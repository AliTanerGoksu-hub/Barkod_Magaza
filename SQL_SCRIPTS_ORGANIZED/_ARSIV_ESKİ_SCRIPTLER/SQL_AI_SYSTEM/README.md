# 🗄️ AI Sistem SQL Sorguları

Bu klasör, AI sistemi için gerekli tüm veritabanı yapılandırma sorgularını içerir.

---

## 📋 Kurulum Sırası

Veritabanını sıfırdan kurmak için bu sırayı takip edin:

### 1️⃣ **INSTALL_DATABASE.sql** (Ana Kurulum)
- **Ne Yapar:** Tüm AI sistemi tablolarını oluşturur
- **tbParamGenel Kolonları Ekler:**
  - `bAIKullan` - AI aktif/pasif
  - `bBaslikOlustur`, `bAciklamaOlustur`, vb.
  - `sEmergentKey` - API anahtarı
  - `sGoogleSearchApiKey`, `sGoogleSearchEngineId`
- **Tablolar:**
  - `tbAIContent` - AI üretilen içerikler
  - `tbAIHistory` - AI işlem geçmişi
  - `tbCreditUsage` - Kredi kullanım takibi
- **Ne Zaman Kullanılır:** İlk kurulum

---

### 1️⃣.5 **INSERT_DEFAULT_PARAMS.sql** (⭐ ÖNEMLİ!)
- **Ne Yapar:** `tbParamGenel` tablosuna varsayılan değerleri ekler
- **Eklenecek Satır:** `nParamID = 1`
- **Ne Zaman Kullanılır:** 
  - INSTALL_DATABASE.sql'den HEMEN SONRA
  - "Ayarlar kaydedilemedi" hatası alıyorsanız
- **⚠️ UYARI:** Bu script çalıştırılmazsa AI Ayarları kaydedemez!

```sql
-- SQL Server Management Studio'da çalıştırın
USE [VeriTabanıAdınız]
GO
-- INSTALL_DATABASE.sql içeriğini çalıştırın
```

---

### 2️⃣ **DATABASE_CREATE_tbStokResim_V2.sql** (Resim Tablosu)
- **Ne Yapar:** Ürün resimleri tablosunu oluşturur
- **Tablo:** `tbStokResim`
- **Kolonlar:**
  - `nID` (Primary Key)
  - `nStokID` (Foreign Key)
  - `sKodu` (Ürün kodu)
  - `sResimYolu` (Resim dosya yolu)
  - `sRenk` (Renk bilgisi)
  - `bAnaResim` (Ana resim mi?)
- **Ne Zaman Kullanılır:** İlk kurulum veya tablo yoksa

---

### 3️⃣ **DATABASE_AI_CONTENT_STRUCTURE.sql** (AI İçerik Yapısı)
- **Ne Yapar:** AI içerik tablolarını detaylı yapılandırır
- **İçerik:**
  - İndeksler
  - Constraint'ler
  - Default değerler
- **Ne Zaman Kullanılır:** Ana kurulumdan sonra

---

## 🔧 Güncelleme/Düzeltme Sorguları

### **DATABASE_ALTER_tbStokResim_COMPLETE.sql**
- **Ne Yapar:** `tbStokResim` tablosuna eksik kolonları ekler
- **Eklenecek Kolonlar:**
  - `nStokID INT`
  - `sRenk NVARCHAR(50)`
  - `bAnaResim BIT`
- **Ne Zaman Kullanılır:** Tablo zaten varsa ama kolonlar eksikse

### **DATABASE_ALTER_tbStokResim_ADD_nStokID.sql**
- Sadece `nStokID` kolonunu ekler

### **DATABASE_ALTER_tbStokResim_ADD_sRenk.sql**
- Sadece `sRenk` kolonunu ekler

---

## 🛠️ Yardımcı Sorgular

### **FIX_VIEW_COLUMNS.sql**
- **Ne Yapar:** View'lerdeki kolon isimlerini düzeltir
- **Düzeltmeler:**
  - `sKod` → `sKodu`
  - `sAciklam` → `sAciklama`
- **Ne Zaman Kullanılır:** Encoding problemlerinden sonra

