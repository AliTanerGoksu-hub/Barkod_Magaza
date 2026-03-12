# E-Ticaret Merkezi Cache Sistemi Dokümantasyonu

## Genel Bakış

Bu dokümantasyon, Barkod_Magaza uygulamasındaki merkezi e-ticaret analiz cache sistemini açıklar.
Sistem, tüm analiz formlarının (Rakip Fiyat, Yorum, Favori/Sepet, İade Riski, Kampanya) 
ortak bir veri kaynağından beslenmesini sağlar.

---

## 1. Tablolar

### 1.1 tbETicaretAnaliz (Ana Cache Tablosu)

Tüm analiz verilerini merkezi olarak tutan ana tablo.

| Kolon Adı | Veri Tipi | Açıklama |
|-----------|-----------|----------|
| **nID** | INT IDENTITY | Primary Key |
| **nStokID** | INT | tbStok tablosu ile ilişki |
| **sBarkod** | NVARCHAR(50) | Ürün barkodu (INDEX) |
| **sStokKodu** | NVARCHAR(50) | Stok kodu |
| **sModel** | NVARCHAR(100) | Model kodu |
| **sUrunAdi** | NVARCHAR(500) | Ürün açıklaması |
| **sRenk** | NVARCHAR(50) | Renk |
| **sBeden** | NVARCHAR(50) | Beden |
| **sKategori** | NVARCHAR(200) | Kategori |
| **sPazaryeri** | NVARCHAR(50) | Pazaryeri (Trendyol, Hepsiburada, vb.) |
| | | |
| **dBizimFiyat** | DECIMAL(18,2) | Bizim satış fiyatımız |
| **dEnDusukRakipFiyat** | DECIMAL(18,2) | En düşük rakip fiyatı |
| **dOrtalamaRakipFiyat** | DECIMAL(18,2) | Ortalama rakip fiyatı |
| **iRakipSayisi** | INT | Toplam rakip sayısı |
| **dFiyatFarki** | DECIMAL(18,2) | Fiyat farkı (TL) |
| **fFiyatFarkYuzde** | DECIMAL(5,2) | Fiyat farkı (%) |
| | | |
| **iSatis7Gun** | INT | Son 7 gün satış adedi |
| **iSatis30Gun** | INT | Son 30 gün satış adedi |
| **iSatis90Gun** | INT | Son 90 gün satış adedi |
| **dSatisTutari30Gun** | DECIMAL(18,2) | Son 30 gün satış tutarı |
| | | |
| **iIadeSayisi** | INT | API'den gelen iade sayısı (Returned) |
| **iIptalSayisi** | INT | API'den gelen iptal sayısı (Cancelled) |
| **iTeslimEdilemedi** | INT | API'den gelen teslim edilemedi (UnDelivered) |
| **iToplamIade** | INT | Toplam iade (DB + API) |
| **fIadeOrani** | DECIMAL(5,2) | İade oranı (%) |
| | | |
| **iYorumSayisi** | INT | Toplam yorum sayısı |
| **fOrtalamaPuan** | DECIMAL(3,1) | Ortalama puan (1-5) |
| **iPozitifYorum** | INT | Pozitif yorum sayısı (4-5 puan) |
| **iNegatifYorum** | INT | Negatif yorum sayısı (1-2 puan) |
| **iNotrYorum** | INT | Nötr yorum sayısı (3 puan) |
| **sSikSikayet** | NVARCHAR(200) | En sık şikayet konusu |
| **sSikOvergu** | NVARCHAR(200) | En sık övgü konusu |
| | | |
| **iGoruntulenmeSayisi** | INT | Tahmini görüntülenme |
| **iFavoriSayisi** | INT | Tahmini favoriye ekleme |
| **iSepetSayisi** | INT | Tahmini sepete ekleme |
| **fFavoriOrani** | DECIMAL(5,2) | Favori oranı (%) |
| **fSepetOrani** | DECIMAL(5,2) | Sepet oranı (%) |
| **fDonusumOrani** | DECIMAL(5,2) | Dönüşüm oranı (%) |
| | | |
| **iStokMiktari** | INT | Mevcut stok |
| **bStokVar** | BIT | Stok var mı? |
| **sContentId** | NVARCHAR(50) | Trendyol Content ID |
| **dteSonGuncelleme** | DATETIME | Son güncelleme zamanı |

