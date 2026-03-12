Imports System.Net
Imports System.IO
Imports System.Text

''' <summary>
''' Business Smart Desktop API Client
''' FTP ve doğrudan SQL bağlantıları yerine güvenli API kullanımı sağlar
''' </summary>
Public Class ApiClient
    
    Private Shared ReadOnly API_BASE_URL As String = "https://desktop.barkodyazilimevi.com"
    Private Shared ReadOnly API_KEY As String = "BSmart2024Desktop!@#SecureKey"
    
    ''' <summary>
    ''' Güncelleme dosyasının bilgisini API'den alır (FTP GetDateTimestamp yerine)
    ''' </summary>
    Public Shared Function GetUpdateFileInfo(fileName As String, platform As String) As UpdateFileInfo
        Dim result As New UpdateFileInfo()
        result.Success = False
        
        Try
            ' TLS 1.2 kullan
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            
            Dim url As String = $"{API_BASE_URL}/api/update/info?file={platform}/{fileName}"
            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Method = "GET"
            request.Headers.Add("X-Api-Key", API_KEY)
            request.Timeout = 30000
            
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(response.GetResponseStream())
                    Dim json As String = reader.ReadToEnd()
                    
                    ' Basit JSON parsing
                    If json.Contains("""success"":true") OrElse json.Contains("""success"": true") Then
                        result.Success = True
                        
                        ' lastModified parse et
                        Dim lastModifiedStart As Integer = json.IndexOf("""lastModified"":")
                        If lastModifiedStart > 0 Then
                            Dim valueStart As Integer = json.IndexOf("""", lastModifiedStart + 15) + 1
                            Dim valueEnd As Integer = json.IndexOf("""", valueStart)
                            If valueEnd > valueStart Then
                                Dim dateStr As String = json.Substring(valueStart, valueEnd - valueStart)
                                DateTime.TryParse(dateStr, result.LastModified)
                            End If
                        End If
                        
                        ' fileSize parse et
                        Dim fileSizeStart As Integer = json.IndexOf("""fileSize"":")
                        If fileSizeStart > 0 Then
                            Dim valueStart As Integer = fileSizeStart + 11
                            Dim valueEnd As Integer = json.IndexOfAny(New Char() {","c, "}"c}, valueStart)
                            If valueEnd > valueStart Then
                                Long.TryParse(json.Substring(valueStart, valueEnd - valueStart).Trim(), result.FileSize)
                            End If
                        End If
                    End If
                End Using
            End Using
            
        Catch ex As Exception
            Debug.WriteLine("[ApiClient.GetUpdateFileInfo] Hata: " & ex.Message)
            result.Success = False
            result.ErrorMessage = ex.Message
        End Try
        
        Return result
    End Function
    
    ''' <summary>
    ''' Güncelleme dosyasını API'den indirir (FTP DownloadFile yerine)
    ''' </summary>
    Public Shared Function DownloadUpdateFile(fileName As String, platform As String, localPath As String) As Boolean
        Try
            ' TLS 1.2 kullan
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            
            Dim url As String = $"{API_BASE_URL}/api/update/download?file={platform}/{fileName}"
            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Method = "GET"
            request.Headers.Add("X-Api-Key", API_KEY)
            request.Timeout = 300000 ' 5 dakika timeout - büyük dosyalar için
            
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Using responseStream As Stream = response.GetResponseStream()
                    ' Hedef klasörü oluştur
                    Dim dir As String = Path.GetDirectoryName(localPath)
                    If Not Directory.Exists(dir) Then
                        Directory.CreateDirectory(dir)
                    End If
                    
                    ' Dosyayı kaydet
                    Using fileStream As New FileStream(localPath, FileMode.Create, FileAccess.Write)
                        responseStream.CopyTo(fileStream)
                    End Using
                End Using
            End Using
            
            Debug.WriteLine("[ApiClient.DownloadUpdateFile] Başarılı: " & fileName)
            Return True
            
        Catch ex As Exception
            Debug.WriteLine("[ApiClient.DownloadUpdateFile] Hata: " & ex.Message)
            Return False
        End Try
    End Function
    
    ''' <summary>
    ''' Yedek dosyasını API'ye yükler (FTP Upload yerine)
    ''' </summary>
    Public Shared Function UploadBackup(localFilePath As String, clientId As String) As Boolean
        Try
            If Not File.Exists(localFilePath) Then
                Return False
            End If
            
            ' TLS 1.2 kullan
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            
            Dim url As String = $"{API_BASE_URL}/api/backup/upload"
            Dim boundary As String = "----" & DateTime.Now.Ticks.ToString("x")
            
            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Method = "POST"
            request.ContentType = "multipart/form-data; boundary=" & boundary
            request.Headers.Add("X-Api-Key", API_KEY)
            request.Headers.Add("X-Client-Id", clientId)
            request.Timeout = 600000 ' 10 dakika timeout
            
            Using requestStream As Stream = request.GetRequestStream()
                Dim fileBytes As Byte() = File.ReadAllBytes(localFilePath)
                Dim fileName As String = Path.GetFileName(localFilePath)
                
                ' Multipart form data oluştur
                Dim header As String = $"--{boundary}" & vbCrLf &
                    $"Content-Disposition: form-data; name=""file""; filename=""{fileName}""" & vbCrLf &
                    "Content-Type: application/octet-stream" & vbCrLf & vbCrLf
                
                Dim headerBytes As Byte() = Encoding.UTF8.GetBytes(header)
                Dim footerBytes As Byte() = Encoding.UTF8.GetBytes(vbCrLf & $"--{boundary}--" & vbCrLf)
                
                requestStream.Write(headerBytes, 0, headerBytes.Length)
                requestStream.Write(fileBytes, 0, fileBytes.Length)
                requestStream.Write(footerBytes, 0, footerBytes.Length)
            End Using
            
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Debug.WriteLine("[ApiClient.UploadBackup] Başarılı: " & Path.GetFileName(localFilePath))
                Return response.StatusCode = HttpStatusCode.OK
            End Using
            
        Catch ex As Exception
            Debug.WriteLine("[ApiClient.UploadBackup] Hata: " & ex.Message)
            Return False
        End Try
    End Function
    
    ''' <summary>
    ''' Lisans doğrulama (Doğrudan SQL bağlantısı yerine)
    ''' </summary>
    Public Shared Function VerifyLicense(licenseKey As String, machineId As String) As LicenseInfo
        Dim result As New LicenseInfo()
        result.IsValid = False
        
        Try
            ' TLS 1.2 kullan
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            
            Dim url As String = $"{API_BASE_URL}/api/license/verify"
            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Method = "POST"
            request.ContentType = "application/json"
            request.Headers.Add("X-Api-Key", API_KEY)
            request.Timeout = 30000
            
            ' JSON body
            Dim jsonBody As String = "{""licenseKey"":""" & licenseKey & """,""machineId"":""" & machineId & """}"
            Dim bodyBytes As Byte() = Encoding.UTF8.GetBytes(jsonBody)
            
            Using requestStream As Stream = request.GetRequestStream()
                requestStream.Write(bodyBytes, 0, bodyBytes.Length)
            End Using
            
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(response.GetResponseStream())
                    Dim json As String = reader.ReadToEnd()
                    
                    result.IsValid = json.Contains("""isValid"":true") OrElse json.Contains("""isValid"": true")
                    
                    ' Firma adını parse et
                    result.FirmaAdi = ParseJsonString(json, "firmaAdi")
                    
                    ' Mesajı parse et
                    result.Message = ParseJsonString(json, "message")
                    
                    ' OzelNot parse et
                    result.OzelNot = ParseJsonString(json, "ozelNot")
                    
                    ' Parametre1, Parametre2 parse et
                    result.Parametre1 = ParseJsonString(json, "parametre1")
                    result.Parametre2 = ParseJsonString(json, "parametre2")
                    
                    ' ExpiryDate parse et
                    Dim expiryStr As String = ParseJsonString(json, "expiryDate")
                    If Not String.IsNullOrEmpty(expiryStr) Then
                        DateTime.TryParse(expiryStr, result.ExpiryDate)
                    End If
                End Using
            End Using
            
        Catch ex As Exception
            Debug.WriteLine("[ApiClient.VerifyLicense] Hata: " & ex.Message)
            result.IsValid = False
            result.Message = "Bağlantı hatası: " & ex.Message
        End Try
        
        Return result
    End Function
    
    ''' <summary>
    ''' Helper: JSON string parse - null değerleri boş string olarak döndürür
    ''' </summary>
    Private Shared Function ParseJsonString(json As String, fieldName As String) As String
        Dim searchKey As String = """" & fieldName & """:"
        Dim startIdx As Integer = json.IndexOf(searchKey)
        If startIdx < 0 Then Return ""

        startIdx += searchKey.Length
        ' Skip whitespace
        While startIdx < json.Length AndAlso json(startIdx) = " "c
            startIdx += 1
        End While

        If startIdx >= json.Length Then Return ""

        ' Check for null value
        If startIdx + 4 <= json.Length AndAlso json.Substring(startIdx, 4) = "null" Then
            Return ""
        End If
        
        ' Check if it's a string value (starts with quote)
        If json(startIdx) = """"c Then
            startIdx += 1 ' Skip opening quote
            Dim endIdx As Integer = json.IndexOf(""""c, startIdx)
            If endIdx > startIdx Then
                Return json.Substring(startIdx, endIdx - startIdx)
            ElseIf endIdx = startIdx Then
                Return "" ' Empty string ""
            End If
        Else
            ' Non-string value (number, boolean)
            Dim endIdx As Integer = json.IndexOfAny(New Char() {","c, "}"c}, startIdx)
            If endIdx > startIdx Then
                Dim value As String = json.Substring(startIdx, endIdx - startIdx).Trim()
                If value = "null" Then Return ""
                Return value
            End If
        End If

        Return ""
    End Function
    
    ''' <summary>
    ''' Lisans aktivasyonu - MAC ID kaydet
    ''' </summary>
    Public Shared Function ActivateLicense(licenseKey As String, machineId As String, computerName As String) As Boolean
        Try
            ' TLS 1.2 kullan
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            
            Dim url As String = $"{API_BASE_URL}/api/license/activate"
            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Method = "POST"
            request.ContentType = "application/json"
            request.Headers.Add("X-Api-Key", API_KEY)
            request.Timeout = 30000
            
            ' JSON body
            Dim jsonBody As String = "{" &
                """licenseKey"":""" & licenseKey & """," &
                """machineId"":""" & machineId & """," &
                """computerName"":""" & computerName & """" &
                "}"
            Dim bodyBytes As Byte() = Encoding.UTF8.GetBytes(jsonBody)
            
            Using requestStream As Stream = request.GetRequestStream()
                requestStream.Write(bodyBytes, 0, bodyBytes.Length)
            End Using
            
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(response.GetResponseStream())
                    Dim json As String = reader.ReadToEnd()
                    Return json.Contains("""success"":true") OrElse json.Contains("""success"": true")
                End Using
            End Using
            
        Catch ex As Exception
            Debug.WriteLine("[ApiClient.ActivateLicense] Hata: " & ex.Message)
            Return False
        End Try
    End Function
    
    ''' <summary>
    ''' API sunucusunun erişilebilir olup olmadığını kontrol eder
    ''' </summary>
    Public Shared Function IsApiAvailable() As Boolean
        Try
            ' TLS 1.2 kullan
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            
            Dim request As HttpWebRequest = CType(WebRequest.Create(API_BASE_URL), HttpWebRequest)
            request.Method = "GET"
            request.Timeout = 5000
            
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Return response.StatusCode = HttpStatusCode.OK
            End Using
            
        Catch
            Return False
        End Try
    End Function
    
End Class

''' <summary>
''' Güncelleme dosyası bilgisi
''' </summary>
Public Class UpdateFileInfo
    Public Property Success As Boolean
    Public Property LastModified As DateTime
    Public Property FileSize As Long
    Public Property ErrorMessage As String
End Class

''' <summary>
''' Lisans bilgisi
''' </summary>
Public Class LicenseInfo
    Public Property IsValid As Boolean
    Public Property FirmaAdi As String
    Public Property Message As String
    Public Property ExpiryDate As DateTime
    Public Property OzelNot As String
    Public Property Parametre1 As String
    Public Property Parametre2 As String
End Class
