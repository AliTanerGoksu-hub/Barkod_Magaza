# 💻 KODLAMA REHBERİ

## Dosya Yapısı

```
/app/
├── TrendyolAPI.vb                    → API iletişim sınıfı
├── TrendyolModels.vb                 → Veri modelleri
├── frm_TrendyolAyar.vb               → API ayarları formu
├── frm_TrendyolBuyBoxAnaliz.vb       → BuyBox analiz/eşleştirme formu
├── frm_TrendyolEntegrasyon.vb        → Ana senkronizasyon formu
└── frm_TrendyolLog.vb                → Log görüntüleme formu
```

---

## 📄 DOSYA 1: TrendyolModels.vb

```vb
' ============================================
' TRENDYOL API MODEL SINIFLARI
' ============================================

Imports Newtonsoft.Json

Namespace TrendyolIntegration

    ''' <summary>
    ''' Fiyat ve stok güncelleme için item modeli
    ''' </summary>
    Public Class PriceStockItem
        <JsonProperty("barcode")>
        Public Property Barcode As String
        
        <JsonProperty("quantity")>
        Public Property Quantity As Integer
        
        <JsonProperty("salePrice")>
        Public Property SalePrice As Decimal
        
        <JsonProperty("listPrice")>
        Public Property ListPrice As Decimal
    End Class

    ''' <summary>
    ''' Fiyat/Stok güncelleme isteği
    ''' </summary>
    Public Class PriceStockRequest
        <JsonProperty("items")>
        Public Property Items As List(Of PriceStockItem)
    End Class

    ''' <summary>
    ''' Batch request sonucu
    ''' </summary>
    Public Class BatchResponse
        <JsonProperty("batchRequestId")>
        Public Property BatchRequestId As String
    End Class

    ''' <summary>
    ''' Batch status item
    ''' </summary>
    Public Class BatchStatusItem
        <JsonProperty("barcode")>
        Public Property Barcode As String
        
        <JsonProperty("status")>
        Public Property Status As String
        
        <JsonProperty("failureReasons")>
        Public Property FailureReasons As List(Of String)
    End Class

    ''' <summary>
    ''' Batch status response
    ''' </summary>
    Public Class BatchStatusResponse
        <JsonProperty("batchRequestId")>
        Public Property BatchRequestId As String
        
        <JsonProperty("status")>
        Public Property Status As String
        
        <JsonProperty("items")>
        Public Property Items As List(Of BatchStatusItem)
    End Class

    ''' <summary>
    ''' Ürün arama sonucu
    ''' </summary>
    Public Class ProductSearchResult
        <JsonProperty("productId")>
        Public Property ProductId As Long
        
        <JsonProperty("barcode")>
        Public Property Barcode As String
        
        <JsonProperty("title")>
        Public Property Title As String
        
        <JsonProperty("brand")>
        Public Property Brand As String
        
        <JsonProperty("categoryId")>
        Public Property CategoryId As Integer
        
        <JsonProperty("listPrice")>
        Public Property ListPrice As Decimal
        
        <JsonProperty("salePrice")>
        Public Property SalePrice As Decimal
        
        <JsonProperty("quantity")>
        Public Property Quantity As Integer
        
        <JsonProperty("sellersCount")>
        Public Property SellersCount As Integer
    End Class

    ''' <summary>
    ''' Kategori modeli
    ''' </summary>
    Public Class TrendyolCategory
        <JsonProperty("id")>
        Public Property Id As Integer
        
        <JsonProperty("name")>
        Public Property Name As String
        
        <JsonProperty("parentId")>
        Public Property ParentId As Integer?
        
        <JsonProperty("subCategories")>
        Public Property SubCategories As List(Of TrendyolCategory)
    End Class

    ''' <summary>
    ''' Marka modeli
    ''' </summary>
    Public Class TrendyolBrand
        <JsonProperty("id")>
        Public Property Id As Integer
        
        <JsonProperty("name")>
        Public Property Name As String
    End Class

    ''' <summary>
    ''' API yanıt wrapper
    ''' </summary>
    Public Class ApiResult(Of T)
        Public Property Success As Boolean
        Public Property Data As T
        Public Property ErrorMessage As String
        Public Property BatchRequestId As String
    End Class

End Namespace
```

---

## 📄 DOSYA 2: TrendyolAPI.vb

