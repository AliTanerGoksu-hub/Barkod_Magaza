# Merkezi E-Ticaret Analiz Cache Sistemi

## Genel Bakis

Bu dokumantasyon, Barkod_Magaza uygulamasindaki merkezi e-ticaret analiz cache sistemini aciklamaktadir. Bu sistem, tum analiz formlarinin veri kaynaklarini birlestirerek performansi artirmak ve API cagrilarini azaltmak icin tasarlanmistir.

## Mimari

### Veritabani Tablolari

#### tbETicaretAnaliz
Ana cache tablosu. Tum e-ticaret analiz verilerini depolar.

```sql
CREATE TABLE tbETicaretAnaliz (
    nID INT IDENTITY(1,1) PRIMARY KEY,
    nStokID INT,
    sBarkod NVARCHAR(50) NOT NULL,
    sStokKodu NVARCHAR(50),
    sModel NVARCHAR(100),
    sUrunAdi NVARCHAR(500),
    sRenk NVARCHAR(50),
    sBeden NVARCHAR(50),
    sKategori NVARCHAR(200),
    sPazaryeri NVARCHAR(50) DEFAULT 'Trendyol',
    
    -- Fiyat Bilgileri
    dBizimFiyat DECIMAL(18,2) DEFAULT 0,
    dEnDusukRakipFiyat DECIMAL(18,2) DEFAULT 0,
    dOrtalamaRakipFiyat DECIMAL(18,2) DEFAULT 0,
    iRakipSayisi INT DEFAULT 0,
    dFiyatFarki DECIMAL(18,2) DEFAULT 0,
    fFiyatFarkYuzde DECIMAL(5,2) DEFAULT 0,
    
    -- Satis Verileri
    iSatis7Gun INT DEFAULT 0,
    iSatis30Gun INT DEFAULT 0,
    iSatis90Gun INT DEFAULT 0,
    dSatisTutari30Gun DECIMAL(18,2) DEFAULT 0,
    
    -- Iade Verileri
    iIadeSayisi INT DEFAULT 0,
    iIptalSayisi INT DEFAULT 0,
    iTeslimEdilemedi INT DEFAULT 0,
    iToplamIade INT DEFAULT 0,
    fIadeOrani DECIMAL(5,2) DEFAULT 0,
    
    -- Yorum/Puan Verileri
    iYorumSayisi INT DEFAULT 0,
    fOrtalamaPuan DECIMAL(3,1) DEFAULT 0,
    iPozitifYorum INT DEFAULT 0,
    iNegatifYorum INT DEFAULT 0,
    iNotrYorum INT DEFAULT 0,
    sSikSikayet NVARCHAR(200),
    sSikOvergu NVARCHAR(200),
    
    -- Favori/Sepet Verileri (Tahmini)
    iGoruntulenmeSayisi INT DEFAULT 0,
    iFavoriSayisi INT DEFAULT 0,
    iSepetSayisi INT DEFAULT 0,
    fFavoriOrani DECIMAL(5,2) DEFAULT 0,
    fSepetOrani DECIMAL(5,2) DEFAULT 0,
    fDonusumOrani DECIMAL(5,2) DEFAULT 0,
    
    -- Stok Bilgileri
    iStokMiktari INT DEFAULT 0,
    bStokVar BIT DEFAULT 1,
    
    -- Meta Bilgiler
    sContentId NVARCHAR(50),
    dteSonGuncelleme DATETIME DEFAULT GETDATE()
)
```

#### tbETicaretRakipDetay
Rakip satici detay bilgilerini depolar (her urun icin birden fazla rakip olabilir).

```sql
CREATE TABLE tbETicaretRakipDetay (
    nID INT IDENTITY(1,1) PRIMARY KEY,
    sBarkod NVARCHAR(50) NOT NULL,
    sRakipMagaza NVARCHAR(200),
    sMagazaId NVARCHAR(50),
    dFiyat DECIMAL(18,2) DEFAULT 0,
    dIndirimiFiyat DECIMAL(18,2) DEFAULT 0,
    dKargoUcreti DECIMAL(18,2) DEFAULT 0,
    fPuan DECIMAL(3,1) DEFAULT 0,
    iYorumSayisi INT DEFAULT 0,
    bStokVar BIT DEFAULT 1,
    bAnaSatici BIT DEFAULT 0,
    dteSonGuncelleme DATETIME DEFAULT GETDATE()
)
```

