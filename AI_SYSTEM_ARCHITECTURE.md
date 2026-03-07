# 🏗️ AI SİSTEM MİMARİSİ VE ÇALIŞMA MANTIĞI

## 📊 GENEL BAKIŞ

```
┌─────────────────────────────────────────────────────────────┐
│                      KULLANICI ARABIRIMI                     │
│  ┌──────────────────┐        ┌──────────────────┐          │
│  │ frm_AIAyarlari   │        │ frm_AIUrunIsle   │          │
│  │ (Ayarlar Formu)  │        │ (İşlem Formu)    │          │
│  └────────┬─────────┘        └────────┬─────────┘          │
└───────────┼──────────────────────────┼────────────────────┘
            │                          │
            ▼                          ▼
┌───────────────────────────────────────────────────────────┐
│                   İŞ MANTIK KATMANI                        │
│  ┌──────────────────────────────────────────────────────┐ │
│  │         AIContentManager (Orkestratör)               │ │
│  │  - İşlem akışını yönetir                             │ │
│  │  - Tüm servisleri koordine eder                      │ │
│  └───┬────────────┬────────────┬────────────┬──────────┘ │
│      │            │            │            │             │
│      ▼            ▼            ▼            ▼             │
│  ┌─────────┐ ┌─────────┐ ┌─────────┐ ┌──────────────┐  │
│  │AIService│ │ Credit  │ │Parameter│ │AIImageFinder │  │
│  │         │ │Service  │ │Service  │ │              │  │
│  └────┬────┘ └────┬────┘ └────┬────┘ └──────┬───────┘  │
└───────┼──────────┼──────────┼───────────────┼──────────┘
        │          │          │               │
        ▼          ▼          ▼               ▼
┌────────────────────────────────────────────────────────────┐
│                    VERİTABANI (SQL Server)                 │
│  ┌──────────┐  ┌──────────┐  ┌──────────┐  ┌──────────┐ │
│  │  tbStok  │  │tbStokAI  │  │tbMusteri │  │tbKredi   │ │
│  │          │  │Icerik    │  │Kredi     │  │Hareketler│ │
│  └──────────┘  └──────────┘  └──────────┘  └──────────┘ │
└────────────────────────────────────────────────────────────┘
        │
        ▼
┌────────────────────────────────────────────────────────────┐
│                   DIŞ SERVİSLER                            │
│  ┌────────────────┐          ┌────────────────┐           │
│  │  OpenAI GPT-5  │          │ Google Custom  │           │
│  │  (AI İçerik)   │          │ Search (Görsel)│           │
│  └────────────────┘          └────────────────┘           │
└────────────────────────────────────────────────────────────┘
```

---

## 🎯 SİSTEM NASIL ÇALIŞIYOR?

### **1. BAŞLANGIÇ: Parametreler ve Ayarlar**

**ParameterService.vb**
```
VERİTABANI: tbParamGenel tablosu
├── bAIKullan (AI sistemi açık mı?)
├── sEmergentKey (OpenAI API Key)
├── bBaslikOlustur (Başlık özelliği aktif mi?)
├── bAciklamaOlustur (Açıklama özelliği aktif mi?)
├── bTalimatOlustur (Talimat özelliği aktif mi?)
└── bGorselBul (Görsel bulma aktif mi?)
```

**Ne yapıyor?**
- Uygulama açılınca tbParamGenel'den ayarları okur
- Her AI işlemi öncesi kontrol edilir
- Admin bu ayarları `frm_AIAyarlari` formundan değiştirir

---

### **2. KULLANICI İŞLEMİ BAŞLATIR**

**Senaryo:** Kullanıcı bir ürün için AI içerik oluşturmak istiyor.

#### **frm_AIUrunIsle.vb** (Ürün İşleme Formu)
```
KULLANICI GİRİŞİ:
├── Stok ID girer (örnek: 12345)
└── "İşle" butonuna tıklar
```

**Form ne yapar?**
1. Stok ID'yi alır
2. `AIContentManager` sınıfını çağırır
3. Sonucu log listesinde gösterir

---

