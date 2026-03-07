' ============================================================================
' PAZARYERI API HELPER
' Dosya: PazaryeriAPIHelper.vb
' Aciklama: Trendyol, Hepsiburada ve diger pazaryeri API entegrasyonlari
' ============================================================================

Imports System.Net
Imports System.Net.Http
Imports System.Text
Imports System.IO
Imports System.Data.OleDb
Imports System.Collections.Generic
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class PazaryeriAPIHelper
    
    Private Shared _connection As String = ""
    Private Shared _httpClient As HttpClient
    
    Shared Sub New()
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls
        _httpClient = New HttpClient()
        _httpClient.Timeout = TimeSpan.FromSeconds(30)
    End Sub
    
    Public Shared Property Connection As String
        Get
            If String.IsNullOrEmpty(_connection) Then
                _connection = KeyCode.connection
            End If
            Return _connection
        End Get
        Set(value As String)
            _connection = value
        End Set
    End Property
    
    ''' <summary>
    ''' E-Ticaret Sınıf Eşleme ayarını okur (tbSistemAyar tablosundan)
    ''' </summary>
    Private Shared Function GetSinifEslemeAyar(conn As OleDb.OleDbConnection, ayarKodu As String, varsayilan As String) As String
        Try
            Using cmd As New OleDb.OleDbCommand($"SELECT sAyarDeger FROM tbSistemAyar WHERE sAyarKodu = '{ayarKodu}'", conn)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso result IsNot DBNull.Value AndAlso Not String.IsNullOrEmpty(result.ToString()) Then
                    Return result.ToString()
                End If
            End Using
        Catch
        End Try
        Return varsayilan
    End Function
    
#Region "API Ayarlari Okuma"
    
    ''' <summary>
    ''' Veritabanindan pazaryeri API ayarlarini okur
    ''' </summary>
    Public Shared Function GetAPISettings(pazaryeri As String) As PazaryeriAPISettings
        Dim settings As New PazaryeriAPISettings()
        settings.Pazaryeri = pazaryeri
        
        Try
            If String.IsNullOrEmpty(Connection) Then Return settings
            
            Using con As New OleDbConnection(Connection)
                con.Open()
                
                Dim sql As String = "SELECT sSellerId, sApiKey, sApiSecret, sBaseUrl FROM tbPazaryeriAyar WHERE sPazaryeri = ?"
                Using cmd As New OleDbCommand(sql, con)
                    cmd.Parameters.AddWithValue("@p", pazaryeri)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            settings.SellerId = If(IsDBNull(reader("sSellerId")), "", reader("sSellerId").ToString())
                            settings.ApiKey = If(IsDBNull(reader("sApiKey")), "", reader("sApiKey").ToString())
                            settings.ApiSecret = If(IsDBNull(reader("sApiSecret")), "", reader("sApiSecret").ToString())
                            settings.BaseUrl = If(IsDBNull(reader("sBaseUrl")), "", reader("sBaseUrl").ToString())
                            settings.IsConfigured = Not String.IsNullOrEmpty(settings.ApiKey)
                        End If
                    End Using
                End Using
            End Using
            
        Catch ex As Exception
            EticaretLogger.LogError($"API ayarlari okuma hatasi: {pazaryeri}", ex)
        End Try
        
        Return settings
    End Function
    
#End Region

