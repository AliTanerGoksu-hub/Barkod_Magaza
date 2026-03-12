Imports DevExpress.XtraEditors
Public Class frm_tbMuhasebe_Entegre_Kasa
    Public firmano As String
    Public donemno As String
    Public connection As String
    Public kullanici As String
    Dim ds_tbsube As DataSet
    Dim ds_tbHareketTipi As DataSet
    Dim dataset1 As DataSet
    Dim bInfo As Boolean = False
    Private Sub frm_tbMuhasebe_Entegre_Kasa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload_tbFisTipi()
        dataload_tbHareketTipi()
        txt_dteFisTarihi1.EditValue = dteSistemTarihi
        txt_dteFisTarihi2.EditValue = dteSistemTarihi
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += "Kasa = " & Trim(sec_sSubeMagaza.Text) & vbTab & " Islem = MuhasebeEntegre"
        kriter += txt_dteFisTarihi1.EditValue & " ve " & txt_dteFisTarihi2.EditValue & " Tarihleri Arasındaki" & vbCrLf
        kriter += sec_bKumulatif.Text & " ve " & sec_bTumu.Text
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
    Private Sub dataload_tbFisTipi()
        ds_tbsube = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSubeMagaza,sAciklama FROM         tbSubeMagaza"))
        sec_sSubeMagaza.Properties.DataSource = ds_tbsube.Tables(0)
        sec_sSubeMagaza.ItemIndex = 0
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
        ara(sec_sSubeMagaza.EditValue, txt_dteFisTarihi1.EditValue, txt_dteFisTarihi2.EditValue)
    End Sub
    Private Sub ara(ByVal sSubeMagaza As String, ByVal dteIslemTarihi1 As DateTime, ByVal dteIslemTarihi2 As DateTime)
        bInfo = False
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        sSubeMagaza = Trim(sSubeMagaza)
        dataload(sSubeMagaza, dteIslemTarihi1, dteIslemTarihi2)
        Label2.Text = Sorgu_sDil("Tamamlandı...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
        bInfo = True
    End Sub
    Private Sub dataload(ByVal sSubeMagaza As String, ByVal dteIslemTarihi1 As DateTime, ByVal dteIslemTarihi2 As DateTime)
        Dim kriter As String = ""
        kriter = "WHERE (tbNakitKasa.nFirmaID <> 0) and tbNakitKasa.nFirmaID = tbFirma.nFirmaID  AND (sHangiUygulama = '' OR sHangiUygulama = 'UR' OR sHangiUygulama = 'TCG' OR sHangiUygulama = 'TCC')   AND dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & "'"
        If sec_bTumu.SelectedIndex = 0 Then
            kriter += " AND lTahsilTutar <> 0"
        ElseIf sec_bTumu.SelectedIndex = 1 Then
            kriter += " AND lTediyeTutar <> 0"
        ElseIf sec_bTumu.SelectedIndex = 2 Then
        End If
        If sSubeMagaza = "" Then
        Else
            kriter += " AND (tbNakitKasa.sSube = '" & sSubeMagaza & "')"
        End If
        If sec_bYenile.Checked = True Then
        Else
            kriter += " and bMuhasebeyeIslendimi = 0"
        End If
        dataset1 = sorgu(sorgu_query("SELECT DISTINCT tbNakitKasa.dteIslemTarihi, tbNakitKasa.sSube, tbFirma.sKodu FROM         tbNakitKasa INNER JOIN                       tbFirma ON tbNakitKasa.nFirmaID = tbFirma.nFirmaID " & kriter & " AND                        (tbFirma.nHesapID = 0)"))
        GridView1.Columns.Clear()
        GridControl1.DataSource = dataset1.Tables(0)
        GridControl1.DataMember = Nothing
        If dataset1.Tables(0).Rows.Count = 0 Then
            dataset1 = sorgu(sorgu_query("SET dateformat dmy SELECT tbtemp.dteIslemTarihi,0 as nIslem, 0 as lFisNo,sMuhFisTipi = CASE WHEN tbTemp.lTahsilTutar = 0 THEN 2 ELSE 1 END,nIslemID,tbtemp.sHareketTipi, tbHesapKasa.sKodu, tbHesapPlani.sKodu AS sHesapKodu, tbtemp.lTahsilTutar, tbtemp.lTediyeTutar, tbtemp.sAciklama, tbtemp.Sube, tbtemp.sMasrafYontemi, tbHesapPlani.sAciklama AS sHesapAciklama, tbHesapKasa.sAciklama AS sKasaAciklama, tbtemp.sDovizCinsi1, tbtemp.lDovizMiktari1, tbtemp.lDovizKuru1, tbtemp.sDovizCinsi2, tbtemp.lDovizMiktari2, tbtemp.lDovizKuru2,tbTemp.nHesapID, tbTemp.nKasaID FROM (SELECT dteIslemTarihi , nKasaId = CASE WHEN Isnull(MainSube.nHesapId , 0) = 0 THEN BosHareketSube.nHesapId ELSE MainSube.nHesapId END , tbNakitKasa.sHareketTipi , nHesapID = CASE WHEN tbNakitKasa.nHesapID = 0 THEN tbFirma.nHesapID ELSE tbNakitKasa.nHesapID END , lTahsilTutar , lTediyeTutar , tbNakitKasa.sAciklama , tbNakitKasa.sSube AS Sube , tbNakitKasa.nKasaIslemID AS nIslemId , tbNakitKasa.sMasrafYontemi , sDovizCinsi1 , lDovizMiktari1 , lDovizKuru1 , sDovizCinsi2 , lDovizMiktari2 , lDovizKuru2 FROM tbNakitKasa LEFT OUTER JOIN (SELECT tbSubeMagaza.sSubeMagaza , nHesapId , bHareketTipineGoreAyri , sHareketTipi FROM tbSubeMagazaHesaplari , tbSubeMagaza WHERE tbSubeMagaza.sSubeMagaza = tbSubeMagazaHesaplari.sSubeMagaza AND nSubeMagazaHesapTipi = 0) AS MainSube ON MainSube.sSubeMagaza = tbNakitKasa.sSube AND ((MainSube.sHareketTipi = tbNakitKasa.sHareketTipi AND bHareketTipineGoreAyri = 1) OR (MainSube.sHareketTipi = '' AND bHareketTipineGoreAyri = 0)) LEFT OUTER JOIN (SELECT tbSubeMagaza.sSubeMagaza , nHesapId FROM tbSubeMagazaHesaplari , tbSubeMagaza WHERE tbSubeMagaza.sSubeMagaza = tbSubeMagazaHesaplari.sSubeMagaza AND nSubeMagazaHesapTipi = 0 AND sHareketTipi = '') AS BosHareketSube ON BosHareketSube.sSubeMagaza = tbNakitKasa.sSube , tbFirma " & kriter & ") tbtemp INNER JOIN tbHesapPlani ON tbtemp.nHesapID = tbHesapPlani.nHesapID INNER JOIN tbHesapPlani tbHesapKasa ON tbtemp.nKasaId = tbHesapKasa.nHesapID WHERE (tbtemp.nHesapID <> 0) UNION ALL SELECT tbtemp.dteIslemTarihi,1 as nIslem, 0 as lFisNo,sMuhFisTipi = CASE WHEN tbTemp.lTahsilTutar = 0 THEN 2 ELSE 1 END,nIslemID,tbtemp.sHareketTipi, tbHesapKasa.sKodu, tbHesapPlani.sKodu AS sHesapKodu, tbtemp.lTediyeTutar as lTahsilTutar, tbtemp.lTahsilTutar as lTediyeTutar, tbtemp.sAciklama, tbtemp.Sube, tbtemp.sMasrafYontemi, tbHesapPlani.sAciklama AS sHesapAciklama, tbHesapKasa.sAciklama AS sKasaAciklama, tbtemp.sDovizCinsi1, tbtemp.lDovizMiktari1, tbtemp.lDovizKuru1, tbtemp.sDovizCinsi2, tbtemp.lDovizMiktari2, tbtemp.lDovizKuru2,tbTemp.nHesapID, tbTemp.nKasaID FROM (SELECT dteIslemTarihi , nKasaId = CASE WHEN Isnull(MainSube.nHesapId , 0) = 0 THEN BosHareketSube.nHesapId ELSE MainSube.nHesapId END , tbNakitKasa.sHareketTipi , nHesapID = CASE WHEN tbNakitKasa.nHesapID = 0 THEN tbFirma.nHesapID ELSE tbNakitKasa.nHesapID END , lTahsilTutar , lTediyeTutar , tbNakitKasa.sAciklama , tbNakitKasa.sSube AS Sube , tbNakitKasa.nKasaIslemID AS nIslemId , tbNakitKasa.sMasrafYontemi , sDovizCinsi1 , lDovizMiktari1 , lDovizKuru1 , sDovizCinsi2 , lDovizMiktari2 , lDovizKuru2 FROM tbNakitKasa LEFT OUTER JOIN (SELECT tbSubeMagaza.sSubeMagaza , nHesapId , bHareketTipineGoreAyri , sHareketTipi FROM tbSubeMagazaHesaplari , tbSubeMagaza WHERE tbSubeMagaza.sSubeMagaza = tbSubeMagazaHesaplari.sSubeMagaza AND nSubeMagazaHesapTipi = 0) AS MainSube ON MainSube.sSubeMagaza = tbNakitKasa.sSube AND ((MainSube.sHareketTipi = tbNakitKasa.sHareketTipi AND bHareketTipineGoreAyri = 1) OR (MainSube.sHareketTipi = '' AND bHareketTipineGoreAyri = 0)) LEFT OUTER JOIN (SELECT tbSubeMagaza.sSubeMagaza , nHesapId FROM tbSubeMagazaHesaplari , tbSubeMagaza WHERE tbSubeMagaza.sSubeMagaza = tbSubeMagazaHesaplari.sSubeMagaza AND nSubeMagazaHesapTipi = 0 AND sHareketTipi = '') AS BosHareketSube ON BosHareketSube.sSubeMagaza = tbNakitKasa.sSube , tbFirma " & kriter & ") tbtemp INNER JOIN tbHesapPlani ON tbtemp.nHesapID = tbHesapPlani.nHesapID INNER JOIN tbHesapPlani tbHesapKasa ON tbtemp.nKasaId = tbHesapKasa.nHesapID WHERE (tbtemp.nHesapID <> 0) ORDER BY tbtemp.dteIslemTarihi, tbtemp.Sube, tbtemp.sHareketTipi, tbtemp.nIslemId"))
            'Dim dataset2 As DataSet = sorgu(sorgu_query("SET dateformat dmy SELECT tbtemp.dteIslemTarihi, 0 as lFisNo,1 as sMuhFisTipi,nIslemID,tbtemp.sHareketTipi, tbHesapKasa.sKodu, tbHesapPlani.sKodu AS sHesapKodu, tbtemp.lTahsilTutar, tbtemp.lTediyeTutar, tbtemp.sAciklama, tbtemp.Sube, tbtemp.sMasrafYontemi, tbHesapPlani.sAciklama AS sHesapAciklama, tbHesapKasa.sAciklama AS sKasaAciklama, tbtemp.sDovizCinsi1, tbtemp.lDovizMiktari1, tbtemp.lDovizKuru1, tbtemp.sDovizCinsi2, tbtemp.lDovizMiktari2, tbtemp.lDovizKuru2,tbTemp.nHesapID, tbTemp.nKasaID FROM (SELECT dteIslemTarihi , nKasaId = CASE WHEN Isnull(MainSube.nHesapId , 0) = 0 THEN BosHareketSube.nHesapId ELSE MainSube.nHesapId END , tbNakitKasa.sHareketTipi , nHesapID = CASE WHEN tbNakitKasa.nHesapID = 0 THEN tbFirma.nHesapID ELSE tbNakitKasa.nHesapID END , lTahsilTutar , lTediyeTutar , tbNakitKasa.sAciklama , tbNakitKasa.sSube AS Sube , tbNakitKasa.nKasaIslemID AS nIslemId , tbNakitKasa.sMasrafYontemi , sDovizCinsi1 , lDovizMiktari1 , lDovizKuru1 , sDovizCinsi2 , lDovizMiktari2 , lDovizKuru2 FROM tbNakitKasa LEFT OUTER JOIN (SELECT tbSubeMagaza.sSubeMagaza , nHesapId , bHareketTipineGoreAyri , sHareketTipi FROM tbSubeMagazaHesaplari , tbSubeMagaza WHERE tbSubeMagaza.sSubeMagaza = tbSubeMagazaHesaplari.sSubeMagaza AND nSubeMagazaHesapTipi = 0) AS MainSube ON MainSube.sSubeMagaza = tbNakitKasa.sSube AND ((MainSube.sHareketTipi = tbNakitKasa.sHareketTipi AND bHareketTipineGoreAyri = 1) OR (MainSube.sHareketTipi = '' AND bHareketTipineGoreAyri = 0)) LEFT OUTER JOIN (SELECT tbSubeMagaza.sSubeMagaza , nHesapId FROM tbSubeMagazaHesaplari , tbSubeMagaza WHERE tbSubeMagaza.sSubeMagaza = tbSubeMagazaHesaplari.sSubeMagaza AND nSubeMagazaHesapTipi = 0 AND sHareketTipi = '') AS BosHareketSube ON BosHareketSube.sSubeMagaza = tbNakitKasa.sSube , tbFirma " & kriter & ") tbtemp INNER JOIN tbHesapPlani ON tbtemp.nHesapID = tbHesapPlani.nHesapID INNER JOIN tbHesapPlani tbHesapKasa ON tbtemp.nKasaId = tbHesapKasa.nHesapID WHERE (tbtemp.nHesapID <> 0) ORDER BY tbtemp.dteIslemTarihi, tbtemp.Sube, tbtemp.sHareketTipi, tbtemp.lTahsilTutar DESC, tbtemp.nIslemId"))
            Dim nGirisCikis = 0
            Dim dr As DataRow
            'Dim dr1 As DataRow
            Dim lFisNo As Int64 = 0
            For Each dr In dataset1.Tables(0).Rows
                If sec_bKumulatif.SelectedIndex = 0 Then
                    If dr("nIslemID") <> nGirisCikis Then
                        lFisNo += 1
                        nGirisCikis = dr("nIslemID")
                        dr("lFisNo") = lFisNo
                    Else
                        dr("lFisNo") = lFisNo
                    End If
                    If dr("nIslem") = 1 Then
                        If dr("sMuhFisTipi") = 1 Then
                            dr("sAciklama") = "Tahsil Yekünü"
                        ElseIf dr("sMuhFisTipi") = 2 Then
                            dr("sAciklama") = "Tediye Yekünü"
                        End If
                    End If
                Else
                    dr("sMuhFisTipi") = 3
                    dr("lFisNo") = 1
                End If
                If dr("nIslem") = 1 Then
                    dr("sHesapKodu") = dr("sKodu")
                    dr("sHesapAciklama") = dr("sKasaAciklama")
                    dr("nHesapID") = dr("nKasaID")
                End If

                'dr1 = dataset2.Tables(0).NewRow
                'dr1("lFisNo") = dr("lFisNo")
                'dr1("sMuhFisTipi") = dr("sMuhFisTipi")
                'dr1("nIslemId") = dr("nIslemId")
                'dr1("dteIslemTarihi") = dr("dteIslemTarihi")
                'dr1("sHareketTipi") = dr("sHareketTipi")
                'dr1("sKodu") = dr("sKodu")
                'dr1("sHesapKodu") = dr("sHesapKodu")
                'dr1("lTahsilTutar") = dr("lTediyeTutar")
                'dr1("lTediyeTutar") = dr("lTahsilTutar")
                'dr1("sAciklama") = dr("sAciklama")
                'dr1("Sube") = dr("Sube")
                'dr1("sMasrafYontemi") = dr("sMasrafYontemi")
                'dr1("sHesapAciklama") = dr("sHesapAciklama")
                'dr1("sKasaAciklama") = dr("sKasaAciklama")
                'dr1("sDovizCinsi1") = dr("sDovizCinsi1")
                'dr1("lDovizMiktari1") = dr("lDovizMiktari1")
                'dr1("lDovizKuru1") = dr("lDovizKuru1")
                'dr1("sDovizCinsi2") = dr("sDovizCinsi2")
                'dr1("lDovizMiktari2") = dr("lDovizMiktari2")
                'dr1("lDovizKuru2") = dr("lDovizKuru2")
                'dr1("nHesapID") = dr("nHesapID")
                'dr1("nKasaId") = dr("nKasaId")
                'dataset2.Tables(0).Rows.Add(dr1)
            Next
            GridView1.Columns.Clear()
            GridControl1.DataSource = dataset1.Tables(0)
            GridControl1.DataMember = Nothing
            GridView1.Columns("nHesapID").Visible = False
            GridView1.Columns("nKasaID").Visible = False
            GridView1.Columns("sKodu").Visible = False
            GridView1.Columns("sKasaAciklama").Visible = False
            GridView1.Columns("lFisNo").OptionsColumn.ShowInCustomizationForm = True
            GridView1.Columns("lFisNo").OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True
            GridView1.Columns("lFisNo").Group()
            GridView1.Columns("sHesapAciklama").VisibleIndex = GridView1.Columns("sHesapKodu").VisibleIndex + 1
            GridView1.Columns("lTahsilTutar").VisibleIndex = GridView1.Columns("lTediyeTutar").VisibleIndex + 1
            GridView1.Columns("lTahsilTutar").Caption = "Alacak"
            GridView1.Columns("lTahsilTutar").DisplayFormat.FormatString = "#,0.00"
            GridView1.Columns("lTahsilTutar").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns("lTediyeTutar").Caption = "Borç"
            GridView1.Columns("lTediyeTutar").DisplayFormat.FormatString = "#,0.00"
            GridView1.Columns("lTediyeTutar").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns("lTahsilTutar").Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTahsilTutar", "{0:#,0.00}")})
            GridView1.Columns("lTediyeTutar").Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTediyeTutar", "{0:#,0.00}")})
            GridView1.Columns("sAciklama").Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sAciklama", "{0}")})
            GridView1.GroupSummary.Clear()
            GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sAciklama", GridView1.Columns("sAciklama"), "{0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTahsilTutar", GridView1.Columns("lTahsilTutar"), "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTediyeTutar", GridView1.Columns("lTediyeTutar"), "{0:#,0.00}")})
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
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Me.Close()
    End Sub
End Class