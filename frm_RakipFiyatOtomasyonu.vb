' ============================================================================
' RAKİP FİYAT OTOMASYONU FORMU
' Dosya: frm_RakipFiyatOtomasyonu.vb
' Tarih: 2026-02-20
' Açıklama: Rakip fiyatlarını izler ve otomatik fiyat ayarlaması yapar
' ROADMAP.md Görevi: Rakip Fiyat Otomasyonu (P1)
' ============================================================================

Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

''' <summary>
''' Rakip fiyat izleme ve otomatik fiyat ayarlama formu
''' Trendyol'daki rakip fiyatlarını analiz eder ve öneriler sunar
''' </summary>
Public Class frm_RakipFiyatOtomasyonu
    Inherits Form

#Region "Değişkenler"
    Public connection As String = ""
    Private WithEvents dgvUrunler As DataGridView
    Private WithEvents dgvRakipler As DataGridView
    Private pnlFiltre As Panel
    Private pnlOzet As Panel
    Private lblOzet As Label
    Private btnTara As Button
    Private btnOtomatikAyarla As Button
    Private btnYenile As Button
    Private cmbKategori As ComboBox
    Private cmbPazaryeri As ComboBox
    Private numMinKar As NumericUpDown
    Private numMaxIndirim As NumericUpDown
    Private chkSadeceDusuklar As CheckBox
    Private lblDurum As Label
    Private progressBar As ProgressBar
    
    ' Rakip analiz sonuçları
    Private rakipAnalizleri As New Dictionary(Of Integer, RakipAnaliz)
    
    ' Rakip detayları (alt grid için)
    Private rakipDetaylari As New Dictionary(Of Integer, List(Of TrendyolCompetitor))
    
    ' Ayarlar
    Private minKarMarji As Decimal = 15D  ' Minimum kar marjı %
    Private maxIndirimOrani As Decimal = 30D ' Maximum indirim oranı %
#End Region

