# SQL Kurulum Rehberi - Barkod Mağaza

Bu klasör, **Barkod Mağaza** uygulaması için gerekli tüm SQL scriptlerini içerir.

---

## 📋 Script Listesi

| # | Dosya | Açıklama | Zorunlu |
|---|-------|----------|---------|
| 01 | `01_MASTER_KURULUM.sql` | Tüm tablo, kolon ve index'ler | ✅ EVET |
| 02 | `02_STORED_PROCEDURES.sql` | Audit Log ve diğer procedure'ler | ✅ EVET |
| 03 | `03_TRIGGER_SISTEMI.sql` | Web senkronizasyon trigger'ları | İsteğe Bağlı |
| 04 | `04_VARSAYILAN_VERILER.sql` | E-ticaret parametreleri, sistem ayarları | ✅ EVET |
| 05 | `05_TEST_KONTROL.sql` | Kurulum doğrulama (Read-Only) | Test |

---

## 🚀 Hızlı Kurulum (Yeni Veritabanı)

```
1. 01_MASTER_KURULUM.sql
2. 02_STORED_PROCEDURES.sql
3. 04_VARSAYILAN_VERILER.sql
4. 05_TEST_KONTROL.sql (Opsiyonel - kontrol için)
```

---

## 🔄 Mevcut Veritabanı Güncelleme

```
1. 01_MASTER_KURULUM.sql (Eksik tablo/kolon ekler)
2. 02_STORED_PROCEDURES.sql
3. 04_VARSAYILAN_VERILER.sql (Eksik verileri ekler)
4. 05_TEST_KONTROL.sql (Kontrol için)
```

---

## ⚠️ Önemli Notlar

1. **VERİTABANI YEDEĞİ ALIN!**
   - Her script çalıştırmadan önce veritabanı yedeği alın

2. **VERİTABANI ADINI DEĞİŞTİRİN!**
   - Her script'in başında: `USE [VERITABANI_ADINIZ]`
   - Kendi veritabanı adınızla değiştirin

3. **SIRAYI TAKİP EDİN!**
   - Scriptler birbirine bağımlı
   - 01 → 02 → 03 → 04 → 05 sırasıyla çalıştırın

4. **PARAMETRELERİ GÜNCELLEYİN!**
   - `DefaultImageUrl`: Kendi resim URL'niz
   - E-ticaret komisyon oranları: Kendi anlaşmalarınız

---

## 📁 Eski Scriptler

`_ARSIV_ESKI/` klasöründe önceki scriptler saklanmaktadır.
Bu dosyalar artık kullanılmamaktadır - sadece referans için tutulmaktadır.

---

## 📞 Sorun Giderme

### Script hata veriyor
- Veritabanı adını kontrol edin
- Yetkinizi kontrol edin
- SQL Server Management Studio'da çalıştırın

### Tablo zaten var hatası
- Scriptler idempotent'tir (IF NOT EXISTS kullanır)
- Tekrar çalıştırılabilir

---

**Son Güncelleme:** Ocak 2025
