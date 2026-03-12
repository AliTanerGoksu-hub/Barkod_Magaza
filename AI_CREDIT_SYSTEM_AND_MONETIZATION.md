# 💳 AI KREDİ SİSTEMİ VE ÜCRETLANDIRME MODELİ

## 🎯 İŞ MODELİ GENEL BAKIŞ

### Sistem Mantığı

```
MÜŞTERİ → PAKET SATIN ALIR → KREDİ YÜKLENIR → AI ÖZELLİKLERİ KULLANIR → KREDİ HARCANIR
```

**Örnek:**
- Müşteri 1000 TL öder
- 1000 AI Kredisi alır
- Her ürün için AI kullanımı: 1 Kredi = 1 TL
- Tam dolu ürün: Başlık, Açıklama, Resim, SEO, Talimatlar
- 1000 ürün için AI kullanabilir

---

## 📦 PAKET SİSTEMİ

### Paket 1: BAŞLANGIÇ 🥉
```
Fiyat: 500 TL
Kredi: 500 Kredi
Ürün Başına: 1 Kredi (1 TL)
Özellikler:
  ✅ Ürün Başlığı (SEO friendly)
  ✅ Kullanım Talimatları
  ❌ Ürün Açıklaması
  ❌ Görsel Bulma
  ❌ Fiyat Optimizasyonu
Uygun: 500 ürüne kadar küçük işletmeler
```

### Paket 2: STANDART 🥈 (Önerilen)
```
Fiyat: 1,000 TL
Kredi: 1,100 Kredi (%10 bonus)
Ürün Başına: 1 Kredi (0.91 TL)
Özellikler:
  ✅ Ürün Başlığı
  ✅ Ürün Açıklaması
  ✅ Kullanım Talimatları
  ✅ Görsel Bulma
  ❌ Görsel Doğrulama
  ❌ Fiyat Optimizasyonu
Uygun: 1000 ürüne kadar orta ölçekli
```

### Paket 3: PRO 🥇
```
Fiyat: 2,500 TL
Kredi: 3,000 Kredi (%20 bonus)
Ürün Başına: 1 Kredi (0.83 TL)
Özellikler:
  ✅ Ürün Başlığı
  ✅ Ürün Açıklaması
  ✅ Kullanım Talimatları
  ✅ Görsel Bulma
  ✅ Görsel Doğrulama
  ✅ Kategori/Etiket Önerisi
  ✅ Fiyat Optimizasyonu
Uygun: 3000 ürüne kadar büyük işletmeler
```

### Paket 4: ENTERPRISE 💎
```
Fiyat: 5,000 TL
Kredi: 7,000 Kredi (%40 bonus)
Ürün Başına: 1 Kredi (0.71 TL)
Özellikler:
  ✅ Tüm Özellikler
  ✅ Öncelikli Destek
  ✅ Özel Prompt Özelleştirme
  ✅ API Entegrasyonu
Uygun: 7000+ ürün, kurumsal
```

---

## 🗄️ VERİTABANI YAPISI

### Tablo 1: tbMusteriKredi (Müşteri Kredi Hesabı)

