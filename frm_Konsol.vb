Imports Microsoft.Win32
Imports System.Xml
Imports DevExpress.XtraEditors
Public Class frm_Konsol
    Public firmano = 100
    Public donemno = 1
    Public connection As String = ""
    Dim sConnection As String = ""
    'Dim connection As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\mPower\mPower.mdb;Persist Security Info=False"
    Public connection_resmi
    Public kasiyerno As String = 1
    Public kullanici As String = "sa"
    Public status As Boolean = False
    Public islemstatus As Boolean = False
    Public aktarim As Boolean = False
    Public nIslemID As Integer = 0
    Public nAlisVerisID As String = ""
    Public sFisTipi As String = "P"
    Public dteFisTarihi As DateTime = Today
    Public lFaturaNo As Int64 = 0
    Public nMusteriID = 0
    Public sAdi As String = "Pos"
    Public sSoyadi As String = "Satış"
    Public sMagaza As String = "D001"
    Public sKasiyerRumuzu As String = "VC"
    Public sKasiyer As String = "Admin"
    Public sHareketTipi As String = "001"
    Public nKasaNo As String = "001"
    Public sAdres1 As String = ""
    Public sAdres2 As String = ""
    Dim e_nMusteriID
    Dim e_sAdi
    Dim e_sSoyadi
    Dim e_sAdres1 = ""
    Dim e_sAdres2 = ""
    Dim sAraKriter As String = ""
    Dim x As Integer = 0
    Dim mevcut As Decimal = 1
    Dim sBarcodeStd As String = 27
    Dim sBarcodeStd_KG As Integer = 2
    Dim sBarcodeStd_GR As Integer = 3
    Dim dr As DataRow
    Dim dr1 As DataRow
    Dim dr_baslik As DataRow
    Dim dr_toplam As DataRow
    Dim dr_param As DataRow
    Dim nSatir As Integer = 0
    Dim sSaticiRumuzu As String
    Dim sFiyatTipi As String = 1
    Dim sOdemeKodu As String = ""
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim ds_alislar_kdv As DataSet
    Dim ds_kasiyer As DataSet
    Dim ds_cari As DataSet
    Dim ds_firma As DataSet
    Dim ds_tbMusteri As DataSet
    Dim ds_tbMusteriNufusu As DataSet
    Dim ds_tbStok As DataSet
    Dim dataset1 As DataSet
    Dim dataset2 As DataSet
    Dim dr_Musteri As DataRow
    Dim dr_hareket As DataRow
    Dim ds_hareket As DataSet
    Dim ds_stok As DataSet
    Dim ds_stok_fisi As DataSet
    Dim ds_stok_barkod As DataSet
    Dim ds_stok_sinif As DataSet
    Dim ds_renk As DataSet
    Dim bkapat As Boolean = False
    Dim bYeniFis As Boolean = False
    Dim info As Boolean = True
    Dim okut As Boolean = False
    Dim sFiyat1 As String = "1"
    Dim sFiyat2 As String = "2"
    Dim sFiyat3 As String = "3"
    Dim sFiyat4 As String = "4"
    Dim sFiyatA As String = "A"
    Dim sFiyatM As String = "M"
    Dim sAktifFiyatTipi As String = "1"
    Dim sAltFiyatTipi As String = "M"
    Dim sStokSinirla As String = ""
    Dim sDateFormat As String = "MDY"
    Dim sqlServer As String = ""
    Dim sqlDatabase As String = ""
    Dim sqlLoginName As String = ""
    Dim sqlPassword As String = ""
    Dim ds_Rapor As DataSet
    Dim sCon As New OleDb.OleDbConnection
    Dim sCmd As New OleDb.OleDbCommand
    Dim sAdapter As New OleDb.OleDbDataAdapter
    Private Sub frm_Konsol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_dteAktarimTarihi.Value = Today
        txt_dteAktarimTarihi2.Value = Today
        Try
            sqlServer = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CONNECT").GetValue("SERVER")
            sqlDatabase = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CONNECT").GetValue("DATABASE")
            sqlLoginName = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CONNECT").GetValue("USER")
            sqlPassword = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CONNECT").GetValue("PASSWORD")
            sFiyat1 = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CONNECT").GetValue("sFiyat1")
            sFiyat2 = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CONNECT").GetValue("sFiyat2")
            sFiyat3 = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CONNECT").GetValue("sFiyat3")
            sFiyat4 = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CONNECT").GetValue("sFiyat4")
            sFiyatA = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CONNECT").GetValue("sFiyatA")
            sFiyatM = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CONNECT").GetValue("sFiyatM")
            sDepo = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CONNECT").GetValue("sDepo")
            sAktifFiyatTipi = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CONNECT").GetValue("sAktifFiyatTipi")
            sDateFormat = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("CONNECT").GetValue("sDateFormat")
            txt_dateformat.Text = sDateFormat
            sBarcodeStd = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").GetValue("BARCODESTD")
            sBarcodeStd_KG = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").GetValue("BARCODESTD_KG")
            sBarcodeStd_GR = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").GetValue("BARCODESTD_GR")
        Catch ex As Exception
            sqlServer = "192.168.1.16,1433"
            sqlDatabase = "BUSINESS"
            sqlLoginName = "SA"
            sqlPassword = ""
            sFiyat1 = "1"
            sFiyat2 = "2"
            sFiyat3 = "3"
            sFiyat4 = "4"
            sFiyatA = "A"
            sFiyatM = "M"
            sAktifFiyatTipi = "1"
            sBarcodeStd = "27"
            sBarcodeStd_KG = 2
            sBarcodeStd_GR = 3
            sDepo = "D002"
            Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("SERVER", sqlServer)
            Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("DATABASE", sqlDatabase)
            Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("USER", sqlLoginName)
            Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("PASSWORD", sqlPassword)
            Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("sDepo", sDepo)
            Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("sFiyat1", sFiyat1)
            Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("sFiyat2", sFiyat2)
            Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("sFiyat3", sFiyat3)
            Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("sFiyat4", sFiyat4)
            Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("sFiyatA", sFiyatA)
            Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("sFiyatM", sFiyatM)
            Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("sAktifFiyatTipi", sAktifFiyatTipi)
            Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").SetValue("BARCODESTD", sBarcodeStd)
            Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").SetValue("BARCODESTD_KG", sBarcodeStd_KG)
            Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").SetValue("BARCODESTD_GR", sBarcodeStd_GR)
        End Try
        txt_sqlServer.Text = sqlServer
        txt_sqlDatabase.Text = sqlDatabase
        txt_sqlLoginName.Text = sqlLoginName
        txt_sqlPassword.Text = sqlPassword
        txt_sFiyat1.Text = sFiyat1
        txt_sFiyat2.Text = sFiyat2
        txt_sFiyat3.Text = sFiyat3
        txt_sFiyatA.Text = sFiyatA
        txt_sFiyatM.Text = sFiyatM
        txt_sAktifFiyatTipi.Text = sAktifFiyatTipi
        txt_sBarcodestd.Text = sBarcodeStd
        txt_sGramajKg.Text = sBarcodeStd_KG
        txt_sGramajGr.Text = sBarcodeStd_GR
        txt_sDepo.Text = sDepo
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        sec_sIslem.CheckAll()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        sec_sIslem.UnCheckAll()
    End Sub
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        sqlServer = txt_sqlServer.Text
        sqlDatabase = txt_sqlDatabase.Text
        sqlLoginName = txt_sqlLoginName.Text
        sqlPassword = txt_sqlPassword.Text
        sFiyat1 = txt_sFiyat1.Text
        sFiyat2 = txt_sFiyat2.Text
        sFiyat3 = txt_sFiyat3.Text
        sFiyatA = txt_sFiyatA.Text
        sFiyatM = txt_sFiyatM.Text
        sAktifFiyatTipi = txt_sAktifFiyatTipi.Text
        sBarcodeStd = txt_sBarcodestd.Text
        sBarcodeStd_KG = txt_sGramajKg.Text
        sBarcodeStd_GR = txt_sGramajGr.Text
        sDateFormat = txt_dateformat.Text
        sDepo = txt_sDepo.Text
        sMagaza = sDepo
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("SERVER", sqlServer)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("DATABASE", sqlDatabase)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("USER", sqlLoginName)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("PASSWORD", sqlPassword)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("sDepo", sDepo)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("sFiyat1", sFiyat1)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("sFiyat2", sFiyat2)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("sFiyat3", sFiyat3)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("sFiyatA", sFiyatA)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("sFiyatM", sFiyatM)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("sAktifFiyatTipi", sAktifFiyatTipi)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("CONNECT").SetValue("sDateFormat", sDateFormat)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").SetValue("BARCODESTD", sBarcodeStd)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").SetValue("BARCODESTD_KG", sBarcodeStd_KG)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").SetValue("BARCODESTD_GR", sBarcodeStd_GR)
        XtraMessageBox.Show("Kayıt Defterine Başarıyla Kaydedildi...", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub program_satislari_aktar(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, Optional ByVal sFisler As String = "'P','K'", Optional ByVal bSor As Boolean = True)
        Dim bDevam As Boolean = True
        'If bSor = True Then
        '    If XtraMessageBox.Show("Satışları Sisteme Ayrı-Ayrı Aktarmak İstediğinize Eminmisiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
        '        bDevam = True
        '    End If
        'Else
        '    bDevam = True
        'End If
        Dim sQlConnection_orj = "Provider=SQLOLEDB.1;Password=" & txt_sqlPassword.Text & ";Persist Security Info=True;User ID=" & txt_sqlLoginName.Text & ";Initial Catalog=" & txt_sqlDatabase.Text & ";Data Source=" & txt_sqlServer.Text & ";Current Language=Türkçe;Application Name=Konsol"
        connection_resmi = sQlConnection_orj
        If bDevam = True Then
            Dim connection_orj = connection
            Dim sAlisVerisID = nAlisVerisID
            Dim ds As DataSet = sorgu(sorgu_query("SET DATEFORMAT DMY SELECT tbAlisVeris.*,tbMusteri.lKodu FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID Where tbAlisVeris.lMalBedeli <> 0 AND tbAlisVeris.sFisTipi IN (" & sFisler & ") and dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "' ORDER by tbAlisVeris.lFaturaNo"))
            Dim dsh As DataSet
            Dim dso As DataSet
            Dim dst As DataSet
            Dim dr As DataRow
            Dim dr1 As DataRow
            Dim dr2 As DataRow
            Dim dr3 As DataRow
            Dim nKayit As Integer = 0
            Dim nIslemID As Int64 = 0
            Dim nOdemeID As String = ""
            Dim nTaksitID As String = ""
            Dim nStokID As Int64 = 0
            Dim lMakbuzNo As Int64 = 0
            Dim musteri_kayit_sayisi As Int64 = 0
            Dim stok_kayit_sayisi As Int64 = 0
            Dim dr_stok As DataRow
            'Dim dr_stok_barkod As DataRow
            Dim barkod_var As Boolean = False
            Dim dr_stok_sinif As DataRow
            Dim dr_renk As DataRow
            Dim dr_stok_sinifi As DataRow
            Dim renk_kayit_sayisi As Int64 = 0
            Dim sinif_kayit_sayisi As Int64 = 0
            Dim dr_fiyat As DataRow
            Dim drn As DataRow
            Dim ds_tbStokFiyati As DataSet
            Dim sSet As String = ""
            ProgressBar1.Properties.Maximum = ds.Tables(0).Rows.Count
            ProgressBar1.EditValue = 0
            For Each dr In ds.Tables(0).Rows
                If connection.Contains("Provider=SQLOLEDB.1") = True Then
                    sSet = "SET DATEFORMAT " & sDateFormat & ""
                End If
                'Müşteri Kontrol
                musteri_kayit_sayisi = sorgu_musteri_kontrol(dr("lKodu"))
                Dim dr_Musteri As DataRow
                If musteri_kayit_sayisi = 0 Then
                    dataload_tbMusteri(dr("lKodu"))
                    dataload_tbMusteriNufusu(dr("lKodu"))
                    dr_Musteri = ds_tbMusteri.Tables(0).Rows(0)
                    nMusteriID = tbMusteri_kaydet_yeni(dr_Musteri("sMagaza"), dr_Musteri("lKodu"), dr_Musteri("sAdi"), dr_Musteri("sSoyadi"), dr_Musteri("nCinsiyet"), dr_Musteri("lAylikGelir"), dr_Musteri("dteKartAcilisTarihi"), dr_Musteri("nIskontoPesin"), dr_Musteri("nIskontoKredili"), dr_Musteri("sUnvan"), dr_Musteri("sVergiDairesi"), dr_Musteri("sVergiNo"), dr_Musteri("bYazismaEvAdresinemi"), dr_Musteri("sEmail"), dr_Musteri("sIsYeriAdi"), dr_Musteri("sIsAdresi1"), dr_Musteri("sIsAdresi2"), dr_Musteri("sIsSemt"), dr_Musteri("sIsIl"), dr_Musteri("sIsPostaKodu"), dr_Musteri("sIsTelefonu"), dr_Musteri("sEvAdresi1"), dr_Musteri("sEvAdresi2"), dr_Musteri("sEvSemt"), dr_Musteri("sEvPostaKodu"), dr_Musteri("sEvIl"), dr_Musteri("sEvTelefonu"), dr_Musteri("sSigortaNo"), dr_Musteri("bEvlimi"), dr_Musteri("dteEvlilikTarihi"), dr_Musteri("dteDogumTarihi"), dr_Musteri("sDogumYeri"), dr_Musteri("sEhliyetNo"), dr_Musteri("sKanGrubu"), dr_Musteri("sHitap"), dr_Musteri("sKullaniciAdi"), dr_Musteri("dteKayitTarihi"), dr_Musteri("sAciklama1"), dr_Musteri("sAciklama2"), dr_Musteri("sAciklama3"), dr_Musteri("sAciklama4"), dr_Musteri("sAciklama5"), dr_Musteri("sGSM"), dr_Musteri("sFax"), dr_Musteri("sResimAdi"))
                    tbMusteriSinifi_kaydet_yeni(nMusteriID, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
                    For Each drn In ds_tbMusteriNufusu.Tables(0).Rows
                        tbMusteriNufusu_kaydet_yeni(nMusteriID, drn("sDin"), drn("sKutukIl"), drn("sKutukIlce"), drn("sKutukMahalle"), drn("sKutukCiltNo"), drn("sKutukSiraNo"), drn("dteNufusCuzdanTarihi"), drn("sCuzdanVerilenYer"), drn("sCuzdanVerNedeni"), drn("sCuzdanKayitNo"), drn("sAnneAdi"), drn("sBabaAdi"), drn("sAileAdresi1"), drn("sAileAdresi2"), drn("sAileSemt"), drn("sAilePostaKodu"), drn("sAileIl"), drn("sAileTelefonu"), drn("sHitapAnne"), drn("sHitapBaba"))
                    Next
                    drn = Nothing
                Else
                End If

                dr("nMusteriID") = sorgu_nMusteriID(dr("lKodu"))
                nKayit = sorgula_nStokID(sSet & " SELECT     COUNT(nAlisverisID) AS nKayit FROM         tbAlisVeris WHERE     (sFisTipi = '" & dr("sFisTipi") & "') AND (dteFaturaTarihi = '" & dr("dteFaturaTarihi") & "') AND (nMusteriID = " & dr("nMusteriID") & " ) AND (lFaturaNo = " & dr("lFaturaNo") & ") AND (nGirisCikis = " & dr("nGirisCikis") & ") and (sMagaza = '" & dr("sMagaza") & "') ")
                If nKayit = 0 Then
                    tbKasiyer_kontrol()
                    'Kayda Başla
                    sMagaza = dr("sMagaza")
                    nAlisVerisID = sorgu_nAlisVerisID(sMagaza)
                    lFaturaNo = dr("lFaturaNo") 'sorgu_lFaturaNo(sMagaza, sFisTipi)
                    dr("sHareketTipi") = Microsoft.VisualBasic.Right(sMagaza, 3)
                    sHareketTipi = dr("sHareketTipi") 'Microsoft.VisualBasic.Right(sMagaza, 2)
                    tbAlisVeris_kaydet_yeni(dr("sMagaza") & nAlisVerisID.ToString, dr("sFisTipi"), dr("dteFaturaTarihi"), dr("nGirisCikis"), dr("lFaturaNo"), dr("nMusteriID"), dr("sMagaza"), sKasiyerRumuzu, dr("sAlisVerisYapanAdi"), dr("sAlisVerisYapanSoyadi"), dr("lToplamMiktar"), dr("lMalBedeli"), dr("lMalIskontoTutari"), dr("nDipIskontoYuzdesi"), dr("lDipIskontoTutari"), dr("nKdvOrani1"), dr("lKdvMatrahi1"), dr("lKdv1"), dr("nKdvOrani2"), dr("lKdvMatrahi2"), dr("lKdv2"), dr("nKdvOrani3"), dr("lKdvMatrahi3"), dr("lKdv3"), dr("nKdvOrani4"), dr("lKdvMatrahi4"), dr("lKdv4"), dr("nKdvOrani5"), dr("lKdvMatrahi5"), dr("lKdv5"), dr("lPesinat"), dr("nVadeFarkiYuzdesi"), dr("nVadeKdvOrani"), dr("lVadeKdvMatrahi"), dr("lVadeKdv"), dr("lVadeFarki"), dr("sOdemeKodu"), dr("lNetTutar"), dr("sHareketTipi"), dr("bMuhasebeyeIslendimi"), dr("nKasaNo"), "Konsol", dr("dteKayitTarihi"), dr("sYaziIle"))
                    tbAvSirano_degistir(1, nAlisVerisID, sMagaza)
                    lFaturaNo_degistir(lFaturaNo, sMagaza)
                    nAlisVerisID = sMagaza & nAlisVerisID.ToString
                    'Detayları Aktar
                    dsh = sorgu(sorgu_query("SELECT     tbStokFisiDetayi.*, tbStok.sKodu FROM         tbStokFisiDetayi INNER JOIN                       tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID Where tbStokFisiDetayi.nAlisVerisID = '" & dr("nAlisVerisID") & "'"))
                    nIslemID = sorgu_nStokIslemID()
                    fis_detay_fisno_degistir(nIslemID)
                    For Each dr1 In dsh.Tables(0).Rows
                        nIslemID = sorgu_nStokIslemID_MERKEZ()
                        Dim bDevamEt As Boolean
                        bDevamEt = False
                        'Stokları Kontrol et
                        stok_kayit_sayisi = sorgu_stok_kontrol(Trim(dr1("sKodu")))
                        If stok_kayit_sayisi = 0 Then
                            'MsgBox(dr("sKodu") & " Kodlu Stok Kaydı Bulunamadı",sDil), MessageBoxIcon.Warning)
                            'Stok Bilgini Çek
                            dataload_stok(dr1("sKodu"))
                            ds_tbStokFiyati = sorgu(sorgu_query("Select * from tbStokFiyati Where nStokID =" & dr1("nStokID") & ""), "TABLE1")
                            'Stok Barkod Bilgisini Çek
                            dataload_stok_barkod(dr1("nStokID"))
                            Dim dr_stok_barkod As DataRow
                            If ds_stok_barkod.Tables(0).Rows.Count > 0 Then
                                barkod_var = True
                                dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                            Else
                                barkod_var = False
                            End If
                            'Sınıf Bilgisini Çek
                            dataload_stok_sinif(dr1("nStokID"))
                            'datarowa yükle
                            dr_stok = ds_stok.Tables(0).Rows(0)
                            'dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                            dr_stok_sinif = ds_stok_sinif.Tables(0).Rows(0)
                            renk_kayit_sayisi = sorgu_Renk_kontrol(dr_stok("sRenk"))
                            If renk_kayit_sayisi = 0 Then
                                dataload_sRenk(dr_stok("sRenk"))
                                dr_renk = ds_renk.Tables(0).Rows(0)
                                stok_renk_kaydet_yeni(dr_renk("sRenk"), dr_renk("sRenkAdi"), dr_renk("lRenkNo"))
                            Else
                            End If
                            'Sınıf Kayıtlarını Kontrol Et
                            For ı As Integer = 1 To 15
                                'MsgBox(dr_stok_sinif("sSinifKodu" & i & ""))
                                sinif_kayit_sayisi = sorgu_Sinif_kontrol(dr_stok_sinif("sSinifKodu" & ı & ""), ı)
                                If sinif_kayit_sayisi = 0 Then
                                    dataload_stok_sinif1(dr_stok_sinif("sSinifKodu" & ı & ""), ı)
                                    dr_stok_sinifi = ds_stok_sinif.Tables(0).Rows(0)
                                    stok_sinif_kaydet_yeni(dr_stok_sinifi("sSinifKodu"), dr_stok_sinifi("sAciklama"), ı)
                                Else
                                End If
                            Next
                            'Stoğu Kaydet
                            nStokID = stok_kaydet_yeni(dr_stok("sKodu"), dr_stok("sAciklama"), dr_stok("sKisaAdi"), dr_stok("nStokTipi"), dr_stok("sBedenTipi"), dr_stok("sKavalaTipi"), dr_stok("sRenk"), dr_stok("sBeden"), dr_stok("sKavala"), dr_stok("sBirimCinsi1"), dr_stok("sBirimCinsi2"), dr_stok("nIskontoYuzdesi"), dr_stok("sKdvTipi"), dr_stok("nTeminSuresi"), dr_stok("lAsgariMiktar"), dr_stok("lAzamiMiktar"), dr_stok("sOzelNot"), dr_stok("nFiyatlandirma"), dr_stok("sModel"), dr_stok("sKullaniciAdi"), dr_stok("dteKayitTarihi"), dr_stok("bEksiyeDusulebilirmi"), dr_stok("sDefaultAsortiTipi"), dr_stok("bEksideUyarsinmi"), dr_stok("bOTVVar"), dr_stok("sOTVTipi"), dr_stok("nIskontoYuzdesiAV"), dr_stok("bEk1"), dr_stok("nEk2"))
                            'barkodu kaydet
                            If barkod_var = True Then
                                dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                                If dr_stok_barkod("nKisim") = 0 Or dr_stok_barkod("nKisim") = 1 Then
                                Else
                                    dr_stok_barkod("nKisim") = 0
                                End If
                                If dr_stok_barkod("sKarsiStokKodu") = Microsoft.VisualBasic.Right(dr_stok_barkod("nStokID"), 6) Then
                                    dr_stok_barkod("sKarsiStokKodu") = ""
                                End If
                                stok_barkod_kaydet_yeni(nStokID, dr_stok_barkod("sBarkod"), dr_stok_barkod("nKisim"), dr_stok_barkod("nFirmaID"), dr_stok_barkod("sKarsiStokKodu"), dr_stok_barkod("sKarsiStokAciklama"))
                            Else
                            End If
                            For Each dr_fiyat In ds_tbStokFiyati.Tables(0).Rows
                                tbStokFiyati_ekle_yeni(dr_stok("nFiyatlandirma"), dr_stok("sModel"), dr_stok("sRenk"), dr_stok("sBeden"), dr_fiyat("sFiyatTipi"), dr_fiyat("lFiyat"), dr_fiyat("dteFiyatTespitTarihi"), dr_fiyat("sKullaniciAdi"))
                            Next
                            'sınıfları kaydet
                            stok_siniflari_kaydet_yeni(nStokID, dr_stok_sinif("sSinifKodu1"), dr_stok_sinif("sSinifKodu2"), dr_stok_sinif("sSinifKodu3"), dr_stok_sinif("sSinifKodu4"), dr_stok_sinif("sSinifKodu5"), dr_stok_sinif("sSinifKodu6"), dr_stok_sinif("sSinifKodu7"), dr_stok_sinif("sSinifKodu8"), dr_stok_sinif("sSinifKodu9"), dr_stok_sinif("sSinifKodu10"), dr_stok_sinif("sSinifKodu11"), dr_stok_sinif("sSinifKodu12"), dr_stok_sinif("sSinifKodu13"), dr_stok_sinif("sSinifKodu14"), dr_stok_sinif("sSinifKodu15"))
                            'Birim Cevrimi
                            Dim ds_tbStokBirimCevrimi As DataSet = sorgu(sorgu_query("Select * from tbStokBirimCevrimi Where nStokID IN (Select nStokID from tbStok where  sModel = '" & dr_stok("sModel") & "')"))
                            For Each drn In ds_tbStokBirimCevrimi.Tables(0).Rows
                                tbStokBirimCevrimi_kaydet_yeni(drn("sBirimCinsi"), drn("lOran"), dr_stok("sModel"))
                            Next
                        Else
                            nStokID = sorgu_nStokID(Trim(dr1("sKodu")))
                        End If
                        Try
                        Catch ex As Exception
                        End Try
                        'Kayda Başla
                        dr1("nMusteriID") = dr("nMusteriID")
                        dr1("nStokID") = nStokID
                        Try
                            nIslemID = tbStokFisidetay_kaydet_yeni(nIslemID, dr1("nStokID"), dr1("dteIslemTarihi"), dr1("nFirmaID"), dr1("nMusteriID"), dr1("sFisTipi").ToString, dr1("dteFisTarihi"), dr1("lFisNo"), dr1("nGirisCikis"), dr("sMagaza").ToString, dr1("lReyonFisNo"), dr1("sStokIslem").ToString, dr1("sKasiyerRumuzu").ToString, dr1("sSaticiRumuzu").ToString, dr1("sOdemeKodu").ToString, dr1("dteIrsaliyeTarihi"), dr1("lIrsaliyeNo"), sorgu_sayi(dr1("lGirisMiktar1"), 0), sorgu_sayi(dr1("lGirisMiktar2"), 0), sorgu_sayi(dr1("lGirisFiyat"), 0), sorgu_sayi(dr1("lGirisTutar"), 0), sorgu_sayi(dr1("lCikisMiktar1"), 0), sorgu_sayi(dr1("lCikisMiktar2"), 0), sorgu_sayi(dr1("lCikisFiyat"), 0), sorgu_sayi(dr1("lCikisTutar"), 0), dr1("sFiyatTipi").ToString, sorgu_sayi(dr1("lBrutFiyat"), 0), sorgu_sayi(dr1("lBrutTutar"), 0), sorgu_sayi(dr1("lMaliyetFiyat"), 0), sorgu_sayi(dr1("lMaliyetTutar"), 0), sorgu_sayi(dr1("lIlaveMaliyetTutar"), 0), sorgu_sayi(dr1("nIskontoYuzdesi"), 0), sorgu_sayi(dr1("lIskontoTutari"), 0), dr1("sDovizCinsi").ToString, sorgu_sayi(dr1("lDovizFiyat"), 0), "", dr1("nReceteNo"), "", "", sorgu_sayi(dr1("nKdvOrani"), 0), dr1("nHesapID"), dr1("sAciklama").ToString, sHareketTipi.ToString, dr1("bMuhasebeyeIslendimi"), dr1("sKullaniciAdi").ToString, dr1("dteKayitTarihi"), dr1("sDovizCinsi1").ToString, sorgu_sayi(dr1("lDovizMiktari1"), 0), sorgu_sayi(dr1("lDovizKuru1"), 0), dr1("sDovizCinsi2").ToString, sorgu_sayi(dr1("lDovizMiktari2"), 0), sorgu_sayi(dr1("lDovizKuru2"), 0), dr1("nOTVOrani"), "", nAlisVerisID, "NULL", "NULL", dr1("sMasrafYontemi").ToString, dr1("sHangiUygulama").ToString, dr1("nEksaha1"), dr1("nEkSaha2"), dr1("bEkSoru1"), dr1("bEkSoru2"), dr1("sSonKullaniciAdi").ToString, dr1("dteSonUpdateTarihi"))
                            bDevamEt = True
                        Catch ex As Exception
                            nIslemID = nIslemID + 1
                            'tbStokFisidetay_kaydet_yeni(nIslemID, dr1("nStokID"), dr1("dteIslemTarihi"), dr1("nFirmaID"), dr1("nMusteriID"), dr1("sFisTipi").ToString, dr1("dteFisTarihi"), dr1("lFisNo"), dr1("nGirisCikis"), sMagaza.ToString, dr1("lReyonFisNo"), dr1("sStokIslem").ToString, dr1("sKasiyerRumuzu").ToString, dr1("sSaticiRumuzu").ToString, dr1("sOdemeKodu").ToString, dr1("dteIrsaliyeTarihi"), dr1("lIrsaliyeNo"), sorgu_sayi(dr1("lGirisMiktar1"), 0), sorgu_sayi(dr1("lGirisMiktar2"), 0), sorgu_sayi(dr1("lGirisFiyat"), 0), sorgu_sayi(dr1("lGirisTutar"), 0), sorgu_sayi(dr1("lCikisMiktar1"), 0), sorgu_sayi(dr1("lCikisMiktar2"), 0), sorgu_sayi(dr1("lCikisFiyat"), 0), sorgu_sayi(dr1("lCikisTutar"), 0), dr1("sFiyatTipi").ToString, sorgu_sayi(dr1("lBrutFiyat"), 0), sorgu_sayi(dr1("lBrutTutar"), 0), sorgu_sayi(dr1("lMaliyetFiyat"), 0), sorgu_sayi(dr1("lMaliyetTutar"), 0), sorgu_sayi(dr1("lIlaveMaliyetTutar"), 0), sorgu_sayi(dr1("nIskontoYuzdesi"), 0), sorgu_sayi(dr1("lIskontoTutari"), 0), dr1("sDovizCinsi").ToString, sorgu_sayi(dr1("lDovizFiyat"), 0), "", dr1("nReceteNo"), "", "", sorgu_sayi(dr1("nKdvOrani"), 0), dr1("nHesapID"), dr1("sAciklama").ToString, sHareketTipi.ToString, dr1("bMuhasebeyeIslendimi"), dr1("sKullaniciAdi").ToString, dr1("dteKayitTarihi"), dr1("sDovizCinsi1").ToString, sorgu_sayi(dr1("lDovizMiktari1"), 0), sorgu_sayi(dr1("lDovizKuru1"), 0), dr1("sDovizCinsi2").ToString, sorgu_sayi(dr1("lDovizMiktari2"), 0), sorgu_sayi(dr1("lDovizKuru2"), 0), dr1("nOTVOrani"), "", nAlisVerisID, "NULL", "NULL", dr1("sMasrafYontemi").ToString, dr1("sHangiUygulama").ToString, dr1("nEksaha1"), dr1("nEkSaha2"), dr1("bEkSoru1"), dr1("bEkSoru2"), dr1("sSonKullaniciAdi").ToString, dr1("dteSonUpdateTarihi"))
                        End Try
                        If bDevamEt = False Then
                            nIslemID = sorgu_nStokIslemID_MERKEZ() 'nIslemID + 1
                            nIslemID = tbStokFisidetay_kaydet_yeni(nIslemID, dr1("nStokID"), dr1("dteIslemTarihi"), dr1("nFirmaID"), dr1("nMusteriID"), dr1("sFisTipi").ToString, dr1("dteFisTarihi"), dr1("lFisNo"), dr1("nGirisCikis"), dr("sMagaza").ToString, dr1("lReyonFisNo"), dr1("sStokIslem").ToString, dr1("sKasiyerRumuzu").ToString, dr1("sSaticiRumuzu").ToString, dr1("sOdemeKodu").ToString, dr1("dteIrsaliyeTarihi"), dr1("lIrsaliyeNo"), sorgu_sayi(dr1("lGirisMiktar1"), 0), sorgu_sayi(dr1("lGirisMiktar2"), 0), sorgu_sayi(dr1("lGirisFiyat"), 0), sorgu_sayi(dr1("lGirisTutar"), 0), sorgu_sayi(dr1("lCikisMiktar1"), 0), sorgu_sayi(dr1("lCikisMiktar2"), 0), sorgu_sayi(dr1("lCikisFiyat"), 0), sorgu_sayi(dr1("lCikisTutar"), 0), dr1("sFiyatTipi").ToString, sorgu_sayi(dr1("lBrutFiyat"), 0), sorgu_sayi(dr1("lBrutTutar"), 0), sorgu_sayi(dr1("lMaliyetFiyat"), 0), sorgu_sayi(dr1("lMaliyetTutar"), 0), sorgu_sayi(dr1("lIlaveMaliyetTutar"), 0), sorgu_sayi(dr1("nIskontoYuzdesi"), 0), sorgu_sayi(dr1("lIskontoTutari"), 0), dr1("sDovizCinsi").ToString, sorgu_sayi(dr1("lDovizFiyat"), 0), "", dr1("nReceteNo"), "", "", sorgu_sayi(dr1("nKdvOrani"), 0), dr1("nHesapID"), dr1("sAciklama").ToString, sHareketTipi.ToString, dr1("bMuhasebeyeIslendimi"), dr1("sKullaniciAdi").ToString, dr1("dteKayitTarihi"), dr1("sDovizCinsi1").ToString, sorgu_sayi(dr1("lDovizMiktari1"), 0), sorgu_sayi(dr1("lDovizKuru1"), 0), dr1("sDovizCinsi2").ToString, sorgu_sayi(dr1("lDovizMiktari2"), 0), sorgu_sayi(dr1("lDovizKuru2"), 0), dr1("nOTVOrani"), "", nAlisVerisID, "NULL", "NULL", dr1("sMasrafYontemi").ToString, dr1("sHangiUygulama").ToString, dr1("nEksaha1"), dr1("nEkSaha2"), dr1("bEkSoru1"), dr1("bEkSoru2"), dr1("sSonKullaniciAdi").ToString, dr1("dteSonUpdateTarihi"))
                        End If
                        fis_detay_fisno_degistir(nIslemID)
                    Next
                    'Tahsilatları Aktar
                    dso = sorgu(sorgu_query("Select * from tbOdeme Where nAlisVerisID ='" & dr("nAlisVerisID") & "' and nOdemeKodu IN(1,3)"))
                    For Each dr2 In dso.Tables(0).Rows
                        If lMakbuzNo = sorgu_lMakbuzNo_varmi(sMagaza, nAlisVerisID) = 0 Then
                            lMakbuzNo = sorgu_lMakbuzNo(sMagaza, dr2("nOdemeKodu"))
                            lMakbuzNo_degistir(lMakbuzNo, sMagaza)
                        End If
                        nOdemeID = sorgu_nOdemeID(sMagaza).ToString
                        tbOdeme_kaydet_yeni(sMagaza & nOdemeID, nAlisVerisID, dr2("sOdemeSekli"), dr2("nOdemeKodu"), dr2("sKasiyerRumuzu"), dr2("dteOdemeTarihi"), dr2("dteValorTarihi"), dr2("lOdemeTutar"), dr2("sDovizCinsi"), dr2("lDovizTutar"), lMakbuzNo, lMakbuzNo, dr2("nTaksitID"), dr2("nIadeAlisVerisID"), dr2("bMuhasebeyeIslendimi"), dr2("nKasaNo"), dr2("sKartNo"), dr2("sKullaniciAdi"), dr2("dteKayitTarihi"), sMagaza)
                        tbAvSirano_degistir(2, nOdemeID, sMagaza)
                    Next
                    'Taksitleri Aktar
                    dst = sorgu(sorgu_query("Select * from tbTaksit Where nAlisVerisID ='" & dr("nAlisVerisID") & "'"))
                    For Each dr3 In dst.Tables(0).Rows
                        nTaksitID = sorgu_nTaksitID(sMagaza)
                        tbTaksit_kaydet_yeni(sMagaza & nTaksitID, nAlisVerisID, dr3("dteTarihi"), dr3("lTutari"))
                        tbAvSirano_degistir(3, nTaksitID, sMagaza)
                    Next
                    ProgressBar1.EditValue += 1
                    ProgressBar1.Refresh()
                Else
                    'MsgBox("Belge Sisteme Kayıtlı")
                End If
            Next
            ProgressBar1.EditValue = 0
            ProgressBar1.Refresh()
            nAlisVerisID = sAlisVerisID
            'MsgBox("İşlem Başarıyla Tamamlandı")
        End If
    End Sub
    Private Sub tbStokFisi_Oku(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sFisler As String, Optional ByVal nTalepID As String = "")
        Dim dataset1 As New DataSet
        Dim dataset2 As New DataSet
        Dim dataset3 As New DataSet
        Dim nFirmaID As Int64 = 0
        Dim nStokID As Int64 = 0
        Dim cari_kayit_sayisi As Int64 = 0
        Dim stok_kayit_sayisi As Int64 = 0
        Dim dr_stok As DataRow
        'Dim dr_stok_barkod As DataRow
        Dim barkod_var As Boolean = False
        Dim dr_stok_sinif As DataRow
        Dim dr_renk As DataRow
        Dim dr_stok_sinifi As DataRow
        Dim renk_kayit_sayisi As Int64 = 0
        Dim sinif_kayit_sayisi As Int64 = 0
        Dim dr_cari As DataRow
        Dim dr_fiyat As DataRow
        Dim drn As DataRow
        Dim ds_tbStokFiyati As DataSet
        Dim kriter As String = ""
        If nTalepID = "" Then
        Else
            kriter += " and tbStokFisiMaster.nStokFisiID = '" & nTalepID & "' "
        End If
        dataset1 = sorgu("SELECT     tbStokFisiMaster.*, tbFirma.sKodu AS sFirmaKodu FROM         tbStokFisiMaster LEFT OUTER JOIN                       tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID Where tbStokFisiMaster.dteFisTarihi between '" & tarih1 & "' and '" & tarih2 & "' and tbStokFisiMaster.sFisTipi IN (" & sFisler & ") " & kriter & "")
        dg.DataSource = dataset1.Tables(0)
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim dr2 As DataRow
        ProgressBar1.Properties.Maximum = dataset1.Tables(0).Rows.Count
        ProgressBar1.EditValue = 0
        Me.Refresh()
        If sCon.State = ConnectionState.Open = True Then
            sCon.Close()
        End If
        sCmd.Connection = sCon
        sCmd.CommandTimeout = Nothing
        sCon.ConnectionString = sConnection
        If sCon.State = ConnectionState.Closed = True Then
            sCon.Open()
        End If
        For Each dr In dataset1.Tables(0).Rows
            cari_kayit_sayisi = sorgu_firma_kontrol(dr("sFirmaKodu"))
            If cari_kayit_sayisi = 0 Then
                'MsgBox(dr_baslik("sKodu") & " Kodlu Firma Kaydı Bulunamadı",sDil), MessageBoxIcon.Warning)
                dataload_cari(dr("sFirmaKodu"))
                dr_cari = ds_firma.Tables(0).Rows(0)
                Dim nHesapID = tbHesapPlani_kaydet_yeni(dr_cari("sKodu"), dr_cari("sAciklama"), "", 0, "", 0, "", "", 0, kullanici, Now)
                nFirmaID = firma_kaydet_yeni(dr_cari("sKodu"), dr_cari("sAciklama"), dr_cari("nOzelIskontosu"), dr_cari("lKrediLimiti"), dr_cari("dteMutabakatTarihi"), dr_cari("nVadeGun"), dr_cari("sHitap"), dr_cari("sAdres1"), dr_cari("sAdres2"), dr_cari("sSemt"), dr_cari("sIl"), dr_cari("sUlke"), dr_cari("sPostaKodu"), dr_cari("sVergiDairesi"), dr_cari("sVergiNo"), nHesapID, dr_cari("sOzelNot"), dr_cari("sKullaniciAdi"), dr_cari("dteKayitTarihi"), dr_cari("sFiyatTipi"))
                Dim ds_tbFirmaSinifi As DataSet = sorgu(sorgu_query("Select * from tbFirmaSinifi Where nFirmaID = " & dr_cari("nFirmaID") & ""))
                For Each dr_cari In ds_tbFirmaSinifi.Tables(0).Rows
                    firma_siniflari_kaydet_yeni(nFirmaID, dr_cari("sSinifKodu1"), dr_cari("sSinifKodu2"), dr_cari("sSinifKodu3"), dr_cari("sSinifKodu4"), dr_cari("sSinifKodu5"))
                Next
                ds_tbFirmaSinifi.Dispose()
                ds_tbFirmaSinifi = Nothing
                Dim ds_tbFirmaIletisimi As DataSet = sorgu(sorgu_query("Select * from tbFirmaIletisimi Where nFirmaID = " & dr_cari("nFirmaID") & ""))
                For Each dr_cari In ds_tbFirmaIletisimi.Tables(0).Rows
                    tbFirmaIletisimi_kaydet_yeni(nFirmaID, dr_cari("sIletisimAraci"), dr_cari("sIletisimAdresi"))
                Next
                ds_tbFirmaIletisimi.Dispose()
                ds_tbFirmaIletisimi = Nothing
                Dim ds_tbFirmaYetkilisi As DataSet = sorgu(sorgu_query("Select * from tbFirmaYetkilisi Where nFirmaID = " & dr_cari("nFirmaID") & ""))
                For Each dr_cari In ds_tbFirmaYetkilisi.Tables(0).Rows
                    tbFirmaYetkilisi_kaydet_yeni(nFirmaID, dr_cari("sUnvan"), dr_cari("sHitap"), dr_cari("sAdiSoyadi"))
                Next
                ds_tbFirmaYetkilisi.Dispose()
                ds_tbFirmaYetkilisi = Nothing
            End If
            nFirmaID = sorgu_nfirmaID(dr("sFirmaKodu"))
            If sorgu_fis_kontrol(dr("sFisTipi"), dr("nGirisCikis"), dr("dteFisTarihi"), dr("lFisNo"), nFirmaID) = 0 Then
                dataset2 = sorgu("SELECT     tbStokFisiDetayi.*, tbStok.sKodu AS sKodu FROM         tbStokFisiDetayi LEFT OUTER JOIN                       tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID Where tbStokFisiDetayi.nStokFisiID =" & dr("nStokFisiID") & " ")
                dataset3 = sorgu("Select * from tbStokFisiAciklamasi Where nStokFisiID = " & dr("nStokFisiID") & " ")
                dr2 = dataset3.Tables(0).Rows(0)
                Dim nStokFisiID As Int64 = sorgu_nStokFisiID()
                nStokFisiID = tbStokFisiMaster_kaydet_yeni(nStokFisiID, dr("sFisTipi"), dr("dteFisTarihi"), dr("nGirisCikis"), dr("lFisNo"), nFirmaID, dr("sDepo").ToString, dr("dteValorTarihi"), dr("bPesinmi"), dr("bListelendimi"), dr("bHizmetFaturasimi"), dr("lToplamMiktar"), dr("lMalBedeli"), dr("lMalIskontoTutari"), dr("nDipIskontoYuzdesi1"), dr("lDipIskontoTutari1"), dr("nDipIskontoYuzdesi2"), dr("lDipIskontoTutari2"), dr("lDipIskontoTutari3"), dr("lEkMaliyet1"), dr("lEkMaliyet2"), dr("lEkMaliyet3"), dr("nKdvOrani1"), dr("lKdvMatrahi1"), dr("lKdv1"), dr("nKdvOrani2"), dr("lKdvMatrahi2"), dr("lKdv2"), dr("nKdvOrani3"), dr("lKdvMatrahi3"), dr("lKdv3"), dr("nKdvOrani4"), dr("lKdvMatrahi4"), dr("lKdv4"), dr("nKdvOrani5"), dr("lKdvMatrahi5"), dr("lKdv5"), dr("lNetTutar"), dr("nTevkifatKdvOrani"), dr("lTevkifatKdvMatrahi"), dr("lTevkifatKdv"), dr("sCariIslem").ToString, dr("nCariHareketID").ToString, dr("nKasaIslemID").ToString, dr("sCariKdvIslem").ToString, dr("nCariKdvHareketID").ToString, dr("sHareketTipi").ToString, dr("bMuhasebeyeIslendimi"), dr("bFisTamamlandimi"), dr("lTransferFisiID").ToString, dr("nTransferFirmaID").ToString, dr("sTransferDepo").ToString, dr("bFaturayaDonustumu"), dr("sKullaniciAdi").ToString, dr("dteKayitTarihi"), dr("sYaziIle").ToString, dr("nOTVOrani1"), dr("lOTVMatrahi1"), dr("lOTV1"), dr("nOTVOrani2"), dr("lOTVMatrahi2"), dr("lOTV2"))
                tbStokFisiAciklamasi_kaydet_yeni(nStokFisiID, dr2("sAciklama1"), dr2("sAciklama2"), dr2("sAciklama3"), dr2("sAciklama4"), dr2("sAciklama5"))
                'tbStokFisiMaster_lFisno_degistir(nStokFisiID)
                Dim nHareketID As Int64
                nHareketID = sorgu_nCariHareketID_sql()
                Dim lBorcTutar As Decimal = 0
                Dim lAlacakTutar As Decimal = 0
                Dim lDovizMiktar1 As Decimal = 0
                Dim lNetTutar As Decimal = sorgu_decimal(dr("lNetTutar"), 0)
                If dr("nGirisCikis") = 1 Then
                    lBorcTutar = 0
                    lAlacakTutar = Math.Abs(lNetTutar)
                ElseIf dr("nGirisCikis") = 2 Then
                    lBorcTutar = Math.Abs(lNetTutar)
                    lAlacakTutar = 0
                ElseIf dr("nGirisCikis") = 3 Then
                    lBorcTutar = Math.Abs(lNetTutar)
                    lAlacakTutar = 0
                ElseIf dr("nGirisCikis") = 4 Then
                    lBorcTutar = 0
                    lAlacakTutar = Math.Abs(lNetTutar)
                End If
                stbFirmaHareketi_kaydet_yeni(nHareketID, nFirmaID, dr("dteFisTarihi"), dr("dteValorTarihi"), dr("sFisTipi"), "Evrak No: " & dr("lFisNo"), lBorcTutar, lAlacakTutar, dr("lFisNo"), 0, dr("sFisTipi"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, dr("sKullaniciAdi"), dr("dteKayitTarihi"))
                tbStokFisiOdemePlani_kaydet_yeni(nStokFisiID, dr("dteFisTarihi"), dr("lNetTutar"), dr("sFisTipi"), nHareketID)
                tbFirmaHareketi_nCariHareketID_degistir(nHareketID)
                ProgressBar2.Properties.Maximum = dataset2.Tables(0).Rows.Count
                ProgressBar2.EditValue = 0
                For Each dr1 In dataset2.Tables(0).Rows
                    Dim nIslemID As Int64 = sorgu_nStokIslemID()
                    'Stokları Kontrol et
                    stok_kayit_sayisi = sorgu_stok_kontrol(Trim(dr1("sKodu")))
                    If stok_kayit_sayisi = 0 Then
                        'MsgBox(dr("sKodu") & " Kodlu Stok Kaydı Bulunamadı",sDil), MessageBoxIcon.Warning)
                        'Stok Bilgini Çek
                        dataload_stok(dr1("sKodu"))
                        ds_tbStokFiyati = sorgu(sorgu_query("Select * from tbStokFiyati Where nStokID =" & dr1("nStokID") & ""), "TABLE1")
                        'Stok Barkod Bilgisini Çek
                        dataload_stok_barkod(dr1("nStokID"))
                        Dim dr_stok_barkod As DataRow
                        If ds_stok_barkod.Tables(0).Rows.Count > 0 Then
                            barkod_var = True
                            dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                        Else
                            barkod_var = False
                        End If
                        'Sınıf Bilgisini Çek
                        dataload_stok_sinif(dr1("nStokID"))
                        'datarowa yükle
                        dr_stok = ds_stok.Tables(0).Rows(0)
                        'dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                        dr_stok_sinif = ds_stok_sinif.Tables(0).Rows(0)
                        renk_kayit_sayisi = sorgu_Renk_kontrol(dr_stok("sRenk"))
                        If renk_kayit_sayisi = 0 Then
                            dataload_sRenk(dr_stok("sRenk"))
                            dr_renk = ds_renk.Tables(0).Rows(0)
                            stok_renk_kaydet_yeni(dr_renk("sRenk"), dr_renk("sRenkAdi"), dr_renk("lRenkNo"))
                        Else
                        End If
                        'Sınıf Kayıtlarını Kontrol Et
                        For ı As Integer = 1 To 15
                            'MsgBox(dr_stok_sinif("sSinifKodu" & i & ""))
                            sinif_kayit_sayisi = sorgu_Sinif_kontrol(dr_stok_sinif("sSinifKodu" & ı & ""), ı)
                            If sinif_kayit_sayisi = 0 Then
                                dataload_stok_sinif1(dr_stok_sinif("sSinifKodu" & ı & ""), ı)
                                dr_stok_sinifi = ds_stok_sinif.Tables(0).Rows(0)
                                stok_sinif_kaydet_yeni(dr_stok_sinifi("sSinifKodu"), dr_stok_sinifi("sAciklama"), ı)
                            Else
                            End If
                        Next
                        'Stoğu Kaydet
                        nStokID = stok_kaydet_yeni(dr_stok("sKodu"), dr_stok("sAciklama"), dr_stok("sKisaAdi"), dr_stok("nStokTipi"), dr_stok("sBedenTipi"), dr_stok("sKavalaTipi"), dr_stok("sRenk"), dr_stok("sBeden"), dr_stok("sKavala"), dr_stok("sBirimCinsi1"), dr_stok("sBirimCinsi2"), dr_stok("nIskontoYuzdesi"), dr_stok("sKdvTipi"), dr_stok("nTeminSuresi"), dr_stok("lAsgariMiktar"), dr_stok("lAzamiMiktar"), dr_stok("sOzelNot"), dr_stok("nFiyatlandirma"), dr_stok("sModel"), dr_stok("sKullaniciAdi"), dr_stok("dteKayitTarihi"), dr_stok("bEksiyeDusulebilirmi"), dr_stok("sDefaultAsortiTipi"), dr_stok("bEksideUyarsinmi"), dr_stok("bOTVVar"), dr_stok("sOTVTipi"), dr_stok("nIskontoYuzdesiAV"), dr_stok("bEk1"), dr_stok("nEk2"))
                        'barkodu kaydet
                        If barkod_var = True Then
                            dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                            If dr_stok_barkod("nKisim") = 0 Or dr_stok_barkod("nKisim") = 1 Then
                            Else
                                dr_stok_barkod("nKisim") = 0
                            End If
                            If dr_stok_barkod("sKarsiStokKodu") = Microsoft.VisualBasic.Right(dr_stok_barkod("nStokID"), 6) Then
                                dr_stok_barkod("sKarsiStokKodu") = ""
                            End If
                            stok_barkod_kaydet_yeni(nStokID, dr_stok_barkod("sBarkod"), dr_stok_barkod("nKisim"), dr_stok_barkod("nFirmaID"), dr_stok_barkod("sKarsiStokKodu"), dr_stok_barkod("sKarsiStokAciklama"))
                        Else
                        End If
                        For Each dr_fiyat In ds_tbStokFiyati.Tables(0).Rows
                            tbStokFiyati_ekle_yeni(dr_stok("nFiyatlandirma"), dr_stok("sModel"), dr_stok("sRenk"), dr_stok("sBeden"), dr_fiyat("sFiyatTipi"), dr_fiyat("lFiyat"), dr_fiyat("dteFiyatTespitTarihi"), dr_fiyat("sKullaniciAdi"))
                        Next
                        'sınıfları kaydet
                        stok_siniflari_kaydet_yeni(nStokID, dr_stok_sinif("sSinifKodu1"), dr_stok_sinif("sSinifKodu2"), dr_stok_sinif("sSinifKodu3"), dr_stok_sinif("sSinifKodu4"), dr_stok_sinif("sSinifKodu5"), dr_stok_sinif("sSinifKodu6"), dr_stok_sinif("sSinifKodu7"), dr_stok_sinif("sSinifKodu8"), dr_stok_sinif("sSinifKodu9"), dr_stok_sinif("sSinifKodu10"), dr_stok_sinif("sSinifKodu11"), dr_stok_sinif("sSinifKodu12"), dr_stok_sinif("sSinifKodu13"), dr_stok_sinif("sSinifKodu14"), dr_stok_sinif("sSinifKodu15"))
                        'Birim Cevrimi
                        Dim ds_tbStokBirimCevrimi As DataSet = sorgu(sorgu_query("Select * from tbStokBirimCevrimi Where nStokID IN (Select nStokID from tbStok where  sModel = '" & dr_stok("sModel") & "')"))
                        For Each drn In ds_tbStokBirimCevrimi.Tables(0).Rows
                            tbStokBirimCevrimi_kaydet_yeni(drn("sBirimCinsi"), drn("lOran"), dr_stok("sModel"))
                        Next
                    Else
                        nStokID = sorgu_nStokID(Trim(dr1("sKodu")))
                    End If
                    Try
                    Catch ex As Exception
                    End Try
                    'Kayda Başla
                    Try
                        nIslemID = tbStokFisidetay_kaydet_yeni(nIslemID, nStokID, dr1("dteIslemTarihi"), nFirmaID, dr1("nMusteriID"), dr1("sFisTipi"), dr1("dteFisTarihi"), dr1("lFisNo"), dr1("nGirisCikis"), dr1("sDepo"), dr1("lReyonFisNo"), dr1("sStokIslem"), dr1("sKasiyerRumuzu"), dr1("sSaticiRumuzu"), dr1("sOdemeKodu"), dr1("dteIrsaliyeTarihi"), dr1("lIrsaliyeNo"), dr1("lGirisMiktar1"), dr1("lGirisMiktar2"), dr1("lGirisFiyat"), dr1("lGirisTutar"), dr1("lCikisMiktar1"), dr1("lCikisMiktar2"), dr1("lCikisFiyat"), dr1("lCikisTutar"), dr1("sFiyatTipi"), "", 1, dr1("lBrutFiyat"), dr1("lBrutTutar"), dr1("lMaliyetFiyat"), dr1("lMaliyetTutar"), dr1("lIlaveMaliyetTutar"), dr1("nIskontoYuzdesi"), dr1("lIskontoTutari"), dr1("sDovizCinsi"), dr1("lDovizFiyat"), "", dr1("nReceteNo"), "", "", dr1("nKdvOrani"), dr1("nHesapID"), dr1("sAciklama"), dr1("sHareketTipi"), dr1("bMuhasebeyeIslendimi"), dr1("sKullaniciAdi"), dr1("dteKayitTarihi"), dr1("sDovizCinsi1").ToString, dr1("lDovizMiktari1"), dr1("lDovizKuru1"), dr1("sDovizCinsi2"), dr1("lDovizMiktari2"), dr1("lDovizKuru2"), dr1("nOTVOrani"), "", "", nStokFisiID, "", dr1("sMasrafYontemi"), dr1("sHangiUygulama"), dr1("nEksaha1"), dr1("nEkSaha2"), dr1("bEkSoru1"), dr1("bEkSoru2"), dr1("sSonKullaniciAdi"), dr1("dteSonUpdateTarihi"))
                        fis_detay_fisno_degistir(nIslemID)
                    Catch ex As Exception
                    End Try
                    ProgressBar2.EditValue += 1
                    ProgressBar2.Refresh()
                Next
                ProgressBar2.EditValue = 0
                ProgressBar2.Refresh()
            End If
            ProgressBar1.EditValue += 1
            Label2.Text = ProgressBar1.EditValue & "/" & dataset1.Tables(0).Rows.Count
            ProgressBar1.Refresh()
            Label2.Refresh()
        Next
    End Sub
    Private Function tbHesapPlani_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal sAlterneAciklama As String, ByVal lBilancoSatiri As Decimal, ByVal sAktifPasif As String, ByVal lKarZararSatiri As Decimal, ByVal sKarZararGelirGider As String, ByVal sMasrafYontemi As String, ByVal bMiktarVar As Integer, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nHesapID, 0) AS nHesapID  FROM         tbHesapPlani Where sKodu = '" & sKodu & "' ")
        Dim kayitno As String = cmd.ExecuteScalar
        If kayitno = "0" Or kayitno = "" Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbHesapPlani (sKodu, sAciklama, sAlterneAciklama, lBilancoSatiri, sAktifPasif, lKarZararSatiri, sKarZararGelirGider, sMasrafYontemi, bMiktarVar, sKullaniciAdi, dteKayitTarihi) VALUES     ('" & sKodu & "', N'" & sAciklama & "', '" & sAlterneAciklama & "', " & lBilancoSatiri & ", '" & sAktifPasif & "', " & lKarZararSatiri & ", '" & sKarZararGelirGider & "', '" & sMasrafYontemi & "', " & bMiktarVar & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
            kayitno = cmd.ExecuteScalar
        End If
        con.Close()
        Return kayitno
    End Function
    Private Function firma_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal nOzelIskontosu As Decimal, ByVal lKrediLimiti As Decimal, ByVal dteMutabakatTarihi As DateTime, ByVal nVadeGun As Int64, ByVal sHitap As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal nHesapID As Int64, ByVal sOzelNot As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sFiyatTipi As String) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
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
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaSinifi                       (nFirmaID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5) VALUES     ('" & nFirmaID & "', '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbFirmaIletisimi_kaydet_yeni(ByVal nFirmaID As String, ByVal sIletisimAraci As String, ByVal sIletisimAdresi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaIletisimi (nFirmaID, sIletisimAraci, sIletisimAdresi) VALUES     ('" & nFirmaID & "', '" & sIletisimAraci & "', '" & sIletisimAdresi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaYetkilisi_kaydet_yeni(ByVal nFirmaID As String, ByVal sUnvan As String, ByVal sHitap As String, ByVal sAdiSoyadi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaYetkilisi (nFirmaID, sUnvan, sHitap, sAdiSoyadi) VALUES     ('" & nFirmaID & "', '" & sUnvan & "', '" & sHitap & "', '" & sAdiSoyadi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_decimal(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        Try
            If deger.ToString = "" Then
                deger = sonuc
            End If
        Catch ex As Exception
            deger = sonuc
        End Try
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
    Private Sub stbFirmaHareketi_kaydet_yeni(ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        sHareketTipi = ""
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY  INSERT INTO tbFirmaHareketi                       (nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nFirmaID & "', '" & dteIslemTarihi & "', '" & dteValorTarihi & "', '" & sCariIslem & "', '" & sAciklama & "', " & lBorcTutar & ", " & lAlacakTutar & " , '" & sEvrakNo & "', " & lVadeFarki & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & " , '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & " , '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        sCmd.ExecuteNonQuery()
    End Sub
    Public Function sorgu_nCariHareketID_sql(Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        Dim kriter As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nHareketID + 1, 0) AS nCariHareketID  FROM         tbFirmaHareketi " & kriter & " ORDER BY nHareketID DESC")
        Dim kayitsayisi = sCmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub nCariHareketID_degistir_sql(ByVal nCariHareketID As String, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = '" & nCariHareketID & "' where nSiraIndex = 1")
        sCmd.ExecuteNonQuery()
    End Sub
    Private Function tbStokFisiMaster_kaydet_yeni(ByVal nStokFisiID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal nGirisCikis As Int64, ByVal lFisNo As Int64, ByVal nFirmaID As Int64, ByVal sDepo As String, ByVal dteValorTarihi As DateTime, ByVal bPesinmi As Byte, ByVal bListelendimi As Byte, ByVal bHizmetFaturasimi As Byte, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi1 As Decimal, ByVal lDipIskontoTutari1 As Decimal, ByVal nDipIskontoYuzdesi2 As Decimal, ByVal lDipIskontoTutari2 As Decimal, ByVal lDipIskontoTutari3 As Decimal, ByVal lEkmaliyet1 As Decimal, ByVal lEkmaliyet2 As Decimal, ByVal lEkmaliyet3 As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lNetTutar As Decimal, ByVal nTevkifatKdvOrani As Decimal, ByVal lTevkifatKdvMatrahi As Decimal, ByVal lTevkifatKdv As Decimal, ByVal sCariIslem As String, ByVal nCariHareketID As String, ByVal nKasaIslemID As String, ByVal sCariKdvIslem As String, ByVal nCariKdvHareketID As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal bFisTamamlandimi As Byte, ByVal lTransferFisiID As String, ByVal nTransferFirmaID As String, ByVal sTransferDepo As String, ByVal bFaturayaDonustumu As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sYaziIle As String, ByVal nOTVOrani1 As Decimal, ByVal lOTVMatrahi1 As Decimal, ByVal lOTV1 As Decimal, ByVal nOTVOrani2 As Decimal, ByVal lOTVMatrahi2 As Decimal, ByVal lOTV2 As Decimal, Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        sHareketTipi = ""
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sCariIslem, nCariHareketID, nKasaIslemID, sCariKdvIslem, nCariKdvHareketID, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID, nTransferFirmaID, sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " , '" & sCariIslem & "', '" & nCariHareketID & "', '" & nKasaIslemID & "', '" & sCariKdvIslem & "', '" & nCariKdvHareketID & "', '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "', '" & nTransferFirmaID & "', '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & ")")
        sCmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID,  sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " ,  '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "',  '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & ")")
        sCmd.ExecuteNonQuery()
        sCmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nStokFisiID = sCmd.ExecuteScalar
        Return nStokFisiID
    End Function
    Private Sub tbStokFisiAciklamasi_kaydet_yeni(ByVal nStokFisiID As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY INSERT INTO tbStokFisiAciklamasi                       (nStokFisiID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5) VALUES     ('" & nStokFisiID & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "')")
        Try
            sCmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
    End Sub
    Private Function tbStokFisidetay_kaydet_yeni(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal sBirimCinsi As String, ByVal lBirimMiktar As Decimal, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As Int64, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sHareketTipi = ""
        If nSiparisID <> "" Then
            sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi,lBirimMiktar,lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , '" & sBirimCinsi & "'," & lBirimMiktar & "," & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", " & nSiparisID & ", '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', '" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  NULL, '" & nStokFisiID & "', NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        Else
            If Trim(sFisTipi) = "IA" Or Trim(sFisTipi) = "IS" Then
                sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi,lBirimMiktar,lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' ,'" & sBirimCinsi & "'," & lBirimMiktar & ", " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', '" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  NULL, '" & nStokFisiID & "', '" & nStokFisiID & "', '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
            Else
                sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi,lBirimMiktar,lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' ,'" & sBirimCinsi & "'," & lBirimMiktar & ", " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', '" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  NULL, '" & nStokFisiID & "', NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
            End If
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nIslemID,nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     (" & nIslemID & " ,'" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', '" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  NULL, '" & nStokFisiID & "', NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        End If
        sCmd.ExecuteNonQuery()
        sCmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nIslemID = sCmd.ExecuteScalar

        Return nIslemID
    End Function
    Private Sub tbStokFisiOdemePlani_kaydet_yeni(ByVal nStokFisiID As String, ByVal dteVadeTarihi As DateTime, ByVal lTutari As Decimal, ByVal sCariIslem As String, ByVal nCariHareketID As String)
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbStokFisiOdemePlani                       (nStokFisiID, dteVadeTarihi, lTutari, sCariIslem, nCariHareketID) VALUES     ('" & nStokFisiID & "', '" & dteVadeTarihi & "', " & lTutari & ", '" & sCariIslem & "', '" & nCariHareketID & "')")
        sCmd.ExecuteNonQuery()
    End Sub
    Public Function sorgu_nCariHareketID() As Int64
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SELECT     MAX(nHareketID) + 1 AS nCariHareketID  FROM         tbFirmaHareketi ")
        Dim kayitsayisi = sorgu_sayi(sCmd.ExecuteScalar, 0)
        sCon.Close()
        Return kayitsayisi
    End Function
    Public Function sorgu_nStokFisiID(Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim kriter As String = ""
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nStokFisiID), 1) + 1 AS nStokFisiID FROM         tbStokFisiMaster")
        Dim kayitsayisi = sCmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_firma_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        'MsgBox(connection_resmi)
        con.ConnectionString = connection_resmi
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbFirma " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        con.Close()
        Return kayitsayisi
        cmd = Nothing
        con = Nothing
    End Function
    Public Function sorgu_fis_kontrol(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String, Optional ByVal resmi As Boolean = True, Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim kriter
        kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nStokFisiID, 0) AS KAYIT FROM         tbStokFisiMaster " & kriter & "")
        Dim kayitsayisi = sCmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_Bordro_kontrol(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteBordroTarihi As DateTime, ByVal lBordroNo As String, ByVal nFirmaID As String, ByVal sSaticiRumuzu As String, Optional ByVal resmi As Boolean = True, Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim kriter
        kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteBordroTarihi = '" & dteBordroTarihi & "') and (lBordroNo = '" & lBordroNo & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "') and sSaticiRumuzu ='" & sSaticiRumuzu & "' "

        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        conn.Open()
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nBordroID, 0) AS KAYIT FROM         tbFirmaBordroMaster " & kriter & "")
        Dim kayitsayisi = sCmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_Talep_kontrol(ByVal BELGETIPI As Int64, ByVal TARIH As DateTime, ByVal BELGENO As String, ByVal KAYITTARIHI As DateTime, Optional ByVal resmi As Boolean = True, Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim kriter
        kriter = "WHERE (BELGETIPI = '" & BELGETIPI & "') and (TARIH = '" & TARIH & "') and (BELGENO = '" & BELGENO & "') and (KAYITTARIHI= '" & KAYITTARIHI & "') "

        'Dim conn As New OleDb.OleDbConnection
        Dim sCmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        'conn.ConnectionString = connection_resmi
        sCmd.Connection = sCon
        'conn.Open()
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(IND, 0) AS KAYIT FROM         ASTOKETIKETTALEPBASLIK " & kriter & "")
        Dim kayitsayisi = sCmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub tbStokFisiMaster_lFisno_degistir(ByVal nstokFisiID As String, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = '" & nstokFisiID & "' where nSiraIndex = 2")
        sCmd.ExecuteNonQuery()
    End Sub
    Private Sub tbFirmaHareketi_nCariHareketID_degistir(ByVal nCariHareketID As String)
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = '" & nCariHareketID & "' where nSiraIndex = 1")
        sCmd.ExecuteNonQuery()
    End Sub
    Private Sub tbBordro_Oku(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sFisler As String, Optional ByVal nTalepID As String = "")
        'Dim dataset1 As New DataSet
        'Dim dataset2 As New DataSet
        Dim kriter As String = ""
        If nTalepID = "" Then
        Else
            kriter += " and tbFirmaBordroMaster.nBordroID = '" & nTalepID & "' "
        End If
        dataset1 = sorgu("SELECT     tbFirmaBordroMaster.*, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAdi, tbFirma.sVergiDairesi AS sVergiDairesi, tbFirma.sVergiNo AS sVergiNo FROM         tbFirmaBordroMaster LEFT OUTER JOIN                       tbFirma ON tbFirmaBordroMaster.nFirmaID = tbFirma.nFirmaID Where tbFirmaBordroMaster.sFisTipi IN (" & sFisler & ") and tbFirmaBordroMaster.dteBordroTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & "")
        dg.DataSource = dataset1.Tables(0)
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim dr_cari As DataRow
        Dim cari_kayit_sayisi As Integer = 0
        ProgressBar1.Properties.Maximum = dataset1.Tables(0).Rows.Count
        ProgressBar1.EditValue = 0
        If sCon.State = ConnectionState.Open = True Then
            sCon.Close()
        End If
        sCmd.Connection = sCon
        sCmd.CommandTimeout = Nothing
        sCon.ConnectionString = sConnection
        If sCon.State = ConnectionState.Closed = True Then
            sCon.Open()
        End If
        For Each dr In dataset1.Tables(0).Rows
            Dim nFirmaID As Int64 = sorgu_nfirmaID(dr("sFirmaKodu"))
            cari_kayit_sayisi = sorgu_firma_kontrol(dr("sFirmaKodu"))
            If cari_kayit_sayisi = 0 Then
                'MsgBox(dr_baslik("sKodu") & " Kodlu Firma Kaydı Bulunamadı",sDil), MessageBoxIcon.Warning)
                dataload_cari(dr("sFirmaKodu"))
                dr_cari = ds_firma.Tables(0).Rows(0)
                Dim nHesapID = tbHesapPlani_kaydet_yeni(dr_cari("sKodu"), dr_cari("sAciklama"), "", 0, "", 0, "", "", 0, kullanici, Now)
                nFirmaID = firma_kaydet_yeni(dr_cari("sKodu"), dr_cari("sAciklama"), dr_cari("nOzelIskontosu"), dr_cari("lKrediLimiti"), dr_cari("dteMutabakatTarihi"), dr_cari("nVadeGun"), dr_cari("sHitap"), dr_cari("sAdres1"), dr_cari("sAdres2"), dr_cari("sSemt"), dr_cari("sIl"), dr_cari("sUlke"), dr_cari("sPostaKodu"), dr_cari("sVergiDairesi"), dr_cari("sVergiNo"), nHesapID, dr_cari("sOzelNot"), dr_cari("sKullaniciAdi"), dr_cari("dteKayitTarihi"), dr_cari("sFiyatTipi"))
                Dim ds_tbFirmaIletisimi As DataSet = sorgu(sorgu_query("Select * from tbFirmaIletisimi Where nFirmaID = " & dr_cari("nFirmaID") & ""))
                For Each dr_cari In ds_tbFirmaIletisimi.Tables(0).Rows
                    tbFirmaIletisimi_kaydet_yeni(nFirmaID, dr_cari("sIletisimAraci"), dr_cari("sIletisimAdresi"))
                Next
                ds_tbFirmaIletisimi.Dispose()
                ds_tbFirmaIletisimi = Nothing
                Dim ds_tbFirmaYetkilisi As DataSet = sorgu(sorgu_query("Select * from tbFirmaYetkilisi Where nFirmaID = " & dr_cari("nFirmaID") & ""))
                For Each dr_cari In ds_tbFirmaYetkilisi.Tables(0).Rows
                    tbFirmaYetkilisi_kaydet_yeni(nFirmaID, dr_cari("sUnvan"), dr_cari("sHitap"), dr_cari("sAdiSoyadi"))
                Next
                ds_tbFirmaYetkilisi.Dispose()
                ds_tbFirmaYetkilisi = Nothing
            End If
            nFirmaID = sorgu_nfirmaID(dr("sFirmaKodu"))
            If sorgu_Bordro_kontrol(dr("sFisTipi"), dr("nGirisCikis"), dr("dteBordroTarihi"), dr("lBordroNo"), nFirmaID, dr("sSaticiRumuzu")) = 0 Then
                dr("nFirmaID") = nFirmaID
                Dim nBordroID As Int64 = tbFirmaBordroMaster_kaydet_yeni(dr("dteBordroTarihi"), dr("lBordroNo"), dr("sFisTipi"), dr("nGirisCikis"), dr("sSaticiRumuzu"), dr("nFirmaID"), dr("sAciklama1"), dr("sAciklama2"), dr("sAciklama3"), dr("sAciklama4"), dr("sAciklama5"), dr("sKullanici"), dr("dteKayitTarihi"), dr("bKilitli"))
                dataset2 = sorgu("SELECT     tbFirmaBordroDetay.*, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbFirma.sVergiDairesi AS sVergiDairesi,tbFirma.sVergiNo AS sVergiNo FROM         tbFirmaBordroDetay LEFT OUTER JOIN                       tbFirma ON tbFirmaBordroDetay.nFirmaID = tbFirma.nFirmaID Where tbFirmaBordroDetay.nBordroID =" & dr("nBordroID") & " ")
                ProgressBar2.Properties.Maximum = dataset2.Tables(0).Rows.Count
                ProgressBar2.EditValue = 0
                nSatir = 0
                For Each dr1 In dataset2.Tables(0).Rows
                    Dim nCariHareketID As Int64 = sorgu_nCariHareketID_sql()
                    cari_kayit_sayisi = sorgu_firma_kontrol(dr1("sFirmaKodu"))
                    If cari_kayit_sayisi = 0 Then
                        'MsgBox(dr_baslik("sKodu") & " Kodlu Firma Kaydı Bulunamadı",sDil), MessageBoxIcon.Warning)
                        dataload_cari(dr1("sFirmaKodu"))
                        dr_cari = ds_firma.Tables(0).Rows(0)
                        Dim nHesapID = tbHesapPlani_kaydet_yeni(dr_cari("sKodu"), dr_cari("sAciklama"), "", 0, "", 0, "", "", 0, kullanici, Now)
                        nFirmaID = firma_kaydet_yeni(dr_cari("sKodu"), dr_cari("sAciklama"), dr_cari("nOzelIskontosu"), dr_cari("lKrediLimiti"), dr_cari("dteMutabakatTarihi"), dr_cari("nVadeGun"), dr_cari("sHitap"), dr_cari("sAdres1"), dr_cari("sAdres2"), dr_cari("sSemt"), dr_cari("sIl"), dr_cari("sUlke"), dr_cari("sPostaKodu"), dr_cari("sVergiDairesi"), dr_cari("sVergiNo"), nHesapID, dr_cari("sOzelNot"), dr_cari("sKullaniciAdi"), dr_cari("dteKayitTarihi"), dr_cari("sFiyatTipi"))
                        firma_siniflari_kaydet_yeni(nFirmaID, "", "", "", "", "")
                        Dim ds_tbFirmaIletisimi As DataSet = sorgu(sorgu_query("Select * from tbFirmaIletisimi Where nFirmaID = " & dr_cari("nFirmaID") & ""))
                        For Each dr_cari In ds_tbFirmaIletisimi.Tables(0).Rows
                            tbFirmaIletisimi_kaydet_yeni(nFirmaID, dr_cari("sIletisimAraci"), dr_cari("sIletisimAdresi"))
                        Next
                        ds_tbFirmaIletisimi.Dispose()
                        ds_tbFirmaIletisimi = Nothing
                        Dim ds_tbFirmaYetkilisi As DataSet = sorgu(sorgu_query("Select * from tbFirmaYetkilisi Where nFirmaID = " & dr_cari("nFirmaID") & ""))
                        For Each dr_cari In ds_tbFirmaYetkilisi.Tables(0).Rows
                            tbFirmaYetkilisi_kaydet_yeni(nFirmaID, dr_cari("sUnvan"), dr_cari("sHitap"), dr_cari("sAdiSoyadi"))
                        Next
                        ds_tbFirmaYetkilisi.Dispose()
                        ds_tbFirmaYetkilisi = Nothing
                    End If
                    nFirmaID = sorgu_nfirmaID(dr1("sFirmaKodu"))
                    dr1("nBordroID") = nBordroID
                    dr1("nFirmaID") = nFirmaID
                    dr1("nHareketID") = nCariHareketID
                    dr1("nKasaIslemID") = ""
                    dr1("nBordroSatirID") = ""
                    Dim nKayitID As Int64 = tbFirmaBordroDetay_kaydet_yeni(0, nBordroID, nCariHareketID, dr1("nKasaIslemID").ToString, dr1("nBordroSatirID").ToString, dr1("nFirmaID"), dr1("dteIslemTarihi"), dr1("dteIslemTarihi"), "", dr1("sAciklama"), dr1("lBorcTutar"), dr1("lAlacakTutar"), dr1("sEvrakNo").ToString, dr1("lVadeFarki"), dr1("sHangiUygulama").ToString, dr1("sHareketTipi").ToString, dr1("sKullaniciAdi").ToString, dr1("dteKayitTarihi"), dr1("sDovizCinsi1").ToString, dr1("lDovizMiktari1"), dr1("lDovizKuru1"), dr1("sDovizCinsi2").ToString, dr1("lDovizMiktari2"), dr1("lDovizKuru2"), dr1("sKullaniciAdi").ToString, dr1("dteSonUpdateTarihi"))
                    dr1("nKayitID") = nKayitID
                    stbFirmaHareketi_kaydet_yeni(nCariHareketID, dr1("nFirmaID"), dr1("dteIslemTarihi"), dr1("dteIslemTarihi"), "", dr1("sAciklama"), dr1("lBorcTutar"), dr1("lAlacakTutar"), dr1("sEvrakNo"), dr1("lVadeFarki"), dr1("sHangiUygulama"), dr1("sHareketTipi"), dr1("sKullaniciAdi"), dr1("dteKayitTarihi"), dr1("sDovizCinsi1"), dr1("lDovizMiktari1"), dr1("lDovizKuru1"), dr1("sDovizCinsi2"), dr1("lDovizMiktari2"), dr1("lDovizKuru2"), dr1("sKullaniciAdi"), dr1("dteSonUpdateTarihi"))
                    nCariHareketID_degistir_sql(nCariHareketID)
                    If Trim(dr1("sCariIslem")) = "N" Then
                        Dim bPesinmi As Boolean = False
                        If Trim(dr1("sCariIslem")) = "N" Then
                            bPesinmi = True
                        End If
                        If bPesinmi = False Then
                            If dr1("nKasaIslemID").ToString <> "" Then
                                tbNakitKasa_kaydet_sil(dr1("nKasaIslemID").ToString, 0)
                                dr1("nKasaIslemID") = ""
                            End If
                        End If
                        If dr1("nKasaIslemID").ToString = "" Then
                            If bPesinmi = True Then
                                dr1("nKasaIslemID") = tbFirmaHarekets_kaydet_yeni(nCariHareketID, dr1("nFirmaID"), dr("dteBordroTarihi"), dr("dteBordroTarihi"), "N", "Tahsilat :" & dr("lBordroNo") & " - " & Microsoft.VisualBasic.Left(Trim(dr1("sAciklama").ToString), 20), dr1("lBorcTutar"), dr1("lAlacakTutar"), dr("lBordroNo"), 0, dr("sFisTipi"), "", dr("sKullanici"), Now, dr1("sDovizCinsi1"), dr1("lDovizMiktari1"), dr1("lDovizKuru1"), dr1("sDovizCinsi2"), dr1("lDovizMiktari2"), dr1("lDovizKuru2"), dr("sKullanici"), Now, bPesinmi, 0)
                            ElseIf bPesinmi = False Then
                                If dr1("nKasaIslemID").ToString <> "" Then
                                    tbNakitKasa_kaydet_sil(dr1("nKasaIslemID").ToString, 0)
                                    dr1("nKasaIslemID") = ""
                                End If
                                tbFirmaHareket_kaydet_yeni(nCariHareketID, dr1("nFirmaID"), dr("dteBordroTarihi"), dr("dteBordroTarihi"), dr1("sOdemeSekli"), "Tahsilat :" & dr("lBordroNo") & " - " & Microsoft.VisualBasic.Left(Trim(dr1("sAciklama").ToString), 20), dr1("lBorcTutar"), dr1("lAlacakTutar"), dr("lBordroNo"), 0, "", "", dr("sKullanici"), Now, "", 0, 0, "", 0, 0, dr("sKullanici"), Now)
                                dr1("nKasaIslemID") = ""
                            End If
                        Else
                            If bPesinmi = True Then
                                tbFirmaHarekets_kaydet_duzelt("", dr1("nKasaIslemID"), dr1("nFirmaID"), dr("dteBordroTarihi"), dr("dteBordroTarihi"), "N", "Tahsilat :" & dr("lBordroNo") & " - " & Microsoft.VisualBasic.Left(Trim(dr1("sAciklama").ToString), 20), dr1("lBorcTutar"), dr1("lAlacakTutar"), dr("lBordroNo"), 0, "", "", dr("sKullanici"), Today, dr1("sDovizCinsi1"), dr1("lDovizMiktari1"), dr1("lDovizKuru1"), dr1("sDovizCinsi2"), dr1("lDovizMiktari2"), dr1("lDovizKuru2"), dr("sKullanici"), Now, bPesinmi, dr1("nKasaIslemID").ToString)
                            ElseIf bPesinmi = False Then
                                tbFirmaHareket_kaydet_duzelt(dr1("nKasaIslemID"), dr1("nFirmaID"), dr("dteBordroTarihi"), dr("dteBordroTarihi"), dr1("sOdemeSekli"), "Tahsilat :" & dr("lBordroNo") & " - " & Microsoft.VisualBasic.Left(Trim(dr1("sAciklama").ToString), 20), dr1("lBorcTutar"), dr1("lAlacakTutar"), dr("lBordroNo"), 0, "", "", dr("sKullanici"), Today, "", 0, 0, "", 0, 0, dr("sKullanici"), Now)
                            End If
                        End If
                    Else
                        'Nakit Kasadan Sil
                        If Trim(dr1("sCariIslem")) = "PCT" Or Trim(dr1("sCariIslem")) = "PST" Then
                        Else
                            If dr1("nKasaIslemID").ToString <> "" Then
                                tbNakitKasa_kaydet_sil(dr1("nKasaIslemID").ToString, 0)
                                dr1("nKasaIslemID") = ""
                            End If
                        End If
                    End If
                    If dr1("nKasaIslemID").ToString <> "" Then
                        If Trim(dr1("sCariIslem")) = "PCT" Or Trim(dr1("sCariIslem")) = "PST" Then
                        Else
                            dr1("sHangiUygulama") = dr("sFisTipi")
                        End If
                    Else
                        dr1("sHangiUygulama") = dr("sFisTipi")
                    End If
                    'Çek/Senet Kontrolü
                    If Trim(dr1("sCariIslem").ToString) = "AC" Or Trim(dr1("sCariIslem").ToString) = "AS" Then
                        If dr1("nBordroSatirID").ToString = "" Then
                            Dim nCekSenetIslem = 1
                            tbCekSenetBodrdro_ekle(dr1("sCariIslem"), nCekSenetIslem, dr1("nFirmaID"), dr1("nHareketID"))
                        Else
                            tbCekSenetBordro_degistir(dr1("nBordroSatirID"))
                        End If
                    ElseIf Trim(dr1("sCariIslem").ToString) = "BC" Or Trim(dr1("sCariIslem").ToString) = "BS" Then
                        If dr1("nBordroSatirID").ToString = "" Then
                            Dim nCekSenetIslem = 20
                            tbCekSenetBodrdro_ekle(dr1("sCariIslem"), nCekSenetIslem, dr1("nFirmaID"), dr1("nHareketID"))
                            nCekSenetIslem = Nothing
                        Else
                            tbCekSenetBordro_degistir(dr1("nBordroSatirID"))
                        End If
                    Else
                        If dr1("nBordroSatirID").ToString <> "" Then
                            If Trim(dr1("sCariIslem")) = "PCT" Or Trim(dr1("sCariIslem")) = "PST" Then
                            Else
                                tbCekSenetBordro_sil(dr1("nBordroSatirID"))
                            End If
                        End If
                    End If
                    If dr1("nBordroSatirID").ToString <> "" Then
                        If Trim(dr1("sCariIslem")) = "PCT" Then
                            dr1("sHangiUygulama") = "AC"
                        ElseIf Trim(dr1("sCariIslem")) = "PST" Then
                            dr1("sHangiUygulama") = "AS"
                        Else
                            dr1("sHangiUygulama") = dr1("sCariIslem")
                        End If
                    Else
                        dr1("sEvrakNo") = dr("lBordroNo")
                        'dr1("sHangiUygulama") = ""
                    End If
                    ''Parçalı Tahsilat Kontrolü
                    'If Trim(dr1("sCariIslem")) = "PCT" Or Trim(dr1("sCariIslem")) = "PST" Then
                    '    If dr1("nBordroSatirID").ToString = "" Then
                    '        satir_ekle_ParcaliTahsilat()
                    '    Else
                    '        tbCekSenetBordro_degistir(dr1("nBordroSatirID"), 11)
                    '        tbNakitKasa_kaydet_duzelt(dr1("nKasaIslemID"), "001", dr("dteBordroTarihi"), dr1("lAlacakTutar"), dr1("lBorcTutar"), dr1("sAciklama"), "", dr1("nFirmaID"), 0, dr1("sHangiUygulama"), dr1("sHareketTipi"), dr1("sKullaniciAdi"), dr1("dteKayitTarihi"), 0, "", dr1("sDovizCinsi1"), dr1("lDovizMiktari1"), dr1("lDovizKuru1"), dr1("sDovizCinsi2"), dr1("lDovizMiktari2"), dr1("lDovizKuru2"), dr1("sSonKullaniciAdi"), dr1("dteSonUpdateTarihi"), 11)
                    '    End If
                    'Else
                    '    If dr1("nBordroSatirID").ToString <> "" Then
                    '        If Trim(dr1("sCariIslem").ToString) = "AC" Or Trim(dr1("sCariIslem").ToString) = "AS" Or Trim(dr1("sCariIslem").ToString) = "BC" Or Trim(dr1("sCariIslem").ToString) = "BS" Then
                    '        Else
                    '            tbCekSenetBordro_parcalitahsilat_kaydet_sil(dr1("nBordroSatirID"), dr1("nKasaIslemID"))
                    '        End If
                    '    End If
                    'End If
                    If Trim(dr1("sCariIslem")) = "PCT" Or Trim(dr1("sCariIslem")) = "PST" Then
                        tbFirmaBordroDetay_kaydet_duzelt(dr1("nKayitID"), dr1("nBordroID"), dr1("nHareketID"), dr1("nKasaIslemID"), dr1("nBordroSatirID"), dr1("nFirmaID"), dr1("dteIslemTarihi"), dr1("dteValorTarihi"), dr1("sCariIslem"), dr1("sAciklama").ToString, dr1("lBorcTutar"), dr1("lAlacakTutar"), dr1("sEvrakNo"), dr1("lVadeFarki"), dr1("sHangiUygulama").ToString, dr1("sHareketTipi").ToString, dr1("sKullaniciAdi").ToString, dr1("dteKayitTarihi"), dr1("sDovizCinsi1"), dr1("lDovizMiktari1"), dr1("lDovizKuru1"), dr1("sDovizCinsi1"), dr1("lDovizMiktari2"), dr1("lDovizKuru2"), dr("sKullanici"), Now)
                        If dr1("nHareketID") <> "" Then
                            tbFirmaHareketi_kaydet_sil("nHareketID")
                            dr1("nHareketID") = ""
                        End If
                        'tbFirmaHareketi_kaydet_duzelt(dr1("nHareketID"), dr1("nFirmaID"), dr1("dteIslemTarihi"), dr1("dteValorTarihi"), dr1("sCariIslem"), dr1("sAciklama").ToString, dr1("lBorcTutar"), dr1("lAlacakTutar"), dr1("sEvrakNo"), dr1("lVadeFarki"), dr1("sHangiUygulama").ToString, dr1("sHareketTipi").ToString, dr1("sKullaniciAdi").ToString, dr1("dteKayitTarihi"), dr1("sDovizCinsi1"), dr1("lDovizMiktari1"), dr1("lDovizKuru1"), dr1("sDovizCinsi1"), dr1("lDovizMiktari2"), dr1("lDovizKuru2"), kullanici, Now)
                    Else
                        If dr1("nHareketID") = "" Then
                            nCariHareketID = sorgu_nCariHareketID()
                            stbFirmaHareketi_kaydet_yeni(nCariHareketID, dr1("nFirmaID"), dr1("dteIslemTarihi"), dr1("dteValorTarihi"), dr1("sCariIslem"), dr1("sAciklama").ToString, dr1("lBorcTutar"), dr1("lAlacakTutar"), dr1("sEvrakNo"), dr1("lVadeFarki"), dr1("sHangiUygulama").ToString, dr1("sHareketTipi").ToString, dr1("sKullaniciAdi").ToString, dr1("dteKayitTarihi"), dr1("sDovizCinsi1"), dr1("lDovizMiktari1"), dr1("lDovizKuru1"), dr1("sDovizCinsi1"), dr1("lDovizMiktari2"), dr1("lDovizKuru2"), dr("sKullanici"), Now)
                            nCariHareketID_degistir_sql(nCariHareketID)
                            dr1("nHareketID") = nCariHareketID
                            nCariHareketID = Nothing
                        End If
                        tbFirmaBordroDetay_kaydet_duzelt(dr1("nKayitID"), dr1("nBordroID"), dr1("nHareketID"), dr1("nKasaIslemID"), dr1("nBordroSatirID"), dr1("nFirmaID"), dr1("dteIslemTarihi"), dr1("dteValorTarihi"), dr1("sCariIslem"), dr1("sAciklama").ToString, dr1("lBorcTutar"), dr1("lAlacakTutar"), dr1("sEvrakNo"), dr1("lVadeFarki"), dr1("sHangiUygulama").ToString, dr1("sHareketTipi").ToString, dr1("sKullaniciAdi").ToString, dr1("dteKayitTarihi"), dr1("sDovizCinsi1"), dr1("lDovizMiktari1"), dr1("lDovizKuru1"), dr1("sDovizCinsi1"), dr1("lDovizMiktari2"), dr1("lDovizKuru2"), dr("sKullanici"), Now)
                        tbFirmaHareketi_kaydet_duzelt(dr1("nHareketID"), dr1("nFirmaID"), dr1("dteIslemTarihi"), dr1("dteValorTarihi"), dr1("sCariIslem"), dr1("sAciklama").ToString, dr1("lBorcTutar"), dr1("lAlacakTutar"), dr1("sEvrakNo"), dr1("lVadeFarki"), dr1("sHangiUygulama").ToString, dr1("sHareketTipi").ToString, dr1("sKullaniciAdi").ToString, dr1("dteKayitTarihi"), dr1("sDovizCinsi1"), dr1("lDovizMiktari1"), dr1("lDovizKuru1"), dr1("sDovizCinsi1"), dr1("lDovizMiktari2"), dr1("lDovizKuru2"), dr("sKullanici"), Now)
                    End If
                    ProgressBar2.EditValue += 1
                    ProgressBar2.Refresh()
                    nSatir += 1
                Next
                ProgressBar2.EditValue = 0
                ProgressBar2.Refresh()
            End If
            ProgressBar1.EditValue += 1
            Label2.Text = ProgressBar1.EditValue & "/" & dataset1.Tables(0).Rows.Count
            ProgressBar1.Refresh()
            Label2.Refresh()
        Next
    End Sub
    Private Function tbFirmaBordroMaster_kaydet_yeni(ByVal dteBordroTarihi As DateTime, ByVal lBordroNo As Int64, ByVal sFisTipi As String, ByVal nGirisCikis As Integer, ByVal sSaticiRumuzu As String, ByVal nFirmaID As Integer, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal sKullanici As String, ByVal dteKayitTarihi As DateTime, ByVal bKilitli As Byte)
        Dim nKayitNo As Integer = 0
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaBordroMaster (dteBordroTarihi, lBordroNo, sFisTipi, nGirisCikis, sSaticiRumuzu, nFirmaID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, sKullanici,  dteKayitTarihi,bKilitli) VALUES     ('" & dteBordroTarihi & "', " & lBordroNo & ", '" & sFisTipi & "', " & nGirisCikis & ", '" & sSaticiRumuzu & "', " & nFirmaID & ", '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "', '" & sKullanici & "', '" & dteKayitTarihi & "'," & bKilitli & ")")
        sCmd.ExecuteNonQuery()
        sCmd.CommandText = "select @@identity"
        nKayitNo = sCmd.ExecuteScalar
        Return nKayitNo
    End Function
    Private Sub tbFirmaBordroMaster_kaydet_duzelt(ByVal nBordroID As Int64, ByVal dteBordroTarihi As DateTime, ByVal lBordroNo As Int64, ByVal sFisTipi As String, ByVal nGirisCikis As Integer, ByVal sSaticiRumuzu As String, ByVal nFirmaID As Integer, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal sKullanici As String, ByVal dteKayitTarihi As DateTime, ByVal bKilitli As Byte)
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbFirmaBordroMaster SET              dteBordroTarihi = '" & dteBordroTarihi & "', lBordroNo = " & lBordroNo & ", sFisTipi = '" & sFisTipi & "', nGirisCikis = " & nGirisCikis & ", sSaticiRumuzu = '" & sSaticiRumuzu & "', nFirmaID = " & nFirmaID & ", sAciklama1 = '" & sAciklama1 & "', sAciklama2 = '" & sAciklama2 & "', sAciklama3 = '" & sAciklama3 & "', sAciklama4 = '" & sAciklama4 & "', sAciklama5 = '" & sAciklama5 & "',bKilitli = " & bKilitli & "  Where nBordroID = " & nBordroID & "")
        sCmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaBordroMaster_kaydet_Sil(ByVal nBordroID As Int64)
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFirmaBordroMaster  Where nBordroID = " & nBordroID & "")
        sCmd.ExecuteNonQuery()
    End Sub
    Private Function tbFirmaBordroDetay_kaydet_yeni(ByVal nKayitID As Int64, ByVal nBordroID As Int64, ByVal nHareketID As String, ByVal nKasaIslemID As String, ByVal nBordroSatirID As String, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim nKayitNo As Int64 = 0
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbFirmaBordroDetay                       (nBordroID,nHareketID,nKasaIslemID,nBordroSatirID,nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     (" & nBordroID & ",'" & nHareketID & "' ,'" & nKasaIslemID & "','" & nBordroSatirID & "','" & nFirmaID & "', '" & dteIslemTarihi & "', '" & dteValorTarihi & "', '" & sCariIslem & "', '" & sAciklama & "', " & lBorcTutar & ", " & lAlacakTutar & " , '" & sEvrakNo & "', " & lVadeFarki & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & " , '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & " , '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        sCmd.ExecuteNonQuery()
        sCmd.CommandText = "select @@identity"
        nKayitNo = sCmd.ExecuteScalar
        Return nKayitNo
    End Function
    Private Sub tbFirmaBordroDetay_kaydet_duzelt(ByVal nKayitID As Int64, ByVal nBordroID As Int64, ByVal nHareketID As String, ByVal nKasaIslemID As String, ByVal nBordroSatirID As String, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime)
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbFirmaBordroDetay SET              nKasaIslemID = '" & nKasaIslemID & "' ,nBordroSatirID ='" & nBordroSatirID & "',nFirmaID = '" & nFirmaID & "', dteIslemTarihi = '" & dteIslemTarihi & "', dteValorTarihi = '" & dteValorTarihi & "', sCariIslem = '" & sCariIslem & "', sAciklama = '" & sAciklama & "', lBorcTutar = " & lBorcTutar & ", lAlacakTutar = " & lAlacakTutar & ", sEvrakNo = '" & sEvrakNo & "', lVadeFarki = " & lVadeFarki & ", sHangiUygulama = '" & sHangiUygulama & "', sHareketTipi = '" & sHareketTipi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "'  WHERE     (nKayitID = " & nKayitID & ") AND nBordroID =" & nBordroID & "")
        sCmd.ExecuteNonQuery()
    End Sub
    Private Sub tbFirmaHareketi_kaydet_duzelt(ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime)
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        If Trim(sCariIslem) = "" Then
            sHangiUygulama = sHangiUygulama
        End If
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = '" & nFirmaID & "', dteIslemTarihi = '" & dteIslemTarihi & "', dteValorTarihi = '" & dteValorTarihi & "', sCariIslem = '" & sCariIslem & "', sAciklama = '" & sAciklama & "', lBorcTutar = " & lBorcTutar & ", lAlacakTutar = " & lAlacakTutar & ", sEvrakNo = '" & sEvrakNo & "', lVadeFarki = " & lVadeFarki & ", sHangiUygulama = '" & sHangiUygulama & "', sHareketTipi = '" & sHareketTipi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "'  WHERE     (nHareketID = " & nHareketID & ")")
        sCmd.ExecuteNonQuery()
    End Sub
    Private Sub tbFirmaHareketi_kaydet_sil(ByVal nHareketID As String)
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("set implicit_transactions on")
        sCmd.ExecuteNonQuery()
        Try
            sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
            sCmd.ExecuteNonQuery()
            sCmd.CommandText = sorgu_query("DELETE FROM tbFirmaHareketi Where nHareketID = '" & nHareketID & "'")
            sCmd.ExecuteNonQuery()
            sCmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            sCmd.ExecuteNonQuery()
        Catch ex As Exception
            sCmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            sCmd.ExecuteNonQuery()
            XtraMessageBox.Show("İşlem Hatası Lütfen Tekrar Deneyiniz...")
        End Try
        sCmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCariSiraNo SET nSonID = (SELECT TOP 1 ISNULL(nHareketID + 1 , 1) AS nSonID FROM tbFirmaHareketi ORDER BY nHareketID DESC) WHERE (nSiraIndex = 1)")
        sCmd.ExecuteNonQuery()
    End Sub
    Private Sub nKasaIslemID_degistir(ByVal nKasaIslemID As String)
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = '" & nKasaIslemID & "' where nSiraIndex = 2")
        sCmd.ExecuteNonQuery()
    End Sub
    Private Function tbNakitKasa_kaydet_yeni(ByVal nKasaIslemID As Int64, ByVal sSube As String, ByVal dteIslemTarihi As DateTime, ByVal lTahsilTutar As Decimal, ByVal lTediyeTutar As Decimal, ByVal sAciklama As String, ByVal nCariHareketID As String, ByVal nFirmaID As Int64, ByVal nHesapID As Int64, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bMuhasebeyeIslendimi As Byte, ByVal sMasrafYontemi As String, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, Optional ByVal nCekSenetIslem As Integer = 1) As Int64
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        If nCekSenetIslem = 11 Then
            nCariHareketID = "NULL"
        End If
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbNakitKasa ( sSube, dteIslemTarihi, lTahsilTutar, lTediyeTutar, sAciklama, nCariHareketID, nFirmaID, nHesapID, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, bMuhasebeyeIslendimi, sMasrafYontemi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ( '" & sSube & "', '" & dteIslemTarihi & "', " & lTahsilTutar & ", " & lTediyeTutar & ", '" & sAciklama & "', " & nCariHareketID & ", " & nFirmaID & ", " & nHesapID & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bMuhasebeyeIslendimi & ", '" & sMasrafYontemi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        sCmd.ExecuteNonQuery()
        sCmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nKasaIslemID = sCmd.ExecuteScalar
        Return nKasaIslemID
    End Function
    Private Sub tbNakitKasa_kaydet_duzelt(ByVal nKasaIslemID As Int64, ByVal sSube As String, ByVal dteIslemTarihi As DateTime, ByVal lTahsilTutar As Decimal, ByVal lTediyeTutar As Decimal, ByVal sAciklama As String, ByVal nCariHareketID As String, ByVal nFirmaID As Int64, ByVal nHesapID As Int64, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bMuhasebeyeIslendimi As Byte, ByVal sMasrafYontemi As String, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, Optional ByVal nCekSenetIslem As Integer = 1)
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        If nCekSenetIslem = 11 Then
            nCariHareketID = "NULL"
        End If
        If sHangiUygulama = "PCT" Then
            sHangiUygulama = "AC"
        ElseIf sHangiUygulama = "PST" Then
            sHangiUygulama = "AS"
        End If
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbNakitKasa SET              lTahsilTutar = " & lTahsilTutar & ", lTediyeTutar = " & lTediyeTutar & ", sAciklama = '" & sAciklama & "', sHareketTipi = '" & sHareketTipi & "', sHangiUygulama = '" & sHangiUygulama & "',bMuhasebeyeIslendimi = " & bMuhasebeyeIslendimi & ", sMasrafYontemi = '" & sMasrafYontemi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "',dteIslemTarihi ='" & dteIslemTarihi & "' Where nKasaIslemID  ='" & nKasaIslemID & "'")
        sCmd.ExecuteNonQuery()
    End Sub
    Private Sub tbNakitKasa_kaydet_sil(ByVal nKasaIslemID As String, ByVal nCariHareketID As String)
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select TOP 1 ISNULL(nCariHareketID,0) From tbNakitKasa Where nKasaIslemID = '" & nKasaIslemID & "' ")
        nCariHareketID = sCmd.ExecuteScalar
        sCmd.CommandText = sorgu_query("set implicit_transactions on")
        sCmd.ExecuteNonQuery()
        Try
            sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
            sCmd.ExecuteNonQuery()
            sCmd.CommandText = sorgu_query("DELETE FROM tbNakitKasa Where nKasaIslemID = '" & nKasaIslemID & "'")
            sCmd.ExecuteNonQuery()
            If nCariHareketID > 0 Then
                'cmd.CommandText = sorgu_query("DELETE FROM tbFirmaHareketi Where nHareketID = '" & nCariHareketID & "'")
                'cmd.ExecuteNonQuery()
            End If
            sCmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            sCmd.ExecuteNonQuery()
        Catch ex As Exception
            sCmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            sCmd.ExecuteNonQuery()
            XtraMessageBox.Show("İşlem Hatası Lütfen Tekrar Deneyiniz...")
        End Try
        sCmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCariSiraNo SET nSonID = (SELECT TOP 1 ISNULL(nHareketID + 1 , 1) AS nSonID FROM tbFirmaHareketi ORDER BY nHareketID DESC) WHERE (nSiraIndex = 1)")
        sCmd.ExecuteNonQuery()
    End Sub
    Private Function tbFirmaHarekets_kaydet_yeni(ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, ByVal bPesinmi As Boolean, Optional ByVal nKasaIslemID As String = "0") As Int64
        If bPesinmi = True Then
            Dim dr As DataRow
            dr = dataset2.Tables(0).Rows(nSatir)
            'nKasaIslemID = sorgu_nKasaIslemID()
            nKasaIslemID = tbNakitKasa_kaydet_yeni(nKasaIslemID, sSubeMagaza, dteIslemTarihi, lAlacakTutar, lBorcTutar, "Tahsilat No :" & sEvrakNo & " - " & Microsoft.VisualBasic.Left(Trim(sAciklama.ToString), 20), nHareketID, nFirmaID, 0, sHangiUygulama, sHareketTipi, sKullaniciAdi, Now, 0, "", sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sKullaniciAdi, Now)
            'nKasaIslemID_degistir(nKasaIslemID)
            dr("nKasaIslemID") = nKasaIslemID.ToString
        End If
        Return nKasaIslemID
    End Function
    Private Sub tbFirmaHarekets_kaydet_duzelt(ByVal nStokFisiID As String, ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, ByVal bPesinmi As Boolean, Optional ByVal nKasaIslemID As String = "0")
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = '" & nFirmaID & "', dteIslemTarihi = '" & dteIslemTarihi & "', dteValorTarihi = '" & dteValorTarihi & "', sCariIslem = '" & sCariIslem & "', sAciklama = 'Evrak No: " & sEvrakNo & "', lBorcTutar = " & lBorcTutar & ", lAlacakTutar = " & lAlacakTutar & ", sEvrakNo = '" & sEvrakNo & "', lVadeFarki = " & lVadeFarki & ", sHangiUygulama = '" & sHangiUygulama & "', sHareketTipi = '" & sHareketTipi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "'  WHERE     (nHareketID IN  (SELECT     nCariHareketID FROM          tbStokFisiOdemePlani WHERE      (nStokFisiID = '" & nStokFisiID & "' )))")
        'cmd.ExecuteNonQuery()
        If bPesinmi = True Then
            If nKasaIslemID <> "" Then
                tbNakitKasa_kaydet_duzelt(nKasaIslemID, "001", dteIslemTarihi, lAlacakTutar, lBorcTutar, "Tahsilat No :" & sEvrakNo & " - " & Microsoft.VisualBasic.Left(Trim(sAciklama.ToString), 20), nHareketID, nFirmaID, 0, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, 0, "", sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sKullaniciAdi, Now)
                sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = '" & nFirmaID & "', dteIslemTarihi = '" & dteIslemTarihi & "', dteValorTarihi = '" & dteValorTarihi & "', sCariIslem = 'N', sAciklama = '" & "Tahsilat :" & sEvrakNo & " - " & Microsoft.VisualBasic.Left(Trim(sAciklama), 20) & "', lBorcTutar = " & lBorcTutar & ", lAlacakTutar = " & lAlacakTutar & ", sEvrakNo = '" & sEvrakNo & "', lVadeFarki = " & lVadeFarki & ", sHangiUygulama = '" & sHangiUygulama & "', sHareketTipi = '" & sHareketTipi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "'  WHERE     (nHareketID IN  (SELECT     nCariHareketID FROM          tbNakitKasa WHERE      (nKasaIslemID = '" & nKasaIslemID & "' )))")
                sCmd.ExecuteNonQuery()
            End If
        End If
    End Sub
    Private Sub tbFirmaHareket_kaydet_yeni(ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime)
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbFirmaHareketi                       (nHareketID,nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     (" & nHareketID & " ,'" & nFirmaID & "', '" & dteIslemTarihi & "', '" & dteValorTarihi & "', '" & sCariIslem & "', '" & sAciklama & "', " & lBorcTutar & ", " & lAlacakTutar & " , '" & sEvrakNo & "', " & lVadeFarki & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & " , '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & " , '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        sCmd.ExecuteNonQuery()
    End Sub
    Private Sub tbFirmaHareket_kaydet_duzelt(ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime)
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = '" & nFirmaID & "', dteIslemTarihi = '" & dteIslemTarihi & "', dteValorTarihi = '" & dteValorTarihi & "', sCariIslem = '" & sCariIslem & "', sAciklama = '" & sAciklama & "', lBorcTutar = " & lBorcTutar & ", lAlacakTutar = " & lAlacakTutar & ", sEvrakNo = '" & sEvrakNo & "', lVadeFarki = " & lVadeFarki & ", sHangiUygulama = '" & sHangiUygulama & "', sHareketTipi = '" & sHareketTipi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "'  WHERE     (nHareketID = " & nHareketID & ")")
        sCmd.ExecuteNonQuery()
    End Sub
    Private Sub tbCekSenetBodrdro_ekle(ByVal sCekSenetTipi As String, ByVal nCekSenetIslem As Integer, ByVal nFirmaID As Integer, ByVal nCariHareketID As Integer)
        Dim dr1 As DataRow
        dr1 = dataset2.Tables(0).Rows(nSatir)
        Dim nBordroSatirID As Int64 = sorgu_nBordroSatirID()
        Dim nCekSenetID = sorgu_nCekSenetID()
        Dim lCekSenetNo = sorgu_lCekSenetNo(sCekSenetTipi)
        Dim lBordroNo = sorgu_lBordroNo()
        Dim lBorcTutar As Decimal = sorgu_sayi(dr1("lBorcTutar"), 0)
        Dim lAlacakTutar As Decimal = sorgu_sayi(dr1("lAlacakTutar"), 0)
        nCekSenetID = tbCekSenet_kaydet_yeni(nCekSenetID, sCekSenetTipi, lCekSenetNo, "", Math.Abs(lBorcTutar - lAlacakTutar), dr1("dteValorTarihi"), dr1("dteIslemTarihi"), "", "", "", "", dr1("nFirmaID"), 1, dr1("sFirmaAciklama"), dr1("sVergiDairesi"), dr1("sVergiNo"), "", "", nBordroSatirID, nCekSenetIslem, dr1("sHareketTipi"), "", kullaniciadi, Now, dr1("sDovizCinsi1"), dr1("lDovizMiktari1"), dr1("lDovizKuru1"), dr1("sDovizCinsi2"), dr1("lDovizMiktari2"), dr1("lDovizKuru2"), kullaniciadi, Now, "", "")
        nBordroSatirID = tbCekSenetBordro_kaydet_yeni(nBordroSatirID, nCekSenetIslem, dr1("nFirmaID"), dr1("dteIslemTarihi"), lBordroNo, nCekSenetID, 0, 0, nCariHareketID, "", 0, "", 0, "", 0, dr1("dteValorTarihi"), 0, kullaniciadi, Now)
        nCekSenetID_degistir(nCekSenetID)
        nBordroSatirID_degistir(nBordroSatirID)
        dr1("nBordroSatirID") = nBordroSatirID
        dr1("sEvrakNo") = lCekSenetNo
    End Sub
    Private Sub tbCekSenetBordro_degistir(ByVal nBordroSatirID As String, Optional ByVal nCekSenetIslem As Integer = 1)
        Dim dr As DataRow
        dr = dataset2.Tables(0).Rows(nSatir)
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        Dim lBorcTutar As Decimal = dr("lBorcTutar")
        Dim lAlacakTutar As Decimal = dr("lAlacakTutar")
        If nCekSenetIslem = 11 Then
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCekSenet SET              sCekSenetTipi = '" & dr("sCariIslem") & "' ,lTutar = " & Math.Abs(dr("lBorcTutar") - dr("lAlacakTutar")) & ", dteVadeTarihi = '" & dr("dteValorTarihi") & "', sHareketTipi = '" & dr("sHareketTipi") & "', sDovizCinsi1 = '" & dr("sDovizCinsi1") & "', lDovizMiktari1 = " & dr("lDovizMiktari1") & ", lDovizKuru1 = " & dr("lDovizKuru1") & ", sDovizCinsi2 = '" & dr("sDovizCinsi2") & "', lDovizMiktari2 = " & dr("lDovizMiktari2") & ", lDovizKuru2 = " & dr("lDovizKuru2") & " where nCekSenetID = (Select nCekSenetID from tbCekSenetBordro where nBordroSatirID = " & nBordroSatirID & ")")
            'cmd.ExecuteNonQuery()
            sCmd.CommandText = sorgu_query("UPDATE    tbCekSenetBordro SET              lProtestoMasrafi = " & Math.Abs(lBorcTutar - lAlacakTutar) & " Where nBordroSatirID =" & nBordroSatirID & " ")
            sCmd.ExecuteNonQuery()
        Else
            sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCekSenet SET              sCekSenetTipi = '" & dr("sCariIslem") & "' ,lTutar = " & Math.Abs(lBorcTutar - lAlacakTutar) & ", dteVadeTarihi = '" & dr("dteValorTarihi") & "', sHareketTipi = '" & dr("sHareketTipi") & "', sDovizCinsi1 = '" & dr("sDovizCinsi1") & "', lDovizMiktari1 = " & dr("lDovizMiktari1") & ", lDovizKuru1 = " & dr("lDovizKuru1") & ", sDovizCinsi2 = '" & dr("sDovizCinsi2") & "', lDovizMiktari2 = " & dr("lDovizMiktari2") & ", lDovizKuru2 = " & dr("lDovizKuru2") & " where nCekSenetID = (Select nCekSenetID from tbCekSenetBordro where nBordroSatirID = " & nBordroSatirID & ")")
            sCmd.ExecuteNonQuery()
            sCmd.CommandText = sorgu_query("UPDATE    tbCekSenetBordro SET              dteValorTarihi = '" & dr("dteValorTarihi") & "' Where nBordroSatirID =" & nBordroSatirID & " ")
        End If
    End Sub
    Private Sub tbCekSenetBordro_sil(ByVal nBordroSatirID As String)
        Dim dr As DataRow
        dr = dataset2.Tables(0).Rows(nSatir)
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
        sCmd.ExecuteNonQuery()
        sCmd.CommandText = sorgu_query("set implicit_transactions on")
        sCmd.ExecuteNonQuery()
        Try
            Dim nCekSenetID As Int64
            sCmd.CommandText = sorgu_query("Select nCekSenetID from tbCekSenetBordro Where nBordroSatirID = " & nBordroSatirID & "")
            nCekSenetID = sCmd.ExecuteScalar
            sCmd.CommandText = sorgu_query("delete from tbCekSenetBordro where nBordroSatirID = " & nBordroSatirID & "")
            sCmd.ExecuteNonQuery()
            sCmd.CommandText = sorgu_query("delete from tbCekSenet where nCekSenetID = " & nCekSenetID & "")
            sCmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("delete from tbFirmaHareketi where nHareketID =" & nCariHareketID & "")
            'cmd.ExecuteNonQuery()
            sCmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            sCmd.ExecuteNonQuery()
            nCekSenetID = Nothing
            dr("nBordroSatirID") = ""
        Catch ex As Exception
            sCmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            sCmd.ExecuteNonQuery()
            XtraMessageBox.Show("İşlem Hatası Lütfen Tekrar Deneyiniz...")
        End Try
        nBordroSatirID_degistir_otomatik()
        nCekSenetID_degistir_otomatik()
    End Sub
    Private Sub tbCekSenetBordro_parcalitahsilat_kaydet_sil(ByVal nBordroSatirID As String, ByVal nKasaIslemID As String)
        Dim dr As DataRow
        dr = dataset2.Tables(0).Rows(nSatir)
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
        sCmd.ExecuteNonQuery()
        sCmd.CommandText = sorgu_query("set implicit_transactions on")
        sCmd.ExecuteNonQuery()
        Dim nCekSenetID As Int64
        Dim nSonBordroSatirID As Int64
        Try
            sCmd.CommandText = sorgu_query("Select nCekSenetID from tbCekSenetBordro Where nBordroSatirID = " & nBordroSatirID & "")
            nCekSenetID = sCmd.ExecuteScalar
            sCmd.CommandText = sorgu_query("Select nOncekiBordroSatirID from tbCekSenetBordro Where nBordroSatirID = " & nBordroSatirID & "")
            nSonBordroSatirID = sCmd.ExecuteScalar
            Dim nOncekiCekSenetIslem As Int64
            sCmd.CommandText = sorgu_query("Select nOncekiCekSenetIslem from tbCekSenetBordro Where nBordroSatirID = " & nBordroSatirID & "")
            nOncekiCekSenetIslem = sCmd.ExecuteScalar
            sCmd.CommandText = sorgu_query("delete from tbCekSenetBordro where nBordroSatirID = " & nBordroSatirID & "")
            sCmd.ExecuteNonQuery()
            sCmd.CommandText = sorgu_query("delete from tbNakitKasa where nKasaIslemID =" & nKasaIslemID & "")
            sCmd.ExecuteNonQuery()
            sCmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            sCmd.ExecuteNonQuery()
            nCekSenetID_Odeme_degistir(nCekSenetID, nSonBordroSatirID, nOncekiCekSenetIslem)
            dr("nBordroSatirID") = ""
            dr("nKasaIslemID") = ""
        Catch ex As Exception
            sCmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            sCmd.ExecuteNonQuery()
            XtraMessageBox.Show("İşlem Hatası Lütfen Tekrar Deneyiniz...")
        End Try
        nCekSenetID = Nothing
        nSonBordroSatirID = Nothing
        nBordroSatirID_degistir_otomatik()
        nCekSenetID_degistir_otomatik()
    End Sub
    Private Function tbCekSenet_kaydet_yeni(ByVal nCekSenetID As Int64, ByVal sCekSenetTipi As String, ByVal lCekSenetNo As Int64, ByVal sBankaKodu As String, ByVal lTutar As Decimal, ByVal dteVadeTarihi As DateTime, ByVal dteDuzenlemeTarihi As DateTime, ByVal sIl As String, ByVal sSemt As String, ByVal sOrjinalCekSenetNo As String, ByVal sKarsiTarafCekSenetNo As String, ByVal nVerenID As Int64, ByVal bKendineAit As Integer, ByVal sBorclusu As String, ByVal sBorcluVergiDairesi As String, ByVal sBorcluVergiNumarasi As String, ByVal sBankaHesapNo As String, ByVal sBankaSubeNo As String, ByVal nSonBordroSatirID As Int64, ByVal nSonCekSenetIslem As Int64, ByVal sHareketTipi As String, ByVal sNot As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, ByVal sCekSenetKodu1 As String, ByVal sCekSenetKodu2 As String) As Int64
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbCekSenet ( sCekSenetTipi, lCekSenetNo, sBankaKodu, lTutar, dteVadeTarihi, dteDuzenlemeTarihi, sIl, sSemt, sOrjinalCekSenetNo, sKarsiTarafCekSenetNo, nVerenID, bKendineAit, sBorclusu, sBorcluVergiDairesi, sBorcluVergiNumarasi, sBankaHesapNo, sBankaSubeNo, nSonBordroSatirID, nSonCekSenetIslem, sHareketTipi, sNot, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi, sCekSenetKodu1, sCekSenetKodu2) VALUES     ( '" & sCekSenetTipi & "', " & lCekSenetNo & ", '" & sBankaKodu & "', " & lTutar & ", '" & dteVadeTarihi & "', '" & dteDuzenlemeTarihi & "', '" & sIl & "', '" & sSemt & "', '" & sOrjinalCekSenetNo & "', '" & sKarsiTarafCekSenetNo & "', " & nVerenID & ", " & bKendineAit & ", '" & sBorclusu & "', '" & sBorcluVergiDairesi & "', '" & sBorcluVergiNumarasi & "', '" & sBankaHesapNo & "', '" & sBankaSubeNo & "', " & nSonBordroSatirID & ", " & nSonCekSenetIslem & ", '" & sHareketTipi & "', '" & sNot & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "', '" & sCekSenetKodu1 & "', '" & sCekSenetKodu2 & "')")
        sCmd.ExecuteNonQuery()
        sCmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nCekSenetID = sCmd.ExecuteScalar
        Return nCekSenetID
    End Function
    Private Function tbCekSenetBordro_kaydet_yeni(ByVal nBordroSatirID As Int64, ByVal nCekSenetIslem As Int64, ByVal nFirmaID As Int64, ByVal dteBordroTarihi As DateTime, ByVal lBordroNo As Int64, ByVal nCekSenetID As Int64, ByVal nOncekiBordroSatirID As Int64, ByVal nOncekiCekSenetIslem As Int64, ByVal nCariHareketID As Int64, ByVal nKasaIslemID As String, ByVal nBorcluFirmaID As Int64, ByVal nBorcluCariHareketID As String, ByVal nProtestoMasrafiFirmaID As Int64, ByVal nProtestoMasrafiCariHareketID As String, ByVal lProtestoMasrafi As Decimal, ByVal dteValorTarihi As DateTime, ByVal bMuhasebeyeIslendimi As Integer, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime)
        If nProtestoMasrafiCariHareketID = "" Then
            nProtestoMasrafiCariHareketID = "NULL"
        End If
        If nKasaIslemID = "" Then
            nKasaIslemID = "NULL"
        End If
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        If nCekSenetIslem = 21 Then
            sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbCekSenetBordro ( nCekSenetIslem, nFirmaID, dteBordroTarihi, lBordroNo, nCekSenetID, nOncekiBordroSatirID, nOncekiCekSenetIslem, nCariHareketID, nBorcluFirmaID, nBorcluCariHareketID,nProtestoMasrafiFirmaID, lProtestoMasrafi, dteValorTarihi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi) VALUES     ( " & nCekSenetIslem & ", " & nFirmaID & ", '" & dteBordroTarihi & "', " & lBordroNo & ", " & nCekSenetID & ", " & nOncekiBordroSatirID & ", " & nOncekiCekSenetIslem & ", NULL, " & nBorcluFirmaID & ", " & nBorcluCariHareketID & " ," & nProtestoMasrafiFirmaID & ", " & lProtestoMasrafi & ", '" & dteValorTarihi & "', " & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "')")
        Else
            sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbCekSenetBordro ( nCekSenetIslem, nFirmaID, dteBordroTarihi, lBordroNo, nCekSenetID, nOncekiBordroSatirID, nOncekiCekSenetIslem, nCariHareketID, nKasaIslemID,nBorcluFirmaID, nProtestoMasrafiFirmaID,nProtestoMasrafiCariHareketID, lProtestoMasrafi, dteValorTarihi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi) VALUES     ( " & nCekSenetIslem & ", " & nFirmaID & ", '" & dteBordroTarihi & "', " & lBordroNo & ", " & nCekSenetID & ", " & nOncekiBordroSatirID & ", " & nOncekiCekSenetIslem & ", " & nCariHareketID & "," & nKasaIslemID & ", " & nBorcluFirmaID & ", " & nProtestoMasrafiFirmaID & ", " & nProtestoMasrafiCariHareketID & "," & lProtestoMasrafi & ", '" & dteValorTarihi & "', " & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "')")
        End If
        sCmd.ExecuteNonQuery()
        sCmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nBordroSatirID = sCmd.ExecuteScalar
        Return nBordroSatirID
    End Function
    Private Sub nCekSenetID_degistir(ByVal nSonID As String)
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCekSenetSiraNo SET              nSonID =" & nSonID & " WHERE     (nSiraIndex = 1)")
        sCmd.ExecuteNonQuery()
    End Sub
    Private Sub nCekSenetID_degistir_otomatik()
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCekSenetSiraNo SET nSonID = ISNULL((SELECT TOP 1 ISNULL(nCekSenetID + 1 , 1) AS nSonID FROM tbCekSenet ORDER BY nCekSenetID DESC), 1) WHERE (nSiraIndex = 1)")
        sCmd.ExecuteNonQuery()
    End Sub
    Private Sub nCekSenetID_Odeme_degistir(ByVal nCekSenetID As String, ByVal nSonBordroSatirID As String, ByVal nSonCekSenetIslem As String)
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCekSenet SET              nSonBordroSatirID = " & nSonBordroSatirID & ",nSonCekSenetIslem = " & nSonCekSenetIslem & " WHere nCekSenetID = " & nCekSenetID & " ")
        sCmd.ExecuteNonQuery()
    End Sub
    Private Sub nBordroSatirID_degistir(ByVal nSonID As String)
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCekSenetSiraNo SET              nSonID =" & nSonID & " WHERE     (nSiraIndex = 2)")
        sCmd.ExecuteNonQuery()
    End Sub
    Private Sub nBordroSatirID_degistir_otomatik()
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCekSenetSiraNo SET nSonID = ISNULL((SELECT TOP 1 ISNULL(nBordroSatirID + 1 , 1) AS nSonID FROM tbCekSenetBordro ORDER BY nBordroSatirID DESC), 1) WHERE (nSiraIndex = 2)")
        sCmd.ExecuteNonQuery()
    End Sub
    Public Function sorgu_nBordroSatirID() As Int64
        'Dim kriter As String = ""
        'Try
        '    If sCon.State = ConnectionState.Closed = True Then
        '        sCon.Open()
        '    End If
        'Catch ex As Exception
        '    sCon.Close()
        '    sCon.Open()
        'End Try
        'sCmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(nBordroSatirID + 1, 1) AS nBordroSatirID FROM tbCekSenetBordro ORDER BY nBordroSatirID DESC")
        'Dim kayitsayisi = sCmd.ExecuteScalar
        'If kayitsayisi = 0 Then
        '    kayitsayisi = 1
        'End If
        'Return kayitsayisi
        Return 1
    End Function
    Public Function sorgu_nCekSenetID() As Int64
        'Try
        '    If sCon.State = ConnectionState.Closed = True Then
        '        sCon.Open()
        '    End If
        'Catch ex As Exception
        '    sCon.Close()
        '    sCon.Open()
        'End Try
        'sCmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(nCekSenetID + 1, 1) AS nCekSenetID FROM tbCekSenet ORDER BY nCekSenetID DESC")
        'Dim kayitsayisi = sCmd.ExecuteScalar
        'If kayitsayisi = 0 Then
        '    kayitsayisi = 1
        'End If
        'Return kayitsayisi
        Return 1
    End Function
    Public Function sorgu_lCekSenetNo(ByVal sCekSenetTipi As String) As Int64
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(lCekSenetNo + 1, 1) AS lCekSenetNo FROM tbCekSenet Where sCekSenetTipi = '" & sCekSenetTipi & "' ORDER BY lCekSenetNo DESC")
        Dim kayitsayisi = sCmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_lBordroNo() As Int64
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(lBordroNo + 1, 1) AS lBordroNo FROM tbCekSenetBordro ORDER BY lBordroNo DESC")
        Dim kayitsayisi = sCmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_nKasaIslemID() As Int64
        Dim kriter As String = ""
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nKasaIslemID + 1, 0) AS nKasaIslemID  FROM         tbNakitKasa " & kriter & " ORDER BY nKasaIslemID DESC")
        Dim kayitsayisi = sCmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub etiketTalep_Oku(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal belgetipi As String, Optional ByVal nTalepID As String = "")
        Dim dataset1 As New DataSet
        Dim dataset2 As New DataSet
        Dim kriter As String = ""
        If nTalepID = "" Then
        Else
            kriter += " and IND = '" & nTalepID & "' "
        End If
        dataset1 = sorgu("Select * from ASTOKETIKETTALEPBASLIK WHERE TARIH BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND BELGETIPI IN (" & belgetipi & ") " & kriter & "")
        dg.DataSource = dataset1.Tables(0)
        Dim dr As DataRow
        Dim dr1 As DataRow
        ProgressBar1.Properties.Maximum = dataset1.Tables(0).Rows.Count
        ProgressBar1.EditValue = 0
        Me.Refresh()
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection_resmi
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Dim stok_kayit_sayisi As Int64 = 0
        Dim dr_stok As DataRow
        'Dim dr_stok_barkod As DataRow
        Dim barkod_var As Boolean = False
        Dim dr_stok_sinif As DataRow
        Dim dr_renk As DataRow
        Dim dr_fiyat As DataRow
        Dim dr_stok_sinifi As DataRow
        Dim renk_kayit_sayisi As Int64 = 0
        Dim sinif_kayit_sayisi As Int64 = 0
        Dim ds_tbStokFiyati As DataSet
        Dim nStokID As Int64 = 0
        For Each dr In dataset1.Tables(0).Rows
            If sorgu_Talep_kontrol(dr("BELGETIPI"), dr("TARIH"), dr("BELGENO"), dr("KAYITTARIHI")) = 0 Then
                Dim IND As Int64 = talep_baslik_kaydet_yeni(dr("TARIH"), dr("BELGENO"), dr("ACIKLAMA"), dr("KOD1"), dr("KOD2"), dr("KOD3"), dr("KOD4"), dr("KOD5"), dr("SONUC"), dr("DEPO"), dr("TDEPO"), dr("BELGETIPI"), dr("AKTIF"), dr("TRANSFER"), 0, dr("KAYITTARIHI"))
                dataset2 = sorgu("SELECT HAREKET.*, tbStok.nStokID,tbStok.sKodu FROM ASTOKETIKETTALEPDETAY AS HAREKET INNER JOIN tbStok ON HAREKET.STOKNO = tbStok.nStokID Where HAREKET.EVRAKNO =" & dr("IND") & " ")
                ProgressBar2.Properties.Maximum = dataset2.Tables(0).Rows.Count
                ProgressBar2.EditValue = 0
                For Each dr1 In dataset2.Tables(0).Rows
                    'Dim nStokID = sorgu_nStokID(dr1("STOKKODU"))
                    'Stokları Kontrol et
                    stok_kayit_sayisi = sorgu_stok_kontrol(Trim(dr1("sKodu")))
                    If stok_kayit_sayisi = 0 Then
                        'MsgBox(dr("sKodu") & " Kodlu Stok Kaydı Bulunamadı",sDil), MessageBoxIcon.Warning)
                        'Stok Bilgini Çek
                        dataload_stok(dr1("sKodu"))
                        ds_tbStokFiyati = sorgu(sorgu_query("Select * from tbStokFiyati Where nStokID =" & dr1("nStokID") & ""), "TABLE1")
                        'Stok Barkod Bilgisini Çek
                        dataload_stok_barkod(dr1("nStokID"))
                        Dim dr_stok_barkod As DataRow
                        If ds_stok_barkod.Tables(0).Rows.Count > 0 Then
                            barkod_var = True
                            dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                        Else
                            barkod_var = False
                        End If
                        'Sınıf Bilgisini Çek
                        dataload_stok_sinif(dr1("nStokID"))
                        'datarowa yükle
                        dr_stok = ds_stok.Tables(0).Rows(0)
                        'dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                        dr_stok_sinif = ds_stok_sinif.Tables(0).Rows(0)
                        renk_kayit_sayisi = sorgu_Renk_kontrol(dr_stok("sRenk"))
                        If renk_kayit_sayisi = 0 Then
                            dataload_sRenk(dr_stok("sRenk"))
                            dr_renk = ds_renk.Tables(0).Rows(0)
                            stok_renk_kaydet_yeni(dr_renk("sRenk"), dr_renk("sRenkAdi"), dr_renk("lRenkNo"))
                        Else
                        End If
                        'Sınıf Kayıtlarını Kontrol Et
                        For ı As Integer = 1 To 15
                            'MsgBox(dr_stok_sinif("sSinifKodu" & i & ""))
                            sinif_kayit_sayisi = sorgu_Sinif_kontrol(dr_stok_sinif("sSinifKodu" & ı & ""), ı)
                            If sinif_kayit_sayisi = 0 Then
                                dataload_stok_sinif1(dr_stok_sinif("sSinifKodu" & ı & ""), ı)
                                dr_stok_sinifi = ds_stok_sinif.Tables(0).Rows(0)
                                stok_sinif_kaydet_yeni(dr_stok_sinifi("sSinifKodu"), dr_stok_sinifi("sAciklama"), ı)
                            Else
                            End If
                        Next
                        'Stoğu Kaydet
                        nStokID = stok_kaydet_yeni(dr_stok("sKodu"), dr_stok("sAciklama"), dr_stok("sKisaAdi"), dr_stok("nStokTipi"), dr_stok("sBedenTipi"), dr_stok("sKavalaTipi"), dr_stok("sRenk"), dr_stok("sBeden"), dr_stok("sKavala"), dr_stok("sBirimCinsi1"), dr_stok("sBirimCinsi2"), dr_stok("nIskontoYuzdesi"), dr_stok("sKdvTipi"), dr_stok("nTeminSuresi"), dr_stok("lAsgariMiktar"), dr_stok("lAzamiMiktar"), dr_stok("sOzelNot"), dr_stok("nFiyatlandirma"), dr_stok("sModel"), dr_stok("sKullaniciAdi"), dr_stok("dteKayitTarihi"), dr_stok("bEksiyeDusulebilirmi"), dr_stok("sDefaultAsortiTipi"), dr_stok("bEksideUyarsinmi"), dr_stok("bOTVVar"), dr_stok("sOTVTipi"), dr_stok("nIskontoYuzdesiAV"), dr_stok("bEk1"), dr_stok("nEk2"))
                        'barkodu kaydet
                        If barkod_var = True Then
                            dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                            If dr_stok_barkod("nKisim") = 0 Or dr_stok_barkod("nKisim") = 1 Then
                            Else
                                dr_stok_barkod("nKisim") = 0
                            End If
                            If dr_stok_barkod("sKarsiStokKodu") = Microsoft.VisualBasic.Right(dr_stok_barkod("nStokID"), 6) Then
                                dr_stok_barkod("sKarsiStokKodu") = ""
                            End If
                            stok_barkod_kaydet_yeni(nStokID, dr_stok_barkod("sBarkod"), dr_stok_barkod("nKisim"), dr_stok_barkod("nFirmaID"), dr_stok_barkod("sKarsiStokKodu"), dr_stok_barkod("sKarsiStokAciklama"))
                        Else
                        End If
                        For Each dr_fiyat In ds_tbStokFiyati.Tables(0).Rows
                            tbStokFiyati_ekle_yeni(dr_stok("nFiyatlandirma"), dr_stok("sModel"), dr_stok("sRenk"), dr_stok("sBeden"), dr_fiyat("sFiyatTipi"), dr_fiyat("lFiyat"), dr_fiyat("dteFiyatTespitTarihi"), dr_fiyat("sKullaniciAdi"))
                        Next
                        'sınıfları kaydet
                        stok_siniflari_kaydet_yeni(nStokID, dr_stok_sinif("sSinifKodu1"), dr_stok_sinif("sSinifKodu2"), dr_stok_sinif("sSinifKodu3"), dr_stok_sinif("sSinifKodu4"), dr_stok_sinif("sSinifKodu5"), dr_stok_sinif("sSinifKodu6"), dr_stok_sinif("sSinifKodu7"), dr_stok_sinif("sSinifKodu8"), dr_stok_sinif("sSinifKodu9"), dr_stok_sinif("sSinifKodu10"), dr_stok_sinif("sSinifKodu11"), dr_stok_sinif("sSinifKodu12"), dr_stok_sinif("sSinifKodu13"), dr_stok_sinif("sSinifKodu14"), dr_stok_sinif("sSinifKodu15"))
                    Else
                        nStokID = sorgu_nStokID(Trim(dr1("sKodu")))
                    End If
                    Try
                    Catch ex As Exception
                    End Try
                    'Kayda Başla
                    talep_hareket_kaydet_yeni(IND, nStokID, dr1("STOKKODU"), dr1("MALINCINSI"), dr1("BARCODE"), dr1("RENK"), dr1("BEDEN"), dr1("MODEL"), dr1("ETIKET"), dr1("ACIKLAMA"), dr1("DEPO"), dr1("MIKTAR"), dr1("sFiyatTipi"), dr1("FIYAT1"), dr1("FIYAT2"), dr1("FIYAT3"), dr1("sBirimCinsi"), dr1("lBirimMiktar"))
                    ProgressBar2.EditValue += 1
                    ProgressBar2.Refresh()
                Next
                ProgressBar2.EditValue = 0
                ProgressBar2.Refresh()
            End If
            ProgressBar1.EditValue += 1
            Label2.Text = ProgressBar1.EditValue & "/" & dataset1.Tables(0).Rows.Count
            ProgressBar1.Refresh()
            Label2.Refresh()
        Next
    End Sub
    Private Function talep_baslik_kaydet_yeni(ByVal TARIH As DateTime, ByVal BELGENO As String, ByVal ACIKLAMA As String, ByVal KOD1 As String, ByVal KOD2 As String, ByVal KOD3 As String, ByVal KOD4 As String, ByVal KOD5 As String, ByVal SONUC As String, ByVal depo As String, ByVal tdepo As String, ByVal belgetipi As Integer, ByVal aktif As Byte, ByVal transfer As Byte, ByVal bKilitli As Byte, ByVal KAYITTARIHI As DateTime) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim sCmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        sCmd.Connection = conn
        conn.Open()
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO ASTOKETIKETTALEPBASLIK                       (TARIH, BELGENO, ACIKLAMA, KOD1, KOD2, KOD3, KOD4, KOD5, SONUC,DEPO,TDEPO,BELGETIPI,AKTIF,TRANSFER,bKilitli,KAYITTARIHI) VALUES     ('" & TARIH & "', '" & BELGENO & "', '" & ACIKLAMA & "', '" & KOD1 & "', '" & KOD2 & "', '" & KOD3 & "', '" & KOD4 & "', '" & KOD5 & "', '" & SONUC & "','" & depo & "','" & tdepo & "'," & belgetipi & "," & aktif & "," & transfer & "," & bKilitli & ",'" & KAYITTARIHI & "')")
        sCmd.ExecuteNonQuery()
        sCmd.CommandText = "select @@identity"
        Dim hareketno = sCmd.ExecuteScalar
        Return hareketno
    End Function
    Private Function talep_hareket_kaydet_yeni(ByVal EVRAKNO As Int64, ByVal STOKNO As Int64, ByVal STOKKODU As String, ByVal MALINCINSI As String, ByVal BARCODE As String, ByVal RENK As String, ByVal BEDEN As String, ByVal MODEL As String, ByVal ETIKET As String, ByVal ACIKLAMA As String, ByVal DEPO As String, ByVal MIKTAR As Decimal, ByVal sFiyatTipi As String, ByVal FIYAT1 As Decimal, ByVal FIYAT2 As Decimal, ByVal FIYAT3 As Decimal, ByVal sBirimCinsi As String, ByVal lBirimMiktar As Decimal) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim sCmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        sCmd.Connection = conn
        conn.Open()
        Try
            If sCon.State = ConnectionState.Closed = True Then
                sCon.Open()
            End If
        Catch ex As Exception
            sCon.Close()
            sCon.Open()
        End Try
        sCmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO ASTOKETIKETTALEPDETAY                       (EVRAKNO, STOKNO, STOKKODU, MALINCINSI, BARCODE, RENK, BEDEN, MODEL, ETIKET, ACIKLAMA, DEPO, MIKTAR, sFiyatTipi,FIYAT1, FIYAT2, FIYAT3,sBirimCinsi,lBirimMiktar) VALUES     (" & EVRAKNO & " , " & STOKNO & " , '" & STOKKODU & "', '" & MALINCINSI & "', '" & BARCODE & "', '" & RENK & "', '" & BEDEN & "', '" & MODEL & "', '" & ETIKET & "', '" & ACIKLAMA & "' , '" & DEPO & "', " & MIKTAR & ",'" & sFiyatTipi & "', " & FIYAT1 & " , " & FIYAT2 & " , " & FIYAT3 & ",'" & sBirimCinsi & "'," & lBirimMiktar & " )")
        sCmd.ExecuteNonQuery()
        sCmd.CommandText = "select @@identity"
        Dim hareketno = sCmd.ExecuteScalar
        Return hareketno
    End Function
    Public Function sorgu_musteri_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbMusteri " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgula_nStokID(ByVal query As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        cmd.CommandTimeout = Nothing
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = query
        Dim kayitsayisi
        Try
            kayitsayisi = cmd.ExecuteScalar
        Catch ex As Exception
            kayitsayisi = 0
        End Try
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgula_String(ByVal query As String) As String
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        cmd.CommandTimeout = Nothing
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = query
        Dim kayitsayisi = sorgu_string(cmd.ExecuteScalar, "")
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub program_satislari_aktar_birlestir(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, Optional ByVal sFisler As String = "'P','K'", Optional ByVal bSor As Boolean = True)
        Dim bDevam As Boolean = True
        'If bSor = True Then
        '    If XtraMessageBox.Show("Satışları Sisteme Ayrı-Ayrı Aktarmak İstediğinize Eminmisiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
        '        bDevam = True
        '    End If
        'Else
        '    bDevam = True
        'End If
        Dim sQlConnection_orj = "Provider=SQLOLEDB.1;Password=" & txt_sqlPassword.Text & ";Persist Security Info=True;User ID=" & txt_sqlLoginName.Text & ";Initial Catalog=" & txt_sqlDatabase.Text & ";Data Source=" & txt_sqlServer.Text & ";Current Language=Türkçe;Application Name=Konsol"
        connection_resmi = sQlConnection_orj
        If bDevam = True Then
            Dim connection_orj = connection
            Dim sAlisVerisID = nAlisVerisID
            Dim ds As DataSet = sorgu(sorgu_query("SELECT sFisTipi, dteFaturaTarihi, 3 AS nGirisCikis, DAY(dteFaturaTarihi) AS lFaturaNo, 0 AS nMusteriID, '" & sMagaza & "' AS sMagaza, '" & sKasiyerRumuzu & "' AS sKasiyerRumuzu,'Pos' AS sAlisVerisYapanAdi,'Satış' AS sAlisVerisYapanSoyadi, SUM(lToplamMiktar) AS lToplamMiktar, SUM(lMalBedeli) AS lMalBedeli, SUM(lMalIskontoTutari) AS lMalIskontoTutari, 0 AS nDipIskontoYuzdesi, SUM(lDipIskontoTutari) AS lDipIskontoTutari, 0 AS nKdvOrani1, 0 AS lKdvMatrahi1, 0 AS lKdv1, 0 AS nKdvOrani2, 0 AS lKdvMatrahi2, 0 AS lKdv2, 0 AS nKdvOrani3, 0 AS lKdvMatrahi3, 0 AS lKdv3, 0 AS nKdvOrani4, 0 AS lKdvMatrahi4, 0 AS lKdv4, 0 AS nKdvOrani5, 0 AS lKdvMatrahi5, 0 AS lKdv5,SUM(lPesinat) AS lPesinat, 0 AS nVadeFarkiYuzdesi, 0 AS nVadeKdvOrani, 0 AS lVadeKdvMatrahi, 0 AS lVadeKdv, SUM(lVadeFarki) AS lVadeFarki, '' AS sOdemeKodu, SUM(lNetTutar) AS lNetTutar, '" & sHareketTipi & "' AS sHareketTipi, 0 AS bMuhasebeyeIslendimi, " & nKasaNo & " AS nKasaNo, '" & sKasiyer & "' AS sKullaniciAdi, '" & Now & "' AS dteKayitTarihi, '' AS sYaziIle FROM tbAlisVeris WHERE (sFisTipi = 'P') AND (lMalBedeli <> 0) and dteFaturaTarihi Between '" & tarih1 & "' and '" & tarih2 & "' GROUP BY sFisTipi, dteFaturaTarihi"))
            Dim dsh As DataSet
            Dim dso As DataSet
            Dim dst As DataSet
            Dim dr As DataRow  'Master
            Dim dr1 As DataRow 'Detay
            Dim dr2 As DataRow 'Ödeme
            Dim dr3 As DataRow 'Taksit
            Dim dr4 As DataRow 'Kdv
            Dim sSet As String = ""
            Dim nKayit As Integer = 0
            Dim nIslemID As Int64 = 0
            Dim nOdemeID As String = ""
            Dim nTaksitID As String = ""
            Dim lMakbuzNo As Int64 = 0
            Dim lNetTutar As Decimal = 0
            Dim nStokID As Int64 = 0
            Dim musteri_kayit_sayisi As Int64 = 0
            Dim stok_kayit_sayisi As Int64 = 0
            Dim dr_stok As DataRow
            'Dim dr_stok_barkod As DataRow
            Dim barkod_var As Boolean = False
            Dim dr_stok_sinif As DataRow
            Dim dr_renk As DataRow
            Dim dr_stok_sinifi As DataRow
            Dim renk_kayit_sayisi As Int64 = 0
            Dim sinif_kayit_sayisi As Int64 = 0
            Dim dr_fiyat As DataRow
            Dim drn As DataRow
            Dim ds_tbStokFiyati As DataSet
            ProgressBar1.Properties.Maximum = ds.Tables(0).Rows.Count
            ProgressBar1.EditValue = 0
            If ds.Tables(0).Rows.Count = 1 Then
                dr = ds.Tables(0).Rows(0)
                dr("sYaziIle") = ygeneltoplam(Math.Abs(lNetTutar))
                Try
                    ds_alislar_kdv = sorgu(sorgu_query("SELECT     TOP 5 nKdvOrani, SUM((lBrutTutar-lIskontoTutari) / ((100 + nKdvOrani) / 100)) AS lKdvMatrahi, SUM(lBrutTutar-lIskontoTutari) - SUM((lBrutTutar-lIskontoTutari) / ((100 + nKdvOrani) / 100)) AS lKdv, SUM(lBrutTutar-lIskontoTutari) AS lNetTutar FROM         tbStokFisiDetayi WHERE     (sFisTipi = 'P') GROUP BY nKdvOrani ORDER BY nKdvOrani"))
                    Dim sayi As Decimal = 0
                    For Each dr4 In ds_alislar_kdv.Tables(0).Rows
                        sayi += 1
                        dr("nKdvOrani" & sayi & "") = dr4("nKdvOrani")
                        dr("lKdvMatrahi" & sayi & "") = dr4("lKdvMatrahi")
                        dr("lKdv" & sayi & "") = dr4("lKdv")
                    Next
                Catch ex As Exception
                End Try
            End If
            For Each dr In ds.Tables(0).Rows
                If connection.Contains("Provider=SQLOLEDB.1") = True Then
                    sSet = "SET DATEFORMAT " & sDateFormat & ""
                End If
                nKayit = sorgula_nStokID("" & sSet & " SELECT     COUNT(nAlisverisID) AS nKayit FROM         tbAlisVeris WHERE     (sFisTipi = '" & dr("sFisTipi") & "') AND (dteFaturaTarihi = '" & dr("dteFaturaTarihi") & "') AND (nMusteriID = " & dr("nMusteriID") & " ) AND (lFaturaNo = " & dr("lFaturaNo") & ") AND (nGirisCikis = " & dr("nGirisCikis") & ") and (sMagaza = '" & dr("sMagaza") & "')")
                If nKayit = 0 Then
                Else
                    nAlisVerisID = sorgula_String(sSet & " SELECT     nAlisVerisID AS nKayit FROM         tbAlisVeris WHERE     (sFisTipi = '" & dr("sFisTipi") & "') AND (dteFaturaTarihi = '" & dr("dteFaturaTarihi") & "') AND (nMusteriID = " & dr("nMusteriID") & " ) AND (lFaturaNo = " & dr("lFaturaNo") & ") AND (nGirisCikis = " & dr("nGirisCikis") & ") and (sMagaza = '" & dr("sMagaza") & "') ")
                    tbAlisVeris_kaydet_sil_sistem(nAlisVerisID)
                    nKayit = 0
                End If
                If nKayit = 0 Then
                    nAlisVerisID = sorgu_nAlisVerisID(sMagaza, 0)
                    lFaturaNo = dr("lFaturaNo") 'sorgu_lFaturaNo(sMagaza, sFisTipi)
                    dr("sHareketTipi") = Microsoft.VisualBasic.Right(sMagaza, 3)
                    sHareketTipi = dr("sHareketTipi") 'Microsoft.VisualBasic.Right(sMagaza, 2)
                    tbAlisVeris_kaydet_yeni(sMagaza & nAlisVerisID.ToString, dr("sFisTipi"), dr("dteFaturaTarihi"), dr("nGirisCikis"), dr("lFaturaNo"), dr("nMusteriID"), sMagaza, sKasiyerRumuzu, dr("sAlisVerisYapanAdi"), dr("sAlisVerisYapanSoyadi"), dr("lToplamMiktar"), dr("lMalBedeli"), dr("lMalIskontoTutari"), dr("nDipIskontoYuzdesi"), dr("lDipIskontoTutari"), dr("nKdvOrani1"), dr("lKdvMatrahi1"), dr("lKdv1"), dr("nKdvOrani2"), dr("lKdvMatrahi2"), dr("lKdv2"), dr("nKdvOrani3"), dr("lKdvMatrahi3"), dr("lKdv3"), dr("nKdvOrani4"), dr("lKdvMatrahi4"), dr("lKdv4"), dr("nKdvOrani5"), dr("lKdvMatrahi5"), dr("lKdv5"), dr("lPesinat"), dr("nVadeFarkiYuzdesi"), dr("nVadeKdvOrani"), dr("lVadeKdvMatrahi"), dr("lVadeKdv"), dr("lVadeFarki"), dr("sOdemeKodu"), dr("lNetTutar"), dr("sHareketTipi"), dr("bMuhasebeyeIslendimi"), dr("nKasaNo"), "Konsol", dr("dteKayitTarihi"), dr("sYaziIle"))
                    tbAvSirano_degistir(1, nAlisVerisID, sMagaza)
                    lFaturaNo_degistir(lFaturaNo, sMagaza)
                    nAlisVerisID = sMagaza & nAlisVerisID.ToString
                    'Detayları Aktar
                    'dsh = sorgu(sorgu_query("Select * from tbStokFisiDetayi Where sFisTipi = 'P'"))
                    dsh = sorgu(sorgu_query("SELECT nStokID, (Select sKodu from tbStok where nStokID = tbStokFisiDetayi.nStokID) as sKodu, dteIslemTarihi, 0 AS nFirmaID, 0 AS nMusteriID, sFisTipi, dteFisTarihi, DAY(dteFisTarihi) AS lFisNo, 3 AS nGirisCikis, '" & sMagaza & "' AS sDepo, 0 AS lReyonFisNo, sStokIslem, '" & sKasiyerRumuzu & "' AS sKasiyerRumuzu, '' AS sSaticiRumuzu, '' AS sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, SUM(lGirisMiktar1) AS lGirisMiktar1, SUM(lGirisMiktar2) AS lGirisMiktar2, sum(lGirisTutar) AS lGirisFiyat, SUM(lGirisTutar) AS lGirisTutar, SUM(lCikisMiktar1) AS lCikisMiktar1, SUM(lCikisMiktar2) AS lCikisMiktar2, sum(lCikisTutar) AS lCikisFiyat, SUM(lCikisTutar) AS lCikisTutar, sFiyatTipi, sum(lBrutTutar) AS lBrutFiyat, SUM(lBrutTutar) AS lBrutTutar, 0 AS lMaliyetFiyat, 0 AS lMaliyetTutar, 0 AS lIlaveMaliyetTutar, sum(lIskontoTutari) AS nIskontoYuzdesi, SUM(lIskontoTutari) AS lIskontoTutari, '' AS sDovizCinsi, 0 AS lDovizFiyat, 0 AS nSiparisID, 0 AS nReceteNo, 0 AS nTransferID, '' AS sTransferDepo, nKdvOrani, 0 AS nHesapID, '' AS sAciklama, '" & sHareketTipi & "' AS sHareketTipi, 0 AS bMuhasebeyeIslendimi, '" & sKasiyer & "' AS sKullaniciAdi, '" & Now & "' AS dteKayitTarihi, '' AS sDovizCinsi1, 0 AS lDovizMiktari1, 0 AS lDovizKuru1, '' AS sDovizCinsi2, 0 AS lDovizMiktari2, 0 AS lDovizKuru2, 0 AS nOtvOrani, 0 AS nTransferFirmaID, '' AS nAlisVerisID, 0 AS nStokFisiID, 0 AS nIrsaliyeFisiID, '' AS sMasrafYontemi, 'P' AS sHangiUygulama,0 AS nEkSaha1, 0 AS nEkSaha2, 0 AS bEkSoru1, 0 AS bEkSoru2, '" & sKasiyer & "' AS sSonKullaniciAdi, '" & Now & "' AS dteSonUpdateTarihi, '' AS sBirimCinsi, 1 AS lBirimMiktar, 0 AS nPrim FROM tbStokFisiDetayi Where sFisTipi ='P' and dteFisTarihi = '" & dr("dteFaturaTarihi") & "'  and nMusteriID = 0 GROUP BY nStokID, dteIslemTarihi, sFisTipi, dteFisTarihi, sStokIslem, dteIrsaliyeTarihi, lIrsaliyeNo, sFiyatTipi, nKdvOrani"))
                    nIslemID = sorgu_nStokIslemID_MERKEZ()
                    Dim sayi As Integer = 0
                    ProgressBar1.Properties.Maximum = dsh.Tables(0).Rows.Count
                    ProgressBar1.EditValue = 0
                    For Each dr1 In dsh.Tables(0).Rows
                        Dim isk1 As Decimal = 0
                        If sayi = 0 Then
                            nIslemID = sorgu_nStokIslemID()
                        Else
                            sorgu_nStokIslemID_MERKEZ()
                        End If
                        'Stokları Kontrol et
                        stok_kayit_sayisi = sorgu_stok_kontrol(Trim(dr1("sKodu")))
                        If stok_kayit_sayisi = 0 Then
                            'MsgBox(dr("sKodu") & " Kodlu Stok Kaydı Bulunamadı",sDil), MessageBoxIcon.Warning)
                            'Stok Bilgini Çek
                            dataload_stok(dr1("sKodu"))
                            ds_tbStokFiyati = sorgu(sorgu_query("Select * from tbStokFiyati Where nStokID =" & dr1("nStokID") & ""), "TABLE1")
                            'Stok Barkod Bilgisini Çek
                            dataload_stok_barkod(dr1("nStokID"))
                            Dim dr_stok_barkod As DataRow
                            If ds_stok_barkod.Tables(0).Rows.Count > 0 Then
                                barkod_var = True
                                dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                            Else
                                barkod_var = False
                            End If
                            'Sınıf Bilgisini Çek
                            dataload_stok_sinif(dr1("nStokID"))
                            'datarowa yükle
                            dr_stok = ds_stok.Tables(0).Rows(0)
                            'dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                            dr_stok_sinif = ds_stok_sinif.Tables(0).Rows(0)
                            renk_kayit_sayisi = sorgu_Renk_kontrol(dr_stok("sRenk"))
                            If renk_kayit_sayisi = 0 Then
                                dataload_sRenk(dr_stok("sRenk"))
                                dr_renk = ds_renk.Tables(0).Rows(0)
                                stok_renk_kaydet_yeni(dr_renk("sRenk"), dr_renk("sRenkAdi"), dr_renk("lRenkNo"))
                            Else
                            End If
                            'Sınıf Kayıtlarını Kontrol Et
                            For ı As Integer = 1 To 15
                                'MsgBox(dr_stok_sinif("sSinifKodu" & i & ""))
                                sinif_kayit_sayisi = sorgu_Sinif_kontrol(dr_stok_sinif("sSinifKodu" & ı & ""), ı)
                                If sinif_kayit_sayisi = 0 Then
                                    dataload_stok_sinif1(dr_stok_sinif("sSinifKodu" & ı & ""), ı)
                                    dr_stok_sinifi = ds_stok_sinif.Tables(0).Rows(0)
                                    stok_sinif_kaydet_yeni(dr_stok_sinifi("sSinifKodu"), dr_stok_sinifi("sAciklama"), ı)
                                Else
                                End If
                            Next
                            'Stoğu Kaydet
                            nStokID = stok_kaydet_yeni(dr_stok("sKodu"), dr_stok("sAciklama"), dr_stok("sKisaAdi"), dr_stok("nStokTipi"), dr_stok("sBedenTipi"), dr_stok("sKavalaTipi"), dr_stok("sRenk"), dr_stok("sBeden"), dr_stok("sKavala"), dr_stok("sBirimCinsi1"), dr_stok("sBirimCinsi2"), dr_stok("nIskontoYuzdesi"), dr_stok("sKdvTipi"), dr_stok("nTeminSuresi"), dr_stok("lAsgariMiktar"), dr_stok("lAzamiMiktar"), dr_stok("sOzelNot"), dr_stok("nFiyatlandirma"), dr_stok("sModel"), dr_stok("sKullaniciAdi"), dr_stok("dteKayitTarihi"), dr_stok("bEksiyeDusulebilirmi"), dr_stok("sDefaultAsortiTipi"), dr_stok("bEksideUyarsinmi"), dr_stok("bOTVVar"), dr_stok("sOTVTipi"), dr_stok("nIskontoYuzdesiAV"), dr_stok("bEk1"), dr_stok("nEk2"))
                            'barkodu kaydet
                            If barkod_var = True Then
                                dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                                If dr_stok_barkod("nKisim") = 0 Or dr_stok_barkod("nKisim") = 1 Then
                                Else
                                    dr_stok_barkod("nKisim") = 0
                                End If
                                If dr_stok_barkod("sKarsiStokKodu") = Microsoft.VisualBasic.Right(dr_stok_barkod("nStokID"), 6) Then
                                    dr_stok_barkod("sKarsiStokKodu") = ""
                                End If
                                stok_barkod_kaydet_yeni(nStokID, dr_stok_barkod("sBarkod"), dr_stok_barkod("nKisim"), dr_stok_barkod("nFirmaID"), dr_stok_barkod("sKarsiStokKodu"), dr_stok_barkod("sKarsiStokAciklama"))
                            Else
                            End If
                            For Each dr_fiyat In ds_tbStokFiyati.Tables(0).Rows
                                tbStokFiyati_ekle_yeni(dr_stok("nFiyatlandirma"), dr_stok("sModel"), dr_stok("sRenk"), dr_stok("sBeden"), dr_fiyat("sFiyatTipi"), dr_fiyat("lFiyat"), dr_fiyat("dteFiyatTespitTarihi"), dr_fiyat("sKullaniciAdi"))
                            Next
                            'sınıfları kaydet
                            stok_siniflari_kaydet_yeni(nStokID, dr_stok_sinif("sSinifKodu1"), dr_stok_sinif("sSinifKodu2"), dr_stok_sinif("sSinifKodu3"), dr_stok_sinif("sSinifKodu4"), dr_stok_sinif("sSinifKodu5"), dr_stok_sinif("sSinifKodu6"), dr_stok_sinif("sSinifKodu7"), dr_stok_sinif("sSinifKodu8"), dr_stok_sinif("sSinifKodu9"), dr_stok_sinif("sSinifKodu10"), dr_stok_sinif("sSinifKodu11"), dr_stok_sinif("sSinifKodu12"), dr_stok_sinif("sSinifKodu13"), dr_stok_sinif("sSinifKodu14"), dr_stok_sinif("sSinifKodu15"))
                            'Birim Cevrimi
                            Dim ds_tbStokBirimCevrimi As DataSet = sorgu(sorgu_query("Select * from tbStokBirimCevrimi Where nStokID IN (Select nStokID from tbStok where  sModel = '" & dr_stok("sModel") & "')"))
                            For Each drn In ds_tbStokBirimCevrimi.Tables(0).Rows
                                tbStokBirimCevrimi_kaydet_yeni(drn("sBirimCinsi"), drn("lOran"), dr_stok("sModel"))
                            Next
                        Else
                            nStokID = sorgu_nStokID(Trim(dr1("sKodu")))
                        End If
                        Try
                        Catch ex As Exception
                        End Try
                        'Kayda Başla
                        dr1("nMusteriID") = dr("nMusteriID")
                        dr1("nStokID") = nStokID
                        Try
                            dr1("lCikisFiyat") = dr1("lCikisTutar") / dr1("lCikisMiktar1")
                        Catch ex As Exception
                            dr1("lCikisFiyat") = 0
                        End Try
                        Try
                            dr1("lBrutFiyat") = dr1("lBrutTutar") / dr1("lCikisMiktar1")
                        Catch ex As Exception
                            dr1("lBrutFiyat") = 0
                        End Try
                        Try
                            If dr1("lIskontoTutari") <> 0 Then
                                dr1("nIskontoYuzdesi") = dr1("lIskontoTutari") / dr1("lBrutTutar") * 100
                                If dr1("nIskontoYuzdesi") > 100 Then
                                    dr1("nIskontoYuzdesi") = 100
                                End If
                            Else
                                dr1("nIskontoYuzdesi") = 0
                            End If
                        Catch ex As Exception
                            dr1("nIskontoYuzdesi") = 0
                        End Try
                        isk1 = dr1("lBrutFiyat") * ((100 - dr1("nIskontoYuzdesi")) / 100)
                        Try
                            dr1("nIskontoYuzdesi") = ((dr1("lBrutFiyat") - isk1) / dr1("lBrutFiyat")) * 100
                        Catch ex As Exception
                        End Try
                        Dim bDevamEt As Boolean = False
                        bDevamEt = False
                        Try
                            nIslemID = tbStokFisidetay_kaydet_yeni(nIslemID, dr1("nStokID"), dr1("dteIslemTarihi"), dr1("nFirmaID"), dr1("nMusteriID"), dr1("sFisTipi").ToString, dr1("dteFisTarihi"), dr1("lFisNo"), dr1("nGirisCikis"), sMagaza.ToString, dr1("lReyonFisNo"), dr1("sStokIslem").ToString, dr1("sKasiyerRumuzu").ToString, dr1("sSaticiRumuzu").ToString, dr1("sOdemeKodu").ToString, dr1("dteIrsaliyeTarihi"), dr1("lIrsaliyeNo"), sorgu_sayi(dr1("lGirisMiktar1"), 0), sorgu_sayi(dr1("lGirisMiktar2"), 0), sorgu_sayi(dr1("lGirisFiyat"), 0), sorgu_sayi(dr1("lGirisTutar"), 0), sorgu_sayi(dr1("lCikisMiktar1"), 0), sorgu_sayi(dr1("lCikisMiktar2"), 0), sorgu_sayi(dr1("lCikisFiyat"), 0), sorgu_sayi(dr1("lCikisTutar"), 0), dr1("sFiyatTipi").ToString, sorgu_sayi(dr1("lBrutFiyat"), 0), sorgu_sayi(dr1("lBrutTutar"), 0), sorgu_sayi(dr1("lMaliyetFiyat"), 0), sorgu_sayi(dr1("lMaliyetTutar"), 0), sorgu_sayi(dr1("lIlaveMaliyetTutar"), 0), sorgu_sayi(dr1("nIskontoYuzdesi"), 0), sorgu_sayi(dr1("lIskontoTutari"), 0), dr1("sDovizCinsi").ToString, sorgu_sayi(dr1("lDovizFiyat"), 0), "", dr1("nReceteNo"), "", "", sorgu_sayi(dr1("nKdvOrani"), 0), dr1("nHesapID"), dr1("sAciklama").ToString, sHareketTipi.ToString, dr1("bMuhasebeyeIslendimi"), dr1("sKullaniciAdi").ToString, dr1("dteKayitTarihi"), dr1("sDovizCinsi1").ToString, sorgu_sayi(dr1("lDovizMiktari1"), 0), sorgu_sayi(dr1("lDovizKuru1"), 0), dr1("sDovizCinsi2").ToString, sorgu_sayi(dr1("lDovizMiktari2"), 0), sorgu_sayi(dr1("lDovizKuru2"), 0), dr1("nOTVOrani"), "", nAlisVerisID, "NULL", "NULL", dr1("sMasrafYontemi").ToString, dr1("sHangiUygulama").ToString, dr1("nEksaha1"), dr1("nEkSaha2"), dr1("bEkSoru1"), dr1("bEkSoru2"), dr1("sSonKullaniciAdi").ToString, dr1("dteSonUpdateTarihi"))
                            bDevamEt = True
                        Catch ex As Exception
                            nIslemID = nIslemID + 1
                            'tbStokFisidetay_kaydet_yeni(nIslemID, dr1("nStokID"), dr1("dteIslemTarihi"), dr1("nFirmaID"), dr1("nMusteriID"), dr1("sFisTipi").ToString, dr1("dteFisTarihi"), dr1("lFisNo"), dr1("nGirisCikis"), sMagaza.ToString, dr1("lReyonFisNo"), dr1("sStokIslem").ToString, dr1("sKasiyerRumuzu").ToString, dr1("sSaticiRumuzu").ToString, dr1("sOdemeKodu").ToString, dr1("dteIrsaliyeTarihi"), dr1("lIrsaliyeNo"), sorgu_sayi(dr1("lGirisMiktar1"), 0), sorgu_sayi(dr1("lGirisMiktar2"), 0), sorgu_sayi(dr1("lGirisFiyat"), 0), sorgu_sayi(dr1("lGirisTutar"), 0), sorgu_sayi(dr1("lCikisMiktar1"), 0), sorgu_sayi(dr1("lCikisMiktar2"), 0), sorgu_sayi(dr1("lCikisFiyat"), 0), sorgu_sayi(dr1("lCikisTutar"), 0), dr1("sFiyatTipi").ToString, sorgu_sayi(dr1("lBrutFiyat"), 0), sorgu_sayi(dr1("lBrutTutar"), 0), sorgu_sayi(dr1("lMaliyetFiyat"), 0), sorgu_sayi(dr1("lMaliyetTutar"), 0), sorgu_sayi(dr1("lIlaveMaliyetTutar"), 0), sorgu_sayi(dr1("nIskontoYuzdesi"), 0), sorgu_sayi(dr1("lIskontoTutari"), 0), dr1("sDovizCinsi").ToString, sorgu_sayi(dr1("lDovizFiyat"), 0), "", dr1("nReceteNo"), "", "", sorgu_sayi(dr1("nKdvOrani"), 0), dr1("nHesapID"), dr1("sAciklama").ToString, sHareketTipi.ToString, dr1("bMuhasebeyeIslendimi"), dr1("sKullaniciAdi").ToString, dr1("dteKayitTarihi"), dr1("sDovizCinsi1").ToString, sorgu_sayi(dr1("lDovizMiktari1"), 0), sorgu_sayi(dr1("lDovizKuru1"), 0), dr1("sDovizCinsi2").ToString, sorgu_sayi(dr1("lDovizMiktari2"), 0), sorgu_sayi(dr1("lDovizKuru2"), 0), dr1("nOTVOrani"), "", nAlisVerisID, "NULL", "NULL", dr1("sMasrafYontemi").ToString, dr1("sHangiUygulama").ToString, dr1("nEksaha1"), dr1("nEkSaha2"), dr1("bEkSoru1"), dr1("bEkSoru2"), dr1("sSonKullaniciAdi").ToString, dr1("dteSonUpdateTarihi"))
                        End Try
                        If bDevamEt = False Then
                            nIslemID = sorgu_nStokIslemID()
                            Try
                                nIslemID = tbStokFisidetay_kaydet_yeni(nIslemID, dr1("nStokID"), dr1("dteIslemTarihi"), dr1("nFirmaID"), dr1("nMusteriID"), dr1("sFisTipi").ToString, dr1("dteFisTarihi"), dr1("lFisNo"), dr1("nGirisCikis"), sMagaza.ToString, dr1("lReyonFisNo"), dr1("sStokIslem").ToString, dr1("sKasiyerRumuzu").ToString, dr1("sSaticiRumuzu").ToString, dr1("sOdemeKodu").ToString, dr1("dteIrsaliyeTarihi"), dr1("lIrsaliyeNo"), sorgu_sayi(dr1("lGirisMiktar1"), 0), sorgu_sayi(dr1("lGirisMiktar2"), 0), sorgu_sayi(dr1("lGirisFiyat"), 0), sorgu_sayi(dr1("lGirisTutar"), 0), sorgu_sayi(dr1("lCikisMiktar1"), 0), sorgu_sayi(dr1("lCikisMiktar2"), 0), sorgu_sayi(dr1("lCikisFiyat"), 0), sorgu_sayi(dr1("lCikisTutar"), 0), dr1("sFiyatTipi").ToString, sorgu_sayi(dr1("lBrutFiyat"), 0), sorgu_sayi(dr1("lBrutTutar"), 0), sorgu_sayi(dr1("lMaliyetFiyat"), 0), sorgu_sayi(dr1("lMaliyetTutar"), 0), sorgu_sayi(dr1("lIlaveMaliyetTutar"), 0), sorgu_sayi(dr1("nIskontoYuzdesi"), 0), sorgu_sayi(dr1("lIskontoTutari"), 0), dr1("sDovizCinsi").ToString, sorgu_sayi(dr1("lDovizFiyat"), 0), "", dr1("nReceteNo"), "", "", sorgu_sayi(dr1("nKdvOrani"), 0), dr1("nHesapID"), dr1("sAciklama").ToString, sHareketTipi.ToString, dr1("bMuhasebeyeIslendimi"), dr1("sKullaniciAdi").ToString, dr1("dteKayitTarihi"), dr1("sDovizCinsi1").ToString, sorgu_sayi(dr1("lDovizMiktari1"), 0), sorgu_sayi(dr1("lDovizKuru1"), 0), dr1("sDovizCinsi2").ToString, sorgu_sayi(dr1("lDovizMiktari2"), 0), sorgu_sayi(dr1("lDovizKuru2"), 0), dr1("nOTVOrani"), "", nAlisVerisID, "NULL", "NULL", dr1("sMasrafYontemi").ToString, dr1("sHangiUygulama").ToString, dr1("nEksaha1"), dr1("nEkSaha2"), dr1("bEkSoru1"), dr1("bEkSoru2"), dr1("sSonKullaniciAdi").ToString, dr1("dteSonUpdateTarihi"))
                            Catch ex As Exception
                            End Try
                        End If
                        fis_detay_fisno_degistir(nIslemID)
                        sayi += 1
                        ProgressBar1.EditValue += 1
                        ProgressBar1.Refresh()
                    Next
                    fis_detay_fisno_degistir(nIslemID)
                    'Tahsilatları Aktar
                    'dso = sorgu(sorgu_query("SELECT     tbOdeme.* FROM         tbAlisVeris INNER JOIN                       tbOdeme ON tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID WHERE     (tbOdeme.nOdemeKodu IN (1, 3)) AND (tbAlisVeris.sFisTipi = 'P')"))
                    dso = sorgu(sorgu_query("SELECT tbOdeme.sOdemeSekli, tbOdeme.nOdemeKodu, '" & sKasiyerRumuzu & "' AS sKasiyerRumuzu, tbOdeme.dteOdemeTarihi, tbOdeme.dteValorTarihi, SUM(tbOdeme.lOdemeTutar) AS lOdemeTutar, tbOdeme.sDovizCinsi, tbOdeme.lDovizTutar, 0 AS lMakbuzNo, 0 AS lOdemeNo, tbOdeme.nTaksitID, tbOdeme.nIadeAlisverisID, tbOdeme.bMuhasebeyeIslendimi, " & nKasaNo & " AS nKasaNo, tbOdeme.sKartNo, '" & sKasiyer & "' AS sKullaniciAdi, '" & Now & "' AS dteKayitTarihi, '" & sMagaza & "' AS sMagaza FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.nOdemeKodu IN (1, 3)) AND (tbAlisVeris.sFisTipi = 'P') AND tbAlisVeris.dteFaturaTarihi = '" & dr("dteFaturaTarihi") & "' GROUP BY tbOdeme.sOdemeSekli, tbOdeme.nOdemeKodu, tbOdeme.dteOdemeTarihi, tbOdeme.dteValorTarihi, tbOdeme.sDovizCinsi, tbOdeme.lDovizTutar, tbOdeme.nTaksitID, tbOdeme.nIadeAlisverisID, tbOdeme.bMuhasebeyeIslendimi, tbOdeme.nKasaNo, tbOdeme.sKartNo"))
                    For Each dr2 In dso.Tables(0).Rows
                        If lMakbuzNo = sorgu_lMakbuzNo_varmi(sMagaza, nAlisVerisID) = 0 Then
                            lMakbuzNo = sorgu_lMakbuzNo(sMagaza, dr2("nOdemeKodu"))
                            lMakbuzNo_degistir(lMakbuzNo, sMagaza)
                        End If
                        nOdemeID = sorgu_nOdemeID(sMagaza).ToString
                        Try
                            tbOdeme_kaydet_yeni(sMagaza & nOdemeID, nAlisVerisID, dr2("sOdemeSekli"), dr2("nOdemeKodu"), dr2("sKasiyerRumuzu"), dr2("dteOdemeTarihi"), dr2("dteValorTarihi"), dr2("lOdemeTutar"), dr2("sDovizCinsi"), dr2("lDovizTutar"), lMakbuzNo, lMakbuzNo, dr2("nTaksitID"), dr2("nIadeAlisVerisID"), dr2("bMuhasebeyeIslendimi"), dr2("nKasaNo"), dr2("sKartNo"), dr2("sKullaniciAdi"), dr2("dteKayitTarihi"), sMagaza)
                        Catch ex As Exception
                        End Try
                        tbAvSirano_degistir(2, nOdemeID, sMagaza)
                    Next
                    'Taksitleri Aktar
                    dst = sorgu(sorgu_query("SELECT     tbTaksit.* FROM         tbAlisVeris INNER JOIN                       tbTaksit ON tbAlisVeris.nAlisverisID = tbTaksit.nAlisverisID WHERE     (tbAlisVeris.sFisTipi = 'P') and (tbAlisVeris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "')"))
                    For Each dr3 In dst.Tables(0).Rows
                        nTaksitID = sorgu_nTaksitID(sMagaza)
                        tbTaksit_kaydet_yeni(sMagaza & nTaksitID, nAlisVerisID, dr3("dteTarihi"), dr3("lTutari"))
                        tbAvSirano_degistir(3, nTaksitID, sMagaza)
                    Next
                    Try
                        ProgressBar1.EditValue += 1
                    Catch ex As Exception
                    End Try
                    ProgressBar1.Refresh()
                Else
                    'MsgBox("Belge Sisteme Kayıtlı")
                End If
            Next
            ProgressBar1.EditValue = 0
            ProgressBar1.Refresh()
            nAlisVerisID = sAlisVerisID
            program_satislari_aktar(tarih1, tarih2, "'K'", False)
        End If
    End Sub
    Private Sub program_odemeleri_aktar(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        'If XtraMessageBox.Show("Alınan Ödemeleri Sisteme Aktarmak İstediğinize Eminmisiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
        Dim sQlConnection_orj = "Provider=SQLOLEDB.1;Password=" & txt_sqlPassword.Text & ";Persist Security Info=True;User ID=" & txt_sqlLoginName.Text & ";Initial Catalog=" & txt_sqlDatabase.Text & ";Data Source=" & txt_sqlServer.Text & ";Current Language=Türkçe;Application Name=Konsol"
        Dim connection_orj = connection
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim sSet As String = ""
        Dim musteri_kayit_sayisi As Integer = 0
        ds_Rapor = sorgu(sorgu_query("SELECT  tbOdeme.*, tbAlisVeris.nMusteriID,tbMusteri.lKodu FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID WHERE (tbOdeme.nOdemeKodu = 2) and tbOdeme.dteOdemeTarihi between '" & tarih1 & "' and '" & tarih2 & "'"))
        For Each dr1 In ds_Rapor.Tables(0).Rows
            If connection.Contains("Provider=SQLOLEDB.1") = True Then
                sSet = "SET DATEFORMAT " & sDateFormat & ""
            End If
            'Müşteri Kontrol
            musteri_kayit_sayisi = sorgu_musteri_kontrol(dr1("lKodu"))
            Dim dr_Musteri As DataRow
            If musteri_kayit_sayisi = 0 Then
                dataload_tbMusteri(dr1("lKodu"))
                dataload_tbMusteriNufusu(dr1("lKodu"))
                dr_Musteri = ds_tbMusteri.Tables(0).Rows(0)
                nMusteriID = tbMusteri_kaydet_yeni(dr_Musteri("sMagaza"), dr_Musteri("lKodu"), dr_Musteri("sAdi"), dr_Musteri("sSoyadi"), dr_Musteri("nCinsiyet"), dr_Musteri("lAylikGelir"), dr_Musteri("dteKartAcilisTarihi"), dr_Musteri("nIskontoPesin"), dr_Musteri("nIskontoKredili"), dr_Musteri("sUnvan"), dr_Musteri("sVergiDairesi"), dr_Musteri("sVergiNo"), dr_Musteri("bYazismaEvAdresinemi"), dr_Musteri("sEmail"), dr_Musteri("sIsYeriAdi"), dr_Musteri("sIsAdresi1"), dr_Musteri("sIsAdresi2"), dr_Musteri("sIsSemt"), dr_Musteri("sIsIl"), dr_Musteri("sIsPostaKodu"), dr_Musteri("sIsTelefonu"), dr_Musteri("sEvAdresi1"), dr_Musteri("sEvAdresi2"), dr_Musteri("sEvSemt"), dr_Musteri("sEvPostaKodu"), dr_Musteri("sEvIl"), dr_Musteri("sEvTelefonu"), dr_Musteri("sSigortaNo"), dr_Musteri("bEvlimi"), dr_Musteri("dteEvlilikTarihi"), dr_Musteri("dteDogumTarihi"), dr_Musteri("sDogumYeri"), dr_Musteri("sEhliyetNo"), dr_Musteri("sKanGrubu"), dr_Musteri("sHitap"), dr_Musteri("sKullaniciAdi"), dr_Musteri("dteKayitTarihi"), dr_Musteri("sAciklama1"), dr_Musteri("sAciklama2"), dr_Musteri("sAciklama3"), dr_Musteri("sAciklama4"), dr_Musteri("sAciklama5"), dr_Musteri("sGSM"), dr_Musteri("sFax"), dr_Musteri("sResimAdi"))
                tbMusteriSinifi_kaydet_yeni(nMusteriID, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
                Dim drn As DataRow
                For Each drn In ds_tbMusteriNufusu.Tables(0).Rows
                    tbMusteriNufusu_kaydet_yeni(nMusteriID, drn("sDin"), drn("sKutukIl"), drn("sKutukIlce"), drn("sKutukMahalle"), drn("sKutukCiltNo"), drn("sKutukSiraNo"), drn("dteNufusCuzdanTarihi"), drn("sCuzdanVerilenYer"), drn("sCuzdanVerNedeni"), drn("sCuzdanKayitNo"), drn("sAnneAdi"), drn("sBabaAdi"), drn("sAileAdresi1"), drn("sAileAdresi2"), drn("sAileSemt"), drn("sAilePostaKodu"), drn("sAileIl"), drn("sAileTelefonu"), drn("sHitapAnne"), drn("sHitapBaba"))
                Next
                drn = Nothing
            Else
            End If
            dr1("nMusteriID") = sorgu_nMusteriID(dr1("lKodu"))
            Dim nKayit As Int64 = sorgula_nStokID("" & sSet & " SELECT     COUNT(nOdemeID) AS nKayit FROM         tbOdeme WHERE     (sMagaza = '" & dr1("sMagaza") & "') AND (lMakbuzNo = " & dr1("lMakbuzNo") & ") AND (nOdemeKodu = 2) AND (dteOdemeTarihi = '" & dr1("dteOdemeTarihi") & "')")
            If nKayit = 0 Then
                Dim ds_taksit As DataSet = tbTaksit(dr1("nMusteriID"))
                Dim tutar As Decimal = 0
                Dim lOdemeTutar As Decimal = 0
                Dim lKur As Decimal = 0
                Dim lDovizTutar As Decimal = 0
                Dim nOdemeID As Int64 = 0
                Dim lMakbuzNo As String = dr1("lMakbuzNo") 'sorgu_lMakbuzNo(sMagaza, 2)
                Dim lToplamTutar As Decimal = 0
                Dim sMagaza As String = dr1("sMagaza")
                lOdemeTutar = dr1("lOdemeTutar")
                If lOdemeTutar > 0 Then
                    For Each dr In ds_taksit.Tables(0).Rows
                        If dr("KALAN") > 0 And lOdemeTutar > 0 Then
                            If lOdemeTutar > dr("KALAN") Then
                                tutar = dr("KALAN")
                                lOdemeTutar -= dr("KALAN")
                                dr("KALAN") = 0
                            ElseIf lOdemeTutar = dr("KALAN") Then
                                tutar = dr("KALAN")
                                lOdemeTutar -= dr("KALAN")
                                dr("KALAN") = 0
                            ElseIf lOdemeTutar < dr("KALAN") Then
                                tutar = lOdemeTutar 'dr("KALAN") - lOdemeTutar
                                lOdemeTutar = 0
                                dr("KALAN") = dr("KALAN") - lOdemeTutar
                            End If
                            lToplamTutar += tutar
                            nOdemeID = sorgu_nOdemeID(sMagaza)
                            'dr1("dteKayitTarihi") = Now
                            If lKur <> 0 Then
                                lDovizTutar = tutar / lKur
                            Else
                                lDovizTutar = 0
                            End If
                            tbOdeme_kaydet_yeni(sMagaza & nOdemeID.ToString, dr("nAlisVerisID"), dr1("sOdemeSekli"), dr1("nOdemeKodu"), dr1("sKasiyerRumuzu"), dr1("dteOdemeTarihi"), dr1("dteOdemeTarihi"), tutar, dr1("sDovizCinsi"), lDovizTutar, lMakbuzNo, lMakbuzNo, dr("nTaksitID"), dr1("nIadeAlisVerisID"), dr1("bMuhasebeyeIslendimi"), dr1("nKasaNo"), dr1("sKartNo"), dr1("sKullaniciAdi"), dr1("dteKayitTarihi"), sMagaza)
                            tbAvSirano_degistir(2, nOdemeID, sMagaza)
                            lMakbuzNo_degistir(lMakbuzNo, sMagaza)
                        End If
                    Next
                End If
            End If
        Next
        'MsgBox("İşlem Başarıyla Tamamlandı...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub
    Public Function sorgu_nAlisVerisID(ByVal sDepo As String, Optional ByVal nIndex As Integer = 1) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        'cmd.CommandText = sorgu_query("SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 1)")
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 1)")
        If nIndex = 0 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(REPLACE(nAlisverisID, '" & sDepo & "', ''), 0) + 1 AS nSonID FROM         tbAlisVeris WHERE     (nAlisVerisID  like '" & sDepo & "%') ORDER BY CAST(ISNULL(REPLACE(nAlisverisID, '" & sDepo & "', ''), 0) AS DECIMAL) DESC")
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 1)")
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(REPLACE(nAlisverisID, '" & sDepo & "', ''), 0) + 1 AS nSonID FROM         tbAlisVeris WHERE     (nAlisVerisID  like '" & sDepo & "%') ORDER BY CAST(ISNULL(REPLACE(nAlisverisID, '" & sDepo & "', ''), 0) AS DECIMAL) DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_lFaturaNo(ByVal sDepo As String, ByVal sFisTipi As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        'cmd.CommandText = sorgu_query("SELECT     ISNULL(MAX(lFaturaNo), 0) + 1 AS nSonID FROM         tbAlisVeris WHERE     (sMagaza = '" & sDepo & "') AND (nGirisCikis = 3) AND (sFisTipi IN ('" & sFisTipi & "'))")
        cmd.CommandText = sorgu_query("SELECT     MAX(lFaturaNo)  AS nSonID FROM         tbAlisVeris WHERE     (nGirisCikis = 3) AND (sFisTipi IN ('" & sFisTipi & "'))")
        Dim kayitsayisi = sorgu_sayi(cmd.ExecuteScalar, 0) + 1
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub tbAvSirano_degistir(ByVal nSiraIndex As Integer, ByVal nSonID As Int64, ByVal sDepo As String)
        'kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        'sorgu(sorgu_query("SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("UPDATE    tbAvSiraNo SET              nSonID = '" & nSonID & "' where nSiraIndex = " & nSiraIndex & " and sDepo = '" & sDepo & "'")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
        adapter = Nothing
    End Sub
    Private Sub lFaturaNo_degistir(ByVal nSonID As Int64, ByVal sDepo As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("UPDATE    tbStokFisNolar SET              lPerakendeFatura1 ='" & nSonID & "' WHERE     (sDepo = '" & sDepo & "')")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Sub tbAlisVeris_kaydet_yeni(ByVal nAlisverisID As String, ByVal sFisTipi As String, ByVal dteFaturaTarihi As DateTime, ByVal nGirisCikis As Int64, ByVal lFaturaNo As String, ByVal nMusteriID As Int64, ByVal sMagaza As String, ByVal sKasiyerRumuzu As String, ByVal sAlisverisYapanAdi As String, ByVal sAlisverisYapanSoyadi As String, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi As Decimal, ByVal lDipIskontoTutari As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lPesinat As Decimal, ByVal nVadeFarkiYuzdesi As Decimal, ByVal nVadeKdvOrani As Decimal, ByVal lVadeKdvMatrahi As Decimal, ByVal lVadeKdv As Decimal, ByVal lVadeFarki As Decimal, ByVal sOdemeKodu As String, ByVal lNetTutar As Decimal, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Integer, ByVal nKasaNo As Int64, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sYaziIle As String)
        Dim sSet As String = ""
        If connection.Contains("Provider=SQLOLEDB.1") = True Then
            sSet = "SET DATEFORMAT " & sDateFormat & ""
        End If
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & sSet & " INSERT INTO tbAlisVeris (nAlisverisID, sFisTipi, dteFaturaTarihi, nGirisCikis, lFaturaNo, nMusteriID, sMagaza, sKasiyerRumuzu, sAlisverisYapanAdi, sAlisverisYapanSoyadi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi, lDipIskontoTutari, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lPesinat, nVadeFarkiYuzdesi, nVadeKdvOrani, lVadeKdvMatrahi, lVadeKdv, lVadeFarki, sOdemeKodu, lNetTutar, sHareketTipi, bMuhasebeyeIslendimi, nKasaNo, sKullaniciAdi, dteKayitTarihi, sYaziIle) VALUES     ('" & nAlisverisID & "', '" & sFisTipi & "', '" & dteFaturaTarihi & "', " & nGirisCikis & ", '" & lFaturaNo & "', " & nMusteriID & ", '" & sMagaza & "', '" & sKasiyerRumuzu & "', '" & sAlisverisYapanAdi & "', '" & sAlisverisYapanSoyadi & "', " & lToplamMiktar & ", " & lMalBedeli & ", " & lMalIskontoTutari & ", " & nDipIskontoYuzdesi & ", " & lDipIskontoTutari & ", " & nKdvOrani1 & ", " & lKdvMatrahi1 & ", " & lKdv1 & ", " & nKdvOrani2 & ", " & lKdvMatrahi2 & ", " & lKdv2 & ", " & nKdvOrani3 & ", " & lKdvMatrahi3 & ", " & lKdv3 & ", " & nKdvOrani4 & ", " & lKdvMatrahi4 & ", " & lKdv4 & ", " & nKdvOrani5 & ", " & lKdvMatrahi5 & ", " & lKdv5 & ", " & lPesinat & ", " & nVadeFarkiYuzdesi & ", " & nVadeKdvOrani & ", " & lVadeKdvMatrahi & ", " & lVadeKdv & ", " & lVadeFarki & ", '" & sOdemeKodu & "', " & lNetTutar & ", '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & nKasaNo & ", '" & sKullaniciAdi & "',  '" & dteKayitTarihi & "', '" & sYaziIle & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbAlisVeris_kaydet_sil_sistem(ByVal nAlisverisID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim lOdemeTutar As Decimal = 0
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(tbOdeme.lOdemeTutar), 0) AS lOdemeTutar FROM tbAlisVeris INNER JOIN tbOdeme ON tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID WHERE (tbOdeme.nOdemeKodu =2) and (tbAlisVeris.nAlisverisID = '" & nAlisverisID & "') OR (tbOdeme.nIadeAlisverisID = '" & nAlisverisID & "') ")
        lOdemeTutar = cmd.ExecuteScalar
        If lOdemeTutar = 0 Then
            Try
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("set implicit_transactions off")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAVPromosyonIndirim where nAlisverisID = '" & nAlisverisID & "' ")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT count (a.nTaksitID) from tbTaksit a , tbOdeme b where a.nTaksitID=b.nTaksitID and a.nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("set implicit_transactions on")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAlisverisSlip set bIptalmi = 0  where nAlisverisID =  ( Select top 1 nIadeAlisverisID from tbOdeme where nIadeAlisverisID <> ''    and nAlisverisID = '" & nAlisverisID & "')")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAVKartTaksit where nOdemeID in ( select nOdemeID from tbOdeme where nAlisverisID =  '" & nAlisverisID & "' )")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbOdeme where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbTaksit where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMusteriPara set lPara = lPara - isnull(( select sum(lTutar) from tbAVHediyeCeki where nAlisverisID = '" & nAlisverisID & "' and sHediyeCekiTipi = 'ParaPU_KAZ'), 0)  + isnull(( select sum(lTutar) from tbAVHediyeCeki where nAlisverisID = '" & nAlisverisID & "' and sHediyeCekiTipi = 'ParaPU_HAR'), 0)  where nMusteriID in (select nMusteriID from tbAlisveris where nAlisverisID = '" & nAlisverisID & "')")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAVIndirimKuponu set bKapandimi = 0 where sAlinanBasilan = 'B' and sKuponSeriNo in (select sKuponSeriNo from tbAVIndirimKuponu where sAlinanBasilan = 'A'  and nAlisverisID = '" & nAlisverisID & "')")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAVIndirimKuponu where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbStokFisiDetayi where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAlisverisSiparis where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAVHediyeCeki where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAlisverisSlip where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAlisVerisAdres where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAlisVeris where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
                cmd.ExecuteNonQuery()
                XtraMessageBox.Show(Sorgu_sDil("İşlem Hatası Lütfen Tekrar Deneyiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        Else
            XtraMessageBox.Show(Sorgu_sDil("Ödeme Alınmış Belgeyi Silemezsiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        con.Close()
    End Sub
    Public Function sorgu_nStokIslemID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SELECT     MAX(nIslemID) AS nStokIslemID FROM         tbStokFisiDetayi")
        Dim kayitsayisi = sorgu_sayi(cmd.ExecuteScalar, 0) + 1
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_nStokIslemID_MERKEZ() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SELECT     nSonID FROM         tbStokSiraNo WHERE     (nSiraIndex = 1)")
        Dim kayitsayisi = sorgu_sayi(cmd.ExecuteScalar, 0) + 1
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub fis_detay_fisno_degistir(ByVal nstokIslemID As String)
        'kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        'sorgu(sorgu_query("SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("UPDATE    tbStokSiraNo SET              nSonID = '" & nstokIslemID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function tbStokFisidetay_kaydet_yeni(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As String, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, Optional ByVal bTransferGuncelle As Boolean = False) As Int64
        Dim sSet As String
        If connection.Contains("Provider=SQLOLEDB.1") = True Then
            sSet = "SET DATEFORMAT " & sDateFormat & ""
        Else
            sSet = ""
        End If
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'nStokFisiID = "NULL"
        'nIrsaliyeFisiID = "NULL"
        cmd.CommandText = sorgu_query("" & sSet & " INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', '" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", 0,  '" & nAlisverisID & "',NULL,NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nIslemID = cmd.ExecuteScalar
        If bTransferGuncelle = True And Trim(sFisTipi) = "T" Then
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokFisiDetayi Set nTransferID = " & nIslemID & " Where nIslemID = " & nTransferID & ""
            cmd.ExecuteNonQuery()
        End If
        Return nIslemID
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub tbAlisVeris_toplam_kaydet_degistir(ByVal nAlisVerisID As String, ByVal nGirisCikis As Int64, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi As Decimal, ByVal lDipIskontoTutari As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lPesinat As Decimal, ByVal nVadeFarkiYuzdesi As Decimal, ByVal nVadeKdvOrani As Decimal, ByVal lVadeKdvMatrahi As Decimal, ByVal lVadeKdv As Decimal, ByVal lVadeFarki As Decimal, ByVal lNetTutar As Decimal, ByVal sYaziIle As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("UPDATE    tbAlisVeris SET              nGirisCikis = " & nGirisCikis & ",lToplamMiktar = " & lToplamMiktar & ", lMalBedeli = " & lMalBedeli & ", lMalIskontoTutari = " & lMalIskontoTutari & ", nDipIskontoYuzdesi = " & nDipIskontoYuzdesi & ", lDipIskontoTutari = " & lDipIskontoTutari & ", nKdvOrani1 = " & nKdvOrani1 & ", lKdvMatrahi1 = " & lKdvMatrahi1 & ", lKdv1 = " & lKdv1 & ", nKdvOrani2 = " & nKdvOrani2 & ", lKdvMatrahi2 = " & lKdvMatrahi2 & ", lKdv2 = " & lKdv2 & ", nKdvOrani3 = " & nKdvOrani3 & ", lKdvMatrahi3 = " & lKdvMatrahi3 & ", lKdv3 = " & lKdv3 & ", nKdvOrani4 = " & nKdvOrani4 & ", lKdvMatrahi4 = " & lKdvMatrahi4 & ", lKdv4 = " & lKdv4 & ", nKdvOrani5 = " & nKdvOrani5 & ", lKdvMatrahi5 = " & lKdvMatrahi5 & ", lKdv5 = " & lKdv5 & ", lPesinat = " & lPesinat & ", nVadeFarkiYuzdesi = " & nVadeFarkiYuzdesi & ", nVadeKdvOrani = " & nVadeKdvOrani & ", lVadeKdvMatrahi = " & lVadeKdvMatrahi & ", lVadeKdv = " & lVadeKdv & ", lVadeFarki = " & lVadeFarki & ", lNetTutar = " & lNetTutar & ", sYaziIle = '" & sYaziIle & "'  WHERE nAlisVerisID = '" & nAlisVerisID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function sorgu_nOdemeID(ByVal sDepo As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query(" SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 2)")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_lMakbuzNo(ByVal sDepo As String, ByVal nOdemeKodu As Integer) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SELECT     MAX(lMakbuzNo) as lMakbuzNo FROM         tbOdeme WHERE     (sMagaza = '" & sDepo & "') and nOdemeKodu=" & nOdemeKodu & "")
        Dim kayitsayisi = sorgu_sayi(cmd.ExecuteScalar, 0) + 1
        Return kayitsayisi
    End Function
    Public Function sorgu_lMakbuzNo_varmi(ByVal sDepo As String, ByVal nAlisVerisID As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SELECT     MAX(lMakbuzNo) AS lMakbuzNo FROM         tbOdeme WHERE     (sMagaza = '" & sDepo & "') and (nOdemeKodu = 1) AND (nAlisverisID = '" & nAlisVerisID & "')")
        Dim kayitsayisi = sorgu_sayi(cmd.ExecuteScalar, 0)
        Return kayitsayisi
    End Function
    Private Sub lMakbuzNo_degistir(ByVal nSonID As Int64, ByVal sDepo As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        nSonID += 1
        cmd.CommandText = sorgu_query(" UPDATE    tbStokFisNolar SET              lPerakendeFatura1 ='" & nSonID & "' WHERE     (sDepo = '" & sDepo & "')")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Function sorgu_nTaksitID(ByVal sDepo As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query(" SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 3)")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_nTaksitID_lKalan(ByVal nTaksitID As String) As Decimal
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query(" SELECT ISNULL(lTutari - (SELECT ISNULL(SUM(lOdemeTutar) , 0) FROM tbOdeme WHERE nTaksitID = tbTaksit.nTaksitID), 0) AS Kalan FROM tbTaksit Where nTaksitID = '" & nTaksitID & "' ")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub tbAvSirano_kaydet_yeni(ByVal sDepo As String, ByVal nSiraIndex As Integer, ByVal sAciklama As String, ByVal nSonID As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("INSERT INTO tbAVSiraNo (sDepo, nSiraIndex, sAciklama, nSonID) VALUES     ('" & sDepo & "', " & nSiraIndex & ", '" & sAciklama & "', " & nSonID & " )")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbAvSiraNo_kaydet_degistir(ByVal sMagaza As String, ByVal nSiraIndex As Int64, ByVal nSonID As Int64)
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAVSiraNo SET              nSonID = nSonID WHERE     (sDepo = '" & sMagaza & "') AND (nSiraIndex = " & nSiraIndex & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbOdeme_kaydet_yeni(ByVal nOdemeID As String, ByVal nAlisverisID As String, ByVal sOdemeSekli As String, ByVal nOdemeKodu As Int64, ByVal sKasiyerRumuzu As String, ByVal dteOdemeTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal lOdemeTutar As Decimal, ByVal sDovizCinsi As String, ByVal lDovizTutar As Decimal, ByVal lMakbuzNo As String, ByVal lOdemeNo As String, ByVal nTaksitID As String, ByVal nIadeAlisverisID As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal nKasaNo As Int64, ByVal sKartNo As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sMagaza As String)
        Dim sSet As String = ""
        If connection.Contains("Provider=SQLOLEDB.1") = True Then
            sSet = "SET DATEFORMAT " & sDateFormat & ""
        End If
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query(" " & sSet & " INSERT INTO tbOdeme                       (nOdemeID, nAlisverisID, sOdemeSekli, nOdemeKodu, sKasiyerRumuzu, dteOdemeTarihi, dteValorTarihi, lOdemeTutar, sDovizCinsi, lDovizTutar, lMakbuzNo, lOdemeNo, nTaksitID, nIadeAlisverisID, bMuhasebeyeIslendimi, nKasaNo, sKartNo, sKullaniciAdi, dteKayitTarihi, sMagaza) VALUES     ('" & nOdemeID & "', '" & nAlisverisID & "', '" & sOdemeSekli & "', " & nOdemeKodu & ", '" & sKasiyerRumuzu & "', '" & dteOdemeTarihi & "', '" & dteValorTarihi & "', " & lOdemeTutar & ", '" & sDovizCinsi & "', " & lDovizTutar & ", " & lMakbuzNo & ", " & lOdemeNo & ", '" & nTaksitID & "', '" & nIadeAlisverisID & "', " & bMuhasebeyeIslendimi & ", " & nKasaNo & ", '" & sKartNo & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sMagaza & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbOdeme_kaydet_degistir(ByVal nOdemeID As String, ByVal nAlisverisID As String, ByVal sOdemeSekli As String, ByVal nOdemeKodu As Int64, ByVal sKasiyerRumuzu As String, ByVal dteOdemeTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal lOdemeTutar As Decimal, ByVal sDovizCinsi As String, ByVal lDovizTutar As Decimal, ByVal lMakbuzNo As String, ByVal lOdemeNo As String, ByVal nTaksitID As String, ByVal nIadeAlisverisID As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal nKasaNo As Int64, ByVal sKartNo As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sMagaza As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query(" UPDATE    tbOdeme SET              nAlisverisID = '" & nAlisverisID & "', sOdemeSekli = '" & sOdemeSekli & "', nOdemeKodu = " & nOdemeKodu & ", sKasiyerRumuzu = '" & sKasiyerRumuzu & "', dteOdemeTarihi = '" & dteOdemeTarihi & "', dteValorTarihi = '" & dteValorTarihi & "', lOdemeTutar = " & lOdemeTutar & ", sDovizCinsi = '" & sDovizCinsi & "', lDovizTutar = " & lDovizTutar & ", lMakbuzNo = '" & lMakbuzNo & "', lOdemeNo = '" & lOdemeNo & "', nTaksitID = '" & nTaksitID & "', nIadeAlisverisID = '" & nIadeAlisverisID & "', bMuhasebeyeIslendimi = " & bMuhasebeyeIslendimi & ", nKasaNo = " & nKasaNo & ", sKartNo = '" & sKartNo & "', sKullaniciAdi = '" & sKullaniciAdi & "', dteKayitTarihi = '" & dteKayitTarihi & "', sMagaza = '" & sMagaza & "' Where nOdemeID = '" & nOdemeID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbOdeme_kaydet_sil(ByVal nOdemeID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query(" DELETE    From tbOdeme  Where nOdemeID = '" & nOdemeID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbTaksit_kaydet_yeni(ByVal nTaksitID As String, ByVal nAlisverisID As String, ByVal dteTarihi As String, ByVal lTutari As Decimal)
        Dim sSet As String = ""
        If connection.Contains("Provider=SQLOLEDB.1") = True Then
            sSet = "SET DATEFORMAT " & sDateFormat & ""
        End If
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query(" " & sSet & " INSERT INTO tbTaksit (nTaksitID, nAlisverisID, dteTarihi, lTutari) VALUES     ('" & nTaksitID & "', '" & nAlisverisID & "', '" & dteTarihi & "', " & lTutari & ")")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbTaksit_kaydet_degistir(ByVal nTaksitID As String, ByVal nAlisverisID As String, ByVal dteTarihi As String, ByVal lTutari As Decimal)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query(" UPDATE    tbTaksit SET              dteTarihi = '" & dteTarihi & "', lTutari = " & lTutari & " Where nTaksitID = '" & nTaksitID & "' and nAlisVerisID = '" & nAlisverisID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbTaksitleri_kaydet_sil(ByVal nAlisverisID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query(" DELETE    tbTaksit Where nAlisVerisID = '" & nAlisverisID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbTaksit_kaydet_sil(ByVal nTaksitID As String, ByVal nAlisverisID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query(" DELETE    tbTaksit Where nTaksitID = '" & nTaksitID & "' and nAlisVerisID = '" & nAlisverisID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function tbTaksit(ByVal nMusteriID As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.lKodu AS kodu, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN, MONTH(tbTaksit.dteTarihi) AS AY, YEAR(tbTaksit.dteTarihi) AS YIL, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbAlisVeris.nAlisverisID, tbTaksit.nTaksitID,tbMusteri.sAdi, tbMusteri.sSoyadi,tbAlisVeris.sAlisverisYapanAdi, tbAlisVeris.sAlisverisYapanSoyadi,ROUND(CAST(GETDATE() - (CAST(tbTaksit.dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & nMusteriID & ") GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo,tbAlisVeris.sAlisverisYapanAdi, tbAlisVeris.sAlisverisYapanSoyadi, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbMusteri.sAdi, tbMusteri.sSoyadi,  tbAlisVeris.nAlisverisID, tbTaksit.nTaksitID HAVING (ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) <> 0) ORDER BY tbTaksit.dteTarihi")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "DATATABLE1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_nfirmaID(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nFirmaID,0) AS nFirmaID FROM         tbFirma " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_nMusteriID(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nMusteriID,0) AS nMusteriID FROM         tbMusteri " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_tbMusteri(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "') "
        ds_tbMusteri = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbMusteri " & kriter & ""))
    End Sub
    Private Sub dataload_tbMusteriNufusu(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (tbMusteri.lKodu = '" & kod & "') "
        ds_tbMusteriNufusu = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbMusteriNufusu.* FROM         tbMusteriNufusu INNER JOIN                       tbMusteri ON tbMusteriNufusu.nMusteriID = tbMusteri.nMusteriID " & kriter & ""))
    End Sub
    Private Function tbMusteri_kaydet_yeni(ByVal sMagaza As String, ByVal lKodu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal nCinsiyet As Int64, ByVal lAylikGelir As Decimal, ByVal dteKartAcilisTarihi As DateTime, ByVal nIskontoPesin As Decimal, ByVal nIskontoKredili As Decimal, ByVal sUnvan As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal bYazismaEvAdresinemi As Integer, ByVal sEmail As String, ByVal sIsYeriAdi As String, ByVal sIsAdresi1 As String, ByVal sIsAdresi2 As String, ByVal sIsSemt As String, ByVal sIsIl As String, ByVal sIsPostaKodu As String, ByVal sIsTelefonu As String, ByVal sEvAdresi1 As String, ByVal sEvAdresi2 As String, ByVal sEvSemt As String, ByVal sEvPostaKodu As String, ByVal sEvIl As String, ByVal sEvTelefonu As String, ByVal sSigortaNo As String, ByVal bEvlimi As Int64, ByVal dteEvlilikTarihi As DateTime, ByVal dteDogumTarihi As DateTime, ByVal sDogumYeri As String, ByVal sEhliyetNo As String, ByVal sKanGrubu As String, ByVal sHitap As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal sGSM As String, ByVal sFax As String, ByVal sResimAdi As String) As Int64
        cmd.Connection = con
        con.ConnectionString = connection_resmi
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
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteriSinifi (nMusteriID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, sSinifKodu11, sSinifKodu12, sSinifKodu13, sSinifKodu14, sSinifKodu15) VALUES     (" & nMusteriID & ", '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "', '" & sSinifKodu6 & "', '" & sSinifKodu7 & "', '" & sSinifKodu8 & "', '" & sSinifKodu9 & "', '" & sSinifKodu10 & "',  '" & sSinifKodu11 & "', '" & sSinifKodu12 & "', '" & sSinifKodu13 & "', '" & sSinifKodu14 & "', '" & sSinifKodu15 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriKredisi_kaydet_yeni(ByVal nMusteriID As String, ByVal lKrediLimiti As String, ByVal dteKrediLimitiTarihi As DateTime, ByVal dteKrediAcilisTarihi As DateTime, ByVal dteSonKullanmaTarihi As DateTime, ByVal bOzelMusterimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteriKredisi (nMusteriID, lKrediLimiti, dteKrediLimitiTarihi, dteKrediAcilisTarihi, dteSonKullanmaTarihi, bOzelMusterimi, sKullaniciAdi, dteKayitTarihi) VALUES     ('" & nMusteriID & "', " & lKrediLimiti & ", '" & dteKrediLimitiTarihi & "', '" & dteKrediAcilisTarihi & "', '" & dteSonKullanmaTarihi & "', " & bOzelMusterimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriKarti_kaydet_yeni(ByVal nMusteriID As String, ByVal nKartNo As String, ByVal sAciklama As String, ByVal dteSonKullanmaTarihi As DateTime, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteriKarti (nMusteriID, nKartNo, sAciklama, dteSonKullanmaTarihi, sKullaniciAdi, dteKayitTarihi) VALUES     ('" & nMusteriID & "',  SUBSTRING(CAST(NEWID() AS NVARCHAR(36)), 0, 9), N'" & sAciklama & "', '" & dteSonKullanmaTarihi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriOzelNot_kaydet_yeni(ByVal nMusteriID As String, ByVal dteGirisTarihi As DateTime, ByVal sText As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteriOzelNot (nMusteriID, dteGirisTarihi, sText, sKullaniciAdi, dteKayitTarihi) VALUES     ('" & nMusteriID & "', '" & dteGirisTarihi & "', '" & sText & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriCocugu_kaydet_yeni(ByVal nMusteriID As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal nCinsiyet As Int64, ByVal dteDogumTarihi As DateTime, ByVal sDogumYeri As String, ByVal sOzelNot As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteriCocugu (nMusteriID, sAdi, sSoyadi, nCinsiyet, dteDogumTarihi, sDogumYeri, sOzelNot) VALUES     ('" & nMusteriID & "', SUBSTRING(CAST(NEWID() AS NVARCHAR(36)), 0, 9), SUBSTRING(CAST(NEWID() AS NVARCHAR(36)), 0, 9), " & nCinsiyet & ", '" & dteDogumTarihi & "', '" & sDogumYeri & "', '" & sOzelNot & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriKefil_kaydet_yeni(ByVal Tablo As String, ByVal nMusteriID As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal sUnvan As String, ByVal sEmail As String, ByVal sIsYeriAdi As String, ByVal sIsAdresi1 As String, ByVal sIsAdresi2 As String, ByVal sIsSemt As String, ByVal sIsPostaKodu As String, ByVal sIsIl As String, ByVal sIsTelefonu As String, ByVal sEvAdresi1 As String, ByVal sEvAdresi2 As String, ByVal sEvSemt As String, ByVal sEvPostaKodu As String, ByVal sEvIl As String, ByVal sEvTelefonu As String, ByVal lAylikGelir As Decimal, ByVal sSigortaNo As String, ByVal sHitap As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO " & Tablo & " (nMusteriID, sAdi, sSoyadi, sUnvan, sEmail, sIsYeriAdi, sIsAdresi1, sIsAdresi2, sIsSemt, sIsPostaKodu, sIsIl, sIsTelefonu, sEvAdresi1, sEvAdresi2, sEvSemt, sEvPostaKodu, sEvIl, sEvTelefonu, lAylikGelir, sSigortaNo, sHitap, sKullaniciAdi, dteKayitTarihi) VALUES     ('" & nMusteriID & "', '" & sAdi & "', '" & sSoyadi & "', '" & sUnvan & "', '" & sEmail & "', '" & sIsYeriAdi & "', '" & sIsAdresi1 & "', '" & sIsAdresi2 & "', '" & sIsSemt & "', '" & sIsPostaKodu & "', '" & sIsIl & "', '" & sIsTelefonu & "', '" & sEvAdresi1 & "', '" & sEvAdresi2 & "', '" & sEvSemt & "', '" & sEvPostaKodu & "', '" & sEvIl & "', '" & sEvTelefonu & "', " & lAylikGelir & ", '" & sSigortaNo & "', '" & sHitap & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "') ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriNufusu_kaydet_yeni(ByVal nMusteriID As String, ByVal sDin As String, ByVal sKutukIl As String, ByVal sKutukIlce As String, ByVal sKutukMahalle As String, ByVal sKutukCiltNo As String, ByVal sKutukSiraNo As String, ByVal dteNufusCuzdanTarihi As DateTime, ByVal sCuzdanVerilenYer As String, ByVal sCuzdanVerNedeni As String, ByVal sCuzdanKayitNo As String, ByVal sAnneAdi As String, ByVal sBabaAdi As String, ByVal sAileAdresi1 As String, ByVal sAileAdresi2 As String, ByVal sAileSemt As String, ByVal sAilePostaKodu As String, ByVal sAileIl As String, ByVal sAileTelefonu As String, ByVal sHitapAnne As String, ByVal sHitapBaba As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteriNufusu (nMusteriID, sDin, sKutukIl, sKutukIlce, sKutukMahalle, sKutukCiltNo, sKutukSiraNo, dteNufusCuzdanTarihi, sCuzdanVerilenYer, sCuzdanVerNedeni, sCuzdanKayitNo, sAnneAdi, sBabaAdi, sAileAdresi1, sAileAdresi2, sAileSemt, sAilePostaKodu, sAileIl, sAileTelefonu, sHitapAnne, sHitapBaba) VALUES     ('" & nMusteriID & "', '" & sDin & "', '" & sKutukIl & "', '" & sKutukIlce & "', '" & sKutukMahalle & "', '" & sKutukCiltNo & "', '" & sKutukSiraNo & "', '" & dteNufusCuzdanTarihi & "','" & sCuzdanVerilenYer & "', '" & sCuzdanVerNedeni & "', '" & sCuzdanKayitNo & "', '" & sAnneAdi & "', '" & sBabaAdi & "', '" & sAileAdresi1 & "', '" & sAileAdresi2 & "', '" & sAileSemt & "', '" & sAilePostaKodu & "', '" & sAileIl & "', '" & sAileTelefonu & "', '" & sHitapAnne & "', '" & sHitapBaba & "') ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_stok_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbStok " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_nStokID(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nStokID, 0) AS nStokID FROM         tbStok " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        conn.Close()
        Return kayitsayisi
    End Function
    Private Sub dataload_stok(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbStok " & kriter & ""))
    End Sub
    Private Sub dataload_stok_barkod(ByVal nStokID As String)
        Dim kriter
        kriter = "WHERE (nStokID = '" & nStokID & "') "
        ds_stok_barkod = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbStokBarkodu " & kriter & ""))
    End Sub
    Private Sub dataload_stok_sinif(ByVal nStokID As String)
        Dim kriter
        kriter = "WHERE (nStokID = '" & nStokID & "') "
        ds_stok_sinif = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbStokSinifi " & kriter & ""))
    End Sub
    Private Sub dataload_stok_sinif1(ByVal sStokSinifi As String, ByVal sinifno As Integer)
        Dim kriter
        kriter = "WHERE (sSinifKodu = '" & sStokSinifi & "') "
        ds_stok_sinif = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM          tbSSinif" & sinifno & " " & kriter & ""))
    End Sub
    Private Sub dataload_cari(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        ds_firma = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirma " & kriter & ""))
    End Sub
    Private Sub dataload_sRenk(ByVal sRenk As String)
        Dim kriter
        kriter = "WHERE (sRenk = '" & sRenk & "') "
        ds_renk = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbRenk " & kriter & ""))
    End Sub
    Public Function sorgu_Renk_kontrol(ByVal sRenk As String) As Int64
        Dim kriter
        kriter = "WHERE (sRenk = '" & sRenk & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbRenk " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_Sinif_kontrol(ByVal sSinifKodu As String, ByVal sinifno As Integer) As Int64
        Dim kriter
        kriter = "WHERE (sSinifKodu = '" & sSinifKodu & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM          tbSSinif" & sinifno & " " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Function stok_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal sKisaAdi As String, ByVal nStokTipi As Int64, ByVal sBedenTipi As String, ByVal sKavalaTipi As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sKavala As String, ByVal sBirimCinsi1 As String, ByVal sBirimCinsi2 As String, ByVal nIskontoYuzdesi As Decimal, ByVal sKdvTipi As String, ByVal nTeminSuresi As Decimal, ByVal lAsgariMiktar As Decimal, ByVal lAzamiMiktar As Decimal, ByVal sOzelNot As String, ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bEksiyeDusulebilirmi As Byte, ByVal sDefaultAsortiTipi As String, ByVal bEksideUyarsinmi As Byte, ByVal bOTVVar As Byte, ByVal sOTVTipi As String, ByVal nIskontoYuzdesiAV As Decimal, ByVal bEk1 As Byte, ByVal nEk2 As String) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStok                       (sKodu, sAciklama, sKisaAdi, nStokTipi, sBedenTipi, sKavalaTipi, sRenk, sBeden, sKavala, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi, nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, sModel, sKullaniciAdi, dteKayitTarihi, bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2) VALUES     ('" & sKodu & "', N'" & sAciklama & "', '" & sKisaAdi & "', '" & nStokTipi & "', '" & sBedenTipi & "', '" & sKavalaTipi & "', '" & sRenk & "', '" & sBeden & "', '" & sKavala & "', '" & sBirimCinsi1 & "', '" & sBirimCinsi2 & "', " & nIskontoYuzdesi & " , '" & sKdvTipi & "', " & nTeminSuresi & " , " & lAsgariMiktar & " , " & lAzamiMiktar & " , '" & sOzelNot & "', '" & nFiyatlandirma & "', '" & sModel & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bEksiyeDusulebilirmi & " , '" & sDefaultAsortiTipi & "', " & bEksideUyarsinmi & " , " & bOTVVar & " , '" & sOTVTipi & "' , '" & nIskontoYuzdesiAV & "', '" & bEk1 & "', '" & nEk2 & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
    End Function
    Private Sub tbStok_kaydet_duzelt(ByVal sKodu As String, ByVal sAciklama As String, ByVal sKisaAdi As String, ByVal nStokTipi As Int64, ByVal sBedenTipi As String, ByVal sKavalaTipi As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sKavala As String, ByVal sBirimCinsi1 As String, ByVal sBirimCinsi2 As String, ByVal nIskontoYuzdesi As Decimal, ByVal sKdvTipi As String, ByVal nTeminSuresi As Decimal, ByVal lAsgariMiktar As Decimal, ByVal lAzamiMiktar As Decimal, ByVal sOzelNot As String, ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bEksiyeDusulebilirmi As Byte, ByVal sDefaultAsortiTipi As String, ByVal bEksideUyarsinmi As Byte, ByVal bOTVVar As Byte, ByVal sOTVTipi As String, ByVal nIskontoYuzdesiAV As Decimal, ByVal bEk1 As Byte, ByVal nEk2 As String, ByVal nPrim As Decimal)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStok SET              sAciklama = N'" & sAciklama & "', sKisaAdi = N'" & sKisaAdi & "', nStokTipi = " & nStokTipi & ", sBedenTipi = N'" & sBedenTipi & "', sKavalaTipi = N'" & sKavalaTipi & "', sBirimCinsi1 = N'" & sBirimCinsi1 & "', sBirimCinsi2 = N'" & sBirimCinsi2 & "', nIskontoYuzdesi = " & nIskontoYuzdesi & ",sKdvTipi = N'" & sKdvTipi & "', nTeminSuresi = N'" & nTeminSuresi & "', lAsgariMiktar = " & lAsgariMiktar & ", lAzamiMiktar = " & lAzamiMiktar & ", sOzelNot = N'" & sOzelNot & "', nFiyatlandirma = " & nFiyatlandirma & ",bEksiyeDusulebilirmi = " & bEksiyeDusulebilirmi & ", sDefaultAsortiTipi = N'" & sDefaultAsortiTipi & "', bEksideUyarsinmi = " & bEksideUyarsinmi & ", bOTVVar = " & bOTVVar & ", sOTVTipi = N'" & sOTVTipi & "', nIskontoYuzdesiAV =" & nIskontoYuzdesiAV & ", bEk1 = " & bEk1 & ", nEk2 = " & nEk2 & ",nPrim=" & nPrim & "  Where sModel= N'" & sModel & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
        con = Nothing
    End Sub
    Private Sub stok_renk_kaydet_yeni(ByVal sRenk As String, ByVal sRenkAdi As String, ByVal lRenkNo As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbRenk                       (sRenk, sRenkAdi, lRenkNo) VALUES     ('" & sRenk & "', '" & sRenkAdi & "', '" & lRenkNo & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub stok_sinif_kaydet_yeni(ByVal sSinifKodu As String, ByVal sAciklama As String, ByVal sinifno As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSSinif" & sinifno & "                       (sSinifKodu, sAciklama) VALUES     ('" & sSinifKodu & "', '" & sAciklama & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub stok_barkod_kaydet_yeni(ByVal nStokID As Int64, ByVal sBarkod As String, ByVal nKisim As Int64, ByVal nFirmaID As String, ByVal sKarsiStokKodu As String, ByVal sKarsiStokAciklama As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokBarkodu                       (nStokID, sBarkod, nKisim, nFirmaID, sKarsiStokKodu, sKarsiStokAciklama) VALUES     ('" & nStokID & "', '" & sBarkod & "', '" & nKisim & "', '" & nFirmaID & "', '" & sKarsiStokKodu & "', '" & sKarsiStokAciklama & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub stok_siniflari_kaydet_yeni(ByVal nStokID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String, ByVal sSinifKodu6 As String, ByVal sSinifKodu7 As String, ByVal sSinifKodu8 As String, ByVal sSinifKodu9 As String, ByVal sSinifKodu10 As String, ByVal sSinifKodu11 As String, ByVal sSinifKodu12 As String, ByVal sSinifKodu13 As String, ByVal sSinifKodu14 As String, ByVal sSinifKodu15 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokSinifi                       (nStokID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, sSinifKodu11, sSinifKodu12, sSinifKodu13, sSinifKodu14, sSinifKodu15) VALUES     ('" & nStokID & "', '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "', '" & sSinifKodu6 & "', '" & sSinifKodu7 & "', '" & sSinifKodu8 & "', '" & sSinifKodu9 & "', '" & sSinifKodu10 & "', '" & sSinifKodu11 & "', '" & sSinifKodu12 & "', '" & sSinifKodu13 & "', '" & sSinifKodu14 & "', '" & sSinifKodu15 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokFiyati_ekle_yeni(ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String, ByVal lFiyat As Decimal, ByVal dteFiyatTespitTarihi As DateTime, ByVal sKullaniciAdi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection_resmi
        cmd.Connection = con
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = "set implicit_transactions on "
        cmd.ExecuteNonQuery()
        If nFiyatlandirma = 0 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & sKullaniciAdi & "' , getdate ()  from tbStok where sModel = '" & sModel & "' and nStokID NOT IN (Select nStokID from tbStokFiyati Where sFiyatTipi = '" & sFiyatTipi & "')"
        ElseIf nFiyatlandirma = 1 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & sKullaniciAdi & "' , getdate ()  from tbStok where sModel = '" & sModel & "' and sRenk ='" & sRenk & "' and nStokID NOT IN (Select nStokID from tbStokFiyati Where sFiyatTipi = '" & sFiyatTipi & "')"
        ElseIf nFiyatlandirma = 2 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & sKullaniciAdi & "' , getdate ()  from tbStok where sModel = '" & sModel & "' and sRenk ='" & sRenk & "' and sBeden ='" & sBeden & "' and nStokID NOT IN (Select nStokID from tbStokFiyati Where sFiyatTipi = '" & sFiyatTipi & "')"
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
    Private Sub tbBirimCinsi_kaydet_yeni(ByVal sBirimCinsi As String, ByVal sAciklama As String, ByVal nOndalik As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbBirimCinsi (sBirimCinsi, sAciklama, nOndalik) VALUES     ('" & sBirimCinsi & "', N'" & sAciklama & "', " & nOndalik & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokBirimCevrimi_kaydet_yeni(ByVal sBirimCinsi As String, ByVal lOran As Decimal, ByVal sModel As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokBirimCevrimi   select nStokID , '" & sBirimCinsi & "' , " & lOran & ",0 from tbStok where sModel = '" & sModel & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbSatici_kaydet_yeni(ByVal sSaticiRumuzu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal nPrim As Decimal, ByVal sAciklama As String, ByVal lSabitPrim As Decimal, ByVal lPrim1Baslangic As Decimal, ByVal lPrim1Bitis As Decimal, ByVal lPrim1Oran As Decimal, ByVal lPrim2Baslangic As Decimal, ByVal lPrim2Bitis As Decimal, ByVal lPrim2Oran As Decimal, ByVal lPrim3Baslangic As Decimal, ByVal lPrim3Bitis As Decimal, ByVal lPrim3Oran As Decimal, ByVal lPrim4Baslangic As Decimal, ByVal lPrim4Bitis As Decimal, ByVal lPrim4Oran As Decimal, ByVal lPrim5Baslangic As Decimal, ByVal lPrim5Bitis As Decimal, ByVal lPrim5Oran As Decimal, ByVal bAktif As Byte)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSatici(sSaticiRumuzu, sAdi, sSoyadi, nPrim, sAciklama, lSabitPrim, lPrim1Baslangic, lPrim1Bitis, lPrim1Oran, lPrim2Baslangic, lPrim2Bitis, lPrim2Oran, lPrim3Baslangic, lPrim3Bitis, lPrim3Oran, lPrim4Baslangic, lPrim4Bitis, lPrim4Oran, lPrim5Baslangic, lPrim5Bitis, lPrim5Oran, bAktif) VALUES ('" & sSaticiRumuzu & "', '" & sAdi & "', '" & sSoyadi & "', " & nPrim & ", '" & sAciklama & "', " & lSabitPrim & ", " & lPrim1Baslangic & ", " & lPrim1Bitis & ", " & lPrim1Oran & ", " & lPrim2Baslangic & ", " & lPrim2Bitis & ", " & lPrim2Oran & ", " & lPrim3Baslangic & ", " & lPrim3Bitis & ", " & lPrim3Oran & ", " & lPrim4Baslangic & ", " & lPrim4Bitis & ", " & lPrim4Oran & ", " & lPrim5Baslangic & ", " & lPrim5Bitis & ", " & lPrim5Oran & ", " & bAktif & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFiyatTipi_kaydet_yeni(ByVal sFiyatTipi As String, ByVal sAciklama As String, ByVal nAST As Int64, ByVal bKdvDahilmi As Byte, ByVal bDovizeBaglimi As Byte, ByVal sDovizCinsi As String, ByVal sHangiKur As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFiyatTipi (sFiyatTipi, sAciklama, nAST, bKdvDahilmi, bDovizeBaglimi, sDovizCinsi, sHangiKur, aktifDepo) VALUES     ('" & sFiyatTipi & "', N'" & sAciklama & "', " & nAST & ", " & bKdvDahilmi & ", " & bDovizeBaglimi & ", '" & sDovizCinsi & "', '" & sHangiKur & "', '')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbOdemeSekli_kaydet_yeni(ByVal sOdemeSekli As String, ByVal sAciklama As String, ByVal nOdemeTipi As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbOdemeSekli (sOdemeSekli, sAciklama, nOdemeTipi) VALUES     ('" & sOdemeSekli & "', N'" & sAciklama & "', '" & nOdemeTipi & "')")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        con.Close()
    End Sub
    Private Sub tbDepo_kaydet_yeni(ByVal sDepo As String, ByVal sAciklama As String, ByVal nFirmaID As Int64, ByVal sSube As String, ByVal sDepoTipi As String, ByVal sEmail As String, ByVal nKatSayisi As Int64, ByVal nMagazaM2 As Int64, ByVal nDepoM2 As Int64, ByVal sKiraDovizCinsi As String, ByVal lKiraBedeli As Decimal, ByVal dteAcilisTarihi As DateTime, ByVal dteSonDekorasyon As DateTime, ByVal sMudurAdiSoyadi As String, ByVal nPersonelAdeti As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSubeMagaza                       (sSubeMagaza, sAciklama, bIskontolarAyri, bHerFaturaAyriFis, bKdvIskEkTekKalemde, bHerMagazadaAyriSatHesVar, bHareketTipineGoreAyri,  sMasrafYontemi) VALUES     ('" & Microsoft.VisualBasic.Right(Trim(sDepo), 3) & "', N'" & sAciklama & "', 0, 0, 0, 0, 0, '')")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbDepo (sDepo, sAciklama, nFirmaID, sSube, sDepoTipi, sEmail, nKatSayisi, nMagazaM2, nDepoM2, sKiraDovizCinsi, lKiraBedeli, dteAcilisTarihi,  dteSonDekorasyon, sMudurAdiSoyadi, nPersonelAdeti) VALUES     ('" & sDepo & "', N'" & sAciklama & "', " & nFirmaID & ", '" & sSube & "', '" & sDepoTipi & "', '" & sEmail & "', " & nKatSayisi & ", " & nMagazaM2 & ", " & nDepoM2 & ", '" & sKiraDovizCinsi & "', " & lKiraBedeli & ", '" & dteAcilisTarihi & "', '" & dteSonDekorasyon & "', '" & sMudurAdiSoyadi & "', " & nPersonelAdeti & ")")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbHareketTipi                       (sHareketTipi, sAciklama, bIkinciFormmu) VALUES     ('" & Microsoft.VisualBasic.Right(Trim(sDepo), 3) & "', N'" & sAciklama & "', 0)")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        con.Close()
        Try
            tbAvSirano_kaydet_yeni(sDepo, 1, "Alisveris Son Sira No", 1)
            tbAvSirano_kaydet_yeni(sDepo, 2, "Odeme     Son Sira No", 1)
            tbAvSirano_kaydet_yeni(sDepo, 3, "Taksit    Son Sira No", 1)
            tbAvSirano_kaydet_yeni(sDepo, 4, "Masraf    Son Sira No", 1)
            tbAvSirano_kaydet_yeni(sDepo, 5, "Siparis   Son Sira No", 1)
            tbStokFisNolar_kaydet_yeni(sDepo, 0, 500000000, 0, 500000000, 0, 500000000, 0, 500000000, 0, 500000000, 0, 500000000, 0, 500000000, 0, 500000000, 0, 500000000, 0, 500000000, 0, 500000000, 0, 0, 500000000)
            tbParamAlisVeris_kaydet_yeni(1, 1, 1, 1, "", 1, 1, 1, 1, 45, 0, "Eşit Dağıt", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "Fatura", "", "", "", "", "", "", "", "", "", "", "", "", 0, 1, 1, 1, 1, 31, 0, 0, 31, 0, 0, 31, 0, 0, 1, 0, 1, 1, 1, "", 1, 1, 1, 1, "", 1, 1, 1, 1, 1, "", "", 1, 1, sDepo, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1, 1, 1, "", 1, 1, 1, 0, 0, "", "", "", "", "", "", "", "", "", "", "", "", "", "", 0, 1, 1, 0, 0, 0, 0)
        Catch ex As Exception
        End Try
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFisNolar_kaydet_yeni(ByVal sDepo As String, ByVal lDepoCikis1 As Int64, ByVal lDepoCikis2 As Int64, ByVal lTransferFisi1 As Int64, ByVal lTransferFisi2 As Int64, ByVal lSevkIrsaliyesi1 As Int64, ByVal lSevkIrsaliyesi2 As Int64, ByVal lSevkFaturasi1 As Int64, ByVal lSevkFaturasi2 As Int64, ByVal lKonsinyeIrsaliye1 As Int64, ByVal lKonsinyeIrsaliye2 As Int64, ByVal lKonsinyeFatura1 As Int64, ByVal lKonsinyeFatura2 As Int64, ByVal lUretimFisi1 As Int64, ByVal lUretimFisi2 As Int64, ByVal lToptanFatura1 As Int64, ByVal lToptanFatura2 As Int64, ByVal lToptanIrsaliye1 As Int64, ByVal lToptanIrsaliye2 As Int64, ByVal lPerakendeFatura1 As Int64, ByVal lPerakendeFatura2 As Int64, ByVal lPerakendeIade1 As Int64, ByVal lPerakendeIade2 As Int64, ByVal lYazarKasaFisNo As Int64, ByVal lOdemeNo1 As Int64, ByVal lOdemeNo2 As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisNolar (sDepo,lDepoCikis1, lDepoCikis2, lTransferFisi1, lTransferFisi2, lSevkIrsaliyesi1, lSevkIrsaliyesi2, lSevkFaturasi1, lSevkFaturasi2, lKonsinyeIrsaliye1, lKonsinyeIrsaliye2, lKonsinyeFatura1, lKonsinyeFatura2, lUretimFisi1, lUretimFisi2, lToptanFatura1, lToptanFatura2, lToptanIrsaliye1, lToptanIrsaliye2, lPerakendeFatura1, lPerakendeFatura2, lPerakendeIade1, lPerakendeIade2, lYazarKasaFisNo, lOdemeNo1, lOdemeNo2) VALUES     ('" & sDepo & "'," & lDepoCikis1 & ", " & lDepoCikis2 & ", " & lTransferFisi1 & ", " & lTransferFisi2 & ", " & lSevkIrsaliyesi1 & ", " & lSevkIrsaliyesi2 & ", " & lSevkFaturasi1 & ", " & lSevkFaturasi2 & ", " & lKonsinyeIrsaliye1 & ", " & lKonsinyeIrsaliye2 & ", " & lKonsinyeFatura1 & ", " & lKonsinyeFatura2 & ", " & lUretimFisi1 & ", " & lUretimFisi2 & ", " & lToptanFatura1 & ", " & lToptanFatura2 & ", " & lToptanIrsaliye1 & ", " & lToptanIrsaliye2 & ", " & lPerakendeFatura1 & ", " & lPerakendeFatura2 & ", " & lPerakendeIade1 & ", " & lPerakendeIade2 & ", " & lYazarKasaFisNo & ", " & lOdemeNo1 & ", " & lOdemeNo2 & ")")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbParamAlisVeris_kaydet_yeni(ByVal bSaticiRumuzuVarmi As Byte, ByVal bEnvanterGosterilsinmi As Byte, ByVal bEksiKontroluVarmi As Byte, ByVal bMalBazindaOdemePlaniVarmi As Byte, ByVal sSabitOdemeKodu As String, ByVal bOdemePlaniDegistirilsinmi As Byte, ByVal bPesinatDegistirilsinmi As Byte, ByVal bTaksitTutDegistirilsinmi As Byte, ByVal bTaksitTarDegistirilsinmi As Byte, ByVal nITMAXG As Int64, ByVal nMinPesinatYuzdesi As Decimal, ByVal sPesinatEksikligiDagilimi As String, ByVal lESPF As Decimal, ByVal lPesinatYuvarlama As Decimal, ByVal lTaksitYuvarlama As Decimal, ByVal bSatisAnindaVadeFarkiVarmi As Byte, ByVal nSatisVadeFarkiYuzdesi As Decimal, ByVal bVFYTaksitleCarpilsinmi As Byte, ByVal nGecikmeVadeFarkiYuzdesi As Decimal, ByVal nGSGG As Decimal, ByVal lGSGT As Decimal, ByVal bVFTS As Byte, ByVal bVadeFarkinaKDVDahilmi As Byte, ByVal sVadeFarkiKdvTipi As String, ByVal sSatisIcinDokulecek As String, ByVal sFaturaFormu1 As String, ByVal sSatisFisiFormu1 As String, ByVal sSenetFormu1 As String, ByVal sOdemeFormu1 As String, ByVal sPesinFormu1 As String, ByVal sIadeFormu1 As String, ByVal sFaturaFormu2 As String, ByVal sSatisFisiFormu2 As String, ByVal sSenetFormu2 As String, ByVal sOdemeFormu2 As String, ByVal sPesinFormu2 As String, ByVal sIadeFormu2 As String, ByVal bTarihDegistirilebilsinmi As Byte, ByVal bLimitAsimiIzinlimi As Byte, ByVal bGecikmeIzinlimi As Byte, ByVal bEskilerIptalEdilsinmi As Byte, ByVal bSatistaMagazaSorulacakmi As Byte, ByVal nAlisGun1 As Integer, ByVal nOdemeTipi1 As Integer, ByVal nOdemeGun1 As Integer, ByVal nAlisGun2 As Integer, ByVal nOdemeTipi2 As Integer, ByVal nOdemeGun2 As Integer, ByVal nAlisGun3 As Integer, ByVal nOdemeTipi3 As Integer, ByVal nOdemeGun3 As Integer, ByVal bMiktarDegistirilsinmi As Byte, ByVal bReyonFisnoVarmi As Byte, ByVal bEanVarmi As Byte, ByVal bTeslimatVarmi As Byte, ByVal nTeslimatGunu As Integer, ByVal sDefaultPesinFiyatTipi As String, ByVal bPFiyatTipiDegistrilsinmi As Byte, ByVal bPesinMalIskontoVarmi As Byte, ByVal bPesinDipIskontoVarmi As Byte, ByVal bPFiyatDegistirilsinmi As Byte, ByVal sDefaultKrediFiyatTipi As String, ByVal bKFiyatTipiDegistrilsinmi As Byte, ByVal bKrediMalIskontoVarmi As Byte, ByVal bKrediDipIskontoVarmi As Byte, ByVal bKFiyatDegistirilsinmi As Byte, ByVal bRaporlarSifrelimi As Byte, ByVal sVadeFarkiFaturaFormu1 As String, ByVal sVadeFarkiFaturaFormu2 As String, ByVal bAgirlikBarkoduVarmi As Byte, ByVal nMinVadeFarkiYuzdesi As Decimal, ByVal sMagazaKodu As String, ByVal bPFiyatSatirdaOlsun As Byte, ByVal bPHediyeCekiBasilacak As Byte, ByVal bPHediyeCekiAlinacak As Byte, ByVal bPOdemeTipineGoreFiyatVar As Byte, ByVal bKFiyatSatirdaOlsun As Byte, ByVal bKHediyeCekiBasilacak As Byte, ByVal bKHediyeCekiAlinacak As Byte, ByVal bKOdemeTipineGoreFiyatVar As Byte, ByVal bStokResmiVar As Byte, ByVal bMusteriResmiVar As Byte, ByVal bKrediKartNoSorsun As Byte, ByVal bDokumdeYaziciSorsun As Byte, ByVal bYalnizSonFaturaYenidenDok As Byte, ByVal bMusteriNotuSatisaGelsin As Byte, ByVal lDefaultMusteriKodu As Int64, ByVal bPIndirimKuponuBasilacak As Byte, ByVal bPIndirimKuponuAlinacak As Byte, ByVal bPPromosyonVar As Byte, ByVal bKPromosyonVar As Byte, ByVal sDefaultHareketTipi As String, ByVal bDovizliGirisVar As Byte, ByVal bEkSoru1 As Byte, ByVal bEkSoru2 As Byte, ByVal nParametre1 As Int64, ByVal nParametre2 As Int64, ByVal sTaxFreeFormu As String, ByVal sDiplomatikFormu As String, ByVal sHediyeCeki As String, ByVal sIndirimKuponu As String, ByVal sPSiparisFormu1 As String, ByVal sPSiparisIadeFormu1 As String, ByVal sPSiparisFormu2 As String, ByVal sPSiparisIadeFormu2 As String, ByVal sKSiparisFormu1 As String, ByVal sKSiparisIadeFormu1 As String, ByVal sKSiparisFormu2 As String, ByVal sKSiparisIadeFormu2 As String, ByVal sYedekFormu1 As String, ByVal sYedekFormu2 As String, ByVal bPartiVar As Byte, ByVal bPSonraTeslimVar As Byte, ByVal bKSonraTeslimVar As Byte, ByVal bEkSoru3 As Byte, ByVal bEkSoru4 As Byte, ByVal bEkSoru5 As Byte, ByVal bEkSoru6 As Byte)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbParamAlisVeris(bSaticiRumuzuVarmi, bEnvanterGosterilsinmi, bEksiKontroluVarmi, bMalBazindaOdemePlaniVarmi, sSabitOdemeKodu, bOdemePlaniDegistirilsinmi, bPesinatDegistirilsinmi, bTaksitTutDegistirilsinmi, bTaksitTarDegistirilsinmi, nITMAXG, nMinPesinatYuzdesi, sPesinatEksikligiDagilimi, lESPF, lPesinatYuvarlama, lTaksitYuvarlama, bSatisAnindaVadeFarkiVarmi, nSatisVadeFarkiYuzdesi, bVFYTaksitleCarpilsinmi, nGecikmeVadeFarkiYuzdesi, nGSGG, lGSGT, bVFTS, bVadeFarkinaKDVDahilmi, sVadeFarkiKdvTipi, sSatisIcinDokulecek, sFaturaFormu1, sSatisFisiFormu1, sSenetFormu1, sOdemeFormu1, sPesinFormu1, sIadeFormu1, sFaturaFormu2, sSatisFisiFormu2, sSenetFormu2, sOdemeFormu2, sPesinFormu2, sIadeFormu2, bTarihDegistirilebilsinmi, bLimitAsimiIzinlimi, bGecikmeIzinlimi, bEskilerIptalEdilsinmi, bSatistaMagazaSorulacakmi, nAlisGun1, nOdemeTipi1, nOdemeGun1, nAlisGun2, nOdemeTipi2, nOdemeGun2, nAlisGun3, nOdemeTipi3, nOdemeGun3, bMiktarDegistirilsinmi, bReyonFisnoVarmi, bEanVarmi, bTeslimatVarmi, nTeslimatGunu, sDefaultPesinFiyatTipi, bPFiyatTipiDegistrilsinmi, bPesinMalIskontoVarmi, bPesinDipIskontoVarmi, bPFiyatDegistirilsinmi, sDefaultKrediFiyatTipi, bKFiyatTipiDegistrilsinmi, bKrediMalIskontoVarmi, bKrediDipIskontoVarmi, bKFiyatDegistirilsinmi, bRaporlarSifrelimi, sVadeFarkiFaturaFormu1, sVadeFarkiFaturaFormu2, bAgirlikBarkoduVarmi, nMinVadeFarkiYuzdesi, sMagazaKodu, bPFiyatSatirdaOlsun, bPHediyeCekiBasilacak, bPHediyeCekiAlinacak, bPOdemeTipineGoreFiyatVar, bKFiyatSatirdaOlsun, bKHediyeCekiBasilacak, bKHediyeCekiAlinacak, bKOdemeTipineGoreFiyatVar, bStokResmiVar, bMusteriResmiVar, bKrediKartNoSorsun, bDokumdeYaziciSorsun, bYalnizSonFaturaYenidenDok, bMusteriNotuSatisaGelsin, lDefaultMusteriKodu, bPIndirimKuponuBasilacak, bPIndirimKuponuAlinacak, bPPromosyonVar, bKPromosyonVar, sDefaultHareketTipi, bDovizliGirisVar, bEkSoru1, bEkSoru2, nParametre1, nParametre2, sTaxFreeFormu, sDiplomatikFormu, sHediyeCeki, sIndirimKuponu, sPSiparisFormu1, sPSiparisIadeFormu1, sPSiparisFormu2, sPSiparisIadeFormu2, sKSiparisFormu1, sKSiparisIadeFormu1, sKSiparisFormu2, sKSiparisIadeFormu2, sYedekFormu1, sYedekFormu2, bPartiVar, bPSonraTeslimVar, bKSonraTeslimVar, bEkSoru3, bEkSoru4, bEkSoru5, bEkSoru6) VALUES (" & bSaticiRumuzuVarmi & ", " & bEnvanterGosterilsinmi & ", " & bEksiKontroluVarmi & ", " & bMalBazindaOdemePlaniVarmi & ", '" & sSabitOdemeKodu & "', " & bOdemePlaniDegistirilsinmi & ", " & bPesinatDegistirilsinmi & ", " & bTaksitTutDegistirilsinmi & ", " & bTaksitTarDegistirilsinmi & ", " & nITMAXG & ", " & nMinPesinatYuzdesi & ", '" & sPesinatEksikligiDagilimi & "', " & lESPF & ", " & lPesinatYuvarlama & ", " & lTaksitYuvarlama & ", " & bSatisAnindaVadeFarkiVarmi & ", " & nSatisVadeFarkiYuzdesi & ", " & bVFYTaksitleCarpilsinmi & ", " & nGecikmeVadeFarkiYuzdesi & ", " & nGSGG & ", " & lGSGT & ", " & bVFTS & ", " & bVadeFarkinaKDVDahilmi & ", '" & sVadeFarkiKdvTipi & "', '" & sSatisIcinDokulecek & "', '" & sFaturaFormu1 & "', '" & sSatisFisiFormu1 & "', '" & sSenetFormu1 & "', '" & sOdemeFormu1 & "', '" & sPesinFormu1 & "', '" & sIadeFormu1 & "', '" & sFaturaFormu2 & "', '" & sSatisFisiFormu2 & "', '" & sSenetFormu2 & "', '" & sOdemeFormu2 & "', '" & sPesinFormu2 & "', '" & sIadeFormu2 & "', " & bTarihDegistirilebilsinmi & ", " & bLimitAsimiIzinlimi & ", " & bGecikmeIzinlimi & ", " & bEskilerIptalEdilsinmi & ", " & bSatistaMagazaSorulacakmi & ", " & nAlisGun1 & ", " & nOdemeTipi1 & ", " & nOdemeGun1 & ", " & nAlisGun2 & ", " & nOdemeTipi2 & ", " & nOdemeGun2 & ", " & nAlisGun3 & ", " & nOdemeTipi3 & ", " & nOdemeGun3 & ", " & bMiktarDegistirilsinmi & ", " & bReyonFisnoVarmi & ", " & bEanVarmi & ", " & bTeslimatVarmi & ", " & nTeslimatGunu & ", '" & sDefaultPesinFiyatTipi & "', " & bPFiyatTipiDegistrilsinmi & ", " & bPesinMalIskontoVarmi & ", " & bPesinDipIskontoVarmi & ", " & bPFiyatDegistirilsinmi & ", '" & sDefaultKrediFiyatTipi & "', " & bKFiyatTipiDegistrilsinmi & ", " & bKrediMalIskontoVarmi & ", " & bKrediDipIskontoVarmi & ", " & bKFiyatDegistirilsinmi & ", " & bRaporlarSifrelimi & ", '" & sVadeFarkiFaturaFormu1 & "', '" & sVadeFarkiFaturaFormu2 & "', " & bAgirlikBarkoduVarmi & ", " & nMinVadeFarkiYuzdesi & ", '" & sMagazaKodu & "', " & bPFiyatSatirdaOlsun & ", " & bPHediyeCekiBasilacak & ", " & bPHediyeCekiAlinacak & ", " & bPOdemeTipineGoreFiyatVar & ", " & bKFiyatSatirdaOlsun & ", " & bKHediyeCekiBasilacak & ", " & bKHediyeCekiAlinacak & ", " & bKOdemeTipineGoreFiyatVar & ", " & bStokResmiVar & ", " & bMusteriResmiVar & ", " & bKrediKartNoSorsun & ", " & bDokumdeYaziciSorsun & ", " & bYalnizSonFaturaYenidenDok & ", " & bMusteriNotuSatisaGelsin & ", " & lDefaultMusteriKodu & ", " & bPIndirimKuponuBasilacak & "," & bPIndirimKuponuAlinacak & ", " & bPPromosyonVar & ", " & bKPromosyonVar & ", '" & sDefaultHareketTipi & "', " & bDovizliGirisVar & ", " & bEkSoru1 & ", " & bEkSoru2 & ", " & nParametre1 & ", " & nParametre2 & ", '" & sTaxFreeFormu & "', '" & sDiplomatikFormu & "', '" & sHediyeCeki & "', '" & sIndirimKuponu & "', '" & sPSiparisFormu1 & "', '" & sPSiparisIadeFormu1 & "', '" & sPSiparisFormu2 & "', '" & sPSiparisIadeFormu2 & "', '" & sKSiparisFormu1 & "', '" & sKSiparisIadeFormu1 & "', '" & sKSiparisFormu2 & "', '" & sKSiparisIadeFormu2 & "', '" & sYedekFormu1 & "', '" & sYedekFormu2 & "', " & bPartiVar & ", " & bPSonraTeslimVar & ", " & bKSonraTeslimVar & ", " & bEkSoru3 & ", " & bEkSoru4 & ", " & bEkSoru5 & ", " & bEkSoru6 & ")")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbCariIslem_kaydet_yeni(ByVal sCariIslem As String, ByVal sAciklama As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbCariIslem (sCariIslem, sAciklama) VALUES     ('" & sCariIslem & "', N'" & sAciklama & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokIslem_kaydet_yeni(ByVal sCariIslem As String, ByVal sAciklama As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbCariIslem (sCariIslem, sAciklama) VALUES     ('" & sCariIslem & "', N'" & sAciklama & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbUlke_kaydet_yeni(ByVal sUlke As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbUlke                      (sUlke) VALUES     ('" & sUlke & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbIletisimAraci_kaydet_yeni(ByVal sIletisimAraci As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbIletisimAraci                      (sIletisimAraci) VALUES     ('" & sIletisimAraci & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbIl_kaydet_yeni(ByVal sIl As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbIl                      (sIl) VALUES     ('" & sIl & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbHitap_kaydet_yeni(ByVal sHitap As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbHitap                      (sHitap) VALUES     ('" & sHitap & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbUnvan_kaydet_yeni(ByVal sUnvan As String, ByVal sAciklama As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbUnvan                      (sUnvan, sAciklama) VALUES     ('" & sUnvan & "', '" & sAciklama & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbHareketTipi_kaydet_yeni(ByVal sHareketTipi As String, ByVal sAciklama As String, ByVal bIkinciFormmu As Byte)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbHareketTipi                      (sHareketTipi, sAciklama, bIkinciFormmu) VALUES     ('" & sHareketTipi & "', '" & sAciklama & "', " & bIkinciFormmu & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbSinif_kaydet_yeni(ByVal table As String, ByVal no As Integer, ByVal sSinifKodu As String, ByVal sAciklama As String, ByVal bSatisYapilamaz As Byte)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If table = "tbMSinif" Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO " & table & no & " (sSinifKodu, sAciklama, bSatisYapilamaz) VALUES     ('" & sSinifKodu & "', N'" & sAciklama & "', " & bSatisYapilamaz & ")")
            cmd.ExecuteNonQuery()
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO " & table & no & " (sSinifKodu, sAciklama) VALUES     ('" & sSinifKodu & "', '" & sAciklama & "')")
            cmd.ExecuteNonQuery()
        End If
        con.Close()
    End Sub
    Private Sub tbKasiyer_kontrol()
        Dim ds_tbkasiyer As DataSet = sorgu(sorgu_query("Select * from tbKasiyer"))
        Dim dr As DataRow
        For Each dr In ds_tbkasiyer.Tables(0).Rows
            If sorgu_sKasiyerRumuzu_kontrol(dr("sKasiyerRumuzu")) = True Then
                Try
                    tbKasiyer_kaydet_yeni(dr("sKasiyerRumuzu"), dr("sAdi"), dr("sSoyadi"), dr("sSifresi"), dr("sDepo"), dr("bIptalYapabilirmi"), dr("bVadeFarksizOdemeAlirmi"), dr("nMaxIskontoYuzdesi"))
                Catch ex As Exception
                End Try
            End If
        Next
    End Sub
    Private Sub tbKasiyer_kaydet_yeni(ByVal sKasiyerRumuzu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal sSifresi As String, ByVal sDepo As String, ByVal bIptalYapabilirmi As Byte, ByVal bVadeFarksizOdemeAlirmi As Byte, ByVal nMaxIskontoYuzdesi As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbKasiyer (sKasiyerRumuzu, sAdi, sSoyadi, sSifresi, sDepo, bIptalYapabilirmi, bVadeFarksizOdemeAlirmi, nMaxIskontoYuzdesi) VALUES     ('" & sKasiyerRumuzu & "', '" & sAdi & "', '" & sSoyadi & "', '" & sSifresi & "', '" & sDepo & "', " & bIptalYapabilirmi & ", " & bVadeFarksizOdemeAlirmi & ", " & nMaxIskontoYuzdesi & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_sKasiyerRumuzu_kontrol(ByVal sKasiyerRumuzu As String) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_resmi
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sKasiyerRumuzu), 0) AS nKayit FROM         tbKasiyer WHERE     (sKasiyerRumuzu = '" & sKasiyerRumuzu & "')  ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub Musterileri_Al(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        dataset1 = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select * from tbMusteri Where dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih2.ToString, 10) + " 23:59:59" & "'"))
        Dim dr_musteri As DataRow
        Dim dr As DataRow
        ProgressBar1.Properties.Maximum = dataset1.Tables(0).Rows.Count
        ProgressBar1.EditValue = 0
        For Each dr In dataset1.Tables(0).Rows
            Try
                If sorgu_musteri_kontrol(dr("lKodu")) = 0 Then
                    dataload_tbMusteri(dr("lKodu"))
                    dataload_tbMusteriNufusu(dr("lKodu"))
                    dr_musteri = ds_tbMusteri.Tables(0).Rows(0)
                    nMusteriID = tbMusteri_kaydet_yeni(dr_musteri("sMagaza"), dr_musteri("lKodu"), dr_musteri("sAdi"), dr_musteri("sSoyadi"), dr_musteri("nCinsiyet"), dr_musteri("lAylikGelir"), dr_musteri("dteKartAcilisTarihi"), dr_musteri("nIskontoPesin"), dr_musteri("nIskontoKredili"), dr_musteri("sUnvan"), dr_musteri("sVergiDairesi"), dr_musteri("sVergiNo"), dr_musteri("bYazismaEvAdresinemi"), dr_musteri("sEmail"), dr_musteri("sIsYeriAdi"), dr_musteri("sIsAdresi1"), dr_musteri("sIsAdresi2"), dr_musteri("sIsSemt"), dr_musteri("sIsIl"), dr_musteri("sIsPostaKodu"), dr_musteri("sIsTelefonu"), dr_musteri("sEvAdresi1"), dr_musteri("sEvAdresi2"), dr_musteri("sEvSemt"), dr_musteri("sEvPostaKodu"), dr_musteri("sEvIl"), dr_musteri("sEvTelefonu"), dr_musteri("sSigortaNo"), dr_musteri("bEvlimi"), dr_musteri("dteEvlilikTarihi"), dr_musteri("dteDogumTarihi"), dr_musteri("sDogumYeri"), dr_musteri("sEhliyetNo"), dr_musteri("sKanGrubu"), dr_musteri("sHitap"), dr_musteri("sKullaniciAdi"), dr_musteri("dteKayitTarihi"), dr_musteri("sAciklama1"), dr_musteri("sAciklama2"), dr_musteri("sAciklama3"), dr_musteri("sAciklama4"), dr_musteri("sAciklama5"), dr_musteri("sGSM"), dr_musteri("sFax"), dr_musteri("sResimAdi"))
                    Dim drn As DataRow
                    For Each drn In ds_tbMusteriNufusu.Tables(0).Rows
                        tbMusteriNufusu_kaydet_yeni(nMusteriID, drn("sDin"), drn("sKutukIl"), drn("sKutukIlce"), drn("sKutukMahalle"), drn("sKutukCiltNo"), drn("sKutukSiraNo"), drn("dteNufusCuzdanTarihi"), drn("sCuzdanVerilenYer"), drn("sCuzdanVerNedeni"), drn("sCuzdanKayitNo"), drn("sAnneAdi"), drn("sBabaAdi"), drn("sAileAdresi1"), drn("sAileAdresi2"), drn("sAileSemt"), drn("sAilePostaKodu"), drn("sAileIl"), drn("sAileTelefonu"), drn("sHitapAnne"), drn("sHitapBaba"))
                    Next
                    'Sınıflandırma
                    Dim ds_tbMusteriSinifi As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select * from tbMusteriSinifi Where nMusteriID = " & dr("nMusteriID") & ""))
                    If ds_tbMusteriSinifi.Tables(0).Rows.Count = 1 Then
                        drn = ds_tbMusteriSinifi.Tables(0).Rows(0)
                        tbMusteriSinifi_kaydet_yeni(nMusteriID, drn("sSinifKodu1"), drn("sSinifKodu2"), drn("sSinifKodu3"), drn("sSinifKodu4"), drn("sSinifKodu5"), drn("sSinifKodu6"), drn("sSinifKodu7"), drn("sSinifKodu8"), drn("sSinifKodu9"), drn("sSinifKodu10"), drn("sSinifKodu11"), drn("sSinifKodu12"), drn("sSinifKodu13"), drn("sSinifKodu14"), drn("sSinifKodu15"))
                    End If
                    'Kredi
                    Dim ds_tbMusteriKredisi As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select * from tbMusteriKredisi Where nMusteriID = " & dr("nMusteriID") & ""))
                    If ds_tbMusteriKredisi.Tables(0).Rows.Count = 1 Then
                        drn = ds_tbMusteriKredisi.Tables(0).Rows(0)
                        tbMusteriKredisi_kaydet_yeni(nMusteriID, drn("lKrediLimiti"), drn("dteKrediLimitiTarihi"), drn("dteKrediAcilisTarihi"), drn("dteSonKullanmaTarihi"), drn("bOzelMusterimi"), drn("sKullaniciAdi"), drn("dteKayitTarihi"))
                    End If
                    'Kefiller
                    Dim ds_tbMusteriKefil1 As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select * from tbMusteriKefil1 Where nMusteriID = " & dr("nMusteriID") & ""))
                    If ds_tbMusteriKefil1.Tables(0).Rows.Count = 1 Then
                        drn = ds_tbMusteriKefil1.Tables(0).Rows(0)
                        tbMusteriKefil_kaydet_yeni("tbMusteriKefil1", nMusteriID, drn("sAdi"), drn("sSoyadi"), drn("sUnvan"), drn("sEmail"), drn("sIsYeriAdi"), drn("sIsAdresi1"), drn("sIsAdresi2"), drn("sIsSemt"), drn("sIsPostaKodu"), drn("sIsIl"), drn("sIsTelefonu"), drn("sEvAdresi1"), drn("sEvAdresi2"), drn("sEvSemt"), drn("sEvPostaKodu"), drn("sEvIl"), drn("sEvTelefonu"), drn("lAylikGelir"), drn("sSigortaNo"), drn("sHitap"), drn("sKullaniciAdi"), drn("dteKayitTarihi"))
                    End If
                    Dim ds_tbMusteriKefil2 As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select * from tbMusteriKefil2 Where nMusteriID = " & dr("nMusteriID") & ""))
                    If ds_tbMusteriKefil2.Tables(0).Rows.Count = 1 Then
                        drn = ds_tbMusteriKefil2.Tables(0).Rows(0)
                        tbMusteriKefil_kaydet_yeni("tbMusteriKefil2", nMusteriID, drn("sAdi"), drn("sSoyadi"), drn("sUnvan"), drn("sEmail"), drn("sIsYeriAdi"), drn("sIsAdresi1"), drn("sIsAdresi2"), drn("sIsSemt"), drn("sIsPostaKodu"), drn("sIsIl"), drn("sIsTelefonu"), drn("sEvAdresi1"), drn("sEvAdresi2"), drn("sEvSemt"), drn("sEvPostaKodu"), drn("sEvIl"), drn("sEvTelefonu"), drn("lAylikGelir"), drn("sSigortaNo"), drn("sHitap"), drn("sKullaniciAdi"), drn("dteKayitTarihi"))
                    End If
                    'Musteri Karti
                    Dim ds_tbMusteriKarti As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select * from tbMusteriKarti Where nMusteriID = " & dr("nMusteriID") & ""))
                    If ds_tbMusteriKarti.Tables(0).Rows.Count > 0 Then
                        For Each drn In ds_tbMusteriKarti.Tables(0).Rows
                            tbMusteriKarti_kaydet_yeni(nMusteriID, drn("nKartNo"), drn("sAciklama"), drn("dteSonKullanmaTarihi"), drn("sKullaniciAdi"), drn("dteKayitTarihi"))
                        Next
                    End If
                    'Musteri Cocuklari
                    Dim ds_tbMusteriCocugu As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select * from tbMusteriCocugu Where nMusteriID = " & dr("nMusteriID") & ""))
                    If ds_tbMusteriCocugu.Tables(0).Rows.Count > 0 Then
                        For Each drn In ds_tbMusteriCocugu.Tables(0).Rows
                            tbMusteriCocugu_kaydet_yeni(nMusteriID, drn("sAdi"), drn("sSoyadi"), drn("nCinsiyet"), drn("dteDogumTarihi"), drn("sDogumYeri"), drn("sOzelNot"))
                        Next
                    End If
                    'Musteri OzelNotlari
                    Dim ds_tbMusteriOzelNot As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select * from tbMusteriOzelNot Where nMusteriID = " & dr("nMusteriID") & ""))
                    If ds_tbMusteriOzelNot.Tables(0).Rows.Count > 0 Then
                        For Each drn In ds_tbMusteriOzelNot.Tables(0).Rows
                            tbMusteriOzelNot_kaydet_yeni(nMusteriID, drn("dteGirisTarihi"), drn("sText"), drn("sKullaniciAdi"), drn("dteKayitTarihi"))
                        Next
                    End If
                End If
            Catch ex As Exception
            End Try
            ProgressBar1.EditValue += 1
            ProgressBar1.Refresh()
        Next
        ProgressBar1.Properties.Maximum = 0
        ProgressBar1.EditValue = 0
    End Sub
    Private Sub Carileri_Al(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        dataset1 = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select * from tbFirma Where dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih2.ToString, 10) + " 23:59:59" & "'"))
        Dim dr_cari As DataRow
        Dim dr As DataRow
        ProgressBar1.Properties.Maximum = dataset1.Tables(0).Rows.Count
        ProgressBar1.EditValue = 0
        For Each dr In dataset1.Tables(0).Rows
            Try
                If sorgu_firma_kontrol(dr("sKodu")) = 0 Then
                    Dim nFirmaID As Int64 = 0
                    dataload_cari(dr("sKodu"))
                    dr_cari = ds_firma.Tables(0).Rows(0)
                    Dim nHesapID = tbHesapPlani_kaydet_yeni(dr_cari("sKodu"), dr_cari("sAciklama"), "", 0, "", 0, "", "", 0, kullanici, Now)
                    nFirmaID = firma_kaydet_yeni(dr_cari("sKodu"), dr_cari("sAciklama"), dr_cari("nOzelIskontosu"), dr_cari("lKrediLimiti"), dr_cari("dteMutabakatTarihi"), dr_cari("nVadeGun"), dr_cari("sHitap"), dr_cari("sAdres1"), dr_cari("sAdres2"), dr_cari("sSemt"), dr_cari("sIl"), dr_cari("sUlke"), dr_cari("sPostaKodu"), dr_cari("sVergiDairesi"), dr_cari("sVergiNo"), nHesapID, dr_cari("sOzelNot"), dr_cari("sKullaniciAdi"), dr_cari("dteKayitTarihi"), dr_cari("sFiyatTipi"))
                    Dim ds_tbFirmaIletisimi As DataSet = sorgu(sorgu_query("Select * from tbFirmaIletisimi Where nFirmaID = " & dr_cari("nFirmaID") & ""))
                    For Each dr_cari In ds_tbFirmaIletisimi.Tables(0).Rows
                        tbFirmaIletisimi_kaydet_yeni(nFirmaID, dr_cari("sIletisimAraci"), dr_cari("sIletisimAdresi"))
                    Next
                    ds_tbFirmaIletisimi.Dispose()
                    ds_tbFirmaIletisimi = Nothing
                    Dim ds_tbFirmaYetkilisi As DataSet = sorgu(sorgu_query("Select * from tbFirmaYetkilisi Where nFirmaID = " & dr_cari("nFirmaID") & ""))
                    For Each dr_cari In ds_tbFirmaYetkilisi.Tables(0).Rows
                        tbFirmaYetkilisi_kaydet_yeni(nFirmaID, dr_cari("sUnvan"), dr_cari("sHitap"), dr_cari("sAdiSoyadi"))
                    Next
                    ds_tbFirmaYetkilisi.Dispose()
                    ds_tbFirmaYetkilisi = Nothing
                End If
            Catch ex As Exception
            End Try
            ProgressBar1.EditValue += 1
            ProgressBar1.Refresh()
        Next
        ProgressBar1.Properties.Maximum = 0
        ProgressBar1.EditValue = 0
    End Sub
    Private Sub tbStoklari_Al_Yeni(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        dataset1 = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select * from tbStok WHERE (nStokTipi <> 5) and dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih2.ToString, 10) + " 23:59:59" & "'"))
        Dim dr As DataRow
        ProgressBar1.Properties.Maximum = dataset1.Tables(0).Rows.Count
        ProgressBar1.EditValue = 0
        For Each dr In dataset1.Tables(0).Rows
            Try
                If sorgu_stok_kontrol(dr("sKodu")) = 0 Then
                    Dim nStokID As Int64
                    Dim drn As DataRow
                    'Stok Bilgini Çek
                    dataload_stok(dr("sKodu"))
                    'datarowa yükle
                    Dim dr_stok As DataRow = ds_stok.Tables(0).Rows(0)
                    Dim renk_kayit_sayisi As Int64 = sorgu_Renk_kontrol(dr_stok("sRenk"))
                    If renk_kayit_sayisi = 0 Then
                        dataload_sRenk(dr_stok("sRenk"))
                        Dim dr_renk As DataRow = ds_renk.Tables(0).Rows(0)
                        stok_renk_kaydet_yeni(dr_renk("sRenk"), dr_renk("sRenkAdi"), dr_renk("lRenkNo"))
                    End If
                    'Stoğu Kaydet
                    nStokID = stok_kaydet_yeni(dr_stok("sKodu"), dr_stok("sAciklama"), dr_stok("sKisaAdi"), dr_stok("nStokTipi"), dr_stok("sBedenTipi"), dr_stok("sKavalaTipi"), dr_stok("sRenk"), dr_stok("sBeden"), dr_stok("sKavala"), dr_stok("sBirimCinsi1"), dr_stok("sBirimCinsi2"), dr_stok("nIskontoYuzdesi"), dr_stok("sKdvTipi"), dr_stok("nTeminSuresi"), dr_stok("lAsgariMiktar"), dr_stok("lAzamiMiktar"), dr_stok("sOzelNot"), dr_stok("nFiyatlandirma"), dr_stok("sModel"), dr_stok("sKullaniciAdi"), dr_stok("dteKayitTarihi"), dr_stok("bEksiyeDusulebilirmi"), dr_stok("sDefaultAsortiTipi"), dr_stok("bEksideUyarsinmi"), dr_stok("bOTVVar"), dr_stok("sOTVTipi"), dr_stok("nIskontoYuzdesiAV"), dr_stok("bEk1"), dr_stok("nEk2"))
                    'barkodu kaydet
                    'Stok Barkod Bilgisini Çek
                    dataload_stok_barkod(dr("nStokID"))
                    Dim dr_stok_barkod As DataRow
                    For Each dr_stok_barkod In ds_stok_barkod.Tables(0).Rows
                        dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                        If dr_stok_barkod("nKisim") = 0 Or dr_stok_barkod("nKisim") = 1 Then
                        Else
                            dr_stok_barkod("nKisim") = 0
                        End If
                        If dr_stok_barkod("sKarsiStokKodu") = Microsoft.VisualBasic.Right(dr_stok_barkod("nStokID"), 6) Then
                            dr_stok_barkod("sKarsiStokKodu") = ""
                        End If
                        stok_barkod_kaydet_yeni(nStokID, dr_stok_barkod("sBarkod"), dr_stok_barkod("nKisim"), dr_stok_barkod("nFirmaID"), dr_stok_barkod("sKarsiStokKodu"), dr_stok_barkod("sKarsiStokAciklama"))
                    Next
                    'Fiyatları Kaydet
                    Dim ds_tbStokFiyati = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  Select * from tbStokFiyati Where nStokID =" & dr("nStokID") & ""), "TABLE1")
                    Dim dr_fiyat As DataRow
                    For Each dr_fiyat In ds_tbStokFiyati.Tables(0).Rows
                        tbStokFiyati_ekle_yeni(dr_stok("nFiyatlandirma"), dr_stok("sModel"), dr_stok("sRenk"), dr_stok("sBeden"), dr_fiyat("sFiyatTipi"), dr_fiyat("lFiyat"), dr_fiyat("dteFiyatTespitTarihi"), dr_fiyat("sKullaniciAdi"))
                    Next
                    'sınıfları kaydet
                    ds_stok_sinif = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select * from tbStokSinifi Where nStokID = " & dr("nStokID") & ""))
                    If ds_stok_sinif.Tables(0).Rows.Count = 1 Then
                        Dim dr_stok_sinif As DataRow = ds_stok_sinif.Tables(0).Rows(0)
                        For ı As Integer = 1 To 15
                            'MsgBox(dr_stok_sinif("sSinifKodu" & i & ""))
                            If Trim(dr_stok_sinif("sSinifKodu" & ı & "")) <> "" Then
                                Dim sinif_kayit_sayisi As Int64 = sorgu_Sinif_kontrol(dr_stok_sinif("sSinifKodu" & ı & ""), ı)
                                If sinif_kayit_sayisi = 0 Then
                                    dataload_stok_sinif1(dr_stok_sinif("sSinifKodu" & ı & ""), ı)
                                    Dim dr_stok_sinifi As DataRow = ds_stok_sinif.Tables(0).Rows(0)
                                    stok_sinif_kaydet_yeni(dr_stok_sinifi("sSinifKodu"), dr_stok_sinifi("sAciklama"), ı)
                                End If
                            End If
                        Next
                        stok_siniflari_kaydet_yeni(nStokID, dr_stok_sinif("sSinifKodu1"), dr_stok_sinif("sSinifKodu2"), dr_stok_sinif("sSinifKodu3"), dr_stok_sinif("sSinifKodu4"), dr_stok_sinif("sSinifKodu5"), dr_stok_sinif("sSinifKodu6"), dr_stok_sinif("sSinifKodu7"), dr_stok_sinif("sSinifKodu8"), dr_stok_sinif("sSinifKodu9"), dr_stok_sinif("sSinifKodu10"), dr_stok_sinif("sSinifKodu11"), dr_stok_sinif("sSinifKodu12"), dr_stok_sinif("sSinifKodu13"), dr_stok_sinif("sSinifKodu14"), dr_stok_sinif("sSinifKodu15"))
                    End If
                    'Birim Cevrimi
                    Dim ds_tbStokBirimCevrimi As DataSet = sorgu(sorgu_query("Select * from tbStokBirimCevrimi Where nStokID IN (Select nStokID from tbStok where  sModel = '" & dr("sModel") & "')"))
                    For Each drn In ds_tbStokBirimCevrimi.Tables(0).Rows
                        tbStokBirimCevrimi_kaydet_yeni(drn("sBirimCinsi"), drn("lOran"), dr("sModel"))
                    Next
                End If
            Catch ex As Exception
            End Try
            ProgressBar1.EditValue += 1
            ProgressBar1.Refresh()
        Next
        ProgressBar1.Properties.Maximum = 0
        ProgressBar1.EditValue = 0
    End Sub
    Private Sub tbStoklari_Al_Degisen(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        dataset1 = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select * from tbStok  WHERE     (nStokTipi <> 5) AND nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2.ToString, 10) & "') and (sFiyatTipi IN('" & sFiyat1 & "','" & sFiyat2 & "','" & sFiyat3 & "','" & sFiyat4 & "','" & sAktifFiyatTipi & "')) )"))
        Dim dr As DataRow
        ProgressBar1.Properties.Maximum = dataset1.Tables(0).Rows.Count
        ProgressBar1.EditValue = 0
        For Each dr In dataset1.Tables(0).Rows
            Try
                If sorgu_stok_kontrol(dr("sKodu")) = 0 Then
                    Dim nStokID As Int64
                    Dim drn As DataRow
                    'Stok Bilgini Çek
                    dataload_stok(dr("sKodu"))
                    'datarowa yükle
                    Dim dr_stok As DataRow = ds_stok.Tables(0).Rows(0)
                    Dim renk_kayit_sayisi As Int64 = sorgu_Renk_kontrol(dr_stok("sRenk"))
                    If renk_kayit_sayisi = 0 Then
                        dataload_sRenk(dr_stok("sRenk"))
                        Dim dr_renk As DataRow = ds_renk.Tables(0).Rows(0)
                        stok_renk_kaydet_yeni(dr_renk("sRenk"), dr_renk("sRenkAdi"), dr_renk("lRenkNo"))
                    Else
                    End If
                    'Stoğu Kaydet
                    nStokID = stok_kaydet_yeni(dr_stok("sKodu"), dr_stok("sAciklama"), dr_stok("sKisaAdi"), dr_stok("nStokTipi"), dr_stok("sBedenTipi"), dr_stok("sKavalaTipi"), dr_stok("sRenk"), dr_stok("sBeden"), dr_stok("sKavala"), dr_stok("sBirimCinsi1"), dr_stok("sBirimCinsi2"), dr_stok("nIskontoYuzdesi"), dr_stok("sKdvTipi"), dr_stok("nTeminSuresi"), dr_stok("lAsgariMiktar"), dr_stok("lAzamiMiktar"), dr_stok("sOzelNot"), dr_stok("nFiyatlandirma"), dr_stok("sModel"), dr_stok("sKullaniciAdi"), dr_stok("dteKayitTarihi"), dr_stok("bEksiyeDusulebilirmi"), dr_stok("sDefaultAsortiTipi"), dr_stok("bEksideUyarsinmi"), dr_stok("bOTVVar"), dr_stok("sOTVTipi"), dr_stok("nIskontoYuzdesiAV"), dr_stok("bEk1"), dr_stok("nEk2"))
                    'barkodu kaydet
                    'Stok Barkod Bilgisini Çek
                    dataload_stok_barkod(dr("nStokID"))
                    Dim dr_stok_barkod As DataRow
                    For Each dr_stok_barkod In ds_stok_barkod.Tables(0).Rows
                        dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                        If dr_stok_barkod("nKisim") = 0 Or dr_stok_barkod("nKisim") = 1 Then
                        Else
                            dr_stok_barkod("nKisim") = 0
                        End If
                        If dr_stok_barkod("sKarsiStokKodu") = Microsoft.VisualBasic.Right(dr_stok_barkod("nStokID"), 6) Then
                            dr_stok_barkod("sKarsiStokKodu") = ""
                        End If
                        stok_barkod_kaydet_yeni(nStokID, dr_stok_barkod("sBarkod"), dr_stok_barkod("nKisim"), dr_stok_barkod("nFirmaID"), dr_stok_barkod("sKarsiStokKodu"), dr_stok_barkod("sKarsiStokAciklama"))
                    Next
                    'Fiyatları Kaydet
                    Dim ds_tbStokFiyati = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select * from tbStokFiyati Where nStokID =" & dr("nStokID") & ""), "TABLE1")
                    Dim dr_fiyat As DataRow
                    For Each dr_fiyat In ds_tbStokFiyati.Tables(0).Rows
                        tbStokFiyati_ekle_yeni(dr_stok("nFiyatlandirma"), dr_stok("sModel"), dr_stok("sRenk"), dr_stok("sBeden"), dr_fiyat("sFiyatTipi"), dr_fiyat("lFiyat"), dr_fiyat("dteFiyatTespitTarihi"), dr_fiyat("sKullaniciAdi"))
                    Next
                    'sınıfları kaydet
                    ds_stok_sinif = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  Select * from tbStokSinifi Where nStokID = " & dr("nStokID") & ""))
                    If ds_stok_sinif.Tables(0).Rows.Count = 1 Then
                        Dim dr_stok_sinif As DataRow = ds_stok_sinif.Tables(0).Rows(0)
                        For ı As Integer = 1 To 15
                            If Trim(dr_stok_sinif("sSinifKodu" & ı & "")) <> "" Then
                                Dim sinif_kayit_sayisi As Int64 = sorgu_Sinif_kontrol(dr_stok_sinif("sSinifKodu" & ı & ""), ı)
                                If sinif_kayit_sayisi = 0 Then
                                    dataload_stok_sinif1(dr_stok_sinif("sSinifKodu" & ı & ""), ı)
                                    Dim dr_stok_sinifi As DataRow = ds_stok_sinif.Tables(0).Rows(0)
                                    stok_sinif_kaydet_yeni(dr_stok_sinifi("sSinifKodu"), dr_stok_sinifi("sAciklama"), ı)
                                Else
                                End If
                            End If
                        Next
                        stok_siniflari_kaydet_yeni(nStokID, dr_stok_sinif("sSinifKodu1"), dr_stok_sinif("sSinifKodu2"), dr_stok_sinif("sSinifKodu3"), dr_stok_sinif("sSinifKodu4"), dr_stok_sinif("sSinifKodu5"), dr_stok_sinif("sSinifKodu6"), dr_stok_sinif("sSinifKodu7"), dr_stok_sinif("sSinifKodu8"), dr_stok_sinif("sSinifKodu9"), dr_stok_sinif("sSinifKodu10"), dr_stok_sinif("sSinifKodu11"), dr_stok_sinif("sSinifKodu12"), dr_stok_sinif("sSinifKodu13"), dr_stok_sinif("sSinifKodu14"), dr_stok_sinif("sSinifKodu15"))
                    End If
                    'Birim Cevrimi
                    Dim ds_tbStokBirimCevrimi As DataSet = sorgu(sorgu_query("Select * from tbStokBirimCevrimi Where nStokID IN (Select nStokID from tbStok where  sModel = '" & dr("sModel") & "')"))
                    For Each drn In ds_tbStokBirimCevrimi.Tables(0).Rows
                        tbStokBirimCevrimi_kaydet_yeni(drn("sBirimCinsi"), drn("lOran"), dr("sModel"))
                    Next
                Else
                    'Stok Bilgini Çek
                    dataload_stok(dr("sKodu"))
                    'datarowa yükle
                    Dim dr_stok As DataRow = ds_stok.Tables(0).Rows(0)
                    'Stok Kaydet
                    tbStok_kaydet_duzelt(dr_stok("sKodu").ToString, dr_stok("sAciklama"), dr_stok("sKisaAdi"), dr_stok("nStokTipi"), dr_stok("sBedenTipi").ToString, dr_stok("sKavalaTipi").ToString, dr_stok("sRenk").ToString, dr_stok("sBeden").ToString, dr_stok("sKavala").ToString, dr_stok("sBirimCinsi1"), dr_stok("sBirimCinsi2"), dr_stok("nIskontoYuzdesi"), dr_stok("sKdvTipi"), dr_stok("nTeminSuresi"), dr_stok("lAsgariMiktar"), dr_stok("lAzamiMiktar"), dr_stok("sOzelNot"), dr_stok("nFiyatlandirma"), dr_stok("sModel"), dr_stok("sKullaniciAdi"), Now, dr_stok("bEksiyeDusulebilirmi"), dr_stok("sDefaultAsortiTipi"), dr_stok("bEksideUyarsinmi"), dr_stok("bOTVVar"), dr_stok("sOTVTipi"), dr_stok("nIskontoYuzdesiAV"), dr_stok("bEk1"), dr_stok("nEk2"), dr_stok("nPrim"))
                    'Fiyatları Kaydet
                    Dim ds_tbStokFiyati = sorgu(sorgu_query("Select * from tbStokFiyati Where nStokID =" & dr("nStokID") & ""), "TABLE1")
                    Dim dr_fiyat As DataRow
                    sorgula_nStokID("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Delete from tbStokFiyati Where nStokID IN (Select nStokID from tbStok Where sModel = '" & dr_stok("sModel") & "')")
                    For Each dr_fiyat In ds_tbStokFiyati.Tables(0).Rows
                        tbStokFiyati_ekle_yeni(dr_stok("nFiyatlandirma"), dr_stok("sModel"), dr_stok("sRenk"), dr_stok("sBeden"), dr_fiyat("sFiyatTipi"), dr_fiyat("lFiyat"), dr_fiyat("dteFiyatTespitTarihi"), dr_fiyat("sKullaniciAdi"))
                    Next
                End If
            Catch ex As Exception
            End Try
            ProgressBar1.EditValue += 1
            ProgressBar1.Refresh()
        Next
        ProgressBar1.Properties.Maximum = 0
        ProgressBar1.EditValue = 0
    End Sub
    Public Function sorgu(ByVal query As String, Optional ByVal sTable As String = "TABLE1") As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, sTable)
        con.Close()
        Return DS
        cmd.Dispose()
        con.Dispose()
        adapter.Dispose()
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_resmi(ByVal query As String, Optional ByVal sTable As String = "TABLE1") As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection_resmi
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, sTable)
        con.Close()
        Return DS
        cmd.Dispose()
        con.Dispose()
        adapter.Dispose()
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Sub tablo_kontrol()
        Dim ds_Satici As DataSet = sorgu(sorgu_query("Select * from tbSatici"))
        For Each dr In ds_Satici.Tables(0).Rows
            If sorgula_nStokID("Select Count(*) from tbSatici Where sSaticiRumuzu = '" & dr("sSaticiRumuzu") & "'") = 0 Then
                tbSatici_kaydet_yeni(dr("sSaticiRumuzu").ToString, dr("sAdi"), dr("sSoyadi"), dr("nPrim"), dr("sAciklama"), dr("lSabitPrim"), dr("lPrim1Baslangic"), dr("lPrim1Bitis"), dr("lPrim1Oran"), dr("lPrim2Baslangic"), dr("lPrim2Bitis"), dr("lPrim2Oran"), dr("lPrim3Baslangic"), dr("lPrim3Bitis"), dr("lPrim3Oran"), dr("lPrim4Baslangic"), dr("lPrim4Bitis"), dr("lPrim4Oran"), dr("lPrim5Baslangic"), dr("lPrim5Bitis"), dr("lPrim5Oran"), dr("bAktif"))
            End If
        Next
        Dim ds_Birim As DataSet = sorgu(sorgu_query("Select * from tbBirimCinsi"))
        For Each dr In ds_Birim.Tables(0).Rows
            If sorgula_nStokID("Select Count(*) from tbBirimCinsi where sBirimCinsi = '" & dr("sBirimCinsi") & "'") = 0 Then
                tbBirimCinsi_kaydet_yeni(dr("sBirimCinsi"), dr("sAciklama"), dr("nOndalik"))
            End If
        Next
        Dim ds_FiyatTipi As DataSet = sorgu(sorgu_query("Select * from tbFiyatTipi where (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%')"))
        For Each dr In ds_FiyatTipi.Tables(0).Rows
            If sorgula_nStokID("Select Count(*) from tbFiyatTipi where (sFiyatTipi = '" & dr("sFiyatTipi") & "') and (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%')") = 0 Then
                tbFiyatTipi_kaydet_yeni(dr("sFiyatTipi"), dr("sAciklama"), dr("nAST"), dr("bKdvDahilmi"), dr("bDovizeBaglimi"), dr("sDovizCinsi"), dr("sHangiKur"))
            End If
        Next
        Dim ds_OdemeSekli As DataSet = sorgu(sorgu_query("Select * from tbOdemeSekli "))
        For Each dr In ds_OdemeSekli.Tables(0).Rows
            If sorgula_nStokID("Select Count(*) from tbOdemeSekli where sOdemeSekli = '" & dr("sOdemeSekli") & "'") = 0 Then
                tbOdemeSekli_kaydet_yeni(dr("sOdemeSekli"), dr("sAciklama"), dr("nOdemeTipi"))
            End If
        Next
        Dim ds_Depo As DataSet = sorgu(sorgu_query("Select * from tbDepo"))
        For Each dr In ds_Depo.Tables(0).Rows
            If sorgula_nStokID("Select Count(*) from tbDepo where sDepo = '" & dr("sDepo") & "'") = 0 Then
                tbDepo_kaydet_yeni(dr("sDepo"), dr("sAciklama"), 0, dr("sSube"), dr("sDepoTipi"), dr("sEmail"), dr("nKatSayisi"), dr("nMagazaM2"), dr("nDepoM2"), dr("sKiraDovizCinsi"), dr("lKiraBedeli"), dr("dteAcilisTarihi"), dr("dteSonDekorasyon"), dr("sMudurAdiSoyadi"), dr("nPersonelAdeti"))
            End If
        Next
        Dim ds_CariIslem As DataSet = sorgu(sorgu_query("Select * from tbCariIslem"))
        For Each dr In ds_CariIslem.Tables(0).Rows
            If sorgula_nStokID("Select Count(*) from tbCariIslem where sCariIslem = '" & dr("sCariIslem") & "'") = 0 Then
                tbCariIslem_kaydet_yeni(dr("sCariIslem"), dr("sAciklama"))
            End If
        Next
        Dim ds_StokIslem As DataSet = sorgu(sorgu_query("Select * from tbStokIslem"))
        For Each dr In ds_StokIslem.Tables(0).Rows
            If sorgula_nStokID("Select Count(*) from tbStokIslem where sStokIslem = '" & dr("sStokIslem") & "'") = 0 Then
                tbStokIslem_kaydet_yeni(dr("sStokIslem"), dr("sAciklama"))
            End If
        Next
        Dim sTable As String = "tbSSinif"
        For ı As Integer = 1 To 15
            Dim ds_Sinif As DataSet = sorgu(sorgu_query("Select * from " & sTable & "" & ı & ""))
            For Each dr In ds_Sinif.Tables(0).Rows
                If sorgula_nStokID("Select Count(*) from " & sTable & "" & ı & " where sSinifKodu = '" & dr("sSinifKodu") & "'") = 0 Then
                    tbSinif_kaydet_yeni(sTable, ı, dr("sSinifKodu"), dr("sAciklama"), 0)
                End If
            Next
        Next
        sTable = "tbMSinif"
        For ı As Integer = 1 To 15
            Dim ds_Sinif As DataSet = sorgu(sorgu_query("Select * from " & sTable & "" & ı & ""))
            For Each dr In ds_Sinif.Tables(0).Rows
                If sorgula_nStokID("Select Count(*) from " & sTable & "" & ı & " where sSinifKodu = '" & dr("sSinifKodu") & "'") = 0 Then
                    tbSinif_kaydet_yeni(sTable, ı, dr("sSinifKodu"), dr("sAciklama"), 0)
                End If
            Next
        Next
        sTable = "tbFSinif"
        For ı As Integer = 1 To 5
            Dim ds_Sinif As DataSet = sorgu(sorgu_query("Select * from " & sTable & "" & ı & ""))
            For Each dr In ds_Sinif.Tables(0).Rows
                If sorgula_nStokID("Select Count(*) from " & sTable & "" & ı & " where sSinifKodu = '" & dr("sSinifKodu") & "'") = 0 Then
                    tbSinif_kaydet_yeni(sTable, ı, dr("sSinifKodu"), dr("sAciklama"), 0)
                End If
            Next
        Next
        Dim ds_HareketTipi As DataSet = sorgu(sorgu_query("Select * from tbHareketTipi"))
        For Each dr In ds_HareketTipi.Tables(0).Rows
            If sorgula_nStokID("Select Count(*) from tbHareketTipi where sHareketTipi = '" & dr("sHareketTipi") & "'") = 0 Then
                tbHareketTipi_kaydet_yeni(dr("sHareketTipi"), dr("sAciklama"), 0)
            End If
        Next
        Dim ds_Unvan As DataSet = sorgu(sorgu_query("Select * from tbUnvan"))
        For Each dr In ds_Unvan.Tables(0).Rows
            If sorgula_nStokID("Select Count(*) from tbUnvan where sUnvan = '" & dr("sUnvan") & "'") = 0 Then
                tbUnvan_kaydet_yeni(dr("sUnvan"), dr("sAciklama"))
            End If
        Next
        Dim ds_Hitap As DataSet = sorgu(sorgu_query("Select * from tbHitap"))
        For Each dr In ds_Hitap.Tables(0).Rows
            If sorgula_nStokID("Select Count(*) from tbHitap where sHitap = '" & dr("sHitap") & "'") = 0 Then
                tbHitap_kaydet_yeni(dr("sHitap"))
            End If
        Next
        Dim ds_Il As DataSet = sorgu(sorgu_query("Select * from tbIl"))
        For Each dr In ds_Il.Tables(0).Rows
            If sorgula_nStokID("Select Count(*) from tbIl where sIl = '" & dr("sIl") & "'") = 0 Then
                tbIl_kaydet_yeni(dr("sIl"))
            End If
        Next
        Dim ds_Ulke As DataSet = sorgu(sorgu_query("Select * from tbUlke"))
        For Each dr In ds_Ulke.Tables(0).Rows
            If sorgula_nStokID("Select Count(*) from tbUlke where sUlke = '" & dr("sUlke") & "'") = 0 Then
                tbUlke_kaydet_yeni(dr("sUlke"))
            End If
        Next
        Dim ds_IletisimAraci As DataSet = sorgu(sorgu_query("Select * from tbIletisimAraci"))
        For Each dr In ds_IletisimAraci.Tables(0).Rows
            If sorgula_nStokID("Select Count(*) from tbIletisimAraci where sIletisimAraci = '" & dr("sIletisimAraci") & "'") = 0 Then
                tbIletisimAraci_kaydet_yeni(dr("sIletisimAraci"))
            End If
        Next
    End Sub
    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        aktar()
    End Sub
    Private Sub aktar()
        Label2.Text = "Lütfen Bekleyiniz...!"
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        Dim sQlConnection_orj = "Provider=SQLOLEDB.1;Password=" & txt_sqlPassword.Text & ";Persist Security Info=True;User ID=" & txt_sqlLoginName.Text & ";Initial Catalog=" & txt_sqlDatabase.Text & ";Data Source=" & txt_sqlServer.Text & ";Current Language=Türkçe;Application Name=Konsol"
        connection_resmi = sQlConnection_orj
        If sCon.State = ConnectionState.Open = True Then
            sCon.Close()
        End If
        sCon.ConnectionString = connection_resmi
        sConnection = connection_resmi
        If sCon.State = ConnectionState.Closed = True Then
            sCon.Open()
        End If
        Dim bTabloKontrol As Boolean = False
        If sec_sIslem.Items.Item(0).CheckState = CheckState.Checked Then
            Dim connection_orj = connection
            Dim connection_resmi_orj = connection_resmi
            connection_resmi = connection_orj
            connection = connection_resmi_orj
            Try
                If bTabloKontrol = False Then
                    tablo_kontrol()
                    bTabloKontrol = True
                End If
                Musterileri_Al(txt_dteAktarimTarihi.Value, txt_dteAktarimTarihi2.Value)
            Catch ex As Exception
            End Try
            connection_resmi = connection_resmi_orj
            connection = connection_orj
        End If
        If sec_sIslem.Items.Item(1).CheckState = CheckState.Checked Then
            Dim connection_orj = connection
            Dim connection_resmi_orj = connection_resmi
            connection_resmi = connection_orj
            connection = connection_resmi_orj
            Try
                If bTabloKontrol = False Then
                    tablo_kontrol()
                    bTabloKontrol = True
                End If
                Carileri_Al(txt_dteAktarimTarihi.Value, txt_dteAktarimTarihi2.Value)
            Catch ex As Exception
            End Try
            connection_resmi = connection_resmi_orj
            connection = connection_orj
        End If
        If sec_sIslem.Items.Item(2).CheckState = CheckState.Checked Then
            Dim connection_orj = connection
            Dim connection_resmi_orj = connection_resmi
            connection_resmi = connection_orj
            connection = connection_resmi_orj
            Try
                If bTabloKontrol = False Then
                    tablo_kontrol()
                    bTabloKontrol = True
                End If
            Catch ex As Exception
            End Try
            Try
                Dim frm As New frm_stok_liste
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.islemstatus = True
                frm.kullanici = kullanici
                Dim kriter As String = ""
                If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Dim dr1 As DataRow
                    Dim i As Integer = 0
                    Dim row As Integer = 0
                    For i = 0 To frm.GridView1.SelectedRowsCount - 1
                        row = (frm.GridView1.GetSelectedRows()(i))
                        dr1 = frm.GridView1.GetDataRow(row)
                        kriter += Trim(dr1("nStokID").ToString()) & ", "
                    Next i
                    dr1 = Nothing
                    'dataset1 = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select * from tbStok WHERE (nStokTipi <> 5) and dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih2.ToString, 10) + " 23:59:59" & "'")
                    dataset1 = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select * from tbStok WHERE (nStokTipi <> 5) and (nStokID IN(" & kriter.Substring(0, kriter.Length - 2) & "))"))
                    tbStoklari_Al_Yeni(txt_dteAktarimTarihi.Value, txt_dteAktarimTarihi2.Value)
                Else
                    Try
                        Me.Close()
                    Catch ex As Exception
                    End Try
                End If
            Catch ex As Exception
            End Try
            connection_resmi = connection_resmi_orj
            connection = connection_orj
        End If
        If sec_sIslem.Items.Item(3).CheckState = CheckState.Checked Then
            Dim connection_orj = connection
            Dim connection_resmi_orj = connection_resmi
            connection_resmi = connection_orj
            connection = connection_resmi_orj
            Try
                If bTabloKontrol = False Then
                    tablo_kontrol()
                    bTabloKontrol = True
                End If
                tbStoklari_Al_Degisen(txt_dteAktarimTarihi.Value, txt_dteAktarimTarihi2.Value)
            Catch ex As Exception
            End Try
            connection_resmi = connection_resmi_orj
            connection = connection_orj
        End If
        If sec_sIslem.Items.Item(4).CheckState = CheckState.Checked Or sec_sIslem.Items.Item(5).CheckState = CheckState.Checked Or sec_sIslem.Items.Item(6).CheckState = CheckState.Checked Or sec_sIslem.Items.Item(7).CheckState = CheckState.Checked Or sec_sIslem.Items.Item(8).CheckState = CheckState.Checked Or sec_sIslem.Items.Item(9).CheckState = CheckState.Checked Or sec_sIslem.Items.Item(10).CheckState = CheckState.Checked Or sec_sIslem.Items.Item(11).CheckState = CheckState.Checked Or sec_sIslem.Items.Item(12).CheckState = CheckState.Checked Then tablo_kontrol()
        If sec_sIslem.Items.Item(4).CheckState = CheckState.Checked Then tbStokFisi_Oku(txt_dteAktarimTarihi.Value, txt_dteAktarimTarihi2.Value, "'FS'")
        If sec_sIslem.Items.Item(5).CheckState = CheckState.Checked Then
            tbStokFisi_Oku(txt_dteAktarimTarihi.Value, txt_dteAktarimTarihi2.Value, "'FA'")
        End If
        If sec_sIslem.Items.Item(6).CheckState = CheckState.Checked Then
            etiketTalep_Oku(txt_dteAktarimTarihi.Value, txt_dteAktarimTarihi2.Value, 2)
        End If
        If sec_sIslem.Items.Item(7).CheckState = CheckState.Checked Then
            etiketTalep_Oku(txt_dteAktarimTarihi.Value, txt_dteAktarimTarihi2.Value, 0)
        End If
        If sec_sIslem.Items.Item(8).CheckState = CheckState.Checked Then
            etiketTalep_Oku(txt_dteAktarimTarihi.Value, txt_dteAktarimTarihi2.Value, 1)
        End If
        If sec_sIslem.Items.Item(9).CheckState = CheckState.Checked Then
            program_satislari_aktar(txt_dteAktarimTarihi.Value, txt_dteAktarimTarihi2.Value)
        End If
        If sec_sIslem.Items.Item(10).CheckState = CheckState.Checked Then
            program_odemeleri_aktar(txt_dteAktarimTarihi.Value, txt_dteAktarimTarihi2.Value)
        End If
        If sec_sIslem.Items.Item(11).CheckState = CheckState.Checked Then
            tbBordro_Oku(txt_dteAktarimTarihi.Value, txt_dteAktarimTarihi2.Value, "'CG','TCG'")
        End If
        If sec_sIslem.Items.Item(12).CheckState = CheckState.Checked Then
            tbBordro_Oku(txt_dteAktarimTarihi.Value, txt_dteAktarimTarihi2.Value, "'CC','TCC'")
        End If
        If sec_sIslem.Items.Item(13).CheckState = CheckState.Checked Then
            program_satislari_aktar_birlestir(txt_dteAktarimTarihi.Value, txt_dteAktarimTarihi2.Value)
        End If
        If sCon.State = ConnectionState.Open = True Then
            sCon.Close()
        End If
        Label2.Text = "İşlem Başarıyla Tamamlandı... " & vbTab & Now.ToLongDateString & Now.ToLongTimeString
        Label2.Refresh()
        Cursor.Current = Cursors.Default
        Cursor.Hide()
        If sec_bTekrarla.Checked = True Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        Label2.Text = "Lütfen Bekleyiniz...!"
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        Dim sQlConnection_orj = "Provider=SQLOLEDB.1;Password=" & txt_sqlPassword.Text & ";Persist Security Info=True;User ID=" & txt_sqlLoginName.Text & ";Initial Catalog=" & txt_sqlDatabase.Text & ";Data Source=" & txt_sqlServer.Text & ";Current Language=Türkçe;Application Name=Konsol"
        connection_resmi = sQlConnection_orj
        Dim dr As DataRow
        If sec_sBelgeTipi.SelectedIndex = 0 Then
            dataset1 = sorgu_resmi(sorgu_query("SELECT tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.sFisTipi,tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.sDepo, tbStokFisiMaster.lNetTutar, tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama FROM tbStokFisiMaster INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID WHERE (tbStokFisiMaster.nStokFisiID =  '" & txt_sKayitNo.Text & "')"))
            If dataset1.Tables(0).Rows.Count = 1 Then
                dr = dataset1.Tables(0).Rows(0)
                lbl_KayitInfo.Text = "KayıtNo: " & dr("nStokFisiID") & "\" & "FisTipi: " & dr("sFisTipi") & " Tarih: " & dr("dteFisTarihi") & "\" & "FisNo:" & dr("lFisNo") & "\" & "Firma:" & dr("sKodu") & "\" & dr("sAciklama")
                btn_BelgeAl.Enabled = True
            Else
                XtraMessageBox.Show("Kayıt Bulunamadı...!" & vbCrLf & "KayıtNo: " & txt_sKayitNo.Text, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                lbl_KayitInfo.Text = "Kayıt Bulunamadı...!"
                btn_BelgeAl.Enabled = False
            End If
        ElseIf sec_sBelgeTipi.SelectedIndex = 1 Then
            dataset1 = sorgu_resmi(sorgu_query("SELECT tbFirmaBordroMaster.nBordroID, tbFirmaBordroMaster.sFisTipi,tbFirmaBordroMaster.dteBordroTarihi, tbFirmaBordroMaster.lBordroNo,  tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama FROM tbFirmaBordroMaster INNER JOIN tbFirma ON tbFirmaBordroMaster.nFirmaID = tbFirma.nFirmaID WHERE (tbFirmaBordroMaster.nBordroID =  '" & txt_sKayitNo.Text & "')"))
            If dataset1.Tables(0).Rows.Count = 1 Then
                dr = dataset1.Tables(0).Rows(0)
                lbl_KayitInfo.Text = "KayıtNo: " & dr("nBordroID") & "\" & "FisTipi:" & dr("sFisTipi") & " Tarih: " & dr("dteBordroTarihi") & "\" & "FisNo:" & dr("lBordroNo") & "\" & "Firma:" & dr("sKodu") & "\" & dr("sAciklama")
                btn_BelgeAl.Enabled = True
            Else
                XtraMessageBox.Show("Kayıt Bulunamadı...!" & vbCrLf & "KayıtNo: " & txt_sKayitNo.Text, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                lbl_KayitInfo.Text = "Kayıt Bulunamadı...!"
                btn_BelgeAl.Enabled = False
            End If
        ElseIf sec_sBelgeTipi.SelectedIndex = 2 Then
            dataset1 = sorgu_resmi(sorgu_query("SELECT     * FROM         ASTOKETIKETTALEPBASLIK WHERE (IND =  '" & txt_sKayitNo.Text & "')"))
            If dataset1.Tables(0).Rows.Count = 1 Then
                dr = dataset1.Tables(0).Rows(0)
                Dim sBelgeTipi As String = "Talep Fişi"
                If dr("BELGETIPI") = 0 Then
                ElseIf dr("BELGETIPI") = 1 Then
                    sBelgeTipi = "Lojistik Fişi"
                ElseIf dr("BELGETIPI") = 2 Then
                    sBelgeTipi = "Transfer Fişi"
                End If
                lbl_KayitInfo.Text = "KayıtNo: " & dr("IND") & "\" & "FisTipi: " & sBelgeTipi & " Tarih: " & dr("TARIH") & "\" & "FisNo:" & dr("BELGENO")
                btn_BelgeAl.Enabled = True
            Else
                XtraMessageBox.Show("Kayıt Bulunamadı...!" & vbCrLf & "KayıtNo: " & txt_sKayitNo.Text, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                lbl_KayitInfo.Text = "Kayıt Bulunamadı...!"
                btn_BelgeAl.Enabled = False
            End If
        End If
        Label2.Text = "Tamamlandı...!"
        Label2.Refresh()
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub btn_BelgeAl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BelgeAl.Click
        Label2.Text = "Lütfen Bekleyiniz...!"
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        Dim sQlConnection_orj = "Provider=SQLOLEDB.1;Password=" & txt_sqlPassword.Text & ";Persist Security Info=True;User ID=" & txt_sqlLoginName.Text & ";Initial Catalog=" & txt_sqlDatabase.Text & ";Data Source=" & txt_sqlServer.Text & ";Current Language=Türkçe;Application Name=Konsol"
        connection_resmi = sQlConnection_orj
        If sec_sBelgeTipi.SelectedIndex = 0 Then
            Dim connection_orj = connection
            Dim connection_resmi_orj = connection_resmi
            connection_resmi = connection_orj
            connection = connection_resmi_orj
            sConnection = connection_resmi
            Try
                tablo_kontrol()
                tbStokFisi_Oku("01/01/1900", "31/12/2078", "'FS','FA','HA','HS','MM','DG','DC'", txt_sKayitNo.Text)
                XtraMessageBox.Show("İşlem Başarıyla Tamamlandı...", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                XtraMessageBox.Show("İşlem Hatası...!")
            End Try
            connection_resmi = connection_resmi_orj
            connection = connection_orj
            sConnection = connection_resmi
        ElseIf sec_sBelgeTipi.SelectedIndex = 1 Then
            Dim connection_orj = connection
            Dim connection_resmi_orj = connection_resmi
            connection_resmi = connection_orj
            connection = connection_resmi_orj
            sConnection = connection_resmi
            Try
                tablo_kontrol()
                tbBordro_Oku("01/01/1900", "31/12/2078", "'CG','CC','TCG','TCC'", txt_sKayitNo.Text)
                XtraMessageBox.Show("İşlem Başarıyla Tamamlandı...", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                XtraMessageBox.Show("İşlem Hatası...!")
            End Try
            connection_resmi = connection_resmi_orj
            connection = connection_orj
            sConnection = connection_resmi
        ElseIf sec_sBelgeTipi.SelectedIndex = 2 Then
            Dim connection_orj = connection
            Dim connection_resmi_orj = connection_resmi
            connection_resmi = connection_orj
            connection = connection_resmi_orj
            sConnection = connection_resmi
            Try
                tablo_kontrol()
                etiketTalep_Oku("01/01/1900", "31/12/2078", "'0','1','2'", txt_sKayitNo.Text)
                XtraMessageBox.Show("İşlem Başarıyla Tamamlandı...", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                XtraMessageBox.Show("İşlem Hatası...!")
            End Try
            connection_resmi = connection_resmi_orj
            connection = connection_orj
            sConnection = connection_resmi
        End If
        Label2.Text = "Tamamlandı...!"
        Label2.Refresh()
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub sec_sBelgeTipi_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sBelgeTipi.SelectedIndexChanged
        btn_BelgeAl.Enabled = False
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        LabelControl3.Text = Now.ToLongDateString & vbTab & Now.ToLongTimeString
        If Trim(Now.ToLongTimeString) = "00:00:59" Then
            txt_dteAktarimTarihi.Value = Today
            txt_dteAktarimTarihi2.Value = Today
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        aktar()
    End Sub
    Private Sub sec_bTekrarla_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bTekrarla.CheckedChanged
        If sec_bTekrarla.Checked = False Then
            Timer1.Enabled = False
        End If
    End Sub
End Class