Imports DevExpress.XtraEditors
Public Class frm_perakende_sil
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Dim sKasiyerRumuzu As String
    Dim sKasiyer As String
    Dim sMagaza As String
    Dim nMusteriID As Int64 = 0
    Dim lKodu As String = 0
    Dim sAdi As String = ""
    Dim sSoyadi As String = ""
    Dim sAdres1 As String = ""
    Dim sAdres2 As String = ""
    Dim ds_kasiyer As DataSet
    Dim ds_cari As DataSet
    Dim ds_tbOdeme As DataSet
    Dim ds_tbkredili As DataSet
    Dim ds_tbpesin As DataSet
    Private Sub frm_perakende_sil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateEdit1.EditValue = dteSistemTarihi
        DateEdit2.EditValue = dteSistemTarihi
        dataload_kasa()
        dataload_kasiyer()
        dataload_depo()
    End Sub
    Private Sub dataload_kasa()
        'If sDatabaseGenel = "NESHBA2019" Then
        '    sec_kasa.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sKasiyerRumuzu as nKasaNo,sAdi as sAciklama FROM         tbKasiyer ")).Tables(0)
        '    sec_kasa.ItemIndex = 0
        'Else

        sec_kasa.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nKasaNo,sAciklama  FROM         tbParekendeKasa ")).Tables(0)
        sec_kasa.ItemIndex = 0
        'End If
    End Sub
    Private Sub dataload_kasiyer()
        sec_kasiyer.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sKasiyerRumuzu AS IND, sAdi + ' ' + sSoyadi AS KASIYER FROM         tbKasiyer ")).Tables(0)
        sec_kasiyer.ItemIndex = 0
        ds_kasiyer = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sKasiyerRumuzu AS IND, sAdi + ' ' + sSoyadi AS KASIYER, sSifresi AS SIFRE, sDepo AS DEPO FROM         tbKasiyer WHERE     (sKasiyerRumuzu <> '') and  (bIptalYapabilirmi = 1)"))
    End Sub
    Private Sub dataload_depo()
        sec_magaza.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo, sAciklama FROM         tbDepo Where sDepo <> '' ")).Tables(0)
        sec_magaza.ItemIndex = 0
    End Sub
    
    Private Sub dataload(ByVal nMusteriID As Int64, ByVal sMagaza As String, ByVal dteTarih1 As DateTime, ByVal dteTarih2 As DateTime)
        dataload_tbOdeme(nMusteriID, sMagaza, dteTarih1, dteTarih2)
        dataload_tbKredili(nMusteriID, sMagaza, dteTarih1, dteTarih2)
        dataload_tbPesin(nMusteriID, sMagaza, dteTarih1, dteTarih2)
    End Sub
    Private Sub dataload_tbPesin(ByVal nMusteriID As Int64, ByVal sMagaza As String, ByVal dteTarih1 As DateTime, ByVal dteTarih2 As DateTime)
        If Trim(sKasiyerRumuzu) = "VC" Or Trim(sKasiyerRumuzu) = "YÖ" Or Trim(sKasiyerRumuzu) = "ALÝ" Then
            If sDatabaseGenel = "NESHBA2019" Then
                ds_tbpesin = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.nAlisverisID, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.nGirisCikis, tbAlisVeris.lFaturaNo, tbAlisVeris.sFisTipi, tbAlisVeris.sMagaza, tbDepo.sAciklama, tbAlisVeris.lToplamMiktar, tbAlisVeris.lNetTutar + tbAlisVeris.lVadeFarki AS lNetTutar, tbAlisVeris.lPesinat, ISNULL(SUM(tbOdeme.lOdemeTutar), 0) AS lOdemeTutar, ISNULL(SUM(ABS(tbIADE.lOdemeTutar)), 0) AS lIadeTutar FROM tbOdeme tbIADE RIGHT OUTER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo LEFT OUTER JOIN tbOdeme ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID AND tbOdeme.nOdemeKodu = 2 ON tbIADE.nIadeAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.nMusteriID = " & nMusteriID & ") AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & dteTarih1 & "' AND '" & dteTarih2 & "') AND (tbAlisVeris.sKasiyerRumuzu = '" & sec_kasiyer.EditValue & "') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX' OR tbAlisVeris.sFisTipi = 'KS' OR tbAlisVeris.sFisTipi = 'SP') GROUP BY tbAlisveris.sKasiyerRumuzu, tbAlisVeris.nAlisverisID, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.nGirisCikis, tbAlisVeris.lFaturaNo, tbAlisVeris.sFisTipi, tbAlisVeris.sMagaza, tbDepo.sAciklama, tbAlisVeris.lToplamMiktar, tbAlisVeris.lNetTutar + tbAlisVeris.lVadeFarki, tbAlisVeris.lPesinat ORDER BY tbAlisVeris.dteFaturaTarihi, tbAlisVeris.nGirisCikis, tbAlisVeris.lFaturaNo"))
            Else
                ds_tbpesin = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisVeris.nAlisverisID, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.nGirisCikis, tbAlisVeris.lFaturaNo, tbAlisVeris.sFisTipi, tbAlisVeris.sMagaza, tbDepo.sAciklama, tbAlisVeris.lToplamMiktar, tbAlisVeris.lNetTutar + tbAlisVeris.lVadeFarki AS lNetTutar, tbAlisVeris.lPesinat, ISNULL(SUM(tbOdeme.lOdemeTutar), 0) AS lOdemeTutar, ISNULL(SUM(ABS(tbIADE.lOdemeTutar)), 0) AS lIadeTutar FROM tbOdeme tbIADE RIGHT OUTER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo LEFT OUTER JOIN tbOdeme ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID AND tbOdeme.nOdemeKodu = 2 ON tbIADE.nIadeAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.nMusteriID = " & nMusteriID & ") AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & dteTarih1 & "' AND '" & dteTarih2 & "')  AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX' OR tbAlisVeris.sFisTipi = 'KS' OR tbAlisVeris.sFisTipi = 'SP') GROUP BY tbAlisVeris.nAlisverisID, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.nGirisCikis, tbAlisVeris.lFaturaNo, tbAlisVeris.sFisTipi, tbAlisVeris.sMagaza, tbDepo.sAciklama, tbAlisVeris.lToplamMiktar, tbAlisVeris.lNetTutar + tbAlisVeris.lVadeFarki, tbAlisVeris.lPesinat ORDER BY tbAlisVeris.dteFaturaTarihi, tbAlisVeris.nGirisCikis, tbAlisVeris.lFaturaNo"))
            End If
        Else
            ds_tbpesin = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisVeris.nAlisverisID, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.nGirisCikis, tbAlisVeris.lFaturaNo, tbAlisVeris.sFisTipi, tbAlisVeris.sMagaza, tbDepo.sAciklama, tbAlisVeris.lToplamMiktar, tbAlisVeris.lNetTutar + tbAlisVeris.lVadeFarki AS lNetTutar, tbAlisVeris.lPesinat, ISNULL(SUM(tbOdeme.lOdemeTutar), 0) AS lOdemeTutar, ISNULL(SUM(ABS(tbIADE.lOdemeTutar)), 0) AS lIadeTutar FROM tbOdeme tbIADE RIGHT OUTER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo LEFT OUTER JOIN tbOdeme ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID AND tbOdeme.nOdemeKodu = 2 ON tbIADE.nIadeAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.nMusteriID = " & nMusteriID & ") AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & dteTarih1 & "' AND '" & dteTarih2 & "') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX' OR tbAlisVeris.sFisTipi = 'KS' OR tbAlisVeris.sFisTipi = 'SP') AND (tbAlisVeris.sMagaza = '" & sMagaza & "') GROUP BY tbAlisVeris.nAlisverisID, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.nGirisCikis, tbAlisVeris.lFaturaNo, tbAlisVeris.sFisTipi, tbAlisVeris.sMagaza, tbDepo.sAciklama, tbAlisVeris.lToplamMiktar, tbAlisVeris.lNetTutar + tbAlisVeris.lVadeFarki, tbAlisVeris.lPesinat ORDER BY tbAlisVeris.dteFaturaTarihi, tbAlisVeris.nGirisCikis, tbAlisVeris.lFaturaNo"))
        End If
            GridControl3.DataSource = ds_tbpesin.Tables(0)
            GridControl3.DataMember = Nothing
    End Sub
    Private Sub dataload_tbKredili(ByVal nMusteriID As Int64, ByVal sMagaza As String, ByVal dteTarih1 As DateTime, ByVal dteTarih2 As DateTime)
        If Trim(sKasiyerRumuzu) = "VC" Or Trim(sKasiyerRumuzu) = "YÖ" Or Trim(sKasiyerRumuzu) = "ALÝ" Then
            ds_tbkredili = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisVeris.nAlisverisID, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.nGirisCikis, tbAlisVeris.lFaturaNo, tbAlisVeris.sFisTipi, tbAlisVeris.sMagaza, tbDepo.sAciklama, tbAlisVeris.lToplamMiktar, tbAlisVeris.lNetTutar + tbAlisVeris.lVadeFarki AS lNetTutar, tbAlisVeris.lPesinat, ISNULL(SUM(tbOdeme_1.lOdemeTutar), 0) AS lOdemeTutar, ISNULL(SUM(ABS(tbIADE.lOdemeTutar)), 0) AS lIadeTutar FROM tbOdeme tbIADE RIGHT OUTER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo LEFT OUTER JOIN tbOdeme tbOdeme_1 ON tbOdeme_1.nAlisverisID = tbAlisVeris.nAlisverisID AND tbOdeme_1.nOdemeKodu = 2 ON tbIADE.nIadeAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.nMusteriID = " & nMusteriID & ") AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & dteTarih1 & "' AND '" & dteTarih2 & "') AND (tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'SK') OR (tbAlisVeris.nMusteriID = " & nMusteriID & ") AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & dteTarih1 & "' AND '" & dteTarih2 & "') AND (tbAlisVeris.sFisTipi = 'KVF')  AND ((SELECT COUNT(nTaksitID) FROM TbTaksit WHERE TbTaksit.nAlisverisID = tbAlisveris.nAlisverisID) <> 0) GROUP BY tbAlisVeris.nAlisverisID, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.nGirisCikis, tbAlisVeris.lFaturaNo, tbAlisVeris.sFisTipi, tbAlisVeris.sMagaza, tbDepo.sAciklama, tbAlisVeris.lToplamMiktar, tbAlisVeris.lNetTutar + tbAlisVeris.lVadeFarki, tbAlisVeris.lPesinat ORDER BY tbAlisVeris.dteFaturaTarihi, tbAlisVeris.nGirisCikis, tbAlisVeris.lFaturaNo"))
        Else
            ds_tbkredili = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisVeris.nAlisverisID, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.nGirisCikis, tbAlisVeris.lFaturaNo, tbAlisVeris.sFisTipi, tbAlisVeris.sMagaza, tbDepo.sAciklama, tbAlisVeris.lToplamMiktar, tbAlisVeris.lNetTutar + tbAlisVeris.lVadeFarki AS lNetTutar, tbAlisVeris.lPesinat, ISNULL(SUM(tbOdeme_1.lOdemeTutar), 0) AS lOdemeTutar, ISNULL(SUM(ABS(tbIADE.lOdemeTutar)), 0) AS lIadeTutar FROM tbOdeme tbIADE RIGHT OUTER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo LEFT OUTER JOIN tbOdeme tbOdeme_1 ON tbOdeme_1.nAlisverisID = tbAlisVeris.nAlisverisID AND tbOdeme_1.nOdemeKodu = 2 ON tbIADE.nIadeAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.nMusteriID = " & nMusteriID & ") AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & dteTarih1 & "' AND '" & dteTarih2 & "') AND (tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisVeris.sMagaza = '" & sMagaza & "') OR (tbAlisVeris.nMusteriID = " & nMusteriID & ") AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & dteTarih1 & "' AND '" & dteTarih2 & "') AND (tbAlisVeris.sFisTipi = 'KVF') AND (tbAlisVeris.sMagaza = '" & sMagaza & "') AND ((SELECT COUNT(nTaksitID) FROM TbTaksit WHERE TbTaksit.nAlisverisID = tbAlisveris.nAlisverisID) <> 0) GROUP BY tbAlisVeris.nAlisverisID, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.nGirisCikis, tbAlisVeris.lFaturaNo, tbAlisVeris.sFisTipi, tbAlisVeris.sMagaza, tbDepo.sAciklama, tbAlisVeris.lToplamMiktar, tbAlisVeris.lNetTutar + tbAlisVeris.lVadeFarki, tbAlisVeris.lPesinat ORDER BY tbAlisVeris.dteFaturaTarihi, tbAlisVeris.nGirisCikis, tbAlisVeris.lFaturaNo"))
        End If
        GridControl2.DataSource = ds_tbkredili.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub dataload_tbOdeme(ByVal nMusteriID As Int64, ByVal sMagaza As String, ByVal dteTarih1 As DateTime, ByVal dteTarih2 As DateTime)
        If Trim(sKasiyerRumuzu) = "VC" Or Trim(sKasiyerRumuzu) = "YÖ" Or Trim(sKasiyerRumuzu) = "ALÝ" Then
            ds_tbOdeme = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbOdeme.dteOdemeTarihi, tbOdeme.lOdemeNo, SUM(tbOdeme.lOdemeTutar) AS lOdemeTutar FROM tbAlisVeris INNER JOIN tbOdeme ON tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID INNER JOIN tbKasiyer ON tbOdeme.sKasiyerRumuzu = tbKasiyer.sKasiyerRumuzu WHERE (tbAlisVeris.nMusteriID = " & nMusteriID & ") AND (tbOdeme.nOdemeKodu = 2) AND (tbOdeme.dteOdemeTarihi BETWEEN '" & dteTarih1 & "' AND '" & dteTarih2 & "') GROUP BY tbOdeme.dteOdemeTarihi, tbOdeme.lOdemeNo ORDER BY tbOdeme.dteOdemeTarihi"))
        Else
            ds_tbOdeme = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbOdeme.dteOdemeTarihi, tbOdeme.lOdemeNo, SUM(tbOdeme.lOdemeTutar) AS lOdemeTutar FROM tbAlisVeris INNER JOIN tbOdeme ON tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID INNER JOIN tbKasiyer ON tbOdeme.sKasiyerRumuzu = tbKasiyer.sKasiyerRumuzu WHERE (tbAlisVeris.nMusteriID = " & nMusteriID & ") AND (tbOdeme.nOdemeKodu = 2) AND (tbOdeme.dteOdemeTarihi BETWEEN '" & dteTarih1 & "' AND '" & dteTarih2 & "') AND (tbOdeme.sMagaza = '" & sMagaza & "') GROUP BY tbOdeme.dteOdemeTarihi, tbOdeme.lOdemeNo ORDER BY tbOdeme.dteOdemeTarihi"))
        End If
        GridControl1.DataSource = ds_tbOdeme.Tables(0)
        GridControl1.DataMember = Nothing
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
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
    Private Sub kasiyer_kontrol()
        Dim sonuc As Boolean = False
        Dim dr As DataRow
        For Each dr In ds_kasiyer.Tables(0).Rows
            If dr("SIFRE") = txt_kasiyer_kod.Text Then
                sKasiyerRumuzu = dr("IND")
                sKasiyer = dr("KASIYER")
                sMagaza = dr("DEPO")
                sonuc = True
            End If
        Next
        If sonuc = True Then
            lbl_kasiyer.Text = sKasiyer
            sec_magaza.EditValue = sMagaza
            txt_kasiyer_kod.Enabled = False
            GridControl1.Enabled = True
            GridControl1.Focus()
            GridControl1.Select()
            PanelControl2.Enabled = True
            'BarSubItem1.Enabled = True
            txt_musterino.Focus()
            txt_musterino.SelectAll()
        ElseIf sonuc = False Then
            lbl_kasiyer.Text = ""
            txt_kasiyer_kod.Enabled = True
            txt_kasiyer_kod.EditValue = ""
            GridControl1.Enabled = False
            PanelControl2.Enabled = False
            'BarSubItem1.Enabled = False
            If XtraMessageBox.Show(Sorgu_sDil("Þifre Hatalý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information) Then
                txt_kasiyer_kod.Focus()
                txt_kasiyer_kod.SelectAll()
            End If
        End If
        dr = Nothing
        sonuc = Nothing
    End Sub
    Private Sub musteri_sec()
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.musterino = dr_baslik("FIRMAKODU")
        frm.islemstatus = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nMusteriID = dr1("nMusteriID")
            lKodu = dr1("lKodu")
            'lbl_musteri_adi.Text = dr1("Musteri")
            txt_musterino.EditValue = lKodu
            musteri_kontrol()
        End If
    End Sub
    Private Sub musteri_kontrol()
        If Trim(txt_musterino.EditValue).ToString <> "" Then
            Dim kontrol = sorgu_cari_kontrol(txt_musterino.EditValue)
            If kontrol = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf kontrol = 1 Then
                dataload_cari(txt_musterino.EditValue)
                Dim dr As DataRow
                For Each dr In ds_cari.Tables(0).Rows
                    'txt_Musteri.EditValue = dr("MUSTERI")
                    lKodu = dr("MUSTERIKODU")
                    nMusteriID = dr("IND")
                    lbl_musteri_adi.Text = dr("MUSTERI")
                    sAdi = dr("sAdi")
                    sSoyadi = dr("sSoyadi")
                    sAdres1 = dr("sAdres1")
                    sAdres2 = dr("sAdres2")
                    ara()
                Next
                dr = Nothing
            End If
        End If
    End Sub
    Public Function sorgu_cari_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         tbMusteri " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_cari(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "') "
        ds_cari = sorgu(sorgu_query("SELECT     nMusteriID AS IND, lKodu AS MUSTERIKODU,sAdi,sSoyadi, sAdi + ' ' + sSoyadi AS MUSTERI,sEvAdresi1 as sAdres1, sEvAdresi2 as sAdres2 FROM         tbMusteri " & kriter & ""))
    End Sub
    Private Sub tbAlisVeris_sil(ByVal nAlisVerisID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("set implicit_transactions off")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbAVPromosyonIndirim where nAlisverisID = '" & nAlisVerisID & "' ")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT count (a.nTaksitID) from tbTaksit a , tbOdeme b where a.nTaksitID=b.nTaksitID and a.nAlisverisID = '" & nAlisVerisID & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("set implicit_transactions on")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAlisverisSlip set bIptalmi = 0  where nAlisverisID =  ( Select top 1 nIadeAlisverisID from tbOdeme where nIadeAlisverisID <> ''    and nAlisverisID = '" & nAlisVerisID & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbAVKartTaksit where nOdemeID in ( select nOdemeID from tbOdeme where nAlisverisID =  '" & nAlisVerisID & "' )")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbOdeme where nAlisverisID = '" & nAlisVerisID & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbTaksit where nAlisverisID = '" & nAlisVerisID & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMusteriPara set lPara = lPara - isnull(( select sum(lTutar) from tbAVHediyeCeki where nAlisverisID = '" & nAlisVerisID & "' and sHediyeCekiTipi = 'ParaPU_KAZ'), 0)  + isnull(( select sum(lTutar) from tbAVHediyeCeki where nAlisverisID = '" & nAlisVerisID & "' and sHediyeCekiTipi = 'ParaPU_HAR'), 0)  where nMusteriID in (select nMusteriID from tbAlisveris where nAlisverisID = '" & nAlisVerisID & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAVIndirimKuponu set bKapandimi = 0 where sAlinanBasilan = 'B' and sKuponSeriNo in (select sKuponSeriNo from tbAVIndirimKuponu where sAlinanBasilan = 'A'  and nAlisverisID = '" & nAlisVerisID & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbAVIndirimKuponu where nAlisverisID = '" & nAlisVerisID & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokFisiDetayi where nAlisverisID = '" & nAlisVerisID & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbAlisverisSiparis where nAlisverisID = '" & nAlisVerisID & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbAVHediyeCeki where nAlisverisID = '" & nAlisVerisID & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbAlisverisSlip where nAlisverisID = '" & nAlisVerisID & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbAlisVeris where nAlisverisID = '" & nAlisVerisID & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Hatasý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        con.Close()
    End Sub
    Private Sub tbOdeme_sil(ByVal dteOdemeTarihi As DateTime, ByVal sMagaza As String, ByVal nMusteriID As Int64, ByVal lMakbuzNo As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("set implicit_transactions on")
            cmd.ExecuteNonQuery()
            cmd.CommandText = "DELETE from tbAVKartTaksit WHERE (nOdemeID IN (SELECT tbOdeme.nOdemeID FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi = '" & dteOdemeTarihi & "') AND (tbOdeme.lMakbuzNo = " & lMakbuzNo & ") AND (tbAlisVeris.nMusteriID = " & nMusteriID & "))) "
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisVeris.nAlisverisID into #temp1 From tbAlisVeris, tbOdeme  Where tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID and not exists ( Select nAlisverisID from tbTaksit where nAlisverisID = tbAlisveris.nAlisverisID ) and sFisTipi = 'KVF'and dteOdemetarihi = '" & dteOdemeTarihi & "' and lOdemeno = " & lMakbuzNo & " and nMusteriID = " & nMusteriID & " and tbOdeme.sMagaza = '" & sMagaza & "' delete tbOdeme from tbAlisveris where tbAlisveris.nAlisverisID = tbOdeme.nAlisverisID and nOdemeKodu = 2 and lOdemeNo = " & lMakbuzNo & " and dteOdemeTarihi = '" & dteOdemeTarihi & "' and nMusteriID = " & nMusteriID & " and tbOdeme.sMagaza = '" & sMagaza & "' delete tbAlisveris from #temp1 where tbAlisveris.nAlisverisID = #temp1.nAlisverisID drop table #temp1")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Hatasý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        con.Close()
    End Sub
    Private Sub stok_satis_detay_kredi()
        Dim frm As New frm_stok_cari_satis
        Dim dr As DataRow
        dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
        frm.status = True
        frm.firmano = 100
        frm.donemno = 1
        frm.connection = connection
        frm.islemstatus = True
        frm.stokno = dr("nAlisVerisID")
        frm.fistipi = Trim(dr("sFisTipi").ToString)
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        dr = Nothing
    End Sub
    Private Sub stok_satis_detay_pesin()
        Dim frm As New frm_stok_cari_satis
        Dim dr As DataRow
        dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
        frm.status = True
        frm.firmano = 100
        frm.donemno = 1
        frm.connection = connection
        frm.islemstatus = True
        frm.stokno = dr("nAlisVerisID")
        frm.fistipi = Trim(dr("sFisTipi").ToString)
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        dr = Nothing
    End Sub
    Private Sub ara()
        dataload(nMusteriID, sec_magaza.EditValue, DateEdit1.EditValue, DateEdit2.EditValue)
    End Sub
    Private Sub txt_musterino_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musterino.ButtonClick
        musteri_sec()
    End Sub
    Private Sub txt_musterino_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_musterino.KeyDown
        If e.KeyCode = Keys.Enter Then
            musteri_kontrol()
            txt_musterino.Focus()
            txt_musterino.SelectAll()
        ElseIf e.KeyCode = Keys.F6 Then
            musteri_sec()
        ElseIf e.KeyCode = Keys.F3 Then
            musteri_sec()
        End If
    End Sub
    Private Sub txt_kasiyer_kod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_kasiyer_kod.KeyDown
        If e.KeyCode = Keys.Enter Then
            kasiyer_kontrol()
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        ara()
    End Sub
    Private Sub ÝnceleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÝnceleToolStripMenuItem.Click
        stok_satis_detay_kredi()
    End Sub
    Private Sub SilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SilToolStripMenuItem.Click
        'If GridView2.RowCount > 0 Then
        '    If XtraMessageBox.Show(Sorgu_sDil("Seçili Ýþlemi Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
        '        Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
        '        If dr("lOdemeTutar") = 0 Then
        '            Dim satir = GridView2.FocusedRowHandle
        '            tbAlisVeris_sil(dr("nAlisVerisID"))
        '            ara()
        '            GridView2.FocusedRowHandle = satir
        '            satir = Nothing
        '        Else
        '            XtraMessageBox.Show(Sorgu_sDil("Ödeme Alýnmýþ Belgeyi Silemezsiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        End If
        '        dr = Nothing
        '    End If
        'End If
        kredi_sil()
    End Sub
    Private Sub kredi_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Peþin Satýþlarý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            arr = GridView2.GetSelectedRows()
            bar1.Properties.Maximum = GridView2.SelectedRowsCount
            bar1.Position = 0
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = GridView2.GetDataRow(s)
                    If dr("lOdemeTutar") = 0 Then
                        tbAlisVeris_sil(dr("nAlisVerisID"))
                    Else
                        XtraMessageBox.Show(Sorgu_sDil("Ödeme Alýnmýþ Belgeyi Silemezsiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    bar1.Position += 1
                    bar1.Refresh()
                Next
            End If
            ara()
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Tamamlandý...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            s = Nothing
            arr = Nothing
            i = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        stok_satis_detay_pesin()
    End Sub
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        'If GridView3.RowCount > 0 Then
        '    If XtraMessageBox.Show(Sorgu_sDil("Seçili Ýþlemi Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
        '        Dim dr As DataRow = GridView3.GetDataRow(GridView3.FocusedRowHandle)
        '        If dr("lOdemeTutar") = 0 Then
        '            Dim satir = GridView3.FocusedRowHandle
        '            tbAlisVeris_sil(dr("nAlisVerisID"))
        '            ara()
        '            GridView3.FocusedRowHandle = satir
        '            satir = Nothing
        '        Else
        '            XtraMessageBox.Show(Sorgu_sDil("Ödeme Alýnmýþ Belgeyi Silemezsiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        End If
        '        dr = Nothing
        '    End If
        'End If
        Pesin_sil()
    End Sub
    Private Sub Pesin_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Peþin Satýþlarý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            arr = GridView3.GetSelectedRows()
            bar1.Properties.Maximum = GridView3.SelectedRowsCount
            bar1.Position = 0
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = GridView3.GetDataRow(s)
                    If dr("lOdemeTutar") = 0 Then
                        tbAlisVeris_sil(dr("nAlisVerisID"))
                    Else
                        XtraMessageBox.Show(Sorgu_sDil("Ödeme Alýnmýþ Belgeyi Silemezsiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    bar1.Position += 1
                    bar.Refresh()
                Next
            End If
            ara()
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Tamamlandý...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            s = Nothing
            arr = Nothing
            i = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Ýþlemi Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                Dim satir = GridView1.FocusedRowHandle
                tbOdeme_sil(dr("dteOdemeTarihi"), sec_magaza.EditValue, nMusteriID, dr("lOdemeNo"))
                ara()
                GridView1.FocusedRowHandle = satir
                satir = Nothing
                dr = Nothing
            End If
        End If
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView2_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView2.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView3_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView3.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
End Class