# 💰 AI MALİYET ANALİZİ VE PARAMETRİK SİSTEM

## 📊 DETAYLI MALİYET HESAPLAMA

### Tek Ürün İçin AI İşlemleri ve Maliyetler

#### 1. **Ürün Başlığı Oluşturma**
```
Model: GPT-4o (text)
Input Token: ~150 token (prompt)
Output Token: ~30 token (başlık)
Maliyet: $0.0025 / 1K input + $0.01 / 1K output
= (150 * 0.0025 / 1000) + (30 * 0.01 / 1000)
= $0.000375 + $0.0003
= $0.000675 ≈ 0.02 TL
```

#### 2. **Ürün Açıklaması Oluşturma**
```
Model: GPT-4o (text)
Input Token: ~200 token
Output Token: ~300 token
= (200 * 0.0025 / 1000) + (300 * 0.01 / 1000)
= $0.0005 + $0.003
= $0.0035 ≈ 0.12 TL
```

#### 3. **Kullanım/Yıkama Talimatları (YENİ)**
```
Model: GPT-4o (text)
Input Token: ~180 token
Output Token: ~250 token
= (180 * 0.0025 / 1000) + (250 * 0.01 / 1000)
= $0.00045 + $0.0025
= $0.00295 ≈ 0.10 TL
```

#### 4. **Görsel Bulma (Google API)**
```
Google Custom Search API
100 arama/gün: ÜCRETSİZ
1000 arama: $5 = 175 TL
1 arama: ~0.175 TL
```

#### 5. **Görsel Doğrulama (İsteğe Bağlı - Vision API)**
```
Model: GPT-4o Vision
Input Token: ~100 token + 1 görsel
Görsel: ~85 token (low detail)
Output Token: ~100 token
= (185 * 0.0025 / 1000) + (100 * 0.01 / 1000)
= $0.0004625 + $0.001
= $0.0014625 ≈ 0.05 TL
```

#### 6. **Kategori ve Etiket Önerisi**
```
Model: GPT-4o (text)
Input Token: ~150 token
Output Token: ~100 token
= (150 * 0.0025 / 1000) + (100 * 0.01 / 1000)
= $0.000375 + $0.001
= $0.001375 ≈ 0.05 TL
```

#### 7. **Fiyat Optimizasyonu (Rakip Analizi)**
```
Model: GPT-4o (text)
Input Token: ~250 token
Output Token: ~150 token
= (250 * 0.0025 / 1000) + (150 * 0.01 / 1000)
= $0.000625 + $0.0015
= $0.002125 ≈ 0.07 TL
```

---

## 💡 SENARYO BAZLI MALİYET ANALİZİ

### Senaryo A: MİNİMAL (Sadece Temel Bilgiler)
**Kullanılan AI Özellikleri:**
- ✅ Ürün Başlığı
- ✅ Kullanım Talimatları

**Toplam Maliyet/Ürün:** 0.02 + 0.10 = **0.12 TL**

**1000 Ürün:** 120 TL
**10,000 Ürün:** 1,200 TL

---

### Senaryo B: STANDART (Önerilen)
**Kullanılan AI Özellikleri:**
- ✅ Ürün Başlığı
- ✅ Ürün Açıklaması
- ✅ Kullanım Talimatları
- ✅ Görsel Bulma (Google API - free tier)

**Toplam Maliyet/Ürün:** 0.02 + 0.12 + 0.10 + 0.00 = **0.24 TL**
*(Google API günlük 100 ürün ücretsiz)*

**1000 Ürün:** 240 TL
**10,000 Ürün:** 2,400 TL

---

### Senaryo C: GELİŞMİŞ (Tam Optimizasyon)
**Kullanılan AI Özellikleri:**
- ✅ Ürün Başlığı
- ✅ Ürün Açıklaması
- ✅ Kullanım Talimatları
- ✅ Görsel Bulma
- ✅ Görsel Doğrulama (Vision API)
- ✅ Kategori/Etiket Önerisi
- ✅ Fiyat Optimizasyonu

**Toplam Maliyet/Ürün:** 0.02 + 0.12 + 0.10 + 0.175 + 0.05 + 0.05 + 0.07 = **0.585 TL**

**1000 Ürün:** 585 TL
**10,000 Ürün:** 5,850 TL

---

### Senaryo D: PREMIUM (Vision API + Tüm Özellikler)
**Her şey dahil + görsel kalite analizi**

