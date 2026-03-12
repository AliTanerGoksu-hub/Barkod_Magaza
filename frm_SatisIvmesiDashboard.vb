' ============================================================================
' SATIŞ İVMESİ DASHBOARD
' Dosya: frm_SatisIvmesiDashboard.vb
' Tarih: 2026-02-19
' Açıklama: Trendyol algoritmasının en kritik faktörü olan satış hızı takibi
' ============================================================================
' AMAÇ:
'   - Günlük/haftalık/aylık satış hızı analizi
'   - Trend tespiti (yükseliş/düşüş/stabil)
'   - Hız düşen ürünler için uyarı
'   - Kampanya önerisi
' ============================================================================

Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data
Imports System.Data.OleDb
Imports System.Collections.Generic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraCharts

Public Class frm_SatisIvmesiDashboard
    Inherits Form
    
    Public connection As String = ""
    
    ' UI Bileşenleri
    Private WithEvents grdUrunler As GridControl
    Private grdViewUrunler As GridView
    Private WithEvents chartTrend As ChartControl
    Private WithEvents cmbPazaryeri As ComboBoxEdit
    Private WithEvents cmbKategori As ComboBoxEdit
    Private WithEvents dteTarihBaslangic As DateEdit
    Private WithEvents dteTarihBitis As DateEdit
    Private WithEvents btnYenile As SimpleButton
    Private WithEvents btnVerileriCek As SimpleButton
    Private WithEvents btnExcelExport As SimpleButton
    Private WithEvents btnLogAc As SimpleButton
    Private lblOzet As LabelControl
    Private lblSonGuncelleme As LabelControl
    Private pnlOzet As Panel
    
    ' Özet kartları
    Private lblToplamUrun As LabelControl
    private lblYukselisteUrun As LabelControl
    Private lblDususteUrun As LabelControl
    Private lblStabilUrun As LabelControl
    
    ' Veri tablosu
    Private _dtUrunler As DataTable
    
    Public Sub New()
        InitializeComponent()
        ' InitializeDataTable burada cagrilmaz - CreateControls icinde grid olusturulduktan sonra cagrilir
    End Sub
    