---

## 🚀 Hızlı Kurulum (Yeni Veritabanı)

```sql
-- 1. Veritabanını seçin
USE [BarkodMagaza]
GO

-- 2. nParamID kolonu ekle (ÖNCE BU!)
-- FIX_ADD_nParamID.sql çalıştırın

-- 3. Ana kurulum
-- INSTALL_DATABASE.sql çalıştırın

-- 4. Varsayılan parametreleri ekle (ÖNEMLİ!)
-- INSERT_DEFAULT_PARAMS.sql çalıştırın

-- 5. Resim tablosu
-- DATABASE_CREATE_tbStokResim_V2.sql çalıştırın

-- 6. AI yapılandırma
-- DATABASE_AI_CONTENT_STRUCTURE.sql çalıştırın

-- 7. Kontrol
SELECT * FROM tbParamGenel WHERE nParamID = 1
SELECT * FROM tbStokResim
```

---

## 🔄 Mevcut Veritabanına Ekleme

```sql
-- 1. nParamID kolonu var mı kontrol et
SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'tbParamGenel' AND COLUMN_NAME = 'nParamID'

-- Yoksa: FIX_ADD_nParamID.sql çalıştırın (ÖNEMLİ!)

-- 2. AI kolonları var mı kontrol et
SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'tbParamGenel' AND COLUMN_NAME LIKE '%AI%'

-- Yoksa: INSTALL_DATABASE.sql çalıştırın

-- 3. nParamID = 1 kaydı var mı kontrol et
SELECT * FROM tbParamGenel WHERE nParamID = 1

-- Yoksa: INSERT_DEFAULT_PARAMS.sql çalıştırın

-- 4. Resim tablosu kontrolü
SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'tbStokResim'

-- Eksik kolonlar varsa: DATABASE_ALTER_tbStokResim_COMPLETE.sql çalıştırın
```

---

## ⚠️ Dikkat Edilmesi Gerekenler

1. ✅ **Yedek Alın:**
   ```sql
   BACKUP DATABASE [VeriTabanı] TO DISK = 'C:\Backup\db.bak'
   ```

2. ✅ **Test Ortamında Deneyin:**
   - İlk önce test veritabanında çalıştırın
   - Sorun yoksa canlı ortamda uygulayın

3. ✅ **Sırayı Takip Edin:**
   - CREATE sorgularını önce
   - ALTER sorgularını sonra
   - INDEX sorgularını en son

4. ✅ **Hataları Kontrol Edin:**
   - Her sorgudan sonra hata mesajlarını inceleyin
   - Hata varsa düzeltin, sonraki sorguya geçmeyin

---

## 📊 Tablo İlişkileri

```
tbStok (Mevcut)
    │
    ├─── tbStokResim (Resimler)
    │       └─ nStokID → tbStok.nID
    │
    └─── tbAIContent (AI İçerikler)
            └─ nStokID → tbStok.nID

tbAIParameters (Ayarlar)
    │
    └─── Global AI Sistemi

tbAIHistory (Geçmiş)
    │
    └─── tbAIContent'e bağlı loglar

tbCreditUsage (Kredi)
    │
    └─── Kullanım takibi
```

---

## 🆘 Sorun Giderme

### Sorun: "Object already exists" hatası
**Çözüm:** Tablo zaten var. ALTER sorgularını kullanın.

### Sorun: "Invalid column name" hatası
**Çözüm:** 
```sql
-- Kolonları kontrol edin
sp_help 'tbStokResim'

-- Eksik kolonları ekleyin
-- DATABASE_ALTER_tbStokResim_COMPLETE.sql
```

### Sorun: "Foreign key constraint" hatası
**Çözüm:** Önce parent tablo (`tbStok`) var mı kontrol edin.

---

## 📞 Destek

Sorularınız için:
1. SQL Server Error Log'u kontrol edin
2. `sp_help 'TabloAdı'` ile tablo yapısını inceleyin
3. Transaction log'ları gözden geçirin

---

**Son Güncelleme:** 2025  
**Versiyon:** 1.0  
**Veritabanı:** SQL Server 2008+ uyumlu
