# 🗄️ VERİTABANI TASARIMI

## Mevcut Tablolar (Dokunma)

```
tbStok              → Ana ürün tablosu
tbStokSinifi        → Kategori bilgileri
Products            → Quka senkronizasyon durumu
product_images      → Resim senkronizasyon durumu
```

---

## YENİ TABLOLAR

### 1. tbTrendyolAyar (Yapılandırma)
```sql
CREATE TABLE tbTrendyolAyar (
    nAyarID INT IDENTITY(1,1) PRIMARY KEY,
    sSupplierId VARCHAR(50) NOT NULL,
    sApiKey VARCHAR(200) NOT NULL,
    sApiSecret VARCHAR(200) NOT NULL,
    sBaseUrl VARCHAR(200) DEFAULT 'https://api.trendyol.com/sapigw',
    bAktif BIT DEFAULT 1,
    dteOlusturma DATETIME DEFAULT GETDATE(),
    dteGuncelleme DATETIME
)
```

**Örnek Kayıt:**
```sql
INSERT INTO tbTrendyolAyar (sSupplierId, sApiKey, sApiSecret, bAktif)
VALUES ('123456', 'your-api-key', 'your-api-secret', 1)
```

---

### 2. tbTrendyolUrunEsleme (Kritik Tablo) ⭐
```sql
CREATE TABLE tbTrendyolUrunEsleme (
    nEslemeID INT IDENTITY(1,1) PRIMARY KEY,
    nStokID INT NOT NULL,                      -- FK: tbStok.nStokID
    
    -- Sizin Bilgileriniz
    sBizimBarkod VARCHAR(50),                  -- Sizin sisteminizdeki barkod
    sStokKodu VARCHAR(50),                     -- Stok kodu
    
    -- Trendyol Bilgileri (Eşleştirme Sonucu)
    sTrendyolBarkod VARCHAR(50),               -- Trendyol'daki barkod (BuyBox için!)
    nTrendyolProductId BIGINT,                 -- Trendyol ürün ID
    sTrendyolTitle VARCHAR(500),               -- Trendyol'daki ürün adı
    nTrendyolCategoryId INT,                   -- Trendyol kategori ID
    sTrendyolBrand VARCHAR(100),               -- Trendyol marka adı
    sModelCode VARCHAR(100),                   -- Model kodu
    
    -- Durum Bilgileri
    nEslesmeDurumu INT DEFAULT 0,              -- 0=Bekliyor, 1=Eşleşti, 2=Eşleşemedi, 3=Manuel
    nBuyBoxDurumu INT DEFAULT 0,               -- 0=Bilinmiyor, 1=BuyBox'ta, 2=BuyBox dışı
    lBuyBoxFiyat MONEY,                        -- BuyBox'taki en düşük fiyat
    nSaticiSayisi INT,                         -- Kaç satıcı var
    
    -- Senkronizasyon
    nSonFiyat MONEY,                           -- Son gönderilen fiyat
    nSonStok INT,                              -- Son gönderilen stok
    dteSonSenkron DATETIME,                    -- Son senkronizasyon tarihi
    sSonHata VARCHAR(500),                     -- Son hata mesajı
    
    -- Meta
    bManuelKontrolGerekli BIT DEFAULT 0,
    bAktif BIT DEFAULT 1,
    dteOlusturma DATETIME DEFAULT GETDATE(),
    dteGuncelleme DATETIME,
    
    CONSTRAINT FK_TrendyolEsleme_Stok FOREIGN KEY (nStokID) 
        REFERENCES tbStok(nStokID)
)

-- Index'ler
CREATE INDEX IX_TrendyolEsleme_Barkod ON tbTrendyolUrunEsleme(sBizimBarkod)
CREATE INDEX IX_TrendyolEsleme_TrendyolBarkod ON tbTrendyolUrunEsleme(sTrendyolBarkod)
CREATE INDEX IX_TrendyolEsleme_Durum ON tbTrendyolUrunEsleme(nEslesmeDurumu)
```

