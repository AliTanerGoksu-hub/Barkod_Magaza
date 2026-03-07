' ============================================================================
' OTOMATİK KAMPANYA ÖNERİSİ FORMU
' Dosya: frm_KampanyaOnerisi.vb
' Tarih: 2026-02-20
' Açıklama: Ürün performansına göre kampanya önerileri sunar
' NOT: frm_qukaGonder.vb'den BAĞIMSIZ çalışır
' ============================================================================

Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks

''' <summary>
''' Otomatik kampanya önerisi formu
''' Satış verilerine göre hangi ürünlere kampanya yapılması gerektiğini analiz eder
''' </summary>
Public Class frm_KampanyaOnerisi
    Inherits Form

#Region "Değişkenler"
    Public connection As String = ""
    Private WithEvents dgvUrunler As DataGridView
    Private pnlFiltre As Panel
    Private pnlOzet As Panel
    Private btnAnaliz As Button
    Private btnKampanyaOlustur As Button
    Private cmbKampanyaTipi As ComboBox
    Private cmbPazaryeri As ComboBox
    Private numIndirimOrani As NumericUpDown
    Private lblDurum As Label
    Private progressBar As ProgressBar
    
    Private kampanyaVerileri As New List(Of KampanyaOneri)
#End Region

#Region "Veri Yapıları"
    Public Class KampanyaOneri
        Public Property nStokID As Integer
        Public Property StokKodu As String
        Public Property ModelKodu As String
        Public Property Barkod As String
        Public Property Renk As String
        Public Property Beden As String
        Public Property Kavala As String
        Public Property UrunAdi As String
        Public Property Model As String
        Public Property Kategori As String
        Public Property MevcutFiyat As Decimal
        Public Property SatisSayisi As Integer
        Public Property Satis7Gun As Integer
        Public Property Satis30Gun As Integer
        Public Property StokMiktari As Integer
        Public Property StokYasi As Integer
        Public Property SonSatisTarihi As DateTime
        Public Property KampanyaTipi As String
        Public Property OneriFiyat As Decimal
        Public Property IndirimOrani As Decimal
        Public Property OnerilenIndirim As Decimal
        Public Property Oncelik As String
        Public Property OncelikSkoru As Integer
        Public Property Tavsiye As String
        Public Property RakipFiyat As Decimal
        Public Property RakipSayisi As Integer
        Public Property FiyatFarki As Decimal
        Public Property FiyatFarkYuzde As Decimal
    End Class
#End Region

