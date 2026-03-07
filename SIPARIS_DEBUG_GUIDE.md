# 🔍 Sipariş Kaydetme Debug Rehberi

## 📋 Genel Bakış

Bu döküman, `frm_qukaGonder.vb` dosyasında bulunan sipariş çekme ve kaydetme işlemlerinin hata ayıklama rehberidir.

---

## 🎯 Problem

**Sipariş çekiliyor ancak `tbStokFisiMaster` ve `tbStokFisiDetayi` tablolarına kayıt yapılmıyor.**

---

## 🛠️ Eklenen Kapsamlı Log Sistemi

### 1. **Log Seviyeleri**

| Seviye | Emoji | Açıklama | Dosya |
|--------|-------|----------|-------|
| **ERROR** | ❌ | Kritik hatalar | `error_YYYY-MM-DD.log` |
| **WARNING** | ⚠️ | Uyarılar | `warning_YYYY-MM-DD.log` |
| **SUCCESS** | ✅ | Başarılı işlemler | `success_YYYY-MM-DD.log` |
| **INFO** | ℹ️ | Bilgi mesajları | `sync_YYYY-MM-DD.log` |
| **DEBUG** | 🔍 | Detaylı debug bilgisi | `sync_YYYY-MM-DD.log` |

### 2. **Log Dosyaları Konumu**

```
C:\Eticaret\log\
├── sync_2025-01-15.log          (Genel log)
├── error_2025-01-15.log         (Hata log)
├── warning_2025-01-15.log       (Uyarı log)
└── success_2025-01-15.log       (Başarı log)
```

**Fallback Lokasyon (C: yazmaya izin yoksa):**
```
Desktop\eticaret_log_fallback.log
Desktop\eticaret_error_fallback.log
```

### 3. **AddOrder Fonksiyonu - Detaylı Loglar**

#### ✅ İşlem Başlangıcı
```
========== SİPARİŞ KAYDETME İŞLEMİ BAŞLIYOR ==========
OrderID: ty(12345)
FirmaID: 11111111111, TC: 11111111111, VergiNo: 0
Müşteri: Ali Yılmaz
Adres: Atatürk mahallesi No: 5
Şehir: Istanbul, İlçe: Kadıköy, PostaKodu: 34000
Telefon: 05551234567, Email: ali@example.com
ÜRÜN 1: Barkod=1234567890123, Fiyat=100.50, Miktar=2
ÜRÜN 2: Barkod=0, Fiyat=0, Miktar=0
...
Ek Maliyet: 15.75
sAciklama2: Ali Yılmaz
sAciklama3: ty(12345)
Toplam Parametre Sayısı: 31
```

#### ✅ Stored Procedure Çalıştırma
```
🔄 Stored Procedure çalıştırılıyor: dbo.Satis_Kaydet
SQL Command: EXEC dbo.Satis_Kaydet ?, ?, ?, ...
Bağlantı Durumu: Open
✅ Stored Procedure tamamlandı. Etkilenen satır sayısı: 1
```

#### ✅ Tablo Doğrulama
```
✅ tbStokFisiMaster'a kayıt eklendi: 1 adet
✅ tbStokFisiDetayi'ye kayıt eklendi: 2 adet
📊 Tablo Kontrol Sonucu: Master=1, Detay=2
✅ Sipariş başarıyla kaydedildi: orderID=ty(12345)
```

#### ❌ Hata Durumları

**Durum 1: Stored Procedure Hiçbir Şey Kaydetmedi**
```
❌ HATA: Stored procedure hiçbir şey kaydetmedi! OrderID: ty(12345)
Muhtemel Sebepler:
1. Barkod(lar) veritabanında bulunamıyor olabilir
2. Stored procedure'de hata oluşmuş olabilir
3. Firma bilgileri eksik/hatalı olabilir
4. Stok/Fiyat bilgileri geçersiz olabilir

❌ BARKOD BULUNAMADI: 1234567890123 (Ürün 1)
✅ Barkod mevcut: 9876543210987 (Ürün 2)
```

**Durum 2: SQL Hatası**
```
========== STORED PROCEDURE HATASI ==========
OrderID: ty(12345)
Hata Mesajı: Violation of PRIMARY KEY constraint...
Hata Tipi: OleDbException
Stack Trace: at System.Data.OleDb...
SQL Error Count: 1
SQL Error: Cannot insert duplicate key... (Code: 2627)
```

---

## 🔎 Debug Adımları

### 1. **Log Dosyalarını İncele**

```batch
# Hata loglarını görüntüle
notepad C:\Eticaret\log\error_2025-01-15.log

# Son 50 satırı görüntüle (PowerShell)
Get-Content C:\Eticaret\log\sync_2025-01-15.log -Tail 50
```

### 2. **Barkod Kontrolü**

Log dosyasında şu satırları ara:
```
❌ BARKOD BULUNAMADI: [barkod]
```

**Çözüm:** İlgili barkodu `tbStok` tablosuna ekle:
```sql
INSERT INTO tbStok (sBarkod, sModel, sRenk, ...) 
VALUES ('1234567890123', 'MODEL123', 'Siyah', ...)
```

### 3. **Stored Procedure Hata Kontrolü**

