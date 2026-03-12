' ============================================
' TRENDYOL API İLETİŞİM SINIFI
' Dosya: TrendyolAPI.vb
' Tarih: 2026-01-30
' Açıklama: Trendyol API ile iletişim için ana sınıf
' ============================================

Imports System.Net
Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports System.IO
Imports System.Collections.Generic
Imports Newtonsoft.Json

Public Class TrendyolAPI

#Region "Singleton & Configuration"

    Private Shared _instance As TrendyolAPI
    Private _httpClient As HttpClient
    
    ' API Bilgileri
    Private _supplierId As String = ""
    Private _apiKey As String = ""
    Private _apiSecret As String = ""
    Private _baseUrl As String = "https://apigw.trendyol.com/integration"
    Private _isConfigured As Boolean = False
    
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
        ' SSL/TLS ayarları
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls
        
        ' HttpClient oluştur
        Dim handler As New HttpClientHandler()
        handler.AutomaticDecompression = DecompressionMethods.GZip Or DecompressionMethods.Deflate
        
        _httpClient = New HttpClient(handler)
        _httpClient.Timeout = TimeSpan.FromSeconds(60)
    End Sub
    
    ''' <summary>
    ''' API bilgilerini ayarla
    ''' </summary>
    Public Sub Configure(supplierId As String, apiKey As String, apiSecret As String, Optional baseUrl As String = Nothing)
        _supplierId = supplierId
        _apiKey = apiKey
        _apiSecret = apiSecret
        
        If Not String.IsNullOrEmpty(baseUrl) Then
            _baseUrl = baseUrl
        End If
        
        ' Auth header ayarla - Trendyol özel format kullanıyor
        ' Authorization yerine "Auth" header'ı ve User-Agent: SelfIntegration gerekli
        Dim credentials As String = _apiKey & ":" & _apiSecret
        Dim bytes() As Byte = Encoding.UTF8.GetBytes(credentials)
        Dim authValue As String = "Basic " & Convert.ToBase64String(bytes)
        
        _httpClient.DefaultRequestHeaders.Clear()
        ' Trendyol için özel header'lar
        _httpClient.DefaultRequestHeaders.Add("User-Agent", _supplierId & " - SelfIntegration")
        _httpClient.DefaultRequestHeaders.Add("Authorization", authValue)
        _httpClient.DefaultRequestHeaders.Add("Accept", "application/json")
        _httpClient.DefaultRequestHeaders.Add("Accept-Language", "tr-TR")
        
        _isConfigured = True
    End Sub
    
    ''' <summary>
    ''' Yapılandırma kontrolü
    ''' </summary>
    Public ReadOnly Property IsConfigured As Boolean
        Get
            Return _isConfigured AndAlso 
                   Not String.IsNullOrEmpty(_supplierId) AndAlso 
                   Not String.IsNullOrEmpty(_apiKey)
        End Get
    End Property
    
    ''' <summary>
    ''' Supplier ID
    ''' </summary>
    Public ReadOnly Property SupplierId As String
        Get
            Return _supplierId
        End Get
    End Property

#End Region

#Region "HTTP Helpers"

    ''' <summary>
    ''' GET request
    ''' </summary>
    Private Async Function GetRequestAsync(endpoint As String) As Task(Of String)
        Dim url As String = _baseUrl & endpoint
        Dim response As HttpResponseMessage = Await _httpClient.GetAsync(url)
        Return Await response.Content.ReadAsStringAsync()
    End Function
    
    ''' <summary>
    ''' GET request with status code
    ''' </summary>
    Private Async Function GetRequestWithStatusAsync(endpoint As String) As Task(Of Tuple(Of String, HttpStatusCode))
        Dim url As String = _baseUrl & endpoint
        Dim response As HttpResponseMessage = Await _httpClient.GetAsync(url)
        Dim content As String = Await response.Content.ReadAsStringAsync()
        Dim resultTuple As New Tuple(Of String, HttpStatusCode)(content, response.StatusCode)
        Return resultTuple
    End Function
    
    ''' <summary>
    ''' POST request
    ''' </summary>
    Private Async Function PostRequestAsync(endpoint As String, jsonBody As String) As Task(Of Tuple(Of String, HttpStatusCode))
        Dim url As String = _baseUrl & endpoint
        Dim postContent As New StringContent(jsonBody, Encoding.UTF8, "application/json")
        Dim response As HttpResponseMessage = Await _httpClient.PostAsync(url, postContent)
        Dim responseBody As String = Await response.Content.ReadAsStringAsync()
        Dim resultTuple As New Tuple(Of String, HttpStatusCode)(responseBody, response.StatusCode)
        Return resultTuple
    End Function
    
    ''' <summary>
    ''' PUT request - Mevcut ürün güncelleme için
    ''' </summary>
    Private Async Function PutRequestAsync(endpoint As String, jsonBody As String) As Task(Of Tuple(Of String, HttpStatusCode))
        Dim url As String = _baseUrl & endpoint
        Dim putContent As New StringContent(jsonBody, Encoding.UTF8, "application/json")
        Dim response As HttpResponseMessage = Await _httpClient.PutAsync(url, putContent)
        Dim responseBody As String = Await response.Content.ReadAsStringAsync()
        Dim resultTuple As New Tuple(Of String, HttpStatusCode)(responseBody, response.StatusCode)
        Return resultTuple
    End Function

#End Region

#Region "API Methods"

    ''' <summary>
    ''' Bağlantı testi
    ''' </summary>
    Public Async Function TestConnectionAsync() As Task(Of ApiResult(Of Boolean))
        If Not IsConfigured Then
            Return ApiResult(Of Boolean).Fail("API yapılandırılmamış. Lütfen Configure() metodunu çağırın.")
        End If
        
        Try
            Dim httpResult As Tuple(Of String, HttpStatusCode) = Await GetRequestWithStatusAsync("/product/sellers/" & _supplierId & "/products?page=0&size=1")
            
            If httpResult.Item2 = HttpStatusCode.OK Then
                Return ApiResult(Of Boolean).Ok(True)
            ElseIf httpResult.Item2 = HttpStatusCode.Unauthorized Then
                Return ApiResult(Of Boolean).Fail("Yetkilendirme hatası! API Key veya Secret yanlış.", 401)
            Else
                Return ApiResult(Of Boolean).Fail("HTTP " & CInt(httpResult.Item2).ToString() & ": " & httpResult.Item1, CInt(httpResult.Item2))
            End If
        Catch ex As TaskCanceledException
            Return ApiResult(Of Boolean).Fail("Bağlantı zaman aşımına uğradı. İnternet bağlantınızı kontrol edin.")
        Catch ex As Exception
            Return ApiResult(Of Boolean).Fail("Hata: " & ex.Message)
        End Try
    End Function
    
    ''' <summary>
    ''' Satıcının ürünlerini listele
    ''' </summary>
    Public Async Function GetProductsAsync(Optional page As Integer = 0, Optional size As Integer = 50, Optional barcode As String = Nothing) As Task(Of ApiResult(Of ProductListResponse))
        If Not IsConfigured Then
            Return ApiResult(Of ProductListResponse).Fail("API yapılandırılmamış")
        End If
        
        Try
            Dim endpoint As String = "/product/sellers/" & _supplierId & "/products?page=" & page.ToString() & "&size=" & size.ToString()
            
            If Not String.IsNullOrEmpty(barcode) Then
                endpoint = endpoint & "&barcode=" & barcode
            End If
            
            Dim httpResult As Tuple(Of String, HttpStatusCode) = Await GetRequestWithStatusAsync(endpoint)
            
            If httpResult.Item2 = HttpStatusCode.OK Then
                Dim response As ProductListResponse = JsonConvert.DeserializeObject(Of ProductListResponse)(httpResult.Item1)
                Return ApiResult(Of ProductListResponse).Ok(response)
            Else
                Return ApiResult(Of ProductListResponse).Fail("HTTP " & CInt(httpResult.Item2).ToString(), CInt(httpResult.Item2))
            End If
        Catch ex As Exception
            Return ApiResult(Of ProductListResponse).Fail(ex.Message)
        End Try
    End Function
    
    ''' <summary>
    ''' Barkod ile ürün ara - BuyBox eşleştirme için kritik!
    ''' </summary>
    Public Async Function SearchProductByBarcodeAsync(barcode As String) As Task(Of ApiResult(Of TrendyolProduct))
        If Not IsConfigured Then
            Return ApiResult(Of TrendyolProduct).Fail("API yapılandırılmamış")
        End If
        
        If String.IsNullOrEmpty(barcode) Then
            Return ApiResult(Of TrendyolProduct).Fail("Barkod boş olamaz")
        End If
        
        Try
            ' Önce kendi ürünlerimizde ara
            Dim endpoint As String = "/product/sellers/" & _supplierId & "/products?barcode=" & barcode
            Dim httpResult As Tuple(Of String, HttpStatusCode) = Await GetRequestWithStatusAsync(endpoint)
            
            If httpResult.Item2 = HttpStatusCode.OK Then
                Dim response As ProductListResponse = JsonConvert.DeserializeObject(Of ProductListResponse)(httpResult.Item1)
                
                If response IsNot Nothing AndAlso response.Content IsNot Nothing AndAlso response.Content.Count > 0 Then
                    Return ApiResult(Of TrendyolProduct).Ok(response.Content(0))
                Else
                    Return ApiResult(Of TrendyolProduct).Fail("Ürün bulunamadı", 404)
                End If
            Else
                Return ApiResult(Of TrendyolProduct).Fail("HTTP " & CInt(httpResult.Item2).ToString(), CInt(httpResult.Item2))
            End If
        Catch ex As Exception
            Return ApiResult(Of TrendyolProduct).Fail(ex.Message)
        End Try
    End Function
    
    ''' <summary>
    ''' StockCode (Model) ile ürün ara
    ''' </summary>
    Public Async Function SearchProductByStockCodeAsync(stockCode As String) As Task(Of ApiResult(Of TrendyolProduct))
        If Not IsConfigured Then
            Return ApiResult(Of TrendyolProduct).Fail("API yapılandırılmamış")
        End If
        
        If String.IsNullOrEmpty(stockCode) Then
            Return ApiResult(Of TrendyolProduct).Fail("StockCode boş olamaz")
        End If
        
        Try
            Dim endpoint As String = "/product/sellers/" & _supplierId & "/products?stockCode=" & stockCode
            Dim httpResult As Tuple(Of String, HttpStatusCode) = Await GetRequestWithStatusAsync(endpoint)
            
            If httpResult.Item2 = HttpStatusCode.OK Then
                Dim response As ProductListResponse = JsonConvert.DeserializeObject(Of ProductListResponse)(httpResult.Item1)
                
                If response IsNot Nothing AndAlso response.Content IsNot Nothing AndAlso response.Content.Count > 0 Then
                    Return ApiResult(Of TrendyolProduct).Ok(response.Content(0))
                Else
                    Return ApiResult(Of TrendyolProduct).Fail("Ürün bulunamadı", 404)
                End If
            Else
                Return ApiResult(Of TrendyolProduct).Fail("HTTP " & CInt(httpResult.Item2).ToString(), CInt(httpResult.Item2))
            End If
        Catch ex As Exception
            Return ApiResult(Of TrendyolProduct).Fail(ex.Message)
        End Try
    End Function
    
    ''' <summary>
    ''' Fiyat ve Stok Güncelle - BuyBox için EN ÖNEMLİ FONKSİYON!
    ''' </summary>
    Public Async Function UpdatePriceAndInventoryAsync(items As List(Of PriceStockItem)) As Task(Of ApiResult(Of String))
        If Not IsConfigured Then
            Return ApiResult(Of String).Fail("API yapılandırılmamış")
        End If
        
        If items Is Nothing OrElse items.Count = 0 Then
            Return ApiResult(Of String).Fail("Güncellenecek ürün yok")
        End If
        
        Try
            Dim endpoint As String = "/inventory/sellers/" & _supplierId & "/products/price-and-inventory"
            
            ' Request body oluştur
            Dim itemList As New List(Of Object)
            For Each item As PriceStockItem In items
                itemList.Add(New With {
                    .barcode = item.Barcode,
                    .quantity = item.Quantity,
                    .salePrice = item.SalePrice,
                    .listPrice = item.ListPrice
                })
            Next
            
            Dim requestBody As Object = New With {
                .items = itemList
            }
            
            Dim json As String = JsonConvert.SerializeObject(requestBody)
            Dim httpResult As Tuple(Of String, HttpStatusCode) = Await PostRequestAsync(endpoint, json)
            
            If httpResult.Item2 = HttpStatusCode.OK OrElse httpResult.Item2 = HttpStatusCode.Accepted Then
                Dim response As BatchResponse = JsonConvert.DeserializeObject(Of BatchResponse)(httpResult.Item1)
                Dim batchId As String = ""
                If response IsNot Nothing Then
                    batchId = response.BatchRequestId
                End If
                Return ApiResult(Of String).Ok("Batch gönderildi: " & batchId, batchId)
            Else
                Return ApiResult(Of String).Fail("HTTP " & CInt(httpResult.Item2).ToString() & ": " & httpResult.Item1, CInt(httpResult.Item2))
            End If
        Catch ex As Exception
            Return ApiResult(Of String).Fail(ex.Message)
        End Try
    End Function
    
    ''' <summary>
    ''' Batch request durumunu kontrol et
    ''' </summary>
    Public Async Function GetBatchStatusAsync(batchRequestId As String) As Task(Of ApiResult(Of BatchStatusResponse))
        If Not IsConfigured Then
            Return ApiResult(Of BatchStatusResponse).Fail("API yapılandırılmamış")
        End If
        
        If String.IsNullOrEmpty(batchRequestId) Then
            Return ApiResult(Of BatchStatusResponse).Fail("Batch ID boş olamaz")
        End If
        
        Try
            Dim endpoint As String = "/product/sellers/" & _supplierId & "/products/batch-requests/" & batchRequestId
            Dim httpResult As Tuple(Of String, HttpStatusCode) = Await GetRequestWithStatusAsync(endpoint)
            
            If httpResult.Item2 = HttpStatusCode.OK Then
                Dim response As BatchStatusResponse = JsonConvert.DeserializeObject(Of BatchStatusResponse)(httpResult.Item1)
                Return ApiResult(Of BatchStatusResponse).Ok(response)
            Else
                Return ApiResult(Of BatchStatusResponse).Fail(httpResult.Item1, CInt(httpResult.Item2))
            End If
        Catch ex As Exception
            Return ApiResult(Of BatchStatusResponse).Fail(ex.Message)
        End Try
    End Function
    
    ''' <summary>
    ''' Kategorileri çek
    ''' </summary>
    Public Async Function GetCategoriesAsync() As Task(Of ApiResult(Of List(Of TrendyolCategory)))
        If Not IsConfigured Then
            Return ApiResult(Of List(Of TrendyolCategory)).Fail("API yapılandırılmamış")
        End If
        
        Try
            Dim httpResult As Tuple(Of String, HttpStatusCode) = Await GetRequestWithStatusAsync("/product/product-categories")
            
            If httpResult.Item2 = HttpStatusCode.OK Then
                Dim response As CategoryListResponse = JsonConvert.DeserializeObject(Of CategoryListResponse)(httpResult.Item1)
                Return ApiResult(Of List(Of TrendyolCategory)).Ok(response.Categories)
            Else
                Return ApiResult(Of List(Of TrendyolCategory)).Fail(httpResult.Item1, CInt(httpResult.Item2))
            End If
        Catch ex As Exception
            Return ApiResult(Of List(Of TrendyolCategory)).Fail(ex.Message)
        End Try
    End Function
    
    ''' <summary>
    ''' Markaları çek
    ''' </summary>
    Public Async Function GetBrandsAsync(Optional page As Integer = 0, Optional size As Integer = 5000) As Task(Of ApiResult(Of List(Of TrendyolBrand)))
        If Not IsConfigured Then
            Return ApiResult(Of List(Of TrendyolBrand)).Fail("API yapılandırılmamış")
        End If
        
        Try
            Dim httpResult As Tuple(Of String, HttpStatusCode) = Await GetRequestWithStatusAsync("/product/brands?page=" & page.ToString() & "&size=" & size.ToString())
            
            If httpResult.Item2 = HttpStatusCode.OK Then
                Dim response As BrandListResponse = JsonConvert.DeserializeObject(Of BrandListResponse)(httpResult.Item1)
                Return ApiResult(Of List(Of TrendyolBrand)).Ok(response.Brands)
            Else
                Return ApiResult(Of List(Of TrendyolBrand)).Fail(httpResult.Item1, CInt(httpResult.Item2))
            End If
        Catch ex As Exception
            Return ApiResult(Of List(Of TrendyolBrand)).Fail(ex.Message)
        End Try
    End Function
    
    ''' <summary>
    ''' Trendyol Public API ile barkod araması - TÜM satıcıları ve kategorileri döndürür
    ''' BuyBox için kritik - rakiplerin kategorisini bulmak için kullanılır
    ''' </summary>
    Public Async Function SearchBarcodePublicAsync(barcode As String) As Task(Of ApiResult(Of TrendyolPublicSearchResult))
        If String.IsNullOrEmpty(barcode) Then
            Return ApiResult(Of TrendyolPublicSearchResult).Fail("Barkod boş olamaz")
        End If
        
        Try
            ' Trendyol Public API - Authentication gerektirmez
            Dim publicClient As New HttpClient()
            publicClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36")
            publicClient.DefaultRequestHeaders.Add("Accept", "application/json")
            
            Dim url As String = "https://apigw.trendyol.com/discovery-web-searchgw-service/v2/api/infinite-scroll/sr?q=" & barcode
            Dim response As HttpResponseMessage = Await publicClient.GetAsync(url)
            Dim content As String = Await response.Content.ReadAsStringAsync()
            
            If response.StatusCode = HttpStatusCode.OK Then
                Dim searchResponse As TrendyolPublicSearchResponse = JsonConvert.DeserializeObject(Of TrendyolPublicSearchResponse)(content)
                
                If searchResponse IsNot Nothing AndAlso searchResponse.IsSuccess AndAlso searchResponse.Result IsNot Nothing Then
                    Dim result As New TrendyolPublicSearchResult()
                    result.Products = New List(Of TrendyolPublicProduct)()
                    
                    If searchResponse.Result.Products IsNot Nothing Then
                        For Each p As TrendyolPublicProduct In searchResponse.Result.Products
                            result.Products.Add(p)
                        Next
                    End If
                    
                    Return ApiResult(Of TrendyolPublicSearchResult).Ok(result)
                Else
                    Return ApiResult(Of TrendyolPublicSearchResult).Fail("Ürün bulunamadı")
                End If
            Else
                Return ApiResult(Of TrendyolPublicSearchResult).Fail("HTTP " & CInt(response.StatusCode).ToString())
            End If
        Catch ex As Exception
            Return ApiResult(Of TrendyolPublicSearchResult).Fail(ex.Message)
        End Try
    End Function

#End Region

#Region "Utility Methods"

    ''' <summary>
    ''' Tekli ürün güncelleme (helper method)
    ''' </summary>
    Public Async Function UpdateProductAsync(barcode As String, quantity As Integer, salePrice As Decimal, listPrice As Decimal) As Task(Of ApiResult(Of String))
        Dim items As New List(Of PriceStockItem)
        items.Add(New PriceStockItem With {
            .Barcode = barcode,
            .Quantity = quantity,
            .SalePrice = salePrice,
            .ListPrice = listPrice
        })
        
        Return Await UpdatePriceAndInventoryAsync(items)
    End Function
    
    ''' <summary>
    ''' Ürün Kategori Güncelleme - BuyBox için kritik!
    ''' PUT /sapigw/suppliers/{supplierid}/v2/products endpoint'i kullanılır
    ''' Önce barkod ile arar, bulamazsa stockCode (model) ile arar
    ''' </summary>
    Public Async Function UpdateProductCategoryAsync(barcode As String, newCategoryId As String, Optional stockCode As String = Nothing) As Task(Of ApiResult(Of String))
        If Not IsConfigured Then
            Return ApiResult(Of String).Fail("API yapilandirilmamis")
        End If
        
        If String.IsNullOrEmpty(newCategoryId) Then
            Return ApiResult(Of String).Fail("Kategori ID gerekli")
        End If
        
        Try
            ' 1. Önce mevcut ürün bilgilerini al - önce barkod, sonra stockCode ile dene
            Dim productResult As ApiResult(Of TrendyolProduct) = Nothing
            
            ' Önce barkod ile ara
            If Not String.IsNullOrEmpty(barcode) Then
                productResult = Await SearchProductByBarcodeAsync(barcode)
            End If
            
            ' Barkod ile bulamazsa stockCode ile ara
            If (productResult Is Nothing OrElse Not productResult.Success) AndAlso Not String.IsNullOrEmpty(stockCode) Then
                productResult = Await SearchProductByStockCodeAsync(stockCode)
            End If
            
            If productResult Is Nothing OrElse Not productResult.Success OrElse productResult.Data Is Nothing Then
                Dim aramaYapilan As String = ""
                If Not String.IsNullOrEmpty(barcode) Then aramaYapilan = "barkod:" & barcode
                If Not String.IsNullOrEmpty(stockCode) Then aramaYapilan = aramaYapilan & " stockCode:" & stockCode
                Return ApiResult(Of String).Fail("Urun bulunamadi. Aranan: " & aramaYapilan)
            End If
            
            Dim existingProduct As TrendyolProduct = productResult.Data
            
            ' 2. Trendyol Product Update V2 endpoint'i
            ' PUT https://api.trendyol.com/sapigw/suppliers/{supplierid}/v2/products
            Dim updateUrl As String = "https://api.trendyol.com/sapigw/suppliers/" & _supplierId & "/v2/products"
            
            ' 3. Request body - TÜM zorunlu alanlar dahil
            ' Ürünün kendi barkodunu kullan (existingProduct'tan)
            Dim urunBarkod As String = existingProduct.Barcode
            If String.IsNullOrEmpty(urunBarkod) Then urunBarkod = barcode
            
            Dim updateItem As New Dictionary(Of String, Object)()
            updateItem.Add("barcode", urunBarkod)
            updateItem.Add("categoryId", CInt(newCategoryId))
            
            ' productMainId - zorunlu
            If Not String.IsNullOrEmpty(existingProduct.ProductMainId) Then
                updateItem.Add("productMainId", existingProduct.ProductMainId)
            Else
                updateItem.Add("productMainId", urunBarkod)
            End If
            
            ' title - zorunlu
            If Not String.IsNullOrEmpty(existingProduct.Title) Then
                updateItem.Add("title", existingProduct.Title)
            Else
                updateItem.Add("title", "Urun " & urunBarkod)
            End If
            
            ' description - zorunlu
            If Not String.IsNullOrEmpty(existingProduct.Description) Then
                updateItem.Add("description", existingProduct.Description)
            Else
                ' Description yoksa title'dan oluştur
                Dim desc As String = existingProduct.Title
                If String.IsNullOrEmpty(desc) Then
                    desc = "Urun aciklamasi - " & urunBarkod
                End If
                updateItem.Add("description", desc)
            End If
            
            ' brandId - zorunlu
            Dim brandIdValue As Integer = 0
            If Not String.IsNullOrEmpty(existingProduct.BrandId) Then
                Integer.TryParse(existingProduct.BrandId, brandIdValue)
            End If
            
            If brandIdValue > 0 Then
                updateItem.Add("brandId", brandIdValue)
            Else
                ' BrandId yoksa hata döndür
                Return ApiResult(Of String).Fail("Urunun marka bilgisi (brandId) bulunamadi. Lutfen once urunu Trendyol'da duzenleyin.")
            End If
            
            ' Fiyat ve miktar - zorunlu
            updateItem.Add("quantity", existingProduct.Quantity)
            updateItem.Add("listPrice", existingProduct.ListPrice)
            updateItem.Add("salePrice", existingProduct.SalePrice)
            updateItem.Add("vatRate", 10)
            updateItem.Add("currencyType", "TRY")
            
            ' StockCode varsa ekle
            If Not String.IsNullOrEmpty(existingProduct.StockCode) Then
                updateItem.Add("stockCode", existingProduct.StockCode)
            End If
            
            Dim itemList As New List(Of Object)
            itemList.Add(updateItem)
            
            Dim requestBody As New Dictionary(Of String, Object)()
            requestBody.Add("items", itemList)
            
            Dim json As String = JsonConvert.SerializeObject(requestBody)
            
            ' PUT request - Direkt URL ile gönder
            Dim putContent As New StringContent(json, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await _httpClient.PutAsync(updateUrl, putContent)
            Dim responseBody As String = Await response.Content.ReadAsStringAsync()
            
            If response.StatusCode = HttpStatusCode.OK OrElse response.StatusCode = HttpStatusCode.Accepted Then
                Dim batchResponse As BatchResponse = JsonConvert.DeserializeObject(Of BatchResponse)(responseBody)
                Dim batchId As String = ""
                If batchResponse IsNot Nothing Then
                    batchId = batchResponse.BatchRequestId
                End If
                Return ApiResult(Of String).Ok("Kategori guncelleme talebi gonderildi. Batch ID: " & batchId, batchId)
            Else
                Return ApiResult(Of String).Fail("HTTP " & CInt(response.StatusCode).ToString() & ": " & responseBody, CInt(response.StatusCode))
            End If
        Catch ex As Exception
            Return ApiResult(Of String).Fail(ex.Message)
        End Try
    End Function
    
    ''' <summary>
    ''' Batch durumu kontrolü ve bekleme
    ''' </summary>
    Public Async Function WaitForBatchCompletionAsync(batchRequestId As String, Optional maxWaitSeconds As Integer = 60, Optional pollIntervalSeconds As Integer = 5) As Task(Of ApiResult(Of BatchStatusResponse))
        Dim elapsed As Integer = 0
        
        While elapsed < maxWaitSeconds
            Dim result As ApiResult(Of BatchStatusResponse) = Await GetBatchStatusAsync(batchRequestId)
            
            If Not result.Success Then
                Return result
            End If
            
            If result.Data.Status = "COMPLETED" OrElse result.Data.Status = "FAILED" Then
                Return result
            End If
            
            Await Task.Delay(pollIntervalSeconds * 1000)
            elapsed += pollIntervalSeconds
        End While
        
        Return ApiResult(Of BatchStatusResponse).Fail("Zaman aşımı: Batch tamamlanmadı")
    End Function

#End Region

End Class