```sql
CREATE TABLE tbMusteriKredi (
    nKrediID INT IDENTITY(1,1) PRIMARY KEY,
    nMusteriID INT NOT NULL,                    -- Müşteri ID (tbMusteri ile ilişki)
    sMusteriAdi NVARCHAR(100),                  -- Müşteri adı
    
    -- KREDİ BİLGİLERİ
    nToplamKredi DECIMAL(10,2) DEFAULT 0.00,    -- Toplam kredi (TL cinsinden)
    nKullanilabilirKredi DECIMAL(10,2) DEFAULT 0.00, -- Kullanılabilir kredi
    nKullanilanKredi DECIMAL(10,2) DEFAULT 0.00,    -- Kullanılan kredi
    
    -- AKTİF PAKET
    sAktifPaket NVARCHAR(50),                   -- Başlangıç / Standart / Pro / Enterprise
    dteAktifPaketTarihi DATETIME,               -- Paket aktivasyon tarihi
    dtePaketBitisTarihi DATETIME,               -- Paket bitiş tarihi (varsa)
    
    -- LİMİTLER
    nGunlukLimit INT DEFAULT 100,               -- Günlük işlem limiti
    nGunlukKullanim INT DEFAULT 0,              -- Bugün kaç işlem yapıldı
    dteGunlukResetTarihi DATE,                  -- Son reset tarihi
    
    -- DURUM
    bAktif BIT DEFAULT 1,                       -- Hesap aktif mi?
    bOtomatikYenile BIT DEFAULT 0,              -- Kredi bitince otomatik yenile
    
    -- ÖDEME BİLGİLERİ
    sOdemeTuru NVARCHAR(50),                    -- Kredi Kartı / Havale / EFT
    dteSonOdeme DATETIME,                       -- Son ödeme tarihi
    nSonOdemeTutar DECIMAL(10,2),               -- Son ödeme tutarı
    
    -- BONUS VE İNDİRİMLER
    nBonusOrani DECIMAL(5,2) DEFAULT 0.00,      -- Bonus oranı (%)
    nToplamBonus DECIMAL(10,2) DEFAULT 0.00,    -- Toplam kazanılan bonus
    
    dteOlusturma DATETIME DEFAULT GETDATE(),
    dteGuncelleme DATETIME DEFAULT GETDATE(),
    
    FOREIGN KEY (nMusteriID) REFERENCES tbMusteri(nMusteriID)
)
```

---

### Tablo 2: tbKrediPaketleri (Satılabilir Paketler)

```sql
CREATE TABLE tbKrediPaketleri (
    nPaketID INT IDENTITY(1,1) PRIMARY KEY,
    sPaketAdi NVARCHAR(100),                    -- Başlangıç / Standart / Pro / Enterprise
    sPaketAciklama NVARCHAR(500),               -- Paket açıklaması
    
    -- FİYATLANDIRMA
    nFiyat DECIMAL(10,2),                       -- Satış fiyatı (TL)
    nKrediMiktari DECIMAL(10,2),                -- Verilecek kredi miktarı
    nBonusOrani DECIMAL(5,2) DEFAULT 0.00,      -- Bonus oranı (%)
    nUrunBasinaKredi DECIMAL(10,4),             -- Ürün başına kredi maliyeti
    
    -- ÖZELLİKLER (JSON formatında saklanabilir)
    bBaslikOlustur BIT DEFAULT 1,
    bAciklamaOlustur BIT DEFAULT 0,
    bTalimatOlustur BIT DEFAULT 1,
    bGorselBul BIT DEFAULT 0,
    bGorselDogrula BIT DEFAULT 0,
    bKategoriOner BIT DEFAULT 0,
    bFiyatOptimize BIT DEFAULT 0,
    
    -- LİMİTLER
    nGunlukLimit INT,                           -- Günlük işlem limiti
    nAylikLimit INT,                            -- Aylık işlem limiti
    
    -- SÜRELİ Mİ?
    bSureli BIT DEFAULT 0,                      -- Paket sürelimi?
    nSureGun INT,                               -- Kaç gün geçerli
    
    -- ÖZEL HAKLAR
    bOncelikliDestek BIT DEFAULT 0,             -- Öncelikli destek
    bOzelPrompt BIT DEFAULT 0,                  -- Özel prompt özelleştirme
    bAPIEntegrasyon BIT DEFAULT 0,              -- API erişimi
    
    -- DURUM
    bAktif BIT DEFAULT 1,                       -- Paket satışta mı?
    nSiraNo INT DEFAULT 0,                      -- Gösterim sırası
    
    dteOlusturma DATETIME DEFAULT GETDATE()
)
```

---

### Tablo 3: tbKrediHareketleri (Kredi Giriş/Çıkış)

