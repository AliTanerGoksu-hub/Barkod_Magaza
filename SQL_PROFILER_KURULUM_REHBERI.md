# 🔍 SQL Server Profiler - Stored Procedure Görememe Sorunu ve Çözümü

## 📋 Problem

`frm_qukaGonder.vb` senkronizasyon çalışırken SQL Server Profiler'da `EXEC dbo.Satis_Kaydet` stored procedure çağrısını göremiyorsunuz.

---

## 🎯 Neden Göremiyorsunuz?

### 1. **OleDb Provider Kullanıyorsunuz**

VB.NET kodunuzda:
```vb
Dim cmd As New OleDb.OleDbCommand
cmd.CommandType = CommandType.StoredProcedure
cmd.CommandText = "dbo.Satis_Kaydet"
```

OleDb, stored procedure'leri **RPC (Remote Procedure Call)** olarak gönderir, **SQL Batch** olarak değil!

### 2. **Profiler'da Yanlış Event Seçilmiş**

Varsayılan olarak Profiler şunları gösterir:
- ✅ `SQL:BatchCompleted` - Normal SQL sorguları
- ❌ **`RPC:Completed` - STORED PROCEDURE ÇAĞRILARI** ← BU EKSİK!

---

## ✅ ÇÖZÜM: Profiler'ı Doğru Ayarlayın

### **Adım 1: SQL Server Profiler'ı Açın**

1. SQL Server Management Studio (SSMS) açın
2. **Tools** → **SQL Server Profiler** tıklayın
3. Yeni bir Trace başlatın

---

### **Adım 2: Template Seçin**

**File** → **New Trace** → **Standard (Default)** seçin

---

### **Adım 3: Events Selection - Doğru Event'leri Seçin**

#### ✅ **Mutlaka Seçilmesi Gerekenler:**

| Event Category | Event Name | Neden Gerekli |
|----------------|------------|---------------|
| **Stored Procedures** | `RPC:Completed` | OleDb SP çağrılarını gösterir |
| **Stored Procedures** | `RPC:Starting` | SP başladığında gösterir |
| **Stored Procedures** | `SP:StmtStarting` | SP içindeki satırları gösterir |
| **Stored Procedures** | `SP:StmtCompleted` | SP içindeki tamamlanan satırları gösterir |
| **TSQL** | `SQL:BatchCompleted` | Normal SQL sorguları |
| **TSQL** | `SQL:BatchStarting` | Sorgu başlangıcı |

#### ✅ **Events Selection Ekranında Yapılacaklar:**

1. **"Show all events"** checkbox'ını işaretleyin
2. **"Show all columns"** checkbox'ını işaretleyin
3. Yukarıdaki event'leri bulup işaretleyin

---

### **Adım 4: Column Filters - Önemli Kolonları Seçin**

#### ✅ **Column Seçimi:**

| Column Name | Açıklama |
|-------------|----------|
| **TextData** | SQL sorgusu/SP adı burada |
| **ApplicationName** | Hangi uygulama çalıştırdı |
| **LoginName** | Hangi kullanıcı |
| **DatabaseName** | Hangi veritabanı |
| **SPID** | Session ID |
| **Duration** | Çalışma süresi (microseconds) |
| **CPU** | CPU kullanımı |
| **Reads** | Disk okuma sayısı |
| **Writes** | Disk yazma sayısı |
| **RowCounts** | Etkilenen satır sayısı |
| **StartTime** | Başlangıç zamanı |
| **EndTime** | Bitiş zamanı |

---

### **Adım 5: Column Filters - Filtreleme (Opsiyonel)**

Sadece ilgili trafiği görmek için:

#### **DatabaseName Filtresi:**
```
DatabaseName = "BARKOD_MAGAZA"  (veya sizin database adınız)
```

#### **TextData Filtresi:**
```
TextData LIKE '%Satis_Kaydet%'
```

#### **ApplicationName Filtresi:**
Eğer biliyorsanız:
```
ApplicationName LIKE '%BARKOD%'
```

---

## 🔍 Profiler'da Ne Göreceksiniz?

### **OleDb ile SP Çağrısı Böyle Görünür:**

