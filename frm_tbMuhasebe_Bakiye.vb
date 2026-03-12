Imports DevExpress.XtraEditors
Public Class frm_tbMuhasebe_Bakiye
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
        Dim kriter As String = ""
        If sec_islem.Text = "Borçlu Hesaplar" Then
            kriter = " HAVING ((SUM(tbMuhasebeFisi.lBorcTutar) - SUM(tbMuhasebeFisi.lAlacakTutar)) > 0 )"
        ElseIf sec_islem.Text = "Alacaklı Hesaplar" Then
            kriter = " HAVING ((SUM(tbMuhasebeFisi.lBorcTutar) - SUM(tbMuhasebeFisi.lAlacakTutar)) < 0 )"
        ElseIf sec_islem.Text = "Tümü" Then
            kriter = " HAVING (ABS(SUM(tbMuhasebeFisi.lBorcTutar) - SUM(tbMuhasebeFisi.lAlacakTutar)) BETWEEN 0 AND 99999999999999999)"
        End If
        If sec_detay.Text = "Ozet" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT DISTINCT SUBSTRING(tbHesapPlani.sKodu, 1, 3) AS sKodu, tbtempKebir.sAciklamakebir AS sAciklama, SUM(tbMuhasebeFisi.lBorcTutar) AS lBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lAlacakTutar, SUM(tbMuhasebeFisi.lGirenMiktar) AS lGirenMiktar, SUM(tbMuhasebeFisi.lCikanMiktar) AS lCikanMiktar, lBorcBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) > 0 THEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) ELSE 0 END, lAlacakBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) < 0 THEN SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) ELSE 0 END, 0 AS lGirenBakiye, 0 AS lCikanBakiye FROM (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamaGrup1 FROM tbHesapPlani) tbtempGrup1 RIGHT OUTER JOIN tbHesapPlani INNER JOIN tbMuhasebeFisi INNER JOIN (SELECT tbHesapplani.nHesapId, SUM(lBorcTutar) - SUM(lalacaktutar) AS lbakiyeTutar, SUM(lgirenMiktar) - SUM(lCikanMiktar) AS lbakiyeMiktar FROM tbMuhasebeFisi, tbHesapPlani WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY tbHesapplani.nHesapID) Bakiye ON Bakiye.nHesapId = tbMuhasebeFisi.nHesapID ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID LEFT OUTER JOIN (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamakebir FROM tbHesapPlani) tbtempKebir ON tbtempKebir.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 3) ON tbtempGrup1.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 7) AND LEN(tbHesapPlani.sKodu) >= 7 WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbMuhasebeFisi.sHangiUygulama = 'MUH')  GROUP BY SUBSTRING(tbHesapPlani.sKodu, 1, 3), tbtempKebir.sAciklamakebir, tbtempGrup1.sAciklamaGrup1 " & kriter & " ORDER BY SUBSTRING(tbHesapPlani.sKodu, 1, 3)")
            collBorcTutar.SummaryItem.FieldName = "lBorcTutar"
            collAlacakTutar.SummaryItem.FieldName = "lAlacakTutar"
            collBorcBakiye.SummaryItem.FieldName = "lBorcBakiye"
            collAlacakBakiye.SummaryItem.FieldName = "lAlacakBakiye"
        ElseIf sec_detay.Text = "Detayli" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT * FROM (SELECT DISTINCT SUBSTRING(tbHesapPlani.sKodu, 1, 3) AS sKodu, tbtempKebir.sAciklamakebir AS sAciklama, SUM(tbMuhasebeFisi.lBorcTutar) AS lBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lAlacakTutar, SUM(tbMuhasebeFisi.lGirenMiktar) AS lGirenMiktar, SUM(tbMuhasebeFisi.lCikanMiktar) AS lCikanMiktar, lBorcBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) > 0 THEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) ELSE 0 END, lAlacakBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) < 0 THEN SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) ELSE 0 END, 0 AS lGirenBakiye, 0 AS lCikanBakiye, 1 AS nDurum,SUM(tbMuhasebeFisi.lBorcTutar) AS lToplamBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lToplamAlacakTutar,lToplamBorcBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) > 0 THEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) ELSE 0 END, lToplamAlacakBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) < 0 THEN SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) ELSE 0 END, 0 AS lToplamGirenBakiye, 0 AS lToplamCikanBakiye FROM (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamaGrup1 FROM tbHesapPlani) tbtempGrup1 RIGHT OUTER JOIN tbHesapPlani INNER JOIN tbMuhasebeFisi INNER JOIN (SELECT tbHesapplani.nHesapId, SUM(lBorcTutar) - SUM(lalacaktutar) AS lbakiyeTutar, SUM(lgirenMiktar) - SUM(lCikanMiktar) AS lbakiyeMiktar FROM tbMuhasebeFisi, tbHesapPlani WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY tbHesapplani.nHesapID) Bakiye ON Bakiye.nHesapId = tbMuhasebeFisi.nHesapID ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID LEFT OUTER JOIN (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamakebir FROM tbHesapPlani) tbtempKebir ON tbtempKebir.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 3) ON tbtempGrup1.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 7) AND LEN(tbHesapPlani.sKodu) >= 7 WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbMuhasebeFisi.sHangiUygulama = 'MUH')  GROUP BY SUBSTRING(tbHesapPlani.sKodu, 1, 3), tbtempKebir.sAciklamakebir, tbtempGrup1.sAciklamaGrup1 " & kriter & " UNION ALL SELECT DISTINCT tbHesapPlani.sKodu AS sKodu, tbHesapPlani.sAciklama, SUM(tbMuhasebeFisi.lBorcTutar) AS lBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lAlacakTutar, SUM(tbMuhasebeFisi.lGirenMiktar) AS lGirenMiktar, SUM(tbMuhasebeFisi.lCikanMiktar) AS lCikanMiktar, lBorcBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) > 0 THEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) ELSE 0 END, lAlacakBakiye = CASE WHEN SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) < 0 THEN SUM(tbMuhasebeFisi.lAlacakTutar - tbMuhasebeFisi.lBorcTutar) ELSE 0 END, 0 AS lGirenBakiye, 0 AS lCikanBakiye, 2 AS nDurum,0 as lToplamBorcTutar, 0 as lToplamAlacakTutar,0 as lToplamBorcBakiye,0 as lToplamAlacakBakiye,0 as lToplamGirenBakiye,0 as lToplamCikanBakiye FROM (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamakebir FROM tbHesapPlani) tbtempKebir RIGHT OUTER JOIN tbHesapPlani INNER JOIN tbMuhasebeFisi INNER JOIN (SELECT tbHesapplani.nHesapId, SUM(lBorcTutar) - SUM(lalacaktutar) AS lbakiyeTutar, SUM(lgirenMiktar) - SUM(lCikanMiktar) AS lbakiyeMiktar FROM tbMuhasebeFisi, tbHesapPlani WHERE tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID AND dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY tbHesapplani.nHesapID) Bakiye ON Bakiye.nHesapId = tbMuhasebeFisi.nHesapID ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID LEFT OUTER JOIN (SELECT sKodu AS sKodu, tbHesapPlani.sAciklama AS sAciklamaGrup1 FROM tbHesapPlani) tbtempGrup1 ON SUBSTRING(tbHesapPlani.sKodu, 1, 7) = tbtempGrup1.sKodu AND LEN(tbHesapPlani.sKodu) >= 7 ON tbtempKebir.sKodu = SUBSTRING(tbHesapPlani.sKodu, 1, 3) WHERE (tbMuhasebeFisi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbMuhasebeFisi.sHangiUygulama = 'MUH')  GROUP BY tbtempKebir.sKodu, Bakiye.lbakiyeTutar, Bakiye.lbakiyeMiktar, SUBSTRING(tbHesapPlani.sKodu, 1, 3), SUBSTRING(tbHesapPlani.sKodu, 1, 7), tbHesapPlani.sKodu, tbHesapPlani.sAciklama, tbtempKebir.sAciklamakebir, tbtempGrup1.sAciklamaGrup1 " & kriter & " ) tbMizan ORDER BY sKodu")
            collBorcTutar.SummaryItem.FieldName = "lToplamBorcTutar"
            collAlacakTutar.SummaryItem.FieldName = "lToplamAlacakTutar"
            collBorcBakiye.SummaryItem.FieldName = "lToplamBorcBakiye"
            collAlacakBakiye.SummaryItem.FieldName = "lToplamAlacakBakiye"
        End If
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbAktif, "Table1")
        conn.Close()
        'Dim dr As DataRow
        Dim s0 As String = ""
        Dim s1 As String = ""
        Dim s2 As Integer = 0
        Dim s4 As String = ""
        Dim lKarZarar As Decimal = 0
        'For Each dr In ds_tbAktif.Tables(0).Rows
        '    If dr("nDurum") = 0 Then
        '        If s0 = "" Then
        '            s0 = "I"
        '        ElseIf s0 = "I" Then
        '            s0 = "II"
        '        ElseIf s0 = "II" Then
        '            s0 = "III"
        '        ElseIf s0 = "III" Then
        '            s0 = "IV"
        '        ElseIf s0 = "IV" Then
        '            s0 = "V"
        '        ElseIf s0 = "V" Then
        '            s0 = "VI"
        '        ElseIf s0 = "VI" Then
        '            s0 = "VII"
        '        End If
        '        dr("sAciklamaTR") = s0 & " - " & dr("sAciklamaTR")
        '        dr("sAciklamaEN") = s0 & " - " & dr("sAciklamaEN")
        '    ElseIf dr("nDurum") = 1 Then
        '        If s1 = "" Then
        '            s1 = "A"
        '        ElseIf s1 = "A" Then
        '            s1 = "B"
        '        ElseIf s1 = "B" Then
        '            s1 = "C"
        '        ElseIf s1 = "C" Then
        '            s1 = "D"
        '        ElseIf s1 = "D" Then
        '            s1 = "E"
        '        ElseIf s1 = "E" Then
        '            s1 = "F"
        '        ElseIf s1 = "F" Then
        '            s1 = "G"
        '        ElseIf s1 = "G" Then
        '            s1 = "H"
        '        ElseIf s1 = "H" Then
        '            s1 = "I"
        '        ElseIf s1 = "I" Then
        '            s1 = "J"
        '        ElseIf s1 = "J" Then
        '            s1 = "K"
        '        ElseIf s1 = "K" Then
        '            s1 = "L"
        '        ElseIf s1 = "L" Then
        '            s1 = "M"
        '        ElseIf s1 = "M" Then
        '            s1 = "N"
        '        ElseIf s1 = "N" Then
        '            s1 = "O"
        '        ElseIf s1 = "O" Then
        '            s1 = "P"
        '        ElseIf s1 = "P" Then
        '            s1 = "R"
        '        ElseIf s1 = "R" Then
        '            s1 = "S"
        '        ElseIf s1 = "S" Then
        '            s1 = "T"
        '        ElseIf s1 = "T" Then
        '            s1 = "U"
        '        ElseIf s1 = "U" Then
        '            s1 = "V"
        '        ElseIf s1 = "V" Then
        '            s1 = "Y"
        '        ElseIf s1 = "Y" Then
        '            s1 = "Z"
        '        End If
        '        s2 = 0
        '        dr("sAciklamaTR") = vbTab & s1.ToString & "-" & dr("sAciklamaTR")
        '        dr("sAciklamaEN") = vbTab & s1.ToString & "-" & dr("sAciklamaEN")
        '    ElseIf dr("nDurum") = 2 Then
        '        s2 += 1
        '        dr("sAciklamaTR") = vbTab & vbTab & s2.ToString & "-" & dr("sAciklamaTR")
        '        dr("sAciklamaEN") = vbTab & vbTab & s2.ToString & "-" & dr("sAciklamaEN")
        '        If dr("sHesap2") = "69" And dr("sHesap3") = "69" Then
        '            dr("Simdiki") = lKarZarar
        '        ElseIf dr("sHesap2") = "69" And dr("sHesap3") = "692" Then
        '            dr("Simdiki") = lKarZarar
        '        Else
        '            lKarZarar = lKarZarar + dr("Simdiki")
        '        End If
        '    End If
        '    If dr("sHesap2") = "69" And dr("sHesap3") = "69" Then
        '        dr("Simdiki") = lKarZarar
        '    ElseIf dr("sHesap2") = "69" And dr("sHesap3") = "692" Then
        '        dr("Simdiki") = lKarZarar
        '    End If
        'Next
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
        DateEdit1.EditValue = "01/01/1900"
        DateEdit2.EditValue = "31/12/2078"
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
        LabelControl4.Text = Sorgu_sDil(LabelControl4.Text, sDil)
        LabelControl5.Text = Sorgu_sDil(LabelControl5.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Sub gorunum_yazdir()
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            Dim kriter As String = ""
            kriter += DateEdit1.EditValue & " ve " & DateEdit2.EditValue & Sorgu_sDil(" Tarihleri Arasındaki Hesap Bakiyesi", sDil) & vbCrLf
            printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Muhasebe Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
            printlink1.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            Dim kriter As String = ""
            kriter += DateEdit1.EditValue & " ve " & DateEdit2.EditValue & Sorgu_sDil(" Tarihleri Arasındaki Hesap Bakiyesi", sDil) & vbCrLf
            printlink2.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Muhasebe Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
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
End Class