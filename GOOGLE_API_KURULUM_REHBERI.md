# 🔑 Google Custom Search API Kurulum Rehberi

Bu rehber, AI Görsel Bulma özelliği için gerekli Google API anahtarlarını nasıl alacağınızı adım adım açıklamaktadır.

---

## 📋 Gereksinimler
- Google hesabı
- İnternet bağlantısı
- 5-10 dakika zaman

---

## 🚀 Adım Adım Kurulum

### 1️⃣ Google Cloud Console'a Giriş
1. Tarayıcınızdan şu adrese gidin: https://console.cloud.google.com/
2. Google hesabınızla giriş yapın

### 2️⃣ Yeni Proje Oluşturun
1. Sayfanın üst kısmında **proje seçimi** bölümüne tıklayın
2. **"Yeni Proje"** seçeneğine tıklayın
3. Proje adı girin (örn: "BarkodMagazaAI")
4. **"Oluştur"** butonuna tıklayın
5. Projenin oluşturulmasını bekleyin (1-2 dakika)

### 3️⃣ Custom Search API'yi Etkinleştirin
1. Sol menüden **"API'ler ve Hizmetler"** > **"Kütüphane"** seçeneğine gidin
2. Arama kutusuna **"Custom Search API"** yazın
3. **"Custom Search API"** sonucuna tıklayın
4. **"Etkinleştir"** butonuna tıklayın

### 4️⃣ API Anahtarı Oluşturun
1. Sol menüden **"API'ler ve Hizmetler"** > **"Kimlik Bilgileri"** seçeneğine gidin
2. Üstteki **"Kimlik Bilgileri Oluştur"** butonuna tıklayın
3. **"API Anahtarı"** seçeneğini seçin
4. Oluşturulan anahtarı **kopyalayın** ve güvenli bir yere kaydedin
   - Bu anahtar şuna benzer: `AIzaSyA1B2C3D4E5F6G7H8I9J0K1L2M3N4O5P6Q`

### 5️⃣ Programlanabilir Arama Motoru Oluşturun
1. Yeni bir sekmede şu adrese gidin: https://programmablesearchengine.google.com/
2. **"Başlarken"** veya **"Yeni arama motoru"** butonuna tıklayın
3. Arama motoru ayarlarını yapın:
   - **Aranacak siteler**: "Tüm web'i ara" seçeneğini işaretleyin
   - **Arama motoru adı**: "Ürün Görselleri" gibi bir isim verin
4. **"Oluştur"** butonuna tıklayın

### 6️⃣ Arama Motoru Kimliğini (CX) Alın
1. Oluşturduğunuz arama motorunun **"Genel Bakış"** sayfasına gidin
2. **"Arama motoru kimliği"** (Search engine ID / cx) alanını bulun
3. Bu kimliği **kopyalayın** ve kaydedin
   - Bu kimlik şuna benzer: `a1b2c3d4e5f6g7h8i`

---

## ✅ Anahtarları Uygulamaya Ekleyin

1. Barkod Mağaza uygulamasını açın
2. **Sistem** menüsünden **"AI Sistemi"** butonuna tıklayın
3. **"AI Ayarları"** seçeneğini seçin
4. API Anahtarları bölümüne:
   - **Google Search API Key**: 4. adımda aldığınız anahtarı yapıştırın
   - **Google Engine ID**: 6. adımda aldığınız kimliği yapıştırın
5. **"Ayarları Kaydet"** butonuna tıklayın
6. **"Test Et"** butonu ile bağlantıyı test edin

---

## 💰 Ücretlendirme

### Ücretsiz Kota
- **Günde 100 arama sorgusu** ücretsizdir
- Çoğu küçük/orta işletme için yeterlidir

### Ücretli Kullanım
- 100'den fazla sorgu için: **1000 sorgu = $5**
- Detaylar için: https://developers.google.com/custom-search/v1/overview

---

## 🔒 Güvenlik İpuçları

1. ✅ API anahtarınızı **asla** başkalarıyla paylaşmayın
2. ✅ API anahtarına **IP kısıtlaması** ekleyin (önerilir):
   - Google Cloud Console > Kimlik Bilgileri > API Anahtarı > Düzenle
   - "Uygulama kısıtlamaları" > "IP adresleri"
   - Şirket IP adresinizi ekleyin
3. ✅ Kullanımınızı **düzenli kontrol edin**:
   - Cloud Console > API'ler ve Hizmetler > Pano

---

## ❓ Sık Sorulan Sorular

### Neden Google API'ye ihtiyacım var?
AI sistemi, ürünleriniz için otomatik olarak görsel bulabilir. Bu, Google Images'da arama yaparak yüksek kaliteli ürün görselleri bulur ve veritabanınıza ekler.

### API anahtarı olmadan çalışır mı?
Evet! API anahtarı olmadan:
- ✅ AI açıklama oluşturma çalışır
- ✅ AI başlık oluşturma çalışır
- ✅ AI talimat oluşturma çalışır
- ❌ AI görsel bulma çalışmaz

### Anahtarım çalışmıyor!
1. API'nin etkinleştirildiğinden emin olun
2. Faturalama hesabının bağlı olduğunu kontrol edin (kredi kartı gerekli, ama ücretsiz kotada ücret kesilmez)
3. Anahtarı doğru kopyaladığınızdan emin olun (boşluk olmamalı)

---

## 📞 Destek

Sorun yaşıyorsanız:
1. Bu rehberi tekrar okuyun
2. Google Cloud Console'da faturalama hesabını kontrol edin
3. API kotanızı kontrol edin

---

**Son Güncelleme:** 2025
**Versiyon:** 1.0
