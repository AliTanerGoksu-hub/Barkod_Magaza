# 🤖 AI SİSTEM KURULUM ve KULLANIM KILAVUZU

## ✅ TAMAMLANAN İŞLEMLER

### 1. Kod Entegrasyonu
- ✅ **AIService.vb** - OpenAI GPT-5 entegrasyonu (içerik üretimi)
- ✅ **AIContentManager.vb** - Ana orkestrasyon modülü
- ✅ **CreditService.vb** - Kredi yönetim sistemi
- ✅ **ParameterService.vb** - Parametre yönetimi
- ✅ **AIImageFinder.vb** - Görsel bulma servisi
- ✅ **frm_AIAyarlari.vb** - AI ayarları formu
- ✅ **frm_AIUrunIsle.vb** - Ürün işleme formu
- ✅ Tüm dosyalar **BARKOD_MAGAZA.vbproj** projesine eklendi

### 2. Model Seçimi
**Seçilen AI Servisi: OpenAI GPT-5**

**Neden GPT-5?**
- ✅ En güncel model (2025)
- ✅ Türkçe dil desteği mükemmel
- ✅ E-ticaret içerik üretimi için optimize
- ✅ Hız/kalite dengesi en iyi
- ✅ Ürün başına maliyet: ~0.01-0.02 USD

### 3. Özellikler
- ✅ SEO-friendly başlık oluşturma
- ✅ Detaylı ürün açıklaması
- ✅ Kategori bazlı kullanım talimatları (tekstil, ayakkabı, züccaciye, elektronik)
- ✅ Meta description oluşturma
- ✅ Ürün görseli bulma (Google Custom Search)
- ✅ Kredi bazlı monetizasyon sistemi (1.4 TL/ürün)
- ✅ Parametrik on/off kontrol
- ✅ Günlük limit sistemi

---

## 📋 KURULUM ADIMLARI

### Adım 1: Veritabanı Güncellemesi

1. **SQL Server Management Studio** (SSMS) açın
2. **INSTALL_DATABASE.sql** dosyasını açın (proje ana dizininde)
3. Script'in başındaki veritabanı adını kendi veritabanınıza göre güncelleyin:
   ```sql
   USE [BARKOD_MAGAZA]  -- Kendi veritabanı adınızı yazın
   ```
4. **F5** tuşuna basarak script'i çalıştırın
5. Script şunları yapacak:
   - `tbParamGenel` tablosuna AI parametreleri ekleyecek
   - `tbStok` tablosuna AI flag alanları ekleyecek
   - `tbStokAIIcerik` tablosunu oluşturacak (AI içerikler için)
   - `tbMusteriKredi` tablosunu oluşturacak (kredi sistemi)
   - `tbKrediHareketleri` tablosunu oluşturacak (işlem log)
   - `tbKrediPaketleri` tablosunu oluşturacak (paket tanımları)

**Kontrol:**
```sql
SELECT * FROM tbParamGenel WHERE nParamID = 1
-- Yeni sütunlar görmeli: bAIKullan, sEmergentKey, vb.
```

---

### Adım 2: Visual Studio'da Projeyi Derle

1. **BARKOD_MAGAZA.sln** dosyasını Visual Studio'da açın
2. **Build > Rebuild Solution** yapın
3. Hata yoksa tüm modüller başarıyla derlenmiştir

**Olası Hatalar:**
- **"Namespace yok" hatası**: Projeyi Clean > Rebuild yapın
- **DevExpress hatası**: DevExpress referansları mevcut olmalı (zaten kurulu)

---

### Adım 3: API Key'leri Alın

#### OpenAI GPT-5 API Key

1. **https://platform.openai.com/** adresine gidin
2. Hesap oluşturun veya giriş yapın
3. **API Keys** bölümüne gidin
4. **"Create new secret key"** butonuna tıklayın
5. Key'i kopyalayın (örnek: `sk-proj-xyz123...`)

**ÖNEMLİ:** 
- Key'i güvenli bir yerde saklayın (bir daha gösterilmez)
- Billing kısmından kredi kartı ekleyin (minimum $5 yükleme)
- Usage limits ayarlayın (örnek: $50/ay)

