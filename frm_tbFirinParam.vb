Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_tbFirinParam
    Public sConnection
    Public nFirmano
    Public nDonemno
    Public sKullanici
    Public sFisTipi As String = "S"
    Dim ds_tbStokSinifi As DataSet
    Private Sub frm_tbFirinParam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dataload_tbStok()
        If sorgu_nFirinParam(sFisTipi) = 0 Then
            tbStokSinifi_kaydet_yeni(sFisTipi, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
        End If
        Dataload_tbStokSinifi(sFisTipi)
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub dataload_tbStok()
        sec_sSinifKodu.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokID,sKodu, sAciklama, sRenk, sBeden, nFiyatlandirma, sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbStok ")).Tables(0)
        'sec_Siniflar.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokID,sKodu, sAciklama, sRenk, sBeden, nFiyatlandirma, sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbStok ")).Tables(0)
        sec_Siniflar.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select 0 as nStokID,'' as sKodu,'Bos' as sAciklama UNION ALL SELECT nStokID,sKodu, sAciklama FROM tbStok ")).Tables(0)
    End Sub
    Private Sub Dataload_tbStokSinifi(ByVal sFisTipi As String)
        Dim kriter As String = ""
        kriter += " SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
        kriter += " SELECT TOP 1 1 AS nSatir, tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID1 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 2 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID2 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 3 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID3 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 4 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID4 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 5 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID5 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 6 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID6 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 7 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID7 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 8 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID8 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 9 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID9 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 10 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID10 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        ds_tbStokSinifi = sorgu(sorgu_query("" & kriter & ""))
        GridControl1.DataMember = Nothing
        GridControl1.DataSource = ds_tbStokSinifi.Tables(0)
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + nFirmano.ToString)
        query = Replace(query, "!D", "D000" + nDonemno.ToString)
        Return query
    End Function
    Private Function sorgu(ByVal query As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = sConnection
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
    Public Function sorgu_nFirinParam(ByVal sFisTipi As String) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = sConnection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(*) AS nKayit FROM         tbFirinParam WHERE     (sFisTipi = '" & sFisTipi & "') ")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub tbStokSinifi_kaydet_duzelt(ByVal nStokID As Integer, ByVal nSatir As Integer, ByVal sFisTipi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbFirinParam SET              nStokID" & nSatir & " =" & nStokID & " where sFisTipi ='" & sFisTipi & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokSinifi_kaydet_yeni(ByVal sFisTipi As String, ByVal nStokID1 As Integer, ByVal nStokID2 As Integer, ByVal nStokID3 As Integer, ByVal nStokID4 As Integer, ByVal nStokID5 As Integer, ByVal nStokID6 As Integer, ByVal nStokID7 As Integer, ByVal nStokID8 As Integer, ByVal nStokID9 As Integer, ByVal nStokID10 As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirinParam (sFisTipi, nStokID1, nStokID2, nStokID3, nStokID4, nStokID5, nStokID6, nStokID7, nStokID8, nStokID9, nStokID10) VALUES     ('" & sFisTipi & "', " & nStokID1 & ", " & nStokID2 & ", " & nStokID3 & ", " & nStokID4 & ", " & nStokID5 & ", " & nStokID6 & ", " & nStokID7 & ", " & nStokID8 & ", " & nStokID9 & ", " & nStokID10 & ") ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            Dim satir = GridView1.FocusedRowHandle
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            GridView1.PostEditor()
            dr.EndEdit()
            tbStokSinifi_kaydet_duzelt(dr("nStokID"), dr("nSatir"), sFisTipi)
            Dataload_tbStokSinifi(sFisTipi)
            GridView1.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Ekraný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.Close()
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
End Class