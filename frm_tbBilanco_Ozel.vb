Imports Microsoft.Win32
Imports FastReport
Imports DevExpress.XtraEditors
Public Class frm_tbBilanco_Ozel
    Public firmano
    Public donemno
    Public connection
    Public nFirmaID
    Dim nHesapID
    Public sKodu
    Public kullanici
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_cari As DataSet
    Public yeni As Boolean = False
    Public bBakiye As Boolean = False
    Private Sub frm_tbBilanco_Ozel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        'DateEdit1.EditValue = dteSistemTarihi
        'DateEdit2.EditValue = dteSistemTarihi

        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        txt_ara.EditValue = ""
        DateEdit1.Focus()
        DateEdit1.Select()
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
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        'Dataload_tbAktif(tarih1, tarih2)
        'Dataload_tbPasif(tarih1, tarih2)
        Try
            ds_tbAktif.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Try
            ds_tbPasif.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim sKod As String = ""
        Dim sAciklama As String = ""
        Dim sAciklamaTR As String = ""
        'sKod = "101"
        'sAciklama = "Alinan Cekler"
        'Dataload_tbAktif(tarih1, tarih2, "SELECT '" & sKod & "' sHesap, '" & sKod & "', N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, 0 AS lBorcTutar, SUM(tbCekSenet.lTutar) AS lAlacakTutar, SUM(tbCekSenet.lTutar) AS lBakiye, 1 AS nDurum FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem WHERE (tbCekSenet.sCekSenetTipi = 'AC') AND (tbCekSenet.dteVadeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbCekSenet.lCekSenetNo BETWEEN '0' AND '999999999') AND (tbCekSenet.sOrjinalCekSenetNo BETWEEN '' AND 'zzzzzzzzz') AND (tbCekSenetBordro.nCekSenetIslem IN (1, 6)) UNION ALL SELECT '" & sKod & "' sHesap, VEREN.sKodu, VEREN.sAciklama, 0 AS lBorcTutar, SUM(tbCekSenet.lTutar) AS lAlacakTutar, SUM(tbCekSenet.lTutar) AS lBakiye, 2 AS nDurum FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem WHERE (tbCekSenet.sCekSenetTipi = 'AC') AND (tbCekSenet.dteVadeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbCekSenet.lCekSenetNo BETWEEN '0' AND '999999999') AND (tbCekSenet.sOrjinalCekSenetNo BETWEEN '' AND 'zzzzzzzzz') AND (tbCekSenetBordro.nCekSenetIslem IN (1, 6)) GROUP BY VEREN.sKodu, VEREN.sAciklama")
        'Aktifler 
        If sec_detay.Text = "Ozet" Then
            sKod = "103"
            sAciklama = Sorgu_sDil("Verilen Çekler", sDil)
            sAciklamaTR = "Verilen Çekler"
            Dataload_tbAktif(tarih1, tarih2, "SELECT '" & sKod & "' sHesap, '" & sKod & "' as sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, 0 AS lBorcTutar, SUM(tbCekSenet.lTutar) AS lAlacakTutar, 0 AS lBakiye, SUM(tbCekSenet.lTutar) AS lTutar,1 AS nDurum FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem WHERE (tbCekSenet.sCekSenetTipi = 'BC') AND (tbCekSenet.dteVadeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbCekSenet.lCekSenetNo BETWEEN '0' AND '999999999') AND (tbCekSenet.sOrjinalCekSenetNo BETWEEN '' AND 'zzzzzzzzz') AND (tbCekSenetBordro.nCekSenetIslem IN (20)) ")
            sKod = "320"
            sAciklama = Sorgu_sDil("Satýcý Firma Hesaplarý", sDil)
            sAciklamaTR = "Satýcý Firma Hesaplarý"
            Dataload_tbAktif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')  ")
            sKod = "321"
            sAciklama = Sorgu_sDil("Borç Senetleri", sDil)
            sAciklamaTR = "Borç Senetleri"
            Dataload_tbAktif(tarih1, tarih2, "SELECT '" & sKod & "' sHesap, '" & sKod & "' as sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, 0 AS lBorcTutar, SUM(tbCekSenet.lTutar) AS lAlacakTutar, 0 AS lBakiye, SUM(tbCekSenet.lTutar) AS lTutar,1 AS nDurum FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem WHERE (tbCekSenet.sCekSenetTipi = 'BS') AND (tbCekSenet.dteVadeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbCekSenet.lCekSenetNo BETWEEN '0' AND '999999999') AND (tbCekSenet.sOrjinalCekSenetNo BETWEEN '' AND 'zzzzzzzzz') AND (tbCekSenetBordro.nCekSenetIslem IN (20)) ")
            sKod = "331"
            sAciklama = Sorgu_sDil("Ortaklara Borçlar", sDil)
            sAciklamaTR = "Ortaklara Borçlar"
            Dataload_tbAktif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            sKod = "335"
            sAciklama = Sorgu_sDil("Personele Borçlar", sDil)
            sAciklamaTR = "Personele Borçlar"
            Dataload_tbAktif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            sKod = "336"
            sAciklama = Sorgu_sDil("Diðer Çesitli Borçlar", sDil)
            sAciklamaTR = "Diðer Çeþitli Borçlar"
            Dataload_tbAktif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            sKod = "339"
            sAciklama = Sorgu_sDil("Diðer Çeþitli Borçlar #", sDil)
            sAciklamaTR = "Diðer Çeþitli Borçlar #"
            Dataload_tbAktif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            sKod = "400"
            sAciklama = Sorgu_sDil("Banka Kredileri", sDil)
            sAciklamaTR = "Banka Kredileri"
            Dataload_tbAktif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            sKod = "500"
            sAciklama = Sorgu_sDil("Sermaye Hesabý", sDil)
            sAciklamaTR = "Sermaye Hesabý"
            Dataload_tbAktif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            'Pasifler 
            sKod = "100"
            sAciklama = Sorgu_sDil("Kasa", sDil)
            sAciklamaTR = "Kasa"
            'Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            Dataload_tbPasif(tarih1, tarih2, "SET dateformat dmy SELECT '" & sKod & "' AS sHesap,'" & sKod & "' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbNakitKasa.lTahsilTutar) AS lBorcTutar, SUM(tbNakitKasa.lTediyeTutar) AS lAlacakTutar, SUM(tbNakitKasa.lTahsilTutar - tbNakitKasa.lTediyeTutar) AS lBakiye, SUM(tbNakitKasa.lTahsilTutar - tbNakitKasa.lTediyeTutar) AS lTutar, 1 AS nDurum FROM tbNakitKasa INNER JOIN tbSubeMagaza ON tbNakitKasa.sSube = tbSubeMagaza.sSubeMagaza WHERE tbNakitKasa.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' ")
            sKod = "101"
            sAciklama = Sorgu_sDil("Alýnan Çekler", sDil)
            sAciklamaTR = "Alýnan Çekler"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' sHesap, '" & sKod & "' as sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, 0 AS lBorcTutar, SUM(tbCekSenet.lTutar) AS lAlacakTutar, 0 AS lBakiye, SUM(tbCekSenet.lTutar) AS lTutar,1 AS nDurum FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem WHERE (tbCekSenet.sCekSenetTipi = 'AC') AND (tbCekSenet.dteVadeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbCekSenet.lCekSenetNo BETWEEN '0' AND '999999999') AND (tbCekSenet.sOrjinalCekSenetNo BETWEEN '' AND 'zzzzzzzzz') AND (tbCekSenetBordro.nCekSenetIslem IN (1,6)) ")
            sKod = "102-108"
            sAciklama = Sorgu_sDil("Banka", sDil)
            sAciklamaTR = "Banka"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu  like '102%' or tbFirma.sKodu  like '108%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            sKod = "120"
            sAciklama = Sorgu_sDil("Alýcýlar", sDil)
            sAciklamaTR = "Alýcýlar"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            sKod = "121"
            sAciklama = Sorgu_sDil("Alacak Senetleri", sDil)
            sAciklamaTR = "Alacak Senetleri"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' sHesap, '" & sKod & "' as sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, 0 AS lBorcTutar, SUM(tbCekSenet.lTutar) AS lAlacakTutar, 0 AS lBakiye, SUM(tbCekSenet.lTutar) AS lTutar,1 AS nDurum FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem WHERE (tbCekSenet.sCekSenetTipi = 'AS') AND (tbCekSenet.dteVadeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbCekSenet.lCekSenetNo BETWEEN '0' AND '999999999') AND (tbCekSenet.sOrjinalCekSenetNo BETWEEN '' AND 'zzzzzzzzz') AND (tbCekSenetBordro.nCekSenetIslem IN (1,6)) ")
            sKod = "127"
            sAciklama = Sorgu_sDil("Alýnan Ödeme Emirleri", sDil)
            sAciklamaTR = "Alýnan Ödeme Emirleri"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            sKod = "128"
            sAciklama = Sorgu_sDil("Þüpheli Alacaklar", sDil)
            sAciklamaTR = "Þüpheli Alacaklar"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            sKod = "131"
            sAciklama = Sorgu_sDil("Ortaklardan Alacaklar", sDil)
            sAciklamaTR = "Ortaklardan Alacaklar"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            sKod = "135"
            sAciklama = Sorgu_sDil("Personelden Alacaklar", sDil)
            sAciklamaTR = "Personelden Alacaklar"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            sKod = "136"
            sAciklama = Sorgu_sDil("Diðer Çeþitli Alacaklar", sDil)
            sAciklamaTR = "Diðer Çeþitli Alacaklar"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            sAciklama = Sorgu_sDil("Kredili Alacaklar", sDil)
            sAciklamaTR = "Müþterilerden Alacaklar"
            Dataload_tbPasif(tarih1, tarih2, "set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, COUNT(DISTINCT nMusteriID) AS Sayi, SUM(Tutar) AS lBorcTutar,0 as lAlacakTutar,SUM(Tutar) AS lBakiye,SUM(Tutar) AS lTutar,1 AS nDurum FROM (SELECT nMusteriID , ISNULL(SUM(Tutar) , 0) AS Tutar FROM (SELECT tbMusteri.nMusteriID ,  isnull((isnull(SUM(tbTaksit.lTutari) , 0) - isnull(SUM(Odeme) , 0)) , 0) AS Tutar FROM tbMusteri , tbAlisVeris , tbTaksit LEFT OUTER JOIN (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme WHERE dteOdemeTarihi <= '" & tarih2 & "' GROUP BY nTaksitId) tbOdeme ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND tbAlisVeris.dteFaturaTarihi <= '" & tarih2 & "' GROUP BY tbMusteri.nMusteriID ) tbptemp WHERE (Tutar > 0 ) GROUP BY nMusteriID ) GECIKME ")
            sKod = "153"
            sAciklama = Sorgu_sDil("Ticari Mallar", sDil)
            sAciklamaTR = "Ticari Mallar"
            'Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & "' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(lMevcut) AS lBorcTutar, SUM(lMevcut * Maliyet) AS lAlacakTutar, 0 as lBakiye,SUM(lMevcut * Maliyet) AS lTutar,1 as nDurum FROM (SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, tbSSinif1.sAciklama AS Sinif1, ((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "')) AS Maliyet, TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN (SELECT nStokID, isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS lMevcut FROM tbStokFisiDetayi WHERE tbStokFisiDetayi.dteIslemTarihi <= '" & tarih2 & "' AND tbStokFisiDetayi.sDepo IN ('D001') GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID WHERE tbStok.sKodu <> '' AND tbStok.nStokTipi < 5 AND (tbStok.sKodu LIKE '" & sKod & "%') AND (TempMevcut.lMevcut > 0)) tbStoklar ")
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & "' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(lMevcut) AS lBorcTutar, SUM(lMevcut * Maliyet) AS lAlacakTutar, 0 as lBakiye,SUM(lMevcut * Maliyet) AS lTutar,1 as nDurum FROM (SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, tbSSinif1.sAciklama AS Sinif1, ((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "')) AS Maliyet, TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN (SELECT nStokID, isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS lMevcut FROM tbStokFisiDetayi WHERE tbStokFisiDetayi.dteIslemTarihi <= '" & tarih2 & "'  GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID WHERE tbStok.sKodu <> '' AND tbStok.nStokTipi < 5  AND (TempMevcut.lMevcut > 0)) tbStoklar ")
            sKod = "170"
            sAciklama = Sorgu_sDil("Yýllara Yaygýn Ýnþ.ve Onarým Maliyetleri", sDil)
            sAciklamaTR = "Yýllara Yaygýn Ýnþ.ve Onarým Maliyetleri"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            sKod = "180"
            sAciklama = Sorgu_sDil("Gelecek Aylara Ait Giderler", sDil)
            sAciklamaTR = "Gelecek Aylara Ait Giderler"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            sKod = "196"
            sAciklama = Sorgu_sDil("Personel Avanslarý", sDil)
            sAciklamaTR = "Personel Avanslarý"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            sKod = "236"
            sAciklama = Sorgu_sDil("Diðer Çeþitli Alacaklar", sDil)
            sAciklamaTR = "Diðer Çeþitli Alacaklar"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            sKod = "250"
            sAciklama = Sorgu_sDil("Arazi ve Arsalar", sDil)
            sAciklamaTR = "Arazi ve Arsalar"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            sKod = "252"
            sAciklama = Sorgu_sDil("Binalar", sDil)
            sAciklamaTR = "Binalar"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            sKod = "253"
            sAciklama = Sorgu_sDil("Tesis. Makina ve Cihazlar", sDil)
            sAciklamaTR = "Tesis. Makina ve Cihazlar"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            sKod = "254"
            sAciklama = Sorgu_sDil("Taþýtlar", sDil)
            sAciklamaTR = "Taþýtlar"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            sKod = "255"
            sAciklama = Sorgu_sDil("Demirbaþlar", sDil)
            sAciklamaTR = "Demirbaþlar"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            sKod = "257"
            sAciklama = Sorgu_sDil("Birikmiþ Amortismanlar", sDil)
            sAciklamaTR = "Birikmiþ Amortismanlar"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")

        ElseIf sec_detay.Text = "Detayli" Then
            sKod = "103"
            sAciklama = Sorgu_sDil("Verilen Çekler", sDil)
            sAciklamaTR = "Verilen Çekler"
            Dataload_tbAktif(tarih1, tarih2, "set dateformat dmy SELECT '" & sKod & "' sHesap, '" & sKod & "' as sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, 0 AS lBorcTutar, SUM(tbCekSenet.lTutar) AS lAlacakTutar, 0 AS lBakiye, SUM(tbCekSenet.lTutar) AS lTutar,1 AS nDurum FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem WHERE (tbCekSenet.sCekSenetTipi = 'BC') AND (tbCekSenet.dteVadeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbCekSenet.lCekSenetNo BETWEEN '0' AND '999999999') AND (tbCekSenet.sOrjinalCekSenetNo BETWEEN '' AND 'zzzzzzzzz') AND (tbCekSenetBordro.nCekSenetIslem IN (20)) UNION ALL SELECT '" & sKod & "' sHesap, VEREN.sKodu, VEREN.sAciklama as sAciklamaTR, VEREN.sOzelNOT sAciklama, 0 AS lBorcTutar, SUM(tbCekSenet.lTutar) AS lAlacakTutar, SUM(tbCekSenet.lTutar) AS lBakiye, 0 as lTutar,2 AS nDurum FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem WHERE (tbCekSenet.sCekSenetTipi = 'BC') AND (tbCekSenet.dteVadeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbCekSenet.lCekSenetNo BETWEEN '0' AND '999999999') AND (tbCekSenet.sOrjinalCekSenetNo BETWEEN '' AND 'zzzzzzzzz') AND (tbCekSenetBordro.nCekSenetIslem IN (20)) GROUP BY VEREN.sKodu, VEREN.sAciklama,VEREN.sOzelNot")
            sKod = "320"
            sAciklama = Sorgu_sDil("Satýcý Firma Hesaplarý", sDil)
            sAciklamaTR = "Satýcý Firma Hesaplarý"
            Dataload_tbAktif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT SUBSTRING(tbFirma.sKodu, 1, 3) AS sHesap, tbFirma.sKodu, tbFirma.sAciklama as sAciklamaTR,tbFirma.sOzelNot as sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS lBakiye, 0 as lTutar, 2 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirma.sKodu, tbFirma.sAciklama,tbFirma.sOzelNot ORDER BY sKodu,sAciklamaTR")
            sKod = "321"
            sAciklama = Sorgu_sDil("Borç Senetleri", sDil)
            sAciklamaTR = "Borç Senetleri"
            Dataload_tbAktif(tarih1, tarih2, "SELECT '" & sKod & "' sHesap, '" & sKod & "' as sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, 0 AS lBorcTutar, SUM(tbCekSenet.lTutar) AS lAlacakTutar, 0 AS lBakiye, SUM(tbCekSenet.lTutar) AS lTutar,1 AS nDurum FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem WHERE (tbCekSenet.sCekSenetTipi = 'BS') AND (tbCekSenet.dteVadeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbCekSenet.lCekSenetNo BETWEEN '0' AND '999999999') AND (tbCekSenet.sOrjinalCekSenetNo BETWEEN '' AND 'zzzzzzzzz') AND (tbCekSenetBordro.nCekSenetIslem IN (20)) UNION ALL SELECT '" & sKod & "' sHesap, VEREN.sKodu, VEREN.sAciklama as sAciklamaTR,VEREN.sOzelNot sAciklama, 0 AS lBorcTutar, SUM(tbCekSenet.lTutar) AS lAlacakTutar, SUM(tbCekSenet.lTutar) AS lBakiye, 0 as lTutar,2 AS nDurum FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem WHERE (tbCekSenet.sCekSenetTipi = 'BS') AND (tbCekSenet.dteVadeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbCekSenet.lCekSenetNo BETWEEN '0' AND '999999999') AND (tbCekSenet.sOrjinalCekSenetNo BETWEEN '' AND 'zzzzzzzzz') AND (tbCekSenetBordro.nCekSenetIslem IN (20)) GROUP BY VEREN.sKodu, VEREN.sAciklama,VEREN.sOzelNot")
            sKod = "331"
            sAciklama = Sorgu_sDil("Ortaklara Borçlar", sDil)
            sAciklamaTR = "Ortaklara Borçlar"
            Dataload_tbAktif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT SUBSTRING(tbFirma.sKodu, 1, 3) AS sHesap, tbFirma.sKodu, tbFirma.sAciklama as sAciklamaTR,tbFirma.sOzelNot as sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS lBakiye, 0 as lTutar, 2 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirma.sKodu, tbFirma.sAciklama,tbFirma.sOzelNot ORDER BY sKodu,sAciklamaTR")
            sKod = "335"
            sAciklama = Sorgu_sDil("Personele Borçlar", sDil)
            sAciklamaTR = "Personele Borçlar"
            Dataload_tbAktif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT SUBSTRING(tbFirma.sKodu, 1, 3) AS sHesap, tbFirma.sKodu, tbFirma.sAciklama as sAciklamaTR,tbFirma.sOzelNot as sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS lBakiye, 0 as lTutar, 2 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirma.sKodu, tbFirma.sAciklama,tbFirma.sOzelNot ORDER BY sKodu,sAciklamaTR")
            sKod = "336"
            sAciklama = Sorgu_sDil("Diðer Çesitli Borçlar", sDil)
            sAciklamaTR = "Diðer Çeþitli Borçlar"
            Dataload_tbAktif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT SUBSTRING(tbFirma.sKodu, 1, 3) AS sHesap, tbFirma.sKodu, tbFirma.sAciklama as sAciklamaTR,tbFirma.sOzelNot as sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS lBakiye, 0 as lTutar, 2 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirma.sKodu, tbFirma.sAciklama,tbFirma.sOzelNot ORDER BY sKodu,sAciklamaTR")
            sKod = "339"
            sAciklama = Sorgu_sDil("Diðer Çeþitli Borçlar #", sDil)
            sAciklamaTR = "Diðer Çeþitli Borçlar"
            Dataload_tbAktif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT SUBSTRING(tbFirma.sKodu, 1, 3) AS sHesap, tbFirma.sKodu, tbFirma.sAciklama as sAciklamaTR,tbFirma.sOzelNot as sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS lBakiye, 0 as lTutar, 2 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirma.sKodu, tbFirma.sAciklama,tbFirma.sOzelNot ORDER BY sKodu,sAciklamaTR")
            sKod = "400"
            sAciklama = Sorgu_sDil("Banka Kredileri", sDil)
            sAciklamaTR = "Banka Kredileri"
            Dataload_tbAktif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT SUBSTRING(tbFirma.sKodu, 1, 3) AS sHesap, tbFirma.sKodu, tbFirma.sAciklama as sAciklamaTR,tbFirma.sOzelNot as sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS lBakiye, 0 as lTutar, 2 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirma.sKodu, tbFirma.sAciklama,tbFirma.sOzelNot ORDER BY sKodu,sAciklamaTR")
            sKod = "500"
            sAciklama = Sorgu_sDil("Sermaye Hesabý", sDil)
            sAciklamaTR = "Sermaye Hesabý"
            Dataload_tbAktif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT SUBSTRING(tbFirma.sKodu, 1, 3) AS sHesap, tbFirma.sKodu, tbFirma.sAciklama as sAciklamaTR,tbFirma.sOzelNot as sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS lBakiye, 0 as lTutar, 2 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirma.sKodu, tbFirma.sAciklama,tbFirma.sOzelNot ORDER BY sKodu,sAciklamaTR")
            'Pasifler 
            sKod = "100"
            sAciklama = Sorgu_sDil("Kasa", sDil)
            sAciklamaTR = "Kasa"
            'Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT SUBSTRING(tbFirma.sKodu, 1, 3) AS sHesap, tbFirma.sKodu, tbFirma.sAciklama as sAciklamaTR,tbFirma.sOzelNot as sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lBakiye, 0 as lTutar, 2 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirma.sKodu, tbFirma.sAciklama,tbFirma.sOzelNot ORDER BY tbFirma.sKodu, tbFirma.sAciklama")
            Dataload_tbPasif(tarih1, tarih2, "SET dateformat dmy SELECT '" & sKod & "' AS sHesap,'" & sKod & "' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbNakitKasa.lTahsilTutar) AS lBorcTutar, SUM(tbNakitKasa.lTediyeTutar) AS lAlacakTutar, SUM(tbNakitKasa.lTahsilTutar - tbNakitKasa.lTediyeTutar) AS lBakiye, SUM(tbNakitKasa.lTahsilTutar - tbNakitKasa.lTediyeTutar) AS lTutar, 1 AS nDurum FROM tbNakitKasa INNER JOIN tbSubeMagaza ON tbNakitKasa.sSube = tbSubeMagaza.sSubeMagaza WHERE tbNakitKasa.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' UNION ALL SELECT '100-' + tbNakitKasa.sSube AS sHesap,'100-' + tbNakitKasa.sSube AS sKodu, tbSubeMagaza.sAciklama sAciklamaTR, N'" & sAciklama & "'  sAciklama,SUM(tbNakitKasa.lTahsilTutar) AS lBorcTutar, SUM(tbNakitKasa.lTediyeTutar) AS lAlacakTutar, SUM(tbNakitKasa.lTahsilTutar - tbNakitKasa.lTediyeTutar) AS lBakiye, 0 AS lTutar, 2 AS nDurum FROM tbNakitKasa INNER JOIN tbSubeMagaza ON tbNakitKasa.sSube = tbSubeMagaza.sSubeMagaza WHERE tbNakitKasa.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY tbNakitKasa.sSube,tbSubeMagaza.sAciklama ORDER BY sKodu, sAciklama")
            sKod = "101"
            sAciklama = Sorgu_sDil("Alýnan Çekler", sDil)
            sAciklamaTR = "Alýnan Çekler"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' sHesap, '" & sKod & "' as sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, 0 AS lBorcTutar, SUM(tbCekSenet.lTutar) AS lAlacakTutar, 0 AS lBakiye, SUM(tbCekSenet.lTutar) AS lTutar,1 AS nDurum FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem WHERE (tbCekSenet.sCekSenetTipi = 'AC') AND (tbCekSenet.dteVadeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbCekSenet.lCekSenetNo BETWEEN '0' AND '999999999') AND (tbCekSenet.sOrjinalCekSenetNo BETWEEN '' AND 'zzzzzzzzz') AND (tbCekSenetBordro.nCekSenetIslem IN (1,6)) UNION ALL SELECT '" & sKod & "' sHesap, VEREN.sKodu, VEREN.sAciklama as sAciklamaTR,VEREN.sOzelNot as sAciklama, 0 AS lBorcTutar, SUM(tbCekSenet.lTutar) AS lAlacakTutar, SUM(tbCekSenet.lTutar) AS lBakiye, 0 as lTutar,2 AS nDurum FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem WHERE (tbCekSenet.sCekSenetTipi = 'AC') AND (tbCekSenet.dteVadeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbCekSenet.lCekSenetNo BETWEEN '0' AND '999999999') AND (tbCekSenet.sOrjinalCekSenetNo BETWEEN '' AND 'zzzzzzzzz') AND (tbCekSenetBordro.nCekSenetIslem IN (1,6)) GROUP BY VEREN.sKodu, VEREN.sAciklama,VEREN.sOzelNot")
            sKod = "108"
            sAciklama = Sorgu_sDil("Banka", sDil)
            sAciklamaTR = "Banka"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu  like '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') ")
            sKod = "108.01"
            sAciklama = Sorgu_sDil("Banka Magaza", sDil)
            sAciklamaTR = "Banka Magaza"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT SUBSTRING(tbFirma.sKodu, 1, 3) AS sHesap, tbFirma.sKodu, tbFirma.sAciklama as sAciklamaTR,tbFirma.sOzelNot as sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lBakiye, 0 as lTutar, 2 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirma.sKodu, tbFirma.sAciklama,tbFirma.sOzelNot ORDER BY  sKodu,sAciklamaTR")
            sKod = "108.02"
            sAciklama = Sorgu_sDil("Banka Ýnþaat", sDil)
            sAciklamaTR = "Banka Ýnþaat"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT SUBSTRING(tbFirma.sKodu, 1, 3) AS sHesap, tbFirma.sKodu, tbFirma.sAciklama as sAciklamaTR,tbFirma.sOzelNot as sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lBakiye, 0 as lTutar, 2 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirma.sKodu, tbFirma.sAciklama,tbFirma.sOzelNot ORDER BY  sKodu,sAciklamaTR")

            'Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT SUBSTRING(tbFirma.sKodu, 1, 3) AS sHesap, tbFirma.sKodu, tbFirma.sAciklama as sAciklamaTR,tbFirma.sOzelNot as sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lBakiye, 0 as lTutar, 2 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirma.sKodu, tbFirma.sAciklama,tbFirma.sOzelNot ORDER BY  sKodu,sAciklamaTR")

            sKod = "120"
            sAciklama = Sorgu_sDil("Alýcýlar", sDil)
            sAciklamaTR = "Alýcýlar"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT SUBSTRING(tbFirma.sKodu, 1, 3) AS sHesap, tbFirma.sKodu, tbFirma.sAciklama as sAciklamaTR,tbFirma.sOzelNot as sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lBakiye, 0 as lTutar, 2 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirma.sKodu, tbFirma.sAciklama,tbFirma.sOzelNot ORDER BY sKodu,sAciklamaTR")
            sKod = "121"
            sAciklama = Sorgu_sDil("Alacak Senetleri", sDil)
            sAciklamaTR = "Alacak Senetleri"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' sHesap, '" & sKod & "' as sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, 0 AS lBorcTutar, SUM(tbCekSenet.lTutar) AS lAlacakTutar, 0 AS lBakiye, SUM(tbCekSenet.lTutar) AS lTutar,1 AS nDurum FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem WHERE (tbCekSenet.sCekSenetTipi = 'AS') AND (tbCekSenet.dteVadeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbCekSenet.lCekSenetNo BETWEEN '0' AND '999999999') AND (tbCekSenet.sOrjinalCekSenetNo BETWEEN '' AND 'zzzzzzzzz') AND (tbCekSenetBordro.nCekSenetIslem IN (1,6)) UNION ALL SELECT '" & sKod & "' sHesap, VEREN.sKodu, VEREN.sAciklama as sAciklamaTR,VEREN.sOzelNot as sAciklama, 0 AS lBorcTutar, SUM(tbCekSenet.lTutar) AS lAlacakTutar, SUM(tbCekSenet.lTutar) AS lBakiye, 0 as lTutar,2 AS nDurum FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem WHERE (tbCekSenet.sCekSenetTipi = 'AS') AND (tbCekSenet.dteVadeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbCekSenet.lCekSenetNo BETWEEN '0' AND '999999999') AND (tbCekSenet.sOrjinalCekSenetNo BETWEEN '' AND 'zzzzzzzzz') AND (tbCekSenetBordro.nCekSenetIslem IN (1,6)) GROUP BY VEREN.sKodu, VEREN.sAciklama,VEREN.sOzelNot")
            sKod = "127"
            sAciklama = Sorgu_sDil("Alýnan Ödeme Emirleri", sDil)
            sAciklamaTR = "Alýnan Ödeme Emirleri"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT SUBSTRING(tbFirma.sKodu, 1, 3) AS sHesap, tbFirma.sKodu, tbFirma.sAciklama as sAciklamaTR,tbFirma.sOzelNot as sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lBakiye, 0 as lTutar, 2 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirma.sKodu, tbFirma.sAciklama,tbFirma.sOzelNot ORDER BY  sKodu,sAciklamaTR")
            sKod = "128"
            sAciklama = Sorgu_sDil("Þüpheli Alacaklar", sDil)
            sAciklamaTR = "Þüpheli Alacaklar"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT SUBSTRING(tbFirma.sKodu, 1, 3) AS sHesap, tbFirma.sKodu, tbFirma.sAciklama as sAciklamaTR,tbFirma.sOzelNot as sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lBakiye, 0 as lTutar, 2 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirma.sKodu, tbFirma.sAciklama,tbFirma.sOzelNot ORDER BY  sKodu,sAciklamaTR")
            sKod = "131"
            sAciklama = Sorgu_sDil("Ortaklardan Alacaklar", sDil)
            sAciklamaTR = "Ortaklardan Alacaklar"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT SUBSTRING(tbFirma.sKodu, 1, 3) AS sHesap, tbFirma.sKodu, tbFirma.sAciklama as sAciklamaTR,tbFirma.sOzelNot as sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lBakiye, 0 as lTutar, 2 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirma.sKodu, tbFirma.sAciklama,tbFirma.sOzelNot ORDER BY sKodu,sAciklamaTR")
            sKod = "136"
            sAciklama = Sorgu_sDil("Diðer Çeþitli Alacaklar", sDil)
            sAciklamaTR = "Diðer Çeþitli Alacaklar"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT SUBSTRING(tbFirma.sKodu, 1, 3) AS sHesap, tbFirma.sKodu, tbFirma.sAciklama as sAciklamaTR,tbFirma.sOzelNot as sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lBakiye, 0 as lTutar, 2 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirma.sKodu, tbFirma.sAciklama,tbFirma.sOzelNot ORDER BY sKodu,sAciklamaTR")
            sAciklama = Sorgu_sDil("Kredili Alacaklar", sDil)
            sAciklamaTR = "Müþterilerden Alacaklar"
            Dataload_tbPasif(tarih1, tarih2, "set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, COUNT(DISTINCT nMusteriID) AS Sayi, SUM(Tutar) AS lBorcTutar,0 as lAlacakTutar,SUM(Tutar) AS lBakiye,SUM(Tutar) AS lTutar,1 AS nDurum FROM (SELECT nMusteriID , ISNULL(SUM(Tutar) , 0) AS Tutar FROM (SELECT tbMusteri.nMusteriID ,  isnull((isnull(SUM(tbTaksit.lTutari) , 0) - isnull(SUM(Odeme) , 0)) , 0) AS Tutar FROM tbMusteri , tbAlisVeris , tbTaksit LEFT OUTER JOIN (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme WHERE dteOdemeTarihi <= '" & tarih2 & "' GROUP BY nTaksitId) tbOdeme ON tbOdeme.nTaksitID = tbTaksit.nTaksitID WHERE tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID AND tbAlisVeris.nMusteriID = tbMusteri.nMusteriID AND tbAlisVeris.dteFaturaTarihi <= '" & tarih2 & "' GROUP BY tbMusteri.nMusteriID ) tbptemp WHERE (Tutar > 0 ) GROUP BY nMusteriID ) GECIKME ")
            sKod = "153"
            sAciklama = Sorgu_sDil("Ticari Mallar", sDil)
            sAciklamaTR = "Ticari Mallar"
            'Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & "' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(lMevcut) AS lBorcTutar, SUM(lMevcut * Maliyet) AS lAlacakTutar, 0 as lBakiye,SUM(lMevcut * Maliyet) AS lTutar,1 as nDurum FROM (SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, tbSSinif1.sAciklama AS Sinif1, ((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "')) AS Maliyet, TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN (SELECT nStokID, isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS lMevcut FROM tbStokFisiDetayi WHERE tbStokFisiDetayi.dteIslemTarihi <= '" & tarih2 & "' AND tbStokFisiDetayi.sDepo IN ('D001') GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID WHERE tbStok.sKodu <> '' AND tbStok.nStokTipi < 5 AND (tbStok.sKodu LIKE '" & sKod & "%') AND (TempMevcut.lMevcut > 0)) tbStoklar UNION ALL SELECT '" & sKod & "' AS sHesap, '" & sKod & "' AS sKodu, Sinif1 AS sAciklama, SUM(lMevcut) AS lBorcTutar, SUM(lMevcut * Maliyet) AS lAlacakTutar, SUM(lMevcut * Maliyet) AS lBakiye,0 AS lTutar,2 as nDurum FROM (SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, tbSSinif1.sAciklama AS Sinif1, ((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "')) AS Maliyet, TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN (SELECT nStokID, isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS lMevcut FROM tbStokFisiDetayi WHERE tbStokFisiDetayi.dteIslemTarihi <= '" & tarih2 & "' AND tbStokFisiDetayi.sDepo IN ('D001') GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID WHERE tbStok.sKodu <> '' AND tbStok.nStokTipi < 5 AND (tbStok.sKodu LIKE '" & sKod & "%') AND (TempMevcut.lMevcut > 0)) tbStoklar GROUP BY Sinif1")
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & "' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(lMevcut) AS lBorcTutar, SUM(lMevcut * Maliyet) AS lAlacakTutar, 0 as lBakiye,SUM(lMevcut * Maliyet) AS lTutar,1 as nDurum FROM (SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, tbSSinif1.sAciklama AS Sinif1, ((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "')) AS Maliyet, TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN (SELECT nStokID, isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS lMevcut FROM tbStokFisiDetayi WHERE tbStokFisiDetayi.dteIslemTarihi <= '" & tarih2 & "'  GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID WHERE tbStok.sKodu <> '' AND tbStok.nStokTipi < 5  AND (TempMevcut.lMevcut > 0)) tbStoklar UNION ALL SELECT '" & sKod & "' AS sHesap, '" & sKod & "' AS sKodu, Sinif1 AS sAciklamaTR,'' sAciklama, SUM(lMevcut) AS lBorcTutar, SUM(lMevcut * Maliyet) AS lAlacakTutar, SUM(lMevcut * Maliyet) AS lBakiye,0 AS lTutar,2 as nDurum FROM (SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, tbSSinif1.sAciklama AS Sinif1, ((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "')) AS Maliyet, TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN (SELECT nStokID, isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS lMevcut FROM tbStokFisiDetayi WHERE tbStokFisiDetayi.dteIslemTarihi <= '" & tarih2 & "'  GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID WHERE tbStok.sKodu <> '' AND tbStok.nStokTipi < 5  AND (TempMevcut.lMevcut > 0)) tbStoklar GROUP BY Sinif1")
            sKod = "196"
            sAciklama = Sorgu_sDil("Personel Avanslarý", sDil)
            sAciklamaTR = "Personel Avanslarý"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT SUBSTRING(tbFirma.sKodu, 1, 3) AS sHesap, tbFirma.sKodu, tbFirma.sAciklama as sAciklamaTR,tbFirma.sOzelNot as sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lBakiye, 0 as lTutar, 2 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirma.sKodu, tbFirma.sAciklama,tbFirma.sOzelNot ORDER BY sKodu,sAciklamaTR")
            sKod = "250"
            sAciklama = Sorgu_sDil("Arazi ve Arsalar", sDil)
            sAciklamaTR = "Arazi ve Arsalar"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT SUBSTRING(tbFirma.sKodu, 1, 3) AS sHesap, tbFirma.sKodu, tbFirma.sAciklama as sAciklamaTR,tbFirma.sOzelNot as sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lBakiye, 0 as lTutar, 2 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirma.sKodu, tbFirma.sAciklama,tbFirma.sOzelNot ORDER BY sKodu,sAciklamaTR")
            sKod = "252"
            sAciklama = Sorgu_sDil("Binalar", sDil)
            sAciklamaTR = "Binalar"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT SUBSTRING(tbFirma.sKodu, 1, 3) AS sHesap, tbFirma.sKodu, tbFirma.sAciklama as sAciklamaTR,tbFirma.sOzelNot as sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lBakiye, 0 as lTutar, 2 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirma.sKodu, tbFirma.sAciklama,tbFirma.sOzelNot ORDER BY sKodu,sAciklamaTR")
            sKod = "253"
            sAciklama = Sorgu_sDil("Tesis. Makina ve Cihazlar", sDil)
            sAciklamaTR = "Tesis. Makina ve Cihazlar"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT SUBSTRING(tbFirma.sKodu, 1, 3) AS sHesap, tbFirma.sKodu, tbFirma.sAciklama as sAciklamaTR,tbFirma.sOzelNot as sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lBakiye, 0 as lTutar, 2 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirma.sKodu, tbFirma.sAciklama,tbFirma.sOzelNot ORDER BY sKodu,sAciklamaTR")
            sKod = "254"
            sAciklama = Sorgu_sDil("Taþýtlar", sDil)
            sAciklamaTR = "Taþýtlar"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT SUBSTRING(tbFirma.sKodu, 1, 3) AS sHesap, tbFirma.sKodu, tbFirma.sAciklama as sAciklamaTR,tbFirma.sOzelNot as sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lBakiye, 0 as lTutar, 2 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirma.sKodu, tbFirma.sAciklama,tbFirma.sOzelNot ORDER BY sKodu,sAciklamaTR")
            sKod = "255"
            sAciklama = Sorgu_sDil("Demirbaþlar", sDil)
            sAciklamaTR = "Demirbaþlar"
            Dataload_tbPasif(tarih1, tarih2, "SELECT '" & sKod & "' AS sHesap, '" & sKod & " ' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, 0 AS lBakiye,SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lTutar, 1 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT SUBSTRING(tbFirma.sKodu, 1, 3) AS sHesap, tbFirma.sKodu, tbFirma.sAciklama as sAciklamaTR,tbFirma.sOzelNot as sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lBakiye, 0 as lTutar, 2 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirma.sKodu LIKE '" & sKod & "%') AND (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') GROUP BY tbFirma.sKodu, tbFirma.sAciklama,tbFirma.sOzelNot ORDER BY sKodu,sAciklamaTR")
        End If
    End Sub
    Public Sub Dataload_tbAktif(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sQuery As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query(sQuery)
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbAktif, "tbAktif")
        conn.Close()
    End Sub
    Public Sub Dataload_tbPasif(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sQuery As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query(sQuery)
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbPasif, "tbPasif")
        conn.Close()
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        raporla_excel()
    End Sub
    Private Sub raporla_excel()
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Bilanço Aktiflerine Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
                SaveFileDialog1.InitialDirectory = "c:\"
                SaveFileDialog1.FileName = "BilançoAktif.xls"
                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                End If
            End If
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            If XtraMessageBox.Show(Sorgu_sDil("Bilanço Pasiflerine Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
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
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Text Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
                SaveFileDialog1.Filter = "Text Dosyalarý(*.txt) |*.txt"
                SaveFileDialog1.InitialDirectory = "c:\"
                SaveFileDialog1.FileName = "Rapor.txt"
                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    GridView2.ExportToText(SaveFileDialog1.FileName.ToString)
                    If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        Process.Start(SaveFileDialog1.FileName.ToString)
                    End If
                End If
                SaveFileDialog1 = Nothing
            End If
        End If
    End Sub
    Private Sub raporla_pdf()
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
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
        ElseIf XtraTabControl1.SelectedTabPageIndex = 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Metin Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
                SaveFileDialog1.Filter = "Metin Dosyalarý(*.pdf) |*.pdf"
                SaveFileDialog1.InitialDirectory = "c:\"
                SaveFileDialog1.FileName = "Rapor.pdf"
                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    GridView2.ExportToPdf(SaveFileDialog1.FileName.ToString)
                    If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        Process.Start(SaveFileDialog1.FileName.ToString)
                    End If
                End If
                SaveFileDialog1 = Nothing
            End If
        End If
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
            printlink1.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            printlink2.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        End If
    End Sub
    Private Sub raporla_faaliyet(ByVal rapor As Integer, ByVal nislem As Integer, Optional ByVal bTumu As Boolean = False)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyalarý (FormBilanco*.fr*) |FormBilanco*.fr*"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\NakitKasa\FormBilanco" & sRaporUzanti & ""
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\NakitKasa"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Microsoft.VisualBasic.Right(sFile, 3) = "frx" Then
                Dim report As New FastReport.Report
                report.Load(sFile)
                report.RegisterData(ds_tbParamGenel)
                report.RegisterData(ds_tbAktif)
                report.RegisterData(ds_tbPasif)
                report.SetParameterValue("dteIslemTarihi1", DateEdit1.EditValue)
                report.SetParameterValue("dteIslemTarihi2", DateEdit2.EditValue)
                'report.SetParameterValue("sMagaza", txt_sMagaza.Text)
                report.ScriptLanguage = Language.Vb
                If nislem = 0 Then
                    report.Show()
                ElseIf nislem = 2 Then
                    report.Design()
                ElseIf nislem = 1 Then
                    report.Print()
                End If
                report.Dispose()
                report = Nothing
                'ElseIf Microsoft.VisualBasic.Right(sFile, 3) = "fr3" Then
                '    report_create_stok(sFile, " WHERE nKasaIslemID = " & dr("nKasaIslemID") & "", nislem, dr("lTahsilTutar"), dr("lTediyeTutar"))
            End If
        End If
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gorunum_yazdir()
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
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        dataload(DateEdit1.EditValue, DateEdit2.EditValue)
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
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        raporla_faaliyet(0, 0)
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        raporla_faaliyet(0, 2)
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        raporla_faaliyet(0, 1)
    End Sub
End Class