#Region "Trendyol API"
    
    ''' <summary>
    ''' Trendyol'dan urun bilgilerini ve rakip fiyatlarini ceker
    ''' </summary>
    Public Shared Function GetTrendyolProductInfo(barcode As String) As TrendyolProductInfo
        Dim result As New TrendyolProductInfo()
        result.Barcode = barcode
        
        Try
            Dim settings = GetAPISettings("Trendyol")
            If Not settings.IsConfigured Then
                EticaretLogger.LogWarning("Trendyol API ayarlari yapilmamis")
                Return result
            End If
            
            ' Trendyol API endpoint
            Dim url As String = $"{settings.BaseUrl}/suppliers/{settings.SellerId}/products?barcode={barcode}"
            
            ' Authorization header
            Dim authString As String = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{settings.ApiKey}:{settings.ApiSecret}"))
            
            Using request As New HttpRequestMessage(HttpMethod.Get, url)
                request.Headers.Add("Authorization", $"Basic {authString}")
                request.Headers.Add("User-Agent", settings.SellerId)
                
                Dim response = _httpClient.SendAsync(request).Result
                
                If response.IsSuccessStatusCode Then
                    Dim json = response.Content.ReadAsStringAsync().Result
                    EticaretLogger.LogTrendyol("GetProductInfo", $"Barcode: {barcode}, Response: {json.Substring(0, Math.Min(500, json.Length))}")
                    
                    Dim data = JObject.Parse(json)
                    Dim content = data("content")
                    
                    If content IsNot Nothing AndAlso content.HasValues Then
                        Dim product = content(0)
                        result.ProductId = product("id")?.ToString()
                        result.Title = product("title")?.ToString()
                        result.ListPrice = If(product("listPrice") IsNot Nothing, CDec(product("listPrice")), 0)
                        result.SalePrice = If(product("salePrice") IsNot Nothing, CDec(product("salePrice")), 0)
                        result.Quantity = If(product("quantity") IsNot Nothing, CInt(product("quantity")), 0)
                        result.Success = True
                    End If
                Else
                    EticaretLogger.LogError($"Trendyol API hatasi: {response.StatusCode}", Nothing)
                End If
            End Using
            
        Catch ex As Exception
            EticaretLogger.LogError($"Trendyol GetProductInfo hatasi: {barcode}", ex)
        End Try
        
        Return result
    End Function
    
    ''' <summary>
    ''' Trendyol'dan siparis listesini ceker
    ''' </summary>
    Public Shared Function GetTrendyolOrders(Optional startDate As DateTime = Nothing, Optional endDate As DateTime = Nothing) As List(Of TrendyolOrder)
        Dim orders As New List(Of TrendyolOrder)
        
        Try
            Dim settings = GetAPISettings("Trendyol")
            If Not settings.IsConfigured Then
                EticaretLogger.LogWarning("Trendyol API ayarlari yapilmamis")
                Return orders
            End If
            
            If startDate = Nothing Then startDate = DateTime.Now.AddDays(-7)
            If endDate = Nothing Then endDate = DateTime.Now
            
            Dim startMillis As Long = CLng((startDate - New DateTime(1970, 1, 1)).TotalMilliseconds)
            Dim endMillis As Long = CLng((endDate - New DateTime(1970, 1, 1)).TotalMilliseconds)
            
            Dim url As String = $"{settings.BaseUrl}/suppliers/{settings.SellerId}/orders?startDate={startMillis}&endDate={endMillis}&size=200"
            
            Dim authString As String = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{settings.ApiKey}:{settings.ApiSecret}"))
            
            Using request As New HttpRequestMessage(HttpMethod.Get, url)
                request.Headers.Add("Authorization", $"Basic {authString}")
                request.Headers.Add("User-Agent", settings.SellerId)
                
                Dim response = _httpClient.SendAsync(request).Result
                
                If response.IsSuccessStatusCode Then
                    Dim json = response.Content.ReadAsStringAsync().Result
                    EticaretLogger.LogTrendyol("GetOrders", $"Response length: {json.Length}")
                    
                    Dim data As JObject = JObject.Parse(json)
                    Dim content As JToken = data("content")
                    
                    If content IsNot Nothing Then
                        For Each orderJson As JToken In content
                            Dim order As New TrendyolOrder()
                            order.OrderNumber = If(orderJson("orderNumber") IsNot Nothing, orderJson("orderNumber").ToString(), "")
                            order.OrderDate = DateTime.Now
                            order.Status = If(orderJson("status") IsNot Nothing, orderJson("status").ToString(), "")
                            order.TotalPrice = If(orderJson("totalPrice") IsNot Nothing, CDec(orderJson("totalPrice")), 0)
                            
                            Dim lines As JToken = orderJson("lines")
                            If lines IsNot Nothing Then
                                For Each line As JToken In lines
                                    Dim orderLine As New TrendyolOrderLine()
                                    orderLine.Barcode = If(line("barcode") IsNot Nothing, line("barcode").ToString(), "")
                                    orderLine.ProductName = If(line("productName") IsNot Nothing, line("productName").ToString(), "")
                                    orderLine.Quantity = If(line("quantity") IsNot Nothing, CInt(line("quantity")), 0)
                                    orderLine.Price = If(line("price") IsNot Nothing, CDec(line("price")), 0)
                                    order.Lines.Add(orderLine)
                                Next
                            End If
                            
                            orders.Add(order)
                        Next
                    End If
                Else
                    EticaretLogger.LogError($"Trendyol Orders API hatasi: {response.StatusCode}", Nothing)
                End If
            End Using
            
        Catch ex As Exception
            EticaretLogger.LogError("Trendyol GetOrders hatasi", ex)
        End Try
        
        Return orders
    End Function
    
    ''' <summary>
    ''' Trendyol'dan iade edilmiş siparişleri çeker
    ''' Status: Cancelled, UnDelivered, Returned
    ''' </summary>
    Public Shared Function GetTrendyolReturnedOrders(Optional startDate As DateTime = Nothing, Optional endDate As DateTime = Nothing) As List(Of TrendyolOrder)
        Dim returnedOrders As New List(Of TrendyolOrder)
        
        Try
            Dim settings = GetAPISettings("Trendyol")
            If Not settings.IsConfigured Then
                EticaretLogger.LogWarning("Trendyol API ayarlari yapilmamis")
                Return returnedOrders
            End If
            
            If startDate = Nothing Then startDate = DateTime.Now.AddDays(-90)
            If endDate = Nothing Then endDate = DateTime.Now
            
            Dim startMillis As Long = CLng((startDate - New DateTime(1970, 1, 1)).TotalMilliseconds)
            Dim endMillis As Long = CLng((endDate - New DateTime(1970, 1, 1)).TotalMilliseconds)
            
            ' İade durumundaki siparişleri çek (status: Cancelled, UnDelivered, Returned)
            Dim statusList As String() = {"Cancelled", "UnDelivered", "Returned"}
            
            For Each status As String In statusList
                Try
                    Dim url As String = $"{settings.BaseUrl}/suppliers/{settings.SellerId}/orders?startDate={startMillis}&endDate={endMillis}&status={status}&size=200"
                    
                    Dim authString As String = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{settings.ApiKey}:{settings.ApiSecret}"))
                    
                    Using request As New HttpRequestMessage(HttpMethod.Get, url)
                        request.Headers.Add("Authorization", $"Basic {authString}")
                        request.Headers.Add("User-Agent", settings.SellerId)
                        
                        Dim response = _httpClient.SendAsync(request).Result
                        
                        If response.IsSuccessStatusCode Then
                            Dim json = response.Content.ReadAsStringAsync().Result
                            EticaretLogger.LogTrendyol("GetReturnedOrders", $"Status: {status}, Response length: {json.Length}")
                            
                            Dim data As JObject = JObject.Parse(json)
                            Dim content As JToken = data("content")
                            
                            If content IsNot Nothing Then
                                For Each orderJson As JToken In content
                                    Dim order As New TrendyolOrder()
                                    order.OrderNumber = If(orderJson("orderNumber") IsNot Nothing, orderJson("orderNumber").ToString(), "")
                                    order.OrderDate = DateTime.Now
                                    order.Status = status
                                    order.TotalPrice = If(orderJson("totalPrice") IsNot Nothing, CDec(orderJson("totalPrice")), 0)
                                    
                                    Dim lines As JToken = orderJson("lines")
                                    If lines IsNot Nothing Then
                                        For Each line As JToken In lines
                                            Dim orderLine As New TrendyolOrderLine()
                                            orderLine.Barcode = If(line("barcode") IsNot Nothing, line("barcode").ToString(), "")
                                            orderLine.ProductName = If(line("productName") IsNot Nothing, line("productName").ToString(), "")
                                            orderLine.Quantity = If(line("quantity") IsNot Nothing, CInt(line("quantity")), 0)
                                            orderLine.Price = If(line("price") IsNot Nothing, CDec(line("price")), 0)
                                            order.Lines.Add(orderLine)
                                        Next
                                    End If
                                    
                                    returnedOrders.Add(order)
                                Next
                            End If
                        End If
                    End Using
                Catch statusEx As Exception
                    EticaretLogger.LogError($"Trendyol GetReturnedOrders hatasi (status: {status})", statusEx)
                End Try
            Next
            
            EticaretLogger.LogInfo($"Trendyol'dan {returnedOrders.Count} iade siparişi çekildi")
            
        Catch ex As Exception
            EticaretLogger.LogError("Trendyol GetReturnedOrders hatasi", ex)
        End Try
        
        Return returnedOrders
    End Function
    
    ''' <summary>
    ''' Barkod bazında iade istatistiklerini hesaplar
    ''' </summary>
    Public Shared Function GetIadeIstatistikleri(startDate As DateTime, endDate As DateTime) As Dictionary(Of String, IadeIstatistik)
        Dim istatistikler As New Dictionary(Of String, IadeIstatistik)
        
        Try
            ' Trendyol iade siparişlerini çek
            Dim iadeOrders = GetTrendyolReturnedOrders(startDate, endDate)
            
            ' Tüm siparişleri çek (satış sayısı için)
            Dim tumOrders = GetTrendyolOrders(startDate, endDate)
            
            ' Barkod bazında satış sayısını hesapla
            Dim satisSayilari As New Dictionary(Of String, Integer)
            For Each order As TrendyolOrder In tumOrders
                For Each line As TrendyolOrderLine In order.Lines
                    If Not String.IsNullOrEmpty(line.Barcode) Then
                        If satisSayilari.ContainsKey(line.Barcode) Then
                            satisSayilari(line.Barcode) += line.Quantity
                        Else
                            satisSayilari.Add(line.Barcode, line.Quantity)
                        End If
                    End If
                Next
            Next
            
            ' Barkod bazında iade sayısını hesapla
            For Each order As TrendyolOrder In iadeOrders
                For Each line As TrendyolOrderLine In order.Lines
                    If Not String.IsNullOrEmpty(line.Barcode) Then
                        If Not istatistikler.ContainsKey(line.Barcode) Then
                            Dim ist As New IadeIstatistik()
                            ist.Barkod = line.Barcode
                            ist.UrunAdi = line.ProductName
                            ist.ToplamSatis = If(satisSayilari.ContainsKey(line.Barcode), satisSayilari(line.Barcode), 0)
                            istatistikler.Add(line.Barcode, ist)
                        End If
                        
                        istatistikler(line.Barcode).ToplamIade += line.Quantity
                        
                        ' İade nedenini kaydet
                        If order.Status = "Cancelled" Then
                            istatistikler(line.Barcode).IptalSayisi += line.Quantity
                        ElseIf order.Status = "Returned" Then
                            istatistikler(line.Barcode).IadeSayisi += line.Quantity
                        ElseIf order.Status = "UnDelivered" Then
                            istatistikler(line.Barcode).TeslimEdilemedi += line.Quantity
                        End If
                    End If
                Next
            Next
            
            ' İade oranlarını hesapla
            For Each kvp As KeyValuePair(Of String, IadeIstatistik) In istatistikler
                Dim ist As IadeIstatistik = kvp.Value
                If ist.ToplamSatis > 0 Then
                    ist.IadeOrani = Math.Round(CDec(ist.ToplamIade) / CDec(ist.ToplamSatis) * 100, 2)
                End If
            Next
            
            EticaretLogger.LogInfo($"İade istatistikleri hesaplandı: {istatistikler.Count} ürün")
            
        Catch ex As Exception
            EticaretLogger.LogError("GetIadeIstatistikleri hatasi", ex)
        End Try
        
        Return istatistikler
    End Function
    
#End Region

#Region "Merkezi E-Ticaret Analiz Cache Sistemi"
    
    ' Cache süresi (saat cinsinden) - Tüm formlar için geçerli
    Private Shared ReadOnly CACHE_SURESI_SAAT As Integer = 6
    
    ''' <summary>
    ''' Ana analiz cache tablosunu oluşturur (yoksa)
    ''' Tüm formların ihtiyaç duyduğu verileri tek tabloda tutar
    ''' </summary>
    Public Shared Sub EnsureETicaretAnalizTable(conn As OleDb.OleDbConnection)
        Try
            ' Ana analiz tablosu
            Dim createTableSql As String = "
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbETicaretAnaliz')
                BEGIN
                    CREATE TABLE tbETicaretAnaliz (
                        nID INT IDENTITY(1,1) PRIMARY KEY,
                        nStokID INT,
                        sBarkod NVARCHAR(50) NOT NULL,
                        sStokKodu NVARCHAR(50),
                        sModel NVARCHAR(100),
                        sUrunAdi NVARCHAR(500),
                        sRenk NVARCHAR(50),
                        sBeden NVARCHAR(50),
                        sKategori NVARCHAR(200),
                        sPazaryeri NVARCHAR(50) DEFAULT 'Trendyol',
                        
                        dBizimFiyat DECIMAL(18,2) DEFAULT 0,
                        dEnDusukRakipFiyat DECIMAL(18,2) DEFAULT 0,
                        dOrtalamaRakipFiyat DECIMAL(18,2) DEFAULT 0,
                        iRakipSayisi INT DEFAULT 0,
                        dFiyatFarki DECIMAL(18,2) DEFAULT 0,
                        fFiyatFarkYuzde DECIMAL(5,2) DEFAULT 0,
                        
                        iSatis7Gun INT DEFAULT 0,
                        iSatis30Gun INT DEFAULT 0,
                        iSatis90Gun INT DEFAULT 0,
                        dSatisTutari30Gun DECIMAL(18,2) DEFAULT 0,
                        
                        iIadeSayisi INT DEFAULT 0,
                        iIptalSayisi INT DEFAULT 0,
                        iTeslimEdilemedi INT DEFAULT 0,
                        iToplamIade INT DEFAULT 0,
                        fIadeOrani DECIMAL(5,2) DEFAULT 0,
                        
                        iYorumSayisi INT DEFAULT 0,
                        fOrtalamaPuan DECIMAL(3,1) DEFAULT 0,
                        iPozitifYorum INT DEFAULT 0,
                        iNegatifYorum INT DEFAULT 0,
                        iNotrYorum INT DEFAULT 0,
                        sSikSikayet NVARCHAR(200),
                        sSikOvergu NVARCHAR(200),
                        
                        iGoruntulenmeSayisi INT DEFAULT 0,
                        iFavoriSayisi INT DEFAULT 0,
                        iSepetSayisi INT DEFAULT 0,
                        fFavoriOrani DECIMAL(5,2) DEFAULT 0,
                        fSepetOrani DECIMAL(5,2) DEFAULT 0,
                        fDonusumOrani DECIMAL(5,2) DEFAULT 0,
                        
                        iStokMiktari INT DEFAULT 0,
                        bStokVar BIT DEFAULT 1,
                        
                        sContentId NVARCHAR(50),
                        dteSonGuncelleme DATETIME DEFAULT GETDATE()
                    )
                    
                    CREATE INDEX IX_ETicaretAnaliz_Barkod ON tbETicaretAnaliz (sBarkod)
                    CREATE INDEX IX_ETicaretAnaliz_StokID ON tbETicaretAnaliz (nStokID)
                    CREATE INDEX IX_ETicaretAnaliz_Pazaryeri ON tbETicaretAnaliz (sPazaryeri)
                END"
            
            Using cmd As New OleDb.OleDbCommand(createTableSql, conn)
                cmd.ExecuteNonQuery()
            End Using
            
            ' Rakip detay tablosu
            Dim createRakipTableSql As String = "
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbETicaretRakipDetay')
                BEGIN
                    CREATE TABLE tbETicaretRakipDetay (
                        nID INT IDENTITY(1,1) PRIMARY KEY,
                        sBarkod NVARCHAR(50) NOT NULL,
                        sRakipMagaza NVARCHAR(200),
                        sMagazaId NVARCHAR(50),
                        dFiyat DECIMAL(18,2) DEFAULT 0,
                        dIndirimiFiyat DECIMAL(18,2) DEFAULT 0,
                        dKargoUcreti DECIMAL(18,2) DEFAULT 0,
                        fPuan DECIMAL(3,1) DEFAULT 0,
                        iYorumSayisi INT DEFAULT 0,
                        bStokVar BIT DEFAULT 1,
                        bAnaSatici BIT DEFAULT 0,
                        dteSonGuncelleme DATETIME DEFAULT GETDATE()
                    )
                    
                    CREATE INDEX IX_RakipDetay_Barkod ON tbETicaretRakipDetay (sBarkod)
                END"
            
            Using cmd As New OleDb.OleDbCommand(createRakipTableSql, conn)
                cmd.ExecuteNonQuery()
            End Using
            
            EticaretLogger.LogInfo("tbETicaretAnaliz ve tbETicaretRakipDetay tabloları kontrol edildi")
            
        Catch ex As Exception
            EticaretLogger.LogError("EnsureETicaretAnalizTable hatası", ex)
            Throw ' Hatayı yukarı fırlat ki çağıran görsün
        End Try
    End Sub
    
    ''' <summary>
    ''' Cache'in güncel olup olmadığını kontrol eder
    ''' </summary>
    Public Shared Function IsCacheValid(barkod As String, conn As OleDb.OleDbConnection) As Boolean
        Try
            Dim cacheSuresiDakika As Integer = CACHE_SURESI_SAAT * 60
            
            Dim sql As String = "SELECT COUNT(*) FROM tbETicaretAnaliz 
                WHERE sBarkod = ? AND DATEDIFF(minute, dteSonGuncelleme, GETDATE()) < ?"
            
            Using cmd As New OleDb.OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("?", barkod)
                cmd.Parameters.AddWithValue("?", cacheSuresiDakika)
                Return CInt(cmd.ExecuteScalar()) > 0
            End Using
        Catch
            Return False
        End Try
    End Function
    
    ''' <summary>
    ''' Cache'den analiz verisini okur
    ''' </summary>
    Public Shared Function GetAnalizFromCache(barkod As String, conn As OleDb.OleDbConnection) As ETicaretAnalizData
        Dim data As ETicaretAnalizData = Nothing
        
        Try
            Dim sql As String = "SELECT * FROM tbETicaretAnaliz WHERE sBarkod = ?"
            
            Using cmd As New OleDb.OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("?", barkod)
                
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        data = New ETicaretAnalizData()
                        data.nStokID = If(IsDBNull(reader("nStokID")), 0, CInt(reader("nStokID")))
                        data.Barkod = barkod
                        data.StokKodu = If(IsDBNull(reader("sStokKodu")), "", reader("sStokKodu").ToString())
                        data.Model = If(IsDBNull(reader("sModel")), "", reader("sModel").ToString())
                        data.UrunAdi = If(IsDBNull(reader("sUrunAdi")), "", reader("sUrunAdi").ToString())
                        data.Renk = If(IsDBNull(reader("sRenk")), "", reader("sRenk").ToString())
                        data.Beden = If(IsDBNull(reader("sBeden")), "", reader("sBeden").ToString())
                        data.Kategori = If(IsDBNull(reader("sKategori")), "", reader("sKategori").ToString())
                        data.Pazaryeri = If(IsDBNull(reader("sPazaryeri")), "Trendyol", reader("sPazaryeri").ToString())
                        
                        ' Fiyat
                        data.BizimFiyat = If(IsDBNull(reader("dBizimFiyat")), 0D, CDec(reader("dBizimFiyat")))
                        data.EnDusukRakipFiyat = If(IsDBNull(reader("dEnDusukRakipFiyat")), 0D, CDec(reader("dEnDusukRakipFiyat")))
                        data.OrtalamaRakipFiyat = If(IsDBNull(reader("dOrtalamaRakipFiyat")), 0D, CDec(reader("dOrtalamaRakipFiyat")))
                        data.RakipSayisi = If(IsDBNull(reader("iRakipSayisi")), 0, CInt(reader("iRakipSayisi")))
                        data.FiyatFarki = If(IsDBNull(reader("dFiyatFarki")), 0D, CDec(reader("dFiyatFarki")))
                        data.FiyatFarkYuzde = If(IsDBNull(reader("fFiyatFarkYuzde")), 0D, CDec(reader("fFiyatFarkYuzde")))
                        
                        ' Satış
                        data.Satis7Gun = If(IsDBNull(reader("iSatis7Gun")), 0, CInt(reader("iSatis7Gun")))
                        data.Satis30Gun = If(IsDBNull(reader("iSatis30Gun")), 0, CInt(reader("iSatis30Gun")))
                        data.Satis90Gun = If(IsDBNull(reader("iSatis90Gun")), 0, CInt(reader("iSatis90Gun")))
                        data.SatisTutari30Gun = If(IsDBNull(reader("dSatisTutari30Gun")), 0D, CDec(reader("dSatisTutari30Gun")))
                        
                        ' İade
                        data.IadeSayisi = If(IsDBNull(reader("iIadeSayisi")), 0, CInt(reader("iIadeSayisi")))
                        data.IptalSayisi = If(IsDBNull(reader("iIptalSayisi")), 0, CInt(reader("iIptalSayisi")))
                        data.TeslimEdilemedi = If(IsDBNull(reader("iTeslimEdilemedi")), 0, CInt(reader("iTeslimEdilemedi")))
                        data.ToplamIade = If(IsDBNull(reader("iToplamIade")), 0, CInt(reader("iToplamIade")))
                        data.IadeOrani = If(IsDBNull(reader("fIadeOrani")), 0D, CDec(reader("fIadeOrani")))
                        
                        ' Yorum
                        data.YorumSayisi = If(IsDBNull(reader("iYorumSayisi")), 0, CInt(reader("iYorumSayisi")))
                        data.OrtalamaPuan = If(IsDBNull(reader("fOrtalamaPuan")), 0D, CDec(reader("fOrtalamaPuan")))
                        data.PozitifYorum = If(IsDBNull(reader("iPozitifYorum")), 0, CInt(reader("iPozitifYorum")))
                        data.NegatifYorum = If(IsDBNull(reader("iNegatifYorum")), 0, CInt(reader("iNegatifYorum")))
                        data.NotrYorum = If(IsDBNull(reader("iNotrYorum")), 0, CInt(reader("iNotrYorum")))
                        data.SikSikayet = If(IsDBNull(reader("sSikSikayet")), "", reader("sSikSikayet").ToString())
                        data.SikOvergu = If(IsDBNull(reader("sSikOvergu")), "", reader("sSikOvergu").ToString())
                        
                        ' Favori/Sepet
                        data.GoruntulenmeSayisi = If(IsDBNull(reader("iGoruntulenmeSayisi")), 0, CInt(reader("iGoruntulenmeSayisi")))
                        data.FavoriSayisi = If(IsDBNull(reader("iFavoriSayisi")), 0, CInt(reader("iFavoriSayisi")))
                        data.SepetSayisi = If(IsDBNull(reader("iSepetSayisi")), 0, CInt(reader("iSepetSayisi")))
                        data.FavoriOrani = If(IsDBNull(reader("fFavoriOrani")), 0D, CDec(reader("fFavoriOrani")))
                        data.SepetOrani = If(IsDBNull(reader("fSepetOrani")), 0D, CDec(reader("fSepetOrani")))
                        data.DonusumOrani = If(IsDBNull(reader("fDonusumOrani")), 0D, CDec(reader("fDonusumOrani")))
                        
                        ' Stok
                        data.StokMiktari = If(IsDBNull(reader("iStokMiktari")), 0, CInt(reader("iStokMiktari")))
                        data.StokVar = If(IsDBNull(reader("bStokVar")), True, CBool(reader("bStokVar")))
                        
                        data.ContentId = If(IsDBNull(reader("sContentId")), "", reader("sContentId").ToString())
                        data.SonGuncelleme = If(IsDBNull(reader("dteSonGuncelleme")), DateTime.MinValue, CDate(reader("dteSonGuncelleme")))
                    End If
                End Using
            End Using
        Catch ex As Exception
            EticaretLogger.LogError($"GetAnalizFromCache hatası: {barkod}", ex)
        End Try
        
        Return data
    End Function
    
    ''' <summary>
    ''' Analiz verisini cache'e kaydeder
    ''' </summary>
    Public Shared Sub SaveAnalizToCache(data As ETicaretAnalizData, conn As OleDb.OleDbConnection)
        Try
            ' Önce eski kaydı sil
            Using deleteCmd As New OleDb.OleDbCommand("DELETE FROM tbETicaretAnaliz WHERE sBarkod = ?", conn)
                deleteCmd.Parameters.AddWithValue("?", data.Barkod)
                deleteCmd.ExecuteNonQuery()
            End Using
            
            ' Yeni kaydı ekle
            Dim insertSql As String = "INSERT INTO tbETicaretAnaliz 
                (nStokID, sBarkod, sStokKodu, sModel, sUrunAdi, sRenk, sBeden, sKategori, sPazaryeri,
                dBizimFiyat, dEnDusukRakipFiyat, dOrtalamaRakipFiyat, iRakipSayisi, dFiyatFarki, fFiyatFarkYuzde,
                iSatis7Gun, iSatis30Gun, iSatis90Gun, dSatisTutari30Gun,
                iIadeSayisi, iIptalSayisi, iTeslimEdilemedi, iToplamIade, fIadeOrani,
                iYorumSayisi, fOrtalamaPuan, iPozitifYorum, iNegatifYorum, iNotrYorum, sSikSikayet, sSikOvergu,
                iGoruntulenmeSayisi, iFavoriSayisi, iSepetSayisi, fFavoriOrani, fSepetOrani, fDonusumOrani,
                iStokMiktari, bStokVar, sContentId, dteSonGuncelleme)
                VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,GETDATE())"
            
            Using cmd As New OleDb.OleDbCommand(insertSql, conn)
                cmd.Parameters.AddWithValue("?", data.nStokID)
                cmd.Parameters.AddWithValue("?", data.Barkod)
                cmd.Parameters.AddWithValue("?", data.StokKodu)
                cmd.Parameters.AddWithValue("?", data.Model)
                cmd.Parameters.AddWithValue("?", data.UrunAdi)
                cmd.Parameters.AddWithValue("?", data.Renk)
                cmd.Parameters.AddWithValue("?", data.Beden)
                cmd.Parameters.AddWithValue("?", data.Kategori)
                cmd.Parameters.AddWithValue("?", data.Pazaryeri)
                cmd.Parameters.AddWithValue("?", data.BizimFiyat)
                cmd.Parameters.AddWithValue("?", data.EnDusukRakipFiyat)
                cmd.Parameters.AddWithValue("?", data.OrtalamaRakipFiyat)
                cmd.Parameters.AddWithValue("?", data.RakipSayisi)
                cmd.Parameters.AddWithValue("?", data.FiyatFarki)
                cmd.Parameters.AddWithValue("?", data.FiyatFarkYuzde)
                cmd.Parameters.AddWithValue("?", data.Satis7Gun)
                cmd.Parameters.AddWithValue("?", data.Satis30Gun)
                cmd.Parameters.AddWithValue("?", data.Satis90Gun)
                cmd.Parameters.AddWithValue("?", data.SatisTutari30Gun)
                cmd.Parameters.AddWithValue("?", data.IadeSayisi)
                cmd.Parameters.AddWithValue("?", data.IptalSayisi)
                cmd.Parameters.AddWithValue("?", data.TeslimEdilemedi)
                cmd.Parameters.AddWithValue("?", data.ToplamIade)
                cmd.Parameters.AddWithValue("?", data.IadeOrani)
                cmd.Parameters.AddWithValue("?", data.YorumSayisi)
                cmd.Parameters.AddWithValue("?", data.OrtalamaPuan)
                cmd.Parameters.AddWithValue("?", data.PozitifYorum)
                cmd.Parameters.AddWithValue("?", data.NegatifYorum)
                cmd.Parameters.AddWithValue("?", data.NotrYorum)
                cmd.Parameters.AddWithValue("?", data.SikSikayet)
                cmd.Parameters.AddWithValue("?", data.SikOvergu)
                cmd.Parameters.AddWithValue("?", data.GoruntulenmeSayisi)
                cmd.Parameters.AddWithValue("?", data.FavoriSayisi)
                cmd.Parameters.AddWithValue("?", data.SepetSayisi)
                cmd.Parameters.AddWithValue("?", data.FavoriOrani)
                cmd.Parameters.AddWithValue("?", data.SepetOrani)
                cmd.Parameters.AddWithValue("?", data.DonusumOrani)
                cmd.Parameters.AddWithValue("?", data.StokMiktari)
                cmd.Parameters.AddWithValue("?", data.StokVar)
                cmd.Parameters.AddWithValue("?", data.ContentId)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            EticaretLogger.LogError($"SaveAnalizToCache hatası: {data.Barkod}", ex)
        End Try
    End Sub
    
    ''' <summary>
    ''' Tek bir ürün için analiz verisini getirir - otomatik cache yönetimi
    ''' Form bu fonksiyonu çağırır, cache süresi kontrolü otomatik yapılır
    ''' </summary>
    Public Shared Function GetAnalizData(barkod As String, nStokID As Integer, conn As OleDb.OleDbConnection) As ETicaretAnalizData
        Try
            EnsureETicaretAnalizTable(conn)
            
            ' Cache süresi kontrolü
            If IsCacheValid(barkod, conn) Then
                ' Cache geçerli - tablodan oku
                Return GetAnalizFromCache(barkod, conn)
            End If
            
            ' Cache yok veya süresi dolmuş - yeni veri oluştur
            Dim data As New ETicaretAnalizData()
            data.nStokID = nStokID
            data.Barkod = barkod
            
            ' Veritabanından satış/iade verilerini çek
            GetSalesDataFromDB(data, conn)
            
            ' Tahmini değerleri hesapla
            CalculateEstimatedValues(data)
            
            ' Cache'e kaydet
            SaveAnalizToCache(data, conn)
            
            Return data
            
        Catch ex As Exception
            EticaretLogger.LogError($"GetAnalizData hatası: {barkod}", ex)
            Return Nothing
        End Try
    End Function
    
    ''' <summary>
    ''' Belirli bir pazaryeri için tüm ürünlerin analiz verilerini getirir
    ''' Form yüklenirken bu fonksiyon çağrılır
    ''' </summary>
    Public Shared Function GetAllAnalizData(conn As OleDb.OleDbConnection, 
                                            Optional pazaryeri As String = "", 
                                            Optional kategori As String = "",
                                            Optional progressCallback As Action(Of Integer, Integer, String) = Nothing) As List(Of ETicaretAnalizData)
        Dim results As New List(Of ETicaretAnalizData)
        
        Try
            EnsureETicaretAnalizTable(conn)
            
            ' Önce cache'den verileri çek
            Dim cacheSql As String = "SELECT * FROM tbETicaretAnaliz WHERE 1=1"
            If Not String.IsNullOrEmpty(pazaryeri) AndAlso pazaryeri <> "Tümü" Then
                cacheSql &= " AND sPazaryeri = '" & pazaryeri.Replace("'", "''") & "'"
            End If
            If Not String.IsNullOrEmpty(kategori) AndAlso kategori <> "Tümü" Then
                cacheSql &= " AND sKategori LIKE '%" & kategori.Replace("'", "''") & "%'"
            End If
            
            ' Cache süresi kontrolü - en az bir kayıt güncel mi?
            Dim cacheSuresiDakika As Integer = CACHE_SURESI_SAAT * 60
            Dim hasValidCache As Boolean = False
            
            Using checkCmd As New OleDb.OleDbCommand(
                "SELECT COUNT(*) FROM tbETicaretAnaliz WHERE DATEDIFF(minute, dteSonGuncelleme, GETDATE()) < " & cacheSuresiDakika, conn)
                hasValidCache = CInt(checkCmd.ExecuteScalar()) > 0
            End Using
            
            If hasValidCache Then
                ' Cache güncel - tablodan oku
                Using cmd As New OleDb.OleDbCommand(cacheSql, conn)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim data = ReadAnalizDataFromReader(reader)
                            If data IsNot Nothing Then
                                results.Add(data)
                            End If
                        End While
                    End Using
                End Using
                
                EticaretLogger.LogInfo($"Cache'den {results.Count} ürün analiz verisi okundu")
                Return results
            End If
            
            ' Cache geçersiz veya boş - veritabanından ürünleri çek ve güncelle
            progressCallback?.Invoke(0, 100, "Veriler güncelleniyor...")
            
            Dim urunler As New List(Of UrunBilgi)
            
            ' Kullanıcının ayarladığı kategori sınıfını oku (varsayılan: sSinifKodu4 = Sınıf 4)
            Dim kategoriField As String = GetSinifEslemeAyar(conn, "ETICARET_SINIF_KAT1", "sSinifKodu4")
            Dim sinifNo As String = kategoriField.Replace("sSinifKodu", "")
            
            Dim urunSql As String = "SELECT s.nStokID, 
                ISNULL((SELECT TOP 1 b.sBarkod FROM tbStokBarkodu b WHERE b.nStokID = s.nStokID), '') AS sBarkod,
                ISNULL(s.sKodu, '') AS sStokKodu,
                ISNULL(s.sModel, '') AS sModel,
                ISNULL(s.sAciklama, '') AS sUrunAdi,
                ISNULL(s.sRenk, '') AS sRenk,
                ISNULL(s.sBeden, '') AS sBeden,
                ISNULL((SELECT TOP 1 ss.sAciklama FROM tbStokSinifi si INNER JOIN tbSSinif" & sinifNo & " ss ON si.sSinifKodu" & sinifNo & " = ss.sSinifKodu WHERE si.nStokID = s.nStokID), '') AS sKategori,
                ISNULL((SELECT TOP 1 f.lFiyat FROM tbStokFiyati f WHERE f.nStokID = s.nStokID AND f.sFiyatTipi = 'WEBP'), 0) AS SatisFiyat,
                ISNULL((SELECT TOP 1 f.lFiyat FROM tbStokFiyati f WHERE f.nStokID = s.nStokID AND f.sFiyatTipi = 'A'), 0) AS AlisFiyat,
                ISNULL((SELECT TOP 1 f.lFiyat FROM tbStokFiyati f WHERE f.nStokID = s.nStokID AND f.sFiyatTipi = 'M'), 0) AS MaliyetFiyat,
                ISNULL((SELECT SUM(d.lGirisMiktar1 - d.lCikisMiktar1) FROM tbStokFisiDetayi d WHERE d.nStokID = s.nStokID), 0) AS Stok
                FROM tbStok s 
                WHERE s.nStokTipi < 5
                AND s.bWebGoruntule = 1
                AND EXISTS (SELECT 1 FROM tbStokBarkodu b WHERE b.nStokID = s.nStokID AND LEN(b.sBarkod) >= 8)"
            
            If Not String.IsNullOrEmpty(kategori) AndAlso kategori <> "Tümü" Then
                urunSql &= " AND EXISTS (SELECT 1 FROM tbStokSinifi si INNER JOIN tbSSinif" & sinifNo & " ss ON si.sSinifKodu" & sinifNo & " = ss.sSinifKodu WHERE si.nStokID = s.nStokID AND ss.sAciklama LIKE '%" & kategori.Replace("'", "''") & "%')"
            End If
            
            Using cmd As New OleDb.OleDbCommand(urunSql, conn)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim barkod = reader("sBarkod").ToString().Trim()
                        If Not String.IsNullOrEmpty(barkod) Then
                            Dim urun As New UrunBilgi()
                            urun.nStokID = CInt(reader("nStokID"))
                            urun.Barkod = barkod
                            urun.StokKodu = reader("sStokKodu").ToString()
                            urun.Model = reader("sModel").ToString()
                            urun.UrunAdi = reader("sUrunAdi").ToString()
                            urun.Renk = reader("sRenk").ToString()
                            urun.Beden = reader("sBeden").ToString()
                            urun.Kategori = reader("sKategori").ToString()
                            urun.SatisFiyat = CDec(reader("SatisFiyat"))
                            urun.AlisFiyat = CDec(reader("AlisFiyat"))
                            urun.MaliyetFiyat = CDec(reader("MaliyetFiyat"))
                            urun.Stok = CDec(reader("Stok"))
                            urunler.Add(urun)
                        End If
                    End While
                End Using
            End Using
            
            ' Her ürün için veri oluştur ve cache'e kaydet
            Dim sayac As Integer = 0
            For Each urun As UrunBilgi In urunler
                sayac += 1
                
                If sayac Mod 50 = 0 Then
                    progressCallback?.Invoke(sayac, urunler.Count, $"Güncelleniyor: {sayac}/{urunler.Count}")
                End If
                
                Try
                    Dim data As New ETicaretAnalizData()
                    data.nStokID = urun.nStokID
                    data.Barkod = urun.Barkod
                    data.StokKodu = urun.StokKodu
                    data.Model = urun.Model
                    data.UrunAdi = urun.UrunAdi
                    data.Renk = urun.Renk
                    data.Beden = urun.Beden
                    data.Kategori = urun.Kategori
                    data.BizimFiyat = urun.SatisFiyat
                    data.Pazaryeri = If(String.IsNullOrEmpty(pazaryeri) OrElse pazaryeri = "Tümü", "Trendyol", pazaryeri)
                    
                    ' Veritabanından satış verilerini çek
                    GetSalesDataFromDB(data, conn)
                    
                    ' Tahmini değerleri hesapla
                    CalculateEstimatedValues(data)
                    
                    ' Cache'e kaydet
                    SaveAnalizToCache(data, conn)
                    
                    results.Add(data)
                    
                Catch itemEx As Exception
                    EticaretLogger.LogError($"Ürün güncelleme hatası: {urun.Barkod}", itemEx)
                End Try
            Next
            
            progressCallback?.Invoke(urunler.Count, urunler.Count, $"Tamamlandı: {results.Count} ürün")
            EticaretLogger.LogInfo($"Cache güncellendi: {results.Count} ürün")
            
        Catch ex As Exception
            EticaretLogger.LogError("GetAllAnalizData hatası", ex)
        End Try
        
        Return results
    End Function
    
    ''' <summary>
    ''' DataReader'dan ETicaretAnalizData okuyan yardımcı fonksiyon
    ''' </summary>
    Private Shared Function ReadAnalizDataFromReader(reader As OleDb.OleDbDataReader) As ETicaretAnalizData
        Try
            Dim data As New ETicaretAnalizData()
            data.nStokID = If(IsDBNull(reader("nStokID")), 0, CInt(reader("nStokID")))
            data.Barkod = If(IsDBNull(reader("sBarkod")), "", reader("sBarkod").ToString())
            data.StokKodu = If(IsDBNull(reader("sStokKodu")), "", reader("sStokKodu").ToString())
            data.Model = If(IsDBNull(reader("sModel")), "", reader("sModel").ToString())
            data.UrunAdi = If(IsDBNull(reader("sUrunAdi")), "", reader("sUrunAdi").ToString())
            data.Renk = If(IsDBNull(reader("sRenk")), "", reader("sRenk").ToString())
            data.Beden = If(IsDBNull(reader("sBeden")), "", reader("sBeden").ToString())
            data.Kategori = If(IsDBNull(reader("sKategori")), "", reader("sKategori").ToString())
            data.Pazaryeri = If(IsDBNull(reader("sPazaryeri")), "Trendyol", reader("sPazaryeri").ToString())
            
            ' Fiyat
            data.BizimFiyat = If(IsDBNull(reader("dBizimFiyat")), 0D, CDec(reader("dBizimFiyat")))
            data.EnDusukRakipFiyat = If(IsDBNull(reader("dEnDusukRakipFiyat")), 0D, CDec(reader("dEnDusukRakipFiyat")))
            data.OrtalamaRakipFiyat = If(IsDBNull(reader("dOrtalamaRakipFiyat")), 0D, CDec(reader("dOrtalamaRakipFiyat")))
            data.RakipSayisi = If(IsDBNull(reader("iRakipSayisi")), 0, CInt(reader("iRakipSayisi")))
            data.FiyatFarki = If(IsDBNull(reader("dFiyatFarki")), 0D, CDec(reader("dFiyatFarki")))
            data.FiyatFarkYuzde = If(IsDBNull(reader("fFiyatFarkYuzde")), 0D, CDec(reader("fFiyatFarkYuzde")))
            
            ' Satış
            data.Satis7Gun = If(IsDBNull(reader("iSatis7Gun")), 0, CInt(reader("iSatis7Gun")))
            data.Satis30Gun = If(IsDBNull(reader("iSatis30Gun")), 0, CInt(reader("iSatis30Gun")))
            data.Satis90Gun = If(IsDBNull(reader("iSatis90Gun")), 0, CInt(reader("iSatis90Gun")))
            data.SatisTutari30Gun = If(IsDBNull(reader("dSatisTutari30Gun")), 0D, CDec(reader("dSatisTutari30Gun")))
            
            ' İade
            data.IadeSayisi = If(IsDBNull(reader("iIadeSayisi")), 0, CInt(reader("iIadeSayisi")))
            data.IptalSayisi = If(IsDBNull(reader("iIptalSayisi")), 0, CInt(reader("iIptalSayisi")))
            data.TeslimEdilemedi = If(IsDBNull(reader("iTeslimEdilemedi")), 0, CInt(reader("iTeslimEdilemedi")))
            data.ToplamIade = If(IsDBNull(reader("iToplamIade")), 0, CInt(reader("iToplamIade")))
            data.IadeOrani = If(IsDBNull(reader("fIadeOrani")), 0D, CDec(reader("fIadeOrani")))
            
            ' Yorum
            data.YorumSayisi = If(IsDBNull(reader("iYorumSayisi")), 0, CInt(reader("iYorumSayisi")))
            data.OrtalamaPuan = If(IsDBNull(reader("fOrtalamaPuan")), 0D, CDec(reader("fOrtalamaPuan")))
            data.PozitifYorum = If(IsDBNull(reader("iPozitifYorum")), 0, CInt(reader("iPozitifYorum")))
            data.NegatifYorum = If(IsDBNull(reader("iNegatifYorum")), 0, CInt(reader("iNegatifYorum")))
            data.NotrYorum = If(IsDBNull(reader("iNotrYorum")), 0, CInt(reader("iNotrYorum")))
            data.SikSikayet = If(IsDBNull(reader("sSikSikayet")), "", reader("sSikSikayet").ToString())
            data.SikOvergu = If(IsDBNull(reader("sSikOvergu")), "", reader("sSikOvergu").ToString())
            
            ' Favori/Sepet
            data.GoruntulenmeSayisi = If(IsDBNull(reader("iGoruntulenmeSayisi")), 0, CInt(reader("iGoruntulenmeSayisi")))
            data.FavoriSayisi = If(IsDBNull(reader("iFavoriSayisi")), 0, CInt(reader("iFavoriSayisi")))
            data.SepetSayisi = If(IsDBNull(reader("iSepetSayisi")), 0, CInt(reader("iSepetSayisi")))
            data.FavoriOrani = If(IsDBNull(reader("fFavoriOrani")), 0D, CDec(reader("fFavoriOrani")))
            data.SepetOrani = If(IsDBNull(reader("fSepetOrani")), 0D, CDec(reader("fSepetOrani")))
            data.DonusumOrani = If(IsDBNull(reader("fDonusumOrani")), 0D, CDec(reader("fDonusumOrani")))
            
            ' Stok
            data.StokMiktari = If(IsDBNull(reader("iStokMiktari")), 0, CInt(reader("iStokMiktari")))
            data.StokVar = If(IsDBNull(reader("bStokVar")), True, CBool(reader("bStokVar")))
            
            data.ContentId = If(IsDBNull(reader("sContentId")), "", reader("sContentId").ToString())
            data.SonGuncelleme = If(IsDBNull(reader("dteSonGuncelleme")), DateTime.MinValue, CDate(reader("dteSonGuncelleme")))
            
            Return data
        Catch
            Return Nothing
        End Try
    End Function
    
    ''' <summary>
    ''' Veritabanından satış verilerini çeker
    ''' </summary>
    Private Shared Sub GetSalesDataFromDB(data As ETicaretAnalizData, conn As OleDb.OleDbConnection)
        Try
            ' Önce stok miktarını çek
            Dim stokSql As String = "SELECT ISNULL(SUM(d.lGirisMiktar1 - d.lCikisMiktar1), 0) AS StokMiktari 
                FROM tbStokFisiDetayi d WHERE d.nStokID = ?"
            
            Using stokCmd As New OleDb.OleDbCommand(stokSql, conn)
                stokCmd.Parameters.AddWithValue("?", data.nStokID)
                Dim stokResult = stokCmd.ExecuteScalar()
                data.StokMiktari = If(IsDBNull(stokResult), 0, CInt(stokResult))
                data.StokVar = data.StokMiktari > 0
            End Using
            
            Dim sql As String = "SELECT 
                ISNULL((SELECT SUM(d.lCikisMiktar1) FROM tbStokFisiDetayi d 
                    INNER JOIN tbStokFisiMaster m ON d.nStokFisiID = m.nStokFisiID 
                    WHERE d.nStokID = ? AND m.sFisTipi = 'FS ' AND d.lCikisMiktar1 > 0 
                    AND m.dteFisTarihi >= DATEADD(day, -7, GETDATE())), 0) AS Satis7Gun,
                ISNULL((SELECT SUM(d.lCikisMiktar1) FROM tbStokFisiDetayi d 
                    INNER JOIN tbStokFisiMaster m ON d.nStokFisiID = m.nStokFisiID 
                    WHERE d.nStokID = ? AND m.sFisTipi = 'FS ' AND d.lCikisMiktar1 > 0 
                    AND m.dteFisTarihi >= DATEADD(day, -30, GETDATE())), 0) AS Satis30Gun,
                ISNULL((SELECT SUM(d.lCikisMiktar1) FROM tbStokFisiDetayi d 
                    INNER JOIN tbStokFisiMaster m ON d.nStokFisiID = m.nStokFisiID 
                    WHERE d.nStokID = ? AND m.sFisTipi = 'FS ' AND d.lCikisMiktar1 > 0 
                    AND m.dteFisTarihi >= DATEADD(day, -90, GETDATE())), 0) AS Satis90Gun,
                ISNULL((SELECT SUM(ABS(d.lCikisMiktar1)) FROM tbStokFisiDetayi d 
                    INNER JOIN tbStokFisiMaster m ON d.nStokFisiID = m.nStokFisiID 
                    WHERE d.nStokID = ? AND (m.sFisTipi = 'FI ' OR d.lCikisMiktar1 < 0)
                    AND m.dteFisTarihi >= DATEADD(day, -90, GETDATE())), 0) AS ToplamIade"
            
            Using cmd As New OleDb.OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("?", data.nStokID)
                cmd.Parameters.AddWithValue("?", data.nStokID)
                cmd.Parameters.AddWithValue("?", data.nStokID)
                cmd.Parameters.AddWithValue("?", data.nStokID)
                
                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then
                        data.Satis7Gun = If(IsDBNull(reader("Satis7Gun")), 0, CInt(reader("Satis7Gun")))
                        data.Satis30Gun = If(IsDBNull(reader("Satis30Gun")), 0, CInt(reader("Satis30Gun")))
                        data.Satis90Gun = If(IsDBNull(reader("Satis90Gun")), 0, CInt(reader("Satis90Gun")))
                        data.ToplamIade = If(IsDBNull(reader("ToplamIade")), 0, CInt(reader("ToplamIade")))
                        
                        If data.Satis90Gun > 0 Then
                            data.IadeOrani = Math.Round(CDec(data.ToplamIade) / CDec(data.Satis90Gun) * 100, 2)
                        End If
                    End If
                End Using
            End Using
        Catch ex As Exception
            EticaretLogger.LogError($"GetSalesDataFromDB hatası: {data.nStokID}", ex)
        End Try
    End Sub
    
    ''' <summary>
    ''' Satış verilerine dayalı tahmini değerleri hesaplar
    ''' </summary>
    Private Shared Sub CalculateEstimatedValues(data As ETicaretAnalizData)
        If data.Satis30Gun > 0 Then
            ' Görüntülenme tahmini (satışın ~65x'i)
            data.GoruntulenmeSayisi = data.Satis30Gun * 65
            
            ' Sepet tahmini (satışın ~4x'i)
            data.SepetSayisi = data.Satis30Gun * 4
            
            ' Favori tahmini (satışın ~2.5x'i)
            data.FavoriSayisi = CInt(data.Satis30Gun * 2.5)
            
            ' Yorum tahmini (satışın ~%7'si)
            data.YorumSayisi = CInt(data.Satis30Gun * 0.07)
            
            ' Oranları hesapla
            If data.GoruntulenmeSayisi > 0 Then
                data.FavoriOrani = Math.Round(CDec(data.FavoriSayisi) / CDec(data.GoruntulenmeSayisi) * 100, 2)
                data.SepetOrani = Math.Round(CDec(data.SepetSayisi) / CDec(data.GoruntulenmeSayisi) * 100, 2)
                data.DonusumOrani = Math.Round(CDec(data.Satis30Gun) / CDec(data.GoruntulenmeSayisi) * 100, 2)
            End If
            
            ' İade oranına göre tahmini puan
            If data.IadeOrani < 5 Then
                data.OrtalamaPuan = 4.5D
            ElseIf data.IadeOrani < 10 Then
                data.OrtalamaPuan = 4.0D
            ElseIf data.IadeOrani < 20 Then
                data.OrtalamaPuan = 3.5D
            Else
                data.OrtalamaPuan = 3.0D
            End If
        End If
    End Sub
    
    ''' <summary>
    ''' Süresi dolmuş cache kayıtlarını temizler
    ''' </summary>
    Public Shared Sub CleanExpiredAnalysisCache(conn As OleDb.OleDbConnection)
        Try
            ' 7 günden eski kayıtları sil (cache süresi ayrı, bu genel temizlik)
            Using cmd As New OleDb.OleDbCommand(
                "DELETE FROM tbETicaretAnaliz WHERE DATEDIFF(day, dteSonGuncelleme, GETDATE()) > 7", conn)
                Dim deleted = cmd.ExecuteNonQuery()
                If deleted > 0 Then
                    EticaretLogger.LogInfo($"Eski analiz kayıtları temizlendi: {deleted}")
                End If
            End Using
            
            Using cmd As New OleDb.OleDbCommand(
                "DELETE FROM tbETicaretRakipDetay WHERE DATEDIFF(day, dteSonGuncelleme, GETDATE()) > 7", conn)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            EticaretLogger.LogError("CleanExpiredAnalysisCache hatası", ex)
        End Try
    End Sub
    
    ''' <summary>
    ''' Cache son güncelleme zamanını döndürür
    ''' </summary>
    Public Shared Function GetCacheLastUpdateTime(conn As OleDb.OleDbConnection) As DateTime
        Try
            Using cmd As New OleDb.OleDbCommand("SELECT MAX(dteSonGuncelleme) FROM tbETicaretAnaliz", conn)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    Return CDate(result)
                End If
            End Using
        Catch
        End Try
        Return DateTime.MinValue
    End Function
    
    ''' <summary>
    ''' Cache'deki toplam kayıt sayısını döndürür
    ''' </summary>
    Public Shared Function GetCacheRecordCount(conn As OleDb.OleDbConnection) As Integer
        Try
            Using cmd As New OleDb.OleDbCommand("SELECT COUNT(*) FROM tbETicaretAnaliz", conn)
                Return CInt(cmd.ExecuteScalar())
            End Using
        Catch
            Return 0
        End Try
    End Function
    
