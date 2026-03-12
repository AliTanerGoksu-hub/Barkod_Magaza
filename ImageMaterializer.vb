Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Text.RegularExpressions

' ------------------------------------------------------------
'  R2 (URL) -> C:\Eticaret\Stok Resim\ altına indirip cache’ler.
'  pResim (lokal yol) varsa onu kullanır.
'  Satıra:
'   - ResimLocal  : String (kullanılan lokal dosya yolu)
'   - ResimBytes  : Byte() (Grid’e gösterilecek veri)
'  TLS1.2 zorlanır; Cloudflare/R2 SSL sorunlarını çözer.
' ------------------------------------------------------------
Module ImageMaterializer
    Private ReadOnly _http As HttpClient = CreateHttp()

    Private Function CreateHttp() As HttpClient
        ServicePointManager.Expect100Continue = False
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        Dim h As New HttpClientHandler() With {
            .AutomaticDecompression = DecompressionMethods.GZip Or DecompressionMethods.Deflate
        }
        Dim c As New HttpClient(h, disposeHandler:=True)
        c.Timeout = TimeSpan.FromSeconds(15)
        Return c
    End Function

    Public Sub MaterializeListImageBytes(ByVal t As DataTable)
        If t Is Nothing OrElse t.Rows.Count = 0 Then Exit Sub

        Dim cacheDir As String = "C:\Eticaret\Stok Resim\"
        Try
            If Not Directory.Exists(cacheDir) Then Directory.CreateDirectory(cacheDir)
        Catch
            ' klasör oluşmasa da devam…
        End Try

        If Not t.Columns.Contains("ResimLocal") Then t.Columns.Add("ResimLocal", GetType(String))
        If Not t.Columns.Contains("ResimBytes") Then t.Columns.Add("ResimBytes", GetType(Byte()))

        Dim has_pResim As Boolean = t.Columns.Contains("pResim")
        Dim has_yol As Boolean = t.Columns.Contains("yol")
        Dim has_sModel As Boolean = t.Columns.Contains("sModel")
        Dim has_nStokID As Boolean = t.Columns.Contains("nStokID")

        For Each r As DataRow In t.Rows
            Dim preferredPath As String = ""
            Dim localPath As String = If(has_pResim AndAlso Not IsDBNull(r("pResim")), Trim(CStr(r("pResim"))), "")

            ' 1) Lokal dosya var mı?
            If Not String.IsNullOrWhiteSpace(localPath) AndAlso File.Exists(localPath) Then
                preferredPath = localPath
            Else
                ' 2) URL’den indir
                Dim url As String = If(has_yol AndAlso Not IsDBNull(r("yol")), Trim(CStr(r("yol"))), "")
                If Not String.IsNullOrWhiteSpace(url) AndAlso url.StartsWith("http", StringComparison.OrdinalIgnoreCase) Then
                    Dim baseName As String = ""
                    If has_sModel AndAlso Not IsDBNull(r("sModel")) AndAlso Not String.IsNullOrWhiteSpace(CStr(r("sModel"))) Then
                        baseName = SafeFileName(CStr(r("sModel")))
                    ElseIf has_nStokID AndAlso Not IsDBNull(r("nStokID")) Then
                        baseName = "STOK_" & CStr(r("nStokID"))
                    Else
                        baseName = Guid.NewGuid().ToString("N")
                    End If

                    Dim ext As String = GetExtensionFromUrl(url)
                    If String.IsNullOrEmpty(ext) Then ext = ".jpg"

                    Dim target As String = Path.Combine(cacheDir, baseName & ext)

                    Try
                        If Not File.Exists(target) Then
                            Dim bytes As Byte() = _http.GetByteArrayAsync(url).GetAwaiter().GetResult()
                            File.WriteAllBytes(target, bytes)
                        End If
                        If File.Exists(target) Then preferredPath = target
                    Catch
                        ' indirme hatası: boş geç
                    End Try
                End If
            End If

            r("ResimLocal") = preferredPath

            Try
                If Not String.IsNullOrWhiteSpace(preferredPath) AndAlso File.Exists(preferredPath) Then
                    r("ResimBytes") = File.ReadAllBytes(preferredPath)
                Else
                    r("ResimBytes") = DBNull.Value
                End If
            Catch
                r("ResimBytes") = DBNull.Value
            End Try
        Next
    End Sub
    Private Function SafeFileName(input As String) As String
        If String.IsNullOrEmpty(input) Then Return ""
        Dim invalid As Char() = System.IO.Path.GetInvalidFileNameChars()

        ' LINQ kullanmadan temizle
        Dim sb As New System.Text.StringBuilder(input.Length)
        For Each ch As Char In input
            Dim isInvalid As Boolean = False
            For Each bad As Char In invalid
                If ch = bad Then
                    isInvalid = True
                    Exit For
                End If
            Next
            If isInvalid Then
                sb.Append("_"c)
            Else
                sb.Append(ch)
            End If
        Next

        Dim cleaned As String = sb.ToString()
        ' Boşlukları tek altçizgiye indir
        cleaned = System.Text.RegularExpressions.Regex.Replace(cleaned, "\s+", "_")
        Return cleaned
    End Function


    Private Function GetExtensionFromUrl(u As String) As String
        Try
            Dim uri As New Uri(u)
            Dim ext As String = Path.GetExtension(uri.AbsolutePath)
            If Not String.IsNullOrEmpty(ext) Then Return ext
        Catch
        End Try
        If u.IndexOf("format=png", StringComparison.OrdinalIgnoreCase) >= 0 Then Return ".png"
        If u.IndexOf("format=webp", StringComparison.OrdinalIgnoreCase) >= 0 Then Return ".webp"
        If u.IndexOf("format=jpeg", StringComparison.OrdinalIgnoreCase) >= 0 Then Return ".jpg"
        If u.IndexOf("format=jpg", StringComparison.OrdinalIgnoreCase) >= 0 Then Return ".jpg"
        Return ".jpg"
    End Function
End Module