```vb
' ============================================
' TRENDYOL API İLETİŞİM SINIFI
' ============================================

Imports System.Net
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Namespace TrendyolIntegration

    Public Class TrendyolAPI
        
        Private Shared _instance As TrendyolAPI
        Private _httpClient As HttpClient
        
        ' API Bilgileri (Veritabanından yüklenecek)
        Private _supplierId As String
        Private _apiKey As String
        Private _apiSecret As String
        Private _baseUrl As String = "https://api.trendyol.com/sapigw"
        
        ''' <summary>
        ''' Singleton instance
        ''' </summary>
        Public Shared ReadOnly Property Instance As TrendyolAPI
            Get
                If _instance Is Nothing Then
                    _instance = New TrendyolAPI()
                End If
                Return _instance
            End Get
        End Property
        
        Private Sub New()
            _httpClient = New HttpClient()
            _httpClient.Timeout = TimeSpan.FromSeconds(30)
        End Sub
        
        ''' <summary>
        ''' API bilgilerini ayarla (Veritabanından çağrılacak)
        ''' </summary>
        Public Sub Configure(supplierId As String, apiKey As String, apiSecret As String, Optional baseUrl As String = Nothing)
            _supplierId = supplierId
            _apiKey = apiKey
            _apiSecret = apiSecret
            If Not String.IsNullOrEmpty(baseUrl) Then
                _baseUrl = baseUrl
            End If
            
            ' Auth header ayarla
            Dim credentials = _apiKey & ":" & _apiSecret
            Dim bytes = Encoding.UTF8.GetBytes(credentials)
            Dim authHeader = "Basic " & Convert.ToBase64String(bytes)
            
            _httpClient.DefaultRequestHeaders.Clear()
            _httpClient.DefaultRequestHeaders.Add("Authorization", authHeader)
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "BarkodMagaza-Integration/1.0")
        End Sub
        
        ''' <summary>
        ''' API ayarlı mı kontrol et
        ''' </summary>
        Public Function IsConfigured() As Boolean
            Return Not String.IsNullOrEmpty(_supplierId) AndAlso 
                   Not String.IsNullOrEmpty(_apiKey) AndAlso 
                   Not String.IsNullOrEmpty(_apiSecret)
        End Function
        
        ''' <summary>
        ''' Bağlantı testi
        ''' </summary>
        Public Async Function TestConnectionAsync() As Task(Of ApiResult(Of Boolean))
            Try
                Dim url = $"{_baseUrl}/suppliers/{_supplierId}/products?page=0&size=1"
                Dim response = Await _httpClient.GetAsync(url)
                
                Return New ApiResult(Of Boolean) With {
                    .Success = response.IsSuccessStatusCode,
                    .Data = response.IsSuccessStatusCode,
                    .ErrorMessage = If(response.IsSuccessStatusCode, Nothing, response.ReasonPhrase)
                }
            Catch ex As Exception
                Return New ApiResult(Of Boolean) With {
                    .Success = False,
                    .Data = False,
                    .ErrorMessage = ex.Message
                }
            End Try
        End Function
        
        ''' <summary>
        ''' Barkod ile ürün ara (BuyBox eşleştirme için) ⭐ KRİTİK
        ''' </summary>
        Public Async Function SearchProductByBarcodeAsync(barcode As String) As Task(Of ApiResult(Of ProductSearchResult))
            Try
                ' Önce kendi ürünlerimizde ara
                Dim url = $"{_baseUrl}/suppliers/{_supplierId}/products?barcode={barcode}"
                Dim response = Await _httpClient.GetAsync(url)
                
                If response.IsSuccessStatusCode Then
                    Dim json = Await response.Content.ReadAsStringAsync()
                    Dim result = JsonConvert.DeserializeObject(Of ProductSearchResult)(json)
                    
                    Return New ApiResult(Of ProductSearchResult) With {
                        .Success = True,
                        .Data = result
                    }
                Else
                    Return New ApiResult(Of ProductSearchResult) With {
                        .Success = False,
                        .ErrorMessage = $"HTTP {response.StatusCode}: {response.ReasonPhrase}"
                    }
                End If
            Catch ex As Exception
                Return New ApiResult(Of ProductSearchResult) With {
                    .Success = False,
                    .ErrorMessage = ex.Message
                }
            End Try
        End Function
        
        ''' <summary>
        ''' Fiyat ve Stok Güncelle ⭐ EN ÖNEMLİ FONKSİYON
        ''' BuyBox rekabetine katılmak için bu endpoint kullanılır
        ''' </summary>
        Public Async Function UpdatePriceAndInventoryAsync(items As List(Of PriceStockItem)) As Task(Of ApiResult(Of String))
            Try
                Dim url = $"{_baseUrl}/suppliers/{_supplierId}/products/price-and-inventory"
                
                Dim request = New PriceStockRequest With {
                    .Items = items
                }
                
                Dim json = JsonConvert.SerializeObject(request)
                Dim content = New StringContent(json, Encoding.UTF8, "application/json")
                
                Dim response = Await _httpClient.PostAsync(url, content)
                Dim responseJson = Await response.Content.ReadAsStringAsync()
                
                If response.IsSuccessStatusCode Then
                    Dim batchResponse = JsonConvert.DeserializeObject(Of BatchResponse)(responseJson)
                    
                    Return New ApiResult(Of String) With {
                        .Success = True,
                        .Data = "Batch gönderildi",
                        .BatchRequestId = batchResponse.BatchRequestId
                    }
                Else
                    Return New ApiResult(Of String) With {
                        .Success = False,
                        .ErrorMessage = $"HTTP {response.StatusCode}: {responseJson}"
                    }
                End If
            Catch ex As Exception
                Return New ApiResult(Of String) With {
                    .Success = False,
                    .ErrorMessage = ex.Message
                }
            End Try
        End Function
        
        ''' <summary>
        ''' Batch request durumunu kontrol et
        ''' </summary>
        Public Async Function GetBatchStatusAsync(batchRequestId As String) As Task(Of ApiResult(Of BatchStatusResponse))
            Try
                Dim url = $"{_baseUrl}/suppliers/{_supplierId}/products/batch-requests/{batchRequestId}"
                Dim response = Await _httpClient.GetAsync(url)
                
                If response.IsSuccessStatusCode Then
                    Dim json = Await response.Content.ReadAsStringAsync()
                    Dim result = JsonConvert.DeserializeObject(Of BatchStatusResponse)(json)
                    
                    Return New ApiResult(Of BatchStatusResponse) With {
                        .Success = True,
                        .Data = result
                    }
                Else
                    Return New ApiResult(Of BatchStatusResponse) With {
                        .Success = False,
                        .ErrorMessage = response.ReasonPhrase
                    }
                End If
            Catch ex As Exception
                Return New ApiResult(Of BatchStatusResponse) With {
                    .Success = False,
                    .ErrorMessage = ex.Message
                }
            End Try
        End Function
        
        ''' <summary>
        ''' Kategorileri çek
        ''' </summary>
        Public Async Function GetCategoriesAsync() As Task(Of ApiResult(Of List(Of TrendyolCategory)))
            Try
                Dim url = $"{_baseUrl}/product-categories"
                Dim response = Await _httpClient.GetAsync(url)
                
                If response.IsSuccessStatusCode Then
                    Dim json = Await response.Content.ReadAsStringAsync()
                    Dim result = JsonConvert.DeserializeObject(Of List(Of TrendyolCategory))(json)
                    
                    Return New ApiResult(Of List(Of TrendyolCategory)) With {
                        .Success = True,
                        .Data = result
                    }
                Else
                    Return New ApiResult(Of List(Of TrendyolCategory)) With {
                        .Success = False,
                        .ErrorMessage = response.ReasonPhrase
                    }
                End If
            Catch ex As Exception
                Return New ApiResult(Of List(Of TrendyolCategory)) With {
                    .Success = False,
                    .ErrorMessage = ex.Message
                }
            End Try
        End Function
        
        ''' <summary>
        ''' Markaları çek
        ''' </summary>
        Public Async Function GetBrandsAsync(Optional page As Integer = 0, Optional size As Integer = 1000) As Task(Of ApiResult(Of List(Of TrendyolBrand)))
            Try
                Dim url = $"{_baseUrl}/brands?page={page}&size={size}"
                Dim response = Await _httpClient.GetAsync(url)
                
                If response.IsSuccessStatusCode Then
                    Dim json = Await response.Content.ReadAsStringAsync()
                    Dim result = JsonConvert.DeserializeObject(Of List(Of TrendyolBrand))(json)
                    
                    Return New ApiResult(Of List(Of TrendyolBrand)) With {
                        .Success = True,
                        .Data = result
                    }
                Else
                    Return New ApiResult(Of List(Of TrendyolBrand)) With {
                        .Success = False,
                        .ErrorMessage = response.ReasonPhrase
                    }
                End If
            Catch ex As Exception
                Return New ApiResult(Of List(Of TrendyolBrand)) With {
                    .Success = False,
                    .ErrorMessage = ex.Message
                }
            End Try
        End Function
        
    End Class

End Namespace
```

