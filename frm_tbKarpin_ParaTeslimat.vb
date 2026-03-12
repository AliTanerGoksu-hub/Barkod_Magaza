Public Class frm_tbKarpin_ParaTeslimat 
    Public firmano
    Public DonemNo
    Public Connection
    Public nKarpinID As Integer = 0
    Public dteFisTarihi As DateTime
    Public sSatici As String
    Public sDepo As String
    Public belgetipi As String
    Dim dataset1 As DataSet
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub dataload()
        dataset1 = query_parateslimat(nKarpinID)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.Select()
        GridControl1.Focus()
    End Sub
    Public Function query_parateslimat(ByVal nKarpinID As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = Connection
        adapter.SelectCommand = cmd
        cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbDoviz.sOdemeSekli as sDovizCinsi,tbDoviz.sOdemeSekli as sDoviz, tbDoviz.nSabit, ISNULL(Para.nKayitID, 0) AS nKayitID, ISNULL(Para.nKarpinID, 0) AS nKarpinID, ISNULL(Para.dteFisTarihi, '01/01/1900') AS dteFisTarihi, ISNULL(Para.sSatici, '') AS sSatici, ISNULL(Para.sDepo, '') AS sDepo, Para.lKur, ISNULL(Para.lMiktar,0) as lMiktar, ISNULL(Para.lTutar,0) as lTutar FROM (SELECT '500' AS sOdemeSekli , 500 AS nSabit UNION ALL SELECT '200' AS sOdemeSekli , 200 AS nSabit UNION ALL SELECT '100' AS sOdemeSekli , 100 AS nSabit UNION ALL SELECT '50' AS sOdemeSekli , 50 AS nSabit UNION ALL SELECT '20' AS sOdemeSekli , 20 AS nSabit UNION ALL SELECT '10' AS sOdemeSekli , 10 AS nSabit UNION ALL SELECT '5' AS sOdemeSekli , 5 AS nSabit UNION ALL SELECT '1' AS sOdemeSekli , 1 AS nSabit UNION ALL SELECT '0.50' AS sOdemeSekli , .50 AS nSabit UNION ALL SELECT '0.25' AS sOdemeSekli , .25 AS nSabit UNION ALL SELECT '0.10' AS sOdemeSekli , .10 AS nSabit UNION ALL SELECT '0.05' AS sOdemeSekli , .05 AS nSabit UNION ALL SELECT sOdemeSekli , 1 AS nSabit FROM tbOdemeSekli WHERE sOdemeSekli <> 'N') tbDoviz LEFT OUTER JOIN tbKarpinParaTeslimat Para ON tbDoviz.sOdemeSekli = Para.sDoviz AND Para.nKarpinID = " & nKarpinID & ""
        cmd.Connection = conn
        conn.Open()
        Dim ds As New DataSet
        Dim N As Integer = adapter.Fill(ds, "KARPIN")
        conn.Close()
        Return ds
    End Function
    Private Sub tbKarpinParaTeslimat_kaydet_yeni(ByVal nKayitID As Int64, ByVal nKarpinID As Int64, ByVal dteFisTarihi As DateTime, ByVal sSatici As String, ByVal sDepo As String, ByVal sDoviz As String, ByVal sDovizCinsi As String, ByVal lKur As Decimal, ByVal lMiktar As Decimal, ByVal lTutar As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = Connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbKarpinParaTeslimat (nKarpinID, dteFisTarihi, sSatici, sDepo, sDoviz, sDovizCinsi, lKur, lMiktar, lTutar) VALUES     ( " & nKarpinID & ", '" & dteFisTarihi & "', '" & sSatici & "', '" & sDepo & "', '" & sDoviz & "', '" & sDovizCinsi & "', " & lKur & ", " & lMiktar & ", " & lTutar & ") ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbKarpinParaTeslimat_kaydet_duzelt(ByVal nKayitID As Int64, ByVal nKarpinID As Int64, ByVal dteFisTarihi As DateTime, ByVal sSatici As String, ByVal sDepo As String, ByVal sDoviz As String, ByVal sDovizCinsi As String, ByVal lKur As Decimal, ByVal lMiktar As Decimal, ByVal lTutar As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = Connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbKarpinParaTeslimat SET              dteFisTarihi = '" & dteFisTarihi & "', sSatici = '" & sSatici & "', sDepo = '" & sDepo & "', sDoviz = '" & sDoviz & "', sDovizCinsi = '" & sDovizCinsi & "', lKur = " & lKur & ", lMiktar = " & lMiktar & ", lTutar = " & lTutar & " Where nKayitID = " & nKayitID & " and  nKarpinID = " & nKarpinID & " ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbKarpinParaTeslimat_kaydet_sil(ByVal nKayitID As Int64, ByVal nKarpinID As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = Connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbKarpinParaTeslimat Where nKayitID = " & nKayitID & " and  nKarpinID = " & nKarpinID & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += "Tarih= " & dteFisTarihi & " EvrakTipi = [Karpin]  Islem = Para Teslimatý"
        kriter += "Plasiyer: " & sSatici & " Depo : " & sDepo
        printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Karpin Entegre", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
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
    Private Sub tutar_hesapla()
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        If dr("nKayitID") = 0 Then
            dr("lKur") = dr("nSabit")
        End If
        dr("lTutar") = dr("lMiktar") * dr("lKur")
        If dr("lMiktar") <> 0 Then
            If sorgu_sDovizCinsi_kontrol(dr("sDovizCinsi"), nKarpinID) = False Then
                tbKarpinParaTeslimat_kaydet_duzelt(dr("nKayitID"), nKarpinID, dteFisTarihi, sSatici, sDepo, dr("sDovizCinsi"), dr("sDovizCinsi"), dr("lKur"), dr("lMiktar"), dr("lTutar"))
            Else
                tbKarpinParaTeslimat_kaydet_yeni(dr("nKayitID"), nKarpinID, dteFisTarihi, sSatici, sDepo, dr("sDovizCinsi"), dr("sDovizCinsi"), dr("lKur"), dr("lMiktar"), dr("lTutar"))
            End If
        Else
            If sorgu_sDovizCinsi_kontrol(dr("sDovizCinsi"), nKarpinID) = False Then
                tbKarpinParaTeslimat_kaydet_sil(dr("nKayitID"), dr("nKarpinID"))
            End If
        End If
    End Sub
    Public Function sorgu_sDovizCinsi_kontrol(ByVal sDovizCinsi As String, ByVal nKarpinID As Int64) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = Connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(*) AS nKayit FROM         tbKarpinParaTeslimat WHERE     (sDovizCinsi = '" & sDovizCinsi & "') AND (nKarpinID = " & nKarpinID & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Private Sub kur_degistir()
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        If dr("sDovizCinsi") <> "TL" Then
            Dim kur = InputBox("Lütfen Kuru Giriniz...", "Kur", dr("lKur"))
            If kur <> Nothing Then
                dr("lKur") = kur
                dr("lTutar") = dr("lMiktar") * dr("lKur")
                tutar_hesapla()
                dr.EndEdit()
                GridView1.UpdateTotalSummary()
            End If
        End If
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            tutar_hesapla()
            Dim satir = GridView1.FocusedRowHandle
            dataload()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub frm_tbKarpin_ParaTeslimat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dataload()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        kur_degistir()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        gorunum_yazdir()
    End Sub
End Class