```sql
CREATE TABLE tbKrediHareketleri (
    nHareketID INT IDENTITY(1,1) PRIMARY KEY,
    nMusteriID INT NOT NULL,
    nKrediID INT NOT NULL,                      -- tbMusteriKredi ile ilişki
    
    -- HAREKET TİPİ
    sHareketTipi NVARCHAR(50),                  -- YuklemeManuel / YuklemePaket / Kullanim / Iade / Bonus
    nMiktar DECIMAL(10,2),                      -- Kredi miktarı (+/-)
    
    -- İŞLEM DETAYI
    nIslemID INT,                               -- tbAIIslemLog ile ilişki (kullanım durumunda)
    nStokID INT,                                -- Hangi ürün için kullanıldı
    sBarkod NVARCHAR(50),                       -- Ürün barkodu
    sIslemAciklama NVARCHAR(500),               -- Açıklama
    
    -- PAKET BİLGİSİ (eğer paket alımıysa)
    nPaketID INT,                               -- tbKrediPaketleri ile ilişki
    sPaketAdi NVARCHAR(100),
    nPaketFiyat DECIMAL(10,2),
    
    -- ÖDEME BİLGİSİ
    sOdemeTuru NVARCHAR(50),                    -- Kredi Kartı / Havale / Manuel
    sOdemeReferans NVARCHAR(100),               -- Ödeme referans no
    
    -- BAKİYE (işlem sonrası)
    nOncekiBakiye DECIMAL(10,2),                -- İşlem öncesi bakiye
    nYeniBakiye DECIMAL(10,2),                  -- İşlem sonrası bakiye
    
    dteTarih DATETIME DEFAULT GETDATE(),
    
    FOREIGN KEY (nMusteriID) REFERENCES tbMusteri(nMusteriID),
    FOREIGN KEY (nKrediID) REFERENCES tbMusteriKredi(nKrediID),
    FOREIGN KEY (nPaketID) REFERENCES tbKrediPaketleri(nPaketID)
)
```

---

### Tablo 4: tbOdemeler (Ödeme Kayıtları)

```sql
CREATE TABLE tbOdemeler (
    nOdemeID INT IDENTITY(1,1) PRIMARY KEY,
    nMusteriID INT NOT NULL,
    
    -- ÖDEME BİLGİLERİ
    nTutar DECIMAL(10,2),                       -- Ödeme tutarı
    sOdemeTuru NVARCHAR(50),                    -- KrediKarti / Havale / EFT
    sOdemeDurumu NVARCHAR(50),                  -- Beklemede / Onaylandi / Iptal / Hata
    
    -- PAKET BİLGİSİ
    nPaketID INT,
    sPaketAdi NVARCHAR(100),
    nKrediMiktari DECIMAL(10,2),                -- Yüklenecek kredi
    
    -- ÖDEME GATEWAY BİLGİLERİ
    sGateway NVARCHAR(50),                      -- iyzico / Stripe / PayTR
    sTransactionID NVARCHAR(100),               -- Gateway transaction ID
    sPaymentToken NVARCHAR(255),                -- Payment token
    sErrorMessage NVARCHAR(500),                -- Hata mesajı (varsa)
    
    -- FATURA BİLGİLERİ
    sFaturaNo NVARCHAR(50),
    sFaturaAdresi NVARCHAR(500),
    sVergiNo NVARCHAR(50),
    
    -- TARİHLER
    dteOdemeTarihi DATETIME DEFAULT GETDATE(),
    dteOnayTarihi DATETIME,
    
    FOREIGN KEY (nMusteriID) REFERENCES tbMusteri(nMusteriID),
    FOREIGN KEY (nPaketID) REFERENCES tbKrediPaketleri(nPaketID)
)
```

---

## 💰 ÜCRETLANDIRME MATRİSİ

### Senaryo A: Tam Dolu Ürün (1 Kredi = 1 TL)

**MÜŞTERİYE SATIŞ:**
```
Ürün başına: 1 Kredi (1 TL)

İçerik:
✅ SEO Başlığı
✅ Detaylı Açıklama (200-300 kelime)
✅ Kullanım Talimatları (kategori bazlı)
✅ Otomatik Görsel Bulma
✅ Görsel Optimizasyonu
✅ Kategori ve Etiket Önerileri
✅ Meta Description (SEO)
```

**SİZİN MALİYETİNİZ:**
```
AI Maliyeti: ~0.60 TL/ürün (premium)
Google API: ~0.175 TL/ürün (veya ücretsiz 100/gün)
Toplam Maliyet: ~0.78 TL/ürün

Kar Marjı: 1.00 - 0.78 = 0.22 TL/ürün (%22)
```

