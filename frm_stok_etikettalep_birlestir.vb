Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Public Class frm_stok_etikettalep_birlestir
    Public firmano As Object
    Public donemno As Object
    Public connection As Object
    Public EVRAKNO As String = ""
    Public islemstatus As Boolean
    Public dataset1 As DataSet
    Public fatura As Boolean
    Public dteFisTarihi As DateTime
    Public sFisTipi As String
    Public nGirisCikis As Integer
    Public nStokFisiID As String = ""
    Public nIslemID As String = ""
    Public sBirimCinsi As String = ""
    Public modelMi As Boolean = False
    Public bSiparis As Boolean
    Public lFisNo As Long
    Public nFirmaID As Long
    Private _stokFisi As DataSet
    Private _siparisFisi As DataSet

    'Private Property stokFisi(nStokFisiID As String, dteFisTarihi As Date, sFisTipi As String, p4 As String) As DataSet
    '    Get
    '        Return _stokFisi
    '    End Get
    '    Set(value As DataSet)
    '        _stokFisi = value
    '    End Set
    'End Property

    'Private Property SiparisFisi(p1 As String, dteFisTarihi As Date, sFisTipi As String, lFisNo As Long) As DataSet
    '    Get
    '        Return _siparisFisi
    '    End Get
    '    Set(value As DataSet)
    '        _siparisFisi = value
    '    End Set
    'End Property

    Private Sub frm_stok_etikettalep_birlestir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ara()
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
    Public Function stok(ByVal EVRAKNO As String) As DataSet
        Dim adapter As OleDbDataAdapter
        Dim command As OleDbCommand
        Dim connection As OleDbConnection
        Dim set1 As DataSet
        Dim str As String
        Dim num As Integer
        Dim set2 As DataSet
        str = ""
        str = (str & " WHERE     (EVRAKNO = " & EVRAKNO & ") ")
        connection = New OleDbConnection
        command = New OleDbCommand
        adapter = New OleDbDataAdapter
        connection.ConnectionString = Conversions.ToString(Me.connection)
        command.CommandTimeout = 0
        adapter.SelectCommand = command
        command.CommandText = Me.sorgu_query(("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST(1 AS Bit) AS SEC, EVRAKNO, STOKNO, STOKKODU, MALINCINSI, sBirimCinsi,lBirimMiktar,BARCODE, RENK, BEDEN, MODEL, CAST(ACIKLAMA AS NVARCHAR(100)) AS ACIKLAMA, ETIKET, DEPO, FIYAT1, FIYAT2, FIYAT3, SUM(MIKTAR) AS MIKTAR, (SELECT TOP 1 IND FROM ASTOKETIKETTALEPDETAY WHERE EVRAKNO = HR.EVRAKNO AND STOKNO = HR.STOKNO ORDER BY IND) AS IND FROM ASTOKETIKETTALEPDETAY HR " & str & " GROUP BY EVRAKNO, STOKNO, STOKKODU, MALINCINSI, sBirimCinsi,lBirimMiktar,BARCODE, RENK, BEDEN, MODEL, CAST(ACIKLAMA AS NVARCHAR(100)), ETIKET, DEPO, FIYAT1, FIYAT2, FIYAT3 HAVING (COUNT(STOKNO) > 1) "))
        command.Connection = connection
        connection.Open()
        [set1] = New DataSet
        num = adapter.Fill([set1], "Table1")
        connection.Close()
        set2 = [set1]
