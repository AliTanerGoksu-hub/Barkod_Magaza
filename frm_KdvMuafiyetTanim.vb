Public Class frm_KdvMuafiyetTanim
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
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        SimpleButton4.Text = Sorgu_sDil(SimpleButton4.Text, sDil)
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

    Public Sub Dataload_tbKdvMuafiyetKodlari()
        Try
            ds_tbKdvMuafiyetKodlari.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbKdvMuafiyetKodlari WHERE sKod <> '' ORDER BY sKod")
        cmd.Connection = conn
        Dim N As Integer = adapter.Fill(ds_tbKdvMuafiyetKodlari, "Table1")
        conn.Close()
        GridControl1.Focus()
        GridControl1.Select()
    End Sub

    Private Sub tbKdvMuafiyetKodlari_kaydet_yeni(ByVal sKod As String, ByVal sKanunMaddesi As String, ByVal sAciklama As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbKdvMuafiyetKodlari (sKod, sKanunMaddesi, sAciklama, bAktif) VALUES ('" & sKod & "', '" & sKanunMaddesi & "', '" & sAciklama & "', 1)")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub tbKdvMuafiyetKodlari_kaydet_duzelt(ByVal nID As Integer, ByVal sKod As String, ByVal sKanunMaddesi As String, ByVal sAciklama As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbKdvMuafiyetKodlari SET sKod = '" & sKod & "', sKanunMaddesi = '" & sKanunMaddesi & "', sAciklama = '" & sAciklama & "' WHERE nID = " & nID)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub tbKdvMuafiyetKodlari_kaydet_sil(ByVal nID As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbKdvMuafiyetKodlari WHERE nID = " & nID)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Public Function sorgu_sKod_kontrol(ByVal sKod As String) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(sKod), 0) AS nKayit FROM tbKdvMuafiyetKodlari WHERE sKod = '" & sKod & "' AND sKod <> ''")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function

    Private Sub kayit_ekle()
        islem = "Ekle"
        PanelControl3.Visible = True
        txt_sKod.EditValue = ""
        txt_sKanunMaddesi.EditValue = ""
        txt_sAciklama.EditValue = ""
        txt_sKod.Focus()
        txt_sKod.SelectAll()
    End Sub

    Private Sub kayit_duzelt()
        islem = "Duzelt"
        PanelControl3.Visible = True
        txt_sKod.EditValue = GridView1.GetFocusedRowCellValue("sKod")
        txt_sKanunMaddesi.EditValue = GridView1.GetFocusedRowCellValue("sKanunMaddesi")
        txt_sAciklama.EditValue = GridView1.GetFocusedRowCellValue("sAciklama")
        txt_sKod.Focus()
        txt_sKod.SelectAll()
    End Sub

    Private Sub kayit_sil()
        If MessageBox.Show(Sorgu_sDil("Seçili Kaydı Silmek İstediğinize Emin misiniz?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim nID As Integer = GridView1.GetFocusedRowCellValue("nID")
            tbKdvMuafiyetKodlari_kaydet_sil(nID)
            Dataload_tbKdvMuafiyetKodlari()
        End If
    End Sub

    Private Sub btn_kaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_kaydet.Click
        If islem = "Ekle" Then
            tbKdvMuafiyetKodlari_kaydet_yeni(txt_sKod.Text, txt_sKanunMaddesi.Text, txt_sAciklama.Text)
            Dataload_tbKdvMuafiyetKodlari()
            PanelControl3.Visible = False
        ElseIf islem = "Duzelt" Then
            Dim nID As Integer = GridView1.GetFocusedRowCellValue("nID")
            tbKdvMuafiyetKodlari_kaydet_duzelt(nID, txt_sKod.Text, txt_sKanunMaddesi.Text, txt_sAciklama.Text)
            Dataload_tbKdvMuafiyetKodlari()
            PanelControl3.Visible = False
        End If
    End Sub

    Private Sub btn_vazgec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_vazgec.Click
        PanelControl3.Visible = False
    End Sub

    Private Sub raporla_excel()
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "Excel Dosyası|*.xlsx"
        sfd.Title = "Excel Olarak Kaydet"
        sfd.FileName = "KdvMuafiyetKodlari_" & DateTime.Now.ToString("yyyyMMdd_HHmmss")
        If sfd.ShowDialog() = DialogResult.OK Then
            GridView1.ExportToXlsx(sfd.FileName)
            MessageBox.Show(Sorgu_sDil("Excel dosyası kaydedildi.", sDil), Sorgu_sDil("Bilgi", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub raporla_pdf()
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "PDF Dosyası|*.pdf"
        sfd.Title = "PDF Olarak Kaydet"
        sfd.FileName = "KdvMuafiyetKodlari_" & DateTime.Now.ToString("yyyyMMdd_HHmmss")
        If sfd.ShowDialog() = DialogResult.OK Then
            GridView1.ExportToPdf(sfd.FileName)
            MessageBox.Show(Sorgu_sDil("PDF dosyası kaydedildi.", sDil), Sorgu_sDil("Bilgi", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub raporla_text()
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "Text Dosyası|*.txt"
        sfd.Title = "Text Olarak Kaydet"
        sfd.FileName = "KdvMuafiyetKodlari_" & DateTime.Now.ToString("yyyyMMdd_HHmmss")
        If sfd.ShowDialog() = DialogResult.OK Then
            GridView1.ExportToText(sfd.FileName)
            MessageBox.Show(Sorgu_sDil("Text dosyası kaydedildi.", sDil), Sorgu_sDil("Bilgi", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txt_sKod_TextChanged(sender As Object, e As EventArgs) Handles txt_sKod.TextChanged
        If Len(Trim(txt_sKod.EditValue)) > 0 And Len(Trim(txt_sAciklama.EditValue)) > 0 Then
            btn_kaydet.Enabled = True
        Else
            btn_kaydet.Enabled = False
        End If
    End Sub

    Private Sub txt_sAciklama_TextChanged(sender As Object, e As EventArgs) Handles txt_sAciklama.TextChanged
        If Len(Trim(txt_sKod.EditValue)) > 0 And Len(Trim(txt_sAciklama.EditValue)) > 0 Then
            btn_kaydet.Enabled = True
        Else
            btn_kaydet.Enabled = False
        End If
    End Sub

    Private Sub txt_sKod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sKod.Validating
        If islem = "Ekle" Then
            If sorgu_sKod_kontrol(Trim(txt_sKod.EditValue)) = False Then
                txt_sKod.ErrorText = txt_sKod.Text & vbTab & MessageBox.Show("Girmiş Olduğunuz Kod Daha Önce Kullanılmıştır")
                e.Cancel = True
                txt_sKod.Focus()
                txt_sKod.SelectAll()
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

    Private Sub frm_KdvMuafiyetTanim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dataload_tbKdvMuafiyetKodlari()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        PanelControl3.Visible = False
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

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        kayit_duzelt()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Me.Close()
    End Sub
End Class