**Durum Kodları:**
```
nEslesmeDurumu:
  0 = Henüz kontrol edilmedi
  1 = Otomatik eşleşti (barkod tuttu)
  2 = Eşleşme bulunamadı
  3 = Manuel eşleştirildi

nBuyBoxDurumu:
  0 = Bilinmiyor
  1 = BuyBox'ta (satış yapılıyor)
  2 = BuyBox dışında (rekabet var ama kazanamıyoruz)
  3 = Tek satıcı (rekabet yok)
```

---

### 3. tbTrendyolKategori (Kategori Cache)
```sql
CREATE TABLE tbTrendyolKategori (
    nKategoriID INT PRIMARY KEY,              -- Trendyol kategori ID
    sKategoriAdi VARCHAR(200),
    nUstKategoriID INT,
    sYol VARCHAR(500),                        -- Tam kategori yolu
    dteGuncelleme DATETIME DEFAULT GETDATE()
)
```

---

### 4. tbTrendyolMarka (Marka Cache)
```sql
CREATE TABLE tbTrendyolMarka (
    nMarkaID INT PRIMARY KEY,                 -- Trendyol marka ID
    sMarkaAdi VARCHAR(100),
    dteGuncelleme DATETIME DEFAULT GETDATE()
)
```

---

### 5. tbTrendyolLog (İşlem Logları)
```sql
CREATE TABLE tbTrendyolLog (
    nLogID BIGINT IDENTITY(1,1) PRIMARY KEY,
    sIslemTipi VARCHAR(50),                   -- FIYAT_GUNCELLE, STOK_GUNCELLE, ESLESTIR
    sBatchRequestId VARCHAR(100),
    nToplamUrun INT,
    nBasarili INT,
    nBasarisiz INT,
    sDetay NVARCHAR(MAX),                     -- JSON detay
    sKullanici VARCHAR(100),
    dteIslem DATETIME DEFAULT GETDATE()
)
```

---

## SQL SCRIPT (Tüm Tabloları Oluştur)

