Imports System.Net
Imports System.Net.Http
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

''' <summary>
''' Business Smart Desktop API Client
''' Güncelleme, Yedekleme, Lisans işlemleri için API bağlantısı
''' </summary>
Public Module ApiClient
    
    ' API Ayarları
    Private Const API_BASE_URL As String = "https://desktop.barkodyazilimevi.com"
    Private Const API_KEY As String = "BSmart2024Desktop!@#SecureKey"
    
    Private ReadOnly httpClient As New HttpClient()
    
    ''' <summary>
    ''' API'ye istek gönder
    ''' </summary>
    Private Function SendRequest(endpoint As String, method As String, Optional body As String = Nothing) As String
        Try
            Dim request As New HttpRequestMessage()
            request.RequestUri = New Uri(API_BASE_URL & endpoint)
            request.Method = New HttpMethod(method)
            request.Headers.Add("X-Api-Key", API_KEY)
            
            If body IsNot Nothing Then
                request.Content = New StringContent(body, Encoding.UTF8, "application/json")
            End If
            
            Dim response = httpClient.SendAsync(request).Result
            Return response.Content.ReadAsStringAsync().Result
        Catch ex As Exception
            Debug.WriteLine("[API] Hata: " & ex.Message)
            Return Nothing
        End Try
    End Function
    
    ' ==================== GÜNCELLEME API ====================
    
    ''' <summary>
    ''' Güncelleme kontrolü yap
    ''' </summary>
    Public Function CheckForUpdates(appName As String, currentVersion As String) As JObject
        Try
            Dim response = SendRequest($"/api/update/check?app={appName}&version={currentVersion}", "GET")
            If response IsNot Nothing Then
                Return JObject.Parse(response)
            End If
        Catch ex As Exception
            Debug.WriteLine("[API-Update] Check hatası: " & ex.Message)
        End Try
        Return Nothing
    End Function
    
    ''' <summary>
    ''' Güncelleme dosyası bilgisini al
    ''' </summary>
    Public Function GetUpdateInfo(fileName As String) As JObject
        Try
            Dim response = SendRequest($"/api/update/info?file={fileName}", "GET")
            If response IsNot Nothing Then
                Return JObject.Parse(response)
            End If
        Catch ex As Exception
            Debug.WriteLine("[API-Update] Info hatası: " & ex.Message)
        End Try
        Return Nothing
    End Function
    
    ''' <summary>
    ''' Güncelleme dosyasını indir
    ''' </summary>
    Public Function DownloadUpdate(fileName As String, localPath As String) As Boolean
        Try
            Dim request As New HttpRequestMessage()
            request.RequestUri = New Uri(API_BASE_URL & $"/api/update/download?file={fileName}")
            request.Method = HttpMethod.Get
            request.Headers.Add("X-Api-Key", API_KEY)
            
            Dim response = httpClient.SendAsync(request).Result
            
            If response.IsSuccessStatusCode Then
                Using fileStream As New FileStream(localPath, FileMode.Create)
                    response.Content.CopyToAsync(fileStream).Wait()
                End Using
                Return True
            End If
        Catch ex As Exception
            Debug.WriteLine("[API-Update] Download hatası: " & ex.Message)
        End Try
        Return False
    End Function
    
    ' ==================== YEDEKLEME API ====================
    
    ''' <summary>
    ''' Yedek dosyasını API'ye yükle
    ''' </summary>
    Public Function UploadBackup(filePath As String, clientId As String) As JObject
        Try
            If Not File.Exists(filePath) Then
                Return JObject.Parse("{""success"":false,""message"":""Dosya bulunamadı""}")
            End If
            
            Using content As New MultipartFormDataContent()
                Dim fileContent As New ByteArrayContent(File.ReadAllBytes(filePath))
                fileContent.Headers.ContentType = New Headers.MediaTypeHeaderValue("application/octet-stream")
                content.Add(fileContent, "file", Path.GetFileName(filePath))
                
                Dim request As New HttpRequestMessage()
                request.RequestUri = New Uri(API_BASE_URL & "/api/backup/upload")
                request.Method = HttpMethod.Post
                request.Headers.Add("X-Api-Key", API_KEY)
                request.Headers.Add("X-Client-Id", clientId)
                request.Content = content
                
                Dim response = httpClient.SendAsync(request).Result
                Dim result = response.Content.ReadAsStringAsync().Result
                Return JObject.Parse(result)
            End Using
        Catch ex As Exception
            Debug.WriteLine("[API-Backup] Upload hatası: " & ex.Message)
            Return JObject.Parse("{""success"":false,""message"":""" & ex.Message & """}")
        End Try
    End Function
    
    ''' <summary>
    ''' Yedek listesini al
    ''' </summary>
    Public Function ListBackups(clientId As String) As JObject
        Try
            Dim response = SendRequest($"/api/backup/list?clientId={clientId}", "GET")
            If response IsNot Nothing Then
                Return JObject.Parse(response)
            End If
        Catch ex As Exception
            Debug.WriteLine("[API-Backup] List hatası: " & ex.Message)
        End Try
        Return Nothing
    End Function
    
    ' ==================== LİSANS API ====================
    
    ''' <summary>
    ''' Lisans doğrula
    ''' </summary>
    Public Function VerifyLicense(licenseKey As String, machineId As String) As JObject
        Try
            Dim body = JsonConvert.SerializeObject(New With {
                .licenseKey = licenseKey,
                .machineId = machineId
            })
            
            Dim response = SendRequest("/api/license/verify", "POST", body)
            If response IsNot Nothing Then
                Return JObject.Parse(response)
            End If
        Catch ex As Exception
            Debug.WriteLine("[API-License] Verify hatası: " & ex.Message)
        End Try
        Return Nothing
    End Function
    
    ''' <summary>
    ''' Lisans aktive et (donanım bilgileriyle)
    ''' </summary>
    Public Function ActivateLicense(licenseKey As String) As JObject
        Try
            Dim body = JsonConvert.SerializeObject(New With {
                .licenseKey = licenseKey,
                .machineId = GetMacAddress(),
                .computerName = Environment.MachineName,
                .userName = Environment.UserName,
                .ipAddress = GetLocalIPAddress(),
                .osVersion = Environment.OSVersion.ToString(),
                .cpuId = GetCPUId(),
                .hddSerial = GetHDDSerial(),
                .biosVersion = GetBiosVersion(),
                .manufacturer = GetComputerManufacturer(),
                .model = GetComputerModel(),
                .systemType = If(Environment.Is64BitOperatingSystem, "x64", "x86")
            })
            
            Dim response = SendRequest("/api/license/activate", "POST", body)
            If response IsNot Nothing Then
                Return JObject.Parse(response)
            End If
        Catch ex As Exception
            Debug.WriteLine("[API-License] Activate hatası: " & ex.Message)
        End Try
        Return Nothing
    End Function
    
    ' ==================== DOSYA API (FTP YERİNE) ====================
    
    ''' <summary>
    ''' Dosya listele
    ''' </summary>
    Public Function ListFiles(folder As String) As JObject
        Try
            Dim response = SendRequest($"/api/files/list?folder={Uri.EscapeDataString(folder)}", "GET")
            If response IsNot Nothing Then
                Return JObject.Parse(response)
            End If
        Catch ex As Exception
            Debug.WriteLine("[API-Files] List hatası: " & ex.Message)
        End Try
        Return Nothing
    End Function
    
    ''' <summary>
    ''' Dosya indir
    ''' </summary>
    Public Function DownloadFile(remoteFile As String, localPath As String) As Boolean
        Try
            Dim request As New HttpRequestMessage()
            request.RequestUri = New Uri(API_BASE_URL & $"/api/files/download?file={Uri.EscapeDataString(remoteFile)}")
            request.Method = HttpMethod.Get
            request.Headers.Add("X-Api-Key", API_KEY)
            
            Dim response = httpClient.SendAsync(request).Result
            
            If response.IsSuccessStatusCode Then
                Using fileStream As New FileStream(localPath, FileMode.Create)
                    response.Content.CopyToAsync(fileStream).Wait()
                End Using
                Return True
            End If
        Catch ex As Exception
            Debug.WriteLine("[API-Files] Download hatası: " & ex.Message)
        End Try
        Return False
    End Function
    
    ''' <summary>
    ''' Dosya yükle
    ''' </summary>
    Public Function UploadFile(localPath As String, remoteFolder As String) As JObject
        Try
            If Not File.Exists(localPath) Then
                Return JObject.Parse("{""success"":false,""message"":""Dosya bulunamadı""}")
            End If
            
            Using content As New MultipartFormDataContent()
                Dim fileContent As New ByteArrayContent(File.ReadAllBytes(localPath))
                fileContent.Headers.ContentType = New Headers.MediaTypeHeaderValue("application/octet-stream")
                content.Add(fileContent, "file", Path.GetFileName(localPath))
                
                Dim request As New HttpRequestMessage()
                request.RequestUri = New Uri(API_BASE_URL & $"/api/files/upload?folder={Uri.EscapeDataString(remoteFolder)}")
                request.Method = HttpMethod.Post
                request.Headers.Add("X-Api-Key", API_KEY)
                request.Content = content
                
                Dim response = httpClient.SendAsync(request).Result
                Dim result = response.Content.ReadAsStringAsync().Result
                Return JObject.Parse(result)
            End Using
        Catch ex As Exception
            Debug.WriteLine("[API-Files] Upload hatası: " & ex.Message)
            Return JObject.Parse("{""success"":false,""message"":""" & ex.Message & """}")
        End Try
    End Function
    
    ' ==================== YARDIMCI FONKSİYONLAR ====================
    
    ''' <summary>
    ''' MAC adresini al
    ''' </summary>
    Private Function GetMacAddress() As String
        Try
            For Each nic In System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
                If nic.OperationalStatus = NetworkInformation.OperationalStatus.Up Then
                    Return nic.GetPhysicalAddress().ToString()
                End If
            Next
        Catch
        End Try
        Return ""
    End Function
    
    ''' <summary>
    ''' Yerel IP adresini al
    ''' </summary>
    Private Function GetLocalIPAddress() As String
        Try
            Dim host = Dns.GetHostEntry(Dns.GetHostName())
            For Each ip In host.AddressList
                If ip.AddressFamily = Sockets.AddressFamily.InterNetwork Then
                    Return ip.ToString()
                End If
            Next
        Catch
        End Try
        Return ""
    End Function
    
    ''' <summary>
    ''' CPU ID al
    ''' </summary>
    Private Function GetCPUId() As String
        Try
            Dim mc As New Management.ManagementClass("Win32_Processor")
            For Each mo As Management.ManagementObject In mc.GetInstances()
                Return mo.Properties("ProcessorId").Value.ToString()
            Next
        Catch
        End Try
        Return ""
    End Function
    
    ''' <summary>
    ''' HDD Seri numarası al
    ''' </summary>
    Private Function GetHDDSerial() As String
        Try
            Dim mc As New Management.ManagementClass("Win32_PhysicalMedia")
            For Each mo As Management.ManagementObject In mc.GetInstances()
                If mo("SerialNumber") IsNot Nothing Then
                    Return mo("SerialNumber").ToString().Trim()
                End If
            Next
        Catch
        End Try
        Return ""
    End Function
    
    ''' <summary>
    ''' BIOS versiyonu al
    ''' </summary>
    Private Function GetBiosVersion() As String
        Try
            Dim mc As New Management.ManagementClass("Win32_BIOS")
            For Each mo As Management.ManagementObject In mc.GetInstances()
                Return mo.Properties("Version").Value.ToString()
            Next
        Catch
        End Try
        Return ""
    End Function
    
    ''' <summary>
    ''' Bilgisayar üreticisi al
    ''' </summary>
    Private Function GetComputerManufacturer() As String
        Try
            Dim mc As New Management.ManagementClass("Win32_ComputerSystem")
            For Each mo As Management.ManagementObject In mc.GetInstances()
                Return mo("Manufacturer").ToString()
            Next
        Catch
        End Try
        Return ""
    End Function
    
    ''' <summary>
    ''' Bilgisayar modeli al
    ''' </summary>
    Private Function GetComputerModel() As String
        Try
            Dim mc As New Management.ManagementClass("Win32_ComputerSystem")
            For Each mo As Management.ManagementObject In mc.GetInstances()
                Return mo("Model").ToString()
            Next
        Catch
        End Try
        Return ""
    End Function
    
End Module
