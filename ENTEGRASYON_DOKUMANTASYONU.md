# E-Ticaret Entegrasyon Sistemi - Çoklu API Desteği

## 📋 Proje Özeti

Bu dokümantasyon, Quka E-Ticaret senkronizasyon sisteminin **çoklu API desteği** için yapılacak değişiklikleri ve mevcut sistemin analizini içerir.

### Amaç
Bazı müşterilerin **Quka Web API entegrasyon paketi VAR**, bazılarının **YOK**. Her iki müşteri tipinin de aynı arayüz üzerinden veri gönderip alabilmesi için sisteme seçmeli gönderim modu eklenmesi gerekmektedir.

| Mod | Hedef Müşteri | API Endpoint Formatı |
|-----|---------------|---------------------|
| **API (Doğrudan)** | Web API paketi OLAN | `https://api.site.com/v1/product/save` |
| **PHP** | Web API paketi OLMAYAN | `https://site.com/ajax.php?page=php_v1&method=product` |

---

## 🔧 OTOMATİK URL DÖNÜŞÜMÜ

Kullanıcı sadece normal API URL'sini girer (ProductSave alanına):
```
https://www.erentrend.com/api/v1/
```

Sistem **otomatik olarak** dönüştürür:

| Mod | URL |
|-----|-----|
| **API (Doğrudan)** | `https://www.erentrend.com/api/v1/product/save` |
| **PHP (PHP)** | `https://www.erentrend.com/ajax.php?page=php_v1&method=product` |

### Method Dönüşüm Tablosu
| API Method | PHP Method |
|------------|--------------|
| product/save | product |
| product/updateStocks | product_stock |
| product/updatePrices | product_price |
| order/lists | orders |
| order/updateStatus | order_status |
| order/updateShipmentInfo | order_shipment |

---

## 🏗️ Mevcut Sistem Mimarisi

### Dosya Yapısı
```
frm_qukaGonder.vb          - Ana form (5458 satır)
frm_qukaGonder.Designer.vb - Form tasarımı
```

### Temel Bileşenler

#### 1. Veritabanı Tabloları (Access)
| Tablo | Açıklama |
|-------|----------|
| `tbStok` | Ana stok bilgileri |
| `tbStokFisiDetayi` | Stok hareketleri |
| `tbStokFiyati` | Fiyat bilgileri |
| `tbStokSinifi` | Kategoriler (Sinif1-8) |
| `tbStokBarkodu` | Barkod bilgileri |
| `tbStokResim` | Resim URL'leri |
| `tbStokAIIcerik` | SEO bilgileri (sSEOBaslik, sMetaDescription, sKisaAciklama, sAnahtarKelimeler) |
| `tbStokUzunNot` | İçerik bilgileri (sUzunNot, sOzellikler, sBedenTablosu, sKullanimTalimati) |
| `tbRenk` | Renk tanımları |
| `tbKdv` | KDV oranları |
| `tbParamGenel` | API ayarları (ApiKey, ApiSecret, ProductSave) |
| `Products` | Gönderim kuyruğu (status: 0=bekliyor, 1=gönderildi, 2=hatalı) |
| `Orders` | Sipariş kuyruğu |

#### 2. Ana Fonksiyonlar
| Fonksiyon | Satır | Açıklama |
|-----------|-------|----------|
| `LoadConfig()` | 729 | API ayarlarını tbParamGenel'den yükler |
| `ProductSync1()` | 814 | Tüm ürünleri Products tablosuna ekler |
| `ProductSync2()` | 858 | Son 20 dk değişen stok/fiyatları işaretler |
| `ProductSync3()` | 915 | status=0 ürünleri API'ye gönderir (3'lü batch) |
| `ProductSync4()` | 1313 | 14+ saat güncellenmemiş ürünleri yeniden işaretler |
| `OrderSync()` | 1348 | Siparişleri çeker ve veritabanına kaydeder |
| `SendProduct()` | 3325 | Tek bir ürünün tüm verilerini hazırlar |
| `LaPost()` | 3035 | HTTP POST isteği yapar |
| `LaGet()` | 2963 | HTTP GET isteği yapar |
| `SyncChangedStocks()` | 4027 | Hızlı stok güncelleme |
| `SyncChangedPrices()` | 4200 | Hızlı fiyat güncelleme |