### Ana Fonksiyonlar (PazaryeriAPIHelper.vb)

#### GetAllAnalizData
Tum urunler icin analiz verilerini getirir. Otomatik cache kontrolu yapar.

```vb
Public Shared Function GetAllAnalizData(
    conn As OleDbConnection, 
    Optional pazaryeri As String = "", 
    Optional kategori As String = "",
    Optional progressCallback As Action(Of Integer, Integer, String) = Nothing
) As List(Of ETicaretAnalizData)
```

**Parametreler:**
- `conn`: Veritabani baglantisi
- `pazaryeri`: Filtrelenecek pazaryeri (opsiyonel)
- `kategori`: Filtrelenecek kategori (opsiyonel)
- `progressCallback`: Ilerleme durumu callback fonksiyonu

**Donus:** `ETicaretAnalizData` listesi

#### GetAnalizData
Tek bir urun icin analiz verisi getirir.

```vb
Public Shared Function GetAnalizData(
    barkod As String, 
    nStokID As Integer, 
    conn As OleDbConnection
) As ETicaretAnalizData
```

#### IsCacheValid
Cache'in guncel olup olmadigini kontrol eder.

```vb
Public Shared Function IsCacheValid(
    barkod As String, 
    conn As OleDbConnection
) As Boolean
```

### Cache Suresi

Cache suresi `CACHE_SURESI_SAAT` degiskeni ile belirlenir. Varsayilan deger: **6 saat**

```vb
Private Shared ReadOnly CACHE_SURESI_SAAT As Integer = 6
```

### Veri Modeli (ETicaretAnalizData)

```vb
Public Class ETicaretAnalizData
    Public Property nStokID As Integer
    Public Property Barkod As String
    Public Property StokKodu As String
    Public Property Model As String
    Public Property UrunAdi As String
    Public Property Renk As String
    Public Property Beden As String
    Public Property Kategori As String
    Public Property Pazaryeri As String
    
    ' Fiyat
    Public Property BizimFiyat As Decimal
    Public Property EnDusukRakipFiyat As Decimal
    Public Property OrtalamaRakipFiyat As Decimal
    Public Property RakipSayisi As Integer
    Public Property FiyatFarki As Decimal
    Public Property FiyatFarkYuzde As Decimal
    
    ' Satis
    Public Property Satis7Gun As Integer
    Public Property Satis30Gun As Integer
    Public Property Satis90Gun As Integer
    Public Property SatisTutari30Gun As Decimal
    
    ' Iade
    Public Property IadeSayisi As Integer
    Public Property IptalSayisi As Integer
    Public Property TeslimEdilemedi As Integer
    Public Property ToplamIade As Integer
    Public Property IadeOrani As Decimal
    
    ' Yorum
    Public Property YorumSayisi As Integer
    Public Property OrtalamaPuan As Decimal
    Public Property PozitifYorum As Integer
    Public Property NegatifYorum As Integer
    Public Property NotrYorum As Integer
    Public Property SikSikayet As String
    Public Property SikOvergu As String
    
    ' Favori/Sepet
    Public Property GoruntulenmeSayisi As Integer
    Public Property FavoriSayisi As Integer
    Public Property SepetSayisi As Integer
    Public Property FavoriOrani As Decimal
    Public Property SepetOrani As Decimal
    Public Property DonusumOrani As Decimal
    
    ' Stok
    Public Property StokMiktari As Integer
    Public Property StokVar As Boolean
    
    Public Property ContentId As String
    Public Property SonGuncelleme As DateTime
End Class
```

## Form Entegrasyonlari

Asagidaki formlar merkezi cache sistemini kullanmaktadir:

### 1. frm_RakipFiyatOtomasyonu
Rakip fiyat analizi ve otomatik fiyat onerisi.

**Kullanilan veriler:**
- BizimFiyat
- EnDusukRakipFiyat
- OrtalamaRakipFiyat
- RakipSayisi
- FiyatFarki
- FiyatFarkYuzde

