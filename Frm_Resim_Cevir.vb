Imports System.IO
Imports System.Net
Imports System.Drawing
Imports System.Data
Imports System.Data.OleDb
Imports System.Threading.Tasks
Imports System.Linq
Imports System.Collections.Generic

' Varyant bilgisi için yardımcı sınıf (VS2012 uyumluluğu için)
Public Class VaryantBilgisi
    Public Property sRenk As String = ""
    Public Property sBeden As String = ""
    Public Property sKavala As String = ""
    
    Public Sub New()
    End Sub
    
    Public Sub New(renk As String, beden As String, kavala As String)
        sRenk = If(renk, "")
        sBeden = If(beden, "")
        sKavala = If(kavala, "")
    End Sub
End Class

' Stok varyant bilgisi için yardımcı sınıf (VS2012 uyumluluğu için)
Public Class StokVaryantBilgisi
    Public Property nStokID As Integer = 0
    Public Property sRenk As String = ""
    Public Property sBeden As String = ""
    Public Property sKavala As String = ""
    
    Public Sub New()
    End Sub
    
    Public Sub New(stokID As Integer, renk As String, beden As String, kavala As String)
        nStokID = stokID
        sRenk = If(renk, "")
        sBeden = If(beden, "")
        sKavala = If(kavala, "")
    End Sub
End Class

