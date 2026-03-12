Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Collections.Generic
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting

Public Class frm_KolaysoftSatisRaporu
    Inherits DevExpress.XtraEditors.XtraForm

    ' API bilgileri
    Private KolaysoftToken As String = Nothing
    Private KolaysoftFirmaId As String = Nothing

    ' UI kontrolleri
    Private WithEvents dtBaslangic As DevExpress.XtraEditors.DateEdit
    Private WithEvents dtBitis As DevExpress.XtraEditors.DateEdit
    Private WithEvents btnSorgula As SimpleButton
    Private WithEvents btnBugun As SimpleButton
    Private WithEvents btnBuHafta As SimpleButton
    Private WithEvents btnBuAy As SimpleButton
    Private WithEvents cmbDepo As DevExpress.XtraEditors.ComboBoxEdit
    Private WithEvents btnPdfExport As SimpleButton

    ' Depo-PosSeri eşleştirmesi
    Private DepoPosSeriDict As New Dictionary(Of String, String)()

    ' Rapor kartları
    Private lblToplamSatis As LabelControl
    Private lblKrediKarti As LabelControl
    Private lblNakit As LabelControl
    Private lblCariHesap As LabelControl
    Private lblEftHavale As LabelControl

    ' Değerler
    Private lblToplamSatisVal As LabelControl
    Private lblKrediKartiVal As LabelControl
    Private lblNakitVal As LabelControl
    Private lblCariHesapVal As LabelControl
    Private lblEftHavaleVal As LabelControl

    ' Detay grid
    Private gridDetay As DevExpress.XtraGrid.GridControl
    Private gridViewDetay As DevExpress.XtraGrid.Views.Grid.GridView

    ' Progress
    Private progressPanel As PanelControl
    Private lblProgress As LabelControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.Text = "Kolaysoft Satış Raporu"
        Me.Size = New Size(900, 700)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.Sizable

        Dim yPos As Integer = 20

        ' ===== TARİH FİLTRESİ =====
        Dim pnlFiltre As New PanelControl()
        pnlFiltre.Location = New Point(20, yPos)
        pnlFiltre.Size = New Size(840, 70)
        pnlFiltre.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.Controls.Add(pnlFiltre)

        ' Başlangıç tarihi
        Dim lblBaslangic As New LabelControl()
        lblBaslangic.Text = "Başlangıç:"
        lblBaslangic.Location = New Point(10, 10)
        pnlFiltre.Controls.Add(lblBaslangic)

        dtBaslangic = New DateEdit()
        dtBaslangic.Location = New Point(80, 7)
        dtBaslangic.Size = New Size(120, 22)
        dtBaslangic.EditValue = DateTime.Today
        dtBaslangic.Properties.DisplayFormat.FormatString = "dd.MM.yyyy"
        dtBaslangic.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        dtBaslangic.Properties.EditFormat.FormatString = "dd.MM.yyyy"
        dtBaslangic.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        pnlFiltre.Controls.Add(dtBaslangic)

        ' Bitiş tarihi
        Dim lblBitis As New LabelControl()
        lblBitis.Text = "Bitiş:"
        lblBitis.Location = New Point(220, 10)
        pnlFiltre.Controls.Add(lblBitis)

        dtBitis = New DateEdit()
        dtBitis.Location = New Point(260, 7)
        dtBitis.Size = New Size(120, 22)
        dtBitis.EditValue = DateTime.Today
        dtBitis.Properties.DisplayFormat.FormatString = "dd.MM.yyyy"
        dtBitis.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        dtBitis.Properties.EditFormat.FormatString = "dd.MM.yyyy"
        dtBitis.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        pnlFiltre.Controls.Add(dtBitis)

        ' Sorgula butonu
        btnSorgula = New SimpleButton()
        btnSorgula.Text = "Sorgula"
        btnSorgula.Location = New Point(400, 5)
        btnSorgula.Size = New Size(100, 28)
        btnSorgula.Appearance.BackColor = Color.FromArgb(0, 122, 204)
        btnSorgula.Appearance.ForeColor = Color.White
        pnlFiltre.Controls.Add(btnSorgula)

        ' Hızlı tarih butonları
        btnBugun = New SimpleButton()
        btnBugun.Text = "Bugün"
        btnBugun.Location = New Point(10, 40)
        btnBugun.Size = New Size(80, 25)
        pnlFiltre.Controls.Add(btnBugun)

        btnBuHafta = New SimpleButton()
        btnBuHafta.Text = "Bu Hafta"
        btnBuHafta.Location = New Point(100, 40)
        btnBuHafta.Size = New Size(80, 25)
        pnlFiltre.Controls.Add(btnBuHafta)

        btnBuAy = New SimpleButton()
        btnBuAy.Text = "Bu Ay"
        btnBuAy.Location = New Point(190, 40)
        btnBuAy.Size = New Size(80, 25)
        pnlFiltre.Controls.Add(btnBuAy)

        ' Depo seçimi
        Dim lblDepo As New LabelControl()
        lblDepo.Text = "Depo:"
        lblDepo.Location = New Point(520, 10)
        pnlFiltre.Controls.Add(lblDepo)

        cmbDepo = New ComboBoxEdit()
        cmbDepo.Location = New Point(560, 7)
        cmbDepo.Size = New Size(180, 22)
        cmbDepo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        pnlFiltre.Controls.Add(cmbDepo)

        ' PDF Export butonu
        btnPdfExport = New SimpleButton()
        btnPdfExport.Text = "PDF"
        btnPdfExport.Location = New Point(760, 5)
        btnPdfExport.Size = New Size(70, 28)
        btnPdfExport.Appearance.BackColor = Color.FromArgb(244, 67, 54)
        btnPdfExport.Appearance.ForeColor = Color.White
        pnlFiltre.Controls.Add(btnPdfExport)

        yPos += 85

        ' ===== ÖZET KARTLARI =====
        Dim pnlOzet As New PanelControl()
        pnlOzet.Location = New Point(20, yPos)
        pnlOzet.Size = New Size(840, 120)
        pnlOzet.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Controls.Add(pnlOzet)

        ' Toplam Satış kartı
        Dim pnlToplam As PanelControl = CreateSummaryCard("TOPLAM SATIŞ", Color.FromArgb(76, 175, 80), 10)
        pnlOzet.Controls.Add(pnlToplam)
        lblToplamSatisVal = CType(pnlToplam.Controls(1), LabelControl)

        ' Kredi Kartı
        Dim pnlKredi As PanelControl = CreateSummaryCard("KREDİ KARTI", Color.FromArgb(33, 150, 243), 175)
        pnlOzet.Controls.Add(pnlKredi)
        lblKrediKartiVal = CType(pnlKredi.Controls(1), LabelControl)

        ' Nakit
        Dim pnlNakit As PanelControl = CreateSummaryCard("NAKİT", Color.FromArgb(255, 152, 0), 340)
        pnlOzet.Controls.Add(pnlNakit)
        lblNakitVal = CType(pnlNakit.Controls(1), LabelControl)

        ' Cari Hesap
        Dim pnlCari As PanelControl = CreateSummaryCard("CARİ HESAP", Color.FromArgb(156, 39, 176), 505)
        pnlOzet.Controls.Add(pnlCari)
        lblCariHesapVal = CType(pnlCari.Controls(1), LabelControl)

        ' EFT/Havale
        Dim pnlEft As PanelControl = CreateSummaryCard("EFT/HAVALE", Color.FromArgb(0, 150, 136), 670)
        pnlOzet.Controls.Add(pnlEft)
        lblEftHavaleVal = CType(pnlEft.Controls(1), LabelControl)

        yPos += 135

        ' ===== DETAY GRİD =====
        Dim lblDetay As New LabelControl()
        lblDetay.Text = "Ödeme Detayları"
        lblDetay.Location = New Point(20, yPos)
        lblDetay.Font = New Font(lblDetay.Font.FontFamily, 10, FontStyle.Bold)
        Me.Controls.Add(lblDetay)
        yPos += 25

        gridDetay = New DevExpress.XtraGrid.GridControl()
        gridViewDetay = New DevExpress.XtraGrid.Views.Grid.GridView()
        gridDetay.MainView = gridViewDetay
        gridDetay.Location = New Point(20, yPos)
        gridDetay.Size = New Size(840, 350)
        gridDetay.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        gridViewDetay.OptionsBehavior.Editable = False
        gridViewDetay.OptionsView.ShowGroupPanel = False
        Me.Controls.Add(gridDetay)

        ' ===== PROGRESS PANEL =====
        progressPanel = New PanelControl()
        progressPanel.Size = New Size(300, 100)
        progressPanel.Location = New Point((Me.ClientSize.Width - 300) / 2, (Me.ClientSize.Height - 100) / 2)
        progressPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        progressPanel.Visible = False
        progressPanel.BringToFront()

        lblProgress = New LabelControl()
        lblProgress.Text = "Veriler yükleniyor..."
        lblProgress.AutoSizeMode = LabelAutoSizeMode.None
        lblProgress.Size = New Size(280, 80)
        lblProgress.Location = New Point(10, 10)
        lblProgress.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        lblProgress.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        progressPanel.Controls.Add(lblProgress)
        Me.Controls.Add(progressPanel)
    End Sub

    Private Function CreateSummaryCard(title As String, color As Color, xPos As Integer) As PanelControl
        Dim pnl As New PanelControl()
        pnl.Location = New Point(xPos, 10)
        pnl.Size = New Size(155, 100)
        pnl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        pnl.Appearance.BackColor = color
        pnl.Appearance.ForeColor = Color.White

        Dim lblTitle As New LabelControl()
        lblTitle.Text = title
        lblTitle.Location = New Point(10, 10)
        lblTitle.Font = New Font(lblTitle.Font.FontFamily, 9, FontStyle.Bold)
        lblTitle.Appearance.ForeColor = Color.White
        pnl.Controls.Add(lblTitle)

        Dim lblValue As New LabelControl()
        lblValue.Text = "0,00 ₺"
        lblValue.Location = New Point(10, 50)
        lblValue.Font = New Font(lblValue.Font.FontFamily, 14, FontStyle.Bold)
        lblValue.Appearance.ForeColor = Color.White
        lblValue.AutoSizeMode = LabelAutoSizeMode.None
        lblValue.Size = New Size(135, 30)
        pnl.Controls.Add(lblValue)

        Return pnl
    End Function

    Private Sub frm_KolaysoftSatisRaporu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Varsayılan olarak bugünün tarihini ayarla
        dtBaslangic.EditValue = DateTime.Today
        dtBitis.EditValue = DateTime.Today
        
        ' Depoları yükle
        LoadDepolar()
    End Sub

    Private Sub LoadDepolar()
        Try
            cmbDepo.Properties.Items.Clear()
            DepoPosSeriDict.Clear()
            
            ' "Tümü" seçeneği ekle
            cmbDepo.Properties.Items.Add("Tümü")
            DepoPosSeriDict("Tümü") = ""
            
            ' KeyCode'daki sorgu fonksiyonunu kullan (OleDb)
            Dim sql As String = "SELECT sAciklama, sPosSeri FROM tbDepo WHERE sPosSeri IS NOT NULL AND sPosSeri <> '' ORDER BY sAciklama"
            Dim ds As DataSet = KeyCode.sorgu(sql, "tbDepo")
            
            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each row As DataRow In ds.Tables(0).Rows
                    Dim depoAdi As String = row("sAciklama").ToString()
                    Dim posSeri As String = row("sPosSeri").ToString()
                    If Not String.IsNullOrEmpty(depoAdi) AndAlso Not String.IsNullOrEmpty(posSeri) Then
                        cmbDepo.Properties.Items.Add(depoAdi)
                        DepoPosSeriDict(depoAdi) = posSeri
                    End If
                Next
            End If
            
            ' İlk öğeyi seç (Tümü)
            If cmbDepo.Properties.Items.Count > 0 Then
                cmbDepo.SelectedIndex = 0
            End If
        Catch ex As Exception
            ' Hata durumunda mesaj göster
            MessageBox.Show("Depo listesi yüklenirken hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnSorgula_Click(sender As Object, e As EventArgs) Handles btnSorgula.Click
        SatisRaporuCek()
    End Sub

    Private Sub btnPdfExport_Click(sender As Object, e As EventArgs) Handles btnPdfExport.Click
        ExportToPdf()
    End Sub

    Private Sub ExportToPdf()
        If gridDetay Is Nothing OrElse gridDetay.DataSource Is Nothing Then
            MessageBox.Show("Önce bir sorgu çalıştırın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        Try
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "PDF Dosyası (*.pdf)|*.pdf"
            saveDialog.Title = "PDF Olarak Kaydet"
            saveDialog.FileName = "KolaysoftSatisRaporu_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".pdf"
            
            If saveDialog.ShowDialog() = DialogResult.OK Then
                ' DevExpress PDF Export
                Dim options As New DevExpress.XtraPrinting.PdfExportOptions()
                options.DocumentOptions.Author = "Barkod Mağaza"
                options.DocumentOptions.Title = "Kolaysoft Satış Raporu"
                
                ' PrintableComponentLink kullanarak export
                Dim ps As New DevExpress.XtraPrinting.PrintingSystem()
                Dim link As New DevExpress.XtraPrinting.PrintableComponentLink(ps)
                link.Component = gridDetay
                
                ' Başlık ekle
                Dim baslangicTarih As DateTime = CDate(dtBaslangic.EditValue)
                Dim bitisTarih As DateTime = CDate(dtBitis.EditValue)
                Dim secilenDepoStr As String = If(cmbDepo.SelectedItem IsNot Nothing, cmbDepo.SelectedItem.ToString(), "Tümü")
                
                ' Rapor başlığı için PageHeaderFooter kullan
                Dim headerStr As String = "KOLAYSOFT SATIŞ RAPORU" & vbCrLf & _
                    "Tarih: " & baslangicTarih.ToString("dd.MM.yyyy") & " - " & bitisTarih.ToString("dd.MM.yyyy") & "  |  Depo: " & secilenDepoStr & vbCrLf & _
                    "Toplam: " & lblToplamSatisVal.Text & " | Kredi Kartı: " & lblKrediKartiVal.Text & " | Nakit: " & lblNakitVal.Text & " | Cari: " & lblCariHesapVal.Text & " | EFT: " & lblEftHavaleVal.Text
                
                link.PageHeaderFooter = New PageHeaderFooter( _
                    New PageHeaderArea(New String() {headerStr, "", ""}, New Font("Arial", 10, FontStyle.Bold), BrickAlignment.Near), _
                    Nothing)
                
                link.CreateDocument()
                link.ExportToPdf(saveDialog.FileName, options)
                
                MessageBox.Show("PDF başarıyla kaydedildi:" & vbCrLf & saveDialog.FileName, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                
                ' PDF'i aç
                System.Diagnostics.Process.Start(saveDialog.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show("PDF oluşturulurken hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBugun_Click(sender As Object, e As EventArgs) Handles btnBugun.Click
        dtBaslangic.EditValue = DateTime.Today
        dtBitis.EditValue = DateTime.Today
        SatisRaporuCek()
    End Sub

    Private Sub btnBuHafta_Click(sender As Object, e As EventArgs) Handles btnBuHafta.Click
        Dim today As DateTime = DateTime.Today
        Dim dayOfWeek As Integer = CInt(today.DayOfWeek)
        If dayOfWeek = 0 Then dayOfWeek = 7 ' Pazar = 7
        dtBaslangic.EditValue = today.AddDays(-(dayOfWeek - 1))
        dtBitis.EditValue = today
        SatisRaporuCek()
    End Sub

    Private Sub btnBuAy_Click(sender As Object, e As EventArgs) Handles btnBuAy.Click
        Dim today As DateTime = DateTime.Today
        dtBaslangic.EditValue = New DateTime(today.Year, today.Month, 1)
        dtBitis.EditValue = today
        SatisRaporuCek()
    End Sub

    Private Sub SatisRaporuCek()
        Try
            ShowProgress("API'ye bağlanılıyor...")
            Application.DoEvents()

            ' 1) Token al
            If String.IsNullOrEmpty(KolaysoftToken) Then
                KolaysoftToken = GetAuthenticationToken()
            End If

            If String.IsNullOrEmpty(KolaysoftToken) OrElse String.IsNullOrEmpty(KolaysoftFirmaId) Then
                HideProgress()
                XtraMessageBox.Show("Kolaysoft bağlantısı kurulamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ShowProgress("Satış verileri çekiliyor...")
            Application.DoEvents()

            ' 2) Tarihleri al
            Dim baslangic As DateTime = Convert.ToDateTime(dtBaslangic.EditValue)
            Dim bitis As DateTime = Convert.ToDateTime(dtBitis.EditValue)

            ' 3) Seçilen deponun POS seri numarasını al
            Dim secilenPosSeri As String = ""
            If cmbDepo.SelectedItem IsNot Nothing Then
                Dim secilenDepo As String = cmbDepo.SelectedItem.ToString()
                If DepoPosSeriDict.ContainsKey(secilenDepo) Then
                    secilenPosSeri = DepoPosSeriDict(secilenDepo)
                End If
            End If

            ' 4) API'den verileri çek
            Dim odemeler As List(Of Dictionary(Of String, Object)) = GetPosPayments(baslangic, bitis)
            
            ' 5) Seçilen depoya göre filtrele (terminalSerialNumber alanına göre)
            Dim filtrelenmisOdemeler As New List(Of Dictionary(Of String, Object))()
            If String.IsNullOrEmpty(secilenPosSeri) Then
                ' Tümü seçiliyse filtreleme yapma
                filtrelenmisOdemeler = odemeler
            Else
                ' Sadece seçilen POS seri numarasına ait ödemeleri al
                For Each odeme As Dictionary(Of String, Object) In odemeler
                    Dim terminalSeri As String = GetStringValue(odeme, "terminalSerialNumber")
                    If terminalSeri.Equals(secilenPosSeri, StringComparison.OrdinalIgnoreCase) Then
                        filtrelenmisOdemeler.Add(odeme)
                    End If
                Next
            End If

            ShowProgress("Veriler işleniyor...")
            Application.DoEvents()

            ' 6) Toplamları hesapla - paymentTypes dizisinden oku
            Dim toplamSatis As Decimal = 0
            Dim toplamKrediKarti As Decimal = 0
            Dim toplamNakit As Decimal = 0
            Dim toplamCari As Decimal = 0
            Dim toplamEft As Decimal = 0

            For Each odeme As Dictionary(Of String, Object) In filtrelenmisOdemeler
                Dim amounts As PaymentAmounts = GetPaymentAmounts(odeme)
                toplamNakit += amounts.Cash
                toplamKrediKarti += amounts.CreditCard
                toplamCari += amounts.OpenAccount
                toplamEft += amounts.Eft
                toplamSatis += amounts.Total
            Next

            ' 7) UI'ı güncelle
            lblToplamSatisVal.Text = toplamSatis.ToString("N2") & " ₺"
            lblKrediKartiVal.Text = toplamKrediKarti.ToString("N2") & " ₺"
            lblNakitVal.Text = toplamNakit.ToString("N2") & " ₺"
            lblCariHesapVal.Text = toplamCari.ToString("N2") & " ₺"
            lblEftHavaleVal.Text = toplamEft.ToString("N2") & " ₺"

            ' 8) Grid'i doldur
            Dim dt As New DataTable()
            dt.Columns.Add("Tarih", GetType(String))
            dt.Columns.Add("Belge No", GetType(String))
            dt.Columns.Add("Toplam", GetType(Decimal))
            dt.Columns.Add("Nakit", GetType(Decimal))
            dt.Columns.Add("Kredi Kartı", GetType(Decimal))
            dt.Columns.Add("Cari", GetType(Decimal))
            dt.Columns.Add("EFT", GetType(Decimal))
            dt.Columns.Add("Durum", GetType(String))

            For Each odeme As Dictionary(Of String, Object) In filtrelenmisOdemeler
                Dim row As DataRow = dt.NewRow()
                ' updateDate instant formatında geliyor, parse et
                Dim updateDateStr As String = GetStringValue(odeme, "updateDate")
                If Not String.IsNullOrEmpty(updateDateStr) Then
                    Try
                        Dim dt2 As DateTime = DateTime.Parse(updateDateStr)
                        row("Tarih") = dt2.ToString("dd.MM.yyyy HH:mm")
                    Catch
                        row("Tarih") = updateDateStr
                    End Try
                Else
                    row("Tarih") = ""
                End If
                row("Belge No") = GetStringValue(odeme, "documentNo")
                Dim amounts As PaymentAmounts = GetPaymentAmounts(odeme)
                row("Toplam") = amounts.Total
                row("Nakit") = amounts.Cash
                row("Kredi Kartı") = amounts.CreditCard
                row("Cari") = amounts.OpenAccount
                row("EFT") = amounts.Eft
                row("Durum") = GetStringValue(odeme, "status")
                dt.Rows.Add(row)
            Next

            gridDetay.DataSource = dt
            gridViewDetay.BestFitColumns()

            HideProgress()

            ' Bilgi mesajı
            Dim secilenDepoAdi As String = If(cmbDepo.SelectedItem IsNot Nothing, cmbDepo.SelectedItem.ToString(), "Tümü")
            Me.Text = "Kolaysoft Satış Raporu - " & filtrelenmisOdemeler.Count.ToString() & " kayıt bulundu (" & secilenDepoAdi & ")"

        Catch ex As Exception
            HideProgress()
            XtraMessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetAuthenticationToken() As String
        ' tbParamGenel'den kullanıcı bilgilerini al
        Dim dtParam As DataTable = SQLCalistir("SELECT PosKullanici, PosSifre FROM tbParamGenel")
        If dtParam Is Nothing OrElse dtParam.Rows.Count = 0 Then
            Throw New Exception("tbParamGenel tablosunda POS kullanıcı bilgisi bulunamadı.")
        End If

        Dim username As String = dtParam.Rows(0)("PosKullanici").ToString().Trim()
        Dim password As String = dtParam.Rows(0)("PosSifre").ToString().Trim()

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            Throw New Exception("POS kullanıcı adı veya şifresi boş. Lütfen Parametreler > Genel bölümünden ayarlayın.")
        End If

        ' API'ye token isteği gönder
        Dim jsonBody As String = JsonConvert.SerializeObject(New With {.username = username, .password = password})
        Dim request As HttpWebRequest = CType(WebRequest.Create("https://service.kolaysoftpos.com/api/erp-authenticate"), HttpWebRequest)
        request.Method = "POST"
        request.ContentType = "application/json"
        request.Timeout = 30000

        Dim data As Byte() = Encoding.UTF8.GetBytes(jsonBody)
        request.ContentLength = data.Length

        Using stream As Stream = request.GetRequestStream()
            stream.Write(data, 0, data.Length)
        End Using

        Dim responseContent As String = String.Empty
        Try
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(response.GetResponseStream())
                    responseContent = reader.ReadToEnd()
                    Dim parsed = JObject.Parse(responseContent)
                    Dim token = parsed("id_token")?.ToString()
                    If String.IsNullOrEmpty(token) Then Throw New Exception("Token alınamadı.")
                    KolaysoftFirmaId = parsed("companyId")?.ToString()
                    If String.IsNullOrEmpty(KolaysoftFirmaId) Then Throw New Exception("Firma ID'si alınamadı.")
                    Return token
                End Using
            End Using
        Catch webEx As WebException
            If webEx.Response IsNot Nothing Then
                responseContent = New StreamReader(webEx.Response.GetResponseStream()).ReadToEnd()
            End If
            Throw New Exception("Kimlik doğrulama hatası: " & webEx.Message & vbCrLf & "Yanıt: " & responseContent)
        End Try
    End Function

    Private Function GetPosPayments(baslangic As DateTime, bitis As DateTime) As List(Of Dictionary(Of String, Object))
        Dim sonuc As New List(Of Dictionary(Of String, Object))()

        ' API URL'i oluştur - companyId ve tarih filtreleri JHipster LongFilter/InstantFilter formatında
        Dim url As String = "https://service.kolaysoftpos.com/services/pos/api/erp/pos-payments?companyId.equals=" & KolaysoftFirmaId
        
        ' Tarih filtreleri - JHipster InstantFilter formatı (greaterThanOrEqual, lessThanOrEqual)
        ' ISO 8601 formatında tarih (Z = UTC)
        url &= "&updateDate.greaterThanOrEqual=" & baslangic.ToString("yyyy-MM-dd") & "T00:00:00Z"
        url &= "&updateDate.lessThanOrEqual=" & bitis.ToString("yyyy-MM-dd") & "T23:59:59Z"
        
        ' Sayfalama - maksimum 200 kayıt
        url &= "&size=200"

        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        request.Method = "GET"
        request.ContentType = "application/json"
        request.Accept = "application/json"
        request.Headers.Add("Authorization", "Bearer " & KolaysoftToken)
        request.Timeout = 60000

        Try
            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(response.GetResponseStream(), Encoding.UTF8)
                    Dim responseContent As String = reader.ReadToEnd()
                    
                    ' JSON parse et
                    Dim jsonResponse = JToken.Parse(responseContent)
                    
                    If jsonResponse.Type = JTokenType.Array Then
                        For Each item As JObject In jsonResponse
                            Dim dict As New Dictionary(Of String, Object)()
                            For Each prop As JProperty In item.Properties()
                                dict(prop.Name) = prop.Value.ToObject(Of Object)()
                            Next
                            sonuc.Add(dict)
                        Next
                    ElseIf jsonResponse.Type = JTokenType.Object Then
                        ' Eğer sayfalama varsa content dizisini al
                        Dim content As JToken = jsonResponse("content")
                        If content IsNot Nothing AndAlso content.Type = JTokenType.Array Then
                            For Each item As JObject In content
                                Dim dict As New Dictionary(Of String, Object)()
                                For Each prop As JProperty In item.Properties()
                                    dict(prop.Name) = prop.Value.ToObject(Of Object)()
                                Next
                                sonuc.Add(dict)
                            Next
                        End If
                    End If
                End Using
            End Using
        Catch webEx As WebException
            Dim responseContent As String = ""
            If webEx.Response IsNot Nothing Then
                responseContent = New StreamReader(webEx.Response.GetResponseStream()).ReadToEnd()
            End If
            Throw New Exception("API hatası: " & webEx.Message & vbCrLf & "Yanıt: " & responseContent)
        End Try

        Return sonuc
    End Function

    Private Function SQLCalistir(sql As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using con As New OleDb.OleDbConnection(KeyCode.sConnection)
                con.Open()
                Using cmd As New OleDb.OleDbCommand(sql, con)
                    Using adapter As New OleDb.OleDbDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Hata durumunda boş DataTable döndür
        End Try
        Return dt
    End Function

    Private Function GetDecimalValue(dict As Dictionary(Of String, Object), key As String) As Decimal
        If dict.ContainsKey(key) AndAlso dict(key) IsNot Nothing Then
            Try
                Return Convert.ToDecimal(dict(key))
            Catch
            End Try
        End If
        Return 0D
    End Function

    Private Function GetStringValue(dict As Dictionary(Of String, Object), key As String) As String
        If dict.ContainsKey(key) AndAlso dict(key) IsNot Nothing Then
            Return dict(key).ToString()
        End If
        Return ""
    End Function

    ' paymentTypes dizisinden ödeme tutarlarını çıkaran sınıf ve fonksiyon
    Private Class PaymentAmounts
        Public Cash As Decimal = 0
        Public CreditCard As Decimal = 0
        Public OpenAccount As Decimal = 0
        Public Eft As Decimal = 0
        Public ReadOnly Property Total As Decimal
            Get
                Return Cash + CreditCard + OpenAccount + Eft
            End Get
        End Property
    End Class

    Private Function GetPaymentAmounts(dict As Dictionary(Of String, Object)) As PaymentAmounts
        Dim result As New PaymentAmounts()
        
        If dict.ContainsKey("paymentTypes") AndAlso dict("paymentTypes") IsNot Nothing Then
            Try
                ' paymentTypes bir JArray olarak geliyor
                Dim paymentTypesObj = dict("paymentTypes")
                Dim paymentTypes As JArray = Nothing
                
                If TypeOf paymentTypesObj Is JArray Then
                    paymentTypes = CType(paymentTypesObj, JArray)
                ElseIf TypeOf paymentTypesObj Is String Then
                    paymentTypes = JArray.Parse(paymentTypesObj.ToString())
                End If
                
                If paymentTypes IsNot Nothing Then
                    For Each pt As JObject In paymentTypes
                        Dim pType As String = If(pt("paymentType")?.ToString(), "")
                        Dim amount As Decimal = 0
                        If pt("amount") IsNot Nothing Then
                            Decimal.TryParse(pt("amount").ToString(), amount)
                        End If
                        
                        Select Case pType.ToLower()
                            Case "cash"
                                result.Cash += amount
                            Case "creditcard"
                                result.CreditCard += amount
                            Case "openaccount"
                                result.OpenAccount += amount
                            Case "efttransferamount", "eft"
                                result.Eft += amount
                        End Select
                    Next
                End If
            Catch
                ' Parse hatası durumunda 0 döndür
            End Try
        End If
        
        Return result
    End Function

    Private Sub ShowProgress(message As String)
        lblProgress.Text = message
        progressPanel.Location = New Point((Me.ClientSize.Width - progressPanel.Width) / 2, (Me.ClientSize.Height - progressPanel.Height) / 2)
        progressPanel.Visible = True
        progressPanel.BringToFront()
    End Sub

    Private Sub HideProgress()
        progressPanel.Visible = False
    End Sub
End Class
