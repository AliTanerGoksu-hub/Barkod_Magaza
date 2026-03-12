Imports DevExpress.XtraEditors
Public Class frm_tbMuhasebe_Entegre_Perakende
    Public firmano As String
    Public donemno As String
    Public connection As String
    Public kullanici As String
    Dim ds_tbFisTipi As DataSet
    Dim ds_tbHareketTipi As DataSet
    Dim dataset1 As DataSet
    Dim ds1 As DataSet
    Dim ds_Faaliyet As New DataSet
    Dim ds_SatisKarlilik As DataSet
    Dim ds_SubeMagaza As DataSet
    Dim ds_OdemeSekli As DataSet
    Dim bInfo As Boolean = False
    Public bPesin As Boolean = False
    Private Sub frm_tbMuhasebe_Entegre_Perakende_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If bPesin = True Then
            Me.Text = "Peşin Muhasebe Entegrasyonu"
            lbl_istihbarat.Text = "Peşin Entegrasyonu Parametreleri Aşağıdadır..."
        Else
            Me.Text = "Perakende Muhasebe Entegrasyonu"
            lbl_istihbarat.Text = "Perakende Entegrasyonu Parametreleri Aşağıdadır..."
        End If
        dataload_depo()
        dataload_tbHareketTipi()
        txt_dteFisTarihi1.EditValue = dteSistemTarihi
        txt_dteFisTarihi2.EditValue = dteSistemTarihi
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += "EvrakTipi = " & Trim(sec_fistipi.Text) & vbTab & " Islem = MuhasebeEntegre"
        kriter += txt_dteFisTarihi1.EditValue & " ve " & txt_dteFisTarihi2.EditValue & " Tarihleri Arasındaki" & vbCrLf
        kriter += "FisNo: " & txt_lFisNo1.Text & " ve " & txt_lFisNo2.Text & " Arasindaki " & "FirmaKodu = " & txt_lKodu1.Text & " ve " & txt_lKodu2.Text
        printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Muhasebe Yönetimi-Account Manager", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Excel Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyaları(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_text()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Text Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Text Dosyaları(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_pdf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Metin Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyaları(*.pdf) |*.pdf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Başlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "İçerir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
        ElseIf kriter = "Boş" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklı" Then
            sorgu_kriter = " <> '" & deger & "' "
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = " >  '" & deger & "' "
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = " < '" & deger & "' "
        ElseIf kriter = "Eşittir" Then
            sorgu_kriter = " = '" & deger & "' "
        End If
        Return sorgu_kriter
    End Function
    Private Function sorgu(ByVal query As String, Optional ByVal sTable As String = "TABLE1") As DataSet
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
        Dim N As Integer = adapter.Fill(DS, sTable)
        con.Close()
        Return DS
    End Function
    Private Sub dataload_depo()
        ds_magaza = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, sDepo AS KOD, sAciklama AS ACIKLAMA FROM         tbDepo WHERE sDepo <> '' ORDER BY sDepo"))
        ds_kasiyer = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, sKasiyerRumuzu AS KOD, sAdi + ' ' + sSoyadi AS ACIKLAMA FROM         tbKasiyer WHERE     (sKasiyerRumuzu <> '') ORDER BY sAdi"))
        ds_kasa = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, nKasaNo AS KOD, sAciklama AS ACIKLAMA FROM         tbParekendeKasa"))
        ds_harekettipi = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, sHareketTipi AS KOD, sAciklama AS ACIKLAMA FROM         tbHareketTipi WHERE     (sHareketTipi <> '') and (aktif = 1)"))
        If bPesin = False Then
            ds_fistipi = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, sFisTipi AS KOD, sAciklama AS ACIKLAMA FROM         tbFisTipi WHERE     (bSatismi = 1) AND (nGCT =4 )"))
        ElseIf bPesin = True Then
            ds_fistipi = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, sFisTipi AS KOD, sAciklama AS ACIKLAMA FROM         tbFisTipi WHERE     (bSatismi = 1) AND (nGCT = 3)"))
        End If
        ds_SubeMagaza = sorgu(sorgu_query("SELECT     sSubeMagaza, sAciklama  FROM         tbSubeMagaza"))
        If Trim(sDepo) = "D001" Or Trim(sDepo) = "D012" Or Trim(sDepo) = "D013" Then
            If kullanici > 3 Then
                sec_depo.Properties.ReadOnly = False
            Else
                sec_depo.Properties.ReadOnly = False
            End If
        Else
            If kullanici > 3 Then
                sec_depo.EditValue = "'" & sDepo & "'"
                sec_depo.Properties.ReadOnly = True
            Else
                sec_depo.Properties.ReadOnly = False
            End If
        End If
    End Sub
    Private Sub dataload_tbHareketTipi()
        ds_tbHareketTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST(sHareketTipi AS CHAR(4)) AS sHareketTipi, sAciklama FROM         tbHareketTipi where aktif = 1"))
        sec_sHareketTipi.Properties.DataSource = ds_tbHareketTipi.Tables(0)
        sec_sHareketTipi.ItemIndex = 0
    End Sub
    Private Sub ara(ByVal sFisTipi As String, ByVal dteFisTarihi1 As DateTime, ByVal dteFisTarihi2 As DateTime, ByVal lFisNo1 As Int64, ByVal lFisNo2 As Int64, ByVal sFirmaKodu1 As String, ByVal sFirmaKodu2 As String, ByVal bIade As Integer, ByVal bYenile As Boolean, ByVal nFirmaUzunluk As Integer)
        bInfo = False
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        sFisTipi = Trim(sFisTipi)
        dataload(sFisTipi, dteFisTarihi1, dteFisTarihi2, lFisNo1, lFisNo2, sFirmaKodu1, sFirmaKodu2, bIade, bYenile, nFirmaUzunluk)
        Label2.Text = Sorgu_sDil("Tamamlandı...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
        bInfo = True
    End Sub
    Private Sub dataload(ByVal sFisTipi As String, ByVal dteFisTarihi1 As DateTime, ByVal dteFisTarihi2 As DateTime, ByVal lFisNo1 As Int64, ByVal lFisNo2 As Int64, ByVal sFirmaKodu1 As String, ByVal sFirmaKodu2 As String, ByVal bIade As Integer, ByVal bYenile As Boolean, ByVal nFirmaUzunluk As Integer)
        'Dim kriter As String = ""
        'kriter = "WHERE tbStokFisiMaster.sFistipi = '" & sFisTipi & "' AND tbStokFisiMaster.lNetTutar <> 0  AND tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID AND tbStokFisiMaster.bFisTamamlandiMi = 1"
        'Dim nNormal As Integer = 1
        'Dim nNormalHesapTipi As Integer = 6
        'Dim nNormalKdvTipi As Integer = 40
        'Dim nNormalTevkifatTipi As Integer = 46
        'Dim nNormalEkMaliyet1 As Integer = 10
        'Dim nNormalEkMaliyet2 As Integer = 11
        'Dim nNormalEkMaliyet3 As Integer = 12
        'Dim nNormalIskonto As Integer = 8
        'Dim nIadeIskonto As Integer = 9
        'Dim nIade As Integer = 2
        'Dim nIadaHesapTipi As Integer = 7
        'Dim nIadeKdvTipi As Integer = 41
        'If sFisTipi = "FS" Or sFisTipi = "DC" Or sFisTipi = "HS" Or sFisTipi = "MM" Then
        '    nNormal = 3
        '    nNormalHesapTipi = 13
        '    nNormalKdvTipi = 42
        '    nNormalTevkifatTipi = 48
        '    nNormalIskonto = 15
        '    nIade = 4
        '    nIadaHesapTipi = 14
        '    nIadeKdvTipi = 43
        '    nIadeIskonto = 16
        'ElseIf sFisTipi = "FA" Or sFisTipi = "DG" Or sFisTipi = "HA" Then
        '    nNormal = 1
        '    nNormalHesapTipi = 6
        '    nNormalKdvTipi = 40
        '    nNormalTevkifatTipi = 46
        '    nNormalIskonto = 8
        '    nIade = 2
        '    nIadaHesapTipi = 7
        '    nIadeKdvTipi = 41
        '    nIadeIskonto = 9
        'End If
        'If bIade = 0 Then
        '    kriter += " AND tbStokFisiMaster.nGirisCikis = " & nNormal & ""
        'ElseIf bIade = 1 Then
        '    kriter += " AND tbStokFisiMaster.nGirisCikis = " & nIade & ""
        'End If
        'If bYenile = False Then
        '    kriter += " and tbStokFisiMaster.bMuhasebeyeIslendimi = 0"
        'Else
        'End If
        'kriter += " AND tbStokFisiMaster.lFisNo BETWEEN " & lFisNo1 & " AND " & lFisNo2 & ""
        'kriter += " AND tbStokFisiMaster.dteFisTarihi BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "'"
        'If Trim(sFirmaKodu1) = "" And Trim(txt_sFirmaKodu2.Text) = "" Then
        'Else
        '    kriter += " and tbFirma.sKodu between '" & sFirmaKodu1 & "' and '" & sFirmaKodu2 & "' "
        'End If
        'dataset1 = sorgu(sorgu_query("SET dateformat dmy SELECT DISTINCT Sube, FisTipi, GirisCikis, Kod, Oran, Tip FROM (SELECT DISTINCT tbDepo.sSube AS Sube, tbAlisveris.sFisTipi AS FisTipi, tbAlisveris.nGirisCikis AS GirisCikis, '' AS Kod, 0 AS Oran, 0 AS Tip FROM tbAlisVeris, tbDepo, tbSubeMagaza WHERE tbAlisVeris.sMagaza = tbDepo.sDepo AND tbSubeMagaza.sSubeMagaza = tbDepo.sSube AND (tbAlisVeris.lMalBedeli <> 0 OR tbAlisveris.lVadeFarki <> 0) AND tbAlisVeris.dteFaturaTarihi BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "' AND (tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'KS' OR tbAlisVeris.sFisTipi = 'KVF' OR tbAlisVeris.sFisTipi = 'PAD') AND ((tbAlisveris.sFisTipi = 'PAD' AND tbAlisveris.nGirisCikis = 3 AND NOT EXISTS (SELECT nHesapID FROM tbSubeMagazaHesaplari WHERE tbDepo.sSube = sSubeMagaza AND nSubeMagazaHesapTipi = 23 AND sHareketTipi = '')) OR (tbAlisveris.sFisTipi = 'PAD' AND tbAlisveris.nGirisCikis = 4 AND NOT EXISTS (SELECT nHesapID FROM tbSubeMagazaHesaplari WHERE tbDepo.sSube = sSubeMagaza AND nSubeMagazaHesapTipi = 24 AND sHareketTipi = '')) OR ((tbAlisveris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'KS') AND NOT EXISTS (SELECT nHesapID FROM tbSubeMagazaHesaplari WHERE tbDepo.sSube = sSubeMagaza AND nSubeMagazaHesapTipi = 35 AND sHareketTipi = ''))) AND tbAlisVeris.bMuhasebeyeIslendimi = 0 UNION ALL SELECT DISTINCT tbDepo.sSube AS Sube, tbAlisveris.sFisTipi AS FisTipi, tbAlisveris.nGirisCikis AS GirisCikis, '' AS Kod, 0 AS Oran, 1 AS Tip FROM tbAlisVeris, tbDepo, tbSubeMagaza WHERE tbAlisVeris.sMagaza = tbDepo.sDepo AND tbSubeMagaza.sSubeMagaza = tbDepo.sSube AND tbSubeMagaza.bHerMagazadaAyriSatHesVar = 0 AND tbAlisVeris.lMalBedeli <> 0 AND tbAlisVeris.dteFaturaTarihi BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "' AND (tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'KS') AND ((tbAlisveris.nGirisCikis = 3 AND NOT EXISTS (SELECT nHesapID FROM tbSubeMagazaHesaplari WHERE tbDepo.sSube = sSubeMagaza AND nSubeMagazaHesapTipi = 23 AND sHareketTipi = '')) OR (tbAlisveris.nGirisCikis = 4 AND NOT EXISTS (SELECT nHesapID FROM tbSubeMagazaHesaplari WHERE tbDepo.sSube = sSubeMagaza AND nSubeMagazaHesapTipi = 24 AND sHareketTipi = ''))) AND tbAlisVeris.bMuhasebeyeIslendimi = 0 UNION ALL SELECT DISTINCT tbDepo.sSube AS Sube, tbStokFisiDetayi.sFisTipi AS FisTipi, tbStokFisiDetayi.nGirisCikis AS GirisCikis, tbStok.sKodu AS Kod, 0 AS Oran, 2 AS Tip FROM tbStokFisiDetayi, tbDepo, tbSubeMagaza, tbStok WHERE tbStokFisiDetayi.sDepo = tbDepo.sDepo AND tbStok.nStokID = tbStokFisiDetayi.nStokID AND tbSubeMagaza.sSubeMagaza = tbDepo.sSube AND tbSubeMagaza.bHerMagazadaAyriSatHesVar = 1 AND tbStokFisiDetayi.lCikisTutar <> 0 AND tbStokFisiDetayi.dteFisTarihi BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "' AND (tbStokFisiDetayi.sFisTipi = 'K' OR tbStokFisiDetayi.sFisTipi = 'KS') AND ((tbStokFisiDetayi.nGirisCikis = 3 AND NOT EXISTS (SELECT nHesapID FROM tbStokMuhasebeEntegrasyon WHERE tbDepo.sSube = sSubeMagaza AND nSubeMagazaHesapTipi = 23 AND sHareketTipi = '' AND tbStokFisiDetayi.nStokID = tbStokMuhasebeEntegrasyon.nStokID)) OR (tbStokFisiDetayi.nGirisCikis = 4 AND NOT EXISTS (SELECT nHesapID FROM tbStokMuhasebeEntegrasyon WHERE tbDepo.sSube = sSubeMagaza AND nSubeMagazaHesapTipi = 24 AND sHareketTipi = '' AND tbStokFisiDetayi.nStokID = tbStokMuhasebeEntegrasyon.nStokID))) AND tbStokFisiDetayi.bMuhasebeyeIslendimi = 0 UNION ALL SELECT DISTINCT tbDepo.sSube AS Sube, tbStokFisiDetayi.sFisTipi AS FisTipi, tbStokFisiDetayi.nGirisCikis AS GirisCikis, '' AS Kod, tbStokFisiDetayi.nKDVOrani AS Oran, 3 AS Tip FROM tbStokFisiDetayi, tbSubeMagaza, tbDepo WHERE tbStokFisiDetayi.sDepo = tbDepo.sDepo AND tbSubeMagaza.sSubeMagaza = tbDepo.sSube AND tbStokFisiDetayi.nKDVOrani <> 0 AND (tbStokFisiDetayi.sFisTipi = 'K' OR tbStokFisiDetayi.sFisTipi = 'KS') AND tbStokFisiDetayi.dteFisTarihi BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "' AND ((tbStokFisiDetayi.nGirisCikis = 3 AND NOT EXISTS (SELECT nHesapID FROM tbSubeMagazaKDV, tbKDv WHERE tbStokFisiDetayi.nKDVOrani = tbKDV.nKdvOrani AND tbDepo.sSube = sSubeMagaza AND nSubeMagazaHesapTipi = 42 AND sHareketTipi = '' AND tbSubeMagazaKDV.sKDVTipi = tbKDV.sKDVTipi)) OR (tbStokFisiDetayi.nGirisCikis = 4 AND NOT EXISTS (SELECT nHesapID FROM tbSubeMagazaKDV, tbKDv WHERE tbStokFisiDetayi.nKDVOrani = tbKDV.nKdvOrani AND tbDepo.sSube = sSubeMagaza AND nSubeMagazaHesapTipi = 43 AND sHareketTipi = '' AND tbSubeMagazaKDV.sKDVTipi = tbKDV.sKDVTipi))) AND tbStokFisiDetayi.bMuhasebeyeIslendimi = 0 UNION ALL SELECT DISTINCT tbDepo.sSube AS Sube, tbAlisveris.sFisTipi AS FisTipi, tbAlisveris.nGirisCikis AS GirisCikis, tbOdeme.sOdemeSekli AS Kod, 0 AS Oran, 6 AS Tip FROM tbOdeme, tbAlisVeris, tbDepo WHERE tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID AND (tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'KS' OR tbAlisVeris.sFisTipi = 'SK' OR tbAlisveris.sFisTipi = 'KVF' OR tbAlisveris.sFisTipi = 'PAD') AND tbOdeme.sMagaza = tbDepo.sDepo AND NOT EXISTS (SELECT tbSubeOdemeSekli.nSatisID FROM tbSubeOdemeSekli WHERE tbSubeOdemeSekli.sSube = tbDepo.sSube AND tbSubeOdemeSekli.sOdemeSekli = tbOdeme.sOdemeSekli) AND tbOdeme.dteOdemeTarihi BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "' AND tbOdeme.bMuhasebeyeIslendimi = 0 UNION ALL SELECT DISTINCT tbDepo.sSube AS Sube, tbAlisveris.sFisTipi AS FisTipi, tbAlisveris.nGirisCikis AS GirisCikis, tbOdeme.sOdemeSekli AS Kod, 0 AS Oran, 6 AS Tip FROM tbOdeme, tbAlisVeris, tbDepo, tbSubeOdemeSekli WHERE tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID AND (tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'SK' OR tbAlisVeris.sFisTipi = 'KS' OR tbAlisveris.sFisTipi = 'KVF' OR tbAlisveris.sFisTipi = 'PAD') AND tbOdeme.sMagaza = tbDepo.sDepo AND tbSubeOdemeSekli.sSube = tbDepo.sSube AND tbSubeOdemeSekli.sOdemeSekli = tbOdeme.sOdemeSekli AND tbSubeOdemeSekli.nSatisID = 0 AND tbOdeme.dteOdemeTarihi BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "' AND tbOdeme.bMuhasebeyeIslendimi = 0 UNION ALL SELECT DISTINCT tbDepo.sSube AS Sube, tbAlisveris.sFisTipi AS FisTipi, tbAlisveris.nGirisCikis AS GirisCikis, tbOdeme.sOdemeSekli AS Kod, 0 AS Oran, 7 AS Tip FROM tbOdeme, tbAlisVeris, tbDepo, tbSubeOdemeSekli WHERE tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID AND (tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'SK' OR tbAlisVeris.sFisTipi = 'KS' OR tbAlisveris.sFisTipi = 'KVF' OR tbAlisveris.sFisTipi = 'PAD') AND tbOdeme.sMagaza = tbDepo.sDepo AND tbSubeOdemeSekli.sSube = tbDepo.sSube AND tbSubeOdemeSekli.sOdemeSekli = tbOdeme.sOdemeSekli AND tbSubeOdemeSekli.nKomisyonOrani <> 0 AND tbSubeOdemeSekli.nKomisyonHesapID = 0 AND tbOdeme.dteOdemeTarihi BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "' AND tbOdeme.bMuhasebeyeIslendimi = 0 UNION ALL SELECT DISTINCT tbDepo.sSube AS Sube, tbAlisveris.sFisTipi AS FisTipi, tbAlisveris.nGirisCikis AS GirisCikis, tbOdeme.sOdemeSekli AS Kod, 0 AS Oran, 9 AS Tip FROM tbOdeme, tbAlisVeris, tbDepo, tbSubeOdemeSekli WHERE tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID AND (tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'SK' OR tbAlisVeris.sFisTipi = 'KS' OR tbAlisveris.sFisTipi = 'KVF' OR tbAlisveris.sFisTipi = 'PAD') AND tbOdeme.sMagaza = tbDepo.sDepo AND tbSubeOdemeSekli.sSube = tbDepo.sSube AND tbSubeOdemeSekli.sOdemeSekli = tbOdeme.sOdemeSekli AND tbSubeOdemeSekli.nErkenOdemeKomOrani <> 0 AND tbSubeOdemeSekli.nErkenOdemeKomHesapID = 0 AND tbOdeme.dteOdemeTarihi BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "' AND tbOdeme.bMuhasebeyeIslendimi = 0 UNION ALL SELECT DISTINCT tbDepo.sSube AS Sube, tbAlisveris.sFisTipi AS FisTipi, 3 AS GirisCikis, '' AS Kod, 0 AS Oran, 8 AS Tip FROM tbOdeme, tbAlisVeris, tbDepo WHERE tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID AND tbAlisVeris.sFisTipi = 'SK' AND tbOdeme.sMagaza = tbDepo.sDepo AND NOT EXISTS (SELECT nHesapID FROM tbSubeMagazaHesaplari WHERE tbDepo.sSube = sSubeMagaza AND nSubeMagazaHesapTipi = 37 AND sHareketTipi = '') AND tbOdeme.dteOdemeTarihi BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "' AND tbOdeme.bMuhasebeyeIslendimi = 0) Rapor ORDER BY Sube, GirisCikis, FisTipi, Tip"))
        'Dim sIskonto As String = "SUM(abs(tbStokFisiDetayi.lIskontoTutari)) AS Iskonto"
        'If sec_bIskontoSubeHesabinaKdvHaric.Checked = True Then
        '    sIskonto = "SUM(abs(tbStokFisiDetayi.lIskontoTutari)/ (1 + tbStokFisiDetayi.nKDVOrani * 0.01)) AS Iskonto"
        'End If
        'Dim sFisNoAlisVeris As String = "0 AS FisNo"
        'Dim sFisNoStokFisi As String = "0 AS FisNo"
        'Dim sFisNoGroup As String = "0 AS FisNo"
        'If sec_bHerSatisAyriFis.Checked = True Then
        '    sFisNoAlisVeris = "CASE tbAlisveris.nGirisCikis WHEN 3 THEN tbAlisveris.lFaturaNo ELSE 0 END AS FisNo"
        '    sFisNoStokFisi = "CASE tbStokFisiDetayi.nGirisCikis WHEN 3 THEN tbStokFisiDetayi.lFisNo ELSE 0 END AS FisNo"
        'Else
        'End If
        'If dataset1.Tables(0).Rows.Count = 0 Then
        '    dataset1 = sorgu(sorgu_query("SELECT UPPER(Sube) AS sSubeMagaza, UPPER(Depo) AS sDepo, DepoAdi, FisTarihi, UPPER(FisTipi) AS sFisTipi, GirisCikis, HesapID, Miktar, Tutar, Iskonto, IskontoID, VadeFarki, Tip, Aciklama, ErkenOdeme, ErkenOdemeID, HareketTipi, FisNo, DovizTutari, DovizCinsi FROM (SELECT tbDepo.sSube AS Sube , tbAlisveris.sMagaza AS Depo , tbDepo.sAciklama AS DepoAdi , tbAlisveris.dteFaturaTarihi AS FisTarihi , tbAlisveris.sFisTipi AS FisTipi , tbAlisveris.nGirisCikis AS GirisCikis , tbSubeMagazaHesaplari.nHesapID AS HesapID , SUM(abs(tbAlisveris.lToplamMiktar)) AS Miktar , CASE sFisTipi WHEN 'KVF' THEN SUM(abs(tbAlisveris.lVadeFarki) - abs(tbAlisveris.lVadeKDV)) ELSE SUM((abs(tbAlisveris.lNetTutar) - abs(tbAlisveris.lKDV1) - abs(tbAlisveris.lKDV2) - abs(tbAlisveris.lKDV3) - abs(tbAlisveris.lKDV4) - abs(tbAlisveris.lKDV5))) END AS Tutar , SUM(abs(tbAlisveris.lMalIskontoTutari) + abs(tbAlisveris.lDipIskontoTutari)) AS Iskonto , 0 AS IskontoID , CASE sFisTipi WHEN 'KVF' THEN 0 ELSE SUM(abs(tbAlisveris.lVadeFarki)) END AS VadeFarki , 1 AS Tip , '' AS Aciklama , 0 AS ErkenOdeme , 0 AS ErkenOdemeID , '' AS HareketTipi , 0 AS FisNo , 0 AS DovizTutari , '' AS DovizCinsi FROM tbAlisveris , tbDepo , tbSubeMagaza , tbSubeMagazaHesaplari WHERE tbAlisveris.sMagaza = tbDepo.sDepo AND tbSubeMagaza.sSubeMagaza = tbDepo.sSube AND ((tbSubeMagaza.bHerMagazadaAyriSatHesVar = 1 AND (tbAlisveris.sFisTipi = 'KVF' OR tbAlisveris.sFisTipi = 'PAD')) OR (tbSubeMagaza.bHerMagazadaAyriSatHesVar = 0 AND (tbAlisveris.sFisTipi = 'K' OR tbAlisveris.sFisTipi = 'KS' OR tbAlisveris.sFisTipi = 'KVF' OR tbAlisveris.sFisTipi = 'PAD'))) AND (((tbAlisveris.sfistipi = 'K' OR tbAlisveris.sfistipi = 'KS' OR tbAlisveris.sfistipi = 'PAD') AND tbAlisveris.nGirisCikis = 3 AND tbSubeMagazaHesaplari.nsubemagazahesaptipi = 23 AND tbSubeMagazaHesaplari.sSubeMagaza = tbDepo.sSube AND tbSubeMagazaHesaplari.sHareketTipi = '') OR ((tbAlisveris.sfistipi = 'K' OR tbAlisveris.sfistipi = 'KS' OR tbAlisveris.sfistipi = 'PAD') AND tbAlisveris.nGirisCikis = 4 AND tbSubeMagazaHesaplari.nsubemagazahesaptipi = 24 AND tbSubeMagazaHesaplari.sSubeMagaza = tbDepo.sSube AND tbSubeMagazaHesaplari.sHareketTipi = '') OR (tbAlisveris.sfistipi = 'KVF' AND tbAlisveris.nGirisCikis = 3 AND tbSubeMagazaHesaplari.nsubemagazahesaptipi = 32 AND tbSubeMagazaHesaplari.sSubeMagaza = tbDepo.sSube AND tbSubeMagazaHesaplari.sHareketTipi = '') OR (tbAlisveris.sfistipi = 'KVF' AND tbAlisveris.nGirisCikis = 4 AND tbSubeMagazaHesaplari.nsubemagazahesaptipi = 33 AND tbSubeMagazaHesaplari.sSubeMagaza = tbDepo.sSube AND tbSubeMagazaHesaplari.sHareketTipi = '')) AND tbAlisveris.dteFaturaTarihi BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "' AND tbAlisveris.bMuhasebeyeIslendimi = 0 GROUP BY tbDepo.sSube , tbAlisveris.sMagaza , tbDepo.sAciklama , tbAlisveris.dteFaturaTarihi , tbAlisveris.sFisTipi , tbAlisveris.nGirisCikis , tbSubeMagazaHesaplari.nHesapID UNION ALL SELECT sSube AS Sube , sMagaza AS Depo , sDepoAdi AS DepoAdi , dteFaturaTarihi AS FisTarihi , sFisTipi AS FisTipi , nGirisCikis AS GirisCikis , nHesapID AS HesapID , Oran AS Miktar , SUM(abs(KDV)) AS Tutar , 0 AS Iskonto , 0 AS IskontoID , 0 AS VadeFarki , 0 AS Tip , Aciklama AS Aciklama , 0 AS ErkenOdeme , 0 AS ErkenOdemeID , HareketTipi AS HareketTipi , FisNo AS FisNo , 0 AS DovizTutari , '' AS DovizCinsi FROM (SELECT sSube , tbAlisveris.sMagaza , tbDepo.sAciklama AS sDepoAdi , dteFaturaTarihi , sFisTipi , nGirisCikis , nHesapID , nVadeKDVOrani AS Oran , SUM(abs(lVadeKDV)) AS KDV , '' AS Aciklama , '' AS HareketTipi , 0 AS FisNo , 0 AS DovizTutari , '' AS DovizCinsi FROM tbAlisveris , tbDepo , tbSubeMagazaKDV , tbKDV WHERE nVadeKDVOrani <> 0 AND tbDepo.sDepo = tbAlisveris.sMagaza AND tbSubeMagazaKDV.sSubeMagaza = tbdepo.sSube AND nVadeKDVOrani = tbKDV.nKDVOrani AND tbAlisveris.sFisTipi = 'KVF' AND ((tbAlisveris.nGirisCikis = 3 AND tbSubeMagazaKDV.nsubemagazahesaptipi = 42 AND tbSubeMagazaKDV.sSubeMagaza = tbDepo.sSube AND tbSubeMagazaKDV.sHareketTipi = '' AND tbKDV.sKDVTipi = tbSubeMagazaKDV.sKDVTipi) OR (tbAlisveris.nGirisCikis = 4 AND tbSubeMagazaKDV.nsubemagazahesaptipi = 43 AND tbSubeMagazaKDV.sSubeMagaza = tbDepo.sSube AND tbSubeMagazaKDV.sHareketTipi = '' AND tbKDV.sKDVTipi = tbSubeMagazaKDV.sKDVTipi)) AND tbAlisveris.dteFaturaTarihi BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "' AND tbAlisveris.bMuhasebeyeIslendimi = 0 GROUP BY sSube , tbAlisveris.sMagaza , tbDepo.sAciklama , dteFaturaTarihi , sFisTipi , nGirisCikis , nVadeKDVOrani , nhesapID UNION ALL SELECT sSube , tbAlisveris.sMagaza , tbDepo.sAciklama AS sDepoAdi , dteFaturaTarihi , sFisTipi , nGirisCikis , nHesapID , nKdvOrani1 AS Oran , SUM(abs(lkdv1)) AS KDV , '' AS Aciklama , '' AS HareketTipi , 0 AS FisNo , 0 AS DovizTutari , '' AS DovizCinsi FROM tbAlisveris , tbDepo , tbSubeMagaza , tbSubeMagazaKDV , tbKDV WHERE nKdvOrani1 <> 0 AND tbDepo.sDepo = tbAlisveris.sMagaza AND tbSubeMagaza.sSubeMagaza = tbDepo.sSube AND tbSubeMagaza.bHerMagazadaAyriSatHesVar = 0 AND tbKDV.nKDVOrani = nKdvOrani1 AND ((tbAlisveris.nGirisCikis = 3 AND tbSubeMagazaKDV.nsubemagazahesaptipi = 42 AND tbSubeMagazaKDV.sSubeMagaza = tbDepo.sSube AND tbSubeMagazaKDV.sHareketTipi = '' AND tbKDV.sKDVTipi = tbSubeMagazaKDV.sKDVTipi) OR (tbAlisveris.nGirisCikis = 4 AND tbSubeMagazaKDV.nsubemagazahesaptipi = 43 AND tbSubeMagazaKDV.sSubeMagaza = tbDepo.sSube AND tbSubeMagazaKDV.sHareketTipi = '' AND tbKDV.sKDVTipi = tbSubeMagazaKDV.sKDVTipi)) AND (tbAlisveris.sFisTipi = 'K' OR tbAlisveris.sFisTipi = 'KS') AND tbAlisveris.dteFaturaTarihi BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "' AND tbAlisveris.bMuhasebeyeIslendimi = 0 GROUP BY sSube , tbAlisveris.sMagaza , tbDepo.sAciklama , dteFaturaTarihi , sFisTipi , nGirisCikis , nKdvOrani1 , tbSubeMagazaKDV.nHesapID UNION ALL SELECT sSube , tbAlisveris.sMagaza , tbDepo.sAciklama AS sDepoAdi , dteFaturaTarihi , sFisTipi , nGirisCikis , nHesapID , nKdvOrani2 AS Oran , SUM(abs(lkdv2)) AS KDV , '' AS Aciklama , '' AS HareketTipi , 0 AS FisNo , 0 AS DovizTutari , '' AS DovizCinsi FROM tbAlisveris , tbDepo , tbSubeMagaza , tbSubeMagazaKDV , tbKDV WHERE nKdvOrani2 <> 0 AND tbDepo.sDepo = tbAlisveris.sMagaza AND tbSubeMagaza.sSubeMagaza = tbDepo.sSube AND tbSubeMagaza.sSubeMagaza = tbDepo.sSube AND tbSubeMagaza.bHerMagazadaAyriSatHesVar = 0 AND tbKDV.nKDVOrani = nKdvOrani2 AND ((tbAlisveris.nGirisCikis = 3 AND tbSubeMagazaKDV.nsubemagazahesaptipi = 42 AND tbSubeMagazaKDV.sSubeMagaza = tbDepo.sSube AND tbSubeMagazaKDV.sHareketTipi = '' AND tbKDV.sKDVTipi = tbSubeMagazaKDV.sKDVTipi) OR (tbAlisveris.nGirisCikis = 4 AND tbSubeMagazaKDV.nsubemagazahesaptipi = 43 AND tbSubeMagazaKDV.sSubeMagaza = tbDepo.sSube AND tbSubeMagazaKDV.sHareketTipi = '' AND tbKDV.sKDVTipi = tbSubeMagazaKDV.sKDVTipi)) AND (tbAlisveris.sFisTipi = 'K' OR tbAlisveris.sFisTipi = 'KS') AND tbAlisveris.dteFaturaTarihi BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "' AND tbAlisveris.bMuhasebeyeIslendimi = 0 GROUP BY sSube , tbAlisveris.sMagaza , tbDepo.sAciklama , dteFaturaTarihi , sFisTipi , nGirisCikis , nKdvOrani2 , tbSubeMagazaKDV.nHesapID UNION ALL SELECT sSube , tbAlisveris.sMagaza , tbDepo.sAciklama AS sDepoAdi , dteFaturaTarihi , sFisTipi , nGirisCikis , nHesapId , nKdvOrani3 AS Oran , SUM(abs(lkdv3)) AS KDV , '' AS Aciklama , '' AS HareketTipi , 0 AS FisNo , 0 AS DovizTutari , '' AS DovizCinsi FROM tbAlisveris , tbDepo , tbSubeMagaza , tbSubeMagazaKDV , tbKDV WHERE nKdvOrani3 <> 0 AND tbDepo.sDepo = tbAlisveris.sMagaza AND tbSubeMagaza.sSubeMagaza = tbDepo.sSube AND tbSubeMagaza.sSubeMagaza = tbDepo.sSube AND tbSubeMagaza.bHerMagazadaAyriSatHesVar = 0 AND tbKDV.nKDVOrani = nKdvOrani3 AND ((tbAlisveris.nGirisCikis = 3 AND tbSubeMagazaKDV.nsubemagazahesaptipi = 42 AND tbSubeMagazaKDV.sSubeMagaza = tbDepo.sSube AND tbSubeMagazaKDV.sHareketTipi = '' AND tbKDV.sKDVTipi = tbSubeMagazaKDV.sKDVTipi) OR (tbAlisveris.nGirisCikis = 4 AND tbSubeMagazaKDV.nsubemagazahesaptipi = 43 AND tbSubeMagazaKDV.sSubeMagaza = tbDepo.sSube AND tbSubeMagazaKDV.sHareketTipi = '' AND tbKDV.sKDVTipi = tbSubeMagazaKDV.sKDVTipi)) AND (tbAlisveris.sFisTipi = 'K' OR tbAlisveris.sFisTipi = 'KS') AND tbAlisveris.dteFaturaTarihi BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "' AND tbAlisveris.bMuhasebeyeIslendimi = 0 GROUP BY sSube , tbAlisveris.sMagaza , tbDepo.sAciklama , dteFaturaTarihi , sFisTipi , nGirisCikis , nKdvOrani3 , tbSubeMagazaKDV.nHesapID UNION ALL SELECT sSube , tbAlisveris.sMagaza , tbDepo.sAciklama AS sDepoAdi , dteFaturaTarihi , sFisTipi , nGirisCikis , nHesapID , nKdvOrani4 AS Oran , SUM(abs(lkdv4)) AS KDV , '' AS Aciklama , '' AS HareketTipi , 0 AS FisNo , 0 AS DovizTutari , '' AS DovizCinsi FROM tbAlisveris , tbDepo , tbSubeMagaza , tbSubeMagazaKDV , tbKDV WHERE nKdvOrani4 <> 0 AND tbDepo.sDepo = tbAlisveris.sMagaza AND tbSubeMagaza.sSubeMagaza = tbDepo.sSube AND tbSubeMagaza.bHerMagazadaAyriSatHesVar = 0 AND tbKDV.nKDVOrani = nKdvOrani4 AND ((tbAlisveris.nGirisCikis = 3 AND tbSubeMagazaKDV.nsubemagazahesaptipi = 42 AND tbSubeMagazaKDV.sSubeMagaza = tbDepo.sSube AND tbSubeMagazaKDV.sHareketTipi = '' AND tbKDV.sKDVTipi = tbSubeMagazaKDV.sKDVTipi) OR (tbAlisveris.nGirisCikis = 4 AND tbSubeMagazaKDV.nsubemagazahesaptipi = 43 AND tbSubeMagazaKDV.sSubeMagaza = tbDepo.sSube AND tbSubeMagazaKDV.sHareketTipi = '' AND tbKDV.sKDVTipi = tbSubeMagazaKDV.sKDVTipi)) AND (tbAlisveris.sFisTipi = 'K' OR tbAlisveris.sFisTipi = 'KS') AND tbAlisveris.dteFaturaTarihi BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "' AND tbAlisveris.bMuhasebeyeIslendimi = 0 GROUP BY sSube , tbAlisveris.sMagaza , tbDepo.sAciklama , dteFaturaTarihi , sFisTipi , nGirisCikis , nKdvOrani4 , tbSubeMagazaKDV.nHesapID UNION ALL SELECT sSube , tbAlisveris.sMagaza , tbDepo.sAciklama AS sDepoAdi , dteFaturaTarihi , sFisTipi , nGirisCikis , nHesapID , nKdvOrani5 AS Oran , SUM(abs(lkdv5)) AS KDV , '' AS Aciklama , '' AS HareketTipi , 0 AS FisNo , 0 AS DovizTutari , '' AS DovizCinsi FROM tbAlisveris , tbDepo , tbSubeMagaza , tbSubeMagazaKDV , tbKDV WHERE nKdvOrani5 <> 0 AND tbDepo.sDepo = tbAlisveris.sMagaza AND tbSubeMagaza.sSubeMagaza = tbDepo.sSube AND tbSubeMagaza.bHerMagazadaAyriSatHesVar = 0 AND tbKDV.nKDVOrani = nKdvOrani5 AND ((tbAlisveris.nGirisCikis = 3 AND tbSubeMagazaKDV.nsubemagazahesaptipi = 42 AND tbSubeMagazaKDV.sSubeMagaza = tbDepo.sSube AND tbSubeMagazaKDV.sHareketTipi = '' AND tbKDV.sKDVTipi = tbSubeMagazaKDV.sKDVTipi) OR (tbAlisveris.nGirisCikis = 4 AND tbSubeMagazaKDV.nsubemagazahesaptipi = 43 AND tbSubeMagazaKDV.sSubeMagaza = tbDepo.sSube AND tbSubeMagazaKDV.sHareketTipi = '' AND tbKDV.sKDVTipi = tbSubeMagazaKDV.sKDVTipi)) AND (tbAlisveris.sFisTipi = 'K' OR tbAlisveris.sFisTipi = 'KS') AND tbAlisveris.dteFaturaTarihi BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "' AND tbAlisveris.bMuhasebeyeIslendimi = 0 GROUP BY sSube , tbAlisveris.sMagaza , tbDepo.sAciklama , dteFaturaTarihi , sFisTipi , nGirisCikis , nKdvOrani5 , tbSubeMagazaKDV.nHesapID) AS TempKDV GROUP BY sSube , sMagaza , sDepoAdi , dteFaturaTarihi , sFisTipi , nGirisCikis , Oran , nHesapID , Aciklama , HareketTipi , Fisno UNION ALL SELECT sSube AS Sube , sDepo AS Depo , sDepoAdi AS DepoAdi , dteFaturaTarihi AS FisTarihi , sFisTipi AS FisTipi , nGirisCikis AS GirisCikis , nHesapID AS HesapID , Oran AS Miktar , SUM(abs(KDV)) AS Tutar , 0 AS Iskonto , 0 AS IskontoID , 0 AS VadeFarki , 0 AS Tip , Aciklama AS Aciklama , 0 AS ErkenOdeme , 0 AS ErkenOdemeID , HareketTipi AS HareketTipi , FisNo AS Fisno , 0 AS DovizTutari , '' AS DovizCinsi FROM (SELECT tbDepo.sSube AS sSube , tbStokFisiDetayi.sDepo AS sDepo , tbDepo.sAciklama AS sDepoAdi , tbStokFisiDetayi.dteFisTarihi AS dteFaturaTarihi , tbStokFisiDetayi.sFisTipi AS sFisTipi , tbStokFisiDetayi.nGirisCikis AS nGirisCikis , tbSubeMagazaKDV.nHesapID AS nHesapID , tbStokFisiDetayi.nKDVOrani AS Oran , (SUM((tbstokfisidetayi.lbruttutar - tbstokfisidetayi.lIskontotutari)) - (SUM((tbstokfisidetayi.lbruttutar - tbstokfisidetayi.lIskontotutari)) / (1 + (tbstokfisidetayi.nKdvorani * 0.01)))) AS KDV , 0 AS Iskonto , 0 AS IskontoID , 0 AS Tip , '' AS Aciklama , 0 AS ErkenOdeme , 0 AS ErkenOdemeID , '' AS HareketTipi , 0 AS FisNo , 0 AS DovizTutari , '' AS DovizCinsi FROM tbStokFisiDetayi , tbDepo , tbSubeMagaza , tbSubeMagazaKDV , tbKDV WHERE (tbStokFisiDetayi.sFisTipi = 'K' OR tbStokFisiDetayi.sFisTipi = 'KS') AND tbStokFisiDetayi.nKDVOrani <> 0 AND tbDepo.sDepo = tbStokFisiDetayi.sDepo AND tbKDV.nKDVOrani = tbStokFisiDetayi.nKDVOrani AND tbSubeMagaza.sSubeMagaza = tbdepo.sSube AND tbSubeMagaza.bHerMagazadaAyriSatHesVar = 1 AND tbDepo.sDepo = tbStokFisiDetayi.sDepo AND tbSubeMagaza.bHerMagazadaAyriSatHesVar = 1 AND ((tbStokFisiDetayi.nGirisCikis = 3 AND tbSubeMagazaKDV.nsubemagazahesaptipi = 42 AND tbSubeMagazaKDV.sSubeMagaza = tbDepo.sSube AND tbSubeMagazaKDV.sHareketTipi = '' AND tbKDV.sKDVTipi = tbSubeMagazaKDV.sKDVTipi) OR (tbStokFisiDetayi.nGirisCikis = 4 AND tbSubeMagazaKDV.nsubemagazahesaptipi = 43 AND tbSubeMagazaKDV.sSubeMagaza = tbDepo.sSube AND tbSubeMagazaKDV.sHareketTipi = '' AND tbKDV.sKDVTipi = tbSubeMagazaKDV.sKDVTipi)) AND tbStokFisiDetayi.dteFisTarihi BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "' AND tbStokFisiDetayi.bMuhasebeyeIslendimi = 0 GROUP BY tbDepo.sSube , tbStokFisiDetayi.sDepo , tbDepo.sAciklama , tbStokFisiDetayi.dteFisTarihi , tbStokFisiDetayi.sFisTipi , tbStokFisiDetayi.nalisverisID , tbStokFisiDetayi.nGirisCikis , tbStokFisiDetayi.nKdvOrani , tbSubeMagazaKDV.nHesapID) AS TempStokKDV GROUP BY sSube , sDepo , sDepoAdi , dteFaturaTarihi , sFisTipi , nGirisCikis , Oran , nHesapID , Aciklama , HareketTipi , Fisno UNION ALL SELECT tbDepo.sSube AS Sube , tbStokFisiDetayi.sDepo AS Depo , tbDepo.sAciklama AS DepoAdi , tbStokFisiDetayi.dteFisTarihi AS FisTarihi , tbStokFisiDetayi.sFisTipi AS FisTipi , tbStokFisiDetayi.nGirisCikis AS GirisCikis , tbStokMuhasebeEntegrasyon.nHesapID AS HesapID , SUM(abs(tbStokFisiDetayi.lCikisMiktar1)) AS Miktar , SUM(abs(tbStokFisiDetayi.lCikisTutar)) AS Tutar , " & sIskonto & " , 0 AS IskontoID , 0 AS VadeFarki , 1 AS Tip , '' AS Aciklama , 0 AS ErkenOdeme , 0 AS ErkenOdemeID , '' AS HareketTipi , 0 AS FisNo , 0 AS DovizTutari , '' AS DovizCinsi FROM tbStokFisiDetayi , tbDepo , tbStokMuhasebeEntegrasyon , tbSubeMagaza WHERE tbStokFisiDetayi.sDepo = tbDepo.sDepo AND tbDepo.sDepo = tbStokFisiDetayi.sDepo AND tbSubeMagaza.sSubeMagaza = tbdepo.sSube AND tbSubeMagaza.bHerMagazadaAyriSatHesVar = 1 AND (tbStokFisiDetayi.sFisTipi = 'K' OR tbStokFisiDetayi.sFisTipi = 'KS') AND ((tbStokFisiDetayi.nGirisCikis = 3 AND tbStokMuhasebeEntegrasyon.nsubemagazahesaptipi = 23 AND tbStokMuhasebeEntegrasyon.sSubeMagaza = tbDepo.sSube AND tbStokMuhasebeEntegrasyon.sHareketTipi = '' AND tbStokFisiDetayi.nStokID = tbStokMuhasebeEntegrasyon.nStokID) OR (tbStokFisiDetayi.nGirisCikis = 4 AND tbStokMuhasebeEntegrasyon.nsubemagazahesaptipi = 24 AND tbStokMuhasebeEntegrasyon.sSubeMagaza = tbDepo.sSube AND tbStokMuhasebeEntegrasyon.sHareketTipi = '' AND tbStokFisiDetayi.nStokID = tbStokMuhasebeEntegrasyon.nStokID)) AND tbStokFisiDetayi.dteFisTarihi BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "' AND tbStokFisiDetayi.bMuhasebeyeIslendimi = 0 GROUP BY tbDepo.sSube , tbStokFisiDetayi.sDepo , tbDepo.sAciklama , tbStokFisiDetayi.dteFisTarihi , tbStokFisiDetayi.sFisTipi , tbStokFisiDetayi.nGirisCikis , tbStokMuhasebeEntegrasyon.nHesapID UNION ALL SELECT tbDepo.sSube AS Sube , tbOdeme.sMagaza AS Depo , tbDepo.sAciklama AS DepoAdi , tbAlisVeris.dteFaturaTarihi AS FisTarihi , tbAlisVeris.sFisTipi AS FisTipi , tbAlisVeris.nGirisCikis AS GirisCikis , tbSubeOdemeSekli.nSatisID AS HesapID , 0 AS Miktar , SUM(abs(tbOdeme.lOdemeTutar)) AS Tutar , SUM((abs(tbOdeme.lOdemeTutar) * nKomisyonOrani * 0.01)) AS Iskonto , tbSubeOdemeSekli.nKomisyonHesapID AS IskontoID , 0 AS VadeFarki , 3 AS Tip , '' AS Aciklama , SUM((abs(tbOdeme.lOdemeTutar) * tbSubeOdemeSekli.nErkenOdemeKomOrani * 0.01)) AS ErkenOdeme , tbSubeOdemeSekli.nErkenOdemeKomHesapID AS ErkenOdemeID , '' AS HareketTipi , 0 AS FisNo , 0 AS DovizTutari , '' AS DovizCinsi FROM tbAlisVeris , tbOdeme , tbSubeOdemeSekli , tbDepo , tbOdemeSekli WHERE (tbAlisveris.sFisTipi = 'K' OR tbAlisveris.sFisTipi = 'SK' OR (tbAlisveris.sFisTipi = 'KS' AND tbOdemeSekli.nOdemeTipi <> 3) OR tbAlisveris.sFisTipi = 'KVF' OR tbAlisveris.sFisTipi = 'PAD') AND tbOdeme.nAlisverisID = tbAlisveris.nAlisverisID AND tbOdemeSekli.sOdemeSekli = tbOdeme.sOdemeSekli AND tbDepo.sDepo = tbOdeme.sMagaza AND tbOdeme.nOdemeKodu = 1 AND tbSubeOdemeSekli.sSube = tbDepo.sSube AND tbSubeOdemeSekli.sOdemeSekli = tbOdeme.sOdemeSekli AND tbAlisVeris.dteFaturaTarihi BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "' AND tbOdeme.bMuhasebeyeIslendimi = 0 GROUP BY tbDepo.sSube , tbOdeme.sMagaza , tbDepo.sAciklama , tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.nGirisCikis , tbSubeOdemeSekli.nSatisID , tbSubeOdemeSekli.nKomisyonHesapID , tbSubeOdemeSekli.nErkenOdemeKomHesapID UNION ALL SELECT tbDepo.sSube AS Sube , tbOdeme.sMagaza AS Depo , tbDepo.sAciklama AS DepoAdi , tbOdeme.dteOdemeTarihi AS FisTarihi , CASE tbAlisveris.sFisTipi WHEN 'SK' THEN 'SK' ELSE 'K' END , tbAlisVeris.nGirisCikis AS GirisCikis , tbSubeOdemeSekli.nSatisID AS HesapID , 0 AS Miktar , SUM(abs(tbOdeme.lOdemeTutar)) AS Tutar , SUM((abs(tbOdeme.lOdemeTutar) * nKomisyonOrani * 0.01)) AS Iskonto , tbSubeOdemeSekli.nKomisyonHesapID AS IskontoID , 0 AS VadeFarki , 4 AS Tip , ' (' + ltrim(str(MIN(lOdemeNo))) + '-' + ltrim(str(MAX(lOdemeNo))) + ')' AS Aciklama , SUM((abs(tbOdeme.lOdemeTutar) * tbSubeOdemeSekli.nErkenOdemeKomOrani * 0.01)) AS ErkenOdeme , tbSubeOdemeSekli.nErkenOdemeKomHesapID AS ErkenOdemeID , '' AS HareketTipi , 0 AS FisNo , 0 AS DovizTutari , '' AS DovizCinsi FROM tbAlisVeris , tbOdeme , tbSubeOdemeSekli , tbDepo WHERE (tbAlisveris.sFisTipi = 'K' OR tbAlisveris.sFisTipi = 'SK' OR tbAlisveris.sFisTipi = 'KS' OR tbAlisveris.sFisTipi = 'KVF' OR tbAlisveris.sFisTipi = 'PAD') AND tbOdeme.nAlisverisID = tbAlisveris.nAlisverisID AND tbDepo.sDepo = tbOdeme.sMagaza AND tbOdeme.nOdemeKodu = 2 AND tbOdeme.lOdemeTutar > 0 AND tbSubeOdemeSekli.sSube = tbDepo.sSube AND tbSubeOdemeSekli.sOdemeSekli = tbOdeme.sOdemeSekli AND tbOdeme.dteOdemeTarihi BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "' AND tbOdeme.bMuhasebeyeIslendimi = 0 GROUP BY tbDepo.sSube , tbOdeme.sMagaza , tbDepo.sAciklama , tbOdeme.dteOdemeTarihi , tbAlisVeris.nGirisCikis , tbSubeOdemeSekli.nSatisID , tbSubeOdemeSekli.nKomisyonHesapID , tbSubeOdemeSekli.nErkenOdemeKomHesapID , tbAlisveris.sFisTipi UNION ALL SELECT tbDepo.sSube AS Sube , tbAlisVeris.sMagaza AS Depo , tbDepo.sAciklama AS DepoAdi , tbAlisverisSlip.dteValor AS FisTarihi , tbAlisveris.sFisTipi AS FisTipi , tbAlisVeris.nGirisCikis AS GirisCikis , tbSubeOdemeSekli.nSatisID AS HesapID , 0 AS Miktar , SUM(abs(tbAlisverisSlip.lTutar)) AS Tutar , SUM((abs(tbAlisverisSlip.lTutar) * tbSubeOdemeSekli.nKomisyonOrani * 0.01)) AS Iskonto , tbSubeOdemeSekli.nKomisyonHesapID AS IskontoID , 0 AS VadeFarki , 4 AS Tip , ' (' + ltrim(str(MIN(lOdemeNo))) + '-' + ltrim(str(MAX(lOdemeNo))) + ')' AS Aciklama , SUM((abs(tbAlisverisSlip.lTutar) * tbSubeOdemeSekli.nErkenOdemeKomOrani * 0.01)) AS ErkenOdeme , tbSubeOdemeSekli.nErkenOdemeKomHesapID AS ErkenOdemeID , '' AS HareketTipi , 0 AS FisNo , 0 AS DovizTutari , '' AS DovizCinsi FROM tbAlisVeris , tbOdeme , tbSubeOdemeSekli , tbDepo , tbAlisverisSlip , tbOdemeSekli WHERE tbAlisveris.sFisTipi = 'KS' AND tbOdeme.nAlisverisID = tbAlisveris.nAlisverisID AND tbAlisverisSlip.nAlisverisID = tbAlisveris.nAlisverisID AND tbOdeme.sOdemeSekli = tbOdemeSekli.sOdemeSekli AND tbOdemeSekli.nOdemeTipi = 3 AND tbOdeme.lOdemeTutar > 0 AND tbDepo.sDepo = tbAlisveris.sMagaza AND tbOdeme.nOdemeKodu = 1 AND tbSubeOdemeSekli.sSube = tbDepo.sSube AND tbSubeOdemeSekli.sOdemeSekli = tbOdeme.sOdemeSekli AND tbAlisverisSlip.dteValor BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "' AND tbAlisverisSlip.bMuhasebeyeIslendimi = 0 GROUP BY tbDepo.sSube , tbAlisVeris.sMagaza , tbDepo.sAciklama , tbAlisverisSlip.dteValor , tbAlisVeris.sFisTipi , tbAlisVeris.nGirisCikis , tbSubeOdemeSekli.nSatisID , tbSubeOdemeSekli.nKomisyonHesapID , tbSubeOdemeSekli.nErkenOdemeKomHesapID UNION ALL SELECT tbDepo.sSube AS Sube , tbOdeme.sMagaza AS Depo , tbDepo.sAciklama AS DepoAdi , tbOdeme.dteOdemeTarihi AS FisTarihi , CASE tbAlisveris.sFisTipi WHEN 'SK' THEN 'SK' ELSE 'K' END , 4 AS GirisCikis , tbSubeOdemeSekli.nSatisID AS HesapID , 0 AS Miktar , SUM(abs(tbOdeme.lOdemeTutar)) AS Tutar , SUM((abs(tbOdeme.lOdemeTutar) * nKomisyonOrani * 0.01)) AS Iskonto , tbSubeOdemeSekli.nKomisyonHesapID AS IskontoID , 0 AS VadeFarki , 4 AS Tip , ' (' + ltrim(str(MIN(lOdemeNo))) + '-' + ltrim(str(MAX(lOdemeNo))) + ')' AS Aciklama , SUM((abs(tbOdeme.lOdemeTutar) * tbSubeOdemeSekli.nErkenOdemeKomOrani * 0.01)) AS ErkenOdeme , tbSubeOdemeSekli.nErkenOdemeKomHesapID AS ErkenOdemeID , '' AS HareketTipi , 0 AS FisNo , 0 AS DovizTutari , '' AS DovizCinsi FROM tbAlisVeris , tbOdeme , tbSubeOdemeSekli , tbDepo WHERE (tbAlisveris.sFisTipi = 'K' OR tbAlisveris.sFisTipi = 'SK' OR tbAlisveris.sFisTipi = 'KS' OR tbAlisveris.sFisTipi = 'KVF' OR tbAlisveris.sFisTipi = 'PAD') AND tbOdeme.nAlisverisID = tbAlisveris.nAlisverisID AND tbDepo.sDepo = tbOdeme.sMagaza AND tbOdeme.nOdemeKodu = 2 AND tbOdeme.lOdemeTutar < 0 AND tbSubeOdemeSekli.sSube = tbDepo.sSube AND tbSubeOdemeSekli.sOdemeSekli = tbOdeme.sOdemeSekli AND tbOdeme.dteOdemeTarihi BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "' AND tbOdeme.bMuhasebeyeIslendimi = 0 GROUP BY tbDepo.sSube , tbOdeme.sMagaza , tbDepo.sAciklama , tbAlisveris.sFisTipi , tbOdeme.dteOdemeTarihi , tbAlisVeris.nGirisCikis , tbSubeOdemeSekli.nSatisID , tbSubeOdemeSekli.nKomisyonHesapID , tbSubeOdemeSekli.nErkenOdemeKomHesapID UNION ALL SELECT tbDepo.sSube AS Sube , tbAlisVeris.sMagaza AS Depo , tbDepo.sAciklama AS DepoAdi , tbAlisverisSlip.dteValor AS FisTarihi , tbAlisveris.sFisTipi AS FisTipi , 4 AS GirisCikis , tbSubeOdemeSekli.nSatisID AS HesapID , 0 AS Miktar , SUM(abs(tbAlisverisSlip.lTutar)) AS Tutar , SUM((abs(tbAlisverisSlip.lTutar) * tbSubeOdemeSekli.nKomisyonOrani * 0.01)) AS Iskonto , tbSubeOdemeSekli.nKomisyonHesapID AS IskontoID , 0 AS VadeFarki , 4 AS Tip , ' (' + ltrim(str(MIN(lOdemeNo))) + '-' + ltrim(str(MAX(lOdemeNo))) + ')' AS Aciklama , SUM((abs(tbAlisverisSlip.lTutar) * tbSubeOdemeSekli.nErkenOdemeKomOrani * 0.01)) AS ErkenOdeme , tbSubeOdemeSekli.nErkenOdemeKomHesapID AS ErkenOdemeID , '' AS HareketTipi , 0 AS FisNo , 0 AS DovizTutari , '' AS DovizCinsi FROM tbAlisVeris , tbOdeme , tbSubeOdemeSekli , tbDepo , tbAlisverisSlip , tbOdemeSekli WHERE tbAlisveris.sFisTipi = 'KS' AND tbOdeme.nAlisverisID = tbAlisveris.nAlisverisID AND tbAlisverisSlip.nAlisverisID = tbAlisveris.nAlisverisID AND tbOdeme.sOdemeSekli = tbOdemeSekli.sOdemeSekli AND tbOdemeSekli.nOdemeTipi = 3 AND tbOdeme.lOdemeTutar < 0 AND tbDepo.sDepo = tbAlisveris.sMagaza AND tbOdeme.nOdemeKodu = 1 AND tbSubeOdemeSekli.sSube = tbDepo.sSube AND tbSubeOdemeSekli.sOdemeSekli = tbOdeme.sOdemeSekli AND tbAlisverisSlip.dteValor BETWEEN '" & dteFisTarihi1 & "' AND '" & dteFisTarihi2 & "' AND tbAlisverisSlip.bMuhasebeyeIslendimi = 0 GROUP BY tbDepo.sSube , tbAlisVeris.sMagaza , tbDepo.sAciklama , tbAlisverisSlip.dteValor , tbAlisVeris.sFisTipi , tbAlisVeris.nGirisCikis , tbSubeOdemeSekli.nSatisID , tbSubeOdemeSekli.nKomisyonHesapID , tbSubeOdemeSekli.nErkenOdemeKomHesapID) Rapor ORDER BY FisTarihi, Depo, FisNo, FisTipi, GirisCikis, HareketTipi, Tip"))
        'End If
        Dim kriter As String = ""
        kriter += "Where (tbAlisVeris.dteFaturaTarihi between '" & txt_dteFisTarihi1.EditValue & "' AND '" & txt_dteFisTarihi2.EditValue & "') "
        kriter += "AND (tbMusteri.lKodu between " & txt_lKodu1.EditValue & " AND " & txt_lKodu2.EditValue & ") "
        kriter += "AND (tbAlisVeris.lFaturaNo between " & txt_lFisNo1.EditValue & " AND " & txt_lFisNo2.EditValue & ") "
        If sec_fistipi.EditValue <> "[Tümü]" Then
            kriter += "AND (tbAlisVeris.sFisTipi IN(" & Trim(sec_fistipi.EditValue) & ")) "
        End If
        If sec_depo.EditValue <> "[Tümü]" Then
            kriter += "AND (tbAlisVeris.sMagaza IN(" & Trim(sec_depo.EditValue) & ")) "
        End If
        'dataset1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisVeris.dteFaturaTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.lFaturaNo, tbMusteri.lKodu AS MusteriKodu, (tbMusteri.sAdi + tbMusteri.sSoyadi) AS Musteri, tbAlisVeris.sMagaza, (select ISNULL(sKodu, 0) from tbHesapPlani where nHesapID = " & nHesapID & ") as HesapKodu, (select ISNULL(sAciklama, '') from tbHesapPlani where nHesapID = " & nHesapID & ") as HesapAciklamasi, 'Evrak No:' + tbAlisVeris.lFaturaNo + ' Perakende Peşin Muhasebe Fişi' as Aciklama,  tbMusteri.nMusteriID, tbAlisVeris.lNetTutar, tbAlisVeris.lKdv1, tbAlisVeris.lKdv2, tbAlisVeris.lKdv3, tbAlisVeris.lKdv4, tbAlisVeris.lKdv5, tbAlisVeris.nAlisverisID, tbAlisVeris.nGirisCikis, tbAlisVeris.sYaziIleFROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID LEFT OUTER JOIN tbAlisVerisAdres ON tbAlisVeris.nAlisverisID = tbAlisVerisAdres.nAlisVerisID " & kriter & " " & kriter_musteri & " AND (tbAlisVeris.sFisTipi IN ('K','P','SK','SP')) tbAlisverisler"))
        If bPesin = True Then
            dataset1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisVeris.sMuhasebeFaturalasma, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.lFaturaNo, tbMusteri.lKodu AS MusteriKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, (tbMusteri.sAdi + tbMusteri.sSoyadi) AS Musteri, tbAlisVeris.sMagaza, tbMusteri.nMusteriID, tbAlisVeris.lNetTutar, (tbAlisVeris.lKdv1 + tbAlisVeris.lKdv2 + tbAlisVeris.lKdv3 + tbAlisVeris.lKdv4 + tbAlisVeris.lKdv5) as KDV, tbAlisVeris.lKdv1, tbAlisVeris.lKdv2, tbAlisVeris.lKdv3, tbAlisVeris.lKdv4, tbAlisVeris.lKdv5, tbAlisVeris.nKdvOrani1, tbAlisVeris.nKdvOrani2, tbAlisVeris.nKdvOrani3, tbAlisVeris.nKdvOrani4, tbAlisVeris.nKdvOrani5, tbAlisVeris.nAlisverisID, tbAlisVeris.nGirisCikis, tbAlisVeris.sYaziIle FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID LEFT OUTER JOIN tbAlisVerisAdres ON tbAlisVeris.nAlisverisID = tbAlisVerisAdres.nAlisVerisID " & kriter & " AND (tbAlisVeris.sFisTipi Not IN ('K', 'SK'))"))
        Else
            dataset1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisVeris.sMuhasebeFaturalasma, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.lFaturaNo, tbMusteri.lKodu AS MusteriKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, (tbMusteri.sAdi + tbMusteri.sSoyadi) AS Musteri, tbAlisVeris.sMagaza, tbMusteri.nMusteriID, tbAlisVeris.lNetTutar, (tbAlisVeris.lKdv1 + tbAlisVeris.lKdv2 + tbAlisVeris.lKdv3 + tbAlisVeris.lKdv4 + tbAlisVeris.lKdv5) as KDV, tbAlisVeris.lKdv1, tbAlisVeris.lKdv2, tbAlisVeris.lKdv3, tbAlisVeris.lKdv4, tbAlisVeris.lKdv5, tbAlisVeris.nKdvOrani1, tbAlisVeris.nKdvOrani2, tbAlisVeris.nKdvOrani3, tbAlisVeris.nKdvOrani4, tbAlisVeris.nKdvOrani5, tbAlisVeris.nAlisverisID, tbAlisVeris.nGirisCikis, tbAlisVeris.sYaziIle FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID LEFT OUTER JOIN tbAlisVerisAdres ON tbAlisVeris.nAlisverisID = tbAlisVerisAdres.nAlisVerisID " & kriter & " AND (tbAlisVeris.sFisTipi Not IN ('P', 'SP'))"))
        End If
        GridControl1.DataSource = dataset1.Tables(0)
        XtraTabControl1.SelectedTabPageIndex = 1
    End Sub
    Private Function fatura_Muhasebelestir() As Boolean
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim MuhsHareketTipi As String = ""
        If sec_bHareketTipi.SelectedIndex = 0 Then
            MuhsHareketTipi = Trim(sDepo)
        ElseIf sec_bHareketTipi.SelectedIndex = 1 Then
            MuhsHareketTipi = Trim(sec_sHareketTipi.EditValue)
        End If
        Dim nSubeMagazaHesapTipi As Integer = 0
        Dim nSubeMagazaHesapTipiKdv As Integer = 0
        Dim SonYevmiyeNo As Integer = SonYevmiyeNoBul("3")
        Dim nHesapID As Integer = KasaMuhasebeKoduBul(Trim(sSubeMagaza), MuhsHareketTipi)
        Dim sorgu As String = ""
        Dim basarili As Boolean = False
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim drs As DataRow
            Dim i As Integer = 0
            Dim lFaturaNo As String = ""
            Dim dteFaturaTarihi As String = ""
            Dim bas As Integer = 0
            Dim fisSayisi As Integer = 0
            Dim atla As Boolean = False
            ProgressBarControl1.Position = 0
            ProgressBarControl1.Properties.Maximum = dataset1.Tables(0).Rows.Count()
            ProgressBarControl1.Refresh()
            For Each drs In dataset1.Tables(0).Rows
                Try
                    atla = False
                    If sec_bYenile.Checked = False And drs("sMuhasebeFaturalasma").ToString() = "" Then
                        atla = False
                    ElseIf sec_bYenile.Checked = False And drs("sMuhasebeFaturalasma").ToString() <> "" Then
                        atla = True
                    Else
                        atla = False
                    End If
                    If atla = False Then
                        If sorgu_sayi(drs("lNetTutar"), 0) > 0 Then
                            fisSayisi = PerakendeMuhasebeFisiVarMi(Trim(drs("lFaturaNo").ToString()), "3", 2)
                            If fisSayisi > 0 Then
                                PerakendeMuhasebeFisiSil(Trim(drs("lFaturaNo").ToString()), Trim(drs("lFaturaNo").ToString()), Trim(drs("nAlisverisID").ToString()), "3", fisSayisi)
                                PerakendeNotMuhasebelestir(drs("lFaturaNo").ToString(), drs("nAlisverisID").ToString(), "")
                            End If
                        End If
                    End If
                Catch ex As Exception
                    PerakendeNotMuhasebelestir(drs("lFaturaNo").ToString(), drs("nAlisverisID").ToString(), "")
                End Try
                ProgressBarControl1.PerformStep()
                ProgressBarControl1.Refresh()
            Next
            drs = Nothing
            i = 0
            lFaturaNo = 0
            fisSayisi = 0
            ProgressBarControl1.Position = 0
            ProgressBarControl1.Properties.Maximum = dataset1.Tables(0).Rows.Count()
            ProgressBarControl1.Refresh()
            For Each drs In dataset1.Tables(0).Rows
                Try
                    atla = False
                    If sec_bYenile.Checked = False And drs("sMuhasebeFaturalasma").ToString() = "" Then
                        atla = False
                    ElseIf sec_bYenile.Checked = False And drs("sMuhasebeFaturalasma").ToString() <> "" Then
                        atla = True
                    Else
                        atla = False
                    End If
                    If atla = False Then
                        If i = 0 Then
                            lFaturaNo = drs("lFaturaNo").ToString()
                            dteFaturaTarihi = drs("dteFaturaTarihi").ToString()
                            If sec_bHerSatisAyriFis.Checked = True Then
                                SonYevmiyeNo = SonYevmiyeNoBul("3")
                                sorgu = ""
                                i = 0
                            Else
                                i += 1
                            End If
                        End If
                        nSubeMagazaHesapTipi = 0
                        If Trim(drs("nGirisCikis").ToString()) = "3" Then
                            nSubeMagazaHesapTipi = 20
                        ElseIf Trim(drs("nGirisCikis").ToString()) = "4" Then
                            nSubeMagazaHesapTipi = 21
                        End If
                        nSubeMagazaHesapTipiKdv = 0
                        If Trim(drs("nGirisCikis").ToString()) = "3" Then
                            nSubeMagazaHesapTipiKdv = 42
                        ElseIf Trim(drs("nGirisCikis").ToString()) = "4" Then
                            nSubeMagazaHesapTipiKdv = 43
                        End If
                        If sorgu_sayi(drs("lNetTutar"), 0) > 0 Then
                            sorgu += sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMuhasebeFisi(dteFisTarihi, sMuhFisTipi, lFisno, nEvrakNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi, sFisTipi, nFirmaIDMuh, nGirisCikis, nStokFisiID, nAlisverisID, nMusteriIDMuh) VALUES('" & dteFaturaTarihi & "', '3', " & lFaturaNo & ", " & drs("lFaturaNo").ToString() & ", " & SonYevmiyeNo & ", " & nHesapID & ", N'Evrak No:" & drs("lFaturaNo").ToString() & " Perakende Peşin Muhasebe Fişi', 0, 0, " & sorgu_sayi(drs("lNetTutar"), 0) & ", 0, '', 0, 'MUH', '" & MuhsHareketTipi & "', 0, 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & Now & "', '', 0, 0, '', 0, 0, 0, '" & Trim(sSubeMagaza) & "', 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & Now & "', '" & Trim(drs("sFisTipi").ToString()) & "', '0', '" & Trim(drs("nGirisCikis").ToString()) & "', '0', '" & Trim(drs("nAlisverisID").ToString()) & "', '" & Trim(drs("nMusteriID").ToString()) & "') ")
                            If sorgu_sayi(drs("lKdv1").ToString(), 0) > 0 Then
                                sorgu += sorgu_query("INSERT INTO tbMuhasebeFisi(dteFisTarihi, sMuhFisTipi, lFisno, nEvrakNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi, sFisTipi, nFirmaIDMuh, nGirisCikis, nStokFisiID, nAlisverisID, nMusteriIDMuh) VALUES('" & dteFaturaTarihi & "', '3', " & lFaturaNo & ", " & drs("lFaturaNo").ToString() & ", " & SonYevmiyeNo & ", (SELECT nHesapID from tbSubeMagazaKdv where (sSubeMagaza = '" & Trim(sSubeMagaza) & "') AND (sHareketTipi = '" & MuhsHareketTipi & "') AND (nSubeMagazaHesapTipi = " & nSubeMagazaHesapTipiKdv & ") AND (sKdvTipi = (select top 1 sKdvTipi from tbKdv where nKdvOrani = " & sorgu_sayi(drs("nKdvOrani1").ToString(), 0) & " Order by sKdvTipi asc))), N'Evrak No:" & drs("lFaturaNo").ToString() & " Perakende Peşin Muhasebe Fişi', 0, 0, 0, " & sorgu_sayi(drs("lKdv1"), 0) & ", '', 0, 'MUH', '" & MuhsHareketTipi & "', 0, 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & Now & "', '', 0, 0, '', 0, 0, 1, '" & Trim(sSubeMagaza) & "', 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & Now & "', '" & Trim(drs("sFisTipi").ToString()) & "', '0', '" & Trim(drs("nGirisCikis").ToString()) & "', '0', '" & Trim(drs("nAlisverisID").ToString()) & "', '" & Trim(drs("nMusteriID").ToString()) & "') ")
                            End If
                            If sorgu_sayi(drs("lKdv2").ToString(), 0) > 0 Then
                                sorgu += sorgu_query("INSERT INTO tbMuhasebeFisi(dteFisTarihi, sMuhFisTipi, lFisno, nEvrakNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi, sFisTipi, nFirmaIDMuh, nGirisCikis, nStokFisiID, nAlisverisID, nMusteriIDMuh) VALUES('" & dteFaturaTarihi & "', '3', " & lFaturaNo & ", " & drs("lFaturaNo").ToString() & ", " & SonYevmiyeNo & ", (SELECT nHesapID from tbSubeMagazaKdv where (sSubeMagaza = '" & Trim(sSubeMagaza) & "') AND (sHareketTipi = '" & MuhsHareketTipi & "') AND (nSubeMagazaHesapTipi = " & nSubeMagazaHesapTipiKdv & ") AND (sKdvTipi = (select top 1 sKdvTipi from tbKdv where nKdvOrani = " & sorgu_sayi(drs("nKdvOrani2").ToString(), 0) & " Order by sKdvTipi asc))), N'Evrak No:" & drs("lFaturaNo").ToString() & " Perakende Peşin Muhasebe Fişi', 0, 0, 0, " & sorgu_sayi(drs("lKdv2"), 0) & ", '', 0, 'MUH', '" & MuhsHareketTipi & "', 0, 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & Now & "', '', 0, 0, '', 0, 0, 1, '" & Trim(sSubeMagaza) & "', 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & Now & "', '" & Trim(drs("sFisTipi").ToString()) & "', '0', '" & Trim(drs("nGirisCikis").ToString()) & "', '0', '" & Trim(drs("nAlisverisID").ToString()) & "', '" & Trim(drs("nMusteriID").ToString()) & "') ")
                            End If
                            If sorgu_sayi(drs("lKdv3").ToString(), 0) > 0 Then
                                sorgu += sorgu_query("INSERT INTO tbMuhasebeFisi(dteFisTarihi, sMuhFisTipi, lFisno, nEvrakNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi, sFisTipi, nFirmaIDMuh, nGirisCikis, nStokFisiID, nAlisverisID, nMusteriIDMuh) VALUES('" & dteFaturaTarihi & "', '3', " & lFaturaNo & ", " & drs("lFaturaNo").ToString() & ", " & SonYevmiyeNo & ", (SELECT nHesapID from tbSubeMagazaKdv where (sSubeMagaza = '" & Trim(sSubeMagaza) & "') AND (sHareketTipi = '" & MuhsHareketTipi & "') AND (nSubeMagazaHesapTipi = " & nSubeMagazaHesapTipiKdv & ") AND (sKdvTipi = (select top 1 sKdvTipi from tbKdv where nKdvOrani = " & sorgu_sayi(drs("nKdvOrani3").ToString(), 0) & " Order by sKdvTipi asc))), N'Evrak No:" & drs("lFaturaNo").ToString() & " Perakende Peşin Muhasebe Fişi', 0, 0, 0, " & sorgu_sayi(drs("lKdv3"), 0) & ", '', 0, 'MUH', '" & MuhsHareketTipi & "', 0, 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & Now & "', '', 0, 0, '', 0, 0, 1, '" & Trim(sSubeMagaza) & "', 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & Now & "', '" & Trim(drs("sFisTipi").ToString()) & "', '0', '" & Trim(drs("nGirisCikis").ToString()) & "', '0', '" & Trim(drs("nAlisverisID").ToString()) & "', '" & Trim(drs("nMusteriID").ToString()) & "') ")
                            End If
                            If sorgu_sayi(drs("lKdv4").ToString(), 0) > 0 Then
                                sorgu += sorgu_query("INSERT INTO tbMuhasebeFisi(dteFisTarihi, sMuhFisTipi, lFisno, nEvrakNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi, sFisTipi, nFirmaIDMuh, nGirisCikis, nStokFisiID, nAlisverisID, nMusteriIDMuh) VALUES('" & dteFaturaTarihi & "', '3', " & lFaturaNo & ", " & drs("lFaturaNo").ToString() & ", " & SonYevmiyeNo & ", (SELECT nHesapID from tbSubeMagazaKdv where (sSubeMagaza = '" & Trim(sSubeMagaza) & "') AND (sHareketTipi = '" & MuhsHareketTipi & "') AND (nSubeMagazaHesapTipi = " & nSubeMagazaHesapTipiKdv & ") AND (sKdvTipi = (select top 1 sKdvTipi from tbKdv where nKdvOrani = " & sorgu_sayi(drs("nKdvOrani4").ToString(), 0) & " Order by sKdvTipi asc))), N'Evrak No:" & drs("lFaturaNo").ToString() & " Perakende Peşin Muhasebe Fişi', 0, 0, 0, " & sorgu_sayi(drs("lKdv4"), 0) & ", '', 0, 'MUH', '" & MuhsHareketTipi & "', 0, 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & Now & "', '', 0, 0, '', 0, 0, 1, '" & Trim(sSubeMagaza) & "', 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & Now & "', '" & Trim(drs("sFisTipi").ToString()) & "', '0', '" & Trim(drs("nGirisCikis").ToString()) & "', '0', '" & Trim(drs("nAlisverisID").ToString()) & "', '" & Trim(drs("nMusteriID").ToString()) & "') ")
                            End If
                            If sorgu_sayi(drs("lKdv5").ToString(), 0) > 0 Then
                                sorgu += sorgu_query("INSERT INTO tbMuhasebeFisi(dteFisTarihi, sMuhFisTipi, lFisno, nEvrakNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi, sFisTipi, nFirmaIDMuh, nGirisCikis, nStokFisiID, nAlisverisID, nMusteriIDMuh) VALUES('" & dteFaturaTarihi & "', '3', " & lFaturaNo & ", " & drs("lFaturaNo").ToString() & ", " & SonYevmiyeNo & ", (SELECT nHesapID from tbSubeMagazaKdv where (sSubeMagaza = '" & Trim(sSubeMagaza) & "') AND (sHareketTipi = '" & MuhsHareketTipi & "') AND (nSubeMagazaHesapTipi = " & nSubeMagazaHesapTipiKdv & ") AND (sKdvTipi = (select top 1 sKdvTipi from tbKdv where nKdvOrani = " & sorgu_sayi(drs("nKdvOrani5").ToString(), 0) & " Order by sKdvTipi asc))), N'Evrak No:" & drs("lFaturaNo").ToString() & " Perakende Peşin Muhasebe Fişi', 0, 0, 0, " & sorgu_sayi(drs("lKdv5"), 0) & ", '', 0, 'MUH', '" & MuhsHareketTipi & "', 0, 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & Now & "', '', 0, 0, '', 0, 0, 1, '" & Trim(sSubeMagaza) & "', 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & Now & "', '" & Trim(drs("sFisTipi").ToString()) & "', '0', '" & Trim(drs("nGirisCikis").ToString()) & "', '0', '" & Trim(drs("nAlisverisID").ToString()) & "', '" & Trim(drs("nMusteriID").ToString()) & "') ")
                            End If
                            sorgu += sorgu_query("INSERT INTO tbMuhasebeFisi(dteFisTarihi, sMuhFisTipi, lFisno, nEvrakNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi, sFisTipi, nFirmaIDMuh, nGirisCikis, nStokFisiID, nAlisverisID, nMusteriIDMuh) VALUES('" & dteFaturaTarihi & "', '3', " & lFaturaNo & ", " & drs("lFaturaNo").ToString() & ", " & SonYevmiyeNo & ", (SELECT nHesapID from tbSubeMagazaHesaplari where (sSubeMagaza = '" & Trim(sSubeMagaza) & "') AND (sHareketTipi = '" & MuhsHareketTipi & "') AND (nSubeMagazaHesapTipi = " & nSubeMagazaHesapTipi & ")), N'Evrak No:" & drs("lFaturaNo").ToString() & " Perakende Peşin Muhasebe Fişi', 0, 0, 0, " & (sorgu_sayi(drs("lNetTutar"), 0) - sorgu_sayi(drs("KDV"), 0)) & ", '', 0, 'MUH', '" & MuhsHareketTipi & "', 0, 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & Now & "', '', 0, 0, '', 0, 0, 2, '" & Trim(sSubeMagaza) & "', 'Kodu: " & kullaniciKodu & ", Adı: " & kullaniciadi & "', '" & Now & "', '" & Trim(drs("sFisTipi").ToString()) & "', '0', '" & Trim(drs("nGirisCikis").ToString()) & "', '0', '" & Trim(drs("nAlisverisID").ToString()) & "', '" & Trim(drs("nMusteriID").ToString()) & "') ")
                            basarili = True
                            If sec_bHerSatisAyriFis.Checked = True Then
                                sorgu += sorgu_query("INSERT INTO tbMuhasebeFisiAciklamasi(dteFisTarihi, sMuhFisTipi, lFisno, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, bKilitli) VALUES('" & dteFaturaTarihi & "', '3', " & lFaturaNo & ", '" & Trim(txt_sAciklama1.Text) & "', '', '', '', '', 1)")
                                cmd.CommandText = sorgu
                                cmd.ExecuteNonQuery()
                                SonYevmiyeKaydet("3", SonYevmiyeNo)
                            End If
                            PerakendeNotMuhasebelestir(drs("lFaturaNo").ToString(), drs("nAlisverisID").ToString(), "Muhasebeleşti")
                            bas += 5
                        Else
                            bas = -1
                        End If
                    End If
                Catch ex As Exception
                    PerakendeNotMuhasebelestir(drs("lFaturaNo").ToString(), drs("nAlisverisID").ToString(), "")
                End Try
                ProgressBarControl1.PerformStep()
                ProgressBarControl1.Refresh()
            Next
            If Trim(sorgu) <> "" And sec_bHerSatisAyriFis.Checked = False Then
                sorgu += sorgu_query("INSERT INTO tbMuhasebeFisiAciklamasi(dteFisTarihi, sMuhFisTipi, lFisno, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, bKilitli) VALUES('" & dteFaturaTarihi & "', '3', " & lFaturaNo & ", '" & Trim(txt_sAciklama1.Text) & "', '', '', '', '', 1)")
                cmd.CommandText = sorgu
                cmd.ExecuteNonQuery()
            End If
            If bas > 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Perakende Muhasebeleştirme İşlemi Başarılı.", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                SonYevmiyeKaydet("3", SonYevmiyeNo)
                If sec_bHerSatisAyriFis.Checked = False Then
                    analiz_Muhasebe_fis("3", lFaturaNo, dteFaturaTarihi)
                End If
            ElseIf bas = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Perakende Muhasebeleştirme İşlemi Başarısız!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Perakende Muhasebeleştirme İşlemi Başarısız!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        con.Close()
        con.Dispose()
        cmd.Dispose()
        cmd = Nothing
        Return basarili
    End Function
    Private Sub analiz_Muhasebe_fis(ByVal sMuhFisTipi As String, ByVal lFaturaNo As String, ByVal dteFaturaTarihi As String)
        If MuhasebeFisiVarMi(lFaturaNo, sMuhFisTipi) > 0 Then
            Dim frm As New frm_tbMuhasebeFisi
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.dteFisTarihi = dteFaturaTarihi
            frm.lFisNo = lFaturaNo
            frm.bMuhasabe = True
            frm.sMuhFisTipi = sMuhFisTipi
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, "frm_Perakende_MuhasebeFisi_Onizleme") = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara(sec_fistipi.EditValue, txt_dteFisTarihi1.EditValue, txt_dteFisTarihi2.EditValue, txt_lFisNo1.EditValue, txt_lFisNo2.EditValue, txt_lKodu1.Text, txt_lKodu2.Text, sec_bIade.SelectedIndex, sec_bYenile.Checked, 60)
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub sec_bHareketTipi_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bHareketTipi.SelectedIndexChanged
        If sec_bHareketTipi.SelectedIndex = 0 Then
            sec_sHareketTipi.EditValue = ""
            sec_sHareketTipi.Enabled = False
        ElseIf sec_bHareketTipi.SelectedIndex = 1 Then
            sec_sHareketTipi.Enabled = True
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_pdf()
    End Sub
    Private Sub sec_depo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_depo.QueryPopUp
        sec_fistipi.Properties.PopupControl = Nothing
        sec_harekettipi.Properties.PopupControl = Nothing
        sec_depo.Properties.PopupControl = sec_grid
        GridControl2.DataSource = ds_magaza.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_fistipi_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_fistipi.QueryPopUp
        sec_fistipi.Properties.PopupControl = sec_grid
        sec_harekettipi.Properties.PopupControl = Nothing
        sec_depo.Properties.PopupControl = Nothing
        GridControl2.DataSource = ds_fistipi.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_harekettipi_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_harekettipi.QueryPopUp
        sec_fistipi.Properties.PopupControl = Nothing
        sec_harekettipi.Properties.PopupControl = sec_grid
        sec_depo.Properties.PopupControl = Nothing
        GridControl2.DataSource = ds_harekettipi.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_depo_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_depo.QueryResultValue
        Dim s As String = deger(ds_magaza)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Function deger(ByVal ds As DataSet) As String
        Dim dr As DataRow
        Dim s As String = ""
        Dim satir As String = ""
        Dim sayi As Integer = 0
        Dim sayi1 As Integer = 0
        For Each dr In ds.Tables(0).Rows
            If dr("SEC") = True Then
                sayi += 1
            End If
        Next
        For Each dr In ds.Tables(0).Rows
            If dr("SEC") = True Then
                sayi1 += 1
                s += "'" + Trim(dr("KOD")).ToString() + "'"
                satir += Trim(dr("ACIKLAMA"))
                If sayi1 < sayi Then
                    s += ","
                    satir += ","
                End If
            End If
        Next
        sayi1 = Nothing
        sayi = Nothing
        Return s.ToString()
    End Function
    Private Sub ClosePopup()
        If Not sec_grid.OwnerEdit Is Nothing Then
            sec_grid.OwnerEdit.ClosePopup()
        End If
    End Sub
    Private Sub sec_fistipi_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_fistipi.QueryResultValue
        Dim s As String = deger(ds_fistipi)
        If s.ToString() <> "" Then
            e.Value = s.ToString()
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub sec_harekettipi_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_harekettipi.QueryResultValue
        Dim s As String = deger(ds_harekettipi)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub GridView2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        girdi_tutar_hesapla()
    End Sub
    Private Sub girdi_tutar_hesapla()
        Dim dr As DataRow
        If GridView2.RowCount > 0 Then
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            dr.BeginEdit()
            dr.EndEdit()
            GridControl2.Focus()
            GridControl2.Select()
        End If
    End Sub
    Private Sub sec_bIskontoSubeHesabina_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bIskontoSubeHesabina.CheckStateChanged
        If sec_bIskontoSubeHesabina.Checked = False Then
            sec_bIskontoSubeHesabinaKdvHaric.Checked = False
            sec_bIskontoSubeHesabinaKdvHaric.Enabled = False
        ElseIf sec_bIskontoSubeHesabina.Checked = True Then
            sec_bIskontoSubeHesabinaKdvHaric.Enabled = True
        End If
    End Sub
    Private Sub sec_sAciklama1OlsunMu_CheckedChanged(sender As Object, e As EventArgs) Handles sec_sAciklama1OlsunMu.CheckedChanged
        txt_sAciklama1.Enabled = sec_sAciklama1OlsunMu.Checked
        txt_sAciklama1.Text = ""
    End Sub
    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        If GridView1.RowCount > 0 Then
            fatura_Muhasebelestir()
        End If
    End Sub
End Class