#### 3. API Endpoint'leri (Mevcut - Doğrudan API)
| Method | Endpoint | Açıklama |
|--------|----------|----------|
| POST | `product/save` | Ürün kaydetme |
| POST | `product/updateStocks` | Stok güncelleme |
| POST | `product/updatePrices` | Fiyat güncelleme |
| GET | `order/lists` | Sipariş listesi |
| GET | `order/show/{id}` | Sipariş detayı |
| POST | `order/updateStatus` | Sipariş durumu güncelle |

---

## 📦 SendProduct() Fonksiyonu Detaylı Analizi

### Gönderilen Veriler (product dictionary)

```vb
' TEMEL BİLGİLER
product("productID") = id                    ' Model__Renk formatı
product("code") = model & "__" & renk        ' Ürün kodu
product("barcode") = firstBarcode            ' Ana barkod
product("currency") = "TL"                   ' Para birimi
product("quantity") = totalStock             ' Toplam stok
product("taxRate") = nKdvOrani.ToString()    ' KDV oranı (string)
product("salePrice") = fiyatSite             ' Site satış fiyatı
product("listPrice") = fiyatTrendyol         ' Liste fiyatı
product("buyPrice") = alisFiyat              ' Alış fiyatı
product("name") = sAciklama & " - " & colorName
product("description") = sAciklama

' MARKA (chkMarkaGonder)
product("brand") = marka                     ' tbSSinif3'ten

' KATEGORİLER (chkKategoriGonder)
product("category1") = cat1                  ' tbSSinif4
product("category2") = cat2                  ' tbSSinif5
product("category3") = cat3                  ' tbSSinif6
product("category4") = cat4                  ' tbSSinif7
product("category5") = cat5                  ' tbSSinif8

' VARYANTLAR
product("variant1Name") = "Renk"
product("variant2Name") = "Beden"
product("variants") = variants               ' List: value1, value2, quantity, barcode, priceStatus, price

' NİTELİKLER
product("attributes") = nitelikler           ' List: name="Beden", value="XS/S/M/L/XL"

' GRUPLAR (Renk Varyasyonları)
product("groups") = groups                   ' List: group="Renk", code="Model__Renk", label="Renk Adı"

' RESİMLER (chkResimGonder)
product("images") = imageObjects             ' List: imageUrl="https://..."

' UZUN AÇIKLAMA (chkUzunAciklamaGonder)
product("longDescription") = finalLongDescription
' İçerik kaynakları (tbStokUzunNot):
'   - sUzunNot: Ana açıklama
'   - sOzellikler: Ürün özellikleri
'   - sKullanimTalimati: Bakım talimatları
'   - sBedenTablosu: Beden tablosu

' KISA AÇIKLAMA (chkKisaAciklamaGonder)
product("shortDescription") = sKisaAciklamaAI  ' tbStokAIIcerik.sKisaAciklama veya tbStok.sKisaAdi

' SEO BİLGİLERİ (chkSEOGonder) - tbStokAIIcerik tablosundan
product("seoTitle") = sSEOBaslik
product("seoDescription") = sMetaDescription
product("seoKeywords") = tagsString          ' sAnahtarKelimeler + etiketler

' DESİ/AĞIRLIK (chkDesiGonder)
product("desi") = Math.Round(desi, 2)        ' Max(hacimsel, ağırlık)

' PAZARYERI FİYATLARI (chkPazaryeriFiyatlari)
product("marketplacePrices") = marketplacePrices
' List: type="ty/hb/n11", currency="TL", price=fiyat
```