### 2. frm_YorumAnalizi
Musteri yorumlari ve duygu analizi.

**Kullanilan veriler:**
- YorumSayisi
- OrtalamaPuan
- PozitifYorum, NegatifYorum, NotrYorum
- SikSikayet, SikOvergu

### 3. frm_FavoriSepetAnalizi
Favori ve sepete eklenme oranlari analizi.

**Kullanilan veriler:**
- GoruntulenmeSayisi
- FavoriSayisi, FavoriOrani
- SepetSayisi, SepetOrani
- DonusumOrani

### 4. frm_IadeRiskiTahmini
Iade riski tahmin ve analizi.

**Kullanilan veriler:**
- Satis90Gun
- IadeSayisi, IptalSayisi, TeslimEdilemedi
- ToplamIade, IadeOrani

### 5. frm_KampanyaOnerisi
Otomatik kampanya onerisi.

**Kullanilan veriler:**
- BizimFiyat
- Satis7Gun, Satis30Gun
- StokMiktari
- EnDusukRakipFiyat, FiyatFarkYuzde

## Akis Diagrami

```
Form Acilir
     |
     v
GetAllAnalizData() cagrilir
     |
     v
Cache suresi kontrol edilir
     |
     +---> Cache GUNCEL --> Cache'den veri okunur
     |                            |
     v                            v
Cache ESKI/YOK             Veri dondurulur
     |
     v
Veritabanindan urunler cekilir
     |
     v
Her urun icin:
  - Satis verileri hesaplanir
  - Tahmini degerler olusturulur
     |
     v
Cache'e kaydedilir (SaveAnalizToCache)
     |
     v
Veri dondurulur
```

## Tahmini Degerler

Trendyol/Hepsiburada API'leri favori/sepet/goruntulenme verisi saglamadigindan, bu degerler satis verilerine dayali olarak tahmin edilir:

| Metrik | Formul |
|--------|--------|
| Goruntulenme | Satis30Gun * 65 |
| Sepet | Satis30Gun * 4 |
| Favori | Satis30Gun * 2.5 |
| Yorum | Satis30Gun * 0.07 |
| FavoriOrani | Favori / Goruntulenme * 100 |
| SepetOrani | Sepet / Goruntulenme * 100 |
| DonusumOrani | Satis / Goruntulenme * 100 |

## Bakim ve Temizlik

### CleanExpiredAnalysisCache
7 gunluk eski cache kayitlarini temizler.

```vb
Public Shared Sub CleanExpiredAnalysisCache(conn As OleDbConnection)
```

Bu fonksiyon periyodik olarak cagrilarak veritabani boyutunun kontrol altinda tutulmasi saglanmalidir.

### GetCacheLastUpdateTime
Cache'in son guncelleme zamanini dondurur.

```vb
Public Shared Function GetCacheLastUpdateTime(conn As OleDbConnection) As DateTime
```

### GetCacheRecordCount
Cache'deki toplam kayit sayisini dondurur.

```vb
Public Shared Function GetCacheRecordCount(conn As OleDbConnection) As Integer
```

## Dikkat Edilmesi Gerekenler

1. **API Limitleri:** Trendyol/Hepsiburada API'lerinin rate limit'leri vardir. Cache sistemi bu limitleri asmamak icin tasarlanmistir.

2. **Veri Tutarliligi:** Cache verileri belirli bir sure icinde guncel kalmayabilir. Kritik kararlar icin cache'i yenilemek gerekebilir.

3. **Veritabani Boyutu:** Cok fazla urun varsa cache tablosu buyuyebilir. Periyodik temizlik onerilir.

4. **Baglanti Yonetimi:** Her cache islemi icin ayri bir baglanti kullanilmaktadir. Connection pooling aktif olmalidir.

## Versiyon Gecmisi

| Tarih | Versiyon | Degisiklik |
|-------|----------|------------|
| 2026-02-21 | 1.0 | Ilk surum - merkezi cache sistemi |

---

*Bu dokumantasyon Barkod_Magaza e-ticaret entegrasyon projesi icin hazirlanmistir.*