**Maliyet Hesabı:**
- GPT-5 Input: ~$0.005/1K token
- GPT-5 Output: ~$0.015/1K token
- Ortalama ürün: ~400 token (input + output)
- **Ürün başına maliyet: ~0.01-0.02 USD (~0.30-0.60 TL)**
- Müşteriye satış: **1.4 TL/ürün** (kar marjı: ~2x)

#### Google Custom Search API (Görsel Bulma İçin - Opsiyonel)

1. **https://console.cloud.google.com/** gidin
2. Yeni proje oluşturun
3. **APIs & Services > Library** bölümünde **"Custom Search API"** aratın ve aktif edin
4. **Credentials** > **Create Credentials** > **API Key**
5. Key'i kopyalayın

**Custom Search Engine ID:**
1. **https://programmablesearchengine.google.com/** gidin
2. **"Add"** butonuna tıklayın
3. "Search the entire web" seçin
4. Create deyip **Engine ID**'yi kopyalayın

**Maliyet:** İlk 100 sorgu/gün ücretsiz, sonrası $5/1000 sorgu

---

### Adım 4: Uygulamada AI Ayarlarını Yapın

1. Uygulamayı çalıştırın
2. **AI Ayarları** formunu açın:
   ```vb
   Dim frmAI As New frm_AIAyarlari()
   frmAI.ShowDialog()
   ```

3. **API Key'leri girin:**
   - **Emergent LLM Key**: OpenAI API Key'inizi buraya yapıştırın
   - **Google Search API Key**: (Görsel bulma için)
   - **Google Engine ID**: (Görsel bulma için)

4. **Özellikleri aktif edin:**
   - ✅ AI Sistemi Aktif (Ana anahtar)
   - ✅ SEO Başlığı Oluştur
   - ✅ Detaylı Açıklama Oluştur
   - ✅ Kullanım Talimatları Oluştur
   - ⬜ Ürün Görseli Bul (Google API gerekli)

5. **Kaydet** butonuna tıklayın

---

## 🚀 KULLANIM

### Tek Ürün İşleme

```vb
Dim aiManager As New AIContentManager()
Dim result As Dictionary(Of String, Object) = aiManager.ProcessProduct(nStokID:=12345, musteriID:=1)

If Convert.ToBoolean(result("success")) Then
    MessageBox.Show("AI içerik başarıyla oluşturuldu!")
Else
    MessageBox.Show(result("message").ToString())
End If
```

### Toplu İşlem

```vb
Dim aiManager As New AIContentManager()
Dim result As Dictionary(Of String, Object) = aiManager.ProcessBulkProducts(musteriID:=1, maxCount:=100)

MessageBox.Show($"{result("successful")} ürün işlendi!")
```

### Kredi Kontrolü

```vb
Dim creditService As New CreditService()
Dim balance As Dictionary(Of String, Object) = creditService.GetCreditBalance(musteriID:=1)

If balance IsNot Nothing Then
    MessageBox.Show($"Mevcut kredi: {balance("kullanilabilir")} TL")
End If
```

---

## 💰 MONETİZASYON SİSTEMİ

### Fiyatlandırma

**Müşteriye Satış Fiyatı:** 1.4 TL/ürün

**Sizin Maliyet Dağılımı (ürün başına):**
- SEO Başlık: 0.02 TL
- Detaylı Açıklama: 0.12 TL
- Kullanım Talimatı: 0.10 TL
- Görsel Bulma: 0.175 TL
- Meta Description: 0.02 TL
- **Toplam:** ~0.40-0.60 TL

**Kar Marjı:** ~0.80-1.00 TL/ürün (%100-150 kar)

### Kredi Paketleri (Örnek)

Database'de `tbKrediPaketleri` tablosuna paketler ekleyebilirsiniz:

```sql
INSERT INTO tbKrediPaketleri (sPaketAdi, nUrunSayisi, nKrediMiktari, nFiyat, sAciklama, bAktif)
VALUES 
('Başlangıç', 50, 70, 89.99, '50 ürün için AI içerik', 1),
('Standart', 200, 280, 299.99, '200 ürün için AI içerik', 1),
('Premium', 1000, 1400, 1299.99, '1000 ürün için AI içerik', 1)
```

---

## 🧪 TEST

### Basit Test

1. tbStok tablosundan bir ürün seçin
2. Aşağıdaki kodu çalıştırın:

```vb
Dim aiManager As New AIContentManager()
Dim testResult = aiManager.ProcessProduct(nStokID:=123, musteriID:=1)
Console.WriteLine(testResult("message"))
```