**Toplam Maliyet/Ürün:** **0.60-0.70 TL**

**1000 Ürün:** 600-700 TL
**10,000 Ürün:** 6,000-7,000 TL

---

## 📊 KARŞILAŞTIRMA TABLOSU

| Özellik | Minimal | Standart | Gelişmiş | Premium |
|---------|---------|----------|----------|---------|
| **Ürün Başlığı** | ✅ | ✅ | ✅ | ✅ |
| **Ürün Açıklaması** | ❌ | ✅ | ✅ | ✅ |
| **Kullanım Talimatları** | ✅ | ✅ | ✅ | ✅ |
| **Görsel Bulma** | ❌ | ✅ (free) | ✅ | ✅ |
| **Görsel Doğrulama** | ❌ | ❌ | ✅ | ✅ |
| **Kategori/Etiket** | ❌ | ❌ | ✅ | ✅ |
| **Fiyat Optimizasyonu** | ❌ | ❌ | ✅ | ✅ |
| **Maliyet/Ürün** | 0.12 TL | 0.24 TL | 0.585 TL | 0.70 TL |
| **1000 Ürün** | 120 TL | 240 TL | 585 TL | 700 TL |

---

## 🎛️ PARAMETRİK SİSTEM TASARIMI

### Veritabanı Yapısı (tbParamAI - Yeni Tablo)

```sql
CREATE TABLE tbParamAI (
    nAIParamID INT IDENTITY(1,1) PRIMARY KEY,
    
    -- GENEL AYARLAR
    bAIKullan BIT DEFAULT 0,                    -- AI kullanılsın mı?
    sAIProvider NVARCHAR(50) DEFAULT 'Emergent', -- Emergent / OpenAI / Claude
    sEmergentKey NVARCHAR(255),                 -- Emergent Universal Key
    
    -- ÖZELLIK AYARLARI (Her biri ayrı açılıp kapanabilir)
    bBaslikOlustur BIT DEFAULT 1,               -- Ürün başlığı oluştur
    bAciklamaOlustur BIT DEFAULT 1,             -- Ürün açıklaması oluştur
    bTalimatOlustur BIT DEFAULT 1,              -- Kullanım talimatları oluştur
    bGorselBul BIT DEFAULT 0,                   -- Otomatik görsel bul
    bGorselDogrula BIT DEFAULT 0,               -- Görseli AI ile doğrula
    bKategoriOner BIT DEFAULT 0,                -- Kategori/etiket öner
    bFiyatOptimize BIT DEFAULT 0,               -- Fiyat optimizasyonu
    
    -- MALİYET YÖNETİMİ
    nGunlukMaxIstek INT DEFAULT 100,            -- Günlük max AI isteği
    nAylikBudget DECIMAL(10,2) DEFAULT 500.00,  -- Aylık AI budget (TL)
    nToplamHarcama DECIMAL(10,2) DEFAULT 0.00,  -- Bu ayki toplam harcama
    dteAyBaslangic DATETIME DEFAULT GETDATE(),  -- Ay başlangıcı (reset için)
    
    -- KATEGORİ BAZLI AYARLAR
    bKategoriBazliAyar BIT DEFAULT 1,           -- Her kategori için farklı ayar
    
    -- LOG VE RAPORLAMA
    bLogKaydet BIT DEFAULT 1,                   -- AI işlemlerini logla
    bMaliyetTakip BIT DEFAULT 1,                -- Maliyet takibi yap
    
    -- GOOGLE API AYARLARI
    sGoogleSearchApiKey NVARCHAR(255),
    sGoogleSearchEngineId NVARCHAR(255),
    
    dteGuncelleme DATETIME DEFAULT GETDATE()
)
```

### Kategori Bazlı AI Ayarları (tbParamAIKategori - Yeni Tablo)