**1000 ÜRÜN İÇİN:**
```
Müşteri Ödemesi: 1,000 TL
Sizin Maliyetiniz: 780 TL
Net Kar: 220 TL
```

---

### Senaryo B: Kısmi Dolu (0.5 Kredi)

**MÜŞTERİYE SATIŞ:**
```
Ürün başına: 0.5 Kredi (0.50 TL)

İçerik:
✅ SEO Başlığı
✅ Kullanım Talimatları
❌ Detaylı Açıklama
❌ Görsel Bulma
❌ Diğerleri
```

**SİZİN MALİYETİNİZ:**
```
AI Maliyeti: ~0.12 TL/ürün
Kar Marjı: 0.50 - 0.12 = 0.38 TL/ürün (%76)
```

---

### Senaryo C: Sadece Talimatlar (0.2 Kredi)

**MÜŞTERİYE SATIŞ:**
```
Ürün başına: 0.2 Kredi (0.20 TL)

İçerik:
✅ Kullanım Talimatları
❌ Diğerleri
```

**SİZİN MALİYETİNİZ:**
```
AI Maliyeti: ~0.10 TL/ürün
Kar Marjı: 0.20 - 0.10 = 0.10 TL/ürün (%50)
```

---

## 📊 KAR-ZARAR ANALİZİ

### Aylık 10,000 Ürün İşlendiğinde

| Paket | Müşteri Sayısı | Ürün/Müşteri | Gelir | Maliyet | Net Kar | Marj |
|-------|----------------|--------------|-------|---------|---------|------|
| **Başlangıç** | 20 | 250 | 10,000 TL | 2,400 TL | 7,600 TL | %76 |
| **Standart** | 10 | 1000 | 10,000 TL | 6,000 TL | 4,000 TL | %40 |
| **Pro** | 4 | 2500 | 10,000 TL | 7,800 TL | 2,200 TL | %22 |
| **Enterprise** | 2 | 5000 | 10,000 TL | 7,800 TL | 2,200 TL | %22 |

**Not:** Kar marjı paket özelliklerine göre değişir. Tam özellikli pakette marj düşük ama hacim yüksek.

---

## 🔐 KREDİ KULLANIM MANTĞI

### Adım 1: Müşteri Paketi Seçer

```vbnet
' Müşteri "Standart Paket" seçer
Paket: Standart
Fiyat: 1,000 TL
Kredi: 1,100 Kredi (bonus dahil)
```

### Adım 2: Ödeme Yapar

```vbnet
' iyzico, Stripe veya Havale ile ödeme
Ödeme Onaylanınca:
  → tbMusteriKredi.nToplamKredi += 1,100
  → tbMusteriKredi.nKullanilabilirKredi += 1,100
  → tbKrediHareketleri.insert(YuklemePaket, +1100)
  → tbOdemeler.insert(Onaylandi)
```

### Adım 3: AI Kullanımı

```vbnet
' Müşteri ürün için AI kullanır
Function UseAIForProduct(productID) As Boolean
    ' 1. Kredi kontrolü
    If KullanilabilirKredi < 1.0 Then
        MessageBox.Show("Yetersiz kredi! Lütfen paket satın alın.")
        Return False
    End If
    
    ' 2. Günlük limit kontrolü
    If GunlukKullanim >= GunlukLimit Then
        MessageBox.Show("Günlük limitiniz doldu!")
        Return False
    End If
    
    ' 3. AI işlemlerini çalıştır
    GenerateTitle(productID)
    GenerateDescription(productID)
    GenerateInstructions(productID)
    FindImage(productID)
    
    ' 4. Kredi düş
    nKullanilabilirKredi -= 1.0
    nKullanilanKredi += 1.0
    nGunlukKullanim += 1
    
    ' 5. Hareket kaydet
    tbKrediHareketleri.Insert(Kullanim, -1.0, productID)
    
    Return True
End Function
```

---

## 🎨 MÜŞTERİ ARAYÜZÜ (UI)

### Kredi Dashboard

