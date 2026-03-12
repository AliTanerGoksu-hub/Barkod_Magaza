# ⚡ AUDIT LOG - HIZLI BAŞLANGIÇ REHBERİ

## 5 Dakikada Çalıştır! 🚀

### ADIM 1: SQL Script Çalıştır (2 dk)

```sql
-- SQL Server Management Studio'da:
-- AuditLogSystem/01_CREATE_tbAuditLog.sql dosyasını aç ve çalıştır (F5)
```

✅ 3 tablo, 5 index, 2 procedure oluşturuldu!

---

### ADIM 2: VB.NET Dosyalarını Ekle (1 dk)

```
Visual Studio'da:
1. Solution Explorer → Sağ Tık → Add → Existing Item
2. AuditLogger.vb seç → Ekle
3. frm_AuditLog_Rapor.vb seç → Ekle
4. NuGet → Install-Package Newtonsoft.Json
```

---

### ADIM 3: Bağlantı Ayarı (1 dk)

**AuditLogger.vb** dosyasında (~satır 685):

```vb
Private Shared Function YeniBaglanti() As Object
    ' BURAYA BAGLANTI STRING YAZIN:
    Return New SqlConnection("Data Source=SUNUCU;Initial Catalog=BARKOD_MAGAZA;Integrated Security=True")
End Function
```

---

### ADIM 4: İlk Test (1 dk)

**Form1.vb veya ana formunuzda:**

```vb
Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ' Audit Logger başlat
    AuditLogger.AktifKullanici = "Test_User"
    AuditLogger.LoglamaAktif = True
    
    ' Test log kaydet
    AuditLogger.LogInsert(
        AuditLogger.ModulAdi.SISTEM,
        "Test",
        1,
        "TEST-001",
        "{""test"":true}",
        "Test log kaydı"
    )
End Sub
```

**Çalıştır** → SQL'de kontrol et:

```sql
SELECT * FROM tbAuditLog ORDER BY nAuditLogID DESC
```

✅ Log kaydı görünüyorsa sistem çalışıyor! 🎉

---

## İLK ENTEGRASYON: Sipariş Formu

**frm_tbSiparis.vb** dosyanızda, kaydet butonuna:

```vb
Private Sub btnKaydet_Click(sender As Object, e As EventArgs)
    ' ... mevcut kodunuz ...
    
    ' Sipariş kaydettikten sonra:
    Try
        AuditLogger.LogInsert(
            AuditLogger.ModulAdi.SIPARIS,
            "tbSiparis",
            siparisID,
            siparisNo,
            AuditLogger.ToJson(New With {.SiparisNo = siparisNo, .Firma = txtFirma.Text}),
            "Yeni sipariş oluşturuldu"
        )
    Catch ex As Exception
        ' Log hatası uygulamayı etkilemez
    End Try
End Sub
```

✅ Sipariş oluştur → `SELECT * FROM tbAuditLog` → Log görünüyor! 🎊

---

## RAPOR FORMU

**Menüde butona:**

```vb
Private Sub btnAuditLog_Click(sender As Object, e As EventArgs)
    Dim frm As New frm_AuditLog_Rapor()
    frm.ShowDialog()
End Sub
```

✅ Tüm loglar tek ekranda! 📊

---

## SOFT DELETE KULLANIMI

**Sipariş silerken:**

```vb
Private Sub btnSil_Click(sender As Object, e As EventArgs)
    ' Fiziksel silme YERİNE:
    ' DELETE FROM tbSiparis WHERE ... ❌
    
    ' Soft delete YAP:
    Using conn As New SqlConnection(BaglantiString)
        conn.Open()
        Dim cmd As New SqlCommand(
            "UPDATE tbSiparis SET bSilindi=1, dteSilinmeTarihi=GETDATE(), " &
            "sSilenKullanici=@user WHERE nSiparisID=@id", conn)
        cmd.Parameters.AddWithValue("@id", siparisID)
        cmd.Parameters.AddWithValue("@user", AuditLogger.AktifKullanici)
        cmd.ExecuteNonQuery()
    End Using
    
    ' Log kaydet
    AuditLogger.LogDelete(
        AuditLogger.ModulAdi.SIPARIS,
        "tbSiparis",
        siparisID,
        siparisNo,
        "{""silindi"":true}",
        "Sipariş silindi"
    )
End Sub
```

