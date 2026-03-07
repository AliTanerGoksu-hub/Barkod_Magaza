' ============================================================================
' FAVORİ/SEPET ORANI ANALİZİ FORMU
' Dosya: frm_FavoriSepetAnalizi.vb
' Tarih: 2026-02-20
' Açıklama: Ürünlerin favori ve sepete eklenme oranlarını analiz eder
' ROADMAP.md Görevi: Favori/Sepet Oranı Analizi (P1)
' NOT: frm_qukaGonder.vb'den BAĞIMSIZ çalışır
' ============================================================================

Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks

''' <summary>
''' Favori ve sepet oranı analizi formu
''' Trendyol'un sıralama algoritmasında önemli olan favori/sepet metriklerini izler
''' </summary>
Public Class frm_FavoriSepetAnalizi
    Inherits Form

#Region "Değişkenler"
    Public connection As String = ""
    Private WithEvents dgvUrunler As DataGridView
    Private pnlFiltre As Panel
    Private pnlOzet As Panel
    Private btnYenile As Button
    Private btnExport As Button
    Private cmbSiralama As ComboBox
    Private cmbKategori As ComboBox
    Private cmbPazaryeri As ComboBox
    Private lblDurum As Label
    Private progressBar As ProgressBar
    
    ' Veri
    Private analizVerileri As New List(Of UrunAnaliz)
#End Region

#Region "Veri Yapıları"
    Public Class UrunAnaliz
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
        Public Property FavoriSayisi As Integer
        Public Property SepetSayisi As Integer
        Public Property SatisSayisi As Integer
        Public Property GoruntulenmeSayisi As Integer
        Public Property FavoriOrani As Decimal
        Public Property SepetOrani As Decimal
        Public Property DonusumOrani As Decimal
        Public Property SepettenSatisOrani As Decimal
        Public Property Performans As String
        Public Property Tavsiye As String
        Public Property SonGuncelleme As DateTime
    End Class
#End Region