```
╔══════════════════════════════════════════════════════╗
║          💳 AI KREDİ YÖNETİMİ                        ║
╚══════════════════════════════════════════════════════╝

📊 KREDİ DURUMUNUZ

┌────────────────────────────────────────────────────┐
│ Kullanılabilir Kredi:  850.50 ₺                    │
│ Kullanılan Kredi:      149.50 ₺                    │
│ Toplam Kredi:         1000.00 ₺                    │
│                                                     │
│ [██████████████████░░░░░░] %85                     │
└────────────────────────────────────────────────────┘

⚠️ Krediniz azalıyor! Yeni paket satın almak için tıklayın.
[💰 Paket Satın Al]


📦 AKTİF PAKETİNİZ

┌────────────────────────────────────────────────────┐
│ Paket: Standart Paket 🥈                           │
│ Aktivasyon: 01.12.2025                             │
│ Özellikler:                                         │
│   ✅ SEO Başlık                                     │
│   ✅ Ürün Açıklaması                                │
│   ✅ Kullanım Talimatları                           │
│   ✅ Görsel Bulma                                   │
│   ❌ Görsel Doğrulama (Pro'ya yükseltin)           │
│                                                     │
│ Günlük Limit: 37/100 kullanıldı                    │
└────────────────────────────────────────────────────┘

[📈 Paketi Yükselt]


📈 KULLANIM İSTATİSTİKLERİ (Son 30 Gün)

┌────────────────────────────────────────────────────┐
│ Toplam İşlem: 149 ürün                             │
│ Günlük Ortalama: 5 ürün                            │
│ En Çok Kullanılan: Tekstil Kategorisi              │
│ Tasarruf: ~2,235 TL (manuel çalışmaya göre)       │
└────────────────────────────────────────────────────┘

[📊 Detaylı Rapor]


🕒 SON HAREKETLERİNİZ

┌────────────────────────────────────────────────────┐
│ 28.11.2025 15:30  │ Kullanım  │ -1.00 ₺ │ Nike Air│
│ 28.11.2025 14:22  │ Kullanım  │ -1.00 ₺ │ Adidas │
│ 28.11.2025 13:45  │ Kullanım  │ -1.00 ₺ │ Puma   │
│ 27.11.2025 10:00  │ Bonus     │ +50.00₺ │ Kampanya│
│ 25.11.2025 09:15  │ Yükleme   │+1000.00₺│ Standart│
└────────────────────────────────────────────────────┘

[📜 Tüm Hareketler]
```

---

## 💳 ÖDEME GATEWAY ENTEGRASYONU

### iyzico Entegrasyonu (Önerilen - Türkiye için)