#Region "Veri Yapıları"
    ''' <summary>
    ''' Rakip analiz sonucu
    ''' </summary>
    Public Class RakipAnaliz
        Public Property nStokID As Integer
        Public Property StokKodu As String
        Public Property ModelKodu As String
        Public Property Barkod As String
        Public Property Renk As String
        Public Property Beden As String
        Public Property Kavala As String
        Public Property UrunAdi As String
        Public Property Kategori As String
        Public Property BizimFiyat As Decimal
        Public Property EnDusukRakip As Decimal
        Public Property OrtalmaRakip As Decimal
        Public Property RakipSayisi As Integer
        Public Property FiyatFarki As Decimal
        Public Property FarkYuzde As Decimal
        Public Property OneriFiyat As Decimal
        Public Property AlisFiyat As Decimal
        Public Property Stok As Integer
        Public Property Satis As Integer
        Public Property Durum As String
        Public Property AksiyonGerekli As Boolean
        Public Property Tavsiye As String
        Public Property SonGuncelleme As DateTime
    End Class
#End Region

#Region "Constructor ve Form Olayları"
    Public Sub New()
        InitializeComponent()
    End Sub
    
    Private Sub InitializeComponent()
        Me.Text = "🏷️ Rakip Fiyat Otomasyonu"
        Me.Size = New Size(1400, 900)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(245, 245, 250)
        
        ' Ana layout
        Dim tlp As New TableLayoutPanel()
        tlp.Dock = DockStyle.Fill
        tlp.RowCount = 4
        tlp.ColumnCount = 1
        tlp.RowStyles.Add(New RowStyle(SizeType.Absolute, 80))   ' Filtre
        tlp.RowStyles.Add(New RowStyle(SizeType.Absolute, 100))  ' Özet
        tlp.RowStyles.Add(New RowStyle(SizeType.Percent, 100))   ' Grid
        tlp.RowStyles.Add(New RowStyle(SizeType.Absolute, 35))   ' Status
        tlp.Padding = New Padding(10)
        Me.Controls.Add(tlp)
        
        ' Filtre paneli
        CreateFilterPanel(tlp)
        
        ' Özet paneli
        CreateSummaryPanel(tlp)
        
        ' Ana DataGrid - Split Container ile
        Dim splitContainer As New SplitContainer()
        splitContainer.Dock = DockStyle.Fill
        splitContainer.Orientation = Orientation.Horizontal
        splitContainer.SplitterDistance = 400
        tlp.Controls.Add(splitContainer, 0, 2)
        
        ' Ürünler Grid
        dgvUrunler = New DataGridView()
        ConfigureGrid(dgvUrunler, splitContainer.Panel1, "Ürünler")
        AddUrunlerColumns()
        
        ' Rakipler Grid
        dgvRakipler = New DataGridView()
        ConfigureGrid(dgvRakipler, splitContainer.Panel2, "Rakip Detayları")
        AddRakiplerColumns()
        
        ' Durum çubuğu
        Dim pnlStatus As New Panel()
        pnlStatus.Dock = DockStyle.Fill
        pnlStatus.BackColor = Color.FromArgb(50, 50, 60)
        tlp.Controls.Add(pnlStatus, 0, 3)
        
        lblDurum = New Label()
        lblDurum.Dock = DockStyle.Left
        lblDurum.ForeColor = Color.White
        lblDurum.AutoSize = True
        lblDurum.Padding = New Padding(5)
        lblDurum.Text = "Hazır. Rakip taraması başlatmak için 'Rakip Tara' butonuna tıklayın."
        pnlStatus.Controls.Add(lblDurum)
        
        progressBar = New ProgressBar()
        progressBar.Dock = DockStyle.Right
        progressBar.Width = 200
        progressBar.Style = ProgressBarStyle.Continuous
        pnlStatus.Controls.Add(progressBar)
    End Sub
    
    Private Sub CreateFilterPanel(tlp As TableLayoutPanel)
        pnlFiltre = New Panel()
        pnlFiltre.Dock = DockStyle.Fill
        pnlFiltre.BackColor = Color.White
        pnlFiltre.Padding = New Padding(10)
        tlp.Controls.Add(pnlFiltre, 0, 0)
        
        Dim flowPanel As New FlowLayoutPanel()
        flowPanel.Dock = DockStyle.Fill
        flowPanel.FlowDirection = FlowDirection.LeftToRight
        flowPanel.WrapContents = False
        pnlFiltre.Controls.Add(flowPanel)
        
        ' Kategori seçimi
        Dim lblKat As New Label()
        lblKat.Text = "Kategori:"
        lblKat.AutoSize = True
        lblKat.Margin = New Padding(0, 8, 5, 0)
        flowPanel.Controls.Add(lblKat)
        
        cmbKategori = New ComboBox()
        cmbKategori.Width = 200
        cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKategori.Items.Add("-- Tümü --")
        cmbKategori.SelectedIndex = 0
        flowPanel.Controls.Add(cmbKategori)
        
        ' Min kar marjı
        Dim lblMinKar As New Label()
        lblMinKar.Text = "Min Kar %:"
        lblMinKar.AutoSize = True
        lblMinKar.Margin = New Padding(20, 8, 5, 0)
        flowPanel.Controls.Add(lblMinKar)
        
        numMinKar = New NumericUpDown()
        numMinKar.Width = 60
        numMinKar.Minimum = 0
        numMinKar.Maximum = 100
        numMinKar.Value = 15
        numMinKar.DecimalPlaces = 0
        flowPanel.Controls.Add(numMinKar)
        
        ' Max indirim oranı
        Dim lblMaxInd As New Label()
        lblMaxInd.Text = "Max İndirim %:"
        lblMaxInd.AutoSize = True
        lblMaxInd.Margin = New Padding(20, 8, 5, 0)
        flowPanel.Controls.Add(lblMaxInd)
        
        numMaxIndirim = New NumericUpDown()
        numMaxIndirim.Width = 60
        numMaxIndirim.Minimum = 0
        numMaxIndirim.Maximum = 100
        numMaxIndirim.Value = 30
        numMaxIndirim.DecimalPlaces = 0
        flowPanel.Controls.Add(numMaxIndirim)
        
        ' Sadece pahalıları göster
        chkSadeceDusuklar = New CheckBox()
        chkSadeceDusuklar.Text = "Sadece pahalı olanlar"
        chkSadeceDusuklar.AutoSize = True
        chkSadeceDusuklar.Margin = New Padding(20, 8, 5, 0)
        flowPanel.Controls.Add(chkSadeceDusuklar)
        
        ' Pazaryeri secimi
        Dim lblPazaryeri As New Label()
        lblPazaryeri.Text = "Pazaryeri:"
        lblPazaryeri.AutoSize = True
        lblPazaryeri.Margin = New Padding(20, 8, 5, 0)
        flowPanel.Controls.Add(lblPazaryeri)
        
        cmbPazaryeri = New ComboBox()
        cmbPazaryeri.Width = 120
        cmbPazaryeri.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPazaryeri.Items.AddRange(New String() {"Tumu", "Trendyol", "Hepsiburada", "N11", "Amazon", "PttAVM", "Pazarama", "CicekSepeti", "Modanisa", "Farmazon", "Idefix", "LCWaikiki"})
        cmbPazaryeri.SelectedIndex = 0
        flowPanel.Controls.Add(cmbPazaryeri)
        
        ' Rakip Tara butonu
        btnTara = New Button()
        btnTara.Text = "🔍 Rakip Tara"
        btnTara.Width = 120
        btnTara.Height = 35
        btnTara.BackColor = Color.FromArgb(0, 150, 136)
        btnTara.ForeColor = Color.White
        btnTara.FlatStyle = FlatStyle.Flat
        btnTara.Margin = New Padding(30, 3, 5, 0)
        AddHandler btnTara.Click, AddressOf btnTara_Click
        flowPanel.Controls.Add(btnTara)
        
        ' Otomatik Ayarla butonu
        btnOtomatikAyarla = New Button()
        btnOtomatikAyarla.Text = "⚡ Otomatik Ayarla"
        btnOtomatikAyarla.Width = 140
        btnOtomatikAyarla.Height = 35
        btnOtomatikAyarla.BackColor = Color.FromArgb(244, 67, 54)
        btnOtomatikAyarla.ForeColor = Color.White
        btnOtomatikAyarla.FlatStyle = FlatStyle.Flat
        btnOtomatikAyarla.Margin = New Padding(10, 3, 5, 0)
        btnOtomatikAyarla.Enabled = False
        AddHandler btnOtomatikAyarla.Click, AddressOf btnOtomatikAyarla_Click
        flowPanel.Controls.Add(btnOtomatikAyarla)
        
        ' Yenile butonu
        btnYenile = New Button()
        btnYenile.Text = "🔄 Yenile"
        btnYenile.Width = 80
        btnYenile.Height = 35
        btnYenile.BackColor = Color.FromArgb(63, 81, 181)
        btnYenile.ForeColor = Color.White
        btnYenile.FlatStyle = FlatStyle.Flat
        btnYenile.Margin = New Padding(10, 3, 0, 0)
        AddHandler btnYenile.Click, AddressOf btnYenile_Click
        flowPanel.Controls.Add(btnYenile)
    End Sub
    
    Private Sub CreateSummaryPanel(tlp As TableLayoutPanel)
        pnlOzet = New Panel()
        pnlOzet.Dock = DockStyle.Fill
        pnlOzet.BackColor = Color.FromArgb(33, 33, 33)
        pnlOzet.Padding = New Padding(15)
        tlp.Controls.Add(pnlOzet, 0, 1)
        
        Dim flowOzet As New FlowLayoutPanel()
        flowOzet.Dock = DockStyle.Fill
        flowOzet.FlowDirection = FlowDirection.LeftToRight
        pnlOzet.Controls.Add(flowOzet)
        
        ' Özet kartları
        CreateSummaryCard(flowOzet, "📦 Toplam Ürün", "0", Color.FromArgb(63, 81, 181))
        CreateSummaryCard(flowOzet, "🔴 Pahalı", "0", Color.FromArgb(244, 67, 54))
        CreateSummaryCard(flowOzet, "🟢 Ucuz", "0", Color.FromArgb(76, 175, 80))
        CreateSummaryCard(flowOzet, "🟡 Normal", "0", Color.FromArgb(255, 193, 7))
        CreateSummaryCard(flowOzet, "💰 Potansiyel Kazanç", "₺0", Color.FromArgb(156, 39, 176))
    End Sub
    
    Private Sub CreateSummaryCard(parent As FlowLayoutPanel, title As String, value As String, color As Color)
        Dim pnl As New Panel()
        pnl.Size = New Size(200, 70)
        pnl.BackColor = color
        pnl.Margin = New Padding(5)
        pnl.Tag = title ' Tag ile kartı tanımla
        parent.Controls.Add(pnl)
        
        Dim lblTitle As New Label()
        lblTitle.Text = title
        lblTitle.ForeColor = Color.White
        lblTitle.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        lblTitle.Location = New Point(10, 8)
        lblTitle.AutoSize = True
        pnl.Controls.Add(lblTitle)
        
        Dim lblValue As New Label()
        lblValue.Text = value
        lblValue.ForeColor = Color.White
        lblValue.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblValue.Location = New Point(10, 32)
        lblValue.AutoSize = True
        lblValue.Tag = "value"
        pnl.Controls.Add(lblValue)
    End Sub
    
    Private Sub ConfigureGrid(grid As DataGridView, parent As Control, title As String)
        grid.Dock = DockStyle.Fill
        grid.BackgroundColor = Color.White
        grid.BorderStyle = BorderStyle.None
        grid.RowHeadersVisible = False
        grid.AllowUserToAddRows = False
        grid.AllowUserToDeleteRows = False
        grid.AllowUserToResizeColumns = True
        grid.AllowUserToOrderColumns = True
        grid.SelectionMode = DataGridViewSelectionMode.CellSelect
        grid.MultiSelect = True
        grid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 60)
        grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        grid.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        grid.ColumnHeadersHeight = 35
        grid.EnableHeadersVisualStyles = False
        grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 250)
        grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(63, 81, 181)
        grid.DefaultCellStyle.SelectionForeColor = Color.White
        grid.ReadOnly = True
        
        ' Cift tiklama ile hucre kopyalama
        AddHandler grid.CellDoubleClick, Sub(s, e)
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                Dim deger = grid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
                If deger IsNot Nothing Then
                    Clipboard.SetText(deger.ToString())
                End If
            End If
        End Sub
        
        ' Sag tik menusu
        Dim contextMenu As New ContextMenuStrip()
        
        Dim mnuHucreKopyala As New ToolStripMenuItem("Secili Hucreyi Kopyala")
        AddHandler mnuHucreKopyala.Click, Sub()
            If grid.CurrentCell IsNot Nothing AndAlso grid.CurrentCell.Value IsNot Nothing Then
                Clipboard.SetText(grid.CurrentCell.Value.ToString())
            End If
        End Sub
        contextMenu.Items.Add(mnuHucreKopyala)
        
        Dim mnuSatirKopyala As New ToolStripMenuItem("Secili Satiri Kopyala")
        AddHandler mnuSatirKopyala.Click, Sub()
            If grid.CurrentRow IsNot Nothing Then
                Dim satirVerisi As New List(Of String)
                For Each cell As DataGridViewCell In grid.CurrentRow.Cells
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
        AddHandler mnuTumunuKopyala.Click, Sub() KopyalaTumVeriler(grid)
        contextMenu.Items.Add(mnuTumunuKopyala)
        
        contextMenu.Items.Add(New ToolStripSeparator())
        
        Dim mnuGorunumDuzenle As New ToolStripMenuItem("Gorunum Duzenle...")
        AddHandler mnuGorunumDuzenle.Click, Sub() GorunumDuzenle(grid)
        contextMenu.Items.Add(mnuGorunumDuzenle)
        
        Dim mnuGorunumKaydet As New ToolStripMenuItem("Gorunumu Kaydet")
        AddHandler mnuGorunumKaydet.Click, Sub() GorunumKaydet(grid)
        contextMenu.Items.Add(mnuGorunumKaydet)
        
        grid.ContextMenuStrip = contextMenu
        parent.Controls.Add(grid)
    End Sub
    
    Private Sub KopyalaTumVeriler(grid As DataGridView)
        Try
            grid.SelectAll()
            Dim data = grid.GetClipboardContent()
            If data IsNot Nothing Then
                Clipboard.SetDataObject(data)
                MessageBox.Show("Tum veriler panoya kopyalandi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Kopyalama hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub GorunumDuzenle(grid As DataGridView)
        Using frm As New frmGorunumDuzenle(grid)
            frm.ShowDialog()
        End Using
    End Sub
    
    Private Sub GorunumKaydet(grid As DataGridView)
        Try
            Dim ayarlar As New List(Of String)
            For Each col As DataGridViewColumn In grid.Columns
                ayarlar.Add($"{col.Name}|{col.Visible}|{col.Width}|{col.DisplayIndex}")
            Next
            
            Dim dosyaAdi As String = $"C:\eticaret\gorunum_{Me.Name}_{grid.Name}.txt"
            System.IO.File.WriteAllLines(dosyaAdi, ayarlar)
            MessageBox.Show("Gorunum kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Kaydetme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub GorunumYukle(grid As DataGridView)
        Try
            Dim dosyaAdi As String = $"C:\eticaret\gorunum_{Me.Name}_{grid.Name}.txt"
            If System.IO.File.Exists(dosyaAdi) Then
                Dim satirlar = System.IO.File.ReadAllLines(dosyaAdi)
                For Each satir As String In satirlar
                    Dim parcalar = satir.Split("|"c)
                    If parcalar.Length >= 4 AndAlso grid.Columns.Contains(parcalar(0)) Then
                        Dim col = grid.Columns(parcalar(0))
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
    
    Private Sub AddUrunlerColumns()
        dgvUrunler.Columns.Add("nStokID", "ID")
        dgvUrunler.Columns("nStokID").Width = 50
        dgvUrunler.Columns("nStokID").Visible = False
        
        dgvUrunler.Columns.Add("StokKodu", "Stok Kodu")
        dgvUrunler.Columns("StokKodu").Width = 90
        
        dgvUrunler.Columns.Add("ModelKodu", "Model")
        dgvUrunler.Columns("ModelKodu").Width = 80
        
        dgvUrunler.Columns.Add("Barkod", "Barkod")
        dgvUrunler.Columns("Barkod").Width = 100
        
        dgvUrunler.Columns.Add("sAciklama", "Urun Adi")
        dgvUrunler.Columns("sAciklama").Width = 200
        
        dgvUrunler.Columns.Add("Renk", "Renk")
        dgvUrunler.Columns("Renk").Width = 70
        
        dgvUrunler.Columns.Add("Beden", "Beden")
        dgvUrunler.Columns("Beden").Width = 60
        
        dgvUrunler.Columns.Add("Kavala", "Kavala")
        dgvUrunler.Columns("Kavala").Width = 70
        
        dgvUrunler.Columns.Add("BizimFiyat", "Bizim Fiyat")
        dgvUrunler.Columns("BizimFiyat").DefaultCellStyle.Format = "#,##0.00 TL"
        dgvUrunler.Columns("BizimFiyat").Width = 90
        
        dgvUrunler.Columns.Add("EnDusukRakip", "En Dusuk Rakip")
        dgvUrunler.Columns("EnDusukRakip").DefaultCellStyle.Format = "#,##0.00 TL"
        dgvUrunler.Columns("EnDusukRakip").Width = 100
        
        dgvUrunler.Columns.Add("FarkYuzde", "Fark %")
        dgvUrunler.Columns("FarkYuzde").DefaultCellStyle.Format = "#0.0'%'"
        dgvUrunler.Columns("FarkYuzde").Width = 60
        
        dgvUrunler.Columns.Add("RakipSayisi", "Rakip")
        dgvUrunler.Columns("RakipSayisi").Width = 50
        
        dgvUrunler.Columns.Add("Durum", "Durum")
        dgvUrunler.Columns("Durum").Width = 70
        
        dgvUrunler.Columns.Add("OneriFiyat", "Oneri Fiyat")
        dgvUrunler.Columns("OneriFiyat").DefaultCellStyle.Format = "#,##0.00 TL"
        dgvUrunler.Columns("OneriFiyat").Width = 90
        
        dgvUrunler.Columns.Add("Tavsiye", "Tavsiye")
        dgvUrunler.Columns("Tavsiye").Width = 150
    End Sub
    
    Private Sub AddRakiplerColumns()
        dgvRakipler.Columns.Add("SiraNo", "#")
        dgvRakipler.Columns("SiraNo").Width = 40
        
        dgvRakipler.Columns.Add("MagazaAdi", "Mağaza")
        dgvRakipler.Columns("MagazaAdi").FillWeight = 25
        
        dgvRakipler.Columns.Add("Fiyat", "Fiyat")
        dgvRakipler.Columns("Fiyat").DefaultCellStyle.Format = "₺#,##0.00"
        dgvRakipler.Columns("Fiyat").FillWeight = 15
        
        dgvRakipler.Columns.Add("KargoUcreti", "Kargo")
        dgvRakipler.Columns("KargoUcreti").DefaultCellStyle.Format = "₺#,##0.00"
        dgvRakipler.Columns("KargoUcreti").FillWeight = 10
        
        dgvRakipler.Columns.Add("ToplamFiyat", "Toplam")
        dgvRakipler.Columns("ToplamFiyat").DefaultCellStyle.Format = "₺#,##0.00"
        dgvRakipler.Columns("ToplamFiyat").FillWeight = 15
        
        dgvRakipler.Columns.Add("Puan", "Puan")
        dgvRakipler.Columns("Puan").FillWeight = 8
        
        dgvRakipler.Columns.Add("YorumSayisi", "Yorum")
        dgvRakipler.Columns("YorumSayisi").FillWeight = 8
        
        dgvRakipler.Columns.Add("Stok", "Stok")
        dgvRakipler.Columns("Stok").FillWeight = 8
        
        dgvRakipler.Columns.Add("FiyatFarki", "Fark")
        dgvRakipler.Columns("FiyatFarki").FillWeight = 11
    End Sub
    
    Private Sub frm_RakipFiyatOtomasyonu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            EticaretLogger.LogInfo("Rakip Fiyat Otomasyonu formu yükleniyor...")
            
            ' Connection string kontrolu - bos ise global KeyCode'dan al
            If String.IsNullOrEmpty(connection) Then
                connection = KeyCode.connection
            End If
            
            LoadKategoriler()
            
            ' Kaydedilmis gorunumu yukle
            GorunumYukle(dgvUrunler)
            
            EticaretLogger.LogInfo("Rakip Fiyat Otomasyonu formu yüklendi.")
        Catch ex As Exception
            EticaretLogger.LogError("Rakip Fiyat formu yükleme hatası", ex)
        End Try
    End Sub
#End Region

#Region "Veri İşlemleri"
    Private Sub LoadKategoriler()
        Try
            cmbKategori.Items.Clear()
            cmbKategori.Items.Add("-- Tümü --")
            
            Using conn As New OleDbConnection(connection)
                conn.Open()
                Dim cmd As New OleDbCommand(
                    "SELECT DISTINCT sAciklama FROM tbSSinif4 ORDER BY sAciklama", conn)
                Using reader = cmd.ExecuteReader()
                    While reader.Read()
                        If Not IsDBNull(reader("sAciklama")) Then
                            cmbKategori.Items.Add(reader("sAciklama").ToString())
                        End If
                    End While
                End Using
            End Using
            
            cmbKategori.SelectedIndex = 0
        Catch ex As Exception
            EticaretLogger.LogError("Kategori yükleme hatası", ex)
        End Try
    End Sub
    
    Private Async Sub btnTara_Click(sender As Object, e As EventArgs)
        Try
            btnTara.Enabled = False
            btnOtomatikAyarla.Enabled = False
            progressBar.Value = 0
            lblDurum.Text = "Rakip taraması başlatılıyor..."
            dgvUrunler.Rows.Clear()
            dgvRakipler.Rows.Clear()
            rakipAnalizleri.Clear()
            rakipDetaylari.Clear()
            
            minKarMarji = numMinKar.Value
            maxIndirimOrani = numMaxIndirim.Value
            
            EticaretLogger.LogInfo($"Rakip taraması başlatıldı. MinKar={minKarMarji}%, MaxIndirim={maxIndirimOrani}%")
            
            ' Merkezi cache'den ürünleri al ve analiz et
            Await Task.Run(Sub() AnalyzeProductsFromCache())
            
            ' Sonuçları göster
            DisplayResults()
            
            Dim aksiyonGerekliVar As Boolean = False
            For Each analizItem As RakipAnaliz In rakipAnalizleri.Values
                If analizItem.AksiyonGerekli Then
                    aksiyonGerekliVar = True
                    Exit For
                End If
            Next
            
            btnOtomatikAyarla.Enabled = aksiyonGerekliVar
            lblDurum.Text = $"Tarama tamamlandı. {rakipAnalizleri.Count} ürün analiz edildi."
            
            EticaretLogger.LogInfo($"Rakip taraması tamamlandı. {rakipAnalizleri.Count} ürün analiz edildi.")
            
        Catch ex As Exception
            EticaretLogger.LogError("Rakip tarama hatası", ex)
            MessageBox.Show($"Tarama hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnTara.Enabled = True
            progressBar.Value = 100
        End Try
    End Sub
    
    ''' <summary>
    ''' Merkezi cache sisteminden rakip fiyat verilerini yükler
    ''' </summary>
    Private Sub AnalyzeProductsFromCache()
        Try
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                Dim pazaryeri As String = ""
                Dim kategori As String = ""
                
                Me.Invoke(Sub()
                    pazaryeri = If(cmbPazaryeri IsNot Nothing AndAlso cmbPazaryeri.SelectedIndex >= 0, cmbPazaryeri.Text, "Tümü")
                    lblDurum.Text = "Veritabanına bağlanılıyor..."
                End Sub)
                
                EticaretLogger.LogInfo($"AnalyzeProductsFromCache başlatıldı. Pazaryeri={pazaryeri}")
                
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
                        lblDurum.Text = "Cache boş veya veri bulunamadı. Log dosyasını kontrol edin."
                        MessageBox.Show("Cache'den veri alınamadı. Lütfen C:\eticaret\log klasöründeki log dosyasını kontrol edin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Sub)
                    Return
                End If
                
                ' Cache verisini Rakip modeline dönüştür
                Me.Invoke(Sub() lblDurum.Text = $"Analiz ediliyor: 0/{cacheData.Count}")
                
                Dim sayac As Integer = 0
                Dim taramaSayisi As Integer = 0
                Dim maxTarama As Integer = 50 ' Cloudflare engeline takılmamak için limit
                
                For Each cacheItem As ETicaretAnalizData In cacheData
                    sayac += 1
                    
                    If sayac Mod 50 = 0 Then
                        Me.Invoke(Sub()
                            progressBar.Value = CInt((sayac / cacheData.Count) * 100)
                            lblDurum.Text = $"İşleniyor: {sayac}/{cacheData.Count} (Taranan: {taramaSayisi})"
                        End Sub)
                    End If
                    
                    Dim rakipAnaliz As New RakipAnaliz()
                    rakipAnaliz.nStokID = cacheItem.nStokID
                    rakipAnaliz.StokKodu = cacheItem.StokKodu
                    rakipAnaliz.ModelKodu = cacheItem.Model
                    rakipAnaliz.Barkod = cacheItem.Barkod
                    rakipAnaliz.Renk = cacheItem.Renk
                    rakipAnaliz.Beden = cacheItem.Beden
                    rakipAnaliz.Kavala = ""
                    rakipAnaliz.UrunAdi = cacheItem.UrunAdi
                    rakipAnaliz.Kategori = cacheItem.Kategori
                    
                    ' Cache'den gelen fiyat verileri
                    rakipAnaliz.BizimFiyat = cacheItem.BizimFiyat
                    
                    ' Trendyol'dan rakip fiyatlarını çek (limit dahilinde)
                    If taramaSayisi < maxTarama AndAlso Not String.IsNullOrEmpty(cacheItem.Barkod) Then
                        Try
                            Me.Invoke(Sub() lblDurum.Text = $"Trendyol taranıyor: {cacheItem.Barkod}")
                            
                            Dim rakipSonuc As RakipTaramaSonuc = TrendyolWebScraperService.GetRakipFiyatlari(cacheItem.Barkod, cacheItem.UrunAdi)
                            taramaSayisi += 1
                            
                            If rakipSonuc.Basarili AndAlso rakipSonuc.RakipSayisi > 0 Then
                                rakipAnaliz.EnDusukRakip = rakipSonuc.EnDusukFiyat
                                rakipAnaliz.OrtalmaRakip = rakipSonuc.OrtalamaFiyat
                                rakipAnaliz.RakipSayisi = rakipSonuc.RakipSayisi
                                
                                ' Fark hesapla
                                If rakipAnaliz.BizimFiyat > 0 AndAlso rakipSonuc.EnDusukFiyat > 0 Then
                                    rakipAnaliz.FiyatFarki = rakipAnaliz.BizimFiyat - rakipSonuc.EnDusukFiyat
                                    rakipAnaliz.FarkYuzde = ((rakipAnaliz.BizimFiyat - rakipSonuc.EnDusukFiyat) / rakipSonuc.EnDusukFiyat) * 100
                                End If
                                
                                EticaretLogger.LogInfo($"Rakip bulundu: {cacheItem.Barkod} - EnDusuk: {rakipSonuc.EnDusukFiyat:N2} TL, Rakip: {rakipSonuc.RakipSayisi}")
                            Else
                                EticaretLogger.LogInfo($"Rakip bulunamadı: {cacheItem.Barkod} - {rakipSonuc.HataMesaji}")
                            End If
                            
                            ' Rate limiting - Cloudflare'a takılmamak için
                            Threading.Thread.Sleep(500)
                            
                        Catch ex As Exception
                            EticaretLogger.LogError($"Rakip tarama hatası: {cacheItem.Barkod}", ex)
                        End Try
                    Else
                        ' Cache'den gelen veriler (varsa)
                        rakipAnaliz.EnDusukRakip = cacheItem.EnDusukRakipFiyat
                        rakipAnaliz.OrtalmaRakip = cacheItem.OrtalamaRakipFiyat
                        rakipAnaliz.RakipSayisi = cacheItem.RakipSayisi
                        rakipAnaliz.FiyatFarki = cacheItem.FiyatFarki
                        rakipAnaliz.FarkYuzde = cacheItem.FiyatFarkYuzde
                    End If
                    
                    ' Satış verileri
                    rakipAnaliz.Stok = cacheItem.StokMiktari
                    rakipAnaliz.Satis = cacheItem.Satis30Gun
                    
                    ' Durum ve öneri hesapla
                    CalculateRecommendation(rakipAnaliz)
                    
                    rakipAnalizleri.Add(rakipAnaliz.nStokID, rakipAnaliz)
                Next
                
                EticaretLogger.LogInfo($"Rakip analizi tamamlandı: {rakipAnalizleri.Count} ürün, {taramaSayisi} Trendyol taraması")
            End Using
        Catch ex As Exception
            EticaretLogger.LogError("AnalyzeProductsFromCache hatası", ex)
            Me.Invoke(Sub()
                lblDurum.Text = $"HATA: {ex.Message}"
                MessageBox.Show($"Analiz hatası: {ex.Message}" & vbCrLf & vbCrLf & "Detaylar için C:\eticaret\log klasörünü kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Sub)
        End Try
    End Sub
    
    ' Eski fonksiyon - artık kullanılmıyor, cache sistemi kullanılıyor
    Private Sub AnalyzeProducts_OLD()
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
                
                ' Gercek satis ve stok verileri ile birlikte urün bilgilerini cek
                Dim sql As String = "SELECT " &
                    "s.nStokID, s.sKodu AS sStokKodu, s.sModel, " &
                    "ISNULL((SELECT TOP 1 b.sBarkod FROM tbStokBarkodu b WHERE b.nStokID = s.nStokID), '') AS sBarkod, " &
                    "ISNULL(s.sRenk, '') AS sRenk, ISNULL(s.sBeden, '') AS sBeden, ISNULL(s.sKavala, '') AS sKavala, s.sAciklama, " &
                    "ISNULL((SELECT TOP 1 f.lFiyat FROM tbStokFiyati f WHERE f.nStokID = s.nStokID AND f.sFiyatTipi = '" & fiyatTipi & "' ORDER BY f.dteFiyatTespitTarihi DESC), 0) AS SatisFiyat, " &
                    "ISNULL((SELECT TOP 1 f.lFiyat FROM tbStokFiyati f WHERE f.nStokID = s.nStokID AND f.sFiyatTipi = 'A' ORDER BY f.dteFiyatTespitTarihi DESC), 0) AS AlisFiyat, " &
                    "(SELECT sAciklama FROM tbSSinif4 WHERE sSinifKodu=si.sSinifKodu4) AS Kategori, " &
                    "ISNULL((SELECT SUM(d.lGirisMiktar1 - d.lCikisMiktar1) FROM tbStokFisiDetayi d WHERE d.nStokID = s.nStokID), 0) AS Stok, " &
                    "ISNULL((SELECT SUM(d.lCikisMiktar1) FROM tbStokFisiDetayi d " &
                    "  INNER JOIN tbStokFisiMaster m ON d.nStokFisiID = m.nStokFisiID " &
                    "  LEFT JOIN tbStokFisiAciklamasi a ON m.nStokFisiID = a.nStokFisiID " &
                    "  WHERE d.nStokID = s.nStokID AND m.sFisTipi = 'FS ' AND d.lCikisMiktar1 > 0 " &
                    "  AND m.dteFisTarihi >= DATEADD(day, -30, GETDATE()) " & pazaryeriWhere & "), 0) AS Son30GunSatis " &
                    "FROM tbStok s " &
                    "LEFT JOIN tbStokSinifi si ON si.nStokID = s.nStokID " &
                    "WHERE s.bWebGoruntule = 1 AND s.nStokTipi < 5 "
                
                ' Kategori filtresi
                If cmbKategori.SelectedIndex > 0 Then
                    sql &= " AND (SELECT sAciklama FROM tbSSinif4 WHERE sSinifKodu=si.sSinifKodu4) = ?"
                End If
                
                sql &= " ORDER BY s.nStokID DESC"
                
                EticaretLogger.LogDatabase("SELECT", "tbStok, tbStokFiyati, tbStokFisiDetayi", 0, sql)
                
                Dim cmd As New OleDbCommand(sql, conn)
                cmd.CommandTimeout = 120
                
                If cmbKategori.SelectedIndex > 0 Then
                    cmd.Parameters.AddWithValue("?", cmbKategori.SelectedItem.ToString())
                End If
                
                Using reader = cmd.ExecuteReader()
                    Dim sayac As Integer = 0
                    
                    While reader.Read()
                        sayac += 1
                        
                        ' Progress guncelle
                        If sayac Mod 50 = 0 Then
                            Me.Invoke(Sub()
                                progressBar.Value = Math.Min(sayac, 100)
                                lblDurum.Text = $"Analiz ediliyor: {sayac} ürün..."
                            End Sub)
                        End If
                        
                        Dim rakipAnaliz As New RakipAnaliz()
                        rakipAnaliz.nStokID = CInt(reader("nStokID"))
                        rakipAnaliz.StokKodu = If(IsDBNull(reader("sStokKodu")), "", reader("sStokKodu").ToString())
                        rakipAnaliz.ModelKodu = If(IsDBNull(reader("sModel")), "", reader("sModel").ToString())
                        rakipAnaliz.Barkod = If(IsDBNull(reader("sBarkod")), "", reader("sBarkod").ToString())
                        rakipAnaliz.Renk = If(IsDBNull(reader("sRenk")), "", reader("sRenk").ToString())
                        rakipAnaliz.Beden = If(IsDBNull(reader("sBeden")), "", reader("sBeden").ToString())
                        rakipAnaliz.Kavala = If(IsDBNull(reader("sKavala")), "", reader("sKavala").ToString())
                        rakipAnaliz.UrunAdi = If(IsDBNull(reader("sAciklama")), "", reader("sAciklama").ToString())
                        rakipAnaliz.BizimFiyat = If(IsDBNull(reader("SatisFiyat")), 0D, CDec(reader("SatisFiyat")))
                        rakipAnaliz.AlisFiyat = If(IsDBNull(reader("AlisFiyat")), 0D, CDec(reader("AlisFiyat")))
                        rakipAnaliz.SonGuncelleme = DateTime.Now
                        
                        ' Gercek stok ve satis verisi
                        Dim stok As Integer = If(IsDBNull(reader("Stok")), 0, CInt(reader("Stok")))
                        Dim satis As Integer = If(IsDBNull(reader("Son30GunSatis")), 0, CInt(reader("Son30GunSatis")))
                        
                        ' NOT: Rakip fiyatlari icin Trendyol/Hepsiburada API entegrasyonu gerekli
                        ' Su an satisa dayali tahmin yapiyoruz
                        SimulateRakipAnaliz(rakipAnaliz, stok, satis)
                        
                        ' Oneri hesapla
                        CalculateRecommendation(rakipAnaliz)
                        
                        rakipAnalizleri(rakipAnaliz.nStokID) = rakipAnaliz
                    End While
                    
                    EticaretLogger.LogInfo($"Rakip analizi tamamlandi: {sayac} urun")
                End Using
                
            End Using
        Catch ex As Exception
            EticaretLogger.LogError("AnalyzeProducts hatası", ex)
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
    
    Private Sub SimulateRakipAnaliz(analiz As RakipAnaliz, stok As Integer, satis As Integer)
        ' Gercek rakip fiyatlari web scraping ile Trendyol'dan cekilir
        Try
            If String.IsNullOrEmpty(analiz.Barkod) OrElse analiz.Barkod.Length < 8 Then
                ' Barkod yoksa veya geçersizse atla
                analiz.RakipSayisi = 0
                analiz.EnDusukRakip = 0
                analiz.OrtalmaRakip = 0
                analiz.FiyatFarki = 0
                analiz.FarkYuzde = 0
                Return
            End If
            
            ' Trendyol'dan rakip bilgilerini çek
            Dim rakipResult As TrendyolCompetitorResult = PazaryeriAPIHelper.GetTrendyolCompetitors(analiz.Barkod)
            
            If rakipResult.Success AndAlso rakipResult.Competitors.Count > 0 Then
                ' Bizim mağazamızı çıkar (varsa)
                Dim bizimMagaza As String = "furkan" ' Kendi mağaza adınız
                Dim rakipler = rakipResult.Competitors.FindAll(Function(x) Not x.MerchantName.ToLower().Contains(bizimMagaza.ToLower()))
                
                If rakipler.Count > 0 Then
                    ' En düşük rakip fiyatı
                    analiz.EnDusukRakip = rakipler.Min(Function(x) If(x.DiscountedPrice > 0, x.DiscountedPrice, Decimal.MaxValue))
                    If analiz.EnDusukRakip = Decimal.MaxValue Then analiz.EnDusukRakip = 0
                    
                    ' Ortalama rakip fiyatı
                    Dim validPrices = rakipler.FindAll(Function(x) x.DiscountedPrice > 0)
                    If validPrices.Count > 0 Then
                        analiz.OrtalmaRakip = CDec(validPrices.Average(Function(x) x.DiscountedPrice))
                    Else
                        analiz.OrtalmaRakip = 0
                    End If
                    
                    ' Rakip sayısı
                    analiz.RakipSayisi = rakipler.Count
                    
                    ' Fiyat farkı hesapla
                    If analiz.EnDusukRakip > 0 AndAlso analiz.BizimFiyat > 0 Then
                        analiz.FiyatFarki = analiz.BizimFiyat - analiz.EnDusukRakip
                        analiz.FarkYuzde = Math.Round((analiz.FiyatFarki / analiz.EnDusukRakip) * 100, 2)
                    Else
                        analiz.FiyatFarki = 0
                        analiz.FarkYuzde = 0
                    End If
                    
                    ' Rakip detaylarını sakla (alt grid için)
                    If Not rakipDetaylari.ContainsKey(analiz.nStokID) Then
                        rakipDetaylari.Add(analiz.nStokID, rakipler)
                    Else
                        rakipDetaylari(analiz.nStokID) = rakipler
                    End If
                Else
                    ' Sadece biz satıyoruz
                    analiz.RakipSayisi = 0
                    analiz.EnDusukRakip = 0
                    analiz.OrtalmaRakip = 0
                    analiz.FiyatFarki = 0
                    analiz.FarkYuzde = 0
                End If
            Else
                ' Ürün Trendyol'da bulunamadı
                analiz.RakipSayisi = 0
                analiz.EnDusukRakip = 0
                analiz.OrtalmaRakip = 0
                analiz.FiyatFarki = 0
                analiz.FarkYuzde = 0
            End If
            
        Catch ex As Exception
            EticaretLogger.LogError($"SimulateRakipAnaliz hatası: Barkod={analiz.Barkod}", ex)
            analiz.RakipSayisi = 0
            analiz.EnDusukRakip = 0
            analiz.OrtalmaRakip = 0
            analiz.FiyatFarki = 0
            analiz.FarkYuzde = 0
        End Try
    End Sub
    
    Private Sub CalculateRecommendation(analiz As RakipAnaliz)
        Try
            ' Durum belirleme
            If analiz.FarkYuzde > 5 Then
                analiz.Durum = "🔴 PAHALI"
                analiz.AksiyonGerekli = True
            ElseIf analiz.FarkYuzde < -5 Then
                analiz.Durum = "🟢 UCUZ"
                analiz.AksiyonGerekli = False
            Else
                analiz.Durum = "🟡 NORMAL"
                analiz.AksiyonGerekli = False
            End If
            
            ' Öneri fiyat hesapla
            If analiz.AksiyonGerekli AndAlso analiz.EnDusukRakip > 0 Then
                ' En düşük rakibin %2 altına in (ama kar marjını koru)
                Dim hedefFiyat As Decimal = analiz.EnDusukRakip * 0.98D
                
                ' Minimum kar marjı kontrolü
                Dim minFiyat As Decimal = analiz.AlisFiyat * (1 + minKarMarji / 100)
                
                ' Maximum indirim kontrolü
                Dim maxIndirimFiyat As Decimal = analiz.BizimFiyat * (1 - maxIndirimOrani / 100)
                
                ' En uygun fiyatı seç
                analiz.OneriFiyat = Math.Max(hedefFiyat, Math.Max(minFiyat, maxIndirimFiyat))
                analiz.OneriFiyat = Math.Round(analiz.OneriFiyat, 2)
                
                ' Tavsiye oluştur
                If analiz.OneriFiyat < analiz.BizimFiyat Then
                    Dim indirimOrani = Math.Round(((analiz.BizimFiyat - analiz.OneriFiyat) / analiz.BizimFiyat) * 100, 1)
                    analiz.Tavsiye = $"Fiyatı ₺{analiz.OneriFiyat:N2}'ye düşür (%{indirimOrani} indirim)"
                Else
                    analiz.Tavsiye = "Fiyat değişikliği önerilmez (kar marjı yetersiz)"
                    analiz.AksiyonGerekli = False
                End If
            Else
                analiz.OneriFiyat = analiz.BizimFiyat
                analiz.Tavsiye = If(analiz.Durum.Contains("UCUZ"), "Fiyat artışı değerlendirilebilir", "Fiyat uygun")
            End If
            
        Catch ex As Exception
            EticaretLogger.LogError($"CalculateRecommendation hatası: nStokID={analiz.nStokID}", ex)
        End Try
    End Sub
    
    Private Sub DisplayResults()
        Try
            dgvUrunler.Rows.Clear()
            
            Dim filteredResults As New List(Of RakipAnaliz)
            For Each item As RakipAnaliz In rakipAnalizleri.Values
                filteredResults.Add(item)
            Next
            
            ' Filtre uygula
            If chkSadeceDusuklar.Checked Then
                Dim tempList As New List(Of RakipAnaliz)
                For Each item As RakipAnaliz In filteredResults
                    If item.AksiyonGerekli Then
                        tempList.Add(item)
                    End If
                Next
                filteredResults = tempList
            End If
            
            ' Sıralama
            filteredResults.Sort(Function(x, y) y.FarkYuzde.CompareTo(x.FarkYuzde))
            
            For Each rakipAnaliz As RakipAnaliz In filteredResults
                Dim rowIndex = dgvUrunler.Rows.Add()
                Dim row = dgvUrunler.Rows(rowIndex)
                
                row.Cells("nStokID").Value = rakipAnaliz.nStokID
                row.Cells("StokKodu").Value = rakipAnaliz.StokKodu
                row.Cells("ModelKodu").Value = rakipAnaliz.ModelKodu
                row.Cells("Barkod").Value = rakipAnaliz.Barkod
                row.Cells("sAciklama").Value = rakipAnaliz.UrunAdi
                row.Cells("Renk").Value = rakipAnaliz.Renk
                row.Cells("Beden").Value = rakipAnaliz.Beden
                row.Cells("Kavala").Value = rakipAnaliz.Kavala
                row.Cells("BizimFiyat").Value = rakipAnaliz.BizimFiyat
                row.Cells("EnDusukRakip").Value = rakipAnaliz.EnDusukRakip
                row.Cells("FarkYuzde").Value = rakipAnaliz.FarkYuzde
                row.Cells("RakipSayisi").Value = rakipAnaliz.RakipSayisi
                row.Cells("Durum").Value = rakipAnaliz.Durum
                row.Cells("OneriFiyat").Value = rakipAnaliz.OneriFiyat
                row.Cells("Tavsiye").Value = rakipAnaliz.Tavsiye
                
                ' Renklendirme
                If rakipAnaliz.Durum.Contains("PAHALI") Then
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 238)
                ElseIf rakipAnaliz.Durum.Contains("UCUZ") Then
                    row.DefaultCellStyle.BackColor = Color.FromArgb(232, 245, 233)
                End If
            Next
            
            ' Özet güncelle
            UpdateSummary()
            
        Catch ex As Exception
            EticaretLogger.LogError("DisplayResults hatası", ex)
        End Try
    End Sub
    
    Private Sub UpdateSummary()
        Try
            Dim toplam As Integer = rakipAnalizleri.Count
            Dim pahali As Integer = 0
            Dim ucuz As Integer = 0
            Dim normal As Integer = 0
            Dim potansiyelKazanc As Decimal = 0
            
            For Each item As RakipAnaliz In rakipAnalizleri.Values
                If item.Durum.Contains("PAHALI") Then pahali += 1
                If item.Durum.Contains("UCUZ") Then ucuz += 1
                If item.Durum.Contains("NORMAL") Then normal += 1
                If item.Durum.Contains("UCUZ") Then
                    potansiyelKazanc += Math.Abs(item.FiyatFarki) * 0.5D
                End If
            Next
            
            ' Kartları güncelle
            For Each ctrlObj As Object In pnlOzet.Controls(0).Controls
                If TypeOf ctrlObj Is Panel Then
                    Dim pnl As Panel = DirectCast(ctrlObj, Panel)
                    Dim tag As String = If(pnl.Tag IsNot Nothing, pnl.Tag.ToString(), "")
                    
                    For Each lblObj As Object In pnl.Controls
                        If TypeOf lblObj Is Label Then
                            Dim lbl As Label = DirectCast(lblObj, Label)
                            If lbl.Tag IsNot Nothing AndAlso lbl.Tag.ToString() = "value" Then
                                Select Case tag
                                    Case "📦 Toplam Ürün" : lbl.Text = toplam.ToString()
                                    Case "🔴 Pahalı" : lbl.Text = pahali.ToString()
                                    Case "🟢 Ucuz" : lbl.Text = ucuz.ToString()
                                    Case "🟡 Normal" : lbl.Text = normal.ToString()
                                    Case "💰 Potansiyel Kazanç" : lbl.Text = $"₺{potansiyelKazanc:N0}"
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
    
    Private Sub btnOtomatikAyarla_Click(sender As Object, e As EventArgs)
        Try
            Dim aksiyonGerekli As New List(Of RakipAnaliz)
            For Each item As RakipAnaliz In rakipAnalizleri.Values
                If item.AksiyonGerekli Then
                    aksiyonGerekli.Add(item)
                End If
            Next
            
            If aksiyonGerekli.Count = 0 Then
                MessageBox.Show("Fiyat değişikliği gereken ürün bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            
            Dim mesaj As String = $"{aksiyonGerekli.Count} ürünün fiyatı otomatik olarak ayarlanacak." & vbCrLf & vbCrLf &
                                 $"Min Kar Marjı: %{minKarMarji}" & vbCrLf &
                                 $"Max İndirim: %{maxIndirimOrani}" & vbCrLf & vbCrLf &
                                 "Devam etmek istiyor musunuz?"
            
            If MessageBox.Show(mesaj, "Fiyat Ayarlama Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                
                EticaretLogger.LogInfo($"Otomatik fiyat ayarlama başlatıldı. {aksiyonGerekli.Count} ürün")
                
                Dim guncellenen As Integer = 0
                
                Using conn As New OleDbConnection(connection)
                    conn.Open()
                    
                    For Each rakipAnaliz As RakipAnaliz In aksiyonGerekli
                        Try
                            ' Trendyol fiyatını güncelle (sFiyatTipi='2')
                            Dim cmdUpdate As New OleDbCommand(
                                "UPDATE tbStokFiyati SET lFiyat = ? WHERE nStokID = ? AND sFiyatTipi = 'WEBP'", conn)
                            cmdUpdate.Parameters.AddWithValue("?", rakipAnaliz.OneriFiyat)
                            cmdUpdate.Parameters.AddWithValue("?", rakipAnaliz.nStokID)
                            
                            Dim affected = cmdUpdate.ExecuteNonQuery()
                            If affected > 0 Then
                                guncellenen += 1
                                EticaretLogger.LogInfo($"Fiyat güncellendi: nStokID={rakipAnaliz.nStokID}, Eski={rakipAnaliz.BizimFiyat}, Yeni={rakipAnaliz.OneriFiyat}")
                            End If
                            
                        Catch updateEx As Exception
                            EticaretLogger.LogError($"Fiyat güncelleme hatası: nStokID={rakipAnaliz.nStokID}", updateEx)
                        End Try
                    Next
                End Using
                
                MessageBox.Show($"{guncellenen} ürünün fiyatı başarıyla güncellendi." & vbCrLf & vbCrLf &
                               "NOT: Fiyatların pazaryerlerine yansıması için 'Tüm Stoklar' senkronizasyonunu çalıştırın.",
                               "Fiyat Güncelleme Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                
                EticaretLogger.LogInfo($"Otomatik fiyat ayarlama tamamlandı. {guncellenen} ürün güncellendi.")
                
                ' Listeyi yenile
                btnTara_Click(Nothing, Nothing)
            End If
            
        Catch ex As Exception
            EticaretLogger.LogError("btnOtomatikAyarla_Click hatası", ex)
            MessageBox.Show($"Fiyat ayarlama hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btnYenile_Click(sender As Object, e As EventArgs)
        LoadKategoriler()
        dgvUrunler.Rows.Clear()
        dgvRakipler.Rows.Clear()
        rakipAnalizleri.Clear()
        UpdateSummary()
        lblDurum.Text = "Liste temizlendi. Yeni tarama için 'Rakip Tara' butonuna tıklayın."
    End Sub
    
    Private Sub dgvUrunler_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUrunler.SelectionChanged
        Try
            If dgvUrunler.CurrentRow Is Nothing Then Return
            If dgvUrunler.CurrentRow.Cells("nStokID").Value Is Nothing Then Return
            
            dgvRakipler.Rows.Clear()
            
            Dim nStokID As Integer = CInt(dgvUrunler.CurrentRow.Cells("nStokID").Value)
            Dim barkod As String = ""
            If dgvUrunler.CurrentRow.Cells("Barkod").Value IsNot Nothing Then
                barkod = dgvUrunler.CurrentRow.Cells("Barkod").Value.ToString()
            End If
            
            ' Önce cache'den rakip detaylarını göster (tarama sırasında kaydedilmiş)
            If rakipDetaylari.ContainsKey(nStokID) Then
                Dim rakipler As List(Of TrendyolCompetitor) = rakipDetaylari(nStokID)
                Dim siraNo As Integer = 0
                
                For Each rakip As TrendyolCompetitor In rakipler
                    siraNo += 1
                    Dim rowIndex As Integer = dgvRakipler.Rows.Add()
                    Dim row As DataGridViewRow = dgvRakipler.Rows(rowIndex)
                    
                    row.Cells("SiraNo").Value = siraNo
                    row.Cells("MagazaAdi").Value = rakip.MerchantName
                    row.Cells("Fiyat").Value = rakip.DiscountedPrice
                    row.Cells("KargoUcreti").Value = rakip.ShippingFee
                    row.Cells("ToplamFiyat").Value = rakip.TotalPrice
                    row.Cells("Puan").Value = If(rakip.Rating > 0, rakip.Rating.ToString("0.0"), "-")
                    row.Cells("YorumSayisi").Value = If(rakip.ReviewCount > 0, rakip.ReviewCount.ToString(), "-")
                    row.Cells("Stok").Value = If(rakip.InStock, "Var", "Yok")
                    
                    ' Bizim fiyatımızla karşılaştır
                    Dim bizimFiyat As Decimal = 0
                    If dgvUrunler.CurrentRow.Cells("BizimFiyat").Value IsNot Nothing Then
                        bizimFiyat = CDec(dgvUrunler.CurrentRow.Cells("BizimFiyat").Value)
                    End If
                    
                    If bizimFiyat > 0 AndAlso rakip.DiscountedPrice > 0 Then
                        Dim fark As Decimal = bizimFiyat - rakip.DiscountedPrice
                        Dim farkYuzde As Decimal = (fark / rakip.DiscountedPrice) * 100
                        row.Cells("FiyatFarki").Value = $"{farkYuzde:+0.0;-0.0}%"
                        
                        ' Renklendirme
                        If farkYuzde > 5 Then
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 238) ' Kırmızı - Pahalıyız
                        ElseIf farkYuzde < -5 Then
                            row.DefaultCellStyle.BackColor = Color.FromArgb(232, 245, 233) ' Yeşil - Ucuzuz
                        End If
                    Else
                        row.Cells("FiyatFarki").Value = "-"
                    End If
                    
                    ' Ana satıcı vurgusu
                    If rakip.IsMainMerchant Then
                        row.DefaultCellStyle.Font = New Font(dgvRakipler.Font, FontStyle.Bold)
                    End If
                Next
                
                lblDurum.Text = $"Barkod: {barkod} - {rakipler.Count} rakip bulundu"
            Else
                ' Cache'de yoksa anlık tarama yap
                If Not String.IsNullOrEmpty(barkod) AndAlso barkod.Length >= 8 Then
                    lblDurum.Text = $"Barkod: {barkod} - Rakip taranıyor..."
                    Application.DoEvents()
                    
                    Try
                        Dim rakipResult As TrendyolCompetitorResult = PazaryeriAPIHelper.GetTrendyolCompetitors(barkod)
                        
                        If rakipResult.Success AndAlso rakipResult.Competitors.Count > 0 Then
                            Dim siraNo As Integer = 0
                            
                            For Each rakip As TrendyolCompetitor In rakipResult.Competitors
                                siraNo += 1
                                Dim rowIndex As Integer = dgvRakipler.Rows.Add()
                                Dim row As DataGridViewRow = dgvRakipler.Rows(rowIndex)
                                
                                row.Cells("SiraNo").Value = siraNo
                                row.Cells("MagazaAdi").Value = rakip.MerchantName
                                row.Cells("Fiyat").Value = rakip.DiscountedPrice
                                row.Cells("KargoUcreti").Value = rakip.ShippingFee
                                row.Cells("ToplamFiyat").Value = rakip.TotalPrice
                                row.Cells("Puan").Value = If(rakip.Rating > 0, rakip.Rating.ToString("0.0"), "-")
                                row.Cells("YorumSayisi").Value = If(rakip.ReviewCount > 0, rakip.ReviewCount.ToString(), "-")
                                row.Cells("Stok").Value = If(rakip.InStock, "Var", "Yok")
                                row.Cells("FiyatFarki").Value = "-"
                            Next
                            
                            ' Cache'e ekle
                            If Not rakipDetaylari.ContainsKey(nStokID) Then
                                rakipDetaylari.Add(nStokID, rakipResult.Competitors)
                            End If
                            
                            lblDurum.Text = $"Barkod: {barkod} - {rakipResult.Competitors.Count} rakip bulundu"
                        Else
                            lblDurum.Text = $"Barkod: {barkod} - Trendyol'da bulunamadı veya rakip yok"
                        End If
                    Catch apiEx As Exception
                        EticaretLogger.LogError("Rakip tarama hatası", apiEx)
                        lblDurum.Text = "Tarama hatası: " & apiEx.Message
                    End Try
                Else
                    lblDurum.Text = "Ürün barkodu bulunamadı veya geçersiz"
                End If
            End If
            
        Catch ex As Exception
            EticaretLogger.LogError("dgvUrunler_SelectionChanged hatasi", ex)
        End Try
    End Sub
#End Region

End Class