Label_009D:
        Return set2
    End Function

    Public Function stokFisi(ByVal nStokFisiID As String, ByVal dteFisTarihi As DateTime, ByVal sFisTipi As String, ByVal nGirisCikis As String) As DataSet
        Dim adapter As OleDbDataAdapter
        Dim command As OleDbCommand
        Dim connection As OleDbConnection
        Dim set1 As DataSet
        Dim num As Integer
        Dim set2 As DataSet
        Dim strArray As String()
        connection = New OleDbConnection
        command = New OleDbCommand
        adapter = New OleDbDataAdapter
        connection.ConnectionString = Conversions.ToString(Me.connection)
        command.CommandTimeout = 0
        adapter.SelectCommand = command
        command.CommandText = Me.sorgu_query(String.Concat(New String() {"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST(1 AS Bit) AS SEC, tbStokFisiDetayi.nStokID AS IND, tbStokFisiDetayi.sAciklama, tbStokFisiDetayi.sDepo AS DEPO, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lCikisFiyat, SUM(tbStokFisiDetayi.lGirisMiktar1) AS lGirisMiktar1, SUM(tbStokFisiDetayi.lCikisMiktar1) AS lCikisMiktar1, (SELECT TOP 1 nIslemID FROM tbStokFisiDetayi AS t WHERE sFisTipi = '", sFisTipi, "' AND dteFisTarihi = '", Conversions.ToString(dteFisTarihi), "' AND nGirisCikis = ", nGirisCikis, " AND t.sAciklama = tbStokFisiDetayi.sAciklama AND t.sDepo = tbStokFisiDetayi.sDepo AND t.lGirisFiyat = tbStokFisiDetayi.lGirisFiyat AND t.lCikisFiyat = tbStokFisiDetayi.lCikisFiyat AND t.nStokID = tbStokFisiDetayi.nStokID ORDER BY nIslemID) AS nIslemID, tbStok.sKodu AS STOKKODU, tbStok.sAciklama AS MALINCINSI, tbStok.sKisaAdi, tbStok.sRenk, tbStok.sBeden AS BEDEN, tbRenk.sRenkAdi AS RENK FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk WHERE (tbStokFisiDetayi.dteFisTarihi = '", Conversions.ToString(dteFisTarihi), "') AND (tbStokFisiDetayi.sFisTipi = '", sFisTipi, "') AND (tbStokFisiDetayi.nGirisCikis = ", nGirisCikis, ") and (tbStokFisiDetayi.nStokFisiID = '", nStokFisiID, "')GROUP BY tbStokFisiDetayi.nStokID, tbStokFisiDetayi.sAciklama, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lCikisFiyat, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.sDepo, tbStok.sKodu, tbStok.sAciklama, tbStok.sKisaAdi, tbStok.sRenk, tbStok.sBeden, tbRenk.sRenkAdi HAVING (COUNT(tbStokFisiDetayi.nStokID) > 1) "}))
        command.Connection = connection
        connection.Open()
        [set1] = New DataSet
        num = adapter.Fill([set1], "Table1")
        connection.Close()
        set2 = [set1]
Label_010D:
        Return set2
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function

    Private Sub ara()
        Dim flag As Boolean
        Dim flag2 As Boolean
        Me.Label2.Text = KeyCode.Sorgu_sDil("Lütfen Bekleyiniz...", KeyCode.sDil)
        Me.Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        Me.dataload(Me.EVRAKNO)
        Me.Label2.Text = KeyCode.Sorgu_sDil("Tamamlandý...", KeyCode.sDil)
        If (Me.fatura = False) Then
            GoTo Label_00C0
        End If
        If (((Me.nGirisCikis = 1) Or (Me.nGirisCikis = 2)) = False) Then
            GoTo Label_0095
        End If
        Me.colMIKTAR.FieldName = "lGirisMiktar1"
        GoTo Label_00BD
Label_0095:
        If (((Me.nGirisCikis = 3) Or (Me.nGirisCikis = 4)) = False) Then
            GoTo Label_00BD
        End If
        Me.colMIKTAR.FieldName = "lCikisMiktar1"
Label_00BD:
        GoTo Label_00DB
Label_00C0:
        If (Me.bSiparis = False) Then
            GoTo Label_00DB
        End If
        Me.colMIKTAR.FieldName = "lCikisMiktar1"
Label_00DB:
        Cursor.Current = Cursors.Default
        Cursor.Hide()
        Return
    End Sub
    Private Sub dataload(ByVal EVRAKNO As String)
        Dim flag As Boolean
        If (Me.fatura = False) Then
            GoTo Label_0036
        End If
        Me.dataset1 = Me.stokFisi(Me.nStokFisiID, Me.dteFisTarihi, Me.sFisTipi, Conversions.ToString(Me.nGirisCikis))
        GoTo Label_0079