#End Region

#Region "Trendyol Yorum API"
    
    ''' <summary>
    ''' Trendyol'dan urun yorumlarini ceker (Public API - auth gerektirmez)
    ''' </summary>
    Public Shared Function GetTrendyolReviews(contentId As String) As List(Of TrendyolReview)
        Dim reviews As New List(Of TrendyolReview)
        
        Try
            ' Trendyol public yorum API'si
            Dim url As String = $"https://public.trendyol.com/discovery-web-searchgw-service/v2/api/reviews/{contentId}?page=0&size=50"
            
            Using request As New HttpRequestMessage(HttpMethod.Get, url)
                request.Headers.Add("User-Agent", "Mozilla/5.0")
                
                Dim response As HttpResponseMessage = _httpClient.SendAsync(request).Result
                
                If response.IsSuccessStatusCode Then
                    Dim json As String = response.Content.ReadAsStringAsync().Result
                    Dim data As JObject = JObject.Parse(json)
                    
                    Dim result As JToken = data("result")
                    If result IsNot Nothing Then
                        Dim productReviews As JToken = result("productReviews")
                        If productReviews IsNot Nothing Then
                            Dim content As JToken = productReviews("content")
                            If content IsNot Nothing Then
                                For Each reviewJson As JToken In content
                                    Dim review As New TrendyolReview()
                                    review.Rating = If(reviewJson("rate") IsNot Nothing, CInt(reviewJson("rate")), 0)
                                    review.Comment = If(reviewJson("comment") IsNot Nothing, reviewJson("comment").ToString(), "")
                                    review.UserName = If(reviewJson("userFullName") IsNot Nothing, reviewJson("userFullName").ToString(), "")
                                    review.ReviewDate = DateTime.Now
                                    reviews.Add(review)
                                Next
                            End If
                        End If
                    End If
                End If
            End Using
            
        Catch ex As Exception
            EticaretLogger.LogError($"Trendyol GetReviews hatasi: {contentId}", ex)
        End Try
        
        Return reviews
    End Function
    
#End Region

#Region "Hepsiburada API"
    
    ''' <summary>
    ''' Hepsiburada'dan siparis listesini ceker
    ''' </summary>
    Public Shared Function GetHepsiburadaOrders(Optional startDate As DateTime = Nothing) As List(Of HepsiburadaOrder)
        Dim orders As New List(Of HepsiburadaOrder)
        
        Try
            Dim settings = GetAPISettings("Hepsiburada")
            If Not settings.IsConfigured Then
                EticaretLogger.LogWarning("Hepsiburada API ayarlari yapilmamis")
                Return orders
            End If
            
            If startDate = Nothing Then startDate = DateTime.Now.AddDays(-7)
            
            Dim url As String = $"{settings.BaseUrl}/orders/merchantid/{settings.SellerId}"
            
            Using request As New HttpRequestMessage(HttpMethod.Get, url)
                request.Headers.Add("Authorization", $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($"{settings.ApiKey}:{settings.ApiSecret}"))}")
                
                Dim response As HttpResponseMessage = _httpClient.SendAsync(request).Result
                
                If response.IsSuccessStatusCode Then
                    Dim json As String = response.Content.ReadAsStringAsync().Result
                    EticaretLogger.LogInfo($"Hepsiburada Orders response: {json.Substring(0, Math.Min(500, json.Length))}")
                    
                    Dim data As JArray = JArray.Parse(json)
                    For Each orderJson As JToken In data
                        Dim order As New HepsiburadaOrder()
                        order.OrderNumber = If(orderJson("orderId") IsNot Nothing, orderJson("orderId").ToString(), "")
                        order.Status = If(orderJson("orderStatus") IsNot Nothing, orderJson("orderStatus").ToString(), "")
                        order.TotalAmount = If(orderJson("totalAmount") IsNot Nothing, CDec(orderJson("totalAmount")), 0)
                        orders.Add(order)
                    Next
                End If
            End Using
            
        Catch ex As Exception
            EticaretLogger.LogError("Hepsiburada GetOrders hatasi", ex)
        End Try
        
        Return orders
    End Function
    
