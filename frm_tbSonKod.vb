Public Class frm_tbSonKod 
    Public firmano
    Public donemno
    Public kullanici
    Public connection
    Public islem As String
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub frm_tbSonKod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_sKodu.EditValue = ""
        txt_sKodu.Focus()
        txt_sKodu.SelectAll()
    End Sub
    Private Sub txt_sKodu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_sKodu.KeyDown
        If e.KeyCode = Keys.Enter Then
            sorgu_sKodu_kontrol(Trim(txt_sKodu.EditValue))
        End If
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Public Sub sorgu_sKodu_kontrol(ByVal kod As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        If islem = "tbFirma" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(MAX(sKodu), '') AS sKod FROM tbFirma WHERE (sKodu LIKE '" & kod & "%')")
        ElseIf islem = "tbHesapPlani" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(MAX(sKodu), '') AS sKod FROM tbHesapPlani WHERE (sKodu LIKE '" & kod & "%')")
        ElseIf islem = "tbCekSenet" Then
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT 'H-' + ISNULL(cast(MAX(cast(substring(sNot, 3, len(snot) - 1)as int)) as varchar(15)), '') AS sKod FROM tbCekSenet WHERE (sNot LIKE '" & kod & "%') and (sNot not like '% %')")
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '" & Trim(kod) & "-' + ISNULL(cast(ISNULL((MAX(cast(substring(sNot, 3, len(snot) - 1) as int)) + 1), 1) as varchar(15)), '') AS sKod FROM tbCekSenet WHERE (sNot LIKE '%" & Trim(kod) & "-%') and (sNot not like '% %') and (isnumeric(ISNULL(CAST(SUBSTRING(sNot, 3, len(sNot) - 1) as varchar(15)), '')) = 1)")
        ElseIf islem = "tbStok" Then
            If sec_bModel.Checked = True Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(MAX(sModel), '') AS sKod FROM tbStok WHERE (sModel LIKE '" & kod & "%')")
            Else
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(MAX(sKodu), '') AS sKod FROM tbStok WHERE (sKodu LIKE '" & kod & "%')")
            End If
        ElseIf islem = "sKisaAdi" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(MAX(sKisaAdi), '') AS sKod FROM tbStok WHERE (sKisaAdi LIKE '" & kod & "%')")
        ElseIf islem = "tbKoli" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(MAX(sKoliKodu), '') AS sKod FROM tbKoli WHERE (sKoliKodu LIKE '" & kod & "%')")
        End If
        lbl_Kod.Text = Trim(cmd.ExecuteScalar)
        conn.Close()
    End Sub
    Private Sub btn_goster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_goster.Click
        sorgu_sKodu_kontrol(Trim(txt_sKodu.EditValue))
    End Sub
End Class