**Index'ler:**
- IX_ETicaretAnaliz_Barkod (sBarkod)
- IX_ETicaretAnaliz_StokID (nStokID)
- IX_ETicaretAnaliz_Pazaryeri (sPazaryeri)
- IX_ETicaretAnaliz_Guncelleme (dteSonGuncelleme)

### 1.2 tbETicaretRakipDetay (Rakip Detay Tablosu)

Her ürün için birden fazla rakip bilgisi tutulabilir.

| Kolon Adı | Veri Tipi | Açıklama |
|-----------|-----------|----------|
| **nID** | INT IDENTITY | Primary Key |
| **sBarkod** | NVARCHAR(50) | Ürün barkodu (INDEX) |
| **sRakipMagaza** | NVARCHAR(200) | Rakip mağaza adı |
| **sMagazaId** | NVARCHAR(50) | Mağaza ID |
| **dFiyat** | DECIMAL(18,2) | Liste fiyatı |
| **dIndirimiFiyat** | DECIMAL(18,2) | İndirimli fiyat |
| **dKargoUcreti** | DECIMAL(18,2) | Kargo ücreti |
| **fPuan** | DECIMAL(3,1) | Mağaza puanı |
| **iYorumSayisi** | INT | Mağaza yorum sayısı |
| **bStokVar** | BIT | Stok durumu |
| **bAnaSatici** | BIT | Ana satıcı mı? |
| **dteSonGuncelleme** | DATETIME | Son güncelleme |

---

## 2. Veri Sınıfları

### 2.1 ETicaretAnalizData

Merkezi veri modeli - tüm formlar bu sınıfı kullanır.

```vb
Public Class ETicaretAnalizData
    ' Temel Bilgiler
    Public Property nStokID As Integer
    Public Property Barkod As String
    Public Property StokKodu As String
    Public Property Model As String
    Public Property UrunAdi As String
    Public Property Renk As String
    Public Property Beden As String
    Public Property Kategori As String
    Public Property Pazaryeri As String = "Trendyol"
    
    ' Fiyat Bilgileri
    Public Property BizimFiyat As Decimal
    Public Property EnDusukRakipFiyat As Decimal
    Public Property OrtalamaRakipFiyat As Decimal
    Public Property RakipSayisi As Integer
    Public Property FiyatFarki As Decimal
    Public Property FiyatFarkYuzde As Decimal
    
    ' Satış Verileri
    Public Property Satis7Gun As Integer
    Public Property Satis30Gun As Integer
    Public Property Satis90Gun As Integer
    Public Property SatisTutari30Gun As Decimal
    
    ' İade Verileri
    Public Property IadeSayisi As Integer        ' Returned
    Public Property IptalSayisi As Integer       ' Cancelled
    Public Property TeslimEdilemedi As Integer   ' UnDelivered
    Public Property ToplamIade As Integer
    Public Property IadeOrani As Decimal
    
    ' Yorum/Puan Verileri
    Public Property YorumSayisi As Integer
    Public Property OrtalamaPuan As Decimal
    Public Property PozitifYorum As Integer
    Public Property NegatifYorum As Integer
    Public Property NotrYorum As Integer
    Public Property SikSikayet As String
    Public Property SikOvergu As String
    
    ' Favori/Sepet Verileri
    Public Property GoruntulenmeSayisi As Integer
    Public Property FavoriSayisi As Integer
    Public Property SepetSayisi As Integer
    Public Property FavoriOrani As Decimal
    Public Property SepetOrani As Decimal
    Public Property DonusumOrani As Decimal
    
    ' Stok Bilgileri
    Public Property StokMiktari As Integer
    Public Property StokVar As Boolean
    
    ' Meta
    Public Property ContentId As String
    Public Property SonGuncelleme As DateTime
End Class
```

### 2.2 IadeIstatistik

API'den gelen iade verilerini tutar.

```vb
Public Class IadeIstatistik
    Public Property Barkod As String
    Public Property UrunAdi As String
    Public Property ToplamSatis As Integer
    Public Property ToplamIade As Integer
    Public Property IadeSayisi As Integer        ' Returned
    Public Property IptalSayisi As Integer       ' Cancelled
    Public Property TeslimEdilemedi As Integer   ' UnDelivered
    Public Property IadeOrani As Decimal
    Public ReadOnly Property RiskSeviyesi As String ' YÜKSEK/ORTA/DÜŞÜK/ÇOK DÜŞÜK
End Class
```

