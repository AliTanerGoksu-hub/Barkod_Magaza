' ============================================================================
' İADE RİSKİ TAHMİNİ FORMU
' Dosya: frm_IadeRiskiTahmini.vb
' Tarih: 2026-02-20
' Açıklama: Ürünlerin iade riskini analiz eder ve öneriler sunar
' ROADMAP.md Görevi: İade Riski Tahmini (P2)
' NOT: frm_qukaGonder.vb'den BAĞIMSIZ çalışır
' ============================================================================

Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks

''' <summary>
''' İade riski tahmini ve analiz formu
''' Geçmiş iade verilerine göre risk skorlaması yapar
''' </summary>
Public Class frm_IadeRiskiTahmini
    Inherits Form

#Region "Değişkenler"
    Public connection As String = ""
    Private WithEvents dgvUrunler As DataGridView
    Private pnlFiltre As Panel
    Private pnlOzet As Panel
    Private btnAnaliz As Button
    Private btnExport As Button
    Private cmbKategori As ComboBox
    Private cmbRiskSeviyesi As ComboBox
    Private cmbPazaryeri As ComboBox
    Private lblDurum As Label
    Private progressBar As ProgressBar
    
    Private analizVerileri As New List(Of IadeAnaliz)
#End Region

#Region "Veri Yapıları"
    Public Class IadeAnaliz
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
        Public Property ToplamSatis As Integer
        Public Property ToplamIade As Integer
        Public Property IadeOrani As Decimal
        Public Property RiskSkoru As Integer
        Public Property RiskSeviyesi As String
        Public Property IadeNedenleri As String
        Public Property Tavsiye As String
        Public Property SonIadeTarihi As DateTime
    End Class
#End Region

