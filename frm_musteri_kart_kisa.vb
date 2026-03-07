Imports DevExpress.XtraEditors
Public Class frm_musteri_kart_kisa
    Public firmano
    Public donemno
    Public connection
    Public nMusteriID
    Public lKodu
    Public kullanici
    Public sMagaza = sDepo
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_cari As DataSet
    Dim ds_tbUnvan As DataSet
    Dim ds_tbHitap As DataSet
    Dim ds_tbCinsiyet As DataSet
    Dim ds_tbIl As DataSet
    Public yeniMusteriKodu As String = ""
    Private Sub frm_musteri_kart_kisa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dataload_tbMusteri(nMusteriID)
        txt_sAdi.Text = ""
        txt_sSoyadi.Text = ""
        'tbParamMusteri_MusteriNo_kaydet_Duzelt(nMusteriID)
        txt_musteriNo.Text = sorgu_lKodu("")
        yeniMusteriKodu = sorgu_lKodu("")
        dataload_tbDepo()
        dataload_tbCinsiyet()
        dataload_tbUnvan()
        dataload_tbIl()
        dataload_tbHitap()
        txt_sMagaza.Focus()
        txt_sMagaza.SelectAll()
        'dataload_tbMSinif(1)
        txt_sMagaza.Focus()
        txt_sMagaza.SelectAll()
        txt_sMagaza.EditValue = sMagaza
    End Sub
    Private Sub dataload_tbDepo()
        txt_sMagaza.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo, sAciklama FROM         tbDepo Where sDepo <> '' ")).Tables(0)
    End Sub
    Private Sub dataload_tbCinsiyet()
        ds_tbCinsiyet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbCinsiyet"))
        txt_nCinsiyet.Properties.DataSource = ds_tbCinsiyet.Tables(0)
    End Sub
    Private Sub dataload_tbUnvan()
        ds_tbUnvan = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbUnvan"))
    End Sub
    Private Sub dataload_tbIl()
        ds_tbIl = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbIl"))
        sec_sIl.Properties.DataSource = ds_tbIl.Tables(0)
    End Sub
    Private Sub dataload_tbHitap()
        ds_tbHitap = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbHitap"))
        txt_sHitap1.Properties.DataSource = ds_tbHitap.Tables(0)
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
    Public Sub Dataload_tbMusteri(ByVal nMusteriID As String)
        Try
            ds_tbMusteri.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *,'' sCuzdanKayitNo From tbMusteri WHERE nMusteriID ='" & nMusteriID & "'")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbMusteri, "Table1")
        conn.Close()
    End Sub
    Private Function tbMusteri_kaydet_yeni(ByVal sMagaza As String, ByVal lKodu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal nCinsiyet As Int64, ByVal lAylikGelir As Decimal, ByVal dteKartAcilisTarihi As DateTime, ByVal nIskontoPesin As Decimal, ByVal nIskontoKredili As Decimal, ByVal sUnvan As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal bYazismaEvAdresinemi As Integer, ByVal sEmail As String, ByVal sIsYeriAdi As String, ByVal sIsAdresi1 As String, ByVal sIsAdresi2 As String, ByVal sIsSemt As String, ByVal sIsIl As String, ByVal sIsPostaKodu As String, ByVal sIsTelefonu As String, ByVal sEvAdresi1 As String, ByVal sEvAdresi2 As String, ByVal sEvSemt As String, ByVal sEvPostaKodu As String, ByVal sEvIl As String, ByVal sEvTelefonu As String, ByVal sSigortaNo As String, ByVal bEvlimi As Int64, ByVal dteEvlilikTarihi As DateTime, ByVal dteDogumTarihi As DateTime, ByVal sDogumYeri As String, ByVal sEhliyetNo As String, ByVal sKanGrubu As String, ByVal sHitap As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal sGSM As String, ByVal sFax As String, ByVal sResimAdi As String) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteri (sMagaza, lKodu, sAdi, sSoyadi, nCinsiyet, lAylikGelir, dteKartAcilisTarihi, nIskontoPesin, nIskontoKredili, sUnvan, sVergiDairesi, sVergiNo, bYazismaEvAdresinemi, sEmail, sIsYeriAdi, sIsAdresi1, sIsAdresi2, sIsSemt, sIsIl, sIsPostaKodu, sIsTelefonu, sEvAdresi1, sEvAdresi2, sEvSemt, sEvPostaKodu, sEvIl, sEvTelefonu, sSigortaNo, bEvlimi, dteEvlilikTarihi, dteDogumTarihi, sDogumYeri, sEhliyetNo, sKanGrubu, sHitap, sKullaniciAdi, dteKayitTarihi, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, sGSM, sFax, sResimAdi) VALUES     ('" & sMagaza & "', '" & lKodu & "', '" & sAdi & "', '" & sSoyadi & "', " & nCinsiyet & ", " & lAylikGelir & ", '" & dteKartAcilisTarihi & "', " & nIskontoPesin & ", " & nIskontoKredili & ", '" & sUnvan & "', '" & sVergiDairesi & "', '" & sVergiNo & "', " & bYazismaEvAdresinemi & ", '" & sEmail & "', '" & sIsYeriAdi & "', '" & sIsAdresi1 & "', '" & sIsAdresi2 & "', '" & sIsSemt & "', '" & sIsIl & "', '" & sIsPostaKodu & "', '" & sIsTelefonu & "', '" & sEvAdresi1 & "', '" & sEvAdresi2 & "', '" & sEvSemt & "', '" & sEvPostaKodu & "', '" & sEvIl & "', '" & sEvTelefonu & "', '" & sSigortaNo & "', " & bEvlimi & ", '" & dteEvlilikTarihi & "', '" & dteDogumTarihi & "', '" & sDogumYeri & "', '" & sEhliyetNo & "', '" & sKanGrubu & "', '" & sHitap & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "', '" & sGSM & "', '" & sFax & "', '" & sResimAdi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Private Sub tbMusteriSinifi_kaydet_yeni(ByVal nMusteriID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String, ByVal sSinifKodu6 As String, ByVal sSinifKodu7 As String, ByVal sSinifKodu8 As String, ByVal sSinifKodu9 As String, ByVal sSinifKodu10 As String, ByVal sSinifKodu11 As String, ByVal sSinifKodu12 As String, ByVal sSinifKodu13 As String, ByVal sSinifKodu14 As String, ByVal sSinifKodu15 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteriSinifi (nMusteriID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, sSinifKodu11, sSinifKodu12, sSinifKodu13, sSinifKodu14, sSinifKodu15) VALUES     (" & nMusteriID & ", '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "', '" & sSinifKodu6 & "', '" & sSinifKodu7 & "', '" & sSinifKodu8 & "', '" & sSinifKodu9 & "', '" & sSinifKodu10 & "',  '" & sSinifKodu11 & "', '" & sSinifKodu12 & "', '" & sSinifKodu13 & "', '" & sSinifKodu14 & "', '" & sSinifKodu15 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbParamMusteri_MusteriNo_kaydet_Duzelt(ByVal lMusteriNo As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbParamMusteri SET lMusteriNo = (SELECT TOP 1 lKodu FROM tbMusteri ORDER BY cast(lKodu AS decimal) DESC)")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbParamMusteri SET lMusteriNo = " & lMusteriNo & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_lKodu(ByVal kod As String) As Int64
        Dim kriter
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lMusteriNo+1,1) as lKodu FROM         tbParamMusteri ")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub analiz_musteri_duzenle()
        Dim frm As New frm_musteri_kart
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.lKodu = txt_musteriNo.Text
        frm.nMusteriID = nMusteriID
        frm.kullanici = kullanici
        'If yetki_kontrol(kullanici, frm.Name) = True Then
        frm.ShowDialog()
        'End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub kaydet_tumu(Optional ByVal bDiger As Boolean = False)
        Dim dr_Musteri As DataRow = ds_tbMusteri.Tables(0).Rows(0)
        dr_Musteri.EndEdit()
        'müþteri no kontrolü
        'txt_musteriNo.EditValue = sorgu_lKodu("")
        'Müþteri
        'MessageBox.Show(txt_nCinsiyet.EditValue)
        nMusteriID = tbMusteri_kaydet_yeni(Trim(dr_Musteri("sMagaza")), yeniMusteriKodu, Trim(dr_Musteri("sAdi")), Trim(dr_Musteri("sSoyadi")), dr_Musteri("nCinsiyet"), dr_Musteri("lAylikGelir"), dr_Musteri("dteKartAcilisTarihi"), dr_Musteri("nIskontoPesin"), dr_Musteri("nIskontoKredili"), Trim(dr_Musteri("sUnvan")), Trim(dr_Musteri("sVergiDairesi")), Trim(dr_Musteri("sVergiNo")), dr_Musteri("bYazismaEvAdresinemi"), Trim(dr_Musteri("sEmail")), Trim(dr_Musteri("sIsYeriAdi")), Trim(dr_Musteri("sIsAdresi1")), Trim(dr_Musteri("sIsAdresi2")), Trim(dr_Musteri("sIsSemt")), Trim(dr_Musteri("sIsIl")), Trim(dr_Musteri("sIsPostaKodu")), dr_Musteri("sIsTelefonu"), Trim(dr_Musteri("sEvAdresi1")), Trim(dr_Musteri("sEvAdresi2")), Trim(dr_Musteri("sEvSemt")), Trim(dr_Musteri("sEvPostaKodu")), Trim(dr_Musteri("sEvIl")), dr_Musteri("sEvTelefonu"), dr_Musteri("sSigortaNo"), dr_Musteri("bEvlimi"), dr_Musteri("dteEvlilikTarihi"), dr_Musteri("dteDogumTarihi"), Trim(dr_Musteri("sDogumYeri")), Trim(dr_Musteri("sEhliyetNo")), dr_Musteri("sKanGrubu"), Trim(dr_Musteri("sHitap")), kullanici, Now, Trim(dr_Musteri("sAciklama1")), Trim(dr_Musteri("sAciklama2")), Trim(dr_Musteri("sAciklama3")), Trim(dr_Musteri("sAciklama4")), Trim(dr_Musteri("sAciklama5")), dr_Musteri("sGSM"), dr_Musteri("sFax"), dr_Musteri("sResimAdi"))
        'nMusteriID = tbMusteri_kaydet_yeni(Trim(txt_sMagaza.EditValue), yeniMusteriKodu, Trim(txt_sAdi.Text), Trim(txt_sSoyadi.Text), txt_nCinsiyet.EditValue, 0, Now.Date.ToString().Substring(0, 10), 0, 0, "", "", "", 1, "", "", "", "", "", "", "", "", txt_sEvAdresi1.Text, txt_sEvAdres2.Text, txt_sEvSemt.Text, txt_sPostaKodu.Text, sec_sIl.EditValue, txt_sEvTelefonu.Text, "", 0, "01.01.1900", "01.01.1900", "", "", "", txt_sHitap1.EditValue, kullanici, Now, "", "", "", "", "", txt_sGSM.Text, "", "")
        tbMusteriSinifi_kaydet_yeni(nMusteriID, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
        If sorgu_tbMusteriTablo_kontrol(nMusteriID, "tbMusteriNufusu") = 0 Then
            tbMusteriNufusu_kaydet_yeni(nMusteriID, "", "", "", "", "", "", "01/01/1900", "", "", Trim(txt_sCuzdanKayitNo.Text), "", "", "", "", "", "", "", "", "", "")
        End If
        tbParamMusteri_MusteriNo_kaydet_Duzelt(yeniMusteriKodu)
        If bDiger = True Then
            'If XtraMessageBox.Show(Sorgu_sDil("Diðer Müþteri Kartý Bilgilerini Girmek Ýster misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question, sorgu_sDil("Dikkat",sDil)) = Windows.Forms.DialogResult.Yes Then
            analiz_musteri_duzenle()
            'End If
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Public Function sorgu_tbMusteriTablo_kontrol(ByVal nMusteriID As String, ByVal Tablo As String) As Int64
        Dim kriter
        kriter = "WHERE (nMusteriID = '" & nMusteriID & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(*), 0) AS KAYIT  FROM " & Tablo & "  " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_sMusteri_kontrol(ByVal sSoyadi As String, ByVal sAdi As String) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(nMusteriID), 0) AS nKayit FROM tbMusteri WHERE (sSoyadi = '" & sSoyadi & "') and (sAdi = '" & sAdi & "') ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Public Function sorgu_sGsmNo_kontrol(ByVal sGSM As String) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(sGSM), 0) AS nKayit FROM tbMusteri WHERE (sGSM = '" & sGSM & "') ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Public Function sorgu_sCuzdanKayitNo_kontrol(ByVal sGSM As String) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sCuzdanKayitNo), 0) AS nKayit FROM         tbMusteriNufusu WHERE     (sCuzdanKayitNo = '" & sGSM & "')  ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Private Sub tbMusteriNufusu_kaydet_yeni(ByVal nMusteriID As String, ByVal sDin As String, ByVal sKutukIl As String, ByVal sKutukIlce As String, ByVal sKutukMahalle As String, ByVal sKutukCiltNo As String, ByVal sKutukSiraNo As String, ByVal dteNufusCuzdanTarihi As DateTime, ByVal sCuzdanVerilenYer As String, ByVal sCuzdanVerNedeni As String, ByVal sCuzdanKayitNo As String, ByVal sAnneAdi As String, ByVal sBabaAdi As String, ByVal sAileAdresi1 As String, ByVal sAileAdresi2 As String, ByVal sAileSemt As String, ByVal sAilePostaKodu As String, ByVal sAileIl As String, ByVal sAileTelefonu As String, ByVal sHitapAnne As String, ByVal sHitapBaba As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteriNufusu (nMusteriID, sDin, sKutukIl, sKutukIlce, sKutukMahalle, sKutukCiltNo, sKutukSiraNo, dteNufusCuzdanTarihi, sCuzdanVerilenYer, sCuzdanVerNedeni, sCuzdanKayitNo, sAnneAdi, sBabaAdi, sAileAdresi1, sAileAdresi2, sAileSemt, sAilePostaKodu, sAileIl, sAileTelefonu, sHitapAnne, sHitapBaba) VALUES     ('" & nMusteriID & "', '" & sDin & "', '" & sKutukIl & "', '" & sKutukIlce & "', '" & sKutukMahalle & "', '" & sKutukCiltNo & "', '" & sKutukSiraNo & "', '" & dteNufusCuzdanTarihi & "','" & sCuzdanVerilenYer & "', '" & sCuzdanVerNedeni & "', '" & sCuzdanKayitNo & "', '" & sAnneAdi & "', '" & sBabaAdi & "', '" & sAileAdresi1 & "', '" & sAileAdresi2 & "', '" & sAileSemt & "', '" & sAilePostaKodu & "', '" & sAileIl & "', '" & sAileTelefonu & "', '" & sHitapAnne & "', '" & sHitapBaba & "') ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        kaydet_tumu()
    End Sub
    Private Sub txt_sSoyadi_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sSoyadi.Validating
        txt_sSoyadi.EditValue = Trim(txt_sSoyadi.EditValue)
        txt_sAdi.EditValue = Trim(txt_sAdi.EditValue)
        If sorgu_sMusteri_kontrol(txt_sSoyadi.EditValue, txt_sAdi.Text) = False Then
            'txt_sSoyadi.ErrorText = txt_sSoyadi.Text & vbTab & "Kaydý Daha Önce Kullanýlmýþ"
            If XtraMessageBox.Show(txt_sAdi.Text & vbTab & txt_sSoyadi.Text & Sorgu_sDil(" Ýsimle Daha Once Kayit Yapilmis...", sDil) & vbCrLf & Sorgu_sDil("Kayýtlarý Görmek Ýster misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = MsgBoxResult.Yes Then
                Dim frm As New frm_musteri_liste
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.txt_ara.Text = txt_sAdi.Text & " " & txt_sSoyadi.Text
                frm.sec_konum.Text = "Musteri"
                frm.sec_kriter.Text = "Eþittir"
                frm.ShowDialog()
                'e.Cancel = True
                'txt_sSoyadi.Focus()
                'txt_sSoyadi.SelectAll()
            End If
        End If
    End Sub
    Private Sub txt_sGSM_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sGSM.Validating
        txt_sGSM.EditValue = Trim(txt_sGSM.EditValue)
        If Trim(txt_sGSM.EditValue) <> "" Then
            If sorgu_sGsmNo_kontrol(txt_sGSM.EditValue) = False Then
                'txt_sSoyadi.ErrorText = txt_sSoyadi.Text & vbTab & "Kaydý Daha Önce Kullanýlmýþ"
                If XtraMessageBox.Show(txt_sGSM.Text & Sorgu_sDil(" GsmNo Daha Once Kayit Yapilmis...", sDil) & vbCrLf & Sorgu_sDil("Kayýtlarý Görmek Ýster misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = MsgBoxResult.Yes Then
                    Dim frm As New frm_musteri_liste
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.connection = connection
                    frm.txt_ara.Text = txt_sGSM.EditValue
                    frm.sec_konum.Text = "Gsm"
                    frm.sec_kriter.Text = "Eþittir"
                    frm.ShowDialog()
                    'e.Cancel = True
                    'txt_sSoyadi.Focus()
                    'txt_sSoyadi.SelectAll()
                End If
            End If
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        kaydet_tumu(True)
    End Sub
    Private Sub txt_sCuzdanKayitNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sCuzdanKayitNo.Validating
        txt_sCuzdanKayitNo.EditValue = Trim(txt_sCuzdanKayitNo.Text.ToString)
        If Trim(txt_sCuzdanKayitNo.EditValue) <> "" Then
            If sorgu_sCuzdanKayitNo_kontrol(txt_sCuzdanKayitNo.Text.ToString) = False Then
                'txt_sSoyadi.ErrorText = txt_sSoyadi.Text & vbTab & "Kaydý Daha Önce Kullanýlmýþ"
                If XtraMessageBox.Show(txt_sCuzdanKayitNo.Text & Sorgu_sDil(" TC Kimlik No Daha Once Kayit Yapilmis...", sDil) & vbCrLf & Sorgu_sDil("Kayýtlarý Görmek Ýster misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = MsgBoxResult.Yes Then
                    Dim frm As New frm_musteri_liste
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.connection = connection
                    frm.txt_ara.Text = txt_sCuzdanKayitNo.EditValue
                    frm.sec_konum.Text = "TCNO"
                    frm.sec_kriter.Text = "Eþittir"
                    frm.ShowDialog()
                    'e.Cancel = True
                    'txt_sSoyadi.Focus()
                    'txt_sSoyadi.SelectAll()
                End If
            End If
        End If
    End Sub
End Class