### 2.3 TrendyolCompetitor

Rakip satıcı bilgilerini tutar.

```vb
Public Class TrendyolCompetitor
    Public Property MerchantId As String
    Public Property MerchantName As String
    Public Property Price As Decimal
    Public Property DiscountedPrice As Decimal
    Public Property OriginalPrice As Decimal
    Public Property FreeShipping As Boolean
    Public Property ShippingFee As Decimal
    Public Property Rating As Decimal
    Public Property ReviewCount As Integer
    Public Property InStock As Boolean
    Public Property IsMainMerchant As Boolean
    Public ReadOnly Property TotalPrice As Decimal ' DiscountedPrice + ShippingFee
End Class
```

---

## 3. Cache Mantığı

### 3.1 Cache Süresi

```vb
Private Shared ReadOnly CACHE_SURESI_SAAT As Integer = 6
```

Cache verileri **6 saat** geçerlidir. Bu süre dolduğunda otomatik güncellenir.

### 3.2 Akış Diyagramı

```
Form Açılır
    ↓
GetAllAnalizData() çağrılır
    ↓
IsCacheValid() kontrolü
    ↓
┌─────────────────┴─────────────────┐
↓ EVET (Süre dolmamış)              ↓ HAYIR (Süre dolmuş veya veri yok)
↓                                   ↓
Cache'den oku                       Veritabanından çek
↓                                   ↓
Form'a döndür                       Hesaplamaları yap
                                    ↓
                                    Cache'e kaydet
                                    ↓
                                    Form'a döndür
```

### 3.3 Cache Kontrolü

```vb
Public Shared Function IsCacheValid(barkod As String, conn As OleDbConnection) As Boolean
    Dim cacheSuresiDakika As Integer = CACHE_SURESI_SAAT * 60  ' 360 dakika
    
    Dim sql As String = "SELECT COUNT(*) FROM tbETicaretAnaliz 
        WHERE sBarkod = ? AND DATEDIFF(minute, dteSonGuncelleme, GETDATE()) < ?"
    
    Return CInt(cmd.ExecuteScalar()) > 0
End Function
```

---

## 4. API Fonksiyonları

### 4.1 GetAllAnalizData()

Tüm ürünler için analiz verisini getirir. Form yüklenirken çağrılır.

```vb
Public Shared Function GetAllAnalizData(
    conn As OleDbConnection, 
    Optional pazaryeri As String = "", 
    Optional kategori As String = "",
    Optional progressCallback As Action(Of Integer, Integer, String) = Nothing
) As List(Of ETicaretAnalizData)
```

**Parametreler:**
- `conn`: Veritabanı bağlantısı
- `pazaryeri`: Filtre (Trendyol, Hepsiburada, vb. veya boş = Tümü)
- `kategori`: Kategori filtresi
- `progressCallback`: İlerleme bildirimi için callback

**Dönüş:** List(Of ETicaretAnalizData)

### 4.2 GetAnalizData()

Tek bir ürün için analiz verisini getirir.

```vb
Public Shared Function GetAnalizData(
    barkod As String, 
    nStokID As Integer, 
    conn As OleDbConnection
) As ETicaretAnalizData
```

### 4.3 GetIadeIstatistikleri()

Trendyol API'den iade siparişlerini çeker.

```vb
Public Shared Function GetIadeIstatistikleri(
    startDate As DateTime, 
    endDate As DateTime
) As Dictionary(Of String, IadeIstatistik)
```

**İade Status Değerleri:**
- `Cancelled`: İptal edilmiş
- `Returned`: İade edilmiş
- `UnDelivered`: Teslim edilememiş

### 4.4 GetTrendyolReturnedOrders()

Trendyol Seller API'den iade siparişlerini çeker.

```vb
Public Shared Function GetTrendyolReturnedOrders(
    Optional startDate As DateTime = Nothing, 
    Optional endDate As DateTime = Nothing
) As List(Of TrendyolOrder)
```

---

## 5. Tahmini Değer Hesaplamaları

API'den doğrudan alınamayan veriler (favori, sepet, görüntülenme) satış verilerine dayalı olarak tahmin edilir.

### 5.1 Formüller

