' ============================================================================
' YORUM ANALİZİ FORMU
' Dosya: frm_YorumAnalizi.vb
' Tarih: 2026-02-20
' Açıklama: Ürün yorumlarını analiz eder ve içgörüler sunar
' NOT: frm_qukaGonder.vb'den BAĞIMSIZ çalışır
' ============================================================================

Imports System.Windows.Forms
Imports System.Drawing
Imports System.Data.OleDb
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks

''' <summary>
''' Yorum analizi formu
''' Müşteri yorumlarından içgörüler çıkarır
''' </summary>
Public Class frm_YorumAnalizi
    Inherits Form

#Region "Değişkenler"
    Public connection As String = ""
    Private WithEvents dgvUrunler As DataGridView
    Private WithEvents dgvYorumlar As DataGridView
    Private pnlFiltre As Panel
    Private pnlOzet As Panel
    Private btnYukle As Button
    Private cmbDuygDurumu As ComboBox
    Private cmbPazaryeri As ComboBox
    Private lblDurum As Label
    Private progressBar As ProgressBar
    
    Private analizVerileri As New List(Of YorumAnaliz)
#End Region

#Region "Veri Yapıları"
    Public Class YorumAnaliz
        Public Property nStokID As Integer
        Public Property StokKodu As String
        Public Property ModelKodu As String
        Public Property Barkod As String
        Public Property Renk As String
        Public Property Beden As String
        Public Property Kavala As String
        Public Property UrunAdi As String
        Public Property Kategori As String
        Public Property ToplamYorum As Integer
        Public Property OrtPuan As Decimal
        Public Property PozitifYorum As Integer
        Public Property NotrYorum As Integer
        Public Property NegatifYorum As Integer
        Public Property PozitifOran As Decimal
        Public Property NegatifOran As Decimal
        Public Property EnSikKelimeler As String
        Public Property SikSikayet As String
        Public Property SikOvergu As String
        Public Property Durum As String
        Public Property Tavsiye As String
    End Class
    
    Public Class Yorum
        Public Property YorumID As Integer
        Public Property Puan As Integer
        Public Property YorumMetni As String
        Public Property Tarih As DateTime
        Public Property Duygu As String
    End Class
#End Region

