Public Class frm_stok_fiyatlandir_toplu 
    Public firmano
    Public donemno
    Public kullanici
    Public connection
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    'Dim ds_tbFiyatTipi As DataSet
    Private Sub frm_stok_fiyatlandir_toplu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'dataload_fiyattipi()
        seckaynak.Properties.Items.Clear()
        seckaynak.Properties.Items.Add(sFiyat1)
        seckaynak.Properties.Items.Add(sFiyat2)
        seckaynak.Properties.Items.Add(sFiyat3)
        seckaynak.Properties.Items.Add(sFiyat4)
        seckaynak.Properties.Items.Add(sFiyat5)
        seckaynak.Properties.Items.Add(sFiyat6)
        seckaynak.Properties.Items.Add(sFiyat7)
        seckaynak.Properties.Items.Add(sFiyatA)
        seckaynak.Properties.Items.Add(sFiyatM)
        sechedef.Properties.Items.Clear()
        sechedef.Properties.Items.Add(sFiyat1)
        sechedef.Properties.Items.Add(sFiyat2)
        sechedef.Properties.Items.Add(sFiyat3)
        sechedef.Properties.Items.Add(sFiyat4)
        sechedef.Properties.Items.Add(sFiyat5)
        sechedef.Properties.Items.Add(sFiyat6)
        sechedef.Properties.Items.Add(sFiyat7)
        sechedef.Properties.Items.Add(sFiyatA)
        sechedef.Properties.Items.Add(sFiyatM)
    End Sub
    Private Sub dataload_fiyattipi()
        'ds_tbFiyatTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFiyatTipi,sAciklama FROM         tbFiyatTipi ORDER BY sFiyatTipi "))
        'seckaynak.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        'seckaynak.ItemIndex = 0
        'sechedef.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        'sechedef.ItemIndex = 0
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
    Private Sub seckriter_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seckriter.SelectedIndexChanged
        If seckriter.Text = "% olarak artýr" Then
            txttutar.Enabled = False
            txtoran.Enabled = True
            seckaynak.Enabled = True
        ElseIf seckriter.Text = "tutar ile artýr" Then
            txtoran.Enabled = False
            txttutar.Enabled = True
            seckaynak.Enabled = True
        ElseIf seckriter.Text = "tutar ile deðiþtir" Then
            txtoran.Enabled = False
            txttutar.Enabled = True
            seckaynak.Enabled = False
        ElseIf seckriter.Text = "YTL 'ye uyarla" Then
            txtoran.Enabled = False
            txttutar.Enabled = False
            seckaynak.Enabled = False
        ElseIf seckriter.Text = "Eski Fiyatý ile deðiþtir" Then
            txtoran.Enabled = False
            txttutar.Enabled = False
            seckaynak.Enabled = False
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class