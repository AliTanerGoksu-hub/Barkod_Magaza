Imports DevExpress.XtraEditors
Public Class frm_emir_kredikartlari_banka_odemeleri_detay
    Public firmano
    Public donemno
    Public connection
    Dim sKasiyerRumuzu As String
    Dim sKasiyer As String
    Dim sMagaza As String
    Public kullanici As String
    Dim ds_kasiyer As DataSet
    Dim dataset1 As DataSet
    Private Sub frm_emir_kredikartlari_banka_odemeleri_detay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        DateEdit1.EditValue = dteSistemTarihi
        DateEdit2.EditValue = dteSistemTarihi
        dataload_kasiyer()
        txt_sOdemeSekli.EditValue = ""
        'dataload(DateEdit1.EditValue, DateEdit1.EditValue, txt_sOdemeSekli.editvalue)
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub dataload_kasiyer()
        ds_kasiyer = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sKasiyerRumuzu AS IND, sAdi + ' ' + sSoyadi AS KASIYER, sSifresi AS SIFRE, sDepo AS DEPO FROM         tbKasiyer WHERE     (sKasiyerRumuzu <> '')"))
    End Sub
  
    Private Sub gorunum_yukle()
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim itm
        For Each itm In kisayol.Items
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Baþlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "Ýçerir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
        ElseIf kriter = "Boþ" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklý" Then
            sorgu_kriter = " <> '" & deger & "' "
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = " >  '" & deger & "' "
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = " < '" & deger & "' "
        ElseIf kriter = "Eþittir" Then
            sorgu_kriter = " = '" & deger & "' "
        End If
        Return sorgu_kriter
    End Function
    Private Function sorgu(ByVal query As String) As DataSet
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
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        con.Close()
        Return DS
    End Function
    Public Function stok(ByVal dteTaksitTarihi1 As DateTime, ByVal dteTaksitTarihi2 As DateTime, ByVal sOdemeSekli As String) As DataSet
        Dim kriter As String = ""
        If sec_Tarih.Text = "Geçiþ Tarihi:" Then
            kriter += "WHERE (tbAVKartTaksit.dteTaksitTarihi BETWEEN '" & dteTaksitTarihi1 & "' AND '" & dteTaksitTarihi2 & "') "
        ElseIf sec_Tarih.Text = "Çekim Tarihi:" Then
            kriter += "WHERE (tbOdeme.dteOdemeTarihi BETWEEN '" & dteTaksitTarihi1 & "' AND '" & dteTaksitTarihi2 & "') "
        End If
        If sOdemeSekli <> "" Then
            kriter += " AND (tbAVKartTaksit.sOdemeSekli LIKE '" & sOdemeSekli & "%')"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAVKartTaksit.sOdemeSekli, tbAVKartTaksit.lIadeTutari, tbAVKartTaksit.lTaksitTutari, tbAVKartTaksit.lKomisyonTutari, tbAVKartTaksit.lKomisyonKDV, tbAVKartTaksit.lServisBedeli, tbAVKartTaksit.lPuan, tbAVKartTaksit.lPuanKdv,  CASE WHEN tbAVKartTaksit.lTaksitTutari = 0 THEN tbAVKartTaksit.lIadeTutari - tbAVKartTaksit.lKomisyonTutari - tbAVKartTaksit.lServisBedeli - tbAVKartTaksit.lPuan - tbAVKartTaksit.lPuanKdv WHEN tbAVKartTaksit.lTaksitTutari <> 0 THEN tbAVKartTaksit.lTaksitTutari - tbAVKartTaksit.lKomisyonTutari - tbAVKartTaksit.lServisBedeli - tbAVKartTaksit.lPuan - tbAVKartTaksit.lPuanKdv END AS lNetTutar, tbOdeme.sMagaza,tbOdeme.lOdemeTutar, tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbAVKartTaksit.nKartTaksitID, tbAVKartTaksit.dteTaksitTarihi, tbAVKartTaksit.nOdemeID, tbAVKartTaksit.lIadeTutari, ROUND(CAST(tbAVKartTaksit.dteTaksitTarihi - (CAST(tbOdeme.dteOdemeTarihi AS INT) ) AS FLOAT), 0) AS GUN, tbOdeme.dteOdemeTarihi FROM tbAVKartTaksit INNER JOIN tbOdeme ON tbAVKartTaksit.nOdemeID = tbOdeme.nOdemeID INNER JOIN aEmirOdemeSekliFirma ON tbAVKartTaksit.sOdemeSekli = aEmirOdemeSekliFirma.sOdemeSekli LEFT OUTER JOIN tbFirma ON aEmirOdemeSekliFirma.nFirmaID = tbFirma.nFirmaID " & kriter & " ORDER BY tbAVKartTaksit.sOdemeSekli")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub dataload(ByVal dteTaksitTarihi1 As DateTime, ByVal dteTaksitTarihi2 As DateTime, ByVal sOdemeSekli As String)
        dataset1 = stok(dteTaksitTarihi1, dteTaksitTarihi2, sOdemeSekli)
        GridControl1.DataSource = dataset1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub kasiyer_kontrol(Optional ByVal status As Boolean = False)
        Dim sonuc As Boolean = False
        Dim dr As DataRow
        For Each dr In ds_kasiyer.Tables(0).Rows
            If dr("SIFRE") = txt_kasiyer_kod.Text Then
                sKasiyerRumuzu = dr("IND")
                sKasiyer = dr("KASIYER")
                sMagaza = dr("DEPO")
                sonuc = True
            End If
        Next
        If sonuc = True Then
            lbl_kasiyer.Text = sKasiyer
            'sec_magaza.EditValue = sMagaza
            txt_kasiyer_kod.Enabled = False
            GridControl1.Enabled = True
            GridControl1.Focus()
            GridControl1.Select()
            'PanelControl2.Enabled = True
            'BarSubItem1.Enabled = True
            DateEdit1.Enabled = True
            DateEdit2.Enabled = True
        ElseIf sonuc = False Then
            lbl_kasiyer.Text = ""
            txt_kasiyer_kod.Enabled = True
            txt_kasiyer_kod.EditValue = ""
            GridControl1.Enabled = False
            DateEdit1.Enabled = False
            DateEdit2.Enabled = False
            'PanelControl2.Enabled = False
            'BarSubItem1.Enabled = False
            If status = False Then
                If XtraMessageBox.Show(Sorgu_sDil("Þifre Hatalý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information) Then
                    txt_kasiyer_kod.Focus()
                    txt_kasiyer_kod.SelectAll()
                End If
            Else
                txt_kasiyer_kod.Focus()
                txt_kasiyer_kod.SelectAll()
            End If
        End If
        dr = Nothing
        sonuc = Nothing
    End Sub
    Private Sub tbMagazaMasrafi_kaydet_yeni(ByVal nMasrafID As String, ByVal dteMasrafTarihi As DateTime, ByVal sMagaza As String, ByVal sKasiyerRumuzu As String, ByVal lFisno As Decimal, ByVal sMasrafTipi As String, ByVal sAciklama As String, ByVal nKdvOrani As Decimal, ByVal lTutar As Decimal, ByVal nKasaNo As Integer, ByVal bMuhasebeyeIslendimi As Integer, ByVal sHareketTipi As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMagazaMasrafi (nMasrafID, dteMasrafTarihi, sMagaza, sKasiyerRumuzu, lFisno, sMasrafTipi, sAciklama, nKdvOrani, lTutar, nKasaNo, bMuhasebeyeIslendimi, sHareketTipi) VALUES     ('" & nMasrafID & "', '" & dteMasrafTarihi & "', '" & sMagaza & "', '" & sKasiyerRumuzu & "', " & lFisno & ", '" & sMasrafTipi & "', N'" & sAciklama & "', " & nKdvOrani & ", " & lTutar & ", " & nKasaNo & ", " & bMuhasebeyeIslendimi & ", '" & sHareketTipi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbtbAVKartTaksit_kaydet_duzelt(ByVal nKartTaksitID As String, ByVal nOdemeID As String, ByVal sOdemeSekli As String, ByVal dteTaksitTarihi As DateTime, ByVal lTaksitTutari As Decimal, ByVal lIadeTutari As Decimal, ByVal lPuan As Decimal, ByVal lPuanKdv As Decimal, ByVal lServisBedeli As Decimal, ByVal lKomisyonTutari As Decimal)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAVKartTaksit SET               sOdemeSekli = '" & sOdemeSekli & "', dteTaksitTarihi = '" & dteTaksitTarihi & "', lTaksitTutari = " & lTaksitTutari & ", lIadeTutari = " & lIadeTutari & ", lPuan = " & lPuan & ", lPuanKdv = " & lPuanKdv & ", lServisBedeli = " & lServisBedeli & ", lKomisyonTutari = " & lKomisyonTutari & " Where nKartTaksitID = '" & nKartTaksitID & "' AND nOdemeID = '" & nOdemeID & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMagazaMasrafi_kaydet_sil(ByVal nMasrafID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbMagazaMasrafi Where nMasrafID = '" & nMasrafID & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tutar_hesapla()
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        tbtbAVKartTaksit_kaydet_duzelt(dr("nKartTaksitID"), dr("nOdemeID"), dr("sOdemeSekli"), dr("dteTaksitTarihi"), dr("lTaksitTutari"), dr("lIadeTutari"), dr("lPuan"), dr("lPuanKdv"), dr("lServisBedeli"), dr("lKomisyonTutari"))
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, txt_sOdemeSekli.EditValue)
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_text()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Text Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Text Dosyalarý(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_pdf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Metin Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyalarý(*.pdf) |*.pdf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        tutar_hesapla()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        Try
            If GridView1.SelectedRowsCount > 1 Then
                Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
            ElseIf GridView1.SelectedRowsCount = 1 Then
                Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
            Else
                Label2.Text = ""
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GörünümüYazdýrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüYazdýrToolStripMenuItem.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        DateEdit1.Focus()
        DateEdit1.SelectAll()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_pdf()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

 
    'Private Sub gorunum_kaydet()
    '    GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    '    XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    'End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub GörünümüKaydetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GörünümüKaydetToolStripMenuItem.Click
        gorunum_kaydet()
    End Sub

    Private Sub GruplandýrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GruplandýrToolStripMenuItem.Click
        GridView1.OptionsView.ShowGroupPanel = True
        GridView1.OptionsCustomization.AllowGroup = True
    End Sub
End Class