```sql
-- /app/SQL_BIRLESTIRILMIS/08_TRENDYOL_TABLOLARI.sql

-- =============================================
-- TRENDYOL DİREKT ENTEGRASYON TABLOLARI
-- Tarih: 2026-01-30
-- Açıklama: BuyBox eşleştirme ve direkt API entegrasyonu için
-- =============================================

USE [YONCALINES]
GO

-- 1. Ayar Tablosu
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbTrendyolAyar')
BEGIN
    CREATE TABLE tbTrendyolAyar (
        nAyarID INT IDENTITY(1,1) PRIMARY KEY,
        sSupplierId VARCHAR(50) NOT NULL,
        sApiKey VARCHAR(200) NOT NULL,
        sApiSecret VARCHAR(200) NOT NULL,
        sBaseUrl VARCHAR(200) DEFAULT 'https://api.trendyol.com/sapigw',
        bAktif BIT DEFAULT 1,
        dteOlusturma DATETIME DEFAULT GETDATE(),
        dteGuncelleme DATETIME
    )
    PRINT 'tbTrendyolAyar tablosu olusturuldu'
END
GO

-- 2. Ürün Eşleme Tablosu (Ana tablo)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbTrendyolUrunEsleme')
BEGIN
    CREATE TABLE tbTrendyolUrunEsleme (
        nEslemeID INT IDENTITY(1,1) PRIMARY KEY,
        nStokID INT NOT NULL,
        sBizimBarkod VARCHAR(50),
        sStokKodu VARCHAR(50),
        sTrendyolBarkod VARCHAR(50),
        nTrendyolProductId BIGINT,
        sTrendyolTitle VARCHAR(500),
        nTrendyolCategoryId INT,
        sTrendyolBrand VARCHAR(100),
        sModelCode VARCHAR(100),
        nEslesmeDurumu INT DEFAULT 0,
        nBuyBoxDurumu INT DEFAULT 0,
        lBuyBoxFiyat MONEY,
        nSaticiSayisi INT,
        nSonFiyat MONEY,
        nSonStok INT,
        dteSonSenkron DATETIME,
        sSonHata VARCHAR(500),
        bManuelKontrolGerekli BIT DEFAULT 0,
        bAktif BIT DEFAULT 1,
        dteOlusturma DATETIME DEFAULT GETDATE(),
        dteGuncelleme DATETIME
    )
    
    CREATE INDEX IX_TrendyolEsleme_Barkod ON tbTrendyolUrunEsleme(sBizimBarkod)
    CREATE INDEX IX_TrendyolEsleme_TrendyolBarkod ON tbTrendyolUrunEsleme(sTrendyolBarkod)
    CREATE INDEX IX_TrendyolEsleme_Durum ON tbTrendyolUrunEsleme(nEslesmeDurumu)
    
    PRINT 'tbTrendyolUrunEsleme tablosu olusturuldu'
END
GO

-- 3. Kategori Cache
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbTrendyolKategori')
BEGIN
    CREATE TABLE tbTrendyolKategori (
        nKategoriID INT PRIMARY KEY,
        sKategoriAdi VARCHAR(200),
        nUstKategoriID INT,
        sYol VARCHAR(500),
        dteGuncelleme DATETIME DEFAULT GETDATE()
    )
    PRINT 'tbTrendyolKategori tablosu olusturuldu'
END
GO

-- 4. Marka Cache
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbTrendyolMarka')
BEGIN
    CREATE TABLE tbTrendyolMarka (
        nMarkaID INT PRIMARY KEY,
        sMarkaAdi VARCHAR(100),
        dteGuncelleme DATETIME DEFAULT GETDATE()
    )
    PRINT 'tbTrendyolMarka tablosu olusturuldu'
END
GO

-- 5. Log Tablosu
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbTrendyolLog')
BEGIN
    CREATE TABLE tbTrendyolLog (
        nLogID BIGINT IDENTITY(1,1) PRIMARY KEY,
        sIslemTipi VARCHAR(50),
        sBatchRequestId VARCHAR(100),
        nToplamUrun INT,
        nBasarili INT,
        nBasarisiz INT,
        sDetay NVARCHAR(MAX),
        sKullanici VARCHAR(100),
        dteIslem DATETIME DEFAULT GETDATE()
    )
    PRINT 'tbTrendyolLog tablosu olusturuldu'
END
GO

PRINT '================================'
PRINT 'Tum tablolar basariyla olusturuldu!'
PRINT '================================'
```

---

## SORGULAR

### Eşleşmemiş Ürünleri Bul
```sql
SELECT s.sKodu, s.sAciklama, e.sBizimBarkod, e.nEslesmeDurumu
FROM tbStok s
LEFT JOIN tbTrendyolUrunEsleme e ON s.nStokID = e.nStokID
WHERE e.nEslesmeDurumu IS NULL OR e.nEslesmeDurumu = 0
```

### BuyBox Dışı Ürünler
```sql
SELECT s.sKodu, s.sAciklama, e.sTrendyolBarkod, e.lBuyBoxFiyat, e.nSaticiSayisi
FROM tbTrendyolUrunEsleme e
INNER JOIN tbStok s ON e.nStokID = s.nStokID
WHERE e.nBuyBoxDurumu = 2  -- BuyBox dışında
```

### Senkronizasyon Bekleyenler
```sql
SELECT s.sKodu, s.sAciklama, e.sTrendyolBarkod, e.dteSonSenkron
FROM tbTrendyolUrunEsleme e
INNER JOIN tbStok s ON e.nStokID = s.nStokID
WHERE e.nEslesmeDurumu = 1  -- Eşleşmiş
  AND (e.dteSonSenkron IS NULL OR e.dteSonSenkron < DATEADD(HOUR, -1, GETDATE()))
```
