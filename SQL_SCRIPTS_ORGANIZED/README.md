# SQL Scripts - Kurulum Kılavuzu

Bu klasördeki SQL scriptleri **sırayla** çalıştırılmalıdır.

## 📋 Script Sırası

### 1️⃣ 01_KURULUM_TABLO_ve_KOLON_EKLEMELERI.sql
**Ne yapar:**
- tbStokAIIcerik tablosunu oluşturur (AI içerikler için)
- tbStokSinifi'ye sModel kolonu ekler
- tbParamGenel'e DefaultImageUrl kolonu ekler
- tbParamETicaret tablosunu oluşturur
- tbStokResim tablosunu oluşturur ve kolonları ekler
- tbStok'a AI kolonları ekler (bAIIcerikVar, dteAISonGuncelleme)
- Performans index'lerini oluşturur

**Ne zaman:**
- İlk kurulumda
- Yeni bir veritabanına geçişte

**Özellik:**
- İdempotent (birden fazla kez çalıştırılabilir)
- Mevcut kolonları kontrol eder, sadece eksik olanları ekler

---

### 2️⃣ 02_MIGRATION_MODEL_BAZLI.sql
**Ne yapar:**
- Mevcut verileri model bazlı yapıya dönüştürür
- nStokID bazlı kayıtları sModel bazlı yapar
- Mükerrer kayıtları temizler (model başına 1 kayıt)
- Yedek tablolar oluşturur (geri dönüş için)

**Ne zaman:**
- 01_KURULUM scriptinden sonra
- Mevcut verileri model bazlı yapmak için

**Uyarı:**
- Bu script veri migration yapar
- Mutlaka önce yedek alın!
- Yedek tablolar otomatik oluşturulur (tbStokSinifi_BACKUP, tbStokAIIcerik_BACKUP)

---

### 3️⃣ 03_PARAMETRE_GUNCELLEME.sql
**Ne yapar:**
- DefaultImageUrl parametresini ekler
- tbParamETicaret için örnek veriler ekler (Trendyol, Hepsiburada, N11, Amazon)
- Tüm parametreleri listeler ve kontrol eder

**Ne zaman:**
- Migration tamamlandıktan sonra
- İlk kurulumda

**Önemli:**
- DefaultImageUrl'i kendi resim URL'niz ile güncelleyin
- E-ticaret parametrelerini kendi anlaşmalarınıza göre düzenleyin

---

### 4️⃣ 04_TEST_PARAMETRE_OKUMA.sql
**Ne yapar:**
- Tüm parametreleri kontrol eder
- tbParamGenel parametrelerini gösterir
- tbParamETicaret parametrelerini gösterir
- Örnek maliyet hesaplaması yapar (100₺ için)
- Platform eşleşme kontrolü yapar
- Eksik platformları bildirir

**Ne zaman:**
- Parametreleri kontrol etmek için
- Sorun giderme için
- Her zaman çalıştırılabilir (read-only)

**Özellik:**
- Veri değiştirmez, sadece okur ve raporlar

---

### 5️⃣ 05_HIZLI_PARAMETRE_GUNCELLEME.sql
**Ne yapar:**
- DefaultImageUrl'i hızlıca günceller
- Kontrol eder ve sonucu gösterir

**Ne zaman:**
- Sadece DefaultImageUrl'i değiştirmek için
- Test amaçlı

---

## 🚀 Hızlı Başlangıç

### İlk Kurulum (Yeni Veritabanı)
```sql
-- 1. Tabloları ve kolonları oluştur
01_KURULUM_TABLO_ve_KOLON_EKLEMELERI.sql

-- 2. Parametreleri ekle
03_PARAMETRE_GUNCELLEME.sql

-- 3. DefaultImageUrl'i güncelle
05_HIZLI_PARAMETRE_GUNCELLEME.sql

-- 4. Kontrol et
04_TEST_PARAMETRE_OKUMA.sql
```

### Mevcut Veritabanı Güncelleme
```sql
-- 1. Tabloları ve kolonları ekle (varsa atlar)
01_KURULUM_TABLO_ve_KOLON_EKLEMELERI.sql

-- 2. Model bazlı yapıya geç (YEDEK ALIR!)
02_MIGRATION_MODEL_BAZLI.sql

-- 3. Parametreleri güncelle
03_PARAMETRE_GUNCELLEME.sql

-- 4. Kontrol et
04_TEST_PARAMETRE_OKUMA.sql
```

---

## ⚠️ Önemli Notlar

1. **Her zaman yedek alın!**
   - Migration script otomatik yedek alır ama yine de manuel yedek önerilir

2. **Veritabanı adını değiştirin!**
   - Her script'in başında `USE [Database]` satırını kendi veritabanınıza göre değiştirin

3. **Parametreleri güncelleyin!**
   - DefaultImageUrl: Kendi resim URL'niz
   - E-ticaret parametreleri: Kendi komisyon oranlarınız

4. **Sırayla çalıştırın!**
   - Scriptler birbirine bağımlı
   - Sırayı değiştirmeyin

5. **Kontrol edin!**
   - Her script'ten sonra 04_TEST script'i ile kontrol edin

---

## 🔄 Geri Dönüş

Eğer migration'da sorun olursa:

```sql
-- Yedekten geri dön
DROP TABLE tbStokSinifi;
SELECT * INTO tbStokSinifi FROM tbStokSinifi_BACKUP;

DROP TABLE tbStokAIIcerik;
SELECT * INTO tbStokAIIcerik FROM tbStokAIIcerik_BACKUP;
```

---

## 📞 Sorun Giderme

### Problem: Script hata veriyor
- Veritabanı adını kontrol edin
- Tablo/kolon zaten var mı kontrol edin
- Yetkiniz var mı kontrol edin

### Problem: Migration sonrası veri kayboldu
- Yedek tablolara bakın (tbStokSinifi_BACKUP)
- Geri dönüş komutlarını kullanın

### Problem: Parametreler güncellenmiyor
- WITH (NOLOCK) kullanıldığından emin olun
- Uygulamayı yeniden başlatın
- 04_TEST script'i ile kontrol edin

---

## ✅ Başarı Kontrol Listesi

- [ ] 01_KURULUM çalıştırıldı
- [ ] Tüm tablolar ve kolonlar oluştu
- [ ] 02_MIGRATION çalıştırıldı (varsa)
- [ ] Model bazlı yapı aktif
- [ ] 03_PARAMETRE çalıştırıldı
- [ ] DefaultImageUrl güncellendi
- [ ] E-ticaret parametreleri güncellendi
- [ ] 04_TEST ile kontrol edildi
- [ ] Uygulama yeniden derlendi
- [ ] Test edildi ve çalışıyor ✨
