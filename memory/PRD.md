# BARKOD MAGAZA - Product Requirements Document

## Original Problem Statement
Visual Basic .NET Windows Forms uygulaması için kategori yönetimi ve akıllı eşleştirme sisteminin geliştirilmesi.

## Core Requirements

### P0 - Critical (Tamamlandı)
1. **Smart Category Matching** - Akıllı kategori eşleştirme
   - String varyasyonları ve yazım hatalarını tanıma
   - ANNE KIZ / BABA OĞUL ürünleri için özel mantık (-S suffix)
   - Marka bazlı gruplama (RP, US gibi prefix'ler)
   - Yetişkin/Çocuk ayrımı

2. **Duplicate Category Prevention** - Tekrarlanan kategori filtreleme
   - Veritabanına kayıt sırasında filtreleme
   - Web platformuna gönderirken filtreleme

3. **Compilation Fixes** - Derleme hataları düzeltildi
   - BC30456, BC30201, BC30451 gibi hatalar çözüldü

### P1 - High (Kısmen Tamamlandı)
1. **Find Category Inconsistencies** - ✅ Eklendi, test bekliyor
   - "🔍 Yanlış Kategorileri Bul" butonu
   - Aynı grup içindeki tutarsız kategorileri tespit

2. **Configurable Fixed Category** - ✅ Eklendi, test bekliyor
   - "Sabit Ana Kategori Ekle" checkbox'ı
   - Excel import sırasında opsiyonel

3. **UI Layout Fix** - ✅ Tamamlandı (14 Şubat 2025)
   - btnSiniflariSil ve btnKategoriKontrol butonları alt alta konumlandırıldı
   - Form taşması sorunu çözüldü

4. **Cleared Classes Display Issue** - ⏳ Bekliyor
   - frm_stok_liste_fiyat.vb'de INNER JOIN → LEFT JOIN düzeltmesi gerekli

### P2 - Medium (Bekliyor)
1. **Barcode Data Mix-up** - Barkod/beden karışıklığı
   - frm_qukagonder.vb dosyasında sorun
   - Ek bilgi bekleniyor

## Technical Architecture
- **Language:** Visual Basic .NET
- **UI Framework:** Windows Forms + DevExpress
- **Database:** SQL Server
- **Version Control:** Git/GitHub

## Key Files
- `/app/AkilliKategoriSecici.vb` - Akıllı eşleştirme mantığı
- `/app/frm_TrendyolKategoriEslestir.vb` - Ana kategori eşleştirme formu
- `/app/frm_UrunTipiKategoriSec.vb` - Ürün tipi seçim formu
- `/app/TrendyolExcelMatcher.vb` - Excel eşleştirme
- `/app/frm_qukaGonder.vb` - Web gönderim
- `/app/frm_stok_liste_fiyat.vb` - Stok listesi (LEFT JOIN düzeltmesi bekliyor)

## Completed Work

### 10 Aralık 2025
- [x] **Trigger Sayfa Ayarları Düzeltmesi** - `frm_qukaGonder.vb`
  - `chkTriggerAktif`, `chkTriggerStok`, `chkTriggerFiyat`, `chkTriggerResim`, `chkTriggerKategori` checkbox ayarları artık veritabanına kaydediliyor
  - `SenkronAyarlariniYukle()` ve `SenkronAyarlariniKaydet()` fonksiyonlarına trigger ayarları eklendi
  - Form kapanıp açıldığında ayarlar korunacak

### Önceki Çalışmalar
- [x] Smart Category Matching mantığı güncellendi (daha granüler gruplama)
- [x] Kategori değişiklikleri için SQL trigger eklendi (`trg_StokSinifi_WebSync`)
- [x] Resim sync trigger'ı düzeltildi ve `UpdateProductImages` fonksiyonu eklendi
- [x] "Kategorileri Güncelle" ve "Resimleri Güncelle" butonları eklendi
- [x] UI düzeni ve "Tümünü Seç" butonu sorunları giderildi
- [x] Buton düzeni düzeltmesi (btnSiniflariSil, btnKategoriKontrol)
- [x] GitHub push başarılı

## Next Steps
1. **Kullanıcı testi:** Trigger sayfası ayarlarının kaydedildiğini doğrulamalı
2. **P1:** Temizlenen sınıflar UI sorunu - `frm_stok_liste_fiyat.vb`'de `LEFT JOIN` düzeltmesi
3. **P2:** Barkod/beden verisi karışıklığı sorununu araştır
