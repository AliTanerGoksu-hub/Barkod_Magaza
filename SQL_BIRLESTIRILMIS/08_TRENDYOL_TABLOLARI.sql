-- =============================================
-- TRENDYOL DİREKT ENTEGRASYON TABLOLARI
-- Dosya: 08_TRENDYOL_TABLOLARI.sql
-- Tarih: 2026-01-30
-- Açıklama: BuyBox eşleştirme ve direkt API entegrasyonu için
-- 
-- KULLANIM: Bu script'i SQL Server Management Studio'da çalıştırın
-- =============================================

USE [YONCALINES]
GO

PRINT '================================'
PRINT 'Trendyol Tablolari Olusturuluyor...'
PRINT '================================'
PRINT ''

-- =============================================
-- 1. AYAR TABLOSU
-- API bilgilerini saklar
-- =============================================
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
    PRINT '✓ tbTrendyolAyar tablosu olusturuldu'
    
    -- Varsayılan ayarları ekle
    INSERT INTO tbTrendyolAyar (sSupplierId, sApiKey, sApiSecret, sBaseUrl, bAktif)
    VALUES ('708257', 'n4KSHjK0VPTmzlcco4iJ', 'XwWTP5lvWnktDukgz9dn', 'https://apigw.trendyol.com/integration', 1)
    PRINT '  → Varsayilan API ayarlari eklendi'
END
ELSE
BEGIN
    PRINT '○ tbTrendyolAyar tablosu zaten mevcut'
END
GO

-- =============================================
-- 2. ÜRÜN EŞLEME TABLOSU (ANA TABLO)
-- BuyBox eşleştirme bilgilerini saklar
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbTrendyolUrunEsleme')
BEGIN
    CREATE TABLE tbTrendyolUrunEsleme (
        nEslemeID INT IDENTITY(1,1) PRIMARY KEY,
        nStokID INT NOT NULL,                      -- FK: tbStok.nStokID
        
        -- Bizim Bilgilerimiz
        sBizimBarkod VARCHAR(50),                  -- Bizim sistemdeki barkod
        sStokKodu VARCHAR(50),                     -- Stok kodu
        
        -- Trendyol Bilgileri (Eşleştirme Sonucu)
        sTrendyolBarkod VARCHAR(50),               -- Trendyol'daki barkod (BuyBox için kritik!)
        nTrendyolProductId BIGINT,                 -- Trendyol ürün ID
        sTrendyolTitle NVARCHAR(500),              -- Trendyol'daki ürün adı
        nTrendyolCategoryId INT,                   -- Trendyol kategori ID
        sTrendyolBrand NVARCHAR(100),              -- Trendyol marka adı
        sModelCode VARCHAR(100),                   -- Model kodu
        
        -- Durum Bilgileri
        nEslesmeDurumu INT DEFAULT 0,              -- 0=Bekliyor, 1=Eşleşti, 2=Eşleşemedi, 3=Manuel
        nBuyBoxDurumu INT DEFAULT 0,               -- 0=Bilinmiyor, 1=BuyBox'ta, 2=BuyBox dışı, 3=Tek satıcı
        lBuyBoxFiyat MONEY,                        -- BuyBox'taki en düşük fiyat
        nSaticiSayisi INT,                         -- Kaç satıcı var
        
        -- Senkronizasyon
        nSonFiyat MONEY,                           -- Son gönderilen fiyat
        nSonStok INT,                              -- Son gönderilen stok
        dteSonSenkron DATETIME,                    -- Son senkronizasyon tarihi
        sSonHata NVARCHAR(500),                    -- Son hata mesajı
        sSonBatchId VARCHAR(100),                  -- Son batch request ID
        
        -- Meta
        bManuelKontrolGerekli BIT DEFAULT 0,
        bAktif BIT DEFAULT 1,
        dteOlusturma DATETIME DEFAULT GETDATE(),
        dteGuncelleme DATETIME
    )
    PRINT '✓ tbTrendyolUrunEsleme tablosu olusturuldu'
    
    -- Index'ler
    CREATE INDEX IX_TrendyolEsleme_StokID ON tbTrendyolUrunEsleme(nStokID)
    CREATE INDEX IX_TrendyolEsleme_BizimBarkod ON tbTrendyolUrunEsleme(sBizimBarkod)
    CREATE INDEX IX_TrendyolEsleme_TrendyolBarkod ON tbTrendyolUrunEsleme(sTrendyolBarkod)
    CREATE INDEX IX_TrendyolEsleme_Durum ON tbTrendyolUrunEsleme(nEslesmeDurumu)
    CREATE INDEX IX_TrendyolEsleme_BuyBox ON tbTrendyolUrunEsleme(nBuyBoxDurumu)
    PRINT '  → Index''ler olusturuldu'
