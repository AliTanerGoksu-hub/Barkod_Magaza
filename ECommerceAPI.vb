Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports System.Collections.Generic
Imports System.Linq

Public Class ECommerceAPI
    Private Const BaseUrl As String = "https://www.site.com/api/v2" ' Gerçek URL ile değiştirin
    Private apiKey As String
    Private apiSecret As String

    Public Sub New(key As String, secret As String)
        apiKey = key
        apiSecret = secret
    End Sub

    Private Function SendRequest(method As String, endpoint As String, Optional body As String = "", Optional params As Dictionary(Of String, Object) = Nothing) As String
        Dim query As String = ""
        If params IsNot Nothing Then
            query = "?" & String.Join("&", params.Select(Function(p) p.Key & "=" & Uri.EscapeDataString(p.Value.ToString())))
        End If
        Dim req As HttpWebRequest = WebRequest.Create(BaseUrl & "/" & endpoint & query)
        req.Method = method
        req.Headers.Add("apikey", apiKey)
        req.Headers.Add("apisecret", apiSecret)
        req.ContentType = "application/json"

        If (method = "POST" Or method = "PUT") AndAlso Not String.IsNullOrEmpty(body) Then
            Using sw As New StreamWriter(req.GetRequestStream())
                sw.Write(body)
            End Using
        End If

        Try
            Using resp As HttpWebResponse = req.GetResponse()
                Using sr As New StreamReader(resp.GetResponseStream())
                    Return sr.ReadToEnd()
                End Using
            End Using
        Catch ex As WebException
            Using sr As New StreamReader(ex.Response.GetResponseStream())
                Return sr.ReadToEnd()
            End Using
        End Try
    End Function

    ' 4.1 Erişim Kontrolü
    Public Function Auth() As String
        Return SendRequest("GET", "auth")
    End Function

    ' 4.2 Kategori
    Public Function GetCategories(Optional params As Dictionary(Of String, Object) = Nothing) As String
        Return SendRequest("GET", "category/lists", , params)
    End Function

    Public Function SaveCategory(categoryData As Object) As String
        Dim json As String = JsonConvert.SerializeObject(categoryData)
        Return SendRequest("POST", "category/save", json)
    End Function

    ' 4.3 Müşteriler
    Public Function GetUsers(Optional params As Dictionary(Of String, Object) = Nothing) As String
        Return SendRequest("GET", "user/lists", , params)
    End Function

    Public Function GetUser(userId As Integer) As String
        Return SendRequest("GET", $"user/show/{userId}")
    End Function

    Public Function SaveUser(userData As Object) As String
        Dim json As String = JsonConvert.SerializeObject(userData)
        Return SendRequest("POST", "user/save", json)
    End Function

    Public Function UpdateDealerLimits(dealerId As Integer, limitsData As Object) As String
        Dim json As String = JsonConvert.SerializeObject(limitsData)
        Return SendRequest("POST", $"dealer/limits/{dealerId}", json)
    End Function

    Public Function UpdateUserWallet(walletData As Object) As String
        Dim json As String = JsonConvert.SerializeObject(walletData)
        Return SendRequest("POST", "user/wallet", json)
    End Function

    ' 4.4 Sipariş
    Public Function GetOrders(Optional params As Dictionary(Of String, Object) = Nothing) As String
        Return SendRequest("GET", "order/lists", , params)
    End Function

    Public Function GetOrder(orderId As Integer) As String
        Return SendRequest("GET", $"order/show/{orderId}")
    End Function

    Public Function GetOrderSummary(Optional params As Dictionary(Of String, Object) = Nothing) As String
        Return SendRequest("GET", "order/summary", , params)
    End Function

    Public Function CreateCartUrl(cartData As Object) As String
        Dim json As String = JsonConvert.SerializeObject(cartData)
        Return SendRequest("POST", "order/createCartUrl", json)
    End Function

    Public Function RemoveItemFromOrder(removeData As Object) As String
        Dim json As String = JsonConvert.SerializeObject(removeData)
        Return SendRequest("POST", "order/removeItem", json)
    End Function

    Public Function UpdateOrderStatus(statusData As Object) As String
        Dim json As String = JsonConvert.SerializeObject(statusData)
        Return SendRequest("POST", "order/updateStatus", json)
    End Function

    Public Function UpdateOrderCargo(cargoData As Object) As String
        Dim json As String = JsonConvert.SerializeObject(cargoData)
        Return SendRequest("POST", "order/updateCargo", json)
    End Function

    ' 4.5 Ürün
    Public Function GetProducts(Optional params As Dictionary(Of String, Object) = Nothing) As String
        Return SendRequest("GET", "product/lists", , params)
    End Function

    Public Function SaveProduct(productData As Object) As String
        Dim json As String = JsonConvert.SerializeObject(productData)
        Return SendRequest("POST", "product/save", json)
    End Function

    Public Function UpdateProductStocks(stockData As Object) As String
        Dim json As String = JsonConvert.SerializeObject(stockData)
        Return SendRequest("POST", "product/updateStocks", json)
    End Function

    Public Function UpdateProductPrices(priceData As Object) As String
        Dim json As String = JsonConvert.SerializeObject(priceData)
        Return SendRequest("POST", "product/updatePrices", json)
    End Function

    Public Function UpdateProductCompatibilities(compatData As Object) As String
        Dim json As String = JsonConvert.SerializeObject(compatData)
        Return SendRequest("POST", "product/updateCompatibilities", json)
    End Function

    Public Function UpdateProductCombines(combineData As Object) As String
        Dim json As String = JsonConvert.SerializeObject(combineData)
        Return SendRequest("POST", "product/updateCombines", json)
    End Function

    Public Function GetProductCombines(Optional params As Dictionary(Of String, Object) = Nothing) As String
        Return SendRequest("GET", "product/combines", , params)
    End Function

    Public Function UpdateProductSimilar(similarData As Object) As String
        Dim json As String = JsonConvert.SerializeObject(similarData)
        Return SendRequest("POST", "product/updateSimilar", json)
    End Function

    ' 4.6 Nitelikler
    Public Function GetAttributes(Optional params As Dictionary(Of String, Object) = Nothing) As String
        Return SendRequest("GET", "attribute/lists", , params)
    End Function

    Public Function SaveAttribute(attrData As Object) As String
        Dim json As String = JsonConvert.SerializeObject(attrData)
        Return SendRequest("POST", "attribute/save", json)
    End Function

    Public Function GetAttributeValues(Optional params As Dictionary(Of String, Object) = Nothing) As String
        Return SendRequest("GET", "attribute/values", , params)
    End Function

    Public Function SaveAttributeValue(valData As Object) As String
        Dim json As String = JsonConvert.SerializeObject(valData)
        Return SendRequest("POST", "attribute/saveValue", json)
    End Function

    ' 4.12 Uyumluluklar
    Public Function GetCompatibilityGroups(Optional params As Dictionary(Of String, Object) = Nothing) As String
        Return SendRequest("GET", "compatibility/lists", , params)
    End Function

    Public Function GetCompatibilityValues(Optional params As Dictionary(Of String, Object) = Nothing) As String
        Return SendRequest("GET", "compatibility/values", , params)
    End Function

    Public Function SaveCompatibility(compatData As Object) As String
        Dim json As String = JsonConvert.SerializeObject(compatData)
        Return SendRequest("POST", "compatibility/save", json)
    End Function

    ' 4.13 Döviz Kurları
    Public Function GetCurrencies() As String
        Return SendRequest("GET", "others/currencies")
    End Function

    ' 4.14 Hediye Çekleri
    Public Function GetVouchers(Optional params As Dictionary(Of String, Object) = Nothing) As String
        Return SendRequest("GET", "voucher/lists", , params)
    End Function

    Public Function SaveVoucher(voucherData As Object) As String
        Dim json As String = JsonConvert.SerializeObject(voucherData)
        Return SendRequest("POST", "voucher/save", json)
    End Function

    Public Function DeleteVoucher(voucherId As Integer) As String
        Return SendRequest("POST", $"voucher/delete/{voucherId}")
    End Function

    ' 4.15 İadeler
    Public Function GetReturns(Optional params As Dictionary(Of String, Object) = Nothing) As String
        Return SendRequest("GET", "return/lists", , params)
    End Function

    ' Ek bölümler (dokümandan kalanlar, truncated kısımlar varsayım ile tamamlandı)
    Public Function GetFastPayments(Optional params As Dictionary(Of String, Object) = Nothing) As String
        Return SendRequest("GET", "fast-payment/lists", , params)
    End Function

    Public Function GetSpecialFields(Optional params As Dictionary(Of String, Object) = Nothing) As String
        Return SendRequest("GET", "special-field/lists", , params)
    End Function

    Public Function GetUnits(Optional params As Dictionary(Of String, Object) = Nothing) As String
        Return SendRequest("GET", "unit/lists", , params)
    End Function
    'Burası yeni eklendi    Public Sub SendProductsToAPI()
    Public Sub SendProductsToAPI()
        Dim apiKey As String = ""
        Dim apiSecret As String = ""
        Dim conn As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand

        ' Bağlantıyı yapılandır
        conn.ConnectionString = connection ' Sizin belirttiğiniz connection değişkeni
        cmd.CommandTimeout = 0
        adapter.SelectCommand = cmd
        cmd.Connection = conn

        Try
            conn.Open()

            ' tbParamgenel tablosundan API key ve secret'ı çek
            cmd.CommandText = "SELECT ApiKey, ApiSecret FROM tbParamgenel"
            Dim readerParams As OleDb.OleDbDataReader = cmd.ExecuteReader()
            If readerParams.Read() Then
                apiKey = readerParams("ApiKey").ToString()
                apiSecret = readerParams("ApiSecret").ToString()
            Else
                Throw New Exception("API key veya secret bulunamadı.")
            End If
            readerParams.Close()

            ' API nesnesini başlat
            Dim api As New ECommerceAPI(apiKey, apiSecret)

            ' Ürünleri çek
            cmd.CommandText = "SELECT StokKodu, Aciklama, Barkod, Fiyat, Renk, Beden, StokMevcudu FROM Urunler"
            Dim readerProducts As OleDb.OleDbDataReader = cmd.ExecuteReader()

            Dim products As New List(Of Dictionary(Of String, Object)) ' Birden fazla ürün için liste
            While readerProducts.Read()
                Dim product As New Dictionary(Of String, Object) From {
                {"code", readerProducts("StokKodu").ToString()},
                {"name", readerProducts("Aciklama").ToString()},
                {"barcode", readerProducts("Barkod").ToString()},
                {"salePrice", Convert.ToDouble(readerProducts("Fiyat"))},
                {"taxRate", 18}, ' Varsayılan KDV oranı
                {"currency", "TL"}, ' Varsayılan para birimi
                {"quantity", Convert.ToInt32(readerProducts("StokMevcudu"))},
                {"variants", New List(Of Object) From {
                    New Dictionary(Of String, Object) From {
                        {"value1", readerProducts("Renk").ToString()},
                        {"value2", readerProducts("Beden").ToString()},
                        {"barcode", readerProducts("Barkod").ToString() & "V"}, ' Varyant için benzersiz barkod
                        {"quantity", Convert.ToInt32(readerProducts("StokMevcudu"))},
                        {"priceStatus", 0},
                        {"price", 0}
                    }
                }}
            }
                products.Add(product)
            End While
            readerProducts.Close()

            ' Ürünleri API'ye gönder
            Dim productData As New Dictionary(Of String, Object) From {{"products", products}}
            Dim response = api.SaveProduct(productData)
            ' Yanıtı logla veya kontrol et
            Console.WriteLine(response)

            ' Yanıt kontrolü
            If response.Contains("SUCCESS") Then
                Console.WriteLine("Ürünler başarıyla gönderildi.")
            Else
                Console.WriteLine("Hata: " & response)
            End If

        Catch ex As Exception
            Console.WriteLine("Hata oluştu: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub
End Class