#Region "Constructor ve Form Olayları"
    Public Sub New()
        InitializeComponent()
    End Sub
    
    Private Sub InitializeComponent()
        Me.Text = "❤️ Favori/Sepet Oranı Analizi"
        Me.Size = New Size(1400, 850)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(245, 245, 250)
        
        ' Ana layout
        Dim tlp As New TableLayoutPanel()
        tlp.Dock = DockStyle.Fill
        tlp.RowCount = 4
        tlp.ColumnCount = 1
        tlp.RowStyles.Add(New RowStyle(SizeType.Absolute, 70))   ' Filtre
        tlp.RowStyles.Add(New RowStyle(SizeType.Absolute, 120))  ' Özet kartları
        tlp.RowStyles.Add(New RowStyle(SizeType.Percent, 100))   ' Grid
        tlp.RowStyles.Add(New RowStyle(SizeType.Absolute, 35))   ' Status
        tlp.Padding = New Padding(10)
        Me.Controls.Add(tlp)
        
        ' Filtre paneli
        CreateFilterPanel(tlp)
        
        ' Özet paneli
        CreateSummaryPanel(tlp)
        
        ' DataGrid
        dgvUrunler = New DataGridView()
        ConfigureGrid()
        tlp.Controls.Add(dgvUrunler, 0, 2)
        
        ' Durum çubuğu
        CreateStatusBar(tlp)
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
        pnlFiltre.Controls.Add(flowPanel)
        
        ' Kategori
        Dim lblKat As New Label()
        lblKat.Text = "Kategori:"
        lblKat.AutoSize = True
        lblKat.Margin = New Padding(0, 10, 5, 0)
        flowPanel.Controls.Add(lblKat)
        
        cmbKategori = New ComboBox()
        cmbKategori.Width = 180
        cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKategori.Items.Add("-- Tümü --")
        cmbKategori.SelectedIndex = 0
        flowPanel.Controls.Add(cmbKategori)
        
        ' Sıralama
        Dim lblSirala As New Label()
        lblSirala.Text = "Sırala:"
        lblSirala.AutoSize = True
        lblSirala.Margin = New Padding(20, 10, 5, 0)
        flowPanel.Controls.Add(lblSirala)
        
        cmbSiralama = New ComboBox()
        cmbSiralama.Width = 180
        cmbSiralama.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSiralama.Items.AddRange({"Favori Oranı (Yüksek)", "Favori Oranı (Düşük)", 
                                    "Sepet Oranı (Yüksek)", "Sepet Oranı (Düşük)",
                                    "Dönüşüm Oranı (Yüksek)", "Dönüşüm Oranı (Düşük)",
                                    "Favori Sayısı", "Sepet Sayısı"})
        cmbSiralama.SelectedIndex = 0
        AddHandler cmbSiralama.SelectedIndexChanged, AddressOf cmbSiralama_Changed
        flowPanel.Controls.Add(cmbSiralama)
        
        ' Pazaryeri secimi
        Dim lblPazaryeri As New Label()
        lblPazaryeri.Text = "Pazaryeri:"
        lblPazaryeri.AutoSize = True
        lblPazaryeri.Margin = New Padding(20, 10, 5, 0)
        flowPanel.Controls.Add(lblPazaryeri)
        
        cmbPazaryeri = New ComboBox()
        cmbPazaryeri.Width = 120
        cmbPazaryeri.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPazaryeri.Items.AddRange(New String() {"Tumu", "Trendyol", "Hepsiburada", "N11", "Amazon", "PttAVM", "Pazarama", "CicekSepeti", "Modanisa", "Farmazon", "Idefix", "LCWaikiki"})
        cmbPazaryeri.SelectedIndex = 0
        flowPanel.Controls.Add(cmbPazaryeri)
        
        ' Yenile butonu
        btnYenile = New Button()
        btnYenile.Text = "🔄 Verileri Yükle"
        btnYenile.Width = 130
        btnYenile.Height = 35
        btnYenile.BackColor = Color.FromArgb(0, 150, 136)
        btnYenile.ForeColor = Color.White
        btnYenile.FlatStyle = FlatStyle.Flat
        btnYenile.Margin = New Padding(30, 5, 5, 0)
        AddHandler btnYenile.Click, AddressOf btnYenile_Click
        flowPanel.Controls.Add(btnYenile)
        
        ' Export butonu
        btnExport = New Button()
        btnExport.Text = "📊 Excel'e Aktar"
        btnExport.Width = 120
        btnExport.Height = 35
        btnExport.BackColor = Color.FromArgb(76, 175, 80)
        btnExport.ForeColor = Color.White
        btnExport.FlatStyle = FlatStyle.Flat
        btnExport.Margin = New Padding(10, 5, 0, 0)
        AddHandler btnExport.Click, AddressOf btnExport_Click
        flowPanel.Controls.Add(btnExport)
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
        CreateSummaryCard(flowOzet, "📦 Toplam Ürün", "0", Color.FromArgb(63, 81, 181), "toplam")
        CreateSummaryCard(flowOzet, "❤️ Ort. Favori Oranı", "%0.0", Color.FromArgb(233, 30, 99), "favoriOran")
        CreateSummaryCard(flowOzet, "🛒 Ort. Sepet Oranı", "%0.0", Color.FromArgb(255, 152, 0), "sepetOran")
        CreateSummaryCard(flowOzet, "💰 Ort. Dönüşüm", "%0.0", Color.FromArgb(76, 175, 80), "donusum")
        CreateSummaryCard(flowOzet, "⭐ Yüksek Performans", "0", Color.FromArgb(156, 39, 176), "yuksek")
        CreateSummaryCard(flowOzet, "⚠️ Düşük Performans", "0", Color.FromArgb(244, 67, 54), "dusuk")
    End Sub
    
    Private Sub CreateSummaryCard(parent As FlowLayoutPanel, title As String, value As String, color As Color, tag As String)
        Dim pnl As New Panel()
        pnl.Size = New Size(180, 85)
        pnl.BackColor = color
        pnl.Margin = New Padding(5)
        pnl.Tag = tag
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
        lblValue.Font = New Font("Segoe UI", 18, FontStyle.Bold)
        lblValue.Location = New Point(10, 38)
        lblValue.AutoSize = True
        lblValue.Tag = "value"
        pnl.Controls.Add(lblValue)
    End Sub
    
    Private Sub ConfigureGrid()
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
        
        dgvUrunler.Columns.Add("GoruntulenmeSayisi", "Goruntuleme")
        dgvUrunler.Columns("GoruntulenmeSayisi").Width = 80
        dgvUrunler.Columns("GoruntulenmeSayisi").DefaultCellStyle.Format = "#,##0"
        
        dgvUrunler.Columns.Add("FavoriSayisi", "Favori")
        dgvUrunler.Columns("FavoriSayisi").Width = 60
        dgvUrunler.Columns("FavoriSayisi").DefaultCellStyle.Format = "#,##0"
        
        dgvUrunler.Columns.Add("FavoriOrani", "Favori %")
        dgvUrunler.Columns("FavoriOrani").Width = 65
        dgvUrunler.Columns("FavoriOrani").DefaultCellStyle.Format = "#0.00'%'"
        
        dgvUrunler.Columns.Add("SepetSayisi", "Sepet")
        dgvUrunler.Columns("SepetSayisi").Width = 60
        dgvUrunler.Columns("SepetSayisi").DefaultCellStyle.Format = "#,##0"
        
        dgvUrunler.Columns.Add("SepetOrani", "Sepet %")
        dgvUrunler.Columns("SepetOrani").Width = 65
        dgvUrunler.Columns("SepetOrani").DefaultCellStyle.Format = "#0.00'%'"
        
        dgvUrunler.Columns.Add("SatisSayisi", "Satis")
        dgvUrunler.Columns("SatisSayisi").Width = 60
        dgvUrunler.Columns("SatisSayisi").DefaultCellStyle.Format = "#,##0"
        
        dgvUrunler.Columns.Add("DonusumOrani", "Donusum %")
        dgvUrunler.Columns("DonusumOrani").Width = 70
        dgvUrunler.Columns("DonusumOrani").DefaultCellStyle.Format = "#0.00'%'"
        
        dgvUrunler.Columns.Add("Performans", "Performans")
        dgvUrunler.Columns("Performans").Width = 80
        
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
        Dim pnlStatus As New Panel()
        pnlStatus.Dock = DockStyle.Fill
        pnlStatus.BackColor = Color.FromArgb(50, 50, 60)
        tlp.Controls.Add(pnlStatus, 0, 3)
        
        lblDurum = New Label()
        lblDurum.Dock = DockStyle.Left
        lblDurum.ForeColor = Color.White
        lblDurum.AutoSize = True
        lblDurum.Padding = New Padding(5)
        lblDurum.Text = "Hazır. Verileri yüklemek için 'Verileri Yükle' butonuna tıklayın."
        pnlStatus.Controls.Add(lblDurum)
        
        progressBar = New ProgressBar()
        progressBar.Dock = DockStyle.Right
        progressBar.Width = 200
        pnlStatus.Controls.Add(progressBar)
    End Sub
    
    Private Sub frm_FavoriSepetAnalizi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            EticaretLogger.LogInfo("Favori/Sepet Analizi formu yükleniyor...")
            
            ' Connection string kontrolu - bos ise global KeyCode'dan al
            If String.IsNullOrEmpty(connection) Then
                connection = KeyCode.connection
            End If
            
            LoadKategoriler()
            
            ' Kaydedilmis gorunumu yukle
            GorunumYukle()
            
            EticaretLogger.LogInfo("Favori/Sepet Analizi formu yüklendi.")
        Catch ex As Exception
            EticaretLogger.LogError("Favori/Sepet formu yükleme hatası", ex)
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
    
    Private Async Sub btnYenile_Click(sender As Object, e As EventArgs)
        Try
            btnYenile.Enabled = False
            progressBar.Value = 0
            lblDurum.Text = "Veriler yükleniyor..."
            analizVerileri.Clear()
            
            EticaretLogger.LogInfo("Favori/Sepet analizi başlatıldı.")
            
            Await Task.Run(Sub() LoadAnalysisDataFromCache())
            
            DisplayResults()
            UpdateSummary()
            
            lblDurum.Text = $"Yükleme tamamlandı. {analizVerileri.Count} ürün analiz edildi."
            EticaretLogger.LogInfo($"Favori/Sepet analizi tamamlandı. {analizVerileri.Count} ürün.")
            
        Catch ex As Exception
            EticaretLogger.LogError("Veri yükleme hatası", ex)
            MessageBox.Show($"Veri yükleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnYenile.Enabled = True
            progressBar.Value = 100
        End Try
    End Sub
    
    ''' <summary>
    ''' Merkezi cache sisteminden veri yükler
    ''' Cache süresi dolmuşsa otomatik güncellenir
    ''' </summary>
    Private Sub LoadAnalysisDataFromCache()
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
                
                EticaretLogger.LogInfo($"LoadAnalysisDataFromCache başlatıldı. Pazaryeri={pazaryeri}")
                
                ' Merkezi cache'den veri al (otomatik güncelleme dahil)
                Me.Invoke(Sub() lblDurum.Text = "Cache verisi alınıyor...")
                
                Dim cacheData As List(Of ETicaretAnalizData) = PazaryeriAPIHelper.GetAllAnalizData(
                    conn, 
                    pazaryeri, 
                    kategori,
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
                        MessageBox.Show("Cache'den veri alınamadı. Log dosyasını kontrol edin: C:\eticaret\log", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Sub)
                    Return
                End If
                
                ' Cache verisini form veri modeline dönüştür
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
                    
                    Dim analiz As New UrunAnaliz()
                    analiz.nStokID = cacheItem.nStokID
                    analiz.StokKodu = cacheItem.StokKodu
                    analiz.ModelKodu = cacheItem.Model
                    analiz.Barkod = cacheItem.Barkod
                    analiz.Renk = cacheItem.Renk
                    analiz.Beden = cacheItem.Beden
                    analiz.Kavala = ""
                    analiz.UrunAdi = cacheItem.UrunAdi
                    analiz.Kategori = cacheItem.Kategori
                    
                    ' Cache'den gelen veriler
                    analiz.SatisSayisi = cacheItem.Satis30Gun
                    analiz.GoruntulenmeSayisi = cacheItem.GoruntulenmeSayisi
                    analiz.FavoriSayisi = cacheItem.FavoriSayisi
                    analiz.SepetSayisi = cacheItem.SepetSayisi
                    analiz.FavoriOrani = cacheItem.FavoriOrani
                    analiz.SepetOrani = cacheItem.SepetOrani
                    analiz.DonusumOrani = cacheItem.DonusumOrani
                    analiz.SepettenSatisOrani = If(cacheItem.SepetSayisi > 0, Math.Round(CDec(cacheItem.Satis30Gun) / CDec(cacheItem.SepetSayisi) * 100, 2), 0)
                    
                    ' Performans ve tavsiye hesapla
                    CalculatePerformance(analiz)
                    
                    analizVerileri.Add(analiz)
                Next
                
                EticaretLogger.LogInfo($"Cache'den {analizVerileri.Count} ürün yüklendi")
            End Using
        Catch ex As Exception
            EticaretLogger.LogError("LoadAnalysisDataFromCache hatası", ex)
            Me.Invoke(Sub()
                lblDurum.Text = $"HATA: {ex.Message}"
                MessageBox.Show($"Analiz hatası: {ex.Message}" & vbCrLf & vbCrLf & "Log: C:\eticaret\log", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Sub)
        End Try
    End Sub
    
    ' Eski fonksiyon - artık kullanılmıyor, cache sistemi kullanılıyor
    Private Sub LoadAnalysisData_OLD()
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
                
                ' Gercek satis verilerinden performans analizi
                ' NOT: Favori ve Sepet sayilari API'den gelmeli - su an satis bazli hesaplanir
                Dim sql As String = "SELECT " &
                    "s.nStokID, s.sKodu AS sStokKodu, s.sModel, " &
                    "ISNULL((SELECT TOP 1 b.sBarkod FROM tbStokBarkodu b WHERE b.nStokID = s.nStokID), '') AS sBarkod, " &
                    "ISNULL(s.sRenk, '') AS sRenk, ISNULL(s.sBeden, '') AS sBeden, ISNULL(s.sKavala, '') AS sKavala, " &
                    "s.sAciklama, " &
                    "(SELECT sAciklama FROM tbSSinif4 WHERE sSinifKodu=si.sSinifKodu4) AS Kategori, " &
                    "ISNULL((SELECT TOP 1 f.lFiyat FROM tbStokFiyati f WHERE f.nStokID = s.nStokID AND f.sFiyatTipi = '" & fiyatTipi & "' ORDER BY f.dteFiyatTespitTarihi DESC), 0) AS Fiyat, " &
                    "ISNULL((SELECT SUM(d.lCikisMiktar1) FROM tbStokFisiDetayi d " &
                    "  INNER JOIN tbStokFisiMaster m ON d.nStokFisiID = m.nStokFisiID " &
                    "  LEFT JOIN tbStokFisiAciklamasi a ON m.nStokFisiID = a.nStokFisiID " &
                    "  WHERE d.nStokID = s.nStokID AND m.sFisTipi = 'FS ' AND d.lCikisMiktar1 > 0 " &
                    "  AND m.dteFisTarihi >= DATEADD(day, -7, GETDATE()) " & pazaryeriWhere & "), 0) AS Son7GunSatis, " &
                    "ISNULL((SELECT SUM(d.lCikisMiktar1) FROM tbStokFisiDetayi d " &
                    "  INNER JOIN tbStokFisiMaster m ON d.nStokFisiID = m.nStokFisiID " &
                    "  LEFT JOIN tbStokFisiAciklamasi a ON m.nStokFisiID = a.nStokFisiID " &
                    "  WHERE d.nStokID = s.nStokID AND m.sFisTipi = 'FS ' AND d.lCikisMiktar1 > 0 " &
                    "  AND m.dteFisTarihi >= DATEADD(day, -30, GETDATE()) " & pazaryeriWhere & "), 0) AS Son30GunSatis, " &
                    "ISNULL((SELECT COUNT(DISTINCT m.nStokFisiID) FROM tbStokFisiDetayi d " &
                    "  INNER JOIN tbStokFisiMaster m ON d.nStokFisiID = m.nStokFisiID " &
                    "  LEFT JOIN tbStokFisiAciklamasi a ON m.nStokFisiID = a.nStokFisiID " &
                    "  WHERE d.nStokID = s.nStokID AND m.sFisTipi = 'FS ' " &
                    "  AND m.dteFisTarihi >= DATEADD(day, -30, GETDATE()) " & pazaryeriWhere & "), 0) AS SiparisSayisi " &
                    "FROM tbStok s " &
                    "LEFT JOIN tbStokSinifi si ON si.nStokID = s.nStokID " &
                    "WHERE s.bWebGoruntule = 1 AND s.nStokTipi < 5 "
                
                If cmbKategori.SelectedIndex > 0 Then
                    sql &= " AND (SELECT sAciklama FROM tbSSinif4 WHERE sSinifKodu=si.sSinifKodu4) = ?"
                End If
                
                sql &= " ORDER BY s.nStokID DESC"
                
                EticaretLogger.LogDatabase("SELECT", "tbStok, tbStokFisiDetayi, tbStokFisiMaster", 0, sql)
                
                Dim cmd As New OleDbCommand(sql, conn)
                cmd.CommandTimeout = 120
                
                If cmbKategori.SelectedIndex > 0 Then
                    cmd.Parameters.AddWithValue("?", cmbKategori.SelectedItem.ToString())
                End If
                
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
                        
                        Dim analiz As New UrunAnaliz()
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
                        analiz.SonGuncelleme = DateTime.Now
                        
                        ' Gercek veriler
                        Dim son7 As Integer = If(IsDBNull(reader("Son7GunSatis")), 0, CInt(reader("Son7GunSatis")))
                        Dim son30 As Integer = If(IsDBNull(reader("Son30GunSatis")), 0, CInt(reader("Son30GunSatis")))
                        Dim siparisSayisi As Integer = If(IsDBNull(reader("SiparisSayisi")), 0, CInt(reader("SiparisSayisi")))
                        Dim fiyat As Decimal = If(IsDBNull(reader("Fiyat")), 0D, CDec(reader("Fiyat")))
                        
                        analiz.SatisSayisi = son30
                        
                        ' Trendyol Seller API'den ürün bilgisi çek
                        Dim apiVerisiGeldi As Boolean = False
                        If Not String.IsNullOrEmpty(analiz.Barkod) AndAlso analiz.Barkod.Length >= 8 Then
                            Try
                                Dim productInfo As TrendyolProductInfo = PazaryeriAPIHelper.GetTrendyolProductInfo(analiz.Barkod)
                                If productInfo.Success Then
                                    ' API'den fiyat bilgisi geldi
                                    If productInfo.SalePrice > 0 Then
                                        fiyat = productInfo.SalePrice
                                    End If
                                    apiVerisiGeldi = True
                                End If
                            Catch ex As Exception
                                EticaretLogger.LogError($"API hatası (barkod: {analiz.Barkod})", ex)
                            End Try
                        End If
                        
                        ' Satış verilerine dayalı tahmini hesapla
                        If son30 > 0 Then
                            ' Sektör ortalamalarına göre tahmin:
                            analiz.GoruntulenmeSayisi = son30 * 65
                            analiz.SepetSayisi = son30 * 4
                            analiz.FavoriSayisi = CInt(son30 * 2.5)
                            
                            ' Oranları hesapla
                            If analiz.GoruntulenmeSayisi > 0 Then
                                analiz.FavoriOrani = Math.Round(CDec(analiz.FavoriSayisi) / CDec(analiz.GoruntulenmeSayisi) * 100, 2)
                                analiz.SepetOrani = Math.Round(CDec(analiz.SepetSayisi) / CDec(analiz.GoruntulenmeSayisi) * 100, 2)
                                analiz.DonusumOrani = Math.Round(CDec(son30) / CDec(analiz.GoruntulenmeSayisi) * 100, 2)
                            End If
                            
                            If analiz.SepetSayisi > 0 Then
                                analiz.SepettenSatisOrani = Math.Round(CDec(son30) / CDec(analiz.SepetSayisi) * 100, 2)
                            End If
                        Else
                            analiz.GoruntulenmeSayisi = 0
                            analiz.FavoriSayisi = 0
                            analiz.SepetSayisi = 0
                            analiz.FavoriOrani = 0
                            analiz.SepetOrani = 0
                            analiz.DonusumOrani = 0
                            analiz.SepettenSatisOrani = 0
                        End If
                        
                        ' Performans ve tavsiye hesapla
                        CalculatePerformance(analiz)
                        
                        analizVerileri.Add(analiz)
                    End While
                    
                    EticaretLogger.LogInfo($"Favori/Sepet analizi tamamlandi: {sayac} urun")
                End Using
                
            End Using
        Catch ex As Exception
            EticaretLogger.LogError("LoadAnalysisData hatası", ex)
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
    
    Private Sub CalculatePerformance(analiz As UrunAnaliz)
        ' Performans skorlama
        Dim skor As Integer = 0
        
        ' Favori oranı değerlendirmesi (sektör ortalaması ~2-5%)
        If analiz.FavoriOrani >= 5 Then
            skor += 3
        ElseIf analiz.FavoriOrani >= 2 Then
            skor += 2
        ElseIf analiz.FavoriOrani >= 1 Then
            skor += 1
        End If
        
        ' Sepet oranı değerlendirmesi (sektör ortalaması ~3-8%)
        If analiz.SepetOrani >= 8 Then
            skor += 3
        ElseIf analiz.SepetOrani >= 4 Then
            skor += 2
        ElseIf analiz.SepetOrani >= 2 Then
            skor += 1
        End If
        
        ' Dönüşüm oranı değerlendirmesi (sektör ortalaması ~1-3%)
        If analiz.DonusumOrani >= 3 Then
            skor += 3
        ElseIf analiz.DonusumOrani >= 1.5 Then
            skor += 2
        ElseIf analiz.DonusumOrani >= 0.5 Then
            skor += 1
        End If
        
        ' Performans belirleme
        If skor >= 7 Then
            analiz.Performans = "⭐ YÜKSEK"
            analiz.Tavsiye = "Mükemmel performans! Stok seviyesini artırın."
        ElseIf skor >= 4 Then
            analiz.Performans = "🟡 ORTA"
            analiz.Tavsiye = "Görsel ve açıklamaları iyileştirin."
        Else
            analiz.Performans = "🔴 DÜŞÜK"
            
            ' Spesifik tavsiye
            If analiz.FavoriOrani < 1 Then
                analiz.Tavsiye = "Favori düşük: Görsel kalitesini artırın, fiyatı gözden geçirin."
            ElseIf analiz.SepetOrani < 2 Then
                analiz.Tavsiye = "Sepet düşük: Ürün açıklamasını zenginleştirin."
            Else
                analiz.Tavsiye = "Dönüşüm düşük: Fiyat/kargo optimizasyonu yapın."
            End If
        End If
    End Sub
    
    Private Sub DisplayResults()
        Try
            dgvUrunler.Rows.Clear()
            
            Dim sortedData = SortData(analizVerileri)
            
            For Each urunAnaliz As UrunAnaliz In sortedData
                Dim rowIndex = dgvUrunler.Rows.Add()
                Dim row = dgvUrunler.Rows(rowIndex)
                
                row.Cells("nStokID").Value = urunAnaliz.nStokID
                row.Cells("StokKodu").Value = urunAnaliz.StokKodu
                row.Cells("ModelKodu").Value = urunAnaliz.ModelKodu
                row.Cells("Barkod").Value = urunAnaliz.Barkod
                row.Cells("UrunAdi").Value = urunAnaliz.UrunAdi
                row.Cells("Renk").Value = urunAnaliz.Renk
                row.Cells("Beden").Value = urunAnaliz.Beden
                row.Cells("Kavala").Value = urunAnaliz.Kavala
                row.Cells("Kategori").Value = urunAnaliz.Kategori
                row.Cells("GoruntulenmeSayisi").Value = urunAnaliz.GoruntulenmeSayisi
                row.Cells("FavoriSayisi").Value = urunAnaliz.FavoriSayisi
                row.Cells("FavoriOrani").Value = urunAnaliz.FavoriOrani
                row.Cells("SepetSayisi").Value = urunAnaliz.SepetSayisi
                row.Cells("SepetOrani").Value = urunAnaliz.SepetOrani
                row.Cells("SatisSayisi").Value = urunAnaliz.SatisSayisi
                row.Cells("DonusumOrani").Value = urunAnaliz.DonusumOrani
                row.Cells("Performans").Value = urunAnaliz.Performans
                row.Cells("Tavsiye").Value = urunAnaliz.Tavsiye
                
                ' Renklendirme
                If urunAnaliz.Performans.Contains("YÜKSEK") Then
                    row.DefaultCellStyle.BackColor = Color.FromArgb(232, 245, 233)
                ElseIf urunAnaliz.Performans.Contains("DÜŞÜK") Then
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 238)
                End If
            Next
            
        Catch ex As Exception
            EticaretLogger.LogError("DisplayResults hatası", ex)
        End Try
    End Sub
    
    Private Function SortData(data As List(Of UrunAnaliz)) As List(Of UrunAnaliz)
        Select Case cmbSiralama.SelectedIndex
            Case 0 : Return data.OrderByDescending(Function(x) x.FavoriOrani).ToList()
            Case 1 : Return data.OrderBy(Function(x) x.FavoriOrani).ToList()
            Case 2 : Return data.OrderByDescending(Function(x) x.SepetOrani).ToList()
            Case 3 : Return data.OrderBy(Function(x) x.SepetOrani).ToList()
            Case 4 : Return data.OrderByDescending(Function(x) x.DonusumOrani).ToList()
            Case 5 : Return data.OrderBy(Function(x) x.DonusumOrani).ToList()
            Case 6 : Return data.OrderByDescending(Function(x) x.FavoriSayisi).ToList()
            Case 7 : Return data.OrderByDescending(Function(x) x.SepetSayisi).ToList()
            Case Else : Return data
        End Select
    End Function
    
    Private Sub UpdateSummary()
        Try
            If analizVerileri.Count = 0 Then Return
            
            Dim toplam As Integer = analizVerileri.Count
            Dim ortFavori As Decimal = 0
            Dim ortSepet As Decimal = 0
            Dim ortDonusum As Decimal = 0
            Dim yuksek As Integer = 0
            Dim dusuk As Integer = 0
            
            For Each item As UrunAnaliz In analizVerileri
                ortFavori += item.FavoriOrani
                ortSepet += item.SepetOrani
                ortDonusum += item.DonusumOrani
                If item.Performans.Contains("YÜKSEK") Then yuksek += 1
                If item.Performans.Contains("DÜŞÜK") Then dusuk += 1
            Next
            
            ortFavori = ortFavori / toplam
            ortSepet = ortSepet / toplam
            ortDonusum = ortDonusum / toplam
            
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
                                    Case "toplam" : lbl.Text = toplam.ToString()
                                    Case "favoriOran" : lbl.Text = $"%{ortFavori:F1}"
                                    Case "sepetOran" : lbl.Text = $"%{ortSepet:F1}"
                                    Case "donusum" : lbl.Text = $"%{ortDonusum:F2}"
                                    Case "yuksek" : lbl.Text = yuksek.ToString()
                                    Case "dusuk" : lbl.Text = dusuk.ToString()
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
    
    Private Sub cmbSiralama_Changed(sender As Object, e As EventArgs)
        If analizVerileri.Count > 0 Then
            DisplayResults()
        End If
    End Sub
    
    Private Sub btnExport_Click(sender As Object, e As EventArgs)
        Try
            If analizVerileri.Count = 0 Then
                MessageBox.Show("Aktarılacak veri yok. Önce verileri yükleyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "CSV Dosyası|*.csv"
            saveDialog.FileName = $"FavoriSepetAnalizi_{DateTime.Now:yyyyMMdd_HHmmss}.csv"
            
            If saveDialog.ShowDialog() = DialogResult.OK Then
                Using writer As New System.IO.StreamWriter(saveDialog.FileName, False, System.Text.Encoding.UTF8)
                    ' Başlık satırı
                    writer.WriteLine("Ürün Adı;Kategori;Görüntülenme;Favori;Favori %;Sepet;Sepet %;Satış;Dönüşüm %;Performans;Tavsiye")
                    
                    ' Veri satırları
                    For Each urunAnaliz As UrunAnaliz In analizVerileri
                        writer.WriteLine($"{urunAnaliz.UrunAdi};{urunAnaliz.Kategori};{urunAnaliz.GoruntulenmeSayisi};{urunAnaliz.FavoriSayisi};{urunAnaliz.FavoriOrani};{urunAnaliz.SepetSayisi};{urunAnaliz.SepetOrani};{urunAnaliz.SatisSayisi};{urunAnaliz.DonusumOrani};{urunAnaliz.Performans};{urunAnaliz.Tavsiye}")
                    Next
                End Using
                
                MessageBox.Show($"Veriler başarıyla aktarıldı:{vbCrLf}{saveDialog.FileName}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                EticaretLogger.LogInfo($"Favori/Sepet analizi Excel'e aktarıldı: {saveDialog.FileName}")
            End If
            
        Catch ex As Exception
            EticaretLogger.LogError("Excel aktarma hatası", ex)
            MessageBox.Show($"Aktarma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

End Class
