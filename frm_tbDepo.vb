Imports DevExpress.XtraEditors
Public Class frm_tbDepo
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_tbDepoTipi As DataSet
    Dim ds_tbSube As DataSet
    Dim ds_tbDovizCinsi As DataSet
    Dim ds_tbFirma As DataSet
    Dim islem As String = ""
    Dim satir
    Public bParamAlisVeris As Boolean = False
    Private Sub frm_tbDepo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dataload_tbDepo()
        dataload_tbDepoTipi()
        dataload_tbSube()
        dataload_tbDovizCinsi()
        dataload_tbFirma()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        If bParamAlisVeris = True Then
            Me.Text = "Alýþveriþ Parametreleri"
        End If
    End Sub
    Private Sub dataload_tbDepoTipi()
        ds_tbDepoTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepoTipi,sAciklama FROM         tbDepoTipi"))
        sec_sDepoTipi.Properties.DataSource = ds_tbDepoTipi.Tables(0)
    End Sub
    Private Sub dataload_tbSube()
        ds_tbSube = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSubeMagaza,sAciklama FROM         tbSubeMagaza"))
        sec_sSube.Properties.DataSource = ds_tbSube.Tables(0)
    End Sub
    Private Sub dataload_tbDovizCinsi()
        ds_tbDovizCinsi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDovizCinsi,sAciklama FROM         tbDovizCinsi"))
        sec_sDovizCinsi.Properties.DataSource = ds_tbDovizCinsi.Tables(0)
    End Sub
    Private Sub dataload_tbFirma()
        'ds_tbFirma = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nFirmaID,sKodu,sAciklama FROM         tbFirma"))
        'sec_tbFirma.Properties.DataSource = ds_tbFirma.Tables(0)
    End Sub
    Private Sub referans_sec()
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.sModul = "Cari"
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            sec_tbFirma.Text = dr1("nFirmaID")
            lbl_Firma.Text = dr1("sAciklama")
            'tbMusteriRefeerans_kaydet_yeni(nMusteriID, dr1("nMusteriID"))
            dr1 = Nothing
        End If
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
    Private Sub gorunum_yazdir()
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim itm
        For Each itm In kisayol.Items
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
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
    Public Sub Dataload_tbDepo()
        Try
            ds_tbDepo.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * From tbDepo Where sDepo <> '' ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbDepo, "Table1")
        conn.Close()
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub tbDepo_kaydet_yeni(ByVal sDepo As String, ByVal sAciklama As String, ByVal nFirmaID As Int64, ByVal sSube As String, ByVal sDepoTipi As String, ByVal sEmail As String, ByVal nKatSayisi As Int64, ByVal nMagazaM2 As Int64, ByVal nDepoM2 As Int64, ByVal sKiraDovizCinsi As String, ByVal lKiraBedeli As Decimal, ByVal dteAcilisTarihi As DateTime, ByVal dteSonDekorasyon As DateTime, ByVal sMudurAdiSoyadi As String, ByVal nPersonelAdeti As Int64, ByVal bEnvanterGosterme As Integer, ByVal bKod3ZorunluMu As Integer, ByVal bTalepDogrulamaKontrol As Byte)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbDepo(sDepo, sAciklama, nFirmaID, sSube, sDepoTipi, sEmail, nKatSayisi, nMagazaM2, nDepoM2, sKiraDovizCinsi, lKiraBedeli, dteAcilisTarihi,  dteSonDekorasyon, sMudurAdiSoyadi, nPersonelAdeti, bEnvanterGosterme, bKod3ZorunluMu, bTalepDogrulamaKontrol) VALUES('" & sDepo & "', N'" & sAciklama & "', " & nFirmaID & ", '" & sSube & "', '" & sDepoTipi & "', '" & sEmail & "', " & nKatSayisi & ", " & nMagazaM2 & ", " & nDepoM2 & ", '" & sKiraDovizCinsi & "', " & lKiraBedeli & ", '" & dteAcilisTarihi & "', '" & dteSonDekorasyon & "', '" & sMudurAdiSoyadi & "', " & nPersonelAdeti & ", " & bEnvanterGosterme & ", " & bKod3ZorunluMu & ", " & bTalepDogrulamaKontrol & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSubeMagaza(sSubeMagaza, sAciklama, bIskontolarAyri, bHerFaturaAyriFis, bKdvIskEkTekKalemde, bHerMagazadaAyriSatHesVar, bHareketTipineGoreAyri, sMasrafYontemi) VALUES('" & Microsoft.VisualBasic.Right(Trim(sDepo), 3) & "', N'" & sAciklama & "', 0, 0, 0, 0, 0, '')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbHareketTipi(sHareketTipi, sAciklama, bIkinciFormmu) VALUES('" & Microsoft.VisualBasic.Right(Trim(sDepo), 3) & "', N'" & sAciklama & "', 0)")
        cmd.ExecuteNonQuery()
        con.Close()
        Try
            tbAvSirano_kaydet_yeni(sDepo, 1, "Alisveris Son Sira No", 1)
            tbAvSirano_kaydet_yeni(sDepo, 2, "Odeme     Son Sira No", 1)
            tbAvSirano_kaydet_yeni(sDepo, 3, "Taksit    Son Sira No", 1)
            tbAvSirano_kaydet_yeni(sDepo, 4, "Masraf    Son Sira No", 1)
            tbAvSirano_kaydet_yeni(sDepo, 5, "Siparis   Son Sira No", 1)
            tbStokFisNolar_kaydet_yeni(sDepo, 0, 500000000, 0, 500000000, 0, 500000000, 0, 500000000, 0, 500000000, 0, 500000000, 0, 500000000, 0, 500000000, 0, 500000000, 0, 500000000, 0, 500000000, 0, 0, 500000000)
            tbParamAlisVeris_kaydet_yeni(1, 1, 1, 1, "", 1, 1, 1, 1, 45, 0, "Eþit Daðýt", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "Fatura", "", "", "", "", "", "", "", "", "", "", "", "", 0, 1, 1, 1, 1, 31, 0, 0, 31, 0, 0, 31, 0, 0, 1, 0, 1, 1, 1, "", 1, 1, 1, 1, "", 1, 1, 1, 1, 1, "", "", 1, 1, sDepo, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1, 1, 1, "", 1, 1, 1, 0, 0, "", "", "", "", "", "", "", "", "", "", "", "", "", "", 0, 1, 1, 0, 0, 0, 0)
        Catch ex As Exception
        End Try
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbAvSirano_kaydet_yeni(ByVal sDepo As String, ByVal nSiraIndex As Integer, ByVal sAciklama As String, ByVal nSonID As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbAVSiraNo (sDepo, nSiraIndex, sAciklama, nSonID) VALUES     ('" & sDepo & "', " & nSiraIndex & ", N'" & sAciklama & "', " & nSonID & " )")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFisNolar_kaydet_yeni(ByVal sDepo As String, ByVal lDepoCikis1 As Int64, ByVal lDepoCikis2 As Int64, ByVal lTransferFisi1 As Int64, ByVal lTransferFisi2 As Int64, ByVal lSevkIrsaliyesi1 As Int64, ByVal lSevkIrsaliyesi2 As Int64, ByVal lSevkFaturasi1 As Int64, ByVal lSevkFaturasi2 As Int64, ByVal lKonsinyeIrsaliye1 As Int64, ByVal lKonsinyeIrsaliye2 As Int64, ByVal lKonsinyeFatura1 As Int64, ByVal lKonsinyeFatura2 As Int64, ByVal lUretimFisi1 As Int64, ByVal lUretimFisi2 As Int64, ByVal lToptanFatura1 As Int64, ByVal lToptanFatura2 As Int64, ByVal lToptanIrsaliye1 As Int64, ByVal lToptanIrsaliye2 As Int64, ByVal lPerakendeFatura1 As Int64, ByVal lPerakendeFatura2 As Int64, ByVal lPerakendeIade1 As Int64, ByVal lPerakendeIade2 As Int64, ByVal lYazarKasaFisNo As Int64, ByVal lOdemeNo1 As Int64, ByVal lOdemeNo2 As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
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
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbParamAlisVeris(bSaticiRumuzuVarmi, bEnvanterGosterilsinmi, bEksiKontroluVarmi, bMalBazindaOdemePlaniVarmi, sSabitOdemeKodu, bOdemePlaniDegistirilsinmi, bPesinatDegistirilsinmi, bTaksitTutDegistirilsinmi, bTaksitTarDegistirilsinmi, nITMAXG, nMinPesinatYuzdesi, sPesinatEksikligiDagilimi, lESPF, lPesinatYuvarlama, lTaksitYuvarlama, bSatisAnindaVadeFarkiVarmi, nSatisVadeFarkiYuzdesi, bVFYTaksitleCarpilsinmi, nGecikmeVadeFarkiYuzdesi, nGSGG, lGSGT, bVFTS, bVadeFarkinaKDVDahilmi, sVadeFarkiKdvTipi, sSatisIcinDokulecek, sFaturaFormu1, sSatisFisiFormu1, sSenetFormu1, sOdemeFormu1, sPesinFormu1, sIadeFormu1, sFaturaFormu2, sSatisFisiFormu2, sSenetFormu2, sOdemeFormu2, sPesinFormu2, sIadeFormu2, bTarihDegistirilebilsinmi, bLimitAsimiIzinlimi, bGecikmeIzinlimi, bEskilerIptalEdilsinmi, bSatistaMagazaSorulacakmi, nAlisGun1, nOdemeTipi1, nOdemeGun1, nAlisGun2, nOdemeTipi2, nOdemeGun2, nAlisGun3, nOdemeTipi3, nOdemeGun3, bMiktarDegistirilsinmi, bReyonFisnoVarmi, bEanVarmi, bTeslimatVarmi, nTeslimatGunu, sDefaultPesinFiyatTipi, bPFiyatTipiDegistrilsinmi, bPesinMalIskontoVarmi, bPesinDipIskontoVarmi, bPFiyatDegistirilsinmi, sDefaultKrediFiyatTipi, bKFiyatTipiDegistrilsinmi, bKrediMalIskontoVarmi, bKrediDipIskontoVarmi, bKFiyatDegistirilsinmi, bRaporlarSifrelimi, sVadeFarkiFaturaFormu1, sVadeFarkiFaturaFormu2, bAgirlikBarkoduVarmi, nMinVadeFarkiYuzdesi, sMagazaKodu, bPFiyatSatirdaOlsun, bPHediyeCekiBasilacak, bPHediyeCekiAlinacak, bPOdemeTipineGoreFiyatVar, bKFiyatSatirdaOlsun, bKHediyeCekiBasilacak, bKHediyeCekiAlinacak, bKOdemeTipineGoreFiyatVar, bStokResmiVar, bMusteriResmiVar, bKrediKartNoSorsun, bDokumdeYaziciSorsun, bYalnizSonFaturaYenidenDok, bMusteriNotuSatisaGelsin, lDefaultMusteriKodu, bPIndirimKuponuBasilacak, bPIndirimKuponuAlinacak, bPPromosyonVar, bKPromosyonVar, sDefaultHareketTipi, bDovizliGirisVar, bEkSoru1, bEkSoru2, nParametre1, nParametre2, sTaxFreeFormu, sDiplomatikFormu, sHediyeCeki, sIndirimKuponu, sPSiparisFormu1, sPSiparisIadeFormu1, sPSiparisFormu2, sPSiparisIadeFormu2, sKSiparisFormu1, sKSiparisIadeFormu1, sKSiparisFormu2, sKSiparisIadeFormu2, sYedekFormu1, sYedekFormu2, bPartiVar, bPSonraTeslimVar, bKSonraTeslimVar, bEkSoru3, bEkSoru4, bEkSoru5, bEkSoru6) VALUES (" & bSaticiRumuzuVarmi & ", " & bEnvanterGosterilsinmi & ", " & bEksiKontroluVarmi & ", " & bMalBazindaOdemePlaniVarmi & ", '" & sSabitOdemeKodu & "', " & bOdemePlaniDegistirilsinmi & ", " & bPesinatDegistirilsinmi & ", " & bTaksitTutDegistirilsinmi & ", " & bTaksitTarDegistirilsinmi & ", " & nITMAXG & ", " & nMinPesinatYuzdesi & ", '" & sPesinatEksikligiDagilimi & "', " & lESPF & ", " & lPesinatYuvarlama & ", " & lTaksitYuvarlama & ", " & bSatisAnindaVadeFarkiVarmi & ", " & nSatisVadeFarkiYuzdesi & ", " & bVFYTaksitleCarpilsinmi & ", " & nGecikmeVadeFarkiYuzdesi & ", " & nGSGG & ", " & lGSGT & ", " & bVFTS & ", " & bVadeFarkinaKDVDahilmi & ", '" & sVadeFarkiKdvTipi & "', '" & sSatisIcinDokulecek & "', '" & sFaturaFormu1 & "', '" & sSatisFisiFormu1 & "', '" & sSenetFormu1 & "', '" & sOdemeFormu1 & "', '" & sPesinFormu1 & "', '" & sIadeFormu1 & "', '" & sFaturaFormu2 & "', '" & sSatisFisiFormu2 & "', '" & sSenetFormu2 & "', '" & sOdemeFormu2 & "', '" & sPesinFormu2 & "', '" & sIadeFormu2 & "', " & bTarihDegistirilebilsinmi & ", " & bLimitAsimiIzinlimi & ", " & bGecikmeIzinlimi & ", " & bEskilerIptalEdilsinmi & ", " & bSatistaMagazaSorulacakmi & ", " & nAlisGun1 & ", " & nOdemeTipi1 & ", " & nOdemeGun1 & ", " & nAlisGun2 & ", " & nOdemeTipi2 & ", " & nOdemeGun2 & ", " & nAlisGun3 & ", " & nOdemeTipi3 & ", " & nOdemeGun3 & ", " & bMiktarDegistirilsinmi & ", " & bReyonFisnoVarmi & ", " & bEanVarmi & ", " & bTeslimatVarmi & ", " & nTeslimatGunu & ", '" & sDefaultPesinFiyatTipi & "', " & bPFiyatTipiDegistrilsinmi & ", " & bPesinMalIskontoVarmi & ", " & bPesinDipIskontoVarmi & ", " & bPFiyatDegistirilsinmi & ", '" & sDefaultKrediFiyatTipi & "', " & bKFiyatTipiDegistrilsinmi & ", " & bKrediMalIskontoVarmi & ", " & bKrediDipIskontoVarmi & ", " & bKFiyatDegistirilsinmi & ", " & bRaporlarSifrelimi & ", '" & sVadeFarkiFaturaFormu1 & "', '" & sVadeFarkiFaturaFormu2 & "', " & bAgirlikBarkoduVarmi & ", " & nMinVadeFarkiYuzdesi & ", '" & sMagazaKodu & "', " & bPFiyatSatirdaOlsun & ", " & bPHediyeCekiBasilacak & ", " & bPHediyeCekiAlinacak & ", " & bPOdemeTipineGoreFiyatVar & ", " & bKFiyatSatirdaOlsun & ", " & bKHediyeCekiBasilacak & ", " & bKHediyeCekiAlinacak & ", " & bKOdemeTipineGoreFiyatVar & ", " & bStokResmiVar & ", " & bMusteriResmiVar & ", " & bKrediKartNoSorsun & ", " & bDokumdeYaziciSorsun & ", " & bYalnizSonFaturaYenidenDok & ", " & bMusteriNotuSatisaGelsin & ", " & lDefaultMusteriKodu & ", " & bPIndirimKuponuBasilacak & "," & bPIndirimKuponuAlinacak & ", " & bPPromosyonVar & ", " & bKPromosyonVar & ", '" & sDefaultHareketTipi & "', " & bDovizliGirisVar & ", " & bEkSoru1 & ", " & bEkSoru2 & ", " & nParametre1 & ", " & nParametre2 & ", '" & sTaxFreeFormu & "', '" & sDiplomatikFormu & "', '" & sHediyeCeki & "', '" & sIndirimKuponu & "', '" & sPSiparisFormu1 & "', '" & sPSiparisIadeFormu1 & "', '" & sPSiparisFormu2 & "', '" & sPSiparisIadeFormu2 & "', '" & sKSiparisFormu1 & "', '" & sKSiparisIadeFormu1 & "', '" & sKSiparisFormu2 & "', '" & sKSiparisIadeFormu2 & "', '" & sYedekFormu1 & "', '" & sYedekFormu2 & "', " & bPartiVar & ", " & bPSonraTeslimVar & ", " & bKSonraTeslimVar & ", " & bEkSoru3 & ", " & bEkSoru4 & ", " & bEkSoru5 & ", " & bEkSoru6 & ")")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbDepo_kaydet_duzelt(ByVal sDepo As String, ByVal sAciklama As String, ByVal nFirmaID As Int64, ByVal sSube As String, ByVal sDepoTipi As String, ByVal sEmail As String, ByVal nKatSayisi As Int64, ByVal nMagazaM2 As Int64, ByVal nDepoM2 As Int64, ByVal sKiraDovizCinsi As String, ByVal lKiraBedeli As Decimal, ByVal dteAcilisTarihi As DateTime, ByVal dteSonDekorasyon As DateTime, ByVal sMudurAdiSoyadi As String, ByVal nPersonelAdeti As Int64, ByVal bEnvanterGosterme As Integer, ByVal bKod3ZorunluMu As Integer, ByVal bTalepDogrulamaKontrol As Byte)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbDepo SET sAciklama = N'" & sAciklama & "', nFirmaID = " & nFirmaID & ", sSube = '" & sSube & "', sDepoTipi = '" & sDepoTipi & "', sEmail = '" & sEmail & "', nKatSayisi = " & nKatSayisi & ", nMagazaM2 = " & nMagazaM2 & ", nDepoM2 = " & nDepoM2 & ", sKiraDovizCinsi = '" & sKiraDovizCinsi & "', lKiraBedeli = " & lKiraBedeli & ", dteAcilisTarihi = '" & dteAcilisTarihi & "', dteSonDekorasyon = '" & dteSonDekorasyon & "', sMudurAdiSoyadi = '" & sMudurAdiSoyadi & "', nPersonelAdeti = " & nPersonelAdeti & ", bEnvanterGosterme = " & bEnvanterGosterme & ", bKod3ZorunluMu = " & bKod3ZorunluMu & ", bTalepDogrulamaKontrol = " & bTalepDogrulamaKontrol & " Where sDepo = '" & sDepo & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbDepo_kaydet_sil(ByVal sDepo As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbStokFisNolar  Where sDepo = '" & sDepo & "'")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbDepo  Where sDepo = '" & sDepo & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub kayit_ekle()
        XtraTabPage1.PageVisible = False
        XtraTabPage2.PageVisible = True
        txt_sDepoKodu.EditValue = ""
        txt_sAciklama.EditValue = ""
        sec_sDepoTipi.EditValue = ""
        sec_tbFirma.Text = 0
        sec_sSube.EditValue = ""
        txt_sEmail.EditValue = ""
        txt_nCalisanSayisi.EditValue = 1
        txt_sMagazaMuduru.EditValue = ""
        txt_nMagazaM2.EditValue = 0
        txt_nDepoM2.EditValue = 0
        txt_nKatSayisi.EditValue = 0
        sec_sDovizCinsi.EditValue = ""
        txt_lKiraBedeli.EditValue = 0
        txt_dteAcilisTarihi.EditValue = "01/01/1900"
        txt_dteDekorasyonTarihi.EditValue = "01/01/1900"
        txt_sDepoKodu.Enabled = True
        islem = "Ekle"
        sec_bEnvanterGosterme.Checked = False
        sec_bKod3ZorunluMu.Checked = False
        sec_bTalepDogrulamaKontrol.Checked = False
        txt_sDepoKodu.Focus()
        txt_sDepoKodu.Select()
    End Sub
    Private Sub kayit_duzelt()
        If bParamAlisVeris = False Then
            XtraTabPage1.PageVisible = False
            XtraTabPage2.PageVisible = True
            satir = GridView1.FocusedRowHandle
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            txt_sDepoKodu.EditValue = dr("sDepo")
            txt_sAciklama.EditValue = dr("sAciklama")
            sec_sDepoTipi.EditValue = dr("sDepoTipi")
            sec_tbFirma.Text = dr("nFirmaID")
            sec_sSube.EditValue = dr("sSube")
            txt_sEmail.EditValue = dr("sEmail")
            txt_nCalisanSayisi.EditValue = dr("nPersonelAdeti")
            txt_sMagazaMuduru.EditValue = dr("sMudurAdiSoyadi")
            txt_nMagazaM2.EditValue = dr("nMagazaM2")
            txt_nDepoM2.EditValue = dr("nDepoM2")
            txt_nKatSayisi.EditValue = dr("nKatSayisi")
            sec_sDovizCinsi.EditValue = dr("sKiraDovizCinsi")
            txt_lKiraBedeli.EditValue = dr("lKiraBedeli")
            txt_dteAcilisTarihi.EditValue = dr("dteAcilisTarihi")
            txt_dteDekorasyonTarihi.EditValue = dr("dteSonDekorasyon")
            sec_bEnvanterGosterme.Checked = Boolean.Parse(dr("bEnvanterGosterme").ToString())
            sec_bKod3ZorunluMu.Checked = Boolean.Parse(dr("bKod3ZorunluMu").ToString())
            sec_bTalepDogrulamaKontrol.Checked = Boolean.Parse(dr("bTalepDogrulamaKontrol").ToString())
            txt_sDepoKodu.Enabled = False
            islem = "Düzelt"
            dr = Nothing
            txt_sAciklama.Focus()
            txt_sAciklama.SelectAll()
        Else
            tbParamAlisVeris()
        End If
    End Sub
    Private Sub tbParamAlisVeris()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_Perakende_Parametre
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sMagaza = dr("sDepo")
            frm.ShowDialog()
            dr = Nothing
        End If
    End Sub
    Private Sub kayit_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Kaydý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            tbDepo_kaydet_sil(dr("sDepo"))
            Dataload_tbDepo()
        End If
    End Sub
    Private Sub kaydet()
        If sec_tbFirma.Text = "" Then
            sec_tbFirma.Text = "0"
        End If
        Dim bEnvanterGosterme As Integer = 0
        Dim bKod3ZorunluMu As Integer = 0
        If sec_bEnvanterGosterme.Checked = True Then
            bEnvanterGosterme = 1
        Else
            bEnvanterGosterme = 0
        End If
        If sec_bKod3ZorunluMu.Checked = True Then
            bKod3ZorunluMu = 1
        Else
            bKod3ZorunluMu = 0
        End If
        If islem = "Ekle" Then
            tbDepo_kaydet_yeni(txt_sDepoKodu.EditValue, txt_sAciklama.EditValue, sec_tbFirma.Text, sec_sSube.EditValue, sec_sDepoTipi.EditValue, txt_sEmail.EditValue, txt_nKatSayisi.EditValue, txt_nMagazaM2.EditValue, txt_nDepoM2.EditValue, sec_sDovizCinsi.EditValue, txt_lKiraBedeli.EditValue, txt_dteAcilisTarihi.EditValue, txt_dteDekorasyonTarihi.EditValue, txt_sMagazaMuduru.EditValue, txt_nCalisanSayisi.EditValue, bEnvanterGosterme, bKod3ZorunluMu, CType(sec_bTalepDogrulamaKontrol.EditValue, Byte))
            Dataload_tbDepo()
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
        ElseIf islem = "Düzelt" Then
            tbDepo_kaydet_duzelt(txt_sDepoKodu.EditValue, txt_sAciklama.EditValue, sec_tbFirma.Text, sec_sSube.EditValue, sec_sDepoTipi.EditValue, txt_sEmail.EditValue, txt_nKatSayisi.EditValue, txt_nMagazaM2.EditValue, txt_nDepoM2.EditValue, sec_sDovizCinsi.EditValue, txt_lKiraBedeli.EditValue, txt_dteAcilisTarihi.EditValue, txt_dteDekorasyonTarihi.EditValue, txt_sMagazaMuduru.EditValue, txt_nCalisanSayisi.EditValue, bEnvanterGosterme, bKod3ZorunluMu, CType(sec_bTalepDogrulamaKontrol.EditValue, Byte))
            Dataload_tbDepo()
            GridView1.FocusedRowHandle = satir
        End If
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = False
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_text()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Text Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Text Dosyalarý(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_pdf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Metin Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyalarý(*.pdf) |*.pdf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub EkleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EkleToolStripMenuItem.Click
        kayit_ekle()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub GörünümüDüzenleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüDüzenleToolStripMenuItem.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub GörünümüKaydetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüKaydetToolStripMenuItem.Click
        gorunum_kaydet()
    End Sub
    Private Sub GörünümüYazdýrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüYazdýrToolStripMenuItem.Click
        gorunum_yazdir()
    End Sub
    Private Sub HýzlýFiltreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HýzlýFiltreToolStripMenuItem.Click
        If HýzlýFiltreToolStripMenuItem.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsView.ShowAutoFilterRow = True
            HýzlýFiltreToolStripMenuItem.Checked = True
        ElseIf HýzlýFiltreToolStripMenuItem.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsView.ShowAutoFilterRow = False
            HýzlýFiltreToolStripMenuItem.Checked = False
        End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If MenuItem6.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            MenuItem6.Checked = True
        ElseIf MenuItem6.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            MenuItem6.Checked = False
        End If
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        If MenuItem7.Checked = False Then
            GridView1.OptionsCustomization.AllowGroup = True
            GridView1.OptionsView.ShowGroupPanel = True
            MenuItem7.Checked = True
        ElseIf MenuItem7.Checked = True Then
            GridView1.OptionsCustomization.AllowGroup = False
            GridView1.OptionsView.ShowGroupPanel = False
            MenuItem7.Checked = False
        End If
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub DuzeltToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DuzeltToolStripMenuItem.Click
        kayit_duzelt()
    End Sub
    Private Sub SilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SilToolStripMenuItem.Click
        kayit_sil()
    End Sub
    Private Sub btn_vazgec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_vazgec.Click
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = False
    End Sub
    Private Sub btn_kaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_kaydet.Click
        kaydet()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Editör Ekranýný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        kayit_ekle()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        kayit_duzelt()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        kayit_sil()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        raporla_pdf()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        kayit_duzelt()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            kayit_duzelt()
        End If
    End Sub
    Private Sub sec_tbFirma_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles sec_tbFirma.ButtonPressed
        referans_sec()
    End Sub
    Private Sub sec_tbFirma_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_tbFirma.TextChanged
        lbl_Firma.Text = sorgula_String("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  Select sAciklama from tbFirma Where nFirmaID ='" & sec_tbFirma.Text & "'")
    End Sub
    Private Sub sec_tbFirma_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_tbFirma.Validating
        If sec_tbFirma.Text = "" Then
            sec_tbFirma.Text = "0"
        End If
    End Sub
End Class