```vbnet
Imports iyzipay
Imports iyzipay.request
Imports iyzipay.model

Public Class IyzicoPaymentService
    
    Private apiKey As String = "sandbox-YOUR-API-KEY"
    Private secretKey As String = "sandbox-YOUR-SECRET-KEY"
    Private baseUrl As String = "https://sandbox-api.iyzipay.com" ' Production: https://api.iyzipay.com
    
    ''' <summary>
    ''' Ödeme başlat
    ''' </summary>
    Public Function InitiatePayment(musteriID As Integer, paketID As Integer, tutar As Decimal) As Dictionary(Of String, Object)
        Try
            ' iyzico options
            Dim options As New Options()
            options.ApiKey = apiKey
            options.SecretKey = secretKey
            options.BaseUrl = baseUrl
            
            ' Payment request oluştur
            Dim request As New CreatePaymentRequest()
            request.Locale = Locale.TR.ToString()
            request.ConversationId = $"PAKET_{musteriID}_{DateTime.Now.Ticks}"
            request.Price = tutar.ToString("F2", CultureInfo.InvariantCulture)
            request.PaidPrice = tutar.ToString("F2", CultureInfo.InvariantCulture)
            request.Currency = Currency.TRY.ToString()
            request.Installment = 1
            request.BasketId = $"PKT{paketID}"
            request.PaymentChannel = PaymentChannel.WEB.ToString()
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString()
            
            ' Müşteri bilgileri
            Dim buyer As New Buyer()
            buyer.Id = musteriID.ToString()
            buyer.Name = "Müşteri Adı" ' Veritabanından çekilecek
            buyer.Surname = "Soyadı"
            buyer.Email = "musteri@email.com"
            buyer.IdentityNumber = "11111111111"
            buyer.RegistrationAddress = "Adres"
            buyer.City = "İstanbul"
            buyer.Country = "Turkey"
            request.Buyer = buyer
            
            ' Kart bilgileri
            Dim paymentCard As New PaymentCard()
            paymentCard.CardHolderName = "Kart Sahibi Adı"
            paymentCard.CardNumber = "5528790000000008" ' Test kartı
            paymentCard.ExpireMonth = "12"
            paymentCard.ExpireYear = "2030"
            paymentCard.Cvc = "123"
            paymentCard.RegisterCard = 0
            request.PaymentCard = paymentCard
            
            ' Fatura adresi
            Dim billingAddress As New Address()
            billingAddress.ContactName = "Müşteri Adı"
            billingAddress.City = "İstanbul"
            billingAddress.Country = "Turkey"
            billingAddress.Description = "Fatura Adresi"
            request.BillingAddress = billingAddress
            
            ' Basket items
            Dim basketItems As New List(Of BasketItem)()
            Dim firstBasketItem As New BasketItem()
            firstBasketItem.Id = paketID.ToString()
            firstBasketItem.Name = "AI Kredi Paketi"
            firstBasketItem.Category1 = "AI Services"
            firstBasketItem.ItemType = BasketItemType.VIRTUAL.ToString()
            firstBasketItem.Price = tutar.ToString("F2", CultureInfo.InvariantCulture)
            basketItems.Add(firstBasketItem)
            request.BasketItems = basketItems
            
            ' Ödeme yap
            Dim payment As Payment = Payment.Create(request, options)
            
            If payment.Status = "success" Then
                ' Başarılı - Kredi yükle
                Return New Dictionary(Of String, Object) From {
                    {"success", True},
                    {"transactionId", payment.PaymentId},
                    {"status", payment.Status},
                    {"message", "Ödeme başarılı"}
                }
            Else
                ' Hata
                Return New Dictionary(Of String, Object) From {
                    {"success", False},
                    {"error", payment.ErrorMessage},
                    {"status", payment.Status}
                }
            End If
            
        Catch ex As Exception
            Return New Dictionary(Of String, Object) From {
                {"success", False},
                {"error", ex.Message}
            }
        End Try
    End Function
    
End Class
```

---

## 🎯 KULLANIM AKIŞI

### Senaryo: Müşteri İlk Kez Paket Alıyor

```
1. MÜŞTERİ LOGİNİ
   ↓
2. KREDİ DASHBOARD → "0.00 TL Krediniz Yok"
   ↓
3. [Paket Satın Al] Butonuna Tıklar
   ↓
4. PAKET SEÇİMİ EKRANI
   - Başlangıç (500 TL)
   - Standart (1000 TL) ⭐ Önerilen
   - Pro (2500 TL)
   - Enterprise (5000 TL)
   ↓
5. MÜŞTERİ "STANDART" PAKET SEÇİYOR
   ↓
6. ÖDEME EKRANI
   - Kredi Kartı ile Ödeme
   - Havale/EFT ile Ödeme
   ↓
7. KREDİ KARTI BİLGİLERİNİ GİRİYOR
   ↓
8. iyzico 3D Secure Ekranı
   ↓
9. ÖDEME BAŞARILI ✅
   ↓
10. KREDİ YÜKLEME
    - tbMusteriKredi: +1,100 Kredi
    - tbKrediHareketleri: Log kaydı
    - tbOdemeler: Ödeme kaydı
   ↓
11. BAŞARI MESAJI
    "Tebrikler! 1,100 AI Kredisi hesabınıza yüklendi!"
   ↓
12. MÜŞTERİ ARTIK AI ÖZELLİKLERİNİ KULLANABİLİR
```

---

## 📧 OTOMATİK BİLDİRİMLER

### Kredi Düşük Uyarısı (Email)

```
Konu: ⚠️ AI Krediniz Azalıyor

Merhaba [Müşteri Adı],

AI krediniz azalıyor:

Kullanılabilir Kredi: 50.00 ₺
Kalan İşlem: ~50 ürün

Krediniz bitmesin! Yeni paket satın alın:

[💰 Paket Satın Al]

İyi çalışmalar,
Barkod_Magaza AI Ekibi
```

