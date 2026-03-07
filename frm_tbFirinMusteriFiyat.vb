Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_tbFirinMusteriFiyat
    Public sConnection
    Public nFirmano
    Public nDonemno
    Public sKullanici
    Public sFisTipi As String = "S"
    Dim nStokID1 As Integer = 0
    Dim nStokID2 As Integer = 0
    Dim nStokID3 As Integer = 0
    Dim nStokID4 As Integer = 0
    Dim nStokID5 As Integer = 0
    Dim nStokID6 As Integer = 0
    Dim nStokID7 As Integer = 0
    Dim nStokID8 As Integer = 0
    Dim nStokID9 As Integer = 0
    Dim nStokID10 As Integer = 0
    Dim ds_tbStokSinifi As DataSet
    Private Sub frm_tbFirinMusteriFiyat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dataload_tbStokSinifi("S")
        Dim dr2 As DataRow = ds_tbStokSinifi.Tables(0).Rows(0)
        Try
            collFiyat1.Caption = Trim(dr2("sAciklama")) & " Fiyat"
            nStokID1 = sorgu_sayi(dr2("nStokID"), 0)
        Catch ex As Exception
            collFiyat1.Caption = "Miktar1" & " Fiyat"
            collFiyat1.Visible = False
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(1)
            collFiyat2.Caption = Trim(dr2("sAciklama")) & " Fiyat"
            nStokID2 = sorgu_sayi(dr2("nStokID"), 0)
        Catch ex As Exception
            collFiyat2.Caption = "Miktar2" & " Fiyat"
            collFiyat2.Visible = False
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(2)
            collFiyat3.Caption = Trim(dr2("sAciklama")) & " Fiyat"
            nStokID3 = sorgu_sayi(dr2("nStokID"), 0)
        Catch ex As Exception
            collFiyat3.Caption = "Miktar3" & " Fiyat"
            collFiyat3.Visible = False
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(3)
            collFiyat4.Caption = Trim(dr2("sAciklama")) & " Fiyat"
            nStokID4 = sorgu_sayi(dr2("nStokID"), 0)
        Catch ex As Exception
            collFiyat4.Caption = "Miktar4" & " Fiyat"
            collFiyat4.Visible = False
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(4)
            collFiyat5.Caption = Trim(dr2("sAciklama")) & " Fiyat"
            nStokID5 = sorgu_sayi(dr2("nStokID"), 0)
        Catch ex As Exception
            collFiyat5.Caption = "Miktar5" & " Fiyat"
            collFiyat5.Visible = False
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(5)
            collFiyat6.Caption = Trim(dr2("sAciklama")) & " Fiyat"
            nStokID6 = sorgu_sayi(dr2("nStokID"), 0)
        Catch ex As Exception
            collFiyat6.Caption = "Miktar6" & " Fiyat"
            collFiyat6.Visible = False
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(6)
            collFiyat7.Caption = Trim(dr2("sAciklama")) & " Fiyat"
            nStokID7 = sorgu_sayi(dr2("nStokID"), 0)
        Catch ex As Exception
            collFiyat7.Caption = "Miktar7" & " Fiyat"
            collFiyat7.Visible = False
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(7)
            collFiyat8.Caption = Trim(dr2("sAciklama")) & " Fiyat"
            nStokID8 = sorgu_sayi(dr2("nStokID"), 0)
        Catch ex As Exception
            collFiyat8.Caption = "Miktar8" & " Fiyat"
            collFiyat8.Visible = False
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(8)
            collFiyat9.Caption = Trim(dr2("sAciklama")) & " Fiyat"
            nStokID9 = sorgu_sayi(dr2("nStokID"), 0)
        Catch ex As Exception
            collFiyat9.Caption = "Miktar9" & " Fiyat"
            collFiyat9.Visible = False
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(9)
            collFiyat10.Caption = Trim(dr2("sAciklama")) & " Fiyat"
            nStokID10 = sorgu_sayi(dr2("nStokID"), 0)
        Catch ex As Exception
            collFiyat10.Caption = "Miktar10" & " Fiyat"
            collFiyat10.Visible = False
        End Try
        dr2 = Nothing
        dataload_tbStok()
        dataload_tbFirinMusteriFiyat()
    End Sub
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub dataload_tbStok()
        sec_sSinifKodu.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokID,sKodu, sAciklama, sRenk, sBeden, nFiyatlandirma, sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbStok ")).Tables(0)
        'sec_Siniflar.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokID,sKodu, sAciklama, sRenk, sBeden, nFiyatlandirma, sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbStok ")).Tables(0)
        sec_Siniflar.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select 0 as nStokID,'' as sKodu,'Bos' as sAciklama UNION ALL SELECT nStokID,sKodu, sAciklama FROM tbStok ")).Tables(0)
    End Sub
    Private Sub dataload_tbFirinMusteriFiyat()
        DataSet1 = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID AS FirmaID, tbFirma.sKodu AS sKodu, tbFirma.sAciklama AS sAciklama, tbFirinMusteriFiyat.* FROM tbFirinMusteriFiyat RIGHT OUTER JOIN tbFirma ON tbFirinMusteriFiyat.nFirmaID = tbFirma.nFirmaID "))
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
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
    Public Function sorgu_nFirinParam(ByVal nFirmaID As String) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = sConnection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(*) AS nKayit FROM         tbFirinMusteriFiyat WHERE     (nFirmaID = '" & nFirmaID & "') ")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub tbFirinMusteriFiyat_kaydet_duzelt(ByVal nFirmaID As Integer, ByVal nStokID1 As Integer, ByVal lFiyat1 As Decimal, ByVal nStokID2 As Integer, ByVal lFiyat2 As Decimal, ByVal nStokID3 As Integer, ByVal lFiyat3 As Decimal, ByVal nStokID4 As Integer, ByVal lFiyat4 As Decimal, ByVal nStokID5 As Integer, ByVal lFiyat5 As Decimal, ByVal nStokID6 As Integer, ByVal lFiyat6 As Decimal, ByVal nStokID7 As Integer, ByVal lFiyat7 As Decimal, ByVal nStokID8 As Integer, ByVal lFiyat8 As Decimal, ByVal nStokID9 As Integer, ByVal lFiyat9 As Decimal, ByVal nStokID10 As Integer, ByVal lFiyat10 As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbFirinMusteriFiyat SET              nStokID1 = " & nStokID1 & ", lFiyat1 = " & lFiyat1 & ", nStokID2 = " & nStokID2 & ", lFiyat2 = " & lFiyat2 & ", nStokID3 = " & nStokID3 & ", lFiyat3 = " & lFiyat3 & ", nStokID4 = " & nStokID4 & ", lFiyat4 = " & lFiyat4 & ", nStokID5 = " & nStokID5 & ", lFiyat5 = " & lFiyat5 & ", nStokID6 = " & nStokID6 & ", lFiyat6 = " & lFiyat6 & ", nStokID7 = " & nStokID7 & ", lFiyat7 = " & lFiyat7 & ", nStokID8 = " & nStokID8 & ", lFiyat8 = " & lFiyat8 & ", nStokID9 = " & nStokID9 & ", lFiyat9 = " & lFiyat9 & ", nStokID10 = " & nStokID10 & ", lFiyat10 = " & lFiyat10 & " Where nFirmaID = " & nFirmaID & " ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbFirinMusteriFiyat_kaydet_sil(ByVal nFirmaID As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbFirinMusteriFiyat  Where nFirmaID = " & nFirmaID & " ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbFirinMusteriFiyat_kaydet_yeni(ByVal nFirmaID As Integer, ByVal nStokID1 As Integer, ByVal lFiyat1 As Decimal, ByVal nStokID2 As Integer, ByVal lFiyat2 As Decimal, ByVal nStokID3 As Integer, ByVal lFiyat3 As Decimal, ByVal nStokID4 As Integer, ByVal lFiyat4 As Decimal, ByVal nStokID5 As Integer, ByVal lFiyat5 As Decimal, ByVal nStokID6 As Integer, ByVal lFiyat6 As Decimal, ByVal nStokID7 As Integer, ByVal lFiyat7 As Decimal, ByVal nStokID8 As Integer, ByVal lFiyat8 As Decimal, ByVal nStokID9 As Integer, ByVal lFiyat9 As Decimal, ByVal nStokID10 As Integer, ByVal lFiyat10 As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirinMusteriFiyat (nFirmaID, nStokID1, lFiyat1, nStokID2, lFiyat2, nStokID3, lFiyat3, nStokID4, lFiyat4, nStokID5, lFiyat5, nStokID6, lFiyat6, nStokID7, lFiyat7, nStokID8, lFiyat8, nStokID9, lFiyat9, nStokID10, lFiyat10) VALUES     (" & nFirmaID & ", " & nStokID1 & ", " & lFiyat1 & ", " & nStokID2 & ", " & lFiyat2 & ", " & nStokID3 & ", " & lFiyat3 & ", " & nStokID4 & ", " & lFiyat4 & ", " & nStokID5 & ", " & lFiyat5 & ", " & nStokID6 & ", " & lFiyat6 & ", " & nStokID7 & ", " & lFiyat7 & ", " & nStokID8 & ", " & lFiyat8 & ", " & nStokID9 & ", " & lFiyat9 & ", " & nStokID10 & ", " & lFiyat10 & ") ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tutar_hesapla()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim lTutar1 As Decimal = 0
            Dim lTutar2 As Decimal = 0
            Dim lTutar3 As Decimal = 0
            Dim lTutar4 As Decimal = 0
            Dim lTutar5 As Decimal = 0
            Dim lTutar6 As Decimal = 0
            Dim lTutar7 As Decimal = 0
            Dim lTutar8 As Decimal = 0
            Dim lTutar9 As Decimal = 0
            Dim lTutar10 As Decimal = 0
            Dim lTutar As Decimal = 0
            dr("lFiyat1") = sorgu_sayi(dr("lFiyat1"), 0)
            dr("lFiyat2") = sorgu_sayi(dr("lFiyat2"), 0)
            dr("lFiyat3") = sorgu_sayi(dr("lFiyat3"), 0)
            dr("lFiyat4") = sorgu_sayi(dr("lFiyat4"), 0)
            dr("lFiyat5") = sorgu_sayi(dr("lFiyat5"), 0)
            dr("lFiyat6") = sorgu_sayi(dr("lFiyat6"), 0)
            dr("lFiyat7") = sorgu_sayi(dr("lFiyat7"), 0)
            dr("lFiyat8") = sorgu_sayi(dr("lFiyat8"), 0)
            dr("lFiyat9") = sorgu_sayi(dr("lFiyat9"), 0)
            dr("lFiyat10") = sorgu_sayi(dr("lFiyat10"), 0)
            lTutar1 = sorgu_sayi(dr("lFiyat1"), 0)
            lTutar2 = sorgu_sayi(dr("lFiyat2"), 0)
            lTutar3 = sorgu_sayi(dr("lFiyat3"), 0)
            lTutar4 = sorgu_sayi(dr("lFiyat4"), 0)
            lTutar5 = sorgu_sayi(dr("lFiyat5"), 0)
            lTutar6 = sorgu_sayi(dr("lFiyat6"), 0)
            lTutar7 = sorgu_sayi(dr("lFiyat7"), 0)
            lTutar8 = sorgu_sayi(dr("lFiyat8"), 0)
            lTutar9 = sorgu_sayi(dr("lFiyat9"), 0)
            lTutar10 = sorgu_sayi(dr("lFiyat10"), 0)
            lTutar = lTutar1 + lTutar2 + lTutar3 + lTutar4 + lTutar5 + lTutar6 + lTutar7 + lTutar8 + lTutar9 + lTutar10
            If lTutar = 0 Then
                tbFirinMusteriFiyat_kaydet_sil(dr("FirmaID"))
            Else
                If sorgu_nFirinParam(dr("FirmaID")) = 0 Then
                    tbFirinMusteriFiyat_kaydet_yeni(dr("FirmaID"), nStokID1, dr("lFiyat1"), nStokID2, dr("lFiyat2"), nStokID3, dr("lFiyat3"), nStokID4, dr("lFiyat4"), nStokID5, dr("lFiyat5"), nStokID6, dr("lFiyat6"), nStokID7, dr("lFiyat7"), nStokID8, dr("lFiyat8"), nStokID9, dr("lFiyat9"), nStokID10, dr("lFiyat10"))
                Else
                    tbFirinMusteriFiyat_kaydet_duzelt(dr("FirmaID"), nStokID1, dr("lFiyat1"), nStokID2, dr("lFiyat2"), nStokID3, dr("lFiyat3"), nStokID4, dr("lFiyat4"), nStokID5, dr("lFiyat5"), nStokID6, dr("lFiyat6"), nStokID7, dr("lFiyat7"), nStokID8, dr("lFiyat8"), nStokID9, dr("lFiyat9"), nStokID10, dr("lFiyat10"))
                End If
            End If
            dr.EndEdit()
        End If
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            Dim satir = GridView1.FocusedRowHandle
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            GridView1.PostEditor()
            tutar_hesapla()
            dr.EndEdit()
            GridView1.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Close()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If DevExpress.XtraEditors.XtraMessageBox.Show(Sorgu_sDil("Ekraný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Close()
            End If
        End If
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        Printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
End Class