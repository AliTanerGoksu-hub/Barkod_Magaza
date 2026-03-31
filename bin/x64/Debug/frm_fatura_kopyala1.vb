Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Public Class frm_fatura_kopyala1
    Public firmano
    Public donemno
    Public connection
    Public sConnection As String
    Public sUzakConnection As String
    Public connection_orj As String = ""
    Public musterino
    Public kullanici
    Public nFirmaID As Int64 = 0
    Public sKodu As String = ""
    Public sAdi As String = ""
    Public sSoyadi As String = ""
    Public sAdres1 As String = ""
    Public sAdres2 As String = ""
    Public sVergiDairesi As String = ""
    Public sVergiNo As String = ""
    Public bLogo As Boolean = False
    Public bPerakende As Boolean = False
    Dim ds_tbFisTipi As DataSet
    Dim ds_tbGirisCikis As DataSet
    Dim ds_cari As DataSet
    Dim ds_firma As DataSet
    Public sFisTipi As String = ""
    Public nGirisCikis As Int64 = 1
    Public bSiparis As Boolean = False
    Public bSatisYapilamaz As Boolean = False
    Public bAktar As Boolean = False
    Public bMuhasebe As Boolean = False
    Public bTalep As Boolean = False
    Dim status As Boolean = False
    Public kapla As Boolean = False

    Private Sub frm_fatura_kopyala_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If bAktar = True Then
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("GlobalParams1").SetValue("SERVER", txt_Server.Text)
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("GlobalParams1").SetValue("DATABASE", txt_database.Text)
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("GlobalParams1").SetValue("PASSWORD", txt_password.Text)
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("GlobalParams1").SetValue("USER", txt_sKullanici.Text)
        End If
    End Sub
    Private Sub frm_fatura_kopyala_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection_orj = connection
        If bAktar = True Then
            Try
                txt_Server.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("GlobalParams1").GetValue("SERVER")
            Catch ex As Exception
                txt_Server.Text = ""
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("GlobalParams1").SetValue("SERVER", "")
            End Try
            Try
                txt_database.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("GlobalParams1").GetValue("DATABASE")
            Catch ex As Exception
                txt_database.Text = ""
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("GlobalParams1").SetValue("DATABASE", "")
            End Try
            Try
                txt_sKullanici.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("GlobalParams1").GetValue("USER")
            Catch ex As Exception
                txt_sKullanici.Text = "sa"
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("GlobalParams1").SetValue("USER", "")
            End Try
            Try
                txt_password.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("GlobalParams1").GetValue("PASSWORD")
            Catch ex As Exception
                txt_password.Text = ""
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("GlobalParams1").SetValue("PASSWORD", "")
            End Try
        End If
        If bLogo = True Then
            txt_nFirmaNo.Visible = True
            txt_nDonemNo.Visible = True
        End If
        If bAktar = False Then
            GroupControl1.Visible = False
            sec_bAyniFisNo.Enabled = False
            dataload_tbFisTipi()
            dataload_tbGirisCikis(nGirisCikis)
            sec_sFisTipi.EditValue = sFisTipi
            sec_nGirisCikis.EditValue = nGirisCikis
            If kapla = True Then
                sec_sFisTipi.Enabled = True
                sec_nGirisCikis.Enabled = True
            End If
            SimpleButton1.Enabled = True
        Else
            txt_nFirmaNo.Visible = True
            txt_nDonemNo.Visible = True
            sec_bAyniFisNo.Checked = True
        End If
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub gorunum_yukle()
        Label1.Text = Sorgu_sDil(Label1.Text, sDil)
        LabelControl1.Text = Sorgu_sDil(LabelControl1.Text, sDil)
        LabelControl2.Text = Sorgu_sDil(LabelControl2.Text, sDil)
        LabelControl3.Text = Sorgu_sDil(LabelControl3.Text, sDil)
        LabelControl4.Text = Sorgu_sDil(LabelControl4.Text, sDil)
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
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
    Private Function sorgu_orj(ByVal query As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection_orj
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub dataload_tbFisTipi()
        If bSiparis = True Then
            ds_tbFisTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nSiparisTipi as sFisTipi,sAciklama FROM         tbSiparisTipi Where nSiparisTipi IN (1,2,3,4)"))
        ElseIf bPerakende = True Then
            ds_tbFisTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFisTipi,sAciklama FROM         tbFisTipi Where sFisTipi IN ('K','P','SK','SP')"))
        ElseIf bTalep = True Then
            ds_tbFisTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '0' AS sFisTipi, 'Urun Talep' AS sAciklama UNION ALL SELECT '1' AS sFisTipi, 'Lojistik Talep' AS sAciklama UNION ALL SELECT '2' AS sFisTipi, 'Transfer Talep' AS sAciklama"))
        Else
            'ds_tbFisTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFisTipi,sAciklama FROM         tbFisTipi Where sFisTipi IN ('DG','DC','FS','FA','HA','HS','IA','IS')"))
            ds_tbFisTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFisTipi,sAciklama FROM         tbFisTipi Where sFisTipi IN ('DG','DC','FS','FA','HA','HS','IA','IS') UNION ALL SELECT     '1' AS sFisTipi, 'Alinan Siparis' AS sAciklama UNION ALL SELECT     '2' AS sFisTipi, 'Verilen Siparis' AS sAciklama UNION ALL SELECT     '3' AS sFisTipi, 'Satinalma Sarti' AS sAciklama UNION ALL SELECT     '4' AS sFisTipi, 'Proforma' AS sAciklama "))
        End If
        sec_sFisTipi.Properties.DataSource = ds_tbFisTipi.Tables(0)
        'sec_sFisTipi.EditValue = sFisTipi
        sec_sFisTipi.ItemIndex = 0
    End Sub
    Private Sub dataload_tbGirisCikis(ByVal nGirisCikis As Int64)
        If kapla = False Then
            ds_tbGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nGirisCikis,sAciklama FROM         tbGirisCikis Where nGirisCikis = '" & nGirisCikis & "'"))
            sec_nGirisCikis.Properties.DataSource = ds_tbGirisCikis.Tables(0)
            sec_nGirisCikis.ItemIndex = 0
        ElseIf kapla = True Then
            If bSiparis = False Then
                If sec_sFisTipi.EditValue = "FS " Or sec_sFisTipi.EditValue = "HS " Or sec_sFisTipi.EditValue = "DC " Or sec_sFisTipi.EditValue = "IS " Or sec_sFisTipi.EditValue = "K " Or sec_sFisTipi.EditValue = "P " Or sec_sFisTipi.EditValue = "SK " Or sec_sFisTipi.EditValue = "SP " Then
                    ds_tbGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nGirisCikis,sAciklama FROM         tbGirisCikis Where nGirisCikis IN (3,4)"))
                ElseIf sec_sFisTipi.EditValue = "FA " Or sec_sFisTipi.EditValue = "HA " Or sec_sFisTipi.EditValue = "DG " Or sec_sFisTipi.EditValue = "IA " Then
                    ds_tbGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nGirisCikis,sAciklama FROM         tbGirisCikis Where nGirisCikis IN (1,2)"))
                Else
                    ds_tbGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nGirisCikis,sAciklama FROM         tbGirisCikis Where nGirisCikis IN (3,4)"))
                End If
            Else
                ds_tbGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nGirisCikis,sAciklama FROM         tbGirisCikis Where nGirisCikis IN (1,3)"))
            End If
            sec_nGirisCikis.Properties.DataSource = ds_tbGirisCikis.Tables(0)
            sec_nGirisCikis.EditValue = nGirisCikis
            sec_nGirisCikis.ItemIndex = 0
        End If
    End Sub
    Private Sub firma_sec(Optional ByVal islem As Integer = 0)
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        frm.nGirisCikis = sec_nGirisCikis.EditValue
        frm.bFis = True
        frm.sModul = "Fatura"
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nFirmaID = dr1("nFirmaID")
            sKodu = dr1("sKodu")
            lbl_Firma.Text = dr1("sAciklama")
            bSatisYapilamaz = dr1("bSatisYapilamaz")
            txt_musteriNo.EditValue = sKodu
            musteri_kontrol()
            dr1 = Nothing
        End If
    End Sub
    Private Sub musteri_sec(Optional ByVal islem As Integer = 0)
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.musterino = dr_baslik("FIRMAKODU")
        frm.islemstatus = True
        frm.bSatis = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nFirmaID = dr1("nMusteriID")
            sKodu = dr1("lKodu")
            lbl_Firma.Text = dr1("Musteri")
            sAdi = dr1("sAdi")
            sSoyadi = dr1("sSoyadi")
            sAdres1 = dr1("sEvAdresi1")
            sAdres2 = dr1("sEvAdresi2")
            sVergiDairesi = dr1("sVergiDairesi")
            sVergiNo = dr1("sVergiNo")
            txt_musteriNo.EditValue = sKodu
            musteri_kontrol()
            dr1 = Nothing
        End If
    End Sub
    'Private Function musteri_kontrol() As Boolean
    '    Dim bDevam As Boolean = False
    '    If Trim(txt_musteriNo.EditValue).ToString <> "" Then
    '        Dim kontrol = sorgu_cari_kontrol(txt_musteriNo.EditValue)
    '        If kontrol = 0 Then
    '            If XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý...", sDil) & vbCrLf & Sorgu_sDil("Kaydý Açmak Ýstermisiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '                Me.dataload_carisi(Conversions.ToString(Me.txt_musteriNo.EditValue))
    '                Dim row As DataRow = Me.ds_firma.Tables.Item(0).Rows.Item(0)
    '                Me.tbIl_kaydet_yeni(Conversions.ToString(row.Item("sIl")), "")
    '                Me.tbUlke_kaydet_yeni(Conversions.ToString(row.Item("sUlke")), "")
    '                Me.nFirmaID = Me.firma_kaydet_yeni(Conversions.ToString(row.Item("sKodu")), Conversions.ToString(row.Item("sAciklama")), Conversions.ToDecimal(row.Item("nOzelIskontosu")), Conversions.ToDecimal(row.Item("lKrediLimiti")), Conversions.ToDate(row.Item("dteMutabakatTarihi")), Conversions.ToLong(row.Item("nVadeGun")), Conversions.ToString(row.Item("sHitap")), Conversions.ToString(row.Item("sAdres1")), Conversions.ToString(row.Item("sAdres2")), Conversions.ToString(row.Item("sSemt")), Conversions.ToString(row.Item("sIl")), Conversions.ToString(row.Item("sUlke")), Conversions.ToString(row.Item("sPostaKodu")), Conversions.ToString(row.Item("sVergiDairesi")), Conversions.ToString(row.Item("sVergiNo")), 0, Conversions.ToString(row.Item("sOzelNot")), Conversions.ToString(row.Item("sKullaniciAdi")), Conversions.ToDate(row.Item("dteKayitTarihi")), Conversions.ToString(row.Item("sFiyatTipi")))
    '                Me.firma_siniflari_kaydet_yeni(Conversions.ToString(Me.nFirmaID), "", "", "", "", "")
    '                flag = True
    '                Me.musteri_kontrol()
    '            End If
    '        ElseIf kontrol = 1 Then
    '            dataload_cari(txt_musteriNo.EditValue)
    '            Dim dr As DataRow
    '            For Each dr In ds_cari.Tables(0).Rows
    '                'txt_Musteri.EditValue = dr("MUSTERI")
    '                sKodu = dr("sKodu")
    '                nFirmaID = dr("nFirmaID")
    '                lbl_Firma.Text = dr("sAciklama")
    '            Next
    '            dr = Nothing
    '            bDevam = True
    '        End If
    '    End If
    '    Return bDevam
    'End Function
    Private Function musteri_kontrol() As Boolean
        Dim current As DataRow
        Dim enumerator As IEnumerator
        Dim flag As Boolean = False
        If (Strings.Trim(Conversions.ToString(Me.txt_musteriNo.EditValue)).ToString = "") Then
            Return flag
        End If
        Dim left As Object = Me.sorgu_cari_kontrol(Conversions.ToString(Me.txt_musteriNo.EditValue))
        If Operators.ConditionalCompareObjectEqual(left, 0, False) Then
            If (XtraMessageBox.Show((KeyCode.Sorgu_sDil("Kayýt Bulunumadý...", KeyCode.sDil) & ChrW(13) & ChrW(10) & KeyCode.Sorgu_sDil("Kaydý Açmak Ýstermisiniz...?", KeyCode.sDil)), KeyCode.Sorgu_sDil("Dikkat", KeyCode.sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                Me.dataload_carisi(Conversions.ToString(Me.txt_musteriNo.EditValue))
                Dim row As DataRow = ds_firma.Tables.Item(0).Rows.Item(0)
                Me.tbIl_kaydet_yeni(Conversions.ToString(row.Item("sIl")), "")
                Me.tbUlke_kaydet_yeni(Conversions.ToString(row.Item("sUlke")), "")
                Me.nFirmaID = Me.firma_kaydet_yeni(Conversions.ToString(row.Item("sKodu")), Conversions.ToString(row.Item("sAciklama")), Conversions.ToDecimal(row.Item("nOzelIskontosu")), Conversions.ToDecimal(row.Item("lKrediLimiti")), Conversions.ToDate(row.Item("dteMutabakatTarihi")), Conversions.ToLong(row.Item("nVadeGun")), Conversions.ToString(row.Item("sHitap")), Conversions.ToString(row.Item("sAdres1")), Conversions.ToString(row.Item("sAdres2")), Conversions.ToString(row.Item("sSemt")), Conversions.ToString(row.Item("sIl")), Conversions.ToString(row.Item("sUlke")), Conversions.ToString(row.Item("sPostaKodu")), Conversions.ToString(row.Item("sVergiDairesi")), Conversions.ToString(row.Item("sVergiNo")), 0, Conversions.ToString(row.Item("sOzelNot")), Conversions.ToString(row.Item("sKullaniciAdi")), Conversions.ToDate(row.Item("dteKayitTarihi")), Conversions.ToString(row.Item("sFiyatTipi")))
                Me.firma_siniflari_kaydet_yeni(Conversions.ToString(Me.nFirmaID), "", "", "", "", "")
                flag = True
                Me.musteri_kontrol()
            End If
            Return flag
        End If
        If Not Operators.ConditionalCompareObjectEqual(left, 1, False) Then
            Return flag
        End If
        Me.dataload_cari(Conversions.ToString(Me.txt_musteriNo.EditValue))
        Try
            enumerator = Me.ds_cari.Tables.Item(0).Rows.GetEnumerator
            Do While enumerator.MoveNext
                current = DirectCast(enumerator.Current, DataRow)
                Me.sKodu = Conversions.ToString(current.Item("sKodu"))
                Me.nFirmaID = Conversions.ToLong(current.Item("nFirmaID"))
                Me.lbl_Firma.Text = Conversions.ToString(current.Item("sAciklama"))
            Loop
        Finally
            If TypeOf enumerator Is IDisposable Then
                TryCast(enumerator, IDisposable).Dispose()
            End If
        End Try
        current = Nothing
        Return True
    End Function
    Private Sub dataload_carisi(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        ds_firma = sorgu_orj(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirma " & kriter & ""))
    End Sub
    Private Sub tbIl_kaydet_yeni(ByVal sIl As String, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbIl (sIl) VALUES     ('" & sIl & "')")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        con.Close()
    End Sub
    Private Sub tbUlke_kaydet_yeni(ByVal sUlke As String, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbUlke (sUlke) VALUES     ('" & sUlke & "')")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        con.Close()
    End Sub
    Private Function firma_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal nOzelIskontosu As Decimal, ByVal lKrediLimiti As Decimal, ByVal dteMutabakatTarihi As DateTime, ByVal nVadeGun As Int64, ByVal sHitap As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal nHesapID As Int64, ByVal sOzelNot As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sFiyatTipi As String) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbFirma                       (sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, dteMutabakatTarihi, nVadeGun, sHitap, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, nHesapID, sOzelNot, sKullaniciAdi, dteKayitTarihi, sFiyatTipi) VALUES     ('" & sKodu & "', N'" & sAciklama & "', " & nOzelIskontosu & ", " & lKrediLimiti & ", '" & dteMutabakatTarihi & "', " & nVadeGun & " , '" & sHitap & "', '" & sAdres1 & "', '" & sAdres2 & "', '" & sSemt & "', '" & sIl & "', '" & sUlke & "', '" & sPostaKodu & "',  '" & sVergiDairesi & "', '" & sVergiNo & "', " & nHesapID & " , '" & sOzelNot & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sFiyatTipi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        cmd = Nothing
        con = Nothing
        Return hareketno
    End Function
    Private Sub firma_siniflari_kaydet_yeni(ByVal nFirmaID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaSinifi (nFirmaID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5) VALUES ('" & nFirmaID & "', '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function sorgu_cari_kontrol(ByVal kod As String) As Int64
        Dim kriter
        If bLogo = False Then
            kriter = "WHERE (sKodu = '" & kod & "') "
        ElseIf bLogo = True Then
            kriter = "WHERE (sKodu = '" & kod & "') "
        End If
        If bPerakende = True Then
            kriter = "WHERE (lKodu = '" & kod & "') "
        Else
            kriter = "WHERE (sKodu = '" & kod & "') "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        If bPerakende = True Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         tbMusteri " & kriter & "")
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         tbFirma " & kriter & "")
        End If
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_cari(ByVal kod As String)
        Dim kriter
        If bPerakende = True Then
            kriter = "WHERE (lKodu = '" & kod & "') "
            ds_cari = sorgu(sorgu_query("SELECT     nMusteriID AS nFirmaId,lKodu as sKodu,sAdi + ' ' + sSoyadi as sAciklama FROM         tbMusteri " & kriter & ""))
        Else
            kriter = "WHERE (sKodu = '" & kod & "') "
            ds_cari = sorgu(sorgu_query("SELECT     nFirmaId,sKodu,sAciklama FROM         tbFirma " & kriter & ""))
        End If
    End Sub
    Public Function sorgu_fis_kontrol(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String, Optional ByVal resmi As Boolean = True, Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim kriter
        kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nStokFisiID, 0) AS KAYIT FROM         tbStokFisiMaster " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        conn.Close()
        cmd = Nothing
        conn = Nothing
        adapter = Nothing
        Return kayitsayisi
        cmd = Nothing
        conn = Nothing
    End Function
    Private Sub sec_sFisTipi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sFisTipi.EditValueChanged
        dataload_tbGirisCikis(3)
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If bMuhasebe = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            If musteri_kontrol() = True Then
                If sec_bAyniFisNo.Checked = True Then
                    If sorgu_fis_kontrol(sec_sFisTipi.EditValue, sec_nGirisCikis.EditValue, txt_dteFisTarihi1.EditValue, txt_lFisNo.Text, nFirmaID) = 0 Then
                        If sec_nGirisCikis.EditValue = 3 And bSatisYapilamaz = True Then
                            XtraMessageBox.Show(Sorgu_sDil("Seçtiðiniz Hesabýn Satýþ Yetkisi Yok, Lütfen Kontrol Ediniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Else
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                            Me.Close()
                        End If
                    Else
                        XtraMessageBox.Show(Sorgu_sDil("Belge Sistemde Kayýtlý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    If sec_nGirisCikis.EditValue = 3 And bSatisYapilamaz = True Then
                        XtraMessageBox.Show(Sorgu_sDil("Seçtiðiniz Hesabýn Satýþ Yetkisi Yok, Lütfen Kontrol Ediniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        sUzakConnection = "Provider=SQLOLEDB.1;Password=" & txt_password.Text & ";Persist Security Info=True;User ID=" & txt_sKullanici.Text & ";Initial Catalog=" & txt_database.Text & ";Data Source=" & txt_Server.Text & ";Current Language=Türkçe;Application Name=BusinessPlus"
        sConnection = "Data Source=" & txt_Server.Text & ";Initial Catalog=" & txt_database.Text & ";Persist Security Info=False;User ID=" & txt_sKullanici.Text & ";Password=" & txt_password.Text & ";Current Language=Türkçe;Packet Size=4096;Application Name=BusinessMobile"
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = sUzakConnection
        cmd.Connection = con
        Try
            con.Open()
            If con.State = ConnectionState.Open Then
                con.Close()
                If bLogo = False Then
                    connection = sUzakConnection
                End If
                GroupControl2.Enabled = True
                dataload_tbFisTipi()
                dataload_tbGirisCikis(nGirisCikis)
                sec_sFisTipi.EditValue = sFisTipi
                sec_nGirisCikis.EditValue = nGirisCikis.ToString
                If kapla = True Then
                    sec_sFisTipi.Enabled = True
                    sec_nGirisCikis.Enabled = True
                End If
                SimpleButton1.Enabled = True
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Baðlantý Hatasý Oluþtu...", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub txt_musteriNo_ButtonClick(ByVal sender As Object, ByVal e As ButtonPressedEventArgs) Handles txt_musteriNo.ButtonClick
        If Me.bPerakende Then
            Me.musteri_sec(0)
        Else
            Me.firma_sec(0)
        End If
    End Sub

    Private Sub txt_musteriNo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If (e.KeyCode = Keys.F3) Then
            If Me.bPerakende Then
                Me.musteri_sec(0)
            Else
                Me.firma_sec(0)
            End If
        ElseIf ((e.KeyCode = Keys.Enter) AndAlso (Strings.Trim(Me.txt_musteriNo.Text) = "")) Then
            If Me.bPerakende Then
                Me.musteri_sec(0)
            Else
                Me.firma_sec(0)
            End If
        End If
    End Sub
    Private Sub txt_musteriNo_Validating(ByVal sender As Object, ByVal e As CancelEventArgs)
        If Not Me.bLogo Then
            Me.musteri_kontrol()
        End If
    End Sub
End Class