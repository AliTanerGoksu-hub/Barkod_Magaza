Imports System
Imports System.IO
Imports System.Net
Imports System.Drawing
Imports System.Data
Imports System.Data.OleDb
Imports System.Threading.Tasks
Imports System.Text
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text.RegularExpressions
Imports System.Collections.Generic

' =========================
'  R2 Bağlantı Yapılandırma
' =========================
Friend Module R2Config
    ' Varsayılan URL (eğer tbParamGenel'de yoksa kullanılır)
    Friend R2_WORKER_BASE_DEFAULT As String = "https://r2.barkodyazilimevi.com"

    ' HTTP Timeout ayarları
    Friend Const HTTP_TIMEOUT_SECONDS As Integer = 180  ' 3 dakika (yavaş bağlantılar için)
    Friend Const MAX_RETRY_COUNT As Integer = 3
    Friend Const RETRY_DELAY_MS As Integer = 2000       ' 2 saniye bekleme

    ' tbParamGenel'den R2 Worker URL'ini al
    Public Function GetR2WorkerBase(Optional connectionString As String = Nothing) As String
        Try
            Dim connStr As String = If(connectionString, connection)
            Using con As New OleDbConnection(connStr)
                Using cmd As New OleDbCommand("SELECT TOP 1 R2_WorkerBase FROM tbParamGenel", con)
                    con.Open()
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        Dim url As String = result.ToString().Trim()
                        If Not String.IsNullOrEmpty(url) Then
                            Return url
                        End If
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Hata durumunda varsayılan URL kullan
            Debug.WriteLine($"R2_WORKER_BASE alınamadı, varsayılan kullanılıyor: {ex.Message}")
        End Try

        Return R2_WORKER_BASE_DEFAULT
    End Function
End Module

