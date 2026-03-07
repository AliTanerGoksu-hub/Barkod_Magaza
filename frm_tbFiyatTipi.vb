Imports DevExpress.XtraEditors
Public Class frm_tbFiyatTipi
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_tbDovizCinsi As DataSet
    Dim islem As String = ""
    Dim satir
    Dim aktifDepo As String = ""
    Private Sub frm_tbDepo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dataload_tbFiyatTipi()
        Dataload_tbFiyatTipiDepo()
        dataload_tbDovizCinsi()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dataload_tbDovizCinsi()
        ds_tbDovizCinsi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDovizCinsi,sAciklama FROM         tbDovizCinsi"))
        sec_sDovizCinsi.Properties.DataSource = ds_tbDovizCinsi.Tables(0)
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
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
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
    Private Sub Dataload_tbFiyatTipiDepo()
        Try
            DataSet1.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sDepo, convert(bit, 0) as aktif From tbDepo Where (sDepo <> '')")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(DataSet1, "Table1")
        conn.Close()
        GridControl2.Focus()
        GridControl2.Select()
    End Sub
    Public Sub Dataload_tbFiyatTipi()
        Try
            ds_tbFiyatTipi.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * From tbFiyatTipi Where (sFiyatTipi <> '')")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbFiyatTipi, "Table1")
        conn.Close()
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub tbFiyatTipi_kaydet_yeni(ByVal sFiyatTipi As String, ByVal sAciklama As String, ByVal nAST As Int64, ByVal bKdvDahilmi As Byte, ByVal bDovizeBaglimi As Byte, ByVal sDovizCinsi As String, ByVal sHangiKur As String, ByVal cAktif As Byte)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFiyatTipi (sFiyatTipi, sAciklama, nAST, bKdvDahilmi, bDovizeBaglimi, sDovizCinsi, sHangiKur, aktif, aktifDepo) VALUES ('" & sFiyatTipi & "', N'" & sAciklama & "', " & nAST & ", " & bKdvDahilmi & ", " & bDovizeBaglimi & ", '" & sDovizCinsi & "', '" & sHangiKur & "', " & cAktif & ", '')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbFiyatTipi_kaydet_duzelt(ByVal sFiyatTipi As String, ByVal sAciklama As String, ByVal nAST As Int64, ByVal bKdvDahilmi As Byte, ByVal bDovizeBaglimi As Byte, ByVal sDovizCinsi As String, ByVal sHangiKur As String, ByVal cAktif As Byte, ByVal aktifDepo As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbFiyatTipi SET sAciklama = N'" & sAciklama & "', nAST = " & nAST & ", bKdvDahilmi = " & bKdvDahilmi & ", bDovizeBaglimi = " & bDovizeBaglimi & ",  sDovizCinsi = '" & sDovizCinsi & "', sHangiKur = '" & sHangiKur & "', aktif = " & cAktif & ", aktifDepo = '" & aktifDepo & "' Where sFiyatTipi = '" & sFiyatTipi & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbFiyatTipi_kaydet_sil(ByVal sFiyatTipi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFiyatTipi Where sFiyatTipi  ='" & sFiyatTipi & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function sorgu_sFiyatTipi_kontrol(ByVal sFiyatTipi As String) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(sFiyatTipi), 0) AS nKayit FROM tbFiyatTipi WHERE (sFiyatTipi = '" & sFiyatTipi & "') and sFiyatTipi <>'' ")
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
        txt_sFiyatTipi.EditValue = ""
        txt_sAciklama.EditValue = ""
        txt_nAST.EditValue = 0
        txt_bKdvDahilmi.Checked = False
        txt_bDovizeBaglimi.Checked = False
        sec_sDovizCinsi.EditValue = ""
        txt_sHangiKur.EditValue = ""
        txt_sFiyatTipi.Enabled = True
        islem = "Ekle"
        txt_sFiyatTipi.Focus()
        txt_sFiyatTipi.Select()
    End Sub
    Private Sub kayit_duzelt()
        XtraTabPage1.PageVisible = False
        XtraTabPage2.PageVisible = True
        satir = GridView1.FocusedRowHandle
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        txt_sFiyatTipi.EditValue = dr("sFiyatTipi")
        txt_sAciklama.EditValue = dr("sAciklama")
        txt_nAST.SelectedIndex = dr("nAST")
        txt_bKdvDahilmi.Checked = dr("bKdvDahilmi")
        txt_bDovizeBaglimi.Checked = dr("bDovizeBaglimi")
        sec_sDovizCinsi.EditValue = dr("sDovizCinsi")
        txt_sHangiKur.EditValue = dr("sHangiKur")
        aktifC.Checked = dr("aktif")
        aktifDepo = dr("aktifDepo")
        txt_sFiyatTipi.Enabled = False
        islem = "Düzelt"
        dr = Nothing
        txt_sAciklama.Focus()
        txt_sAciklama.SelectAll()
        If Trim(aktifDepo) <> "" Then
            aktifDepoVeriAl(0)
        Else
            For x As Integer = 0 To DataSet1.Tables(0).Rows.Count - 1
                GridView2.SetRowCellValue(x, "aktif", 0)
            Next
        End If
    End Sub
    Private Sub aktifDepoVeriAl(ByVal opt As Integer)
        Dim dr As DataRow
        Dim x As Integer = 0
        If opt = 0 Then
            If aktifDepo.Length > 5 Then
                Dim words As String() = aktifDepo.Split(New Char() {"|"c})
                Dim word As String
                For x = 0 To DataSet1.Tables(0).Rows.Count - 1
                    GridView2.SetRowCellValue(x, "aktif", 0)
                Next
                For Each word In words
                    For x = 0 To DataSet1.Tables(0).Rows.Count - 1
                        If Trim(GridView2.GetRowCellValue(x, "sDepo").ToString()) = Trim(word) Then
                            GridView2.SetRowCellValue(x, "aktif", 1)
                        End If
                    Next
                Next
            Else
                For x = 0 To DataSet1.Tables(0).Rows.Count - 1
                    GridView2.SetRowCellValue(x, "aktif", 0)
                Next
                For x = 0 To DataSet1.Tables(0).Rows.Count - 1
                    If Trim(GridView2.GetRowCellValue(x, "sDepo").ToString()) = Trim(aktifDepo) Then
                        GridView2.SetRowCellValue(x, "aktif", 1)
                    End If
                Next
            End If
        ElseIf opt = 1 Then
            aktifDepo = ""
            For x = 0 To DataSet1.Tables(0).Rows.Count - 1
                If Boolean.Parse(GridView2.GetRowCellValue(x, "aktif").ToString()) = True Then
                    aktifDepo += GridView2.GetRowCellValue(x, "sDepo") + "|"
                End If
            Next
        End If
        aktifDepo = aktifDepo.Substring(0, (aktifDepo.Length - 1))
    End Sub
    Private Sub kayit_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Kaydý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            tbFiyatTipi_kaydet_sil(dr("sFiyatTipi"))
            Dataload_tbFiyatTipi()
        End If
    End Sub
    Private Sub kaydet()
        If islem = "Ekle" Then
            tbFiyatTipi_kaydet_yeni(txt_sFiyatTipi.EditValue, txt_sAciklama.EditValue, txt_nAST.SelectedIndex, CType(txt_bKdvDahilmi.EditValue, Byte), CType(txt_bDovizeBaglimi.EditValue, Byte), sec_sDovizCinsi.EditValue, txt_sHangiKur.EditValue, CType(aktifC.EditValue, Byte))
            Dataload_tbFiyatTipi()
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
        ElseIf islem = "Düzelt" Then
            aktifDepoVeriAl(1)
            tbFiyatTipi_kaydet_duzelt(txt_sFiyatTipi.EditValue, txt_sAciklama.EditValue, txt_nAST.SelectedIndex, CType(txt_bKdvDahilmi.EditValue, Byte), CType(txt_bDovizeBaglimi.EditValue, Byte), sec_sDovizCinsi.EditValue, txt_sHangiKur.EditValue, CType(aktifC.EditValue, Byte), aktifDepo)
            Dataload_tbFiyatTipi()
            GridView1.FocusedRowHandle = satir
        End If
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = False
        GridControl1.Focus()
        GridControl1.Select()
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
    Private Sub txt_sFiyatTipi_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sFiyatTipi.Validating
        If islem = "Ekle" Then
            If sorgu_sFiyatTipi_kontrol(Trim(txt_sFiyatTipi.EditValue)) = False Then
                txt_sFiyatTipi.ErrorText = txt_sFiyatTipi.Text & vbTab & "Kaydý Daha Önce Kullanýlmýþ"
                e.Cancel = True
                txt_sFiyatTipi.Focus()
                txt_sFiyatTipi.SelectAll()
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
    Private Sub txt_bDovizeBaglimi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_bDovizeBaglimi.CheckStateChanged
        If txt_bDovizeBaglimi.Checked = True Then
            sec_sDovizCinsi.Enabled = True
            txt_sHangiKur.Enabled = True
        ElseIf txt_bDovizeBaglimi.Checked = False Then
            sec_sDovizCinsi.Enabled = False
            txt_sHangiKur.Enabled = False
            sec_sDovizCinsi.EditValue = ""
            txt_sHangiKur.EditValue = ""
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Editör Ekranýný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
End Class