Label_0036:
        If (Me.bSiparis = False) Then
            GoTo Label_006B
        End If
        Me.dataset1 = Me.SiparisFisi(Conversions.ToString(Me.nFirmaID), Me.dteFisTarihi, Me.sFisTipi, Me.lFisNo)
        GoTo Label_0079
Label_006B:
        Me.dataset1 = Me.stok(EVRAKNO)
Label_0079:
        Me.GridControl1.DataSource = Me.dataset1.Tables.Item(0)
        Me.GridControl1.DataMember = Nothing
        Me.PanelControl3.Select()
        Me.GridControl1.Focus()
        Me.GridControl1.Select()
        Me.GridView1.CollapseAllGroups()
        Return
    End Sub
    Public Function SiparisFisi(ByVal nFirmaID As String, ByVal dteSiparisTarihi As DateTime, ByVal nSiparisTipi As String, ByVal lFisNo As Long) As DataSet
        Dim adapter As OleDbDataAdapter
        Dim command As OleDbCommand
        Dim connection As OleDbConnection
        Dim set1 As DataSet
        Dim num As Integer
        Dim set2 As DataSet
        Dim strArray As String()
        connection = New OleDbConnection
        command = New OleDbCommand
        adapter = New OleDbDataAdapter
        connection.ConnectionString = Conversions.ToString(Me.connection)
        command.CommandTimeout = 0
        adapter.SelectCommand = command
        command.CommandText = Me.sorgu_query(String.Concat(New String() {"SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST(1 AS Bit) AS SEC, tbSiparis.nStokID AS IND, tbSiparis.sSiparisiVeren as sAciklama, tbSiparis.sDepo AS DEPO, tbSiparis.lFiyati lCikisFiyat, SUM(tbSiparis.lMiktari) AS lCikisMiktar1, (SELECT TOP 1 nSiparisID FROM tbSiparis AS t WHERE nSiparisTipi = '", Me.sFisTipi, "' AND dteSiparisTarihi = '", Conversions.ToString(dteSiparisTarihi), "' AND nFirmaID = ", nFirmaID, " and lSiparisNo = ", Conversions.ToString(lFisNo), " AND t.sSiparisiVeren = tbSiparis.sSiparisiVeren AND t.sDepo = tbSiparis.sDepo AND t.lFiyati = tbSiparis.lFiyati  AND t.nStokID = tbSiparis.nStokID ORDER BY nSiparisID) AS nIslemID, tbStok.sKodu AS STOKKODU, tbStok.sAciklama AS MALINCINSI, tbStok.sKisaAdi, tbStok.sRenk, tbStok.sBeden AS BEDEN, tbRenk.sRenkAdi AS RENK FROM tbSiparis INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk WHERE (tbSiparis.dteSiparisTarihi = '", Conversions.ToString(dteSiparisTarihi), "') AND (tbSiparis.nSiparisTipi = '", nSiparisTipi, "') AND (tbSiparis.nFirmaID = ", nFirmaID, ") and (tbSiparis.lSiparisNo = ", Conversions.ToString(lFisNo), ") GROUP BY tbSiparis.nStokID, tbSiparis.sSiparisiVeren, tbSiparis.lFiyati,  tbSiparis.nKdvOrani, tbSiparis.sDepo, tbStok.sKodu, tbStok.sAciklama, tbStok.sKisaAdi, tbStok.sRenk, tbStok.sBeden, tbRenk.sRenkAdi HAVING (COUNT(tbSiparis.nStokID) > 1) "}))
        command.Connection = connection
        connection.Open()
        [set1] = New DataSet
        num = adapter.Fill([set1], "Table1")
        connection.Close()
        set2 = [set1]
Label_012E:
        Return set2
    End Function
    Private Sub sorgu()
        Dim flag As Boolean
        If islemstatus = Nothing Then
            GoTo Label_001C
        End If
        Me.DialogResult = 1
        Me.Close()
        GoTo Label_0024
Label_001C:
        Me.Close()
Label_0024:
        Return
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        sorgu()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Enter Then
            sorgu()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class