```vb
Private Shared Sub CalculateEstimatedValues(data As ETicaretAnalizData)
    If data.Satis30Gun > 0 Then
        ' Görüntülenme tahmini (satışın ~65x'i)
        data.GoruntulenmeSayisi = data.Satis30Gun * 65
        
        ' Sepet tahmini (satışın ~4x'i)
        data.SepetSayisi = data.Satis30Gun * 4
        
        ' Favori tahmini (satışın ~2.5x'i)
        data.FavoriSayisi = CInt(data.Satis30Gun * 2.5)
        
        ' Yorum tahmini (satışın ~%7'si)
        data.YorumSayisi = CInt(data.Satis30Gun * 0.07)
        
        ' Oranlar
        data.FavoriOrani = (FavoriSayisi / GoruntulenmeSayisi) * 100
        data.SepetOrani = (SepetSayisi / GoruntulenmeSayisi) * 100
        data.DonusumOrani = (Satis30Gun / GoruntulenmeSayisi) * 100
    End If
End Sub
```

### 5.2 Puan Tahmini (İade Oranına Göre)

| İade Oranı | Tahmini Puan |
|------------|--------------|
| < %5 | 4.5 |
| %5 - %10 | 4.0 |
| %10 - %20 | 3.5 |
| > %20 | 3.0 |

---

## 6. Formların Cache Kullanımı

### 6.1 frm_FavoriSepetAnalizi

```vb
Private Sub LoadAnalysisDataFromCache()
    Dim cacheData = PazaryeriAPIHelper.GetAllAnalizData(conn, pazaryeri, kategori, progressCallback)
    
    For Each cacheItem In cacheData
        Dim analiz As New FavoriSepetAnaliz()
        analiz.FavoriSayisi = cacheItem.FavoriSayisi
        analiz.SepetSayisi = cacheItem.SepetSayisi
        analiz.GoruntulenmeSayisi = cacheItem.GoruntulenmeSayisi
        ' ...
    Next
End Sub
```

### 6.2 frm_IadeRiskiTahmini

```vb
Private Sub AnalyzeIadeRiskiFromCache()
    Dim cacheData = PazaryeriAPIHelper.GetAllAnalizData(conn, pazaryeri, kategori, progressCallback)
    
    For Each cacheItem In cacheData
        Dim analiz As New IadeAnaliz()
        analiz.ToplamSatis = cacheItem.Satis90Gun
        analiz.ToplamIade = cacheItem.ToplamIade
        analiz.IadeOrani = cacheItem.IadeOrani
        analiz.IadeNedenleri = $"İade: {cacheItem.IadeSayisi}, İptal: {cacheItem.IptalSayisi}"
        ' ...
    Next
End Sub
```

### 6.3 frm_KampanyaOnerisi

```vb
Private Sub AnalyzeKampanyaFromCache()
    Dim cacheData = PazaryeriAPIHelper.GetAllAnalizData(conn, pazaryeri, kategori, progressCallback)
    
    For Each cacheItem In cacheData
        Dim kampanya As New KampanyaOneri()
        kampanya.MevcutFiyat = cacheItem.BizimFiyat
        kampanya.RakipFiyat = cacheItem.EnDusukRakipFiyat
        kampanya.Satis30Gun = cacheItem.Satis30Gun
        ' ...
    Next
End Sub
```

### 6.4 frm_YorumAnalizi

```vb
Private Sub AnalyzeYorumlarFromCache()
    Dim cacheData = PazaryeriAPIHelper.GetAllAnalizData(conn, pazaryeri, kategori, progressCallback)
    
    For Each cacheItem In cacheData
        Dim analiz As New YorumAnaliz()
        analiz.ToplamYorum = cacheItem.YorumSayisi
        analiz.OrtPuan = cacheItem.OrtalamaPuan
        analiz.SikSikayet = cacheItem.SikSikayet
        ' ...
    Next
End Sub
```

### 6.5 frm_RakipFiyatOtomasyonu

```vb
Private Sub AnalyzeProductsFromCache()
    Dim cacheData = PazaryeriAPIHelper.GetAllAnalizData(conn, pazaryeri, kategori, progressCallback)
    
    For Each cacheItem In cacheData
        Dim rakipAnaliz As New RakipAnaliz()
        rakipAnaliz.BizimFiyat = cacheItem.BizimFiyat
        rakipAnaliz.EnDusukRakip = cacheItem.EnDusukRakipFiyat
        rakipAnaliz.RakipSayisi = cacheItem.RakipSayisi
        ' ...
    Next
End Sub
```

