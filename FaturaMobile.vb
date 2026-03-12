Imports FastReport
Imports Microsoft.Win32
Imports System.IO
Public Class MobileFatura
    Public firmano_MobileFatura
    Public donemno_MobileFatura
    Public connection_MobileFatura
    Dim dataset1_MobileFatura As DataSet
    Public DataSet2_MobileFatura As DataSet
    Dim IstekRapor_MobileFatura As Integer = 0
    Public s_nIslemID As String = ""
    Dim sorgu_txt_baslik As String = ""
    Dim sorgu_txt_hareket As String = ""
    Dim sorgu_txt_toplam As String = ""
    Dim IstekFisNo As String
    Dim sFiyatTipi As String = "1"
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim dataset1_MobileFaaliyet As DataSet
    Public Sub OtoFaturaThread_MobileFatura()
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        Dim trd As Threading.Thread
        trd = New Threading.Thread(AddressOf OtoFaturaOlustur_MobileFatura)
        trd.IsBackground = True
        trd.Start()
    End Sub
    Private Sub FaturaDurumDegistir_MobileFatura(ByVal eskiDurum As Integer, ByVal yeniDurum As Integer, ByVal IstekID As String, ByVal olusturmaTarihi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_MobileFatura
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            If Trim(olusturmaTarihi) = "" Then
                cmd.CommandText = sorgu_query_MobileFatura("SET DATEFORMAT DMY Update FaturaMobile Set IstekDurum = " & yeniDurum & " WHERE (IstekDurum = " & eskiDurum & ") AND (id = '" & IstekID & "')")
            Else
                cmd.CommandText = sorgu_query_MobileFatura("SET DATEFORMAT DMY Update FaturaMobile Set IstekDurum = " & yeniDurum & ", RaporOlusturmaTarihi = GetDate() WHERE (IstekDurum = " & eskiDurum & ") AND (id = '" & IstekID & "')")
            End If
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Function sorgu_query_MobileFatura(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano_MobileFatura.ToString)
        query = Replace(query, "!D", "D000" + donemno_MobileFatura.ToString)
        Return query
    End Function
    Private Sub OtoFaturaOlustur_MobileFatura()
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim IstekTarihi As String = ""
        Dim IstekID As String = ""
        Dim IstekFisNo As String = ""
        Dim IstekTarihiDate As Date
        cmd.Connection = con
        con.ConnectionString = connection_MobileFatura
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            cmd.CommandText = sorgu_query_MobileFatura("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  top 1 ISNULL(IstekTarihi, '') FROM FaturaMobile WHERE (IstekDurum = 0) Order By IstekTarihi Desc ")
            IstekTarihi = cmd.ExecuteScalar.ToString()
            cmd.CommandText = sorgu_query_MobileFatura("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  top 1 ISNULL(IstekFisNo, '') FROM FaturaMobile WHERE (IstekDurum = 0) Order By IstekFisNo Desc ")
            IstekFisNo = cmd.ExecuteScalar.ToString()
            cmd.CommandText = sorgu_query_MobileFatura("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Top 1 ISNULL(id, 0) FROM FaturaMobile WHERE (IstekDurum = 0) Order By IstekTarihi Desc")
            IstekID = cmd.ExecuteScalar.ToString()
            cmd.CommandText = sorgu_query_MobileFatura("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Top 1 ISNULL(IstekRapor, 0) FROM FaturaMobile WHERE (id = " & IstekID & ")")
            IstekRapor_MobileFatura = Convert.ToInt32(cmd.ExecuteScalar.ToString())
        Catch ex As Exception
            IstekRapor_MobileFatura = 0
        End Try
        con.Close()
        If Trim(IstekTarihi) <> "" Then
            IstekTarihiDate = Date.Parse(IstekTarihi)
            Dim YeniTarih As String = IstekTarihiDate.Day & "." & IstekTarihiDate.Month & "." & IstekTarihiDate.Year
            If Directory.Exists("C:\xampp\htdocs\Fatura\" & YeniTarih) = True Then
                Try
                    If IstekRapor_MobileFatura = 0 Then
                        If Directory.Exists("C:\xampp\htdocs\Fatura\" & YeniTarih & "") = True Then
                            Directory.Delete("C:\xampp\htdocs\Fatura\" & YeniTarih & " ", True)
                        End If
                        Directory.CreateDirectory("C:\xampp\htdocs\Fatura\" & YeniTarih & "")
                    End If
                Catch ex As Exception
                End Try
            Else
                Try
                    Directory.CreateDirectory("C:\xampp\htdocs\Fatura\" & YeniTarih)
                    If IstekRapor_MobileFatura = 0 Then
                        Directory.CreateDirectory("C:\xampp\htdocs\Fatura\" & YeniTarih & "")

                    End If
                Catch ex As Exception
                End Try
            End If
            Try
                FaturaDurumDegistir_MobileFatura(0, 1, IstekID, "")
                dataload_MobileFatura(YeniTarih, IstekFisNo)
                raporla_MobileFatura(4, YeniTarih, IstekID)
            Catch ex As Exception
                FaturaDurumDegistir_MobileFatura(1, 0, IstekID, "")
            End Try
        End If
    End Sub
    Private Sub dataload_MobileFatura(ByVal tarih1 As DateTime, ByVal IstekFisNo As String)
        sorgu_baslik_MobileFatura(IstekFisNo)
        sorgu_harekets_MobileFatura(IstekFisNo) 'tamam
        sorgu_toplam_MobileFatura(IstekFisNo) 'tamam
    End Sub
    Private Sub raporla_MobileFatura(ByVal status As Integer, Optional ByVal YeniTarih As String = "", Optional ByVal IstekID As String = "")
        Dim file1 As String
        Dim ara As String
        Dim frx As New TfrxReportClass
        Dim ds As New TfrxUserDataSetClass
        Dim qr_hareket As New TfrxADOQuery
        frx.ClearReport()
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("Fast Reports").CreateSubKey("connections").SetValue("UGURLU", connection_MobileFatura)
        file1 = "c:\Formlar\Raporlar\Dokumler\Form _Mobile_Fatura.fr3"
        frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
        frx.LoadReportFromFile(file1)
        Dim str As String = ""
        Dim strArr() As String
        str = YeniTarih
        strArr = str.Split(".")
        str = strArr(0) & "/" & strArr(1) & "/" & strArr(2)
        frx.SetVariable("IstekFisNo", "'" & str & " 00:00:00'")
        ara = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Microsoft").OpenSubKey("Windows NT").OpenSubKey("CurrentVersion").OpenSubKey("Windows").GetValue("Device").ToString()
        Dim adi As String = ""
        Dim soyadi As String = ""
        Dim x
        If CStr(ara.ToString) <> "" Then
            x = (ara).IndexOf(",", 1, (ara.Length - 1))
            If x = -1 Then
                adi = ara
            Else
                adi = (ara).Substring(0, x)
                soyadi = (ara).Substring((x + 1), (ara).Length - (x + 1))
                If IsNumeric(ara) Then
                Else
                End If
            End If
        End If
        frx.PrintOptions.Printer = adi
        Try
            frx.PrepareReport(True)
            If IstekRapor_MobileFatura = 0 Then
                frx.ExportToHTML("C:\xampp\htdocs\Fatura\" & YeniTarih & "\Fatura.html", False, True, False, False, True, False)
            End If
            FaturaDurumDegistir_MobileFatura(1, 2, IstekID, "1")
        Catch ex As Exception
            FaturaDurumDegistir_MobileFatura(1, 0, IstekID, "1")
        End Try
    End Sub
    Private Function sorgu_toplam_MobileFatura(ByVal IstekFisNo As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokFisiID, lToplamMiktar, lMalBedeli, lMalIskontoTutari,CAST(0 AS money) AS nMalIskontoYuzdesi, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, CAST(0 AS money) AS nDipIskontoYuzdesi3, lDipIskontoTutari1+lDipIskontoTutari2+lDipIskontoTutari3 as lDipIskontoTutari,CAST(0 AS money) AS nDipIskontoYuzdesi,lEkmaliyet1, lEkmaliyet2, lEkmaliyet3,lEkmaliyet1+lEkmaliyet2+lEkmaliyet3 as lEkmaliyet,CAST(0 AS money) AS nEkmaliyetYuzdesi, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2, lKdv1 + lKdv2 + lKdv3 + lKdv4 + lKdv5 AS lKdv FROM tbStokFisiMaster WHERE (nStokFisiID = '" & IstekFisNo & "')")
        sorgu_txt_toplam = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        con.Close()
        Return Datastoklar1
    End Function
    Private Function sorgu_baslik_MobileFatura(ByVal IstekFisNo As String)
        If IstekRapor_MobileFatura = 0 Then
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            Dim adapter As New OleDb.OleDbDataAdapter
            Dim sFisTipi As String = ""
            con.ConnectionString = connection
            cmd.CommandTimeout = Nothing
            adapter.SelectCommand = cmd
            If Trim(sFisTipi) = "FS" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.*, DATEDIFF(day, tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.dteValorTarihi) AS nOpsiyon,tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu,tbFirma.nOzelIskontosu2,tbFirma.nOzelIskontosu3,tbFirma.nOzelIskontosu4,tbFirma.sSaticiRumuzu, tbFirma.lKrediLimiti, tbFirma.dteMutabakatTarihi, tbFirma.nVadeGun, tbFirma.sHitap, tbFirma.sAdres1, tbFirma.sAdres2, tbFirma.sSemt, tbFirma.sIl, tbFirma.sUlke, tbFirma.sPostaKodu, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirma.sFiyatTipi, tbStokFisiAciklamasi.sAciklama1, tbStokFisiAciklamasi.sAciklama2, tbStokFisiAciklamasi.sAciklama3, tbStokFisiAciklamasi.sAciklama4, tbStokFisiAciklamasi.sAciklama5,(Select nGCT from tbFisTipi Where sFisTipi = tbStokFisiMaster.sFisTipi) as nGCT,(Select ISNULL(SUM(lBorcTutar-lAlacakTutar),0) as lBakiye from tbFirmaHareketi where nFirmaID = tbFirma.nFirmaID) as lBakiye,(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS [Fax],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS [Gsm],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS [Telefon],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS [Web],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS [Yetkili],ISNULL(tbDoviz.sDovizCinsi1,'') as sDovizCinsi1,ISNULL(tbDoviz.lDovizKuru1,0) as lDovizKuru1  FROM tbStokFisiMaster INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID LEFT OUTER JOIN (SELECT     TOP 1 nStokFisiID, ISNULL(sDovizCinsi1,'') sDovizCinsi1, lDovizKuru1 FROM          tbStokFisiDetayi WHERE (nStokFisiID = '" & IstekFisNo & "') GROUP BY nStokFisiID, sDovizCinsi1, lDovizKuru1 ORDER BY sDovizCinsi1 DESC) tbDoviz ON tbStokFisiMaster.nStokFisiID = tbDoviz.nStokFisiID WHERE (tbStokFisiMaster.nStokFisiID = '" & IstekFisNo & "')")
            Else
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.*, IADEMI = CASE WHEN tbStokFisiMaster.nGirisCikis = 2 OR tbStokFisiMaster.nGirisCikis = 4 THEN 'BU BİR İADE FATURASIDIR' ELSE '' END, DATEDIFF(day, tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.dteValorTarihi) AS nOpsiyon, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.nOzelIskontosu2, tbFirma.nOzelIskontosu3, tbFirma.nOzelIskontosu4, tbFirma.sSaticiRumuzu, (SELECT nPrim FROM tbSatici WHERE sSaticiRumuzu = tbFirma.sSaticiRumuzu) AS nPrim, tbFirma.lKrediLimiti, tbFirma.dteMutabakatTarihi, tbFirma.nVadeGun, tbFirma.sHitap, tbFirma.sAdres1, tbFirma.sAdres2, tbFirma.sSemt, tbFirma.sIl, tbFirma.sUlke, tbFirma.sPostaKodu, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirma.sFiyatTipi, tbFirma.bTahsilatYapilamaz, tbStokFisiAciklamasi.sAciklama1, tbStokFisiAciklamasi.sAciklama2, tbStokFisiAciklamasi.sAciklama3, tbStokFisiAciklamasi.sAciklama4, tbStokFisiAciklamasi.sAciklama5, (Select nGCT from tbFisTipi Where sFisTipi = tbStokFisiMaster.sFisTipi) as nGCT, (Select ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) as lBakiye from tbFirmaHareketi where nFirmaID = tbFirma.nFirmaID and dteIslemTarihi <= tbStokFisiMaster.dteFisTarihi AND (nHareketID < (SELECT nCariHareketID FROM tbStokFisiOdemePlani WHERE nStokFisiID = tbStokFisiMaster.nStokFisiID))) as lEskiBakiye, (Select ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) as lBakiye from tbFirmaHareketi where nFirmaID = tbFirma.nFirmaID) as lBakiye, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail], (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS [Fax], (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS [Gsm], (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS [Telefon], (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS [Web], (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS [Yetkili], (SELECT sSinifKodu1 FROM tbFirmaSinifi WHERE nFirmaID = tbFirma.nFirmaID) AS sSinifKodu1, ISNULL(tbDoviz.sDovizCinsi1, '') as sDovizCinsi1, ISNULL(tbDoviz.lDovizKuru1, 0) as lDovizKuru1 FROM tbStokFisiMaster INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID LEFT OUTER JOIN (SELECT TOP 1 nStokFisiID, ISNULL(sDovizCinsi1, '') sDovizCinsi1, lDovizKuru1 FROM tbStokFisiDetayi WHERE (nStokFisiID = '" & IstekFisNo & "') GROUP BY nStokFisiID, sDovizCinsi1, lDovizKuru1 ORDER BY sDovizCinsi1 DESC) tbDoviz ON tbStokFisiMaster.nStokFisiID = tbDoviz.nStokFisiID WHERE (tbStokFisiMaster.nStokFisiID = '" & IstekFisNo & "')")
            End If
            sorgu_txt_baslik = cmd.CommandText
            cmd.Connection = con
            con.Open()
        End If
    End Function
    Private Function sorgu_harekets_MobileFatura(ByVal IstekFisNo As String) As DataSet
        If IstekRapor_MobileFatura = 0 Then
            Dim sFisTİpi As String
            Dim kriter As String
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            Dim adapter As New OleDb.OleDbDataAdapter
            con.ConnectionString = connection
            cmd.CommandTimeout = Nothing
            adapter.SelectCommand = cmd
            If Trim(sFisTİpi) = "FS" Then
                If s_nIslemID <> "" Then
                    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiDetayi.*, (SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAciklama,tbStok.sBirimCinsi1,tbStok.sBirimCinsi2,ISNULL((SELECT     ISNULL(lOran, 0) FROM tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,dbo.ROUNDYTL(lCikisMiktar1 / ISNULL((SELECT ISNULL(lOran, 0) FROM tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lCikisBirimMiktar , dbo.ROUNDYTL(lGirisMiktar1 / ISNULL((SELECT     ISNULL(lOran, 0) FROM  tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lGirisBirimMiktar,dbo.ROUNDYTL(tbStokFisiDetayi.lGirisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lGirisMiktar,dbo.ROUNDYTL(tbStokFisiDetayi.lCikisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lCikisMiktar,tbStok.sModel, tbStok.sBeden,tbStok.nFiyatlandirma,tbStok.nStokTipi,(Select sRenkAdi from tbRenk where sRenk = tbStok.sRenk) as sRenkAdi,(SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod,(SELECT nKdvOrani FROM  tbKdv WHERE  sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS lMaliyet,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS lAlis, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 50, 9) AS MONEY) AS nMasrafSatiri,CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL(ABS(ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0) AS lKdvTutari,dbo.ROUNDYTL(tbStokFisiDetayi.lBrutFiyat * tbStokFisiDetayi.lBirimMiktar) AS lFiyat,CAST(dbo.ROUNDYTL(tbStokFisiDetayi.lBrutFiyat*tbStokFisiDetayi.lBirimMiktar) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilFiyat,CAST(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutFiyat,CAST(tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutTutar,lDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutTutar / lDovizKuru1 ELSE lBrutTutar END, lDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN dbo.ROUNDYTL((lBrutFiyat*lBirimMiktar)) / lDovizKuru1 ELSE dbo.ROUNDYTL(lBrutFiyat*lBirimMiktar) END,lDovizBrutFiyati = CASE WHEN sDovizCinsi1  <> '' AND lDovizKuru1<> 0 THEN lBrutFiyat / lDovizKuru1 ELSE lBrutFiyat END, lDahilDovizTutar = CASE WHEN sDovizCinsi1  <> '' ANDlDovizKuru1 <> 0 THEN (lBrutTutar / lDovizKuru1) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutTutar)* (100 + tbStokFisiDetayi.nKdvOrani) / 100  END, lDahilDovizFiyati = CASE WHEN sDovizCinsi1  <> '' AND lDovizKuru1  <> 0 THEN ((lBrutFiyat*lBirimMiktar) / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE ((lBrutFiyat*lBirimMiktar))* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END,lDahilDovizBrutFiyati = CASE WHEN sDovizCinsi1  <> '' AND lDovizKuru1   <> 0 THEN (lBrutFiyat / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutFiyat)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID  WHERE (tbStokFisiDetayi.nStokFisiID ='" & IstekFisNo & "') ORDER BY tbStokFisiDetayi.nEkSaha1,tbStokFisiDetayi.nIslemID")
                Else
                    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiDetayi.*, tbSatici.sAdi + ' ' + tbSatici.sSoyadi AS sSatici,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAciklama,tbStok.sKisaAdi,tbStok.nHacim,tbStok.nAgirlik,tbStok.sBirimCinsi1,tbStok.sBirimCinsi2,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,tbStok.sKisaAdi, tbStok.sOzelNot,(lCikisMiktar1 / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lCikisBirimMiktar , (lGirisMiktar1 / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lGirisBirimMiktar,(tbStokFisiDetayi.lGirisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lGirisMiktar,(tbStokFisiDetayi.lCikisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lCikisMiktar,tbStok.sModel,tbStok.sRenk,tbStok.sBeden, tbStok.sKavala,tbStok.nFiyatlandirma,tbStok.nStokTipi,(Select sRenkAdi from tbRenk where sRenk = tbStok.sRenk) as sRenkAdi,(SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1,(SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID and nKisim = 0) AS sBarkod,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS lFiyat1,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS lFiyat2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS lFiyat3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS lFiyat4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "'),0) AS lOzelFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS lAlis,CAST(0 AS MONEY) AS ISK1, CAST(0 AS MONEY) AS ISK2, CAST(0 AS MONEY) AS ISK3, CAST(0 AS MONEY) AS ISK4,CAST(0 AS MONEY) AS ISK5,CAST(0 AS MONEY) AS ISK6,CAST(0 AS MONEY) AS ISK7,CAST(0 AS MONEY) AS ISK8, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 50, 9) AS MONEY) AS nMasrafSatiri,CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL(ABS(ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0) AS lKdvTutari,(tbStokFisiDetayi.lBrutFiyat * tbStokFisiDetayi.lBirimMiktar) AS lFiyat,CAST((tbStokFisiDetayi.lBrutFiyat*tbStokFisiDetayi.lBirimMiktar) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilFiyat,lDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutTutar / lDovizKuru1 ELSE lBrutTutar END, lDovizFiyat = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutFiyat / lDovizKuru1 ELSE lBrutFiyat END,CASE WHEN tbStokFisiDetayi.nGirisCikis = 1 OR nGirisCikis = 2 THEN tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE tbStokFisiDetayi.lCikisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 END AS lNetFiyat FROM tbStokFisiDetayi INNER JOIN tbSatici ON tbStokFisiDetayi.sSaticiRumuzu = tbSatici.sSaticiRumuzu INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID  WHERE     (tbStokFisiDetayi.nStokFisiID = '" & IstekFisNo & "') ORDER BY tbStokFisiDetayi.nEkSaha1,tbStokFisiDetayi.nIslemID")
                End If
            ElseIf Trim(sFisTİpi) = "IS" Or Trim(sFisTİpi) = "IA" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiDetayi.*, tbSatici.sAdi + ' ' + tbSatici.sSoyadi AS sSatici,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAciklama,tbStok.sKisaAdi,tbStok.nHacim,tbStok.nAgirlik,tbStok.sBirimCinsi1,tbStok.sBirimCinsi2,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,tbStok.sKisaAdi, tbStok.sOzelNot,(lCikisMiktar1 / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lCikisBirimMiktar , (lGirisMiktar1 / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lGirisBirimMiktar,(tbStokFisiDetayi.lGirisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lGirisMiktar,(tbStokFisiDetayi.lCikisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lCikisMiktar,tbStok.sModel, tbStok.sRenk,tbStok.sBeden,tbStok.sKavala,tbStok.nFiyatlandirma,tbStok.nStokTipi,(Select sRenkAdi from tbRenk where sRenk = tbStok.sRenk) as sRenkAdi,(SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1,(SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID and nKisim = 0) AS sBarkod, (SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS lFiyat1,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS lFiyat2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS lFiyat3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS lFiyat4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "'),0) AS lOzelFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS lAlis,/*CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) AS ISK1*/(CASE WHEN ISNUMERIC(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5)) = 1 THEN CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) ELSE Cast(0 as money) END) as ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, CAST(0 AS MONEY) AS ISK5,CAST(0 AS MONEY) AS ISK6,CAST(0 AS MONEY) AS ISK7,CAST(0 AS MONEY) AS ISK8,CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 50, 9) AS MONEY) AS nMasrafSatiri,CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL((ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0) AS lKdvTutari,(tbStokFisiDetayi.lBrutFiyat * tbStokFisiDetayi.lBirimMiktar) AS lFiyat,CAST((tbStokFisiDetayi.lBrutFiyat*tbStokFisiDetayi.lBirimMiktar) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilFiyat,CAST(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilBrutFiyat,CAST(tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilBrutTutar,lDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutTutar / lDovizKuru1 ELSE lBrutTutar END, lDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN ((lBrutFiyat*lBirimMiktar)) / lDovizKuru1 ELSE (lBrutFiyat*lBirimMiktar) END,lDovizBrutFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutFiyat / lDovizKuru1 ELSE lBrutFiyat END, lDahilDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutTutar / lDovizKuru1) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutTutar)* (100 + tbStokFisiDetayi.nKdvOrani) / 100  END, lDahilDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN ((lBrutFiyat*lBirimMiktar) / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE ((lBrutFiyat*lBirimMiktar))* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END,lDahilDovizBrutFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutFiyat / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutFiyat)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END,CASE WHEN tbStokFisiDetayi.nGirisCikis = 1 OR nGirisCikis = 2 THEN tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE tbStokFisiDetayi.lCikisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 END AS lNetFiyat, ISNULL((select nPartiID from tbStokFisiPartiID where tbStokFisiPartiID.nIslemIDRef = tbStokFisiDetayi.nIslemID), '') as nPartiID FROM tbStokFisiDetayi INNER JOIN tbSatici ON tbStokFisiDetayi.sSaticiRumuzu = tbSatici.sSaticiRumuzu INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID  WHERE     (tbStokFisiDetayi.nIrsaliyeFisiID = '" & IstekFisNo & "') ORDER BY tbStokFisiDetayi.nEkSaha1,tbStokFisiDetayi.nIslemID")
            Else
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiDetayi.*, tbSatici.sAdi + ' ' + tbSatici.sSoyadi AS sSatici,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAciklama,tbStok.sKisaAdi,tbStok.nHacim,tbStok.nAgirlik,tbStok.sBirimCinsi1,tbStok.sBirimCinsi2,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,tbStok.sKisaAdi, tbStok.sOzelNot, CONVERT(DECIMAL(10, 4), (lCikisMiktar1 / ISNULL((SELECT ISNULL(lOran, 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1))) as lCikisBirimMiktar, CONVERT(DECIMAL(10, 4), (lGirisMiktar1 / ISNULL((SELECT ISNULL(lOran, 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1))) as lGirisBirimMiktar, CONVERT(DECIMAL(10, 4), (tbStokFisiDetayi.lGirisMiktar1 / tbStokFisiDetayi.lBirimMiktar)) AS lGirisMiktar, CONVERT(DECIMAL(10, 4), (tbStokFisiDetayi.lCikisMiktar1 / tbStokFisiDetayi.lBirimMiktar)) AS lCikisMiktar, tbStok.sModel, tbStok.sRenk, tbStok.sBeden, tbStok.sKavala, tbStok.nFiyatlandirma, tbStok.nStokTipi, (Select sRenkAdi from tbRenk where sRenk = tbStok.sRenk) as sRenkAdi, (SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1, (SELECT TOP 1 ISNULL(sBarkod, '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID and nKisim = 0) AS sBarkod, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'), 0) AS lFiyat4, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "'), 0) AS lOzelFiyat, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS lMaliyet, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'), 0) AS lAltFiyat, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS lAlis, /* CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) AS ISK1*/(CASE WHEN ISNUMERIC(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5)) = 1 THEN CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) ELSE Cast(0 as money) END) as ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, CAST(0 AS MONEY) AS ISK5,CAST(0 AS MONEY) AS ISK6,CAST(0 AS MONEY) AS ISK7,CAST(0 AS MONEY) AS ISK8,CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 50, 9) AS MONEY) AS nMasrafSatiri,CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL((ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0) AS lKdvTutari,(tbStokFisiDetayi.lBrutFiyat * tbStokFisiDetayi.lBirimMiktar) AS lFiyat,CAST((tbStokFisiDetayi.lBrutFiyat*tbStokFisiDetayi.lBirimMiktar) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilFiyat,CAST(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilBrutFiyat,CAST(tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilBrutTutar, lDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN CONVERT(DECIMAL(10, 4), lBrutTutar / lDovizKuru1) ELSE CONVERT(DECIMAL(10, 2), lBrutTutar) END, CONVERT(DECIMAL(10, 4), CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN ((lBrutFiyat*lBirimMiktar)) / lDovizKuru1 ELSE (lBrutFiyat*lBirimMiktar) END) as lDovizFiyati, CONVERT(DECIMAL(10, 4), CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutFiyat / lDovizKuru1 ELSE lBrutFiyat END) as lDovizBrutFiyati, lDahilDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN CONVERT(DECIMAL(10, 4), (lBrutTutar / lDovizKuru1) * (100 + tbStokFisiDetayi.nKdvOrani) / 100) ELSE CONVERT(DECIMAL(10, 2), (lBrutTutar)* (100 + tbStokFisiDetayi.nKdvOrani) / 100) END, CONVERT(DECIMAL(10, 4), CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN ((lBrutFiyat*lBirimMiktar) / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE ((lBrutFiyat*lBirimMiktar))* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END) as lDahilDovizFiyati, CONVERT(DECIMAL(10, 4), CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutFiyat / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutFiyat)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END) as lDahilDovizBrutFiyati, CONVERT(DECIMAL(10, 4), CASE WHEN tbStokFisiDetayi.nGirisCikis = 1 OR nGirisCikis = 2 THEN tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE tbStokFisiDetayi.lCikisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 END) AS lNetFiyat, ISNULL((select nPartiID from tbStokFisiPartiID where tbStokFisiPartiID.nIslemIDRef = tbStokFisiDetayi.nIslemID), '') as nPartiID FROM tbStokFisiDetayi INNER JOIN tbSatici ON tbStokFisiDetayi.sSaticiRumuzu = tbSatici.sSaticiRumuzu INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiDetayi.nStokFisiID = '" & IstekFisNo & "') ORDER BY tbStokFisiDetayi.nEkSaha1, tbStokFisiDetayi.nIslemID")
            End If
            sorgu_txt_hareket = cmd.CommandText
            cmd.Connection = con
            con.Open()
            Dim Datastoklar1 As New DataSet
            Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
            Try
                N = adapter.Fill(Datastoklar1, "HAREKET")
            Catch ex As Exception
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiDetayi.*, tbSatici.sAdi + ' ' + tbSatici.sSoyadi AS sSatici,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAciklama,tbStok.sKisaAdi,tbStok.nHacim,tbStok.nAgirlik,tbStok.sBirimCinsi1,tbStok.sBirimCinsi2,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,tbStok.sKisaAdi, tbStok.sOzelNot,(lCikisMiktar1 / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lCikisBirimMiktar , (lGirisMiktar1 / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) ) as lGirisBirimMiktar,(tbStokFisiDetayi.lGirisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lGirisMiktar,(tbStokFisiDetayi.lCikisMiktar1 / tbStokFisiDetayi.lBirimMiktar) AS lCikisMiktar,tbStok.sModel, tbStok.sRenk,tbStok.sBeden,tbStok.sKavala,tbStok.nFiyatlandirma,tbStok.nStokTipi,(Select sRenkAdi from tbRenk where sRenk = tbStok.sRenk) as sRenkAdi,(SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1,(SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID and nKisim = 0) AS sBarkod,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS lFiyat1,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS lFiyat2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS lFiyat3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS lFiyat4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "'),0) AS lOzelFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS lAlis, CAST(0 AS MONEY) AS ISK1, CAST(0 AS MONEY) AS ISK2, CAST(0 AS MONEY) AS ISK3, CAST(0 AS MONEY) AS ISK4, CAST(0 AS MONEY) AS ISK5,CAST(0 AS MONEY) AS ISK6,CAST(0 AS MONEY) AS ISK7,CAST(0 AS MONEY) AS ISK8,CAST(0 AS MONEY) AS nMasrafSatiri,CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL((ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0) AS lKdvTutari,(tbStokFisiDetayi.lBrutFiyat * tbStokFisiDetayi.lBirimMiktar) AS lFiyat,CAST((tbStokFisiDetayi.lBrutFiyat*tbStokFisiDetayi.lBirimMiktar) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilFiyat,CAST(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilBrutFiyat,CAST(tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilBrutTutar,lDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutTutar / lDovizKuru1 ELSE lBrutTutar END, lDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN ((lBrutFiyat*lBirimMiktar)) / lDovizKuru1 ELSE (lBrutFiyat*lBirimMiktar) END,lDovizBrutFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutFiyat / lDovizKuru1 ELSE lBrutFiyat END, lDahilDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutTutar / lDovizKuru1) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutTutar)* (100 + tbStokFisiDetayi.nKdvOrani) / 100  END, lDahilDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN ((lBrutFiyat*lBirimMiktar) / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE ((lBrutFiyat*lBirimMiktar))* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END,lDahilDovizBrutFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutFiyat / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutFiyat)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END,CASE WHEN tbStokFisiDetayi.nGirisCikis = 1 OR nGirisCikis = 2 THEN tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE tbStokFisiDetayi.lCikisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 END AS lNetFiyat FROM tbStokFisiDetayi INNER JOIN tbSatici ON tbStokFisiDetayi.sSaticiRumuzu = tbSatici.sSaticiRumuzu INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID  WHERE     (tbStokFisiDetayi.nStokFisiID = '" & IstekFisNo & "') ORDER BY tbStokFisiDetayi.nEkSaha1,tbStokFisiDetayi.nIslemID")
                sorgu_txt_hareket = cmd.CommandText
                N = adapter.Fill(Datastoklar1, "HAREKET")
            End Try
            con.Close()
            Return Datastoklar1
        End If
    End Function
    Public Function sorgu_tbStokFisiEkMaliyet_MobileFatura(ByVal IstekFisNo As String) As DataSet
        If IstekRapor_MobileFatura = 0 Then
            Dim kriter = " WHERE tbStokFisiEkMaliyet.nStokFisiID = '" & IstekFisNo & "' and tbStokFisiEkMaliyet.nIslemID =0"
            Dim conn As New OleDb.OleDbConnection
            Dim cmd As New OleDb.OleDbCommand
            Dim adapter As New OleDb.OleDbDataAdapter
            conn.ConnectionString = connection
            cmd.CommandTimeout = False
            adapter.SelectCommand = cmd
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiEkMaliyet.nKarsiID, tbStokFisiEkMaliyet.nKarsiIslemID, tbStokFisiEkMaliyet.lNetTutar AS lYansiyanTutar, tbStokFisiEkMaliyet.nStokFisiID, tbStokFisiEkMaliyet.nIslemID, tbStokFisiEkMaliyet.lTutar, tbStokFisiEkMaliyet.nOran, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.dteTeslimTarihi, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lFisNo, tbFirma.nFirmaID, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbStokFisiMaster.lNetTutar, tbStok.sKodu AS sStokKodu, tbStok.sModel, tbStok.sAciklama AS sStokAciklama,tbStok.sKisaAdi,tbStok.nHacim,tbStok.nAgirlik, tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.lCikisMiktar1, tbStokFisiDetayi.lCikisFiyat, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.lCikisTutar, tbStokFisiDetayi.sKullaniciAdi FROM tbStok INNER JOIN tbStokFisiDetayi ON tbStok.nStokID = tbStokFisiDetayi.nStokID INNER JOIN tbStokFisiEkMaliyet INNER JOIN tbStokFisiMaster ON tbStokFisiEkMaliyet.nKarsiID = tbStokFisiMaster.nStokFisiID INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID  " & kriter & " ")
            cmd.Connection = conn
            conn.Open()
            Dim Datastoklar1 As New DataSet
            Dim N As Integer = adapter.Fill(Datastoklar1, "tbStokFisiEkMaliyet")
            conn.Close()
            Return Datastoklar1
        End If
    End Function

End Class