Public Class frm_tbDoviz 
    Public firmano
    Public donemno
    Public connection
    Public sKodu As String
    Public sAciklama As String
    Public sDovizCinsi As String = ""
    Public lDovizKuru As Decimal = 0
    Dim dataset1 As DataSet
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Public sText As String = ""
    Private Sub frm_tbDoviz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataset1 = sorgu(sorgu_query(sText))
        sec_sDovizCinsi.Properties.DataSource = dataset1.Tables(0)
        sec_sDovizCinsi.ItemIndex = 0
        sec_sDovizCinsi.Text = sDovizCinsi
        sec_sDovizCinsi.Focus()
        sec_sDovizCinsi.SelectAll()
        tutar_hesapla()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
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
    Private Sub sec_lDovizKuru_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_lDovizKuru.EditValueChanged

        tutar_hesapla()
    End Sub
    Private Sub tutar_hesapla()
        Try
            txt_lDovizTutar.EditValue = FormatNumber(txt_lTutar.EditValue / sec_lDovizKuru.EditValue, 2)
        Catch ex As Exception
            txt_lDovizTutar.EditValue = 0
        End Try
    End Sub
End Class