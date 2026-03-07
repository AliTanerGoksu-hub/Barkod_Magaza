Imports DevExpress.XtraEditors
Public Class frm_tbMuhasebe_Entegre_Param
    Public firmano As String
    Public donemno As String
    Public connection As String
    Public kullanici As String
    Dim ds_tbSubeMagaza As DataSet
    Dim ds_tbSubeMagazaHesaplari As DataSet
    Dim ds_tbHareketTipi As DataSet
    Dim dataset1 As DataSet
    Dim bInfo As Boolean = False
    Private Sub frm_tbMuhasebe_Entegre_Param_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload_tbSubeMagaza()
        dataload_tbHareketTipi()
        dataload_tbHesapPlani()
        dataload_tbKdv()
    End Sub
    Private Sub dataload_tbKdv()
        sec_sKdvTipi.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sKdvTipi, nKdvOrani FROM tbKdv Order by sKdvTipi")).Tables(0)
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += lbl_Sube.Text & " sHareketTipi = " & sec_sHareketTipi.EditValue & " Muhasebe Entegrasyon Kodları"
        'kriter += txt_dteFisTarihi1.EditValue & " ve " & txt_dteFisTarihi2.EditValue & " Tarihleri Arasındaki" & vbCrLf
        'kriter += sec_bKumulatif.Text & " ve " & sec_bTumu.Text
        printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Muhasebe Yönetimi-Account Manager", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Excel Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyaları(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_text()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Text Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Text Dosyaları(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_pdf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Metin Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyaları(*.pdf) |*.pdf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub dataload_tbSubeMagaza()
        ds_tbSubeMagaza = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSubeMagaza,sAciklama FROM         tbSubeMagaza"))
        GridControl1.DataSource = ds_tbSubeMagaza.Tables(0)
        GridControl1.DataMember = Nothing
    End Sub
    Private Sub dataload_tbHareketTipi()
        ds_tbHareketTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST(sHareketTipi AS CHAR(4)) AS sHareketTipi, sAciklama FROM         tbHareketTipi where aktif = 1"))
        sec_sHareketTipi.Properties.DataSource = ds_tbHareketTipi.Tables(0)
        sec_sHareketTipi.ItemIndex = 0
    End Sub
    Private Sub dataload_tbHesapPlani()
        sec_sHesapPlani.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nHesapID,sKodu,sAciklama FROM         tbHesapPlani Order by sKodu")).Tables(0)
    End Sub
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dataload_tbSubeMagazaHesaplari(dr("sSubeMagaza").ToString(), sec_sHareketTipi.EditValue, 0)
            GridControl2.Focus()
            GridControl2.Select()
        End If
        Label2.Text = Sorgu_sDil("Tamamlandı...", sDil)
    End Sub
    Private Sub dataload_tbSubeMagazaHesaplari(ByVal sSubeMagaza As String, ByVal sHareketTipi As String, ByVal nIslem As Int64)
        lbl_Sube.Text = " <b>Mağaza:</b> " & sSubeMagaza
        If btn_CekSenet.Checked = True Then
            colsKdvTipi.Visible = False
            ds_tbSubeMagazaHesaplari = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT 0 as nIslem,'' sKdvTipi,tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi, tbSubeMagazaHesapTipi.sAciklama, ISNULL(TempHesaplar.sSubeMagaza, '') AS sSubeMagaza, ISNULL(TempHesaplar.sHareketTipi, '') AS sHareketTipi, ISNULL(TempHesaplar.nHesapID, '') AS nHesapID, ISNULL(TempHesaplar.HesapKodu, '') AS sKodu, ISNULL(TempHesaplar.HesapAdi, '') AS sHesapAciklama FROM tbSubeMagazaHesapTipi LEFT OUTER JOIN (SELECT tbSubeMagazaHesaplari.nSubeMagazaHesapTipi AS nSubeMagazaHesapTipi , tbSubeMagazaHesaplari.sSubeMagaza , tbSubeMagazaHesaplari.sHareketTipi , tbHesapPlani.nHesapID , tbHesapPlani.sKodu AS HesapKodu , tbHesapPlani.sAciklama AS HesapAdi FROM tbHesapPlani , tbSubeMagazaHesaplari WHERE tbHesapPlani.nHesapID = tbSubeMagazaHesaplari.nHesapID AND tbSubeMagazaHesaplari.sHareketTipi = '" & sHareketTipi & "' AND tbSubeMagazaHesaplari.sSubeMagaza = '" & sSubeMagaza & "') TempHesaplar ON tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi = TempHesaplar.nSubeMagazaHesapTipi WHERE (tbSubeMagazaHesapTipi.nTipi = 0) AND (tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi < 6) ORDER BY tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi"))
        ElseIf btn_Kdv.Checked = True Then
            colsKdvTipi.Visible = True
            colsKdvTipi.Caption = "KdvTipi"
            GridView2.Columns("sKdvTipi").VisibleIndex = GridView2.Columns("sAciklama").VisibleIndex + 1
            ds_tbSubeMagazaHesaplari = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT 1 as nIslem,tbKDV.sKdvTipi, tbKDV.nSubeMagazaHesapTipi, tbKDV.sAciklama, tbSubeMagazaKdv.sSubeMagaza, tbSubeMagazaKdv.sHareketTipi, tbSubeMagazaKdv.nHesapID, tbHesapPlani.sKodu, tbHesapPlani.sAciklama AS sHesapAciklama FROM tbHesapPlani INNER JOIN tbSubeMagazaKdv ON tbHesapPlani.nHesapID = tbSubeMagazaKdv.nHesapID RIGHT OUTER JOIN (SELECT DISTINCT tbKdv.sKdvTipi , tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi , tbSubeMagazaHesapTipi.sAciklama FROM tbKdv CROSS JOIN tbSubeMagazaHesapTipi WHERE (tbKdv.sKdvTipi <> '') AND (tbSubeMagazaHesapTipi.nTipi = 2)) tbKDV ON tbSubeMagazaKdv.sKdvTipi = tbKDV.sKdvTipi COLLATE Turkish_CI_AS AND tbSubeMagazaKdv.nSubeMagazaHesapTipi = tbKDV.nSubeMagazaHesapTipi AND tbSubeMagazaKdv.sSubeMagaza = '" & sSubeMagaza & "' AND tbSubeMagazaKdv.sHareketTipi = '" & sHareketTipi & "' ORDER BY tbKDV.sKdvTipi, tbKDV.nSubeMagazaHesapTipi"))
        ElseIf btn_OTV.Checked = True Then
            colsKdvTipi.Visible = True
            colsKdvTipi.Caption = "OTVTipi"
            GridView2.Columns("sKdvTipi").VisibleIndex = GridView2.Columns("sAciklama").VisibleIndex + 1
            ds_tbSubeMagazaHesaplari = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT 2 as nIslem,tbOTV.sOTVTipi AS sKdvTipi, tbOTV.nSubeMagazaHesapTipi, tbOTV.sAciklama, tbSubeMagazaOTV.sSubeMagaza, tbSubeMagazaOTV.sHareketTipi, tbSubeMagazaOTV.nHesapID, tbHesapPlani.sKodu, tbHesapPlani.sAciklama AS sHesapAciklama FROM tbHesapPlani INNER JOIN tbSubeMagazaOTV ON tbHesapPlani.nHesapID = tbSubeMagazaOTV.nHesapID RIGHT OUTER JOIN (SELECT DISTINCT tbOTV.sOTVTipi , tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi , tbSubeMagazaHesapTipi.sAciklama FROM tbOTV CROSS JOIN tbSubeMagazaHesapTipi WHERE (tbOTV.sOTVTipi <> '') AND (tbSubeMagazaHesapTipi.nTipi = 2)) tbOTV ON tbSubeMagazaOTV.sOTVTipi = tbOTV.sOTVTipi COLLATE Turkish_CI_AS AND tbSubeMagazaOTV.nSubeMagazaHesapTipi = tbOTV.nSubeMagazaHesapTipi AND tbSubeMagazaOTV.sSubeMagaza = '" & sSubeMagaza & "' AND tbSubeMagazaOTV.sHareketTipi = '" & sHareketTipi & "' ORDER BY tbOTV.sOTVTipi, tbOTV.nSubeMagazaHesapTipi"))
        ElseIf btn_Perakende.Checked = True Then
            colsKdvTipi.Visible = False
            ds_tbSubeMagazaHesaplari = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT 0 as nIslem,'' sKdvTipi,tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi, tbSubeMagazaHesapTipi.sAciklama, ISNULL(TempHesaplar.sSubeMagaza, '') AS sSubeMagaza, ISNULL(TempHesaplar.sHareketTipi, '') AS sHareketTipi, ISNULL(TempHesaplar.nHesapID, '') AS nHesapID, ISNULL(TempHesaplar.HesapKodu, '') AS sKodu, ISNULL(TempHesaplar.HesapAdi, '') AS sHesapAciklama FROM tbSubeMagazaHesapTipi LEFT OUTER JOIN (SELECT tbSubeMagazaHesaplari.nSubeMagazaHesapTipi AS nSubeMagazaHesapTipi , tbSubeMagazaHesaplari.sSubeMagaza , tbSubeMagazaHesaplari.sHareketTipi , tbHesapPlani.nHesapID , tbHesapPlani.sKodu AS HesapKodu , tbHesapPlani.sAciklama AS HesapAdi FROM tbHesapPlani , tbSubeMagazaHesaplari WHERE tbHesapPlani.nHesapID = tbSubeMagazaHesaplari.nHesapID AND tbSubeMagazaHesaplari.sHareketTipi = '" & sHareketTipi & "' AND tbSubeMagazaHesaplari.sSubeMagaza = '" & sSubeMagaza & "') TempHesaplar ON tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi = TempHesaplar.nSubeMagazaHesapTipi WHERE (tbSubeMagazaHesapTipi.nTipi = 1 OR tbSubeMagazaHesapTipi.nTipi = 4) AND (tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi <> 0) ORDER BY tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi"))
        ElseIf btn_Toptan.Checked = True Then
            colsKdvTipi.Visible = False
            ds_tbSubeMagazaHesaplari = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT 0 as nIslem,'' sKdvTipi,tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi, tbSubeMagazaHesapTipi.sAciklama, ISNULL(TempHesaplar.sSubeMagaza, '') AS sSubeMagaza, ISNULL(TempHesaplar.sHareketTipi, '') AS sHareketTipi, ISNULL(TempHesaplar.nHesapID, '') AS nHesapID, ISNULL(TempHesaplar.HesapKodu, '') AS sKodu, ISNULL(TempHesaplar.HesapAdi, '') AS sHesapAciklama FROM tbSubeMagazaHesapTipi LEFT OUTER JOIN (SELECT tbSubeMagazaHesaplari.nSubeMagazaHesapTipi AS nSubeMagazaHesapTipi , tbSubeMagazaHesaplari.sSubeMagaza , tbSubeMagazaHesaplari.sHareketTipi , tbHesapPlani.nHesapID , tbHesapPlani.sKodu AS HesapKodu , tbHesapPlani.sAciklama AS HesapAdi FROM tbHesapPlani , tbSubeMagazaHesaplari WHERE tbHesapPlani.nHesapID = tbSubeMagazaHesaplari.nHesapID AND tbSubeMagazaHesaplari.sHareketTipi = '" & sHareketTipi & "' AND tbSubeMagazaHesaplari.sSubeMagaza = '" & sSubeMagaza & "') TempHesaplar ON tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi = TempHesaplar.nSubeMagazaHesapTipi WHERE (tbSubeMagazaHesapTipi.nTipi = 0) AND (tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi > 5) ORDER BY tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi"))
        ElseIf btn_Kasa.Checked = True Then
            colsKdvTipi.Visible = False
            ds_tbSubeMagazaHesaplari = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT 0 as nIslem,'' sKdvTipi,tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi, tbSubeMagazaHesapTipi.sAciklama, ISNULL(TempHesaplar.sSubeMagaza, '') AS sSubeMagaza, ISNULL(TempHesaplar.sHareketTipi, '') AS sHareketTipi, ISNULL(TempHesaplar.nHesapID, '') AS nHesapID, ISNULL(TempHesaplar.HesapKodu, '') AS sKodu, ISNULL(TempHesaplar.HesapAdi, '') AS sHesapAciklama FROM tbSubeMagazaHesapTipi LEFT OUTER JOIN (SELECT tbSubeMagazaHesaplari.nSubeMagazaHesapTipi AS nSubeMagazaHesapTipi , tbSubeMagazaHesaplari.sSubeMagaza , tbSubeMagazaHesaplari.sHareketTipi , tbHesapPlani.nHesapID , tbHesapPlani.sKodu AS HesapKodu , tbHesapPlani.sAciklama AS HesapAdi FROM tbHesapPlani , tbSubeMagazaHesaplari WHERE tbHesapPlani.nHesapID = tbSubeMagazaHesaplari.nHesapID AND tbSubeMagazaHesaplari.sHareketTipi = '" & sHareketTipi & "' AND tbSubeMagazaHesaplari.sSubeMagaza = '" & sSubeMagaza & "') TempHesaplar ON tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi = TempHesaplar.nSubeMagazaHesapTipi WHERE     (tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi = 0) ORDER BY tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi"))
        ElseIf btn_Tumu.Checked = True Then
            colsKdvTipi.Caption = "KDV/OTV"
            GridView2.Columns("sKdvTipi").VisibleIndex = GridView2.Columns("sAciklama").VisibleIndex + 1
            ds_tbSubeMagazaHesaplari = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT 0 as nIslem,'' sKdvTipi,tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi, tbSubeMagazaHesapTipi.sAciklama, ISNULL(TempHesaplar.sSubeMagaza, '') AS sSubeMagaza, ISNULL(TempHesaplar.sHareketTipi, '') AS sHareketTipi, ISNULL(TempHesaplar.nHesapID, '') AS nHesapID, ISNULL(TempHesaplar.HesapKodu, '') AS sKodu, ISNULL(TempHesaplar.HesapAdi, '') AS sHesapAciklama FROM tbSubeMagazaHesapTipi LEFT OUTER JOIN (SELECT tbSubeMagazaHesaplari.nSubeMagazaHesapTipi AS nSubeMagazaHesapTipi , tbSubeMagazaHesaplari.sSubeMagaza , tbSubeMagazaHesaplari.sHareketTipi , tbHesapPlani.nHesapID , tbHesapPlani.sKodu AS HesapKodu , tbHesapPlani.sAciklama AS HesapAdi FROM tbHesapPlani , tbSubeMagazaHesaplari WHERE tbHesapPlani.nHesapID = tbSubeMagazaHesaplari.nHesapID AND tbSubeMagazaHesaplari.sHareketTipi = '" & sHareketTipi & "' AND tbSubeMagazaHesaplari.sSubeMagaza = '" & sSubeMagaza & "') TempHesaplar ON tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi = TempHesaplar.nSubeMagazaHesapTipi WHERE     (tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi = 0) UNION ALL SELECT DISTINCT 0 as nIslem,'' sKdvTipi,tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi, tbSubeMagazaHesapTipi.sAciklama, ISNULL(TempHesaplar.sSubeMagaza, '') AS sSubeMagaza, ISNULL(TempHesaplar.sHareketTipi, '') AS sHareketTipi, ISNULL(TempHesaplar.nHesapID, '') AS nHesapID, ISNULL(TempHesaplar.HesapKodu, '') AS sKodu, ISNULL(TempHesaplar.HesapAdi, '') AS sHesapAciklama FROM tbSubeMagazaHesapTipi LEFT OUTER JOIN (SELECT tbSubeMagazaHesaplari.nSubeMagazaHesapTipi AS nSubeMagazaHesapTipi , tbSubeMagazaHesaplari.sSubeMagaza , tbSubeMagazaHesaplari.sHareketTipi , tbHesapPlani.nHesapID , tbHesapPlani.sKodu AS HesapKodu , tbHesapPlani.sAciklama AS HesapAdi FROM tbHesapPlani , tbSubeMagazaHesaplari WHERE tbHesapPlani.nHesapID = tbSubeMagazaHesaplari.nHesapID AND tbSubeMagazaHesaplari.sHareketTipi = '" & sHareketTipi & "' AND tbSubeMagazaHesaplari.sSubeMagaza = '" & sSubeMagaza & "') TempHesaplar ON tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi = TempHesaplar.nSubeMagazaHesapTipi WHERE     (tbSubeMagazaHesapTipi.nTipi = 0) AND (tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi < 6) UNION ALL SELECT DISTINCT 0 as nIslem,'' sKdvTipi,tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi, tbSubeMagazaHesapTipi.sAciklama, ISNULL(TempHesaplar.sSubeMagaza, '') AS sSubeMagaza, ISNULL(TempHesaplar.sHareketTipi, '') AS sHareketTipi, ISNULL(TempHesaplar.nHesapID, '') AS nHesapID, ISNULL(TempHesaplar.HesapKodu, '') AS sKodu, ISNULL(TempHesaplar.HesapAdi, '') AS sHesapAciklama FROM tbSubeMagazaHesapTipi LEFT OUTER JOIN (SELECT tbSubeMagazaHesaplari.nSubeMagazaHesapTipi AS nSubeMagazaHesapTipi , tbSubeMagazaHesaplari.sSubeMagaza , tbSubeMagazaHesaplari.sHareketTipi , tbHesapPlani.nHesapID , tbHesapPlani.sKodu AS HesapKodu , tbHesapPlani.sAciklama AS HesapAdi FROM tbHesapPlani , tbSubeMagazaHesaplari WHERE tbHesapPlani.nHesapID = tbSubeMagazaHesaplari.nHesapID AND tbSubeMagazaHesaplari.sHareketTipi = '" & sHareketTipi & "' AND tbSubeMagazaHesaplari.sSubeMagaza = '" & sSubeMagaza & "') TempHesaplar ON tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi = TempHesaplar.nSubeMagazaHesapTipi WHERE (tbSubeMagazaHesapTipi.nTipi = 0) AND (tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi > 5) UNION ALL SELECT DISTINCT 0 as nIslem,'' sKdvTipi,tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi, tbSubeMagazaHesapTipi.sAciklama, ISNULL(TempHesaplar.sSubeMagaza, '') AS sSubeMagaza, ISNULL(TempHesaplar.sHareketTipi, '') AS sHareketTipi, ISNULL(TempHesaplar.nHesapID, '') AS nHesapID, ISNULL(TempHesaplar.HesapKodu, '') AS sKodu, ISNULL(TempHesaplar.HesapAdi, '') AS sHesapAciklama FROM tbSubeMagazaHesapTipi LEFT OUTER JOIN (SELECT tbSubeMagazaHesaplari.nSubeMagazaHesapTipi AS nSubeMagazaHesapTipi , tbSubeMagazaHesaplari.sSubeMagaza , tbSubeMagazaHesaplari.sHareketTipi , tbHesapPlani.nHesapID , tbHesapPlani.sKodu AS HesapKodu , tbHesapPlani.sAciklama AS HesapAdi FROM tbHesapPlani , tbSubeMagazaHesaplari WHERE tbHesapPlani.nHesapID = tbSubeMagazaHesaplari.nHesapID AND tbSubeMagazaHesaplari.sHareketTipi = '" & sHareketTipi & "' AND tbSubeMagazaHesaplari.sSubeMagaza = '" & sSubeMagaza & "') TempHesaplar ON tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi = TempHesaplar.nSubeMagazaHesapTipi WHERE (tbSubeMagazaHesapTipi.nTipi = 1 OR tbSubeMagazaHesapTipi.nTipi = 4) AND (tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi <> 0) UNION ALL SELECT 1 as nIslem,tbKDV.sKdvTipi, tbKDV.nSubeMagazaHesapTipi, tbKDV.sAciklama, tbSubeMagazaKdv.sSubeMagaza, tbSubeMagazaKdv.sHareketTipi, tbSubeMagazaKdv.nHesapID, tbHesapPlani.sKodu, tbHesapPlani.sAciklama AS sHesapAciklama FROM tbHesapPlani INNER JOIN tbSubeMagazaKdv ON tbHesapPlani.nHesapID = tbSubeMagazaKdv.nHesapID RIGHT OUTER JOIN (SELECT DISTINCT tbKdv.sKdvTipi , tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi , tbSubeMagazaHesapTipi.sAciklama FROM tbKdv CROSS JOIN tbSubeMagazaHesapTipi WHERE (tbKdv.sKdvTipi <> '') AND (tbSubeMagazaHesapTipi.nTipi = 2)) tbKDV ON tbSubeMagazaKdv.sKdvTipi = tbKDV.sKdvTipi COLLATE Turkish_CI_AS AND tbSubeMagazaKdv.nSubeMagazaHesapTipi = tbKDV.nSubeMagazaHesapTipi AND tbSubeMagazaKdv.sSubeMagaza = '" & sSubeMagaza & "' AND tbSubeMagazaKdv.sHareketTipi = '" & sHareketTipi & "' UNION ALL SELECT 2 as nIslem,tbOTV.sOTVTipi AS sKdvTipi, tbOTV.nSubeMagazaHesapTipi, tbOTV.sAciklama, tbSubeMagazaOTV.sSubeMagaza, tbSubeMagazaOTV.sHareketTipi, tbSubeMagazaOTV.nHesapID, tbHesapPlani.sKodu, tbHesapPlani.sAciklama AS sHesapAciklama FROM tbHesapPlani INNER JOIN tbSubeMagazaOTV ON tbHesapPlani.nHesapID = tbSubeMagazaOTV.nHesapID RIGHT OUTER JOIN (SELECT DISTINCT tbOTV.sOTVTipi , tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi , tbSubeMagazaHesapTipi.sAciklama FROM tbOTV CROSS JOIN tbSubeMagazaHesapTipi WHERE (tbOTV.sOTVTipi <> '') AND (tbSubeMagazaHesapTipi.nTipi = 2)) tbOTV ON tbSubeMagazaOTV.sOTVTipi = tbOTV.sOTVTipi COLLATE Turkish_CI_AS AND tbSubeMagazaOTV.nSubeMagazaHesapTipi = tbOTV.nSubeMagazaHesapTipi AND tbSubeMagazaOTV.sSubeMagaza = '" & sSubeMagaza & "' AND tbSubeMagazaOTV.sHareketTipi = '" & sHareketTipi & "' ORDER BY tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi"))
        End If
        GridControl2.DataMember = Nothing
        GridControl2.DataSource = ds_tbSubeMagazaHesaplari.Tables(0)
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        conn.Close()
        Return DS
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Başlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "İçerir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
        ElseIf kriter = "Boş" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklı" Then
            sorgu_kriter = " <> '" & deger & "' "
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = " >  '" & deger & "' "
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = " < '" & deger & "' "
        ElseIf kriter = "Eşittir" Then
            sorgu_kriter = " = '" & deger & "' "
        End If
        Return sorgu_kriter
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dataload_tbSubeMagazaHesaplari(dr("sSubeMagaza"), sec_sHareketTipi.EditValue, 0)
        End If
    End Sub
    Private Sub btn_Toptan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Toptan.CheckedChanged
        If btn_Toptan.Checked = True Then
            'btn_Toptan.Checked = False 
            btn_CekSenet.Checked = False
            btn_Kdv.Checked = False
            btn_OTV.Checked = False
            btn_Perakende.Checked = False
            btn_Kasa.Checked = False
            btn_Tumu.Checked = False
            ara()
        End If
    End Sub
    Private Sub btn_Perakende_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Perakende.CheckedChanged
        If btn_Perakende.Checked = True Then
            btn_Toptan.Checked = False
            btn_CekSenet.Checked = False
            btn_Kdv.Checked = False
            'btn_Perakende.Checked = False
            btn_OTV.Checked = False
            btn_Kasa.Checked = False
            btn_Tumu.Checked = False
            ara()
        End If
    End Sub
    Private Sub btn_Kdv_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Kdv.CheckedChanged
        If btn_Kdv.Checked = True Then
            btn_Toptan.Checked = False
            btn_CekSenet.Checked = False
            'btn_Kdv.Checked = False
            btn_OTV.Checked = False
            btn_Perakende.Checked = False
            btn_Kasa.Checked = False
            btn_Tumu.Checked = False
            ara()
        End If
    End Sub
    Private Sub btn_CekSenet_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_CekSenet.CheckedChanged
        If btn_CekSenet.Checked = True Then
            btn_Toptan.Checked = False
            'btn_CekSenet.Checked = False
            btn_Kdv.Checked = False
            btn_OTV.Checked = False
            btn_Perakende.Checked = False
            btn_Kasa.Checked = False
            btn_Tumu.Checked = False
            ara()
        End If
    End Sub
    Private Sub btn_Kasa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Kasa.CheckedChanged
        If btn_Kasa.Checked = True Then
            btn_Toptan.Checked = False
            btn_CekSenet.Checked = False
            btn_Kdv.Checked = False
            btn_OTV.Checked = False
            btn_Perakende.Checked = False
            'btn_Kasa.Checked = False
            btn_Tumu.Checked = False
            ara()
        End If
    End Sub
    Private Sub sec_sHareketTipi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sHareketTipi.EditValueChanged
        ara()
    End Sub
    Private Sub GridView2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        If GridView2.RowCount > 0 Then
            Dim satir = GridView2.FocusedRowHandle
            Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Dim dr2 As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            GridView1.PostEditor()
            dr.EndEdit()
            'tbStokSinifi_kaydet_duzelt(sModel, dr("sSinifKodu"), dr("sSinifNo"))
            If btn_Kdv.Checked = True Then
                tbStokMuhasebeEntegrasyonu_kaydet_duzelt(dr("sKdvTipi"), dr2("sSubeMagaza").ToString, Integer.Parse(dr("nSubeMagazaHesapTipi").ToString()), sec_sHareketTipi.EditValue, Integer.Parse(dr("nHesapID").ToString()), 1)
            ElseIf btn_OTV.checked = True Then
                tbStokMuhasebeEntegrasyonu_kaydet_duzelt(dr("sKdvTipi"), dr2("sSubeMagaza").ToString, Integer.Parse(dr("nSubeMagazaHesapTipi").ToString()), sec_sHareketTipi.EditValue, Integer.Parse(dr("nHesapID").ToString()), 2)
            ElseIf btn_Tumu.Checked = True Then
                tbStokMuhasebeEntegrasyonu_kaydet_duzelt(dr("sKdvTipi"), dr2("sSubeMagaza").ToString, Integer.Parse(dr("nSubeMagazaHesapTipi").ToString()), sec_sHareketTipi.EditValue, Integer.Parse(dr("nHesapID").ToString()), Integer.Parse(dr("nIslem").ToString()))
            Else
                tbStokMuhasebeEntegrasyonu_kaydet_duzelt("", dr2("sSubeMagaza").ToString, Integer.Parse(dr("nSubeMagazaHesapTipi").ToString()), sec_sHareketTipi.EditValue, Integer.Parse(dr("nHesapID").ToString()))
            End If
            ara()
            GridView2.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub btn_OTV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_OTV.CheckedChanged
        If btn_OTV.Checked = True Then
            btn_Toptan.Checked = False
            btn_CekSenet.Checked = False
            btn_Kdv.Checked = False
            'btn_OTV.Checked = False
            btn_Perakende.Checked = False
            btn_Kasa.Checked = False
            btn_Tumu.Checked = False
            ara()
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_pdf()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub btn_Tumu_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Tumu.CheckedChanged
        If btn_Tumu.Checked = True Then
            btn_Toptan.Checked = False
            btn_CekSenet.Checked = False
            btn_Kdv.Checked = False
            btn_OTV.Checked = False
            btn_Perakende.Checked = False
            btn_Kasa.Checked = False
            'btn_Tumu.Checked = False 
            ara()
        End If
    End Sub
    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Değişiklikleri Tüm Şubeler İçin Kayıt Etmek İstiyormusunuz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            If GridView2.RowCount > 0 Then
                If GridView1.RowCount > 0 Then
                    Dim i As Integer = 0
                    Dim i1 As Integer = 0
                    ProgressBarControl1.Properties.Maximum = GridView1.RowCount * GridView2.RowCount
                    ProgressBarControl1.Position = 0
                    ProgressBarControl1.Refresh()
                    For i1 = 0 To GridView2.RowCount - 1
                        Dim dr As DataRow = GridView2.GetDataRow(i1)
                        If IsDBNull(dr("nSubeMagazaHesapTipi")) = False And IsDBNull(dr("nHesapID")) = False Then
                            If dr("nSubeMagazaHesapTipi").ToString() <> "" And dr("nHesapID").ToString() <> "" Then
                                For i = 0 To GridView1.RowCount - 1
                                    Dim drBaslik As DataRow = GridView1.GetDataRow(i)
                                    If btn_Kdv.Checked = True Then
                                        tbStokMuhasebeEntegrasyonu_kaydet_duzelt(dr("sKdvTipi"), drBaslik("sSubeMagaza").ToString, Integer.Parse(dr("nSubeMagazaHesapTipi").ToString()), sec_sHareketTipi.EditValue, Integer.Parse(dr("nHesapID").ToString()), 1)
                                    ElseIf btn_OTV.Checked = True Then
                                        tbStokMuhasebeEntegrasyonu_kaydet_duzelt(dr("sKdvTipi"), drBaslik("sSubeMagaza").ToString, Integer.Parse(dr("nSubeMagazaHesapTipi").ToString()), sec_sHareketTipi.EditValue, Integer.Parse(dr("nHesapID").ToString()), 2)
                                    ElseIf btn_Tumu.Checked = True Then
                                        tbStokMuhasebeEntegrasyonu_kaydet_duzelt(dr("sKdvTipi"), drBaslik("sSubeMagaza").ToString, Integer.Parse(dr("nSubeMagazaHesapTipi").ToString()), sec_sHareketTipi.EditValue, Integer.Parse(dr("nHesapID").ToString()), Integer.Parse(dr("nIslem").ToString()))
                                    Else
                                        tbStokMuhasebeEntegrasyonu_kaydet_duzelt("", drBaslik("sSubeMagaza").ToString, Integer.Parse(dr("nSubeMagazaHesapTipi").ToString()), sec_sHareketTipi.EditValue, Integer.Parse(dr("nHesapID").ToString()))
                                    End If
                                    ProgressBarControl1.Position += 1
                                    ProgressBarControl1.Refresh()
                                Next
                                dr = Nothing
                            End If
                        End If
                    Next
                    ara()
                End If
            End If
        End If
    End Sub
    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Değişiklikleri Tüm Hareketler ve Şubeleri İçin Kayıt Etmek İstiyormusunuz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            If GridView2.RowCount > 0 Then
                If GridView1.RowCount > 0 Then
                    Dim i As Integer = 0
                    Dim i1 As Integer = 0
                    Dim i2 As Integer = 0
                    ProgressBarControl1.Properties.Maximum = GridView1.RowCount * (GridView2.RowCount * ds_tbHareketTipi.Tables(0).Rows.Count)
                    ProgressBarControl1.Position = 0
                    ProgressBarControl1.Refresh()
                    For i2 = 0 To GridView2.RowCount - 1
                        Dim dr As DataRow = GridView2.GetDataRow(i2)
                        If IsDBNull(dr("nSubeMagazaHesapTipi")) = False And IsDBNull(dr("nHesapID")) = False Then
                            If dr("nSubeMagazaHesapTipi").ToString() <> "" And dr("nHesapID").ToString() <> "" Then
                                For i1 = 0 To ds_tbHareketTipi.Tables(0).Rows.Count - 1
                                    Dim drBaslikHareket As DataRow = ds_tbHareketTipi.Tables(0).Rows(i1)
                                    For i = 0 To GridView1.RowCount - 1
                                        Dim drBaslik As DataRow = GridView1.GetDataRow(i)
                                        If btn_Kdv.Checked = True Then
                                            tbStokMuhasebeEntegrasyonu_kaydet_duzelt(dr("sKdvTipi"), drBaslik("sSubeMagaza").ToString, Integer.Parse(dr("nSubeMagazaHesapTipi").ToString()), drBaslikHareket("sHareketTipi"), Integer.Parse(dr("nHesapID").ToString()), 1)
                                        ElseIf btn_OTV.Checked = True Then
                                            tbStokMuhasebeEntegrasyonu_kaydet_duzelt(dr("sKdvTipi"), drBaslik("sSubeMagaza").ToString, Integer.Parse(dr("nSubeMagazaHesapTipi").ToString()), drBaslikHareket("sHareketTipi"), Integer.Parse(dr("nHesapID").ToString()), 2)
                                        ElseIf btn_Tumu.Checked = True Then
                                            tbStokMuhasebeEntegrasyonu_kaydet_duzelt(dr("sKdvTipi"), drBaslik("sSubeMagaza").ToString, Integer.Parse(dr("nSubeMagazaHesapTipi").ToString()), drBaslikHareket("sHareketTipi"), Integer.Parse(dr("nHesapID").ToString()), Integer.Parse(dr("nIslem").ToString()))
                                        Else
                                            tbStokMuhasebeEntegrasyonu_kaydet_duzelt("", drBaslik("sSubeMagaza").ToString, Integer.Parse(dr("nSubeMagazaHesapTipi").ToString()), drBaslikHareket("sHareketTipi"), Integer.Parse(dr("nHesapID").ToString()))
                                        End If
                                        ProgressBarControl1.Position += 1
                                        ProgressBarControl1.Refresh()
                                    Next
                                Next
                                dr = Nothing
                            End If
                        End If
                    Next
                    ara()
                End If
            End If
        End If
    End Sub
End Class