' =========================
'  R2 Yardımcıları
' =========================
Friend Module R2Helpers

    Public Function SlugifyKeepDot(input As String) As String
        If String.IsNullOrWhiteSpace(input) Then Return ""
        Dim t = input.Trim().ToLowerInvariant().
                Replace(" ", "-").
                Replace("ı", "i").Replace("ğ", "g").Replace("ü", "u").Replace("ş", "s").Replace("ö", "o").Replace("ç", "c")

        Dim sb As New StringBuilder()
        For Each ch As Char In t
            If Char.IsLetterOrDigit(ch) OrElse ch = "-"c OrElse ch = "_"c OrElse ch = "/"c OrElse ch = "."c Then
                sb.Append(ch)
            End If
        Next
        Return sb.ToString()
    End Function

    Public Async Function R2UploadAsync(localPath As String,
                                        objectKey As String,
                                        contentType As String,
                                        Optional connectionString As String = Nothing) As Task(Of String)

        If Not File.Exists(localPath) Then
            Throw New FileNotFoundException($"Dosya bulunamadı: {localPath}")
        End If

        Dim key As String = SlugifyKeepDot(objectKey.Replace("\", "/"))
        Dim bytes As Byte() = File.ReadAllBytes(localPath)
        Return Await R2UploadFromBytesAsync(bytes, objectKey, contentType, connectionString)
    End Function

    Public Async Function R2UploadFromBytesAsync(bytes As Byte(),
                                                  objectKey As String,
                                                  contentType As String,
                                                  Optional connectionString As String = Nothing) As Task(Of String)

        If bytes Is Nothing OrElse bytes.Length = 0 Then
            Throw New ArgumentException("Byte array boş olamaz")
        End If

        Dim key As String = SlugifyKeepDot(objectKey.Replace("\", "/"))
        Dim workerBase As String = R2Config.GetR2WorkerBase(connectionString)
        Dim url As String = workerBase.TrimEnd("/"c) & "/upload"

        ' Retry mekanizması
        Dim lastException As Exception = Nothing
        For attempt As Integer = 1 To R2Config.MAX_RETRY_COUNT
            lastException = Nothing
            Try
                Using client As New HttpClient()
                    client.Timeout = TimeSpan.FromSeconds(R2Config.HTTP_TIMEOUT_SECONDS)

                    Dim req As New HttpRequestMessage(HttpMethod.Post, New Uri(url))
                    req.Headers.Add("x-object-key", key)

                    Dim content As New ByteArrayContent(bytes)
                    If Not String.IsNullOrEmpty(contentType) Then
                        content.Headers.ContentType = New MediaTypeHeaderValue(contentType)
                    End If
                    req.Content = content

                    Dim resp As HttpResponseMessage = Await client.SendAsync(req).ConfigureAwait(False)
                    Dim body As String = Await resp.Content.ReadAsStringAsync().ConfigureAwait(False)

                    If Not resp.IsSuccessStatusCode Then
                        Dim errorMsg As String = $"R2 Upload başarısız (HTTP {CInt(resp.StatusCode)}): {body}"

                        ' 5xx hatalarında retry yap
                        If CInt(resp.StatusCode) >= 500 AndAlso attempt < R2Config.MAX_RETRY_COUNT Then
                            Debug.WriteLine($"[R2Upload] Deneme {attempt}/{R2Config.MAX_RETRY_COUNT} başarısız, tekrar deneniyor...")
                            Await Task.Delay(R2Config.RETRY_DELAY_MS * attempt)
                            Continue For
                        End If

                        Throw New Exception(errorMsg)
                    End If

                    ' JSON'dan URL'yi çıkar
                    Dim m As Match = Regex.Match(body, "(?i)""url""\s*:\s*""([^""]+)""")
                    If m.Success Then
                        Dim resultUrl As String = m.Groups(1).Value
                        Debug.WriteLine($"[R2Upload] Başarılı: {key} -> {resultUrl}")
                        Return resultUrl
                    Else
                        ' JSON'da url çıkmazsa güvenli geri dönüş
                        Dim fallbackUrl As String = workerBase.TrimEnd("/"c) & "/files/" & key
                        Debug.WriteLine($"[R2Upload] URL parse edilemedi, fallback kullanılıyor: {fallbackUrl}")
                        Return fallbackUrl
                    End If
                End Using

            Catch ex As Exception
                lastException = ex

                ' Detaylı hata bilgisi
                Dim errorDetail As String = ex.Message
                If TypeOf ex Is HttpRequestException Then
                    errorDetail = $"HTTP İstek Hatası: {ex.Message}"
                    If ex.InnerException IsNot Nothing Then
                        errorDetail &= $" (İç Hata: {ex.InnerException.Message})"
                    End If
                ElseIf TypeOf ex Is TaskCanceledException Then
                    errorDetail = "Zaman aşımı: Sunucuya bağlanılamadı (timeout)"
                ElseIf TypeOf ex Is System.Net.WebException Then
                    errorDetail = $"Ağ Hatası: {ex.Message}"
                End If

                ' Timeout veya network hataları için retry
                If attempt < R2Config.MAX_RETRY_COUNT Then
                    Debug.WriteLine($"[R2Upload] Hata (deneme {attempt}/{R2Config.MAX_RETRY_COUNT}): {errorDetail}")
                    ' Await yerine Thread.Sleep kullan (Catch içinde Await kullanılamaz)
                    Threading.Thread.Sleep(R2Config.RETRY_DELAY_MS * attempt)
                    Continue For
                End If
            End Try
        Next

        ' Tüm denemeler başarısız - detaylı hata mesajı
        Dim finalError As String = lastException?.Message
        If lastException IsNot Nothing AndAlso lastException.InnerException IsNot Nothing Then
            finalError &= $" | İç Hata: {lastException.InnerException.Message}"
        End If
        
        Throw New Exception($"R2 upload başarısız ({R2Config.MAX_RETRY_COUNT} deneme sonrası): {finalError}" & vbCrLf & vbCrLf &
                           "Olası Sebepler:" & vbCrLf &
                           "1. İnternet bağlantınızı kontrol edin" & vbCrLf &
                           "2. Firewall/Antivirüs R2 sunucusunu engelliyor olabilir" & vbCrLf &
                           "3. Proxy ayarlarınızı kontrol edin" & vbCrLf &
                           "4. R2 Worker URL'ini tbParamGenel tablosundan kontrol edin", lastException)
    End Function
    Public Function R2Delete(objectKey As String, Optional connectionString As String = Nothing) As Boolean
        If String.IsNullOrEmpty(objectKey) Then Return False

        Dim workerBase As String = R2Config.GetR2WorkerBase(connectionString)
        Dim workerDeleteUrl As String = workerBase.TrimEnd("/"c) & "/delete"

        ' Retry mekanizması ile
        For attempt As Integer = 1 To R2Config.MAX_RETRY_COUNT
            Using client As New HttpClient()
                client.Timeout = TimeSpan.FromSeconds(30)

                Try
                    ' 1) HTTP POST + x-object-key header
                    Dim reqDel As New HttpRequestMessage(HttpMethod.Post, New Uri(workerDeleteUrl))
                    reqDel.Headers.Add("x-object-key", objectKey)
                    Dim resp = client.SendAsync(reqDel).GetAwaiter().GetResult()

                    If resp.IsSuccessStatusCode Then
                        Debug.WriteLine($"[R2Delete] Başarılı: {objectKey}")
                        Return True
                    End If

                    ' 5xx hatalarında retry
                    If CInt(resp.StatusCode) >= 500 AndAlso attempt < R2Config.MAX_RETRY_COUNT Then
                        Debug.WriteLine($"[R2Delete] Deneme {attempt}/{R2Config.MAX_RETRY_COUNT} başarısız, tekrar deneniyor...")
                        Threading.Thread.Sleep(R2Config.RETRY_DELAY_MS * attempt)
                        Continue For
                    End If
                Catch ex As Exception
                    Debug.WriteLine($"[R2Delete] Header metodu hata (deneme {attempt}): {ex.Message}")
                End Try

                ' 2) Fallback: POST /delete with form data
                Try
                    Dim form As New FormUrlEncodedContent(New Dictionary(Of String, String) From {{"key", objectKey}})
                    Dim resp2 = client.PostAsync(workerDeleteUrl, form).GetAwaiter().GetResult()

                    If resp2.IsSuccessStatusCode Then
                        Debug.WriteLine($"[R2Delete] Başarılı (fallback): {objectKey}")
                        Return True
                    End If

                    ' 5xx hatalarında retry
                    If CInt(resp2.StatusCode) >= 500 AndAlso attempt < R2Config.MAX_RETRY_COUNT Then
                        Threading.Thread.Sleep(R2Config.RETRY_DELAY_MS * attempt)
                        Continue For
                    End If
                Catch ex As Exception
                    Debug.WriteLine($"[R2Delete] Fallback metodu hata (deneme {attempt}): {ex.Message}")
                End Try
            End Using
        Next

        Debug.WriteLine($"[R2Delete] Başarısız (tüm denemeler tükendi): {objectKey}")
        Return False
    End Function

    ' Yardımcı: R2 URL kontrolü
    Public Function IsR2Url(url As String) As Boolean
        If String.IsNullOrEmpty(url) Then Return False
        Return url.Contains("r2.dev") OrElse url.Contains("workers.dev/files/")
    End Function

    ' Yardımcı: Batch upload (çoklu dosya)
    Public Async Function R2UploadBatchAsync(files As Dictionary(Of String, String),
                                             contentType As String,
                                             Optional connectionString As String = Nothing) As Task(Of Dictionary(Of String, String))
        Dim results As New Dictionary(Of String, String)

        For Each kvp As KeyValuePair(Of String, String) In files
            Try
                Dim localPath As String = kvp.Key
                Dim objectKey As String = kvp.Value
                Dim r2Url As String = Await R2UploadAsync(localPath, objectKey, contentType, connectionString)
                results.Add(localPath, r2Url)
            Catch ex As Exception
                Debug.WriteLine($"[R2UploadBatch] Hata: {kvp.Key} -> {ex.Message}")
                results.Add(kvp.Key, "ERROR: " & ex.Message)
            End Try
        Next

        Return results
    End Function
End Module