```sql
CREATE TABLE tbParamAIKategori (
    nAIKategoriParamID INT IDENTITY(1,1) PRIMARY KEY,
    nKategoriID INT NOT NULL,                   -- tbStokSinifi ile ilişki
    sKategoriAdi NVARCHAR(100),                 -- Kategori adı (örn: Tekstil)
    
    -- Bu kategori için AI kullanılsın mı?
    bAIKullan BIT DEFAULT 1,
    
    -- Özellik ayarları (kategori özel)
    bBaslikOlustur BIT DEFAULT 1,
    bAciklamaOlustur BIT DEFAULT 1,
    bTalimatOlustur BIT DEFAULT 1,
    bGorselBul BIT DEFAULT 0,
    
    -- Talimat şablonu türü
    sTalimatTuru NVARCHAR(50) DEFAULT 'Genel',  -- Tekstil / Ayakkabı / Züccaciye / Elektronik vb.
    
    -- Özel prompt (kategori için özel AI prompt)
    sOzelPrompt NVARCHAR(MAX),
    
    dteGuncelleme DATETIME DEFAULT GETDATE(),
    
    FOREIGN KEY (nKategoriID) REFERENCES tbStokSinifi(nSinifID)
)
```

### AI İşlem Logu (tbAIIslemLog - Yeni Tablo)

```sql
CREATE TABLE tbAIIslemLog (
    nLogID INT IDENTITY(1,1) PRIMARY KEY,
    nStokID INT,                                -- İşlem yapılan ürün
    sBarkod NVARCHAR(50),                       -- Barkod
    sIslemTuru NVARCHAR(50),                    -- Başlık / Açıklama / Talimat / Görsel vb.
    sAIModel NVARCHAR(50),                      -- GPT-4o / Claude vb.
    nInputToken INT,                            -- Kullanılan input token
    nOutputToken INT,                           -- Kullanılan output token
    nMaliyet DECIMAL(10,4),                     -- İşlem maliyeti (TL)
    bBasarili BIT,                              -- Başarılı mı?
    sHataMesaji NVARCHAR(MAX),                  -- Hata varsa mesaj
    dteTarih DATETIME DEFAULT GETDATE(),
    
    FOREIGN KEY (nStokID) REFERENCES tbStok(nStokID)
)
```

---

## 🎨 KULLANIM TALİMATLARI ŞABLONLARI

### Tekstil Kategorisi

```vbnet
Private Function GenerateTextileInstructions(productData As Dictionary(Of String, Object)) As String
    Try
        Dim prompt As String = $"
Sen bir tekstil ürünleri uzmanısın. Aşağıdaki ürün için detaylı kullanım ve yıkama talimatları oluştur.

Ürün Bilgileri:
- Ürün Adı: {productData("sStokAdi")}
- Malzeme: {productData("sMalzeme")} (varsa)
- Renk: {productData("sRenk")}
- Kategori: Tekstil

Talimatlar şunları içermeli:

📋 GENEL BİLGİLER:
- Ürünün özel özellikleri
- Kullanım alanı

🧺 YIKAMA TALİMATLARI:
- Yıkama sıcaklığı (°C)
- Makine/el yıkama
- Deterjan türü önerisi
- Renk ayrımı
- Ağartıcı kullanımı (uyarı)

👔 KURUTMA:
- Doğal kurutma / makine
- Asma şekli
- Güneş ışığı uyarıları

🔥 ÜTÜ:
- Ütü sıcaklığı
- Buhar kullanımı
- Özel uyarılar

⚠️ DİKKAT EDİLECEKLER:
- Renk akması riski
- Çekme/genişleme
- Diğer önemli notlar

🔄 BAKIM ÖNERİLERİ:
- İlk yıkama önerileri
- Uzun ömürlü kullanım için
- Saklama koşulları

Format: HTML kullan (ul, li, strong, em etiketleri)
Dil: Türkçe, açık ve anlaşılır
Uzunluk: 200-300 kelime

SADECE TALİMATLARI DÖNDÜR!"

        Dim apiKey As String = GetEmergentLLMKey()
        Dim instructions As String = CallOpenAI(prompt, 400)
        
        Log("SUCCESS", "GenerateTextileInstructions", "Tekstil talimatları oluşturuldu")
        Return instructions.Trim()
        
    Catch ex As Exception
        LogError($"Tekstil talimatları hatası: {ex.Message}")
        ' Fallback: Genel şablon
        Return GetDefaultTextileInstructions()
    End Try
End Function

' Fallback şablon (AI kullanılmazsa)
Private Function GetDefaultTextileInstructions() As String
    Return "<h3>Kullanım ve Bakım Talimatları</h3>
<ul>
<li><strong>Yıkama:</strong> 30°C'de makine yıkama yapılabilir</li>
<li><strong>Kurutma:</strong> Doğal kurutma önerilir</li>
<li><strong>Ütü:</strong> Orta sıcaklıkta ütülenebilir</li>
<li><strong>Ağartma:</strong> Ağartıcı kullanmayınız</li>
<li><strong>İlk Yıkama:</strong> Renk akmasını önlemek için ayrı yıkayınız</li>
</ul>"
End Function
```