### **3. ORKESTRATÖR DEVREYİ GİRER**

**AIContentManager.vb** (Ana Koordinatör)

```
ProcessProduct(nStokID, musteriID) fonksiyonu çalışır:

ADIM 1: Parametre Kontrolü
├── ParameterService.IsAIEnabled() → AI açık mı?
└── Kapalıysa → "AI sistemi kapalı" mesajı döner

ADIM 2: Kredi Kontrolü
├── CreditService.CheckCredit(musteriID, 1.4) → Yeterli kredi var mı?
└── Yetersizse → "Yetersiz kredi" mesajı döner

ADIM 3: Günlük Limit Kontrolü
├── CreditService.CheckDailyLimit(musteriID) → Günlük limit aşıldı mı?
└── Aşıldıysa → "Günlük limit aşıldı" mesajı döner

ADIM 4: Ürün Bilgilerini Al
└── tbStok tablosundan ürün detaylarını çek
    (sKodu, sAciklama, sModel, sRenk, sMarka, kategori vb.)

ADIM 5: AI İçerik Üretimi
├── AIService.GenerateTitle(productData) → SEO başlık oluştur
├── AIService.GenerateDescription(productData) → Açıklama oluştur
├── AIService.GenerateInstructions(productData) → Kullanım talimatı oluştur
└── AIService.GenerateMetaDescription(productData) → Meta description

ADIM 6: Görsel Bulma (opsiyonel)
└── AIImageFinder.AutoFindAndAddImage(...) → Google'dan görsel bul

ADIM 7: Veritabanına Kaydet
├── tbStokAIIcerik tablosuna AI içerikleri yaz
└── tbStok.bAIIcerikVar = 1 olarak güncelle

ADIM 8: Krediyi Düş
└── CreditService.DeductCredit(musteriID, 1.4, stokID, "AI içerik")
```

---

## 💾 VERİTABANI YAPISI

### **A) MEVCUT TABLOLARA EKLENENLER:**

#### **tbStok (Ürün Tablosu) - Güncellemeler**
```sql
ALTER TABLE tbStok ADD bAIIcerikVar BIT DEFAULT 0
ALTER TABLE tbStok ADD dteAISonGuncelleme DATETIME
ALTER TABLE tbStok ADD nAIKaliteSkor INT DEFAULT 0
```

**Ne için?**
- `bAIIcerikVar`: Bu ürün için AI içerik oluşturuldu mu? (Evet/Hayır)
- `dteAISonGuncelleme`: AI içerik en son ne zaman güncellendi?
- `nAIKaliteSkor`: AI içerik kalite skoru (0-100)

**Nasıl kullanılıyor?**
```vb
' AI işlemi başlamadan önce kontrol
Dim query = "SELECT * FROM tbStok WHERE bAIIcerikVar = 0"  ' AI içeriği olmayan ürünler

' AI işlemi tamamlandıktan sonra
UPDATE tbStok SET bAIIcerikVar = 1, dteAISonGuncelleme = GETDATE() WHERE nStokID = 12345
```

---

#### **tbParamGenel (Parametre Tablosu) - Yeni Kolonlar**
```sql
ALTER TABLE tbParamGenel ADD sEmergentKey NVARCHAR(255)      -- OpenAI API Key
ALTER TABLE tbParamGenel ADD bAIKullan BIT DEFAULT 0          -- AI sistemi aktif mi?
ALTER TABLE tbParamGenel ADD bBaslikOlustur BIT DEFAULT 1     -- Başlık özelliği
ALTER TABLE tbParamGenel ADD bAciklamaOlustur BIT DEFAULT 1   -- Açıklama özelliği
ALTER TABLE tbParamGenel ADD bTalimatOlustur BIT DEFAULT 1    -- Talimat özelliği
ALTER TABLE tbParamGenel ADD bGorselBul BIT DEFAULT 0         -- Görsel bulma
```