#Region "Constructor ve Form"
    Public Sub New()
        InitializeComponent()
    End Sub
    
    Private Sub InitializeComponent()
        Me.Text = "💬 Yorum Analizi"
        Me.Size = New Size(1400, 850)
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
        CreateGrids(tlp)
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
        
        ' Duygu Durumu Filtresi
        Dim lblDuygu As New Label()
        lblDuygu.Text = "Duygu Durumu:"
        lblDuygu.AutoSize = True
        lblDuygu.Margin = New Padding(0, 10, 5, 0)
        flow.Controls.Add(lblDuygu)
        
        cmbDuygDurumu = New ComboBox()
        cmbDuygDurumu.Width = 150
        cmbDuygDurumu.DropDownStyle = ComboBoxStyle.DropDownList
        cmbDuygDurumu.Items.AddRange({"-- Tümü --", "Pozitif", "Notr", "Negatif", "Kritik (Çok Negatif)"})
        cmbDuygDurumu.SelectedIndex = 0
        flow.Controls.Add(cmbDuygDurumu)
        
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
        
        ' Yükle butonu
        btnYukle = New Button()
        btnYukle.Text = "📊 Yorumları Analiz Et"
        btnYukle.Width = 170
        btnYukle.Height = 38
        btnYukle.BackColor = Color.FromArgb(63, 81, 181)
        btnYukle.ForeColor = Color.White
        btnYukle.FlatStyle = FlatStyle.Flat
        btnYukle.Margin = New Padding(30, 5, 0, 0)
        AddHandler btnYukle.Click, AddressOf btnYukle_Click
        flow.Controls.Add(btnYukle)
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
        
        CreateCard(flow, "📦 Ürün Sayısı", "0", Color.FromArgb(63, 81, 181), "urun")
        CreateCard(flow, "💬 Toplam Yorum", "0", Color.FromArgb(156, 39, 176), "yorum")
        CreateCard(flow, "⭐ Ort. Puan", "0.0", Color.FromArgb(255, 193, 7), "puan")
        CreateCard(flow, "😊 Pozitif", "%0", Color.FromArgb(76, 175, 80), "pozitif")
        CreateCard(flow, "😐 Notr", "%0", Color.FromArgb(158, 158, 158), "notr")
        CreateCard(flow, "😞 Negatif", "%0", Color.FromArgb(244, 67, 54), "negatif")
    End Sub
    
    Private Sub CreateCard(parent As FlowLayoutPanel, title As String, value As String, color As Color, tag As String)
        Dim pnl As New Panel()
        pnl.Size = New Size(165, 75)
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
    
    Private Sub CreateGrids(tlp As TableLayoutPanel)
        Dim split As New SplitContainer()
        split.Dock = DockStyle.Fill
        split.Orientation = Orientation.Horizontal
        split.SplitterDistance = 350
        tlp.Controls.Add(split, 0, 2)
        
        ' Ürünler Grid
        dgvUrunler = New DataGridView()
        ConfigureGrid(dgvUrunler)
        split.Panel1.Controls.Add(dgvUrunler)
        
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
        
        dgvUrunler.Columns.Add("ToplamYorum", "Yorum")
        dgvUrunler.Columns("ToplamYorum").Width = 60
        
        dgvUrunler.Columns.Add("OrtPuan", "Ort. Puan")
        dgvUrunler.Columns("OrtPuan").Width = 70
        dgvUrunler.Columns("OrtPuan").DefaultCellStyle.Format = "#0.0"
        
        dgvUrunler.Columns.Add("PozitifOran", "Pozitif %")
        dgvUrunler.Columns("PozitifOran").Width = 70
        dgvUrunler.Columns("PozitifOran").DefaultCellStyle.Format = "#0'%'"
        
        dgvUrunler.Columns.Add("NegatifOran", "Negatif %")
        dgvUrunler.Columns("NegatifOran").Width = 70
        dgvUrunler.Columns("NegatifOran").DefaultCellStyle.Format = "#0'%'"
        
        dgvUrunler.Columns.Add("Durum", "Durum")
        dgvUrunler.Columns("Durum").Width = 90
        
        dgvUrunler.Columns.Add("SikSikayet", "Sık Şikayet")
        dgvUrunler.Columns("SikSikayet").Width = 120
        
        dgvUrunler.Columns.Add("Tavsiye", "Tavsiye")
        dgvUrunler.Columns("Tavsiye").Width = 200
        
        ' Yorumlar Grid (Alt panel - seçili ürünün yorumları)
        dgvYorumlar = New DataGridView()
        ConfigureGrid(dgvYorumlar)
        split.Panel2.Controls.Add(dgvYorumlar)
        
        dgvYorumlar.Columns.Add("Puan", "Puan")
        dgvYorumlar.Columns("Puan").Width = 60
        
        dgvYorumlar.Columns.Add("Duygu", "Duygu")
        dgvYorumlar.Columns("Duygu").Width = 100
        
        dgvYorumlar.Columns.Add("YorumMetni", "Yorum")
        dgvYorumlar.Columns("YorumMetni").FillWeight = 70
        
        dgvYorumlar.Columns.Add("Tarih", "Tarih")
        dgvYorumlar.Columns("Tarih").Width = 100
    End Sub
    
    Private Sub ConfigureGrid(grid As DataGridView)
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
        grid.ColumnHeadersHeight = 32
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
        lblDurum.Text = "Hazır. Yorumları analiz etmek için butona tıklayın."
        pnl.Controls.Add(lblDurum)
        
        progressBar = New ProgressBar()
        progressBar.Dock = DockStyle.Right
        progressBar.Width = 200
        pnl.Controls.Add(progressBar)
    End Sub
    
    Private Sub frm_YorumAnalizi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            EticaretLogger.LogInfo("Yorum Analizi formu yükleniyor...")
            
            ' Connection string kontrolu - bos ise global KeyCode'dan al
            If String.IsNullOrEmpty(connection) Then
                connection = KeyCode.connection
            End If
            
            ' Kaydedilmis gorunumleri yukle
            GorunumYukle(dgvUrunler)
            GorunumYukle(dgvYorumlar)
            
            EticaretLogger.LogInfo("Yorum Analizi formu yüklendi.")
        Catch ex As Exception
            EticaretLogger.LogError("Yorum Analizi formu yükleme hatası", ex)
        End Try
    End Sub
