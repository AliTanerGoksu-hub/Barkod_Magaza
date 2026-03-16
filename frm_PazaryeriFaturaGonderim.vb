Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

''' <summary>
''' Pazaryeri Fatura Gönderim Formu
''' GİB'e gönderilmiş faturaları Trendyol ve Hepsiburada'ya toplu olarak gönderir.
''' </summary>
Public Class frm_PazaryeriFaturaGonderim
    Inherits XtraForm

    ' ===== FORM KONTROLLERİ =====
    Private WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As GridView
    Private WithEvents cmbPazaryeri As ComboBoxEdit
    Private WithEvents dtBaslangic As DevExpress.XtraEditors.DateEdit
    Private WithEvents dtBitis As DevExpress.XtraEditors.DateEdit
    Private WithEvents btnListele As SimpleButton
    Private WithEvents btnSecilileriGonder As SimpleButton
    Private WithEvents btnTumunuGonder As SimpleButton
    Private WithEvents lblDurum As LabelControl
    Private WithEvents ProgressBar1 As ProgressBarControl
    Private WithEvents chkTumunuSec As CheckEdit
    Private WithEvents chkGonderilenleriGoster As CheckEdit
    Private WithEvents chkSadeceTeslimEdilenler As CheckEdit
    Private WithEvents PanelControl1 As PanelControl
    Private WithEvents GroupControl1 As GroupControl
    
    ' ===== CONTEXT MENU =====
    Private WithEvents ContextMenu1 As ContextMenu
    Private WithEvents mnuSutunOzellestir As MenuItem
    Private WithEvents mnuGorunumKaydet As MenuItem
    Private WithEvents mnuFiltrele As MenuItem
    Private WithEvents mnuSep1 As MenuItem
    Private WithEvents mnuTeslimDurumuGuncelle As MenuItem

    ' ===== VERİTABANI =====
    Public connection As String = ""
    Private dtFaturalar As New DataTable()

    ' ===== API BİLGİLERİ =====
    Private Class PazaryeriAPI
        Public Property Pazaryeri As String
        Public Property SellerId As String
        Public Property ApiKey As String
        Public Property ApiSecret As String
        Public Property BaseUrl As String
        Public Property Aktif As Boolean
    End Class

    Private pazaryeriApis As New Dictionary(Of String, PazaryeriAPI)

    Public Sub New()
        InitializeComponent()
        ' API'ler Load event'inde yüklenecek (connection atandıktan sonra)
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()

        ' Form ayarları
        Me.Text = "Pazaryeri Fatura Gönderimi"
        Me.Size = New Size(1200, 700)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.Sizable

        ' Panel - Filtreler
        PanelControl1 = New PanelControl()
        PanelControl1.Location = New Point(10, 10)
        PanelControl1.Size = New Size(Me.ClientSize.Width - 20, 80)
        PanelControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Me.Controls.Add(PanelControl1)

        ' Pazaryeri ComboBox
        Dim lblPazaryeri As New LabelControl()
        lblPazaryeri.Text = "Pazaryeri:"
        lblPazaryeri.Location = New Point(10, 15)
        PanelControl1.Controls.Add(lblPazaryeri)

        cmbPazaryeri = New ComboBoxEdit()
        cmbPazaryeri.Location = New Point(80, 12)
        cmbPazaryeri.Size = New Size(150, 26)
        cmbPazaryeri.Properties.Items.AddRange(New String() {"Tümü", "Trendyol", "Hepsiburada", "N11", "Pazarama"})
        cmbPazaryeri.SelectedIndex = 0
        cmbPazaryeri.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        PanelControl1.Controls.Add(cmbPazaryeri)

        ' Tarih filtreleri
        Dim lblBaslangic As New LabelControl()
        lblBaslangic.Text = "Başlangıç:"
        lblBaslangic.Location = New Point(250, 15)
        PanelControl1.Controls.Add(lblBaslangic)

        dtBaslangic = New DevExpress.XtraEditors.DateEdit()
        dtBaslangic.Location = New Point(320, 12)
        dtBaslangic.Size = New Size(120, 26)
        dtBaslangic.EditValue = DateTime.Today.AddDays(-10)  ' Son 10 gün
        PanelControl1.Controls.Add(dtBaslangic)

        Dim lblBitis As New LabelControl()
        lblBitis.Text = "Bitiş:"
        lblBitis.Location = New Point(460, 15)
        PanelControl1.Controls.Add(lblBitis)

        dtBitis = New DevExpress.XtraEditors.DateEdit()
        dtBitis.Location = New Point(500, 12)
        dtBitis.Size = New Size(120, 26)
        dtBitis.EditValue = DateTime.Today
        PanelControl1.Controls.Add(dtBitis)

        ' Butonlar
        btnListele = New SimpleButton()
        btnListele.Text = "Listele"
        btnListele.Location = New Point(650, 10)
        btnListele.Size = New Size(100, 30)
        btnListele.Appearance.BackColor = Color.LightBlue
        PanelControl1.Controls.Add(btnListele)

        btnSecilileriGonder = New SimpleButton()
        btnSecilileriGonder.Text = "Seçilileri Gönder"
        btnSecilileriGonder.Location = New Point(760, 10)
        btnSecilileriGonder.Size = New Size(130, 30)
        btnSecilileriGonder.Appearance.BackColor = Color.LightGreen
        PanelControl1.Controls.Add(btnSecilileriGonder)

        btnTumunuGonder = New SimpleButton()
        btnTumunuGonder.Text = "Tümünü Gönder"
        btnTumunuGonder.Location = New Point(900, 10)
        btnTumunuGonder.Size = New Size(130, 30)
        btnTumunuGonder.Appearance.BackColor = Color.Orange
        PanelControl1.Controls.Add(btnTumunuGonder)

        ' Tümünü Seç
        chkTumunuSec = New CheckEdit()
        chkTumunuSec.Text = "Tümünü Seç"
        chkTumunuSec.Location = New Point(10, 50)
        chkTumunuSec.Size = New Size(100, 25)
        PanelControl1.Controls.Add(chkTumunuSec)
        
        ' Gönderilenleri Göster
        chkGonderilenleriGoster = New CheckEdit()
        chkGonderilenleriGoster.Text = "Gönderilenleri de Göster"
        chkGonderilenleriGoster.Location = New Point(120, 50)
        chkGonderilenleriGoster.Size = New Size(180, 25)
        PanelControl1.Controls.Add(chkGonderilenleriGoster)
        
        ' Sadece Teslim Edilenler
        chkSadeceTeslimEdilenler = New CheckEdit()
        chkSadeceTeslimEdilenler.Text = "Sadece Teslim Edilenler"
        chkSadeceTeslimEdilenler.Location = New Point(310, 50)
        chkSadeceTeslimEdilenler.Size = New Size(180, 25)
        chkSadeceTeslimEdilenler.Checked = True  ' Default olarak işaretli
        PanelControl1.Controls.Add(chkSadeceTeslimEdilenler)

        ' Durum Label
        lblDurum = New LabelControl()
        lblDurum.Text = "Hazır"
        lblDurum.Location = New Point(500, 50)
        lblDurum.AutoSizeMode = LabelAutoSizeMode.None
        lblDurum.Size = New Size(500, 20)
        PanelControl1.Controls.Add(lblDurum)

        ' Grid
        GridControl1 = New DevExpress.XtraGrid.GridControl()
        GridView1 = New GridView()
        GridControl1.MainView = GridView1
        GridControl1.ViewCollection.Add(GridView1)
        GridControl1.Location = New Point(10, 100)
        GridControl1.Size = New Size(Me.ClientSize.Width - 20, Me.ClientSize.Height - 160)
        GridControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Me.Controls.Add(GridControl1)

        ' Grid sütunları
        GridView1.OptionsView.ShowGroupPanel = False
        GridView1.OptionsSelection.MultiSelect = True
        GridView1.OptionsView.ShowAutoFilterRow = True
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView1.OptionsCustomization.AllowFilter = True
        GridView1.OptionsCustomization.AllowColumnMoving = True
        GridView1.OptionsCustomization.AllowColumnResizing = True
        GridView1.OptionsCustomization.AllowSort = True
        
        ' Context Menu
        ContextMenu1 = New ContextMenu()
        mnuSutunOzellestir = New MenuItem("Sütun Özelleştir")
        mnuGorunumKaydet = New MenuItem("Görünümü Kaydet")
        mnuFiltrele = New MenuItem("Filtreleme Aç/Kapat")
        mnuSep1 = New MenuItem("-")
        mnuTeslimDurumuGuncelle = New MenuItem("Teslim Durumlarını Güncelle (Trendyol)")
        ContextMenu1.MenuItems.AddRange(New MenuItem() {mnuSutunOzellestir, mnuGorunumKaydet, mnuFiltrele, mnuSep1, mnuTeslimDurumuGuncelle})
        GridControl1.ContextMenu = ContextMenu1

        ' Progress Bar
        ProgressBar1 = New ProgressBarControl()
        ProgressBar1.Location = New Point(10, Me.ClientSize.Height - 50)
        ProgressBar1.Size = New Size(Me.ClientSize.Width - 20, 30)
        ProgressBar1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ProgressBar1.Visible = False
        Me.Controls.Add(ProgressBar1)

        Me.ResumeLayout(False)
    End Sub

    Private Sub LoadPazaryeriApis()
        Try
            Using con As New OleDbConnection(connection)
                con.Open()
                Using cmd As New OleDbCommand("SELECT sPazaryeri, sSellerId, sApiKey, sApiSecret, sBaseUrl, bAktif FROM tbPazaryeriAyar WHERE bAktif = 1", con)
                    Using reader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim api As New PazaryeriAPI()
                            api.Pazaryeri = If(reader.IsDBNull(0), "", reader.GetString(0).Trim())
                            api.SellerId = If(reader.IsDBNull(1), "", reader.GetValue(1).ToString().Trim())
                            api.ApiKey = If(reader.IsDBNull(2), "", reader.GetString(2).Trim())
                            api.ApiSecret = If(reader.IsDBNull(3), "", reader.GetString(3).Trim())
                            api.BaseUrl = If(reader.IsDBNull(4), "", reader.GetString(4).Trim())
                            api.Aktif = True
                            If Not String.IsNullOrEmpty(api.Pazaryeri) Then
                                pazaryeriApis(api.Pazaryeri.ToUpperInvariant()) = api
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("API bilgileri yüklenemedi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnListele_Click(sender As Object, e As EventArgs) Handles btnListele.Click
        ListeleFaturalar()
    End Sub

    Private Sub ListeleFaturalar()
        Try
            Cursor = Cursors.WaitCursor
            lblDurum.Text = "Faturalar yükleniyor..."
            Application.DoEvents()

            dtFaturalar.Clear()
            
            ' Tarih değerlerini debug için logla
            Dim basDate As DateTime = CDate(dtBaslangic.EditValue)
            Dim bitDate As DateTime = CDate(dtBitis.EditValue)
            Debug.WriteLine("[TARIH] Başlangıç: " & basDate.ToString("yyyy-MM-dd") & ", Bitiş: " & bitDate.ToString("yyyy-MM-dd"))

            Dim pazaryeriFiltre As String = ""
            Select Case cmbPazaryeri.SelectedIndex
                Case 1 ' Trendyol
                    pazaryeriFiltre = " AND A.sAciklama3 LIKE 'TY%' "
                Case 2 ' Hepsiburada
                    pazaryeriFiltre = " AND A.sAciklama3 LIKE 'HB%' "
                Case 3 ' N11
                    pazaryeriFiltre = " AND A.sAciklama3 LIKE 'N11%' "
                Case 4 ' Pazarama
                    pazaryeriFiltre = " AND A.sAciklama3 LIKE 'PAZ%' "
            End Select

            Dim sql As String = "SELECT " &
                "M.nStokFisiID, " &
                "M.dteFisTarihi, " &
                "M.lFisNo, " &
                "M.GibFaturaNo, " &
                "M.sEfaturaGuid, " &
                "M.sEfaturaTipi, " &
                "M.lNetTutar, " &
                "A.sAciklama2 AS MusteriAdi, " &
                "A.sAciklama3 AS SiparisNo, " &
                "ISNULL(F.sAciklama, '') AS FirmaAdi, " &
                "ISNULL(F.sIl, '') AS Il, " &
                "ISNULL(F.sSemt, '') AS Semt, " &
                "(SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = F.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon, " &
                "CASE " &
                "   WHEN A.sAciklama3 LIKE 'TY%' THEN 'Trendyol' " &
                "   WHEN A.sAciklama3 LIKE 'HB%' THEN 'Hepsiburada' " &
                "   WHEN A.sAciklama3 LIKE 'N11%' THEN 'N11' " &
                "   WHEN A.sAciklama3 LIKE 'PAZ%' THEN 'Pazarama' " &
                "   ELSE 'Bilinmiyor' " &
                "END AS Pazaryeri, " &
                "ISNULL(P.bGonderildi, 0) AS bGonderildi, " &
                "P.dteGonderimTarihi, " &
                "P.sGonderimSonucu, " &
                "P.sHataMesaji, " &
                "ISNULL(M.sTeslimDurumu, '') AS TeslimDurumu " &
                "FROM tbStokFisiMaster M " &
                "INNER JOIN tbStokFisiAciklamasi A ON M.nStokFisiID = A.nStokFisiID " &
                "LEFT JOIN tbFirma F ON M.nFirmaID = F.nFirmaID " &
                "LEFT JOIN tbPazaryeriFaturaGonderim P ON M.nStokFisiID = P.nStokFisiID " &
                "WHERE M.dteFisTarihi >= ? AND M.dteFisTarihi <= ? " &
                "AND (A.sAciklama3 LIKE 'TY%' OR A.sAciklama3 LIKE 'HB%' OR A.sAciklama3 LIKE 'N11%' OR A.sAciklama3 LIKE 'PAZ%') " &
                If(chkGonderilenleriGoster IsNot Nothing AndAlso chkGonderilenleriGoster.Checked, "", "AND ISNULL(P.bGonderildi, 0) = 0 ") &
                If(chkSadeceTeslimEdilenler IsNot Nothing AndAlso chkSadeceTeslimEdilenler.Checked, "AND (ISNULL(M.sTeslimDurumu, '') LIKE '%Teslim Edildi%' OR ISNULL(M.sTeslimDurumu, '') LIKE '%Delivered%') ", "") &
                pazaryeriFiltre &
                "ORDER BY ISNULL(P.bGonderildi, 0) ASC, M.dteFisTarihi DESC"
            
            Debug.WriteLine("[SQL] chkSadeceTeslimEdilenler null mu: " & (chkSadeceTeslimEdilenler Is Nothing).ToString())
            Debug.WriteLine("[SQL] chkGonderilenleriGoster null mu: " & (chkGonderilenleriGoster Is Nothing).ToString())
            If chkSadeceTeslimEdilenler IsNot Nothing Then
                Debug.WriteLine("[SQL] Sadece Teslim Edilenler: " & chkSadeceTeslimEdilenler.Checked.ToString())
            End If
            Debug.WriteLine("[SQL] Query: " & sql)

            Using con As New OleDbConnection(connection)
                con.Open()
                Using cmd As New OleDbCommand(sql, con)
                    ' OleDb ? parametreleri sıralı eklenmeli
                    cmd.Parameters.AddWithValue("@p0", basDate.Date)
                    cmd.Parameters.AddWithValue("@p1", bitDate.Date.AddDays(1).AddSeconds(-1)) ' Gün sonuna kadar
                    
                    Debug.WriteLine("[SQL] Param @p0: " & basDate.Date.ToString("yyyy-MM-dd"))
                    Debug.WriteLine("[SQL] Param @p1: " & bitDate.Date.AddDays(1).AddSeconds(-1).ToString("yyyy-MM-dd HH:mm:ss"))
                    
                    Using adapter As New OleDbDataAdapter(cmd)
                        adapter.Fill(dtFaturalar)
                    End Using
                End Using
            End Using
            
            Debug.WriteLine("[SQL] Sonuç sayısı: " & dtFaturalar.Rows.Count)

            GridControl1.DataSource = dtFaturalar
            GridView1.BestFitColumns()

            ' Sütun başlıklarını düzenle
            For Each col As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
                Select Case col.FieldName
                    Case "nStokFisiID" : col.Visible = False
                    Case "dteFisTarihi" : col.Caption = "Fatura Tarihi"
                    Case "lFisNo" : col.Caption = "Fiş No"
                    Case "GibFaturaNo" : col.Caption = "GİB Fatura No"
                    Case "sEfaturaGuid" : col.Caption = "Fatura UUID" : col.Visible = False
                    Case "sEfaturaTipi" : col.Caption = "Fatura Tipi"
                    Case "lNetTutar" : col.Caption = "Net Tutar" : col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric : col.DisplayFormat.FormatString = "N2"
                    Case "MusteriAdi" : col.Caption = "Müşteri (Sipariş)"
                    Case "SiparisNo" : col.Caption = "Sipariş No"
                    Case "FirmaAdi" : col.Caption = "Cari Adı"
                    Case "Telefon" : col.Caption = "Telefon"
                    Case "Il" : col.Caption = "İl"
                    Case "Semt" : col.Caption = "Semt"
                    Case "Pazaryeri" : col.Caption = "Pazaryeri"
                    Case "bGonderildi" : col.Caption = "Fatura Gönderildi" : col.Visible = True
                    Case "dteGonderimTarihi" : col.Caption = "Gönderim Tarihi"
                    Case "sGonderimSonucu" : col.Caption = "Sonuç"
                    Case "sHataMesaji" : col.Caption = "Hata"
                    Case "TeslimDurumu" : col.Caption = "Teslim Durumu"
                End Select
            Next
            
            ' Görünümü registry'den yükle
            gorunum_yukle()
            
            ' Satır renklendirme için event handler ekle
            AddHandler GridView1.RowStyle, AddressOf GridView1_RowStyle
            
            ' Gönderilen ve bekleyen sayılarını hesapla
            Dim gonderildi As Integer = 0
            Dim bekliyor As Integer = 0
            For Each row As DataRow In dtFaturalar.Rows
                If CBool(row("bGonderildi")) Then
                    gonderildi += 1
                Else
                    bekliyor += 1
                End If
            Next

            lblDurum.Text = "Toplam " & dtFaturalar.Rows.Count & " fatura. Bekleyen: " & bekliyor & ", Gönderilmiş: " & gonderildi
            Cursor = Cursors.Default

        Catch ex As Exception
            Cursor = Cursors.Default
            lblDurum.Text = "Hata: " & ex.Message
            MessageBox.Show("Faturalar listelenirken hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Gönderilmiş satırları yeşil, bekleyenleri normal renkte göster
    ''' </summary>
    Private Sub GridView1_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs)
        Try
            If e.RowHandle >= 0 Then
                Dim view As GridView = CType(sender, GridView)
                Dim gonderildi As Object = view.GetRowCellValue(e.RowHandle, "bGonderildi")
                If gonderildi IsNot Nothing AndAlso gonderildi IsNot DBNull.Value AndAlso CBool(gonderildi) Then
                    e.Appearance.BackColor = Color.LightGreen
                    e.Appearance.ForeColor = Color.DarkGreen
                End If
            End If
        Catch
            ' Hata durumunda sessizce devam et
        End Try
    End Sub


    Private Sub btnSecilileriGonder_Click(sender As Object, e As EventArgs) Handles btnSecilileriGonder.Click
        Dim selectedRows As Integer() = GridView1.GetSelectedRows()
        If selectedRows.Length = 0 Then
            MessageBox.Show("Lütfen en az bir fatura seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show(selectedRows.Length & " fatura pazaryerlerine gönderilecek. Devam edilsin mi?",
                          "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            GonderFaturalar(selectedRows)
        End If
    End Sub

    Private Sub btnTumunuGonder_Click(sender As Object, e As EventArgs) Handles btnTumunuGonder.Click
        If dtFaturalar.Rows.Count = 0 Then
            MessageBox.Show("Gönderilecek fatura yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Tüm " & dtFaturalar.Rows.Count & " fatura pazaryerlerine gönderilecek. Devam edilsin mi?",
                          "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim allRows(dtFaturalar.Rows.Count - 1) As Integer
            For i As Integer = 0 To dtFaturalar.Rows.Count - 1
                allRows(i) = i
            Next
            GonderFaturalar(allRows)
        End If
    End Sub

    Private Sub GonderFaturalar(rows As Integer())
        Try
            ProgressBar1.Visible = True
            ProgressBar1.Properties.Maximum = rows.Length
            ProgressBar1.EditValue = 0
            btnListele.Enabled = False
            btnSecilileriGonder.Enabled = False
            btnTumunuGonder.Enabled = False

            Dim basarili As Integer = 0
            Dim basarisiz As Integer = 0
            Dim gibGonderilen As Integer = 0

            For i As Integer = 0 To rows.Length - 1
                Dim rowIndex As Integer = rows(i)
                Dim dr As DataRowView = CType(GridView1.GetRow(rowIndex), DataRowView)
                If dr Is Nothing Then Continue For

                Dim nStokFisiID As Integer = CInt(dr("nStokFisiID"))
                Dim siparisNo As String = dr("SiparisNo").ToString().Trim()
                Dim pazaryeri As String = dr("Pazaryeri").ToString().Trim()
                Dim gibFaturaNo As String = If(dr("GibFaturaNo") IsNot DBNull.Value AndAlso dr("GibFaturaNo") IsNot Nothing, dr("GibFaturaNo").ToString().Trim(), "")
                Dim faturaGuid As String = If(dr("sEfaturaGuid") IsNot DBNull.Value AndAlso dr("sEfaturaGuid") IsNot Nothing, dr("sEfaturaGuid").ToString().Trim(), "")
                Dim faturaTarihi As DateTime = If(dr("dteFisTarihi") IsNot DBNull.Value, CDate(dr("dteFisTarihi")), DateTime.Now)

                lblDurum.Text = "Gönderiliyor: " & siparisNo & " (" & pazaryeri & ") - " & (i + 1) & "/" & rows.Length
                Application.DoEvents()
                
                ' DEBUG: GibFaturaNo değerini logla ve MessageBox ile göster
                Debug.WriteLine("[DEBUG] Sipariş: " & siparisNo & ", GibFaturaNo: [" & gibFaturaNo & "], IsNullOrEmpty: " & String.IsNullOrEmpty(gibFaturaNo).ToString())
                
                ' İlk kayıt için debug mesajı göster
                If i = 0 Then
                    MessageBox.Show("Sipariş: " & siparisNo & vbCrLf & 
                                   "GibFaturaNo: [" & gibFaturaNo & "]" & vbCrLf &
                                   "Boş mu: " & String.IsNullOrEmpty(gibFaturaNo).ToString() & vbCrLf &
                                   "Trim sonrası boş mu: " & (gibFaturaNo.Trim() = "").ToString(),
                                   "DEBUG - GİB Fatura No Kontrolü", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                ' ===== GİB'E GÖNDERİLMEMİŞSE ÖNCE GİB'E GÖNDER =====
                ' GibFaturaNo boş, null, "0" veya sadece boşluk ise GİB'e gönder
                If String.IsNullOrEmpty(gibFaturaNo) OrElse gibFaturaNo.Trim() = "" OrElse gibFaturaNo.Trim() = "0" Then
                    Debug.WriteLine("[GIB] GibFaturaNo boş/0 - GİB'e gönderilecek: " & siparisNo)
                    MessageBox.Show("GİB'e gönderilecek: " & siparisNo, "DEBUG", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lblDurum.Text = "GİB'e gönderiliyor: " & siparisNo & " - " & (i + 1) & "/" & rows.Length
                    Application.DoEvents()
                    
                    ' ===== MİKRO İHRACAT KONTROLÜ - GİB'E GÖNDERMEDEN ÖNCE =====
                    ' Trendyol siparişi ise mikro ihracat kontrolü yap
                    If pazaryeri = "Trendyol" Then
                        Try
                            Dim isMicroExportCheck As Boolean = False
                            Dim hataMesajiCheck As String = ""
                            Dim orderNumber As String = siparisNo
                            If orderNumber.StartsWith("TY") Then orderNumber = orderNumber.Substring(2)
                            
                            If pazaryeriApis.ContainsKey("TRENDYOL") Then
                                Dim api = pazaryeriApis("TRENDYOL")
                                
                                ' API credentials hazırla
                                Dim credentials As String = api.ApiKey & ":" & api.ApiSecret
                                Dim authBase64 As String = Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials))
                                Dim userAgent As String = api.SellerId & " - SelfIntegration"
                                
                                Dim pkgId As String = GetTrendyolShipmentPackageId(api.SellerId, orderNumber, authBase64, userAgent, hataMesajiCheck, isMicroExportCheck)
                                
                                If isMicroExportCheck Then
                                    ' Mikro ihracat - faturayı ihracat faturası olarak işaretle
                                    Debug.WriteLine("[IHRACAT] Mikro ihracat tespit edildi: " & siparisNo)
                                    IhracatFaturasıOlarakIsaretle(nStokFisiID)
                                End If
                            End If
                        Catch ex As Exception
                            Debug.WriteLine("[IHRACAT] Mikro ihracat kontrolü hatası: " & ex.Message)
                        End Try
                    End If
                    
                    Try
                        Dim gibSonuc As String = mod_EFatura.FaturaGonder(nStokFisiID)
                        If Not String.IsNullOrEmpty(gibSonuc) AndAlso Not gibSonuc.ToLower().Contains("hata") Then
                            gibFaturaNo = gibSonuc
                            gibGonderilen += 1
                            Debug.WriteLine("[GIB] Fatura GİB'e gönderildi: " & gibFaturaNo)
                            
                            ' faturaGuid'i de güncellemek için veritabanından tekrar oku
                            Try
                                Using con As New OleDbConnection(connection)
                                    con.Open()
                                    Using cmd As New OleDbCommand("SELECT sEfaturaGuid, dteFisTarihi FROM tbStokFisiMaster WHERE nStokFisiID = ?", con)
                                        cmd.Parameters.AddWithValue("@p0", nStokFisiID)
                                        Using rdr = cmd.ExecuteReader()
                                            If rdr.Read() Then
                                                faturaGuid = If(IsDBNull(rdr("sEfaturaGuid")), "", rdr("sEfaturaGuid").ToString().Trim())
                                                faturaTarihi = If(IsDBNull(rdr("dteFisTarihi")), DateTime.Now, CDate(rdr("dteFisTarihi")))
                                            End If
                                        End Using
                                    End Using
                                End Using
                            Catch
                            End Try
                        Else
                            Debug.WriteLine("[GIB] GİB gönderim hatası: " & If(gibSonuc, "boş yanıt"))
                            basarisiz += 1
                            KaydetGonderimSonucu(nStokFisiID, pazaryeri, siparisNo, "", "", False, "GİB'e gönderilemedi: " & If(gibSonuc, "boş yanıt"))
                            Continue For
                        End If
                    Catch ex As Exception
                        Debug.WriteLine("[GIB] GİB gönderim exception: " & ex.Message)
                        basarisiz += 1
                        KaydetGonderimSonucu(nStokFisiID, pazaryeri, siparisNo, "", "", False, "GİB gönderim hatası: " & ex.Message)
                        Continue For
                    End Try
                End If

                Dim sonuc As Boolean = False
                Dim hataMesaji As String = ""

                Select Case pazaryeri.ToUpperInvariant()
                    Case "TRENDYOL"
                        sonuc = GonderTrendyol(siparisNo, gibFaturaNo, faturaGuid, faturaTarihi, hataMesaji)
                    Case "HEPSIBURADA"
                        sonuc = GonderHepsiburada(siparisNo, gibFaturaNo, faturaGuid, hataMesaji)
                    Case "N11"
                        sonuc = GonderN11(siparisNo, gibFaturaNo, faturaGuid, hataMesaji)
                    Case "PAZARAMA"
                        sonuc = GonderPazarama(siparisNo, gibFaturaNo, faturaGuid, hataMesaji)
                    Case Else
                        hataMesaji = "Bilinmeyen pazaryeri: " & pazaryeri
                End Select

                ' Sonucu kaydet
                KaydetGonderimSonucu(nStokFisiID, pazaryeri, siparisNo, gibFaturaNo, faturaGuid, sonuc, hataMesaji)

                If sonuc Then
                    basarili += 1
                Else
                    basarisiz += 1
                End If

                ProgressBar1.EditValue = i + 1
                Application.DoEvents()
            Next

            lblDurum.Text = "Tamamlandı! Başarılı: " & basarili & ", Başarısız: " & basarisiz & If(gibGonderilen > 0, ", GİB'e gönderilen: " & gibGonderilen, "")
            Dim mesaj As String = "Gönderim tamamlandı!" & vbCrLf & vbCrLf &
                           "Pazaryerine Başarılı: " & basarili & vbCrLf &
                           "Başarısız: " & basarisiz
            If gibGonderilen > 0 Then
                mesaj &= vbCrLf & "GİB'e otomatik gönderilen: " & gibGonderilen
            End If
            MessageBox.Show(mesaj, "Sonuç", MessageBoxButtons.OK,
                           If(basarisiz = 0, MessageBoxIcon.Information, MessageBoxIcon.Warning))

            ' Listeyi yenile
            ListeleFaturalar()

        Catch ex As Exception
            lblDurum.Text = "Hata: " & ex.Message
            MessageBox.Show("Gönderim sırasında hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ProgressBar1.Visible = False
            btnListele.Enabled = True
            btnSecilileriGonder.Enabled = True
            btnTumunuGonder.Enabled = True
        End Try
    End Sub

    ''' <summary>
    ''' Trendyol'a fatura gönder
    ''' </summary>
    Private Function GonderTrendyol(siparisNo As String, gibFaturaNo As String, faturaGuid As String, faturaTarihi As DateTime, ByRef hataMesaji As String) As Boolean
        Try
            If Not pazaryeriApis.ContainsKey("TRENDYOL") Then
                hataMesaji = "Trendyol API ayarları bulunamadı"
                Return False
            End If

            Dim api = pazaryeriApis("TRENDYOL")
            
            Debug.WriteLine("[TY] ===== TRENDYOL FATURA GÖNDERME =====")
            Debug.WriteLine("[TY] Sipariş No: " & siparisNo)
            Debug.WriteLine("[TY] GİB Fatura No: " & gibFaturaNo)
            Debug.WriteLine("[TY] Satıcı ID: " & api.SellerId)
            Debug.WriteLine("[TY] API Key: " & api.ApiKey)

            ' Sipariş numarasını temizle (TY11035907594 -> 11035907594)
            Dim orderNumber As String = siparisNo.Replace("TY", "").Replace("ty", "").Trim()
            Debug.WriteLine("[TY] Order Number: " & orderNumber)
            
            ' Auth bilgileri
            Dim authRaw As String = api.ApiKey & ":" & api.ApiSecret
            Dim authBytes As Byte() = Encoding.UTF8.GetBytes(authRaw)
            Dim authBase64 As String = Convert.ToBase64String(authBytes)
            Dim userAgent As String = api.SellerId & " - SelfIntegration"
            
            ' 1. ADIM: Sipariş numarasıyla Paket ID'yi bul ve micro export kontrolü yap
            Dim isMicroExport As Boolean = False
            Dim shipmentPackageId As String = GetTrendyolShipmentPackageId(api.SellerId, orderNumber, authBase64, userAgent, hataMesaji, isMicroExport)
            If String.IsNullOrEmpty(shipmentPackageId) Then
                Debug.WriteLine("[TY] HATA: Paket ID bulunamadı - " & hataMesaji)
                Return False
            End If
            Debug.WriteLine("[TY] Shipment Package ID bulundu: " & shipmentPackageId)
            Debug.WriteLine("[TY] Is Micro Export: " & isMicroExport.ToString())

            ' Fatura linki oluştur (Kolaysoft'tan alınacak)
            Dim invoiceLink As String = GetKolaysoftFaturaLink(gibFaturaNo, faturaGuid)
            If String.IsNullOrEmpty(invoiceLink) Then
                hataMesaji = "Fatura linki alınamadı"
                Debug.WriteLine("[TY] HATA: Fatura linki alınamadı")
                Return False
            End If
            Debug.WriteLine("[TY] Fatura Link: " & invoiceLink)

            ' 2. ADIM: Fatura linkini gönder
            ' POST https://apigw.trendyol.com/integration/sellers/{sellerId}/seller-invoice-links
            Dim baseUrl As String = "https://apigw.trendyol.com"
            
            Dim url As String = baseUrl & "/integration/sellers/" & api.SellerId & "/seller-invoice-links"
            Debug.WriteLine("[TY] URL: " & url)

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            
            Dim req As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            req.Method = "POST"
            req.ContentType = "application/json"
            req.Accept = "application/json"
            
            ' Trendyol özel User-Agent formatı: {supplierId} - SelfIntegration
            req.UserAgent = userAgent
            req.Headers.Add("Authorization", "Basic " & authBase64)
            req.Timeout = 30000

            ' Body - Trendyol fatura linki formatı
            ' invoiceNumber ve invoiceDateTime: Micro export için ZORUNLU, normal siparişlerde de gönderilebilir
            ' Her zaman gönderiyoruz çünkü mikro ihracat tespiti zor olabiliyor
            Dim invoiceDateTime As Long = CLng((faturaTarihi.ToUniversalTime() - New DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds)
            
            ' shipmentPackageId Long olmalı (tırnak olmadan)
            Dim jsonBody As String = "{" &
                """shipmentPackageId"": " & shipmentPackageId & "," &
                """invoiceLink"": """ & invoiceLink.Replace("""", "\""") & """," &
                """invoiceNumber"": """ & gibFaturaNo & """," &
                """invoiceDateTime"": " & invoiceDateTime.ToString() &
                "}"
            
            Debug.WriteLine("[TY] isMicroExport: " & isMicroExport.ToString())
            Debug.WriteLine("[TY] invoiceNumber: " & gibFaturaNo & ", invoiceDateTime: " & invoiceDateTime.ToString())
            Debug.WriteLine("[TY] Body: " & jsonBody)
            
            Dim data As Byte() = Encoding.UTF8.GetBytes(jsonBody)
            req.ContentLength = data.Length

            Using stream = req.GetRequestStream()
                stream.Write(data, 0, data.Length)
            End Using

            Using resp As HttpWebResponse = CType(req.GetResponse(), HttpWebResponse)
                Dim statusCode As Integer = CInt(resp.StatusCode)
                Debug.WriteLine("[TY] Response Status: " & statusCode)
                
                If statusCode >= 200 AndAlso statusCode < 300 Then
                    Debug.WriteLine("[TY] BAŞARILI!")
                    Return True
                Else
                    hataMesaji = "HTTP " & statusCode & ": " & resp.StatusDescription
                    Debug.WriteLine("[TY] HATA: " & hataMesaji)
                    Return False
                End If
            End Using

        Catch wex As WebException
            If wex.Response IsNot Nothing Then
                Try
                    Dim resp As HttpWebResponse = CType(wex.Response, HttpWebResponse)
                    Dim statusCode As Integer = CInt(resp.StatusCode)
                    Using reader As New StreamReader(resp.GetResponseStream(), Encoding.UTF8)
                        Dim errorBody As String = reader.ReadToEnd()
                        hataMesaji = "HTTP " & statusCode & ": " & If(errorBody.Length > 300, errorBody.Substring(0, 300), errorBody)
                        Debug.WriteLine("[TY] WebException: " & hataMesaji)
                    End Using
                Catch
                    hataMesaji = wex.Message
                    Debug.WriteLine("[TY] WebException: " & hataMesaji)
                End Try
            Else
                hataMesaji = wex.Message
                Debug.WriteLine("[TY] WebException (no response): " & hataMesaji)
            End If
            Return False
        Catch ex As Exception
            hataMesaji = ex.Message
            Debug.WriteLine("[TY] Exception: " & hataMesaji)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Trendyol API'den sipariş numarasıyla Shipment Package ID'yi bul
    ''' GET /sapigw/suppliers/{supplierId}/orders?orderNumber={orderNumber}
    ''' </summary>
    Private Function GetTrendyolShipmentPackageId(sellerId As String, orderNumber As String, authBase64 As String, userAgent As String, ByRef hataMesaji As String, ByRef isMicroExport As Boolean) As String
        isMicroExport = False
        Try
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            
            ' Sipariş detayını çek
            ' GET /sapigw/suppliers/{supplierId}/orders?orderNumber={orderNumber}
            Dim url As String = "https://api.trendyol.com/sapigw/suppliers/" & sellerId & "/orders?orderNumber=" & orderNumber
            Debug.WriteLine("[TY-Search] URL: " & url)
            
            Dim req As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            req.Method = "GET"
            req.Accept = "application/json"
            req.UserAgent = userAgent
            req.Headers.Add("Authorization", "Basic " & authBase64)
            req.Timeout = 30000
            
            Using resp As HttpWebResponse = CType(req.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(resp.GetResponseStream(), Encoding.UTF8)
                    Dim json As String = reader.ReadToEnd()
                    Debug.WriteLine("[TY-Search] Response length: " & json.Length)
                    
                    If json.Length > 0 Then
                        Debug.WriteLine("[TY-Search] Response preview: " & If(json.Length > 500, json.Substring(0, 500), json))
                    End If
                    
                    ' JSON parse et
                    Dim obj As JObject = JObject.Parse(json)
                    
                    ' content array içinde siparişler var
                    If obj("content") IsNot Nothing Then
                        Dim contentArray As JArray = CType(obj("content"), JArray)
                        Debug.WriteLine("[TY-Search] Content count: " & contentArray.Count)
                        
                        ' Önce shipmentPackageId'yi bulalım, sonra return edeceğiz
                        Dim foundPackageId As String = Nothing
                        
                        For Each order As JObject In contentArray
                            ' === TÜM ORDER ALANLARINI LOGLA (DEBUG) ===
                            Debug.WriteLine("[TY-Search] === ORDER ALANLARI ===")
                            For Each jprop As JProperty In order.Properties()
                                Dim valStr As String = ""
                                If jprop.Value IsNot Nothing Then
                                    valStr = jprop.Value.ToString()
                                    If valStr.Length > 100 Then valStr = valStr.Substring(0, 100) & "..."
                                End If
                                Debug.WriteLine("[TY-Search] " & jprop.Name & " = " & valStr)
                            Next
                            Debug.WriteLine("[TY-Search] === ORDER ALANLARI SONU ===")
                            
                            ' === MICRO EXPORT KONTROLÜ ===
                            ' 1. deliveryType kontrolü
                            If order("deliveryType") IsNot Nothing Then
                                Dim deliveryType As String = order("deliveryType").ToString().ToUpperInvariant()
                                Debug.WriteLine("[TY-Search] deliveryType=" & deliveryType)
                                If deliveryType.Contains("MICRO") OrElse deliveryType.Contains("EXPORT") Then
                                    isMicroExport = True
                                    Debug.WriteLine("[TY-Search] MICRO EXPORT tespit edildi: deliveryType=" & deliveryType)
                                End If
                            End If
                            
                            ' 2. orderType kontrolü
                            If order("orderType") IsNot Nothing Then
                                Dim orderType As String = order("orderType").ToString().ToUpperInvariant()
                                Debug.WriteLine("[TY-Search] orderType=" & orderType)
                                If orderType.Contains("MICRO") OrElse orderType.Contains("EXPORT") Then
                                    isMicroExport = True
                                    Debug.WriteLine("[TY-Search] MICRO EXPORT tespit edildi: orderType=" & orderType)
                                End If
                            End If
                            
                            ' 3. isMicroExport alanı direkt kontrol (boolean)
                            If order("isMicroExport") IsNot Nothing Then
                                Try
                                    isMicroExport = Convert.ToBoolean(order("isMicroExport"))
                                    Debug.WriteLine("[TY-Search] order.isMicroExport=" & isMicroExport.ToString())
                                Catch
                                    ' Boolean parse edilemezse string olarak kontrol et
                                    Dim microVal As String = order("isMicroExport").ToString().ToUpperInvariant()
                                    If microVal = "TRUE" OrElse microVal = "1" OrElse microVal = "YES" Then
                                        isMicroExport = True
                                        Debug.WriteLine("[TY-Search] order.isMicroExport (string)=" & microVal)
                                    End If
                                End Try
                            End If
                            
                            ' 3b. "micro" alanı kontrolü (Trendyol API'de "micro": true olarak dönebilir)
                            If order("micro") IsNot Nothing Then
                                Try
                                    Dim microFlag As Boolean = Convert.ToBoolean(order("micro"))
                                    If microFlag Then
                                        isMicroExport = True
                                        Debug.WriteLine("[TY-Search] order.micro=True")
                                    End If
                                Catch
                                    Dim microVal As String = order("micro").ToString().ToUpperInvariant()
                                    If microVal = "TRUE" OrElse microVal = "1" Then
                                        isMicroExport = True
                                        Debug.WriteLine("[TY-Search] order.micro (string)=" & microVal)
                                    End If
                                End Try
                            End If
                            
                            ' 4. exportType kontrolü
                            If order("exportType") IsNot Nothing Then
                                Dim exportType As String = order("exportType").ToString().ToUpperInvariant()
                                Debug.WriteLine("[TY-Search] exportType=" & exportType)
                                If exportType.Contains("MICRO") OrElse Not String.IsNullOrEmpty(exportType) Then
                                    isMicroExport = True
                                    Debug.WriteLine("[TY-Search] MICRO EXPORT tespit edildi: exportType=" & exportType)
                                End If
                            End If
                            
                            ' 5. microExportInfo kontrolü
                            If order("microExportInfo") IsNot Nothing Then
                                isMicroExport = True
                                Debug.WriteLine("[TY-Search] MICRO EXPORT tespit edildi: microExportInfo mevcut")
                            End If
                            
                            ' 6. cargoProviderName kontrolü - yurtdışı kargo şirketleri
                            If order("cargoProviderName") IsNot Nothing Then
                                Dim cargoProvider As String = order("cargoProviderName").ToString().ToUpperInvariant()
                                Debug.WriteLine("[TY-Search] cargoProviderName=" & cargoProvider)
                                If cargoProvider.Contains("EXPORT") OrElse cargoProvider.Contains("INTERNATIONAL") OrElse cargoProvider.Contains("YURTDISI") Then
                                    isMicroExport = True
                                    Debug.WriteLine("[TY-Search] MICRO EXPORT tespit edildi: cargoProviderName=" & cargoProvider)
                                End If
                            End If
                            
                            ' 7. shipmentAddress ülke kontrolü - Türkiye dışı = ihracat
                            If order("shipmentAddress") IsNot Nothing Then
                                Dim shipAddr As JObject = CType(order("shipmentAddress"), JObject)
                                If shipAddr("countryCode") IsNot Nothing Then
                                    Dim countryCode As String = shipAddr("countryCode").ToString().ToUpperInvariant()
                                    Debug.WriteLine("[TY-Search] shipmentAddress.countryCode=" & countryCode)
                                    If countryCode <> "TR" AndAlso countryCode <> "TUR" AndAlso countryCode <> "TURKEY" AndAlso Not String.IsNullOrEmpty(countryCode) Then
                                        isMicroExport = True
                                        Debug.WriteLine("[TY-Search] MICRO EXPORT tespit edildi: countryCode=" & countryCode)
                                    End If
                                End If
                                If shipAddr("country") IsNot Nothing Then
                                    Dim country As String = shipAddr("country").ToString().ToUpperInvariant()
                                    Debug.WriteLine("[TY-Search] shipmentAddress.country=" & country)
                                    If country <> "TÜRKİYE" AndAlso country <> "TURKIYE" AndAlso country <> "TURKEY" AndAlso Not String.IsNullOrEmpty(country) Then
                                        isMicroExport = True
                                        Debug.WriteLine("[TY-Search] MICRO EXPORT tespit edildi: country=" & country)
                                    End If
                                End If
                            End If
                            
                            ' === SHIPMENT PACKAGE ID BULMA ===
                            ' Her siparişin lines array'i var
                            If order("lines") IsNot Nothing Then
                                Dim linesArray As JArray = CType(order("lines"), JArray)
                                For Each line As JObject In linesArray
                                    ' Line seviyesinde de isMicroExport olabilir
                                    If line("isMicroExport") IsNot Nothing Then
                                        Try
                                            Dim lineMicro As Boolean = Convert.ToBoolean(line("isMicroExport"))
                                            If lineMicro Then
                                                isMicroExport = True
                                                Debug.WriteLine("[TY-Search] line.isMicroExport=True")
                                            End If
                                        Catch
                                        End Try
                                    End If
                                    
                                    ' Line'da exportType kontrolü
                                    If line("exportType") IsNot Nothing Then
                                        isMicroExport = True
                                        Debug.WriteLine("[TY-Search] line.exportType mevcut")
                                    End If
                                    
                                    ' shipmentPackageId burada
                                    If line("shipmentPackageId") IsNot Nothing AndAlso foundPackageId Is Nothing Then
                                        foundPackageId = line("shipmentPackageId").ToString()
                                        Debug.WriteLine("[TY-Search] Found shipmentPackageId in line: " & foundPackageId)
                                    End If
                                Next
                            End If
                            
                            ' Veya direkt shipmentPackageId olabilir
                            If order("shipmentPackageId") IsNot Nothing AndAlso foundPackageId Is Nothing Then
                                foundPackageId = order("shipmentPackageId").ToString()
                                Debug.WriteLine("[TY-Search] Found shipmentPackageId in order: " & foundPackageId)
                            End If
                        Next
                        
                        ' Tüm kontroller bittikten sonra return et
                        Debug.WriteLine("[TY-Search] SONUÇ - isMicroExport: " & isMicroExport.ToString() & ", packageId: " & If(foundPackageId, "NULL"))
                        If foundPackageId IsNot Nothing Then
                            Return foundPackageId
                        End If
                    End If
                    
                    hataMesaji = "Sipariş bulundu ama shipmentPackageId bulunamadı"
                    Return Nothing
                End Using
            End Using
            
        Catch wex As WebException
            If wex.Response IsNot Nothing Then
                Try
                    Dim resp As HttpWebResponse = CType(wex.Response, HttpWebResponse)
                    Dim statusCode As Integer = CInt(resp.StatusCode)
                    Using reader As New StreamReader(resp.GetResponseStream(), Encoding.UTF8)
                        Dim errorBody As String = reader.ReadToEnd()
                        hataMesaji = "HTTP " & statusCode & ": " & If(errorBody.Length > 200, errorBody.Substring(0, 200), errorBody)
                        Debug.WriteLine("[TY-Search] WebException: " & hataMesaji)
                    End Using
                Catch
                    hataMesaji = wex.Message
                End Try
            Else
                hataMesaji = wex.Message
            End If
            Return Nothing
        Catch ex As Exception
            hataMesaji = "Paket arama hatası: " & ex.Message
            Debug.WriteLine("[TY-Search] Exception: " & ex.Message)
            Return Nothing
        End Try
    End Function


    ''' <summary>
    ''' Hepsiburada'ya fatura linki gönder
    ''' 1. Önce sipariş numarasıyla package bilgisini al
    ''' 2. PackageNumber ile fatura linkini gönder
    ''' Endpoint: PUT /packages/merchantid/{merchantId}/packagenumber/{packageNumber}/invoice
    ''' </summary>
    Private Function GonderHepsiburada(siparisNo As String, gibFaturaNo As String, faturaGuid As String, ByRef hataMesaji As String) As Boolean
        Try
            If Not pazaryeriApis.ContainsKey("HEPSIBURADA") Then
                hataMesaji = "Hepsiburada API ayarları bulunamadı"
                Return False
            End If

            Dim api = pazaryeriApis("HEPSIBURADA")

            ' Sipariş numarasını temizle (HB prefix varsa kaldır)
            Dim orderNumber As String = siparisNo.Replace("HB", "").Replace("hb", "").Trim()
            If String.IsNullOrEmpty(orderNumber) Then
                hataMesaji = "Sipariş numarası boş"
                Return False
            End If

            ' Fatura linki al
            Dim invoiceLink As String = GetKolaysoftFaturaLink(gibFaturaNo, faturaGuid)
            If String.IsNullOrEmpty(invoiceLink) Then
                hataMesaji = "Fatura linki alınamadı"
                Return False
            End If

            ' ===== HEPSIBURADA API - Basic Auth =====
            ' Entegratör Adı (ApiKey) : Servis Anahtarı (ApiSecret)
            ' merchant.hepsiburada.com > Entegrasyon > Entegratör Bilgileri
            Dim merchantId As String = api.SellerId
            Dim entegratorAdi As String = api.ApiKey
            Dim servisAnahtari As String = api.ApiSecret
            
            ' Eğer entegratör adı yoksa merchantId kullan
            If String.IsNullOrEmpty(entegratorAdi) Then
                entegratorAdi = merchantId
            End If
            
            If String.IsNullOrEmpty(merchantId) OrElse String.IsNullOrEmpty(servisAnahtari) Then
                hataMesaji = "Mağaza ID veya Servis Anahtarı eksik. merchant.hepsiburada.com > Entegrasyon > Entegratör Bilgileri"
                Return False
            End If
            
            ' Basic Auth: EntegratorAdi:ServisAnahtari
            Dim authRaw As String = entegratorAdi & ":" & servisAnahtari
            Dim authBytes As Byte() = Encoding.UTF8.GetBytes(authRaw)
            Dim authBase64 As String = Convert.ToBase64String(authBytes)
            
            Debug.WriteLine("[HB-Invoice] ===== FATURA GÖNDERME =====")
            Debug.WriteLine("[HB-Invoice] Sipariş No: " & orderNumber)
            Debug.WriteLine("[HB-Invoice] MerchantId: " & merchantId)
            Debug.WriteLine("[HB-Invoice] Entegratör: " & entegratorAdi)
            Debug.WriteLine("[HB-Invoice] Fatura Link: " & invoiceLink)
            
            ' 1. ADIM: Package Number'ı bul
            Dim baseUrl As String = "https://oms-external.hepsiburada.com"
            Dim packageNumber As String = ""
            Dim apiHataMesaji As String = ""
            
            packageNumber = GetHepsiburadaPackageNumber(baseUrl, merchantId, orderNumber, authBase64, apiHataMesaji)
            
            If String.IsNullOrEmpty(packageNumber) Then
                Debug.WriteLine("[HB-Invoice] Paket numarası bulunamadı: " & apiHataMesaji)
                hataMesaji = apiHataMesaji
                Return False
            End If
            
            Debug.WriteLine("[HB-Invoice] Paket numarası bulundu: " & packageNumber)
            
            ' 2. ADIM: Fatura linkini gönder
            ' PUT /packages/merchantid/{merchantId}/packagenumber/{packageNumber}/invoice
            Dim url As String = baseUrl & "/packages/merchantid/" & merchantId & "/packagenumber/" & packageNumber & "/invoice"
            
            Debug.WriteLine("[HB-Invoice] URL: " & url)
            
            ' TLS 1.2 zorla
            ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType) ' TLS 1.2
            
            Dim req As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            req.Method = "PUT"
            req.ContentType = "application/json"
            req.Accept = "application/json"
            req.Timeout = 60000
            req.Headers.Add("Authorization", "Basic " & authBase64)
            req.Headers.Add("User-Agent", "BusinessSmart/1.0")
            
            ' Body: invoiceLink
            Dim payload As String = "{""invoiceLink"": """ & invoiceLink.Replace("""", "\""") & """}"
            Debug.WriteLine("[HB-Invoice] Payload: " & payload)
            
            Dim data As Byte() = Encoding.UTF8.GetBytes(payload)
            req.ContentLength = data.Length

            Using stream = req.GetRequestStream()
                stream.Write(data, 0, data.Length)
            End Using

            Using resp As HttpWebResponse = CType(req.GetResponse(), HttpWebResponse)
                Dim statusCode As Integer = CInt(resp.StatusCode)
                Debug.WriteLine("[HB-Invoice] Response Status: " & statusCode)
                
                ' 204 No Content = Başarılı
                If statusCode = 204 OrElse (statusCode >= 200 AndAlso statusCode < 300) Then
                    Return True
                Else
                    hataMesaji = "HTTP " & statusCode & ": " & resp.StatusDescription
                    Return False
                End If
            End Using

        Catch wex As WebException
            If wex.Response IsNot Nothing Then
                Try
                    Dim resp As HttpWebResponse = CType(wex.Response, HttpWebResponse)
                    Dim statusCode As Integer = CInt(resp.StatusCode)
                    Using reader As New StreamReader(resp.GetResponseStream(), Encoding.UTF8)
                        Dim errorResponse As String = reader.ReadToEnd()
                        Debug.WriteLine("[HB-Invoice] Error (" & statusCode & "): " & errorResponse)
                        
                        ' Detaylı hata mesajları
                        Select Case statusCode
                            Case 400
                                hataMesaji = "Fatura linki geçersiz format (400). Link PDF veya HTML olmalı."
                            Case 401
                                hataMesaji = "Kimlik doğrulama hatası (401). Entegratör Adı ve Servis Anahtarı'nı kontrol edin."
                            Case 403
                                hataMesaji = "Yetki hatası (403). Paket bu mağazaya ait değil veya yetkiniz yok."
                            Case 409
                                hataMesaji = "Bu pakete zaten fatura eklenmiş (409)."
                            Case 404
                                hataMesaji = "Paket bulunamadı (404)."
                            Case Else
                                hataMesaji = "HTTP " & statusCode & ": " & If(errorResponse.Length > 300, errorResponse.Substring(0, 300), errorResponse)
                        End Select
                    End Using
                Catch
                    hataMesaji = wex.Message
                End Try
            Else
                hataMesaji = wex.Message
            End If
            Return False
        Catch ex As Exception
            hataMesaji = ex.Message
            Return False
        End Try
    End Function
    
    ''' <summary>
    ''' Hepsiburada'dan sipariş numarasıyla package number'ı bul
    ''' MPOP API üzerinden çeşitli endpointleri dener
    ''' </summary>
    Private Function GetHepsiburadaPackageNumber(baseUrl As String, merchantId As String, orderNumber As String, authBase64 As String, ByRef hataMesaji As String) As String
        Try
            ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType) ' TLS 1.2
            
            Dim packageNumber As String = ""
            
            ' Tarih aralığı - son 30 gün
            Dim beginDate As String = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd")
            Dim endDate As String = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd")
            
            ' Yöntem 1: Teslim Edilen Siparişler (Delivered)
            ' GET /packages/merchantid/{merchantId}/delivered?beginDate=...&endDate=...
            Try
                Debug.WriteLine("[HB-Search] Yöntem 1: Teslim Edilenler (Delivered)")
                Dim deliveredUrl As String = baseUrl & "/packages/merchantid/" & merchantId & "/delivered?beginDate=" & beginDate & "&endDate=" & endDate & "&limit=50&offset=0"
                Debug.WriteLine("[HB-Search] URL: " & deliveredUrl)
                
                packageNumber = TryGetPackageFromUrl(deliveredUrl, authBase64, orderNumber)
                If Not String.IsNullOrEmpty(packageNumber) Then
                    Debug.WriteLine("[HB-Search] Yöntem 1 başarılı! PackageNumber: " & packageNumber)
                    Return packageNumber
                End If
            Catch ex As Exception
                Debug.WriteLine("[HB-Search] Yöntem 1 hatası: " & ex.Message)
            End Try
            
            ' Yöntem 2: Kargoda Olanlar (Shipped/InTransit)
            ' GET /packages/merchantid/{merchantId}/shipped?beginDate=...&endDate=...
            Try
                Debug.WriteLine("[HB-Search] Yöntem 2: Kargoda Olanlar (Shipped)")
                Dim shippedUrl As String = baseUrl & "/packages/merchantid/" & merchantId & "/shipped?beginDate=" & beginDate & "&endDate=" & endDate & "&limit=50&offset=0"
                Debug.WriteLine("[HB-Search] URL: " & shippedUrl)
                
                packageNumber = TryGetPackageFromUrl(shippedUrl, authBase64, orderNumber)
                If Not String.IsNullOrEmpty(packageNumber) Then
                    Debug.WriteLine("[HB-Search] Yöntem 2 başarılı! PackageNumber: " & packageNumber)
                    Return packageNumber
                End If
            Catch ex As Exception
                Debug.WriteLine("[HB-Search] Yöntem 2 hatası: " & ex.Message)
            End Try
            
            ' Yöntem 3: Açık Paketler (Open) - timespan ile son 24 saat
            ' GET /packages/merchantid/{merchantId}?timespan=24&limit=50&offset=0
            Try
                Debug.WriteLine("[HB-Search] Yöntem 3: Açık Paketler (Open)")
                Dim openUrl As String = baseUrl & "/packages/merchantid/" & merchantId & "?timespan=24&limit=50&offset=0"
                Debug.WriteLine("[HB-Search] URL: " & openUrl)
                
                packageNumber = TryGetPackageFromUrl(openUrl, authBase64, orderNumber)
                If Not String.IsNullOrEmpty(packageNumber) Then
                    Debug.WriteLine("[HB-Search] Yöntem 3 başarılı! PackageNumber: " & packageNumber)
                    Return packageNumber
                End If
            Catch ex As Exception
                Debug.WriteLine("[HB-Search] Yöntem 3 hatası: " & ex.Message)
            End Try
            
            ' Yöntem 4: Sipariş Detayı
            ' GET /orders/merchantid/{merchantId}/{orderNumber}
            Try
                Debug.WriteLine("[HB-Search] Yöntem 4: Sipariş Detayı")
                Dim orderUrl As String = baseUrl & "/orders/merchantid/" & merchantId & "/" & orderNumber
                Debug.WriteLine("[HB-Search] URL: " & orderUrl)
                
                packageNumber = TryGetPackageFromOrderDetail(orderUrl, authBase64)
                If Not String.IsNullOrEmpty(packageNumber) Then
                    Debug.WriteLine("[HB-Search] Yöntem 4 başarılı! PackageNumber: " & packageNumber)
                    Return packageNumber
                End If
            Catch ex As Exception
                Debug.WriteLine("[HB-Search] Yöntem 4 hatası: " & ex.Message)
            End Try
            
            hataMesaji = "Sipariş için paket numarası bulunamadı: " & orderNumber & ". Tüm API endpointleri denendi."
            Return Nothing
            
        Catch ex As Exception
            hataMesaji = "Paket arama hatası: " & ex.Message
            Return Nothing
        End Try
    End Function
    
    ''' <summary>
    ''' Sipariş detayından paket numarası al
    ''' </summary>
    Private Function TryGetPackageFromOrderDetail(url As String, authBase64 As String) As String
        Try
            Dim req As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            req.Method = "GET"
            req.Accept = "application/json"
            req.Timeout = 30000
            req.Headers.Add("Authorization", "Basic " & authBase64)
            req.UserAgent = "BusinessSmart/1.0"
            
            Using resp As HttpWebResponse = CType(req.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(resp.GetResponseStream(), Encoding.UTF8)
                    Dim json As String = reader.ReadToEnd()
                    Debug.WriteLine("[HB-Search] Order detail response: " & If(json.Length > 500, json.Substring(0, 500), json))
                    
                    If json.Trim().StartsWith("{") Then
                        Dim obj As JObject = JObject.Parse(json)
                        
                        ' packageNumber direkt varsa
                        If obj("packageNumber") IsNot Nothing Then
                            Return obj("packageNumber").ToString()
                        End If
                        
                        ' items içinde olabilir
                        If obj("items") IsNot Nothing Then
                            For Each item As JObject In CType(obj("items"), JArray)
                                If item("packageNumber") IsNot Nothing Then
                                    Return item("packageNumber").ToString()
                                End If
                            Next
                        End If
                        
                        ' lineItems içinde olabilir
                        If obj("lineItems") IsNot Nothing Then
                            For Each item As JObject In CType(obj("lineItems"), JArray)
                                If item("packageNumber") IsNot Nothing Then
                                    Return item("packageNumber").ToString()
                                End If
                            Next
                        End If
                    End If
                End Using
            End Using
            
            Return Nothing
        Catch wex As WebException
            Debug.WriteLine("[HB-Search] Order detail WebException: " & wex.Message)
            Return Nothing
        Catch ex As Exception
            Debug.WriteLine("[HB-Search] Order detail Exception: " & ex.Message)
            Return Nothing
        End Try
    End Function
    
    ''' <summary>
    ''' Belirtilen URL'den paket numarası almayı dene
    ''' </summary>
    Private Function TryGetPackageFromUrl(url As String, authBase64 As String, orderNumber As String) As String
        Try
            Dim req As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            req.Method = "GET"
            req.Accept = "application/json"
            req.Timeout = 30000
            req.Headers.Add("Authorization", "Basic " & authBase64)
            req.UserAgent = "BusinessSmart/1.0"
            
            Using resp As HttpWebResponse = CType(req.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(resp.GetResponseStream(), Encoding.UTF8)
                    Dim json As String = reader.ReadToEnd()
                    Debug.WriteLine("[HB-Search] Response length: " & json.Length)
                    
                    If json.Length > 0 Then
                        Debug.WriteLine("[HB-Search] Response preview: " & If(json.Length > 300, json.Substring(0, 300), json))
                    End If
                    
                    ' JSON array ise
                    If json.Trim().StartsWith("[") Then
                        Dim arr As JArray = JArray.Parse(json)
                        For Each item As JObject In arr
                            Dim itemOrderNo As String = ""
                            If item("orderNumber") IsNot Nothing Then
                                itemOrderNo = item("orderNumber").ToString()
                            ElseIf item("order_number") IsNot Nothing Then
                                itemOrderNo = item("order_number").ToString()
                            ElseIf item("OrderNumber") IsNot Nothing Then
                                itemOrderNo = item("OrderNumber").ToString()
                            End If
                            
                            Debug.WriteLine("[HB-Search] Checking order: " & itemOrderNo & " vs " & orderNumber)
                            
                            If itemOrderNo = orderNumber OrElse itemOrderNo.EndsWith(orderNumber) OrElse orderNumber.EndsWith(itemOrderNo) Then
                                Dim pkgNo As String = ""
                                If item("packageNumber") IsNot Nothing Then
                                    pkgNo = item("packageNumber").ToString()
                                ElseIf item("package_number") IsNot Nothing Then
                                    pkgNo = item("package_number").ToString()
                                ElseIf item("PackageNumber") IsNot Nothing Then
                                    pkgNo = item("PackageNumber").ToString()
                                End If
                                
                                If Not String.IsNullOrEmpty(pkgNo) Then
                                    Return pkgNo
                                End If
                            End If
                        Next
                    ' JSON object ise
                    ElseIf json.Trim().StartsWith("{") Then
                        Dim obj As JObject = JObject.Parse(json)
                        
                        ' packages array içinde olabilir
                        If obj("packages") IsNot Nothing Then
                            For Each item As JObject In CType(obj("packages"), JArray)
                                Dim pkgNo As String = ""
                                If item("packageNumber") IsNot Nothing Then
                                    pkgNo = item("packageNumber").ToString()
                                End If
                                If Not String.IsNullOrEmpty(pkgNo) Then
                                    Return pkgNo
                                End If
                            Next
                        End If
                        
                        ' Direkt packageNumber olabilir
                        If obj("packageNumber") IsNot Nothing Then
                            Return obj("packageNumber").ToString()
                        End If
                    End If
                End Using
            End Using
            
            Return Nothing
            
        Catch wex As WebException
            If wex.Response IsNot Nothing Then
                Try
                    Dim resp As HttpWebResponse = CType(wex.Response, HttpWebResponse)
                    Dim statusCode As Integer = CInt(resp.StatusCode)
                    Using reader As New StreamReader(resp.GetResponseStream(), Encoding.UTF8)
                        Dim errorResponse As String = reader.ReadToEnd()
                        Debug.WriteLine("[HB-Search] HTTP " & statusCode & ": " & If(errorResponse.Length > 200, errorResponse.Substring(0, 200), errorResponse))
                    End Using
                Catch
                    Debug.WriteLine("[HB-Search] WebException: " & wex.Message)
                End Try
            Else
                Debug.WriteLine("[HB-Search] WebException (no response): " & wex.Message)
            End If
            Return Nothing
        Catch ex As Exception
            Debug.WriteLine("[HB-Search] Exception: " & ex.Message)
            Return Nothing
        End Try
    End Function
    

    ''' <summary>
    ''' N11'e fatura linki gönder
    ''' SOAP API: https://api.n11.com/ws/SellerInvoiceService.wsdl
    ''' Metod: saveLinkSellerInvoice
    ''' </summary>
    Private Function GonderN11(siparisNo As String, gibFaturaNo As String, faturaGuid As String, ByRef hataMesaji As String) As Boolean
        Try
            If Not pazaryeriApis.ContainsKey("N11") Then
                hataMesaji = "N11 API ayarları bulunamadı"
                Return False
            End If

            Dim api = pazaryeriApis("N11")
            
            Debug.WriteLine("[N11] ===== N11 FATURA GÖNDERME =====")
            Debug.WriteLine("[N11] Sipariş No: " & siparisNo)
            Debug.WriteLine("[N11] GİB Fatura No: " & gibFaturaNo)
            Debug.WriteLine("[N11] API Key: " & If(String.IsNullOrEmpty(api.ApiKey), "BOŞ", api.ApiKey.Substring(0, Math.Min(10, api.ApiKey.Length)) & "..."))

            ' Sipariş numarasını temizle (N11 prefix varsa kaldır)
            Dim orderNumber As String = siparisNo.Replace("N11", "").Replace("n11", "").Trim()
            Debug.WriteLine("[N11] Order Number: " & orderNumber)
            
            ' Fatura linki al - N11 sadece pdf, png, jpeg kabul ediyor
            Dim invoiceLink As String = GetKolaysoftFaturaLink(gibFaturaNo, faturaGuid)
            If String.IsNullOrEmpty(invoiceLink) Then
                hataMesaji = "Fatura linki alınamadı"
                Debug.WriteLine("[N11] HATA: Fatura linki alınamadı")
                Return False
            End If
            Debug.WriteLine("[N11] Fatura Link: " & invoiceLink)
            
            ' N11 SOAP API endpoint
            Dim soapUrl As String = "https://api.n11.com/ws/SellerInvoiceService.wsdl"
            Dim soapAction As String = "http://www.n11.com/ws/SellerInvoiceService/saveLinkSellerInvoice"
            
            ' SOAP XML Request oluştur
            ' ÖNEMLİ: URL'deki & karakterini &amp; olarak encode et
            Dim encodedUrl As String = invoiceLink.Replace("&", "&amp;")
            
            Dim soapRequest As String = "<?xml version=""1.0"" encoding=""utf-8""?>" &
                "<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:sch=""http://www.n11.com/ws/schemas"">" &
                "<soapenv:Header/>" &
                "<soapenv:Body>" &
                "<sch:SaveLinkSellerInvoiceRequest>" &
                "<auth>" &
                "<appKey>" & api.ApiKey & "</appKey>" &
                "<appSecret>" & api.ApiSecret & "</appSecret>" &
                "</auth>" &
                "<url>" & encodedUrl & "</url>" &
                "<orderNumber>" & orderNumber & "</orderNumber>" &
                "</sch:SaveLinkSellerInvoiceRequest>" &
                "</soapenv:Body>" &
                "</soapenv:Envelope>"
            
            Debug.WriteLine("[N11] SOAP Request (preview): " & soapRequest.Substring(0, Math.Min(500, soapRequest.Length)))
            
            ' HTTP Request gönder
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            
            Dim req As HttpWebRequest = CType(WebRequest.Create("https://api.n11.com/ws/SellerInvoiceService"), HttpWebRequest)
            req.Method = "POST"
            req.ContentType = "text/xml; charset=utf-8"
            req.Accept = "text/xml"
            req.Headers.Add("SOAPAction", soapAction)
            req.Timeout = 30000
            
            Dim data As Byte() = Encoding.UTF8.GetBytes(soapRequest)
            req.ContentLength = data.Length
            
            Using stream = req.GetRequestStream()
                stream.Write(data, 0, data.Length)
            End Using
            
            Using resp As HttpWebResponse = CType(req.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(resp.GetResponseStream(), Encoding.UTF8)
                    Dim responseXml As String = reader.ReadToEnd()
                    Debug.WriteLine("[N11] Response: " & responseXml)
                    
                    ' Response'u parse et
                    If responseXml.Contains("<status>success</status>") Then
                        Debug.WriteLine("[N11] BAŞARILI!")
                        Return True
                    ElseIf responseXml.Contains("<status>failure</status>") Then
                        ' Hata mesajını çıkar
                        Dim errorMatch As System.Text.RegularExpressions.Match = 
                            System.Text.RegularExpressions.Regex.Match(responseXml, "<errorMessage>(.*?)</errorMessage>")
                        If errorMatch.Success Then
                            hataMesaji = errorMatch.Groups(1).Value
                        Else
                            hataMesaji = "N11 API hatası (failure)"
                        End If
                        Debug.WriteLine("[N11] HATA: " & hataMesaji)
                        Return False
                    Else
                        hataMesaji = "Beklenmeyen yanıt formatı"
                        Return False
                    End If
                End Using
            End Using
            
        Catch wex As WebException
            If wex.Response IsNot Nothing Then
                Try
                    Dim resp As HttpWebResponse = CType(wex.Response, HttpWebResponse)
                    Dim statusCode As Integer = CInt(resp.StatusCode)
                    Using reader As New StreamReader(resp.GetResponseStream(), Encoding.UTF8)
                        Dim errorBody As String = reader.ReadToEnd()
                        Debug.WriteLine("[N11] WebException (" & statusCode & "): " & errorBody)
                        
                        ' SOAP Fault mesajını çıkarmaya çalış
                        Dim faultMatch As System.Text.RegularExpressions.Match = 
                            System.Text.RegularExpressions.Regex.Match(errorBody, "<faultstring>(.*?)</faultstring>")
                        If faultMatch.Success Then
                            hataMesaji = faultMatch.Groups(1).Value
                        Else
                            hataMesaji = "HTTP " & statusCode & ": " & If(errorBody.Length > 200, errorBody.Substring(0, 200), errorBody)
                        End If
                    End Using
                Catch
                    hataMesaji = wex.Message
                End Try
            Else
                hataMesaji = wex.Message
                Debug.WriteLine("[N11] WebException (no response): " & hataMesaji)
            End If
            Return False
        Catch ex As Exception
            hataMesaji = ex.Message
            Debug.WriteLine("[N11] Exception: " & hataMesaji)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Pazarama'ya fatura linki gönder
    ''' API: https://isortagim.pazarama.com
    ''' NOT: Pazarama resmi fatura API dokümantasyonu bulunamadı.
    ''' Bu fonksiyon placeholder olarak eklenmiştir.
    ''' </summary>
    Private Function GonderPazarama(siparisNo As String, gibFaturaNo As String, faturaGuid As String, ByRef hataMesaji As String) As Boolean
        Try
            If Not pazaryeriApis.ContainsKey("PAZARAMA") Then
                hataMesaji = "Pazarama API ayarları bulunamadı"
                Return False
            End If

            Dim api = pazaryeriApis("PAZARAMA")
            
            Debug.WriteLine("[PAZ] ===== PAZARAMA FATURA GÖNDERME =====")
            Debug.WriteLine("[PAZ] Sipariş No: " & siparisNo)
            Debug.WriteLine("[PAZ] GİB Fatura No: " & gibFaturaNo)
            
            ' Sipariş numarasını temizle (PAZ prefix varsa kaldır)
            Dim orderNumber As String = siparisNo.Replace("PAZ", "").Replace("paz", "").Trim()
            Debug.WriteLine("[PAZ] Order Number: " & orderNumber)
            
            ' Fatura linki al
            Dim invoiceLink As String = GetKolaysoftFaturaLink(gibFaturaNo, faturaGuid)
            If String.IsNullOrEmpty(invoiceLink) Then
                hataMesaji = "Fatura linki alınamadı"
                Debug.WriteLine("[PAZ] HATA: Fatura linki alınamadı")
                Return False
            End If
            Debug.WriteLine("[PAZ] Fatura Link: " & invoiceLink)
            
            ' Pazarama API bilgileri
            Dim baseUrl As String = If(String.IsNullOrEmpty(api.BaseUrl), "https://isortagim.pazarama.com", api.BaseUrl.TrimEnd("/"c))
            Dim apiKey As String = api.ApiKey
            Dim apiSecret As String = api.ApiSecret
            
            If String.IsNullOrEmpty(apiKey) OrElse String.IsNullOrEmpty(apiSecret) Then
                hataMesaji = "Pazarama API Key veya Secret eksik"
                Return False
            End If
            
            ' ===== PAZARAMA FATURA GÖNDERİM ENDPOINTİ =====
            ' Pazarama'nın resmi fatura gönderim API'si dokümantasyonu bulunamadı.
            ' Aşağıdaki endpoint tahminidir ve test edilmelidir.
            ' Doğru endpoint için Pazarama destek ile iletişime geçilmesi önerilir.
            
            ' Tahmini endpoint: PUT /api/v1/orders/{orderNumber}/invoice
            Dim url As String = baseUrl & "/api/v1/orders/" & orderNumber & "/invoice"
            Debug.WriteLine("[PAZ] URL (tahmini): " & url)
            
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            
            Dim req As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            req.Method = "PUT"
            req.ContentType = "application/json"
            req.Accept = "application/json"
            req.Timeout = 30000
            
            ' Pazarama genellikle Header'da API Key kullanıyor
            req.Headers.Add("X-API-KEY", apiKey)
            req.Headers.Add("X-API-SECRET", apiSecret)
            
            ' Body
            Dim payload As String = "{""invoiceLink"": """ & invoiceLink.Replace("""", "\""") & """, ""invoiceNumber"": """ & gibFaturaNo & """}"
            Debug.WriteLine("[PAZ] Payload: " & payload)
            
            Dim data As Byte() = Encoding.UTF8.GetBytes(payload)
            req.ContentLength = data.Length
            
            Using stream = req.GetRequestStream()
                stream.Write(data, 0, data.Length)
            End Using
            
            Using resp As HttpWebResponse = CType(req.GetResponse(), HttpWebResponse)
                Dim statusCode As Integer = CInt(resp.StatusCode)
                Debug.WriteLine("[PAZ] Response Status: " & statusCode)
                
                If statusCode >= 200 AndAlso statusCode < 300 Then
                    Debug.WriteLine("[PAZ] BAŞARILI!")
                    Return True
                Else
                    hataMesaji = "HTTP " & statusCode & ": " & resp.StatusDescription
                    Debug.WriteLine("[PAZ] HATA: " & hataMesaji)
                    Return False
                End If
            End Using
            
        Catch wex As WebException
            If wex.Response IsNot Nothing Then
                Try
                    Dim resp As HttpWebResponse = CType(wex.Response, HttpWebResponse)
                    Dim statusCode As Integer = CInt(resp.StatusCode)
                    Using reader As New StreamReader(resp.GetResponseStream(), Encoding.UTF8)
                        Dim errorBody As String = reader.ReadToEnd()
                        Debug.WriteLine("[PAZ] WebException (" & statusCode & "): " & errorBody)
                        
                        ' Özel hata mesajları
                        Select Case statusCode
                            Case 401
                                hataMesaji = "Yetkilendirme hatası (401). API Key ve Secret'ı kontrol edin."
                            Case 404
                                hataMesaji = "Endpoint bulunamadı (404). Pazarama fatura API'si farklı olabilir."
                            Case Else
                                hataMesaji = "HTTP " & statusCode & ": " & If(errorBody.Length > 200, errorBody.Substring(0, 200), errorBody)
                        End Select
                    End Using
                Catch
                    hataMesaji = wex.Message
                End Try
            Else
                hataMesaji = wex.Message
                Debug.WriteLine("[PAZ] WebException (no response): " & hataMesaji)
            End If
            Return False
        Catch ex As Exception
            hataMesaji = ex.Message
            Debug.WriteLine("[PAZ] Exception: " & hataMesaji)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' GİB e-Arşiv fatura linkini al
    ''' Önce tbStokFisiMaster'dan sEfaturaUrl kontrol edilir, yoksa GİB standart URL formatı kullanılır
    ''' </summary>
    Private Function GetKolaysoftFaturaLink(gibFaturaNo As String, faturaGuid As String) As String
        Try
            ' Önce veritabanından kayıtlı fatura URL'ini kontrol et
            Dim faturaUrl As String = ""
            
            Using con As New OleDbConnection(connection)
                con.Open()
                
                ' tbStokFisiMaster'da sEfaturaUrl sütunu var mı kontrol et ve değerini al
                Try
                    Using cmd As New OleDbCommand("SELECT TOP 1 sEfaturaUrl FROM tbStokFisiMaster WHERE GibFaturaNo = ? AND sEfaturaUrl IS NOT NULL AND sEfaturaUrl <> ''", con)
                        cmd.Parameters.Add("p0", OleDbType.VarChar, 50).Value = gibFaturaNo
                        Dim result = cmd.ExecuteScalar()
                        If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                            faturaUrl = result.ToString().Trim()
                        End If
                    End Using
                Catch
                    ' sEfaturaUrl sütunu yoksa devam et
                End Try
                
                ' Eğer veritabanında URL yoksa, GİB standart formatını kullan
                If String.IsNullOrEmpty(faturaUrl) AndAlso Not String.IsNullOrEmpty(faturaGuid) Then
                    ' GİB e-Arşiv portal linki formatı
                    ' Format: https://earsivportal.efatura.gov.tr/intragiris.html?ettn=GUID
                    faturaUrl = "https://earsivportal.efatura.gov.tr/intragiris.html?ettn=" & faturaGuid
                End If
            End Using
            
            ' Hala URL yoksa ve GibFaturaNo varsa, alternatif format dene
            If String.IsNullOrEmpty(faturaUrl) AndAlso Not String.IsNullOrEmpty(gibFaturaNo) Then
                ' Alternatif: GİB sorgu linki
                faturaUrl = "https://earsivportal.efatura.gov.tr/intragiris.html?fatession=" & gibFaturaNo
            End If
            
            Return faturaUrl
            
        Catch ex As Exception
            Debug.WriteLine("Fatura link hatası: " & ex.Message)
            Return ""
        End Try
    End Function

    ''' <summary>
    ''' Gönderim sonucunu veritabanına kaydet
    ''' </summary>
    Private Sub KaydetGonderimSonucu(nStokFisiID As Integer, pazaryeri As String, siparisNo As String,
                                     gibFaturaNo As String, faturaGuid As String, basarili As Boolean, hataMesaji As String)
        Try
            Using con As New OleDbConnection(connection)
                con.Open()

                ' Mevcut kayıt var mı kontrol et
                Dim mevcutID As Object = Nothing
                Using cmdCheck As New OleDbCommand("SELECT nID FROM tbPazaryeriFaturaGonderim WHERE nStokFisiID = ?", con)
                    cmdCheck.Parameters.Add("p0", OleDbType.Integer).Value = nStokFisiID
                    mevcutID = cmdCheck.ExecuteScalar()
                End Using

                If mevcutID Is Nothing Then
                    ' Yeni kayıt ekle
                    Using cmd As New OleDbCommand(
                        "INSERT INTO tbPazaryeriFaturaGonderim (nStokFisiID, sPazaryeri, sSiparisNo, sFaturaNo, sFaturaUUID, bGonderildi, dteGonderimTarihi, sGonderimSonucu, sHataMesaji, nDenemeAdet) " &
                        "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", con)
                        cmd.Parameters.Add("p0", OleDbType.Integer).Value = nStokFisiID
                        cmd.Parameters.Add("p1", OleDbType.VarChar, 50).Value = pazaryeri
                        cmd.Parameters.Add("p2", OleDbType.VarChar, 50).Value = siparisNo
                        cmd.Parameters.Add("p3", OleDbType.VarChar, 50).Value = gibFaturaNo
                        cmd.Parameters.Add("p4", OleDbType.VarChar, 100).Value = If(String.IsNullOrEmpty(faturaGuid), DBNull.Value, CObj(faturaGuid))
                        cmd.Parameters.Add("p5", OleDbType.Boolean).Value = basarili
                        cmd.Parameters.Add("p6", OleDbType.DBTimeStamp).Value = DateTime.Now
                        cmd.Parameters.Add("p7", OleDbType.VarChar, 500).Value = If(basarili, "Başarılı", "Başarısız")
                        cmd.Parameters.Add("p8", OleDbType.VarChar, 500).Value = If(String.IsNullOrEmpty(hataMesaji), DBNull.Value, CObj(hataMesaji))
                        cmd.Parameters.Add("p9", OleDbType.Integer).Value = 1
                        cmd.ExecuteNonQuery()
                    End Using
                Else
                    ' Mevcut kaydı güncelle
                    Using cmd As New OleDbCommand(
                        "UPDATE tbPazaryeriFaturaGonderim SET bGonderildi = ?, dteGonderimTarihi = ?, sGonderimSonucu = ?, sHataMesaji = ?, nDenemeAdet = nDenemeAdet + 1 " &
                        "WHERE nStokFisiID = ?", con)
                        cmd.Parameters.Add("p0", OleDbType.Boolean).Value = basarili
                        cmd.Parameters.Add("p1", OleDbType.DBTimeStamp).Value = DateTime.Now
                        cmd.Parameters.Add("p2", OleDbType.VarChar, 500).Value = If(basarili, "Başarılı", "Başarısız")
                        cmd.Parameters.Add("p3", OleDbType.VarChar, 500).Value = If(String.IsNullOrEmpty(hataMesaji), DBNull.Value, CObj(hataMesaji))
                        cmd.Parameters.Add("p4", OleDbType.Integer).Value = nStokFisiID
                        cmd.ExecuteNonQuery()
                    End Using
                End If
            End Using
        Catch ex As Exception
            Debug.WriteLine("Gönderim sonucu kayıt hatası: " & ex.Message)
        End Try
    End Sub

    Private Sub chkTumunuSec_CheckedChanged(sender As Object, e As EventArgs) Handles chkTumunuSec.CheckedChanged
        If chkTumunuSec.Checked Then
            GridView1.SelectAll()
        Else
            GridView1.ClearSelection()
        End If
    End Sub

    Private Sub frm_PazaryeriFaturaGonderim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Connection atandıktan sonra API'leri yükle
        If Not String.IsNullOrEmpty(connection) Then
            LoadPazaryeriApis()
            ListeleFaturalar()
            
            ' Form açılışında teslim durumlarını güncelle
            ' (Zaten teslim edilmiş/iptal olanlar atlanıyor, hızlı çalışır)
            TeslimDurumlariniGuncelle()
        Else
            lblDurum.Text = "Hata: Veritabanı bağlantısı yok!"
        End If
    End Sub
    
    ''' <summary>
    ''' Sadece Teslim Edilenler checkbox değiştiğinde listeyi yenile
    ''' </summary>
    Private Sub chkSadeceTeslimEdilenler_CheckedChanged(sender As Object, e As EventArgs) Handles chkSadeceTeslimEdilenler.CheckedChanged
        Debug.WriteLine("[CHECKBOX] Sadece Teslim Edilenler: " & chkSadeceTeslimEdilenler.Checked.ToString())
        ListeleFaturalar()
    End Sub
    
    ' ===== CONTEXT MENU EVENT HANDLERS =====
    
    ''' <summary>
    ''' Sütun özelleştirme dialogunu aç
    ''' </summary>
    Private Sub mnuSutunOzellestir_Click(sender As Object, e As EventArgs) Handles mnuSutunOzellestir.Click
        GridView1.ColumnsCustomization()
    End Sub
    
    ''' <summary>
    ''' Görünümü registry'ye kaydet
    ''' </summary>
    Private Sub mnuGorunumKaydet_Click(sender As Object, e As EventArgs) Handles mnuGorunumKaydet.Click
        gorunum_kaydet()
    End Sub
    
    ''' <summary>
    ''' Filtreleme satırını aç/kapat
    ''' </summary>
    Private Sub mnuFiltrele_Click(sender As Object, e As EventArgs) Handles mnuFiltrele.Click
        GridView1.OptionsView.ShowAutoFilterRow = Not GridView1.OptionsView.ShowAutoFilterRow
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView1.OptionsCustomization.AllowFilter = True
    End Sub
    
    ''' <summary>
    ''' Trendyol'dan teslim durumlarını güncelle
    ''' </summary>
    Private Sub mnuTeslimDurumuGuncelle_Click(sender As Object, e As EventArgs) Handles mnuTeslimDurumuGuncelle.Click
        TeslimDurumlariniGuncelle()
    End Sub
    
    ' ===== GÖRÜNÜM FONKSİYONLARI =====
    
    ''' <summary>
    ''' Görünümü registry'ye kaydet
    ''' </summary>
    Private Sub gorunum_kaydet()
        Try
            GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString())
            MessageBox.Show("Görünüm kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Görünüm kaydedilirken hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ''' <summary>
    ''' Görünümü registry'den yükle
    ''' </summary>
    Private Sub gorunum_yukle()
        Try
            GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString())
        Catch ex As Exception
            ' İlk açılışta registry kaydı olmayabilir, sessizce geç
            Debug.WriteLine("Görünüm yüklenemedi: " & ex.Message)
        End Try
    End Sub
    
    ' ===== TESLİM DURUMU FONKSİYONLARI =====
    
    ''' <summary>
    ''' Seçili Trendyol siparişlerinin teslim durumlarını API'den çekip günceller
    ''' </summary>
    Private Sub TeslimDurumlariniGuncelle()
        Try
            Cursor = Cursors.WaitCursor
            lblDurum.Text = "Teslim durumları güncelleniyor..."
            Application.DoEvents()
            
            ' Trendyol API bilgilerini al
            If Not pazaryeriApis.ContainsKey("TRENDYOL") Then
                MessageBox.Show("Trendyol API ayarları bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Cursor = Cursors.Default
                Return
            End If
            
            Dim api = pazaryeriApis("TRENDYOL")
            Dim guncellenen As Integer = 0
            Dim atlanan As Integer = 0
            Dim hata As Integer = 0
            
            For i As Integer = 0 To dtFaturalar.Rows.Count - 1
                Dim row As DataRow = dtFaturalar.Rows(i)
                Dim pazaryeri As String = row("Pazaryeri").ToString()
                
                ' Sadece Trendyol siparişlerini kontrol et
                If pazaryeri <> "Trendyol" Then Continue For
                
                ' Zaten teslim edilmiş olanları atla
                Dim mevcutDurum As String = row("TeslimDurumu").ToString().Trim()
                If mevcutDurum.ToUpperInvariant().Contains("TESLİM EDİLDİ") OrElse 
                   mevcutDurum.ToUpperInvariant().Contains("TESLIM EDILDI") OrElse
                   mevcutDurum.ToUpperInvariant().Contains("DELIVERED") OrElse
                   mevcutDurum.ToUpperInvariant().Contains("İPTAL") OrElse
                   mevcutDurum.ToUpperInvariant().Contains("IPTAL") OrElse
                   mevcutDurum.ToUpperInvariant().Contains("CANCELLED") Then
                    atlanan += 1
                    Continue For
                End If
                
                Dim siparisNo As String = row("SiparisNo").ToString().Trim()
                If String.IsNullOrEmpty(siparisNo) Then Continue For
                
                ' Sipariş numarasından TY prefix'ini kaldır
                Dim orderNumber As String = siparisNo
                If orderNumber.StartsWith("TY") Then
                    orderNumber = orderNumber.Substring(2)
                End If
                
                lblDurum.Text = "Kontrol ediliyor: " & siparisNo & " (" & (i + 1) & "/" & dtFaturalar.Rows.Count & ")"
                Application.DoEvents()
                
                Try
                    Dim teslimDurumu As String = GetTrendyolTeslimDurumu(api, orderNumber)
                    If Not String.IsNullOrEmpty(teslimDurumu) Then
                        row("TeslimDurumu") = teslimDurumu
                        
                        ' Veritabanına kaydet
                        KaydetTeslimDurumu(CInt(row("nStokFisiID")), teslimDurumu)
                        guncellenen += 1
                    End If
                Catch ex As Exception
                    Debug.WriteLine("Teslim durumu alınamadı: " & siparisNo & " - " & ex.Message)
                    hata += 1
                End Try
            Next
            
            GridView1.RefreshData()
            lblDurum.Text = "Tamamlandı! Güncellenen: " & guncellenen & ", Atlanan (zaten teslim/iptal): " & atlanan & ", Hata: " & hata
            Cursor = Cursors.Default
            
        Catch ex As Exception
            Cursor = Cursors.Default
            lblDurum.Text = "Hata: " & ex.Message
            MessageBox.Show("Teslim durumları güncellenirken hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ''' <summary>
    ''' Trendyol API'den sipariş teslim durumunu çeker
    ''' </summary>
    Private Function GetTrendyolTeslimDurumu(api As PazaryeriAPI, orderNumber As String) As String
        Try
            ' Trendyol sipariş detayı API'si
            Dim url As String = api.BaseUrl & "/integration/order/sellers/" & api.SellerId & "/orders?orderNumber=" & orderNumber
            
            Dim req As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            req.Method = "GET"
            req.ContentType = "application/json"
            req.Accept = "application/json"
            req.Timeout = 30000
            
            ' Basic Auth
            Dim credentials As String = api.ApiKey & ":" & api.ApiSecret
            Dim base64Credentials As String = Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials))
            req.Headers.Add("Authorization", "Basic " & base64Credentials)
            
            Using resp As HttpWebResponse = CType(req.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(resp.GetResponseStream(), Encoding.UTF8)
                    Dim json As String = reader.ReadToEnd()
                    Dim obj As JObject = JObject.Parse(json)
                    
                    If obj("content") IsNot Nothing Then
                        Dim contentArray As JArray = CType(obj("content"), JArray)
                        If contentArray.Count > 0 Then
                            Dim order As JObject = CType(contentArray(0), JObject)
                            
                            ' Sipariş durumu
                            Dim status As String = ""
                            If order("status") IsNot Nothing Then
                                status = order("status").ToString()
                            End If
                            
                            ' Kargo durumu
                            Dim cargoTrackingNumber As String = ""
                            Dim cargoProviderName As String = ""
                            
                            If order("cargoTrackingNumber") IsNot Nothing Then
                                cargoTrackingNumber = order("cargoTrackingNumber").ToString()
                            End If
                            If order("cargoProviderName") IsNot Nothing Then
                                cargoProviderName = order("cargoProviderName").ToString()
                            End If
                            
                            ' lines içinden deliveredDate kontrol et
                            Dim deliveredDate As String = ""
                            If order("lines") IsNot Nothing Then
                                Dim lines As JArray = CType(order("lines"), JArray)
                                For Each line As JObject In lines
                                    If line("deliveredDate") IsNot Nothing Then
                                        deliveredDate = line("deliveredDate").ToString()
                                        Exit For
                                    End If
                                Next
                            End If
                            
                            ' Durum metnini oluştur
                            Dim durumMetni As String = status
                            If Not String.IsNullOrEmpty(deliveredDate) Then
                                durumMetni = "Teslim Edildi"
                            ElseIf status.ToUpperInvariant() = "DELIVERED" Then
                                durumMetni = "Teslim Edildi"
                            ElseIf status.ToUpperInvariant() = "SHIPPED" Then
                                durumMetni = "Kargoda"
                            ElseIf status.ToUpperInvariant() = "PICKING" Then
                                durumMetni = "Hazırlanıyor"
                            ElseIf status.ToUpperInvariant() = "INVOICED" Then
                                durumMetni = "Faturalandı"
                            ElseIf status.ToUpperInvariant() = "CANCELLED" Then
                                durumMetni = "İptal"
                            End If
                            
                            If Not String.IsNullOrEmpty(cargoTrackingNumber) Then
                                durumMetni &= " (" & cargoProviderName & ": " & cargoTrackingNumber & ")"
                            End If
                            
                            Return durumMetni
                        End If
                    End If
                End Using
            End Using
            
            Return ""
        Catch ex As Exception
            Debug.WriteLine("GetTrendyolTeslimDurumu hata: " & ex.Message)
            Return ""
        End Try
    End Function
    
    ''' <summary>
    ''' Teslim durumunu tbStokFisiMaster tablosuna kaydet
    ''' </summary>
    Private Sub KaydetTeslimDurumu(nStokFisiID As Integer, teslimDurumu As String)
        Try
            Using con As New OleDbConnection(connection)
                con.Open()
                
                ' tbStokFisiMaster tablosunda güncelle
                Dim sqlUpdate As String = "UPDATE tbStokFisiMaster SET sTeslimDurumu = ? WHERE nStokFisiID = ?"
                Using cmdUpdate As New OleDbCommand(sqlUpdate, con)
                    cmdUpdate.Parameters.AddWithValue("@p0", teslimDurumu)
                    cmdUpdate.Parameters.AddWithValue("@p1", nStokFisiID)
                    cmdUpdate.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Debug.WriteLine("KaydetTeslimDurumu hata: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Faturayı ihracat faturası olarak işaretler (KDV %0, istisna kodu 301)
    ''' 3065 sayılı KDV Kanunu 11/1-a maddesi gereği ihracat istisnası
    ''' </summary>
    Private Sub IhracatFaturasıOlarakIsaretle(nStokFisiID As Integer)
        Try
            Using con As New OleDbConnection(connection)
                con.Open()
                
                ' 1. Fatura tipini İhracat Faturası olarak ayarla
                ' 2. KDV muafiyet kodunu 301 (ihracat istisnası) olarak ayarla
                ' 3. KDV oranlarını %0 yap
                Dim sqlUpdate As String = "UPDATE tbStokFisiMaster SET " &
                    "bFaturaTipi = 'İhracat Faturası', " &
                    "nKdvMuafiyetKodu = '301' " &
                    "WHERE nStokFisiID = ?"
                    
                Using cmdUpdate As New OleDbCommand(sqlUpdate, con)
                    cmdUpdate.Parameters.AddWithValue("@p0", nStokFisiID)
                    cmdUpdate.ExecuteNonQuery()
                End Using
                
                ' Fatura detaylarındaki KDV oranlarını da sıfırla
                Dim sqlDetay As String = "UPDATE tbStokFisiDetayi SET " &
                    "nKdvOrani = 0, " &
                    "lKdvTutari = 0 " &
                    "WHERE nStokFisiID = ?"
                    
                Using cmdDetay As New OleDbCommand(sqlDetay, con)
                    cmdDetay.Parameters.AddWithValue("@p0", nStokFisiID)
                    cmdDetay.ExecuteNonQuery()
                End Using
                
                ' Master tablosundaki toplam KDV'yi de sıfırla
                Dim sqlMaster As String = "UPDATE tbStokFisiMaster SET " &
                    "lToplamKdv = 0 " &
                    "WHERE nStokFisiID = ?"
                    
                Using cmdMaster As New OleDbCommand(sqlMaster, con)
                    cmdMaster.Parameters.AddWithValue("@p0", nStokFisiID)
                    cmdMaster.ExecuteNonQuery()
                End Using
                
                Debug.WriteLine("[IHRACAT] Fatura ihracat olarak işaretlendi: nStokFisiID=" & nStokFisiID)
                Debug.WriteLine("[IHRACAT] bFaturaTipi='İhracat Faturası', nKdvMuafiyetKodu='301', KDV=%0")
                
            End Using
        Catch ex As Exception
            Debug.WriteLine("[IHRACAT] İhracat faturası işaretleme hatası: " & ex.Message)
        End Try
    End Sub
    
End Class