SQL Server Management Studio'da manuel test:
```sql
EXEC dbo.Satis_Kaydet 
    @FirmaID = '11111111111',
    @sVergiNo = '0',
    @Adi = 'Ali',
    @Soyadi = 'Yılmaz',
    @Adres = 'Test Adres',
    ... -- diğer parametreler
```

### 4. **Tablo Doğrulama**

```sql
-- Master tablosunu kontrol et
SELECT TOP 10 * FROM tbStokFisiMaster 
WHERE sAciklama3 LIKE '%ty(%' 
ORDER BY nIslemID DESC

-- Detay tablosunu kontrol et
SELECT d.*, m.sAciklama2, m.sAciklama3 
FROM tbStokFisiDetayi d
INNER JOIN tbStokFisiMaster m ON d.nIslemID = m.nIslemID
WHERE m.sAciklama3 LIKE '%ty(%'
ORDER BY d.nIslemID DESC, d.nSira ASC
```

### 5. **Parametre Eksikliği Kontrolü**

Log dosyasında:
```
Toplam Parametre Sayısı: 31
```

Eğer 31 değilse, parametre eksikliği var demektir.

---

## 🐛 Yaygın Hatalar ve Çözümleri

### ❌ Hata 1: "Barkod bulunamadı"

**Sebep:** Siparişte gelen barkod `tbStok` tablosunda yok.

**Çözüm:**
1. Barkodu sisteme ekle
2. Veya API'den gelen barkodu düzelt
3. Log dosyasında hangi barkodun bulunamadığını görebilirsiniz

### ❌ Hata 2: "Stored procedure hiçbir şey kaydetmedi"

**Sebep:** SP içinde bir validation başarısız oldu.

**Çözüm:**
1. SP kodunu kontrol et (`Satis_Kaydet` stored procedure)
2. SP içindeki PRINT ve RAISERROR mesajlarını logla
3. Manuel test yap

### ❌ Hata 3: "Primary Key violation"

**Sebep:** Aynı sipariş daha önce kaydedilmiş.

**Çözüm:**
```sql
-- Sipariş log kontrolü
SELECT * FROM orders WHERE ID = 'ty(12345)'

-- Eski kaydı sil (DİKKATLİ!)
DELETE FROM orders WHERE ID = 'ty(12345)'
```

### ❌ Hata 4: "Connection timeout"

**Sebep:** Veritabanı bağlantısı kesildi.

**Çözüm:**
```vb.net
' Connection timeout'u artır
cmd.CommandTimeout = 300 ' 5 dakika
```

---

## 📊 Performans İzleme

### Log Dosyası Boyutu

Sistem otomatik olarak 100MB'ı aşan log dosyalarını arşivler:
```
sync_archive_2025-01-15_143025.log
```

### Memory Kullanımı

Log sistemi thread-safe ve memory-efficient tasarlandı:
- SyncLock kullanımı
- Dosya akışları düzgün kapatılıyor
- Fallback mekanizması var

---

## 🔧 Gelişmiş Debug

### 1. **SQL Profiler Kullanımı**

SQL Server Profiler'da şunu izle:
- SP çağrıları
- Parametre değerleri
- Execution time
- Error messages

### 2. **Breakpoint Koyma**

Visual Studio'da:
```vb.net
' AddOrder fonksiyonunda
Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
' ↑ Buraya breakpoint koy
```

### 3. **Test Senaryosu**

```vb.net
' Test siparişi oluştur
Dim testOrder As New Dictionary(Of String, Object)
testOrder("order") = New Dictionary(Of String, Object) From {
    {"id", "TEST123"}
}
testOrder("customer") = New Dictionary(Of String, Object) From {
    {"name", "Test User"},
    {"phone", "5551234567"}
}
testOrder("products") = New List(Of Dictionary(Of String, Object)) From {
    New Dictionary(Of String, Object) From {
        {"barcode", "1234567890123"},
        {"price", 100},
        {"amount", 1}
    }
}

AddOrder(testOrder)
```

---

## 📞 Destek

### Log Dosyaları Paylaşma

Hata durumunda şu dosyaları paylaş:
1. `error_YYYY-MM-DD.log` (Tam gün)
2. `sync_YYYY-MM-DD.log` (Son 500 satır)
3. Hatalı siparişin orderID'si

### İletişim

- **GitHub Issue:** Repo'da issue aç
- **Email:** support@example.com

---

## 📝 Notlar

- ✅ Log sistemi UTF-8 encoding kullanır (Türkçe karakter sorunu yok)
- ✅ Thread-safe tasarım (Çoklu sipariş aynı anda gelebilir)
- ✅ Fallback mekanizması (C: drive yazılamazsa Desktop'a yazar)
- ✅ Otomatik arşivleme (100MB üzeri dosyalar)
- ✅ UI'ya da log yazılır (Kullanıcı görebilir)

---

## 🎓 Öğrenme Kaynakları

### VB.NET OleDb
- [Microsoft Docs - OleDb](https://docs.microsoft.com/en-us/dotnet/api/system.data.oledb)

### Stored Procedure Debug
- [SQL Server Profiler](https://docs.microsoft.com/en-us/sql/tools/sql-server-profiler)

### Log4Net Alternative
İleri seviye için Log4Net kütüphanesine geçilebilir.

---

**Son Güncelleme:** 2025-01-15  
**Versiyon:** 2.0 - Kapsamlı Debug Sistemi