### Kredi Bitti Uyarısı

```
Konu: ❌ AI Krediniz Bitti

Merhaba [Müşteri Adı],

AI krediniz tükendi:

Kullanılabilir Kredi: 0.00 ₺

AI özelliklerini kullanmaya devam etmek için yeni paket satın alın:

[💰 Acil Paket Satın Al]

En popüler: Standart Paket - 1,000 TL (1,100 Kredi)

İyi çalışmalar,
Barkod_Magaza AI Ekibi
```

---

## 📊 ADMIN PANELİ (Sizin İçin)

### Kredi Yönetim Ekranı

```
╔══════════════════════════════════════════════════════╗
║      🎛️ AI KREDİ YÖNETİMİ (ADMIN)                   ║
╚══════════════════════════════════════════════════════╝

📊 GENEL İSTATİSTİKLER

┌────────────────────────────────────────────────────┐
│ Toplam Müşteri: 150                                │
│ Aktif Abonelik: 127                                │
│ Toplam Kredi Satışı: 125,000 TL (Bu Ay)           │
│ Kullanılan Kredi: 78,500 TL                        │
│ Net Kar: 27,500 TL (%22 marj)                      │
└────────────────────────────────────────────────────┘


📦 PAKET DAĞILIMI

┌────────────────────────────────────────────────────┐
│ Başlangıç:  45 müşteri (30%)  │  22,500 TL         │
│ Standart:   60 müşteri (40%)  │  60,000 TL ⭐      │
│ Pro:        30 müşteri (20%)  │  75,000 TL         │
│ Enterprise: 15 müşteri (10%)  │  75,000 TL         │
└────────────────────────────────────────────────────┘


🔝 EN ÇOK HARCAYAN MÜŞTERİLER

┌────────────────────────────────────────────────────┐
│ 1. ABC Tekstil    │ 5,000 TL  │ Enterprise         │
│ 2. XYZ Ayakkabı   │ 3,500 TL  │ Pro                │
│ 3. DEF Züccaciye  │ 2,500 TL  │ Pro                │
└────────────────────────────────────────────────────┘


⚠️ DİKKAT GEREKTİREN HESAPLAR

┌────────────────────────────────────────────────────┐
│ • MNO Ltd. - Kredi bitti, 3 gündür kullanmıyor    │
│ • PQR A.Ş. - Günlük limite sık takılıyor          │
│ • STU Tekstil - Ödeme beklemede (Havale)          │
└────────────────────────────────────────────────────┘

[📊 Detaylı Rapor] [💰 Manuel Kredi Yükle] [⚙️ Paket Ayarları]
```

---

## 🎁 KAMPANYA VE BONUS SİSTEMİ

### Kampanya 1: İlk Alım Bonusu
```sql
-- İlk paket alımında %20 bonus
IF (SELECT COUNT(*) FROM tbKrediHareketleri WHERE nMusteriID = @MusteriID AND sHareketTipi = 'YuklemePaket') = 1
BEGIN
    DECLARE @BonusKredi DECIMAL(10,2) = @KrediMiktari * 0.20
    
    INSERT INTO tbKrediHareketleri (nMusteriID, sHareketTipi, nMiktar, sIslemAciklama)
    VALUES (@MusteriID, 'Bonus', @BonusKredi, 'İlk Alım Bonusu %20')
    
    UPDATE tbMusteriKredi SET nKullanilabilirKredi += @BonusKredi WHERE nMusteriID = @MusteriID
END
```

### Kampanya 2: Referans Bonusu
```
Arkadaşını Getir, İkiniz de Kazanın!

Referans kodu paylaş:
→ Arkadaşın 100 TL bonus kazanır
→ Sen de 100 TL bonus kazanırsın
```

### Kampanya 3: Hacim İndirimi
```
5,000 TL ve üzeri paket alımlarında:
→ %15 ekstra kredi
→ Ücretsiz öncelikli destek (3 ay)
```

---

## 💡 FİYATLANDIRMA STRATEJİSİ

### Dinamik Fiyatlandırma