#Region "Constructor ve Form"
    Public Sub New()
        InitializeComponent()
    End Sub
    
    Private Sub InitializeComponent()
        Me.Text = "⚠️ İade Riski Tahmini"
        Me.Size = New Size(1350, 800)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(245, 245, 250)
        
        Dim tlp As New TableLayoutPanel()
        tlp.Dock = DockStyle.Fill
        tlp.RowCount = 4
        tlp.ColumnCount = 1
        tlp.RowStyles.Add(New RowStyle(SizeType.Absolute, 70))
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
        
        ' Kategori
        Dim lblKat As New Label()
        lblKat.Text = "Kategori:"
        lblKat.AutoSize = True
        lblKat.Margin = New Padding(0, 10, 5, 0)
        flow.Controls.Add(lblKat)
        
        cmbKategori = New ComboBox()
        cmbKategori.Width = 180
        cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKategori.Items.Add("-- Tümü --")
        cmbKategori.SelectedIndex = 0
        flow.Controls.Add(cmbKategori)
        
        ' Risk Seviyesi
        Dim lblRisk As New Label()
        lblRisk.Text = "Risk Seviyesi:"
        lblRisk.AutoSize = True
        lblRisk.Margin = New Padding(20, 10, 5, 0)
        flow.Controls.Add(lblRisk)
        
        cmbRiskSeviyesi = New ComboBox()
        cmbRiskSeviyesi.Width = 150
        cmbRiskSeviyesi.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRiskSeviyesi.Items.AddRange({"-- Tümü --", "KRİTİK", "YÜKSEK", "ORTA", "DÜŞÜK"})
        cmbRiskSeviyesi.SelectedIndex = 0
        flow.Controls.Add(cmbRiskSeviyesi)
        
        ' Analiz butonu
        btnAnaliz = New Button()
        btnAnaliz.Text = "🔍 Analiz Et"
        btnAnaliz.Width = 120
        btnAnaliz.Height = 35
        btnAnaliz.BackColor = Color.FromArgb(244, 67, 54)
        btnAnaliz.ForeColor = Color.White
        btnAnaliz.FlatStyle = FlatStyle.Flat
        btnAnaliz.Margin = New Padding(30, 5, 5, 0)
        AddHandler btnAnaliz.Click, AddressOf btnAnaliz_Click
        flow.Controls.Add(btnAnaliz)
        
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
        
        ' Export butonu
        btnExport = New Button()
        btnExport.Text = "📊 Rapor Al"
        btnExport.Width = 110
        btnExport.Height = 35
        btnExport.BackColor = Color.FromArgb(76, 175, 80)
        btnExport.ForeColor = Color.White
        btnExport.FlatStyle = FlatStyle.Flat
        btnExport.Margin = New Padding(10, 5, 0, 0)
        AddHandler btnExport.Click, AddressOf btnExport_Click
        flow.Controls.Add(btnExport)
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
        
        CreateCard(flow, "📦 Toplam Ürün", "0", Color.FromArgb(63, 81, 181), "toplam")
        CreateCard(flow, "🔴 Kritik Risk", "0", Color.FromArgb(183, 28, 28), "kritik")
        CreateCard(flow, "🟠 Yüksek Risk", "0", Color.FromArgb(244, 67, 54), "yuksek")
        CreateCard(flow, "🟡 Orta Risk", "0", Color.FromArgb(255, 152, 0), "orta")
        CreateCard(flow, "🟢 Düşük Risk", "0", Color.FromArgb(76, 175, 80), "dusuk")
        CreateCard(flow, "📈 Ort. İade %", "%0", Color.FromArgb(156, 39, 176), "ortiade")
    End Sub
    
    Private Sub CreateCard(parent As FlowLayoutPanel, title As String, value As String, color As Color, tag As String)
        Dim pnl As New Panel()
        pnl.Size = New Size(170, 75)
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
        dgvUrunler.ColumnHeadersHeight = 35
        dgvUrunler.EnableHeadersVisualStyles = False
        dgvUrunler.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 250)
        dgvUrunler.DefaultCellStyle.SelectionBackColor = Color.FromArgb(63, 81, 181)
        dgvUrunler.DefaultCellStyle.SelectionForeColor = Color.White
        dgvUrunler.ReadOnly = True
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
        
        ' Kolonlar
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
        dgvUrunler.Columns("UrunAdi").Width = 180
        
        dgvUrunler.Columns.Add("Renk", "Renk")
        dgvUrunler.Columns("Renk").Width = 70
        
        dgvUrunler.Columns.Add("Beden", "Beden")
        dgvUrunler.Columns("Beden").Width = 60
        
        dgvUrunler.Columns.Add("Kavala", "Kavala")
        dgvUrunler.Columns("Kavala").Width = 70
        
        dgvUrunler.Columns.Add("Kategori", "Kategori")
        dgvUrunler.Columns("Kategori").Width = 100
        
        dgvUrunler.Columns.Add("ToplamSatis", "Satis")
        dgvUrunler.Columns("ToplamSatis").Width = 60
        
        dgvUrunler.Columns.Add("ToplamIade", "Iade")
        dgvUrunler.Columns("ToplamIade").Width = 60
        
        dgvUrunler.Columns.Add("IadeOrani", "Iade %")
        dgvUrunler.Columns("IadeOrani").Width = 60
        dgvUrunler.Columns("IadeOrani").DefaultCellStyle.Format = "#0.0'%'"
        
        dgvUrunler.Columns.Add("RiskSkoru", "Risk Skoru")
        dgvUrunler.Columns("RiskSkoru").Width = 70
        
        dgvUrunler.Columns.Add("RiskSeviyesi", "Risk")
        dgvUrunler.Columns("RiskSeviyesi").Width = 90
        
        dgvUrunler.Columns.Add("IadeNedenleri", "Iade Nedenleri")
        dgvUrunler.Columns("IadeNedenleri").Width = 120
        
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
        lblDurum.Text = "Hazır. Analiz için butona tıklayın."
        pnl.Controls.Add(lblDurum)
        
        progressBar = New ProgressBar()
        progressBar.Dock = DockStyle.Right
        progressBar.Width = 200
        pnl.Controls.Add(progressBar)
    End Sub
    
    Private Sub frm_IadeRiskiTahmini_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            EticaretLogger.LogInfo("İade Riski Tahmini formu yükleniyor...")
            
            ' Connection string kontrolu - bos ise global KeyCode'dan al
            If String.IsNullOrEmpty(connection) Then
                connection = KeyCode.connection
            End If
            
            LoadKategoriler()
            
            ' Kaydedilmis gorunumu yukle
            GorunumYukle()
            
            EticaretLogger.LogInfo("İade Riski Tahmini formu yüklendi.")
        Catch ex As Exception
            EticaretLogger.LogError("İade Riski formu yükleme hatası", ex)
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
    
    Private Async Sub btnAnaliz_Click(sender As Object, e As EventArgs)
        Try
            btnAnaliz.Enabled = False
            progressBar.Value = 0
            lblDurum.Text = "Analiz yapılıyor..."
            analizVerileri.Clear()
            
            EticaretLogger.LogInfo("İade riski analizi başlatıldı.")
            
            Await Task.Run(Sub() AnalyzeIadeRiskiFromCache())
            
            DisplayResults()
            UpdateSummary()
            
            lblDurum.Text = $"Analiz tamamlandı. {analizVerileri.Count} ürün analiz edildi."
            EticaretLogger.LogInfo($"İade riski analizi tamamlandı. {analizVerileri.Count} ürün.")
            
        Catch ex As Exception
            EticaretLogger.LogError("İade analizi hatası", ex)
            MessageBox.Show($"Analiz hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnAnaliz.Enabled = True
            progressBar.Value = 100
        End Try
    End Sub
    
    ''' <summary>
    ''' Merkezi cache sisteminden iade riski verilerini yükler
    ''' </summary>
    Private Sub AnalyzeIadeRiskiFromCache()
        Try
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                Dim pazaryeri As String = ""
                Dim kategori As String = ""
                
                Me.Invoke(Sub()
                    pazaryeri = If(cmbPazaryeri IsNot Nothing AndAlso cmbPazaryeri.SelectedIndex >= 0, cmbPazaryeri.Text, "Tümü")
                    kategori = If(cmbKategori IsNot Nothing AndAlso cmbKategori.SelectedIndex > 0, cmbKategori.Text, "")
                    lblDurum.Text = "Veritabanına bağlanılıyor..."
                End Sub)
                
                EticaretLogger.LogInfo($"AnalyzeIadeRiskiFromCache başlatıldı. Pazaryeri={pazaryeri}")
                
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
                
                ' Cache verisini İade analiz modeline dönüştür
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
                    
                    Dim analiz As New IadeAnaliz()
                    analiz.nStokID = cacheItem.nStokID
                    analiz.StokKodu = cacheItem.StokKodu
                    analiz.ModelKodu = cacheItem.Model
                    analiz.Barkod = cacheItem.Barkod
                    analiz.Renk = cacheItem.Renk
                    analiz.Beden = cacheItem.Beden
                    analiz.Kavala = ""
                    analiz.UrunAdi = cacheItem.UrunAdi
                    analiz.Model = cacheItem.Model
                    analiz.Kategori = cacheItem.Kategori
                    
                    ' Cache'den gelen iade verileri
                    analiz.ToplamSatis = cacheItem.Satis90Gun
                    analiz.ToplamIade = cacheItem.ToplamIade
                    analiz.IadeOrani = cacheItem.IadeOrani
                    
                    ' İade nedenleri detayı
                    Dim nedenler As New List(Of String)
                    If cacheItem.IadeSayisi > 0 Then nedenler.Add($"İade: {cacheItem.IadeSayisi}")
                    If cacheItem.IptalSayisi > 0 Then nedenler.Add($"İptal: {cacheItem.IptalSayisi}")
                    If cacheItem.TeslimEdilemedi > 0 Then nedenler.Add($"Teslim edilemedi: {cacheItem.TeslimEdilemedi}")
                    analiz.IadeNedenleri = If(nedenler.Count > 0, String.Join(", ", nedenler), GetIadeNedeniFromKategori(cacheItem.Kategori))
                    
                    ' Risk hesapla
                    CalculateRisk(analiz)
                    
                    analizVerileri.Add(analiz)
                Next
                
                EticaretLogger.LogInfo($"Cache'den {analizVerileri.Count} ürün iade analizi yüklendi")
            End Using
        Catch ex As Exception
            EticaretLogger.LogError("AnalyzeIadeRiskiFromCache hatası", ex)
            Me.Invoke(Sub()
                lblDurum.Text = $"HATA: {ex.Message}"
                MessageBox.Show($"Analiz hatası: {ex.Message}" & vbCrLf & vbCrLf & "Log: C:\eticaret\log", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Sub)
        End Try
    End Sub
    
    ' Eski fonksiyon - artık kullanılmıyor, cache sistemi kullanılıyor  
    Private Sub AnalyzeIadeRiski_OLD()
        Try
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                ' Pazaryeri prefix'i belirle
                Dim pazaryeri As String = If(cmbPazaryeri IsNot Nothing AndAlso cmbPazaryeri.SelectedIndex >= 0, cmbPazaryeri.Text, "Tumu")
                Dim pazaryeriPrefix As String = GetPazaryeriPrefix(pazaryeri)
                
                ' Pazaryeri filtresi icin WHERE clause
                Dim pazaryeriWhere As String = ""
                If pazaryeriPrefix <> "" Then
                    If pazaryeriPrefix.Length = 3 Then
                        pazaryeriWhere = " AND LEFT(ISNULL(a.sAciklama3,''),3) = '" & pazaryeriPrefix & "' "
                    Else
                        pazaryeriWhere = " AND LEFT(ISNULL(a.sAciklama3,''),2) = '" & pazaryeriPrefix & "' "
                    End If
                End If
                
                ' Gercek satis ve iade verilerini ceken SQL
                ' FS = Satis Fisi, FI = Iade Fisi (veya negatif lCikisMiktar1)
                Dim sql As String = "SELECT " &
                    "s.nStokID, s.sKodu AS sStokKodu, s.sModel, " &
                    "ISNULL((SELECT TOP 1 b.sBarkod FROM tbStokBarkodu b WHERE b.nStokID = s.nStokID), '') AS sBarkod, " &
                    "ISNULL(s.sRenk, '') AS sRenk, ISNULL(s.sBeden, '') AS sBeden, ISNULL(s.sKavala, '') AS sKavala, " &
                    "s.sAciklama, " &
                    "(SELECT sAciklama FROM tbSSinif4 WHERE sSinifKodu=si.sSinifKodu4) AS Kategori, " &
                    "ISNULL((SELECT SUM(d.lCikisMiktar1) FROM tbStokFisiDetayi d " &
                    "  INNER JOIN tbStokFisiMaster m ON d.nStokFisiID = m.nStokFisiID " &
                    "  LEFT JOIN tbStokFisiAciklamasi a ON m.nStokFisiID = a.nStokFisiID " &
                    "  WHERE d.nStokID = s.nStokID AND m.sFisTipi = 'FS ' AND d.lCikisMiktar1 > 0 " &
                    "  AND m.dteFisTarihi >= DATEADD(day, -90, GETDATE()) " & pazaryeriWhere & "), 0) AS ToplamSatis, " &
                    "ISNULL((SELECT SUM(ABS(d.lCikisMiktar1)) FROM tbStokFisiDetayi d " &
                    "  INNER JOIN tbStokFisiMaster m ON d.nStokFisiID = m.nStokFisiID " &
                    "  LEFT JOIN tbStokFisiAciklamasi a ON m.nStokFisiID = a.nStokFisiID " &
                    "  WHERE d.nStokID = s.nStokID AND (m.sFisTipi = 'FI ' OR d.lCikisMiktar1 < 0) " &
                    "  AND m.dteFisTarihi >= DATEADD(day, -90, GETDATE()) " & pazaryeriWhere & "), 0) AS ToplamIade, " &
                    "(SELECT MAX(m.dteFisTarihi) FROM tbStokFisiDetayi d " &
                    "  INNER JOIN tbStokFisiMaster m ON d.nStokFisiID = m.nStokFisiID " &
                    "  WHERE d.nStokID = s.nStokID AND (m.sFisTipi = 'FI ' OR d.lCikisMiktar1 < 0)) AS SonIadeTarihi " &
                    "FROM tbStok s " &
                    "LEFT JOIN tbStokSinifi si ON si.nStokID = s.nStokID " &
                    "WHERE s.bWebGoruntule = 1 AND s.nStokTipi < 5 "
                
                If cmbKategori.SelectedIndex > 0 Then
                    sql &= " AND (SELECT sAciklama FROM tbSSinif4 WHERE sSinifKodu=si.sSinifKodu4) = ?"
                End If
                
                sql &= " ORDER BY s.nStokID DESC"
                
                Dim cmd As New OleDbCommand(sql, conn)
                cmd.CommandTimeout = 120
                
                If cmbKategori.SelectedIndex > 0 Then
                    cmd.Parameters.AddWithValue("?", cmbKategori.SelectedItem.ToString())
                End If
                
                EticaretLogger.LogDatabase("SELECT", "tbStok, tbStokFisiDetayi, tbStokFisiMaster", 0, sql)
                
                ' API'den iade istatistiklerini çek (son 90 gün)
                Me.Invoke(Sub() lblDurum.Text = "API'den iade verileri çekiliyor...")
                Dim apiIadeStats As Dictionary(Of String, IadeIstatistik) = Nothing
                Try
                    apiIadeStats = PazaryeriAPIHelper.GetIadeIstatistikleri(DateTime.Now.AddDays(-90), DateTime.Now)
                    EticaretLogger.LogInfo($"API'den {apiIadeStats.Count} ürün için iade istatistiği alındı")
                Catch apiEx As Exception
                    EticaretLogger.LogError("API iade istatistikleri alınamadı", apiEx)
                    apiIadeStats = New Dictionary(Of String, IadeIstatistik)
                End Try
                
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
                        
                        Dim analiz As New IadeAnaliz()
                        analiz.nStokID = CInt(reader("nStokID"))
                        analiz.StokKodu = If(IsDBNull(reader("sStokKodu")), "", reader("sStokKodu").ToString())
                        analiz.ModelKodu = If(IsDBNull(reader("sModel")), "", reader("sModel").ToString())
                        analiz.Barkod = If(IsDBNull(reader("sBarkod")), "", reader("sBarkod").ToString())
                        analiz.Renk = If(IsDBNull(reader("sRenk")), "", reader("sRenk").ToString())
                        analiz.Beden = If(IsDBNull(reader("sBeden")), "", reader("sBeden").ToString())
                        analiz.Kavala = If(IsDBNull(reader("sKavala")), "", reader("sKavala").ToString())
                        analiz.UrunAdi = If(IsDBNull(reader("sAciklama")), "", reader("sAciklama").ToString())
                        analiz.Model = If(IsDBNull(reader("sModel")), "", reader("sModel").ToString())
                        analiz.Kategori = If(IsDBNull(reader("Kategori")), "", reader("Kategori").ToString())
                        
                        ' Veritabanı değerlerini al
                        Dim dbSatis As Integer = If(IsDBNull(reader("ToplamSatis")), 0, CInt(reader("ToplamSatis")))
                        Dim dbIade As Integer = If(IsDBNull(reader("ToplamIade")), 0, CInt(reader("ToplamIade")))
                        analiz.SonIadeTarihi = If(IsDBNull(reader("SonIadeTarihi")), DateTime.MinValue, CDate(reader("SonIadeTarihi")))
                        
                        ' API'den gelen verileri birleştir (barkod ile eşleştir)
                        If Not String.IsNullOrEmpty(analiz.Barkod) AndAlso apiIadeStats.ContainsKey(analiz.Barkod) Then
                            Dim apiStat = apiIadeStats(analiz.Barkod)
                            ' API ve veritabanı verilerini topla
                            analiz.ToplamSatis = dbSatis + apiStat.ToplamSatis
                            analiz.ToplamIade = dbIade + apiStat.ToplamIade
                            
                            ' İade nedeni API'den geliyorsa daha detaylı
                            If apiStat.IadeSayisi > 0 OrElse apiStat.IptalSayisi > 0 OrElse apiStat.TeslimEdilemedi > 0 Then
                                Dim nedenler As New List(Of String)
                                If apiStat.IadeSayisi > 0 Then nedenler.Add($"İade: {apiStat.IadeSayisi}")
                                If apiStat.IptalSayisi > 0 Then nedenler.Add($"İptal: {apiStat.IptalSayisi}")
                                If apiStat.TeslimEdilemedi > 0 Then nedenler.Add($"Teslim edilemedi: {apiStat.TeslimEdilemedi}")
                                analiz.IadeNedenleri = String.Join(", ", nedenler)
                            Else
                                analiz.IadeNedenleri = GetIadeNedeniFromKategori(analiz.Kategori)
                            End If
                        Else
                            ' Sadece veritabanı verileri
                            analiz.ToplamSatis = dbSatis
                            analiz.ToplamIade = dbIade
                            analiz.IadeNedenleri = GetIadeNedeniFromKategori(analiz.Kategori)
                        End If
                        
                        ' Iade orani hesapla
                        If analiz.ToplamSatis > 0 Then
                            analiz.IadeOrani = Math.Round((CDec(analiz.ToplamIade) / CDec(analiz.ToplamSatis)) * 100, 1)
                        Else
                            analiz.IadeOrani = 0
                        End If
                        
                        ' Risk hesapla
                        CalculateRisk(analiz)
                        
                        analizVerileri.Add(analiz)
                    End While
                    
                    EticaretLogger.LogInfo($"Iade riski analizi tamamlandi: {sayac} urun (API + Veritabanı)")
                End Using
                
            End Using
        Catch ex As Exception
            EticaretLogger.LogError("AnalyzeIadeRiski hatası", ex)
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
    
    Private Function GetIadeNedeniFromKategori(kategori As String) As String
        If String.IsNullOrEmpty(kategori) Then Return "Genel"
        
        Dim kat As String = kategori.ToLower()
        If kat.Contains("ayakkab") Then Return "Beden uyumsuzlugu"
        If kat.Contains("elbise") OrElse kat.Contains("gomlek") Then Return "Beden/Renk farki"
        If kat.Contains("pantolon") Then Return "Beden hatasi"
        If kat.Contains("canta") OrElse kat.Contains("aksesuar") Then Return "Beklentiden farkli"
        Return "Genel"
    End Function
    
    Private Sub CalculateRisk(analiz As IadeAnaliz)
        ' Risk skoru hesaplama (0-100)
        Dim skor As Integer = 0
        
        ' İade oranına göre skor
        If analiz.IadeOrani >= 20 Then
            skor = 90
        ElseIf analiz.IadeOrani >= 15 Then
            skor = 75
        ElseIf analiz.IadeOrani >= 10 Then
            skor = 55
        ElseIf analiz.IadeOrani >= 5 Then
            skor = 35
        Else
            skor = 15
        End If
        
        ' Toplam iade sayısına göre bonus/ceza
        If analiz.ToplamIade > 50 Then skor += 10
        If analiz.ToplamIade > 100 Then skor += 10
        
        analiz.RiskSkoru = Math.Min(skor, 100)
        
        ' Risk seviyesi
        Select Case analiz.RiskSkoru
            Case Is >= 80
                analiz.RiskSeviyesi = "🔴 KRİTİK"
                analiz.Tavsiye = "ACİL: Ürünü incelemeye alın, satışı durdurmayı düşünün"
            Case Is >= 60
                analiz.RiskSeviyesi = "🟠 YÜKSEK"
                analiz.Tavsiye = "Ürün açıklamasını ve görsellerini güncelleyin"
            Case Is >= 40
                analiz.RiskSeviyesi = "🟡 ORTA"
                analiz.Tavsiye = "Beden tablosu ve kumaş bilgisini detaylandırın"
            Case Else
                analiz.RiskSeviyesi = "🟢 DÜŞÜK"
                analiz.Tavsiye = "İyi performans, mevcut durumu koruyun"
        End Select
    End Sub
    
    Private Sub DisplayResults()
        Try
            dgvUrunler.Rows.Clear()
            
            Dim filtered As New List(Of IadeAnaliz)
            For Each item As IadeAnaliz In analizVerileri
                filtered.Add(item)
            Next
            
            ' Risk filtresi
            If cmbRiskSeviyesi.SelectedIndex > 0 Then
                Dim secili = cmbRiskSeviyesi.SelectedItem.ToString()
                Dim tempList As New List(Of IadeAnaliz)
                For Each item As IadeAnaliz In filtered
                    If item.RiskSeviyesi.Contains(secili) Then
                        tempList.Add(item)
                    End If
                Next
                filtered = tempList
            End If
            
            ' Sıralama
            filtered.Sort(Function(x, y) y.RiskSkoru.CompareTo(x.RiskSkoru))
            
            For Each iadeAnaliz As IadeAnaliz In filtered
                Dim row = dgvUrunler.Rows.Add()
                dgvUrunler.Rows(row).Cells("nStokID").Value = iadeAnaliz.nStokID
                dgvUrunler.Rows(row).Cells("StokKodu").Value = iadeAnaliz.StokKodu
                dgvUrunler.Rows(row).Cells("ModelKodu").Value = iadeAnaliz.ModelKodu
                dgvUrunler.Rows(row).Cells("Barkod").Value = iadeAnaliz.Barkod
                dgvUrunler.Rows(row).Cells("UrunAdi").Value = iadeAnaliz.UrunAdi
                dgvUrunler.Rows(row).Cells("Renk").Value = iadeAnaliz.Renk
                dgvUrunler.Rows(row).Cells("Beden").Value = iadeAnaliz.Beden
                dgvUrunler.Rows(row).Cells("Kavala").Value = iadeAnaliz.Kavala
                dgvUrunler.Rows(row).Cells("Kategori").Value = iadeAnaliz.Kategori
                dgvUrunler.Rows(row).Cells("ToplamSatis").Value = iadeAnaliz.ToplamSatis
                dgvUrunler.Rows(row).Cells("ToplamIade").Value = iadeAnaliz.ToplamIade
                dgvUrunler.Rows(row).Cells("IadeOrani").Value = iadeAnaliz.IadeOrani
                dgvUrunler.Rows(row).Cells("RiskSkoru").Value = iadeAnaliz.RiskSkoru
                dgvUrunler.Rows(row).Cells("RiskSeviyesi").Value = iadeAnaliz.RiskSeviyesi
                dgvUrunler.Rows(row).Cells("IadeNedenleri").Value = iadeAnaliz.IadeNedenleri
                dgvUrunler.Rows(row).Cells("Tavsiye").Value = iadeAnaliz.Tavsiye
                
                ' Renklendirme
                If iadeAnaliz.RiskSeviyesi.Contains("KRİTİK") Then
                    dgvUrunler.Rows(row).DefaultCellStyle.BackColor = Color.FromArgb(255, 205, 210)
                ElseIf iadeAnaliz.RiskSeviyesi.Contains("YÜKSEK") Then
                    dgvUrunler.Rows(row).DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 178)
                ElseIf iadeAnaliz.RiskSeviyesi.Contains("DÜŞÜK") Then
                    dgvUrunler.Rows(row).DefaultCellStyle.BackColor = Color.FromArgb(200, 230, 201)
                End If
            Next
            
        Catch ex As Exception
            EticaretLogger.LogError("DisplayResults hatası", ex)
        End Try
    End Sub
    
    Private Sub UpdateSummary()
        Try
            If analizVerileri.Count = 0 Then Return
            
            Dim toplam As Integer = analizVerileri.Count
            Dim kritik As Integer = 0
            Dim yuksek As Integer = 0
            Dim orta As Integer = 0
            Dim dusuk As Integer = 0
            Dim ortIade As Decimal = 0
            
            For Each item As IadeAnaliz In analizVerileri
                If item.RiskSeviyesi.Contains("KRİTİK") Then kritik += 1
                If item.RiskSeviyesi.Contains("YÜKSEK") Then yuksek += 1
                If item.RiskSeviyesi.Contains("ORTA") Then orta += 1
                If item.RiskSeviyesi.Contains("DÜŞÜK") Then dusuk += 1
                ortIade += item.IadeOrani
            Next
            ortIade = ortIade / toplam
            
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
                                    Case "kritik" : lbl.Text = kritik.ToString()
                                    Case "yuksek" : lbl.Text = yuksek.ToString()
                                    Case "orta" : lbl.Text = orta.ToString()
                                    Case "dusuk" : lbl.Text = dusuk.ToString()
                                    Case "ortiade" : lbl.Text = $"%{ortIade:F1}"
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
    
    Private Sub btnExport_Click(sender As Object, e As EventArgs)
        Try
            If analizVerileri.Count = 0 Then
                MessageBox.Show("Aktarılacak veri yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "CSV Dosyası|*.csv"
            saveDialog.FileName = $"IadeRiskiRaporu_{DateTime.Now:yyyyMMdd_HHmmss}.csv"
            
            Dim sorted As New List(Of IadeAnaliz)
            For Each item As IadeAnaliz In analizVerileri
                sorted.Add(item)
            Next
            sorted.Sort(Function(x, y) y.RiskSkoru.CompareTo(x.RiskSkoru))
            
            If saveDialog.ShowDialog() = DialogResult.OK Then
                Using writer As New System.IO.StreamWriter(saveDialog.FileName, False, System.Text.Encoding.UTF8)
                    writer.WriteLine("Ürün Adı;Kategori;Satış;İade;İade %;Risk Skoru;Risk Seviyesi;İade Nedenleri;Tavsiye")
                    
                    For Each iadeAnaliz As IadeAnaliz In sorted
                        writer.WriteLine($"{iadeAnaliz.UrunAdi};{iadeAnaliz.Kategori};{iadeAnaliz.ToplamSatis};{iadeAnaliz.ToplamIade};{iadeAnaliz.IadeOrani};{iadeAnaliz.RiskSkoru};{iadeAnaliz.RiskSeviyesi};{iadeAnaliz.IadeNedenleri};{iadeAnaliz.Tavsiye}")
                    Next
                End Using
                
                MessageBox.Show($"Rapor kaydedildi:{vbCrLf}{saveDialog.FileName}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                EticaretLogger.LogInfo($"İade riski raporu oluşturuldu: {saveDialog.FileName}")
            End If
        Catch ex As Exception
            EticaretLogger.LogError("Rapor oluşturma hatası", ex)
            MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

End Class