---

## 📄 DOSYA 3: frm_TrendyolAyar.vb (Basit Form)

```vb
' ============================================
' TRENDYOL API AYAR FORMU
' ============================================

Public Class frm_TrendyolAyar
    
    Private Sub frm_TrendyolAyar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
    End Sub
    
    Private Sub LoadSettings()
        ' Veritabanından ayarları yükle
        Try
            Using cmd As New OleDb.OleDbCommand()
                cmd.Connection = con
                cmd.CommandText = "SELECT TOP 1 * FROM tbTrendyolAyar WHERE bAktif = 1"
                
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txt_SupplierId.Text = reader("sSupplierId").ToString()
                        txt_ApiKey.Text = reader("sApiKey").ToString()
                        txt_ApiSecret.Text = reader("sApiSecret").ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Tablo yoksa hata vermez
        End Try
    End Sub
    
    Private Async Sub btn_Test_Click(sender As Object, e As EventArgs) Handles btn_Test.Click
        If String.IsNullOrEmpty(txt_SupplierId.Text) OrElse 
           String.IsNullOrEmpty(txt_ApiKey.Text) OrElse 
           String.IsNullOrEmpty(txt_ApiSecret.Text) Then
            MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        btn_Test.Enabled = False
        lbl_Status.Text = "Test ediliyor..."
        
        Try
            TrendyolAPI.Instance.Configure(txt_SupplierId.Text, txt_ApiKey.Text, txt_ApiSecret.Text)
            Dim result = Await TrendyolAPI.Instance.TestConnectionAsync()
            
            If result.Success Then
                lbl_Status.Text = "✓ Bağlantı başarılı!"
                lbl_Status.ForeColor = Color.Green
            Else
                lbl_Status.Text = "✗ Bağlantı başarısız: " & result.ErrorMessage
                lbl_Status.ForeColor = Color.Red
            End If
        Catch ex As Exception
            lbl_Status.Text = "✗ Hata: " & ex.Message
            lbl_Status.ForeColor = Color.Red
        Finally
            btn_Test.Enabled = True
        End Try
    End Sub
    
    Private Sub btn_Kaydet_Click(sender As Object, e As EventArgs) Handles btn_Kaydet.Click
        Try
            Using cmd As New OleDb.OleDbCommand()
                cmd.Connection = con
                
                ' Önce mevcut kaydı kontrol et
                cmd.CommandText = "SELECT COUNT(*) FROM tbTrendyolAyar"
                Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                
                If count > 0 Then
                    ' Güncelle
                    cmd.CommandText = "UPDATE tbTrendyolAyar SET sSupplierId=?, sApiKey=?, sApiSecret=?, dteGuncelleme=? WHERE bAktif=1"
                Else
                    ' Ekle
                    cmd.CommandText = "INSERT INTO tbTrendyolAyar (sSupplierId, sApiKey, sApiSecret, bAktif) VALUES (?, ?, ?, 1)"
                End If
                
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@p1", txt_SupplierId.Text)
                cmd.Parameters.AddWithValue("@p2", txt_ApiKey.Text)
                cmd.Parameters.AddWithValue("@p3", txt_ApiSecret.Text)
                If count > 0 Then
                    cmd.Parameters.AddWithValue("@p4", DateTime.Now)
                End If
                
                cmd.ExecuteNonQuery()
                
                MessageBox.Show("Ayarlar kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
End Class
```

