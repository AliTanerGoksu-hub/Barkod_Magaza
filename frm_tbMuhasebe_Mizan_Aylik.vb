Imports System.Windows.Forms
Imports DevExpress.XtraExport
Imports DevExpress.XtraGrid.Export
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Wizard
Imports DevExpress.XtraCharts.Design
Imports DevExpress.XtraEditors
Public Class frm_tbMuhasebe_Mizan_Aylik
    Public firmano
    Public donemno
    Public connection
    Public nFirmaID
    Dim nHesapID
    Public sKodu
    Public kullanici
    Public sIslem As String = "Aktif+Pasif"
    Public bGrafikGoster As Boolean = False
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_cari As DataSet
    Public yeni As Boolean = False
    Public bBakiye As Boolean = False
    Dim mevcut_tutar As Decimal = 0
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        dataload(DateEdit1.EditValue, DateEdit2.EditValue)
        GridControl1.Focus()
        GridControl1.Select()
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
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        'mevcut_tutar = dataload_mevcut_mal(tarih1, tarih2)
        Dataload_tbAktif(tarih1, tarih2)
        'Dataload_tbPasif(tarih1, tarih2)
    End Sub
    Public Sub Dataload_tbAktif(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        Try
            ds_tbAktif.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If sec_detay.Text = "Ozet" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT DISTINCT SUBSTRING(tbHesapPlani.sKodu, 1, 3) AS sKodu, tbtempKebir.sAciklamakebir AS sAciklama, SUM(tbMuhasebeFisi.lBorcTutar) AS lBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lAlacakTutar, SUM(tbMuhasebeFisi.lGirenMiktar) AS lGirenMiktar, SUM(tbMuhasebeFisi.lCikanMiktar) AS lCikanMiktar, lBorcBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) > 0 THEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) ELSE 0 END, lAlacakBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) < 0 THEN SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) ELSE 0 END, 0 AS lGirenBakiye, 0 AS lCikanBakiye FROM (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamaGrup1 FROM tbHesapPlani) tbtempGrup1 RIGHT OUTER JOIN tbHesapPlani INNER JOIN tbMuhasebeFisi INNER JOIN (SELECT tbHesapplani.nHesapId, SUM(lBorcTutar) - SUM(lalacaktutar) AS lbakiyeTutar, SUM(lgirenMiktar) - SUM(lCikanMiktar) AS lbakiyeMiktar FROM tbMuhasebeFisi, tbHesapPlani WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY tbHesapplani.nHesapID) Bakiye ON Bakiye.nHesapId = tbMuhasebeFisi.nHesapID ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID LEFT OUTER JOIN (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamakebir FROM tbHesapPlani) tbtempKebir ON tbtempKebir.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 3) ON tbtempGrup1.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 7) AND LEN(tbHesapPlani.sKodu) >= 7 WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbMuhasebeFisi.sHangiUygulama = 'MUH')  GROUP BY SUBSTRING(tbHesapPlani.sKodu, 1, 3), tbtempKebir.sAciklamakebir, tbtempGrup1.sAciklamaGrup1 HAVING (ABS(SUM(tbMuhasebeFisi.lBorcTutar) - SUM(tbMuhasebeFisi.lAlacakTutar)) BETWEEN 0 AND 99999999999999999) ORDER BY SUBSTRING(tbHesapPlani.sKodu, 1, 3)")
            collBorcTutar.SummaryItem.FieldName = "lBorcTutar"
            collAlacakTutar.SummaryItem.FieldName = "lAlacakTutar"
            collBorcBakiye.SummaryItem.FieldName = "lBorcBakiye"
            collAlacakBakiye.SummaryItem.FieldName = "lAlacakBakiye"
        ElseIf sec_detay.Text = "Detayli" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT * FROM (SELECT DISTINCT SUBSTRING(tbHesapPlani.sKodu, 1, 3) AS sKodu, tbtempKebir.sAciklamakebir AS sAciklama, SUM(tbMuhasebeFisi.lBorcTutar) AS lBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lAlacakTutar, SUM(tbMuhasebeFisi.lGirenMiktar) AS lGirenMiktar, SUM(tbMuhasebeFisi.lCikanMiktar) AS lCikanMiktar, lBorcBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) > 0 THEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) ELSE 0 END, lAlacakBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) < 0 THEN SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) ELSE 0 END, 0 AS lGirenBakiye, 0 AS lCikanBakiye, 1 AS nDurum,SUM(tbMuhasebeFisi.lBorcTutar) AS lToplamBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lToplamAlacakTutar,lToplamBorcBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) > 0 THEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) ELSE 0 END, lToplamAlacakBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) < 0 THEN SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) ELSE 0 END, 0 AS lToplamGirenBakiye, 0 AS lToplamCikanBakiye FROM (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamaGrup1 FROM tbHesapPlani) tbtempGrup1 RIGHT OUTER JOIN tbHesapPlani INNER JOIN tbMuhasebeFisi INNER JOIN (SELECT tbHesapplani.nHesapId, SUM(lBorcTutar) - SUM(lalacaktutar) AS lbakiyeTutar, SUM(lgirenMiktar) - SUM(lCikanMiktar) AS lbakiyeMiktar FROM tbMuhasebeFisi, tbHesapPlani WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY tbHesapplani.nHesapID) Bakiye ON Bakiye.nHesapId = tbMuhasebeFisi.nHesapID ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID LEFT OUTER JOIN (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamakebir FROM tbHesapPlani) tbtempKebir ON tbtempKebir.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 3) ON tbtempGrup1.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 7) AND LEN(tbHesapPlani.sKodu) >= 7 WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbMuhasebeFisi.sHangiUygulama = 'MUH')  GROUP BY SUBSTRING(tbHesapPlani.sKodu, 1, 3), tbtempKebir.sAciklamakebir, tbtempGrup1.sAciklamaGrup1 HAVING (ABS(SUM(tbMuhasebeFisi.lBorcTutar) - SUM(tbMuhasebeFisi.lAlacakTutar)) BETWEEN 0 AND 99999999999999999) UNION ALL SELECT DISTINCT tbHesapPlani.sKodu AS sKodu, tbHesapPlani.sAciklama, SUM(tbMuhasebeFisi.lBorcTutar) AS lBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lAlacakTutar, SUM(tbMuhasebeFisi.lGirenMiktar) AS lGirenMiktar, SUM(tbMuhasebeFisi.lCikanMiktar) AS lCikanMiktar, lBorcBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) > 0 THEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) ELSE 0 END, lAlacakBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) < 0 THEN SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) ELSE 0 END, 0 AS lGirenBakiye, 0 AS lCikanBakiye, 2 AS nDurum,0 as lToplamBorcTutar, 0 as lToplamAlacakTutar,0 as lToplamBorcBakiye,0 as lToplamAlacakBakiye,0 as lToplamGirenBakiye,0 as lToplamCikanBakiye FROM (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamakebir FROM tbHesapPlani) tbtempKebir RIGHT OUTER JOIN tbHesapPlani INNER JOIN tbMuhasebeFisi INNER JOIN (SELECT tbHesapplani.nHesapId, SUM(lBorcTutar) - SUM(lalacaktutar) AS lbakiyeTutar, SUM(lgirenMiktar) - SUM(lCikanMiktar) AS lbakiyeMiktar FROM tbMuhasebeFisi, tbHesapPlani WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY tbHesapplani.nHesapID) Bakiye ON Bakiye.nHesapId = tbMuhasebeFisi.nHesapID ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID LEFT OUTER JOIN (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamaGrup1 FROM tbHesapPlani) tbtempGrup1 ON SUBSTRING(tbHesapPlani.sKodu, 1, 7) = tbtempGrup1.sKodu AND LEN(tbHesapPlani.sKodu) >= 7 ON tbtempKebir.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 3) WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbMuhasebeFisi.sHangiUygulama = 'MUH')  GROUP BY tbtempKebir.sKodu, Bakiye.lbakiyeTutar, Bakiye.lbakiyeMiktar, SUBSTRING(tbHesapPlani.sKodu, 1, 3), SUBSTRING(tbHesapPlani.sKodu, 1, 7), tbHesapPlani.sKodu, tbHesapPlani.sAciklama, tbtempKebir.sAciklamakebir, tbtempGrup1.sAciklamaGrup1 HAVING (ABS(SUM(tbMuhasebeFisi.lBorcTutar) - SUM(tbMuhasebeFisi.lAlacakTutar)) BETWEEN 0 AND 99999999999999999)) tbMizan ORDER BY sKodu")
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT DISTINCT tbHesapPlani.sKodu AS sKodu, SUBSTRING(tbHesapPlani.sKodu, 1, 3) AS sHesap1, SUBSTRING(tbHesapPlani.sKodu, 1, 7) AS sHesap2, tbHesapPlani.sAciklama, tbtempKebir.sAciklamakebir, SUM(tbMuhasebeFisi.lBorcTutar) AS lBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lAlacakTutar, SUM(tbMuhasebeFisi.lGirenMiktar) AS lGirenMiktar, SUM(tbMuhasebeFisi.lCikanMiktar) AS lCikanMiktar,lBorcBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) > 0 THEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) ELSE 0 END, lAlacakBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) < 0 THEN SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) ELSE 0 END, 0 AS lGirenBakiye, 0 AS lCikanBakiye FROM (SELECT sKodu AS sKodu , tbHesapPlani.sAciklama AS sAciklamakebir FROM tbHesapPlani) tbtempKebir RIGHT OUTER JOIN tbHesapPlani INNER JOIN tbMuhasebeFisi INNER JOIN (SELECT tbHesapplani.nHesapId , SUM(lBorcTutar) - SUM(lalacaktutar) AS lbakiyeTutar , SUM(lgirenMiktar) - SUM(lCikanMiktar) AS lbakiyeMiktar FROM tbMuhasebeFisi , tbHesapPlani WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY tbHesapplani.nHesapID) Bakiye ON Bakiye.nHesapId = tbMuhasebeFisi.nHesapID ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID LEFT OUTER JOIN (SELECT sKodu AS sKodu , tbHesapPlani.sAciklama AS sAciklamaGrup1 FROM tbHesapPlani) tbtempGrup1 ON SUBSTRING(tbHesapPlani.sKodu, 1, 7) = tbtempGrup1.sKodu AND LEN(tbHesapPlani.sKodu) >= 7 ON tbtempKebir.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 3) WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbMuhasebeFisi.sHangiUygulama = 'MUH')  GROUP BY tbtempKebir.sKodu, Bakiye.lbakiyeTutar, Bakiye.lbakiyeMiktar, SUBSTRING(tbHesapPlani.sKodu, 1, 3), SUBSTRING(tbHesapPlani.sKodu, 1, 7), tbHesapPlani.sKodu, tbHesapPlani.sAciklama, tbtempKebir.sAciklamakebir, tbtempGrup1.sAciklamaGrup1 HAVING (ABS(SUM(tbMuhasebeFisi.lBorcTutar) - SUM(tbMuhasebeFisi.lAlacakTutar)) BETWEEN 0 AND 99999999999999999) ORDER BY SUBSTRING(tbHesapPlani.sKodu, 1, 3), SUBSTRING(tbHesapPlani.sKodu, 1, 7), tbHesapPlani.sKodu, tbHesapPlani.sAciklama")
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbBilancoGelirTablosuHesaplari.sHesap2, tbBilancoGelirTablosuHesaplari.sHesap3, tbBilancoGelirTablosuHesaplari.sAciklamaTR, tbBilancoGelirTablosuHesaplari.sAciklamaEN,tbBilancoGelirTablosuHesaplari.sAciklamaAR, ISNULL(tempBilancoAktif.Onceki, 0) AS Onceki, ISNULL(tempBilancoAktif.Simdiki, 0) AS Simdiki, tbBilancoGelirTablosuHesaplari.bFormulMu, tbBilancoGelirTablosuHesaplari.sHesapSirasi, tbBilancoGelirTablosuHesaplari.nDurum FROM tbBilancoGelirTablosuHesaplari LEFT OUTER JOIN (SELECT HesapKodu, SUM(Simdiki) AS Simdiki, SUM(Onceki) AS Onceki FROM (SELECT substring(tbHesapPlani.sKodu, 1, 2) AS HesapKodu, SUM((tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar)) AS Simdiki, 0 AS Onceki FROM tbHesapPlani, tbMuhasebeFisi WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbHesapPlani.sKodu, 1, 2) UNION SELECT substring(tbHesapPlani.sKodu, 1, 3) AS HesapKodu, SUM((tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar)) AS Simdiki, 0 AS Onceki FROM tbHesapPlani, tbMuhasebeFisi WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbHesapPlani.sKodu, 1, 3) UNION SELECT substring(tbHesapPlani.sKodu, 1, 1) AS HesapKodu, SUM((tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar)) AS Simdiki, 0 AS Onceki FROM tbHesapPlani, tbMuhasebeFisi WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbHesapPlani.sKodu, 1, 1)) AS tempBilanco GROUP BY HesapKodu) tempBilancoAktif ON tempBilancoAktif.HesapKodu = tbBilancoGelirTablosuHesaplari.sHesap3 WHERE (tbBilancoGelirTablosuHesaplari.nRaporTipi = 1) AND (tbBilancoGelirTablosuHesaplari.bAktifMi = 1) UNION ALL SELECT SUBSTRING(tbHesapPlani.sKodu , 1 , 2) AS sHesap2 , SUBSTRING(tbHesapPlani.sKodu , 1 , 20) AS sHesap3 , tbHesapPlani.sAciklama AS sAciklamaTR , '' AS sAciklamaEN , tbHesapPlani.sAlterneAciklama as sAciklamaAR,SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) AS Onceki , 0 AS Simdiki , 0 AS bFormulMu , tbHesapPlani.sKodu AS sHesapSirasi , 3 AS nDurum FROM tbHesapPlani INNER JOIN tbMuhasebeFisi ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID WHERE (SUBSTRING(tbHesapPlani.sKodu , 1 , 1) < '3') AND tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY tbHesapPlani.sKodu , tbHesapPlani.sAciklama,tbHesapPlani.sAlterneAciklama ) TempBilanco ORDER BY sHesapSirasi")
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbBilancoGelirTablosuHesaplari.sHesap2 , tbBilancoGelirTablosuHesaplari.sHesap3 , tbBilancoGelirTablosuHesaplari.sAciklamaTR , tbBilancoGelirTablosuHesaplari.sAciklamaEN,tbBilancoGelirTablosuHesaplari.sAciklamaAR , ISNULL(tempBilancoAktif.Onceki , 0) AS Onceki , ISNULL(tempBilancoAktif.Simdiki , 0) AS Simdiki , tbBilancoGelirTablosuHesaplari.bFormulMu , tbBilancoGelirTablosuHesaplari.sHesapSirasi , tbBilancoGelirTablosuHesaplari.nDurum FROM tbBilancoGelirTablosuHesaplari LEFT OUTER JOIN (SELECT HesapKodu , SUM(Simdiki) AS Simdiki , SUM(Onceki) AS Onceki FROM (SELECT substring(tbFirma.sKodu , 1 , 2) AS HesapKodu , SUM((tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar)) AS Simdiki , 0 AS Onceki FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbFirma.sKodu , 1 , 2) UNION SELECT substring(tbFirma.sKodu , 1 , 3) AS HesapKodu , SUM((tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar)) AS Simdiki , 0 AS Onceki FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbFirma.sKodu , 1 , 3) UNION SELECT substring(tbFirma.sKodu , 1 , 1) AS HesapKodu , SUM((tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar)) AS Simdiki , 0 AS Onceki FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbFirma.sKodu , 1 , 1)) AS tempBilanco GROUP BY HesapKodu) tempBilancoAktif ON tempBilancoAktif.HesapKodu = tbBilancoGelirTablosuHesaplari.sHesap3 WHERE (tbBilancoGelirTablosuHesaplari.nRaporTipi = 1) AND (tbBilancoGelirTablosuHesaplari.bAktifMi = 1) UNION ALL SELECT SUBSTRING(tbFirma.sKodu , 1 , 2) AS sHesap2 , SUBSTRING(tbFirma.sKodu , 1 , 20) AS sHesap3 , tbFirma.sAciklama AS sAciklamaTR , '' AS sAciklamaEN , tbFirma.sOzelNot as sAciklamaAR,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Onceki , 0 AS Simdiki , 0 AS bFormulMu , tbFirma.sKodu AS sHesapSirasi , 3 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (SUBSTRING(tbFirma.sKodu , 1 , 1) < '3') AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY tbFirma.sKodu , tbFirma.sAciklama,tbFirma.sOzelNot) TempBilanco ORDER BY sHesapSirasi")
            collBorcTutar.SummaryItem.FieldName = "lToplamBorcTutar"
            collAlacakTutar.SummaryItem.FieldName = "lToplamAlacakTutar"
            collBorcBakiye.SummaryItem.FieldName = "lToplamBorcBakiye"
            collAlacakBakiye.SummaryItem.FieldName = "lToplamAlacakBakiye"
        End If
        If sec_bakiye.Text = "Mizan" Then
            col01_lAlacakBakiye.Visible = True
            col01_lBorcBakiye.Visible = True
            col01_lBakiye.Visible = True
            col01_lBakiye.Caption = "OcakBakiye"
            col02_lAlacakBakiye.Visible = True
            col02_lBorcBakiye.Visible = True
            col02_lBakiye.Visible = True
            col02_lBakiye.Caption = "SubatBakiye"
            col03_lAlacakBakiye.Visible = True
            col03_lBorcBakiye.Visible = True
            col03_lBakiye.Visible = True
            col03_lBakiye.Caption = "MartBakiye"
            col04_lAlacakBakiye.Visible = True
            col04_lBorcBakiye.Visible = True
            col04_lBakiye.Visible = True
            col04_lBakiye.Caption = "NisanBakiye"
            col05_lAlacakBakiye.Visible = True
            col05_lBorcBakiye.Visible = True
            col05_lBakiye.Visible = True
            col05_lBakiye.Caption = "MayisBakiye"
            col06_lAlacakBakiye.Visible = True
            col06_lBorcBakiye.Visible = True
            col06_lBakiye.Visible = True
            col06_lBakiye.Caption = "HaziranBakiye"
            col07_lAlacakBakiye.Visible = True
            col07_lBorcBakiye.Visible = True
            col07_lBakiye.Visible = True
            col07_lBakiye.Caption = "TemmuzBakiye"
            col08_lAlacakBakiye.Visible = True
            col08_lBorcBakiye.Visible = True
            col08_lBakiye.Visible = True
            col08_lBakiye.Caption = "AgustosBakiye"
            col09_lAlacakBakiye.Visible = True
            col09_lBorcBakiye.Visible = True
            col09_lBakiye.Visible = True
            col09_lBakiye.Caption = "EylulBakiye"
            col10_lAlacakBakiye.Visible = True
            col10_lBorcBakiye.Visible = True
            col10_lBakiye.Visible = True
            col10_lBakiye.Caption = "EkimBakiye"
            col11_lAlacakBakiye.Visible = True
            col11_lBorcBakiye.Visible = True
            col11_lBakiye.Visible = True
            col11_lBakiye.Caption = "KasimBakiye"
            col12_lAlacakBakiye.Visible = True
            col12_lBorcBakiye.Visible = True
            col12_lBakiye.Visible = True
            col12_lBakiye.Caption = "AralikBakiye"
        ElseIf sec_bakiye.Text = "Bakiye" Then
            col01_lAlacakBakiye.Visible = False
            col01_lBorcBakiye.Visible = False
            col01_lBakiye.Visible = True
            col01_lBakiye.Caption = "Ocak"
            col02_lAlacakBakiye.Visible = False
            col02_lBorcBakiye.Visible = False
            col02_lBakiye.Visible = True
            col02_lBakiye.Caption = "Subat"
            col03_lAlacakBakiye.Visible = False
            col03_lBorcBakiye.Visible = False
            col03_lBakiye.Visible = True
            col03_lBakiye.Caption = "Mart"
            col04_lAlacakBakiye.Visible = False
            col04_lBorcBakiye.Visible = False
            col04_lBakiye.Visible = True
            col04_lBakiye.Caption = "Nisan"
            col05_lAlacakBakiye.Visible = False
            col05_lBorcBakiye.Visible = False
            col05_lBakiye.Visible = True
            col05_lBakiye.Caption = "Mayis"
            col06_lAlacakBakiye.Visible = False
            col06_lBorcBakiye.Visible = False
            col06_lBakiye.Visible = True
            col06_lBakiye.Caption = "Haziran"
            col07_lAlacakBakiye.Visible = False
            col07_lBorcBakiye.Visible = False
            col07_lBakiye.Visible = True
            col07_lBakiye.Caption = "Temmuz"
            col08_lAlacakBakiye.Visible = False
            col08_lBorcBakiye.Visible = False
            col08_lBakiye.Visible = True
            col08_lBakiye.Caption = "Agustos"
            col09_lAlacakBakiye.Visible = False
            col09_lBorcBakiye.Visible = False
            col09_lBakiye.Visible = True
            col09_lBakiye.Caption = "Eylul"
            col10_lAlacakBakiye.Visible = False
            col10_lBorcBakiye.Visible = False
            col10_lBakiye.Visible = True
            col11_lBakiye.Caption = "Ekim"
            col11_lAlacakBakiye.Visible = False
            col11_lBorcBakiye.Visible = False
            col11_lBakiye.Visible = True
            col11_lBakiye.Caption = "Kasim"
            col12_lAlacakBakiye.Visible = False
            col12_lBorcBakiye.Visible = False
            col12_lBakiye.Visible = True
            col12_lBakiye.Caption = "Aralik"
        End If
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbAktif, "Table1")
        conn.Close()
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim s0 As String = ""
        Dim s1 As String = ""
        Dim s2 As Integer = 0
        Dim s4 As String = ""
        Dim lKarZarar As Decimal = 0
        Dim ds_tbAylik As New DataSet
        For Each dr In ds_tbAktif.Tables(0).Rows
            ds_tbAylik = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy  SELECT DISTINCT CONVERT (char(7), tbMuhasebeFisi.dteFisTarihi, 111) AS Ay, SUM(ISNULL(tbMuhasebeFisi.lBorcTutar, 0)) AS lBorcTutar, SUM(ISNULL(tbMuhasebeFisi.lAlacakTutar, 0)) AS lAlacakTutar, SUM(ISNULL(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar, 0)) AS lBakiye FROM tbHesapPlani INNER JOIN tbMuhasebeFisi ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID WHERE (tbHesapPlani.sKodu <> '') AND (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbMuhasebeFisi.sHangiUygulama = 'MUH')  AND (tbHesapPlani.sKodu LIKE '" & Trim(dr("sKodu")) & "%') GROUP BY CONVERT (char(7), tbMuhasebeFisi.dteFisTarihi, 111)"))
            For Each dr1 In ds_tbAylik.Tables(0).Rows
                If dr1("Ay") = Year(tarih1) & "/" & "01" Then
                    dr("01_lBorcBakiye") = dr1("lBorcTutar")
                    dr("01_lAlacakBakiye") = dr1("lAlacakTutar")
                    dr("01_lBakiye") = dr1("lBakiye")
                ElseIf dr1("Ay") = Year(tarih1) & "/" & "02" Then
                    dr("02_lBorcBakiye") = dr1("lBorcTutar")
                    dr("02_lAlacakBakiye") = dr1("lAlacakTutar")
                    dr("02_lBakiye") = dr1("lBakiye")
                ElseIf dr1("Ay") = Year(tarih1) & "/" & "03" Then
                    dr("03_lBorcBakiye") = dr1("lBorcTutar")
                    dr("03_lAlacakBakiye") = dr1("lAlacakTutar")
                    dr("03_lBakiye") = dr1("lBakiye")
                ElseIf dr1("Ay") = Year(tarih1) & "/" & "04" Then
                    dr("04_lBorcBakiye") = dr1("lBorcTutar")
                    dr("04_lAlacakBakiye") = dr1("lAlacakTutar")
                    dr("04_lBakiye") = dr1("lBakiye")
                ElseIf dr1("Ay") = Year(tarih1) & "/" & "05" Then
                    dr("05_lBorcBakiye") = dr1("lBorcTutar")
                    dr("05_lAlacakBakiye") = dr1("lAlacakTutar")
                    dr("05_lBakiye") = dr1("lBakiye")
                ElseIf dr1("Ay") = Year(tarih1) & "/" & "06" Then
                    dr("06_lBorcBakiye") = dr1("lBorcTutar")
                    dr("06_lAlacakBakiye") = dr1("lAlacakTutar")
                    dr("06_lBakiye") = dr1("lBakiye")
                ElseIf dr1("Ay") = Year(tarih1) & "/" & "07" Then
                    dr("07_lBorcBakiye") = dr1("lBorcTutar")
                    dr("07_lAlacakBakiye") = dr1("lAlacakTutar")
                    dr("07_lBakiye") = dr1("lBakiye")
                ElseIf dr1("Ay") = Year(tarih1) & "/" & "08" Then
                    dr("08_lBorcBakiye") = dr1("lBorcTutar")
                    dr("08_lAlacakBakiye") = dr1("lAlacakTutar")
                    dr("08_lBakiye") = dr1("lBakiye")
                ElseIf dr1("Ay") = Year(tarih1) & "/" & "09" Then
                    dr("09_lBorcBakiye") = dr1("lBorcTutar")
                    dr("09_lAlacakBakiye") = dr1("lAlacakTutar")
                    dr("09_lBakiye") = dr1("lBakiye")
                ElseIf dr1("Ay") = Year(tarih1) & "/" & "10" Then
                    dr("10_lBorcBakiye") = dr1("lBorcTutar")
                    dr("10_lAlacakBakiye") = dr1("lAlacakTutar")
                    dr("10_lBakiye") = dr1("lBakiye")
                ElseIf dr1("Ay") = Year(tarih1) & "/" & "11" Then
                    dr("11_lBorcBakiye") = dr1("lBorcTutar")
                    dr("11_lAlacakBakiye") = dr1("lAlacakTutar")
                    dr("11_lBakiye") = dr1("lBakiye")
                ElseIf dr1("Ay") = Year(tarih1) & "/" & "12" Then
                    dr("12_lBorcBakiye") = dr1("lBorcTutar")
                    dr("12_lAlacakBakiye") = dr1("lAlacakTutar")
                    dr("12_lBakiye") = dr1("lBakiye")
                End If
            Next
        Next
        s0 = Nothing
        s1 = Nothing
        s2 = Nothing
        s4 = Nothing
    End Sub
    Private Sub frm_tbBilanco_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        DateEdit1.EditValue = "01/01/" & Year(dteSistemTarihi)
        DateEdit2.EditValue = "31/12/" & Year(dteSistemTarihi)
        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        DateEdit1.Focus()
        DateEdit1.Select()
    End Sub
    Private Function dataload_mevcut_mal(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime) As Decimal
        Dim ds1 As DataSet
        Dim tutar As Decimal = 0
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '0' AS IND, 'Envanter' AS Baslik, 'Mevcut Mal Tutarı' AS Aciklama, COUNT(DISTINCT nStokID) AS Sayi, SUM(Mevcut) AS Miktar, SUM(Mevcut * Maliyet) AS Tutar FROM (SELECT Stok.nStokID , (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID AND tbStokFisiDetayi.dteIslemTarihi <= '" & tarih2 & "') AS Mevcut , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyatM & "')) AS Maliyet FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID INNER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk WHERE (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID AND tbStokFisiDetayi.dteIslemTarihi <= '" & tarih2 & "') > 0) t"))
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            'dr = DataSet1.Tables(0).NewRow
            'dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            'dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = sorgu_sayi(dr1("Miktar"), 0)
            'dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            'dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            tutar = sorgu_sayi(dr1("Tutar"), 0)
            'DataSet1.Tables(0).Rows.Add(dr)
        Next
        Return tutar
    End Function
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        raporla_excel()
    End Sub
    Private Sub raporla_excel()
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Bilanço Aktiflerine Excel Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                SaveFileDialog1.Filter = "Excel Dosyaları(*.xls) |*.xls"
                SaveFileDialog1.InitialDirectory = "c:\"
                SaveFileDialog1.FileName = "BilançoAktif.xls"
                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                End If
            End If
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            If XtraMessageBox.Show(Sorgu_sDil("Bilanço Pasiflerine Excel Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                SaveFileDialog1.Filter = "Excel Dosyaları(*.xls) |*.xls"
                SaveFileDialog1.InitialDirectory = "c:\"
                SaveFileDialog1.FileName = "BilançoPasif.xls"
                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                End If
            End If
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
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gorunum_yazdir()
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
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        LabelControl1.Text = Sorgu_sDil(LabelControl1.Text, sDil)
        LabelControl2.Text = Sorgu_sDil(LabelControl2.Text, sDil)
        LabelControl3.Text = Sorgu_sDil(LabelControl3.Text, sDil)
        LabelControl5.Text = Sorgu_sDil(LabelControl5.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Sub gorunum_yazdir()
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            Dim kriter As String = ""
            kriter += DateEdit1.EditValue & " ve " & DateEdit2.EditValue & Sorgu_sDil(" Tarihleri Arasındaki Aylık Mizan", sDil) & vbCrLf
            printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Muhasebe Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
            printlink1.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            printlink2.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        End If
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_pdf()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If GridView1.RowCount > 0 Then
            If bGrafikGoster = True Then
                DataSet1.Tables(0).Rows.Clear()
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                DataSet1 = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy  SELECT DISTINCT DATENAME(MONTH, tbMuhasebeFisi.dteFisTarihi) AS sAciklama,CONVERT (char(7), tbMuhasebeFisi.dteFisTarihi, 111) AS Ay, SUM(ISNULL(tbMuhasebeFisi.lBorcTutar, 0)) AS lBorcTutar, SUM(ISNULL(tbMuhasebeFisi.lAlacakTutar, 0)) AS lAlacakTutar, SUM(ISNULL(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar, 0)) AS lBakiye FROM tbHesapPlani INNER JOIN tbMuhasebeFisi ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID WHERE (tbHesapPlani.sKodu <> '') AND (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & DateEdit1.EditValue & "' AND '" & DateEdit2.EditValue & "') AND (tbHesapPlani.sKodu LIKE '" & Trim(dr("sKodu")) & "%') GROUP BY DATENAME(MONTH, tbMuhasebeFisi.dteFisTarihi),CONVERT (char(7), tbMuhasebeFisi.dteFisTarihi, 111)"))
                ChartControl1.DataSource = DataSet1.Tables(0)
                ChartControl1.Refresh()
                ChartControl1.Series.Item(0).DataSource = DataSet1.Tables(0)
                ChartControl1.Series.Item(1).DataSource = DataSet1.Tables(0)
                ChartControl1.Titles.Clear()
                Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle
                ChartTitle1.Text = dr("sAciklama")
                Me.ChartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
            End If
        End If
    End Sub

    Private Sub SimpleButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        degistir_grafik()
    End Sub
    Private Sub degistir_grafik()
        ' Create a chart.
        'Dim Chart As New ChartControl
        ' Set its datasource.
        ' Note that you can also set any other specific options for the chart here.
        'Chart.DataSource = DataSet1.Tables(0)
        ' Run the chart's wizard.
        'ChartControl1.SeriesTemplate.ChangeView(ViewType.Pie)
        'ChartWizard.Run(Me.ChartControl1, Nothing, True)
        Dim chartWizard_Renamed As ChartWizard = New ChartWizard(Me.ChartControl1)
        chartWizard_Renamed.ShowDialog()
        If TypeOf ChartControl1.Series(0).View Is SeriesViewColorEachSupportBase Then
            chColorEach.Enabled = True
            chColorEach.Checked = CType(ChartControl1.Series(0).View, SeriesViewColorEachSupportBase).ColorEach
        ElseIf TypeOf ChartControl1.Series(0).View Is SeriesView3DColorEachSupportBase Then
            chColorEach.Enabled = True
            chColorEach.Checked = CType(ChartControl1.Series(0).View, SeriesView3DColorEachSupportBase).ColorEach
        Else
            ChartControl1.Series(0).Label.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            chColorEach.Enabled = False
            chColorEach.Checked = False
        End If
        ' Create a form, add the chart to it, and display the form.
        'Dim Form1 As New Form
        'Form1.Controls.Add(Chart)
        'Form1.Show()
    End Sub
End Class