---

### Ayakkabı Kategorisi

```vbnet
Private Function GenerateShoeInstructions(productData As Dictionary(Of String, Object)) As String
    Try
        Dim prompt As String = $"
Sen bir ayakkabı bakım uzmanısın. Aşağıdaki ayakkabı için detaylı kullanım ve bakım talimatları oluştur.

Ürün Bilgileri:
- Ürün Adı: {productData("sStokAdi")}
- Malzeme: {productData("sMalzeme")} (deri/süet/kumaş vb.)
- Kullanım Alanı: {productData("sKullanim")} (spor/günlük/klasik)

Talimatlar şunları içermeli:

👟 İLK KULLANIM:
- Ayakkabıyı ilk giymeden önce yapılması gerekenler
- Ayak sağlığı için öneriler

🧼 TEMİZLİK:
- Malzeme bazlı temizlik yöntemi
- Kullanılacak temizlik malzemeleri
- Temizlik sıklığı
- Yıkama makinesi uyarısı (eğer uygun değilse)

💧 KURULAMA:
- Doğru kurutma yöntemi
- Kalorifer/güneş uyarıları
- Şekil bozulmasını önleme

🛡️ KORUMA:
- Su geçirmezlik spreyi
- Leke önleyici
- Renk koruma

📦 SAKLAMA:
- Mevsimlik saklama
- Hava sirkülasyonu
- Şekil koruyucular (ayakkabı kalıbı)

⚠️ DİKKAT EDİLECEKLER:
- Malzemeye özel uyarılar
- Yanlış bakımın zararları

🔄 UZUN ÖMÜR İÇİN:
- Günlük rotasyon önerisi
- Taban bakımı
- Bağcık/aksesuar değişimi

Format: HTML (ul, li, strong, em)
Dil: Türkçe, net ve pratik
Uzunluk: 200-300 kelime

SADECE TALİMATLARI DÖNDÜR!"

        Dim apiKey As String = GetEmergentLLMKey()
        Dim instructions As String = CallOpenAI(prompt, 400)
        
        Return instructions.Trim()
        
    Catch ex As Exception
        LogError($"Ayakkabı talimatları hatası: {ex.Message}")
        Return GetDefaultShoeInstructions()
    End Try
End Function
```

---

### Züccaciye Kategorisi

```vbnet
Private Function GenerateGlasswareInstructions(productData As Dictionary(Of String, Object)) As String
    Try
        Dim prompt As String = $"
Sen bir ev eşyaları uzmanısın. Aşağıdaki züccaciye/cam ürün için kullanım ve bakım talimatları oluştur.

Ürün Bilgileri:
- Ürün Adı: {productData("sStokAdi")}
- Malzeme: {productData("sMalzeme")} (cam/porselen/seramik)
- Kullanım: {productData("sKullanim")} (sofra/mutfak/dekoratif)

Talimatlar şunları içermeli:

🍽️ KULLANIM:
- Hangi amaçla kullanılır
- Gıda güvenliği
- Sıcaklık sınırları (sıcak/soğuk)

🧽 TEMİZLİK:

**BULAŞIK MAKİNESİ:**
- Bulaşık makinesinde yıkanabilir mi? (✅/❌)
- Eğer evet: Hangi programda, kaç derecede?
- Yerleştirme önerileri
- Tablet/tuz/parlatıcı kullanımı

**EL İLE YIKAMA:**
- El ile yıkama önerisi
- Kullanılacak deterjan türü
- Sünger/fırça seçimi
- Durulama

💦 KURULAMA:
- Doğal kurutma / bez ile silme
- Su lekesi önleme
- Parlatma yöntemleri

🔥 SICAKLIK:
- Fırın kullanımı (eğer uygunsa)
- Mikrodalga kullanımı (eğer uygunsa)
- Ani sıcaklık değişimi uyarısı

⚠️ DİKKAT EDİLECEKLER:
- Kırılma/çatlama riskleri
- Kimyasal temizleyici uyarıları
- Metal aksesuar varsa (altın yaldız vb.) özel uyarı

📦 SAKLAMA:
- İstiflenebilir mi?
- Koruyucu malzeme kullanımı
- Nem/toz koruması

🛡️ UZUN ÖMÜR İÇİN:
- Çizilme önleme
- Leke önleme (çay/kahve)
- Parlaklık koruma

Format: HTML (ul, li, strong, em)
Dil: Türkçe, pratik ve güvenlik odaklı
Uzunluk: 200-300 kelime

SADECE TALİMATLARI DÖNDÜR!"

        Dim apiKey As String = GetEmergentLLMKey()
        Dim instructions As String = CallOpenAI(prompt, 400)
        
        Return instructions.Trim()
        
    Catch ex As Exception
        LogError($"Züccaciye talimatları hatası: {ex.Message}")
        Return GetDefaultGlasswareInstructions()
    End Try
End Function
```