END
ELSE
BEGIN
    PRINT '○ tbTrendyolUrunEsleme tablosu zaten mevcut'
END
GO

-- =============================================
-- 3. KATEGORİ CACHE TABLOSU
-- Trendyol kategorilerini cache'ler
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbTrendyolKategori')
BEGIN
    CREATE TABLE tbTrendyolKategori (
        nKategoriID INT PRIMARY KEY,              -- Trendyol kategori ID
        sKategoriAdi NVARCHAR(200),
        nUstKategoriID INT,
        sYol NVARCHAR(500),                       -- Tam kategori yolu
        dteGuncelleme DATETIME DEFAULT GETDATE()
    )
    PRINT '✓ tbTrendyolKategori tablosu olusturuldu'
END
ELSE
BEGIN
    PRINT '○ tbTrendyolKategori tablosu zaten mevcut'
END
GO

-- =============================================
-- 4. MARKA CACHE TABLOSU
-- Trendyol markalarını cache'ler
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbTrendyolMarka')
BEGIN
    CREATE TABLE tbTrendyolMarka (
        nMarkaID INT PRIMARY KEY,                 -- Trendyol marka ID
        sMarkaAdi NVARCHAR(100),
        dteGuncelleme DATETIME DEFAULT GETDATE()
    )
    PRINT '✓ tbTrendyolMarka tablosu olusturuldu'
END
ELSE
BEGIN
    PRINT '○ tbTrendyolMarka tablosu zaten mevcut'
END
GO

-- =============================================
-- 5. LOG TABLOSU
-- Tüm API işlemlerini loglar
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbTrendyolLog')
BEGIN
    CREATE TABLE tbTrendyolLog (
        nLogID BIGINT IDENTITY(1,1) PRIMARY KEY,
        sIslemTipi VARCHAR(50),                   -- FIYAT_GUNCELLE, STOK_GUNCELLE, ESLESTIR, BAGLANTI_TEST
        sBatchRequestId VARCHAR(100),
        nToplamUrun INT,
        nBasarili INT,
        nBasarisiz INT,
        sDetay NVARCHAR(MAX),                     -- JSON detay
        sKullanici VARCHAR(100),
        dteIslem DATETIME DEFAULT GETDATE()
    )
    PRINT '✓ tbTrendyolLog tablosu olusturuldu'
    
    CREATE INDEX IX_TrendyolLog_Tarih ON tbTrendyolLog(dteIslem DESC)
    CREATE INDEX IX_TrendyolLog_Tip ON tbTrendyolLog(sIslemTipi)
END
ELSE
BEGIN
    PRINT '○ tbTrendyolLog tablosu zaten mevcut'
END
GO

-- =============================================
-- 6. TEST BARKODLARI (BuyBox'a girememiş ürünler)
-- =============================================
PRINT ''
PRINT '================================'
PRINT 'Test Barkodlari:'
PRINT '================================'
PRINT '8684053186724'
PRINT '8684053232339'
PRINT '8684053232308'
PRINT '8684053425007'
PRINT '8684053424994'
PRINT ''

-- =============================================
-- ÖZET
-- =============================================
PRINT ''
PRINT '================================'
PRINT 'KURULUM TAMAMLANDI!'
PRINT '================================'
PRINT ''
PRINT 'Olusturulan Tablolar:'
PRINT '  1. tbTrendyolAyar        - API ayarlari'
PRINT '  2. tbTrendyolUrunEsleme  - Urun eslestirme (ANA TABLO)'
PRINT '  3. tbTrendyolKategori    - Kategori cache'
PRINT '  4. tbTrendyolMarka       - Marka cache'
PRINT '  5. tbTrendyolLog         - Islem loglari'
PRINT ''
PRINT 'Durum Kodlari:'
PRINT '  nEslesmeDurumu: 0=Bekliyor, 1=Eslesti, 2=Eslesemedi, 3=Manuel'
PRINT '  nBuyBoxDurumu:  0=Bilinmiyor, 1=BuyBox''ta, 2=BuyBox disi, 3=Tek satici'
PRINT ''
GO
