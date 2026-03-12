Public Class frm_tbKod 
    Public firmano
    Public donemno
    Public connection
    Public sKodu As String
    Public sAciklama As String
    Dim dataset1 As DataSet
    Public sText As String = ""
    Public bDepo As Boolean
    Private Sub SimpleButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SimpleButton1.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Close()
    End Sub
    Private Sub frm_tbKod_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If bDepo = True Then
            Group_Depo.Visible = True
            Height = 200
        Else
            Group_Depo.Visible = False
            Height = 155
        End If
        dataset1 = sorgu(sorgu_query(sText))
        LookUpEdit1.Properties.DataSource = dataset1.Tables(0)
        LookUpEdit1.ItemIndex = 1
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Function sorgu(ByVal query As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Using adapter As New OleDb.OleDbDataAdapter()
            con.ConnectionString = connection
            cmd.CommandTimeout = Nothing
            adapter.SelectCommand = cmd
            cmd.CommandText = query
            cmd.Connection = con
            con.Open()
            Dim DS As New DataSet()
            adapter.Fill(DS, "TABLE1")
            con.Close()
            Return DS
        End Using
    End Function
End Class