---

## 7. Veri Kaynakları

### 7.1 Veritabanı Tabloları

| Veri | Kaynak Tablo | Açıklama |
|------|--------------|----------|
| Ürün Bilgisi | tbStok | sKodu, sModel, sAciklama, sRenk, sBeden |
| Barkod | tbStokBarkodu | sBarkod |
| Fiyat | tbStokFiyati | lFiyat (sFiyatTipi'ye göre) |
| Satış | tbStokFisiDetayi + tbStokFisiMaster | sFisTipi='FS ', lCikisMiktar1 > 0 |
| İade | tbStokFisiDetayi + tbStokFisiMaster | sFisTipi='FI ' veya lCikisMiktar1 < 0 |
| Kategori | tbSSinif4 | sAciklama |
| Stok | tbStok | Hesaplanır (giriş - çıkış) |

### 7.2 API Kaynakları

| Veri | API | Endpoint |
|------|-----|----------|
| İade Siparişleri | Trendyol Seller API | /suppliers/{sellerId}/orders?status=Returned |
| İptal Siparişleri | Trendyol Seller API | /suppliers/{sellerId}/orders?status=Cancelled |
| Ürün Bilgisi | Trendyol Seller API | /suppliers/{sellerId}/products?barcode={barcode} |
| Yorumlar | Trendyol Public API | /discovery-web-productgw-service/api/productGroup/{contentId}/reviews |

---

## 8. Hata Yönetimi

### 8.1 Loglama

Tüm işlemler `EticaretLogger` ile loglanır:

```vb
EticaretLogger.LogInfo("Cache'den 500 ürün yüklendi")
EticaretLogger.LogError("API hatası", ex)
EticaretLogger.LogWarning("Cache süresi dolmuş, güncelleniyor")
```

Log dosyası konumu: `C:\eticaret\log\`

### 8.2 Hata Durumları

| Hata | Çözüm |
|------|-------|
| API bağlantı hatası | Veritabanı verilerini kullan |
| Cache tablosu yok | EnsureETicaretAnalizTable() ile oluştur |
| Barkod bulunamadı | Boş veri döndür |
| Timeout | CommandTimeout = 120 saniye |

---

## 9. Performans Optimizasyonları

1. **Cache Kullanımı**: 6 saatlik cache ile gereksiz sorguları önle
2. **Toplu Sorgu**: Her form açılışında tek sorgu ile tüm verileri çek
3. **Index'ler**: sBarkod, nStokID, dteSonGuncelleme alanlarında index
4. **Async İşlemler**: UI'ı dondurmamak için Task.Run() kullan
5. **Progress Callback**: Kullanıcıya ilerleme bilgisi göster

---

## 10. Gelecek Geliştirmeler

- [ ] Rakip fiyat için Trendyol public API entegrasyonu (Cloudflare bypass)
- [ ] Hepsiburada API entegrasyonu
- [ ] N11 API entegrasyonu
- [ ] Cache süresinin kullanıcı tarafından ayarlanabilmesi
- [ ] Otomatik cache yenileme (arka plan görevi)

---

## 11. Sorun Giderme

### 11.1 Cache Güncellenmiyor

```sql
-- Cache durumunu kontrol et
SELECT TOP 10 sBarkod, dteSonGuncelleme, 
    DATEDIFF(minute, dteSonGuncelleme, GETDATE()) AS DakikaOnce
FROM tbETicaretAnaliz 
ORDER BY dteSonGuncelleme DESC
```

### 11.2 Veri Gelmiyor

1. Log dosyasını kontrol et: `C:\eticaret\log\eticaret_*.log`
2. tbETicaretAnaliz tablosunu kontrol et
3. API ayarlarını kontrol et: `tbPazaryeriAyar`

### 11.3 Cache'i Manuel Temizleme

```sql
-- Tüm cache'i temizle
DELETE FROM tbETicaretAnaliz

-- Süresi dolmuş kayıtları temizle
DELETE FROM tbETicaretAnaliz 
WHERE DATEDIFF(day, dteSonGuncelleme, GETDATE()) > 7
```

---

**Son Güncelleme:** 2026-02-23
**Versiyon:** 1.0
**Yazar:** E-Ticaret Entegrasyon Sistemi
