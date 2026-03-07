Public Class frm_TevkifatTanim
    Public firmano As Integer = 100
    Public donemno As Integer = 1
    Public connection
    Public kullanici
    Public islem As String = ""
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim satir
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
    Private Sub gorunum_yazdir()
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        MessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
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
    Public Sub Dataload_tbTevkifattanim()
        Try
            ds_tbTevkifattanim.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * From  tbTevkifattanim where sTevkifatTipi <>'' ")
        cmd.Connection = conn
        Dim N As Integer = adapter.Fill(ds_tbTevkifattanim, "Table1")
        conn.Close()
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub tbTevkifattanim_kaydet_yeni(ByVal sTevkifatTipi As String, ByVal nTevkifatOrani As Int64, ByVal nTevkifatAciklama As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbTevkifattanim (sTevkifatTipi, nTevkifatOrani , nTevkifatAciklama) VALUES     ('" & sTevkifatTipi & "', " & nTevkifatOrani & " , '" & nTevkifatAciklama & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbTevkifattanim_kaydet_duzelt(ByVal sTevkifatTipi As String, ByVal nTevkifatOrani As Int64, ByVal nTevkifatAciklama As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbTevkifattanim SET   nTevkifatAciklama = '" & nTevkifatAciklama & "' ,  nTevkifatOrani = '" & nTevkifatOrani & "' Where sTevkifatTipi = '" & sTevkifatTipi & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbTevkifattanim_kaydet_sil(ByVal sTevkifatTipi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbTevkifattanim Where sTevkifatTipi ='" & sTevkifatTipi & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_sTevkifatTipi_kontrol(ByVal sTevkifatTipi As String) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sTevkifatTipi), 0) AS nKayit FROM         tbTevkifattanim WHERE     (sTevkifatTipi = '" & sTevkifatTipi & "') and sTevkifatTipi <>'' ")
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
        txt_sTevkifTipi.Enabled = True
        txt_sTevkifTipi.EditValue = ""
        txt_nTevkifOrani.EditValue = 0
        islem = "Ekle"
        txt_nTevkifOrani.Focus()
        txt_sTevkifTipi.Select()
    End Sub
    Private Sub kayit_duzelt()
        XtraTabPage1.PageVisible = False
        XtraTabPage2.PageVisible = True
        satir = GridView1.FocusedRowHandle
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        txt_sTevkifTipi.EditValue = dr("sTevkifatTipi")
        txt_nTevkifOrani.EditValue = dr("nTevkifatOrani")
        txt_TevkifAciklama.EditValue = dr("nTevkifatAciklama")
        txt_sTevkifTipi.Enabled = False
        islem = "Düzelt"
        dr = Nothing
        txt_nTevkifOrani.Focus()
        txt_nTevkifOrani.SelectAll()
    End Sub
    Private Sub kayit_sil()
        If MessageBox.Show(Sorgu_sDil("Kaydı Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            tbTevkifattanim_kaydet_sil(dr("sTevkifatTipi"))
            Dataload_tbTevkifattanim()
        End If
    End Sub
    Private Sub kaydet()
        If islem = "Ekle" Then
            tbTevkifattanim_kaydet_yeni(txt_sTevkifTipi.EditValue, txt_nTevkifOrani.EditValue, txt_TevkifAciklama.EditValue)
            Dataload_tbTevkifattanim()
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
        ElseIf islem = "Düzelt" Then
            tbTevkifattanim_kaydet_duzelt(txt_sTevkifTipi.EditValue, txt_nTevkifOrani.EditValue, txt_TevkifAciklama.EditValue)
            Dataload_tbTevkifattanim()
            GridView1.FocusedRowHandle = satir
        End If
        XtraTabControl1.SelectedTabPageIndex = 0
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = False
        XtraTabControl1.SelectedTabPageIndex = 0
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub raporla_excel()
        If MessageBox.Show(Sorgu_sDil("Sonuçları Excel Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyaları(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If MessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_text()
        If MessageBox.Show(Sorgu_sDil("Sonuçları Text Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Text Dosyaları(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If MessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_pdf()
        If MessageBox.Show(Sorgu_sDil("Sonuçları Metin Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyaları(*.pdf) |*.pdf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If MessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub btn_vazgec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_vazgec.Click
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = False
    End Sub
    Private Sub btn_kaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_kaydet.Click
        kaydet()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        kayit_ekle()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        kayit_duzelt()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        kayit_sil()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub GörünümüKaydetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüKaydetToolStripMenuItem.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        gorunum_yazdir()
    End Sub
    Private Sub HızlıFiltreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HızlıFiltreToolStripMenuItem.Click
        If HızlıFiltreToolStripMenuItem.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsView.ShowAutoFilterRow = True
            HızlıFiltreToolStripMenuItem.Checked = True
        ElseIf HızlıFiltreToolStripMenuItem.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsView.ShowAutoFilterRow = False
            HızlıFiltreToolStripMenuItem.Checked = False
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
    'Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
    '   Me.Close()
    'End Sub
    'Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
    '    Me.Close()
    ' End Sub
    Private Sub txt_sSinifKodu_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_sTevkifTipi.EditValueChanged, txt_sTevkifTipi.EditValueChanged
        If Trim(txt_sTevkifTipi.EditValue) <> "" Then
            btn_kaydet.Enabled = True
        Else
            btn_kaydet.Enabled = False
        End If
    End Sub
    Private Sub txt_sSinifKodu_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sTevkifTipi.Validating, txt_sTevkifTipi.Validating
        If islem = "Ekle" Then
            If sorgu_sTevkifatTipi_kontrol(Trim(txt_sTevkifTipi.EditValue)) = False Then
                txt_sTevkifTipi.ErrorText = txt_sTevkifTipi.Text & vbTab & MessageBox.Show("Girmiş Olduğunuz Tevkifat Tipi Daha Önce Kullanılmıştir")
                e.Cancel = True
                txt_sTevkifTipi.Focus()
                txt_sTevkifTipi.SelectAll()
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
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub frm_tbSinif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dataload_tbTevkifattanim()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txt_bSatisYapilamaz_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btn_kaydet.Focus()
            btn_kaydet.Select()
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MessageBox.Show(Sorgu_sDil("Editör Ekranını Kapatmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        kayit_ekle()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        kayit_sil()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        raporla_pdf()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        raporla_text()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        kayit_duzelt()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton3_Click_1(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton4_Click_1(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
End Class