**Nasıl kullanılıyor?**
```vb
' Ayarlar formunda
ParameterService.SetParameter("bAIKullan", 1)  ' AI'yi aç
ParameterService.SetParameter("sEmergentKey", "sk-proj-xyz...")  ' API key kaydet

' İşlem sırasında kontrol
If ParameterService.IsFeatureEnabled("bBaslikOlustur") Then
    ' Başlık oluştur
End If
```

---

### **B) YENİ TABLOLAR:**

#### **1. tbStokAIIcerik (AI İçerik Deposu)**
```sql
CREATE TABLE tbStokAIIcerik (
    nAIIcerikID INT PRIMARY KEY IDENTITY(1,1),
    nStokID INT,                          -- Hangi ürün?
    sSEOBaslik NVARCHAR(255),             -- AI tarafından oluşturulan SEO başlığı
    sDetayliAciklama NVARCHAR(MAX),       -- Detaylı ürün açıklaması (HTML)
    sKullanimTalimati NVARCHAR(MAX),      -- Kullanım talimatları
    sMetaDescription NVARCHAR(255),       -- Meta description
    nAIMaliyet DECIMAL(10,2),             -- Bu işlem için harcanan maliyet
    dteOlusturma DATETIME DEFAULT GETDATE(),
    bOnaylandi BIT DEFAULT 0              -- İçerik onaylandı mı?
)
```

**Örnek Veri:**
```
nStokID: 12345
sSEOBaslik: "Nike Air Max 2024 Erkek Spor Ayakkabı - Siyah"
sDetayliAciklama: "<h3>Özellikler</h3><ul><li>Hafif yapı...</li></ul>"
sKullanimTalimati: "<h4>İlk Kullanım</h4><p>Ayakkabınızı..."
sMetaDescription: "Nike Air Max 2024 erkek spor ayakkabısı..."
nAIMaliyet: 0.45
```

**Nasıl kullanılıyor?**
```vb
' Kayıt
INSERT INTO tbStokAIIcerik (nStokID, sSEOBaslik, sDetayliAciklama, ...)
VALUES (12345, 'Nike Air Max...', '<h3>Özellikler...</h3>', ...)

' Okuma
SELECT ai.sSEOBaslik, ai.sDetayliAciklama
FROM tbStok s
JOIN tbStokAIIcerik ai ON s.nStokID = ai.nStokID
WHERE s.nStokID = 12345
```

---

#### **2. tbMusteriKredi (Kredi Hesapları)**
```sql
CREATE TABLE tbMusteriKredi (
    nKrediID INT PRIMARY KEY IDENTITY(1,1),
    nMusteriID INT,                       -- Hangi müşteri?
    nToplamKredi DECIMAL(10,2),           -- Toplam yüklenen kredi
    nKullanilabilirKredi DECIMAL(10,2),   -- Kalan kredi
    nKullanilanKredi DECIMAL(10,2),       -- Kullanılan kredi
    nGunlukKullanim INT,                  -- Bugün kaç ürün işlendi?
    nGunlukLimit INT DEFAULT 100,         -- Günlük limit
    dteGunlukResetTarihi DATE             -- Son reset tarihi
)
```

**Örnek Veri:**
```
nMusteriID: 1
nToplamKredi: 1000.00
nKullanilabilirKredi: 650.00
nKullanilanKredi: 350.00
nGunlukKullanim: 25
nGunlukLimit: 100
```

**Nasıl kullanılıyor?**
```vb
' Kredi kontrolü
SELECT nKullanilabilirKredi FROM tbMusteriKredi WHERE nMusteriID = 1
-- Sonuç: 650.00 TL var mı? (1 işlem = 1.4 TL)

' Kredi düşme
UPDATE tbMusteriKredi 
SET nKullanilabilirKredi = nKullanilabilirKredi - 1.4,
    nKullanilanKredi = nKullanilanKredi + 1.4,
    nGunlukKullanim = nGunlukKullanim + 1
WHERE nMusteriID = 1
```

---