#Region "Form Initialization"
    
    Private Sub InitializeComponent()
        Me.Text = "Satis Ivmesi Dashboard - Pazaryeri Analizi"
        Me.Size = New Size(1400, 850)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = SystemIcons.Application
        
        CreateControls()
        LayoutControls()
    End Sub
    
    Private Sub CreateControls()
        ' === BAŞLIK PANELİ ===
        Dim pnlHeader As New Panel()
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Height = 60
        pnlHeader.BackColor = Color.FromArgb(0, 150, 136)
        
        Dim lblTitle As New Label()
        lblTitle.Text = "SATIŞ İVMESİ DASHBOARD"
        lblTitle.Font = New Font("Segoe UI", 18, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(20, 15)
        lblTitle.AutoSize = True
        pnlHeader.Controls.Add(lblTitle)
        
        Dim lblSubtitle As New Label()
        lblSubtitle.Text = "Pazaryeri Satis Performansi Analizi"
        lblSubtitle.Font = New Font("Segoe UI", 9)
        lblSubtitle.ForeColor = Color.FromArgb(200, 255, 255)
        lblSubtitle.Location = New Point(400, 22)
        lblSubtitle.AutoSize = True
        pnlHeader.Controls.Add(lblSubtitle)
        
        Me.Controls.Add(pnlHeader)
        
        ' === FİLTRE PANELİ ===
        Dim pnlFilter As New Panel()
        pnlFilter.Location = New Point(10, 70)
        pnlFilter.Size = New Size(1370, 50)
        pnlFilter.BackColor = Color.FromArgb(245, 245, 245)
        
        ' Kategori
        Dim lblKategori As New LabelControl()
        lblKategori.Text = "Kategori:"
        lblKategori.Location = New Point(220, 17)
        pnlFilter.Controls.Add(lblKategori)
        
        cmbKategori = New ComboBoxEdit()
        cmbKategori.Location = New Point(280, 13)
        cmbKategori.Size = New Size(150, 20)
        cmbKategori.Properties.Items.Add("Tümü")
        cmbKategori.SelectedIndex = 0
        pnlFilter.Controls.Add(cmbKategori)
        
        ' Tarih Aralığı
        Dim lblTarih As New LabelControl()
        lblTarih.Text = "Tarih:"
        lblTarih.Location = New Point(450, 17)
        pnlFilter.Controls.Add(lblTarih)
        
        dteTarihBaslangic = New DateEdit()
        dteTarihBaslangic.Location = New Point(495, 13)
        dteTarihBaslangic.Size = New Size(100, 20)
        dteTarihBaslangic.DateTime = DateTime.Now.AddDays(-30)
        pnlFilter.Controls.Add(dteTarihBaslangic)
        
        Dim lblTarihAra As New LabelControl()
        lblTarihAra.Text = "-"
        lblTarihAra.Location = New Point(600, 17)
        pnlFilter.Controls.Add(lblTarihAra)
        
        dteTarihBitis = New DateEdit()
        dteTarihBitis.Location = New Point(615, 13)
        dteTarihBitis.Size = New Size(100, 20)
        dteTarihBitis.DateTime = DateTime.Now
        pnlFilter.Controls.Add(dteTarihBitis)
        
        ' Pazaryeri Filtresi
        Dim lblPazaryeri As New LabelControl()
        lblPazaryeri.Text = "Pazaryeri:"
        lblPazaryeri.Location = New Point(730, 17)
        pnlFilter.Controls.Add(lblPazaryeri)
        
        cmbPazaryeri = New ComboBoxEdit()
        cmbPazaryeri.Location = New Point(795, 13)
        cmbPazaryeri.Size = New Size(120, 20)
        cmbPazaryeri.Properties.Items.AddRange(New String() {"Tumu", "Trendyol", "Hepsiburada", "N11", "Amazon", "PttAVM", "Pazarama", "CicekSepeti", "Modanisa", "Farmazon", "Idefix", "LCWaikiki"})
        cmbPazaryeri.SelectedIndex = 0
        pnlFilter.Controls.Add(cmbPazaryeri)
        
        ' Butonlar - yan yana duzgun yerlesim
        btnYenile = New SimpleButton()
        btnYenile.Text = "Yenile"
        btnYenile.Location = New Point(930, 10)
        btnYenile.Size = New Size(70, 28)
        btnYenile.Appearance.BackColor = Color.FromArgb(33, 150, 243)
        btnYenile.Appearance.ForeColor = Color.White
        pnlFilter.Controls.Add(btnYenile)
        
        btnVerileriCek = New SimpleButton()
        btnVerileriCek.Text = "API Cek"
        btnVerileriCek.Location = New Point(1005, 10)
        btnVerileriCek.Size = New Size(70, 28)
        btnVerileriCek.Appearance.BackColor = Color.FromArgb(76, 175, 80)
        btnVerileriCek.Appearance.ForeColor = Color.White
        pnlFilter.Controls.Add(btnVerileriCek)
        
        btnExcelExport = New SimpleButton()
        btnExcelExport.Text = "Excel"
        btnExcelExport.Location = New Point(1080, 10)
        btnExcelExport.Size = New Size(60, 28)
        btnExcelExport.Appearance.BackColor = Color.FromArgb(255, 152, 0)
        btnExcelExport.Appearance.ForeColor = Color.White
        pnlFilter.Controls.Add(btnExcelExport)
        
        btnLogAc = New SimpleButton()
        btnLogAc.Text = "Log"
        btnLogAc.Location = New Point(1145, 10)
        btnLogAc.Size = New Size(50, 28)
        btnLogAc.Appearance.BackColor = Color.Gray
        btnLogAc.Appearance.ForeColor = Color.White
        pnlFilter.Controls.Add(btnLogAc)
        
        lblSonGuncelleme = New LabelControl()
        lblSonGuncelleme.Text = ""
        lblSonGuncelleme.Location = New Point(1200, 17)
        lblSonGuncelleme.ForeColor = Color.Gray
        pnlFilter.Controls.Add(lblSonGuncelleme)
        
        Me.Controls.Add(pnlFilter)
        
        ' === ÖZET KARTLARI ===
        pnlOzet = New Panel()
        pnlOzet.Location = New Point(10, 130)
        pnlOzet.Size = New Size(1370, 80)
        
        ' Toplam Ürün Kartı
        CreateSummaryCard(pnlOzet, 0, "TOPLAM ÜRÜN", "0", Color.FromArgb(33, 150, 243), lblToplamUrun)
        
        ' Yükselişte Kartı
        CreateSummaryCard(pnlOzet, 1, "YÜKSELİŞTE", "0", Color.FromArgb(76, 175, 80), lblYukselisteUrun)
        
        ' Düşüşte Kartı
        CreateSummaryCard(pnlOzet, 2, "DÜŞÜŞTE", "0", Color.FromArgb(244, 67, 54), lblDususteUrun)
        
        ' Stabil Kartı
        CreateSummaryCard(pnlOzet, 3, "STABİL", "0", Color.FromArgb(255, 193, 7), lblStabilUrun)
        
        Me.Controls.Add(pnlOzet)
        
        ' === ÜRÜN LİSTESİ GRID ===
        grdUrunler = New GridControl()
        grdUrunler.Location = New Point(10, 220)
        grdUrunler.Size = New Size(900, 400)
        
        grdViewUrunler = New GridView(grdUrunler)
        grdUrunler.MainView = grdViewUrunler
        grdViewUrunler.OptionsBehavior.Editable = False
        grdViewUrunler.OptionsView.ShowGroupPanel = False
        grdViewUrunler.OptionsView.RowAutoHeight = True
        
        Me.Controls.Add(grdUrunler)
        
        ' === TREND GRAFİĞİ ===
        chartTrend = New ChartControl()
        chartTrend.Location = New Point(920, 220)
        chartTrend.Size = New Size(460, 400)
        
        ' Grafik başlığı
        chartTrend.Titles.Add(New ChartTitle())
        chartTrend.Titles(0).Text = "Son 7 Günlük Satış Trendi"
        chartTrend.Titles(0).Font = New Font("Segoe UI", 11, FontStyle.Bold)
        
        Me.Controls.Add(chartTrend)
        
        ' === ALT BİLGİ PANELİ ===
        Dim pnlBottom As New Panel()
        pnlBottom.Location = New Point(10, 630)
        pnlBottom.Size = New Size(1370, 180)
        pnlBottom.BackColor = Color.FromArgb(250, 250, 250)
        pnlBottom.BorderStyle = BorderStyle.FixedSingle
        
        Dim lblAciklama As New Label()
        lblAciklama.Text = "TRENDYOL ALGORİTMASI BİLGİSİ" & vbCrLf & vbCrLf &
                          "• Satış İvmesi: Son 3 gündeki satışlar, son 3 aydaki satışlardan daha önemli!" & vbCrLf &
                          "• Favori + Sepet Oranı: Yüksek ilgi gören ürünler öne çıkar" & vbCrLf &
                          "• Dış Trafik: Sosyal medya ve reklamlardan gelen trafik değerlidir" & vbCrLf &
                          "• Satıcı Puanı: 9.5+ puan kritik öneme sahip" & vbCrLf &
                          "• İade Oranı: Düşük iade oranı sıralamayı yükseltir" & vbCrLf & vbCrLf &
                          "ÖNERİ: Düşüşte olan ürünler için kampanya/indirim yaparak satış ivmesini artırın!"
        lblAciklama.Font = New Font("Segoe UI", 9)
        lblAciklama.Location = New Point(15, 10)
        lblAciklama.Size = New Size(700, 160)
        pnlBottom.Controls.Add(lblAciklama)
        
        ' Kampanya Önerisi Listesi
        Dim lstKampanyaOneri As New ListBox()
        lstKampanyaOneri.Location = New Point(730, 10)
        lstKampanyaOneri.Size = New Size(625, 160)
        lstKampanyaOneri.Font = New Font("Consolas", 9)
        lstKampanyaOneri.Items.Add("=== KAMPANYA ÖNERİLERİ ===")
        lstKampanyaOneri.Items.Add("(Veriler yüklendikten sonra düşüşte olan ürünler burada listelenecek)")
        pnlBottom.Controls.Add(lstKampanyaOneri)
        
        Me.Controls.Add(pnlBottom)
        
        ' Grid ve DataTable'i baslat
        InitializeDataTable()
        LayoutControls()
    End Sub
    
    Private Sub CreateSummaryCard(parent As Panel, index As Integer, title As String, value As String, color As Color, ByRef valueLabel As LabelControl)
        Dim card As New Panel()
        card.Location = New Point(index * 340 + 5, 5)
        card.Size = New Size(330, 70)
        card.BackColor = color
        
        Dim lblCardTitle As New Label()
        lblCardTitle.Text = title
        lblCardTitle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lblCardTitle.ForeColor = Color.White
        lblCardTitle.Location = New Point(15, 10)
        lblCardTitle.AutoSize = True
        card.Controls.Add(lblCardTitle)
        
        valueLabel = New LabelControl()
        valueLabel.Text = value
        valueLabel.Font = New Font("Segoe UI", 24, FontStyle.Bold)
        valueLabel.ForeColor = Color.White
        valueLabel.Location = New Point(15, 32)
        valueLabel.AutoSize = True
        card.Controls.Add(valueLabel)
        
        parent.Controls.Add(card)
    End Sub
    
    Private Sub LayoutControls()
        ' Grid sütunlarını ayarla
        If grdViewUrunler Is Nothing Then Return
        
        grdViewUrunler.Columns.Clear()
        
        AddGridColumn("sModel", "Model", 80)
        AddGridColumn("sUrunAdi", "Urun Adi", 180)
        AddGridColumn("sPazaryeri", "Pazaryeri", 80)
        AddGridColumn("nSon3Gun", "Son 3 Gun", 70)
        AddGridColumn("nSon7Gun", "Son 7 Gun", 70)
        AddGridColumn("nSon30Gun", "Son 30 Gun", 80)
        AddGridColumn("sTrend", "Trend", 80)
        AddGridColumn("nTrendYuzde", "Trend %", 60)
        AddGridColumn("nStok", "Stok", 60)
        AddGridColumn("lFiyat", "Fiyat", 70)
        AddGridColumn("sOneri", "Oneri", 150)
    End Sub
    
    Private Sub AddGridColumn(fieldName As String, caption As String, width As Integer)
        If grdViewUrunler Is Nothing Then Return
        
        Dim col As New DevExpress.XtraGrid.Columns.GridColumn()
        col.FieldName = fieldName
        col.Caption = caption
        col.Width = width
        col.Visible = True
        grdViewUrunler.Columns.Add(col)
    End Sub
    
    Private Sub InitializeDataTable()
        _dtUrunler = New DataTable()
        _dtUrunler.Columns.Add("nStokID", GetType(Integer))
        _dtUrunler.Columns.Add("sModel", GetType(String))
        _dtUrunler.Columns.Add("sUrunAdi", GetType(String))
        _dtUrunler.Columns.Add("sPazaryeri", GetType(String))
        _dtUrunler.Columns.Add("nSon3Gun", GetType(Integer))
        _dtUrunler.Columns.Add("nSon7Gun", GetType(Integer))
        _dtUrunler.Columns.Add("nSon30Gun", GetType(Integer))
        _dtUrunler.Columns.Add("sTrend", GetType(String))
        _dtUrunler.Columns.Add("nTrendYuzde", GetType(Decimal))
        _dtUrunler.Columns.Add("nStok", GetType(Integer))
        _dtUrunler.Columns.Add("lFiyat", GetType(Decimal))
        _dtUrunler.Columns.Add("sOneri", GetType(String))
        
        If grdUrunler IsNot Nothing Then
            grdUrunler.DataSource = _dtUrunler
        End If
    End Sub

#End Region

#Region "Form Events"
    
    Private Sub frm_SatisIvmesiDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            EticaretLogger.LogInfo("Satış İvmesi Dashboard açıldı")
            
            ' Connection string kontrolu - bos ise global KeyCode'dan al
            If String.IsNullOrEmpty(connection) Then
                connection = KeyCode.connection
            End If
            
            If String.IsNullOrEmpty(connection) Then
                MessageBox.Show("Veritabanı bağlantısı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            
            ' Null kontrolleri
            If _dtUrunler Is Nothing Then
                InitializeDataTable()
            End If
            
            If cmbPazaryeri IsNot Nothing AndAlso cmbPazaryeri.SelectedIndex < 0 Then
                cmbPazaryeri.SelectedIndex = 0
            End If
            
            LoadCategories()
            LoadData()
            
        Catch ex As Exception
            EticaretLogger.LogError("Form yukleme hatasi", ex)
            MessageBox.Show("Veri yukleme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub frm_SatisIvmesiDashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        EticaretLogger.LogInfo("Satış İvmesi Dashboard kapatıldı")
    End Sub

#End Region

#Region "Button Events"
    
    Private Sub btnYenile_Click(sender As Object, e As EventArgs) Handles btnYenile.Click
        EticaretLogger.LogInfo("Satis Ivmesi Dashboard - Yenile tiklandi")
        LoadData()
    End Sub
    
    Private Sub cmbPazaryeri_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPazaryeri.SelectedIndexChanged
        LoadData()
    End Sub
    
    Private Sub btnVerileriCek_Click(sender As Object, e As EventArgs) Handles btnVerileriCek.Click
        EticaretLogger.LogInfo("Satis Ivmesi Dashboard - API'den veri cekme baslatildi")
        FetchDataFromApi()
    End Sub
    
    Private Sub btnExcelExport_Click(sender As Object, e As EventArgs) Handles btnExcelExport.Click
        EticaretLogger.LogInfo("Satış İvmesi Dashboard - Excel export")
        ExportToExcel()
    End Sub
    
    Private Sub btnLogAc_Click(sender As Object, e As EventArgs) Handles btnLogAc.Click
        EticaretLogger.OpenLogFolder()
    End Sub

#End Region

#Region "Data Loading"
    
    Private Sub LoadCategories()
        Try
            If cmbKategori Is Nothing Then Return
            
            cmbKategori.Properties.Items.Clear()
            cmbKategori.Properties.Items.Add("Tümü")
            
            If String.IsNullOrEmpty(connection) Then
                cmbKategori.SelectedIndex = 0
                Return
            End If
            
            Using con As New OleDbConnection(connection)
                con.Open()
                Using cmd As New OleDbCommand("SELECT DISTINCT sAciklama FROM tbSSinif4 WHERE sAciklama IS NOT NULL ORDER BY sAciklama", con)
                    cmd.CommandTimeout = 60
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            If Not IsDBNull(reader("sAciklama")) Then
                                cmbKategori.Properties.Items.Add(reader("sAciklama").ToString())
                            End If
                        End While
                    End Using
                End Using
            End Using
            
            cmbKategori.SelectedIndex = 0
            EticaretLogger.LogInfo($"Kategoriler yüklendi: {cmbKategori.Properties.Items.Count} adet")
            
        Catch ex As Exception
            EticaretLogger.LogError("Kategori yükleme hatası", ex)
            If cmbKategori IsNot Nothing AndAlso cmbKategori.Properties.Items.Count > 0 Then
                cmbKategori.SelectedIndex = 0
            End If
        End Try
    End Sub
    
    Private Sub LoadData()
        Dim sw As Stopwatch = EticaretLogger.StartOperation("LoadSatisIvmesiData")
        
        Try
            ' Null kontrolleri
            If _dtUrunler Is Nothing Then
                InitializeDataTable()
            End If
            
            If grdUrunler Is Nothing OrElse grdViewUrunler Is Nothing Then
                EticaretLogger.LogWarning("Grid kontrolleri henuz hazir degil")
                Return
            End If
            
            If lblToplamUrun Is Nothing OrElse lblYukselisteUrun Is Nothing OrElse lblDususteUrun Is Nothing OrElse lblStabilUrun Is Nothing Then
                EticaretLogger.LogWarning("Ozet label kontrolleri henuz hazir degil")
            End If
            
            _dtUrunler.Clear()
            
            ' Pazaryeri filtresine gore siparis no prefix'i belirle
            Dim pazaryeri As String = "Tumu"
            If cmbPazaryeri IsNot Nothing Then
                Try
                    If cmbPazaryeri.SelectedIndex >= 0 Then
                        pazaryeri = cmbPazaryeri.Text
                    End If
                Catch
                    pazaryeri = "Tumu"
                End Try
            End If
            
            If String.IsNullOrEmpty(pazaryeri) Then pazaryeri = "Tumu"
            
            Dim pazaryeriPrefix As String = ""
            Dim fiyatTipi As String = "2"
            
            Select Case pazaryeri
                Case "Trendyol"
                    pazaryeriPrefix = "TY"
                    fiyatTipi = "2"
                Case "Hepsiburada"
                    pazaryeriPrefix = "HB"
                    fiyatTipi = "3"
                Case "N11"
                    pazaryeriPrefix = "N11"
                    fiyatTipi = "4"
                Case "Amazon"
                    pazaryeriPrefix = "AM"
                    fiyatTipi = "5"
                Case "PttAVM"
                    pazaryeriPrefix = "PT"
                    fiyatTipi = "6"
                Case "Pazarama"
                    pazaryeriPrefix = "PT"
                    fiyatTipi = "7"
                Case "CicekSepeti"
                    pazaryeriPrefix = "CS"
                    fiyatTipi = "8"
                Case "Modanisa"
                    pazaryeriPrefix = "MH"
                    fiyatTipi = "9"
                Case "Farmazon"
                    pazaryeriPrefix = "FA"
                    fiyatTipi = "12"
                Case "Idefix"
                    pazaryeriPrefix = "ID"
                    fiyatTipi = "10"
                Case "LCWaikiki"
                    pazaryeriPrefix = "LCW"
                    fiyatTipi = "11"
                Case Else
                    pazaryeriPrefix = "" ' Tumu
                    fiyatTipi = "2"
            End Select
            
            Using con As New OleDbConnection(connection)
                con.Open()
                
                ' Gercek satis verilerini tbStokFisiMaster, tbStokFisiDetayi ve tbStokFisiAciklamasi'ndan cek
                ' Pazaryeri filtresi: sAciklama3 siparis numarasindan (TY, HB, N11, AM, PT, CS, MH, ID, LCW prefix)
                Dim whereClause As String = ""
                If pazaryeriPrefix <> "" Then
                    ' 3 karakterli prefix'ler: N11, LCW
                    If pazaryeriPrefix.Length = 3 Then
                        whereClause = " AND EXISTS (SELECT 1 FROM tbStokFisiAciklamasi a WHERE a.nStokFisiID = m.nStokFisiID AND LEFT(ISNULL(a.sAciklama3,''),3) = '" & pazaryeriPrefix & "') "
                    Else
                        ' 2 karakterli prefix'ler: TY, HB, AM, PT, CS, MH, ID
                        whereClause = " AND EXISTS (SELECT 1 FROM tbStokFisiAciklamasi a WHERE a.nStokFisiID = m.nStokFisiID AND LEFT(ISNULL(a.sAciklama3,''),2) = '" & pazaryeriPrefix & "') "
                    End If
                End If
                
                Dim sql As String = "SELECT " &
                    "s.nStokID, s.sModel, s.sAciklama AS sUrunAdi, " &
                    "'" & If(pazaryeri = "Tumu", "Tumu", pazaryeri) & "' AS sPazaryeri, " &
                    "ISNULL((SELECT SUM(d.lCikisMiktar1) FROM tbStokFisiDetayi d " &
                    "  INNER JOIN tbStokFisiMaster m ON d.nStokFisiID = m.nStokFisiID " &
                    "  WHERE d.nStokID = s.nStokID AND m.dteFisTarihi >= DATEADD(day, -3, GETDATE()) " &
                    "  AND m.sFisTipi = 'FS ' " & whereClause & "), 0) AS nSon3Gun, " &
                    "ISNULL((SELECT SUM(d.lCikisMiktar1) FROM tbStokFisiDetayi d " &
                    "  INNER JOIN tbStokFisiMaster m ON d.nStokFisiID = m.nStokFisiID " &
                    "  WHERE d.nStokID = s.nStokID AND m.dteFisTarihi >= DATEADD(day, -7, GETDATE()) " &
                    "  AND m.sFisTipi = 'FS ' " & whereClause & "), 0) AS nSon7Gun, " &
                    "ISNULL((SELECT SUM(d.lCikisMiktar1) FROM tbStokFisiDetayi d " &
                    "  INNER JOIN tbStokFisiMaster m ON d.nStokFisiID = m.nStokFisiID " &
                    "  WHERE d.nStokID = s.nStokID AND m.dteFisTarihi >= DATEADD(day, -30, GETDATE()) " &
                    "  AND m.sFisTipi = 'FS ' " & whereClause & "), 0) AS nSon30Gun, " &
                    "ISNULL((SELECT SUM(d.lGirisMiktar1 - d.lCikisMiktar1) FROM tbStokFisiDetayi d WHERE d.nStokID = s.nStokID), 0) AS nStok, " &
                    "ISNULL((SELECT TOP 1 f.lFiyat FROM tbStokFiyati f WHERE f.nStokID = s.nStokID AND f.sFiyatTipi = '" & fiyatTipi & "' ORDER BY f.dteFiyatTespitTarihi DESC), 0) AS lFiyat " &
                    "FROM tbStok s " &
                    "WHERE s.bWebGoruntule = 1 AND s.nStokTipi < 5 " &
                    "ORDER BY s.nStokID DESC"
                
                EticaretLogger.LogDatabase("SELECT", "tbStok, tbStokFisiDetayi, tbStokFisiMaster", 0, sql)
                
                Using cmd As New OleDbCommand(sql, con)
                    cmd.CommandTimeout = 180 ' 3 dakika timeout (karmasik sorgu)
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        Dim rowCount As Integer = 0
                        
                        While reader.Read()
                            Dim row As DataRow = _dtUrunler.NewRow()
                            row("nStokID") = If(IsDBNull(reader("nStokID")), 0, CInt(reader("nStokID")))
                            row("sModel") = If(IsDBNull(reader("sModel")), "", reader("sModel").ToString())
                            row("sUrunAdi") = If(IsDBNull(reader("sUrunAdi")), "", reader("sUrunAdi").ToString())
                            row("sPazaryeri") = If(IsDBNull(reader("sPazaryeri")), "", reader("sPazaryeri").ToString())
                            row("nSon3Gun") = If(IsDBNull(reader("nSon3Gun")), 0, CInt(reader("nSon3Gun")))
                            row("nSon7Gun") = If(IsDBNull(reader("nSon7Gun")), 0, CInt(reader("nSon7Gun")))
                            row("nSon30Gun") = If(IsDBNull(reader("nSon30Gun")), 0, CInt(reader("nSon30Gun")))
                            row("nStok") = If(IsDBNull(reader("nStok")), 0, CInt(reader("nStok")))
                            row("lFiyat") = If(IsDBNull(reader("lFiyat")), 0D, CDec(reader("lFiyat")))
                            
                            ' Trend hesapla
                            Dim son3 As Integer = CInt(row("nSon3Gun"))
                            Dim son7 As Integer = CInt(row("nSon7Gun"))
                            Dim son30 As Integer = CInt(row("nSon30Gun"))
                            
                            Dim trend As String = "Sabit"
                            Dim trendYuzde As Decimal = 0
                            
                            If son30 > 0 Then
                                Dim gunlukOrt30 As Decimal = CDec(son30) / 30
                                Dim gunlukOrt7 As Decimal = CDec(son7) / 7
                                
                                If gunlukOrt30 > 0 Then
                                    trendYuzde = ((gunlukOrt7 - gunlukOrt30) / gunlukOrt30) * 100
                                    
                                    If trendYuzde > 20 Then
                                        trend = "Yukselis"
                                    ElseIf trendYuzde < -20 Then
                                        trend = "Dusus"
                                    End If
                                End If
                            End If
                            
                            row("sTrend") = trend
                            row("nTrendYuzde") = Math.Round(trendYuzde, 1)
                            
                            ' Oneri hesapla
                            row("sOneri") = CalculateRecommendation(row)
                            
                            _dtUrunler.Rows.Add(row)
                            rowCount += 1
                        End While
                        
                        EticaretLogger.LogInfo($"Satis ivmesi verileri yuklendi: {rowCount} urun")
                    End Using
                End Using
            End Using
            
            ' Ozet kartlarini guncelle
            UpdateSummaryCards()
            
            ' Grafik guncelle
            UpdateChart()
            
            ' Son guncelleme zamani
            lblSonGuncelleme.Text = "Son guncelleme: " & DateTime.Now.ToString("HH:mm:ss")
            
            EticaretLogger.EndOperation("LoadSatisIvmesiData", sw, True, _dtUrunler.Rows.Count)
            
        Catch ex As Exception
            EticaretLogger.LogError("Satis ivmesi veri yukleme hatasi", ex)
            EticaretLogger.EndOperation("LoadSatisIvmesiData", sw, False)
            MessageBox.Show("Veri yukleme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Function CalculateRecommendation(row As DataRow) As String
        Dim trend As String = row("sTrend").ToString()
        Dim son3Gun As Integer = CInt(row("nSon3Gun"))
        Dim son30Gun As Integer = CInt(row("nSon30Gun"))
        Dim stok As Integer = CInt(row("nStok"))
        
        If trend = "Dusus" OrElse trend = "Düşüş" Then
            If son3Gun < son30Gun / 10 Then
                Return "ACİL: Kampanya/İndirim Yap!"
            Else
                Return "Fiyat/Görsel Güncelle"
            End If
        ElseIf trend = "Yukselis" OrElse trend = "Yükseliş" Then
            If stok < 10 Then
                Return "Stok Artır!"
            Else
                Return "Devam Et"
            End If
        Else
            If son30Gun = 0 Then
                Return "Ürünü Öne Çıkar"
            Else
                Return "İzlemeye Devam"
            End If
        End If
    End Function
    
    Private Sub UpdateSummaryCards()
        Try
            If _dtUrunler Is Nothing Then Return
            
            Dim toplam As Integer = _dtUrunler.Rows.Count
            Dim yukselis As Integer = 0
            Dim dusus As Integer = 0
            Dim stabil As Integer = 0
            
            For Each row As DataRow In _dtUrunler.Rows
                Dim trend As String = If(row("sTrend") Is Nothing OrElse IsDBNull(row("sTrend")), "", row("sTrend").ToString().ToLower())
                If trend.Contains("yuksel") OrElse trend.Contains("yüksel") Then
                    yukselis += 1
                ElseIf trend.Contains("dus") OrElse trend.Contains("düş") Then
                    dusus += 1
                Else
                    stabil += 1
                End If
            Next
            
            If lblToplamUrun IsNot Nothing Then lblToplamUrun.Text = toplam.ToString()
            If lblYukselisteUrun IsNot Nothing Then lblYukselisteUrun.Text = yukselis.ToString()
            If lblDususteUrun IsNot Nothing Then lblDususteUrun.Text = dusus.ToString()
            If lblStabilUrun IsNot Nothing Then lblStabilUrun.Text = stabil.ToString()
            
            EticaretLogger.LogInfo($"Özet güncellendi - Toplam: {toplam}, Yükseliş: {yukselis}, Düşüş: {dusus}, Stabil: {stabil}")
        Catch ex As Exception
            EticaretLogger.LogError("UpdateSummaryCards hatasi", ex)
        End Try
    End Sub
    
    Private Sub UpdateChart()
        Try
            If chartTrend Is Nothing Then Return
            
            chartTrend.Series.Clear()
            
            ' Gercek veriler API'den gelecek
            Dim series As New Series("Gunluk Satis", ViewType.Line)
            series.ArgumentDataMember = "Tarih"
            series.ValueDataMembers.AddRange(New String() {"Satis"})
            
            ' Bos grafik - API ayarlari yapildiginda veriler gelecek
            chartTrend.Series.Add(series)
            
            ' Grafik görünümü
            Dim lineView As LineSeriesView = TryCast(series.View, LineSeriesView)
            If lineView IsNot Nothing Then
                lineView.Color = Color.FromArgb(0, 150, 136)
                lineView.LineStyle.Thickness = 2
                lineView.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
            End If
            
        Catch ex As Exception
            EticaretLogger.LogError("Grafik güncelleme hatası", ex)
        End Try
    End Sub
    
    Private Sub FetchDataFromApi()
        ' Trendyol API'den satış verilerini çek
        EticaretLogger.LogTrendyol("FetchSalesData", "Satış verileri API'den çekiliyor...")
        
        MessageBox.Show(
            "Bu özellik Trendyol Satıcı Paneli API'si ile entegre edilecek." & vbCrLf & vbCrLf &
            "Mevcut durumda:" & vbCrLf &
            "1. Siparişlerden satış verisi hesaplanıyor" & vbCrLf &
            "2. Manuel veri girişi yapılabilir" & vbCrLf & vbCrLf &
            "API entegrasyonu için Trendyol Satıcı Ofisi'nden rapor API erişimi gereklidir.",
            "API Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        
        ' Mevcut siparişlerden satış hesapla
        CalculateSalesFromOrders()
    End Sub
    
    Private Sub CalculateSalesFromOrders()
        Dim sw As Stopwatch = EticaretLogger.StartOperation("CalculateSalesFromOrders")
        
        Try
            Using con As New OleDbConnection(connection)
                con.Open()
                
                ' tbSatisIvmesiOzet tablosunu güncelle
                ' Gerçek sipariş verilerinden hesaplama
                Dim sqlUpdate As String = "
                    UPDATE sio SET 
                        sio.nSon3GunSatis = ISNULL((
                            SELECT SUM(ABS(d.lCikisMiktar1)) 
                            FROM tbStokFisiDetayi d 
                            INNER JOIN tbStokFisi f ON d.nIslemID = f.nIslemID 
                            WHERE d.nStokID = sio.nStokID 
                            AND f.nHareketTipi IN (2,6,8) 
                            AND f.dteIslemTarihi >= DATEADD(day, -3, GETDATE())
                        ), 0),
                        sio.nSon7GunSatis = ISNULL((
                            SELECT SUM(ABS(d.lCikisMiktar1)) 
                            FROM tbStokFisiDetayi d 
                            INNER JOIN tbStokFisi f ON d.nIslemID = f.nIslemID 
                            WHERE d.nStokID = sio.nStokID 
                            AND f.nHareketTipi IN (2,6,8) 
                            AND f.dteIslemTarihi >= DATEADD(day, -7, GETDATE())
                        ), 0),
                        sio.nSon30GunSatis = ISNULL((
                            SELECT SUM(ABS(d.lCikisMiktar1)) 
                            FROM tbStokFisiDetayi d 
                            INNER JOIN tbStokFisi f ON d.nIslemID = f.nIslemID 
                            WHERE d.nStokID = sio.nStokID 
                            AND f.nHareketTipi IN (2,6,8) 
                            AND f.dteIslemTarihi >= DATEADD(day, -30, GETDATE())
                        ), 0),
                        sio.dteGuncelleme = GETDATE()
                    FROM tbSatisIvmesiOzet sio"
                
                ' Trend hesapla
                Dim sqlTrend As String = "
                    UPDATE tbSatisIvmesiOzet SET 
                        sTrend = CASE 
                            WHEN nSon3GunSatis * 10 > nSon30GunSatis THEN 'Yukselis'
                            WHEN nSon3GunSatis * 10 < nSon30GunSatis * 0.5 THEN 'Dusus'
                            ELSE 'Stabil'
                        END,
                        nTrendYuzdesi = CASE 
                            WHEN nSon30GunSatis > 0 THEN ((CAST(nSon7GunSatis AS DECIMAL) * 30 / 7) - nSon30GunSatis) * 100 / nSon30GunSatis
                            ELSE 0
                        END"
                
                EticaretLogger.LogDatabase("UPDATE", "tbSatisIvmesiOzet", 0, "Satış verileri güncelleniyor...")
                
                ' SQL Server varsa execute et, yoksa log yaz
                Try
                    Using cmd As New OleDbCommand(sqlUpdate, con)
                        cmd.ExecuteNonQuery()
                    End Using
                    
                    Using cmd As New OleDbCommand(sqlTrend, con)
                        cmd.ExecuteNonQuery()
                    End Using
                    
                    EticaretLogger.LogInfo("Satış verileri siparişlerden hesaplandı")
                Catch sqlEx As Exception
                    ' Tablo yoksa oluştur
                    EticaretLogger.LogWarning("tbSatisIvmesiOzet tablosu bulunamadı, oluşturuluyor...")
                    CreateSalesTable(con)
                End Try
            End Using
            
            ' Verileri yeniden yükle
            LoadData()
            
            EticaretLogger.EndOperation("CalculateSalesFromOrders", sw, True)
            
        Catch ex As Exception
            EticaretLogger.LogError("Satış hesaplama hatası", ex)
            EticaretLogger.EndOperation("CalculateSalesFromOrders", sw, False)
        End Try
    End Sub
    
    Private Sub CreateSalesTable(con As OleDbConnection)
        Try
            Dim sqlCreate As String = "
                CREATE TABLE tbSatisIvmesiOzet (
                    nID INT IDENTITY(1,1) PRIMARY KEY,
                    nStokID INT,
                    sModel VARCHAR(50),
                    nSon3GunSatis INT DEFAULT 0,
                    nSon7GunSatis INT DEFAULT 0,
                    nSon30GunSatis INT DEFAULT 0,
                    sTrend VARCHAR(20) DEFAULT 'Bilinmiyor',
                    nTrendYuzdesi DECIMAL(10,2) DEFAULT 0,
                    dteGuncelleme DATETIME DEFAULT GETDATE()
                )"
            
            Using cmd As New OleDbCommand(sqlCreate, con)
                cmd.ExecuteNonQuery()
            End Using
            
            EticaretLogger.LogDatabase("CREATE TABLE", "tbSatisIvmesiOzet", 0, sqlCreate)
            EticaretLogger.LogInfo("tbSatisIvmesiOzet tablosu oluşturuldu")
            
        Catch ex As Exception
            EticaretLogger.LogError("Tablo oluşturma hatası", ex)
        End Try
    End Sub
    
    Private Sub ExportToExcel()
        Try
            Using sfd As New SaveFileDialog()
                sfd.Filter = "Excel Dosyası|*.xlsx"
                sfd.FileName = "SatisIvmesi_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".xlsx"
                
                If sfd.ShowDialog() = DialogResult.OK Then
                    ' DevExpress Excel Export
                    grdViewUrunler.ExportToXlsx(sfd.FileName)
                    
                    EticaretLogger.LogInfo("Excel export tamamlandı: " & sfd.FileName)
                    MessageBox.Show("Excel dosyası oluşturuldu: " & sfd.FileName, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            EticaretLogger.LogError("Excel export hatası", ex)
            MessageBox.Show("Excel oluşturma hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

End Class
