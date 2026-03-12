Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports System.IO
Imports DevExpress.XtraExport
Imports DevExpress.XtraGrid.Export
Imports DevExpress.XtraGrid
Imports System.Char
Imports business_smart.brkdutil
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen
Public Class AppYazarKasa
    Public Shared connection, firmano, donemno, userno, sKasiyerRumuzu As String
    Public Shared kriter, fiyat, secstatus
    Public Shared nKayitSinir As Integer = 0
    Public dataset1 As New DataSet
    'inter
    Public ds_Inter As DataSet
    Public GridControl1 As New DevExpress.XtraGrid.GridControl
    Public GridView1 As New DevExpress.XtraGrid.Views.Grid.GridView
    'diger
    Public sayi
    'Dim timer1 As New Timer
    Dim stokkodu, malincinsi, barkod, kod1, kod2, kod3, kod4, kod5, stokkriter, secsirala, secfiyat, status, tarih1, tarih2
    Dim count As String = ""
    Dim listbox1 As New ListBox
    Private fprogress As frmProgress = Nothing
    Public Function sorgu(ByVal sFiyatTipi As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*, tbStokBarkodu.sBarkod, tbSSinif1.sAciklama AS Sinif1, tbSSinif2.sAciklama AS Sinif2, tbSSinif3.sAciklama AS Sinif3, tbSSinif4.sAciklama AS Sinif4, tbSSinif5.sAciklama AS Sinif5, tbSSinif6.sAciklama AS Sinif6, tbSSinif7.sAciklama AS Sinif7, tbSSinif8.sAciklama AS Sinif8, tbSSinif9.sAciklama AS Sinif9, tbSSinif10.sAciklama AS Sinif10, tbSSinif11.sAciklama AS Sinif11, tbSSinif12.sAciklama AS Sinif12, tbSSinif13.sAciklama AS Sinif13, tbSSinif14.sAciklama AS Sinif14, tbSSinif15.sAciklama AS Sinif15, ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10, '') AS ISTIHBARAT,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS FIYAT2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS FIYAT3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS FIYAT4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "'),0) AS lFiyat,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani,(Select ISNULL(sRenkAdi,'') from tbRenk Where sRenk = tbStok.sRenk) as sRenkAdi,CAST(1 as Money) as lMiktar  FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " ")
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TOPLUSTOK")
        conn.Close()
        Return DS
    End Function
    Private Function sorgu_inter(ByVal sFiyatTipi1 As String, ByVal sFiyatTipi2 As String, ByVal sFiyatTipi3 As String, ByVal sFiyatTipi As String, Optional ByVal bMevcut As Boolean = False) As DataSet
        Dim sMevcutQuery As String = ""
        If nKayitSinir > 0 Then
            count = " TOP " & nKayitSinir & " "
        Else
            count = ""
        End If
        If bMevcut = True Then
            sMevcutQuery = ",ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "') , 0) AS ALISFIYATI,(SELECT     ISNULL(SUM(lGirisMiktar1 - lCikisMiktar1), 0) FROM          tbStokFisiDetayi WHERE      nStokID = tbStok.nStokID) AS lMevcut"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " * FROM (SELECT nStokID , sKodu , sAciklama , sKisaAdi , sBirimCinsi1 , sKdvTipi , (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod ,(Select ISNULL(sRenkAdi,'') from tbRenk Where sRenk = tbStok.sRenk) as sRenkAdi,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') , 0) AS FIYAT1 , ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi2 & "') , 0) AS FIYAT2 , ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') , 0) AS FIYAT3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "') , 0) AS lFiyat " & sMevcutQuery & " FROM tbStok Where tbStok.nStokTipi <>5 ) DERIVEDTBL WHERE (sBarkod <> '') ORDER BY sKodu ")
        'count = " TOP 10 "
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " * FROM (SELECT tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sKisaAdi, tbStok.sBirimCinsi1, tbStok.sKdvTipi, tbStok.sAlisKdvTipi,tbStokBarkodu.sBarkod, tbRenk.sRenkAdi, tbStok.sBeden, tbKdv.nKdvOrani, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "'), 0) AS lFiyat, tbStokSinifi.sSinifKodu5,tbStokSinifi.sSinifKodu6,tbStokSinifi.sSinifKodu7 FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk INNER JOIN tbKdv ON tbStok.sKdvTipi = tbKdv.sKdvTipi INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID WHERE (tbStok.nStokTipi < 5) ) DERIVEDTBL WHERE (sBarkod <> '') ORDER BY sKodu ")
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TOPLUSTOK")
        conn.Close()
        Return DS
    End Function
    Private Function sorgu_Degisen(ByVal sFiyatTipi1 As String, ByVal sFiyatTipi2 As String, ByVal sFiyatTipi3 As String, ByVal sFiyatTipi As String, Optional ByVal bMevcut As Boolean = False) As DataSet
        Dim sMevcutQuery As String = ""
        If nKayitSinir > 0 Then
            count = " TOP " & nKayitSinir & " "
        Else
            count = ""
        End If
        If bMevcut = True Then
            sMevcutQuery = ",ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "') , 0) AS ALISFIYATI,(SELECT     ISNULL(SUM(lGirisMiktar1 - lCikisMiktar1), 0) FROM          tbStokFisiDetayi WHERE      nStokID = tbStok.nStokID) AS lMevcut"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " * FROM (SELECT nStokID , sKodu , sAciklama , sKisaAdi , sBirimCinsi1 , sKdvTipi , (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod ,(Select ISNULL(sRenkAdi,'') from tbRenk Where sRenk = tbStok.sRenk) as sRenkAdi,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') , 0) AS FIYAT1 , ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi2 & "') , 0) AS FIYAT2 , ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') , 0) AS FIYAT3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "') , 0) AS lFiyat " & sMevcutQuery & " FROM tbStok Where tbStok.nStokTipi <>5 ) DERIVEDTBL WHERE (sBarkod <> '') ORDER BY sKodu ")
        'count = " TOP 10 "
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " * FROM (SELECT tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sKisaAdi, tbStok.sBirimCinsi1, tbStok.sKdvTipi, tbStok.sAlisKdvTipi,tbStokBarkodu.sBarkod, tbRenk.sRenkAdi, tbStok.sBeden, tbKdv.nKdvOrani, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "'), 0) AS lFiyat, tbStokSinifi.sSinifKodu5,tbStokSinifi.sSinifKodu6,tbStokSinifi.sSinifKodu7 FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID INNER JOIN tbStokFiyati ON tbStok.nStokID = tbStokFiyati.nStokID INNER JOIN  tbRenk ON tbStok.sRenk = tbRenk.sRenk INNER JOIN tbKdv ON tbStok.sKdvTipi = tbKdv.sKdvTipi INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID WHERE (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and tbStok.nStokTipi < 5 ) DERIVEDTBL WHERE (sBarkod <> '') ORDER BY sKodu ")
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TOPLUSTOK")
        conn.Close()
        Return DS
    End Function
    Private Function sorgu_inter_nStokIDSirali(ByVal sFiyatTipi1 As String, ByVal sFiyatTipi2 As String, ByVal sFiyatTipi3 As String, ByVal sFiyatTipi As String, Optional ByVal bMevcut As Boolean = False) As DataSet
        Dim sMevcutQuery As String = ""
        If nKayitSinir > 0 Then
            count = " TOP " & nKayitSinir & " "
        Else
            count = ""
        End If
        If bMevcut = True Then
            sMevcutQuery = ",ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "') , 0) AS ALISFIYATI,(SELECT     ISNULL(SUM(lGirisMiktar1 - lCikisMiktar1), 0) FROM          tbStokFisiDetayi WHERE      nStokID = tbStok.nStokID) AS lMevcut"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " * FROM (SELECT nStokID , sKodu , sAciklama , sKisaAdi , sBirimCinsi1 , sKdvTipi , (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod ,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') , 0) AS FIYAT1 , ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi2 & "') , 0) AS FIYAT2 , ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') , 0) AS FIYAT3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "') , 0) AS lFiyat " & sMevcutQuery & " FROM tbStok Where tbStok.nStokTipi <>5 ) DERIVEDTBL WHERE (sBarkod <> '') ORDER BY nStokID DESC")
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TOPLUSTOK")
        conn.Close()
        Return DS
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub kriterkontrol()
        kriter = "Where tbStok.sKodu <>'' and tbStok.nStokTipi < 5 "
        If stokkodu <> "" Then
            kriter += " AND (tbStok.sKodu LIKE '" & stokkodu & "%')"
        End If
        If malincinsi <> "" Then
            kriter += " AND (tbStok.sAciklama LIKE '" & malincinsi & "%')"
        End If
        If barkod <> "" Then
            kriter += " AND (tbStokBarkodu.sBarkod LIKE '" & barkod & "%')"
        End If
        If kod1 <> "" Then
            kriter += " AND (tbSSinif1.sAciklama LIKE '" & kod1 & "%')"
        End If
        If kod2 <> "" Then
            kriter += " AND (StbSSinif2.sAciklama LIKE '" & kod2 & "%')"
        End If
        If kod3 <> "" Then
            kriter += " AND (tbSSinif3.sAciklama LIKE '" & kod3 & "%')"
        End If
        If kod4 <> "" Then
            kriter += " AND (tbSSinif4.sAciklama LIKE '" & kod4 & "%')"
        End If
        If kod5 <> "" Then
            kriter += " AND (tbSSinif5.sAciklama LIKE '" & kod5 & "%')"
        End If
        'If aktif <> "" Then
        '    kriter += " AND (STK.STATUS " & sorgu_kriter_string(aktif, qaktif) & ")"
        'End If
        If secfiyat = "1. Satýþ Fiyatý" Then
            fiyat = 1
        ElseIf secfiyat = "2. Satýþ Fiyatý" Then
            fiyat = 2
        ElseIf secfiyat = "3. Satýþ Fiyatý" Then
            fiyat = 3
        End If
        If stokkriter = "1.Fiyatý Deðiþenler" Then
            'tarih2 = DateAdd(DateInterval.Day, 1, tarih2)
            kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='" & sFiyat1 & "')  ) "
            secstatus = 1
        ElseIf stokkriter = "2.Fiyatý Deðiþenler" Then
            'tarih2 = DateAdd(DateInterval.Day, 1, tarih2)
            kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='" & sFiyat2 & "')  ) "
            secstatus = 1
        ElseIf stokkriter = "3.Fiyatý Deðiþenler" Then
            'tarih2 = DateAdd(DateInterval.Day, 1, tarih2)
            kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='" & sFiyat3 & "')  ) "
            secstatus = 1
        ElseIf stokkriter = "4.Fiyatý Deðiþenler" Then
            'tarih2 = DateAdd(DateInterval.Day, 1, tarih2)
            kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='" & sFiyat4 & "')  ) "
            secstatus = 1
        ElseIf stokkriter = "Satýþ Fiyatý Deðiþenler" Then
            'tarih2 = DateAdd(DateInterval.Day, 1, tarih2)
            
            kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi NOT IN ('" & sFiyatA & "','" & sFiyatM & "'))  ) "
            secstatus = 1
        ElseIf stokkriter = "Alýþ Fiyatý Deðiþenler" Then
            tarih2 = DateAdd(DateInterval.Day, 1, tarih2)
            kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='A') ) "
            secstatus = 1
        ElseIf stokkriter = "Yeni Açýlan Stoklar" Then
            tarih2 = DateAdd(DateInterval.Day, 1, tarih2)
            kriter += " AND tbStok.dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih2.ToString, 10) + " 23:59:59" & "' "
            secstatus = 1
        ElseIf stokkriter = "Tüm Stoklar" Then
            kriter += ""
            secstatus = 1
        ElseIf stokkriter = "Tartýlý Stoklar" Then
            kriter += " AND (len(tbStokBarkodu.sBarkod) = 5)"
            secstatus = 1
        ElseIf stokkriter = "Plu Stoklar" Then
            kriter += " AND (len(tbStokBarkodu.sBarkod) = 6) and tbStokBarkodu.sBarkod like '000%'"
            secstatus = 1
        ElseIf stokkriter = "[Boþ Liste]" Then
            kriter += " AND (tbStok.nStokID=0)"
            secstatus = 1
        End If
        If nKayitSinir > 0 Then
            count = " TOP " & nKayitSinir & " "
        Else
            count = ""
        End If
        'DENEME YAP
        'kriter += " AND (birim.SATISFIYATI1 =0)"
        If secsirala = "STOKKODU" Then
            kriter += " ORDER BY tbStok.sKodu"
        ElseIf secsirala = "MALINCINSI" Then
            kriter += " ORDER BY tbStok.sAciklama"
        ElseIf secsirala = "BARKOD" Then
            kriter += " ORDER BY tbStokBarkodu.sBarkod"
        ElseIf secsirala = "OZELKOD" Then
            kriter += " ORDER BY tbSSinif1.sSinifkodu"
        End If
    End Sub
    Private Function intercariler() As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        If nKayitSinir > 0 Then
            count = " TOP " & nKayitSinir & " "
        Else
            count = ""
        End If
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nFirmaID, sKodu, sAciklama, sAdres1, sVergiDairesi, sVergiNo, nOzelIskontosu FROM tbFirma WHERE sKodu <>''  ORDER BY nFirmaID")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " nMusteriID AS nFirmaID, lKodu AS sKodu, sAdi AS sAciklama, (SELECT bakiye FROM vwMusteriBakiyesi WHERE nMusteriID = tbMusteri.nMusteriID) AS sAdres1, sVergiDairesi, sVergiNo, nIskontoPesin AS nOzelIskontosu,ISNULL((SELECT     TOP 1 nKartNo  FROM         tbMusteriKarti WHERE     (nMusteriID = tbMusteri.nMusteriID) ORDER BY dteSonKullanmaTarihi),'') nKartNo FROM tbMusteri ORDER BY lKodu")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " * FROM (SELECT nFirmaID , sKodu = CASE WHEN CAST(nKartNo AS NVARCHAR(20)) = '' THEN CAST(lKodu AS NVARCHAR(20)) ELSE CAST(nKartNo AS NVARCHAR(20)) END , sAciklama , sAdres1 , sEvTelefonu , sAciklama1 , sAdres , dteKayitTarihi , sVergiDairesi , sVergiNo , nOzelIskontosu , sEhliyetNo FROM (SELECT nMusteriID AS nFirmaID , lKodu , sAdi + ' ' + sSoyadi AS sAciklama , (SELECT bakiye FROM vwMusteriBakiyesi WHERE nMusteriID = tbMusteri.nMusteriID) AS sAdres1 , sEvAdresi1 + ' ' + sEvAdresi2 + ' ' + sEvSemt + ' ' + sEvIl AS sAdres , sEvTelefonu , sAciklama1 , dteKayitTarihi , sVergiDairesi , sVergiNo , nIskontoPesin AS nOzelIskontosu , sEhliyetNo , ISNULL((SELECT TOP 1 nKartNo FROM tbMusteriKarti WHERE (nMusteriID = tbMusteri.nMusteriID) ORDER BY dteSonKullanmaTarihi) , '') AS nKartNo FROM tbMusteri WHERE nMusteriID > 0 AND nMusteriID NOT IN (SELECT tbMusteriSinifi.nMusteriID FROM tbMSinif1 INNER JOIN tbMusteriSinifi ON tbMSinif1.sSinifKodu = tbMusteriSinifi.sSinifKodu1 WHERE (tbMSinif1.bSatisYapilamaz = 1))) tbMusteri) Musteri ORDER BY CAST(sKodu AS FLOAT)")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " * FROM (SELECT nFirmaID , sKodu = CASE WHEN CAST(nKartNo AS NVARCHAR(20)) = '' THEN CAST(lKodu AS NVARCHAR(20)) ELSE CAST(nKartNo AS NVARCHAR(20)) END , sAciklama , sAdres1 , sEvTelefonu , sAciklama1 , sAdres , dteKayitTarihi , sVergiDairesi , sVergiNo , nOzelIskontosu , sEhliyetNo FROM (SELECT nMusteriID AS nFirmaID , lKodu , sAdi + ' ' + sSoyadi AS sAciklama , (SELECT bakiye FROM vwMusteriBakiyesi WHERE nMusteriID = tbMusteri.nMusteriID) AS sAdres1 , sEvAdresi1 + ' ' + sEvAdresi2 + ' ' + sEvSemt + ' ' + sEvIl AS sAdres , sEvTelefonu , sAciklama1 , dteKayitTarihi , sVergiDairesi , sVergiNo , nIskontoPesin AS nOzelIskontosu , sEhliyetNo , ISNULL((SELECT TOP 1 nKartNo FROM tbMusteriKarti WHERE (nMusteriID = tbMusteri.nMusteriID) ORDER BY dteSonKullanmaTarihi) , '') AS nKartNo FROM tbMusteri WHERE nMusteriID > 0 AND nMusteriID NOT IN (SELECT tbMusteriSinifi.nMusteriID FROM tbMSinif1 INNER JOIN tbMusteriSinifi ON tbMSinif1.sSinifKodu = tbMusteriSinifi.sSinifKodu1 WHERE (tbMSinif1.bSatisYapilamaz = 1))) tbMusteri) Musteri ORDER BY sKodu")
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "POS")
        conn.Close()
        Return DS
    End Function
    Private Function intercariler2() As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        If nKayitSinir > 0 Then
            count = " TOP " & nKayitSinir & " "
        Else
            count = ""
        End If
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nFirmaID, sKodu, sAciklama, sAdres1, sVergiDairesi, sVergiNo, nOzelIskontosu,sFiyatTipi as sEhliyetNo FROM tbFirma WHERE sKodu <>''  ORDER BY nFirmaID")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " nMusteriID AS nFirmaID, lKodu AS sKodu, sAdi AS sAciklama, sEvAdresi1 as sAdres1,sEvAdresi2 as sAdres2, sVergiDairesi, sVergiNo, nIskontoPesin AS nOzelIskontosu,sEhliyetNo FROM tbMusteri ORDER BY lKodu")
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "POS")
        conn.Close()
        Return DS
    End Function
    Private Function ds_BusinessMobile_cariler() As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        If nKayitSinir > 0 Then
            count = " TOP " & nKayitSinir & " "
        Else
            count = ""
        End If
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT    " & count & "  sKodu, sAciklama, (SELECT     SUM(lBorcTutar - lAlacakTutar) FROM          tbFirmaHareketi WHERE      nFirmaID = tbFirma.nFirmaID) AS lBakiye FROM         tbFirma Order by sKodu")
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "POS")
        conn.Close()
        Return DS
    End Function
    Private ReadOnly Property Progress() As frmProgress
        Get
            If Object.Equals(fprogress, Nothing) Then
                fprogress = New frmProgress()
            End If
            Return fprogress
        End Get
    End Property
    Private Sub dosyaolusturINTER(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String, ByVal sDepo As String)
        Dim dr As DataRow
        Dim sKodu As String = ""
        Dim plu As String
        Dim malincinsi As String
        Dim departman As String = ""
        Dim satir As String = ""
        Dim satirlar As New Windows.Forms.ComboBox
        Dim fiyat
        Dim satisfiyati
        Dim stokno
        Dim birim
        Dim status
        Dim sAyrac As String = ":"
        If sPath = "\\tsclient\C" Or sPath = "\\tsclient\D" Or sPath = "\\tsclient\E" Or sPath = "\\tsclient\F" Then
            sAyrac = ""
        End If
        Dim sDosyaUrun As String = "" & sPath & sAyrac & sFile & "\posgenel\URUN.DAT"
        Dim sDosyaBarkod As String = "" & sPath & sAyrac & sFile & "\posgenel\BARKOD.IDX"
        Dim sDosyaPluno As String = "" & sPath & sAyrac & sFile & "\posgenel\PLUNO.IDX"
        Dim z As String = "C:" & sFile & "\posgenel\" & sDepo & "\URUN.DAT"
        Dim barkodidx As String = "C:" & sFile & "\posgenel\" & sDepo & "\BARKOD.IDX"
        Dim pluidx As String = "C:" & sFile & "\posgenel\" & sDepo & "\PLUNO.IDX"
        Dim pluReyon As String = "C:" & sFile & "\posgenel\" & sDepo & "\REYON.DAT"
        Dim pluGrup As String = "C:" & sFile & "\posgenel\" & sDepo & "\GRUP.DAT"
        Dim pluOzelKod As String = "C:" & sFile & "\posgenel\" & sDepo & "\OZELKOD.DAT"
        Dim pluToptan As String = "C:" & sFile & "\posgenel\" & sDepo & "\TOPTAN.DAT"
        Dim sDosyaPluReyon As String = "" & sPath & sAyrac & sFile & "\posgenel\REYON.DAT"
        Dim sDosyaPluGrup As String = "" & sPath & sAyrac & sFile & "\posgenel\GRUP.DAT"
        Dim sDosyapluOzelKod As String = "" & sPath & sAyrac & sFile & "\posgenel\OZELKOD.DAT"
        Dim sDosyapluToptan As String = "" & sPath & sAyrac & sFile & "\posgenel\TOPTAN.DAT"
        Dim DOSYA As New FileInfo(z)
        If DOSYA.Exists Then
            DOSYA.Delete()
        End If
        Dim dosya1 As New FileInfo(barkodidx)
        If dosya1.Exists Then
            dosya1.Delete()
        End If
        Dim dosya2 As New FileInfo(pluidx)
        If dosya2.Exists Then
            dosya2.Delete()
        End If
        Dim dosya3 As New FileInfo(pluToptan)
        If dosya3.Exists Then
            dosya3.Delete()
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        Dim barkodsw As StreamWriter = File.AppendText(barkodidx)
        Dim plusw As StreamWriter = File.AppendText(pluidx)
        Dim toptansw As StreamWriter = File.AppendText(pluToptan)
        sayi = 0
        Dim CON As New OleDb.OleDbConnection
        CON.ConnectionString = connection
        Dim CMD As New OleDb.OleDbCommand
        CMD.Connection = CON
        CMD.CommandTimeout = Nothing
        CON.Open()
        ds_Inter.Tables(0).Clear()
        'Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Ýnter Pos Stok Dosyasý Oluþturuluyor...")
        SplashScreenManager.ShowForm(GetType(WaitForm1), False, True)
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 And dr("FIYAT1") < 1000000000 Then
                If IsNumeric(dr("sBarkod")) Then
                    Dim barkod = Trim(dr("sBarkod").ToString)
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If dr("sBirimCinsi1") = "P" Then
                        dr("FIYAT1") = 0
                    End If
                    If sFiyatTipi <> 1 Then
                        If dr("lFiyat") = 0 Then
                            satisfiyati = dr("FIYAT1")
                        Else
                            satisfiyati = dr("lFiyat")
                        End If
                    Else
                        satisfiyati = dr("FIYAT1")
                    End If
                    If barkoduzunluk >= 5 Then
                        If Len(barkod) = 13 Then
                            plu = barkod
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "H"
                        ElseIf Len(barkod) = 8 Then
                            plu = (barkod)
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "H"
                        ElseIf Len(Trim(barkod)) = 5 Then
                            If Trim(dr("sBirimCinsi1")) = "ADT" Then
                                plu = "28"
                            Else
                                plu = sGramaj
                            End If
                            'plu = sGramaj
                            plu += (barkod)
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "E"
                        ElseIf Len(barkod) > 14 Then
                            plu = (barkod)
                            plu = Microsoft.VisualBasic.Left(plu, 13)
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "H"
                        ElseIf Len(barkod) = 6 Then
                            barkod = CType(barkod, Integer)
                            plu = (barkod)
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "H"
                        Else
                            'buraya dikkat et
                            plu = barkod
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "H"
                        End If
                        'malincinsi oluþtur
                        malincinsi = " " + UCase(Trim(dr("sAciklama").ToString))
                        If Trim(dr("sRenkAdi").ToString) <> "" And Trim(dr("sBeden")) = "" Then
                            malincinsi = " " + UCase(Microsoft.VisualBasic.Left(Trim(dr("sAciklama").ToString), 13)) + "\" + Microsoft.VisualBasic.Left(Trim(dr("sRenkAdi")), 5)
                        ElseIf Trim(dr("sRenkAdi").ToString) <> "" And Trim(dr("sBeden")) <> "" Then
                            malincinsi = " " + UCase(Microsoft.VisualBasic.Left(Trim(dr("sAciklama").ToString), 10)) + "\" + Microsoft.VisualBasic.Left(Trim(dr("sRenkAdi")), 4) + "\" + Microsoft.VisualBasic.Left(Trim(dr("sBeden")), 3)
                        End If
                        'birim adý oluþtur
                        birim = UCase(dr("sBirimCinsi1"))
                        If birim = "" Then
                            birim = "ADET"
                        End If
                        birim = degeruzunlukkontrol(birim, 4)
                        If birim = "P" Then
                            status = "P"
                        End If
                        'departman oluþtur
                        departman = ""
                        departman += sayiuzunlukkontrol(Replace(Left(dr("sKdvTipi"), 2), ".", ""), 2)
                        'stok numarasý oluþtur
                        stokno = UCase(Microsoft.VisualBasic.Right(dr("nStokID"), 6))
                        stokno = sayiuzunlukkontrol(stokno, 6)
                        fiyat = sayiuzunlukkontrol(FormatNumber(satisfiyati, 2).Replace(",", ""), 9)
                        'sayi += 1
                        'Dim satir As String = ""
                        'satir = sayiuzunlukkontrol(sayi, 6)
                        'If Trim(dr("sBirimCinsi1").ToString) = "P" Then
                        '    status = "P"
                        'End If
                        plu = degeruzunlukkontrol(Trim(plu), 20)
                        malincinsi = degeruzunlukkontrol(Trim(malincinsi), 20)
                        If satirlar.Items.Contains(stokno) = False Then
                            sayi += 1
                            satir = sayiuzunlukkontrol(sayi, 6)
                            If Trim(dr("sBirimCinsi1").ToString) = "P" Then
                                status = "P"
                            End If
                            sw.WriteLine(1 & stokno & plu & malincinsi & fiyat & departman & birim & status)
                            satirlar.Items.Add(stokno)
                            If Trim(dr("sAlisKdvTipi")) <> "" Then
                                toptansw.WriteLine(Trim(plu) & "," & sayiuzunlukkontrol(Replace(Left(dr("sAlisKdvTipi"), 2), ".", ""), 2) & ",0" & fiyat)
                            End If
                        Else
                        End If
                        Dim dr_inter As DataRow = ds_Inter.Tables(0).NewRow
                        dr_inter("BARKOD") = plu
                        dr_inter("PLU") = stokno
                        dr_inter("SATIR") = satir
                        'MsgBox(sayiuzunlukkontrol_deger(Microsoft.VisualBasic.Right(Trim(dr("sSinifKodu5").ToString), 4), 4, "0"))
                        Try
                            If Trim(dr("sSinifKodu5").ToString) <> "" Then
                                dr_inter("REYON") = sayiuzunlukkontrol_deger(Microsoft.VisualBasic.Right(Trim(dr("sSinifKodu5").ToString), 4), 4, "0")
                            Else
                                dr_inter("REYON") = ""
                            End If
                        Catch ex As Exception
                            dr_inter("REYON") = ""
                        End Try
                        Try
                            If Trim(dr("sSinifKodu6").ToString) <> "" Then
                                dr_inter("GRUP") = sayiuzunlukkontrol_deger(Microsoft.VisualBasic.Right(Trim(dr("sSinifKodu6").ToString), 4), 4, "0")
                            Else
                                dr_inter("GRUP") = ""
                            End If
                        Catch ex As Exception
                            dr_inter("GRUP") = ""
                        End Try
                        Try
                            If Trim(dr("sSinifKodu7").ToString) <> "" Then
                                dr_inter("OZELKOD") = sayiuzunlukkontrol_deger(Microsoft.VisualBasic.Right(Trim(dr("sSinifKodu7").ToString), 4), 4, "0")
                            Else
                                dr_inter("OZELKOD") = ""
                            End If
                        Catch ex As Exception
                            dr_inter("OZELKOD") = ""
                        End Try
                        ds_Inter.Tables(0).Rows.Add(dr_inter)
                        dr_inter = Nothing
                        'CMD.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO  BTBLINTERPOSIDX (BARKOD, PLU, SATIR) VALUES     ('" & plu & "','" & stokno & "','" & satir & "')"
                        'CMD.ExecuteNonQuery()
                        '    satir_plu.SetValue(plu, pluno, satir)
                    End If
                End If
            Else
            End If
            nIndex = nIndex + 1
            'Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        CON.Close()
        sw.Close()
        barkodsw.Close()
        plusw.Close()
        toptansw.Close()
        dosyaolusturINTER_IDX(0, sPath, sFile, sDepo)
        dosyaolusturINTER_IDX(1, sPath, sFile, sDepo)
        dosyaolusturINTER_IDX(2, sPath, sFile, sDepo)
        dosyaolusturINTER_IDX(3, sPath, sFile, sDepo)
        dosyaolusturINTER_IDX(4, sPath, sFile, sDepo)
        Dim sDosyaU As New FileInfo(z) 'urun.dat
        Dim sDosyaB As New FileInfo(barkodidx) 'barkod.ýdx
        Dim sDosyaP As New FileInfo(pluidx) 'plu.ýdx
        Dim sDosyaR As New FileInfo(pluReyon) 'reyon.dat
        Dim sDosyaO As New FileInfo(pluOzelKod) 'ozelkod.dat
        Dim sDosyaG As New FileInfo(pluOzelKod) 'grup.dat
        Dim sDosyaT As New FileInfo(pluToptan) 'toptan.dat
        'urun
        If sDosyaU.Exists = True Then
            sDosyaU.CopyTo(sDosyaUrun, True)
        End If
        'barkod
        If sDosyaB.Exists = True Then
            sDosyaB.CopyTo(sDosyaBarkod, True)
        End If
        'plu
        If sDosyaP.Exists = True Then
            sDosyaP.CopyTo(sDosyaPluno, True)
        End If
        'Reyon 
        If sDosyaR.Exists = True Then
            sDosyaR.CopyTo(sDosyaPluReyon, True)
        End If
        'OzelKod 
        If sDosyaO.Exists = True Then
            sDosyaO.CopyTo(sDosyapluOzelKod, True)
        End If
        'Grup
        If sDosyaG.Exists = True Then
            sDosyaG.CopyTo(sDosyaPluGrup, True)
        End If
        'Toptan
        If sDosyaT.Exists = True Then
            sDosyaT.CopyTo(sDosyapluToptan, True)
        End If
        satirlar.Items.Clear()
        satirlar.Dispose()
        satirlar = Nothing
        'Progress.HideProgress()
        SplashScreenManager.CloseForm()
    End Sub
    Private Sub dosyaolusturINTER_uruntaksit(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        Dim dr As DataRow
        Dim plu As String
        Dim malincinsi As String
        Dim departman As String = ""
        Dim fiyat
        Dim satisfiyati
        Dim stokno
        Dim birim
        Dim status
        Dim satirlar As New Windows.Forms.ComboBox
        Dim satir As String = ""
        Dim z As String = String.Format("{0}:{1}\posgenel\URUNTKST.DAT", sPath, sFile)
        Dim barkodidx As String = String.Format("{0}:{1}\posgenel\BARKOD.IDX", sPath, sFile)
        Dim pluidx As String = String.Format("{0}:{1}\posgenel\PLUNO.IDX", sPath, sFile)
        Dim DOSYA As New FileInfo(z)
        If DOSYA.Exists Then
            DOSYA.Delete()
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        sayi = 0
        ds_Inter.Tables(0).Clear()
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Ýnter Pos Taksit Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT2") > 0 And dr("FIYAT2") < 1000000000 Then
                If IsNumeric(dr("sBarkod")) Then
                    Dim barkod = Trim(dr("sBarkod").ToString)
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If dr("sBirimCinsi1") = "P" Then
                        dr("FIYAT2") = 0
                    End If
                    If sFiyatTipi <> 1 Then
                        If dr("lFiyat") = 0 Then
                            satisfiyati = dr("FIYAT2")
                        Else
                            satisfiyati = dr("lFiyat")
                        End If
                    Else
                        satisfiyati = dr("FIYAT2")
                    End If
                    If barkoduzunluk >= 5 Then
                        If Len(barkod) = 13 Then
                            plu = barkod
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "H"
                        ElseIf Len(barkod) = 8 Then
                            plu = (barkod)
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "H"
                        ElseIf Len(Trim(barkod)) = 5 Then
                            plu = sGramaj
                            plu += (barkod)
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "E"
                        ElseIf Len(barkod) > 14 Then
                            plu = (barkod)
                            plu = Microsoft.VisualBasic.Left(plu, 13)
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "H"
                        ElseIf Len(barkod) = 6 Then
                            barkod = CType(barkod, Integer)
                            plu = (barkod)
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "H"
                        Else
                            'buraya dikkat et
                            plu = barkod
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "H"
                        End If
                        'malincinsi oluþtur
                        malincinsi = " " + UCase(Trim(dr("sAciklama").ToString))
                        'birim adý oluþtur
                        birim = UCase(dr("sBirimCinsi1"))
                        If birim = "" Then
                            birim = "ADET"
                        End If
                        birim = degeruzunlukkontrol(birim, 4)
                        If birim = "P" Then
                            status = "P"
                        End If
                        'departman oluþtur
                        departman = ""
                        departman += sayiuzunlukkontrol(Replace(Left(dr("sKdvTipi"), 2), ".", ""), 2)
                        'stok numarasý oluþtur
                        stokno = UCase(Microsoft.VisualBasic.Right(dr("nStokID"), 6))
                        stokno = sayiuzunlukkontrol(stokno, 6)
                        fiyat = sayiuzunlukkontrol(FormatNumber(satisfiyati, 2).Replace(",", ""), 10)
                       
                        Dim sAy As String = ""
                        Dim sGun As String = ""
                        Dim sYil As String = ""
                        Dim sDakika As String = ""
                        Dim sSaniye As String = ""
                        Dim sSalise As String = ""
                        plu = degeruzunlukkontrol(Trim(plu), 20)
                        malincinsi = degeruzunlukkontrol(Trim(malincinsi), 20)
                        If satirlar.Items.Contains(stokno) = False Then
                            sayi += 1
                            satir = sayiuzunlukkontrol(sayi, 6)
                            If Trim(dr("sBirimCinsi1").ToString) = "P" Then
                                status = "P"
                            End If
                            sw.WriteLine(String.Format("{0},{1},{2},01-01-2000 23:59:59,01", stokno, malincinsi, fiyat))
                            satirlar.Items.Add(stokno)
                        Else
                        End If
                    End If
                End If
            Else
            End If
            nIndex = nIndex + 1
            'Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        satirlar.Items.Clear()
        satirlar.Dispose()
        satirlar = Nothing
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolusturINTER_IDX(ByVal islem As Integer, ByVal sPath As String, ByVal sFile As String, ByVal sDepo As String)
        Dim barkodidx As String = "C:" & sFile & "\posgenel\" & sDepo & "\BARKOD.IDX"
        Dim pluidx As String = "C:" & sFile & "\posgenel\" & sDepo & "\PLUNO.IDX"
        Dim pluReyon As String = "C:" & sFile & "\posgenel\" & sDepo & "\REYON.DAT"
        Dim pluGrup As String = "C:" & sFile & "\posgenel\" & sDepo & "\GRUP.DAT"
        Dim pluOzelKod As String = "C:" & sFile & "\posgenel\" & sDepo & "\OZELKOD.DAT"
        Dim dosya1 As New FileInfo(barkodidx)
        Dim satirlar As New Windows.Forms.ComboBox
        If islem = 0 Then
            If dosya1.Exists Then
                dosya1.Delete()
            End If
        ElseIf islem = 1 Then
            Dim dosya2 As New FileInfo(pluidx)
            If dosya2.Exists Then
                dosya2.Delete()
            End If
        ElseIf islem = 2 Then
            Dim dosya3 As New FileInfo(pluReyon)
            If dosya3.Exists Then
                dosya3.Delete()
            End If
        ElseIf islem = 3 Then
            Dim dosya4 As New FileInfo(pluGrup)
            If dosya4.Exists Then
                dosya4.Delete()
            End If
        ElseIf islem = 4 Then
            Dim dosya5 As New FileInfo(pluOzelKod)
            If dosya5.Exists Then
                dosya5.Delete()
            End If
        End If
        Dim barkodsw As StreamWriter = File.AppendText(barkodidx)
        Dim plusw As StreamWriter = File.AppendText(pluidx)
        Dim reyonsw As StreamWriter = File.AppendText(pluReyon)
        Dim grupsw As StreamWriter = File.AppendText(pluGrup)
        Dim ozelkodsw As StreamWriter = File.AppendText(pluOzelKod)
        GridControl1.DataSource = ds_Inter.Tables(0)
        GridControl1.DataMember = Nothing
        If islem = 0 Then
            GridView1.Columns("BARKOD").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            GridView1.Columns("PLU").SortOrder = DevExpress.Data.ColumnSortOrder.None
            GridView1.Columns("SATIR").SortOrder = DevExpress.Data.ColumnSortOrder.None
            GridView1.Columns("OZELKOD").SortOrder = DevExpress.Data.ColumnSortOrder.None
            GridView1.SelectAll()
        ElseIf islem = 1 Then
            GridView1.Columns("BARKOD").SortOrder = DevExpress.Data.ColumnSortOrder.None
            GridView1.Columns("PLU").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            GridView1.Columns("SATIR").SortOrder = DevExpress.Data.ColumnSortOrder.None
            GridView1.Columns("OZELKOD").SortOrder = DevExpress.Data.ColumnSortOrder.None
            GridView1.SelectAll()
        ElseIf islem = 2 Or islem = 3 Or islem = 4 Then
            GridView1.Columns("BARKOD").SortOrder = DevExpress.Data.ColumnSortOrder.None
            GridView1.Columns("PLU").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            GridView1.Columns("SATIR").SortOrder = DevExpress.Data.ColumnSortOrder.None
            GridView1.Columns("OZELKOD").SortOrder = DevExpress.Data.ColumnSortOrder.None
            GridView1.SelectAll()
        End If
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim deger As String
        Dim satirno As String
        Dim dr_idx As DataRow
        GridView1.SelectAll()
        arr = GridView1.GetSelectedRows()
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr_idx = GridView1.GetDataRow(s)
                If islem = 0 Then
                    deger = dr_idx(1)
                    satirno = dr_idx(3)
                    barkodsw.WriteLine(deger & satirno)
                ElseIf islem = 1 Then
                    deger = dr_idx(2)
                    satirno = dr_idx(3)
                    If satirlar.Items.Contains(deger) = False Then
                        plusw.WriteLine(deger & satirno)
                        satirlar.Items.Add(deger)
                    End If
                ElseIf islem = 2 Then
                    deger = dr_idx(2)
                    satirno = dr_idx(4)
                    If Trim(satirno) = "" Then
                    Else
                        If satirlar.Items.Contains(deger) = False Then
                            reyonsw.WriteLine(deger & satirno)
                            satirlar.Items.Add(deger)
                        End If
                    End If
                ElseIf islem = 3 Then
                    deger = dr_idx(2)
                    satirno = dr_idx(5)
                    If Trim(satirno) = "" Then
                    Else
                        If satirlar.Items.Contains(deger) = False Then
                            grupsw.WriteLine(deger & satirno)
                            satirlar.Items.Add(deger)
                        End If
                    End If
                ElseIf islem = 4 Then
                    deger = dr_idx(2)
                    satirno = dr_idx(6)
                    If Trim(satirno) = "" Then
                    Else
                        If satirlar.Items.Contains(deger) = False Then
                            ozelkodsw.WriteLine(deger & "," & satirno)
                            satirlar.Items.Add(deger)
                        End If
                    End If
                End If
            Next
        End If
        barkodsw.Close()
        plusw.Close()
        reyonsw.Close()
        grupsw.Close()
        ozelkodsw.Close()
        satirlar.Items.Clear()
        satirlar.Dispose()
        satirlar = Nothing
    End Sub
    Private Sub dosyaolusturESCORT_IDX(ByVal islem As Integer, ByVal sPath As String, ByVal sFile As String)
        Dim barkodidx As String = "" & sPath & ":" & sFile & "\posgenel\DATA\BARKOD.IDX"
        Dim pluidx As String = "" & sPath & ":" & sFile & "\posgenel\DATA\PLUNO.IDX"
        Dim dosya1 As New FileInfo(barkodidx)
        Dim satirlar As New Windows.Forms.ComboBox
        If islem = 0 Then
            If dosya1.Exists Then
                dosya1.Delete()
            End If
        ElseIf islem = 1 Then
            Dim dosya2 As New FileInfo(pluidx)
            If dosya2.Exists Then
                dosya2.Delete()
            End If
        End If
        Dim barkodsw As StreamWriter = File.AppendText(barkodidx)
        Dim plusw As StreamWriter = File.AppendText(pluidx)
        GridControl1.DataSource = ds_Inter.Tables(0)
        GridControl1.DataMember = Nothing
        If islem = 0 Then
            GridView1.Columns("BARKOD").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            GridView1.Columns("PLU").SortOrder = DevExpress.Data.ColumnSortOrder.None
            GridView1.Columns("SATIR").SortOrder = DevExpress.Data.ColumnSortOrder.None
            GridView1.SelectAll()
        ElseIf islem = 1 Then
            GridView1.Columns("BARKOD").SortOrder = DevExpress.Data.ColumnSortOrder.None
            GridView1.Columns("PLU").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            GridView1.Columns("SATIR").SortOrder = DevExpress.Data.ColumnSortOrder.None
            GridView1.SelectAll()
        End If
        'Dim s As String
        'Dim arr As Integer()
        'Dim i As Integer
        'Dim dr_idx As DataRow
        'Dim deger As String
        'Dim satirno As String
        'GridView1.SelectAll()
        'arr = GridView1.GetSelectedRows()
        'If arr Is Nothing Then
        'Else
        '    Array.Sort(arr)
        '    For Each i In arr
        '        s = i.ToString
        '        dr_idx = GridView1.GetDataRow(s)
        '        If islem = 0 Then
        '            deger = dr_idx(1)
        '            satirno = dr_idx(3)
        '            barkodsw.WriteLine(deger & satirno)
        '        ElseIf islem = 1 Then
        '            deger = dr_idx(2)
        '            satirno = dr_idx(3)
        '            plusw.WriteLine(deger & satirno)
        '        End If
        '    Next
        'End If
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim deger As String
        Dim satirno As String
        Dim dr_idx As DataRow
        GridView1.SelectAll()
        arr = GridView1.GetSelectedRows()
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr_idx = GridView1.GetDataRow(s)
                If islem = 0 Then
                    deger = dr_idx(1)
                    satirno = dr_idx(3)
                    barkodsw.WriteLine(deger & satirno)
                ElseIf islem = 1 Then
                    deger = dr_idx(2)
                    satirno = dr_idx(3)
                    If satirlar.Items.Contains(deger) = False Then
                        plusw.WriteLine(deger & satirno)
                        satirlar.Items.Add(deger)
                    End If
                End If
            Next
        End If
        barkodsw.Close()
        plusw.Close()
        satirlar.Items.Clear()
        satirlar.Dispose()
        satirlar = Nothing
    End Sub
    Private Sub dosyaolusturINTER_degisen(ByVal sPath As String, ByVal sFile As String, ByVal sFiyattipi As Integer, ByVal sGramaj As String)
        Dim dr As DataRow
        Dim plu As String
        Dim malincinsi As String
        Dim departman As String
        Dim fiyat
        Dim satisfiyati
        Dim stokno
        Dim birim
        Dim status
        Dim satirlar As New Windows.Forms.ComboBox
        Dim satir As String = ""
        Dim sAyrac As String = ":"
        If sPath = "\\tsclient\C" Or sPath = "\\tsclient\D" Or sPath = "\\tsclient\E" Or sPath = "\\tsclient\F" Then
            sAyrac = ""
        End If
        Dim z As String = "" & sPath & sAyrac & sFile & "\posgenel\TEKURUN.DAT" 'SAVE.FileName.ToString
        Dim barkodidx As String = "" & sPath & sAyrac & sFile & "\posgenel\BARKOD.IDX"
        Dim pluidx As String = "" & sPath & sAyrac & sFile & "\posgenel\PLUNO.IDX"
        Dim DOSYA As New FileInfo(z)
        If DOSYA.Exists Then
            DOSYA.Delete()
        End If
        Dim dosya1 As New FileInfo(barkodidx)
        If dosya1.Exists Then
            dosya1.Delete()
        End If
        Dim dosya2 As New FileInfo(pluidx)
        If dosya2.Exists Then
            dosya2.Delete()
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        Dim barkodsw As StreamWriter = File.AppendText(barkodidx)
        Dim plusw As StreamWriter = File.AppendText(pluidx)
        sayi = 0
        Dim CON As New OleDb.OleDbConnection
        CON.ConnectionString = connection
        Dim CMD As New OleDb.OleDbCommand
        CMD.CommandTimeout = Nothing
        CMD.Connection = CON
        CON.Open()
        CMD.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM BTBLINTERPOSIDX WHERE IND > 0"
        CMD.ExecuteNonQuery()
        CON.Close()
        CON.Open()
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Ýnter Pos Deðiþen Stoklar Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 And dr("FIYAT1") < 1000000000 Then
                If IsNumeric(dr("sBarkod")) Then
                    Dim barkod = Trim(dr("sBarkod"))
                    Dim barkoduzunluk As Integer
                    If IsDBNull(dr("sBarkod")) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If dr("sBirimCinsi1") = "P" Then
                        dr("FIYAT1") = 0
                    End If
                    If sFiyattipi <> 1 Then
                        If dr("lFiyat") = 0 Then
                            satisfiyati = dr("FIYAT1")
                        Else
                            satisfiyati = dr("lFiyat")
                        End If
                    Else
                        satisfiyati = dr("FIYAT1")
                    End If
                    If barkoduzunluk >= 5 Then
                        If Len(barkod) = 13 Then
                            plu = barkod
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "H"
                        ElseIf Len(barkod) = 8 Then
                            plu = (barkod)
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "H"
                        ElseIf Len(Trim(barkod)) = 5 Then
                            plu = sGramaj
                            plu += (barkod)
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "E"
                        ElseIf Len(barkod) > 14 Then
                            plu = (barkod)
                            plu = Microsoft.VisualBasic.Left(plu, 13)
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "H"
                        ElseIf Len(barkod) = 6 Then
                            plu = (barkod)
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "H"
                        Else
                            'buraya dikkat et
                            plu = barkod
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "H"
                        End If
                        malincinsi = " " + UCase(Trim(dr("sAciklama").ToString))
                        'birim adý oluþtur
                        birim = UCase(dr("sBirimCinsi1"))
                        If birim = "" Then
                            birim = "ADET"
                        End If
                        birim = degeruzunlukkontrol(birim, 4)
                        If birim = "P" Then
                            status = "P"
                        End If
                        'departman oluþtur
                        departman = ""
                        departman += sayiuzunlukkontrol(Replace(Left(dr("sKdvTipi"), 2), ".", ""), 2)
                        'stok numarasý oluþtur
                        stokno = UCase(Microsoft.VisualBasic.Right(dr("nStokID"), 6))
                        stokno = sayiuzunlukkontrol(stokno, 6)
                        fiyat = sayiuzunlukkontrol(FormatNumber(satisfiyati, 2).Replace(",", ""), 9)
                        plu = degeruzunlukkontrol(Trim(plu), 20)
                        malincinsi = degeruzunlukkontrol(Trim(malincinsi), 20)
                        If satirlar.Items.Contains(stokno) = False Then
                            sayi += 1
                            satir = sayiuzunlukkontrol(sayi, 6)
                            If Trim(dr("sBirimCinsi1").ToString) = "P" Then
                                status = "P"
                            End If
                            sw.WriteLine(1 & stokno & plu & malincinsi & fiyat & departman & birim & status)
                            satirlar.Items.Add(stokno)
                        End If
                        'sw.WriteLine(1 & stokno & plu & malincinsi & fiyat & departman & birim & status)
                        'sayi += 1
                    End If
                End If
            Else
            End If
            nIndex = nIndex + 1
            'Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        CON.Close()
        sw.Close()
        satirlar.Items.Clear()
        satirlar.Dispose()
        satirlar = Nothing
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolusturINTER_cariler(ByVal sPath As String, ByVal sFile As String, ByVal sFiyattipi As Integer, ByVal sKasa As String)
        Dim dr As DataRow
        Dim nCarino As String = ""
        Dim nCariKod As String = ""
        Dim sCari As String = ""
        Dim sAdres As String = ""
        Dim sVergiDairesi As String = ""
        Dim sVergiNo As String = ""
        Dim nIskontoYuzdesi As String = ""
        Dim nFiyatNo As String = 1
        Dim sCariOzelKod As String = ""
        Dim sAyrac As String = ":"
        If sPath = "\\tsclient\C" Or sPath = "\\tsclient\D" Or sPath = "\\tsclient\E" Or sPath = "\\tsclient\F" Then
            sAyrac = ""
        End If
        Dim z As String = "" & sPath & sAyrac & sFile & "\posgenel\CARI.DAT" 'SAVE.FileName.ToString
        Dim barkodidx As String = "" & sPath & sAyrac & sFile & "\posgenel\CARINO.IDX"
        Dim pluidx As String = "" & sPath & sAyrac & sFile & "\posgenel\CARIKOD.IDX"
        If sKasa = "Escort" Then
            z = "" & sPath & sAyrac & sFile & "\posgenel\DATA\CARI.DAT"
            barkodidx = "" & sPath & sAyrac & sFile & "\posgenel\DATA\CARINO.IDX"
            pluidx = "" & sPath & sAyrac & sFile & "\posgenel\DATA\CARIKOD.IDX"
        End If
        Dim DOSYA As New FileInfo(z)
        If DOSYA.Exists Then
            DOSYA.Delete()
        End If
        Dim dosya1 As New FileInfo(barkodidx)
        If dosya1.Exists Then
            dosya1.Delete()
        End If
        Dim dosya2 As New FileInfo(pluidx)
        If dosya2.Exists Then
            dosya2.Delete()
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        Dim barkodsw As StreamWriter = File.AppendText(barkodidx)
        Dim plusw As StreamWriter = File.AppendText(pluidx)
        sayi = 0
        Dim CON As New OleDb.OleDbConnection
        CON.ConnectionString = connection
        Dim CMD As New OleDb.OleDbCommand
        CMD.CommandTimeout = Nothing
        CMD.Connection = CON
        CON.Open()
        CMD.CommandText = "TRUNCATE TABLE BTBLINTERPOSIDX "
        CMD.ExecuteNonQuery()
        CON.Close()
        CON.Open()
        Dim ds As New DataSet
        ds = intercariler()
        sayi = 1
        Progress.ShowProgress(ds.Tables(0).Rows.Count(), Sorgu_sDil("Cari Dosyasý Oluþturuluyor...", sDil))
        Dim nIndex As Integer = 0
        For Each dr In ds.Tables(0).Rows
            'If Trim(dr("nKartNo")) = "" Then
            nCariKod = degeruzunlukkontrol(Trim(dr("sKodu").ToString), 20)
            'Else
            '    nCariKod = degeruzunlukkontrol(Trim(dr("nKartNo").ToString), 20)
            'End If
            sCari = degeruzunlukkontrol(Trim(dr("sAciklama")).ToString, 20)
            sAdres = degeruzunlukkontrol(Trim(dr("sAdres1").ToString), 60)
            sVergiDairesi = degeruzunlukkontrol(Trim(dr("sVergiDairesi").ToString), 15)
            sVergiNo = degeruzunlukkontrol(Trim(dr("sVergiNo").ToString), 15)
            nIskontoYuzdesi = sayiuzunlukkontrol(CInt(dr("nOzelIskontosu")), 2)
            If Trim(dr("sEhliyetNo")) = "" Then
                nFiyatNo = sayiuzunlukkontrol_deger("1", 2, "0")
            Else
                If IsNumeric(dr("sEhliyetNo")) Then
                    nFiyatNo = sayiuzunlukkontrol_deger(CInt(dr("sEhliyetNo")), 2, "0")
                End If
            End If
            sCariOzelKod = degeruzunlukkontrol("C", 20)
            Dim satir As String
            satir = sayiuzunlukkontrol(sayi, 6)
            Dim pluno As String = ""
            nCarino = Trim(dr("nFirmaID"))
            pluno = sayiuzunlukkontrol(nCarino, 6)
            sw.WriteLine(1 & pluno & nCariKod & sCari & sAdres & sVergiDairesi & sVergiNo & nIskontoYuzdesi & nFiyatNo & "C                   ")
            CMD.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO  BTBLINTERPOSIDX (BARKOD, PLU, SATIR) VALUES     ('" & nCariKod & "','" & nCarino & "','" & satir & "')"
            CMD.ExecuteNonQuery()
            sayi += 1
            nIndex = nIndex + 1
            'Progress.Progress(nIndex, Sorgu_sDil("Kodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        CON.Close()
        sw.Close()
        Progress.HideProgress()
        Dim deger
        Dim satirno
        ds = interbarkodidx()
        For Each dr In ds.Tables(0).Rows
            deger = dr(0)
            satirno = dr(1)
            plusw.WriteLine(degeruzunlukkontrol(deger, 20) & satirno)
        Next
        plusw.Close()
        ds = interpluidx()
        For Each dr In ds.Tables(0).Rows
            deger = Trim(dr(0))
            satirno = dr(1)
            barkodsw.WriteLine(sayiuzunlukkontrol(deger, 6) & satirno)
        Next
        barkodsw.Close()
    End Sub
    Private Sub dosyaolusturINTER_cariler2(ByVal sPath As String, ByVal sFile As String, ByVal sFiyattipi As Integer)
        Dim dr As DataRow
        Dim nCarino As String = ""
        Dim nCariKod As String = ""
        Dim sCari As String = ""
        Dim sAdres As String = ""
        Dim sVergiDairesi As String = ""
        Dim sVergiNo As String = ""
        Dim nIskontoYuzdesi As String = ""
        Dim nFiyatNo As String = "1"
        Dim sCariOzelKod As String = ""
        Dim sAyrac As String = ":"
        If sPath = "\\tsclient\C" Or sPath = "\\tsclient\D" Or sPath = "\\tsclient\E" Or sPath = "\\tsclient\F" Then
            sAyrac = ""
        End If
        Dim z As String = "" & sPath & sAyrac & sFile & "\posgenel\CARI.DAT" 'SAVE.FileName.ToString
        Dim barkodidx As String = "" & sPath & sAyrac & sFile & "\posgenel\CARINO.IDX"
        Dim pluidx As String = "" & sPath & sAyrac & sFile & "\posgenel\CARIKOD.IDX"
        Dim DOSYA As New FileInfo(z)
        If DOSYA.Exists Then
            DOSYA.Delete()
        End If
        Dim dosya1 As New FileInfo(barkodidx)
        If dosya1.Exists Then
            dosya1.Delete()
        End If
        Dim dosya2 As New FileInfo(pluidx)
        If dosya2.Exists Then
            dosya2.Delete()
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        Dim barkodsw As StreamWriter = File.AppendText(barkodidx)
        Dim plusw As StreamWriter = File.AppendText(pluidx)
        sayi = 0
        Dim CON As New OleDb.OleDbConnection
        CON.ConnectionString = connection
        Dim CMD As New OleDb.OleDbCommand
        CMD.CommandTimeout = Nothing
        CMD.Connection = CON
        CON.Open()
        CMD.CommandText = "TRUNCATE TABLE BTBLINTERPOSIDX "
        CMD.ExecuteNonQuery()
        CON.Close()
        CON.Open()
        Dim ds As New DataSet
        ds = intercariler2()
        sayi = 1
        Progress.ShowProgress(ds.Tables(0).Rows.Count(), Sorgu_sDil("Cari Dosyasý Oluþturuluyor...", sDil))
        Dim nIndex As Integer = 0
        For Each dr In ds.Tables(0).Rows
            nCariKod = degeruzunlukkontrol(Trim(dr("sKodu").ToString), 20)
            sCari = degeruzunlukkontrol(Trim(dr("sAciklama")).ToString, 20)
            sAdres = degeruzunlukkontrol(Trim(dr("sAdres1").ToString), 60)
            sVergiDairesi = degeruzunlukkontrol(Trim(dr("sVergiDairesi").ToString), 15)
            sVergiNo = degeruzunlukkontrol(Trim(dr("sVergiNo").ToString), 15)
            nIskontoYuzdesi = sayiuzunlukkontrol(CInt(dr("nOzelIskontosu")), 2)
            If Trim(dr("sEhliyetNo")) = "" Then
                nFiyatNo = sayiuzunlukkontrol_deger("1", 2, "0")
            Else
                If IsNumeric(dr("sEhliyetNo")) Then
                    nFiyatNo = sayiuzunlukkontrol_deger(CInt(dr("sEhliyetNo")), 2, "0")
                End If
            End If
            sCariOzelKod = degeruzunlukkontrol("C", 20)
            Dim satir As String
            satir = sayiuzunlukkontrol(sayi, 6)
            Dim pluno As String = ""
            nCarino = Trim(dr("nFirmaID"))
            pluno = sayiuzunlukkontrol(nCarino, 6)
            sw.WriteLine(1 & pluno & nCariKod & sCari & sAdres & sVergiDairesi & sVergiNo & nIskontoYuzdesi & nFiyatNo, sCariOzelKod)
            CMD.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO  BTBLINTERPOSIDX (BARKOD, PLU, SATIR) VALUES     ('" & nCariKod & "','" & nCarino & "','" & satir & "')"
            CMD.ExecuteNonQuery()
            sayi += 1
            nIndex = nIndex + 1
            'Progress.Progress(nIndex, Sorgu_sDil("Kodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        CON.Close()
        sw.Close()
        Progress.HideProgress()
        Dim deger
        Dim satirno
        ds = interbarkodidx()
        'For Each dr In ds.Tables(0).Rows
        '    deger = dr(0)
        '    satirno = dr(1)
        '    barkodsw.WriteLine(deger & " " & satirno)
        'Next
        'barkodsw.Close()
        'ds = interpluidx()
        'For Each dr In ds.Tables(0).Rows
        '    deger = dr(0)
        '    satirno = dr(1)
        '    plusw.WriteLine(deger & satirno)
        'Next
        'plusw.Close()
        For Each dr In ds.Tables(0).Rows
            deger = dr(0)
            satirno = dr(1)
            plusw.WriteLine(deger & " " & satirno)
        Next
        plusw.Close()
        ds = interpluidx()
        For Each dr In ds.Tables(0).Rows
            deger = dr(0)
            satirno = dr(1)
            barkodsw.WriteLine(deger & satirno)
        Next
        barkodsw.Close()
    End Sub
    Private Sub dosyaolustur_BusinessMobile_cariler(ByVal sPath As String, ByVal sFile As String, ByVal sFiyattipi As Integer)
        Dim dr As DataRow
        Dim nCariKod As String = ""
        Dim sCari As String = ""
        Dim lBakiye As String = ""
        Dim z As String = "" & sPath & ": " & sFile  'SAVE.FileName.ToString
        Dim DOSYA As New FileInfo(z)
        If DOSYA.Exists Then
            DOSYA.Delete()
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        sayi = 0
        Dim ds As New DataSet
        ds = ds_BusinessMobile_cariler()
        sayi = 1
        For Each dr In ds.Tables(0).Rows
            nCariKod = degeruzunlukkontrol(Trim(dr("sKodu").ToString), 20)
            sCari = degeruzunlukkontrol(Trim(dr("sAciklama")).ToString, 60)
            lBakiye = sayiuzunlukkontrol_deger(FormatNumber(sorgu_sayi(dr("lBakiye"), 0), 2).Replace(",", ""), 10, " ")
            sw.WriteLine(nCariKod & "," & sCari & "," & lBakiye)
            sayi += 1
        Next
        sw.Close()
    End Sub
    Private Sub dosyaolustur_SambaPos_musteriler(ByVal sPath As String, ByVal sFile As String, ByVal sFiyattipi As Integer, ByVal sKasa As String)
        Dim dr As DataRow
        Dim nCarino As String = ""
        Dim nCariKod As String = ""
        Dim sCari As String = ""
        Dim sAdres As String = ""
        Dim sVergiDairesi As String = ""
        Dim sVergiNo As String = ""
        Dim nIskontoYuzdesi As String = ""
        Dim nFiyatNo As String = 1
        Dim sCariOzelKod As String = ""
        Dim sAyrac As String = ":"
        Dim ds As New DataSet
        ds = intercariler()
        sayi = 1
        Progress.ShowProgress(ds.Tables(0).Rows.Count(), Sorgu_sDil("SambaPos Müþteri Dosyasý Oluþturuluyor...", sDil))
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SambaData2;" & sFile & ";Current Language=Türkçe;Application Name=SambaPos"
        cmd.Connection = con
        Dim nIndex As Integer = 0
        For Each dr In ds.Tables(0).Rows
            'If Trim(dr("nKartNo")) = "" Then
            nCariKod = degeruzunlukkontrol(Trim(dr("sKodu").ToString), 20)
            'Else
            '    nCariKod = degeruzunlukkontrol(Trim(dr("nKartNo").ToString), 20)
            'End If
            sCari = degeruzunlukkontrol(Trim(dr("sAciklama")).ToString, 20)
            sAdres = degeruzunlukkontrol(Trim(dr("sAdres1").ToString), 60)
            sVergiDairesi = degeruzunlukkontrol(Trim(dr("sVergiDairesi").ToString), 15)
            sVergiNo = degeruzunlukkontrol(Trim(dr("sVergiNo").ToString), 15)
            nIskontoYuzdesi = sayiuzunlukkontrol(CInt(dr("nOzelIskontosu")), 2)
            If Trim(dr("sEhliyetNo")) = "" Then
                nFiyatNo = sayiuzunlukkontrol_deger("1", 2, "0")
            Else
                If IsNumeric(dr("sEhliyetNo")) Then
                    nFiyatNo = sayiuzunlukkontrol_deger(CInt(dr("sEhliyetNo")), 2, "0")
                End If
            End If
            If Trim(dr("sEvTelefonu")) = "" Then
                dr("sEvTelefonu") = "212"
            End If
            sCariOzelKod = degeruzunlukkontrol("C", 20)
            Dim satir As String
            satir = sayiuzunlukkontrol(sayi, 6)
            Dim pluno As String = ""
            nCarino = Trim(dr("nFirmaID"))
            pluno = sayiuzunlukkontrol(nCarino, 6)
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim nSayi As Integer = 0
            cmd.CommandText = "Select ISNULL(COUNT(*),0) from Customers Where Id = " & dr("nFirmaID") & ""
            nSayi = Convert.ToInt16(cmd.ExecuteScalar())
            If nSayi = 0 Then
                cmd.CommandText = "SET IDENTITY_INSERT  Customers ON INSERT INTO Customers                       (Id, Name, GroupCode, PhoneNumber, Address, Note, AccountOpeningDate, InternalAccount) VALUES     (" & dr("nFirmaId") & ", '" & dr("sAciklama") & "', NULL, '" & dr("sEvTelefonu") & "', '" & dr("sAdres") & "', '" & dr("sAciklama1") & "', '" & dr("dteKayitTarihi") & "', 0)"
                cmd.ExecuteNonQuery()
            ElseIf nSayi = 1 Then
                cmd.CommandText = ("Update Customers set Name = '" & dr("sAciklama") & "',PhoneNumber = '" & dr("sEvTelefonu") & "',Address = '" & dr("sAdres1") & "' Where Id = " & dr("nFirmaID") & "")
                cmd.ExecuteNonQuery()
            End If
            sayi += 1
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("Kodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        con.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolusturESCORT(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As Integer, ByVal sGramaj As String, Optional ByVal urunfile As String = "URUN.DAT")
        Dim dr As DataRow
        Dim plu As String
        Dim malincinsi As String
        Dim departman As String
        Dim satirlar As New Windows.Forms.ComboBox
        Dim satir As String = ""
        Dim fiyat
        Dim stokno
        Dim birim
        Dim status
        Dim sAyrac As String = ":"
        If sPath = "\\tsclient\C" Or sPath = "\\tsclient\D" Or sPath = "\\tsclient\E" Or sPath = "\\tsclient\F" Then
            sAyrac = ""
        End If
        Dim z As String = "" & sPath & sAyrac & sFile & "\posgenel\DATA\" & urunfile & "" 'SAVE.FileName.ToString
        Dim barkodidx As String = "" & sPath & sAyrac & sFile & "\POSGENEL\DATA\" & "BARKOD.IDX"
        Dim pluidx As String = "" & sPath & sAyrac & sFile & "\POSGENEL\DATA\" & "PLUNO.IDX"
        Dim DOSYA As New FileInfo(z)
        If DOSYA.Exists Then
            DOSYA.Delete()
        End If
        Dim dosya1 As New FileInfo(barkodidx)
        If dosya1.Exists Then
            dosya1.Delete()
        End If
        Dim dosya2 As New FileInfo(pluidx)
        If dosya2.Exists Then
            dosya2.Delete()
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        Dim barkodsw As StreamWriter = File.AppendText(barkodidx)
        Dim plusw As StreamWriter = File.AppendText(pluidx)
        'sw.WriteLine(sender)
        'sw.WriteLine("")
        sayi = 0
        Dim CON As New OleDb.OleDbConnection
        CON.ConnectionString = connection
        Dim CMD As New OleDb.OleDbCommand
        CMD.CommandTimeout = Nothing
        CMD.Connection = CON
        CON.Open()
        'CMD.CommandText = "TRUNCATE TABLE BTBLINTERPOSIDX "
        'CMD.ExecuteNonQuery()
        'CON.Close()
        'CON.Open()
        ds_Inter.Tables(0).Clear()
        'Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Escort Pos Stok Dosyasý Oluþturuluyor...")
        SplashScreenManager.ShowForm(GetType(WaitForm1), False, True)
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 And dr("FIYAT1") < 1000000000 Then
                If IsNumeric(dr("sBarkod")) Then
                    Dim barkod = Trim(dr("sBarkod"))
                    Dim barkoduzunluk As Integer
                    If IsDBNull(dr("sBarkod")) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If dr("sBirimCinsi1") = "P" Then
                        dr("FIYAT1") = 0
                    End If
                    Dim satisfiyati '= dr("FIYAT1")
                    If sFiyatTipi <> 1 Then
                        If dr("lFiyat") = 0 Then
                            satisfiyati = dr("FIYAT1")
                        Else
                            satisfiyati = dr("lFiyat")
                        End If
                    Else
                        satisfiyati = dr("FIYAT1")
                    End If
                    'plu oluþtur
                    If barkoduzunluk >= 5 Then
                        If Len(barkod) = 13 Then
                            plu = barkod
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "H"
                        ElseIf Len(barkod) = 8 Then
                            plu = (barkod)
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "H"
                        ElseIf Len(Trim(barkod)) = 5 Then
                            If Trim(dr("sBirimCinsi1")) = "ADT" Then
                                plu = "28"
                            Else
                                plu = sGramaj
                            End If
                            'plu = sGramaj
                            'plu = ""
                            plu += (barkod)
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "E"
                        ElseIf Len(barkod) > 14 Then
                            plu = (barkod)
                            plu = Microsoft.VisualBasic.Left(plu, 13)
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "H"
                        ElseIf Len(barkod) = 6 Then
                            barkod = CType(barkod, Integer)
                            plu = (barkod)
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "H"
                        Else
                            'buraya dikkat et
                            plu = barkod
                            plu = degeruzunlukkontrol(plu, 20)
                            status = "H"
                        End If
                        'malincinsi oluþtur
                        malincinsi = " " + UCase(Trim(dr("sAciklama").ToString))
                        'birim adý oluþtur
                        birim = UCase(dr("sBirimCinsi1"))
                        If birim = "" Then
                            birim = "ADET"
                        End If
                        birim = degeruzunlukkontrol(birim, 4)
                        If birim = "P" Then
                            status = "P"
                        End If
                        'departman oluþtur
                        departman = ""
                        departman += sayiuzunlukkontrol(Replace(Left(dr("sKdvTipi"), 2), ".", ""), 2)
                        'stok numarasý oluþtur
                        stokno = UCase(Microsoft.VisualBasic.Right(dr("nStokID"), 6))
                        stokno = sayiuzunlukkontrol(stokno, 6)
                        fiyat = sayiuzunlukkontrol(FormatNumber(satisfiyati, 2).Replace(".", "").Replace(",", ""), 9)
                        'sayi += 1
                        'Dim satir As String = ""
                        'satir = sayiuzunlukkontrol(sayi, 6)
                        'If Trim(dr("sBirimCinsi1").ToString) = "P" Then
                        '    status = "P"
                        'End If
                        plu = degeruzunlukkontrol(Trim(plu), 20)
                        malincinsi = degeruzunlukkontrol(Trim(malincinsi), 20)
                        If satirlar.Items.Contains(stokno) = False Then
                            sayi += 1
                            satir = sayiuzunlukkontrol(sayi, 6)
                            If Trim(dr("sBirimCinsi1").ToString) = "P" Then
                                status = "P"
                            End If
                            sw.WriteLine(1 & stokno & plu & malincinsi & fiyat & departman & birim & status & "000000")
                            satirlar.Items.Add(stokno)
                        Else
                        End If
                        Dim dr_inter As DataRow = ds_Inter.Tables(0).NewRow
                        dr_inter("BARKOD") = plu
                        dr_inter("PLU") = stokno
                        dr_inter("SATIR") = satir
                        ds_Inter.Tables(0).Rows.Add(dr_inter)
                        dr_inter = Nothing
                        If urunfile = "URUN.DAT" Then
                            'CMD.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO  BTBLINTERPOSIDX (BARKOD, PLU, SATIR) VALUES     ('" & plu & "','" & pluno & "','" & satir & "')"
                            'CMD.ExecuteNonQuery()
                        End If
                    End If
                End If
            Else
            End If
            nIndex = nIndex + 1
            'Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        CON.Close()
        sw.Close()
        barkodsw.Close()
        plusw.Close()
        If urunfile = "URUN.DAT" Then
            'Dim ds As New DataSet
            'Dim deger
            'Dim satirno
            'ds = interbarkodidx()
            'For Each dr In ds.Tables(0).Rows
            '    deger = dr(0)
            '    satirno = dr(1)
            '    barkodsw.WriteLine(deger & " " & satirno)
            'Next
            'barkodsw.Close()
            'ds = interpluidx()
            'For Each dr In ds.Tables(0).Rows
            '    deger = dr(0)
            '    satirno = dr(1)
            '    plusw.WriteLine(deger & satirno)
            'Next
            'plusw.Close()
            dosyaolusturESCORT_IDX(0, sPath, sFile)
            dosyaolusturESCORT_IDX(1, sPath, sFile)
        End If
        'Progress.HideProgress()
        SplashScreenManager.CloseForm()
    End Sub
    'Private Sub dosyaolusturCASLP1(ByVal path As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
    '    Dim dr As DataRow
    '    Dim plu As String
    '    Dim malincinsi As String
    '    Dim fiyat
    '    Dim satisfiyati
    '    Dim plunumber As String = ""
    '    'If SAVE.ShowDialog = DialogResult.OK Then
    '    Dim z As String = path & ":" & sFile
    '    Dim DOSYA As New FileInfo(z)
    '    If DOSYA.Exists Then
    '        DOSYA.Delete()
    '    Else
    '    End If
    '    Dim sw As StreamWriter = File.AppendText(z)
    '    'sw.WriteLine(sender)
    '    'sw.WriteLine("")
    '    Dim sayi As Integer = 0
    '    For Each dr In dataset1.Tables(0).Rows
    '        If dr("FIYAT1") > 0 And dr("FIYAT1") < 1000000000 Then
    '            If IsNumeric(dr("sBarkod")) Then
    '                sayi += 1
    '                If sayi < 10 Then
    '                    plunumber = "   "
    '                    plunumber += CStr(sayi)
    '                ElseIf sayi < 100 Then
    '                    plunumber = "  "
    '                    plunumber += CStr(sayi)
    '                ElseIf sayi < 1000 Then
    '                    plunumber = " "
    '                    plunumber += CStr(sayi)
    '                End If
    '                Dim barkod = Trim(dr("sBarkod"))
    '                Dim barkoduzunluk As Integer
    '                If IsDBNull(dr("sBarkod")) = True Then
    '                    barkoduzunluk = 0
    '                Else
    '                    barkoduzunluk = barkod.length
    '                End If
    '                If sFiyatTipi <> 1 Then
    '                    If dr("lFiyat") = 0 Then
    '                        satisfiyati = dr("FIYAT1")
    '                    Else
    '                        satisfiyati = dr("lFiyat")
    '                    End If
    '                Else
    '                    satisfiyati = dr("FIYAT1")
    '                End If
    '                'plu oluþtur
    '                If barkoduzunluk = 5 Then
    '                    If Len(Trim(dr("sBarkod"))) = 5 Then
    '                        'plu = "027"
    '                        plu = sGramaj
    '                        plu += (dr("sBarkod"))
    '                        plu += "000000"
    '                    End If
    '                    'malincinsi oluþtur
    '                    malincinsi = "" + UCase(dr("sAciklama"))
    '                    malincinsi = malincinsi.Replace("Ý", "I")
    '                    malincinsi = malincinsi.Replace("Þ", "S")
    '                    malincinsi = malincinsi.Replace("Ç", "C")
    '                    malincinsi = malincinsi.Replace("Ð", "G")
    '                    malincinsi = malincinsi.Replace("Ü", "U")
    '                    malincinsi = malincinsi.Replace("Ö", "O")
    '                    Dim maluzunluk As Integer = 28
    '                    Dim muzunluk = Len(malincinsi)
    '                    If Len(malincinsi) < 28 Then
    '                        Dim malfark As Integer = maluzunluk - muzunluk
    '                        Dim i As Integer
    '                        For i = 1 To malfark
    '                            malincinsi = malincinsi.Insert(muzunluk, " ")
    '                        Next
    '                    Else
    '                        malincinsi = Microsoft.VisualBasic.Left(malincinsi, 28)
    '                    End If
    '                    ''fiyat oluþtur
    '                    'If Len(Len(Convert.ToString(CType(satisfiyati, Integer)))) < 8 Then
    '                    '    If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CAS").GetValue("YTL") = "true" Then
    '                    '        fiyat = FormatNumber(satisfiyati, 2)
    '                    '        fiyat = fiyat.Replace(".", "")
    '                    '        fiyat = fiyat.Replace(",", "")
    '                    '    Else
    '                    '        fiyat = Convert.ToString(CType(satisfiyati, Integer))
    '                    '    End If
    '                    '    'fiyat = dr("FIYAT1")
    '                    '    Dim fiyatfark As Integer = 8 - Len(fiyat)
    '                    '    Dim i As Integer
    '                    '    For i = 1 To fiyatfark
    '                    '        fiyat = fiyat.insert(0, "0")
    '                    '    Next
    '                    'Else
    '                    '    If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CAS").GetValue("YTL") = "true" Then
    '                    '        fiyat = FormatNumber(satisfiyati, 2)
    '                    '        fiyat = fiyat.Replace(".", "")
    '                    '        fiyat = fiyat.Replace(",", "")
    '                    '        fiyat = Microsoft.VisualBasic.Left(fiyat, 8)
    '                    '    Else
    '                    '        fiyat = Convert.ToString(CType(satisfiyati, Integer))
    '                    '        fiyat = Microsoft.VisualBasic.Left(fiyat, 8)
    '                    '    End If
    '                    'End If
    '                    fiyat = sayiuzunlukkontrol(FormatNumber(dr("FIYAT" & sFiyatTipi & ""), 2).Replace(".", "").Replace(",", ""), 8)
    '                    sw.WriteLine(plunumber & vbTab & malincinsi & vbTab & malincinsi & vbTab & fiyat & vbTab & "  0" & vbTab & "   0" & vbTab & "0" + dr("sBarkod") & vbTab & "00" & vbTab & "  0" & vbTab)
    '                End If
    '            End If
    '        Else
    '        End If
    '    Next
    '    sw.Close()
    'End Sub
    Private Sub dosyaolusturCASLP1(ByVal spath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String, ByVal bBarkodlu As Boolean)
        Dim dr As DataRow
        Dim plu As String
        Dim malincinsi As String
        Dim fiyat
        Dim satisfiyati
        Dim plunumber As String = ""
        'If SAVE.ShowDialog = DialogResult.OK Then
        Dim sAyrac As String = ":"
        If sPath = "\\tsclient\C" Or sPath = "\\tsclient\D" Or sPath = "\\tsclient\E" Or sPath = "\\tsclient\F" Then
            sAyrac = ""
        End If
        Dim z As String = spath & sAyrac & sFile
        Dim DOSYA As New FileInfo(z)
        If DOSYA.Exists Then
            DOSYA.Delete()
        Else
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        'sw.WriteLine(sender)
        'sw.WriteLine("")
        sayi = 0
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Terazi Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > -1 And dr("FIYAT1") < 1000000000 Then
                If IsNumeric(dr("sBarkod")) Then
                    sayi += 1
                    plunumber = degeruzunlukkontrol(sayi, 4)
                    'If sayi < 10 Then
                    '    plunumber = "   "
                    '    plunumber += CStr(sayi)
                    'ElseIf sayi < 100 Then
                    '    plunumber = "  "
                    '    plunumber += CStr(sayi)
                    'ElseIf sayi < 1000 Then
                    '    plunumber = " "
                    '    plunumber += CStr(sayi)
                    'End If
                    Dim barkod = Trim(dr("sBarkod"))
                    Dim barkoduzunluk As Integer
                    If IsDBNull(dr("sBarkod")) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If sFiyatTipi <> 1 Then
                        If dr("lFiyat") = 0 Then
                            satisfiyati = dr("FIYAT1")
                        Else
                            satisfiyati = dr("lFiyat")
                        End If
                    Else
                        satisfiyati = dr("FIYAT1")
                    End If
                    'plu oluþtur
                    If barkoduzunluk = 5 Then
                        If Len(Trim(dr("sBarkod"))) = 5 Then
                            'plu = "027"
                            If Trim(dr("sBirimCinsi1")) = "ADT" Then
                                plu = "28"
                            Else
                                plu = sGramaj
                            End If
                            'plu = sGramaj
                            plu += (dr("sBarkod"))
                            plu += "000000"
                        End If
                        'malincinsi oluþtur
                        malincinsi = "" + UCase(Trim(dr("sAciklama").ToString) + " " + Trim(dr("sRenkAdi").ToString))
                        malincinsi = malincinsi.Replace("Ý", "I")
                        malincinsi = malincinsi.Replace("Þ", "S")
                        malincinsi = malincinsi.Replace("Ç", "C")
                        malincinsi = malincinsi.Replace("Ð", "G")
                        malincinsi = malincinsi.Replace("Ü", "U")
                        malincinsi = malincinsi.Replace("Ö", "O")
                        Dim maluzunluk As Integer = 28
                        Dim muzunluk = Len(malincinsi)
                        If Len(malincinsi) < 28 Then
                            Dim malfark As Integer = maluzunluk - muzunluk
                            Dim i As Integer
                            For i = 1 To malfark
                                malincinsi = malincinsi.Insert(muzunluk, " ")
                            Next
                        Else
                            malincinsi = Microsoft.VisualBasic.Left(malincinsi, 28)
                        End If
                        ''fiyat oluþtur
                        'If Len(Len(Convert.ToString(CType(satisfiyati, Integer)))) < 8 Then
                        '    If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CAS").GetValue("YTL") = "true" Then
                        '        fiyat = FormatNumber(satisfiyati, 2)
                        '        fiyat = fiyat.Replace(".", "")
                        '        fiyat = fiyat.Replace(",", "")
                        '    Else
                        '        fiyat = Convert.ToString(CType(satisfiyati, Integer))
                        '    End If
                        '    'fiyat = dr("FIYAT1")
                        '    Dim fiyatfark As Integer = 8 - Len(fiyat)
                        '    Dim i As Integer
                        '    For i = 1 To fiyatfark
                        '        fiyat = fiyat.insert(0, "0")
                        '    Next
                        'Else
                        '    If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CAS").GetValue("YTL") = "true" Then
                        '        fiyat = FormatNumber(satisfiyati, 2)
                        '        fiyat = fiyat.Replace(".", "")
                        '        fiyat = fiyat.Replace(",", "")
                        '        fiyat = Microsoft.VisualBasic.Left(fiyat, 8)
                        '    Else
                        '        fiyat = Convert.ToString(CType(satisfiyati, Integer))
                        '        fiyat = Microsoft.VisualBasic.Left(fiyat, 8)
                        '    End If
                        'End If
                        fiyat = degeruzunlukkontrol(FormatNumber(satisfiyati, 2).Replace(".", "").Replace(",", ""), 8)
                        'fiyat = sayiuzunlukkontrol(FormatNumber(dr("FIYAT" & sFiyatTipi & ""), 2).Replace(".", "").Replace(",", ""), 8)
                        If bBarkodlu = False Then
                            sw.WriteLine(plunumber & vbTab & malincinsi & vbTab & malincinsi & vbTab & fiyat & vbTab & "0  " & vbTab & "0   " & vbTab & "0" + Trim(dr("sBarkod")) & vbTab & sGramaj & vbTab & "0" & "  " & vbTab)
                        ElseIf bBarkodlu = True Then
                            sw.WriteLine(Right(Trim(dr("sBarkod")), 4) & vbTab & malincinsi & vbTab & malincinsi & vbTab & fiyat & vbTab & "0  " & vbTab & "0   " & vbTab & "0" + Trim(dr("sBarkod")) & vbTab & sGramaj & vbTab & "0" & "  " & vbTab)
                        End If
                    End If
                End If
            Else
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolusturDibal(ByVal path As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        Dim dr As DataRow
        Dim plu As String
        Dim malincinsi As String
        Dim fiyat
        Dim satisfiyati
        Dim plunumber As String = ""
        'If SAVE.ShowDialog = DialogResult.OK Then
        Dim z As String = path & ":" & sFile
        Dim DOSYA As New FileInfo(z)
        If DOSYA.Exists Then
            DOSYA.Delete()
        Else
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        'sw.WriteLine(sender)
        'sw.WriteLine("")
        sayi = 0
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Terazi Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 And dr("FIYAT1") < 1000000000 Then
                If IsNumeric(dr("sBarkod")) Then
                    sayi += 1
                    plunumber = sayiuzunlukkontrol(sayi, 4)
                    'If sayi < 10 Then
                    '    plunumber = "   "
                    '    plunumber += CStr(sayi)
                    'ElseIf sayi < 100 Then
                    '    plunumber = "  "
                    '    plunumber += CStr(sayi)
                    'ElseIf sayi < 1000 Then
                    '    plunumber = " "
                    '    plunumber += CStr(sayi)
                    'End If
                    Dim barkod = Trim(dr("sBarkod"))
                    Dim barkoduzunluk As Integer
                    If IsDBNull(dr("sBarkod")) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If sFiyatTipi <> 1 Then
                        If dr("lFiyat") = 0 Then
                            satisfiyati = dr("FIYAT1")
                        Else
                            satisfiyati = dr("lFiyat")
                        End If
                    Else
                        satisfiyati = dr("FIYAT1")
                    End If
                    'plu oluþtur
                    If barkoduzunluk = 5 Then
                        If Len(Trim(dr("sBarkod"))) = 5 Then
                            'plu = "027"
                            plu = sGramaj
                            plu += (dr("sBarkod"))
                            plu += "000000"
                        End If
                        'malincinsi oluþtur
                        malincinsi = "" + UCase(dr("sAciklama") + " " + dr("sRenkAdi"))
                        malincinsi = malincinsi.Replace("Ý", "I")
                        malincinsi = malincinsi.Replace("Þ", "S")
                        malincinsi = malincinsi.Replace("Ç", "C")
                        malincinsi = malincinsi.Replace("Ð", "G")
                        malincinsi = malincinsi.Replace("Ü", "U")
                        malincinsi = malincinsi.Replace("Ö", "O")
                        Dim maluzunluk As Integer = 28
                        Dim muzunluk = Len(malincinsi)
                        If Len(malincinsi) < 28 Then
                            Dim malfark As Integer = maluzunluk - muzunluk
                            Dim i As Integer
                            For i = 1 To malfark
                                malincinsi = malincinsi.Insert(muzunluk, " ")
                            Next
                        Else
                            malincinsi = Microsoft.VisualBasic.Left(malincinsi, 28)
                        End If
                        ''fiyat oluþtur
                        'If Len(Len(Convert.ToString(CType(satisfiyati, Integer)))) < 8 Then
                        '    If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CAS").GetValue("YTL") = "true" Then
                        '        fiyat = FormatNumber(satisfiyati, 2)
                        '        fiyat = fiyat.Replace(".", "")
                        '        fiyat = fiyat.Replace(",", "")
                        '    Else
                        '        fiyat = Convert.ToString(CType(satisfiyati, Integer))
                        '    End If
                        '    'fiyat = dr("FIYAT1")
                        '    Dim fiyatfark As Integer = 8 - Len(fiyat)
                        '    Dim i As Integer
                        '    For i = 1 To fiyatfark
                        '        fiyat = fiyat.insert(0, "0")
                        '    Next
                        'Else
                        '    If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CAS").GetValue("YTL") = "true" Then
                        '        fiyat = FormatNumber(satisfiyati, 2)
                        '        fiyat = fiyat.Replace(".", "")
                        '        fiyat = fiyat.Replace(",", "")
                        '        fiyat = Microsoft.VisualBasic.Left(fiyat, 8)
                        '    Else
                        '        fiyat = Convert.ToString(CType(satisfiyati, Integer))
                        '        fiyat = Microsoft.VisualBasic.Left(fiyat, 8)
                        '    End If
                        'End If
                        fiyat = sayiuzunlukkontrol(FormatNumber(dr("FIYAT" & sFiyatTipi & ""), 2).Replace(".", "").Replace(",", ""), 8)
                        'fiyat = sayiuzunlukkontrol(FormatNumber(dr("FIYAT" & sFiyatTipi & ""), 2).Replace(".", "").Replace(",", ""), 8)
                        sw.WriteLine(plunumber & vbTab & malincinsi & vbTab & malincinsi & vbTab & fiyat & vbTab & "0  " & vbTab & "0   " & vbTab & "0" + Trim(dr("sBarkod")) & vbTab & sGramaj & vbTab & "0" & "  " & vbTab)
                    End If
                End If
            Else
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolusturCASLP15R(ByVal spath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        Dim dr As DataRow
        Dim plu As String = ""
        Dim malincinsi As String = ""
        Dim fiyat
        Dim satisfiyati
        Dim plunumber As String = ""
        Dim s As String
        Dim sAyrac As String = ":"
        If sPath = "\\tsclient\C" Or sPath = "\\tsclient\D" Or sPath = "\\tsclient\E" Or sPath = "\\tsclient\F" Then
            sAyrac = ""
        End If
        Dim z As String = spath & sAyrac & sFile
        Dim DOSYA As New FileInfo(z)
        If DOSYA.Exists Then
            DOSYA.Delete()
        Else
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        'sw.WriteLine(sender)
        'sw.WriteLine("")
        sayi = 0
        s = ""
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Terazi Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 And dr("FIYAT1") < 1000000000 Then
                If IsNumeric(dr("sBarkod")) Then
                    sayi += 1
                    If sayi < 10 Then
                        plunumber = "   "
                        plunumber += CStr(sayi)
                    ElseIf sayi < 100 Then
                        plunumber = "  "
                        plunumber += CStr(sayi)
                    ElseIf sayi < 1000 Then
                        plunumber = " "
                        plunumber += CStr(sayi)
                    End If
                    Dim barkod = Trim(dr("sBarkod"))
                    Dim barkoduzunluk As Integer
                    If IsDBNull(dr("sBarkod")) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If sFiyatTipi <> 1 Then
                        If dr("lFiyat") = 0 Then
                            satisfiyati = dr("FIYAT1")
                        Else
                            satisfiyati = dr("lFiyat")
                        End If
                    Else
                        satisfiyati = dr("FIYAT1")
                    End If
                    'plu oluþtur
                    If barkoduzunluk = 5 Then
                        If Len(Trim(dr("sBarkod"))) = 5 Then
                            'plu = "027"
                            'plu = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CAS").GetValue("GRAMAJFLAG")
                            plu = ""
                            plu += (Trim(dr("sBarkod")))
                        End If
                        'malincinsi oluþtur
                        malincinsi = UCase(dr("sAciklama") + " " + dr("sRenkAdi"))
                        malincinsi = malincinsi.Replace("Ý", "I")
                        malincinsi = malincinsi.Replace("Þ", "S")
                        malincinsi = malincinsi.Replace("Ç", "C")
                        malincinsi = malincinsi.Replace("Ð", "G")
                        malincinsi = malincinsi.Replace("Ü", "U")
                        malincinsi = malincinsi.Replace("Ö", "O")
                        Dim maluzunluk As Integer = 56
                        Dim muzunluk = Len(malincinsi)
                        If Len(malincinsi) < 56 Then
                            Dim malfark As Integer = maluzunluk - muzunluk
                            Dim i As Integer
                            For i = 1 To malfark
                                malincinsi = malincinsi.Insert(muzunluk, " ")
                            Next
                        Else
                            malincinsi = Microsoft.VisualBasic.Left(malincinsi, 56)
                        End If
                        fiyat = sayiuzunlukkontrol(FormatNumber(satisfiyati, 2).Replace(".", "").Replace(",", ""), 7)
                        'sw.WriteLine(plunumber & vbTab & malincinsi & vbTab & malincinsi & vbTab & fiyat & vbTab & "  0" & vbTab & "   0" & vbTab & "0" + dr("sBarkod") & vbTab & "00" & vbTab & "  0" & vbTab)
                        s += plunumber & malincinsi & fiyat & "0" & "  " & 0 & "   0" & plu & 0 & " 000"
                    End If
                End If
            Else
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.WriteLine(s)
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolusturOLIVETTILP15(ByVal path As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        Dim dr As DataRow
        Dim plu As String = ""
        Dim malincinsi As String = ""
        Dim fiyat
        Dim satisfiyati
        Dim plunumber As String = ""
        'If SAVE.ShowDialog = DialogResult.OK Then
        Dim z As String = path & ":" & sFile
        If z = "" Then
            z = "c:\terazi\terazi.plu"
        End If
        Dim DOSYA As New FileInfo(z)
        If DOSYA.Exists Then
            DOSYA.Delete()
        Else
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        'sw.WriteLine(sender)
        'sw.WriteLine("")
        Dim sayi As Integer = 0
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Terazi Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        sayi = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 And dr("FIYAT1") < 1000000000 Then
                If IsNumeric(dr("sBarkod")) Then
                    sayi += 1
                    If sayi < 10 Then
                        plunumber = "   "
                        plunumber += CStr(sayi)
                    ElseIf sayi < 100 Then
                        plunumber = "  "
                        plunumber += CStr(sayi)
                    ElseIf sayi < 1000 Then
                        plunumber = " "
                        plunumber += CStr(sayi)
                    End If
                    Dim barkod = Trim(dr("sBarkod"))
                    Dim barkoduzunluk As Integer
                    If IsDBNull(dr("sBarkod")) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If sFiyatTipi <> 1 Then
                        If dr("lFiyat") = 0 Then
                            satisfiyati = dr("FIYAT1")
                        Else
                            satisfiyati = dr("lFiyat")
                        End If
                    Else
                        satisfiyati = dr("FIYAT1")
                    End If
                    'plu oluþtur
                    If barkoduzunluk = 5 Then
                        If Len(Trim(dr("sBarkod"))) = 5 Then
                            'plu = "027"
                            plu = sGramaj
                            plu += (Trim(dr("sBarkod")))
                            plu += "000000"
                        End If
                        'malincinsi oluþtur
                        malincinsi = "" + UCase(dr("sAciklama"))
                        malincinsi = malincinsi.Replace("Ý", "I")
                        malincinsi = malincinsi.Replace("Þ", "S")
                        malincinsi = malincinsi.Replace("Ç", "C")
                        malincinsi = malincinsi.Replace("Ð", "G")
                        malincinsi = malincinsi.Replace("Ü", "U")
                        malincinsi = malincinsi.Replace("Ö", "O")
                        Dim maluzunluk As Integer = 28
                        Dim muzunluk = Len(malincinsi)
                        If Len(malincinsi) < 28 Then
                            Dim malfark As Integer = maluzunluk - muzunluk
                            Dim i As Integer
                            For i = 1 To malfark
                                malincinsi = malincinsi.Insert(muzunluk, " ")
                            Next
                        Else
                            malincinsi = Microsoft.VisualBasic.Left(malincinsi, 28)
                        End If
                        ''fiyat oluþtur
                        'If Len(Len(Convert.ToString(CType(satisfiyati, Integer)))) < 8 Then
                        '    If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CAS").GetValue("YTL") = "true" Then
                        '        fiyat = FormatNumber(satisfiyati, 2)
                        '        fiyat = fiyat.Replace(".", "")
                        '        fiyat = fiyat.Replace(",", "")
                        '    Else
                        '        fiyat = Convert.ToString(CType(satisfiyati, Integer))
                        '    End If
                        '    'fiyat = dr("FIYAT1")
                        '    Dim fiyatfark As Integer = 8 - Len(fiyat)
                        '    Dim i As Integer
                        '    For i = 1 To fiyatfark
                        '        fiyat = fiyat.insert(0, "0")
                        '    Next
                        'Else
                        '    If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CAS").GetValue("YTL") = "true" Then
                        '        fiyat = FormatNumber(satisfiyati, 2)
                        '        fiyat = fiyat.Replace(".", "")
                        '        fiyat = fiyat.Replace(",", "")
                        '        fiyat = Microsoft.VisualBasic.Left(fiyat, 8)
                        '    Else
                        '        fiyat = Convert.ToString(CType(satisfiyati, Integer))
                        '        fiyat = Microsoft.VisualBasic.Left(fiyat, 8)
                        '    End If
                        'End If
                        fiyat = sayiuzunlukkontrol(FormatNumber(dr("FIYAT" & sFiyatTipi & ""), 2).Replace(".", "").Replace(",", ""), 8)
                        sw.WriteLine(plunumber & vbTab & malincinsi & vbTab & malincinsi & vbTab & fiyat & vbTab & "  0" & vbTab & "   0" & vbTab & "0" + dr("sBarkod") & vbTab & "00" & vbTab & "  0" & vbTab)
                    End If
                End If
            Else
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolusturishida(ByVal spath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String, Optional ByVal bToledo As Boolean = False)
        Dim dr As DataRow
        Dim plu As String = ""
        Dim malincinsi As String = ""
        Dim fiyat
        Dim satisfiyati = ""
        Dim sAyrac As String = ":"
        If spath = "\\tsclient\C" Or spath = "\\tsclient\D" Or spath = "\\tsclient\E" Or spath = "\\tsclient\F" Then
            sAyrac = ""
        End If
        'If SAVE.ShowDialog = DialogResult.OK Then
        Dim z As String = spath & sAyrac & sFile
        Dim DOSYA As New FileInfo(z)
        If DOSYA.Exists Then
            DOSYA.Delete()
        Else
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        'sw.WriteLine(sender)
        'sw.WriteLine("")
        sayi = 0
        SplashScreenManager.ShowForm(GetType(WaitForm1), False, True)
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Terazi Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 And dr("FIYAT1") < 1000000000 Then
                If IsNumeric(dr("sBarkod")) Then
                    Dim barkod = Trim(dr("sBarkod"))
                    Dim barkoduzunluk As Integer
                    If IsDBNull(dr("sBarkod")) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If sFiyatTipi <> 1 Then
                        If dr("lFiyat") = 0 Then
                            satisfiyati = dr("FIYAT1")
                        Else
                            satisfiyati = dr("lFiyat")
                        End If
                    Else
                        satisfiyati = dr("FIYAT1")
                    End If
                    'plu oluþtur
                    If barkoduzunluk = 5 Then
                        If Len(Trim(dr("sBarkod"))) = 5 Then
                            If Trim(dr("sBirimCinsi1")) = "ADT" Then
                                plu = "028"
                            Else
                                plu = sGramaj
                            End If
                            'plu = "027"
                            'plu = sGramaj
                            plu += (Trim(dr("sBarkod")))
                            plu += "000000"
                        End If
                        'malincinsi oluþtur
                        malincinsi = " " + UCase(Trim(dr("sAciklama").ToString))
                        If Trim(dr("sRenkAdi").ToString) <> "" And Trim(dr("sBeden")) = "" Then
                            malincinsi = " " + UCase(Microsoft.VisualBasic.Left(Trim(dr("sAciklama").ToString), 10)) + "\" + Microsoft.VisualBasic.Left(Trim(dr("sRenkAdi")), 10)
                        ElseIf Trim(dr("sRenkAdi").ToString) <> "" And Trim(dr("sBeden")) <> "" Then
                            malincinsi = " " + UCase(Microsoft.VisualBasic.Left(Trim(dr("sAciklama").ToString), 10)) + "\" + Microsoft.VisualBasic.Left(Trim(dr("sRenkAdi")), 10) + "\" + Microsoft.VisualBasic.Left(Trim(dr("sBeden")), 3)
                        End If
                        'malincinsi = " " + UCase(dr("sAciklama"))
                        malincinsi = malincinsi.Replace("Ý", "I")
                        malincinsi = malincinsi.Replace("Þ", "S")
                        malincinsi = malincinsi.Replace("Ç", "C")
                        malincinsi = malincinsi.Replace("Ð", "G")
                        malincinsi = malincinsi.Replace("Ü", "U")
                        malincinsi = malincinsi.Replace("Ö", "O")
                        Dim maluzunluk As Integer = 25
                        Dim muzunluk = Len(malincinsi)
                        If Len(malincinsi) < 25 Then
                            Dim malfark As Integer = maluzunluk - muzunluk
                            Dim i As Integer
                            For i = 1 To malfark
                                malincinsi = malincinsi.Insert(muzunluk, " ")
                            Next
                        Else
                            malincinsi = Microsoft.VisualBasic.Left(malincinsi, 25)
                        End If
                        'fiyat oluþtur
                        'If Len(Len(Convert.ToString(CType(dr("FIYAT1"), Integer)))) < 8 Then
                        '    fiyat = Convert.ToString(CType(dr("FIYAT1"), Integer))
                        '    Dim fiyatfark As Integer = 8 - Len(fiyat)
                        '    Dim i As Integer
                        '    For i = 1 To fiyatfark
                        '        fiyat = fiyat.insert(0, "0")
                        '    Next
                        'Else
                        '    fiyat = Convert.ToString(CType(dr("FIYAT1"), Integer))
                        '    fiyat = Microsoft.VisualBasic.Left(fiyat, 8)
                        'End If
                        'If Len(Len(Convert.ToString(CType(satisfiyati, Integer)))) < 8 Then
                        '    If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("ISHIDA").GetValue("YTL") = "true" Then
                        '        fiyat = FormatNumber(satisfiyati, 2)
                        '        fiyat = fiyat.Replace(".", "")
                        '        fiyat = fiyat.Replace(",", "")
                        '    Else
                        '        fiyat = Convert.ToString(CType(satisfiyati, Integer))
                        '    End If
                        '    'fiyat = dr("FIYAT1")
                        '    Dim fiyatfark As Integer = 8 - Len(fiyat)
                        '    Dim i As Integer
                        '    For i = 1 To fiyatfark
                        '        fiyat = fiyat.insert(0, "0")
                        '    Next
                        'Else
                        '    If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("ISHIDA").GetValue("YTL") = "true" Then
                        '        fiyat = FormatNumber(satisfiyati, 2)
                        '        fiyat = fiyat.Replace(".", "")
                        '        fiyat = fiyat.Replace(",", "")
                        '        fiyat = Microsoft.VisualBasic.Left(fiyat, 8)
                        '    Else
                        '        fiyat = Convert.ToString(CType(satisfiyati, Integer))
                        '        fiyat = Microsoft.VisualBasic.Left(fiyat, 8)
                        '    End If
                        'End If
                        fiyat = sayiuzunlukkontrol(FormatNumber(satisfiyati, 2).Replace(".", "").Replace(",", ""), 8)
                        If bToledo = False Then
                            sw.WriteLine(plu & " " & malincinsi & fiyat)
                        ElseIf bToledo = True Then
                            sw.WriteLine(plu & " " & malincinsi & fiyat & " " & barkod)
                        End If
                        sayi += 1
                    End If
                End If
            Else
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
        SplashScreenManager.CloseForm()
    End Sub
    Private Sub dosyaolustur_bizerba(ByVal path As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        Dim dr As DataRow
        Dim plu As String = ""
        Dim malincinsi As String = ""
        Dim fiyat
        Dim satisfiyati = ""
        'If SAVE.ShowDialog = DialogResult.OK Then
        Dim z As String = path & ":" & sFile 'SAVE.FileName.ToString
        Dim DOSYA As New FileInfo(z)
        If DOSYA.Exists Then
            DOSYA.Delete()
        Else
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        'sw.WriteLine(sender)
        'sw.WriteLine("")
        sayi = 0
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Terazi Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 And dr("FIYAT1") < 1000 Then
                If IsNumeric(dr("sBarkod")) Then
                    Dim barkod = Trim(dr("sBarkod"))
                    Dim barkoduzunluk As Integer
                    If IsDBNull(dr("sBarkod")) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If sFiyatTipi <> 1 Then
                        If dr("lFiyat") = 0 Then
                            satisfiyati = dr("FIYAT1")
                        Else
                            satisfiyati = dr("lFiyat")
                        End If
                    Else
                        satisfiyati = dr("FIYAT1")
                    End If
                    'plu oluþtur
                    If barkoduzunluk = 5 Then
                        If Len(Trim(dr("sBarkod"))) = 5 Then
                            'plu = "027"
                            plu = sGramaj
                            plu += (dr("sBarkod"))
                            plu += "000000"
                        End If
                        'malincinsi oluþtur
                        malincinsi = " " + UCase(dr("sAciklama"))
                        malincinsi = malincinsi.Replace("Ý", "I")
                        malincinsi = malincinsi.Replace("Þ", "S")
                        malincinsi = malincinsi.Replace("Ç", "C")
                        malincinsi = malincinsi.Replace("Ð", "G")
                        malincinsi = malincinsi.Replace("Ü", "U")
                        malincinsi = malincinsi.Replace("Ö", "O")
                        Dim maluzunluk As Integer = 25
                        Dim muzunluk = Len(malincinsi)
                        If Len(malincinsi) < 25 Then
                            Dim malfark As Integer = maluzunluk - muzunluk
                            Dim i As Integer
                            For i = 1 To malfark
                                malincinsi = malincinsi.Insert(muzunluk, " ")
                            Next
                        Else
                            malincinsi = Microsoft.VisualBasic.Left(malincinsi, 25)
                        End If
                        'fiyat oluþtur
                        'If Len(Len(Convert.ToString(CType(dr("FIYAT1"), Integer)))) < 8 Then
                        '    fiyat = Convert.ToString(CType(dr("FIYAT1"), Integer))
                        '    Dim fiyatfark As Integer = 8 - Len(fiyat)
                        '    Dim i As Integer
                        '    For i = 1 To fiyatfark
                        '        fiyat = fiyat.insert(0, "0")
                        '    Next
                        'Else
                        '    fiyat = Convert.ToString(CType(dr("FIYAT1"), Integer))
                        '    fiyat = Microsoft.VisualBasic.Left(fiyat, 8)
                        'End If
                        'If Len(Len(Convert.ToString(CType(dr("FIYAT1"), Integer)))) < 8 Then
                        '    If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("ISHIDA").GetValue("YTL") = "true" Then
                        '        fiyat = FormatNumber(dr("FIYAT1"), 2)
                        '        fiyat = fiyat.Replace(".", "")
                        '        fiyat = fiyat.Replace(",", "")
                        '    Else
                        '        fiyat = Convert.ToString(CType(dr("FIYAT1"), Integer))
                        '    End If
                        '    'fiyat = dr("FIYAT1")
                        '    Dim fiyatfark As Integer = 8 - Len(fiyat)
                        '    Dim i As Integer
                        '    For i = 1 To fiyatfark
                        '        fiyat = fiyat.insert(0, "0")
                        '    Next
                        'Else
                        '    If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("ISHIDA").GetValue("YTL") = "true" Then
                        '        fiyat = FormatNumber(dr("FIYAT1"), 2)
                        '        fiyat = fiyat.Replace(".", "")
                        '        fiyat = fiyat.Replace(",", "")
                        '        fiyat = Microsoft.VisualBasic.Left(fiyat, 8)
                        '    Else
                        '        fiyat = Convert.ToString(CType(dr("FIYAT1"), Integer))
                        '        fiyat = Microsoft.VisualBasic.Left(fiyat, 8)
                        '    End If
                        'End If
                        fiyat = sayiuzunlukkontrol(FormatNumber(satisfiyati, 2).Replace(".", "").Replace(",", ""), 8)
                        sw.WriteLine(plu & " " & malincinsi & fiyat)
                        sayi += 1
                    End If
                End If
            Else
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolustur_AveryBarkel(ByVal path As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        Dim dr As DataRow
        Dim nStokID As String = ""
        Dim plu As String = ""
        Dim malincinsi As String = ""
        Dim fiyat
        Dim satisfiyati = ""
        'If SAVE.ShowDialog = DialogResult.OK Then
        Dim z As String = path & ":" & sFile 'SAVE.FileName.ToString
        Dim DOSYA As New FileInfo(z)
        If DOSYA.Exists Then
            DOSYA.Delete()
        Else
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        'sw.WriteLine(sender)
        'sw.WriteLine("")
        sayi = 0
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Terazi Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 And dr("FIYAT1") < 1000 Then
                If IsNumeric(dr("sBarkod")) Then
                    Dim barkod = Trim(dr("sBarkod"))
                    Dim barkoduzunluk As Integer
                    If IsDBNull(dr("sBarkod")) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If sFiyatTipi <> 1 Then
                        If dr("lFiyat") = 0 Then
                            satisfiyati = dr("FIYAT1")
                        Else
                            satisfiyati = dr("lFiyat")
                        End If
                    Else
                        satisfiyati = dr("FIYAT1")
                    End If
                    'plu oluþtur
                    If barkoduzunluk = 5 Then
                        If Len(Trim(dr("sBarkod"))) = 5 Then
                            'plu = "027"
                            plu = sGramaj
                            plu += (Trim(dr("sBarkod")))
                            plu += "        "
                        End If
                        'malincinsi oluþtur
                        malincinsi = UCase(dr("sAciklama"))
                        malincinsi = malincinsi.Replace("Ý", "I")
                        malincinsi = malincinsi.Replace("Þ", "S")
                        malincinsi = malincinsi.Replace("Ç", "C")
                        malincinsi = malincinsi.Replace("Ð", "G")
                        malincinsi = malincinsi.Replace("Ü", "U")
                        malincinsi = malincinsi.Replace("Ö", "O")
                        Dim maluzunluk As Integer = 50
                        Dim muzunluk = Len(malincinsi)
                        If Len(malincinsi) < 50 Then
                            Dim malfark As Integer = maluzunluk - muzunluk
                            Dim i As Integer
                            For i = 1 To malfark
                                malincinsi = malincinsi.Insert(muzunluk, " ")
                            Next
                        Else
                            malincinsi = Microsoft.VisualBasic.Left(malincinsi, 50)
                        End If
                        nStokID = degeruzunlukkontrol(Right(dr("nStokID"), 9), 9)
                        fiyat = sayiuzunlukkontrol_deger(FormatNumber(satisfiyati, 2), 12, " ")
                        fiyat = fiyat.Replace(",", "")
                        fiyat = fiyat.Replace(".", ",")
                        sw.WriteLine(nStokID & ":" & plu & ":" & malincinsi & ":" & fiyat)
                        sayi += 1
                    End If
                End If
            Else
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolusturDIGISM80(ByVal path As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        Dim dr As DataRow
        Dim plu As String = ""
        Dim malincinsi As String = ""
        Dim fiyat
        Dim satisfiyati
        Dim z As String = path & ":" & sFile 'SAVE.FileName.ToString
        'Dim z As String = InputBox("Terazi Dosyasý Konumu ve Adý", "Terazi Dosyasý", "" & terazipath & "") 'SAVE.FileName.ToString
        'If z = "" Then
        '    z = "c:\SM80\BRKDPLU"
        'End If
        Dim DOSYA As New FileInfo(z)
        If DOSYA.Exists Then
            DOSYA.Delete()
        Else
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        sayi = 0
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Terazi Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 And dr("FIYAT1") < 1000000000 Then
                If IsNumeric(dr("sBarkod")) Then
                    Dim barkod = Trim(dr("sBarkod"))
                    Dim barkoduzunluk As Integer
                    If IsDBNull(dr("sBarkod")) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If sFiyatTipi <> 1 Then
                        If dr("lFiyat") = 0 Then
                            satisfiyati = dr("FIYAT1")
                        Else
                            satisfiyati = dr("lFiyat")
                        End If
                    Else
                        satisfiyati = dr("FIYAT1")
                    End If
                    'plu oluþtur
                    If barkoduzunluk = 5 Then
                        If Len(Trim(dr("sBarkod"))) = 5 Then
                            'plu = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("ISHIDA").GetValue("GRAMAJFLAG").substring(1, 2)
                            'plu += (dr("sBarkod"))
                            plu = sGramaj
                            plu += (Trim(dr("sBarkod")))
                            plu += "0000001"
                        End If
                        'malincinsi oluþtur
                        malincinsi = UCase(dr("sAciklama") + " " + dr("sRenkAdi"))
                        malincinsi = malincinsi.Replace("Ý", "I")
                        malincinsi = malincinsi.Replace("Þ", "S")
                        malincinsi = malincinsi.Replace("Ç", "C")
                        malincinsi = malincinsi.Replace("Ð", "G")
                        malincinsi = malincinsi.Replace("Ü", "U")
                        malincinsi = malincinsi.Replace("Ö", "O")
                        malincinsi = malincinsi + " "
                        'Dim maluzunluk As Integer = 15
                        'Dim muzunluk = Len(malincinsi)
                        'If Len(malincinsi) < 15 Then
                        '    Dim malfark As Integer = maluzunluk - muzunluk
                        '    Dim i As Integer
                        '    For i = 1 To malfark
                        '        malincinsi = malincinsi.Insert(muzunluk, " ")
                        '    Next
                        'Else
                        '    malincinsi = Microsoft.VisualBasic.Left(malincinsi, 15)
                        'End If
                        'fiyat oluþtur
                        fiyat = FormatNumber(satisfiyati, 2)
                        fiyat = fiyat.Replace(".", "")
                        fiyat = fiyat.Replace(",", "")
                        'satir oluþtur
                        sayi += 1
                        Dim satir As String = ""
                        If sayi < 10 Then
                            satir = "0000" + sayi.ToString
                        ElseIf sayi < 100 Then
                            satir = "000" + sayi.ToString
                        ElseIf sayi < 1000 Then
                            satir = "00" + sayi.ToString
                        ElseIf sayi < 10000 Then
                            satir = "0" + sayi.ToString
                        End If
                        sw.WriteLine("WHFA" & satir & vbTab & "B" & fiyat & vbTab & "C17" & vbTab & "E5" & vbTab & "F" & plu & vbTab & "G997" & vbTab & "H000" & vbTab & "K000" & vbTab & "Q7400" & vbTab)
                        sw.WriteLine("WHHA" & satir & vbTab & "B1" & vbTab & "C7" & vbTab & "D" & malincinsi & vbTab)
                    End If
                End If
            Else
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
        XtraMessageBox.Show(Sorgu_sDil("Terazi Dosyasý Oluþturuldu  : ", sDil) & z, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        If XtraMessageBox.Show(Sorgu_sDil("Teraziye Göndermek Ýstiyormusunuz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            'Dim path = "C:\SM80\GONDER.BAT"
            'Process.Start(path)
            Dim g As String = "C:\SM80\brkdtransfer.bat"
            Dim DOSYA1 As New FileInfo(g)
            If DOSYA1.Exists Then
                DOSYA1.Delete()
            End If
            Dim sg As StreamWriter = File.AppendText(g)
            sg.WriteLine("@echo off")
            sg.WriteLine("ECHO LUTFEN ISLEMIN BITMESINI BEKLEYINIZ...!")
            sg.WriteLine("ECHO Toplam Gonderilecek Urun Sayisi :" & sayi & "")
            sg.WriteLine("C:")
            sg.WriteLine("cd\SM80")
            sg.WriteLine("FIS3D S3 02:01 terazi")
            sg.WriteLine("DEL COMLOG")
            sg.WriteLine("MD POS")
            sg.Close()
            Process.Start("C:\SM80\brkdtransfer.bat")
        End If
    End Sub
    Private Sub dosyaolusturNCR()
        Dim dr As DataRow
        Dim ncrstokkodu
        Dim ncrmalincinsi
        Dim ncrbarcode
        Dim ncrfiyat
        Dim ncrdepartman As String = ""
        Dim ncrbarcodestd
        Dim i As Integer
        Dim z As String = "c:\Formlar\database\CONDTIMP.DAT"
        Dim dosya As New FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        sayi = 0
        Dim sw As StreamWriter = File.AppendText(z)
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "NCR Stok Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 Then
                If IsNumeric(dr("sBarkod")) Then
                    Dim barkod = Trim(dr("sBarkod"))
                    Dim barkoduzunluk As Integer
                    If IsDBNull(dr("sBarkod")) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If barkoduzunluk >= 5 Then
                        'ürün adi oluþtur
                        ncrmalincinsi = UCase(dr("sAciklama"))
                        ncrmalincinsi = ncrmalincinsi.Replace("Ý", "I")
                        ncrmalincinsi = ncrmalincinsi.Replace("Þ", "S")
                        ncrmalincinsi = ncrmalincinsi.Replace("Ç", "C")
                        ncrmalincinsi = ncrmalincinsi.Replace("Ð", "G")
                        ncrmalincinsi = ncrmalincinsi.Replace("Ü", "U")
                        ncrmalincinsi = ncrmalincinsi.Replace("Ö", "O")
                        Dim maluzunluk As Integer = 20
                        Dim muzunluk = Len(ncrmalincinsi)
                        If Len(ncrmalincinsi) < 20 Then
                            Dim malfark As Integer = maluzunluk - muzunluk
                            For i = 1 To malfark
                                ncrmalincinsi = ncrmalincinsi.Insert(muzunluk, " ")
                            Next
                        Else
                            ncrmalincinsi = Microsoft.VisualBasic.Left(ncrmalincinsi, 20)
                        End If
                        'stokkodu oluþtur
                        ncrstokkodu = UCase(dr("sKodu"))
                        ncrmalincinsi = ncrmalincinsi.Replace("Ý", "I")
                        ncrmalincinsi = ncrmalincinsi.Replace("Þ", "S")
                        ncrmalincinsi = ncrmalincinsi.Replace("Ç", "C")
                        ncrmalincinsi = ncrmalincinsi.Replace("Ð", "G")
                        ncrmalincinsi = ncrmalincinsi.Replace("Ü", "U")
                        ncrmalincinsi = ncrmalincinsi.Replace("Ö", "O")
                        Dim STOKuzunluk As Integer = 20
                        Dim STuzunluk = Len(ncrstokkodu)
                        If Len(ncrstokkodu) < 20 Then
                            Dim STOKfark As Integer = STOKuzunluk - STuzunluk
                            For i = 1 To STOKfark
                                ncrstokkodu = ncrstokkodu.Insert(STuzunluk, " ")
                            Next
                        Else
                            ncrstokkodu = Microsoft.VisualBasic.Left(ncrstokkodu, 20)
                        End If
                        'fiyatoluþtur
                        ncrfiyat = FormatNumber(dr("FIYAT1"), 2)
                        ncrfiyat = ncrfiyat.Replace(".", "")
                        ncrfiyat = ncrfiyat.Replace(",", "")
                        Dim fiyatfark As Integer = 12 - Len(ncrfiyat)
                        For i = 1 To fiyatfark
                            ncrfiyat = ncrfiyat.insert(0, "0")
                        Next
                        'barcode oluþtur
                        ncrbarcode = Trim(dr("sBarkod"))
                        Dim barkodfark As Integer = 21 - Len(ncrbarcode)
                        For i = 1 To barkodfark
                            ncrbarcode = ncrbarcode.insert(0, "0")
                        Next
                        'barcode standardý
                        If Len(Trim(dr("sBarkod"))) = 5 Then
                            ncrbarcodestd = 1
                        Else
                            ncrbarcodestd = 0
                        End If
                        'departman
                        If dr("nKdvOrani") = 0 Then
                            ncrdepartman = 1
                        ElseIf dr("nKdvOrani") = 1 Then
                            ncrdepartman = 2
                        ElseIf dr("nKdvOrani") = 8 Then
                            ncrdepartman = 3
                        ElseIf dr("nKdvOrani") = 18 Then
                            ncrdepartman = 4
                        End If
                        'dosyoya yaz
                        sw.WriteLine("10" & ncrstokkodu & ncrmalincinsi & ncrbarcode & "0000000000000000000000000000000000000000000000000000000000000000000000000000000000000")
                        sw.WriteLine("2" & ncrmalincinsi & "                              " & ncrfiyat & "000000000.00000000000.00000000000.000000000011110001000100010" & ncrdepartman & "" & ncrbarcodestd & "0000000000110000000000")
                        sayi += 1
                    End If
                End If
            End If
            nIndex = nIndex + 1
            'Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolustur_sayim(ByVal path As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        Dim dr As DataRow
        Dim ncrstokkodu
        Dim ncrmalincinsi
        Dim ncrbarcode
        Dim ncrfiyat
        Dim satisfiyati
        Dim ncrbarcodestd
        Dim i As Integer
        Dim z As String = path & ":" & sFile
        Dim dosya As New FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        sayi = 0
        Dim sw As StreamWriter = File.AppendText(z)
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Sayým Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 Then
                If IsNumeric(Trim(dr("sBarkod").ToString)) Then
                    Dim barkod = Trim(dr("sBarkod").ToString)
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If barkoduzunluk >= 5 Then
                        'ürün adi oluþtur
                        ncrmalincinsi = UCase(Trim(dr("sAciklama").ToString))
                        ncrmalincinsi = degeruzunlukkontrol(ncrmalincinsi, 12)
                        'stokkodu oluþtur
                        ncrstokkodu = UCase(Trim(dr("sKodu").ToString))
                        ncrstokkodu = degeruzunlukkontrol(ncrstokkodu, 20)
                        'fiyatoluþtur
                        If sFiyatTipi <> 1 Then
                            If dr("lFiyat") = 0 Then
                                satisfiyati = dr("FIYAT1")
                            Else
                                satisfiyati = dr("lFiyat")
                            End If
                        Else
                            satisfiyati = dr("FIYAT1")
                        End If
                        ncrfiyat = FormatNumber(satisfiyati, 2)
                        'ncrfiyat = ncrfiyat.Replace(".", ".")
                        'ncrfiyat = ncrfiyat.Replace(",", "")
                        Dim fiyatfark As Integer = 10 - Len(ncrfiyat)
                        For i = 1 To fiyatfark
                            ncrfiyat = ncrfiyat.insert(0, " ")
                        Next
                        'barcode oluþtur
                        ncrbarcode = barkod
                        ncrbarcode = degeruzunlukkontrol(ncrbarcode, 14)
                        'barcode standardý
                        If Len(Trim(dr("sBarkod"))) = 5 Then
                            ncrbarcodestd = 1
                        Else
                            ncrbarcodestd = 0
                        End If
                        'dosyoya yaz
                        sw.WriteLine(ncrbarcode & ncrmalincinsi & " " & ncrfiyat)
                        'sw.WriteLine("10" & ncrstokkodu & ncrmalincinsi & ncrbarcode & "0000000000000000000000000000000000000000000000000000000000000000000000000000000000000")
                        'sw.WriteLine("2" & ncrmalincinsi & "                              " & ncrfiyat & "000000000.00000000000.00000000000.000000000011110001000100010" & ncrdepartman & "" & ncrbarcodestd & "0000000000110000000000")
                        sayi += 1
                    End If
                End If
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolustur_sayim_PSC(ByVal path As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        Dim dr As DataRow
        Dim ncrstokkodu
        Dim ncrmalincinsi
        Dim ncrbarcode
        Dim ncrfiyat
        Dim satisfiyati
        Dim ncrbarcodestd
        Dim i As Integer
        Dim z As String = path & ":" & sFile
        Dim dosya As New FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        sayi = 0
        Dim sw As StreamWriter = File.AppendText(z)
        sw.WriteLine("")
        sw.WriteLine("")
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Terminal Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 Then
                If IsNumeric(Trim(dr("sBarkod").ToString)) Then
                    Dim barkod = Trim(dr("sBarkod").ToString)
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    dr("lFiyat") = sorgu_sayi(dr("lFiyat"), 0)
                    dr("FIYAT1") = sorgu_sayi(dr("FIYAT1"), 0)
                    If barkoduzunluk >= 5 Then
                        'ürün adi oluþtur
                        ncrmalincinsi = Trim(UCase(dr("sAciklama")))
                        ncrmalincinsi = degeruzunlukkontrol(ncrmalincinsi, 20)
                        'stokkodu oluþtur
                        ncrstokkodu = UCase(Trim(dr("sKodu").ToString))
                        ncrstokkodu = degeruzunlukkontrol(ncrstokkodu, 20)
                        If sFiyatTipi <> 1 Then
                            If dr("lFiyat") = 0 Then
                                satisfiyati = dr("FIYAT1")
                            Else
                                satisfiyati = dr("lFiyat")
                            End If
                        Else
                            satisfiyati = dr("FIYAT1")
                        End If
                        'fiyatoluþtur
                        ncrfiyat = FormatNumber(satisfiyati, 2)
                        ncrfiyat = ncrfiyat.Replace(",", "")
                        ncrfiyat = ncrfiyat.Replace(".", ",")
                        Dim fiyatfark As Integer = 7 - Len(ncrfiyat)
                        For i = 1 To fiyatfark
                            ncrfiyat = ncrfiyat.insert(0, " ")
                        Next
                        'barcode oluþtur
                        ncrbarcode = Trim(dr("sBarkod").ToString)
                        ncrbarcode = degeruzunlukkontrol(ncrbarcode, 15)
                        'barcode standardý
                        If Len(Trim(dr("sBarkod"))) = 5 Then
                            ncrbarcodestd = 1
                        Else
                            ncrbarcodestd = 0
                        End If
                        'dosyoya yaz
                        sw.WriteLine(ncrbarcode & ncrmalincinsi & ncrfiyat & "00000")
                        sayi += 1
                    End If
                End If
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.Hide()
    End Sub
    Private Sub dosyaolustur_HUGIN425TX(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        Dim dr As DataRow
        Dim sPlu As String = ""
        Dim sPluStd As String = "000"
        Dim sMalincinsi As String = ""
        Dim lFiyat As String = ""
        Dim sDept As String = ""
        Dim tarih As Date = Now
        Dim con As New OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim z As String = sPath & ":" & sFile '"c:\entry01\PLU.TXT"
        Dim dosya As New FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        sayi = 0
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Hugin Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 Then
                If IsNumeric(Trim(dr("sBarkod").ToString)) Then
                    Dim barkod = Trim(dr("sBarkod").ToString)
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If barkoduzunluk >= 5 Then
                        'ürün adi oluþtur
                        sMalincinsi = UCase(Trim(dr("sAciklama").ToString))
                        sMalincinsi = degeruzunlukkontrol(sMalincinsi, 19)
                        'fiyatoluþtur
                        If sFiyatTipi <> 1 Then
                            If dr("FIYAT" & sFiyatTipi & "") = 0 Then
                                lFiyat = dr("FIYAT1")
                            Else
                                lFiyat = dr("FIYAT" & sFiyatTipi & "")
                            End If
                        Else
                            lFiyat = dr("FIYAT1")
                        End If
                        lFiyat = FormatNumber(lFiyat * 100, 0)
                        'fiyat = dr("FIYAT1") * 100
                        'barcode oluþtur
                        'barcode = dr("sBarkod")
                        If Len(Trim(barkod)) = 5 Then
                            sPlu = sGramaj & barkod '& "000000"
                            sPluStd = "016"
                        ElseIf Len(barkod) = 6 Then
                            sPlu = CType(barkod, Integer)
                            sPluStd = "000"
                        Else
                            sPlu = barkod
                            sPluStd = "000"
                        End If
                    End If
                    'departman
                    sDept = ""
                    sDept += sayiuzunlukkontrol(Replace(Left(dr("sKdvTipi"), 2), ".", ""), 2)
                    sPlu = degeruzunlukkontrol(sPlu, 14)
                    lFiyat = sayiuzunlukkontrol(lFiyat.Replace(",", "").Replace(".", ""), 10)
                    'dosyoya yaz=""
                    sw.WriteLine(sPlu & "," & sMalincinsi & ",003," & sPluStd & ",124,004,000,0             ," & sDept & "," & lFiyat)
                    sayi += 1
                End If
            End If
            nIndex = nIndex + 1
            'Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolustur_IBMEntry_Vega(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        Dim dr As DataRow
        Dim barcode As String = ""
        Dim malincinsi As String = ""
        Dim fiyat As String = ""
        Dim departman As String = ""
        Dim tarih As Date = Now
        Dim con As New OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim z As String = sPath & ":" & sFile '"c:\entry01\PLU.TXT"
        Dim dosya As New FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        sayi = 0
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "IBM Entry Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 Then
                If IsNumeric(Trim(dr("sBarkod").ToString)) Then
                    Dim barkod = Trim(dr("sBarkod").ToString)
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If barkoduzunluk >= 5 Then
                        'ürün adi oluþtur
                        malincinsi = UCase(Trim(dr("sAciklama").ToString))
                        malincinsi = degeruzunlukkontrol(malincinsi, 16)
                        malincinsi = Trim(malincinsi)
                        malincinsi = LTrim(malincinsi)
                        malincinsi = RTrim(malincinsi)
                        'fiyatoluþtur
                        If sFiyatTipi <> 1 Then
                            If dr("FIYAT" & sFiyatTipi & "") = 0 Then
                                fiyat = dr("FIYAT1")
                            Else
                                fiyat = dr("FIYAT" & sFiyatTipi & "")
                            End If
                        Else
                            fiyat = dr("FIYAT1")
                        End If
                        fiyat = FormatNumber(fiyat * 100, 0)
                        'fiyat = dr("FIYAT1") * 100
                        'barcode oluþtur
                        'barcode = dr("sBarkod")
                        If Len(Trim(barkod)) = 5 Then
                            barcode = sGramaj & barkod & "000000"
                        ElseIf Len(barkod) = 6 Then
                            barcode = CType(barkod, Integer)
                        Else
                            barcode = barkod
                        End If
                    End If
                    'departman
                    departman = ""
                    departman += sayiuzunlukkontrol(Replace(Left(dr("sKdvTipi"), 2), ".", ""), 2)
                    departman = CType(departman, Integer)
                    'dosyoya yaz=""
                    sw.WriteLine(" " & barcode & "," & malincinsi & "," & fiyat & "," & departman)
                    sayi += 1
                End If
            End If
            nIndex = nIndex + 1
            'Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolustur_IBMEntry_mdb(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        Dim dr As DataRow
        Dim barcode As String = ""
        Dim malincinsi As String = ""
        Dim fiyat As String = ""
        Dim departman As String = ""
        Dim tarih As Date = Now
        Dim con As New OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim z As String = sPath & ":" & sFile '"c:\entry01\PLU.TXT"
        Dim dosya As New FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        sayi = 0
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\entry01\entry01.mdb;Persist Security Info=False"
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = "DELETE FROM PLU"
        cmd.ExecuteNonQuery()
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "IBM Entry Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 Then
                If IsNumeric(Trim(dr("sBarkod").ToString)) Then
                    Dim barkod = Trim(dr("sBarkod").ToString)
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If barkoduzunluk >= 5 Then
                        'ürün adi oluþtur
                        malincinsi = UCase(Trim(dr("sAciklama").ToString))
                        malincinsi = degeruzunlukkontrol(malincinsi, 15)
                        'fiyatoluþtur
                        'fiyat = FormatNumber(dr("FIYAT1") * 100, 0)
                        'fiyatoluþtur
                        If sFiyatTipi <> 1 Then
                            If dr("FIYAT" & sFiyatTipi & "") = 0 Then
                                fiyat = dr("FIYAT1")
                            Else
                                fiyat = dr("FIYAT" & sFiyatTipi & "")
                            End If
                        Else
                            fiyat = dr("FIYAT1")
                        End If
                        fiyat = FormatNumber(fiyat, 0)
                        'fiyat = dr("FIYAT1") * 100
                        'barcode oluþtur
                        'barcode = dr("sBarkod")
                        If Len(Trim(barkod)) = 5 Then
                            barcode = sGramaj & barkod & "000000"
                        ElseIf Len(barkod) = 6 Then
                            barcode = CType(barkod, Integer)
                        Else
                            barcode = barkod
                        End If
                    End If
                    'departman
                    departman = ""
                    departman += sayiuzunlukkontrol(Replace(Left(dr("sKdvTipi"), 2), ".", ""), 2)
                    departman = CType(departman, Integer)
                    'dosyoya yaz=""
                    sw.WriteLine(" " & barcode & "," & malincinsi & "," & fiyat & "," & departman)
                    sayi += 1
                    cmd.CommandText = "INSERT INTO  PLU (CODE,EXPLAIN,REXPLAIN,PRICE,DEPARTMENT,AMOUNT,DEL,OPERATOR,UDATE) VALUES (" & barcode & ",'" & malincinsi & "','" & malincinsi & "' ," & fiyat & "," & departman & ",9999,0,0,'" & Today & "')"
                    'SIEMENS_STOCK_CARDS_kaydet_yeni(sPath, sFile, barcode, 0, malincinsi, malincinsi, malincinsi, malincinsi, malincinsi, sBirimCinsi, 1, 1, 1, 1, fiyat, 0, 0, 0, 0, 0, 7, departman, 0, 0, departman, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, Now)
                    cmd.ExecuteNonQuery()
                End If
            End If
            nIndex = nIndex + 1
            'Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        conn.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolustur_SambaPos_Stoklar(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "SambaPos Dosyasý Oluþturuluyor...")
        Dim dr As DataRow
        Dim nIndex As Integer = 0
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SambaData2;" & sFile & ";Current Language=Türkçe;Application Name=SambaPos"
        cmd.Connection = con
        sayi = 1
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 And Trim(dr("sBarkod")) <> "" Then
                If IsNumeric(Trim(dr("sBarkod").ToString)) Then
                    If sFiyatTipi <> 1 Then
                        If dr("FIYAT" & sFiyatTipi & "") = 0 Then
                            fiyat = dr("FIYAT1")
                        Else
                            fiyat = dr("FIYAT" & sFiyatTipi & "")
                        End If
                    Else
                        fiyat = dr("FIYAT1")
                    End If
                    If Trim(dr("sKdvTipi")) = "" Then
                        dr("sKdvTipi") = "1"
                    End If
                    Dim nSayi As Integer = 0
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                    cmd.CommandText = "Select ISNULL(COUNT(*),0) from MenuItems Where Id = " & dr("nStokID") & ""
                    nSayi = Convert.ToInt16(cmd.ExecuteScalar())
                    If nSayi = 0 Then
                        cmd.CommandText = ("SET IDENTITY_INSERT  MenuItems ON INSERT INTO MenuItems                       (Id, Name, LastUpdateTime, GroupCode, Barcode, Tag,VatTemplate_Id) VALUES     (" & dr("nStokID") & ", '" & dr("sAciklama") & "', NULL, '', '" & dr("sBarkod") & "', ''," & sorgu_sayi(dr("sKdvTipi"), 0) & ")")
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = ("INSERT INTO MenuItemPortions                       (MenuItemId, Name, Price_CurrencyCode, Price_Amount, Multiplier) VALUES     (" & dr("nStokID") & ", 'Normal', 'TL', " & fiyat & ",1)")
                        cmd.ExecuteNonQuery()
                    ElseIf nSayi = 1 Then
                        cmd.CommandText = ("Update MenuItems set Name = '" & dr("sAciklama") & "',VatTemplate_Id = " & sorgu_sayi(dr("sKdvTipi"), 0) & ",Barcode = '" & dr("sBarkod") & "' Where Id = " & dr("nStokID") & "")
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = ("Update MenuItemPortions Set Price_Amount = " & fiyat & " Where MenuItemID = " & dr("nStokID") & "")
                        cmd.ExecuteNonQuery()
                    End If
                    sayi += 1
                End If
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        con.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolustur_BusinessMobile_txt(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        Dim dr As DataRow
        Dim sKodu As String = ""
        Dim barcode As String = ""
        Dim sMalincinsi As String = ""
        Dim fiyat As String = ""
        Dim lFiyat1 As String = ""
        Dim lFiyat2 As String = ""
        Dim lFiyat3 As String = ""
        Dim departman As String = ""
        Dim sBirimCinsi As String = ""
        Dim sBirimCinsi2 As String = ""
        Dim sBarcodeType As String = 0
        Dim sAnaDepartman As String = ""
        Dim nKdvOrani As String = ""
        Dim lMevcut As String = ""
        Dim bTartili As Integer = 0
        Dim tarih As Date = Now
        Dim con As New OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim z As String = sPath & ":" & sFile '"c:\entry01\PLU.TXT"
        Dim dosya As New FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        sayi = 0
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Mobile Terminal Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 And Trim(dr("sBarkod")) <> "" Then
                If IsNumeric(Trim(dr("sBarkod").ToString)) Then
                    Dim barkod As String = Trim(dr("sBarkod").ToString)
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.Length
                    End If
                    If barkoduzunluk >= 5 Then
                        'ürün adi oluþtur
                        sMalincinsi = UCase(Trim(dr("sAciklama").ToString))
                        sMalincinsi = degeruzunlukkontrol(sMalincinsi, 60)
                        sMalincinsi = Trim(sMalincinsi)
                        sMalincinsi = LTrim(sMalincinsi)
                        sMalincinsi = RTrim(sMalincinsi)
                        'fiyatoluþtur
                        If sFiyatTipi <> 1 Then
                            If dr("FIYAT" & sFiyatTipi & "") = 0 Then
                                fiyat = dr("FIYAT1")
                            Else
                                fiyat = dr("FIYAT" & sFiyatTipi & "")
                            End If
                        Else
                            fiyat = dr("FIYAT1")
                        End If
                        'fiyat = dr("FIYAT1") * 100
                        fiyat = sayiuzunlukkontrol_deger(FormatNumber(fiyat, 2).Replace(",", ""), 10, " ")
                        sBirimCinsi = Trim(dr("sBirimCinsi1").ToString)
                        If sBirimCinsi = "" Then
                            sBirimCinsi = "Adet"
                        End If
                        'barcode oluþtur
                        'barcode = dr("sBarkod")
                        bTartili = 0
                        If Len(Trim(barkod)) = 5 Then
                            'barcode = sGramaj & barkod & "000000"
                            barcode = sGramaj & barkod
                            sBarcodeType = 0
                            bTartili = 1
                            sBirimCinsi = "KG"
                        ElseIf Len(barkod) = 6 Then
                            barcode = CType(barkod, Integer)
                            sBarcodeType = 5
                        ElseIf Len(barkod) = 8 Then
                            barcode = barkod
                            sBarcodeType = 2
                        ElseIf Len(barkod) = 12 Then
                            barcode = barkod
                            sBarcodeType = 11
                        ElseIf Len(barkod) = 13 Then
                            barcode = barkod
                            sBarcodeType = 1
                        Else
                            barcode = barkod
                            sBarcodeType = 0
                        End If
                    End If
                    'departman
                    departman = ""
                    departman += sayiuzunlukkontrol(Replace(Left(dr("sKdvTipi"), 2), ".", ""), 2)
                    departman = CType(departman, Integer)
                    nKdvOrani = dr("nKdvOrani")
                    sBirimCinsi = degeruzunlukkontrol(sBirimCinsi, 4)
                    'stokkodu 
                    sKodu = degeruzunlukkontrol(Trim(dr("nStokID").ToString), 20)
                    sMalincinsi = degeruzunlukkontrol(sMalincinsi, 60)
                    barcode = degeruzunlukkontrol(barcode, 20)
                    sBarcodeType = sayiuzunlukkontrol(sBarcodeType, 2)
                    sAnaDepartman = "        "
                    lFiyat1 = fiyat
                    lFiyat2 = sayiuzunlukkontrol_deger(FormatNumber(dr("ALISFIYATI"), 2).Replace(",", ""), 10, " ")
                    lFiyat3 = sayiuzunlukkontrol_deger("0.00", 10, " ")
                    lMevcut = sayiuzunlukkontrol_deger(dr("lMevcut"), 10, " ")
                    Dim yil As String = ""
                    Dim ay As String = ""
                    Dim gun As String = ""
                    yil = sayiuzunlukkontrol(Today.Year, 4)
                    ay = sayiuzunlukkontrol(Today.Month, 2)
                    gun = sayiuzunlukkontrol(Now.Day.ToString, 2)
                    'dosyoya yaz=""
                    sw.WriteLine(barcode & "," & sMalincinsi & "," & nKdvOrani & "," & lFiyat2 & "," & lFiyat1 & "," & lMevcut)
                    sayi += 1
                End If
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolustur_SIEMENS_txt(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        Dim dr As DataRow
        Dim sKodu As String = ""
        Dim barcode As String = ""
        Dim sMalincinsi As String = ""
        Dim fiyat As String = ""
        Dim fiyat2 As String = ""
        Dim fiyat3 As String = ""
        Dim lFiyat1 As String = ""
        Dim lFiyat2 As String = ""
        Dim lFiyat3 As String = ""
        Dim departman As String = ""
        Dim sBirimCinsi As String = ""
        Dim sBirimCinsi2 As String = ""
        Dim sBarcodeType As String = 0
        Dim sAnaDepartman As String = ""
        Dim nKdvOrani As String = ""
        Dim bTartili As Integer = 0
        Dim tarih As Date = Now
        Dim con As New OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim z As String = sPath & ":" & sFile '"c:\entry01\PLU.TXT"
        Dim dosya As New FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        sayi = 0
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Siemens Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 And Trim(dr("sBarkod")) <> "" Then
                If IsNumeric(Trim(dr("sBarkod").ToString)) Then
                    Dim barkod As String = Trim(dr("sBarkod").ToString)
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.Length
                    End If
                    If barkoduzunluk >= 5 Then
                        'ürün adi oluþtur
                        sMalincinsi = UCase(Trim(dr("sAciklama").ToString))
                        sMalincinsi = degeruzunlukkontrol(sMalincinsi, 30)
                        sMalincinsi = Trim(sMalincinsi)
                        sMalincinsi = LTrim(sMalincinsi)
                        sMalincinsi = RTrim(sMalincinsi)
                        'fiyatoluþtur
                        If sFiyatTipi <> 1 Then
                            If dr("FIYAT" & sFiyatTipi & "") = 0 Then
                                fiyat = dr("FIYAT1")
                            Else
                                fiyat = dr("FIYAT" & sFiyatTipi & "")
                            End If
                        Else
                            fiyat = dr("FIYAT1")
                        End If
                        fiyat = dr("FIYAT1") * 100
                        If dr("FIYAT2") = 0 Then
                            fiyat2 = dr("FIYAT1") * 100
                        Else
                            fiyat2 = dr("FIYAT2") * 100
                        End If
                        If dr("FIYAT3") = 0 Then
                            fiyat3 = dr("FIYAT1") * 100
                        Else
                            fiyat3 = dr("FIYAT3") * 100
                        End If
                        fiyat = sayiuzunlukkontrol_deger(FormatNumber(fiyat, 2).Replace(",", ""), 10, " ")
                        fiyat2 = sayiuzunlukkontrol_deger(FormatNumber(fiyat2, 2).Replace(",", ""), 10, " ")
                        fiyat3 = sayiuzunlukkontrol_deger(FormatNumber(fiyat3, 2).Replace(",", ""), 10, " ")
                        sBirimCinsi = Trim(dr("sBirimCinsi1").ToString)
                        If sBirimCinsi = "" Then
                            sBirimCinsi = "Adet"
                        End If
                        'barcode oluþtur
                        'barcode = dr("sBarkod")
                        bTartili = 0
                        If Len(Trim(barkod)) = 5 Then
                            'barcode = sGramaj & barkod & "000000"
                            barcode = sGramaj & barkod
                            sBarcodeType = 0
                            bTartili = 1
                            sBirimCinsi = "KG"
                        ElseIf Len(barkod) = 6 Then
                            barcode = CType(barkod, Integer)
                            sBarcodeType = 5
                        ElseIf Len(barkod) = 8 Then
                            barcode = barkod
                            sBarcodeType = 2
                        ElseIf Len(barkod) = 12 Then
                            barcode = barkod
                            sBarcodeType = 11
                        ElseIf Len(barkod) = 13 Then
                            barcode = barkod
                            sBarcodeType = 1
                        Else
                            barcode = barkod
                            sBarcodeType = 0
                        End If
                    End If
                    'departman
                    departman = ""
                    departman += sayiuzunlukkontrol(Replace(Left(dr("sKdvTipi"), 2), ".", ""), 2)
                    Try
                        departman = CType(departman, Integer)
                    Catch ex As Exception
                        departman = 1
                    End Try
                    nKdvOrani = dr("nKdvOrani")
                    sBirimCinsi = degeruzunlukkontrol(sBirimCinsi, 4)
                    'stokkodu 
                    sKodu = degeruzunlukkontrol(Trim(dr("nStokID").ToString), 20)
                    sMalincinsi = degeruzunlukkontrol(sMalincinsi, 30)
                    barcode = degeruzunlukkontrol(barcode, 20)
                    sBarcodeType = sayiuzunlukkontrol(sBarcodeType, 2)
                    sAnaDepartman = "        "
                    lFiyat1 = fiyat
                    lFiyat2 = fiyat2 'sayiuzunlukkontrol_deger("0.00", 10, " ")
                    lFiyat3 = fiyat3 'sayiuzunlukkontrol_deger("0.00", 10, " ")
                    Dim yil As String = ""
                    Dim ay As String = ""
                    Dim gun As String = ""
                    yil = sayiuzunlukkontrol(Today.Year, 4)
                    ay = sayiuzunlukkontrol(Today.Month, 2)
                    gun = sayiuzunlukkontrol(Now.Day.ToString, 2)
                    'dosyoya yaz=""
                    sw.WriteLine("""" & sKodu & """," & """" & barcode & """," & sBarcodeType & "," & """" & sMalincinsi & """," & """" & sMalincinsi & """," & """" & degeruzunlukkontrol(sMalincinsi, 20) & """," & """" & degeruzunlukkontrol(sMalincinsi, 13) & """," & """" & degeruzunlukkontrol(sMalincinsi, 20) & """," & """" & degeruzunlukkontrol(sMalincinsi, 16) & """,00,1," & """" & sAnaDepartman & """," & """" & sAnaDepartman & """," & """" & sAnaDepartman & """," & """" & sAnaDepartman & """," & """" & sAnaDepartman & """," & """" & sAnaDepartman & """," & """" & sAnaDepartman & """," & """" & degeruzunlukkontrol(sBirimCinsi, 8) & """," & """" & degeruzunlukkontrol(sBirimCinsi, 4) & """," & """" & sAnaDepartman & """," & """" & degeruzunlukkontrol(sAnaDepartman, 4) & """," & "0.000," & """" & sAnaDepartman & """," & """" & degeruzunlukkontrol(sAnaDepartman, 4) & """,0.000,      0.00,      0.00,      0.00," & lFiyat1 & "," & lFiyat2 & "," & lFiyat3 & ",0.000," & lFiyat1 & ", 0," & sayiuzunlukkontrol(FormatNumber(nKdvOrani, 2), 5) & "," & """100000""," & """" & degeruzunlukkontrol(sAnaDepartman, 10) & """," & "  0, 0.000, 0.000, 0.000, 0.000, 0.000, 0.000," & bTartili & "," & """" & degeruzunlukkontrol(sAnaDepartman, 20) & """,01,""                    "",01," & bTartili & " ,0,""" & yil & ay & gun & """,0.00,0.00,0.00,0.00,0.00,0.00,0.00,0.00,0.0,0.0")
                    sayi += 1
                End If
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolustur_Siemens_cariler(ByVal sPath As String, ByVal sFile As String, ByVal sFiyattipi As Integer)
        Dim dr As DataRow
        Dim nCarino As String = ""
        Dim nCariKod As String = ""
        Dim sCari As String = ""
        Dim sAdres1 As String = ""
        Dim sAdres2 As String = ""
        Dim sAdres3 As String = ""
        Dim sVergiDairesi As String = ""
        Dim sVergiNo As String = ""
        Dim nIskontoYuzdesi As String = ""
        Dim sCariKartTipi As String = "00000001"
        Dim z As String = sPath & ":" & sFile
        Dim DOSYA As New FileInfo(z)
        If DOSYA.Exists Then
            DOSYA.Delete()
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        sayi = 0
        Dim ds As New DataSet
        ds = intercariler2()
        For Each dr In ds.Tables(0).Rows
            nCariKod = degeruzunlukkontrol(Trim(dr("sKodu").ToString), 30)
            sCari = degeruzunlukkontrol(Trim(dr("sAciklama")).ToString, 30)
            sAdres1 = degeruzunlukkontrol(Trim(dr("sAdres1").ToString), 30)
            sAdres2 = degeruzunlukkontrol(Trim(dr("sAdres2").ToString), 30)
            sAdres3 = degeruzunlukkontrol("", 30)
            sVergiDairesi = degeruzunlukkontrol(Trim(dr("sVergiDairesi").ToString), 16)
            sVergiNo = degeruzunlukkontrol(Trim(dr("sVergiNo").ToString), 12)
            nIskontoYuzdesi = sayiuzunlukkontrol(FormatNumber(sorgu_sayi(dr("nOzelIskontosu"), 0), 2), 4)
            Dim satir As String
            satir = sayiuzunlukkontrol(sayi, 6)
            Dim pluno As String = ""
            nCarino = Trim(dr("nFirmaID"))
            pluno = sayiuzunlukkontrol(nCarino, 16)
            sw.WriteLine("""" & pluno & """," & """" & nCariKod & """," & sCari & "," & """" & sAdres1 & """," & """" & sAdres2 & """," & """" & sAdres3 & """," & """" & sVergiDairesi & """," & """" & sVergiNo & """," & nIskontoYuzdesi & "," & """" & sCariKartTipi & """,00000")
            sayi += 1
        Next
        sw.Close()
    End Sub
    Private Sub dosyaolustur_Ncr_txt(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        Dim dr As DataRow
        Dim sKodu As String = ""
        Dim barcode As String = ""
        Dim sMalincinsi As String = ""
        Dim fiyat As String = ""
        Dim lFiyat1 As String = ""
        Dim lFiyat2 As String = ""
        Dim lFiyat3 As String = ""
        Dim departman As String = ""
        Dim sBirimCinsi As String = ""
        Dim sBirimCinsi2 As String = ""
        Dim sBarcodeType As String = 0
        Dim sAnaDepartman As String = ""
        Dim nKdvOrani As String = ""
        Dim bTartili As Integer = 0
        Dim tarih As Date = Now
        Dim con As New OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim z As String = sPath & ":" & sFile '"c:\entry01\PLU.TXT"
        Dim dosya As New FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        sayi = 0
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "NCR Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 And Trim(dr("sBarkod")) <> "" Then
                If IsNumeric(Trim(dr("sBarkod").ToString)) Then
                    Dim barkod As String = Trim(dr("sBarkod").ToString)
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.Length
                    End If
                    If barkoduzunluk >= 5 Then
                        'ürün adi oluþtur
                        sMalincinsi = UCase(Trim(dr("sAciklama").ToString))
                        sMalincinsi = degeruzunlukkontrol(sMalincinsi, 30)
                        sMalincinsi = Trim(sMalincinsi)
                        sMalincinsi = LTrim(sMalincinsi)
                        sMalincinsi = RTrim(sMalincinsi)
                        'fiyatoluþtur
                        If sFiyatTipi <> 1 Then
                            If dr("FIYAT" & sFiyatTipi & "") = 0 Then
                                fiyat = dr("FIYAT1")
                            Else
                                fiyat = dr("FIYAT" & sFiyatTipi & "")
                            End If
                        Else
                            fiyat = dr("FIYAT1")
                        End If
                        fiyat = dr("FIYAT1") * 100
                        fiyat = sayiuzunlukkontrol_deger(FormatNumber(fiyat, 0).Replace(",", ""), 9, "0")
                        sBirimCinsi = Trim(dr("sBirimCinsi1").ToString)
                        If sBirimCinsi = "" Then
                            sBirimCinsi = "Ad"
                        End If
                        'barcode oluþtur
                        'barcode = dr("sBarkod")
                        bTartili = 0
                        If Len(Trim(barkod)) = 5 Then
                            'barcode = sGramaj & barkod & "000000"
                            barcode = sGramaj & Trim(barkod) & "00000"
                            barcode = barcode & Ean13_CheckSum(Microsoft.VisualBasic.Left(barcode, 12))
                            sBarcodeType = 21
                            bTartili = 1
                            sBirimCinsi = "KG"
                        ElseIf Len(barkod) = 6 Then
                            barcode = CType(barkod, Integer)
                            'barcode = barkod
                            sBarcodeType = 10
                        ElseIf Len(barkod) = 8 Then
                            barcode = barkod
                            sBarcodeType = 10
                        ElseIf Len(barkod) = 12 Then
                            barcode = barkod
                            sBarcodeType = 10
                        ElseIf Len(barkod) = 13 Then
                            barcode = barkod
                            sBarcodeType = 10
                        Else
                            barcode = barkod
                            sBarcodeType = 10
                        End If
                    End If
                    'departman
                    departman = ""
                    departman += sayiuzunlukkontrol(Replace(Left(dr("sKdvTipi"), 2), ".", ""), 2)
                    'departman = sayiuzunlukkontrol(CType(departman, Integer), 2)
                    nKdvOrani = dr("nKdvOrani")
                    sBirimCinsi = degeruzunlukkontrol(sBirimCinsi, 2)
                    'stokkodu 
                    sKodu = degeruzunlukkontrol(Trim(dr("nStokID").ToString), 20)
                    sMalincinsi = degeruzunlukkontrol(sMalincinsi, 20)
                    'barcode = degeruzunlukkontrol(barcode, 13)
                    barcode = sayiuzunlukkontrol_deger(barcode, 16, " ")
                    sBarcodeType = sayiuzunlukkontrol(sBarcodeType, 2)
                    sAnaDepartman = "        "
                    lFiyat1 = fiyat
                    'dosyoya yaz=""
                    'sw.WriteLine("""" & sKodu & """," & """" & barcode & """," & sBarcodeType & "," & """" & sMalincinsi & """," & """" & sMalincinsi & """," & """" & degeruzunlukkontrol(sMalincinsi, 20) & """," & """" & degeruzunlukkontrol(sMalincinsi, 13) & """," & """" & degeruzunlukkontrol(sMalincinsi, 20) & """," & """" & degeruzunlukkontrol(sMalincinsi, 16) & """,00,1," & """" & sAnaDepartman & """," & """" & sAnaDepartman & """," & """" & sAnaDepartman & """," & """" & sAnaDepartman & """," & """" & sAnaDepartman & """," & """" & sAnaDepartman & """," & """" & sAnaDepartman & """," & """" & degeruzunlukkontrol(sBirimCinsi, 8) & """," & """" & degeruzunlukkontrol(sBirimCinsi, 4) & """," & """" & sAnaDepartman & """," & """" & degeruzunlukkontrol(sAnaDepartman, 4) & """," & "0.000," & """" & sAnaDepartman & """," & """" & degeruzunlukkontrol(sAnaDepartman, 4) & """,0.000,      0.00,      0.00,      0.00," & lFiyat1 & "," & lFiyat2 & "," & lFiyat3 & ",0.000," & lFiyat1 & ", 0," & sayiuzunlukkontrol(FormatNumber(nKdvOrani, 2), 5) & "," & """100000""," & """" & degeruzunlukkontrol(sAnaDepartman, 10) & """," & "  0, 0.000, 0.000, 0.000, 0.000, 0.000, 0.000," & bTartili & "," & """" & degeruzunlukkontrol(sAnaDepartman, 20) & """,01,""                    "",01," & bTartili & " ,0,""" & yil & ay & gun & """,0.00,0.00,0.00,0.00,0.00,0.00,0.00,0.00,0.0,0.0")
                    'sw.WriteLine("   " & barcode & "0100" & sBarcodeType & departman & "00" & sBirimCinsi & "00100000" & sMalincinsi & "             " & fiyat)
                    sw.WriteLine(barcode & "0100" & sBarcodeType & departman & "00" & sBirimCinsi & "00100000" & sMalincinsi & "             " & fiyat)
                    sayi += 1
                End If
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Function Ean13_CheckSum(ByVal barcode As String) As Integer
        Dim X As Integer = 0
        Dim Y As Integer = 0
        Dim j As Integer = 11
        Dim m_checksum As Integer = 0
        Try
            For i As Integer = 1 To 12
                If i Mod 2 = 0 Then
                    X += Val(barcode(j))
                Else
                    Y += Val(barcode(j))
                End If
                j -= 1
            Next
            Dim Z As Integer = X + (3 * Y)
            'first(way)
            'Dim m_CheckSum As Integer = ((10 - (Z Mod 10)) Mod 10)
            'second way
            Dim M As Integer = Z
            Do Until (M Mod 10 = 0)
                M += 1
            Loop
            m_checksum = M - Z
            Return m_checksum
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
    Private Sub dosyaolustur_SIEMENS_mdb(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        Dim dr As DataRow
        Dim barcode As String = ""
        Dim malincinsi As String = ""
        Dim fiyat As String = ""
        Dim fiyat2 As String = ""
        Dim fiyat3 As String = ""
        Dim departman As String = ""
        Dim sBirimCinsi As String = ""
        Dim sBarcodeType As Integer = 0
        Dim bTartili As Integer = 0
        Dim tarih As Date = Now
        Dim con As New OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim z As String = sPath & ":" & sFile '"c:\entry01\PLU.TXT"
        Dim dosya As New FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        sayi = 0
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & sPath & ": " & sFile & " ;Persist Security Info=False"
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = "DELETE FROM STOCK_CARDS"
        cmd.ExecuteNonQuery()
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Siemens Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 Then
                If IsNumeric(Trim(dr("sBarkod").ToString)) Then
                    Dim barkod = Trim(dr("sBarkod").ToString)
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If barkoduzunluk >= 5 Then
                        'ürün adi oluþtur
                        malincinsi = UCase(Trim(dr("sAciklama").ToString))
                        malincinsi = degeruzunlukkontrol(malincinsi, 15)
                        'fiyatoluþtur
                        'fiyat = FormatNumber(dr("FIYAT1") * 100, 0)
                        'fiyatoluþtur
                        If sFiyatTipi <> 1 Then
                            If dr("FIYAT" & sFiyatTipi & "") = 0 Then
                                fiyat = dr("FIYAT1")
                            Else
                                fiyat = dr("FIYAT" & sFiyatTipi & "")
                            End If
                        Else
                            fiyat = dr("FIYAT1")
                        End If
                        fiyat = FormatNumber(fiyat, 0)
                        'fiyat = dr("FIYAT1") * 100
                        'barcode oluþtur
                        'barcode = dr("sBarkod")
                        bTartili = 0
                        If Len(Trim(barkod)) = 5 Then
                            barcode = sGramaj & barkod & "000000"
                            sBarcodeType = 0
                            bTartili = 1
                        ElseIf Len(barkod) = 6 Then
                            barcode = CType(barkod, Integer)
                            sBarcodeType = 5
                        ElseIf Len(barkod) = 8 Then
                            sBarcodeType = 2
                        ElseIf Len(barkod) = 12 Then
                            sBarcodeType = 11
                        ElseIf Len(barkod) = 13 Then
                            sBarcodeType = 1
                        Else
                            barcode = barkod
                            sBarcodeType = 0
                        End If
                    End If
                    'departman
                    departman = ""
                    departman += sayiuzunlukkontrol(Replace(Left(dr("sKdvTipi"), 2), ".", ""), 2)
                    departman = CType(departman, Integer)
                    sBirimCinsi = dr("sBirimCinsi1")
                    'dosyoya yaz=""
                    sw.WriteLine(" " & barcode & "," & malincinsi & "," & fiyat & "," & departman)
                    sayi += 1
                    'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO  PLU (CODE,EXPLAIN,REXPLAIN,PRICE,DEPARTMENT,AMOUNT,DEL,OPERATOR,UDATE) VALUES (" & barcode & ",'" & malincinsi & "','" & malincinsi & "' ," & fiyat & "," & departman & ",9999,0,0,'" & Today & "')"
                    SIEMENS_STOCK_CARDS_kaydet_yeni(sPath, sFile, barcode, sBarcodeType, malincinsi, malincinsi, malincinsi, malincinsi, malincinsi, sBirimCinsi, 1, 1, 1, 1, fiyat, 0, 0, 0, 0, 0, 7, departman, 0, 0, departman, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, bTartili, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, Now)
                End If
            End If
            nIndex = nIndex + 1
            'Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        conn.Close()
        Progress.HideProgress()
    End Sub
    Private Sub SIEMENS_STOCK_CARDS_kaydet_yeni(ByVal sPath As String, ByVal sFile As String, ByVal CODE As String, ByVal BARCODE_TYPE As Integer, ByVal EXPLAIN As String, ByVal MEDIUM_EXPLAIN As String, ByVal RECEIPT_EXPLAIN As String, ByVal SHELF_EXPLAIN As String, ByVal SCALE_EXPLAIN As String, ByVal UNIT1 As String, ByVal UNIT2_COEFF As Int64, ByVal UNIT3_COEFF As Int64, ByVal UNIT2_MULTIPLIES As Integer, ByVal UNIT3_MULTIPLIES As Integer, ByVal SELL_PRICE1 As Decimal, ByVal SELL_PRICE2 As Decimal, ByVal SELL_PRICE3 As Decimal, ByVal BUY_PRICE1 As Decimal, ByVal BUY_PRICE2 As Decimal, ByVal BUY_PRICE3 As Decimal, ByVal VAT_INCLUDED_FLAGS As Integer, ByVal SELL_VAT_GRP As Integer, ByVal SELL_VAT_GRP2 As Integer, ByVal SELL_VAT_GRP3 As Integer, ByVal BUY_VAT_GRP As Integer, ByVal BUY_VAT_GRP2 As Integer, ByVal BUY_VAT_GRP3 As Integer, ByVal CURRENCY_BUY_PRICE As Decimal, ByVal CURRENCY_SELL_PRICE As Decimal, ByVal SUPPLY_TIME As Integer, ByVal SHELF_LIFE As Integer, ByVal CONSUME_LIFE As Integer, ByVal COST_TYPE As Integer, ByVal TARGET_PROFIT As Integer, ByVal POS_GRP As Integer, ByVal SCALE_MODE As Integer, ByVal POINTWHAT As Integer, ByVal POINTMULT As Integer, ByVal CANSELLFLAG As Integer, ByVal CANRETURN As Integer, ByVal MINSALEQUANTITY As Integer, ByVal MAXSALEQUANTITY As Integer, ByVal LABEL_TYPE As Integer, ByVal WEIGHED_AT_POS As Integer, ByVal WITH_DEPOSIT As Integer, ByVal ACTIVE As Integer, ByVal PRODUCER_BARCODE As Integer, ByVal NEVER_DISCOUNT As Integer, ByVal HQ_CARD_ONLY As Integer, ByVal BEING_COUNTED As Integer, ByVal IS_MENU As Integer, ByVal STORE_ORDER_LEVEL As Integer, ByVal STORE_CRITICAL_LEVEL As Integer, ByVal STORE_MAXIMUM_LEVEL As Integer, ByVal WHOUSE_ORDER_LEVEL As Integer, ByVal WHOUSE_CRITICAL_LEVEL As Integer, ByVal WHOUSE_MAXIMUM_LEVEL As Integer, ByVal DUSPAL_TABAN As Integer, ByVal DUSPAL_YUKSEKLIK As Integer, ByVal EUROPAL_TABAN As Integer, ByVal EUROPAL_YUKSEKLIK As Integer, ByVal TAX_STATUS As Integer, ByVal SENT As Integer, ByVal SELL_PRICE4 As Integer, ByVal SELL_PRICE5 As Integer, ByVal QUANTITY1 As Integer, ByVal QUANTITY2 As Integer, ByVal QUANTITY3 As Integer, ByVal QUANTITY4 As Integer, ByVal DISCOUNT_PERCENT As Integer, ByVal DISCOUNT_VALUE As Integer, ByVal DISC_PERC1 As Integer, ByVal DISC_PERC2 As Integer, ByVal DISC_PERC3 As Integer, ByVal DISC_PERC4 As Integer, ByVal DISC_PERC5 As Integer, ByVal AUDIT_WHO As Integer, ByVal AUDIT_WHEN As DateTime)
        Dim con As New OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & sPath & ":" & sFile & ";Persist Security Info=False"
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = "INSERT INTO  STOCK_CARDS(CODE, BARCODE_TYPE, EXPLAIN, MEDIUM_EXPLAIN, RECEIPT_EXPLAIN, SHELF_EXPLAIN, SCALE_EXPLAIN, UNIT1, UNIT2_COEFF, UNIT3_COEFF, UNIT2_MULTIPLIES, UNIT3_MULTIPLIES, SELL_PRICE1, SELL_PRICE2, SELL_PRICE3, BUY_PRICE1, BUY_PRICE2, BUY_PRICE3, VAT_INCLUDED_FLAGS, SELL_VAT_GRP, SELL_VAT_GRP2, SELL_VAT_GRP3, BUY_VAT_GRP, BUY_VAT_GRP2, BUY_VAT_GRP3, CURRENCY_BUY_PRICE, CURRENCY_SELL_PRICE, SUPPLY_TIME, SHELF_LIFE, CONSUME_LIFE, COST_TYPE, TARGET_PROFIT, POS_GRP, SCALE_MODE, POINTWHAT, POINTMULT, CANSELLFLAG, CANRETURN, MINSALEQUANTITY, MAXSALEQUANTITY, LABEL_TYPE, WEIGHED_AT_POS, WITH_DEPOSIT, ACTIVE, PRODUCER_BARCODE, NEVER_DISCOUNT, HQ_CARD_ONLY, BEING_COUNTED, IS_MENU, STORE_ORDER_LEVEL, STORE_CRITICAL_LEVEL, STORE_MAXIMUM_LEVEL, WHOUSE_ORDER_LEVEL, WHOUSE_CRITICAL_LEVEL, WHOUSE_MAXIMUM_LEVEL, DUSPAL_TABAN, DUSPAL_YUKSEKLIK, EUROPAL_TABAN, EUROPAL_YUKSEKLIK, TAX_STATUS, SENT, SELL_PRICE4, SELL_PRICE5, QUANTITY1, QUANTITY2, QUANTITY3, QUANTITY4, DISCOUNT_PERCENT, DISCOUNT_VALUE, DISC_PERC1, DISC_PERC2, DISC_PERC3, DISC_PERC4, DISC_PERC5, AUDIT_WHO, AUDIT_WHEN) VALUES ('" & CODE & "', " & BARCODE_TYPE & ", '" & EXPLAIN & "', '" & MEDIUM_EXPLAIN & "', '" & RECEIPT_EXPLAIN & "', '" & SHELF_EXPLAIN & "', '" & SCALE_EXPLAIN & "', '" & UNIT1 & "', " & UNIT2_COEFF & ", " & UNIT3_COEFF & ", " & UNIT2_MULTIPLIES & ", " & UNIT3_MULTIPLIES & ", " & SELL_PRICE1 & ", " & SELL_PRICE2 & ", " & SELL_PRICE3 & ", " & BUY_PRICE1 & ", " & BUY_PRICE2 & ", " & BUY_PRICE3 & ", " & VAT_INCLUDED_FLAGS & ", " & SELL_VAT_GRP & ", " & SELL_VAT_GRP2 & ", " & SELL_VAT_GRP3 & ", " & BUY_VAT_GRP & ", " & BUY_VAT_GRP2 & ", " & BUY_VAT_GRP3 & ", " & CURRENCY_BUY_PRICE & ", " & CURRENCY_SELL_PRICE & ", " & SUPPLY_TIME & ", " & SHELF_LIFE & ", " & CONSUME_LIFE & ", " & COST_TYPE & ", " & TARGET_PROFIT & ", " & POS_GRP & ", " & SCALE_MODE & ", " & POINTWHAT & ", " & POINTMULT & ", " & CANSELLFLAG & ", " & CANRETURN & ", " & MINSALEQUANTITY & ", " & MAXSALEQUANTITY & ", " & LABEL_TYPE & ", " & WEIGHED_AT_POS & ", " & WITH_DEPOSIT & ", " & ACTIVE & ", '" & PRODUCER_BARCODE & "', " & NEVER_DISCOUNT & ", " & HQ_CARD_ONLY & ", " & BEING_COUNTED & ", " & IS_MENU & ", " & STORE_ORDER_LEVEL & ", " & STORE_CRITICAL_LEVEL & ", " & STORE_MAXIMUM_LEVEL & ", " & WHOUSE_ORDER_LEVEL & ", " & WHOUSE_CRITICAL_LEVEL & ", " & WHOUSE_MAXIMUM_LEVEL & ", " & DUSPAL_TABAN & ", " & DUSPAL_YUKSEKLIK & ", " & EUROPAL_TABAN & ", " & EUROPAL_YUKSEKLIK & ", " & TAX_STATUS & ", " & SENT & " , " & SELL_PRICE4 & ", " & SELL_PRICE5 & ", " & QUANTITY1 & ", " & QUANTITY2 & ", " & QUANTITY3 & ", " & QUANTITY4 & ", " & DISCOUNT_PERCENT & ", " & DISCOUNT_VALUE & ", " & DISC_PERC1 & ", " & DISC_PERC2 & ", " & DISC_PERC3 & ", " & DISC_PERC4 & ", " & DISC_PERC5 & ", " & AUDIT_WHO & ", '" & AUDIT_WHEN & "')"
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub dosyaolustur_IBMEntry_entry01(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        Dim dr As DataRow
        Dim barcode As String = ""
        Dim malincinsi As String = ""
        Dim fiyat As String = ""
        Dim departman As String = ""
        Dim tarih As Date = Now
        Dim con As New OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim z As String = sPath & ":" & sFile '"c:\entry01\PLU.TXT"
        Dim dosya As New FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        sayi = 0
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "IBM Entry Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 Then
                If IsNumeric(Trim(dr("sBarkod").ToString)) Then
                    Dim barkod = Trim(dr("sBarkod").ToString)
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If barkoduzunluk >= 5 Then
                        'ürün adi oluþtur
                        malincinsi = UCase(Trim(dr("sAciklama").ToString))
                        malincinsi = Trim(malincinsi)
                        malincinsi = LTrim(malincinsi)
                        malincinsi = RTrim(malincinsi)
                        malincinsi = degeruzunlukkontrol(malincinsi, 16)
                        If sFiyatTipi <> 1 Then
                            If dr("FIYAT" & sFiyatTipi & "") = 0 Then
                                fiyat = dr("FIYAT1")
                            Else
                                fiyat = dr("FIYAT" & sFiyatTipi & "")
                            End If
                        Else
                            fiyat = dr("FIYAT1")
                        End If
                        fiyat = FormatNumber(fiyat * 100, 0)
                        fiyat = fiyat.Replace(",", "")
                        fiyat = fiyat.Replace(".", ",")
                        'barcode oluþtur
                        'barcode = dr("sBarkod")
                        If Len(Trim(barkod)) = 5 Then
                            barcode = sGramaj & barkod & "000000"
                        ElseIf Len(barkod) = 6 Then
                            barcode = CType(barkod, Integer)
                        Else
                            barcode = barkod
                        End If
                        barcode = degeruzunlukkontrol(barcode, 25)
                        fiyat = degeruzunlukkontrol(fiyat, 9)
                    End If
                    'departman
                    departman = ""
                    departman += sayiuzunlukkontrol(Replace(Left(dr("sKdvTipi"), 2), ".", ""), 2)
                    departman = CType(departman, Integer)
                    'dosyoya yaz
                    sw.WriteLine(barcode & " " & malincinsi & " " & fiyat & " " & departman)
                    sayi += 1
                End If
            End If
            nIndex = nIndex + 1
            'Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolustur_etiket(ByVal miktar As Decimal, ByVal logo As String)
        Dim dr As DataRow
        Dim ncrstokkodu
        Dim ncrmalincinsi
        Dim ncrbarcode = ""
        Dim ncrfiyat
        Dim barcodestd = ""
        Dim sDovizCinsi As String = ""
        Dim z As String = "c:\Formlar\database\etiket.prn"
        Dim firmalogosu = logo 'Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("GlobalParams").GetValue("FIRMALOGOSU")
        Dim dosya As New FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        sayi = 0
        Dim sw As StreamWriter = File.AppendText(z)
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Etiket Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 Then
                If IsNumeric(Trim(dr("sBarkod").ToString)) Then
                    Dim barkod = Trim(dr("sBarkod"))
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If barkoduzunluk >= 5 Then
                        'ürün adi oluþtur
                        ncrmalincinsi = UCase(Trim(dr("sAciklama").ToString))
                        ncrmalincinsi = degeruzunlukkontrol(ncrmalincinsi, 35)
                        If barkoduzunluk = 5 Then
                            barcodestd = "461100600200090"
                        ElseIf barkoduzunluk = 6 Then
                            barcodestd = "4C6203000200090"
                        ElseIf barkoduzunluk = 8 Then
                            If Len(Trim(dr("sKodu"))) = 6 Then
                                barcodestd = "4C6203000200090"
                            ElseIf Len(Trim(dr("sKodu"))) = 8 Then
                                barcodestd = "4G6203000200090"
                            End If
                        ElseIf barkoduzunluk = 13 Then
                            barcodestd = "4F6203000200090"
                        Else
                            barcodestd = "4A6203000200090"
                        End If
                        'stokkodu oluþtur
                        ncrstokkodu = UCase(Trim(dr("sKodu")))
                        ncrstokkodu = degeruzunlukkontrol(ncrstokkodu, 20)
                        'fiyatoluþtur
                        ncrfiyat = FormatNumber(dr("FIYAT1"), 2)
                        If barkoduzunluk = 8 Then
                            If Len(Trim(dr("sKodu"))) = 6 Then
                                ncrbarcode = Trim(dr("sKodu"))
                            ElseIf Len(Trim(dr("sKodu"))) = 8 Then
                                ncrbarcode = Trim(dr("sBarkod"))
                            End If
                        Else
                            ncrbarcode = Trim(dr("sBarkod"))
                        End If
                        If dr("FIYAT1") < 1 Then
                            ncrfiyat = FormatNumber(dr("FIYAT1") * 100, 0)
                            sDovizCinsi = "Kurus"
                        Else
                            ncrfiyat = FormatNumber(dr("FIYAT1"), 2)
                            sDovizCinsi = "TL"
                        End If
                        'dosyoya yaz
                        Dim t As Integer
                        For t = 1 To miktar
                            sw.WriteLine("KI70")
                            sw.WriteLine("L")
                            sw.WriteLine("H12")
                            sw.WriteLine("D11")
                            sw.WriteLine("451100600140035" & ncrmalincinsi & "")
                            sw.WriteLine("" & barcodestd & ncrbarcode & "")
                            sw.WriteLine("461100201900075 " & ncrfiyat & " " & sDovizCinsi & "")
                            'sw.WriteLine("441000202000100 " & FormatNumber(CType(ncrfiyat, Decimal) * 1000000, 0) & " TL")
                            sw.WriteLine("451100500140135" & firmalogosu & "")
                            sw.WriteLine("E")
                            sw.WriteLine("f270")
                            sayi += 1
                        Next
                    End If
                End If
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolustur_etiket_10X10(ByVal miktar As Decimal, ByVal logo As String)
        Dim dr As DataRow
        Dim ncrstokkodu
        Dim ncrmalincinsi
        Dim ncrbarcode = ""
        Dim ncrfiyat
        Dim barcodestd = ""
        Dim sDovizCinsi As String = ""
        Dim z As String = "c:\Formlar\database\etiket.prn"
        Dim firmalogosu = logo 'Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("GlobalParams").GetValue("FIRMALOGOSU")
        Dim dosya As New FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        sayi = 0
        Dim sw As StreamWriter = File.AppendText(z)
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Etiket Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 Then
                If IsNumeric(Trim(dr("sBarkod").ToString)) Then
                    Dim barkod = Trim(dr("sBarkod").ToString)
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If barkoduzunluk >= 5 Then
                        'ürün adi oluþtur
                        ncrmalincinsi = UCase(Trim(dr("sAciklama").ToString))
                        ncrmalincinsi = degeruzunlukkontrol(ncrmalincinsi, 35)
                        If barkoduzunluk = 5 Then
                            barcodestd = "361100600500275"
                        ElseIf barkoduzunluk = 6 Then
                            barcodestd = "3C6203000500275"
                        ElseIf barkoduzunluk = 8 Then
                            If Len(Trim(dr("sKodu"))) = 6 Then
                                barcodestd = "3C6203000500275"
                            ElseIf Len(Trim(dr("sKodu"))) = 8 Then
                                barcodestd = "3G6203000500275"
                            End If
                        ElseIf barkoduzunluk = 13 Then
                            barcodestd = "3F6203000500275"
                        Else
                            barcodestd = "3A6203000500275"
                        End If
                        'stokkodu oluþtur
                        ncrstokkodu = UCase(Trim(dr("sKodu").ToString))
                        ncrstokkodu = degeruzunlukkontrol(ncrstokkodu, 20)
                        'fiyatoluþtur
                        ncrfiyat = FormatNumber(dr("FIYAT1"), 2)
                        If barkoduzunluk = 8 Then
                            If Len(Trim(dr("sKodu"))) = 6 Then
                                ncrbarcode = Trim(dr("sKodu"))
                            ElseIf Len(Trim(dr("sKodu"))) = 8 Then
                                ncrbarcode = Trim(dr("sBarkod"))
                            End If
                        Else
                            ncrbarcode = Trim(dr("sBarkod"))
                        End If
                        If dr("FIYAT1") < 1 Then
                            ncrfiyat = FormatNumber(dr("FIYAT1") * 100, 0)
                            sDovizCinsi = "Kurus"
                        Else
                            ncrfiyat = FormatNumber(dr("FIYAT1"), 2)
                            sDovizCinsi = "TL"
                        End If
                        'dosyoya yaz
                        Dim t As Integer
                        For t = 1 To miktar
                            sw.WriteLine("KI70")
                            sw.WriteLine("L")
                            sw.WriteLine("H12")
                            sw.WriteLine("D11")
                            sw.WriteLine("451300600140125" & ncrmalincinsi & "")
                            sw.WriteLine("" & barcodestd & ncrbarcode & "")
                            sw.WriteLine("462300300700275" & ncrfiyat & " " & sDovizCinsi & "")
                            'sw.WriteLine("441000202000100 " & FormatNumber(CType(ncrfiyat, Decimal) * 1000000, 0) & " TL")
                            sw.WriteLine("451200500140350" & firmalogosu & "")
                            sw.WriteLine("E")
                            sw.WriteLine("f270")
                            sayi += 1
                        Next
                    End If
                End If
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolustur_etiket_10X15(ByVal miktar As Decimal, ByVal logo As String)
        Dim dr As DataRow
        Dim ncrstokkodu
        Dim ncrmalincinsi
        Dim ncrbarcode = ""
        Dim ncrfiyat
        Dim barcodestd = ""
        Dim sDovizCinsi As String = ""
        Dim z As String = "c:\Formlar\database\etiket.prn"
        Dim firmalogosu = logo 'Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("GlobalParams").GetValue("FIRMALOGOSU")
        Dim dosya As New FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        sayi = 0
        Dim sw As StreamWriter = File.AppendText(z)
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Etiket Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 Then
                If IsNumeric(Trim(dr("sBarkod").ToString)) Then
                    Dim barkod = Trim(dr("sBarkod").ToString)
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If barkoduzunluk >= 5 Then
                        'ürün adi oluþtur
                        ncrmalincinsi = UCase(Trim(dr("sAciklama").ToString))
                        ncrmalincinsi = degeruzunlukkontrol(ncrmalincinsi, 25)
                        If barkoduzunluk = 5 Then
                            barcodestd = "361100600500275"
                        ElseIf barkoduzunluk = 6 Then
                            barcodestd = "3C6203000500275"
                        ElseIf barkoduzunluk = 8 Then
                            If Len(Trim(dr("sKodu"))) = 6 Then
                                barcodestd = "3C6203000500275"
                            ElseIf Len(Trim(dr("sKodu"))) = 8 Then
                                barcodestd = "3G6203000500275"
                            End If
                        ElseIf barkoduzunluk = 13 Then
                            barcodestd = "3F6203000500275"
                        Else
                            barcodestd = "3A6203000500275"
                        End If
                        'stokkodu oluþtur
                        ncrstokkodu = UCase(Trim(dr("sKodu").ToString))
                        ncrstokkodu = degeruzunlukkontrol(ncrstokkodu, 20)
                        'fiyatoluþtur
                        ncrfiyat = FormatNumber(dr("FIYAT1"), 2)
                        If barkoduzunluk = 8 Then
                            If Len(Trim(dr("sKodu"))) = 6 Then
                                ncrbarcode = Trim(dr("sKodu"))
                            ElseIf Len(Trim(dr("sKodu"))) = 8 Then
                                ncrbarcode = Trim(dr("sBarkod"))
                            End If
                        Else
                            ncrbarcode = Trim(dr("sBarkod"))
                        End If
                        If dr("FIYAT1") < 1 Then
                            ncrfiyat = FormatNumber(dr("FIYAT1") * 100, 0)
                            sDovizCinsi = "Krs"
                        Else
                            ncrfiyat = FormatNumber(dr("FIYAT1"), 2)
                            sDovizCinsi = "TL"
                        End If
                        'dosyoya yaz
                        Dim t As Integer
                        For t = 1 To miktar
                            sw.WriteLine("KI70")
                            sw.WriteLine("L")
                            sw.WriteLine("H12")
                            sw.WriteLine("D11")
                            sw.WriteLine("442300600140125" & ncrmalincinsi & "")
                            sw.WriteLine("" & barcodestd & ncrbarcode & "")
                            sw.WriteLine("462300502500275" & ncrfiyat & " " & sDovizCinsi & "")
                            sw.WriteLine("451200500140350" & firmalogosu & "")
                            sw.WriteLine("E")
                            sw.WriteLine("f270")
                            sayi += 1
                        Next
                    End If
                End If
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolustur_etiket_intermec(ByVal miktar As Decimal, ByVal logo As String)
        Dim dr As DataRow
        Dim ncrstokkodu
        Dim ncrmalincinsi
        Dim ncrbarcode
        Dim ncrfiyat
        Dim barcodestd
        Dim sDovizCinsi As String = ""
        Dim z As String = "c:\Formlar\database\etiket.prn"
        Dim firmalogosu = logo 'Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("GlobalParams").GetValue("FIRMALOGOSU")
        Dim dosya As New FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        sayi = 0
        Dim sw As StreamWriter = File.AppendText(z)
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Etiket Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 Then
                If IsNumeric(Trim(dr("sBarkod").ToString)) Then
                    Dim barkod = Trim(dr("sBarkod"))
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If barkoduzunluk >= 5 Then
                        'ürün adi oluþtur
                        ncrmalincinsi = UCase(Trim(dr("sAciklama").ToString))
                        ncrmalincinsi = degeruzunlukkontrol(ncrmalincinsi, 35)
                        If barkoduzunluk = 5 Then
                            barcodestd = "B190,53,1,E30,2,0,66,B,"
                        ElseIf barkoduzunluk = 6 Then
                            barcodestd = "B190,53,1,E30,2,0,66,B,"
                        ElseIf barkoduzunluk = 8 Then
                            barcodestd = "B190,53,1,E80,3,0,66,B,"
                        ElseIf barkoduzunluk = 13 Then
                            barcodestd = "B190,53,1,E30,2,0,66,B,"
                        Else
                            barcodestd = "B190,53,1,E30,2,0,66,B,"
                        End If
                        'stokkodu oluþtur
                        ncrstokkodu = UCase(Trim(dr("sKodu").ToString))
                        ncrstokkodu = degeruzunlukkontrol(ncrstokkodu, 20)
                        'fiyatoluþtur
                        ncrfiyat = FormatNumber(dr("FIYAT1"), 2)
                        ncrbarcode = Trim(dr("sBarkod"))
                        If dr("FIYAT1") < 1 Then
                            ncrfiyat = FormatNumber(dr("FIYAT1") * 100, 0)
                            sDovizCinsi = "Kurus"
                        Else
                            ncrfiyat = FormatNumber(dr("FIYAT1"), 2)
                            sDovizCinsi = "TL"
                        End If
                        'dosyoya yaz
                        Dim t
                        For t = 1 To miktar
                            sw.WriteLine("")
                            sw.WriteLine("ON,D")
                            sw.WriteLine("Q767,31-8")
                            sw.WriteLine("q303")
                            sw.WriteLine("S2")
                            sw.WriteLine("D10")
                            sw.WriteLine("ZT")
                            sw.WriteLine("JF")
                            sw.WriteLine("")
                            sw.WriteLine("N")
                            sw.WriteLine("A274,34,1,2,4,2,N,""" & ncrmalincinsi & """")
                            sw.WriteLine("A190,342,1,2,5,3,N,""" & ncrfiyat & " " & sDovizCinsi & """")
                            sw.WriteLine("A105,710,0,1,1,2,N,""" & Today & """")
                            sw.WriteLine("" & barcodestd & """" & ncrbarcode & """")
                            'sw.WriteLine("A110,342,1,2,2,2,N,""" & FormatNumber(CType(ncrfiyat, Decimal) * 1000000, 0) & " TL""")
                            sw.WriteLine("A70,100,1,2,3,2,N,""" & firmalogosu & """")
                            sw.WriteLine("P1")
                            sayi += 1
                        Next
                    End If
                End If
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolustur_zebra_rafetiket(ByVal miktar As Decimal, ByVal logo As String)
        Dim dr As DataRow
        Dim ncrstokkodu
        Dim ncrmalincinsi
        Dim ncrbarcode
        Dim ncrfiyat
        Dim barcodestd
        Dim sDovizCinsi As String = ""
        Dim z As String = "c:\Formlar\database\etiket.prn"
        Dim firmalogosu = logo 'Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("GlobalParams").GetValue("FIRMALOGOSU")
        Dim dosya As New FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        sayi = 0
        Dim sw As StreamWriter = File.AppendText(z)
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Etiket Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 Then
                If IsNumeric(Trim(dr("sBarkod").ToString)) Then
                    Dim barkod = Trim(dr("sBarkod").ToString)
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If barkoduzunluk >= 5 Then
                        'ürün adi oluþtur
                        ncrmalincinsi = UCase(dr("sAciklama"))
                        ncrmalincinsi = degeruzunlukkontrol(ncrmalincinsi, 35)
                        If barkoduzunluk = 5 Then
                            barcodestd = "6"
                        ElseIf barkoduzunluk = 6 Then
                            barcodestd = "6"
                        ElseIf barkoduzunluk = 8 Then
                            barcodestd = "8"
                        ElseIf barkoduzunluk = 13 Then
                            barcodestd = "E"
                        Else
                            barcodestd = "E"
                        End If
                        'stokkodu oluþtur
                        ncrstokkodu = UCase(Trim(dr("sKodu").ToString))
                        ncrstokkodu = degeruzunlukkontrol(ncrstokkodu, 20)
                        'fiyatoluþtur
                        ncrfiyat = FormatNumber(dr("FIYAT1"), 2)
                        ncrbarcode = Trim(dr("sBarkod"))
                        If dr("FIYAT1") < 1 Then
                            ncrfiyat = FormatNumber(dr("FIYAT1") * 100, 0)
                            sDovizCinsi = "Kurus"
                        Else
                            ncrfiyat = FormatNumber(dr("FIYAT1"), 2)
                            sDovizCinsi = "TL"
                        End If
                        'dosyoya yaz
                        Dim t
                        For t = 1 To miktar
                            sw.WriteLine("^XA")
                            sw.WriteLine("^FO130,100")
                            sw.WriteLine("^B" & barcodestd & "R,50,Y,N")
                            sw.WriteLine("^FD" & ncrbarcode & "^FS")
                            sw.WriteLine("^FWR^CFD^FS")
                            sw.WriteLine("^FWR^CFD^FS")
                            sw.WriteLine("^FO210,60,^AQR,80,15^FD" & ncrmalincinsi & "^FS")
                            sw.WriteLine("^FWR^CFD^FS")
                            sw.WriteLine("^FO120,370,120,^AQR,90,25^FD" & ncrfiyat & " " & sDovizCinsi & "^FS")
                            sw.WriteLine("^FWR^CFD^FS")
                            'sw.WriteLine("^FO60,370,120,^AQR,70,15^FD" & FormatNumber(CType(ncrfiyat, Decimal) * 1000000, 0) & " TL^FS")
                            sw.WriteLine("^FWR^CFD^FS")
                            sw.WriteLine("^FO1,100,10,^AQR,60,15^FD" & firmalogosu & "^FS")
                            sw.WriteLine("^XZ")
                            sayi += 1
                        Next
                    End If
                End If
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolustur_zebra_10X10(ByVal miktar As Decimal, ByVal logo As String)
        Dim dr As DataRow
        Dim ncrstokkodu
        Dim ncrmalincinsi
        Dim ncrbarcode
        Dim ncrfiyat
        Dim barcodestd
        Dim sDovizCinsi As String = ""
        Dim z As String = "c:\Formlar\database\etiket.prn"
        Dim firmalogosu = logo 'Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("GlobalParams").GetValue("FIRMALOGOSU")
        Dim dosya As New FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        sayi = 0
        Dim sw As StreamWriter = File.AppendText(z)
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Etiket Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 Then
                If IsNumeric(Trim(dr("sBarkod").ToString)) Then
                    Dim barkod = Trim(dr("sBarkod").ToString)
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If barkoduzunluk >= 5 Then
                        'ürün adi oluþtur
                        ncrmalincinsi = UCase(dr("sAciklama"))
                        ncrmalincinsi = degeruzunlukkontrol(ncrmalincinsi, 35)
                        If barkoduzunluk = 5 Then
                            barcodestd = "6"
                        ElseIf barkoduzunluk = 6 Then
                            barcodestd = "6"
                        ElseIf barkoduzunluk = 8 Then
                            barcodestd = "8"
                        ElseIf barkoduzunluk = 13 Then
                            barcodestd = "E"
                        Else
                            barcodestd = "E"
                        End If
                        'stokkodu oluþtur
                        ncrstokkodu = UCase(dr("sKodu"))
                        ncrstokkodu = degeruzunlukkontrol(ncrstokkodu, 20)
                        'fiyatoluþtur
                        ncrfiyat = FormatNumber(dr("FIYAT1"), 2)
                        ncrbarcode = Trim(dr("sBarkod"))
                        If dr("FIYAT1") < 1 Then
                            ncrfiyat = FormatNumber(dr("FIYAT1") * 100, 0)
                            sDovizCinsi = "Kurus"
                        Else
                            ncrfiyat = FormatNumber(dr("FIYAT1"), 2)
                            sDovizCinsi = "TL"
                        End If
                        'dosyoya yaz
                        Dim t
                        'miktar = dr("MIKTAR")
                        For t = 1 To miktar
                            sw.WriteLine("^XA")
                            sw.WriteLine("^FO200,100")
                            sw.WriteLine("^B" & barcodestd & "R,100,Y,N")
                            sw.WriteLine("^FD" & ncrbarcode & "^FS")
                            sw.WriteLine("^FWR^CFD^FS")
                            sw.WriteLine("^FWR^CFD^FS")
                            sw.WriteLine("^FO600,1,^AQR,150,20^FD" & ncrmalincinsi & "^FS")
                            sw.WriteLine("^FWR^CFD^FS")
                            sw.WriteLine("^FO350,1,120,^AQR,900,60^FD" & ncrfiyat & " TL^FS")
                            sw.WriteLine("^FWR^CFD^FS")
                            'sw.WriteLine("^FO60,370,120,^AQR,70,15^FD" & FormatNumber(CType(ncrfiyat, Decimal) * 1000000, 0) & " TL^FS")
                            sw.WriteLine("^FWR^CFD^FS")
                            sw.WriteLine("^FO10,1,1,^AQR,100,15^FD" & firmalogosu & "^FS")
                            sw.WriteLine("^XZ")
                            sayi += 1
                        Next
                    End If
                End If
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolustur_urunetiket(ByVal miktar As Decimal, ByVal logo As String)
        Dim dr As DataRow
        Dim ncrstokkodu
        Dim ncrmalincinsi
        Dim ncrbarcode = ""
        Dim ncrfiyat
        Dim barcodestd = ""
        Dim z As String = "c:\Formlar\database\etiket.prn"
        Dim dosya As New FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        sayi = 0
        Dim sw As StreamWriter = File.AppendText(z)
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Etiket Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 Then
                If IsNumeric(Trim(dr("sBarkod").ToString)) Then
                    Dim barkod = Trim(dr("sBarkod").ToString)
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If barkoduzunluk >= 5 Then
                        'ürün adi oluþtur
                        ncrmalincinsi = UCase(dr("sAciklama"))
                        ncrmalincinsi = degeruzunlukkontrol(ncrmalincinsi, 25)
                        If barkoduzunluk = 5 Then
                            barcodestd = "C"
                        ElseIf barkoduzunluk = 6 Then
                            barcodestd = "C"
                        ElseIf barkoduzunluk = 8 Then
                            If Len(Trim(dr("sKodu"))) = 6 Then
                                barcodestd = "C"
                            ElseIf Len(Trim(dr("sKodu"))) = 8 Then
                                barcodestd = "G"
                            End If
                        ElseIf barkoduzunluk = 13 Then
                            barcodestd = "F"
                        Else
                            barcodestd = "F"
                        End If
                        'stokkodu oluþtur
                        ncrstokkodu = UCase(Trim(dr("sKodu").ToString))
                        ncrstokkodu = degeruzunlukkontrol(ncrstokkodu, 20)
                        'fiyatoluþtur
                        ncrfiyat = FormatNumber(dr("FIYAT1"), 2)
                        If barkoduzunluk = 8 Then
                            If Len(Trim(dr("sKodu"))) = 6 Then
                                ncrbarcode = Trim(dr("sKodu").ToString)
                            ElseIf Len(Trim(dr("sKodu").ToString)) = 8 Then
                                ncrbarcode = Trim(dr("sBarkod").ToString)
                            End If
                        Else
                            ncrbarcode = Trim(dr("sBarkod").ToString)
                        End If
                        'dosyoya yaz
                        Dim t As Integer
                        For t = 1 To miktar
                            sw.WriteLine("L")
                            sw.WriteLine("D11")
                            sw.WriteLine("4" & barcodestd & "1204000270060" & ncrbarcode & "")
                            sw.WriteLine("421100300100070" & ncrmalincinsi & "")
                            sw.WriteLine("4" & barcodestd & "1204000270130" & ncrbarcode & "")
                            sw.WriteLine("421100300100143" & ncrmalincinsi & "")
                            sw.WriteLine("4" & barcodestd & "1204000270210" & ncrbarcode & "")
                            sw.WriteLine("421100300100223" & ncrmalincinsi & "")
                            sw.WriteLine("4" & barcodestd & "1204000270290" & ncrbarcode & "")
                            sw.WriteLine("421100300100303" & ncrmalincinsi & "")
                            sw.WriteLine("E")
                            sw.WriteLine("f270")
                            sayi += 1
                        Next
                    End If
                End If
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolustur_urunetiket_fiyatli(ByVal miktar As Integer, ByVal logo As String)
        Dim dr As DataRow
        Dim ncrstokkodu As String = ""
        Dim ncrmalincinsi As String = ""
        Dim ncrbarcode As String = ""
        Dim ncrfiyat
        Dim barcodestd = ""
        Dim sDovizCinsi As String = ""
        Dim z As String = "c:\Formlar\database\etiket.prn"
        Dim dosya As New FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        sayi = 0
        Dim sw As StreamWriter = File.AppendText(z)
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Etiket Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 Then
                If IsNumeric(Trim(dr("sBarkod").ToString)) Then
                    Dim barkod = Trim(dr("sBarkod"))
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If barkoduzunluk >= 5 Then
                        'ürün adi oluþtur
                        ncrmalincinsi = UCase(dr("sAciklama"))
                        ncrmalincinsi = degeruzunlukkontrol(ncrmalincinsi, 25)
                        If barkoduzunluk = 5 Then
                            barcodestd = "C"
                        ElseIf barkoduzunluk = 6 Then
                            barcodestd = "C"
                        ElseIf barkoduzunluk = 8 Then
                            If Len(Trim(dr("sKodu"))) = 6 Then
                                barcodestd = "C"
                            ElseIf Len(Trim(dr("sKodu"))) = 8 Then
                                barcodestd = "G"
                            End If
                        ElseIf barkoduzunluk = 13 Then
                            barcodestd = "F"
                        Else
                            barcodestd = "F"
                        End If
                        'stokkodu oluþtur
                        ncrstokkodu = UCase(Trim(dr("sKodu").ToString))
                        ncrstokkodu = degeruzunlukkontrol(ncrstokkodu, 20)
                        'fiyatoluþtur
                        ncrfiyat = FormatNumber(dr("FIYAT1"), 2)
                        If barkoduzunluk = 8 Then
                            If Len(Trim(dr("sKodu"))) = 6 Then
                                ncrbarcode = Trim(dr("sKodu"))
                            ElseIf Len(Trim(dr("sKodu"))) = 8 Then
                                ncrbarcode = Trim(dr("sBarkod"))
                            End If
                        Else
                            ncrbarcode = Trim(dr("sBarkod"))
                        End If
                        If dr("FIYAT1") < 1 Then
                            ncrfiyat = FormatNumber(dr("FIYAT1") * 100, 0)
                            sDovizCinsi = "Kurus"
                        Else
                            ncrfiyat = FormatNumber(dr("FIYAT1"), 2)
                            sDovizCinsi = "TL"
                        End If
                        'dosyoya yaz
                        Dim t
                        For t = 1 To miktar
                            sw.WriteLine("L")
                            sw.WriteLine("D11")
                            sw.WriteLine("4" & barcodestd & "1202000270040" & ncrbarcode & "")
                            sw.WriteLine("421100300100050" & ncrmalincinsi & "")
                            sw.WriteLine("421200300600070" & ncrfiyat & " " & sDovizCinsi & "")
                            sw.WriteLine("4" & barcodestd & "1202000270110" & ncrbarcode & "")
                            sw.WriteLine("421100300100123" & ncrmalincinsi & "")
                            sw.WriteLine("421200300600143" & ncrfiyat & " " & sDovizCinsi & "")
                            sw.WriteLine("4" & barcodestd & "1202000270190" & ncrbarcode & "")
                            sw.WriteLine("421100300100203" & ncrmalincinsi & "")
                            sw.WriteLine("421200300600223" & ncrfiyat & " " & sDovizCinsi & "")
                            sw.WriteLine("4" & barcodestd & "1202000270270" & ncrbarcode & "")
                            sw.WriteLine("421100300100283" & ncrmalincinsi & "")
                            sw.WriteLine("421200300600303" & ncrfiyat & " " & sDovizCinsi & "")
                            sw.WriteLine("E")
                            sw.WriteLine("f270")
                            sayi += 1
                        Next
                    End If
                End If
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolustur_zebra_urunetiket(ByVal miktar As Decimal, ByVal logo As String)
        Dim dr As DataRow
        Dim ncrstokkodu
        Dim ncrmalincinsi
        Dim ncrbarcode
        Dim ncrfiyat
        Dim barcodestd
        Dim z As String = "c:\Formlar\database\etiket.prn"
        Dim dosya As New FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        sayi = 0
        Dim sw As StreamWriter = File.AppendText(z)
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Etiket Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 Then
                If IsNumeric(Trim(dr("sBarkod").ToString)) Then
                    Dim barkod = Trim(dr("sBarkod").ToString)
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    If barkoduzunluk >= 5 Then
                        'ürün adi oluþtur
                        ncrmalincinsi = UCase(dr("sAciklama"))
                        ncrmalincinsi = degeruzunlukkontrol(ncrmalincinsi, 20)
                        If barkoduzunluk = 5 Then
                            barcodestd = "6"
                        ElseIf barkoduzunluk = 6 Then
                            barcodestd = "6"
                        ElseIf barkoduzunluk = 8 Then
                            barcodestd = "8"
                        ElseIf barkoduzunluk = 13 Then
                            barcodestd = "E"
                        Else
                            barcodestd = "E"
                        End If
                        'stokkodu oluþtur
                        ncrstokkodu = UCase(dr("sKodu"))
                        ncrstokkodu = degeruzunlukkontrol(ncrstokkodu, 20)
                        'fiyatoluþtur
                        ncrfiyat = FormatNumber(dr("FIYAT1"), 2)
                        ncrbarcode = Trim(dr("sBarkod"))
                        'dosyoya yaz
                        Dim t
                        For t = 1 To miktar
                            sw.WriteLine("^XA")
                            sw.WriteLine("^FO50,130")
                            sw.WriteLine("^B" & barcodestd & "B,70,Y,N")
                            sw.WriteLine("^FD" & ncrbarcode & "^FS")
                            sw.WriteLine("^FWB^CFD^FS")
                            sw.WriteLine("^FO20,2,^FD" & ncrmalincinsi & "^FS")
                            sw.WriteLine("^FO210,130")
                            sw.WriteLine("^B" & barcodestd & "B,70,Y,N")
                            sw.WriteLine("^FD" & ncrbarcode & "^FS")
                            sw.WriteLine("^FWD^CFD^FS")
                            sw.WriteLine("^FO180,2^FD" & ncrmalincinsi & "^FS")
                            sw.WriteLine("^FO370,130")
                            sw.WriteLine("^B" & barcodestd & "B,70,Y,N")
                            sw.WriteLine("^FD" & ncrbarcode & "^FS")
                            sw.WriteLine("^FWD^CFD^FS")
                            sw.WriteLine("^FO340,2^FD" & ncrmalincinsi & "^FS")
                            sw.WriteLine("^FO530,130")
                            sw.WriteLine("^B" & barcodestd & "B,70,Y,N")
                            sw.WriteLine("^FD" & ncrbarcode & "^FS")
                            sw.WriteLine("^FWD^CFD^FS")
                            sw.WriteLine("^FO500,2^FD" & ncrmalincinsi & "^FS")
                            sw.WriteLine("^XZ")
                            sayi += 1
                        Next
                    End If
                End If
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    'neshba 
    Private Sub dosyaolusturIBM(ByVal spath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        Dim dr As DataRow
        Dim IBMstokkodu1
        Dim IBMmalincinsi1
        Dim IBMstokkodu2
        Dim IBMstokkodu3
        Dim IBMmalincinsi2
        Dim IBMmalincinsi3
        Dim IBMbarcode As String = ""
        Dim IBMfiyat
        Dim IBMdepartman As String = ""
        Dim IBMbarcodestd1
        Dim IBMbarcodestd2
        Dim IBMbarcodestd3
        Dim sAyrac As String = ":"

        If spath = "\\tsclient\C" Or spath = "\\tsclient\D" Or spath = "\\tsclient\E" Or spath = "\\tsclient\F" Then
            sAyrac = ""
        End If
        Dim z As String = spath & sAyrac & sFile
        Dim dosya As New FileInfo(z)
        If dosya.Exists Then
            dosya.Delete()
        End If
        sayi = 0
        'Dim sw As StreamWriter = File.CreateText(z)
        Dim sw As StreamWriter = File.AppendText(z)
        'sw.WriteLine("<SIGNATURE=GNDPLU.GDF><VERSION=0223000>")
        sw.WriteLine("<SIGNATURE=GNDPLU.GDF><VERSION=220001>")
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "IBM Stok Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT1") > 0 Then

                'If IsNumeric(dr("sBarkod")) Then
                Dim barkod = Trim(dr("sBarkod"))
                Dim barkoduzunluk As Integer
                If IsDBNull(barkod) = True Then
                    barkoduzunluk = 0
                Else
                    barkoduzunluk = barkod.length
                End If
                If barkoduzunluk >= 5 Then
                    'ürün adi oluþtur
                    IBMmalincinsi1 = UCase(Trim(dr("sAciklama").ToString))
                    IBMmalincinsi1 = degeruzunlukkontrol(Trim(IBMmalincinsi1), 40)
                    'ürün adi2 oluþtur
                    IBMmalincinsi2 = UCase(Trim(dr("sAciklama").ToString))
                    IBMmalincinsi2 = degeruzunlukkontrol(Trim(IBMmalincinsi2), 20)
                    'ürün adi3 oluþtur
                    IBMmalincinsi3 = UCase(Trim(dr("sAciklama").ToString))
                    IBMmalincinsi3 = degeruzunlukkontrol(Trim(IBMmalincinsi3), 16)
                    'stokkodu1 oluþtur
                    IBMstokkodu1 = UCase(Trim(dr("sKodu").ToString))
                    IBMstokkodu1 = Replace(IBMstokkodu1, ".", "-")
                    IBMstokkodu1 = degeruzunlukkontrol(Trim(IBMstokkodu1), 24)
                    'stokkodu2 oluþtur
                    IBMstokkodu2 = UCase(dr("sKodu"))
                    IBMstokkodu2 = Replace(IBMstokkodu2, ".", "-")
                    IBMstokkodu2 = degeruzunlukkontrol(Trim(IBMstokkodu2), 24)
                    'stokkodu3 oluþtur
                    IBMstokkodu3 = UCase(dr("sKodu"))
                    IBMstokkodu3 = Replace(IBMstokkodu2, ".", "-")
                    IBMstokkodu3 = degeruzunlukkontrol(Trim(IBMstokkodu2), 3)
                    'fiyatoluþtur
                    Dim satisfiyati As Decimal = 0
                    If sFiyatTipi <> 1 Then
                        If dr("lFiyat") = 0 Then
                            satisfiyati = dr("FIYAT1")
                        Else
                            satisfiyati = dr("lFiyat")
                        End If
                    Else
                        satisfiyati = dr("FIYAT1")
                    End If
                    IBMfiyat = FormatNumber(satisfiyati, 2)
                    IBMfiyat = IBMfiyat.Replace(",", ",")
                    IBMfiyat = IBMfiyat.Replace(".", ",")
                    'Dim fiyatfark As Integer = 15 - Len(IBMfiyat)
                    'Dim fiyatuzunluk = Len(IBMfiyat)
                    'For i = 1 To fiyatfark
                    '    IBMfiyat = IBMfiyat.insert(fiyatuzunluk, " ")
                    'Next
                    IBMfiyat = degeruzunlukkontrol(IBMfiyat, 15)
                    'barcode oluþtur
                    'IBMbarcode = dr("sBarkod")
                    'Dim barkodfark As Integer = 21 - Len(IBMbarcode)
                    'For i = 1 To barkodfark
                    '    IBMbarcode = IBMbarcode.insert(0, "0")
                    'Next
                    If Len(Trim(barkod)) = 5 Then
                        IBMbarcode = degeruzunlukkontrol(sGramaj + barkod.ToString, 24)
                        IBMbarcode = degeruzunlukkontrol(IBMbarcode, 24)
                        IBMstokkodu1 = degeruzunlukkontrol(sGramaj + barkod, 24)
                    ElseIf Len(barkod) = 6 Then
                        IBMbarcode = barkod.ToString
                        IBMbarcode = degeruzunlukkontrol(IBMbarcode, 24)
                    ElseIf Len(barkod) = 8 Then
                        IBMbarcode = degeruzunlukkontrol(barkod, 24)
                    ElseIf Len(barkod) = 11 Then
                        IBMbarcode = degeruzunlukkontrol(barkod, 24)
                    ElseIf Len(barkod) = 12 Then
                        IBMbarcode = barkod.ToString
                        IBMbarcode = degeruzunlukkontrol(IBMbarcode, 24)
                    ElseIf Len(barkod) = 13 Then
                        IBMbarcode = barkod.ToString
                        IBMbarcode = degeruzunlukkontrol(IBMbarcode, 24)
                    ElseIf Len(barkod) = 14 Then
                        IBMbarcode = barkod.ToString
                        IBMbarcode = degeruzunlukkontrol(IBMbarcode, 24)
                    Else
                        IBMbarcode = degeruzunlukkontrol(IBMbarcode, 24)
                    End If
                    'barcode standardý
                    If Len(Trim(barkod)) = 5 Then
                        IBMbarcodestd1 = "001 "
                        IBMbarcodestd2 = "11000           "
                        IBMbarcodestd3 = "10"
                    ElseIf Len(barkod) = 6 Then
                        IBMbarcodestd1 = "201 "
                        IBMbarcodestd2 = "11000           "
                        IBMbarcodestd3 = "00"
                    Else
                        IBMbarcodestd1 = "1001"
                        IBMbarcodestd2 = "01              "
                        IBMbarcodestd3 = "00"
                    End If
                    'departman
                    If dr("nKdvOrani") = 0 Then
                        IBMdepartman = "10  "
                    ElseIf dr("nKdvOrani") = 1 Then
                        IBMdepartman = "20  "
                    ElseIf dr("nKdvOrani") = 8 Then
                        IBMdepartman = "30  "
                    ElseIf dr("nKdvOrani") = 18 Then
                        IBMdepartman = "40  "
                    End If
                    'IBMdepartman = ""
                    'IBMdepartman += degeruzunlukkontrol(Replace(Left(dr("sKdvTipi"), 2), ".", ""), 3)
                    'dosyaya yaz
                    'sw.WriteLine("01  " & 1 & IBMstokkodu1 & IBMstokkodu1 & IBMmalincinsi2 & IBMstokkodu2 & IBMmalincinsi1 & IBMmalincinsi1 & IBMmalincinsi3 & "                                00              0                                            " & IBMbarcodestd2 & "1                              1           1           " & "00" & IBMfiyat & "0              0              0              0              0              0              0              0              0              0 0 0 0 0 0 0 0 0 0 1023  " & IBMdepartman & IBMdepartman & "00              0              0  0              00000001                    0     0              0     0              0              0              " & IBMbarcodestd3 & "              0              0              0              0              0              0              0              0              0     " & IBMfiyat)
                    sw.WriteLine("01  " & 1 & IBMstokkodu1 & IBMstokkodu1 & IBMmalincinsi1 & IBMmalincinsi1 & IBMmalincinsi2 & IBMmalincinsi2 & IBMmalincinsi3 & IBMstokkodu3 & "     02                      00,00           0,00           0                             00              0                              0           0           " & "00" & IBMfiyat & "0              0              0              0              0              0              0              0              0              0 0 0 0 0 0 0 0 0 0 1023  " & "00" & IBMdepartman & "00              0              0  0              00000021                    0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000     ")

                    sw.WriteLine("02  " & 1 & IBMstokkodu1 & IBMbarcode & IBMbarcode & "1     " & IBMbarcodestd1 & "" & IBMfiyat)
                    sayi += 1
                End If
            End If
            'End If
            nIndex = nIndex + 1
            'Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolusturSHARP_yeni(ByVal sender As String, ByVal parametre1 As String, ByVal parametre2 As String, ByVal sFile As String, ByVal sFiyatTipi As Integer, ByVal sGramaj As String, ByVal sAdetli As String)
        Dim dr As DataRow
        Dim plu As String
        Dim malincinsi As String
        Dim departman As String
        Dim fiyat
        'If SAVE.ShowDialog = DialogResult.OK Then
        Dim z As String = sFile
        Dim DOSYA As New FileInfo(z)
        If DOSYA.Exists Then
            DOSYA.Delete()
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        sw.WriteLine(sender)
        'sw.WriteLine("")
        sayi = 0
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Sharp Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT" & sFiyatTipi & "") > 0 And dr("FIYAT" & sFiyatTipi & "") < 1000000000 Then
                If IsNumeric(Trim(dr("sBarkod").ToString)) Then
                    Dim barkod = Trim(dr("sBarkod").ToString)
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    Dim satisfiyati = dr("FIYAT" & sFiyatTipi & "")
                    'plu oluþtur
                    If barkoduzunluk >= 5 Then
                        If Len(barkod) = 13 Then
                            plu = "0"
                            plu += barkod
                        ElseIf Len(barkod) = 8 Then
                            plu = "100000"
                            plu += (barkod)
                        ElseIf Len(Trim(barkod)) = 5 Then
                            'plu = "027"
                            plu = sGramaj.ToString
                            plu += (barkod)
                            plu += "000000"
                        ElseIf Len(barkod) = 6 Then
                            plu = "50000000"
                            plu += (barkod)
                        ElseIf Len(barkod) = 12 Then
                            plu = "40"
                            plu += (barkod)
                        ElseIf Len(barkod) > 14 Then
                            plu = (barkod)
                            plu = Microsoft.VisualBasic.Left(plu, 14)
                        Else
                            'buraya dikkat et
                            plu = "00000000000000"
                        End If
                        'malincinsi oluþtur
                        malincinsi = " " + UCase(Trim(dr("sAciklama").ToString))
                        malincinsi = degeruzunlukkontrol(malincinsi, 17)
                        departman = " "
                        departman += sayiuzunlukkontrol(Replace(Left(dr("sKdvTipi"), 2), ".", ""), 2)
                        'fiyat oluþtur
                        fiyat = sayiuzunlukkontrol(FormatNumber(dr("FIYAT" & sFiyatTipi & ""), 2).Replace(".", "").Replace(",", ""), 8)
                        sw.WriteLine(plu & departman & parametre1 & parametre2 & fiyat & malincinsi)
                        sayi += 1
                    End If
                End If
            Else
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolusturSHARP_fiyat(ByVal sender As String, ByVal parametre1 As String, ByVal parametre2 As String, ByVal sFile As String, ByVal sFiyatTipi As Integer, ByVal sGramaj As String, ByVal sAdetli As String)
        Dim dr As DataRow
        Dim plu As String
        Dim malincinsi As String
        Dim departman As String
        Dim fiyat
        'If SAVE.ShowDialog = DialogResult.OK Then
        Dim z As String = sFile
        Dim DOSYA As New FileInfo(z)
        If DOSYA.Exists Then
            DOSYA.Delete()
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        sw.WriteLine(sender)
        'sw.WriteLine("")
        sayi = 0
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Sharp Stok Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            If dr("FIYAT" & sFiyatTipi & "") > 0 And dr("FIYAT" & sFiyatTipi & "") < 1000000000 Then
                If IsNumeric(Trim(dr("sBarkod").ToString)) Then
                    Dim barkod = Trim(dr("sBarkod").ToString)
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    Dim satisfiyati = dr("FIYAT" & sFiyatTipi & "")
                    'plu oluþtur
                    If barkoduzunluk >= 5 Then
                        If Len(barkod) = 13 Then
                            plu = "0"
                            plu += barkod
                        ElseIf Len(barkod) = 8 Then
                            plu = "100000"
                            plu += (barkod)
                        ElseIf Len(Trim(barkod)) = 5 Then
                            'plu = "027"
                            plu = sGramaj.ToString
                            plu += (barkod)
                            plu += "000000"
                        ElseIf Len(barkod) = 6 Then
                            plu = "50000000"
                            plu += (barkod)
                        ElseIf Len(barkod) = 12 Then
                            plu = "40"
                            plu += (barkod)
                        ElseIf Len(barkod) > 14 Then
                            plu = (barkod)
                            plu = Microsoft.VisualBasic.Left(plu, 14)
                        Else
                            'buraya dikkat et
                            plu = "00000000000000"
                        End If
                        'malincinsi oluþtur
                        malincinsi = " " + UCase(Trim(dr("sAciklama").ToString))
                        malincinsi = degeruzunlukkontrol(malincinsi, 17)
                        departman = " "
                        departman += sayiuzunlukkontrol(Replace(Left(dr("sKdvTipi"), 2), ".", ""), 2)
                        fiyat = sayiuzunlukkontrol(FormatNumber(dr("FIYAT" & sFiyatTipi & ""), 2).Replace(".", "").Replace(",", ""), 8)
                        sw.WriteLine(plu & " " & fiyat & malincinsi)
                        sayi += 1
                    End If
                End If
            Else
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Private Sub dosyaolusturSHARP_plu(ByVal sender As String, ByVal parametre1 As String, ByVal parametre2 As String, ByVal sFile As String, ByVal sFiyatTipi As Integer, ByVal sGramaj As String, ByVal sAdetli As String)
        Dim dr As DataRow
        Dim plu As String
        Dim malincinsi As String
        Dim departman As String
        Dim fiyat
        Dim z As String = sFile
        Dim DOSYA As New FileInfo(z)
        If DOSYA.Exists Then
            DOSYA.Delete()
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        sw.WriteLine(sender)
        'sw.WriteLine("")
        sayi = 0
        Progress.ShowProgress(dataset1.Tables(0).Rows.Count(), "Sharp Plu Dosyasý Oluþturuluyor...")
        Dim nIndex As Integer = 0
        For Each dr In dataset1.Tables(0).Rows
            plu = ""
            If dr("FIYAT" & sFiyatTipi & "") > 0 And dr("FIYAT" & sFiyatTipi & "") < 1000000000 Then
                If IsNumeric(Trim(dr("sBarkod").ToString)) Then
                    Dim barkod = Trim(dr("sBarkod"))
                    Dim barkoduzunluk As Integer
                    If IsDBNull(barkod) = True Then
                        barkoduzunluk = 0
                    Else
                        barkoduzunluk = barkod.length
                    End If
                    Dim satisfiyati = dr("FIYAT1")
                    'plu oluþtur
                    If barkoduzunluk <= 6 Then
                        If Len(barkod) = 6 Then
                            plu += barkod
                        ElseIf Len(Trim(barkod)) = 5 Then
                            plu = "0"
                            plu += (barkod)
                            'plu += "000000"
                        Else
                            'buraya dikkat et
                            plu = "000000"
                        End If
                        'malincinsi oluþtur
                        malincinsi = " " + UCase(Trim(dr("sAciklama").ToString))
                        malincinsi = degeruzunlukkontrol(malincinsi, 17)
                        'departman oluþtur
                        departman = " "
                        departman += sayiuzunlukkontrol(Replace(Left(dr("sKdvTipi"), 2), ".", ""), 2)
                        fiyat = sayiuzunlukkontrol(FormatNumber(dr("FIYAT" & sFiyatTipi & ""), 2).Replace(".", "").Replace(",", ""), 8)
                        sw.WriteLine(plu & departman & parametre1 & fiyat & malincinsi)
                        sayi += 1
                    End If
                End If
            Else
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sAciklama").ToString)
        Next
        sw.Close()
        Progress.HideProgress()
    End Sub
    Public Sub ciro_INTER(ByVal dosya As String, ByVal kasano As Integer, ByVal kasa As String)
        Dim z = (dosya)
        Dim sr As StreamReader = File.OpenText(z)
        Dim sk As StreamReader = File.OpenText(z)
        Dim s As String = ""
        Dim satir As String
        Dim satis
        Dim fis
        Dim iade As Integer = 0
        Dim iadetutar As Decimal = 0
        Dim fatura
        Dim iptal
        Dim aratoplam As Decimal = 0
        Dim faturakdv As Decimal = 0
        Dim indirim As Decimal = 0
        Dim nakit As Decimal = 0
        Dim kredi1 As Decimal = 0
        Dim kredi2 As Decimal = 0
        Dim kredi3 As Decimal = 0
        Dim kredi4 As Decimal = 0
        Dim kredi5 As Decimal = 0
        Dim kredi As Decimal = 0
        Dim belgeiptal As Integer = 0
        Dim belgeiptaltutar As Decimal = 0
        Dim ortalamaciro As Decimal = 0
        Dim sOdemeKodu
        Dim sayi As Integer
        sayi = 0
        fis = 0
        iade = 0
        fatura = 0
        iptal = 0
        faturakdv = 0
        belgeiptal = 0
        belgeiptaltutar = 0
        Do While sk.Peek() > -1
            satir = sk.ReadLine
            satis = Trim(satir.Substring(8, 2))
            If satis = 1 Then
                fis += 1
            ElseIf satis = 2 Then
                fatura += 1
            ElseIf satis = 5 Then
                iptal += CType(Trim(satir.Substring(30, 10)), Decimal)
            ElseIf satis = 6 Then
                indirim = indirim + CType(Trim(satir.Substring(30, 10)), Decimal)
            ElseIf satis = 7 Then
                faturakdv = faturakdv + CType(Trim(satir.Substring(30, 10)), Decimal)
            ElseIf satis = 8 Then
                aratoplam = aratoplam + CType(Trim(satir.Substring(30, 10)), Decimal)
            ElseIf satis = 9 Then
                nakit = nakit + CType(Trim(satir.Substring(30, 10)), Decimal)
            ElseIf satis = 10 Then
                kredi = kredi + CType(Trim(satir.Substring(30, 10)), Decimal)
                sOdemeKodu = Trim(satir.Substring(25, 2))
                If sOdemeKodu = 1 Then
                    kredi1 = kredi1 + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf sOdemeKodu = 2 Then
                    kredi2 = kredi2 + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf sOdemeKodu = 3 Then
                    kredi3 = kredi3 + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf sOdemeKodu = 4 Then
                    kredi4 = kredi4 + CType(Trim(satir.Substring(30, 10)), Decimal)
                Else
                    kredi5 = kredi5 + CType(Trim(satir.Substring(30, 10)), Decimal)
                End If
                'kredi = kredi + CType(Trim(satir.Substring(30, 10)), Decimal)
            ElseIf satis = 24 Then
                iade += 1
            ElseIf satis = 21 Then
                iade += 1
            ElseIf satis = 30 Then
                belgeiptal += 1
                belgeiptaltutar = belgeiptaltutar + CType(Trim(satir.Substring(30, 10)), Decimal)
            End If
        Loop
        sk.Close()
        If kasa = "inter" Then
            dosya = dosya.Replace("HR", "IP")
        ElseIf kasa = "escort" Then
            dosya = dosya.Replace("HR", "HI")
        End If
        dosya = dosya.Replace("YDK", "")
        z = dosya
        Dim dosya2 As New FileInfo(z)
        If dosya2.Exists Then
            dosya2.CopyTo("" & z & "YDK", True)
            z = z & "YDK"
            Dim ips As StreamReader = File.OpenText(z)
            Do While ips.Peek() > -1
                satir = ips.ReadLine
                satis = Trim(satir.Substring(8, 2))
                If satis = 1 Then
                    If kasa = "escort" Then
                        belgeiptal += 1
                        'belgeiptaltutar = belgeiptaltutar + CType(Trim(satir.Substring(30, 10)), Decimal)
                    End If
                    'fis += 1
                ElseIf satis = 2 Then
                    If kasa = "escort" Then
                        belgeiptal += 1
                        'belgeiptaltutar = belgeiptaltutar + CType(Trim(satir.Substring(30, 10)), Decimal)
                    End If
                ElseIf satis = 5 Then
                    'iptal += CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 6 Then
                    'indirim = indirim + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 7 Then
                    'faturakdv = faturakdv + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 8 Then
                    If kasa = "escort" Then
                        'belgeiptal += 1
                        belgeiptaltutar = belgeiptaltutar + CType(Trim(satir.Substring(30, 10)), Decimal)
                    End If
                    'aratoplam = aratoplam + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 9 Then
                    'nakit = nakit + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 10 Then
                    'kredi = kredi + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 30 Then
                    belgeiptal += 1
                    belgeiptaltutar = belgeiptaltutar + CType(Trim(satir.Substring(30, 10)), Decimal)
                End If
            Loop
            ips.Close()
        Else
        End If
        If kasa = "inter" Then
            dosya = dosya.Replace("HI", "HD")
        ElseIf kasa = "escort" Then
            dosya = dosya.Replace("HI", "HD")
        End If
        dosya = dosya.Replace("YDK", "")
        z = dosya
        Dim dosya3 As New FileInfo(z)
        If dosya3.Exists Then
            dosya3.CopyTo("" & z & "YDK", True)
            z = z & "YDK"
            Dim ipa As StreamReader = File.OpenText(z)
            Do While ipa.Peek() > -1
                satir = ipa.ReadLine
                satis = Trim(satir.Substring(8, 2))
                If satis = 1 Then
                    'fis += 1
                ElseIf satis = 2 Then
                    '
                ElseIf satis = 5 Then
                    'iptal += CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 6 Then
                    'indirim = indirim + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 7 Then
                    'faturakdv = faturakdv + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 8 Then
                    'MsgBox(satir)
                    'If kasa = "escort" Then
                    '    'MsgBox(CType(Trim(satir.Substring(30, 10)), Decimal))
                    iadetutar = iadetutar + CType(Trim(satir.Substring(30, 10)), Decimal)
                    'End If
                ElseIf satis = 9 Then
                    'nakit = nakit + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 21 Then
                    iade = iade + 1
                ElseIf satis = 30 Then
                    'belgeiptal += 1
                    'belgeiptaltutar = belgeiptaltutar + CType(Trim(satir.Substring(30, 10)), Decimal)
                End If
            Loop
            ipa.Close()
        Else
        End If
        Try
            ortalamaciro = aratoplam / ((CType(fis, Integer) + CType(fatura, Integer)) - CType(belgeiptal, Integer))
        Catch ex As Exception
            ortalamaciro = 0
        End Try
        If kasa = "inter" Then
            Dim dr As DataRow = dataset1.Tables(0).NewRow
            dr(0) = kasano
            dr(1) = fis
            dr(2) = fatura
            dr(3) = belgeiptal
            dr(4) = belgeiptaltutar
            dr(5) = aratoplam
            dr(6) = indirim
            dr(7) = ortalamaciro
            dr(8) = nakit
            dr(9) = kredi1
            dr(10) = kredi2
            dr(11) = iade
            dr(12) = kredi3
            dr(13) = kredi4
            dr(14) = kredi
            dr(15) = iadetutar
            dataset1.Tables(0).Rows.Add(dr)
        ElseIf kasa = "escort" Then
            Dim dr As DataRow = dataset1.Tables(0).NewRow
            dr(0) = kasano
            dr(1) = fis
            dr(2) = fatura
            dr(3) = belgeiptal
            dr(4) = belgeiptaltutar / 100
            dr(5) = aratoplam / 100
            dr(6) = indirim / 100
            dr(7) = ortalamaciro / 100
            dr(8) = nakit / 100
            dr(9) = kredi1 / 100
            dr(10) = kredi2 / 100
            dr(11) = iade
            dr(12) = kredi3 / 100
            dr(13) = kredi4 / 100
            dr(14) = kredi / 100
            dr(15) = iadetutar / 100
            dataset1.Tables(0).Rows.Add(dr)
        End If
        sk.Close()
        sr.Close()
    End Sub
    Private Sub ciro_ESCORT(ByVal dosya As String)
        Dim z = (dosya) 'OPEN.FileName.ToString
        Dim sr As StreamReader = File.OpenText(z)
        Dim sk As StreamReader = File.OpenText(z)
        Dim s As String = ""
        Dim satir As String
        Dim satis
        Dim fis
        Dim fatura
        Dim iptal
        Dim aratoplam As Decimal
        Dim faturakdv As Decimal
        Dim indirim As Decimal
        Dim nakit As Decimal
        Dim kredi As Decimal
        Dim belgeiptal
        Dim belgeiptaltutar
        Dim ortalamaciro
        's = sr.Read
        Dim sayi As Integer
        sayi = 0
        fis = 0
        fatura = 0
        iptal = 0
        faturakdv = 0
        belgeiptal = 0
        belgeiptaltutar = 0
        Do While sk.Peek() > -1
            satir = sk.ReadLine
            satis = Trim(satir.Substring(8, 2))
            If satis = 1 Then
                fis += 1
            ElseIf satis = 2 Then
                fatura += 1
            ElseIf satis = 5 Then
                iptal += CType(Trim(satir.Substring(30, 10)), Decimal)
            ElseIf satis = 6 Then
                indirim = indirim + CType(Trim(satir.Substring(30, 10)), Decimal)
            ElseIf satis = 7 Then
                faturakdv = faturakdv + (CType(Trim(satir.Substring(30, 10)), Decimal) / 100)
            ElseIf satis = 8 Then
                aratoplam = aratoplam + (CType(Trim(satir.Substring(30, 10)), Decimal) / 100)
            ElseIf satis = 9 Then
                nakit = nakit + (CType(Trim(satir.Substring(30, 10)), Decimal) / 100)
            ElseIf satis = 10 Then
                kredi = kredi + (CType(Trim(satir.Substring(30, 10)), Decimal) / 100)
            ElseIf satis = 30 Then
                belgeiptal += 1
                belgeiptaltutar = belgeiptaltutar + (CType(Trim(satir.Substring(30, 10)), Decimal) / 100)
            End If
        Loop
        dosya = dosya.Replace("HR", "IP")
        dosya = dosya.Replace("YDK", "")
        z = dosya
        Dim dosya2 As New FileInfo(z)
        If dosya2.Exists Then
            dosya2.CopyTo("" & z & "YDK", True)
            z = z & "YDK"
            Dim ips As StreamReader = File.OpenText(z)
            Do While ips.Peek() > -1
                satir = ips.ReadLine
                satis = Trim(satir.Substring(8, 2))
                If satis = 1 Then
                    'fis += 1
                ElseIf satis = 2 Then
                    'fatura += 1
                ElseIf satis = 5 Then
                    'iptal += CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 6 Then
                    'indirim = indirim + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 7 Then
                    'faturakdv = faturakdv + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 8 Then
                    'aratoplam = aratoplam + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 9 Then
                    'nakit = nakit + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 10 Then
                    'kredi = kredi + CType(Trim(satir.Substring(30, 10)), Decimal)
                ElseIf satis = 30 Then
                    belgeiptal += 1
                    belgeiptaltutar = belgeiptaltutar + (CType(Trim(satir.Substring(30, 10)), Decimal) / 100)
                End If
            Loop
        Else
        End If
        ortalamaciro = aratoplam / ((CType(fis, Integer) + CType(fatura, Integer)) - CType(belgeiptal, Integer))
        'MsgBox(Sorgu_sDil("Fiþ Sayýsý        " & vbTab & vbTab & fis & vbCrLf & "Fatura Sayýsý " & vbTab & vbTab & fatura & vbCrLf & "Ýptal Edilen Belge Sayýsý" & vbTab & belgeiptal & vbCrLf & "Ýptal Edilen Belge Tutarý " & vbTab & FormatCurrency(belgeiptaltutar, 2) & vbCrLf & "==============================" & vbCrLf & "Toplam Ciro " & vbTab & vbTab & FormatCurrency(aratoplam, 2) & vbCrLf & "Toplam Ýndirim  " & vbTab & vbTab & FormatCurrency(indirim, 2) & vbCrLf & "Ortalama Ciro " & vbTab & vbTab & FormatCurrency(ortalamaciro, 2) & vbCrLf & "==============================" & vbCrLf & "Nakit Satýþ" & vbTab & vbTab & FormatCurrency(nakit, 2) & vbCrLf & "Kredili Satýþ " & vbTab & vbTab & FormatCurrency(kredi, 2), MessageBoxIcon.Information, "ÝNTER POS CÝRO RAPORU")
        Dim dr As DataRow = dataset1.Tables(0).NewRow
        dr("FIS") = fis
        dr("FATURA") = fatura
        dr("IPTAL") = belgeiptal
        dr("IPTALTUTAR") = belgeiptaltutar
        dr("INDIRIM") = indirim
        dr("ARATOPLAM") = aratoplam
        dr("ORTALAMA") = ortalamaciro
        dr("NAKIT") = nakit
        dr("KREDI1") = kredi
        dataset1.Tables(0).Rows.Add(dr)
    End Sub
    Private Sub interurunsatisoku(ByVal dosya As String)
        status = False
        Dim z = (dosya) 'OPEN.FileName.ToString
        Dim sr As StreamReader = File.OpenText(z)
        Dim sk As StreamReader = File.OpenText(z)
        Dim s As String
        Dim satir As String
        Dim satis
        Dim kriter1 As String
        Dim plu
        Dim miktar
        Dim fiyat
        's = sr.Read
        Dim sayi As Integer
        sayi = 0
        Do While sk.Peek() > -1
            satir = sk.ReadLine
            satis = Trim(satir.Substring(8, 2))
            If satis = 4 Then
                sayi += 1
            ElseIf satis = 5 Then
                sayi += 1
            End If
        Loop
        Do While sr.Peek() > -1
            s = sr.ReadLine()
            satis = Trim(s.Substring(8, 2))
            If satis = 4 Then
                sayi += 1
                'MsgBox(s)
                plu = Trim(s.Substring(21, 6))
                If listbox1.Items.Contains(plu) = True Then
                    miktar = Trim(s.Substring(16, 5))
                    fiyat = Trim(s.Substring(30, 10))
                    'MsgBox(plu & vbCrLf & miktar & vbCrLf & fiyat)
                    kriter1 = " AND(STOK.IND =  " & plu & ")"
                    satisdataload(fiyat, miktar, kriter1, CType(plu, Integer))
                End If
                'bar.Position = sayi
                'bar.Refresh()
                'Me.Refresh()
            ElseIf satis = 5 Then
                plu = Trim(s.Substring(21, 6))
                If listbox1.Items.Contains(plu) = True Then
                    miktar = Trim(s.Substring(16, 5))
                    fiyat = Trim(s.Substring(30, 10))
                    kriter1 = " AND(STOK.IND =  " & plu & ")"
                    satisdataload(-(fiyat), -(miktar), kriter1, CType(plu, Integer))
                End If
                'bar.Position = sayi
                'bar.Refresh()
                'Me.Refresh()
            End If
        Loop
        'colFIYATI.Caption = "TUTAR"
        'fiyatgir.ReadOnly = True
        'miktargir.ReadOnly = True
        'panelstatus.Visible = False
        'bar.Visible = False
    End Sub
    Public Sub interurunkontrol(ByVal dosya As String, ByVal kasa As String)
        Dim dr As DataRow
        Dim kayitno
        Dim pluno As String = ""
        listbox1.Items.Clear()
        For Each dr In dataset1.Tables(0).Rows
            kayitno = Microsoft.VisualBasic.Right(("nStokID"), 6)
            pluno = sayiuzunlukkontrol(kayitno, 6)
            listbox1.Items.Add(pluno)
        Next
        interurunsatisoku(dosya)
    End Sub
    Private Sub satisdataload(ByVal fiyat As Decimal, ByVal miktar As String, ByVal kriter As String, ByVal plu As Integer)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        Dim kriter1
        kriter1 = kriter
        cmd.CommandText = "set dateformat dmy SELECT stok.IND, stok.STOKKODU, stok.MALINCINSI, stok.KOD1, stok.KOD2, stok.KOD3," & _
                " stok.KOD4, stok.KOD5, stok.KOD6, stok.KOD7, stok.KOD8, stok.KOD9, stok.KOD10, s" & _
                "tok.ALISFIYATI, stok.MALIYET, birim.BIRIMADI, birim.CARPAN, birim.BARCODE, birim" & _
                ".BARCODESTD, birim.ACIKLAMA, birim.KDV, birim.KDVDAHIL, birim.SATISFIYATI1, biri" & _
                "m.SATISFIYATI2, birim.SATISFIYATI3, birim.PB1, birim.PB2, birim.PB3, stok.KDVGRU" & _
                "BU, TBLKDVGRUPLARI.ACIKLAMA AS KDVACIKLA, depo.DEPOADI, birim.IND AS BIRIMNO, de" & _
                "po.IND AS DEPONO, '" & fiyat & "' AS FIYATI, TBLKDVGRUPLARI.IND AS KDVDEPNO, " & _
                "CAST('1' AS BIT) AS SEC, '" & miktar & "' AS MIKTAR FROM F0" & firmano & "TBLSTOKLAR stok INNER JOIN F0" & firmano & "" & _
                "TBLBIRIMLEREX birim ON stok.IND = birim.STOKNO AND stok.ANABIRIM = birim.IND IN" & _
                "NER JOIN F0" & firmano & "TBLDEPOLAR depo ON stok.DEPO = depo.IND INNER JOIN TBLKDVGRUPLARI " & _
                "ON stok.KDVGRUBU = TBLKDVGRUPLARI.IND WHERE (stok.IND > 100)" & kriter1 & ""
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(dataset1, "TOPLUSTOK")
        conn.Close()
    End Sub
    Public Sub satis_INTER(ByVal dosya As String, ByVal kasa As String)
        Dim z = (dosya) 'OPEN.FileName.ToString
        Dim sr As StreamReader = File.OpenText(z)
        Dim sk As StreamReader = File.OpenText(z)
        Dim satir As String
        Dim satis
        'Dim kriter1 As String
        Dim fis
        Dim kasiyer As String = ""
        Dim kasano As String = ""
        Dim saat As String = ""
        Dim fatura
        Dim iptal
        Dim aratoplam As Decimal
        Dim faturakdv As Decimal
        Dim indirim As Decimal
        Dim nakit As Decimal
        Dim kredi As Decimal
        Dim belgeiptal As Integer = 0
        Dim belgeiptaltutar As Decimal = 0
        Dim ortalamaciro As Decimal = 0
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        's = sr.Read
        Dim sayi As Integer
        sayi = 0
        fis = 0
        fatura = 0
        iptal = 0
        faturakdv = 0
        Do While sk.Peek() > -1
            satir = sk.ReadLine
            satis = Trim(satir.Substring(8, 2))
            fis = 0
            iptal = 0
            If satis = 1 Then
                'fis += 1
                fis = 0
                kasiyer = CType(Trim(satir.Substring(23, 4)), Integer)
                kasano = CType(Trim(satir.Substring(15, 3)), Integer)
            ElseIf satis = 2 Then
                'fatura += 1
                fis = 1
            ElseIf satis = 3 Then
                saat = Trim(satir.Substring(28, 5))
            ElseIf satis = 5 Then
                'iptal += CType(Trim(satir.Substring(30, 10)), Decimal)
                iptal = 1
            ElseIf satis = 6 Then
                'indirim = indirim + CType(Trim(satir.Substring(30, 10)), Decimal)
                indirim = CType(Trim(satir.Substring(30, 10)), Decimal)
            ElseIf satis = 7 Then
                'faturakdv = faturakdv + CType(Trim(satir.Substring(30, 10)), Decimal)
            ElseIf satis = 8 Then
                'aratoplam = aratoplam + CType(Trim(satir.Substring(30, 10)), Decimal)
                aratoplam = CType(Trim(satir.Substring(30, 10)), Decimal)
            ElseIf satis = 9 Then
                'nakit = nakit + CType(Trim(satir.Substring(30, 10)), Decimal)
                nakit = CType(Trim(satir.Substring(30, 10)), Decimal)
            ElseIf satis = 10 Then
                'kredi = kredi + CType(Trim(satir.Substring(30, 10)), Decimal)
                kredi = CType(Trim(satir.Substring(30, 10)), Decimal)
            ElseIf satis = 11 Then
                con.Open()
                If kasa = "escort" Then
                    cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO  BTBLINTERCIRO (KASA, KASIYER, SAAT, FIS, IPTAL, ARATOPLAM, INDIRIM, NAKIT, KREDI)  VALUES     (" & kasano & "," & kasiyer & ",'" & saat & "'," & fis & "," & iptal & "," & aratoplam / 100 & "," & indirim / 100 & "," & nakit / 100 & "," & kredi / 100 & ")"
                ElseIf kasa = "inter" Then
                    cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO  BTBLINTERCIRO (KASA, KASIYER, SAAT, FIS, IPTAL, ARATOPLAM, INDIRIM, NAKIT, KREDI)  VALUES     (" & kasano & "," & kasiyer & ",'" & saat & "'," & fis & "," & iptal & "," & aratoplam & "," & indirim & "," & nakit & "," & kredi & ")"
                End If
                cmd.ExecuteNonQuery()
                con.Close()
                indirim = 0
                aratoplam = 0
                nakit = 0
                kredi = 0
            ElseIf satis = 30 Then
                belgeiptal += 1
                If kasa = "escort" Then
                    belgeiptaltutar = belgeiptaltutar + (CType(Trim(satir.Substring(30, 10)), Decimal) / 100)
                ElseIf kasa = "inter" Then
                    belgeiptaltutar = belgeiptaltutar + CType(Trim(satir.Substring(30, 10)), Decimal)
                End If
            End If
        Loop
    End Sub
    Private Sub satis_ESCORT(ByVal dosya As String)
        Dim z = (dosya) 'OPEN.FileName.ToString
        Dim sr As StreamReader = File.OpenText(z)
        Dim sk As StreamReader = File.OpenText(z)
        Dim s As String = ""
        Dim satir As String
        Dim satis
        Dim fis
        Dim kasiyer As String = ""
        Dim kasano As String = ""
        Dim saat As String = ""
        Dim fatura
        Dim iptal
        Dim aratoplam As Decimal
        Dim faturakdv As Decimal
        Dim indirim As Decimal
        Dim nakit As Decimal
        Dim kredi As Decimal
        Dim belgeiptal As Integer = 0
        Dim belgeiptaltutar As Decimal = 0
        Dim ortalamaciro As Decimal = 0
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        's = sr.Read
        Dim sayi As Integer
        sayi = 0
        fis = 0
        fatura = 0
        iptal = 0
        faturakdv = 0
        Do While sk.Peek() > -1
            satir = sk.ReadLine
            satis = Trim(satir.Substring(8, 2))
            fis = 0
            iptal = 0
            If satis = 1 Then
                'fis += 1
                fis = 0
                kasiyer = CType(Trim(satir.Substring(23, 4)), Integer)
                kasano = CType(Trim(satir.Substring(15, 3)), Integer)
            ElseIf satis = 2 Then
                'fatura += 1
                fis = 1
            ElseIf satis = 3 Then
                saat = Trim(satir.Substring(28, 5))
            ElseIf satis = 5 Then
                'iptal += CType(Trim(satir.Substring(30, 10)), Decimal)
                iptal = 1
            ElseIf satis = 6 Then
                'indirim = indirim + CType(Trim(satir.Substring(30, 10)), Decimal)
                indirim = CType(Trim(satir.Substring(30, 10)), Decimal)
            ElseIf satis = 7 Then
                'faturakdv = faturakdv + CType(Trim(satir.Substring(30, 10)), Decimal)
            ElseIf satis = 8 Then
                'aratoplam = aratoplam + CType(Trim(satir.Substring(30, 10)), Decimal)
                aratoplam = CType(Trim(satir.Substring(30, 10)), Decimal) / 100
            ElseIf satis = 9 Then
                'nakit = nakit + CType(Trim(satir.Substring(30, 10)), Decimal)
                nakit = CType(Trim(satir.Substring(30, 10)), Decimal) / 100
            ElseIf satis = 10 Then
                'kredi = kredi + CType(Trim(satir.Substring(30, 10)), Decimal)
                kredi = CType(Trim(satir.Substring(30, 10)), Decimal) / 100
            ElseIf satis = 11 Then
                con.Open()
                cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO  BTBLINTERCIRO (KASA, KASIYER, SAAT, FIS, IPTAL, ARATOPLAM, INDIRIM, NAKIT, KREDI)  VALUES     (" & kasano & "," & kasiyer & ",'" & saat & "'," & fis & "," & iptal & "," & aratoplam & "," & indirim & "," & nakit & "," & kredi & ")"
                cmd.ExecuteNonQuery()
                con.Close()
                indirim = 0
                aratoplam = 0
                nakit = 0
                kredi = 0
            ElseIf satis = 30 Then
                belgeiptal += 1
                belgeiptaltutar = belgeiptaltutar + (CType(Trim(satir.Substring(30, 10)), Decimal) / 100)
            End If
        Loop
    End Sub
    Private Function interbarkodidx() As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT BARKOD,SATIR FROM BTBLINTERPOSIDX ORDER BY BARKOD"
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "POS")
        conn.Close()
        Return DS
    End Function
    Public Function intercirosaatlik() As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     SUBSTRING(SAAT, 1, 2) AS NO,COUNT(FIS) AS FISSAYISI, SUM(ARATOPLAM) AS CIRO, SUM(NAKIT) AS NAKIT, SUM(KREDI) AS KREDI FROM         BTBLINTERCIRO GROUP BY SUBSTRING(SAAT, 1, 2) ORDER BY NO"
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "POS")
        conn.Close()
        Return DS
    End Function
    Public Sub satis_INTER_sql()
        dataset1.Clear()
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = " set dateformat dmy SELECT     SUM(satis.FIYAT) AS FIYATI, SUM(satis.MIKTAR) AS MIKTAR, stok.STOKKODU, stok.MALINCINSI, stok.KOD1, stok.KOD2, stok.KOD3, stok.KOD4, " & _
                                 " stok.KOD5, stok.KOD6, stok.KOD7, stok.KOD8, stok.KOD9, stok.KOD10, stok.ALISFIYATI, stok.MALIYET, birim.BIRIMADI, birim.CARPAN, " & _
                                 " birim.BARCODE, birim.BARCODESTD, birim.ACIKLAMA, birim.KDV, birim.KDVDAHIL, birim.SATISFIYATI1, birim.SATISFIYATI2, birim.SATISFIYATI3, " & _
                                 " birim.PB1, birim.PB2, birim.PB3, DEPO.DEPOADI, KDVGRUP.ACIKLAMA AS KDVACIKLA, birim.IND AS BIRIMNO, stok.IND, " & _
                                 " CAST('1' AS BIT) AS SEC" & _
           " FROM         BTBLINTERSATIS satis INNER JOIN" & _
                                 " F0" & firmano & "TBLSTOKLAR stok ON satis.PLU = stok.IND INNER JOIN" & _
                                 " F0" & firmano & "TBLBIRIMLEREX birim ON stok.IND = birim.STOKNO INNER JOIN" & _
                                 " F0" & firmano & "TBLDEPOLAR DEPO ON stok.DEPO = DEPO.IND INNER JOIN" & _
                                 " F0" & firmano & "TBLKDVGRUPLARI KDVGRUP ON stok.KDVGRUBU = KDVGRUP.IND" & _
           " GROUP BY satis.PLU, stok.STOKKODU, stok.MALINCINSI, stok.KOD1, stok.KOD2, stok.KOD3, stok.KOD4, stok.KOD5, stok.KOD6, stok.KOD7, stok.KOD8, " & _
                                 " stok.KOD9, stok.KOD10, stok.ALISFIYATI, stok.MALIYET, birim.BIRIMADI, birim.CARPAN, birim.BARCODE, birim.BARCODESTD, birim.ACIKLAMA, " & _
                                 " birim.KDV, birim.KDVDAHIL, birim.SATISFIYATI1, birim.SATISFIYATI2, birim.SATISFIYATI3, birim.PB1, birim.PB2, birim.PB3, DEPO.DEPOADI, " & _
                   " KDVGRUP.ACIKLAMA, birim.IND, stok.IND  HAVING SUM(satis.MIKTAR) > 0"
        cmd.Connection = conn
        conn.Open()
        adapter.Fill(dataset1, "TOPLUSTOK")
        conn.Close()
    End Sub
    Public Sub intersatisoku(ByVal dosya As String, ByVal kasa As String, ByVal sMagaza As String, ByVal nStatus As Integer, ByVal sKullanici As String, ByVal nIslem As Integer)
        status = False
        Dim z = (dosya)
        Dim sr As StreamReader = File.OpenText(z)
        Dim sk As StreamReader = File.OpenText(z)
        Dim s As String
        Dim satir As String
        Dim satis
        Dim nAlisVerisID As String = ""
        Dim sSatir As String = ""
        Dim sSatisSatir As String = ""
        Dim nMusteriID As String = 0
        Dim sKasaNo As String = ""
        Dim lFisNo As Integer = 0
        Dim sFisTipi As String = "P"
        Dim nFisGC As Integer = 0
        Dim dteFisTarihi As String = "01/01/1900"
        Dim dteKayitTarihi As String = "01/01/1900"
        Dim sKasiyerRumuzu As String = ""
        Dim sSaticiRumuzu As String = ""
        Dim nGirisCikis As Integer = 3
        Dim nStokID As Integer = 0
        Dim sKodu As String = ""
        Dim lMiktar As Decimal = 0
        Dim lFiyat As Decimal = 0
        Dim lTutar As Decimal = 0
        Dim lToplamTutar As Decimal = 0
        Dim lBrutFiyat As Decimal = 0
        Dim lBrutTutar As Decimal = 0
        Dim sIskontoTipi As String = "TOP"
        Dim nIskontoYuzdesi As Decimal = 0
        Dim lIskontoTutari As Decimal = 0
        Dim lNetTutar As Decimal = 0
        Dim sKdvTipi As String = "01"
        Dim sOdemeKodu As String = "NAK"
        Dim lOdemeTutar As Decimal = 0
        Dim bKapali As Boolean = True
        Dim bBarkod As Boolean = False
        Dim bToplam As Boolean = False
        's = sr.Read
        Dim sayi As Integer
        Dim nSatirSayi As Integer = 0
        sayi = 0
        Do While sk.Peek() > -1
            satir = sk.ReadLine
            satis = Trim(satir.Substring(8, 2))
            nSatirSayi += 1
            Try
                If satis = 4 Then
                    sayi += 1
                ElseIf satis = 5 Then
                    sayi += 1
                ElseIf satis = 38 Then
                    bBarkod = True
                End If
            Catch ex As Exception
                XtraMessageBox.Show(dosya.ToString & Sorgu_sDil("Ýsimli Dosyada ", sDil) & nSatirSayi & Sorgu_sDil(" Kayýtlý Satýr Hatalý,Lütfen Kontrol Ediniz", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Question)
            End Try
        Loop
        sk.Close()
        Dim dlg As New WaitDlgFrm("Toplam Satýr :" & sayi)
        sayi = 0
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        Do While sr.Peek() > -1
            sayi += 1
            s = sr.ReadLine()
            satis = Trim(s.Substring(8, 2))
            If s.Length = 40 Then
                If satis = 1 Then
                    lToplamTutar = 0
                    bToplam = False
                    nAlisVerisID = sMagaza + Trim(s.Substring(28, 4))
                    sKasaNo = Trim(s.Substring(15, 3))
                    lFisNo = CType(Trim(s.Substring(28, 6)), Integer)
                    sFisTipi = "P"
                    nFisGC = 0
                    sKasiyerRumuzu = Trim(s.Substring(23, 4))
                    sSaticiRumuzu = ""
                ElseIf satis = 2 Then
                    lToplamTutar = 0
                    bToplam = False
                    nAlisVerisID = sMagaza + Trim(s.Substring(28, 4))
                    sKasaNo = Trim(s.Substring(15, 3))
                    lFisNo = CType(Trim(s.Substring(28, 6)), Integer)
                    sFisTipi = "K"
                    nFisGC = 0
                    sKasiyerRumuzu = Trim(s.Substring(23, 4))
                    sSaticiRumuzu = ""
                ElseIf satis = 24 Then
                    lToplamTutar = 0
                    bToplam = False
                    nFisGC = 1
                    nAlisVerisID = sMagaza + Trim(s.Substring(28, 4))
                    sKasaNo = Trim(s.Substring(15, 3))
                    lFisNo = CType(Trim(s.Substring(28, 6)), Integer)
                    sFisTipi = "P"
                    nFisGC = 1
                    sKasiyerRumuzu = Trim(s.Substring(23, 4))
                    sSaticiRumuzu = ""
                ElseIf satis = 21 Then
                    lToplamTutar = 0
                    bToplam = False
                    nFisGC = 1
                    nAlisVerisID = sMagaza + Trim(s.Substring(28, 4))
                    sKasaNo = Trim(s.Substring(15, 3))
                    lFisNo = CType(Trim(s.Substring(28, 6)), Integer)
                    sFisTipi = "K"
                    nFisGC = 1
                    sKasiyerRumuzu = Trim(s.Substring(23, 4))
                    sSaticiRumuzu = ""
                ElseIf satis = 22 Then
                    sSaticiRumuzu = Trim(s.Substring(15, 4))
                ElseIf satis = 3 Then
                    dteFisTarihi = Trim(s.Substring(15, 10))
                    dteKayitTarihi = dteFisTarihi + " " + Trim(s.Substring(28, 8))
                ElseIf satis = 4 Then
                    nStokID = CType(Trim(s.Substring(21, 6)), Integer)
                    lMiktar = CType(Trim(s.Substring(15, 6)), Decimal)
                    If lMiktar = 0 Then
                        lMiktar = 0.01
                    End If
                    lTutar = CType(Trim(s.Substring(30, 10)), Decimal)
                    lFiyat = lTutar / lMiktar
                    If kasa = "escort" Then
                        lTutar = lTutar / 100
                        lFiyat = lFiyat / 100
                    End If
                    'sKdvTipi = CType(Trim(s.Substring(28, 2)), Integer)
                    sKdvTipi = Trim(s.Substring(28, 2))
                    nGirisCikis = 3
                    If bBarkod = False Then
                        sayi += 1
                        sSatir = sayi
                        sSatisSatir = sSatir
                        sKodu = ""
                        lBrutFiyat = lFiyat
                        lBrutTutar = lTutar
                        intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, nStokID, sKodu, sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, "", 0, lMiktar, lBrutFiyat, lBrutTutar, "", 0, 0, lFiyat, lTutar, sKdvTipi, 0, 0, dteKayitTarihi, nStatus, sKullanici, bToplam)
                    End If
                    lToplamTutar += lTutar
                ElseIf satis = 5 Then
                    nStokID = CType(Trim(s.Substring(21, 6)), Integer)
                    lMiktar = CType(Trim(s.Substring(15, 6)), Decimal)
                    If lMiktar = 0 Then
                        lMiktar = 0.01
                    End If
                    lTutar = Trim(s.Substring(30, 10))
                    lFiyat = lTutar / lMiktar
                    If kasa = "escort" Then
                        lTutar = lTutar / 100
                        lFiyat = lFiyat / 100
                    End If
                    lMiktar = -lMiktar
                    lFiyat = -lFiyat
                    lTutar = -lTutar
                    'sKdvTipi = CType(Trim(s.Substring(28, 2)), Integer)
                    sKdvTipi = Trim(s.Substring(28, 2))
                    nGirisCikis = 4
                    If bBarkod = False Then
                        sayi += 1
                        sSatir = sayi
                        sSatisSatir = sSatir
                        sKodu = ""
                        lBrutFiyat = lFiyat
                        lBrutTutar = lTutar
                        intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, nStokID, sKodu, sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, "", 0, lMiktar, lBrutFiyat, lBrutTutar, "", 0, 0, lFiyat, lTutar, sKdvTipi, 0, 0, dteKayitTarihi, nStatus, sKullanici, bToplam)
                    End If
                    lToplamTutar += lTutar
                ElseIf satis = 25 Then
                    nStokID = CType(Trim(s.Substring(21, 6)), Integer)
                    lMiktar = CType(Trim(s.Substring(15, 6)), Decimal)
                    If lMiktar = 0 Then
                        lMiktar = 0.01
                    End If
                    lTutar = Trim(s.Substring(30, 10))
                    lFiyat = lTutar / lMiktar
                    If kasa = "escort" Then
                        lTutar = lTutar / 100
                        lFiyat = lFiyat / 100
                    End If
                    lMiktar = -lMiktar
                    lFiyat = -lFiyat
                    lTutar = -lTutar
                    'sKdvTipi = CType(Trim(s.Substring(28, 2)), Integer)
                    sKdvTipi = Trim(s.Substring(28, 2))
                    nGirisCikis = 4
                    If bBarkod = False Then
                        sayi += 1
                        sSatir = sayi
                        sSatisSatir = sSatir
                        sKodu = ""
                        lBrutFiyat = lFiyat
                        lBrutTutar = lTutar
                        intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, nStokID, sKodu, sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, "", 0, lMiktar, lBrutFiyat, lBrutTutar, "", 0, 0, lFiyat, lTutar, sKdvTipi, 0, 0, dteKayitTarihi, nStatus, sKullanici, bToplam)
                    End If
                    lToplamTutar += lTutar
                ElseIf satis = 38 Then
                    sKodu = Trim(s.Substring(15, 12))
                    sKodu += Trim(s.Substring(28, 12))
                    sayi += 1
                    sSatir = sayi
                    sSatisSatir = sSatir
                    lBrutFiyat = lFiyat
                    lBrutTutar = lTutar
                    If bBarkod = True Then
                        intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, nStokID, sKodu, sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, "", 0, lMiktar, lBrutFiyat, lBrutTutar, "", 0, 0, lFiyat, lTutar, sKdvTipi, 0, 0, dteKayitTarihi, nStatus, sKullanici, bToplam)
                    End If
                ElseIf satis = 6 Then
                    sIskontoTipi = Trim(s.Substring(15, 3))
                    If Trim(s.Substring(25, 2)) = "--" Then
                        nIskontoYuzdesi = 0
                    Else
                        nIskontoYuzdesi = CType(Trim(s.Substring(25, 2)), Decimal)
                    End If
                    sayi += 1
                    sSatir = sayi
                    lIskontoTutari = CType(Trim(s.Substring(30, 10)), Decimal)
                    If kasa = "escort" Then
                        lIskontoTutari = lIskontoTutari / 100
                    End If
                    nGirisCikis = 6
                    'MsgBox(Sorgu_sDil("Satir: " & sSatir & lIskontoTutari & vbTab & lToplamTutar)
                    If lIskontoTutari = lToplamTutar And nIslem = 2 Then
                        bToplam = True
                        lNetTutar = lToplamTutar
                        If kasa = "escort" Then
                            lNetTutar = lToplamTutar / 100
                        End If
                        sayi += 1
                        sSatir = sayi
                        sOdemeKodu = "TOP"
                        lOdemeTutar = 0
                        nGirisCikis = 8
                        If nFisGC = 1 Then
                            lNetTutar = -lNetTutar
                        End If
                        intersatiskayit_toplam_degistir(sFisTipi, nFisGC, dteFisTarihi, lFisNo, sKasiyerRumuzu, sKasaNo, lNetTutar, sKullanici, bToplam)
                    Else
                        bToplam = False
                        If sIskontoTipi = "SNS" Then
                            Dim elFiyat = lFiyat
                            Dim elTutar = lTutar
                            lTutar = lTutar - lIskontoTutari
                            lFiyat = lTutar / lMiktar
                            nIskontoYuzdesi = (lIskontoTutari / lBrutTutar) * 100
                            intersatiskayit_degistir(nAlisVerisID, sSatisSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sKasaNo, "", 0, 0, 0, 0, sIskontoTipi, nIskontoYuzdesi, lIskontoTutari, lFiyat, lTutar, "", 0, 0, dteKayitTarihi, nStatus, sKullanici, bToplam)
                            lFiyat = elFiyat
                            lTutar = elTutar
                            nIskontoYuzdesi = 0
                            lIskontoTutari = 0
                            sIskontoTipi = ""
                        Else
                            intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, "", 0, 0, 0, 0, sIskontoTipi, nIskontoYuzdesi, lIskontoTutari, 0, 0, "", 0, 0, dteKayitTarihi, nStatus, sKullanici, bToplam)
                        End If
                    End If
                ElseIf satis = 8 Then
                    If bToplam = True Then
                        lNetTutar = lToplamTutar
                        If kasa = "escort" Then
                            lNetTutar = lToplamTutar / 100
                        End If
                    Else
                        lNetTutar = CType(Trim(s.Substring(30, 10)), Decimal)
                        If kasa = "escort" Then
                            lNetTutar = lNetTutar / 100
                        End If
                        sayi += 1
                        sSatir = sayi
                        sOdemeKodu = "TOP"
                        lOdemeTutar = 0
                        nGirisCikis = 8
                        intersatiskayit_toplam_degistir(sFisTipi, nFisGC, dteFisTarihi, lFisNo, sKasiyerRumuzu, sKasaNo, lNetTutar, sKullanici, bToplam)
                        'intersatiskayit(nAlisVerisID, sSatir, sFisTipi, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sKasaNo, "", 0, 0, 0, 0, "", 0, 0, 0, 0, "", 0, lNetTutar, dteKayitTarihi, nStatus, sKullanici)
                    End If
                ElseIf satis = 9 Then
                    sOdemeKodu = Trim(s.Substring(11, 1))
                    lOdemeTutar = CType(Trim(s.Substring(30, 10)), Decimal)
                    If nFisGC = 1 Then
                        lOdemeTutar = -lOdemeTutar
                        lNetTutar = -lNetTutar
                    End If
                    If kasa = "escort" Then
                        lOdemeTutar = lOdemeTutar / 100
                    End If
                    sayi += 1
                    sSatir = sayi
                    nGirisCikis = 9
                    intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, sOdemeKodu, lOdemeTutar, 0, 0, 0, "", 0, 0, 0, 0, "", 0, lNetTutar, dteKayitTarihi, nStatus, sKullanici, bToplam)
                    lToplamTutar = 0
                    'bToplam = False
                ElseIf satis = 10 Then
                    sOdemeKodu = Trim(s.Substring(25, 2))
                    If bToplam = True Then
                        lOdemeTutar = lToplamTutar
                    Else
                        lOdemeTutar = CType(Trim(s.Substring(30, 10)), Decimal)
                    End If
                    If kasa = "escort" Then
                        lOdemeTutar = lOdemeTutar / 100
                    End If
                    If nFisGC = 1 Then
                        lOdemeTutar = -lOdemeTutar
                        lNetTutar = -lNetTutar
                    End If
                    sayi += 1
                    sSatir = sayi
                    nGirisCikis = 10
                    intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, sOdemeKodu, lOdemeTutar, 0, 0, 0, "", 0, 0, 0, 0, "", 0, lNetTutar, dteKayitTarihi, nStatus, sKullanici, bToplam)
                    lToplamTutar = 0
                    'bToplam = False
                ElseIf satis = 30 Then
                    If Trim(s.Substring(26, 1)) = "" Then
                        nStatus = 1
                    ElseIf Trim(s.Substring(26, 1)) = "0" Then
                        nStatus = 2
                    ElseIf Trim(s.Substring(26, 1)) = "1" Then
                        nStatus = 2
                    ElseIf Trim(s.Substring(26, 1)) = "2" Then
                        nStatus = 3
                    End If
                    lNetTutar = CType(Trim(s.Substring(30, 10)), Decimal)
                    If kasa = "escort" Then
                        lNetTutar = lNetTutar / 100
                    End If
                    sayi += 1
                    sSatir = sayi
                    nGirisCikis = 30
                    intersatiskayit_baslik_degistir(sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sKasiyerRumuzu, sKasaNo, nStatus, sKullanici, bToplam, bKapali)
                    intersatiskayit_toplam_degistir(sFisTipi, nFisGC, dteFisTarihi, lFisNo, sKasiyerRumuzu, sKasaNo, lNetTutar, sKullanici, bToplam)
                    intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, "", 0, 0, 0, 0, "", 0, 0, 0, 0, "", 0, lNetTutar, dteKayitTarihi, nStatus, sKullanici, bToplam)
                    nMusteriID = ""
                    bKapali = True
                    nStatus = 1
                ElseIf satis = 11 Then
                    nMusteriID = Trim(s.Substring(15, 12))
                    nMusteriID += Trim(s.Substring(28, 8))
                    If Trim(s.Substring(39, 1)) = "" Then
                        bKapali = True
                    ElseIf Trim(s.Substring(39, 1)) = "A" Then
                        bKapali = False
                    ElseIf Trim(s.Substring(39, 1)) = "K" Then
                        bKapali = True
                    End If
                    If kasa = "escort" Then
                        bKapali = False
                    End If
                    If nMusteriID = "" Or nMusteriID = "0" Then
                        bKapali = True
                    Else
                        bKapali = False
                    End If
                    sayi += 1
                    sSatir = sayi
                    nGirisCikis = 11
                    intersatiskayit_baslik_degistir(sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sKasiyerRumuzu, sKasaNo, nStatus, sKullanici, bToplam, bKapali)
                    intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, "", 0, 0, 0, 0, "", 0, 0, 0, 0, "", 0, lNetTutar, dteKayitTarihi, nStatus, sKullanici, bToplam, bKapali)
                    'intersatiskayit_baslik_degistir(sFisTipi, dteFisTarihi, lFisNo, nMusteriID, sKasiyerRumuzu, sKasaNo, nStatus, sKullanici, bToplam, bKapali)
                    nMusteriID = ""
                    bKapali = True
                    bToplam = False
                End If
            Else
                XtraMessageBox.Show(Sorgu_sDil("Hatalý Ýndex Satýrý: ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Loop
        sr.Close()
        dlg.Close()
    End Sub
    Public Sub Simenes_satisoku(ByVal dosya As String, ByVal kasa As String, ByVal sMagaza As String, ByVal nStatus As Integer, ByVal sKullanici As String, ByVal nIslem As Integer)
        status = False
        Dim z = (dosya)
        Dim sr As StreamReader = File.OpenText(z)
        Dim sk As StreamReader = File.OpenText(z)
        Dim s As String
        Dim satir As String
        Dim nAlisVerisID As String = ""
        Dim sSatir As String = ""
        Dim sSatisSatir As String = ""
        Dim nMusteriID As String = 0
        Dim sKasaNo As String = ""
        Dim lFisNo As Integer = 0
        Dim sFisTipi As String = "P"
        Dim nFisGC As Integer = 0
        Dim dteFisTarihi As String = "01/01/1900"
        Dim dteKayitTarihi As String = "01/01/1900"
        Dim sKasiyerRumuzu As String = ""
        Dim nGirisCikis As Integer = 3
        Dim nStokID As Integer = 0
        Dim sKodu As String = ""
        Dim lMiktar As Decimal = 0
        Dim lFiyat As Decimal = 0
        Dim lTutar As Decimal = 0
        Dim lToplamTutar As Decimal = 0
        Dim lBrutFiyat As Decimal = 0
        Dim lBrutTutar As Decimal = 0
        Dim sIskontoTipi As String = "TOP"
        Dim nIskontoYuzdesi As Decimal = 0
        Dim lIskontoTutari As Decimal = 0
        Dim lNetTutar As Decimal = 0
        Dim sKdvTipi As String = "01"
        Dim sOdemeKodu As String = "NAK"
        Dim lOdemeTutar As Decimal = 0
        Dim bKapali As Boolean = True
        Dim bBarkod As Boolean = False
        Dim bToplam As Boolean = False
        Dim nKdvOrani As Decimal = 0
        's = sr.Read
        Dim sayi As Integer
        Dim nSatirSayi As Integer = 0
        sayi = 0
        Do While sk.Peek() > -1
            satir = sk.ReadLine
            Try
                If Len(satir) = 140 Then
                    sayi += 1
                    nSatirSayi += 1
                End If
            Catch ex As Exception
                XtraMessageBox.Show(dosya.ToString & Sorgu_sDil("Ýsimli Dosyada ", sDil) & nSatirSayi & Sorgu_sDil(" Kayýtlý Satýr Hatalý,Lütfen Kontrol Ediniz", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Question)
            End Try
        Loop
        sk.Close()
        Dim dlg As New WaitDlgFrm("Toplam Satýr :" & sayi)
        sayi = 0
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        Do While sr.Peek() > -1
            sayi += 1
            s = sr.ReadLine()
            If lFisNo <> Trim(s.Substring(17, 6)) And sayi > 1 Then
                sOdemeKodu = "N"
                lOdemeTutar = lNetTutar
                nGirisCikis = 9
                intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, sOdemeKodu, lOdemeTutar, 0, 0, 0, "", 0, 0, 0, 0, "", 0, lNetTutar, dteKayitTarihi, nStatus, sKullanici, bToplam)
                nGirisCikis = 11
                bKapali = True
                intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, "", 0, 0, 0, 0, "", 0, 0, 0, 0, "", 0, lNetTutar, dteKayitTarihi, nStatus, sKullanici, bToplam, bKapali)
                nGirisCikis = 3
                lNetTutar = 0
            End If
            lFisNo = Trim(s.Substring(17, 6))
            nAlisVerisID = "D" & Trim(s.Substring(135, 3)) & Trim(s.Substring(17, 6))
            sKasaNo = Trim(s.Substring(0, 5))
            Dim sYil As String = ""
            Dim sAy As String = ""
            Dim sGun As String = ""
            Dim sSaat As String = ""
            Dim sDakika As String = ""
            sYil = Trim(s.Substring(5, 4))
            sAy = Trim(s.Substring(9, 2))
            sGun = Trim(s.Substring(11, 2))
            sSaat = Trim(s.Substring(13, 2))
            sDakika = Trim(s.Substring(15, 2))
            dteFisTarihi = sGun + "/" + sAy + "/" + sYil
            dteKayitTarihi = dteFisTarihi + " " + sSaat + ":" + sDakika
            sSatisSatir = Trim(s.Substring(23, 4))
            'nStokID = Trim(s.Substring(30, 20))
            nStokID = Trim(s.Substring(35, 6))
            lMiktar = Trim(s.Substring(51, 9))
            lTutar = Trim(s.Substring(60, 12))
            lTutar = lTutar / 100
            lFiyat = lTutar / lMiktar
            lBrutFiyat = lFiyat
            lBrutTutar = lTutar
            If Trim(s.Substring(139, 1)) = 4 Then
                lMiktar = -lMiktar
                lTutar = -lTutar
                lBrutTutar = -lBrutTutar
                nGirisCikis = 4
            ElseIf Trim(s.Substring(139, 1)) = 1 Then
                nGirisCikis = 3
            End If
            lNetTutar += lBrutTutar
            nKdvOrani = Trim(s.Substring(72, 5))
            sMagaza = "D" & Trim(s.Substring(135, 3))
            sSatir = sayi
            If Trim(s.Substring(139, 1)) = 1 Then
                sFisTipi = "P"
            ElseIf Trim(s.Substring(139, 1)) = 2 Then
                sFisTipi = "K"
            ElseIf Trim(s.Substring(139, 1)) = 3 Then
                sFisTipi = "K"
            ElseIf Trim(s.Substring(139, 1)) = 4 Then
                sFisTipi = "P"
            ElseIf Trim(s.Substring(139, 1)) = 5 Then
                sFisTipi = "P"
            ElseIf Trim(s.Substring(139, 1)) = 6 Then
                sFisTipi = "P"
            ElseIf Trim(s.Substring(139, 1)) = 7 Then
                sFisTipi = "P"
            ElseIf Trim(s.Substring(139, 1)) = 8 Then
                sFisTipi = "P"
            ElseIf Trim(s.Substring(139, 1)) = 9 Then
                sFisTipi = "P"
            End If
            'intersatiskayit_baslik_degistir(sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sKasiyerRumuzu, sKasaNo, nStatus, sKullanici, bToplam, bKapali)
            intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, nStokID, sKodu, sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, "", 0, lMiktar, lBrutFiyat, lBrutTutar, "", 0, 0, lFiyat, lTutar, sKdvTipi, nKdvOrani, 0, dteKayitTarihi, nStatus, sKullanici, bToplam)
        Loop
        sr.Close()
        dlg.Close()
        sOdemeKodu = "N"
        lOdemeTutar = lNetTutar
        nGirisCikis = 9
        intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, sOdemeKodu, lOdemeTutar, 0, 0, 0, "", 0, 0, 0, 0, "", 0, lNetTutar, dteKayitTarihi, nStatus, sKullanici, bToplam)
        nGirisCikis = 11
        bKapali = True
        intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, "", 0, 0, 0, 0, "", 0, 0, 0, 0, "", 0, lNetTutar, dteKayitTarihi, nStatus, sKullanici, bToplam, bKapali)
        nGirisCikis = 3
        lNetTutar = 0
    End Sub
    Public Sub NCR_satisoku(ByVal dosya As String, ByVal kasa As String, ByVal sMagaza As String, ByVal nStatus As Integer, ByVal sKullanici As String, ByVal nIslem As Integer, ByVal sGramaj As String)
        status = False
        Dim z = (dosya)
        Dim sr As StreamReader = File.OpenText(z)
        Dim sk As StreamReader = File.OpenText(z)
        Dim s As String
        Dim satir As String
        Dim nAlisVerisID As String = ""
        Dim sSatir As String = ""
        Dim sSatisSatir As String = ""
        Dim nMusteriID As String = 0
        Dim sKasaNo As String = ""
        Dim lFisNo As Integer = 0
        Dim sFisTipi As String = "P"
        Dim nFisGC As Integer = 0
        Dim dteFisTarihi As String = "01/01/1900"
        Dim dteKayitTarihi As String = "01/01/1900"
        Dim sKasiyerRumuzu As String = ""
        Dim nGirisCikis As Integer = 3
        Dim nStokID As Integer = 0
        Dim sKodu As String = ""
        Dim lMiktar As Decimal = 0
        Dim lFiyat As Decimal = 0
        Dim lTutar As Decimal = 0
        Dim lToplamTutar As Decimal = 0
        Dim lBrutFiyat As Decimal = 0
        Dim lBrutTutar As Decimal = 0
        Dim sIskontoTipi As String = "TOP"
        Dim nIskontoYuzdesi As Decimal = 0
        Dim lIskontoTutari As Decimal = 0
        Dim lNetTutar As Decimal = 0
        Dim sKdvTipi As String = ""
        Dim sOdemeKodu As String = "NAK"
        Dim lOdemeTutar As Decimal = 0
        Dim bKapali As Boolean = True
        Dim bBarkod As Boolean = False
        Dim bToplam As Boolean = False
        Dim bGramaj As Boolean = False
        Dim nKdvOrani As Decimal = 0
        's = sr.Read
        Dim sayi As Integer
        Dim nSatirSayi As Integer = 0
        sayi = 0
        Do While sk.Peek() > -1
            satir = sk.ReadLine
            Try
                If Len(satir) = 78 Then
                    sayi += 1
                    nSatirSayi += 1
                End If
            Catch ex As Exception
                XtraMessageBox.Show(dosya.ToString & Sorgu_sDil("Ýsimli Dosyada ", sDil) & nSatirSayi & Sorgu_sDil(" Kayýtlý Satýr Hatalý,Lütfen Kontrol Ediniz", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Question)
            End Try
        Loop
        sk.Close()
        Dim dlg As New WaitDlgFrm("Toplam Satýr :" & sayi)
        sayi = 0
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        Do While sr.Peek() > -1
            sayi += 1
            s = sr.ReadLine()
            If Trim(s.Substring(32, 1)) = "S" Then
                If lFisNo <> Trim(s.Substring(23, 4)) And sayi > 1 Then
                    sOdemeKodu = "N"
                    lOdemeTutar = lNetTutar
                    nGirisCikis = 9
                    intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, sOdemeKodu, lOdemeTutar, 0, 0, 0, "", 0, 0, 0, 0, "", 0, lNetTutar, dteKayitTarihi, nStatus, sKullanici, bToplam)
                    nGirisCikis = 11
                    bKapali = True
                    intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, "", 0, 0, 0, 0, "", 0, 0, 0, 0, "", 0, lNetTutar, dteKayitTarihi, nStatus, sKullanici, bToplam, bKapali)
                    nGirisCikis = 3
                    lNetTutar = 0
                End If
                lFisNo = Trim(s.Substring(23, 4))
                nAlisVerisID = "D" & Trim(s.Substring(23, 4))
                sKasaNo = Trim(s.Substring(5, 3))
                Dim sYil As String = ""
                Dim sAy As String = ""
                Dim sGun As String = ""
                Dim sSaat As String = ""
                Dim sDakika As String = ""
                sYil = "20" & Trim(s.Substring(9, 2))
                sAy = Trim(s.Substring(11, 2))
                sGun = Trim(s.Substring(13, 2))
                sSaat = Trim(s.Substring(16, 2))
                sDakika = Trim(s.Substring(18, 2))
                dteFisTarihi = sGun + "/" + sAy + "/" + sYil
                dteKayitTarihi = dteFisTarihi + " " + sSaat + ":" + sDakika
                sSatisSatir = Trim(s.Substring(28, 3))
                'nStokID = Trim(s.Substring(30, 20))
                'nStokID = Trim(s.Substring(34, 6))
                sKodu = Trim(s.Substring(43, 16))
                If sKodu.Length > 5 Then
                    If Trim(sKodu.Substring(0, 2)) = Microsoft.VisualBasic.Left(sGramaj, 2) Then
                        sKodu = Trim(sKodu.Substring(2, 5))
                        bGramaj = True
                        'If lMiktar >= 1000 Then
                        'lMiktar = lMiktar / 1000
                        'ElseIf lMiktar < 1000 Then
                        '    lMiktar = "0." & lMiktar
                        'End If
                    Else
                        bGramaj = False
                    End If
                Else
                    bGramaj = False
                End If
                'nStokID = Trim(s.Substring(35, 6))
                nStokID = sorgu_nStokID(sKodu)
                nStokID = Microsoft.VisualBasic.Right(nStokID.ToString, 6)
                'nStokID = Microsoft.VisualBasic.Right(nStokID.ToString, 6)
                sKodu = sKodu
                Dim sMiktar = Trim(s.Substring(62, 6))
                If Right(sMiktar, 2) = "10" Then
                    If bGramaj = False Then
                        lMiktar = Trim(s.Substring(60, 4))
                    Else
                        lMiktar = Trim(s.Substring(62, 6))
                    End If
                Else
                End If
                'lMiktar = Trim(s.Substring(63, 6))
                lTutar = Trim(s.Substring(69, 9))
                lTutar = lTutar / 100
                lFiyat = lTutar / lMiktar
                lBrutFiyat = lFiyat
                lBrutTutar = lTutar
                If Trim(s.Substring(59, 1)) = "-" Then
                    lMiktar = -lMiktar
                    lTutar = -lTutar
                    lBrutTutar = -lBrutTutar
                    nGirisCikis = 4
                ElseIf Trim(s.Substring(59, 1)) = "+" Then
                    nGirisCikis = 3
                End If
                lNetTutar += lBrutTutar
                nKdvOrani = 0
                sMagaza = sDepo
                sSatir = sayi
                sFisTipi = "P"
                'intersatiskayit_baslik_degistir(sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sKasiyerRumuzu, sKasaNo, nStatus, sKullanici, bToplam, bKapali)
                intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, nStokID, sKodu, sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, "", 0, lMiktar, lBrutFiyat, lBrutTutar, "", 0, 0, lFiyat, lTutar, sKdvTipi, nKdvOrani, 0, dteKayitTarihi, nStatus, sKullanici, bToplam)
            End If
        Loop
        sr.Close()
        dlg.Close()
        sOdemeKodu = "N"
        lOdemeTutar = lNetTutar
        nGirisCikis = 9
        intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, sOdemeKodu, lOdemeTutar, 0, 0, 0, "", 0, 0, 0, 0, "", 0, lNetTutar, dteKayitTarihi, nStatus, sKullanici, bToplam)
        nGirisCikis = 11
        bKapali = True
        intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, "", 0, 0, 0, 0, "", 0, 0, 0, 0, "", 0, lNetTutar, dteKayitTarihi, nStatus, sKullanici, bToplam, bKapali)
        nGirisCikis = 3
        lNetTutar = 0
    End Sub

    Public Sub IBM_satisoku(ByVal dosya As String, ByVal kasa As String, ByVal sMagaza As String, ByVal nStatus As Integer, ByVal sKullanici As String, ByVal nIslem As Integer, ByVal sGramaj As String)
        status = False
        Dim z = (dosya)
        Dim sr As StreamReader = File.OpenText(z)
        Dim sk As StreamReader = File.OpenText(z)
        Dim s As String
        Dim satir As String
        Dim nAlisVerisID As String = ""
        Dim sSatir As String = ""
        Dim sSatisSatir As String = ""
        Dim nMusteriID As String = 0
        Dim sKasaNo = 1
        Dim lFisNo As Integer = 0
        Dim sFisTipi As String = "P"
        Dim nFisGC As Integer = 0
        Dim dteFisTarihi As String = "01/01/1900"
        Dim dteKayitTarihi As String = "01/01/1900"
        'Dim sKasiyerRumuzu As String = ""
        Dim nGirisCikis As Integer = 3
        Dim nStokID As Integer = 0
        Dim sBarkod As String = ""
        Dim sKodu As String = ""
        Dim lMiktar As Decimal = 0
        Dim lFiyat As Decimal = "0.00"
        Dim lTutar As Decimal = "0.00"
        Dim lToplamTutar As Decimal = "0.00"
        Dim lBrutFiyat As Decimal = "0.00"
        Dim lBrutTutar As Decimal = "0.00"
        Dim sIskontoTipi As String = "TOP"
        Dim nIskontoYuzdesi As Decimal = 0
        Dim lIskontoTutari As Decimal = "0.00"
        Dim lNetTutar As Decimal = 0
        Dim sKdvTipi As String = "01"
        Dim sOdemeKodu As String = ""
        Dim lOdemeTutar As Decimal = 0
        Dim bKapali As Boolean = True
        Dim bBarkod As Boolean = False
        Dim bToplam As Boolean = False
        Dim nKdvOrani As Decimal = 0
        Dim lToplamIskonto As Decimal = "0.00"
        Dim lNetTutarT As Decimal = "0.00"
        Dim lOdemeTutarT As Decimal = "0.00"
        Dim lMalIskontoTutariT As Decimal = 0
        Dim nGC As String = ""
        Dim IndirimliFiyat As Decimal = "0.00"
        's = sr.Read
        Dim sayi As Integer
        Dim nSatirSayi As Integer = 0
        sayi = 0
        Do While sk.Peek() > -1
            satir = sk.ReadLine
            Try
                If Len(satir) = 277 Then
                    sayi += 1
                    nSatirSayi += 1
                End If
            Catch ex As Exception
                XtraMessageBox.Show(dosya.ToString & Sorgu_sDil("Ýsimli Dosyada ", sDil) & nSatirSayi & Sorgu_sDil(" Kayýtlý Satýr Hatalý,Lütfen Kontrol Ediniz", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Question)
            End Try
        Loop
        sk.Close()
        Dim dlg As New WaitDlgFrm("Toplam Satýr :" & sayi)
        sayi = 0
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        Do While sr.Peek() > -1
            sayi += 1
            s = sr.ReadLine()
            If sayi > 1 Then
                If Trim(s.Substring(0, 2)) = 1 Then
                    If lFisNo <> Trim(s.Substring(35, 10)) And sayi >= 1 Then
                        nGirisCikis = 9
                        Dim sYil As String = ""
                        Dim sAy As String = ""
                        Dim sGun As String = ""
                        Dim sSaat As String = ""
                        Dim sDakika As String = ""

                        sYil = Trim(s.Substring(15, 4))
                        sAy = Trim(s.Substring(12, 2))
                        sGun = Trim(s.Substring(9, 2))
                        sSaat = Trim(s.Substring(35, 2))
                        sDakika = Trim(s.Substring(37, 2))
                        dteFisTarihi = sGun + "/" + sAy + "/" + sYil
                        dteKayitTarihi = dteFisTarihi + " " + sSaat + ":" + sDakika
                        intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, sOdemeKodu, lOdemeTutar, 0, 0, 0, "", 0, 0, 0, 0, "", 0, lOdemeTutar, dteKayitTarihi, nStatus, sKullanici, bToplam)
                        nGirisCikis = 11
                        bKapali = True
                        intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, "", 0, 0, 0, 0, "", 0, 0, 0, 0, "", 0, lNetTutar, dteKayitTarihi, nStatus, sKullanici, bToplam, bKapali)
                        nGirisCikis = 3
                        lNetTutar = 0
                    End If
                    lFisNo = Trim(s.Substring(35, 10))
                    nAlisVerisID = "D" & Trim(s.Substring(2, 2)) & Trim(s.Substring(35, 6))
                    sKasaNo = Trim(s.Substring(3, 6))
                    'Dim sYil As String = ""
                    'Dim sAy As String = ""
                    'Dim sGun As String = ""
                    'Dim sSaat As String = ""
                    'Dim sDakika As String = ""
                    If sKasaNo = 5 Then
                        sMagaza = "P009"
                    End If

                    'sYil = Trim(s.Substring(15, 4))
                    'sAy = Trim(s.Substring(12, 2))
                    'sGun = Trim(s.Substring(9, 2))
                    'sSaat = Trim(s.Substring(35, 2))
                    'sDakika = Trim(s.Substring(37, 2))
                    'dteFisTarihi = sGun + "/" + sAy + "/" + sYil
                    'dteKayitTarihi = dteFisTarihi + " " + sSaat + ":" + sDakika
                    sKasiyerRumuzu = Trim(s.Substring(53, 8))
                    lTutar = Replace((s.Substring(91, 15)), ",", ".")

                    lToplamIskonto = Replace((s.Substring(121, 15)), ",", ".")
                    lMalIskontoTutariT = lMalIskontoTutariT + lToplamIskonto
                    lToplamIskonto += lToplamIskonto

                    
                    nGC = Trim(s.Substring(61, 1))
                    If Trim(s.Substring(61, 1)) = 0 Then
                        sFisTipi = "P"
                        nGirisCikis = 3
                    ElseIf Trim(s.Substring(61, 1)) = 1 Then
                        sFisTipi = "P"
                        nGirisCikis = 3
                    ElseIf Trim(s.Substring(61, 1)) = 2 Then
                        sFisTipi = "P"
                        nGirisCikis = 4
                        lMiktar = -lMiktar
                        lTutar = -lTutar
                        lBrutTutar = -lBrutTutar
                        lFiyat = -lFiyat
                        lOdemeTutar = -lOdemeTutar
                    End If
                    If Trim(s.Substring(62, 1)) = 0 Then
                        nFisGC = 0
                        nStatus = 0
                    Else
                        nFisGC = 1
                        nStatus = 1
                    End If
                    'iade için yapýlan 
                    nGC = Trim(s.Substring(61, 1))
                    If Trim(s.Substring(61, 1)) = 0 Then
                        sFisTipi = "P"
                        nGirisCikis = 3
                    ElseIf Trim(s.Substring(61, 1)) = 1 Then
                        sFisTipi = "P"
                        nGirisCikis = 3
                    ElseIf Trim(s.Substring(61, 1)) = 2 Then
                        sFisTipi = "P"
                        nGirisCikis = 4
                        If lMiktar > 0 Then
                            lMiktar = -lMiktar
                            lTutar = -lTutar
                            lBrutTutar = -lBrutTutar
                            lFiyat = -lFiyat
                            lOdemeTutar = -lOdemeTutar
                        End If
                        End If
                        If Trim(s.Substring(0, 2)) = 1 Then
                            nGC = Trim(s.Substring(61, 1))
                            If nGC = 1 Then
                                lMiktar = -lMiktar
                                lTutar = -lTutar
                                lBrutTutar = -lBrutTutar
                                lFiyat = -lFiyat
                            lNetTutar = lTutar
                            lOdemeTutar = -lOdemeTutar
                                nGirisCikis = 4

                            ElseIf nGC = 0 Then
                                nGirisCikis = 3
                            End If
                        End If
                    lNetTutar = lTutar
                    lOdemeTutar = lNetTutar
                ElseIf Trim(s.Substring(0, 4)) = "03 1" Then
                    ''lNetTutar = Replace((s.Substring(11, 1)), ",", ".")
                    ''lNetTutar = Replace((s.Substring(13, 15)), ",", ".")
                    'lOdemeTutar = lNetTutar
                    'lNetTutarT = Replace((s.Substring(13, 15)), ",", ".")
                    'lOdemeTutar = Replace((s.Substring(13, 15)), ",", ".")
                    If nGirisCikis = 4 Then
                        lNetTutar = -lNetTutar
                        lOdemeTutar = -lOdemeTutar
                    End If
                    If nGirisCikis = 4 Then
                        If lMiktar > 0 Then
                            lMiktar = -lMiktar
                            lTutar = -lTutar
                            lBrutTutar = -lBrutTutar
                            lFiyat = -lFiyat
                            lNetTutar = lTutar
                            lBrutFiyat = -lBrutFiyat
                            lOdemeTutar = -lOdemeTutar
                        End If
                    End If
                    sOdemeKodu = Trim(s.Substring(9, 2))
                    If sOdemeKodu = "0" Then
                        sOdemeKodu = "N"
                    End If
                ElseIf Trim(s.Substring(0, 4)) = "03 2" Then
                    If Trim(s.Substring(11, 1)) = 0 Then
                        lNetTutar = lTutar
                        'lNetTutar = Replace((s.Substring(13, 15)), ",", ".")
                        'lNetTutar = lNetTutar + lNetTutarT
                        lOdemeTutar = lOdemeTutar
                        sOdemeKodu = Trim(s.Substring(9, 2))
                        If sOdemeKodu = "0" Then
                            sOdemeKodu = "N"
                        End If
                    Else
                        lNetTutar = lTutar
                        'lNetTutarT = Replace((s.Substring(13, 15)), ",", ".")
                        'lOdemeTutarT = Replace((s.Substring(13, 15)), ",", ".")
                        'lNetTutar = lNetTutar - lNetTutarT
                        'lOdemeTutar = lOdemeTutar - lOdemeTutarT
                    End If
                ElseIf Trim(s.Substring(0, 2)) = 3 Then
                    If Trim(s.Substring(11, 1)) = 1 Then
                        'lNetTutar = Replace((s.Substring(11, 1)), ",", ".")
                        lNetTutarT = Replace((s.Substring(13, 15)), ",", ".")
                        lOdemeTutarT = Replace((s.Substring(13, 15)), ",", ".")
                        'lNetTutar = lNetTutar - lNetTutarT
                        'lOdemeTutar = lOdemeTutar - lOdemeTutarT

                    End If


                ElseIf Trim(s.Substring(0, 2)) = 2 Then
                    sSatisSatir = Trim(s.Substring(3, 6))
                    'nStokID = Trim(s.Substring(30, 20))
                    sBarkod = Trim(s.Substring(182, 20))

                    lMiktar = Trim(s.Substring(45, 9))

                    If sBarkod.Length = 7 Then
                        If Trim(sBarkod.Substring(0, 2)) = Microsoft.VisualBasic.Left(sGramaj, 2) Then
                            sBarkod = Trim(sBarkod.Substring(2, 5))
                            'If lMiktar >= 1000 Then
                            lMiktar = lMiktar / 1000
                            'ElseIf lMiktar < 1000 Then
                            '    lMiktar = "0." & lMiktar
                            'End If
                        End If
                    End If
                    'nStokID = Trim(s.Substring(35, 6))
                    nStokID = sorgu_nStokID(sBarkod)
                    nStokID = Microsoft.VisualBasic.Right(nStokID.ToString, 6)
                    sKodu = sBarkod

                    'Dim deneme As String = Right(lTutar, 2)
                    'Dim deneme1 As String = Left(lTutar, 2)
                    lIskontoTutari = Replace((s.Substring(106, 15)), ",", ".")
                    lToplamIskonto = lToplamIskonto + lIskontoTutari
                    lBrutFiyat = Replace((s.Substring(76, 15)), ",", ".")
                    'If lIskontoTutari > 0 Then
                    '    lTutar = lTutar - lIskontoTutari
                    'Else
                    '    lTutar = lTutar
                    'End If
                    If lBrutFiyat > 0 Then
                        IndirimliFiyat = lBrutFiyat - lIskontoTutari
                        nIskontoYuzdesi = ((lBrutFiyat - IndirimliFiyat) / lBrutFiyat * 100)
                    End If
                    Try
                        lFiyat = lTutar / lMiktar
                    Catch ex As Exception
                        lFiyat = 0
                    End Try


                   
                    nKdvOrani = Trim(s.Substring(42, 2))
                    lBrutFiyat = Replace((s.Substring(61, 15)), ",", ".")
                    lBrutTutar = Replace((s.Substring(76, 15)), ",", ".")
                    'If Trim(s.Substring(33, 1)) = 1 Then
                    '    lMiktar = -lMiktar
                    '    lTutar = -lTutar
                    '    lBrutTutar = -lBrutTutar
                    '    lFiyat = -lFiyat
                    '    nGirisCikis = 4
                    'ElseIf Trim(s.Substring(33, 1)) = 0 Then
                    '    nGirisCikis = 3
                    'End If
                    'iade için yapýlan 
                    If Trim(s.Substring(33, 1)) = 1 Or nGC = 2 Then
                        lMiktar = -lMiktar
                        lTutar = -lTutar
                        lBrutFiyat = -lBrutFiyat
                        lBrutTutar = -lBrutTutar
                        lFiyat = -lFiyat
                        nGirisCikis = 4
                    ElseIf Trim(s.Substring(33, 1)) = 0 Then
                        lMiktar = lMiktar
                        lTutar = lTutar
                        lBrutFiyat = -lBrutFiyat
                        lBrutTutar = lBrutTutar
                        lFiyat = lFiyat
                        nGirisCikis = 3
                    End If


                    'lTutar = lTutar - lToplamIskonto
                    'lBrutFiyat = lFiyat
                    'lBrutTutar = lTutar
                    If Trim(s.Substring(0, 2)) = 99 Then
                        lMiktar = -lMiktar
                        lTutar = -lTutar
                        lBrutTutar = -lBrutTutar
                        lBrutFiyat = -lBrutFiyat
                        lFiyat = -lFiyat
                        lOdemeTutar = -lOdemeTutar
                        lNetTutar = -lNetTutar
                        nGirisCikis = 4
                        'ElseIf Trim(s.Substring(0, 2)) = 2 Then
                        '    nGirisCikis = 3
                    End If

                    sSatir = sayi
                    lOdemeTutar = lNetTutar
                    If nGirisCikis = 4 Then
                        If lMiktar > 0 Then
                            lMiktar = -lMiktar
                            lTutar = -lTutar
                            lBrutTutar = -lBrutTutar
                            lFiyat = -lFiyat
                            lNetTutar = -lNetTutar
                            lBrutFiyat = -lBrutFiyat
                            lOdemeTutar = lNetTutar
                        End If
                    End If

                    intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, nStokID, sKodu, sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, sOdemeKodu, 0, lMiktar, lBrutFiyat, lBrutTutar, "", nIskontoYuzdesi, lIskontoTutari, lFiyat, lTutar, sKdvTipi, nKdvOrani, lNetTutar, dteKayitTarihi, nStatus, sKullanici, bToplam)
                    End If
            End If

        Loop
        sr.Close()
        dlg.Close()
        nGirisCikis = 9
        intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, sOdemeKodu, lOdemeTutar, 0, 0, 0, "", 0, 0, 0, 0, "", 0, lOdemeTutar, dteKayitTarihi, nStatus, sKullanici, bToplam)
        nGirisCikis = 11
        bKapali = True
        intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, sOdemeKodu, lOdemeTutar, 0, 0, 0, "", 0, 0, 0, 0, "", 0, lNetTutar, dteKayitTarihi, nStatus, sKullanici, bToplam, bKapali)
        'nGirisCikis = 3
        'lNetTutar = lNetTutar
        'sOdemeKodu = sOdemeKodu
        'lOdemeTutar = lNetTutar
        lNetTutar = 0
    End Sub
    Public Sub inter_urun_oku(ByVal sPath As String, ByVal sFile As String)
        'dataset1.Tables("TOPLUSTOK").Clear()
        Dim dosya As String = "" & sPath & ":" & sFile & "\posgenel\urun.dat"
        Dim z = (dosya)
        Dim sr As StreamReader = File.OpenText(z)
        Dim sk As StreamReader = File.OpenText(z)
        Dim s As String
        Dim satir As String
        Dim satis
        'Dim plu
        's = sr.Read
        Dim takipno
        Dim barcode
        Dim stokadi
        Dim satisfiyati
        Dim departman
        Dim birimadi
        Dim status
        Dim fiyattl
        Dim sayi As Integer
        sayi = 0
        Do While sk.Peek() > -1
            satir = sk.ReadLine
            satis = Trim(satir.Substring(0, 63))
            sayi += 1
        Loop
        Dim dlg As New WaitDlgFrm("Toplam Satýr :" & sayi)
        sayi = 0
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\Formlar\database\barkoddb.mdb;Persist Security Info=False"
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "DELETE FROM PLU"
        cmd.ExecuteNonQuery()
        Do While sr.Peek() > -1
            s = sr.ReadLine
            satis = Trim(s.Substring(0, 63))
            takipno = Trim(satis.Substring(1, 6))
            barcode = Trim(satis.Substring(7, 20))
            stokadi = Trim(satis.Substring(27, 20))
            satisfiyati = Trim(satis.Substring(47, 9))
            departman = Trim(satis.Substring(56, 2))
            birimadi = Trim(satis.Substring(58, 4))
            status = Trim(satis.Substring(62, 1))
            fiyattl = CType(satisfiyati, Decimal) * 1000000
            cmd.CommandText = "INSERT INTO  PLU  (PLUNO, BARCODE, STOKADI,SATISFIYATI,BIRIM,DEPARTMAN,STATUS,SATISFIYATITL) VALUES     ('" & takipno & "','" & barcode & "','" & stokadi & "'," & CType(satisfiyati, Decimal) & ",'" & birimadi & "','" & departman & "','" & status & "'," & fiyattl & ")"
            cmd.ExecuteNonQuery()
        Loop
        'Dim stoklistesi As String = "SELECT     PLU.IND, PLU.PLUNO AS TAKIPNO, PLU.BARCODE, PLU.STOKADI, PLU.SATISFIYATI, PLU.BIRIM, PLU.DEPARTMAN, PLU.REYON, PLU.STATUS,  DEPARTMAN.KDV, DEPARTMAN.ACIKLAMA FROM         (PLU INNER JOIN DEPARTMAN ON PLU.DEPARTMAN = DEPARTMAN.DEPARTMAN)"
        con.Close()
        dlg.Close()
    End Sub
    Public Shared Function inter_urunlistesi(ByVal pluno As String, ByVal barcode As String, ByVal stokadi As String, ByVal reyon As String, ByVal islem As String) As DataSet
        Dim kriter As Object = "WHERE PLU.IND > 0"
        If pluno <> "" Then
            kriter += " AND (PLU.PLUNO LIKE '" & pluno & "%')"
        End If
        If barcode <> "" Then
            kriter += " AND (PLU.BARCODE LIKE '" & barcode & "%')"
        End If
        If stokadi <> "" Then
            kriter += " AND (PLU.STOKADI LIKE '" & stokadi & "%')"
        End If
        If reyon <> "" Then
            kriter += " AND (PLU.REYON LIKE '" & reyon & "%')"
        End If
        If islem = "Tartýlý Stoklar" Then
            kriter += " AND (PLU.STATUS ='E')"
        ElseIf islem = "Birim Fiyatlý Stoklar" Then
            kriter += " AND (PLU.STATUS ='P')"
        ElseIf islem = "Yeni Açýlan Stoklar" Then
            kriter += ""
        ElseIf islem = "Fiyatý Deðiþen Stoklar" Then
            kriter += ""
        ElseIf islem = "[Tüm Stoklar]" Then
            kriter += ""
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\Formlar\database\barkoddb.mdb;Persist Security Info=False"
        cmd.Connection = conn
        adapter.SelectCommand = cmd
        cmd.CommandText = "SELECT     PLU.IND, PLU.PLUNO AS TAKIPNO, PLU.BARCODE, PLU.STOKADI, PLU.SATISFIYATI, PLU.BIRIM, PLU.DEPARTMAN, PLU.REYON, PLU.STATUS,  DEPARTMAN.KDV, DEPARTMAN.ACIKLAMA,'1' AS MIKTAR, PLU.SATISFIYATITL FROM         PLU INNER JOIN DEPARTMAN ON PLU.DEPARTMAN = DEPARTMAN.DEPARTMAN " & kriter & ""
        conn.Open()
        Dim dataset1 As New DataSet
        Dim N As Integer = adapter.Fill(dataset1, "TABLE1")
        conn.Close()
        Return dataset1
    End Function
    Private Sub intersatiskayit_degistir(ByVal nAlisVerisID As String, ByVal sSatir As String, ByVal sFisTipi As String, ByVal nFisGC As Integer, ByVal dteFisTarihi As DateTime, ByVal lFisNo As Integer, ByVal nMusteriID As String, ByVal sMagazaKodu As String, ByVal nGirisCikis As Integer, ByVal nStokID As Integer, ByVal sKodu As String, ByVal sKasiyerRumuzu As String, ByVal sKasaNo As String, ByVal sOdemeKodu As String, ByVal lOdemeTutar As Decimal, ByVal lMiktar As Decimal, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal sIskontoTipi As String, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal lFiyat As Decimal, ByVal lTutar As Decimal, ByVal sKdvTipi As String, ByVal nKdvOrani As Decimal, ByVal lNetTutar As Decimal, ByVal dteKayitTarihi As DateTime, ByVal nStatus As Integer, ByVal sKullanici As String, ByVal bIskonto As Integer, Optional ByVal bKapali As Integer = 1)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection() With {.ConnectionString = connection}
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        con.Open()
        nIskontoYuzdesi = FormatNumber(nIskontoYuzdesi, 2)
        lFiyat = FormatNumber(lFiyat, 2)
        If nIskontoYuzdesi = 100 Then
            nIskontoYuzdesi = 99.99
        End If
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    BTBLINTERSATIS SET              lIskontoTutari = " & lIskontoTutari & ", nIskontoYuzdesi = " & nIskontoYuzdesi & ", sIskontoTipi = '" & sIskontoTipi & "', lTutar = " & lTutar & ", lFiyat = " & lFiyat & " WHERE     nAlisVerisID = '" & nAlisVerisID & "' AND sFisTipi = '" & sFisTipi & "' and nFisGC = " & nFisGC & " AND lFisNo =" & lFisNo & " AND dteKayitTarihi= '" & dteKayitTarihi & "' AND sKullanici='" & sKullanici & "' and sSatir ='" & sSatir & "'"
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub intersatiskayit_baslik_degistir(ByVal sFisTipi As String, ByVal nFisGC As Integer, ByVal dteFisTarihi As DateTime, ByVal lFisNo As Integer, ByVal nMusteriID As String, ByVal sKasiyerRumuzu As String, ByVal sKasaNo As String, ByVal nStatus As Integer, ByVal sKullanici As String, ByVal bIskonto As Integer, Optional ByVal bKapali As Integer = 1)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    BTBLINTERSATIS SET               nMusteriID = '" & nMusteriID & "', bIskonto = " & bIskonto & " ,bKapali = " & bKapali & ", nStatus = " & nStatus & " WHERE     dteFisTarihi ='" & dteFisTarihi & "' and sFisTipi = '" & sFisTipi & "' and  nFisGC = " & nFisGC & " AND lFisNo =" & lFisNo & " and sKullanici='" & sKullanici & "' and sKasiyerRumuzu ='" & sKasiyerRumuzu & "' and sKasaNo = '" & sKasaNo & "' "
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub intersatiskayit_toplam_degistir(ByVal sFisTipi As String, ByVal nFisGC As Integer, ByVal dteFisTarihi As DateTime, ByVal lFisNo As Integer, ByVal sKasiyerRumuzu As String, ByVal sKasaNo As String, ByVal lNetTutar As Decimal, ByVal sKullanici As String, ByVal bIskonto As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    BTBLINTERSATIS SET               lNetTutar = " & lNetTutar & " WHERE     dteFisTarihi ='" & dteFisTarihi & "' and sFisTipi = '" & sFisTipi & "' and nFisGC = " & nFisGC & " AND lFisNo =" & lFisNo & " and sKullanici='" & sKullanici & "' and sKasiyerRumuzu ='" & sKasiyerRumuzu & "' and sKasaNo = '" & sKasaNo & "' "
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub intersatiskayit(ByVal nAlisVerisID As String, ByVal sSatir As String, ByVal sFisTipi As String, ByVal nFisGC As Integer, ByVal dteFisTarihi As DateTime, ByVal lFisNo As Integer, ByVal nMusteriID As String, ByVal sMagazaKodu As String, ByVal nGirisCikis As Integer, ByVal nStokID As Integer, ByVal sKodu As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sKasaNo As String, ByVal sOdemeKodu As String, ByVal lOdemeTutar As Decimal, ByVal lMiktar As Decimal, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal sIskontoTipi As String, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal lFiyat As Decimal, ByVal lTutar As Decimal, ByVal sKdvTipi As String, ByVal nKdvOrani As Decimal, ByVal lNetTutar As Decimal, ByVal dteKayitTarihi As DateTime, ByVal nStatus As Integer, ByVal sKullanici As String, ByVal bIskonto As Integer, Optional ByVal bKapali As Integer = 1)
        If nStokID = 0 Then
            sSaticiRumuzu = ""
        End If
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO  BTBLINTERSATIS (nAlisVerisID, sSatir,sFisTipi,nFisGC,bKapali,bIskonto,nStatus,dteFisTarihi, lFisNo, nMusteriID, sMagazaKodu, nGirisCikis, nStokID, sKodu,sKasiyerRumuzu, sSaticiRumuzu,sKasaNo, sOdemeKodu,lOdemeTutar, lMiktar, lBrutFiyat, lBrutTutar, sIskontoTipi,nIskontoYuzdesi, lIskontoTutari, lFiyat, lTutar, sKdvTipi, nKdvOrani,lNetTutar, dteKayitTarihi,sKullanici) VALUES     ('" & nAlisVerisID & "' , '" & sSatir & "','" & sFisTipi & "'," & nFisGC & ", " & bKapali & "," & bIskonto & "," & nStatus & ",'" & dteFisTarihi & "', " & lFisNo & ", '" & nMusteriID & "', '" & sMagazaKodu & "', " & nGirisCikis & ", " & nStokID & ", '" & sKodu & "','" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "','" & sKasaNo & "', '" & sOdemeKodu & "'," & lOdemeTutar & ", " & lMiktar & ", " & lBrutFiyat & ", " & lBrutTutar & ", '" & sIskontoTipi & "'," & nIskontoYuzdesi & ", " & lIskontoTutari & ", " & lFiyat & ", " & lTutar & ", '" & sKdvTipi & "', " & nKdvOrani & ", " & lNetTutar & ",'" & dteKayitTarihi & "','" & sKullanici & "')"
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        con.Close()
    End Sub
    Public Function intercirokasiyer() As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     KASIYER AS NO, COUNT(FIS) AS FISSAYISI ,SUM(ARATOPLAM) AS CIRO, SUM(NAKIT) AS NAKIT, SUM(KREDI) AS KREDI FROM         BTBLINTERCIRO GROUP BY KASIYER ORDER BY NO"
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "POS")
        conn.Close()
        Return DS
    End Function
    Public Function intercirokdv() As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST(SUM(BTBLINTERSATIS.FIYAT) AS FLOAT) AS Toplam,DEPARTMAN.Kdv,'0' AS KdvMatrahý,'0' AS KdvTutarý, BTBLINTERSATIS.Dep,  DEPARTMAN.Acýklama FROM         BTBLINTERSATIS INNER JOIN DEPARTMAN ON BTBLINTERSATIS.DEP = DEPARTMAN.DEPARTMAN GROUP BY BTBLINTERSATIS.DEP, DEPARTMAN.KDV, DEPARTMAN.ACIKLAMA"
        'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST(SUM(ciro.FIYAT) AS FLOAT) AS Tutar, CAST(birim.KDV AS FLOAT) AS kdv, CAST(SUM(ciro.FIYAT) - SUM(ciro.FIYAT) / ((100 + birim.KDV) / 100) AS  FLOAT) AS Kdvtutarý FROM         BTBLINTERSATIS ciro  GROUP BY birim.KDV ORDER BY birim.KDV"
        'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST(SUM(ciro.FIYAT) AS FLOAT) AS Tutar, CAST(birim.KDV AS FLOAT) AS kdv, CAST(SUM(ciro.FIYAT) - SUM(ciro.FIYAT) / ((100 + birim.KDV) / 100) AS  FLOAT) AS Kdvtutarý FROM         BTBLINTERSATIS ciro INNER JOIN  F0100TBLSTOKLAR stok ON ciro.PLU = stok.IND INNER JOIN  F0100TBLBIRIMLEREX birim ON stok.IND = birim.STOKNO AND stok.ANABIRIM = birim.IND AND stok.BIRIMEX = birim.IND GROUP BY birim.KDV ORDER BY birim.KDV"
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "POS")
        conn.Close()
        Dim dr As DataRow
        For Each dr In DS.Tables(0).Rows
            dr("KDVTUTARI") = FormatNumber(dr("TOPLAM") - dr("TOPLAM") / ((100 + dr("nKdvOrani")) / 100), 2)
            dr("KDVMATRAHI") = FormatNumber(dr("TOPLAM") - dr("KDVTUTARI"), 2)
            dr("TOPLAM") = FormatNumber(dr("TOPLAM"), 2)
        Next
        Return DS
    End Function
    Private Function interpluidx() As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT PLU,SATIR FROM BTBLINTERPOSIDX ORDER BY PLU"
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "POS")
        conn.Close()
        Return DS
    End Function
    Public Sub inter_tumu(ByVal ilkkasa As Integer, ByVal sonkasa As Integer, ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String, ByVal sDepo As String)
        If XtraMessageBox.Show("Sisteme Kayýtlý Tüm Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?", "Ýnter Pos Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = MsgBoxResult.Yes Then
            Dim sAyrac As String = ":"
            If sPath = "\\tsclient\C" Or sPath = "\\tsclient\D" Or sPath = "\\tsclient\E" Or sPath = "\\tsclient\F" Then
                sAyrac = ""
            End If
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            kod1 = ""
            kod2 = ""
            kod3 = ""
            kod4 = ""
            kod5 = ""
            stokkriter = "Tüm Stoklar"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            'Dim dlg As New WaitDlgFrm("Ýnter Pos Stok Dosyasý Oluþturuluyor...")
            'dlg.Refresh()
            kriterkontrol()
            dataset1 = sorgu_inter(sFiyat1, sFiyat2, sFiyat3, sFiyatTipi)
            dosyaolusturINTER(sPath, sFile, sFiyatTipi, sGramaj, sDepo)
            'dlg.Close()
            Dim i As Integer
            Dim t As Integer = 0
            t = ilkkasa - 1
            For i = ilkkasa To sonkasa
                t += 1
                Dim Z As String = String.Format("{0}" & sAyrac & "{1}\POSKON\MESAJ.{2}", sPath, sFile, sayiuzunlukkontrol(t, 3))
                Dim sw As StreamWriter = File.CreateText(Z)
                sw.WriteLine("107100000000000")
                sw.Close()
            Next
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi & vbCrLf & Sorgu_sDil("Kasalara Mesaj Gönderildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Me.Refresh()
            'Dim frm As New frmkasaizle
            'frm.ilkkasa = 1
            'frm.sonkasa = kasasayisi
            'frm.ShowDialog()
            kasa_izle(ilkkasa, sonkasa, sPath, "inter")
        End If
    End Sub
    Public Sub inter_tumu_toptan(ByVal ilkkasa As Integer, ByVal sonkasa As Integer, ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String, ByVal sDepo As String)
        If XtraMessageBox.Show("Sisteme Kayýtlý Tüm Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?", "Ýnter Pos Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = MsgBoxResult.Yes Then
            Dim sAyrac As String = ":"
            If sPath = "\\tsclient\C" Or sPath = "\\tsclient\D" Or sPath = "\\tsclient\E" Or sPath = "\\tsclient\F" Then
                sAyrac = ""
            End If
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            kod1 = ""
            kod2 = ""
            kod3 = ""
            kod4 = ""
            kod5 = ""
            stokkriter = "Tüm Stoklar"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            'Dim dlg As New WaitDlgFrm("Ýnter Pos Stok Dosyasý Oluþturuluyor...")
            'dlg.Refresh()
            kriterkontrol()
            dataset1 = sorgu_inter(sFiyat1, sFiyat2, sFiyat3, sFiyatTipi)
            dosyaolusturINTER(sPath, sFile, sFiyatTipi, sGramaj, sDepo)
            'dlg.Close()
            Dim i As Integer
            Dim t As Integer = 0
            t = ilkkasa - 1
            For i = ilkkasa To sonkasa
                t += 1
                Dim Z As String = String.Format("{0}" & sAyrac & "{1}\POSKON\MESAJ.{2}", sPath, sFile, sayiuzunlukkontrol(t, 3))
                Dim sw As StreamWriter = File.CreateText(Z)
                sw.WriteLine("12900000000000")
                sw.Close()
            Next
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi & vbCrLf & Sorgu_sDil("Kasalara Mesaj Gönderildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Me.Refresh()
            'Dim frm As New frmkasaizle
            'frm.ilkkasa = 1
            'frm.sonkasa = kasasayisi
            'frm.ShowDialog()
            kasa_izle(ilkkasa, sonkasa, sPath, "inter")
        End If
    End Sub
    Public Sub inter_tumu_uruntaksit(ByVal ilkkasa As Integer, ByVal sonkasa As Integer, ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        If XtraMessageBox.Show("Sisteme Kayýtlý Tüm Stoklarýn Taksitli Fiyatlarini Kasaya Göndermek Ýstediðinize Emin misiniz..?", "Ýnter Pos Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = MsgBoxResult.Yes Then
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            kod1 = ""
            kod2 = ""
            kod3 = ""
            kod4 = ""
            kod5 = ""
            stokkriter = "Tüm Stoklar"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            Dim dlg As New WaitDlgFrm("Ýnter Pos Stok Taksit Dosyasý Oluþturuluyor...")
            dlg.Refresh()
            kriterkontrol()
            dataset1 = sorgu_inter_nStokIDSirali(sFiyat1, sFiyat2, sFiyat3, sFiyatTipi)
            dosyaolusturINTER_uruntaksit(sPath, sFile, sFiyatTipi, sGramaj)
            dlg.Close()
            Dim i As Integer
            Dim t As Integer = 0
            t = ilkkasa - 1
            For i = ilkkasa To sonkasa
                t += 1
                Dim Z As String = String.Format("{0}:{1}\POSKON\MESAJ.{2}", sPath, sFile, sayiuzunlukkontrol(t, 3))
                Dim sw As StreamWriter = File.CreateText(Z)
                sw.WriteLine("119100000000000")
                sw.Close()
            Next
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi & vbCrLf & Sorgu_sDil("Kasalara Mesaj Gönderildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Me.Refresh()
            kasa_izle(ilkkasa, sonkasa, sPath, "inter")
        End If
    End Sub
    Public Sub inter_secili(ByVal ilkkasa As Integer, ByVal sonkasa As Integer, ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As Integer, ByVal sGramaj As String, ByVal sDepo As String)
        If XtraMessageBox.Show("Seçili Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?", "Ýnter Pos Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = MsgBoxResult.Yes Then
            Dim dlg As New WaitDlgFrm("Ýnter Pos Stok Dosyasý Oluþturuluyor...")
            dosyaolusturINTER(sPath, sFile, sFiyatTipi, sGramaj, sDepo)
            dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim sAyrac As String = ":"
            If sPath = "\\tsclient\C" Or sPath = "\\tsclient\D" Or sPath = "\\tsclient\E" Or sPath = "\\tsclient\F" Then
                sAyrac = ""
            End If
            Dim i As Integer
            Dim t As Integer = 0
            t = ilkkasa - 1
            For i = ilkkasa To sonkasa
                t += 1
                Dim Z As String = String.Format("{0}" & sAyrac & "{1}\POSKON\MESAJ.{2}", sPath, sFile, sayiuzunlukkontrol(t, 3))
                Dim sw As StreamWriter = File.CreateText(Z)
                sw.WriteLine("107100000000000")
                sw.Close()
            Next
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
            kasa_izle(ilkkasa, sonkasa, sPath, "inter")
        End If
    End Sub
    Public Sub inter_degisenler(ByVal ilkkasa As Integer, ByVal sonkasa As Integer, ByVal sPath As String, ByVal sFile As String, ByVal fiyat As Integer, ByVal sGramaj As String)
        If XtraMessageBox.Show("Deðiþen Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?", "Ýnter Pos Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = MsgBoxResult.Yes Then
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            kod1 = ""
            kod2 = ""
            kod3 = ""
            kod4 = ""
            kod5 = ""
            stokkriter = "1.Fiyatý Deðiþenler"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            tarih1 = Today
            tarih2 = Today
            Dim dlg As New WaitDlgFrm("Ýnter Pos Stok Dosyasý Oluþturuluyor...")
            dlg.Refresh()
            kriterkontrol()
            dataset1 = sorgu(fiyat)
            dosyaolusturINTER_degisen(sPath, sFile, fiyat, sGramaj)
            dlg.Close()
            'MsgBox(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : " & sayi & vbCrLf & "Kasalara Mesaj Gönderildi",sDil), MessageBoxButtons.YesNo,sorgu_sDil("Dikkat",sDil))
            'Dim i As Integer
            'Dim t As Integer = 0
            'For i = 1 To kasasayisi
            '    t += 1
            '    Dim Z As String = "" & path & ":\POSKON\MESAJ.00" & t & ""
            '    Dim sw As StreamWriter = File.CreateText(Z)
            '    sw.WriteLine("107100000000000")
            '    sw.Close()
            'Next
            Dim sAyrac As String = ":"
            If sPath = "\\tsclient\C" Or sPath = "\\tsclient\D" Or sPath = "\\tsclient\E" Or sPath = "\\tsclient\F" Then
                sAyrac = ""
            End If
            If sayi > 0 Then
                Dim i As Integer
                Dim t As Integer = 0
                t = 0
                t = ilkkasa - 1
                For i = ilkkasa To sonkasa
                    t += 1
                    'Dim Z As String = "" & path & ":\POSKON\MESAJ.00" & t & ""
                    Dim Z As String = String.Format("{0}" & sAyrac & "{1}\POSKON\MESAJ.{2}", sPath, sFile, sayiuzunlukkontrol(t, 3))
                    Dim sw As StreamWriter = File.CreateText(Z)
                    sw.WriteLine("1230000000000")
                    sw.Close()
                Next
                XtraMessageBox.Show(Sorgu_sDil(String.Format("Toplam Gönderilen Ürün Sayýsý : {0}{1}Kasalara Mesaj Gönderildi", sayi, vbCrLf), sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Dim frm As New frmkasaizle
                'frm.ilkkasa = 1
                'frm.sonkasa = kasasayisi
                'frm.ShowDialog()
            Else
                XtraMessageBox.Show(Sorgu_sDil(String.Format("Deðiþen Ürün Sayýsý '0'{0}Kasalara Mesaj Gönderilemedi...", vbCrLf), sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            End If
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
            'Me.Refresh()
            kasa_izle(ilkkasa, sonkasa, sPath, "inter")
        End If
    End Sub
    Public Sub inter_cariler(ByVal ilkkasa As Integer, ByVal sonkasa As Integer, ByVal sPath As String, ByVal sFile As String, ByVal fiyat As Integer)
        If XtraMessageBox.Show("Sisteme Kayýtlý Cari Kayýtlarýný Kasaya Göndermek Ýstediðinize Emin misiniz..?", "Ýnter Pos Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = MsgBoxResult.Yes Then
            Dim dlg As New WaitDlgFrm("Ýnter Pos Cari Dosyasý Oluþturuluyor...")
            dosyaolusturINTER_cariler(sPath, sFile, fiyat, "Inter")
            dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Cari Kayýt Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim sAyrac As String = ":"
            If sPath = "\\tsclient\C" Or sPath = "\\tsclient\D" Or sPath = "\\tsclient\E" Or sPath = "\\tsclient\F" Then
                sAyrac = ""
            End If
            Dim i As Integer
            Dim t As Integer = 0
            t = ilkkasa - 1
            For i = ilkkasa To sonkasa
                t += 1
                Dim Z As String = String.Format("{0}" & sAyrac & "{1}\POSKON\MESAJ.{2}", sPath, sFile, sayiuzunlukkontrol(t, 3))
                Dim sw As StreamWriter = File.CreateText(Z)
                sw.WriteLine("108100000000000")
                sw.Close()
            Next
            'dataset1.Tables(0).Clear()
            'Dim frm As New frmkasaizle
            'frm.ilkkasa = ilkkasa
            'frm.sonkasa = sonkasa
            'frm.ShowDialog()
            kasa_izle(ilkkasa, sonkasa, sPath, "inter")
        End If
    End Sub
    Public Sub ESCORT_cariler(ByVal ilkkasa As Integer, ByVal sonkasa As Integer, ByVal sPath As String, ByVal sFile As String, ByVal fiyat As Integer)
        If XtraMessageBox.Show("Sisteme Kayýtlý Cari Kayýtlarýný Kasaya Göndermek Ýstediðinize Emin misiniz..?", "Ýnter Pos Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = MsgBoxResult.Yes Then
            Dim dlg As New WaitDlgFrm("ESCORT Pos Cari Dosyasý Oluþturuluyor...")
            dosyaolusturINTER_cariler(sPath, sFile, fiyat, "Escort")
            dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Cari Kayýt Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim i As Integer
            Dim t As Integer = 0
            t = ilkkasa - 1
            For i = ilkkasa To sonkasa
                t += 1
                Dim Z As String = String.Format("{0}:{1}\POSGENEL\DATA\MESAJ.{2}", sPath, sFile, sayiuzunlukkontrol(t, 3))
                Dim sw As StreamWriter = File.CreateText(Z)
                sw.WriteLine("108000000000000")
                sw.Close()
            Next
            'dataset1.Tables(0).Clear()
            'Dim frm As New frmkasaizle
            'frm.ilkkasa = 1
            'frm.sonkasa = kasasayisi
            'frm.ShowDialog()
            kasa_izle(ilkkasa, sonkasa, sPath, "escort")
        End If
    End Sub
    Public Sub inter_cariler2(ByVal ilkkasa As Integer, ByVal sonkasa As Integer, ByVal sPath As String, ByVal sFile As String, ByVal fiyat As Integer)
        If XtraMessageBox.Show("Sisteme Kayýtlý Cari Kayýtlarýný Kasaya Göndermek Ýstediðinize Emin misiniz..?", "Ýnter Pos Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = MsgBoxResult.Yes Then
            Dim dlg As New WaitDlgFrm("Ýnter Pos Cari Dosyasý Oluþturuluyor...")
            dosyaolusturINTER_cariler2(sPath, sFile, fiyat)
            dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Cari Kayýt Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim sAyrac As String = ":"
            If sPath = "\\tsclient\C" Or sPath = "\\tsclient\D" Or sPath = "\\tsclient\E" Or sPath = "\\tsclient\F" Then
                sAyrac = ""
            End If
            Dim i As Integer
            Dim t As Integer = 0
            t = ilkkasa - 1
            For i = ilkkasa To sonkasa
                t += 1
                Dim Z As String = String.Format("{0}" & sAyrac & "{1}\POSKON\MESAJ.{2}", sPath, sFile, sayiuzunlukkontrol(t, 3))
                Dim sw As StreamWriter = File.CreateText(Z)
                sw.WriteLine("108100000000000")
                sw.Close()
            Next
            'dataset1.Tables(0).Clear()
            'Dim frm As New frmkasaizle
            'frm.ilkkasa = 1
            'frm.sonkasa = kasasayisi
            'frm.ShowDialog()
            kasa_izle(ilkkasa, sonkasa, sPath, "inter")
        End If
    End Sub
    Public Sub Siemens_TXT_musteriler(ByVal sPath As String, ByVal sFile As String, ByVal fiyat As Integer)
        If XtraMessageBox.Show("Sisteme Kayýtlý Müþteri Kayýtlarýný Kasaya Göndermek Ýstediðinize Emin misiniz..?", "Ýnter Pos Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = MsgBoxResult.Yes Then
            Dim dlg As New WaitDlgFrm("Siemens Pos Cari Dosyasý Oluþturuluyor...")
            dosyaolustur_Siemens_cariler(sPath, sFile, fiyat)
            dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Müþteri Kayýt Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub kasa_izle(ByVal ilkkasa As Integer, ByVal sonkasa As Integer, ByVal sPath As String, ByVal kasa As String)
        Dim frm As New frmkasaizle
        frm.ilkkasa = ilkkasa
        frm.sonkasa = sonkasa
        frm.sPath = sPath
        frm.kasa = kasa
        frm.ShowDialog()
    End Sub
    Public Sub ESCORT_tumu(ByVal ilkkasa As Integer, ByVal sonkasa As Integer, ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As Integer, ByVal sGramaj As String)
        If XtraMessageBox.Show("Sisteme Kayýtlý Tüm Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?", "ESCORT Pos Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = MsgBoxResult.Yes Then
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            kod1 = ""
            kod2 = ""
            kod3 = ""
            kod4 = ""
            kod5 = ""
            stokkriter = "Tüm Stoklar"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            'Dim dlg As New WaitDlgFrm("ESCORT Pos Stok Dosyasý Oluþturuluyor...")
            'dlg.Refresh()
            kriterkontrol()
            dataset1 = sorgu_inter(sFiyat1, sFiyat2, sFiyat3, sFiyatTipi)
            Dim path = sPath  'Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("INTERPOS").GetValue("PATH")
            dosyaolusturESCORT(sPath, sFile, sFiyatTipi, sGramaj)
            'dlg.Close()
            Dim sAyrac As String = ":"
            If sPath = "\\tsclient\C" Or sPath = "\\tsclient\D" Or sPath = "\\tsclient\E" Or sPath = "\\tsclient\F" Then
                sAyrac = ""
            End If
            Dim i As Integer
            Dim t As Integer = 0
            t = ilkkasa - 1
            For i = ilkkasa To sonkasa
                t += 1
                Dim Z As String = "" & sPath & sAyrac & sFile & "\POSGENEL\DATA\MESAJ." & sayiuzunlukkontrol(t, 3)
                Dim sw As StreamWriter = File.CreateText(Z)
                sw.WriteLine("107100000000000")
                sw.Close()
            Next
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : " & sayi & vbCrLf & "Kasalara Mesaj Gönderildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            kasa_izle(ilkkasa, sonkasa, path, "escort")
            'Me.Refresh()
        End If
    End Sub
    Public Sub ESCORT_secili(ByVal ilkkasa As Integer, ByVal sonkasa As Integer, ByVal sPath As String, ByVal sFile As String, ByVal fiyat As Integer, ByVal sGramaj As String)
        If XtraMessageBox.Show("Seçili Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?", "ESCORT Pos Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = MsgBoxResult.Yes Then
            Dim dlg As New WaitDlgFrm("ESCORT Pos Stok Dosyasý Oluþturuluyor...")
            dosyaolusturESCORT(sPath, sFile, fiyat, sGramaj)
            dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim sAyrac As String = ":"
            If sPath = "\\tsclient\C" Or sPath = "\\tsclient\D" Or sPath = "\\tsclient\E" Or sPath = "\\tsclient\F" Then
                sAyrac = ""
            End If
            Dim i As Integer
            Dim t As Integer = 0
            t = ilkkasa - 1
            For i = ilkkasa To sonkasa
                t += 1
                Dim Z As String = "" & sPath & sAyrac & sFile & "\POSGENEL\DATA\MESAJ." & sayiuzunlukkontrol(t, 3)
                Dim sw As StreamWriter = File.CreateText(Z)
                sw.WriteLine("107100000000000")
                sw.Close()
            Next
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
            kasa_izle(ilkkasa, sonkasa, sPath, "escort")
        End If
    End Sub
    Public Sub ESCORT_degisenler(ByVal ilkkasa As Integer, ByVal sonkasa As Integer, ByVal sPath As String, ByVal sFile As String, ByVal fiyat As Integer, ByVal sGramaj As String)
        If XtraMessageBox.Show("Deðiþen Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?", "Ýnter Pos Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = MsgBoxResult.Yes Then
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            kod1 = ""
            kod2 = ""
            kod3 = ""
            kod4 = ""
            kod5 = ""
            stokkriter = "1.Fiyatý Deðiþenler"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            tarih1 = Today
            tarih2 = Today
            Dim dlg As New WaitDlgFrm("Escort Pos Stok Dosyasý Oluþturuluyor...")
            dlg.Refresh()
            kriterkontrol()
            dataset1 = sorgu(fiyat)
            Dim path = sPath  'Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("INTERPOS").GetValue("PATH")
            dosyaolusturESCORT(sPath, sFile, fiyat, sGramaj, "TEKURUN.DAT")
            dlg.Close()
            Dim sAyrac As String = ":"
            If sPath = "\\tsclient\C" Or sPath = "\\tsclient\D" Or sPath = "\\tsclient\E" Or sPath = "\\tsclient\F" Then
                sAyrac = ""
            End If
            If sayi > 0 Then
                Dim i As Integer
                Dim t As Integer = 0
                t = 0
                t = ilkkasa - 1
                For i = ilkkasa To sonkasa
                    t += 1
                    'Dim Z As String = "" & path & ":\POSKON\MESAJ.00" & t & ""
                    Dim Z As String = "" & sPath & sAyrac & sFile & "\POSGENEL\DATA\MESAJ." & sayiuzunlukkontrol(t, 3) & ""
                    Dim sw As StreamWriter = File.CreateText(Z)
                    sw.WriteLine("1230000000000")
                    sw.Close()
                Next
                XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi & vbCrLf & Sorgu_sDil("Kasalara Mesaj Gönderildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Dim frm As New frmkasaizle
                'frm.ilkkasa = 1
                'frm.sonkasa = kasasayisi
                'frm.ShowDialog()
            Else
                XtraMessageBox.Show(Sorgu_sDil("Deðiþen Ürün Sayýsý '0'", sDil) & vbCrLf & Sorgu_sDil("Kasalara Mesaj Gönderilemedi...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
            'Me.Refresh()
            kasa_izle(ilkkasa, sonkasa, path, "escort")
        End If
    End Sub
    Public Sub CASLP1_tumu(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String, ByVal nTartili As Integer, ByVal nSinif As Integer, ByVal sSinif As String, Optional ByVal bBarkodlu As Boolean = False)
        If nTartili = 1 Then
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            If sSinif <> "" Then
                If nSinif = 1 Then
                    kod1 = sSinif
                ElseIf nSinif = 2 Then
                    kod2 = sSinif
                ElseIf nSinif = 3 Then
                    kod3 = sSinif
                ElseIf nSinif = 4 Then
                    kod4 = sSinif
                ElseIf nSinif = 5 Then
                    kod5 = sSinif
                End If
            Else
                kod1 = ""
                kod2 = ""
                kod3 = ""
                kod4 = ""
                kod5 = ""
            End If
            stokkriter = "Tartýlý Stoklar"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            kriterkontrol()
            dataset1 = sorgu(sFiyatTipi)
        End If
        dosyaolusturCASLP1(sPath, sFile, sFiyatTipi, sGramaj, bBarkodlu)
        XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub Dibal_tumu(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String, ByVal nTartili As Integer, ByVal nSinif As Integer, ByVal sSinif As String)
        If nTartili = 1 Then
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            If sSinif <> "" Then
                If nSinif = 1 Then
                    kod1 = sSinif
                ElseIf nSinif = 2 Then
                    kod2 = sSinif
                ElseIf nSinif = 3 Then
                    kod3 = sSinif
                ElseIf nSinif = 4 Then
                    kod4 = sSinif
                ElseIf nSinif = 5 Then
                    kod5 = sSinif
                End If
            Else
                kod1 = ""
                kod2 = ""
                kod3 = ""
                kod4 = ""
                kod5 = ""
            End If
            stokkriter = "Tartýlý Stoklar"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            kriterkontrol()
            dataset1 = sorgu(sFiyatTipi)
        End If
        dosyaolusturDibal(sPath, sFile, sFiyatTipi, sGramaj)
        XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub AveryBarkel_tumu(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String, ByVal nTartili As Integer, ByVal nSinif As Integer, ByVal sSinif As String)
        If nTartili = 1 Then
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            If sSinif <> "" Then
                If nSinif = 1 Then
                    kod1 = sSinif
                ElseIf nSinif = 2 Then
                    kod2 = sSinif
                ElseIf nSinif = 3 Then
                    kod3 = sSinif
                ElseIf nSinif = 4 Then
                    kod4 = sSinif
                ElseIf nSinif = 5 Then
                    kod5 = sSinif
                End If
            Else
                kod1 = ""
                kod2 = ""
                kod3 = ""
                kod4 = ""
                kod5 = ""
            End If
            stokkriter = "Tartýlý Stoklar"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            kriterkontrol()
            dataset1 = sorgu(sFiyatTipi)
        End If
        dosyaolustur_AveryBarkel(sPath, sFile, sFiyatTipi, sGramaj)
        XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub OLIVETTILP15_tumu(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String, ByVal nTartili As Integer, ByVal nSinif As Integer, ByVal sSinif As String)
        If nTartili = 1 Then
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            If sSinif <> "" Then
                If nSinif = 1 Then
                    kod1 = sSinif
                ElseIf nSinif = 2 Then
                    kod2 = sSinif
                ElseIf nSinif = 3 Then
                    kod3 = sSinif
                ElseIf nSinif = 4 Then
                    kod4 = sSinif
                ElseIf nSinif = 5 Then
                    kod5 = sSinif
                End If
            Else
                kod1 = ""
                kod2 = ""
                kod3 = ""
                kod4 = ""
                kod5 = ""
            End If
            stokkriter = "Tartýlý Stoklar"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            kriterkontrol()
            dataset1 = sorgu(sFiyatTipi)
        End If
        dosyaolusturOLIVETTILP15(sPath, sFile, sFiyatTipi, sGramaj)
        XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub CASLP15R_tumu(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String, ByVal nTartili As Integer, ByVal nSinif As Integer, ByVal sSinif As String)
        If nTartili = 1 Then
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            If sSinif <> "" Then
                If nSinif = 1 Then
                    kod1 = sSinif
                ElseIf nSinif = 2 Then
                    kod2 = sSinif
                ElseIf nSinif = 3 Then
                    kod3 = sSinif
                ElseIf nSinif = 4 Then
                    kod4 = sSinif
                ElseIf nSinif = 5 Then
                    kod5 = sSinif
                End If
            Else
                kod1 = ""
                kod2 = ""
                kod3 = ""
                kod4 = ""
                kod5 = ""
            End If
            stokkriter = "Tartýlý Stoklar"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            kriterkontrol()
            dataset1 = sorgu(sFiyatTipi)
        End If
        dosyaolusturCASLP15R(sPath, sFile, sFiyatTipi, sGramaj)
        XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub DIGISM80_tumu(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String, ByVal nTartili As Integer, ByVal nSinif As Integer, ByVal sSinif As String)
        If nTartili = 1 Then
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            If sSinif <> "" Then
                If nSinif = 1 Then
                    kod1 = sSinif
                ElseIf nSinif = 2 Then
                    kod2 = sSinif
                ElseIf nSinif = 3 Then
                    kod3 = sSinif
                ElseIf nSinif = 4 Then
                    kod4 = sSinif
                ElseIf nSinif = 5 Then
                    kod5 = sSinif
                End If
            Else
                kod1 = ""
                kod2 = ""
                kod3 = ""
                kod4 = ""
                kod5 = ""
            End If
            stokkriter = "Tartýlý Stoklar"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            kriterkontrol()
            dataset1 = sorgu(sFiyatTipi)
        End If
        dosyaolusturDIGISM80(sPath, sFile, sFiyatTipi, sGramaj)
        'MsgBox(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi & vbCrLf & Sorgu_sDil("Kasalara Mesaj Gönderildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub ISHIDA_tumu(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String, ByVal nTartili As Integer, ByVal nSinif As Integer, ByVal sSinif As String, Optional ByVal bToledo As Boolean = False)
        If nTartili = 1 Then
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            If sSinif <> "" Then
                If nSinif = 1 Then
                    kod1 = sSinif
                ElseIf nSinif = 2 Then
                    kod2 = sSinif
                ElseIf nSinif = 3 Then
                    kod3 = sSinif
                ElseIf nSinif = 4 Then
                    kod4 = sSinif
                ElseIf nSinif = 5 Then
                    kod5 = sSinif
                End If
            Else
                kod1 = ""
                kod2 = ""
                kod3 = ""
                kod4 = ""
                kod5 = ""
            End If
            stokkriter = "Tartýlý Stoklar"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            kriterkontrol()
            dataset1 = sorgu(sFiyatTipi)
        End If
        dosyaolusturishida(sPath, sFile, sFiyatTipi, sGramaj, bToledo)
        XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub Hugin425TX_tumu(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String, ByVal sPort As String)
        If XtraMessageBox.Show(Sorgu_sDil("Sisteme Kayýtlý Tüm Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            kod1 = ""
            kod2 = ""
            kod3 = ""
            kod4 = ""
            kod5 = ""
            stokkriter = "Tüm Stoklar"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            'Dim dlg As New WaitDlgFrm("Hugin Stok Dosyasý Oluþturuluyor...")
            'dlg.Refresh()
            kriterkontrol()
            dataset1 = sorgu(sFiyatTipi)
            dosyaolustur_HUGIN425TX(sPath, sFile, sFiyatTipi, sGramaj)
            'dlg.Close()
            'If XtraMessageBox.Show(Sorgu_sDil("Kayýtlý Tüm Stoklarý Kasaya Göndermek Ýstediðinize Eminmisiniz...!", sDil), sorgu_sDil("Dikkat",sDil),MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            '    'Dim z As String = "c:\entry01\entry.bat" 'SAVE.FileName.ToString
            '    'Dim DOSYA As New FileInfo(z)
            '    'If DOSYA.Exists Then
            '    '    DOSYA.Delete()
            '    'End If
            '    'Dim sw As StreamWriter = File.AppendText(z)
            '    'sw.WriteLine("@echo off")
            '    'sw.WriteLine("ECHO LUTFEN YAZARKASANIZI KONTROL EDINIZ...!")
            '    'sw.WriteLine("ECHO LUTFEN ISLEMIN BITMESINI BEKLEYINIZ...!")
            '    'sw.WriteLine("ECHO Toplam Gonderilecek Urun Sayisi :" & sayi & "")
            '    'sw.WriteLine("C:")
            '    'sw.WriteLine("cd\entry01")
            '    'sw.WriteLine("C:\entry01\ENTRYIBM.EXE 7 2 2 plu.txt plu.err")
            '    'sw.WriteLine("type urun.err")
            '    'sw.Close()
            '    'Process.Start("c:\entry01\entry.bat")
            'End If
        End If
    End Sub
    Public Sub Entry_tumu(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        If XtraMessageBox.Show(Sorgu_sDil("Sisteme Kayýtlý Tüm Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            kod1 = ""
            kod2 = ""
            kod3 = ""
            kod4 = ""
            kod5 = ""
            stokkriter = "Tüm Stoklar"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            'Dim dlg As New WaitDlgFrm("Entry Stok Dosyasý Oluþturuluyor...")
            'dlg.Refresh()
            kriterkontrol()
            dataset1 = sorgu(sFiyatTipi)
            dosyaolustur_IBMEntry_Vega(sPath, sFile, sFiyatTipi, sGramaj)
            'dlg.Close()
            'Process.Start("C:\NEW-YTL\ENTRYIBM.EXE", "7 2 2 C:\urun.yaz c:\urun.err")
            If XtraMessageBox.Show(Sorgu_sDil("Kayýtlý Tüm Stoklarý Kasaya Göndermek Ýstediðinize Eminmisiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim z As String = "c:\entry01\entry.bat" 'SAVE.FileName.ToString
                Dim DOSYA As New FileInfo(z)
                If DOSYA.Exists Then
                    DOSYA.Delete()
                End If
                Dim sw As StreamWriter = File.AppendText(z)
                sw.WriteLine("@echo off")
                sw.WriteLine("ECHO LUTFEN YAZARKASANIZI KONTROL EDINIZ...!")
                sw.WriteLine("ECHO LUTFEN ISLEMIN BITMESINI BEKLEYINIZ...!")
                sw.WriteLine("ECHO Toplam Gonderilecek Urun Sayisi :" & sayi & "")
                sw.WriteLine("C:")
                sw.WriteLine("cd\entry01")
                sw.WriteLine("C:\entry01\ENTRYIBM.EXE 7 2 2 plu.txt plu.err")
                sw.WriteLine("type urun.err")
                sw.Close()
                Process.Start("c:\entry01\entry.bat")
            End If
        End If
    End Sub
    Public Sub Entry_secili_VEGA(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String, ByVal sPort As String)
        'Dim dlg As New WaitDlgFrm("Entry Stok Dosyasý Oluþturuluyor...")
        dosyaolustur_IBMEntry_Vega(sPath, sFile, sFiyatTipi, sGramaj)
        'dlg.Close()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            'Process.Start("C:\NEW-YTL\ENTRYIBM.EXE", "7 2 2 C:\urun.yaz c:\urun.err")
            'Dim z As String = "c:\entry01\entry.bat" 'SAVE.FileName.ToString
            'Dim DOSYA As New FileInfo(z)
            'If DOSYA.Exists Then
            '    DOSYA.Delete()
            'End If
            'Dim sw As StreamWriter = File.AppendText(z)
            'sw.WriteLine("@echo off")
            'sw.WriteLine("ECHO LUTFEN YAZARKASANIZI KONTROL EDINIZ...!")
            'sw.WriteLine("ECHO LUTFEN ISLEMIN BITMESINI BEKLEYINIZ...!")
            'sw.WriteLine("ECHO Toplam Gonderilecek Urun Sayisi :" & sayi & "")
            'sw.WriteLine("C:")
            'sw.WriteLine("cd\entry01")
            'sw.WriteLine("C:\entry01\ENTRYIBM.EXE 7 " & port & " 1 c:\entry01\plu.txt c:\entry01\plu.err")
            'sw.WriteLine("type c:\entry01\plu.err")
            'sw.WriteLine("c:")
            'sw.WriteLine("cd\entry01")
            'sw.WriteLine("pause")
            'sw.Close()
            'Process.Start("c:\entry01\entry.bat")
            'port = Nothing
            Dim objProcess As System.Diagnostics.Process
            objProcess = New System.Diagnostics.Process()
            objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            objProcess.StartInfo.FileName = "C:\entry01\ENTRYIBM.EXE"
            objProcess.StartInfo.Arguments = "7 " & sPort & " 1 " & sPath & ":" & sFile & " c:\entry01\plu.err"
            Try
                objProcess.Start()
                objProcess.WaitForExit()
                objProcess.Close()
            Catch ex As Exception
                XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
            End Try
            ' Process.Start("c:\entry01\Econnect.exe", "SEND " & sPort & " c:\entry01\plu.txt").WaitForExit()
            sPort = Nothing
        End If
    End Sub
    Public Sub HUGIN425TX_secili(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String, ByVal sPort As String)
        'Dim dlg As New WaitDlgFrm("Hugin Stok Dosyasý Oluþturuluyor...")
        dosyaolustur_HUGIN425TX(sPath, sFile, sFiyatTipi, sGramaj)
        'dlg.Close()
        'If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?" & vbCrLf & "Toplam Gonderilecek Urun Sayisi :" & sayi & "", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
        'Dim objProcess As System.Diagnostics.Process
        'objProcess = New System.Diagnostics.Process()
        'objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        'objProcess.StartInfo.FileName = "c:\entry01\Econnect.exe"
        'objProcess.StartInfo.Arguments = "SEND " & sPort & " " & sPath & ":" & sFile & ""
        'Try
        '    objProcess.Start()
        '    objProcess.WaitForExit()
        '    objProcess.Close()
        'Catch ex As Exception
        '    DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
        'End Try
        '' Process.Start("c:\entry01\Econnect.exe", "SEND " & sPort & " c:\entry01\plu.txt").WaitForExit()
        'sPort = Nothing
        'End If
    End Sub
    Public Sub Entry_secili_entry01(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String, ByVal sPort As String)
        'Dim dlg As New WaitDlgFrm("Entry Stok Dosyasý Oluþturuluyor...")
        dosyaolustur_IBMEntry_entry01(sPath, sFile, sFiyatTipi, sGramaj)
        'dlg.Close()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?" & vbCrLf & "Toplam Gonderilecek Urun Sayisi :" & sayi & "", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim objProcess As System.Diagnostics.Process
            objProcess = New System.Diagnostics.Process()
            objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            objProcess.StartInfo.FileName = "c:\entry01\Econnect.exe"
            objProcess.StartInfo.Arguments = "SEND " & sPort & " " & sPath & ":" & sFile & ""
            Try
                objProcess.Start()
                objProcess.WaitForExit()
                objProcess.Close()
            Catch ex As Exception
                XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
            End Try
            ' Process.Start("c:\entry01\Econnect.exe", "SEND " & sPort & " c:\entry01\plu.txt").WaitForExit()
            sPort = Nothing
        End If
    End Sub
    Public Sub Entry_secili_mdb(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String, ByVal sPort As String)
        'Dim dlg As New WaitDlgFrm("Entry Stok Dosyasý Oluþturuluyor..." & vbTab & "Entry01.mdb")
        dosyaolustur_IBMEntry_mdb(sPath, sFile, sFiyatTipi, sGramaj)
        'dlg.Close()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?" & vbCrLf & "Toplam Gonderilecek Urun Sayisi :" & sayi & "", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim objProcess As System.Diagnostics.Process
            objProcess = New System.Diagnostics.Process()
            objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            objProcess.StartInfo.FileName = "C:\entry01\entry01.exe"
            objProcess.StartInfo.Arguments = ""
            Try
                objProcess.Start()
                'objProcess.WaitForExit()
                'objProcess.Close()
            Catch ex As Exception
                XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
            End Try
            ' Process.Start("c:\entry01\Econnect.exe", "SEND " & sPort & " c:\entry01\plu.txt").WaitForExit()
            sPort = Nothing
        End If
    End Sub
    Public Sub SIEMENS_secili_mdb(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String, ByVal sPort As String)
        'Dim dlg As New WaitDlgFrm("SIEMENS Stok Dosyasý Oluþturuluyor..." & vbTab & "MRKTOFIS.mdb")
        dosyaolustur_IBMEntry_mdb(sPath, sFile, sFiyatTipi, sGramaj)
        'dlg.Close()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?" & vbCrLf & "Toplam Gonderilecek Urun Sayisi :" & sayi & "", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim objProcess As System.Diagnostics.Process
            objProcess = New System.Diagnostics.Process()
            objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            objProcess.StartInfo.FileName = "C:\entry01\entry01.exe"
            objProcess.StartInfo.Arguments = ""
            Try
                objProcess.Start()
                'objProcess.WaitForExit()
                'objProcess.Close()
            Catch ex As Exception
                XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
            End Try
            ' Process.Start("c:\entry01\Econnect.exe", "SEND " & sPort & " c:\entry01\plu.txt").WaitForExit()
            sPort = Nothing
        End If
    End Sub
    Public Sub NCR_secili()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            'Dim dlg As New WaitDlgFrm("NCR Pos Stok Dosyasý Oluþturuluyor...")
            dosyaolusturNCR()
            'dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Sub formula7400_sayim_secili(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarý Terminale Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dlg As New WaitDlgFrm("Formula 7400 Stok Dosyasý Oluþturuluyor...")
            dosyaolustur_sayim(sPath, sFile, sFiyatTipi, sGramaj)
            dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Sub psc_falcon_secili(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarý Terminale Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dlg As New WaitDlgFrm("Pcs Falcon El terminali Stok Dosyasý Oluþturuluyor...")
            dosyaolustur_sayim_PSC(sPath, sFile, sFiyatTipi, sGramaj)
            dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Sub NCR_tumu(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        If XtraMessageBox.Show(Sorgu_sDil("Sisteme Kayýtlý Tüm Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            kod1 = ""
            kod2 = ""
            kod3 = ""
            kod4 = ""
            kod5 = ""
            stokkriter = "Tüm Stoklar"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            'Dim dlg As New WaitDlgFrm("NCR Pos Stok Dosyasý Oluþturuluyor...")
            'dlg.Refresh()
            kriterkontrol()
            dataset1 = sorgu_inter(sFiyat1, sFiyat2, sFiyat3, sFiyatTipi)
            dosyaolusturNCR()
            'dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
        End If
    End Sub
    Public Sub BusinessMobile_cariler(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        If XtraMessageBox.Show("Sisteme Kayýtlý Cari Kayýtlarýný Mobil Cihaza Göndermek Ýstediðinize Emin misiniz..?", "Ýnter Pos Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = MsgBoxResult.Yes Then
            'Dim dlg As New WaitDlgFrm("Ýnter Pos Cari Dosyasý Oluþturuluyor...")
            dosyaolustur_BusinessMobile_cariler(sPath, sFile, sFiyatTipi)
            'dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Cari Kayýt Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Sub BusinessMobile_TXT_tumu(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        If XtraMessageBox.Show(Sorgu_sDil("Sisteme Kayýtlý Tüm Stoklarý Mobile Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            kod1 = ""
            kod2 = ""
            kod3 = ""
            kod4 = ""
            kod5 = ""
            stokkriter = "Tüm Stoklar"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            'Dim dlg As New WaitDlgFrm("BusinessMobile Pos Stok Dosyasý Oluþturuluyor...")
            'dlg.Refresh()
            kriterkontrol()
            dataset1 = sorgu_inter("", sFiyatTipi, "", True)
            dosyaolustur_BusinessMobile_txt(sPath, sFile, sFiyatTipi, sGramaj)
            'dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
        End If
    End Sub
    Public Sub BusinessMobile_TXT_secili(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Tüm Stoklarý Mobil Cihaza Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            'Dim dlg As New WaitDlgFrm("BusinessMobile Pos Stok Dosyasý Oluþturuluyor...")
            dosyaolustur_BusinessMobile_txt(sPath, sFile, sFiyatTipi, sGramaj)
            'dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Sub SambaPos_musteriler(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String, ByVal sKasa As String)
        If XtraMessageBox.Show("Sisteme Kayýtlý Müþteri Kayýtlarýný SambaPosa Göndermek Ýstediðinize Emin misiniz..?", "Ýnter Pos Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = MsgBoxResult.Yes Then
            'Dim dlg As New WaitDlgFrm("Ýnter Pos Cari Dosyasý Oluþturuluyor...")
            dosyaolustur_SambaPos_musteriler(sPath, sFile, sFiyatTipi, sKasa)
            'dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Müþteri Kayýt Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Sub SambaPos_Stoklar_tumu(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        If XtraMessageBox.Show(Sorgu_sDil("Sisteme Kayýtlý Tüm Stoklarý SambaPosa Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            kod1 = ""
            kod2 = ""
            kod3 = ""
            kod4 = ""
            kod5 = ""
            stokkriter = "Tüm Stoklar"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            'Dim dlg As New WaitDlgFrm("BusinessMobile Pos Stok Dosyasý Oluþturuluyor...")
            'dlg.Refresh()
            kriterkontrol()
            dataset1 = sorgu_inter("", sFiyatTipi, "", True)
            dosyaolustur_SambaPos_Stoklar(sPath, sFile, sFiyatTipi, sGramaj)
            'dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
        End If
    End Sub
    Public Sub SambaPos_Stoklar_secili(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Tüm Stoklarý SambaPosa Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            dosyaolustur_SambaPos_Stoklar(sPath, sFile, sFiyatTipi, sGramaj)
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Sub SIEMENS_TXT_tumu(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        If XtraMessageBox.Show(Sorgu_sDil("Sisteme Kayýtlý Tüm Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            kod1 = ""
            kod2 = ""
            kod3 = ""
            kod4 = ""
            kod5 = ""
            stokkriter = "Tüm Stoklar"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            'Dim dlg As New WaitDlgFrm("SIEMENS Pos Stok Dosyasý Oluþturuluyor...")
            'dlg.Refresh()
            kriterkontrol()
            dataset1 = sorgu_inter(sFiyat1, sFiyat2, sFiyat3, sFiyatTipi)
            dosyaolustur_SIEMENS_txt(sPath, sFile, sFiyatTipi, sGramaj)
            'dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
        End If
    End Sub
    Public Sub SIEMENS_TXT_secili(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Tüm Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            'Dim dlg As New WaitDlgFrm("SIEMENS Pos Stok Dosyasý Oluþturuluyor...")
            dosyaolustur_SIEMENS_txt(sPath, sFile, sFiyatTipi, sGramaj)
            'dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Sub SIEMENS_MDB_tumu(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        If XtraMessageBox.Show(Sorgu_sDil("Sisteme Kayýtlý Tüm Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            kod1 = ""
            kod2 = ""
            kod3 = ""
            kod4 = ""
            kod5 = ""
            stokkriter = "Tüm Stoklar"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            'Dim dlg As New WaitDlgFrm("SIEMENS Pos Stok Dosyasý Oluþturuluyor...")
            'dlg.Refresh()
            kriterkontrol()
            dataset1 = sorgu_inter(sFiyat1, sFiyat2, sFiyat3, sFiyatTipi)
            dosyaolustur_SIEMENS_mdb(sPath, sFile, sFiyatTipi, sGramaj)
            'dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
        End If
    End Sub
    Public Sub Ncr_TXT_tumu(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        If XtraMessageBox.Show(Sorgu_sDil("Sisteme Kayýtlý Tüm Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            kod1 = ""
            kod2 = ""
            kod3 = ""
            kod4 = ""
            kod5 = ""
            stokkriter = "Tüm Stoklar"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            'Dim dlg As New WaitDlgFrm("Ncr Pos Stok Dosyasý Oluþturuluyor...")
            'dlg.Refresh()
            kriterkontrol()
            dataset1 = sorgu_inter(sFiyat1, sFiyat2, sFiyat3, sFiyatTipi)
            dosyaolustur_Ncr_txt(sPath, sFile, sFiyatTipi, sGramaj)
            'dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
        End If
    End Sub
    Public Sub Ncr_TXT_secili(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Tüm Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            'Dim dlg As New WaitDlgFrm("Ncr Pos Stok Dosyasý Oluþturuluyor...")
            dosyaolustur_Ncr_txt(sPath, sFile, sFiyatTipi, sGramaj)
            'dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Sub sayim_tumu(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        If XtraMessageBox.Show(Sorgu_sDil("Sisteme Kayýtlý Tüm Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            kod1 = ""
            kod2 = ""
            kod3 = ""
            kod4 = ""
            kod5 = ""
            stokkriter = "Tüm Stoklar"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            'Dim dlg As New WaitDlgFrm("Sayým Cihazý Stok Dosyasý Oluþturuluyor...")
            'dlg.Refresh()
            kriterkontrol()
            dataset1 = sorgu_inter(sFiyat1, sFiyat2, sFiyat3, sFiyatTipi)
            dosyaolustur_sayim(sPath, sFile, sFiyatTipi, sGramaj)
            'dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
        End If
    End Sub
    Public Sub IBMgenius_tumu(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        If XtraMessageBox.Show(Sorgu_sDil("Sisteme Kayýtlý Tüm Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            kod1 = ""
            kod2 = ""
            kod3 = ""
            kod4 = ""
            kod5 = ""
            ''sFile = "gncpluf.gtf"
            stokkriter = "Tüm Stoklar"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            'Dim dlg As New WaitDlgFrm("IBM Pos Stok Dosyasý Oluþturuluyor...")
            'dlg.Refresh()
            kriterkontrol()
            dataset1 = sorgu_inter(sFiyat1, sFiyat2, sFiyat3, sFiyatTipi)
            dosyaolusturIBM(sPath, sFile, sFiyatTipi, sGramaj)
            'dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
        End If
    End Sub
    Public Sub IBMgenius_Degisen(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        If XtraMessageBox.Show(Sorgu_sDil("Sisteme Kayýtlý Tüm Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            stokkodu = ""
            malincinsi = ""
            barkod = ""
            kod1 = ""
            kod2 = ""
            kod3 = ""
            kod4 = ""
            kod5 = ""
            ''sFile = "gncpluf.gtf"
            stokkriter = "Deðiþen Stoklar"
            secsirala = "BARKOD"
            secfiyat = "1. Satýþ Fiyatý"
            'Dim dlg As New WaitDlgFrm("IBM Pos Stok Dosyasý Oluþturuluyor...")
            'dlg.Refresh()
            kriterkontrol()
            dataset1 = sorgu_Degisen(sFiyat1, sFiyat2, sFiyat3, sFiyatTipi)
            dosyaolusturIBM(sPath, sFile, sFiyatTipi, sGramaj)
            'dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
        End If
    End Sub
    Public Sub IBMgenius_secili(ByVal sPath As String, ByVal sFile As String, ByVal sFiyatTipi As String, ByVal sGramaj As String)
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Tüm Stoklarý Kasaya Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            'Dim dlg As New WaitDlgFrm("IBM Pos Stok Dosyasý Oluþturuluyor...")
            dosyaolusturIBM(sPath, sFile, sFiyatTipi, sGramaj)
            'dlg.Close()
            XtraMessageBox.Show(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : ", sDil) & sayi, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Sub SHARP_yeni(ByVal sender As String, ByVal parametre1 As String, ByVal parametre2 As String, ByVal sFile As String, ByVal sFiyatTipi As Integer, ByVal sGramaj As String, ByVal sAdetli As String)
        dosyaolusturSHARP_yeni(sender, parametre1, parametre2, sFile, sFiyatTipi, sGramaj, sAdetli)
    End Sub
    Public Sub SHARP_fiyat(ByVal sender As String, ByVal parametre1 As String, ByVal parametre2 As String, ByVal sFile As String, ByVal sFiyatTipi As Integer, ByVal sGramaj As String, ByVal sAdetli As String)
        dosyaolusturSHARP_fiyat(sender, parametre1, parametre2, sFile, sFiyatTipi, sGramaj, sAdetli)
    End Sub
    Public Sub SHARP_plu(ByVal sender As String, ByVal parametre1 As String, ByVal parametre2 As String, ByVal sFile As String, ByVal sFiyatTipi As Integer, ByVal sGramaj As String, ByVal sAdetli As String)
        dosyaolusturSHARP_plu(sender, parametre1, parametre2, sFile, sFiyatTipi, sGramaj, sAdetli)
    End Sub
    Public Sub SHARP_Ciro_Genel(ByVal dosya As String)
        Dim z = (dosya) 'OPEN.FileName.ToString
        Dim sr As StreamReader = File.OpenText(z)
        Dim sk As StreamReader = File.OpenText(z)
        Dim satir As String
        Dim satis As String
        Dim fis
        Dim fatura
        Dim iptal
        Dim aratoplam As Decimal
        Dim faturakdv As Decimal
        Dim indirim As Decimal
        Dim nakit As Decimal
        Dim nakitfis
        Dim kredi1 As Decimal
        Dim kredi1fis
        Dim kredi2 As Decimal
        Dim kredi2fis
        Dim belgeiptal As Integer = 0
        Dim belgeiptaltutar As Decimal = 0
        Dim ortalamaciro
        's = sr.Read
        Dim sayi As Integer
        sayi = 0
        fis = 0
        fatura = 0
        iptal = 0
        faturakdv = 0
        kredi1 = 0
        kredi2 = 0
        Do While sk.Peek() > -1
            sayi += 1
            satir = sk.ReadLine
            If sayi >= 2 Then
                satis = Trim(satir.Substring(0, 4))
                If satis = "3001" Then
                    aratoplam = CType(Trim(satir.Substring(5, 11)), Decimal)
                    aratoplam = aratoplam / 100
                ElseIf satis = "4400" Then
                    belgeiptaltutar = CType(Trim(satir.Substring(5, 11)), Decimal)
                    belgeiptaltutar = belgeiptaltutar / 100
                    belgeiptal = CType(Trim(satir.Substring(16, 6)), Decimal)
                ElseIf satis = "5000" Then
                    fis = CType(Trim(satir.Substring(16, 6)), Decimal)
                ElseIf satis = "7001" Then
                    nakit = CType(Trim(satir.Substring(5, 11)), Decimal)
                    nakit = nakit / 100
                    nakitfis = CType(Trim(satir.Substring(16, 6)), Decimal)
                ElseIf satis = "9001" Then
                    kredi1 = CType(Trim(satir.Substring(5, 11)), Decimal)
                    kredi1 = kredi1 / 100
                    kredi1fis = CType(Trim(satir.Substring(16, 6)), Decimal)
                ElseIf satis = "9002" Then
                    kredi2 = CType(Trim(satir.Substring(5, 11)), Decimal)
                    kredi2 = kredi2 / 100
                    kredi2fis = CType(Trim(satir.Substring(16, 6)), Decimal)
                End If
            End If
        Loop
        ortalamaciro = aratoplam / ((CType(fis, Integer)))
        XtraMessageBox.Show(Sorgu_sDil("Fiþ Sayýsý        ", sDil) & vbTab & vbTab & fis & vbCrLf & Sorgu_sDil("Fatura Sayýsý ", sDil) & vbTab & vbTab & fatura & vbCrLf & Sorgu_sDil("Ýptal Edilen Belge Sayýsý", sDil) & vbTab & belgeiptal & vbCrLf & Sorgu_sDil("Ýptal Edilen Belge Tutarý ", sDil) & vbTab & FormatCurrency(belgeiptaltutar, 2) & vbCrLf & "==============================" & vbCrLf & Sorgu_sDil("Toplam Ciro ", sDil) & vbTab & vbTab & FormatCurrency(aratoplam, 2) & vbCrLf & Sorgu_sDil("Toplam Ýndirim  ", sDil) & vbTab & vbTab & FormatCurrency(indirim, 2) & vbCrLf & Sorgu_sDil("Ortalama Ciro ", sDil) & vbTab & vbTab & FormatCurrency(ortalamaciro, 2) & vbCrLf & "==============================" & vbCrLf & Sorgu_sDil("Nakit Satýþ", sDil) & vbTab & vbTab & FormatCurrency(nakit, 2) & vbCrLf & Sorgu_sDil("Kredili Satýþ 1", sDil) & vbTab & vbTab & FormatCurrency(kredi1, 2) & vbCrLf & Sorgu_sDil("Kredili Satýþ 2", sDil) & vbTab & vbTab & FormatCurrency(kredi2, 2), "SHARP ER A 495T CÝRO RAPORU", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub SHARP_Ciro_Departman(ByVal dosya As String)
        Dim z = (dosya) 'OPEN.FileName.ToString
        Dim sr As StreamReader = File.OpenText(z)
        Dim sk As StreamReader = File.OpenText(z)
        Dim satir As String
        'genel departman açýklama
        Dim departman
        Dim departmansayisi As Integer = 0
        Dim departmanaciklama As String
        Dim departmantutar
        Dim tutar As Decimal
        Dim departmanmiktar
        Dim fismiktar As Integer
        Dim aciklama
        's = sr.Read
        aciklama = ""
        Dim sayi As Integer
        sayi = 0
        Do While sk.Peek() > -1
            sayi += 1
            satir = sk.ReadLine
            If sayi >= 3 Then
                departman = Trim(satir.Substring(0, 2))
                departmansayisi += 1
                departmanaciklama = Trim(satir.Substring(29, 16))
                departmantutar = Trim(satir.Substring(46, 11))
                departmantutar = departmantutar / 100
                tutar = tutar + CType(departmantutar, Decimal)
                departmanmiktar = Trim(satir.Substring(57, 5))
                fismiktar = fismiktar + CType(departmanmiktar, Integer)
                aciklama += "No : " & departman & " " & "--> : " & departmanaciklama & vbTab & vbTab & "Tutar : " & FormatCurrency(departmantutar, 2) & vbTab & vbTab & vbTab & "S. Adedi   : " & FormatNumber(departmanmiktar, 0) & vbCrLf
            End If
        Loop
        'ortalamaciro = aratoplam / ((CType(fis, Integer)))
        'MsgBox(Sorgu_sDil("Fiþ Sayýsý        " & vbTab & vbTab & fis & vbCrLf & "Fatura Sayýsý " & vbTab & vbTab & fatura & vbCrLf & "Ýptal Edilen Belge Sayýsý" & vbTab & belgeiptal & vbCrLf & "Ýptal Edilen Belge Tutarý " & vbTab & FormatCurrency(belgeiptaltutar, 2) & vbCrLf & "==============================" & vbCrLf & "Toplam Ciro " & vbTab & vbTab & FormatCurrency(aratoplam, 2) & vbCrLf & "Toplam Ýndirim  " & vbTab & vbTab & FormatCurrency(indirim, 2) & vbCrLf & "Ortalama Ciro " & vbTab & vbTab & FormatCurrency(ortalamaciro, 2) & vbCrLf & "==============================" & vbCrLf & "Nakit Satýþ" & vbTab & vbTab & FormatCurrency(nakit, 2) & vbCrLf & "Kredili Satýþ 1" & vbTab & vbTab & FormatCurrency(kredi1, 2) & vbCrLf & "Kredili Satýþ 2" & vbTab & vbTab & FormatCurrency(kredi2, 2), MessageBoxIcon.Information, "SHARP ER A 495T CÝRO RAPORU")
        aciklama += "=============================================================" & vbCrLf
        aciklama += "Toplam : " & departmansayisi & "                " & vbTab & vbTab & "Tutar :" & FormatCurrency(tutar, 2) & vbTab & vbTab & vbTab & "S. Toplamý :" & FormatNumber(fismiktar, 0) & vbCrLf
        XtraMessageBox.Show(aciklama, "SHARP ER A 495T DEPARTMAN SATIÞ RAPORU", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub HUGIN_satisoku_EAN(ByVal dosya As String, ByVal kasa As String, ByVal sMagaza As String, ByVal nStatus As Integer, ByVal sKullanici As String, ByVal nIslem As Integer, ByVal sGramaj As String)
        status = False
        Dim z = (dosya)
        Dim sr As StreamReader = File.OpenText(z)
        Dim sk As StreamReader = File.OpenText(z)
        Dim s As String
        Dim satir As String
        Dim nAlisVerisID As String = ""
        Dim sSatir As String = ""
        Dim sSatisSatir As String = ""
        Dim nMusteriID As String = 0
        Dim sKasaNo As String = ""
        Dim lFisNo As Integer = 0
        Dim sFisTipi As String = "P"
        Dim nFisGC As Integer = 0
        Dim dteFisTarihi As String = "01/01/1900"
        Dim dteKayitTarihi As String = "01/01/1900"
        Dim sKasiyerRumuzu As String = ""
        Dim nGirisCikis As Integer = 3
        Dim nStokID As Integer = 0
        Dim sKodu As String = ""
        Dim sBarkod As String = ""
        Dim sAciklama As String = ""
        Dim lMiktar As String = ""
        Dim lFiyat As String = ""
        Dim lTutar As Decimal = 0
        Dim lToplamTutar As Decimal = 0
        Dim lBrutFiyat As Decimal = 0
        Dim lBrutTutar As Decimal = 0
        Dim sIskontoTipi As String = "TOP"
        Dim nIskontoYuzdesi As Decimal = 0
        Dim lIskontoTutari As Decimal = 0
        Dim lNetTutar As Decimal = 0
        Dim sKdvTipi As String = "01"
        Dim sOdemeKodu As String = ""
        Dim lOdemeTutar As Decimal = 0
        Dim bKapali As Boolean = True
        Dim bBarkod As Boolean = False
        Dim bToplam As Boolean = False
        Dim nKdvOrani As Decimal = 0
        Dim miktar1 As String
        Dim miktar2 As String
        's = sr.Read
        Dim sayi As Integer
        Dim nSatirSayi As Integer = 0
        Dim oku As Byte()
        sayi = 0
        Do While sk.Peek() > -1
            satir = sk.ReadLine
            Try
                'MsgBox(Len(satir))
                If Len(satir) = 80 Then
                    sayi += 1
                    nSatirSayi += 1
                End If
            Catch ex As Exception
                XtraMessageBox.Show(dosya.ToString & Sorgu_sDil("Isimli Dosyada ", sDil) & nSatirSayi & Sorgu_sDil(" Kayýtlý Satýr Hatalý,Lütfen Kontrol Ediniz", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Question)
            End Try
        Loop
        sk.Close()
        Dim dlg As New WaitDlgFrm("Toplam Satýr :" & sayi)
        sayi = 0
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        Do While sr.Peek() > -1
            sayi += 1
            s = sr.ReadLine()
            Try
                If Len(s) = 80 Then
                    oku = System.Text.Encoding.UTF7.GetBytes(s)
                    s = System.Text.Encoding.UTF7.GetString(oku)
                    'büyük harf
                    s = Replace(s, "€", "Ç")
                    s = Replace(s, "¦", "Ð")
                    s = Replace(s, "˜", "Ý")
                    s = Replace(s, "ž", "Þ")
                    s = Replace(s, "š", "Ü")
                    s = Replace(s, "™", "Ö")
                    'küçük harf
                    s = Replace(s, "‡", "ç")
                    s = Replace(s, "§", "ð")
                    s = Replace(s, "i", "i")
                    s = Replace(s, "Ÿ", "þ")
                    s = Replace(s, "", "ü")
                    lFisNo = 1 'Trim(s.Substring(17, 6))
                    nAlisVerisID = "D" & lFisNo
                    sKasaNo = kasa
                    dteFisTarihi = Today
                    dteKayitTarihi = Now
                    sSatisSatir = sayi
                    'nStokID = Trim(s.Substring(30, 20))
                    'nStokID = Trim(s.Substring(35, 6))
                    Dim plu As String = s.Substring(19, 14)
                    'MsgBox(Trim(plu.Substring(0, 3)))
                    Dim plucod = sGramaj
                    If Trim(plu.Substring(0, 2)) <> plucod Then
                        'MsgBox(plu & vbTab & "Uzunluk: " & Len(plu))
                        sBarkod = plu.Substring(0, 13)
                    ElseIf Trim(plu.Substring(0, 2)) = plucod Then
                        sBarkod = plu.Substring(2, 5)
                    End If
                    nStokID = sorgu_nStokID(sBarkod)
                    nStokID = Microsoft.VisualBasic.Right(nStokID.ToString, 6)
                    sKodu = sBarkod
                    sAciklama = Trim(s.Substring(0, 18))
                    miktar1 = Trim(s.Substring(37, 8))
                    miktar2 = Trim(s.Substring(45, 2))
                    lMiktar = miktar1
                    lMiktar += "."
                    lMiktar += miktar2
                    lFiyat = Trim(s.Substring(59, 8))
                    lFiyat += "."
                    lFiyat += Trim(s.Substring(67, 2))
                    lMiktar = CType(lMiktar, Decimal)
                    lFiyat = CType(lFiyat, Decimal) / lMiktar
                    lTutar = CType(lMiktar, Decimal) * CType(lFiyat, Decimal)
                    'lTutar = Trim(s.Substring(60, 12))
                    'lTutar = lTutar / 100
                    'lFiyat = lTutar / lMiktar
                    lBrutFiyat = lFiyat
                    lBrutTutar = lTutar
                    nGirisCikis = 3
                    lNetTutar += lBrutTutar
                    nKdvOrani = 0
                    sKdvTipi = Trim(s.Substring(34, 2))
                    sMagaza = sMagaza
                    sSatir = sayi
                    sFisTipi = "P"
                    'intersatiskayit_baslik_degistir(sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sKasiyerRumuzu, sKasaNo, nStatus, sKullanici, bToplam, bKapali)
                    intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, nStokID, sKodu, sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, "", 0, lMiktar, lBrutFiyat, lBrutTutar, "", 0, 0, lFiyat, lTutar, sKdvTipi, nKdvOrani, 0, dteKayitTarihi, nStatus, sKullanici, bToplam)
                End If
            Catch
                XtraMessageBox.Show(dosya.ToString & Sorgu_sDil("Ýsimli Dosyada ", sDil) & sayi & Sorgu_sDil(" Kayýtlý Satýr Hatalý,Lütfen Kontrol Ediniz", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Question)
            End Try
        Loop
        sr.Close()
        dlg.Close()
        sOdemeKodu = "N"
        lOdemeTutar = lNetTutar
        nGirisCikis = 9
        intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, sOdemeKodu, lOdemeTutar, 0, 0, 0, "", 0, 0, 0, 0, "", 0, lNetTutar, dteKayitTarihi, nStatus, sKullanici, bToplam)
        nGirisCikis = 11
        bKapali = True
        intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, "", 0, 0, 0, 0, "", 0, 0, 0, 0, "", 0, lNetTutar, dteKayitTarihi, nStatus, sKullanici, bToplam, bKapali)
        nGirisCikis = 3
        lNetTutar = 0
    End Sub
    Public Sub SHARP_satisoku_EAN(ByVal dosya As String, ByVal kasa As String, ByVal sMagaza As String, ByVal nStatus As Integer, ByVal sKullanici As String, ByVal nIslem As Integer, ByVal sGramaj As String)
        status = False
        Dim z = (dosya)
        Dim sr As StreamReader = File.OpenText(z)
        Dim sk As StreamReader = File.OpenText(z)
        Dim s As String
        Dim satir As String
        Dim nAlisVerisID As String = ""
        Dim sSatir As String = ""
        Dim sSatisSatir As String = ""
        Dim nMusteriID As String = 0
        Dim sKasaNo As String = ""
        Dim lFisNo As Integer = 0
        Dim sFisTipi As String = "P"
        Dim nFisGC As Integer = 0
        Dim dteFisTarihi As String = "01/01/1900"
        Dim dteKayitTarihi As String = "01/01/1900"
        Dim sKasiyerRumuzu As String = ""
        Dim nGirisCikis As Integer = 3
        Dim nStokID As Integer = 0
        Dim sKodu As String = ""
        Dim sBarkod As String = ""
        Dim sAciklama As String = ""
        Dim lMiktar As String = ""
        Dim lFiyat As String = ""
        Dim lTutar As Decimal = 0
        Dim lToplamTutar As Decimal = 0
        Dim lBrutFiyat As Decimal = 0
        Dim lBrutTutar As Decimal = 0
        Dim sIskontoTipi As String = "TOP"
        Dim nIskontoYuzdesi As Decimal = 0
        Dim lIskontoTutari As Decimal = 0
        Dim lNetTutar As Decimal = 0
        Dim sKdvTipi As String = "01"
        Dim sOdemeKodu As String = "NAK"
        Dim lOdemeTutar As Decimal = 0
        Dim bKapali As Boolean = True
        Dim bBarkod As Boolean = False
        Dim bToplam As Boolean = False
        Dim nKdvOrani As Decimal = 0
        Dim miktar1 As String
        Dim miktar2 As String
        's = sr.Read
        Dim sayi As Integer
        Dim nSatirSayi As Integer = 0
        Dim oku As Byte()
        sayi = 0
        Do While sk.Peek() > -1
            satir = sk.ReadLine
            Try
                If Len(satir) = 82 Then
                    sayi += 1
                    nSatirSayi += 1
                End If
            Catch ex As Exception
                XtraMessageBox.Show(dosya.ToString & Sorgu_sDil("Isimli Dosyada ", sDil) & nSatirSayi & Sorgu_sDil(" Kayýtlý Satýr Hatalý,Lütfen Kontrol Ediniz", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Question)
            End Try
        Loop
        sk.Close()
        Dim dlg As New WaitDlgFrm("Toplam Satýr :" & sayi)
        sayi = 0
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        Do While sr.Peek() > -1
            sayi += 1
            s = sr.ReadLine()
            Try
                If Len(s) = 82 Then
                    oku = System.Text.Encoding.UTF7.GetBytes(s)
                    s = System.Text.Encoding.UTF7.GetString(oku)
                    'büyük harf
                    s = Replace(s, "€", "Ç")
                    s = Replace(s, "¦", "Ð")
                    s = Replace(s, "˜", "Ý")
                    s = Replace(s, "ž", "Þ")
                    s = Replace(s, "š", "Ü")
                    s = Replace(s, "™", "Ö")
                    'küçük harf
                    s = Replace(s, "‡", "ç")
                    s = Replace(s, "§", "ð")
                    s = Replace(s, "i", "i")
                    s = Replace(s, "Ÿ", "þ")
                    s = Replace(s, "", "ü")
                    lFisNo = 1 'Trim(s.Substring(17, 6))
                    nAlisVerisID = "D" & lFisNo
                    sKasaNo = kasa
                    dteFisTarihi = Today
                    dteKayitTarihi = Now
                    sSatisSatir = sayi
                    'nStokID = Trim(s.Substring(30, 20))
                    'nStokID = Trim(s.Substring(35, 6))
                    Dim plu As String = Trim(s.Substring(0, 14))
                    'MsgBox(Trim(plu.Substring(0, 3)))
                    Dim plucod = sGramaj
                    If Trim(plu.Substring(0, 3)) <> plucod And Trim(plu.Substring(0, 3)) <> 100 And Trim(plu.Substring(0, 3)) <> 500 Then
                        sBarkod = Trim(plu.Substring(1, 13))
                    ElseIf Trim(plu.Substring(0, 3)) = plucod Then
                        sBarkod = Trim(plu.Substring(3, 5))
                    ElseIf Trim(plu.Substring(0, 3)) = 5 Then
                        sBarkod = Trim(plu.Substring(7, 6))
                    ElseIf Trim(plu.Substring(0, 3)) = 100 Then
                        sBarkod = Trim(plu.Substring(6, 8))
                    ElseIf Trim(plu.Substring(0, 3)) = 4 Then
                        sBarkod = Trim(plu.Substring(2, 11))
                    End If
                    nStokID = sorgu_nStokID(sBarkod)
                    nStokID = Microsoft.VisualBasic.Right(nStokID.ToString, 6)
                    sKodu = sBarkod
                    sAciklama = Trim(s.Substring(44, 16))
                    miktar1 = Trim(s.Substring(72, 5))
                    miktar2 = Trim(s.Substring(77, 3))
                    lMiktar = miktar1
                    lMiktar += "."
                    lMiktar += miktar2
                    lFiyat = Trim(s.Substring(62, 8))
                    lFiyat += "."
                    lFiyat += Trim(s.Substring(70, 2))
                    lMiktar = CType(lMiktar, Decimal)
                    lFiyat = CType(lFiyat, Decimal) / lMiktar
                    lTutar = CType(lMiktar, Decimal) * CType(lFiyat, Decimal)
                    'lTutar = Trim(s.Substring(60, 12))
                    'lTutar = lTutar / 100
                    'lFiyat = lTutar / lMiktar
                    lBrutFiyat = lFiyat
                    lBrutTutar = lTutar
                    nGirisCikis = 3
                    lNetTutar += lBrutTutar
                    nKdvOrani = 0
                    sKdvTipi = Trim(s.Substring(15, 2))
                    sMagaza = sMagaza
                    sSatir = sayi
                    sFisTipi = "P"
                    'intersatiskayit_baslik_degistir(sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sKasiyerRumuzu, sKasaNo, nStatus, sKullanici, bToplam, bKapali)
                    intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, nStokID, sKodu, sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, "", 0, lMiktar, lBrutFiyat, lBrutTutar, "", 0, 0, lFiyat, lTutar, sKdvTipi, nKdvOrani, 0, dteKayitTarihi, nStatus, sKullanici, bToplam)
                End If
            Catch
                XtraMessageBox.Show(dosya.ToString & Sorgu_sDil("Ýsimli Dosyada ", sDil) & sayi & Sorgu_sDil(" Kayýtlý Satýr Hatalý,Lütfen Kontrol Ediniz", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Question)
            End Try
        Loop
        sr.Close()
        dlg.Close()
        sOdemeKodu = "N"
        lOdemeTutar = lNetTutar
        nGirisCikis = 9
        intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, sOdemeKodu, lOdemeTutar, 0, 0, 0, "", 0, 0, 0, 0, "", 0, lNetTutar, dteKayitTarihi, nStatus, sKullanici, bToplam)
        nGirisCikis = 11
        bKapali = True
        intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, "", 0, 0, 0, 0, "", 0, 0, 0, 0, "", 0, lNetTutar, dteKayitTarihi, nStatus, sKullanici, bToplam, bKapali)
        nGirisCikis = 3
        lNetTutar = 0
    End Sub
    Public Sub SHARP_satisoku_PLU(ByVal dosya As String, ByVal kasa As String, ByVal sMagaza As String, ByVal nStatus As Integer, ByVal sKullanici As String, ByVal nIslem As Integer, ByVal sGramaj As String)
        status = False
        Dim z = (dosya)
        Dim sr As StreamReader = File.OpenText(z)
        Dim sk As StreamReader = File.OpenText(z)
        Dim s As String
        Dim satir As String
        Dim nAlisVerisID As String = ""
        Dim sSatir As String = ""
        Dim sSatisSatir As String = ""
        Dim nMusteriID As String = 0
        Dim sKasaNo As String = ""
        Dim lFisNo As Integer = 0
        Dim sFisTipi As String = "P"
        Dim nFisGC As Integer = 0
        Dim dteFisTarihi As String = "01/01/1900"
        Dim dteKayitTarihi As String = "01/01/1900"
        Dim sKasiyerRumuzu As String = ""
        Dim nGirisCikis As Integer = 3
        Dim nStokID As Integer = 0
        Dim sKodu As String = ""
        Dim sBarkod As String = ""
        Dim sAciklama As String = ""
        Dim lMiktar As String = ""
        Dim lFiyat As String = ""
        Dim lTutar As Decimal = 0
        Dim lToplamTutar As Decimal = 0
        Dim lBrutFiyat As Decimal = 0
        Dim lBrutTutar As Decimal = 0
        Dim sIskontoTipi As String = "TOP"
        Dim nIskontoYuzdesi As Decimal = 0
        Dim lIskontoTutari As Decimal = 0
        Dim lNetTutar As Decimal = 0
        Dim sKdvTipi As String = "01"
        Dim sOdemeKodu As String = "NAK"
        Dim lOdemeTutar As Decimal = 0
        Dim bKapali As Boolean = True
        Dim bBarkod As Boolean = False
        Dim bToplam As Boolean = False
        Dim nKdvOrani As Decimal = 0
        Dim miktar1 As String
        Dim miktar2 As String
        's = sr.Read
        Dim sayi As Integer
        Dim nSatirSayi As Integer = 0
        Dim oku As Byte()
        sayi = 0
        Do While sk.Peek() > -1
            satir = sk.ReadLine
            Try
                If Len(satir) = 71 Then
                    sayi += 1
                    nSatirSayi += 1
                End If
            Catch ex As Exception
                XtraMessageBox.Show(dosya.ToString & Sorgu_sDil("Isimli Dosyada ", sDil) & nSatirSayi & Sorgu_sDil(" Kayýtlý Satýr Hatalý,Lütfen Kontrol Ediniz", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Question)
            End Try
        Loop
        sk.Close()
        Dim dlg As New WaitDlgFrm("Toplam Satýr :" & sayi)
        sayi = 0
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        Do While sr.Peek() > -1
            sayi += 1
            s = sr.ReadLine()
            Try
                If Len(s) = 71 Then
                    Dim plu As String = Trim(s.Substring(0, 6))
                    If plu < 65 Then
                        oku = System.Text.Encoding.UTF7.GetBytes(s)
                        s = System.Text.Encoding.UTF7.GetString(oku)
                        'büyük harf
                        s = Replace(s, "€", "Ç")
                        s = Replace(s, "¦", "Ð")
                        s = Replace(s, "˜", "Ý")
                        s = Replace(s, "ž", "Þ")
                        s = Replace(s, "š", "Ü")
                        s = Replace(s, "™", "Ö")
                        'küçük harf
                        s = Replace(s, "‡", "ç")
                        s = Replace(s, "§", "ð")
                        s = Replace(s, "i", "i")
                        s = Replace(s, "Ÿ", "þ")
                        s = Replace(s, "", "ü")
                        lFisNo = 2
                        nAlisVerisID = "D" & lFisNo
                        sKasaNo = kasa
                        dteFisTarihi = Today
                        dteKayitTarihi = Now
                        sSatisSatir = sayi
                        'nStokID = Trim(s.Substring(30, 20))
                        'nStokID = Trim(s.Substring(35, 6))
                        'MsgBox(Trim(plu.Substring(0, 3)))
                        'Dim plucod = sGramaj
                        'If Trim(plu.Substring(0, 3)) <> plucod And Trim(plu.Substring(0, 3)) <> 100 And Trim(plu.Substring(0, 3)) <> 500 Then
                        '    sBarkod = Trim(plu.Substring(1, 13))
                        'ElseIf Trim(plu.Substring(0, 3)) = plucod Then
                        '    sBarkod = Trim(plu.Substring(3, 5))
                        'ElseIf Trim(plu.Substring(0, 3)) = 5 Then
                        '    sBarkod = Trim(plu.Substring(7, 6))
                        'ElseIf Trim(plu.Substring(0, 3)) = 100 Then
                        '    sBarkod = Trim(plu.Substring(6, 8))
                        'ElseIf Trim(plu.Substring(0, 3)) = 4 Then
                        '    sBarkod = Trim(plu.Substring(2, 11))
                        'End If
                        sBarkod = plu
                        nStokID = sorgu_nStokID(sBarkod)
                        nStokID = Microsoft.VisualBasic.Right(nStokID.ToString, 6)
                        sKodu = sBarkod
                        sAciklama = Trim(s.Substring(34, 16))
                        miktar1 = Trim(s.Substring(61, 5))
                        miktar2 = Trim(s.Substring(67, 3))
                        lMiktar = miktar1
                        lMiktar += "."
                        lMiktar += miktar2
                        lFiyat = Trim(s.Substring(51, 8))
                        lFiyat += "."
                        lFiyat += Trim(s.Substring(59, 2))
                        lMiktar = CType(lMiktar, Decimal)
                        lFiyat = CType(lFiyat, Decimal) / lMiktar
                        lTutar = CType(lMiktar, Decimal) * CType(lFiyat, Decimal)
                        lBrutFiyat = lFiyat
                        lBrutTutar = lTutar
                        nGirisCikis = 3
                        lNetTutar += lBrutTutar
                        nKdvOrani = 0
                        sKdvTipi = Trim(s.Substring(7, 2))
                        sMagaza = sMagaza
                        sSatir = sayi
                        sFisTipi = "P"
                        'intersatiskayit_baslik_degistir(sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sKasiyerRumuzu, sKasaNo, nStatus, sKullanici, bToplam, bKapali)
                        intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, nStokID, sKodu, sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, "", 0, lMiktar, lBrutFiyat, lBrutTutar, "", 0, 0, lFiyat, lTutar, sKdvTipi, nKdvOrani, 0, dteKayitTarihi, nStatus, sKullanici, bToplam)
                    End If
                End If
            Catch
                XtraMessageBox.Show(dosya.ToString & Sorgu_sDil("Ýsimli Dosyada ", sDil) & sayi & Sorgu_sDil(" Kayýtlý Satýr Hatalý,Lütfen Kontrol Ediniz", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Question)
            End Try
        Loop
        sr.Close()
        dlg.Close()
        sOdemeKodu = "N"
        lOdemeTutar = lNetTutar
        nGirisCikis = 9
        intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, sOdemeKodu, lOdemeTutar, 0, 0, 0, "", 0, 0, 0, 0, "", 0, lNetTutar, dteKayitTarihi, nStatus, sKullanici, bToplam)
        nGirisCikis = 11
        bKapali = True
        intersatiskayit(nAlisVerisID, sSatir, sFisTipi, nFisGC, dteFisTarihi, lFisNo, nMusteriID, sMagaza, nGirisCikis, 0, "", sKasiyerRumuzu, sSaticiRumuzu, sKasaNo, "", 0, 0, 0, 0, "", 0, 0, 0, 0, "", 0, lNetTutar, dteKayitTarihi, nStatus, sKullanici, bToplam, bKapali)
        nGirisCikis = 3
        lNetTutar = 0
    End Sub
    Public Function SHARP_GUNSONU(ByVal dosya As String, ByVal kasa As String, ByVal sMagaza As String, ByVal nStatus As Integer, ByVal sKullanici As String, ByVal nIslem As Integer, ByVal sGramaj As String) As Boolean
        Dim entegre As Boolean = False
        dosya = "C:\persis\EanSatis" & kasa & ".txt"
        Dim DOSYAEAN As New FileInfo(dosya)
        If DOSYAEAN.Exists Then
            SHARP_satisoku_EAN(dosya, kasa, sMagaza, nStatus, sKullanici, nIslem, sGramaj)
            entegre = True
        Else
            XtraMessageBox.Show(Sorgu_sDil("Ean Satýþ Bilgisi Yok", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dosya = "C:\persis\PluSatis" & kasa & ".txt"
        Dim DOSYAPLU As New FileInfo(dosya)
        If DOSYAPLU.Exists Then
            SHARP_satisoku_PLU(dosya, kasa, sMagaza, nStatus, sKullanici, nIslem, sGramaj)
            entegre = True
        Else
            XtraMessageBox.Show(Sorgu_sDil("Plu Satýþ Bilgisi Yok", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'If XtraMessageBox.Show(Sorgu_sDil("Entegrasyon Yapmak Ýstermisiniz ...?",sDil), MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
        'satis_aktar()
        'End If
        Return entegre
    End Function
    Public Function HUGIN_GUNSONU(ByVal dosya As String, ByVal kasa As String, ByVal sMagaza As String, ByVal nStatus As Integer, ByVal sKullanici As String, ByVal nIslem As Integer, ByVal sGramaj As String) As Boolean
        Dim entegre As Boolean = False
        dosya = "C:\HuginAlpha\EanSatis.txt"
        Dim DOSYAEAN As New FileInfo(dosya)
        If DOSYAEAN.Exists Then
            HUGIN_satisoku_EAN(dosya, kasa, sMagaza, nStatus, sKullanici, nIslem, sGramaj)
            entegre = True
        Else
            XtraMessageBox.Show(Sorgu_sDil("Ean Satýþ Bilgisi Yok", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'If XtraMessageBox.Show(Sorgu_sDil("Entegrasyon Yapmak Ýstermisiniz ...?",sDil), MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
        'satis_aktar()
        'End If
        Return entegre
    End Function
    Public Sub INTER_ciro(ByVal islem As Integer, ByVal kasa As String, ByVal nIlkKasa As Integer, ByVal nSonKasa As Integer, ByVal sPath As String, ByVal sFile As String, ByVal dteIslemTarihi As DateTime)
        Dim frm As New frmposciro
        frm.lblpos.Text = kasa
        frm.kasa = kasa
        frm.islem = islem
        frm.nIlkKasa = nIlkKasa
        frm.nSonKasa = nSonKasa
        frm.sPath = sPath
        frm.sFile = sFile
        frm.dteIslemTarihi = dteIslemTarihi
        frm.tarih = dteIslemTarihi.ToShortDateString
        frm.tarih2 = dteIslemTarihi.ToShortDateString
        frm.Show()
    End Sub
    Public Sub INTER_ciro_saatlik(ByVal islem As Integer, ByVal kasa As String)
        Dim frm As New frmkasaara
        frm.lblpos.Text = kasa
        frm.kasa = kasa
        frm.islem = islem
        frm.ShowDialog()
        Dim frmpos As New frmrptpos
        frmpos.DataSet1 = intercirosaatlik()
        frmpos.Show()
    End Sub
    Public Sub INTER_ciro_KASÝYER(ByVal islem As Integer, ByVal kasa As String)
        Dim frm As New frmkasaara
        frm.lblpos.Text = kasa
        frm.kasa = kasa
        frm.islem = islem
        frm.ShowDialog()
        Dim frmpos As New frmrptpos
        frmpos.DataSet1 = intercirokasiyer()
        frmpos.Show()
    End Sub
    Public Sub INTER_ciro_Kdv(ByVal islem As Integer, ByVal kasa As String)
        Dim frm As New frmkasaara
        frm.lblpos.Text = kasa
        frm.kasa = kasa
        frm.islem = islem
        frm.ShowDialog()
        Dim frmpos As New frmrptpos
        frmpos.GridView1.Columns.Clear()
        frmpos.DataSet1 = intercirokdv()
        frmpos.GridControl1.DataSource = frm.DataSet1.Tables("POS")
        frmpos.Show()
    End Sub
    Public Sub rafetiket_secili(ByVal miktar As Integer, ByVal port As String, ByVal logo As String)
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarý Barkod Yazýcýya Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dlg As New WaitDlgFrm("Argox Yazýcý Stok Dosyasý Oluþturuluyor...")
            dosyaolustur_etiket(miktar, logo)
            dlg.Close()
            'MsgBox(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : " & sayi, MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
            If sayi > 0 Then
                If XtraMessageBox.Show(Sorgu_sDil("Lütfen..! " & sayi & " Sayfa icin Yazýcýyý Hazýrlayýp  << EVET >> Tuþuna Basýnýz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Dim z As String = "c:\Formlar\database\argox.bat" 'SAVE.FileName.ToString
                    Dim DOSYA As New FileInfo(z)
                    If DOSYA.Exists Then
                        DOSYA.Delete()
                    End If
                    Dim sw As StreamWriter = File.AppendText(z)
                    sw.WriteLine("@echo off")
                    sw.WriteLine("ECHO LUTFEN ISLEMIN BITMESINI BEKLEYINIZ...!")
                    sw.WriteLine("ECHO Toplam Gonderilecek Urun Sayisi :" & sayi & "")
                    sw.WriteLine("C:")
                    sw.WriteLine("cd\database")
                    sw.WriteLine("copy c:\Formlar\database\etiket.prn " & port & "")
                    sw.Close()
                    'Process.Start("c:\Formlar\database\argox.bat")
                    Dim objProcess As System.Diagnostics.Process
                    objProcess = New System.Diagnostics.Process()
                    objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    objProcess.StartInfo.FileName = "c:\Formlar\database\argox.bat"
                    'objProcess.StartInfo.Arguments = "c:\Formlar\database\etiket.prn " & port & ""
                    Dim dlg1 As New WaitDlgFrm(sayi & " Urun Yazdiriliyor...")
                    Try
                        objProcess.Start()
                        objProcess.WaitForExit()
                        objProcess.Close()
                    Catch ex As Exception
                        XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                        'MessageBox.Show(ex.ToString)
                    End Try
                    dlg1.Close()
                    objProcess.Dispose()
                    objProcess = Nothing
                End If
            End If
        End If
    End Sub
    Public Sub rafetiket_secili_10X10(ByVal miktar As Integer, ByVal port As String, ByVal logo As String)
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarý Barkod Yazýcýya Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dlg As New WaitDlgFrm("Argox Yazýcý Stok Dosyasý Oluþturuluyor...")
            dosyaolustur_etiket_10X10(miktar, logo)
            dlg.Close()
            'MsgBox(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : " & sayi, MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
            If sayi > 0 Then
                If XtraMessageBox.Show(Sorgu_sDil("Lütfen..! " & sayi & " Sayfa icin Yazýcýyý Hazýrlayýp  << EVET >> Tuþuna Basýnýz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Dim z As String = "c:\Formlar\database\argox.bat" 'SAVE.FileName.ToString
                    Dim DOSYA As New FileInfo(z)
                    If DOSYA.Exists Then
                        DOSYA.Delete()
                    End If
                    Dim sw As StreamWriter = File.AppendText(z)
                    sw.WriteLine("@echo off")
                    sw.WriteLine("ECHO LUTFEN ISLEMIN BITMESINI BEKLEYINIZ...!")
                    sw.WriteLine("ECHO Toplam Gonderilecek Urun Sayisi :" & sayi & "")
                    sw.WriteLine("C:")
                    sw.WriteLine("cd\database")
                    sw.WriteLine("copy c:\Formlar\database\etiket.prn " & port & "")
                    sw.Close()
                    'Process.Start("c:\Formlar\database\argox.bat")
                    Dim objProcess As System.Diagnostics.Process
                    objProcess = New System.Diagnostics.Process()
                    objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    objProcess.StartInfo.FileName = "c:\Formlar\database\argox.bat"
                    'objProcess.StartInfo.Arguments = "c:\Formlar\database\etiket.prn " & port & ""
                    Dim dlg1 As New WaitDlgFrm(sayi & " Urun Yazdiriliyor...")
                    Try
                        objProcess.Start()
                        objProcess.WaitForExit()
                        objProcess.Close()
                    Catch ex As Exception
                        XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                        'MessageBox.Show(ex.ToString)
                    End Try
                    dlg1.Close()
                    objProcess.Dispose()
                    objProcess = Nothing
                End If
            End If
        End If
    End Sub
    Public Sub rafetiket_secili_10X15(ByVal miktar As Integer, ByVal port As String, ByVal logo As String)
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarý Barkod Yazýcýya Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dlg As New WaitDlgFrm("Argox Yazýcý Stok Dosyasý Oluþturuluyor...")
            dosyaolustur_etiket_10X15(miktar, logo)
            dlg.Close()
            'MsgBox(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : " & sayi, MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
            If sayi > 0 Then
                If XtraMessageBox.Show(Sorgu_sDil("Lütfen..! " & sayi & " Sayfa icin Yazýcýyý Hazýrlayýp  << EVET >> Tuþuna Basýnýz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Dim z As String = "c:\Formlar\database\argox.bat" 'SAVE.FileName.ToString
                    Dim DOSYA As New FileInfo(z)
                    If DOSYA.Exists Then
                        DOSYA.Delete()
                    End If
                    Dim sw As StreamWriter = File.AppendText(z)
                    sw.WriteLine("@echo off")
                    sw.WriteLine("ECHO LUTFEN ISLEMIN BITMESINI BEKLEYINIZ...!")
                    sw.WriteLine("ECHO Toplam Gonderilecek Urun Sayisi :" & sayi & "")
                    sw.WriteLine("C:")
                    sw.WriteLine("cd\database")
                    sw.WriteLine("copy c:\Formlar\database\etiket.prn " & port & "")
                    sw.Close()
                    'Process.Start("c:\Formlar\database\argox.bat")
                    Dim objProcess As System.Diagnostics.Process
                    objProcess = New System.Diagnostics.Process()
                    objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    objProcess.StartInfo.FileName = "c:\Formlar\database\argox.bat"
                    'objProcess.StartInfo.Arguments = "c:\Formlar\database\etiket.prn " & port & ""
                    Dim dlg1 As New WaitDlgFrm(sayi & " Urun Yazdiriliyor...")
                    Try
                        objProcess.Start()
                        objProcess.WaitForExit()
                        objProcess.Close()
                    Catch ex As Exception
                        XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                        'MessageBox.Show(ex.ToString)
                    End Try
                    dlg1.Close()
                    objProcess.Dispose()
                    objProcess = Nothing
                End If
            End If
        End If
    End Sub
    Public Sub intermec_rafetiket_secili(ByVal miktar As Integer, ByVal port As String, ByVal logo As String)
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarý Barkod Yazýcýya Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dlg As New WaitDlgFrm("Ýntermec Yazýcý Stok Dosyasý Oluþturuluyor...")
            dosyaolustur_etiket_intermec(miktar, logo)
            dlg.Close()
            'MsgBox(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : " & sayi, MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
            If sayi > 0 Then
                If XtraMessageBox.Show(Sorgu_sDil("Lütfen..! " & sayi & " Sayfa icin Yazýcýyý Hazýrlayýp  << EVET >> Tuþuna Basýnýz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Dim z As String = "c:\Formlar\database\argox.bat" 'SAVE.FileName.ToString
                    Dim DOSYA As New FileInfo(z)
                    If DOSYA.Exists Then
                        DOSYA.Delete()
                    End If
                    Dim sw As StreamWriter = File.AppendText(z)
                    sw.WriteLine("@echo off")
                    sw.WriteLine("ECHO LUTFEN ISLEMIN BITMESINI BEKLEYINIZ...!")
                    sw.WriteLine("ECHO Toplam Gonderilecek Urun Sayisi :" & sayi & "")
                    sw.WriteLine("C:")
                    sw.WriteLine("cd\database")
                    sw.WriteLine("copy c:\Formlar\database\etiket.prn " & port & "")
                    sw.Close()
                    'Process.Start("c:\Formlar\database\argox.bat")
                    Dim objProcess As System.Diagnostics.Process
                    objProcess = New System.Diagnostics.Process()
                    objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    objProcess.StartInfo.FileName = "c:\Formlar\database\argox.bat"
                    'objProcess.StartInfo.Arguments = "c:\Formlar\database\etiket.prn " & port & ""
                    Dim dlg1 As New WaitDlgFrm(sayi & " Urun Yazdiriliyor...")
                    Try
                        objProcess.Start()
                        objProcess.WaitForExit()
                        objProcess.Close()
                    Catch ex As Exception
                        XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                        'MessageBox.Show(ex.ToString)
                    End Try
                    dlg1.Close()
                    objProcess.Dispose()
                    objProcess = Nothing
                End If
            End If
        End If
    End Sub
    Public Sub urunetiket_secili(ByVal miktar As Integer, ByVal port As String, ByVal logo As String)
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarý Barkod Yazýcýya Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dlg As New WaitDlgFrm("Argox Yazýcý Stok Dosyasý Oluþturuluyor...")
            dosyaolustur_urunetiket(miktar, logo)
            dlg.Close()
            'MsgBox(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : " & sayi, MessageBoxButtons.OK + MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
            If sayi > 0 Then
                If XtraMessageBox.Show(Sorgu_sDil("Lütfen..! " & sayi & " Sayfa icin Yazýcýyý Hazýrlayýp << EVET >> Tuþuna Basýnýz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Dim z As String = "c:\Formlar\database\argox.bat" 'SAVE.FileName.ToString
                    Dim DOSYA As New FileInfo(z)
                    If DOSYA.Exists Then
                        DOSYA.Delete()
                    End If
                    Dim sw As StreamWriter = File.AppendText(z)
                    sw.WriteLine("@echo off")
                    sw.WriteLine("ECHO LUTFEN ISLEMIN BITMESINI BEKLEYINIZ...!")
                    sw.WriteLine("ECHO Toplam Gonderilecek Urun Sayisi :" & sayi & "")
                    sw.WriteLine("C:")
                    sw.WriteLine("cd\database")
                    sw.WriteLine("copy c:\Formlar\database\etiket.prn " & port & "")
                    sw.Close()
                    'Process.Start("c:\Formlar\database\argox.bat")
                    Dim objProcess As System.Diagnostics.Process
                    objProcess = New System.Diagnostics.Process()
                    objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    objProcess.StartInfo.FileName = "c:\Formlar\database\argox.bat"
                    'objProcess.StartInfo.Arguments = "c:\Formlar\database\etiket.prn " & port & ""
                    Dim dlg1 As New WaitDlgFrm(sayi & " Urun Yazdiriliyor...")
                    Try
                        objProcess.Start()
                        objProcess.WaitForExit()
                        objProcess.Close()
                    Catch ex As Exception
                        XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                        'MessageBox.Show(ex.ToString)
                    End Try
                    dlg1.Close()
                    objProcess.Dispose()
                    objProcess = Nothing
                End If
            End If
        End If
    End Sub
    Public Sub urunetiket_fiyatli_secili(ByVal miktar As Integer, ByVal port As String, ByVal logo As String)
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarý Barkod Yazýcýya Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dlg As New WaitDlgFrm("Argox Yazýcý Stok Dosyasý Oluþturuluyor...")
            dosyaolustur_urunetiket_fiyatli(miktar, logo)
            dlg.Close()
            'MsgBox(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : " & sayi, MessageBoxButtons.OK + MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
            If sayi > 0 Then
                If XtraMessageBox.Show(Sorgu_sDil("Lütfen..! " & sayi & " Sayfa icin Yazýcýyý Hazýrlayýp << EVET >> Tuþuna Basýnýz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Dim z As String = "c:\Formlar\database\argox.bat" 'SAVE.FileName.ToString
                    Dim DOSYA As New FileInfo(z)
                    If DOSYA.Exists Then
                        DOSYA.Delete()
                    End If
                    Dim sw As StreamWriter = File.AppendText(z)
                    sw.WriteLine("@echo off")
                    sw.WriteLine("ECHO LUTFEN ISLEMIN BITMESINI BEKLEYINIZ...!")
                    sw.WriteLine("ECHO Toplam Gonderilecek Urun Sayisi :" & sayi & "")
                    sw.WriteLine("C:")
                    sw.WriteLine("cd\database")
                    sw.WriteLine("copy c:\Formlar\database\etiket.prn " & port & "")
                    sw.Close()
                    'Process.Start("c:\Formlar\database\argox.bat")
                    Dim objProcess As System.Diagnostics.Process
                    objProcess = New System.Diagnostics.Process()
                    objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    objProcess.StartInfo.FileName = "c:\Formlar\database\argox.bat"
                    'objProcess.StartInfo.Arguments = "c:\Formlar\database\etiket.prn " & port & ""
                    Dim dlg1 As New WaitDlgFrm(sayi & " Urun Yazdiriliyor...")
                    Try
                        objProcess.Start()
                        objProcess.WaitForExit()
                        objProcess.Close()
                    Catch ex As Exception
                        XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                        'MessageBox.Show(ex.ToString)
                    End Try
                    dlg1.Close()
                    objProcess.Dispose()
                    objProcess = Nothing
                End If
            End If
        End If
    End Sub
    Public Sub zebra_rafetiket_secili(ByVal miktar As Integer, ByVal port As String, ByVal logo As String)
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarý Barkod Yazýcýya Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dlg As New WaitDlgFrm("Zebra Yazýcý Stok Dosyasý Oluþturuluyor...")
            dosyaolustur_zebra_rafetiket(miktar, logo)
            dlg.Close()
            'MsgBox(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : " & sayi, MessageBoxButtons.OK + MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
            If sayi > 0 Then
                If XtraMessageBox.Show(Sorgu_sDil("Lütfen..! " & sayi & " Sayfa icin Yazýcýyý Hazýrlayýp  << EVET >> Tuþuna Basýnýz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Dim z As String = "c:\Formlar\database\zebra.bat" 'SAVE.FileName.ToString
                    Dim DOSYA As New FileInfo(z)
                    If DOSYA.Exists Then
                        DOSYA.Delete()
                    End If
                    Dim sw As StreamWriter = File.AppendText(z)
                    sw.WriteLine("@echo off")
                    sw.WriteLine("ECHO LUTFEN ISLEMIN BITMESINI BEKLEYINIZ...!")
                    sw.WriteLine("ECHO Toplam Gonderilecek Urun Sayisi :" & sayi & "")
                    sw.WriteLine("C:")
                    sw.WriteLine("cd\database")
                    sw.WriteLine("copy c:\Formlar\database\etiket.prn " & port & " ")
                    sw.Close()
                    'Process.Start("c:\Formlar\database\zebra.bat")
                    Dim objProcess As System.Diagnostics.Process
                    objProcess = New System.Diagnostics.Process()
                    objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    objProcess.StartInfo.FileName = "c:\Formlar\database\zebra.bat"
                    'objProcess.StartInfo.Arguments = "c:\Formlar\database\etiket.prn " & port & ""
                    Dim dlg1 As New WaitDlgFrm(sayi & " Urun Yazdiriliyor...")
                    Try
                        objProcess.Start()
                        objProcess.WaitForExit()
                        objProcess.Close()
                    Catch ex As Exception
                        XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                        'MessageBox.Show(ex.ToString)
                    End Try
                    dlg1.Close()
                    objProcess.Dispose()
                    objProcess = Nothing
                End If
            End If
        End If
    End Sub
    Public Sub zebra_10X10_secili(ByVal miktar As Integer, ByVal port As String, ByVal logo As String)
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarý Barkod Yazýcýya Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dlg As New WaitDlgFrm("Zebra Yazýcý Stok Dosyasý Oluþturuluyor...")
            dosyaolustur_zebra_10X10(miktar, logo)
            dlg.Close()
            'MsgBox(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : " & sayi, MessageBoxButtons.OK + MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
            If sayi > 0 Then
                If XtraMessageBox.Show(Sorgu_sDil("Lütfen..! " & sayi & " Sayfa icin Yazýcýyý Hazýrlayýp  << EVET >> Tuþuna Basýnýz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Dim z As String = "c:\Formlar\database\zebra.bat" 'SAVE.FileName.ToString
                    Dim DOSYA As New FileInfo(z)
                    If DOSYA.Exists Then
                        DOSYA.Delete()
                    End If
                    Dim sw As StreamWriter = File.AppendText(z)
                    sw.WriteLine("@echo off")
                    sw.WriteLine("ECHO LUTFEN ISLEMIN BITMESINI BEKLEYINIZ...!")
                    sw.WriteLine("ECHO Toplam Gonderilecek Urun Sayisi :" & sayi & "")
                    sw.WriteLine("C:")
                    sw.WriteLine("cd\database")
                    sw.WriteLine("copy c:\Formlar\database\etiket.prn " & port & " ")
                    sw.Close()
                    'Process.Start("c:\Formlar\database\zebra.bat")
                    Dim objProcess As System.Diagnostics.Process
                    objProcess = New System.Diagnostics.Process()
                    objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    objProcess.StartInfo.FileName = "c:\Formlar\database\zebra.bat"
                    'objProcess.StartInfo.Arguments = "c:\Formlar\database\etiket.prn " & port & ""
                    Dim dlg1 As New WaitDlgFrm(sayi & " Urun Yazdiriliyor...")
                    Try
                        objProcess.Start()
                        objProcess.WaitForExit()
                        objProcess.Close()
                    Catch ex As Exception
                        XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                        'MessageBox.Show(ex.ToString)
                    End Try
                    dlg1.Close()
                    objProcess.Dispose()
                    objProcess = Nothing
                End If
            End If
        End If
    End Sub
    Public Sub zebra_urunetiket_secili(ByVal miktar As Integer, ByVal port As String, ByVal logo As String)
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarý Barkod Yazýcýya Göndermek Ýstediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dlg As New WaitDlgFrm("Zebra Yazýcý Stok Dosyasý Oluþturuluyor...")
            dosyaolustur_zebra_urunetiket(miktar, logo)
            dlg.Close()
            'MsgBox(Sorgu_sDil("Toplam Gönderilen Ürün Sayýsý : " & sayi, MessageBoxButtons.OK + MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
            dataset1.Tables(0).Dispose()
            dataset1.Tables(0).Clear()
            If sayi > 0 Then
                If XtraMessageBox.Show(Sorgu_sDil("Lütfen..! " & sayi & " Sayfa icin Yazýcýyý Hazýrlayýp << EVET >> Tuþuna Basýnýz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Dim z As String = "c:\Formlar\database\zebra.bat" 'SAVE.FileName.ToString
                    Dim DOSYA As New FileInfo(z)
                    If DOSYA.Exists Then
                        DOSYA.Delete()
                    End If
                    Dim sw As StreamWriter = File.AppendText(z)
                    sw.WriteLine("@echo off")
                    sw.WriteLine("ECHO LUTFEN ISLEMIN BITMESINI BEKLEYINIZ...!")
                    sw.WriteLine("ECHO Toplam Gonderilecek Urun Sayisi :" & sayi & "")
                    sw.WriteLine("C:")
                    sw.WriteLine("cd\database")
                    sw.WriteLine("copy c:\Formlar\database\etiket.prn " & port & " ")
                    sw.Close()
                    'Process.Start("c:\Formlar\database\zebra.bat")
                    Dim objProcess As System.Diagnostics.Process
                    objProcess = New System.Diagnostics.Process()
                    objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
                    objProcess.StartInfo.FileName = "c:\Formlar\database\zebra.bat"
                    'objProcess.StartInfo.Arguments = "c:\Formlar\database\etiket.prn " & port & ""
                    Dim dlg1 As New WaitDlgFrm(sayi & " Urun Yazdiriliyor...")
                    Try
                        objProcess.Start()
                        objProcess.WaitForExit()
                        objProcess.Close()
                    Catch ex As Exception
                        XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                        'MessageBox.Show(ex.ToString)
                    End Try
                    dlg1.Close()
                    objProcess.Dispose()
                    objProcess = Nothing
                End If
            End If
        End If
    End Sub
    Public Sub inter_program()
        'Dim frm As New frmkasaprogram
        'frm.ShowDialog()
        'frm.Close()
    End Sub
    Public Sub inter_promosyon()
        'Dim frm As New frminterpromosyon
        'frm.ShowDialog()
        'frm.Close()
    End Sub
    Public Function degeruzunlukkontrol(ByVal deger As String, ByVal uzunluk As String) As String
        deger = deger.Replace("Ý", "I")
        deger = deger.Replace("Þ", "S")
        deger = deger.Replace("Ç", "C")
        deger = deger.Replace("Ð", "G")
        deger = deger.Replace("Ü", "U")
        deger = deger.Replace("Ö", "O")
        deger = deger.Replace("ý", "i")
        deger = deger.Replace("þ", "s")
        deger = deger.Replace("ç", "c")
        deger = deger.Replace("ð", "g")
        deger = deger.Replace("ü", "u")
        deger = deger.Replace("ö", "o")
        Dim degeruzunluk As Integer = uzunluk
        Dim muzunluk = Len(deger)
        If Len(deger) < uzunluk Then
            Dim degerfark As Integer = degeruzunluk - muzunluk
            Dim i As Integer
            For i = 1 To degerfark
                deger = deger.Insert(muzunluk, " ")
            Next
        Else
            deger = Microsoft.VisualBasic.Left(deger, uzunluk)
        End If
        Return deger
    End Function
    Public Function sayiuzunlukkontrol(ByVal deger As String, ByVal uzunluk As String) As String
        Dim degeruzunluk As Integer = uzunluk
        Dim muzunluk = Len(deger)
        If Len(deger) < uzunluk Then
            Dim degerfark As Integer = degeruzunluk - muzunluk
            Dim i As Integer
            For i = 1 To degerfark
                deger = deger.Insert(0, "0")
            Next
        Else
            deger = Microsoft.VisualBasic.Left(deger, uzunluk)
        End If
        Return deger
    End Function
    Public Function sayiuzunlukkontrol_deger(ByVal deger As String, ByVal uzunluk As String, ByVal sEkle As String) As String
        Dim degeruzunluk As Integer = uzunluk
        Dim muzunluk = Len(deger)
        If Len(deger) < uzunluk Then
            Dim degerfark As Integer = degeruzunluk - muzunluk
            Dim i As Integer
            For i = 1 To degerfark
                deger = deger.Insert(0, sEkle)
            Next
        Else
            deger = Microsoft.VisualBasic.Left(deger, uzunluk)
        End If
        Return deger
    End Function
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If Trim(deger.ToString) = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
End Class