#### **3. tbKrediHareketleri (İşlem Logu)**
```sql
CREATE TABLE tbKrediHareketleri (
    nHareketID INT PRIMARY KEY IDENTITY(1,1),
    nMusteriID INT,
    sHareketTipi VARCHAR(20),             -- "Kullanim" veya "YuklemePaket"
    nMiktar DECIMAL(10,2),                -- +70 veya -1.4
    nStokID INT,                          -- Hangi ürün için?
    sIslemAciklama NVARCHAR(255),         -- "AI içerik oluşturma"
    nOncekiBakiye DECIMAL(10,2),          -- İşlem öncesi bakiye
    nYeniBakiye DECIMAL(10,2),            -- İşlem sonrası bakiye
    dteTarih DATETIME DEFAULT GETDATE()
)
```

**Örnek Log Verisi:**
```
nMusteriID: 1
sHareketTipi: "Kullanim"
nMiktar: -1.4
nStokID: 12345
sIslemAciklama: "AI içerik oluşturma - Nike Air Max"
nOncekiBakiye: 651.4
nYeniBakiye: 650.0
dteTarih: 2025-01-02 14:35:22
```

**Nasıl kullanılıyor?**
```vb
' Her işlemde log ekle
INSERT INTO tbKrediHareketleri 
VALUES (1, 'Kullanim', -1.4, 12345, 'AI içerik oluşturma', 651.4, 650.0, GETDATE())

' Raporlama
SELECT nMusteriID, SUM(nMiktar) AS ToplamHarcama
FROM tbKrediHareketleri
WHERE sHareketTipi = 'Kullanim'
GROUP BY nMusteriID
```

---

#### **4. tbKrediPaketleri (Satılabilir Paketler)**
```sql
CREATE TABLE tbKrediPaketleri (
    nPaketID INT PRIMARY KEY IDENTITY(1,1),
    sPaketAdi NVARCHAR(50),               -- "Başlangıç"
    nUrunSayisi INT,                      -- 500 ürün
    nKrediMiktari DECIMAL(10,2),          -- 700 TL
    nFiyat DECIMAL(10,2),                 -- 699 TL (müşteriye satış)
    sAciklama NVARCHAR(255),
    bAktif BIT DEFAULT 1
)
```

**Örnek Paketler:**
```
1. Başlangıç: 500 ürün → 700 TL kredi → Satış: 699 TL
2. Standart: 1000 ürün → 1400 TL kredi → Satış: 1299 TL  
3. Pro: 3000 ürün → 4200 TL kredi → Satış: 3699 TL
4. Enterprise: 10000 ürün → 14000 TL kredi → Satış: 11999 TL
```

---

## 🔄 ENTEGRASYON AKIŞI (Tam Senaryo)

### **SENARYO: Kullanıcı "Nike Air Max Siyah" Ürünü İçin AI İçerik Oluşturuyor**