#End Region

#Region "N11 API"
    
    ''' <summary>
    ''' N11'den siparis listesini ceker (SOAP API)
    ''' </summary>
    Public Shared Function GetN11Orders() As List(Of N11Order)
        Dim orders As New List(Of N11Order)
        
        Try
            Dim settings = GetAPISettings("N11")
            If Not settings.IsConfigured Then
                EticaretLogger.LogWarning("N11 API ayarlari yapilmamis")
                Return orders
            End If
            
            ' N11 SOAP API
            Dim soapEnvelope As String = $"<?xml version=""1.0"" encoding=""utf-8""?>
<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:sch=""http://www.n11.com/ws/schemas"">
   <soapenv:Header>
      <sch:auth>
         <sch:appKey>{settings.ApiKey}</sch:appKey>
         <sch:appSecret>{settings.ApiSecret}</sch:appSecret>
      </sch:auth>
   </soapenv:Header>
   <soapenv:Body>
      <sch:DetailedOrderListRequest>
         <sch:searchData>
            <sch:productId></sch:productId>
            <sch:status>New</sch:status>
            <sch:buyerName></sch:buyerName>
            <sch:orderNumber></sch:orderNumber>
            <sch:productSellerCode></sch:productSellerCode>
            <sch:recipient></sch:recipient>
            <sch:period>
               <sch:startDate></sch:startDate>
               <sch:endDate></sch:endDate>
            </sch:period>
            <sch:sortForUpdateDate>false</sch:sortForUpdateDate>
         </sch:searchData>
         <sch:pagingData>
            <sch:currentPage>0</sch:currentPage>
            <sch:pageSize>100</sch:pageSize>
         </sch:pagingData>
      </sch:DetailedOrderListRequest>
   </soapenv:Body>
</soapenv:Envelope>"
            
            Using request As New HttpRequestMessage(HttpMethod.Post, $"{settings.BaseUrl}/orderService/")
                request.Content = New StringContent(soapEnvelope, Encoding.UTF8, "text/xml")
                request.Headers.Add("SOAPAction", "")
                
                Dim response = _httpClient.SendAsync(request).Result
                
                If response.IsSuccessStatusCode Then
                    Dim xml = response.Content.ReadAsStringAsync().Result
                    EticaretLogger.LogInfo($"N11 Orders response length: {xml.Length}")
                    ' Parse XML response...
                End If
            End Using
            
        Catch ex As Exception
            EticaretLogger.LogError("N11 GetOrders hatasi", ex)
        End Try
        
        Return orders
    End Function
    
#End Region

#Region "Trendyol Web Scraping - Rakip Fiyat Analizi"
    
    ''' <summary>
    ''' Trendyol'dan barkod ile ürün arayıp rakip satıcı bilgilerini çeker (Web Scraping)
    ''' </summary>
    Public Shared Function GetTrendyolCompetitors(barcode As String) As TrendyolCompetitorResult
        Dim result As New TrendyolCompetitorResult()
        result.Barcode = barcode
        result.Competitors = New List(Of TrendyolCompetitor)()
        
        Try
            ' Rate limiting - çok hızlı istek atmamak için
            System.Threading.Thread.Sleep(500)
            
            ' 1. Önce barkod ile arama yap
            Dim searchUrl As String = $"https://www.trendyol.com/sr?q={barcode}"
            
            Using request As New HttpRequestMessage(HttpMethod.Get, searchUrl)
                request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36")
                request.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,*/*;q=0.8")
                request.Headers.Add("Accept-Language", "tr-TR,tr;q=0.9,en-US;q=0.8,en;q=0.7")
                
                Dim response As HttpResponseMessage = _httpClient.SendAsync(request).Result
                
                If response.IsSuccessStatusCode Then
                    Dim html As String = response.Content.ReadAsStringAsync().Result
                    
                    ' Content ID'yi bul (ürün detay sayfası için)
                    Dim contentId As String = ExtractContentId(html)
                    
                    If Not String.IsNullOrEmpty(contentId) Then
                        result.ContentId = contentId
                        
                        ' 2. Diğer satıcıları çek
                        result = GetTrendyolMerchants(result)
                    Else
                        ' Arama sonucundan fiyat bilgisi çekmeye çalış
                        result = ExtractPriceFromSearchResults(html, result)
                    End If
                End If
            End Using
            
        Catch ex As Exception
            EticaretLogger.LogError($"Trendyol rakip tarama hatası: {barcode}", ex)
            result.ErrorMessage = ex.Message
        End Try
        
        Return result
    End Function
    
    ''' <summary>
    ''' HTML'den Content ID çıkar
    ''' </summary>
    Private Shared Function ExtractContentId(html As String) As String
        Try
            ' Pattern: "contentId":12345678 veya /p-12345678
            Dim patterns As String() = {
                """contentId"":(\d+)",
                "/p-(\d+)",
                "data-content-id=""(\d+)""",
                "productId"":(\d+)"
            }
            
            For Each pattern As String In patterns
                Dim match = System.Text.RegularExpressions.Regex.Match(html, pattern)
                If match.Success AndAlso match.Groups.Count > 1 Then
                    Return match.Groups(1).Value
                End If
            Next
            
        Catch ex As Exception
            EticaretLogger.LogError("ExtractContentId hatası", ex)
        End Try
        
        Return ""
    End Function
    
    ''' <summary>
    ''' Trendyol diğer satıcılar API'sinden rakip bilgilerini çeker
    ''' </summary>
    Private Shared Function GetTrendyolMerchants(result As TrendyolCompetitorResult) As TrendyolCompetitorResult
        Try
            If String.IsNullOrEmpty(result.ContentId) Then Return result
            
            ' Rate limiting
            System.Threading.Thread.Sleep(300)
            
            ' Diğer satıcılar API'si
            Dim merchantUrl As String = $"https://public.trendyol.com/discovery-web-searchgw-service/v2/api/product-detail/{result.ContentId}/other-merchants"
            
            Using request As New HttpRequestMessage(HttpMethod.Get, merchantUrl)
                request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36")
                request.Headers.Add("Accept", "application/json")
                
                Dim response As HttpResponseMessage = _httpClient.SendAsync(request).Result
                
                If response.IsSuccessStatusCode Then
                    Dim json As String = response.Content.ReadAsStringAsync().Result
                    Dim data As JObject = JObject.Parse(json)
                    
                    ' Ürün bilgileri
                    If data("result") IsNot Nothing Then
                        Dim resultObj = data("result")
                        
                        result.ProductName = If(resultObj("name") IsNot Nothing, resultObj("name").ToString(), "")
                        
                        ' Diğer satıcılar
                        Dim otherMerchants As JToken = resultObj("otherMerchants")
                        If otherMerchants IsNot Nothing Then
                            For Each merchant As JToken In otherMerchants
                                Dim comp As New TrendyolCompetitor()
                                comp.MerchantName = If(merchant("name") IsNot Nothing, merchant("name").ToString(), "Bilinmiyor")
                                comp.MerchantId = If(merchant("id") IsNot Nothing, merchant("id").ToString(), "")
                                
                                ' Fiyat bilgileri
                                Dim priceInfo = merchant("price")
                                If priceInfo IsNot Nothing Then
                                    comp.Price = If(priceInfo("sellingPrice") IsNot Nothing, CDec(priceInfo("sellingPrice")), 0)
                                    comp.DiscountedPrice = If(priceInfo("discountedPrice") IsNot Nothing, CDec(priceInfo("discountedPrice")), comp.Price)
                                    comp.OriginalPrice = If(priceInfo("originalPrice") IsNot Nothing, CDec(priceInfo("originalPrice")), comp.Price)
                                End If
                                
                                ' Kargo bilgisi
                                comp.FreeShipping = merchant("freeShipping") IsNot Nothing AndAlso CBool(merchant("freeShipping"))
                                comp.ShippingFee = If(comp.FreeShipping, 0, 34.99D) ' Varsayılan kargo ücreti
                                
                                ' Puan ve yorum
                                Dim ratingInfo = merchant("ratingScore")
                                If ratingInfo IsNot Nothing Then
                                    comp.Rating = If(ratingInfo("averageRating") IsNot Nothing, CDec(ratingInfo("averageRating")), 0)
                                    comp.ReviewCount = If(ratingInfo("totalCount") IsNot Nothing, CInt(ratingInfo("totalCount")), 0)
                                End If
                                
                                ' Stok durumu
                                comp.InStock = merchant("inStock") Is Nothing OrElse CBool(merchant("inStock"))
                                
                                result.Competitors.Add(comp)
                            Next
                        End If
                        
                        ' Ana satıcı bilgisi (merchant)
                        Dim mainMerchant = resultObj("merchant")
                        If mainMerchant IsNot Nothing Then
                            Dim mainComp As New TrendyolCompetitor()
                            mainComp.MerchantName = If(mainMerchant("name") IsNot Nothing, mainMerchant("name").ToString(), "Ana Satıcı")
                            mainComp.MerchantId = If(mainMerchant("id") IsNot Nothing, mainMerchant("id").ToString(), "")
                            mainComp.IsMainMerchant = True
                            
                            ' Ana satıcı fiyat bilgisi
                            Dim mainPrice = resultObj("price")
                            If mainPrice IsNot Nothing Then
                                mainComp.Price = If(mainPrice("sellingPrice") IsNot Nothing, CDec(mainPrice("sellingPrice")), 0)
                                mainComp.DiscountedPrice = If(mainPrice("discountedPrice") IsNot Nothing, CDec(mainPrice("discountedPrice")), mainComp.Price)
                            End If
                            
                            result.Competitors.Insert(0, mainComp)
                        End If
                    End If
                    
                    result.Success = result.Competitors.Count > 0
                    
                Else
                    EticaretLogger.LogWarning($"Trendyol merchants API yanıt vermedi: {response.StatusCode}")
                End If
            End Using
            
        Catch ex As Exception
            EticaretLogger.LogError($"GetTrendyolMerchants hatası: {result.ContentId}", ex)
            result.ErrorMessage = ex.Message
        End Try
        
        Return result
    End Function
    
    ''' <summary>
    ''' Arama sonuçlarından fiyat bilgisi çıkar (alternatif yöntem)
    ''' </summary>
    Private Shared Function ExtractPriceFromSearchResults(html As String, result As TrendyolCompetitorResult) As TrendyolCompetitorResult
        Try
            ' JSON data içindeki fiyat bilgisini bul
            ' Pattern: "price":{"sellingPrice":123.45
            Dim pricePattern As String = """sellingPrice"":(\d+\.?\d*)"
            Dim priceMatch = System.Text.RegularExpressions.Regex.Match(html, pricePattern)
            
            If priceMatch.Success AndAlso priceMatch.Groups.Count > 1 Then
                Dim comp As New TrendyolCompetitor()
                comp.MerchantName = "Trendyol Arama Sonucu"
                comp.Price = CDec(priceMatch.Groups(1).Value)
                comp.DiscountedPrice = comp.Price
                result.Competitors.Add(comp)
                result.Success = True
            End If
            
            ' Merchant name
            Dim merchantPattern As String = """merchantName"":""([^""]+)"""
            Dim merchantMatch = System.Text.RegularExpressions.Regex.Match(html, merchantPattern)
            If merchantMatch.Success AndAlso merchantMatch.Groups.Count > 1 AndAlso result.Competitors.Count > 0 Then
                result.Competitors(0).MerchantName = merchantMatch.Groups(1).Value
            End If
            
        Catch ex As Exception
            EticaretLogger.LogError("ExtractPriceFromSearchResults hatası", ex)
        End Try
        
        Return result
    End Function
    
#End Region

End Class

#Region "Data Classes"

Public Class PazaryeriAPISettings
    Public Property Pazaryeri As String
    Public Property SellerId As String
    Public Property ApiKey As String
    Public Property ApiSecret As String
    Public Property BaseUrl As String
    Public Property IsConfigured As Boolean = False
End Class

Public Class TrendyolProductInfo
    Public Property Barcode As String
    Public Property ProductId As String
    Public Property Title As String
    Public Property ListPrice As Decimal
    Public Property SalePrice As Decimal
    Public Property Quantity As Integer
    Public Property Success As Boolean = False
End Class

Public Class TrendyolOrder
    Public Property OrderNumber As String
    Public Property OrderDate As DateTime
    Public Property Status As String
    Public Property TotalPrice As Decimal
    Public Property Lines As New List(Of TrendyolOrderLine)
End Class

Public Class TrendyolOrderLine
    Public Property Barcode As String
    Public Property ProductName As String
    Public Property Quantity As Integer
    Public Property Price As Decimal
End Class

Public Class TrendyolReview
    Public Property Rating As Integer
    Public Property Comment As String
    Public Property UserName As String
    Public Property ReviewDate As DateTime
End Class

Public Class HepsiburadaOrder
    Public Property OrderNumber As String
    Public Property Status As String
    Public Property TotalAmount As Decimal
End Class

Public Class N11Order
    Public Property OrderNumber As String
    Public Property Status As String
    Public Property TotalAmount As Decimal
End Class

''' <summary>
''' Barkod bazında iade istatistikleri
''' </summary>
Public Class IadeIstatistik
    Public Property Barkod As String
    Public Property UrunAdi As String
    Public Property ToplamSatis As Integer = 0
    Public Property ToplamIade As Integer = 0
    Public Property IadeSayisi As Integer = 0        ' Returned
    Public Property IptalSayisi As Integer = 0       ' Cancelled
    Public Property TeslimEdilemedi As Integer = 0   ' UnDelivered
    Public Property IadeOrani As Decimal = 0
    
    ''' <summary>
    ''' Risk seviyesini döndürür
    ''' </summary>
    Public ReadOnly Property RiskSeviyesi As String
        Get
            If IadeOrani >= 20 Then Return "YÜKSEK"
            If IadeOrani >= 10 Then Return "ORTA"
            If IadeOrani >= 5 Then Return "DÜŞÜK"
            Return "ÇOK DÜŞÜK"
        End Get
    End Property
End Class

''' <summary>
''' Merkezi E-Ticaret Analiz Veri Modeli
''' Tüm formların ortak kullandığı veri yapısı
''' </summary>
Public Class ETicaretAnalizData
    ' Temel Bilgiler
    Public Property nStokID As Integer
    Public Property Barkod As String
    Public Property StokKodu As String
    Public Property Model As String
    Public Property UrunAdi As String
    Public Property Renk As String
    Public Property Beden As String
    Public Property Kategori As String
    Public Property Pazaryeri As String = "Trendyol"
    
    ' Fiyat Bilgileri
    Public Property BizimFiyat As Decimal = 0
    Public Property EnDusukRakipFiyat As Decimal = 0
    Public Property OrtalamaRakipFiyat As Decimal = 0
    Public Property RakipSayisi As Integer = 0
    Public Property FiyatFarki As Decimal = 0
    Public Property FiyatFarkYuzde As Decimal = 0
    
    ' Satış Verileri
    Public Property Satis7Gun As Integer = 0
    Public Property Satis30Gun As Integer = 0
    Public Property Satis90Gun As Integer = 0
    Public Property SatisTutari30Gun As Decimal = 0
    
    ' İade Verileri
    Public Property IadeSayisi As Integer = 0
    Public Property IptalSayisi As Integer = 0
    Public Property TeslimEdilemedi As Integer = 0
    Public Property ToplamIade As Integer = 0
    Public Property IadeOrani As Decimal = 0
    
    ' Yorum/Puan Verileri
    Public Property YorumSayisi As Integer = 0
    Public Property OrtalamaPuan As Decimal = 0
    Public Property PozitifYorum As Integer = 0
    Public Property NegatifYorum As Integer = 0
    Public Property NotrYorum As Integer = 0
    Public Property SikSikayet As String
    Public Property SikOvergu As String
    
    ' Favori/Sepet Verileri
    Public Property GoruntulenmeSayisi As Integer = 0
    Public Property FavoriSayisi As Integer = 0
    Public Property SepetSayisi As Integer = 0
    Public Property FavoriOrani As Decimal = 0
    Public Property SepetOrani As Decimal = 0
    Public Property DonusumOrani As Decimal = 0
    
    ' Stok Bilgileri
    Public Property StokMiktari As Integer = 0
    Public Property StokVar As Boolean = True
    
    ' Meta
    Public Property ContentId As String
    Public Property SonGuncelleme As DateTime
End Class

''' <summary>
''' Trendyol rakip analiz sonucu
''' </summary>
Public Class TrendyolCompetitorResult
    Public Property Barcode As String
    Public Property ContentId As String
    Public Property ProductName As String
    Public Property Competitors As New List(Of TrendyolCompetitor)
    Public Property Success As Boolean = False
    Public Property ErrorMessage As String
    
    ''' <summary>
    ''' En düşük fiyatlı rakibi döndürür
    ''' </summary>
    Public ReadOnly Property LowestPriceCompetitor As TrendyolCompetitor
        Get
            If Competitors Is Nothing OrElse Competitors.Count = 0 Then Return Nothing
            Dim lowest As TrendyolCompetitor = Competitors(0)
            For Each comp As TrendyolCompetitor In Competitors
                If comp.DiscountedPrice > 0 AndAlso comp.DiscountedPrice < lowest.DiscountedPrice Then
                    lowest = comp
                End If
            Next
            Return lowest
        End Get
    End Property
    
    ''' <summary>
    ''' En düşük fiyatı döndürür
    ''' </summary>
    Public ReadOnly Property LowestPrice As Decimal
        Get
            If LowestPriceCompetitor Is Nothing Then Return 0
            Return LowestPriceCompetitor.DiscountedPrice
        End Get
    End Property
    
    ''' <summary>
    ''' Ortalama fiyatı döndürür
    ''' </summary>
    Public ReadOnly Property AveragePrice As Decimal
        Get
            If Competitors Is Nothing OrElse Competitors.Count = 0 Then Return 0
            Dim total As Decimal = 0
            Dim count As Integer = 0
            For Each comp As TrendyolCompetitor In Competitors
                If comp.DiscountedPrice > 0 Then
                    total += comp.DiscountedPrice
                    count += 1
                End If
            Next
            Return If(count > 0, total / count, 0)
        End Get
    End Property
End Class

''' <summary>
''' Trendyol rakip satıcı bilgisi
''' </summary>
Public Class TrendyolCompetitor
    Public Property MerchantId As String
    Public Property MerchantName As String
    Public Property Price As Decimal
    Public Property DiscountedPrice As Decimal
    Public Property OriginalPrice As Decimal
    Public Property FreeShipping As Boolean
    Public Property ShippingFee As Decimal
    Public Property Rating As Decimal
    Public Property ReviewCount As Integer
    Public Property InStock As Boolean = True
    Public Property IsMainMerchant As Boolean = False
    
    ''' <summary>
    ''' Toplam maliyet (fiyat + kargo)
    ''' </summary>
    Public ReadOnly Property TotalPrice As Decimal
        Get
            Return DiscountedPrice + ShippingFee
        End Get
    End Property
End Class

''' <summary>
''' Ürün bilgi yapısı - Tuple yerine kullanılır (VB.NET 8+ eleman sınırı nedeniyle)
''' </summary>
Public Class UrunBilgi
    Public Property nStokID As Integer
    Public Property Barkod As String
    Public Property StokKodu As String
    Public Property Model As String
    Public Property UrunAdi As String
    Public Property Renk As String
    Public Property Beden As String
    Public Property Kategori As String
    Public Property SatisFiyat As Decimal
    Public Property AlisFiyat As Decimal
    Public Property MaliyetFiyat As Decimal
    Public Property Stok As Decimal
End Class

#End Region
