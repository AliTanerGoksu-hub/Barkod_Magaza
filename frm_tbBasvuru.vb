Imports FastReport
Public Class frm_tbBasvuru
    Public firmano
    Public donemno
    Public connection
    Public nAdayID As Int64 = 0
    Public kullanici
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_tbIl As DataSet
    Dim ds_tbYabanciDil As DataSet
    Dim ds_tbYabanciDilSeviye As DataSet
    Dim ds_tbYuksekOkul As DataSet
    Dim ds_tbYuksekOkulBolum As DataSet
    Dim ds_tbCinsiyet As DataSet
    Dim ds_tbIsPozisyonu As DataSet
    Public yeni As Boolean = False
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        kaydet_tumu()
    End Sub
    Private Sub frm_tbBasvuru_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If nAdayID = 0 Then
            If yeni = False Then
                'firma_sec()
            ElseIf yeni = True Then
                nAdayID = sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nAdayID), 0) + 1 AS nAdayID FROM         tbIsBasvurusuForm")
                txt_AdayNo.Text = nAdayID
                dataload(nAdayID)
                Dim dr As DataRow = ds_tbIsBasvurusuForm.Tables(0).NewRow
                dr(0) = nAdayID
                dr("dteBasvuruTarihi") = dteSistemTarihi
                sec_bTCVatandasimi.EditValue = True
                txt_nCinsiyet.EditValue = 1
                txt_dteTerhisTarihi.EditValue = "01/01/1900"
                txt_nTecilSuresi.EditValue = 0
                sec_sIletisimPET.SelectedIndex = 1
                txt_lSicilNo.EditValue = 0
                sec_bEhliyetiVarmi.EditValue = 0
                txt_bEvlimi.EditValue = False
                txt_nCocukSayisi.EditValue = 0
                txt_dteBasvuruTarihi.EditValue = dteSistemTarihi
                sec_sKanGrubu.EditValue = ""
                sec_sBasvuruPosizyonu1.EditValue = ""
                sec_sBasvuruPosizyonu2.EditValue = ""
                sec_sBasvuruPosizyonu3.EditValue = ""
                txt_nBasvuruSure1.EditValue = 0
                txt_nBasvuruSure2.EditValue = 0
                txt_nBasvuruSure3.EditValue = 0
                txt_lSonMaasi.EditValue = 0
                sec_nYabanciDilID1.EditValue = 1
                sec_nYabanciDilID2.EditValue = 1
                sec_nYabanciDilID3.EditValue = 1
                sec_nYDSeviye1.EditValue = 0
                sec_nYDSeviye2.EditValue = 0
                sec_nYDSeviye3.EditValue = 0
                sec_nYuksekOkulID1.EditValue = 1
                sec_nYuksekOkulID2.EditValue = 1
                sec_nYuksekOkulID3.EditValue = 1
                sec_nBolumID1.EditValue = 1
                sec_nBolumID2.EditValue = 1
                sec_nBolumID3.EditValue = 1
                txt_dteIlkBaslangicTarihi.EditValue = "01/01/1900"
                txt_dteOrtaBaslangicTarihi.EditValue = "01/01/1900"
                txt_dteLiseBaslangicTarihi.EditValue = "01/01/1900"
                txt_dteYOBaslangicTarihi1.EditValue = "01/01/1900"
                txt_dteYOBaslangicTarihi2.EditValue = "01/01/1900"
                txt_dteYOBaslangicTarihi3.EditValue = "01/01/1900"
                txt_dteIlkBitisTarihi.EditValue = "01/01/1900"
                txt_dteOrtaBitisTarihi.EditValue = "01/01/1900"
                txt_dteLiseBitisTarihi.EditValue = "01/01/1900"
                txt_dteYOBitisTarihi1.EditValue = "01/01/1900"
                txt_dteYOBitisTarihi2.EditValue = "01/01/1900"
                txt_dteYOBitisTarihi3.EditValue = "01/01/1900"
                ds_tbIsBasvurusuForm.Tables(0).Rows.Add(dr)
                SimpleButton1.Text = "&Kaydet"
            End If
        Else
            txt_AdayNo.EditValue = nAdayID
            dataload(nAdayID)
        End If
        'dataload_tbUnvan()
        'dataload_tbHitap()
        'dataload_tbFiyatTipi()
        'dataload_tbSaticiRumuzu()
        'dataload_tbDovizCinsi()
        dataload_tbCinsiyet()
        dataload_tbIl()
        dataload_tbYabanciDil()
        dataload_tbYuksekOkul()
        dataload_tbIsPozisyonu()
        'dataload_tbUlke()
        'dataload_tbFSinif(1)
        If yeni = True Then
            txt_sAdi.Focus()
            txt_sAdi.SelectAll()
            sec_bTCVatandasimi.EditValue = True
            txt_nCinsiyet.EditValue = 1
            txt_dteTerhisTarihi.EditValue = "01/01/1900"
            txt_nTecilSuresi.EditValue = 0
            sec_sIletisimPET.SelectedIndex = 1
            txt_lSicilNo.EditValue = 0
            sec_bEhliyetiVarmi.EditValue = 0
            txt_bEvlimi.EditValue = False
            txt_nCocukSayisi.EditValue = 0
            txt_dteBasvuruTarihi.EditValue = dteSistemTarihi
            sec_sKanGrubu.EditValue = ""
            sec_sBasvuruPosizyonu1.EditValue = ""
            sec_sBasvuruPosizyonu2.EditValue = ""
            sec_sBasvuruPosizyonu3.EditValue = ""
            txt_nBasvuruSure1.EditValue = 0
            txt_nBasvuruSure2.EditValue = 0
            txt_nBasvuruSure3.EditValue = 0
            txt_lSonMaasi.EditValue = 0
            sec_nYabanciDilID1.EditValue = 1
            sec_nYabanciDilID2.EditValue = 1
            sec_nYabanciDilID3.EditValue = 1
            sec_nYDSeviye1.EditValue = 0
            sec_nYDSeviye2.EditValue = 0
            sec_nYDSeviye3.EditValue = 0
            sec_nYuksekOkulID1.EditValue = 1
            sec_nYuksekOkulID2.EditValue = 1
            sec_nYuksekOkulID3.EditValue = 1
            sec_nBolumID1.EditValue = 1
            sec_nBolumID2.EditValue = 1
            sec_nBolumID3.EditValue = 1
            txt_dteIlkBaslangicTarihi.EditValue = "01/01/1900"
            txt_dteOrtaBaslangicTarihi.EditValue = "01/01/1900"
            txt_dteLiseBaslangicTarihi.EditValue = "01/01/1900"
            txt_dteYOBaslangicTarihi1.EditValue = "01/01/1900"
            txt_dteYOBaslangicTarihi2.EditValue = "01/01/1900"
            txt_dteYOBaslangicTarihi3.EditValue = "01/01/1900"
            txt_dteIlkBitisTarihi.EditValue = "01/01/1900"
            txt_dteOrtaBitisTarihi.EditValue = "01/01/1900"
            txt_dteLiseBitisTarihi.EditValue = "01/01/1900"
            txt_dteYOBitisTarihi1.EditValue = "01/01/1900"
            txt_dteYOBitisTarihi2.EditValue = "01/01/1900"
            txt_dteYOBitisTarihi3.EditValue = "01/01/1900"
        Else
            XtraTabControl1.SelectedTabPageIndex = 0
            txt_sAdi.Focus()
            txt_sAdi.SelectAll()
        End If
    End Sub
    Private Sub dataload(ByVal nAdayID As String)
        Dataload_tbIsBasvuruForm(nAdayID)
    End Sub
    Private Sub dataload_tbIl()
        ds_tbIl = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sIl FROM         tbIl order by sIl"), "tbIl")
        txt_sEvIl.Properties.DataSource = ds_tbIl.Tables(0)
        sec_sAcil1Il.Properties.DataSource = ds_tbIl.Tables(0)
        sec_sAcil2Il.Properties.DataSource = ds_tbIl.Tables(0)
        txt_sEvIl.Properties.DataSource = ds_tbIl.Tables(0)
    End Sub
    Private Sub dataload_tbIsPozisyonu()
        ds_tbIsPozisyonu = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sIsKodu, sAciklama FROM         tbIsPozisyonu"), "tbIsPozisyonu")
        sec_sBasvuruPosizyonu1.Properties.DataSource = ds_tbIsPozisyonu.Tables(0)
        sec_sBasvuruPosizyonu2.Properties.DataSource = ds_tbIsPozisyonu.Tables(0)
        sec_sBasvuruPosizyonu3.Properties.DataSource = ds_tbIsPozisyonu.Tables(0)
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
        sec_nYuksekOkulID3.Properties.DataSource = ds_tbYuksekOkul.Tables(0)
        ds_tbYuksekOkulBolum = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT     nBolumID, sBolum FROM         tbYuksekOkulBolum"), "tbYuksekOkulBolum")
        sec_nBolumID1.Properties.DataSource = ds_tbYuksekOkulBolum.Tables(0)
        sec_nBolumID2.Properties.DataSource = ds_tbYuksekOkulBolum.Tables(0)
        sec_nBolumID3.Properties.DataSource = ds_tbYuksekOkulBolum.Tables(0)
    End Sub
    Private Sub dataload_tbCinsiyet()
        ds_tbCinsiyet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbCinsiyet"), "tbCinsiyet")
        txt_nCinsiyet.Properties.DataSource = ds_tbCinsiyet.Tables(0)
    End Sub
    Public Sub Dataload_tbIsBasvuruForm(ByVal nAdayID As String)
        Try
            ds_tbIsBasvurusuForm.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbIsBasvurusuForm where  nAdayID ='" & nAdayID & "'")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbIsBasvurusuForm, "Table1")
        conn.Close()
    End Sub
    'Private Function tbIsBasvuruForm_kaydet_yeni(ByVal nAdayID As Int64, ByVal sAdi As String, ByVal sSoyadi As String, ByVal nCinsiyet As Int64, ByVal bEhliyetiVarmi As Byte, ByVal sEhliyetSinifi As String, ByVal bAskerliginiYaptimi As Byte, ByVal dteTerhisTarihi As DateTime, ByVal nTecilSuresi As Decimal, ByVal sDogumYeri As String, ByVal dteDogumTarihi As DateTime, ByVal bEvlimi As Byte, ByVal sDini As String, ByVal sEvAdresi1 As String, ByVal sEvAdresi2 As String, ByVal sEvSemt As String, ByVal sEvPostaKodu As String, ByVal sEvIl As String, ByVal sEvTelefonu As String, ByVal sCepTelefonu As String, ByVal sE_Posta As String, ByVal sIletisimPET As Integer, ByVal sIlkOgrenim As String, ByVal dteIlkBitisTarihi As DateTime, ByVal sLise As String, ByVal dteLiseBitisTarihi As DateTime, ByVal nYuksekOkulID1 As Int64, ByVal nBolumID1 As Int64, ByVal sDigerYuksekOkul1 As Int64, ByVal dteYOBitisTarihi1 As DateTime, ByVal nYuksekOkulID2 As Int64, ByVal nBolumID2 As Int64, ByVal sDigerYuksekOkul2 As String, ByVal dteYOBitisTarihi2 As DateTime, ByVal sMeslek As String, ByVal sIsTecrubesi As String, ByVal lSonMaasi As Decimal, ByVal sReferans1AdiSoyadi As String, ByVal sReferans1Tel As String, ByVal sReferans1Aciklamasi As String, ByVal sReferans2AdiSoyadi As String, ByVal sReferans2Tel As String, ByVal sReferans2Aciklamasi As String, ByVal sBasvuruPosizyonu As String, ByVal sBilgisayarTecrubesi As String, ByVal sEkAciklama As String, ByVal nYabanciDilID1 As Int64, ByVal nYDSeviye1 As Int64, ByVal nYabanciDilID2 As Int64, ByVal nYDSeviye2 As Int64, ByVal nYabanciDilID3 As Int64, ByVal nYDSeviye3 As Int64, ByVal dteBasvuruTarihi As DateTime, ByVal sResimAdi As String, ByVal sKimlikNo As String, ByVal sBabaAdi As String, ByVal sBabaMeslek As String, ByVal sAnneAdi As String, ByVal sAnneMeslek As String, ByVal sEsAdi As String, ByVal sEsMeslek As String, ByVal sEsTelefonu As String, ByVal bTCVatandasimi As Byte, ByVal sUyrugu As String, ByVal nCocukSayisi As Decimal, ByVal sKanGrubu As String, ByVal bSabikalimi As Byte, ByVal sSabikaNeden As String, ByVal bOnemliHastalikGecirdimi As Byte, ByVal sOnemliHastalikAciklama As String, ByVal bFizikselProplemiVarmi As Byte, ByVal sFizilsekProplemAciklama As String, ByVal sAcil1AdiSoyadi As String, ByVal sAcil1YakinlikDerecesi As String, ByVal sAcil1Telefon As String, ByVal sAcil1Adres As String, ByVal sAcil1Semt As String, ByVal sAcil1Il As String, ByVal sAcil2AdiSoyadi As String, ByVal sAcil2YakinlikDerecesi As String, ByVal sAcil2Telefon As String, ByVal sAcil2Adres As String, ByVal sAcil2Semt As String, ByVal sAcil2Il As String, ByVal sReferans1Sonuc As String, ByVal sReferans2Sonuc As String, ByVal sReferans3AdiSoyadi As String, ByVal sReferans3Tel As String, ByVal sReferans3Aciklamasi As String, ByVal sReferans3Sonuc As String, ByVal sBasvuruPosizyonu2 As String, ByVal sBasvuruPosizyonu3 As String, ByVal nBasvuruSure1 As Decimal, ByVal nBasvuruSure2 As Decimal, ByVal nBasvuruSure3 As Decimal, ByVal sSosyalImkanOnceki As String, ByVal dteIlkBaslangicTarihi As DateTime, ByVal sOrtaOgrenim As String, ByVal dteOrtaBalangicTarihi As DateTime, ByVal dteOrtaBitisTarihi As DateTime, ByVal dteLiseBaslangicTarihi As DateTime, ByVal dteYOBaslangicTarihi1 As DateTime, ByVal bYODevamEdiyormu1 As Byte, ByVal dteYOBaslangicTarihi2 As DateTime, ByVal bYODevamEdiyormu2 As Byte, ByVal nYuksekOkulID3 As Int64, ByVal nBolumID3 As Int64, ByVal sDigerYuksekOkul3 As String, ByVal dteYOBitisTarihi3 As DateTime, ByVal dteYOBaslangicTarihi3 As DateTime, ByVal bYODevamEdiyormu3 As Byte, ByVal bIseAlindi As Byte, ByVal lSicilNo As Int64) As Int64
    Private Function tbIsBasvuruForm_kaydet_yeni(ByVal nAdayID, ByVal sAdi, ByVal sSoyadi, ByVal nCinsiyet, ByVal bEhliyetiVarmi, ByVal sEhliyetSinifi, ByVal bAskerliginiYaptimi, ByVal dteTerhisTarihi, ByVal nTecilSuresi, ByVal sDogumYeri, ByVal dteDogumTarihi, ByVal bEvlimi, ByVal sDini, ByVal sEvAdresi1, ByVal sEvAdresi2, ByVal sEvSemt, ByVal sEvPostaKodu, ByVal sEvIl, ByVal sEvTelefonu, ByVal sCepTelefonu, ByVal sE_Posta, ByVal sIletisimPET, ByVal sIlkOgrenim, ByVal dteIlkBitisTarihi, ByVal sLise, ByVal dteLiseBitisTarihi, ByVal nYuksekOkulID1, ByVal nBolumID1, ByVal sDigerYuksekOkul1, ByVal dteYOBitisTarihi1, ByVal nYuksekOkulID2, ByVal nBolumID2, ByVal sDigerYuksekOkul2, ByVal dteYOBitisTarihi2, ByVal sMeslek, ByVal sIsTecrubesi, ByVal lSonMaasi, ByVal sReferans1AdiSoyadi, ByVal sReferans1Tel, ByVal sReferans1Aciklamasi, ByVal sReferans2AdiSoyadi, ByVal sReferans2Tel, ByVal sReferans2Aciklamasi, ByVal sBasvuruPosizyonu, ByVal sBilgisayarTecrubesi, ByVal sEkAciklama, ByVal nYabanciDilID1, ByVal nYDSeviye1, ByVal nYabanciDilID2, ByVal nYDSeviye2, ByVal nYabanciDilID3, ByVal nYDSeviye3, ByVal dteBasvuruTarihi, ByVal sResimAdi, ByVal sKimlikNo, ByVal sBabaAdi, ByVal sBabaMeslek, ByVal sAnneAdi, ByVal sAnneMeslek, ByVal sEsAdi, ByVal sEsMeslek, ByVal sEsTelefonu, ByVal bTCVatandasimi, ByVal sUyrugu, ByVal nCocukSayisi, ByVal sKanGrubu, ByVal bSabikalimi, ByVal sSabikaNeden, ByVal bOnemliHastalikGecirdimi, ByVal sOnemliHastalikAciklama, ByVal bFizikselProplemiVarmi, ByVal sFizilsekProplemAciklama, ByVal sAcil1AdiSoyadi, ByVal sAcil1YakinlikDerecesi, ByVal sAcil1Telefon, ByVal sAcil1Adres, ByVal sAcil1Semt, ByVal sAcil1Il, ByVal sAcil2AdiSoyadi, ByVal sAcil2YakinlikDerecesi, ByVal sAcil2Telefon, ByVal sAcil2Adres, ByVal sAcil2Semt, ByVal sAcil2Il, ByVal sReferans1Sonuc, ByVal sReferans2Sonuc, ByVal sReferans3AdiSoyadi, ByVal sReferans3Tel, ByVal sReferans3Aciklamasi, ByVal sReferans3Sonuc, ByVal sBasvuruPosizyonu2, ByVal sBasvuruPosizyonu3, ByVal nBasvuruSure1, ByVal nBasvuruSure2, ByVal nBasvuruSure3, ByVal sSosyalImkanOnceki, ByVal dteIlkBaslangicTarihi, ByVal sOrtaOgrenim, ByVal dteOrtaBalangicTarihi, ByVal dteOrtaBitisTarihi, ByVal dteLiseBaslangicTarihi, ByVal dteYOBaslangicTarihi1, ByVal bYODevamEdiyormu1, ByVal dteYOBaslangicTarihi2, ByVal bYODevamEdiyormu2, ByVal nYuksekOkulID3, ByVal nBolumID3, ByVal sDigerYuksekOkul3, ByVal dteYOBitisTarihi3, ByVal dteYOBaslangicTarihi3, ByVal bYODevamEdiyormu3, ByVal bIseAlindi, ByVal lSicilNo) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbIsBasvurusuForm(nAdayID, sAdi, sSoyadi, nCinsiyet, bEhliyetiVarmi, sEhliyetSinifi, bAskerliginiYaptimi, dteTerhisTarihi, nTecilSuresi, sDogumYeri, dteDogumTarihi, bEvlimi, sDini, sEvAdresi1, sEvAdresi2, sEvSemt, sEvPostaKodu, sEvIl, sEvTelefonu, sCepTelefonu, sE_Posta, sIletisimPET, sIlkOgrenim, dteIlkBitisTarihi, sLise, dteLiseBitisTarihi, nYuksekOkulID1, nBolumID1, sDigerYuksekOkul1, dteYOBitisTarihi1, nYuksekOkulID2, nBolumID2, sDigerYuksekOkul2, dteYOBitisTarihi2, sMeslek, sIsTecrubesi, lSonMaasi, sReferans1AdiSoyadi, sReferans1Tel, sReferans1Aciklamasi, sReferans2AdiSoyadi, sReferans2Tel, sReferans2Aciklamasi, sBasvuruPosizyonu, sBilgisayarTecrubesi, sEkAciklama, nYabanciDilID1, nYDSeviye1, nYabanciDilID2, nYDSeviye2, nYabanciDilID3, nYDSeviye3, dteBasvuruTarihi, sResimAdi, sKimlikNo, sBabaAdi, sBabaMeslek, sAnneAdi, sAnneMeslek, sEsAdi, sEsMeslek, sEsTelefonu, bTCVatandasimi, sUyrugu, nCocukSayisi, sKanGrubu, bSabikalimi, sSabikaNeden, bOnemliHastalikGecirdimi, sOnemliHastalikAciklama, bFizikselProplemiVarmi, sFizilsekProplemAciklama, sAcil1AdiSoyadi, sAcil1YakinlikDerecesi, sAcil1Telefon, sAcil1Adres, sAcil1Semt, sAcil1Il, sAcil2AdiSoyadi, sAcil2YakinlikDerecesi, sAcil2Telefon, sAcil2Adres, sAcil2Semt, sAcil2Il, sReferans1Sonuc, sReferans2Sonuc, sReferans3AdiSoyadi, sReferans3Tel, sReferans3Aciklamasi, sReferans3Sonuc, sBasvuruPosizyonu2, sBasvuruPosizyonu3, nBasvuruSure1, nBasvuruSure2, nBasvuruSure3, sSosyalImkanOnceki, dteIlkBaslangicTarihi, sOrtaOgrenim, dteOrtaBalangicTarihi, dteOrtaBitisTarihi, dteLiseBaslangicTarihi, dteYOBaslangicTarihi1, bYODevamEdiyormu1, dteYOBaslangicTarihi2, bYODevamEdiyormu2, nYuksekOkulID3, nBolumID3, sDigerYuksekOkul3, dteYOBitisTarihi3, dteYOBaslangicTarihi3, bYODevamEdiyormu3, bIseAlindi, lSicilNo) VALUES (" & nAdayID & ", '" & sAdi & "', '" & sSoyadi & "', " & nCinsiyet & ", " & bEhliyetiVarmi & ", '" & sEhliyetSinifi & "', " & bAskerliginiYaptimi & ", '" & dteTerhisTarihi & "', " & nTecilSuresi & ", '" & sDogumYeri & "', '" & dteDogumTarihi & "', " & bEvlimi & ", '" & sDini & "', '" & sEvAdresi1 & "', '" & sEvAdresi2 & "', '" & sEvSemt & "', '" & sEvPostaKodu & "', '" & sEvIl & "', '" & sEvTelefonu & "', '" & sCepTelefonu & "', '" & sE_Posta & "', '" & sIletisimPET & "', '" & sIlkOgrenim & "', '" & dteIlkBitisTarihi & "', '" & sLise & "', '" & dteLiseBitisTarihi & "', " & nYuksekOkulID1 & ", " & nBolumID1 & ", '" & sDigerYuksekOkul1 & "', '" & dteYOBitisTarihi1 & "', " & nYuksekOkulID2 & ", " & nBolumID2 & ", '" & sDigerYuksekOkul2 & "', '" & dteYOBitisTarihi2 & "', '" & sMeslek & "', '" & sIsTecrubesi & "', " & lSonMaasi & ", '" & sReferans1AdiSoyadi & "', '" & sReferans1Tel & "', '" & sReferans1Aciklamasi & "', '" & sReferans2AdiSoyadi & "', '" & sReferans2Tel & "', '" & sReferans2Aciklamasi & "', '" & sBasvuruPosizyonu & "', '" & sBilgisayarTecrubesi & "', '" & sEkAciklama & "'," & nYabanciDilID1 & ", " & nYDSeviye1 & ", " & nYabanciDilID2 & ", " & nYDSeviye2 & ", " & nYabanciDilID3 & ", " & nYDSeviye3 & ", '" & dteBasvuruTarihi & "', '" & sResimAdi & "', '" & sKimlikNo & "', '" & sBabaAdi & "', '" & sBabaMeslek & "', '" & sAnneAdi & "', '" & sAnneMeslek & "', '" & sEsAdi & "', '" & sEsMeslek & "', '" & sEsTelefonu & "', " & bTCVatandasimi & ", '" & sUyrugu & "', " & nCocukSayisi & ", '" & sKanGrubu & "', " & bSabikalimi & ", '" & sSabikaNeden & "', " & bOnemliHastalikGecirdimi & ", '" & sOnemliHastalikAciklama & "', " & bFizikselProplemiVarmi & ", '" & sFizilsekProplemAciklama & "', '" & sAcil1AdiSoyadi & "', '" & sAcil1YakinlikDerecesi & "', '" & sAcil1Telefon & "', '" & sAcil1Adres & "', '" & sAcil1Semt & "', '" & sAcil1Il & "', '" & sAcil2AdiSoyadi & "', '" & sAcil2YakinlikDerecesi & "', '" & sAcil2Telefon & "', '" & sAcil2Adres & "', '" & sAcil2Semt & "', '" & sAcil2Il & "', '" & sReferans1Sonuc & "', '" & sReferans2Sonuc & "', '" & sReferans3AdiSoyadi & "', '" & sReferans3Tel & "', '" & sReferans3Aciklamasi & "', '" & sReferans3Sonuc & "', '" & sBasvuruPosizyonu2 & "', '" & sBasvuruPosizyonu3 & "', " & nBasvuruSure1 & ", " & nBasvuruSure2 & ", " & nBasvuruSure3 & ", '" & sSosyalImkanOnceki & "', '" & dteIlkBaslangicTarihi & "', '" & sOrtaOgrenim & "', '" & dteOrtaBalangicTarihi & "', '" & dteOrtaBitisTarihi & "', '" & dteLiseBaslangicTarihi & "', '" & dteYOBaslangicTarihi1 & "', " & bYODevamEdiyormu1 & ", '" & dteYOBaslangicTarihi2 & "', " & bYODevamEdiyormu2 & ", " & nYuksekOkulID3 & ", " & nBolumID3 & ", '" & sDigerYuksekOkul3 & "', '" & dteYOBitisTarihi3 & "', '" & dteYOBaslangicTarihi3 & "', " & bYODevamEdiyormu3 & ", " & bIseAlindi & ", " & lSicilNo & ")")
        cmd.ExecuteNonQuery()
        'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        'Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return nAdayID
    End Function
    Private Sub tbIsBasvuruForm_kaydet_duzelt(ByVal nAdayID, ByVal sAdi, ByVal sSoyadi, ByVal nCinsiyet, ByVal bEhliyetiVarmi, ByVal sEhliyetSinifi, ByVal bAskerliginiYaptimi, ByVal dteTerhisTarihi, ByVal nTecilSuresi, ByVal sDogumYeri, ByVal dteDogumTarihi, ByVal bEvlimi, ByVal sDini, ByVal sEvAdresi1, ByVal sEvAdresi2, ByVal sEvSemt, ByVal sEvPostaKodu, ByVal sEvIl, ByVal sEvTelefonu, ByVal sCepTelefonu, ByVal sE_Posta, ByVal sIletisimPET, ByVal sIlkOgrenim, ByVal dteIlkBitisTarihi, ByVal sLise, ByVal dteLiseBitisTarihi, ByVal nYuksekOkulID1, ByVal nBolumID1, ByVal sDigerYuksekOkul1, ByVal dteYOBitisTarihi1, ByVal nYuksekOkulID2, ByVal nBolumID2, ByVal sDigerYuksekOkul2, ByVal dteYOBitisTarihi2, ByVal sMeslek, ByVal sIsTecrubesi, ByVal lSonMaasi, ByVal sReferans1AdiSoyadi, ByVal sReferans1Tel, ByVal sReferans1Aciklamasi, ByVal sReferans2AdiSoyadi, ByVal sReferans2Tel, ByVal sReferans2Aciklamasi, ByVal sBasvuruPosizyonu, ByVal sBilgisayarTecrubesi, ByVal sEkAciklama, ByVal nYabanciDilID1, ByVal nYDSeviye1, ByVal nYabanciDilID2, ByVal nYDSeviye2, ByVal nYabanciDilID3, ByVal nYDSeviye3, ByVal dteBasvuruTarihi, ByVal sResimAdi, ByVal sKimlikNo, ByVal sBabaAdi, ByVal sBabaMeslek, ByVal sAnneAdi, ByVal sAnneMeslek, ByVal sEsAdi, ByVal sEsMeslek, ByVal sEsTelefonu, ByVal bTCVatandasimi, ByVal sUyrugu, ByVal nCocukSayisi, ByVal sKanGrubu, ByVal bSabikalimi, ByVal sSabikaNeden, ByVal bOnemliHastalikGecirdimi, ByVal sOnemliHastalikAciklama, ByVal bFizikselProplemiVarmi, ByVal sFizilsekProplemAciklama, ByVal sAcil1AdiSoyadi, ByVal sAcil1YakinlikDerecesi, ByVal sAcil1Telefon, ByVal sAcil1Adres, ByVal sAcil1Semt, ByVal sAcil1Il, ByVal sAcil2AdiSoyadi, ByVal sAcil2YakinlikDerecesi, ByVal sAcil2Telefon, ByVal sAcil2Adres, ByVal sAcil2Semt, ByVal sAcil2Il, ByVal sReferans1Sonuc, ByVal sReferans2Sonuc, ByVal sReferans3AdiSoyadi, ByVal sReferans3Tel, ByVal sReferans3Aciklamasi, ByVal sReferans3Sonuc, ByVal sBasvuruPosizyonu2, ByVal sBasvuruPosizyonu3, ByVal nBasvuruSure1, ByVal nBasvuruSure2, ByVal nBasvuruSure3, ByVal sSosyalImkanOnceki, ByVal dteIlkBaslangicTarihi, ByVal sOrtaOgrenim, ByVal dteOrtaBalangicTarihi, ByVal dteOrtaBitisTarihi, ByVal dteLiseBaslangicTarihi, ByVal dteYOBaslangicTarihi1, ByVal bYODevamEdiyormu1, ByVal dteYOBaslangicTarihi2, ByVal bYODevamEdiyormu2, ByVal nYuksekOkulID3, ByVal nBolumID3, ByVal sDigerYuksekOkul3, ByVal dteYOBitisTarihi3, ByVal dteYOBaslangicTarihi3, ByVal bYODevamEdiyormu3, ByVal bIseAlindi, ByVal lSicilNo)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbIsBasvurusuForm SET  sAdi = '" & sAdi & "', sSoyadi = '" & sSoyadi & "', nCinsiyet = " & nCinsiyet & ", bEhliyetiVarmi = " & bEhliyetiVarmi & ", sEhliyetSinifi = '" & sEhliyetSinifi & "', bAskerliginiYaptimi = " & bAskerliginiYaptimi & ", dteTerhisTarihi = '" & dteTerhisTarihi & "', nTecilSuresi = " & nTecilSuresi & ", sDogumYeri = '" & sDogumYeri & "', dteDogumTarihi = '" & dteDogumTarihi & "', bEvlimi = " & bEvlimi & ", sDini = '" & sDini & "', sEvAdresi1 = '" & sEvAdresi1 & "', sEvAdresi2 = '" & sEvAdresi2 & "', sEvSemt = '" & sEvSemt & "', sEvPostaKodu = '" & sEvPostaKodu & "', sEvIl = '" & sEvIl & "', sEvTelefonu = '" & sEvTelefonu & "', sCepTelefonu = '" & sCepTelefonu & "', sE_Posta = '" & sE_Posta & "', sIletisimPET = " & sIletisimPET & ", sIlkOgrenim = '" & sIlkOgrenim & "', dteIlkBitisTarihi = '" & dteIlkBitisTarihi & "', sLise = '" & sLise & "', dteLiseBitisTarihi = '" & dteLiseBitisTarihi & "', nYuksekOkulID1 = " & nYuksekOkulID1 & ", nBolumID1 = " & nBolumID1 & ", sDigerYuksekOkul1 = '" & sDigerYuksekOkul1 & "', dteYOBitisTarihi1 = '" & dteYOBitisTarihi1 & "', nYuksekOkulID2 = " & nYuksekOkulID2 & ", nBolumID2 = " & nBolumID2 & ", sDigerYuksekOkul2 = '" & sDigerYuksekOkul2 & "', dteYOBitisTarihi2 = '" & dteYOBitisTarihi2 & "', sMeslek = '" & sMeslek & "', sIsTecrubesi = '" & sIsTecrubesi & "', lSonMaasi = " & lSonMaasi & ", sReferans1AdiSoyadi = '" & sReferans1AdiSoyadi & "', sReferans1Tel = '" & sReferans1Tel & "', sReferans1Aciklamasi = '" & sReferans1Aciklamasi & "', sReferans2AdiSoyadi = '" & sReferans2AdiSoyadi & "', sReferans2Tel = '" & sReferans2Tel & "', sReferans2Aciklamasi = '" & sReferans2Aciklamasi & "', sBasvuruPosizyonu = '" & sBasvuruPosizyonu & "', sBilgisayarTecrubesi = '" & sBilgisayarTecrubesi & "', sEkAciklama = '" & sEkAciklama & "', nYabanciDilID1 = " & nYabanciDilID1 & ", nYDSeviye1 = " & nYDSeviye1 & ", nYabanciDilID2 = " & nYabanciDilID2 & ", nYDSeviye2 = " & nYDSeviye2 & ", nYabanciDilID3 = " & nYabanciDilID3 & ", nYDSeviye3 = " & nYDSeviye3 & ", dteBasvuruTarihi = '" & dteBasvuruTarihi & "', sResimAdi = '" & sResimAdi & "', sKimlikNo = '" & sKimlikNo & "', sBabaAdi = '" & sBabaAdi & "', sBabaMeslek = '" & sBabaMeslek & "', sAnneAdi = '" & sAnneAdi & "', sAnneMeslek = '" & sAnneMeslek & "', sEsAdi = '" & sEsAdi & "', sEsMeslek = '" & sEsMeslek & "', sEsTelefonu = '" & sEsTelefonu & "', bTCVatandasimi = " & bTCVatandasimi & ", sUyrugu = '" & sUyrugu & "', nCocukSayisi = " & nCocukSayisi & ", sKanGrubu = '" & sKanGrubu & "', bSabikalimi = " & bSabikalimi & ", sSabikaNeden = '" & sSabikaNeden & "', bOnemliHastalikGecirdimi = " & bOnemliHastalikGecirdimi & ", sOnemliHastalikAciklama = '" & sOnemliHastalikAciklama & "', bFizikselProplemiVarmi = " & bFizikselProplemiVarmi & ", sFizilsekProplemAciklama = '" & sFizilsekProplemAciklama & "', sAcil1AdiSoyadi = '" & sAcil1AdiSoyadi & "', sAcil1YakinlikDerecesi = '" & sAcil1YakinlikDerecesi & "', sAcil1Telefon = '" & sAcil1Telefon & "', sAcil1Adres = '" & sAcil1Adres & "', sAcil1Semt = '" & sAcil1Semt & "', sAcil1Il = '" & sAcil1Il & "', sAcil2AdiSoyadi = '" & sAcil2AdiSoyadi & "', sAcil2YakinlikDerecesi = '" & sAcil2YakinlikDerecesi & "', sAcil2Telefon = '" & sAcil2Telefon & "', sAcil2Adres = '" & sAcil2Adres & "', sAcil2Semt = '" & sAcil2Semt & "', sAcil2Il = '" & sAcil2Il & "', sReferans1Sonuc = '" & sReferans1Sonuc & "', sReferans2Sonuc = '" & sReferans2Sonuc & "', sReferans3AdiSoyadi = '" & sReferans3AdiSoyadi & "', sReferans3Tel = '" & sReferans3Tel & "', sReferans3Aciklamasi = '" & sReferans3Aciklamasi & "', sReferans3Sonuc = '" & sReferans3Sonuc & "', sBasvuruPosizyonu2 = '" & sBasvuruPosizyonu2 & "', sBasvuruPosizyonu3 = '" & sBasvuruPosizyonu3 & "', nBasvuruSure1 = " & nBasvuruSure1 & ", nBasvuruSure2 = " & nBasvuruSure2 & ", nBasvuruSure3 = " & nBasvuruSure3 & ", sSosyalImkanOnceki = '" & sSosyalImkanOnceki & "', dteIlkBaslangicTarihi = '" & dteIlkBaslangicTarihi & "', sOrtaOgrenim = '" & sOrtaOgrenim & "', dteOrtaBalangicTarihi = '" & dteOrtaBalangicTarihi & "', dteOrtaBitisTarihi = '" & dteOrtaBitisTarihi & "', dteLiseBaslangicTarihi = '" & dteLiseBaslangicTarihi & "', dteYOBaslangicTarihi1 = '" & dteYOBaslangicTarihi1 & "', bYODevamEdiyormu1 = " & bYODevamEdiyormu1 & ", dteYOBaslangicTarihi2 = '" & dteYOBaslangicTarihi2 & "', bYODevamEdiyormu2 = " & bYODevamEdiyormu2 & ", nYuksekOkulID3 = " & nYuksekOkulID3 & ", nBolumID3 = " & nBolumID3 & ", sDigerYuksekOkul3 = '" & sDigerYuksekOkul3 & "', dteYOBitisTarihi3 = '" & dteYOBitisTarihi3 & "', dteYOBaslangicTarihi3 = '" & dteYOBaslangicTarihi3 & "', bYODevamEdiyormu3 = " & bYODevamEdiyormu3 & ", bIseAlindi = " & bIseAlindi & ", lSicilNo = " & lSicilNo & "  Where nAdayID = '" & nAdayID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub kaydet_tumu()
        Dim dr As DataRow
        dr = ds_tbIsBasvurusuForm.Tables(0).Rows(0)
        If yeni = False Then
            tbIsBasvuruForm_kaydet_duzelt(sorgu_sayi(dr("nAdayID"), 0), dr("sAdi").ToString, dr("sSoyadi").ToString, sorgu_sayi(dr("nCinsiyet"), 1), sorgu_sayi(dr("bEhliyetiVarmi"), 0), dr("sEhliyetSinifi").ToString, sorgu_sayi(dr("bAskerliginiYaptimi"), 0), dr("dteTerhisTarihi"), sorgu_sayi(dr("nTecilSuresi"), 0), dr("sDogumYeri").ToString, dr("dteDogumTarihi"), sorgu_sayi(dr("bEvlimi"), 0), dr("sDini").ToString, dr("sEvAdresi1").ToString, dr("sEvAdresi2").ToString, dr("sEvSemt").ToString, dr("sEvPostaKodu").ToString, dr("sEvIl").ToString, dr("sEvTelefonu").ToString, dr("sCepTelefonu").ToString, dr("sE_Posta").ToString, sorgu_sayi(dr("sIletisimPET"), 1), dr("sIlkOgrenim").ToString, dr("dteIlkBitisTarihi"), dr("sLise").ToString, dr("dteLiseBitisTarihi"), sorgu_sayi(dr("nYuksekOkulID1"), 1), sorgu_sayi(dr("nBolumID1"), 1), dr("sDigerYuksekOkul1").ToString, dr("dteYOBitisTarihi1"), sorgu_sayi(dr("nYuksekOkulID2"), 1), sorgu_sayi(dr("nBolumID2"), 0), dr("sDigerYuksekOkul2").ToString, dr("dteYOBitisTarihi2"), dr("sMeslek").ToString, dr("sIsTecrubesi").ToString, sorgu_sayi(dr("lSonMaasi"), 0), dr("sReferans1AdiSoyadi").ToString, dr("sReferans1Tel").ToString, dr("sReferans1Aciklamasi").ToString, dr("sReferans2AdiSoyadi").ToString, dr("sReferans2Tel").ToString, dr("sReferans2Aciklamasi").ToString, dr("sBasvuruPosizyonu").ToString, dr("sBilgisayarTecrubesi").ToString, dr("sEkAciklama").ToString, sorgu_sayi(dr("nYabanciDilID1"), 1), sorgu_sayi(dr("nYDSeviye1"), 0), sorgu_sayi(dr("nYabanciDilID2"), 1), sorgu_sayi(dr("nYDSeviye2"), 0), sorgu_sayi(dr("nYabanciDilID3"), 1), sorgu_sayi(dr("nYDSeviye3"), 0), dr("dteBasvuruTarihi"), dr("sResimAdi").ToString, dr("sKimlikNo").ToString, dr("sBabaAdi").ToString, dr("sBabaMeslek").ToString, dr("sAnneAdi").ToString, dr("sAnneMeslek").ToString, dr("sEsAdi").ToString, dr("sEsMeslek").ToString, dr("sEsTelefonu").ToString, sorgu_sayi(dr("bTCVatandasimi"), 1), dr("sUyrugu").ToString, sorgu_sayi(dr("nCocukSayisi"), 0), dr("sKanGrubu").ToString, sorgu_sayi(dr("bSabikalimi"), 0), dr("sSabikaNeden").ToString, sorgu_sayi(dr("bOnemliHastalikGecirdimi"), 0), dr("sOnemliHastalikAciklama").ToString, sorgu_sayi(dr("bFizikselProplemiVarmi"), 0), dr("sFizilsekProplemAciklama").ToString, dr("sAcil1AdiSoyadi").ToString, dr("sAcil1YakinlikDerecesi").ToString, dr("sAcil1Telefon").ToString, dr("sAcil1Adres").ToString, dr("sAcil1Semt").ToString, dr("sAcil1Il").ToString, dr("sAcil2AdiSoyadi").ToString, dr("sAcil2YakinlikDerecesi").ToString, dr("sAcil2Telefon").ToString, dr("sAcil2Adres").ToString, dr("sAcil2Semt").ToString, dr("sAcil2Il").ToString, dr("sReferans1Sonuc").ToString, dr("sReferans2Sonuc").ToString, dr("sReferans3AdiSoyadi").ToString, dr("sReferans3Tel").ToString, dr("sReferans3Aciklamasi").ToString, dr("sReferans3Sonuc").ToString, dr("sBasvuruPosizyonu2").ToString, dr("sBasvuruPosizyonu3").ToString, sorgu_sayi(dr("nBasvuruSure1"), 0), sorgu_sayi(dr("nBasvuruSure2"), 0), sorgu_sayi(dr("nBasvuruSure3"), 0), dr("sSosyalImkanOnceki").ToString, dr("dteIlkBaslangicTarihi"), dr("sOrtaOgrenim").ToString, dr("dteOrtaBalangicTarihi"), dr("dteOrtaBitisTarihi"), dr("dteLiseBaslangicTarihi"), dr("dteYOBaslangicTarihi1"), sorgu_sayi(dr("bYODevamEdiyormu1"), 0), dr("dteYOBaslangicTarihi2"), sorgu_sayi(dr("bYODevamEdiyormu2"), 0), sorgu_sayi(dr("nYuksekOkulID3"), 0), sorgu_sayi(dr("nBolumID3"), 0), dr("sDigerYuksekOkul3"), dr("dteYOBitisTarihi3"), dr("dteYOBaslangicTarihi3"), sorgu_sayi(dr("bYODevamEdiyormu3"), 0), sorgu_sayi(dr("bIseAlindi"), 0), sorgu_sayi(dr("lSicilNo"), 0))
            Me.Close()
        ElseIf yeni = True Then
            tbIsBasvuruForm_kaydet_yeni(sorgu_sayi(dr("nAdayID"), 0), dr("sAdi").ToString, dr("sSoyadi").ToString, sorgu_sayi(dr("nCinsiyet"), 1), sorgu_sayi(dr("bEhliyetiVarmi"), 0), dr("sEhliyetSinifi").ToString, sorgu_sayi(dr("bAskerliginiYaptimi"), 0), dr("dteTerhisTarihi"), sorgu_sayi(dr("nTecilSuresi"), 0), dr("sDogumYeri").ToString, dr("dteDogumTarihi"), sorgu_sayi(dr("bEvlimi"), 0), dr("sDini").ToString, dr("sEvAdresi1").ToString, dr("sEvAdresi2").ToString, dr("sEvSemt").ToString, dr("sEvPostaKodu").ToString, dr("sEvIl").ToString, dr("sEvTelefonu").ToString, dr("sCepTelefonu").ToString, dr("sE_Posta").ToString, sorgu_sayi(dr("sIletisimPET"), 1), dr("sIlkOgrenim").ToString, dr("dteIlkBitisTarihi"), dr("sLise").ToString, dr("dteLiseBitisTarihi"), sorgu_sayi(dr("nYuksekOkulID1"), 1), sorgu_sayi(dr("nBolumID1"), 1), dr("sDigerYuksekOkul1").ToString, dr("dteYOBitisTarihi1"), sorgu_sayi(dr("nYuksekOkulID2"), 1), sorgu_sayi(dr("nBolumID2"), 0), dr("sDigerYuksekOkul2").ToString, dr("dteYOBitisTarihi2"), dr("sMeslek").ToString, dr("sIsTecrubesi").ToString, sorgu_sayi(dr("lSonMaasi"), 0), dr("sReferans1AdiSoyadi").ToString, dr("sReferans1Tel").ToString, dr("sReferans1Aciklamasi").ToString, dr("sReferans2AdiSoyadi").ToString, dr("sReferans2Tel").ToString, dr("sReferans2Aciklamasi").ToString, dr("sBasvuruPosizyonu").ToString, dr("sBilgisayarTecrubesi").ToString, dr("sEkAciklama").ToString, sorgu_sayi(dr("nYabanciDilID1"), 1), sorgu_sayi(dr("nYDSeviye1"), 0), sorgu_sayi(dr("nYabanciDilID2"), 1), sorgu_sayi(dr("nYDSeviye2"), 0), sorgu_sayi(dr("nYabanciDilID3"), 1), sorgu_sayi(dr("nYDSeviye3"), 0), dr("dteBasvuruTarihi"), dr("sResimAdi").ToString, dr("sKimlikNo").ToString, dr("sBabaAdi").ToString, dr("sBabaMeslek").ToString, dr("sAnneAdi").ToString, dr("sAnneMeslek").ToString, dr("sEsAdi").ToString, dr("sEsMeslek").ToString, dr("sEsTelefonu").ToString, sorgu_sayi(dr("bTCVatandasimi"), 1), dr("sUyrugu").ToString, sorgu_sayi(dr("nCocukSayisi"), 0), dr("sKanGrubu").ToString, sorgu_sayi(dr("bSabikalimi"), 0), dr("sSabikaNeden").ToString, sorgu_sayi(dr("bOnemliHastalikGecirdimi"), 0), dr("sOnemliHastalikAciklama").ToString, sorgu_sayi(dr("bFizikselProplemiVarmi"), 0), dr("sFizilsekProplemAciklama").ToString, dr("sAcil1AdiSoyadi").ToString, dr("sAcil1YakinlikDerecesi").ToString, dr("sAcil1Telefon").ToString, dr("sAcil1Adres").ToString, dr("sAcil1Semt").ToString, dr("sAcil1Il").ToString, dr("sAcil2AdiSoyadi").ToString, dr("sAcil2YakinlikDerecesi").ToString, dr("sAcil2Telefon").ToString, dr("sAcil2Adres").ToString, dr("sAcil2Semt").ToString, dr("sAcil2Il").ToString, dr("sReferans1Sonuc").ToString, dr("sReferans2Sonuc").ToString, dr("sReferans3AdiSoyadi").ToString, dr("sReferans3Tel").ToString, dr("sReferans3Aciklamasi").ToString, dr("sReferans3Sonuc").ToString, dr("sBasvuruPosizyonu2").ToString, dr("sBasvuruPosizyonu3").ToString, sorgu_sayi(dr("nBasvuruSure1"), 0), sorgu_sayi(dr("nBasvuruSure2"), 0), sorgu_sayi(dr("nBasvuruSure3"), 0), dr("sSosyalImkanOnceki").ToString, dr("dteIlkBaslangicTarihi"), dr("sOrtaOgrenim").ToString, dr("dteOrtaBalangicTarihi"), dr("dteOrtaBitisTarihi"), dr("dteLiseBaslangicTarihi"), dr("dteYOBaslangicTarihi1"), sorgu_sayi(dr("bYODevamEdiyormu1"), 0), dr("dteYOBaslangicTarihi2"), sorgu_sayi(dr("bYODevamEdiyormu2"), 0), sorgu_sayi(dr("nYuksekOkulID3"), 0), sorgu_sayi(dr("nBolumID3"), 0), dr("sDigerYuksekOkul3"), dr("dteYOBitisTarihi3"), dr("dteYOBaslangicTarihi3"), sorgu_sayi(dr("bYODevamEdiyormu3"), 0), sorgu_sayi(dr("bIseAlindi"), 0), sorgu_sayi(dr("lSicilNo"), 0))
            yeni = False
            SimpleButton1.Text = "&Tamam"
            txt_AdayNo.Enabled = False
            XtraTabPage2.PageEnabled = True
            XtraTabPage3.PageEnabled = True
            XtraTabPage4.PageEnabled = True
            XtraTabPage5.PageEnabled = True
            dataload(nAdayID)
            txt_sAdi.Focus()
            txt_sAdi.SelectAll()
            'btn_KodBul.Enabled = False
        End If
    End Sub
    Private Sub raporla_basvuru(ByVal rapor As Integer, ByVal nislem As Integer, ByVal nAdayID As Int64)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyaları (Basvuru*.fr*) |Basvuru*.fr*"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Personel\Basvuru" & sRaporUzanti & ""
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Personel"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            If Microsoft.VisualBasic.Right(sFile, 3) = "frx" Then
                Dim report As New FastReport.Report
                report.Load(sFile)
                report.RegisterData(ds_tbParamGenel, "tbParamGenel")
                report.RegisterData(ds_tbIsBasvurusuForm, "tbIsBasvurusuForm")
                report.RegisterData(ds_tbCinsiyet, "tbCinsiyet")
                report.RegisterData(ds_tbIsPozisyonu, "tbIsPozisyonu")
                report.RegisterData(ds_tbYabanciDil, "tbYabanciDil")
                report.RegisterData(ds_tbYabanciDilSeviye, "tbYabanciDilSeviye")
                report.RegisterData(ds_tbYuksekOkul, "tbYuksekOkul")
                report.RegisterData(ds_tbYuksekOkulBolum, "tbYuksekOkulBolum")
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
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub sec_bTCVatandasimi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bTCVatandasimi.CheckStateChanged
        If sec_bTCVatandasimi.Checked = True Then
            txt_sUyrugu.EditValue = ""
            txt_sUyrugu.Enabled = False
        Else
            txt_sUyrugu.Enabled = True
        End If
    End Sub
    Private Sub sec_bEhliyetiVarmi_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bEhliyetiVarmi.CheckedChanged
    End Sub
    Private Sub sec_bEhliyetiVarmi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bEhliyetiVarmi.CheckStateChanged
        If sec_bEhliyetiVarmi.Checked = True Then
            txt_sEhliyetSinifi.Enabled = True
        Else
            txt_sEhliyetSinifi.Enabled = False
            txt_sEhliyetSinifi.Text = ""
        End If
    End Sub
    Private Sub sec_bAskerliginiYaptimi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bAskerliginiYaptimi.CheckStateChanged
        If sec_bAskerliginiYaptimi.Checked = True Then
            txt_nTecilSuresi.EditValue = 0
            txt_nTecilSuresi.Enabled = False
            txt_dteTerhisTarihi.Enabled = True
            txt_dteBasvuruTarihi.EditValue = dteSistemTarihi
        Else
            txt_dteTerhisTarihi.EditValue = "01/01/1900"
            txt_dteTerhisTarihi.Enabled = False
            txt_nTecilSuresi.EditValue = 0
            txt_nTecilSuresi.Enabled = True
        End If
    End Sub
    Private Sub sec_bSabikalimi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bSabikalimi.CheckStateChanged
        If sec_bSabikalimi.Checked = True Then
            txt_sSabikaNeden.Enabled = True
        Else
            txt_sSabikaNeden.Enabled = False
        End If
    End Sub
    Private Sub sec_bOnemliHastalikGecirdimi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bOnemliHastalikGecirdimi.CheckStateChanged
        If sec_bOnemliHastalikGecirdimi.Checked = True Then
            txt_sOnemliHastalikAciklama.Enabled = True
        Else
            txt_sOnemliHastalikAciklama.Enabled = False
        End If
    End Sub
    Private Sub sec_bFizikselProplemiVarmi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bFizikselProplemiVarmi.CheckStateChanged
        If sec_bFizikselProplemiVarmi.Checked = True Then
            txt_sFizilsekProplemAciklama.Enabled = True
        Else
            txt_sFizilsekProplemAciklama.Enabled = False
        End If
    End Sub
    Private Sub sec_bIseAlindi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bIseAlindi.CheckStateChanged
        If sec_bIseAlindi.Checked = True Then
            txt_lSicilNo.Enabled = True
        Else
            txt_lSicilNo.Enabled = False
            txt_lSicilNo.EditValue = 0
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        raporla_basvuru(0, 0, txt_AdayNo.EditValue)
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_basvuru(0, 2, txt_AdayNo.EditValue)
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_basvuru(0, 1, txt_AdayNo.EditValue)
    End Sub
End Class