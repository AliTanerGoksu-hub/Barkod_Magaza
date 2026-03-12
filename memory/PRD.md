# PRD - Business Smart Barkod Magaza

## Original Problem Statement
VB.NET Windows Forms tabanlı e-ticaret ve perakende yönetim uygulaması. Ana özellikler:
- Quka API üzerinden sipariş senkronizasyonu
- Pazaryeri entegrasyonları (Trendyol, Hepsiburada)
- GİB e-Fatura/e-Arşiv entegrasyonu (Kolaysoft)
- Stok ve fiyat yönetimi
- POS satış işlemleri
- AI tabanlı ürün içerik oluşturma

## Implemented Features (2025-03)

### Bug Fixes (Completed)
1. **POS Ödeme Donma Hatası** - `frm_perakende_odeme.vb`
   - Ödeme isteği bekleme sırasını düzeltildi

2. **Gece Yarısı lic.dat Dosya Kilidi Çökmesi** - `Form1.vb`
   - Try...Finally bloğu ile dosya kapatma garantilendi

3. **Toplu Resim Yükleme Duplikasyon Hatası** - `frm_TopluResimYukleme.vb`, `frm_stok_kart.vb`
   - Model+Renk bazlı kontrol (Size bazlı yerine)

4. **Excel Import Hataları** - `frm_fatura.vb`
   - Varyant veri kalıcılığı ve COM exception düzeltmeleri

5. **✅ Quka API Müşteri Bilgisi Kaydedilmiyor (2025-03-10)** - `frm_qukaGonder.vb`
   - **Kök Neden:** GetIlName fonksiyonu sadece plaka kodu ile arama yapıyordu
   - **Çözüm:** 
     - GetIlName: Plaka + İl adı + Türkçe karakter toleranslı arama
     - GetVarsayilanIl: Veritabanından gerçek varsayılan il değeri
     - NormalizeTurkishChars: Türkçe karakter dönüşümü
   - **Dosya:** frm_qukaGonder.vb (satır 81-172, 3270-3300, 9925-9945)

6. **✅ POS JSON Veri Duplikasyonu (2025-03)** - `frm_Perakende_Satis.vb`, `frm_Perakende_Satis_Pesin.vb`
   - Bireysel müşteri adı `currentTitle` alanında tekrarlanıyordu - düzeltildi

7. **✅ AI Kategori/Marka Eşleme Hatası (2025-03)** - `frm_AIUrunIsle.vb`
   - Yanlış varsayılan değerler düzeltildi

8. **✅ FTP Başlangıç Hatası (2025-03)** - `Form1.vb`
   - "530 Not logged in" hatası bastırıldı

### Completed Features (2025-03)
1. **✅ Trendyol Fatura Entegrasyonu** - `frm_PazaryeriFaturaGonderim.vb`
   - shipmentPackageId dinamik olarak alınıyor
   - Fatura linki doğru endpoint'e gönderiliyor

2. **✅ Pazaryeri Fatura Gönderim UI** - `frm_PazaryeriFaturaGonderim.vb`
   - "Gönderilenleri de Göster" checkbox
   - Renk kodlaması ile gönderilmiş faturaları gösterme

3. **✅ Toplu Tarih Değiştir** - `frm_fatura_liste.vb`
   - Context menü ile toplu tarih değişikliği

4. **✅ GİB Ön Gönderim Kontrolü** - `frm_fatura_liste.vb`
   - Pazaryerine göndermeden önce GİB'e gönderim kontrolü

5. **✅ AI Formu 5 Kategori Desteği (2025-12)** - `frm_AIUrunIsle.vb`
   - Kategori yolu artık 5 seviye kullanıyor: Kat1 > Kat2 > Kat3 > Kat4 > Kat5
   - `GetModelsWithoutAI` fonksiyonu 5 kategori okuyor
   - Tüm SQL sorguları güncellendi

9. **✅ Otomatik Güncelleme "Access is denied" Hatası Düzeltildi (2025-12)** - `Form1.vb`
   - **Kök Neden:** OtoGuncelleme fonksiyonu dosyaları `%TEMP%\BusinessSmartUpdate` klasörüne indirirken, Form1_Closing fonksiyonu dosyaları `C:\Program Files\...\Util\` klasöründen okumaya çalışıyordu
   - **Çözüm:** 
     - Form1_Closing fonksiyonu artık TEMP klasöründen dosyaları okuyacak şekilde güncellendi
     - Tüm exe'ler için (business_smart, MANAGE, LICENSE, POS) tutarlı TEMP klasör kullanımı
   - **Sonuç:** Program artık admin hakları olmadan da güncellenebilir

### In Progress / Blocked Features
1. **🔴 Hepsiburada Fatura Entegrasyonu (BLOKE)** - `frm_PazaryeriFaturaGonderim.vb`
   - HTTP 403 Forbidden hatası
   - Hepsiburada/Quka ile iletişim gerekli (IP whitelist veya entegratör izinleri)

## Key Database Schema
- `tbStokFisiMaster`: Fatura header (nFisNo, GibFaturaNo, nFirmaID)
- `tbStokFisiAciklamasi`: Sipariş kodu (sAciklama3)
- `tbPazaryeriAyar`: API credentials (sSaticiID, sApiKey, sApiSecret)
- `tbPazaryeriFaturaGonderim`: Fatura gönderim log
- `tbFirma`: Müşteri bilgileri (sIl FK -> tbIl.sIl)
- `tbIl`: İl tablosu (sPlaka, sIl)
- `tbSistemAyar`: Sistem ayarları (ETICARET_SINIF_MARKA, ETICARET_SINIF_KAT1-5)
- `tbStok`: Stok kartları (sSinifKodu3-8 parametrik sınıf kodları)
- `tbSSinif3-8`: Parametrik sınıf tanımları
- `tbStokAIIcerik`: AI oluşturulan içerikler

## Architecture
- VB.NET Windows Forms
- SQL Server (FURKAN2026)
- OleDb bağlantı
- DevExpress UI
- External APIs: Quka, Kolaysoft, Trendyol, Hepsiburada, OpenAI (AI içerik)

## Files of Reference
- `/app/Barkod_Magaza_Git/frm_qukaGonder.vb` - Sipariş senkronizasyonu
- `/app/Barkod_Magaza_Git/frm_PazaryeriFaturaGonderim.vb` - Pazaryeri fatura gönderim
- `/app/Barkod_Magaza_Git/frm_fatura_liste.vb` - Fatura listesi
- `/app/Barkod_Magaza_Git/Form1.vb` - Ana form
- `/app/Barkod_Magaza_Git/frm_AIUrunIsle.vb` - AI ürün işleme (5 kategori desteği)
- `/app/Barkod_Magaza_Git/frm_SinifEsleme.vb` - Parametrik sınıf eşleştirme

## Known Issues
- **Hepsiburada API 403 Forbidden**: IP whitelist veya entegratör izin sorunu. Kullanıcı Hepsiburada/Quka ile iletişime geçmeli.

## Backlog (P2)
1. POS Email alanı veritabanı veri kontrolü (muhtemelen veri girişi sorunu)
2. **VB.NET İstemcisini Yeni API'ye Taşıma** - `desktop.barkodyazilimevi.com` API'sine geçiş
   - FTP ve doğrudan SQL bağlantılarını API çağrılarıyla değiştirmek
   - Port 21 (FTP) ve Port 8991 (SQL) kapatılabilecek
