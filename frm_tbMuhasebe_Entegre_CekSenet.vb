Imports DevExpress.XtraEditors
Public Class frm_tbMuhasebe_Entegre_CekSenet
    Public firmano As String
    Public donemno As String
    Public connection As String
    Public kullanici As String
    Dim ds_tbCekSenetTipi As DataSet
    Dim ds_tbHareketTipi As DataSet
    Dim dataset1 As DataSet
    Dim bInfo As Boolean = False

    Private Sub frm_tbMuhasebe_Entegre_CekSenet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload_tbCekSenetTipi()
        dataload_tbHareketTipi()
        txt_dteFisTarihi1.EditValue = dteSistemTarihi
        txt_dteFisTarihi2.EditValue = dteSistemTarihi
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += "Kasa = " & Trim(sec_sCekSenetTipi.Text) & vbTab & " Islem = MuhasebeEntegre"
        kriter += txt_dteFisTarihi1.EditValue & " ve " & txt_dteFisTarihi2.EditValue & " Tarihleri Arasındaki" & vbCrLf
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
    Private Function sorgu(ByVal query As String, Optional ByVal sTable As String = "TABLE1") As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, sTable)
        con.Close()
        Return DS
    End Function

    Private Sub dataload_tbCekSenetTipi()
        ds_tbCekSenetTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sCekSenetTipi,sAciklama FROM         tbCekSenetTipi"))
        sec_sCekSenetTipi.Properties.DataSource = ds_tbCekSenetTipi.Tables(0)
        sec_sCekSenetTipi.ItemIndex = 0
    End Sub
    Private Sub dataload_tbHareketTipi()
        ds_tbHareketTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST(sHareketTipi AS CHAR(4)) AS sHareketTipi, sAciklama FROM         tbHareketTipi where aktif = 1"))
        sec_sHareketTipi.Properties.DataSource = ds_tbHareketTipi.Tables(0)
        sec_sHareketTipi.ItemIndex = 0
    End Sub
    Private Sub sec_bHareketTipi_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bHareketTipi.SelectedIndexChanged
        If sec_bHareketTipi.SelectedIndex = 0 Then
            sec_sHareketTipi.EditValue = ""
            sec_sHareketTipi.Enabled = False
        ElseIf sec_bHareketTipi.SelectedIndex = 1 Then
            sec_sHareketTipi.Enabled = True
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara(sec_sCekSenetTipi.EditValue, txt_dteFisTarihi1.EditValue, txt_dteFisTarihi2.EditValue, txt_lFisNo1.EditValue, txt_lFisNo2.EditValue)
    End Sub
    Private Sub ara(ByVal sSubeMagaza As String, ByVal dteIslemTarihi1 As DateTime, ByVal dteIslemTarihi2 As DateTime, ByVal lBordroNo1 As Int64, ByVal lBordroNo2 As Int64)
        bInfo = False
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        sSubeMagaza = Trim(sSubeMagaza)
        dataload(sSubeMagaza, dteIslemTarihi1, dteIslemTarihi2, lBordroNo1, lBordroNo2)
        Label2.Text = Sorgu_sDil("Tamamlandı...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
        bInfo = True
    End Sub
    Private Sub dataload(ByVal sCekSenetTipi As String, ByVal dteBordroTarihi1 As DateTime, ByVal dteBordroTarihi2 As DateTime, ByVal lBordroNo1 As Int64, ByVal lBordroNo2 As Int64)
        Dim kriter As String = ""
        Dim nSubeMagazaHesapTipi As Integer = 1
        kriter = "WHERE (tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "') AND (tbCekSenetBordro.dteBordroTarihi BETWEEN '" & dteBordroTarihi1 & "' AND '" & dteBordroTarihi2 & "') AND (tbCekSenetBordro.lBordroNo BETWEEN " & lBordroNo1 & " AND " & lBordroNo2 & ")"
        If sec_bYenile.Checked = True Then
        Else
            kriter += " and tbCekSenetBordro.bMuhasebeyeIslendimi = 0"
        End If
        If sCekSenetTipi = "AC" Then
            nSubeMagazaHesapTipi = 1
        ElseIf sCekSenetTipi = "AS" Then
            nSubeMagazaHesapTipi = 3
        ElseIf sCekSenetTipi = "BC" Then
            nSubeMagazaHesapTipi = 2
        ElseIf sCekSenetTipi = "BS" Then
            nSubeMagazaHesapTipi = 5
        End If
        If sCekSenetTipi = "AC" Or sCekSenetTipi = "AS" Then
            nSubeMagazaHesapTipi = 1
            dataset1 = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT tbCekSenetBordro.dteBordroTarihi, tbCekSenetBordro.lBordroNo, tbFirma.sKodu, '' AS firmayok, 0 AS Tip FROM tbFirma, tbCekSenetBordro, tbCekSenet WHERE tbFirma.nHesapID = 0 AND tbFirma.nFirmaID = tbCekSenetBordro.nFirmaID AND tbCekSenetBordro.dteBordroTarihi BETWEEN '" & dteBordroTarihi1 & "' AND '" & dteBordroTarihi2 & "' AND tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "' AND tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID AND tbCekSenetBordro.lBordroNo BETWEEN " & lBordroNo1 & " AND " & lBordroNo2 & " UNION SELECT tbCekSenetBordro.dteBordroTarihi, tbCekSenetBordro.lBordroNo, tbFirma.sKodu, '' AS firmayok, 0 AS Tip FROM tbFirma, tbCekSenetBordro, tbCekSenet WHERE tbFirma.nHesapID = 0 AND tbFirma.nFirmaID = tbCekSenetBordro.nBorcluFirmaID AND tbCekSenetBordro.nBorcluFirmaID <> 0 AND tbCekSenetBordro.dteBordroTarihi BETWEEN '" & dteBordroTarihi1 & "' AND '" & dteBordroTarihi2 & "' AND tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "' AND tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID AND tbCekSenetBordro.lBordroNo BETWEEN " & lBordroNo1 & " AND " & lBordroNo2 & " UNION SELECT tbCekSenetBordro.dteBordroTarihi, tbCekSenetBordro.lBordroNo, tbFirma.sKodu, '' AS firmayok, 1 AS Tip FROM tbFirma, tbCekSenetBordro, tbCekSenet WHERE Isnull ((SELECT nHesapId FROM tbSubeMagazaHesapLari, tbSubeMagaza WHERE tbSubeMagaza.sSubeMagaza = tbSubeMagazaHesapLari.sSubeMagaza AND tbSubeMagazaHesapLari.sSubeMagaza = '' AND tbSubeMagazaHesapLari.sHareketTipi = '' AND nSubeMagazaHesapTipi = 0), 0) = 0 AND Isnull ((SELECT nHesapId FROM tbSubeMagazaHesapLari, tbSubeMagaza WHERE tbSubeMagaza.sSubeMagaza = tbSubeMagazaHesapLari.sSubeMagaza AND bHareketTipineGoreAyri = 1 AND tbSubeMagazaHesapLari.sSubeMagaza = '' AND tbSubeMagazaHesapLari.sHareketTipi = tbCeksenet.sHareketTipi AND nSubeMagazaHesapTipi = 0), 0) = 0 AND tbFirma.nFirmaID = tbCekSenetBordro.nFirmaID AND tbCekSenetBordro.dteBordroTarihi BETWEEN '" & dteBordroTarihi1 & "' AND '" & dteBordroTarihi2 & "' AND tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "' AND tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID AND tbCekSenetBordro.lBordroNo BETWEEN " & lBordroNo1 & " AND " & lBordroNo2 & " AND (nCekSenetIslem = 8) UNION SELECT tbCekSenetBordro.dteBordroTarihi, tbCekSenetBordro.lBordroNo, tbFirma.sKodu, '' AS firmayok, 18 AS Tip FROM tbCeksenetBordro, tbCeksenet, tbFirma WHERE (SELECT TOP 1 sKodu FROM tbHesapPlani, tbSubeMagaza, tbSubeMagazaHesaplari, tbNakitKasa WHERE tbHesapPlani.nHesapId = tbSubeMagazaHesaplari.nHesapId AND nSubeMagazaHesapTipi = 0 AND tbSubeMagazaHesaplari.sSubeMagaza = tbNakitKasa.sSube AND tbNakitKasa.nKasaIslemId = tbCeksenetBordro.nProtestoMasrafiCariHareketId AND ((tbNakitKasa.sHareketTipi = tbSubeMagazaHesaplari.sHareketTipi AND tbSubeMagaza.bHareketTipineGoreAyri = 1) OR (tbSubeMagazaHesaplari.sHareketTipi = '' AND tbSubeMagaza.bHareketTipineGoreAyri = 0))) IS NULL AND tbFirma.nFirmaID = tbCekSenetBordro.nFirmaID AND tbCekSenetBordro.dteBordroTarihi BETWEEN '" & dteBordroTarihi1 & "' AND '" & dteBordroTarihi2 & "' AND tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "' AND tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID AND tbCekSenetBordro.lBordroNo BETWEEN " & lBordroNo1 & " AND " & lBordroNo2 & " AND (nCekSenetIslem = 8) UNION SELECT tbCekSenetBordro.dteBordroTarihi, tbCekSenetBordro.lBordroNo, tbFirma.sKodu, tbFirmayok.sKodu AS firmayok, 2 AS Tip FROM tbFirma, tbCekSenetBordro, tbCekSenet, tbFirma AS tbFirmayok WHERE tbFirmayok.nHesapID = 0 AND tbFirmayok.nFirmaID = tbCekSenetBordro.nBorcluFirmaID AND tbFirma.nFirmaID = tbCekSenetBordro.nFirmaID AND tbCekSenetBordro.dteBordroTarihi BETWEEN '" & dteBordroTarihi1 & "' AND '" & dteBordroTarihi2 & "' AND tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "' AND tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID AND tbCekSenetBordro.lBordroNo BETWEEN " & lBordroNo1 & " AND " & lBordroNo2 & " AND (((nCekSenetIslem = 7) AND - 1 = - 1) OR (nCekSenetIslem = 9 AND - 1 = - 1)) UNION ALL SELECT tbCekSenetBordro.dteBordroTarihi, tbCekSenetBordro.lBordroNo, tbFirma.sKodu, '' AS firmayok, 0 AS Tip FROM tbFirma, tbCekSenetBordro, tbCekSenet WHERE tbFirma.nHesapID = 0 AND tbFirma.nFirmaID = tbCekSenetBordro.nFirmaID AND tbCekSenetBordro.dteBordroTarihi BETWEEN '" & dteBordroTarihi1 & "' AND '" & dteBordroTarihi2 & "' AND tbCekSenetBordro.nCekSenetIslem = 21 AND tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "' AND tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID AND tbCekSenetBordro.lBordroNo BETWEEN " & lBordroNo1 & " AND " & lBordroNo2 & " UNION ALL SELECT tbCekSenetBordro.dteBordroTarihi, tbCekSenetBordro.lBordroNo, tbFirma.sKodu, '' AS firmayok, 0 AS Tip FROM tbFirma, tbCekSenetBordro, tbCekSenet WHERE tbFirma.nHesapID = 0 AND tbFirma.nFirmaID = tbCekSenetBordro.nProtestoMasrafiFirmaID AND tbCekSenetBordro.dteBordroTarihi BETWEEN '" & dteBordroTarihi1 & "' AND '" & dteBordroTarihi2 & "' AND tbCekSenetBordro.nCekSenetIslem = 24 AND tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "' AND tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID AND tbCekSenetBordro.lBordroNo BETWEEN " & lBordroNo1 & " AND " & lBordroNo2 & " UNION ALL SELECT DISTINCT '', 0, '', rtrim(ltrim(nHesapID)) AS firmayok, CASE IsNull(nHesapID, 0) WHEN 0 THEN 7 ELSE 99 END AS Tip FROM tbSubeMagazaHesapTipi LEFT OUTER JOIN tbSubeMagazaHesaplari ON tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi = tbSubeMagazaHesaplari.nSubeMagazaHesapTipi AND tbSubeMagazaHesaplari.nSubeMagazaHesapTipi = 1 WHERE tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi = 3 AND IsNull(nHesapID, 0) = 0 AND tbSubeMagazaHesaplari.sSubeMagaza = '' AND tbSubeMagazaHesaplari.sSubeMagaza = ''"))
        ElseIf sCekSenetTipi = "BC" Or sCekSenetTipi = "BS" Then
            nSubeMagazaHesapTipi = 2
            dataset1 = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SET DATEFORMAT DMY SELECT tbCekSenetBordro.dteBordroTarihi, tbCekSenetBordro.lBordroNo, tbFirma.sKodu, '' AS firmayok, 0 AS Tip FROM tbFirma, tbCekSenetBordro, tbCekSenet WHERE tbFirma.nHesapID = 0 AND tbFirma.nFirmaID = tbCekSenetBordro.nFirmaID AND tbCekSenetBordro.dteBordroTarihi BETWEEN '" & dteBordroTarihi1 & "' AND '" & dteBordroTarihi2 & "' AND tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "' AND tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID AND tbCekSenetBordro.lBordroNo BETWEEN " & lBordroNo1 & " AND " & lBordroNo2 & " AND tbCekSenetBordro.bMuhasebeyeIslendimi = 0 UNION SELECT tbCekSenetBordro.dteBordroTarihi, tbCekSenetBordro.lBordroNo, tbFirma.sKodu, '' AS firmayok, 7 AS Tip FROM tbFirma, tbCekSenetBordro, tbCekSenet WHERE Isnull ((SELECT nHesapId FROM tbSubeMagazaHesapLari, tbSubeMagaza WHERE tbSubeMagaza.sSubeMagaza = tbSubeMagazaHesapLari.sSubeMagaza AND tbSubeMagazaHesapLari.sSubeMagaza = '' AND tbSubeMagazaHesapLari.sHareketTipi = '' AND nSubeMagazaHesapTipi = 2), 0) = 0 AND Isnull ((SELECT nHesapId FROM tbSubeMagaza, tbSubeMagazaHesapLari WHERE tbSubeMagaza.sSubeMagaza = tbSubeMagazaHesapLari.sSubeMagaza AND tbSubeMagazaHesapLari.sSubeMagaza = '' AND tbSubeMagazaHesapLari.sHareketTipi = tbCeksenet.sHareketTipi AND bHareketTipineGoreAyri = 1 AND nSubeMagazaHesapTipi = 2), 0) = 0 AND tbFirma.nFirmaID = tbCekSenetBordro.nFirmaID AND tbCekSenetBordro.dteBordroTarihi BETWEEN '" & dteBordroTarihi1 & "' AND '" & dteBordroTarihi2 & "' AND tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "' AND tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID AND tbCekSenetBordro.lBordroNo BETWEEN " & lBordroNo1 & " AND " & lBordroNo2 & " AND tbCekSenetBordro.bMuhasebeyeIslendimi = 0 UNION ALL SELECT tbCekSenetBordro.dteBordroTarihi, tbCekSenetBordro.lBordroNo, tbFirma.sKodu, '' AS firmayok, 0 AS Tip FROM tbFirma, tbCekSenetBordro, tbCekSenet WHERE tbFirma.nHesapID = 0 AND tbFirma.nFirmaID = tbCekSenetBordro.nFirmaID AND tbCekSenetBordro.dteBordroTarihi BETWEEN '" & dteBordroTarihi1 & "' AND '" & dteBordroTarihi2 & "' AND tbCekSenetBordro.nCekSenetIslem = 21 AND tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "' AND tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID AND tbCekSenetBordro.lBordroNo BETWEEN " & lBordroNo1 & " AND " & lBordroNo2 & "  UNION ALL SELECT tbCekSenetBordro.dteBordroTarihi, tbCekSenetBordro.lBordroNo, tbFirma.sKodu, '' AS firmayok, 0 AS Tip FROM tbFirma, tbCekSenetBordro, tbCekSenet WHERE tbFirma.nHesapID = 0 AND tbFirma.nFirmaID = tbCekSenetBordro.nProtestoMasrafiFirmaID AND tbCekSenetBordro.dteBordroTarihi BETWEEN '" & dteBordroTarihi1 & "' AND '" & dteBordroTarihi2 & "' AND tbCekSenetBordro.nCekSenetIslem = 24 AND tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "' AND tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID AND tbCekSenetBordro.lBordroNo BETWEEN " & lBordroNo1 & " AND " & lBordroNo2 & "  UNION ALL SELECT DISTINCT '', 0, '', rtrim(ltrim(nHesapID)) AS firmayok, CASE IsNull(nHesapID, 0) WHEN 0 THEN 7 ELSE 99 END AS Tip FROM tbSubeMagazaHesapTipi LEFT OUTER JOIN tbSubeMagazaHesaplari ON tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi = tbSubeMagazaHesaplari.nSubeMagazaHesapTipi AND tbSubeMagazaHesaplari.nSubeMagazaHesapTipi = 2 WHERE tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi = 3 AND IsNull(nHesapID, 0) = 0 AND tbSubeMagazaHesaplari.sSubeMagaza = '' AND tbSubeMagazaHesaplari.sSubeMagaza = ''"))
        End If
        GridView1.Columns.Clear()
        GridControl1.DataSource = dataset1.Tables(0)
        GridControl1.DataMember = Nothing
        If dataset1.Tables(0).Rows.Count = 0 Then
            sorgu_nDeger("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  UPDATE    tbCekSenetBordro SET              nProtestoMasrafiCariHareketID = nKasaIslemID WHERE     (nKasaIslemID > 0)")
            sorgu_nDeger("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  UPDATE    tbCekSenetBordro SET              nBorcluFirmaID = nFirmaID WHERE     (nCekSenetIslem = 7) and nBorcluFirmaID = 0")
            sorgu_nDeger("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  UPDATE    tbCekSenetBordro SET              nProtestoMasrafiFirmaID = nBorcluFirmaID WHERE     (nCekSenetIslem = 21) and nProtestoMasrafiFirmaID = 0 and nKasaIslemID IS NULL")
            dataset1 = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SET dateformat dmy SELECT 0 AS nIslem, 3 AS sMuhFisTipi, 0 AS lFisNo, tbCekSenetBordro.dteBordroTarihi, tbCekSenetBordro.lBordroNo, tbCekSenet.sHareketTipi, tbHesapPlani.sKodu, SUBSTRING(tbBanka.sAciklama, 1, 15) AS sBankaAdi, CAST(0 AS MONEY) AS lBorcTutar, tbCekSenet.lTutar AS lAlacakTutar, tbHesapPlani.sKodu AS sHesapKodu, tbCekSenet.dteVadeTarihi, tbCekSenetBordro.nCekSenetIslem, tbCekSenetBordro.nOncekiCekSenetIslem, CASE WHEN (- 1 = - 1 AND nCekSenetIslem <> 8) THEN ISNULL ((SELECT tbHesapPlani.sKodu FROM tbHesapPlani, tbFirma WHERE (tbHesapPlani.nHesapID = tbFirma.nHesapID AND tbFirma.nFirmaID = tbCekSenetBordro.nBorcluFirmaID)), 0) WHEN (- 1 = 0 OR nCekSenetIslem = 8) THEN ISNULL ((SELECT tbHesapPlani.sKodu FROM tbHesapPlani WHERE (tbHesapPlani.nHesapID = tbCekSenetBordro.nBorcluFirmaID)), 0) ELSE '' END AS BorcluHesap, CASE WHEN (- 1 = - 1) THEN ISNULL ((SELECT tbHesapPlani.sKodu FROM tbHesapPlani, tbFirma WHERE (tbHesapPlani.nHesapID = tbFirma.nHesapID AND tbCekSenetBordro.nProtestoMasrafiFirmaID = tbFirma.nFirmaID)), 0) WHEN (- 1 = 0) THEN ISNULL ((SELECT tbHesapPlani.sKodu FROM tbHesapPlani WHERE (tbHesapPlani.nHesapID = tbCekSenetBordro.nProtestoMasrafiFirmaID)), 0) ELSE '' END AS ProtestoKodu, tbCekSenetBordro.lProtestoMasrafi, CASE WHEN (- 1 = 0 OR nCekSenetIslem = 8) THEN ISNULL ((SELECT tbHesapPlani.sKodu FROM tbHesapPlani WHERE (tbHesapPlani.nHesapID = tbCekSenetBordro.nBorcluFirmaID)), 0) WHEN (- 1 = - 1 OR nCekSenetIslem <> 8) THEN ISNULL ((SELECT tbHesapPlani.sKodu FROM tbHesapPlani, tbFirma WHERE (tbHesapPlani.nHesapID = tbFirma.nHesapID AND tbFirma.nFirmaID = tbCekSenetBordro.nBorcluFirmaID)), 0) ELSE '' END AS BorcluHesapBanka, '' AS Expr2, tbCekSenet.lCekSenetNo, '' AS Expr3, tbFirma.sAciklama AS sAciklama, tbCekSenet.sOrjinalCekSenetNo, tbHesapPlani.sAciklama AS sHesapAciklama, tbCekSenet.sNot, CASE WHEN Isnull(MainSube.sKodu, '') = '' THEN BosHareketSube.sKodu ELSE MainSube.sKodu END AS nBordroHesap, CASE WHEN isnull(tbCekSenetBordro.nProtestoMasrafiCariHareketID, 0) = 0 THEN CASE WHEN Isnull(MainSubeKasa.sKodu, '') = '' THEN BosHareketSubeKasa.sKodu ELSE MainSubeKasa.sKodu END ELSE isnull ((SELECT tbHesapPlani.sKodu FROM tbNakitKasa, tbSubeMagazaHesaplari, tbHesapPlani, tbSubeMAgaza WHERE tbNakitKasa.nKasaIslemID = nProtestoMasrafiCariHareketID AND tbNakitKasa.sSube = tbSubeMagazaHesaplari.sSubeMagaza AND tbHesapPlani.nHesapID = tbSubeMagazaHesaplari.nHEsapID AND nSubeMagazaHesapTipi = 0 AND tbSubeMAgaza.sSubeMagaza = tbNakitKasa.sSube AND ((tbCekSenet.sHareketTipi = tbSubeMagazaHesaplari.sHareketTipi AND bHareketTipineGoreAyri = 1) OR (tbSubeMagazaHesaplari.sHareketTipi = '' AND bHareketTipineGoreAyri = 0))), CASE WHEN Isnull(MainSubeKasa.sKodu, '') = '' THEN BosHareketSubeKasa.sKodu ELSE MainSubeKasa.sKodu END) END AS nKasaHesap, CASE WHEN Isnull(MainSube.sKodu, '') = '' THEN BosHareketSube.sAciklama ELSE MainSube.sAciklama END AS nCekSenekAciklama, CASE WHEN Isnull(MainSubeKasa.sKodu, '') = '' THEN BosHareketSubeKasa.sAciklama ELSE MainSubeKasa.sAciklama END AS nKasaAciklama, CASE CONVERT(char(60), nProtestoMasrafiFirmaID) WHEN '0' THEN Isnull ((SELECT TOP 1 sKodu FROM tbHesapPlani, tbSubeMagaza, tbSubeMagazaHesaplari, tbNakitKasa WHERE tbHesapPlani.nHesapId = tbSubeMagazaHesaplari.nHesapId AND nSubeMagazaHesapTipi = 0 AND tbSubeMagazaHesaplari.sSubeMagaza = tbNakitKasa.sSube AND tbNakitKasa.nKasaIslemId = tbCeksenetBordro.nProtestoMasrafiCariHareketId AND ((tbNakitKasa.sHareketTipi = tbSubeMagazaHesaplari.sHareketTipi AND tbSubeMagaza.bHareketTipineGoreAyri = 1) OR (tbSubeMagazaHesaplari.sHareketTipi = '' AND tbSubeMagaza.bHareketTipineGoreAyri = 0))), '') ELSE Isnull ((SELECT sKodu FROM tbHesapPlani WHERE nHesapId IN (SELECT nHesapId FROM tbFirma WHERE nFirmaId = nProtestoMasrafiFirmaID)), '') END AS sTahsilatKasa FROM (SELECT tbSubeMagaza.sSubeMagaza, tbHesapPlani.sKodu, tbHesapPlani.sAciklama FROM tbHesapPlani, tbSubeMagazaHesaplari, tbSubeMagaza WHERE tbHesapPlani.nHesapId = tbSubeMagazaHesaplari.nHesapId AND tbSubeMagaza.sSubeMagaza = tbSubeMagazaHesaplari.sSubeMagaza AND nSubeMagazaHesapTipi = 0 AND sHareketTipi = '' AND tbSubeMagaza.sSubeMagaza = '') BosHareketSubeKasa RIGHT OUTER JOIN tbCekSenet INNER JOIN tbCekSenetBordro ON tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu AND tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbFirma INNER JOIN tbHesapPlani ON tbFirma.nHesapID = tbHesapPlani.nHesapID ON tbCekSenetBordro.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN (SELECT tbSubeMagaza.sSubeMagaza, tbHesapPlani.sKodu, tbHesapPlani.sAciklama, bHareketTipineGoreAyri, sHareketTipi FROM tbHesapPlani, tbSubeMagazaHesaplari, tbSubeMagaza WHERE tbHesapPlani.nHesapId = tbSubeMagazaHesaplari.nHesapId AND tbSubeMagaza.sSubeMagaza = tbSubeMagazaHesaplari.sSubeMagaza AND nSubeMagazaHesapTipi = " & nSubeMagazaHesapTipi & " AND tbSubeMagaza.sSubeMagaza = '') MainSube ON MainSube.sHareketTipi = tbCekSenet.sHareketTipi AND MainSube.bHareketTipineGoreAyri = 1 OR MainSube.sHareketTipi = '' AND MainSube.bHareketTipineGoreAyri = 0 LEFT OUTER JOIN (SELECT tbSubeMagaza.sSubeMagaza, tbHesapPlani.sKodu, tbHesapPlani.sAciklama FROM tbHesapPlani, tbSubeMagazaHesaplari, tbSubeMagaza WHERE tbHesapPlani.nHesapId = tbSubeMagazaHesaplari.nHesapId AND tbSubeMagaza.sSubeMagaza = tbSubeMagazaHesaplari.sSubeMagaza AND nSubeMagazaHesapTipi = " & nSubeMagazaHesapTipi & " AND sHareketTipi = '' AND tbSubeMagaza.sSubeMagaza = '') BosHareketSube ON 1 = 1 LEFT OUTER JOIN (SELECT tbSubeMagaza.sSubeMagaza, tbHesapPlani.sKodu, tbHesapPlani.sAciklama, bHareketTipineGoreAyri, sHareketTipi FROM tbHesapPlani, tbSubeMagazaHesaplari, tbSubeMagaza WHERE tbHesapPlani.nHesapId = tbSubeMagazaHesaplari.nHesapId AND tbSubeMagaza.sSubeMagaza = tbSubeMagazaHesaplari.sSubeMagaza AND nSubeMagazaHesapTipi = 0 AND tbSubeMagaza.sSubeMagaza = '') MainSubeKasa ON MainSubeKasa.sHareketTipi = tbCekSenet.sHareketTipi AND MainSubeKasa.bHareketTipineGoreAyri = 1 OR MainSubeKasa.sHareketTipi = '' AND MainSubeKasa.bHareketTipineGoreAyri = 0 ON 1 = 1 " & kriter & " AND (tbCekSenetBordro.nCekSenetIslem <> 10) UNION ALL SELECT 1 AS nIslem, 3 AS sMuhFisTipi, 0 AS lFisNo, tbCekSenetBordro.dteBordroTarihi, tbCekSenetBordro.lBordroNo, tbCekSenet.sHareketTipi, tbHesapPlani.sKodu, SUBSTRING(tbBanka.sAciklama, 1, 15) AS sBankaAdi, CAST(0 AS MONEY) AS lBorcTutar, tbCekSenet.lTutar AS lAlacakTutar, tbHesapPlani.sKodu AS sHesapKodu, tbCekSenet.dteVadeTarihi, tbCekSenetBordro.nCekSenetIslem, tbCekSenetBordro.nOncekiCekSenetIslem, CASE WHEN (- 1 = - 1 AND nCekSenetIslem <> 8) THEN ISNULL ((SELECT tbHesapPlani.sKodu FROM tbHesapPlani, tbFirma WHERE (tbHesapPlani.nHesapID = tbFirma.nHesapID AND tbFirma.nFirmaID = tbCekSenetBordro.nBorcluFirmaID)), 0) WHEN (- 1 = 0 OR nCekSenetIslem = 8) THEN ISNULL ((SELECT tbHesapPlani.sKodu FROM tbHesapPlani WHERE (tbHesapPlani.nHesapID = tbCekSenetBordro.nBorcluFirmaID)), 0) ELSE '' END AS BorcluHesap, CASE WHEN (- 1 = - 1) THEN ISNULL ((SELECT tbHesapPlani.sKodu FROM tbHesapPlani, tbFirma WHERE (tbHesapPlani.nHesapID = tbFirma.nHesapID AND tbCekSenetBordro.nProtestoMasrafiFirmaID = tbFirma.nFirmaID)), 0) WHEN (- 1 = 0) THEN ISNULL ((SELECT tbHesapPlani.sKodu FROM tbHesapPlani WHERE (tbHesapPlani.nHesapID = tbCekSenetBordro.nProtestoMasrafiFirmaID)), 0) ELSE '' END AS ProtestoKodu, tbCekSenetBordro.lProtestoMasrafi, CASE WHEN (- 1 = 0 OR nCekSenetIslem = 8) THEN ISNULL ((SELECT tbHesapPlani.sKodu FROM tbHesapPlani WHERE (tbHesapPlani.nHesapID = tbCekSenetBordro.nBorcluFirmaID)), 0) WHEN (- 1 = - 1 OR nCekSenetIslem <> 8) THEN ISNULL ((SELECT tbHesapPlani.sKodu FROM tbHesapPlani, tbFirma WHERE (tbHesapPlani.nHesapID = tbFirma.nHesapID AND tbFirma.nFirmaID = tbCekSenetBordro.nBorcluFirmaID)), 0) ELSE '' END AS BorcluHesapBanka, '' AS Expr2, tbCekSenet.lCekSenetNo, '' AS Expr3, tbFirma.sAciklama AS sAciklama, tbCekSenet.sOrjinalCekSenetNo, tbHesapPlani.sAciklama AS sHesapAciklama, tbCekSenet.sNot, CASE WHEN Isnull(MainSube.sKodu, '') = '' THEN BosHareketSube.sKodu ELSE MainSube.sKodu END AS nBordroHesap, CASE WHEN isnull(tbCekSenetBordro.nProtestoMasrafiCariHareketID, 0) = 0 THEN CASE WHEN Isnull(MainSubeKasa.sKodu, '') = '' THEN BosHareketSubeKasa.sKodu ELSE MainSubeKasa.sKodu END ELSE isnull ((SELECT tbHesapPlani.sKodu FROM tbNakitKasa, tbSubeMagazaHesaplari, tbHesapPlani, tbSubeMAgaza WHERE tbNakitKasa.nKasaIslemID = nProtestoMasrafiCariHareketID AND tbNakitKasa.sSube = tbSubeMagazaHesaplari.sSubeMagaza AND tbHesapPlani.nHesapID = tbSubeMagazaHesaplari.nHEsapID AND nSubeMagazaHesapTipi = 0 AND tbSubeMAgaza.sSubeMagaza = tbNakitKasa.sSube AND ((tbCekSenet.sHareketTipi = tbSubeMagazaHesaplari.sHareketTipi AND bHareketTipineGoreAyri = 1) OR (tbSubeMagazaHesaplari.sHareketTipi = '' AND bHareketTipineGoreAyri = 0))), CASE WHEN Isnull(MainSubeKasa.sKodu, '') = '' THEN BosHareketSubeKasa.sKodu ELSE MainSubeKasa.sKodu END) END AS nKasaHesap, CASE WHEN Isnull(MainSube.sKodu, '') = '' THEN BosHareketSube.sAciklama ELSE MainSube.sAciklama END AS nCekSenekAciklama, CASE WHEN Isnull(MainSubeKasa.sKodu, '') = '' THEN BosHareketSubeKasa.sAciklama ELSE MainSubeKasa.sAciklama END AS nKasaAciklama, CASE CONVERT(char(60), nProtestoMasrafiFirmaID) WHEN '0' THEN Isnull ((SELECT TOP 1 sKodu FROM tbHesapPlani, tbSubeMagaza, tbSubeMagazaHesaplari, tbNakitKasa WHERE tbHesapPlani.nHesapId = tbSubeMagazaHesaplari.nHesapId AND nSubeMagazaHesapTipi = 0 AND tbSubeMagazaHesaplari.sSubeMagaza = tbNakitKasa.sSube AND tbNakitKasa.nKasaIslemId = tbCeksenetBordro.nProtestoMasrafiCariHareketId AND ((tbNakitKasa.sHareketTipi = tbSubeMagazaHesaplari.sHareketTipi AND tbSubeMagaza.bHareketTipineGoreAyri = 1) OR (tbSubeMagazaHesaplari.sHareketTipi = '' AND tbSubeMagaza.bHareketTipineGoreAyri = 0))), '') ELSE Isnull ((SELECT sKodu FROM tbHesapPlani WHERE nHesapId IN (SELECT nHesapId FROM tbFirma WHERE nFirmaId = nProtestoMasrafiFirmaID)), '') END AS sTahsilatKasa FROM (SELECT tbSubeMagaza.sSubeMagaza, tbHesapPlani.sKodu, tbHesapPlani.sAciklama FROM tbHesapPlani, tbSubeMagazaHesaplari, tbSubeMagaza WHERE tbHesapPlani.nHesapId = tbSubeMagazaHesaplari.nHesapId AND tbSubeMagaza.sSubeMagaza = tbSubeMagazaHesaplari.sSubeMagaza AND nSubeMagazaHesapTipi = 0 AND sHareketTipi = '' AND tbSubeMagaza.sSubeMagaza = '') BosHareketSubeKasa RIGHT OUTER JOIN tbCekSenet INNER JOIN tbCekSenetBordro ON tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu AND tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbFirma INNER JOIN tbHesapPlani ON tbFirma.nHesapID = tbHesapPlani.nHesapID ON tbCekSenetBordro.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN (SELECT tbSubeMagaza.sSubeMagaza, tbHesapPlani.sKodu, tbHesapPlani.sAciklama, bHareketTipineGoreAyri, sHareketTipi FROM tbHesapPlani, tbSubeMagazaHesaplari, tbSubeMagaza WHERE tbHesapPlani.nHesapId = tbSubeMagazaHesaplari.nHesapId AND tbSubeMagaza.sSubeMagaza = tbSubeMagazaHesaplari.sSubeMagaza AND nSubeMagazaHesapTipi = " & nSubeMagazaHesapTipi & " AND tbSubeMagaza.sSubeMagaza = '') MainSube ON MainSube.sHareketTipi = tbCekSenet.sHareketTipi AND MainSube.bHareketTipineGoreAyri = 1 OR MainSube.sHareketTipi = '' AND MainSube.bHareketTipineGoreAyri = 0 LEFT OUTER JOIN (SELECT tbSubeMagaza.sSubeMagaza, tbHesapPlani.sKodu, tbHesapPlani.sAciklama FROM tbHesapPlani, tbSubeMagazaHesaplari, tbSubeMagaza WHERE tbHesapPlani.nHesapId = tbSubeMagazaHesaplari.nHesapId AND tbSubeMagaza.sSubeMagaza = tbSubeMagazaHesaplari.sSubeMagaza AND nSubeMagazaHesapTipi = " & nSubeMagazaHesapTipi & " AND sHareketTipi = '' AND tbSubeMagaza.sSubeMagaza = '') BosHareketSube ON 1 = 1 LEFT OUTER JOIN (SELECT tbSubeMagaza.sSubeMagaza, tbHesapPlani.sKodu, tbHesapPlani.sAciklama, bHareketTipineGoreAyri, sHareketTipi FROM tbHesapPlani, tbSubeMagazaHesaplari, tbSubeMagaza WHERE tbHesapPlani.nHesapId = tbSubeMagazaHesaplari.nHesapId AND tbSubeMagaza.sSubeMagaza = tbSubeMagazaHesaplari.sSubeMagaza AND nSubeMagazaHesapTipi = 0 AND tbSubeMagaza.sSubeMagaza = '') MainSubeKasa ON MainSubeKasa.sHareketTipi = tbCekSenet.sHareketTipi AND MainSubeKasa.bHareketTipineGoreAyri = 1 OR MainSubeKasa.sHareketTipi = '' AND MainSubeKasa.bHareketTipineGoreAyri = 0 ON 1 = 1 " & kriter & " AND (tbCekSenetBordro.nCekSenetIslem <> 10) ORDER BY tbCekSenetBordro.dteBordroTarihi, tbCekSenetBordro.nCekSenetIslem, tbCekSenet.sHareketTipi, tbCekSenetBordro.lBordroNo, nIslem,tbHesapPlani.sKodu, BorcluHesap, ProtestoKodu"))
            'Dim dataset2 As DataSet = sorgu(sorgu_query("SET dateformat dmy SELECT tbtemp.dteIslemTarihi, 0 as lFisNo,1 as sMuhFisTipi,nIslemID,tbtemp.sHareketTipi, tbHesapKasa.sKodu, tbHesapPlani.sKodu AS sHesapKodu, tbtemp.lTahsilTutar, tbtemp.lTediyeTutar, tbtemp.sAciklama, tbtemp.Sube, tbtemp.sMasrafYontemi, tbHesapPlani.sAciklama AS sHesapAciklama, tbHesapKasa.sAciklama AS sKasaAciklama, tbtemp.sDovizCinsi1, tbtemp.lDovizMiktari1, tbtemp.lDovizKuru1, tbtemp.sDovizCinsi2, tbtemp.lDovizMiktari2, tbtemp.lDovizKuru2,tbTemp.nHesapID, tbTemp.nKasaID FROM (SELECT dteIslemTarihi , nKasaId = CASE WHEN Isnull(MainSube.nHesapId , 0) = 0 THEN BosHareketSube.nHesapId ELSE MainSube.nHesapId END , tbNakitKasa.sHareketTipi , nHesapID = CASE WHEN tbNakitKasa.nHesapID = 0 THEN tbFirma.nHesapID ELSE tbNakitKasa.nHesapID END , lTahsilTutar , lTediyeTutar , tbNakitKasa.sAciklama , tbNakitKasa.sSube AS Sube , tbNakitKasa.nKasaIslemID AS nIslemId , tbNakitKasa.sMasrafYontemi , sDovizCinsi1 , lDovizMiktari1 , lDovizKuru1 , sDovizCinsi2 , lDovizMiktari2 , lDovizKuru2 FROM tbNakitKasa LEFT OUTER JOIN (SELECT tbSubeMagaza.sSubeMagaza , nHesapId , bHareketTipineGoreAyri , sHareketTipi FROM tbSubeMagazaHesaplari , tbSubeMagaza WHERE tbSubeMagaza.sSubeMagaza = tbSubeMagazaHesaplari.sSubeMagaza AND nSubeMagazaHesapTipi = 0) AS MainSube ON MainSube.sSubeMagaza = tbNakitKasa.sSube AND ((MainSube.sHareketTipi = tbNakitKasa.sHareketTipi AND bHareketTipineGoreAyri = 1) OR (MainSube.sHareketTipi = '' AND bHareketTipineGoreAyri = 0)) LEFT OUTER JOIN (SELECT tbSubeMagaza.sSubeMagaza , nHesapId FROM tbSubeMagazaHesaplari , tbSubeMagaza WHERE tbSubeMagaza.sSubeMagaza = tbSubeMagazaHesaplari.sSubeMagaza AND nSubeMagazaHesapTipi = 0 AND sHareketTipi = '') AS BosHareketSube ON BosHareketSube.sSubeMagaza = tbNakitKasa.sSube , tbFirma " & kriter & ") tbtemp INNER JOIN tbHesapPlani ON tbtemp.nHesapID = tbHesapPlani.nHesapID INNER JOIN tbHesapPlani tbHesapKasa ON tbtemp.nKasaId = tbHesapKasa.nHesapID WHERE (tbtemp.nHesapID <> 0) ORDER BY tbtemp.dteIslemTarihi, tbtemp.Sube, tbtemp.sHareketTipi, tbtemp.lTahsilTutar DESC, tbtemp.nIslemId"))
            Dim nGirisCikis = 0
            Dim dr As DataRow
            'Dim dr1 As DataRow
            Dim lFisNo As Int64 = 0
            For Each dr In dataset1.Tables(0).Rows
                'If sec_bKumulatif.SelectedIndex = 0 Then
                If dr("lBordroNo") <> nGirisCikis Then
                    lFisNo += 1
                    nGirisCikis = dr("lBordroNo")
                    dr("lFisNo") = lFisNo
                Else
                    dr("lFisNo") = lFisNo
                End If
                If dr("nCekSenetIslem") = 8 Or dr("nCekSenetIslem") = 11 Then
                    dr("sMuhFisTipi") = 1
                Else
                    dr("sMuhFisTipi") = 3
                End If
                If dr("nIslem") = 0 Then
                    If dr("nCekSenetIslem") = 1 Or dr("nCekSenetIslem") = 6 Or dr("nCekSenetIslem") = 21 Or dr("nCekSenetIslem") = 22 Or dr("nCekSenetIslem") = 23 Or dr("nCekSenetIslem") = 24 Then
                        dr("lBorcTutar") = dr("lAlacakTutar")
                        dr("lAlacakTutar") = 0
                    End If
                End If
                If dr("nIslem") = 1 Then
                    If dr("nCekSenetIslem") = 2 Or dr("nCekSenetIslem") = 3 Or dr("nCekSenetIslem") = 4 Or dr("nCekSenetIslem") = 5 Or dr("nCekSenetIslem") = 7 Or dr("nCekSenetIslem") = 8 Or dr("nCekSenetIslem") = 10 Or dr("nCekSenetIslem") = 11 Or dr("nCekSenetIslem") = 20 Then
                        dr("lBorcTutar") = dr("lAlacakTutar")
                        dr("lAlacakTutar") = 0
                    End If
                End If
                'Else
                '    dr("sMuhFisTipi") = 3
                '    dr("lFisNo") = 1
                'End If
                If sec_bTekTekIslenenlerdeAciklamaCekSenetNoBordroNoBankaKodundanOlussun.Checked = True Then
                    dr("sAciklama") = Microsoft.VisualBasic.Left("ÇS No." + Trim(dr("lCekSenetNo")) & "-B:" + Trim(dr("lBordroNo").ToString) + "-(" + Microsoft.VisualBasic.Left(dr("sBankaAdi"), 15) + ")\" + dr("sHesapAciklama"), 60)
                Else
                    dr("sAciklama") = Microsoft.VisualBasic.Left("B:" + Trim(dr("lBordroNo").ToString) + "\(" + Microsoft.VisualBasic.Left(dr("sBankaAdi"), 15) + ")\" + dr("dteVadeTarihi") + "\No:" + Trim(dr("lCekSenetNo")) + "\E.N:" + Trim(dr("sOrjinalCekSenetNo")) + "\" + dr("sHesapAciklama"), 60)
                End If
                If dr("nIslem") = 0 Then
                    dr("sKodu") = dr("nBordroHesap")
                    dr("sHesapAciklama") = dr("nCekSenekAciklama")
                End If
                If dr("nIslem") = 1 Then
                    If dr("nCekSenetIslem") = 8 Or dr("nCekSenetIslem") = 11 Or dr("nCekSenetIslem") = 21 Then
                        dr("sKodu") = dr("nKasaHesap")
                        dr("sHesapAciklama") = dr("nKasaAciklama")
                    ElseIf dr("nCekSenetIslem") = 24 Then
                        dr("sKodu") = dr("BorcluHesap")
                        dr("sHesapAciklama") = sorgula_String("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED select ISNULL(sAciklama,'') from tbHesapPlani Where sKodu = '" & dr("BorcluHesap") & "'")
                    End If
                End If
            Next
            GridView1.Columns.Clear()
            GridControl1.DataSource = dataset1.Tables(0)
            GridControl1.DataMember = Nothing
            GridView1.Columns("lBordroNo").Visible = False
            GridView1.Columns("sBankaAdi").Visible = False
            GridView1.Columns("nCekSenekAciklama").Visible = False
            GridView1.Columns("nKasaAciklama").Visible = False
            GridView1.Columns("nKasaHesap").Visible = False
            GridView1.Columns("nBordroHesap").Visible = False
            GridView1.Columns("lCekSenetNo").Visible = False
            GridView1.Columns("Expr2").Visible = False
            GridView1.Columns("Expr3").Visible = False
            GridView1.Columns("sTahsilatKasa").Visible = False
            GridView1.Columns("sOrjinalCekSenetNo").Visible = False
            GridView1.Columns("BorcluHesapBanka").Visible = False
            GridView1.Columns("lProtestoMasrafi").Visible = False
            GridView1.Columns("ProtestoKodu").Visible = False
            GridView1.Columns("BorcluHesap").Visible = False
            GridView1.Columns("nOncekiCekSenetIslem").Visible = False
            GridView1.Columns("nCekSenetIslem").Visible = False
            GridView1.Columns("dteVadeTarihi").Visible = False
            GridView1.Columns("sHesapKodu").Visible = False
            GridView1.Columns("lFisNo").OptionsColumn.ShowInCustomizationForm = True
            GridView1.Columns("lFisNo").OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True
            GridView1.Columns("lFisNo").Group()
            GridView1.Columns("sHesapAciklama").VisibleIndex = GridView1.Columns("sKodu").VisibleIndex + 1
            GridView1.Columns("sAciklama").VisibleIndex = GridView1.Columns("sHesapAciklama").VisibleIndex + 1
            GridView1.Columns("lAlacakTutar").VisibleIndex = GridView1.Columns("lBorcTutar").VisibleIndex + 1
            GridView1.Columns("lAlacakTutar").Caption = "Alacak"
            GridView1.Columns("lAlacakTutar").DisplayFormat.FormatString = "#,0.00"
            GridView1.Columns("lAlacakTutar").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns("lBorcTutar").Caption = "Borç"
            GridView1.Columns("lBorcTutar").DisplayFormat.FormatString = "#,0.00"
            GridView1.Columns("lBorcTutar").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns("lAlacakTutar").Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacakTutar", "{0:#,0.00}")})
            GridView1.Columns("lBorcTutar").Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcTutar", "{0:#,0.00}")})
            GridView1.Columns("sAciklama").Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sAciklama", "{0}")})
            GridView1.GroupSummary.Clear()
            GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sAciklama", GridView1.Columns("sAciklama"), "{0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacakTutar", GridView1.Columns("lAlacakTutar"), "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcTutar", GridView1.Columns("lBorcTutar"), "{0:#,0.00}")})
            GridView1.BestFitColumns()
        End If
        GridView1.ExpandAllGroups()
        XtraTabControl1.SelectedTabPageIndex = 1
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_pdf()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Me.Close()
    End Sub
End Class