```vbnet
' Müşteri geçmişine göre özel fiyat
Function GetCustomPrice(musteriID As Integer, paketID As Integer) As Decimal
    Dim basePrice As Decimal = GetPaketFiyat(paketID)
    
    ' Sadık müşteri indirimi
    Dim toplamAlim As Decimal = GetToplamAlisTutari(musteriID)
    If toplamAlim > 10000 Then
        basePrice *= 0.90 ' %10 indirim
    ElseIf toplamAlim > 5000 Then
        basePrice *= 0.95 ' %5 indirim
    End If
    
    ' Kampanya indirimi
    Dim activeDiscount As Decimal = GetActiveDiscountRate()
    If activeDiscount > 0 Then
        basePrice *= (1 - activeDiscount)
    End If
    
    Return basePrice
End Function
```

---

## 📈 BAŞARI METRİKLERİ

### Takip Edilecek KPI'lar

1. **ARPU** (Average Revenue Per User)
   - Müşteri başına ortalama gelir
   - Hedef: 1,500 TL/ay

2. **Churn Rate** (Müşteri Kaybı)
   - Aylık müşteri kaybı oranı
   - Hedef: < %5

3. **LTV** (Lifetime Value)
   - Müşterinin toplam değeri
   - Hedef: 10,000 TL+

4. **CAC** (Customer Acquisition Cost)
   - Müşteri edinme maliyeti
   - Hedef: < 500 TL

5. **Kredi Kullanım Oranı**
   - Satılan kredinin kaçı kullanılıyor
   - Hedef: > %80

---

## 🚀 UYGULAMA PLANI

### Faz 1: Temel Altyapı (Hafta 1-2)
- [x] Veritabanı tabloları oluşturma
- [x] Kredi sistemi backend implementasyonu
- [x] Paket tanımlama sistemi
- [ ] Temel UI (dashboard)

### Faz 2: Ödeme Entegrasyonu (Hafta 3)
- [ ] iyzico entegrasyonu
- [ ] Test ödeme akışı
- [ ] Fatura sistemi

### Faz 3: Müşteri Paneli (Hafta 4)
- [ ] Kredi dashboard UI
- [ ] Paket satın alma sayfası
- [ ] Hareket geçmişi

### Faz 4: Admin Paneli (Hafta 5)
- [ ] Kredi yönetimi
- [ ] Raporlama
- [ ] Manuel kredi yükleme

### Faz 5: Bildirimler ve Otomasyon (Hafta 6)
- [ ] Email bildirimleri
- [ ] SMS uyarıları
- [ ] Otomatik kampanyalar

---

## 💰 GELİR PROJEKSİYONU

### 6 Aylık Projeksiyon

| Ay | Müşteri | Ort. Paket | Gelir | Maliyet | Net Kar |
|----|---------|------------|-------|---------|---------|
| 1  | 20      | 1,000 TL   | 20,000 TL | 12,000 TL | 8,000 TL |
| 2  | 40      | 1,000 TL   | 40,000 TL | 24,000 TL | 16,000 TL |
| 3  | 70      | 1,200 TL   | 84,000 TL | 50,400 TL | 33,600 TL |
| 4  | 100     | 1,200 TL   | 120,000 TL | 72,000 TL | 48,000 TL |
| 5  | 130     | 1,300 TL   | 169,000 TL | 101,400 TL | 67,600 TL |
| 6  | 150     | 1,400 TL   | 210,000 TL | 126,000 TL | 84,000 TL |

**Toplam 6 Ay:**
- Gelir: 643,000 TL
- Maliyet: 385,800 TL
- Net Kar: 257,200 TL (%40 marj)

---

## 🎯 SONUÇ

### Ana Avantajlar

✅ **Sürdürülebilir Gelir:** Aylık tekrarlayan gelir
✅ **Ölçeklenebilir:** Sınırsız müşteri kapasitesi
✅ **Otomatik:** Minimum manuel müdahale
✅ **Şeffaf:** Müşteri her şeyi görebilir
✅ **Esnek:** Paket ve fiyat özelleştirilebilir
✅ **Karlı:** %22-76 kar marjı

**Bu sistem sayesinde hem müşterileriniz AI'dan faydalanır, hem de sürdürülebilir bir iş modeli oluşturursunuz!** 🚀