✅ Sipariş "silinmiş" ama geri yüklenebilir! 🔄

---

## SORGULARDA DEĞİŞİKLİK

**Önceki:**
```sql
SELECT * FROM tbSiparis
```

**Şimdi:**
```sql
SELECT * FROM tbSiparis WHERE bSilindi = 0
-- veya ISNULL(bSilindi, 0) = 0
```

✅ Silinen kayıtlar gözükmez!

---

## FAYDA ANALİZİ

### Kim Neyi Değiştirdi?

```sql
SELECT 
    sKullaniciAdi AS Kullanici,
    sIslemTipi AS Islem,
    sKayitReferans AS Kayit,
    sAlanAdi AS Alan,
    sEskiDeger AS Eski,
    sYeniDeger AS Yeni,
    dteIslemZamani AS Zaman
FROM tbAuditLog
WHERE nKayitID = 12345 -- Sipariş ID
ORDER BY dteIslemZamani DESC
```

**Çıktı:**
```
Kullanici | Islem  | Kayit        | Alan         | Eski    | Yeni    | Zaman
----------|--------|--------------|--------------|---------|---------|-------------------
Ali       | UPDATE | SIP-2025-001 | lNetTutar    | 1000.00 | 1500.00 | 2025-12-11 14:30
Ayşe      | UPDATE | SIP-2025-001 | sFirmaKodu   | FRM001  | FRM002  | 2025-12-11 13:15
Mehmet    | INSERT | SIP-2025-001 | -            | -       | -       | 2025-12-11 10:00
```

✅ Tam geçmiş! 🔍

---

## PERFORMANS İPUÇLARI

### Sadece Kritik Modüllerde Loglama

```vb
' Sipariş, Fatura, Finans → Logla
AuditLogger.LoglamaAktif = True

' Parametre, Raporlar → Loglama
' SQL: UPDATE tbAuditModuller SET bLogAktif=0 WHERE sModulKodu='PARAMETRE'
```

### Detaylı Loglama Kapat (Hızlı mod)

```vb
AuditLogger.DetayliLoglama = False ' Alan bazlı log yok, sadece genel kayıt
```

### Eski Logları Temizle

```sql
-- 1 yıldan eski logları sil
DELETE FROM tbAuditLog WHERE dteIslemZamani < DATEADD(YEAR, -1, GETDATE())

-- veya arşivle
INSERT INTO tbAuditLog_Arsiv SELECT * FROM tbAuditLog WHERE dteIslemZamani < DATEADD(YEAR, -1, GETDATE())
DELETE FROM tbAuditLog WHERE dteIslemZamani < DATEADD(YEAR, -1, GETDATE())
```

---

## SORUN GİDERME HIZLI KONTROL

### Log kayıtları oluşmuyor?

```vb
' 1. Debug modda çalıştır
AuditLogger.LogInsert(...) ' Breakpoint koy

' 2. Try-Catch ekle
Try
    AuditLogger.LogInsert(...)
Catch ex As Exception
    MessageBox.Show("Log hatası: " & ex.Message)
End Try

' 3. SQL'de kontrol
-- SELECT * FROM tbAuditLog ORDER BY nAuditLogID DESC
```

### Bağlantı hatası?

```vb
' YeniBaglanti() metodunu test et
Dim conn = AuditLogger.YeniBaglanti()
If conn IsNot Nothing Then
    MessageBox.Show("Bağlantı OK!")
Else
    MessageBox.Show("Bağlantı HATA!")
End If
```

---

## ÖZET: 5 DAKİKA İÇİNDE ✅

1. ✅ SQL script çalıştır
2. ✅ VB dosyaları ekle
3. ✅ Bağlantı ayarla
4. ✅ İlk test yap
5. ✅ Sipariş formuna entegre et

**HAZIR! 🎉**

---

## SONRAKİ ADIMLAR

📖 **Detaylı rehber:** `AUDIT_LOG_KURULUM_REHBERI.md`  
🔧 **Tüm modül örnekleri:** İçeride var!  
📊 **Raporlama:** Hazır form mevcut!  

**Kolay gelsin!** 🚀