```
┌──────────────────────────────────────────────────────┐
│ ADIM 1: Kullanıcı Form Açar                          │
└──────────────────────────────────────────────────────┘
frm_AIUrunIsle formu açılır
└─> LoadCreditStatus() çağrılır
    └─> CreditService.GetCreditBalance(1)
        └─> SQL: SELECT * FROM tbMusteriKredi WHERE nMusteriID = 1
        └─> SONUÇ: 650 TL kredi var
        └─> Form'da gösterir: "💳 Kredi: 650.00 TL"

┌──────────────────────────────────────────────────────┐
│ ADIM 2: Stok ID Girişi                               │
└──────────────────────────────────────────────────────┘
Kullanıcı: txtStokID = "12345" yazar
"İşle" butonuna tıklar

┌──────────────────────────────────────────────────────┐
│ ADIM 3: AIContentManager İşlemi Başlatır            │
└──────────────────────────────────────────────────────┘
AIContentManager.ProcessProduct(12345, 1) çağrılır

├─> [KONTROL 1] ParameterService.IsAIEnabled()
│   └─> SQL: SELECT bAIKullan FROM tbParamGenel WHERE nParamID = 1
│   └─> SONUÇ: 1 (Aktif) ✓

├─> [KONTROL 2] CreditService.CheckCredit(1, 1.4)
│   └─> SQL: SELECT nKullanilabilirKredi FROM tbMusteriKredi WHERE nMusteriID = 1
│   └─> SONUÇ: 650 ≥ 1.4 → Yeterli ✓

├─> [KONTROL 3] CreditService.CheckDailyLimit(1)
│   └─> SQL: SELECT nGunlukKullanim, nGunlukLimit FROM tbMusteriKredi
│   └─> SONUÇ: 25 < 100 → Limit uygun ✓

├─> [VERİ ÇEKME] GetProductData(12345)
│   └─> SQL: SELECT s.*, k.sKategoriAdi FROM tbStok s 
│              LEFT JOIN tbStokSinifi k ON s.nSinifID = k.nSinifID
│              WHERE s.nStokID = 12345
│   └─> SONUÇ:
│       {
│         "nStokID": 12345,
│         "sKodu": "NKE-AM-001",
│         "sAciklama": "Nike Air Max Erkek Spor Ayakkabı",
│         "sModel": "Air Max 2024",
│         "sRenk": "Siyah",
│         "sMarka": "Nike",
│         "sKategoriAdi": "Ayakkabı"
│       }

┌──────────────────────────────────────────────────────┐
│ ADIM 4: AI İçerik Üretimi (OpenAI GPT-5)            │
└──────────────────────────────────────────────────────┘

├─> [BAŞLIK] AIService.GenerateTitle(productData)
│   └─> OpenAI API'ye istek gönder:
│       Prompt: "Nike Air Max 2024 Siyah için SEO başlık oluştur..."
│   └─> GPT-5 Yanıtı: "Nike Air Max 2024 Erkek Spor Ayakkabı - Siyah | Orijinal"
│   └─> Maliyet: ~0.02 TL

├─> [AÇIKLAMA] AIService.GenerateDescription(productData)
│   └─> OpenAI API'ye istek:
│       Prompt: "Nike Air Max için detaylı açıklama yaz..."
│   └─> GPT-5 Yanıtı: 
│       "<h3>Ürün Özellikleri</h3>
│        <ul>
│          <li>Hafif ve dayanıklı Air Max yastıklama</li>
│          <li>Nefes alabilen mesh üst yapı</li>
│          <li>Günlük kullanım için ideal konfor</li>
│        </ul>"
│   └─> Maliyet: ~0.12 TL

├─> [TALİMAT] AIService.GenerateInstructions(productData)
│   └─> Kategori: "Ayakkabı" algılandı
│   └─> GetShoeInstructionPrompt() kullanılır
│   └─> GPT-5 Yanıtı:
│       "<h4>👟 İlk Kullanım</h4>
│        <p>Ayakkabınızı ilk kez giymeden önce...</p>
│        <h4>🧼 Temizlik</h4>
│        <p>Yumuşak bir fırça ve sabunlu su ile...</p>"
│   └─> Maliyet: ~0.10 TL

├─> [META] AIService.GenerateMetaDescription(productData)
│   └─> GPT-5 Yanıtı: "Nike Air Max 2024 erkek spor ayakkabısı..."
│   └─> Maliyet: ~0.02 TL

└─> TOPLAM AI MALİYET: 0.26 TL

┌──────────────────────────────────────────────────────┐
│ ADIM 5: Görsel Bulma (Opsiyonel)                     │
└──────────────────────────────────────────────────────┘

(Eğer bGorselBul = 1 ise)
AIImageFinder.AutoFindAndAddImage(...)
└─> Google Custom Search API'ye istek:
    Query: "Nike Air Max 2024 Siyah"
└─> İlk 3 görseli indir ve kontrol et
└─> En uygun görseli tbStokResim'e kaydet
└─> Maliyet: ~0.175 TL

┌──────────────────────────────────────────────────────┐
│ ADIM 6: Veritabanına Kaydetme                        │
└──────────────────────────────────────────────────────┘

SaveToDatabase(12345, productData, 0.26)
├─> SQL 1: INSERT INTO tbStokAIIcerik
│          (nStokID, sSEOBaslik, sDetayliAciklama, ...)
│          VALUES (12345, 'Nike Air Max...', '<h3>...', ...)
│
└─> SQL 2: UPDATE tbStok 
           SET bAIIcerikVar = 1, 
               dteAISonGuncelleme = GETDATE()
           WHERE nStokID = 12345

┌──────────────────────────────────────────────────────┐
│ ADIM 7: Kredi Düşürme                                │
└──────────────────────────────────────────────────────┘

CreditService.DeductCredit(1, 1.4, 12345, "AI içerik oluşturma")

├─> Mevcut bakiye al: 650.00 TL
├─> Yeni bakiye hesapla: 650.00 - 1.4 = 648.60 TL
│
├─> SQL 1: UPDATE tbMusteriKredi
│          SET nKullanilabilirKredi = 648.60,
│              nKullanilanKredi = nKullanilanKredi + 1.4,
│              nGunlukKullanim = nGunlukKullanim + 1
│          WHERE nMusteriID = 1
│
└─> SQL 2: INSERT INTO tbKrediHareketleri
           (nMusteriID, sHareketTipi, nMiktar, nStokID, ...)
           VALUES (1, 'Kullanim', -1.4, 12345, ...)

┌──────────────────────────────────────────────────────┐
│ ADIM 8: Kullanıcıya Sonuç Gösterme                   │
└──────────────────────────────────────────────────────┘

Form'da Log:
├─> "✅ İşlem BAŞARILI!"
├─> "📝 İşlem başarılı! 1.4 kredi kullanıldı."
├─> "  ✓ SEO Başlık oluşturuldu"
├─> "  ✓ Detaylı açıklama oluşturuldu"
├─> "  ✓ Kullanım talimatları oluşturuldu"
├─> "  ✓ Meta veriler oluşturuldu"
└─> "  ✓ Veritabanına kaydedildi"

MessageBox: "✅ Ürün başarıyla işlendi!"

Kredi güncellendi: "💳 Kredi: 648.60 TL"
```

