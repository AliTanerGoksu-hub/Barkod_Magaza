Public Class frm_tbNot 
    Public connection As String = ""
    Public firmano As Integer
    Public donemno As Integer
    Public kullanici As Integer
    Public kullaniciAdi As String = ""
    Dim ds_kasiyer As DataSet
    Dim ds_tbNot As DataSet
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub frm_tbNot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload_kasiyer()
        Try
            If sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select ISNULL(count(*),0) from tbNot where nKullanici = " & kullanici & "") = 0 Then
                sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbNot                       (nKullanici, sNot) VALUES     (" & kullanici & ", '')")
            End If
        Catch ex As Exception
            sorgula_nStokID("CREATE TABLE [tbNot] (	[nKullanici] [int] NOT NULL CONSTRAINT [DF_tbNot_nKullanici] DEFAULT (0),	[sNot] [ntext] COLLATE Turkish_CI_AS NOT NULL CONSTRAINT [DF_tbNot_sNot] DEFAULT (''),	CONSTRAINT [PK_tbNot] PRIMARY KEY  CLUSTERED 	(		[nKullanici]	)  ON [PRIMARY] ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]")
        End Try

        txt_sNot.Text = sorgula_String("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select sNot from tbNot where nKullanici = " & kullanici & "")
    End Sub
    Private Sub dataload_kasiyer()
        ds_kasiyer = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '0' AS IND, '[Tümü]' AS ACIKLAMA, '1111' AS SIFRE FROM APERSONEL UNION SELECT IND, PERSONELADI AS ACIKLAMA, SIFRE FROM APERSONEL "))
        sec_personel.Properties.DataSource = ds_kasiyer.Tables(0)
        sec_personel.EditValue = kullanici
        sec_personel.Text = kullaniciAdi
        'sec_personel.ItemIndex = 1
        'sec_personel.Refresh()
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim conn As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub duzelt(ByVal nKullanici As Int64, ByVal sNot As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim conn As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    tbNot SET               sNot = '" & sNot & "' WHERE nKullanici= '" & nKullanici & "'")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            If sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select ISNULL(count(*),0) from tbNot where nKullanici = " & kullanici & "") = 0 Then
                sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbNot                       (nKullanici, sNot) VALUES     (" & kullanici & ", '')")
            End If
        Catch ex As Exception
            'sorgula_nStokID("CREATE TABLE [tbNot] (	[nKullanici] [int] NOT NULL CONSTRAINT [DF_tbNot_nKullanici] DEFAULT (0),	[sNot] [ntext] COLLATE Turkish_CI_AS NOT NULL CONSTRAINT [DF_tbNot_sNot] DEFAULT (''),	CONSTRAINT [PK_tbNot] PRIMARY KEY  CLUSTERED 	(		[nKullanici]	)  ON [PRIMARY] ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]")
        End Try
        duzelt(sec_personel.EditValue, Replace(txt_sNot.Text, "'", ""))
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
End Class