---

## 📋 IMPLEMENTASYON SIRASI

### ADIM 1: Model Sınıflarını Oluştur
```
1. /app/TrendyolModels.vb dosyasını oluştur
2. BARKOD_MAGAZA.vbproj'a ekle
3. Derleme kontrolü yap
```

### ADIM 2: API Sınıfını Oluştur
```
1. /app/TrendyolAPI.vb dosyasını oluştur
2. Newtonsoft.Json referansı ekle (yoksa)
3. BARKOD_MAGAZA.vbproj'a ekle
4. Derleme kontrolü yap
```

### ADIM 3: Ayar Formunu Oluştur
```
1. /app/frm_TrendyolAyar.vb oluştur
2. /app/frm_TrendyolAyar.Designer.vb oluştur
3. BARKOD_MAGAZA.vbproj'a ekle
4. Test et
```

### ADIM 4: Ana Menüye Ekle
```
1. Form1.vb'de Trendyol menüsü ekle
2. Alt menüler: Ayarlar, BuyBox Analiz, Senkronizasyon
```

### ADIM 5: BuyBox Analiz Formunu Oluştur
```
Bu en önemli form - BuyBox eşleştirme burada yapılacak
```

### ADIM 6: Senkronizasyon Formunu Oluştur
```
Fiyat/Stok güncelleme burada yapılacak
```

---

## ⚠️ NOTLAR

1. **Newtonsoft.Json**: Proje'de yoksa NuGet'ten ekle
2. **HttpClient**: System.Net.Http referansı gerekli
3. **Async/Await**: .NET Framework 4.5+ gerekli
4. **Encoding**: API UTF-8 bekliyor
5. **Timeout**: 30 saniye varsayılan, artırılabilir