Module Frm_Resim_Cevir

    ' ===== Genel ayarlar =====
    Private Const LOCAL_ROOT As String = "C:\Eticaret"
    Private Const LOCAL_RESIM_ROOT As String = "C:\Eticaret\Stok Resim" ' Artık kullanılmıyor (Base64 kullanımı)
    Private Const JPEG_QUALITY As Long = 85L
    Private Const TARGET_WIDTH As Integer = 600
    Private Const MAX_RESIM_PER_STOK As Integer = 11
    Private Const CLEAR_BASE64_AFTER_SUCCESS As Boolean = False ' Deprecated - Base64 kalıcı
    Private Const LOG_PATH As String = "C:\Eticaret\migrate_images.log"

    ' ===== ÖNEMLI NOT =====
    ' Bu migration tool ESKİ SİSTEMDEN YENİ SİSTEME GEÇİŞ İÇİN kullanılır.
    ' 
    ' ESKİ SİSTEM (2 tablo):
    ' - tbStokResim: Base64 resimler (pResim kolonunda)
    '
    ' YENİ SİSTEM (1 tablo):
    ' - tbStokResim: Sadece R2 URL'leri (yol kolonunda), her resim ayrı satır
    '
    ' Migration işlemi:
    ' 1. tbStokResim'deki base64'leri R2'ye taşır
    ' 2. tbStokResim'deki eski HTTP URL'leri R2'ye taşır
    ' 3. Her resim için ayrı satır oluşturur (nSira 1-11)
    ' ============================================

    ' ===== Overwrite politikası =====
    ' TRUE: yol doluysa bile, R2 DEĞİLSE üzerine yaz.
    Private Const OVERWRITE_NON_R2 As Boolean = True

    ' ===== FTP fallback ayarları =====
    Private Const FTP_ENABLED As Boolean = True
    Private Const FTP_PORT As Integer = 21
    Private Const FTP_USER As String = "bayii"
    Private Const FTP_PASS As String = "BusinessSmart4909"
    Private Const FTP_USE_PASSIVE As Boolean = True
    Private Const FTP_USE_SSL As Boolean = False
    Private Const FTP_BASE_PATH As String = "/Eticaret"
    Private sourceIp As String = ""
    Private ReadOnly Property FTP_HOST As String
        Get
            Static cached As String = Nothing
            If String.IsNullOrEmpty(cached) Then
                Dim ip = GetLisansSourceIp()
                cached = If(String.IsNullOrEmpty(ip), "88.247.79.39", ip)
            End If
            Return cached
        End Get
    End Property
    ' =========================================================
    '                      GİRİŞ NOKTASI
    ' =========================================================
    Public Async Sub MigrateOldImages()
        Try
            ' Klasörleri oluştur
            Directory.CreateDirectory(LOCAL_ROOT)
            Directory.CreateDirectory(LOCAL_RESIM_ROOT)
            Log("=== MIGRASYON BAŞLADI (tbStokResim - R2 Upload) ===")
            Log("Lokal resim klasörü: " & LOCAL_RESIM_ROOT)

            ' Firma klasörünü bul
            sourceIp = GetLisansSourceIp()
            Dim sOnayKodu As String = GetOnayKoduFromRegistry()
            Dim firmaKlasor As String = If(String.IsNullOrEmpty(sOnayKodu), "", GetFirmaKlasorByOnay(sourceIp, sOnayKodu))
            Dim localFolder As String = Path.Combine(LOCAL_ROOT, firmaKlasor)
            If Not Directory.Exists(localFolder) Then Directory.CreateDirectory(localFolder)

            Log("Firma klasörü: " & firmaKlasor)
            Log("Geçici klasör: " & localFolder)

            ' 1) tbStokEticaretResim'den FTP URL'leri işle (ÖNCE BU)
            Await Migrate_tbStokEticaretResim(localFolder, firmaKlasor)

            ' 2) tbStokResim'deki Base64 resimleri işle (varsa)
            Await Migrate_tbStokResim(localFolder, firmaKlasor)

            ' 3) Eski HTTP URL'li kayıtları da R2'ye taşı
            Await Migrate_ExistingUrls_tbStokResim(localFolder, firmaKlasor)

            Log("=== MIGRASYON BİTTİ ===")
            Log("Tüm resimler " & LOCAL_RESIM_ROOT & " klasörüne ve R2'ye yüklendi")
            MessageBox.Show("Resim migration tamamlandı!" & vbCrLf & vbCrLf &
                          "Lokal klasör: " & LOCAL_RESIM_ROOT & vbCrLf &
                          "Log dosyası: " & LOG_PATH,
                          "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            Log("FATAL: " & ex.ToString())
            MessageBox.Show("HATA: " & ex.Message & vbCrLf & vbCrLf &
                          "Detaylar için log dosyasını kontrol edin: " & LOG_PATH,
                          "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw
        End Try
    End Sub


    ' =========================================================
    '          tbStokEticaretResim (FTP URL'LER - ÖNCELİKLİ)
    ' =========================================================
    Private Async Function Migrate_tbStokEticaretResim(localFolder As String, firmaKlasor As String) As Task
        Log("[tbStokEticaretResim] FTP URL'leri işleniyor...")

        Using con As New OleDbConnection(connection)
            Using cmd As OleDbCommand = con.CreateCommand()
                ' YENİ YAPI: tbStokEticaretResim artık nSira bazlı (her resim ayrı satır)
                cmd.CommandText =
                    "SELECT nStokResimID, sModel, nSira, ISNULL(yol,'') AS yol " &
                    "FROM tbStokEticaretResim WITH (NOLOCK) " &
                    "WHERE yol IS NOT NULL AND yol <> '' " &
                    "ORDER BY sModel, nSira"

                con.Open()
                Using rd As OleDbDataReader = cmd.ExecuteReader()
                    Dim processedCount As Integer = 0

                    While rd.Read()
                        Dim nStokResimID As Integer = SafeGetInt(rd, "nStokResimID")
                        Dim sModel As String = SafeGetStr(rd, "sModel")
                        Dim nSira As Integer = SafeGetInt(rd, "nSira")
                        Dim yolUrl As String = SafeGetStr(rd, "yol")

                        ' Güvenlik kontrolü: sModel boş olabilir
                        If String.IsNullOrEmpty(sModel) Then
                            Log("[SKIP] StokID=" & nStokResimID.ToString() & " sModel boş, atlanıyor")
                            Continue While
                        End If
                        
                        If String.IsNullOrEmpty(yolUrl) Then Continue While
                        If R2Helpers.IsR2Url(yolUrl) Then Continue While ' Zaten R2'de

                        Try
                            ' Varyant bilgilerini al (sRenk, sBeden, sKavala)
                            Dim varyantBilgisi As VaryantBilgisi = GetVaryantBilgisi(sModel)
                            
                            ' Dosya adı: sModel_sRenk_sBeden_sKavala_nSira_600.jpg
                            Dim fileName As String = BuildFileName(sModel, varyantBilgisi.sRenk, varyantBilgisi.sBeden, varyantBilgisi.sKavala, nSira)
                            Dim tempPath As String = Path.Combine(localFolder, "_tmp_" & nStokResimID.ToString() & "_" & nSira.ToString() & ".bin")
                            Dim localPath As String = Path.Combine(LOCAL_RESIM_ROOT, fileName)

                            ' FTP/HTTP'den indir
                            If Not TryDownloadHttpThenFtp(yolUrl, tempPath, firmaKlasor) Then
                                Log("[SKIP] StokID=" & nStokResimID.ToString() & " Sira=" & nSira.ToString() & " indirilemedi: " & yolUrl)
                                Continue While
                            End If

                            ' Resize ve JPG'ye çevir
                            Dim jpgPath As String = Path.Combine(localFolder, fileName)
                            Using src As Image = Image.FromFile(tempPath)
                                Using resized As Image = ResizeToWidth(src, TARGET_WIDTH)
                                    SaveJpeg(jpgPath, resized, JPEG_QUALITY)
                                End Using
                            End Using

                            ' Geçici dosyayı sil
                            Try : File.Delete(tempPath) : Catch : End Try

                            ' Lokal klasöre kopyala
                            File.Copy(jpgPath, localPath, True)

                            ' R2'ye upload
                            Dim objectKey As String = BuildObjectKey(firmaKlasor, sModel, fileName)
                            Dim r2Url As String = Await TryUploadWithRetry(jpgPath, objectKey, "image/jpeg")

                            ' tbStokResim'e EKLE (INSERT) - Base64 encode et
                            Dim base64String As String = ""
                            Using fs As New FileStream(jpgPath, FileMode.Open, FileAccess.Read)
                                Dim imgBytes As Byte() = New Byte(fs.Length - 1) {}
                                fs.Read(imgBytes, 0, imgBytes.Length)
                                base64String = Convert.ToBase64String(imgBytes)
                            End Using

                            ' tbStokResim'e INSERT - TÜM VARYANTLARA EKLE (eski resimlerde renk/beden ayrımı yok)
                            InsertInto_tbStokResim_AllVariants(sModel, nSira, base64String, r2Url)

                            ' Geçici JPG'yi sil
                            Try : File.Delete(jpgPath) : Catch : End Try

                            processedCount += 1
                            Log("[OK] ResimID=" & nStokResimID.ToString() & " Model=" & sModel & " Sira=" & nSira.ToString() & " FTP=" & yolUrl & " -> R2: " & r2Url)

                        Catch ex As Exception
                            Log("[HATA] ResimID=" & nStokResimID.ToString() & " Model=" & sModel & " Sira=" & nSira.ToString() & " URL=" & yolUrl & ": " & ex.Message)
                        End Try
                    End While
                    Log("[tbStokEticaretResim] Tamamlandı. Toplam: " & processedCount.ToString() & " resim")
                End Using
            End Using
        End Using
    End Function

    ' tbStokResim'e INSERT - Basitleştirilmiş (nStokID ve sRenk yok)
    ' GetRenkFromTbStok fonksiyonu artık kullanılmıyor (nStokID kullanıyoruz)
    
    Private Sub InsertInto_tbStokResim(sModel As String, nSira As Integer, base64String As String, r2Url As String)
        Try
            ' nStokID, sRenk, sBeden, sKavala bilgilerini tbStok'tan al (sModel bazlı - ilk kaydı al)
            Dim nStokID As Integer = 0
            Dim sRenk As String = ""
            Dim sBeden As String = ""
            Dim sKavala As String = ""
            
            Using con As New OleDbConnection(connection)
                Using cmd As New OleDbCommand("SELECT TOP 1 nStokID, sRenk, sBeden, sKavala FROM tbStok WHERE sModel = ?", con)
                    cmd.Parameters.Add("p0", OleDbType.VarChar, 50).Value = sModel
                    con.Open()
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            nStokID = If(reader.IsDBNull(0), 0, reader.GetInt32(0))
                            sRenk = If(reader.IsDBNull(1) OrElse reader.GetValue(1) Is Nothing, "", reader.GetValue(1).ToString().Trim())
                            sBeden = If(reader.IsDBNull(2) OrElse reader.GetValue(2) Is Nothing, "", reader.GetValue(2).ToString().Trim())
                            sKavala = If(reader.IsDBNull(3) OrElse reader.GetValue(3) Is Nothing, "", reader.GetValue(3).ToString().Trim())
                        End If
                    End Using
                End Using
            End Using
            
            Using con As New OleDbConnection(connection)
                Using cmd As New OleDbCommand()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO tbStokResim (sModel, nStokID, sRenk, sBeden, sKavala, nSira, pResim, yol) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
                    cmd.Parameters.Add(New OleDbParameter("sModel", OleDbType.VarChar, 50)).Value = sModel
                    cmd.Parameters.Add(New OleDbParameter("nStokID", OleDbType.Integer)).Value = If(nStokID = 0, DBNull.Value, CObj(nStokID))
                    cmd.Parameters.Add(New OleDbParameter("sRenk", OleDbType.VarChar, 10)).Value = If(String.IsNullOrEmpty(sRenk), DBNull.Value, CObj(sRenk))
                    cmd.Parameters.Add(New OleDbParameter("sBeden", OleDbType.VarChar, 10)).Value = If(String.IsNullOrEmpty(sBeden), DBNull.Value, CObj(sBeden))
                    cmd.Parameters.Add(New OleDbParameter("sKavala", OleDbType.VarChar, 10)).Value = If(String.IsNullOrEmpty(sKavala), DBNull.Value, CObj(sKavala))
                    cmd.Parameters.Add(New OleDbParameter("nSira", OleDbType.Integer)).Value = nSira
                    cmd.Parameters.Add(New OleDbParameter("pResim", OleDbType.VarChar)).Value = base64String
                    cmd.Parameters.Add(New OleDbParameter("yol", OleDbType.VarChar, 500)).Value = r2Url

                    con.Open()
                    cmd.ExecuteNonQuery()
                    Log("[INSERT OK] Model=" & sModel & ", nStokID=" & nStokID.ToString() & ", sRenk=" & sRenk & ", sBeden=" & sBeden & ", Sira=" & nSira.ToString())
                End Using
            End Using
        Catch ex As Exception
            Log("[INSERT HATA] Model=" & sModel & " Sira=" & nSira.ToString() & ": " & ex.Message)
        End Try
    End Sub


    ' =========================================================
    '                     tbStokResim (BASE64 ve YOL1-11)
    ' =========================================================
    ' ===== YENİ MANTIK: FTP → Base64 → Database (pResim) → R2 (yol) =====
' 1) FTP'den resim indir
' 2) Base64'e encode et (FULL quality)
' 3) tbStokResim'e Base64 olarak kaydet (pResim kolonu)
' 4) R2'ye upload et ve yol kolonunu güncelle

' =========================================================
'                     tbStokResim (BASE64 Update)
' =========================================================
Private Async Function Migrate_tbStokResim(localFolder As String, firmaKlasor As String) As Task
    Log("[tbStokResim] Base64 resimleri işleniyor...")

    Using con As New OleDbConnection(connection)
        Using cmd As OleDbCommand = con.CreateCommand()
            cmd.CommandText =
                "SELECT nStokResimID, sModel, " &
                "ISNULL(sRenk,'') AS sRenk, " &
                "pResim, " &
                "ISNULL(yol,'') AS yol " &
                "FROM tbStokResim WITH (NOLOCK) " &
                "ORDER BY nStokResimID"

            con.Open()
            Using rd As OleDbDataReader = cmd.ExecuteReader()
                Dim processedCount As Integer = 0

                While rd.Read()
                    Dim resimID As Integer = SafeGetInt(rd, "nStokResimID")
                    Dim sModel As String = SafeGetStr(rd, "sModel")
                    Dim sRenk As String = SafeGetStr(rd, "sRenk")
                    Dim base64Existing As String = SafeGetStr(rd, "pResim")
                    Dim mevcutYol As String = SafeGetStr(rd, "yol")
                    
                    ' Güvenlik kontrolü: sModel boş olabilir
                    If String.IsNullOrEmpty(sModel) Then
                        Log("[SKIP] ResimID=" & resimID.ToString() & " sModel boş, atlanıyor")
                        Continue While
                    End If
                    
                    ' sRenk artık kullanılmıyor (nStokID kullanıyoruz)
                    ' Bu satır sadece backward compatibility için kalıyor

                    ' 1) Base64 kontrolü - varsa ve yeterli uzunluktaysa atla
                    If Not String.IsNullOrEmpty(base64Existing) AndAlso base64Existing.Length > 100 Then
                        ' Base64 var, sadece R2 URL kontrolü yap
                        If String.IsNullOrEmpty(mevcutYol) OrElse Not IsR2Url(mevcutYol) Then
                            ' R2 URL yok, sadece R2'ye upload et
                            Try
                                ' Varyant bilgilerini güvenli şekilde al
                                Dim varyantBilgisi As VaryantBilgisi = GetVaryantBilgisi(sModel)
                                
                                Dim fileName As String = BuildFileName(sModel, varyantBilgisi.sRenk, varyantBilgisi.sBeden, varyantBilgisi.sKavala, 1)
                                Dim tempPath As String = Path.Combine(localFolder, fileName)
                                
                                ' Base64'ten dosya oluştur
                                Dim bytes As Byte() = Convert.FromBase64String(CleanBase64(base64Existing))
                                File.WriteAllBytes(tempPath, bytes)
                                
                                ' R2'ye upload
                                Dim objectKey As String = BuildObjectKey(firmaKlasor, sModel, fileName)
                                Dim r2Url As String = Await TryUploadWithRetry(tempPath, objectKey, "image/jpeg")
                                
                                ' Sadece yol kolonunu güncelle (+ nStokID)
                                Dim nStokID As Integer = 0
                                ' nStokID'yi sModel'den al (fallback)
                                Using conStok As New OleDbConnection(connection)
                                    Using cmdStok As New OleDbCommand("SELECT TOP 1 nStokID FROM tbStok WHERE sModel = ?", conStok)
                                        cmdStok.Parameters.Add("p0", OleDbType.VarChar, 50).Value = sModel
                                        conStok.Open()
                                        Dim resultStok = cmdStok.ExecuteScalar()
                                        If resultStok IsNot Nothing AndAlso Not IsDBNull(resultStok) Then
                                            nStokID = CInt(resultStok)
                                        End If
                                    End Using
                                End Using
                                Update_tbStokResim_YolOnly(resimID, r2Url, sModel, nStokID)
                                
                                ' Temp dosyayı sil
                                Try : File.Delete(tempPath) : Catch : End Try
                                
                                processedCount += 1
                                Log("[OK R2] ResimID=" & resimID.ToString() & " Model=" & sModel & " Renk=" & sRenk & " -> R2: " & r2Url)
                            Catch ex As Exception
                                Log("[HATA R2] ResimID=" & resimID.ToString() & " Model=" & sModel & ": " & ex.Message)
                            End Try
                        Else
                            Log("[SKIP] ResimID=" & resimID.ToString() & " Base64 ve R2 URL mevcut")
                        End If
                        Continue While
                    End If

                    ' 2) Base64 yok, FTP'den indir ve Base64'e çevir
                    Try
                        ' Varyant bilgilerini güvenli şekilde al
                        Dim varyantBilgisi As VaryantBilgisi = GetVaryantBilgisi(sModel)
                        
                        Dim fileName As String = BuildFileName(sModel, varyantBilgisi.sRenk, varyantBilgisi.sBeden, varyantBilgisi.sKavala, 1)
                        Dim tempPath As String = Path.Combine(localFolder, "_tmp_" & resimID.ToString() & ".bin")

                        ' FTP URL'i oluştur (eski HTTP URL varsa)
                        Dim ftpDownloadSuccess As Boolean = False
                        If Not String.IsNullOrEmpty(mevcutYol) AndAlso IsOldHttpUrl(mevcutYol) Then
                            ftpDownloadSuccess = TryDownloadHttpThenFtp(mevcutYol, tempPath, firmaKlasor)
                        End If

                        If Not ftpDownloadSuccess Then
                            Log("[SKIP] ResimID=" & resimID.ToString() & " Model=" & sModel & " FTP'den indirilemedi")
                            Continue While
                        End If

                        ' Resize ve JPG'ye çevir
                        Dim jpgPath As String = Path.Combine(localFolder, fileName)
                        Using src As Image = Image.FromFile(tempPath)
                            Using resized As Image = ResizeToWidth(src, TARGET_WIDTH)
                                SaveJpeg(jpgPath, resized, JPEG_QUALITY)
                            End Using
                        End Using

                        ' Base64'e encode et
                        Dim base64String As String = ""
                        Using fs As New FileStream(jpgPath, FileMode.Open, FileAccess.Read)
                            Dim imgBytes As Byte() = New Byte(fs.Length - 1) {}
                            fs.Read(imgBytes, 0, imgBytes.Length)
                            base64String = Convert.ToBase64String(imgBytes)
                        End Using

                        ' R2'ye upload
                        Dim objectKey As String = BuildObjectKey(firmaKlasor, sModel, fileName)
                        Dim r2Url As String = Await TryUploadWithRetry(jpgPath, objectKey, "image/jpeg")

                        ' Database'e Base64 ve R2 URL kaydet (+ nStokID)
                        Dim nStokID As Integer = 0
                        ' nStokID'yi sModel'den al (fallback)
                        Using conStok As New OleDbConnection(connection)
                            Using cmdStok As New OleDbCommand("SELECT TOP 1 nStokID FROM tbStok WHERE sModel = ?", conStok)
                                cmdStok.Parameters.Add("p0", OleDbType.VarChar, 50).Value = sModel
                                conStok.Open()
                                Dim resultStok = cmdStok.ExecuteScalar()
                                If resultStok IsNot Nothing AndAlso Not IsDBNull(resultStok) Then
                                    nStokID = CInt(resultStok)
                                End If
                            End Using
                        End Using
                        Update_tbStokResim_BothColumns(resimID, base64String, r2Url, sModel, nStokID)

                        ' Temp dosyaları sil
                        Try : File.Delete(tempPath) : Catch : End Try
                        Try : File.Delete(jpgPath) : Catch : End Try

                        processedCount += 1
                        Log("[OK FULL] ResimID=" & resimID.ToString() & " Model=" & sModel & " Renk=" & sRenk & " Base64=" & base64String.Length.ToString() & " chars, R2=" & r2Url)

                    Catch ex As Exception
                        Log("[HATA] ResimID=" & resimID.ToString() & " Model=" & sModel & ": " & ex.Message)
                    End Try
                End While
                Log("[tbStokResim] Base64 işlemi tamamlandı. Toplam: " & processedCount.ToString() & " resim")
            End Using
        End Using
    End Using
End Function

' Update: Sadece yol kolonu (R2 URL) + nStokID güncelleme
Private Sub Update_tbStokResim_YolOnly(nStokResimID As Integer, r2Url As String, Optional sModel As String = "", Optional nStokID As Integer = 0)
    Using con As New OleDbConnection(connection)
        Using cmd As OleDbCommand = con.CreateCommand()
            ' nStokID bilgisi yoksa tbStok'tan al
            If nStokID = 0 AndAlso Not String.IsNullOrEmpty(sModel) Then
                Using cmdStok As New OleDbCommand("SELECT TOP 1 nStokID FROM tbStok WHERE sModel = ?", con)
                    cmdStok.Parameters.Add("p0", OleDbType.VarChar, 50).Value = sModel
                    con.Open()
                    Dim result = cmdStok.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        nStokID = CInt(result)
                    End If
                    con.Close()
                End Using
            End If
            
            If nStokID > 0 Then
                cmd.CommandText = "UPDATE tbStokResim SET yol = ?, nStokID = ? WHERE nStokResimID = ?"
                cmd.Parameters.Add("p0", OleDbType.VarChar, 500).Value = r2Url
                cmd.Parameters.Add("p1", OleDbType.Integer).Value = nStokID
                cmd.Parameters.Add("p2", OleDbType.Integer).Value = nStokResimID
            Else
                cmd.CommandText = "UPDATE tbStokResim SET yol = ? WHERE nStokResimID = ?"
                cmd.Parameters.Add("p0", OleDbType.VarChar, 500).Value = r2Url
                cmd.Parameters.Add("p1", OleDbType.Integer).Value = nStokResimID
            End If
            
            If con.State <> ConnectionState.Open Then con.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Using
End Sub

' Update: pResim (Base64) + yol (R2 URL) + nStokID
Private Sub Update_tbStokResim_BothColumns(nStokResimID As Integer, base64String As String, r2Url As String, Optional sModel As String = "", Optional nStokID As Integer = 0)
    Using con As New OleDbConnection(connection)
        Using cmd As OleDbCommand = con.CreateCommand()
            ' nStokID bilgisi yoksa tbStok'tan al
            If nStokID = 0 AndAlso Not String.IsNullOrEmpty(sModel) Then
                Using cmdStok As New OleDbCommand("SELECT TOP 1 nStokID FROM tbStok WHERE sModel = ?", con)
                    cmdStok.Parameters.Add("p0", OleDbType.VarChar, 50).Value = sModel
                    con.Open()
                    Dim result = cmdStok.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        nStokID = CInt(result)
                    End If
                    con.Close()
                End Using
            End If
            
            If nStokID > 0 Then
                cmd.CommandText = "UPDATE tbStokResim SET pResim = ?, yol = ?, nStokID = ? WHERE nStokResimID = ?"
                cmd.Parameters.Add("p0", OleDbType.VarChar).Value = base64String
                cmd.Parameters.Add("p1", OleDbType.VarChar, 500).Value = r2Url
                cmd.Parameters.Add("p2", OleDbType.Integer).Value = nStokID
                cmd.Parameters.Add("p3", OleDbType.Integer).Value = nStokResimID
            Else
                cmd.CommandText = "UPDATE tbStokResim SET pResim = ?, yol = ? WHERE nStokResimID = ?"
                cmd.Parameters.Add("p0", OleDbType.VarChar).Value = base64String
                cmd.Parameters.Add("p1", OleDbType.VarChar, 500).Value = r2Url
                cmd.Parameters.Add("p2", OleDbType.Integer).Value = nStokResimID
            End If
            
            If con.State <> ConnectionState.Open Then con.Open()
            cmd.ExecuteNonQuery()
        End Using
    End Using
End Sub


    

    ' =========================================================
    '                **ARTIK KULLANILMIYOR - TEK TABLO YAPISINA GEÇİLDİ**
    ' =========================================================
    '



    ' =========================================================
    '             ESKİ URL'LERİ DE R2'YE TAŞI (HTTP→FTP, YOL1-11)
    ' =========================================================
    Private Async Function Migrate_ExistingUrls_tbStokResim(localFolder As String, firmaKlasor As String) As Task
        Log("[Migrate_ExistingUrls] Eski HTTP URL'leri işleniyor...")

        Using con As New OleDbConnection(connection)
            Using cmd As OleDbCommand = con.CreateCommand()
                cmd.CommandText =
                    "SELECT nStokResimID, sModel, " &
                    "ISNULL(sRenk,'') AS sRenk, " &
                    "ISNULL(yol,'') AS yol " &
                    "FROM tbStokResim WITH (NOLOCK) " &
                    "WHERE LEN(ISNULL(yol,'')) > 0 " &
                    "ORDER BY nStokResimID"

                con.Open()
                Using rd As OleDbDataReader = cmd.ExecuteReader()
                    Dim processedCount As Integer = 0
                    Dim currentSiraByModel As New Dictionary(Of String, Integer)

                    While rd.Read()
                        Dim resimID As Integer = SafeGetInt(rd, "nStokResimID")
                        Dim sModel As String = SafeGetStr(rd, "sModel")
                        Dim sRenk As String = SafeGetStr(rd, "sRenk")
                        Dim yolOld As String = SafeGetStr(rd, "yol")
                        
                        ' Güvenlik kontrolü: sModel boş olabilir
                        If String.IsNullOrEmpty(sModel) Then
                            Log("[SKIP] ResimID=" & resimID.ToString() & " sModel boş, atlanıyor")
                            Continue While
                        End If
                        
                        ' sRenk artık kullanılmıyor (nStokID kullanıyoruz)
                        ' Bu satır sadece backward compatibility için kalıyor

                        ' Her model için sıra numarası takibi
                        If Not currentSiraByModel.ContainsKey(sModel) Then
                            currentSiraByModel(sModel) = 1
                        Else
                            currentSiraByModel(sModel) += 1
                        End If

                        Dim nSira As Integer = currentSiraByModel(sModel)

                        ' Max 11 resim kontrolü
                        If nSira > MAX_RESIM_PER_STOK Then
                            Continue While
                        End If

                        ' R2 URL ise atla
                        If IsR2Url(yolOld) Then Continue While

                        ' HTTP/HTTPS URL değilse atla
                        If Not IsOldHttpUrl(yolOld) Then Continue While

                        Try
                            ' Varyant bilgilerini güvenli şekilde al
                            Dim varyantBilgisi As VaryantBilgisi = GetVaryantBilgisi(sModel)
                            
                            Dim fileName As String = BuildFileName(sModel, varyantBilgisi.sRenk, varyantBilgisi.sBeden, varyantBilgisi.sKavala, nSira)
                            Dim tempPath As String = Path.Combine(localFolder, "_tmp_" & resimID.ToString() & ".bin")
                            Dim localPath As String = Path.Combine(LOCAL_RESIM_ROOT, fileName)

                            ' HTTP veya FTP'den indir
                            If Not TryDownloadHttpThenFtp(yolOld, tempPath, firmaKlasor) Then
                                Log("[SKIP] ResimID=" & resimID.ToString() & " indirilemedi: " & yolOld)
                                Continue While
                            End If

                            ' Resize ve JPG'ye çevir
                            Dim jpgPath As String = Path.Combine(localFolder, fileName)
                            Using src As Image = Image.FromFile(tempPath)
                                Using resized As Image = ResizeToWidth(src, TARGET_WIDTH)
                                    SaveJpeg(jpgPath, resized, JPEG_QUALITY)
                                End Using
                            End Using

                            ' Geçici dosyayı sil
                            Try : File.Delete(tempPath) : Catch : End Try

                            ' Lokal klasöre kopyala
                            File.Copy(jpgPath, localPath, True)

                            ' R2'ye upload
                            Dim objectKey As String = BuildObjectKey(firmaKlasor, sModel, fileName)
                            Dim r2Url As String = Await TryUploadWithRetry(jpgPath, objectKey, "image/jpeg")

                            ' Veritabanını güncelle
                            ' Base64'e encode et
                            Dim base64String As String = ""
                            Using fs As New FileStream(jpgPath, FileMode.Open, FileAccess.Read)
                                Dim imgBytes As Byte() = New Byte(fs.Length - 1) {}
                                fs.Read(imgBytes, 0, imgBytes.Length)
                                base64String = Convert.ToBase64String(imgBytes)
                            End Using

                            ' nStokID'yi sModel'den al
                            Dim nStokID As Integer = 0
                            Using conStok As New OleDbConnection(connection)
                                Using cmdStok As New OleDbCommand("SELECT TOP 1 nStokID FROM tbStok WHERE sModel = ?", conStok)
                                    cmdStok.Parameters.Add("p0", OleDbType.VarChar, 50).Value = sModel
                                    conStok.Open()
                                    Dim resultStok = cmdStok.ExecuteScalar()
                                    If resultStok IsNot Nothing AndAlso Not IsDBNull(resultStok) Then
                                        nStokID = CInt(resultStok)
                                    End If
                                End Using
                            End Using
                            
                            ' Mevcut kaydı güncelle
                            Update_tbStokResim_BothColumns(resimID, base64String, r2Url, sModel, nStokID)
                            
                            ' Eski resimlerde renk/beden ayrımı yok, modelin DİĞER varyantlarına da ekle
                            ' (mevcut kayıt zaten güncellendi, diğer varyantlara INSERT yap)
                            Dim tumVaryantlar As List(Of StokVaryantBilgisi) = GetAllVariantsForModel(sModel)
                            For Each varItem As StokVaryantBilgisi In tumVaryantlar
                                ' Mevcut kaydın varyantını atla (zaten güncellendi)
                                If varItem.nStokID = nStokID Then Continue For
                                
                                Try
                                    Using conInsert As New OleDbConnection(connection)
                                        Using cmdInsert As New OleDbCommand()
                                            cmdInsert.Connection = conInsert
                                            cmdInsert.CommandText = "INSERT INTO tbStokResim (sModel, nStokID, sRenk, sBeden, sKavala, nSira, pResim, yol) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
                                            cmdInsert.Parameters.Add(New OleDbParameter("sModel", OleDbType.VarChar, 50)).Value = sModel
                                            cmdInsert.Parameters.Add(New OleDbParameter("nStokID", OleDbType.Integer)).Value = If(varItem.nStokID = 0, DBNull.Value, CObj(varItem.nStokID))
                                            cmdInsert.Parameters.Add(New OleDbParameter("sRenk", OleDbType.VarChar, 10)).Value = If(String.IsNullOrEmpty(varItem.sRenk), DBNull.Value, CObj(varItem.sRenk))
                                            cmdInsert.Parameters.Add(New OleDbParameter("sBeden", OleDbType.VarChar, 10)).Value = If(String.IsNullOrEmpty(varItem.sBeden), DBNull.Value, CObj(varItem.sBeden))
                                            cmdInsert.Parameters.Add(New OleDbParameter("sKavala", OleDbType.VarChar, 10)).Value = If(String.IsNullOrEmpty(varItem.sKavala), DBNull.Value, CObj(varItem.sKavala))
                                            cmdInsert.Parameters.Add(New OleDbParameter("nSira", OleDbType.Integer)).Value = nSira
                                            cmdInsert.Parameters.Add(New OleDbParameter("pResim", OleDbType.VarChar)).Value = base64String
                                            cmdInsert.Parameters.Add(New OleDbParameter("yol", OleDbType.VarChar, 500)).Value = r2Url
                                            
                                            conInsert.Open()
                                            cmdInsert.ExecuteNonQuery()
                                            Log("[INSERT OTHER VARIANT] Model=" & sModel & " nStokID=" & varItem.nStokID.ToString() & " sRenk=" & varItem.sRenk & " Sira=" & nSira.ToString())
                                        End Using
                                    End Using
                                Catch exVar As Exception
                                    Log("[INSERT OTHER VARIANT HATA] Model=" & sModel & " nStokID=" & varItem.nStokID.ToString() & ": " & exVar.Message)
                                End Try
                            Next

                            ' Geçici JPG'yi sil
                            Try : File.Delete(jpgPath) : Catch : End Try

                            processedCount += 1
                            Log("[OK] ResimID=" & resimID.ToString() & " Model=" & sModel & " Renk=" & sRenk & " Sira=" & nSira.ToString() & " OLD=" & yolOld & " -> R2: " & r2Url)

                        Catch ex As Exception
                            Log("[HATA] ResimID=" & resimID.ToString() & " Model=" & sModel & " URL=" & yolOld & ": " & ex.Message)
                        End Try
                    End While
                    Log("[Migrate_ExistingUrls] Tamamlandı. Toplam: " & processedCount.ToString() & " resim")
                End Using
            End Using
        End Using
    End Function


    ' =========================================================
    '                       ORTAK YARDIMCILAR
    ' =========================================================
    Private Function GetLisansSourceIp() As String
        Using con As New OleDbConnection(connection)
            Using cmd As OleDbCommand = con.CreateCommand()
                cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 Lisans FROM tbParamGenel"
                con.Open()
                Dim o = cmd.ExecuteScalar()
                Dim ip As String = If(o Is Nothing OrElse o Is DBNull.Value, "", CStr(o))
                If String.IsNullOrEmpty(ip) Then ip = GetLisansSourceIp()
                Return ip
            End Using
        End Using
    End Function

    Public Function GetOnayKoduFromRegistry() As String
        Try
            Return Microsoft.Win32.Registry.LocalMachine.
                OpenSubKey("Software").OpenSubKey("BusinessSmart").
                OpenSubKey("Key").GetValue("sOnayKodu").ToString()
        Catch
            Return ""
        End Try
    End Function

    Public Function GetFirmaKlasorByOnay(sourceIp As String, sOnayKodu As String) As String
        ' API üzerinden klasör adını al (güvenli yöntem)
        Try
            If Not String.IsNullOrEmpty(sOnayKodu) AndAlso sOnayKodu <> "0" Then
                Dim licenseResult = ApiClient.VerifyLicense(sOnayKodu, Form1.Netzwerk(3))
                If licenseResult.IsValid AndAlso Not String.IsNullOrEmpty(licenseResult.OzelNot) Then
                    Return licenseResult.OzelNot.Trim()
                End If
            End If
        Catch ex As Exception
            Debug.WriteLine("[GetFirmaKlasorByOnay] API hatası: " & ex.Message)
        End Try
        Return ""
    End Function

    Private Function ResizeToWidth(src As Image, targetWidth As Integer) As Image
        Dim ratio As Double = targetWidth / CDbl(src.Width)
        Dim w As Integer = targetWidth
        Dim h As Integer = CInt(Math.Round(src.Height * ratio))

        Dim bmp As New Bitmap(w, h)
        bmp.SetResolution(96, 96)

        Using g As Graphics = Graphics.FromImage(bmp)
            g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
            g.DrawImage(src, New Rectangle(0, 0, w, h))
        End Using

        Return bmp
    End Function

    Private Sub SaveJpeg(path As String, img As Image, quality As Long)
        Dim enc As Imaging.ImageCodecInfo = Nothing
        For Each c As Imaging.ImageCodecInfo In Imaging.ImageCodecInfo.GetImageEncoders()
            If c.MimeType = "image/jpeg" Then enc = c : Exit For
        Next
        If enc Is Nothing Then
            img.Save(path, Imaging.ImageFormat.Jpeg)
            Exit Sub
        End If
        Dim ep As New Imaging.EncoderParameters(1)
        ep.Param(0) = New Imaging.EncoderParameter(Imaging.Encoder.Quality, quality)
        img.Save(path, enc, ep)
    End Sub

    Private Function CleanBase64(s As String) As String
        If String.IsNullOrEmpty(s) Then Return ""
        Return s.Replace(vbCr, "").Replace(vbLf, "").Replace(" ", "")
    End Function

    Private Function SafeGetStr(rd As IDataRecord, col As String) As String
        Dim ix As Integer = rd.GetOrdinal(col)
        If rd.IsDBNull(ix) Then Return ""
        Return Convert.ToString(rd.GetValue(ix))
    End Function

    Private Function SafeGetInt(rd As IDataRecord, col As String) As Integer
        Dim ix As Integer = rd.GetOrdinal(col)
        If rd.IsDBNull(ix) Then Return 0
        Return Convert.ToInt32(rd.GetValue(ix))
    End Function

    Private Function HasColumn(rd As IDataRecord, col As String) As Boolean
        For i As Integer = 0 To rd.FieldCount - 1
            If String.Equals(rd.GetName(i), col, StringComparison.OrdinalIgnoreCase) Then Return True
        Next
        Return False
    End Function

    ' Varyant bilgilerini al (sModel ile tbStok'tan ilk kaydı çek)
    ' Eğer sModel ile eşleşen kayıt yoksa boş döner
    ' GÜVENLİK: sModel boş/NULL olsa bile hata vermez
    Private Function GetVaryantBilgisi(sModel As String) As VaryantBilgisi
        Dim result As New VaryantBilgisi()
        
        ' sModel boş/NULL kontrolü
        If String.IsNullOrEmpty(sModel) Then
            Log("[GetVaryantBilgisi] sModel boş, boş varyant dönüyor")
            Return result
        End If
        
        Try
            Using con As New OleDbConnection(connection)
                Using cmd As New OleDbCommand("SELECT TOP 1 sRenk, sBeden, sKavala FROM tbStok WHERE sModel = ?", con)
                    cmd.Parameters.Add("p0", OleDbType.VarChar, 50).Value = sModel
                    con.Open()
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            result.sRenk = If(reader.IsDBNull(0) OrElse reader.GetValue(0) Is Nothing, "", reader.GetValue(0).ToString().Trim())
                            result.sBeden = If(reader.IsDBNull(1) OrElse reader.GetValue(1) Is Nothing, "", reader.GetValue(1).ToString().Trim())
                            result.sKavala = If(reader.IsDBNull(2) OrElse reader.GetValue(2) Is Nothing, "", reader.GetValue(2).ToString().Trim())
                        Else
                            Log("[GetVaryantBilgisi] sModel=" & sModel & " için tbStok'ta kayıt bulunamadı, boş varyant dönüyor")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Hata olursa boş döner
            Log("[GetVaryantBilgisi HATA] sModel=" & sModel & ": " & ex.Message)
        End Try
        
        Return result
    End Function
    
    ' Modele ait TÜM varyantları al (tüm renk/beden kombinasyonları)
    ' Eski resimlerde renk/beden ayrımı olmadığında kullanılır
    ' GÜVENLİK: sModel boş/NULL olsa bile hata vermez
    Private Function GetAllVariantsForModel(sModel As String) As List(Of StokVaryantBilgisi)
        Dim varyantlar As New List(Of StokVaryantBilgisi)
        
        ' sModel boş/NULL kontrolü
        If String.IsNullOrEmpty(sModel) Then
            Log("[GetAllVariantsForModel] sModel boş, boş liste dönüyor")
            Return varyantlar
        End If
        
        Try
            Using con As New OleDbConnection(connection)
                Using cmd As New OleDbCommand("SELECT nStokID, ISNULL(sRenk,'') AS sRenk, ISNULL(sBeden,'') AS sBeden, ISNULL(sKavala,'') AS sKavala FROM tbStok WHERE sModel = ?", con)
                    cmd.Parameters.Add("p0", OleDbType.VarChar, 50).Value = sModel
                    con.Open()
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim varItem As New StokVaryantBilgisi()
                            varItem.nStokID = If(reader.IsDBNull(0), 0, reader.GetInt32(0))
                            varItem.sRenk = If(reader.IsDBNull(1) OrElse reader.GetValue(1) Is Nothing, "", reader.GetValue(1).ToString().Trim())
                            varItem.sBeden = If(reader.IsDBNull(2) OrElse reader.GetValue(2) Is Nothing, "", reader.GetValue(2).ToString().Trim())
                            varItem.sKavala = If(reader.IsDBNull(3) OrElse reader.GetValue(3) Is Nothing, "", reader.GetValue(3).ToString().Trim())
                            varyantlar.Add(varItem)
                        End While
                    End Using
                End Using
            End Using
            
            If varyantlar.Count = 0 Then
                Log("[GetAllVariantsForModel] Model=" & sModel & " için tbStok'ta varyant bulunamadı")
            End If
        Catch ex As Exception
            Log("[GetAllVariantsForModel HATA] Model=" & sModel & ": " & ex.Message)
        End Try
        
        Return varyantlar
    End Function
    
    ' Eski resim için TÜM varyantlara INSERT yap
    ' Renk/beden ayrımı olmayan eski resimleri modelin tüm varyantlarına ekler
    ' GÜVENLİK: sModel boş veya varyant yoksa güvenli şekilde handle eder
    Private Sub InsertInto_tbStokResim_AllVariants(sModel As String, nSira As Integer, base64String As String, r2Url As String)
        Try
            ' sModel boş/NULL kontrolü
            If String.IsNullOrEmpty(sModel) Then
                Log("[INSERT ALL VARIANTS] sModel boş, işlem iptal edildi")
                Return
            End If
            
            ' Modele ait tüm varyantları al
            Dim varyantlar = GetAllVariantsForModel(sModel)
            
            If varyantlar.Count = 0 Then
                ' Hiç varyant yoksa sadece model bazlı kaydet (eski davranış)
                Log("[INSERT] Model=" & sModel & " için tbStok'ta varyant bulunamadı, sadece model bazlı kaydediliyor")
                InsertInto_tbStokResim(sModel, nSira, base64String, r2Url)
                Return
            End If
            
            ' Her varyant için ayrı kayıt oluştur
            Dim successCount As Integer = 0
            For Each varItem As StokVaryantBilgisi In varyantlar
                Try
                    Using con As New OleDbConnection(connection)
                        Using cmd As New OleDbCommand()
                            cmd.Connection = con
                            cmd.CommandText = "INSERT INTO tbStokResim (sModel, nStokID, sRenk, sBeden, sKavala, nSira, pResim, yol) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
                            cmd.Parameters.Add(New OleDbParameter("sModel", OleDbType.VarChar, 50)).Value = sModel
                            cmd.Parameters.Add(New OleDbParameter("nStokID", OleDbType.Integer)).Value = If(varItem.nStokID = 0, DBNull.Value, CObj(varItem.nStokID))
                            cmd.Parameters.Add(New OleDbParameter("sRenk", OleDbType.VarChar, 10)).Value = If(String.IsNullOrEmpty(varItem.sRenk), DBNull.Value, CObj(varItem.sRenk))
                            cmd.Parameters.Add(New OleDbParameter("sBeden", OleDbType.VarChar, 10)).Value = If(String.IsNullOrEmpty(varItem.sBeden), DBNull.Value, CObj(varItem.sBeden))
                            cmd.Parameters.Add(New OleDbParameter("sKavala", OleDbType.VarChar, 10)).Value = If(String.IsNullOrEmpty(varItem.sKavala), DBNull.Value, CObj(varItem.sKavala))
                            cmd.Parameters.Add(New OleDbParameter("nSira", OleDbType.Integer)).Value = nSira
                            cmd.Parameters.Add(New OleDbParameter("pResim", OleDbType.VarChar)).Value = base64String
                            cmd.Parameters.Add(New OleDbParameter("yol", OleDbType.VarChar, 500)).Value = r2Url

                            con.Open()
                            cmd.ExecuteNonQuery()
                            successCount += 1
                            Log("[INSERT VARIANT OK] Model=" & sModel & ", nStokID=" & varItem.nStokID.ToString() & ", sRenk=" & varItem.sRenk & ", sBeden=" & varItem.sBeden & ", Sira=" & nSira.ToString())
                        End Using
                    End Using
                Catch exInsert As Exception
                    Log("[INSERT VARIANT HATA] Model=" & sModel & " nStokID=" & varItem.nStokID.ToString() & " Sira=" & nSira.ToString() & ": " & exInsert.Message)
                End Try
            Next
            
            Log("[INSERT ALL VARIANTS] Model=" & sModel & " için " & successCount.ToString() & "/" & varyantlar.Count.ToString() & " varyanta resim başarıyla eklendi")
        Catch ex As Exception
            Log("[INSERT ALL VARIANTS HATA] Model=" & sModel & " Sira=" & nSira.ToString() & ": " & ex.Message)
        End Try
    End Sub
    
    ' Dosya adı oluştur: sModel_sRenk_sBeden_sKavala_nSira_600.jpg
    Private Function BuildFileName(sModel As String, sRenk As String, sBeden As String, sKavala As String, nSira As Integer) As String
        Dim parts As New List(Of String) From {sModel.Trim()}
        If Not String.IsNullOrEmpty(sRenk) Then parts.Add(sRenk.Trim())
        If Not String.IsNullOrEmpty(sBeden) Then parts.Add(sBeden.Trim())
        If Not String.IsNullOrEmpty(sKavala) Then parts.Add(sKavala.Trim())
        parts.Add(nSira.ToString())
        parts.Add("600") ' Width
        Return String.Join("_", parts) & ".jpg"
    End Function

    Private Function BuildObjectKey(firmaKlasor As String, sModel As String, fileName As String) As String
        Dim klasorSlug As String = R2Helpers.SlugifyKeepDot(firmaKlasor)
        Dim modelSlug As String = R2Helpers.SlugifyKeepDot(Trim(sModel))
        Dim klasorUrlPart As String = If(String.IsNullOrEmpty(klasorSlug), "", klasorSlug & "/")
        ' products/<firmaKlasor>/<model>/<dosya>
        Return "products/" & klasorUrlPart & modelSlug & "/" & fileName
    End Function

    Private Async Function TryUploadWithRetry(localPath As String, objectKey As String, contentType As String) As Task(Of String)
        Dim attempt As Integer = 0
        Dim delayMs As Integer = 500
        Do
            Try
                Return Await R2Helpers.R2UploadAsync(localPath, objectKey, contentType, connection)
            Catch ex As Exception
                attempt += 1
                Log(String.Format("[UploadRetry] {0} deneme={1} hata={2}", objectKey, attempt, ex.Message))
                If attempt >= 3 Then Throw
            End Try
            Await Task.Delay(delayMs)
            delayMs = Math.Min(delayMs * 2, 4000)
        Loop
    End Function

    Private Sub Log(msg As String)
        Try
            File.AppendAllText(LOG_PATH, Date.Now.ToString("yyyy-MM-dd HH:mm:ss") & " " & msg & Environment.NewLine)
        Catch
        End Try
    End Sub

    ' ---------------- Overwrite & URL yardımcıları ----------------
    Private Function IsR2Url(u As String) As Boolean
        If String.IsNullOrEmpty(u) Then Return False
        ' R2Helpers'daki IsR2Url fonksiyonunu kullan
        Return R2Helpers.IsR2Url(u)
    End Function

    Private Function ShouldOverwrite(existing As String) As Boolean
        If String.IsNullOrEmpty(existing) Then Return True
        If OVERWRITE_NON_R2 AndAlso Not IsR2Url(existing) Then Return True
        Return False
    End Function

    Private Function IsOldHttpUrl(u As String) As Boolean
        If String.IsNullOrEmpty(u) Then Return False
        If IsR2Url(u) Then Return False
        Return u.StartsWith("http://", StringComparison.OrdinalIgnoreCase) OrElse u.StartsWith("https://", StringComparison.OrdinalIgnoreCase)
    End Function

    Private Function NormalizeUrl(u As String) As String
        If String.IsNullOrEmpty(u) Then Return u
        ' Encode/escape işi segment bazlı MapHttpToFtpUrl içinde yapılacak; burada sadece trim.
        Return u.Trim()
    End Function
    Private Function MapHttpToFtpUrl(oldHttp As String, firmaKlasor As String) As String
        Try
            Dim u As New Uri(oldHttp)
            Dim portPart As String = If(FTP_PORT <> 21, ":" & FTP_PORT.ToString(), "")
            Dim fileName As String = System.IO.Path.GetFileName(Uri.UnescapeDataString(u.AbsolutePath))
            Dim encFirma As String = Uri.EscapeDataString(firmaKlasor)
            Dim encFile As String = Uri.EscapeDataString(fileName)
            Dim pathCombined As String = FTP_BASE_PATH.TrimEnd("/"c) & "/" & encFirma & "/" & encFile
            Return "ftp://" & FTP_HOST & portPart & pathCombined
        Catch
            Return ""
        End Try
    End Function
    Private Function TryDownloadHttpThenFtp(oldUrl As String, targetPath As String, firmaKlasor As String) As Boolean
        ' Önce HTTP dene
        If TryDownloadHttp(oldUrl, targetPath) Then Return True

        ' Sonra FTP (aktifse)
        If Not FTP_ENABLED Then
            Log("[FB] FTP kapalı, HTTP başarısız -> vazgeçiliyor: " & oldUrl)
            Return False
        End If

        ' DOĞRU: HTTP URL'den FTP URL üret
        Dim ftpUrl As String = MapHttpToFtpUrl(oldUrl, firmaKlasor)
        If String.IsNullOrEmpty(ftpUrl) Then
            Log("[FB] MapHttpToFtpUrl boş döndü: " & oldUrl)
            Return False
        End If

        Log("[FB] HTTP olmadı, FTP denenecek: " & ftpUrl)
        Return TryDownloadFtp(ftpUrl, targetPath)
    End Function
    Private Function TryDownloadFtp(ftpUrl As String, targetPath As String) As Boolean
        Try
            Dim req As FtpWebRequest = CType(WebRequest.Create(New Uri(ftpUrl)), FtpWebRequest)
            req.Method = WebRequestMethods.Ftp.DownloadFile
            req.Credentials = New NetworkCredential(FTP_USER, FTP_PASS)
            req.UsePassive = FTP_USE_PASSIVE
            req.EnableSsl = FTP_USE_SSL
            req.UseBinary = True
            req.KeepAlive = False
            req.ReadWriteTimeout = 30000
            req.Timeout = 30000
            req.Proxy = Nothing
            Using resp As FtpWebResponse = CType(req.GetResponse(), FtpWebResponse)
                Using rs As Stream = resp.GetResponseStream()
                    Using fs As New FileStream(targetPath, FileMode.Create, FileAccess.Write, FileShare.None)
                        rs.CopyTo(fs)
                    End Using
                End Using
                Log(String.Format("[FTP OK] {0} -> {1} ({2})", ftpUrl, targetPath, resp.StatusDescription))
            End Using
            Return File.Exists(targetPath)
        Catch ex As WebException
            Dim status As String = ""
            Try
                Dim r = TryCast(ex.Response, FtpWebResponse)
                If r IsNot Nothing Then status = r.StatusDescription
            Catch
            End Try
            Log(String.Format("[FTP HATA] url={0} msg={1} status={2}", ftpUrl, ex.Message, status))
            Return False
        Catch ex As Exception
            Log(String.Format("[FTP HATA] url={0} msg={1}", ftpUrl, ex.Message))
            Return False
        End Try
    End Function
    ' ---------------- HTTP→FTP Fallback indirme ----------------
    Private Function TryDownloadHttp(oldUrl As String, targetPath As String) As Boolean
        Try
            Using wc As New WebClient()
                wc.Headers(HttpRequestHeader.UserAgent) = "ImgMigrator/1.0"
                wc.DownloadFile(oldUrl, targetPath)
            End Using
            Return File.Exists(targetPath)
        Catch ex As Exception
            Log(String.Format("[HTTP HATA] url={0} msg={1}", oldUrl, ex.Message))
            Return False
        End Try
    End Function

End Module