---

## 📋 VERİ NEREYE YAZILIYOR?

### **İşlem Sonrası Veritabanı Durumu:**

#### **tbStok Tablosu:**
```sql
nStokID: 12345
sKodu: "NKE-AM-001"
sAciklama: "Nike Air Max Erkek Spor Ayakkabı"
bAIIcerikVar: 1 ✅  (ÖNCE: 0, SONRA: 1)
dteAISonGuncelleme: 2025-01-02 14:35:22 ✅  (EKLENDI)
```

#### **tbStokAIIcerik Tablosu:** (YENİ KAYIT)
```sql
nAIIcerikID: 1001 (otomatik)
nStokID: 12345
sSEOBaslik: "Nike Air Max 2024 Erkek Spor Ayakkabı - Siyah | Orijinal"
sDetayliAciklama: "<h3>Ürün Özellikleri</h3><ul><li>Hafif...</li></ul>"
sKullanimTalimati: "<h4>👟 İlk Kullanım</h4>..."
sMetaDescription: "Nike Air Max 2024 erkek spor ayakkabısı..."
nAIMaliyet: 0.26
dteOlusturma: 2025-01-02 14:35:22
bOnaylandi: 0
```

#### **tbMusteriKredi Tablosu:**
```sql
nMusteriID: 1
nToplamKredi: 1000.00 (değişmedi)
nKullanilabilirKredi: 648.60 ✅  (ÖNCE: 650.00, SONRA: 648.60)
nKullanilanKredi: 351.40 ✅  (ÖNCE: 350.00, SONRA: 351.40)
nGunlukKullanim: 26 ✅  (ÖNCE: 25, SONRA: 26)
nGunlukLimit: 100 (değişmedi)
```

#### **tbKrediHareketleri Tablosu:** (YENİ KAYIT)
```sql
nHareketID: 5623 (otomatik)
nMusteriID: 1
sHareketTipi: "Kullanim"
nMiktar: -1.4
nStokID: 12345
sIslemAciklama: "AI içerik oluşturma"
nOncekiBakiye: 650.00
nYeniBakiye: 648.60
dteTarih: 2025-01-02 14:35:22
```

---

## 🔍 AI İÇERİĞİ NASIL KULLANILIR?

### **1. E-Ticaret Sitesinde Gösterme:**