---

## 🔧 YAPILACAK DEĞİŞİKLİKLER

### 1. UI Değişiklikleri (frm_qukaGonder.Designer.vb)

#### Yeni Kontroller Eklenecek:
```vb
' Gönderim Modu Seçimi
grpGonderimModu As GroupBox
rdoApiDogrudan As RadioButton     ' "API (Doğrudan)" - Mevcut sistem
rdoPHP As RadioButton           ' "PHP Entegrasyon" - Yeni sistem
lblGonderimBilgi As Label         ' Açıklama

' tbParamGenel'e Yeni Alanlar:
' - PHPApiUrl (örn: https://site.com/ajax.php?page=php_v1&method=)
' - GonderimModu (1=API, 2=PHP)
```

### 2. Kod Değişiklikleri (frm_qukaGonder.vb)

#### a. Yeni Değişkenler
```vb
Private PHPApiUrl As String
Private GonderimModu As Integer  ' 1=API, 2=PHP
```

#### b. LoadConfig() Güncelleme
```vb
' Mevcut: ApiKey, ApiSecret, ProductSave (LAGlobalAddress)
' Yeni eklenecek: PHPApiUrl, GonderimModu
cmd.CommandText = "SELECT ApiKey, ApiSecret, ProductSave, PHPApiUrl, GonderimModu FROM tbParamGenel"
```

#### c. Yeni Fonksiyonlar
```vb
' PHP için POST fonksiyonu
Private Function LaPostPHP(method As String, data As Dictionary(Of String, Object)) As String
    ' URL: PHPApiUrl & method (örn: .../ajax.php?page=php_v1&method=product)
    ' Headers: apikey, apisecret
    ' Format: application/x-www-form-urlencoded (PHP uyumlu)
End Function

' PHP için GET fonksiyonu
Private Function LaGetPHP(method As String) As String
    ' URL: PHPApiUrl & method & "&" & queryParams
End Function

' Akıllı yönlendirici
Private Function SendToApi(method As String, data As Dictionary(Of String, Object)) As String
    If GonderimModu = 2 Then
        Return LaPostPHP(method, data)
    Else
        Return LaPost(method, data)
    End If
End Function
```

#### d. ProductSync3() Güncelleme
```vb
' Mevcut:
Dim result As String = LaPost("product/save", data)

' Yeni:
Dim result As String = SendToApi("product/save", data)
' veya PHP için:
Dim result As String = SendToApi("product", data)  ' PHP endpoint farklı
```

### 3. Veritabanı Değişiklikleri

#### tbParamGenel Tablosuna Eklenecek Alanlar:
```sql
ALTER TABLE tbParamGenel ADD COLUMN PHPApiUrl VARCHAR(500)
ALTER TABLE tbParamGenel ADD COLUMN GonderimModu INTEGER DEFAULT 1
```

---

## 📊 API Format Karşılaştırması

### Doğrudan API (Mevcut)
```
URL: https://api.site.com/v1/product/save
Method: POST
Content-Type: application/json
Headers:
  - apikey: xxx
  - apisecret: xxx
Body: JSON
```

### PHP API (Yeni)
```
URL: https://site.com/ajax.php?page=php_v1&method=product
Method: POST
Content-Type: application/x-www-form-urlencoded
Headers:
  - apikey: xxx
  - apisecret: xxx
Body: form-urlencoded (bulk_update=1&bulk_products[0][code]=xxx&...)
```

---

## ✅ TAMAMLANAN İŞLER