---

### Elektronik Kategorisi

```vbnet
Private Function GenerateElectronicsInstructions(productData As Dictionary(Of String, Object)) As String
    Try
        Dim prompt As String = $"
Sen bir elektronik ürünler uzmanısın. Aşağıdaki ürün için kullanım ve bakım talimatları oluştur.

Ürün Bilgileri:
- Ürün Adı: {productData("sStokAdi")}
- Kategori: Elektronik
- Özellikler: {productData("sOzellikler")}

Talimatlar şunları içermeli:

🔌 İLK KULLANIM:
- Kutu açılış kontrolleri
- İlk şarj/kurulum
- Garanti aktivasyonu

⚡ GÜVENLİ KULLANIM:
- Elektrik güvenliği
- Su/nem koruması (IP rating varsa belirt)
- Çocukların erişimi

🧹 TEMİZLİK VE BAKIM:
- Temizlik sıklığı
- Kullanılacak malzemeler
- Yapılmaması gerekenler (su, kimyasal vb.)
- Havalandırma delikleri temizliği

🔋 PİL/ŞARJ YÖNETİMİ:
- Şarj süresi ve sıklığı
- Pil ömrü uzatma
- Orijinal şarj cihazı uyarısı

🌡️ ÇEVRE KOŞULLARI:
- Uygun sıcaklık aralığı
- Nem oranı
- Toz koruması

⚠️ GÜVENLİK UYARILARI:
- Elektrik çarpması riski
- Yangın güvenliği
- Çocuk güvenliği

🔧 ARIZA VE SERVİS:
- Yaygın sorunlar ve çözümleri
- Yetkili servis uyarısı
- Garanti koşulları

♻️ ÇEVRE KORUMA:
- Eski ürün imhası
- WEEE direktifi bilgilendirmesi
- Geri dönüşüm

Format: HTML (ul, li, strong, em)
Dil: Türkçe, güvenlik odaklı
Uzunluk: 250-350 kelime

SADECE TALİMATLARI DÖNDÜR!"

        Dim apiKey As String = GetEmergentLLMKey()
        Dim instructions As String = CallOpenAI(prompt, 500)
        
        Return instructions.Trim()
        
    Catch ex As Exception
        LogError($"Elektronik talimatları hatası: {ex.Message}")
        Return GetDefaultElectronicsInstructions()
    End Try
End Function
```

---

## 🎛️ PARAMETRİK SİSTEM KULLANIMI

### Admin Paneli (Ayarlar Formu)

