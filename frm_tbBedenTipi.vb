Imports DevExpress.XtraEditors
Public Class frm_tbBedenTipi
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim islem As String = ""
    Dim satir
    Private Sub frm_tbDepo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dataload_tbBedenTipi()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
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
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
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
    Public Sub Dataload_tbBedenTipi()
        Try
            ds_tbBedenTipi.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * From tbBedenTipi Where sBedenTipi <>'' ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbBedenTipi, "Table1")
        conn.Close()
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub tbBedenTipi_kaydet_yeni(ByVal sBedenTipi As String, ByVal sAciklama As String, ByVal sBeden1 As String, ByVal sBeden2 As String, ByVal sBeden3 As String, ByVal sBeden4 As String, ByVal sBeden5 As String, ByVal sBeden6 As String, ByVal sBeden7 As String, ByVal sBeden8 As String, ByVal sBeden9 As String, ByVal sBeden10 As String, ByVal sBeden11 As String, ByVal sBeden12 As String, ByVal sBeden13 As String, ByVal sBeden14 As String, ByVal sBeden15 As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbBedenTipi (sBedenTipi, sAciklama, sBeden1, sBeden2, sBeden3, sBeden4, sBeden5, sBeden6, sBeden7, sBeden8, sBeden9, sBeden10, sBeden11, sBeden12, sBeden13, sBeden14, sBeden15) VALUES     ('" & sBedenTipi & "', N'" & sAciklama & "', '" & sBeden1 & "', '" & sBeden2 & "', '" & sBeden3 & "', '" & sBeden4 & "', '" & sBeden5 & "', '" & sBeden6 & "', '" & sBeden7 & "', '" & sBeden8 & "', '" & sBeden9 & "', '" & sBeden10 & "', '" & sBeden11 & "', '" & sBeden12 & "', '" & sBeden13 & "', '" & sBeden14 & "', '" & sBeden15 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbBedenTipi_kaydet_duzelt(ByVal sBedenTipi As String, ByVal sAciklama As String, ByVal sBeden1 As String, ByVal sBeden2 As String, ByVal sBeden3 As String, ByVal sBeden4 As String, ByVal sBeden5 As String, ByVal sBeden6 As String, ByVal sBeden7 As String, ByVal sBeden8 As String, ByVal sBeden9 As String, ByVal sBeden10 As String, ByVal sBeden11 As String, ByVal sBeden12 As String, ByVal sBeden13 As String, ByVal sBeden14 As String, ByVal sBeden15 As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbBedenTipi SET              sAciklama = N'" & sAciklama & "', sBeden1 = '" & sBeden1 & "', sBeden2 = '" & sBeden2 & "', sBeden3 = '" & sBeden3 & "', sBeden4 = '" & sBeden4 & "', sBeden5 = '" & sBeden5 & "', sBeden6 = '" & sBeden6 & "', sBeden7 = '" & sBeden7 & "', sBeden8 = '" & sBeden8 & "', sBeden9 = '" & sBeden9 & "', sBeden10 = '" & sBeden10 & "',  sBeden11 = '" & sBeden11 & "', sBeden12 = '" & sBeden12 & "', sBeden13 = '" & sBeden13 & "', sBeden14 = '" & sBeden14 & "', sBeden15 = '" & sBeden15 & "' Where sBedenTipi = '" & sBedenTipi & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbBedenTipi_kaydet_sil(ByVal sBedenTipi As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbBedenTipi Where sBedenTipi  ='" & sBedenTipi & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_sBedenTipi_kontrol(ByVal sBedenTipi As String) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sBedenTipi), 0) AS nKayit FROM         tbBedenTipi WHERE     (sBedenTipi = '" & sBedenTipi & "') and sBedenTipi <>'' ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Private Sub kayit_ekle()
        XtraTabPage1.PageVisible = False
        XtraTabPage2.PageVisible = True
        txt_sBedenTipi.EditValue = ""
        txt_sAciklama.EditValue = ""
        txt_sBeden1.EditValue = ""
        txt_sBeden2.EditValue = ""
        txt_sBeden3.EditValue = ""
        txt_sBeden4.EditValue = ""
        txt_sBeden5.EditValue = ""
        txt_sBeden6.EditValue = ""
        txt_sBeden7.EditValue = ""
        txt_sBeden8.EditValue = ""
        txt_sBeden9.EditValue = ""
        txt_sBeden10.EditValue = ""
        txt_sBeden11.EditValue = ""
        txt_sBeden12.EditValue = ""
        txt_sBeden13.EditValue = ""
        txt_sBeden14.EditValue = ""
        txt_sBeden15.EditValue = ""
        txt_sBedenTipi.Enabled = True
        islem = "Ekle"
        txt_sBedenTipi.Focus()
        txt_sBedenTipi.Select()
    End Sub
    Private Sub kayit_duzelt()
        XtraTabPage1.PageVisible = False
        XtraTabPage2.PageVisible = True
        satir = GridView1.FocusedRowHandle
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        txt_sBedenTipi.EditValue = dr("sBedenTipi")
        txt_sAciklama.EditValue = dr("sAciklama")
        txt_sBeden1.EditValue = dr("sBeden1")
        txt_sBeden2.EditValue = dr("sBeden2")
        txt_sBeden3.EditValue = dr("sBeden3")
        txt_sBeden4.EditValue = dr("sBeden4")
        txt_sBeden5.EditValue = dr("sBeden5")
        txt_sBeden6.EditValue = dr("sBeden6")
        txt_sBeden7.EditValue = dr("sBeden7")
        txt_sBeden8.EditValue = dr("sBeden8")
        txt_sBeden9.EditValue = dr("sBeden9")
        txt_sBeden10.EditValue = dr("sBeden10")
        txt_sBeden11.EditValue = dr("sBeden11")
        txt_sBeden12.EditValue = dr("sBeden12")
        txt_sBeden13.EditValue = dr("sBeden13")
        txt_sBeden14.EditValue = dr("sBeden14")
        txt_sBeden15.EditValue = dr("sBeden15")
        txt_sBedenTipi.Enabled = False
        islem = "Düzelt"
        dr = Nothing
        txt_sAciklama.Focus()
        txt_sAciklama.SelectAll()
    End Sub
    Private Sub kayit_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Kaydý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            tbBedenTipi_kaydet_sil(dr("sBedenTipi"))
            Dataload_tbBedenTipi()
        End If
    End Sub
    Private Sub kaydet()
        If islem = "Ekle" Then
            tbBedenTipi_kaydet_yeni(txt_sBedenTipi.EditValue, txt_sAciklama.EditValue, txt_sBeden1.EditValue, txt_sBeden2.EditValue, txt_sBeden3.EditValue, txt_sBeden4.EditValue, txt_sBeden5.EditValue, txt_sBeden6.EditValue, txt_sBeden7.EditValue, txt_sBeden8.EditValue, txt_sBeden9.EditValue, txt_sBeden10.EditValue, txt_sBeden11.EditValue, txt_sBeden12.EditValue, txt_sBeden13.EditValue, txt_sBeden14.EditValue, txt_sBeden15.EditValue)
            Dataload_tbBedenTipi()
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
        ElseIf islem = "Düzelt" Then
            tbBedenTipi_kaydet_duzelt(txt_sBedenTipi.EditValue, txt_sAciklama.EditValue, txt_sBeden1.EditValue, txt_sBeden2.EditValue, txt_sBeden3.EditValue, txt_sBeden4.EditValue, txt_sBeden5.EditValue, txt_sBeden6.EditValue, txt_sBeden7.EditValue, txt_sBeden8.EditValue, txt_sBeden9.EditValue, txt_sBeden10.EditValue, txt_sBeden11.EditValue, txt_sBeden12.EditValue, txt_sBeden13.EditValue, txt_sBeden14.EditValue, txt_sBeden15.EditValue)
            Dataload_tbBedenTipi()
            GridView1.FocusedRowHandle = satir
        End If
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = False
        GridControl1.Focus()
        GridControl1.Select()
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
    Private Sub EkleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EkleToolStripMenuItem.Click
        kayit_ekle()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub GörünümüDüzenleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüDüzenleToolStripMenuItem.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub GörünümüKaydetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüKaydetToolStripMenuItem.Click
        gorunum_kaydet()
    End Sub
    Private Sub GörünümüYazdýrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüYazdýrToolStripMenuItem.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub HýzlýFiltreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HýzlýFiltreToolStripMenuItem.Click
        If HýzlýFiltreToolStripMenuItem.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsView.ShowAutoFilterRow = True
            HýzlýFiltreToolStripMenuItem.Checked = True
        ElseIf HýzlýFiltreToolStripMenuItem.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsView.ShowAutoFilterRow = False
            HýzlýFiltreToolStripMenuItem.Checked = False
        End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If MenuItem6.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            MenuItem6.Checked = True
        ElseIf MenuItem6.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            MenuItem6.Checked = False
        End If
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        If MenuItem7.Checked = False Then
            GridView1.OptionsCustomization.AllowGroup = True
            GridView1.OptionsView.ShowGroupPanel = True
            MenuItem7.Checked = True
        ElseIf MenuItem7.Checked = True Then
            GridView1.OptionsCustomization.AllowGroup = False
            GridView1.OptionsView.ShowGroupPanel = False
            MenuItem7.Checked = False
        End If
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub DuzeltToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DuzeltToolStripMenuItem.Click
        kayit_duzelt()
    End Sub
    Private Sub SilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SilToolStripMenuItem.Click
        kayit_sil()
    End Sub
    Private Sub btn_vazgec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_vazgec.Click
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = False
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub btn_kaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_kaydet.Click
        kaydet()
    End Sub
    Private Sub txt_sBedenTipi_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sBedenTipi.Validating
        If islem = "Ekle" Then
            If sorgu_sBedenTipi_kontrol(Trim(txt_sBedenTipi.EditValue)) = False Then
                txt_sBedenTipi.ErrorText = txt_sBedenTipi.Text & vbTab & "Kaydý Daha Önce Kullanýlmýþ"
                e.Cancel = True
                txt_sBedenTipi.Focus()
                txt_sBedenTipi.SelectAll()
            End If
        End If
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Editör Ekranýný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        kayit_ekle()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        kayit_duzelt()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        kayit_sil()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        raporla_pdf()
    End Sub
End Class