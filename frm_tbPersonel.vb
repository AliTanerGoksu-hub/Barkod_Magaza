Imports FastReport
Imports DevExpress.XtraEditors
Public Class frm_tbPersonel
    Public firmano
    Public donemno
    Public connection
    Public nPersonelID As Int64 = 0
    Public lSicilNo As Int64 = 1
    Public kullanici
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_tbCinsiyet As DataSet
    Dim ds_tbBordroSSK As DataSet
    Dim ds_tbBordroStatu As DataSet
    Dim ds_tbIstenCikisSebebi As DataSet
    Dim ds_tbIstenCikisSebebiBolge As DataSet
    Dim ds_tbPersonelMeslekKod As DataSet
    Dim ds_tbDovizCinsi As DataSet
    Dim ds_tbUnvan As DataSet
    Dim ds_tbIl As DataSet
    Dim ds_tbYabanciDil As DataSet
    Dim ds_tbYabanciDilSeviye As DataSet
    Dim ds_tbYuksekOkul As DataSet
    Dim ds_tbYuksekOkulBolum As DataSet
    Dim ds_tbBordroFirmaDepartman As DataSet
    Dim ds_tbPersonelEgitim As DataSet
    Dim ds_tbEgitimTipi As DataSet
    Dim ds_tbYakinlik As DataSet
    Dim ds_tbIzinTipi As DataSet
    Public yeni As Boolean = False
    Private Sub frm_tbPersonel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload_tbIl()
        dataload_tbCinsiyet()
        dataload_tbBordroSSK()
        dataload_tbIstenCikisSebebi()
        dataload_tbPersonelMeslekKod()
        dataload_tbYabanciDil()
        dataload_tbYuksekOkul()
        dataload_tbIsKanunu()
        dataload_tbBordroFirmaDepartman()
        dataload_tbUnvan()
        dataload_tbDovizCinsi()
        dataload_tbEgitimTipi()
        dataload_tbYakinlik()
        dataload_tbIzinTipi()
        If nPersonelID = 0 Then
            If yeni = False Then
                'firma_sec()
            ElseIf yeni = True Then
                nPersonelID = sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nPersonelID), 0) + 1 AS nPersonelID FROM         tbPersonel")
                txt_nPersonelID.Text = nPersonelID
                lSicilNo = sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(lSicilNo), 0) + 1 AS lSicilNo FROM         tbPersonel")
                'dataload(nPersonelID)
                Dim dr As DataRow = ds_tbPersonel.Tables(0).NewRow
                dr("nPersonelID") = nPersonelID
                dr("lSicilNo") = lSicilNo
                ds_tbPersonel.Tables(0).Rows.Add(dr)
                SimpleButton1.Text = "&Kaydet"
            End If
        Else
            txt_nPersonelID.EditValue = nPersonelID
            dataload(nPersonelID)
        End If

        If yeni = True Then
        Else
            XtraTabControl1.SelectedTabPageIndex = 0
            txt_sAdi.Focus()
            txt_sAdi.SelectAll()
        End If
    End Sub
    Private Sub dataload_tbIsKanunu()
        Dim dr As DataRow = ds_tbIsKanunu.Tables(0).NewRow
        dr("sKodu") = "00000"
        dr("sAciklama") = "Sigortalı Özel Bir Kanuna Tabii Değil"
        ds_tbIsKanunu.Tables(0).Rows.Add(dr)
        dr = ds_tbIsKanunu.Tables(0).NewRow
        dr("sKodu") = "05510"
        dr("sAciklama") = "Say.Kan.MYO %5"
        ds_tbIsKanunu.Tables(0).Rows.Add(dr)
        dr = ds_tbIsKanunu.Tables(0).NewRow
        dr("sKodu") = "04857"
        dr("sAciklama") = "Sigortalı Sakatlı İndirimi Kanununa Tabii"
        ds_tbIsKanunu.Tables(0).Rows.Add(dr)
        dr = ds_tbIsKanunu.Tables(0).NewRow
        dr("sKodu") = "14857"
        dr("sAciklama") = "4857 Hazine İndirimi %100"
        ds_tbIsKanunu.Tables(0).Rows.Add(dr)
        dr = ds_tbIsKanunu.Tables(0).NewRow
        dr("sKodu") = "54857"
        dr("sAciklama") = "4857 Hazine İndirimi %500"
        ds_tbIsKanunu.Tables(0).Rows.Add(dr)
        dr = ds_tbIsKanunu.Tables(0).NewRow
        dr("sKodu") = "05084"
        dr("sAciklama") = "5084 Hazine İndirimi %100"
        ds_tbIsKanunu.Tables(0).Rows.Add(dr)
        dr = ds_tbIsKanunu.Tables(0).NewRow
        dr("sKodu") = "85084"
        dr("sAciklama") = "5084 Hazine İndirimi %80"
        ds_tbIsKanunu.Tables(0).Rows.Add(dr)
        dr = ds_tbIsKanunu.Tables(0).NewRow
        dr("sKodu") = "05350"
        dr("sAciklama") = "5350 Hazine İndirimi %100"
        ds_tbIsKanunu.Tables(0).Rows.Add(dr)
        dr = ds_tbIsKanunu.Tables(0).NewRow
        dr("sKodu") = "85350"
        dr("sAciklama") = "5350 Hazine İndirimi %80"
        ds_tbIsKanunu.Tables(0).Rows.Add(dr)
        dr = ds_tbIsKanunu.Tables(0).NewRow
        dr("sKodu") = "05615"
        dr("sAciklama") = "5615 Hazine İndirimi %100"
        ds_tbIsKanunu.Tables(0).Rows.Add(dr)
        dr = ds_tbIsKanunu.Tables(0).NewRow
        dr("sKodu") = "85615"
        dr("sAciklama") = "5615 Hazine İndirimi %80"
        ds_tbIsKanunu.Tables(0).Rows.Add(dr)
        dr = ds_tbIsKanunu.Tables(0).NewRow
        dr("sKodu") = "05921"
        dr("sAciklama") = "5921 Sayılı Kanuna Tabii"
        ds_tbIsKanunu.Tables(0).Rows.Add(dr)
        sec_sTTFNumarasi.Properties.DataSource = ds_tbIsKanunu.Tables(0)
    End Sub
    Private Sub dataload_tbDovizCinsi()
        ds_tbDovizCinsi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDovizCinsi, sAciklama FROM         tbDovizCinsi ORDER BY sDovizCinsi"))
        sec_sUcretDovizCinsi.Properties.DataSource = ds_tbDovizCinsi.Tables(0)
    End Sub
    Private Sub dataload_tbCinsiyet()
        ds_tbCinsiyet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbCinsiyet"), "tbCinsiyet")
        txt_nCinsiyet.Properties.DataSource = ds_tbCinsiyet.Tables(0)
        sec_YakinCinsiyet.DataSource = ds_tbCinsiyet.Tables(0)
    End Sub

    Private Sub dataload_tbBordroFirmaDepartman()
        ds_tbBordroFirmaDepartman = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepartmanKodu, sAciklama FROM         tbBordroFirmaDepartman"), "tbBordroFirmaDepartman")
        sec_sDepartmanKodu.Properties.DataSource = ds_tbBordroFirmaDepartman.Tables(0)
    End Sub
    Private Sub dataload_tbIl()
        ds_tbIl = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sIl FROM         tbIl order by sIl"), "tbIl")
        txt_sEvIl.Properties.DataSource = ds_tbIl.Tables(0)
        sec_sSonIsyeriIl.Properties.DataSource = ds_tbIl.Tables(0)
        txt_sKayitliIl.Properties.DataSource = ds_tbIl.Tables(0)
        sec_Il.DataSource = ds_tbIl.Tables(0)
        'txt_sEvIl.Properties.DataSource = ds_tbIl.Tables(0)
    End Sub
    Private Sub dataload_tbUnvan()
        ds_tbUnvan = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sUnvan,sAciklama FROM         tbUnvan"))
        sec_sUnvan.Properties.DataSource = ds_tbUnvan.Tables(0)
    End Sub
    Private Sub dataload_tbEgitimTipi()
        ds_tbEgitimTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sEgitimTipi, sAciklama FROM         tbEgitimTipi ORDER BY sAciklama"))
        sec_sEgitimTipi.DataSource = ds_tbEgitimTipi.Tables(0)
    End Sub
    Private Sub dataload_tbYakinlik()
        ds_tbYakinlik = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sYakinlikDerecesi, sAciklama FROM         tbYakinlik"))
        sec_Yakinlik.DataSource = ds_tbYakinlik.Tables(0)
    End Sub
    Private Sub dataload_tbIzinTipi()
        ds_tbIzinTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sIzinTipi, sAciklama FROM         tbIzinTipi"))
        sec_IzinTipi.DataSource = ds_tbIzinTipi.Tables(0)
    End Sub
    Private Sub dataload_tbPersonelMeslekKod()
        ds_tbPersonelMeslekKod = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     RTRIM(sMeslekKodu) sMeslekKodu, sAciklama FROM         tbPersonelMeslekKod ORDER BY sAciklama"), "tbPersonelMeslekKod")
        sec_sMeslekKodu.Properties.DataSource = ds_tbPersonelMeslekKod.Tables(0)
    End Sub
    Private Sub dataload_tbIstenCikisSebebi()
        ds_tbIstenCikisSebebi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sCikisSebebi, sAciklama FROM         tbIstenCikisSebebi ORDER BY sCikisSebebi"), "tbIstenCikisSebebi")
        sec_sCikisSebebi.Properties.DataSource = ds_tbIstenCikisSebebi.Tables(0)
        ds_tbIstenCikisSebebiBolge = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nCikisSebebiBolge, sAciklama FROM         tbIstenCikisSebebiBolge ORDER BY nCikisSebebiBolge"), "tbIstenCikisSebebiBolge")
        sec_lTTFToplamOdenen.Properties.DataSource = ds_tbIstenCikisSebebiBolge.Tables(0)
    End Sub
    Private Sub dataload_tbBordroSSK()
        ds_tbBordroSSK = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sStatuKodu, sAciklama FROM         tbBordroVergiSSK WHERE     (sVS = 'SSK') ORDER BY sStatuKodu"), "tbBordroSSK")
        ds_tbBordroStatu = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED select sStatuKodu, sAciklama from tbBordroVergiSSk where sVS = 'VI' order by sStatuKodu"), "tbBordroStatu")
        sec_sVergiStatusu2.Properties.DataSource = ds_tbBordroSSK.Tables(0)
        sec_sVergiStatusu.Properties.DataSource = ds_tbBordroStatu.Tables(0)
    End Sub
    Private Sub dataload_tbYabanciDil()
        ds_tbYabanciDil = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nYabanciDilID, sYabanciDil FROM         tbYabanciDil ORDER BY sYabanciDil"), "tbYabanciDil")
        sec_nYabanciDilID1.Properties.DataSource = ds_tbYabanciDil.Tables(0)
        sec_nYabanciDilID2.Properties.DataSource = ds_tbYabanciDil.Tables(0)
        sec_nYabanciDilID3.Properties.DataSource = ds_tbYabanciDil.Tables(0)
        ds_tbYabanciDilSeviye = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT     nYDSeviye, sAciklama FROM         tbYabanciDilSeviye"), "tbYabanciDilSeviye")
        sec_nYDSeviye1.Properties.DataSource = ds_tbYabanciDilSeviye.Tables(0)
        sec_nYDSeviye2.Properties.DataSource = ds_tbYabanciDilSeviye.Tables(0)
        sec_nYDSeviye3.Properties.DataSource = ds_tbYabanciDilSeviye.Tables(0)
    End Sub
    Private Sub dataload_tbYuksekOkul()
        ds_tbYuksekOkul = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nYuksekOkulID, sYuksekOkul FROM         tbYuksekOkul"), "tbYuksekOkul")
        sec_nYuksekOkulID1.Properties.DataSource = ds_tbYuksekOkul.Tables(0)
        sec_nYuksekOkulID2.Properties.DataSource = ds_tbYuksekOkul.Tables(0)
        ds_tbYuksekOkulBolum = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT     nBolumID, sBolum FROM         tbYuksekOkulBolum"), "tbYuksekOkulBolum")
        sec_nBolumID1.Properties.DataSource = ds_tbYuksekOkulBolum.Tables(0)
        sec_nBolumID2.Properties.DataSource = ds_tbYuksekOkulBolum.Tables(0)
    End Sub
    Private Sub dataload(ByVal nPersonelID As String)
        Dataload_tbPersonel(nPersonelID)
        Dim dr As DataRow
        If ds_tbPersonel.Tables(0).Rows.Count = 1 Then
            dr = ds_tbPersonel.Tables(0).Rows(0)
            txt_sAkedemikUnvani.Text = dr("sAkedemikUnvani")
            If dr("sSaatGunlukAylik") = "S" Then
                sec_sSaatGunlukAylik.SelectedIndex = 0
            ElseIf dr("sSaatGunlukAylik") = "G" Then
                sec_sSaatGunlukAylik.SelectedIndex = 1
            ElseIf dr("sSaatGunlukAylik") = "A" Then
                sec_sSaatGunlukAylik.SelectedIndex = 2
            End If
            If Trim(dr("sTTFNumarasi")) <> "" Then
                sec_sTTFNumarasi.EditValue = Microsoft.VisualBasic.Left(dr("sTTFNumarasi").ToString, 5)
                sec_sMeslekKodu.EditValue = Microsoft.VisualBasic.Right(dr("sTTFNumarasi").ToString, 4)
            End If
        End If
        If sorgu_tbFirmaTablo_kontrol(nPersonelID, "tbPersonelSinifi") = 0 Then
            tbPersonelSinifi_kaydet_yeni(nPersonelID, "", "", "", "", "")
        End If
        If sorgu_tbFirmaTablo_kontrol(nPersonelID, "tbPersonelOzluk") = 0 Then
            tbPersonelOzluk_kaydet_yeni(nPersonelID, "", 0, "", "", "", 0, "01/01/1900", 0, "", "", "", "", "", "01/01/1900", 0, "", 1, "", "", "", "", "", "", "", "", "", "", "", "", "01/01/1900", "", "", "", "", "", "", "", "", "", 0, 0, 0)
        End If
        If sorgu_tbFirmaTablo_kontrol(nPersonelID, "tbPersonelMeslek") = 0 Then
            tbPersonelMeslek_kaydet_yeni(nPersonelID, "", "01/01/1900", "", "01/01/1900", 1, 1, "01/01/1900", 1, 1, "01/01/1900", "", 0, "", "", "", "", "", "", "", "", "", 1, 0, 1, 0, 1, 0, 1, "", 0, 0)
        End If
        Dataload_tbHesapSinifi(nPersonelID)
        Dataload_tbPersonelOzluk(nPersonelID)
        Dataload_tbPersonelMeslek(nPersonelID)
        ds_tbPersonelEgitim = Dataload_tbPersonelEgitim(nPersonelID)
        GridControl2.DataSource = ds_tbPersonelEgitim.Tables(0)
        GridControl2.DataMember = Nothing
        ds_tbPersonelYakini = Dataload_tbPersonelYakini(nPersonelID)
        GridControl3.DataSource = ds_tbPersonelYakini.Tables(0)
        GridControl3.DataMember = Nothing
        ds_tbPersonelIzini = Dataload_tbPersonelIzini(nPersonelID)
        GridControl4.DataSource = ds_tbPersonelIzini.Tables(0)
        GridControl4.DataMember = Nothing
        ds_tbPersonelKumSigorta = Dataload_tbPersonelKumSigorta(nPersonelID)
        GridControl5.DataSource = ds_tbPersonelKumSigorta.Tables(0)
        GridControl5.DataMember = Nothing
        ds_tbPersonelKumVergi = Dataload_tbPersonelKumVergi(nPersonelID)
        GridControl6.DataSource = ds_tbPersonelKumVergi.Tables(0)
        GridControl6.DataMember = Nothing
    End Sub
    Public Sub Dataload_tbPersonel(ByVal nPersonelID As String)
        Try
            ds_tbPersonel.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbPersonel where  nPersonelID ='" & nPersonelID & "'")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbPersonel, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbPersonelOzluk(ByVal nPersonelID As String)
        Try
            ds_tbPersonelOzluk.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbPersonelOzluk where  nPersonelID ='" & nPersonelID & "'")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbPersonelOzluk, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbPersonelMeslek(ByVal nPersonelID As String)
        Try
            ds_tbPersonelMeslek.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbPersonelMeslek where  nPersonelID ='" & nPersonelID & "'")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbPersonelMeslek, "Table1")
        conn.Close()
    End Sub
    Private Sub Dataload_tbHesapSinifi(ByVal nMusteriID As String)
        Dim kriter As String = ""
        kriter += " SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
        kriter += " SELECT 1 AS sSinifNo, tbPersonelSinifi.nPersonelID, (SELECT sSinifTipi01 FROM tbParamBordro) AS sSinifTipi, tbPSinif1.sSinifKodu, tbPSinif1.sAciklama FROM tbPersonelSinifi INNER JOIN tbPSinif1 ON tbPersonelSinifi.sSinifKodu1 = tbPSinif1.sSinifKodu WHERE (tbPersonelSinifi.nPersonelID = '" & nPersonelID & "')"
        kriter += " UNION ALL"
        kriter += " SELECT 2 AS sSinifNo, tbPersonelSinifi.nPersonelID, (SELECT sSinifTipi02 FROM tbParamBordro) AS sSinifTipi, tbPSinif2.sSinifKodu, tbPSinif2.sAciklama FROM tbPersonelSinifi INNER JOIN tbPSinif2 ON tbPersonelSinifi.sSinifKodu2 = tbPSinif2.sSinifKodu WHERE (tbPersonelSinifi.nPersonelID = '" & nPersonelID & "')"
        kriter += " UNION ALL"
        kriter += " SELECT 3 AS sSinifNo, tbPersonelSinifi.nPersonelID, (SELECT sSinifTipi03 FROM tbParamBordro) AS sSinifTipi, tbPSinif3.sSinifKodu, tbPSinif3.sAciklama FROM tbPersonelSinifi INNER JOIN tbPSinif3 ON tbPersonelSinifi.sSinifKodu3 = tbPSinif3.sSinifKodu WHERE (tbPersonelSinifi.nPersonelID = '" & nPersonelID & "')"
        kriter += " UNION ALL"
        kriter += " SELECT 4 AS sSinifNo, tbPersonelSinifi.nPersonelID, (SELECT sSinifTipi04 FROM tbParamBordro) AS sSinifTipi, tbPSinif4.sSinifKodu, tbPSinif4.sAciklama FROM tbPersonelSinifi INNER JOIN tbPSinif4 ON tbPersonelSinifi.sSinifKodu4 = tbPSinif4.sSinifKodu WHERE (tbPersonelSinifi.nPersonelID = '" & nPersonelID & "')"
        kriter += " UNION ALL"
        kriter += " SELECT 5 AS sSinifNo, tbPersonelSinifi.nPersonelID, (SELECT sSinifTipi05 FROM tbParamBordro) AS sSinifTipi, tbPSinif5.sSinifKodu, tbPSinif5.sAciklama FROM tbPersonelSinifi INNER JOIN tbPSinif5 ON tbPersonelSinifi.sSinifKodu5 = tbPSinif5.sSinifKodu WHERE (tbPersonelSinifi.nPersonelID = '" & nPersonelID & "')"
        ds_tbPersonelSinifi = sorgu(sorgu_query("" & kriter & ""))
        GridControl1.DataMember = Nothing
        GridControl1.DataSource = ds_tbPersonelSinifi.Tables(0)
    End Sub
    Private Sub dataload_tbPSinif(Optional ByVal sSinifNo As Integer = 1)
        sec_sSinifKodu.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbPSinif" & sSinifNo & "")).Tables(0)
        sec_siniflar.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbPSinif" & sSinifNo & "")).Tables(0)
    End Sub
    Public Function Dataload_tbPersonelEgitim(ByVal nPersonelID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbPersonelEgitim WHERE nPersonelID ='" & nPersonelID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function Dataload_tbPersonelYakini(ByVal nPersonelID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbPersonelYakini WHERE nPersonelID ='" & nPersonelID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function Dataload_tbPersonelIzini(ByVal nPersonelID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *,dteIzinTarihi as dteEskiIzinTarihi FROM         tbPersonelIzini WHERE nPersonelID ='" & nPersonelID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function Dataload_tbPersonelKumSigorta(ByVal nPersonelID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *,nYil as nEskiYil,nGun1 + nGun2 + nGun3 + nGun4 + nGun5 + nGun6 + nGun7 + nGun8 + nGun9 + nGun10 + nGun11 + nGun12 AS nGunToplam, lMatrah1 + lMatrah2 + lMatrah3 + lMatrah4 + lMatrah5 + lMatrah6 + lMatrah7 + lMatrah8 + lMatrah9 + lMatrah10 + lMatrah11 + lMatrah12 AS lMatrahToplam, lIssislikPrimi1 + lIssislikPrimi2 + lIssislikPrimi3 + lIssislikPrimi4 + lIssislikPrimi5 + lIssislikPrimi6 + lIssislikPrimi7 + lIssislikPrimi8 + lIssislikPrimi9 + lIssislikPrimi10 + lIssislikPrimi11 + lIssislikPrimi12 AS lIssislikPrimiToplam FROM         tbPersonelKumSigorta WHERE nPersonelID ='" & nPersonelID & "' Order by nYil Desc")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function Dataload_tbPersonelKumVergi(ByVal nPersonelID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *,nYil as nEskiYil, lMatrah1 + lMatrah2 + lMatrah3 + lMatrah4 + lMatrah5 + lMatrah6 + lMatrah7 + lMatrah8 + lMatrah9 + lMatrah10 + lMatrah11 + lMatrah12 AS lMatrahToplam FROM         tbPersonelKumVergi WHERE nPersonelID ='" & nPersonelID & "' Order by nYil Desc")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_tbFirmaTablo_kontrol(ByVal nHesapID As String, ByVal Tablo As String) As Int64
        Dim kriter
        kriter = "WHERE (nPersonelID = '" & nHesapID & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         " & Tablo & "  " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub tbPersonelSinifi_kaydet_yeni(ByVal nPersonelID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbPersonelSinifi (nPersonelID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5) VALUES     (" & nPersonelID & ", '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbPersonelSinifi_kaydet_duzelt(ByVal nPersonelID As String, ByVal sSinifKodu As String, ByVal sSinifNo As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbPersonelSinifi SET              sSinifKodu" & sSinifNo & " = '" & sSinifKodu & "' where nPersonelID = '" & nPersonelID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        kaydet_tumu()
    End Sub
    Private Sub kaydet_tumu()
        Dim dr As DataRow
        dr = ds_tbPersonel.Tables(0).Rows(0)
        If yeni = False Then
            If sec_sSaatGunlukAylik.SelectedIndex = 0 Then
                dr("sSaatGunlukAylik") = "S"
            ElseIf sec_sSaatGunlukAylik.SelectedIndex = 1 Then
                dr("sSaatGunlukAylik") = "G"
            ElseIf sec_sSaatGunlukAylik.SelectedIndex = 2 Then
                dr("sSaatGunlukAylik") = "A"
            End If
            dr("nCocukAd") = sorgu_sayi(dr("nCocukAdOkulOncesi"), 0) + sorgu_sayi(dr("nCocukAdIlkOgrenim"), 0) + sorgu_sayi(dr("nCocukAdLise"), 0) + sorgu_sayi(dr("nCocukAdYuksek"), 0)
            dr("sTTFNumarasi") = degeruzunlukkontrol(sec_sTTFNumarasi.EditValue, 5) & " " & degeruzunlukkontrol(sec_sMeslekKodu.EditValue, 4)
            tbPersonel_kaydet_duzelt(dr("nPersonelID"), sorgu_sayi(dr("lSicilNo"), 0), dr("sDepartmanKodu").ToString, dr("sAdi").ToString, dr("sIkinciAdi").ToString, dr("sSoyadi").ToString, sorgu_sayi(dr("nCinsiyet"), 0), dr("sAkedemikUnvani").ToString, dr("sUnvan").ToString, sorgu_sayi(dr("bSSKKesilecekmi"), 0), sorgu_sayi(dr("bIssizlikKesilecekmi"), 0), dr("sSSKSicilNo").ToString, dr("sSSKStatusu").ToString, dr("sVergiStatusu").ToString, sorgu_sayi(dr("lTTFToplamOdenen"), 0), dr("sTTFNumarasi").ToString, sorgu_sayi(dr("bBrutUcretlimi"), 0), dr("sSaatGunlukAylik").ToString, dr("sUcretDovizCinsi").ToString, sorgu_sayi(dr("lBirimUcret"), 0), dr("sBankaHesapNo").ToString, dr("sBankaHesapNoKS").ToString, dr("dteIseGirisTarihi"), dr("dteIstenCikisTarihi"), dr("sCikisSebebi").ToString, sorgu_sayi(dr("bCalisiyormu"), 0), sorgu_sayi(dr("nCocukAd"), 0), sorgu_sayi(dr("nCocukAdOkulOncesi"), 0), sorgu_sayi(dr("nCocukAdIlkOgrenim"), 0), sorgu_sayi(dr("nCocukAdLise"), 0), sorgu_sayi(dr("nCocukAdYuksek"), 0), sorgu_sayi(dr("lOzelSagSigAylikPrimi"), 0), sorgu_sayi(dr("bSendikaUyesimi"), 0), dr("sResimAdi").ToString, dr("dteOzelSSBaslangic"), kullaniciadi, Now, sorgu_sayi(dr("lOzelEmekSigAylikPrimi"), 0))
            dr = ds_tbPersonelOzluk.Tables(0).Rows(0)
            tbPersonelOzluk_kaydet_duzelt(dr("nPersonelID"), dr("sPasaportNumarasi").ToString, sorgu_sayi(dr("bEhliyetiVarmi"), 0), dr("sEhliyetSinifi").ToString, dr("sVergiDairesi").ToString, dr("sVergiNo").ToString, sorgu_sayi(dr("bAskerliginiYaptimi"), 0), dr("dteTerhisTarihi"), sorgu_sayi(dr("nTecilSuresi"), 0), dr("sMernisNo").ToString, dr("sKimlikNo").ToString, dr("sBabaAdi").ToString, dr("sAnneAdi").ToString, dr("sDogumYeri").ToString, dr("dteDogumTarihi"), sorgu_sayi(dr("bEvlimi"), 0), dr("sKizlikSoyadi").ToString, sorgu_sayi(dr("bTCVatandasimi"), 0), dr("sUyrugu").ToString, dr("sDini").ToString, dr("sKanGrubu").ToString, dr("sKayitliIl").ToString, dr("sKayitliIlce").ToString, dr("sKayitliMahKoy").ToString, dr("sKayitliCiltNo").ToString, dr("sKayitliAileNo").ToString, dr("sKayitliSiraNo").ToString, dr("sVerildigiYer").ToString, dr("sVerilisNedeni").ToString, dr("sKayitNo").ToString, dr("dteVerilisTarihi"), dr("sEvAdresi1").ToString, dr("sEvAdresi2").ToString, dr("sEvSemt").ToString, dr("sEvPostaKodu").ToString, dr("sEvIl").ToString, dr("sEvTelefonu").ToString, dr("sCepTelefonu").ToString, dr("sE_Posta").ToString, dr("sAileTelefonu").ToString, sorgu_sayi(dr("bEskiHukumlumu"), 0), sorgu_sayi(dr("bEsiIcinAGIAlacak"), 0), sorgu_sayi(dr("nAGIAlacakCocukSayisi"), 0))
            dr = ds_tbPersonelMeslek.Tables(0).Rows(0)
            tbPersonelMeslek_kaydet_duzelt(dr("nPersonelID"), dr("sIlkOgrenim").ToString, dr("dteIlkBitisTarihi"), dr("sLise").ToString, dr("dteLiseBitisTarihi"), sorgu_sayi(dr("nYuksekOkulID1"), 1), sorgu_sayi(dr("nBolumID1"), 1), dr("dteYOBitisTarihi1"), sorgu_sayi(dr("nYuksekOkulID2"), 1), sorgu_sayi(dr("nBolumID2"), 1), dr("dteYOBitisTarihi2"), dr("sMeslek").ToString, sorgu_sayi(dr("nMeslekKidemi"), 0), dr("sSonIsyeri").ToString, dr("sSonIsyerindeUnvani").ToString, dr("sSonIsyeriAdresi1").ToString, dr("sSonIsyeriAdresi2").ToString, dr("sSonIsyeriSemt").ToString, dr("sSonIsyeriPostaKodu").ToString, dr("sSonIsyeriIl").ToString, dr("sSonSicilNo").ToString, dr("sSonKurum").ToString, sorgu_sayi(dr("nYabanciDilID1"), 1), sorgu_sayi(dr("nYDSeviye1"), 0), sorgu_sayi(dr("nYabanciDilID2"), 1), sorgu_sayi(dr("nYDSeviye2"), 0), sorgu_sayi(dr("nYabanciDilID3"), 1), sorgu_sayi(dr("nYDSeviye3"), 0), sorgu_sayi(dr("nOgrenimDurumu"), 0), dr("sOgrenimDurumuDiger").ToString, sorgu_sayi(dr("bAylikAliyormu"), 0), sorgu_sayi(dr("nSSKAylikAliyormu"), 0))
            Me.Close()
        ElseIf yeni = True Then
            If sec_sSaatGunlukAylik.SelectedIndex = 0 Then
                dr("sSaatGunlukAylik") = "S"
            ElseIf sec_sSaatGunlukAylik.SelectedIndex = 1 Then
                dr("sSaatGunlukAylik") = "G"
            ElseIf sec_sSaatGunlukAylik.SelectedIndex = 2 Then
                dr("sSaatGunlukAylik") = "A"
            End If
            dr("nCocukAd") = sorgu_sayi(dr("nCocukAdOkulOncesi"), 0) + sorgu_sayi(dr("nCocukAdIlkOgrenim"), 0) + sorgu_sayi(dr("nCocukAdLise"), 0) + sorgu_sayi(dr("nCocukAdYuksek"), 0)
            dr("sTTFNumarasi") = degeruzunlukkontrol(sec_sTTFNumarasi.EditValue, 5) & " " & degeruzunlukkontrol(sec_sMeslekKodu.EditValue, 4)
            nPersonelID = tbPersonel_kaydet_yeni(dr("nPersonelID"), sorgu_sayi(dr("lSicilNo"), 0), dr("sDepartmanKodu").ToString, dr("sAdi").ToString, dr("sIkinciAdi").ToString, dr("sSoyadi").ToString, sorgu_sayi(dr("nCinsiyet"), 0), dr("sAkedemikUnvani").ToString, dr("sUnvan").ToString, sorgu_sayi(dr("bSSKKesilecekmi"), 0), sorgu_sayi(dr("bIssizlikKesilecekmi"), 0), dr("sSSKSicilNo").ToString, dr("sSSKStatusu").ToString, dr("sVergiStatusu").ToString, sorgu_sayi(dr("lTTFToplamOdenen"), 0), dr("sTTFNumarasi").ToString, sorgu_sayi(dr("bBrutUcretlimi"), 0), dr("sSaatGunlukAylik").ToString, dr("sUcretDovizCinsi").ToString, sorgu_sayi(dr("lBirimUcret"), 0), dr("sBankaHesapNo").ToString, dr("sBankaHesapNoKS").ToString, dr("dteIseGirisTarihi"), dr("dteIstenCikisTarihi"), dr("sCikisSebebi").ToString, sorgu_sayi(dr("bCalisiyormu"), 0), sorgu_sayi(dr("nCocukAd"), 0), sorgu_sayi(dr("nCocukAdOkulOncesi"), 0), sorgu_sayi(dr("nCocukAdIlkOgrenim"), 0), sorgu_sayi(dr("nCocukAdLise"), 0), sorgu_sayi(dr("nCocukAdYuksek"), 0), sorgu_sayi(dr("lOzelSagSigAylikPrimi"), 0), sorgu_sayi(dr("bSendikaUyesimi"), 0), dr("sResimAdi").ToString, dr("dteOzelSSBaslangic"), kullaniciadi, Now, sorgu_sayi(dr("lOzelEmekSigAylikPrimi"), 0))
            tbPersonelOzluk_kaydet_yeni(dr("nPersonelID"), "", 0, "", "", "", 0, "01/01/1900", 0, "", "", "", "", "", "01/01/1900", 0, "", 1, "", "", "", "", "", "", "", "", "", "", "", "", "01/01/1900", "", "", "", "", "", "", "", "", "", 0, 0, 0)
            tbPersonelMeslek_kaydet_yeni(dr("nPersonelID"), "", "01/01/1900", "", "01/01/1900", 1, 1, "01/01/1900", 1, 1, "01/01/1900", "", 0, "", "", "", "", "", "", "", "", "", 1, 0, 1, 0, 1, 0, 1, "", 0, 0)
            yeni = False
            SimpleButton1.Text = "&Tamam"
            txt_lSicilNo.Enabled = False
            XtraTabPage2.PageEnabled = True
            XtraTabPage3.PageEnabled = True
            dataload(nPersonelID)
            txt_sAdi.Focus()
            txt_sAdi.SelectAll()
            'btn_KodBul.Enabled = False
        End If
    End Sub
    Private Function tbPersonel_kaydet_yeni(ByVal nPersonelID, ByVal lSicilNo, ByVal sDepartmanKodu, ByVal sAdi, ByVal sIkinciAdi, ByVal sSoyadi, ByVal nCinsiyet, ByVal sAkedemikUnvani, ByVal sUnvan, ByVal bSSKKesilecekmi, ByVal bIssizlikKesilecekmi, ByVal sSSKSicilNo, ByVal sSSKStatusu, ByVal sVergiStatusu, ByVal lTTFToplamOdenen, ByVal sTTFNumarasi, ByVal bBrutUcretlimi, ByVal sSaatGunlukAylik, ByVal sUcretDovizCinsi, ByVal lBirimUcret, ByVal sBankaHesapNo, ByVal sBankaHesapNoKS, ByVal dteIseGirisTarihi, ByVal dteIstenCikisTarihi, ByVal sCikisSebebi, ByVal bCalisiyormu, ByVal nCocukAd, ByVal nCocukAdOkulOncesi, ByVal nCocukAdIlkOgrenim, ByVal nCocukAdLise, ByVal nCocukAdYuksek, ByVal lOzelSagSigAylikPrimi, ByVal bSendikaUyesimi, ByVal sResimAdi, ByVal dteOzelSSBaslangic, ByVal sKullaniciAdi, ByVal dteKayitTarihi, ByVal lOzelEmekSigAylikPrimi) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbPersonel( lSicilNo, sDepartmanKodu, sAdi, sIkinciAdi, sSoyadi, nCinsiyet, sAkedemikUnvani, sUnvan, bSSKKesilecekmi, bIssizlikKesilecekmi, sSSKSicilNo, sSSKStatusu, sVergiStatusu, lTTFToplamOdenen, sTTFNumarasi, bBrutUcretlimi, sSaatGunlukAylik, sUcretDovizCinsi, lBirimUcret, sBankaHesapNo, sBankaHesapNoKS, dteIseGirisTarihi, dteIstenCikisTarihi, sCikisSebebi, bCalisiyormu, nCocukAd, nCocukAdOkulOncesi, nCocukAdIlkOgrenim, nCocukAdLise, nCocukAdYuksek, lOzelSagSigAylikPrimi, bSendikaUyesimi, sResimAdi, dteOzelSSBaslangic, sKullaniciAdi, dteKayitTarihi, lOzelEmekSigAylikPrimi) VALUES ( " & lSicilNo & ", '" & sDepartmanKodu & "', '" & sAdi & "', '" & sIkinciAdi & "', '" & sSoyadi & "', " & nCinsiyet & ", '" & sAkedemikUnvani & "', '" & sUnvan & "', " & bSSKKesilecekmi & ", " & bIssizlikKesilecekmi & ", '" & sSSKSicilNo & "', '" & sSSKStatusu & "', '" & sVergiStatusu & "', " & lTTFToplamOdenen & ", '" & sTTFNumarasi & "', " & bBrutUcretlimi & ", '" & sSaatGunlukAylik & "', '" & sUcretDovizCinsi & "', " & lBirimUcret & ", '" & sBankaHesapNo & "', '" & sBankaHesapNoKS & "', '" & dteIseGirisTarihi & "', '" & dteIstenCikisTarihi & "', '" & sCikisSebebi & "', " & bCalisiyormu & ", " & nCocukAd & ", " & nCocukAdOkulOncesi & ", " & nCocukAdIlkOgrenim & ", " & nCocukAdLise & ", " & nCocukAdYuksek & ", " & lOzelSagSigAylikPrimi & ", " & bSendikaUyesimi & ", '" & sResimAdi & "', '" & dteOzelSSBaslangic & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & lOzelEmekSigAylikPrimi & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Private Sub tbPersonel_kaydet_duzelt(ByVal nPersonelID, ByVal lSicilNo, ByVal sDepartmanKodu, ByVal sAdi, ByVal sIkinciAdi, ByVal sSoyadi, ByVal nCinsiyet, ByVal sAkedemikUnvani, ByVal sUnvan, ByVal bSSKKesilecekmi, ByVal bIssizlikKesilecekmi, ByVal sSSKSicilNo, ByVal sSSKStatusu, ByVal sVergiStatusu, ByVal lTTFToplamOdenen, ByVal sTTFNumarasi, ByVal bBrutUcretlimi, ByVal sSaatGunlukAylik, ByVal sUcretDovizCinsi, ByVal lBirimUcret, ByVal sBankaHesapNo, ByVal sBankaHesapNoKS, ByVal dteIseGirisTarihi, ByVal dteIstenCikisTarihi, ByVal sCikisSebebi, ByVal bCalisiyormu, ByVal nCocukAd, ByVal nCocukAdOkulOncesi, ByVal nCocukAdIlkOgrenim, ByVal nCocukAdLise, ByVal nCocukAdYuksek, ByVal lOzelSagSigAylikPrimi, ByVal bSendikaUyesimi, ByVal sResimAdi, ByVal dteOzelSSBaslangic, ByVal sKullaniciAdi, ByVal dteKayitTarihi, ByVal lOzelEmekSigAylikPrimi)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbPersonel SET lSicilNo = " & lSicilNo & ", sDepartmanKodu = '" & sDepartmanKodu & "', sAdi = '" & sAdi & "', sIkinciAdi = '" & sIkinciAdi & "', sSoyadi = '" & sSoyadi & "', nCinsiyet = " & nCinsiyet & ", sAkedemikUnvani = '" & sAkedemikUnvani & "', sUnvan = '" & sUnvan & "', bSSKKesilecekmi = " & bSSKKesilecekmi & ", bIssizlikKesilecekmi = " & bIssizlikKesilecekmi & ", sSSKSicilNo = '" & sSSKSicilNo & "', sSSKStatusu = '" & sSSKStatusu & "', sVergiStatusu = '" & sVergiStatusu & "', lTTFToplamOdenen = " & lTTFToplamOdenen & ", sTTFNumarasi = '" & sTTFNumarasi & "', bBrutUcretlimi = " & bBrutUcretlimi & ", sSaatGunlukAylik = '" & sSaatGunlukAylik & "', sUcretDovizCinsi = '" & sUcretDovizCinsi & "', lBirimUcret = " & lBirimUcret & ", sBankaHesapNo = '" & sBankaHesapNo & "', sBankaHesapNoKS = '" & sBankaHesapNoKS & "', dteIseGirisTarihi = '" & dteIseGirisTarihi & "', dteIstenCikisTarihi = '" & dteIstenCikisTarihi & "', sCikisSebebi = '" & sCikisSebebi & "', bCalisiyormu = " & bCalisiyormu & ", nCocukAd = " & nCocukAd & ", nCocukAdOkulOncesi = " & nCocukAdOkulOncesi & ", nCocukAdIlkOgrenim = " & nCocukAdIlkOgrenim & ", nCocukAdLise = " & nCocukAdLise & ", nCocukAdYuksek = " & nCocukAdYuksek & ", lOzelSagSigAylikPrimi = " & lOzelSagSigAylikPrimi & ", bSendikaUyesimi = " & bSendikaUyesimi & ", sResimAdi = '" & sResimAdi & "', dteOzelSSBaslangic = '" & dteOzelSSBaslangic & "',  lOzelEmekSigAylikPrimi = " & lOzelEmekSigAylikPrimi & "  Where nPersonelID = '" & nPersonelID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Function tbPersonelOzluk_kaydet_yeni(ByVal nPersonelID, ByVal sPasaportNumarasi, ByVal bEhliyetiVarmi, ByVal sEhliyetSinifi, ByVal sVergiDairesi, ByVal sVergiNo, ByVal bAskerliginiYaptimi, ByVal dteTerhisTarihi, ByVal nTecilSuresi, ByVal sMernisNo, ByVal sKimlikNo, ByVal sBabaAdi, ByVal sAnneAdi, ByVal sDogumYeri, ByVal dteDogumTarihi, ByVal bEvlimi, ByVal sKizlikSoyadi, ByVal bTCVatandasimi, ByVal sUyrugu, ByVal sDini, ByVal sKanGrubu, ByVal sKayitliIl, ByVal sKayitliIlce, ByVal sKayitliMahKoy, ByVal sKayitliCiltNo, ByVal sKayitliAileNo, ByVal sKayitliSiraNo, ByVal sVerildigiYer, ByVal sVerilisNedeni, ByVal sKayitNo, ByVal dteVerilisTarihi, ByVal sEvAdresi1, ByVal sEvAdresi2, ByVal sEvSemt, ByVal sEvPostaKodu, ByVal sEvIl, ByVal sEvTelefonu, ByVal sCepTelefonu, ByVal sE_Posta, ByVal sAileTelefonu, ByVal bEskiHukumlumu, ByVal bEsiIcinAGIAlacak, ByVal nAGIAlacakCocukSayisi) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbPersonelOzluk(nPersonelID, sPasaportNumarasi, bEhliyetiVarmi, sEhliyetSinifi, sVergiDairesi, sVergiNo, bAskerliginiYaptimi, dteTerhisTarihi, nTecilSuresi, sMernisNo, sKimlikNo, sBabaAdi, sAnneAdi, sDogumYeri, dteDogumTarihi, bEvlimi, sKizlikSoyadi, bTCVatandasimi, sUyrugu, sDini, sKanGrubu, sKayitliIl, sKayitliIlce, sKayitliMahKoy, sKayitliCiltNo, sKayitliAileNo, sKayitliSiraNo, sVerildigiYer, sVerilisNedeni, sKayitNo, dteVerilisTarihi, sEvAdresi1, sEvAdresi2, sEvSemt, sEvPostaKodu, sEvIl, sEvTelefonu, sCepTelefonu, sE_Posta, sAileTelefonu, bEskiHukumlumu, bEsiIcinAGIAlacak, nAGIAlacakCocukSayisi) VALUES (" & nPersonelID & ", '" & sPasaportNumarasi & "', " & bEhliyetiVarmi & ", '" & sEhliyetSinifi & "', '" & sVergiDairesi & "', '" & sVergiNo & "', " & bAskerliginiYaptimi & ", '" & dteTerhisTarihi & "', " & nTecilSuresi & ", '" & sMernisNo & "', '" & sKimlikNo & "', '" & sBabaAdi & "', '" & sAnneAdi & "', '" & sDogumYeri & "', '" & dteDogumTarihi & "', " & bEvlimi & ", '" & sKizlikSoyadi & "', " & bTCVatandasimi & ", '" & sUyrugu & "', '" & sDini & "', '" & sKanGrubu & "', '" & sKayitliIl & "', '" & sKayitliIlce & "', '" & sKayitliMahKoy & "', '" & sKayitliCiltNo & "', '" & sKayitliAileNo & "', '" & sKayitliSiraNo & "', '" & sVerildigiYer & "', '" & sVerilisNedeni & "', '" & sKayitNo & "', '" & dteVerilisTarihi & "', '" & sEvAdresi1 & "', '" & sEvAdresi2 & "', '" & sEvSemt & "', '" & sEvPostaKodu & "', '" & sEvIl & "', '" & sEvTelefonu & "', '" & sCepTelefonu & "', '" & sE_Posta & "', '" & sAileTelefonu & "', " & bEskiHukumlumu & ", " & bEsiIcinAGIAlacak & ", " & nAGIAlacakCocukSayisi & ")")
        cmd.ExecuteNonQuery()
        con.Close()
        Return nPersonelID
    End Function
    Private Sub tbPersonelOzluk_kaydet_duzelt(ByVal nPersonelID, ByVal sPasaportNumarasi, ByVal bEhliyetiVarmi, ByVal sEhliyetSinifi, ByVal sVergiDairesi, ByVal sVergiNo, ByVal bAskerliginiYaptimi, ByVal dteTerhisTarihi, ByVal nTecilSuresi, ByVal sMernisNo, ByVal sKimlikNo, ByVal sBabaAdi, ByVal sAnneAdi, ByVal sDogumYeri, ByVal dteDogumTarihi, ByVal bEvlimi, ByVal sKizlikSoyadi, ByVal bTCVatandasimi, ByVal sUyrugu, ByVal sDini, ByVal sKanGrubu, ByVal sKayitliIl, ByVal sKayitliIlce, ByVal sKayitliMahKoy, ByVal sKayitliCiltNo, ByVal sKayitliAileNo, ByVal sKayitliSiraNo, ByVal sVerildigiYer, ByVal sVerilisNedeni, ByVal sKayitNo, ByVal dteVerilisTarihi, ByVal sEvAdresi1, ByVal sEvAdresi2, ByVal sEvSemt, ByVal sEvPostaKodu, ByVal sEvIl, ByVal sEvTelefonu, ByVal sCepTelefonu, ByVal sE_Posta, ByVal sAileTelefonu, ByVal bEskiHukumlumu, ByVal bEsiIcinAGIAlacak, ByVal nAGIAlacakCocukSayisi)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbPersonelOzluk SET sPasaportNumarasi = '" & sPasaportNumarasi & "', bEhliyetiVarmi = " & bEhliyetiVarmi & ", sEhliyetSinifi = '" & sEhliyetSinifi & "', sVergiDairesi = '" & sVergiDairesi & "', sVergiNo = '" & sVergiNo & "', bAskerliginiYaptimi = " & bAskerliginiYaptimi & ", dteTerhisTarihi = '" & dteTerhisTarihi & "', nTecilSuresi = " & nTecilSuresi & ", sMernisNo = '" & sMernisNo & "', sKimlikNo = '" & sKimlikNo & "', sBabaAdi = '" & sBabaAdi & "', sAnneAdi = '" & sAnneAdi & "', sDogumYeri = '" & sDogumYeri & "', dteDogumTarihi = '" & dteDogumTarihi & "', bEvlimi = " & bEvlimi & ", sKizlikSoyadi = '" & sKizlikSoyadi & "', bTCVatandasimi = " & bTCVatandasimi & ", sUyrugu = '" & sUyrugu & "', sDini = '" & sDini & "', sKanGrubu = '" & sKanGrubu & "', sKayitliIl = '" & sKayitliIl & "', sKayitliIlce = '" & sKayitliIlce & "', sKayitliMahKoy = '" & sKayitliMahKoy & "', sKayitliCiltNo = '" & sKayitliCiltNo & "', sKayitliAileNo = '" & sKayitliAileNo & "', sKayitliSiraNo = '" & sKayitliSiraNo & "', sVerildigiYer = '" & sVerildigiYer & "', sVerilisNedeni = '" & sVerilisNedeni & "', sKayitNo = '" & sKayitNo & "', dteVerilisTarihi = '" & dteVerilisTarihi & "', sEvAdresi1 = '" & sEvAdresi1 & "', sEvAdresi2 = '" & sEvAdresi2 & "', sEvSemt = '" & sEvSemt & "', sEvPostaKodu = '" & sEvPostaKodu & "', sEvIl = '" & sEvIl & "', sEvTelefonu = '" & sEvTelefonu & "', sCepTelefonu = '" & sCepTelefonu & "', sE_Posta = '" & sE_Posta & "', sAileTelefonu = '" & sAileTelefonu & "', bEskiHukumlumu = " & bEskiHukumlumu & ", bEsiIcinAGIAlacak = " & bEsiIcinAGIAlacak & ", nAGIAlacakCocukSayisi = " & nAGIAlacakCocukSayisi & "  Where nPersonelID = '" & nPersonelID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Function tbPersonelMeslek_kaydet_yeni(ByVal nPersonelID, ByVal sIlkOgrenim, ByVal dteIlkBitisTarihi, ByVal sLise, ByVal dteLiseBitisTarihi, ByVal nYuksekOkulID1, ByVal nBolumID1, ByVal dteYOBitisTarihi1, ByVal nYuksekOkulID2, ByVal nBolumID2, ByVal dteYOBitisTarihi2, ByVal sMeslek, ByVal nMeslekKidemi, ByVal sSonIsyeri, ByVal sSonIsyerindeUnvani, ByVal sSonIsyeriAdresi1, ByVal sSonIsyeriAdresi2, ByVal sSonIsyeriSemt, ByVal sSonIsyeriPostaKodu, ByVal sSonIsyeriIl, ByVal sSonSicilNo, ByVal sSonKurum, ByVal nYabanciDilID1, ByVal nYDSeviye1, ByVal nYabanciDilID2, ByVal nYDSeviye2, ByVal nYabanciDilID3, ByVal nYDSeviye3, ByVal nOgrenimDurumu, ByVal sOgrenimDurumuDiger, ByVal bAylikAliyormu, ByVal nSSKAylikAliyormu) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbPersonelMeslek(nPersonelID, sIlkOgrenim, dteIlkBitisTarihi, sLise, dteLiseBitisTarihi, nYuksekOkulID1, nBolumID1, dteYOBitisTarihi1, nYuksekOkulID2, nBolumID2, dteYOBitisTarihi2, sMeslek, nMeslekKidemi, sSonIsyeri, sSonIsyerindeUnvani, sSonIsyeriAdresi1, sSonIsyeriAdresi2, sSonIsyeriSemt, sSonIsyeriPostaKodu, sSonIsyeriIl, sSonSicilNo, sSonKurum, nYabanciDilID1, nYDSeviye1, nYabanciDilID2, nYDSeviye2, nYabanciDilID3, nYDSeviye3, nOgrenimDurumu, sOgrenimDurumuDiger, bAylikAliyormu, nSSKAylikAliyormu) VALUES (" & nPersonelID & ", '" & sIlkOgrenim & "', '" & dteIlkBitisTarihi & "', '" & sLise & "', '" & dteLiseBitisTarihi & "', " & nYuksekOkulID1 & ", " & nBolumID1 & ", '" & dteYOBitisTarihi1 & "', " & nYuksekOkulID2 & ", " & nBolumID2 & ", '" & dteYOBitisTarihi2 & "', '" & sMeslek & "', " & nMeslekKidemi & ", '" & sSonIsyeri & "', '" & sSonIsyerindeUnvani & "', '" & sSonIsyeriAdresi1 & "', '" & sSonIsyeriAdresi2 & "', '" & sSonIsyeriSemt & "', '" & sSonIsyeriPostaKodu & "', '" & sSonIsyeriIl & "', '" & sSonSicilNo & "', '" & sSonKurum & "', " & nYabanciDilID1 & ", " & nYDSeviye1 & ", " & nYabanciDilID2 & ", " & nYDSeviye2 & ", " & nYabanciDilID3 & ", " & nYDSeviye3 & ", " & nOgrenimDurumu & ", '" & sOgrenimDurumuDiger & "', " & bAylikAliyormu & ", " & nSSKAylikAliyormu & ")")
        cmd.ExecuteNonQuery()
        con.Close()
        Return nPersonelID
    End Function
    Private Sub tbPersonelMeslek_kaydet_duzelt(ByVal nPersonelID, ByVal sIlkOgrenim, ByVal dteIlkBitisTarihi, ByVal sLise, ByVal dteLiseBitisTarihi, ByVal nYuksekOkulID1, ByVal nBolumID1, ByVal dteYOBitisTarihi1, ByVal nYuksekOkulID2, ByVal nBolumID2, ByVal dteYOBitisTarihi2, ByVal sMeslek, ByVal nMeslekKidemi, ByVal sSonIsyeri, ByVal sSonIsyerindeUnvani, ByVal sSonIsyeriAdresi1, ByVal sSonIsyeriAdresi2, ByVal sSonIsyeriSemt, ByVal sSonIsyeriPostaKodu, ByVal sSonIsyeriIl, ByVal sSonSicilNo, ByVal sSonKurum, ByVal nYabanciDilID1, ByVal nYDSeviye1, ByVal nYabanciDilID2, ByVal nYDSeviye2, ByVal nYabanciDilID3, ByVal nYDSeviye3, ByVal nOgrenimDurumu, ByVal sOgrenimDurumuDiger, ByVal bAylikAliyormu, ByVal nSSKAylikAliyormu)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbPersonelMeslek SET sIlkOgrenim = '" & sIlkOgrenim & "', dteIlkBitisTarihi = '" & dteIlkBitisTarihi & "', sLise = '" & sLise & "', dteLiseBitisTarihi = '" & dteLiseBitisTarihi & "', nYuksekOkulID1 = " & nYuksekOkulID1 & ", nBolumID1 = " & nBolumID1 & ", dteYOBitisTarihi1 = '" & dteYOBitisTarihi1 & "', nYuksekOkulID2 = " & nYuksekOkulID2 & ", nBolumID2 = " & nBolumID2 & ", dteYOBitisTarihi2 = '" & dteYOBitisTarihi2 & "', sMeslek = '" & sMeslek & "', nMeslekKidemi = " & nMeslekKidemi & ", sSonIsyeri = '" & sSonIsyeri & "', sSonIsyerindeUnvani = '" & sSonIsyerindeUnvani & "', sSonIsyeriAdresi1 = '" & sSonIsyeriAdresi1 & "', sSonIsyeriAdresi2 = '" & sSonIsyeriAdresi2 & "', sSonIsyeriSemt = '" & sSonIsyeriSemt & "', sSonIsyeriPostaKodu = '" & sSonIsyeriPostaKodu & "', sSonIsyeriIl = '" & sSonIsyeriIl & "', sSonSicilNo = '" & sSonSicilNo & "', sSonKurum = '" & sSonKurum & "', nYabanciDilID1 =" & nYabanciDilID1 & ", nYDSeviye1 = " & nYDSeviye1 & ", nYabanciDilID2 = " & nYabanciDilID2 & ", nYDSeviye2 = " & nYDSeviye2 & ", nYabanciDilID3 = " & nYabanciDilID3 & ", nYDSeviye3 = " & nYDSeviye3 & ", nOgrenimDurumu = " & nOgrenimDurumu & ", sOgrenimDurumuDiger = '" & sOgrenimDurumuDiger & "', bAylikAliyormu = " & bAylikAliyormu & ", nSSKAylikAliyormu = " & nSSKAylikAliyormu & "  Where nPersonelID = " & nPersonelID & "")
        cmd.ExecuteNonQuery()
        con.Close()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub tbPersonelEgitim_kaydet_yeni(ByVal nEgitimID As Int64, ByVal nPersonelID As Int64, ByVal sEgitimTipi As String, ByVal dteBaslangicTarihi As DateTime, ByVal dteBitisTarihi As DateTime, ByVal sAciklama As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        nEgitimID = sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nEgitimID), 0) + 1 AS nEgitimID FROM         tbPersonelEgitim")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbPersonelEgitim                       (nEgitimID,nPersonelID, sEgitimTipi, dteBaslangicTarihi, dteBitisTarihi, sAciklama) VALUES     (" & nEgitimID & "," & nPersonelID & ", '" & sEgitimTipi & "', '" & dteBaslangicTarihi & "', '" & dteBitisTarihi & "', '" & sAciklama & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbPersonelEgitim_kaydet_duzelt(ByVal nEgitimID As Int64, ByVal nPersonelID As Int64, ByVal sEgitimTipi As String, ByVal dteBaslangicTarihi As DateTime, ByVal dteBitisTarihi As DateTime, ByVal sAciklama As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbPersonelEgitim SET              sEgitimTipi = '" & sEgitimTipi & "', dteBaslangicTarihi = '" & dteBaslangicTarihi & "', dteBitisTarihi = '" & dteBitisTarihi & "',                        sAciklama = '" & sAciklama & "' Where nEgitimID = '" & nEgitimID & "' and nPersonelID ='" & nPersonelID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbPersonelEgitim_Satir_sil()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow
            Dim satir
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            satir = GridView2.FocusedRowHandle
            If XtraMessageBox.Show(dr("nEgitimID") & vbTab & Sorgu_sDil(" Nolu Eğitim Kaydını Silmek istediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                tbPersonelEgitim_kaydet_sil(dr("nEgitimID"), dr("nPersonelID"))
            End If
            ds_tbPersonelEgitim = Dataload_tbPersonelEgitim(nPersonelID)
            GridControl2.DataSource = ds_tbPersonelEgitim.Tables(0)
            GridControl2.DataMember = Nothing
            GridView2.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub tbPersonelEgitim_kaydet_sil(ByVal nEgitimID As String, ByVal nPersonelID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbPersonelEgitim  Where nEgitimID = '" & nEgitimID & "' and nPersonelID ='" & nPersonelID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub egitim_ekle()
        tbPersonelEgitim_kaydet_yeni(0, nPersonelID, "", dteSistemTarihi, dteSistemTarihi, "")
        ds_tbPersonelEgitim = Dataload_tbPersonelEgitim(nPersonelID)
        GridControl2.DataSource = ds_tbPersonelEgitim.Tables(0)
        GridControl2.DataMember = Nothing
        GridView2.FocusedRowHandle = GridView2.RowCount - 1
        GridControl2.Focus()
        GridControl2.Select()
        GridView2.FocusedColumn = colsEgitimTipi
    End Sub
    Private Sub egitim_sil()
        tbPersonelEgitim_Satir_sil()
    End Sub
    Private Sub egitim_yazdir()
        GridControl2.ShowPrintPreview()
    End Sub
    Private Sub tbPersonelYakini_kaydet_yeni(ByVal nYakinID As Int64, ByVal nPersonelID As Int64, ByVal sAdi As String, ByVal sSoyadi As String, ByVal sYakinlikDerecesi As String, ByVal dteDogumTarihi As DateTime, ByVal sAdresi1 As String, ByVal sAdresi2 As String, ByVal sSemt As String, ByVal sPostaKodu As String, ByVal sIl As String, ByVal sTelefonu As String, ByVal sCepTelefonu As String, ByVal sE_Posta As String, ByVal sNot As String, ByVal sKimlikNo As String, ByVal sDogumYeri As String, ByVal bTCVatandasimi As Byte, ByVal sUyrugu As String, ByVal nCinsiyet As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        nYakinID = sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nYakinID), 0) + 1 AS nYakinID FROM         tbPersonelYakini")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbPersonelYakini                       (nYakinID, nPersonelID, sAdi, sSoyadi, sYakinlikDerecesi, dteDogumTarihi, sAdresi1, sAdresi2, sSemt, sPostaKodu, sIl, sTelefonu, sCepTelefonu, sE_Posta, sNot,  sKimlikNo, sDogumYeri, bTCVatandasimi, sUyrugu, nCinsiyet) VALUES     (" & nYakinID & ", " & nPersonelID & ", '" & sAdi & "', '" & sSoyadi & "', '" & sYakinlikDerecesi & "', '" & dteDogumTarihi & "', '" & sAdresi1 & "', '" & sAdresi2 & "', '" & sSemt & "', '" & sPostaKodu & "', '" & sIl & "', '" & sTelefonu & "', '" & sCepTelefonu & "', '" & sE_Posta & "', '" & sNot & "', '" & sKimlikNo & "', '" & sDogumYeri & "', " & bTCVatandasimi & ", '" & sUyrugu & "', " & nCinsiyet & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbPersonelYakini_kaydet_duzelt(ByVal nYakinID As Int64, ByVal nPersonelID As Int64, ByVal sAdi As String, ByVal sSoyadi As String, ByVal sYakinlikDerecesi As String, ByVal dteDogumTarihi As DateTime, ByVal sAdresi1 As String, ByVal sAdresi2 As String, ByVal sSemt As String, ByVal sPostaKodu As String, ByVal sIl As String, ByVal sTelefonu As String, ByVal sCepTelefonu As String, ByVal sE_Posta As String, ByVal sNot As String, ByVal sKimlikNo As String, ByVal sDogumYeri As String, ByVal bTCVatandasimi As Byte, ByVal sUyrugu As String, ByVal nCinsiyet As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbPersonelYakini SET              sAdi = '" & sAdi & "', sSoyadi = '" & sSoyadi & "', sYakinlikDerecesi = '" & sYakinlikDerecesi & "', dteDogumTarihi = '" & dteDogumTarihi & "',                        sAdresi1 = '" & sAdresi1 & "', sAdresi2 = '" & sAdresi2 & "', sSemt = '" & sSemt & "', sPostaKodu = '" & sPostaKodu & "', sIl = '" & sIl & "', sTelefonu = '" & sTelefonu & "', sCepTelefonu = '" & sCepTelefonu & "',                        sE_Posta = '" & sE_Posta & "', sNot = '" & sNot & "', sKimlikNo = '" & sKimlikNo & "', sDogumYeri = '" & sDogumYeri & "', bTCVatandasimi = " & bTCVatandasimi & ", sUyrugu = '" & sUyrugu & "', nCinsiyet = " & nCinsiyet & " Where nYakinID = '" & nYakinID & "' and nPersonelID ='" & nPersonelID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbPersonelYakini_Satir_sil()
        If GridView3.RowCount > 0 Then
            Dim dr As DataRow
            Dim satir
            dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            satir = GridView3.FocusedRowHandle
            If XtraMessageBox.Show(dr("nYakinID") & vbTab & Sorgu_sDil(" Nolu Personel Yakını Kaydını Silmek istediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                tbPersonelYakini_kaydet_sil(dr("nYakinID"), dr("nPersonelID"))
            End If
            ds_tbPersonelYakini = Dataload_tbPersonelYakini(nPersonelID)
            GridControl3.DataSource = ds_tbPersonelYakini.Tables(0)
            GridControl3.DataMember = Nothing
            GridView3.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub tbPersonelYakini_kaydet_sil(ByVal nYakinID As String, ByVal nPersonelID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbPersonelYakini  Where nYakinID = '" & nYakinID & "' and nPersonelID ='" & nPersonelID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub yakin_ekle()
        tbPersonelYakini_kaydet_yeni(0, nPersonelID, "", "", "A", "01/01/1900", "", "", "", "", "", "", "", "", "", "", "", 1, "", 1)
        ds_tbPersonelYakini = Dataload_tbPersonelYakini(nPersonelID)
        GridControl3.DataSource = ds_tbPersonelYakini.Tables(0)
        GridControl3.DataMember = Nothing
        GridView3.FocusedRowHandle = GridView3.RowCount - 1
        GridControl3.Focus()
        GridControl3.Select()
        GridView3.FocusedColumn = colsYakinlikDerecesi
    End Sub
    Private Sub yakin_sil()
        tbPersonelYakini_Satir_sil()
    End Sub
    Private Sub yakinlik_yazdir()
        GridControl3.ShowPrintPreview()
    End Sub
    Private Sub tbPersonelIzini_kaydet_yeni(ByVal nPersonelID As Int64, ByVal dteIzinTarihi As DateTime, ByVal sIzinTipi As String, ByVal bUcretlimi As Byte, ByVal sMazaret As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbPersonelIzini                       (nPersonelID, dteIzinTarihi, sIzinTipi, bUcretlimi, sMazaret) VALUES     (" & nPersonelID & ", '" & dteIzinTarihi & "', '" & sIzinTipi & "', " & bUcretlimi & ", '" & sMazaret & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbPersonelIzini_kaydet_duzelt(ByVal nPersonelID As Int64, ByVal dteIzinTarihi As DateTime, ByVal sIzinTipi As String, ByVal bUcretlimi As Byte, ByVal sMazaret As String, ByVal dteEskiIzinTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbPersonelIzini SET              dteIzinTarihi = '" & dteIzinTarihi & "', sIzinTipi = '" & sIzinTipi & "', bUcretlimi = " & bUcretlimi & ", sMazaret = '" & sMazaret & "' Where dteIzinTarihi = '" & dteEskiIzinTarihi & "' and nPersonelID ='" & nPersonelID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbPersonelIzini_Satir_sil()
        If GridView4.RowCount > 0 Then
            Dim dr As DataRow
            Dim satir
            dr = GridView4.GetDataRow(GridView3.FocusedRowHandle)
            satir = GridView4.FocusedRowHandle
            If XtraMessageBox.Show(dr("dteIzinTarihi") & vbTab & Sorgu_sDil(" Tarihli İzin Kaydını Silmek istediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                tbPersonelYakini_kaydet_sil(dr("dteIzinTarihi"), dr("nPersonelID"))
            End If
            ds_tbPersonelIzini = Dataload_tbPersonelIzini(nPersonelID)
            GridControl4.DataSource = ds_tbPersonelIzini.Tables(0)
            GridControl4.DataMember = Nothing
            GridView4.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub tbPersonelIzini_kaydet_sil(ByVal dteIzinTarihi As DateTime, ByVal nPersonelID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbPersonelIzini  Where dteIzinTarihi = '" & dteIzinTarihi & "' and nPersonelID ='" & nPersonelID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub Izin_ekle()
        tbPersonelIzini_kaydet_yeni(nPersonelID, dteSistemTarihi, "N", 1, "")
        ds_tbPersonelIzini = Dataload_tbPersonelIzini(nPersonelID)
        GridControl4.DataSource = ds_tbPersonelIzini.Tables(0)
        GridControl4.DataMember = Nothing
        GridView4.FocusedRowHandle = GridView4.RowCount - 1
        GridControl4.Focus()
        GridControl4.Select()
        GridView4.FocusedColumn = colsIzinTipi
    End Sub
    Private Sub Izin_sil()
        tbPersonelIzini_Satir_sil()
    End Sub
    Private Sub Izin_yazdir()
        GridControl4.ShowPrintPreview()
    End Sub
    Private Sub tbPersonelKumSigorta_kaydet_yeni(ByVal nPersonelID As Int64, ByVal nYil As Int64, ByVal nGun1 As Decimal, ByVal lMatrah1 As Decimal, ByVal lIssislikPrimi1 As Decimal, ByVal nGun2 As Decimal, ByVal lMatrah2 As Decimal, ByVal lIssislikPrimi2 As Decimal, ByVal nGun3 As Decimal, ByVal lMatrah3 As Decimal, ByVal lIssislikPrimi3 As Decimal, ByVal nGun4 As Decimal, ByVal lMatrah4 As Decimal, ByVal lIssislikPrimi4 As Decimal, ByVal nGun5 As Decimal, ByVal lMatrah5 As Decimal, ByVal lIssislikPrimi5 As Decimal, ByVal nGun6 As Decimal, ByVal lMatrah6 As Decimal, ByVal lIssislikPrimi6 As Decimal, ByVal nGun7 As Decimal, ByVal lMatrah7 As Decimal, ByVal lIssislikPrimi7 As Decimal, ByVal nGun8 As Decimal, ByVal lMatrah8 As Decimal, ByVal lIssislikPrimi8 As Decimal, ByVal nGun9 As Decimal, ByVal lMatrah9 As Decimal, ByVal lIssislikPrimi9 As Decimal, ByVal nGun10 As Decimal, ByVal lMatrah10 As Decimal, ByVal lIssislikPrimi10 As Decimal, ByVal nGun11 As Decimal, ByVal lMatrah11 As Decimal, ByVal lIssislikPrimi11 As Decimal, ByVal nGun12 As Decimal, ByVal lMatrah12 As Decimal, ByVal lIssislikPrimi12 As Decimal, ByVal bKullaniciGirdi1 As Byte, ByVal bKullaniciGirdi2 As Byte, ByVal bKullaniciGirdi3 As Byte, ByVal bKullaniciGirdi4 As Byte, ByVal bKullaniciGirdi5 As Byte, ByVal bKullaniciGirdi6 As Byte, ByVal bKullaniciGirdi7 As Byte, ByVal bKullaniciGirdi8 As Byte, ByVal bKullaniciGirdi9 As Byte, ByVal bKullaniciGirdi10 As Byte, ByVal bKullaniciGirdi11 As Byte, ByVal bKullaniciGirdi12 As Byte)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbPersonelKumSigorta(nPersonelID, nYil, nGun1, lMatrah1, lIssislikPrimi1, nGun2, lMatrah2, lIssislikPrimi2, nGun3, lMatrah3, lIssislikPrimi3, nGun4, lMatrah4, lIssislikPrimi4, nGun5, lMatrah5, lIssislikPrimi5, nGun6, lMatrah6, lIssislikPrimi6, nGun7, lMatrah7, lIssislikPrimi7, nGun8, lMatrah8, lIssislikPrimi8, nGun9, lMatrah9, lIssislikPrimi9, nGun10, lMatrah10, lIssislikPrimi10, nGun11, lMatrah11, lIssislikPrimi11, nGun12, lMatrah12, lIssislikPrimi12, bKullaniciGirdi1, bKullaniciGirdi2, bKullaniciGirdi3, bKullaniciGirdi4, bKullaniciGirdi5, bKullaniciGirdi6, bKullaniciGirdi7, bKullaniciGirdi8, bKullaniciGirdi9, bKullaniciGirdi10, bKullaniciGirdi11, bKullaniciGirdi12) VALUES (" & nPersonelID & ", " & nYil & ", " & nGun1 & ", " & lMatrah1 & ", " & lIssislikPrimi1 & ", " & nGun2 & ", " & lMatrah2 & ", " & lIssislikPrimi2 & ", " & nGun3 & ", " & lMatrah3 & ", " & lIssislikPrimi3 & ", " & nGun4 & ", " & lMatrah4 & ", " & lIssislikPrimi4 & ", " & nGun5 & ", " & lMatrah5 & ", " & lIssislikPrimi5 & ", " & nGun6 & ", " & lMatrah6 & ", " & lIssislikPrimi6 & ", " & nGun7 & ", " & lMatrah7 & ", " & lIssislikPrimi7 & ", " & nGun8 & ", " & lMatrah8 & ", " & lIssislikPrimi8 & ", " & nGun9 & ", " & lMatrah9 & ", " & lIssislikPrimi9 & ", " & nGun10 & ", " & lMatrah10 & ", " & lIssislikPrimi10 & ", " & nGun11 & ", " & lMatrah11 & ", " & lIssislikPrimi11 & ", " & nGun12 & ", " & lMatrah12 & ", " & lIssislikPrimi12 & ", " & bKullaniciGirdi1 & ", " & bKullaniciGirdi2 & ", " & bKullaniciGirdi3 & ", " & bKullaniciGirdi4 & ", " & bKullaniciGirdi5 & ", " & bKullaniciGirdi6 & ", " & bKullaniciGirdi7 & ", " & bKullaniciGirdi8 & ", " & bKullaniciGirdi9 & ", " & bKullaniciGirdi10 & ", " & bKullaniciGirdi11 & ", " & bKullaniciGirdi12 & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbPersonelKumSigorta_kaydet_duzelt(ByVal nPersonelID As Int64, ByVal nYil As Int64, ByVal nGun1 As Decimal, ByVal lMatrah1 As Decimal, ByVal lIssislikPrimi1 As Decimal, ByVal nGun2 As Decimal, ByVal lMatrah2 As Decimal, ByVal lIssislikPrimi2 As Decimal, ByVal nGun3 As Decimal, ByVal lMatrah3 As Decimal, ByVal lIssislikPrimi3 As Decimal, ByVal nGun4 As Decimal, ByVal lMatrah4 As Decimal, ByVal lIssislikPrimi4 As Decimal, ByVal nGun5 As Decimal, ByVal lMatrah5 As Decimal, ByVal lIssislikPrimi5 As Decimal, ByVal nGun6 As Decimal, ByVal lMatrah6 As Decimal, ByVal lIssislikPrimi6 As Decimal, ByVal nGun7 As Decimal, ByVal lMatrah7 As Decimal, ByVal lIssislikPrimi7 As Decimal, ByVal nGun8 As Decimal, ByVal lMatrah8 As Decimal, ByVal lIssislikPrimi8 As Decimal, ByVal nGun9 As Decimal, ByVal lMatrah9 As Decimal, ByVal lIssislikPrimi9 As Decimal, ByVal nGun10 As Decimal, ByVal lMatrah10 As Decimal, ByVal lIssislikPrimi10 As Decimal, ByVal nGun11 As Decimal, ByVal lMatrah11 As Decimal, ByVal lIssislikPrimi11 As Decimal, ByVal nGun12 As Decimal, ByVal lMatrah12 As Decimal, ByVal lIssislikPrimi12 As Decimal, ByVal bKullaniciGirdi1 As Byte, ByVal bKullaniciGirdi2 As Byte, ByVal bKullaniciGirdi3 As Byte, ByVal bKullaniciGirdi4 As Byte, ByVal bKullaniciGirdi5 As Byte, ByVal bKullaniciGirdi6 As Byte, ByVal bKullaniciGirdi7 As Byte, ByVal bKullaniciGirdi8 As Byte, ByVal bKullaniciGirdi9 As Byte, ByVal bKullaniciGirdi10 As Byte, ByVal bKullaniciGirdi11 As Byte, ByVal bKullaniciGirdi12 As Byte, ByVal nEskiYil As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbPersonelKumSigorta SET nYil = " & nYil & ",nGun1 = " & nGun1 & ", lMatrah1 = " & lMatrah1 & ", lIssislikPrimi1 = " & lIssislikPrimi1 & ", nGun2 = " & nGun2 & ", lMatrah2 = " & lMatrah2 & ", lIssislikPrimi2 = " & lIssislikPrimi2 & ", nGun3 = " & nGun3 & ", lMatrah3 = " & lMatrah3 & ", lIssislikPrimi3 = " & lIssislikPrimi3 & ", nGun4 = " & nGun4 & ", lMatrah4 = " & lMatrah4 & ", lIssislikPrimi4 = " & lIssislikPrimi4 & ", nGun5 = " & nGun5 & ", lMatrah5 = " & lMatrah5 & ", lIssislikPrimi5 = " & lIssislikPrimi5 & ", nGun6 = " & nGun6 & ", lMatrah6 = " & lMatrah6 & ", lIssislikPrimi6 = " & lIssislikPrimi6 & ", nGun7 = " & nGun7 & ", lMatrah7 = " & lMatrah7 & ", lIssislikPrimi7 = " & lIssislikPrimi7 & ", nGun8 = " & nGun8 & ", lMatrah8 = " & lMatrah8 & ", lIssislikPrimi8 = " & lIssislikPrimi8 & ", nGun9 = " & nGun9 & ", lMatrah9 = " & lMatrah9 & ", lIssislikPrimi9 = " & lIssislikPrimi9 & ", nGun10 = " & nGun10 & ", lMatrah10 = " & lMatrah10 & ", lIssislikPrimi10 = " & lIssislikPrimi10 & ", nGun11 = " & nGun11 & ", lMatrah11 = " & lMatrah11 & ", lIssislikPrimi11 = " & lIssislikPrimi11 & ", nGun12 = " & nGun12 & ", lMatrah12 = " & lMatrah12 & ", lIssislikPrimi12 = " & lIssislikPrimi12 & ", bKullaniciGirdi1 = " & bKullaniciGirdi1 & ", bKullaniciGirdi2 = " & bKullaniciGirdi2 & ", bKullaniciGirdi3 = " & bKullaniciGirdi3 & ", bKullaniciGirdi4 = " & bKullaniciGirdi4 & ", bKullaniciGirdi5 = " & bKullaniciGirdi5 & ",  bKullaniciGirdi6 = " & bKullaniciGirdi6 & ", bKullaniciGirdi7 = " & bKullaniciGirdi7 & ", bKullaniciGirdi8 =" & bKullaniciGirdi8 & ", bKullaniciGirdi9 = " & bKullaniciGirdi9 & ", bKullaniciGirdi10 = " & bKullaniciGirdi10 & ", bKullaniciGirdi11 = " & bKullaniciGirdi11 & ", bKullaniciGirdi12 = " & bKullaniciGirdi12 & " Where nYil = '" & nEskiYil & "' and nPersonelID ='" & nPersonelID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbPersonelKumSigorta_Satir_sil()
        If GridControl5.Rows.Count > 0 Then
            Dim dr As DataRow
            Dim satir
            dr = ds_tbPersonelKumSigorta.Tables(0).Rows(GridControl5.FocusedRecord)
            satir = GridControl5.FocusedRecord
            If XtraMessageBox.Show(dr("nYil") & vbTab & Sorgu_sDil(" Yılı Kümülatif Sigorta Kaydını Silmek istediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                tbPersonelKumSigorta_kaydet_sil(dr("nYil"), dr("nPersonelID"))
            End If
            ds_tbPersonelKumSigorta = Dataload_tbPersonelKumSigorta(nPersonelID)
            GridControl5.DataSource = ds_tbPersonelKumSigorta.Tables(0)
            GridControl5.DataMember = Nothing
            GridControl5.FocusedRecord = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub tbPersonelKumSigorta_kaydet_sil(ByVal dteIzinTarihi As DateTime, ByVal nPersonelID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbPersonelIzini  Where dteIzinTarihi = '" & dteIzinTarihi & "' and nPersonelID ='" & nPersonelID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub KumSigorta_ekle()
        tbPersonelKumSigorta_kaydet_yeni(nPersonelID, Now.Year, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
        ds_tbPersonelKumSigorta = Dataload_tbPersonelKumSigorta(nPersonelID)
        GridControl5.DataSource = ds_tbPersonelKumSigorta.Tables(0)
        GridControl5.DataMember = Nothing
        GridControl5.Focus()
        GridControl5.Select()
    End Sub
    Private Sub KumSigorta_sil()
        tbPersonelKumSigorta_Satir_sil()
    End Sub
    Private Sub KumSigorta_yazdir()
        GridControl5.ShowRibbonPrintPreview()
    End Sub
    Private Sub tbPersonelKumVergi_kaydet_yeni(ByVal nPersonelID As Int64, ByVal nYil As Int64, ByVal lMatrah1 As Decimal, ByVal lMatrah2 As Decimal, ByVal lMatrah3 As Decimal, ByVal lMatrah4 As Decimal, ByVal lMatrah5 As Decimal, ByVal lMatrah6 As Decimal, ByVal lMatrah7 As Decimal, ByVal lMatrah8 As Decimal, ByVal lMatrah9 As Decimal, ByVal lMatrah10 As Decimal, ByVal lMatrah11 As Decimal, ByVal lMatrah12 As Decimal, ByVal bKullaniciGirdi1 As Byte, ByVal bKullaniciGirdi2 As Byte, ByVal bKullaniciGirdi3 As Byte, ByVal bKullaniciGirdi4 As Byte, ByVal bKullaniciGirdi5 As Byte, ByVal bKullaniciGirdi6 As Byte, ByVal bKullaniciGirdi7 As Byte, ByVal bKullaniciGirdi8 As Byte, ByVal bKullaniciGirdi9 As Byte, ByVal bKullaniciGirdi10 As Byte, ByVal bKullaniciGirdi11 As Byte, ByVal bKullaniciGirdi12 As Byte)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbPersonelKumVergi(nPersonelID, nYil,  lMatrah1, lMatrah2,  lMatrah3,  lMatrah4,  lMatrah5,  lMatrah6, lMatrah7,  lMatrah8,  lMatrah9,  lMatrah10,  lMatrah11,  lMatrah12,  bKullaniciGirdi1, bKullaniciGirdi2, bKullaniciGirdi3, bKullaniciGirdi4, bKullaniciGirdi5, bKullaniciGirdi6, bKullaniciGirdi7, bKullaniciGirdi8, bKullaniciGirdi9, bKullaniciGirdi10, bKullaniciGirdi11, bKullaniciGirdi12) VALUES (" & nPersonelID & ", " & nYil & ",  " & lMatrah1 & ",  " & lMatrah2 & ",  " & lMatrah3 & ",  " & lMatrah4 & ",  " & lMatrah5 & ",  " & lMatrah6 & ",  " & lMatrah7 & ",  " & lMatrah8 & ",  " & lMatrah9 & ",  " & lMatrah10 & ",  " & lMatrah11 & ",  " & lMatrah12 & ",  " & bKullaniciGirdi1 & ", " & bKullaniciGirdi2 & ", " & bKullaniciGirdi3 & ", " & bKullaniciGirdi4 & ", " & bKullaniciGirdi5 & ", " & bKullaniciGirdi6 & ", " & bKullaniciGirdi7 & ", " & bKullaniciGirdi8 & ", " & bKullaniciGirdi9 & ", " & bKullaniciGirdi10 & ", " & bKullaniciGirdi11 & ", " & bKullaniciGirdi12 & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbPersonelKumVergi_kaydet_duzelt(ByVal nPersonelID As Int64, ByVal nYil As Int64, ByVal lMatrah1 As Decimal, ByVal lMatrah2 As Decimal, ByVal lMatrah3 As Decimal, ByVal lMatrah4 As Decimal, ByVal lMatrah5 As Decimal, ByVal lMatrah6 As Decimal, ByVal lMatrah7 As Decimal, ByVal lMatrah8 As Decimal, ByVal lMatrah9 As Decimal, ByVal lMatrah10 As Decimal, ByVal lMatrah11 As Decimal, ByVal lMatrah12 As Decimal, ByVal bKullaniciGirdi1 As Byte, ByVal bKullaniciGirdi2 As Byte, ByVal bKullaniciGirdi3 As Byte, ByVal bKullaniciGirdi4 As Byte, ByVal bKullaniciGirdi5 As Byte, ByVal bKullaniciGirdi6 As Byte, ByVal bKullaniciGirdi7 As Byte, ByVal bKullaniciGirdi8 As Byte, ByVal bKullaniciGirdi9 As Byte, ByVal bKullaniciGirdi10 As Byte, ByVal bKullaniciGirdi11 As Byte, ByVal bKullaniciGirdi12 As Byte, ByVal nEskiYil As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbPersonelKumVergi SET nYil = " & nYil & ", lMatrah1 = " & lMatrah1 & ",  lMatrah2 = " & lMatrah2 & ", lMatrah3 = " & lMatrah3 & ",  lMatrah4 = " & lMatrah4 & ",  lMatrah5 = " & lMatrah5 & ",  lMatrah6 = " & lMatrah6 & ", lMatrah7 = " & lMatrah7 & ",  lMatrah8 = " & lMatrah8 & ",  lMatrah9 = " & lMatrah9 & ", lMatrah10 = " & lMatrah10 & ",  lMatrah11 = " & lMatrah11 & ",  lMatrah12 = " & lMatrah12 & ",  bKullaniciGirdi1 = " & bKullaniciGirdi1 & ", bKullaniciGirdi2 = " & bKullaniciGirdi2 & ", bKullaniciGirdi3 = " & bKullaniciGirdi3 & ", bKullaniciGirdi4 = " & bKullaniciGirdi4 & ", bKullaniciGirdi5 = " & bKullaniciGirdi5 & ",  bKullaniciGirdi6 = " & bKullaniciGirdi6 & ", bKullaniciGirdi7 = " & bKullaniciGirdi7 & ", bKullaniciGirdi8 =" & bKullaniciGirdi8 & ", bKullaniciGirdi9 = " & bKullaniciGirdi9 & ", bKullaniciGirdi10 = " & bKullaniciGirdi10 & ", bKullaniciGirdi11 = " & bKullaniciGirdi11 & ", bKullaniciGirdi12 = " & bKullaniciGirdi12 & " Where nYil = '" & nEskiYil & "' and nPersonelID ='" & nPersonelID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbPersonelKumVergi_Satir_sil()
        If GridControl6.Rows.Count > 0 Then
            Dim dr As DataRow
            Dim satir
            dr = ds_tbPersonelKumVergi.Tables(0).Rows(GridControl6.FocusedRecord)
            satir = GridControl6.FocusedRecord
            If XtraMessageBox.Show(dr("nYil") & vbTab & Sorgu_sDil(" Yılı Kümülatif Vergi Kaydını Silmek istediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                tbPersonelKumVergi_kaydet_sil(dr("nYil"), dr("nPersonelID"))
            End If
            ds_tbPersonelKumVergi = Dataload_tbPersonelKumVergi(nPersonelID)
            GridControl5.DataSource = ds_tbPersonelKumVergi.Tables(0)
            GridControl6.DataMember = Nothing
            GridControl6.FocusedRecord = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub tbPersonelKumVergi_kaydet_sil(ByVal nYil As Int64, ByVal nPersonelID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbPersonelKumVergi  Where nYil = " & nYil & " and nPersonelID ='" & nPersonelID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub KumVergi_ekle()
        tbPersonelKumVergi_kaydet_yeni(nPersonelID, Now.Year, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
        ds_tbPersonelKumVergi = Dataload_tbPersonelKumVergi(nPersonelID)
        GridControl6.DataSource = ds_tbPersonelKumVergi.Tables(0)
        GridControl6.DataMember = Nothing
        GridControl6.Focus()
        GridControl6.Select()
    End Sub
    Private Sub KumVergi_sil()
        tbPersonelKumVergi_Satir_sil()
    End Sub
    Private Sub KumVergi_yazdir()
        GridControl6.ShowRibbonPrintPreview()
    End Sub
    Private Sub raporla_personel(ByVal rapor As Integer, ByVal nislem As Integer, ByVal nPersonelID As Int64)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyaları (Personel*.fr*) |Personel*.fr*"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Personel\Personel" & sRaporUzanti & ""
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Personel"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            If Microsoft.VisualBasic.Right(sFile, 3) = "frx" Then
                Dim report As New FastReport.Report
                report.Load(sFile)
                report.RegisterData(ds_tbParamGenel, "tbParamGenel")
                report.RegisterData(ds_tbPersonel, "tbPersonel")
                report.RegisterData(ds_tbPersonelSinifi, "tbPersonelSinifi")
                report.RegisterData(ds_tbCinsiyet, "tbCinsiyet")
                report.RegisterData(ds_tbBordroSSK, "tbBordroSSK")
                report.RegisterData(ds_tbIsKanunu, "tbIsKanunu")
                report.RegisterData(ds_tbIstenCikisSebebi, "tbIstenCikisSebebi")
                report.RegisterData(ds_tbIstenCikisSebebiBolge, "tbIstenCikisSebebiBolge")
                report.RegisterData(ds_tbPersonelMeslekKod, "tbPersonelMeslekKod")
                report.RegisterData(ds_tbUnvan, "tbUnvan")
                report.ScriptLanguage = Language.Vb
                If nislem = 0 Then
                    report.Show()
                ElseIf nislem = 2 Then
                    report.Design()
                ElseIf nislem = 1 Then
                    report.Print()
                End If
                report.Dispose()
                report = Nothing
                'ElseIf Microsoft.VisualBasic.Right(sFile, 3) = "fr3" Then
                '    report_create_stok(sFile, " WHERE nKasaIslemID = " & dr("nKasaIslemID") & "", nislem, dr("lTahsilTutar"), dr("lTediyeTutar"))
            End If
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        raporla_personel(0, 0, txt_nPersonelID.Value)
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_personel(0, 2, txt_nPersonelID.Value)
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_personel(0, 1, txt_nPersonelID.Value)
    End Sub
    Private Sub txt_lSicilNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_lSicilNo.Validating
        If yeni = True Then
            txt_lSicilNo.EditValue = Trim(txt_lSicilNo.EditValue)
            If sorgu_sKodu_kontrol(txt_lSicilNo.EditValue) = False Then
                txt_lSicilNo.ErrorText = txt_lSicilNo.Text & vbTab & "Kaydı Daha Önce Kullanılmış"
                e.Cancel = True
                txt_lSicilNo.Focus()
                txt_lSicilNo.SelectAll()
            End If
        End If
    End Sub
    Public Function sorgu_sKodu_kontrol(ByVal kod As String) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(lSicilNo), 0) AS nKayit FROM         tbPersonel WHERE     (lSicilNo = '" & kod & "') ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Private Sub SimpleButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        kaydet_tumu()
    End Sub
    Private Sub sec_bSSKKesilecekmi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bSSKKesilecekmi.CheckStateChanged
        If sec_bSSKKesilecekmi.Checked = True Then
            txt_sSSKSicilNo.Enabled = True
            sec_sVergiStatusu2.Enabled = True
            sec_bIssizlikKesilecekmi.Enabled = True
        ElseIf sec_bSSKKesilecekmi.Checked = False Then
            txt_sSSKSicilNo.Text = ""
            sec_sVergiStatusu2.EditValue = 1
            sec_bIssizlikKesilecekmi.Checked = False
            txt_sSSKSicilNo.Enabled = False
            sec_sVergiStatusu2.Enabled = False
            sec_bIssizlikKesilecekmi.Enabled = False
        End If
    End Sub
    Private Sub sec_bAskerliginiYaptimi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bAskerliginiYaptimi.CheckStateChanged
        If sec_bAskerliginiYaptimi.Checked = True Then
            txt_nTecilSuresi.EditValue = 0
            txt_nTecilSuresi.Enabled = False
            txt_dteTerhisTarihi.Enabled = True
        Else
            txt_dteTerhisTarihi.EditValue = "01/01/1900"
            txt_dteTerhisTarihi.Enabled = False
            txt_nTecilSuresi.EditValue = 0
            txt_nTecilSuresi.Enabled = True
        End If
    End Sub
    Private Sub sec_bEhliyetiVarmi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bEhliyetiVarmi.CheckStateChanged
        If sec_bEhliyetiVarmi.Checked = True Then
            txt_sEhliyetSinifi.Enabled = True
        Else
            txt_sEhliyetSinifi.Enabled = False
            txt_sEhliyetSinifi.Text = ""
        End If
    End Sub
    Private Sub sec_bTCVatandasimi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bTCVatandasimi.CheckStateChanged
        If sec_bTCVatandasimi.Checked = True Then
            txt_sUyrugu.EditValue = ""
            txt_sUyrugu.Enabled = False
        Else
            txt_sUyrugu.Enabled = True
        End If
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            Dim satir = GridView1.FocusedRowHandle
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            GridView1.PostEditor()
            dr.EndEdit()
            tbPersonelSinifi_kaydet_duzelt(txt_nPersonelID.EditValue, dr("sSinifKodu"), dr("sSinifNo"))
            Dataload_tbHesapSinifi(txt_nPersonelID.EditValue)
            GridView1.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Try
                dataload_tbPSinif(dr("sSinifNo"))
            Catch ex As Exception
            End Try
            dr = Nothing
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Group_Kopyala.Visible = False
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Group_Kopyala.Visible = True
        txt_sYeniSicil.Text = sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(lSicilNo), 0) + 1 AS lSicilNo FROM         tbPersonel")
        txt_sYeniSicil.Focus()
        txt_sYeniSicil.SelectAll()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        If sorgu_nStokID("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select isnull(nPersonelId,0) from tbPersonel where lSicilNo = " & txt_sYeniSicil.Text & " ") = 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Personel Kartını Kopyalamaya Başlamak İstediğinize Emin misiniz?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                kopyala(txt_lSicilNo.Text, txt_sYeniSicil.Text)
            End If
        Else
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm,Kayıt İçerde Var...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub kopyala(ByVal lSicilNo As Int64, ByVal lYeniSicilNo As Int64)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("insert into tbPersonel select " & lYeniSicilNo & ",sDepartmanKodu,sAdi,sIkinciAdi,sSoyadi,nCinsiyet,sAkedemikUnvani,sUnvan,bSSKKesilecekmi,bIssizlikKesilecekmi,sSSKSicilNo,sSSKStatusu,sVergiStatusu,lTTFToplamOdenen,sTTFNumarasi,bBrutUcretlimi,sSaatGunlukAylik,sUcretDovizCinsi,lBirimUcret,sBankaHesapNo,sBankaHesapNoKS,dteIseGirisTarihi,dteIstenCikisTarihi,sCikisSebebi,bCalisiyormu,nCocukAd,nCocukAdOkulOncesi,nCocukAdIlkOgrenim,nCocukAdLise,nCocukAdYuksek,lOzelSagSigAylikPrimi,bSendikaUyesimi,sResimAdi,dteOzelSSBaslangic,'" & kullaniciadi & "',getdate(),lOzelEmekSigAylikPrimi from tbPersonel where lSicilNo = " & lSicilNo & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("Select isnull(nPersonelId,0) from tbPersonel where lSicilNo = " & lYeniSicilNo & "")
            Dim nPersonelID As Int64 = cmd.ExecuteScalar
            If sec_bKopyalaSicil.Checked = True Then
                cmd.CommandText = sorgu_query("insert into tbPersonelOzluk select " & nPersonelID & ",sPasaportNumarasi,bEhliyetiVarmi,sEhliyetSinifi,sVergiDairesi,sVergiNo,bAskerliginiYaptimi,dteTerhisTarihi,nTecilSuresi,sMernisNo,sKimlikNo, sBabaAdi, sAnneAdi,sDogumYeri,dteDogumTarihi,bEvlimi,sKizlikSoyadi,bTCVatandasimi,sUyrugu,sDini,sKanGrubu,sKayitliIl,sKayitliIlce,sKayitliMahKoy,sKayitliCiltNo,sKayitliAileNo,sKayitliSiraNo,sVerildigiYer,sVerilisNedeni,sKayitNo,dteVerilisTarihi,sEvAdresi1,sEvAdresi2,sEvSemt,sEvPostaKodu,sEvIl,sEvTelefonu,sCepTelefonu,sE_Posta,sAileTelefonu,bEskiHukumlumu,tbPersonelOzluk.bEsiIcinAGIAlacak,tbPersonelOzluk.nAGIAlacakCocukSayisi from tbPersonelOzluk,tbPersonel where lSicilNo =" & lSicilNo & " and tbPersonelOzluk.nPersonelId = tbPersonel.nPersonelId")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("insert into tbPersonelMeslek  select " & nPersonelID & ",sIlkOgrenim,dteIlkBitisTarihi,sLise,dteLiseBitisTarihi,nYuksekOkulID1,nBolumID1,dteYOBitisTarihi1,nYuksekOkulID2,nBolumID2,dteYOBitisTarihi2,sMeslek,nMeslekKidemi,sSonIsyeri,sSonIsyerindeUnvani,sSonIsyeriAdresi1,sSonIsyeriAdresi2,sSonIsyeriSemt,sSonIsyeriPostaKodu,sSonIsyeriIl,sSonSicilNo,sSonKurum,nYabanciDilID1,nYDSeviye1,nYabanciDilID2,nYDSeviye2,nYabanciDilID3,nYDSeviye3,nOgrenimDurumu,sOgrenimDurumuDiger,bAylikAliyormu,nSSKAylikAliyormu from tbPersonelMeslek,tbPersonel where lSicilNo = " & lSicilNo & " and tbPersonelMeslek.nPersonelId = tbPersonel.nPersonelId")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("insert into tbPersonelSicil select " & nPersonelID & ", sSicilKod,dteIslemTarihi,sAciklama from tbPersonelSicil,tbPersonel where lSicilNo = " & lSicilNo & " and tbPersonelSicil.nPersonelId = tbPersonel.nPersonelId")
                cmd.ExecuteNonQuery()
            End If
            If sec_bKopyalaSinifi.Checked = True Then
                cmd.CommandText = sorgu_query("insert into tbPersonelSinifi  select " & nPersonelID & ",sSinifKodu1,sSinifKodu2,sSinifKodu3,sSinifKodu4,sSinifKodu5 from tbPersonelSinifi,tbPersonel where lSicilNo = " & lSicilNo & " and tbPersonelSinifi.nPersonelId = tbPersonel.nPersonelId ")
                cmd.ExecuteNonQuery()
            End If
            If sec_bKopyalaEgitim.Checked = True Then
                cmd.CommandText = sorgu_query("insert into tbPersonelEgitim select " & nPersonelID & ", sEgitimTipi,dteBaslangicTarihi,dteBitisTarihi,sAciklama from tbPersonelEgitim,tbPersonel where lSicilNo = " & lSicilNo & " and tbPersonelEgitim.nPersonelId = tbPersonel.nPersonelId")
                cmd.ExecuteNonQuery()
            End If
            If sec_bKopyalaYakini.Checked = True Then
                cmd.CommandText = sorgu_query("insert into tbPersonelYakini select " & nPersonelID & ",tbPersonelYakini.sAdi,tbPersonelYakini.sSoyadi,sYakinlikDerecesi, dteDogumTarihi,sAdresi1,sAdresi2,sSemt, sPostaKodu,sIl,sTelefonu,sCepTelefonu,sE_Posta, sNot,sKimlikNo,sDogumYeri,bTCVatandasimi,sUyrugu,tbPersonelYakini.nCinsiyet from tbPersonelYakini,tbPersonel where lSicilNo = " & lSicilNo & " and tbPersonelYakini.nPersonelId = tbPersonel.nPersonelId")
                cmd.ExecuteNonQuery()
            End If
            If sec_bKopyalaMatrahSigorta.Checked = True Then
                cmd.CommandText = sorgu_query("insert into tbPersonelKumSigorta select " & nPersonelID & ",nYil,nGun1,lMatrah1,lIssislikPrimi1,nGun2,lMatrah2,lIssislikPrimi2,nGun3,lMatrah3,lIssislikPrimi3,nGun4,lMatrah4,lIssislikPrimi4,nGun5,lMatrah5,lIssislikPrimi5,nGun6,lMatrah6,lIssislikPrimi6,nGun7,lMatrah7,lIssislikPrimi7,nGun8,lMatrah8,lIssislikPrimi8,nGun9,lMatrah9,lIssislikPrimi9,nGun10,lMatrah10,lIssislikPrimi10,nGun11,lMatrah11,lIssislikPrimi11,nGun12,lMatrah12,lIssislikPrimi12,bKullaniciGirdi1,bKullaniciGirdi2,bKullaniciGirdi3,bKullaniciGirdi4,bKullaniciGirdi5, bKullaniciGirdi6,bKullaniciGirdi7, bKullaniciGirdi8, bKullaniciGirdi9, bKullaniciGirdi10, bKullaniciGirdi11, bKullaniciGirdi12 from tbPersonelKumSigorta,tbPersonel where lSicilNo = " & lSicilNo & " and tbPersonelKumSigorta.nPersonelId = tbPersonel.nPersonelId")
                cmd.ExecuteNonQuery()
            End If
            If sec_bKopyalaMatrahVergi.Checked = True Then
                cmd.CommandText = sorgu_query("insert into tbPersonelKumVergi select " & nPersonelID & ",nYil, lMatrah1,lMatrah2,lMatrah3,lMatrah4,lMatrah5, lMatrah6,lMatrah7,lMatrah8,lMatrah9,lMatrah10,lMatrah11,lMatrah12, bKullaniciGirdi1,bKullaniciGirdi2,bKullaniciGirdi3,bKullaniciGirdi4,bKullaniciGirdi5, bKullaniciGirdi6, bKullaniciGirdi7, bKullaniciGirdi8, bKullaniciGirdi9, bKullaniciGirdi10, bKullaniciGirdi11, bKullaniciGirdi12 from tbPersonelKumVergi,tbPersonel where lSicilNo = " & lSicilNo & " and tbPersonelKumVergi.nPersonelId = tbPersonel.nPersonelId")
                cmd.ExecuteNonQuery()
            End If
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(sKodu,'') as sKodu FROM         tbFirma WHERE     (nFirmaID < '" & nFirmaID & "' ) ORDER BY sKodu DESC ")
            'sKodu = cmd.ExecuteScalar
            'txt_musteriNo.EditValue = sKodu
            MsgBox(Sorgu_sDil("Kayıt Başarıyla Kopyalandı...", sDil), MessageBoxIcon.Information, Sorgu_sDil("Dikkat", sDil))
            dataload(nPersonelID)
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm,Kayıt İçerde Var...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 ROLLBACK TRAN")
            cmd.ExecuteNonQuery()
        End Try
        con.Close()
    End Sub
    Private Sub sec_OncedenCalismis_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_OncedenCalismis.CheckStateChanged
        If sec_OncedenCalismis.Checked = True Then
            sec_bKurum.Enabled = True
            txt_sSonKurum.Enabled = True
            txt_sSonSicilNo.Enabled = True
            sec_bAylikAliyormu.Enabled = True
        Else
            sec_bKurum.Enabled = True
            txt_sSonKurum.Enabled = False
            txt_sSonKurum.EditValue = ""
            txt_sSonSicilNo.Enabled = False
            txt_sSonSicilNo.EditValue = ""
            sec_bAylikAliyormu.Enabled = False
            sec_bAylikAliyormu.Checked = False
        End If
    End Sub
    Private Sub sec_bKurum_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bKurum.SelectedIndexChanged
        If sec_bKurum.SelectedIndex = 0 Then
            txt_sSonKurum.Enabled = False
            txt_sSonKurum.EditValue = "SSK"
        ElseIf sec_bKurum.SelectedIndex = 1 Then
            txt_sSonKurum.Enabled = False
            txt_sSonKurum.EditValue = "Bağkur"
        ElseIf sec_bKurum.SelectedIndex = 2 Then
            txt_sSonKurum.Enabled = False
            txt_sSonKurum.EditValue = "T.C. Emekli Sandığı"
        ElseIf sec_bKurum.SelectedIndex = 3 Then
            txt_sSonKurum.Enabled = True
        End If
    End Sub
    Private Sub sec_nSSKAylikAliyormu_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_nSSKAylikAliyormu.CheckStateChanged
        If sec_nSSKAylikAliyormu.Checked = True Then
            RadioGroup2.Enabled = True
        Else
            RadioGroup2.Enabled = False
            RadioGroup2.EditValue = 0
        End If
    End Sub
    Private Sub GridView2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        If GridView2.RowCount > 0 Then
            Dim satir = GridView2.FocusedRowHandle
            Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            GridView2.PostEditor()
            dr.EndEdit()
            Try
                tbPersonelEgitim_kaydet_duzelt(dr("nEgitimID"), dr("nPersonelID"), dr("sEgitimTipi"), dr("dteBaslangicTarihi"), dr("dteBitisTarihi"), dr("sAciklama"))
            Catch ex As Exception
                XtraMessageBox.Show(Sorgu_sDil("Kayıt İçeride Var", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            ds_tbPersonelEgitim = Dataload_tbPersonelEgitim(nPersonelID)
            GridView2.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub btn_yetkili_ekle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_yetkili_ekle.Click
        egitim_ekle()
    End Sub
    Private Sub btn_yetkili_sil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_yetkili_sil.Click
        egitim_sil()
    End Sub
    Private Sub btn_yetkili_yazdir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_yetkili_yazdir.Click
        egitim_yazdir()
    End Sub
    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        yakin_ekle()
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        yakin_sil()
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        yakinlik_yazdir()
    End Sub
    Private Sub GridView3_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView3.CellValueChanged
        If GridView3.RowCount > 0 Then
            Dim satir = GridView3.FocusedRowHandle
            Dim dr As DataRow = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            GridView3.PostEditor()
            dr.EndEdit()
            Try
                tbPersonelYakini_kaydet_duzelt(dr("nYakinID"), dr("nPersonelID"), dr("sAdi"), dr("sSoyadi"), dr("sYakinlikDerecesi"), dr("dteDogumTarihi"), dr("sAdresi1"), dr("sAdresi2"), dr("sSemt"), dr("sPostaKodu"), dr("sIl"), dr("sTelefonu"), dr("sCepTelefonu"), dr("sE_Posta"), dr("sNot"), dr("sKimlikNo"), dr("sDogumYeri"), CType(dr("bTCVatandasimi"), Byte), dr("sUyrugu"), dr("nCinsiyet"))
            Catch ex As Exception
                XtraMessageBox.Show(Sorgu_sDil("Kayıt İçeride Var", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            ds_tbPersonelYakini = Dataload_tbPersonelYakini(nPersonelID)
            GridView3.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub GridView4_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView4.CellValueChanged
        If GridView4.RowCount > 0 Then
            Dim satir = GridView4.FocusedRowHandle
            Dim dr As DataRow = GridView4.GetDataRow(GridView4.FocusedRowHandle)
            GridView4.PostEditor()
            dr.EndEdit()
            Try
                tbPersonelIzini_kaydet_duzelt(dr("nPersonelID"), dr("dteIzinTarihi"), dr("sIzinTipi"), dr("bUcretlimi"), dr("sMazaret"), dr("dteEskiIzinTarihi"))
                dr("dteEskiIzinTarihi") = dr("dteIzinTarihi")
            Catch ex As Exception
                XtraMessageBox.Show(Sorgu_sDil("Kayıt İçeride Var", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            ds_tbPersonelIzini = Dataload_tbPersonelIzini(nPersonelID)
            GridView4.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub SimpleButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton10.Click
        Izin_ekle()
    End Sub
    Private Sub SimpleButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton9.Click
        Izin_sil()
    End Sub
    Private Sub SimpleButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton8.Click
        Izin_yazdir()
    End Sub
    Private Sub SimpleButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton13.Click
        KumSigorta_ekle()
    End Sub
    Private Sub SimpleButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton12.Click
        KumSigorta_sil()
    End Sub
    Private Sub SimpleButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton11.Click
        KumSigorta_yazdir()
    End Sub
    Private Sub GridControl5_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles GridControl5.CellValueChanged
        If GridControl5.Rows.Count > 0 Then
            GridControl5.UpdateFocusedRecord()
            GridControl5.CloseEditor()
            Dim satir = GridControl5.FocusedRecordCellIndex
            Dim dr As DataRow = ds_tbPersonelKumSigorta.Tables(0).Rows(GridControl5.FocusedRecord)
            dr.EndEdit()
            Try
                dr("nGunToplam") = dr("nGun1") + dr("nGun2") + dr("nGun3") + dr("nGun4") + dr("nGun5") + dr("nGun6") + dr("nGun7") + dr("nGun8") + dr("nGun9") + dr("nGun10") + dr("nGun11") + dr("nGun12")
                dr("lMatrahToplam") = dr("lMatrah1") + dr("lMatrah2") + dr("lMatrah3") + dr("lMatrah4") + dr("lMatrah5") + dr("lMatrah6") + dr("lMatrah7") + dr("lMatrah8") + dr("lMatrah9") + dr("lMatrah10") + dr("lMatrah11") + dr("lMatrah12")
                dr("lIssislikPrimiToplam") = dr("lIssislikPrimi1") + dr("lIssislikPrimi2") + dr("lIssislikPrimi3") + dr("lIssislikPrimi4") + dr("lIssislikPrimi5") + dr("lIssislikPrimi6") + dr("lIssislikPrimi7") + dr("lIssislikPrimi8") + dr("lIssislikPrimi9") + dr("lIssislikPrimi10") + dr("lIssislikPrimi11") + dr("lIssislikPrimi12")
                tbPersonelKumSigorta_kaydet_duzelt(dr("nPersonelID"), dr("nYil"), dr("nGun1"), dr("lMatrah1"), dr("lIssislikPrimi1"), dr("nGun2"), dr("lMatrah2"), dr("lIssislikPrimi2"), dr("nGun3"), dr("lMatrah3"), dr("lIssislikPrimi3"), dr("nGun4"), dr("lMatrah4"), dr("lIssislikPrimi4"), dr("nGun5"), dr("lMatrah5"), dr("lIssislikPrimi5"), dr("nGun6"), dr("lMatrah6"), dr("lIssislikPrimi6"), dr("nGun7"), dr("lMatrah7"), dr("lIssislikPrimi7"), dr("nGun8"), dr("lMatrah8"), dr("lIssislikPrimi8"), dr("nGun9"), dr("lMatrah9"), dr("lIssislikPrimi9"), dr("nGun10"), dr("lMatrah10"), dr("lIssislikPrimi10"), dr("nGun11"), dr("lMatrah11"), dr("lIssislikPrimi11"), dr("nGun12"), dr("lMatrah12"), dr("lIssislikPrimi12"), dr("bKullaniciGirdi1"), dr("bKullaniciGirdi2"), dr("bKullaniciGirdi3"), dr("bKullaniciGirdi4"), dr("bKullaniciGirdi5"), dr("bKullaniciGirdi6"), dr("bKullaniciGirdi7"), dr("bKullaniciGirdi8"), dr("bKullaniciGirdi9"), dr("bKullaniciGirdi10"), dr("bKullaniciGirdi11"), dr("bKullaniciGirdi12"), dr("nEskiYil"))
                dr("nEskiYil") = dr("nYil")
            Catch ex As Exception
                XtraMessageBox.Show(Sorgu_sDil("Kayıt İçeride Var", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            'ds_tbPersonelKumSigorta = Dataload_tbPersonelKumSigorta(nPersonelID)
            'GridControl5.DataSource = ds_tbPersonelKumSigorta.Tables(0)
            'GridControl5.DataMember = Nothing
            'GridControl5.FocusedRecordCellIndex = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub SimpleButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton16.Click
        KumVergi_ekle()
    End Sub
    Private Sub SimpleButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton15.Click
        KumVergi_sil()
    End Sub
    Private Sub SimpleButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton14.Click
        KumVergi_yazdir()
    End Sub
End Class