```vb
' Ürün detay sayfasında
Dim query = "SELECT s.sAciklama, ai.sSEOBaslik, ai.sDetayliAciklama, ai.sKullanimTalimati " &
            "FROM tbStok s " &
            "LEFT JOIN tbStokAIIcerik ai ON s.nStokID = ai.nStokID " &
            "WHERE s.nStokID = 12345"

' Sonuç:
' - Sayfa başlığı: ai.sSEOBaslik
' - Ürün açıklaması: ai.sDetayliAciklama (HTML)
' - Kullanım talimatları: ai.sKullanimTalimati (HTML)
```

### **2. XML/Excel Export:**

```vb
' Pazar yerlerine (Trendyol, Hepsiburada) gönderirken
SELECT 
    s.sKodu AS UrunKodu,
    ai.sSEOBaslik AS UrunBasligi,
    ai.sDetayliAciklama AS Aciklama,
    ai.sMetaDescription AS KisaAciklama
FROM tbStok s
JOIN tbStokAIIcerik ai ON s.nStokID = ai.nStokID
WHERE s.bAIIcerikVar = 1
```

### **3. Raporlama:**

```vb
' Hangi ürünler AI'dan geçti?
SELECT COUNT(*) AS ToplamIslenmiş FROM tbStok WHERE bAIIcerikVar = 1

' Toplam harcama
SELECT SUM(nMiktar) AS ToplamHarcama 
FROM tbKrediHareketleri 
WHERE sHareketTipi = 'Kullanim'

' Günlük kullanım
SELECT nMusteriID, nGunlukKullanim, nGunlukLimit 
FROM tbMusteriKredi
```

---

## ⚙️ ÖZELLEŞTİRME VE AYARLAR

### **Hangi Özellikleri Açıp Kapatabilirim?**

**frm_AIAyarlari** formunda:

```
✅ AI Sistemi Aktif (Ana anahtar) → bAIKullan
  ├─ ✅ SEO Başlığı Oluştur → bBaslikOlustur (0.02 TL)
  ├─ ✅ Detaylı Açıklama → bAciklamaOlustur (0.12 TL)
  ├─ ✅ Kullanım Talimatları → bTalimatOlustur (0.10 TL)
  ├─ ⬜ Ürün Görseli Bul → bGorselBul (0.175 TL)
  ├─ ⬜ Görsel Doğrulama → bGorselDogrula (0.05 TL)
  ├─ ⬜ Kategori Önerisi → bKategoriOner (0.05 TL)
  └─ ⬜ Fiyat Optimizasyonu → bFiyatOptimize (0.07 TL)
```

**Her özellik ayrı ayrı açılıp kapatılabilir!**

Örnek:
- Sadece başlık istiyorsanız: 0.02 TL/ürün
- Başlık + Açıklama: 0.14 TL/ürün
- Tüm özellikler: ~0.40-0.60 TL/ürün

Müşteriye satış: **1.4 TL/ürün** (sabit)

---

## 🎯 ÖZET

### **Sistemin 3 Ana Bileşeni:**

1. **UI Layer (Formlar)**
   - frm_AIAyarlari → Ayarları yönet
   - frm_AIUrunIsle → İşlem yap

2. **Business Logic (Servisler)**
   - AIContentManager → Orkestra şefi
   - AIService → OpenAI ile konuşur
   - CreditService → Para yönetimi
   - ParameterService → Ayarları okur

3. **Data Layer (Veritabanı)**
   - tbStok → Ürün bilgileri
   - tbStokAIIcerik → AI içerikleri
   - tbMusteriKredi → Kredi bakiyeleri
   - tbKrediHareketleri → İşlem logları

### **Veri Akışı:**
```
KULLANICI → Form → AIContentManager → Servisler → Database
                                    ↓
                                OpenAI API
```

### **Sonuç:**
Her ürün için:
- AI içerik üretilir
- tbStokAIIcerik'e kaydedilir
- Kredi düşülür
- Log tutulur
- ✅ Hazır!

---

Başka bir kısım için detay ister misiniz? 🚀