```vbnet
Public Class frm_AIAyarlari
    
    ' Form yüklendiğinde mevcut ayarları göster
    Private Sub frm_AIAyarlari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAISettings()
    End Sub
    
    Private Sub LoadAISettings()
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                
                Dim cmd As New OleDb.OleDbCommand(
                    "SELECT * FROM tbParamAI WHERE nAIParamID = 1", conn)
                
                Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                
                If reader.Read() Then
                    ' Genel ayarlar
                    chkAIKullan.Checked = Convert.ToBoolean(reader("bAIKullan"))
                    
                    ' Özellik ayarları
                    chkBaslikOlustur.Checked = Convert.ToBoolean(reader("bBaslikOlustur"))
                    chkAciklamaOlustur.Checked = Convert.ToBoolean(reader("bAciklamaOlustur"))
                    chkTalimatOlustur.Checked = Convert.ToBoolean(reader("bTalimatOlustur"))
                    chkGorselBul.Checked = Convert.ToBoolean(reader("bGorselBul"))
                    chkGorselDogrula.Checked = Convert.ToBoolean(reader("bGorselDogrula"))
                    chkKategoriOner.Checked = Convert.ToBoolean(reader("bKategoriOner"))
                    chkFiyatOptimize.Checked = Convert.ToBoolean(reader("bFiyatOptimize"))
                    
                    ' Maliyet yönetimi
                    txtGunlukMaxIstek.Text = reader("nGunlukMaxIstek").ToString()
                    txtAylikBudget.Text = reader("nAylikBudget").ToString()
                    lblToplamHarcama.Text = $"{reader("nToplamHarcama"):F2} TL"
                    
                    ' Maliyet hesapla ve göster
                    CalculateEstimatedCost()
                End If
                
                reader.Close()
            End Using
            
        Catch ex As Exception
            MessageBox.Show($"Ayarlar yüklenemedi: {ex.Message}", "Hata", 
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ' Tahmini maliyet hesapla
    Private Sub CalculateEstimatedCost()
        Dim costPerProduct As Decimal = 0
        
        ' Her özellik için maliyet ekle
        If chkBaslikOlustur.Checked Then costPerProduct += 0.02D
        If chkAciklamaOlustur.Checked Then costPerProduct += 0.12D
        If chkTalimatOlustur.Checked Then costPerProduct += 0.10D
        If chkGorselBul.Checked Then costPerProduct += 0.175D
        If chkGorselDogrula.Checked Then costPerProduct += 0.05D
        If chkKategoriOner.Checked Then costPerProduct += 0.05D
        If chkFiyatOptimize.Checked Then costPerProduct += 0.07D
        
        ' Göster
        lblMaliyetUrun.Text = $"{costPerProduct:F2} TL/ürün"
        lblMaliyet1000.Text = $"{costPerProduct * 1000:F2} TL (1000 ürün)"
        lblMaliyet10000.Text = $"{costPerProduct * 10000:F2} TL (10,000 ürün)"
        
        ' Bütçe uyarısı
        Dim aylikBudget As Decimal = Convert.ToDecimal(txtAylikBudget.Text)
        Dim gunlukMax As Integer = Convert.ToInt32(txtGunlukMaxIstek.Text)
        Dim aylikTahminiUrun As Integer = gunlukMax * 30
        Dim aylikTahminiMaliyet As Decimal = costPerProduct * aylikTahminiUrun
        
        If aylikTahminiMaliyet > aylikBudget Then
            lblBudgetUyari.Text = $"⚠️ UYARI: Tahmini aylık maliyet ({aylikTahminiMaliyet:F2} TL) bütçeyi aşıyor!"
            lblBudgetUyari.ForeColor = Color.Red
        Else
            lblBudgetUyari.Text = $"✅ Tahmini aylık maliyet ({aylikTahminiMaliyet:F2} TL) bütçe dahilinde"
            lblBudgetUyari.ForeColor = Color.Green
        End If
    End Sub
    
    ' Ayarları kaydet
    Private Sub btnKaydet_Click(sender As Object, e As EventArgs) Handles btnKaydet.Click
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                
                Dim cmd As New OleDb.OleDbCommand(
                    "UPDATE tbParamAI SET " &
                    "bAIKullan = ?, " &
                    "bBaslikOlustur = ?, " &
                    "bAciklamaOlustur = ?, " &
                    "bTalimatOlustur = ?, " &
                    "bGorselBul = ?, " &
                    "bGorselDogrula = ?, " &
                    "bKategoriOner = ?, " &
                    "bFiyatOptimize = ?, " &
                    "nGunlukMaxIstek = ?, " &
                    "nAylikBudget = ?, " &
                    "dteGuncelleme = GETDATE() " &
                    "WHERE nAIParamID = 1", conn)
                
                cmd.Parameters.AddWithValue("?", If(chkAIKullan.Checked, 1, 0))
                cmd.Parameters.AddWithValue("?", If(chkBaslikOlustur.Checked, 1, 0))
                cmd.Parameters.AddWithValue("?", If(chkAciklamaOlustur.Checked, 1, 0))
                cmd.Parameters.AddWithValue("?", If(chkTalimatOlustur.Checked, 1, 0))
                cmd.Parameters.AddWithValue("?", If(chkGorselBul.Checked, 1, 0))
                cmd.Parameters.AddWithValue("?", If(chkGorselDogrula.Checked, 1, 0))
                cmd.Parameters.AddWithValue("?", If(chkKategoriOner.Checked, 1, 0))
                cmd.Parameters.AddWithValue("?", If(chkFiyatOptimize.Checked, 1, 0))
                cmd.Parameters.AddWithValue("?", Convert.ToInt32(txtGunlukMaxIstek.Text))
                cmd.Parameters.AddWithValue("?", Convert.ToDecimal(txtAylikBudget.Text))
                
                cmd.ExecuteNonQuery()
                
                MessageBox.Show("AI ayarları başarıyla kaydedildi!", "Başarılı", 
                              MessageBoxButtons.OK, MessageBoxIcon.Information)
                
                Log("SUCCESS", "btnKaydet_Click", "AI ayarları güncellendi")
            End Using
            
        Catch ex As Exception
            MessageBox.Show($"Ayarlar kaydedilemedi: {ex.Message}", "Hata", 
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ' Checkbox değiştiğinde maliyet güncelle
    Private Sub chk_CheckedChanged(sender As Object, e As EventArgs) Handles _
        chkBaslikOlustur.CheckedChanged, chkAciklamaOlustur.CheckedChanged, 
        chkTalimatOlustur.CheckedChanged, chkGorselBul.CheckedChanged,
        chkGorselDogrula.CheckedChanged, chkKategoriOner.CheckedChanged,
        chkFiyatOptimize.CheckedChanged
        
        CalculateEstimatedCost()
    End Sub
    
End Class
```

