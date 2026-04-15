Imports System.Data.OleDb
Imports System.Net
Imports System.IO
Imports System.Collections
Imports System.Collections.Generic
Imports System.Text
Imports System
Imports System.Threading
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports DevExpress.XtraEditors
Imports System.Globalization
Imports System.Timers
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Drawing
Imports System.Runtime.InteropServices

Public Class frm_qukaGonder
    Inherits System.Windows.Forms.Form
    
    ' Windows API - Formu öne getirmek için
    <DllImport("user32.dll")>
    Private Shared Function SetForegroundWindow(hWnd As IntPtr) As Boolean
    End Function
    
    <DllImport("user32.dll")>
    Private Shared Function ShowWindow(hWnd As IntPtr, nCmdShow As Integer) As Boolean
    End Function
    
    Private Const SW_RESTORE As Integer = 9
    Private Const SW_SHOW As Integer = 5
    
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    'Private connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Code\BARKOD_MAGAZA_vista_2014-VS12\Database.accdb;" ' GerÇek veritabanı yolunu güncelleyin
    Private ApiKey As String
    Private ApiSecret As String
    Private LAGlobalAddress As String
    Private ReadOnly logLock As New Object
    Private ilce As String
    Private postaKodu As String
    Private telefon As String
    Private eMail As String
    
    ' ===== GÖNDERİM MODU =====
    ' GonderimModu: 1 = API (Doğrudan), 2 = PHP Entegrasyon
    ' Not: URL otomatik dönüştürülür, ekstra alan gerekmiyor
    Private GonderimModu As Integer = 1
    Private stokSyncTimer As New Timers.Timer()
    Private siparisSyncTimer As New Timers.Timer()
    Private stokSyncInterval As Double = 3600000 ' Varsayılan 1 saat (milisaniye)
    Private siparisSyncInterval As Double = 1800000 ' Varsayılan 30 dakika (milisaniye)
    Private isRunning As Boolean = False
    
    ' Son senkronizasyon tarihleri (değişiklik algılama için)
    Private lastStockSyncDate As DateTime = DateTime.MinValue
    Private lastPriceSyncDate As DateTime = DateTime.MinValue
    
    ' Trigger sistemi için
    Private triggerSyncTimer As New Timers.Timer()
    Private isTriggerRunning As Boolean = False
    
    ' System Tray için
    Private WithEvents notifyIcon As New NotifyIcon()
    Private trayContextMenu As New ContextMenuStrip()
    
    ' Senkronizasyon kilit objesi (aynı anda birden fazla sync önlemek için)
    Private _syncLockObj As New Object()
    Private isSyncRunning As Boolean = False
    
    ' İptal mekanizması için CancellationTokenSource
    Private _cts As CancellationTokenSource = Nothing
    Private _cancelRequested As Boolean = False
    
    ' Form yüklenirken event'ları engelle
    Private _isFormLoading As Boolean = True
    
    Private Function GetIlName(ByVal cityCode As String, ByVal conn As OleDb.OleDbConnection) As String
        If String.IsNullOrEmpty(cityCode) Then Return ""
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            
            ' Önce plaka kodu ile dene (örn: "34" -> "İstanbul")
            Using cmd As New OleDb.OleDbCommand("SELECT sIl FROM tbIl WHERE sPlaka = ?", conn)
                cmd.Parameters.AddWithValue("?", cityCode)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not String.IsNullOrEmpty(result.ToString()) Then
                    Log("DEBUG", "GetIlName", $"cityCode={cityCode}, plaka ile bulundu: {result.ToString()}")
                    Return result.ToString()
                End If
            End Using
            
            ' Plaka ile bulunamazsa, il adı ile dene (case-insensitive ve Türkçe karakter toleranslı)
            ' Örn: "Kahramanmaraş" -> "Kahramanmaraş" veya "KAHRAMANMARAŞ"
            Using cmdByName As New OleDb.OleDbCommand("SELECT TOP 1 sIl FROM tbIl WHERE UPPER(sIl) = UPPER(?) OR sIl LIKE ?", conn)
                cmdByName.Parameters.AddWithValue("?", cityCode.ToUpperInvariant())
                cmdByName.Parameters.AddWithValue("?", cityCode & "%")
                Dim resultByName As Object = cmdByName.ExecuteScalar()
                If resultByName IsNot Nothing AndAlso Not String.IsNullOrEmpty(resultByName.ToString()) Then
                    Log("DEBUG", "GetIlName", $"cityCode={cityCode}, isim ile bulundu: {resultByName.ToString()}")
                    Return resultByName.ToString()
                End If
            End Using
            
            ' Türkçe karakter dönüşümü ile tekrar dene (İ->I, ı->i, ş->s, ğ->g, ü->u, ö->o, ç->c)
            Dim normalizedCity As String = NormalizeTurkishChars(cityCode)
            Using cmdNormalized As New OleDb.OleDbCommand("SELECT TOP 1 sIl FROM tbIl", conn)
                Dim reader As OleDb.OleDbDataReader = cmdNormalized.ExecuteReader()
                While reader.Read()
                    Dim dbIl As String = reader("sIl").ToString()
                    If String.Equals(NormalizeTurkishChars(dbIl), normalizedCity, StringComparison.OrdinalIgnoreCase) Then
                        reader.Close()
                        Log("DEBUG", "GetIlName", $"cityCode={cityCode}, normalize ile bulundu: {dbIl}")
                        Return dbIl
                    End If
                End While
                reader.Close()
            End Using
            
            Log("WARNING", "GetIlName", $"cityCode={cityCode} bulunamadı, gelen değer döndürülüyor")
            Return cityCode
        Catch ex As Exception
            LogError($"GetIlName hata: {ex.Message}")
            Return cityCode
        End Try
    End Function
    
    ''' <summary>
    ''' Türkçe karakterleri ASCII karşılıklarına dönüştürür (karşılaştırma için)
    ''' </summary>
    Private Function NormalizeTurkishChars(ByVal text As String) As String
        If String.IsNullOrEmpty(text) Then Return ""
        Return text.Replace("İ", "I").Replace("ı", "i").Replace("Ş", "S").Replace("ş", "s") _
                   .Replace("Ğ", "G").Replace("ğ", "g").Replace("Ü", "U").Replace("ü", "u") _
                   .Replace("Ö", "O").Replace("ö", "o").Replace("Ç", "C").Replace("ç", "c")
    End Function
    
    ''' <summary>
    ''' Veritabanından varsayılan il değerini alır (İstanbul - plaka 34)
    ''' Bu fonksiyon FK constraint hatalarını önlemek için gerçek veritabanı değerini döndürür
    ''' </summary>
    Private Function GetVarsayilanIl(ByVal conn As OleDb.OleDbConnection) As String
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            
            ' İstanbul için plaka 34 ile sorgula
            Using cmd As New OleDb.OleDbCommand("SELECT sIl FROM tbIl WHERE sPlaka = '34'", conn)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not String.IsNullOrEmpty(result.ToString()) Then
                    Log("DEBUG", "GetVarsayilanIl", $"Varsayilan il (plaka 34): {result.ToString()}")
                    Return result.ToString()
                End If
            End Using
            
            ' Plaka 34 bulunamazsa, tablodaki ilk kaydı al
            Using cmdFirst As New OleDb.OleDbCommand("SELECT TOP 1 sIl FROM tbIl ORDER BY sPlaka", conn)
                Dim resultFirst As Object = cmdFirst.ExecuteScalar()
                If resultFirst IsNot Nothing AndAlso Not String.IsNullOrEmpty(resultFirst.ToString()) Then
                    Log("WARNING", "GetVarsayilanIl", $"Plaka 34 bulunamadi, ilk kayit kullaniliyor: {resultFirst.ToString()}")
                    Return resultFirst.ToString()
                End If
            End Using
            
            ' Hiçbir şey bulunamazsa hardcoded değer (bu durumda FK hatası alınabilir)
            Log("ERROR", "GetVarsayilanIl", "tbIl tablosu bos! Varsayilan Istanbul kullaniliyor.")
            Return "Istanbul"
        Catch ex As Exception
            LogError($"GetVarsayilanIl hata: {ex.Message}")
            Return "Istanbul"
        End Try
    End Function
    Public Sub New()
        InitializeComponent()
        con.ConnectionString = connection
        cmd.CommandTimeout = 0 ' Sonsuz bekleme, alternatif: 30
        cmd.Connection = con
        stokSyncTimer.Interval = stokSyncInterval
        siparisSyncTimer.Interval = siparisSyncInterval
        
        ' Timer'ların kendi thread'inde çalışması için SynchronizingObject'i Nothing yap
        stokSyncTimer.SynchronizingObject = Nothing
        siparisSyncTimer.SynchronizingObject = Nothing
        
        AddHandler stokSyncTimer.Elapsed, AddressOf OnStokSyncTimerElapsed
        AddHandler siparisSyncTimer.Elapsed, AddressOf OnSiparisSyncTimerElapsed
        AddHandler btnManuelBaslat.Click, AddressOf BtnManuelBaslat_Click
        AddHandler btnOtomatikBaslat.Click, AddressOf BtnOtomatikBaslat_Click
        AddHandler btnDurdur.Click, AddressOf BtnDurdur_Click
        AddHandler btnTarihliSiparisCek.Click, AddressOf BtnTarihliSiparisCek_Click
        
        ' ComboBox varsayılan seçim
        cmbSiparisStatus.SelectedIndex = 0
        
        ' DateTimePicker varsayılan değerler (son 7 gün)
        dtpBitis.Value = DateTime.Now
        dtpBaslangic.Value = DateTime.Now.AddDays(-7)
        
        ' Form açıldığında öne gelmesi için
        AddHandler Me.Shown, AddressOf Form_Shown
        
        ' Kaydedilmis ayarlari yukle
        LoadSavedSettings()
        
        ' Form kapanirken ayarlari kaydet
        AddHandler Me.FormClosing, AddressOf Form_Closing_SaveSettings
        
        ' System Tray kurulumu
        SetupSystemTray()
    End Sub
    
    ''' <summary>
    ''' Form açıldığında öne getir
    ''' </summary>
    Private Sub Form_Shown(sender As Object, e As EventArgs)
        ' Normal durumda aç (minimize değil)
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
        
        ' Öne getir
        Me.TopMost = True
        Me.Activate()
        Me.BringToFront()
        Me.Focus()
        Me.TopMost = False  ' Kalıcı üstte kalmasın
    End Sub
    
    ''' <summary>
    ''' System Tray ikonunu ve menüsünü ayarlar
    ''' Form kapatıldığında arka planda çalışmaya devam etmesini sağlar
    ''' </summary>
    Private Sub SetupSystemTray()
        Try
            ' Programın kendi ikonunu kullan (64x64.ico)
            ' Önce formun ikonunu dene, yoksa uygulama ikonunu kullan
            If Me.Icon IsNot Nothing Then
                notifyIcon.Icon = Me.Icon
            Else
                ' Uygulama dizininden ikonu yükle
                Dim iconPath As String = System.IO.Path.Combine(Application.StartupPath, "64x64.ico")
                If System.IO.File.Exists(iconPath) Then
                    notifyIcon.Icon = New Icon(iconPath)
                Else
                    ' Son çare: sistem ikonu
                    notifyIcon.Icon = SystemIcons.Application
                End If
            End If
            notifyIcon.Text = "E-Ticaret Senkronizasyon - Çalışıyor"
            notifyIcon.Visible = False
            
            ' Sağ tık menüsü oluştur
            Dim mnuGoster As New ToolStripMenuItem("📺 Göster")
            mnuGoster.Font = New Font(mnuGoster.Font, FontStyle.Bold)
            
            Dim mnuDurum As New ToolStripMenuItem("📊 Durum: Beklemede")
            mnuDurum.Name = "mnuDurum"
            mnuDurum.Enabled = False
            
            Dim mnuSeparator1 As New ToolStripSeparator()
            
            Dim mnuManuelCalistir As New ToolStripMenuItem("▶️ Manuel Çalıştır")
            Dim mnuDurdur As New ToolStripMenuItem("⏸️ Senkronizasyonu Durdur")
            Dim mnuEksikVaryant As New ToolStripMenuItem("🔍 Eksik Varyantları Kontrol Et")
            
            Dim mnuSeparator2 As New ToolStripSeparator()
            
            Dim mnuKapat As New ToolStripMenuItem("❌ Tamamen Kapat")
            mnuKapat.ForeColor = Color.Red
            
            ' Event handler'ları ekle
            AddHandler mnuGoster.Click, Sub(s, ev)
                ShowFormFromTray()
            End Sub
            
            AddHandler mnuManuelCalistir.Click, Sub(s, ev)
                Task.Run(Sub()
                    Try
                        SafeUpdateUI(Sub() AddLog("System Tray'den manuel senkronizasyon başlatıldı..."))
                        RunSynchronizationAsync()
                        SafeUpdateUI(Sub() AddLog("System Tray manuel senkronizasyon tamamlandı."))
                    Catch ex As Exception
                        SafeUpdateUI(Sub() AddLog("System Tray manuel senkronizasyon hatası: " & ex.Message))
                    End Try
                End Sub)
            End Sub
            
            AddHandler mnuDurdur.Click, Sub(s, ev)
                Try
                    StopAllTimers()
                    UpdateTrayStatus("Durduruldu")
                    If notifyIcon IsNot Nothing Then
                        notifyIcon.ShowBalloonTip(2000, "Senkronizasyon", "Senkronizasyon durduruldu.", ToolTipIcon.Info)
                    End If
                Catch ex As Exception
                    ' Yok say
                End Try
            End Sub
            
            AddHandler mnuEksikVaryant.Click, Sub(s, ev)
                Task.Run(Sub()
                    Try
                        KontrolEtEksikVaryantlar()
                    Catch ex As Exception
                        SafeUpdateUI(Sub() AddLog("Eksik varyant kontrolü hatası: " & ex.Message))
                    End Try
                End Sub)
            End Sub
            
            AddHandler mnuKapat.Click, Sub(s, ev)
                Dim result = MessageBox.Show("Senkronizasyonu tamamen kapatmak istediğinize emin misiniz?" & vbCrLf & vbCrLf & "Bu işlem tüm otomatik senkronizasyonları durduracak ve formu açacak.", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Try
                        ' Sadece senkronizasyonu durdur
                        StopAllTimers()
                        ' Formu göster
                        ShowFormFromTray()
                    Catch ex As Exception
                        Debug.WriteLine("mnuKapat hatası: " & ex.Message)
                    End Try
                End If
            End Sub
            
            ' Uygulamayı tamamen kapatma menüsü
            Dim mnuSeparator3 As New ToolStripSeparator()
            Dim mnuCikis As New ToolStripMenuItem("🚪 Uygulamadan Çık")
            mnuCikis.ForeColor = Color.DarkRed
            
            AddHandler mnuCikis.Click, Sub(s, ev)
                Dim result = MessageBox.Show("Uygulamadan tamamen çıkmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = DialogResult.Yes Then
                    Try
                        StopAllTimers()
                        notifyIcon.Visible = False
                        notifyIcon.Dispose()
                    Catch
                        ' Yok say
                    End Try
                    Application.Exit()
                End If
            End Sub
            
            ' Menüye ekle
            trayContextMenu.Items.AddRange({mnuGoster, mnuDurum, mnuSeparator1, mnuManuelCalistir, mnuDurdur, mnuEksikVaryant, mnuSeparator2, mnuKapat, mnuSeparator3, mnuCikis})
            notifyIcon.ContextMenuStrip = trayContextMenu
            
            ' Çift tıklama ile formu göster
            AddHandler notifyIcon.DoubleClick, Sub(s, ev)
                ShowFormFromTray()
            End Sub
            
        Catch ex As Exception
            Debug.WriteLine("SetupSystemTray hatası: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' System Tray'den formu gösterir
    ''' </summary>
    Private Sub ShowFormFromTray()
        Try
            ' Form dispose edilmişse hiçbir şey yapma
            If Me.IsDisposed Then
                notifyIcon.Visible = False
                Exit Sub
            End If
            
            ' Tray ikonunu gizle
            notifyIcon.Visible = False
            
            ' Formu göster
            Me.Show()
            Me.WindowState = FormWindowState.Normal
            Me.Activate()
            
        Catch ex As ObjectDisposedException
            ' Form dispose edilmiş, sessizce çık
            notifyIcon.Visible = False
        Catch ex As Exception
            ' Diğer hatalar
        End Try
    End Sub
    
    ''' <summary>
    ''' System Tray menüsündeki durum metnini günceller
    ''' </summary>
    Private Sub UpdateTrayStatus(status As String)
        Try
            For Each item As ToolStripItem In trayContextMenu.Items
                If item.Name = "mnuDurum" Then
                    item.Text = "📊 Durum: " & status
                    Exit For
                End If
            Next
            notifyIcon.Text = "E-Ticaret Senkronizasyon - " & status
        Catch ex As Exception
            Debug.WriteLine("UpdateTrayStatus hatası: " & ex.Message)
        End Try
    End Sub
    
#Region "Ayarlari Kaydetme ve Yukleme"
    
    ''' <summary>
    ''' Kaydedilmis ayarlari yukler
    ''' </summary>
    Private Sub LoadSavedSettings()
        Try
            ' Checkbox ayarlarini yukle
            chkTumStoklar.Checked = My.Settings.EticaretTumStoklar
            chkFiyatDegisenleri.Checked = My.Settings.EticaretFiyatDegisenleri
            chkMiktarDegisenleri.Checked = My.Settings.EticaretMiktarDegisenleri
            chkResimGonder.Checked = My.Settings.EticaretResimGonder
            chkVaryantGuncelle.Checked = My.Settings.EticaretVaryantGuncelle
            chkKategoriGuncelle.Checked = My.Settings.EticaretKategoriGuncelle
            chkSiparisAl.Checked = My.Settings.EticaretSiparisAl
            chkTumSiparisler.Checked = My.Settings.EticaretTumSiparisler
            chkPazaryeriFiyatlari.Checked = My.Settings.EticaretPazaryeriFiyatlari
            
            ' Trigger checkbox ayarlarini yukle
            chkTriggerAktif.Checked = My.Settings.EticaretTriggerAktif
            chkTriggerStok.Checked = My.Settings.EticaretTriggerStok
            chkTriggerFiyat.Checked = My.Settings.EticaretTriggerFiyat
            chkTriggerResim.Checked = My.Settings.EticaretTriggerResim
            chkTriggerKategori.Checked = My.Settings.EticaretTriggerKategori
            
            ' Diger checkbox ayarlarini yukle
            chkTumunuGonder.Checked = My.Settings.EticaretTumunuGonder
            chkMarkaGonder.Checked = My.Settings.EticaretMarkaGonder
            chkKategoriGonder.Checked = My.Settings.EticaretKategoriGonder
            chkUzunAciklamaGonder.Checked = My.Settings.EticaretUzunAciklamaGonder
            chkKisaAciklamaGonder.Checked = My.Settings.EticaretKisaAciklamaGonder
            chkSEOGonder.Checked = My.Settings.EticaretSEOGonder
            chkDesiGonder.Checked = My.Settings.EticaretDesiGonder
            
            ' Timer surelerini yukle
            txtStokTimerDakika.Value = My.Settings.EticaretStokTimerDakika
            txtSiparisTimerDakika.Value = My.Settings.EticaretSiparisTimerDakika
            txtTriggerTimerDakika.Value = My.Settings.EticaretTriggerTimerDakika
            
            AddLog("Kaydedilmis ayarlar yuklendi.")
        Catch ex As Exception
            Debug.WriteLine("LoadSavedSettings hatasi: " & ex.Message)
            ' Hata olursa varsayilan degerler kalsin
        End Try
    End Sub
    
    ''' <summary>
    ''' Mevcut ayarlari kaydeder
    ''' </summary>
    Private Sub SaveCurrentSettings()
        Try
            ' Checkbox ayarlarini kaydet
            My.Settings.EticaretTumStoklar = chkTumStoklar.Checked
            My.Settings.EticaretFiyatDegisenleri = chkFiyatDegisenleri.Checked
            My.Settings.EticaretMiktarDegisenleri = chkMiktarDegisenleri.Checked
            My.Settings.EticaretResimGonder = chkResimGonder.Checked
            My.Settings.EticaretVaryantGuncelle = chkVaryantGuncelle.Checked
            My.Settings.EticaretKategoriGuncelle = chkKategoriGuncelle.Checked
            My.Settings.EticaretSiparisAl = chkSiparisAl.Checked
            My.Settings.EticaretTumSiparisler = chkTumSiparisler.Checked
            My.Settings.EticaretPazaryeriFiyatlari = chkPazaryeriFiyatlari.Checked
            
            ' Trigger checkbox ayarlarini kaydet
            My.Settings.EticaretTriggerAktif = chkTriggerAktif.Checked
            My.Settings.EticaretTriggerStok = chkTriggerStok.Checked
            My.Settings.EticaretTriggerFiyat = chkTriggerFiyat.Checked
            My.Settings.EticaretTriggerResim = chkTriggerResim.Checked
            My.Settings.EticaretTriggerKategori = chkTriggerKategori.Checked
            
            ' Diger checkbox ayarlarini kaydet
            My.Settings.EticaretTumunuGonder = chkTumunuGonder.Checked
            My.Settings.EticaretMarkaGonder = chkMarkaGonder.Checked
            My.Settings.EticaretKategoriGonder = chkKategoriGonder.Checked
            My.Settings.EticaretUzunAciklamaGonder = chkUzunAciklamaGonder.Checked
            My.Settings.EticaretKisaAciklamaGonder = chkKisaAciklamaGonder.Checked
            My.Settings.EticaretSEOGonder = chkSEOGonder.Checked
            My.Settings.EticaretDesiGonder = chkDesiGonder.Checked
            
            ' Timer surelerini kaydet
            My.Settings.EticaretStokTimerDakika = CInt(txtStokTimerDakika.Value)
            My.Settings.EticaretSiparisTimerDakika = CInt(txtSiparisTimerDakika.Value)
            My.Settings.EticaretTriggerTimerDakika = CInt(txtTriggerTimerDakika.Value)
            
            ' Degisiklikleri kaydet
            My.Settings.Save()
            
        Catch ex As Exception
            Debug.WriteLine("SaveCurrentSettings hatasi: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Form kapanirken ayarlari kaydeder
    ''' </summary>
    Private Sub Form_Closing_SaveSettings(sender As Object, e As FormClosingEventArgs)
        SaveCurrentSettings()
        AddLog("Ayarlar kaydedildi.")
    End Sub

    ''' <summary>
    ''' Seçili fiyat tipini döndürür (Pazaryeri Fiyatları seçili değilse)
    ''' </summary>
    Private Function GetSeciliFiyatTipi() As String
        Try
            If cmbFiyatTipi.SelectedItem IsNot Nothing Then
                Return cmbFiyatTipi.SelectedItem.ToString()
            End If
        Catch
        End Try
        Return "WEBP"
    End Function

#End Region

    ''' <summary>
    ''' Tüm timer'ları durdurur
    ''' </summary>
    Private Sub StopAllTimers()
        Try
            ' İptal bayrağını ayarla
            _cancelRequested = True

            ' CancellationTokenSource'u iptal et
            If _cts IsNot Nothing Then
                Try
                    _cts.Cancel()
                Catch ex As ObjectDisposedException
                    ' Zaten dispose edilmiş
                End Try
            End If

            stokSyncTimer.Stop()
            siparisSyncTimer.Stop()
            triggerSyncTimer.Stop()
            isRunning = False
            isTriggerRunning = False
            isSyncRunning = False

            SafeUpdateUI(Sub()
                             lblDurum.Text = "Durum: Durduruldu"
                             btnOtomatikBaslat.Enabled = True
                             btnManuelBaslat.Enabled = True
                             btnDurdur.Enabled = False
                             grpKriterler.Enabled = True
                             grpTimerlar.Enabled = True
                             AddLog("⏹️ Tüm senkronizasyonlar durduruldu.")
                         End Sub)
        Catch ex As Exception
            Debug.WriteLine("StopAllTimers hatası: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Thread-Safe UI güncelleme metodu
    ''' UI thread'ini bloke etmeden güncelleme yapar
    ''' </summary>
    Private Sub SafeUpdateUI(action As Action)
        Try
            If Me.IsDisposed OrElse Not Me.IsHandleCreated Then Exit Sub

            If Me.InvokeRequired Then
                Me.BeginInvoke(action) ' Invoke yerine BeginInvoke kullan - bloke etmez
            Else
                action()
            End If
        Catch ex As ObjectDisposedException
            ' Form kapatılmış, sessizce devam et
        Catch ex As InvalidOperationException
            ' Handle oluşturulmamış
        Catch ex As Exception
            Debug.WriteLine("SafeUpdateUI hatası: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Klasik Senkronizasyon Progress Bar'ı günceller
    ''' </summary>
    Private Sub UpdateKlasikProgress(current As Integer, total As Integer, Optional basarili As Integer = 0)
        SafeUpdateUI(Sub()
                         If total > 0 Then
                             prgKlasik.Maximum = total
                             prgKlasik.Value = Math.Min(current, total)
                             Dim kalan As Integer = total - current
                             lblKlasikSayac.Text = $"Sipariş: {current}/{total} | Başarılı: {basarili} | Kalan: {kalan}"
                         Else
                             prgKlasik.Value = 0
                             lblKlasikSayac.Text = "Sipariş: 0/0 | Başarılı: 0 | Kalan: 0"
                         End If
                     End Sub)
    End Sub

    ''' <summary>
    ''' Trigger Senkronizasyon Progress Bar'ı günceller
    ''' </summary>
    Private Sub UpdateTriggerProgress(current As Integer, total As Integer, Optional gonderilen As Integer = 0)
        SafeUpdateUI(Sub()
                         If total > 0 Then
                             prgTrigger.Maximum = total
                             prgTrigger.Value = Math.Min(current, total)
                             Dim kalan As Integer = total - current
                             lblTriggerSayac.Text = $"Ürün: {current}/{total} | Gönderilen: {gonderilen} | Kalan: {kalan}"
                         Else
                             prgTrigger.Value = 0
                             lblTriggerSayac.Text = "Ürün: 0/0 | Gönderilen: 0 | Kalan: 0"
                         End If
                     End Sub)
    End Sub

    ''' <summary>
    ''' Progress bar'ları sıfırlar
    ''' </summary>
    Private Sub ResetProgressBars()
        SafeUpdateUI(Sub()
                         prgKlasik.Value = 0
                         prgTrigger.Value = 0
                         lblKlasikSayac.Text = "Sipariş: 0/0 | Başarılı: 0 | Kalan: 0"
                         lblTriggerSayac.Text = "Ürün: 0/0 | Gönderilen: 0 | Kalan: 0"
                     End Sub)
    End Sub

    ''' <summary>
    ''' Checkbox değerini thread-safe okur (UI'dan)
    ''' NOT: Arka plan işlemleri için GetAyarBool kullanın
    ''' </summary>
    Private Function GetCheckboxValue(chk As CheckBox) As Boolean
        Try
            If Me.IsDisposed OrElse Not Me.IsHandleCreated Then Return False

            If Me.InvokeRequired Then
                Return CBool(Me.Invoke(Function() chk.Checked))
            Else
                Return chk.Checked
            End If
        Catch
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Veritabanından ayar değerini Boolean olarak okur (Thread-safe)
    ''' Arka plan senkronizasyon işlemleri için kullanılır
    ''' </summary>
    Private Function GetAyarBool(ayarKodu As String, Optional varsayilan As Boolean = False) As Boolean
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                Dim deger As String = AyarOku(conn, ayarKodu)
                conn.Close()
                
                If String.IsNullOrEmpty(deger) Then
                    Return varsayilan
                End If
                Return (deger = "1")
            End Using
        Catch ex As Exception
            Debug.WriteLine($"GetAyarBool hatası ({ayarKodu}): " & ex.Message)
            Return varsayilan
        End Try
    End Function

    ''' <summary>
    ''' Veritabanından ayar değerini String olarak okur (Thread-safe)
    ''' </summary>
    Private Function GetAyarString(ayarKodu As String, Optional varsayilan As String = "") As String
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                Dim deger As String = AyarOku(conn, ayarKodu)
                conn.Close()
                
                If String.IsNullOrEmpty(deger) Then
                    Return varsayilan
                End If
                Return deger
            End Using
        Catch ex As Exception
            Debug.WriteLine($"GetAyarString hatası ({ayarKodu}): " & ex.Message)
            Return varsayilan
        End Try
    End Function

    ''' <summary>
    ''' Veritabanından ayar değerini Decimal olarak okur (Thread-safe)
    ''' </summary>
    Private Function GetAyarDecimal(ayarKodu As String, Optional varsayilan As Decimal = 0D) As Decimal
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                Dim deger As String = AyarOku(conn, ayarKodu)
                conn.Close()
                
                If String.IsNullOrEmpty(deger) OrElse Not IsNumeric(deger) Then
                    Return varsayilan
                End If
                Return CDec(deger)
            End Using
        Catch ex As Exception
            Debug.WriteLine($"GetAyarDecimal hatası ({ayarKodu}): " & ex.Message)
            Return varsayilan
        End Try
    End Function

    ''' <summary>
    ''' NumericUpDown değerini thread-safe okur
    ''' </summary>
    Private Function GetNumericValue(nud As NumericUpDown) As Decimal
        Try
            If Me.IsDisposed OrElse Not Me.IsHandleCreated Then Return 0D

            If Me.InvokeRequired Then
                Return CDec(Me.Invoke(Function() nud.Value))
            Else
                Return nud.Value
            End If
        Catch ex As Exception
            Log("WARNING", "GetNumericValue", $"NumericUpDown değeri okunamadı: {ex.Message}")
            Return 0D
        End Try
    End Function

    ''' <summary>
    ''' TextBox değerini thread-safe okur
    ''' </summary>
    Private Function GetTextBoxValue(txt As TextBox) As String
        Try
            If Me.IsDisposed OrElse Not Me.IsHandleCreated Then Return ""

            If Me.InvokeRequired Then
                Return CStr(Me.Invoke(Function() txt.Text))
            Else
                Return txt.Text
            End If
        Catch ex As Exception
            Log("WARNING", "GetTextBoxValue", $"TextBox değeri okunamadı: {ex.Message}")
            Return ""
        End Try
    End Function

    ''' <summary>
    ''' Form kapatılırken çağrılır
    ''' Otomatik senkronizasyon çalışıyorsa System Tray'e minimize eder
    ''' </summary>
    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        If isRunning OrElse isTriggerRunning Then
            e.Cancel = True ' Kapatmayı iptal et

            ' SADECE HIDE - Basit tut
            Me.Hide()

            notifyIcon.Visible = True
            UpdateTrayStatus("Arka Planda Çalışıyor")
            notifyIcon.ShowBalloonTip(3000, "E-Ticaret Senkronizasyon",
                "Senkronizasyon arka planda devam ediyor." & vbCrLf & "Kapatmak için sağ tıklayın.",
                ToolTipIcon.Info)
        Else
            notifyIcon.Visible = False
            Try
                notifyIcon.Dispose()
            Catch
            End Try
            MyBase.OnFormClosing(e)
        End If
    End Sub

    Private Sub BtnManuelBaslat_Click(sender As Object, e As EventArgs)
        Try
            ' İptal bayrağını sıfırla
            _cancelRequested = False

            ' Yeni CancellationTokenSource oluştur
            If _cts IsNot Nothing Then
                Try : _cts.Dispose() : Catch : End Try
            End If
            _cts = New CancellationTokenSource()

            AddLog("Manuel senkronizasyon başlatılıyor...")
            lblDurum.Text = "Durum: İşlemde..."
            btnManuelBaslat.Enabled = False
            btnDurdur.Enabled = True

            ' Async olarak çalıştır - UI'ı bloke etmez
            Task.Run(Sub()
                         Try
                             RunSynchronizationAsync()
                             SafeUpdateUI(Sub()
                                              If _cancelRequested Then
                                                  lblDurum.Text = "Durum: İptal Edildi"
                                                  AddLog("⏹️ Manuel senkronizasyon iptal edildi.")
                                              Else
                                                  lblDurum.Text = "Durum: Tamamlandı"
                                                  AddLog("✅ Manuel senkronizasyon tamamlandı.")
                                                  MessageBox.Show("Senkronizasyon başarıyla tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                              End If
                                              btnManuelBaslat.Enabled = True
                                              btnDurdur.Enabled = False
                                          End Sub)
                         Catch ex As OperationCanceledException
                             SafeUpdateUI(Sub()
                                              lblDurum.Text = "Durum: İptal Edildi"
                                              btnManuelBaslat.Enabled = True
                                              btnDurdur.Enabled = False
                                              AddLog("⏹️ Senkronizasyon kullanıcı tarafından iptal edildi.")
                                          End Sub)
                         Catch ex As Exception
                             SafeUpdateUI(Sub()
                                              lblDurum.Text = "Durum: Hata!"
                                              btnManuelBaslat.Enabled = True
                                              btnDurdur.Enabled = False
                                              AddLog("HATA: " & ex.Message)
                                              MessageBox.Show("Senkronizasyon hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                          End Sub)
                         End Try
                     End Sub)
        Catch ex As Exception
            lblDurum.Text = "Durum: Hata!"
            btnManuelBaslat.Enabled = True
            btnDurdur.Enabled = False
            AddLog("HATA: " & ex.Message)
            MessageBox.Show("Senkronizasyon hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnOtomatikBaslat_Click(sender As Object, e As EventArgs)
        Try
            ' İptal bayrağını sıfırla
            _cancelRequested = False

            ' Yeni CancellationTokenSource oluştur
            If _cts IsNot Nothing Then
                Try : _cts.Dispose() : Catch : End Try
            End If
            _cts = New CancellationTokenSource()

            ' Timer sürelerini ayarla
            stokSyncInterval = CDbl(txtStokTimerDakika.Value) * 60000
            siparisSyncInterval = CDbl(txtSiparisTimerDakika.Value) * 60000
            stokSyncTimer.Interval = stokSyncInterval
            siparisSyncTimer.Interval = siparisSyncInterval

            ' Timer'ları başlat
            If chkTumStoklar.Checked OrElse chkFiyatDegisenleri.Checked OrElse chkMiktarDegisenleri.Checked OrElse chkResimGonder.Checked Then
                stokSyncTimer.Start()
                AddLog($"Stok timer başlatıldı. Kontrol süresi: {txtStokTimerDakika.Value} dakika")
            End If

            If chkSiparisAl.Checked Then
                siparisSyncTimer.Start()
                AddLog($"Sipariş timer başlatıldı. Kontrol süresi: {txtSiparisTimerDakika.Value} dakika")
            End If

            isRunning = True
            lblDurum.Text = "Durum: Otomatik Çalışıyor"
            btnOtomatikBaslat.Enabled = False
            btnManuelBaslat.Enabled = False
            btnDurdur.Enabled = True
            ' NOT: Kriterler ve timer ayarları artık kilitlenmiyor - kullanıcı değiştirebilir
            ' grpKriterler.Enabled = False  ' KALDIRILDI
            ' grpTimerlar.Enabled = False   ' KALDIRILDI
            AddLog("Otomatik senkronizasyon başlatıldı.")
            AddLog("💡 İpucu: Formu kapatsanız bile senkronizasyon arka planda devam edecek.")
            AddLog("⚠️ Durdurmak için 'Durdur' butonuna tıklayın.")

            ' System Tray durumunu güncelle
            UpdateTrayStatus("Otomatik Çalışıyor")
        Catch ex As Exception
            MessageBox.Show("Otomatik başlatma hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnDurdur_Click(sender As Object, e As EventArgs)
        Try
            StopAllTimers()
            UpdateTrayStatus("Durduruldu")
            AddLog("Otomatik senkronizasyon durduruldu.")
        Catch ex As Exception
            MessageBox.Show("Durdurma hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub OnStokSyncTimerElapsed(sender As Object, e As ElapsedEventArgs)
        ' Eğer zaten bir senkronizasyon çalışıyorsa, atla
        If isSyncRunning Then
            SafeUpdateUI(Sub() AddLog("⚠️ Önceki stok senkronizasyonu devam ediyor, bu döngü atlandı."))
            Exit Sub
        End If

        ' Async Task olarak çalıştır - UI'ı bloke etmez
        Task.Run(Sub()
                     SyncLock _syncLockObj
                         If isSyncRunning Then Exit Sub
                         isSyncRunning = True
                     End SyncLock

                     Try
                         SafeUpdateUI(Sub()
                                          AddLog("Stok otomatik kontrolü başlatıldı...")
                                          lblDurum.Text = "Durum: Stok kontrol ediliyor..."
                                      End Sub)

                         UpdateTrayStatus("Stok Kontrol Ediliyor...")

                         LoadConfig()

                         ' ===== AYARLARI VERİTABANINDAN OKU (Thread-safe) =====
                         Dim ayarMiktarDegisen As Boolean = GetAyarBool("SENKRON_MIKTAR_DEGISEN", True)
                         Dim ayarFiyatDegisen As Boolean = GetAyarBool("SENKRON_FIYAT_DEGISEN", True)
                         Dim ayarTumStoklar As Boolean = GetAyarBool("SENKRON_TUM_STOKLAR", False)
                         Dim ayarResimGonder As Boolean = GetAyarBool("SENKRON_RESIM_GONDER", True)

                         ' ===== HIZLI GÜNCELLEME: Sadece değişenleri gönder =====
                         If ayarMiktarDegisen AndAlso Not ayarTumStoklar Then
                             SafeUpdateUI(Sub() AddLog("Hızlı stok güncellemesi yapılıyor (product/updateStocks)..."))
                             SyncChangedStocks()
                         End If

                         If ayarFiyatDegisen AndAlso Not ayarTumStoklar Then
                             SafeUpdateUI(Sub() AddLog("Hızlı fiyat güncellemesi yapılıyor (product/updatePrices)..."))
                             SyncChangedPrices()
                         End If

                         ' ===== TAM GÜNCELLEME: Tüm ürünleri gönder =====
                         If ayarTumStoklar Then
                             ProductSync1()
                             ForceUpdateAllProducts() ' Tüm ürünleri status=0 yap
                         End If
                         If ayarFiyatDegisen OrElse ayarMiktarDegisen Then
                             ProductSync2()
                         End If
                         If ayarResimGonder Then
                             ProductSync3()
                         End If
                         ProductSync4()

                         SafeUpdateUI(Sub()
                                          lblDurum.Text = "Durum: Otomatik Çalışıyor"
                                          AddLog("Stok otomatik kontrolü tamamlandı.")
                                      End Sub)

                         UpdateTrayStatus("Otomatik Çalışıyor")
                     Catch ex As Exception
                         SafeUpdateUI(Sub() AddLog("Stok kontrolü hatası: " & ex.Message))
                         Debug.WriteLine("Stok kontrolü hatası: " & ex.Message)
                     Finally
                         SyncLock _syncLockObj
                             isSyncRunning = False
                         End SyncLock
                     End Try
                 End Sub)
    End Sub

    Private Sub OnSiparisSyncTimerElapsed(sender As Object, e As ElapsedEventArgs)
        ' Async Task olarak çalıştır - UI'ı bloke etmez
        Task.Run(Sub()
                     Try
                         SafeUpdateUI(Sub()
                                          AddLog("Sipariş otomatik kontrolü başlatıldı...")
                                          lblDurum.Text = "Durum: Siparişler kontrol ediliyor..."
                                      End Sub)

                         UpdateTrayStatus("Siparişler Kontrol Ediliyor...")

                         LoadConfig()
                         
                         ' ===== AYARI VERİTABANINDAN OKU (Thread-safe) =====
                         Dim ayarSiparisAl As Boolean = GetAyarBool("SENKRON_SIPARIS_AL", True)
                         
                         If ayarSiparisAl Then
                             ' Otomatik çalıştırmada her zaman sadece yeni siparişleri çek (status=1)
                             OrderSync(False)
                         End If

                         SafeUpdateUI(Sub()
                                          lblDurum.Text = "Durum: Otomatik Çalışıyor"
                                          AddLog("Sipariş otomatik kontrolü tamamlandı.")
                                      End Sub)

                         UpdateTrayStatus("Otomatik Çalışıyor")
                     Catch ex As Exception
                         SafeUpdateUI(Sub() AddLog("Sipariş kontrolü hatası: " & ex.Message))
                         Debug.WriteLine("Sipariş kontrolü hatası: " & ex.Message)
                     End Try
                 End Sub)
    End Sub
    Private Sub AddLog(message As String)
        Try
            ' Form veya TextBox disposed ise sadece Console'a yaz
            If Me.IsDisposed OrElse txtLog Is Nothing OrElse txtLog.IsDisposed Then
                Console.WriteLine("[LOG] " & message)
                Exit Sub
            End If

            If txtLog.InvokeRequired Then
                If Me.IsHandleCreated AndAlso Not Me.IsDisposed Then
                    txtLog.Invoke(Sub() AddLog(message))
                Else
                    Console.WriteLine("[LOG] " & message)
                End If
            Else
                Dim timestamp As String = DateTime.Now.ToString("HH:mm:ss")
                txtLog.AppendText($"[{timestamp}] {message}{vbCrLf}")
            End If
        Catch ex As ObjectDisposedException
            Console.WriteLine("[LOG] " & message)
        Catch ex As Exception
            Console.WriteLine("[LOG ERROR] " & ex.Message & " - " & message)
        End Try
    End Sub
    Public Sub RunSynchronization()
        Log("INFO", "RunSynchronization", "Senkronizasyon işlemi başlatılıyor.")
        Try
            LoadConfig()

            ' Kriterlere gÜ¶re işlemleri Çalıştır
            If chkTumStoklar.Checked Then
                ProductSync1()
                ForceUpdateAllProducts()
            End If

            If chkFiyatDegisenleri.Checked OrElse chkMiktarDegisenleri.Checked Then
                ProductSync2()
            End If

            If chkResimGonder.Checked OrElse chkTumStoklar.Checked Then
                ProductSync3()
            End If

            ProductSync4()

            ' ===== YENİ: Hızlı stok ve fiyat güncelleme =====
            ' Sadece değişenleri hızlı güncelle (product/updateStocks ve product/updatePrices)
            If chkMiktarDegisenleri.Checked AndAlso Not chkTumStoklar.Checked Then
                Log("INFO", "RunSynchronization", "Hızlı stok güncellemesi yapılıyor...")
                SyncChangedStocks()
            End If

            If chkFiyatDegisenleri.Checked AndAlso Not chkTumStoklar.Checked Then
                Log("INFO", "RunSynchronization", "Hızlı fiyat güncellemesi yapılıyor...")
                SyncChangedPrices()
            End If
            If chkSiparisAl.Checked Then
                ' Manuel çalıştırmada checkbox'a göre tüm veya yeni siparişler
                Dim fetchAll As Boolean = chkTumSiparisler.Checked
                OrderSync(fetchAll)
            End If

            Log("INFO", "RunSynchronization", "Senkronizasyon işlemi tamamlandı.")
        Catch ex As Exception
            LogError("Senkronizasyon hatası: " & ex.Message)
            Throw
        End Try
    End Sub
    ''' <summary>
    ''' Asynchronous version of RunSynchronization - UI'ı bloke etmez
    ''' Ayarları VERİTABANINDAN okur (Thread-safe)
    ''' </summary>
    Public Sub RunSynchronizationAsync()
        Log("INFO", "RunSynchronizationAsync", "Asenkron senkronizasyon işlemi başlatılıyor.")
        Try
            ' İptal kontrolü
            If _cancelRequested Then
                Log("INFO", "RunSynchronizationAsync", "⏹️ İptal isteği alındı, senkronizasyon başlamadı.")
                Return
            End If

            LoadConfig()

            ' ===== AYARLARI VERİTABANINDAN OKU (Thread-safe) =====
            Dim ayarTumStoklar As Boolean = GetAyarBool("SENKRON_TUM_STOKLAR", False)
            Dim ayarFiyatDegisen As Boolean = GetAyarBool("SENKRON_FIYAT_DEGISEN", True)
            Dim ayarMiktarDegisen As Boolean = GetAyarBool("SENKRON_MIKTAR_DEGISEN", True)
            Dim ayarResimGonder As Boolean = GetAyarBool("SENKRON_RESIM_GONDER", True)
            Dim ayarVaryantGuncelle As Boolean = GetAyarBool("SENKRON_VARYANT_GUNCELLE", False)
            Dim ayarKategoriGuncelle As Boolean = GetAyarBool("SENKRON_KATEGORI_GUNCELLE", True)
            Dim ayarSiparisAl As Boolean = GetAyarBool("SENKRON_SIPARIS_AL", True)
            Dim ayarTumSiparisler As Boolean = GetAyarBool("SENKRON_TUM_SIPARISLER", False)

            ' Kriterlere göre işlemleri çalıştır - her adımda iptal kontrolü
            If ayarTumStoklar AndAlso Not _cancelRequested Then
                ProductSync1()
                If Not _cancelRequested Then ForceUpdateAllProducts()
            End If

            If (ayarFiyatDegisen OrElse ayarMiktarDegisen) AndAlso Not _cancelRequested Then
                ProductSync2()
            End If

            If (ayarResimGonder OrElse ayarTumStoklar) AndAlso Not _cancelRequested Then
                ProductSync3()
            End If

            If Not _cancelRequested Then
                ProductSync4()
            End If

            ' ===== YENİ: Hızlı stok ve fiyat güncelleme =====
            ' Sadece değişenleri hızlı güncelle (product/updateStocks ve product/updatePrices)
            If ayarMiktarDegisen AndAlso Not ayarTumStoklar AndAlso Not _cancelRequested Then
                Log("INFO", "RunSynchronizationAsync", "Hızlı stok güncellemesi yapılıyor...")
                SyncChangedStocks()
            End If

            If ayarFiyatDegisen AndAlso Not ayarTumStoklar AndAlso Not _cancelRequested Then
                Log("INFO", "RunSynchronizationAsync", "Hızlı fiyat güncellemesi yapılıyor...")
                SyncChangedPrices()
            End If

            ' YENİ: Varyant güncelleme
            If ayarVaryantGuncelle AndAlso Not _cancelRequested Then
                Log("INFO", "RunSynchronizationAsync", "Varyant güncelleme yapılıyor...")
                SyncChangedVariants()
            End If

            ' YENİ: Kategori güncelleme
            If ayarKategoriGuncelle AndAlso Not _cancelRequested Then
                Log("INFO", "RunSynchronizationAsync", "Kategori güncelleme yapılıyor...")
                SyncChangedCategories()
            End If

            If ayarSiparisAl AndAlso Not _cancelRequested Then
                ' Manuel çalıştırmada checkbox'a göre tüm veya yeni siparişler
                OrderSync(ayarTumSiparisler)
            End If

            If _cancelRequested Then
                Log("INFO", "RunSynchronizationAsync", "⏹️ Asenkron senkronizasyon iptal edildi.")
            Else
                Log("INFO", "RunSynchronizationAsync", "✅ Asenkron senkronizasyon işlemi tamamlandı.")
            End If
        Catch ex As Exception
            LogError("Asenkron senkronizasyon hatası: " & ex.Message)
            Throw
        End Try
    End Sub
    Private Sub LoadConfig()
        Log("INFO", "LoadConfig", "⚙️ Yapılandırma yükleniyor...")
        Using conn As New OleDb.OleDbConnection
            Try
                conn.ConnectionString = connection
                conn.Open()
                Log("DEBUG", "LoadConfig", "✅ Veritabanı bağlantısı açıldı.")

                Dim cmd As New OleDb.OleDbCommand
                cmd.CommandText = "SELECT ApiKey, ApiSecret, ProductSave FROM tbParamGenel"
                cmd.Connection = conn

                Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    ApiKey = If(reader("ApiKey") Is DBNull.Value, "", reader("ApiKey").ToString().Trim())
                    ApiSecret = If(reader("ApiSecret") Is DBNull.Value, "", reader("ApiSecret").ToString().Trim())
                    LAGlobalAddress = If(reader("ProductSave") Is DBNull.Value, "", reader("ProductSave").ToString().Trim())

                    ' Validation
                    If String.IsNullOrEmpty(ApiKey) Then
                        LogError("⚠️ ApiKey boş! Lütfen tbParamGenel tablosunda ApiKey alanını doldurun.")
                        Throw New Exception("ApiKey boş")
                    End If

                    If String.IsNullOrEmpty(ApiSecret) Then
                        LogError("⚠️ ApiSecret boş! Lütfen tbParamGenel tablosunda ApiSecret alanını doldurun.")
                        Throw New Exception("ApiSecret boş")
                    End If

                    If String.IsNullOrEmpty(LAGlobalAddress) Then
                        LogError("⚠️ ProductSave (API URL) boş! Lütfen tbParamGenel tablosunda ProductSave alanını doldurun.")
                        Throw New Exception("ProductSave boş")
                    End If

                    ' URL formatını kontrol et
                    If Not LAGlobalAddress.StartsWith("http://") AndAlso Not LAGlobalAddress.StartsWith("https://") Then
                        LogError($"⚠️ ProductSave geçersiz URL formatı: {LAGlobalAddress}")
                        LogError("URL http:// veya https:// ile başlamalı. Örnek: https://api.example.com/v1/")
                        Throw New Exception("ProductSave geçersiz URL formatı")
                    End If

                    Log("SUCCESS", "LoadConfig", "✅ Yapılandırma başarıyla yüklendi!")
                    Log("INFO", "LoadConfig", $"🔑 API Key: {ApiKey.Substring(0, Math.Min(8, ApiKey.Length))}***")
                    Log("INFO", "LoadConfig", $"🔐 API Secret: {ApiSecret.Substring(0, Math.Min(8, ApiSecret.Length))}***")
                    Log("INFO", "LoadConfig", $"🌐 API URL: {LAGlobalAddress}")
                Else
                    LogError("❌ tbParamGenel tablosunda yapılandırma bulunamadı!")
                    Throw New Exception("Configuration not found in tbParamGenel")
                End If
                reader.Close()
            Catch ex As Exception
                LogError($"❌ Yapılandırma yükleme hatası: {ex.Message}")
                LogError($"🔍 Stack Trace: {ex.StackTrace}")
                Throw
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                    Log("DEBUG", "LoadConfig", "🔌 Veritabanı bağlantısı kapatıldı.")
                End If
            End Try
        End Using
    End Sub
    Private Sub ForceUpdateAllProducts()
        ' TÜM STOKLAR seçiliyse: Tüm ürünleri status=0 yap (tekrar gönderim için)
        Log("INFO", "ForceUpdateAllProducts", "Tüm ürünler güncelleme için işaretleniyor (status=0)...")
        Using conn As New OleDb.OleDbConnection
            Try
                conn.ConnectionString = connection
                conn.Open()
                Log("DEBUG", "ForceUpdateAllProducts", "Veritabanı bağlantısı açıldı.")
                Dim cmd As New OleDb.OleDbCommand
                cmd.CommandText = "UPDATE Products SET status = '0', updated_at = GETDATE()"
                cmd.Connection = conn
                Dim updatedCount As Integer = cmd.ExecuteNonQuery()
                Log("INFO", "ForceUpdateAllProducts", $"Tüm ürünler güncelleme için işaretlendi. Toplam: {updatedCount} ürün")
            Catch ex As Exception
                LogError("Error in ForceUpdateAllProducts: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                    Log("DEBUG", "ForceUpdateAllProducts", "Veritabanı bağlantısı kapatıldı.")
                End If
            End Try
        End Using
    End Sub
    Private Sub ProductSync1()
        Log("INFO", "ProductSync1", "Ürün senkronizasyonu (1) başlatılıyor.")

        ' İptal kontrolü
        If _cancelRequested Then
            Log("INFO", "ProductSync1", "⏹️ İptal isteği alındı, atlanıyor...")
            Return
        End If
        Using conn As New OleDb.OleDbConnection
            Try
                conn.ConnectionString = connection
                conn.Open()
                Log("DEBUG", "ProductSync1", "Veritabanı bağlantısı açıldı.")
                Dim cmd As New OleDb.OleDbCommand
                cmd.CommandText = "SELECT T1.sModel, T1.sRenk FROM [tbStok] AS T1 LEFT JOIN [tbStokSinifi] AS T3 ON T3.nStokID=T1.nStokID WHERE T1.bWebGoruntule='1' GROUP BY T1.sModel, T1.sRenk ORDER BY T1.sModel DESC"
                cmd.Connection = conn
                Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                Dim count As Integer = 0
                While reader.Read() AndAlso Not _cancelRequested
                    Dim rawModel As String = Trim(reader("sModel").ToString)
                    Dim renk As String = Trim(reader("sRenk").ToString)

                    ' sModel direkt kullan - veritabanında zaten doğru
                    Dim id As String = rawModel & "__" & renk
                    InsertProductIfNotExists(id, conn)
                    count += 1
                End While
                reader.Close()

                If _cancelRequested Then
                    Log("INFO", "ProductSync1", $"⏹️ Ürün senkronizasyonu (1) iptal edildi. işlenen: {count}")
                Else
                    Log("INFO", "ProductSync1", $"Ürün senkronizasyonu (1) tamamlandı. işlenen ürün sayısı: {count}")
                End If
            Catch ex As Exception
                LogError("Error in ProductSync1: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                    Log("DEBUG", "ProductSync1", "Veritabanı bağlantısı kapatıldı.")
                End If
            End Try
        End Using
    End Sub
    Private Sub ProductSync2()
        Log("INFO", "ProductSync2", "Ürün senkronizasyonu (2) başlatılıyor.")
        Using conn As New OleDb.OleDbConnection
            Try
                conn.ConnectionString = connection
                conn.Open()
                Log("DEBUG", "ProductSync2", "Veritabanı bağlantısı açıldı.")
                Dim date20 As String = DateTime.Now.AddMinutes(-20).ToString("yyyy-MM-ddTHH:mm:ss")
                Dim cmd1 As New OleDb.OleDbCommand
                cmd1.CommandText = "SELECT TOP 1000 T2.sModel, T2.sRenk, T1.nIslemID FROM [tbStokFisiDetayi] AS T1 LEFT JOIN tbStok AS T2 ON T2.nStokID=T1.nStokID WHERE T1.[dteSonUpdateTarihi] >= ? AND T2.bWebGoruntule='1' ORDER BY T1.dteSonUpdateTarihi DESC"
                cmd1.Parameters.AddWithValue("?", date20)
                cmd1.Connection = conn
                Dim reader1 As OleDb.OleDbDataReader = cmd1.ExecuteReader()
                Dim count1 As Integer = 0
                While reader1.Read()
                    Dim rawModel As String = Trim(reader1("sModel").ToString)
                    Dim renk As String = Trim(reader1("sRenk").ToString)
                    Dim nIslemID As String = reader1("nIslemID").ToString

                    ' sModel direkt kullan
                    Dim id As String = rawModel & "__" & renk
                    InsertFisIfNotExists(nIslemID, id, conn)
                    count1 += 1
                End While
                reader1.Close()
                Log("DEBUG", "ProductSync2", $"Stok fişi güncellemeleri işlendi. işlenen kayıt sayısı: {count1}")
                Dim cmd2 As New OleDb.OleDbCommand
                cmd2.CommandText = "SELECT TOP 1000 T2.sModel, T2.sRenk FROM [tbStokFiyati] AS T1 LEFT JOIN tbStok AS T2 ON T2.nStokID=T1.nStokID WHERE T1.[dteKayitTarihi] >= ? AND T2.bWebGoruntule='1' ORDER BY T1.[dteKayitTarihi] ASC"
                cmd2.Parameters.AddWithValue("?", date20)
                cmd2.Connection = conn
                Dim reader2 As OleDb.OleDbDataReader = cmd2.ExecuteReader()
                Dim count2 As Integer = 0
                While reader2.Read()
                    Dim rawModel As String = Trim(reader2("sModel").ToString)
                    Dim renk As String = Trim(reader2("sRenk").ToString)

                    ' sModel direkt kullan
                    Dim id As String = rawModel & "__" & renk
                    Dim update As New OleDb.OleDbCommand
                    update.CommandText = "UPDATE Products SET status = '0', updated_at = GETDATE() WHERE productID = ?"
                    update.Parameters.AddWithValue("?", id)
                    update.Connection = conn
                    update.ExecuteNonQuery()
                    count2 += 1
                End While
                reader2.Close()
                Log("INFO", "ProductSync2", $"Ürün senkronizasyonu (2) tamamlandı. Güncellenen fiyat kayıt sayısı: {count2}")
            Catch ex As Exception
                LogError("Error in ProductSync2: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                    Log("DEBUG", "ProductSync2", "Veritabanı bağlantısı kapatıldı.")
                End If
            End Try
        End Using
    End Sub
    Private Sub ProductSync3()
        Log("INFO", "ProductSync3", "Ürün senkronizasyonu (3) başlatılıyor.")

        ' *** URUN KONTROLU: Tum web urunlerinin kuyrukta oldugundan emin ol ***
        EnsureAllWebProductsInQueue()

        ' Iptal kontrolu
        If _cancelRequested Then
            Log("INFO", "ProductSync3", "Iptal istegi alindi, cikiliyor...")
            Return
        End If

        ' Toplam gönderilecek ürün sayısını al
        Dim totalToSend As Integer = 0
        Using countConn As New OleDb.OleDbConnection(connection)
            countConn.Open()
            Dim countCmd As New OleDb.OleDbCommand("SELECT COUNT(*) FROM Products WHERE status = '0'", countConn)
            totalToSend = Convert.ToInt32(countCmd.ExecuteScalar())
        End Using

        Log("INFO", "ProductSync3", $"📊 Toplam gönderilecek ürün: {totalToSend}")
        SafeUpdateUI(Sub() lblDurum.Text = $"Durum: 0/{totalToSend} ürün gönderildi")

        Dim totalSent As Integer = 0
        Dim batchNumber As Integer = 0
        Dim hasMoreProducts As Boolean = True

        ' Kuyrukta ürün kalmayana kadar devam et (iptal kontrolü ile)
        While hasMoreProducts AndAlso Not _cancelRequested
            ' İptal kontrolü
            If _cancelRequested Then
                Log("INFO", "ProductSync3", "⏹️ İptal isteği alındı, döngüden çıkılıyor...")
                Exit While
            End If

            batchNumber += 1
            Dim bulkProducts As New List(Of Dictionary(Of String, Object))

            Using conn As New OleDb.OleDbConnection
                Try
                    conn.ConnectionString = connection
                    conn.Open()

                    Dim cmd As New OleDb.OleDbCommand
                    ' Sunucu timeout sorunu için batch boyutu 3'e düşürüldü
                    cmd.CommandText = "SELECT TOP 3 * FROM Products WHERE status = '0' ORDER BY NEWID()"
                    cmd.Connection = conn
                    Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader()

                    While reader.Read() AndAlso Not _cancelRequested
                        Dim id As String = reader("productID").ToString
                        Dim res As Dictionary(Of String, Object) = SendProduct(id, conn)
                        If res IsNot Nothing AndAlso res.Count > 0 Then
                            If Not res.ContainsKey("code") OrElse String.IsNullOrWhiteSpace(res("code").ToString()) Then
                                Log("WARNING", "ProductSync3", $"Ürün kodu eksik: productID={id}")
                                ' Hatalı ürünü işaretle (status = '2' = hatalı)
                                MarkProductAsError(id, "Ürün kodu eksik")
                                Continue While
                            End If
                            bulkProducts.Add(res)
                        Else
                            ' SendProduct hata döndürdü, ürünü hatalı olarak işaretle
                            Log("WARNING", "ProductSync3", $"SendProduct başarısız: productID={id}")
                            MarkProductAsError(id, "SendProduct işlemi başarısız")
                        End If
                    End While
                    reader.Close()

                Catch ex As Exception
                    LogError("Error in ProductSync3 reading products: " & ex.Message)
                    hasMoreProducts = False
                    Exit While
                Finally
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                End Try
            End Using

            ' İptal kontrolü
            If _cancelRequested Then
                Log("INFO", "ProductSync3", "⏹️ İptal isteği alındı, API gönderimi atlanıyor...")
                Exit While
            End If

            ' Gönderilecek ürün yoksa döngüden çık
            If bulkProducts.Count = 0 Then
                ' Eğer hiç ürün okunamadıysa ve kuyrukta hala ürün varsa, hatalı ürünleri atla
                Using checkConn As New OleDb.OleDbConnection
                    checkConn.ConnectionString = connection
                    checkConn.Open()
                    Dim checkCmd As New OleDb.OleDbCommand("SELECT COUNT(*) FROM Products WHERE status = '0'", checkConn)
                    Dim remainingCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                    If remainingCount > 0 AndAlso Not _cancelRequested Then
                        Log("WARNING", "ProductSync3", $"Bu batch'te ürün işlenemedi ama kuyrukta {remainingCount} ürün var. Devam ediliyor...")
                        ' 3 saniye bekle ve devam et
                        System.Threading.Thread.Sleep(3000)
                        Continue While
                    Else
                        hasMoreProducts = False
                        Log("INFO", "ProductSync3", $"Kuyruk boş. Toplam gönderilen: {totalSent} ürün")
                        Exit While
                    End If
                End Using
            End If

            ' API'ye gönder
            Try
                Dim data As New Dictionary(Of String, Object)
                data("products") = bulkProducts

                Log("INFO", "ProductSync3", $"Batch #{batchNumber}: {bulkProducts.Count} ürün gönderiliyor...")

                ' DEBUG: Her ürünün temel bilgilerini logla
                For Each debugItem As Dictionary(Of String, Object) In bulkProducts
                    Dim dCode As String = If(debugItem.ContainsKey("code"), debugItem("code").ToString(), "?")
                    Dim dBrand As String = If(debugItem.ContainsKey("brand"), debugItem("brand").ToString(), "?")
                    Dim dCat1 As String = If(debugItem.ContainsKey("category1"), debugItem("category1").ToString(), "?")
                    Dim dCat2 As String = If(debugItem.ContainsKey("category2"), debugItem("category2").ToString(), "?")
                    Dim dCat3 As String = If(debugItem.ContainsKey("category3"), debugItem("category3").ToString(), "?")
                    Dim dPrice As String = If(debugItem.ContainsKey("price"), debugItem("price").ToString(), "?")
                    Dim dQty As String = If(debugItem.ContainsKey("quantity"), debugItem("quantity").ToString(), "?")
                    Dim dName As String = If(debugItem.ContainsKey("name"), debugItem("name").ToString(), "?")
                    Dim dBarcode As String = If(debugItem.ContainsKey("barcode"), debugItem("barcode").ToString(), "?")
                    Dim dImgCount As Integer = 0
                    If debugItem.ContainsKey("images") AndAlso TypeOf debugItem("images") Is List(Of Dictionary(Of String, Object)) Then
                        dImgCount = DirectCast(debugItem("images"), List(Of Dictionary(Of String, Object))).Count
                    End If
                    Dim dVarCount As Integer = 0
                    If debugItem.ContainsKey("variants") AndAlso TypeOf debugItem("variants") Is List(Of Dictionary(Of String, Object)) Then
                        dVarCount = DirectCast(debugItem("variants"), List(Of Dictionary(Of String, Object))).Count
                    End If
                    Log("DEBUG", "ProductSync3", $"📦 GÖNDERİLEN: code={dCode}, brand={dBrand}, cat1={dCat1}, cat2={dCat2}, cat3={dCat3}, price={dPrice}, qty={dQty}, img={dImgCount}, var={dVarCount}, barcode={dBarcode}, name={dName}")
                Next

                ' ===== GÖNDERİM MODU: API veya PHP seçimine göre =====
                Dim result As String = SendToApi("product/save", data)

                If result.Contains("SUCCESS") OrElse result.Contains("OK") Then
                    Log("SUCCESS", "ProductSync3", $"Batch #{batchNumber} API yanıtı alındı!")
                    Log("DEBUG", "ProductSync3", $"📄 TAM API YANITI: {result}")

                    ' API yanıtını parse et ve her ürünün durumunu kontrol et
                    Dim successCount As Integer = 0
                    Dim failCount As Integer = 0
                    Dim failedProducts As New List(Of String)

                    Try
                        ' JSON yanıtı parse et: {"code":"SUCCESS","result":{"products":[{"id":123,"code":"XXX","status":1},...]}}
                        Dim jsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(result)
                        If jsonResponse IsNot Nothing AndAlso jsonResponse.ContainsKey("result") Then
                            Dim resultObj = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(jsonResponse("result").ToString())
                            If resultObj IsNot Nothing AndAlso resultObj.ContainsKey("products") Then
                                Dim productsArray = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, Object)))(resultObj("products").ToString())
                                If productsArray IsNot Nothing Then
                                    For Each prodResult As Dictionary(Of String, Object) In productsArray
                                        Dim prodCode As String = If(prodResult.ContainsKey("code"), prodResult("code").ToString(), "?")
                                        Dim prodId As Integer = If(prodResult.ContainsKey("id"), Convert.ToInt32(prodResult("id")), 0)
                                        Dim prodStatus As Integer = If(prodResult.ContainsKey("status"), Convert.ToInt32(prodResult("status")), 0)
                                        Dim prodError As String = If(prodResult.ContainsKey("error"), prodResult("error").ToString(), "")
                                        Dim prodMessage As String = If(prodResult.ContainsKey("message"), prodResult("message").ToString(), "")

                                        If prodStatus = 1 AndAlso prodId > 0 Then
                                            successCount += 1
                                            Log("DEBUG", "ProductSync3", $"✅ Ürün kaydedildi: {prodCode} (id={prodId})")
                                        Else
                                            failCount += 1
                                            failedProducts.Add(prodCode)
                                            Log("WARNING", "ProductSync3", $"⚠️ Ürün KAYDEDİLMEDİ: {prodCode} (id={prodId}, status={prodStatus}, error={prodError}, message={prodMessage})")

                                            ' DEBUG: Başarısız ürünün tam JSON'unu dosyaya yaz
                                            Try
                                                Dim failedLogFolder As String = "C:\Eticaret\log"
                                                If Not System.IO.Directory.Exists(failedLogFolder) Then
                                                    System.IO.Directory.CreateDirectory(failedLogFolder)
                                                End If
                                                For Each failedItem As Dictionary(Of String, Object) In bulkProducts
                                                    If failedItem.ContainsKey("code") AndAlso failedItem("code").ToString() = prodCode Then
                                                        Dim failedJson As String = Newtonsoft.Json.JsonConvert.SerializeObject(failedItem, Newtonsoft.Json.Formatting.Indented)
                                                        Dim failedFilePath As String = System.IO.Path.Combine(failedLogFolder, $"failed_product_{prodCode}_{DateTime.Now:yyyyMMdd_HHmmss}.json")
                                                        System.IO.File.WriteAllText(failedFilePath, failedJson)
                                                        Log("DEBUG", "ProductSync3", $"📄 Başarısız ürün JSON'u kaydedildi: {failedFilePath}")
                                                        Exit For
                                                    End If
                                                Next
                                            Catch fileEx As Exception
                                                Log("WARNING", "ProductSync3", $"Başarısız ürün JSON'u kaydedilemedi: {fileEx.Message}")
                                            End Try
                                        End If
                                    Next
                                End If
                            End If
                        End If
                    Catch parseEx As Exception
                        Log("WARNING", "ProductSync3", $"API yanıtı parse edilemedi: {parseEx.Message}")
                    End Try

                    ' Ürün durumlarını güncelle
                    Using conn As New OleDb.OleDbConnection
                        conn.ConnectionString = connection
                        conn.Open()
                        For Each item As Dictionary(Of String, Object) In bulkProducts
                            Dim stockID As String = item("productID").ToString
                            Dim prodCode As String = If(item.ContainsKey("code"), item("code").ToString(), stockID)

                            ' Başarısız ürünleri hatalı işaretle, başarılıları güncelle
                            If failedProducts.Contains(prodCode) Then
                                MarkProductAsError(stockID, "API status=0 döndü - ürün kaydedilemedi")
                            Else
                                Dim update As New OleDb.OleDbCommand
                                update.CommandText = "UPDATE Products SET status = '1', updated_at = ? WHERE productID = ?"
                                update.Parameters.AddWithValue("?", DateTime.Now)
                                update.Parameters.AddWithValue("?", stockID)
                                update.Connection = conn
                                update.ExecuteNonQuery()
                                totalSent += 1
                            End If
                        Next
                    End Using

                    Log("INFO", "ProductSync3", $"Batch #{batchNumber} sonuç: {successCount} başarılı, {failCount} başarısız")

                    ' İlerleme durumunu güncelle
                    Dim remaining As Integer = totalToSend - totalSent
                    Log("INFO", "ProductSync3", $"📊 İlerleme: {totalSent}/{totalToSend} gönderildi, {remaining} kaldı")
                    SafeUpdateUI(Sub() lblDurum.Text = $"Durum: {totalSent}/{totalToSend} gönderildi, {remaining} kaldı")

                    ' Rate limiting - API limiti: 25 istek/dakika
                    ' 60s / 25 = 2.4s minimum, güvenlik için 3 saniye bekliyoruz
                    System.Threading.Thread.Sleep(3000)
                Else
                    ' PRODUCTSAVE008: Zorunlu nitelik alanları eksik
                    ' API yanıtını detaylı logla
                    Log("ERROR", "ProductSync3", $"Batch #{batchNumber} başarısız!")
                    Log("ERROR", "ProductSync3", $"API Yanıtı (TAM): {result}")

                    ' Hatalı ürünlerin detaylarını logla
                    For Each item As Dictionary(Of String, Object) In bulkProducts
                        Dim prodId As String = If(item.ContainsKey("productID"), item("productID").ToString, "?")
                        Dim prodCode As String = If(item.ContainsKey("code"), item("code").ToString, "?")
                        Dim hasAttrs As Boolean = item.ContainsKey("attributes") AndAlso TypeOf item("attributes") Is List(Of Dictionary(Of String, Object)) AndAlso DirectCast(item("attributes"), List(Of Dictionary(Of String, Object))).Count > 0
                        Dim attrCount As Integer = If(hasAttrs, DirectCast(item("attributes"), List(Of Dictionary(Of String, Object))).Count, 0)
                        Log("WARNING", "ProductSync3", $"Hatalı ürün: {prodId}, code={prodCode}, attributes sayısı={attrCount}")

                        MarkProductAsError(prodId, "API hatası: " & If(result.Length > 200, result.Substring(0, 200), result))
                    Next
                    ' 5 saniye bekle ve devam et
                    System.Threading.Thread.Sleep(5000)
                End If

            Catch ex As Exception
                LogError("Error in ProductSync3 API call: " & ex.Message)
                ' Timeout veya bağlantı hatası - ürünleri hatalı olarak işaretle ve devam et
                Log("WARNING", "ProductSync3", $"Batch #{batchNumber} exception - ürünler hatalı işaretleniyor ve devam ediliyor...")
                For Each item As Dictionary(Of String, Object) In bulkProducts
                    MarkProductAsError(item("productID").ToString, "Exception: " & ex.Message)
                Next
                ' 10 saniye bekle ve devam et (timeout sonrası daha uzun bekleme)
                System.Threading.Thread.Sleep(10000)
            End Try
        End While

        If _cancelRequested Then
            Log("INFO", "ProductSync3", $"⏹️ Ürün senkronizasyonu iptal edildi. Gönderilen: {totalSent}/{totalToSend} ürün, {batchNumber} batch")
            SafeUpdateUI(Sub() lblDurum.Text = $"Durum: İptal edildi - {totalSent}/{totalToSend} gönderildi")
        Else
            Log("INFO", "ProductSync3", $"✅ Ürün senkronizasyonu tamamlandı. Toplam: {totalSent}/{totalToSend} ürün, {batchNumber} batch")
            SafeUpdateUI(Sub() lblDurum.Text = $"Durum: Tamamlandı - {totalSent} ürün gönderildi")
        End If
    End Sub

    ' Hatalı ürünü işaretleyen fonksiyon
    Private Sub MarkProductAsError(productID As String, errorMessage As String)
        Try
            Using errConn As New OleDb.OleDbConnection
                errConn.ConnectionString = connection
                errConn.Open()
                Dim errCmd As New OleDb.OleDbCommand("UPDATE Products SET status = '2', error_message = ?, updated_at = ? WHERE productID = ?", errConn)
                errCmd.Parameters.AddWithValue("?", errorMessage)
                errCmd.Parameters.AddWithValue("?", DateTime.Now)
                errCmd.Parameters.AddWithValue("?", productID)
                errCmd.ExecuteNonQuery()
            End Using
            Log("WARNING", "MarkProductAsError", $"Ürün hatalı olarak işaretlendi: {productID} - {errorMessage}")
        Catch ex As Exception
            ' error_message alanı yoksa sadece status güncelle
            Try
                Using errConn As New OleDb.OleDbConnection
                    errConn.ConnectionString = connection
                    errConn.Open()
                    Dim errCmd As New OleDb.OleDbCommand("UPDATE Products SET status = '2', updated_at = ? WHERE productID = ?", errConn)
                    errCmd.Parameters.AddWithValue("?", DateTime.Now)
                    errCmd.Parameters.AddWithValue("?", productID)
                    errCmd.ExecuteNonQuery()
                End Using
            Catch
            End Try
        End Try
    End Sub

    ' Hatalı ürünleri listeleyen fonksiyon
    Private Function GetErrorProducts() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New OleDb.OleDbConnection
                conn.ConnectionString = connection
                conn.Open()
                Dim cmd As New OleDb.OleDbCommand("SELECT productID, error_message, updated_at FROM Products WHERE status = '2' ORDER BY updated_at DESC", conn)
                Dim adapter As New OleDb.OleDbDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        Catch ex As Exception
            ' error_message alanı yoksa sadece productID getir
            Try
                Using conn As New OleDb.OleDbConnection
                    conn.ConnectionString = connection
                    conn.Open()
                    Dim cmd As New OleDb.OleDbCommand("SELECT productID, updated_at FROM Products WHERE status = '2' ORDER BY updated_at DESC", conn)
                    Dim adapter As New OleDb.OleDbDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            Catch
            End Try
        End Try
        Return dt
    End Function

    ' Hatalı ürünleri sıfırlayan fonksiyon (tekrar deneme için)
    Private Sub ResetErrorProducts()
        Try
            Using conn As New OleDb.OleDbConnection
                conn.ConnectionString = connection
                conn.Open()
                Dim cmd As New OleDb.OleDbCommand("UPDATE Products SET status = '0', error_message = '' WHERE status = '2'", conn)
                Dim count As Integer = cmd.ExecuteNonQuery()
                Log("INFO", "ResetErrorProducts", $"{count} hatalı ürün sıfırlandı, tekrar denenecek.")
                MessageBox.Show($"{count} hatalı ürün sıfırlandı ve tekrar denenecek.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        Catch ex As Exception
            Log("ERROR", "ResetErrorProducts", $"Hata: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' tbStok tablosunda olmayan Products kayıtlarını temizler (yetim kayıtları siler)
    ''' productID formatı: sModel__sRenk şeklinde
    ''' </summary>
    Public Sub CleanOrphanProducts()
        Log("INFO", "CleanOrphanProducts", "tbStok'ta olmayan Products kayıtları temizleniyor...")
        Dim deletedCount As Integer = 0
        Dim checkedCount As Integer = 0
        Dim orphanList As New List(Of String)

        Try
            Using conn As New OleDb.OleDbConnection
                conn.ConnectionString = connection
                conn.Open()

                ' Önce tüm Products kayıtlarını al
                Dim selectCmd As New OleDb.OleDbCommand("SELECT productID FROM Products", conn)
                Dim productIds As New List(Of String)

                Using reader As OleDb.OleDbDataReader = selectCmd.ExecuteReader()
                    While reader.Read()
                        productIds.Add(reader("productID").ToString())
                    End While
                End Using

                Log("INFO", "CleanOrphanProducts", $"Toplam {productIds.Count} Products kaydı kontrol edilecek...")

                ' Her productID için tbStok'ta var mı kontrol et
                For Each productId As String In productIds
                    checkedCount += 1

                    ' productID formatı: sModel__sRenk (varyantlı) veya sModel (varyansız)
                    Dim parts() As String = productId.Split(New String() {"__"}, StringSplitOptions.None)
                    If parts.Length < 1 OrElse String.IsNullOrEmpty(parts(0)) Then
                        ' Geçersiz format - sil
                        orphanList.Add(productId)
                        Continue For
                    End If

                    Dim sModel As String = parts(0)
                    Dim sRenk As String = If(parts.Length > 1, parts(1), "")  ' Varyansız ise boş

                    ' tbStok'ta bu sModel ve sRenk kombinasyonu var mı?
                    Dim checkCmd As New OleDb.OleDbCommand(
                        "SELECT COUNT(*) FROM tbStok WHERE sModel = ? AND sRenk = ? AND bWebGoruntule = '1'", conn)
                    checkCmd.Parameters.AddWithValue("?", sModel)
                    checkCmd.Parameters.AddWithValue("?", sRenk)

                    Dim existsCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If existsCount = 0 Then
                        orphanList.Add(productId)
                    End If

                    ' Her 100 kayıtta bir ilerleme göster
                    If checkedCount Mod 100 = 0 Then
                        SafeUpdateUI(Sub() AddLog($"Kontrol ediliyor: {checkedCount}/{productIds.Count}..."))
                    End If
                Next

                ' Yetim kayıtları sil
                If orphanList.Count > 0 Then
                    Log("INFO", "CleanOrphanProducts", $"Silinecek yetim kayıt sayısı: {orphanList.Count}")

                    For Each orphanId As String In orphanList
                        Dim deleteCmd As New OleDb.OleDbCommand("DELETE FROM Products WHERE productID = ?", conn)
                        deleteCmd.Parameters.AddWithValue("?", orphanId)
                        deleteCmd.ExecuteNonQuery()
                        deletedCount += 1
                    Next

                    Log("SUCCESS", "CleanOrphanProducts", $"✅ {deletedCount} yetim kayıt silindi!")
                Else
                    Log("INFO", "CleanOrphanProducts", "Yetim kayıt bulunamadı, tüm Products kayıtları geçerli.")
                End If
            End Using

            ' Sonucu göster
            Dim mesaj As String = $"Kontrol edilen: {checkedCount} kayıt" & vbCrLf &
                                  $"Silinen yetim kayıt: {deletedCount}" & vbCrLf & vbCrLf &
                                  "Yetim kayıtlar = tbStok tablosunda karşılığı olmayan Products kayıtları"

            MessageBox.Show(mesaj, "Temizlik Tamamlandı", MessageBoxButtons.OK,
                           If(deletedCount > 0, MessageBoxIcon.Information, MessageBoxIcon.Information))

        Catch ex As Exception
            LogError($"CleanOrphanProducts hatası: {ex.Message}")
            MessageBox.Show($"Temizlik sırasında hata oluştu: {ex.Message}", "Hata",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Hatalı ürünleri gösteren buton click eventi
    Private Sub btnHataliUrunler_Click(sender As Object, e As EventArgs) Handles btnHataliUrunler.Click
        Dim dt As DataTable = GetErrorProducts()
        If dt.Rows.Count = 0 Then
            MessageBox.Show("Hatalı ürün bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Hatalı ürün listesini göster
        Dim frm As New Form()
        frm.Text = "Hatalı Ürünler (" & dt.Rows.Count & " adet)"
        frm.Size = New Size(700, 500)
        frm.StartPosition = FormStartPosition.CenterParent

        Dim dgv As New DataGridView()
        dgv.Dock = DockStyle.Fill
        dgv.DataSource = dt
        dgv.ReadOnly = True
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.AllowUserToAddRows = False

        Dim btnReset As New Button()
        btnReset.Text = "Hatalı Ürünleri Sıfırla (Tekrar Dene)"
        btnReset.Dock = DockStyle.Bottom
        btnReset.Height = 40
        AddHandler btnReset.Click, Sub()
                                       ResetErrorProducts()
                                       frm.Close()
                                   End Sub

        Dim btnExport As New Button()
        btnExport.Text = "Excel'e Aktar"
        btnExport.Dock = DockStyle.Bottom
        btnExport.Height = 40
        AddHandler btnExport.Click, Sub()
                                        ExportToExcel(dt, "Hatali_Urunler")
                                    End Sub

        frm.Controls.Add(dgv)
        frm.Controls.Add(btnExport)
        frm.Controls.Add(btnReset)

        ' Yetim Kayıtları Temizle butonu
        Dim btnCleanOrphan As New Button()
        btnCleanOrphan.Text = "Yetim Kayıtları Temizle (tbStok'ta olmayanları sil)"
        btnCleanOrphan.Dock = DockStyle.Bottom
        btnCleanOrphan.Height = 40
        btnCleanOrphan.BackColor = Color.LightCoral
        AddHandler btnCleanOrphan.Click, Sub()
                                             Dim onay As DialogResult = MessageBox.Show(
                "Bu işlem tbStok tablosunda karşılığı olmayan TÜM Products kayıtlarını silecektir." & vbCrLf & vbCrLf &
                "Devam etmek istiyor musunuz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)

                                             If onay = DialogResult.Yes Then
                                                 frm.Close()
                                                 CleanOrphanProducts()
                                             End If
                                         End Sub
        frm.Controls.Add(btnCleanOrphan)

        frm.ShowDialog()
    End Sub

    Private Sub btnWebdeOlmayanlar_Click(sender As Object, e As EventArgs) Handles btnWebdeOlmayanlar.Click
        ' Buton disable et (çift tıklama önleme)
        btnWebdeOlmayanlar.Enabled = False

        Try
            ' Kullanıcıya üç seçenek sun
            Dim mesaj As String = "Üç farklı işlem yapabilirsiniz:" & vbCrLf & vbCrLf &
                                  "1. YENİ ÜRÜNLER: Products tablosunda hiç olmayan ürünleri bul ve gönder" & vbCrLf &
                                  "   (Hiç gönderilmemiş ürünler için)" & vbCrLf & vbCrLf &
                                  "2. WEB'DE OLMAYANLAR: Products'ta var ama web'de olmayan ürünleri bul" & vbCrLf &
                                  "   (Varyant barkodu eksik olduğu için web'den silinen ürünler için)" & vbCrLf & vbCrLf &
                                  "3. YETİM KAYITLARI TEMİZLE: tbStok'ta olmayan Products kayıtlarını sil" & vbCrLf &
                                  "   (Silinen veya bWebGoruntule=0 olan ürünlerin artık kayıtları)"

            Dim frmSecim As New Form()
            frmSecim.Text = "İşlem Seçimi"
            frmSecim.Size = New Size(520, 300)
            frmSecim.StartPosition = FormStartPosition.CenterParent
            frmSecim.FormBorderStyle = FormBorderStyle.FixedDialog
            frmSecim.MaximizeBox = False
            frmSecim.MinimizeBox = False

            Dim lblMesaj As New Label()
            lblMesaj.Text = mesaj
            lblMesaj.Location = New Point(20, 20)
            lblMesaj.Size = New Size(470, 150)
            lblMesaj.AutoSize = False

            Dim btnYeniUrunler As New Button()
            btnYeniUrunler.Text = "1. Yeni Ürünler"
            btnYeniUrunler.Location = New Point(20, 180)
            btnYeniUrunler.Size = New Size(150, 40)
            btnYeniUrunler.BackColor = Color.LightBlue
            btnYeniUrunler.DialogResult = DialogResult.Yes

            Dim btnSilinenUrunler As New Button()
            btnSilinenUrunler.Text = "2. Web'de Olmayanlar"
            btnSilinenUrunler.Location = New Point(180, 180)
            btnSilinenUrunler.Size = New Size(150, 40)
            btnSilinenUrunler.BackColor = Color.LightYellow
            btnSilinenUrunler.DialogResult = DialogResult.No

            Dim btnYetimTemizle As New Button()
            btnYetimTemizle.Text = "3. Yetim Temizle"
            btnYetimTemizle.Location = New Point(340, 180)
            btnYetimTemizle.Size = New Size(150, 40)
            btnYetimTemizle.BackColor = Color.LightCoral
            btnYetimTemizle.DialogResult = DialogResult.Retry

            frmSecim.Controls.Add(lblMesaj)
            frmSecim.Controls.Add(btnYeniUrunler)
            frmSecim.Controls.Add(btnSilinenUrunler)
            frmSecim.Controls.Add(btnYetimTemizle)
            frmSecim.AcceptButton = btnYeniUrunler

            Dim sonuc As DialogResult = frmSecim.ShowDialog()

            If sonuc = DialogResult.Yes Then
                ' Yeni ürünler - Products tablosunda hiç olmayan
                Dim eksikSayisi As Integer = GetEksikUrunSayisi()

                If eksikSayisi > 0 Then
                    Dim mesaj2 As String = $"Products tablosunda OLMAYAN {eksikSayisi} adet ürün bulundu." & vbCrLf & vbCrLf &
                                          "Bu ürünler bulunup web'e gönderilecek." & vbCrLf & vbCrLf &
                                          "İşleme devam etmek istiyor musunuz?"

                    Dim cevap As DialogResult = MessageBox.Show(mesaj2, "Yeni Ürünler", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If cevap = DialogResult.Yes Then
                        AddLog("Yeni ürünler kontrol ediliyor...")
                        GonderWebdeOlmayanUrunler()
                    End If
                Else
                    MessageBox.Show("Tüm ürünler zaten Products tablosunda mevcut!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            ElseIf sonuc = DialogResult.No Then
                ' Web'de olmayanlar - Web'de olmayan ama Products'ta var
                Dim onay As DialogResult = MessageBox.Show(
                    "Bu işlem:" & vbCrLf & vbCrLf &
                    "1. Products tablosundaki TÜM ürünleri kontrol eder" & vbCrLf &
                    "2. Her birini web servisinde arar (yavaş olabilir!)" & vbCrLf &
                    "3. Web'de OLMAYAN ürünleri Products'tan SİLER" & vbCrLf &
                    "4. Sonra bu ürünleri tekrar gönderebilirsiniz" & vbCrLf & vbCrLf &
                    "Bu işlem zaman alabilir. Devam etmek istiyor musunuz?",
                    "Web'de Olmayanları Kontrol Et",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning)

                If onay = DialogResult.Yes Then
                    AddLog("Web'de olmayan ürünler kontrol ediliyor...")
                    KontrolEtWebdeOlmayanlar()
                End If

            ElseIf sonuc = DialogResult.Retry Then
                ' Yetim kayıtları temizle - tbStok'ta olmayanları sil
                Dim onay As DialogResult = MessageBox.Show(
                    "Bu işlem:" & vbCrLf & vbCrLf &
                    "• tbStok tablosunda karşılığı OLMAYAN Products kayıtlarını bulur" & vbCrLf &
                    "• Bu kayıtlar silinmiş veya bWebGoruntule=0 yapılmış ürünlerdir" & vbCrLf &
                    "• Bulunan yetim kayıtlar Products tablosundan SİLİNİR" & vbCrLf & vbCrLf &
                    "Bu işlem 'Ürün bulunamadı' hatalarını düzeltir." & vbCrLf & vbCrLf &
                    "Devam etmek istiyor musunuz?",
                    "Yetim Kayıtları Temizle",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning)

                If onay = DialogResult.Yes Then
                    AddLog("Yetim kayıtları temizleniyor...")
                    CleanOrphanProducts()
                End If
            End If

        Catch ex As Exception
            LogError("btnWebdeOlmayanlar_Click hatası: " & ex.Message)
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Butonu tekrar aktif et
            btnWebdeOlmayanlar.Enabled = True
        End Try
    End Sub

    ' Excel'e aktarma fonksiyonu
    Private Sub ExportToExcel(dt As DataTable, fileName As String)
        Try
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "CSV Dosyası|*.csv"
            saveDialog.FileName = fileName & "_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".csv"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Using sw As New System.IO.StreamWriter(saveDialog.FileName, False, System.Text.Encoding.UTF8)
                    ' Başlıklar
                    Dim headers As New List(Of String)
                    For Each col As DataColumn In dt.Columns
                        headers.Add(col.ColumnName)
                    Next
                    sw.WriteLine(String.Join(";", headers))

                    ' Veriler
                    For Each row As DataRow In dt.Rows
                        Dim values As New List(Of String)
                        For Each col As DataColumn In dt.Columns
                            values.Add(row(col).ToString())
                        Next
                        sw.WriteLine(String.Join(";", values))
                    Next
                End Using
                MessageBox.Show("Dosya başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ProductSync4()
        Log("INFO", "ProductSync4", "Ürün senkronizasyonu (4) başlatılıyor.")
        Using conn As New OleDb.OleDbConnection
            Try
                conn.ConnectionString = connection
                conn.Open()
                Log("DEBUG", "ProductSync4", "Veritabanı bağlantısı açıldı.")
                Dim date14 As DateTime = DateTime.Now.AddHours(-14)
                Dim cmd As New OleDb.OleDbCommand
                cmd.CommandText = "SELECT TOP 50 * FROM Products WHERE status = '1' AND updated_at <= ? ORDER BY updated_at ASC"
                cmd.Parameters.AddWithValue("?", date14)
                cmd.Connection = conn
                Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                Dim count As Integer = 0
                While reader.Read()
                    Dim id As String = reader("productID").ToString
                    Dim update As New OleDb.OleDbCommand
                    update.CommandText = "UPDATE Products SET status = '0', updated_at = GETDATE() WHERE productID = ?"
                    update.Parameters.AddWithValue("?", id)
                    update.Connection = conn
                    update.ExecuteNonQuery()
                    count += 1
                End While
                reader.Close()
                Log("INFO", "ProductSync4", $"Ürün senkronizasyonu (4) tamamlandı. Güncellenen ürün sayısı: {count}")
            Catch ex As Exception
                LogError("Error in ProductSync4: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                    Log("DEBUG", "ProductSync4", "Veritabanı bağlantısı kapatıldı.")
                End If
            End Try
        End Using
    End Sub
    Private Sub OrderSync(Optional fetchAllOrders As Boolean = False)
        Log("INFO", "OrderSync", $"Sipariş senkronizasyonu başlatılıyor. Tüm siparişler: {fetchAllOrders}")
        Try
            ' API anahtarlarını kontrol et
            If String.IsNullOrEmpty(ApiKey) OrElse String.IsNullOrEmpty(ApiSecret) Then
                LogError("OrderSync: API anahtarları eksik! ApiKey veya ApiSecret boş.")
                Return
            End If

            ' Status değerleri: 
            ' 0 = Beklemede/Onay Bekliyor, 1 = Yeni/Beklemede, 2 = İşleme Alındı, 3 = Kargoya Verildi, vb.
            ' fetchAllOrders=False: status 0, 1 ve 2 siparişlerini çek
            ' fetchAllOrders=True: Tüm siparişleri tek sorguda çek (status parametresi olmadan)
            Dim statusValues As List(Of String) = New List(Of String)
            If fetchAllOrders Then
                statusValues.Add("") ' Tümü (status parametresi olmadan)
            Else
                ' Sadece Beklemede ve Yeni siparişlerini çek (0 ve 1)
                statusValues.Add("0") ' Beklemede/Onay Bekliyor
                statusValues.Add("1") ' Yeni/Beklemede
                ' status=2 (İşleme Alındı) çekilmiyor - zaten işlenmiş siparişler
            End If

            Dim pageSize As Integer = 100
            Dim maxPages As Integer = 200

            Dim totalProcessed As Integer = 0
            Dim successCount As Integer = 0
            Dim failCount As Integer = 0
            Dim skipCount As Integer = 0
            Dim alreadyProcessedCount As Integer = 0

            Log("DEBUG", "OrderSync", $"Sipariş Status değerleri: {String.Join(", ", statusValues.Select(Function(s) If(String.IsNullOrEmpty(s), "TÜM", s)))} ({If(fetchAllOrders, "Tüm siparişler", "Beklemede + Yeni + İşleme Alındı")})")

            ' Veritabanı bağlantısını aç (tüm işlem boyunca açık kalacak)
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()

                ' ===== HER STATUS İÇİN AYRI AYRI SİPARİŞLERİ ÇEK =====
                For Each statusValue As String In statusValues
                    Dim pageStart As Integer = 0
                    Dim hasMorePages As Boolean = True
                    Dim pageNumber As Integer = 1

                    Log("INFO", "OrderSync", $"📋 Status={If(String.IsNullOrEmpty(statusValue), "TÜM", statusValue)} için siparişler çekiliyor...")

                    ' Bugünün tarihini al (sadece bugünden itibaren siparişleri çek)
                    Dim todayDate As String = DateTime.Now.ToString("yyyy-MM-dd")

                    While hasMorePages AndAlso pageNumber <= maxPages
                        Dim queryParams As String
                        If String.IsNullOrEmpty(statusValue) Then
                            ' Tüm siparişler için status parametresi olmadan (sadece bugünden itibaren)
                            queryParams = $"?pageStart={pageStart}&pageSize={pageSize}&orderBy=id&sort=desc&startDate={todayDate}"
                        Else
                            ' Belirli status için (sadece bugünden itibaren)
                            queryParams = $"?pageStart={pageStart}&pageSize={pageSize}&orderBy=id&sort=desc&status={statusValue}&startDate={todayDate}"
                        End If
                        Log("INFO", "OrderSync", $"📄 Status={If(String.IsNullOrEmpty(statusValue), "TÜM", statusValue)}, Sayfa {pageNumber} çekiliyor: pageStart={pageStart}, pageSize={pageSize}, startDate={todayDate}")

                        ' ===== GÖNDERİM MODU: API veya PHP seçimine göre =====
                        Dim result As String = GetFromApi("order/lists" & queryParams)

                        If String.IsNullOrEmpty(result) Then
                            Log("WARNING", "OrderSync", $"Sayfa {pageNumber}: API'den boş yanıt alındı, sayfalama durduruluyor.")
                            hasMorePages = False
                            Continue While
                        End If

                        ' Bu sayfadaki siparişleri parse et
                        Dim pageOrders As List(Of Dictionary(Of String, Object)) = ParseOrders(result)

                        If pageOrders Is Nothing OrElse pageOrders.Count = 0 Then
                            Log("INFO", "OrderSync", $"Sayfa {pageNumber}: Sipariş bulunamadı, sayfalama tamamlandı.")
                            hasMorePages = False
                        Else
                            Log("INFO", "OrderSync", $"📄 Sayfa {pageNumber}: {pageOrders.Count} sipariş bulundu. İşleniyor...")

                            ' Her sipariş için: detay çek ve HEMEN kaydet
                            For Each orderSummary As Dictionary(Of String, Object) In pageOrders
                                Try
                                    totalProcessed += 1

                                    Dim orderId As String = ""
                                    Dim orderCode As String = ""

                                    If orderSummary.ContainsKey("id") Then
                                        orderId = orderSummary("id").ToString()
                                    End If
                                    If orderSummary.ContainsKey("code") Then
                                        orderCode = orderSummary("code").ToString()
                                    End If

                                    ' Önce bu siparişin zaten işlenip işlenmediğini kontrol et
                                    ' Hem orderID hem de sipariş kodu (TY..., HB...) ile kontrol et
                                    If Not String.IsNullOrEmpty(orderId) AndAlso IsOrderAlreadyProcessed(orderId, conn, orderCode) Then
                                        alreadyProcessedCount += 1
                                        Log("DEBUG", "OrderSync", $"Sipariş zaten işlenmiş, atlanıyor: {orderId} ({orderCode})")
                                        Continue For
                                    End If

                                    If Not String.IsNullOrEmpty(orderId) Then
                                        Log("INFO", "OrderSync", $"🔄 Sipariş işleniyor: {orderId} ({orderCode}) [{totalProcessed}]")

                                        ' Sipariş detayını çek (retry mekanizması ile)
                                        Dim orderDetail As Dictionary(Of String, Object) = FetchOrderDetail(orderId)

                                        If orderDetail IsNot Nothing Then
                                            ' orderSummary'den sipariş kodunu orderDetail'e ekle
                                            If Not String.IsNullOrEmpty(orderCode) Then
                                                If orderDetail.ContainsKey("order") AndAlso orderDetail("order") IsNot Nothing Then
                                                    Dim orderObj As Dictionary(Of String, Object) = AsDict(orderDetail("order"))
                                                    If orderObj IsNot Nothing AndAlso Not orderObj.ContainsKey("code") Then
                                                        orderObj("code") = orderCode
                                                    End If
                                                End If
                                            End If

                                            ' HEMEN KAYDET!
                                            Try
                                                AddOrder(orderDetail)
                                                successCount += 1
                                                Log("SUCCESS", "OrderSync", $"✅ Sipariş kaydedildi: {orderId} ({orderCode}) - Toplam başarılı: {successCount}")
                                            Catch addEx As Exception
                                                failCount += 1
                                                Log("ERROR", "OrderSync", $"❌ Sipariş kaydetme hatası: {orderId} - {addEx.Message}")
                                            End Try
                                        Else
                                            skipCount += 1
                                            Log("WARNING", "OrderSync", $"⚠️ Sipariş detayı alınamadı: {orderId}")
                                        End If

                                        ' API Rate Limiting önlemi
                                        Thread.Sleep(5000)
                                    End If
                                Catch detailEx As Exception
                                    failCount += 1
                                    Log("ERROR", "OrderSync", $"Sipariş işleme hatası: {detailEx.Message}")
                                    Continue For
                                End Try
                            Next

                            ' Sayfa sonuçlarını logla
                            Log("INFO", "OrderSync", $"📊 Status={If(String.IsNullOrEmpty(statusValue), "TÜM", statusValue)}, Sayfa {pageNumber} tamamlandı. Başarılı: {successCount}, Atlanan: {skipCount + alreadyProcessedCount}, Hatalı: {failCount}")

                            ' Sonraki sayfaya geç
                            If pageOrders.Count < pageSize Then
                                hasMorePages = False
                                Log("INFO", "OrderSync", $"Status={If(String.IsNullOrEmpty(statusValue), "TÜM", statusValue)} - Son sayfaya ulaşıldı (sayfa {pageNumber}).")
                            Else
                                pageStart += pageSize
                                pageNumber += 1
                                ' Sayfalama için bekleme
                                Thread.Sleep(2000)
                            End If
                        End If
                    End While

                Next ' For Each statusValue

                conn.Close()
            End Using

            ' Final özet
            Log("INFO", "OrderSync", $"")
            Log("INFO", "OrderSync", $"========== SİPARİŞ SENKRONİZASYONU TAMAMLANDI ==========")
            Log("INFO", "OrderSync", $"📊 Toplam işlenen: {totalProcessed}")
            Log("INFO", "OrderSync", $"✅ Başarıyla kaydedilen: {successCount}")
            Log("INFO", "OrderSync", $"⏭️ Zaten işlenmiş (atlanan): {alreadyProcessedCount}")
            Log("INFO", "OrderSync", $"⚠️ Detay alınamayan: {skipCount}")
            Log("INFO", "OrderSync", $"❌ Hatalı: {failCount}")
            Log("INFO", "OrderSync", $"📋 Sorgulanan status değerleri: {String.Join(", ", statusValues)}")
            Log("INFO", "OrderSync", $"=========================================================")

        Catch ex As Exception
            LogError($"OrderSync Kritik Hata: {ex.Message} - StackTrace: {ex.StackTrace}")
        End Try
    End Sub
    Private Function FetchOrders(Optional fetchAllOrders As Boolean = False) As List(Of Dictionary(Of String, Object))
        Log("INFO", "FetchOrders", $"Siparişler API'den çekiliyor. Tüm siparişler: {fetchAllOrders}")
        Dim orders As New List(Of Dictionary(Of String, Object))
        Try
            ' API anahtarlarının kontrolü
            If String.IsNullOrEmpty(ApiKey) OrElse String.IsNullOrEmpty(ApiSecret) Then
                LogError("FetchOrders: API anahtarları eksik! ApiKey veya ApiSecret boş.")
                Return Nothing
            End If

            ' API dokümantasyonuna göre order/lists endpoint'ini kullan (GET metodu)
            ' Parametreler: pageStart, pageSize, orderBy, sort, status
            ' status=0: Tüm siparişler, status=1: Yeni siparişler (PDF dokümantasyonu)
            Dim statusValue As String = If(fetchAllOrders, "0", "1")
            Dim pageSize As Integer = 100
            Dim pageStart As Integer = 0
            Dim allOrderSummaries As New List(Of Dictionary(Of String, Object))
            Dim hasMorePages As Boolean = True
            Dim pageNumber As Integer = 1
            Dim maxPages As Integer = 200 ' Güvenlik limiti: maksimum 20.000 sipariş (200 sayfa x 100)

            Log("DEBUG", "FetchOrders", $"API Anahtarı: {If(String.IsNullOrEmpty(ApiKey), "BOŞ", "MEVCUT")}")
            Log("DEBUG", "FetchOrders", $"Sipariş Status: {statusValue} ({If(fetchAllOrders, "Tüm siparişler", "Yeni siparişler")})")

            ' ===== SAYFALAMA İLE TÜM SİPARİŞLERİ ÇEK =====
            While hasMorePages AndAlso pageNumber <= maxPages
                Dim queryParams As String = $"?pageStart={pageStart}&pageSize={pageSize}&orderBy=id&sort=desc&status={statusValue}"
                Log("INFO", "FetchOrders", $"📄 Sayfa {pageNumber} çekiliyor: pageStart={pageStart}, pageSize={pageSize}")

                ' ===== GÖNDERİM MODU: API veya PHP seçimine göre =====
                Dim result As String = GetFromApi("order/lists" & queryParams)

                If String.IsNullOrEmpty(result) Then
                    Log("WARNING", "FetchOrders", $"Sayfa {pageNumber}: API'den boş yanıt alındı, sayfalama durduruluyor.")
                    hasMorePages = False
                    Continue While
                End If

                ' Bu sayfadaki siparişleri parse et
                Dim pageOrders As List(Of Dictionary(Of String, Object)) = ParseOrders(result)

                If pageOrders Is Nothing OrElse pageOrders.Count = 0 Then
                    Log("INFO", "FetchOrders", $"Sayfa {pageNumber}: Sipariş bulunamadı, sayfalama tamamlandı.")
                    hasMorePages = False
                Else
                    allOrderSummaries.AddRange(pageOrders)
                    Log("INFO", "FetchOrders", $"📄 Sayfa {pageNumber}: {pageOrders.Count} sipariş çekildi. Toplam: {allOrderSummaries.Count}")

                    ' Eğer bu sayfada pageSize'dan az sipariş varsa, son sayfadayız
                    If pageOrders.Count < pageSize Then
                        hasMorePages = False
                        Log("INFO", "FetchOrders", $"Son sayfaya ulaşıldı (sayfa {pageNumber}, {pageOrders.Count} sipariş).")
                    Else
                        ' Sonraki sayfaya geç
                        pageStart += pageSize
                        pageNumber += 1

                        ' Sayfalama için de bekleme ekle (rate limit önlemi)
                        Thread.Sleep(2000) ' 2 saniye bekle
                    End If
                End If
            End While

            If pageNumber > maxPages Then
                Log("WARNING", "FetchOrders", $"Maksimum sayfa limitine ({maxPages}) ulaşıldı. Toplam: {allOrderSummaries.Count} sipariş.")
            End If

            Log("INFO", "FetchOrders", $"✅ Sayfalama tamamlandı. Toplam {allOrderSummaries.Count} sipariş çekildi ({pageNumber - 1} sayfa).")

            ' JSON parse işlemi
            Try
                orders = allOrderSummaries
                If orders Is Nothing OrElse orders.Count = 0 Then
                    Log("INFO", "FetchOrders", "İşlenecek yeni sipariş bulunamadı.")
                    Return New List(Of Dictionary(Of String, Object))
                End If

                Log("INFO", "FetchOrders", $"Çekilen toplam sipariş sayısı: {orders.Count}")

                ' Her sipariş için detayları çek
                Dim detailedOrders As New List(Of Dictionary(Of String, Object))
                For Each orderSummary As Dictionary(Of String, Object) In orders
                    Try
                        Dim orderId As String = ""
                        If orderSummary.ContainsKey("id") Then
                            orderId = orderSummary("id").ToString()
                        ElseIf orderSummary.ContainsKey("code") Then
                            orderId = orderSummary("code").ToString()
                        End If

                        If Not String.IsNullOrEmpty(orderId) Then
                            Dim orderDetail As Dictionary(Of String, Object) = FetchOrderDetail(orderId)
                            If orderDetail IsNot Nothing Then
                                ' orderSummary'den sipariş kodunu (TY..., HB... gibi) orderDetail'e ekle
                                ' Bu, AddOrder'da doğru prefix'li kodun kullanılmasını sağlar
                                If orderSummary.ContainsKey("code") AndAlso orderSummary("code") IsNot Nothing Then
                                    Dim summaryCode As String = orderSummary("code").ToString().Trim()
                                    If Not String.IsNullOrEmpty(summaryCode) Then
                                        ' orderDetail içinde order objesi varsa, oraya ekle
                                        If orderDetail.ContainsKey("order") AndAlso orderDetail("order") IsNot Nothing Then
                                            Dim orderObj As Dictionary(Of String, Object) = AsDict(orderDetail("order"))
                                            If orderObj IsNot Nothing AndAlso Not orderObj.ContainsKey("code") Then
                                                orderObj("code") = summaryCode
                                                Log("DEBUG", "FetchOrders", $"Sipariş kodunu orderDetail.order'a eklendi: {summaryCode}")
                                            End If
                                        End If
                                    End If
                                End If
                                detailedOrders.Add(orderDetail)
                            Else
                                Log("WARNING", "FetchOrders", $"Sipariş detayı alınamadı: {orderId}")
                            End If

                            ' API Rate Limiting önlemi: Her sipariş detayı çekildikten sonra 5 saniye bekle
                            ' Bu, AUTH004 (Rate Limit) hatasını önler
                            Thread.Sleep(5000)
                        End If
                    Catch detailEx As Exception
                        Log("ERROR", "FetchOrders", $"Sipariş detay hatası: {detailEx.Message}")
                        Continue For
                    End Try
                Next

                orders = detailedOrders

                ' Hatalı barkod kontrolü
                For Each currentOrder As Dictionary(Of String, Object) In orders
                    If currentOrder.ContainsKey("products") AndAlso currentOrder("products") IsNot Nothing Then
                        Dim products As List(Of Dictionary(Of String, Object)) = AsListOfDict(currentOrder("products"))
                        If products IsNot Nothing Then
                            For Each currentProduct As Dictionary(Of String, Object) In products
                                If currentProduct.ContainsKey("barcode") AndAlso currentProduct("barcode") IsNot Nothing AndAlso currentProduct("barcode").ToString().Trim() = "8684053043355" Then
                                    Log("WARNING", "FetchOrders", $"Hatalı barkod (8684053043355) API yanıtında bulundu: orderID={If(currentOrder.ContainsKey("order") AndAlso currentOrder("order") IsNot Nothing AndAlso AsDict(currentOrder("order")).ContainsKey("id"), AsDict(currentOrder("order"))("id"), "Bilinmeyen")}")
                                End If
                            Next
                        End If
                    End If
                Next
            Catch parseEx As Exception
                LogError($"FetchOrders JSON Parse hatası: {parseEx.Message}, StackTrace: {parseEx.StackTrace}")
                Return Nothing
            End Try

        Catch ex As Exception
            LogError("FetchOrders Genel hata: " & ex.Message & ", StackTrace: " & ex.StackTrace)
            Return Nothing
        End Try
        Return orders
    End Function

    ''' <summary>
    ''' Tek bir siparişin detayını API'den çeker (order/show endpoint'i)
    ''' Retry with Exponential Backoff mekanizması ile - AUTH004 hatasında bekleyip tekrar dener
    ''' </summary>
    Private Function FetchOrderDetail(orderId As String) As Dictionary(Of String, Object)
        Log("DEBUG", "FetchOrderDetail", $"Sipariş detayı çekiliyor: {orderId}")

        Const MAX_RETRIES As Integer = 3
        Dim retryDelays As Integer() = {10000, 20000, 30000} ' 10sn, 20sn, 30sn (milisaniye)

        For attempt As Integer = 1 To MAX_RETRIES
            Try
                ' ===== GÖNDERİM MODU: API veya PHP seçimine göre =====
                Dim result As String = GetFromApi("order/show/" & orderId)

                If String.IsNullOrEmpty(result) Then
                    Log("ERROR", "FetchOrderDetail", $"Sipariş detayı boş: {orderId} (Deneme {attempt}/{MAX_RETRIES})")
                    If attempt < MAX_RETRIES Then
                        Log("INFO", "FetchOrderDetail", $"⏳ {retryDelays(attempt - 1) / 1000} saniye bekleniyor...")
                        Thread.Sleep(retryDelays(attempt - 1))
                        Continue For
                    End If
                    Return Nothing
                End If

                ' JSON Parse
                Dim jObj As JObject = JObject.Parse(result)

                ' API hata kontrolü (büyük/küçük harf duyarsız)
                If jObj.ContainsKey("code") Then
                    Dim apiCode As String = jObj("code").ToString().ToUpper()

                    ' AUTH004 veya diğer rate limit hataları için retry
                    If apiCode = "AUTH004" OrElse apiCode.Contains("RATE") OrElse apiCode.Contains("LIMIT") OrElse apiCode.Contains("THROTTLE") Then
                        Log("WARNING", "FetchOrderDetail", $"⚠️ Rate Limit hatası: {apiCode}, orderId={orderId} (Deneme {attempt}/{MAX_RETRIES})")
                        If attempt < MAX_RETRIES Then
                            Log("INFO", "FetchOrderDetail", $"⏳ {retryDelays(attempt - 1) / 1000} saniye bekleniyor ve tekrar denenecek...")
                            Thread.Sleep(retryDelays(attempt - 1))
                            Continue For
                        Else
                            Log("ERROR", "FetchOrderDetail", $"❌ Maksimum deneme sayısına ulaşıldı: {orderId}")
                            Return Nothing
                        End If
                    End If

                    If apiCode <> "SUCCESS" AndAlso apiCode <> "200" AndAlso apiCode <> "OK" Then
                        Log("ERROR", "FetchOrderDetail", $"API Hata Kodu: {apiCode}, orderId={orderId}")
                        Return Nothing
                    End If
                End If

                ' Başarılı - result içindeki order objesini al
                If jObj.ContainsKey("result") AndAlso jObj("result") IsNot Nothing Then
                    Dim resultObj As JToken = jObj("result")
                    If resultObj.Type = JTokenType.Object Then
                        If attempt > 1 Then
                            Log("SUCCESS", "FetchOrderDetail", $"✅ Retry başarılı! orderId={orderId} (Deneme {attempt})")
                        End If
                        Return resultObj.ToObject(Of Dictionary(Of String, Object))()
                    End If
                End If

                ' Direkt order objesi olabilir
                If jObj.ContainsKey("order") Then
                    Dim orderDict As New Dictionary(Of String, Object)
                    orderDict("order") = jObj("order").ToObject(Of Dictionary(Of String, Object))()
                    If jObj.ContainsKey("customer") Then
                        orderDict("customer") = jObj("customer").ToObject(Of Dictionary(Of String, Object))()
                    End If
                    If jObj.ContainsKey("products") Then
                        orderDict("products") = jObj("products").ToObject(Of List(Of Dictionary(Of String, Object)))()
                    End If
                    If jObj.ContainsKey("summary") Then
                        orderDict("summary") = jObj("summary").ToObject(Of Dictionary(Of String, Object))()
                    End If
                    If attempt > 1 Then
                        Log("SUCCESS", "FetchOrderDetail", $"✅ Retry başarılı! orderId={orderId} (Deneme {attempt})")
                    End If
                    Return orderDict
                End If

                Log("WARNING", "FetchOrderDetail", $"Beklenmeyen yanıt formatı: {orderId}")
                Return Nothing

            Catch ex As Exception
                Log("ERROR", "FetchOrderDetail", $"Hata: {ex.Message}, orderId={orderId} (Deneme {attempt}/{MAX_RETRIES})")
                If attempt < MAX_RETRIES Then
                    Log("INFO", "FetchOrderDetail", $"⏳ {retryDelays(attempt - 1) / 1000} saniye bekleniyor...")
                    Thread.Sleep(retryDelays(attempt - 1))
                    Continue For
                End If
                LogError($"FetchOrderDetail hatası: {ex.Message}, orderId={orderId}")
                Return Nothing
            End Try
        Next

        Return Nothing
    End Function
    Private Function ParseOrders(json As String) As List(Of Dictionary(Of String, Object))
        Log("INFO", "ParseOrders", "API yanıtı ayrıştırılıyor.")
        Try
            If String.IsNullOrEmpty(json) Then
                Log("ERROR", "ParseOrders", "Boş JSON string alındı!")
                Return Nothing
            End If

            ' JSON formatını kontrol et
            Dim trimmedJson As String = json.Trim()
            If Not trimmedJson.StartsWith("[") AndAlso Not trimmedJson.StartsWith("{") Then
                Log("ERROR", "ParseOrders", $"Geçersiz JSON formatı. İlk 100 karakter: {If(trimmedJson.Length > 100, trimmedJson.Substring(0, 100), trimmedJson)}")
                Return Nothing
            End If

            Dim orders As New List(Of Dictionary(Of String, Object))

            ' JSON objesini parse et
            Dim jObj As JObject = Nothing
            Dim jArray As JArray = Nothing

            If trimmedJson.StartsWith("{") Then
                jObj = JObject.Parse(json)

                ' API hata kodlarını kontrol et (büyük/küçük harf duyarsız)
                If jObj.ContainsKey("code") Then
                    Dim apiCode As String = jObj("code").ToString().ToUpper()
                    ' Hata kodları: AUTH005, AUTH006, ORDERSHOW001, vs.
                    If apiCode.StartsWith("AUTH") OrElse apiCode.StartsWith("ORDER") OrElse apiCode.StartsWith("ERR") Then
                        If apiCode <> "SUCCESS" AndAlso apiCode <> "OK" Then
                            Log("WARNING", "ParseOrders", $"API Hata/Uyarı Kodu: {apiCode}")
                            ' Boş result durumu - hata değil, sipariş yok demek
                            If jObj.ContainsKey("result") Then
                                Dim resultToken As JToken = jObj("result")
                                If resultToken.Type = JTokenType.Array AndAlso CType(resultToken, JArray).Count = 0 Then
                                    Log("INFO", "ParseOrders", "API boş sipariş listesi döndü (result: [])")
                                    Return New List(Of Dictionary(Of String, Object))
                                End If
                            End If
                            Return New List(Of Dictionary(Of String, Object))
                        End If
                    End If
                End If

                ' API dokümantasyonuna göre result içinde list array var
                ' Format: {"total": 100, "pageSize": 50, "list": [...]}
                If jObj.ContainsKey("result") AndAlso jObj("result") IsNot Nothing Then
                    Dim resultObj As JToken = jObj("result")

                    If resultObj.Type = JTokenType.Object Then
                        Dim resultDict As JObject = CType(resultObj, JObject)
                        If resultDict.ContainsKey("list") AndAlso resultDict("list") IsNot Nothing Then
                            jArray = CType(resultDict("list"), JArray)
                            Log("DEBUG", "ParseOrders", $"result.list içinde {jArray.Count} sipariş bulundu.")
                        Else
                            ' result direkt obje ise (tek sipariş detayı)
                            Dim orderDict As Dictionary(Of String, Object) = resultObj.ToObject(Of Dictionary(Of String, Object))()
                            If orderDict IsNot Nothing Then
                                orders.Add(orderDict)
                            End If
                        End If
                    ElseIf resultObj.Type = JTokenType.Array Then
                        jArray = CType(resultObj, JArray)
                        Log("DEBUG", "ParseOrders", $"result array içinde {jArray.Count} sipariş bulundu.")
                    End If
                ElseIf jObj.ContainsKey("list") AndAlso jObj("list") IsNot Nothing Then
                    ' Direkt list array
                    jArray = CType(jObj("list"), JArray)
                    Log("DEBUG", "ParseOrders", $"list içinde {jArray.Count} sipariş bulundu.")
                ElseIf jObj.ContainsKey("order") Then
                    ' Tek sipariş detayı formatı
                    Dim orderDict As Dictionary(Of String, Object) = jObj.ToObject(Of Dictionary(Of String, Object))()
                    If orderDict IsNot Nothing Then
                        orders.Add(orderDict)
                    End If
                End If
            ElseIf trimmedJson.StartsWith("[") Then
                ' Direkt array formatında
                jArray = JArray.Parse(json)
                Log("DEBUG", "ParseOrders", $"Array formatında {jArray.Count} sipariş bulundu.")
            End If

            ' Array'den siparişleri parse et
            If jArray IsNot Nothing Then
                For Each item As JToken In jArray
                    Try
                        If item.Type = JTokenType.Object Then
                            Dim orderDict As Dictionary(Of String, Object) = item.ToObject(Of Dictionary(Of String, Object))()
                            If orderDict IsNot Nothing Then
                                orders.Add(orderDict)
                            Else
                                Log("WARNING", "ParseOrders", "Bir sipariş objesi null olarak parse edildi, atlanıyor.")
                            End If
                        End If
                    Catch itemEx As Exception
                        Log("ERROR", "ParseOrders", $"Sipariş item parse hatası: {itemEx.Message}")
                        Continue For
                    End Try
                Next
            End If

            Log("DEBUG", "ParseOrders", $"Ayrıştırılan sipariş sayısı: {orders.Count}")
            Return orders
        Catch ex As Exception
            LogError($"ParseOrders kritik hata: {ex.Message}, JSON: {If(json?.Length > 200, json.Substring(0, 200) & "...", json)}, StackTrace: {ex.StackTrace}")
            Return Nothing
        End Try
    End Function
    Private Function Trunc(ByVal s As String, ByVal maxLen As Integer) As String
        If s Is Nothing Then Return ""
        s = s.Trim()
        If s.Length > maxLen Then Return s.Substring(0, maxLen)
        Return s
    End Function

    ''' <summary>
    ''' Urun listesinden barkod okur - birden fazla alan adini dener
    ''' </summary>
    Private Function GetBarcodeFromProduct(ByVal products As List(Of Dictionary(Of String, Object)), ByVal idx As Integer) As String
        If products Is Nothing OrElse idx >= products.Count OrElse products(idx) Is Nothing Then Return "0"

        Dim p As Dictionary(Of String, Object) = products(idx)
        Dim result As String = "0"

        ' barcode
        If p.ContainsKey("barcode") AndAlso p("barcode") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(p("barcode").ToString()) AndAlso p("barcode").ToString().Trim() <> "8684053043355" Then
            result = p("barcode").ToString().Trim()
            ' merchantSku
        ElseIf p.ContainsKey("merchantSku") AndAlso p("merchantSku") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(p("merchantSku").ToString()) Then
            result = p("merchantSku").ToString().Trim()
            ' sku
        ElseIf p.ContainsKey("sku") AndAlso p("sku") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(p("sku").ToString()) Then
            result = p("sku").ToString().Trim()
            ' stockCode
        ElseIf p.ContainsKey("stockCode") AndAlso p("stockCode") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(p("stockCode").ToString()) Then
            result = p("stockCode").ToString().Trim()
            ' productCode
        ElseIf p.ContainsKey("productCode") AndAlso p("productCode") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(p("productCode").ToString()) Then
            result = p("productCode").ToString().Trim()
        End If

        Return result
    End Function

    Private Function ReadBarcode(ByVal p As Dictionary(Of String, Object)) As String
        If p Is Nothing Then Return "0"
        Dim b As String = ""
        If p.ContainsKey("barcode") AndAlso p("barcode") IsNot Nothing Then
            b = Convert.ToString(p("barcode")).Trim()
        End If
        If String.IsNullOrWhiteSpace(b) Then Return "0"
        Return b
    End Function
    Private Function ReadDec(ByVal p As Dictionary(Of String, Object), ByVal key As String) As Decimal
        If p Is Nothing Then Return 0D
        If p.ContainsKey(key) AndAlso p(key) IsNot Nothing Then
            Dim txt As String = Convert.ToString(p(key))
            Dim d As Decimal
            If Decimal.TryParse(txt, d) Then Return d
        End If
        Return 0D
    End Function
    Private Function GetProduct(ByVal products As List(Of Dictionary(Of String, Object)), ByVal idx As Integer) As Dictionary(Of String, Object)
        If products Is Nothing Then Return New Dictionary(Of String, Object)
        If idx >= 0 AndAlso idx < products.Count Then
            Return AsDict(products(idx))
        End If
        Return New Dictionary(Of String, Object)
    End Function
    ''' <summary>
    ''' API'den gelen bozuk Türkçe karakter kodlarını düzeltir
    ''' Örnek: mu{240}la -> muğla, {252}r{252}n -> ürün
    ''' </summary>
    Private Function DecodeApiData(ByVal encodedText As String) As String
        If String.IsNullOrEmpty(encodedText) Then Return encodedText
        Try
            Dim result As String = encodedText.Trim()

            ' Türkçe karakter kodlarını gerçek karakterlere çevir
            result = result.Replace("{199}", "Ç")
            result = result.Replace("{231}", "ç")
            result = result.Replace("{208}", "Ğ")
            result = result.Replace("{240}", "ğ")
            result = result.Replace("{304}", "İ")
            result = result.Replace("{221}", "İ")
            result = result.Replace("{305}", "ı")
            result = result.Replace("{253}", "ı")
            result = result.Replace("{214}", "Ö")
            result = result.Replace("{246}", "ö")
            result = result.Replace("{222}", "Ş")
            result = result.Replace("{351}", "ş")
            result = result.Replace("{254}", "ş")
            result = result.Replace("{220}", "Ü")
            result = result.Replace("{252}", "ü")
            
            ' Azerbaycan karakterleri - SQL Server desteklemediği için Latin karşılıklarına çevir
            result = result.Replace("{601}", "e")  ' ə -> e
            result = result.Replace("{399}", "E")  ' Ə -> E
            result = result.Replace("ə", "e")      ' Doğrudan karakter varsa (UTF-8)
            result = result.Replace("Ə", "E")      ' Büyük harf (UTF-8)
            
            ' Encoding bozulması durumunda oluşabilecek karakterler
            ' UTF-8 ə (U+0259) yanlış yorumlanınca: É™ veya benzer
            result = result.Replace("É™", "e")     ' UTF-8 -> Latin1 bozulması
            result = result.Replace("Æ™", "e")     ' Alternatif bozulma
            result = result.Replace(ChrW(&H259), "e")  ' Unicode code point olarak
            result = result.Replace(ChrW(&H18F), "E")  ' Büyük Ə code point
            
            ' Soru işareti olarak görünen karakterleri düzelt (son çare)
            ' Sadece tek karakter soru işaretleri için (kelime ortasında)
            ' Bu işlem diğer tüm replace'lerden SONRA yapılmalı
            
            Log("DEBUG", "DecodeApiData", $"Girdi: [{encodedText}] -> Çıktı: [{result}]")
            Return result
        Catch ex As Exception
            LogError($"DecodeApiData hatası: {ex.Message}, input={encodedText}")
            Return encodedText
        End Try
    End Function

    ''' <summary>
    ''' PHP functions.php'deki tr_strtoupper fonksiyonunun VB.NET çevirisi
    ''' Türkçe karakterleri doğru şekilde büyük harfe çevirir
    ''' </summary>
    Private Function TrStrToUpper(ByVal text As String) As String
        If String.IsNullOrEmpty(text) Then Return text
        Try
            ' Önce Türkçe karakterleri büyük harflerle değiştir
            text = text.Replace("ç", "Ç")
            text = text.Replace("i", "İ")
            text = text.Replace("ı", "I")
            text = text.Replace("ğ", "Ğ")
            text = text.Replace("ö", "Ö")
            text = text.Replace("ş", "Ş")
            text = text.Replace("ü", "Ü")

            ' Sonra tüm metni büyük harfe çevir (İngilizce karakterler için)
            text = text.ToUpper()

            Return text
        Catch ex As Exception
            LogError($"TrStrToUpper hatası: {ex.Message}, input={text}")
            Return text.ToUpper()
        End Try
    End Function

    ''' <summary>
    ''' PHP functions.php'deki tr_strtolower fonksiyonunun VB.NET çevirisi
    ''' Türkçe karakterleri doğru şekilde küçük harfe çevirir
    ''' </summary>
    Private Function TrStrToLower(ByVal text As String) As String
        If String.IsNullOrEmpty(text) Then Return text
        Try
            ' Önce Türkçe karakterleri küçük harflerle değiştir
            text = text.Replace("Ç", "ç")
            text = text.Replace("İ", "i")
            text = text.Replace("I", "ı")
            text = text.Replace("Ğ", "ğ")
            text = text.Replace("Ö", "ö")
            text = text.Replace("Ş", "ş")
            text = text.Replace("Ü", "ü")

            ' Sonra tüm metni küçük harfe çevir (İngilizce karakterler için)
            text = text.ToLower()

            Return text
        Catch ex As Exception
            LogError($"TrStrToLower hatası: {ex.Message}, input={text}")
            Return text.ToLower()
        End Try
    End Function
    Private Function ToTurkishTitleCase(ByVal input As String) As String
        If String.IsNullOrEmpty(input) Then Return input
        Try
            ' Önce Azerbaycan karakterlerini geçici olarak değiştir (ToLower bozmasın diye)
            Dim processed As String = input
            processed = processed.Replace(ChrW(&H259), "e")  ' ə -> e
            processed = processed.Replace(ChrW(&H18F), "E")  ' Ə -> E
            processed = processed.Replace("ə", "e")
            processed = processed.Replace("Ə", "E")
            
            Dim culture As New CultureInfo("tr-TR")
            Dim words As String() = processed.ToLower(culture).Split(" "c)
            Dim titleWords As New List(Of String)
            For Each word As String In words
                If String.IsNullOrEmpty(word) Then Continue For
                If word.ToLower(culture) = "mahallesi" OrElse word.ToLower(culture) = "sokak" OrElse word.ToLower(culture) = "no:" Then
                    titleWords.Add(word.ToLower(culture))
                Else
                    Dim firstChar As String = If(word.Length > 0, culture.TextInfo.ToUpper(word.Substring(0, 1)), "")
                    Dim rest As String = If(word.Length > 1, word.Substring(1), "")
                    titleWords.Add(firstChar & rest)
                End If
            Next
            Dim result As String = String.Join(" ", titleWords)
            Log("DEBUG", "ToTurkishTitleCase", $"Input={input}, Output={result}")
            Return result
        Catch ex As Exception
            LogError($"ToTurkishTitleCase hatası: {ex.Message}, input={input}")
            Return input
        End Try
    End Function
    Private Function IsOrderAlreadyProcessed(orderID As String, conn As OleDb.OleDbConnection, Optional siparisKodu As String = "") As Boolean
        ' BASİTLEŞTİRİLMİŞ KONTROL - SADECE orders TABLOSU (SQL Server)
        If String.IsNullOrEmpty(orderID) Then
            Log("WARNING", "IsOrderAlreadyProcessed", "orderID boş veya null.")
            Return True ' Güvenli taraf - boş ID varsa işleme
        End If
        Try
            If String.IsNullOrEmpty(KeyCode.sConnection) Then 
                Log("ERROR", "IsOrderAlreadyProcessed", "KeyCode.sConnection BOŞ!")
                Return True ' Bağlantı yoksa güvenli tarafta kal
            End If
            
            Dim sqlConnStr As String = KeyCode.sConnection
            If sqlConnStr.ToLower().Contains("provider=") Then
                Dim parts As String() = sqlConnStr.Split(";"c)
                Dim cleanParts As New List(Of String)
                For Each part As String In parts
                    If Not part.Trim().ToLower().StartsWith("provider=") Then
                        If Not String.IsNullOrWhiteSpace(part) Then cleanParts.Add(part.Trim())
                    End If
                Next
                sqlConnStr = String.Join(";", cleanParts)
            End If
            
            Using sqlConn As New SqlClient.SqlConnection(sqlConnStr)
                sqlConn.Open()
                Log("DEBUG", "IsOrderAlreadyProcessed", $"===== KONTROL BAŞLIYOR =====")
                Log("DEBUG", "IsOrderAlreadyProcessed", $"orderID değeri: [{orderID}]")
                Log("DEBUG", "IsOrderAlreadyProcessed", $"orderID tipi: {orderID.GetType().Name}")
                Log("DEBUG", "IsOrderAlreadyProcessed", $"SQL: SELECT COUNT(*) FROM orders WHERE ID = {orderID} AND status = 1")
                
                ' Status=1 olan kayıtlar başarıyla işlenmiş siparişlerdir
                Using checkCmd As New SqlClient.SqlCommand("SELECT COUNT(*) FROM orders WHERE ID = @orderID AND status = 1", sqlConn)
                    checkCmd.Parameters.AddWithValue("@orderID", orderID)
                    Dim count As Integer = CInt(checkCmd.ExecuteScalar())
                    Log("DEBUG", "IsOrderAlreadyProcessed", $"Sorgu sonucu COUNT: {count}")
                    
                    If count > 0 Then
                        Log("DEBUG", "IsOrderAlreadyProcessed", $"orderID={orderID}, orders tablosunda BULUNDU (status=1) - ATLANIYOR")
                        Return True
                    Else
                        Log("DEBUG", "IsOrderAlreadyProcessed", $"orderID={orderID}, orders tablosunda status=1 BULUNAMADI")
                    End If
                End Using
            End Using

            Log("DEBUG", "IsOrderAlreadyProcessed", $"orderID={orderID}, daha önce işlenmemiş - İŞLENECEK")
            Return False
        Catch ex As Exception
            LogError($"IsOrderAlreadyProcessed HATA: {ex.Message}, orderID={orderID}")
            Return True ' HATA durumunda güvenli tarafta kal - tekrar eklemeyi önle
        End Try
    End Function
    Private Sub LogProcessedOrder(orderID As String, conn As OleDb.OleDbConnection)
        Try
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim insertCmd As New OleDb.OleDbCommand("INSERT INTO tbSiparisLog (orderID, processed_at) SELECT ?, GETDATE() WHERE NOT EXISTS (SELECT 1 FROM tbSiparisLog WHERE orderID = ?)", conn)
            insertCmd.Parameters.AddWithValue("?", orderID)
            insertCmd.Parameters.AddWithValue("?", orderID)
            Dim rowsAffected As Integer = insertCmd.ExecuteNonQuery()
            Log("DEBUG", "LogProcessedOrder", $"Sipariş loglandı: orderID={orderID}, Etkilenen satır: {rowsAffected}")
        Catch ex As Exception
            LogError($"LogProcessedOrder hatası: {ex.Message}, orderID={orderID}, StackTrace: {ex.StackTrace}")
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub
    Private Sub UpdateOrderStatus(orderID As String, conn As OleDb.OleDbConnection, Optional nStokFisiID As Integer = 0, Optional nFirmaID As Integer = 0, Optional sAciklama3 As String = "")
        Try
            ' Orders tablosu SQL Server'da - ayrı bağlantı kullan
            If String.IsNullOrEmpty(KeyCode.sConnection) Then
                Log("WARNING", "UpdateOrderStatus", "SQL Server baglantisi bos, orders tablosu guncellenemedi")
                Return
            End If
            
            ' Önce eksik kolonları kontrol et ve ekle
            EnsureOrdersTableColumns()
            
            ' OleDb connection string'den Provider kısmını kaldır
            Dim sqlConnStr As String = KeyCode.sConnection
            If sqlConnStr.ToLower().Contains("provider=") Then
                Dim parts As String() = sqlConnStr.Split(";"c)
                Dim cleanParts As New List(Of String)
                For Each part As String In parts
                    If Not part.Trim().ToLower().StartsWith("provider=") Then
                        If Not String.IsNullOrWhiteSpace(part) Then
                            cleanParts.Add(part.Trim())
                        End If
                    End If
                Next
                sqlConnStr = String.Join(";", cleanParts)
            End If
            
            Using sqlConn As New SqlClient.SqlConnection(sqlConnStr)
                sqlConn.Open()
                
                ' Orders tablosunu güncelle - nStokFisiID, nFirmaID, sAciklama3 alanlarını da ekle
                Dim updateSql As String = "UPDATE orders SET status = 1, updated_at = GETDATE()"
                If nStokFisiID > 0 Then updateSql &= ", nStokFisiID = @nStokFisiID"
                If nFirmaID > 0 Then updateSql &= ", nFirmaID = @nFirmaID"
                If Not String.IsNullOrEmpty(sAciklama3) Then updateSql &= ", sAciklama3 = @sAciklama3"
                updateSql &= " WHERE ID = @orderID"
                
                Using updateCmd As New SqlClient.SqlCommand(updateSql, sqlConn)
                    updateCmd.Parameters.AddWithValue("@orderID", orderID)
                    If nStokFisiID > 0 Then updateCmd.Parameters.AddWithValue("@nStokFisiID", nStokFisiID)
                    If nFirmaID > 0 Then updateCmd.Parameters.AddWithValue("@nFirmaID", nFirmaID)
                    If Not String.IsNullOrEmpty(sAciklama3) Then updateCmd.Parameters.AddWithValue("@sAciklama3", sAciklama3)
                    
                    Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()
                    Log("DEBUG", "UpdateOrderStatus", $"SQL Server orders guncellendi: orderID={orderID}, nStokFisiID={nStokFisiID}, nFirmaID={nFirmaID}, sAciklama3={sAciklama3}, Etkilenen satir: {rowsAffected}")
                End Using
            End Using
        Catch ex As Exception
            LogError($"UpdateOrderStatus hatasi: {ex.Message}, orderID={orderID}, StackTrace: {ex.StackTrace}")
        End Try
    End Sub
    ''' <summary>
    ''' Web API'ye sipariş durumu güncelleme gönderir (order/updateStatus)
    ''' </summary>
    ''' <param name="orderCode">Sipariş kodu (örn: TY10825278977, HB4305610070)</param>
    ''' <param name="newStatus">Yeni durum: 1=Yeni, 2=Hazırlanıyor, 3=Kargoda, 4=Teslim Edildi, 6=İptal</param>
    ''' <returns>Başarılı ise True</returns>
    Private Function UpdateOrderStatusOnWeb(orderCode As String, newStatus As Integer) As Boolean
        Try
            If String.IsNullOrEmpty(orderCode) Then
                Log("WARNING", "UpdateOrderStatusOnWeb", "Sipariş kodu boş!")
                Return False
            End If

            Log("INFO", "UpdateOrderStatusOnWeb", $"🌐 Web API'ye sipariş durumu gönderiliyor: {orderCode} -> Status: {newStatus}")

            ' API'ye gönderilecek veri
            Dim postData As New Dictionary(Of String, Object)
            postData.Add("code", orderCode)
            postData.Add("status", newStatus)

            ' order/updateStatus endpoint'ine POST isteği
            ' ===== GÖNDERİM MODU: API veya PHP seçimine göre =====
            Dim result As String = SendToApi("order/updateStatus", postData)

            If String.IsNullOrEmpty(result) Then
                Log("WARNING", "UpdateOrderStatusOnWeb", $"API'den boş yanıt: {orderCode}")
                Return False
            End If

            ' API yanıtını kontrol et
            Try
                Dim jObj As JObject = JObject.Parse(result)
                If jObj.ContainsKey("code") Then
                    Dim apiCode As String = jObj("code").ToString().ToUpper()
                    If apiCode = "SUCCESS" OrElse apiCode = "200" OrElse apiCode = "OK" Then
                        Log("SUCCESS", "UpdateOrderStatusOnWeb", $"✅ Sipariş durumu güncellendi: {orderCode} -> Status: {newStatus}")
                        Return True
                    Else
                        Log("WARNING", "UpdateOrderStatusOnWeb", $"API hata kodu: {apiCode}, Sipariş: {orderCode}")
                        Return False
                    End If
                Else
                    ' code alanı yoksa, başarılı kabul et
                    Log("INFO", "UpdateOrderStatusOnWeb", $"API yanıtı (code alanı yok): {result}")
                    Return True
                End If
            Catch parseEx As Exception
                Log("WARNING", "UpdateOrderStatusOnWeb", $"API yanıtı parse edilemedi: {parseEx.Message}")
                Return False
            End Try

        Catch ex As Exception
            LogError($"UpdateOrderStatusOnWeb hatası: {ex.Message}, orderCode={orderCode}, StackTrace: {ex.StackTrace}")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Sipariş kodunun geçerli bir e-ticaret öneki (TY, HB, N11, AM, GG, CS, KY, PT, MH) içerip içermediğini kontrol eder
    ''' </summary>
    ''' <param name="code">Kontrol edilecek sipariş kodu</param>
    ''' <returns>Geçerli önek varsa True, yoksa False</returns>
    Private Function HasValidOrderPrefix(code As String) As Boolean
        If String.IsNullOrEmpty(code) Then Return False

        Dim codeUpper As String = code.ToUpper().Trim()

        ' Bilinen e-ticaret platformu önekleri (PAZ = Pazarama eklendi)
        Dim validPrefixes As String() = {"TY", "HB", "N11", "AM", "GG", "CS", "KY", "PT", "MH", "PAZ"}

        For Each prefix As String In validPrefixes
            If codeUpper.StartsWith(prefix) Then
                Return True
            End If
        Next

        Return False
    End Function


    ''' <summary>
    ''' E-Ticaret sipariş maliyetini hesaplar (lEkmaliyet3 için)
    ''' </summary>
    ''' <param name="orderID">Sipariş numarası (örn: ty(12345), Hb(67890))</param>
    ''' <param name="toplamSatisFiyati">Toplam satış fiyatı (KDV Hariç)</param>
    ''' <param name="conn">Veritabanı bağlantısı</param>
    ''' <returns>Hesaplanan ek maliyet tutarı</returns>
    Private Function HesaplaEkMaliyet(siparisNo As String, toplamSatisFiyati As Decimal, conn As OleDb.OleDbConnection) As Decimal
        Try
            ' Sipariş no önekini belirle (örn: TY10615305025 -> TY)
            Dim siparisOnek As String = ""
            Dim siparisNoUpper As String = siparisNo.ToUpper()

            If siparisNoUpper.StartsWith("TY") Then
                siparisOnek = "ty("
            ElseIf siparisNoUpper.StartsWith("HB") Then
                siparisOnek = "Hb("
            ElseIf siparisNoUpper.StartsWith("N11") Then
                siparisOnek = "n11"
            ElseIf siparisNoUpper.StartsWith("AM") Then
                siparisOnek = "am("
            ElseIf siparisNoUpper.StartsWith("GG") Then
                siparisOnek = "gg("
            ElseIf siparisNoUpper.StartsWith("CS") Then
                siparisOnek = "cs("
            ElseIf siparisNoUpper.StartsWith("KY") Then
                siparisOnek = "ky("
            ElseIf siparisNoUpper.StartsWith("PT") Then
                siparisOnek = "pt("
            ElseIf siparisNoUpper.StartsWith("MH") Then
                siparisOnek = "mh("
            ElseIf siparisNoUpper.StartsWith("PAZ") Then
                siparisOnek = "paz("
            Else
                Log("WARNING", "HesaplaEkMaliyet", $"Bilinmeyen sipariş öneki: {siparisNo} (İlk 2-3 karakter: {If(siparisNo.Length >= 3, siparisNo.Substring(0, 3), siparisNo)})")
                Return 0
            End If

            Log("DEBUG", "HesaplaEkMaliyet", $"Sipariş No: {siparisNo} -> Önek: {siparisOnek}")

            ' Parametreleri veritabanından çek
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim sql As String = "SELECT nKomisyonTipi, nKomisyonOrani, lKomisyonSabitTutar, lKargoSabitBedel, " &
                               "nIadeOperasyonOrani, nPaketlemeOrani, nOdemeIslemUcretiOrani, lOdemeIslemSabitUcret, " &
                               "lDigerMasraf1, lDigerMasraf2 " &
                               "FROM tbParamETicaret WHERE sSiparisNoOnek = ? AND bAktif = 1"

            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("?", siparisOnek)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Parametreleri al
                        Dim komisyonTipi As Integer = Convert.ToInt32(reader("nKomisyonTipi"))
                        Dim komisyonOrani As Decimal = Convert.ToDecimal(reader("nKomisyonOrani"))
                        Dim komisyonSabitTutar As Decimal = Convert.ToDecimal(reader("lKomisyonSabitTutar"))
                        Dim kargoSabitBedel As Decimal = Convert.ToDecimal(reader("lKargoSabitBedel"))
                        Dim iadeOperasyonOrani As Decimal = Convert.ToDecimal(reader("nIadeOperasyonOrani"))
                        Dim paketlemeOrani As Decimal = Convert.ToDecimal(reader("nPaketlemeOrani"))
                        Dim odemeIslemUcretiOrani As Decimal = Convert.ToDecimal(reader("nOdemeIslemUcretiOrani"))
                        Dim odemeIslemSabitUcret As Decimal = Convert.ToDecimal(reader("lOdemeIslemSabitUcret"))
                        Dim digerMasraf1 As Decimal = Convert.ToDecimal(reader("lDigerMasraf1"))
                        Dim digerMasraf2 As Decimal = Convert.ToDecimal(reader("lDigerMasraf2"))

                        ' Hesaplamalar
                        Dim komisyonTutari As Decimal = 0
                        If komisyonTipi = 1 Then
                            ' Yüzde bazlı komisyon
                            komisyonTutari = (toplamSatisFiyati * komisyonOrani) / 100
                        Else
                            ' Sabit tutar
                            komisyonTutari = komisyonSabitTutar
                        End If

                        Dim iadeOperasyonTutari As Decimal = (toplamSatisFiyati * iadeOperasyonOrani) / 100
                        Dim paketlemeTutari As Decimal = (toplamSatisFiyati * paketlemeOrani) / 100
                        Dim odemeIslemTutari As Decimal = odemeIslemSabitUcret + ((toplamSatisFiyati * odemeIslemUcretiOrani) / 100)

                        ' Toplam ek maliyet
                        Dim toplamEkMaliyet As Decimal = komisyonTutari + kargoSabitBedel + iadeOperasyonTutari +
                                                         paketlemeTutari + odemeIslemTutari + digerMasraf1 + digerMasraf2

                        Log("INFO", "HesaplaEkMaliyet", $"Sipariş No: {siparisNo}, Satış: {toplamSatisFiyati}, " &
                            $"Komisyon: {komisyonTutari}, Kargo: {kargoSabitBedel}, İade Op: {iadeOperasyonTutari}, " &
                            $"Paketleme: {paketlemeTutari}, Ödeme: {odemeIslemTutari}, Toplam: {toplamEkMaliyet}")

                        Return toplamEkMaliyet
                    Else
                        Log("WARNING", "HesaplaEkMaliyet", $"Parametre bulunamadı: {siparisOnek}")
                        Return 0
                    End If
                End Using
            End Using
        Catch ex As Exception
            LogError($"HesaplaEkMaliyet hatası: {ex.Message}, Sipariş No: {siparisNo}, StackTrace: {ex.StackTrace}")
            Return 0
        End Try
    End Function

    Private Sub AddOrder(ByVal order As Dictionary(Of String, Object))
        If order Is Nothing Then
            Log("WARNING", "AddOrder", "Sipariş verisi null.")
            Return
        End If

        ' Müşteri bilgilerini al
        Dim cust As Dictionary(Of String, Object) = If(order.ContainsKey("customer") AndAlso order("customer") IsNot Nothing, AsDict(order("customer")), Nothing)

        ' Sipariş bilgilerini al
        Dim orderData As Dictionary(Of String, Object) = If(order.ContainsKey("order") AndAlso order("order") IsNot Nothing, AsDict(order("order")), Nothing)

        ' Ürün listesini al
        Dim products As List(Of Dictionary(Of String, Object)) = If(order.ContainsKey("products") AndAlso order("products") IsNot Nothing, AsListOfDict(order("products")), Nothing)

        ' Sipariş ID'sini belirle
        Dim orderID As String = "Bilinmeyen"
        If orderData IsNot Nothing AndAlso orderData.ContainsKey("id") Then
            orderID = If(orderData("id") IsNot Nothing, orderData("id").ToString(), "Bilinmeyen")
        End If

        ' Sipariş Kodunu belirle (TY..., HB... gibi) - KRİTİK: tekrar işleme kontrolü için
        Dim siparisKodu As String = ""
        If orderData IsNot Nothing AndAlso orderData.ContainsKey("code") AndAlso orderData("code") IsNot Nothing Then
            siparisKodu = orderData("code").ToString().Trim()
        End If
        Log("DEBUG", "AddOrder", $"Sipariş tanımlayıcıları: orderID={orderID}, siparisKodu={siparisKodu}")

        ' Eksik veri kontrolü
        If cust Is Nothing Then
            Log("ERROR", "AddOrder", $"Müşteri bilgisi eksik: orderID={orderID}")
            Return
        End If

        If orderData Is Nothing Then
            Log("ERROR", "AddOrder", $"Sipariş bilgisi eksik: orderID={orderID}")
            Return
        End If

        If products Is Nothing Then
            Log("ERROR", "AddOrder", $"Ürün listesi null: orderID={orderID}")
            Return
        End If

        If products.Count = 0 Then
            Log("WARNING", "AddOrder", $"Ürün listesi boş: orderID={orderID}")
            Return
        End If

        Log("INFO", "AddOrder", $"Sipariş işleniyor: orderID={orderID}, Ürün sayısı: {products.Count}")

        ' ===== DEBUG: Ürün yapısını analiz et =====
        If products.Count > 0 AndAlso products(0) IsNot Nothing Then
            Dim firstProduct As Dictionary(Of String, Object) = products(0)
            Dim keysStr As String = String.Join(", ", firstProduct.Keys.ToArray())
            Log("DEBUG", "AddOrder", $"🔍 İLK ÜRÜN ALANLARI: {keysStr}")

            ' Barkod olabilecek tüm alanları kontrol et
            Dim possibleBarcodeFields As String() = {"barcode", "Barcode", "BARCODE", "merchantSku", "sku", "SKU", "productCode", "code", "stockCode", "barkod", "Barkod"}
            For Each fieldName As String In possibleBarcodeFields
                If firstProduct.ContainsKey(fieldName) AndAlso firstProduct(fieldName) IsNot Nothing Then
                    Log("DEBUG", "AddOrder", $"📦 BARKOD ALANI BULUNDU: {fieldName} = [{firstProduct(fieldName)}]")
                End If
            Next

            ' Tüm ürün alanlarını ve değerlerini logla
            For Each kvp As KeyValuePair(Of String, Object) In firstProduct
                Dim valueStr As String = If(kvp.Value IsNot Nothing, kvp.Value.ToString(), "NULL")
                If valueStr.Length > 100 Then valueStr = valueStr.Substring(0, 100) & "..."
                Log("DEBUG", "AddOrder", $"   {kvp.Key} = [{valueStr}]")
            Next
        End If
        ' ===== DEBUG SON =====

        ' Hatalı barkodları filtrele (8684053043355)
        Dim originalProductCount As Integer = products.Count
        If products IsNot Nothing Then
            products = products.Where(Function(p) p IsNot Nothing AndAlso If(p.ContainsKey("barcode") AndAlso p("barcode") IsNot Nothing, p("barcode").ToString().Trim() <> "8684053043355", True)).ToList()
        End If

        If products.Count <> originalProductCount Then
            Log("WARNING", "AddOrder", $"Hatalı barkodlar filtrelendi: orderID={orderID}, Önceki: {originalProductCount}, Sonraki: {products.Count}")
        End If

        ' Filtreleme sonrası ürün kontrolü
        If products.Count = 0 Then
            Log("WARNING", "AddOrder", $"Filtreleme sonrası ürün kalmadı: orderID={orderID}")
            Return
        End If

        ' Connection string kontrolü
        If String.IsNullOrEmpty(connection) Then
            Log("ERROR", "AddOrder", $"Connection string bos veya null! orderID={orderID}")
            Return
        End If
        Using conn As New OleDb.OleDbConnection(connection)
            Try
                conn.Open()
                If conn.State <> ConnectionState.Open Then
                    Log("ERROR", "AddOrder", "Bağlantı aÇılamadı.")
                    Return
                End If
                ' KRİTİK FIX: Hem orderID hem de siparisKodu ile kontrol et
                ' Bu düzeltme, siparişlerin tekrar tekrar işlenmesini önler
                If IsOrderAlreadyProcessed(orderID, conn, siparisKodu) Then
                    Log("INFO", "AddOrder", $"Sipariş zaten işlenmiş: orderID={orderID}, siparisKodu={siparisKodu}")

                    ' ===== MEVCUT SİPARİŞ İÇİN İHRACAT BİLGİLERİNİ GÜNCELLE =====
                    ' Sipariş daha önce kaydedilmiş olsa bile, yurt dışı ise ihracat bilgilerini güncelle
                    Try
                        ' Ülke bilgisini order parametresinden al
                        Dim ulkeBilgisi As String = "Turkiye"
                        Dim adresBilgisi As String = ""
                        Dim sehirBilgisi As String = ""

                        ' custInvoice
                        If order.ContainsKey("customerInvoice") AndAlso order("customerInvoice") IsNot Nothing Then
                            Dim ci = AsDict(order("customerInvoice"))
                            If ci IsNot Nothing AndAlso ci.ContainsKey("country") AndAlso ci("country") IsNot Nothing Then
                                ulkeBilgisi = Convert.ToString(ci("country"))
                            End If
                        End If
                        ' custDelivery  
                        If order.ContainsKey("customerDelivery") AndAlso order("customerDelivery") IsNot Nothing Then
                            Dim cd = AsDict(order("customerDelivery"))
                            If cd IsNot Nothing Then
                                If cd.ContainsKey("country") AndAlso cd("country") IsNot Nothing AndAlso ulkeBilgisi = "Turkiye" Then
                                    ulkeBilgisi = Convert.ToString(cd("country"))
                                End If
                                If cd.ContainsKey("address1") Then adresBilgisi = Convert.ToString(cd("address1"))
                                If cd.ContainsKey("address2") Then adresBilgisi &= " " & Convert.ToString(cd("address2"))
                                If cd.ContainsKey("city") Then sehirBilgisi = Convert.ToString(cd("city"))
                            End If
                        End If
                        ' cust (zaten yukarıda tanımlı)
                        If cust IsNot Nothing AndAlso cust.ContainsKey("country") AndAlso cust("country") IsNot Nothing AndAlso ulkeBilgisi = "Turkiye" Then
                            ulkeBilgisi = Convert.ToString(cust("country"))
                        End If

                        ulkeBilgisi = If(ToTurkishTitleCase(Trunc(If(DecodeApiData(ulkeBilgisi), "Turkiye"), 20)), "Turkiye")

                        ' Türkiye mi kontrol et
                        Dim turkiyeMiKontrol As Boolean = (ulkeBilgisi.ToUpper(New CultureInfo("tr-TR")) = "TÜRKİYE" OrElse
                                                    ulkeBilgisi.ToUpper(New CultureInfo("tr-TR")) = "TURKIYE" OrElse
                                                    ulkeBilgisi.ToUpper(New CultureInfo("tr-TR")) = "TURKEY" OrElse
                                                    ulkeBilgisi.ToUpper(New CultureInfo("tr-TR")) = "TR")

                        If Not turkiyeMiKontrol Then
                            Log("INFO", "AddOrder", $"🌍 MEVCUT YURT DIŞI SİPARİŞ - İhracat bilgileri güncelleniyor: {ulkeBilgisi}")

                            ' Mevcut siparişin nStokFisiID'sini bul
                            Dim mevcutStokFisiID As Integer = 0
                            Using findCmd As New OleDb.OleDbCommand("SELECT TOP 1 nStokFisiID FROM tbStokFisiMaster WHERE sAciklama3 = ?", conn)
                                findCmd.Parameters.AddWithValue("?", siparisKodu)
                                If conn.State <> ConnectionState.Open Then conn.Open()
                                Dim result = findCmd.ExecuteScalar()
                                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                                    mevcutStokFisiID = Convert.ToInt32(result)
                                End If
                            End Using

                            If mevcutStokFisiID > 0 Then
                                Dim ulkeKoduBilgi As String = GetUlkeKodu(ulkeBilgisi, conn)

                                ' İhracat bilgilerini güncelle
                                Using updateCmd As New OleDb.OleDbCommand()
                                    updateCmd.Connection = conn
                                    updateCmd.CommandText = "UPDATE tbStokFisiMaster SET " &
                                        "bFaturaTipi = 'İhracat Faturası', " &
                                        "sKdvMuafiyetKodu = '301', " &
                                        "sTeslimatAdresi = ?, " &
                                        "sTeslimatSehir = ?, " &
                                        "sTeslimatUlke = ?, " &
                                        "sTeslimatUlkeKodu = ?, " &
                                        "sIncotermsKodu = 'DAP', " &
                                        "nTasimaSekli = 3 " &
                                        "WHERE nStokFisiID = ?"

                                    updateCmd.Parameters.Add("?", OleDbType.VarWChar, 255).Value = If(String.IsNullOrEmpty(adresBilgisi), "", adresBilgisi.Trim())
                                    updateCmd.Parameters.Add("?", OleDbType.VarWChar, 100).Value = If(String.IsNullOrEmpty(sehirBilgisi), "", sehirBilgisi)
                                    updateCmd.Parameters.Add("?", OleDbType.VarWChar, 100).Value = If(String.IsNullOrEmpty(ulkeBilgisi), "", ulkeBilgisi)
                                    updateCmd.Parameters.Add("?", OleDbType.VarWChar, 10).Value = If(String.IsNullOrEmpty(ulkeKoduBilgi), "XX", ulkeKoduBilgi)
                                    updateCmd.Parameters.AddWithValue("?", mevcutStokFisiID)

                                    Dim rowsUpdated As Integer = updateCmd.ExecuteNonQuery()
                                    If rowsUpdated > 0 Then
                                        Log("SUCCESS", "AddOrder", $"✅ MEVCUT SİPARİŞ İHRACAT BİLGİLERİ GÜNCELLENDİ! nStokFisiID: {mevcutStokFisiID}")
                                    Else
                                        Log("WARNING", "AddOrder", $"⚠️ Mevcut sipariş ihracat bilgileri güncellenemedi! nStokFisiID: {mevcutStokFisiID}")
                                    End If
                                End Using
                            Else
                                Log("WARNING", "AddOrder", $"⚠️ Mevcut sipariş için nStokFisiID bulunamadı: {siparisKodu}")
                            End If
                        End If
                    Catch exMevcut As Exception
                        Log("ERROR", "AddOrder", $"❌ Mevcut sipariş ihracat güncelleme hatası: {exMevcut.Message}")
                    End Try
                    ' ===== MEVCUT SİPARİŞ İHRACAT GÜNCELLEME SONU =====

                    Return
                End If
                Dim randStr As String = Guid.NewGuid().ToString()

                ' Orders tablosu SQL Server'da - ayrı bağlantı kullan
                Dim rowsAffectedOrders As Integer = 0
                Try
                    If Not String.IsNullOrEmpty(KeyCode.sConnection) Then
                        Dim sqlConnStr As String = KeyCode.sConnection
                        If sqlConnStr.ToLower().Contains("provider=") Then
                            Dim parts As String() = sqlConnStr.Split(";"c)
                            Dim cleanParts As New List(Of String)
                            For Each part As String In parts
                                If Not part.Trim().ToLower().StartsWith("provider=") Then
                                    If Not String.IsNullOrWhiteSpace(part) Then cleanParts.Add(part.Trim())
                                End If
                            Next
                            sqlConnStr = String.Join(";", cleanParts)
                        End If

                        Using sqlConn As New SqlClient.SqlConnection(sqlConnStr)
                            sqlConn.Open()

                            ' Sipariş zaten varsa UPDATE yap, yoksa INSERT yap
                            Dim orderExists As Integer = 0
                            Using checkCmd As New SqlClient.SqlCommand("SELECT COUNT(*) FROM orders WHERE ID = @orderID", sqlConn)
                                checkCmd.Parameters.AddWithValue("@orderID", orderID)
                                orderExists = CInt(checkCmd.ExecuteScalar())
                            End Using

                            If orderExists > 0 Then
                                Using updateCmd As New SqlClient.SqlCommand("UPDATE orders SET randStr = @randStr, status = 1, updated_at = GETDATE() WHERE ID = @orderID", sqlConn)
                                    updateCmd.Parameters.AddWithValue("@randStr", randStr)
                                    updateCmd.Parameters.AddWithValue("@orderID", orderID)
                                    rowsAffectedOrders = updateCmd.ExecuteNonQuery()
                                    Log("DEBUG", "AddOrder", $"orders tablosunda güncelleme: orderID={orderID}, randStr={randStr}, Etkilenen satır: {rowsAffectedOrders}")
                                End Using
                            Else
                                Using insertCmd As New SqlClient.SqlCommand("INSERT INTO orders (ID, randStr, status, updated_at) VALUES (@orderID, @randStr, 1, GETDATE())", sqlConn)
                                    insertCmd.Parameters.AddWithValue("@orderID", orderID)
                                    insertCmd.Parameters.AddWithValue("@randStr", randStr)
                                    rowsAffectedOrders = insertCmd.ExecuteNonQuery()
                                    Log("DEBUG", "AddOrder", $"orders tablosuna ekleme: orderID={orderID}, randStr={randStr}, Etkilenen satır: {rowsAffectedOrders}")
                                End Using
                            End If
                        End Using
                    End If
                Catch ordersEx As Exception
                    Log("ERROR", "AddOrder", $"Orders tablosu hatası: {ordersEx.Message}")
                End Try
                Dim fisID As String = orderID
                For Each product As Dictionary(Of String, Object) In products
                    If product Is Nothing Then Continue For
                    Dim productID As String = If(product.ContainsKey("code"), If(product("code") IsNot Nothing, product("code").ToString(), "0"), "0")
                    If conn.State = ConnectionState.Closed Then conn.Open()
                    Dim insertFisDetay As New OleDb.OleDbCommand("INSERT INTO fis_detay (fisID, type, productID, updated_at) VALUES (?, 1, ?, GETDATE())", conn)
                    insertFisDetay.Parameters.AddWithValue("?", fisID)
                    insertFisDetay.Parameters.AddWithValue("?", productID)
                    Dim rowsAffectedFisDetay As Integer = insertFisDetay.ExecuteNonQuery()
                    Log("DEBUG", "AddOrder", $"fis_detay tablosuna ekleme: fisID={fisID}, productID={productID}, Etkilenen satır: {rowsAffectedFisDetay}")
                Next

                ' ===== API v2.2.4: customer icindeki delivery objesini al =====
                Dim custDelivery As Dictionary(Of String, Object) = Nothing
                If cust.ContainsKey("delivery") AndAlso cust("delivery") IsNot Nothing Then
                    custDelivery = AsDict(cust("delivery"))
                End If

                ' ===== API v2.2.4: customer icindeki invoice (fatura) objesini al =====
                ' İHRACAT SİPARİŞLERİNDE FATURA BİLGİLERİ KULLANILMALI (teslimat değil)
                Dim custInvoice As Dictionary(Of String, Object) = Nothing
                If cust.ContainsKey("invoice") AndAlso cust("invoice") IsNot Nothing Then
                    custInvoice = AsDict(cust("invoice"))
                    Log("INFO", "AddOrder", $"✓ INVOICE objesi BULUNDU")
                Else
                    Log("WARNING", "AddOrder", $"⚠ INVOICE objesi YOK - delivery kullanılacak")
                End If

                ' DEBUG: Customer objesinin tüm anahtarlarını ve değerlerini logla
                Log("DEBUG", "AddOrder", $"CUSTOMER KEYS: {String.Join(", ", cust.Keys)}")
                Log("DEBUG", "AddOrder", $"CUSTOMER.NAME: [{If(cust.ContainsKey("name"), cust("name"), "N/A")}]")
                Log("DEBUG", "AddOrder", $"CUSTOMER.FIRSTNAME: [{If(cust.ContainsKey("firstName"), cust("firstName"), "N/A")}]")
                Log("DEBUG", "AddOrder", $"CUSTOMER.LASTNAME: [{If(cust.ContainsKey("lastName"), cust("lastName"), "N/A")}]")
                Log("DEBUG", "AddOrder", $"CUSTOMER.TITLE: [{If(cust.ContainsKey("title"), cust("title"), "N/A")}]")
                If custDelivery IsNot Nothing Then
                    Log("DEBUG", "AddOrder", $"DELIVERY KEYS: {String.Join(", ", custDelivery.Keys)}")
                    If custDelivery.ContainsKey("name") Then
                        Log("DEBUG", "AddOrder", $"DELIVERY NAME: {custDelivery("name")}")
                    End If
                End If
                If custInvoice IsNot Nothing Then
                    Log("DEBUG", "AddOrder", $"INVOICE KEYS: {String.Join(", ", custInvoice.Keys)}")
                    If custInvoice.ContainsKey("name") Then
                        Log("DEBUG", "AddOrder", $"INVOICE NAME: {custInvoice("name")}")
                    End If
                End If

                ' DEBUG: customer.title değerini logla
                If cust.ContainsKey("title") AndAlso cust("title") IsNot Nothing Then
                    Log("DEBUG", "AddOrder", $"CUSTOMER.TITLE: [{cust("title")}]")
                End If

                ' ===== TC KIMLIK: API v2.2.4 - "nationalId" alanindan =====
                Dim tc As String = "0"
                If cust.ContainsKey("nationalId") AndAlso cust("nationalId") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(cust("nationalId").ToString()) Then
                    tc = cust("nationalId").ToString().Trim()
                ElseIf cust.ContainsKey("tc") AndAlso cust("tc") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(cust("tc").ToString()) Then
                    tc = cust("tc").ToString().Trim()
                End If
                ' TC bos veya 0 ise varsayilan deger ata (11 adet 1)
                If String.IsNullOrWhiteSpace(tc) OrElse tc = "0" Then
                    tc = "11111111111"
                End If

                ' ===== VERGI NO: API v2.2.4 - "taxId" alanindan =====
                Dim sVergiNo As String = "0"
                If cust.ContainsKey("taxId") AndAlso cust("taxId") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(cust("taxId").ToString()) Then
                    sVergiNo = cust("taxId").ToString().Trim()
                ElseIf cust.ContainsKey("tax_id") AndAlso cust("tax_id") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(cust("tax_id").ToString()) Then
                    sVergiNo = cust("tax_id").ToString().Trim()
                End If
                ' Vergi No bos veya 0 ise varsayilan deger ata (11 adet 1)
                If String.IsNullOrWhiteSpace(sVergiNo) OrElse sVergiNo = "0" Then
                    sVergiNo = "1111111111"
                End If

                ' ===== İSİM: ÖNCELİKLE FATURA BİLGİLERİNDEN AL =====
                ' API v2.2.4'te fatura ismi sırası:
                ' 1. order.invoiceName (root seviyede)
                ' 2. customer.title (fatura unvanı)
                ' 3. customer.invoice.name (nested - genelde boş)
                ' 4. customer.name (fallback - teslimat firması olabilir)
                Dim rawName As String = ""

                ' Önce order root'taki invoiceName'i kontrol et
                If order.ContainsKey("invoiceName") AndAlso order("invoiceName") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(order("invoiceName").ToString()) Then
                    rawName = order("invoiceName").ToString()
                    Log("INFO", "AddOrder", $"🔍 İSİM ORDER.INVOICENAME'DEN ALINDI: [{rawName}]")
                    ' Sonra customer.title kontrol et (fatura unvanı)
                ElseIf cust.ContainsKey("title") AndAlso cust("title") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(cust("title").ToString()) Then
                    rawName = cust("title").ToString()
                    Log("INFO", "AddOrder", $"🔍 İSİM CUSTOMER.TITLE'DAN ALINDI: [{rawName}]")
                    ' Sonra customer.invoice.name kontrol et
                ElseIf custInvoice IsNot Nothing AndAlso custInvoice.ContainsKey("name") AndAlso custInvoice("name") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(custInvoice("name").ToString()) Then
                    rawName = custInvoice("name").ToString()
                    Log("INFO", "AddOrder", $"🔍 İSİM CUSTOMER.INVOICE.NAME'DEN ALINDI: [{rawName}]")
                    ' Son olarak customer.name fallback
                ElseIf cust.ContainsKey("name") AndAlso cust("name") IsNot Nothing Then
                    rawName = cust("name").ToString()
                    Log("INFO", "AddOrder", $"🔍 İSİM CUSTOMER.NAME'DEN ALINDI (FALLBACK): [{rawName}]")
                    rawName = cust("name").ToString()
                    Log("INFO", "AddOrder", $"🔍 İSİM CUSTOMER'DAN ALINDI (customer.name)")
                End If

                ' ===== KRİTİK DEBUG: API'DEN NE GELİYOR? =====
                Log("INFO", "AddOrder", $"🔍 API'DEN GELEN İSİM (RAW): [{rawName}]")

                ' API'den gelen bozuk karakterleri düzelt
                Dim fullName As String = If(rawName IsNot Nothing, DecodeApiData(rawName), "")
                If fullName Is Nothing Then fullName = ""

                Log("INFO", "AddOrder", $"🔍 TEMİZLENMİŞ İSİM: [{fullName}]")
                ' isim ve soyisim ayrımı, Türkçe imla kurallarına uygun
                Dim adi As String = ""
                Dim soyadi As String = ""
                If Not String.IsNullOrEmpty(fullName) AndAlso fullName.Contains(" ") Then
                    Dim spaceIndex As Integer = fullName.IndexOf(" ")
                    Dim tempAdi As String = ToTurkishTitleCase(Trunc(fullName.Substring(0, spaceIndex), 15))
                    Dim tempSoyadi As String = ToTurkishTitleCase(Trunc(fullName.Substring(spaceIndex + 1), 15))
                    adi = If(tempAdi, "")
                    soyadi = If(tempSoyadi, "")
                ElseIf Not String.IsNullOrEmpty(fullName) Then
                    Dim tempAdi As String = ToTurkishTitleCase(Trunc(fullName, 15))
                    adi = If(tempAdi, "")
                    soyadi = ""
                Else
                    adi = ""
                    soyadi = ""
                End If

                ' ===== KRİTİK DEBUG: İŞLENMİŞ İSİM =====
                Log("INFO", "AddOrder", $"🔍 İŞLENMİŞ ADI: [{adi}]")
                Log("INFO", "AddOrder", $"🔍 İŞLENMİŞ SOYADI: [{soyadi}]")
                Log("INFO", "AddOrder", $"🔍 ADI BYTE ARRAY: {String.Join(",", System.Text.Encoding.UTF8.GetBytes(If(adi, "")).Select(Function(b) b.ToString()))}")

                ' ===== ADRES: ÖNCELİKLE FATURA BİLGİLERİNDEN AL =====
                ' API v2.2.4: 1. order.invoiceAddress 2. customer.invoice.address 3. customer.delivery.address
                Dim rawAddress As String = ""
                If order.ContainsKey("invoiceAddress") AndAlso order("invoiceAddress") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(order("invoiceAddress").ToString()) Then
                    rawAddress = Convert.ToString(order("invoiceAddress"))
                    Log("INFO", "AddOrder", $"🔍 ADRES ORDER.INVOICEADDRESS'DEN ALINDI")
                ElseIf custInvoice IsNot Nothing AndAlso custInvoice.ContainsKey("address") AndAlso custInvoice("address") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(custInvoice("address").ToString()) Then
                    rawAddress = Convert.ToString(custInvoice("address"))
                    Log("INFO", "AddOrder", $"🔍 ADRES CUSTOMER.INVOICE.ADDRESS'DEN ALINDI")
                ElseIf custDelivery IsNot Nothing AndAlso custDelivery.ContainsKey("address") AndAlso custDelivery("address") IsNot Nothing Then
                    rawAddress = Convert.ToString(custDelivery("address"))
                ElseIf cust.ContainsKey("address") AndAlso cust("address") IsNot Nothing Then
                    rawAddress = Convert.ToString(cust("address"))
                End If
                rawAddress = If(DecodeApiData(rawAddress), "")
                Dim adres As String = If(ToTurkishTitleCase(Trunc(rawAddress, 60)), "")
                Dim addressParts As String() = adres.Split(" "c)
                For i As Integer = 0 To addressParts.Length - 1
                    If addressParts(i).ToLower() = "mahallesi" OrElse addressParts(i).ToLower() = "sokak" OrElse addressParts(i).ToLower() = "no:" Then
                        addressParts(i) = addressParts(i).ToLower(New CultureInfo("tr-TR"))
                    End If
                Next
                adres = String.Join(" ", addressParts)

                ' ===== ULKE: customer.invoice.country veya customer.delivery.country =====
                Dim rawUlke As String = "Turkiye"
                If custInvoice IsNot Nothing AndAlso custInvoice.ContainsKey("country") AndAlso custInvoice("country") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(custInvoice("country").ToString()) Then
                    rawUlke = Convert.ToString(custInvoice("country"))
                ElseIf custDelivery IsNot Nothing AndAlso custDelivery.ContainsKey("country") AndAlso custDelivery("country") IsNot Nothing Then
                    rawUlke = Convert.ToString(custDelivery("country"))
                ElseIf cust.ContainsKey("country") AndAlso cust("country") IsNot Nothing Then
                    rawUlke = Convert.ToString(cust("country"))
                End If
                Dim ulke As String = If(ToTurkishTitleCase(Trunc(If(DecodeApiData(rawUlke), "Turkiye"), 20)), "Turkiye")

                ' ===== SEHIR: ÖNCELİKLE FATURA BİLGİLERİNDEN AL =====
                ' API v2.2.4: 1. order.invoiceCity 2. customer.invoice.city 3. customer.delivery.city
                Dim cityName As String = ""
                ' API v2.2.4: 1. order.invoiceCity 2. customer.invoice.city 3. customer.delivery.city
                If order.ContainsKey("invoiceCity") AndAlso order("invoiceCity") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(order("invoiceCity").ToString()) Then
                    cityName = order("invoiceCity").ToString().Trim()
                    Log("INFO", "AddOrder", $"🔍 ŞEHİR ORDER.INVOICECITY'DEN ALINDI: [{cityName}]")
                ElseIf custInvoice IsNot Nothing AndAlso custInvoice.ContainsKey("city") AndAlso custInvoice("city") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(custInvoice("city").ToString()) Then
                    cityName = custInvoice("city").ToString().Trim()
                    Log("INFO", "AddOrder", $"🔍 ŞEHİR CUSTOMER.INVOICE.CITY'DEN ALINDI: [{cityName}]")
                ElseIf custDelivery IsNot Nothing AndAlso custDelivery.ContainsKey("city") AndAlso custDelivery("city") IsNot Nothing Then
                    cityName = custDelivery("city").ToString().Trim()
                ElseIf cust.ContainsKey("city_code") AndAlso cust("city_code") IsNot Nothing Then
                    cityName = cust("city_code").ToString().Trim()
                End If

                ' Varsayılan il değerini veritabanından al (İstanbul için plaka 34)
                Dim varsayilanIl As String = GetVarsayilanIl(conn)
                Log("DEBUG", "AddOrder", $"Varsayilan il: {varsayilanIl}")

                ' ===== YABANCI ÜLKE KONTROLÜ =====
                ' Eğer ülke Türkiye değilse, ham şehir adını doğrudan kullan
                ' SP'de otomatik olarak tbUlke ve tbIl tablolarına eklenecek
                Dim turkiyeMi As Boolean = (ulke.ToUpper(New CultureInfo("tr-TR")) = "TÜRKİYE" OrElse
                                            ulke.ToUpper(New CultureInfo("tr-TR")) = "TURKIYE" OrElse
                                            ulke.ToUpper(New CultureInfo("tr-TR")) = "TURKEY" OrElse
                                            ulke.ToUpper(New CultureInfo("tr-TR")) = "TR")

                Dim il As String = ""

                If turkiyeMi Then
                    ' Türkiye ise mevcut mantığı kullan - tbIl tablosunda ara
                    il = If(Not String.IsNullOrEmpty(cityName), GetIlName(cityName, conn), varsayilanIl)

                    ' GetIlName null veya boş döndüyse varsayılanı kullan
                    If String.IsNullOrEmpty(il) Then
                        il = varsayilanIl
                    End If

                    ' İl validasyonu: tbIl tablosunda var mı kontrol et
                    If String.IsNullOrEmpty(il) OrElse il = "Bilinmeyen" OrElse il = "00" Then
                        Log("WARNING", "AddOrder", $"Gecersiz sehir: cityName=[{cityName}], orderID={orderID} - Varsayilan: {varsayilanIl}")
                        il = varsayilanIl
                    Else
                        ' İlin veritabanında gerçekten var olduğunu kontrol et
                        Dim checkIlCmd As New OleDb.OleDbCommand("SELECT COUNT(*) FROM tbIl WHERE sIl = ?", conn)
                        checkIlCmd.Parameters.AddWithValue("?", il)
                        Dim ilExists As Integer = CInt(checkIlCmd.ExecuteScalar())

                        If ilExists = 0 Then
                            Log("WARNING", "AddOrder", $"Il tbIl tablosunda bulunamadi: [{il}], orderID={orderID} - Varsayilan: {varsayilanIl}")
                            il = varsayilanIl
                        End If
                        ' NOT: ToTurkishTitleCase kullanmıyoruz çünkü veritabanındaki değeri aynen kullanmalıyız
                    End If
                    Log("INFO", "AddOrder", $"🇹🇷 TÜRKİYE SİPARİŞİ - İl: [{il}] (tbIl'den alındı)")
                Else
                    ' YABANCI ÜLKE - Ham şehir adını doğrudan kullan, tbIl araması YAPMA
                    ' SP'de otomatik olarak tbUlke ve tbIl tablolarına eklenecek
                    il = If(Not String.IsNullOrEmpty(cityName), ToTurkishTitleCase(cityName.Trim()), "")
                    If String.IsNullOrEmpty(il) Then
                        il = "Bilinmeyen"
                    End If
                    Log("INFO", "AddOrder", $"🌍 YABANCI ÜLKE SİPARİŞİ - Ülke: [{ulke}], Ham Şehir: [{il}] (doğrudan SP'ye gönderilecek)")
                End If

                ' ===== ILCE: ÖNCELİKLE FATURA BİLGİLERİNDEN AL =====
                ' API v2.2.4: 1. order.invoiceDistrict 2. customer.invoice.district 3. customer.delivery.district
                Dim rawIlce As String = ""
                If order.ContainsKey("invoiceDistrict") AndAlso order("invoiceDistrict") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(order("invoiceDistrict").ToString()) Then
                    rawIlce = Convert.ToString(order("invoiceDistrict"))
                    Log("INFO", "AddOrder", $"🔍 İLÇE ORDER.INVOICEDISTRICT'TEN ALINDI: [{rawIlce}]")
                ElseIf custInvoice IsNot Nothing AndAlso custInvoice.ContainsKey("district") AndAlso custInvoice("district") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(custInvoice("district").ToString()) Then
                    rawIlce = Convert.ToString(custInvoice("district"))
                    Log("INFO", "AddOrder", $"🔍 İLÇE CUSTOMER.INVOICE.DISTRICT'TEN ALINDI: [{rawIlce}]")
                ElseIf custDelivery IsNot Nothing AndAlso custDelivery.ContainsKey("district") AndAlso custDelivery("district") IsNot Nothing Then
                    rawIlce = Convert.ToString(custDelivery("district"))
                ElseIf cust.ContainsKey("district") AndAlso cust("district") IsNot Nothing Then
                    rawIlce = Convert.ToString(cust("district"))
                End If
                Dim ilce As String = If(ToTurkishTitleCase(Trunc(If(DecodeApiData(rawIlce), ""), 60)), "")

                Dim postaKodu As String = Trunc(If(cust.ContainsKey("zipcode") AndAlso cust("zipcode") IsNot Nothing, Convert.ToString(cust("zipcode")), ""), 20).Trim()

                ' ===== VERGI DAIRESI: API v2.2.4 - "taxBranch" alanindan =====
                Dim rawVergiDairesi As String = "TC"
                If cust.ContainsKey("taxBranch") AndAlso cust("taxBranch") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(cust("taxBranch").ToString()) Then
                    rawVergiDairesi = cust("taxBranch").ToString()
                ElseIf cust.ContainsKey("tax_branch") AndAlso cust("tax_branch") IsNot Nothing Then
                    rawVergiDairesi = cust("tax_branch").ToString()
                End If
                Dim vergiDairesi As String = If(ToTurkishTitleCase(Trunc(If(DecodeApiData(rawVergiDairesi), "TC"), 60)), "TC")

                ' Vergi No zaten yukarida tanimlandi (sVergiNo), burada tekrar kullaniyoruz
                Dim vergiNo As String = sVergiNo

                ' ===== TELEFON: API v2.2.4 - "phone" alanindan =====
                Dim rawTelefon As String = If(cust.ContainsKey("phone") AndAlso cust("phone") IsNot Nothing, Convert.ToString(cust("phone")), "")
                Dim telefon As String = If(Trunc(If(DecodeApiData(rawTelefon), ""), 60), "")
                Log("INFO", "AddOrder", $"Telefon - API'den gelen: [{rawTelefon}] -> Temizlenmis: [{telefon}]")


                Dim rawEmail As String = If(cust.ContainsKey("email") AndAlso cust("email") IsNot Nothing, Convert.ToString(cust("email")), "")
                Dim eMail As String = If(Trunc(If(DecodeApiData(rawEmail), ""), 60), "")

                ' Ülke ve il bilgilerini de logla
                Log("INFO", "AddOrder", $"Ulke: [{ulke}], Il: [{il}], Ilce: [{ilce}]")

                ' ===== BARKOD OKUMA - GELISTIRILMIS =====
                ' API'den farkli alan isimleriyle gelebilir: barcode, merchantSku, sku, stockCode
                Dim barkod As String = "0"
                If products.Count > 0 AndAlso products(0) IsNot Nothing Then
                    Dim p0 As Dictionary(Of String, Object) = products(0)

                    ' Once standart barcode alanini dene
                    If p0.ContainsKey("barcode") AndAlso p0("barcode") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(p0("barcode").ToString()) Then
                        barkod = p0("barcode").ToString().Trim()
                        Log("DEBUG", "AddOrder", $"Barkod 'barcode' alanindan alindi: [{barkod}]")
                        ' merchantSku dene (Trendyol/Hepsiburada icin yaygin)
                    ElseIf p0.ContainsKey("merchantSku") AndAlso p0("merchantSku") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(p0("merchantSku").ToString()) Then
                        barkod = p0("merchantSku").ToString().Trim()
                        Log("DEBUG", "AddOrder", $"Barkod 'merchantSku' alanindan alindi: [{barkod}]")
                        ' sku dene
                    ElseIf p0.ContainsKey("sku") AndAlso p0("sku") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(p0("sku").ToString()) Then
                        barkod = p0("sku").ToString().Trim()
                        Log("DEBUG", "AddOrder", $"Barkod 'sku' alanindan alindi: [{barkod}]")
                        ' stockCode dene
                    ElseIf p0.ContainsKey("stockCode") AndAlso p0("stockCode") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(p0("stockCode").ToString()) Then
                        barkod = p0("stockCode").ToString().Trim()
                        Log("DEBUG", "AddOrder", $"Barkod 'stockCode' alanindan alindi: [{barkod}]")
                        ' productCode dene
                    ElseIf p0.ContainsKey("productCode") AndAlso p0("productCode") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(p0("productCode").ToString()) Then
                        barkod = p0("productCode").ToString().Trim()
                        Log("DEBUG", "AddOrder", $"Barkod 'productCode' alanindan alindi: [{barkod}]")
                    Else
                        Log("WARNING", "AddOrder", $"HICBIR BARKOD ALANI BULUNAMADI! orderID={orderID}")
                    End If
                End If

                Dim fiyat As Decimal = If(products.Count > 0 AndAlso products(0) IsNot Nothing AndAlso products(0).ContainsKey("price") AndAlso IsNumeric(products(0)("price")), Convert.ToDecimal(products(0)("price")), 0)
                ' Miktar okuma - API'de "quantity" veya "amount" olabilir
                Dim miktar As Decimal = 1
                If products.Count > 0 AndAlso products(0) IsNot Nothing Then
                    If products(0).ContainsKey("quantity") AndAlso IsNumeric(products(0)("quantity")) Then
                        miktar = Convert.ToDecimal(products(0)("quantity"))
                    ElseIf products(0).ContainsKey("amount") AndAlso IsNumeric(products(0)("amount")) Then
                        miktar = Convert.ToDecimal(products(0)("amount"))
                    End If
                End If

                ' ===== BARKOD1-4 OKUMA =====
                Dim barkod1 As String = GetBarcodeFromProduct(products, 1)
                Dim fiyat1 As Decimal = If(products.Count > 1 AndAlso products(1) IsNot Nothing AndAlso products(1).ContainsKey("price") AndAlso IsNumeric(products(1)("price")), Convert.ToDecimal(products(1)("price")), 0)
                ' Miktar1 okuma - quantity veya amount
                Dim miktar1 As Decimal = 1
                If products.Count > 1 AndAlso products(1) IsNot Nothing Then
                    If products(1).ContainsKey("quantity") AndAlso IsNumeric(products(1)("quantity")) Then
                        miktar1 = Convert.ToDecimal(products(1)("quantity"))
                    ElseIf products(1).ContainsKey("amount") AndAlso IsNumeric(products(1)("amount")) Then
                        miktar1 = Convert.ToDecimal(products(1)("amount"))
                    End If
                End If

                Dim barkod2 As String = GetBarcodeFromProduct(products, 2)
                Dim fiyat2 As Decimal = If(products.Count > 2 AndAlso products(2) IsNot Nothing AndAlso products(2).ContainsKey("price") AndAlso IsNumeric(products(2)("price")), Convert.ToDecimal(products(2)("price")), 0)
                ' Miktar2 okuma - quantity veya amount
                Dim miktar2 As Decimal = 1
                If products.Count > 2 AndAlso products(2) IsNot Nothing Then
                    If products(2).ContainsKey("quantity") AndAlso IsNumeric(products(2)("quantity")) Then
                        miktar2 = Convert.ToDecimal(products(2)("quantity"))
                    ElseIf products(2).ContainsKey("amount") AndAlso IsNumeric(products(2)("amount")) Then
                        miktar2 = Convert.ToDecimal(products(2)("amount"))
                    End If
                End If

                Dim barkod3 As String = GetBarcodeFromProduct(products, 3)
                Dim fiyat3 As Decimal = If(products.Count > 3 AndAlso products(3) IsNot Nothing AndAlso products(3).ContainsKey("price") AndAlso IsNumeric(products(3)("price")), Convert.ToDecimal(products(3)("price")), 0)
                ' Miktar3 okuma - quantity veya amount
                Dim miktar3 As Decimal = 1
                If products.Count > 3 AndAlso products(3) IsNot Nothing Then
                    If products(3).ContainsKey("quantity") AndAlso IsNumeric(products(3)("quantity")) Then
                        miktar3 = Convert.ToDecimal(products(3)("quantity"))
                    ElseIf products(3).ContainsKey("amount") AndAlso IsNumeric(products(3)("amount")) Then
                        miktar3 = Convert.ToDecimal(products(3)("amount"))
                    End If
                End If

                Dim barkod4 As String = GetBarcodeFromProduct(products, 4)
                Dim fiyat4 As Decimal = If(products.Count > 4 AndAlso products(4) IsNot Nothing AndAlso products(4).ContainsKey("price") AndAlso IsNumeric(products(4)("price")), Convert.ToDecimal(products(4)("price")), 0)
                ' Miktar4 okuma - quantity veya amount
                Dim miktar4 As Decimal = 1
                If products.Count > 4 AndAlso products(4) IsNot Nothing Then
                    If products(4).ContainsKey("quantity") AndAlso IsNumeric(products(4)("quantity")) Then
                        miktar4 = Convert.ToDecimal(products(4)("quantity"))
                    ElseIf products(4).ContainsKey("amount") AndAlso IsNumeric(products(4)("amount")) Then
                        miktar4 = Convert.ToDecimal(products(4)("amount"))
                    End If
                End If

                Log("DEBUG", "AddOrder", $"Siparis: orderID={orderID}, Urun Sayisi={products.Count}, ilk barkod={barkod}, ikinci barkod={barkod1}")
                If barkod1 = "8684053043355" Then
                    Log("WARNING", "AddOrder", $"ikinci barkod (8684053043355) hala mevcut: orderID={orderID}, Ürün sayısı={products.Count}")
                    barkod1 = "0"
                    fiyat1 = 0
                    miktar1 = 0
                End If
                Dim firmaID As String = If(String.IsNullOrEmpty(tc), "1", tc)

                ' sAciklama2: Müşteri Adı Soyadı, sAciklama3: Sipariş No (örn: TY10825278977, HB4305610070)
                Dim sAciklama2 As String = (If(adi, "") + " " + If(soyadi, "")).Trim()

                ' Sipariş kodunu tekrar kontrol et (TY, HB öneki içeren kod - ek maliyet hesaplaması için gerekli)
                ' NOT: siparisKodu değişkeni fonksiyon başında tanımlandı
                ' Eğer boş veya geçersiz ise, tüm olası alanları kontrol et
                If String.IsNullOrEmpty(siparisKodu) OrElse Not HasValidOrderPrefix(siparisKodu) Then
                    Dim possibleCodeFields As String() = {"code", "order_code", "orderCode", "randStr", "orderNo", "order_no"}

                    For Each fieldName As String In possibleCodeFields
                        If orderData.ContainsKey(fieldName) AndAlso orderData(fieldName) IsNot Nothing Then
                            Dim tempCode As String = orderData(fieldName).ToString().Trim()
                            If HasValidOrderPrefix(tempCode) Then
                                siparisKodu = tempCode
                                Log("DEBUG", "AddOrder", $"Geçerli sipariş kodu bulundu: {tempCode} (alan: {fieldName})")
                                Exit For
                            End If
                        End If
                    Next
                End If

                ' Eğer orderData'dan bulunamazsa, order objesinin dışındaki alanlara bak
                If String.IsNullOrEmpty(siparisKodu) OrElse Not HasValidOrderPrefix(siparisKodu) Then
                    ' order objesinin üst düzeyindeki alanlara da bak (FetchOrders'dan eklenen)
                    If order.ContainsKey("code") AndAlso order("code") IsNot Nothing Then
                        Dim topLevelCode As String = order("code").ToString().Trim()
                        If HasValidOrderPrefix(topLevelCode) Then
                            siparisKodu = topLevelCode
                            Log("DEBUG", "AddOrder", $"Üst düzey sipariş kodu bulundu: {topLevelCode}")
                        End If
                    End If
                End If

                ' Hala bulunamadıysa, orderID'yi kullan (ancak uyarı logla)
                If String.IsNullOrEmpty(siparisKodu) OrElse Not HasValidOrderPrefix(siparisKodu) Then
                    siparisKodu = orderID
                    Log("WARNING", "AddOrder", $"Geçerli prefix'li sipariş kodu bulunamadı. orderID kullanılıyor: {orderID}. Ek maliyet hesaplanamayabilir.")
                End If

                Dim sAciklama3 As String = siparisKodu
                Log("DEBUG", "AddOrder", $"Sipariş Kodu (sAciklama3): {sAciklama3}, orderID: {orderID}")

                ' ===== ÖNCELİKLE WEB API'DE SİPARİŞ DURUMUNU GÜNCELLE =====
                ' Bu işlem veritabanına kaydetmeden ÖNCE yapılır, böylece sipariş tekrar çekilmez
                Try
                    If Not String.IsNullOrEmpty(sAciklama3) AndAlso HasValidOrderPrefix(sAciklama3) Then
                        Log("INFO", "AddOrder", $"🌐 Web API'de sipariş durumu güncelleniyor (ÖNCE): {sAciklama3}")
                        Dim webUpdateSuccess As Boolean = UpdateOrderStatusOnWeb(sAciklama3, 2) ' 2 = Hazırlanıyor
                        If webUpdateSuccess Then
                            Log("SUCCESS", "AddOrder", $"✅ Web API'de sipariş durumu 'Hazırlanıyor' olarak güncellendi: {sAciklama3}")
                        Else
                            Log("WARNING", "AddOrder", $"⚠️ Web API güncellemesi başarısız oldu: {sAciklama3} - Sipariş tekrar çekilebilir!")
                        End If
                    End If
                Catch webPreEx As Exception
                    Log("ERROR", "AddOrder", $"❌ Web API ön güncelleme hatası: {webPreEx.Message}, orderID={orderID}")
                    ' Web hatası sipariş işlemeyi engellemez, devam et
                End Try

                ' ===== WHATSAPP BİLDİRİMİ GÖNDER (SP'DEN BAĞIMSIZ) =====
                ' Bu işlem SP sonucundan bağımsız olarak yapılır
                Try
                    Log("INFO", "AddOrder", $"📱 WhatsApp bildirimi gönderiliyor: {sAciklama3}")

                    ' Toplam tutarı hesapla
                    Dim whatsappTutar As Decimal = (fiyat * miktar) + (fiyat1 * miktar1) + (fiyat2 * miktar2) + (fiyat3 * miktar3) + (fiyat4 * miktar4)

                    ' Ürün detaylarını oluştur - zaten yukarıda alınan barkod değişkenlerini kullan
                    Dim urunDetaylari As New System.Text.StringBuilder()
                    Dim urunSayisi As Integer = 0

                    ' Tüm barkod/miktar çiftlerini kontrol et
                    Dim barkodlar() As String = {barkod, barkod1, barkod2, barkod3, barkod4}
                    Dim miktarlar() As Decimal = {miktar, miktar1, miktar2, miktar3, miktar4}

                    For i As Integer = 0 To 4
                        Dim pBarkod As String = barkodlar(i)
                        Dim pMiktar As Decimal = miktarlar(i)

                        If Not String.IsNullOrEmpty(pBarkod) AndAlso pBarkod <> "0" AndAlso pBarkod <> "8684053043355" Then
                            urunSayisi += 1
                            Log("DEBUG", "AddOrder", $"WhatsApp Ürün {urunSayisi} - Barkod: [{pBarkod}], Miktar: {pMiktar}")

                            ' Veritabanından stok bilgilerini al
                            Dim stokAdi As String = ""
                            Dim stokKodu As String = ""
                            Dim renk As String = ""
                            Dim beden As String = ""
                            Dim kavala As String = ""
                            Dim mevcutEnvanter As Decimal = 0

                            Try
                                ' TEK SORGU - Barkoddan tüm bilgileri çek
                                Dim stokCmd As New OleDb.OleDbCommand()
                                stokCmd.Connection = conn
                                stokCmd.CommandText = "SELECT s.sKodu, s.sAciklama, ISNULL(r.sRenkAdi,'') AS sRenkAdi, " &
                                    "ISNULL(s.sBeden,'') AS sBeden, ISNULL(s.sKavala,'') AS sKavala, " &
                                    "(SELECT ISNULL(SUM(lGirisMiktar1),0) - ISNULL(SUM(lCikisMiktar1),0) FROM tbStokFisiDetayi WHERE nStokID = s.nStokID) AS lMevcut " &
                                    "FROM tbStokBarkodu sb " &
                                    "INNER JOIN tbStok s ON s.nStokID = sb.nStokID " &
                                    "LEFT JOIN tbRenk r ON s.sRenk = r.sRenk " &
                                    "WHERE sb.sBarkod = ?"
                                stokCmd.Parameters.AddWithValue("?", pBarkod)

                                Using stokReader As OleDb.OleDbDataReader = stokCmd.ExecuteReader()
                                    If stokReader.Read() Then
                                        stokKodu = If(Not stokReader.IsDBNull(0), stokReader.GetString(0), "")
                                        stokAdi = If(Not stokReader.IsDBNull(1), stokReader.GetString(1), "")
                                        renk = If(Not stokReader.IsDBNull(2), stokReader.GetString(2), "")
                                        beden = If(Not stokReader.IsDBNull(3), stokReader.GetString(3), "")
                                        kavala = If(Not stokReader.IsDBNull(4), stokReader.GetString(4), "")
                                        mevcutEnvanter = If(Not stokReader.IsDBNull(5), stokReader.GetDecimal(5), 0)
                                        Log("DEBUG", "AddOrder", $"Stok bulundu - Kod: {stokKodu}, Ad: {stokAdi}, Mevcut: {mevcutEnvanter}")
                                    Else
                                        Log("WARNING", "AddOrder", $"Barkod bulunamadı: {pBarkod}")
                                    End If
                                End Using
                            Catch stokEx As Exception
                                Log("ERROR", "AddOrder", $"Stok sorgu hatası: {pBarkod} - {stokEx.Message}")
                            End Try

                            urunDetaylari.AppendLine("")
                            urunDetaylari.AppendLine($"📦 ÜRÜN {urunSayisi}:")
                            urunDetaylari.AppendLine($"   Stok Kodu: {stokKodu}")
                            urunDetaylari.AppendLine($"   Stok Adı: {stokAdi}")
                            If Not String.IsNullOrEmpty(renk) Then urunDetaylari.AppendLine($"   Renk: {renk}")
                            If Not String.IsNullOrEmpty(beden) Then urunDetaylari.AppendLine($"   Beden: {beden}")
                            If Not String.IsNullOrEmpty(kavala) AndAlso kavala.Trim() <> "" Then urunDetaylari.AppendLine($"   Kavala: {kavala}")
                            urunDetaylari.AppendLine($"   Sipariş Adedi: {CInt(pMiktar)}")
                            urunDetaylari.AppendLine($"   Mevcut Stok: {CInt(mevcutEnvanter)}")
                        End If
                    Next

                    ' WhatsApp bildirimi gönder
                    BildirimServisi.ETicaretSiparisWhatsAppBildirimiDetayli(sAciklama3, sAciklama2, whatsappTutar, urunDetaylari.ToString())
                    Log("SUCCESS", "AddOrder", $"✅ WhatsApp bildirimi gönderildi - Sipariş: {sAciklama3}, Müşteri: {sAciklama2}, Tutar: {whatsappTutar.ToString("N2")} TL")
                Catch whatsappEx As Exception
                    Log("ERROR", "AddOrder", $"❌ WhatsApp bildirim hatası: {whatsappEx.Message}, orderID={orderID}")
                    ' WhatsApp hatası sipariş işlemeyi engellemez, devam et
                End Try

                ' E-Ticaret ek maliyet hesaplama (sAciklama3 kullan - örn: TY10615305025)
                Dim toplamSatisFiyati As Decimal = (fiyat * miktar) + (fiyat1 * miktar1) + (fiyat2 * miktar2) + (fiyat3 * miktar3) + (fiyat4 * miktar4)

                ' ===== KARGO BEDELİ KONTROLÜ =====
                ' Eğer "Kargo Ekle" aktif ve toplam tutar minimum tutarın altındaysa
                ' boş bir ürün slotuna kargo stok kodunu ekle
                ' NOT: Ayarlar veritabanından okunuyor (thread-safe)
                Dim kargoEkleAktif As Boolean = False
                Dim kargoMinTutar As Decimal = 500D
                Dim kargoBarkod As String = "KARGO"
                Dim kargoFiyat As Decimal = 0D

                Try
                    ' Kargo ayarlarını VERİTABANINDAN oku (thread-safe)
                    Dim kargoAktifStr As String = AyarOku(conn, "KARGO_EKLE_AKTIF")
                    kargoEkleAktif = (kargoAktifStr = "1")

                    Log("DEBUG", "AddOrder", $"📦 KARGO DEBUG: KARGO_EKLE_AKTIF={kargoAktifStr}, kargoEkleAktif={kargoEkleAktif}")

                    If kargoEkleAktif Then
                        ' Min tutar ve stok kodunu veritabanından oku
                        Dim kargoMinTutarStr As String = AyarOku(conn, "KARGO_MIN_TUTAR")
                        If Not String.IsNullOrEmpty(kargoMinTutarStr) AndAlso IsNumeric(kargoMinTutarStr) Then
                            kargoMinTutar = CDec(kargoMinTutarStr)
                        End If

                        kargoBarkod = AyarOku(conn, "KARGO_STOK_KODU")

                        Log("DEBUG", "AddOrder", $"📦 KARGO DEBUG: MinTutar={kargoMinTutar}, Barkod={kargoBarkod}, ToplamSatis={toplamSatisFiyati}")

                        ' Eğer kargo barkod boş ise hata ver
                        If String.IsNullOrEmpty(kargoBarkod) OrElse kargoBarkod.Trim() = "" Then
                            Log("WARNING", "AddOrder", $"⚠️ Kargo stok kodu boş! Lütfen ayarlardan kargo stok kodunu girin.")
                            kargoEkleAktif = False
                        Else
                            kargoBarkod = kargoBarkod.Trim()

                            ' Kargo fiyatını stok kartından al (Seçili fiyat tipi)
                            Dim kargoFiyatTipi As String = AyarOku(conn, "GONDERIM_FIYAT_TIPI")
                            If String.IsNullOrEmpty(kargoFiyatTipi) Then kargoFiyatTipi = "WEBP"

                            Using kargoCmd As New OleDb.OleDbCommand(
                                "SELECT TOP 1 f.lFiyat FROM tbStokFiyati f " &
                                "INNER JOIN tbStokBarkodu b ON f.nStokID = b.nStokID " &
                                "WHERE b.sBarkod = ? AND f.sFiyatTipi = ?", conn)
                                kargoCmd.Parameters.AddWithValue("?", kargoBarkod)
                                kargoCmd.Parameters.AddWithValue("?", kargoFiyatTipi)
                                Dim result = kargoCmd.ExecuteScalar()
                                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                                    kargoFiyat = CDec(result)
                                End If
                            End Using

                            Log("DEBUG", "AddOrder", $"📦 KARGO DEBUG: FiyatTipi={kargoFiyatTipi}, KargoFiyat={kargoFiyat}")

                            If kargoFiyat = 0 Then
                                Log("WARNING", "AddOrder", $"⚠️ Kargo stoğu ({kargoBarkod}) için {kargoFiyatTipi} fiyatı bulunamadı!")
                            End If
                        End If
                    End If
                Catch ex As Exception
                    kargoEkleAktif = False
                    Log("ERROR", "AddOrder", $"❌ Kargo bilgisi alınamadı: {ex.Message}")
                End Try

                If kargoEkleAktif AndAlso toplamSatisFiyati < kargoMinTutar Then
                    Log("INFO", "AddOrder", $"📦 KARGO KONTROLÜ: Toplam {toplamSatisFiyati:N2} TL < Min {kargoMinTutar:N2} TL - Kargo eklenecek")

                    ' Boş bir ürün slotu bul ve kargo ekle
                    If String.IsNullOrEmpty(barkod1) OrElse barkod1 = "0" Then
                        barkod1 = kargoBarkod
                        fiyat1 = kargoFiyat
                        miktar1 = 1
                        Log("INFO", "AddOrder", $"📦 Kargo slotu 2'ye eklendi: Barkod={kargoBarkod}, Fiyat={kargoFiyat}")
                    ElseIf String.IsNullOrEmpty(barkod2) OrElse barkod2 = "0" Then
                        barkod2 = kargoBarkod
                        fiyat2 = kargoFiyat
                        miktar2 = 1
                        Log("INFO", "AddOrder", $"📦 Kargo slotu 3'e eklendi: Barkod={kargoBarkod}, Fiyat={kargoFiyat}")
                    ElseIf String.IsNullOrEmpty(barkod3) OrElse barkod3 = "0" Then
                        barkod3 = kargoBarkod
                        fiyat3 = kargoFiyat
                        miktar3 = 1
                        Log("INFO", "AddOrder", $"📦 Kargo slotu 4'e eklendi: Barkod={kargoBarkod}, Fiyat={kargoFiyat}")
                    ElseIf String.IsNullOrEmpty(barkod4) OrElse barkod4 = "0" Then
                        barkod4 = kargoBarkod
                        fiyat4 = kargoFiyat
                        miktar4 = 1
                        Log("INFO", "AddOrder", $"📦 Kargo slotu 5'e eklendi: Barkod={kargoBarkod}, Fiyat={kargoFiyat}")
                    Else
                        Log("WARNING", "AddOrder", $"📦 Kargo eklenemedi - tüm ürün slotları dolu!")
                    End If

                    ' Toplam tutarı güncelle
                    toplamSatisFiyati = (fiyat * miktar) + (fiyat1 * miktar1) + (fiyat2 * miktar2) + (fiyat3 * miktar3) + (fiyat4 * miktar4)
                    Log("INFO", "AddOrder", $"📦 Yeni toplam tutar: {toplamSatisFiyati:N2} TL")
                ElseIf kargoEkleAktif Then
                    Log("INFO", "AddOrder", $"📦 KARGO KONTROLÜ: Toplam {toplamSatisFiyati:N2} TL >= Min {kargoMinTutar:N2} TL - Kargo eklenmedi (ücretsiz kargo)")
                End If

                Dim ekMaliyet3 As Decimal = HesaplaEkMaliyet(sAciklama3, toplamSatisFiyati, conn)

                ' Eğer ekMaliyet3 boş veya negatifse 0.00 yap
                If ekMaliyet3 < 0 Then
                    ekMaliyet3 = 0.00D
                    Log("WARNING", "AddOrder", $"Ek maliyet negatif olduğu için 0.00 olarak ayarlandı")
                End If

                Log("INFO", "AddOrder", $"E-Ticaret Maliyet Hesaplama - Sipariş No (sAciklama3): {sAciklama3}, Toplam Satış: {toplamSatisFiyati}, Ek Maliyet: {ekMaliyet3}")
                Log("INFO", "AddOrder", $"Müşteri (sAciklama2): {sAciklama2}")

                ' ===== STORED PROCEDURE'E GÖNDERİLECEK TÜM PARAMETRELERİ LOGLA =====
                Log("INFO", "AddOrder", $"📋 SP Parametreleri -> TC:[{firmaID}], Ad:[{adi}], Soyad:[{soyadi}], Adres:[{adres}]")
                Log("INFO", "AddOrder", $"📋 SP Parametreleri -> Ülke:[{ulke}], İl:[{il}], İlçe:[{ilce}], Posta:[{postaKodu}]")
                Log("INFO", "AddOrder", $"📋 SP Parametreleri -> Telefon:[{telefon}], Email:[{eMail}], VergiNo:[{vergiNo}]")

                Dim sql As String = "EXEC dbo.Satis_Kaydet ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?"
                Using cmd As New OleDb.OleDbCommand(sql, conn)
                    ' TÜRKÇE KARAKTER DESTEĞİ İÇİN VarWChar (Unicode) KULLAN!
                    cmd.Parameters.Add("?", OleDbType.VarWChar, 60).Value = firmaID
                    cmd.Parameters.Add("?", OleDbType.VarWChar, 60).Value = If(String.IsNullOrEmpty(sVergiNo), "0", sVergiNo)
                    cmd.Parameters.Add("?", OleDbType.VarWChar, 15).Value = If(String.IsNullOrEmpty(adi), "", adi)
                    cmd.Parameters.Add("?", OleDbType.VarWChar, 15).Value = If(String.IsNullOrEmpty(soyadi), "", soyadi)
                    cmd.Parameters.Add("?", OleDbType.VarWChar, 60).Value = If(String.IsNullOrEmpty(adres), "", adres)
                    cmd.Parameters.Add("?", OleDbType.VarWChar, 20).Value = If(String.IsNullOrEmpty(ulke), "Türkiye", ulke)
                    cmd.Parameters.Add("?", OleDbType.VarWChar, 20).Value = If(String.IsNullOrEmpty(il), "Istanbul", il)
                    cmd.Parameters.Add("?", OleDbType.VarWChar, 60).Value = If(String.IsNullOrEmpty(ilce), "", ilce)
                    cmd.Parameters.Add("?", OleDbType.VarWChar, 20).Value = If(String.IsNullOrEmpty(postaKodu), "", postaKodu)
                    cmd.Parameters.Add("?", OleDbType.VarWChar, 60).Value = If(String.IsNullOrEmpty(vergiDairesi), "TC", vergiDairesi)
                    cmd.Parameters.Add("?", OleDbType.VarWChar, 60).Value = If(String.IsNullOrEmpty(vergiNo), "0", vergiNo)
                    cmd.Parameters.Add("?", OleDbType.VarWChar, 60).Value = If(String.IsNullOrEmpty(telefon), "", telefon)
                    cmd.Parameters.Add("?", OleDbType.VarWChar, 60).Value = If(String.IsNullOrEmpty(eMail), "", eMail)
                    cmd.Parameters.Add("?", OleDbType.VarWChar, 20).Value = If(String.IsNullOrEmpty(barkod), "0", barkod)

                    ' Fiyat ve Miktar parametreleri - NUMERIC için Precision ve Scale belirtilmeli
                    Dim paramFiyat As OleDbParameter = cmd.Parameters.Add("?", OleDbType.Numeric)
                    paramFiyat.Precision = 18
                    paramFiyat.Scale = 2
                    paramFiyat.Value = fiyat

                    Dim paramMiktar As OleDbParameter = cmd.Parameters.Add("?", OleDbType.Numeric)
                    paramMiktar.Precision = 14
                    paramMiktar.Scale = 0
                    paramMiktar.Value = miktar

                    cmd.Parameters.Add("?", OleDbType.VarWChar, 20).Value = If(String.IsNullOrEmpty(barkod1), "0", barkod1)

                    Dim paramFiyat1 As OleDbParameter = cmd.Parameters.Add("?", OleDbType.Numeric)
                    paramFiyat1.Precision = 18
                    paramFiyat1.Scale = 2
                    paramFiyat1.Value = fiyat1

                    Dim paramMiktar1 As OleDbParameter = cmd.Parameters.Add("?", OleDbType.Numeric)
                    paramMiktar1.Precision = 14
                    paramMiktar1.Scale = 0
                    paramMiktar1.Value = miktar1

                    cmd.Parameters.Add("?", OleDbType.VarWChar, 20).Value = If(String.IsNullOrEmpty(barkod2), "0", barkod2)

                    Dim paramFiyat2 As OleDbParameter = cmd.Parameters.Add("?", OleDbType.Numeric)
                    paramFiyat2.Precision = 18
                    paramFiyat2.Scale = 2
                    paramFiyat2.Value = fiyat2

                    Dim paramMiktar2 As OleDbParameter = cmd.Parameters.Add("?", OleDbType.Numeric)
                    paramMiktar2.Precision = 14
                    paramMiktar2.Scale = 0
                    paramMiktar2.Value = miktar2

                    cmd.Parameters.Add("?", OleDbType.VarWChar, 20).Value = If(String.IsNullOrEmpty(barkod3), "0", barkod3)

                    Dim paramFiyat3 As OleDbParameter = cmd.Parameters.Add("?", OleDbType.Numeric)
                    paramFiyat3.Precision = 18
                    paramFiyat3.Scale = 2
                    paramFiyat3.Value = fiyat3

                    Dim paramMiktar3 As OleDbParameter = cmd.Parameters.Add("?", OleDbType.Numeric)
                    paramMiktar3.Precision = 14
                    paramMiktar3.Scale = 0
                    paramMiktar3.Value = miktar3

                    cmd.Parameters.Add("?", OleDbType.VarWChar, 20).Value = If(String.IsNullOrEmpty(barkod4), "0", barkod4)

                    Dim paramFiyat4 As OleDbParameter = cmd.Parameters.Add("?", OleDbType.Numeric)
                    paramFiyat4.Precision = 18
                    paramFiyat4.Scale = 2
                    paramFiyat4.Value = fiyat4

                    Dim paramMiktar4 As OleDbParameter = cmd.Parameters.Add("?", OleDbType.Numeric)
                    paramMiktar4.Precision = 14
                    paramMiktar4.Scale = 0
                    paramMiktar4.Value = miktar4

                    ' Ek Maliyet - NUMERIC(18,2) - Precision ve Scale belirtilmeli
                    Dim paramEkMaliyet As OleDbParameter = cmd.Parameters.Add("?", OleDbType.Numeric)
                    paramEkMaliyet.Precision = 18
                    paramEkMaliyet.Scale = 2
                    paramEkMaliyet.Value = If(ekMaliyet3 > 0, ekMaliyet3, 0.00D)

                    cmd.Parameters.Add("?", OleDbType.VarWChar, 255).Value = If(String.IsNullOrEmpty(sAciklama2), "", sAciklama2)
                    cmd.Parameters.Add("?", OleDbType.VarWChar, 255).Value = If(String.IsNullOrEmpty(sAciklama3), "", sAciklama3)

                    ' ===== DETAYLI LOG SİSTEMİ - BAŞLANGIÇ =====
                    Log("INFO", "AddOrder", $"========== SİPARİŞ KAYDETME İŞLEMİ BAŞLIYOR ==========")
                    Log("DEBUG", "AddOrder", $"OrderID: {orderID}")
                    Log("DEBUG", "AddOrder", $"FirmaID: {firmaID}, TC: {tc}, VergiNo: {sVergiNo}")
                    Log("DEBUG", "AddOrder", $"Müşteri: {adi} {soyadi}")
                    Log("DEBUG", "AddOrder", $"Adres: {adres}")
                    Log("DEBUG", "AddOrder", $"Şehir: {il}, İlçe: {ilce}, PostaKodu: {postaKodu}")
                    Log("DEBUG", "AddOrder", $"Telefon: {telefon}, Email: {eMail}")
                    Log("DEBUG", "AddOrder", $"ÜRÜN 1: Barkod={barkod}, Fiyat={fiyat}, Miktar={miktar}")
                    Log("DEBUG", "AddOrder", $"ÜRÜN 2: Barkod={barkod1}, Fiyat={fiyat1}, Miktar={miktar1}")
                    Log("DEBUG", "AddOrder", $"ÜRÜN 3: Barkod={barkod2}, Fiyat={fiyat2}, Miktar={miktar2}")
                    Log("DEBUG", "AddOrder", $"ÜRÜN 4: Barkod={barkod3}, Fiyat={fiyat3}, Miktar={miktar3}")
                    Log("DEBUG", "AddOrder", $"ÜRÜN 5: Barkod={barkod4}, Fiyat={fiyat4}, Miktar={miktar4}")
                    Log("DEBUG", "AddOrder", $"Ek Maliyet: {ekMaliyet3}")
                    Log("DEBUG", "AddOrder", $"sAciklama2: {sAciklama2}")
                    Log("DEBUG", "AddOrder", $"sAciklama3: {sAciklama3}")
                    Log("INFO", "AddOrder", $"Toplam Parametre Sayısı: {cmd.Parameters.Count}")

                    Try
                        Log("INFO", "AddOrder", $"🔄 Stored Procedure çalıştırılıyor: dbo.Satis_Kaydet")
                        Log("DEBUG", "AddOrder", $"SQL Command: {sql}")
                        Log("DEBUG", "AddOrder", $"CommandType: {cmd.CommandType}")
                        Log("DEBUG", "AddOrder", $"CommandText: {cmd.CommandText}")

                        ' Parametreleri de logla (ilk 5 parametre)
                        For i As Integer = 0 To Math.Min(4, cmd.Parameters.Count - 1)
                            Log("DEBUG", "AddOrder", $"Param[{i}]: {cmd.Parameters(i).Value}")
                        Next
                        Log("DEBUG", "AddOrder", $"... ve {cmd.Parameters.Count - 5} parametre daha")

                        ' ExecuteNonQuery öncesi bağlantı durumunu kontrol et
                        If conn.State <> ConnectionState.Open Then
                            Log("ERROR", "AddOrder", "⚠️ Bağlantı kapalı, yeniden açılıyor...")
                            conn.Open()
                        End If

                        Log("DEBUG", "AddOrder", $"Bağlantı Durumu: {conn.State}")

                        ' Stored Procedure'ü çalıştır
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        Dim bugunTarihi As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                        Log("INFO", "AddOrder", $"✅ Stored Procedure tamamlandı. Etkilenen satır sayısı: {rowsAffected}")
                        Log("INFO", "AddOrder", $"📅 Kayıt Tarihi: {bugunTarihi} (BUGÜN)")

                        ' Stored Procedure sonucunu detaylı kontrol et
                        If rowsAffected > 0 Then
                            Log("SUCCESS", "AddOrder", $"✅ Sipariş başarıyla kaydedildi: orderID={orderID}")

                            ' tbStokFisiMaster ve tbStokFisiDetayi tablolarını kontrol et
                            Dim masterCount As Integer = 0
                            Dim detayCount As Integer = 0
                            Dim realStokFisiID As Integer = 0
                            Dim realFirmaID As Integer = 0

                            Try
                                ' Master tablosunu kontrol et (sAciklama3 kullanarak - sipariş kodu)
                                ' NOT: SP kendi nStokFisiID oluşturur, orderID ile kontrol YANLIŞ!
                                ' tbStokFisiAciklamasi tablosunda sAciklama3 alanında sipariş kodu saklanıyor
                                Dim checkMasterCmd As New OleDb.OleDbCommand(
                                    "SELECT COUNT(*) FROM tbStokFisiMaster M INNER JOIN tbStokFisiAciklamasi A ON M.nStokFisiID = A.nStokFisiID WHERE A.sAciklama3 LIKE ?", conn)
                                checkMasterCmd.Parameters.AddWithValue("?", sAciklama3)
                                masterCount = CInt(checkMasterCmd.ExecuteScalar())

                                If masterCount > 0 Then
                                    ' Kayıt tarihini de göster (BUGÜNÜN kayıtlarını kontrol et)
                                    Try
                                        ' Son eklenen kaydı al (BUGÜN)
                                        Dim getDateCmd As New OleDb.OleDbCommand(
                                            "SELECT TOP 1 nStokFisiID, CONVERT(VARCHAR(10), dteFisTarihi, 120) AS FisTarihi, " &
                                            "CONVERT(VARCHAR(19), dteKayitTarihi, 120) AS KayitTarihi " &
                                            "FROM tbStokFisiMaster " &
                                            "WHERE CONVERT(DATE, dteKayitTarihi) = CONVERT(DATE, GETDATE()) " &
                                            "ORDER BY dteKayitTarihi DESC", conn)
                                        ' NOT: nStokFisiID yerine bugünün kayıtlarından en son eklenen

                                        Using reader As OleDb.OleDbDataReader = getDateCmd.ExecuteReader()
                                            If reader.Read() Then
                                                Dim yeniStokFisiID As String = If(reader("nStokFisiID") IsNot DBNull.Value, reader("nStokFisiID").ToString(), "?")
                                                Dim fisTarihi As String = If(reader("FisTarihi") IsNot DBNull.Value, reader("FisTarihi").ToString(), "BİLİNMİYOR")
                                                Dim kayitTarihi As String = If(reader("KayitTarihi") IsNot DBNull.Value, reader("KayitTarihi").ToString(), "BİLİNMİYOR")
                                                Log("SUCCESS", "AddOrder", $"✅ tbStokFisiMaster'a BUGÜN kayıt eklendi: nStokFisiID={yeniStokFisiID}")
                                                Log("SUCCESS", "AddOrder", $"📅 FİŞ TARİHİ: {fisTarihi} | KAYIT ZAMANI: {kayitTarihi} (BUGÜN)")
                                            Else
                                                Log("SUCCESS", "AddOrder", $"✅ tbStokFisiMaster'a kayıt eklendi: {masterCount} adet (Tarih bilgisi alınamadı)")
                                            End If
                                        End Using
                                    Catch dateEx As Exception
                                        Log("SUCCESS", "AddOrder", $"✅ tbStokFisiMaster'a kayıt eklendi: {masterCount} adet (Tarih alınamadı)")
                                    End Try
                                Else
                                    Log("ERROR", "AddOrder", $"❌ tbStokFisiMaster'a kayıt EKLENMEDI! OrderID: {orderID}")
                                End If

                                ' Detay tablosunu kontrol et (Master'dan nStokFisiID al)
                                ' NOT: Detay için önce Master'dan gerçek nStokFisiID'yi bul
                                ' tbStokFisiAciklamasi tablosunda sAciklama3 alanında sipariş kodu saklanıyor
                                Try
                                    Dim getIdCmd As New OleDb.OleDbCommand(
                                        "SELECT TOP 1 M.nStokFisiID FROM tbStokFisiMaster M INNER JOIN tbStokFisiAciklamasi A ON M.nStokFisiID = A.nStokFisiID WHERE A.sAciklama3 LIKE ? ORDER BY M.nStokFisiID DESC", conn)
                                    getIdCmd.Parameters.AddWithValue("?", sAciklama3)
                                    Dim result = getIdCmd.ExecuteScalar()
                                    If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                                        realStokFisiID = CInt(result)
                                    End If
                                Catch
                                End Try

                                Dim checkDetayCmd As New OleDb.OleDbCommand(
                                    "SELECT COUNT(*) FROM tbStokFisiDetayi WHERE nStokFisiID = ?", conn)
                                checkDetayCmd.Parameters.AddWithValue("?", realStokFisiID)
                                detayCount = CInt(checkDetayCmd.ExecuteScalar())

                                If detayCount > 0 Then
                                    Log("SUCCESS", "AddOrder", $"✅ tbStokFisiDetayi'ye kayıt eklendi: {detayCount} adet")
                                Else
                                    Log("ERROR", "AddOrder", $"❌ tbStokFisiDetayi'ye kayıt EKLENMEDI! OrderID: {orderID}")
                                End If

                                Log("INFO", "AddOrder", $"📊 Tablo Kontrol Sonucu: Master={masterCount}, Detay={detayCount}")

                                ' nFirmaID'yi al
                                Try
                                    Dim getFirmaCmd As New OleDb.OleDbCommand(
                                        "SELECT TOP 1 M.nFirmaID FROM tbStokFisiMaster M INNER JOIN tbStokFisiAciklamasi A ON M.nStokFisiID = A.nStokFisiID WHERE A.sAciklama3 LIKE ? ORDER BY M.nStokFisiID DESC", conn)
                                    getFirmaCmd.Parameters.AddWithValue("?", sAciklama3)
                                    Dim firmaResult = getFirmaCmd.ExecuteScalar()
                                    If firmaResult IsNot Nothing AndAlso firmaResult IsNot DBNull.Value Then
                                        realFirmaID = CInt(firmaResult)
                                    End If
                                Catch
                                End Try

                            Catch checkEx As Exception
                                LogError($"Tablo kontrol hatası: {checkEx.Message}")
                            End Try

                            ' Orders tablosunu güncelle - nStokFisiID, nFirmaID, sAciklama3 ile
                            UpdateOrderStatus(orderID, conn, realStokFisiID, realFirmaID, sAciklama3)

                            ' ===== YURT DIŞI SİPARİŞ İÇİN İHRACAT BİLGİLERİNİ GÜNCELLE =====
                            ' Eğer ülke Türkiye değilse, tbStokFisiMaster tablosundaki ihracat alanlarını doldur
                            If Not turkiyeMi AndAlso realStokFisiID > 0 Then
                                Try
                                    Log("INFO", "AddOrder", $"🌍 YURT DIŞI SİPARİŞ TESPİT EDİLDİ - İhracat bilgileri güncelleniyor...")
                                    Log("INFO", "AddOrder", $"📦 nStokFisiID: {realStokFisiID}, Ülke: {ulke}, Şehir: {il}")

                                    ' Ülke kodunu ISO 3166-1 alpha-2 formatına dönüştür
                                    Dim ulkeKodu As String = GetUlkeKodu(ulke, conn)

                                    ' İhracat alanlarını güncelle
                                    Dim updateIhracatCmd As New OleDb.OleDbCommand()
                                    updateIhracatCmd.Connection = conn
                                    updateIhracatCmd.CommandText = "UPDATE tbStokFisiMaster SET " &
                                        "bFaturaTipi = 'İhracat Faturası', " &
                                        "sKdvMuafiyetKodu = '301', " &
                                        "sTeslimatAdresi = ?, " &
                                        "sTeslimatSehir = ?, " &
                                        "sTeslimatUlke = ?, " &
                                        "sTeslimatUlkeKodu = ?, " &
                                        "sIncotermsKodu = 'DAP', " &
                                        "nTasimaSekli = 3 " &
                                        "WHERE nStokFisiID = ?"

                                    ' Teslimat adresi (API'den gelen adres)
                                    updateIhracatCmd.Parameters.Add("?", OleDbType.VarWChar, 255).Value = If(String.IsNullOrEmpty(adres), "", adres)
                                    ' Teslimat şehri
                                    updateIhracatCmd.Parameters.Add("?", OleDbType.VarWChar, 100).Value = If(String.IsNullOrEmpty(il), "", il)
                                    ' Teslimat ülkesi
                                    updateIhracatCmd.Parameters.Add("?", OleDbType.VarWChar, 100).Value = If(String.IsNullOrEmpty(ulke), "", ulke)
                                    ' Teslimat ülke kodu (ISO)
                                    updateIhracatCmd.Parameters.Add("?", OleDbType.VarWChar, 10).Value = If(String.IsNullOrEmpty(ulkeKodu), "XX", ulkeKodu)
                                    ' nStokFisiID
                                    updateIhracatCmd.Parameters.AddWithValue("?", realStokFisiID)

                                    If conn.State <> ConnectionState.Open Then conn.Open()
                                    Dim ihracatRowsAffected As Integer = updateIhracatCmd.ExecuteNonQuery()

                                    If ihracatRowsAffected > 0 Then
                                        Log("SUCCESS", "AddOrder", $"✅ İHRACAT BİLGİLERİ GÜNCELLENDİ!")
                                        Log("INFO", "AddOrder", $"   - bFaturaTipi: İhracat Faturası")
                                        Log("INFO", "AddOrder", $"   - sKdvMuafiyetKodu: 301 (İhracat İstisnası)")
                                        Log("INFO", "AddOrder", $"   - sTeslimatUlke: {ulke}")
                                        Log("INFO", "AddOrder", $"   - sTeslimatUlkeKodu: {ulkeKodu}")
                                        Log("INFO", "AddOrder", $"   - sIncotermsKodu: DAP (Kargo Teslim)")
                                        Log("INFO", "AddOrder", $"   - nTasimaSekli: 3 (Kara Yolu)")
                                    Else
                                        Log("WARNING", "AddOrder", $"⚠️ İhracat bilgileri güncellenemedi! nStokFisiID: {realStokFisiID}")
                                    End If

                                Catch ihracatEx As Exception
                                    Log("ERROR", "AddOrder", $"❌ İhracat bilgileri güncelleme hatası: {ihracatEx.Message}")
                                    LogError($"İhracat bilgileri güncelleme hatası: {ihracatEx.Message}, nStokFisiID={realStokFisiID}")
                                End Try
                            End If
                            ' ===== YURT DIŞI SİPARİŞ GÜNCELLEME SONU =====

                            ' Not: WhatsApp bildirimi zaten SP'den önce gönderildi

                        ElseIf rowsAffected = 0 Then
                            Log("ERROR", "AddOrder", $"❌ HATA: Stored procedure hiçbir şey kaydetmedi! OrderID: {orderID}")
                            Log("ERROR", "AddOrder", $"Muhtemel Sebepler:")
                            Log("ERROR", "AddOrder", $"1. Barkod(lar) veritabanında bulunamıyor olabilir")
                            Log("ERROR", "AddOrder", $"2. Stored procedure'de hata oluşmuş olabilir")
                            Log("ERROR", "AddOrder", $"3. Firma bilgileri eksik/hatalı olabilir")
                            Log("ERROR", "AddOrder", $"4. Stok/Fiyat bilgileri geçersiz olabilir")

                            ' Barkod kontrolü yap
                            For i As Integer = 0 To 4
                                Dim testBarkod As String = ""
                                Select Case i
                                    Case 0 : testBarkod = barkod
                                    Case 1 : testBarkod = barkod1
                                    Case 2 : testBarkod = barkod2
                                    Case 3 : testBarkod = barkod3
                                    Case 4 : testBarkod = barkod4
                                End Select

                                If Not String.IsNullOrEmpty(testBarkod) AndAlso testBarkod <> "0" Then
                                    Try
                                        Dim barkodCheckCmd As New OleDb.OleDbCommand(
                                            "SELECT COUNT(*) FROM tbStok WHERE sBarkod = ?", conn)
                                        barkodCheckCmd.Parameters.AddWithValue("?", testBarkod)
                                        Dim barkodExists As Integer = CInt(barkodCheckCmd.ExecuteScalar())

                                        If barkodExists = 0 Then
                                            Log("ERROR", "AddOrder", $"❌ BARKOD BULUNAMADI: {testBarkod} (Ürün {i + 1})")
                                        Else
                                            Log("SUCCESS", "AddOrder", $"✅ Barkod mevcut: {testBarkod} (Ürün {i + 1})")
                                        End If
                                    Catch barkodEx As Exception
                                        LogError($"Barkod kontrol hatası: {barkodEx.Message}")
                                    End Try
                                End If
                            Next

                        ElseIf rowsAffected = -1 Then
                            Log("WARNING", "AddOrder", $"⚠️ Stored procedure -1 döndü (bazı DBMS'lerde normal)")
                            Log("INFO", "AddOrder", $"Tabloları manuel kontrol ediyoruz...")

                            ' Manuel kontrol (nStokFisiID kullanarak)
                            Try
                                Dim checkManualMasterCmd As New OleDb.OleDbCommand(
                                    "SELECT TOP 1 nStokFisiID FROM tbStokFisiMaster " &
                                    "WHERE nStokFisiID = ? " &
                                    "ORDER BY nStokFisiID DESC", conn)
                                checkManualMasterCmd.Parameters.AddWithValue("?", orderID)
                                Dim lastStokFisiID As Object = checkManualMasterCmd.ExecuteScalar()

                                If lastStokFisiID IsNot Nothing Then
                                    ' Kayıt tarihini de al
                                    Dim checkDateCmd As New OleDb.OleDbCommand(
                                        "SELECT TOP 1 CONVERT(VARCHAR(19), dteKayitTarihi, 120) AS KayitTarihi, " &
                                        "CONVERT(VARCHAR(10), dteFisTarihi, 120) AS FisTarihi " &
                                        "FROM tbStokFisiMaster WHERE nStokFisiID = ?", conn)
                                    checkDateCmd.Parameters.AddWithValue("?", lastStokFisiID)

                                    Using reader As OleDb.OleDbDataReader = checkDateCmd.ExecuteReader()
                                        If reader.Read() Then
                                            Dim kayitTarihi As String = If(reader("KayitTarihi") IsNot DBNull.Value, reader("KayitTarihi").ToString(), "BİLİNMİYOR")
                                            Dim fisTarihi As String = If(reader("FisTarihi") IsNot DBNull.Value, reader("FisTarihi").ToString(), "BİLİNMİYOR")
                                            Log("SUCCESS", "AddOrder", $"✅ Kayıt BAŞARILI! nStokFisiID: {lastStokFisiID}")
                                            Log("SUCCESS", "AddOrder", $"📅 FİŞ TARİHİ: {fisTarihi} | KAYIT ZAMANI: {kayitTarihi}")
                                        End If
                                    End Using

                                    ' Manuel kontrol sonrası orders tablosunu güncelle
                                    Dim manuelFirmaID As Integer = 0
                                    Try
                                        Dim getFirmaCmd2 As New OleDb.OleDbCommand(
                                            "SELECT TOP 1 nFirmaID FROM tbStokFisiMaster WHERE nStokFisiID = ?", conn)
                                        getFirmaCmd2.Parameters.AddWithValue("?", lastStokFisiID)
                                        Dim firmaResult2 = getFirmaCmd2.ExecuteScalar()
                                        If firmaResult2 IsNot Nothing AndAlso firmaResult2 IsNot DBNull.Value Then
                                            manuelFirmaID = CInt(firmaResult2)
                                        End If
                                    Catch
                                    End Try
                                    UpdateOrderStatus(orderID, conn, lastStokFisiID, manuelFirmaID, sAciklama3)
                                Else
                                    Log("ERROR", "AddOrder", $"❌ Kayıt tabloya EKLENMEDI!")
                                End If
                            Catch checkEx As Exception
                                LogError($"Manuel kontrol hatası: {checkEx.Message}")
                            End Try
                        End If

                    Catch spEx As Exception
                        Log("ERROR", "AddOrder", $"========== STORED PROCEDURE HATASI ==========")
                        Log("ERROR", "AddOrder", $"OrderID: {orderID}")
                        Log("ERROR", "AddOrder", $"Hata Mesajı: {spEx.Message}")
                        Log("ERROR", "AddOrder", $"Hata Tipi: {spEx.GetType().Name}")
                        Log("ERROR", "AddOrder", $"Stack Trace: {spEx.StackTrace}")

                        If TypeOf spEx Is OleDb.OleDbException Then
                            Dim oleEx As OleDb.OleDbException = CType(spEx, OleDb.OleDbException)
                            Log("ERROR", "AddOrder", $"SQL Error Count: {oleEx.Errors.Count}")
                            For Each sqlErr As OleDb.OleDbError In oleEx.Errors
                                Log("ERROR", "AddOrder", $"SQL Error: {sqlErr.Message} (Code: {sqlErr.NativeError})")
                            Next
                        End If

                        LogError($"AddOrder SP hatası: {spEx.Message}, orderID={orderID}, StackTrace: {spEx.StackTrace}")
                        Throw
                    End Try

                    Log("INFO", "AddOrder", $"========== SİPARİŞ KAYDETME İŞLEMİ BİTTİ ==========")
                    ' ===== DETAYLI LOG SİSTEMİ - BİTİŞ =====
                End Using
            Catch ex As Exception
                Log("ERROR", "AddOrder", $"HATA: {ex.GetType().Name} - {ex.Message}, orderID={orderID}")
                If ex.InnerException IsNot Nothing Then
                    Log("ERROR", "AddOrder", $"Inner: {ex.InnerException.Message}")
                End If
                LogError($"AddOrder hatasi: {ex.Message}, orderID={orderID}, StackTrace: {ex.StackTrace}")
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                    Log("DEBUG", "AddOrder", "Veritabanı bağlantısı kapatıldı.")
                End If
            End Try
        End Using
    End Sub

    ''' <summary>
    ''' Web'de goruntulenmesi gereken tum urunlerin Products tablosunda oldugundan emin olur
    ''' Eksik urunleri otomatik olarak ekler
    ''' </summary>
    Private Sub EnsureAllWebProductsInQueue()
        Log("INFO", "EnsureAllWebProductsInQueue", "Web urunleri kontrolu baslatiliyor...")

        ' Önce variantCount sütununun var olduğundan emin ol
        EnsureVariantCountColumn()

        Dim addedCount As Integer = 0
        Dim existCount As Integer = 0
        Dim variantChangedCount As Integer = 0
        Dim errorCount As Integer = 0

        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()

                ' bWebGoruntule=1 olan tum urunleri ve varyant sayilarini al
                Dim cmd As New OleDb.OleDbCommand()
                cmd.CommandText = "SELECT T1.sModel, T1.sRenk, COUNT(*) AS varyantSayisi " &
                                  "FROM tbStok AS T1 " &
                                  "WHERE T1.bWebGoruntule = '1' AND T1.sModel IS NOT NULL AND T1.sModel <> '' " &
                                  "GROUP BY T1.sModel, T1.sRenk"
                cmd.Connection = conn

                Dim products As New List(Of Tuple(Of String, String, Integer))()
                Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim sModel As String = If(reader("sModel") IsNot DBNull.Value, reader("sModel").ToString().Trim(), "")
                        Dim sRenk As String = If(reader("sRenk") IsNot DBNull.Value, reader("sRenk").ToString().Trim(), "")
                        Dim varyantSayisi As Integer = Convert.ToInt32(reader("varyantSayisi"))
                        If Not String.IsNullOrEmpty(sModel) Then
                            products.Add(Tuple.Create(sModel, sRenk, varyantSayisi))
                        End If
                    End While
                End Using

                Log("INFO", "EnsureAllWebProductsInQueue", $"Toplam {products.Count} web urunu bulundu. Kontrol ediliyor...")

                ' Her urun icin Products tablosunda var mi ve varyant sayisi degismis mi kontrol et
                For Each productTuple As Tuple(Of String, String, Integer) In products
                    Try
                        Dim sModel As String = productTuple.Item1
                        Dim sRenk As String = productTuple.Item2
                        Dim dbVaryantSayisi As Integer = productTuple.Item3
                        Dim productID As String = sModel & "__" & sRenk

                        ' Products tablosunda var mi ve varyant sayisini kontrol et
                        Dim checkCmd As New OleDb.OleDbCommand("SELECT status, variantCount FROM Products WHERE productID = ?", conn)
                        checkCmd.Parameters.AddWithValue("?", productID)
                        Using checkReader As OleDb.OleDbDataReader = checkCmd.ExecuteReader()
                            If checkReader.Read() Then
                                ' Urun var - varyant sayisi degismis mi kontrol et
                                Dim currentStatus As String = If(checkReader("status") IsNot DBNull.Value, checkReader("status").ToString(), "0")
                                Dim savedVaryantSayisi As Integer = 0
                                If checkReader("variantCount") IsNot DBNull.Value Then
                                    savedVaryantSayisi = Convert.ToInt32(checkReader("variantCount"))
                                End If

                                ' Varyant sayisi artmis ve urun zaten gonderilmisse (status=1), tekrar gonder
                                If dbVaryantSayisi > savedVaryantSayisi AndAlso currentStatus = "1" Then
                                    checkReader.Close()
                                    Dim updateCmd As New OleDb.OleDbCommand("UPDATE Products SET status = '0', variantCount = ?, updated_at = GETDATE() WHERE productID = ?", conn)
                                    updateCmd.Parameters.AddWithValue("?", dbVaryantSayisi)
                                    updateCmd.Parameters.AddWithValue("?", productID)
                                    updateCmd.ExecuteNonQuery()
                                    variantChangedCount += 1
                                    Log("INFO", "EnsureAllWebProductsInQueue", $"Varyant eklendi, tekrar gonderilecek: {productID} (eski:{savedVaryantSayisi} -> yeni:{dbVaryantSayisi})")
                                Else
                                    existCount += 1
                                End If
                            Else
                                ' Products tablosunda yok, ekle
                                checkReader.Close()
                                Dim insertCmd As New OleDb.OleDbCommand("INSERT INTO Products (productID, status, variantCount, updated_at) VALUES (?, '0', ?, GETDATE())", conn)
                                insertCmd.Parameters.AddWithValue("?", productID)
                                insertCmd.Parameters.AddWithValue("?", dbVaryantSayisi)
                                insertCmd.ExecuteNonQuery()
                                addedCount += 1

                                If addedCount Mod 100 = 0 Then
                                    Log("INFO", "EnsureAllWebProductsInQueue", $"Ilerleme: {addedCount} yeni urun eklendi...")
                                End If
                            End If
                        End Using

                    Catch ex As Exception
                        errorCount += 1
                        If errorCount <= 10 Then
                            Log("WARNING", "EnsureAllWebProductsInQueue", $"Urun islenemedi: Hata: {ex.Message}")
                        End If
                    End Try
                Next

            End Using

            Log("SUCCESS", "EnsureAllWebProductsInQueue", $"Kontrol tamamlandi. Yeni: {addedCount}, Mevcut: {existCount}, Varyant degisen: {variantChangedCount}, Hata: {errorCount}")

        Catch ex As Exception
            Log("ERROR", "EnsureAllWebProductsInQueue", $"Genel hata: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Products tablosuna variantCount sutunu ekler (yoksa)
    ''' </summary>
    Private Sub EnsureVariantCountColumn()
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()

                ' variantCount sutunu var mi kontrol et
                Dim checkCmd As New OleDb.OleDbCommand(
                    "SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS " &
                    "WHERE TABLE_NAME = 'Products' AND COLUMN_NAME = 'variantCount'", conn)
                Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If exists = 0 Then
                    ' Sutun yok, ekle
                    Dim alterCmd As New OleDb.OleDbCommand(
                        "ALTER TABLE Products ADD variantCount INT DEFAULT 0", conn)
                    alterCmd.ExecuteNonQuery()
                    Log("INFO", "EnsureVariantCountColumn", "Products tablosuna variantCount sutunu eklendi")
                End If
            End Using
        Catch ex As Exception
            Log("WARNING", "EnsureVariantCountColumn", $"variantCount sutunu eklenemedi: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Web'de status=1 olan ama gercekte web'de olmayan urunleri tespit eder ve status=0 yapar
    ''' </summary>
    Private Sub ResetOrphanedProducts()
        Log("INFO", "ResetOrphanedProducts", "Orphan urun kontrolu baslatiliyor...")

        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()

                ' status=1 olan ama son 7 gunde guncellenmemis urunleri bul
                Dim checkCmd As New OleDb.OleDbCommand(
                    "SELECT COUNT(*) FROM Products WHERE status = '1' AND " &
                    "(updated_at IS NULL OR updated_at < DATEADD(day, -7, GETDATE()))", conn)
                Dim orphanCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If orphanCount > 0 Then
                    Log("INFO", "ResetOrphanedProducts", $"{orphanCount} eski urun bulundu, yeniden gonderilmek uzere isaretleniyor...")

                    ' Bu urunlerin status'unu 0 yap ki tekrar gonderilsinler
                    Dim updateCmd As New OleDb.OleDbCommand(
                        "UPDATE Products SET status = '0' WHERE status = '1' AND " &
                        "(updated_at IS NULL OR updated_at < DATEADD(day, -7, GETDATE()))", conn)
                    Dim updated As Integer = updateCmd.ExecuteNonQuery()

                    Log("SUCCESS", "ResetOrphanedProducts", $"{updated} urun yeniden gonderilmek uzere isaretlendi")
                Else
                    Log("INFO", "ResetOrphanedProducts", "Orphan urun bulunamadi")
                End If

            End Using
        Catch ex As Exception
            Log("ERROR", "ResetOrphanedProducts", $"Hata: {ex.Message}")
        End Try
    End Sub


    Private Sub InsertProductIfNotExists(id As String, conn As OleDb.OleDbConnection)
        Log("INFO", "InsertProductIfNotExists", $"Ürün kontrol ediliyor: productID={id}")
        Try
            Dim check As New OleDb.OleDbCommand
            check.CommandText = "SELECT COUNT(*) FROM Products WHERE productID = ? COLLATE Turkish_CI_AS"
            check.Parameters.AddWithValue("?", id)
            check.Connection = conn
            If CInt(check.ExecuteScalar()) = 0 Then
                Dim insert As New OleDb.OleDbCommand
                insert.CommandText = "INSERT INTO Products (productID, status, updated_at) VALUES (?, '0', GETDATE())"
                insert.Parameters.AddWithValue("?", id)
                insert.Connection = conn
                insert.ExecuteNonQuery()
                Log("DEBUG", "InsertProductIfNotExists", $"Ürün eklendi: productID={id}")
            Else
                Log("DEBUG", "InsertProductIfNotExists", $"Ürün zaten mevcut: productID={id}")
            End If
        Catch ex As Exception
            LogError("Error in InsertProductIfNotExists: " & ex.Message)
        End Try
    End Sub
    Private Sub InsertFisIfNotExists(nIslemID As String, id As String, conn As OleDb.OleDbConnection)
        Log("INFO", "InsertFisIfNotExists", $"Fiş güncelleniyor: nIslemID={nIslemID}, productID={id}")
        Try
            Dim update As New OleDb.OleDbCommand
            update.CommandText = "UPDATE Products SET status = '0', updated_at = GETDATE() WHERE productID = ? COLLATE Turkish_CI_AS"
            update.Parameters.AddWithValue("?", id)
            update.Connection = conn
            update.ExecuteNonQuery()
            Log("DEBUG", "InsertFisIfNotExists", $"Fiş güncellendi: productID={id}")
        Catch ex As Exception
            LogError("Error in InsertFisIfNotExists: " & ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' HTTP GET isteği yapar (sipariş listesi ve detayları için)
    ''' API dokümantasyonuna göre order/lists ve order/show GET metodu kullanır
    ''' </summary>
    Private Function LaGet(method As String) As String
        Log("INFO", "LaGet", $"API GET çağrısı yapılıyor: method={method}")
        Try
            ' LAGlobalAddress, ApiKey ve ApiSecret kontrolü
            If String.IsNullOrEmpty(LAGlobalAddress) Then
                LogError("LaGet: LAGlobalAddress boş veya null!")
                Return ""
            End If

            If String.IsNullOrEmpty(ApiKey) OrElse String.IsNullOrEmpty(ApiSecret) Then
                LogError($"LaGet: API kimlik bilgileri eksik! ApiKey={Not String.IsNullOrEmpty(ApiKey)}, ApiSecret={Not String.IsNullOrEmpty(ApiSecret)}")
                Return ""
            End If

            ' LAGlobalAddress'in doğru formatta olduğundan emin ol (/ ile bitmeli)
            Dim baseAddress As String = LAGlobalAddress
            If Not baseAddress.EndsWith("/") Then
                baseAddress &= "/"
                Log("WARNING", "LaGet", $"LAGlobalAddress '/' ile bitmiyor, eklendi: {baseAddress}")
            End If

            Dim url As String = baseAddress & method

            ' URL validation
            If Not url.StartsWith("http://") AndAlso Not url.StartsWith("https://") Then
                LogError($"LaGet Geçersiz URL: {url}")
                Return ""
            End If

            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Method = "GET"
            request.Timeout = 300000 ' 300 saniye (5 dakika) timeout - artırıldı
            request.ReadWriteTimeout = 300000 ' Read/Write timeout
            request.KeepAlive = False
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36"

            ' Content-Type ve Headers (API dokümantasyonuna göre)
            request.Accept = "application/json"
            request.Headers.Add("apikey", ApiKey)
            request.Headers.Add("apisecret", ApiSecret)

            Log("INFO", "LaGet", $"🌐 API İstek URL: {url}")
            Log("DEBUG", "LaGet", $"🔑 API Key mevcut: {Not String.IsNullOrEmpty(ApiKey)}")
            Log("DEBUG", "LaGet", $"🔐 API Secret mevcut: {Not String.IsNullOrEmpty(ApiSecret)}")

            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Log("SUCCESS", "LaGet", $"✅ HTTP Durum Kodu: {CInt(response.StatusCode)} - {response.StatusDescription}")
                Using responseStream As Stream = response.GetResponseStream()
                    Using reader As New StreamReader(responseStream, Encoding.UTF8)
                        Dim result As String = reader.ReadToEnd().Trim()
                        Log("INFO", "LaGet", $"📥 API yanıtı (ilk 500 karakter): {If(result.Length > 500, result.Substring(0, 500) & "...", result)}")
                        Return result
                    End Using
                End Using
            End Using
        Catch ex As WebException
            Dim errorResponse As String = ""
            Dim statusCode As String = "Bilinmiyor"

            If ex.Response IsNot Nothing Then
                Try
                    Dim httpResponse As HttpWebResponse = CType(ex.Response, HttpWebResponse)
                    statusCode = $"{CInt(httpResponse.StatusCode)} - {httpResponse.StatusDescription}"

                    Using reader As New StreamReader(ex.Response.GetResponseStream(), Encoding.UTF8)
                        errorResponse = reader.ReadToEnd()
                    End Using
                Catch
                    errorResponse = "Yanıt okunamadı"
                End Try
            End If

            LogError($"❌ LaGet WebException: {ex.Message}")
            LogError($"📍 HTTP Durum: {statusCode}")
            LogError($"📄 Yanıt (ilk 1000 karakter): {If(errorResponse.Length > 1000, errorResponse.Substring(0, 1000) & "...", errorResponse)}")
            LogError($"🔍 Stack Trace: {ex.StackTrace}")

            Return ""
        Catch ex As Exception
            LogError($"❌ LaGet Genel Hata: {ex.Message}")
            LogError($"🔍 Stack Trace: {ex.StackTrace}")
            Return ""
        End Try
    End Function
    Private Function LaPost(method As String, data As Dictionary(Of String, Object)) As String
        Log("INFO", "LaPost", $"API çağrısı yapılıyor: method={method}")
        Try
            ' LAGlobalAddress'in doğru formatta olduğundan emin ol (/ ile bitmeli)
            Dim baseAddress As String = LAGlobalAddress
            If Not baseAddress.EndsWith("/") Then
                baseAddress &= "/"
                Log("WARNING", "LaPost", $"LAGlobalAddress '/' ile bitmiyor, eklendi: {baseAddress}")
            End If

            Dim url As String = baseAddress & method

            ' URL validation
            If Not url.StartsWith("http://") AndAlso Not url.StartsWith("https://") Then
                LogError($"LaPost Geçersiz URL: {url}")
                Return ""
            End If

            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Method = "POST"
            request.Timeout = 300000 ' 300 saniye (5 dakika) timeout - artırıldı
            request.ReadWriteTimeout = 300000 ' Read/Write timeout
            request.KeepAlive = False
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36"

            ' API dokümantasyonuna göre JSON formatında gönder
            Dim jsonString As String = JsonConvert.SerializeObject(data)
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(jsonString)

            ' Content-Type ve Headers (API dokümantasyonuna göre)
            request.ContentType = "application/json; charset=utf-8"
            request.Accept = "application/json"
            request.ContentLength = byteArray.Length
            request.Headers.Add("apikey", ApiKey)
            request.Headers.Add("apisecret", ApiSecret)

            Log("INFO", "LaPost", $"🌐 API İstek URL: {url}")
            Log("DEBUG", "LaPost", $"📤 JSON verisi (ilk 500 karakter): {If(jsonString.Length > 500, jsonString.Substring(0, 500) & "...", jsonString)}")
            Log("DEBUG", "LaPost", $"🔑 API Key mevcut: {Not String.IsNullOrEmpty(ApiKey)}")
            Log("DEBUG", "LaPost", $"🔐 API Secret mevcut: {Not String.IsNullOrEmpty(ApiSecret)}")

            Using dataStream As Stream = request.GetRequestStream()
                dataStream.Write(byteArray, 0, byteArray.Length)
            End Using

            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Log("SUCCESS", "LaPost", $"✅ HTTP Durum Kodu: {CInt(response.StatusCode)} - {response.StatusDescription}")
                Using responseStream As Stream = response.GetResponseStream()
                    Using reader As New StreamReader(responseStream, Encoding.UTF8)
                        Dim result As String = reader.ReadToEnd().Trim()
                        Log("INFO", "LaPost", $"📥 API yanıtı (ilk 500 karakter): {If(result.Length > 500, result.Substring(0, 500) & "...", result)}")
                        Return result
                    End Using
                End Using
            End Using
        Catch ex As WebException
            Dim errorResponse As String = ""
            Dim statusCode As String = "Bilinmiyor"

            If ex.Response IsNot Nothing Then
                Try
                    Dim httpResponse As HttpWebResponse = CType(ex.Response, HttpWebResponse)
                    statusCode = $"{CInt(httpResponse.StatusCode)} - {httpResponse.StatusDescription}"

                    Using reader As New StreamReader(ex.Response.GetResponseStream(), Encoding.UTF8)
                        errorResponse = reader.ReadToEnd()
                    End Using
                Catch
                    errorResponse = "Yanıt okunamadı"
                End Try
            End If

            LogError($"❌ LaPost WebException: {ex.Message}")
            LogError($"📍 HTTP Durum: {statusCode}")
            LogError($"📄 Yanıt (ilk 1000 karakter): {If(errorResponse.Length > 1000, errorResponse.Substring(0, 1000) & "...", errorResponse)}")
            LogError($"🔍 Stack Trace: {ex.StackTrace}")

            Return ""
        Catch ex As Exception
            LogError($"❌ LaPost Genel Hata: {ex.Message}")
            LogError($"🔍 Stack Trace: {ex.StackTrace}")
            Return ""
        End Try
    End Function

    ' ===== YENİ: URL'yi PHP Formatına Dönüştür =====
    ''' <summary>
    ''' Normal API URL'sini PHP formatına dönüştürür
    ''' Örnek: https://www.erentrend.com/api/v1/ -> https://www.erentrend.com/ajax.php?page=php_v1&method=
    ''' </summary>
    Private Function ConvertToPHPUrl(apiUrl As String) As String
        Try
            ' URL'den domain'i çıkar
            Dim uri As New Uri(apiUrl)
            Dim baseUrl As String = uri.Scheme & "://" & uri.Host

            ' Port varsa ekle
            If Not uri.IsDefaultPort Then
                baseUrl &= ":" & uri.Port.ToString()
            End If

            ' PHP formatına dönüştür
            Dim phpUrl As String = baseUrl & "/ajax.php?page=php_v1&method="

            Log("INFO", "ConvertToPHPUrl", $"🔄 URL dönüştürüldü: {apiUrl} -> {phpUrl}")
            Return phpUrl
        Catch ex As Exception
            LogError($"❌ URL dönüştürme hatası: {ex.Message}")
            ' Hata durumunda orijinal URL'yi döndür
            Return apiUrl
        End Try
    End Function

    ' ===== YENİ: API Method'unu PHP Formatına Dönüştür =====
    ''' <summary>
    ''' API method adını PHP formatına dönüştürür
    ''' Örnek: product/save -> product, order/lists -> orders
    ''' </summary>
    Private Function ConvertMethodToPHP(apiMethod As String) As String
        ' API method -> PHP method eşleştirmesi
        Select Case apiMethod.ToLower().Trim("/")
            Case "product/save"
                Return "product"
            Case "product/updatestocks"
                Return "product_stock"
            Case "product/updateprices"
                Return "product_price"
            Case "product/updatesimilars"
                Return "product_similar"
            Case "order/lists"
                Return "orders"
            Case "order/updatestatus"
                Return "order_status"
            Case "order/updateshipmentinfo"
                Return "order_shipment"
            Case Else
                ' Query string varsa ayır
                If apiMethod.Contains("?") Then
                    Dim parts = apiMethod.Split("?"c)
                    Dim basePart = parts(0).Trim("/").Replace("/", "_")
                    Return basePart & "&" & parts(1)
                End If
                ' Bilinmeyen method için / yerine _ koy
                Return apiMethod.Trim("/").Replace("/", "_")
        End Select
    End Function

    ' ===== YENİ: PHP Entegrasyon için POST Fonksiyonu =====
    ''' <summary>
    ''' PHP API'sine POST isteği yapar
    ''' URL formatı: https://site.com/ajax.php?page=php_v1&method=product
    ''' Content-Type: application/x-www-form-urlencoded
    ''' </summary>
    Private Function LaPostPHP(method As String, data As Dictionary(Of String, Object)) As String
        Log("INFO", "LaPostPHP", $"PHP API çağrısı yapılıyor: method={method}")
        Try
            ' Normal API URL'sini PHP formatına dönüştür
            ' https://www.erentrend.com/api/v1/ -> https://www.erentrend.com/ajax.php?page=php_v1&method=
            Dim phpBaseUrl As String = ConvertToPHPUrl(LAGlobalAddress)

            ' Method'u PHP formatına uyarla
            ' API: product/save -> PHP: product
            Dim phpMethod As String = ConvertMethodToPHP(method)

            ' Final URL oluştur
            Dim url As String = phpBaseUrl & phpMethod

            ' URL validation
            If Not url.StartsWith("http://") AndAlso Not url.StartsWith("https://") Then
                LogError($"LaPostPHP Geçersiz URL: {url}")
                Return ""
            End If

            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Method = "POST"
            request.Timeout = 300000 ' 300 saniye (5 dakika) timeout - artırıldı
            request.ReadWriteTimeout = 300000 ' Read/Write timeout - artırıldı
            request.KeepAlive = False
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36"

            ' PHP için form-urlencoded format (PHP'nin http_build_query formatı)
            Dim formData As String = BuildFormData(data)
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(formData)

            ' Content-Type ve Headers
            request.ContentType = "application/x-www-form-urlencoded; charset=utf-8"
            request.Accept = "*/*"
            request.ContentLength = byteArray.Length
            request.Headers.Add("apikey", ApiKey)
            request.Headers.Add("apisecret", ApiSecret)

            Log("INFO", "LaPostPHP", $"🌐 PHP API İstek URL: {url}")
            Log("DEBUG", "LaPostPHP", $"📤 Form verisi (ilk 500 karakter): {If(formData.Length > 500, formData.Substring(0, 500) & "...", formData)}")

            Using dataStream As Stream = request.GetRequestStream()
                dataStream.Write(byteArray, 0, byteArray.Length)
            End Using

            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Log("SUCCESS", "LaPostPHP", $"✅ HTTP Durum Kodu: {CInt(response.StatusCode)} - {response.StatusDescription}")
                Using responseStream As Stream = response.GetResponseStream()
                    Using reader As New StreamReader(responseStream, Encoding.UTF8)
                        Dim result As String = reader.ReadToEnd().Trim()
                        Log("INFO", "LaPostPHP", $"📥 PHP yanıtı (ilk 500 karakter): {If(result.Length > 500, result.Substring(0, 500) & "...", result)}")
                        Return result
                    End Using
                End Using
            End Using
        Catch ex As WebException
            Dim errorResponse As String = ""
            Dim statusCode As String = "Bilinmiyor"

            If ex.Response IsNot Nothing Then
                Try
                    Dim httpResponse As HttpWebResponse = CType(ex.Response, HttpWebResponse)
                    statusCode = $"{CInt(httpResponse.StatusCode)} - {httpResponse.StatusDescription}"

                    Using reader As New StreamReader(ex.Response.GetResponseStream(), Encoding.UTF8)
                        errorResponse = reader.ReadToEnd()
                    End Using
                Catch
                    errorResponse = "Yanıt okunamadı"
                End Try
            End If

            LogError($"❌ LaPostPHP WebException: {ex.Message}")
            LogError($"📍 HTTP Durum: {statusCode}")
            LogError($"📄 Yanıt: {If(errorResponse.Length > 1000, errorResponse.Substring(0, 1000) & "...", errorResponse)}")

            Return ""
        Catch ex As Exception
            LogError($"❌ LaPostPHP Genel Hata: {ex.Message}")
            Return ""
        End Try
    End Function

    ' ===== YENİ: PHP Entegrasyon için GET Fonksiyonu =====
    Private Function LaGetPHP(method As String) As String
        Log("INFO", "LaGetPHP", $"PHP API GET çağrısı yapılıyor: method={method}")
        Try
            ' Normal API URL'sini PHP formatına dönüştür
            Dim phpBaseUrl As String = ConvertToPHPUrl(LAGlobalAddress)

            ' Method'u PHP formatına uyarla
            Dim phpMethod As String = ConvertMethodToPHP(method)

            ' Final URL oluştur
            Dim url As String = phpBaseUrl & phpMethod

            If Not url.StartsWith("http://") AndAlso Not url.StartsWith("https://") Then
                LogError($"LaGetPHP Geçersiz URL: {url}")
                Return ""
            End If

            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            request.Method = "GET"
            request.Timeout = 300000 ' 300 saniye (5 dakika) timeout - artırıldı
            request.ReadWriteTimeout = 300000 ' Read/Write timeout - artırıldı
            request.KeepAlive = False
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36"
            request.Accept = "*/*"
            request.Headers.Add("apikey", ApiKey)
            request.Headers.Add("apisecret", ApiSecret)

            Log("INFO", "LaGetPHP", $"🌐 PHP API İstek URL: {url}")

            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Log("SUCCESS", "LaGetPHP", $"✅ HTTP Durum Kodu: {CInt(response.StatusCode)}")
                Using responseStream As Stream = response.GetResponseStream()
                    Using reader As New StreamReader(responseStream, Encoding.UTF8)
                        Dim result As String = reader.ReadToEnd().Trim()
                        Log("INFO", "LaGetPHP", $"📥 PHP yanıtı (ilk 500 karakter): {If(result.Length > 500, result.Substring(0, 500) & "...", result)}")
                        Return result
                    End Using
                End Using
            End Using
        Catch ex As WebException
            LogError($"❌ LaGetPHP WebException: {ex.Message}")
            Return ""
        Catch ex As Exception
            LogError($"❌ LaGetPHP Genel Hata: {ex.Message}")
            Return ""
        End Try
    End Function

    ' ===== YENİ: Akıllı API Yönlendirici =====
    ''' <summary>
    ''' Seçili gönderim moduna göre doğru API fonksiyonunu çağırır
    ''' GonderimModu: 1 = API (Doğrudan), 2 = PHP Entegrasyon
    ''' </summary>
    Private Function SendToApi(method As String, data As Dictionary(Of String, Object)) As String
        ' UI'dan gönderim modunu kontrol et
        Dim currentMode As Integer = GonderimModu
        SafeUpdateUI(Sub()
                         If rdoPhpEntegrasyon.Checked Then
                             currentMode = 2
                         Else
                             currentMode = 1
                         End If
                     End Sub)

        If currentMode = 2 Then
            Log("INFO", "SendToApi", $"📡 PHP modu ile gönderiliyor: {method}")
            Return LaPostPHP(method, data)
        Else
            Log("INFO", "SendToApi", $"📡 API modu ile gönderiliyor: {method}")
            Return LaPost(method, data)
        End If
    End Function

    ''' <summary>
    ''' GET istekleri için akıllı yönlendirici
    ''' </summary>
    Private Function GetFromApi(method As String) As String
        Dim currentMode As Integer = GonderimModu
        SafeUpdateUI(Sub()
                         If rdoPhpEntegrasyon.Checked Then
                             currentMode = 2
                         Else
                             currentMode = 1
                         End If
                     End Sub)

        If currentMode = 2 Then
            Log("INFO", "GetFromApi", $"📡 PHP modu ile alınıyor: {method}")
            Return LaGetPHP(method)
        Else
            Log("INFO", "GetFromApi", $"📡 API modu ile alınıyor: {method}")
            Return LaGet(method)
        End If
    End Function

    Private Function BuildFormData(data As Dictionary(Of String, Object)) As String
        Log("INFO", "BuildFormData", "Form verisi oluşturuluyor.")
        Try
            Dim sb As New StringBuilder
            BuildFormDataRecursive(data, sb, "")
            Dim result = If(sb.Length > 0, sb.ToString.Substring(1), "")
            Log("DEBUG", "BuildFormData", $"Oluşturulan form verisi: {result}")
            Return result
        Catch ex As Exception
            LogError($"BuildFormData Error: {ex.Message}")
            Return ""
        End Try
    End Function
    Private Sub BuildFormDataRecursive(obj As Object, sb As StringBuilder, prefix As String)
        Log("INFO", "BuildFormDataRecursive", $"Form verisi işleniyor: prefix={prefix}")
        Try
            If TypeOf obj Is Dictionary(Of String, Object) Then
                Dim dict As Dictionary(Of String, Object) = obj
                For Each kv As KeyValuePair(Of String, Object) In dict
                    Dim newPrefix As String = If(prefix = "", kv.Key, prefix & "[" & kv.Key & "]")
                    BuildFormDataRecursive(kv.Value, sb, newPrefix)
                Next
            ElseIf TypeOf obj Is List(Of Dictionary(Of String, Object)) Then
                Dim list As List(Of Dictionary(Of String, Object)) = obj
                For i As Integer = 0 To list.Count - 1
                    Dim newPrefix As String = prefix & "[" & i & "]"
                    BuildFormDataRecursive(list(i), sb, newPrefix)
                Next
            ElseIf TypeOf obj Is List(Of String) Then
                ' String listesi (resim URL'leri gibi)
                Dim list As List(Of String) = obj
                Log("DEBUG", "BuildFormDataRecursive", $"String listesi bulundu: {list.Count} adet, prefix={prefix}")
                For i As Integer = 0 To list.Count - 1
                    Dim newPrefix As String = prefix & "[" & i & "]"
                    sb.Append("&" & WebUtility.UrlEncode(newPrefix) & "=" & WebUtility.UrlEncode(list(i)))
                    Log("DEBUG", "BuildFormDataRecursive", $"Resim eklendi: {newPrefix} = {list(i)}")
                Next
            ElseIf TypeOf obj Is IList Then
                ' Genel liste desteği
                Dim list As IList = obj
                For i As Integer = 0 To list.Count - 1
                    Dim newPrefix As String = prefix & "[" & i & "]"
                    BuildFormDataRecursive(list(i), sb, newPrefix)
                Next
            Else
                sb.Append("&" & WebUtility.UrlEncode(prefix) & "=" & WebUtility.UrlEncode(obj.ToString))
            End If
        Catch ex As Exception
            LogError("Error in BuildFormDataRecursive: " & ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' Hata mesajlarını loglar (Dosya + Konsol + UI)
    ''' </summary>
    Private Sub LogError(message As String)
        Try
            ' EticaretLogger'a yönlendir
            EticaretLogger.LogError(message)

            ' UI'ye de yaz (thread-safe)
            Try
                If Not Me.IsDisposed AndAlso Me.IsHandleCreated Then
                    If Me.InvokeRequired Then
                        Me.Invoke(Sub() AddLog($"❌ ERROR: {message}"))
                    Else
                        AddLog($"❌ ERROR: {message}")
                    End If
                End If
            Catch dispEx As ObjectDisposedException
                ' Form kapalı, UI log atla
            End Try
        Catch ex As Exception
            Console.WriteLine($"[KRITIK] LogError hatası: {ex.Message}")
            EticaretLogger.LogCritical($"LogError yönlendirme hatası: {message}", ex)
        End Try
    End Sub

    ''' <summary>
    ''' Genel log mesajlarını loglar (EticaretLogger'a yönlendirir)
    ''' Level: DEBUG, INFO, WARNING, ERROR, SUCCESS
    ''' </summary>
    Private Sub Log(level As String, method As String, message As String)
        Try
            ' Tam mesajı formatla
            Dim fullMessage As String = $"[{method}] {message}"

            ' EticaretLogger'a yönlendir
            Select Case level.ToUpper()
                Case "DEBUG"
                    EticaretLogger.LogDebug(fullMessage)
                Case "INFO"
                    EticaretLogger.LogInfo(fullMessage)
                Case "WARNING"
                    EticaretLogger.LogWarning(fullMessage)
                Case "ERROR", "CRITICAL"
                    EticaretLogger.LogError(fullMessage)
                Case "SUCCESS"
                    EticaretLogger.LogInfo($"✅ {fullMessage}")
                Case Else
                    EticaretLogger.LogInfo(fullMessage)
            End Select

            ' Ayrıca sync log dosyasına da yaz (eski format uyumluluğu)
            EticaretLogger.LogSync(method, "", level <> "ERROR", message)

            ' Önemli mesajları UI'ye de yaz (thread-safe)
            If level = "ERROR" OrElse level = "SUCCESS" OrElse level = "WARNING" OrElse level = "INFO" Then
                Dim emoji As String = ""
                Select Case level
                    Case "ERROR" : emoji = "❌"
                    Case "SUCCESS" : emoji = "✅"
                    Case "WARNING" : emoji = "⚠️"
                    Case "INFO" : emoji = "ℹ️"
                    Case "DEBUG" : emoji = "🔍"
                End Select

                ' Sadece kritik mesajları UI'ye gönder (DEBUG hariç)
                If level <> "DEBUG" Then
                    Try
                        If Not Me.IsDisposed AndAlso Me.IsHandleCreated Then
                            If Me.InvokeRequired Then
                                Me.Invoke(Sub() AddLog($"{emoji} [{level}] {method}: {message}"))
                            Else
                                AddLog($"{emoji} [{level}] {method}: {message}")
                            End If
                        End If
                    Catch dispEx As ObjectDisposedException
                        ' Form kapalı, UI log atla
                    End Try
                End If
            End If

        Catch ex As Exception
            Console.WriteLine($"[KRITIK] Log yazma hatası: {ex.Message}")
            Try
                ' Fallback: EticaretLogger kritik hata
                EticaretLogger.LogCritical($"Log yönlendirme hatası: {message}", ex)
            Catch
                ' Tamamen başarısız
            End Try
        End Try
    End Sub

    ' StrToUTF8 fonksiyonu kaldırıldı (682. satırdaki PHP versiyonu kullanılıyor)

    ' ===== BEDEN SIRALAMA (PHP'deki reOrderArray) =====
    Private Function ReOrderVariants(variants As List(Of Dictionary(Of String, Object)), searchValue As String) As List(Of Dictionary(Of String, Object))
        Dim result As New List(Of Dictionary(Of String, Object))
        For i As Integer = variants.Count - 1 To 0 Step -1
            If variants(i).ContainsKey("value_2") AndAlso variants(i)("value_2").ToString().ToUpper() = searchValue.ToUpper() Then
                result.Add(variants(i))
                variants.RemoveAt(i)
            End If
        Next
        result.AddRange(variants)
        Return result
    End Function
    Private Function SendProduct(id As String, conn As OleDb.OleDbConnection) As Dictionary(Of String, Object)
        Log("INFO", "SendProduct", $"Ürün işleniyor: productID={id}")
        Dim product As New Dictionary(Of String, Object)
        Try
            Dim parts() As String = id.Split(New String() {"__"}, StringSplitOptions.None)
            If parts.Length < 1 OrElse String.IsNullOrEmpty(parts(0)) Then
                Log("ERROR", "SendProduct", $"Hatalı productID formatı: {id}")
                Return product
            End If
            Dim productModelFromID As String = parts(0).Trim()
            Dim renk As String = If(parts.Length > 1, parts(1).Trim(), "")  ' Varyanssız ise boş
            product("productID") = id

            ' cleanModel formatını oluştur (frm_stok_kart.vb ile aynı mantık)
            ' Örnek: "US1717-G0889-10 Yaş" -> "US1717-G"
            Dim cleanModel As String = productModelFromID
            If Not String.IsNullOrEmpty(productModelFromID) Then
                Dim modelParts() As String = productModelFromID.Split("-"c)
                If modelParts.Length >= 2 Then
                    cleanModel = modelParts(0) & "-" & modelParts(1)
                End If
            End If

            ' Kullanıcının deposunu al
            Dim userDepo As String = sDepo
            If String.IsNullOrEmpty(userDepo) Then userDepo = "D001"
            Log("DEBUG", "SendProduct", $"Model ayrıştırıldı: productModelFromID={productModelFromID}, cleanModel={cleanModel}, renk={renk}, depo={userDepo}")

            ' Ana ürün bilgilerini Çek
            ' Seçilen fiyat tipini al
            Dim seciliFiyatTipi As String = GetSeciliFiyatTipi()

            Dim baseSql As String =
            "SELECT TOP 1 " &
            " T1.nStokID," &
            " T1.sKodu," &
            " T1.sAciklama," &
            " T1.sKisaAdi," &
            " T1.nStokTipi," &
            " T1.sBedenTipi," &
            " T1.sModel," &
            " T1.sRenk," &
            " T1.nEn," &
            " T1.nBoy," &
            " T1.nYukseklik," &
            " T1.nAgirlik," &
            " T2.nKdvOrani," &
            " (SELECT lFiyat FROM tbStokFiyati WHERE nStokID=T1.nStokID AND sFiyatTipi='2') AS TRENDYOL_SATIS," &
            " (SELECT lFiyat FROM tbStokFiyati WHERE nStokID=T1.nStokID AND sFiyatTipi='3') AS HB_SATIS," &
            " (SELECT lFiyat FROM tbStokFiyati WHERE nStokID=T1.nStokID AND sFiyatTipi='4') AS N11_SATIS," &
            " (SELECT lFiyat FROM tbStokFiyati WHERE nStokID=T1.nStokID AND sFiyatTipi='" & seciliFiyatTipi & "') AS SITE_SATIS," &
            " (SELECT lFiyat FROM tbStokFiyati WHERE nStokID=T1.nStokID AND sFiyatTipi='A') AS ALIS_FIYAT"

            ' Dinamik sınıf eşleştirme SQL parçalarını al
            Dim markaField As String = GetSinifEslemeSqlField(conn, "ETICARET_SINIF_MARKA", "sSinifKodu3", "marka")
            Dim cat1Field As String = GetSinifEslemeSqlField(conn, "ETICARET_SINIF_KAT1", "sSinifKodu4", "cat1")
            Dim cat2Field As String = GetSinifEslemeSqlField(conn, "ETICARET_SINIF_KAT2", "sSinifKodu5", "cat2")
            Dim cat3Field As String = GetSinifEslemeSqlField(conn, "ETICARET_SINIF_KAT3", "sSinifKodu6", "cat3")
            Dim cat4Field As String = GetSinifEslemeSqlField(conn, "ETICARET_SINIF_KAT4", "sSinifKodu7", "cat4")
            Dim cat5Field As String = GetSinifEslemeSqlField(conn, "ETICARET_SINIF_KAT5", "sSinifKodu8", "cat5")
            Dim etiket1Field As String = GetSinifEslemeSqlField(conn, "ETICARET_SINIF_ETIKET1", "sSinifKodu5", "etiket1")
            Dim etiket2Field As String = GetSinifEslemeSqlField(conn, "ETICARET_SINIF_ETIKET2", "sSinifKodu6", "etiket2")
            Dim etiket3Field As String = GetSinifEslemeSqlField(conn, "ETICARET_SINIF_ETIKET3", "sSinifKodu7", "etiket3")

            Dim sql As String = baseSql &
            "," & markaField & "," &
            " " & cat1Field & "," &
            " " & cat2Field & "," &
            " " & cat3Field & "," &
            " " & cat4Field & "," &
            " " & cat5Field & "," &
            " " & etiket1Field & "," &
            " " & etiket2Field & "," &
            " " & etiket3Field & "," &
            " T4.sSEOBaslik," &
            " T4.sMetaDescription," &
            " T4.sKisaAciklama," &
            " T4.sAnahtarKelimeler," &
            " T4.nIcerikPuani," &
            " T4.sYikamaTalimati," &
            " T4.sBakimTalimati," &
            " T4.sGuvenliklUyari," &
            " T5.sUzunNot," &
            " T5.sBedenTablosu," &
            " T5.sOzellikler," &
            " T5.sKullanimTalimati " &
            "FROM [tbStok] AS T1 " &
            "LEFT JOIN [tbKdv] AS T2 ON T2.sKdvTipi=T1.sKdvTipi " &
            "LEFT JOIN [tbStokSinifi] AS T3 ON T3.nStokID=T1.nStokID " &
            "LEFT JOIN [tbStokAIIcerik] AS T4 ON T4.sModel=? " &
            "LEFT JOIN [tbStokUzunNot] AS T5 ON T5.sModel=? " &
            "WHERE T1.sModel = ? AND T1.sRenk = ? AND T1.bWebGoruntule='1' " &
            "ORDER BY T1.nStokID ASC"

            Dim sAciklama As String = ""
            Dim sKisaAdi As String = ""
            Dim nKdvOrani As Decimal = 0D
            Dim fiyatTrendyol As Decimal = 0D
            Dim fiyatHb As Decimal = 0D
            Dim fiyatN11 As Decimal = 0D
            Dim fiyatSite As Decimal = 0D
            Dim alisFiyat As Decimal = 0D
            Dim nEn As Decimal = 0D
            Dim nBoy As Decimal = 0D
            Dim nYukseklik As Decimal = 0D
            Dim nAgirlik As Decimal = 0D
            Dim marka As String = ""
            Dim cat1 As String = ""
            Dim cat2 As String = ""
            Dim cat3 As String = ""
            Dim cat4 As String = ""
            Dim cat5 As String = ""
            Dim etiket1 As String = ""
            Dim etiket2 As String = ""
            Dim etiket3 As String = ""
            Dim sSEOBaslik As String = ""
            Dim sMetaDescription As String = ""
            Dim sUzunNot As String = ""
            Dim firstBarcode As String = ""
            Dim colorName As String = ""

            ' AI İçerik Alanları
            ' SEO: tbStokAIIcerik'ten (sSEOBaslik, sMetaDescription, sKisaAciklama, sAnahtarKelimeler, nIcerikPuani)
            ' İçerik: tbStokUzunNot'tan (sUzunNot, sOzellikler, sBedenTablosu, sKullanimTalimati)
            Dim sKisaAciklamaAI As String = ""
            Dim sOzellikler As String = ""
            Dim sKullanimTalimati As String = ""
            Dim sAnahtarKelimeler As String = ""
            Dim sBedenTablosu As String = ""
            Dim nIcerikPuani As Integer = 0
            ' Yeni alanlar: tbStokAIIcerik'ten
            Dim sYikamaTalimati As String = ""
            Dim sBakimTalimati As String = ""
            Dim sGuvenliklUyari As String = ""

            Dim model As String = ""  ' Veritabanından alınacak

            Using cmd As New OleDb.OleDbCommand(sql, conn)
                ' cleanModel kullanarak JOIN yap (tbStokAIIcerik ve tbStokUzunNot'ta cleanModel formatı kullanılıyor)
                cmd.Parameters.AddWithValue("?", cleanModel)
                cmd.Parameters.AddWithValue("?", cleanModel)
                cmd.Parameters.AddWithValue("?", productModelFromID)
                cmd.Parameters.AddWithValue("?", renk)

                Log("DEBUG", "SendProduct", $"SQL Parametreler - T4.sModel='{cleanModel}', T5.sModel='{cleanModel}', T1.sModel='{productModelFromID}', T1.sRenk='{renk}'")

                Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                    Log("DEBUG", "SendProduct", $"SQL ExecuteReader tamamlandı")

                    If reader.Read() Then
                        Log("DEBUG", "SendProduct", $"reader.Read() = TRUE, kayıt bulundu!")
                        ' VERİTABANINDAN sModel'i al - BU DOĞRU MODEL!
                        model = If(reader("sModel") Is DBNull.Value, productModelFromID, reader("sModel").ToString().Trim())
                        Log("INFO", "SendProduct", $"Veritabanından sModel alındı: {model}")

                        sAciklama = If(reader("sAciklama") Is DBNull.Value, "", reader("sAciklama").ToString().Trim())
                        sKisaAdi = If(reader("sKisaAdi") Is DBNull.Value, "", reader("sKisaAdi").ToString().Trim())
                        etiket1 = If(reader("etiket1") Is DBNull.Value, "", reader("etiket1").ToString().Trim())
                        etiket2 = If(reader("etiket2") Is DBNull.Value, "", reader("etiket2").ToString().Trim())
                        etiket3 = If(reader("etiket3") Is DBNull.Value, "", reader("etiket3").ToString().Trim())
                        sSEOBaslik = If(reader("sSEOBaslik") Is DBNull.Value, "", reader("sSEOBaslik").ToString().Trim())
                        sMetaDescription = If(reader("sMetaDescription") Is DBNull.Value, "", reader("sMetaDescription").ToString().Trim())
                        sUzunNot = If(reader("sUzunNot") Is DBNull.Value, "", reader("sUzunNot").ToString().Trim())

                        ' AI İçerik Alanlarını Oku
                        ' SEO: tbStokAIIcerik'ten | İçerik: tbStokUzunNot'tan
                        Try
                            ' tbStokAIIcerik'ten: SEO alanları
                            sKisaAciklamaAI = If(reader("sKisaAciklama") Is DBNull.Value, "", reader("sKisaAciklama").ToString().Trim())
                            sAnahtarKelimeler = If(reader("sAnahtarKelimeler") Is DBNull.Value, "", reader("sAnahtarKelimeler").ToString().Trim())
                            nIcerikPuani = If(reader("nIcerikPuani") Is DBNull.Value, 0, Convert.ToInt32(reader("nIcerikPuani")))
                            ' Yeni alanlar: tbStokAIIcerik'ten
                            sYikamaTalimati = If(reader("sYikamaTalimati") Is DBNull.Value, "", reader("sYikamaTalimati").ToString().Trim())
                            sBakimTalimati = If(reader("sBakimTalimati") Is DBNull.Value, "", reader("sBakimTalimati").ToString().Trim())
                            sGuvenliklUyari = If(reader("sGuvenliklUyari") Is DBNull.Value, "", reader("sGuvenliklUyari").ToString().Trim())

                            ' tbStokUzunNot'tan: İçerik alanları
                            sOzellikler = If(reader("sOzellikler") Is DBNull.Value, "", reader("sOzellikler").ToString().Trim())
                            sBedenTablosu = If(reader("sBedenTablosu") Is DBNull.Value, "", reader("sBedenTablosu").ToString().Trim())
                            sKullanimTalimati = If(reader("sKullanimTalimati") Is DBNull.Value, "", reader("sKullanimTalimati").ToString().Trim())
                        Catch
                            ' Alanlar yoksa görmezden gel
                        End Try

                        ' DEBUG: AI içerik durumu
                        Log("DEBUG", "SendProduct", $"SEO (tbStokAIIcerik) - sSEOBaslik: {If(String.IsNullOrEmpty(sSEOBaslik), "BOŞ", "DOLU")}, sMetaDescription: {If(String.IsNullOrEmpty(sMetaDescription), "BOŞ", "DOLU")}, sKisaAciklama: {If(String.IsNullOrEmpty(sKisaAciklamaAI), "BOŞ", "DOLU")}")
                        Log("DEBUG", "SendProduct", $"İçerik (tbStokUzunNot) - sUzunNot: {If(String.IsNullOrEmpty(sUzunNot), "BOŞ", "DOLU")}, sOzellikler: {If(String.IsNullOrEmpty(sOzellikler), "BOŞ", "DOLU")}, sBedenTablosu: {If(String.IsNullOrEmpty(sBedenTablosu), "BOŞ", "DOLU")}, Puan: {nIcerikPuani}")
                        Log("DEBUG", "SendProduct", $"Etiketler - etiket1: '{etiket1}', etiket2: '{etiket2}', etiket3: '{etiket3}'")
                        nKdvOrani = If(reader("nKdvOrani") Is DBNull.Value, 0D, Convert.ToDecimal(reader("nKdvOrani")))
                        fiyatTrendyol = If(reader("TRENDYOL_SATIS") Is DBNull.Value, 0D, Convert.ToDecimal(reader("TRENDYOL_SATIS")))
                        fiyatHb = If(reader("HB_SATIS") Is DBNull.Value, 0D, Convert.ToDecimal(reader("HB_SATIS")))
                        fiyatN11 = If(reader("N11_SATIS") Is DBNull.Value, 0D, Convert.ToDecimal(reader("N11_SATIS")))
                        fiyatSite = If(reader("SITE_SATIS") Is DBNull.Value, 0D, Convert.ToDecimal(reader("SITE_SATIS")))
                        alisFiyat = If(reader("ALIS_FIYAT") Is DBNull.Value, 0D, Convert.ToDecimal(reader("ALIS_FIYAT")))
                        nEn = If(reader("nEn") Is DBNull.Value, 0D, Convert.ToDecimal(reader("nEn")))
                        nBoy = If(reader("nBoy") Is DBNull.Value, 0D, Convert.ToDecimal(reader("nBoy")))
                        nYukseklik = If(reader("nYukseklik") Is DBNull.Value, 0D, Convert.ToDecimal(reader("nYukseklik")))
                        nAgirlik = If(reader("nAgirlik") Is DBNull.Value, 0D, Convert.ToDecimal(reader("nAgirlik")))
                        marka = If(reader("marka") Is DBNull.Value, "", reader("marka").ToString().Trim())
                        cat1 = If(reader("cat1") Is DBNull.Value, "", reader("cat1").ToString().Trim())
                        cat2 = If(reader("cat2") Is DBNull.Value, "", reader("cat2").ToString().Trim())
                        cat3 = If(reader("cat3") Is DBNull.Value, "", reader("cat3").ToString().Trim())
                        cat4 = If(reader("cat4") Is DBNull.Value, "", reader("cat4").ToString().Trim())
                        cat5 = If(reader("cat5") Is DBNull.Value, "", reader("cat5").ToString().Trim())
                    Else
                        Log("ERROR", "SendProduct", $"reader.Read() = FALSE! Ürün bulunamadı: productID={id}, productModelFromID={productModelFromID}, renk={renk}")
                        Log("ERROR", "SendProduct", $"SQL: {sql}")
                        Return product
                    End If
                End Using
            End Using

            ' ===== VARYANTLAR: Tüm bedenleri Çek (PHP mantığı) =====
            Dim variants As New List(Of Dictionary(Of String, Object))
            Dim nitelikler As New List(Of Dictionary(Of String, Object))
            Dim totalStock As Integer = 0
            Dim addedCodes As New HashSet(Of String)

            ' Beden değerlerini toplamak için (unique)
            Dim bedenSet As New HashSet(Of String)

            Dim variantSql As String =
            "SELECT " &
            " T1.nStokID," &
            " T1.sKodu," &
            " T1.sBeden," &
            " T1.sRenk," &
            " T2.sBarkod," &
            " T3.sRenkAdi," &
            " (SELECT lFiyat FROM tbStokFiyati WHERE nStokID=T1.nStokID AND sFiyatTipi='" & seciliFiyatTipi & "') AS varyantFiyat," &
            " (SELECT ISNULL(SUM(lGirisMiktar1 - lCikisMiktar1), 0) " &
            "  FROM tbStokFisiDetayi " &
            "  WHERE nStokID=T1.nStokID AND sDepo=?) AS stok " &
            "FROM [tbStok] AS T1 " &
            "LEFT JOIN tbStokBarkodu AS T2 ON T2.nStokID=T1.nStokID AND T2.nKisim=0 " &
            "LEFT JOIN tbRenk AS T3 ON T3.sRenk=T1.sRenk " &
            "WHERE T1.sModel = ? AND (T1.sRenk = ? OR (? = '' AND (T1.sRenk IS NULL OR T1.sRenk = ''))) AND T1.bWebGoruntule='1' " &
            "ORDER BY T1.sKodu ASC"

            Using varCmd As New OleDb.OleDbCommand(variantSql, conn)
                varCmd.Parameters.AddWithValue("?", userDepo)  ' Depo parametresi (stok sorgusu için)
                varCmd.Parameters.AddWithValue("?", model)
                varCmd.Parameters.AddWithValue("?", renk)
                varCmd.Parameters.AddWithValue("?", renk)  ' Renk boşsa NULL/boş kontrol için
                Log("DEBUG", "SendProduct", $"Varyant sorgusu başlatılıyor: sModel='{model}', sRenk='{renk}', sDepo='{userDepo}'")

                ' Önce kaç varyant olduğunu kontrol et (bWebGoruntule filtresi dahil)
                Dim countSql As String = "SELECT COUNT(*) FROM tbStok WHERE sModel = ? AND (sRenk = ? OR (? = '' AND (sRenk IS NULL OR sRenk = ''))) AND bWebGoruntule='1'"
                Using countCmd As New OleDb.OleDbCommand(countSql, conn)
                    countCmd.Parameters.AddWithValue("?", model)
                    countCmd.Parameters.AddWithValue("?", renk)
                    countCmd.Parameters.AddWithValue("?", renk)
                    Dim dbCount As Integer = Convert.ToInt32(countCmd.ExecuteScalar())
                    Log("DEBUG", "SendProduct", $"Veritabanında bWebGoruntule=1 olan varyant sayısı: {dbCount}")
                End Using

                ' bWebGoruntule=0 olan varyantları da kontrol et
                Dim countAllSql As String = "SELECT COUNT(*) FROM tbStok WHERE sModel = ? AND (sRenk = ? OR (? = '' AND (sRenk IS NULL OR sRenk = '')))"
                Using countAllCmd As New OleDb.OleDbCommand(countAllSql, conn)
                    countAllCmd.Parameters.AddWithValue("?", model)
                    countAllCmd.Parameters.AddWithValue("?", renk)
                    countAllCmd.Parameters.AddWithValue("?", renk)
                    Dim totalDbCount As Integer = Convert.ToInt32(countAllCmd.ExecuteScalar())
                    Log("DEBUG", "SendProduct", $"Veritabanında TOPLAM varyant sayısı (tüm bWebGoruntule): {totalDbCount}")
                End Using

                Using varReader As OleDb.OleDbDataReader = varCmd.ExecuteReader()
                    While varReader.Read()
                        Try
                            Dim sKodu As String = If(varReader("sKodu") Is DBNull.Value, "", varReader("sKodu").ToString().Trim())
                            Dim sBeden As String = If(varReader("sBeden") Is DBNull.Value, "", varReader("sBeden").ToString().Trim())
                            Dim sBarkod As String = If(varReader("sBarkod") Is DBNull.Value, "", varReader("sBarkod").ToString().Trim())
                            Dim sRenkAdi As String = If(varReader("sRenkAdi") Is DBNull.Value, "", varReader("sRenkAdi").ToString().Trim())
                            Dim stok As Integer = If(varReader("stok") Is DBNull.Value, 0, Convert.ToInt32(varReader("stok")))
                            Dim varyantFiyat As Decimal = If(varReader("varyantFiyat") Is DBNull.Value, 0D, Convert.ToDecimal(varReader("varyantFiyat")))

                            ' Mevcudu sifir olan varyantlari atla - webe gonderme
                            If stok <= 0 Then
                                Log("DEBUG", "SendProduct", $"Varyant atlandi (stok=0): sKodu='{sKodu}', sBeden='{sBeden}'")
                                Continue While
                            End If

                            Log("DEBUG", "SendProduct", $"Varyant bulundu: sKodu='{sKodu}', sBeden='{sBeden}', sBarkod='{sBarkod}', stok={stok}")

                            If addedCodes.Contains(sKodu) Then
                                Log("DEBUG", "SendProduct", $"Varyant atlandı (duplicate sKodu): {sKodu}")
                                Continue While
                            End If
                            addedCodes.Add(sKodu)

                            If String.IsNullOrEmpty(firstBarcode) AndAlso Not String.IsNullOrEmpty(sBarkod) Then
                                firstBarcode = sBarkod
                            End If

                            If String.IsNullOrEmpty(colorName) AndAlso Not String.IsNullOrEmpty(sRenkAdi) Then
                                colorName = sRenkAdi
                            End If

                            If stok < 0 Then stok = 0
                            totalStock += stok

                            Dim variantItem As New Dictionary(Of String, Object)
                            ' API dokümantasyonuna göre zorunlu alanlar: value1, quantity, barcode, priceStatus, price
                            variantItem("value1") = sRenkAdi  ' 1. varyant değeri (Renk)
                            variantItem("value2") = sBeden    ' 2. varyant değeri (Beden)
                            variantItem("quantity") = stok    ' Stok miktarı (zorunlu)
                            variantItem("barcode") = sBarkod  ' Varyant barkodu (zorunlu)
                            variantItem("priceStatus") = If(varyantFiyat > 0, True, False)  ' Varyant özel fiyat durumu (zorunlu)
                            variantItem("price") = If(varyantFiyat > 0, varyantFiyat, 0D)  ' Varyant fiyatı (zorunlu)
                            variants.Add(variantItem)

                            Log("DEBUG", "SendProduct", $"Varyant eklendi: sBeden='{sBeden}', barkod='{sBarkod}'")

                            If Not String.IsNullOrEmpty(sBeden) Then
                                ' Her beden için ayrı bir nitelik ekle (API: value tekil string olmalı)
                                Dim nitelikItem As New Dictionary(Of String, Object)
                                nitelikItem("name") = "Beden"
                                nitelikItem("value") = sBeden.Trim()  ' API: "value" (tekil string)
                                ' Aynı beden daha önce eklenmemişse ekle
                                If Not bedenSet.Contains(sBeden.Trim()) Then
                                    bedenSet.Add(sBeden.Trim())
                                    nitelikler.Add(nitelikItem)
                                End If
                            End If
                        Catch ex As Exception
                            Log("ERROR", "SendProduct", $"Varyant hatası: {ex.Message}")
                        End Try
                    End While
                End Using
            End Using

            ' Beden sıralaması (PHP mantığı: XS, S, M, L, XL)
            variants = ReOrderVariants(variants, "XL")
            variants = ReOrderVariants(variants, "L")
            variants = ReOrderVariants(variants, "M")
            variants = ReOrderVariants(variants, "S")
            variants = ReOrderVariants(variants, "XS")
            variants = ReOrderVariants(variants, "L-XL")
            variants = ReOrderVariants(variants, "S-M")

            ' ===== VARYANTSIZ ÜRÜN KONTROLÜ =====
            ' Eğer varyant bulunamadıysa, ana ürün stoğunu kullan
            If variants.Count = 0 Then
                Log("INFO", "SendProduct", $"Varyant bulunamadı, ana ürün stoğu alınıyor: {model}__{renk}")

                Dim mainStockSql As String =
                    "SELECT T1.nStokID, T1.sKodu, T2.sBarkod, " &
                    "(SELECT ISNULL(SUM(lGirisMiktar1 - lCikisMiktar1), 0) FROM tbStokFisiDetayi WHERE nStokID=T1.nStokID AND sDepo=?) AS stok " &
                    "FROM tbStok AS T1 " &
                    "LEFT JOIN tbStokBarkodu AS T2 ON T2.nStokID=T1.nStokID AND T2.nKisim=0 " &
                    "WHERE T1.sModel = ? AND (T1.sRenk = ? OR T1.sRenk IS NULL OR T1.sRenk = '') AND T1.bWebGoruntule='1'"

                Using mainCmd As New OleDb.OleDbCommand(mainStockSql, conn)
                    mainCmd.Parameters.AddWithValue("?", userDepo)
                    mainCmd.Parameters.AddWithValue("?", model)
                    mainCmd.Parameters.AddWithValue("?", renk)

                    Using mainReader As OleDb.OleDbDataReader = mainCmd.ExecuteReader()
                        If mainReader.Read() Then
                            Dim mainStok As Integer = If(mainReader("stok") Is DBNull.Value, 0, Convert.ToInt32(mainReader("stok")))
                            Dim mainBarkod As String = If(mainReader("sBarkod") Is DBNull.Value, "", mainReader("sBarkod").ToString().Trim())

                            If mainStok < 0 Then mainStok = 0
                            totalStock = mainStok

                            If String.IsNullOrEmpty(firstBarcode) AndAlso Not String.IsNullOrEmpty(mainBarkod) Then
                                firstBarcode = mainBarkod
                            End If

                            Dim singleVariant As New Dictionary(Of String, Object)
                            singleVariant("value1") = If(Not String.IsNullOrEmpty(colorName), colorName, "Standart")
                            singleVariant("value2") = ""
                            singleVariant("quantity") = mainStok
                            singleVariant("barcode") = mainBarkod
                            singleVariant("priceStatus") = False
                            singleVariant("price") = 0D
                            variants.Add(singleVariant)

                            Log("INFO", "SendProduct", $"Ana ürün stoğu eklendi: stok={mainStok}, barkod={mainBarkod}")
                        Else
                            Log("WARNING", "SendProduct", $"Ana ürün de bulunamadı: {model}__{renk}")
                        End If
                    End Using
                End Using
            End If


            ' ===== GROUPS: Aynı modelin diğer renkleri (PHP mantığı) =====
            Dim groups As New List(Of Dictionary(Of String, Object))
            Dim groupSql As String =
            "SELECT T1.sModel, T1.sRenk, T2.sRenkAdi " &
            "FROM [tbStok] AS T1 " &
            "LEFT JOIN tbRenk AS T2 ON T2.sRenk=T1.sRenk " &
            "WHERE T1.bWebGoruntule='1' AND T1.bWebTavsiye=1 AND T1.sModel = ? " &
            "GROUP BY T1.sModel, T1.sRenk, T2.sRenkAdi " &
            "ORDER BY T1.sModel DESC"

            Using grpCmd As New OleDb.OleDbCommand(groupSql, conn)
                grpCmd.Parameters.AddWithValue("?", model)
                Using grpReader As OleDb.OleDbDataReader = grpCmd.ExecuteReader()
                    While grpReader.Read()
                        Try
                            Dim grpModel As String = If(grpReader("sModel") Is DBNull.Value, "", grpReader("sModel").ToString().Trim())
                            Dim grpRenk As String = If(grpReader("sRenk") Is DBNull.Value, "", grpReader("sRenk").ToString().Trim())
                            Dim grpRenkAdi As String = If(grpReader("sRenkAdi") Is DBNull.Value, "", grpReader("sRenkAdi").ToString().Trim())

                            Dim groupItem As New Dictionary(Of String, Object)
                            groupItem("group") = "Renk"
                            groupItem("code") = grpModel & "__" & grpRenk
                            groupItem("label") = grpRenkAdi
                            groups.Add(groupItem)
                        Catch ex As Exception
                            Log("ERROR", "SendProduct", $"Group hatası: {ex.Message}")
                        End Try
                    End While
                End Using
            End Using

            ' ===== RESiMLER: tbStokResim'den R2 URL'lerini Çek =====
            ' Önce renk bazlı ara, bulamazsa sadece model bazlı ara (varyansız ürünler için)
            Dim images As New List(Of String)

            ' İlk olarak renk bazlı sorgula
            Dim imageSql As String =
            "SELECT nSira, MIN(yol) AS yol " &
            "FROM tbStokResim " &
            "WHERE sModel = ? AND sRenk = ? AND yol IS NOT NULL AND yol <> '' AND nSira BETWEEN 1 AND 5 " &
            "GROUP BY nSira " &
            "ORDER BY nSira"

            Using imgCmd As New OleDb.OleDbCommand(imageSql, conn)
                imgCmd.Parameters.AddWithValue("?", model)
                imgCmd.Parameters.AddWithValue("?", renk)
                Using imgReader As OleDb.OleDbDataReader = imgCmd.ExecuteReader()
                    While imgReader.Read()
                        Try
                            If Not imgReader.IsDBNull(imgReader.GetOrdinal("yol")) Then
                                Dim imgUrl As String = imgReader("yol").ToString().Trim()
                                If Not String.IsNullOrEmpty(imgUrl) AndAlso imgUrl <> "." AndAlso imgUrl.StartsWith("http") Then
                                    images.Add(imgUrl)
                                    Log("DEBUG", "SendProduct", $"Resim eklendi (renk bazlı): nSira={imgReader("nSira")}, URL={imgUrl}")
                                End If
                            End If
                        Catch ex As Exception
                            Log("WARNING", "SendProduct", $"Resim okuma hatası: {ex.Message}")
                        End Try
                    End While
                End Using
            End Using

            ' Renk bazlı resim bulunamadıysa, sadece model bazlı ara (varyansız ürünler için)
            If images.Count = 0 Then
                Log("INFO", "SendProduct", $"Renk bazlı resim bulunamadı, model bazlı aranıyor: {model}")

                Dim imageSqlNoColor As String =
                "SELECT nSira, MIN(yol) AS yol " &
                "FROM tbStokResim " &
                "WHERE sModel = ? AND (sRenk IS NULL OR sRenk = '') AND yol IS NOT NULL AND yol <> '' AND nSira BETWEEN 1 AND 5 " &
                "GROUP BY nSira " &
                "ORDER BY nSira"

                Using imgCmdNoColor As New OleDb.OleDbCommand(imageSqlNoColor, conn)
                    imgCmdNoColor.Parameters.AddWithValue("?", model)
                    Using imgReaderNoColor As OleDb.OleDbDataReader = imgCmdNoColor.ExecuteReader()
                        While imgReaderNoColor.Read()
                            Try
                                If Not imgReaderNoColor.IsDBNull(imgReaderNoColor.GetOrdinal("yol")) Then
                                    Dim imgUrl As String = imgReaderNoColor("yol").ToString().Trim()
                                    If Not String.IsNullOrEmpty(imgUrl) AndAlso imgUrl <> "." AndAlso imgUrl.StartsWith("http") Then
                                        images.Add(imgUrl)
                                        Log("DEBUG", "SendProduct", $"Resim eklendi (model bazlı): nSira={imgReaderNoColor("nSira")}, URL={imgUrl}")
                                    End If
                                End If
                            Catch ex As Exception
                                Log("WARNING", "SendProduct", $"Resim okuma hatası (model bazlı): {ex.Message}")
                            End Try
                        End While
                    End Using
                End Using
            End If

            ' Hala resim bulunamadıysa, sadece model ile tüm resimleri ara
            If images.Count = 0 Then
                Log("INFO", "SendProduct", $"Model bazlı resim de bulunamadı, tüm model resimleri aranıyor: {model}")

                Dim imageSqlAll As String =
                "SELECT TOP 5 nSira, yol " &
                "FROM tbStokResim " &
                "WHERE sModel = ? AND yol IS NOT NULL AND yol <> '' " &
                "ORDER BY nSira"

                Using imgCmdAll As New OleDb.OleDbCommand(imageSqlAll, conn)
                    imgCmdAll.Parameters.AddWithValue("?", model)
                    Using imgReaderAll As OleDb.OleDbDataReader = imgCmdAll.ExecuteReader()
                        While imgReaderAll.Read()
                            Try
                                If Not imgReaderAll.IsDBNull(imgReaderAll.GetOrdinal("yol")) Then
                                    Dim imgUrl As String = imgReaderAll("yol").ToString().Trim()
                                    If Not String.IsNullOrEmpty(imgUrl) AndAlso imgUrl <> "." AndAlso imgUrl.StartsWith("http") Then
                                        images.Add(imgUrl)
                                        Log("DEBUG", "SendProduct", $"Resim eklendi (tüm model): nSira={imgReaderAll("nSira")}, URL={imgUrl}")
                                    End If
                                End If
                            Catch ex As Exception
                                Log("WARNING", "SendProduct", $"Resim okuma hatası (tüm model): {ex.Message}")
                            End Try
                        End While
                    End Using
                End Using
            End If

            Log("INFO", "SendProduct", $"Model={model}, Renk={renk} için {images.Count} adet resim bulundu")

            ' ===== ÜRÜN VERiLERiNi DOLDUR (PHP formatında) =====
            product("code") = model & "__" & renk
            product("currency") = "TL"  ' API dokümantasyonunda currency zorunlu
            product("barcode") = If(String.IsNullOrEmpty(firstBarcode), model, firstBarcode)
            product("quantity") = totalStock  ' API dokümantasyonunda quantity zorunlu
            product("taxRate") = CInt(nKdvOrani).ToString()  ' API dokümantasyonunda taxRate STRING olmalı
            product("price") = fiyatSite  ' API dokümantasyonunda price ZORUNLU!
            product("salePrice") = fiyatSite  ' API: Satış fiyatı
            product("listPrice") = fiyatTrendyol  ' API: Market fiyatı
            product("buyPrice") = alisFiyat  ' API: Alış fiyatı

            ' ===== MUKERRER KONTROLU: Barkod bazli web kontrolu =====
            ' Her urun gonderilmeden once web'de var mi kontrol et
            Dim productBarcode As String = If(String.IsNullOrEmpty(firstBarcode), model, firstBarcode)
            If Not String.IsNullOrEmpty(productBarcode) Then
                Dim webdeVar As Boolean = KontrolEtUrunWebdeVar(productBarcode)
                If webdeVar Then
                    Log("INFO", "SendProduct", $"GUNCELLEME: {id} (Barkod: {productBarcode}) web'de mevcut - guncellenecek")
                    product("_webdeVar") = True

                    ' Web'de var ama Products tablosunda yoksa ekle (status=1: zaten gonderilmis)
                    Try
                        Dim checkCmd As New OleDb.OleDbCommand("SELECT COUNT(*) FROM Products WHERE productID = ?", conn)
                        checkCmd.Parameters.AddWithValue("?", id)
                        Dim existsInProducts As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                        If existsInProducts = 0 Then
                            Dim insertCmd As New OleDb.OleDbCommand(
                                "INSERT INTO Products (productID, status, updated_at) VALUES (?, '1', GETDATE())", conn)
                            insertCmd.Parameters.AddWithValue("?", id)
                            insertCmd.ExecuteNonQuery()
                            Log("INFO", "SendProduct", $"Products tablosuna eklendi (status=1): {id}")
                        End If
                    Catch exProd As Exception
                        Log("WARNING", "SendProduct", $"Products tablosu kontrolu hatasi: {exProd.Message}")
                    End Try
                Else
                    Log("INFO", "SendProduct", $"YENI URUN: {id} (Barkod: {productBarcode}) web'de yok - eklenecek")
                    product("_webdeVar") = False
                End If
            End If


            ' ===== CHECKBOX KONTROLLÜ VERİ GÖNDERİMİ =====
            ' Ayarları VERİTABANINDAN oku (Thread-safe)
            Dim tumunuGonder As Boolean = GetAyarBool("GONDERIM_TUMUNU", True)
            Dim markaGonder As Boolean = GetAyarBool("GONDERIM_MARKA", True)
            Dim kategoriGonder As Boolean = GetAyarBool("GONDERIM_KATEGORI", True)
            Dim desiGonder As Boolean = GetAyarBool("GONDERIM_DESI", True)
            Dim uzunAciklamaGonder As Boolean = GetAyarBool("GONDERIM_UZUN_ACIKLAMA", True)
            Dim kisaAciklamaGonder As Boolean = GetAyarBool("GONDERIM_KISA_ACIKLAMA", True)
            Dim seoGonder As Boolean = GetAyarBool("GONDERIM_SEO", True)
            Dim resimGonderAyar As Boolean = GetAyarBool("SENKRON_RESIM_GONDER", True)
            Dim pazaryeriFiyatlariGonder As Boolean = GetAyarBool("GONDERIM_PAZARYERI_FIYAT", False)

            ' MARKA: chkMarkaGonder veya chkTumunuGonder
            If tumunuGonder OrElse markaGonder Then
                If Not String.IsNullOrEmpty(marka) Then
                    product("brand") = marka
                End If
            End If

            ' DEBUG: Marka ve kategori bilgilerini logla
            Log("DEBUG", "SendProduct", $"📦 Ürün: {model} - Marka: '{marka}'")
            Log("DEBUG", "SendProduct", $"📁 Kategoriler: Cat1: '{cat1}', Cat2: '{cat2}', Cat3: '{cat3}', Cat4: '{cat4}', Cat5: '{cat5}'")

            ' PAZARYERI FİYATLARI: veritabanından okundu
            ' (pazaryeriFiyatlariGonder zaten yukarıda tanımlandı)
            Dim marketplacePrices As New List(Of Dictionary(Of String, Object))

            If pazaryeriFiyatlariGonder Then
                ' Her pazaryerine kendi fiyatını gönder
                If fiyatTrendyol > 0 Then
                    marketplacePrices.Add(New Dictionary(Of String, Object) From {{"type", "ty"}, {"currency", "TL"}, {"price", fiyatTrendyol}})
                End If
                If fiyatHb > 0 Then
                    marketplacePrices.Add(New Dictionary(Of String, Object) From {{"type", "hb"}, {"currency", "TL"}, {"price", fiyatHb}})
                End If
                If fiyatN11 > 0 Then
                    marketplacePrices.Add(New Dictionary(Of String, Object) From {{"type", "n11"}, {"currency", "TL"}, {"price", fiyatN11}})
                End If
                Log("DEBUG", "SendProduct", $"Pazaryeri fiyatları: TY={fiyatTrendyol}, HB={fiyatHb}, N11={fiyatN11}")
            Else
                ' Tüm pazaryerlerine webp (site) fiyatını gönder
                If fiyatSite > 0 Then
                    marketplacePrices.Add(New Dictionary(Of String, Object) From {{"type", "ty"}, {"currency", "TL"}, {"price", fiyatSite}})
                    marketplacePrices.Add(New Dictionary(Of String, Object) From {{"type", "hb"}, {"currency", "TL"}, {"price", fiyatSite}})
                    marketplacePrices.Add(New Dictionary(Of String, Object) From {{"type", "n11"}, {"currency", "TL"}, {"price", fiyatSite}})
                    Log("DEBUG", "SendProduct", $"Tüm pazaryerlerine site fiyatı gönderiliyor: {fiyatSite}")
                End If
            End If

            If marketplacePrices.Count > 0 Then
                product("marketplacePrices") = marketplacePrices
            End If
            product("name") = sAciklama & " - " & colorName

            ' Description: tbStok.sAciklama kullan
            Dim descriptionText As String = sAciklama
            If Not String.IsNullOrWhiteSpace(descriptionText) Then
                product("description") = descriptionText
            Else
                ' Eğer hiÇ aÇıklama yoksa marka ve model kullan
                product("description") = marka & " " & model & " - " & colorName
            End If

            ' KATEGORİLER: kategoriGonder veya tumunuGonder
            ' TEKRARLANAN KATEGORİLERİ ATLA - aynı değer birden fazla kategoriye yazılmışsa sadece ilkini gönder
            If tumunuGonder OrElse kategoriGonder Then
                Dim gonderilmisKategoriler As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
                Dim kategoriIndex As Integer = 1

                ' Tüm kategorileri sırayla kontrol et, tekrarlamayanları gönder
                Dim tumKategoriler() As String = {cat1, cat2, cat3, cat4, cat5}
                For Each kat As String In tumKategoriler
                    If Not String.IsNullOrEmpty(kat) AndAlso Not gonderilmisKategoriler.Contains(kat.Trim()) Then
                        gonderilmisKategoriler.Add(kat.Trim())
                        product("category" & kategoriIndex.ToString()) = kat.Trim()
                        kategoriIndex += 1
                    End If
                Next
            End If

            ' ===== VARYANTSIZ ÜRÜN KONTROLÜ =====
            ' Eğer varyant yoksa (renk/beden yok), variants array'i gönderme - sadece quantity gönder
            Dim hasRealVariants As Boolean = False

            If variants.Count > 0 Then
                ' Varyant var mı kontrol et - sadece "Standart" değilse gerçek varyant var
                For Each v As Dictionary(Of String, Object) In variants
                    Dim val1 As String = If(v.ContainsKey("value1"), v("value1").ToString(), "")
                    Dim val2 As String = If(v.ContainsKey("value2"), v("value2").ToString(), "")
                    If (Not String.IsNullOrEmpty(val1) AndAlso val1 <> "Standart") OrElse Not String.IsNullOrEmpty(val2) Then
                        hasRealVariants = True
                        Exit For
                    End If
                Next
            End If

            If hasRealVariants Then
                ' Gerçek varyantlar var - variants array'i gönder
                product("variants") = variants
                Log("INFO", "SendProduct", $"Varyantlı ürün: {variants.Count} varyant gönderiliyor")
            Else
                ' Varyant yok - variants array'i GÖNDERME, sadece quantity kullan
                ' API dokümantasyonuna göre varyansız ürünlerde variants gönderilmemeli
                Log("INFO", "SendProduct", $"Varyansız ürün: variants gönderilmiyor, quantity={totalStock}")
            End If

            product("attributes") = nitelikler
            product("groups") = groups

            ' DEBUG: Attributes logla
            Log("DEBUG", "SendProduct", $"productID={id}, attributes sayısı={nitelikler.Count}")
            If nitelikler.Count > 0 Then
                For Each attr As Dictionary(Of String, Object) In nitelikler
                    Dim attrName As String = If(attr.ContainsKey("name"), attr("name").ToString, "?")
                    Dim attrValue As String = If(attr.ContainsKey("value"), attr("value").ToString, "?")
                    Log("DEBUG", "SendProduct", $"  - Attribute: name={attrName}, value={attrValue}")
                Next
            Else
                Log("WARNING", "SendProduct", $"productID={id} için hiç attribute bulunamadı!")
            End If

            ' ===== DESİ HESAPLAMA (En x Boy x Yükseklik / 3000) =====
            ' Desi = Hacimsel ağırlık, eğer gerçek ağırlık daha büyükse o kullanılır
            Dim desiHacimsel As Decimal = 0D
            If nEn > 0 AndAlso nBoy > 0 AndAlso nYukseklik > 0 Then
                desiHacimsel = (nEn * nBoy * nYukseklik) / 3000D
            End If
            ' DESİ/AĞIRLIK: desiGonder veya tumunuGonder
            If tumunuGonder OrElse desiGonder Then
                Dim desi As Decimal = Math.Max(desiHacimsel, nAgirlik)
                If desi > 0 Then
                    product("desi") = Math.Round(desi, 2)
                    Log("INFO", "SendProduct", $"Desi hesaplandı: {Math.Round(desi, 2)} (Hacimsel: {Math.Round(desiHacimsel, 2)}, Ağırlık: {nAgirlik})")
                End If
            End If

            ' ===== VARYANT İSİMLERİ =====
            product("variant1Name") = "Renk"
            product("variant2Name") = "Beden"

            ' UZUN AÇIKLAMA: uzunAciklamaGonder veya tumunuGonder
            If tumunuGonder OrElse uzunAciklamaGonder Then
                ' ===== KAPSAMLI AÇIKLAMA OLUŞTURMA (longDescription) =====
                ' Tüm içerik tbStokUzunNot'tan: sUzunNot + sOzellikler + sKullanimTalimati + sBedenTablosu
                Dim longDescriptionBuilder As New System.Text.StringBuilder()

                ' 1. Ana Açıklama (tbStokUzunNot.sUzunNot)
                If Not String.IsNullOrWhiteSpace(sUzunNot) Then
                    longDescriptionBuilder.AppendLine(sUzunNot.Trim())
                    longDescriptionBuilder.AppendLine()
                End If

                ' 2. Ürün Özellikleri (tbStokUzunNot.sOzellikler)
                If Not String.IsNullOrWhiteSpace(sOzellikler) Then
                    longDescriptionBuilder.AppendLine("<div class=""product-features"">")
                    longDescriptionBuilder.AppendLine("<h3>✨ Ürün Özellikleri</h3>")
                    longDescriptionBuilder.AppendLine(sOzellikler.Trim())
                    longDescriptionBuilder.AppendLine("</div>")
                    longDescriptionBuilder.AppendLine()
                End If

                ' 3. Bakım/Kullanım Talimatları (tbStokUzunNot.sKullanimTalimati)
                If Not String.IsNullOrWhiteSpace(sKullanimTalimati) Then
                    longDescriptionBuilder.AppendLine("<div class=""care-instructions"">")
                    longDescriptionBuilder.AppendLine("<h3>🧺 Bakım Talimatları</h3>")
                    longDescriptionBuilder.AppendLine(sKullanimTalimati.Trim())
                    longDescriptionBuilder.AppendLine("</div>")
                    longDescriptionBuilder.AppendLine()
                End If

                ' 4. Yıkama Talimatı (tbStokAIIcerik.sYikamaTalimati)
                If Not String.IsNullOrWhiteSpace(sYikamaTalimati) Then
                    longDescriptionBuilder.AppendLine("<div class=""washing-instructions"">")
                    longDescriptionBuilder.AppendLine("<h3>🧼 Yıkama Talimatları</h3>")
                    longDescriptionBuilder.AppendLine(sYikamaTalimati.Trim())
                    longDescriptionBuilder.AppendLine("</div>")
                    longDescriptionBuilder.AppendLine()
                End If

                ' 5. Bakım Talimatı (tbStokAIIcerik.sBakimTalimati)
                If Not String.IsNullOrWhiteSpace(sBakimTalimati) Then
                    longDescriptionBuilder.AppendLine("<div class=""maintenance-instructions"">")
                    longDescriptionBuilder.AppendLine("<h3>🔧 Saklama ve Bakım</h3>")
                    longDescriptionBuilder.AppendLine(sBakimTalimati.Trim())
                    longDescriptionBuilder.AppendLine("</div>")
                    longDescriptionBuilder.AppendLine()
                End If

                ' 6. Güvenlik Uyarısı (tbStokAIIcerik.sGuvenliklUyari)
                If Not String.IsNullOrWhiteSpace(sGuvenliklUyari) Then
                    longDescriptionBuilder.AppendLine("<div class=""safety-warning"">")
                    longDescriptionBuilder.AppendLine("<h3>⚠️ Güvenlik Uyarıları</h3>")
                    longDescriptionBuilder.AppendLine(sGuvenliklUyari.Trim())
                    longDescriptionBuilder.AppendLine("</div>")
                    longDescriptionBuilder.AppendLine()
                End If

                ' 7. Beden Tablosu (tbStokUzunNot.sBedenTablosu)
                ' NOT: Züccaciye, Elektronik, Kozmetik, Mutfak ürünleri için beden tablosu GÖNDERİLMEZ
                If Not String.IsNullOrWhiteSpace(sBedenTablosu) Then
                    ' Kategori bazlı sektör kontrolü
                    Dim kategoriBilgisi As String = (cat1 & " " & cat2 & " " & cat3 & " " & sAciklama).ToLower()
                    Dim bedenTablosuGonder As Boolean = True

                    ' Züccaciye/Mutfak/Cam/Elektronik/Kozmetik kategorileri için beden tablosu GÖNDERME
                    If kategoriBilgisi.Contains("züccaciye") OrElse kategoriBilgisi.Contains("zuccaciye") OrElse
                       kategoriBilgisi.Contains("mutfak") OrElse kategoriBilgisi.Contains("tabak") OrElse
                       kategoriBilgisi.Contains("bardak") OrElse kategoriBilgisi.Contains("tencere") OrElse
                       kategoriBilgisi.Contains("cam") OrElse kategoriBilgisi.Contains("porselen") OrElse
                       kategoriBilgisi.Contains("seramik") OrElse kategoriBilgisi.Contains("elektronik") OrElse
                       kategoriBilgisi.Contains("kozmetik") OrElse kategoriBilgisi.Contains("servis") OrElse
                       kategoriBilgisi.Contains("fincan") OrElse kategoriBilgisi.Contains("kase") OrElse
                       kategoriBilgisi.Contains("tepsi") OrElse kategoriBilgisi.Contains("kavanoz") Then
                        bedenTablosuGonder = False
                        Log("INFO", "SendProduct", $"Beden tablosu atlandı - Kategori: {cat1} (züccaciye/mutfak/elektronik)")
                    End If

                    If bedenTablosuGonder Then
                        longDescriptionBuilder.AppendLine("<div class=""size-chart"">")
                        longDescriptionBuilder.AppendLine(sBedenTablosu.Trim())
                        longDescriptionBuilder.AppendLine("</div>")
                    End If
                End If

                ' longDescription'ı ayarla
                Dim finalLongDescription As String = longDescriptionBuilder.ToString().Trim()
                If Not String.IsNullOrWhiteSpace(finalLongDescription) Then
                    product("longDescription") = finalLongDescription
                    Log("INFO", "SendProduct", $"longDescription eklendi ({finalLongDescription.Length} karakter)")
                End If
            End If

            ' KISA AÇIKLAMA: kisaAciklamaGonder veya tumunuGonder
            If tumunuGonder OrElse kisaAciklamaGonder Then
                ' ===== KISA AÇIKLAMA (shortDescription) =====
                ' Öncelik: AI Kısa Açıklama (tbStokAIIcerik) > sKisaAdi
                If Not String.IsNullOrWhiteSpace(sKisaAciklamaAI) Then
                    product("shortDescription") = sKisaAciklamaAI.Trim()
                    Log("INFO", "SendProduct", "shortDescription eklendi (AI)")
                ElseIf Not String.IsNullOrWhiteSpace(sKisaAdi) Then
                    product("shortDescription") = sKisaAdi.Trim()
                    Log("INFO", "SendProduct", "shortDescription eklendi (sKisaAdi)")
                End If
            End If

            ' SEO BİLGİLERİ: seoGonder veya tumunuGonder
            If tumunuGonder OrElse seoGonder Then
                ' ===== SEO BİLGİLERİ (tbStokAIIcerik tablosundan) =====
                ' SEO Title
                If Not String.IsNullOrWhiteSpace(sSEOBaslik) Then
                    product("seoTitle") = sSEOBaslik.Trim()
                    Log("INFO", "SendProduct", "seoTitle eklendi (AI)")
                End If

                ' SEO Description (Meta Description)
                If Not String.IsNullOrWhiteSpace(sMetaDescription) Then
                    product("seoDescription") = sMetaDescription.Trim()
                    Log("INFO", "SendProduct", "seoDescription eklendi (AI)")
                End If

                ' ===== ETİKETLER / ANAHTAR KELİMELER =====
                Dim etiketler As New List(Of String)

                ' Önce AI anahtar kelimelerini ekle (varsa)
                If Not String.IsNullOrWhiteSpace(sAnahtarKelimeler) Then
                    Dim aiKeywords As String() = sAnahtarKelimeler.Split({","c, ";"c}, StringSplitOptions.RemoveEmptyEntries)
                    For Each kw As String In aiKeywords
                        If Not String.IsNullOrWhiteSpace(kw) Then etiketler.Add(kw.Trim())
                    Next
                End If

                ' Sonra sınıf etiketlerini ekle
                If Not String.IsNullOrWhiteSpace(etiket1) AndAlso Not etiketler.Contains(etiket1.Trim()) Then etiketler.Add(etiket1.Trim())
                If Not String.IsNullOrWhiteSpace(etiket2) AndAlso Not etiketler.Contains(etiket2.Trim()) Then etiketler.Add(etiket2.Trim())
                If Not String.IsNullOrWhiteSpace(etiket3) AndAlso Not etiketler.Contains(etiket3.Trim()) Then etiketler.Add(etiket3.Trim())

                If etiketler.Count > 0 Then
                    Dim tagsString As String = String.Join(", ", etiketler)
                    product("seoKeywords") = tagsString
                    Log("INFO", "SendProduct", $"seoKeywords eklendi: {etiketler.Count} adet ({tagsString.Substring(0, Math.Min(50, tagsString.Length))}...)")
                End If
            End If

            ' İçerik Puanını logla
            If nIcerikPuani > 0 Then
                Log("INFO", "SendProduct", $"📊 AI İçerik Puanı: {nIcerikPuani}/100")
            End If

            ' RESİMLER: resimGonderAyar veya tumunuGonder
            If tumunuGonder OrElse resimGonderAyar Then
                ' Resim URL'leri (API dokümantasyonuna göre imageUrl formatında)
                If images.Count > 0 Then
                    Dim imageObjects As New List(Of Dictionary(Of String, Object))
                    For Each imgUrl As String In images
                        imageObjects.Add(New Dictionary(Of String, Object) From {{"imageUrl", imgUrl}})
                    Next
                    product("images") = imageObjects
                    Log("INFO", "SendProduct", $"{images.Count} adet resim bulundu")
                Else
                    ' Varsayılan resim ekleme (opsiyonel)
                    Dim defaultImage As New List(Of Dictionary(Of String, Object))
                    defaultImage.Add(New Dictionary(Of String, Object) From {{"imageUrl", "https://www.erentrend.com/default-image.jpg"}})
                    product("images") = defaultImage
                    Log("WARNING", "SendProduct", "Resim bulunamadı, varsayılan kullanılıyor")
                End If
            End If

            Log("INFO", "SendProduct", $"Ürün başarıyla hazırlandı: {model}__{renk}, Toplam stok: {totalStock}, Varyant sayısı: {variants.Count}, Resim sayısı: {images.Count}")

        Catch ex As Exception
            LogError($"SendProduct Error: {ex.Message}")
            Log("ERROR", "SendProduct", $"Hata detayı: {ex.StackTrace}")
        End Try
        Return product
    End Function

    Private Function AsDict(obj As Object) As Dictionary(Of String, Object)
        If obj Is Nothing Then Return New Dictionary(Of String, Object)
        If TypeOf obj Is Dictionary(Of String, Object) Then Return DirectCast(obj, Dictionary(Of String, Object))
        If TypeOf obj Is JObject Then Return DirectCast(obj, JObject).ToObject(Of Dictionary(Of String, Object))()
        If TypeOf obj Is JToken Then Return DirectCast(obj, JToken).ToObject(Of Dictionary(Of String, Object))()
        If TypeOf obj Is String Then
            Try
                Return JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(CStr(obj))
            Catch
            End Try
        End If
        Return New Dictionary(Of String, Object)
    End Function
    Private Function AsListOfDict(obj As Object) As List(Of Dictionary(Of String, Object))
        If obj Is Nothing Then Return New List(Of Dictionary(Of String, Object))
        If TypeOf obj Is List(Of Dictionary(Of String, Object)) Then Return DirectCast(obj, List(Of Dictionary(Of String, Object)))
        If TypeOf obj Is JArray Then Return DirectCast(obj, JArray).ToObject(Of List(Of Dictionary(Of String, Object)))()
        If TypeOf obj Is JToken Then Return DirectCast(obj, JToken).ToObject(Of List(Of Dictionary(Of String, Object)))()
        If TypeOf obj Is String Then
            Try
                Return JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, Object)))(CStr(obj))
            Catch
            End Try
        End If
        Return New List(Of Dictionary(Of String, Object))
    End Function

    ' ===== YENİ API FONKSİYONLARI (QUKA API v2.2.2) =====

    ''' <summary>

    ''' <summary>
    ''' Urunun web'de olup olmadigini kontrol eder, yoksa product/save ile ekler
    ''' </summary>
    Private Function EnsureProductExistsOnWeb(productID As String, conn As OleDb.OleDbConnection) As Boolean
        Try
            ' Oncelikle urunun web'e daha once gonderilip gonderilmedigini kontrol et
            ' Products tablosunda status=1 ise daha once basariyla gonderilmis demektir
            Dim checkCmd As New OleDb.OleDbCommand("SELECT status FROM Products WHERE productID = ?", conn)
            checkCmd.Parameters.AddWithValue("?", productID)
            Dim statusObj As Object = checkCmd.ExecuteScalar()

            If statusObj IsNot Nothing AndAlso Not IsDBNull(statusObj) Then
                Dim status As String = statusObj.ToString()
                If status = "1" Then
                    ' Urun daha once basariyla gonderilmis, web'de var
                    Return True
                End If
            End If

            ' Urun web'de yok veya daha once gonderilemedi, simdi gonder
            Log("INFO", "EnsureProductExistsOnWeb", $"Urun web'de yok, product/save ile ekleniyor: {productID}")

            Dim product As Dictionary(Of String, Object) = SendProduct(productID, conn)

            If product IsNot Nothing AndAlso product.Count > 0 Then
                ' product/save ile gonder
                Dim data As New Dictionary(Of String, Object)
                Dim products As New List(Of Dictionary(Of String, Object))
                products.Add(product)
                data("products") = products

                Dim result As String = SendToApi("product/save", data)

                If result.Contains("SUCCESS") OrElse result.Contains("OK") OrElse result.Contains("PRODUCTSAVE") Then
                    ' Basariyla eklendi, status'u 1 yap
                    Dim updateCmd As New OleDb.OleDbCommand("UPDATE Products SET status = '1', updated_at = GETDATE() WHERE productID = ?", conn)
                    updateCmd.Parameters.AddWithValue("?", productID)
                    updateCmd.ExecuteNonQuery()

                    Log("SUCCESS", "EnsureProductExistsOnWeb", $"Urun web'e eklendi: {productID}")
                    Return True
                Else
                    Log("WARNING", "EnsureProductExistsOnWeb", $"Urun eklenemedi: {productID}, Yanit: {result}")
                    Return False
                End If
            Else
                Log("WARNING", "EnsureProductExistsOnWeb", $"Urun bilgisi alinamadi: {productID}")
                Return False
            End If

        Catch ex As Exception
            Log("ERROR", "EnsureProductExistsOnWeb", $"Hata: {ex.Message}, productID={productID}")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Stok guncellemesi oncesi tum urunlerin web'de oldugundan emin olur
    ''' </summary>
    Private Sub EnsureAllProductsExistOnWeb(productIDs As List(Of String))
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                Dim addedCount As Integer = 0
                Dim existCount As Integer = 0

                For Each productID As String In productIDs
                    If EnsureProductExistsOnWeb(productID, conn) Then
                        existCount += 1
                    Else
                        ' Eklenemedi, yine de devam et
                    End If
                Next

                Log("INFO", "EnsureAllProductsExistOnWeb", $"Kontrol tamamlandi. Web'de mevcut/eklenen: {existCount}/{productIDs.Count}")
            End Using
        Catch ex As Exception
            Log("ERROR", "EnsureAllProductsExistOnWeb", $"Hata: {ex.Message}")
        End Try
    End Sub


    ''' Toplu stok güncelleme - product/updateStocks endpoint'i
    ''' Tek seferde 30 ürüne kadar stok güncelleyebilir
    ''' </summary>
    Public Function UpdateStocks(stockUpdates As List(Of Dictionary(Of String, Object))) As Boolean
        Try
            If stockUpdates Is Nothing OrElse stockUpdates.Count = 0 Then
                Log("WARNING", "UpdateStocks", "Güncellenecek stok bulunamadı")
                Return False
            End If

            ' *** WEB KONTROLU: Urunlerin web'de oldugundan emin ol ***
            Dim productIDs As New List(Of String)()
            For Each item As Dictionary(Of String, Object) In stockUpdates
                If item.ContainsKey("productID") Then
                    productIDs.Add(item("productID").ToString())
                End If
            Next
            If productIDs.Count > 0 Then
                Log("INFO", "UpdateStocks", $"Web'de urun kontrolu yapiliyor: {productIDs.Count} urun")
                EnsureAllProductsExistOnWeb(productIDs)
            End If

            ' API limiti: Maksimum 30 ürün
            Dim batchSize As Integer = 30
            Dim totalBatches As Integer = CInt(Math.Ceiling(stockUpdates.Count / CDbl(batchSize)))
            Dim successCount As Integer = 0
            Dim errorCount As Integer = 0
            Dim totalSent As Integer = 0

            For batchIndex As Integer = 0 To totalBatches - 1
                Dim batch = stockUpdates.Skip(batchIndex * batchSize).Take(batchSize).ToList()

                Dim postData As New Dictionary(Of String, Object)
                postData("stocks") = batch

                Log("INFO", "UpdateStocks", $"Batch {batchIndex + 1}/{totalBatches} gönderiliyor ({batch.Count} ürün)")

                ' ===== GÖNDERİM MODU: API veya PHP seçimine göre =====
                Dim result As String = SendToApi("product/updateStocks", postData)

                If Not String.IsNullOrEmpty(result) Then
                    Try
                        Dim response As Dictionary(Of String, Object) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(result)
                        If response IsNot Nothing Then
                            ' API yanıt formatı: {"code":"PRODUCTUPDATESTOCK001","result":"stocks"}
                            Dim code As String = If(response.ContainsKey("code"), response("code").ToString(), "")

                            ' PRODUCTUPDATESTOCK001 = Başarılı
                            If code = "PRODUCTUPDATESTOCK001" Then
                                successCount += batch.Count
                                totalSent += batch.Count
                            ElseIf response.ContainsKey("stocks") Then
                                ' Detaylı yanıt varsa her ürünü kontrol et
                                Dim stocks As List(Of Dictionary(Of String, Object)) = AsListOfDict(response("stocks"))
                                For Each stockItem As Dictionary(Of String, Object) In stocks
                                    Dim status As Integer = If(stockItem.ContainsKey("status"), CInt(stockItem("status")), 0)
                                    If status = 1 Then
                                        successCount += 1
                                    Else
                                        errorCount += 1
                                        Dim errCode As String = If(stockItem.ContainsKey("code"), stockItem("code").ToString(), "?")
                                        Log("WARNING", "UpdateStocks", "Stok güncellenemedi: " & errCode & ", status=" & status.ToString())
                                    End If
                                Next
                                totalSent += stocks.Count
                            Else
                                ' Başka bir başarılı kod
                                successCount += batch.Count
                                totalSent += batch.Count
                            End If
                        End If
                    Catch ex As Exception
                        Log("ERROR", "UpdateStocks", "Response parse hatası: " & ex.Message)
                        errorCount += batch.Count
                    End Try
                Else
                    errorCount += batch.Count
                End If
            Next

            Log("INFO", "UpdateStocks", $"Stok güncelleme tamamlandı. Toplam: {totalSent}, Başarılı: {successCount}, Hatalı: {errorCount}")
            Return errorCount = 0

        Catch ex As Exception
            Log("ERROR", "UpdateStocks", $"Hata: {ex.Message}")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Veritabanından değişen stokları alıp toplu güncelleme yapar
    ''' Değişiklik algılama: tbStokFisiDetayi.dteSonUpdateTarihi son senkronizasyon tarihinden büyük olanlar
    ''' </summary>
    Public Sub SyncChangedStocks()
        Try
            Log("INFO", "SyncChangedStocks", "Değişen stoklar kontrol ediliyor...")

            Dim stockUpdates As New List(Of Dictionary(Of String, Object))

            ' Son senkronizasyon tarihini kullan, ilk çalışmada son 1 saat
            Dim syncDate As DateTime = lastStockSyncDate
            If syncDate = DateTime.MinValue Then
                syncDate = DateTime.Now.AddHours(-1)
            End If
            Log("INFO", "SyncChangedStocks", $"Son senkronizasyon tarihi: {syncDate:yyyy-MM-dd HH:mm:ss}")

            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()

                ' Stok hareketi olan ürünleri bul (dteSonUpdateTarihi son senkronizasyondan sonra değişenler)
                Dim sql As String =
                "SELECT DISTINCT T2.sModel, T2.sRenk, T1.nStokID, T3.sBarkod, " &
                " (SELECT ISNULL(SUM(lGirisMiktar1 - lCikisMiktar1), 0) FROM tbStokFisiDetayi WHERE nStokID=T1.nStokID AND sDepo=?) AS stok " &
                "FROM tbStokFisiDetayi AS T1 " &
                "LEFT JOIN tbStok AS T2 ON T2.nStokID = T1.nStokID " &
                "LEFT JOIN tbStokBarkodu AS T3 ON T3.nStokID = T1.nStokID AND T3.nKisim=0 " &
                "WHERE T1.dteSonUpdateTarihi >= ? AND T2.bWebGoruntule='1' " &
                "ORDER BY T2.sModel, T2.sRenk"

                Using cmd As New OleDb.OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("?", sDepo)
                    cmd.Parameters.AddWithValue("?", syncDate)

                    Dim currentCode As String = ""
                    Dim currentVariants As New List(Of Dictionary(Of String, Object))

                    Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim sModel As String = If(reader("sModel") Is DBNull.Value, "", reader("sModel").ToString().Trim())
                            Dim sRenk As String = If(reader("sRenk") Is DBNull.Value, "", reader("sRenk").ToString().Trim())
                            Dim sBarkod As String = If(reader("sBarkod") Is DBNull.Value, "", reader("sBarkod").ToString().Trim())
                            Dim stok As Integer = If(reader("stok") Is DBNull.Value, 0, Convert.ToInt32(reader("stok")))
                            If stok < 0 Then stok = 0

                            Dim code As String = sModel & "__" & sRenk

                            If code <> currentCode AndAlso currentCode <> "" Then
                                ' Önceki ürünü kaydet
                                Dim stockItem As New Dictionary(Of String, Object)
                                stockItem("code") = currentCode
                                stockItem("variants") = currentVariants
                                stockUpdates.Add(stockItem)
                                currentVariants = New List(Of Dictionary(Of String, Object))
                            End If

                            currentCode = code

                            If Not String.IsNullOrEmpty(sBarkod) Then
                                Dim variantItem As New Dictionary(Of String, Object)
                                variantItem("barcode") = sBarkod
                                variantItem("quantity") = stok
                                currentVariants.Add(variantItem)
                            End If
                        End While

                        ' Son ürünü de ekle
                        If currentCode <> "" AndAlso currentVariants.Count > 0 Then
                            Dim stockItem As New Dictionary(Of String, Object)
                            stockItem("code") = currentCode
                            stockItem("variants") = currentVariants
                            stockUpdates.Add(stockItem)
                        End If
                    End Using
                End Using
            End Using

            If stockUpdates.Count > 0 Then
                Log("INFO", "SyncChangedStocks", $"📊 {stockUpdates.Count} ürün için stok güncellemesi yapılacak")
                SafeUpdateUI(Sub() lblDurum.Text = $"Durum: 0/{stockUpdates.Count} stok güncelleniyor")
                Dim success As Boolean = UpdateStocks(stockUpdates)
                If success Then
                    ' Başarılı senkronizasyon sonrası tarihi güncelle
                    lastStockSyncDate = DateTime.Now
                    Log("INFO", "SyncChangedStocks", $"✅ Stok güncellemesi tamamlandı: {lastStockSyncDate:yyyy-MM-dd HH:mm:ss}")
                    SafeUpdateUI(Sub() lblDurum.Text = $"Durum: {stockUpdates.Count} ürün stok güncellendi")
                End If
            Else
                Log("INFO", "SyncChangedStocks", "Güncellenecek stok değişikliği bulunamadı")
                SafeUpdateUI(Sub() lblDurum.Text = "Durum: Stok değişikliği yok")
                ' Değişiklik olmasa bile tarihi güncelle (boşa tekrar kontrol etmesin)
                lastStockSyncDate = DateTime.Now
            End If

        Catch ex As Exception
            Log("ERROR", "SyncChangedStocks", $"Hata: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Toplu fiyat güncelleme - product/updatePrices endpoint'i
    ''' Tek seferde 15 ürüne kadar fiyat güncelleyebilir
    ''' </summary>
    Public Function UpdatePrices(priceUpdates As List(Of Dictionary(Of String, Object))) As Boolean
        Try
            If priceUpdates Is Nothing OrElse priceUpdates.Count = 0 Then
                Log("WARNING", "UpdatePrices", "Güncellenecek fiyat bulunamadı")
                Return False
            End If

            ' *** WEB KONTROLU: Urunlerin web'de oldugundan emin ol ***
            Dim priceProductIDs As New List(Of String)()
            For Each item As Dictionary(Of String, Object) In priceUpdates
                If item.ContainsKey("productID") Then
                    priceProductIDs.Add(item("productID").ToString())
                End If
            Next
            If priceProductIDs.Count > 0 Then
                Log("INFO", "UpdatePrices", $"Web'de urun kontrolu yapiliyor: {priceProductIDs.Count} urun")
                EnsureAllProductsExistOnWeb(priceProductIDs)
            End If

            ' API limiti: Maksimum 15 ürün
            Dim batchSize As Integer = 15
            Dim totalBatches As Integer = CInt(Math.Ceiling(priceUpdates.Count / CDbl(batchSize)))
            Dim successCount As Integer = 0
            Dim errorCount As Integer = 0
            Dim totalSent As Integer = 0

            For batchIndex As Integer = 0 To totalBatches - 1
                Dim batch = priceUpdates.Skip(batchIndex * batchSize).Take(batchSize).ToList()

                Dim postData As New Dictionary(Of String, Object)
                postData("prices") = batch

                Log("INFO", "UpdatePrices", $"Batch {batchIndex + 1}/{totalBatches} gönderiliyor ({batch.Count} ürün)")

                ' ===== GÖNDERİM MODU: API veya PHP seçimine göre =====
                Dim result As String = SendToApi("product/updatePrices", postData)

                If Not String.IsNullOrEmpty(result) Then
                    Try
                        Dim response As Dictionary(Of String, Object) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(result)
                        If response IsNot Nothing Then
                            ' API yanıt formatı: {"code":"PRODUCTUPDATEPRICE001","result":"products"}
                            Dim code As String = If(response.ContainsKey("code"), response("code").ToString(), "")

                            ' PRODUCTUPDATEPRICE001 = Başarılı
                            If code = "PRODUCTUPDATEPRICE001" Then
                                successCount += batch.Count
                                totalSent += batch.Count
                            ElseIf response.ContainsKey("products") Then
                                ' Detaylı yanıt varsa her ürünü kontrol et
                                Dim products As List(Of Dictionary(Of String, Object)) = AsListOfDict(response("products"))
                                For Each prod As Dictionary(Of String, Object) In products
                                    Dim status As Integer = If(prod.ContainsKey("status"), CInt(prod("status")), 0)
                                    If status = 1 Then
                                        successCount += 1
                                    Else
                                        errorCount += 1
                                        Dim errCode As String = If(prod.ContainsKey("code"), prod("code").ToString(), "?")
                                        Log("WARNING", "UpdatePrices", "Fiyat güncellenemedi: " & errCode & ", status=" & status.ToString())
                                    End If
                                Next
                                totalSent += products.Count
                            Else
                                ' Başka bir başarılı kod
                                successCount += batch.Count
                                totalSent += batch.Count
                            End If
                        End If
                    Catch ex As Exception
                        Log("ERROR", "UpdatePrices", $"Response parse hatası: {ex.Message}")
                        errorCount += batch.Count
                    End Try
                Else
                    errorCount += batch.Count
                End If
            Next

            Log("INFO", "UpdatePrices", $"Fiyat güncelleme tamamlandı. Toplam: {totalSent}, Başarılı: {successCount}, Hatalı: {errorCount}")
            Return errorCount = 0

        Catch ex As Exception
            Log("ERROR", "UpdatePrices", $"Hata: {ex.Message}")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Veritabanından değişen fiyatları alıp toplu güncelleme yapar
    ''' Değişiklik algılama: tbStokFiyati.dteKayitTarihi son senkronizasyon tarihinden büyük olanlar
    ''' </summary>
    Public Sub SyncChangedPrices()
        Try
            Log("INFO", "SyncChangedPrices", "Değişen fiyatlar kontrol ediliyor...")

            Dim priceUpdates As New List(Of Dictionary(Of String, Object))

            ' Son senkronizasyon tarihini kullan, ilk çalışmada son 1 saat
            Dim syncDate As DateTime = lastPriceSyncDate
            If syncDate = DateTime.MinValue Then
                syncDate = DateTime.Now.AddHours(-1)
            End If
            Log("INFO", "SyncChangedPrices", $"Son senkronizasyon tarihi: {syncDate:yyyy-MM-dd HH:mm:ss}")

            ' Seçilen fiyat tipini al
            Dim seciliFiyatTipi As String = GetSeciliFiyatTipi()

            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()

                ' Fiyatı değişen ürünleri bul (dteKayitTarihi son senkronizasyondan sonra değişenler)
                Dim sql As String =
                "SELECT DISTINCT T2.sModel, T2.sRenk, T1.nStokID, T3.sBarkod, " &
                " (SELECT lFiyat FROM tbStokFiyati WHERE nStokID=T1.nStokID AND sFiyatTipi='" & seciliFiyatTipi & "') AS siteFiyat, " &
                " (SELECT lFiyat FROM tbStokFiyati WHERE nStokID=T1.nStokID AND sFiyatTipi='webl') AS listeFiyat, " &
                " (SELECT lFiyat FROM tbStokFiyati WHERE nStokID=T1.nStokID AND sFiyatTipi='2') AS trendyolFiyat, " &
                " (SELECT lFiyat FROM tbStokFiyati WHERE nStokID=T1.nStokID AND sFiyatTipi='3') AS hbFiyat, " &
                " (SELECT lFiyat FROM tbStokFiyati WHERE nStokID=T1.nStokID AND sFiyatTipi='4') AS n11Fiyat " &
                "FROM tbStokFiyati AS T1 " &
                "LEFT JOIN tbStok AS T2 ON T2.nStokID = T1.nStokID " &
                "LEFT JOIN tbStokBarkodu AS T3 ON T3.nStokID = T1.nStokID AND T3.nKisim=0 " &
                "WHERE T1.dteKayitTarihi >= ? AND T2.bWebGoruntule='1' " &
                "ORDER BY T2.sModel, T2.sRenk"

                Using cmd As New OleDb.OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("?", syncDate)

                    Dim processedCodes As New HashSet(Of String)

                    Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim sModel As String = If(reader("sModel") Is DBNull.Value, "", reader("sModel").ToString().Trim())
                            Dim sRenk As String = If(reader("sRenk") Is DBNull.Value, "", reader("sRenk").ToString().Trim())
                            Dim siteFiyat As Decimal = If(reader("siteFiyat") Is DBNull.Value, 0D, Convert.ToDecimal(reader("siteFiyat")))
                            Dim listeFiyat As Decimal = If(reader("listeFiyat") Is DBNull.Value, 0D, Convert.ToDecimal(reader("listeFiyat")))
                            Dim trendyolFiyat As Decimal = If(reader("trendyolFiyat") Is DBNull.Value, 0D, Convert.ToDecimal(reader("trendyolFiyat")))
                            Dim hbFiyat As Decimal = If(reader("hbFiyat") Is DBNull.Value, 0D, Convert.ToDecimal(reader("hbFiyat")))
                            Dim n11Fiyat As Decimal = If(reader("n11Fiyat") Is DBNull.Value, 0D, Convert.ToDecimal(reader("n11Fiyat")))

                            Dim code As String = sModel & "__" & sRenk
                            If processedCodes.Contains(code) Then Continue While
                            processedCodes.Add(code)

                            If siteFiyat <= 0 Then Continue While

                            Dim priceItem As New Dictionary(Of String, Object)
                            priceItem("code") = code
                            priceItem("currency") = "TL"
                            priceItem("salePrice") = siteFiyat
                            If listeFiyat > 0 Then priceItem("listPrice") = listeFiyat

                            ' Pazaryeri fiyatları
                            Dim marketplacePrices As New List(Of Dictionary(Of String, Object))
                            If trendyolFiyat > 0 Then
                                marketplacePrices.Add(New Dictionary(Of String, Object) From {
                                    {"type", "ty"}, {"currency", "TL"}, {"price", trendyolFiyat}
                                })
                            End If
                            If hbFiyat > 0 Then
                                marketplacePrices.Add(New Dictionary(Of String, Object) From {
                                    {"type", "hb"}, {"currency", "TL"}, {"price", hbFiyat}
                                })
                            End If
                            If n11Fiyat > 0 Then
                                marketplacePrices.Add(New Dictionary(Of String, Object) From {
                                    {"type", "n11"}, {"currency", "TL"}, {"price", n11Fiyat}
                                })
                            End If
                            If marketplacePrices.Count > 0 Then
                                priceItem("marketplacePrices") = marketplacePrices
                            End If

                            priceUpdates.Add(priceItem)
                        End While
                    End Using
                End Using
            End Using

            If priceUpdates.Count > 0 Then
                Log("INFO", "SyncChangedPrices", $"📊 {priceUpdates.Count} ürün için fiyat güncellemesi yapılacak")
                SafeUpdateUI(Sub() lblDurum.Text = $"Durum: 0/{priceUpdates.Count} fiyat güncelleniyor")
                Dim success As Boolean = UpdatePrices(priceUpdates)
                If success Then
                    ' Başarılı senkronizasyon sonrası tarihi güncelle
                    lastPriceSyncDate = DateTime.Now
                    Log("INFO", "SyncChangedPrices", $"✅ Fiyat güncellemesi tamamlandı: {lastPriceSyncDate:yyyy-MM-dd HH:mm:ss}")
                    SafeUpdateUI(Sub() lblDurum.Text = $"Durum: {priceUpdates.Count} ürün fiyatı güncellendi")
                End If
            Else
                Log("INFO", "SyncChangedPrices", "Güncellenecek fiyat değişikliği bulunamadı")
                SafeUpdateUI(Sub() lblDurum.Text = "Durum: Fiyat değişikliği yok")
                ' Değişiklik olmasa bile tarihi güncelle (boşa tekrar kontrol etmesin)
                lastPriceSyncDate = DateTime.Now
            End If

        Catch ex As Exception
            Log("ERROR", "SyncChangedPrices", $"Hata: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Varyant güncelleme - Mevcut ürünlerin varyantlarını tekrar gönderir
    ''' </summary>
    Public Sub SyncChangedVariants()
        Try
            Log("INFO", "SyncChangedVariants", "Varyant güncelleme başlatılıyor...")

            Dim updatedCount As Integer = 0

            ' Status=1 olan (daha önce gönderilmiş) tüm ürünleri al ve tekrar gönder
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()

                ' Products tablosunda status=1 olan ürünleri status=0 yap
                Dim updateCmd As New OleDb.OleDbCommand("UPDATE Products SET status = '0', updated_at = GETDATE() WHERE status = '1'", conn)
                updatedCount = updateCmd.ExecuteNonQuery()

                Log("INFO", "SyncChangedVariants", $"📊 {updatedCount} ürün varyant güncellemesi için işaretlendi (status=0)")
                SafeUpdateUI(Sub() lblDurum.Text = $"Durum: {updatedCount} ürün varyant için hazırlanıyor")
            End Using

            ' ProductSync3 çağır - status=0 olanları gönderecek (tam ürün bilgisiyle)
            If updatedCount > 0 Then
                ProductSync3()
            Else
                SafeUpdateUI(Sub() lblDurum.Text = "Durum: Güncellenecek varyant yok")
            End If

        Catch ex As Exception
            Log("ERROR", "SyncChangedVariants", $"Hata: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Kategori güncelleme - Mevcut ürünlerin kategorilerini tekrar gönderir
    ''' </summary>
    Public Sub SyncChangedCategories()
        Try
            Log("INFO", "SyncChangedCategories", "Kategori güncelleme başlatılıyor...")

            Dim updatedCount As Integer = 0

            ' Status=1 olan (daha önce gönderilmiş) tüm ürünleri al ve tekrar gönder
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()

                ' Products tablosunda status=1 olan ürünleri status=0 yap
                Dim updateCmd As New OleDb.OleDbCommand("UPDATE Products SET status = '0', updated_at = GETDATE() WHERE status = '1'", conn)
                updatedCount = updateCmd.ExecuteNonQuery()

                Log("INFO", "SyncChangedCategories", $"📊 {updatedCount} ürün kategori güncellemesi için işaretlendi (status=0)")
                SafeUpdateUI(Sub() lblDurum.Text = $"Durum: {updatedCount} ürün kategori için hazırlanıyor")
            End Using

            ' ProductSync3 çağır - status=0 olanları gönderecek (tam ürün bilgisiyle)
            If updatedCount > 0 Then
                ProductSync3()
            Else
                SafeUpdateUI(Sub() lblDurum.Text = "Durum: Güncellenecek kategori yok")
            End If

        Catch ex As Exception
            Log("ERROR", "SyncChangedCategories", $"Hata: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Tarih aralığı ile sipariş çekme butonu click event
    ''' </summary>
    Private Sub BtnTarihliSiparisCek_Click(sender As Object, e As EventArgs)
        Try
            Dim baslangic As DateTime = dtpBaslangic.Value.Date
            Dim bitis As DateTime = dtpBitis.Value.Date.AddDays(1).AddSeconds(-1) ' Bitiş gününün sonuna kadar

            If baslangic > bitis Then
                MessageBox.Show("Başlangıç tarihi bitiş tarihinden büyük olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Tarih aralığı kontrolü - çok geniş aralık uyarısı
            Dim gunFarki As Integer = (bitis.Date - baslangic.Date).Days
            If gunFarki > 30 Then
                Dim uyariSonuc As DialogResult = MessageBox.Show(
                    $"Seçilen tarih aralığı {gunFarki} gün!" & vbCrLf & vbCrLf &
                    "Çok geniş tarih aralıkları uzun sürebilir ve sistem yükünü artırabilir." & vbCrLf &
                    "Devam etmek istiyor musunuz?",
                    "Geniş Tarih Aralığı Uyarısı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning)
                If uyariSonuc = DialogResult.No Then Return
            End If

            ' Status seçimini al
            Dim selectedStatus As String = ""
            Dim statusAciklama As String = ""
            Select Case cmbSiparisStatus.SelectedIndex
                Case 0 ' Tümü
                    selectedStatus = "0,1,2"
                    statusAciklama = "Tümü (Yeni, Onaylandı, Hazırlanıyor)"
                Case 1 ' 0 - Yeni
                    selectedStatus = "0"
                    statusAciklama = "Sadece Yeni Siparişler"
                Case 2 ' 1 - Onaylandı
                    selectedStatus = "1"
                    statusAciklama = "Sadece Onaylanmış Siparişler"
                Case 3 ' 2 - Hazırlanıyor
                    selectedStatus = "2"
                    statusAciklama = "Sadece Hazırlanan Siparişler"
                Case Else
                    selectedStatus = "0,1,2"
                    statusAciklama = "Tümü"
            End Select

            ' Kullanıcı onayı al
            Dim onay As DialogResult = MessageBox.Show(
                $"Sipariş çekme işlemi başlatılacak:" & vbCrLf & vbCrLf &
                $"📅 Başlangıç: {baslangic:dd.MM.yyyy}" & vbCrLf &
                $"📅 Bitiş: {bitis:dd.MM.yyyy}" & vbCrLf &
                $"📋 Durum: {statusAciklama}" & vbCrLf & vbCrLf &
                "⚠️ Mükerrer kontrolleri aktif - Zaten işlenmiş siparişler atlanacak." & vbCrLf & vbCrLf &
                "Devam etmek istiyor musunuz?",
                "Sipariş Çekme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)

            If onay = DialogResult.No Then Return

            Log("INFO", "TarihliSiparisCek", $"Tarih aralığı sipariş çekme başlatılıyor: {baslangic:yyyy-MM-dd} - {bitis:yyyy-MM-dd}, Status: {selectedStatus}")
            SafeUpdateUI(Sub() lblDurum.Text = $"Durum: {baslangic:dd.MM.yyyy} - {bitis:dd.MM.yyyy} arası siparişler çekiliyor...")

            ' Butonu devre dışı bırak
            btnTarihliSiparisCek.Enabled = False
            btnTarihliSiparisCek.Text = "İşleniyor..."

            ' Arka planda çalıştır
            Dim bgWorker As New System.ComponentModel.BackgroundWorker()
            AddHandler bgWorker.DoWork, Sub(s, args)
                                            FetchOrdersByDateRange(baslangic, bitis, selectedStatus)
                                        End Sub
            AddHandler bgWorker.RunWorkerCompleted, Sub(s, args)
                                                        SafeUpdateUI(Sub()
                                                                         lblDurum.Text = "Durum: Tarihli sipariş çekme tamamlandı"
                                                                         btnTarihliSiparisCek.Enabled = True
                                                                         btnTarihliSiparisCek.Text = "Tarihe Gore Siparis Cek"
                                                                     End Sub)
                                                    End Sub
            bgWorker.RunWorkerAsync()

        Catch ex As Exception
            Log("ERROR", "BtnTarihliSiparisCek_Click", $"Hata: {ex.Message}")
            MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnTarihliSiparisCek.Enabled = True
            btnTarihliSiparisCek.Text = "Tarihe Gore Siparis Cek"
        End Try
    End Sub

    ''' <summary>
    ''' Tarih aralığına göre siparişleri çeker ve mükerrer kontrolü yapar
    ''' MÜKERRER KONTROL KATMANLARI:
    ''' 1. IsDuplicateOrder - tbStokFisiAciklamasi.sAciklama3 ve orders tablosu kontrolü
    ''' 2. IsOrderAlreadyProcessed - Ek kontrol katmanı
    ''' 3. AddOrder içindeki kontrol - Son güvenlik katmanı
    ''' </summary>
    Private Sub FetchOrdersByDateRange(baslangic As DateTime, bitis As DateTime, statusValues As String)
        Try
            ' ÖNCELİKLE: API ayarlarının yüklü olduğundan emin ol
            If String.IsNullOrEmpty(LAGlobalAddress) Then
                Log("WARNING", "FetchOrdersByDateRange", "LAGlobalAddress boş, config yükleniyor...")
                LoadConfig()
            End If

            ' Hala boşsa hata ver
            If String.IsNullOrEmpty(LAGlobalAddress) Then
                Log("ERROR", "FetchOrdersByDateRange", "❌ API adresi (LAGlobalAddress) yüklenemedi! Lütfen ayarları kontrol edin.")
                SafeUpdateUI(Sub() MessageBox.Show("API adresi yüklenemedi! Lütfen ayarları kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error))
                Return
            End If

            Log("DEBUG", "FetchOrdersByDateRange", $"API Adresi: {LAGlobalAddress}")
            Log("DEBUG", "FetchOrdersByDateRange", $"API Key: {If(String.IsNullOrEmpty(ApiKey), "BOŞ!", "Mevcut")}")

            Dim totalProcessed As Integer = 0
            Dim successCount As Integer = 0
            Dim skipCount As Integer = 0
            Dim duplicateCount As Integer = 0
            Dim failCount As Integer = 0

            Dim startDateStr As String = baslangic.ToString("yyyy-MM-dd")
            Dim endDateStr As String = bitis.ToString("yyyy-MM-dd")

            ' İşlem başlangıç logu - Detaylı bilgi
            Log("INFO", "FetchOrdersByDateRange", $"")
            Log("INFO", "FetchOrdersByDateRange", $"═══════════════════════════════════════════════════════════")
            Log("INFO", "FetchOrdersByDateRange", $"📅 TARİHLİ SİPARİŞ ÇEKME BAŞLATILDI")
            Log("INFO", "FetchOrdersByDateRange", $"   Başlangıç: {startDateStr}")
            Log("INFO", "FetchOrdersByDateRange", $"   Bitiş: {endDateStr}")
            Log("INFO", "FetchOrdersByDateRange", $"   Status Değerleri: {statusValues}")
            Log("INFO", "FetchOrdersByDateRange", $"   Mükerrer Kontrol: AKTİF (4 katmanlı)")
            Log("INFO", "FetchOrdersByDateRange", $"═══════════════════════════════════════════════════════════")

            ' Progress bar'ı sıfırla
            ResetProgressBars()
            SafeUpdateUI(Sub() lblDurum.Text = "Durum: Siparişler çekiliyor...")

            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()

                ' Her status için ayrı çek
                Dim statusList As String() = statusValues.Split(","c)

                For Each statusValue As String In statusList
                    statusValue = statusValue.Trim()

                    Dim pageStart As Integer = 0
                    Dim pageSize As Integer = 50
                    Dim pageNumber As Integer = 1
                    Dim maxPages As Integer = 100
                    Dim hasMorePages As Boolean = True

                    Log("INFO", "FetchOrdersByDateRange", $"📅 Tarih: {startDateStr} - {endDateStr}, Status: {statusValue}")

                    While hasMorePages AndAlso pageNumber <= maxPages
                        ' API tarih parametreleri - farklı formatlar denenebilir
                        ' Bazı API'ler: startDate, endDate
                        ' Bazı API'ler: start_date, end_date  
                        ' Bazı API'ler: dateFrom, dateTo
                        Dim queryParams As String = $"?pageStart={pageStart}&pageSize={pageSize}&orderBy=id&sort=desc&status={statusValue}&startDate={startDateStr}&endDate={endDateStr}"

                        Log("INFO", "FetchOrdersByDateRange", $"📄 Sayfa {pageNumber} çekiliyor: {queryParams}")
                        Log("DEBUG", "FetchOrdersByDateRange", $"TAM URL: order/lists{queryParams}")
                        SafeUpdateUI(Sub() lblDurum.Text = $"Durum: Status={statusValue}, Sayfa {pageNumber} çekiliyor...")

                        Dim result As String = GetFromApi("order/lists" & queryParams)

                        ' API yanıtını logla (hata ayıklama için)
                        If Not String.IsNullOrEmpty(result) Then
                            Log("DEBUG", "FetchOrdersByDateRange", $"API YANITI (ilk 500 karakter): {If(result.Length > 500, result.Substring(0, 500), result)}")
                        End If

                        If String.IsNullOrEmpty(result) Then
                            Log("WARNING", "FetchOrdersByDateRange", $"Sayfa {pageNumber}: API'den boş yanıt")
                            hasMorePages = False
                            Continue While
                        End If

                        Dim pageOrders As List(Of Dictionary(Of String, Object)) = ParseOrders(result)

                        If pageOrders Is Nothing OrElse pageOrders.Count = 0 Then
                            Log("INFO", "FetchOrdersByDateRange", $"Sayfa {pageNumber}: Sipariş bulunamadı (ParseOrders sonucu boş)")
                            Log("DEBUG", "FetchOrdersByDateRange", $"ParseOrders null mı: {pageOrders Is Nothing}")
                            hasMorePages = False
                        Else
                            Log("INFO", "FetchOrdersByDateRange", $"📄 Sayfa {pageNumber}: {pageOrders.Count} sipariş bulundu")

                            For Each orderSummary As Dictionary(Of String, Object) In pageOrders
                                Try
                                    totalProcessed += 1

                                    ' Toplam sipariş sayısını hesapla (tahmini)
                                    Dim estimatedTotal As Integer = pageOrders.Count * pageNumber

                                    ' Progress bar güncelle - başarılı sayısını da göster
                                    UpdateKlasikProgress(totalProcessed, estimatedTotal, successCount)

                                    Dim orderId As String = ""
                                    Dim orderCode As String = ""
                                    Dim customerName As String = ""

                                    If orderSummary.ContainsKey("id") Then orderId = orderSummary("id").ToString()
                                    If orderSummary.ContainsKey("code") Then orderCode = orderSummary("code").ToString()
                                    If orderSummary.ContainsKey("customerName") Then customerName = orderSummary("customerName").ToString()

                                    ' MÜKERRER KONTROLÜ: sAciklama2 (müşteri) ve sAciklama3 (sipariş no) kontrol et
                                    If IsDuplicateOrder(conn, customerName, orderCode) Then
                                        duplicateCount += 1
                                        Log("DEBUG", "FetchOrdersByDateRange", $"Mükerrer sipariş atlandı: {orderCode} - {customerName}")
                                        Continue For
                                    End If

                                    ' Eski kontrol de yap
                                    If Not String.IsNullOrEmpty(orderId) AndAlso IsOrderAlreadyProcessed(orderId, conn, orderCode) Then
                                        skipCount += 1
                                        Log("DEBUG", "FetchOrdersByDateRange", $"Sipariş zaten işlenmiş: {orderId} ({orderCode})")
                                        Continue For
                                    End If

                                    If Not String.IsNullOrEmpty(orderId) Then
                                        Log("INFO", "FetchOrdersByDateRange", $"🔄 Sipariş işleniyor: {orderId} ({orderCode}) [{totalProcessed}]")
                                        SafeUpdateUI(Sub() lblDurum.Text = $"Durum: {orderId} işleniyor... ({successCount} başarılı, {duplicateCount} mükerrer)")

                                        ' Sipariş detayını çek
                                        Dim orderDetail As Dictionary(Of String, Object) = FetchOrderDetail(orderId)

                                        If orderDetail IsNot Nothing Then
                                            If Not String.IsNullOrEmpty(orderCode) Then
                                                If orderDetail.ContainsKey("order") AndAlso orderDetail("order") IsNot Nothing Then
                                                    Dim orderObj As Dictionary(Of String, Object) = AsDict(orderDetail("order"))
                                                    If orderObj IsNot Nothing AndAlso Not orderObj.ContainsKey("code") Then
                                                        orderObj("code") = orderCode
                                                    End If
                                                End If
                                            End If

                                            Try
                                                ' SON GÜVENLİK KONTROLÜ - AddOrder öncesi tekrar kontrol et
                                                ' Stokların alt üst olmaması için kritik!
                                                If IsDuplicateOrder(conn, customerName, orderCode) Then
                                                    duplicateCount += 1
                                                    Log("WARNING", "FetchOrdersByDateRange", $"⚠️ Son kontrolde mükerrer tespit edildi: {orderCode}")
                                                    Continue For
                                                End If

                                                AddOrder(orderDetail)
                                                successCount += 1
                                                Log("SUCCESS", "FetchOrdersByDateRange", $"✅ Sipariş kaydedildi: {orderId} ({orderCode})")
                                                ' Sayaçları güncelle
                                                UpdateKlasikProgress(totalProcessed, estimatedTotal, successCount)
                                            Catch addEx As Exception
                                                failCount += 1
                                                Log("ERROR", "FetchOrdersByDateRange", $"❌ Kaydetme hatası: {orderId} - {addEx.Message}")
                                            End Try
                                        Else
                                            skipCount += 1
                                            Log("WARNING", "FetchOrdersByDateRange", $"⚠️ Detay alınamadı: {orderId}")
                                        End If

                                        Thread.Sleep(5000)
                                    End If
                                Catch detailEx As Exception
                                    failCount += 1
                                    Log("ERROR", "FetchOrdersByDateRange", $"Hata: {detailEx.Message}")
                                End Try
                            Next

                            If pageOrders.Count < pageSize Then
                                hasMorePages = False
                            Else
                                pageStart += pageSize
                                pageNumber += 1
                                Thread.Sleep(2000)
                            End If
                        End If
                    End While
                Next
            End Using

            ' İşlem sonuç özeti - Detaylı log
            Log("SUCCESS", "FetchOrdersByDateRange", $"")
            Log("SUCCESS", "FetchOrdersByDateRange", $"═══════════════════════════════════════════════════════════")
            Log("SUCCESS", "FetchOrdersByDateRange", $"✅ TARİHLİ SİPARİŞ ÇEKME TAMAMLANDI")
            Log("SUCCESS", "FetchOrdersByDateRange", $"   Toplam Kontrol Edilen: {totalProcessed}")
            Log("SUCCESS", "FetchOrdersByDateRange", $"   Başarılı Kaydedilen: {successCount}")
            Log("SUCCESS", "FetchOrdersByDateRange", $"   Mükerrer (Atlandı): {duplicateCount}")
            Log("SUCCESS", "FetchOrdersByDateRange", $"   Zaten İşlenmiş: {skipCount}")
            Log("SUCCESS", "FetchOrdersByDateRange", $"   Hatalı: {failCount}")
            Log("SUCCESS", "FetchOrdersByDateRange", $"═══════════════════════════════════════════════════════════")

            ' Progress bar'ı tamamla
            UpdateKlasikProgress(totalProcessed, totalProcessed)
            SafeUpdateUI(Sub() lblDurum.Text = $"Durum: Tamamlandı - {successCount} yeni, {duplicateCount} mükerrer, {failCount} hatalı")

            ' Kullanıcıya bilgilendirme mesajı göster
            SafeUpdateUI(Sub()
                             MessageBox.Show(
                                 $"Tarihli sipariş çekme tamamlandı!" & vbCrLf & vbCrLf &
                                 $"Toplam Kontrol: {totalProcessed}" & vbCrLf &
                                 $"Yeni Kaydedilen: {successCount}" & vbCrLf &
                                 $"Mükerrer (Atlandı): {duplicateCount}" & vbCrLf &
                                 $"Zaten İşlenmiş: {skipCount}" & vbCrLf &
                                 $"Hatalı: {failCount}",
                                 "İşlem Tamamlandı",
                                 MessageBoxButtons.OK,
                                 If(failCount > 0, MessageBoxIcon.Warning, MessageBoxIcon.Information))
                         End Sub)

        Catch ex As Exception
            Log("ERROR", "FetchOrdersByDateRange", $"Genel hata: {ex.Message}")
            SafeUpdateUI(Sub() MessageBox.Show($"Sipariş çekme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error))
        End Try
    End Sub

    ''' <summary>
    ''' Mükerrer sipariş kontrolü - Çoklu tablo kontrolü yapar
    ''' 1. tbStokFisiAciklamasi.sAciklama3 = sipariş numarası (TAM EŞLEŞMELİ)
    ''' 2. orders tablosu - ID ve status kontrolü
    ''' Stokların alt üst olmaması için KATKI güvenlik katmanı
    ''' </summary>
    Private Function IsDuplicateOrder(conn As OleDb.OleDbConnection, customerName As String, orderCode As String) As Boolean
        Try
            If String.IsNullOrEmpty(orderCode) Then
                Log("WARNING", "IsDuplicateOrder", "orderCode boş - kontrol atlanıyor")
                Return False
            End If

            ' 1. KONTROL: tbStokFisiAciklamasi tablosunda TAM EŞLEŞME ile sipariş numarası kontrol et
            ' sAciklama3 = sipariş numarası (TY10825278977, HB4305610070 gibi)
            Dim checkSql1 As String = "SELECT COUNT(*) FROM tbStokFisiAciklamasi WHERE sAciklama3 = ?"
            Using checkCmd1 As New OleDb.OleDbCommand(checkSql1, conn)
                checkCmd1.Parameters.AddWithValue("?", orderCode.Trim())
                Dim count1 As Integer = Convert.ToInt32(checkCmd1.ExecuteScalar())
                If count1 > 0 Then
                    Log("DEBUG", "IsDuplicateOrder", $"✅ Mükerrer bulundu (tbStokFisiAciklamasi.sAciklama3): {orderCode}")
                    Return True
                End If
            End Using

            ' 2. KONTROL: Prefix'li varyasyonları da kontrol et (örn: TY10825278977-1, HB4305610070_2)
            ' Bu, aynı siparişin farklı kayıtlarını da yakalar
            Dim checkSql2 As String = "SELECT COUNT(*) FROM tbStokFisiAciklamasi WHERE sAciklama3 LIKE ?"
            Using checkCmd2 As New OleDb.OleDbCommand(checkSql2, conn)
                checkCmd2.Parameters.AddWithValue("?", orderCode.Trim() & "%")
                Dim count2 As Integer = Convert.ToInt32(checkCmd2.ExecuteScalar())
                If count2 > 0 Then
                    Log("DEBUG", "IsDuplicateOrder", $"✅ Mükerrer bulundu (tbStokFisiAciklamasi.sAciklama3 LIKE): {orderCode}%")
                    Return True
                End If
            End Using

            ' 3. KONTROL: orders tablosunda status=1 (işlenmiş) kontrolü - SQL SERVER
            ' Bu tablo web siparişlerinin local durumunu tutar
            Try
                If Not String.IsNullOrEmpty(KeyCode.sConnection) Then
                    Dim sqlConnStr As String = KeyCode.sConnection
                    If sqlConnStr.ToLower().Contains("provider=") Then
                        Dim parts As String() = sqlConnStr.Split(";"c)
                        Dim cleanParts As New List(Of String)
                        For Each part As String In parts
                            If Not part.Trim().ToLower().StartsWith("provider=") Then
                                If Not String.IsNullOrWhiteSpace(part) Then cleanParts.Add(part.Trim())
                            End If
                        Next
                        sqlConnStr = String.Join(";", cleanParts)
                    End If

                    Using sqlConn As New SqlClient.SqlConnection(sqlConnStr)
                        sqlConn.Open()
                        ' sAciklama3 ile kontrol et (HB4606960184, TY123456 gibi)
                        Using checkCmd3 As New SqlClient.SqlCommand("SELECT COUNT(*) FROM orders WHERE sAciklama3 = @orderCode AND status = 1", sqlConn)
                            checkCmd3.Parameters.AddWithValue("@orderCode", orderCode.Trim())
                            Dim count3 As Integer = Convert.ToInt32(checkCmd3.ExecuteScalar())
                            If count3 > 0 Then
                                Log("DEBUG", "IsDuplicateOrder", $"✅ Mükerrer bulundu (orders.sAciklama3): {orderCode}")
                                Return True
                            End If
                        End Using
                    End Using
                End If
            Catch ordersEx As Exception
                Log("DEBUG", "IsDuplicateOrder", $"orders tablosu kontrolü atlandı: {ordersEx.Message}")
            End Try

            ' 4. KONTROL: fis_detay tablosunda sipariş kodu ile kontrol
            ' Bu, sipariş kaydının ürün detaylarının eklenip eklenmediğini kontrol eder
            Try
                Dim checkSql4 As String = "SELECT COUNT(*) FROM fis_detay WHERE fisID = ?"
                Using checkCmd4 As New OleDb.OleDbCommand(checkSql4, conn)
                    checkCmd4.Parameters.AddWithValue("?", orderCode.Trim())
                    Dim count4 As Integer = Convert.ToInt32(checkCmd4.ExecuteScalar())
                    If count4 > 0 Then
                        Log("DEBUG", "IsDuplicateOrder", $"✅ Mükerrer bulundu (fis_detay tablosu): {orderCode}")
                        Return True
                    End If
                End Using
            Catch fisDetayEx As Exception
                ' fis_detay tablosu olmayabilir
                Log("DEBUG", "IsDuplicateOrder", $"fis_detay tablosu kontrolü atlandı: {fisDetayEx.Message}")
            End Try

            Log("DEBUG", "IsDuplicateOrder", $"❌ Mükerrer değil, yeni sipariş: {orderCode}")
            Return False

        Catch ex As Exception
            Log("ERROR", "IsDuplicateOrder", $"Kritik hata: {ex.Message} - GÜVENLİK İÇİN TRUE DÖNDÜRÜLÜYOR")
            ' HATA DURUMUNDA TRUE DÖNDÜR - Stokların alt üst olmaması için
            ' Kullanıcıya mükerrer gibi gösterilsin, manuel kontrol yapsın
            Return True
        End Try
    End Function

    ''' <summary>
    ''' Sipariş kargo bilgisi güncelleme - order/updateShipmentInfo endpoint'i
    ''' </summary>
    Public Function UpdateShipmentInfo(orderCode As String, shipmentBarcode As String, shipmentCode As String,
                                       shipmentFirmName As String, Optional shipmentUrl As String = "") As Boolean
        Try
            If String.IsNullOrEmpty(orderCode) Then
                Log("WARNING", "UpdateShipmentInfo", "Sipariş kodu boş")
                Return False
            End If

            Dim postData As New Dictionary(Of String, Object)
            postData("code") = orderCode

            If Not String.IsNullOrEmpty(shipmentBarcode) Then
                postData("shipmentBarcode") = shipmentBarcode
            End If
            If Not String.IsNullOrEmpty(shipmentCode) Then
                postData("shipmentCode") = shipmentCode
            End If
            If Not String.IsNullOrEmpty(shipmentFirmName) Then
                postData("shipmentFirmName") = shipmentFirmName
            End If
            If Not String.IsNullOrEmpty(shipmentUrl) Then
                postData("shipmentUrl") = shipmentUrl
            End If

            Log("INFO", "UpdateShipmentInfo", $"Kargo bilgisi gönderiliyor: {orderCode}, Firma: {shipmentFirmName}, Takip: {shipmentCode}")

            ' ===== GÖNDERİM MODU: API veya PHP seçimine göre =====
            Dim result As String = SendToApi("order/updateShipmentInfo", postData)

            If Not String.IsNullOrEmpty(result) Then
                Try
                    Dim response = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(result)
                    If response IsNot Nothing Then
                        Dim status As Integer = If(response.ContainsKey("status"), CInt(response("status")), 0)
                        If status = 1 Then
                            Log("INFO", "UpdateShipmentInfo", $"Kargo bilgisi güncellendi: {orderCode}")
                            Return True
                        Else
                            Log("WARNING", "UpdateShipmentInfo", $"Kargo bilgisi güncellenemedi: {orderCode}, status={status}")
                        End If
                    End If
                Catch ex As Exception
                    Log("ERROR", "UpdateShipmentInfo", $"Response parse hatası: {ex.Message}")
                End Try
            End If

            Return False

        Catch ex As Exception
            Log("ERROR", "UpdateShipmentInfo", $"Hata: {ex.Message}")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Benzer ürünleri güncelleme - product/updateSimilars endpoint'i
    ''' </summary>
    Public Function UpdateSimilarProducts(mainProductCode As String, similarProductCodes As List(Of String)) As Boolean
        Try
            If String.IsNullOrEmpty(mainProductCode) OrElse similarProductCodes Is Nothing OrElse similarProductCodes.Count = 0 Then
                Log("WARNING", "UpdateSimilarProducts", "Ürün kodu veya benzer ürünler boş")
                Return False
            End If

            Dim similarProducts As New List(Of Dictionary(Of String, Object))
            For Each codeItem As String In similarProductCodes
                similarProducts.Add(New Dictionary(Of String, Object) From {{"code", codeItem}})
            Next

            Dim productItem As New Dictionary(Of String, Object)
            productItem("code") = mainProductCode
            productItem("similarProducts") = similarProducts

            Dim postData As New Dictionary(Of String, Object)
            postData("products") = New List(Of Dictionary(Of String, Object)) From {productItem}

            Log("INFO", "UpdateSimilarProducts", "Benzer ürünler güncelleniyor: " & mainProductCode & " -> " & similarProductCodes.Count.ToString() & " ürün")

            ' ===== GÖNDERİM MODU: API veya PHP seçimine göre =====
            Dim result As String = SendToApi("product/updateSimilars", postData)

            If Not String.IsNullOrEmpty(result) Then
                Try
                    Dim response = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(result)
                    If response IsNot Nothing AndAlso response.ContainsKey("products") Then
                        Dim products = AsListOfDict(response("products"))
                        If products.Count > 0 Then
                            Dim status As Integer = If(products(0).ContainsKey("status"), CInt(products(0)("status")), 0)
                            If status = 1 Then
                                Log("INFO", "UpdateSimilarProducts", $"Benzer ürünler güncellendi: {mainProductCode}")
                                Return True
                            End If
                        End If
                    End If
                Catch ex As Exception
                    Log("ERROR", "UpdateSimilarProducts", $"Response parse hatası: {ex.Message}")
                End Try
            End If

            Return False

        Catch ex As Exception
            Log("ERROR", "UpdateSimilarProducts", $"Hata: {ex.Message}")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Aynı modelin farklı renklerini benzer ürün olarak ayarlar
    ''' </summary>
    Public Sub SyncSimilarProductsByModel()
        Try
            Log("INFO", "SyncSimilarProductsByModel", "Benzer ürünler (renk varyantları) senkronize ediliyor...")

            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()

                ' Birden fazla rengi olan modelleri bul
                Dim sql As String =
                "SELECT sModel, sRenk FROM tbStok " &
                "WHERE bWebGoruntule='1' AND sModel IN " &
                "(SELECT sModel FROM tbStok WHERE bWebGoruntule='1' GROUP BY sModel HAVING COUNT(DISTINCT sRenk) > 1) " &
                "GROUP BY sModel, sRenk " &
                "ORDER BY sModel, sRenk"

                Dim modelGroups As New Dictionary(Of String, List(Of String))

                Using cmd As New OleDb.OleDbCommand(sql, conn)
                    Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim sModel As String = If(reader("sModel") Is DBNull.Value, "", reader("sModel").ToString().Trim())
                            Dim sRenk As String = If(reader("sRenk") Is DBNull.Value, "", reader("sRenk").ToString().Trim())

                            If String.IsNullOrEmpty(sModel) Then Continue While

                            Dim code As String = sModel & "__" & sRenk

                            If Not modelGroups.ContainsKey(sModel) Then
                                modelGroups(sModel) = New List(Of String)
                            End If
                            modelGroups(sModel).Add(code)
                        End While
                    End Using
                End Using

                ' Her model için benzer ürünleri güncelle
                For Each kvp As KeyValuePair(Of String, List(Of String)) In modelGroups
                    Dim codes As List(Of String) = kvp.Value
                    If codes.Count < 2 Then Continue For

                    For Each mainCode As String In codes
                        Dim similarCodes As New List(Of String)
                        For Each c As String In codes
                            If c <> mainCode Then similarCodes.Add(c)
                        Next
                        UpdateSimilarProducts(mainCode, similarCodes)
                    Next
                Next

                Log("INFO", "SyncSimilarProductsByModel", "Benzer ürün senkronizasyonu tamamlandı. " & modelGroups.Count.ToString() & " model işlendi.")
            End Using

        Catch ex As Exception
            Log("ERROR", "SyncSimilarProductsByModel", "Hata: " & ex.Message)
        End Try
    End Sub

    ' =====================================================
    ' ===== KATEGORİ VE RESİM GÜNCELLEME FONKSİYONLARI =====
    ' product/save endpoint'i ile mevcut ürünlerin kategori ve resimlerini günceller
    ' =====================================================

    ''' <summary>
    ''' Mevcut ürünlerin kategorilerini web'de günceller
    ''' product/save endpoint'i kullanılır
    ''' Sadece kategori bilgisi gönderilir, diğer alanlar değişmez
    ''' </summary>
    Public Function UpdateProductCategories(categoryUpdates As List(Of Dictionary(Of String, Object))) As Boolean
        Try
            If categoryUpdates Is Nothing OrElse categoryUpdates.Count = 0 Then
                Log("WARNING", "UpdateProductCategories", "Güncellenecek kategori bulunamadı")
                Return False
            End If

            ' *** WEB KONTROLU: Urunlerin web'de oldugundan emin ol ***
            Dim priceProductIDs As New List(Of String)()
            For Each item As Dictionary(Of String, Object) In categoryUpdates
                If item.ContainsKey("productID") Then
                    priceProductIDs.Add(item("productID").ToString())
                End If
            Next
            If priceProductIDs.Count > 0 Then
                Log("INFO", "UpdateProductCategories", $"Web'de urun kontrolu yapiliyor: {priceProductIDs.Count} urun")
                EnsureAllProductsExistOnWeb(priceProductIDs)
            End If

            ' API limiti: Maksimum 15 ürün
            Dim batchSize As Integer = 15
            Dim totalBatches As Integer = CInt(Math.Ceiling(categoryUpdates.Count / CDbl(batchSize)))
            Dim successCount As Integer = 0
            Dim errorCount As Integer = 0

            Log("INFO", "UpdateProductCategories", $"{categoryUpdates.Count} ürün için kategori güncellemesi başlıyor...")

            For batchIndex As Integer = 0 To totalBatches - 1
                Dim batch = categoryUpdates.Skip(batchIndex * batchSize).Take(batchSize).ToList()

                ' product/save formatına dönüştür
                Dim products As New List(Of Dictionary(Of String, Object))
                For Each catItem As Dictionary(Of String, Object) In batch
                    Dim product As New Dictionary(Of String, Object)
                    product("code") = catItem("code")
                    product("categories") = catItem("categories") ' Kategori ID listesi
                    products.Add(product)
                Next

                Dim postData As New Dictionary(Of String, Object)
                postData("products") = products

                Log("INFO", "UpdateProductCategories", $"Batch {batchIndex + 1}/{totalBatches} gönderiliyor ({batch.Count} ürün)")

                Dim result As String = SendToApi("product/save", postData)

                If Not String.IsNullOrEmpty(result) Then
                    Try
                        Dim response = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(result)
                        If response.ContainsKey("code") Then
                            Dim responseCode As String = response("code").ToString()
                            ' API başarı kodları: 200, PRODUCTSAVE001, PRODUCTSAVE002 vb.
                            If responseCode = "200" OrElse responseCode.StartsWith("PRODUCTSAVE") Then
                                successCount += batch.Count
                                Log("INFO", "UpdateProductCategories", $"Batch {batchIndex + 1} başarılı")
                            Else
                                errorCount += batch.Count
                                Log("WARNING", "UpdateProductCategories", $"Batch {batchIndex + 1} hatalı: {result}")
                            End If
                        Else
                            errorCount += batch.Count
                            Log("WARNING", "UpdateProductCategories", $"Batch {batchIndex + 1} code içermiyor: {result}")
                        End If
                    Catch ex As Exception
                        Log("ERROR", "UpdateProductCategories", $"Response parse hatası: {ex.Message}")
                        errorCount += batch.Count
                    End Try
                Else
                    errorCount += batch.Count
                End If

                ' Rate limiting - 25 istek/dakika
                System.Threading.Thread.Sleep(2500)
            Next

            Log("INFO", "UpdateProductCategories", $"Kategori güncelleme tamamlandı. Başarılı: {successCount}, Hatalı: {errorCount}")
            Return errorCount = 0

        Catch ex As Exception
            Log("ERROR", "UpdateProductCategories", $"Hata: {ex.Message}")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Mevcut ürünlerin resimlerini web'de günceller
    ''' product/save endpoint'i kullanılır
    ''' Sadece resim bilgisi gönderilir, diğer alanlar değişmez
    ''' </summary>
    Public Function UpdateProductImages(imageUpdates As List(Of Dictionary(Of String, Object))) As Boolean
        Try
            If imageUpdates Is Nothing OrElse imageUpdates.Count = 0 Then
                Log("WARNING", "UpdateProductImages", "Güncellenecek resim bulunamadı")
                Return False
            End If

            ' *** WEB KONTROLU: Urunlerin web'de oldugundan emin ol ***
            Dim priceProductIDs As New List(Of String)()
            For Each item As Dictionary(Of String, Object) In imageUpdates
                If item.ContainsKey("productID") Then
                    priceProductIDs.Add(item("productID").ToString())
                End If
            Next
            If priceProductIDs.Count > 0 Then
                Log("INFO", "UpdateProductImages", $"Web'de urun kontrolu yapiliyor: {priceProductIDs.Count} urun")
                EnsureAllProductsExistOnWeb(priceProductIDs)
            End If

            ' API limiti: Maksimum 15 ürün
            Dim batchSize As Integer = 15
            Dim totalBatches As Integer = CInt(Math.Ceiling(imageUpdates.Count / CDbl(batchSize)))
            Dim successCount As Integer = 0
            Dim errorCount As Integer = 0

            Log("INFO", "UpdateProductImages", $"{imageUpdates.Count} ürün için resim güncellemesi başlıyor...")

            For batchIndex As Integer = 0 To totalBatches - 1
                Dim batch = imageUpdates.Skip(batchIndex * batchSize).Take(batchSize).ToList()

                ' product/save formatına dönüştür
                Dim products As New List(Of Dictionary(Of String, Object))
                For Each imgItem As Dictionary(Of String, Object) In batch
                    Dim product As New Dictionary(Of String, Object)
                    product("code") = imgItem("code")

                    ' Resimleri images array'ine dönüştür
                    Dim images As New List(Of Dictionary(Of String, Object))
                    If imgItem.ContainsKey("imageUrls") Then
                        Dim urls = DirectCast(imgItem("imageUrls"), List(Of String))
                        For Each imgUrl As String In urls
                            images.Add(New Dictionary(Of String, Object) From {{"imageUrl", imgUrl}})
                        Next
                    End If
                    product("images") = images

                    products.Add(product)
                Next

                Dim postData As New Dictionary(Of String, Object)
                postData("products") = products

                Log("INFO", "UpdateProductImages", $"Batch {batchIndex + 1}/{totalBatches} gönderiliyor ({batch.Count} ürün)")

                Dim result As String = SendToApi("product/save", postData)

                If Not String.IsNullOrEmpty(result) Then
                    Try
                        Dim response = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(result)
                        If response.ContainsKey("code") Then
                            Dim responseCode As String = response("code").ToString()
                            ' API başarı kodları: 200, PRODUCTSAVE001, PRODUCTSAVE002 vb.
                            If responseCode = "200" OrElse responseCode.StartsWith("PRODUCTSAVE") Then
                                successCount += batch.Count
                                Log("INFO", "UpdateProductImages", $"Batch {batchIndex + 1} başarılı")
                            Else
                                errorCount += batch.Count
                                Log("WARNING", "UpdateProductImages", $"Batch {batchIndex + 1} hatalı: {result}")
                            End If
                        Else
                            errorCount += batch.Count
                            Log("WARNING", "UpdateProductImages", $"Batch {batchIndex + 1} code içermiyor: {result}")
                        End If
                    Catch ex As Exception
                        Log("ERROR", "UpdateProductImages", $"Response parse hatası: {ex.Message}")
                        errorCount += batch.Count
                    End Try
                Else
                    errorCount += batch.Count
                End If

                ' Rate limiting - 25 istek/dakika
                System.Threading.Thread.Sleep(2500)
            Next

            Log("INFO", "UpdateProductImages", $"Resim güncelleme tamamlandı. Başarılı: {successCount}, Hatalı: {errorCount}")
            Return errorCount = 0

        Catch ex As Exception
            Log("ERROR", "UpdateProductImages", $"Hata: {ex.Message}")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Trigger tabanlı: Kategori değişen ürünleri web'de günceller
    ''' products tablosunda status=0 olan ürünlerin kategorilerini gönderir
    ''' </summary>
    Public Sub SyncProductsTableCategories()
        Try
            Log("INFO", "SyncProductsTableCategories", "Kategori değişiklikleri kontrol ediliyor...")

            Dim categoryUpdates As New List(Of Dictionary(Of String, Object))
            Dim processedProductIDs As New List(Of String)

            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()

                ' products tablosundan status=0 olanları al
                Dim sql As String =
                "SELECT p.productID " &
                "FROM products p " &
                "WHERE p.status = 0 " &
                "ORDER BY p.updated_at ASC"

                Using cmd As New OleDb.OleDbCommand(sql, conn)
                    Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim prodID As String = If(reader("productID") Is DBNull.Value, "", reader("productID").ToString().Trim())
                            If Not String.IsNullOrEmpty(prodID) Then
                                processedProductIDs.Add(prodID)
                            End If
                        End While
                    End Using
                End Using

                If processedProductIDs.Count = 0 Then
                    Log("INFO", "SyncProductsTableCategories", "Güncellenecek kategori değişikliği bulunamadı")
                    Return
                End If

                Log("INFO", "SyncProductsTableCategories", $"{processedProductIDs.Count} ürün için kategori güncellemesi yapılacak")

                ' Her ürün için kategori bilgisini al
                For Each prodID As String In processedProductIDs
                    Dim parts As String() = prodID.Split(New String() {"__"}, StringSplitOptions.None)
                    If parts.Length < 1 OrElse String.IsNullOrEmpty(parts(0)) Then Continue For

                    Dim sModel As String = parts(0).Trim()
                    Dim sRenk As String = If(parts.Length > 1, parts(1).Trim(), "")  ' Varyansız ise boş

                    Try
                        ' tbStokSinifi'den kategori kodlarını al ve web kategori ID'lerine dönüştür
                        Dim catSql As String =
                        "SELECT SS.sSinifKodu4, SS.sSinifKodu5, SS.sSinifKodu6, SS.sSinifKodu7, SS.sSinifKodu8 " &
                        "FROM tbStokSinifi SS " &
                        "INNER JOIN tbStok S ON SS.nStokID = S.nStokID " &
                        "WHERE S.sModel = ? AND S.sRenk = ?"

                        Dim categories As New List(Of Integer)

                        Using catCmd As New OleDb.OleDbCommand(catSql, conn)
                            catCmd.Parameters.AddWithValue("?", sModel)
                            catCmd.Parameters.AddWithValue("?", sRenk)
                            Using catReader As OleDb.OleDbDataReader = catCmd.ExecuteReader()
                                If catReader.Read() Then
                                    ' Kategori kodlarından web ID'lerini bul
                                    ' Bu kısım web platformunuza göre özelleştirilmeli
                                    For i As Integer = 4 To 8
                                        Dim colName As String = "sSinifKodu" & i.ToString()
                                        If Not catReader.IsDBNull(catReader.GetOrdinal(colName)) Then
                                            Dim sinifKodu As String = catReader(colName).ToString().Trim()
                                            If Not String.IsNullOrEmpty(sinifKodu) Then
                                                ' Web kategori ID'sini bulmak için lookup yapılmalı
                                                ' Şimdilik kategori kodunu doğrudan integer'a çevirmeyi dene
                                                Dim catId As Integer
                                                If Integer.TryParse(sinifKodu, catId) Then
                                                    categories.Add(catId)
                                                End If
                                            End If
                                        End If
                                    Next
                                End If
                            End Using
                        End Using

                        If categories.Count > 0 Then
                            categoryUpdates.Add(New Dictionary(Of String, Object) From {
                                {"code", prodID},
                                {"categories", categories}
                            })
                        End If

                    Catch catEx As Exception
                        Log("WARNING", "SyncProductsTableCategories", $"Kategori alınamadı ({prodID}): {catEx.Message}")
                    End Try
                Next

                ' Toplu güncelleme yap
                If categoryUpdates.Count > 0 Then
                    Dim success As Boolean = UpdateProductCategories(categoryUpdates)

                    If success Then
                        ' Başarılı olanları işaretle
                        For Each syncProdID As String In processedProductIDs
                            Using updCmd As New OleDb.OleDbCommand(
                                "UPDATE products SET status = 1, updated_at = GETDATE() WHERE productID = ?", conn)
                                updCmd.Parameters.AddWithValue("?", syncProdID)
                                updCmd.ExecuteNonQuery()
                            End Using
                        Next
                    End If
                End If

                Log("INFO", "SyncProductsTableCategories", "Kategori senkronizasyonu tamamlandı")
            End Using

        Catch ex As Exception
            Log("ERROR", "SyncProductsTableCategories", "Hata: " & ex.Message)
        End Try
    End Sub

    ' ===== YENİ API FONKSİYONLARI SONU =====

    ' =====================================================
    ' ===== TRIGGER TABANLI SENKRONIZASYON FONKSİYONLARI =====
    ' Bu fonksiyonlar products ve product_images tablolarını kullanır
    ' Trigger'lar değişiklikleri bu tablolara yazar
    ' =====================================================

    ''' <summary>
    ''' products tablosundan status=0 olan ürünleri bulup stok günceller
    ''' Trigger sistemi ile çalışır - mevcut sistemi bozmaz
    ''' </summary>
    Public Sub SyncProductsTableStocks()
        Try
            Log("INFO", "SyncProductsTableStocks", "products tablosundan değişen stoklar kontrol ediliyor...")
            SafeUpdateUI(Sub() lblTriggerDurum.Text = "Durum: Stok değişiklikleri kontrol ediliyor...")

            Dim stockUpdates As New List(Of Dictionary(Of String, Object))
            Dim processedProductIDs As New List(Of String)
            Dim totalProducts As Integer = 0
            Dim processedCount As Integer = 0

            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()

                ' Önce toplam sayıyı al
                Using countCmd As New OleDb.OleDbCommand("SELECT COUNT(*) FROM products WHERE status = 0", conn)
                    totalProducts = Convert.ToInt32(countCmd.ExecuteScalar())
                End Using

                UpdateTriggerProgress(0, totalProducts, 0)
                SafeUpdateUI(Sub() lblTriggerSayac.Text = $"Stok: 0/{totalProducts} | Gönderilen: 0 | Kalan: {totalProducts}")

                ' products tablosundan status=0 olanları al (stok değişmiş)
                Dim sql As String =
                "SELECT p.productID, p.updated_at " &
                "FROM products p " &
                "WHERE p.status = 0 " &
                "ORDER BY p.updated_at ASC"

                Using cmd As New OleDb.OleDbCommand(sql, conn)
                    Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim productID As String = If(reader("productID") Is DBNull.Value, "", reader("productID").ToString().Trim())
                            If String.IsNullOrEmpty(productID) Then Continue While

                            ' productID formatı: sModel__sRenk (varyantlı) veya sModel (varyansız)
                            Dim parts As String() = productID.Split(New String() {"__"}, StringSplitOptions.None)

                            ' Varyansız ürünler de işlensin (parts.Length = 1)
                            If parts.Length < 1 OrElse String.IsNullOrEmpty(parts(0)) Then Continue While

                            processedProductIDs.Add(productID)
                            processedCount += 1
                            UpdateTriggerProgress(processedCount, totalProducts, 0)
                        End While
                    End Using
                End Using

                ' Her ürün için stok bilgilerini al
                For Each prodID As String In processedProductIDs
                    Dim parts As String() = prodID.Split(New String() {"__"}, StringSplitOptions.None)
                    Dim sModel As String = parts(0).Trim()
                    Dim sRenk As String = If(parts.Length > 1, parts(1).Trim(), "")  ' Varyansız ise boş

                    Dim variants As New List(Of Dictionary(Of String, Object))

                    Using varCmd As New OleDb.OleDbCommand(
                        "SELECT T1.nStokID, T2.sBarkod, " &
                        " (SELECT ISNULL(SUM(lGirisMiktar1 - lCikisMiktar1), 0) FROM tbStokFisiDetayi WHERE nStokID=T1.nStokID AND sDepo=?) AS stok " &
                        "FROM tbStok T1 " &
                        "LEFT JOIN tbStokBarkodu T2 ON T2.nStokID = T1.nStokID AND T2.nKisim=0 " &
                        "WHERE T1.sModel = ? AND T1.sRenk = ? AND T1.bWebGoruntule='1'", conn)

                        varCmd.Parameters.AddWithValue("?", sDepo)
                        varCmd.Parameters.AddWithValue("?", sModel)
                        varCmd.Parameters.AddWithValue("?", sRenk)

                        Using varReader As OleDb.OleDbDataReader = varCmd.ExecuteReader()
                            While varReader.Read()
                                Dim sBarkod As String = If(varReader("sBarkod") Is DBNull.Value, "", varReader("sBarkod").ToString().Trim())
                                Dim stok As Integer = If(varReader("stok") Is DBNull.Value, 0, Convert.ToInt32(varReader("stok")))
                                If stok < 0 Then stok = 0

                                If Not String.IsNullOrEmpty(sBarkod) Then
                                    Dim variantItem As New Dictionary(Of String, Object)
                                    variantItem("barcode") = sBarkod
                                    variantItem("quantity") = stok
                                    variants.Add(variantItem)
                                End If
                            End While
                        End Using
                    End Using

                    If variants.Count > 0 Then
                        Dim stockItem As New Dictionary(Of String, Object)
                        stockItem("code") = prodID
                        stockItem("variants") = variants
                        stockUpdates.Add(stockItem)
                    End If
                Next

                ' Stok güncellemesi yap
                If stockUpdates.Count > 0 Then
                    Log("INFO", "SyncProductsTableStocks", stockUpdates.Count.ToString() & " ürün için stok güncellemesi yapılacak")
                    SafeUpdateUI(Sub() lblTriggerDurum.Text = $"Durum: {stockUpdates.Count} ürün gönderiliyor...")
                    Dim success As Boolean = UpdateStocks(stockUpdates)

                    ' Başarılı olanları işaretle (status=1)
                    If success AndAlso processedProductIDs.Count > 0 Then
                        Dim sentCount As Integer = 0
                        For Each pid As String In processedProductIDs
                            Using updCmd As New OleDb.OleDbCommand(
                                "UPDATE products SET status = 1, updated_at = GETDATE() WHERE productID = ?", conn)
                                updCmd.Parameters.AddWithValue("?", pid)
                                updCmd.ExecuteNonQuery()
                            End Using
                            sentCount += 1
                            UpdateTriggerProgress(sentCount, processedProductIDs.Count, sentCount)
                        Next
                        Log("INFO", "SyncProductsTableStocks", processedProductIDs.Count.ToString() & " ürün status=1 olarak işaretlendi")
                        SafeUpdateUI(Sub() lblTriggerSayac.Text = $"Stok: {processedProductIDs.Count}/{processedProductIDs.Count} | Gönderilen: {processedProductIDs.Count} | Kalan: 0")
                    End If
                Else
                    Log("INFO", "SyncProductsTableStocks", "Güncellenecek stok değişikliği bulunamadı")
                    SafeUpdateUI(Sub() lblTriggerSayac.Text = "Stok: Değişiklik yok")
                End If
            End Using

        Catch ex As Exception
            Log("ERROR", "SyncProductsTableStocks", "Hata: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' products tablosundan f_durum=0 olan ürünleri bulup fiyat günceller
    ''' Trigger sistemi ile çalışır - mevcut sistemi bozmaz
    ''' </summary>
    Public Sub SyncProductsTablePrices()
        Try
            Log("INFO", "SyncProductsTablePrices", "products tablosundan değişen fiyatlar kontrol ediliyor...")

            Dim priceUpdates As New List(Of Dictionary(Of String, Object))
            Dim processedProductIDs As New List(Of String)

            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()

                ' products tablosundan f_durum=0 olanları al (fiyat değişmiş)
                Dim sql As String =
                "SELECT p.productID, p.updated_at " &
                "FROM products p " &
                "WHERE p.f_durum = 0 " &
                "ORDER BY p.updated_at ASC"

                Using cmd As New OleDb.OleDbCommand(sql, conn)
                    Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim prodID As String = If(reader("productID") Is DBNull.Value, "", reader("productID").ToString().Trim())
                            If String.IsNullOrEmpty(prodID) Then Continue While
                            processedProductIDs.Add(prodID)
                        End While
                    End Using
                End Using

                ' Her ürün için fiyat bilgilerini al
                For Each prodID As String In processedProductIDs
                    Dim parts As String() = prodID.Split(New String() {"__"}, StringSplitOptions.None)
                    If parts.Length < 1 OrElse String.IsNullOrEmpty(parts(0)) Then Continue For

                    Dim sModel As String = parts(0).Trim()
                    Dim sRenk As String = If(parts.Length > 1, parts(1).Trim(), "")  ' Varyansız ise boş
                    Dim seciliFiyatTipi As String = GetSeciliFiyatTipi()

                    Using fiyatCmd As New OleDb.OleDbCommand(
                        "SELECT TOP 1 " &
                        " (SELECT lFiyat FROM tbStokFiyati WHERE nStokID=T1.nStokID AND sFiyatTipi='" & seciliFiyatTipi & "') AS siteFiyat, " &
                        " (SELECT lFiyat FROM tbStokFiyati WHERE nStokID=T1.nStokID AND sFiyatTipi='webl') AS listeFiyat, " &
                        " (SELECT lFiyat FROM tbStokFiyati WHERE nStokID=T1.nStokID AND sFiyatTipi='2') AS trendyolFiyat, " &
                        " (SELECT lFiyat FROM tbStokFiyati WHERE nStokID=T1.nStokID AND sFiyatTipi='3') AS hbFiyat, " &
                        " (SELECT lFiyat FROM tbStokFiyati WHERE nStokID=T1.nStokID AND sFiyatTipi='4') AS n11Fiyat " &
                        "FROM tbStok T1 WHERE T1.sModel = ? AND T1.sRenk = ? AND T1.bWebGoruntule='1'", conn)

                        fiyatCmd.Parameters.AddWithValue("?", sModel)
                        fiyatCmd.Parameters.AddWithValue("?", sRenk)

                        Using fiyatReader As OleDb.OleDbDataReader = fiyatCmd.ExecuteReader()
                            If fiyatReader.Read() Then
                                Dim siteFiyat As Decimal = If(fiyatReader("siteFiyat") Is DBNull.Value, 0D, Convert.ToDecimal(fiyatReader("siteFiyat")))
                                Dim listeFiyat As Decimal = If(fiyatReader("listeFiyat") Is DBNull.Value, 0D, Convert.ToDecimal(fiyatReader("listeFiyat")))
                                Dim trendyolFiyat As Decimal = If(fiyatReader("trendyolFiyat") Is DBNull.Value, 0D, Convert.ToDecimal(fiyatReader("trendyolFiyat")))
                                Dim hbFiyat As Decimal = If(fiyatReader("hbFiyat") Is DBNull.Value, 0D, Convert.ToDecimal(fiyatReader("hbFiyat")))
                                Dim n11Fiyat As Decimal = If(fiyatReader("n11Fiyat") Is DBNull.Value, 0D, Convert.ToDecimal(fiyatReader("n11Fiyat")))

                                If siteFiyat > 0 Then
                                    Dim priceItem As New Dictionary(Of String, Object)
                                    priceItem("code") = prodID
                                    priceItem("currency") = "TL"
                                    priceItem("salePrice") = siteFiyat
                                    If listeFiyat > 0 Then priceItem("listPrice") = listeFiyat

                                    ' Pazaryeri fiyatları
                                    Dim marketplacePrices As New List(Of Dictionary(Of String, Object))
                                    If trendyolFiyat > 0 Then
                                        marketplacePrices.Add(New Dictionary(Of String, Object) From {
                                            {"type", "ty"}, {"currency", "TL"}, {"price", trendyolFiyat}
                                        })
                                    End If
                                    If hbFiyat > 0 Then
                                        marketplacePrices.Add(New Dictionary(Of String, Object) From {
                                            {"type", "hb"}, {"currency", "TL"}, {"price", hbFiyat}
                                        })
                                    End If
                                    If n11Fiyat > 0 Then
                                        marketplacePrices.Add(New Dictionary(Of String, Object) From {
                                            {"type", "n11"}, {"currency", "TL"}, {"price", n11Fiyat}
                                        })
                                    End If
                                    If marketplacePrices.Count > 0 Then
                                        priceItem("marketplacePrices") = marketplacePrices
                                    End If

                                    priceUpdates.Add(priceItem)
                                End If
                            End If
                        End Using
                    End Using
                Next

                ' Fiyat güncellemesi yap
                If priceUpdates.Count > 0 Then
                    Log("INFO", "SyncProductsTablePrices", priceUpdates.Count.ToString() & " ürün için fiyat güncellemesi yapılacak")
                    Dim success As Boolean = UpdatePrices(priceUpdates)

                    ' Başarılı olanları işaretle (f_durum=1)
                    If success AndAlso processedProductIDs.Count > 0 Then
                        For Each pid As String In processedProductIDs
                            Using updCmd As New OleDb.OleDbCommand(
                                "UPDATE products SET f_durum = 1, updated_at = GETDATE() WHERE productID = ?", conn)
                                updCmd.Parameters.AddWithValue("?", pid)
                                updCmd.ExecuteNonQuery()
                            End Using
                        Next
                        Log("INFO", "SyncProductsTablePrices", processedProductIDs.Count.ToString() & " ürün f_durum=1 olarak işaretlendi")
                    End If
                Else
                    Log("INFO", "SyncProductsTablePrices", "Güncellenecek fiyat değişikliği bulunamadı")
                End If
            End Using

        Catch ex As Exception
            Log("ERROR", "SyncProductsTablePrices", "Hata: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' product_images tablosundan status=0 olan ürünlerin resimlerini gönderir
    ''' Trigger sistemi ile çalışır - mevcut sistemi bozmaz
    ''' </summary>
    Public Sub SyncProductImagesTable()
        Try
            Log("INFO", "SyncProductImagesTable", "product_images tablosundan değişen resimler kontrol ediliyor...")

            Dim processedProductIDs As New List(Of String)
            Dim successCount As Integer = 0
            Dim errorCount As Integer = 0

            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()

                ' product_images tablosundan status=0 olanları al (resim değişmiş)
                Dim sql As String =
                "SELECT productID, img_count " &
                "FROM product_images " &
                "WHERE status = 0 " &
                "ORDER BY updated_at ASC"

                Using cmd As New OleDb.OleDbCommand(sql, conn)
                    Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim prodID As String = If(reader("productID") Is DBNull.Value, "", reader("productID").ToString().Trim())
                            If String.IsNullOrEmpty(prodID) Then Continue While
                            processedProductIDs.Add(prodID)
                        End While
                    End Using
                End Using

                If processedProductIDs.Count = 0 Then
                    Log("INFO", "SyncProductImagesTable", "Güncellenecek resim değişikliği bulunamadı")
                    Return
                End If

                Log("INFO", "SyncProductImagesTable", processedProductIDs.Count.ToString() & " ürün için resim güncellemesi yapılacak")

                ' Her ürün için resim gönder
                For Each prodID As String In processedProductIDs
                    Dim parts As String() = prodID.Split(New String() {"__"}, StringSplitOptions.None)
                    If parts.Length < 1 OrElse String.IsNullOrEmpty(parts(0)) Then Continue For

                    Dim sModel As String = parts(0).Trim()
                    Dim sRenk As String = If(parts.Length > 1, parts(1).Trim(), "")  ' Varyansız ise boş

                    Try
                        ' Resim URL'lerini al (nSira 1-5 için GROUP BY)
                        Dim images As New List(Of String)
                        Dim imageSql As String =
                        "SELECT nSira, MIN(yol) AS yol " &
                        "FROM tbStokResim " &
                        "WHERE sModel = ? AND sRenk = ? AND yol IS NOT NULL AND yol <> '' AND nSira BETWEEN 1 AND 5 " &
                        "GROUP BY nSira " &
                        "ORDER BY nSira"

                        Using imgCmd As New OleDb.OleDbCommand(imageSql, conn)
                            imgCmd.Parameters.AddWithValue("?", sModel)
                            imgCmd.Parameters.AddWithValue("?", sRenk)
                            Using imgReader As OleDb.OleDbDataReader = imgCmd.ExecuteReader()
                                While imgReader.Read()
                                    Try
                                        If Not imgReader.IsDBNull(imgReader.GetOrdinal("yol")) Then
                                            Dim imgUrl As String = imgReader("yol").ToString().Trim()
                                            If Not String.IsNullOrEmpty(imgUrl) AndAlso imgUrl <> "." AndAlso imgUrl.StartsWith("http") Then
                                                images.Add(imgUrl)
                                            End If
                                        End If
                                    Catch ex As Exception
                                        Log("WARNING", "SyncProductImagesTable", $"Resim okuma hatası: {ex.Message}")
                                    End Try
                                End While
                            End Using
                        End Using

                        If images.Count > 0 Then
                            ' API'ye resim gönder
                            Dim imageData As New Dictionary(Of String, Object)
                            imageData("code") = prodID

                            Dim imageObjects As New List(Of Dictionary(Of String, Object))
                            For Each imgUrl As String In images
                                imageObjects.Add(New Dictionary(Of String, Object) From {{"imageUrl", imgUrl}})
                            Next
                            imageData("images") = imageObjects

                            ' API çağrısı yap
                            Dim apiResult As Boolean = SendImagesToAPI(imageData)

                            If apiResult Then
                                successCount += 1
                                Log("INFO", "SyncProductImagesTable", $"Resim gönderildi: {prodID} ({images.Count} adet)")

                                ' Başarılı - status=1 yap
                                Using updCmd As New OleDb.OleDbCommand(
                                    "UPDATE product_images SET status = 1, img_count = ?, updated_at = GETDATE() WHERE productID = ?", conn)
                                    updCmd.Parameters.AddWithValue("?", images.Count)
                                    updCmd.Parameters.AddWithValue("?", prodID)
                                    updCmd.ExecuteNonQuery()
                                End Using
                            Else
                                errorCount += 1
                                Log("ERROR", "SyncProductImagesTable", $"Resim gönderilemedi: {prodID}")
                            End If
                        Else
                            ' Resim yok, yine de status=1 yap (boş resim gönderildi kabul et)
                            Log("WARNING", "SyncProductImagesTable", $"Resim bulunamadı: {prodID}")
                            Using updCmd As New OleDb.OleDbCommand(
                                "UPDATE product_images SET status = 1, img_count = 0, updated_at = GETDATE() WHERE productID = ?", conn)
                                updCmd.Parameters.AddWithValue("?", prodID)
                                updCmd.ExecuteNonQuery()
                            End Using
                        End If

                    Catch imgEx As Exception
                        errorCount += 1
                        Log("ERROR", "SyncProductImagesTable", "Resim hatası (" & prodID & "): " & imgEx.Message)
                    End Try
                Next

                Log("INFO", "SyncProductImagesTable", "Resim senkronizasyonu tamamlandı. Başarılı: " & successCount.ToString() & ", Hatalı: " & errorCount.ToString())
            End Using

        Catch ex As Exception
            Log("ERROR", "SyncProductImagesTable", "Hata: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' API'ye resim gönderir - product/save endpoint'ini kullanır
    ''' </summary>
    Private Function SendImagesToAPI(imageData As Dictionary(Of String, Object)) As Boolean
        Try
            ' product/save endpoint'ini kullan
            Dim code As String = imageData("code").ToString()
            Dim images As List(Of Dictionary(Of String, Object)) = DirectCast(imageData("images"), List(Of Dictionary(Of String, Object)))

            ' product/save formatında veri hazırla
            Dim products As New List(Of Dictionary(Of String, Object))
            Dim product As New Dictionary(Of String, Object)
            product("code") = code
            product("images") = images
            products.Add(product)

            Dim postData As New Dictionary(Of String, Object)
            postData("products") = products

            ' SendToApi fonksiyonunu kullan (mevcut API ayarlarını kullanır)
            Dim result As String = SendToApi("product/save", postData)

            If Not String.IsNullOrEmpty(result) Then
                Try
                    Dim response = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(result)
                    If response.ContainsKey("code") Then
                        Dim responseCode As String = response("code").ToString()
                        ' API başarı kodları: 200, PRODUCTSAVE001, PRODUCTSAVE002 vb.
                        If responseCode = "200" OrElse responseCode.StartsWith("PRODUCTSAVE") Then
                            Return True
                        Else
                            Log("WARNING", "SendImagesToAPI", $"API yanıtı: {result}")
                            Return False
                        End If
                    Else
                        Log("WARNING", "SendImagesToAPI", $"API yanıtı code içermiyor: {result}")
                        Return False
                    End If
                Catch ex As Exception
                    Log("ERROR", "SendImagesToAPI", $"Response parse hatası: {ex.Message}")
                    Return False
                End Try
            Else
                Return False
            End If

        Catch ex As Exception
            Log("ERROR", "SendImagesToAPI", "Hata: " & ex.Message)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Tüm trigger tabanlı senkronizasyonları çalıştırır
    ''' Mevcut sistemi bozmaz, ek olarak çalışır
    ''' </summary>
    Public Sub RunTriggerBasedSync()
        Try
            Log("INFO", "RunTriggerBasedSync", "Trigger tabanlı senkronizasyon başlatılıyor...")

            ' 1. Stok değişikliklerini kontrol et (products.status=0)
            SyncProductsTableStocks()

            ' 2. Fiyat değişikliklerini kontrol et (products.f_durum=0)
            SyncProductsTablePrices()

            ' 3. Resim değişikliklerini kontrol et (product_images.status=0)
            SyncProductImagesTable()

            Log("INFO", "RunTriggerBasedSync", "Trigger tabanlı senkronizasyon tamamlandı.")

        Catch ex As Exception
            Log("ERROR", "RunTriggerBasedSync", "Hata: " & ex.Message)
        End Try
    End Sub

    ' ===== TRIGGER TAB EVENT HANDLER'LARI =====

    ''' <summary>
    ''' Trigger Başlat butonu
    ''' </summary>
    Private Sub btnTriggerBaslat_Click(sender As Object, e As EventArgs) Handles btnTriggerBaslat.Click
        Try
            If Not chkTriggerAktif.Checked Then
                XtraMessageBox.Show("Trigger sistemi aktif değil!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Timer ayarla
            Dim dakika As Integer = CInt(txtTriggerTimerDakika.Value)
            triggerSyncTimer.Interval = dakika * 60 * 1000 ' Dakikayı milisaniyeye çevir

            AddHandler triggerSyncTimer.Elapsed, AddressOf OnTriggerSyncTimerElapsed
            triggerSyncTimer.AutoReset = True
            triggerSyncTimer.Start()

            isTriggerRunning = True
            btnTriggerBaslat.Enabled = False
            btnTriggerDurdur.Enabled = True
            lblDurum.Text = "Durum: Trigger Sistemi Çalışıyor"
            lblDurum.ForeColor = System.Drawing.Color.Green

            AddLog("Trigger sistemi başlatıldı. Kontrol süresi: " & dakika.ToString() & " dakika")

            ' İlk çalıştırma
            RunTriggerSync()

        Catch ex As Exception
            XtraMessageBox.Show("Trigger başlatma hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Trigger Durdur butonu
    ''' </summary>
    Private Sub btnTriggerDurdur_Click(sender As Object, e As EventArgs) Handles btnTriggerDurdur.Click
        Try
            triggerSyncTimer.Stop()
            RemoveHandler triggerSyncTimer.Elapsed, AddressOf OnTriggerSyncTimerElapsed

            isTriggerRunning = False
            btnTriggerBaslat.Enabled = True
            btnTriggerDurdur.Enabled = False
            lblDurum.Text = "Durum: Beklemede"
            lblDurum.ForeColor = System.Drawing.Color.Black

            AddLog("Trigger sistemi durduruldu.")

        Catch ex As Exception
            XtraMessageBox.Show("Trigger durdurma hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Trigger Timer olayı
    ''' </summary>
    Private Sub OnTriggerSyncTimerElapsed(sender As Object, e As ElapsedEventArgs)
        Try
            Me.Invoke(Sub()
                          AddLog("Trigger otomatik kontrolü başlatıldı...")
                          lblDurum.Text = "Durum: Trigger kontrol ediliyor..."
                      End Sub)

            RunTriggerSync()

            Me.Invoke(Sub()
                          lblDurum.Text = "Durum: Trigger Sistemi Çalışıyor"
                          AddLog("Trigger otomatik kontrolü tamamlandı.")
                      End Sub)
        Catch ex As Exception
            Me.Invoke(Sub()
                          AddLog("Trigger kontrolü hatası: " & ex.Message)
                      End Sub)
        End Try
    End Sub

    ''' <summary>
    ''' Trigger senkronizasyonunu çalıştır
    ''' Ayarları VERİTABANINDAN okur (Thread-safe)
    ''' </summary>
    Private Sub RunTriggerSync()
        Try
            LoadConfig()

            ' Progress bar'ı sıfırla
            ResetProgressBars()
            SafeUpdateUI(Sub() lblTriggerDurum.Text = "Durum: Trigger senkronizasyonu çalışıyor...")

            ' ===== TRIGGER AYARLARINI VERİTABANINDAN OKU (Thread-safe) =====
            Dim triggerStok As Boolean = GetAyarBool("TRIGGER_STOK", True)
            Dim triggerFiyat As Boolean = GetAyarBool("TRIGGER_FIYAT", True)
            Dim triggerResim As Boolean = GetAyarBool("TRIGGER_RESIM", True)
            Dim triggerKategori As Boolean = GetAyarBool("TRIGGER_KATEGORI", True)

            Dim totalSteps As Integer = 0
            Dim currentStep As Integer = 0

            If triggerStok Then totalSteps += 1
            If triggerFiyat Then totalSteps += 1
            If triggerResim Then totalSteps += 1
            If triggerKategori Then totalSteps += 1

            If triggerStok Then
                currentStep += 1
                UpdateTriggerProgress(currentStep, totalSteps)
                SafeUpdateUI(Sub() lblTriggerDurum.Text = $"Durum: Stok senkronizasyonu ({currentStep}/{totalSteps})...")
                SyncProductsTableStocks()
            End If

            If triggerFiyat Then
                currentStep += 1
                UpdateTriggerProgress(currentStep, totalSteps)
                SafeUpdateUI(Sub() lblTriggerDurum.Text = $"Durum: Fiyat senkronizasyonu ({currentStep}/{totalSteps})...")
                SyncProductsTablePrices()
            End If

            If triggerResim Then
                currentStep += 1
                UpdateTriggerProgress(currentStep, totalSteps)
                SafeUpdateUI(Sub() lblTriggerDurum.Text = $"Durum: Resim senkronizasyonu ({currentStep}/{totalSteps})...")
                SyncProductImagesTable()
            End If

            If triggerKategori Then
                currentStep += 1
                UpdateTriggerProgress(currentStep, totalSteps)
                SafeUpdateUI(Sub() lblTriggerDurum.Text = $"Durum: Kategori senkronizasyonu ({currentStep}/{totalSteps})...")
                SyncProductsTableCategories()
            End If

            ' Progress bar'ı tamamla
            UpdateTriggerProgress(totalSteps, totalSteps)
            SafeUpdateUI(Sub() lblTriggerDurum.Text = "Durum: Trigger tamamlandı")

            ' İstatistikleri güncelle
            Me.Invoke(Sub() RefreshTriggerStats())

        Catch ex As Exception
            Log("ERROR", "RunTriggerSync", "Hata: " & ex.Message)
            SafeUpdateUI(Sub() lblTriggerDurum.Text = "Durum: Hata!")
        End Try
    End Sub

    ''' <summary>
    ''' Bekleyen değişiklikleri yenile butonu
    ''' </summary>
    Private Sub btnTriggerYenile_Click(sender As Object, e As EventArgs) Handles btnTriggerYenile.Click
        RefreshTriggerStats()
    End Sub

    ''' <summary>
    ''' Bekleyen değişiklik istatistiklerini güncelle
    ''' </summary>
    Private Sub RefreshTriggerStats()
        Try
            Dim stokCount As Integer = 0
            Dim fiyatCount As Integer = 0
            Dim resimCount As Integer = 0
            Dim kategoriCount As Integer = 0

            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()

                ' Bekleyen stok değişiklikleri (status=0)
                Using cmd As New OleDb.OleDbCommand("SELECT COUNT(*) FROM products WHERE status = 0", conn)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        stokCount = Convert.ToInt32(result)
                    End If
                End Using

                ' Bekleyen fiyat değişiklikleri (f_durum=0)
                Using cmd As New OleDb.OleDbCommand("SELECT COUNT(*) FROM products WHERE f_durum = 0", conn)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        fiyatCount = Convert.ToInt32(result)
                    End If
                End Using

                ' Bekleyen resim değişiklikleri
                Using cmd As New OleDb.OleDbCommand("SELECT COUNT(*) FROM product_images WHERE status = 0", conn)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        resimCount = Convert.ToInt32(result)
                    End If
                End Using

                ' Bekleyen kategori değişiklikleri (kategori trigger status=0 olan ürünler)
                ' Not: Kategori değişikliği de products tablosundaki status alanını kullanır
                kategoriCount = stokCount ' Şimdilik aynı, trigger ayrı alan eklerse değişir
            End Using

            lblBekleyenStok.Text = "Stok: " & stokCount.ToString() & " ürün bekliyor"
            lblBekleyenFiyat.Text = "Fiyat: " & fiyatCount.ToString() & " ürün bekliyor"
            lblBekleyenResim.Text = "Resim: " & resimCount.ToString() & " ürün bekliyor"
            lblBekleyenKategori.Text = "Kategori: " & kategoriCount.ToString() & " ürün bekliyor"

            ' Renk kodlaması
            lblBekleyenStok.ForeColor = If(stokCount > 0, System.Drawing.Color.Red, System.Drawing.Color.Green)
            lblBekleyenFiyat.ForeColor = If(fiyatCount > 0, System.Drawing.Color.Red, System.Drawing.Color.Green)
            lblBekleyenResim.ForeColor = If(resimCount > 0, System.Drawing.Color.Red, System.Drawing.Color.Green)

        Catch ex As Exception
            lblBekleyenStok.Text = "Stok: Hata"
            lblBekleyenFiyat.Text = "Fiyat: Hata"
            lblBekleyenResim.Text = "Resim: Hata"
        End Try
    End Sub

    ''' <summary>
    ''' Form yüklendiğinde trigger istatistiklerini güncelle
    ''' </summary>
    Private Sub frm_qukaGonder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' ===== LOGLAMA SİSTEMİ BAŞLAT =====
            EticaretLogger.LogApplicationStart()
            EticaretLogger.LogInfo("frm_qukaGonder formu yükleniyor...")

            ' ===== SSL/TLS GÜVENLİK PROTOKOLÜ AYARI =====
            ' Modern sunuculara güvenli bağlantı kurabilmek için TLS 1.2 ve üzeri protokolleri etkinleştir
            ' Bu ayar SSL/TLS secure channel hatalarını önler
            System.Net.ServicePointManager.SecurityProtocol =
                System.Net.SecurityProtocolType.Tls12 Or
                System.Net.SecurityProtocolType.Tls11 Or
                System.Net.SecurityProtocolType.Tls

            Log("INFO", "Form_Load", "✅ SSL/TLS güvenlik protokolü ayarlandı (TLS 1.2/1.1/1.0)")

            ' Eski logları temizle (30 günden eski)
            Try
                EticaretLogger.CleanOldLogs(30)
            Catch cleanEx As Exception
                EticaretLogger.LogWarning($"Eski log temizleme hatası: {cleanEx.Message}")
            End Try

            ' Kaydedilmiş ayarları yükle
            SenkronAyarlariniYukle()
            RefreshTriggerStats()

            EticaretLogger.LogInfo("frm_qukaGonder formu başarıyla yüklendi.")
        Catch ex As Exception
            EticaretLogger.LogError("Form_Load hatası", ex)
            Debug.WriteLine("Form_Load hatası: " & ex.Message)
        End Try
    End Sub

    Private Sub frm_qukaGonder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            ' Mevcut ayarları kaydet
            SenkronAyarlariniKaydet()

            ' Otomatik senkron çalışıyorsa
            If isRunning Then
                Dim result As DialogResult = MessageBox.Show(
                    "Otomatik senkronizasyon çalışıyor." & vbCrLf & vbCrLf &
                    "• EVET: Küçült ve arka planda çalışmaya devam et" & vbCrLf &
                    "• HAYIR: Senkronu durdur ve kapat",
                    "Senkronizasyon Çalışıyor",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' Formu küçült, kapatma
                    e.Cancel = True
                    Me.WindowState = FormWindowState.Minimized
                    EticaretLogger.LogInfo("Form minimize edildi, senkronizasyon arka planda devam ediyor.")
                    Exit Sub
                Else
                    ' Timer'ları durdur ve kapat
                    stokSyncTimer.Stop()
                    siparisSyncTimer.Stop()
                    isRunning = False
                    EticaretLogger.LogInfo("Senkronizasyon durduruldu ve form kapatılıyor.")
                End If
            End If

            ' Uygulama kapanış logu
            EticaretLogger.LogApplicationEnd()
        Catch ex As Exception
            EticaretLogger.LogError("FormClosing hatası", ex)
            Debug.WriteLine("FormClosing hatası: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Senkronizasyon checkbox ayarlarını veritabanından yükler
    ''' </summary>
    Private Sub SenkronAyarlariniYukle()
        Try
            ' Form yüklenirken event'ları engelle
            _isFormLoading = True

            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()

                ' Mevcut checkbox ayarlarını yükle
                chkTumStoklar.Checked = AyarOku(conn, "SENKRON_TUM_STOKLAR") = "1"
                chkFiyatDegisenleri.Checked = AyarOku(conn, "SENKRON_FIYAT_DEGISEN") = "1"
                chkMiktarDegisenleri.Checked = AyarOku(conn, "SENKRON_MIKTAR_DEGISEN") = "1"
                chkResimGonder.Checked = AyarOku(conn, "SENKRON_RESIM_GONDER") = "1"
                chkVaryantGuncelle.Checked = AyarOku(conn, "SENKRON_VARYANT_GUNCELLE") = "1"
                chkKategoriGuncelle.Checked = AyarOku(conn, "SENKRON_KATEGORI_GUNCELLE") = "1"
                chkSiparisAl.Checked = If(AyarOku(conn, "SENKRON_SIPARIS_AL") = "", True, AyarOku(conn, "SENKRON_SIPARIS_AL") = "1")
                chkTumSiparisler.Checked = AyarOku(conn, "SENKRON_TUM_SIPARISLER") = "1"

                ' YENİ: Gönderim Ayarları checkbox'ları
                ' Varsayılan olarak hepsi açık (ilk kullanım için)
                chkTumunuGonder.Checked = If(AyarOku(conn, "GONDERIM_TUMUNU") = "", True, AyarOku(conn, "GONDERIM_TUMUNU") = "1")
                chkMarkaGonder.Checked = If(AyarOku(conn, "GONDERIM_MARKA") = "", True, AyarOku(conn, "GONDERIM_MARKA") = "1")
                chkKategoriGonder.Checked = If(AyarOku(conn, "GONDERIM_KATEGORI") = "", True, AyarOku(conn, "GONDERIM_KATEGORI") = "1")
                chkUzunAciklamaGonder.Checked = If(AyarOku(conn, "GONDERIM_UZUN_ACIKLAMA") = "", True, AyarOku(conn, "GONDERIM_UZUN_ACIKLAMA") = "1")
                chkKisaAciklamaGonder.Checked = If(AyarOku(conn, "GONDERIM_KISA_ACIKLAMA") = "", True, AyarOku(conn, "GONDERIM_KISA_ACIKLAMA") = "1")
                chkSEOGonder.Checked = If(AyarOku(conn, "GONDERIM_SEO") = "", True, AyarOku(conn, "GONDERIM_SEO") = "1")
                chkDesiGonder.Checked = If(AyarOku(conn, "GONDERIM_DESI") = "", True, AyarOku(conn, "GONDERIM_DESI") = "1")
                chkPazaryeriFiyatlari.Checked = If(AyarOku(conn, "GONDERIM_PAZARYERI_FIYAT") = "", False, AyarOku(conn, "GONDERIM_PAZARYERI_FIYAT") = "1")

                ' FIYAT TIPI COMBOBOX DOLDUR
                cmbFiyatTipi.Items.Clear()
                cmbFiyatTipi.Items.Add("WEBP")
                cmbFiyatTipi.Items.Add("1")
                cmbFiyatTipi.Items.Add("2")
                cmbFiyatTipi.Items.Add("3")
                cmbFiyatTipi.Items.Add("4")
                cmbFiyatTipi.Items.Add("5")
                cmbFiyatTipi.Items.Add("A")
                cmbFiyatTipi.Items.Add("M")
                Dim kayitliFiyatTipi As String = AyarOku(conn, "GONDERIM_FIYAT_TIPI")
                If String.IsNullOrEmpty(kayitliFiyatTipi) Then kayitliFiyatTipi = "WEBP"
                Dim fiyatTipiIndex As Integer = cmbFiyatTipi.Items.IndexOf(kayitliFiyatTipi)
                cmbFiyatTipi.SelectedIndex = If(fiyatTipiIndex >= 0, fiyatTipiIndex, 0)

                ' KARGO AYARLARI
                chkKargoEkle.Checked = If(AyarOku(conn, "KARGO_EKLE_AKTIF") = "", False, AyarOku(conn, "KARGO_EKLE_AKTIF") = "1")
                Dim kargoMinTutarStr As String = AyarOku(conn, "KARGO_MIN_TUTAR")
                If Not String.IsNullOrEmpty(kargoMinTutarStr) AndAlso IsNumeric(kargoMinTutarStr) Then
                    txtKargoMinTutar.Value = CDec(kargoMinTutarStr)
                End If
                txtKargoStokKodu.Text = AyarOku(conn, "KARGO_STOK_KODU")

                ' TRIGGER TAB AYARLARI - Bu ayarlar form kapandığında kaybediliyordu, düzeltildi
                chkTriggerAktif.Checked = If(AyarOku(conn, "TRIGGER_AKTIF") = "", False, AyarOku(conn, "TRIGGER_AKTIF") = "1")
                chkTriggerStok.Checked = If(AyarOku(conn, "TRIGGER_STOK") = "", True, AyarOku(conn, "TRIGGER_STOK") = "1")
                chkTriggerFiyat.Checked = If(AyarOku(conn, "TRIGGER_FIYAT") = "", True, AyarOku(conn, "TRIGGER_FIYAT") = "1")
                chkTriggerResim.Checked = If(AyarOku(conn, "TRIGGER_RESIM") = "", True, AyarOku(conn, "TRIGGER_RESIM") = "1")
                chkTriggerKategori.Checked = If(AyarOku(conn, "TRIGGER_KATEGORI") = "", True, AyarOku(conn, "TRIGGER_KATEGORI") = "1")

                ' Timer sürelerini yükle
                Dim stokDakika As String = AyarOku(conn, "SENKRON_STOK_DAKIKA")
                Dim siparisDakika As String = AyarOku(conn, "SENKRON_SIPARIS_DAKIKA")
                Dim triggerDakika As String = AyarOku(conn, "SENKRON_TRIGGER_DAKIKA")

                If Not String.IsNullOrEmpty(stokDakika) AndAlso IsNumeric(stokDakika) Then
                    txtStokTimerDakika.Value = CDec(stokDakika)
                End If

                If Not String.IsNullOrEmpty(siparisDakika) AndAlso IsNumeric(siparisDakika) Then
                    txtSiparisTimerDakika.Value = CDec(siparisDakika)
                End If

                If Not String.IsNullOrEmpty(triggerDakika) AndAlso IsNumeric(triggerDakika) Then
                    txtTriggerTimerDakika.Value = CDec(triggerDakika)
                End If

                conn.Close()
            End Using

            AddLog("Ayarlar yüklendi.")
        Catch ex As Exception
            Debug.WriteLine("SenkronAyarlariniYukle hatası: " & ex.Message)
        Finally
            ' Form yükleme tamamlandı, event'ları aktif et
            _isFormLoading = False
        End Try
    End Sub

    ''' <summary>
    ''' Senkronizasyon checkbox ayarlarını veritabanına kaydeder
    ''' </summary>
    Private Sub SenkronAyarlariniKaydet()
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()

                ' Mevcut checkbox ayarlarını kaydet
                AyarKaydet(conn, "SENKRON_TUM_STOKLAR", If(chkTumStoklar.Checked, "1", "0"))
                AyarKaydet(conn, "SENKRON_FIYAT_DEGISEN", If(chkFiyatDegisenleri.Checked, "1", "0"))
                AyarKaydet(conn, "SENKRON_MIKTAR_DEGISEN", If(chkMiktarDegisenleri.Checked, "1", "0"))
                AyarKaydet(conn, "SENKRON_RESIM_GONDER", If(chkResimGonder.Checked, "1", "0"))
                AyarKaydet(conn, "SENKRON_VARYANT_GUNCELLE", If(chkVaryantGuncelle.Checked, "1", "0"))
                AyarKaydet(conn, "SENKRON_KATEGORI_GUNCELLE", If(chkKategoriGuncelle.Checked, "1", "0"))
                AyarKaydet(conn, "SENKRON_SIPARIS_AL", If(chkSiparisAl.Checked, "1", "0"))
                AyarKaydet(conn, "SENKRON_TUM_SIPARISLER", If(chkTumSiparisler.Checked, "1", "0"))

                ' YENİ: Gönderim Ayarları checkbox'larını kaydet
                AyarKaydet(conn, "GONDERIM_TUMUNU", If(chkTumunuGonder.Checked, "1", "0"))
                AyarKaydet(conn, "GONDERIM_MARKA", If(chkMarkaGonder.Checked, "1", "0"))
                AyarKaydet(conn, "GONDERIM_KATEGORI", If(chkKategoriGonder.Checked, "1", "0"))
                AyarKaydet(conn, "GONDERIM_UZUN_ACIKLAMA", If(chkUzunAciklamaGonder.Checked, "1", "0"))
                AyarKaydet(conn, "GONDERIM_KISA_ACIKLAMA", If(chkKisaAciklamaGonder.Checked, "1", "0"))
                AyarKaydet(conn, "GONDERIM_SEO", If(chkSEOGonder.Checked, "1", "0"))
                AyarKaydet(conn, "GONDERIM_DESI", If(chkDesiGonder.Checked, "1", "0"))
                AyarKaydet(conn, "GONDERIM_PAZARYERI_FIYAT", If(chkPazaryeriFiyatlari.Checked, "1", "0"))

                ' KARGO AYARLARINI KAYDET
                AyarKaydet(conn, "KARGO_EKLE_AKTIF", If(chkKargoEkle.Checked, "1", "0"))
                AyarKaydet(conn, "KARGO_MIN_TUTAR", txtKargoMinTutar.Value.ToString())
                AyarKaydet(conn, "KARGO_STOK_KODU", txtKargoStokKodu.Text.Trim())

                ' TRIGGER TAB AYARLARINI KAYDET - Bu ayarlar form kapandığında kaybediliyordu, düzeltildi
                AyarKaydet(conn, "TRIGGER_AKTIF", If(chkTriggerAktif.Checked, "1", "0"))
                AyarKaydet(conn, "TRIGGER_STOK", If(chkTriggerStok.Checked, "1", "0"))
                AyarKaydet(conn, "TRIGGER_FIYAT", If(chkTriggerFiyat.Checked, "1", "0"))
                AyarKaydet(conn, "TRIGGER_RESIM", If(chkTriggerResim.Checked, "1", "0"))
                AyarKaydet(conn, "TRIGGER_KATEGORI", If(chkTriggerKategori.Checked, "1", "0"))

                ' Timer sürelerini kaydet
                AyarKaydet(conn, "SENKRON_STOK_DAKIKA", txtStokTimerDakika.Value.ToString())
                AyarKaydet(conn, "SENKRON_SIPARIS_DAKIKA", txtSiparisTimerDakika.Value.ToString())
                AyarKaydet(conn, "SENKRON_TRIGGER_DAKIKA", txtTriggerTimerDakika.Value.ToString())

                conn.Close()
            End Using
        Catch ex As Exception
            Debug.WriteLine("SenkronAyarlariniKaydet hatası: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Stok timer süresi değiştiğinde veritabanına kaydet
    ''' </summary>
    Private Sub txtStokTimerDakika_ValueChanged(sender As Object, e As EventArgs) Handles txtStokTimerDakika.ValueChanged
        If _isFormLoading Then Exit Sub
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                AyarKaydet(conn, "SENKRON_STOK_DAKIKA", txtStokTimerDakika.Value.ToString())
                conn.Close()
            End Using
        Catch ex As Exception
            Debug.WriteLine("Stok timer kaydetme hatası: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Sipariş timer süresi değiştiğinde veritabanına kaydet
    ''' </summary>
    Private Sub txtSiparisTimerDakika_ValueChanged(sender As Object, e As EventArgs) Handles txtSiparisTimerDakika.ValueChanged
        If _isFormLoading Then Exit Sub
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                AyarKaydet(conn, "SENKRON_SIPARIS_DAKIKA", txtSiparisTimerDakika.Value.ToString())
                conn.Close()
            End Using
        Catch ex As Exception
            Debug.WriteLine("Sipariş timer kaydetme hatası: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Trigger timer süresi değiştiğinde veritabanına kaydet
    ''' </summary>
    Private Sub txtTriggerTimerDakika_ValueChanged(sender As Object, e As EventArgs) Handles txtTriggerTimerDakika.ValueChanged
        If _isFormLoading Then Exit Sub
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                AyarKaydet(conn, "SENKRON_TRIGGER_DAKIKA", txtTriggerTimerDakika.Value.ToString())
                conn.Close()
            End Using
        Catch ex As Exception
            Debug.WriteLine("Trigger timer kaydetme hatası: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Fiyat tipi değiştiğinde veritabanına kaydet
    ''' </summary>
    Private Sub cmbFiyatTipi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiyatTipi.SelectedIndexChanged
        If _isFormLoading Then Exit Sub
        Try
            If cmbFiyatTipi.SelectedItem IsNot Nothing Then
                Using conn As New OleDb.OleDbConnection(connection)
                    conn.Open()
                    AyarKaydet(conn, "GONDERIM_FIYAT_TIPI", cmbFiyatTipi.SelectedItem.ToString())
                    conn.Close()
                End Using
            End If
        Catch ex As Exception
            Debug.WriteLine("Fiyat tipi kaydetme hatası: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Kargo Stok Kodu alanına tıklandığında stok listesi açılır
    ''' </summary>
    Private Sub txtKargoStokKodu_Click(sender As Object, e As EventArgs) Handles txtKargoStokKodu.Click
        Try
            Dim frmStokListe As New frm_stok_liste()
            frmStokListe.connection = connection
            frmStokListe.firmano = firmano
            frmStokListe.donemno = donemno
            frmStokListe.islemstatus = True
            frmStokListe.StartPosition = FormStartPosition.CenterParent

            If frmStokListe.ShowDialog() = DialogResult.OK Then
                ' Seçilen stok bilgilerini al
                If frmStokListe.secili_nStokID <> 0 Then
                    ' Barkod veya stok kodunu al
                    Dim barkod As String = ""
                    Using conn As New OleDb.OleDbConnection(connection)
                        conn.Open()
                        Using cmd As New OleDb.OleDbCommand("SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = ?", conn)
                            cmd.Parameters.AddWithValue("?", frmStokListe.secili_nStokID)
                            Dim result = cmd.ExecuteScalar()
                            If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                                barkod = result.ToString().Trim()
                            End If
                        End Using
                        conn.Close()
                    End Using

                    If Not String.IsNullOrEmpty(barkod) Then
                        txtKargoStokKodu.Text = barkod
                        ' Ayarı hemen kaydet
                        Using conn As New OleDb.OleDbConnection(connection)
                            conn.Open()
                            AyarKaydet(conn, "KARGO_STOK_KODU", barkod)
                            conn.Close()
                        End Using
                    End If
                End If
            End If
        Catch ex As Exception
            Debug.WriteLine("Kargo stok seçimi hatası: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Kargo Ekle checkbox değiştiğinde veritabanına kaydet
    ''' </summary>
    Private Sub chkKargoEkle_CheckedChanged(sender As Object, e As EventArgs) Handles chkKargoEkle.CheckedChanged
        If _isFormLoading Then Exit Sub
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                AyarKaydet(conn, "KARGO_EKLE_AKTIF", If(chkKargoEkle.Checked, "1", "0"))
                conn.Close()
            End Using
            AddLog($"📦 Kargo bedeli ekleme: {If(chkKargoEkle.Checked, "AKTİF", "KAPALI")}")
        Catch ex As Exception
            Debug.WriteLine("chkKargoEkle kaydetme hatası: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Kargo Min Tutar değiştiğinde veritabanına kaydet
    ''' </summary>
    Private Sub txtKargoMinTutar_ValueChanged(sender As Object, e As EventArgs) Handles txtKargoMinTutar.ValueChanged
        ' Form yüklenirken kaydetme
        If _isFormLoading Then Exit Sub

        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                AyarKaydet(conn, "KARGO_MIN_TUTAR", txtKargoMinTutar.Value.ToString())
                conn.Close()
            End Using
            AddLog($"📦 Kargo minimum tutar güncellendi: {txtKargoMinTutar.Value:N2} TL")
        Catch ex As Exception
            Debug.WriteLine("txtKargoMinTutar kaydetme hatası: " & ex.Message)
        End Try
    End Sub

#Region "Senkronizasyon Kriterleri CheckedChanged Event Handler'ları"

    Private Sub chkTumStoklar_CheckedChanged(sender As Object, e As EventArgs) Handles chkTumStoklar.CheckedChanged
        AyarKaydetHizli("SENKRON_TUM_STOKLAR", chkTumStoklar.Checked)
    End Sub

    Private Sub chkFiyatDegisenleri_CheckedChanged(sender As Object, e As EventArgs) Handles chkFiyatDegisenleri.CheckedChanged
        AyarKaydetHizli("SENKRON_FIYAT_DEGISEN", chkFiyatDegisenleri.Checked)
    End Sub

    Private Sub chkMiktarDegisenleri_CheckedChanged(sender As Object, e As EventArgs) Handles chkMiktarDegisenleri.CheckedChanged
        AyarKaydetHizli("SENKRON_MIKTAR_DEGISEN", chkMiktarDegisenleri.Checked)
    End Sub

    Private Sub chkResimGonder_CheckedChanged(sender As Object, e As EventArgs) Handles chkResimGonder.CheckedChanged
        AyarKaydetHizli("SENKRON_RESIM_GONDER", chkResimGonder.Checked)
    End Sub

    Private Sub chkVaryantGuncelle_CheckedChanged(sender As Object, e As EventArgs) Handles chkVaryantGuncelle.CheckedChanged
        AyarKaydetHizli("SENKRON_VARYANT_GUNCELLE", chkVaryantGuncelle.Checked)
    End Sub

    Private Sub chkKategoriGuncelle_CheckedChanged(sender As Object, e As EventArgs) Handles chkKategoriGuncelle.CheckedChanged
        AyarKaydetHizli("SENKRON_KATEGORI_GUNCELLE", chkKategoriGuncelle.Checked)
    End Sub

    Private Sub chkSiparisAl_CheckedChanged(sender As Object, e As EventArgs) Handles chkSiparisAl.CheckedChanged
        AyarKaydetHizli("SENKRON_SIPARIS_AL", chkSiparisAl.Checked)
    End Sub

    Private Sub chkTumSiparisler_CheckedChanged(sender As Object, e As EventArgs) Handles chkTumSiparisler.CheckedChanged
        AyarKaydetHizli("SENKRON_TUM_SIPARISLER", chkTumSiparisler.Checked)
    End Sub

#End Region

#Region "Gönderim Ayarları CheckedChanged Event Handler'ları"

    Private Sub chkTumunuGonder_CheckedChanged(sender As Object, e As EventArgs) Handles chkTumunuGonder.CheckedChanged
        AyarKaydetHizli("GONDERIM_TUMUNU", chkTumunuGonder.Checked)
    End Sub

    Private Sub chkMarkaGonder_CheckedChanged(sender As Object, e As EventArgs) Handles chkMarkaGonder.CheckedChanged
        AyarKaydetHizli("GONDERIM_MARKA", chkMarkaGonder.Checked)
    End Sub

    Private Sub chkKategoriGonder_CheckedChanged(sender As Object, e As EventArgs) Handles chkKategoriGonder.CheckedChanged
        AyarKaydetHizli("GONDERIM_KATEGORI", chkKategoriGonder.Checked)
    End Sub

    Private Sub chkUzunAciklamaGonder_CheckedChanged(sender As Object, e As EventArgs) Handles chkUzunAciklamaGonder.CheckedChanged
        AyarKaydetHizli("GONDERIM_UZUN_ACIKLAMA", chkUzunAciklamaGonder.Checked)
    End Sub

    Private Sub chkKisaAciklamaGonder_CheckedChanged(sender As Object, e As EventArgs) Handles chkKisaAciklamaGonder.CheckedChanged
        AyarKaydetHizli("GONDERIM_KISA_ACIKLAMA", chkKisaAciklamaGonder.Checked)
    End Sub

    Private Sub chkSEOGonder_CheckedChanged(sender As Object, e As EventArgs) Handles chkSEOGonder.CheckedChanged
        AyarKaydetHizli("GONDERIM_SEO", chkSEOGonder.Checked)
    End Sub

    Private Sub chkDesiGonder_CheckedChanged(sender As Object, e As EventArgs) Handles chkDesiGonder.CheckedChanged
        AyarKaydetHizli("GONDERIM_DESI", chkDesiGonder.Checked)
    End Sub

    Private Sub chkPazaryeriFiyatlari_CheckedChanged(sender As Object, e As EventArgs) Handles chkPazaryeriFiyatlari.CheckedChanged
        AyarKaydetHizli("GONDERIM_PAZARYERI_FIYAT", chkPazaryeriFiyatlari.Checked)
    End Sub

#End Region

#Region "Trigger Ayarları CheckedChanged Event Handler'ları"

    Private Sub chkTriggerAktif_CheckedChanged(sender As Object, e As EventArgs) Handles chkTriggerAktif.CheckedChanged
        AyarKaydetHizli("TRIGGER_AKTIF", chkTriggerAktif.Checked)
    End Sub

    Private Sub chkTriggerStok_CheckedChanged(sender As Object, e As EventArgs) Handles chkTriggerStok.CheckedChanged
        AyarKaydetHizli("TRIGGER_STOK", chkTriggerStok.Checked)
    End Sub

    Private Sub chkTriggerFiyat_CheckedChanged(sender As Object, e As EventArgs) Handles chkTriggerFiyat.CheckedChanged
        AyarKaydetHizli("TRIGGER_FIYAT", chkTriggerFiyat.Checked)
    End Sub

    Private Sub chkTriggerResim_CheckedChanged(sender As Object, e As EventArgs) Handles chkTriggerResim.CheckedChanged
        AyarKaydetHizli("TRIGGER_RESIM", chkTriggerResim.Checked)
    End Sub

    Private Sub chkTriggerKategori_CheckedChanged(sender As Object, e As EventArgs) Handles chkTriggerKategori.CheckedChanged
        AyarKaydetHizli("TRIGGER_KATEGORI", chkTriggerKategori.Checked)
    End Sub

#End Region

    ''' <summary>
    ''' Checkbox değerini hızlıca veritabanına kaydeder (yardımcı fonksiyon)
    ''' </summary>
    Private Sub AyarKaydetHizli(ayarKodu As String, deger As Boolean)
        ' Form yüklenirken kaydetme
        If _isFormLoading Then Exit Sub

        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                AyarKaydet(conn, ayarKodu, If(deger, "1", "0"))
                conn.Close()
            End Using
        Catch ex As Exception
            Debug.WriteLine($"AyarKaydetHizli hatası ({ayarKodu}): " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' tbSistemAyar tablosundan ayar okur
    ''' </summary>
    Private Function AyarOku(conn As OleDb.OleDbConnection, sAyarKodu As String) As String
        Try
            Using cmd As New OleDb.OleDbCommand("SELECT sAyarDeger FROM tbSistemAyar WHERE sAyarKodu = ?", conn)
                cmd.Parameters.AddWithValue("?", sAyarKodu)
                Dim result As Object = cmd.ExecuteScalar()
                Return If(result IsNot Nothing AndAlso result IsNot DBNull.Value, result.ToString(), "")
            End Using
        Catch
            Return ""
        End Try
    End Function

    ''' <summary>
    ''' tbSistemAyar tablosuna ayar kaydeder (varsa günceller, yoksa ekler)
    ''' </summary>
    Private Sub AyarKaydet(conn As OleDb.OleDbConnection, sAyarKodu As String, sAyarDeger As String)
        Try
            ' Önce var mı kontrol et
            Dim mevcutMu As Boolean = False
            Using checkCmd As New OleDb.OleDbCommand("SELECT COUNT(*) FROM tbSistemAyar WHERE sAyarKodu = ?", conn)
                checkCmd.Parameters.AddWithValue("?", sAyarKodu)
                mevcutMu = CInt(checkCmd.ExecuteScalar()) > 0
            End Using

            If mevcutMu Then
                ' Güncelle
                Using updateCmd As New OleDb.OleDbCommand("UPDATE tbSistemAyar SET sAyarDeger = ? WHERE sAyarKodu = ?", conn)
                    updateCmd.Parameters.AddWithValue("?", sAyarDeger)
                    updateCmd.Parameters.AddWithValue("?", sAyarKodu)
                    updateCmd.ExecuteNonQuery()
                End Using
            Else
                ' Yeni kayıt ekle
                Using insertCmd As New OleDb.OleDbCommand("INSERT INTO tbSistemAyar (sAyarKodu, sAyarDeger, sAciklama) VALUES (?, ?, ?)", conn)
                    insertCmd.Parameters.AddWithValue("?", sAyarKodu)
                    insertCmd.Parameters.AddWithValue("?", sAyarDeger)
                    insertCmd.Parameters.AddWithValue("?", "E-Ticaret Senkronizasyon Ayarı")
                    insertCmd.ExecuteNonQuery()
                End Using
            End If
        Catch ex As Exception
            Debug.WriteLine($"AyarKaydet hatası ({sAyarKodu}): " & ex.Message)
        End Try
    End Sub

    ' ===== TRIGGER TAB EVENT HANDLER'LARI SONU =====

    ' ===== SINIF EŞLEŞTİRME YARDIMCI FONKSİYONLARI =====

    ''' <summary>
    ''' Sınıf eşleştirme ayarlarından SQL alan adını döndürür
    ''' </summary>
    Private Function GetSinifEslemeSqlField(conn As OleDb.OleDbConnection, ayarKodu As String, varsayilan As String, aliasName As String) As String
        Dim fieldCode As String = varsayilan

        Try
            Using cmd As New OleDb.OleDbCommand($"SELECT sAyarDeger FROM tbSistemAyar WHERE sAyarKodu = '{ayarKodu}'", conn)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso result IsNot DBNull.Value AndAlso Not String.IsNullOrEmpty(result.ToString()) Then
                    fieldCode = result.ToString()
                End If
            End Using
        Catch
        End Try

        If String.IsNullOrEmpty(fieldCode) Then
            Return $"'' AS {aliasName}"
        End If

        ' Sınıf alanları için lookup
        If fieldCode.StartsWith("sSinifKodu") Then
            Dim sinifNo As String = fieldCode.Replace("sSinifKodu", "")
            Return $"(SELECT sAciklama FROM [tbSSinif{sinifNo}] WHERE sSinifKodu=T3.{fieldCode}) AS {aliasName}"
        End If

        ' Doğrudan alan (sGrup1, sModel, sRenk vs.)
        If fieldCode.StartsWith("sGrup") Then
            Return $"T1.{fieldCode} AS {aliasName}"
        End If

        Return $"T1.{fieldCode} AS {aliasName}"
    End Function

    ''' <summary>
    ''' Dinamik sınıf eşleştirmeli SQL sorgusu oluşturur
    ''' </summary>
    Private Function BuildProductSqlWithSinifEsleme(conn As OleDb.OleDbConnection) As String
        Dim markaField As String = GetSinifEslemeSqlField(conn, "ETICARET_SINIF_MARKA", "sSinifKodu3", "marka")
        Dim cat1Field As String = GetSinifEslemeSqlField(conn, "ETICARET_SINIF_KAT1", "sSinifKodu4", "cat1")
        Dim cat2Field As String = GetSinifEslemeSqlField(conn, "ETICARET_SINIF_KAT2", "sSinifKodu5", "cat2")
        Dim cat3Field As String = GetSinifEslemeSqlField(conn, "ETICARET_SINIF_KAT3", "sSinifKodu6", "cat3")
        Dim cat4Field As String = GetSinifEslemeSqlField(conn, "ETICARET_SINIF_KAT4", "sSinifKodu7", "cat4")
        Dim cat5Field As String = GetSinifEslemeSqlField(conn, "ETICARET_SINIF_KAT5", "sSinifKodu8", "cat5")
        Dim etiket1Field As String = GetSinifEslemeSqlField(conn, "ETICARET_SINIF_ETIKET1", "sSinifKodu5", "etiket1")
        Dim etiket2Field As String = GetSinifEslemeSqlField(conn, "ETICARET_SINIF_ETIKET2", "sSinifKodu6", "etiket2")
        Dim etiket3Field As String = GetSinifEslemeSqlField(conn, "ETICARET_SINIF_ETIKET3", "sSinifKodu7", "etiket3")

        ' Seçilen fiyat tipini al
        Dim seciliFiyatTipi As String = GetSeciliFiyatTipi()

        Return "SELECT T1.nStokID, T1.sKodu, T1.sBeden, T1.sAciklama, T1.sKisaAdi," &
               " T1.sModel," &
               " T1.sRenk," &
               " T1.nEn," &
               " T1.nBoy," &
               " T1.nYukseklik," &
               " T1.nAgirlik," &
               " T2.nKdvOrani," &
               " (SELECT lFiyat FROM tbStokFiyati WHERE nStokID=T1.nStokID AND sFiyatTipi='2') AS TRENDYOL_SATIS," &
               " (SELECT lFiyat FROM tbStokFiyati WHERE nStokID=T1.nStokID AND sFiyatTipi='3') AS HB_SATIS," &
               " (SELECT lFiyat FROM tbStokFiyati WHERE nStokID=T1.nStokID AND sFiyatTipi='4') AS N11_SATIS," &
               " (SELECT lFiyat FROM tbStokFiyati WHERE nStokID=T1.nStokID AND sFiyatTipi='" & seciliFiyatTipi & "') AS SITE_SATIS," &
               " (SELECT lFiyat FROM tbStokFiyati WHERE nStokID=T1.nStokID AND sFiyatTipi='A') AS ALIS_FIYAT," &
               $" {markaField}," &
               $" {cat1Field}," &
               $" {cat2Field}," &
               $" {cat3Field}," &
               $" {cat4Field}," &
               $" {cat5Field}," &
               $" {etiket1Field}," &
               $" {etiket2Field}," &
               $" {etiket3Field}," &
               " T4.sSEOBaslik," &
               " T4.sMetaDescription," &
               " T4.sKisaAciklama," &
               " T4.sAnahtarKelimeler," &
               " T4.nIcerikPuani," &
               " T5.sUzunNot," &
               " T5.sBedenTablosu," &
               " T5.sOzellikler," &
               " T5.sKullanimTalimati " &
               "FROM [tbStok] AS T1 " &
               "LEFT JOIN [tbKdv] AS T2 ON T2.sKdvTipi=T1.sKdvTipi " &
               "LEFT JOIN [tbStokSinifi] AS T3 ON T3.nStokID=T1.nStokID " &
               "LEFT JOIN [tbStokAIIcerik] AS T4 ON T4.sModel=? " &
               "LEFT JOIN [tbStokUzunNot] AS T5 ON T5.sModel=? " &
               "WHERE T1.sModel = ? AND T1.sRenk = ? AND T1.bWebGoruntule='1' " &
               "ORDER BY T1.nStokID ASC"
    End Function

    ''' <summary>
    ''' Sınıf Eşleştirme Ayarları butonuna tıklandığında
    ''' </summary>
    Private Sub btnSinifEsleme_Click(sender As Object, e As EventArgs) Handles btnSinifEsleme.Click
        Try
            Dim frm As New frm_SinifEsleme()
            frm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show($"Sınıf eşleştirme formu açılamadı: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ===== SINIF EŞLEŞTİRME YARDIMCI FONKSİYONLARI SONU =====

    ' ===== MANUEL GÜNCELLEME BUTON EVENT HANDLER'LARI =====

    ''' <summary>
    ''' Kategorileri Güncelle butonu - Status kontrolü yapmadan TÜM kategorileri günceller
    ''' </summary>
    Private Sub btnKategoriGuncelle_Click(sender As Object, e As EventArgs) Handles btnKategoriGuncelle.Click
        Try
            AddLog("Manuel kategori güncelleme başlatılıyor (tüm ürünler)...")
            btnKategoriGuncelle.Enabled = False
            lblDurum.Text = "Durum: TÜM kategoriler güncelleniyor..."

            ' Arka planda çalıştır
            Task.Run(Sub()
                         Try
                             LoadConfig()
                             ManuelKategoriGuncelle()  ' Status kontrolü yapmayan yeni fonksiyon

                             Me.Invoke(Sub()
                                           RefreshTriggerStats()
                                           btnKategoriGuncelle.Enabled = True
                                           lblDurum.Text = "Durum: Kategori güncelleme tamamlandı"
                                           AddLog("Manuel kategori güncelleme tamamlandı!")
                                       End Sub)
                         Catch ex As Exception
                             Me.Invoke(Sub()
                                           btnKategoriGuncelle.Enabled = True
                                           lblDurum.Text = "Durum: Hata!"
                                           AddLog("Kategori güncelleme hatası: " & ex.Message)
                                       End Sub)
                         End Try
                     End Sub)

        Catch ex As Exception
            btnKategoriGuncelle.Enabled = True
            AddLog("Kategori güncelleme hatası: " & ex.Message)
            XtraMessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Resimleri Güncelle butonu - Status kontrolü yapmadan TÜM resimleri günceller
    ''' </summary>
    Private Sub btnResimGuncelle_Click(sender As Object, e As EventArgs) Handles btnResimGuncelle.Click
        Try
            AddLog("Manuel resim güncelleme başlatılıyor (tüm ürünler)...")
            btnResimGuncelle.Enabled = False
            lblDurum.Text = "Durum: TÜM resimler güncelleniyor..."

            ' Arka planda çalıştır
            Task.Run(Sub()
                         Try
                             LoadConfig()
                             ManuelResimGuncelle()  ' Status kontrolü yapmayan yeni fonksiyon

                             Me.Invoke(Sub()
                                           RefreshTriggerStats()
                                           btnResimGuncelle.Enabled = True
                                           lblDurum.Text = "Durum: Resim güncelleme tamamlandı"
                                           AddLog("Manuel resim güncelleme tamamlandı!")
                                       End Sub)
                         Catch ex As Exception
                             Me.Invoke(Sub()
                                           btnResimGuncelle.Enabled = True
                                           lblDurum.Text = "Durum: Hata!"
                                           AddLog("Resim güncelleme hatası: " & ex.Message)
                                       End Sub)
                         End Try
                     End Sub)

        Catch ex As Exception
            btnResimGuncelle.Enabled = True
            AddLog("Resim güncelleme hatası: " & ex.Message)
            XtraMessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Manuel Kategori Güncelleme - Status kontrolü yapmadan TÜM ürünlerin kategorilerini günceller
    ''' </summary>
    Private Sub ManuelKategoriGuncelle()
        Try
            Log("INFO", "ManuelKategoriGuncelle", "TÜM ürünler için kategori güncelleme başlatılıyor (status kontrolü yok)...")

            Dim categoryUpdates As New List(Of Dictionary(Of String, Object))
            Dim processedCount As Integer = 0

            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()

                ' products tablosundaki TÜM ürünleri al (status kontrolü YOK)
                Dim sql As String =
                "SELECT DISTINCT p.productID " &
                "FROM products p " &
                "WHERE p.productID IS NOT NULL AND p.productID <> '' " &
                "ORDER BY p.productID"

                Using cmd As New OleDb.OleDbCommand(sql, conn)
                    Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim prodID As String = If(reader("productID") Is DBNull.Value, "", reader("productID").ToString().Trim())
                            If String.IsNullOrEmpty(prodID) Then Continue While

                            Dim parts As String() = prodID.Split(New String() {"__"}, StringSplitOptions.None)
                            If parts.Length < 1 OrElse String.IsNullOrEmpty(parts(0)) Then Continue While

                            Dim sModel As String = parts(0).Trim()
                            Dim sRenk As String = If(parts.Length > 1, parts(1).Trim(), "")  ' Varyansız ise boş

                            Try
                                ' tbStokSinifi'den kategori kodlarını al
                                Dim catSql As String =
                                "SELECT SS.sSinifKodu4, SS.sSinifKodu5, SS.sSinifKodu6, SS.sSinifKodu7, SS.sSinifKodu8 " &
                                "FROM tbStokSinifi SS " &
                                "INNER JOIN tbStok S ON SS.nStokID = S.nStokID " &
                                "WHERE S.sModel = ? AND S.sRenk = ?"

                                Dim categories As New List(Of Integer)

                                Using catCmd As New OleDb.OleDbCommand(catSql, conn)
                                    catCmd.Parameters.AddWithValue("?", sModel)
                                    catCmd.Parameters.AddWithValue("?", sRenk)
                                    Using catReader As OleDb.OleDbDataReader = catCmd.ExecuteReader()
                                        If catReader.Read() Then
                                            For i As Integer = 4 To 8
                                                Dim colName As String = "sSinifKodu" & i.ToString()
                                                If Not catReader.IsDBNull(catReader.GetOrdinal(colName)) Then
                                                    Dim sinifKodu As String = catReader(colName).ToString().Trim()
                                                    If Not String.IsNullOrEmpty(sinifKodu) Then
                                                        Dim catId As Integer
                                                        If Integer.TryParse(sinifKodu, catId) Then
                                                            categories.Add(catId)
                                                        End If
                                                    End If
                                                End If
                                            Next
                                        End If
                                    End Using
                                End Using

                                If categories.Count > 0 Then
                                    categoryUpdates.Add(New Dictionary(Of String, Object) From {
                                        {"code", prodID},
                                        {"categories", categories}
                                    })
                                    processedCount += 1
                                End If

                            Catch catEx As Exception
                                Log("WARNING", "ManuelKategoriGuncelle", $"Kategori alınamadı ({prodID}): {catEx.Message}")
                            End Try
                        End While
                    End Using
                End Using

                If categoryUpdates.Count = 0 Then
                    Log("INFO", "ManuelKategoriGuncelle", "Güncellenecek kategori bulunamadı")
                    Return
                End If

                Log("INFO", "ManuelKategoriGuncelle", $"{categoryUpdates.Count} ürün için kategori güncellenecek")

                ' Toplu güncelleme yap
                Dim success As Boolean = UpdateProductCategories(categoryUpdates)

                If success Then
                    Log("INFO", "ManuelKategoriGuncelle", $"Kategori güncelleme tamamlandı. {categoryUpdates.Count} ürün güncellendi.")
                Else
                    Log("WARNING", "ManuelKategoriGuncelle", "Kategori güncelleme kısmen başarısız oldu")
                End If

                conn.Close()
            End Using

        Catch ex As Exception
            Log("ERROR", "ManuelKategoriGuncelle", "Hata: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Manuel Resim Güncelleme - Status kontrolü yapmadan TÜM ürünlerin resimlerini günceller
    ''' </summary>
    Private Sub ManuelResimGuncelle()
        Try
            Log("INFO", "ManuelResimGuncelle", "TÜM ürünler için resim güncelleme başlatılıyor (status kontrolü yok)...")

            Dim successCount As Integer = 0
            Dim errorCount As Integer = 0

            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()

                ' product_images tablosundaki TÜM ürünleri al (status kontrolü YOK)
                Dim sql As String =
                "SELECT DISTINCT productID " &
                "FROM product_images " &
                "WHERE productID IS NOT NULL AND productID <> '' " &
                "ORDER BY productID"

                Dim productList As New List(Of String)

                Using cmd As New OleDb.OleDbCommand(sql, conn)
                    Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim prodID As String = If(reader("productID") Is DBNull.Value, "", reader("productID").ToString().Trim())
                            If Not String.IsNullOrEmpty(prodID) Then
                                productList.Add(prodID)
                            End If
                        End While
                    End Using
                End Using

                If productList.Count = 0 Then
                    Log("INFO", "ManuelResimGuncelle", "Güncellenecek resim bulunamadı")
                    Return
                End If

                Log("INFO", "ManuelResimGuncelle", $"{productList.Count} ürün için resim güncellenecek")

                ' Her ürün için resim gönder
                For Each prodID As String In productList
                    Dim parts As String() = prodID.Split(New String() {"__"}, StringSplitOptions.None)
                    If parts.Length < 1 OrElse String.IsNullOrEmpty(parts(0)) Then Continue For

                    Dim sModel As String = parts(0).Trim()
                    Dim sRenk As String = If(parts.Length > 1, parts(1).Trim(), "")  ' Varyansız ise boş

                    Try
                        ' Resim URL'lerini al (nSira 1-5 için GROUP BY)
                        Dim images As New List(Of String)
                        Dim imageSql As String =
                        "SELECT nSira, MIN(yol) AS yol " &
                        "FROM tbStokResim " &
                        "WHERE sModel = ? AND sRenk = ? AND yol IS NOT NULL AND yol <> '' AND nSira BETWEEN 1 AND 5 " &
                        "GROUP BY nSira " &
                        "ORDER BY nSira"

                        Using imgCmd As New OleDb.OleDbCommand(imageSql, conn)
                            imgCmd.Parameters.AddWithValue("?", sModel)
                            imgCmd.Parameters.AddWithValue("?", sRenk)
                            Using imgReader As OleDb.OleDbDataReader = imgCmd.ExecuteReader()
                                While imgReader.Read()
                                    Try
                                        Dim yol As String = If(imgReader("yol") Is DBNull.Value, "", imgReader("yol").ToString().Trim())
                                        If Not String.IsNullOrEmpty(yol) Then
                                            ' URL formatına çevir
                                            Dim imageUrl As String = yol
                                            If Not imageUrl.StartsWith("http") Then
                                                imageUrl = LAGlobalAddress & "/images/" & imageUrl
                                            End If
                                            images.Add(imageUrl)
                                        End If
                                    Catch imgEx As Exception
                                        Log("WARNING", "ManuelResimGuncelle", $"Resim okuma hatası: {imgEx.Message}")
                                    End Try
                                End While
                            End Using
                        End Using

                        If images.Count > 0 Then
                            ' API'ye gönder
                            Dim imageData As New Dictionary(Of String, Object)
                            imageData("code") = prodID

                            Dim imageList As New List(Of Dictionary(Of String, Object))
                            For Each imgUrl As String In images
                                imageList.Add(New Dictionary(Of String, Object) From {{"imageUrl", imgUrl}})
                            Next
                            imageData("images") = imageList

                            Dim apiResult As Boolean = SendImagesToAPI(imageData)

                            If apiResult Then
                                successCount += 1
                                Log("INFO", "ManuelResimGuncelle", $"Resim gönderildi: {prodID} ({images.Count} adet)")
                            Else
                                errorCount += 1
                                Log("ERROR", "ManuelResimGuncelle", $"Resim gönderilemedi: {prodID}")
                            End If
                        End If

                    Catch imgEx As Exception
                        errorCount += 1
                        Log("ERROR", "ManuelResimGuncelle", "Resim hatası (" & prodID & "): " & imgEx.Message)
                    End Try

                    ' Rate limiting
                    System.Threading.Thread.Sleep(500)
                Next

                Log("INFO", "ManuelResimGuncelle", $"Resim güncelleme tamamlandı. Başarılı: {successCount}, Hatalı: {errorCount}")

                conn.Close()
            End Using

        Catch ex As Exception
            Log("ERROR", "ManuelResimGuncelle", "Hata: " & ex.Message)
        End Try
    End Sub

    ' ===== MANUEL GÜNCELLEME BUTON EVENT HANDLER'LARI SONU =====

    ' ===== TRIGGER TABANLI SENKRONIZASYON FONKSİYONLARI SONU =====

    ' ========================================================================
    ' WEB'DE OLMAYAN ÜRÜNLERİ KONTROL ET VE TEMİZLE
    ' ========================================================================

    ''' <summary>
    ''' Products tablosundaki ürünlerin gerçekten web'de olup olmadığını kontrol eder
    ''' Web'de OLMAYAN ürünleri temizler (status=0 veya siler)
    ''' Böylece tekrar gönderilebilir hale gelir
    ''' </summary>
    Public Sub KontrolEtWebdeOlmayanlar()
        Try
            Log("INFO", "KontrolEtWebdeOlmayanlar", "Web'de olmayan ürünler kontrol ediliyor...")

            ' API ayarlarının yüklü olduğunu kontrol et, yoksa yükle
            If String.IsNullOrEmpty(LAGlobalAddress) OrElse String.IsNullOrEmpty(ApiKey) OrElse String.IsNullOrEmpty(ApiSecret) Then
                Log("WARNING", "KontrolEtWebdeOlmayanlar", "API ayarları yüklü değil, yükleniyor...")
                Using conn As New OleDbConnection(connection)
                    conn.Open()
                    Dim cmd As New OleDbCommand("SELECT TOP 1 ApiKey, ApiSecret, ProductSave FROM tbParamGenel WHERE ApiKey IS NOT NULL", conn)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ApiKey = If(reader("ApiKey") Is DBNull.Value, "", reader("ApiKey").ToString().Trim())
                            ApiSecret = If(reader("ApiSecret") Is DBNull.Value, "", reader("ApiSecret").ToString().Trim())
                            LAGlobalAddress = If(reader("ProductSave") Is DBNull.Value, "", reader("ProductSave").ToString().Trim())
                            Log("SUCCESS", "KontrolEtWebdeOlmayanlar", $"API ayarları yüklendi: URL={LAGlobalAddress}")
                        End If
                    End Using
                End Using

                ' Hala boşsa hata ver
                If String.IsNullOrEmpty(LAGlobalAddress) Then
                    MessageBox.Show("API ayarları yüklenmemiş! Lütfen önce API ayarlarını yapılandırın.",
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End If

            Dim silinecekUrunler As New List(Of String)
            Dim kontrolEdilen As Integer = 0
            Dim bulunamayan As Integer = 0

            Using conn As New OleDbConnection(connection)
                conn.Open()

                ' Products tablosundaki TÜM ürünleri al (status=1 olanlar - "gönderildi" işaretli)
                Dim cmdProducts As New OleDbCommand(
                    "SELECT productID FROM Products WHERE status = 1", conn)

                Using reader As OleDbDataReader = cmdProducts.ExecuteReader()
                    While reader.Read()
                        kontrolEdilen += 1
                        Dim productID As String = reader("productID").ToString()

                        ' productID formatı: sModel__sRenk
                        Dim parts() As String = productID.Split(New String() {"__"}, StringSplitOptions.None)
                        If parts.Length <> 2 Then Continue While

                        Dim sModel As String = parts(0).Trim()
                        Dim sRenk As String = parts(1).Trim()

                        ' Ürünün barkodunu al (web'de sorgulamak için)
                        Dim barkod As String = GetBarkodFromStok(sModel, sRenk, conn)

                        If String.IsNullOrEmpty(barkod) Then
                            Log("WARNING", "KontrolEtWebdeOlmayanlar",
                                $"  {productID} → Barkod bulunamadı, atlanıyor")
                            Continue While
                        End If

                        ' Web servisinde bu ürün var mı kontrol et
                        Dim webdeVar As Boolean = KontrolEtUrunWebdeVar(barkod)

                        If Not webdeVar Then
                            ' Web'de yok - silindi veya hiç gönderilmemiş
                            bulunamayan += 1
                            silinecekUrunler.Add(productID)
                            Log("WARNING", "KontrolEtWebdeOlmayanlar",
                                $"  ❌ {productID} (Barkod: {barkod}) → Web'de BULUNAMADI!")
                        Else
                            Log("SUCCESS", "KontrolEtWebdeOlmayanlar",
                                $"  ✅ {productID} (Barkod: {barkod}) → Web'de mevcut")
                        End If

                        ' Rate limiting - her istek arasında 1 saniye bekle
                        Thread.Sleep(1000)
                    End While
                End Using

                ' Web'de olmayan ürünleri Products tablosundan temizle
                If silinecekUrunler.Count > 0 Then
                    For Each productID As String In silinecekUrunler
                        ' Seçenek 1: Tamamen sil
                        Dim cmdDelete As New OleDbCommand(
                            "DELETE FROM Products WHERE productID = ?", conn)
                        cmdDelete.Parameters.AddWithValue("?", productID)
                        cmdDelete.ExecuteNonQuery()

                        ' Seçenek 2: Status'ü 0 yap (yorum satırı - isterseniz kullanın)
                        ' Dim cmdUpdate As New OleDbCommand(
                        '     "UPDATE Products SET status = 0 WHERE productID = ?", conn)
                        ' cmdUpdate.Parameters.AddWithValue("?", productID)
                        ' cmdUpdate.ExecuteNonQuery()
                    Next

                    Log("SUCCESS", "KontrolEtWebdeOlmayanlar",
                        $"✅ {silinecekUrunler.Count} adet ürün Products tablosundan temizlendi")
                End If

                conn.Close()
            End Using

            ' Sonuç mesajı
            Dim mesaj As String = $"Kontrol Sonuçları:" & vbCrLf & vbCrLf &
                                  $"Kontrol edilen ürün: {kontrolEdilen}" & vbCrLf &
                                  $"Web'de mevcut: {kontrolEdilen - bulunamayan}" & vbCrLf &
                                  $"Web'de BULUNAMAYAN: {bulunamayan}" & vbCrLf & vbCrLf

            If bulunamayan > 0 Then
                mesaj &= $"{bulunamayan} adet ürün Products tablosundan temizlendi." & vbCrLf &
                        "Bu ürünler artık tekrar gönderilebilir!" & vbCrLf & vbCrLf &
                        "Şimdi göndermek ister misiniz?"

                Dim cevap As DialogResult = MessageBox.Show(mesaj, "Web'de Olmayan Ürünler Temizlendi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If cevap = DialogResult.Yes Then
                    ' Manuel olarak hemen gönder
                    Log("INFO", "KontrolEtWebdeOlmayanlar", "Temizlenen ürünler yeniden gönderiliyor...")
                    ProductSync2()
                End If
            Else
                mesaj &= "Tüm ürünler web'de mevcut. Sorun yok! ✅"
                MessageBox.Show(mesaj, "Kontrol Tamamlandı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            LogError("KontrolEtWebdeOlmayanlar hatası: " & ex.Message)
            MessageBox.Show("Hata oluştu: " & ex.Message, "Hata",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ========================================================================
    ' EKSİK VARYANTLARI KONTROL ET VE GÖNDER
    ' ========================================================================

    ''' <summary>
    ''' Web'deki ürünlerin varyantlarını veritabanı ile karşılaştırır
    ''' Eksik varyantı olan ürünleri tekrar gönderir
    ''' </summary>
    Public Sub KontrolEtEksikVaryantlar()
        Try
            Log("INFO", "KontrolEtEksikVaryantlar", "Eksik varyantlar kontrol ediliyor...")
            SafeUpdateUI(Sub() AddLog("Eksik varyantlar kontrol ediliyor..."))

            ' API ayarlarının yüklü olduğunu kontrol et, yoksa yükle
            If String.IsNullOrEmpty(LAGlobalAddress) OrElse String.IsNullOrEmpty(ApiKey) OrElse String.IsNullOrEmpty(ApiSecret) Then
                Log("WARNING", "KontrolEtEksikVaryantlar", "API ayarları yüklü değil, yükleniyor...")
                Using connApi As New OleDbConnection(connection)
                    connApi.Open()
                    Dim cmdApi As New OleDbCommand("SELECT TOP 1 ApiKey, ApiSecret, ProductSave FROM tbParamGenel WHERE ApiKey IS NOT NULL", connApi)
                    Using readerApi As OleDbDataReader = cmdApi.ExecuteReader()
                        If readerApi.Read() Then
                            ApiKey = If(readerApi("ApiKey") Is DBNull.Value, "", readerApi("ApiKey").ToString().Trim())
                            ApiSecret = If(readerApi("ApiSecret") Is DBNull.Value, "", readerApi("ApiSecret").ToString().Trim())
                            LAGlobalAddress = If(readerApi("ProductSave") Is DBNull.Value, "", readerApi("ProductSave").ToString().Trim())
                            Log("SUCCESS", "KontrolEtEksikVaryantlar", $"API ayarları yüklendi: URL={LAGlobalAddress}")
                        End If
                    End Using
                End Using

                ' Hala boşsa hata ver
                If String.IsNullOrEmpty(LAGlobalAddress) Then
                    MessageBox.Show("API ayarları yüklenmemiş! Lütfen önce API ayarlarını yapılandırın.",
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End If

            Dim eksikVaryantliUrunler As New List(Of String)
            Dim kontrolEdilen As Integer = 0
            Dim eksikBulunan As Integer = 0

            Using conn As New OleDbConnection(connection)
                conn.Open()

                ' Products tablosundaki gönderilmiş ürünleri al (status=1)
                Dim cmdProducts As New OleDbCommand(
                    "SELECT productID FROM Products WHERE status = '1'", conn)

                Using reader As OleDbDataReader = cmdProducts.ExecuteReader()
                    While reader.Read()
                        kontrolEdilen += 1
                        Dim productID As String = reader("productID").ToString()

                        ' productID formatı: sModel__sRenk
                        Dim parts() As String = productID.Split(New String() {"__"}, StringSplitOptions.None)
                        If parts.Length <> 2 Then Continue While

                        Dim sModel As String = parts(0).Trim()
                        Dim sRenk As String = parts(1).Trim()

                        ' Veritabanındaki varyant sayısını al
                        Dim dbVaryantSayisi As Integer = GetVaryantSayisiDB(sModel, sRenk, conn)

                        ' Web'deki varyant sayısını al
                        Dim webVaryantSayisi As Integer = GetVaryantSayisiWeb(sModel, sRenk)

                        Log("DEBUG", "KontrolEtEksikVaryantlar", $"{productID}: DB={dbVaryantSayisi}, Web={webVaryantSayisi}")

                        ' -1 = API hatası (AUTH004 vb.), bu durumda karşılaştırma yapma
                        If webVaryantSayisi = -1 Then
                            Log("WARNING", "KontrolEtEksikVaryantlar", $"API hatası: {productID} - karşılaştırma atlandı")
                            Continue While
                        End If

                        If dbVaryantSayisi > webVaryantSayisi Then
                            eksikBulunan += 1
                            eksikVaryantliUrunler.Add(productID)
                            Log("WARNING", "KontrolEtEksikVaryantlar", $"Eksik varyant: {productID} (DB:{dbVaryantSayisi} > Web:{webVaryantSayisi})")
                        End If

                        ' Her 10 üründe bir UI güncelle
                        If kontrolEdilen Mod 10 = 0 Then
                            SafeUpdateUI(Sub() AddLog($"Kontrol edilen: {kontrolEdilen}..."))
                        End If
                    End While
                End Using

                ' Eksik varyantlı ürünleri tekrar gönder
                If eksikVaryantliUrunler.Count > 0 Then
                    Dim mesaj As String = $"Eksik Varyant Kontrolü Tamamlandı:" & vbCrLf & vbCrLf &
                                          $"Kontrol edilen ürün: {kontrolEdilen}" & vbCrLf &
                                          $"Eksik varyantlı ürün: {eksikBulunan}" & vbCrLf & vbCrLf &
                                          "Bu ürünleri tekrar göndermek ister misiniz?"

                    Dim cevap As DialogResult = MessageBox.Show(mesaj, "Eksik Varyant Bulundu",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If cevap = DialogResult.Yes Then
                        Log("INFO", "KontrolEtEksikVaryantlar", $"{eksikVaryantliUrunler.Count} ürün tekrar gönderilecek...")
                        SafeUpdateUI(Sub() AddLog($"{eksikVaryantliUrunler.Count} ürün tekrar gönderilecek..."))

                        ' Bu ürünlerin status'unu 0 yap ki tekrar gönderilsin
                        For Each productID As String In eksikVaryantliUrunler
                            Dim updateCmd As New OleDbCommand(
                                "UPDATE Products SET status = '0' WHERE productID = ?", conn)
                            updateCmd.Parameters.AddWithValue("?", productID)
                            updateCmd.ExecuteNonQuery()
                        Next

                        ' Şimdi gönder
                        ProductSync2()

                        MessageBox.Show($"{eksikVaryantliUrunler.Count} ürün tekrar gönderildi!", "Tamamlandı",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show($"Kontrol edilen {kontrolEdilen} ürünün tamamında varyantlar eksiksiz! ✅",
                        "Kontrol Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End Using

            Log("INFO", "KontrolEtEksikVaryantlar", $"Kontrol tamamlandı. Toplam: {kontrolEdilen}, Eksik: {eksikBulunan}")
            SafeUpdateUI(Sub() AddLog($"Kontrol tamamlandı. Toplam: {kontrolEdilen}, Eksik: {eksikBulunan}"))

        Catch ex As Exception
            LogError("KontrolEtEksikVaryantlar hatası: " & ex.Message)
            MessageBox.Show("Hata oluştu: " & ex.Message, "Hata",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Veritabanındaki varyant sayısını döndürür
    ''' </summary>
    Private Function GetVaryantSayisiDB(sModel As String, sRenk As String, conn As OleDbConnection) As Integer
        Try
            Dim cmd As New OleDbCommand(
                "SELECT COUNT(*) FROM tbStok WHERE sModel = ? AND sRenk = ? AND bWebGoruntule = '1'", conn)
            cmd.Parameters.AddWithValue("?", sModel)
            cmd.Parameters.AddWithValue("?", sRenk)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            LogError($"GetVaryantSayisiDB hatası ({sModel}, {sRenk}): {ex.Message}")
            Return 0
        End Try
    End Function

    ''' <summary>
    ''' Web'deki varyant sayısını döndürür (API'den alır)
    ''' </summary>
    Private Function GetVaryantSayisiWeb(sModel As String, sRenk As String) As Integer
        Try
            ' Ürün kodunu oluştur
            Dim productCode As String = sModel & "__" & sRenk

            ' API'den ürün bilgisini al
            Dim method As String = "product/lists?code=" & Uri.EscapeDataString(productCode)
            Dim response As String = GetFromApi(method)

            If String.IsNullOrEmpty(response) Then
                Log("DEBUG", "GetVaryantSayisiWeb", $"Boş yanıt: {productCode}")
                Return -1 ' Hata durumu
            End If

            ' JSON parse et
            Dim json As JObject = JObject.Parse(response)

            ' AUTH004 veya diğer hata kodlarını kontrol et
            If json("code") IsNot Nothing Then
                Dim codeVal As String = json("code").ToString().ToUpper()
                If codeVal = "AUTH004" OrElse codeVal.StartsWith("AUTH") OrElse codeVal.StartsWith("ERR") Then
                    Log("WARNING", "GetVaryantSayisiWeb", $"API hata kodu: {codeVal} - Ürün: {productCode}")
                    Return -1 ' Hata durumu - AUTH004 veya benzeri
                End If
            End If

            ' Varyant sayısını bul - önce result.list, sonra result.products dene
            Dim products As JArray = Nothing

            If json("result") IsNot Nothing Then
                ' Önce "list" alanını kontrol et (API'nin gerçek yanıt formatı)
                If json("result")("list") IsNot Nothing Then
                    products = CType(json("result")("list"), JArray)
                    Log("DEBUG", "GetVaryantSayisiWeb", $"result.list kullanılıyor: {productCode}")
                    ' Sonra "products" alanını kontrol et (eski format için)
                ElseIf json("result")("products") IsNot Nothing Then
                    products = CType(json("result")("products"), JArray)
                    Log("DEBUG", "GetVaryantSayisiWeb", $"result.products kullanılıyor: {productCode}")
                End If
            End If

            If products IsNot Nothing AndAlso products.Count > 0 Then
                Dim firstProduct As JObject = CType(products(0), JObject)
                If firstProduct("variants") IsNot Nothing Then
                    Dim variants As JArray = CType(firstProduct("variants"), JArray)
                    If variants IsNot Nothing Then
                        Log("DEBUG", "GetVaryantSayisiWeb", $"Varyant sayısı: {variants.Count} - Ürün: {productCode}")
                        Return variants.Count
                    End If
                End If
                ' Varyant array'i yoksa 0 döndür (ürün var ama varyant yok)
                Log("DEBUG", "GetVaryantSayisiWeb", $"Varyant array bulunamadı: {productCode}")
                Return 0
            End If

            ' Ürün bulunamadı
            Log("DEBUG", "GetVaryantSayisiWeb", $"Ürün bulunamadı: {productCode}")
            Return 0
        Catch ex As Exception
            LogError($"GetVaryantSayisiWeb hatası ({sModel}, {sRenk}): {ex.Message}")
            Return -1 ' Hata durumu
        End Try
    End Function

    ''' <summary>
    ''' tbStokBarkodu tablosundan barkod bilgisini alır
    ''' </summary>
    Private Function GetBarkodFromStok(sModel As String, sRenk As String, conn As OleDbConnection) As String
        Try
            ' Barkod tbStokBarkodu tablosunda, tbStok ile nStokID üzerinden ilişkili
            Dim cmd As New OleDbCommand(
                "SELECT TOP 1 B.sBarkod " &
                "FROM tbStok S " &
                "INNER JOIN tbStokBarkodu B ON B.nStokID = S.nStokID " &
                "WHERE S.sModel = ? AND S.sRenk = ? AND B.nKisim = 0", conn)
            cmd.Parameters.AddWithValue("?", sModel)
            cmd.Parameters.AddWithValue("?", sRenk)

            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                Return result.ToString().Trim()
            End If
        Catch ex As Exception
            LogError("GetBarkodFromStok hatası: " & ex.Message)
        End Try
        Return ""
    End Function

    ''' <summary>
    ''' Web servisinde ürünün var olup olmadığını kontrol eder
    ''' PDF dokümantasyonuna göre: GET /product/lists?barcode=xxx
    ''' </summary>
    Private Function KontrolEtUrunWebdeVar(barkod As String) As Boolean
        Try
            ' API endpoint: /product/lists?barcode=XXX
            Dim method As String = "product/lists?barcode=" & Uri.EscapeDataString(barkod)
            ' ===== GÖNDERİM MODU: API veya PHP seçimine göre =====
            Dim response As String = GetFromApi(method)

            If String.IsNullOrEmpty(response) Then
                Log("DEBUG", "KontrolEtUrunWebdeVar", $"Barkod {barkod}: Boş yanıt döndü")
                Return False
            End If

            ' DEBUG: API yanıtını logla
            Log("DEBUG", "KontrolEtUrunWebdeVar", $"Barkod {barkod}: API yanıtı (ilk 300 kar): {If(response.Length > 300, response.Substring(0, 300), response)}")

            ' JSON parse et
            Dim json As JObject = JObject.Parse(response)

            ' AUTH004 veya diğer hata kodlarını kontrol et
            If json("code") IsNot Nothing Then
                Dim codeVal As String = json("code").ToString().ToUpper()
                If codeVal = "AUTH004" OrElse codeVal.StartsWith("AUTH") OrElse codeVal.StartsWith("ERR") Then
                    Log("WARNING", "KontrolEtUrunWebdeVar", $"Barkod {barkod}: API hata kodu: {codeVal}")
                    Return False ' Hata durumunda False döndür
                End If
            End If

            ' Başarılı mı kontrol et - hem "success" hem de "code" alanlarını kontrol et
            Dim isSuccess As Boolean = False

            ' success=true kontrolü
            If json("success") IsNot Nothing Then
                isSuccess = json("success").ToString().ToLower() = "true"
            End If

            ' code="SUCCESS" kontrolü (bazı API'ler böyle dönüyor)
            If json("code") IsNot Nothing Then
                Dim codeVal As String = json("code").ToString().ToUpper()
                If codeVal = "SUCCESS" OrElse codeVal = "0" Then
                    isSuccess = True
                End If
            End If

            If isSuccess Then
                ' Data array'ini kontrol et - önce result.list, sonra diğerleri
                Dim dataArray As JArray = Nothing

                ' Önce "result.list" alanını kontrol et (API'nin gerçek yanıt formatı)
                If json("result") IsNot Nothing AndAlso json("result")("list") IsNot Nothing Then
                    dataArray = CType(json("result")("list"), JArray)
                    Log("DEBUG", "KontrolEtUrunWebdeVar", $"Barkod {barkod}: result.list kullanılıyor")
                    ' Sonra "data" alanını kontrol et
                ElseIf json("data") IsNot Nothing AndAlso TypeOf json("data") Is JArray Then
                    dataArray = CType(json("data"), JArray)
                    Log("DEBUG", "KontrolEtUrunWebdeVar", $"Barkod {barkod}: data kullanılıyor")
                    ' Sonra "result.products" alanını kontrol et (eski format için)
                ElseIf json("result") IsNot Nothing AndAlso json("result")("products") IsNot Nothing Then
                    dataArray = CType(json("result")("products"), JArray)
                    Log("DEBUG", "KontrolEtUrunWebdeVar", $"Barkod {barkod}: result.products kullanılıyor")
                End If

                If dataArray IsNot Nothing AndAlso dataArray.Count > 0 Then
                    Log("DEBUG", "KontrolEtUrunWebdeVar", $"Barkod {barkod}: {dataArray.Count} ürün bulundu")

                    ' Ürün bulundu - barkod tam eşleşme kontrolü
                    For Each item As JObject In dataArray
                        ' Ana barkod kontrolü
                        If item("barcode") IsNot Nothing Then
                            Dim webBarkod As String = item("barcode").ToString().Trim()
                            If webBarkod = barkod Then
                                Log("DEBUG", "KontrolEtUrunWebdeVar", $"Barkod {barkod}: Ana barkod eşleşti!")
                                Return True ' TAM EŞLEŞME - ürün web'de var!
                            End If
                        End If

                        ' Varyant barkodlarını da kontrol et
                        If item("variantBarcode") IsNot Nothing Then
                            Dim varyantBarkod As String = item("variantBarcode").ToString().Trim()
                            If varyantBarkod = barkod Then
                                Log("DEBUG", "KontrolEtUrunWebdeVar", $"Barkod {barkod}: Varyant barkodu eşleşti!")
                                Return True ' Varyant barkodu eşleşti
                            End If
                        End If

                        ' Variants array içinde barkod kontrolü
                        If item("variants") IsNot Nothing AndAlso TypeOf item("variants") Is JArray Then
                            For Each varItem As JObject In CType(item("variants"), JArray)
                                If varItem("barcode") IsNot Nothing Then
                                    Dim varBarkod As String = varItem("barcode").ToString().Trim()
                                    If varBarkod = barkod Then
                                        Log("DEBUG", "KontrolEtUrunWebdeVar", $"Barkod {barkod}: Variant içinde eşleşti!")
                                        Return True
                                    End If
                                End If
                            Next
                        End If
                    Next

                    ' Ürün bulundu ama barkod eşleşmedi - yine de var sayalım
                    Log("DEBUG", "KontrolEtUrunWebdeVar", $"Barkod {barkod}: Ürün bulundu ama barkod eşleşmedi, yine de VAR kabul ediliyor")
                    Return True
                Else
                    Log("DEBUG", "KontrolEtUrunWebdeVar", $"Barkod {barkod}: data/list/products array boş veya yok")
                End If
            Else
                Log("DEBUG", "KontrolEtUrunWebdeVar", $"Barkod {barkod}: API success=false döndü")
            End If

            Return False ' Ürün bulunamadı

        Catch ex As Exception
            LogError($"KontrolEtUrunWebdeVar hatası (Barkod: {barkod}): " & ex.Message)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Products tablosunda OLMAYAN ürünleri bulup web'e gönderir
    ''' bWebGoruntule=1 olan ama Products tablosunda kaydı olmayan ürünler gönderilir
    ''' (Hiç gönderilmemiş yeni ürünler için)
    ''' </summary>
    Public Sub GonderWebdeOlmayanUrunler()
        Try
            Log("INFO", "GonderWebdeOlmayanUrunler", "Web'de olmayan ürünler bulunuyor...")

            Dim olmayanUrunler As New List(Of String)

            Using conn As New OleDbConnection(connection)
                conn.Open()

                ' bWebGoruntule=1 olan tüm ürünleri al
                Dim cmdTumUrunler As New OleDbCommand(
                    "SELECT DISTINCT T1.sModel, T1.sRenk " &
                    "FROM tbStok AS T1 " &
                    "WHERE T1.bWebGoruntule = 1 " &
                    "ORDER BY T1.sModel", conn)

                Using reader As OleDbDataReader = cmdTumUrunler.ExecuteReader()
                    While reader.Read()
                        Dim sModel As String = Trim(reader("sModel").ToString())
                        Dim sRenk As String = Trim(reader("sRenk").ToString())
                        Dim productID As String = sModel & "__" & sRenk

                        ' Products tablosunda var mı kontrol et
                        Dim cmdCheck As New OleDbCommand(
                            "SELECT COUNT(*) FROM Products WHERE productID = ?", conn)
                        cmdCheck.Parameters.AddWithValue("?", productID)

                        Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

                        If count = 0 Then
                            ' Products tablosunda yok - ekle
                            olmayanUrunler.Add(productID)
                            InsertProductIfNotExists(productID, conn)
                        End If
                    End While
                End Using

                conn.Close()
            End Using

            If olmayanUrunler.Count > 0 Then
                Log("INFO", "GonderWebdeOlmayanUrunler",
                    $"{olmayanUrunler.Count} adet web'de olmayan ürün Products tablosuna eklendi")
                Log("INFO", "GonderWebdeOlmayanUrunler",
                    "Bu ürünler status=0 olarak işaretlendi ve sonraki senkronizasyonda gönderilecek")

                ' Opsiyonel: Hemen göndermek için
                Dim cevap As DialogResult = MessageBox.Show(
                    $"{olmayanUrunler.Count} adet yeni ürün bulundu." & vbCrLf & vbCrLf &
                    "Bu ürünleri ŞİMDİ web'e göndermek ister misiniz?" & vbCrLf & vbCrLf &
                    "EVET: Hemen gönder" & vbCrLf &
                    "HAYIR: Sonraki otomatik senkronizasyonda gönderilsin",
                    "Yeni Ürünler Bulundu",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)

                If cevap = DialogResult.Yes Then
                    ' Manuel olarak hemen gönder
                    Log("INFO", "GonderWebdeOlmayanUrunler", "Yeni ürünler Trendyol'a gönderiliyor...")
                    ProductSync2()
                End If
            Else
                Log("INFO", "GonderWebdeOlmayanUrunler", "Tüm ürünler zaten web'de mevcut")
                MessageBox.Show(
                    "Tüm ürünler zaten Trendyol'da mevcut." & vbCrLf &
                    "Web'de olmayan yeni ürün bulunamadı.",
                    "Bilgi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            LogError("GonderWebdeOlmayanUrunler hatası: " & ex.Message)
            MessageBox.Show(
                "Hata oluştu: " & ex.Message,
                "Hata",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Eksik ürün sayısını döndürür (web'de olması gereken ama olmayan)
    ''' </summary>
    Public Function GetEksikUrunSayisi() As Integer
        Try
            Dim eksikSayisi As Integer = 0

            Using conn As New OleDbConnection(connection)
                conn.Open()

                ' bWebGoruntule=1 olan toplam ürün sayısı
                Dim cmdToplam As New OleDbCommand(
                    "SELECT COUNT(DISTINCT sModel + '__' + sRenk) " &
                    "FROM tbStok " &
                    "WHERE bWebGoruntule = 1", conn)
                Dim toplamUrun As Integer = Convert.ToInt32(cmdToplam.ExecuteScalar())

                ' Products tablosundaki ürün sayısı
                Dim cmdMevcut As New OleDbCommand(
                    "SELECT COUNT(*) FROM Products", conn)
                Dim mevcutUrun As Integer = Convert.ToInt32(cmdMevcut.ExecuteScalar())

                eksikSayisi = toplamUrun - mevcutUrun
                If eksikSayisi < 0 Then eksikSayisi = 0

                conn.Close()
            End Using

            Return eksikSayisi

        Catch ex As Exception
            LogError("GetEksikUrunSayisi hatası: " & ex.Message)
            Return 0
        End Try
    End Function

#Region "Eksik Alan Uyarı Sistemi"

    ''' <summary>
    ''' Ürünün pazaryerine gönderilmeden önce eksik alanlarını kontrol eder
    ''' ROADMAP.md'deki "Eksik Alan Uyarı Sistemi" implementasyonu
    ''' </summary>
    Public Function CheckMissingFields(nStokID As Integer, conn As OleDb.OleDbConnection) As Dictionary(Of String, Object)
        Dim result As New Dictionary(Of String, Object)
        Dim criticalMissing As New List(Of String)    ' Zorunlu - gönderilmez
        Dim warningMissing As New List(Of String)     ' Önemli - uyarı verilir
        Dim infoMissing As New List(Of String)        ' Bilgi - tavsiye
        Dim canProceed As Boolean = True

        Try
            EticaretLogger.LogInfo($"Eksik alan kontrolü başlatıldı: nStokID={nStokID}")

            Dim sql As String = "SELECT s.sAciklama, s.sModel, s.sRenk, s.sKodu, " &
                               "s.sBedenTipi, s.nEn, s.nBoy, s.nAgirlik, " &
                               "si.sSinifKodu3 AS markaKodu, si.sSinifKodu4 AS katKodu, " &
                               "(SELECT sAciklama FROM tbSSinif3 WHERE sSinifKodu=si.sSinifKodu3) AS marka, " &
                               "(SELECT COUNT(*) FROM tbResim r WHERE r.nStokID = s.nStokID) AS nResimSayisi, " &
                               "(SELECT COUNT(*) FROM tbStokBarkodu b WHERE b.nStokID = s.nStokID) AS nVaryantSayisi, " &
                               "(SELECT lFiyat FROM tbStokFiyati WHERE nStokID=s.nStokID AND sFiyatTipi='2') AS fiyatTrendyol, " &
                               "(SELECT lFiyat FROM tbStokFiyati WHERE nStokID=s.nStokID AND sFiyatTipi='3') AS fiyatHB, " &
                               "(SELECT lFiyat FROM tbStokFiyati WHERE nStokID=s.nStokID AND sFiyatTipi='" & GetSeciliFiyatTipi() & "') AS fiyatSite, " &
                               "ai.sSEOBaslik, ai.sMetaDescription, ai.nIcerikPuani, " &
                               "un.sUzunNot " &
                               "FROM tbStok s " &
                               "LEFT JOIN tbStokSinifi si ON si.nStokID = s.nStokID " &
                               "LEFT JOIN tbStokAIIcerik ai ON ai.sModel = s.sModel " &
                               "LEFT JOIN tbStokUzunNot un ON un.sModel = s.sModel " &
                               "WHERE s.nStokID = ?"

            Dim cmd As New OleDb.OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("?", nStokID)

            Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Dim urunAdi As String = If(IsDBNull(reader("sAciklama")), "", reader("sAciklama").ToString())

                    ' ========================
                    ' KRİTİK ALANLAR (Zorunlu)
                    ' ========================

                    ' 1. Görsel kontrolü
                    Dim resimSayisi As Integer = If(IsDBNull(reader("nResimSayisi")), 0, CInt(reader("nResimSayisi")))
                    If resimSayisi = 0 Then
                        criticalMissing.Add("❌ GÖRSEL: Hiç görsel yok! En az 1 görsel zorunlu.")
                        canProceed = False
                    ElseIf resimSayisi < 3 Then
                        warningMissing.Add($"⚠️ GÖRSEL: Sadece {resimSayisi} görsel var. Minimum 5 görsel önerilir.")
                    End If

                    ' 2. Fiyat kontrolü
                    Dim fiyatTrendyol As Decimal = If(IsDBNull(reader("fiyatTrendyol")), 0D, CDec(reader("fiyatTrendyol")))
                    Dim fiyatHB As Decimal = If(IsDBNull(reader("fiyatHB")), 0D, CDec(reader("fiyatHB")))
                    Dim fiyatSite As Decimal = If(IsDBNull(reader("fiyatSite")), 0D, CDec(reader("fiyatSite")))

                    If fiyatTrendyol <= 0 AndAlso fiyatHB <= 0 AndAlso fiyatSite <= 0 Then
                        criticalMissing.Add("❌ FİYAT: Hiç fiyat tanımlanmamış!")
                        canProceed = False
                    Else
                        If fiyatTrendyol <= 0 Then warningMissing.Add("⚠️ Trendyol fiyatı tanımlanmamış")
                        If fiyatHB <= 0 Then warningMissing.Add("⚠️ Hepsiburada fiyatı tanımlanmamış")
                    End If

                    ' 3. Varyant kontrolü
                    Dim varyantSayisi As Integer = If(IsDBNull(reader("nVaryantSayisi")), 0, CInt(reader("nVaryantSayisi")))
                    If varyantSayisi = 0 Then
                        criticalMissing.Add("❌ VARYANT: Hiç beden/barkod tanımlanmamış!")
                        canProceed = False
                    End If

                    ' 4. Marka kontrolü
                    Dim marka As String = If(IsDBNull(reader("marka")), "", reader("marka").ToString().Trim())
                    Dim markaKodu As String = If(IsDBNull(reader("markaKodu")), "", reader("markaKodu").ToString().Trim())
                    If String.IsNullOrEmpty(marka) OrElse String.IsNullOrEmpty(markaKodu) Then
                        criticalMissing.Add("❌ MARKA: Marka bilgisi eksik! (Sinif 3)")
                        canProceed = False
                    End If

                    ' 5. Kategori kontrolü
                    Dim katKodu As String = If(IsDBNull(reader("katKodu")), "", reader("katKodu").ToString().Trim())
                    If String.IsNullOrEmpty(katKodu) Then
                        criticalMissing.Add("❌ KATEGORİ: Kategori bilgisi eksik! (Sinif 4)")
                        canProceed = False
                    End If

                    ' ========================
                    ' ÖNEMLİ ALANLAR (Uyarı)
                    ' ========================

                    ' 6. SEO Başlık
                    Dim seoBaslik As String = If(IsDBNull(reader("sSEOBaslik")), "", reader("sSEOBaslik").ToString().Trim())
                    If String.IsNullOrEmpty(seoBaslik) Then
                        warningMissing.Add("⚠️ SEO BAŞLIK: AI tarafından oluşturulmuş başlık yok. Sıralama düşük olabilir.")
                    End If

                    ' 7. Meta Description
                    Dim metaDesc As String = If(IsDBNull(reader("sMetaDescription")), "", reader("sMetaDescription").ToString().Trim())
                    If String.IsNullOrEmpty(metaDesc) Then
                        infoMissing.Add("ℹ️ META DESC: Meta description eksik.")
                    End If

                    ' 8. Detaylı açıklama
                    Dim uzunNot As String = If(IsDBNull(reader("sUzunNot")), "", reader("sUzunNot").ToString().Trim())
                    If String.IsNullOrEmpty(uzunNot) Then
                        warningMissing.Add("⚠️ AÇIKLAMA: Detaylı ürün açıklaması yok. Trendyol sıralaması için önemli!")
                    End If

                    ' 9. İçerik puanı kontrolü
                    Dim icerikPuani As Integer = If(IsDBNull(reader("nIcerikPuani")), 0, CInt(reader("nIcerikPuani")))
                    If icerikPuani < 40 Then
                        warningMissing.Add($"⚠️ İÇERİK PUANI: {icerikPuani}/100 - Düşük içerik kalitesi!")
                    ElseIf icerikPuani < 70 Then
                        infoMissing.Add($"ℹ️ İÇERİK PUANI: {icerikPuani}/100 - İyileştirme önerilir.")
                    End If

                    ' 10. Ölçü kontrolü
                    Dim nEn As Decimal = If(IsDBNull(reader("nEn")), 0D, CDec(reader("nEn")))
                    Dim nBoy As Decimal = If(IsDBNull(reader("nBoy")), 0D, CDec(reader("nBoy")))
                    Dim nAgirlik As Decimal = If(IsDBNull(reader("nAgirlik")), 0D, CDec(reader("nAgirlik")))

                    If nEn <= 0 OrElse nBoy <= 0 Then
                        infoMissing.Add("ℹ️ ÖLÇÜ: En/Boy bilgisi eksik (kargo hesaplaması etkilenebilir)")
                    End If

                    result("urunAdi") = urunAdi
                End If
            End Using

            ' Sonuçları hazırla
            result("canProceed") = canProceed
            result("criticalMissing") = criticalMissing
            result("warningMissing") = warningMissing
            result("infoMissing") = infoMissing
            result("totalIssues") = criticalMissing.Count + warningMissing.Count + infoMissing.Count
            result("nStokID") = nStokID

            ' Loglama
            If criticalMissing.Count > 0 Then
                EticaretLogger.LogWarning($"Eksik alan kontrolü: nStokID={nStokID}, Kritik={criticalMissing.Count}, Uyarı={warningMissing.Count}")
                For Each kritikItem As String In criticalMissing
                    EticaretLogger.LogError($"[nStokID={nStokID}] {kritikItem}")
                Next
            End If

        Catch ex As Exception
            EticaretLogger.LogError($"CheckMissingFields hatası: nStokID={nStokID}", ex)
            result("error") = ex.Message
            result("canProceed") = False
        End Try

        Return result
    End Function

    ''' <summary>
    ''' Eksik alan uyarı dialogunu gösterir
    ''' </summary>
    Public Function ShowMissingFieldsWarning(checkResult As Dictionary(Of String, Object)) As Boolean
        Try
            If checkResult Is Nothing OrElse Not checkResult.ContainsKey("totalIssues") Then
                Return True ' Kontrol yapılamadı, devam et
            End If

            Dim totalIssues As Integer = CInt(checkResult("totalIssues"))
            If totalIssues = 0 Then Return True ' Sorun yok

            Dim canProceed As Boolean = CBool(checkResult("canProceed"))
            Dim criticalList As List(Of String) = DirectCast(checkResult("criticalMissing"), List(Of String))
            Dim warningList As List(Of String) = DirectCast(checkResult("warningMissing"), List(Of String))
            Dim infoList As List(Of String) = DirectCast(checkResult("infoMissing"), List(Of String))
            Dim urunAdi As String = If(checkResult.ContainsKey("urunAdi"), checkResult("urunAdi").ToString(), "Ürün")

            ' Mesaj oluştur
            Dim sb As New System.Text.StringBuilder()
            sb.AppendLine($"📋 ÜRÜN: {urunAdi}")
            sb.AppendLine()

            If criticalList.Count > 0 Then
                sb.AppendLine("🔴 KRİTİK HATALAR (Gönderilmez):")
                For Each critItem As String In criticalList
                    sb.AppendLine($"   {critItem}")
                Next
                sb.AppendLine()
            End If

            If warningList.Count > 0 Then
                sb.AppendLine("🟠 UYARILAR (Sıralama etkilenir):")
                For Each warnItem As String In warningList
                    sb.AppendLine($"   {warnItem}")
                Next
                sb.AppendLine()
            End If

            If infoList.Count > 0 Then
                sb.AppendLine("🔵 BİLGİ (Tavsiye):")
                For Each infoItem As String In infoList
                    sb.AppendLine($"   {infoItem}")
                Next
                sb.AppendLine()
            End If

            If canProceed Then
                sb.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
                sb.AppendLine("Bu ürün gönderilebilir ancak eksikler sıralamayı etkileyebilir.")
                sb.AppendLine("Devam etmek istiyor musunuz?")

                Dim result As DialogResult = MessageBox.Show(
                    sb.ToString(),
                    $"⚠️ Eksik Alan Uyarısı ({warningList.Count + infoList.Count} sorun)",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning)

                Return result = DialogResult.Yes
            Else
                sb.AppendLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━")
                sb.AppendLine("❌ Bu ürün kritik eksikler nedeniyle GÖNDERİLEMEZ!")
                sb.AppendLine("Lütfen önce yukarıdaki eksikleri tamamlayın.")

                MessageBox.Show(
                    sb.ToString(),
                    $"🚫 Ürün Gönderilemez ({criticalList.Count} kritik hata)",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error)

                Return False
            End If

        Catch ex As Exception
            EticaretLogger.LogError("ShowMissingFieldsWarning hatası", ex)
            Return True ' Hata durumunda devam et
        End Try
    End Function

    ''' <summary>
    ''' Seçili ürünlerin toplu eksik alan kontrolü
    ''' NOT: Bu metod şu an devre dışı - Form üzerinde dgv_stoklar kontrolü tanımlanmadığı için çalışmıyor
    ''' İleride uygun bir DataGridView eklendikten sonra aktif edilebilir
    ''' </summary>
    Public Sub CheckSelectedProductsForMissingFields()
        Try
            ' NOT: Bu metod devre dışıdır. dgv_stoklar kontrolü forumda mevcut değil.
            ' İleride bu özellik aktif edilmek istenirse, önce forma uygun bir DataGridView eklenmeli
            ' ve bu kontrolün adı burada kullanılmalıdır.

            MessageBox.Show("Bu özellik henüz aktif değildir. Ürün seçimi için gerekli kontrol henüz tanımlanmamıştır.",
                           "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            EticaretLogger.LogInfo("CheckSelectedProductsForMissingFields çağrıldı ancak dgv_stoklar mevcut değil.")

        Catch ex As Exception
            EticaretLogger.LogError("CheckSelectedProductsForMissingFields hatası", ex)
            MessageBox.Show($"Kontrol sırasında hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lblTriggerBilgi_Click(sender As Object, e As EventArgs) Handles lblTriggerBilgi.Click

    End Sub

#End Region


    ' ========== ORDERS TABLOSU ALAN KONTROLU ==========
    Private Sub EnsureOrdersTableColumns()
        Try
            If String.IsNullOrEmpty(KeyCode.sConnection) Then
                Log("WARNING", "EnsureOrdersTableColumns", "SQL Server baglantisi bos, alan kontrolu atlanıyor")
                Return
            End If

            ' OleDb connection string'den Provider kısmını kaldır
            Dim sqlConnStr As String = KeyCode.sConnection
            If sqlConnStr.ToLower().Contains("provider=") Then
                Dim parts As String() = sqlConnStr.Split(";"c)
                Dim cleanParts As New List(Of String)
                For Each part As String In parts
                    If Not part.Trim().ToLower().StartsWith("provider=") Then
                        If Not String.IsNullOrWhiteSpace(part) Then
                            cleanParts.Add(part.Trim())
                        End If
                    End If
                Next
                sqlConnStr = String.Join(";", cleanParts)
            End If

            Using conn As New SqlClient.SqlConnection(sqlConnStr)
                conn.Open()

                ' nStokFisiID alanını kontrol et ve ekle
                Dim checkCol1 As String = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('orders') AND name = 'nStokFisiID') ALTER TABLE orders ADD nStokFisiID INT NULL"
                Using cmd1 As New SqlClient.SqlCommand(checkCol1, conn)
                    cmd1.ExecuteNonQuery()
                End Using

                ' nFirmaID alanını kontrol et ve ekle
                Dim checkCol2 As String = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('orders') AND name = 'nFirmaID') ALTER TABLE orders ADD nFirmaID INT NULL"
                Using cmd2 As New SqlClient.SqlCommand(checkCol2, conn)
                    cmd2.ExecuteNonQuery()
                End Using

                ' sAciklama3 alanını kontrol et ve ekle
                Dim checkCol3 As String = "IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('orders') AND name = 'sAciklama3') ALTER TABLE orders ADD sAciklama3 NVARCHAR(100) NULL"
                Using cmd3 As New SqlClient.SqlCommand(checkCol3, conn)
                    cmd3.ExecuteNonQuery()
                End Using

                Log("DEBUG", "EnsureOrdersTableColumns", "Orders tablosu alan kontrolu tamamlandi")
            End Using
        Catch ex As Exception
            Log("ERROR", "EnsureOrdersTableColumns", $"Alan kontrolu hatasi: {ex.Message}")
        End Try
    End Sub

    ' ========== EKSIK MUSTERI BILGILERINI GUNCELLE ==========
    Private Sub BtnEksikBilgiGuncelle_Click(sender As Object, e As EventArgs) Handles btnEksikBilgiGuncelle.Click
        Try
            Dim baslangicTarihi As DateTime = dtpBaslangic.Value.Date
            Dim bitisTarihi As DateTime = dtpBitis.Value.Date.AddDays(1).AddSeconds(-1) ' Gün sonuna kadar

            Dim mesaj As String = $"Tarih aralığı: {baslangicTarihi:dd.MM.yyyy} - {dtpBitis.Value:dd.MM.yyyy}" & vbCrLf & vbCrLf &
                                  "Bu tarih aralığındaki siparişlerde eksik müşteri bilgilerini güncellemek istiyor musunuz?"

            If MessageBox.Show(mesaj, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                lblDurum.Text = "Durum: Eksik bilgiler guncelleniyor..."
                Dim bgWorker As New System.ComponentModel.BackgroundWorker()
                AddHandler bgWorker.DoWork, Sub(s, args)
                                                EksikMusteriBilgileriniGuncelle(baslangicTarihi, bitisTarihi)
                                            End Sub
                AddHandler bgWorker.RunWorkerCompleted, Sub(s, args)
                                                            SafeUpdateUI(Sub() lblDurum.Text = "Durum: Hazir")
                                                        End Sub
                bgWorker.RunWorkerAsync()
            End If
        Catch ex As Exception
            Log("ERROR", "BtnEksikBilgiGuncelle_Click", $"Hata: {ex.Message}")
            MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub EksikMusteriBilgileriniGuncelle(baslangicTarihi As DateTime, bitisTarihi As DateTime)
        Log("INFO", "EksikMusteriBilgileriniGuncelle", $"========== EKSIK MUSTERI BILGILERI GUNCELLEME BASLIYOR ==========")
        Log("INFO", "EksikMusteriBilgileriniGuncelle", $"Tarih araligi: {baslangicTarihi:yyyy-MM-dd} - {bitisTarihi:yyyy-MM-dd}")

        Try
            If String.IsNullOrEmpty(LAGlobalAddress) Then
                LoadConfig()
            End If

            ' Orders tablosunda eksik alanları kontrol et ve ekle
            EnsureOrdersTableColumns()

            Dim guncellenenSayisi As Integer = 0
            Dim hataliSayisi As Integer = 0
            Dim atladiSayisi As Integer = 0

            ' Orders tablosu SQL Server'da - doğrudan sAciklama3 ile sipariş kodlarını çek
            Dim siparisKodlari As New List(Of String)
            Dim sqlConnStr As String = ""

            If Not String.IsNullOrEmpty(KeyCode.sConnection) Then
                ' OleDb connection string'den Provider kısmını kaldır (SqlConnection için)
                sqlConnStr = KeyCode.sConnection
                If sqlConnStr.ToLower().Contains("provider=") Then
                    ' Provider=xxx; kısmını kaldır
                    Dim parts As String() = sqlConnStr.Split(";"c)
                    Dim cleanParts As New List(Of String)
                    For Each part As String In parts
                        If Not part.Trim().ToLower().StartsWith("provider=") Then
                            If Not String.IsNullOrWhiteSpace(part) Then
                                cleanParts.Add(part.Trim())
                            End If
                        End If
                    Next
                    sqlConnStr = String.Join(";", cleanParts)
                End If

                Log("DEBUG", "EksikMusteriBilgileriniGuncelle", $"SQL Server connection string hazırlandi")

                Using sqlConn As New SqlClient.SqlConnection(sqlConnStr)
                    sqlConn.Open()
                    ' sAciklama3 alanından doğrudan sipariş kodunu al
                    Dim sqlOrders As String = "SELECT ID, sAciklama3 FROM orders WHERE updated_at >= @baslangic AND updated_at <= @bitis AND sAciklama3 IS NOT NULL AND sAciklama3 <> '' ORDER BY ID DESC"
                    Using cmdOrders As New SqlClient.SqlCommand(sqlOrders, sqlConn)
                        cmdOrders.Parameters.AddWithValue("@baslangic", baslangicTarihi)
                        cmdOrders.Parameters.AddWithValue("@bitis", bitisTarihi)

                        Log("DEBUG", "EksikMusteriBilgileriniGuncelle", $"SQL Server Orders sorgusu: {baslangicTarihi:yyyy-MM-dd} - {bitisTarihi:yyyy-MM-dd}")

                        Using reader As SqlClient.SqlDataReader = cmdOrders.ExecuteReader()
                            While reader.Read()
                                If Not reader.IsDBNull(1) Then
                                    Dim kod As String = reader("sAciklama3").ToString().Trim()
                                    If Not String.IsNullOrEmpty(kod) AndAlso Not siparisKodlari.Contains(kod) Then
                                        siparisKodlari.Add(kod)
                                    End If
                                End If
                            End While
                        End Using
                    End Using
                End Using
                Log("INFO", "EksikMusteriBilgileriniGuncelle", $"SQL Server orders tablosundan {siparisKodlari.Count} siparis kodu bulundu")
            Else
                Log("ERROR", "EksikMusteriBilgileriniGuncelle", "SQL Server baglantisi (KeyCode.sConnection) bos!")
                SafeUpdateUI(Sub() MessageBox.Show("SQL Server bağlantısı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error))
                Return
            End If

            If siparisKodlari.Count = 0 Then
                SafeUpdateUI(Sub() MessageBox.Show($"Belirtilen tarih aralığında ({baslangicTarihi:dd.MM.yyyy} - {bitisTarihi:dd.MM.yyyy}) sipariş bulunamadı!" & vbCrLf & vbCrLf & "NOT: orders tablosunda sAciklama3 alanı boş olabilir. Yeni siparişler için bu alan otomatik doldurulacak.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information))
                Return
            End If

            SafeUpdateUI(Sub() AddLog($"Tarih aralığında {siparisKodlari.Count} siparis kodu bulundu"))

            ' SQL Server bağlantısı kullan (Access değil)
            Using conn As New SqlClient.SqlConnection(sqlConnStr)
                conn.Open()

                Dim sayac As Integer = 0
                For Each siparisKodu As String In siparisKodlari
                    sayac += 1
                    Try
                        Log("INFO", "EksikBilgi", $"========== [{sayac}/{siparisKodlari.Count}] SIPARIS: {siparisKodu} ==========")
                        SafeUpdateUI(Sub()
                                         lblDurum.Text = $"Durum: {sayac}/{siparisKodlari.Count} siparis isleniyor..."
                                         AddLog($"[{sayac}] Siparis: {siparisKodu}")
                                     End Sub)

                        ' API'den siparis ID'sini bul
                        Dim apiOrderId As String = ""
                        Log("DEBUG", "EksikBilgi", $"API'den siparis aranıyor: order/lists?search={siparisKodu}")
                        Dim searchResult As String = GetFromApi($"order/lists?search={siparisKodu}&pageSize=1")

                        If String.IsNullOrEmpty(searchResult) Then
                            Log("WARNING", "EksikBilgi", $"[{siparisKodu}] API yanıt BOŞ - Sipariş API'de bulunamadı")
                            atladiSayisi += 1
                            Continue For
                        End If

                        Try
                            Dim jObj As JObject = JObject.Parse(searchResult)
                            If jObj.ContainsKey("result") AndAlso jObj("result") IsNot Nothing Then
                                Dim resultObj As JToken = jObj("result")
                                If resultObj.Type = JTokenType.Object Then
                                    Dim resObj As JObject = CType(resultObj, JObject)
                                    If resObj.ContainsKey("list") AndAlso resObj("list") IsNot Nothing Then
                                        Dim listArray As JArray = CType(resObj("list"), JArray)
                                        Log("DEBUG", "EksikBilgi", $"[{siparisKodu}] API list count: {listArray.Count}")
                                        If listArray.Count > 0 Then
                                            Dim firstOrder As JObject = CType(listArray(0), JObject)
                                            If firstOrder.ContainsKey("id") Then
                                                apiOrderId = firstOrder("id").ToString()
                                                Log("DEBUG", "EksikBilgi", $"[{siparisKodu}] API Order ID bulundu: {apiOrderId}")
                                            End If
                                        Else
                                            Log("WARNING", "EksikBilgi", $"[{siparisKodu}] API list BOŞ - Sipariş bulunamadı")
                                        End If
                                    End If
                                End If
                            End If
                        Catch jsonEx As Exception
                            Log("ERROR", "EksikBilgi", $"[{siparisKodu}] JSON parse hatasi: {jsonEx.Message}")
                        End Try

                        If String.IsNullOrEmpty(apiOrderId) Then
                            Log("WARNING", "EksikBilgi", $"[{siparisKodu}] ATLANDI - API Order ID bulunamadı")
                            atladiSayisi += 1
                            Continue For
                        End If

                        ' Siparis detayini cek
                        Log("DEBUG", "EksikBilgi", $"[{siparisKodu}] Siparis detayi çekiliyor: order/show/{apiOrderId}")
                        Dim orderDetail As Dictionary(Of String, Object) = FetchOrderDetail(apiOrderId)
                        If orderDetail Is Nothing Then
                            Log("ERROR", "EksikBilgi", $"[{siparisKodu}] HATA - Sipariş detayı çekilemedi")
                            hataliSayisi += 1
                            Continue For
                        End If

                        ' Musteri bilgilerini al
                        Dim cust As Dictionary(Of String, Object) = If(orderDetail.ContainsKey("customer") AndAlso orderDetail("customer") IsNot Nothing, AsDict(orderDetail("customer")), Nothing)
                        If cust Is Nothing Then
                            Log("WARNING", "EksikBilgi", $"[{siparisKodu}] ATLANDI - customer objesi bulunamadı")
                            atladiSayisi += 1
                            Continue For
                        End If

                        ' customer icindeki delivery objesini al
                        Dim custDelivery As Dictionary(Of String, Object) = Nothing
                        If cust.ContainsKey("delivery") AndAlso cust("delivery") IsNot Nothing Then
                            custDelivery = AsDict(cust("delivery"))
                        End If

                        ' customer icindeki invoice (fatura) objesini al
                        ' İhracat siparişlerinde fatura bilgileri kullanılmalı
                        Dim custInvoice As Dictionary(Of String, Object) = Nothing
                        If cust.ContainsKey("invoice") AndAlso cust("invoice") IsNot Nothing Then
                            custInvoice = AsDict(cust("invoice"))
                        End If

                        ' ===== TC KIMLIK: API v2.2.4 - "nationalId" alanindan =====
                        Dim tc As String = "11111111111"
                        If cust.ContainsKey("nationalId") AndAlso cust("nationalId") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(cust("nationalId").ToString()) Then
                            tc = cust("nationalId").ToString().Trim()
                        End If
                        If String.IsNullOrWhiteSpace(tc) OrElse tc = "0" Then tc = "11111111111"

                        ' ===== VERGI NO: API v2.2.4 - "taxId" alanindan =====
                        Dim sVergiNo As String = ""
                        If cust.ContainsKey("taxId") AndAlso cust("taxId") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(cust("taxId").ToString()) Then
                            sVergiNo = cust("taxId").ToString().Trim()
                        ElseIf cust.ContainsKey("tax_id") AndAlso cust("tax_id") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(cust("tax_id").ToString()) Then
                            sVergiNo = cust("tax_id").ToString().Trim()
                        End If
                        ' Vergi No bos veya 0 ise varsayilan deger ata (11 adet 1)
                        If String.IsNullOrWhiteSpace(sVergiNo) OrElse sVergiNo = "0" Then
                            sVergiNo = "1111111111"
                        End If

                        ' ===== VERGI DAIRESI: API v2.2.4 - "taxBranch" alanindan =====
                        Dim sVergiDairesi As String = ""
                        If cust.ContainsKey("taxBranch") AndAlso cust("taxBranch") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(cust("taxBranch").ToString()) Then
                            sVergiDairesi = DecodeApiData(cust("taxBranch").ToString().Trim())
                        ElseIf cust.ContainsKey("tax_branch") AndAlso cust("tax_branch") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(cust("tax_branch").ToString()) Then
                            sVergiDairesi = DecodeApiData(cust("tax_branch").ToString().Trim())
                        End If

                        ' ===== ADRES: ÖNCELİKLE FATURA BİLGİLERİNDEN AL (invoice.address) =====
                        Dim adres As String = ""
                        If custInvoice IsNot Nothing AndAlso custInvoice.ContainsKey("address") AndAlso custInvoice("address") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(custInvoice("address").ToString()) Then
                            adres = DecodeApiData(Convert.ToString(custInvoice("address")))
                            Log("INFO", "EksikBilgi", $"[{siparisKodu}] ADRES FATURA BİLGİLERİNDEN ALINDI")
                        ElseIf custDelivery IsNot Nothing AndAlso custDelivery.ContainsKey("address") AndAlso custDelivery("address") IsNot Nothing Then
                            adres = DecodeApiData(Convert.ToString(custDelivery("address")))
                        End If

                        ' ===== ILCE: ÖNCELİKLE FATURA BİLGİLERİNDEN AL (invoice.district) =====
                        Dim ilceVal As String = ""
                        If custInvoice IsNot Nothing AndAlso custInvoice.ContainsKey("district") AndAlso custInvoice("district") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(custInvoice("district").ToString()) Then
                            ilceVal = DecodeApiData(Convert.ToString(custInvoice("district")))
                            Log("INFO", "EksikBilgi", $"[{siparisKodu}] İLÇE FATURA BİLGİLERİNDEN ALINDI")
                        ElseIf custDelivery IsNot Nothing AndAlso custDelivery.ContainsKey("district") AndAlso custDelivery("district") IsNot Nothing Then
                            ilceVal = DecodeApiData(Convert.ToString(custDelivery("district")))
                        End If

                        ' ===== IL: ÖNCELİKLE FATURA BİLGİLERİNDEN AL (invoice.city) =====
                        Dim il As String = ""
                        Dim rawIlSource As String = ""
                        If custInvoice IsNot Nothing AndAlso custInvoice.ContainsKey("city") AndAlso custInvoice("city") IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(custInvoice("city").ToString()) Then
                            rawIlSource = custInvoice("city").ToString().Trim()
                            Log("INFO", "EksikBilgi", $"[{siparisKodu}] İL FATURA BİLGİLERİNDEN ALINDI")
                        ElseIf custDelivery IsNot Nothing AndAlso custDelivery.ContainsKey("city") AndAlso custDelivery("city") IsNot Nothing Then
                            rawIlSource = custDelivery("city").ToString().Trim()
                        End If

                        If Not String.IsNullOrEmpty(rawIlSource) Then
                            ' GetIlName ile veritabanındaki gerçek değeri al
                            Using oleConn As New OleDb.OleDbConnection(connection)
                                oleConn.Open()
                                il = GetIlName(rawIlSource, oleConn)
                                ' Eğer hala boşsa veya bulunamadıysa, validasyon için kontrol et
                                If Not String.IsNullOrEmpty(il) Then
                                    Dim checkIlCmd As New OleDb.OleDbCommand("SELECT COUNT(*) FROM tbIl WHERE sIl = ?", oleConn)
                                    checkIlCmd.Parameters.AddWithValue("?", il)
                                    Dim ilExists As Integer = CInt(checkIlCmd.ExecuteScalar())
                                    If ilExists = 0 Then
                                        Log("WARNING", "EksikBilgi", $"[{siparisKodu}] İl tbIl tablosunda bulunamadi: [{il}], il güncellemesi atlanacak")
                                        il = "" ' Boş bırak, güncelleme yapılmasın
                                    End If
                                End If
                            End Using
                        End If

                        ' ===== API'DEN GELEN VERİLERİ LOGLA =====
                        Log("INFO", "EksikBilgi", $"[{siparisKodu}] API VERİLERİ:")
                        Log("INFO", "EksikBilgi", $"  - TC (nationalId): {tc}")
                        Log("INFO", "EksikBilgi", $"  - Vergi No (taxId): {If(String.IsNullOrEmpty(sVergiNo), "BOŞ", sVergiNo)}")
                        Log("INFO", "EksikBilgi", $"  - Vergi Dairesi (taxBranch): {If(String.IsNullOrEmpty(sVergiDairesi), "BOŞ", sVergiDairesi)}")
                        Log("INFO", "EksikBilgi", $"  - Adres: {If(String.IsNullOrEmpty(adres), "BOŞ", adres)}")
                        Log("INFO", "EksikBilgi", $"  - İlçe (district): {If(String.IsNullOrEmpty(ilceVal), "BOŞ", ilceVal)}")
                        Log("INFO", "EksikBilgi", $"  - İl (city): {If(String.IsNullOrEmpty(il), "BOŞ", il)}")

                        ' Firma ID bul ve guncelle (SQL Server)
                        Dim firmaId As Integer = 0
                        Dim sqlFirmaId As String = "SELECT TOP 1 f.nFirmaID FROM tbFirma f INNER JOIN tbStokFisiMaster m ON f.nFirmaID = m.nFirmaID INNER JOIN tbStokFisiAciklamasi a ON m.nStokFisiID = a.nStokFisiID WHERE a.sAciklama3 = @kod"
                        Using cmdFirma As New SqlClient.SqlCommand(sqlFirmaId, conn)
                            cmdFirma.Parameters.AddWithValue("@kod", siparisKodu)
                            Dim result = cmdFirma.ExecuteScalar()
                            If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                                firmaId = Convert.ToInt32(result)
                                Log("DEBUG", "EksikBilgi", $"[{siparisKodu}] tbFirma'da nFirmaID bulundu: {firmaId}")
                            Else
                                Log("WARNING", "EksikBilgi", $"[{siparisKodu}] tbFirma'da kayıt BULUNAMADI - tbStokFisiAciklamasi.sAciklama3 = '{siparisKodu}' eşleşmedi")
                            End If
                        End Using

                        If firmaId > 0 Then
                            Dim updateFields As New List(Of String)
                            Dim updateParams As New List(Of SqlClient.SqlParameter)

                            If Not String.IsNullOrEmpty(adres) Then
                                updateFields.Add("sAdres1 = @adres")
                                updateParams.Add(New SqlClient.SqlParameter("@adres", If(adres.Length > 60, adres.Substring(0, 60), adres)))
                            End If
                            If Not String.IsNullOrEmpty(ilceVal) Then
                                updateFields.Add("sSemt = @ilce")
                                updateParams.Add(New SqlClient.SqlParameter("@ilce", If(ilceVal.Length > 30, ilceVal.Substring(0, 30), ilceVal)))
                            End If
                            If Not String.IsNullOrEmpty(il) Then
                                updateFields.Add("sIl = @il")
                                updateParams.Add(New SqlClient.SqlParameter("@il", If(il.Length > 30, il.Substring(0, 30), il)))
                            End If
                            ' TC ekle
                            If Not String.IsNullOrEmpty(tc) Then
                                updateFields.Add("TC = @tc")
                                updateParams.Add(New SqlClient.SqlParameter("@tc", CLng(tc)))
                            End If
                            ' Vergi No ekle (API v2.2.4 - taxId)
                            If Not String.IsNullOrEmpty(sVergiNo) Then
                                updateFields.Add("sVergiNo = @vergino")
                                updateParams.Add(New SqlClient.SqlParameter("@vergino", If(sVergiNo.Length > 20, sVergiNo.Substring(0, 20), sVergiNo)))
                            End If
                            ' Vergi Dairesi ekle (API v2.2.4 - taxBranch)
                            If Not String.IsNullOrEmpty(sVergiDairesi) Then
                                updateFields.Add("sVergiDairesi = @vergidairesi")
                                updateParams.Add(New SqlClient.SqlParameter("@vergidairesi", If(sVergiDairesi.Length > 60, sVergiDairesi.Substring(0, 60), sVergiDairesi)))
                            End If

                            If updateFields.Count > 0 Then
                                Dim sqlUpdate As String = "UPDATE tbFirma SET " & String.Join(", ", updateFields) & " WHERE nFirmaID = @firmaid"
                                updateParams.Add(New SqlClient.SqlParameter("@firmaid", firmaId))

                                Log("DEBUG", "EksikBilgi", $"[{siparisKodu}] UPDATE SQL: {sqlUpdate}")
                                Log("DEBUG", "EksikBilgi", $"[{siparisKodu}] Güncellenecek alan sayısı: {updateFields.Count}")

                                Using cmdUpdate As New SqlClient.SqlCommand(sqlUpdate, conn)
                                    For Each param As SqlClient.SqlParameter In updateParams
                                        cmdUpdate.Parameters.Add(param)
                                    Next
                                    Dim rowsAffected As Integer = cmdUpdate.ExecuteNonQuery()
                                    If rowsAffected > 0 Then
                                        guncellenenSayisi += 1
                                        Log("SUCCESS", "EksikBilgi", $"[{siparisKodu}] ✓ tbFirma GÜNCELLENDİ - nFirmaID: {firmaId}, Etkilenen satır: {rowsAffected}")
                                        SafeUpdateUI(Sub() AddLog($"✓ {siparisKodu} güncellendi"))
                                    Else
                                        Log("WARNING", "EksikBilgi", $"[{siparisKodu}] UPDATE çalıştı ama satır etkilenmedi!")
                                        atladiSayisi += 1
                                    End If
                                End Using
                            Else
                                Log("WARNING", "EksikBilgi", $"[{siparisKodu}] ATLANDI - Güncellenecek alan yok (tüm değerler boş)")
                                atladiSayisi += 1
                            End If
                        Else
                            Log("WARNING", "EksikBilgi", $"[{siparisKodu}] ATLANDI - FirmaID=0 (tbFirma'da kayıt bulunamadı)")
                            atladiSayisi += 1
                        End If

                        Thread.Sleep(300)

                    Catch orderEx As Exception
                        Log("ERROR", "EksikBilgi", $"[{siparisKodu}] HATA: {orderEx.Message}")
                        hataliSayisi += 1
                    End Try
                Next

                conn.Close()
            End Using

            Dim sonucMesaji As String = $"Tamamlandi!" & vbCrLf & $"Guncellenen: {guncellenenSayisi}" & vbCrLf & $"Atlanan: {atladiSayisi}" & vbCrLf & $"Hatali: {hataliSayisi}"
            Log("INFO", "EksikMusteriBilgileriniGuncelle", sonucMesaji.Replace(vbCrLf, " | "))
            SafeUpdateUI(Sub()
                             lblDurum.Text = "Durum: Tamamlandi"
                             MessageBox.Show(sonucMesaji, "Islem Tamamlandi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                         End Sub)

        Catch ex As Exception
            Log("ERROR", "EksikMusteriBilgileriniGuncelle", $"Genel hata: {ex.Message}")
            SafeUpdateUI(Sub() MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error))
        End Try
    End Sub

    ''' <summary>
    ''' Ülke adını ISO 3166-1 alpha-2 ülke koduna dönüştürür
    ''' Önce veritabanındaki tbUlke tablosunu kontrol eder, bulamazsa bilinen ülke kodlarını kullanır
    ''' </summary>
    ''' <param name="ulkeAdi">Ülke adı (örn: "Germany", "Deutschland", "Almanya")</param>
    ''' <param name="conn">Veritabanı bağlantısı</param>
    ''' <returns>ISO 3166-1 alpha-2 ülke kodu (örn: "DE")</returns>
    Private Function GetUlkeKodu(ulkeAdi As String, conn As OleDb.OleDbConnection) As String
        If String.IsNullOrEmpty(ulkeAdi) Then Return "XX"

        Try
            ' Önce veritabanındaki tbUlke tablosunda ara (sUlkeKodu alanı varsa)
            Try
                If conn.State <> ConnectionState.Open Then conn.Open()
                Dim ulkeCmd As New OleDb.OleDbCommand(
                    "SELECT TOP 1 sUlkeKodu FROM tbUlke WHERE sUlke LIKE ? OR sUlke LIKE ?", conn)
                ulkeCmd.Parameters.AddWithValue("?", ulkeAdi)
                ulkeCmd.Parameters.AddWithValue("?", "%" & ulkeAdi & "%")
                Dim result = ulkeCmd.ExecuteScalar()
                If result IsNot Nothing AndAlso result IsNot DBNull.Value AndAlso Not String.IsNullOrEmpty(result.ToString()) Then
                    Log("DEBUG", "GetUlkeKodu", $"Veritabanından ülke kodu bulundu: {ulkeAdi} -> {result}")
                    Return result.ToString().Trim().ToUpper()
                End If
            Catch dbEx As Exception
                ' tbUlke tablosunda sUlkeKodu alanı olmayabilir, devam et
                Log("DEBUG", "GetUlkeKodu", $"Veritabanı sorgusu başarısız: {dbEx.Message}")
            End Try

            ' Ülke adını büyük harfe çevir (case-insensitive karşılaştırma için)
            Dim ulkeUpper As String = ulkeAdi.ToUpper(New System.Globalization.CultureInfo("tr-TR"))

            ' Yaygın ülke kodları - Select Case ile hızlı eşleşme
            Select Case ulkeUpper
                ' Avrupa
                Case "GERMANY", "DEUTSCHLAND", "ALMANYA" : Return "DE"
                Case "FRANCE", "FRANKREICH", "FRANSA" : Return "FR"
                Case "ITALY", "ITALIEN", "İTALYA", "ITALYA" : Return "IT"
                Case "SPAIN", "SPANIEN", "İSPANYA", "ISPANYA" : Return "ES"
                Case "UNITED KINGDOM", "UK", "ENGLAND", "İNGİLTERE", "INGILTERE", "BİRLEŞİK KRALLIK" : Return "GB"
                Case "NETHERLANDS", "HOLLAND", "HOLLANDA" : Return "NL"
                Case "BELGIUM", "BELGIEN", "BELÇİKA", "BELCIKA" : Return "BE"
                Case "AUSTRIA", "ÖSTERREICH", "OSTERREICH", "AVUSTURYA" : Return "AT"
                Case "SWITZERLAND", "SCHWEIZ", "İSVİÇRE", "ISVICRE" : Return "CH"
                Case "POLAND", "POLEN", "POLONYA" : Return "PL"
                Case "SWEDEN", "SCHWEDEN", "İSVEÇ", "ISVEC" : Return "SE"
                Case "NORWAY", "NORWEGEN", "NORVEÇ", "NORVEC" : Return "NO"
                Case "DENMARK", "DÄNEMARK", "DANEMARK", "DANİMARKA", "DANIMARKA" : Return "DK"
                Case "FINLAND", "FINNLAND", "FİNLANDİYA", "FINLANDIYA" : Return "FI"
                Case "GREECE", "GRIECHENLAND", "YUNANİSTAN", "YUNANISTAN" : Return "GR"
                Case "PORTUGAL", "PORTEKİZ", "PORTEKIZ" : Return "PT"
                Case "IRELAND", "IRLAND", "İRLANDA", "IRLANDA" : Return "IE"
                Case "CZECH REPUBLIC", "CZECHIA", "TSCHECHIEN", "ÇEKYA", "CEKYA", "ÇEK CUMHURİYETİ" : Return "CZ"
                Case "HUNGARY", "UNGARN", "MACARİSTAN", "MACARISTAN" : Return "HU"
                Case "ROMANIA", "RUMÄNIEN", "RUMANIEN", "ROMANYA" : Return "RO"
                Case "BULGARIA", "BULGARIEN", "BULGARİSTAN", "BULGARISTAN" : Return "BG"
                Case "CROATIA", "KROATIEN", "HIRVATİSTAN", "HIRVATISTAN" : Return "HR"
                Case "SLOVAKIA", "SLOWAKEI", "SLOVAKYA" : Return "SK"
                Case "SLOVENIA", "SLOWENIEN", "SLOVENYA" : Return "SI"
                Case "LUXEMBOURG", "LUXEMBURG", "LÜKSEMBURG", "LUKSEMBURG" : Return "LU"
                Case "ESTONIA", "ESTLAND", "ESTONYA" : Return "EE"
                Case "LATVIA", "LETTLAND", "LETONYA" : Return "LV"
                Case "LITHUANIA", "LITAUEN", "LİTVANYA", "LITVANYA" : Return "LT"
                Case "CYPRUS", "ZYPERN", "KIBRIS", "KUZEY KIBRIS" : Return "CY"
                Case "MALTA" : Return "MT"
                Case "ICELAND", "ISLAND", "İZLANDA", "IZLANDA" : Return "IS"
                Case "SERBIA", "SERBIEN", "SIRBİSTAN", "SIRBISTAN" : Return "RS"
                Case "MONTENEGRO", "KARADAĞ", "KARADAG" : Return "ME"
                Case "NORTH MACEDONIA", "NORDMAZEDONIEN", "KUZEY MAKEDONYA" : Return "MK"
                Case "ALBANIA", "ALBANIEN", "ARNAVUTLUK" : Return "AL"
                Case "BOSNIA", "BOSNIEN", "BOSNA", "BOSNA HERSEK" : Return "BA"
                Case "KOSOVO", "KOSOVA" : Return "XK"
                Case "MOLDOVA", "MOLDAWIEN", "MOLDAVYA" : Return "MD"
                Case "UKRAINE", "UKRAYNA" : Return "UA"
                Case "BELARUS", "WEIßRUSSLAND", "WEISSRUSSLAND" : Return "BY"
                Case "RUSSIA", "RUSSLAND", "RUSYA" : Return "RU"

                ' Amerika
                Case "UNITED STATES", "USA", "AMERİKA", "AMERIKA", "ABD" : Return "US"
                Case "CANADA", "KANADA" : Return "CA"
                Case "MEXICO", "MEXIKO", "MEKSİKA", "MEKSIKA" : Return "MX"
                Case "BRAZIL", "BRASILIEN", "BREZİLYA", "BREZILYA" : Return "BR"
                Case "ARGENTINA", "ARGENTINIEN", "ARJANTİN", "ARJANTIN" : Return "AR"
                Case "CHILE", "ŞİLİ", "SILI" : Return "CL"
                Case "COLOMBIA", "KOLUMBIEN", "KOLOMBİYA", "KOLOMBIYA" : Return "CO"
                Case "PERU" : Return "PE"

                ' Asya
                Case "CHINA", "ÇİN", "CIN" : Return "CN"
                Case "JAPAN", "JAPONYA" : Return "JP"
                Case "SOUTH KOREA", "KOREA", "GÜNEY KORE", "GUNEY KORE" : Return "KR"
                Case "INDIA", "INDIEN", "HİNDİSTAN", "HINDISTAN" : Return "IN"
                Case "INDONESIA", "INDONESIEN", "ENDONEZYA" : Return "ID"
                Case "THAILAND", "TAYLAND" : Return "TH"
                Case "VIETNAM" : Return "VN"
                Case "PHILIPPINES", "PHILIPPINEN", "FİLİPİNLER", "FILIPINLER" : Return "PH"
                Case "MALAYSIA", "MALEZYA" : Return "MY"
                Case "SINGAPORE", "SİNGAPUR", "SINGAPUR" : Return "SG"
                Case "PAKISTAN" : Return "PK"
                Case "BANGLADESH", "BANGLADESCH", "BANGLADEŞ" : Return "BD"
                Case "SAUDI ARABIA", "SAUDIARABIEN", "SUUDİ ARABİSTAN", "SUUDI ARABISTAN" : Return "SA"
                Case "UNITED ARAB EMIRATES", "UAE", "BİRLEŞİK ARAP EMİRLİKLERİ", "BAE" : Return "AE"
                Case "ISRAEL", "İSRAİL", "ISRAIL" : Return "IL"
                Case "IRAN", "İRAN" : Return "IR"
                Case "IRAQ", "IRAK" : Return "IQ"
                Case "JORDAN", "JORDANIEN", "ÜRDÜN", "URDUN" : Return "JO"
                Case "LEBANON", "LIBANON", "LÜBNAN", "LUBNAN" : Return "LB"
                Case "KUWAIT", "KUVEYT" : Return "KW"
                Case "QATAR", "KATAR" : Return "QA"
                Case "BAHRAIN" : Return "BH"
                Case "OMAN", "UMMAN" : Return "OM"
                Case "AZERBAIJAN", "ASERBAIDSCHAN", "AZERBAYCAN" : Return "AZ"
                Case "GEORGIA", "GEORGIEN", "GÜRCİSTAN", "GURCISTAN" : Return "GE"
                Case "ARMENIA", "ARMENIEN", "ERMENİSTAN", "ERMENISTAN" : Return "AM"
                Case "KAZAKHSTAN", "KASACHSTAN", "KAZAKİSTAN", "KAZAKISTAN" : Return "KZ"
                Case "UZBEKISTAN", "USBEKISTAN", "ÖZBEKİSTAN", "OZBEKISTAN" : Return "UZ"
                Case "TURKMENISTAN", "TÜRKMENİSTAN", "TURKMENISTAN" : Return "TM"
                Case "KYRGYZSTAN", "KIRGISISTAN", "KIRGIZİSTAN", "KIRGIZISTAN" : Return "KG"
                Case "TAJIKISTAN", "TADSCHIKISTAN", "TACİKİSTAN", "TACIKISTAN" : Return "TJ"
                Case "AFGHANISTAN", "AFGANİSTAN", "AFGANISTAN" : Return "AF"
                Case "MONGOLIA", "MONGOLEI", "MOĞOLİSTAN", "MOGOLISTAN" : Return "MN"
                Case "NEPAL" : Return "NP"
                Case "SRI LANKA" : Return "LK"
                Case "MYANMAR" : Return "MM"
                Case "CAMBODIA", "KAMBODSCHA", "KAMBOÇYA", "KAMBOCYA" : Return "KH"
                Case "LAOS" : Return "LA"
                Case "HONG KONG" : Return "HK"
                Case "TAIWAN" : Return "TW"
                Case "MACAU", "MACAO" : Return "MO"

                ' Afrika
                Case "EGYPT", "ÄGYPTEN", "AGYPTEN", "MISIR" : Return "EG"
                Case "SOUTH AFRICA", "SÜDAFRIKA", "SUDAFRIKA", "GÜNEY AFRİKA", "GUNEY AFRIKA" : Return "ZA"
                Case "MOROCCO", "MAROKKO", "FAS" : Return "MA"
                Case "ALGERIA", "ALGERIEN", "CEZAYİR", "CEZAYIR" : Return "DZ"
                Case "TUNISIA", "TUNESIEN", "TUNUS" : Return "TN"
                Case "LIBYA", "LIBYEN", "LİBYA" : Return "LY"
                Case "NIGERIA", "NİJERYA", "NIJERYA" : Return "NG"
                Case "KENYA" : Return "KE"
                Case "ETHIOPIA", "ÄTHIOPIEN", "ATHIOPIEN", "ETİYOPYA", "ETIYOPYA" : Return "ET"
                Case "GHANA", "GANA" : Return "GH"
                Case "TANZANIA", "TANSANIA", "TANZANYA" : Return "TZ"
                Case "UGANDA" : Return "UG"
                Case "SUDAN" : Return "SD"
                Case "SENEGAL" : Return "SN"
                Case "IVORY COAST", "ELFENBEINKÜSTE", "FİLDİŞİ SAHİLİ", "FILDISI SAHILI" : Return "CI"
                Case "CAMEROON", "KAMERUN" : Return "CM"
                Case "ZIMBABWE", "SIMBABWE" : Return "ZW"
                Case "ANGOLA" : Return "AO"
                Case "MOZAMBIQUE", "MOSAMBIK", "MOZAMBİK", "MOZAMBIK" : Return "MZ"

                ' Okyanusya
                Case "AUSTRALIA", "AUSTRALIEN", "AVUSTRALYA" : Return "AU"
                Case "NEW ZEALAND", "NEUSEELAND", "YENİ ZELANDA", "YENI ZELANDA" : Return "NZ"

                ' Türkiye
                Case "TURKEY", "TÜRKEI", "TURKEI", "TÜRKİYE", "TURKIYE" : Return "TR"
            End Select

            ' Bulunamazsa varsayılan XX döndür
            Log("WARNING", "GetUlkeKodu", $"Ülke kodu bulunamadı: {ulkeAdi} -> XX (varsayılan)")
            Return "XX"
            
        Catch ex As Exception
            Log("ERROR", "GetUlkeKodu", $"Hata: {ex.Message}, Ülke: {ulkeAdi}")
            Return "XX"
        End Try
    End Function

End Class