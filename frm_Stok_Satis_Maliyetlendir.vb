Imports System.Threading
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Public Class frm_Stok_Satis_Maliyetlendir
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Public nIslemID As Int64 = 0
    Public bAnaliz As Boolean = False
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Private _searchCriteria As String
    Private _searching As Boolean
    Private _deferSearch As Boolean
    Private _searchThread As Thread
    Private _onSearchComplete As EventHandler
    Dim ds_tbStoklar As DataSet
    Dim ds_tbAlislar As DataSet
    Dim ds_tbSatislar As DataSet
    Dim ds_stok As DataSet
    Dim ds_fiyattipi As DataSet
    Dim lBasitMaliyet As Decimal = 0
    Dim lGirisMaliyet As Decimal = 0
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        BeginSearch()
    End Sub
    Private Sub Satislari_Maliyetlendir(ByVal islem As Integer, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal bModel As Integer)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandTimeout = False
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Delete from TEMPStokMaliyet")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY insert into TEMPStokMaliyet Select distinct tbStokFisiDetayi.nStokID ,sDepo from tbStok,tbStokFisiDetayi  where tbStok.nStokID=tbStokFisiDetayi.nStokID ")
        cmd.ExecuteNonQuery()
        If islem = 0 Then
            cmd.CommandText = sorgu_query("sp_NebMaliyetHesapla_AgirlikliOrtalama '" & tarih1 & "','" & tarih2 & "',0")
        ElseIf islem = 1 Then
            cmd.CommandText = sorgu_query("sp_NebMaliyetHesapla_AgirlikliOrtalamaDeposuz '" & tarih1 & "','" & tarih2 & "',0")
        ElseIf islem = 2 Then
            cmd.CommandText = sorgu_query("sp_NebMaliyetHesapla_AylikOrtalama '" & tarih1 & "','" & tarih2 & "',0")
        ElseIf islem = 3 Then
            'cmd.CommandText = sorgu_query("sp_NebMaliyetHesapla_BasitOrtalama '" & tarih1 & "','" & tarih2 & "',0")
            cmd.CommandText = sorgu_query("sp_NebMaliyetHesapla_Fifo '" & tarih1 & "','" & tarih2 & "',0")
        ElseIf islem = 4 Then
            cmd.CommandText = sorgu_query("sp_NebMaliyetHesapla_Fifo '" & tarih1 & "','" & tarih2 & "',0")
        ElseIf islem = 5 Then
            cmd.CommandText = sorgu_query("sp_NebMaliyetHesapla_FifoDeposuz '" & tarih1 & "','" & tarih2 & "',0")
        ElseIf islem = 6 Then
            cmd.CommandText = sorgu_query("sp_NebMaliyetHesapla_IkiTarihArasiOrtalama '" & tarih1 & "','" & tarih2 & "',0")
        ElseIf islem = 7 Then
            cmd.CommandText = sorgu_query("sp_NebMaliyetHesapla_Lifo '" & tarih1 & "','" & tarih2 & "',0")
        ElseIf islem = 8 Then
            cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiDetayi SET lMaliyetFiyat = ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0), lMaliyetTutar = lCikisMiktar1 * ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) WHERE (dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (sFisTipi IN ('FS', 'DC','SK','SP','K','P','PF'))")
        ElseIf islem = 9 Then
            cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiDetayi SET lMaliyetFiyat = (SELECT TOP 1 ISNULL(CAST(lGirisFiyat * (100 + nKdvOrani) / 100 AS FLOAT), 0) FROM tbStokFisiDetayi tbFis WHERE tbFis.nStokID = tbStokFisiDetayi.nStokID AND tbFis.dteFisTarihi <= tbStokFisiDetayi.dteFisTarihi AND tbFis.nGirisCikis = 1 ORDER BY dteFisTarihi DESC), lMaliyetTutar = (SELECT TOP 1 ISNULL(CAST(lGirisFiyat * (100 + nKdvOrani) / 100 AS FLOAT), 0) FROM tbStokFisiDetayi tbFis WHERE tbFis.nStokID = tbStokFisiDetayi.nStokID AND tbFis.dteFisTarihi <= tbStokFisiDetayi.dteFisTarihi AND tbFis.nGirisCikis = 1 ORDER BY dteFisTarihi DESC) * lCikisMiktar1 WHERE (nGirisCikis IN (3, 4)) AND (dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') and nStokID IN (Select DISTINCT nStokID from tbStokFisiDetayi Where nGirisCikis =1)")
        End If
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokFisiDetayi_Maliyet_degistir(ByVal nIslemID As Int64, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal)
        'Dim cmd As New OleDb.OleDbCommand
        'Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.ConnectionString = connection
            con.Open()
        End If
        cmd.CommandTimeout = False
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokFisiDetayi set lMaliyetFiyat = " & lMaliyetFiyat & " , lMaliyetTutar = " & lMaliyetTutar & " Where nIslemID =" & nIslemID & " ")
        cmd.ExecuteNonQuery()
        'con.Close()
        'cmd = Nothing
        'con = Nothing
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
    Private Sub frm_Stok_Satis_Maliyetlendir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds_fiyattipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFiyatTipi where (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%')"))
        If bAnaliz = False Then
            DateEdit1.EditValue = Today
            DateEdit2.EditValue = dteSistemTarihi
            sec_islem.SelectedIndex = 7
        ElseIf bAnaliz = True Then
            DateEdit1.EditValue = "01/01/1900"
            DateEdit2.EditValue = dteSistemTarihi
            sec_islem.SelectedIndex = 3
            hesapla()
        End If
        If Trim(nIslemID) <> 0 Then
            GridView2.Columns("nIslemID").FilterInfo = New ColumnFilterInfo("[nIslemID] LIKE '" & nIslemID & "%'")
        Else
            GridView2.ClearColumnsFilter()
        End If
    End Sub
    Public Sub BeginSearch()
        If IsHandleCreated Then
            _searchThread = New Thread(New ThreadStart(AddressOf loading))
            _searching = True
            _searchThread.Start()
        Else
            _deferSearch = True
        End If
    End Sub
    Sub loading()
        Try
            SimpleButton1.Enabled = False
            lbl_info.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
            lbl_info.Refresh()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            Satislari_Maliyetlendir(sec_islem.SelectedIndex, DateEdit1.EditValue, DateEdit2.EditValue, sec_bModel.Checked)
            lbl_info.Text = Sorgu_sDil("Tamamlandý...", sDil)
            SimpleButton1.Enabled = True
            Cursor.Current = Cursors.Default
            Cursor.Hide()
        Finally
            _searching = False
            BeginInvoke(_onSearchComplete, New Object() {Me, EventArgs.Empty})
        End Try
    End Sub
    Private Sub maliyetlendir()
        SimpleButton1.Enabled = False
        lbl_info.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        lbl_info.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        Satislari_Maliyetlendir(sec_islem.SelectedIndex, DateEdit1.EditValue, DateEdit2.EditValue, sec_bModel.Checked)
        lbl_info.Text = Sorgu_sDil("Tamamlandý...", sDil)
        SimpleButton1.Enabled = True
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub Maliyet_Servisi(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sStokKodu As String)
        Dim sYil As String = tarih1.Year.ToString
        Dim sAy As String = tarih1.Month.ToString
        SimpleButton1.Enabled = False
        lbl_info.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        lbl_info.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        Dim kriter As String = ""
        If sStokKodu = "" Then
        Else
            kriter = " AND sKodu like '" & sStokKodu & "%'"
        End If
        ds_tbStoklar = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY SELECT nStokID, sKodu, sModel,sAciklama, sRenk, sBeden,nStokTipi, sBirimCinsi1,nFiyatlandirma,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.nStokID AND sFiyatTipi = '" & sFiyatM & "'), 0) AS lMaliyet FROM tbStok WHERE (nStokID IN (SELECT DISTINCT nStokID FROM tbStokFisiDetayi WHERE (nGirisCikis IN (3 , 4) and sFisTipi IN ('K','P','SK','SP','FS','DC') AND dteFisTarihi Between '" & tarih1 & "' and '" & tarih2 & "'))) " & kriter & " "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim dr2 As DataRow
        Dim lToplamKar As Decimal = 0
        Dim lToplamMaliyet As Decimal = 0
        Dim nOran As Decimal = 0
        'Dim dr1 As DataRow
        bar1.Properties.Maximum = ds_tbStoklar.Tables(0).Rows.Count
        bar1.Position = 0
        For Each dr In ds_tbStoklar.Tables(0).Rows
            lbl_sStokAciklama.Text = "Stok: " & dr("sKodu") & vbTab & dr("sAciklama")
            lbl_sStokAciklama.Refresh()
            lbl_lKalanMiktar.Text = "**"
            lbl_lKalanTutar.Text = "**"
            lbl_lKalanMaliyet.Text = "**"
            lbl_lSonAlisMaliyeti.Text = "**"
            lToplamKar = 0
            lToplamMaliyet = 0
            If sec_islem.SelectedIndex = 0 Or sec_islem.SelectedIndex = 2 Or sec_islem.SelectedIndex = 3 Or sec_islem.SelectedIndex = 4 Then
                ds_tbAlislar = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY SELECT tbFirma.nFirmaID,tbFirma.sKodu,tbFirma.sAciklama,tbStokFisiDetayi.nStokFisiID,tbStokFisiDetayi.nGirisCikis,tbStokFisiDetayi.nIslemID, tbStokFisiDetayi.sDepo,tbStokFisiDetayi.sFisTipi,tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lFisNo,tbStokFisiDetayi.nStokID, tbStokFisiDetayi.lGirisMiktar1,tbStokFisiDetayi.lGirisMiktar1 as lMiktar, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.lMaliyetFiyat, tbStokFisiDetayi.lMaliyetTutar, tbStokFisiDetayi.lIlaveMaliyetTutar,tbStokFisiMaster.lMalBedeli AS lMalBedeli,tbStokFisiMaster.lNetTutar, tbStokFisiMaster.lMalIskontoTutari AS lMalIskontotuTutari, tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari, tbStokFisiMaster.lEkmaliyet1,tbStokFisiMaster.lEkmaliyet2,tbStokFisiMaster.lEkmaliyet3,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiMaster.nStokFisiID and nIslemID =0) AS lEkMaliyet4, (SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,CAST(0 AS money) AS nEkOran,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani FROM         tbStokFisiDetayi INNER JOIN                       tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID INNER JOIN                       tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID WHERE (tbStokFisiDetayi.nGirisCikis IN (1)) and tbStokFisiDetayi.lGirisMiktar1 <> 0  AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND tbStokFisiDetayi.nStokID = " & dr("nStokID") & " and tbStokFisiDetayi.sFisTipi <> 'T' ORDER BY tbStokFisiDetayi.nStokID, tbStokFisiDetayi.dteFisTarihi,tbStokFisiDetayi.nIslemID"))
                If ds_tbAlislar.Tables(0).Rows.Count = 0 Then
                    ds_tbAlislar = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY SELECT TOP 1 tbFirma.nFirmaID,tbFirma.sKodu,tbFirma.sAciklama,tbStokFisiDetayi.nStokFisiID,tbStokFisiDetayi.nGirisCikis,tbStokFisiDetayi.nIslemID, tbStokFisiDetayi.sDepo,tbStokFisiDetayi.sFisTipi,tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lFisNo,tbStokFisiDetayi.nStokID, tbStokFisiDetayi.lGirisMiktar1,tbStokFisiDetayi.lGirisMiktar1 as lMiktar, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.lMaliyetFiyat, tbStokFisiDetayi.lMaliyetTutar, tbStokFisiDetayi.lIlaveMaliyetTutar,tbStokFisiMaster.lMalBedeli AS lMalBedeli,tbStokFisiMaster.lNetTutar, tbStokFisiMaster.lMalIskontoTutari AS lMalIskontotuTutari, tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari, tbStokFisiMaster.lEkmaliyet1,tbStokFisiMaster.lEkmaliyet2,tbStokFisiMaster.lEkmaliyet3,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiMaster.nStokFisiID and nIslemID =0) AS lEkMaliyet4, (SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,CAST(0 AS money) AS nEkOran,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani FROM         tbStokFisiDetayi INNER JOIN                       tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID INNER JOIN                       tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID WHERE (tbStokFisiDetayi.nGirisCikis IN (1)) and tbStokFisiDetayi.lGirisMiktar1 > 0  AND (tbStokFisiDetayi.dteFisTarihi < '" & tarih1 & "' ) AND tbStokFisiDetayi.nStokID = " & dr("nStokID") & " and tbStokFisiDetayi.sFisTipi <> 'T' ORDER BY tbStokFisiDetayi.nStokID, tbStokFisiDetayi.dteFisTarihi DESC,tbStokFisiDetayi.nIslemID DESC"))
                End If
                maliyet_kontrol()
            ElseIf sec_islem.SelectedIndex = 1 Then
                ds_tbAlislar = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY SELECT tbFirma.nFirmaID,tbFirma.sKodu,tbFirma.sAciklama,tbStokFisiDetayi.nStokFisiID,tbStokFisiDetayi.nGirisCikis,tbStokFisiDetayi.nIslemID, tbStokFisiDetayi.sDepo,tbStokFisiDetayi.sFisTipi,tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lFisNo,tbStokFisiDetayi.nStokID, tbStokFisiDetayi.lGirisMiktar1,tbStokFisiDetayi.lGirisMiktar1 as lMiktar, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.lMaliyetFiyat, tbStokFisiDetayi.lMaliyetTutar, tbStokFisiDetayi.lIlaveMaliyetTutar,tbStokFisiMaster.lMalBedeli AS lMalBedeli,tbStokFisiMaster.lNetTutar, tbStokFisiMaster.lMalIskontoTutari AS lMalIskontotuTutari, tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari, tbStokFisiMaster.lEkmaliyet1,tbStokFisiMaster.lEkmaliyet2,tbStokFisiMaster.lEkmaliyet3,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiMaster.nStokFisiID and nIslemID =0) AS lEkMaliyet4, (SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,CAST(0 AS money) AS nEkOran,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani FROM         tbStokFisiDetayi INNER JOIN                       tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID INNER JOIN                       tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID WHERE (tbStokFisiDetayi.nGirisCikis IN (1)) and tbStokFisiDetayi.lGirisMiktar1 <> 0  AND (YEAR(tbStokFisiDetayi.dteFisTarihi) = '" & sYil & "' )  AND (MONTH(tbStokFisiDetayi.dteFisTarihi) = '" & sAy & "' ) AND tbStokFisiDetayi.nStokID = " & dr("nStokID") & " and tbStokFisiDetayi.sFisTipi <> 'T' ORDER BY tbStokFisiDetayi.nStokID, tbStokFisiDetayi.dteFisTarihi,tbStokFisiDetayi.nIslemID"))
                maliyet_kontrol()
            ElseIf sec_islem.SelectedIndex = 5 Then
                ds_tbAlislar = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY SELECT tbFirma.nFirmaID,tbFirma.sKodu,tbFirma.sAciklama,tbStokFisiDetayi.nStokFisiID,tbStokFisiDetayi.nGirisCikis,tbStokFisiDetayi.nIslemID, tbStokFisiDetayi.sDepo,tbStokFisiDetayi.sFisTipi,tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lFisNo,tbStokFisiDetayi.nStokID, tbStokFisiDetayi.lGirisMiktar1,tbStokFisiDetayi.lGirisMiktar1 as lMiktar, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.lMaliyetFiyat, tbStokFisiDetayi.lMaliyetTutar, tbStokFisiDetayi.lIlaveMaliyetTutar,tbStokFisiMaster.lMalBedeli AS lMalBedeli,tbStokFisiMaster.lNetTutar, tbStokFisiMaster.lMalIskontoTutari AS lMalIskontotuTutari, tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari, tbStokFisiMaster.lEkmaliyet1,tbStokFisiMaster.lEkmaliyet2,tbStokFisiMaster.lEkmaliyet3,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiMaster.nStokFisiID and nIslemID =0) AS lEkMaliyet4, (SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,CAST(0 AS money) AS nEkOran,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani FROM         tbStokFisiDetayi INNER JOIN                       tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID INNER JOIN                       tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID WHERE (tbStokFisiDetayi.nGirisCikis IN (1)) and tbStokFisiDetayi.lGirisMiktar1 <> 0  AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND tbStokFisiDetayi.nStokID = " & dr("nStokID") & " and tbStokFisiDetayi.sFisTipi <> 'T' ORDER BY tbStokFisiDetayi.nStokID, tbStokFisiDetayi.dteFisTarihi DESC,tbStokFisiDetayi.nIslemID DESC"))
                If ds_tbAlislar.Tables(0).Rows.Count = 0 Then
                    ds_tbAlislar = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY SELECT TOP 1 tbFirma.nFirmaID,tbFirma.sKodu,tbFirma.sAciklama,tbStokFisiDetayi.nStokFisiID,tbStokFisiDetayi.nGirisCikis,tbStokFisiDetayi.nIslemID, tbStokFisiDetayi.sDepo,tbStokFisiDetayi.sFisTipi,tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lFisNo,tbStokFisiDetayi.nStokID, tbStokFisiDetayi.lGirisMiktar1,tbStokFisiDetayi.lGirisMiktar1 as lMiktar, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.lMaliyetFiyat, tbStokFisiDetayi.lMaliyetTutar, tbStokFisiDetayi.lIlaveMaliyetTutar,tbStokFisiMaster.lMalBedeli AS lMalBedeli,tbStokFisiMaster.lNetTutar, tbStokFisiMaster.lMalIskontoTutari AS lMalIskontotuTutari, tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari, tbStokFisiMaster.lEkmaliyet1,tbStokFisiMaster.lEkmaliyet2,tbStokFisiMaster.lEkmaliyet3,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiMaster.nStokFisiID and nIslemID =0) AS lEkMaliyet4, (SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,CAST(0 AS money) AS nEkOran,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani FROM         tbStokFisiDetayi INNER JOIN                       tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID INNER JOIN                       tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID WHERE (tbStokFisiDetayi.nGirisCikis IN (1)) and tbStokFisiDetayi.lGirisMiktar1 > 0  AND (tbStokFisiDetayi.dteFisTarihi < '" & tarih1 & "' ) AND tbStokFisiDetayi.nStokID = " & dr("nStokID") & " and tbStokFisiDetayi.sFisTipi <> 'T' ORDER BY tbStokFisiDetayi.nStokID, tbStokFisiDetayi.dteFisTarihi DESC,tbStokFisiDetayi.nIslemID DESC"))
                End If
                maliyet_kontrol()
            ElseIf sec_islem.SelectedIndex = 6 Then
                ds_tbAlislar = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY SELECT TOP 1 tbFirma.nFirmaID,tbFirma.sKodu,tbFirma.sAciklama,tbStokFisiDetayi.nStokFisiID,tbStokFisiDetayi.nGirisCikis,tbStokFisiDetayi.nIslemID, tbStokFisiDetayi.sDepo,tbStokFisiDetayi.sFisTipi,tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lFisNo,tbStokFisiDetayi.nStokID, tbStokFisiDetayi.lGirisMiktar1,tbStokFisiDetayi.lGirisMiktar1 as lMiktar, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.lMaliyetFiyat, tbStokFisiDetayi.lMaliyetTutar, tbStokFisiDetayi.lIlaveMaliyetTutar,tbStokFisiMaster.lMalBedeli AS lMalBedeli,tbStokFisiMaster.lNetTutar, tbStokFisiMaster.lMalIskontoTutari AS lMalIskontotuTutari, tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari, tbStokFisiMaster.lEkmaliyet1,tbStokFisiMaster.lEkmaliyet2,tbStokFisiMaster.lEkmaliyet3,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiMaster.nStokFisiID and nIslemID =0) AS lEkMaliyet4, (SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,CAST(0 AS money) AS nEkOran,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani FROM         tbStokFisiDetayi INNER JOIN                       tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID INNER JOIN                       tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID WHERE (tbStokFisiDetayi.nGirisCikis IN (1)) and tbStokFisiDetayi.lGirisMiktar1 <> 0  AND (tbStokFisiDetayi.dteFisTarihi <= '" & tarih1 & "' ) AND tbStokFisiDetayi.nStokID = " & dr("nStokID") & " and tbStokFisiDetayi.sFisTipi <> 'T' ORDER BY tbStokFisiDetayi.nStokID, tbStokFisiDetayi.dteFisTarihi DESC,tbStokFisiDetayi.nIslemID DESC"))
                maliyet_kontrol()
            ElseIf sec_islem.SelectedIndex = 7 Then
                ds_tbAlislar = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY SELECT TOP 1 tbFirma.nFirmaID,tbFirma.sKodu,tbFirma.sAciklama,tbStokFisiDetayi.nStokFisiID,tbStokFisiDetayi.nGirisCikis,tbStokFisiDetayi.nIslemID, tbStokFisiDetayi.sDepo,tbStokFisiDetayi.sFisTipi,tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lFisNo,tbStokFisiDetayi.nStokID, tbStokFisiDetayi.lGirisMiktar1,tbStokFisiDetayi.lGirisMiktar1 as lMiktar, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.lMaliyetFiyat, tbStokFisiDetayi.lMaliyetTutar, tbStokFisiDetayi.lIlaveMaliyetTutar,tbStokFisiMaster.lMalBedeli AS lMalBedeli,tbStokFisiMaster.lNetTutar, tbStokFisiMaster.lMalIskontoTutari AS lMalIskontotuTutari, tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari, tbStokFisiMaster.lEkmaliyet1,tbStokFisiMaster.lEkmaliyet2,tbStokFisiMaster.lEkmaliyet3,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiMaster.nStokFisiID and nIslemID =0) AS lEkMaliyet4, (SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,CAST(0 AS money) AS nEkOran,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani FROM         tbStokFisiDetayi INNER JOIN                       tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID INNER JOIN                       tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID WHERE (tbStokFisiDetayi.nGirisCikis IN (1)) and tbStokFisiDetayi.lGirisMiktar1 <> 0  AND (tbStokFisiDetayi.dteFisTarihi <= '" & tarih1 & "' ) AND tbStokFisiDetayi.nStokID = " & dr("nStokID") & " and tbStokFisiDetayi.sFisTipi <> 'T' ORDER BY tbStokFisiDetayi.nStokID, tbStokFisiDetayi.dteFisTarihi DESC,tbStokFisiDetayi.nIslemID DESC"))
                maliyet_kontrol()
            End If
            Try
                GridControl1.DataSource = ds_tbAlislar.Tables(0)
                GridControl1.DataMember = Nothing
            Catch ex As Exception
            End Try
            ds_tbSatislar = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY SELECT tbFirma.nFirmaID,tbFirma.sKodu,tbFirma.sAciklama,tbStokFisiDetayi.nStokFisiID,tbStokFisiDetayi.nGirisCikis,tbStokFisiDetayi.nIslemID, tbStokFisiDetayi.sDepo,tbStokFisiDetayi.sFisTipi,tbStokFisiDetayi.dteFisTarihi,tbStokFisiDetayi.lFisNo,tbStokFisiDetayi.sSaticiRumuzu,YEAR(tbStokFisiDetayi.dteFisTarihi) as sYil,MONTH(tbStokFisiDetayi.dteFisTarihi) as sAy,tbStokFisiDetayi.nStokID, tbStokFisiDetayi.lCikisMiktar1, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, CAST(tbStokFisiDetayi.lCikisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lCikisFiyat, CAST(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lCikisTutar, tbStokFisiDetayi.lMaliyetFiyat, tbStokFisiDetayi.lMaliyetTutar,CAST(0 as Money) as lKar,Cast(0 as Money) as nOran FROM tbStokFisiDetayi INNER JOIN                       tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID WHERE (tbStokFisiDetayi.nGirisCikis IN (3,4)) AND tbStokFisiDetayi.sFisTipi IN ('K','P','SK','SP','FS','DC','PF') and tbStokFisiDetayi.dteFisTarihi Between '" & tarih1 & "' and '" & tarih2 & "' AND tbStokFisiDetayi.nStokID = " & dr("nStokID") & " and tbStokFisiDetayi.sFisTipi <> 'T' ORDER BY tbStokFisiDetayi.nStokID, tbStokFisiDetayi.dteFisTarihi"))
            GridControl2.DataSource = ds_tbSatislar.Tables(0)
            GridControl2.DataMember = Nothing
            Dim lMaliyetFiyat As Decimal = 0
            Dim bHesapla As Boolean = False

            bar2.Properties.Maximum = ds_tbSatislar.Tables(0).Rows.Count
            bar2.Position = 0
            For Each dr1 In ds_tbSatislar.Tables(0).Rows
                If sec_islem.SelectedIndex = 6 Then
                    dr1("lMaliyetTutar") = dr("lMaliyet") * dr1("lCikisMiktar1")
                    dr1("lMaliyetFiyat") = dr("lMaliyet")
                    bHesapla = False
                ElseIf sec_islem.SelectedIndex = 2 Then
                    dr1("lMaliyetTutar") = lBasitMaliyet * dr1("lCikisMiktar1")
                    dr1("lMaliyetFiyat") = lBasitMaliyet
                    bHesapla = False
                ElseIf sec_islem.SelectedIndex = 4 Then
                    dr1("lMaliyetTutar") = lGirisMaliyet * dr1("lCikisMiktar1")
                    dr1("lMaliyetFiyat") = lGirisMaliyet
                    bHesapla = False
                ElseIf sec_islem.SelectedIndex = 7 Then
                    If dr1("dteFisTarihi") = tarih1 Then
                        bHesapla = True
                    Else
                        tarih1 = dr1("dteFisTarihi")
                        ds_tbAlislar = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY SELECT TOP 1 tbStokFisiDetayi.nIslemID, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.nStokID, tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.lMaliyetFiyat, tbStokFisiDetayi.lMaliyetTutar, tbStokFisiDetayi.lIlaveMaliyetTutar,tbStokFisiMaster.lMalBedeli AS lMalBedeli,tbStokFisiMaster.lNetTutar, tbStokFisiMaster.lMalIskontoTutari AS lMalIskontotuTutari, tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari, tbStokFisiMaster.lEkmaliyet1,tbStokFisiMaster.lEkmaliyet2,tbStokFisiMaster.lEkmaliyet3,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiMaster.nStokFisiID and nIslemID =0) AS lEkMaliyet4, (SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,CAST(0 AS money) AS nEkOran,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani FROM         tbStokFisiDetayi INNER JOIN                       tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID INNER JOIN                       tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiDetayi.nGirisCikis IN (1)) and tbStokFisiDetayi.lGirisMiktar1 > 0  AND (tbStokFisiDetayi.dteFisTarihi <= '" & tarih1 & "' ) AND tbStokFisiDetayi.nStokID = " & dr("nStokID") & " and tbStokFisiDetayi.sFisTipi <> 'T' ORDER BY tbStokFisiDetayi.nStokID, tbStokFisiDetayi.dteFisTarihi DESC"))
                        maliyet_kontrol()
                        bHesapla = True
                    End If
                ElseIf sec_islem.SelectedIndex = 1 Then
                    If dr1("sAy") = sAy And dr1("sYil") = sYil Then
                        If lBasitMaliyet = 0 Then
                            lBasitMaliyet = lMaliyetFiyat
                        Else
                            lMaliyetFiyat = lBasitMaliyet
                        End If
                        dr1("lMaliyetTutar") = lBasitMaliyet * dr1("lCikisMiktar1")
                        dr1("lMaliyetFiyat") = lBasitMaliyet
                        bHesapla = False
                    Else
                        sAy = dr1("sAy")
                        sYil = dr1("sYil")
                        ds_tbAlislar = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY SELECT tbStokFisiDetayi.nIslemID, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.nStokID, tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.lMaliyetFiyat, tbStokFisiDetayi.lMaliyetTutar, tbStokFisiDetayi.lIlaveMaliyetTutar,tbStokFisiMaster.lMalBedeli AS lMalBedeli,tbStokFisiMaster.lNetTutar, tbStokFisiMaster.lMalIskontoTutari AS lMalIskontotuTutari, tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari, tbStokFisiMaster.lEkmaliyet1,tbStokFisiMaster.lEkmaliyet2,tbStokFisiMaster.lEkmaliyet3,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiMaster.nStokFisiID and nIslemID =0) AS lEkMaliyet4, (SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,CAST(0 AS money) AS nEkOran,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani FROM         tbStokFisiDetayi INNER JOIN                       tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID INNER JOIN                       tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiDetayi.nGirisCikis IN (1)) and tbStokFisiDetayi.lGirisMiktar1 > 0  AND (YEAR(tbStokFisiDetayi.dteFisTarihi) = '" & sYil & "' )  AND (MONTH(tbStokFisiDetayi.dteFisTarihi) = '" & sAy & "' ) AND tbStokFisiDetayi.nStokID = " & dr("nStokID") & " and tbStokFisiDetayi.sFisTipi <> 'T' ORDER BY tbStokFisiDetayi.nStokID, tbStokFisiDetayi.dteFisTarihi DESC"))
                        maliyet_kontrol()
                        If lBasitMaliyet = 0 Then
                            lBasitMaliyet = lMaliyetFiyat
                        Else
                            lMaliyetFiyat = lBasitMaliyet
                        End If
                        dr1("lMaliyetTutar") = lBasitMaliyet * dr1("lCikisMiktar1")
                        dr1("lMaliyetFiyat") = lBasitMaliyet
                        bHesapla = False
                    End If
                Else
                    bHesapla = True
                End If

                If bHesapla = True Then
                    dr1("lMaliyetTutar") = lMaliyet_hesapla(dr1("lCikisMiktar1"), dr1("dteFisTarihi"))
                    dr1("lMaliyetFiyat") = Math.Abs(dr1("lMaliyetTutar") / dr1("lCikisMiktar1"))
                    If dr1("lMaliyetFiyat") = 0 Then
                        dr1("lMaliyetFiyat") = lMaliyetFiyat
                        dr1("lMaliyetTutar") = dr1("lMaliyetFiyat") * dr1("lCikisMiktar1")
                    Else
                        lMaliyetFiyat = Math.Abs(dr1("lMaliyetFiyat"))
                    End If
                End If
                dr1("lKar") = dr1("lCikisTutar") - dr1("lMaliyetTutar")
                Try
                    dr1("nOran") = dr1("lKar") / dr1("lMaliyetTutar")
                Catch ex As Exception
                    dr1("nOran") = 0
                End Try
                If Trim(dr1("sAciklama")).Contains("SAYIM") = True Or Trim(dr1("sAciklama")).ToString.Contains("STOK DUZELT") = True Or dr("nStokTipi") = 4 Or dr("nStokTipi") = 6 Then
                    dr1("lMaliyetFiyat") = dr1("lCikisFiyat")
                    dr1("lMaliyetTutar") = dr1("lCikisTutar")
                    dr1("lKar") = 0
                    dr1("nOran") = 0
                Else
                    lToplamKar = lToplamKar + dr1("lKar")
                    lToplamMaliyet = lToplamMaliyet + dr1("lMaliyetTutar")
                End If

                If bAnaliz = False Then
                    tbStokFisiDetayi_Maliyet_degistir(dr1("nIslemID"), dr1("lMaliyetFiyat"), dr1("lMaliyetTutar"))
                End If
                bar2.Position = bar2.Position + 1
                bar2.Refresh()
            Next
            Dim lKalanMiktar As Decimal = 0
            Dim lKalanTutar As Decimal = 0
            Dim lKalanMaliyet As Decimal = 0
            For Each dr2 In ds_tbAlislar.Tables(0).Rows
                If dr2("lGirisMiktar1") <> 0 Then
                    lKalanMiktar = lKalanMiktar + dr2("lGirisMiktar1")
                    lKalanTutar = lKalanTutar + (dr2("lGirisMiktar1") * dr2("lMaliyetFiyat"))
                End If
                lbl_lSonAlisMaliyeti.Text = Format(dr2("lMaliyetFiyat"), "#,0.00##")
            Next
            Try
                lKalanMaliyet = lKalanTutar / lKalanMiktar
            Catch ex As Exception
                lKalanMaliyet = 0
            End Try
            lbl_lKalanMiktar.Text = Format(lKalanMiktar, "#,0.###") & " " & dr("sBirimCinsi1").ToString
            lbl_lKalanTutar.Text = Format(lKalanTutar, "#,0.###")
            lbl_lKalanMaliyet.Text = Format(lKalanMaliyet, "#,0.###")
            Try
                nOran = lToplamKar / lToplamMaliyet * 100
            Catch ex As Exception
                nOran = 0
            End Try
            colnOran.SummaryItem.DisplayFormat = "%" & FormatNumber(nOran, 2).ToString
            bar1.Position = bar1.Position + 1
            bar1.Refresh()
            'Maliyet Güncelle
            If sec_bMaliyetDegistir.Checked = True Then
                Dim fiyat As Decimal = 0
                Try
                    fiyat = sorgu_stok_fiyat("" & sFiyatM & "", dr("nStokID"), "")
                Catch ex As Exception
                    fiyat = 0
                End Try
                'maliyetleri guncelle
                If fiyat = 0 Then
                    tbStokFiyati_ekle_sil(dr("nFiyatlandirma"), dr("sModel"), dr("sRenk"), dr("sBeden"), sFiyatM, lKalanMaliyet, dteSistemTarihi)
                    tbStokFiyati_ekle_yeni(dr("nFiyatlandirma"), dr("sModel"), dr("sRenk"), dr("sBeden"), sFiyatM, lKalanMaliyet, dteSistemTarihi, kullaniciadi)
                ElseIf fiyat <> lKalanMaliyet Then
                    tbStokFiyati_ekle_duzelt(dr("nFiyatlandirma"), dr("sModel"), dr("sRenk"), dr("sBeden"), sFiyatM, lKalanMaliyet, dteSistemTarihi)
                End If
            End If
        Next


        If bAnaliz = False Then
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        lbl_info.Text = Sorgu_sDil("Tamamlandý...", sDil)
        SimpleButton1.Enabled = True
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub maliyet_kontrol()
        Dim maliyet As Decimal = 0
        Dim oranekmaliyet As Decimal = 0
        Dim dr3 As DataRow
        Dim lToplamMiktar As Decimal = 0
        Dim lToplamMaliyet As Decimal = 0
        Dim lToplamTutar As Decimal = 0
        For Each dr3 In ds_tbAlislar.Tables(0).Rows
            maliyet = (dr3("lGirisTutar")) / dr3("lGirisMiktar1")
            If dr3("nKdvOrani") <> dr3("nStokKdvOrani") Then
                If bKdvKontrolluMaliyet = True Then
                    maliyet = maliyet * ((dr3("nStokKdvOrani") + 100) / 100)
                Else
                    maliyet = maliyet * ((dr3("nKdvOrani") + 100) / 100)
                End If
            Else
                maliyet = maliyet * ((dr3("nKdvOrani") + 100) / 100)
            End If
            maliyet = (maliyet) - (Math.Abs((dr3("lIlaveMaliyetTutar") + dr3("lEkIlaveMaliyetTutar")) / dr3("lGirisMiktar1")))
            Try
                If CType(dr3("lEkmaliyet1") + dr3("lEkMaliyet3") + dr3("lEkMaliyet4"), Decimal) <> 0 Then
                    oranekmaliyet = CType(dr3("lEkmaliyet1") + dr3("lEkmaliyet3") + dr3("lEkMaliyet4"), Decimal) / CType(dr3("lNetTutar") - (dr3("lEkmaliyet1")), Decimal)
                    maliyet = maliyet + (maliyet * (((oranekmaliyet * 100)) / 100))
                End If
            Catch ex As Exception
            End Try
            dr3("lMaliyetFiyat") = maliyet
            'dr3("lGirisTutar") = dr3("lGirisTutar") * ((dr3("nKdvOrani") + 100) / 100)
            lToplamMiktar += dr3("lGirisMiktar1")
            lToplamMaliyet += dr3("lGirisMiktar1") * dr3("lMaliyetFiyat")
            lToplamTutar += dr3("lGirisTutar") * ((dr3("nKdvOrani") + 100) / 100)
        Next
        Try
            lBasitMaliyet = lToplamMaliyet / lToplamMiktar
        Catch ex As Exception
            lBasitMaliyet = 0
        End Try
        Try
            lGirisMaliyet = lToplamTutar / lToplamMiktar
        Catch ex As Exception
            lGirisMaliyet = 0
        End Try
    End Sub
    Private Function lMaliyet_hesapla(ByVal lMiktar As Decimal, ByVal tarih As DateTime) As Decimal
        Dim dr As DataRow
        Dim tutar As Decimal = 0
        Dim lSonMiktar As Decimal = 0
        Dim lIlkMiktar As Decimal = 0
        Dim lSonMaliyet As Decimal = 0
        Dim lOrjMiktar As Decimal = lMiktar
        'lMiktar = Math.Abs(lMiktar)
        lSonMiktar = lMiktar
        lIlkMiktar = lMiktar
        Dim nIslemID As Int64 = 0
        If lMiktar < 0 Then
            For Each dr In ds_tbAlislar.Tables(0).Rows
                If lMiktar < 0 And dr("dteFisTarihi") <= tarih Then
                    tutar = dr("lMaliyetFiyat") * lMiktar
                    nIslemID = dr("nIslemID")
                End If
            Next
        End If
        For Each dr In ds_tbAlislar.Tables(0).Rows
            If lMiktar < 0 And dr("dteFisTarihi") <= tarih And nIslemID = dr("nIslemID") Then
                dr("lGirisMiktar1") = dr("lGirisMiktar1") + Math.Abs(lMiktar)
            End If
            If dr("lGirisMiktar1") > 0 And lSonMiktar > 0 Then
                If lMiktar > dr("lGirisMiktar1") Then
                    'tutar += dr("lMaliyetFiyat") * (lMiktar - dr("lGirisMiktar1"))
                    lSonMaliyet = dr("lMaliyetFiyat")
                    tutar += dr("lMaliyetFiyat") * (dr("lGirisMiktar1"))
                    lMiktar -= dr("lGirisMiktar1")
                    dr("lGirisMiktar1") = 0
                ElseIf lSonMiktar = dr("lGirisMiktar1") Then
                    tutar += dr("lMaliyetFiyat") * dr("lGirisMiktar1")
                    lSonMaliyet = dr("lMaliyetFiyat")
                    'lMiktar = lMiktar - dr("lGirisMiktar1")
                    lMiktar = 0
                    dr("lGirisMiktar1") = 0
                ElseIf lSonMiktar < dr("lGirisMiktar1") Then
                    tutar += dr("lMaliyetFiyat") * (lMiktar)
                    lSonMaliyet = dr("lMaliyetFiyat")
                    dr("lGirisMiktar1") = dr("lGirisMiktar1") - lMiktar
                    lMiktar = 0
                End If
                lSonMiktar = lMiktar
            End If
        Next
        If lSonMiktar > 0 Then
            Try
                tutar = tutar / (lIlkMiktar - lMiktar)
                tutar = tutar * lIlkMiktar
            Catch ex As Exception
                tutar = lIlkMiktar * lSonMaliyet
            End Try
        End If
        Return tutar
    End Function
    Private Sub fis_duzelt(Optional ByVal nIslem As Integer = 1)
        Dim bDevam As Boolean = False
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        If nIslem = 1 Then
            If GridView1.RowCount > 0 Then
                bDevam = True
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Else
                bDevam = False
            End If
        ElseIf nIslem = 2 Then
            If GridView2.RowCount > 0 Then
                bDevam = True
                dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Else
                bDevam = False
            End If
        End If
        If bDevam = True Then
            Dim frm As New frm_fatura
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.lFisNo = dr("lFisNo")
            frm.dteFisTarihi = dr("dteFisTarihi")
            frm.sFisTipi = dr("sFisTipi")
            frm.nFirmaID = dr("nFirmaID")
            frm.nGirisCikis = dr("nGirisCikis")
            frm.nStokFisiID = dr("nStokFisiID")
            frm.nIslemID = dr("nIslemID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                Try
                    frm.ShowDialog()
                Catch ex As Exception
                End Try
            End If
            frm.Close()
            frm = Nothing
            dr = Nothing
        End If
    End Sub
    Protected Overrides Sub OnHandleDestroyed(ByVal e As EventArgs)
        If Not RecreatingHandle Then
            StopSearch()
        End If
        MyBase.OnHandleDestroyed(e)
    End Sub
    Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
        MyBase.OnHandleCreated(e)
        If _deferSearch Then
            _deferSearch = False
            BeginSearch()
        End If
    End Sub
    Private Sub OnSearchComplete(ByVal sender As Object, ByVal e As EventArgs)
        RaiseEvent SearchComplete(sender, e)
    End Sub
    Public Event SearchComplete As EventHandler
    Public Sub StopSearch()
        If Not _searching Then
            Return
        End If
        If _searchThread.IsAlive Then
            _searchThread.Abort()
            _searchThread.Join()
        End If
        _searchThread = Nothing
        _searching = False
    End Sub
    Private Sub gorunum_yazdir()
        printlink.CreateDocument(ps)
        ps.PreviewRibbonFormEx.ShowDialog()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub sec_islem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            sec_bModel.Focus()
            sec_bModel.Select()
        End If
    End Sub
    Private Sub sec_bModel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_bModel.KeyDown
        If e.KeyCode = Keys.Enter Then
            SimpleButton1.Focus()
            SimpleButton1.Select()
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Maliyetlendir.Click
        hesapla()
    End Sub
    Private Sub hesapla()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        Maliyet_Servisi(DateEdit1.EditValue, DateEdit2.EditValue, txt_sStokKodu.Text)
        If GridView1.RowCount > 0 Then
            GridView1.ClearSelection()
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
            GridView1.SelectRow(GridView1.FocusedRowHandle)
            GridControl1.Focus()
        End If
        GridControl1.Focus()
        GridControl1.Select()
        If GridView2.RowCount > 0 Then
            GridView2.ClearSelection()
            GridView2.FocusedRowHandle = GridView2.RowCount - 1
            GridView2.SelectRow(GridView2.FocusedRowHandle)
            GridControl2.Focus()
        End If
        GridControl2.Focus()
        GridControl2.Select()
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        fis_duzelt()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            fis_duzelt()
        End If
    End Sub
    Private Sub GridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView2.DoubleClick
        fis_duzelt(2)
    End Sub
    Private Sub GridView2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView2.KeyDown
        If e.KeyCode = Keys.Enter Then
            fis_duzelt(2)
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub
    Private Sub btn_MaliyetDegistir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_MaliyetDegistir.ItemClick
    End Sub
    Private Sub guncelle_maliyet(ByVal sKodu As String)
        Dim fiyat As Decimal = 0
        Dim maliyet As Decimal = 0
        Dim dr1 As DataRow = ds_tbStoklar.Tables(0).Rows(0)
        dataload_stok(sKodu)
        Try
            fiyat = sorgu_stok_fiyat("" & sFiyatM & "", dr1("nStokID"), dr1("sDovizCinsi"))
        Catch ex As Exception
            fiyat = 0
        End Try
        'maliyetleri guncelle
        If fiyat = 0 Then
            tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyatM, maliyet, dteSistemTarihi)
            tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyatM, maliyet, dteSistemTarihi, kullaniciadi)
        ElseIf fiyat <> maliyet Then
            tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyatM, maliyet, dteSistemTarihi)
        End If
    End Sub
    Private Sub dataload_stok(ByVal kod As String, Optional ByVal sConnection As String = "")
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbStok " & kriter & ""))
    End Sub
    Public Function sorgu_stok_fiyat(ByVal fiyattipi As String, ByVal stokno As Int64, ByVal sDovizCinsi As String) As Decimal
        Dim kriter
        kriter = "WHERE     (sFiyatTipi = '" & fiyattipi & "') AND (nStokID = " & stokno & ")"
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim lKur As Decimal = 1
        Dim sKur As String = "lAlisKuru"
        sDovizCinsi = sorgula_String("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select ISNULL(sDovizCinsi,'') from tbStok where nStokID = " & stokno & "")
        Dim dr As DataRow
        For Each dr In ds_fiyattipi.Tables(0).Rows
            If Trim(dr("sFiyatTipi")) = Trim(fiyattipi) Then
                If Trim(dr("sDovizCinsi")) <> "" Then
                    sDovizCinsi = dr("sDovizCinsi")
                    If dr("sHangiKur") = "Alýþ" Then
                        sKur = "lAlisKuru"
                    ElseIf dr("sHangiKur") = "Satýþ" Then
                        sKur = "lSatisKuru"
                    ElseIf dr("sHangiKur") = "Efektif Alýþ" Then
                        sKur = "lEfektiAlisKuru"
                    ElseIf dr("sHangiKur") = "Efektif Satýþ" Then
                        sKur = "lEfektifSatisKuru"
                    ElseIf dr("sHangiKur") = "Merkez Bankasý Alýþ" Then
                        sKur = "lMerkezBankasiAlisKuru"
                    ElseIf dr("sHangiKur") = "Merkez Bankasý Satýþ" Then
                        sKur = "lMerkezBankasiSatisKuru"
                    Else
                        sKur = "lAlisKuru"
                    End If
                    lKur = sorgu_lDovizKuru(sDovizCinsi, sKur)
                End If
            End If
        Next
        If Trim(sDovizCinsi) <> "" Then
            lKur = sorgu_lDovizKuru(sDovizCinsi, sKur)
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lFiyat * " & lKur & ", 0) AS FIYAT FROM         tbStokFiyati " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        con.Dispose()
        cmd.Dispose()
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub tbStokFiyati_ekle_yeni(ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String, ByVal lFiyat As Decimal, ByVal dteFiyatTespitTarihi As DateTime, ByVal sKullaniciAdi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = "set implicit_transactions on "
        cmd.ExecuteNonQuery()
        If nFiyatlandirma = 0 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & sKullaniciAdi & "' , getdate ()  from tbStok where sModel = '" & sModel & "'"
        ElseIf nFiyatlandirma = 1 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & sKullaniciAdi & "' , getdate ()  from tbStok where sModel = '" & sModel & "' and sRenk ='" & sRenk & "'"
        ElseIf nFiyatlandirma = 2 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & sKullaniciAdi & "' , getdate ()  from tbStok where sModel = '" & sModel & "' and sRenk ='" & sRenk & "' and sBeden ='" & sBeden & "'"
        End If
        cmd.ExecuteNonQuery()
        cmd.CommandText = "IF @@TRANCOUNT > 0 COMMIT TRAN"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "set implicit_transactions off "
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFiyati_ekle_duzelt(ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String, ByVal lFiyat As Decimal, ByVal dteFiyatTespitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = "set implicit_transactions on "
        cmd.ExecuteNonQuery()
        If lFiyat = 0 Then
            If nFiyatlandirma = 0 Then
                cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED delete tbStokFiyati from tbStok where tbStok.nStokID = tbStokFiyati.nStokID       and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "'"
            ElseIf nFiyatlandirma = 1 Then
                cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED delete tbStokFiyati from tbStok where tbStok.nStokID = tbStokFiyati.nStokID       and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "'"
            ElseIf nFiyatlandirma = 2 Then
                cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED delete tbStokFiyati from tbStok where tbStok.nStokID = tbStokFiyati.nStokID       and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "' and sBeden ='" & sBeden & "'"
            End If
        Else
            If nFiyatlandirma = 0 Then
                cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED update tbStokFiyati set lFiyat = " & lFiyat & " , dteFiyatTespitTarihi = '" & dteFiyatTespitTarihi & "' , dteKayitTarihi = getdate() from tbStok where tbStok.nStokID = tbStokFiyati.nStokID and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "'"
            ElseIf nFiyatlandirma = 1 Then
                cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED update tbStokFiyati set lFiyat = " & lFiyat & " , dteFiyatTespitTarihi = '" & dteFiyatTespitTarihi & "' , dteKayitTarihi = getdate() from tbStok where tbStok.nStokID = tbStokFiyati.nStokID and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "'"
            ElseIf nFiyatlandirma = 2 Then
                cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED update tbStokFiyati set lFiyat = " & lFiyat & " , dteFiyatTespitTarihi = '" & dteFiyatTespitTarihi & "' , dteKayitTarihi = getdate() from tbStok where tbStok.nStokID = tbStokFiyati.nStokID and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "' and sBeden = '" & sBeden & "' "
            End If
        End If
        cmd.ExecuteNonQuery()
        cmd.CommandText = "IF @@TRANCOUNT > 0 COMMIT TRAN"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "set implicit_transactions off "
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFiyati_ekle_sil(ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String, ByVal lFiyat As Decimal, ByVal dteFiyatTespitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = "set implicit_transactions on "
        cmd.ExecuteNonQuery()
        If nFiyatlandirma = 0 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED delete tbStokFiyati from tbStok where tbStok.nStokID = tbStokFiyati.nStokID       and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "'"
        ElseIf nFiyatlandirma = 1 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED delete tbStokFiyati from tbStok where tbStok.nStokID = tbStokFiyati.nStokID       and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "'"
        ElseIf nFiyatlandirma = 2 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED delete tbStokFiyati from tbStok where tbStok.nStokID = tbStokFiyati.nStokID       and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "' and sBeden ='" & sBeden & "'"
        End If
        cmd.ExecuteNonQuery()
        cmd.CommandText = "IF @@TRANCOUNT > 0 COMMIT TRAN"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "set implicit_transactions off "
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
   
End Class