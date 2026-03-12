Imports DevExpress.XtraEditors
Public Class frm_tbMuhasebeFisi_KrediKarti
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Public sFisTipi As String = "MUH"
    Public nMusteriFirmaID As Int64 = 0
    Public nMusteriHesapID As Int64 = 0
    Public sMusteriKodu As String = ""
    Public sMusteriAciklama As String = ""
    Public nBankaFirmaID As Int64 = 0
    Public nBankaHesapID As Int64 = 0
    Public sBankaKodu As String = ""
    Public sBankaAciklama As String = ""
    Public bAlacak As Boolean = False
    Public dteFisTarihi As DateTime = "01/01/1900"
    Dim lNetTutar As Decimal = 0
    Dim lKesinti As Decimal = 0
    Dim nKesintiFirmaID As Int64 = 0
    Dim nKesintiHesapID As Int64 = 0
    Dim bLoad As Boolean = False
    Dim ds_cari As DataSet
    Dim ds_OdemeSekli As DataSet
    Private Sub frm_tbMuhasebeFisi_KrediKarti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateEdit1.EditValue = dteFisTarihi
        ds_OdemeSekli = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbOdeme.sOdemeSekli, tbOdeme.sAciklama, tbFirma.nFirmaID AS nHesapID, tbFirma.nHesapID AS nKesintiHesapID FROM aEmirOdemeSekliFirma tbOdeme INNER JOIN tbFirma ON tbOdeme.KnFirmaID = tbFirma.nFirmaID WHERE (tbOdeme.nOdemeTipi = 2)")) '.Tables(0)
        sec_sOdemeSekli.Properties.DataSource = ds_OdemeSekli.Tables(0)
        sec_sOdemeSekli.Text = "KK"
        txt_bankano.Focus()
        txt_bankano.Select()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If txt_bankano.Text = "" Or nBankaHesapID = 0 Then
            XtraMessageBox.Show("Lütfen Banka/Kredi Kartı Bilgisini giriniz...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            txt_bankano.Focus()
            txt_bankano.Select()
        ElseIf txt_lTutar.EditValue = 0 Then
            XtraMessageBox.Show("Lütfen Tutar Bilgisini giriniz...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            txt_lTutar.Focus()
            txt_lTutar.Select()
        Else
            kaydet()
            Me.Close()
        End If
    End Sub
    Private Sub nKesintiHesaplari(ByVal sOdemeSekli As String)
        Dim dr As DataRow
        For Each dr In ds_OdemeSekli.Tables(0).Rows
            If Trim(dr("sOdemeSekli")) = Trim(sOdemeSekli) Then
                nKesintiFirmaID = dr("nHesapID")
                nKesintiHesapID = dr("nKesintiHesapID")
            End If
        Next
    End Sub
    Private Sub tbAVTaksitKart_Olustur(ByVal sOdemeSekli As String, ByVal lOdemeTutar As Decimal)
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        Dim ds_tbBankaOdemeSekli As DataSet = sorgu(sorgu_query("SET              DATEFIRST 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *,0 as nSatisGun FROM         tbBankaOdemeSekli Where sOdemeSekli = '" & sec_sOdemeSekli.EditValue & "'"))
        Dim dr As DataRow
        For Each dr In ds_tbBankaOdemeSekli.Tables(0).Rows
            Dim i As Integer
            Dim dteTarihi As DateTime
            Dim TaksitSayisi As Int64 = txt_nTaksitSayisi.EditValue
            Dim nTaksitID As String = ""
            Dim dteBaslangic As DateTime = dteFisTarihi
            Dim lTaksitTutari As Decimal = 0
            Dim lIadeTutari As Decimal = 0
            Dim lPuan As Decimal = 0
            Dim lPuanKdv As Decimal = 0
            Dim lServisBedeli As Decimal = 0
            Dim lKomisyonTutari As Decimal = 0
            Dim lKomisyonTutari2 As Decimal = 0
            Dim lKomisyon As Decimal = 0
            Dim lIadeTutar As Decimal = 0
            Dim bEkle As Boolean = True
            Dim nEkle As Integer = 0
            If lOdemeTutar > 0 Then
                lTaksitTutari = lOdemeTutar / TaksitSayisi
                lIadeTutar = 0
            ElseIf lOdemeTutar < 0 Then
                lIadeTutari = lOdemeTutar / TaksitSayisi
                lTaksitTutari = 0
            End If
            dteTarihi = dteBaslangic
            dr("nSatisGun") = dteFisTarihi.Day
            'Satis Gunu Protokol Kontrolu
            'Cuma
            If dr("nSatisGun") = 5 Then
                If dr("bS_Cuma_Pazar") = False And dr("bs_Cuma_Pazartesi") = False Then
                    dteTarihi = dteBaslangic
                ElseIf dr("bS_Cuma_Pazar") = True And dr("bs_Cuma_Pazartesi") = True Then
                    dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    bEkle = False
                ElseIf dr("bS_Cuma_Pazar") = True And dr("bs_Cuma_Pazartesi") = False Then
                    dteTarihi = DateAdd(DateInterval.Day, 2, dteTarihi)
                    bEkle = False
                ElseIf dr("bS_Cuma_Pazar") = False And dr("bs_Cuma_Pazartesi") = True Then
                    dteTarihi = DateAdd(DateInterval.Day, 3, dteTarihi)
                    bEkle = False
                End If
                dteBaslangic = dteTarihi
                'Cumartesi
            ElseIf dr("nSatisGun") = 6 Then
                If dr("bS_Cumartesi_Pazar") = False And dr("bS_Cumartesi_Pazartesi") = False Then
                    dteTarihi = dteBaslangic
                ElseIf dr("bS_Cumartesi_Pazar") = True And dr("bS_Cumartesi_Pazartesi") = False Then
                    dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    bEkle = False
                ElseIf dr("bS_Cumartesi_Pazar") = False And dr("bS_Cumartesi_Pazartesi") = True Then
                    dteTarihi = DateAdd(DateInterval.Day, 2, dteTarihi)
                    bEkle = False
                End If
                dteBaslangic = dteTarihi
                'Pazar
            ElseIf dr("nSatisGun") = 7 Then
                If dr("bS_Pazar_Pazartesi") = False Then
                    dteTarihi = dteBaslangic
                ElseIf dr("bS_Pazar_Pazartesi") = True Then
                    dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    bEkle = False
                End If
                dteBaslangic = dteTarihi
            End If
            dteBaslangic = dteTarihi
            'Taksit Hesapla
            For i = 1 To TaksitSayisi
                'Bonus Hesapla
                If dr("nBonusOrani") <> 0 Then
                    lPuan = (lOdemeTutar * dr("nBonusOrani")) / 100
                    If dr("nBonus_KdvOrani") <> 0 Then
                        lPuanKdv = (lPuan * dr("nBonus_KdvOrani")) / 100
                    End If
                End If
                'Komisyon Hesapla
                If dr("nKomisyonOrani") <> 0 Then
                    lKomisyonTutari = (lTaksitTutari * dr("nKomisyonOrani")) / 100
                    If dr("nKomisyon_Kdv_Orani") <> 0 Then
                        lKomisyonTutari += (lKomisyonTutari * dr("nKomisyon_Kdv_Orani")) / 100
                    End If
                End If
                lKomisyon = lKomisyonTutari
                'Ek Komisyon Hesapla
                If dr("nKomisyonOrani_2") <> 0 Then
                    If dr("nKomisyonOrani_2_Aciklama") = 0 Then
                        lKomisyonTutari2 += (lOdemeTutar * dr("nKomisyonOrani_2")) / 100
                    ElseIf dr("nKomisyonOrani_2_Aciklama") = 1 Then
                    ElseIf dr("nKomisyonOrani_2_Aciklama") = 2 Then
                        lKomisyonTutari2 += ((lOdemeTutar - lKomisyonTutari) * dr("nKomisyonOrani_2")) / 100
                    End If
                End If
                'Taksit Protokol Kontrolu
                If i > 1 Then
                    If dr("nTaksit") = 2 Then
                        If dr("bTaksit_Satis") = 0 Then
                            If dr("nTaksit" & i & "") <> 0 Then
                                dteTarihi = DateAdd(DateInterval.Day, dr("nTaksit" & i & ""), dteTarihi)
                            Else
                                dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                            End If
                        ElseIf dr("bTaksit_Satis") <> 0 Then
                            If dr("nTaksit" & i & "") <> 0 Then
                                dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                            Else
                                dteTarihi = DateAdd(DateInterval.Month, i, dr("dteOdemeTarihi"))
                            End If
                        End If
                    Else
                        dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                    End If
                    If dr("nBonus_Puan") = 0 Then
                        lPuan = 0
                        lPuanKdv = 0
                    ElseIf dr("nBonus_Puan") = 2 Then
                        lPuan = 0
                        lPuanKdv = 0
                    ElseIf dr("nBonus_Puan") = 3 Then
                        lPuan = 0
                        lPuanKdv = 0
                    End If
                    If dr("bKomisyon_IlkTaksit") = 1 Then
                        lKomisyonTutari = 0
                    End If
                    'ElseIf i = 2 Then
                    '    dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                    '    'If bEkle = True Then
                    '    '    dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    '    'End If
                ElseIf i = 1 Then
                    'İlk Taksit
                    lKomisyonTutari += lKomisyonTutari2
                    If dr("nTaksit") = 0 Then
                        Dim gun As Integer = 0
                        Dim ay As Integer = 0
                        Dim yil As Integer = 0
                        gun = dteTarihi.Day
                        ay = dteTarihi.Month
                        yil = dteTarihi.Year
                        If gun > 0 And dteTarihi.Day <= dr("nAlisGun1") Then
                            If dr("bS_Bulundugu_Ay1") = 0 Then
                                dteTarihi = dr("nTaksitGun1").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay1") = 1 Then
                                dteTarihi = dr("nTaksitGun1").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay1") = 2 Then
                                dteTarihi = dr("nTaksitGun1").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        ElseIf gun >= dr("nAlisGun1") And gun <= dr("nAlisGun2") Then
                            If dr("bS_Bulundugu_Ay2") = 0 Then
                                dteTarihi = dr("nTaksitGun2").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay2") = 1 Then
                                dteTarihi = dr("nTaksitGun2").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay2") = 2 Then
                                dteTarihi = dr("nTaksitGun2").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        ElseIf gun >= dr("nAlisGun2") And gun <= dr("nAlisGun3") Then
                            If dr("bS_Bulundugu_Ay3") = 0 Then
                                dteTarihi = dr("nTaksitGun3").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay3") = 1 Then
                                dteTarihi = dr("nTaksitGun3").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay3") = 2 Then
                                dteTarihi = dr("nTaksitGun3").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        ElseIf gun >= dr("nAlisGun3") And gun <= dr("nAlisGun4") Then
                            If dr("bS_Bulundugu_Ay4") = 0 Then
                                dteTarihi = dr("nTaksitGun4").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay4") = 1 Then
                                dteTarihi = dr("nTaksitGun4").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay4") = 2 Then
                                dteTarihi = dr("nTaksitGun4").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        ElseIf gun >= dr("nAlisGun4") And gun <= dr("nAlisGun5") Then
                            If dr("bS_Bulundugu_Ay5") = 0 Then
                                dteTarihi = dr("nTaksitGun5").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay5") = 1 Then
                                dteTarihi = dr("nTaksitGun5").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay5") = 2 Then
                                dteTarihi = dr("nTaksitGun5").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        ElseIf gun >= dr("nAlisGun5") And gun <= dr("nAlisGun6") Then
                            If dr("bS_Bulundugu_Ay6") = 0 Then
                                dteTarihi = dr("nTaksitGun6").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay6") = 1 Then
                                dteTarihi = dr("nTaksitGun6").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay6") = 2 Then
                                dteTarihi = dr("nTaksitGun6").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        End If
                    ElseIf dr("nTaksit") = 1 Then
                        dteTarihi = DateAdd(DateInterval.Day, dr("nIlkTaksitSonra"), dteBaslangic)
                    ElseIf dr("nTaksit") = 2 Then
                        If dr("bTaksit_Satis") = 0 Then
                            'dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                            dteTarihi = DateAdd(DateInterval.Day, dr("nTaksit1"), dteBaslangic)
                        ElseIf dr("bTaksit_Satis") = 1 Then
                            'MsgBox(dteBaslangic)
                            'If bEkle = True Then
                            If dr("nSatisGun") = 5 Then
                                dteTarihi = DateAdd(DateInterval.Day, 2, dr("dteOdemeTarihi"))
                                nEkle = 2
                            ElseIf dr("nSatisGun") = 6 Then
                                dteTarihi = DateAdd(DateInterval.Day, 1, dr("dteOdemeTarihi"))
                                nEkle = 1
                            ElseIf dr("nSatisGun") = 7 Then
                                dteTarihi = DateAdd(DateInterval.Day, 0, dr("dteOdemeTarihi"))
                                nEkle = 0
                            End If
                            'End If
                            dteTarihi = DateAdd(DateInterval.Day, dr("nTaksit1"), dteTarihi)
                        ElseIf dr("bTaksit_Satis") = 2 Then
                            dteTarihi = DateAdd(DateInterval.Day, dr("nTaksit1"), dr("dteOdemeTarihi"))
                        End If
                    ElseIf dr("nTaksit") = 3 Then
                        dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                        dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    End If
                End If
                'Servis Bedeli Hesapla
                If dr("nBSMV") <> 0 Then
                    If dr("bServisAlisveristen") = 0 Then
                        lServisBedeli = (lKomisyon * dr("nBSMV")) / 1000
                    ElseIf dr("bServisAlisveristen") = 1 Then
                        lServisBedeli = (lKomisyonTutari * dr("nBSMV")) / 1000
                    ElseIf dr("bServisAlisveristen") = 2 Then
                        lServisBedeli = (lTaksitTutari * dr("nBSMV")) / 100
                    End If
                End If
                'Puan Protokol Kontrolu
                If dr("nBonus_Puan") = 2 Then
                    lPuan = 0
                    lPuanKdv = 0
                ElseIf dr("nBonus_Puan") = 3 Then
                    lPuan = 0
                    lPuanKdv = 0
                End If
                'Taksit Gunu Kontrolu
                If dteTarihi.DayOfWeek = DayOfWeek.Saturday Then
                    If dr("bT_Cumartesi_Pazartesi") = True Then
                        dteTarihi = DateAdd(DateInterval.Day, 2, dteTarihi)
                        nEkle = 2
                    End If
                ElseIf dteTarihi.DayOfWeek = DayOfWeek.Sunday Then
                    If dr("bT_Pazar_Pazartesi") = True Then
                        dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                        nEkle = 1
                    End If
                End If
                'Ekle
                'tbAVTaksitKart_kaydet_ekle(dr("nOdemeID"), dr("sOdemeSekli"), dteTarihi, lTaksitTutari, lIadeTutari, lPuan, lPuanKdv, lServisBedeli, lKomisyonTutari, 0, kullanici, "01/01/1900", kullanici, Today)
                'If dr("nTaksit") <> 3 Then
                '    If nEkle > 0 Then
                '        dteTarihi = DateAdd(DateInterval.Day, -nEkle, dteTarihi)
                '        nEkle = 0
                '    End If
                'End If
                If dr("nTaksit") = 2 Then
                    If dr("bTaksit_Satis") = 1 Or dr("bTaksit_Satis") = 2 Then
                        If nEkle > 0 Then
                            dteTarihi = DateAdd(DateInterval.Day, -nEkle, dteTarihi)
                            nEkle = 0
                        End If
                    End If
                ElseIf dr("nTaksit") = 0 Then
                    If nEkle > 0 Then
                        dteTarihi = DateAdd(DateInterval.Day, -nEkle, dteTarihi)
                        nEkle = 0
                    End If
                End If
                'Taksit Protokol Kontrolu
                'If i = 1 Then
                '    If bEkle = True Then
                '        dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                '    End If
                'ElseIf i = 2 Then
                '    If bEkle = True Then
                '        dteTarihi = DateAdd(DateInterval.Day, -1, dteTarihi)
                '    End If
                'End If
            Next
            'Bonus Hesapla
            If dr("nBonusOrani") <> 0 Then
                lPuan = (lOdemeTutar * dr("nBonusOrani")) / 100
                If dr("nBonus_KdvOrani") <> 0 Then
                    lPuanKdv = (lPuan * dr("nBonus_KdvOrani")) / 100
                End If
            End If
            If dr("nBonus_Puan") = 2 Then
                'tbAVTaksitKart_kaydet_ekle(dr("nOdemeID"), dr("sOdemeSekli"), dr("dteOdemeTarihi"), 0, 0, lPuan, lPuanKdv, 0, 0, 0, kullanici, "01/01/1900", kullanici, Today)
                lbl_lPuan.Text = lPuan
                lbl_lPuanKdv.Text = lPuanKdv
            ElseIf dr("nBonus_Puan") = 3 Then
                'tbAVTaksitKart_kaydet_ekle(dr("nOdemeID"), dr("sOdemeSekli"), DateAdd(DateInterval.Day, 1, dr("dteOdemeTarihi")), 0, 0, lPuan, lPuanKdv, 0, 0, 0, kullanici, "01/01/1900", kullanici, Today)
                lbl_lPuan.Text = lPuan
                lbl_lPuanKdv.Text = lPuanKdv
            End If
            lbl_dteTarih.Text = dteTarihi
            lbl_lTaksitTutari.Text = Format(lTaksitTutari, "#,0.00")
            lbl_lIadeTutari.Text = Format(lIadeTutar, "#,0.00")
            lbl_lPuan.Text = Format(lPuan, "#,0.00")
            lbl_lPuanKdv.Text = Format(lPuanKdv, "#,0.00")
            lbl_lServisBedeli.Text = Format(lServisBedeli, "#,0.00")
            lbl_lKomisyonTutari.Text = Format(lKomisyonTutari, "#,0.00")
            lNetTutar = lOdemeTutar - (lPuan + lPuanKdv + lServisBedeli + lKomisyonTutari)
            lKesinti = txt_lTutar.EditValue - lNetTutar
            lbl_lNetTutar.Text = Format(lNetTutar, "#,0.00##")
        Next
        Label2.Text = Sorgu_sDil("Tamamlandı...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub kaydet()
        Dim ds_tbBankaOdemeSekli As DataSet = sorgu(sorgu_query("SET              DATEFIRST 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbBankaOdemeSekli Where sOdemeSekli = '" & sec_sOdemeSekli.EditValue & "'"))
        nKesintiHesaplari(sec_sOdemeSekli.EditValue)
        Dim dteBordroTarihi As DateTime = DateEdit1.EditValue
        Dim dteValorTarihi As DateTime = dteBordroTarihi
        Dim lFisNo As Int64 = sorgu_lMuhasebeFisNo()
        Dim sMuhFisTipi As Int64 = 3
        Dim nFisSiraID As Int64 = sorgu_nFisSiraID()
        Dim nCariHareketID = sorgu_nCariHareketID()
        Dim nHareketID As Int64 = nCariHareketID
        Dim nKasaIslemID As String = ""
        Dim nBordroSatirID As String = ""
        Dim lBorcTutar As Decimal = txt_lTutar.EditValue
        Dim lAlacakTutar As Decimal = 0
        Dim sDovizCinsi1 As String = ""
        Dim lDovizMiktari1 As Decimal = 0
        Dim lDovizKuru1 As Decimal = 0
        Dim sDovizCinsi2 As String = ""
        Dim lDovizMiktari2 As Decimal = 0
        Dim lDovizKuru2 As Decimal = 0
        Dim sEvrakNo As String = txt_sEvrakNo.Text
        Dim sHangiUygulama As String = sFisTipi
        Dim nBorcluFirmaID As Int64 = nMusteriFirmaID
        Dim nBorcluHesapID As Int64 = nMusteriHesapID
        Dim sBorcluHesap As String = sMusteriAciklama
        Dim sBorcluAciklama As String = txt_sAciklama.Text
        Dim nAlacakliFirmaID As Int64 = nBankaFirmaID
        Dim nAlacakliHesapID As Int64 = nBankaHesapID
        Dim sAlacakliHesap As String = sBankaAciklama
        Dim sAlacakliAciklama As String = txt_sAciklama.Text
        If sec_sDefter.Text = "Ödeme" Then
            nBorcluFirmaID = nMusteriFirmaID
            nBorcluHesapID = nMusteriHesapID
            sBorcluHesap = sMusteriAciklama
            sBorcluAciklama = txt_sAciklama.Text
            nAlacakliFirmaID = nBankaFirmaID
            nAlacakliHesapID = nBankaHesapID
            sAlacakliHesap = sBankaAciklama
            sAlacakliAciklama = txt_sAciklama.Text
        ElseIf sec_sDefter.Text = "Tahsilat" Then
            nBorcluFirmaID = nBankaFirmaID
            nBorcluHesapID = nBankaHesapID
            sBorcluHesap = sBankaAciklama
            sBorcluAciklama = txt_sAciklama.Text
            nAlacakliFirmaID = nMusteriFirmaID
            nAlacakliHesapID = nMusteriHesapID
            sAlacakliHesap = sMusteriAciklama
            sAlacakliAciklama = txt_sAciklama.Text
        End If
        Dim nVadeGun As Int64 = 0
        Dim sOdemeSekli As String = sec_sOdemeSekli.EditValue
        Try
            sorgula_nStokID("INSERT INTO tbCariIslem                       (sCariIslem, sAciklama) VALUES     ('" & sOdemeSekli & "', '')")
        Catch ex As Exception
        End Try
        'Kesinti Kontrolü
        If sec_sDefter.Text = "Tahsilat" Then
            If sec_bKesintiDus.Checked = True And nKesintiFirmaID <> 0 Then
                lBorcTutar = lNetTutar
            End If
        End If
        'Borçlu Kaydet
        nHareketID = tbFirmaHareketi_kaydet_yeni(nHareketID, nBorcluFirmaID, dteBordroTarihi, DateAdd(DateInterval.Day, nVadeGun, dteBordroTarihi), sOdemeSekli, sBorcluAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, 0, sHangiUygulama, sHareketTipi, kullaniciadi, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, kullaniciadi, Now)
        nCariHareketID = nHareketID
        nCariHareketID_degistir(nCariHareketID)
        nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dteBordroTarihi, sMuhFisTipi, lFisNo, lFisNo, nBorcluHesapID, Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Left(Trim(sAlacakliHesap), 45) & "\" & Trim(sAlacakliAciklama), 59), 0, 0, lBorcTutar, lAlacakTutar, "", 0, "CHS", sHareketTipi, nCariHareketID, kullaniciadi, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, 0, sSubeMagaza, kullaniciadi, Now)
        nFisSiraID_degistir(nFisSiraID)
        If sec_sDefter.Text = "Tahsilat" Then
            If sec_bKesintiDus.Checked = True And nKesintiFirmaID <> 0 Then
                nCariHareketID = sorgu_nCariHareketID()
                nHareketID = nCariHareketID
                nFisSiraID = sorgu_nFisSiraID()
                lBorcTutar = lKesinti
                nBorcluFirmaID = nKesintiFirmaID
                nBorcluHesapID = nKesintiHesapID
                nHareketID = tbFirmaHareketi_kaydet_yeni(nHareketID, nBorcluFirmaID, dteBordroTarihi, DateAdd(DateInterval.Day, nVadeGun, dteBordroTarihi), sOdemeSekli, sBorcluAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, 0, sHangiUygulama, sHareketTipi, kullaniciadi, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, kullaniciadi, Now)
                nCariHareketID = nHareketID
                nCariHareketID_degistir(nCariHareketID)
                nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dteBordroTarihi, sMuhFisTipi, lFisNo, lFisNo, nBorcluHesapID, Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Left(Trim(sAlacakliHesap), 45) & "\" & Trim(sAlacakliAciklama), 59), 0, 0, lBorcTutar, lAlacakTutar, "", 0, "CHS", sHareketTipi, nCariHareketID, kullaniciadi, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, 0, sSubeMagaza, kullaniciadi, Now)
                nFisSiraID_degistir(nFisSiraID)
            End If
        End If
        'Alacaklı Kaydet
        If sec_bTaksitBol.Checked = True And sec_sDefter.Text = "Ödeme" Then
            Dim i As Integer = 0
            txt_lTutar.EditValue = txt_lTutar.EditValue / txt_nTaksitSayisi.EditValue
            dteValorTarihi = DateAdd(DateInterval.Day, nVadeGun, dteBordroTarihi)
            For i = 1 To txt_nTaksitSayisi.EditValue
                dteValorTarihi = DateAdd(DateInterval.Month, 1, dteValorTarihi)
                nCariHareketID = sorgu_nCariHareketID()
                nHareketID = nCariHareketID
                nFisSiraID = sorgu_nFisSiraID()
                lBorcTutar = 0
                lAlacakTutar = txt_lTutar.EditValue
                nHareketID = tbFirmaHareketi_kaydet_yeni(nHareketID, nAlacakliFirmaID, dteBordroTarihi, dteValorTarihi, sOdemeSekli, sAlacakliAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, 0, sHangiUygulama, sHareketTipi, kullaniciadi, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, kullaniciadi, Now)
                nCariHareketID = nHareketID
                nCariHareketID_degistir(nCariHareketID)
                nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dteBordroTarihi, sMuhFisTipi, lFisNo, lFisNo, nAlacakliHesapID, Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Left(Trim(sBorcluHesap), 45) & "\" & Trim(sAlacakliAciklama), 59), 0, 0, lBorcTutar, lAlacakTutar, "", 0, "CHS", sHareketTipi, nCariHareketID, kullaniciadi, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, 0, sSubeMagaza, kullaniciadi, Now)
                nFisSiraID_degistir(nFisSiraID)
            Next
        Else
            dteValorTarihi = DateAdd(DateInterval.Day, nVadeGun, dteBordroTarihi)
            nCariHareketID = sorgu_nCariHareketID()
            nHareketID = nCariHareketID
            nFisSiraID = sorgu_nFisSiraID()
            lBorcTutar = 0
            lAlacakTutar = txt_lTutar.EditValue
            nHareketID = tbFirmaHareketi_kaydet_yeni(nHareketID, nAlacakliFirmaID, dteBordroTarihi, dteValorTarihi, sOdemeSekli, sAlacakliAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, 0, sHangiUygulama, sHareketTipi, kullaniciadi, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, kullaniciadi, Now)
            nCariHareketID = nHareketID
            nCariHareketID_degistir(nCariHareketID)
            nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dteBordroTarihi, sMuhFisTipi, lFisNo, lFisNo, nAlacakliHesapID, Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Left(Trim(sBorcluHesap), 45) & "\" & Trim(sAlacakliAciklama), 59), 0, 0, lBorcTutar, lAlacakTutar, "", 0, "CHS", sHareketTipi, nCariHareketID, kullaniciadi, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, 0, sSubeMagaza, kullaniciadi, Now)
            nFisSiraID_degistir(nFisSiraID)
        End If
        lMuhasebeFisNo_degistir()
        Try
            tbMuhasebeFisi_Aciklamasi_kaydet_yeni(dteBordroTarihi, sMuhFisTipi, lFisNo, "", "FinansEntegre", "K.Kartı ile " & sec_sDefter.Text, "", "", 0)
        Catch ex As Exception
        End Try
        analiz_fis(dteBordroTarihi, lFisNo, lFisNo, False, sMuhFisTipi, "Muhasebe")
    End Sub
    Private Sub analiz_fis(ByVal dteFisTarihi As DateTime, ByVal lFisNo As Int64, ByVal lYevmiyeNo As Int64, ByVal bMuhasabe As Boolean, ByVal sMuhFisTipi As Int64, ByVal sModul As String)
        Dim frm As New frm_tbMuhasebeFisi
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.dteFisTarihi = dteFisTarihi
        frm.lFisNo = lFisNo
        frm.lYevmiyeNo = lYevmiyeNo
        frm.bMuhasabe = bMuhasabe
        frm.sMuhFisTipi = sMuhFisTipi
        frm.kullanici = kullanici
        frm.sModul = sModul
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Function tbFirmaHareketi_kaydet_yeni(ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If Trim(sCariIslem) = "" Then
            sHangiUygulama = sFisTipi
        End If
        If Trim(sDovizCinsi2) <> "" Then
            If lDovizKuru2 = 0 Then
                lDovizKuru2 = 1
            End If
            sDovizCinsi1 = sDovizCinsi2
            lDovizKuru1 = lDovizKuru2
            lDovizMiktari1 = lDovizMiktari2
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbFirmaHareketi                       (nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nFirmaID & "', '" & dteIslemTarihi & "', '" & dteValorTarihi & "', '" & sCariIslem & "', N'" & sAciklama & "', " & lBorcTutar & ", " & lAlacakTutar & " , '" & sEvrakNo & "', " & lVadeFarki & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & " , '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & " , '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nHareketID = cmd.ExecuteScalar
        Return nHareketID
        con.Close()
    End Function
    Private Sub tbFirmaHareketi_nCariHareketID_degistir(ByVal nCariHareketID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = sConnection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = '" & nCariHareketID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function sorgu_nCariHareketID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nHareketID + 1, 0) AS nCariHareketID  FROM         tbFirmaHareketi " & kriter & " ORDER BY nHareketID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub nCariHareketID_degistir(ByVal nCariHareketID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = '" & nCariHareketID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_lMuhasebeFisNo() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonMahsupNo1, 1) AS lFisNo FROM         tbMuhasebeFisNo")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 1 Then
            kayitsayisi = 2
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_nFisSiraID() As Int64
        'Dim kriter As String = ""
        ''kriter = "WHERE (sKodu = '" & kod & "')  "
        'Dim conn As New OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim adapter As New OleDb.OleDbDataAdapter
        ''MsgBox(connection_resmi)
        'conn.ConnectionString = connection
        'cmd.Connection = conn
        'conn.Open()
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nFisSiraID + 1, 1) AS nFisSiraID FROM         tbMuhasebeFisi ORDER BY nFisSiraID DESC")
        'Dim kayitsayisi = cmd.ExecuteScalar
        'Return kayitsayisi
        Return 1
    End Function
    Private Sub nFisSiraID_degistir(ByVal nFisSiraID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMuhasebeSiraNo SET              nSonID = '" & nFisSiraID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub lMuhasebeFisNo_degistir()
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMuhasebeFisNo SET lSonMahsupNo1 = ISNULL((SELECT TOP 1 ISNULL(lFisno + 1 , 1) AS lFisNo FROM tbMuhasebeFisi WHERE (sMuhFisTipi = 3) Order by lFisNo desc),1)")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function tbMuhasebeFisi_kaydet_yeni(ByVal nFisSiraID As String, ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As Integer, ByVal lFisno As Int64, ByVal lYevmiyeNo As Int64, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal lGirenMiktar As Decimal, ByVal lCikanMiktar As Decimal, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sMasrafYontemi As String, ByVal nKasaID As Int64, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal nCariHareketID As Int64, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nSatir As Int64, ByVal sSubeMagaza As String, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMuhasebeFisi ( dteFisTarihi, sMuhFisTipi, lFisno, nEvrakNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar,sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ( '" & dteFisTarihi & "', '" & sMuhFisTipi & "', " & lFisno & ", " & lFisno & ", " & lYevmiyeNo & ", " & nHesapID & ", N'" & sAciklama & "', " & lGirenMiktar & ", " & lCikanMiktar & ", " & lBorcTutar & ", " & lAlacakTutar & ", '" & sMasrafYontemi & "', " & nKasaID & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', " & nCariHareketID & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & ", " & nSatir & ", '" & sSubeMagaza & "', '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nFisSiraID = cmd.ExecuteScalar
        Return nFisSiraID
        con.Close()
    End Function
    Private Sub tbMuhasebeFisi_Aciklamasi_kaydet_yeni(ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As String, ByVal lFisno As Int64, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal bKilitli As Byte)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbMuhasebeFisiAciklamasi (dteFisTarihi, sMuhFisTipi, lFisno, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5,bKilitli) VALUES     ('" & dteFisTarihi & "', '" & sMuhFisTipi & "', " & lFisno & ", '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "'," & bKilitli & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub musteri_sec(Optional ByVal sModul As String = "Cari")
        Dim frm1 As New frm_firma_liste
        frm1.firmano = firmano
        frm1.donemno = donemno
        frm1.connection = connection
        frm1.islemstatus = True
        frm1.kullanici = kullanici
        If sModul = "Cari" Then
            frm1.txt_ara.Text = txt_musterino.Text
        ElseIf sModul = "Banka" Then
            If sec_sDefter.Text = "Ödeme" Then
                sModul = "K.Kartı"
            End If
            frm1.txt_ara.Text = txt_bankano.Text
        End If
        frm1.sModul = sModul
        If frm1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow = frm1.GridView1.GetDataRow(frm1.GridView1.FocusedRowHandle)
            If sModul = "Cari" Then
                txt_musterino.Text = dr1("sKodu")
                sMusteriKodu = dr1("sKodu")
                nMusteriHesapID = dr1("nHesapID")
                txt_bankano.Focus()
                txt_bankano.Select()
            ElseIf sModul = "Banka" Or sModul = "K.Kartı" Then
                txt_bankano.Text = dr1("sKodu")
                sBankaKodu = dr1("sKodu")
                nBankaHesapID = dr1("nHesapID")
                sec_sOdemeSekli.Focus()
                sec_sOdemeSekli.Select()
            End If
        End If
        frm1.Close()
        frm1.Dispose()
        frm1 = Nothing
    End Sub
    Private Sub musteri_kontrol(Optional ByVal sModul As String = "Cari")
        If Trim(txt_musterino.EditValue).ToString <> "" Then
            Dim kontrol As Int64
            Dim sMusterino As String = ""
            If sModul = "Cari" Then
                sMusterino = txt_musterino.EditValue
            ElseIf sModul = "Banka" Then
                sMusterino = txt_bankano.EditValue
            End If
            kontrol = sorgu_cari_kontrol(sMusterino)
            If kontrol = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Kayıt Bulunumadı...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf kontrol = 1 Then
                dataload_cari(sMusterino)
                Dim dr As DataRow
                For Each dr In ds_cari.Tables(0).Rows
                    'txt_Musteri.EditValue = dr("MUSTERI")
                    If sModul = "Cari" Then
                        sMusteriKodu = dr("sKodu")
                        nMusteriFirmaID = dr("nFirmaID")
                        nMusteriHesapID = dr("nHesapID")
                        lbl_sMusteriAciklama.Text = dr("sAciklama")
                        sMusteriAciklama = dr("sAciklama")
                    ElseIf sModul = "Banka" Then
                        sBankaKodu = dr("sKodu")
                        nBankaFirmaID = dr("nFirmaID")
                        nBankaHesapID = dr("nHesapID")
                        lbl_sBankaAciklama.Text = dr("sAciklama")
                        sBankaAciklama = dr("sAciklama")
                    End If
                Next
                dr = Nothing
            End If
        End If
    End Sub
    Public Function sorgu_cari_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         tbFirma " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_cari(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        ds_cari = sorgu(sorgu_query("SELECT     nHesapID,nFirmaID,sKodu,sAciklama FROM         tbFirma " & kriter & ""))
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        kaydet()
    End Sub
    Private Sub txt_musterino_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musterino.ButtonClick
        musteri_sec()
    End Sub
    Private Sub txt_musterino_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_musterino.KeyDown
        If e.KeyCode = Keys.Space Then
            musteri_sec()
        ElseIf e.KeyCode = Keys.F4 Then
            musteri_sec()
        ElseIf e.KeyCode = Keys.Enter Then
            If Trim(txt_musterino.Text) = "" Then
                musteri_sec()
            End If
        End If
    End Sub
    Private Sub txt_musterino_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_musterino.Validating
        musteri_kontrol()
    End Sub
    Private Sub txt_bankano_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_bankano.ButtonClick
        musteri_sec("Banka")
    End Sub
    Private Sub txt_bankano_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_bankano.KeyDown
        If e.KeyCode = Keys.Space Then
            musteri_sec("Banka")
        ElseIf e.KeyCode = Keys.F4 Then
            musteri_sec("Banka")
        ElseIf e.KeyCode = Keys.Enter Then
            If Trim(txt_bankano.Text) = "" Then
                musteri_sec("Banka")
            End If
        End If
    End Sub
    Private Sub txt_bankano_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_bankano.Validating
        musteri_kontrol("Banka")
    End Sub
    Private Sub sec_sDefter_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sDefter.SelectedIndexChanged
        txt_sAciklama.Text = "K.Kartı ile " & sec_sDefter.Text
    End Sub
    Private Sub txt_nTaksitSayisi_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nTaksitSayisi.EditValueChanged
    End Sub
    Private Sub txt_lTutar_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_lTutar.EditValueChanged
        tbAVTaksitKart_Olustur(sec_sOdemeSekli.EditValue, txt_lTutar.EditValue)
    End Sub
    Private Sub sec_sOdemeSekli_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sOdemeSekli.EditValueChanged
        tbAVTaksitKart_Olustur(sec_sOdemeSekli.EditValue, txt_lTutar.EditValue)
    End Sub
End Class