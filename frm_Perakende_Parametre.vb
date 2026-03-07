Public Class frm_Perakende_Parametre
    Public firmano
    Public donemno
    Public connection
    Dim ds_tbKrediliFiyatTipi As DataSet
    Dim ds_tbPesinFiyatTipi As DataSet
    Dim ds_tbKdv As DataSet
    Dim ds_tbOdemePlani As DataSet
    Dim ds_tbHareketTipi As DataSet
    Dim ds_tbSatici As DataSet
    Dim ds_tbDepo As DataSet
    Public sMagaza As String = ""
    Private Sub frm_Perakende_Parametre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload()
        dataload_tbFiyatTipi()
        Dim dr As DataRow = DataSet1.Tables(0).Rows(0)
        sec_sSatisIcinDokulecek.Text = dr("sSatisIcinDokulecek")
        'MsgBox(dr("sSatisIcinDokulecek"))
        sec_bS_Bulundugu_Ay1.SelectedIndex = dr("nOdemeTipi1")
        sec_bS_Bulundugu_Ay2.SelectedIndex = dr("nOdemeTipi2")
        sec_bS_Bulundugu_Ay3.SelectedIndex = dr("nOdemeTipi3")
        If dr("nParametre2") = 0 Then
            sec_bSatilmayanIadeEdilemesin.Checked = False
        ElseIf dr("nParametre2") = 1 Then
            sec_bSatilmayanIadeEdilemesin.Checked = True
        End If
        ButtonEdit1.Enabled = CheckEdit2.Checked
    End Sub
    Private Sub dataload()
        sorgu_tbParamAlisVeris("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select * from tbParamAlisVeris Where sMagazaKodu ='" & sMagaza & "'")
    End Sub
    Private Sub dataload_tbFiyatTipi()
        ds_tbKrediliFiyatTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFiyatTipi,sAciklama FROM         tbFiyatTipi "))
        ds_tbPesinFiyatTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFiyatTipi,sAciklama FROM         tbFiyatTipi "))
        ds_tbKdv = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sKdvTipi,nKdvOrani FROM         tbKdv "))
        ds_tbHareketTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST(sHareketTipi AS CHAR(4)) AS sHareketTipi, sAciklama FROM         tbHareketTipi where aktif = 1"))
        ds_tbSatici = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu,sAdi FROM         tbSatici where (bAktif = 1)"))
        ds_tbDepo = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo,sAciklama FROM         tbDepo "))
        ds_tbOdemePlani = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED select sOdemeKodu, sAciklama, nPesinatYuzdesi as [Peþinat Yüzdesi], nTaksitAdeti as [Taksit Adeti], nTaksitYuzde1 as [%1], nTaksitYuzde2 as [%2],nTaksitYuzde3 as [%3],nTaksitYuzde4 as [%4],nTaksitYuzde5 as [%5]  from tbOdemePlani order by sAciklama "))
        sDefaultPesinFiyatTipi.Properties.DataSource = ds_tbPesinFiyatTipi.Tables(0)
        sec_sDefaultKrediFiyatTipi.Properties.DataSource = ds_tbKrediliFiyatTipi.Tables(0)
        sec_sVadeFarkiKdvTipi.Properties.DataSource = ds_tbKdv.Tables(0)
        sec_sHareketTipi.Properties.DataSource = ds_tbHareketTipi.Tables(0)
        sec_sSabitOdemeKodu.Properties.DataSource = ds_tbOdemePlani.Tables(0)
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
    Private Sub sorgu_tbParamAlisVeris(ByVal query As String)
        Try
            DataSet1.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim N As Integer = adapter.Fill(DataSet1, "Table1")
        con.Close()
    End Sub
    Private Sub tbParamAlisVeris_kaydet_yeni(ByVal bSaticiRumuzuVarmi As Byte, ByVal bEnvanterGosterilsinmi As Byte, ByVal bEksiKontroluVarmi As Byte, ByVal bMalBazindaOdemePlaniVarmi As Byte, ByVal sSabitOdemeKodu As String, ByVal bOdemePlaniDegistirilsinmi As Byte, ByVal bPesinatDegistirilsinmi As Byte, ByVal bTaksitTutDegistirilsinmi As Byte, ByVal bTaksitTarDegistirilsinmi As Byte, ByVal nITMAXG As Int64, ByVal nMinPesinatYuzdesi As Decimal, ByVal sPesinatEksikligiDagilimi As String, ByVal lESPF As Decimal, ByVal lPesinatYuvarlama As Decimal, ByVal lTaksitYuvarlama As Decimal, ByVal bSatisAnindaVadeFarkiVarmi As Byte, ByVal nSatisVadeFarkiYuzdesi As Decimal, ByVal bVFYTaksitleCarpilsinmi As Byte, ByVal nGecikmeVadeFarkiYuzdesi As Decimal, ByVal nGSGG As Decimal, ByVal lGSGT As Decimal, ByVal bVFTS As Byte, ByVal bVadeFarkinaKDVDahilmi As Byte, ByVal sVadeFarkiKdvTipi As String, ByVal sSatisIcinDokulecek As String, ByVal sFaturaFormu1 As String, ByVal sSatisFisiFormu1 As String, ByVal sSenetFormu1 As String, ByVal sOdemeFormu1 As String, ByVal sPesinFormu1 As String, ByVal sIadeFormu1 As String, ByVal sFaturaFormu2 As String, ByVal sSatisFisiFormu2 As String, ByVal sSenetFormu2 As String, ByVal sOdemeFormu2 As String, ByVal sPesinFormu2 As String, ByVal sIadeFormu2 As String, ByVal bTarihDegistirilebilsinmi As Byte, ByVal bLimitAsimiIzinlimi As Byte, ByVal bGecikmeIzinlimi As Byte, ByVal bEskilerIptalEdilsinmi As Byte, ByVal bSatistaMagazaSorulacakmi As Byte, ByVal nAlisGun1 As Integer, ByVal nOdemeTipi1 As Integer, ByVal nOdemeGun1 As Integer, ByVal nAlisGun2 As Integer, ByVal nOdemeTipi2 As Integer, ByVal nOdemeGun2 As Integer, ByVal nAlisGun3 As Integer, ByVal nOdemeTipi3 As Integer, ByVal nOdemeGun3 As Integer, ByVal bMiktarDegistirilsinmi As Byte, ByVal bReyonFisnoVarmi As Byte, ByVal bEanVarmi As Byte, ByVal bTeslimatVarmi As Byte, ByVal nTeslimatGunu As Integer, ByVal sDefaultPesinFiyatTipi As String, ByVal bPFiyatTipiDegistrilsinmi As Byte, ByVal bPesinMalIskontoVarmi As Byte, ByVal bPesinDipIskontoVarmi As Byte, ByVal bPFiyatDegistirilsinmi As Byte, ByVal sDefaultKrediFiyatTipi As String, ByVal bKFiyatTipiDegistrilsinmi As Byte, ByVal bKrediMalIskontoVarmi As Byte, ByVal bKrediDipIskontoVarmi As Byte, ByVal bKFiyatDegistirilsinmi As Byte, ByVal bRaporlarSifrelimi As Byte, ByVal sVadeFarkiFaturaFormu1 As String, ByVal sVadeFarkiFaturaFormu2 As String, ByVal bAgirlikBarkoduVarmi As Byte, ByVal nMinVadeFarkiYuzdesi As Decimal, ByVal sMagazaKodu As String, ByVal bPFiyatSatirdaOlsun As Byte, ByVal bPHediyeCekiBasilacak As Byte, ByVal bPHediyeCekiAlinacak As Byte, ByVal bPOdemeTipineGoreFiyatVar As Byte, ByVal bKFiyatSatirdaOlsun As Byte, ByVal bKHediyeCekiBasilacak As Byte, ByVal bKHediyeCekiAlinacak As Byte, ByVal bKOdemeTipineGoreFiyatVar As Byte, ByVal bStokResmiVar As Byte, ByVal bMusteriResmiVar As Byte, ByVal bKrediKartNoSorsun As Byte, ByVal bDokumdeYaziciSorsun As Byte, ByVal bYalnizSonFaturaYenidenDok As Byte, ByVal bMusteriNotuSatisaGelsin As Byte, ByVal lDefaultMusteriKodu As Int64, ByVal bPIndirimKuponuBasilacak As Byte, ByVal bPIndirimKuponuAlinacak As Byte, ByVal bPPromosyonVar As Byte, ByVal bKPromosyonVar As Byte, ByVal sDefaultHareketTipi As String, ByVal bDovizliGirisVar As Byte, ByVal bEkSoru1 As Byte, ByVal bEkSoru2 As Byte, ByVal nParametre1 As Int64, ByVal nParametre2 As Int64, ByVal sTaxFreeFormu As String, ByVal sDiplomatikFormu As String, ByVal sHediyeCeki As String, ByVal sIndirimKuponu As String, ByVal sPSiparisFormu1 As String, ByVal sPSiparisIadeFormu1 As String, ByVal sPSiparisFormu2 As String, ByVal sPSiparisIadeFormu2 As String, ByVal sKSiparisFormu1 As String, ByVal sKSiparisIadeFormu1 As String, ByVal sKSiparisFormu2 As String, ByVal sKSiparisIadeFormu2 As String, ByVal sYedekFormu1 As String, ByVal sYedekFormu2 As String, ByVal bPartiVar As Byte, ByVal bPSonraTeslimVar As Byte, ByVal bKSonraTeslimVar As Byte, ByVal bEkSoru3 As Byte, ByVal bEkSoru4 As Byte, ByVal bEkSoru5 As Byte, ByVal bEkSoru6 As Byte, ByVal fatAcik As Byte, ByVal PesinFarkliSatir As Byte, ByVal bHizliYazdir As Byte, ByVal sHizliYazdirYol As String, ByVal bFiyatTipiZorunlumu As Byte)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbParamAlisVeris(bSaticiRumuzuVarmi, bEnvanterGosterilsinmi, bEksiKontroluVarmi, bMalBazindaOdemePlaniVarmi, sSabitOdemeKodu, bOdemePlaniDegistirilsinmi, bPesinatDegistirilsinmi, bTaksitTutDegistirilsinmi, bTaksitTarDegistirilsinmi, nITMAXG, nMinPesinatYuzdesi, sPesinatEksikligiDagilimi, lESPF, lPesinatYuvarlama, lTaksitYuvarlama, bSatisAnindaVadeFarkiVarmi, nSatisVadeFarkiYuzdesi, bVFYTaksitleCarpilsinmi, nGecikmeVadeFarkiYuzdesi, nGSGG, lGSGT, bVFTS, bVadeFarkinaKDVDahilmi, sVadeFarkiKdvTipi, sSatisIcinDokulecek, sFaturaFormu1, sSatisFisiFormu1, sSenetFormu1, sOdemeFormu1, sPesinFormu1, sIadeFormu1, sFaturaFormu2, sSatisFisiFormu2, sSenetFormu2, sOdemeFormu2, sPesinFormu2, sIadeFormu2, bTarihDegistirilebilsinmi, bLimitAsimiIzinlimi, bGecikmeIzinlimi, bEskilerIptalEdilsinmi, bSatistaMagazaSorulacakmi, nAlisGun1, nOdemeTipi1, nOdemeGun1, nAlisGun2, nOdemeTipi2, nOdemeGun2, nAlisGun3, nOdemeTipi3, nOdemeGun3, bMiktarDegistirilsinmi, bReyonFisnoVarmi, bEanVarmi, bTeslimatVarmi, nTeslimatGunu, sDefaultPesinFiyatTipi, bPFiyatTipiDegistrilsinmi, bPesinMalIskontoVarmi, bPesinDipIskontoVarmi, bPFiyatDegistirilsinmi, sDefaultKrediFiyatTipi, bKFiyatTipiDegistrilsinmi, bKrediMalIskontoVarmi, bKrediDipIskontoVarmi, bKFiyatDegistirilsinmi, bRaporlarSifrelimi, sVadeFarkiFaturaFormu1, sVadeFarkiFaturaFormu2, bAgirlikBarkoduVarmi, nMinVadeFarkiYuzdesi, sMagazaKodu, bPFiyatSatirdaOlsun, bPHediyeCekiBasilacak, bPHediyeCekiAlinacak, bPOdemeTipineGoreFiyatVar, bKFiyatSatirdaOlsun, bKHediyeCekiBasilacak, bKHediyeCekiAlinacak, bKOdemeTipineGoreFiyatVar, bStokResmiVar, bMusteriResmiVar, bKrediKartNoSorsun, bDokumdeYaziciSorsun, bYalnizSonFaturaYenidenDok, bMusteriNotuSatisaGelsin, lDefaultMusteriKodu, bPIndirimKuponuBasilacak, bPIndirimKuponuAlinacak, bPPromosyonVar, bKPromosyonVar, sDefaultHareketTipi, bDovizliGirisVar, bEkSoru1, bEkSoru2, nParametre1, nParametre2, sTaxFreeFormu, sDiplomatikFormu, sHediyeCeki, sIndirimKuponu, sPSiparisFormu1, sPSiparisIadeFormu1, sPSiparisFormu2, sPSiparisIadeFormu2, sKSiparisFormu1, sKSiparisIadeFormu1, sKSiparisFormu2, sKSiparisIadeFormu2, sYedekFormu1, sYedekFormu2, bPartiVar, bPSonraTeslimVar, bKSonraTeslimVar, bEkSoru3, bEkSoru4, bEkSoru5, bEkSoru6, bHizliYazdir, sHizliYazdirYol, bFiyatTipiZorunlumu) VALUES (" & bSaticiRumuzuVarmi & ", " & bEnvanterGosterilsinmi & ", " & bEksiKontroluVarmi & ", " & bMalBazindaOdemePlaniVarmi & ", '" & sSabitOdemeKodu & "', " & bOdemePlaniDegistirilsinmi & ", " & bPesinatDegistirilsinmi & ", " & bTaksitTutDegistirilsinmi & ", " & bTaksitTarDegistirilsinmi & ", " & nITMAXG & ", " & nMinPesinatYuzdesi & ", '" & sPesinatEksikligiDagilimi & "', " & lESPF & ", " & lPesinatYuvarlama & ", " & lTaksitYuvarlama & ", " & bSatisAnindaVadeFarkiVarmi & ", " & nSatisVadeFarkiYuzdesi & ", " & bVFYTaksitleCarpilsinmi & ", " & nGecikmeVadeFarkiYuzdesi & ", " & nGSGG & ", " & lGSGT & ", " & bVFTS & ", " & bVadeFarkinaKDVDahilmi & ", '" & sVadeFarkiKdvTipi & "', '" & sSatisIcinDokulecek & "', '" & sFaturaFormu1 & "', '" & sSatisFisiFormu1 & "', '" & sSenetFormu1 & "', '" & sOdemeFormu1 & "', '" & sPesinFormu1 & "', '" & sIadeFormu1 & "', '" & sFaturaFormu2 & "', '" & sSatisFisiFormu2 & "', '" & sSenetFormu2 & "', '" & sOdemeFormu2 & "', '" & sPesinFormu2 & "', '" & sIadeFormu2 & "', " & bTarihDegistirilebilsinmi & ", " & bLimitAsimiIzinlimi & ", " & bGecikmeIzinlimi & ", " & bEskilerIptalEdilsinmi & ", " & bSatistaMagazaSorulacakmi & ", " & nAlisGun1 & ", " & nOdemeTipi1 & ", " & nOdemeGun1 & ", " & nAlisGun2 & ", " & nOdemeTipi2 & ", " & nOdemeGun2 & ", " & nAlisGun3 & ", " & nOdemeTipi3 & ", " & nOdemeGun3 & ", " & bMiktarDegistirilsinmi & ", " & bReyonFisnoVarmi & ", " & bEanVarmi & ", " & bTeslimatVarmi & ", " & nTeslimatGunu & ", '" & sDefaultPesinFiyatTipi & "', " & bPFiyatTipiDegistrilsinmi & ", " & bPesinMalIskontoVarmi & ", " & bPesinDipIskontoVarmi & ", " & bPFiyatDegistirilsinmi & ", '" & sDefaultKrediFiyatTipi & "', " & bKFiyatTipiDegistrilsinmi & ", " & bKrediMalIskontoVarmi & ", " & bKrediDipIskontoVarmi & ", " & bKFiyatDegistirilsinmi & ", " & bRaporlarSifrelimi & ", '" & sVadeFarkiFaturaFormu1 & "', '" & sVadeFarkiFaturaFormu2 & "', " & bAgirlikBarkoduVarmi & ", " & nMinVadeFarkiYuzdesi & ", '" & sMagazaKodu & "', " & bPFiyatSatirdaOlsun & ", " & bPHediyeCekiBasilacak & ", " & bPHediyeCekiAlinacak & ", " & bPOdemeTipineGoreFiyatVar & ", " & bKFiyatSatirdaOlsun & ", " & bKHediyeCekiBasilacak & ", " & bKHediyeCekiAlinacak & ", " & bKOdemeTipineGoreFiyatVar & ", " & bStokResmiVar & ", " & bMusteriResmiVar & ", " & bKrediKartNoSorsun & ", " & bDokumdeYaziciSorsun & ", " & bYalnizSonFaturaYenidenDok & ", " & bMusteriNotuSatisaGelsin & ", " & lDefaultMusteriKodu & ", " & bPIndirimKuponuBasilacak & "," & bPIndirimKuponuAlinacak & ", " & bPPromosyonVar & ", " & bKPromosyonVar & ", '" & sDefaultHareketTipi & "', " & bDovizliGirisVar & ", " & bEkSoru1 & ", " & bEkSoru2 & ", " & nParametre1 & ", " & nParametre2 & ", '" & sTaxFreeFormu & "', '" & sDiplomatikFormu & "', '" & sHediyeCeki & "', '" & sIndirimKuponu & "', '" & sPSiparisFormu1 & "', '" & sPSiparisIadeFormu1 & "', '" & sPSiparisFormu2 & "', '" & sPSiparisIadeFormu2 & "', '" & sKSiparisFormu1 & "', '" & sKSiparisIadeFormu1 & "', '" & sKSiparisFormu2 & "', '" & sKSiparisIadeFormu2 & "', '" & sYedekFormu1 & "', '" & sYedekFormu2 & "', " & bPartiVar & ", " & bPSonraTeslimVar & ", " & bKSonraTeslimVar & ", " & bEkSoru3 & ", " & bEkSoru4 & ", " & bEkSoru5 & ", " & bEkSoru6 & ", " & bHizliYazdir & ", '" & sHizliYazdirYol & "', " & bFiyatTipiZorunlumu & ")")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbParamAlisVeris_kaydet_duzelt(ByVal bSaticiRumuzuVarmi As Byte, ByVal bEnvanterGosterilsinmi As Byte, ByVal bEksiKontroluVarmi As Byte, ByVal bMalBazindaOdemePlaniVarmi As Byte, ByVal sSabitOdemeKodu As String, ByVal bOdemePlaniDegistirilsinmi As Byte, ByVal bPesinatDegistirilsinmi As Byte, ByVal bTaksitTutDegistirilsinmi As Byte, ByVal bTaksitTarDegistirilsinmi As Byte, ByVal nITMAXG As Int64, ByVal nMinPesinatYuzdesi As Decimal, ByVal sPesinatEksikligiDagilimi As String, ByVal lESPF As Decimal, ByVal lPesinatYuvarlama As Decimal, ByVal lTaksitYuvarlama As Decimal, ByVal bSatisAnindaVadeFarkiVarmi As Byte, ByVal nSatisVadeFarkiYuzdesi As Decimal, ByVal bVFYTaksitleCarpilsinmi As Byte, ByVal nGecikmeVadeFarkiYuzdesi As Decimal, ByVal nGSGG As Decimal, ByVal lGSGT As Decimal, ByVal bVFTS As Byte, ByVal bVadeFarkinaKDVDahilmi As Byte, ByVal sVadeFarkiKdvTipi As String, ByVal sSatisIcinDokulecek As String, ByVal sFaturaFormu1 As String, ByVal sSatisFisiFormu1 As String, ByVal sSenetFormu1 As String, ByVal sOdemeFormu1 As String, ByVal sPesinFormu1 As String, ByVal sIadeFormu1 As String, ByVal sFaturaFormu2 As String, ByVal sSatisFisiFormu2 As String, ByVal sSenetFormu2 As String, ByVal sOdemeFormu2 As String, ByVal sPesinFormu2 As String, ByVal sIadeFormu2 As String, ByVal bTarihDegistirilebilsinmi As Byte, ByVal bLimitAsimiIzinlimi As Byte, ByVal bGecikmeIzinlimi As Byte, ByVal bEskilerIptalEdilsinmi As Byte, ByVal bSatistaMagazaSorulacakmi As Byte, ByVal nAlisGun1 As Integer, ByVal nOdemeTipi1 As Integer, ByVal nOdemeGun1 As Integer, ByVal nAlisGun2 As Integer, ByVal nOdemeTipi2 As Integer, ByVal nOdemeGun2 As Integer, ByVal nAlisGun3 As Integer, ByVal nOdemeTipi3 As Integer, ByVal nOdemeGun3 As Integer, ByVal bMiktarDegistirilsinmi As Byte, ByVal bReyonFisnoVarmi As Byte, ByVal bEanVarmi As Byte, ByVal bTeslimatVarmi As Byte, ByVal nTeslimatGunu As Integer, ByVal sDefaultPesinFiyatTipi As String, ByVal bPFiyatTipiDegistrilsinmi As Byte, ByVal bPesinMalIskontoVarmi As Byte, ByVal bPesinDipIskontoVarmi As Byte, ByVal bPFiyatDegistirilsinmi As Byte, ByVal sDefaultKrediFiyatTipi As String, ByVal bKFiyatTipiDegistrilsinmi As Byte, ByVal bKrediMalIskontoVarmi As Byte, ByVal bKrediDipIskontoVarmi As Byte, ByVal bKFiyatDegistirilsinmi As Byte, ByVal bRaporlarSifrelimi As Byte, ByVal sVadeFarkiFaturaFormu1 As String, ByVal sVadeFarkiFaturaFormu2 As String, ByVal bAgirlikBarkoduVarmi As Byte, ByVal nMinVadeFarkiYuzdesi As Decimal, ByVal sMagazaKodu As String, ByVal bPFiyatSatirdaOlsun As Byte, ByVal bPHediyeCekiBasilacak As Byte, ByVal bPHediyeCekiAlinacak As Byte, ByVal bPOdemeTipineGoreFiyatVar As Byte, ByVal bKFiyatSatirdaOlsun As Byte, ByVal bKHediyeCekiBasilacak As Byte, ByVal bKHediyeCekiAlinacak As Byte, ByVal bKOdemeTipineGoreFiyatVar As Byte, ByVal bStokResmiVar As Byte, ByVal bMusteriResmiVar As Byte, ByVal bKrediKartNoSorsun As Byte, ByVal bDokumdeYaziciSorsun As Byte, ByVal bYalnizSonFaturaYenidenDok As Byte, ByVal bMusteriNotuSatisaGelsin As Byte, ByVal lDefaultMusteriKodu As Int64, ByVal bPIndirimKuponuBasilacak As Byte, ByVal bPIndirimKuponuAlinacak As Byte, ByVal bPPromosyonVar As Byte, ByVal bKPromosyonVar As Byte, ByVal sDefaultHareketTipi As String, ByVal bDovizliGirisVar As Byte, ByVal bEkSoru1 As Byte, ByVal bEkSoru2 As Byte, ByVal nParametre1 As Int64, ByVal nParametre2 As Int64, ByVal sTaxFreeFormu As String, ByVal sDiplomatikFormu As String, ByVal sHediyeCeki As String, ByVal sIndirimKuponu As String, ByVal sPSiparisFormu1 As String, ByVal sPSiparisIadeFormu1 As String, ByVal sPSiparisFormu2 As String, ByVal sPSiparisIadeFormu2 As String, ByVal sKSiparisFormu1 As String, ByVal sKSiparisIadeFormu1 As String, ByVal sKSiparisFormu2 As String, ByVal sKSiparisIadeFormu2 As String, ByVal sYedekFormu1 As String, ByVal sYedekFormu2 As String, ByVal bPartiVar As Byte, ByVal bPSonraTeslimVar As Byte, ByVal bKSonraTeslimVar As Byte, ByVal bEkSoru3 As Byte, ByVal bEkSoru4 As Byte, ByVal bEkSoru5 As Byte, ByVal bEkSoru6 As Byte, ByVal fatAcik As Byte, ByVal PesinFarkliSatir As Byte, ByVal bHizliYazdir As Byte, ByVal sHizliYazdirYol As String, ByVal bFiyatTipiZorunlumu As Byte)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbParamAlisVeris SET bSaticiRumuzuVarmi = " & bSaticiRumuzuVarmi & ", bEnvanterGosterilsinmi = " & bEnvanterGosterilsinmi & ", bEksiKontroluVarmi = " & bEksiKontroluVarmi & ", bMalBazindaOdemePlaniVarmi = " & bMalBazindaOdemePlaniVarmi & ", sSabitOdemeKodu = '" & sSabitOdemeKodu & "', bOdemePlaniDegistirilsinmi = " & bOdemePlaniDegistirilsinmi & ", bPesinatDegistirilsinmi = " & bPesinatDegistirilsinmi & ", bTaksitTutDegistirilsinmi = " & bTaksitTutDegistirilsinmi & ", bTaksitTarDegistirilsinmi = " & bTaksitTarDegistirilsinmi & ", nITMAXG = " & nITMAXG & ", nMinPesinatYuzdesi = " & nMinPesinatYuzdesi & ", sPesinatEksikligiDagilimi = '" & sPesinatEksikligiDagilimi & "', lESPF = " & lESPF & ", lPesinatYuvarlama = " & lPesinatYuvarlama & ", lTaksitYuvarlama = " & lTaksitYuvarlama & ", bSatisAnindaVadeFarkiVarmi = " & bSatisAnindaVadeFarkiVarmi & ", nSatisVadeFarkiYuzdesi = " & nSatisVadeFarkiYuzdesi & ", bVFYTaksitleCarpilsinmi = " & bVFYTaksitleCarpilsinmi & ", nGecikmeVadeFarkiYuzdesi = " & nGecikmeVadeFarkiYuzdesi & ", nGSGG = " & nGSGG & ", lGSGT = " & lGSGT & ", bVFTS = " & bVFTS & ", bVadeFarkinaKDVDahilmi = " & bVadeFarkinaKDVDahilmi & ", sVadeFarkiKdvTipi = '" & sVadeFarkiKdvTipi & "', sSatisIcinDokulecek = '" & sSatisIcinDokulecek & "', sFaturaFormu1 = '" & sFaturaFormu1 & "', sSatisFisiFormu1 = '" & sSatisFisiFormu1 & "', sSenetFormu1 = '" & sSenetFormu1 & "', sOdemeFormu1 = '" & sOdemeFormu1 & "', sPesinFormu1 = '" & sPesinFormu1 & "', sIadeFormu1 = '" & sIadeFormu1 & "', sFaturaFormu2 = '" & sFaturaFormu2 & "', sSatisFisiFormu2 = '" & sSatisFisiFormu2 & "', sSenetFormu2 = '" & sSenetFormu2 & "', sOdemeFormu2 = '" & sOdemeFormu2 & "', sPesinFormu2 = '" & sPesinFormu2 & "', sIadeFormu2 = '" & sIadeFormu2 & "', bTarihDegistirilebilsinmi = " & bTarihDegistirilebilsinmi & ", bLimitAsimiIzinlimi = " & bLimitAsimiIzinlimi & ", bGecikmeIzinlimi = " & bGecikmeIzinlimi & ", bEskilerIptalEdilsinmi = " & bEskilerIptalEdilsinmi & ", bSatistaMagazaSorulacakmi = " & bSatistaMagazaSorulacakmi & ", nAlisGun1 = " & nAlisGun1 & ", nOdemeTipi1 = " & nOdemeTipi1 & ", nOdemeGun1 = " & nOdemeGun1 & ", nAlisGun2 = " & nAlisGun2 & ", nOdemeTipi2 = " & nOdemeTipi2 & ", nOdemeGun2 = " & nOdemeGun2 & ", nAlisGun3 = " & nAlisGun3 & ", nOdemeTipi3 = " & nOdemeTipi3 & ", nOdemeGun3 = " & nOdemeGun3 & ", bMiktarDegistirilsinmi = " & bMiktarDegistirilsinmi & ", bReyonFisnoVarmi = " & bReyonFisnoVarmi & ", bEanVarmi = " & bEanVarmi & ", bTeslimatVarmi = " & bTeslimatVarmi & ", nTeslimatGunu = " & nTeslimatGunu & ", sDefaultPesinFiyatTipi = '" & sDefaultPesinFiyatTipi & "', bPFiyatTipiDegistrilsinmi = " & bPFiyatTipiDegistrilsinmi & ", bPesinMalIskontoVarmi = " & bPesinMalIskontoVarmi & ", bPesinDipIskontoVarmi = " & bPesinDipIskontoVarmi & ", bPFiyatDegistirilsinmi = " & bPFiyatDegistirilsinmi & ", sDefaultKrediFiyatTipi = '" & sDefaultKrediFiyatTipi & "', bKFiyatTipiDegistrilsinmi = " & bKFiyatTipiDegistrilsinmi & ", bKrediMalIskontoVarmi = " & bKrediMalIskontoVarmi & ", bKrediDipIskontoVarmi = " & bKrediDipIskontoVarmi & ", bKFiyatDegistirilsinmi = " & bKFiyatDegistirilsinmi & ", bRaporlarSifrelimi = " & bRaporlarSifrelimi & ", sVadeFarkiFaturaFormu1 = '" & sVadeFarkiFaturaFormu1 & "', sVadeFarkiFaturaFormu2 = '" & sVadeFarkiFaturaFormu2 & "', bAgirlikBarkoduVarmi = " & bAgirlikBarkoduVarmi & ", nMinVadeFarkiYuzdesi = " & nMinVadeFarkiYuzdesi & ",  bPFiyatSatirdaOlsun = " & bPFiyatSatirdaOlsun & ", bPHediyeCekiBasilacak = " & bPHediyeCekiBasilacak & ", bPHediyeCekiAlinacak = " & bPHediyeCekiAlinacak & ", bPOdemeTipineGoreFiyatVar = " & bPOdemeTipineGoreFiyatVar & ", bKFiyatSatirdaOlsun = " & bKFiyatSatirdaOlsun & ", bKHediyeCekiBasilacak = " & bKHediyeCekiBasilacak & ", bKHediyeCekiAlinacak = " & bKHediyeCekiAlinacak & ", bKOdemeTipineGoreFiyatVar = " & bKOdemeTipineGoreFiyatVar & ", bStokResmiVar = " & bStokResmiVar & ", bMusteriResmiVar = " & bMusteriResmiVar & ", bKrediKartNoSorsun = " & bKrediKartNoSorsun & ", bDokumdeYaziciSorsun = " & bDokumdeYaziciSorsun & ", bYalnizSonFaturaYenidenDok = " & bYalnizSonFaturaYenidenDok & ", bMusteriNotuSatisaGelsin = " & bMusteriNotuSatisaGelsin & ", lDefaultMusteriKodu = " & lDefaultMusteriKodu & ", bPIndirimKuponuBasilacak = " & bPIndirimKuponuBasilacak & ", bPIndirimKuponuAlinacak = " & bPIndirimKuponuAlinacak & ", bPPromosyonVar = " & bPPromosyonVar & ", bKPromosyonVar = " & bKPromosyonVar & ", sDefaultHareketTipi = '" & sDefaultHareketTipi & "', bDovizliGirisVar = " & bDovizliGirisVar & ", bEkSoru1 = " & bEkSoru1 & ", bEkSoru2 = " & bEkSoru2 & ", nParametre1 = " & nParametre1 & ", nParametre2 =" & nParametre2 & ", sTaxFreeFormu = '" & sTaxFreeFormu & "', sDiplomatikFormu = '" & sDiplomatikFormu & "', sHediyeCeki = '" & sHediyeCeki & "', sIndirimKuponu = '" & sIndirimKuponu & "', sPSiparisFormu1 = '" & sPSiparisFormu1 & "', sPSiparisIadeFormu1 = '" & sPSiparisIadeFormu1 & "', sPSiparisFormu2 = '" & sPSiparisFormu2 & "', sPSiparisIadeFormu2 = '" & sPSiparisIadeFormu2 & "', sKSiparisFormu1 = '" & sKSiparisFormu1 & "', sKSiparisIadeFormu1 = '" & sKSiparisIadeFormu1 & "', sKSiparisFormu2 = '" & sKSiparisFormu2 & "', sKSiparisIadeFormu2 = '" & sKSiparisIadeFormu2 & "', sYedekFormu1 = '" & sYedekFormu1 & "', sYedekFormu2 = '" & sYedekFormu2 & "', bPartiVar = " & bPartiVar & ", bPSonraTeslimVar = " & bPSonraTeslimVar & ", bKSonraTeslimVar = " & bKSonraTeslimVar & ", bEkSoru3 = " & bEkSoru3 & ", bEkSoru4 = " & bEkSoru4 & ", bEkSoru5 = " & bEkSoru5 & ", bEkSoru6 = " & bEkSoru6 & ", fatAcik = " & fatAcik & ", PesinFarkliSatir = " & PesinFarkliSatir & ", bHizliYazdir = " & bHizliYazdir & ", sHizliYazdirYol = '" & sHizliYazdirYol & "', bFiyatTipiZorunlumu = " & bFiyatTipiZorunlumu & " Where sMagazaKodu ='" & sMagazaKodu & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub kaydet()
        Dim dr As DataRow
        dr = DataSet1.Tables(0).Rows(0)
        Dim sSatisIcinDokulecek As String = "Fatura"
        If sec_sSatisIcinDokulecek.SelectedIndex = 0 Then
            sSatisIcinDokulecek = "Fatura"
        ElseIf sec_sSatisIcinDokulecek.SelectedIndex = 1 Then
            sSatisIcinDokulecek = "Senet"
        ElseIf sec_sSatisIcinDokulecek.SelectedIndex = 2 Then
            sSatisIcinDokulecek = "Fatura ve Senet"
        End If
        sSatisIcinDokulecek = sec_sSatisIcinDokulecek.Text
        dr("nOdemeTipi1") = sec_bS_Bulundugu_Ay1.SelectedIndex
        dr("nOdemeTipi2") = sec_bS_Bulundugu_Ay2.SelectedIndex
        dr("nOdemeTipi3") = sec_bS_Bulundugu_Ay3.SelectedIndex
        tbParamAlisVeris_kaydet_duzelt(dr("bSaticiRumuzuVarmi"), dr("bEnvanterGosterilsinmi"), dr("bEksiKontroluVarmi"), dr("bMalBazindaOdemePlaniVarmi"), dr("sSabitOdemeKodu"), dr("bOdemePlaniDegistirilsinmi"), dr("bPesinatDegistirilsinmi"), dr("bTaksitTutDegistirilsinmi"), dr("bTaksitTarDegistirilsinmi"), dr("nITMAXG"), dr("nMinPesinatYuzdesi"), dr("sPesinatEksikligiDagilimi"), dr("lESPF"), dr("lPesinatYuvarlama"), dr("lTaksitYuvarlama"), dr("bSatisAnindaVadeFarkiVarmi"), dr("nSatisVadeFarkiYuzdesi"), dr("bVFYTaksitleCarpilsinmi"), dr("nGecikmeVadeFarkiYuzdesi"), dr("nGSGG"), dr("lGSGT"), dr("bVFTS"), dr("bVadeFarkinaKDVDahilmi"), dr("sVadeFarkiKdvTipi"), sSatisIcinDokulecek, dr("sFaturaFormu1"), dr("sSatisFisiFormu1"), dr("sSenetFormu1"), dr("sOdemeFormu1"), dr("sPesinFormu1"), dr("sIadeFormu1"), dr("sFaturaFormu2"), dr("sSatisFisiFormu2"), dr("sSenetFormu2"), dr("sOdemeFormu2"), dr("sPesinFormu2"), dr("sIadeFormu2"), dr("bTarihDegistirilebilsinmi"), dr("bLimitAsimiIzinlimi"), dr("bGecikmeIzinlimi"), dr("bEskilerIptalEdilsinmi"), dr("bSatistaMagazaSorulacakmi"), dr("nAlisGun1"), dr("nOdemeTipi1"), dr("nOdemeGun1"), dr("nAlisGun2"), dr("nOdemeTipi2"), dr("nOdemeGun2"), dr("nAlisGun3"), dr("nOdemeTipi3"), dr("nOdemeGun3"), dr("bMiktarDegistirilsinmi"), dr("bReyonFisnoVarmi"), dr("bEanVarmi"), dr("bTeslimatVarmi"), dr("nTeslimatGunu"), dr("sDefaultPesinFiyatTipi"), dr("bPFiyatTipiDegistrilsinmi"), dr("bPesinMalIskontoVarmi"), dr("bPesinDipIskontoVarmi"), dr("bPFiyatDegistirilsinmi"), dr("sDefaultKrediFiyatTipi"), dr("bKFiyatTipiDegistrilsinmi"), dr("bKrediMalIskontoVarmi"), dr("bKrediDipIskontoVarmi"), dr("bKFiyatDegistirilsinmi"), dr("bRaporlarSifrelimi"), dr("sVadeFarkiFaturaFormu1"), dr("sVadeFarkiFaturaFormu2"), dr("bAgirlikBarkoduVarmi"), dr("nMinVadeFarkiYuzdesi"), dr("sMagazaKodu"), dr("bPFiyatSatirdaOlsun"), dr("bPHediyeCekiBasilacak"), dr("bPHediyeCekiAlinacak"), dr("bPOdemeTipineGoreFiyatVar"), dr("bKFiyatSatirdaOlsun"), dr("bKHediyeCekiBasilacak"), dr("bKHediyeCekiAlinacak"), dr("bKOdemeTipineGoreFiyatVar"), dr("bStokResmiVar"), dr("bMusteriResmiVar"), dr("bKrediKartNoSorsun"), dr("bDokumdeYaziciSorsun"), dr("bYalnizSonFaturaYenidenDok"), dr("bMusteriNotuSatisaGelsin"), dr("lDefaultMusteriKodu"), dr("bPIndirimKuponuBasilacak"), dr("bPIndirimKuponuAlinacak"), dr("bPPromosyonVar"), dr("bKPromosyonVar"), dr("sDefaultHareketTipi"), dr("bDovizliGirisVar"), dr("bEkSoru1"), dr("bEkSoru2"), dr("nParametre1"), dr("nParametre2"), dr("sTaxFreeFormu"), dr("sDiplomatikFormu"), dr("sHediyeCeki"), dr("sIndirimKuponu"), dr("sPSiparisFormu1"), dr("sPSiparisIadeFormu1"), dr("sPSiparisFormu2"), dr("sPSiparisIadeFormu2"), dr("sKSiparisFormu1"), dr("sKSiparisIadeFormu1"), dr("sKSiparisFormu2"), dr("sKSiparisIadeFormu2"), dr("sYedekFormu1"), dr("sYedekFormu2"), dr("bPartiVar"), dr("bPSonraTeslimVar"), dr("bKSonraTeslimVar"), dr("bEkSoru3"), dr("bEkSoru4"), dr("bEkSoru5"), dr("bEkSoru6"), dr("fatAcik"), dr("PesinFarkliSatir"), dr("bHizliYazdir"), dr("sHizliYazdirYol"), dr("bFiyatTipiZorunlumu"))
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        kaydet()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub txt_nAlisGun1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nAlisGun1.EditValueChanged
        If txt_nAlisGun1.EditValue > 0 And txt_nAlisGun1.EditValue < 31 Then
            txt_nIlkGun2.EditValue = txt_nAlisGun1.EditValue + 1
            txt_nAlisGun2.EditValue = 31
            txt_nAlisGun2.Enabled = True
            txt_nTaksitGun2.EditValue = 31
            txt_nTaksitGun2.Enabled = True
            'sec_bS_Bulundugu_Ay2.SelectedIndex = 0
            sec_bS_Bulundugu_Ay2.Enabled = True
        Else
            txt_nIlkGun2.EditValue = 0
            txt_nAlisGun2.EditValue = 0
            txt_nAlisGun2.Enabled = False
            txt_nTaksitGun2.EditValue = 0
            txt_nTaksitGun2.Enabled = False
            sec_bS_Bulundugu_Ay2.SelectedIndex = 0
            sec_bS_Bulundugu_Ay2.Enabled = False
        End If
    End Sub
    Private Sub txt_nAlisGun2_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nAlisGun2.EditValueChanged
        If txt_nAlisGun2.EditValue > 0 And txt_nAlisGun2.EditValue < 31 Then
            txt_nIlkGun3.EditValue = txt_nAlisGun2.EditValue + 1
            txt_nAlisGun3.EditValue = 31
            txt_nAlisGun3.Enabled = True
            txt_nTaksitGun3.EditValue = 31
            txt_nTaksitGun3.Enabled = True
            'sec_bS_Bulundugu_Ay3.SelectedIndex = 0
            sec_bS_Bulundugu_Ay3.Enabled = True
        Else
            txt_nIlkGun3.EditValue = 0
            txt_nAlisGun3.EditValue = 0
            txt_nAlisGun3.Enabled = False
            txt_nTaksitGun3.EditValue = 0
            txt_nTaksitGun3.Enabled = False
            'sec_bS_Bulundugu_Ay3.SelectedIndex = 0
            sec_bS_Bulundugu_Ay3.Enabled = False
        End If
    End Sub
    Private Sub sec_bMalBazindaOdemePlaniVar_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bMalBazindaOdemePlaniVar.CheckStateChanged
        If sec_bMalBazindaOdemePlaniVar.Checked = True Then
            sec_bFisBazindaOdemePlaniVar.Checked = False
            sec_bOdemePlaniGiristeSecilecek.Checked = True
            sec_bOdemePlaniTek.Checked = False
            sec_sSabitOdemeKodu.EditValue = ""
            Group_OdemePlani.Enabled = False
        End If
    End Sub
    Private Sub sec_bFisBazindaOdemePlaniVar_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bFisBazindaOdemePlaniVar.CheckStateChanged
        If sec_bFisBazindaOdemePlaniVar.Checked = True Then
            Group_OdemePlani.Enabled = True
            sec_bMalBazindaOdemePlaniVar.Checked = False
        End If
    End Sub
    Private Sub sec_bOdemePlaniGiristeSecilecek_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bOdemePlaniGiristeSecilecek.CheckStateChanged
        If sec_bOdemePlaniGiristeSecilecek.Checked = True Then
            sec_bOdemePlaniTek.Checked = False
            sec_sSabitOdemeKodu.EditValue = ""
        End If
    End Sub
    Private Sub sec_bSatisAnindaVadeFarkiVarmi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bSatisAnindaVadeFarkiVarmi.CheckStateChanged
        If sec_bSatisAnindaVadeFarkiVarmi.Checked = True Then
            Group_SatisAnindaVadeFarki.Enabled = True
        Else
            Group_SatisAnindaVadeFarki.Enabled = False
            txt_nSatisVadeFarkiYuzdesi.EditValue = 0
            sec_bVFYTaksitleCarpilsinmi.Checked = False
            sec_bVadeFarkinaKDVDahilmi.Checked = False
        End If
    End Sub
    Private Sub sec_bOdemePlaniTek_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bOdemePlaniTek.CheckStateChanged
        If sec_bOdemePlaniTek.Checked = True Then
            sec_bOdemePlaniGiristeSecilecek.Checked = False
        End If
    End Sub
    Private Sub ButtonEdit1_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit1.ButtonClick
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Dokumler"
        OpenFileDialog1.ShowDialog()
        ButtonEdit1.Text = System.IO.Path.GetDirectoryName(OpenFileDialog1.FileName) + "\" + System.IO.Path.GetFileName(OpenFileDialog1.FileName)
    End Sub
    Private Sub CheckEdit2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckEdit2.CheckedChanged
        ButtonEdit1.Enabled = CheckEdit2.Checked
    End Sub
End Class