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
    Private WithEvents PanelControl1 As PanelControl
    Private WithEvents GroupControl1 As GroupControl

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
        cmbPazaryeri.Properties.Items.AddRange(New String() {"Tümü", "Trendyol", "Hepsiburada", "N11"})
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
        dtBaslangic.EditValue = DateTime.Today.AddDays(-30)
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

        ' Durum Label
        lblDurum = New LabelControl()
        lblDurum.Text = "Hazır"
        lblDurum.Location = New Point(650, 50)
        lblDurum.AutoSizeMode = LabelAutoSizeMode.None
        lblDurum.Size = New Size(400, 20)
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

            Dim pazaryeriFiltre As String = ""
            Select Case cmbPazaryeri.SelectedIndex
                Case 1 ' Trendyol
                    pazaryeriFiltre = " AND A.sAciklama3 LIKE 'TY%' "
                Case 2 ' Hepsiburada
                    pazaryeriFiltre = " AND A.sAciklama3 LIKE 'HB%' "
                Case 3 ' N11
                    pazaryeriFiltre = " AND A.sAciklama3 LIKE 'N11%' "
            End Select

            Dim sql As String = "SELECT " &
                "M.nStokFisiID, " &
                "M.dteFisTarihi, " &
                "M.lFisNo, " &
                "M.GibFaturaNo, " &
                "M.sEfaturaGuid, " &
                "M.sEfaturaTipi, " &
                "M.lNetTutar, " &
                "A.sAciklama3 AS SiparisNo, " &
                "CASE " &
                "   WHEN A.sAciklama3 LIKE 'TY%' THEN 'Trendyol' " &
                "   WHEN A.sAciklama3 LIKE 'HB%' THEN 'Hepsiburada' " &
                "   WHEN A.sAciklama3 LIKE 'N11%' THEN 'N11' " &
                "   ELSE 'Bilinmiyor' " &
                "END AS Pazaryeri, " &
                "ISNULL(P.bGonderildi, 0) AS bGonderildi, " &
                "P.dteGonderimTarihi, " &
                "P.sGonderimSonucu, " &
                "P.sHataMesaji " &
                "FROM tbStokFisiMaster M " &
                "INNER JOIN tbStokFisiAciklamasi A ON M.nStokFisiID = A.nStokFisiID " &
                "LEFT JOIN tbPazaryeriFaturaGonderim P ON M.nStokFisiID = P.nStokFisiID " &
                "WHERE M.dteFisTarihi >= ? AND M.dteFisTarihi <= ? " &
                "AND M.GibFaturaNo IS NOT NULL AND M.GibFaturaNo <> '' " &
                "AND (A.sAciklama3 LIKE 'TY%' OR A.sAciklama3 LIKE 'HB%' OR A.sAciklama3 LIKE 'N11%') " &
                "AND ISNULL(P.bGonderildi, 0) = 0 " &
                pazaryeriFiltre &
                "ORDER BY M.dteFisTarihi DESC"

            Using con As New OleDbConnection(connection)
                con.Open()
                Using cmd As New OleDbCommand(sql, con)
                    cmd.Parameters.Add("@bas", OleDbType.Date).Value = CDate(dtBaslangic.EditValue)
                    cmd.Parameters.Add("@bit", OleDbType.Date).Value = CDate(dtBitis.EditValue)
                    Using adapter As New OleDbDataAdapter(cmd)
                        adapter.Fill(dtFaturalar)
                    End Using
                End Using
            End Using

            GridControl1.DataSource = dtFaturalar
            GridView1.BestFitColumns()

            ' Sütun başlıklarını düzenle
            For Each col As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
                Select Case col.FieldName
                    Case "nStokFisiID" : col.Visible = False
                    Case "dteFisTarihi" : col.Caption = "Fatura Tarihi"
                    Case "lFisNo" : col.Caption = "Fiş No"
                    Case "GibFaturaNo" : col.Caption = "GİB Fatura No"
                    Case "sEfaturaGuid" : col.Caption = "Fatura UUID"
                    Case "sEfaturaTipi" : col.Caption = "Fatura Tipi"
                    Case "lNetTutar" : col.Caption = "Net Tutar" : col.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric : col.DisplayFormat.FormatString = "N2"
                    Case "SiparisNo" : col.Caption = "Sipariş No"
                    Case "Pazaryeri" : col.Caption = "Pazaryeri"
                    Case "bGonderildi" : col.Visible = False
                    Case "dteGonderimTarihi" : col.Caption = "Gönderim Tarihi"
                    Case "sGonderimSonucu" : col.Caption = "Sonuç"
                    Case "sHataMesaji" : col.Caption = "Hata"
                End Select
            Next

            lblDurum.Text = $"Toplam {dtFaturalar.Rows.Count} fatura listelendi. Gönderilmeyi bekliyor."
            Cursor = Cursors.Default

        Catch ex As Exception
            Cursor = Cursors.Default
            lblDurum.Text = "Hata: " & ex.Message
            MessageBox.Show("Faturalar listelenirken hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSecilileriGonder_Click(sender As Object, e As EventArgs) Handles btnSecilileriGonder.Click
        Dim selectedRows As Integer() = GridView1.GetSelectedRows()
        If selectedRows.Length = 0 Then
            MessageBox.Show("Lütfen en az bir fatura seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show($"{selectedRows.Length} fatura pazaryerlerine gönderilecek. Devam edilsin mi?",
                          "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            GonderFaturalar(selectedRows)
        End If
    End Sub

    Private Sub btnTumunuGonder_Click(sender As Object, e As EventArgs) Handles btnTumunuGonder.Click
        If dtFaturalar.Rows.Count = 0 Then
            MessageBox.Show("Gönderilecek fatura yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show($"Tüm {dtFaturalar.Rows.Count} fatura pazaryerlerine gönderilecek. Devam edilsin mi?",
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

            For i As Integer = 0 To rows.Length - 1
                Dim rowIndex As Integer = rows(i)
                Dim dr As DataRowView = CType(GridView1.GetRow(rowIndex), DataRowView)
                If dr Is Nothing Then Continue For

                Dim nStokFisiID As Integer = CInt(dr("nStokFisiID"))
                Dim siparisNo As String = dr("SiparisNo").ToString().Trim()
                Dim pazaryeri As String = dr("Pazaryeri").ToString().Trim()
                Dim gibFaturaNo As String = dr("GibFaturaNo").ToString().Trim()
                Dim faturaGuid As String = If(dr("sEfaturaGuid") IsNot DBNull.Value, dr("sEfaturaGuid").ToString().Trim(), "")

                lblDurum.Text = $"Gönderiliyor: {siparisNo} ({pazaryeri}) - {i + 1}/{rows.Length}"
                Application.DoEvents()

                Dim sonuc As Boolean = False
                Dim hataMesaji As String = ""

                Select Case pazaryeri.ToUpperInvariant()
                    Case "TRENDYOL"
                        sonuc = GonderTrendyol(siparisNo, gibFaturaNo, faturaGuid, hataMesaji)
                    Case "HEPSIBURADA"
                        sonuc = GonderHepsiburada(siparisNo, gibFaturaNo, faturaGuid, hataMesaji)
                    Case "N11"
                        sonuc = GonderN11(siparisNo, gibFaturaNo, faturaGuid, hataMesaji)
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

            lblDurum.Text = $"Tamamlandı! Başarılı: {basarili}, Başarısız: {basarisiz}"
            MessageBox.Show($"Gönderim tamamlandı!" & vbCrLf & vbCrLf &
                           $"Başarılı: {basarili}" & vbCrLf &
                           $"Başarısız: {basarisiz}",
                           "Sonuç", MessageBoxButtons.OK,
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
    Private Function GonderTrendyol(siparisNo As String, gibFaturaNo As String, faturaGuid As String, ByRef hataMesaji As String) As Boolean
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

            ' Sipariş numarasından package ID'yi çıkar (TY11035907594 -> 11035907594)
            Dim packageId As String = siparisNo.Replace("TY", "").Replace("ty", "").Trim()
            Debug.WriteLine("[TY] Package ID: " & packageId)

            ' Fatura linki oluştur (Kolaysoft'tan alınacak)
            Dim invoiceLink As String = GetKolaysoftFaturaLink(gibFaturaNo, faturaGuid)
            If String.IsNullOrEmpty(invoiceLink) Then
                hataMesaji = "Fatura linki alınamadı"
                Debug.WriteLine("[TY] HATA: Fatura linki alınamadı")
                Return False
            End If
            Debug.WriteLine("[TY] Fatura Link: " & invoiceLink)

            ' API isteği - Trendyol endpoint
            ' PUT /sapigw/suppliers/{supplierId}/shipment-packages/{id}/invoice-link
            Dim baseUrl As String = api.BaseUrl
            If String.IsNullOrEmpty(baseUrl) Then
                baseUrl = "https://api.trendyol.com"
            End If
            baseUrl = baseUrl.TrimEnd("/"c)
            
            Dim url As String = baseUrl & "/sapigw/suppliers/" & api.SellerId & "/shipment-packages/" & packageId & "/invoice-link"
            Debug.WriteLine("[TY] URL: " & url)

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            
            Dim req As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            req.Method = "PUT"
            req.ContentType = "application/json"
            req.Accept = "application/json"
            
            ' Trendyol özel User-Agent formatı: {supplierId} - SelfIntegration
            req.UserAgent = api.SellerId & " - SelfIntegration"

            ' Basic Auth - ApiKey:ApiSecret
            Dim authRaw As String = api.ApiKey & ":" & api.ApiSecret
            Debug.WriteLine("[TY] Auth: " & api.ApiKey & ":***")
            
            Dim authBytes As Byte() = Encoding.UTF8.GetBytes(authRaw)
            req.Headers.Add("Authorization", "Basic " & Convert.ToBase64String(authBytes))
            req.Timeout = 30000

            ' Body - {"invoiceLink": "url"}
            Dim jsonBody As String = "{""invoiceLink"": """ & invoiceLink.Replace("""", "\""") & """}"
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

            ' Hepsiburada API Base URL
            Dim baseUrl As String = api.BaseUrl
            If String.IsNullOrEmpty(baseUrl) OrElse baseUrl.Contains("/magaza/") OrElse baseUrl.Contains("www.") Then
                baseUrl = "https://mpop.hepsiburada.com"
            End If
            baseUrl = baseUrl.TrimEnd("/"c)
            
            ' Authentication bilgileri - Hepsiburada: EntegratorAdi:ServisAnahtari
            ' EntegratorAdi = ApiKey (qukasoft_dev gibi), ServisAnahtari = ApiSecret
            Dim entegratorAdi As String = api.ApiKey
            Dim servisAnahtari As String = api.ApiSecret
            
            ' Eğer entegratör adı yoksa MerchantId kullan (eski format)
            If String.IsNullOrEmpty(entegratorAdi) Then
                entegratorAdi = api.SellerId
            End If
            
            Dim authRaw As String = entegratorAdi & ":" & servisAnahtari
            Debug.WriteLine("[HB] Auth Username: " & entegratorAdi)
            
            Dim authBytes As Byte() = Encoding.UTF8.GetBytes(authRaw)
            Dim authBase64 As String = Convert.ToBase64String(authBytes)
            
            ' 1. ADIM: Package Number'ı bul (MPOP API ile)
            Dim packageNumber As String = ""
            Dim apiHataMesaji As String = ""
            
            Debug.WriteLine("[HB] ===== PAKET NUMARASI ARAMA =====")
            Debug.WriteLine("[HB] Sipariş No: " & orderNumber)
            Debug.WriteLine("[HB] MerchantId: " & api.SellerId)
            
            packageNumber = GetHepsiburadaPackageNumber(baseUrl, api.SellerId, orderNumber, authBase64, apiHataMesaji)
            
            If String.IsNullOrEmpty(packageNumber) Then
                Debug.WriteLine("[HB] Paket numarası bulunamadı: " & apiHataMesaji)
                hataMesaji = apiHataMesaji
                Return False
            End If
            
            Debug.WriteLine("[HB] Paket numarası bulundu: " & packageNumber)
            
            ' 2. ADIM: Fatura linkini gönder
            ' PUT /packages/merchantid/{merchantId}/packagenumber/{packageNumber}/invoice
            Dim url As String = baseUrl & "/packages/merchantid/" & api.SellerId & "/packagenumber/" & packageNumber & "/invoice"
            
            Debug.WriteLine("[HB-Invoice] ===== FATURA GÖNDERME =====")
            Debug.WriteLine("[HB-Invoice] URL: " & url)
            Debug.WriteLine("[HB-Invoice] MerchantId: " & api.SellerId)
            Debug.WriteLine("[HB-Invoice] PackageNumber: " & packageNumber)
            Debug.WriteLine("[HB-Invoice] InvoiceLink: " & invoiceLink)

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            
            Dim req As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            req.Method = "PUT"
            req.ContentType = "application/json"
            req.Accept = "application/json"
            req.Timeout = 60000
            req.Headers.Add("Authorization", "Basic " & authBase64)
            req.UserAgent = "BusinessSmart/1.0"

            ' Body: {"invoiceLink": "url"}
            Dim payload As String = "{""invoiceLink"": """ & invoiceLink.Replace("""", "\""") & """}"
            Debug.WriteLine("[HB-Invoice] Payload: " & payload)
            
            Dim data As Byte() = Encoding.UTF8.GetBytes(payload)
            req.ContentLength = data.Length

            Using stream = req.GetRequestStream()
                stream.Write(data, 0, data.Length)
            End Using

            Using resp As HttpWebResponse = CType(req.GetResponse(), HttpWebResponse)
                Dim statusCode As Integer = CInt(resp.StatusCode)
                If statusCode >= 200 AndAlso statusCode < 300 Then
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
                    Using reader As New StreamReader(resp.GetResponseStream(), Encoding.UTF8)
                        Dim errorResponse As String = reader.ReadToEnd()
                        hataMesaji = "HTTP " & CInt(resp.StatusCode) & ": " & If(errorResponse.Length > 200, errorResponse.Substring(0, 200), errorResponse)
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
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            
            Dim packageNumber As String = ""
            Dim mpopBase As String = "https://mpop.hepsiburada.com"
            
            ' Tarih aralığı - son 30 gün
            Dim beginDate As String = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd")
            Dim endDate As String = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd")
            
            ' Yöntem 1: Teslim Edilen Siparişler (Delivered)
            ' GET /packages/merchantid/{merchantId}/delivered?beginDate=...&endDate=...
            Try
                Debug.WriteLine("[HB-Search] Yöntem 1: Teslim Edilenler (Delivered)")
                Dim deliveredUrl As String = mpopBase & "/packages/merchantid/" & merchantId & "/delivered?beginDate=" & beginDate & "&endDate=" & endDate & "&limit=50&offset=0"
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
                Dim shippedUrl As String = mpopBase & "/packages/merchantid/" & merchantId & "/shipped?beginDate=" & beginDate & "&endDate=" & endDate & "&limit=50&offset=0"
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
                Dim openUrl As String = mpopBase & "/packages/merchantid/" & merchantId & "?timespan=24&limit=50&offset=0"
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
                Dim orderUrl As String = mpopBase & "/orders/merchantid/" & merchantId & "/" & orderNumber
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
    ''' N11'e fatura gönder
    ''' </summary>
    Private Function GonderN11(siparisNo As String, gibFaturaNo As String, faturaGuid As String, ByRef hataMesaji As String) As Boolean
        ' TODO: N11 API entegrasyonu eklenecek
        hataMesaji = "N11 entegrasyonu henüz aktif değil"
        Return False
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
                    faturaUrl = $"https://earsivportal.efatura.gov.tr/intragiris.html?ettn={faturaGuid}"
                End If
            End Using
            
            ' Hala URL yoksa ve GibFaturaNo varsa, alternatif format dene
            If String.IsNullOrEmpty(faturaUrl) AndAlso Not String.IsNullOrEmpty(gibFaturaNo) Then
                ' Alternatif: GİB sorgu linki
                faturaUrl = $"https://earsivportal.efatura.gov.tr/intragiris.html?fatession={gibFaturaNo}"
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
        Else
            lblDurum.Text = "Hata: Veritabanı bağlantısı yok!"
        End If
    End Sub
End Class