| Tarih | İş | Durum |
|-------|-----|-------|
| 2026-02-11 | Mevcut sistem analizi | ✅ Tamamlandı |
| 2026-02-11 | PHP entegrasyon analizi | ✅ Tamamlandı |
| 2026-02-11 | Dokümantasyon oluşturma | ✅ Tamamlandı |
| 2026-02-11 | grpGonderimModu UI ekleme | ✅ Tamamlandı |
| 2026-02-11 | LaPostPHP() fonksiyonu | ✅ Tamamlandı |
| 2026-02-11 | LaGetPHP() fonksiyonu | ✅ Tamamlandı |
| 2026-02-11 | SendToApi() yönlendirici | ✅ Tamamlandı |
| 2026-02-11 | GetFromApi() yönlendirici | ✅ Tamamlandı |
| 2026-02-11 | LoadConfig() güncelleme | ✅ Tamamlandı |
| 2026-02-11 | ProductSync3() güncelleme | ✅ Tamamlandı |
| 2026-02-11 | OrderSync() güncelleme | ✅ Tamamlandı |
| 2026-02-11 | Diğer API çağrıları güncelleme | ✅ Tamamlandı |

| 2026-02-11 | Otomatik URL dönüşümü eklendi | ✅ Tamamlandı |
| 2026-02-11 | ConvertToPHPUrl() fonksiyonu | ✅ Tamamlandı |
| 2026-02-11 | ConvertMethodToPHP() fonksiyonu | ✅ Tamamlandı |

## 🔄 KALAN İŞLER

**YOKTUR** - Sistem tamamen hazır. 
- Veritabanında değişiklik gerekmiyor
- Sadece UI'dan mod seçimi yeterli

---

## 🆕 YENİ EKLENEN KODLAR (Özet)

### 1. Designer Dosyası (frm_qukaGonder.Designer.vb)
```vb
' Gönderim Modu Seçimi (API/PHP)
Friend WithEvents grpGonderimModu As GroupBox
Friend WithEvents rdoApiDogrudan As RadioButton   ' Varsayılan seçili
Friend WithEvents rdoPHP As RadioButton
Friend WithEvents lblGonderimModuBilgi As Label
```

### 2. Ana Dosya (frm_qukaGonder.vb)

#### Yeni Değişkenler:
```vb
Private GonderimModu As Integer = 1  ' 1=API, 2=PHP (UI'dan seçilir)
```

#### Yeni Fonksiyonlar:
- `ConvertToPHPUrl(apiUrl)` - URL'yi PHP formatına dönüştürür
- `ConvertMethodToPHP(apiMethod)` - Method adını PHP formatına dönüştürür
- `LaPostPHP(method, data)` - PHP formatında POST
- `LaGetPHP(method)` - PHP formatında GET
- `SendToApi(method, data)` - Akıllı POST yönlendirici
- `GetFromApi(method)` - Akıllı GET yönlendirici

#### Güncellenen Fonksiyonlar:
- `LoadConfig()` - PHPApiUrl ve GonderimModu eklendi
- `ProductSync3()` - SendToApi kullanıyor
- `OrderSync()` - GetFromApi kullanıyor
- `FetchOrders()` - GetFromApi kullanıyor
- `FetchOrderDetail()` - GetFromApi kullanıyor
- `UpdateOrderStatusOnWeb()` - SendToApi kullanıyor
- `UpdateStocks()` - SendToApi kullanıyor
- `UpdatePrices()` - SendToApi kullanıyor
- `UpdateShipmentInfo()` - SendToApi kullanıyor
- `UpdateSimilarProducts()` - SendToApi kullanıyor
- `KontrolEtUrunWebdeVar()` - GetFromApi kullanıyor

---

## 📝 NOTLAR

### Dikkat Edilecekler:
1. **Veri okuma/yazma AYNI kalacak** - Sadece gönderim API'si değişecek
2. **Mevcut müşteriler etkilenmemeli** - Varsayılan mod "API (Doğrudan)" olacak
3. **PHP formatı** - PHP'nin `http_build_query` fonksiyonu gibi form-urlencoded format
4. **UTF-8 encoding** - Türkçe karakterler için özel dönüşüm fonksiyonları (strToUTF8)