#Region "Constructor ve Form"
    Public Sub New()
        InitializeComponent()
    End Sub
    
    Private Sub InitializeComponent()
        Me.Text = "🎯 Otomatik Kampanya Önerisi"
        Me.Size = New Size(1400, 850)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(245, 245, 250)
        
        Dim tlp As New TableLayoutPanel()
        tlp.Dock = DockStyle.Fill
        tlp.RowCount = 4
        tlp.ColumnCount = 1
        tlp.RowStyles.Add(New RowStyle(SizeType.Absolute, 75))
        tlp.RowStyles.Add(New RowStyle(SizeType.Absolute, 110))
        tlp.RowStyles.Add(New RowStyle(SizeType.Percent, 100))
        tlp.RowStyles.Add(New RowStyle(SizeType.Absolute, 35))
        tlp.Padding = New Padding(10)
        Me.Controls.Add(tlp)
        
        CreateFilterPanel(tlp)
        CreateSummaryPanel(tlp)
        CreateGrid(tlp)
        CreateStatusBar(tlp)
    End Sub
    
    Private Sub CreateFilterPanel(tlp As TableLayoutPanel)
        pnlFiltre = New Panel()
        pnlFiltre.Dock = DockStyle.Fill
        pnlFiltre.BackColor = Color.White
        pnlFiltre.Padding = New Padding(10)
        tlp.Controls.Add(pnlFiltre, 0, 0)
        
        Dim flow As New FlowLayoutPanel()
        flow.Dock = DockStyle.Fill
        flow.FlowDirection = FlowDirection.LeftToRight
        pnlFiltre.Controls.Add(flow)
        
        ' Kampanya Tipi
        Dim lblTip As New Label()
        lblTip.Text = "Kampanya Tipi:"
        lblTip.AutoSize = True
        lblTip.Margin = New Padding(0, 10, 5, 0)
        flow.Controls.Add(lblTip)
        
        cmbKampanyaTipi = New ComboBox()
        cmbKampanyaTipi.Width = 180
        cmbKampanyaTipi.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKampanyaTipi.Items.AddRange({"-- Tumu --", "STOK ERITME", "SATIS ARTIRMA", "YENI URUN TANITIM", "SEZON SONU"})
        cmbKampanyaTipi.SelectedIndex = 0
        flow.Controls.Add(cmbKampanyaTipi)
        
        ' Indirim Orani
        Dim lblIndirim As New Label()
        lblIndirim.Text = "Max Indirim %:"
        lblIndirim.AutoSize = True
        lblIndirim.Margin = New Padding(20, 10, 5, 0)
        flow.Controls.Add(lblIndirim)
        
        numIndirimOrani = New NumericUpDown()
        numIndirimOrani.Width = 70
        numIndirimOrani.Minimum = 5
        numIndirimOrani.Maximum = 70
        numIndirimOrani.Value = 30
        flow.Controls.Add(numIndirimOrani)
        
        ' Pazaryeri secimi
        Dim lblPazaryeri As New Label()
        lblPazaryeri.Text = "Pazaryeri:"
        lblPazaryeri.AutoSize = True
        lblPazaryeri.Margin = New Padding(20, 10, 5, 0)
        flow.Controls.Add(lblPazaryeri)
        
        cmbPazaryeri = New ComboBox()
        cmbPazaryeri.Width = 120
        cmbPazaryeri.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPazaryeri.Items.AddRange(New String() {"Tumu", "Trendyol", "Hepsiburada", "N11", "Amazon", "PttAVM", "Pazarama", "CicekSepeti", "Modanisa", "Farmazon", "Idefix", "LCWaikiki"})
        cmbPazaryeri.SelectedIndex = 0
        flow.Controls.Add(cmbPazaryeri)
        
        ' Analiz butonu
        btnAnaliz = New Button()
        btnAnaliz.Text = "Analiz Et"
        btnAnaliz.Width = 120
        btnAnaliz.Height = 38
        btnAnaliz.BackColor = Color.FromArgb(63, 81, 181)
        btnAnaliz.ForeColor = Color.White
        btnAnaliz.FlatStyle = FlatStyle.Flat
        btnAnaliz.Margin = New Padding(30, 5, 5, 0)
        AddHandler btnAnaliz.Click, AddressOf btnAnaliz_Click
        flow.Controls.Add(btnAnaliz)
        
        ' Kampanya Olustur butonu
        btnKampanyaOlustur = New Button()
        btnKampanyaOlustur.Text = "Secililere Kampanya Uygula"
        btnKampanyaOlustur.Width = 200
        btnKampanyaOlustur.Height = 38
        btnKampanyaOlustur.BackColor = Color.FromArgb(76, 175, 80)
        btnKampanyaOlustur.ForeColor = Color.White
        btnKampanyaOlustur.FlatStyle = FlatStyle.Flat
        btnKampanyaOlustur.Margin = New Padding(10, 5, 0, 0)
        btnKampanyaOlustur.Enabled = False
        AddHandler btnKampanyaOlustur.Click, AddressOf btnKampanyaOlustur_Click
        flow.Controls.Add(btnKampanyaOlustur)
    End Sub
    
    Private Sub CreateSummaryPanel(tlp As TableLayoutPanel)
        pnlOzet = New Panel()
        pnlOzet.Dock = DockStyle.Fill
        pnlOzet.BackColor = Color.FromArgb(33, 33, 33)
        pnlOzet.Padding = New Padding(15)
        tlp.Controls.Add(pnlOzet, 0, 1)
        
        Dim flow As New FlowLayoutPanel()
        flow.Dock = DockStyle.Fill
        flow.FlowDirection = FlowDirection.LeftToRight
        pnlOzet.Controls.Add(flow)
        
        CreateCard(flow, "📦 Toplam Öneri", "0", Color.FromArgb(63, 81, 181), "toplam")
        CreateCard(flow, "🔴 Yüksek Öncelik", "0", Color.FromArgb(244, 67, 54), "yuksek")
        CreateCard(flow, "🟡 Orta Öncelik", "0", Color.FromArgb(255, 152, 0), "orta")
        CreateCard(flow, "🟢 Düşük Öncelik", "0", Color.FromArgb(76, 175, 80), "dusuk")
        CreateCard(flow, "📉 Stok Eritme", "0", Color.FromArgb(156, 39, 176), "stokeritme")
        CreateCard(flow, "💰 Potansiyel Ciro", "₺0", Color.FromArgb(0, 150, 136), "ciro")
    End Sub
    
    Private Sub CreateCard(parent As FlowLayoutPanel, title As String, value As String, color As Color, tag As String)
        Dim pnl As New Panel()
        pnl.Size = New Size(175, 75)
        pnl.BackColor = color
        pnl.Margin = New Padding(5)
        pnl.Tag = tag
        parent.Controls.Add(pnl)
        
        Dim lblTitle As New Label()
        lblTitle.Text = title
        lblTitle.ForeColor = Color.White
        lblTitle.Font = New Font("Segoe UI", 9)
        lblTitle.Location = New Point(10, 8)
        lblTitle.AutoSize = True
        pnl.Controls.Add(lblTitle)
        
        Dim lblValue As New Label()
        lblValue.Text = value
        lblValue.ForeColor = Color.White
        lblValue.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblValue.Location = New Point(10, 35)
        lblValue.AutoSize = True
        lblValue.Tag = "value"
        pnl.Controls.Add(lblValue)
    End Sub
    
    Private Sub CreateGrid(tlp As TableLayoutPanel)
        dgvUrunler = New DataGridView()
        dgvUrunler.Dock = DockStyle.Fill
        dgvUrunler.BackgroundColor = Color.White
        dgvUrunler.BorderStyle = BorderStyle.None
        dgvUrunler.RowHeadersVisible = False
        dgvUrunler.AllowUserToAddRows = False
        dgvUrunler.AllowUserToDeleteRows = False
        dgvUrunler.AllowUserToResizeColumns = True
        dgvUrunler.AllowUserToOrderColumns = True
        dgvUrunler.SelectionMode = DataGridViewSelectionMode.CellSelect
        dgvUrunler.MultiSelect = True
        dgvUrunler.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        dgvUrunler.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 60)
        dgvUrunler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvUrunler.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        dgvUrunler.ColumnHeadersHeight = 28
        dgvUrunler.RowTemplate.Height = 24
        dgvUrunler.EnableHeadersVisualStyles = False
        dgvUrunler.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 250)
        dgvUrunler.DefaultCellStyle.Font = New Font("Segoe UI", 8)
        dgvUrunler.DefaultCellStyle.Padding = New Padding(2, 1, 2, 1)
        dgvUrunler.DefaultCellStyle.SelectionBackColor = Color.FromArgb(63, 81, 181)
        dgvUrunler.DefaultCellStyle.SelectionForeColor = Color.White
        tlp.Controls.Add(dgvUrunler, 0, 2)
        
        ' Cift tiklama ile hucre kopyalama
        AddHandler dgvUrunler.CellDoubleClick, Sub(s, e)
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim deger = dgvUrunler.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
                If deger IsNot Nothing Then
                    Clipboard.SetText(deger.ToString())
                End If
            End If
        End Sub
        
        ' Sag tik menusu
        Dim contextMenu As New ContextMenuStrip()
        
        Dim mnuHucreKopyala As New ToolStripMenuItem("Secili Hucreyi Kopyala")
        AddHandler mnuHucreKopyala.Click, Sub()
            If dgvUrunler.CurrentCell IsNot Nothing AndAlso dgvUrunler.CurrentCell.Value IsNot Nothing Then
                Clipboard.SetText(dgvUrunler.CurrentCell.Value.ToString())
            End If
        End Sub
        contextMenu.Items.Add(mnuHucreKopyala)
        
        Dim mnuSatirKopyala As New ToolStripMenuItem("Secili Satiri Kopyala")
        AddHandler mnuSatirKopyala.Click, Sub()
            If dgvUrunler.CurrentRow IsNot Nothing Then
                Dim satirVerisi As New List(Of String)
                For Each cell As DataGridViewCell In dgvUrunler.CurrentRow.Cells
                    If cell.Value IsNot Nothing Then
                        satirVerisi.Add(cell.Value.ToString())
                    End If
                Next
                Clipboard.SetText(String.Join(vbTab, satirVerisi))
            End If
        End Sub
        contextMenu.Items.Add(mnuSatirKopyala)
        
        contextMenu.Items.Add(New ToolStripSeparator())
        
        Dim mnuTumunuKopyala As New ToolStripMenuItem("Tum Verileri Kopyala")
        AddHandler mnuTumunuKopyala.Click, Sub() KopyalaTumVeriler()
        contextMenu.Items.Add(mnuTumunuKopyala)
        
        contextMenu.Items.Add(New ToolStripSeparator())
        
        Dim mnuGorunumDuzenle As New ToolStripMenuItem("Gorunum Duzenle...")
        AddHandler mnuGorunumDuzenle.Click, Sub() GorunumDuzenle()
        contextMenu.Items.Add(mnuGorunumDuzenle)
        
        Dim mnuGorunumKaydet As New ToolStripMenuItem("Gorunumu Kaydet")
        AddHandler mnuGorunumKaydet.Click, Sub() GorunumKaydet()
        contextMenu.Items.Add(mnuGorunumKaydet)
        
        dgvUrunler.ContextMenuStrip = contextMenu
        
        ' Checkbox kolonu
        Dim chkCol As New DataGridViewCheckBoxColumn()
        chkCol.Name = "Sec"
        chkCol.HeaderText = "✓"
        chkCol.Width = 30
        chkCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        chkCol.Resizable = DataGridViewTriState.False
        dgvUrunler.Columns.Add(chkCol)
        
        dgvUrunler.Columns.Add("nStokID", "ID")
        dgvUrunler.Columns("nStokID").Visible = False
        dgvUrunler.Columns("nStokID").Width = 50
        
        dgvUrunler.Columns.Add("StokKodu", "Stok Kodu")
        dgvUrunler.Columns("StokKodu").Width = 90
        
        dgvUrunler.Columns.Add("ModelKodu", "Model")
        dgvUrunler.Columns("ModelKodu").Width = 80
        
        dgvUrunler.Columns.Add("Barkod", "Barkod")
        dgvUrunler.Columns("Barkod").Width = 100
        
        dgvUrunler.Columns.Add("UrunAdi", "Urun Adi")
        dgvUrunler.Columns("UrunAdi").Width = 160
        
        dgvUrunler.Columns.Add("Renk", "Renk")
        dgvUrunler.Columns("Renk").Width = 70
        
        dgvUrunler.Columns.Add("Beden", "Beden")
        dgvUrunler.Columns("Beden").Width = 60
        
        dgvUrunler.Columns.Add("Kavala", "Kavala")
        dgvUrunler.Columns("Kavala").Width = 70
        
        dgvUrunler.Columns.Add("Kategori", "Kategori")
        dgvUrunler.Columns("Kategori").Width = 90
        
        dgvUrunler.Columns.Add("MevcutFiyat", "Mevcut Fiyat")
        dgvUrunler.Columns("MevcutFiyat").Width = 80
        dgvUrunler.Columns("MevcutFiyat").DefaultCellStyle.Format = "₺#,##0.00"
        
        dgvUrunler.Columns.Add("StokMiktari", "Stok")
        dgvUrunler.Columns("StokMiktari").Width = 50
        
        dgvUrunler.Columns.Add("StokYasi", "Stok Yasi")
        dgvUrunler.Columns("StokYasi").Width = 60
        
        dgvUrunler.Columns.Add("SatisSayisi", "Satis")
        dgvUrunler.Columns("SatisSayisi").Width = 50
        
        dgvUrunler.Columns.Add("KampanyaTipi", "Kampanya Tipi")
        dgvUrunler.Columns("KampanyaTipi").Width = 100
        
        dgvUrunler.Columns.Add("IndirimOrani", "Indirim %")
        dgvUrunler.Columns("IndirimOrani").Width = 65
        dgvUrunler.Columns("IndirimOrani").DefaultCellStyle.Format = "#0'%'"
        
        dgvUrunler.Columns.Add("OneriFiyat", "Oneri Fiyat")
        dgvUrunler.Columns("OneriFiyat").Width = 80
        dgvUrunler.Columns("OneriFiyat").DefaultCellStyle.Format = "₺#,##0.00"
        
        dgvUrunler.Columns.Add("Oncelik", "Oncelik")
        dgvUrunler.Columns("Oncelik").Width = 80
        
        dgvUrunler.Columns.Add("Tavsiye", "Tavsiye")
        dgvUrunler.Columns("Tavsiye").Width = 200
    End Sub
    
    Private Sub KopyalaTumVeriler()
        Try
            dgvUrunler.SelectAll()
            Dim data = dgvUrunler.GetClipboardContent()
            If data IsNot Nothing Then
                Clipboard.SetDataObject(data)
                MessageBox.Show("Tum veriler panoya kopyalandi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Kopyalama hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub GorunumDuzenle()
        Using frm As New frmGorunumDuzenle(dgvUrunler)
            frm.ShowDialog()
        End Using
    End Sub
    
    Private Sub GorunumKaydet()
        Try
            Dim ayarlar As New List(Of String)
            For Each col As DataGridViewColumn In dgvUrunler.Columns
                ayarlar.Add($"{col.Name}|{col.Visible}|{col.Width}|{col.DisplayIndex}")
            Next
            
            Dim dosyaAdi As String = $"C:\eticaret\gorunum_{Me.Name}_{dgvUrunler.Name}.txt"
            System.IO.File.WriteAllLines(dosyaAdi, ayarlar)
            MessageBox.Show("Gorunum kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Kaydetme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub GorunumYukle()
        Try
            Dim dosyaAdi As String = $"C:\eticaret\gorunum_{Me.Name}_{dgvUrunler.Name}.txt"
            If System.IO.File.Exists(dosyaAdi) Then
                Dim satirlar = System.IO.File.ReadAllLines(dosyaAdi)
                For Each satir As String In satirlar
                    Dim parcalar = satir.Split("|"c)
                    If parcalar.Length >= 4 AndAlso dgvUrunler.Columns.Contains(parcalar(0)) Then
                        Dim col = dgvUrunler.Columns(parcalar(0))
                        col.Visible = Boolean.Parse(parcalar(1))
                        col.Width = Integer.Parse(parcalar(2))
                        col.DisplayIndex = Integer.Parse(parcalar(3))
                    End If
                Next
            End If
        Catch
            ' Sessizce devam et
        End Try
    End Sub
    
    Private Sub CreateStatusBar(tlp As TableLayoutPanel)
        Dim pnl As New Panel()
        pnl.Dock = DockStyle.Fill
        pnl.BackColor = Color.FromArgb(50, 50, 60)
        tlp.Controls.Add(pnl, 0, 3)
        
        lblDurum = New Label()
        lblDurum.Dock = DockStyle.Left
        lblDurum.ForeColor = Color.White
        lblDurum.AutoSize = True
        lblDurum.Padding = New Padding(5)
        lblDurum.Text = "Hazır. Kampanya önerileri için Analiz Et butonuna tıklayın."
        pnl.Controls.Add(lblDurum)
        
        progressBar = New ProgressBar()
        progressBar.Dock = DockStyle.Right
        progressBar.Width = 200
        pnl.Controls.Add(progressBar)
    End Sub
    
    Private Sub frm_KampanyaOnerisi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            EticaretLogger.LogInfo("Kampanya Önerisi formu yükleniyor...")
            
            ' Connection string kontrolu - bos ise global KeyCode'dan al
            If String.IsNullOrEmpty(connection) Then
                connection = KeyCode.connection
            End If
            
            ' Kaydedilmis gorunumu yukle
            GorunumYukle()
            
            EticaretLogger.LogInfo("Kampanya Önerisi formu yüklendi.")
        Catch ex As Exception
            EticaretLogger.LogError("Kampanya formu yükleme hatası", ex)
        End Try
    End Sub
#End Region

#Region "Veri İşlemleri"
    Private Async Sub btnAnaliz_Click(sender As Object, e As EventArgs)
        Try
            btnAnaliz.Enabled = False
            btnKampanyaOlustur.Enabled = False
            progressBar.Value = 0
            lblDurum.Text = "Kampanya önerileri hesaplanıyor..."
            kampanyaVerileri.Clear()
            
            EticaretLogger.LogInfo("Kampanya analizi başlatıldı.")
            
            Await Task.Run(Sub() AnalyzeKampanyaFromCache())
            
            DisplayResults()
            UpdateSummary()
            
            btnKampanyaOlustur.Enabled = kampanyaVerileri.Count > 0
            lblDurum.Text = $"Analiz tamamlandı. {kampanyaVerileri.Count} ürün için kampanya önerisi oluşturuldu."
            EticaretLogger.LogInfo($"Kampanya analizi tamamlandı. {kampanyaVerileri.Count} öneri.")
            
        Catch ex As Exception
            EticaretLogger.LogError("Kampanya analizi hatası", ex)
            MessageBox.Show($"Analiz hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnAnaliz.Enabled = True
            progressBar.Value = 100
        End Try
    End Sub
    
    ''' <summary>
    ''' Merkezi cache sisteminden kampanya önerisi verilerini yükler
    ''' </summary>
    Private Sub AnalyzeKampanyaFromCache()
        Try
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                Dim pazaryeri As String = ""
                Dim kategori As String = ""
                
                Me.Invoke(Sub()
                    pazaryeri = If(cmbPazaryeri IsNot Nothing AndAlso cmbPazaryeri.SelectedIndex >= 0, cmbPazaryeri.Text, "Tümü")
                    kategori = ""
                    lblDurum.Text = "Veritabanına bağlanılıyor..."
                End Sub)
                
                EticaretLogger.LogInfo($"AnalyzeKampanyaFromCache başlatıldı. Pazaryeri={pazaryeri}")
                
                ' Merkezi cache'den veri al
                Me.Invoke(Sub() lblDurum.Text = "Cache verisi alınıyor...")
                
                Dim cacheData As List(Of ETicaretAnalizData) = PazaryeriAPIHelper.GetAllAnalizData(
                    conn, pazaryeri, kategori,
                    Sub(current, total, message)
                        Me.Invoke(Sub()
                            If total > 0 Then progressBar.Value = CInt((current / total) * 100)
                            lblDurum.Text = message
                        End Sub)
                    End Sub)
                
                EticaretLogger.LogInfo($"Cache'den {cacheData.Count} kayıt alındı")
                
                If cacheData.Count = 0 Then
                    Me.Invoke(Sub()
                        lblDurum.Text = "Veri bulunamadı."
                        MessageBox.Show("Cache'den veri alınamadı. Log: C:\eticaret\log", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Sub)
                    Return
                End If
                
                ' Cache verisini Kampanya modeline dönüştür
                Me.Invoke(Sub() lblDurum.Text = $"İşleniyor: 0/{cacheData.Count}")
                
                Dim sayac As Integer = 0
                For Each cacheItem As ETicaretAnalizData In cacheData
                    sayac += 1
                    
                    If sayac Mod 100 = 0 Then
                        Me.Invoke(Sub()
                            progressBar.Value = CInt((sayac / cacheData.Count) * 100)
                            lblDurum.Text = $"İşleniyor: {sayac}/{cacheData.Count}"
                        End Sub)
                    End If
                    
                    Dim kampanya As New KampanyaOneri()
                    kampanya.nStokID = cacheItem.nStokID
                    kampanya.StokKodu = cacheItem.StokKodu
                    kampanya.ModelKodu = cacheItem.Model
                    kampanya.Barkod = cacheItem.Barkod
                    kampanya.Renk = cacheItem.Renk
                    kampanya.Beden = cacheItem.Beden
                    kampanya.Kavala = ""
                    kampanya.UrunAdi = cacheItem.UrunAdi
                    kampanya.Kategori = cacheItem.Kategori
                    
                    ' Cache'den gelen veriler
                    kampanya.MevcutFiyat = cacheItem.BizimFiyat
                    kampanya.Satis7Gun = cacheItem.Satis7Gun
                    kampanya.Satis30Gun = cacheItem.Satis30Gun
                    kampanya.StokMiktari = cacheItem.StokMiktari
                    kampanya.RakipFiyat = cacheItem.EnDusukRakipFiyat
                    kampanya.RakipSayisi = cacheItem.RakipSayisi
                    kampanya.FiyatFarki = cacheItem.FiyatFarki
                    kampanya.FiyatFarkYuzde = cacheItem.FiyatFarkYuzde
                    
                    ' Kampanya önerisi hesapla
                    CalculateKampanyaOneri(kampanya)
                    
                    ' Sadece kampanya önerisi olanları ekle
                    If kampanya.OnerilenIndirim > 0 OrElse kampanya.KampanyaTipi <> "YOK" Then
                        kampanyaVerileri.Add(kampanya)
                    End If
                Next
                
                EticaretLogger.LogInfo($"Cache'den {kampanyaVerileri.Count} kampanya önerisi oluşturuldu")
            End Using
        Catch ex As Exception
            EticaretLogger.LogError("AnalyzeKampanyaFromCache hatası", ex)
            Me.Invoke(Sub()
                lblDurum.Text = $"HATA: {ex.Message}"
                MessageBox.Show($"Analiz hatası: {ex.Message}" & vbCrLf & vbCrLf & "Log: C:\eticaret\log", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Sub)
        End Try
    End Sub
    
    ' Eski fonksiyon - artık kullanılmıyor, cache sistemi kullanılıyor
    Private Sub AnalyzeKampanya_OLD()
        Try
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                ' Pazaryeri prefix'i belirle
                Dim pazaryeri As String = If(cmbPazaryeri IsNot Nothing AndAlso cmbPazaryeri.SelectedIndex >= 0, cmbPazaryeri.Text, "Tumu")
                Dim pazaryeriPrefix As String = GetPazaryeriPrefix(pazaryeri)
                Dim fiyatTipi As String = GetFiyatTipi(pazaryeri)
                
                ' Pazaryeri filtresi
                Dim pazaryeriWhere As String = ""
                If pazaryeriPrefix <> "" Then
                    If pazaryeriPrefix.Length = 3 Then
                        pazaryeriWhere = " AND LEFT(ISNULL(a.sAciklama3,''),3) = '" & pazaryeriPrefix & "' "
                    Else
                        pazaryeriWhere = " AND LEFT(ISNULL(a.sAciklama3,''),2) = '" & pazaryeriPrefix & "' "
                    End If
                End If
                
                ' Gercek stok, satis ve fiyat verilerini ceken SQL
                Dim sql As String = "SELECT " &
                    "s.nStokID, s.sKodu AS sStokKodu, s.sModel, " &
                    "ISNULL((SELECT TOP 1 b.sBarkod FROM tbStokBarkodu b WHERE b.nStokID = s.nStokID), '') AS sBarkod, " &
                    "ISNULL(s.sRenk, '') AS sRenk, ISNULL(s.sBeden, '') AS sBeden, ISNULL(s.sKavala, '') AS sKavala, " &
                    "s.sAciklama, " &
                    "ISNULL((SELECT TOP 1 f.lFiyat FROM tbStokFiyati f WHERE f.nStokID = s.nStokID AND f.sFiyatTipi = '" & fiyatTipi & "' ORDER BY f.dteFiyatTespitTarihi DESC), 0) AS Fiyat, " &
                    "(SELECT sAciklama FROM tbSSinif4 WHERE sSinifKodu=si.sSinifKodu4) AS Kategori, " &
                    "ISNULL((SELECT SUM(d.lGirisMiktar1 - d.lCikisMiktar1) FROM tbStokFisiDetayi d WHERE d.nStokID = s.nStokID), 0) AS StokMiktari, " &
                    "ISNULL((SELECT SUM(d.lCikisMiktar1) FROM tbStokFisiDetayi d " &
                    "  INNER JOIN tbStokFisiMaster m ON d.nStokFisiID = m.nStokFisiID " &
                    "  LEFT JOIN tbStokFisiAciklamasi a ON m.nStokFisiID = a.nStokFisiID " &
                    "  WHERE d.nStokID = s.nStokID AND m.sFisTipi = 'FS ' AND d.lCikisMiktar1 > 0 " &
                    "  AND m.dteFisTarihi >= DATEADD(day, -30, GETDATE()) " & pazaryeriWhere & "), 0) AS SatisSayisi, " &
                    "(SELECT MAX(m.dteFisTarihi) FROM tbStokFisiDetayi d " &
                    "  INNER JOIN tbStokFisiMaster m ON d.nStokFisiID = m.nStokFisiID " &
                    "  LEFT JOIN tbStokFisiAciklamasi a ON m.nStokFisiID = a.nStokFisiID " &
                    "  WHERE d.nStokID = s.nStokID AND m.sFisTipi = 'FS ' " & pazaryeriWhere & ") AS SonSatisTarihi, " &
                    "(SELECT MIN(m.dteFisTarihi) FROM tbStokFisiDetayi d " &
                    "  INNER JOIN tbStokFisiMaster m ON d.nStokFisiID = m.nStokFisiID " &
                    "  WHERE d.nStokID = s.nStokID AND m.sFisTipi = 'AG ' AND d.lGirisMiktar1 > 0) AS IlkGirisTarihi " &
                    "FROM tbStok s " &
                    "LEFT JOIN tbStokSinifi si ON si.nStokID = s.nStokID " &
                    "WHERE s.bWebGoruntule = 1 AND s.nStokTipi < 5 " &
                    "ORDER BY s.nStokID DESC"
                
                EticaretLogger.LogDatabase("SELECT", "tbStok, tbStokFisiDetayi, tbStokFisiMaster", 0, sql)
                
                Dim cmd As New OleDbCommand(sql, conn)
                cmd.CommandTimeout = 120
                
                Dim maxIndirim As Decimal = numIndirimOrani.Value
                
                Using reader = cmd.ExecuteReader()
                    Dim sayac As Integer = 0
                    
                    While reader.Read()
                        sayac += 1
                        
                        If sayac Mod 50 = 0 Then
                            Me.Invoke(Sub()
                                progressBar.Value = Math.Min(sayac, 100)
                                lblDurum.Text = $"Yükleniyor: {sayac} ürün..."
                            End Sub)
                        End If
                        
                        Dim oneri As New KampanyaOneri()
                        oneri.nStokID = CInt(reader("nStokID"))
                        oneri.StokKodu = If(IsDBNull(reader("sStokKodu")), "", reader("sStokKodu").ToString())
                        oneri.ModelKodu = If(IsDBNull(reader("sModel")), "", reader("sModel").ToString())
                        oneri.Barkod = If(IsDBNull(reader("sBarkod")), "", reader("sBarkod").ToString())
                        oneri.Renk = If(IsDBNull(reader("sRenk")), "", reader("sRenk").ToString())
                        oneri.Beden = If(IsDBNull(reader("sBeden")), "", reader("sBeden").ToString())
                        oneri.Kavala = If(IsDBNull(reader("sKavala")), "", reader("sKavala").ToString())
                        oneri.UrunAdi = If(IsDBNull(reader("sAciklama")), "", reader("sAciklama").ToString())
                        oneri.Model = If(IsDBNull(reader("sModel")), "", reader("sModel").ToString())
                        oneri.Kategori = If(IsDBNull(reader("Kategori")), "", reader("Kategori").ToString())
                        oneri.MevcutFiyat = If(IsDBNull(reader("Fiyat")), 0D, CDec(reader("Fiyat")))
                        oneri.StokMiktari = If(IsDBNull(reader("StokMiktari")), 0, CInt(reader("StokMiktari")))
                        oneri.SatisSayisi = If(IsDBNull(reader("SatisSayisi")), 0, CInt(reader("SatisSayisi")))
                        oneri.SonSatisTarihi = If(IsDBNull(reader("SonSatisTarihi")), DateTime.MinValue, CDate(reader("SonSatisTarihi")))
                        
                        ' Stok yasi hesapla (ilk giris tarihinden itibaren)
                        Dim ilkGirisTarihi As DateTime = If(IsDBNull(reader("IlkGirisTarihi")), DateTime.Now, CDate(reader("IlkGirisTarihi")))
                        oneri.StokYasi = CInt((DateTime.Now - ilkGirisTarihi).TotalDays)
                        If oneri.StokYasi < 0 Then oneri.StokYasi = 0
                        
                        ' Kampanya tipi ve oncelik hesapla
                        CalculateKampanya(oneri, maxIndirim)
                        
                        ' Sadece kampanya onerisi olanlari ekle
                        If oneri.OncelikSkoru > 0 Then
                            kampanyaVerileri.Add(oneri)
                        End If
                    End While
                    
                    EticaretLogger.LogInfo($"Kampanya analizi tamamlandi: {sayac} urun incelendi, {kampanyaVerileri.Count} oneri")
                End Using
                
            End Using
        Catch ex As Exception
            EticaretLogger.LogError("AnalyzeKampanya hatası", ex)
            Throw
        End Try
    End Sub
    
    Private Function GetPazaryeriPrefix(pazaryeri As String) As String
        Select Case pazaryeri
            Case "Trendyol" : Return "TY"
            Case "Hepsiburada" : Return "HB"
            Case "N11" : Return "N11"
            Case "Amazon" : Return "AM"
            Case "PttAVM" : Return "PT"
            Case "Pazarama" : Return "PZ"
            Case "CicekSepeti" : Return "CS"
            Case "Modanisa" : Return "MH"
            Case "Farmazon" : Return "FA"
            Case "Idefix" : Return "ID"
            Case "LCWaikiki" : Return "LCW"
            Case Else : Return ""
        End Select
    End Function
    
    Private Function GetFiyatTipi(pazaryeri As String) As String
        Select Case pazaryeri
            Case "Trendyol" : Return "WEBP"
            Case "Hepsiburada" : Return "WEBP"
            Case "N11" : Return "WEBP"
            Case "Amazon" : Return "WEBP"
            Case "PttAVM" : Return "WEBP"
            Case "Pazarama" : Return "WEBP"
            Case "CicekSepeti" : Return "WEBP"
            Case "Modanisa" : Return "WEBP"
            Case "Idefix" : Return "WEBP"
            Case "LCWaikiki" : Return "WEBP"
            Case "Farmazon" : Return "WEBP"
            Case Else : Return "WEBP"
        End Select
    End Function
    
    ''' <summary>
    ''' Cache verisinden kampanya önerisi hesaplar
    ''' </summary>
    Private Sub CalculateKampanyaOneri(oneri As KampanyaOneri)
        Dim skor As Integer = 0
        Dim indirimOrani As Decimal = 0
        
        ' Max indirim oranını UI'dan al
        Dim maxIndirim As Decimal = 30
        Me.Invoke(Sub() maxIndirim = numIndirimOrani.Value)
        
        ' 30 günlük satışı kullan
        oneri.SatisSayisi = oneri.Satis30Gun
        
        ' ===== STOK ERİTME =====
        ' Yüksek stok + düşük satış
        If oneri.StokMiktari > 100 AndAlso oneri.SatisSayisi < 10 Then
            oneri.KampanyaTipi = "🔴 STOK ERİTME"
            indirimOrani = Math.Min(maxIndirim, 40)
            skor = 90
            oneri.Tavsiye = "ACİL! Stok erimiyor, agresif indirim önerilir"
        
        ' ===== RAKIP BAZLI FİYAT İNDİRİMİ =====
        ElseIf oneri.FiyatFarkYuzde > 10 AndAlso oneri.RakipSayisi > 0 Then
            oneri.KampanyaTipi = "🟠 RAKİP FİYAT"
            indirimOrani = Math.Min(maxIndirim, oneri.FiyatFarkYuzde)
            skor = 75
            oneri.Tavsiye = $"Rakiplerden %{oneri.FiyatFarkYuzde:N0} pahalısınız"
        
        ' ===== SATIŞ ARTIRMA =====
        ElseIf oneri.StokMiktari > 50 AndAlso oneri.SatisSayisi < 30 Then
            oneri.KampanyaTipi = "🟡 SATIŞ ARTIRMA"
            indirimOrani = Math.Min(maxIndirim, 20)
            skor = 50
            oneri.Tavsiye = "Satışları canlandırmak için hafif indirim"
        
        ' ===== YENİ ÜRÜN TANITIM =====
        ElseIf oneri.Satis7Gun = 0 AndAlso oneri.StokMiktari > 20 Then
            oneri.KampanyaTipi = "🟢 YENİ ÜRÜN"
            indirimOrani = Math.Min(maxIndirim, 15)
            skor = 40
            oneri.Tavsiye = "Yeni ürün tanıtım kampanyası"
        
        Else
            oneri.KampanyaTipi = "YOK"
            skor = 0
        End If
        
        ' Filtre kontrolü
        If cmbKampanyaTipi.SelectedIndex > 0 Then
            Dim secili = cmbKampanyaTipi.SelectedItem.ToString().ToUpper()
            If oneri.KampanyaTipi Is Nothing OrElse Not oneri.KampanyaTipi.ToUpper().Contains(secili.Split(" "c)(0)) Then
                skor = 0
            End If
        End If
        
        oneri.OncelikSkoru = skor
        oneri.IndirimOrani = indirimOrani
        oneri.OnerilenIndirim = indirimOrani
        
        ' Öneri fiyat hesapla
        If indirimOrani > 0 AndAlso oneri.MevcutFiyat > 0 Then
            oneri.OneriFiyat = Math.Round(oneri.MevcutFiyat * (1 - indirimOrani / 100), 2)
        Else
            oneri.OneriFiyat = oneri.MevcutFiyat
        End If
        
        ' Öncelik seviyesi
        Select Case skor
            Case Is >= 70
                oneri.Oncelik = "🔴 YÜKSEK"
            Case Is >= 40
                oneri.Oncelik = "🟡 ORTA"
            Case Is > 0
                oneri.Oncelik = "🟢 DÜŞÜK"
            Case Else
                oneri.Oncelik = ""
        End Select
    End Sub
    
    Private Sub CalculateKampanya(oneri As KampanyaOneri, maxIndirim As Decimal)
        Dim skor As Integer = 0
        Dim indirimOrani As Decimal = 0
        
        ' ===== STOK ERİTME =====
        ' Yüksek stok + düşük satış + eski stok
        If oneri.StokMiktari > 100 AndAlso oneri.SatisSayisi < 10 AndAlso oneri.StokYasi > 90 Then
            oneri.KampanyaTipi = "🔴 STOK ERİTME"
            indirimOrani = Math.Min(maxIndirim, 40)
            skor = 90
            oneri.Tavsiye = "ACİL! Stok yaşlanıyor, agresif indirim önerilir"
        
        ' ===== SEZON SONU =====
        ElseIf oneri.StokYasi > 120 Then
            oneri.KampanyaTipi = "🟠 SEZON SONU"
            indirimOrani = Math.Min(maxIndirim, 35)
            skor = 70
            oneri.Tavsiye = "Sezon sonu indirimi, stoğu eritmek için ideal"
        
        ' ===== SATIŞ ARTIRMA =====
        ElseIf oneri.StokMiktari > 50 AndAlso oneri.SatisSayisi < 30 Then
            oneri.KampanyaTipi = "🟡 SATIŞ ARTIRMA"
            indirimOrani = Math.Min(maxIndirim, 20)
            skor = 50
            oneri.Tavsiye = "Satışları canlandırmak için hafif indirim"
        
        ' ===== YENİ ÜRÜN TANITIM =====
        ElseIf oneri.StokYasi < 30 AndAlso oneri.SatisSayisi < 5 Then
            oneri.KampanyaTipi = "🟢 YENİ ÜRÜN"
            indirimOrani = Math.Min(maxIndirim, 15)
            skor = 40
            oneri.Tavsiye = "Yeni ürün tanıtım kampanyası"
        
        Else
            ' Kampanya önerilmez
            skor = 0
        End If
        
        ' Filtre kontrolü
        If cmbKampanyaTipi.SelectedIndex > 0 Then
            Dim secili = cmbKampanyaTipi.SelectedItem.ToString()
            If Not oneri.KampanyaTipi.Contains(secili.Split(" "c)(0)) Then
                skor = 0
            End If
        End If
        
        oneri.OncelikSkoru = skor
        oneri.IndirimOrani = indirimOrani
        
        ' Öneri fiyat hesapla
        If indirimOrani > 0 AndAlso oneri.MevcutFiyat > 0 Then
            oneri.OneriFiyat = Math.Round(oneri.MevcutFiyat * (1 - indirimOrani / 100), 2)
        Else
            oneri.OneriFiyat = oneri.MevcutFiyat
        End If
        
        ' Öncelik seviyesi
        Select Case skor
            Case Is >= 70
                oneri.Oncelik = "🔴 YÜKSEK"
            Case Is >= 40
                oneri.Oncelik = "🟡 ORTA"
            Case Is > 0
                oneri.Oncelik = "🟢 DÜŞÜK"
            Case Else
                oneri.Oncelik = ""
        End Select
    End Sub
    
    Private Sub DisplayResults()
        Try
            dgvUrunler.Rows.Clear()
            
            ' Sort by OncelikSkoru descending
            Dim sorted As New List(Of KampanyaOneri)
            For Each item As KampanyaOneri In kampanyaVerileri
                sorted.Add(item)
            Next
            sorted.Sort(Function(x, y) y.OncelikSkoru.CompareTo(x.OncelikSkoru))
            
            For Each kampOneri As KampanyaOneri In sorted
                Dim row = dgvUrunler.Rows.Add()
                dgvUrunler.Rows(row).Cells("Sec").Value = False
                dgvUrunler.Rows(row).Cells("nStokID").Value = kampOneri.nStokID
                dgvUrunler.Rows(row).Cells("StokKodu").Value = kampOneri.StokKodu
                dgvUrunler.Rows(row).Cells("ModelKodu").Value = kampOneri.ModelKodu
                dgvUrunler.Rows(row).Cells("Barkod").Value = kampOneri.Barkod
                dgvUrunler.Rows(row).Cells("UrunAdi").Value = kampOneri.UrunAdi
                dgvUrunler.Rows(row).Cells("Renk").Value = kampOneri.Renk
                dgvUrunler.Rows(row).Cells("Beden").Value = kampOneri.Beden
                dgvUrunler.Rows(row).Cells("Kavala").Value = kampOneri.Kavala
                dgvUrunler.Rows(row).Cells("Kategori").Value = kampOneri.Kategori
                dgvUrunler.Rows(row).Cells("MevcutFiyat").Value = kampOneri.MevcutFiyat
                dgvUrunler.Rows(row).Cells("StokMiktari").Value = kampOneri.StokMiktari
                dgvUrunler.Rows(row).Cells("StokYasi").Value = $"{kampOneri.StokYasi} gun"
                dgvUrunler.Rows(row).Cells("SatisSayisi").Value = kampOneri.SatisSayisi
                dgvUrunler.Rows(row).Cells("KampanyaTipi").Value = kampOneri.KampanyaTipi
                dgvUrunler.Rows(row).Cells("IndirimOrani").Value = kampOneri.IndirimOrani
                dgvUrunler.Rows(row).Cells("OneriFiyat").Value = kampOneri.OneriFiyat
                dgvUrunler.Rows(row).Cells("Oncelik").Value = kampOneri.Oncelik
                dgvUrunler.Rows(row).Cells("Tavsiye").Value = kampOneri.Tavsiye
                
                ' Renklendirme
                If kampOneri.Oncelik.Contains("YÜKSEK") Then
                    dgvUrunler.Rows(row).DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 238)
                ElseIf kampOneri.Oncelik.Contains("ORTA") Then
                    dgvUrunler.Rows(row).DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 224)
                End If
            Next
            
        Catch ex As Exception
            EticaretLogger.LogError("DisplayResults hatası", ex)
        End Try
    End Sub
    
    Private Sub UpdateSummary()
        Try
            If kampanyaVerileri.Count = 0 Then Return
            
            Dim toplam As Integer = kampanyaVerileri.Count
            Dim yuksek As Integer = 0
            Dim orta As Integer = 0
            Dim dusuk As Integer = 0
            Dim stokEritme As Integer = 0
            Dim potansiyelCiro As Decimal = 0
            
            For Each item As KampanyaOneri In kampanyaVerileri
                If item.Oncelik.Contains("YÜKSEK") Then yuksek += 1
                If item.Oncelik.Contains("ORTA") Then orta += 1
                If item.Oncelik.Contains("DÜŞÜK") Then dusuk += 1
                If item.KampanyaTipi.Contains("STOK ERİTME") Then stokEritme += 1
                potansiyelCiro += item.OneriFiyat * Math.Min(item.StokMiktari, 10)
            Next
            
            For Each ctrlObj As Object In pnlOzet.Controls(0).Controls
                If TypeOf ctrlObj Is Panel Then
                    Dim pnl As Panel = DirectCast(ctrlObj, Panel)
                    Dim tag As String = If(pnl.Tag IsNot Nothing, pnl.Tag.ToString(), "")
                    
                    For Each lblObj As Object In pnl.Controls
                        If TypeOf lblObj Is Label Then
                            Dim lbl As Label = DirectCast(lblObj, Label)
                            If lbl.Tag IsNot Nothing AndAlso lbl.Tag.ToString() = "value" Then
                                Select Case tag
                                    Case "toplam" : lbl.Text = toplam.ToString()
                                    Case "yuksek" : lbl.Text = yuksek.ToString()
                                    Case "orta" : lbl.Text = orta.ToString()
                                    Case "dusuk" : lbl.Text = dusuk.ToString()
                                    Case "stokeritme" : lbl.Text = stokEritme.ToString()
                                    Case "ciro" : lbl.Text = $"₺{potansiyelCiro:N0}"
                                End Select
                            End If
                        End If
                    Next
                End If
            Next
        Catch ex As Exception
            EticaretLogger.LogError("UpdateSummary hatası", ex)
        End Try
    End Sub
    
    Private Sub btnKampanyaOlustur_Click(sender As Object, e As EventArgs)
        Try
            ' Seçili satırları say
            Dim seciliSayisi As Integer = 0
            For Each row As DataGridViewRow In dgvUrunler.Rows
                If CBool(row.Cells("Sec").Value) = True Then
                    seciliSayisi += 1
                End If
            Next
            
            If seciliSayisi = 0 Then
                MessageBox.Show("Lütfen kampanya uygulanacak ürünleri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            
            Dim mesaj = $"{seciliSayisi} ürüne kampanya fiyatı uygulanacak." & vbCrLf & vbCrLf &
                       "Bu işlem Trendyol fiyatlarını güncelleyecektir." & vbCrLf &
                       "Devam etmek istiyor musunuz?"
            
            If MessageBox.Show(mesaj, "Kampanya Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                
                Dim guncellenen As Integer = 0
                
                Using conn As New OleDbConnection(connection)
                    conn.Open()
                    
                    For Each row As DataGridViewRow In dgvUrunler.Rows
                        If CBool(row.Cells("Sec").Value) = True Then
                            Dim nStokID As Integer = CInt(row.Cells("nStokID").Value)
                            Dim oneriFiyat As Decimal = CDec(row.Cells("OneriFiyat").Value)
                            
                            Try
                                Dim cmdUpdate As New OleDbCommand(
                                    "UPDATE tbStokFiyati SET lFiyat = ? WHERE nStokID = ? AND sFiyatTipi = 'WEBP'", conn)
                                cmdUpdate.Parameters.AddWithValue("?", oneriFiyat)
                                cmdUpdate.Parameters.AddWithValue("?", nStokID)
                                
                                If cmdUpdate.ExecuteNonQuery() > 0 Then
                                    guncellenen += 1
                                    EticaretLogger.LogInfo($"Kampanya fiyatı uygulandı: nStokID={nStokID}, Fiyat={oneriFiyat}")
                                End If
                            Catch updateEx As Exception
                                EticaretLogger.LogError($"Fiyat güncelleme hatası: nStokID={nStokID}", updateEx)
                            End Try
                        End If
                    Next
                End Using
                
                MessageBox.Show($"{guncellenen} ürüne kampanya fiyatı uygulandı." & vbCrLf & vbCrLf &
                               "Fiyatların pazaryerlerine yansıması için senkronizasyon yapın.",
                               "Kampanya Uygulandı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                
                EticaretLogger.LogInfo($"Toplu kampanya uygulandı: {guncellenen} ürün")
                
                ' Listeyi yenile
                btnAnaliz_Click(Nothing, Nothing)
            End If
            
        Catch ex As Exception
            EticaretLogger.LogError("Kampanya uygulama hatası", ex)
            MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

End Class