### Tam Test Senaryosu

1. **Parametre kontrolü**: AI sistemi açık mı?
2. **Kredi kontrolü**: Müşterinin yeterli kredisi var mı?
3. **İçerik üretimi**: GPT-5'ten başlık, açıklama alınıyor mu?
4. **Veritabanı kaydı**: tbStokAIIcerik'e yazılıyor mu?
5. **Log kontrolü**: Hatalar `AI_Content_Manager.log` dosyasında

---

## ⚙️ ANA MENÜYE EKLEME

Uygulamanızın ana menüsüne AI formlarını ekleyin:

### Ribbon Menü Örneği (DevExpress)

```vb
' Ana form veya ribbon bar'da
Private Sub btnAIAyarlari_Click(sender As Object, e As EventArgs)
    Dim frmAI As New frm_AIAyarlari()
    frmAI.ShowDialog()
End Sub

Private Sub btnAIUrunIsle_Click(sender As Object, e As EventArgs)
    Dim frmUrun As New frm_AIUrunIsle()
    frmUrun.Show()
End Sub
```

---

## 🐛 SORUN GİDERME

### "API key bulunamadı" Hatası
- tbParamGenel tablosunda `sEmergentKey` alanı dolu mu kontrol edin
- AI Ayarları formundan key'i tekrar kaydedin

### "Yetersiz kredi" Hatası
- tbMusteriKredi tablosunu kontrol edin
- Manuel kredi ekleyin:
  ```vb
  Dim creditService As New CreditService()
  creditService.AddCredit(musteriID:=1, amount:=100, paketID:=1, aciklama:="Test kredisi")
  ```

### "AI içerik oluşturulamadı" Hatası
- Log dosyasını kontrol edin: `AI_Service.log`
- OpenAI API key'in geçerli olduğundan emin olun
- Internet bağlantısını kontrol edin

### GPT-5 Modeli Bulunamadı
- OpenAI hesabınızın GPT-5'e erişimi var mı kontrol edin
- Alternatif: `AIService.vb` dosyasında model adını `"gpt-4"` olarak değiştirin (satır 215)

---

## 📊 İZLEME ve ANALİZ

### Kullanım İstatistikleri

```sql
-- Toplam işlenen ürün sayısı
SELECT COUNT(*) FROM tbStokAIIcerik

-- Toplam harcanan kredi
SELECT SUM(nMiktar) FROM tbKrediHareketleri WHERE sHareketTipi = 'Kullanim'

-- Müşteri bazında kullanım
SELECT nMusteriID, COUNT(*) as ToplamUrun, SUM(nMiktar) as ToplamKredi
FROM tbKrediHareketleri
WHERE sHareketTipi = 'Kullanim'
GROUP BY nMusteriID
```

---

## 🔐 GÜVENLİK ÖNERİLERİ

1. **API Key'leri şifreleyerek saklayın** (production için)
2. **Rate limiting** uygulayın (şu an 1 saniye/istek)
3. **Günlük limit** aktif tutun (kötüye kullanımı önler)
4. **Log dosyalarını** düzenli kontrol edin
5. **SSL/TLS** kullanın (API çağrıları için)

---

## 📞 DESTEK

Sorun yaşarsanız:
1. Log dosyalarını kontrol edin (`AI_Service.log`, `Credit_Service.log`)
2. Database script'inin tamamen çalıştığından emin olun
3. API key'lerin geçerli olduğunu doğrulayın

---

## ✅ SON KONTROL LİSTESİ

- [ ] Database script çalıştırıldı mı?
- [ ] Visual Studio'da proje derlendi mi?
- [ ] OpenAI API key alındı mı?
- [ ] AI Ayarları formunda key kaydedildi mi?
- [ ] Test ürünü ile deneme yapıldı mı?
- [ ] Ana menüye butonlar eklendi mi?
- [ ] Kredi paketleri tanımlandı mı?

---

**🎉 Tebrikler! AI sisteminiz kullanıma hazır.**

**Seçilen Servis:** OpenAI GPT-5  
**API Key Nereden Alınır:** https://platform.openai.com/api-keys  
**Tahmini Maliyet:** 0.01-0.02 USD/ürün (~0.30-0.60 TL)  
**Satış Fiyatı:** 1.4 TL/ürün  
**Kar Marjı:** ~%100-150
