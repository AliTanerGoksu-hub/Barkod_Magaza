' ============================================================================
' AI DESTEKLI ÜRÜN GÖRSELI BULMA VE EKLEME SİSTEMİ
' ============================================================================
' Bu modül, barkod/model/renk bilgilerinden otomatik olarak ürün görsellerini
' bulur, AI ile doğrular ve veritabanına ekler
' ============================================================================

Imports System.Net
Imports System.Collections.Generic
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Threading.Tasks
Imports System.Text.RegularExpressions
Imports System.Linq

Public Class AIImageFinder
    
    ' Private değişkenler
    Private connection As String = ""
    Private emergentApiKey As String = ""
    Private googleSearchApiKey As String = "AIzaSyC_dOGn3xgVmBgkJv4b6_03StemDSbrWIg"
    Private googleSearchEngineId As String = "d3830d60b868641c4"
    Private logFilePath As String = ""
    Private imageFolderPath As String = ""
    
    ''' <summary>
    ''' Constructor - API key'lerini yükle
    ''' </summary>
    Public Sub New()
        Try
            ' Klasör yollarını ayarla
            imageFolderPath = Path.Combine(Application.StartupPath, "AI_Images")
            logFilePath = Path.Combine(Application.StartupPath, "AI_ImageFinder.log")
            
            ' Connection string'i global değişkenden almaya çalış
            Try
                connection = My.Settings.ConnectionString
            Catch
                ' Başarısız olursa boş bırak, constructor parametresi ile verilecek
                connection = ""
            End Try
            
            LoadApiKeys()
            
            ' Görsel klasörünü oluştur
            If Not Directory.Exists(imageFolderPath) Then
                Directory.CreateDirectory(imageFolderPath)
            End If
            
            LogImage("SUCCESS", "AIImageFinder", "AI Image Finder başlatıldı")
            
        Catch ex As Exception
            LogImage("ERROR", "AIImageFinder", $"Başlatma hatası: {ex.Message}")
        End Try
    End Sub
    
    ''' <summary>
    ''' Constructor - Connection string ile başlat
    ''' </summary>
    Public Sub New(connectionString As String)
        Try
            ' Klasör yollarını ayarla
            imageFolderPath = Path.Combine(Application.StartupPath, "AI_Images")
            logFilePath = Path.Combine(Application.StartupPath, "AI_ImageFinder.log")
            
            connection = connectionString
            
            LoadApiKeys()
            
            ' Görsel klasörünü oluştur
            If Not Directory.Exists(imageFolderPath) Then
                Directory.CreateDirectory(imageFolderPath)
            End If
            
            LogImage("SUCCESS", "AIImageFinder", "AI Image Finder başlatıldı (connection verildi)")
            
        Catch ex As Exception
            LogImage("ERROR", "AIImageFinder", $"Başlatma hatası: {ex.Message}")
        End Try
    End Sub
    
    ''' <summary>
    ''' Veritabanından API key'lerini yükle
    ''' </summary>
    Private Sub LoadApiKeys()
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                
                Dim cmd As New OleDb.OleDbCommand(
                    "SELECT sEmergentKey, sGoogleSearchApiKey, sGoogleSearchEngineId FROM tbParamGenel WHERE nParamID = 1", conn)
                
                Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                
                If reader.Read() Then
                    emergentApiKey = If(reader("sEmergentKey") IsNot DBNull.Value, reader("sEmergentKey").ToString(), "")
                    googleSearchApiKey = If(reader("sGoogleSearchApiKey") IsNot DBNull.Value, reader("sGoogleSearchApiKey").ToString(), "")
                    googleSearchEngineId = If(reader("sGoogleSearchEngineId") IsNot DBNull.Value, reader("sGoogleSearchEngineId").ToString(), "")
                End If
                
                reader.Close()
                
                ' Key kontrolü
                If String.IsNullOrEmpty(googleSearchApiKey) Then
                    LogImage("WARNING", "LoadApiKeys", "Google Search API Key bulunamadı!")
                End If
                
                If String.IsNullOrEmpty(emergentApiKey) Then
                    LogImage("WARNING", "LoadApiKeys", "Emergent LLM Key bulunamadı!")
                End If
                
            End Using
            
        Catch ex As Exception
            LogImage("ERROR", "LoadApiKeys", $"API key yükleme hatası: {ex.Message}")
        End Try
    End Sub
    
    ''' <summary>
    ''' API key'lerini veritabanına kaydet
    ''' </summary>
    Public Sub SaveApiKeys(googleApiKey As String, googleEngineId As String, Optional emergentKey As String = "")
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                
                ' Önce kayıt var mı kontrol et
                Dim checkCmd As New OleDb.OleDbCommand("SELECT COUNT(*) FROM tbParamGenel WHERE nParamID = 1", conn)
                Dim recordExists As Boolean = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0
                
                If recordExists Then
                    ' UPDATE
                    Dim updateCmd As New OleDb.OleDbCommand(
                        "UPDATE tbParamGenel SET sGoogleSearchApiKey = ?, sGoogleSearchEngineId = ?" &
                        If(String.IsNullOrEmpty(emergentKey), "", ", sEmergentKey = ?") &
                        " WHERE nParamID = 1", conn)
                    
                    updateCmd.Parameters.AddWithValue("?", googleApiKey)
                    updateCmd.Parameters.AddWithValue("?", googleEngineId)
                    If Not String.IsNullOrEmpty(emergentKey) Then
                        updateCmd.Parameters.AddWithValue("?", emergentKey)
                    End If
                    
                    updateCmd.ExecuteNonQuery()
                    LogImage("SUCCESS", "SaveApiKeys", "API key'leri güncellendi")
                Else
                    ' INSERT
                    Dim insertCmd As New OleDb.OleDbCommand(
                        "INSERT INTO tbParamGenel (nParamID, sGoogleSearchApiKey, sGoogleSearchEngineId" &
                        If(String.IsNullOrEmpty(emergentKey), "", ", sEmergentKey") &
                        ") VALUES (1, ?, ?" &
                        If(String.IsNullOrEmpty(emergentKey), "", ", ?") & ")", conn)
                    
                    insertCmd.Parameters.AddWithValue("?", googleApiKey)
                    insertCmd.Parameters.AddWithValue("?", googleEngineId)
                    If Not String.IsNullOrEmpty(emergentKey) Then
                        insertCmd.Parameters.AddWithValue("?", emergentKey)
                    End If
                    
                    insertCmd.ExecuteNonQuery()
                    LogImage("SUCCESS", "SaveApiKeys", "API key'leri eklendi")
                End If
                
                ' Yeni key'leri yükle
                googleSearchApiKey = googleApiKey
                googleSearchEngineId = googleEngineId
                If Not String.IsNullOrEmpty(emergentKey) Then
                    emergentApiKey = emergentKey
                End If
                
            End Using
            
        Catch ex As Exception
            LogImage("ERROR", "SaveApiKeys", $"API key kaydetme hatası: {ex.Message}")
        End Try
    End Sub
    
    ''' <summary>
    ''' Barkod ile Google Images'de ürün görseli arar
    ''' </summary>
    Public Function FindImagesByBarcode(barcode As String) As List(Of String)
        Dim imageUrls As New List(Of String)
        
        Try
            LogImage("INFO", "FindImagesByBarcode", $"Arama başlıyor: {barcode}")
            
            ' Google API kontrolü
            If String.IsNullOrEmpty(googleSearchApiKey) OrElse String.IsNullOrEmpty(googleSearchEngineId) Then
                LogImage("ERROR", "FindImagesByBarcode", "Google API key veya Search Engine ID eksik!")
                Return imageUrls
            End If
            
            LogImage("INFO", "FindImagesByBarcode", $"Google API kullanılıyor - Key: {googleSearchApiKey.Substring(0, 10)}..., CX: {googleSearchEngineId}")
            
            ' ÖNCE: Barkod ile ara
            imageUrls = SearchGoogleImages(barcode)
            
            If imageUrls.Count > 0 Then
                LogImage("SUCCESS", "FindImagesByBarcode", $"Barkod ile {imageUrls.Count} görsel bulundu")
                Return imageUrls
            End If
            
            LogImage("WARNING", "FindImagesByBarcode", "Barkod ile sonuç yok, ürün adı ile denenecek...")
            
            ' İKİNCİ: Ürün adı ile ara - AŞAMALI DENEME (tbStok'tan çek)
            If Not String.IsNullOrEmpty(connection) Then
                Try
                    Using conn As New OleDb.OleDbConnection(connection)
                        Using cmd As New OleDb.OleDbCommand(
                            "SELECT TOP 1 sAciklama, sModel FROM tbStok s " &
                            "INNER JOIN tbStokBarkodu b ON s.nStokID = b.nStokID " &
                            "WHERE b.sBarkod = ?", conn)
                            cmd.Parameters.Add("p0", OleDb.OleDbType.VarChar, 50).Value = barcode
                            conn.Open()
                            
                            Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                                If reader.Read() Then
                                    Dim productName As String = If(reader.IsDBNull(0), "", reader.GetString(0).Trim())
                                    Dim model As String = If(reader.IsDBNull(1), "", reader.GetString(1).Trim())
                                    
                                    If Not String.IsNullOrEmpty(productName) OrElse Not String.IsNullOrEmpty(model) Then
                                        ' AŞAMA 1: Model kodu + arnetta (en etkili)
                                        If Not String.IsNullOrEmpty(model) Then
                                            Dim searchQuery1 As String = $"{model} arnetta"
                                            LogImage("INFO", "FindImagesByBarcode", $"Aşama 1 - Model kodu ile arama: {searchQuery1}")
                                            imageUrls = SearchGoogleImages(searchQuery1)
                                        End If
                                        
                                        ' AŞAMA 2: Sonuç yoksa ürün adı dene
                                        If imageUrls.Count = 0 AndAlso Not String.IsNullOrEmpty(productName) Then
                                            Dim searchQuery2 As String = $"{productName} {model} arnetta"
                                            LogImage("INFO", "FindImagesByBarcode", $"Aşama 2 - Ürün adı ile arama: {searchQuery2}")
                                            imageUrls = SearchGoogleImages(searchQuery2)
                                        End If
                                        
                                        ' AŞAMA 3: Hala sonuç yoksa sadece ürün adı
                                        If imageUrls.Count = 0 AndAlso Not String.IsNullOrEmpty(productName) Then
                                            Dim searchQuery3 As String = $"{productName} cocuk"
                                            LogImage("INFO", "FindImagesByBarcode", $"Aşama 3 - Genel arama: {searchQuery3}")
                                            imageUrls = SearchGoogleImages(searchQuery3)
                                        End If
                                    End If
                                End If
                            End Using
                        End Using
                    End Using
                Catch dbEx As Exception
                    LogImage("ERROR", "FindImagesByBarcode", $"Database hatası: {dbEx.Message}")
                End Try
            End If
            
            LogImage("SUCCESS", "FindImagesByBarcode", $"Toplam {imageUrls.Count} görsel bulundu")
            Return imageUrls
            
        Catch ex As Exception
            LogImage("ERROR", "FindImagesByBarcode", $"Genel hata: {ex.Message}")
            Return imageUrls
        End Try
    End Function
    
    ''' <summary>
    ''' Arnetta sitesinde direkt model arama (JavaScript render olmadan)
    ''' </summary>
    Private Function SearchArnettaDirect(modelCode As String) As List(Of String)
        Dim images As New List(Of String)
        
        Try
            ' Arnetta CDN'den direkt resim URL'lerini oluştur
            ' Pattern: https://cdn.arnetta.com.tr/image/cache/catalog/urun_resimleri/MODEL-1000x1000.jpg
            ' Varyantlar: MODEL, MODEL-1, MODEL-2, MODEL-3, MODEL-4
            
            Dim baseUrl As String = "https://cdn.arnetta.com.tr/image/cache/catalog/urun_resimleri/"
            Dim sizeSuffix As String = "-1000x1000.jpg"
            
            ' Ana resim ve varyantları dene
            Dim variants As New List(Of String) From {
                $"{modelCode}{sizeSuffix}",           ' 23566-1000x1000.jpg
                $"{modelCode}-1{sizeSuffix}",         ' 23566-1-1000x1000.jpg
                $"{modelCode}-2{sizeSuffix}",         ' 23566-2-1000x1000.jpg
                $"{modelCode}-3{sizeSuffix}",         ' 23566-3-1000x1000.jpg
                $"{modelCode}-4{sizeSuffix}",         ' 23566-4-1000x1000.jpg
                $"{modelCode}-5{sizeSuffix}"          ' 23566-5-1000x1000.jpg
            }
            
            Using client As New WebClient()
                client.Headers.Add("User-Agent", "Mozilla/5.0")
                
                For Each imageVariant As String In variants
                    Dim imageUrl As String = baseUrl & imageVariant
                    
                    Try
                        ' HEAD request - resim var mı kontrol et
                        Dim req As HttpWebRequest = CType(WebRequest.Create(imageUrl), HttpWebRequest)
                        req.Method = "HEAD"
                        req.Timeout = 3000
                        req.UserAgent = "Mozilla/5.0"
                        
                        Using response As HttpWebResponse = CType(req.GetResponse(), HttpWebResponse)
                            If response.StatusCode = HttpStatusCode.OK Then
                                images.Add(imageUrl)
                                LogImage("DEBUG", "SearchArnettaDirect", $"Resim bulundu: {imageUrl}")
                            End If
                        End Using
                    Catch
                        ' Bu varyant yok, devam et
                    End Try
                Next
            End Using
            
            LogImage("INFO", "SearchArnettaDirect", $"{modelCode} için {images.Count} resim bulundu")
            
        Catch ex As Exception
            LogImage("ERROR", "SearchArnettaDirect", $"Hata: {ex.Message}")
        End Try
        
        Return images
    End Function
    
    ''' <summary>
    ''' Ürün sayfasından tüm resimleri scrape et (Arnetta/RolyPoly için)
    ''' </summary>
    Private Function ScrapeProductPageImages(pageUrl As String) As List(Of String)
        Dim images As New List(Of String)
        
        Try
            Using client As New WebClient()
                client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36")
                client.Encoding = System.Text.Encoding.UTF8
                
                Dim html As String = client.DownloadString(pageUrl)
                
                ' Arnetta/RolyPoly sitelerinde ürün resimleri için pattern'ler
                ' Örnek: https://cdn.arnetta.com.tr/image/cache/catalog/urun_resimleri/23566-4-1000x1000.jpg
                Dim patterns As New List(Of String) From {
                    "https://cdn\.arnetta\.com\.tr/image/cache/catalog/[^""'\s]+\.(jpg|jpeg|png)",
                    "https://[^""'\s]*?arnetta\.com\.tr[^""'\s]*?/catalog/[^""'\s]+\.(jpg|jpeg|png)",
                    "https://[^""'\s]*?rolypoly\.com\.tr[^""'\s]*?/catalog/[^""'\s]+\.(jpg|jpeg|png)"
                }
                
                Dim seenImages As New HashSet(Of String)
                
                For Each pattern As String In patterns
                    Dim matches As MatchCollection = Regex.Matches(html, pattern, RegexOptions.IgnoreCase)
                    
                    For Each match As Match In matches
                        Dim imageUrl As String = match.Value.Trim()
                        imageUrl = Regex.Replace(imageUrl, "[""',;)\]]+$", "")
                        
                        ' Sadece büyük boyutlu resimleri al (1000x1000, 800x800)
                        If (imageUrl.Contains("1000x1000") OrElse imageUrl.Contains("800x800") OrElse imageUrl.Contains("500x500")) AndAlso 
                           Not seenImages.Contains(imageUrl) Then
                            images.Add(imageUrl)
                            seenImages.Add(imageUrl)
                            LogImage("DEBUG", "ScrapeProductPageImages", $"Resim bulundu: {imageUrl}")
                        End If
                    Next
                Next
                
                LogImage("INFO", "ScrapeProductPageImages", $"{pageUrl} sayfasından {images.Count} resim çekildi")
                
            End Using
            
        Catch ex As Exception
            LogImage("ERROR", "ScrapeProductPageImages", $"Scraping hatası: {ex.Message}")
        End Try
        
        Return images
    End Function
    
    ''' <summary>
    ''' Barkod prefix'inden marka sitesini belirle
    ''' </summary>
    Private Function GetBrandSiteFromBarcode(barcode As String) As String
        ' İlk 2-3 karakterden markayı tespit et
        If String.IsNullOrEmpty(barcode) OrElse barcode.Length < 2 Then
            Return ""
        End If
        
        Dim prefix As String = barcode.Substring(0, 2).ToUpper()
        
        ' Marka mapping
        Select Case prefix
            Case "RP"
                Return "site:arnetta.com.tr OR site:rolypoly.com.tr"
            Case "AN"
                Return "site:arnetta.com.tr"
            Case Else
                Return ""
        End Select
    End Function
    
    ''' <summary>
    ''' Model kodunu barkoddan çıkar (prefix ve varyant kodu olmadan)
    ''' Örnek: RP23566-4 -> 23566
    ''' </summary>
    Private Function ExtractModelFromBarcode(barcode As String) As String
        If String.IsNullOrEmpty(barcode) Then
            Return barcode
        End If
        
        ' Önce "-" varsa onu kaldır (varyant kodu)
        Dim withoutVariant As String = barcode
        If barcode.Contains("-") Then
            withoutVariant = barcode.Substring(0, barcode.IndexOf("-"))
        End If
        
        ' İlk 2 karakter harf ise onları kaldır (marka prefix'i)
        If withoutVariant.Length > 2 AndAlso Char.IsLetter(withoutVariant(0)) AndAlso Char.IsLetter(withoutVariant(1)) Then
            Return withoutVariant.Substring(2)
        End If
        
        Return withoutVariant
    End Function
    
    ''' <summary>
    ''' Google Images'de arama yap (internal helper)
    ''' </summary>
    Private Function SearchGoogleImages(searchQuery As String) As List(Of String)
        Dim imageUrls As New List(Of String)
        
        Try
            ' Eğer arama terimi barkod gibi görünüyorsa, önce marka sitesinde direkt scraping dene
            Dim brandPrefix As String = ""
            If searchQuery.Length >= 2 AndAlso Char.IsLetter(searchQuery(0)) AndAlso Char.IsLetter(searchQuery(1)) Then
                brandPrefix = searchQuery.Substring(0, 2).ToUpper()
            End If
            
            ' RP prefix ise Arnetta sitesinde direkt ara
            If brandPrefix = "RP" Then
                Dim modelCode As String = ExtractModelFromBarcode(searchQuery)
                Dim arnettaImages As List(Of String) = SearchArnettaDirect(modelCode)
                If arnettaImages.Count > 0 Then
                    LogImage("SUCCESS", "SearchGoogleImages", $"Arnetta sitesinden direkt {arnettaImages.Count} resim bulundu")
                    Return arnettaImages
                End If
            End If
            
            ' Fallback: Google API ile ara - TAM BARKOD kullan
            Dim enhancedQuery As String = searchQuery
            LogImage("INFO", "SearchGoogleImages", $"Google'da arama: tam barkod = {searchQuery}")
            
            ' Google Custom Search API URL
            Dim searchUrl As String = "https://www.googleapis.com/customsearch/v1?" &
                                     $"key={googleSearchApiKey}&" &
                                     $"cx={googleSearchEngineId}&" &
                                     $"q={Uri.EscapeDataString(enhancedQuery)}&" &
                                     "searchType=image&" &
                                     "num=10"
            
            ' HTTP Request
            Using client As New WebClient()
                client.Encoding = System.Text.Encoding.UTF8
                
                Dim response As String = client.DownloadString(searchUrl)
                Dim jsonResponse As JObject = JObject.Parse(response)
                
                If jsonResponse("items") IsNot Nothing Then
                    Dim items As JArray = CType(jsonResponse("items"), JArray)
                    
                    ' İlk öğeden ürün sayfası URL'sini al
                    If items.Count > 0 Then
                        Dim firstItem As JObject = CType(items(0), JObject)
                        
                        ' Ürün sayfası URL'si var mı?
                        Dim productPageUrl As String = ""
                        If firstItem("image") IsNot Nothing AndAlso firstItem("image")("contextLink") IsNot Nothing Then
                            productPageUrl = firstItem("image")("contextLink").ToString()
                            LogImage("INFO", "SearchGoogleImages", $"Ürün sayfası bulundu: {productPageUrl}")
                            
                            ' Eğer Arnetta/RolyPoly sitesiyse, sayfadaki TÜM resimleri al
                            If productPageUrl.Contains("arnetta.com.tr") OrElse productPageUrl.Contains("rolypoly.com.tr") Then
                                Dim productImages As List(Of String) = ScrapeProductPageImages(productPageUrl)
                                If productImages.Count > 0 Then
                                    LogImage("SUCCESS", "SearchGoogleImages", $"Ürün sayfasından {productImages.Count} resim alındı")
                                    Return productImages
                                End If
                            End If
                        End If
                        
                        ' Fallback: Google'dan gelen tüm resimleri al
                        For Each item As JObject In items
                            Dim imageUrl As String = item("link").ToString()
                            imageUrls.Add(imageUrl)
                            LogImage("DEBUG", "SearchGoogleImages", $"Görsel bulundu: {imageUrl}")
                        Next
                    End If
                End If
                
                LogImage("INFO", "SearchGoogleImages", $"'{searchQuery}' için {imageUrls.Count} görsel bulundu")
                Return imageUrls
            End Using
            
        Catch webEx As WebException
            Dim errorResponse As String = ""
            If webEx.Response IsNot Nothing Then
                Using reader As New StreamReader(webEx.Response.GetResponseStream())
                    errorResponse = reader.ReadToEnd()
                End Using
            End If
            
            LogImage("ERROR", "SearchGoogleImages", $"API hatası: {webEx.Message}, Response: {errorResponse}")
            Return imageUrls
            
        Catch ex As Exception
            LogImage("ERROR", "SearchGoogleImages", $"Genel hata: {ex.Message}")
            Return imageUrls
        End Try
    End Function
    
    ''' <summary>
    ''' Model + Renk + Marka ile görsel arama
    ''' </summary>
    Public Function FindImagesByAttributes(model As String, renk As String, marka As String, kategori As String) As List(Of String)
        Try
            ' Akıllı arama sorgusu oluştur
            Dim searchQuery As String = $"{marka} {model} {renk} {kategori} product image"
            
            LogImage("INFO", "FindImagesByAttributes", $"Öznitelik araması: {searchQuery}")
            
            If String.IsNullOrEmpty(googleSearchApiKey) OrElse String.IsNullOrEmpty(googleSearchEngineId) Then
                LogImage("ERROR", "FindImagesByAttributes", "Google API key veya Search Engine ID eksik!")
                Return New List(Of String)
            End If
            
            Dim searchUrl As String = "https://www.googleapis.com/customsearch/v1?" &
                                     $"key={googleSearchApiKey}&" &
                                     $"cx={googleSearchEngineId}&" &
                                     $"q={Uri.EscapeDataString(searchQuery)}&" &
                                     $"searchType=image&" &
                                     $"num=10&" &
                                     $"imgSize=large&" &
                                     $"fileType=jpg,png&" &
                                     $"safe=active"
            
            Using client As New WebClient()
                client.Encoding = System.Text.Encoding.UTF8
                
                Dim response As String = client.DownloadString(searchUrl)
                Dim jsonResponse As JObject = JObject.Parse(response)
                
                Dim imageUrls As New List(Of String)
                
                If jsonResponse("items") IsNot Nothing Then
                    For Each item As JObject In jsonResponse("items")
                        Dim imageUrl As String = item("link").ToString()
                        imageUrls.Add(imageUrl)
                    Next
                End If
                
                LogImage("SUCCESS", "FindImagesByAttributes", $"{imageUrls.Count} adet görsel bulundu")
                Return imageUrls
            End Using
            
        Catch ex As Exception
            LogImage("ERROR", "FindImagesByAttributes", $"Hata: {ex.Message}")
            Return New List(Of String)
        End Try
    End Function
    
    ''' <summary>
    ''' AI Vision ile görseli doğrula (basit versiyon)
    ''' </summary>
    Public Function ValidateImageSimple(imageUrl As String) As Dictionary(Of String, Object)
        Try
            LogImage("INFO", "ValidateImageSimple", $"Görsel kontrol ediliyor: {imageUrl}")
            
            ' Basit validasyon: URL formatı ve erişilebilirlik
            If Not imageUrl.StartsWith("http") Then
                Return New Dictionary(Of String, Object) From {
                    {"is_valid", False},
                    {"confidence_score", 0},
                    {"reason", "Geçersiz URL formatı"}
                }
            End If
            
            ' URL'ye erişim kontrolü
            Try
                Using client As New WebClient()
                    client.Encoding = System.Text.Encoding.UTF8
                    client.OpenRead(imageUrl).Close()
                End Using
                
                ' Basit validasyon: Erişilebilir
                Return New Dictionary(Of String, Object) From {
                    {"is_valid", True},
                    {"confidence_score", 70},
                    {"reason", "URL erişilebilir"}
                }
                
            Catch
                Return New Dictionary(Of String, Object) From {
                    {"is_valid", False},
                    {"confidence_score", 0},
                    {"reason", "URL'ye erişilemiyor"}
                }
            End Try
            
        Catch ex As Exception
            LogImage("ERROR", "ValidateImageSimple", $"Hata: {ex.Message}")
            Return New Dictionary(Of String, Object) From {
                {"is_valid", False},
                {"confidence_score", 0},
                {"reason", "Doğrulama hatası"}
            }
        End Try
    End Function
    
    ''' <summary>
    ''' Görseli indir ve optimize et
    ''' </summary>
    Public Function DownloadAndOptimizeImage(imageUrl As String, barcode As String, productName As String) As String
        Try
            LogImage("INFO", "DownloadAndOptimizeImage", $"Görsel indiriliyor: {imageUrl}")
            
            ' 1. Görseli indir
            Using client As New WebClient()
                Dim imageBytes As Byte() = client.DownloadData(imageUrl)
                
                ' 2. Dosya adı oluştur
                Dim timestamp As String = DateTime.Now.ToString("yyyyMMddHHmmss")
                Dim safeProductName As String = MakeSafeFileName(productName)
                Dim fileName As String = $"{barcode}_{safeProductName}_{timestamp}.jpg"
                Dim fullPath As String = Path.Combine(imageFolderPath, fileName)
                
                ' 3. Geçici olarak kaydet
                File.WriteAllBytes(fullPath, imageBytes)
                
                ' 4. Optimize et
                Dim optimizedPath As String = OptimizeImage(fullPath)
                
                ' 5. Orjinal dosyayı sil (optimize edilmiş versiyonu kullan)
                If File.Exists(fullPath) AndAlso fullPath <> optimizedPath Then
                    File.Delete(fullPath)
                End If
                
                LogImage("SUCCESS", "DownloadAndOptimizeImage", $"Görsel kaydedildi: {optimizedPath}")
                Return optimizedPath
            End Using
            
        Catch ex As Exception
            LogImage("ERROR", "DownloadAndOptimizeImage", $"Hata: {ex.Message}")
            Return ""
        End Try
    End Function
    
    ''' <summary>
    ''' Görseli optimize et (boyut, kalite)
    ''' </summary>
    Private Function OptimizeImage(imagePath As String) As String
        Try
            Using originalImage As Image = Image.FromFile(imagePath)
                ' Hedef boyut: 1600x1600 (e-ticaret standardı)
                Dim targetWidth As Integer = 1600
                Dim targetHeight As Integer = 1600
                
                ' Aspect ratio koru
                Dim ratio As Double = Math.Min(targetWidth / CDbl(originalImage.Width), 
                                              targetHeight / CDbl(originalImage.Height))
                
                Dim newWidth As Integer = CInt(originalImage.Width * ratio)
                Dim newHeight As Integer = CInt(originalImage.Height * ratio)
                
                ' Yeni görsel oluştur
                Using resizedImage As New Bitmap(newWidth, newHeight)
                    Using g As Graphics = Graphics.FromImage(resizedImage)
                        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                        g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                        g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
                        g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                        
                        g.DrawImage(originalImage, 0, 0, newWidth, newHeight)
                    End Using
                    
                    ' Optimized dosya adı
                    Dim optimizedPath As String = imagePath.Replace(".jpg", "_opt.jpg")
                    
                    ' JPEG encoder ayarları (kalite: 85%)
                    Dim jpegEncoder As ImageCodecInfo = GetEncoderInfo("image/jpeg")
                    Dim encoderParams As New EncoderParameters(1)
                    encoderParams.Param(0) = New EncoderParameter(Encoder.Quality, 85L)
                    
                    ' Kaydet
                    resizedImage.Save(optimizedPath, jpegEncoder, encoderParams)
                    
                    LogImage("SUCCESS", "OptimizeImage", $"Görsel optimize edildi: {optimizedPath}")
                    Return optimizedPath
                End Using
            End Using
            
        Catch ex As Exception
            LogImage("ERROR", "OptimizeImage", $"Hata: {ex.Message}")
            Return imagePath
        End Try
    End Function
    
    ''' <summary>
    ''' JPEG encoder bilgisi al
    ''' </summary>
    Private Function GetEncoderInfo(mimeType As String) As ImageCodecInfo
        Dim encoders As ImageCodecInfo() = ImageCodecInfo.GetImageEncoders()
        For Each encoder As ImageCodecInfo In encoders
            If encoder.MimeType = mimeType Then
                Return encoder
            End If
        Next
        Return Nothing
    End Function
    
    ''' <summary>
    ''' Dosya adı için güvenli string
    ''' </summary>
    Private Function MakeSafeFileName(fileName As String) As String
        Dim invalidChars As Char() = Path.GetInvalidFileNameChars()
        Dim safeName As String = String.Join("_", fileName.Split(invalidChars))
        Return safeName.Substring(0, Math.Min(30, safeName.Length))
    End Function
    
    ''' <summary>
    ''' Görseli veritabanına kaydet
    ''' </summary>
    Public Async Function SaveImageToDatabase(barcode As String, imagePath As String, imageUrl As String, isMainImage As Boolean) As Task(Of Boolean)
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                
                ' Stok ID bul - tbStokBarkodu tablosundan
                Dim stokId As Object = Nothing
                Dim sModel As String = ""
                
                ' Önce tbStokBarkodu tablosundan barkod ile ara
                Try
                    Dim cmd1 As New OleDb.OleDbCommand(
                        "SELECT TOP 1 tbStok.nStokID, tbStok.sKodu FROM tbStokBarkodu " &
                        "INNER JOIN tbStok ON tbStok.nStokID = tbStokBarkodu.nStokID " &
                        "WHERE tbStokBarkodu.sBarkod = ?", conn)
                    cmd1.Parameters.AddWithValue("?", barcode)
                    
                    Using reader = cmd1.ExecuteReader()
                        If reader.Read() Then
                            stokId = reader("nStokID")
                            sModel = reader("sKodu").ToString().Trim()
                            LogImage("INFO", "SaveImageToDatabase", $"Barkod bulundu: {barcode} -> StokID: {stokId}, sModel: {sModel}")
                        End If
                    End Using
                Catch ex As Exception
                    LogImage("ERROR", "SaveImageToDatabase", $"tbStokBarkodu sorgu hatası: {ex.Message}")
                End Try
                
                ' Bulunamadıysa tbStok.sKodu'dan dene
                If stokId Is Nothing Then
                    Try
                        Dim cmd2 As New OleDb.OleDbCommand("SELECT TOP 1 nStokID, sKodu FROM tbStok WHERE sKodu = ?", conn)
                        cmd2.Parameters.AddWithValue("?", barcode)
                        
                        Using reader = cmd2.ExecuteReader()
                            If reader.Read() Then
                                stokId = reader("nStokID")
                                sModel = reader("sKodu").ToString().Trim()
                                LogImage("INFO", "SaveImageToDatabase", $"Ürün kodu bulundu: {barcode} -> StokID: {stokId}, sModel: {sModel}")
                            End If
                        End Using
                    Catch ex As Exception
                        LogImage("ERROR", "SaveImageToDatabase", $"tbStok sorgu hatası: {ex.Message}")
                    End Try
                End If
                
                If stokId Is Nothing Then
                    Dim errorMsg As String = $"Ürün bulunamadı! Barkod/Kod: {barcode}"
                    LogImage("WARNING", "SaveImageToDatabase", errorMsg)
                    MessageBox.Show(errorMsg, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If
                
                ' R2'ye upload et
                Dim r2Url As String = ""
                Try
                    ' Resmi byte array'e çevir (URL'den indir)
                    Dim imageBytes As Byte()
                    Using webClient As New WebClient()
                        webClient.Headers.Add("User-Agent", "Mozilla/5.0")
                        imageBytes = webClient.DownloadData(imageUrl)
                    End Using
                    
                    ' Sıra numarasını al
                    Dim nSira As Integer = GetNextSlotNumber(sModel, conn)
                    
                    ' R2 dosya adı: sModel_nSira.jpg
                    Dim fileName As String = $"{sModel}_{nSira}.jpg"
                    Dim objectKey As String = $"products/{sModel}/{fileName}"
                    
                    LogImage("INFO", "SaveImageToDatabase", $"R2'ye yükleniyor: {objectKey}")
                    r2Url = Await R2Helpers.R2UploadFromBytesAsync(imageBytes, objectKey, "image/jpeg")
                    
                    If Not String.IsNullOrEmpty(r2Url) Then
                        LogImage("SUCCESS", "SaveImageToDatabase", $"R2'ye yüklendi: {r2Url}")
                    End If
                Catch ex As Exception
                    LogImage("ERROR", "SaveImageToDatabase", $"R2 upload hatası: {ex.Message}")
                    ' R2 hatası fatal değil, devam et
                End Try
                
                ' Görseli ekle - doğru kolon isimleri: sModel ve yol
                Dim insertCmd As New OleDb.OleDbCommand(
                    "INSERT INTO tbStokResim (sModel, yol, nStokID, bAnaResim, dteKayitTarihi) VALUES (?, ?, ?, ?, ?)", conn)
                
                insertCmd.Parameters.AddWithValue("?", sModel)
                insertCmd.Parameters.AddWithValue("?", If(String.IsNullOrEmpty(r2Url), imagePath, r2Url))
                insertCmd.Parameters.AddWithValue("?", stokId)
                insertCmd.Parameters.AddWithValue("?", If(isMainImage, 1, 0))
                insertCmd.Parameters.AddWithValue("?", DateTime.Now)
                
                Dim rowsAffected As Integer = insertCmd.ExecuteNonQuery()
                
                If rowsAffected > 0 Then
                    LogImage("SUCCESS", "SaveImageToDatabase", $"Görsel eklendi: Kod={sModel}, Yol={If(String.IsNullOrEmpty(r2Url), imagePath, r2Url)}")
                    Return True
                Else
                    LogImage("ERROR", "SaveImageToDatabase", "ExecuteNonQuery 0 satır döndürdü")
                    Return False
                End If
            End Using
            
        Catch ex As Exception
            Dim errorMsg As String = $"Veritabanı hatası: {ex.Message}"
            LogImage("ERROR", "SaveImageToDatabase", errorMsg)
            MessageBox.Show(errorMsg & vbCrLf & vbCrLf & "SQL: INSERT INTO tbStokResim", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    
    ''' <summary>
    ''' Sıradaki slot numarasını al
    ''' </summary>
    Private Function GetNextSlotNumber(sModel As String, conn As OleDb.OleDbConnection) As Integer
        Try
            Dim cmd As New OleDb.OleDbCommand(
                "SELECT COUNT(*) FROM tbStokResim WHERE sModel = ?", conn)
            cmd.Parameters.AddWithValue("?", sModel)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count + 1
        Catch
            Return 1
        End Try
    End Function
    
    ''' <summary>
    ''' Komple otomatik görsel bulma ve ekleme
    ''' </summary>
    Public Async Function AutoFindAndAddImage(barcode As String, model As String, renk As String, 
                                       marka As String, kategori As String, productName As String) As Task(Of Dictionary(Of String, Object))
        Try
            LogImage("INFO", "AutoFindAndAddImage", $"Otomatik işlem başlatılıyor: {productName}")
            
            Dim result As New Dictionary(Of String, Object) From {
                {"success", False},
                {"method", ""},
                {"image_url", ""},
                {"image_path", ""}
            }
            
            ' 1. Barkod ile ara
            Dim imageUrls As List(Of String) = FindImagesByBarcode(barcode)
            
            If imageUrls.Count = 0 Then
                LogImage("WARNING", "AutoFindAndAddImage", "Barkod ile bulunamadı, özniteliklerle aranıyor")
                imageUrls = FindImagesByAttributes(model, renk, marka, kategori)
            End If
            
            If imageUrls.Count = 0 Then
                LogImage("ERROR", "AutoFindAndAddImage", "Hiç görsel bulunamadı")
                result("method") = "no_images_found"
                Return result
            End If
            
            ' 2. İlk geçerli görseli seç (basit versiyon)
            Dim selectedImageUrl As String = ""
            
            For Each imageUrl As String In imageUrls.Take(3) ' İlk 3 görseli kontrol et
                Dim validation As Dictionary(Of String, Object) = ValidateImageSimple(imageUrl)
                
                If Convert.ToBoolean(validation("is_valid")) Then
                    selectedImageUrl = imageUrl
                    Exit For
                End If
            Next
            
            If String.IsNullOrEmpty(selectedImageUrl) Then
                LogImage("WARNING", "AutoFindAndAddImage", "Geçerli görsel bulunamadı")
                result("method") = "no_valid_images"
                Return result
            End If
            
            ' 3. Görseli indir ve optimize et
            Dim localImagePath As String = DownloadAndOptimizeImage(selectedImageUrl, barcode, productName)
            
            If String.IsNullOrEmpty(localImagePath) Then
                LogImage("ERROR", "AutoFindAndAddImage", "Görsel indirilemedi")
                result("method") = "download_failed"
                Return result
            End If
            
            ' 4. Veritabanına kaydet
            Dim saved As Boolean = Await SaveImageToDatabase(barcode, localImagePath, selectedImageUrl, True)
            
            If saved Then
                result("success") = True
                result("method") = "auto_ai"
                result("image_url") = selectedImageUrl
                result("image_path") = localImagePath
                
                LogImage("SUCCESS", "AutoFindAndAddImage", $"✅ Görsel işlemi başarılı: {productName}")
            Else
                result("method") = "database_save_failed"
            End If
            
            Return result
            
        Catch ex As Exception
            LogImage("ERROR", "AutoFindAndAddImage", $"Hata: {ex.Message}")
            Return New Dictionary(Of String, Object) From {
                {"success", False},
                {"method", "error"},
                {"error_message", ex.Message}
            }
        End Try
    End Function
    
    ''' <summary>
    ''' E-ticaret sitelerinden görsel ara (Google API olmadan)
    ''' </summary>
    Private Function SearchEcommerceSites(barcode As String) As List(Of String)
        Dim imageUrls As New List(Of String)
        
        Try
            LogImage("INFO", "SearchEcommerceSites", $"E-ticaret sitelerinde arama başlıyor: {barcode}")
            
            ' ÖNCELİK SIRASI: Trendyol > Hepsiburada > N11
            
            ' 1. Trendyol'dan ara (en popüler)
            Dim trendyolImages As List(Of String) = SearchTrendyol(barcode)
            imageUrls.AddRange(trendyolImages)
            LogImage("INFO", "SearchEcommerceSites", $"Trendyol: {trendyolImages.Count} resim")
            
            ' 2. Hepsiburada'dan ara
            Dim hepsiburadaImages As List(Of String) = SearchHepsiburada(barcode)
            imageUrls.AddRange(hepsiburadaImages)
            LogImage("INFO", "SearchEcommerceSites", $"Hepsiburada: {hepsiburadaImages.Count} resim")
            
            ' 3. N11'den ara
            Dim n11Images As List(Of String) = SearchN11(barcode)
            imageUrls.AddRange(n11Images)
            LogImage("INFO", "SearchEcommerceSites", $"N11: {n11Images.Count} resim")
            
            LogImage("SUCCESS", "SearchEcommerceSites", $"Toplam {imageUrls.Count} görsel bulundu (Trendyol:{trendyolImages.Count}, Hepsiburada:{hepsiburadaImages.Count}, N11:{n11Images.Count})")
            
        Catch ex As Exception
            LogImage("ERROR", "SearchEcommerceSites", $"Hata: {ex.Message}")
        End Try
        
        Return imageUrls
    End Function
    
    ''' <summary>
    ''' Trendyol'dan görsel ara
    ''' </summary>
    Private Function SearchTrendyol(barcode As String) As List(Of String)
        Dim images As New List(Of String)
        
        Try
            Dim searchUrl As String = $"https://www.trendyol.com/sr?q={barcode}"
            
            Using client As New WebClient()
                client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36")
                Dim html As String = client.DownloadString(searchUrl)
                
                ' STRATEJI: İlk ürünün ID prefix'ini tespit et (örn: ty1700) ve sadece o prefix'li resimleri al
                ' Pattern: https://cdn.dsmcdn.com/ty1700/prod/...
                Dim allImagePattern As String = "https://cdn\.dsmcdn\.com/(ty\d+)/prod/[^""'\s]*?\.(jpg|jpeg|png)"
                Dim allMatches As MatchCollection = Regex.Matches(html, allImagePattern, RegexOptions.IgnoreCase)
                
                If allMatches.Count = 0 Then
                    LogImage("WARNING", "SearchTrendyol", "Hiç /prod/ resim bulunamadı")
                    Return images
                End If
                
                ' İlk resmin prefix'ini al (bu ilk ürünün ID'si)
                Dim firstMatch As Match = allMatches(0)
                Dim firstPrefix As String = firstMatch.Groups(1).Value ' ty1700, ty1788 vs.
                
                LogImage("INFO", "SearchTrendyol", $"İlk ürün prefix'i tespit edildi: {firstPrefix}")
                
                ' Sadece aynı prefix'e sahip resimleri al
                Dim seenImages As New HashSet(Of String)
                
                For Each match As Match In allMatches
                    Dim currentPrefix As String = match.Groups(1).Value
                    
                    ' Sadece ilk ürünün prefix'i ile eşleşenleri al
                    If currentPrefix = firstPrefix Then
                        Dim imageUrl As String = match.Value.Trim()
                        imageUrl = Regex.Replace(imageUrl, "[""',;)\]]+$", "")
                        
                        If Not seenImages.Contains(imageUrl) AndAlso images.Count < 10 Then
                            images.Add(imageUrl)
                            seenImages.Add(imageUrl)
                            LogImage("DEBUG", "SearchTrendyol", $"Aynı ürün resmi: {imageUrl}")
                        End If
                        
                        If images.Count >= 10 Then Exit For
                    End If
                Next
                
                LogImage("INFO", "SearchTrendyol", $"Trendyol'da {firstPrefix} prefix'li {images.Count} resim bulundu")
            End Using
            
        Catch ex As Exception
            LogImage("ERROR", "SearchTrendyol", $"Hata: {ex.Message}")
        End Try
        
        Return images
    End Function
    
    ''' <summary>
    ''' N11'den görsel ara
    ''' </summary>
    Private Function SearchN11(barcode As String) As List(Of String)
        Dim images As New List(Of String)
        
        Try
            Dim searchUrl As String = $"https://www.n11.com/arama?q={barcode}"
            
            Using client As New WebClient()
                client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36")
                Dim html As String = client.DownloadString(searchUrl)
                
                ' N11'in ürün resim URL'lerini bul
                Dim pattern As String = "https://n11scdn[^""']+"
                Dim matches As MatchCollection = Regex.Matches(html, pattern)
                
                For Each match As Match In matches
                    Dim imageUrl As String = match.Value
                    If Not images.Contains(imageUrl) Then
                        images.Add(imageUrl)
                        If images.Count >= 5 Then Exit For
                    End If
                Next
                
                LogImage("INFO", "SearchN11", $"N11'de {images.Count} görsel bulundu")
            End Using
            
        Catch ex As Exception
            LogImage("ERROR", "SearchN11", $"Hata: {ex.Message}")
        End Try
        
        Return images
    End Function
    
    ''' <summary>
    ''' Hepsiburada'dan görsel ara
    ''' </summary>
    Private Function SearchHepsiburada(barcode As String) As List(Of String)
        Dim images As New List(Of String)
        
        Try
            Dim searchUrl As String = $"https://www.hepsiburada.com/ara?q={barcode}"
            
            Using client As New WebClient()
                client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36")
                Dim html As String = client.DownloadString(searchUrl)
                
                ' STRATEJI: İlk ürünün ID'sini tespit et ve sadece o ID'ye ait resimleri al
                ' Pattern: https://productimages.hepsiburada.net/s/123/1000-1000/...
                Dim allImagePattern As String = "https://productimages\.hepsiburada\.net/s/(\d+)/(1000-1000|550-550|375-375)/[^""'\s]*?\.(jpg|jpeg|png)"
                Dim allMatches As MatchCollection = Regex.Matches(html, allImagePattern, RegexOptions.IgnoreCase)
                
                If allMatches.Count = 0 Then
                    LogImage("WARNING", "SearchHepsiburada", "Hiç resim bulunamadı")
                    Return images
                End If
                
                ' İlk resmin ürün ID'sini al
                Dim firstMatch As Match = allMatches(0)
                Dim firstProductId As String = firstMatch.Groups(1).Value ' 123, 456 vs.
                
                LogImage("INFO", "SearchHepsiburada", $"İlk ürün ID'si tespit edildi: {firstProductId}")
                
                ' Sadece aynı ürün ID'sine sahip resimleri al
                Dim seenImages As New HashSet(Of String)
                
                For Each match As Match In allMatches
                    Dim currentProductId As String = match.Groups(1).Value
                    
                    ' Sadece ilk ürünün ID'si ile eşleşenleri al
                    If currentProductId = firstProductId Then
                        Dim imageUrl As String = match.Value.Trim()
                        imageUrl = Regex.Replace(imageUrl, "[""',;)\]]+$", "")
                        
                        ' 1000-1000 boyutundakileri tercih et
                        If Not seenImages.Contains(imageUrl) AndAlso images.Count < 10 Then
                            images.Add(imageUrl)
                            seenImages.Add(imageUrl)
                            LogImage("DEBUG", "SearchHepsiburada", $"Aynı ürün resmi: {imageUrl}")
                        End If
                        
                        If images.Count >= 10 Then Exit For
                    End If
                Next
                
                LogImage("INFO", "SearchHepsiburada", $"Hepsiburada'da ID:{firstProductId} için {images.Count} resim bulundu")
            End Using
            
        Catch ex As Exception
            LogImage("ERROR", "SearchHepsiburada", $"Hata: {ex.Message}")
        End Try
        
        Return images
    End Function
    
    ''' <summary>
    ''' Google API bilgilerini kaydet (test için)
    ''' </summary>
    Public Sub SetupGoogleAPI()
        Try
            ' API bilgilerini kaydet
            Dim apiKey As String = "AIzaSyC_dOGn3xgVmBgkJv4b6_03StemDSbrWIg"
            Dim engineId As String = "d3830d60b868641c4"
            
            SaveApiKeys(apiKey, engineId)
            LogImage("SUCCESS", "SetupGoogleAPI", $"Google API kurulumu tamamlandı - Key: {apiKey.Substring(0, 10)}..., CX: {engineId}")
            
        Catch ex As Exception
            LogImage("ERROR", "SetupGoogleAPI", $"Google API kurulum hatası: {ex.Message}")
        End Try
    End Sub
    
    ''' <summary>
    ''' Google API test et
    ''' </summary>
    Public Function TestGoogleAPI(testBarcode As String) As Boolean
        Try
            LogImage("INFO", "TestGoogleAPI", $"Google API test ediliyor: {testBarcode}")
            
            Dim results As List(Of String) = FindImagesByBarcode(testBarcode)
            
            If results.Count > 0 Then
                LogImage("SUCCESS", "TestGoogleAPI", $"✅ Google API çalışıyor! {results.Count} görsel bulundu")
                For i As Integer = 0 To Math.Min(2, results.Count - 1)
                    LogImage("INFO", "TestGoogleAPI", $"Örnek görsel {i + 1}: {results(i)}")
                Next
                Return True
            Else
                LogImage("WARNING", "TestGoogleAPI", "⚠️ Google API çalışıyor ama görsel bulunamadı")
                Return False
            End If
            
        Catch ex As Exception
            LogImage("ERROR", "TestGoogleAPI", $"❌ Google API test hatası: {ex.Message}")
            Return False
        End Try
    End Function
    
    ''' <summary>
    ''' Log fonksiyonu
    ''' </summary>
    Private Sub LogImage(level As String, functionName As String, message As String)
        Try
            Dim timestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            Dim logMessage As String = $"[{timestamp}] [{level}] [{functionName}] {message}"
            
            Console.WriteLine(logMessage)
            File.AppendAllText(logFilePath, logMessage & vbCrLf)
            
        Catch
            ' Log hatası olsa bile uygulama devam etsin
        End Try
    End Sub
    
End Class
