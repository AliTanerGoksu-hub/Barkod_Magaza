# 🚀 AI DESTEKLI ÜRÜN GÖNDERİM SİSTEMİ - HIZLI BAŞLANGIÇ REHBERİ

## 📋 İÇİNDEKİLER

1. [Sistem Gereksinimleri](#sistem-gereksinimleri)
2. [Kurulum Adımları](#kurulum-adımları)
3. [İlk AI Özelliğini Ekleme (15 Dakika)](#ilk-ai-özelliğini-ekleme)
4. [Test ve Doğrulama](#test-ve-doğrulama)
5. [Sorun Giderme](#sorun-giderme)

---

## 🔧 SİSTEM GEREKSİNİMLERİ

### Yazılım Gereksinimleri
- ✅ Visual Studio 2012 veya üzeri
- ✅ .NET Framework 4.8
- ✅ Newtonsoft.Json NuGet paketi
- ✅ İnternet bağlantısı (API çağrıları için)

### Emergent LLM Key
- ✅ Emergent platformunda kayıtlı hesap
- ✅ Universal Key aktif
- ✅ Kredi bakiyesi (en az 100 TL önerilir)

### Veritabanı
- ✅ SQL Server (mevcut)
- ✅ tbStok, tbStokSinifi tabloları

---

## 📦 KURULUM ADIMLARI

### Adım 1: Newtonsoft.Json Paketi Kontrolü

Projenizde Newtonsoft.Json zaten mevcut. Kontrol için:

```vb
' frm_qukaGonder.vb dosyasının başında
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
```

✅ Eğer hata verirse:
1. Solution Explorer → References → Right Click
2. Manage NuGet Packages
3. "Newtonsoft.Json" ara ve yükle

---

### Adım 2: AI Helper Class Ekleme

1. **Solution Explorer**'da projeye sağ tıklayın
2. **Add → Existing Item** seçin
3. `AI_IMPLEMENTATION_EXAMPLE.vb` dosyasını seçin

Veya içeriği manuel kopyalayın.

---

### Adım 3: Emergent LLM Key Entegrasyonu

#### A. Doğrudan Key Kullanımı (Test için)

`frm_qukaGonder.vb` dosyasında:

```vb
' Class seviyesinde değişken ekle
Private emergentLLMKey As String = ""

' Form yüklendiğinde key'i al
Private Sub frm_qukaGonder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Try
        ' Emergent LLM Key'i al
        emergentLLMKey = GetEmergentUniversalKey()
        
        If String.IsNullOrEmpty(emergentLLMKey) Then
            MessageBox.Show("Emergent LLM Key bulunamadı! AI özellikleri devre dışı.", 
                          "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Log("SUCCESS", "Form_Load", "Emergent LLM Key yüklendi")
        End If
        
    Catch ex As Exception
        LogError($"Form yükleme hatası: {ex.Message}")
    End Try
End Sub

' Key alma fonksiyonu (gerçek implementasyon)
Private Function GetEmergentUniversalKey() As String
    Try
        ' emergent_integrations_manager tool çağrısı
        ' Bu satırı gerçek implementasyonda düzenleyin
        
        ' Alternatif: Veritabanından al
        Using conn As New OleDb.OleDbConnection(connection)
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand(
                "SELECT sEmergentKey FROM tbParamGenel WHERE nParamID = 1", conn)
            Dim result As Object = cmd.ExecuteScalar()
            
            If result IsNot Nothing Then
                Return result.ToString()
            End If
        End Using
        
        Return ""
        
    Catch ex As Exception
        LogError($"Key alma hatası: {ex.Message}")
        Return ""
    End Try
End Function
```

#### B. Veritabanında Key Saklama (Önerilen)

SQL'de:

```sql
-- tbParamGenel tablosuna alan ekle
ALTER TABLE tbParamGenel ADD sEmergentKey NVARCHAR(255);

-- Key'i kaydet
UPDATE tbParamGenel 
SET sEmergentKey = 'your-emergent-universal-key-here'
WHERE nParamID = 1;
```

---

## ⚡ İLK AI ÖZELLİĞİNİ EKLEME (15 Dakika)

### Özellik: AI ile Ürün Başlığı Oluşturma

#### Adım 1: AI Helper Class'ını Kullanıma Hazırla

`frm_qukaGonder.vb` dosyasında:

```vb
' Class seviyesinde AI helper tanımla
Private aiHelper As AIProductEnhancer

' Form yüklendiğinde başlat
Private Sub frm_qukaGonder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Try
        ' AI Helper'ı başlat
        aiHelper = New AIProductEnhancer()
        
        Log("SUCCESS", "Form_Load", "AI Helper başlatıldı")
        
    Catch ex As Exception
        LogError($"AI Helper başlatma hatası: {ex.Message}")
    End Try
End Sub
```

---

#### Adım 2: Mevcut SendProduct Fonksiyonunu Güncelle

Mevcut `SendProduct` fonksiyonunu bulun (yaklaşık satır 600-700):

```vb
Private Function SendProduct(ByVal id As String, ByVal conn As OleDb.OleDbConnection) As Dictionary(Of String, Object)
    Try
        ' ... Mevcut kod ...
        
        ' ÜRÜNİ AL
        Dim cmd As New OleDb.OleDbCommand
        cmd.CommandText = "SELECT TOP 1 * FROM ..."
        ' ... (mevcut sorgu)
        
        Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            Dim productData As New Dictionary(Of String, Object)
            
            ' Ürün bilgilerini doldur
            Dim model As String = reader("sModel").ToString()
            Dim renk As String = reader("sRenk").ToString()
            Dim kategori As String = reader("sKategori").ToString()
            Dim marka As String = reader("sMarka").ToString()
            
            ' ===== YENİ: AI İLE BAŞLIK OLUŞTUR =====
            Dim aiTitle As String = ""
            Try
                If aiHelper IsNot Nothing Then
                    aiTitle = aiHelper.GenerateProductTitle(
                        model:=model,
                        renk:=renk,
                        kategori:=kategori,
                        marka:=marka,
                        platform:="Trendyol"
                    )
                    
                    Log("SUCCESS", "SendProduct", $"AI başlık oluşturuldu: {aiTitle}")
                End If
            Catch aiEx As Exception
                LogError($"AI başlık hatası: {aiEx.Message}")
                ' Fallback: Manuel başlık
                aiTitle = $"{marka} {model} {renk}"
            End Try
            
            ' Başlığı kullan
            productData("title") = If(String.IsNullOrEmpty(aiTitle), $"{marka} {model}", aiTitle)
            ' ===== AI ENTEGRASYONU BİTİŞ =====
            
            ' ... Diğer alanları doldur ...
            productData("code") = reader("sBarkod").ToString()
            productData("price") = reader("lFiyat").ToString()
            ' vb...
            
            Return productData
        End If
        
        Return Nothing
        
    Catch ex As Exception
        LogError($"SendProduct hatası: {ex.Message}")
        Return Nothing
    End Try
End Function
```

---

#### Adım 3: Projeyi Derle ve Test Et

1. **Build → Rebuild Solution** (veya F6)
2. Hataları gider (varsa)
3. Uygulamayı çalıştır (F5)

---

### İlk Test: Tek Ürün İçin AI Başlık

```vb
' Test butonu ekle (formdaki bir butona tıklayınca)
Private Sub btnTestAI_Click(sender As Object, e As EventArgs) Handles btnTestAI.Click
    Try
        ' Test ürünü seç
        Dim testProductID As String = "TEST_MODEL__KIRMIZI"
        
        Using conn As New OleDb.OleDbConnection(connection)
            conn.Open()
            
            ' Ürünü gönder (AI ile zenginleştirilmiş)
            Dim result As Dictionary(Of String, Object) = SendProduct(testProductID, conn)
            
            If result IsNot Nothing Then
                MessageBox.Show(
                    $"AI Başlık Oluşturuldu!{vbCrLf}{vbCrLf}" &
                    $"Başlık: {result("title")}{vbCrLf}" &
                    $"Kod: {result("code")}{vbCrLf}" &
                    $"Fiyat: {result("price")} TL",
                    "AI Test Başarılı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )
                
                Log("SUCCESS", "btnTestAI_Click", "AI testi başarılı")
            Else
                MessageBox.Show("Ürün bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
        
    Catch ex As Exception
        MessageBox.Show($"Test hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        LogError($"AI test hatası: {ex.Message}")
    End Try
End Sub
```

---

## ✅ TEST VE DOĞRULAMA

### Test 1: Log Kontrolü

Log dosyasını kontrol edin: `AI_Operations.log`

```
[2025-11-28 16:30:15] [INFO] [GenerateProductTitle] AI başlık üretiliyor: Air Max 270 - Trendyol
[2025-11-28 16:30:17] [DEBUG] [CallOpenAI] API çağrısı yapılıyor... Prompt uzunluğu: 245
[2025-11-28 16:30:19] [SUCCESS] [CallOpenAI] AI yanıtı alındı. Uzunluk: 87
[2025-11-28 16:30:19] [SUCCESS] [GenerateProductTitle] Başlık oluşturuldu: Nike Air Max 270 Siyah Erkek Spor Ayakkabı
```

### Test 2: Veritabanı Kontrolü

```sql
-- Son güncellenen ürünleri kontrol et
SELECT TOP 10 
    sModel,
    sRenk,
    sStokAdi AS ManuelBaslik,
    -- AI başlığı başka bir alanda saklanabilir
    dteGuncelleme
FROM tbStok
WHERE dteGuncelleme >= CAST(GETDATE() AS DATE)
ORDER BY dteGuncelleme DESC
```

### Test 3: API Maliyet Kontrolü

Emergent Dashboard:
1. Profile → Universal Key → Usage
2. Son 24 saatteki kullanımı kontrol et
3. Ortalama maliyet: ~0.10-0.50 TL/ürün (başlık için)

---

## 🔥 HIZLI KULLANIM ÖRNEKLERİ

### Örnek 1: Toplu Ürün Başlığı Güncelleme

```vb
Private Sub BulkUpdateProductTitles()
    Try
        Using conn As New OleDb.OleDbConnection(connection)
            conn.Open()
            
            ' Son 50 güncellenmeyen ürünü al
            Dim cmd As New OleDb.OleDbCommand(
                "SELECT TOP 50 sModel, sRenk, sMarka, sKategori, sBarkod " &
                "FROM tbStok WHERE bWebGoruntule = 1 " &
                "ORDER BY dteGuncelleme ASC", conn)
            
            Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
            Dim updatedCount As Integer = 0
            
            While reader.Read()
                Dim model As String = reader("sModel").ToString()
                Dim renk As String = reader("sRenk").ToString()
                Dim marka As String = reader("sMarka").ToString()
                Dim kategori As String = reader("sKategori").ToString()
                Dim barkod As String = reader("sBarkod").ToString()
                
                Try
                    ' AI başlık oluştur
                    Dim aiTitle As String = aiHelper.GenerateProductTitle(
                        model, renk, kategori, marka, "Trendyol")
                    
                    ' Veritabanına kaydet
                    Dim updateCmd As New OleDb.OleDbCommand(
                        "UPDATE tbStok SET sStokAdi = ?, dteGuncelleme = GETDATE() " &
                        "WHERE sBarkod = ?", conn)
                    updateCmd.Parameters.AddWithValue("?", aiTitle)
                    updateCmd.Parameters.AddWithValue("?", barkod)
                    updateCmd.ExecuteNonQuery()
                    
                    updatedCount += 1
                    Log("SUCCESS", "BulkUpdateProductTitles", 
                        $"Güncellendi: {barkod} -> {aiTitle}")
                    
                Catch aiEx As Exception
                    LogError($"Ürün güncelleme hatası ({barkod}): {aiEx.Message}")
                End Try
                
                ' Rate limit için bekleme (saniyede 3 istek)
                Threading.Thread.Sleep(350)
            End While
            
            reader.Close()
            
            MessageBox.Show(
                $"{updatedCount} adet ürün başlığı AI ile güncellendi!",
                "Başarılı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            
        End Using
        
    Catch ex As Exception
        LogError($"Toplu güncelleme hatası: {ex.Message}")
        MessageBox.Show($"Hata: {ex.Message}", "Hata", 
                       MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
End Sub
```

---

### Örnek 2: Platform-Specific Başlıklar

```vb
Private Sub GeneratePlatformSpecificTitles(productCode As String)
    Try
        Using conn As New OleDb.OleDbConnection(connection)
            conn.Open()
            
            ' Ürün bilgilerini al
            Dim cmd As New OleDb.OleDbCommand(
                "SELECT * FROM tbStok WHERE sBarkod = ?", conn)
            cmd.Parameters.AddWithValue("?", productCode)
            Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
            
            If reader.Read() Then
                Dim model As String = reader("sModel").ToString()
                Dim renk As String = reader("sRenk").ToString()
                Dim kategori As String = reader("sKategori").ToString()
                Dim marka As String = reader("sMarka").ToString()
                
                ' Her platform için ayrı başlık
                Dim platforms As String() = {"Trendyol", "HepsiBurada", "N11"}
                
                For Each platform As String In platforms
                    Dim aiTitle As String = aiHelper.GenerateProductTitle(
                        model, renk, kategori, marka, platform)
                    
                    Console.WriteLine($"{platform}: {aiTitle}")
                    
                    ' Her platform için ayrı alanlara kaydet
                    ' (veritabanında sTrendyolBaslik, sHepsiBuradaBaslik vb.)
                Next
            End If
            
            reader.Close()
        End Using
        
    Catch ex As Exception
        LogError($"Platform başlıkları hatası: {ex.Message}")
    End Try
End Sub
```

---

## 🛠️ SORUN GİDERME

### Sorun 1: "Emergent LLM Key bulunamadı"

**Çözüm:**
```vb
' tbParamGenel tablosunu kontrol et
SELECT sEmergentKey FROM tbParamGenel WHERE nParamID = 1

-- Boş ise ekle:
UPDATE tbParamGenel SET sEmergentKey = 'your-key-here' WHERE nParamID = 1
```

---

### Sorun 2: "API çağrısı hatası - 401 Unauthorized"

**Nedeni:** Key geçersiz veya süresi dolmuş

**Çözüm:**
1. Emergent Dashboard → Profile → Universal Key
2. Key'i yenile
3. Veritabanını güncelle

---

### Sorun 3: "JSON parse hatası"

**Nedeni:** AI beklenmedik format döndü

**Çözüm:**
```vb
' Prompt'u daha spesifik yap
Dim prompt As String = "... SADECE JSON DÖNDÜR, BAŞKA BİR ŞEY YAZMA! ..."

' Try-catch ile fallback ekle
Try
    Dim result = JsonConvert.DeserializeObject(aiResponse)
Catch jsonEx As Exception
    ' Fallback: Manuel değer
    result = New Dictionary(Of String, Object) From {{"title", "Varsayılan Başlık"}}
End Try
```

---

### Sorun 4: "AI yanıtı çok yavaş (10+ saniye)"

**Nedeni:** 
- İnternet bağlantısı yavaş
- API token limiti aşıldı
- Prompt çok uzun

**Çözüm:**
```vb
' Timeout ekle
cmd.CommandTimeout = 30 ' 30 saniye

' Prompt'u kısalt
' Önceki: 500 kelime → Sonraki: 150 kelime

' Paralel işleme
' Task.Run() ile asenkron çalıştır
```

---

### Sorun 5: "Türkçe karakterler bozuk"

**Çözüm:**
```vb
' UTF-8 encoding kullan
Using client As New WebClient()
    client.Encoding = System.Text.Encoding.UTF8
    ' ...
End Using

' Veritabanında NVARCHAR kullan
ALTER TABLE tbStok ALTER COLUMN sStokAdi NVARCHAR(255)
```

---

## 📊 PERFORMANS İZLEME

### Metrikler

```vb
' Log dosyasından metrikleri oku
Private Function GetAIPerformanceMetrics() As Dictionary(Of String, Object)
    Try
        Dim logLines As String() = File.ReadAllLines("AI_Operations.log")
        
        Dim totalCalls As Integer = 0
        Dim successCalls As Integer = 0
        Dim errorCalls As Integer = 0
        Dim avgResponseTime As Double = 0
        
        For Each line As String In logLines
            If line.Contains("[CallOpenAI]") Then
                totalCalls += 1
                
                If line.Contains("[SUCCESS]") Then
                    successCalls += 1
                ElseIf line.Contains("[ERROR]") Then
                    errorCalls += 1
                End If
            End If
        Next
        
        Return New Dictionary(Of String, Object) From {
            {"total_calls", totalCalls},
            {"success_rate", (successCalls / totalCalls) * 100},
            {"error_rate", (errorCalls / totalCalls) * 100}
        }
        
    Catch ex As Exception
        Return New Dictionary(Of String, Object)
    End Try
End Function
```

---

## 🎯 SONRAKİ ADIMLAR

### Hafta 1
- ✅ AI başlık üretimi (TAMAMLANDI)
- ⏳ AI açıklama üretimi
- ⏳ Log ve monitoring sistemi

### Hafta 2
- ⏳ Görsel kalite kontrolü
- ⏳ Akıllı fiyatlandırma
- ⏳ A/B testleri

### Hafta 3
- ⏳ Stok tahmini
- ⏳ Otomatik müşteri desteği
- ⏳ Raporlama dashboard'u

---

## 💡 İPUÇLARI VE EN İYİ UYGULAMALAR

### 1. Prompt Engineering
```vb
' ❌ Kötü Prompt
"Bu ürün için başlık yaz"

' ✅ İyi Prompt
"Sen bir e-ticaret uzmanısın. Trendyol platformu için SEO-friendly, 
100 karakter maksimum, marka adını başa alan bir başlık oluştur. 
Ürün: Nike Air Max 270 Siyah Spor Ayakkabı. 
SADECE BAŞLIĞI DÖNDÜR, BAŞKA BİR ŞEY YAZMA!"
```

### 2. Rate Limiting
```vb
' Saniyede 3 istek sınırı
Private lastApiCallTime As DateTime = DateTime.MinValue

Private Sub RateLimitCheck()
    Dim timeSinceLastCall As TimeSpan = DateTime.Now - lastApiCallTime
    If timeSinceLastCall.TotalMilliseconds < 350 Then
        Threading.Thread.Sleep(350 - CInt(timeSinceLastCall.TotalMilliseconds))
    End If
    lastApiCallTime = DateTime.Now
End Sub
```

### 3. Caching
```vb
' Aynı ürün için tekrar AI çağrısı yapma
Private aiTitleCache As New Dictionary(Of String, String)

Private Function GetOrGenerateTitle(productCode As String) As String
    If aiTitleCache.ContainsKey(productCode) Then
        Return aiTitleCache(productCode)
    End If
    
    Dim aiTitle As String = aiHelper.GenerateProductTitle(...)
    aiTitleCache(productCode) = aiTitle
    
    Return aiTitle
End Function
```

---

## 📞 DESTEK VE KAYNAKLAR

- **Emergent Dokümantasyon:** [emergent.ai/docs](https://emergent.ai/docs)
- **OpenAI API Referans:** [platform.openai.com/docs](https://platform.openai.com/docs)
- **Bu Proje Log Dosyası:** `AI_Operations.log`
- **Detaylı Analiz Raporu:** `AI_ENHANCED_ANALYSIS_REPORT.md`

---

**Başarılar! 🚀**

Bu rehber ile ilk AI özelliğinizi 15 dakikada ekleyebilir ve müşterilerinizin satışlarını artırmaya başlayabilirsiniz!
