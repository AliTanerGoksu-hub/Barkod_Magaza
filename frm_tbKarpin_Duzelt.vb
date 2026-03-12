Public Class frm_tbKarpin_Duzelt 
    Public Connection As String
    Public FirmaNo As Integer
    Public DonemNo As Integer
    Public Kullanici As String
    Public bIslemStatus As Boolean = False
    Public sSaticiRumuzu As String
    Public sDepo As String
    Public nKmBaslangic As Int64
    Public nKmBitis As Int64
    Public nKmFark As Int64
    Private Sub frm_tbKarpin_Duzelt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload_satici()
        dataload_depo()
        If bIslemStatus = True Then
            sec_sSatici.EditValue = Trim(sSaticiRumuzu)
            sec_sDepo.EditValue = sDepo
            txt_KmBaslangic.EditValue = nKmBaslangic
            txt_KmBitis.EditValue = nKmBitis
            txt_Km.EditValue = nKmFark
        End If
    End Sub
    Private Sub dataload_satici()
        sec_sSatici.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     RTRIM(sSaticiRumuzu) as sSaticiRumuzu , sAdi + ' ' + sSoyadi AS sSatici  FROM         tbSatici Order by sSaticiRumuzu ")).Tables(0)
        sec_sSatici.ItemIndex = 0
    End Sub
    Private Sub dataload_depo()
        sec_sDepo.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     RTRIM(sDepo) as sDepo , sAciklama  FROM         tbDepo Order by sDepo ")).Tables(0)
        sec_sDepo.ItemIndex = 0
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = Connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        conn.Close()
        Return DS
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub km_hesapla()
        Try
            txt_Km.EditValue = txt_KmBitis.EditValue - txt_KmBaslangic.EditValue
        Catch ex As Exception
            txt_Km.EditValue = 0
        End Try
    End Sub
    Private Sub txt_KmBaslangic_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_KmBaslangic.EditValueChanged
        km_hesapla()
    End Sub
    Private Sub txt_KmBitis_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_KmBitis.EditValueChanged
        km_hesapla()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        sorgu()
    End Sub
    Private Sub sorgu()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
End Class