### PHP Referans Kodları:
- `/app/ent_files/extracted/ent/functions.php` - Ana fonksiyonlar
- `/app/ent_files/extracted/ent/product_sync_3.php` - Ürün gönderimi
- `/app/ent_files/extracted/ent/orders.php` - Sipariş alma

---

## 🔗 İLGİLİ DOSYALAR

```
/app/temp_repo/frm_qukaGonder.vb           - Ana kod (5458 satır)
/app/temp_repo/frm_qukaGonder.Designer.vb  - Form tasarımı (715 satır)
/app/ent_files/extracted/ent/              - PHP referans kodları
```

---

**Son Güncelleme:** 2026-02-11
**Hazırlayan:** E1 AI Agent
**Sonraki Agent İçin:** Bu dokümandan devam edebilirsiniz. "DEVAM EDEN İŞLER" bölümündeki sıraya göre ilerleyin.

---

## 🐛 HATA DÜZELTMELERİ

### 2026-02-12 - SSL/TLS ve API Timeout Düzeltmeleri

#### Sorun 1: SSL/TLS Güvenli Kanal Hatası
**Hata Mesajı:** `WebException: SSL/TLS güvenli kanalı içi güven ilişkisi kurulamadı`

**Neden:** .NET Framework eski güvenlik protokollerini (SSL 3.0, TLS 1.0) kullanmaya çalışıyordu, ancak modern sunucular bu protokolleri güvenlik nedeniyle devre dışı bıraktı.

**Çözüm:** `Form_Load` fonksiyonuna aşağıdaki kod eklendi:
```vb
System.Net.ServicePointManager.SecurityProtocol = 
    System.Net.SecurityProtocolType.Tls12 Or 
    System.Net.SecurityProtocolType.Tls11 Or 
    System.Net.SecurityProtocolType.Tls
```

#### Sorun 2: API Timeout Hatası (500 Internal Server Error)
**Hata Mesajı:** `WebException: (500) İç Sunucu Hatası - Request Timeout`

**Neden:** API istekleri için belirlenen timeout süreleri (60-180 saniye) büyük veri transferleri için yetersiz kalıyordu.

**Çözüm:** Tüm HTTP istekleri için timeout değerleri artırıldı:
- `LaGet()`: 60 saniye → **300 saniye (5 dakika)**
- `LaPost()`: 180 saniye → **300 saniye (5 dakika)**
- `LaGetPHP()`: 60 saniye → **300 saniye (5 dakika)**
- `LaPostPHP()`: 180 saniye → **300 saniye (5 dakika)**

Ayrıca tüm fonksiyonlara `ReadWriteTimeout` da eklendi.

#### Commit Bilgileri
```
Commit: 6b22b09
Tarih: 2026-02-12
Branch: main
```

### 2026-02-12 - Sipariş Kayıt Doğrulama Hatası
**Sorun:** Siparişler veritabanına kaydedilmesine rağmen, loglarda "sipariş kaydedilemedi" hatası görünüyordu.

**Neden:** `AddOrder` fonksiyonundaki doğrulama kontrolü, veritabanından dönen `@@identity` (yeni eklenen kaydın ID'si) ile siparişi arıyordu. Ancak stored procedure, aradığımız sipariş koduyla eşleşmeyen bir ID döndürüyordu.

**Çözüm:** Doğrulama kontrolü, veritabanının döndürdüğü ID yerine siparişin benzersiz kodu olan `sAciklama3` alanı üzerinden yapılacak şekilde güncellendi.

---

## ⚠️ BİLİNEN SORUNLAR VE ÇÖZÜMLER

### Sunucu Yükü ve Rate Limiting
- API limiti: 25 istek/dakika
- Her batch arasında 3 saniye bekleme yapılıyor
- Batch boyutu timeout sorunları için 3'e düşürülmüş durumda

### Hatalı Ürünler
- `status = '2'` olarak işaretlenen ürünler hatalıdır
- "Hatalı Ürünler" butonu ile listelenebilir
- "Sıfırla" ile tekrar denemeye alınabilir

