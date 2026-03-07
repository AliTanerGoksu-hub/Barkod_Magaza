Imports DevExpress.XtraEditors
Public Class frm_tbStokBirimCevrimi
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
    Public sModel As String
    Dim dr As DataRow
    Private Sub frm_tbStokBiriCevrimi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dataload_tbStokBirimCevrimi(sModel)
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
    Public Function sorgu_tbStokBirimCevrimi_kontrol(ByVal sBirimCinsi As String, ByVal sModel As String) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(*) AS Sayi FROM         tbStokBirimCevrimi WHERE     (nStokID IN (SELECT     nStokID FROM tbStok WHERE sModel = '" & sModel & "')) AND (sBirimCinsi = '" & sBirimCinsi & "')")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Public Sub Dataload_tbStokBirimCevrimi(ByVal sModel As String)
        Try
            DS.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT tbBirimCinsi.sBirimCinsi, tbBirimCinsi.sAciklama, tbBirimCinsi.nOndalik, ISNULL(tbStokBirimCevrimi.lOran, 0) AS lOran, tbStokBirimCevrimi.bTersOran FROM tbBirimCinsi LEFT OUTER JOIN tbStokBirimCevrimi ON tbBirimCinsi.sBirimCinsi = tbStokBirimCevrimi.sBirimCinsi AND tbStokBirimCevrimi.nStokID IN (SELECT nStokID FROM tbStok WHERE sModel = '" & sModel & "') ORDER BY tbBirimCinsi.sBirimCinsi ")
        cmd.Connection = conn
        Dim N As Integer = adapter.Fill(DS, "Table1")
        conn.Close()
        GridControl1.DataSource = DS.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub dataload_tbDovizCinsi()
        'ds_tbDovizCinsi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDovizCinsi,sAciklama FROM         tbDovizCinsi"))
        'sec_sDovizCinsi.Properties.DataSource = ds_tbDovizCinsi.Tables(0)
    End Sub
    Private Sub tbStokBirimCevrimi_kaydet_yeni(ByVal sBirimCinsi As String, ByVal lOran As Decimal, ByVal bTersOran As Integer, ByVal sModel As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokBirimCevrimi select nStokID, '" & sBirimCinsi & "', " & lOran & ", " & bTersOran & " from tbStok where sModel = '" & sModel & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokBirimCevrimi_kaydet_duzelt(ByVal sBirimCinsi As String, ByVal lOran As Decimal, ByVal bTersOran As Integer, ByVal sModel As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED update tbStokBirimCevrimi set lOran = " & lOran & ", bTersOran = " & bTersOran & " where sBirimCinsi = '" & sBirimCinsi & "' and nStokID in (select nStokID from tbStok where sModel = '" & sModel & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokBirimCevirimi_kaydet_sil(ByVal sModel As String, ByVal sBirimCinsi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED delete tbStokBirimCevrimi  where sBirimCinsi = '" & sBirimCinsi & "' and  nStokID in ( select nStokID from tbStok where sModel = '" & sModel & "' )")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tutar_hesapla()
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim bTersOran As Integer = 0
        If dr("lOran") <> 0 Then
            If Boolean.Parse(dr("bTersOran").ToString()) = True Then
                bTersOran = 1
            Else
                bTersOran = 0
            End If
            If sorgu_tbStokBirimCevrimi_kontrol(dr("sBirimCinsi"), sModel) = False Then
                tbStokBirimCevrimi_kaydet_duzelt(dr("sBirimCinsi"), dr("lOran"), bTersOran, sModel)
            Else
                tbStokBirimCevrimi_kaydet_yeni(dr("sBirimCinsi"), dr("lOran"), bTersOran, sModel)
            End If
        Else
            If sorgu_tbStokBirimCevrimi_kontrol(dr("sBirimCinsi"), sModel) = False Then
                tbStokBirimCevirimi_kaydet_sil(sModel, dr("sBirimCinsi"))
            End If
        End If
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            tutar_hesapla()
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
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Editor Ekranindan Cikmak Ýstediginize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
End Class