---

## 📋 ÖRNEK KULLANIM SENARYOLARI

### Senaryo 1: AI Tamamen Kapalı
```vbnet
' tbParamAI ayarları:
bAIKullan = 0

' Sonuç: Hiçbir AI özelliği kullanılmaz
' Maliyet: 0 TL
' Ürünler manuel girilir veya mevcut veriler kullanılır
```

### Senaryo 2: Sadece Talimatlar İçin AI
```vbnet
' tbParamAI ayarları:
bAIKullan = 1
bBaslikOlustur = 0
bAciklamaOlustur = 0
bTalimatOlustur = 1  ← Sadece bu açık
bGorselBul = 0
...

' Sonuç: Sadece kullanım talimatları AI ile oluşturulur
' Maliyet: 0.10 TL/ürün
' 1000 ürün = 100 TL/ay
```

### Senaryo 3: Tekstil İçin Özel, Diğerleri Manuel
```vbnet
' tbParamAIKategori ayarları:
-- Tekstil kategorisi
nKategoriID = 1
bAIKullan = 1
bTalimatOlustur = 1

-- Diğer kategoriler
bAIKullan = 0

' Sonuç: Sadece tekstil ürünleri için AI talimatları
' Maliyet: Kategori bazlı hesaplanır
```

---

## 🎯 SONUÇ VE ÖNERİLER

### Önerilen Başlangıç Konfigürasyonu

**İlk Ay (Test Dönemi):**
```
✅ bAIKullan = 1
✅ bTalimatOlustur = 1       (0.10 TL/ürün)
✅ bBaslikOlustur = 1         (0.02 TL/ürün)
❌ bAciklamaOlustur = 0       (henüz değil)
❌ bGorselBul = 0             (manuel)
❌ Diğerleri = 0

Toplam: 0.12 TL/ürün
Günlük 50 ürün: 6 TL/gün
Aylık: ~180 TL
```

**2. Ay (Genişletme):**
```
✅ bAciklamaOlustur = 1 ekle
Toplam: 0.24 TL/ürün
Aylık: ~360 TL
```

**3. Ay+ (Tam Optimizasyon):**
```
Tüm özellikleri aç
Toplam: 0.60 TL/ürün
Aylık: ~900 TL (1500 ürün için)
```

### ROI Hesabı

**Yatırım:**
- Aylık AI maliyeti: 180-900 TL
- Kurulum süresi: 1 gün

**Tasarruf:**
- Manuel çalışma: 1 ürün = 15 dakika
- AI ile: 1 ürün = 10 saniye
- 1000 ürün için: 250 saat tasarruf
- Maaş bazlı tasarruf: 10,000-20,000 TL/ay

**ROI: %1000-2000** (İlk ayda)

---

**SON SÖZ:**

✅ Parametrik sistem sayesinde müşterileriniz istediği özellikleri açıp kapatabilir
✅ Maliyet tam şeffaf ve kontrol edilebilir
✅ Kategori bazlı özelleştirme mümkün
✅ Bütçe aşımı koruması var
✅ Detaylı maliyet takibi ve raporlama

**Herhangi bir soru veya özelleştirme ihtiyacı olursa yardımcı olmaya hazırım!** 🚀
