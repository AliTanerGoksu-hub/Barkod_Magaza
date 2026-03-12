Imports Microsoft.Win32
Public Class frm_stok_kart_fiyat_default
    Public firmano
    Public donemno
    Public connection
    Public nStokID
    Public sKodu
    Public sModel
    Public kullanici
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_stok As DataSet
    Dim ds_nStokID As DataSet
    Dim ds_tbFiyatlandirma As DataSet
    Dim ds_tbFiyatTipi As DataSet
    Dim ds_tbSatici As DataSet
    Dim ds_tbDepo As DataSet
    Dim ds_tbsube As DataSet
    Public islem_status As Boolean = False
    Private Sub frm_stok_kart_fiyat_default_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload_tbFiyatTipi()
        'Normal
        Try
            sec_sFiyatTipi1.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("sFiyatTipi1").ToString
        Catch ex As Exception
            sec_sFiyatTipi1.EditValue = ""
        End Try
        Try
            sec_sFiyatTipi2.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("sFiyatTipi2").ToString
        Catch ex As Exception
            sec_sFiyatTipi2.EditValue = ""
        End Try
        Try
            sec_sFiyatTipi3.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("sFiyatTipi3").ToString
        Catch ex As Exception
            sec_sFiyatTipi3.EditValue = ""
        End Try
        Try
            sec_sFiyatTipi4.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("sFiyatTipi4").ToString
        Catch ex As Exception
            sec_sFiyatTipi4.EditValue = ""
        End Try
        Try
            sec_sFiyatTipi5.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("sFiyatTipi5").ToString
        Catch ex As Exception
            sec_sFiyatTipi5.EditValue = ""
        End Try
        Try
            sec_sFiyatTipi6.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("sFiyatTipi6").ToString
        Catch ex As Exception
            sec_sFiyatTipi6.EditValue = ""
        End Try
        Try
            sec_sFiyatTipi7.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("sFiyatTipi7").ToString
        Catch ex As Exception
            sec_sFiyatTipi7.EditValue = ""
        End Try
        'Eskiler
        Try
            sec_sEFiyatTipi1.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("EsFiyatTipi1").ToString
        Catch ex As Exception
            sec_sEFiyatTipi1.EditValue = ""
        End Try
        Try
            sec_sEFiyatTipi2.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("EsFiyatTipi2").ToString
        Catch ex As Exception
            sec_sEFiyatTipi2.EditValue = ""
        End Try
        Try
            sec_sEFiyatTipi3.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("EsFiyatTipi3").ToString
        Catch ex As Exception
            sec_sEFiyatTipi3.EditValue = ""
        End Try
        Try
            sec_sEFiyatTipi4.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("EsFiyatTipi4").ToString
        Catch ex As Exception
            sec_sEFiyatTipi4.EditValue = ""
        End Try
        Try
            sec_sEFiyatTipi5.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("EsFiyatTipi5").ToString
        Catch ex As Exception
            sec_sEFiyatTipi5.EditValue = ""
        End Try
        Try
            sec_sEFiyatTipi6.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("EsFiyatTipi6").ToString
        Catch ex As Exception
            sec_sEFiyatTipi6.EditValue = ""
        End Try
        Try
            sec_sEFiyatTipi7.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("EsFiyatTipi7").ToString
        Catch ex As Exception
            sec_sEFiyatTipi7.EditValue = ""
        End Try
        Try
            sec_bVadeDagilim.Checked = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("PERAKENDE").GetValue("bCalcVadeDagilim").ToString
        Catch ex As Exception
            sec_bVadeDagilim.Checked = False
        End Try
        Try
            sec_bOtomatikTaksit.Checked = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("PERAKENDE").GetValue("bOtomatikTaksit").ToString
        Catch ex As Exception
            sec_bOtomatikTaksit.Checked = False
        End Try
        Try
            sec_bOtomatikPesinatDuzelt.Checked = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("PERAKENDE").GetValue("bOtomatikPesinatDuzelt").ToString
        Catch ex As Exception
            sec_bOtomatikPesinatDuzelt.Checked = False
        End Try
        Try
            sec_bKdvKontrolluMaliyet.Checked = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("FIS").GetValue("bKdvKontrolluMaliyet").ToString
        Catch ex As Exception
            sec_bKdvKontrolluMaliyet.Checked = False
        End Try
        Try
            sec_bSatirKontrol.Checked = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("FIS").GetValue("bSatirKontrol").ToString
        Catch ex As Exception
            sec_bSatirKontrol.Checked = False
        End Try
        Try
            sec_bOtomatikMaliyetFiyati.Checked = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("FIS").GetValue("bOtomatikMaliyetFiyati").ToString
        Catch ex As Exception
            sec_bOtomatikMaliyetFiyati.Checked = False
        End Try
        Try
            sec_bOtomatikAlisFiyati.Checked = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("FIS").GetValue("bOtomatikAlisFiyati").ToString
        Catch ex As Exception
            sec_bOtomatikAlisFiyati.Checked = False
        End Try
        Try
            sec_bAlisFiyatiUyar.Checked = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("FIS").GetValue("bAlisFiyatiUyar").ToString
        Catch ex As Exception
            sec_bAlisFiyatiUyar.Checked = False
        End Try
        Try
            sec_dteSonFaturaTarihi.EditValue = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("FIS").GetValue("dteSonFaturaTarihi").ToString
        Catch ex As Exception
            sec_dteSonFaturaTarihi.EditValue = "01/01/1900"
        End Try
        Try
            sec_dteSonIrsaliyeTarihi.EditValue = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("FIS").GetValue("dteSonIrsaliyeTarihi").ToString
        Catch ex As Exception
            sec_dteSonIrsaliyeTarihi.EditValue = "01/01/1900"
        End Try
        Try
            sec_dteSonStokFisiTarihi.EditValue = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("FIS").GetValue("dteSonStokFisiTarihi").ToString
        Catch ex As Exception
            sec_dteSonStokFisiTarihi.EditValue = "01/01/1900"
        End Try
        Try
            sec_dteSonNakitKasaTarihi.EditValue = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("FIS").GetValue("dteSonNakitKasaTarihi").ToString
        Catch ex As Exception
            sec_dteSonNakitKasaTarihi.EditValue = "01/01/1900"
        End Try
        Try
            sec_nFirmaGrupKodUzunlugu.EditValue = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("FIS").GetValue("nFirmaGrupKodUzunlugu").ToString
        Catch ex As Exception
            sec_nFirmaGrupKodUzunlugu.EditValue = 0
        End Try
        Try
            txt_nTaksitGun.EditValue = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("PERAKENDE").GetValue("nTaksitGun").ToString
        Catch ex As Exception
            txt_nTaksitGun.EditValue = 0
        End Try
        Try
            txt_nTaksitBaslangic.EditValue = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("PERAKENDE").GetValue("nTaksitBaslangic").ToString
        Catch ex As Exception
            txt_nTaksitBaslangic.EditValue = 0
        End Try
        Try
            txt_nTaksitSayi.EditValue = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("PERAKENDE").GetValue("nTaksitSayi").ToString
        Catch ex As Exception
            txt_nTaksitSayi.EditValue = 0
        End Try
        Try
            sec_sKrediliFiyatTipi.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("sKrediliFiyatTipi").ToString
        Catch ex As Exception
            sec_sKrediliFiyatTipi.EditValue = ""
        End Try
        Try
            sec_bMessageCheck.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("bMessageCheck").ToString
        Catch ex As Exception
            sec_bMessageCheck.Checked = False
        End Try
        Try
            sec_bNamazVaktiGosterme.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("bNamazVaktiGosterme").ToString
        Catch ex As Exception
            sec_bNamazVaktiGosterme.Checked = False
        End Try
        Try
            sec_bOtomatikYedek.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("bOtomatikYedek").ToString
        Catch ex As Exception
            sec_bOtomatikYedek.Checked = False
        End Try
        Try
            sec_aktifDepoCari.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("bAktifDepoCari").ToString
        Catch ex As Exception
            sec_aktifDepoCari.Checked = True
        End Try
        Try
            sec_bOtomatikYedekRar.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("bOtomatikYedekRar").ToString
        Catch ex As Exception
            sec_bOtomatikYedekRar.Checked = False
        End Try
        Try
            sec_sYedekPath.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("sYedekPath").ToString
        Catch ex As Exception
            sec_sYedekPath.Text = "D"
        End Try
        Try
            sec_sPesinFiyatTipi.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("sPesinFiyatTipi").ToString
        Catch ex As Exception
            sec_sPesinFiyatTipi.EditValue = ""
        End Try
        Try
            sec_sSaticiRumuzu.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("sSaticiRumuzu").ToString
        Catch ex As Exception
            sec_sSaticiRumuzu.EditValue = ""
        End Try
        Try
            sec_sDepo.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("DEPOKODU").ToString
        Catch ex As Exception
            sec_sDepo.EditValue = ""
        End Try
        Try
            sec_TeslimatAktifDepo.EditValue = sAktifTeslimatDepo
        Catch ex As Exception
            sec_TeslimatAktifDepo.EditValue = ""
        End Try
        Try
            sec_sSubeMagaza.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("sSubeMagaza").ToString
        Catch ex As Exception
            sec_sSubeMagaza.EditValue = "001"
        End Try
        Try
            txt_printer_termal.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("PrinterTermal").ToString
        Catch ex As Exception
            txt_printer_termal.EditValue = ""
        End Try
        Try
            txt_printer_depo.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("PrinterDepo").ToString
        Catch ex As Exception
            txt_printer_depo.EditValue = ""
        End Try
        Try
            sec_nFontSize.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MAGAZA").OpenSubKey("Global").GetValue("FontSize").ToString
        Catch ex As Exception
            sec_nFontSize.EditValue = 8.25
        End Try
        Try
            sec_bFiyatKdvHaric.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MAGAZA").OpenSubKey("Global").GetValue("bFiyatKdvHaric").ToString
        Catch ex As Exception
            sec_bFiyatKdvHaric.Checked = False
        End Try
        Try
            sec_bFaturaKdvDahil.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MAGAZA").OpenSubKey("Global").GetValue("bFaturaKdvDahil").ToString
        Catch ex As Exception
            sec_bFaturaKdvDahil.Checked = False
        End Try
        Try
            sec_bFaturaKdvSiz.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MAGAZA").OpenSubKey("Global").GetValue("bFaturaKdvSiz").ToString
        Catch ex As Exception
            sec_bFaturaKdvSiz.Checked = False
        End Try
        Try
            sec_bFaturaIskontosuz.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MAGAZA").OpenSubKey("Global").GetValue("bFaturaIskontosuz").ToString
        Catch ex As Exception
            sec_bFaturaIskontosuz.Checked = False
        End Try
        Try
            txt_nFaturaCiktiSatirSayisi.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MAGAZA").OpenSubKey("Global").GetValue("nFaturaCiktiSatirSayisi").ToString
        Catch ex As Exception
            txt_nFaturaCiktiSatirSayisi.EditValue = 25
        End Try
        Try
            sec_bIrsaliyeKdvSiz.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MAGAZA").OpenSubKey("Global").GetValue("bIrsaliyeKdvSiz").ToString
        Catch ex As Exception
            sec_bIrsaliyeKdvSiz.Checked = False
        End Try
        Try
            sec_bIrsaliyeIskontosuz.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MAGAZA").OpenSubKey("Global").GetValue("bIrsaliyeIskontosuz").ToString
        Catch ex As Exception
            sec_bIrsaliyeIskontosuz.Checked = False
        End Try
        Try
            txt_nIrsaliyeCiktiSatirSayisi.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MAGAZA").OpenSubKey("Global").GetValue("nIrsaliyeCiktiSatirSayisi").ToString
        Catch ex As Exception
            txt_nIrsaliyeCiktiSatirSayisi.EditValue = 25
        End Try
        Try
            sec_bStokFisiKdvSiz.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MAGAZA").OpenSubKey("Global").GetValue("bStokFisiKdvSiz").ToString
        Catch ex As Exception
            sec_bStokFisiKdvSiz.Checked = False
        End Try
        Try
            sec_bStokFisiIskontosuz.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MAGAZA").OpenSubKey("Global").GetValue("bStokFisiIskontosuz").ToString
        Catch ex As Exception
            sec_bStokFisiIskontosuz.Checked = False
        End Try
        Try
            txt_nStokFisiCiktiSatirSayisi.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MAGAZA").OpenSubKey("Global").GetValue("nStokFisiCiktiSatirSayisi").ToString
        Catch ex As Exception
            txt_nStokFisiCiktiSatirSayisi.EditValue = 25
        End Try
        Try
            sec_bTransferEnvanterKontrol.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MAGAZA").OpenSubKey("Global").GetValue("bTransferEnvanterKontrol").ToString
        Catch ex As Exception
            sec_bTransferEnvanterKontrol.Checked = False
        End Try
        Try
            sec_bTransferTeslimatYok.Checked = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MAGAZA").OpenSubKey("Global").GetValue("bTransferTeslimatYok").ToString
        Catch ex As Exception
            sec_bTransferTeslimatYok.Checked = False
        End Try
        Try
            sec_sRaporUzanti.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MAGAZA").OpenSubKey("Global").GetValue("sRaporUzanti").ToString
        Catch ex As Exception
            sec_sRaporUzanti.Text = ".frx"
        End Try
        Try
            sec_sYaziIle.Text = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MAGAZA").OpenSubKey("Global").GetValue("sYaziIle").ToString
        Catch ex As Exception
            sec_sYaziIle.Text = "TR"
        End Try
        Try
            txt_sGramajFlag.Text = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").GetValue("BARCODESTD")
        Catch ex As Exception
            txt_sGramajFlag.Text = "27"
            Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").SetValue("BARCODESTD", txt_sGramajFlag.Text)
        End Try
        Try
            txt_sGramajKg.Text = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").GetValue("BARCODESTD_KG")
        Catch ex As Exception
            txt_sGramajKg.Text = "2"
            Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").SetValue("BARCODESTD_KG", txt_sGramajKg.Text)
        End Try
        Try
            txt_sGramajGr.Text = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").GetValue("BARCODESTD_GR")
        Catch ex As Exception
            txt_sGramajGr.Text = "3"
            Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").SetValue("BARCODESTD_GR", txt_sGramajGr.Text)
        End Try
        Try
            sec_MobileFaaliyet.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("OtoFaaliyet").GetValue("durum").ToString()
        Catch ex As Exception
            sec_MobileFaaliyet.Checked = False
        End Try
        Try
            sec_MobileFatura.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("OtoFatura").GetValue("durum").ToString()
        Catch ex As Exception
            sec_MobileFatura.Checked = False
        End Try
        Try
            sec_eticaret.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("Eticaret").GetValue("durum").ToString()
        Catch ex As Exception
            sec_eticaret.Checked = False
        End Try
    End Sub
    Private Sub dataload_tbFiyatTipi()
        ds_tbFiyatTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFiyatTipi,sAciklama FROM         tbFiyatTipi where (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%')"))
        ds_tbSatici = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu,sAdi FROM         tbSatici where bAktif =1"))
        ds_tbDepo = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo,sAciklama FROM         tbDepo "))
        sec_sDepo.Properties.DataSource = ds_tbDepo.Tables(0)
        sec_TeslimatAktifDepo.Properties.DataSource = ds_tbDepo.Tables(0)
        ds_tbsube = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSubeMagaza,sAciklama FROM         tbSubeMagaza"))
        sec_sSubeMagaza.Properties.DataSource = ds_tbsube.Tables(0)
        sec_sFiyatTipi1.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sFiyatTipi2.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sFiyatTipi3.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sFiyatTipi4.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sFiyatTipi5.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sFiyatTipi6.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sFiyatTipi7.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sEFiyatTipi1.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sEFiyatTipi2.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sEFiyatTipi3.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sEFiyatTipi4.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sEFiyatTipi5.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sEFiyatTipi6.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sEFiyatTipi7.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sKrediliFiyatTipi.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sPesinFiyatTipi.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sSaticiRumuzu.Properties.DataSource = ds_tbSatici.Tables(0)
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
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("sFiyatTipi1", sec_sFiyatTipi1.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("sFiyatTipi2", sec_sFiyatTipi2.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("sFiyatTipi3", sec_sFiyatTipi3.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("sFiyatTipi4", sec_sFiyatTipi4.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("sFiyatTipi5", sec_sFiyatTipi5.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("sFiyatTipi6", sec_sFiyatTipi6.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("sFiyatTipi7", sec_sFiyatTipi7.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("EsFiyatTipi1", sec_sEFiyatTipi1.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("EsFiyatTipi2", sec_sEFiyatTipi2.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("EsFiyatTipi3", sec_sEFiyatTipi3.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("EsFiyatTipi4", sec_sEFiyatTipi4.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("EsFiyatTipi5", sec_sEFiyatTipi5.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("EsFiyatTipi6", sec_sEFiyatTipi6.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("EsFiyatTipi7", sec_sEFiyatTipi7.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("PrinterTermal", txt_printer_termal.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("PrinterDepo", txt_printer_depo.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("sKrediliFiyatTipi", sec_sKrediliFiyatTipi.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("sPesinFiyatTipi", sec_sPesinFiyatTipi.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("sSaticiRumuzu", sec_sSaticiRumuzu.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("MAGAZA").CreateSubKey("Global").SetValue("FontSize", sec_nFontSize.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("MAGAZA").CreateSubKey("Global").SetValue("bFiyatKdvHaric", sec_bFiyatKdvHaric.Checked)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("MAGAZA").CreateSubKey("Global").SetValue("bFaturaKdvDahil", sec_bFaturaKdvDahil.Checked)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("MAGAZA").CreateSubKey("Global").SetValue("bFaturaKdvSiz", sec_bFaturaKdvSiz.Checked)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("MAGAZA").CreateSubKey("Global").SetValue("bFaturaIskontosuz", sec_bFaturaIskontosuz.Checked)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("MAGAZA").CreateSubKey("Global").SetValue("nFaturaCiktiSatirSayisi", txt_nFaturaCiktiSatirSayisi.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("MAGAZA").CreateSubKey("Global").SetValue("bIrsaliyeKdvSiz", sec_bIrsaliyeKdvSiz.Checked)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("MAGAZA").CreateSubKey("Global").SetValue("bIrsaliyeIskontosuz", sec_bIrsaliyeIskontosuz.Checked)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("MAGAZA").CreateSubKey("Global").SetValue("nIrsaliyeCiktiSatirSayisi", txt_nIrsaliyeCiktiSatirSayisi.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("MAGAZA").CreateSubKey("Global").SetValue("bStokFisiKdvSiz", sec_bStokFisiKdvSiz.Checked)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("MAGAZA").CreateSubKey("Global").SetValue("bStokFisiIskontosuz", sec_bStokFisiIskontosuz.Checked)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("MAGAZA").CreateSubKey("Global").SetValue("nStokFisiCiktiSatirSayisi", txt_nStokFisiCiktiSatirSayisi.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("MAGAZA").CreateSubKey("Global").SetValue("bTransferEnvanterKontrol", sec_bTransferEnvanterKontrol.Checked)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("MAGAZA").CreateSubKey("Global").SetValue("sRaporUzanti", sec_sRaporUzanti.Text)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("MAGAZA").CreateSubKey("Global").SetValue("sYaziIle", sec_sYaziIle.Text)
        Try
            If yetki_kontrol(kullanici, "sAktifTeslimatDepo_Degis") = True Then
                Dim con As New OleDb.OleDbConnection
                Dim cmd As New OleDb.OleDbCommand
                Dim adapter As New OleDb.OleDbDataAdapter
                con.ConnectionString = connection
                cmd.CommandTimeout = Nothing
                adapter.SelectCommand = cmd
                cmd.CommandText = "Update tbParamStok Set sAktifTeslimatDepo = '" & sec_TeslimatAktifDepo.EditValue & "'"
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End If
        Catch ex As Exception
        End Try
        'Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("DEPOKODU", sec_sDepo.EditValue)
        'Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("sSubeMagaza", sec_sSubeMagaza.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("bMessageCheck", sec_bMessageCheck.Checked)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("bNamazVaktiGosterme", sec_bNamazVaktiGosterme.Checked)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("bOtomatikYedek", sec_bOtomatikYedek.Checked)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("bAktifDepoCari", sec_aktifDepoCari.Checked)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("bOtomatikYedekRar", sec_bOtomatikYedekRar.Checked)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("sYedekPath", sec_sYedekPath.Text)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("PERAKENDE").SetValue("bCalcVadeDagilim", sec_bVadeDagilim.Checked)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("PERAKENDE").SetValue("bOtomatikTaksit", sec_bOtomatikTaksit.Checked)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("PERAKENDE").SetValue("bOtomatikPesinatDuzelt", sec_bOtomatikPesinatDuzelt.Checked)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("FIS").SetValue("bKdvKontrolluMaliyet", sec_bKdvKontrolluMaliyet.Checked)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("FIS").SetValue("bSatirKontrol", sec_bSatirKontrol.Checked)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("FIS").SetValue("bOtomatikMaliyetFiyati", sec_bOtomatikMaliyetFiyati.Checked)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("FIS").SetValue("bOtomatikAlisFiyati", sec_bOtomatikAlisFiyati.Checked)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("FIS").SetValue("bAlisFiyatiUyar", sec_bAlisFiyatiUyar.Checked)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("FIS").SetValue("dteSonFaturaTarihi", sec_dteSonFaturaTarihi.EditValue)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("FIS").SetValue("dteSonIrsaliyeTarihi", sec_dteSonIrsaliyeTarihi.EditValue)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("FIS").SetValue("dteSonStokFisiTarihi", sec_dteSonStokFisiTarihi.EditValue)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("FIS").SetValue("dteSonNakitKasaTarihi", sec_dteSonNakitKasaTarihi.EditValue)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("FIS").SetValue("nFirmaGrupKodUzunlugu", sec_nFirmaGrupKodUzunlugu.EditValue)
        dteSonFaturaTarihi = sec_dteSonFaturaTarihi.EditValue
        dteSonIrsaliyeTarihi = sec_dteSonIrsaliyeTarihi.EditValue
        dteSonStokFisiTarihi = sec_dteSonStokFisiTarihi.EditValue
        dteSonNakitKasaTarihi = sec_dteSonNakitKasaTarihi.EditValue
        nFirmaGrupKodUzunlugu = sec_nFirmaGrupKodUzunlugu.EditValue
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("PERAKENDE").SetValue("nTaksitGun", txt_nTaksitGun.EditValue)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("PERAKENDE").SetValue("nTaksitBaslangic", txt_nTaksitBaslangic.EditValue)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("PERAKENDE").SetValue("nTaksitSayi", txt_nTaksitSayi.EditValue)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").SetValue("BARCODESTD", txt_sGramajFlag.Text)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").SetValue("BARCODESTD_KG", txt_sGramajKg.Text)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").SetValue("BARCODESTD_GR", txt_sGramajGr.Text)
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("MAGAZA").CreateSubKey("Global").SetValue("bTransferTeslimatYok", sec_bTransferTeslimatYok.Checked)
        sRaporUzanti = sec_sRaporUzanti.Text
        otoFaaliyetCalistir = sec_MobileFaaliyet.Checked
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("OtoFaaliyet").SetValue("durum", sec_MobileFatura.Checked)
        otoFaaliyetCalistir = sec_MobileFatura.Checked
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("OtoFatura").SetValue("durum", sec_MobileFatura.Checked)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("Eticaret").SetValue("durum", sec_eticaret.Checked)

        Me.Close()
    End Sub
    Private Sub sec_bOtomatikTaksit_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bOtomatikTaksit.CheckedChanged
        If sec_bOtomatikTaksit.Checked = True Then
            txt_nTaksitGun.Enabled = True
        Else
            txt_nTaksitGun.Enabled = False
        End If
    End Sub

    Private Sub sec_MobileFaaliyet_CheckedChanged(sender As Object, e As EventArgs) Handles sec_MobileFaaliyet.CheckedChanged

    End Sub

    Private Sub PanelControl3_Paint(sender As Object, e As PaintEventArgs) Handles PanelControl3.Paint

    End Sub
    Private Sub sec_eticaret_CheckedChanged(sender As Object, e As EventArgs) Handles sec_eticaret.CheckedChanged

    End Sub


End Class