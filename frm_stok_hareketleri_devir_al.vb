Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_stok_hareketleri_devir_al
    Dim query As String = ""
    Dim DS As DataSet
    Dim dr As DataRow
    Dim sayi As Integer = 0
    Dim i As Integer = 0
    Dim lFisNo As Integer = 0
    Dim nStokFisiID As String = ""
    Dim sorguC As SorguClass = New SorguClass
    Private Sub frm_fis_depo_kodu_degistir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PanelControl2.BringToFront()
        PanelControl2.Visible = False
        fisTipi.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sFisTipi, sAciklama FROM tbFisTipi where sFisTipi IN ('DC', 'DG', 'FA', 'FS', 'IA', 'IS', 'T')")).Tables(0)
        fisTarih1.EditValue = Today
        fisTarih2.EditValue = Today
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        sayi = Integer.Parse(sorguC.sorgu("set dateformat dmy select Count(*) from tbStokFisiMaster where (dteFisTarihi between '" & fisTarih1.Text & "' AND '" & fisTarih2.Text & "') AND (sFisTipi = '" & Trim(fisTipi.EditValue) & "')"))
        If sayi > 0 Then
            PanelControl2.Visible = True
            lFisNo = sorguC.sorgu("select (Max(lFisNo) + 1) as lFisNo from tbStokFisiMaster")
            query = "set dateformat DMY insert into tbStokFisiMaster (nGirisCikis, nFirmaID, sDepo, lKdv1, lKdv2, lKdv3, lKdv4, "
            query += "lKdv5, lNetTutar, lTevkifatKdv, lTransferFisiID, sTransferDepo, sYaziIle, "
            query += "sFisTipi, dteFisTarihi, lFisNo, dteValorTarihi, sKullaniciAdi, "
            If Trim(fisTipi.EditValue) = "FA" Or Trim(fisTipi.EditValue) = "DG" Or Trim(fisTipi.EditValue) = "IA" Then
                query += "dteKayitTarihi) values ('1', '0', 'D001', 0, 0, 0, 0, 0, 0, 0, 0, '', '', "
            ElseIf Trim(fisTipi.EditValue) = "FS" Or Trim(fisTipi.EditValue) = "DC" Or Trim(fisTipi.EditValue) = "IS" Or Trim(fisTipi.EditValue) = "T" Then
                query += "dteKayitTarihi) values ('3', '0', 'D001', 0, 0, 0, 0, 0, 0, 0, 0, '', '', "
            End If
            query += "'D" & Trim(fisTipi.EditValue) & "', '" & sorguC.guncelTarih("tarih") & "', '" & lFisNo & "', "
            query += "'" & sorguC.guncelTarih("tarih") & "', '" & Trim(kullaniciadi) & "', '" & sorguC.guncelTarih("tarih") & "')"
            If sorguC.hata = False Then
                sorguC.sorgu_tam(query)
            End If
            nStokFisiID = sorguC.sorgu("select top 1 nStokFisiID from tbStokFisiMaster where lFisNo = '" & lFisNo & "'")
            query = "set dateformat DMY insert into tbStokFisiDetayi (nStokID, nFirmaID, nMusteriID, sFisTipi, sDepo, nGirisCikis, "
            query += "lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, "
            query += "lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, "
            query += "lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, "
            query += "sDovizCinsi, lDovizFiyat, nKdvOrani, sAciklama, sHareketTipi, sDovizCinsi1, lDovizMiktari1, "
            query += "lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, sBirimCinsi, lBirimMiktar, "
            query += "nPrim, lPrimTutari, dteIslemTarihi, dteFisTarihi, lFisNo, dteIrsaliyeTarihi, dteKayitTarihi, "
            query += "dteSonUpdateTarihi, sKullaniciAdi, sStokIslem, nStokFisiID) "
            query += "select nStokID, nFirmaID, nMusteriID, 'D" & Trim(fisTipi.EditValue) & "' as sFisTipi, sDepo, "
            query += "nGirisCikis, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, "
            query += "lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, "
            query += "lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, "
            query += "lDovizFiyat, nKdvOrani, sAciklama, sHareketTipi, sDovizCinsi1, lDovizMiktari1, "
            query += "lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, "
            query += "sBirimCinsi, lBirimMiktar, nPrim, lPrimTutari, '" & sorguC.guncelTarih("tarih") & "' as dteIslemTarihi, "
            query += "'" & sorguC.guncelTarih("tarih") & "' as dteFisTarihi, '" & lFisNo & "' as lFisNo, "
            query += "'" & sorguC.guncelTarih("tarih") & "' as dteIrsaliyeTarihi, '" & sorguC.guncelTarih("tarih") & "' as dteKayitTarihi, "
            query += "'" & sorguC.guncelTarih("tarih") & "' as dteSonUpdateTarihi, '" & Trim(kullaniciadi) & "' as sKullaniciAdi, "
            query += "'D', '" & nStokFisiID & "' from tbStokFisiDetayi where (lFisNo IN (select "
            query += "lFisNo from tbStokFisiMaster where (dteFisTarihi between '" & fisTarih1.Text & "' AND "
            query += "'" & fisTarih2.Text & "') AND (sFisTipi = '" & Trim(fisTipi.EditValue) & "'))) AND "
            query += "(dteFisTarihi between '" & fisTarih1.Text & "' AND '" & fisTarih2.Text & "') AND "
            query += "(sFisTipi = '" & Trim(fisTipi.EditValue) & "')"
            If sorguC.hata = False Then
                sorguC.sorgu_tam(query)
            End If
            query = "update tbStokFisiMaster set lToplamMiktar = "
            query += "(select ISNULL(CASE WHEN sum(lGirisMiktar1) > 0 THEN sum(lGirisMiktar1) "
            query += "ELSE sum(lCikisMiktar1) END, 0) as lToplamMiktar from tbStokFisiDetayi where "
            query += "(lFisNo = '" & lFisNo & "') AND (sFisTipi = 'D" & Trim(fisTipi.EditValue) & "')), "
            query += "lMalBedeli = (select ISNULL(sum(lBrutTutar), 0) as lBrutTutar from tbStokFisiDetayi "
            query += "where (lFisNo = '" & lFisNo & "') AND (sFisTipi = 'D" & Trim(fisTipi.EditValue) & "')), "
            query += "lMalIskontoTutari = (select ISNULL(sum(lIskontoTutari), 0) as lIskontoTutari from "
            query += "tbStokFisiDetayi where (lFisNo = '" & lFisNo & "') "
            query += "AND (sFisTipi = 'D" & Trim(fisTipi.EditValue) & "')), lNetTutar = "
            query += "(select ISNULL(sum(lMaliyetTutar), 0) as lMaliyetTutar from tbStokFisiDetayi where "
            query += "(lFisNo = '" & lFisNo & "') "
            query += "AND (sFisTipi = 'D" & Trim(fisTipi.EditValue) & "')) where lFisNo = '" & lFisNo & "'"
            If sorguC.hata = False Then
                sorguC.sorgu_tam(query)
            End If
            query = "update tbStokFisiMaster set sYaziIle = "
            query += "'" & ygeneltoplam(Math.Abs(Decimal.Parse(sorguC.sorgu("select lNetTutar from tbStokFisiMaster where lFisNo = '" & lFisNo & "'")))) & "' "
            query += "where lFisNo = '" & lFisNo & "'"
            If sorguC.hata = False Then
                sorguC.sorgu_tam(query)
            End If
            query = "insert into tbStokFisiAciklamasi values('" & sorguC.sorgu("select nStokFisiID from tbStokFisiMaster where lFisNo = '" & lFisNo & "'") & "', "
            query += "'Devir', '', '', '', '')"
            If sorguC.hata = False Then
                sorguC.sorgu_tam(query)
            End If
            query = "delete from tbStokFisiMaster where (sFisTipi = '" & Trim(fisTipi.EditValue) & "') AND "
            query += "(dteFisTarihi between '" & fisTarih1.Text & "' and '" & fisTarih2.Text & "')"
            If sorguC.hata = False Then
                sorguC.sorgu_tam(query)
            End If
            query = "delete from tbStokFisiDetayi where (sFisTipi = '" & Trim(fisTipi.EditValue) & "') AND "
            query += "(dteFisTarihi between '" & fisTarih1.Text & "' and '" & fisTarih2.Text & "')"
            If sorguC.hata = False Then
                sorguC.sorgu_tam(query)
            End If
            PanelControl2.Visible = False
            If sorguC.hata = False Then
                sorguC.sorgu_Destek("Stok Hareketleri Devir Ýþlemi", "" & fisTarih1.Text & "-" & fisTarih2.Text & " Tarih aralýðýnda, " & Trim(fisTipi.EditValue) & " Fiþ tipindeki kayýtlar, " & nStokFisiID & " numaralý nStokFisiID, " & lFisNo & " numaralý lFisNo ve " & sorguC.guncelTarih("tarih") & " fiþ tarihi verileri ile kayýt edildi.", "SimpleButton1_Click()", "frm_stok_hareketleri_devir_al.vb")
                MessageBox.Show("Devir Ýþlemi Baþarýlý.", "Business Smart")
            Else
                sorguC.hata = False
                sorguC.sorgu_Destek("Stok Hareketleri Devir Ýþlemi", "" & fisTarih1.Text & "-" & fisTarih2.Text & " Tarih aralýðýnda, " & Trim(fisTipi.EditValue) & " Fiþ tipindeki kayýtlar, " & nStokFisiID & " numaralý nStokFisiID, " & lFisNo & " numaralý lFisNo ve " & sorguC.guncelTarih("tarih") & " fiþ tarihi verileri ile kayýt edilemedi. Bir sorun var!", "SimpleButton1_Click()", "frm_stok_hareketleri_devir_al.vb")
                MessageBox.Show("Devir Ýþlemi Baþarýsýz.", "Business Smart")
            End If
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub fisTipi_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles fisTipi.EditValueChanged
        fisTipiAciklama.Text = fisTipi.Properties.GetDataSourceValue("sAciklama", fisTipi.ItemIndex)
    End Sub
End Class