#### **RPC:Starting Event:**
```
TextData: { call dbo.Satis_Kaydet(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?) }
ApplicationName: .Net SqlClient Data Provider
LoginName: DOMAIN\Username
DatabaseName: BARKOD_MAGAZA
SPID: 52
```

#### **RPC:Completed Event:**
```
TextData: { call dbo.Satis_Kaydet(?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?) }
Duration: 1523000  (1.523 saniye)
CPU: 156
Reads: 234
Writes: 12
RowCounts: -1
```

**NOT:** `RowCounts = -1` normal bir durumdur stored procedure'ler için!

---

## 🧪 Test: Profiler Çalışıyor mu?

### **1. Basit Test:**

SQL Management Studio'da şu sorguyu çalıştırın:
```sql
EXEC dbo.Satis_Kaydet 
    @TC = '11111111111',
    @sVergiNo = '0',
    @Adi = 'Test',
    @Soyadi = 'User',
    @Adres = 'Test Adres',
    @Ulke = 'Türkiye',
    @Il = 'Istanbul',
    @Ilce = 'Kadıköy',
    @PostaKodu = '34000',
    @VergiDairesi = 'Test VD',
    @VergiNo = '0',
    @Telefon = '5551234567',
    @eMail = 'test@test.com',
    @Barkod = '8684053211310',
    @Fiyat = 100.00,
    @Miktar = 1,
    @Barkod1 = '0',
    @Fiyat1 = 0,
    @Miktar1 = 0,
    @Barkod2 = '0',
    @Fiyat2 = 0,
    @Miktar2 = 0,
    @Barkod3 = '0',
    @Fiyat3 = 0,
    @Miktar3 = 0,
    @Barkod4 = '0',
    @Fiyat4 = 0,
    @Miktar4 = 0,
    @EkMaliyet3 = 0,
    @sAciklama2 = 'Test User',
    @sAciklama3 = 'TEST123'
```

**Profiler'da göreceksiniz:**
- ✅ `RPC:Starting` - Başladı
- ✅ `SP:StmtStarting` (birkaç satır) - SP içindeki satırlar
- ✅ `RPC:Completed` - Tamamlandı

### **2. VB.NET Uygulamasından Test:**

1. Uygulamayı çalıştırın
2. Sipariş senkronizasyonu yapın
3. Profiler'da **TextData** kolonunda şunu arayın:
   ```
   Satis_Kaydet
   ```

---

## 📊 Profiler Trace Kaydetme

### **Trace'i Kaydedin (Sonra İncelemek İçin):**

1. **File** → **Save As** → **Trace File** seçin
2. Dosya adı: `BARKOD_SENKRON_TRACE_2025-11-25.trc`
3. Kaydedip sonra açabilirsiniz:
   - **File** → **Open** → **Trace File**

---

## 🔧 Alternatif: Extended Events (Modern Yöntem)

SQL Server 2012+ için **Extended Events** daha hafif ve modern:

### **Extended Event Session Oluşturma:**

```sql
-- Extended Event Session oluştur
CREATE EVENT SESSION [BARKOD_SP_Tracking] ON SERVER 
ADD EVENT sqlserver.rpc_completed(
    ACTION(sqlserver.client_app_name,sqlserver.database_name,sqlserver.sql_text,sqlserver.username)
    WHERE ([package0].[equal_boolean]([sqlserver].[is_system],(0)))
),
ADD EVENT sqlserver.rpc_starting(
    ACTION(sqlserver.client_app_name,sqlserver.database_name,sqlserver.sql_text,sqlserver.username)
    WHERE ([package0].[equal_boolean]([sqlserver].[is_system],(0)))
),
ADD EVENT sqlserver.sp_statement_completed(
    ACTION(sqlserver.client_app_name,sqlserver.database_name,sqlserver.sql_text)
    WHERE ([sqlserver].[database_name]=N'BARKOD_MAGAZA')
)
ADD TARGET package0.event_file(SET filename=N'C:\Temp\BARKOD_SP_Tracking.xel')
WITH (MAX_MEMORY=4096 KB,EVENT_RETENTION_MODE=ALLOW_SINGLE_EVENT_LOSS,MAX_DISPATCH_LATENCY=30 SECONDS,MAX_EVENT_SIZE=0 KB,MEMORY_PARTITION_MODE=NONE,TRACK_CAUSALITY=ON,STARTUP_STATE=OFF)
GO

-- Session'ı başlat
ALTER EVENT SESSION [BARKOD_SP_Tracking] ON SERVER STATE = START;
GO
```

