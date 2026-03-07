Public Class frm_ozelkod_tanimla 
    Public firmano
    Public donemno
    Public connection
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub dataload_siniflar(Optional ByVal sinifno As Integer = 1)
        sec_satici.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSinifKodu, sAciklama FROM         tbSSinif" & sinifno & " ")).Tables(0)
        sec_satici.EditValue = ""
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Function sorgu(ByVal query As String) As DataSet
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        conn.Close()
        Return DS
    End Function
    Private Sub tbSinif(ByVal tablo As String)
        Dim fr As New frm_tbSinif
        fr.firmano = firmano
        fr.donemno = donemno
        fr.connection = connection
        fr.Table = tablo
        fr.ShowDialog()
        dataload_siniflar(sec_sinifno.Text)
        fr.Close()
        fr = Nothing
    End Sub
    Private Sub frm_ozelkod_tanimla_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dataload_siniflar(1)
    End Sub
    Private Sub sec_sinifno_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sinifno.SelectedIndexChanged
        dataload_siniflar(sec_sinifno.Text)
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        tbSinif("tbSSinif")
    End Sub
End Class