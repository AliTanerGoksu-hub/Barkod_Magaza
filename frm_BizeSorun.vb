Imports System.Collections.Generic
Imports System.Net.Mail
Imports DevExpress.XtraEditors
Imports System.Net
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Management
Imports System.Text
Imports Microsoft.Win32
Imports System.Threading
Imports System.Data.SqlClient

Public Class frm_BizeSorun
    ' Ticket sistemi değişkenleri
    Private ticketNo As String = ""
    Private ekliDosyalar As New List(Of String)()
    Private Const MAX_VIDEO_SIZE As Long = 50 * 1024 * 1024 ' 50 MB
    Private Const MAX_IMAGE_SIZE As Long = 10 * 1024 * 1024 ' 10 MB
    Private sistemBilgisi As String = ""
    
    ' Desteklenen dosya uzantıları
    Private desteklenenResimler() As String = {".jpg", ".jpeg", ".png", ".gif", ".bmp"}
    Private desteklenenVideolar() As String = {".mp4", ".avi", ".mov", ".wmv", ".mkv"}

#Region "Form Events"
    
    Private Sub frm_BizeSorun_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Ticket numarası oluştur
        ticketNo = OlusturTicketNo()
        lbl_TicketNo.Text = "Ticket: " & ticketNo
        
        ' Sistem bilgisini topla
        sistemBilgisi = ToplamSistemBilgisi()
        
        ' Drag-Drop aktif et
        Me.AllowDrop = True
        txt_sMesaj.AllowDrop = True
        pnl_DosyaAlani.AllowDrop = True
        
        ' Varsayılan değerler
        txt_sOncelik.SelectedIndex = 0
        txt_sKategori.SelectedIndex = 0
        
        ' Ticket geçmişini yükle
        YukleTicketGecmisi()
        
        ' Tab kontrolü ayarla
        tabControl.SelectedTabPageIndex = 0
        
        ' Durum çubuğu
        GuncelleDurumCubugu("Hazır - Yeni destek talebi oluşturabilirsiniz")
    End Sub
    
    Private Sub frm_BizeSorun_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Geçici dosyaları temizle
        TemizleGeciciDosyalar()
    End Sub

#End Region

#Region "Ticket Numarası Oluşturma"
    
    Private Function OlusturTicketNo() As String
        ' Format: TKT-YYYY-NNNNN
        Dim yil As String = DateTime.Now.Year.ToString()
        Dim siraNo As Integer = GetNextTicketNumber()
        Return String.Format("TKT-{0}-{1:D5}", yil, siraNo)
    End Function
    
    Private Function GetNextTicketNumber() As Integer
        Dim nextNo As Integer = 1
        Try
            Using conn As New SqlConnection(KeyCode.SQLconnection)
                conn.Open()
                Dim cmd As New SqlCommand("SELECT ISNULL(MAX(TicketSiraNo), 0) + 1 FROM DESTEK_TICKET WHERE YEAR(OlusturmaTarihi) = YEAR(GETDATE())", conn)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    nextNo = Convert.ToInt32(result)
                End If
            End Using
        Catch ex As Exception
            ' Hata durumunda timestamp bazlı numara
            nextNo = CInt(DateTime.Now.Ticks Mod 100000)
        End Try
        Return nextNo
    End Function

#End Region