### **Sonuçları Görüntüleme:**

```sql
-- Extended Event sonuçlarını oku
SELECT 
    event_data.value('(event/@name)[1]', 'varchar(50)') AS event_name,
    event_data.value('(event/@timestamp)[1]', 'datetime2') AS timestamp,
    event_data.value('(event/data[@name="statement"]/value)[1]', 'nvarchar(max)') AS statement,
    event_data.value('(event/action[@name="client_app_name"]/value)[1]', 'nvarchar(256)') AS app_name,
    event_data.value('(event/action[@name="database_name"]/value)[1]', 'nvarchar(256)') AS database_name
FROM 
(
    SELECT CAST(event_data AS xml) AS event_data
    FROM sys.fn_xe_file_target_read_file('C:\Temp\BARKOD_SP_Tracking*.xel', NULL, NULL, NULL)
) AS ed
ORDER BY timestamp DESC;
```

---

## 🎯 Yaygın Hatalar ve Çözümleri

### ❌ Hata 1: "Profiler hiçbir şey göstermiyor"

**Sebep:** Yanlış event seçilmiş.

**Çözüm:** 
- ✅ `RPC:Completed` event'ini ekleyin
- ✅ Filtreleri kaldırın (özellikle Duration > 0 filtresi)

---

### ❌ Hata 2: "Parametre değerleri görünmüyor"

**Sebep:** OleDb parametreleri `?` olarak gösterir.

**Çözüm:** 
- ✅ VB.NET loglarına bakın (yeni eklediğimiz parametre logları)
- ✅ SP içinde `PRINT` statement'ları ekleyin:
  ```sql
  PRINT 'TC: ' + @TC
  PRINT 'Adi: ' + @Adi
  ```

---

### ❌ Hata 3: "ApplicationName boş görünüyor"

**Sebep:** OleDb connection string'de belirtilmemiş.

**Çözüm:** Connection string'e ekleyin:
```vb
"Provider=SQLOLEDB;Data Source=SERVER;Initial Catalog=BARKOD_MAGAZA;Application Name=BARKOD_SENKRON;"
```

---

## 📝 Özet Checklist

Profiler'da Stored Procedure görmek için:

- [ ] **RPC:Completed** event'i seçildi
- [ ] **RPC:Starting** event'i seçildi
- [ ] **TextData** kolonu seçildi
- [ ] **ApplicationName** kolonu seçildi
- [ ] **DatabaseName** kolonu seçildi
- [ ] **Duration** filtresi kaldırıldı (veya 0'a ayarlandı)
- [ ] Trace başlatıldı
- [ ] VB.NET uygulaması çalıştırıldı
- [ ] Sipariş senkronizasyonu yapıldı

---

## 🔍 Hala Göremiyorsanız?

### **Log Dosyalarını Kontrol Edin:**

Yeni eklediğimiz loglar size gösterecek:

```
C:\Eticaret\log\sync_2025-11-25.log
```

İçinde arayın:
```
[DEBUG] [AddOrder] CommandType: StoredProcedure
[DEBUG] [AddOrder] CommandText: dbo.Satis_Kaydet
[DEBUG] [AddOrder] Param[0]: 11111111111
[DEBUG] [AddOrder] Param[1]: 0
...
```

Bu bilgilerle:
1. ✅ SP gerçekten çağrılıyor mu? → CommandText'i görün
2. ✅ Parametreler doğru mu? → Param değerlerini görün
3. ✅ Bağlantı açık mı? → Bağlantı Durumu: Open

---

## 🎓 Kaynak ve Referanslar

- [SQL Server Profiler Documentation](https://docs.microsoft.com/en-us/sql/tools/sql-server-profiler/sql-server-profiler)
- [Extended Events Overview](https://docs.microsoft.com/en-us/sql/relational-databases/extended-events/extended-events)
- [OleDb CommandType](https://docs.microsoft.com/en-us/dotnet/api/system.data.commandtype)

---

**Hazırlayan:** AI Assistant  
**Tarih:** 2025-11-25  
**Versiyon:** 1.0
