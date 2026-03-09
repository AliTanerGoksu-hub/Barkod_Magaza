Imports System
Imports System.IO
Imports System.Data.OleDb
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports Microsoft.Win32

Public Class frm_TopluResimYukleme
    Inherits DevExpress.XtraEditors.XtraForm
    
    ' Public properties - Form1'den set edilecek
    Public connection As String
    Public kullanici As String
    
    ' UI Kontrolleri
    Private lblKlasorYolu As LabelControl
    Private txtKlasorYolu As TextEdit
    Private btnKlasorSec As SimpleButton
    Private btnYuklemeBaslat As SimpleButton
    Private btnKapat As SimpleButton
    Private progressBar As System.Windows.Forms.ProgressBar
    Private lblDurum As LabelControl
    Private lblDetay As LabelControl
    Private memoSonuc As MemoEdit
    
    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub
    
    Private Sub InitializeComponent()
        Me.lblKlasorYolu = New LabelControl()
        Me.txtKlasorYolu = New TextEdit()
        Me.btnKlasorSec = New SimpleButton()
        Me.btnYuklemeBaslat = New SimpleButton()
        Me.btnKapat = New SimpleButton()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.lblDurum = New LabelControl()
        Me.lblDetay = New LabelControl()
        Me.memoSonuc = New MemoEdit()
        
        CType(Me.txtKlasorYolu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memoSonuc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        
        ' lblKlasorYolu
        Me.lblKlasorYolu.Location = New System.Drawing.Point(20, 20)
        Me.lblKlasorYolu.Name = "lblKlasorYolu"
        Me.lblKlasorYolu.Size = New System.Drawing.Size(90, 13)
        Me.lblKlasorYolu.TabIndex = 0
        Me.lblKlasorYolu.Text = "Resim Klasörü:"
        
        ' txtKlasorYolu
        Me.txtKlasorYolu.Location = New System.Drawing.Point(120, 17)
        Me.txtKlasorYolu.Name = "txtKlasorYolu"
        Me.txtKlasorYolu.Properties.ReadOnly = True
        Me.txtKlasorYolu.Size = New System.Drawing.Size(450, 20)
        Me.txtKlasorYolu.TabIndex = 1
        
        ' btnKlasorSec
        Me.btnKlasorSec.Location = New System.Drawing.Point(580, 15)
        Me.btnKlasorSec.Name = "btnKlasorSec"
        Me.btnKlasorSec.Size = New System.Drawing.Size(100, 25)
        Me.btnKlasorSec.TabIndex = 2
        Me.btnKlasorSec.Text = "Klasör Seç..."
        AddHandler Me.btnKlasorSec.Click, AddressOf btnKlasorSec_Click
        
        ' lblDurum
        Me.lblDurum.Location = New System.Drawing.Point(20, 60)
        Me.lblDurum.Name = "lblDurum"
        Me.lblDurum.Size = New System.Drawing.Size(250, 13)
        Me.lblDurum.TabIndex = 3
        Me.lblDurum.Text = "Hazır. Lütfen klasör seçin."
        
        ' progressBar
        Me.progressBar.Location = New System.Drawing.Point(20, 85)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(660, 25)
        Me.progressBar.TabIndex = 4
        
        ' lblDetay
        Me.lblDetay.Location = New System.Drawing.Point(20, 120)
        Me.lblDetay.Name = "lblDetay"
        Me.lblDetay.Size = New System.Drawing.Size(200, 13)
        Me.lblDetay.TabIndex = 5
        Me.lblDetay.Text = ""
        
        ' memoSonuc
        Me.memoSonuc.Location = New System.Drawing.Point(20, 145)
        Me.memoSonuc.Name = "memoSonuc"
        Me.memoSonuc.Properties.ReadOnly = True
        Me.memoSonuc.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.memoSonuc.Size = New System.Drawing.Size(660, 220)
        Me.memoSonuc.TabIndex = 6
        
        ' btnYuklemeBaslat
        Me.btnYuklemeBaslat.Enabled = False
        Me.btnYuklemeBaslat.Location = New System.Drawing.Point(480, 380)
        Me.btnYuklemeBaslat.Name = "btnYuklemeBaslat"
        Me.btnYuklemeBaslat.Size = New System.Drawing.Size(100, 30)
        Me.btnYuklemeBaslat.TabIndex = 7
        Me.btnYuklemeBaslat.Text = "Yüklemeyi Başlat"
        AddHandler Me.btnYuklemeBaslat.Click, AddressOf btnYuklemeBaslat_Click
        
        ' btnKapat
        Me.btnKapat.Location = New System.Drawing.Point(590, 380)
        Me.btnKapat.Name = "btnKapat"
        Me.btnKapat.Size = New System.Drawing.Size(90, 30)
        Me.btnKapat.TabIndex = 8
        Me.btnKapat.Text = "Kapat"
        AddHandler Me.btnKapat.Click, AddressOf btnKapat_Click
        
        ' Form
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 430)
        Me.Controls.Add(Me.btnKapat)
        Me.Controls.Add(Me.btnYuklemeBaslat)
        Me.Controls.Add(Me.memoSonuc)
        Me.Controls.Add(Me.lblDetay)
        Me.Controls.Add(Me.progressBar)
        Me.Controls.Add(Me.lblDurum)
        Me.Controls.Add(Me.btnKlasorSec)
        Me.Controls.Add(Me.txtKlasorYolu)
        Me.Controls.Add(Me.lblKlasorYolu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_TopluResimYukleme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Toplu Resim Yükleme (Varyant Bazlı)"
        
        CType(Me.txtKlasorYolu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memoSonuc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    
    Private Sub btnKlasorSec_Click(sender As Object, e As EventArgs)
        Using folderDialog As New FolderBrowserDialog()
            folderDialog.Description = "Resim dosyalarının bulunduğu klasörü seçin"
            
            If folderDialog.ShowDialog() = DialogResult.OK Then
                txtKlasorYolu.Text = folderDialog.SelectedPath
                
                ' Klasördeki resim sayısını kontrol et
                Dim imageFiles As Integer = Directory.GetFiles(folderDialog.SelectedPath, "*.*", SearchOption.TopDirectoryOnly) _
                    .Where(Function(f) f.ToLower().EndsWith(".jpg") OrElse 
                                       f.ToLower().EndsWith(".jpeg") OrElse 
                                       f.ToLower().EndsWith(".png")).Count()
                
                lblDurum.Text = $"{imageFiles} adet resim dosyası bulundu. Yüklemey başlatabilirsiniz."
                btnYuklemeBaslat.Enabled = (imageFiles > 0)
                memoSonuc.Text = ""
            End If
        End Using
    End Sub
    
    Private Async Sub btnYuklemeBaslat_Click(sender As Object, e As EventArgs)
        Try
            Dim klasorYolu As String = txtKlasorYolu.Text
            
            If String.IsNullOrEmpty(klasorYolu) Then
                XtraMessageBox.Show("Lütfen önce bir klasör seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            
            ' Resimleri al
            Dim imageFiles As String() = Directory.GetFiles(klasorYolu, "*.*", SearchOption.TopDirectoryOnly) _
                .Where(Function(f) f.ToLower().EndsWith(".jpg") OrElse 
                                   f.ToLower().EndsWith(".jpeg") OrElse 
                                   f.ToLower().EndsWith(".png")).ToArray()
            
            If imageFiles.Length = 0 Then
                XtraMessageBox.Show("Seçilen klasörde resim dosyası bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            
            ' Onay al
            Dim confirmMsg As String = $"{imageFiles.Length} adet resim dosyası bulundu.{vbCrLf}{vbCrLf}" &
                $"Bu resimleri model ve varyant kodlarına göre otomatik olarak stok kartlarına yüklemek istiyor musunuz?{vbCrLf}{vbCrLf}" &
                $"İşlem uzun sürebilir!"
            
            If XtraMessageBox.Show(confirmMsg, "Toplu Resim Yükleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                Return
            End If
            
            ' UI'ı kilitle
            btnYuklemeBaslat.Enabled = False
            btnKlasorSec.Enabled = False
            btnKapat.Enabled = False
            progressBar.Minimum = 0
            progressBar.Maximum = imageFiles.Length
            progressBar.Value = 0
            memoSonuc.Text = "İşlem başlatılıyor..." & vbCrLf
            
            ' lRenkNo kolonunu ekle (eğer yoksa)
            EnsureLRenkNoColumnExists()
            
            Await TopluResimYukle(imageFiles)
            
        Catch ex As Exception
            XtraMessageBox.Show($"Toplu resim yükleme hatası:{vbCrLf}{vbCrLf}{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' UI'ı aç
            btnKlasorSec.Enabled = True
            btnKapat.Enabled = True
            btnYuklemeBaslat.Enabled = True
        End Try
    End Sub
    
    Private Sub btnKapat_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    
    Private Async Function TopluResimYukle(imageFiles As String()) As Task
        ' İstatistikler
        Dim totalFiles As Integer = imageFiles.Length
        Dim successCount As Integer = 0
        Dim failedCount As Integer = 0
        Dim skippedCount As Integer = 0
        Dim failedFiles As New List(Of String)
        
        For i As Integer = 0 To imageFiles.Length - 1
            Dim imagePath As String = imageFiles(i)
            Dim fileName As String = Path.GetFileName(imagePath)
            
            lblDurum.Text = $"İşleniyor: {i + 1} / {totalFiles}"
            lblDetay.Text = $"Dosya: {fileName}"
            progressBar.Value = i + 1
            Application.DoEvents()
            
            ' Dosya adından bilgileri çıkar
            Dim sModel As String = ""
            Dim lRenkNo As String = ""
            Dim resimNo As Integer = 0
            
            If Not ParseImageFileName(fileName, sModel, lRenkNo, resimNo) Then
                failedFiles.Add($"{fileName} (Dosya adı formatı hatalı)")
                failedCount += 1
                AppendLog($"✗ {fileName} - Dosya adı formatı hatalı")
                Continue For
            End If
            
            ' tbRenk'ten lRenkNo'ya göre renk kodlarını bul
            Dim resimNoStr As String = If(resimNo > 0, $" #{resimNo}", "")
            AppendLog($"→ {fileName}: Model='{sModel}', lRenkNo='{lRenkNo}'{resimNoStr}")
            Dim renkKodlari As List(Of String) = GetRenkKoduFromLRenkNo(lRenkNo)
            
            If renkKodlari.Count = 0 Then
                failedFiles.Add($"{fileName} (lRenkNo='{lRenkNo}' için renk kodu bulunamadı)")
                skippedCount += 1
                AppendLog($"  ⊘ lRenkNo '{lRenkNo}' için renk kodu bulunamadı")
                Continue For
            End If
            
            AppendLog($"  ✓ {renkKodlari.Count} renk kodu bulundu: {String.Join(", ", renkKodlari)}")
            
            ' Her renk kodu için stokları bul ve yükle
            Dim uploadedToAnyStok As Boolean = False
            
            For Each sRenk As String In renkKodlari
                ' Bu model ve renk koduna sahip stokları bul
                Dim stokIDs As List(Of Integer) = GetStokIDsByModelAndRenk(sModel, sRenk)
                
                If stokIDs.Count = 0 Then
                    AppendLog($"  ⊘ Model='{sModel}' + Renk='{sRenk}' için stok kaydı yok")
                    Continue For
                End If
                
                AppendLog($"  ✓ Renk '{sRenk}' için {stokIDs.Count} stok bulundu")
                
                ' Her stok için resmi yükle
                For Each nStokID As Integer In stokIDs
                    lblDetay.Text = $"Model: {sModel}, Varyant: {lRenkNo} → Renk: {sRenk}, StokID: {nStokID}"
                    Application.DoEvents()
                    
                    Dim uploaded As Boolean = Await UploadImageToStok(imagePath, nStokID, sModel, sRenk, lRenkNo, resimNo)
                    
                    If uploaded Then
                        uploadedToAnyStok = True
                        AppendLog($"✓ {fileName} → StokID: {nStokID} (Model: {sModel}, Renk: {sRenk})")
                    End If
                Next
            Next
            
            If uploadedToAnyStok Then
                successCount += 1
            Else
                failedFiles.Add($"{fileName} (Stok kaydı bulunamadı)")
                skippedCount += 1
                AppendLog($"⊘ {fileName} - Stok kaydı bulunamadı")
            End If
        Next
        
        ' Sonuç raporu
        lblDurum.Text = "İşlem tamamlandı!"
        lblDetay.Text = ""
        
        Dim resultMsg As String = vbCrLf & "═══════════════════════════════" & vbCrLf &
            "TOPLU RESİM YÜKLEME TAMAMLANDI!" & vbCrLf &
            "═══════════════════════════════" & vbCrLf &
            $"Toplam Dosya: {totalFiles}" & vbCrLf &
            $"✓ Başarılı: {successCount}" & vbCrLf &
            $"✗ Başarısız: {failedCount}" & vbCrLf &
            $"⊘ Atlandı: {skippedCount}"
        
        If failedFiles.Count > 0 Then
            resultMsg &= vbCrLf & vbCrLf & "HATALI DOSYALAR:" & vbCrLf & String.Join(vbCrLf, failedFiles.Take(20))
            If failedFiles.Count > 20 Then
                resultMsg &= vbCrLf & $"... ve {failedFiles.Count - 20} dosya daha"
            End If
        End If
        
        AppendLog(resultMsg)
        
        XtraMessageBox.Show(resultMsg, "Toplu Yükleme Sonucu", MessageBoxButtons.OK, 
            If(failedCount + skippedCount = 0, MessageBoxIcon.Information, MessageBoxIcon.Warning))
    End Function
    
    Private Sub AppendLog(message As String)
        memoSonuc.Text &= message & vbCrLf
        memoSonuc.SelectionStart = memoSonuc.Text.Length
        memoSonuc.ScrollToCaret()
    End Sub
    
    ' ============================================================================
    ' YARDIMCI FONKSİYONLAR
    ' ============================================================================
    
    Private Function ParseImageFileName(fileName As String, ByRef sModel As String, ByRef lRenkNo As String, ByRef resimNo As Integer) As Boolean
        Try
            Dim nameWithoutExt As String = Path.GetFileNameWithoutExtension(fileName)
            Dim lastDashIndex As Integer = nameWithoutExt.LastIndexOf("-")
            
            If lastDashIndex = -1 Then
                Return False
            End If
            
            sModel = nameWithoutExt.Substring(0, lastDashIndex).Trim()
            Dim variantPart As String = nameWithoutExt.Substring(lastDashIndex + 1).Trim().ToUpper()
            
            ' Parantez içindeki resim numarasını çıkar: "V1 (3)" → lRenkNo = "V1", resimNo = 3
            resimNo = 0  ' 0 = otomatik slot bul
            Dim parantezIndex As Integer = variantPart.IndexOf("(")
            
            If parantezIndex > 0 Then
                lRenkNo = variantPart.Substring(0, parantezIndex).Trim()
                
                ' Parantez içindeki sayıyı çıkar
                Dim parantezKapama As Integer = variantPart.IndexOf(")")
                If parantezKapama > parantezIndex Then
                    Dim numStr As String = variantPart.Substring(parantezIndex + 1, parantezKapama - parantezIndex - 1).Trim()
                    Integer.TryParse(numStr, resimNo)
                End If
            Else
                lRenkNo = variantPart
                resimNo = 0  ' Otomatik slot
            End If
            
            If String.IsNullOrEmpty(sModel) OrElse String.IsNullOrEmpty(lRenkNo) Then
                Return False
            End If
            
            Return True
        Catch
            Return False
        End Try
    End Function
    
    Private Function GetRenkKoduFromLRenkNo(lRenkNo As String) As List(Of String)
        Dim renkKodlari As New List(Of String)
        
        Try
            Using con As New OleDbConnection(connection)
                con.Open()
                Using cmd As New OleDbCommand("SELECT sRenk FROM tbRenk WHERE lRenkNo LIKE ?", con)
                    cmd.Parameters.Add("lRenkNo", OleDbType.VarChar, 10).Value = lRenkNo.Trim() & "%"
                    
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            If Not reader.IsDBNull(0) Then
                                Dim renkKodu As String = reader.GetString(0).Trim()
                                If Not String.IsNullOrEmpty(renkKodu) Then
                                    renkKodlari.Add(renkKodu)
                                End If
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch
            ' Ignore
        End Try
        
        Return renkKodlari
    End Function
    
    Private Function GetStokIDsByModelAndRenk(sModel As String, sRenk As String) As List(Of Integer)
        Dim stokIDs As New List(Of Integer)
        
        Try
            Using con As New OleDbConnection(connection)
                con.Open()
                Using cmd As New OleDbCommand("SELECT nStokID FROM tbStok WHERE sModel LIKE ? AND sRenk LIKE ?", con)
                    cmd.Parameters.Add("sModel", OleDbType.VarChar, 50).Value = sModel.Trim() & "%"
                    cmd.Parameters.Add("sRenk", OleDbType.VarChar, 10).Value = sRenk.Trim() & "%"
                    
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            If Not reader.IsDBNull(0) Then
                                stokIDs.Add(reader.GetInt32(0))
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch
            ' Ignore
        End Try
        
        Return stokIDs
    End Function
    
    Private Sub EnsureLRenkNoColumnExists()
        Try
            Using con As New OleDbConnection(connection)
                con.Open()
                
                Dim columnExists As Boolean = False
                Using cmdCheck As New OleDbCommand(
                    "SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'tbStokResim' AND COLUMN_NAME = 'lRenkNo'", con)
                    Dim count As Integer = CInt(cmdCheck.ExecuteScalar())
                    columnExists = (count > 0)
                End Using
                
                If Not columnExists Then
                    Using cmdAdd As New OleDbCommand("ALTER TABLE tbStokResim ADD lRenkNo VARCHAR(10)", con)
                        cmdAdd.ExecuteNonQuery()
                        AppendLog("✓ tbStokResim tablosuna lRenkNo kolonu eklendi")
                    End Using
                Else
                    AppendLog("✓ lRenkNo kolonu zaten mevcut")
                End If
            End Using
        Catch ex As Exception
            AppendLog($"⚠ lRenkNo kolonu kontrol hatası: {ex.Message}")
        End Try
    End Sub
    
    Private Async Function UploadImageToStok(
        imagePath As String,
        nStokID As Integer,
        sModel As String,
        sRenk As String,
        lRenkNo As String,
        resimNo As Integer) As Task(Of Boolean)
        
        Try
            ' tbStok'tan sBeden ve sKavala bilgilerini al
            Dim sBeden As String = ""
            Dim sKavala As String = ""
            Dim sKodu As String = ""
            
            Using con As New OleDbConnection(connection)
                con.Open()
                Using cmd As New OleDbCommand("SELECT sKodu, sBeden, sKavala FROM tbStok WHERE nStokID = ?", con)
                    cmd.Parameters.Add("nStokID", OleDbType.Integer).Value = nStokID
                    
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            sKodu = If(reader.IsDBNull(0), "", reader.GetString(0).Trim())
                            sBeden = If(reader.IsDBNull(1), "", reader.GetString(1).Trim())
                            sKavala = If(reader.IsDBNull(2), "", reader.GetString(2).Trim())
                        End If
                    End Using
                End Using
            End Using
            
            ' Resim slot'u al
            ' Eğer dosya adında numara varsa (örn: V1 (3).jpg), o numarayı kullan
            ' Yoksa, otomatik boş slot bul
            Dim nSira As Integer
            If resimNo > 0 AndAlso resimNo <= 11 Then
                nSira = resimNo
            Else
                nSira = GetNextAvailableSlot_tbStokResim(sModel, sRenk, nStokID)
            End If
            
            If nSira > 11 Then
                Return False
            End If
            
            ' Resmi yükle ve byte array'e çevir
            Dim imageBytes As Byte()
            Using fs As New FileStream(imagePath, FileMode.Open, FileAccess.Read)
                imageBytes = New Byte(fs.Length - 1) {}
                fs.Read(imageBytes, 0, imageBytes.Length)
            End Using
            
            ' R2'ye upload et
            Dim klasor As String = GetFirmaKlasorAdi()
            
            Dim fileNameParts As New List(Of String) From {sModel.Trim()}
            If Not String.IsNullOrEmpty(sRenk) Then fileNameParts.Add(sRenk.Trim())
            If Not String.IsNullOrEmpty(sBeden) Then fileNameParts.Add(sBeden.Trim())
            If Not String.IsNullOrEmpty(sKavala) Then fileNameParts.Add(sKavala.Trim())
            fileNameParts.Add(nSira.ToString())
            
            Dim fileName As String = String.Join("_", fileNameParts) & ".jpg"
            Dim objectKey As String = If(String.IsNullOrEmpty(klasor),
                "products/" & sModel.Trim() & "/" & fileName,
                "products/" & klasor & "/" & sModel.Trim() & "/" & fileName)
            
            Dim uploadedUrl As String = Await R2Helpers.R2UploadFromBytesAsync(imageBytes, objectKey, "image/jpeg")
            
            ' Base64 encode
            Dim base64String As String = Convert.ToBase64String(imageBytes)
            
            ' Database'e kaydet
            Using con As New OleDbConnection(connection)
                con.Open()
                
                Try
                    Using cmdClean As New OleDbCommand("IF @@TRANCOUNT > 0 ROLLBACK TRAN; SET IMPLICIT_TRANSACTIONS OFF", con)
                        cmdClean.ExecuteNonQuery()
                    End Using
                Catch
                End Try
                
                Using cmdBegin As New OleDbCommand("BEGIN TRAN", con)
                    cmdBegin.ExecuteNonQuery()
                End Using
                
                Try
                    Dim existingId As Object = Nothing
                    Using cmdCheck As New OleDbCommand(
                        "SELECT nStokResimID FROM tbStokResim WHERE nStokID = ? AND nSira = ?", con)
                        cmdCheck.Parameters.Add("p0", OleDbType.Integer).Value = nStokID
                        cmdCheck.Parameters.Add("p1", OleDbType.Integer).Value = nSira
                        existingId = cmdCheck.ExecuteScalar()
                    End Using
                    
                    If existingId Is Nothing Then
                        Using cmd As OleDbCommand = con.CreateCommand()
                            cmd.CommandText = "INSERT INTO tbStokResim (sModel, nStokID, sRenk, sBeden, sKavala, lRenkNo, nSira, pResim, yol, sAciklama, sKullaniciAdi, dteKayitTarihi) " &
                                             "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
                            cmd.Parameters.Add("sModel", OleDbType.VarChar, 50).Value = sModel
                            cmd.Parameters.Add("nStokID", OleDbType.Integer).Value = nStokID
                            cmd.Parameters.Add("sRenk", OleDbType.VarChar, 10).Value = If(String.IsNullOrEmpty(sRenk), DBNull.Value, CObj(sRenk))
                            cmd.Parameters.Add("sBeden", OleDbType.VarChar, 10).Value = If(String.IsNullOrEmpty(sBeden), DBNull.Value, CObj(sBeden))
                            cmd.Parameters.Add("sKavala", OleDbType.VarChar, 10).Value = If(String.IsNullOrEmpty(sKavala), DBNull.Value, CObj(sKavala))
                            cmd.Parameters.Add("lRenkNo", OleDbType.VarChar, 10).Value = If(String.IsNullOrEmpty(lRenkNo), DBNull.Value, CObj(lRenkNo))
                            cmd.Parameters.Add("nSira", OleDbType.Integer).Value = nSira
                            
                            Dim pResimParam As New OleDbParameter("pResim", OleDbType.LongVarChar)
                            pResimParam.Value = If(String.IsNullOrEmpty(base64String), DBNull.Value, CObj(base64String))
                            cmd.Parameters.Add(pResimParam)
                            
                            cmd.Parameters.Add("yol", OleDbType.VarChar, 500).Value = uploadedUrl
                            cmd.Parameters.Add("sAciklama", OleDbType.VarChar, 250).Value = ""
                            cmd.Parameters.Add("sKullaniciAdi", OleDbType.VarChar, 50).Value = kullanici
                            cmd.Parameters.Add("dteKayitTarihi", OleDbType.DBTimeStamp).Value = Now
                            
                            cmd.ExecuteNonQuery()
                        End Using
                    Else
                        Using cmd As OleDbCommand = con.CreateCommand()
                            cmd.CommandText = "UPDATE tbStokResim SET pResim = ?, yol = ?, sRenk = ?, sBeden = ?, sKavala = ?, lRenkNo = ?, sKullaniciAdi = ?, dteKayitTarihi = ? " &
                                             "WHERE nStokID = ? AND nSira = ?"
                            cmd.Parameters.Add("pResim", OleDbType.LongVarChar).Value = base64String
                            cmd.Parameters.Add("yol", OleDbType.VarChar, 500).Value = uploadedUrl
                            cmd.Parameters.Add("sRenk", OleDbType.VarChar, 10).Value = If(String.IsNullOrEmpty(sRenk), DBNull.Value, CObj(sRenk))
                            cmd.Parameters.Add("sBeden", OleDbType.VarChar, 10).Value = If(String.IsNullOrEmpty(sBeden), DBNull.Value, CObj(sBeden))
                            cmd.Parameters.Add("sKavala", OleDbType.VarChar, 10).Value = If(String.IsNullOrEmpty(sKavala), DBNull.Value, CObj(sKavala))
                            cmd.Parameters.Add("lRenkNo", OleDbType.VarChar, 10).Value = If(String.IsNullOrEmpty(lRenkNo), DBNull.Value, CObj(lRenkNo))
                            cmd.Parameters.Add("sKullaniciAdi", OleDbType.VarChar, 50).Value = kullanici
                            cmd.Parameters.Add("dteKayitTarihi", OleDbType.DBTimeStamp).Value = Now
                            cmd.Parameters.Add("nStokID", OleDbType.Integer).Value = nStokID
                            cmd.Parameters.Add("nSira", OleDbType.Integer).Value = nSira
                            
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                    
                    Using cmdCommit As New OleDbCommand("COMMIT TRAN", con)
                        cmdCommit.ExecuteNonQuery()
                    End Using
                    
                    Return True
                    
                Catch dbEx As Exception
                    Try
                        Using cmdRollback As New OleDbCommand("IF @@TRANCOUNT > 0 ROLLBACK TRAN", con)
                            cmdRollback.ExecuteNonQuery()
                        End Using
                    Catch
                    End Try
                    
                    Throw dbEx
                End Try
            End Using
            
        Catch ex As Exception
            Return False
        End Try
    End Function
    
    Private Function GetFirmaKlasorAdi() As String
        Dim klasor As String = ""
        
        Try
            Dim sourceIP As String = ""
            Using conLocal As New OleDbConnection(connection)
                conLocal.Open()
                Using cmdSource As New OleDbCommand("SELECT TOP 1 Lisans FROM tbParamGenel", conLocal)
                    Dim result As Object = cmdSource.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        sourceIP = result.ToString().Trim()
                    End If
                End Using
            End Using
            
            If String.IsNullOrEmpty(sourceIP) Then
                sourceIP = "212.156.206.214"
            End If
            
            Dim sOnayKodu As String = ""
            Try
                sOnayKodu = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("Key").GetValue("sOnayKodu").ToString()
            Catch
                sOnayKodu = ""
            End Try
            
            If Not String.IsNullOrEmpty(sOnayKodu) AndAlso sOnayKodu <> "0" Then
                Dim remoteConnectionString As String = String.Format(
                    "Provider=SQLOLEDB.1;Password=87918991;Persist Security Info=True;User ID=bayii1;Initial Catalog=BAYII;Data Source={0},8991",
                    sourceIP)
                
                Try
                    Using conRemote As New OleDbConnection(remoteConnectionString)
                        conRemote.Open()
                        Using cmdKlasor As New OleDbCommand(
                            "SELECT TOP 1 tbFirma.sOzelNot " &
                            "FROM tbFirmaLisans " &
                            "INNER JOIN tbFirma ON tbFirmaLisans.nFirmaID = tbFirma.nFirmaID " &
                            "WHERE tbFirmaLisans.sOnayKodu = ?", conRemote)
                            cmdKlasor.Parameters.Add("sOnayKodu", OleDbType.VarChar, 50).Value = sOnayKodu
                            
                            Dim result As Object = cmdKlasor.ExecuteScalar()
                            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                                klasor = result.ToString().Trim()
                            End If
                        End Using
                    End Using
                Catch
                    klasor = ""
                End Try
            End If
        Catch
            klasor = ""
        End Try
        
        Return klasor
    End Function
    
    Private Function GetNextAvailableSlot_tbStokResim(sModel As String, sRenk As String, nStokID As Integer) As Integer
        Try
            Using con As New OleDbConnection(connection)
                con.Open()
                
                ' En yüksek nSira değerini al
                Using cmd As New OleDbCommand(
                    "SELECT ISNULL(MAX(nSira), 0) FROM tbStokResim WHERE nStokID = ? AND ISNULL(sRenk,'') = ISNULL(?,'') ORDER BY nSira", con)
                    cmd.Parameters.Add("p0", OleDbType.Integer).Value = nStokID
                    cmd.Parameters.Add("p1", OleDbType.VarChar, 10).Value = If(String.IsNullOrEmpty(sRenk), DBNull.Value, CObj(sRenk))
                    
                    Dim maxSira As Object = cmd.ExecuteScalar()
                    Dim nextSira As Integer = If(maxSira Is Nothing OrElse IsDBNull(maxSira), 1, CInt(maxSira) + 1)
                    
                    Return nextSira
                End Using
            End Using
        Catch
            Return 1
        End Try
    End Function
    
End Class