#Region "Sistem Bilgisi Toplama"
    
    Private Function ToplamSistemBilgisi() As String
        Dim sb As New StringBuilder()
        
        Try
            sb.AppendLine("========== SİSTEM BİLGİLERİ ==========")
            sb.AppendLine()
            
            ' Lisans ve Firma Bilgileri
            sb.AppendLine("── LİSANS VE FİRMA BİLGİLERİ ──")
            Try
                ' tbFirmaLisans + tbFirma'dan lisans ve firma bilgilerini al
                Dim lisansSahibiBilgileri As DataRow = GetLisansSahibiBilgileri()
                If lisansSahibiBilgileri IsNot Nothing Then
                    sb.AppendLine(String.Format("Firma Adı (Lisans): {0}", GetSafeString(lisansSahibiBilgileri, "sAciklama")))
                    sb.AppendLine(String.Format("Lisans Kodu: {0}", GetSafeString(lisansSahibiBilgileri, "sKodu")))
                    sb.AppendLine(String.Format("Lisans Adresi: {0}", GetSafeString(lisansSahibiBilgileri, "sAdres1")))
                    sb.AppendLine(String.Format("Geçerlilik Tarihi: {0}", GetSafeDate(lisansSahibiBilgileri, "dteGecerlilikTarihi")))
                End If
                
                ' Sonra tbParamGenel'den firma bilgilerini al (lokal)
                Dim firmaBilgileri As DataRow = GetFirmaBilgileri()
                If firmaBilgileri IsNot Nothing Then
                    sb.AppendLine(String.Format("Firma Adı: {0}", GetSafeString(firmaBilgileri, "sFirmaAdi")))
                    sb.AppendLine(String.Format("Adres: {0}", GetSafeString(firmaBilgileri, "sFirmaAdresi")))
                    sb.AppendLine(String.Format("Semt/İl: {0} / {1}", GetSafeString(firmaBilgileri, "sSemt"), GetSafeString(firmaBilgileri, "sIl")))
                    sb.AppendLine(String.Format("Telefon: {0}", GetSafeString(firmaBilgileri, "sTelefon1")))
                    sb.AppendLine(String.Format("Vergi Dairesi: {0}", GetSafeString(firmaBilgileri, "sVergiDairesi")))
                    sb.AppendLine(String.Format("Vergi No: {0}", GetSafeString(firmaBilgileri, "sVergiNumarasi")))
                End If
                
                If lisansSahibiBilgileri Is Nothing AndAlso firmaBilgileri Is Nothing Then
                    sb.AppendLine("Firma bilgileri alınamadı")
                End If
            Catch
                sb.AppendLine("Firma bilgileri alınamadı")
            End Try
            sb.AppendLine()
            
            ' Uygulama Bilgileri
            sb.AppendLine("── UYGULAMA ──")
            sb.AppendLine(String.Format("Versiyon: {0}.{1}.{2}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build))
            sb.AppendLine(String.Format("Onay Kodu: {0}", sOnayKodu))
            sb.AppendLine(String.Format("Program Kullanıcısı: {0} ({1})", kullaniciadi, kullanici))
            sb.AppendLine()
            
            ' İşletim Sistemi
            sb.AppendLine("── İŞLETİM SİSTEMİ ──")
            sb.AppendLine(String.Format("OS: {0}", Environment.OSVersion.ToString()))
            sb.AppendLine(String.Format("64-Bit OS: {0}", Environment.Is64BitOperatingSystem))
            sb.AppendLine(String.Format("64-Bit Process: {0}", Environment.Is64BitProcess))
            sb.AppendLine(String.Format("Makine Adı: {0}", Environment.MachineName))
            sb.AppendLine(String.Format("Kullanıcı: {0}", Environment.UserName))
            sb.AppendLine()
            
            ' Donanım Bilgileri
            sb.AppendLine("── DONANIM ──")
            sb.AppendLine(String.Format("İşlemci Sayısı: {0}", Environment.ProcessorCount))
            
            ' RAM Bilgisi
            Try
                Dim ramQuery As New ManagementObjectSearcher("SELECT TotalPhysicalMemory FROM Win32_ComputerSystem")
                For Each item As ManagementObject In ramQuery.Get()
                    Dim totalRam As Long = Convert.ToInt64(item("TotalPhysicalMemory"))
                    sb.AppendLine(String.Format("Toplam RAM: {0:F2} GB", totalRam / (1024 * 1024 * 1024)))
                Next
            Catch
            End Try
            
            ' Disk Bilgisi
            For Each drive As DriveInfo In DriveInfo.GetDrives()
                If drive.IsReady AndAlso drive.DriveType = DriveType.Fixed Then
                    sb.AppendLine(String.Format("Disk {0}: {1:F2} GB boş / {2:F2} GB toplam", _
                        drive.Name, _
                        drive.AvailableFreeSpace / (1024 * 1024 * 1024), _
                        drive.TotalSize / (1024 * 1024 * 1024)))
                End If
            Next
            sb.AppendLine()
            
            ' Ekran Bilgisi
            sb.AppendLine("── EKRAN ──")
            For Each scr As Screen In Screen.AllScreens
                sb.AppendLine(String.Format("Ekran: {0} x {1} ({2})", _
                    scr.Bounds.Width, _
                    scr.Bounds.Height, _
                    If(scr.Primary, "Ana Ekran", "İkincil")))
            Next
            sb.AppendLine()
            
            ' .NET Framework
            sb.AppendLine("── .NET FRAMEWORK ──")
            sb.AppendLine(String.Format("CLR Versiyon: {0}", Environment.Version.ToString()))
            
            ' Registry'den .NET versiyon
            Try
                Using ndpKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\")
                    If ndpKey IsNot Nothing Then
                        Dim releaseKey As Integer = Convert.ToInt32(ndpKey.GetValue("Release"))
                        sb.AppendLine(String.Format(".NET Framework: {0}", GetDotNetVersion(releaseKey)))
                    End If
                End Using
            Catch
            End Try
            sb.AppendLine()
            
            ' SQL Server Bağlantı Durumu
            sb.AppendLine("── VERİTABANI ──")
            sb.AppendLine(String.Format("Bağlantı: {0}", If(TestDatabaseConnection(), "Başarılı", "Başarısız")))
            sb.AppendLine()
            
            ' Tarih/Saat
            sb.AppendLine("── TARİH/SAAT ──")
            sb.AppendLine(String.Format("Rapor Tarihi: {0}", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")))
            sb.AppendLine(String.Format("Timezone: {0}", TimeZone.CurrentTimeZone.StandardName))
            
            sb.AppendLine()
            sb.AppendLine("========================================")
            
        Catch ex As Exception
            sb.AppendLine("Sistem bilgisi toplanırken hata: " & ex.Message)
        End Try
        
        Return sb.ToString()
    End Function
    
    Private Function GetLisansSahibiBilgileri() As DataRow
        Try
            ' Lisans sunucusundan bilgileri çek (tbFirmaLisans + tbFirma)
            Using conn As New SqlConnection(KeyCode.SQLconnection)
                conn.Open()
                ' tbFirmaLisans'tan lisans bilgilerini ve nFirmaID'yi al
                ' tbFirma'dan firma adını (sAciklama) nFirmaID ile çek
                Dim cmd As New SqlCommand("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " & _
                    "SELECT TOP 1 fl.sKodu, fl.sAdres1, fl.dteGecerlilikTarihi, fl.nFirmaID, " & _
                    "ISNULL(f.sAciklama, fl.sAciklama) AS sAciklama " & _
                    "FROM tbFirmaLisans fl " & _
                    "LEFT JOIN tbFirma f ON fl.nFirmaID = f.nFirmaID " & _
                    "WHERE fl.sOnayKodu = @OnayKodu", conn)
                cmd.Parameters.AddWithValue("@OnayKodu", sOnayKodu)
                
                Using adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)
                    End If
                End Using
            End Using
        Catch
        End Try
        Return Nothing
    End Function
    
    Private Function GetFirmaBilgileri() As DataRow
        Try
            Using conn As New SqlConnection(KeyCode.SQLconnection)
                conn.Open()
                Dim cmd As New SqlCommand("SELECT TOP 1 sFirmaAdi, sFirmaKisaAdi, sFirmaAdresi, sSemt, sIl, sPostaKodu, " & _
                    "sVergiDairesi, sVergiNumarasi, sTelefon1, sTelefon2, sTelefon3, sFax, sEmail, sMagazaKodu FROM tbParamGenel", conn)
                
                Using adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)
                    End If
                End Using
            End Using
        Catch
        End Try
        Return Nothing
    End Function
    
    Private Function GetSafeDate(row As DataRow, columnName As String) As String
        Try
            If row.Table.Columns.Contains(columnName) Then
                Dim value = row(columnName)
                If value IsNot Nothing AndAlso Not IsDBNull(value) Then
                    Return CDate(value).ToString("dd.MM.yyyy")
                End If
            End If
        Catch
        End Try
        Return "-"
    End Function
    
    Private Function GetSafeString(row As DataRow, columnName As String) As String
        Try
            If row.Table.Columns.Contains(columnName) Then
                Dim value = row(columnName)
                If value IsNot Nothing AndAlso Not IsDBNull(value) Then
                    Return value.ToString().Trim()
                End If
            End If
        Catch
        End Try
        Return "-"
    End Function
    
    Private Function GetDotNetVersion(releaseKey As Integer) As String
        If releaseKey >= 528040 Then Return "4.8 veya üzeri"
        If releaseKey >= 461808 Then Return "4.7.2"
        If releaseKey >= 461308 Then Return "4.7.1"
        If releaseKey >= 460798 Then Return "4.7"
        If releaseKey >= 394802 Then Return "4.6.2"
        If releaseKey >= 394254 Then Return "4.6.1"
        If releaseKey >= 393295 Then Return "4.6"
        If releaseKey >= 379893 Then Return "4.5.2"
        If releaseKey >= 378675 Then Return "4.5.1"
        If releaseKey >= 378389 Then Return "4.5"
        Return "4.5 öncesi"
    End Function
    
    Private Function TestDatabaseConnection() As Boolean
        Try
            Using conn As New SqlConnection(KeyCode.SQLconnection)
                conn.Open()
                Return True
            End Using
        Catch
            Return False
        End Try
    End Function

#End Region

#Region "Dosya İşlemleri - Drag & Drop"
    
    Private Sub pnl_DosyaAlani_DragEnter(sender As Object, e As DragEventArgs) Handles pnl_DosyaAlani.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) OrElse e.Data.GetDataPresent(DataFormats.Bitmap) Then
            e.Effect = DragDropEffects.Copy
            pnl_DosyaAlani.Appearance.BackColor = Color.FromArgb(200, 230, 255)
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    
    Private Sub pnl_DosyaAlani_DragLeave(sender As Object, e As EventArgs) Handles pnl_DosyaAlani.DragLeave
        pnl_DosyaAlani.Appearance.BackColor = Color.FromArgb(240, 240, 240)
    End Sub
    
    Private Sub pnl_DosyaAlani_DragDrop(sender As Object, e As DragEventArgs) Handles pnl_DosyaAlani.DragDrop
        pnl_DosyaAlani.Appearance.BackColor = Color.FromArgb(240, 240, 240)
        
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim dosyalar() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
            For Each dosyaItem As String In dosyalar
                DosyaEkle(dosyaItem)
            Next
        ElseIf e.Data.GetDataPresent(DataFormats.Bitmap) Then
            ' Clipboard'dan resim
            Dim img As Image = CType(e.Data.GetData(DataFormats.Bitmap), Image)
            ResimKaydetVeEkle(img)
        End If
    End Sub
    
    Private Sub frm_BizeSorun_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Ctrl+V - Panodan yapıştır
        If e.Control AndAlso e.KeyCode = Keys.V Then
            If Clipboard.ContainsImage() Then
                Dim img As Image = Clipboard.GetImage()
                ResimKaydetVeEkle(img)
                e.Handled = True
            End If
        End If
        
        ' Ctrl+Shift+S - Ekran görüntüsü al
        If e.Control AndAlso e.Shift AndAlso e.KeyCode = Keys.S Then
            EkranGoruntusuAl()
            e.Handled = True
        End If
    End Sub

#End Region

#Region "Dosya Ekleme ve Validasyon"
    
    Private Function DosyaUzantisiDestekleniyor(uzanti As String, desteklenenler() As String) As Boolean
        For Each dest As String In desteklenenler
            If dest.ToLower() = uzanti.ToLower() Then
                Return True
            End If
        Next
        Return False
    End Function
    
    Private Sub DosyaEkle(dosyaYolu As String)
        If Not File.Exists(dosyaYolu) Then
            XtraMessageBox.Show("Dosya bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        Dim uzanti As String = Path.GetExtension(dosyaYolu).ToLower()
        Dim dosyaBoyutu As Long = New FileInfo(dosyaYolu).Length
        
        ' Video kontrolü
        If DosyaUzantisiDestekleniyor(uzanti, desteklenenVideolar) Then
            If dosyaBoyutu > MAX_VIDEO_SIZE Then
                XtraMessageBox.Show(String.Format("Video dosyası çok büyük!{0}Maksimum: 50 MB{0}Dosya boyutu: {1:F2} MB", _
                    vbCrLf, dosyaBoyutu / (1024 * 1024)), "Dosya Boyutu Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        ' Resim kontrolü
        ElseIf DosyaUzantisiDestekleniyor(uzanti, desteklenenResimler) Then
            If dosyaBoyutu > MAX_IMAGE_SIZE Then
                XtraMessageBox.Show(String.Format("Resim dosyası çok büyük!{0}Maksimum: 10 MB{0}Dosya boyutu: {1:F2} MB", _
                    vbCrLf, dosyaBoyutu / (1024 * 1024)), "Dosya Boyutu Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Else
            XtraMessageBox.Show("Desteklenmeyen dosya formatı!" & vbCrLf & "Desteklenen: JPG, PNG, GIF, BMP, MP4, AVI, MOV, WMV, MKV", _
                "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        ' Toplam dosya sayısı kontrolü (max 5)
        If ekliDosyalar.Count >= 5 Then
            XtraMessageBox.Show("En fazla 5 dosya ekleyebilirsiniz!", "Limit Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        ' Dosyayı listeye ekle
        ekliDosyalar.Add(dosyaYolu)
        GuncelleDosyaListesi()
        GuncelleDurumCubugu(String.Format("Dosya eklendi: {0}", Path.GetFileName(dosyaYolu)))
    End Sub
    
    Private Sub ResimKaydetVeEkle(img As Image)
        Try
            ' Geçici dosya oluştur
            Dim tempPath As String = Path.Combine(Path.GetTempPath(), String.Format("screenshot_{0}.png", DateTime.Now.ToString("yyyyMMdd_HHmmss")))
            img.Save(tempPath, ImageFormat.Png)
            DosyaEkle(tempPath)
        Catch ex As Exception
            XtraMessageBox.Show("Resim kaydedilemedi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub GuncelleDosyaListesi()
        listDosyalar.Items.Clear()
        Dim toplamBoyut As Long = 0
        
        For Each dosyaItem As String In ekliDosyalar
            Dim fi As New FileInfo(dosyaItem)
            Dim boyutStr As String = If(fi.Length > 1024 * 1024, _
                String.Format("{0:F2} MB", fi.Length / (1024 * 1024)), _
                String.Format("{0:F0} KB", fi.Length / 1024))
            
            listDosyalar.Items.Add(String.Format("{0} ({1})", fi.Name, boyutStr))
            toplamBoyut += fi.Length
        Next
        
        lbl_DosyaBilgi.Text = String.Format("{0} dosya ekli (Toplam: {1:F2} MB)", ekliDosyalar.Count, toplamBoyut / (1024 * 1024))
    End Sub
    
    Private Sub btn_DosyaSec_Click(sender As Object, e As EventArgs) Handles btn_DosyaSec.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Dosya Seç (Resim veya Video)"
            ofd.Filter = "Tüm Desteklenen|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.mp4;*.avi;*.mov;*.wmv;*.mkv|Resimler|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Videolar|*.mp4;*.avi;*.mov;*.wmv;*.mkv"
            ofd.Multiselect = True
            
            If ofd.ShowDialog() = DialogResult.OK Then
                For Each dosyaItem As String In ofd.FileNames
                    DosyaEkle(dosyaItem)
                Next
            End If
        End Using
    End Sub
    
    Private Sub btn_DosyaSil_Click(sender As Object, e As EventArgs) Handles btn_DosyaSil.Click
        If listDosyalar.SelectedIndex >= 0 Then
            ekliDosyalar.RemoveAt(listDosyalar.SelectedIndex)
            GuncelleDosyaListesi()
            GuncelleDurumCubugu("Dosya kaldırıldı")
        End If
    End Sub

#End Region

#Region "Ekran Görüntüsü"
    
    Private Sub btn_EkranGoruntusu_Click(sender As Object, e As EventArgs) Handles btn_EkranGoruntusu.Click
        EkranGoruntusuAl()
    End Sub
    
    Private Sub EkranGoruntusuAl()
        Try
            ' Formu geçici olarak gizle
            Me.WindowState = FormWindowState.Minimized
            Thread.Sleep(300)
            
            ' Tüm ekranları yakala
            Dim bounds As Rectangle = Screen.PrimaryScreen.Bounds
            Using bmp As New Bitmap(bounds.Width, bounds.Height)
                Using g As Graphics = Graphics.FromImage(bmp)
                    g.CopyFromScreen(bounds.Location, Point.Empty, bounds.Size)
                End Using
                
                ' Kaydet
                Dim tempPath As String = Path.Combine(Path.GetTempPath(), String.Format("ekran_goruntusu_{0}.png", DateTime.Now.ToString("yyyyMMdd_HHmmss")))
                bmp.Save(tempPath, ImageFormat.Png)
                
                ' Formu geri getir
                Me.WindowState = FormWindowState.Normal
                Me.Activate()
                
                ' Dosyayı ekle
                DosyaEkle(tempPath)
                
                XtraMessageBox.Show("Ekran görüntüsü alındı ve eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            Me.WindowState = FormWindowState.Normal
            XtraMessageBox.Show("Ekran görüntüsü alınamadı: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Form Validasyonu"
    
    Private Function ValidateForm() As Boolean
        ' Email kontrolü
        If String.IsNullOrEmpty(txt_mail.Text.Trim()) Then
            XtraMessageBox.Show("Lütfen e-posta adresinizi girin!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_mail.Focus()
            Return False
        End If
        
        If Not IsValidEmail(txt_mail.Text) Then
            XtraMessageBox.Show("Geçerli bir e-posta adresi girin!", "Hatalı E-posta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_mail.Focus()
            Return False
        End If
        
        ' İsim kontrolü
        If String.IsNullOrEmpty(txt_sKimden.Text.Trim()) Then
            XtraMessageBox.Show("Lütfen adınızı girin!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_sKimden.Focus()
            Return False
        End If
        
        ' Konu kontrolü
        If String.IsNullOrEmpty(txt_sKonu.Text.Trim()) Then
            XtraMessageBox.Show("Lütfen konu başlığı girin!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_sKonu.Focus()
            Return False
        End If
        
        ' Mesaj kontrolü
        If String.IsNullOrEmpty(txt_sMesaj.Text.Trim()) Then
            XtraMessageBox.Show("Lütfen mesajınızı yazın!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_sMesaj.Focus()
            Return False
        End If
        
        Return True
    End Function
    
    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr As New MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function

#End Region

#Region "Mail Gönderimi (Geliştirilmiş)"
    
    Private Sub btn_Gonder_Click(sender As Object, e As EventArgs) Handles btn_Gonder.Click
        If Not ValidateForm() Then Return
        
        ' Onay iste
        Dim result = XtraMessageBox.Show( _
            String.Format("Destek talebiniz gönderilecek.{0}{0}Ticket No: {1}{0}Ekli Dosya: {2} adet{0}{0}Devam edilsin mi?", _
                vbCrLf, ticketNo, ekliDosyalar.Count), _
            "Gönderim Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        
        If result = DialogResult.No Then Return
        
        ' Progress göster
        progressPanel.Visible = True
        btn_Gonder.Enabled = False
        GuncelleDurumCubugu("Gönderiliyor...")
        Application.DoEvents()
        
        Try
            ' Veritabanına kaydet
            Dim ticketId As Integer = KaydetTicketVeritabani()
            
            ' Email gönder (senkron - eski .NET için)
            MailGonder()
            
            ' Başarılı
            progressPanel.Visible = False
            
            XtraMessageBox.Show( _
                String.Format("Destek talebiniz başarıyla gönderildi!{0}{0}Ticket No: {1}{0}{0}Bu numara ile talebinizi takip edebilirsiniz.{0}En geç 5 iş günü içinde size dönüş yapılacaktır.", _
                    vbCrLf, ticketNo), _
                "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
            ' Formu temizle
            TemizleForm()
            
            ' Yeni ticket numarası
            ticketNo = OlusturTicketNo()
            lbl_TicketNo.Text = "Ticket: " & ticketNo
            
            ' Geçmişi güncelle
            YukleTicketGecmisi()
            
        Catch ex As Exception
            progressPanel.Visible = False
            XtraMessageBox.Show("Gönderim sırasında hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btn_Gonder.Enabled = True
            GuncelleDurumCubugu("Hazır")
        End Try
    End Sub
    
    Private Sub MailGonder()
        ' SSL Sertifika doğrulamasını bypass et (self-signed veya geçersiz sertifikalar için)
        ServicePointManager.ServerCertificateValidationCallback = Function(sender, certificate, chain, sslPolicyErrors) True
        
        Using smtpServer As New SmtpClient()
            ' SMTP Ayarları
            smtpServer.Credentials = New NetworkCredential("destek@barkodyazilim.com.tr", "Jnx~evm4rlF_")
            smtpServer.Port = 587
            smtpServer.Host = "mail.barkodyazilim.com.tr"
            smtpServer.EnableSsl = True
            smtpServer.Timeout = 60000 ' 60 saniye timeout
            
            ' 1. DESTEK EKİBİNE EMAIL (Sistem bilgileri AYRI DOSYA olarak)
            Using mailDestek As New MailMessage()
                mailDestek.From = New MailAddress("destek@barkodyazilim.com.tr", "Barkod Destek Sistemi")
                mailDestek.ReplyToList.Add(New MailAddress(txt_mail.Text, txt_sKimden.Text))
                
                ' Alıcılar (Destek ekibi)
                mailDestek.To.Add("destek@barkodyazilim.com.tr")
                mailDestek.To.Add("alitanergoksu@barkodyazilim.com.tr")
                mailDestek.To.Add("info@barkodyazilim.com.tr")
                
                ' Konu
                mailDestek.Subject = String.Format("[{0}] {1} - {2} ({3})", _
                    ticketNo, _
                    txt_sKategori.Text, _
                    txt_sKonu.Text, _
                    txt_sOncelik.Text)
                
                ' Öncelik ayarla
                Select Case txt_sOncelik.Text
                    Case "Acil"
                        mailDestek.Priority = MailPriority.High
                    Case "Arayın"
                        mailDestek.Priority = MailPriority.High
                    Case Else
                        mailDestek.Priority = MailPriority.Normal
                End Select
                
                ' Mail içeriği (HTML) - Sistem bilgileri YOK (yanıtlarken görünmemesi için)
                mailDestek.IsBodyHtml = True
                mailDestek.Body = OlusturDestekMailIcerigi()
                
                ' Dosya ekleri
                For Each dosyaItem As String In ekliDosyalar
                    If File.Exists(dosyaItem) Then
                        mailDestek.Attachments.Add(New Attachment(dosyaItem))
                    End If
                Next
                
                ' Sistem bilgilerini AYRI DOSYA olarak ekle (yanıtlarken görünmez)
                Dim sistemBilgisiDosyasi As String = Path.Combine(Path.GetTempPath(), String.Format("sistem_bilgisi_{0}.txt", ticketNo))
                File.WriteAllText(sistemBilgisiDosyasi, sistemBilgisi, Encoding.UTF8)
                mailDestek.Attachments.Add(New Attachment(sistemBilgisiDosyasi))
                
                ' Gönder
                smtpServer.Send(mailDestek)
                
                ' Geçici dosyayı sil
                Try
                    File.Delete(sistemBilgisiDosyasi)
                Catch
                End Try
            End Using
            
            ' 2. MÜŞTERİYE BASİT BİLGİLENDİRME EMAİLİ (Sistem bilgisi YOK)
            Using mailMusteri As New MailMessage()
                mailMusteri.From = New MailAddress("destek@barkodyazilim.com.tr", "Barkod Destek Sistemi")
                mailMusteri.To.Add(txt_mail.Text)
                
                mailMusteri.Subject = String.Format("Destek Talebiniz - {0}", ticketNo)
                mailMusteri.IsBodyHtml = True
                mailMusteri.Body = OlusturMusteriBilgilendirmeMaili()
                
                ' Müşteriye de dosya eklerini gönder
                For Each dosyaItem As String In ekliDosyalar
                    If File.Exists(dosyaItem) Then
                        mailMusteri.Attachments.Add(New Attachment(dosyaItem))
                    End If
                Next
                
                smtpServer.Send(mailMusteri)
            End Using
        End Using
    End Sub
    
    Private Function OlusturMusteriBilgilendirmeMaili() As String
        Dim sb As New StringBuilder()
        
        sb.AppendLine("<html><head>")
        sb.AppendLine("<style>")
        sb.AppendLine("body { font-family: 'Segoe UI', Tahoma, sans-serif; line-height: 1.6; color: #333; background: #f5f5f5; padding: 20px; }")
        sb.AppendLine(".container { max-width: 600px; margin: 0 auto; background: white; border-radius: 10px; overflow: hidden; box-shadow: 0 2px 10px rgba(0,0,0,0.1); }")
        sb.AppendLine(".header { background: linear-gradient(135deg, #667eea 0%, #764ba2 100%); color: white; padding: 30px; text-align: center; }")
        sb.AppendLine(".content { padding: 30px; }")
        sb.AppendLine(".ticket-box { background: #f8f9fa; padding: 20px; border-radius: 8px; text-align: center; margin: 20px 0; }")
        sb.AppendLine(".ticket-no { font-size: 24px; font-weight: bold; color: #667eea; }")
        sb.AppendLine(".info-row { padding: 10px 0; border-bottom: 1px solid #eee; }")
        sb.AppendLine(".label { font-weight: bold; color: #555; }")
        sb.AppendLine(".message-box { background: #f8f9fa; padding: 15px; border-radius: 8px; margin: 15px 0; border-left: 4px solid #667eea; }")
        sb.AppendLine(".footer { background: #333; color: #999; padding: 20px; text-align: center; font-size: 12px; }")
        sb.AppendLine("</style></head><body>")
        
        sb.AppendLine("<div class='container'>")
        
        ' Header
        sb.AppendLine("<div class='header'>")
        sb.AppendLine("<h1>Destek Talebiniz</h1>")
        sb.AppendLine(String.Format("<p>{0}</p>", ticketNo))
        sb.AppendLine("</div>")
        
        ' Content
        sb.AppendLine("<div class='content'>")
        sb.AppendLine(String.Format("<p>Sayın <strong>{0}</strong>,</p>", txt_sKimden.Text))
        sb.AppendLine("<p>Destek talebiniz başarıyla alınmıştır. Aşağıda talebinizin bir kopyası bulunmaktadır.</p>")
        
        ' Talep Detayları
        sb.AppendLine("<h3>Talep Detayları</h3>")
        sb.AppendLine(String.Format("<div class='info-row'><span class='label'>Kategori:</span> {0}</div>", txt_sKategori.Text))
        sb.AppendLine(String.Format("<div class='info-row'><span class='label'>Konu:</span> {0}</div>", txt_sKonu.Text))
        sb.AppendLine(String.Format("<div class='info-row'><span class='label'>Öncelik:</span> {0}</div>", txt_sOncelik.Text))
        sb.AppendLine(String.Format("<div class='info-row'><span class='label'>Tarih:</span> {0}</div>", DateTime.Now.ToString("dd MMMM yyyy HH:mm")))
        
        ' Müşterinin yazdığı mesaj
        sb.AppendLine("<h3>Mesajınız</h3>")
        sb.AppendLine("<div class='message-box'>")
        sb.AppendLine(txt_sMesaj.Text.Replace(vbCrLf, "<br/>"))
        sb.AppendLine("</div>")
        
        ' Ekli dosyalar
        If ekliDosyalar.Count > 0 Then
            sb.AppendLine(String.Format("<h3>Ekli Dosyalar ({0} adet)</h3>", ekliDosyalar.Count))
            sb.AppendLine("<ul>")
            For Each dosyaItem As String In ekliDosyalar
                Dim fi As New FileInfo(dosyaItem)
                sb.AppendLine(String.Format("<li>{0} ({1:F2} MB)</li>", fi.Name, fi.Length / (1024 * 1024)))
            Next
            sb.AppendLine("</ul>")
        End If
        
        sb.AppendLine("<p style='margin-top: 20px; padding: 15px; background: #e8f5e9; border-radius: 5px;'>")
        sb.AppendLine("<strong>Not:</strong> En kısa sürede size dönüş yapılacaktır. Bu e-postayı yanıtlayarak destek ekibimizle iletişime geçebilirsiniz.")
        sb.AppendLine("</p>")
        sb.AppendLine("</div>")
        
        ' Footer
        sb.AppendLine("<div class='footer'>")
        sb.AppendLine("<p>Barkod Yazılım Destek Ekibi</p>")
        sb.AppendLine("<p>Tel: (530) 542-5771 | info@barkodyazilim.com.tr</p>")
        sb.AppendLine("</div>")
        
        sb.AppendLine("</div>")
        sb.AppendLine("</body></html>")
        
        Return sb.ToString()
    End Function
    
    Private Function OlusturDestekMailIcerigi() As String
        ' Destek ekibine giden email - Sistem bilgileri DOSYA EKİ olarak gidiyor
        Dim sb As New StringBuilder()
        
        sb.AppendLine("<html><head>")
        sb.AppendLine("<style>")
        sb.AppendLine("body { font-family: 'Segoe UI', Tahoma, sans-serif; line-height: 1.6; color: #333; }")
        sb.AppendLine(".header { background: linear-gradient(135deg, #667eea 0%, #764ba2 100%); color: white; padding: 20px; border-radius: 8px 8px 0 0; }")
        sb.AppendLine(".content { background: #f9f9f9; padding: 20px; border: 1px solid #ddd; }")
        sb.AppendLine(".info-box { background: white; padding: 15px; margin: 10px 0; border-radius: 5px; border-left: 4px solid #667eea; }")
        sb.AppendLine(".label { font-weight: bold; color: #555; }")
        sb.AppendLine(".priority-high { color: #e74c3c; font-weight: bold; }")
        sb.AppendLine(".priority-normal { color: #27ae60; }")
        sb.AppendLine(".note-box { background: #fff3cd; padding: 10px; border-radius: 5px; margin-top: 15px; border-left: 4px solid #ffc107; }")
        sb.AppendLine(".footer { background: #333; color: #999; padding: 15px; text-align: center; font-size: 12px; border-radius: 0 0 8px 8px; }")
        sb.AppendLine("</style></head><body>")
        
        ' Header
        sb.AppendLine("<div class='header'>")
        sb.AppendLine(String.Format("<h2>Destek Talebi: {0}</h2>", ticketNo))
        sb.AppendLine(String.Format("<p>Tarih: {0}</p>", DateTime.Now.ToString("dd MMMM yyyy HH:mm")))
        sb.AppendLine("</div>")
        
        ' Content
        sb.AppendLine("<div class='content'>")
        
        ' Müşteri Bilgileri
        sb.AppendLine("<div class='info-box'>")
        sb.AppendLine("<h3>Müşteri Bilgileri</h3>")
        sb.AppendLine(String.Format("<p><span class='label'>Ad Soyad:</span> {0}</p>", txt_sKimden.Text))
        sb.AppendLine(String.Format("<p><span class='label'>E-posta:</span> {0}</p>", txt_mail.Text))
        sb.AppendLine(String.Format("<p><span class='label'>Telefon:</span> {0}</p>", If(String.IsNullOrEmpty(txt_Telefon.Text), "-", txt_Telefon.Text)))
        sb.AppendLine("</div>")
        
        ' Talep Detayları
        sb.AppendLine("<div class='info-box'>")
        sb.AppendLine("<h3>Talep Detayları</h3>")
        sb.AppendLine(String.Format("<p><span class='label'>Kategori:</span> {0}</p>", txt_sKategori.Text))
        sb.AppendLine(String.Format("<p><span class='label'>Konu:</span> {0}</p>", txt_sKonu.Text))
        sb.AppendLine(String.Format("<p><span class='label'>Öncelik:</span> <span class='{1}'>{0}</span></p>", _
            txt_sOncelik.Text, _
            If(txt_sOncelik.Text = "Normal", "priority-normal", "priority-high")))
        sb.AppendLine("</div>")
        
        ' Mesaj
        sb.AppendLine("<div class='info-box'>")
        sb.AppendLine("<h3>Mesaj</h3>")
        sb.AppendLine(String.Format("<p>{0}</p>", txt_sMesaj.Text.Replace(vbCrLf, "<br/>")))
        sb.AppendLine("</div>")
        
        ' Ekli Dosyalar
        If ekliDosyalar.Count > 0 Then
            sb.AppendLine("<div class='info-box'>")
            sb.AppendLine(String.Format("<h3>Ekli Dosyalar ({0} adet)</h3>", ekliDosyalar.Count))
            sb.AppendLine("<ul>")
            For Each dosyaItem As String In ekliDosyalar
                Dim fi As New FileInfo(dosyaItem)
                sb.AppendLine(String.Format("<li>{0} ({1:F2} MB)</li>", fi.Name, fi.Length / (1024 * 1024)))
            Next
            sb.AppendLine("</ul>")
            sb.AppendLine("</div>")
        End If
        
        ' Not: Sistem bilgileri ekte
        sb.AppendLine("<div class='note-box'>")
        sb.AppendLine("<strong>📎 Not:</strong> Sistem ve lisans bilgileri ekteki <code>sistem_bilgisi_" & ticketNo & ".txt</code> dosyasındadır.")
        sb.AppendLine("</div>")
        
        sb.AppendLine("</div>")
        
        ' Footer
        sb.AppendLine("<div class='footer'>")
        sb.AppendLine("<p>Bu e-posta Barkod Mağaza Destek Sistemi tarafından otomatik olarak oluşturulmuştur.</p>")
        sb.AppendLine(String.Format("<p>Onay Kodu: {0} | Versiyon: {1}.{2}</p>", sOnayKodu, My.Application.Info.Version.Major, My.Application.Info.Version.Minor))
        sb.AppendLine("</div>")
        
        sb.AppendLine("</body></html>")
        
        Return sb.ToString()
    End Function
    
    Private Function OlusturMailIcerigi() As String
        Dim sb As New StringBuilder()
        
        sb.AppendLine("<html><head>")
        sb.AppendLine("<style>")
        sb.AppendLine("body { font-family: 'Segoe UI', Tahoma, sans-serif; line-height: 1.6; color: #333; }")
        sb.AppendLine(".header { background: linear-gradient(135deg, #667eea 0%, #764ba2 100%); color: white; padding: 20px; border-radius: 8px 8px 0 0; }")
        sb.AppendLine(".content { background: #f9f9f9; padding: 20px; border: 1px solid #ddd; }")
        sb.AppendLine(".info-box { background: white; padding: 15px; margin: 10px 0; border-radius: 5px; border-left: 4px solid #667eea; }")
        sb.AppendLine(".label { font-weight: bold; color: #555; }")
        sb.AppendLine(".priority-high { color: #e74c3c; font-weight: bold; }")
        sb.AppendLine(".priority-normal { color: #27ae60; }")
        sb.AppendLine(".system-info { background: #2c3e50; color: #ecf0f1; padding: 15px; font-family: 'Consolas', monospace; font-size: 12px; border-radius: 5px; white-space: pre-wrap; }")
        sb.AppendLine(".footer { background: #333; color: #999; padding: 15px; text-align: center; font-size: 12px; border-radius: 0 0 8px 8px; }")
        sb.AppendLine("</style></head><body>")
        
        ' Header
        sb.AppendLine("<div class='header'>")
        sb.AppendLine(String.Format("<h2>Destek Talebi: {0}</h2>", ticketNo))
        sb.AppendLine(String.Format("<p>Tarih: {0}</p>", DateTime.Now.ToString("dd MMMM yyyy HH:mm")))
        sb.AppendLine("</div>")
        
        ' Content
        sb.AppendLine("<div class='content'>")
        
        ' Müşteri Bilgileri
        sb.AppendLine("<div class='info-box'>")
        sb.AppendLine("<h3>Müşteri Bilgileri</h3>")
        sb.AppendLine(String.Format("<p><span class='label'>Ad Soyad:</span> {0}</p>", txt_sKimden.Text))
        sb.AppendLine(String.Format("<p><span class='label'>E-posta:</span> {0}</p>", txt_mail.Text))
        sb.AppendLine(String.Format("<p><span class='label'>Telefon:</span> {0}</p>", If(String.IsNullOrEmpty(txt_Telefon.Text), "-", txt_Telefon.Text)))
        sb.AppendLine("</div>")
        
        ' Talep Detayları
        sb.AppendLine("<div class='info-box'>")
        sb.AppendLine("<h3>Talep Detayları</h3>")
        sb.AppendLine(String.Format("<p><span class='label'>Kategori:</span> {0}</p>", txt_sKategori.Text))
        sb.AppendLine(String.Format("<p><span class='label'>Konu:</span> {0}</p>", txt_sKonu.Text))
        sb.AppendLine(String.Format("<p><span class='label'>Öncelik:</span> <span class='{1}'>{0}</span></p>", _
            txt_sOncelik.Text, _
            If(txt_sOncelik.Text = "Normal", "priority-normal", "priority-high")))
        sb.AppendLine("</div>")
        
        ' Mesaj
        sb.AppendLine("<div class='info-box'>")
        sb.AppendLine("<h3>Mesaj</h3>")
        sb.AppendLine(String.Format("<p>{0}</p>", txt_sMesaj.Text.Replace(vbCrLf, "<br/>")))
        sb.AppendLine("</div>")
        
        ' Ekli Dosyalar
        If ekliDosyalar.Count > 0 Then
            sb.AppendLine("<div class='info-box'>")
            sb.AppendLine(String.Format("<h3>Ekli Dosyalar ({0} adet)</h3>", ekliDosyalar.Count))
            sb.AppendLine("<ul>")
            For Each dosyaItem As String In ekliDosyalar
                Dim fi As New FileInfo(dosyaItem)
                sb.AppendLine(String.Format("<li>{0} ({1:F2} MB)</li>", fi.Name, fi.Length / (1024 * 1024)))
            Next
            sb.AppendLine("</ul>")
            sb.AppendLine("</div>")
        End If
        
        ' Sistem Bilgileri
        sb.AppendLine("<div class='info-box'>")
        sb.AppendLine("<h3>Sistem Bilgileri</h3>")
        sb.AppendLine("<div class='system-info'>")
        sb.AppendLine(sistemBilgisi.Replace(vbCrLf, "<br/>"))
        sb.AppendLine("</div>")
        sb.AppendLine("</div>")
        
        sb.AppendLine("</div>")
        
        ' Footer
        sb.AppendLine("<div class='footer'>")
        sb.AppendLine("<p>Bu e-posta Barkod Mağaza Destek Sistemi tarafından otomatik olarak oluşturulmuştur.</p>")
        sb.AppendLine(String.Format("<p>Onay Kodu: {0} | Versiyon: {1}.{2}</p>", sOnayKodu, My.Application.Info.Version.Major, My.Application.Info.Version.Minor))
        sb.AppendLine("</div>")
        
        sb.AppendLine("</body></html>")
        
        Return sb.ToString()
    End Function

#End Region

#Region "Veritabanı İşlemleri"
    
    Private Function KaydetTicketVeritabani() As Integer
        Dim ticketId As Integer = 0
        
        Try
            Using conn As New SqlConnection(KeyCode.SQLconnection)
                conn.Open()
                
                ' Tablo var mı kontrol et, yoksa oluştur
                OlusturTicketTablosu(conn)
                
                Dim sql As String = "INSERT INTO DESTEK_TICKET (TicketNo, TicketSiraNo, MusteriAd, MusteriEmail, MusteriTelefon, " & _
                                   "Kategori, Konu, Mesaj, Oncelik, Durum, SistemBilgisi, EkliDosyaSayisi, OlusturmaTarihi, OnayKodu) " & _
                                   "VALUES (@TicketNo, @TicketSiraNo, @MusteriAd, @MusteriEmail, @MusteriTelefon, " & _
                                   "@Kategori, @Konu, @Mesaj, @Oncelik, @Durum, @SistemBilgisi, @EkliDosyaSayisi, GETDATE(), @OnayKodu); " & _
                                   "SELECT SCOPE_IDENTITY();"
                
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@TicketNo", ticketNo)
                    cmd.Parameters.AddWithValue("@TicketSiraNo", Integer.Parse(ticketNo.Split("-"c)(2)))
                    cmd.Parameters.AddWithValue("@MusteriAd", txt_sKimden.Text)
                    cmd.Parameters.AddWithValue("@MusteriEmail", txt_mail.Text)
                    cmd.Parameters.AddWithValue("@MusteriTelefon", If(String.IsNullOrEmpty(txt_Telefon.Text), DBNull.Value, CObj(txt_Telefon.Text)))
                    cmd.Parameters.AddWithValue("@Kategori", txt_sKategori.Text)
                    cmd.Parameters.AddWithValue("@Konu", txt_sKonu.Text)
                    cmd.Parameters.AddWithValue("@Mesaj", txt_sMesaj.Text)
                    cmd.Parameters.AddWithValue("@Oncelik", txt_sOncelik.Text)
                    cmd.Parameters.AddWithValue("@Durum", "Açık")
                    cmd.Parameters.AddWithValue("@SistemBilgisi", sistemBilgisi)
                    cmd.Parameters.AddWithValue("@EkliDosyaSayisi", ekliDosyalar.Count)
                    cmd.Parameters.AddWithValue("@OnayKodu", sOnayKodu)
                    
                    Dim resultObj = cmd.ExecuteScalar()
                    If resultObj IsNot Nothing Then
                        ticketId = Convert.ToInt32(resultObj)
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Veritabanı hatası log'la ama mail gönderimini engelleme
            Debug.WriteLine("Veritabanı kayıt hatası: " & ex.Message)
        End Try
        
        Return ticketId
    End Function
    
    Private Sub OlusturTicketTablosu(conn As SqlConnection)
        Dim checkSql As String = "IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'DESTEK_TICKET') " & _
                                "CREATE TABLE DESTEK_TICKET (" & _
                                "ID INT IDENTITY(1,1) PRIMARY KEY, " & _
                                "TicketNo NVARCHAR(20) NOT NULL, " & _
                                "TicketSiraNo INT NOT NULL, " & _
                                "MusteriAd NVARCHAR(100), " & _
                                "MusteriEmail NVARCHAR(100), " & _
                                "MusteriTelefon NVARCHAR(20), " & _
                                "Kategori NVARCHAR(50), " & _
                                "Konu NVARCHAR(200), " & _
                                "Mesaj NVARCHAR(MAX), " & _
                                "Oncelik NVARCHAR(20) DEFAULT 'Açık', " & _
                                "Durum NVARCHAR(20) DEFAULT 'Açık', " & _
                                "SistemBilgisi NVARCHAR(MAX), " & _
                                "EkliDosyaSayisi INT DEFAULT 0, " & _
                                "OlusturmaTarihi DATETIME DEFAULT GETDATE(), " & _
                                "GuncellemeTarihi DATETIME, " & _
                                "OnayKodu NVARCHAR(50), " & _
                                "Yanit NVARCHAR(MAX), " & _
                                "YanitTarihi DATETIME)"
        
        Using cmd As New SqlCommand(checkSql, conn)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
    
    Private Sub YukleTicketGecmisi()
        Try
            gridTicketGecmisi.DataSource = Nothing
            
            Using conn As New SqlConnection(KeyCode.SQLconnection)
                conn.Open()
                
                ' Sadece bu kullanıcının ticket'larını getir
                Dim sql As String = "SELECT TicketNo, Kategori, Konu, Oncelik, Durum, OlusturmaTarihi, YanitTarihi " & _
                                   "FROM DESTEK_TICKET WHERE OnayKodu = @OnayKodu ORDER BY OlusturmaTarihi DESC"
                
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@OnayKodu", sOnayKodu)
                    
                    Using adapter As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        adapter.Fill(dt)
                        gridTicketGecmisi.DataSource = dt
                    End Using
                End Using
            End Using
            
            ' Grid görünümünü ayarla
            FormatTicketGrid()
            
        Catch ex As Exception
            Debug.WriteLine("Ticket geçmişi yüklenemedi: " & ex.Message)
        End Try
    End Sub
    
    Private Sub FormatTicketGrid()
        Try
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(gridTicketGecmisi.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            
            If view IsNot Nothing AndAlso view.Columns.Count > 0 Then
                view.Columns("TicketNo").Caption = "Ticket No"
                view.Columns("Kategori").Caption = "Kategori"
                view.Columns("Konu").Caption = "Konu"
                view.Columns("Oncelik").Caption = "Öncelik"
                view.Columns("Durum").Caption = "Durum"
                view.Columns("OlusturmaTarihi").Caption = "Tarih"
                view.Columns("YanitTarihi").Caption = "Yanıt Tarihi"
                
                view.Columns("OlusturmaTarihi").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                view.Columns("OlusturmaTarihi").DisplayFormat.FormatString = "dd.MM.yyyy HH:mm"
                
                view.BestFitColumns()
            End If
        Catch
        End Try
    End Sub

#End Region

#Region "Yardımcı Metodlar"
    
    Private Sub TemizleForm()
        txt_sKonu.Text = ""
        txt_sMesaj.Text = ""
        ekliDosyalar.Clear()
        GuncelleDosyaListesi()
        txt_sOncelik.SelectedIndex = 0
        txt_sKategori.SelectedIndex = 0
    End Sub
    
    Private Sub TemizleGeciciDosyalar()
        Try
            For Each dosyaItem As String In ekliDosyalar
                If dosyaItem.StartsWith(Path.GetTempPath()) AndAlso File.Exists(dosyaItem) Then
                    File.Delete(dosyaItem)
                End If
            Next
        Catch
        End Try
    End Sub
    
    Private Sub GuncelleDurumCubugu(mesaj As String)
        lbl_Durum.Text = mesaj
    End Sub
    
    Private Sub btn_Vazgec_Click(sender As Object, e As EventArgs) Handles btn_Vazgec.Click
        Me.Close()
    End Sub
    
    Private Sub btn_SistemBilgisi_Click(sender As Object, e As EventArgs) Handles btn_SistemBilgisi.Click
        ' Sistem bilgisini göster
        Using frm As New Form()
            frm.Text = "Sistem Bilgileri"
            frm.Size = New Size(600, 500)
            frm.StartPosition = FormStartPosition.CenterParent
            
            Dim txt As New TextBox()
            txt.Multiline = True
            txt.ScrollBars = ScrollBars.Both
            txt.Dock = DockStyle.Fill
            txt.Font = New Font("Consolas", 9)
            txt.ReadOnly = True
            txt.Text = sistemBilgisi
            
            frm.Controls.Add(txt)
            frm.ShowDialog(Me)
        End Using
    End Sub

#End Region

End Class