#End Region

#Region "Veri İşlemleri"
    Private Async Sub btnYukle_Click(sender As Object, e As EventArgs)
        Try
            btnYukle.Enabled = False
            progressBar.Value = 0
            lblDurum.Text = "Yorumlar analiz ediliyor..."
            analizVerileri.Clear()
            
            EticaretLogger.LogInfo("Yorum analizi başlatıldı.")
            
            Await Task.Run(Sub() AnalyzeYorumlarFromCache())
            
            DisplayResults()
            UpdateSummary()
            
            lblDurum.Text = $"Analiz tamamlandı. {analizVerileri.Count} ürün analiz edildi."
            EticaretLogger.LogInfo($"Yorum analizi tamamlandı. {analizVerileri.Count} ürün.")
            
        Catch ex As Exception
            EticaretLogger.LogError("Yorum analizi hatası", ex)
            MessageBox.Show($"Analiz hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnYukle.Enabled = True
            progressBar.Value = 100
        End Try
    End Sub
    
    ''' <summary>
    ''' Merkezi cache sisteminden yorum verilerini yükler
    ''' </summary>
    Private Sub AnalyzeYorumlarFromCache()
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
                
                EticaretLogger.LogInfo($"AnalyzeYorumlarFromCache başlatıldı. Pazaryeri={pazaryeri}")
                
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
                
                ' Cache verisini Yorum modeline dönüştür
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
                    
                    Dim analiz As New YorumAnaliz()
                    analiz.nStokID = cacheItem.nStokID
                    analiz.StokKodu = cacheItem.StokKodu
                    analiz.ModelKodu = cacheItem.Model
                    analiz.Barkod = cacheItem.Barkod
                    analiz.Renk = cacheItem.Renk
                    analiz.Beden = cacheItem.Beden
                    analiz.Kavala = ""
                    analiz.UrunAdi = cacheItem.UrunAdi
                    analiz.Kategori = cacheItem.Kategori
                    
                    ' Cache'den gelen yorum verileri
                    analiz.ToplamYorum = cacheItem.YorumSayisi
                    analiz.OrtPuan = cacheItem.OrtalamaPuan
                    analiz.PozitifYorum = cacheItem.PozitifYorum
                    analiz.NegatifYorum = cacheItem.NegatifYorum
                    analiz.NotrYorum = cacheItem.NotrYorum
                    analiz.SikSikayet = If(String.IsNullOrEmpty(cacheItem.SikSikayet), "Yorum yok", cacheItem.SikSikayet)
                    analiz.SikOvergu = If(String.IsNullOrEmpty(cacheItem.SikOvergu), "Yorum yok", cacheItem.SikOvergu)
                    
                    ' Oranları hesapla
                    If analiz.ToplamYorum > 0 Then
                        analiz.PozitifOran = Math.Round(CDec(analiz.PozitifYorum) / CDec(analiz.ToplamYorum) * 100, 1)
                        analiz.NegatifOran = Math.Round(CDec(analiz.NegatifYorum) / CDec(analiz.ToplamYorum) * 100, 1)
                    End If
                    
                    ' Duygu analizi ve tavsiye
                    CalculateSentiment(analiz)
                    
                    analizVerileri.Add(analiz)
                Next
                
                EticaretLogger.LogInfo($"Cache'den {analizVerileri.Count} yorum analizi yüklendi")
            End Using
        Catch ex As Exception
            EticaretLogger.LogError("AnalyzeYorumlarFromCache hatası", ex)
            Me.Invoke(Sub()
                lblDurum.Text = $"HATA: {ex.Message}"
                MessageBox.Show($"Analiz hatası: {ex.Message}" & vbCrLf & vbCrLf & "Log: C:\eticaret\log", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Sub)
        End Try
    End Sub
    
    ' Eski fonksiyon - artık kullanılmıyor, cache sistemi kullanılıyor
    Private Sub AnalyzeYorumlar_OLD()
        Try
            Using conn As New OleDbConnection(connection)
                conn.Open()
                
                ' Pazaryeri prefix'i belirle
                Dim pazaryeri As String = If(cmbPazaryeri IsNot Nothing AndAlso cmbPazaryeri.SelectedIndex >= 0, cmbPazaryeri.Text, "Tumu")
                Dim pazaryeriPrefix As String = GetPazaryeriPrefix(pazaryeri)
                
                ' Pazaryeri filtresi
                Dim pazaryeriWhere As String = ""
                If pazaryeriPrefix <> "" Then
                    If pazaryeriPrefix.Length = 3 Then
                        pazaryeriWhere = " AND LEFT(ISNULL(a.sAciklama3,''),3) = '" & pazaryeriPrefix & "' "
                    Else
                        pazaryeriWhere = " AND LEFT(ISNULL(a.sAciklama3,''),2) = '" & pazaryeriPrefix & "' "
                    End If
                End If
                
                ' Gercek satis ve iade verilerine dayali yorum tahmini
                ' NOT: Gercek yorum verileri icin Trendyol/Hepsiburada API entegrasyonu gerekli
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
                    "  AND m.dteFisTarihi >= DATEADD(day, -90, GETDATE()) " & pazaryeriWhere & "), 0) AS ToplamIade " &
                    "FROM tbStok s " &
                    "LEFT JOIN tbStokSinifi si ON si.nStokID = s.nStokID " &
                    "WHERE s.bWebGoruntule = 1 AND s.nStokTipi < 5 " &
                    "ORDER BY s.nStokID DESC"
                
                EticaretLogger.LogDatabase("SELECT", "tbStok, tbStokFisiDetayi, tbStokFisiMaster", 0, sql)
                
                Dim cmd As New OleDbCommand(sql, conn)
                cmd.CommandTimeout = 120
                
                Using reader = cmd.ExecuteReader()
                    Dim sayac As Integer = 0
                    
                    While reader.Read()
                        sayac += 1
                        
                        If sayac Mod 50 = 0 Then
                            Me.Invoke(Sub()
                                progressBar.Value = Math.Min(sayac, 100)
                                lblDurum.Text = $"Analiz: {sayac} ürün..."
                            End Sub)
                        End If
                        
                        Dim analiz As New YorumAnaliz()
                        analiz.nStokID = CInt(reader("nStokID"))
                        analiz.StokKodu = If(IsDBNull(reader("sStokKodu")), "", reader("sStokKodu").ToString())
                        analiz.ModelKodu = If(IsDBNull(reader("sModel")), "", reader("sModel").ToString())
                        analiz.Barkod = If(IsDBNull(reader("sBarkod")), "", reader("sBarkod").ToString())
                        analiz.Renk = If(IsDBNull(reader("sRenk")), "", reader("sRenk").ToString())
                        analiz.Beden = If(IsDBNull(reader("sBeden")), "", reader("sBeden").ToString())
                        analiz.Kavala = If(IsDBNull(reader("sKavala")), "", reader("sKavala").ToString())
                        analiz.UrunAdi = If(IsDBNull(reader("sAciklama")), "", reader("sAciklama").ToString())
                        
                        ' Gercek veriler
                        Dim toplamSatis As Integer = If(IsDBNull(reader("ToplamSatis")), 0, CInt(reader("ToplamSatis")))
                        Dim toplamIade As Integer = If(IsDBNull(reader("ToplamIade")), 0, CInt(reader("ToplamIade")))
                        Dim kategori As String = If(IsDBNull(reader("Kategori")), "", reader("Kategori").ToString())
                        
                        ' Satis ve iade verilerine dayali yorum tahmini
                        ' Genellikle satis miktarinin %10-20'si kadar yorum gelir
                        CalculateYorumFromSales(analiz, toplamSatis, toplamIade, kategori)
                        
                        ' Duygu analizi ve tavsiye
                        CalculateSentiment(analiz)
                        
                        ' Filtre
                        Dim ekle As Boolean = True
                        If cmbDuygDurumu.SelectedIndex > 0 Then
                            Select Case cmbDuygDurumu.SelectedIndex
                                Case 1 : ekle = analiz.PozitifOran > 60
                                Case 2 : ekle = analiz.PozitifOran >= 40 AndAlso analiz.PozitifOran <= 60
                                Case 3 : ekle = analiz.NegatifOran > 30
                                Case 4 : ekle = analiz.NegatifOran > 50
                            End Select
                        End If
                        
                        If ekle Then analizVerileri.Add(analiz)
                    End While
                    
                    EticaretLogger.LogInfo($"Yorum analizi tamamlandi: {sayac} urun")
                End Using
                
            End Using
        Catch ex As Exception
            EticaretLogger.LogError("AnalyzeYorumlar hatası", ex)
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
    
    Private Sub CalculateYorumFromSales(analiz As YorumAnaliz, toplamSatis As Integer, toplamIade As Integer, kategori As String)
        ' Trendyol Seller API'den ürün bilgisi çek
        If Not String.IsNullOrEmpty(analiz.Barkod) AndAlso analiz.Barkod.Length >= 8 Then
            Try
                ' Önce ürün bilgisini al
                Dim productInfo As TrendyolProductInfo = PazaryeriAPIHelper.GetTrendyolProductInfo(analiz.Barkod)
                
                If productInfo.Success AndAlso Not String.IsNullOrEmpty(productInfo.ProductId) Then
                    ' Yorum API'sini çağır
                    Dim reviews As List(Of TrendyolReview) = PazaryeriAPIHelper.GetTrendyolReviews(productInfo.ProductId)
                    
                    If reviews IsNot Nothing AndAlso reviews.Count > 0 Then
                        analiz.ToplamYorum = reviews.Count
                        
                        ' Puan dağılımı hesapla
                        Dim toplam As Decimal = 0
                        Dim pozitif As Integer = 0
                        Dim negatif As Integer = 0
                        Dim notr As Integer = 0
                        
                        For Each review As TrendyolReview In reviews
                            toplam += review.Rating
                            If review.Rating >= 4 Then
                                pozitif += 1
                            ElseIf review.Rating <= 2 Then
                                negatif += 1
                            Else
                                notr += 1
                            End If
                        Next
                        
                        analiz.OrtPuan = Math.Round(toplam / reviews.Count, 1)
                        analiz.PozitifYorum = pozitif
                        analiz.NegatifYorum = negatif
                        analiz.NotrYorum = notr
                        
                        ' Oranları hesapla
                        analiz.PozitifOran = Math.Round(CDec(pozitif) / CDec(reviews.Count) * 100, 1)
                        analiz.NegatifOran = Math.Round(CDec(negatif) / CDec(reviews.Count) * 100, 1)
                        
                        ' Şikayet/Övgü analizi
                        analiz.SikSikayet = GetSikSikayetFromReviews(reviews)
                        analiz.SikOvergu = GetSikOverguFromReviews(reviews)
                        
                        Return ' Başarılı - fonksiyondan çık
                    End If
                End If
            Catch ex As Exception
                EticaretLogger.LogError($"Yorum API hatası: {analiz.Barkod}", ex)
            End Try
        End If
        
        ' API'den veri gelmezse satış verilerine göre tahmin
        If toplamSatis > 0 Then
            ' Tahmini yorum sayısı (satışın ~%5-10'u yorum yapar)
            analiz.ToplamYorum = CInt(toplamSatis * 0.07)
            
            ' İade oranına göre tahmini puan
            Dim iadeOrani As Decimal = If(toplamSatis > 0, CDec(toplamIade) / CDec(toplamSatis) * 100, 0)
            
            If iadeOrani < 5 Then
                analiz.OrtPuan = 4.5D
                analiz.PozitifOran = 85
                analiz.NegatifOran = 5
                analiz.SikSikayet = "Çok az şikayet"
                analiz.SikOvergu = "Kalite, Hızlı kargo"
            ElseIf iadeOrani < 10 Then
                analiz.OrtPuan = 4.0D
                analiz.PozitifOran = 70
                analiz.NegatifOran = 15
                analiz.SikSikayet = "Kargo süresi"
                analiz.SikOvergu = "Fiyat/Performans"
            ElseIf iadeOrani < 20 Then
                analiz.OrtPuan = 3.5D
                analiz.PozitifOran = 50
                analiz.NegatifOran = 30
                analiz.SikSikayet = "Beden/Ölçü sorunu"
                analiz.SikOvergu = "Uygun fiyat"
            Else
                analiz.OrtPuan = 3.0D
                analiz.PozitifOran = 30
                analiz.NegatifOran = 50
                analiz.SikSikayet = "Kalite sorunu"
                analiz.SikOvergu = "-"
            End If
            
            analiz.PozitifYorum = CInt(analiz.ToplamYorum * analiz.PozitifOran / 100)
            analiz.NegatifYorum = CInt(analiz.ToplamYorum * analiz.NegatifOran / 100)
            analiz.NotrYorum = analiz.ToplamYorum - analiz.PozitifYorum - analiz.NegatifYorum
        Else
            ' Hiç satış yoksa
            analiz.ToplamYorum = 0
            analiz.OrtPuan = 0
            analiz.PozitifYorum = 0
            analiz.NegatifYorum = 0
            analiz.NotrYorum = 0
            analiz.PozitifOran = 0
            analiz.NegatifOran = 0
            analiz.SikSikayet = "Yorum yok"
            analiz.SikOvergu = "Yorum yok"
        End If
    End Sub
    
    Private Function GetSikSikayetFromReviews(reviews As List(Of TrendyolReview)) As String
        ' Negatif yorumları analiz et
        Dim negatifYorumlar = reviews.FindAll(Function(r) r.Rating <= 2 AndAlso Not String.IsNullOrEmpty(r.Comment))
        If negatifYorumlar.Count = 0 Then Return "Şikayet yok"
        
        ' Basit keyword analizi
        Dim kargo As Integer = 0
        Dim beden As Integer = 0
        Dim kalite As Integer = 0
        Dim renk As Integer = 0
        
        For Each r As TrendyolReview In negatifYorumlar
            Dim yorum = r.Comment.ToLower()
            If yorum.Contains("kargo") OrElse yorum.Contains("teslimat") Then kargo += 1
            If yorum.Contains("beden") OrElse yorum.Contains("ölçü") OrElse yorum.Contains("küçük") OrElse yorum.Contains("büyük") Then beden += 1
            If yorum.Contains("kalite") OrElse yorum.Contains("kumaş") OrElse yorum.Contains("malzeme") Then kalite += 1
            If yorum.Contains("renk") OrElse yorum.Contains("fotoğraf") Then renk += 1
        Next
        
        If beden >= kargo AndAlso beden >= kalite AndAlso beden >= renk Then Return "Beden/Ölçü"
        If kalite >= kargo AndAlso kalite >= renk Then Return "Kalite"
        If kargo >= renk Then Return "Kargo"
        Return "Renk farkı"
    End Function
    
    Private Function GetSikOverguFromReviews(reviews As List(Of TrendyolReview)) As String
        ' Pozitif yorumları analiz et
        Dim pozitifYorumlar = reviews.FindAll(Function(r) r.Rating >= 4 AndAlso Not String.IsNullOrEmpty(r.Comment))
        If pozitifYorumlar.Count = 0 Then Return "Övgü yok"
        
        Dim kalite As Integer = 0
        Dim fiyat As Integer = 0
        Dim kargo As Integer = 0
        
        For Each r As TrendyolReview In pozitifYorumlar
            Dim yorum = r.Comment.ToLower()
            If yorum.Contains("kalite") OrElse yorum.Contains("güzel") OrElse yorum.Contains("harika") Then kalite += 1
            If yorum.Contains("fiyat") OrElse yorum.Contains("ucuz") OrElse yorum.Contains("uygun") Then fiyat += 1
            If yorum.Contains("kargo") OrElse yorum.Contains("hızlı") Then kargo += 1
        Next
        
        If kalite >= fiyat AndAlso kalite >= kargo Then Return "Kalite"
        If fiyat >= kargo Then Return "Fiyat/Performans"
        Return "Hızlı kargo"
    End Function
    
    Private Function GetSikOverguByKategori(kategori As String) As String
        Return ""
    End Function
    
    Private Sub CalculateSentiment(analiz As YorumAnaliz)
        ' Durum belirleme
        If analiz.OrtPuan >= 4.5 AndAlso analiz.NegatifOran < 10 Then
            analiz.Durum = "⭐ MÜKEMMEL"
            analiz.Tavsiye = "Harika! Bu ürünü öne çıkarın, reklam verin"
        ElseIf analiz.OrtPuan >= 4.0 AndAlso analiz.NegatifOran < 20 Then
            analiz.Durum = "😊 İYİ"
            analiz.Tavsiye = "İyi performans, devam edin"
        ElseIf analiz.OrtPuan >= 3.5 Then
            analiz.Durum = "😐 ORTA"
            analiz.Tavsiye = $"İyileştirme gerekli: {analiz.SikSikayet} sorununa odaklanın"
        ElseIf analiz.OrtPuan >= 3.0 Then
            analiz.Durum = "😟 DÜŞÜK"
            analiz.Tavsiye = $"DİKKAT: {analiz.SikSikayet} - Ürünü gözden geçirin"
        Else
            analiz.Durum = "🔴 KRİTİK"
            analiz.Tavsiye = $"ACİL: Ürün açıklamasını ve kaliteyi kontrol edin"
        End If
    End Sub
    
    Private Sub DisplayResults()
        Try
            dgvUrunler.Rows.Clear()
            
            ' Sıralama
            Dim sorted As New List(Of YorumAnaliz)
            For Each item As YorumAnaliz In analizVerileri
                sorted.Add(item)
            Next
            sorted.Sort(Function(x, y) x.OrtPuan.CompareTo(y.OrtPuan))
            
            For Each yorumAnaliz As YorumAnaliz In sorted
                Dim row = dgvUrunler.Rows.Add()
                dgvUrunler.Rows(row).Cells("nStokID").Value = yorumAnaliz.nStokID
                dgvUrunler.Rows(row).Cells("StokKodu").Value = yorumAnaliz.StokKodu
                dgvUrunler.Rows(row).Cells("ModelKodu").Value = yorumAnaliz.ModelKodu
                dgvUrunler.Rows(row).Cells("Barkod").Value = yorumAnaliz.Barkod
                dgvUrunler.Rows(row).Cells("UrunAdi").Value = yorumAnaliz.UrunAdi
                dgvUrunler.Rows(row).Cells("Renk").Value = yorumAnaliz.Renk
                dgvUrunler.Rows(row).Cells("Beden").Value = yorumAnaliz.Beden
                dgvUrunler.Rows(row).Cells("Kavala").Value = yorumAnaliz.Kavala
                dgvUrunler.Rows(row).Cells("ToplamYorum").Value = yorumAnaliz.ToplamYorum
                dgvUrunler.Rows(row).Cells("OrtPuan").Value = yorumAnaliz.OrtPuan
                dgvUrunler.Rows(row).Cells("PozitifOran").Value = yorumAnaliz.PozitifOran
                dgvUrunler.Rows(row).Cells("NegatifOran").Value = yorumAnaliz.NegatifOran
                dgvUrunler.Rows(row).Cells("Durum").Value = yorumAnaliz.Durum
                dgvUrunler.Rows(row).Cells("SikSikayet").Value = yorumAnaliz.SikSikayet
                dgvUrunler.Rows(row).Cells("Tavsiye").Value = yorumAnaliz.Tavsiye
                
                ' Renklendirme
                If yorumAnaliz.Durum.Contains("KRİTİK") Then
                    dgvUrunler.Rows(row).DefaultCellStyle.BackColor = Color.FromArgb(255, 205, 210)
                ElseIf yorumAnaliz.Durum.Contains("DÜŞÜK") Then
                    dgvUrunler.Rows(row).DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 178)
                ElseIf yorumAnaliz.Durum.Contains("MÜKEMMEL") Then
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
            
            Dim urunSayisi As Integer = analizVerileri.Count
            Dim toplamYorum As Integer = 0
            Dim ortPuan As Decimal = 0
            Dim ortPozitif As Decimal = 0
            Dim ortNotr As Decimal = 0
            Dim ortNegatif As Decimal = 0
            
            For Each item As YorumAnaliz In analizVerileri
                toplamYorum += item.ToplamYorum
                ortPuan += item.OrtPuan
                ortPozitif += item.PozitifOran
                ortNegatif += item.NegatifOran
            Next
            
            ortPuan = ortPuan / urunSayisi
            ortPozitif = ortPozitif / urunSayisi
            ortNegatif = ortNegatif / urunSayisi
            ortNotr = 100 - ortPozitif - ortNegatif
            
            For Each ctrlObj As Object In pnlOzet.Controls(0).Controls
                If TypeOf ctrlObj Is Panel Then
                    Dim pnl As Panel = DirectCast(ctrlObj, Panel)
                    Dim tag As String = If(pnl.Tag IsNot Nothing, pnl.Tag.ToString(), "")
                    
                    For Each lblObj As Object In pnl.Controls
                        If TypeOf lblObj Is Label Then
                            Dim lbl As Label = DirectCast(lblObj, Label)
                            If lbl.Tag IsNot Nothing AndAlso lbl.Tag.ToString() = "value" Then
                                Select Case tag
                                    Case "urun" : lbl.Text = urunSayisi.ToString()
                                    Case "yorum" : lbl.Text = toplamYorum.ToString()
                                    Case "puan" : lbl.Text = ortPuan.ToString("0.0")
                                    Case "pozitif" : lbl.Text = $"%{ortPozitif:F0}"
                                    Case "notr" : lbl.Text = $"%{ortNotr:F0}"
                                    Case "negatif" : lbl.Text = $"%{ortNegatif:F0}"
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
    
    Private Sub dgvUrunler_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUrunler.SelectionChanged
        Try
            dgvYorumlar.Rows.Clear()
            
            If dgvUrunler.CurrentRow Is Nothing Then Return
            If dgvUrunler.CurrentRow.Cells("nStokID").Value Is Nothing Then Return
            If dgvUrunler.CurrentRow.Cells("Barkod").Value Is Nothing Then Return
            
            Dim barkod As String = dgvUrunler.CurrentRow.Cells("Barkod").Value.ToString()
            
            Dim pazaryeri As String = "Tumu"
            If cmbPazaryeri IsNot Nothing AndAlso cmbPazaryeri.SelectedIndex > 0 Then
                pazaryeri = cmbPazaryeri.Text
            End If
            
            ' Gercek API'den yorumlari cek
            If Not String.IsNullOrEmpty(barkod) Then
                If pazaryeri = "Trendyol" OrElse pazaryeri = "Tumu" Then
                    Try
                        Dim productInfo As TrendyolProductInfo = PazaryeriAPIHelper.GetTrendyolProductInfo(barkod)
                        
                        If productInfo.Success AndAlso Not String.IsNullOrEmpty(productInfo.ProductId) Then
                            Dim reviews As List(Of TrendyolReview) = PazaryeriAPIHelper.GetTrendyolReviews(productInfo.ProductId)
                            
                            If reviews.Count > 0 Then
                                For Each reviewItem As TrendyolReview In reviews
                                    Dim puan As Integer = reviewItem.Rating
                                    Dim duygu As String = If(puan >= 4, "Pozitif", If(puan = 3, "Notr", "Negatif"))
                                    
                                    Dim row As Integer = dgvYorumlar.Rows.Add()
                                    dgvYorumlar.Rows(row).Cells("Puan").Value = New String("*"c, puan)
                                    dgvYorumlar.Rows(row).Cells("Duygu").Value = duygu
                                    dgvYorumlar.Rows(row).Cells("YorumMetni").Value = reviewItem.Comment
                                    dgvYorumlar.Rows(row).Cells("Tarih").Value = reviewItem.ReviewDate.ToString("dd.MM.yyyy")
                                Next
                                lblDurum.Text = $"Trendyol API - {reviews.Count} yorum"
                            Else
                                lblDurum.Text = "Bu urun icin yorum bulunamadi"
                            End If
                        Else
                            lblDurum.Text = "API ayarlarini kontrol edin (Pazaryeri API Ayarlari)"
                        End If
                    Catch apiEx As Exception
                        EticaretLogger.LogError("Trendyol yorum API hatasi", apiEx)
                        lblDurum.Text = "API hatasi: " & apiEx.Message
                    End Try
                End If
            Else
                lblDurum.Text = "Urun barkodu bulunamadi"
            End If
            
        Catch ex As Exception
            EticaretLogger.LogError("dgvUrunler_SelectionChanged hatasi", ex)
        End Try
    End Sub
#End Region

End Class
