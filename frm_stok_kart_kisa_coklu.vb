Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_stok_kart_kisa_coklu
    Public firmano
    Public donemno
    Public connection
    Public nStokID
    Public kullanici As String
    Public sKodu
    Public sModel
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_stok As DataSet
    Dim ds_nStokID As DataSet
    Dim ds_tbBirimCinsi As DataSet
    Dim ds_tbRenk As DataSet
    Dim ds_tbAsorti As DataSet
    Dim DS_tbKdv As DataSet
    Dim ds_tbOTV As DataSet
    Dim ds_tbFiyatlandirma As DataSet
    Dim ds_tbFiyatTipi As DataSet
    Public islem_status As Boolean = False
    Dim sayi As Integer = 0
    Dim bSinifKod1Zorunlumu As Boolean = False
    Dim bSinifKod2Zorunlumu As Boolean = False
    Dim bSinifKod3Zorunlumu As Boolean = False
    Dim bSinifKod4Zorunlumu As Boolean = False
    Dim trd As Threading.Thread
    Private Sub frm_stok_kart_kisa_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Enter
    End Sub
    Private Sub frm_stok_kart_kisa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        Dataload_tbStok(sModel)
        dataload_tbBirimCinsi()
        dataload_tbRenk()
        dataload_tbAsorti()
        dataload_tbKdv()
        dataload_tbOTV()
        dataload_tbFiyatTipi()
        dataload_tbSSinif(1)
        txt_sAdi.Focus()
        txt_sAdi.SelectAll()
        If islem_status = False Then
            If txt_sBarkod.Text = "" Then
                txt_sKodu.Text = ""
                txt_sBarkod.Text = ""
            End If
        End If
        Try
            lbl_sKisaAdi.Text = sorgu_sKisaAdi_kontrol().ToString
        Catch ex As Exception
            lbl_sKisaAdi.Text = ""
        End Try
        Try
            sec_sFiyatTipi1.EditValue = Trim(sFiyat1)
        Catch ex As Exception
            sec_sFiyatTipi1.EditValue = "1"
        End Try
        Try
            sec_sFiyatTipi2.EditValue = Trim(sFiyat2)
        Catch ex As Exception
            sec_sFiyatTipi2.EditValue = "2"
        End Try
        Try
            sec_sFiyatTipi3.EditValue = Trim(sFiyat3)
        Catch ex As Exception
            sec_sFiyatTipi3.EditValue = "3"
        End Try
        Try
            sec_sFiyatTipi4.EditValue = Trim(sFiyatA)
        Catch ex As Exception
            sec_sFiyatTipi4.EditValue = "A"
        End Try
        Try
            sec_sFiyatTipi5.EditValue = Trim(sFiyatM)
        Catch ex As Exception
            sec_sFiyatTipi5.EditValue = "M"
        End Try
        Try
            txt_sAyrac.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("sAyrac").ToString
        Catch ex As Exception
            txt_sAyrac.Text = ""
        End Try
        txt_sBirimCinsi1.EditValue = sDefaultBirimCinsi
        txt_sKdvTipi.EditValue = sDefaultKdvCinsi
        txt_OTVvar.EditValue = 0
        txt_sOTVtipi.EditValue = sDefaultOTVTipi
        sec_sSinifKodu.EditValue = ""
        lbl_Sinif1.Text = sStokSinifTipi1
        lbl_Sinif_1.Text = sStokSinifTipi1
        lbl_Sinif_2.Text = sStokSinifTipi2
        lbl_Sinif_3.Text = sStokSinifTipi3
        lbl_Sinif_4.Text = sStokSinifTipi4
        bSinifKod1Zorunlumu = sorgula_Boolean("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT bSinifKodu1Zorunlumu   FROM tbParamStokKodlama")
        bSinifKod2Zorunlumu = sorgula_Boolean("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT bSinifKodu2Zorunlumu   FROM tbParamStokKodlama")
        bSinifKod3Zorunlumu = sorgula_Boolean("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT bSinifKodu3Zorunlumu   FROM tbParamStokKodlama")
        bSinifKod4Zorunlumu = sorgula_Boolean("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT bSinifKodu4Zorunlumu   FROM tbParamStokKodlama")
    End Sub
    Private Sub gorunum_yukle()
        Dim itm
        For Each itm In ContextMenu1.MenuItems
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        Label1.Text = Sorgu_sDil(Label1.Text, sDil)
        LabelControl1.Text = Sorgu_sDil(LabelControl1.Text, sDil)
        LabelControl2.Text = Sorgu_sDil(LabelControl2.Text, sDil)
        LabelControl3.Text = Sorgu_sDil(LabelControl3.Text, sDil)
        LabelControl4.Text = Sorgu_sDil(LabelControl4.Text, sDil)
        lbl_Sinif1.Text = Sorgu_sDil(lbl_Sinif1.Text, sDil)
        LabelControl6.Text = Sorgu_sDil(LabelControl6.Text, sDil)
        LabelControl7.Text = Sorgu_sDil(LabelControl7.Text, sDil)
        LabelControl8.Text = Sorgu_sDil(LabelControl8.Text, sDil)
        LabelControl9.Text = Sorgu_sDil(LabelControl9.Text, sDil)
        LabelControl10.Text = Sorgu_sDil(LabelControl10.Text, sDil)
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
    End Sub
    Private Sub dataload_tbBirimCinsi()
        ds_tbBirimCinsi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbBirimCinsi"))
        txt_sBirimCinsi1.Properties.DataSource = ds_tbBirimCinsi.Tables(0)
        'txt_sBirimCinsi2.Properties.DataSource = ds_tbBirimCinsi.Tables(0)
    End Sub
    Private Sub dataload_tbRenk()
        ds_tbRenk = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sRenk,sRenkAdi FROM         tbRenk Order by sRenk"))
        txt_sRenk.Properties.DataSource = ds_tbRenk.Tables(0)
        txt_sRenk.ItemIndex = 0
        'txt_sBirimCinsi2.Properties.DataSource = ds_tbBirimCinsi.Tables(0)
    End Sub
    Private Sub dataload_tbAsorti()
        'ds_tbAsorti = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sAsortiTipi FROM         tbAsorti"))
        'txt_sAsortiTipi.Properties.DataSource = ds_tbAsorti.Tables(0)
    End Sub
    Private Sub dataload_tbKdv()
        DS_tbKdv = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbKdv where sKdvTipi <>'' "))
        txt_sKdvTipi.Properties.DataSource = DS_tbKdv.Tables(0)
        'txt_sKdvTipi.EditValue = 8
        txt_sKdvTipi.ItemIndex = 2
    End Sub
    Private Sub dataload_tbOTV()
        ds_tbOTV = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbOTV"))
        txt_sOTVtipi.Properties.DataSource = ds_tbOTV.Tables(0)
    End Sub
    Private Sub dataload_tbFiyatTipi()
        ds_tbFiyatTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     RTRIM(sFiyatTipi) sFiyatTipi,sAciklama FROM         tbFiyatTipi Where sFiyatTipi <> '' and (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%')"))
        sec_sFiyatTipi1.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sFiyatTipi2.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sFiyatTipi3.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sFiyatTipi4.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sFiyatTipi5.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
    End Sub
    Private Sub dataload_tbSSinif(Optional ByVal sSinifNo As Integer = 1, Optional ByVal bSinifla As Boolean = False)
        sec_sSinifKodu.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu, sAciklama FROM tbSSinif" & sSinifNo & "")).Tables(0)
        'If bSinifla = True Then
        sec_sSinifKodu1.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu, sAciklama FROM tbSSinif1 Order by sSinifKodu")).Tables(0)
        sec_sSinifKodu2.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu, sAciklama FROM tbSSinif2 Order by sSinifKodu")).Tables(0)
        sec_sSinifKodu3.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu, sAciklama FROM tbSSinif3 Order by sSinifKodu")).Tables(0)
        sec_sSinifKodu4.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu, sAciklama FROM tbSSinif4 Order by sSinifKodu")).Tables(0)
        sec_sSinifKodu1.EditValue = ""
        sec_sSinifKodu2.EditValue = ""
        sec_sSinifKodu3.EditValue = ""
        sec_sSinifKodu4.EditValue = ""
        'End If
    End Sub
    Private Sub dataload_tbIletisimAraci()
        'sec_IletisimAraci.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbIletisimAraci")).Tables(0)
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
    Public Sub Dataload_tbStok(ByVal sModel As String)
        Try
            ds_tbStok.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 * From tbStok WHERE sModel ='" & sModel & "'")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbStok, "Table1")
        conn.Close()
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
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sKodu), 0) AS nKayit FROM         tbStok WHERE     (sKodu = '" & kod & "') ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sKoliKodu), 0) AS nKayit FROM         tbKoli WHERE     (sKoliKodu = '" & kod & "') ")
            kayitsayisi = cmd.ExecuteScalar
        End If
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Public Function sorgu_sBarkod_kontrol(ByVal kod As String) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sBarkod), 0) AS nKayit FROM         tbStokBarkodu WHERE     (sBarkod = '" & kod & "') ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sKoliKodu), 0) AS nKayit FROM         tbKoli WHERE     (sKoliKodu = '" & kod & "') ")
            kayitsayisi = cmd.ExecuteScalar
        End If
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Public Function sorgu_sKisaAdi_kontrol() As Int64
        Dim kriter
        Dim sKisaAdi As Int64 = 0
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(CAST(sKisaAdi AS FLOAT)),0) AS sKisaAdi FROM         tbStok WHERE     (ISNUMERIC(sKisaAdi) = 1) ")
        sKisaAdi = cmd.ExecuteScalar
        sKisaAdi += 1
        Return sKisaAdi
    End Function
    Private Function tbStok_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal sKisaAdi As String, ByVal nStokTipi As Int64, ByVal sBedenTipi As String, ByVal sKavalaTipi As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sKavala As String, ByVal sBirimCinsi1 As String, ByVal sBirimCinsi2 As String, ByVal nIskontoYuzdesi As Decimal, ByVal sKdvTipi As String, ByVal nTeminSuresi As Decimal, ByVal lAsgariMiktar As Decimal, ByVal lAzamiMiktar As Decimal, ByVal sOzelNot As String, ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bEksiyeDusulebilirmi As Byte, ByVal sDefaultAsortiTipi As String, ByVal bEksideUyarsinmi As Byte, ByVal bOTVVar As Byte, ByVal sOTVTipi As String, ByVal nIskontoYuzdesiAV As Decimal, ByVal bEk1 As Byte, ByVal nEk2 As String, ByVal nAgirlik As Decimal, ByVal bOIVVar As Byte, ByVal nOIV As Decimal) As Decimal
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStok (sKodu, sAciklama, sKisaAdi, nStokTipi, sBedenTipi, sKavalaTipi, sRenk, sBeden, sKavala, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi, nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, sModel, sKullaniciAdi, dteKayitTarihi, bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2, nAgirlik, bOIVVar, nOIV) VALUES ('" & sKodu & "', N'" & sAciklama & "', '" & sKisaAdi & "', " & nStokTipi & ", '" & sBedenTipi & "', '" & sKavalaTipi & "', '" & sRenk & "', '" & sBeden & "', '" & sKavala & "', '" & sBirimCinsi1 & "', '" & sBirimCinsi1 & "', " & nIskontoYuzdesi & ", '" & sKdvTipi & "', " & nTeminSuresi & ", " & lAsgariMiktar & ", " & lAzamiMiktar & ", '" & sOzelNot & "', " & nFiyatlandirma & ", '" & sModel & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bEksiyeDusulebilirmi & ", '" & sDefaultAsortiTipi & "', " & bEksideUyarsinmi & ", " & bOTVVar & ", '" & sOTVTipi & "', " & nIskontoYuzdesiAV & ", " & bEk1 & ", " & nEk2 & "," & nAgirlik & ", " & bOIVVar & ", " & nOIV & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Private Sub tbStokSinifi_kaydet_yeni(ByVal nStokID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String, ByVal sSinifKodu6 As String, ByVal sSinifKodu7 As String, ByVal sSinifKodu8 As String, ByVal sSinifKodu9 As String, ByVal sSinifKodu10 As String, ByVal sSinifKodu11 As String, ByVal sSinifKodu12 As String, ByVal sSinifKodu13 As String, ByVal sSinifKodu14 As String, ByVal sSinifKodu15 As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokSinifi (nStokID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, sSinifKodu11, sSinifKodu12, sSinifKodu13, sSinifKodu14, sSinifKodu15) VALUES     (N'" & nStokID & "', N'" & sSinifKodu1 & "', N'" & sSinifKodu2 & "', N'" & sSinifKodu3 & "', N'" & sSinifKodu4 & "', N'" & sSinifKodu5 & "', N'" & sSinifKodu6 & "', N'" & sSinifKodu7 & "', N'" & sSinifKodu8 & "', N'" & sSinifKodu9 & "', N'" & sSinifKodu10 & "',  N'" & sSinifKodu11 & "', N'" & sSinifKodu12 & "', N'" & sSinifKodu13 & "', N'" & sSinifKodu14 & "', N'" & sSinifKodu15 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokBarkodu_kaydet_yeni(ByVal nStokID As Int64, ByVal sBarkod As String, ByVal nKisim As Integer, ByVal nFirmaID As Integer, ByVal sKarsiStokKodu As String, ByVal sKarsiStokAciklama As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokBarkodu (nStokID, sBarkod, nKisim, nFirmaID, sKarsiStokKodu, sKarsiStokAciklama) VALUES     (" & nStokID & ", '" & sBarkod & "', " & nKisim & ", " & nFirmaID & ", '" & sKarsiStokKodu & "', '" & sKarsiStokAciklama & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokFiyati_ekle_yeni(ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String, ByVal lFiyat As Decimal, ByVal dteFiyatTespitTarihi As DateTime, ByVal sKullaniciAdi As String)
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
    Private Function tbSonKod(ByVal islem As String) As String
        Dim frm As New frm_tbSonKod
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.islem = islem
        Dim sKodu As String = ""
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            sKodu = frm.lbl_Kod.Text
        End If
        frm.Close()
        frm = Nothing
        Return sKodu
    End Function
    Private Sub kaydet_thread()
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        trd = New Threading.Thread(AddressOf kaydet_tumu)
        trd.IsBackground = True
        trd.Start()
    End Sub
    Private Sub kaydet_tumu()
        Dim bDevam As Boolean = False
        If Trim(txt_sKodu.Text) = "" Then
            bDevam = False
            XtraMessageBox.Show(Sorgu_sDil("Stok Kodunu Boþ Býrakamazsýnýz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            bDevam = True
        End If
        If Trim(sec_sSinifKodu.EditValue) = "" And bSinifKod1Zorunlumu = True Then
            bDevam = False
            XtraMessageBox.Show(Sorgu_sDil("Sýnýf Kodunu Boþ Býrakamazsýnýz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            bDevam = True
        End If
        If bDevam = True Then
            sKodu = txt_sKodu.EditValue
            sModel = sKodu
            If IsDBNull(txt_OIVVar.EditValue) Then
                txt_OIVVar.Checked = False
            End If
            If IsDBNull(txt_nOIV.Value) Then
                txt_nOIV.Value = 0
            End If
            Dim sayi As Integer = 0
            Dim artan_kod = 0
            If Trim(txt_sKodu.Text) <> "" And Trim(txt_sKodu2.Text) <> "" Then
                sayi = Integer.Parse(txt_sKodu2.Text) - Integer.Parse(txt_sKodu.Text)
                artan_kod = Integer.Parse(txt_sKodu.Text)
                bekleme_paneli.Visible = True
                bekleme_progress.Properties.Maximum = sayi
                bekleme_progress.Position = 0
                If sayi > 1 Then
                    For i As Integer = 0 To sayi
                        If sorgu_sKodu_kontrol((artan_kod + i).ToString()) Then
                            nStokID = tbStok_kaydet_yeni((artan_kod + i).ToString(), txt_sAdi.EditValue.ToString, txt_sKisaAdi.EditValue.ToString, 0, "", "", txt_sRenk.EditValue.ToString, txt_sBeden.Text.ToString, "", txt_sBirimCinsi1.EditValue.ToString, "", 0, txt_sKdvTipi.EditValue.ToString, 0, 0, 0, "", 0, (artan_kod + i).ToString(), kullanici, Now, 1, "", 0, CType((txt_OTVvar.EditValue), Byte), txt_sOTVtipi.Text, 0, 0, 0, txt_nAgirlik.Value, CType((txt_OIVVar.EditValue), Byte), txt_nOIV.Value)
                            tbStokSinifi_kaydet_yeni(nStokID, sec_sSinifKodu.EditValue, sec_sSinifKodu2.EditValue.ToString, sec_sSinifKodu3.EditValue.ToString, sec_sSinifKodu4.EditValue.ToString, "", "", "", "", "", "", "", "", "", "", "")
                            If txt_lFiyat1.EditValue > 0 Then
                                tbStokFiyati_ekle_yeni(0, (artan_kod + i).ToString(), "", "", sec_sFiyatTipi1.EditValue.ToString, txt_lFiyat1.EditValue.ToString, Today, kullaniciadi)
                            End If
                            If txt_lFiyat2.EditValue > 0 Then
                                tbStokFiyati_ekle_yeni(0, (artan_kod + i).ToString(), "", "", sec_sFiyatTipi2.EditValue.ToString, txt_lFiyat2.EditValue.ToString, Today, kullaniciadi)
                            End If
                            If txt_lFiyat3.EditValue > 0 Then
                                tbStokFiyati_ekle_yeni(0, (artan_kod + i).ToString(), "", "", sec_sFiyatTipi3.EditValue.ToString, txt_lFiyat3.EditValue.ToString, Today, kullaniciadi)
                            End If
                            If txt_lFiyat4.EditValue > 0 Then
                                tbStokFiyati_ekle_yeni(0, (artan_kod + i).ToString(), "", "", sec_sFiyatTipi4.EditValue.ToString, txt_lFiyat4.EditValue.ToString, Today, kullaniciadi)
                            End If
                            If txt_lFiyat5.EditValue > 0 Then
                                tbStokFiyati_ekle_yeni(0, (artan_kod + i).ToString(), "", "", sec_sFiyatTipi5.EditValue.ToString, txt_lFiyat5.EditValue.ToString, Today, kullaniciadi)
                            End If
                            If Trim(txt_sBarkod.Text) <> "" Then
                                tbStokBarkodu_kaydet_yeni(nStokID, txt_sBarkod.Text, 0, 0, "", "")
                            End If
                            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("sFiyatTipi1", sec_sFiyatTipi1.EditValue)
                            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("sFiyatTipi2", sec_sFiyatTipi2.EditValue)
                            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("sFiyatTipi3", sec_sFiyatTipi3.EditValue)
                            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("sFiyatTipi4", sec_sFiyatTipi4.EditValue)
                            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("sFiyatTipi5", sec_sFiyatTipi5.EditValue)
                            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("sAyrac", txt_sAyrac.Text)
                        End If
                        bekleme_progress.Position += 1
                    Next
                    MessageBox.Show("Çoklu Stok Kaydý Oluþturma Ýþlemi Tamamlandý.", "Barkod Yazýlým Evi")
                End If
            Else
                XtraMessageBox.Show(Sorgu_sDil("Lütfen bir deðer aralýðý belirleyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            If bSinifKod2Zorunlumu = True Or bSinifKod3Zorunlumu = True Or bSinifKod4Zorunlumu = True Then
                'bDiger = True
            End If
            'If bDiger = True Then
            '    stok_duzelt()
            'End If
            'If XtraMessageBox.Show(Sorgu_sDil("Diðer Stok Kartý Bilgilerini Girmek Ýster misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question, sorgu_sDil("Dikkat",sDil)) = Windows.Forms.DialogResult.Yes Then
            '    stok_duzelt()
            'End If
            If islem_status = False Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                Me.Close()
            End If
        Else
            txt_sKodu.Focus()
            txt_sKodu.SelectAll()
        End If
    End Sub
    Private Sub stok_duzelt()
        Dim frm As New frm_stok_kart
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.nStokID = nStokID
        frm.sKodu = sKodu
        frm.sModel = sModel
        frm.kullanici = kullanici
        frm.ShowDialog()
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub txt_sKodu_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_sKodu.EditValueChanged
        If Len(txt_sKodu.Text.ToString) <> 0 Then
            lbl_sKodu.Text = Len(txt_sKodu.EditValue.ToString)
            SimpleButton1.Enabled = True
            SimpleButton3.Enabled = True
        Else
            lbl_sKodu.Text = "*"
            SimpleButton1.Enabled = False
            SimpleButton3.Enabled = False
        End If
    End Sub
    Private Sub txt_sKodu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_sKodu.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_sBarkod.Text = Trim(txt_sKodu.Text.ToString)
        ElseIf e.KeyCode = Keys.F5 Then
            txt_sKodu.Text = tbSonKod("tbStok").ToString
        ElseIf e.KeyCode = Keys.Down Then
            txt_sBarkod.Text = Trim(txt_sKodu.Text.ToString)
            txt_sAdi.Focus()
            txt_sAdi.SelectAll()
        End If
    End Sub
    Private Sub txt_sKodu_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sKodu.Validating
        txt_sKodu.Text = Trim(txt_sKodu.Text.ToString)
        If sorgu_sKodu_kontrol(txt_sKodu.Text) = False Then
            txt_sKodu.ErrorText = txt_sKodu.Text & vbTab & "Kaydý Daha Önce Kullanýlmýþ"
            If XtraMessageBox.Show(txt_sKodu.Text & Sorgu_sDil(" Kodlu Kayýt Daha Önceden Kullanýlmýþ...!", sDil) & vbCrLf & Sorgu_sDil("Kayýtlarý Listelemek Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                stok_liste(txt_sKodu.Text, "sKodu")
            End If
            e.Cancel = True
            txt_sKodu.Focus()
            txt_sKodu.SelectAll()
        End If
    End Sub
    Private Sub stok_liste(ByVal ara As String, ByVal sKonum As String)
        Dim frm As New frm_stok
        'frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.kullanici = kullanici
        'frm.islemstatus = True
        If ara <> "" Then
            frm.qgelismis = "Baþlar"
            frm.gelismis = ara
            frm.status = True
            frm.mevcut = 1
        End If
        frm.ShowDialog()
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub txt_sBarkod_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_sBarkod.EditValueChanged
        If Len(txt_sBarkod.EditValue.ToString) <> 0 Then
            lbl_sBarkod.Text = Len(txt_sBarkod.Text.ToString)
        ElseIf Len(txt_sBarkod.EditValue.ToString) = 5 Then
            txt_sBirimCinsi1.EditValue = "KG "
        Else
            lbl_sBarkod.Text = "*"
        End If
        If Len(txt_sBarkod.EditValue.ToString) >= 12 Then
            If IsNumeric(txt_sBarkod.Text) = True Then
                lbl_checkdigit.Text = Ean13_CheckSum(Microsoft.VisualBasic.Left(txt_sBarkod.Text, 12))
            End If
        ElseIf Len(txt_sBarkod.EditValue.ToString) >= 7 Then
            If IsNumeric(txt_sBarkod.Text) = True Then
                lbl_checkdigit.Text = EAN8_Checksum(Microsoft.VisualBasic.Left(txt_sBarkod.Text, 7))
            End If
        End If
        If Len(txt_sBarkod.EditValue.ToString) = 8 Then
            If Microsoft.VisualBasic.Right(txt_sBarkod.Text, 1) = lbl_checkdigit.Text Then
                lbl_barcodestd.Text = "Ean8"
            Else
                lbl_barcodestd.Text = "-"
            End If
        ElseIf Len(txt_sBarkod.EditValue.ToString) = 13 Then
            If Microsoft.VisualBasic.Right(txt_sBarkod.Text, 1) = lbl_checkdigit.Text Then
                lbl_barcodestd.Text = "Ean13"
            Else
                lbl_barcodestd.Text = "-"
            End If
        Else
            lbl_barcodestd.Text = "-"
        End If
        BarCodeControl1.Text = txt_sBarkod.Text
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
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
    Private Function EAN8_Checksum(ByVal EAN8_Barcode As String) As String
        'http://www.barcodeisland.com/ean8.phtml
        Dim ChecksumCalculation As Integer = 0
        Dim Position As Int32 = 1
        For i As Integer = EAN8_Barcode.Length - 1 To 0 Step -1
            If Position Mod 2 = 1 Then
                'odd position
                ChecksumCalculation += Convert.ToInt32(EAN8_Barcode.Substring(i, 1)) * 3
            Else
                'even position
                ChecksumCalculation += Convert.ToInt32(EAN8_Barcode.Substring(i, 1)) * 1
            End If
            Position += 1
        Next
        Dim Checksum As Integer = 10 - (ChecksumCalculation Mod 10)
        Return Microsoft.VisualBasic.Right(Convert.ToString(Checksum), 1)
    End Function
    Private Sub txt_sBarkod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_sBarkod.KeyDown
        If e.KeyCode = Keys.Up Then
            txt_sKisaAdi.Focus()
            txt_sKisaAdi.SelectAll()
        ElseIf e.KeyCode = Keys.Down Then
            txt_sBirimCinsi1.Focus()
            txt_sBirimCinsi1.Select()
        End If
    End Sub
    Private Sub txt_sBarkod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sBarkod.Validating
        txt_sBarkod.Text = Trim(txt_sBarkod.Text.ToString)
        If sorgu_sBarkod_kontrol(txt_sBarkod.Text) = False Then
            txt_sBarkod.ErrorText = txt_sBarkod.Text & vbTab & "Barkodu Daha Önce Kullanýlmýþ"
            If XtraMessageBox.Show(txt_sBarkod.Text & Sorgu_sDil(" Barkodlu Kayýt Daha Önceden Kullanýlmýþ...!", sDil) & vbCrLf & Sorgu_sDil("Kayýtlarý Listelemek Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                stok_liste(txt_sBarkod.Text, "sBarkod")
            End If
            e.Cancel = True
            txt_sBarkod.Focus()
            txt_sBarkod.SelectAll()
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        kaydet_thread()
    End Sub
    Private Sub txt_OTVvar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_OTVvar.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_sOTVtipi.Focus()
            txt_sOTVtipi.Select()
        End If
    End Sub
    Private Sub txt_sAdi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_sAdi.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_sKisaAdi.EditValue = Microsoft.VisualBasic.Left(Trim(txt_sAdi.EditValue.ToString), 20)
        ElseIf e.KeyCode = Keys.F5 Then
            Dim frm As New frm_stok
            Dim dr1 As DataRow
            frm.connection = connection
            frm.firmano = firmano
            frm.donemno = donemno
            frm.islemstatus = True
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                txt_sAdi.Text = dr1("sAciklama")
                'txt_sBarkod.Text = Trim(dr1("sBarkod"))
                txt_lFiyat1.EditValue = sorgu_sayi(dr1("PESIN"), 0)
                txt_lFiyat2.EditValue = sorgu_sayi(dr1("ALTIAY"), 0)
                txt_lFiyat3.EditValue = sorgu_sayi(dr1("ONAY"), 0)
                txt_lFiyat4.EditValue = sorgu_sayi(dr1("ALISFIYATI"), 0)
                txt_lFiyat5.EditValue = sorgu_sayi(dr1("MALIYET"), 0)
                txt_sKdvTipi.EditValue = dr1("sKdvTipi")
                txt_sBirimCinsi1.EditValue = dr1("sBirimCinsi1")
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            dr1 = Nothing
        ElseIf e.KeyCode = Keys.Up Then
            txt_sKodu.Focus()
            txt_sKodu.SelectAll()
        ElseIf e.KeyCode = Keys.Down Then
            txt_sKisaAdi.EditValue = Microsoft.VisualBasic.Left(Trim(txt_sAdi.EditValue.ToString), 20)
            txt_sKisaAdi.Focus()
            txt_sKisaAdi.SelectAll()
        End If
    End Sub
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub txt_sKisaAdi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_sKisaAdi.KeyDown
        If e.KeyCode = Keys.F5 Then
            txt_sKisaAdi.Text = tbSonKod("sKisaAdi").ToString
            txt_sKisaAdi.Focus()
            txt_sKisaAdi.SelectAll()
        ElseIf e.KeyCode = Keys.Up Then
            e.Handled = True
            txt_sAdi.Focus()
            txt_sAdi.SelectAll()
        ElseIf e.KeyCode = Keys.Down Then
            e.Handled = True
            txt_sBarkod.Focus()
            txt_sBarkod.SelectAll()
        End If
    End Sub
    Private Sub txt_sOTVtipi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_sOTVtipi.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_lFiyat1.Focus()
            txt_lFiyat1.SelectAll()
        End If
    End Sub
    Private Sub txt_lFiyat1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_lFiyat1.KeyDown
        If e.KeyCode = Keys.Down Then
            e.Handled = False
            txt_lFiyat2.Focus()
            txt_lFiyat2.SelectAll()
        ElseIf e.KeyCode = Keys.Up Then
            e.Handled = False
            txt_sKdvTipi.Focus()
            txt_sKdvTipi.Select()
        End If
    End Sub
    Private Sub txt_lFiyat2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_lFiyat2.KeyDown
        If e.KeyCode = Keys.Down Then
            e.Handled = True
            txt_lFiyat3.Focus()
            txt_lFiyat3.SelectAll()
        ElseIf e.KeyCode = Keys.Up Then
            e.Handled = True
            txt_lFiyat1.Focus()
            txt_lFiyat1.SelectAll()
        End If
    End Sub
    Private Sub txt_lFiyat3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_lFiyat3.KeyDown
        If e.KeyCode = Keys.Down Then
            e.Handled = True
            txt_lFiyat4.Focus()
            txt_lFiyat4.SelectAll()
        ElseIf e.KeyCode = Keys.Up Then
            e.Handled = True
            txt_lFiyat2.Focus()
            txt_lFiyat2.SelectAll()
        End If
    End Sub
    Private Sub txt_lFiyat4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_lFiyat4.KeyDown
        If e.KeyCode = Keys.Down Then
            e.Handled = True
            txt_lFiyat5.Focus()
            txt_lFiyat5.SelectAll()
        ElseIf e.KeyCode = Keys.Up Then
            e.Handled = True
            txt_lFiyat3.Focus()
            txt_lFiyat3.SelectAll()
        End If
    End Sub
    Private Sub txt_lFiyat5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_lFiyat5.KeyDown
        If e.KeyCode = Keys.Down Then
            e.Handled = True
            SimpleButton1.Focus()
            SimpleButton1.Select()
        ElseIf e.KeyCode = Keys.Up Then
            e.Handled = True
            txt_lFiyat4.Focus()
            txt_lFiyat4.SelectAll()
        End If
    End Sub
    Private Sub SimpleButton1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SimpleButton1.KeyDown
        If e.KeyCode = Keys.Down Then
            SimpleButton2.Focus()
            SimpleButton2.Select()
        ElseIf e.KeyCode = Keys.Up Then
            txt_lFiyat5.Focus()
            txt_lFiyat5.SelectAll()
        End If
    End Sub
    Private Sub txt_sBirimCinsi1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_sBirimCinsi1.KeyDown
        If e.KeyCode = Keys.Up Then
            'e.Handled = True
            'txt_sBarkod.Focus()
            'txt_sBarkod.SelectAll()
        ElseIf e.KeyCode = Keys.Down Then
            'e.Handled = True
            'txt_sKdvTipi.Focus()
            'txt_sKdvTipi.Select()
        ElseIf e.KeyCode = Keys.Enter Then
            'txt_sKdvTipi.Focus()
            'txt_sKdvTipi.Select()
        End If
    End Sub
    Private Sub txt_sKdvTipi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_sKdvTipi.KeyDown
        If e.KeyCode = Keys.Up Then
            'e.Handled = True
            'txt_sBirimCinsi1.Focus()
            'txt_sBirimCinsi1.Select()
        ElseIf e.KeyCode = Keys.Down Then
            'e.Handled = True
            'txt_lFiyat1.Focus()
            'txt_lFiyat1.SelectAll()
        ElseIf e.KeyCode = Keys.Enter Then
            txt_lFiyat1.Focus()
            txt_lFiyat1.SelectAll()
        End If
    End Sub
    Private Sub txt_lFiyat1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_lFiyat1.Validating
        If txt_lFiyat1.EditValue < 0 Then
            txt_lFiyat1.EditValue = 0
        End If
    End Sub
    Private Sub txt_lFiyat2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_lFiyat2.Validating
        If txt_lFiyat1.EditValue < 0 Then
            txt_lFiyat1.EditValue = 0
        End If
    End Sub
    Private Sub txt_lFiyat3_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_lFiyat3.Validating
        If txt_lFiyat3.EditValue < 0 Then
            txt_lFiyat3.EditValue = 0
        End If
    End Sub
    Private Sub txt_lFiyat4_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_lFiyat4.Validating
        If txt_lFiyat4.EditValue < 0 Then
            txt_lFiyat4.EditValue = 0
        End If
    End Sub
    Private Sub txt_lFiyat5_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_lFiyat5.Validating
        If txt_lFiyat5.EditValue < 0 Then
            txt_lFiyat5.EditValue = 0
        End If
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        kaydet_tumu()
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        'kaydet_tumu(True)
    End Sub
    Private Sub sec_sSinifKodu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SimpleButton1.Focus()
            SimpleButton1.Select()
        ElseIf e.KeyCode = Keys.Down Then
            'SimpleButton1.Focus()
            'SimpleButton1.Select()
        End If
    End Sub
    Private Sub txt_sRenk_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_sRenk.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_sBeden.Focus()
            txt_sBeden.SelectAll()
        End If
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        GroupControl1.Visible = True
        dataload_tbSSinif(1, True)
        sec_sSinifKodu1.Focus()
        sec_sSinifKodu1.Select()
    End Sub
    Private Sub btn_Vazgec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Vazgec.Click
        GroupControl1.Visible = False
        txt_sKodu.Focus()
        txt_sKodu.SelectAll()
    End Sub
    Private Sub btn_Kaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Kaydet.Click
        txt_sKodu.Text = lbl_sKod.Text
        txt_sKodu.Focus()
        txt_sKodu.SelectAll()
        GroupControl1.Visible = False
    End Sub
    Public Function sorgu_sKodu_bul(ByVal islem As String, ByVal bModel As Boolean, ByVal kod As String, ByVal sAyrac As String, ByVal nUzunluk As Int64) As String
        Dim sKod As String = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        If islem = "tbFirma" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(sKodu), '') AS sKod FROM         tbFirma WHERE     (sKodu LIKE '" & kod & "%') ")
        ElseIf islem = "tbHesapPlani" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(sKodu), '') AS sKod FROM         tbHesapPlani WHERE     (sKodu LIKE '" & kod & "%') ")
        ElseIf islem = "tbStok" Then
            If bModel = True Then
                Dim kriter As String = ""
                If nUzunluk = 12 Then
                ElseIf nUzunluk = 5 Then
                    kriter += " AND LEN(sModel) = 5 "
                ElseIf nUzunluk = 6 Then
                    kriter += " AND LEN(sModel) = 6 "
                End If
                If sAyrac = "" Then
                    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(sModel), '') AS sKod FROM         tbStok WHERE     (sModel LIKE '" & kod & "%') and sModel NOT LIKE '%-%' " & kriter & "")
                Else
                    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(sModel), '') AS sKod FROM         tbStok WHERE     (sModel LIKE '" & kod & "%') ")
                End If
            Else
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(sKodu), '') AS sKod FROM         tbStok WHERE     (sKodu LIKE '" & kod & "%') ")
            End If
        ElseIf islem = "sKisaAdi" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(sKisaAdi), '') AS sKod FROM         tbStok WHERE     (sKisaAdi LIKE '" & kod & "%') ")
        ElseIf islem = "tbKoli" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(sKoliKodu), '') AS sKod FROM         tbKoli WHERE     (sKoliKodu LIKE '" & kod & "%') ")
        End If
        sKod = Trim(cmd.ExecuteScalar)
        conn.Close()
        Return sKod
    End Function
    Private Sub kod_bul()
        Dim sKod As String = ""
        If Trim(sec_sSinifKodu1.Text) <> "" Then
            sKod = Trim(sec_sSinifKodu1.EditValue.ToString)
            sec_sSinifKodu.EditValue = sKod
            'sKod += txt_sAyrac.Text
        End If
        If Trim(sec_sSinifKodu2.Text) <> "" Then
            sKod += Trim(sec_sSinifKodu2.EditValue.ToString)
            'sKod += txt_sAyrac.Text
        End If
        If Trim(sec_sSinifKodu3.Text) <> "" Then
            sKod += Trim(sec_sSinifKodu3.EditValue.ToString)
            'sKod += txt_sAyrac.Text
        End If
        If Trim(sec_sSinifKodu4.Text) <> "" Then
            sKod += Trim(sec_sSinifKodu4.EditValue.ToString)
            'sKod += txt_sAyrac.Text
        End If
        sKod += txt_sAyrac.Text
        Dim lKod As Integer = 1
        Dim nUzunluk As Int16 = 64
        If sec_sKodlamaTipi.SelectedIndex = 0 Then
            nUzunluk = 12
        ElseIf sec_sKodlamaTipi.SelectedIndex = 1 Then
            nUzunluk = 5
        ElseIf sec_sKodlamaTipi.SelectedIndex = 2 Then
            If sKod = "" Then
                sKod = "00"
            End If
            nUzunluk = 6
        End If
        lbl_sKod.Text = sorgu_sKodu_bul("tbStok", True, sKod, txt_sAyrac.Text, nUzunluk)
        Try
            lKod = sorgu_sayi(lbl_sKod.Text.Replace(sKod, ""), 0) + 1
            lKod = sayiuzunlukkontrol(lKod, nUzunluk - Len(Trim(sKod)))
        Catch ex As Exception
            lKod = 1
        End Try
        If Trim(lbl_sKod.Text) = "" Then
            lbl_sKod.Text = sKod
        End If
        lbl_sKod.Text = sKod + sayiuzunlukkontrol(lKod, nUzunluk - Len(Trim(sKod)))
    End Sub
    Private Sub txt_sAyrac_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        kod_bul()
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        txt_sKodu.Text = tbSonKod("tbStok").ToString
    End Sub
    Private Sub sec_sSinifKodu1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_sSinifKodu1.Validating
        kod_bul()
    End Sub
    Private Sub sec_sSinifKodu2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_sSinifKodu2.Validating
        kod_bul()
    End Sub
    Private Sub sec_sSinifKodu3_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_sSinifKodu3.Validating
        kod_bul()
    End Sub
    Private Sub sec_sSinifKodu4_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_sSinifKodu4.Validating
        kod_bul()
    End Sub
    Private Sub sec_sKodlamaTipi_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sKodlamaTipi.SelectedIndexChanged
        kod_bul()
    End Sub
    Private Sub txt_sAyrac_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_sAyrac.SelectedValueChanged
        kod_bul()
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        tbSinif("tbSSinif", 1)
    End Sub
    Private Sub tbSinif(ByVal tablo As String, ByVal no As Integer)
        Dim fr As New frm_tbSinif
        fr.firmano = firmano
        fr.donemno = donemno
        fr.connection = connection
        fr.Table = tablo
        fr.No = no
        fr.sec_sSinifNo.EditValue = no
        fr.ShowDialog()
        dataload_tbSSinif(1, True)
        fr.Close()
        fr = Nothing
    End Sub
    Private Sub SimpleButton7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        tbSinif("tbSSinif", 2)
    End Sub
    Private Sub SimpleButton8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton8.Click
        tbSinif("tbSSinif", 3)
    End Sub
    Private Sub SimpleButton9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton9.Click
        tbSinif("tbSSinif", 4)
    End Sub
    Private Sub sec_sSinifKodu_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_sSinifKodu.KeyDown
        If e.KeyCode = Keys.Enter Then
            SimpleButton1.Focus()
            SimpleButton1.Select()
        End If
    End Sub
    Private Sub txt_OIVVar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles txt_OIVVar.CheckedChanged
        txt_nOIV.Enabled = txt_OIVVar.Checked
    End Sub
End Class