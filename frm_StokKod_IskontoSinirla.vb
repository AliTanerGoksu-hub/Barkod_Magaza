Imports System
Imports System.Drawing
Imports System.Collections
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_StokKod_IskontoSinirla
    Public nFirmano
    Public nDonemno
    Public sConnection
    Public skullanici
    Dim ds_tbsube As DataSet
    Dim ds_tbDovizCinsi As DataSet
    Dim ds_tbSiparisTipi As DataSet
    Dim ds_sSiparissIslem As DataSet
    Dim ds_cari As DataSet
    Dim ds_satir_stok As DataSet
    Dim ds_BirimSet As DataSet
    Dim ds_tbFiyatTipi As DataSet
    Dim ds_baslik As New DataSet
    Dim ds_tbSiparis As New DataSet
    Dim ds_tbSiparisIslem As DataSet
    Dim ds_tbSiparisToplam As New DataSet
    Dim ds_tbFirma As New DataSet
    Dim ds_tbHesapPlani As New DataSet
    Dim ds_stok As DataSet
    Dim ds_tbOdemePlani As DataSet
    Dim ds_FiyatSinirla As New DataSet
    Dim sorgu_txt_baslik As String = ""
    Dim sorgu_txt_hareket As String = ""
    Dim sorgu_txt_toplam As String = ""
    Dim sorgu_txt_firma As String = ""
    Public yeni As Boolean = False
    Dim status As Boolean = False
    Public islemstatus As Boolean = False
    Dim dr_baslik As DataRow
    Dim dr_hareket As DataRow
    Dim dr_toplam As DataRow
    Dim Yuklendi As Boolean = False
    Dim okut As Boolean = False
    Dim mevcut As Decimal = 1
    Dim nSatir As Integer = -1
    Dim bSayisal As Boolean = False
    Dim bDahil As Boolean = False
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub frm_tbSiparis_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Timer1.Enabled = False
        Timer1.Dispose()
    End Sub
    Private Sub frm_tbSiparis_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            loaded()
        Catch ex As Exception
            loaded()
        End Try
        yuklendi = True
        status = True
        dg.Focus()
    End Sub
    Private Sub loaded()
        Try
            Dataload_tbFiyatlandir()
        Catch ex As Exception
            sorgula_Decimal("CREATE TABLE [tbFiyatlandir] ([sGrup] [varcharkisa] NOT NULL ,[sKodu] [varcharkisa] NOT NULL ,[sAciklama] [varcharUzun] NOT NULL ,[sOdemePlani] [OdemeKodu] NOT NULL ,[sNokta] [varcharkisa] NOT NULL ,[nIskontoYuzdesi1] [Yuzde] NOT NULL ,[nIskontoYuzdesi2] [Yuzde] NOT NULL ,[nIskontoYuzdesi3] [Yuzde] NOT NULL ,[nIskontoYuzdesi4] [Yuzde] NOT NULL ,[nIskontoYuzdesi5] [Yuzde] NOT NULL ,[b1Yaz] [bit] NOT NULL ,[b2Yaz] [bit] NOT NULL ,[b3Yaz] [bit] NOT NULL ,[b4Yaz] [bit] NOT NULL ,[b5Yaz] [bit] NOT NULL ,[b1Var] [bit] NOT NULL ,[b2Var] [bit] NOT NULL ,[b3Var] [bit] NOT NULL ,[b4Var] [bit] NOT NULL ,[b5Var] [bit] NOT NULL ) ON [PRIMARY]")
            Dataload_tbFiyatlandir()
        End Try
    End Sub
    Public Function sorgula_nStokID(ByVal query As String) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con = New OleDb.OleDbConnection(sConnection)
        cmd.CommandTimeout = False
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = query
        Dim kayitsayisi = sorgu_sayi(cmd.ExecuteScalar, 0)
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
        cmd = Nothing
    End Function
    Private Sub dataload_tbOdemePlani()
        ds_tbOdemePlani = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     LOGICALREF AS nOdemeID, CODE AS sKodu, DEFINITION_ AS sAciklama FROM         LG_*!F_PAYPLANS ORDER BY CODE"))
        'sec_sOdemePlani.DataSource = ds_tbOdemePlani.Tables(0)
        'sec_sOdemePlani.DisplayMember = "sKodu"
        'sec_sOdemePlani.ValueMember = "nOdemeID"
        'sec_sOdemePlani.SelectedIndex = 7
    End Sub
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Başlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "İçerir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
        ElseIf kriter = "Boş" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklı" Then
            sorgu_kriter = " <> '" & deger & "' "
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = " >  '" & deger & "' "
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = " < '" & deger & "' "
        ElseIf kriter = "Eşittir" Then
            sorgu_kriter = " = '" & deger & "' "
        End If
        Return sorgu_kriter
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", nFirmano.ToString)
        query = Replace(query, "!D", nDonemno.ToString)
        Return query
    End Function
    Private Function yetki_kontrol(ByVal kullanici As Int64, ByVal frm As String) As Boolean
        Dim yetki As Int64 = Sorgu_Yetki(kullanici, frm)
        Dim pass As Boolean = False
        If yetki = 0 Then
            XtraMessageBox.Show("Üzgünüm Yetkiniz Yok!" & vbCrLf & "Lütfen Sistem Yönecinizle Görüşün..." & vbCrLf & "FormID: " & frm, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            status = True
            pass = False
        ElseIf yetki = 1 Then
            pass = True
        End If
        Return pass
    End Function
    Private Function Sorgu_Yetki(ByVal kasiyerno As Int64, ByVal Form As String, Optional ByVal islem As Integer = 0, Optional ByVal bYetki As Integer = 0) As Int64
        Dim kriter
        kriter = " WHERE     (Personel.PersonelNo = " & kasiyerno & ") AND (Forms.Form = '" & Form & "') "
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con = New OleDb.OleDbConnection(sConnection)
        cmd.CommandTimeout = False
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Dim kayitsayisi As Int64 = 0
        Dim formkayitsayisi As Int64 = 0
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS Kayit FROM         aEmirForms WHERE     (Form = '" & Form & "')")
        formkayitsayisi = cmd.ExecuteScalar
        If formkayitsayisi = 0 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO aEmirForms (Modul, Form, Aciklama, DefaultYetki) VALUES     ('Genel', '" & Form & "', '" & Form & "', " & bYetki & ")")
            cmd.ExecuteNonQuery()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(CAST(Personel.Yetki AS int), 0) AS Yetki FROM         aPersonelYetki Personel INNER JOIN                       aEmirForms Forms ON Personel.Form = Forms.Form  " & kriter & "")
        kayitsayisi = cmd.ExecuteScalar
        con.Close()
        If islem = 1 Then
            If kayitsayisi = 0 Then
                kayitsayisi = 1
            ElseIf kayitsayisi = 1 Then
                kayitsayisi = 0
            End If
        End If
        Return kayitsayisi
        'kayitsayisi = Nothing
        formkayitsayisi = Nothing
    End Function
    Private Function sorgu(ByVal query As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim conn As OleDb.OleDbConnection = New OleDb.OleDbConnection(sConnection)
        adapter.SelectCommand = cmd
        cmd.CommandTimeout = False
        cmd.Connection = conn
        cmd.CommandText = query
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        conn.Close()
        cmd = Nothing
        conn = Nothing
        adapter = Nothing
        Return DS
    End Function
    Public Sub Dataload_tbFiyatlandir()
        status = True
        Try
            ds_tbSiparis.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection(sConnection)
        adapter.SelectCommand = cmd
        cmd.CommandTimeout = 180
        cmd.Connection = con
        'CAST(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutFiyat,CAST(tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutTutar
        'CAST(tbSiparis.PRICE * (100 + tbSiparis.VAT) / 100 AS FLOAT) AS lDahilBrutFiyat,CAST(tbSiparis.TOTAL * (100 + tbSiparis.VAT) / 100 AS FLOAT) AS lDahilBrutTutar
        cmd.CommandText = sorgu_query("SELECT     * FROM         tbFiyatlandir ORDER BY sGrup")
        sorgu_txt_hareket = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim N As Integer = adapter.Fill(ds_tbSiparis, "Table1")
        con.Close()
        dg.DataSource = ds_tbSiparis.Tables(0)
        'Dataload_tbYekun(dteSiparisTarihi, nSiparisTipi, lSiparisNo, nFirmaID)
        If ds_tbSiparis.Tables(0).Rows.Count > 0 Then
            dg.CurrentRowIndex = ds_tbSiparis.Tables(0).Rows.Count - 1
            dg.Select(dg.CurrentRowIndex)
        End If
        status = False
    End Sub
    Public Function sorgu_sAciklama_kontrol(ByVal dteSiparisTarihi As DateTime, ByVal nSiparisTipi As Integer, ByVal lSiparisNo As Int64, ByVal nFirmaID As Int64) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con = New OleDb.OleDbConnection(sConnection)
        cmd.CommandTimeout = False
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(*),0) AS nKayit FROM tbSiparisAciklamasi WHERE (nSiparisTipi = " & nSiparisTipi & ") AND (lSiparisNo = " & lSiparisNo & ") and (nFirmaID = " & nFirmaID & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        con.Close()
        con = Nothing
        cmd = Nothing
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Public Function sorgu_sHareketTipi_kontrol(ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As String, ByVal lFisNo As Int64) As String
        Dim kriter
        kriter = ""
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con = New OleDb.OleDbConnection(sConnection)
        cmd.CommandTimeout = False
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT ISNULL(sHareketTipi,'') as sHareketTipi FROM         tbMuhasebeFisi WHERE (dteFisTarihi = '" & dteFisTarihi & "') AND (sMuhFisTipi = " & sMuhFisTipi & ") AND (lFisno = " & lFisNo & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        con.Close()
        con = Nothing
        cmd = Nothing
        Return kayitsayisi
    End Function
    Public Function sorgu_sSubeMagaza_kontrol(ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As String, ByVal lFisNo As Int64) As String
        Dim kriter
        kriter = ""
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con = New OleDb.OleDbConnection(sConnection)
        cmd.CommandTimeout = False
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT ISNULL(sSubeMagaza,'') as sSubeMagaza FROM         tbMuhasebeFisi WHERE (dteFisTarihi = '" & dteFisTarihi & "') AND (sMuhFisTipi = " & sMuhFisTipi & ") AND (lFisno = " & lFisNo & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        con.Close()
        con = Nothing
        cmd = Nothing
        Return kayitsayisi
    End Function
    Private Sub tbFiyatlandir_kaydet_yeni(ByVal sGrup As String, ByVal sKodu As String, ByVal sAciklama As String, ByVal sOdemePlani As String, ByVal sNokta As String, ByVal nIskontoYuzdesi1 As Decimal, ByVal nIskontoYuzdesi2 As Decimal, ByVal nIskontoYuzdesi3 As Decimal, ByVal nIskontoYuzdesi4 As Decimal, ByVal nIskontoYuzdesi5 As Decimal, ByVal b1Yaz As Byte, ByVal b2Yaz As Byte, ByVal b3Yaz As Byte, ByVal b4Yaz As Byte, ByVal b5Yaz As Byte, ByVal b1Var As Byte, ByVal b2Var As Byte, ByVal b3Var As Byte, ByVal b4Var As Byte, ByVal b5Var As Byte)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con = New OleDb.OleDbConnection(sConnection)
        cmd.CommandTimeout = False
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("INSERT INTO tbFiyatlandir                       (sGrup, sKodu, sAciklama, sOdemePlani, sNokta, nIskontoYuzdesi1, nIskontoYuzdesi2, nIskontoYuzdesi3, nIskontoYuzdesi4, nIskontoYuzdesi5, b1Yaz, b2Yaz,b3Yaz, b4Yaz, b5Yaz, b1Var, b2Var, b3Var, b4Var, b5Var) VALUES     ('" & sGrup & "', '" & sKodu & "', '" & sAciklama & "', '" & sOdemePlani & "', '" & sNokta & "', " & nIskontoYuzdesi1 & ", " & nIskontoYuzdesi2 & ", " & nIskontoYuzdesi3 & ", " & nIskontoYuzdesi4 & ", " & nIskontoYuzdesi5 & ", " & b1Yaz & ", " & b2Yaz & "," & b3Yaz & ", " & b4Yaz & ", " & b5Yaz & ", " & b1Var & ", " & b2Var & ", " & b3Var & ", " & b4Var & ", " & b5Var & ")")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbFiyatlandir_kaydet_duzelt(ByVal sGrup As String, ByVal sKodu As String, ByVal sAciklama As String, ByVal sOdemePlani As String, ByVal sNokta As String, ByVal nIskontoYuzdesi1 As Decimal, ByVal nIskontoYuzdesi2 As Decimal, ByVal nIskontoYuzdesi3 As Decimal, ByVal nIskontoYuzdesi4 As Decimal, ByVal nIskontoYuzdesi5 As Decimal, ByVal b1Yaz As Byte, ByVal b2Yaz As Byte, ByVal b3Yaz As Byte, ByVal b4Yaz As Byte, ByVal b5Yaz As Byte, ByVal b1Var As Byte, ByVal b2Var As Byte, ByVal b3Var As Byte, ByVal b4Var As Byte, ByVal b5Var As Byte)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con = New OleDb.OleDbConnection(sConnection)
        cmd.CommandTimeout = False
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("UPDATE    tbFiyatlandir SET               nIskontoYuzdesi1 = " & nIskontoYuzdesi1 & ", nIskontoYuzdesi2 = " & nIskontoYuzdesi2 & ", nIskontoYuzdesi3 = " & nIskontoYuzdesi3 & ", nIskontoYuzdesi4 = " & nIskontoYuzdesi4 & ", nIskontoYuzdesi5 = " & nIskontoYuzdesi5 & ",b1Yaz = " & b1Yaz & ", b2Yaz = " & b2Yaz & ", b3Yaz = " & b3Yaz & ", b4Yaz = " & b4Yaz & ", b5Yaz = " & b5Yaz & ", b1Var = " & b1Var & ", b2Var = " & b2Var & ", b3Var = " & b3Var & ", b4Var = " & b4Var & ", b5Var = " & b5Var & " Where sGrup = '" & sGrup & "' and  sKodu = '" & sKodu & "' and  sOdemePlani = '" & sOdemePlani & "'and sNokta = '" & sNokta & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbFiyatlandir_kaydet_sil(ByVal sGrup As String, ByVal sKodu As String, ByVal sOdemePlani As String, ByVal sNokta As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con = New OleDb.OleDbConnection(sConnection)
        cmd.CommandTimeout = False
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM     tbFiyatlandir  Where sGrup = '" & sGrup & "' and  sKodu = '" & sKodu & "' and  sOdemePlani = '" & sOdemePlani & "'and sNokta = '" & sNokta & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub sorgu_tbFiyatlandirma(ByVal sGrup As String, ByVal sOdemePlani As String, ByVal sNokta As String)
        If sOdemePlani = "00" Then
        Else
            sOdemePlani = "PH"
        End If
        If Trim(sNokta) = "" Then
            sNokta = "B"
        End If
        ds_FiyatSinirla = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *  FROM         LG_*!F_Fiyatlandir WHERE     (sGrup = '" & sGrup & "') AND (sOdemePlani = '" & sOdemePlani & "') AND (sNokta = '" & sNokta & "' OR sNokta = 'H') "))
        'Dim dr As DataRow
        'For Each dr In ds_FiyatSinirla.Tables(0).Rows
        '    XtraMessageBox.Show(dr(0) & vbTab & dr(1) & vbTab & dr(2))
        'Next
    End Sub
    Private Sub satir_ekle_stok_tek(Optional ByVal ara As String = "")
        Dim dr As DataRow = ds_tbSiparis.Tables(0).NewRow
        dr("sGrup") = txt_sGrup.Text
        dr("sKodu") = txt_sGrup.Text
        dr("sAciklama") = txt_sAciklama.Text
        dr("sOdemePlani") = txt_sOdemePlani.Text
        dr("sNokta") = txt_sNokta.Text
        dr("nIskontoYuzdesi1") = txt_nIskontoYuzdesi1.Text
        dr("nIskontoYuzdesi2") = txt_nIskontoYuzdesi2.Text
        dr("nIskontoYuzdesi3") = txt_nIskontoYuzdesi3.Text
        dr("nIskontoYuzdesi4") = txt_nIskontoYuzdesi4.Text
        dr("nIskontoYuzdesi5") = txt_nIskontoYuzdesi5.Text
        dr("b1Yaz") = sec_b1Yaz.Checked
        dr("b2Yaz") = sec_b2Yaz.Checked
        dr("b3Yaz") = sec_b3Yaz.Checked
        dr("b4Yaz") = sec_b4Yaz.Checked
        dr("b5Yaz") = sec_b5Yaz.Checked
        dr("b1Var") = sec_b1Var.Checked
        dr("b2Var") = sec_b2Var.Checked
        dr("b3Var") = sec_b3Var.Checked
        dr("b4Var") = sec_b4Var.Checked
        dr("b5Var") = sec_b5Var.Checked
        tbFiyatlandir_kaydet_yeni(dr("sGrup"), dr("sKodu"), dr("sAciklama"), dr("sOdemePlani"), dr("sNokta"), dr("nIskontoYuzdesi1"), dr("nIskontoYuzdesi2"), dr("nIskontoYuzdesi3"), dr("nIskontoYuzdesi4"), dr("nIskontoYuzdesi5"), dr("b1Yaz"), dr("b2Yaz"), dr("b3Yaz"), dr("b4Yaz"), dr("b5Yaz"), dr("b1Var"), dr("b2Var"), dr("b3Var"), dr("b4Var"), dr("b5Var"))
        ds_tbSiparis.Tables(0).Rows.Add(dr)
        If ds_tbSiparis.Tables(0).Rows.Count > 0 Then
            dg.CurrentRowIndex = ds_tbSiparis.Tables(0).Rows.Count - 1
            dg.Select(dg.CurrentRowIndex)
        End If
        yeni = False
        status = False
        TabControl1.SelectedIndex = 0
        Button11.Enabled = False
        lbl_info.Text = "Ekle"
        btn_degistir.Enabled = False
        txt_sAra.Enabled = True
        txt_sAra.Visible = True
        txt_sAra.Text = ""
        txt_sAra.Focus()
    End Sub
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        Try
            If deger.ToString = "" Then
                deger = sonuc
            End If
        Catch ex As Exception
            deger = sonuc
        End Try
        Return deger
    End Function
    Private Sub satir_sil()
        If ds_tbSiparis.Tables(0).Rows.Count > 0 Then
            If XtraMessageBox.Show("Satırı Silmek İstediğinize Eminsiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dr As DataRow
                dr = ds_tbSiparis.Tables(0).Rows(dg.CurrentRowIndex)
                Try
                    tbFiyatlandir_kaydet_sil(dr("sGrup"), dr("sKodu"), dr("sOdemePlani"), dr("sNokta"))
                Catch ex As Exception
                End Try
                Dataload_tbFiyatlandir()
                dg.Focus()
            End If
        End If
    End Sub
    Private Sub tutar_hesapla(Optional ByVal nSatirSec As Int16 = -1)
        If ds_tbSiparis.Tables(0).Rows.Count > 0 Then
            Dim dr As DataRow = ds_tbSiparis.Tables(0).Rows(dg.CurrentRowIndex)
            dr("sGrup") = txt_sGrup.Text
            dr("sKodu") = txt_sGrup.Text
            dr("sAciklama") = txt_sAciklama.Text
            dr("sOdemePlani") = txt_sOdemePlani.Text
            dr("sNokta") = txt_sNokta.Text
            dr("nIskontoYuzdesi1") = txt_nIskontoYuzdesi1.Text
            dr("nIskontoYuzdesi2") = txt_nIskontoYuzdesi2.Text
            dr("nIskontoYuzdesi3") = txt_nIskontoYuzdesi3.Text
            dr("nIskontoYuzdesi4") = txt_nIskontoYuzdesi4.Text
            dr("nIskontoYuzdesi5") = txt_nIskontoYuzdesi5.Text
            dr("b1Yaz") = sec_b1Yaz.Checked
            dr("b2Yaz") = sec_b2Yaz.Checked
            dr("b3Yaz") = sec_b3Yaz.Checked
            dr("b4Yaz") = sec_b4Yaz.Checked
            dr("b5Yaz") = sec_b5Yaz.Checked
            dr("b1Var") = sec_b1Var.Checked
            dr("b2Var") = sec_b2Var.Checked
            dr("b3Var") = sec_b3Var.Checked
            dr("b4Var") = sec_b4Var.Checked
            dr("b5Var") = sec_b5Var.Checked
            tbFiyatlandir_kaydet_duzelt(dr("sGrup"), dr("sKodu"), dr("sAciklama"), dr("sOdemePlani"), dr("sNokta"), dr("nIskontoYuzdesi1"), dr("nIskontoYuzdesi2"), dr("nIskontoYuzdesi3"), dr("nIskontoYuzdesi4"), dr("nIskontoYuzdesi5"), dr("b1Yaz"), dr("b2Yaz"), dr("b3Yaz"), dr("b4Yaz"), dr("b5Yaz"), dr("b1Var"), dr("b2Var"), dr("b3Var"), dr("b4Var"), dr("b5Var"))
            dr = Nothing
        End If
    End Sub
    Public Function degeruzunlukkontrol(ByVal deger As String, ByVal uzunluk As String) As String
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
    Private Function uzunluk_tamamla(ByVal deger As String, ByVal uzunluk As Int64, Optional ByVal simge As String = "0") As String
        deger = FormatNumber(deger, 2)
        If Len(deger) < uzunluk Then
            Dim fark As Integer = uzunluk - Len(deger)
            Dim i As Integer
            For i = 1 To fark
                deger = deger.Insert(0, simge)
            Next
        End If
        Return deger
    End Function
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        satir_sil()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lbl_info.Text = "Ekle"
        btn_degistir.Enabled = False
        txt_sAra.Enabled = True
        txt_sAra.Visible = True
        txt_sAra.Text = ""
        txt_sAra.Focus()
        ''ınputPanel1.Visible = True
    End Sub
    Private Sub txt_sAra_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_sAra.DoubleClick
        'ınputPanel1.Visible = True
    End Sub
    Private Sub txt_sAra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_sAra.KeyDown
        If e.KeyCode = Keys.Right Then
            'Dim colon = dg.CurrentCell.ColumnNumber
            'Dim satir = dg.CurrentRowIndex
            ''dg.CurrentCell.RowNumber = dg.CurrentCell.RowNumber = satir
            'dg.CurrentCell.Equals(satir, colon + 1)
            'colon = Nothing
            'satir = Nothing
        ElseIf e.KeyCode = Keys.Left Then
            'Dim colon = dg.CurrentCell.ColumnNumber
            'Dim satir = dg.CurrentRowIndex
            ''dg.CurrentCell = CType("DataGridCell {RowNumber = " & satir & " , ColumnNumber = " & colon - 1 & "}", DataGridCell)
            ''dg.CurrentCell = dg.CurrentCell.RowNumber = satir And dg.CurrentCell.ColumnNumber - 1
            'dg.CurrentCell.Equals(satir, colon - 1)
            'colon = Nothing
            'satir = Nothing
        ElseIf e.KeyCode = Keys.Up Then
            If ds_tbSiparis.Tables(0).Rows.Count > 1 Then
                Try
                    dg.CurrentRowIndex -= 1
                Catch ex As Exception
                End Try
            End If
        ElseIf e.KeyCode = Keys.Down Then
            If dg.CurrentRowIndex < ds_tbSiparis.Tables(0).Rows.Count Then
                Try
                    dg.CurrentRowIndex += 1
                Catch ex As Exception
                End Try
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            If lbl_info.Text = "Ekle" Then
                Try
                    stok_ara()
                Catch ex As Exception
                    mevcut = 1
                    stok_kontrol()
                End Try
            Else
                Try
                    'satir_degistir()
                Catch ex As Exception
                    XtraMessageBox.Show("Lutfen İsleminizi Kontrol Ediniz...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End If
        End If
    End Sub
    Private Sub stok_ara()
        If Trim(txt_sAra.Text) <> "" Then
            Dim X As String
            Label2.Text = "Barkod Standardı Kontrol Ediliyor..."
            Label2.Refresh()
            Dim barcodestd As String = ""
            Try
                barcodestd = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").GetValue("BARCODESTD")
            Catch ex As Exception
                barcodestd = "27"
                Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").SetValue("BARCODESTD", barcodestd)
            End Try
            If barcodestd.ToString = "" Then
                barcodestd = "27"
                Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").SetValue("BARCODESTD", barcodestd)
            End If
            If IsNumeric(Trim(txt_sAra.Text)) = True Then
                If Len(Trim(txt_sAra.Text).ToString) < 2 Then
                    txt_sAra.Text = Trim(txt_sAra.Text) + "  "
                End If
                If Trim((Trim(txt_sAra.Text)).Substring(0, 2)) = barcodestd Then
                    Dim deger As String = Trim(Trim(txt_sAra.Text))
                    If IsNumeric(deger) = True Then
                        mevcut = CType((deger.Substring(7, sBarcodeStd_KG) + "." + deger.Substring(7 + sBarcodeStd_KG, sBarcodeStd_GR)), Decimal)
                        txt_sAra.Text = deger.Substring(2, 5)
                    End If
                Else
                    mevcut = 1
                End If
            Else
                If CStr(Trim(txt_sAra.Text).ToString) <> "" Then
                    X = (Trim(txt_sAra.Text)).IndexOf("*", 1, (Trim(txt_sAra.Text)).Length - 1)
                    If X = -1 Then
                        mevcut = 1
                    Else
                        mevcut = (Trim(txt_sAra.Text)).Substring(0, X)
                        txt_sAra.Text = (Trim(txt_sAra.Text)).Substring((X + 1), (Trim(txt_sAra.Text)).Length - (X + 1))
                        If IsNumeric(Trim(txt_sAra.Text)) Then
                        Else
                        End If
                    End If
                End If
            End If
            barcodestd = Nothing
            Label2.Text = "Barkod Standardı Kontrolü Tamamlandı..."
            Label2.Refresh()
            stok_kontrol()
        End If
    End Sub
    Private Sub stok_kontrol()
        If IsNumeric(Trim(txt_sAra.Text)) = True Then
            okut = True
        Else
            okut = False
        End If
        Label2.Text = "Stok Kartı Kontrolü Yapılıyor..."
        Label2.Refresh()
        Dim kontrol = sorgu_stok_kontrol(txt_sAra.Text)
        If kontrol = 0 Then
            If XtraMessageBox.Show("Kayıt Bulunumadı..." & vbCrLf & "Yeni Stok Kaydetmek İstermisiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                'Stok_Yeni(txt_sAra.Text)
            End If
            Label2.Text = "Stok Kaydı Bulunamadı!!!.Tekrar Deneyiniz..."
            Label2.Refresh()
            txt_sAra.Focus()
            txt_sAra.SelectAll()
        ElseIf kontrol = 1 Then
            Label2.Text = "Belge Stok Kaydı Kontrol Ediliyor... "
            Label2.Refresh()
            'MsgBox("Kayıt Tek...")
            dataload_stok(Trim(txt_sAra.Text))
            Label2.Text = "Stok Bilgisi Yükleniyor... "
            Label2.Refresh()
            satir_ekle_stok_tek(False)
            txt_sAra.Text = ""
            txt_sAra.Focus()
            txt_sAra.SelectAll()
        ElseIf kontrol > 1 Then
            Label2.Text = "Stok Satıra İşlendi...Yeni Ürün Okutun..."
            Label2.Refresh()
            txt_sAra.Text = ""
            txt_sAra.Focus()
            txt_sAra.SelectAll()
        End If
    End Sub
    Public Function sorgu_stok_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "AND (tbStok.CODE like  '" & kod & "%') or (tbStok.NAME like  '" & kod & "%')  or (tbStok.EANBARCODE like '" & kod & "%') "
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con = New OleDb.OleDbConnection(sConnection)
        cmd.CommandTimeout = False
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  ISNULL(COUNT(*), 0) AS KAYIT FROM LG_*!F_UNITSETL tbBirimSet RIGHT OUTER JOIN LG_*!F_ITEMS tbStok ON tbBirimSet.UNITSETREF = tbStok.UNITSETREF WHERE (tbStok.CODE <> '') AND (tbBirimSet.MAINUNIT = 1) " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        con.Close()
        con = Nothing
        cmd = Nothing
        Return kayitsayisi
    End Function
    Private Sub dataload_stok(ByVal kod As String)
        Dim kriter
        kriter = "AND (tbStok.CODE like '" & kod & "%') or (tbStok.NAME like '" & kod & "%')  or  (tbStok.EANBARCODE like '" & kod & "%') "
        ds_stok = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  tbStok.LOGICALREF AS nStokID, tbStok.NAME AS sAciklama, tbStok.CODE AS sKodu, tbStok.SPECODE AS SINIF1, tbStok.SPECODE2 AS SINIF2, tbStok.SPECODE3 AS SINIF3, tbStok.SPECODE4 AS SINIF4, tbStok.SPECODE5 AS SINIF5, tbStok.VAT AS nKdvOrani, ISNULL((SELECT TOP 1 PRICE FROM LG_*!F_PRCLIST WHERE CARDREF = tbStok.LOGICALREF AND PTYPE = 2 AND PRIORITY = 1), 0) AS lFiyat1, ISNULL((SELECT TOP 1 PRICE FROM LG_*!F_PRCLIST WHERE CARDREF = tbStok.LOGICALREF AND PTYPE = 2 AND PRIORITY = 2), 0) AS lFiyat2, ISNULL((SELECT TOP 1 PRICE FROM LG_*!F_PRCLIST WHERE CARDREF = tbStok.LOGICALREF AND PTYPE = 2 AND PRIORITY = 3), 0) AS lFiyat3, ISNULL((SELECT TOP 1 PRICE FROM LG_*!F_PRCLIST WHERE CARDREF = tbStok.LOGICALREF AND PTYPE = 1), 0) AS lAlis, ISNULL((SELECT TOP 1 PRICE FROM LG_*!F_PRCLIST WHERE CARDREF = tbStok.LOGICALREF AND PTYPE = 1), 0) AS lMaliyet, (SELECT ISNULL(ONHAND , 0) lMevcut FROM LG_*!F_!D_GNTOTST GNSTITOT WHERE (INVENNO = - 1) AND STOCKREF = tbStok.LOGICALREF) AS lMevcut, tbStok.EANBARCODE AS sBarkod, tbBirimSet.LOGICALREF AS UOMREF, tbBirimSet.UNITSETREF AS USREF, tbBirimSet.CONVFACT1 AS UINFO1, tbBirimSet.CONVFACT2 AS UINFO1, tbBirimSet.CODE AS sBirimCinsi FROM LG_*!F_UNITSETL tbBirimSet RIGHT OUTER JOIN LG_*!F_ITEMS tbStok ON tbBirimSet.UNITSETREF = tbStok.UNITSETREF WHERE (tbStok.CODE <> '') AND (tbBirimSet.MAINUNIT = 1) " & kriter & " ORDER BY tbStok.CODE"))
    End Sub
    Private Sub dg_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.CurrentCellChanged
        If ds_tbSiparis.Tables(0).Rows.Count > 0 Then
            Dim dr As DataRow = ds_tbSiparis.Tables(0).Rows(dg.CurrentRowIndex)
            If dg.CurrentCell.ColumnNumber = 0 Then
                lbl_info.Text = "Grup:"
                txt_sAra.Text = dr("sGrup")
                txt_sAra.Enabled = False
                btn_degistir.Enabled = False
                txt_sAra.Visible = True
                bSayisal = False
            ElseIf dg.CurrentCell.ColumnNumber = 1 Then
                lbl_info.Text = "Aciklama:"
                txt_sAra.Text = dr("sAciklama")
                txt_sAra.Enabled = False
                btn_degistir.Enabled = False
                txt_sAra.Visible = True
                bSayisal = False
            ElseIf dg.CurrentCell.ColumnNumber = 2 Then
                lbl_info.Text = "Ödeme:"
                txt_sAra.Text = dr("sOdemePlani")
                txt_sAra.Enabled = False
                btn_degistir.Enabled = False
                txt_sAra.Visible = True
                bSayisal = False
            ElseIf dg.CurrentCell.ColumnNumber = 3 Then
                lbl_info.Text = "Nokta:"
                txt_sAra.Text = dr("sNokta")
                txt_sAra.Enabled = False
                btn_degistir.Enabled = False
                txt_sAra.Visible = True
                bSayisal = False
            ElseIf dg.CurrentCell.ColumnNumber = 4 Then
                lbl_info.Text = "Isk1:"
                txt_sAra.Text = dr("nIskontoYuzdesi1")
                txt_sAra.Enabled = False
                btn_degistir.Enabled = False
                txt_sAra.Visible = True
                bSayisal = False
            ElseIf dg.CurrentCell.ColumnNumber = 5 Then
                lbl_info.Text = "Isk2:"
                txt_sAra.Text = dr("nIskontoYuzdesi2")
                txt_sAra.Enabled = False
                btn_degistir.Enabled = False
                txt_sAra.Visible = True
                bSayisal = False
            ElseIf dg.CurrentCell.ColumnNumber = 6 Then
                lbl_info.Text = "Isk3:"
                txt_sAra.Text = dr("nIskontoYuzdesi3")
                txt_sAra.Enabled = False
                btn_degistir.Enabled = False
                txt_sAra.Visible = True
                bSayisal = False
            ElseIf dg.CurrentCell.ColumnNumber = 7 Then
                lbl_info.Text = "Isk4:"
                txt_sAra.Text = dr("nIskontoYuzdesi4")
                txt_sAra.Enabled = False
                btn_degistir.Enabled = False
                txt_sAra.Visible = True
                bSayisal = False
            ElseIf dg.CurrentCell.ColumnNumber = 8 Then
                lbl_info.Text = "Isk5:"
                txt_sAra.Text = dr("nIskontoYuzdesi5")
                txt_sAra.Enabled = False
                btn_degistir.Enabled = False
                txt_sAra.Visible = True
                bSayisal = False
            ElseIf dg.CurrentCell.ColumnNumber = 9 Then
                lbl_info.Text = "Isk1Yaz:"
                txt_sAra.Text = dr("b1Yaz")
                txt_sAra.Enabled = False
                btn_degistir.Enabled = False
                txt_sAra.Visible = True
                bSayisal = False
            ElseIf dg.CurrentCell.ColumnNumber = 10 Then
                lbl_info.Text = "Isk2Yaz:"
                txt_sAra.Text = dr("b2Yaz")
                txt_sAra.Enabled = False
                btn_degistir.Enabled = False
                txt_sAra.Visible = True
                bSayisal = False
            ElseIf dg.CurrentCell.ColumnNumber = 11 Then
                lbl_info.Text = "Isk3Yaz:"
                txt_sAra.Text = dr("b3Yaz")
                txt_sAra.Enabled = False
                btn_degistir.Enabled = False
                txt_sAra.Visible = True
                bSayisal = False
            ElseIf dg.CurrentCell.ColumnNumber = 12 Then
                lbl_info.Text = "Isk4Yaz:"
                txt_sAra.Text = dr("b4Yaz")
                txt_sAra.Enabled = False
                btn_degistir.Enabled = False
                txt_sAra.Visible = True
                bSayisal = False
            ElseIf dg.CurrentCell.ColumnNumber = 13 Then
                lbl_info.Text = "Isk5Yaz:"
                txt_sAra.Text = dr("b5Yaz")
                txt_sAra.Enabled = False
                btn_degistir.Enabled = False
                txt_sAra.Visible = True
                bSayisal = False
            ElseIf dg.CurrentCell.ColumnNumber = 14 Then
                lbl_info.Text = "Isk1Var:"
                txt_sAra.Text = dr("b1Var")
                txt_sAra.Enabled = False
                btn_degistir.Enabled = False
                txt_sAra.Visible = True
                bSayisal = False
            ElseIf dg.CurrentCell.ColumnNumber = 15 Then
                lbl_info.Text = "Isk2Var:"
                txt_sAra.Text = dr("b2Var")
                txt_sAra.Enabled = False
                btn_degistir.Enabled = False
                txt_sAra.Visible = True
                bSayisal = False
            ElseIf dg.CurrentCell.ColumnNumber = 16 Then
                lbl_info.Text = "Isk3Var:"
                txt_sAra.Text = dr("b3Var")
                txt_sAra.Enabled = False
                btn_degistir.Enabled = False
                txt_sAra.Visible = True
                bSayisal = False
            ElseIf dg.CurrentCell.ColumnNumber = 17 Then
                lbl_info.Text = "Isk4Var:"
                txt_sAra.Text = dr("b4Var")
                txt_sAra.Enabled = False
                btn_degistir.Enabled = False
                txt_sAra.Visible = True
                bSayisal = False
            ElseIf dg.CurrentCell.ColumnNumber = 18 Then
                lbl_info.Text = "Isk5Var:"
                txt_sAra.Text = dr("b5Var")
                txt_sAra.Enabled = False
                btn_degistir.Enabled = False
                txt_sAra.Visible = True
                bSayisal = False
            End If
            txt_sAra.Text = Trim(txt_sAra.Text)
            txt_sAra.SelectAll()
            If txt_sAra.Visible = True Then
                txt_sAra.Focus()
            End If
        End If
    End Sub
    Private Function tbBirimSet_Carpan(ByVal CODE As String) As Decimal
        Dim drs As DataRow
        Dim lBirimCarpan As Decimal = 1
        For Each drs In ds_BirimSet.Tables(0).Rows
            If drs("CODE") = CODE Then
                lBirimCarpan = drs("CONVFACT1")
            End If
        Next
        Return lBirimCarpan
    End Function
    Private Sub txt_sAra_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_sAra.TextChanged
        If txt_sAra.Text <> "" Then
            If lbl_info.Text <> "Ekle" Then
                txt_sAra.Text = Microsoft.VisualBasic.Replace(txt_sAra.Text, "*", ".")
                txt_sAra.Select(Trim(Len(txt_sAra.Text)) - 0, 1)
                txt_sAra.ScrollToCaret()
            End If
        End If
    End Sub
    Private Sub dg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg.DoubleClick
        If txt_sAra.Visible = True Then
            txt_sAra.Focus()
            txt_sAra.SelectAll()
        End If
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabControl1.SelectedIndex = 0
    End Sub
    Private Sub txt_sSiparisiAlan_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'ınputPanel1.Visible = True
    End Sub
    Private Sub txt_sSiparisiAlan_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'ınputPanel1.Visible = True
    End Sub
    Private Sub txt_sSiparisiAlan_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        'ınputPanel1.Visible = False
    End Sub
    Private Sub txt_sSiparisiVeren_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'ınputPanel1.Visible = True
    End Sub
    Private Sub txt_sSiparisiVeren_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        'ınputPanel1.Visible = False
    End Sub
    Private Sub txt_sNot5_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'ınputPanel1.Visible = True
    End Sub
    Private Sub txt_sNot5_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        'ınputPanel1.Visible = False
    End Sub
    Private Sub txt_sOzelKod_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        'ınputPanel1.Visible = True
    End Sub
    Private Sub txt_sNot1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        ''ınputPanel1.Visible = True
    End Sub
    Private Sub txt_sNot1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        'ınputPanel1.Visible = False
    End Sub
    Private Sub txt_sYetkiKodu_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        'ınputPanel1.Visible = True
    End Sub
    Private Sub txt_sNot2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        ''ınputPanel1.Visible = True
    End Sub
    Private Sub txt_sNot2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        'ınputPanel1.Visible = False
    End Sub
    Private Sub txt_sProjeKodu_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        'ınputPanel1.Visible = True
    End Sub
    Private Sub txt_sNot3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        ''ınputPanel1.Visible = True
    End Sub
    Private Sub txt_sNot3_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        'ınputPanel1.Visible = False
    End Sub
    Private Sub txt_sNot4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        'ınputPanel1.Visible = True
    End Sub
    Private Sub txt_sNot4_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        'ınputPanel1.Visible = False
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbl_Saat.Text = Now.ToLongTimeString
        lbl_baslik.Text = "Iskonto Ayarlama # "
        If Yuklendi = True Then
            Label2.Text = "Kayıt Sayısı :" & ds_tbSiparis.Tables(0).Rows.Count & "/Satır :" & dg.CurrentRowIndex + 1
        End If
    End Sub
    Private Sub lbl_input_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'ınputPanel1.Visible = False
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabControl1.SelectedIndex = 0
    End Sub
    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lbl_info.Text = "Ekle"
        btn_degistir.Enabled = False
        txt_sAra.Enabled = True
        txt_sAra.Visible = True
        txt_sAra.Text = ""
        txt_sAra.Focus()
        'Dim frm As New frm_Klavye
        'If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        '    txt_sAra.Text = frm.txt_sSifre.Text
        '    SendKeys.Send("{Enter}")
        'End If
    End Sub
    Private Sub txt_sAra_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sAra.Validating
        'ınputPanel1.Visible = False
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'ınputPanel1.Visible = True
        txt_sAra.Focus()
        txt_sAra.SelectAll()
        If txt_sAra.Visible = True Then
            txt_sAra.Focus()
            txt_sAra.SelectAll()
        End If
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        TabControl1.SelectedIndex = 0
        Button11.Enabled = False
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        duzelt()
    End Sub
    Private Sub duzelt()
        If ds_tbSiparis.Tables(0).Rows.Count > 0 Then
            Dim dr As DataRow = ds_tbSiparis.Tables(0).Rows(dg.CurrentRowIndex)
            lbl_info.Text = "Duzelt"
            txt_sGrup.Text = dr("sGrup")
            txt_sAciklama.Text = dr("sAciklama")
            txt_sOdemePlani.Text = dr("sOdemePlani")
            txt_sNokta.Text = dr("sNokta")
            txt_nIskontoYuzdesi1.Text = Format(dr("nIskontoYuzdesi1"), "#,0.##")
            txt_nIskontoYuzdesi2.Text = Format(dr("nIskontoYuzdesi2"), "#,0.##")
            txt_nIskontoYuzdesi3.Text = Format(dr("nIskontoYuzdesi3"), "#,0.##")
            txt_nIskontoYuzdesi4.Text = Format(dr("nIskontoYuzdesi4"), "#,0.##")
            txt_nIskontoYuzdesi5.Text = Format(dr("nIskontoYuzdesi5"), "#,0.##")
            sec_b1Yaz.Checked = dr("b1Yaz")
            sec_b2Yaz.Checked = dr("b2Yaz")
            sec_b3Yaz.Checked = dr("b3Yaz")
            sec_b4Yaz.Checked = dr("b4Yaz")
            sec_b5Yaz.Checked = dr("b5Yaz")
            sec_b1Var.Checked = dr("b1Var")
            sec_b2Var.Checked = dr("b2Var")
            sec_b3Var.Checked = dr("b3Var")
            sec_b4Var.Checked = dr("b4Var")
            sec_b5Var.Checked = dr("b5Var")
            txt_sGrup.Enabled = False
            txt_sAciklama.Enabled = True
            txt_sOdemePlani.Enabled = False
            txt_sNokta.Enabled = False
            TabControl1.SelectedIndex = 1
            txt_sGrup.Focus()
            txt_sGrup.SelectAll()
            Button11.Enabled = True
            duzelt_hesapla()
        End If
    End Sub
    Private Sub l_Miktar_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_sGrup.DoubleClick
        'ınputPanel1.Visible = True
    End Sub
    Private Sub l_Miktar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_sGrup.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_sAciklama.Enabled = True Then
                txt_sAciklama.Focus()
                txt_sAciklama.SelectAll()
            Else
                txt_nIskontoYuzdesi1.Focus()
                txt_nIskontoYuzdesi1.SelectAll()
            End If
        End If
    End Sub
    Private Sub l_Fiyat_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_sAciklama.DoubleClick
        ''ınputPanel1.Visible = True
    End Sub
    Private Sub l_Fiyat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_sAciklama.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_nIskontoYuzdesi1.Focus()
            txt_nIskontoYuzdesi1.SelectAll()
        End If
    End Sub
    Private Sub l_Isk1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nIskontoYuzdesi1.DoubleClick
        ''ınputPanel1.Visible = True
    End Sub
    Private Sub l_Isk1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_nIskontoYuzdesi1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_nIskontoYuzdesi2.Enabled = True Then
                txt_nIskontoYuzdesi2.Focus()
                txt_nIskontoYuzdesi2.SelectAll()
            Else
                txt_nIskontoYuzdesi3.Focus()
                txt_nIskontoYuzdesi3.SelectAll()
            End If
        End If
    End Sub
    Private Sub l_Isk2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_nIskontoYuzdesi2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_nIskontoYuzdesi3.Enabled = True Then
                txt_nIskontoYuzdesi3.Focus()
                txt_nIskontoYuzdesi3.SelectAll()
            Else
                Button11.Focus()
                Button11.Select()
            End If
        End If
    End Sub
    Private Sub l_Isk3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_nIskontoYuzdesi3.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_nIskontoYuzdesi4.Focus()
            txt_nIskontoYuzdesi4.SelectAll()
        End If
    End Sub
    Private Sub l_Isk4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_nIskontoYuzdesi4.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_nIskontoYuzdesi5.Focus()
            txt_nIskontoYuzdesi5.SelectAll()
        End If
    End Sub
    Private Sub l_Isk5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_nIskontoYuzdesi5.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button11.Focus()
            Button11.Select()
        End If
    End Sub
    Private Sub duzelt_hesapla()
        Try
            Dim dr As DataRow = ds_tbSiparis.Tables(0).Rows(dg.CurrentRowIndex)
            Dim isk1 As Decimal = 0
            Dim isk2 As Decimal = 0
            Dim isk3 As Decimal = 0
            Dim isk4 As Decimal = 0
            Dim isk5 As Decimal = 0
            Dim isk6 As Decimal = 0
            Dim isk7 As Decimal = 0
            Dim isk8 As Decimal = 0
            Dim lMiktar As Decimal = 0
            Dim lFiyat As Decimal = 0
            Dim lGercekFiyat As Decimal = 0
            Dim lGercekToplam As Decimal = 0
            txt_nIskontoYuzdesi1.Enabled = True
            txt_nIskontoYuzdesi2.Enabled = True
            txt_nIskontoYuzdesi3.Enabled = True
            txt_nIskontoYuzdesi4.Enabled = True
            txt_nIskontoYuzdesi5.Enabled = True
            lFiyat = 100
            lMiktar = 1
            isk1 = lFiyat * ((100 - txt_nIskontoYuzdesi1.Text) / 100)
            isk2 = isk1 * ((100 - txt_nIskontoYuzdesi2.Text) / 100)
            isk3 = isk2 * ((100 - txt_nIskontoYuzdesi3.Text) / 100)
            isk4 = isk3 * ((100 - txt_nIskontoYuzdesi4.Text) / 100)
            isk5 = isk4 * ((100 - txt_nIskontoYuzdesi5.Text) / 100)
            isk6 = isk5
            Try
                txt_nIskontoYuzdesi.Text = Format(((lFiyat - isk6) / lFiyat) * 100, "#,0.00")
            Catch ex As Exception
                txt_nIskontoYuzdesi.Text = 0
            End Try
            lGercekFiyat = isk6
            lGercekToplam = isk6 * lMiktar
            'Dim nKayit = sorgula_nSayi(sorgu_query("SELECT     COUNT(*) AS nKayit FROM         LG_001_Fiyatlandir WHERE     (sGrup = '" & txt_sGrup.Text & "') AND (sOdemePlani = '" & txt_sOdemePlani.Text & "') AND (sNokta = '" & txt_sNokta.Text & "')"))
            'If lbl_info.Text = "Ekle" Then
            '    If nKayit = 0 Then
            '        Button11.Enabled = True
            '    Else
            '        Button11.Enabled = False
            '    End If
            'End If
            'nKayit = Nothing
        Catch ex As Exception
        End Try
    End Sub
    Private Sub l_Miktar_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sGrup.Validating
        'ınputPanel1.Visible = False
    End Sub
    Private Sub l_Fiyat_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sAciklama.Validating
        'ınputPanel1.Visible = False
    End Sub
    Private Sub l_Isk1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_nIskontoYuzdesi1.Validating
        If IsNumeric(txt_nIskontoYuzdesi1.Text) = True Then
        Else
            txt_nIskontoYuzdesi1.Text = 0
            e.Cancel = True
            XtraMessageBox.Show("Lütfen Sayısal Veri Giriniz...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        duzelt_hesapla()
        'ınputPanel1.Visible = False
    End Sub
    Private Sub l_Isk2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_nIskontoYuzdesi2.Validating
        If IsNumeric(txt_nIskontoYuzdesi2.Text) = True Then
        Else
            txt_nIskontoYuzdesi2.Text = 0
            e.Cancel = True
            XtraMessageBox.Show("Lütfen Sayısal Veri Giriniz...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        duzelt_hesapla()
    End Sub
    Private Sub l_Isk3_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_nIskontoYuzdesi3.Validating
        If IsNumeric(txt_nIskontoYuzdesi3.Text) = True Then
        Else
            txt_nIskontoYuzdesi3.Text = 0
            e.Cancel = True
            XtraMessageBox.Show("Lütfen Sayısal Veri Giriniz...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        duzelt_hesapla()
    End Sub
    Private Sub l_Isk4_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_nIskontoYuzdesi4.Validating
        If IsNumeric(txt_nIskontoYuzdesi4.Text) = True Then
        Else
            txt_nIskontoYuzdesi4.Text = 0
            e.Cancel = True
            XtraMessageBox.Show("Lütfen Sayısal Veri Giriniz...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        duzelt_hesapla()
    End Sub
    Private Sub l_Isk5_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_nIskontoYuzdesi5.Validating
        If IsNumeric(txt_nIskontoYuzdesi5.Text) = True Then
        Else
            txt_nIskontoYuzdesi5.Text = 0
            e.Cancel = True
            XtraMessageBox.Show("Lütfen Sayısal Veri Giriniz...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        duzelt_hesapla()
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim nKayit = sorgula_Decimal(sorgu_query("SELECT     COUNT(*) AS nKayit FROM         tbFiyatlandir WHERE     (sGrup = '" & txt_sGrup.Text & "') AND (sOdemePlani = '" & txt_sOdemePlani.Text & "') AND (sNokta = '" & txt_sNokta.Text & "')"))
        If lbl_info.Text = "Ekle" Then
            If nKayit = 0 Then
                satir_ekle_stok_tek()
            Else
                XtraMessageBox.Show("Kayit İcerde Var Lutfen Kontrol Ediniz...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
        nKayit = Nothing
        If lbl_info.Text = "Ekle" Then
            'satir_ekle_stok_tek()
        ElseIf lbl_info.Text = "Duzelt" Then
            TabControl1.SelectedIndex = 0
            Button11.Enabled = False
            If ds_tbSiparis.Tables(0).Rows.Count > 0 Then
                Dim dr As DataRow
                dr = ds_tbSiparis.Tables(0).Rows(dg.CurrentRowIndex)
                dg.Focus()
                dr("sGrup") = txt_sGrup.Text
                dr("sKodu") = txt_sGrup.Text
                dr("sAciklama") = txt_sAciklama.Text
                dr("sOdemePlani") = txt_sOdemePlani.Text
                dr("sNokta") = txt_sNokta.Text
                dr("nIskontoYuzdesi1") = txt_nIskontoYuzdesi1.Text
                dr("nIskontoYuzdesi2") = txt_nIskontoYuzdesi2.Text
                dr("nIskontoYuzdesi3") = txt_nIskontoYuzdesi3.Text
                dr("nIskontoYuzdesi4") = txt_nIskontoYuzdesi4.Text
                dr("nIskontoYuzdesi5") = txt_nIskontoYuzdesi5.Text
                dr("b1Yaz") = sec_b1Yaz.Checked
                dr("b2Yaz") = sec_b2Yaz.Checked
                dr("b3Yaz") = sec_b3Yaz.Checked
                dr("b4Yaz") = sec_b4Yaz.Checked
                dr("b5Yaz") = sec_b5Yaz.Checked
                dr("b1Var") = sec_b1Var.Checked
                dr("b2Var") = sec_b2Var.Checked
                dr("b3Var") = sec_b3Var.Checked
                dr("b4Var") = sec_b4Var.Checked
                dr("b5Var") = sec_b5Var.Checked
                tutar_hesapla()
            End If
        End If
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        lbl_info.Text = "Ekle"
        txt_sGrup.Enabled = True
        txt_sAciklama.Enabled = True
        txt_sOdemePlani.Enabled = True
        txt_sNokta.Enabled = True
        txt_sGrup.Text = ""
        txt_sAciklama.Text = ""
        txt_sOdemePlani.Text = ""
        txt_sNokta.Text = ""
        txt_nIskontoYuzdesi1.Text = 0
        txt_nIskontoYuzdesi2.Text = 0
        txt_nIskontoYuzdesi3.Text = 0
        txt_nIskontoYuzdesi4.Text = 0
        txt_nIskontoYuzdesi5.Text = 0
        sec_b1Yaz.Checked = True
        sec_b2Yaz.Checked = True
        sec_b3Yaz.Checked = True
        sec_b4Yaz.Checked = True
        sec_b5Yaz.Checked = True
        sec_b1Var.Checked = True
        sec_b2Var.Checked = True
        sec_b3Var.Checked = True
        sec_b4Var.Checked = True
        sec_b5Var.Checked = True
        TabControl1.SelectedIndex = 1
        txt_sGrup.Focus()
        txt_sGrup.SelectAll()
        Button11.Enabled = True
    End Sub
End Class