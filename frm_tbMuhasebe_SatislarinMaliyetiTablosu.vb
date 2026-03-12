Imports DevExpress.XtraEditors
Public Class frm_tbMuhasebe_SatislarinMaliyetiTablosu
    Public firmano
    Public donemno
    Public connection
    Public nFirmaID
    Dim nHesapID
    Public sKodu
    Public kullanici
    Public sIslem As String = "Aktif+Pasif"
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
        'Dataload_tbAktif(tarih1, tarih2)
        Dataload_tbPasif(tarih1, tarih2)
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
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT tbBilancoGelirTablosuHesaplari.sHesap2, tbBilancoGelirTablosuHesaplari.sHesap3, tbBilancoGelirTablosuHesaplari.sAciklamaTR, tbBilancoGelirTablosuHesaplari.sAciklamaEN,tbBilancoGelirTablosuHesaplari.sAciklamaAR, ISNULL(tempBilancoAktif.Onceki, 0) AS Onceki, ISNULL(tempBilancoAktif.Simdiki, 0) AS Simdiki, tbBilancoGelirTablosuHesaplari.bFormulMu, tbBilancoGelirTablosuHesaplari.sHesapSirasi, tbBilancoGelirTablosuHesaplari.nDurum FROM tbBilancoGelirTablosuHesaplari LEFT OUTER JOIN (SELECT HesapKodu, SUM(Simdiki) AS Simdiki, SUM(Onceki) AS Onceki FROM (SELECT substring(tbHesapPlani.sKodu, 1, 2) AS HesapKodu, SUM((tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar)) AS Simdiki, 0 AS Onceki FROM tbHesapPlani, tbMuhasebeFisi WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND (tbMuhasebeFisi.sHangiUygulama = 'MUH')  GROUP BY substring(tbHesapPlani.sKodu, 1, 2) UNION SELECT substring(tbHesapPlani.sKodu, 1, 3) AS HesapKodu, SUM((tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar)) AS Simdiki, 0 AS Onceki FROM tbHesapPlani, tbMuhasebeFisi WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND (tbMuhasebeFisi.sHangiUygulama = 'MUH')  GROUP BY substring(tbHesapPlani.sKodu, 1, 3) UNION SELECT substring(tbHesapPlani.sKodu, 1, 1) AS HesapKodu, SUM((tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar)) AS Simdiki, 0 AS Onceki FROM tbHesapPlani, tbMuhasebeFisi WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND (tbMuhasebeFisi.sHangiUygulama = 'MUH')  GROUP BY substring(tbHesapPlani.sKodu, 1, 1)) AS tempBilanco GROUP BY HesapKodu) tempBilancoAktif ON tempBilancoAktif.HesapKodu = tbBilancoGelirTablosuHesaplari.sHesap3 WHERE (tbBilancoGelirTablosuHesaplari.nRaporTipi = 1) AND (tbBilancoGelirTablosuHesaplari.bAktifMi = 1) ORDER BY tbBilancoGelirTablosuHesaplari.sHesapSirasi")
        ElseIf sec_detay.Text = "Detayli" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbBilancoGelirTablosuHesaplari.sHesap2, tbBilancoGelirTablosuHesaplari.sHesap3, tbBilancoGelirTablosuHesaplari.sAciklamaTR, tbBilancoGelirTablosuHesaplari.sAciklamaEN,tbBilancoGelirTablosuHesaplari.sAciklamaAR, ISNULL(tempBilancoAktif.Onceki, 0) AS Onceki, ISNULL(tempBilancoAktif.Simdiki, 0) AS Simdiki, tbBilancoGelirTablosuHesaplari.bFormulMu, tbBilancoGelirTablosuHesaplari.sHesapSirasi, tbBilancoGelirTablosuHesaplari.nDurum FROM tbBilancoGelirTablosuHesaplari LEFT OUTER JOIN (SELECT HesapKodu, SUM(Simdiki) AS Simdiki, SUM(Onceki) AS Onceki FROM (SELECT substring(tbHesapPlani.sKodu, 1, 2) AS HesapKodu, SUM((tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar)) AS Simdiki, 0 AS Onceki FROM tbHesapPlani, tbMuhasebeFisi WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND (tbMuhasebeFisi.sHangiUygulama = 'MUH')  GROUP BY substring(tbHesapPlani.sKodu, 1, 2) UNION SELECT substring(tbHesapPlani.sKodu, 1, 3) AS HesapKodu, SUM((tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar)) AS Simdiki, 0 AS Onceki FROM tbHesapPlani, tbMuhasebeFisi WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND (tbMuhasebeFisi.sHangiUygulama = 'MUH')  GROUP BY substring(tbHesapPlani.sKodu, 1, 3) UNION SELECT substring(tbHesapPlani.sKodu, 1, 1) AS HesapKodu, SUM((tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar)) AS Simdiki, 0 AS Onceki FROM tbHesapPlani, tbMuhasebeFisi WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND (tbMuhasebeFisi.sHangiUygulama = 'MUH')  GROUP BY substring(tbHesapPlani.sKodu, 1, 1)) AS tempBilanco GROUP BY HesapKodu) tempBilancoAktif ON tempBilancoAktif.HesapKodu = tbBilancoGelirTablosuHesaplari.sHesap3 WHERE (tbBilancoGelirTablosuHesaplari.nRaporTipi = 1) AND (tbBilancoGelirTablosuHesaplari.bAktifMi = 1) UNION ALL SELECT SUBSTRING(tbHesapPlani.sKodu , 1 , 2) AS sHesap2 , SUBSTRING(tbHesapPlani.sKodu , 1 , 20) AS sHesap3 , tbHesapPlani.sAciklama AS sAciklamaTR , '' AS sAciklamaEN , tbHesapPlani.sAlterneAciklama as sAciklamaAR,SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) AS Onceki , 0 AS Simdiki , 0 AS bFormulMu , tbHesapPlani.sKodu AS sHesapSirasi , 3 AS nDurum FROM tbHesapPlani INNER JOIN tbMuhasebeFisi ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID WHERE (SUBSTRING(tbHesapPlani.sKodu , 1 , 1) < '3') AND tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND (tbMuhasebeFisi.sHangiUygulama = 'MUH')  GROUP BY tbHesapPlani.sKodu , tbHesapPlani.sAciklama,tbHesapPlani.sAlterneAciklama ) TempBilanco ORDER BY sHesapSirasi")
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbBilancoGelirTablosuHesaplari.sHesap2 , tbBilancoGelirTablosuHesaplari.sHesap3 , tbBilancoGelirTablosuHesaplari.sAciklamaTR , tbBilancoGelirTablosuHesaplari.sAciklamaEN,tbBilancoGelirTablosuHesaplari.sAciklamaAR , ISNULL(tempBilancoAktif.Onceki , 0) AS Onceki , ISNULL(tempBilancoAktif.Simdiki , 0) AS Simdiki , tbBilancoGelirTablosuHesaplari.bFormulMu , tbBilancoGelirTablosuHesaplari.sHesapSirasi , tbBilancoGelirTablosuHesaplari.nDurum FROM tbBilancoGelirTablosuHesaplari LEFT OUTER JOIN (SELECT HesapKodu , SUM(Simdiki) AS Simdiki , SUM(Onceki) AS Onceki FROM (SELECT substring(tbFirma.sKodu , 1 , 2) AS HesapKodu , SUM((tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar)) AS Simdiki , 0 AS Onceki FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbFirma.sKodu , 1 , 2) UNION SELECT substring(tbFirma.sKodu , 1 , 3) AS HesapKodu , SUM((tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar)) AS Simdiki , 0 AS Onceki FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbFirma.sKodu , 1 , 3) UNION SELECT substring(tbFirma.sKodu , 1 , 1) AS HesapKodu , SUM((tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar)) AS Simdiki , 0 AS Onceki FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbFirma.sKodu , 1 , 1)) AS tempBilanco GROUP BY HesapKodu) tempBilancoAktif ON tempBilancoAktif.HesapKodu = tbBilancoGelirTablosuHesaplari.sHesap3 WHERE (tbBilancoGelirTablosuHesaplari.nRaporTipi = 1) AND (tbBilancoGelirTablosuHesaplari.bAktifMi = 1) UNION ALL SELECT SUBSTRING(tbFirma.sKodu , 1 , 2) AS sHesap2 , SUBSTRING(tbFirma.sKodu , 1 , 20) AS sHesap3 , tbFirma.sAciklama AS sAciklamaTR , '' AS sAciklamaEN , tbFirma.sOzelNot as sAciklamaAR,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Onceki , 0 AS Simdiki , 0 AS bFormulMu , tbFirma.sKodu AS sHesapSirasi , 3 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (SUBSTRING(tbFirma.sKodu , 1 , 1) < '3') AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY tbFirma.sKodu , tbFirma.sAciklama,tbFirma.sOzelNot) TempBilanco ORDER BY sHesapSirasi")
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
        Dim ds_tbMaliyet As New DataSet
        For Each dr In ds_tbAktif.Tables(0).Rows
            If dr("sHesap3") = 151 And dr("nDurum") = 1 Then
                ds_tbMaliyet = sorgu(sorgu_query("SELECT SUM(BorcSimdiki) AS BorcSimdiki, SUM(BakiyeSimdiki) AS BakiyeSimdiki, SUM(BorcOnceki) AS BorcOnceki, SUM(BakiyeOnceki) AS BakiyeOnceki, SUM(ToplamBorc) AS ToplamStokAlisBorc FROM (SELECT isnull(SUM(lBorcTutar) , 0) AS BorcSimdiki , 0 AS BakiyeSimdiki , 0 AS BorcOnceki , 0 AS BakiyeOnceki , 0 AS ToplamBorc FROM tbMuhasebeFisi , tbHesapPlani WHERE tbMuhasebeFisi.nHesapId = tbHesapPlani.nHesapId AND dteFistarihi = '20/01/2010' AND lFisNo = 5 AND sMuhFistipi = '3' AND substring(tbHesapPlani.sKodu , 1 , 3) = '" & dr("sHesap3") & "' UNION ALL SELECT 0 AS BorcSimdiki , isnull(SUM(lBorcTutar - lAlacakTutar) , 0) AS BakiyeSimdiki , 0 AS BorcOnceki , 0 AS BakiyeOnceki , SUM(lBorcTutar) AS ToplamBorc FROM tbMuhasebeFisi , tbHesapPlani WHERE tbMuhasebeFisi.nHesapId = tbHesapPlani.nHesapId AND dteFistarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND substring(tbHesapPlani.sKodu , 1 , 3) = '" & dr("sHesap3") & "') TempDonemBasiSonuStok"))
            ElseIf dr("sHesap3") = 152 And dr("nDurum") = 1 Then
                ds_tbMaliyet = sorgu(sorgu_query("SELECT SUM(BorcSimdiki) AS BorcSimdiki, SUM(BakiyeSimdiki) AS BakiyeSimdiki, SUM(BorcOnceki) AS BorcOnceki, SUM(BakiyeOnceki) AS BakiyeOnceki, SUM(ToplamBorc) AS ToplamStokAlisBorc FROM (SELECT isnull(SUM(lBorcTutar) , 0) AS BorcSimdiki , 0 AS BakiyeSimdiki , 0 AS BorcOnceki , 0 AS BakiyeOnceki , 0 AS ToplamBorc FROM tbMuhasebeFisi , tbHesapPlani WHERE tbMuhasebeFisi.nHesapId = tbHesapPlani.nHesapId AND dteFistarihi = '20/01/2010' AND lFisNo = 5 AND sMuhFistipi = '3' AND substring(tbHesapPlani.sKodu , 1 , 3) = '" & dr("sHesap3") & "' UNION ALL SELECT 0 AS BorcSimdiki , isnull(SUM(lBorcTutar - lAlacakTutar) , 0) AS BakiyeSimdiki , 0 AS BorcOnceki , 0 AS BakiyeOnceki , SUM(lBorcTutar) AS ToplamBorc FROM tbMuhasebeFisi , tbHesapPlani WHERE tbMuhasebeFisi.nHesapId = tbHesapPlani.nHesapId AND dteFistarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND substring(tbHesapPlani.sKodu , 1 , 3) = '" & dr("sHesap3") & "') TempDonemBasiSonuStok"))
            ElseIf dr("sHesap3") = 153 And dr("nDurum") = 1 Then
                ds_tbMaliyet = sorgu(sorgu_query("SELECT SUM(BorcSimdiki) AS BorcSimdiki, SUM(BakiyeSimdiki) AS BakiyeSimdiki, SUM(BorcOnceki) AS BorcOnceki, SUM(BakiyeOnceki) AS BakiyeOnceki, SUM(ToplamBorc) AS ToplamStokAlisBorc FROM (SELECT isnull(SUM(lBorcTutar) , 0) AS BorcSimdiki , 0 AS BakiyeSimdiki , 0 AS BorcOnceki , 0 AS BakiyeOnceki , 0 AS ToplamBorc FROM tbMuhasebeFisi , tbHesapPlani WHERE tbMuhasebeFisi.nHesapId = tbHesapPlani.nHesapId AND dteFistarihi = '20/01/2010' AND lFisNo = 5 AND sMuhFistipi = '3' AND substring(tbHesapPlani.sKodu , 1 , 3) = '" & dr("sHesap3") & "' UNION ALL SELECT 0 AS BorcSimdiki , isnull(SUM(lBorcTutar - lAlacakTutar) , 0) AS BakiyeSimdiki , 0 AS BorcOnceki , 0 AS BakiyeOnceki , SUM(lBorcTutar) AS ToplamBorc FROM tbMuhasebeFisi , tbHesapPlani WHERE tbMuhasebeFisi.nHesapId = tbHesapPlani.nHesapId AND dteFistarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND substring(tbHesapPlani.sKodu , 1 , 3) = '" & dr("sHesap3") & "') TempDonemBasiSonuStok"))
            End If
            If dr("sHesap3") = 153 And dr("sHesapSirasi") = 907 Then
                dr1 = ds_tbMaliyet.Tables(0).Rows(0)
                dr("Onceki") = dr1("BorcSimdiki")
            ElseIf dr("sHesap3") = 153 And dr("sHesapSirasi") = 908 Then
                dr1 = ds_tbMaliyet.Tables(0).Rows(0)
                dr("Onceki") = dr1("ToplamStokAlisBorc")
            ElseIf dr("sHesap3") = 153 And dr("sHesapSirasi") = 909 Then
                dr1 = ds_tbMaliyet.Tables(0).Rows(0)
                dr("Onceki") = dr1("BakiyeSimdiki")
            End If
            If dr("nDurum") = 0 Then
                If s0 = "" Then
                    s0 = "I"
                ElseIf s0 = "I" Then
                    s0 = "II"
                ElseIf s0 = "II" Then
                    s0 = "III"
                ElseIf s0 = "III" Then
                    s0 = "IV"
                ElseIf s0 = "IV" Then
                    s0 = "V"
                ElseIf s0 = "V" Then
                    s0 = "VI"
                ElseIf s0 = "VI" Then
                    s0 = "VII"
                End If
                dr("sAciklamaTR") = s0 & " - " & dr("sAciklamaTR")
                dr("sAciklamaEN") = s0 & " - " & dr("sAciklamaEN")
            ElseIf dr("nDurum") = 1 Then
                If s1 = "" Then
                    s1 = "A"
                ElseIf s1 = "A" Then
                    s1 = "B"
                ElseIf s1 = "B" Then
                    s1 = "C"
                ElseIf s1 = "C" Then
                    s1 = "D"
                ElseIf s1 = "D" Then
                    s1 = "E"
                ElseIf s1 = "E" Then
                    s1 = "F"
                ElseIf s1 = "F" Then
                    s1 = "G"
                ElseIf s1 = "G" Then
                    s1 = "H"
                ElseIf s1 = "H" Then
                    s1 = "I"
                ElseIf s1 = "I" Then
                    s1 = "J"
                ElseIf s1 = "J" Then
                    s1 = "K"
                ElseIf s1 = "K" Then
                    s1 = "L"
                ElseIf s1 = "L" Then
                    s1 = "M"
                ElseIf s1 = "M" Then
                    s1 = "N"
                ElseIf s1 = "N" Then
                    s1 = "O"
                ElseIf s1 = "O" Then
                    s1 = "P"
                ElseIf s1 = "P" Then
                    s1 = "R"
                ElseIf s1 = "R" Then
                    s1 = "S"
                ElseIf s1 = "S" Then
                    s1 = "T"
                ElseIf s1 = "T" Then
                    s1 = "U"
                ElseIf s1 = "U" Then
                    s1 = "V"
                ElseIf s1 = "V" Then
                    s1 = "Y"
                ElseIf s1 = "Y" Then
                    s1 = "Z"
                End If
                s2 = 0
                dr("sAciklamaTR") = vbTab & s1.ToString & "-" & dr("sAciklamaTR")
                dr("sAciklamaEN") = vbTab & s1.ToString & "-" & dr("sAciklamaEN")
            ElseIf dr("nDurum") = 2 Then
                s2 += 1
                dr("sAciklamaTR") = vbTab & vbTab & s2.ToString & "-" & dr("sAciklamaTR")
                dr("sAciklamaEN") = vbTab & vbTab & s2.ToString & "-" & dr("sAciklamaEN")
            End If
        Next
        s0 = Nothing
        s1 = Nothing
        s2 = Nothing
        s4 = Nothing
    End Sub
    Public Sub Dataload_tbPasif(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        Try
            ds_tbPasif.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If sec_detay.Text = "Ozet" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT tbSatislarinMaliyetleriHesaplari.sHesap2, tbSatislarinMaliyetleriHesaplari.sHesap3, tbSatislarinMaliyetleriHesaplari.sAciklamaTR, tbSatislarinMaliyetleriHesaplari.sAciklamaEN, ISNULL(tempSatislarinMaliyetleri.Onceki, 0) AS Onceki, ISNULL(tempSatislarinMaliyetleri.Simdiki, 0) AS Simdiki, tbSatislarinMaliyetleriHesaplari.bFormulMu, tbSatislarinMaliyetleriHesaplari.sHesapSirasi, tbSatislarinMaliyetleriHesaplari.nDurum, tbSatislarinMaliyetleriHesaplari.bUseSelect, tbSatislarinMaliyetleriHesaplari.nDonemBasiSonu, tbSatislarinMaliyetleriHesaplari.nBBA FROM tbSatislarinMaliyetleriHesaplari LEFT OUTER JOIN (SELECT HesapKodu, SUM(Simdiki) AS Simdiki, SUM(Onceki) AS Onceki FROM (SELECT substring(tbHesapPlani.sKodu, 1, 3) AS HesapKodu, SUM(tbMuhasebeFisi.lBorcTutar) AS Simdiki, 0 AS Onceki FROM tbHesapPlani, tbMuhasebeFisi WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND (tbMuhasebeFisi.sHangiUygulama = 'MUH')  GROUP BY substring(tbHesapPlani.sKodu, 1, 3)) AS tempSatislarinMaliyetleriHeaplari GROUP BY HesapKodu) tempSatislarinMaliyetleri ON tempSatislarinMaliyetleri.HesapKodu = tbSatislarinMaliyetleriHesaplari.sHesap3 WHERE (1 = 1) ORDER BY tbSatislarinMaliyetleriHesaplari.sHesapSirasi")
        ElseIf sec_detay.Text = "Detayli" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbBilancoGelirTablosuHesaplari.sHesap2, tbBilancoGelirTablosuHesaplari.sHesap3, tbBilancoGelirTablosuHesaplari.sAciklamaTR, tbBilancoGelirTablosuHesaplari.sAciklamaEN, tbBilancoGelirTablosuHesaplari.sAciklamaAR,ISNULL(tempBilancoAktif.Onceki, 0) AS Onceki, ISNULL(tempBilancoAktif.Simdiki, 0) AS Simdiki, tbBilancoGelirTablosuHesaplari.bFormulMu, tbBilancoGelirTablosuHesaplari.sHesapSirasi, tbBilancoGelirTablosuHesaplari.nDurum FROM tbBilancoGelirTablosuHesaplari LEFT OUTER JOIN (SELECT HesapKodu , SUM(Simdiki) AS Simdiki , SUM(Onceki) AS Onceki FROM (SELECT substring(tbHesapPlani.sKodu , 1 , 2) AS HesapKodu , SUM((tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar)) AS Simdiki , 0 AS Onceki FROM tbHesapPlani , tbMuhasebeFisi WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND (tbMuhasebeFisi.sHangiUygulama = 'MUH')  GROUP BY substring(tbHesapPlani.sKodu , 1 , 2) UNION SELECT substring(tbHesapPlani.sKodu , 1 , 3) AS HesapKodu , SUM((tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar)) AS Simdiki , 0 AS Onceki FROM tbHesapPlani , tbMuhasebeFisi WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND (tbMuhasebeFisi.sHangiUygulama = 'MUH')  GROUP BY substring(tbHesapPlani.sKodu , 1 , 3) UNION SELECT substring(tbHesapPlani.sKodu , 1 , 1) AS HesapKodu , SUM((tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar)) AS Simdiki , 0 AS Onceki FROM tbHesapPlani , tbMuhasebeFisi WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND (tbMuhasebeFisi.sHangiUygulama = 'MUH')  GROUP BY substring(tbHesapPlani.sKodu , 1 , 1)) AS tempBilanco GROUP BY HesapKodu) tempBilancoAktif ON tempBilancoAktif.HesapKodu = tbBilancoGelirTablosuHesaplari.sHesap3 WHERE (tbBilancoGelirTablosuHesaplari.nRaporTipi = 2) AND (tbBilancoGelirTablosuHesaplari.bAktifMi = 0) UNION ALL SELECT SUBSTRING(tbHesapPlani.sKodu , 1 , 2) AS sHesap2 , SUBSTRING(tbHesapPlani.sKodu , 1 , 20) AS sHesap3 , tbHesapPlani.sAciklama AS sAciklamaTR , '' AS sAciklamaEN ,tbHesapPlani.sAlterneAciklama sAciklamaAR, SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) AS Onceki , 0 AS Simdiki , 0 AS bFormulMu , tbHesapPlani.sKodu AS sHesapSirasi , 3 AS nDurum FROM tbHesapPlani INNER JOIN tbMuhasebeFisi ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID WHERE (SUBSTRING(tbHesapPlani.sKodu , 1 , 1) BETWEEN '6' AND '8') AND tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND (tbMuhasebeFisi.sHangiUygulama = 'MUH')  GROUP BY tbHesapPlani.sKodu , tbHesapPlani.sAciklama,tbHesapPlani.sAlterneAciklama) TempBilanco ORDER BY sHesapSirasi")
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbBilancoGelirTablosuHesaplari.sHesap2 , tbBilancoGelirTablosuHesaplari.sHesap3 , tbBilancoGelirTablosuHesaplari.sAciklamaTR , tbBilancoGelirTablosuHesaplari.sAciklamaEN , tbBilancoGelirTablosuHesaplari.sAciklamaAR,ISNULL(tempBilancoAktif.Onceki , 0) AS Onceki , ISNULL(tempBilancoAktif.Simdiki , 0) AS Simdiki , tbBilancoGelirTablosuHesaplari.bFormulMu , tbBilancoGelirTablosuHesaplari.sHesapSirasi , tbBilancoGelirTablosuHesaplari.nDurum FROM tbBilancoGelirTablosuHesaplari LEFT OUTER JOIN (SELECT HesapKodu , SUM(Simdiki) AS Simdiki , SUM(Onceki) AS Onceki FROM (SELECT substring(tbFirma.sKodu , 1 , 2) AS HesapKodu , SUM((tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar)) AS Simdiki , 0 AS Onceki FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbFirma.sKodu , 1 , 2) UNION SELECT substring(tbFirma.sKodu , 1 , 3) AS HesapKodu , SUM((tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar)) AS Simdiki , 0 AS Onceki FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbFirma.sKodu , 1 , 3) UNION SELECT substring(tbFirma.sKodu , 1 , 1) AS HesapKodu , SUM((tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar)) AS Simdiki , 0 AS Onceki FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbFirma.sKodu , 1 , 1)) AS tempBilanco GROUP BY HesapKodu) tempBilancoAktif ON tempBilancoAktif.HesapKodu = tbBilancoGelirTablosuHesaplari.sHesap3 WHERE (tbBilancoGelirTablosuHesaplari.nRaporTipi = 1) AND (tbBilancoGelirTablosuHesaplari.bAktifMi = 0) UNION ALL SELECT SUBSTRING(tbFirma.sKodu , 1 , 2) AS sHesap2 , SUBSTRING(tbFirma.sKodu , 1 , 20) AS sHesap3 , tbFirma.sAciklama AS sAciklamaTR , '' AS sAciklamaEN ,tbFirma.sOzelNot sAciklamaAR, SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS Onceki , 0 AS Simdiki , 0 AS bFormulMu , tbFirma.sKodu AS sHesapSirasi , 3 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (SUBSTRING(tbFirma.sKodu , 1 , 1) BETWEEN '3' AND '6') AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY tbFirma.sKodu , tbFirma.sAciklama,tbFirma.sOzelNot) TempBilanco ORDER BY sHesapSirasi")
        End If
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbBilancoGelirTablosuHesaplari.sHesap2, tbBilancoGelirTablosuHesaplari.sHesap3, tbBilancoGelirTablosuHesaplari.sAciklamaTR, tbBilancoGelirTablosuHesaplari.sAciklamaEN, ISNULL(tempBilancoAktif.Onceki, 0) AS Onceki, ISNULL(tempBilancoAktif.Simdiki, 0) AS Simdiki, tbBilancoGelirTablosuHesaplari.bFormulMu, tbBilancoGelirTablosuHesaplari.sHesapSirasi, tbBilancoGelirTablosuHesaplari.nDurum FROM tbBilancoGelirTablosuHesaplari LEFT OUTER JOIN (SELECT HesapKodu , SUM(Simdiki) AS Simdiki , SUM(Onceki) AS Onceki FROM (SELECT substring(tbFirma.sKodu , 1 , 2) AS HesapKodu , SUM((tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar)) AS Simdiki , 0 AS Onceki FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbFirma.sKodu , 1 , 2) UNION SELECT substring(tbFirma.sKodu , 1 , 3) AS HesapKodu , SUM((tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar)) AS Simdiki , 0 AS Onceki FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbFirma.sKodu , 1 , 3) UNION SELECT substring(tbFirma.sKodu , 1 , 1) AS HesapKodu , SUM((tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar)) AS Simdiki , 0 AS Onceki FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbFirma.sKodu , 1 , 1)) AS tempBilanco GROUP BY HesapKodu) tempBilancoAktif ON tempBilancoAktif.HesapKodu = tbBilancoGelirTablosuHesaplari.sHesap3 WHERE (tbBilancoGelirTablosuHesaplari.nRaporTipi = 1) AND (tbBilancoGelirTablosuHesaplari.bAktifMi = 0) ORDER BY tbBilancoGelirTablosuHesaplari.sHesapSirasi")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbPasif, "Table1")
        conn.Close()
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim s0 As String = ""
        Dim s1 As String = ""
        Dim s2 As Integer = 0
        Dim s4 As String = ""
        Dim lToplamMaliyet As Decimal = 0
        Dim ds_tbMaliyet As New DataSet
        For Each dr In ds_tbPasif.Tables(0).Rows
            If dr("sHesap3") = 151 And dr("nDurum") = 1 Then
                ds_tbMaliyet = sorgu(sorgu_query("SELECT SUM(BorcSimdiki) AS BorcSimdiki, SUM(BakiyeSimdiki) AS BakiyeSimdiki, SUM(BorcOnceki) AS BorcOnceki, SUM(BakiyeOnceki) AS BakiyeOnceki, SUM(ToplamBorc) AS ToplamStokAlisBorc FROM (SELECT isnull(SUM(lBorcTutar) , 0) AS BorcSimdiki , 0 AS BakiyeSimdiki , 0 AS BorcOnceki , 0 AS BakiyeOnceki , 0 AS ToplamBorc FROM tbMuhasebeFisi , tbHesapPlani WHERE tbMuhasebeFisi.nHesapId = tbHesapPlani.nHesapId AND dteFistarihi = '" & tarih1 & "' AND lFisNo = 1 AND sMuhFistipi = '3' AND substring(tbHesapPlani.sKodu , 1 , 3) = '" & dr("sHesap3") & "' UNION ALL SELECT 0 AS BorcSimdiki , isnull(SUM(lBorcTutar - lAlacakTutar) , 0) AS BakiyeSimdiki , 0 AS BorcOnceki , 0 AS BakiyeOnceki , SUM(lBorcTutar) AS ToplamBorc FROM tbMuhasebeFisi , tbHesapPlani WHERE tbMuhasebeFisi.nHesapId = tbHesapPlani.nHesapId AND dteFistarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND substring(tbHesapPlani.sKodu , 1 , 3) = '" & dr("sHesap3") & "') TempDonemBasiSonuStok"))
            ElseIf dr("sHesap3") = 152 And dr("nDurum") = 1 Then
                ds_tbMaliyet = sorgu(sorgu_query("SELECT SUM(BorcSimdiki) AS BorcSimdiki, SUM(BakiyeSimdiki) AS BakiyeSimdiki, SUM(BorcOnceki) AS BorcOnceki, SUM(BakiyeOnceki) AS BakiyeOnceki, SUM(ToplamBorc) AS ToplamStokAlisBorc FROM (SELECT isnull(SUM(lBorcTutar) , 0) AS BorcSimdiki , 0 AS BakiyeSimdiki , 0 AS BorcOnceki , 0 AS BakiyeOnceki , 0 AS ToplamBorc FROM tbMuhasebeFisi , tbHesapPlani WHERE tbMuhasebeFisi.nHesapId = tbHesapPlani.nHesapId AND dteFistarihi = '" & tarih1 & "' AND lFisNo = 1 AND sMuhFistipi = '3' AND substring(tbHesapPlani.sKodu , 1 , 3) = '" & dr("sHesap3") & "' UNION ALL SELECT 0 AS BorcSimdiki , isnull(SUM(lBorcTutar - lAlacakTutar) , 0) AS BakiyeSimdiki , 0 AS BorcOnceki , 0 AS BakiyeOnceki , SUM(lBorcTutar) AS ToplamBorc FROM tbMuhasebeFisi , tbHesapPlani WHERE tbMuhasebeFisi.nHesapId = tbHesapPlani.nHesapId AND dteFistarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND substring(tbHesapPlani.sKodu , 1 , 3) = '" & dr("sHesap3") & "') TempDonemBasiSonuStok"))
            ElseIf dr("sHesap3") = 153 And dr("nDurum") = 1 Then
                ds_tbMaliyet = sorgu(sorgu_query("SELECT SUM(BorcSimdiki) AS BorcSimdiki, SUM(BakiyeSimdiki) AS BakiyeSimdiki, SUM(BorcOnceki) AS BorcOnceki, SUM(BakiyeOnceki) AS BakiyeOnceki, SUM(ToplamBorc) AS ToplamStokAlisBorc FROM (SELECT isnull(SUM(lBorcTutar) , 0) AS BorcSimdiki , 0 AS BakiyeSimdiki , 0 AS BorcOnceki , 0 AS BakiyeOnceki , 0 AS ToplamBorc FROM tbMuhasebeFisi , tbHesapPlani WHERE tbMuhasebeFisi.nHesapId = tbHesapPlani.nHesapId AND dteFistarihi = '" & tarih1 & "' AND lFisNo = 1 AND sMuhFistipi = '3' AND substring(tbHesapPlani.sKodu , 1 , 3) = '" & dr("sHesap3") & "' UNION ALL SELECT 0 AS BorcSimdiki , isnull(SUM(lBorcTutar - lAlacakTutar) , 0) AS BakiyeSimdiki , 0 AS BorcOnceki , 0 AS BakiyeOnceki , SUM(lBorcTutar) AS ToplamBorc FROM tbMuhasebeFisi , tbHesapPlani WHERE tbMuhasebeFisi.nHesapId = tbHesapPlani.nHesapId AND dteFistarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND substring(tbHesapPlani.sKodu , 1 , 3) = '" & dr("sHesap3") & "') TempDonemBasiSonuStok"))
                dr1 = ds_tbMaliyet.Tables(0).Rows(0)
                lToplamMaliyet = (dr1("ToplamStokAlisBorc")) - dr1("BakiyeSimdiki")
                dr("Simdiki") = lToplamMaliyet
            End If
            If dr("sHesap3") = 151 And dr("sHesapSirasi") = 798 Then
                dr1 = ds_tbMaliyet.Tables(0).Rows(0)
                dr("Onceki") = dr1("BorcSimdiki")
                dr("Simdiki") = 0
            ElseIf dr("sHesap3") = 151 And dr("sHesapSirasi") = 799 Then
                dr1 = ds_tbMaliyet.Tables(0).Rows(0)
                dr("Onceki") = dr1("BakiyeSimdiki")
                dr("Simdiki") = 0
            End If
            If dr("sHesap3") = 152 And dr("sHesapSirasi") = 898 Then
                dr1 = ds_tbMaliyet.Tables(0).Rows(0)
                dr("Onceki") = dr1("BorcSimdiki")
                dr("Simdiki") = 0
            ElseIf dr("sHesap3") = 152 And dr("sHesapSirasi") = 899 Then
                dr1 = ds_tbMaliyet.Tables(0).Rows(0)
                dr("Onceki") = dr1("BakiyeSimdiki")
                dr("Simdiki") = 0
            End If
            If dr("sHesap3") = 153 And dr("sHesapSirasi") = 907 Then
                dr1 = ds_tbMaliyet.Tables(0).Rows(0)
                dr("Onceki") = dr1("BorcSimdiki")
                dr("Simdiki") = 0
            ElseIf dr("sHesap3") = 153 And dr("sHesapSirasi") = 908 Then
                dr1 = ds_tbMaliyet.Tables(0).Rows(0)
                dr("Onceki") = dr1("ToplamStokAlisBorc") - dr1("BorcSimdiki")
                dr("Simdiki") = 0
            ElseIf dr("sHesap3") = 153 And dr("sHesapSirasi") = 909 Then
                dr1 = ds_tbMaliyet.Tables(0).Rows(0)
                dr("Onceki") = dr1("BakiyeSimdiki")
                dr("Simdiki") = 0
            End If
            If dr("sHesap3") = 910 Then
                dr("Simdiki") = lToplamMaliyet
            ElseIf dr("sHesap3") = 999 Then
                dr("Simdiki") = lToplamMaliyet
            End If
            If dr("nDurum") = 0 Then
                If s0 = "" Then
                    s0 = "I"
                ElseIf s0 = "I" Then
                    s0 = "II"
                ElseIf s0 = "II" Then
                    s0 = "III"
                ElseIf s0 = "III" Then
                    s0 = "IV"
                ElseIf s0 = "IV" Then
                    s0 = "V"
                ElseIf s0 = "V" Then
                    s0 = "VI"
                ElseIf s0 = "VI" Then
                    s0 = "VII"
                End If
                dr("sAciklamaTR") = s0 & " - " & dr("sAciklamaTR")
                dr("sAciklamaEN") = s0 & " - " & dr("sAciklamaEN")
            ElseIf dr("nDurum") = 1 Then
                If s1 = "" Then
                    s1 = "A"
                ElseIf s1 = "A" Then
                    s1 = "B"
                ElseIf s1 = "B" Then
                    s1 = "C"
                ElseIf s1 = "C" Then
                    s1 = "D"
                ElseIf s1 = "D" Then
                    s1 = "E"
                ElseIf s1 = "E" Then
                    s1 = "F"
                ElseIf s1 = "F" Then
                    s1 = "G"
                ElseIf s1 = "G" Then
                    s1 = "H"
                ElseIf s1 = "H" Then
                    s1 = "I"
                ElseIf s1 = "I" Then
                    s1 = "J"
                ElseIf s1 = "J" Then
                    s1 = "K"
                ElseIf s1 = "K" Then
                    s1 = "L"
                ElseIf s1 = "L" Then
                    s1 = "M"
                ElseIf s1 = "M" Then
                    s1 = "N"
                ElseIf s1 = "N" Then
                    s1 = "O"
                ElseIf s1 = "O" Then
                    s1 = "P"
                ElseIf s1 = "P" Then
                    s1 = "R"
                ElseIf s1 = "R" Then
                    s1 = "S"
                ElseIf s1 = "S" Then
                    s1 = "T"
                ElseIf s1 = "T" Then
                    s1 = "U"
                ElseIf s1 = "U" Then
                    s1 = "V"
                ElseIf s1 = "V" Then
                    s1 = "Y"
                ElseIf s1 = "Y" Then
                    s1 = "Z"
                End If
                s2 = 0
                dr("sAciklamaTR") = vbTab & s1.ToString & "-" & dr("sAciklamaTR")
                dr("sAciklamaEN") = vbTab & s1.ToString & "-" & dr("sAciklamaEN")
            ElseIf dr("nDurum") = 2 Then
                s2 += 1
                dr("sAciklamaTR") = vbTab & vbTab & s2.ToString & "-" & dr("sAciklamaTR")
                dr("sAciklamaEN") = vbTab & vbTab & s2.ToString & "-" & dr("sAciklamaEN")
            End If
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
        txt_ara.EditValue = ""
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
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
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
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Text Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
                SaveFileDialog1.Filter = "Text Dosyaları(*.txt) |*.txt"
                SaveFileDialog1.InitialDirectory = "c:\"
                SaveFileDialog1.FileName = "Rapor.txt"
                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    GridView2.ExportToText(SaveFileDialog1.FileName.ToString)
                    If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        Process.Start(SaveFileDialog1.FileName.ToString)
                    End If
                End If
                SaveFileDialog1 = Nothing
            End If
        End If
    End Sub
    Private Sub raporla_pdf()
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
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
        ElseIf XtraTabControl1.SelectedTabPageIndex = 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Metin Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
                SaveFileDialog1.Filter = "Metin Dosyaları(*.pdf) |*.pdf"
                SaveFileDialog1.InitialDirectory = "c:\"
                SaveFileDialog1.FileName = "Rapor.pdf"
                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    GridView2.ExportToPdf(SaveFileDialog1.FileName.ToString)
                    If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        Process.Start(SaveFileDialog1.FileName.ToString)
                    End If
                End If
                SaveFileDialog1 = Nothing
            End If
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
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView2.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        LabelControl1.Text = Sorgu_sDil(LabelControl1.Text, sDil)
        LabelControl2.Text = Sorgu_sDil(LabelControl2.Text, sDil)
        LabelControl3.Text = Sorgu_sDil(LabelControl3.Text, sDil)
        LabelControl4.Text = Sorgu_sDil(LabelControl4.Text, sDil)
        LabelControl5.Text = Sorgu_sDil(LabelControl5.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Sub gorunum_yazdir()
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            Dim kriter As String = ""
            kriter += DateEdit1.EditValue & " ve " & DateEdit2.EditValue & Sorgu_sDil(" Tarihleri Arasındaki Satışların Maliyet Tablosu", sDil) & vbCrLf
            printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Muhasebe Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
            printlink1.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            printlink2.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        End If
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            GridControl1.Focus()
            GridControl1.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            GridControl2.Focus()
            GridControl2.Select()
        End If
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
End Class