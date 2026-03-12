Imports System.IO
Imports FastReport
Imports Microsoft.Win32
Public Class MobileFaaliyet
    Public firmano_MobileFaaliyet
    Public donemno_MobileFaaliyet
    Public connection_MobileFaaliyet
    Public firmatipi_MobileFaaliyet As Boolean = False
    Dim dataset1_MobileFaaliyet As DataSet
    Public DataSet2_MobileFaaliyet As DataSet
    Dim ds_alislar_MobileFaaliyet As DataSet
    Dim IstekRapor_MobileFaaliyet As Integer = 0
    Public Sub OtoFaaliyetThread_MobileFaaliyet()
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        Dim trd As Threading.Thread
        trd = New Threading.Thread(AddressOf OtoFaaliyetOlustur_MobileFaaliyet)
        trd.IsBackground = True
        trd.Start()
    End Sub
    Private Sub FaaliyetDurumDegistir_MobileFaaliyet(ByVal eskiDurum As Integer, ByVal yeniDurum As Integer, ByVal IstekID As String, ByVal olusturmaTarihi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_MobileFaaliyet
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            If Trim(olusturmaTarihi) = "" Then
                cmd.CommandText = sorgu_query_MobileFaaliyet("SET DATEFORMAT DMY Update FaaliyetMobile Set IstekDurum = " & yeniDurum & " WHERE (IstekDurum = " & eskiDurum & ") AND (id = '" & IstekID & "')")
            Else
                cmd.CommandText = sorgu_query_MobileFaaliyet("SET DATEFORMAT DMY Update FaaliyetMobile Set IstekDurum = " & yeniDurum & ", RaporOlusturmaTarihi = GetDate() WHERE (IstekDurum = " & eskiDurum & ") AND (id = '" & IstekID & "')")
            End If
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub OtoFaaliyetOlustur_MobileFaaliyet()
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim IstekTarihi As String = ""
        Dim IstekTarihiDate As Date
        Dim IstekID As String = ""
        cmd.Connection = con
        con.ConnectionString = connection_MobileFaaliyet
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try 
            cmd.CommandText = sorgu_query_MobileFaaliyet("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Top 1 ISNULL(IstekTarihi, '') FROM FaaliyetMobile WHERE (IstekDurum = 0) Order By IstekTarihi Desc")
            IstekTarihi = cmd.ExecuteScalar.ToString()
            cmd.CommandText = sorgu_query_MobileFaaliyet("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Top 1 ISNULL(id, 0) FROM FaaliyetMobile WHERE (IstekDurum = 0) Order By IstekTarihi Desc")
            IstekID = cmd.ExecuteScalar.ToString()
            cmd.CommandText = sorgu_query_MobileFaaliyet("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Top 1 ISNULL(IstekRapor, 0) FROM FaaliyetMobile WHERE (id = " & IstekID & ")")
            IstekRapor_MobileFaaliyet = Integer.Parse(cmd.ExecuteScalar.ToString())
        Catch ex As Exception
            IstekRapor_MobileFaaliyet = 0
        End Try
        con.Close()
        If Trim(IstekTarihi) <> "" Then
            IstekTarihiDate = Date.Parse(IstekTarihi)
            Dim YeniTarih As String = IstekTarihiDate.Day & "." & IstekTarihiDate.Month & "." & IstekTarihiDate.Year
            If Directory.Exists("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih) = True Then
                Try
                    If IstekRapor_MobileFaaliyet = 0 Then
                        If Directory.Exists("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih & "\Perakende") = True Then
                            Directory.Delete("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih & "\Perakende", True)
                        End If
                        Directory.CreateDirectory("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih & "\Perakende")
                    Else
                        If Directory.Exists("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih & "\Fatura") = True Then
                            Directory.Delete("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih & "\Fatura", True)
                        End If
                        Directory.CreateDirectory("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih & "\Fatura")
                    End If
                Catch ex As Exception
                End Try
            Else
                Try
                    Directory.CreateDirectory("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih)
                    If IstekRapor_MobileFaaliyet = 0 Then
                        Directory.CreateDirectory("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih & "\Perakende")
                    Else
                        Directory.CreateDirectory("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih & "\Fatura")
                    End If
                Catch ex As Exception
                End Try
            End If
            Try
                FaaliyetDurumDegistir_MobileFaaliyet(0, 1, IstekID, "")
                dataload_MobileFaaliyet(YeniTarih, YeniTarih, "", "Kodu", "Başlar", "", "Kodu", "Başlar")
                dataload_satis_MobileFaaliyet(YeniTarih, YeniTarih, "", "Kodu", "Başlar", "", "Kodu", "Başlar", 6)
                raporla_MobileFaaliyet(4, YeniTarih, IstekID)
            Catch ex As Exception
                FaaliyetDurumDegistir_MobileFaaliyet(1, 0, IstekID, "")
            End Try
        End If
    End Sub
    Private Sub dataload_MobileFaaliyet(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara_stok As String, ByVal konum_stok As String, ByVal ara_kriter_stok As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String)
        dataset1_MobileFaaliyet = stok_MobileFaaliyet(tarih1, tarih2, ara_stok, konum_stok, ara_kriter_stok, ara, konum, ara_kriter)
        kontrol_oran_MobileFaaliyet()
        kontrol_hazirla_MobileFaaliyet()
    End Sub
    Private Sub dataload_satis_MobileFaaliyet(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara_stok As String, ByVal konum_stok As String, ByVal ara_kriter_stok As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal kontrol As Int64)
        dataset1_MobileFaaliyet = stok_satis_MobileFaaliyet(tarih1, tarih2, ara_stok, konum_stok, ara_kriter_stok, ara, konum, ara_kriter, kontrol, "()")
        kontrol_oran_satis_MobileFaaliyet()
        If kontrol = 6 Then
            Dim alisverisler As String = kontrol_fark_MobileFaaliyet(1)
            dataset1_MobileFaaliyet = stok_satis_MobileFaaliyet(tarih1, tarih2, ara_stok, konum_stok, ara_kriter_stok, ara, konum, ara_kriter, kontrol, alisverisler)
            kontrol_oran_satis_MobileFaaliyet()
            alisverisler = Nothing
        ElseIf kontrol = 7 Then
            Dim alisverisler As String = kontrol_fark_MobileFaaliyet(2)
            dataset1_MobileFaaliyet = stok_satis_MobileFaaliyet(tarih1, tarih2, ara_stok, konum_stok, ara_kriter_stok, ara, konum, ara_kriter, kontrol, alisverisler)
            kontrol_oran_satis_MobileFaaliyet()
            alisverisler = Nothing
        End If
        satis_kontrol_hazirla_MobileFaaliyet()
    End Sub
    Public Function stok_MobileFaaliyet(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara_stok As String, ByVal konum_stok As String, ByVal ara_kriter_stok As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String) As DataSet
        Dim kriter As String = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_MobileFaaliyet
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query_MobileFaaliyet("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.nStokFisiID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.lGirisMiktar2, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.nIskontoYuzdesi, tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.sDovizCinsi, tbStokFisiDetayi.lDovizFiyat, tbStokFisiDetayi.nSiparisID, tbStokFisiDetayi.sAciklama AS Expr1, tbStokFisiDetayi.dteIrsaliyeTarihi, tbStokFisiDetayi.lIrsaliyeNo, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.nStokID, tbStokFisiDetayi.nFirmaID, tbStokFisiDetayi.nIrsaliyeFisiID, tbStokFisiDetayi.sStokIslem, tbStokFisiDetayi.nOTVOrani, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.nIslemID, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, CAST(0 AS MONEY) AS GERCEKFIYAT,CAST(0 AS MONEY) AS ISKONTO,CAST(0 AS MONEY) AS ISKONTOTUTAR, CAST(0 AS MONEY) AS GERCEKTOPLAM, CAST(0 AS MONEY) AS Fark,CAST(0 AS MONEY) AS FarkOran,CAST(0 AS MONEY) AS EKMASRAF, CAST(0 AS MONEY) AS ONCEKIMALIYET, 'Normal' AS Durum,tbFirma.sKodu AS FirmaKodu, tbFirma.sAciklama AS FirmaAdi, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lFisNo, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lMalBedeli, tbStokFisiMaster.lMalIskontoTutari,tbStokFisiMaster.lDipIskontoTutari3, tbStokFisiMaster.lEkmaliyet1, tbStokFisiMaster.lNetTutar FROM tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID WHERE (tbStokFisiMaster.sFisTipi = 'FA ') AND (tbStokFisiMaster.dteFisTarihi between '" & tarih1 & "' and '" & tarih2 & "')  " & kriter & " ORDER BY tbStokFisiDetayi.nIslemID")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function stok_satis_MobileFaaliyet(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara_stok As String, ByVal konum_stok As String, ByVal ara_kriter_stok As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal kontrol As Int64, ByVal alisverisler As String) As DataSet
        Dim kriter As String = ""
        If ara.ToString <> "" Then
            If konum = "Kodu" Then
                If firmatipi_MobileFaaliyet = False Then
                    kriter += " AND (tbMusteri.lKodu " & sorgu_kriter_string_MobileFaaliyet(ara, ara_kriter) & ")"
                Else
                    kriter += " AND (tbFirma.sKodu " & sorgu_kriter_string_MobileFaaliyet(ara, ara_kriter) & ")"
                End If
            ElseIf konum = "Adı" Then
                If firmatipi_MobileFaaliyet = False Then
                    kriter += " AND (tbMusteri.sAdi " & sorgu_kriter_string_MobileFaaliyet(ara, ara_kriter) & ")"
                Else
                    kriter += " AND (tbFirma.sAciklama " & sorgu_kriter_string_MobileFaaliyet(ara, ara_kriter) & ")"
                End If
            ElseIf konum = "Soyadı" Then
                kriter += " AND (tbMusteri.sSoyadi " & sorgu_kriter_string_MobileFaaliyet(ara, ara_kriter) & ")"
            ElseIf konum = "İstihbarat" Then
                kriter += " AND ((tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + '  ' + tbMusteri.sAciklama5) " & sorgu_kriter_string_MobileFaaliyet(ara, ara_kriter) & ")"
            ElseIf konum = "EvAdresi" Then
                kriter += " AND (tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu + ' ' + tbMusteri.sEvIl  " & sorgu_kriter_string_MobileFaaliyet(ara, ara_kriter) & ")"
            ElseIf konum = "İşAdresi" Then
                kriter += " AND (tbMusteri.sIsAdresi1 + ' ' + tbMusteri.sIsAdresi2 + ' ' + tbMusteri.sIsSemt + ' ' + tbMusteri.sIsIl + ' ' + tbMusteri.sIsPostaKodu " & sorgu_kriter_string_MobileFaaliyet(ara, ara_kriter) & ")"
            ElseIf konum = "EvTelefonu" Then
                kriter += " AND (tbMusteri.sEvTelefonu " & sorgu_kriter_string_MobileFaaliyet(ara, ara_kriter) & ")"
            ElseIf konum = "İşTelefonu" Then
                kriter += " AND (tbMusteri.sIsTelefonu " & sorgu_kriter_string_MobileFaaliyet(ara, ara_kriter) & ")"
            ElseIf konum = "Gsm" Then
                kriter += " AND (tbMusteri.sGsm " & sorgu_kriter_string_MobileFaaliyet(ara, ara_kriter) & ")"
            ElseIf konum = "DoğumYeri" Then
                kriter += " AND (tbMusteri.sDogumYeri " & sorgu_kriter_string_MobileFaaliyet(ara, ara_kriter) & ")"
            ElseIf konum = "1.Kefil Adı" Then
                kriter += " AND tbMusteri.nMusteriID IN (Select nMusteriID from tbMusteriKefil1 where sAdi + ' ' + sSoyadi " & sorgu_kriter_string_MobileFaaliyet(ara, ara_kriter) & ")"
            ElseIf konum = "2.Kefil Adı" Then
                kriter += " AND tbMusteri.nMusteriID IN (Select nMusteriID from tbMusteriKefil2 where sAdi + ' ' + sSoyadi " & sorgu_kriter_string_MobileFaaliyet(ara, ara_kriter) & ")"
            ElseIf konum = "Sınıf1" Then
                kriter += " AND (tbMSinif1.sAciklama " & sorgu_kriter_string_MobileFaaliyet(ara, ara_kriter) & ")"
            ElseIf konum = "Sınıf2" Then
                kriter += " AND (tbMSinif2.sAciklama " & sorgu_kriter_string_MobileFaaliyet(ara, ara_kriter) & ")"
            ElseIf konum = "Sınıf3" Then
                kriter += " AND (tbMSinif3.sAciklama " & sorgu_kriter_string_MobileFaaliyet(ara, ara_kriter) & ")"
            ElseIf konum = "Sınıf4" Then
                kriter += " AND (tbMSinif4.sAciklama " & sorgu_kriter_string_MobileFaaliyet(ara, ara_kriter) & ")"
            ElseIf konum = "Sınıf5" Then
                kriter += " AND (tbMSinif5.sAciklama " & sorgu_kriter_string_MobileFaaliyet(ara, ara_kriter) & ")"
            ElseIf konum = "Adı+Soyadı" Then
                Dim adi As String = ""
                Dim soyadi As String = ""
                Dim x
                If CStr(ara.ToString) <> "" Then
                    x = (ara).IndexOf(" ", 1, (ara.Length - 1))
                    If x = -1 Then
                        adi = ara
                    Else
                        adi = (ara).Substring(0, x)
                        soyadi = (ara).Substring((x + 1), (ara).Length - (x + 1))
                    End If
                End If
                If adi.ToString <> "" Then
                    kriter += " AND (tbMusteri.sAdi " & sorgu_kriter_string_MobileFaaliyet(adi, ara_kriter) & ")"
                End If
                If soyadi.ToString <> "" Then
                    kriter += " AND (tbMusteri.sSoyadi " & sorgu_kriter_string_MobileFaaliyet(soyadi, ara_kriter) & ")"
                End If
            End If
        End If
        If ara_stok.ToString <> "" Then
            If konum_stok = "Kod" Then
                kriter += " AND (tbStok.sKodu " & sorgu_kriter_string_MobileFaaliyet(ara_stok, ara_kriter_stok) & ")"
            ElseIf konum_stok = "Ad" Then
                kriter += " AND (tbStok.sAciklama " & sorgu_kriter_string_MobileFaaliyet(ara_stok, ara_kriter_stok) & ")"
            ElseIf konum = "Sınıf1" Then
                kriter += " AND tbStok.nStokID IN (SELECT tbStok.nStokID FROM tbStok INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif1.sAciklama " & sorgu_kriter_string_MobileFaaliyet(ara_stok, ara_kriter_stok) & ")"
            ElseIf konum = "Sınıf2" Then
                kriter += " AND tbStok.nStokID IN (SELECT tbStok.nStokID FROM tbStok INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif2.sAciklama " & sorgu_kriter_string_MobileFaaliyet(ara_stok, ara_kriter_stok) & ")"
            ElseIf konum = "Sınıf3" Then
                kriter += " AND tbStok.nStokID IN (SELECT tbStok.nStokID FROM tbStok INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif3.sAciklama " & sorgu_kriter_string_MobileFaaliyet(ara_stok, ara_kriter_stok) & ")"
            ElseIf konum = "Sınıf4" Then
                kriter += " AND tbStok.nStokID IN (SELECT tbStok.nStokID FROM tbStok INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif4.sAciklama " & sorgu_kriter_string_MobileFaaliyet(ara_stok, ara_kriter_stok) & ")"
            ElseIf konum = "Sınıf5" Then
                kriter += " AND tbStok.nStokID IN (SELECT tbStok.nStokID FROM tbStok INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif5.sAciklama " & sorgu_kriter_string_MobileFaaliyet(ara_stok, ara_kriter_stok) & ")"
            ElseIf konum = "Barkod" Then
                kriter += " AND tbStok.nStokID IN (SELECT tbStok.nStokID FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID WHERE tbStokBarkodu.sBarkod " & sorgu_kriter_string_MobileFaaliyet(ara_stok, ara_kriter_stok) & ")"
            End If
        End If
        Dim kriter_hediyeli As String = ""
        If kontrol = 0 Then
            kriter_hediyeli = " WHERE abs(fiyat) <> gFiyat AND nAlisVerisID NOT IN (SELECT DISTINCT nAlisverisID FROM (SELECT tbAlisVeris.nAlisverisID, tbStokFisiDetayi.sFiyatTipi FROM tbAlisVeris LEFT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.nAlisverisID, tbAlisverisSiparis.sFiyatTipi FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) Hediye WHERE (sFiyatTipi IN ('HD')))"
        ElseIf kontrol = 1 Then
            kriter_hediyeli = " WHERE nAlisVerisID IN (SELECT DISTINCT nAlisverisID FROM (SELECT tbAlisVeris.nAlisverisID, tbStokFisiDetayi.sFiyatTipi FROM tbAlisVeris LEFT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.nAlisverisID, tbAlisverisSiparis.sFiyatTipi FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) Hediye WHERE (sFiyatTipi IN ('HD')))"
        ElseIf kontrol = 2 Then
            Dim odemekodu = InputBox("Peşin Fiyat Vade Kontrolü", "Peşin Vadesi", 0).ToString
            If odemekodu <> "" Then
                kriter_hediyeli = " WHERE sFiyatTipi = '" & sFiyat1 & "' and sOdemeKodu > " & odemekodu & " "
            End If
        ElseIf kontrol = 3 Then
            Dim odemekodu = InputBox("6 Aylık Fiyat Vade Kontrolü", "6 Aylık Fiyat Vadesi", 6).ToString
            If odemekodu <> "" Then
                kriter_hediyeli = " WHERE sFiyatTipi = '" & sFiyat2 & "' and sOdemeKodu > " & odemekodu & " "
            End If
        ElseIf kontrol = 4 Then
            Dim odemekodu = InputBox("10 Aylık Fiyat Vade Kontrolü", "10 Aylık Fiyat Vadesi", 10).ToString
            If odemekodu <> "" Then
                kriter_hediyeli = " WHERE sFiyatTipi = '" & sFiyat3 & "' and sOdemeKodu > " & odemekodu & " "
            End If
        ElseIf kontrol = 5 Then
        ElseIf kontrol = 6 Then
        ElseIf kontrol = 7 Then
        End If
        If alisverisler <> "()" Then
            kriter_hediyeli = " Where nAlisVerisID IN " & alisverisler & " "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_MobileFaaliyet
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        If IstekRapor_MobileFaaliyet = 0 Then
            cmd.CommandText = sorgu_query_MobileFaaliyet("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbAlisVeris.nAlisverisID, tbMusteri.nMusteriID, tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, tbAlisVeris.dteFaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, tbAlisVeris.lFaturaNo AS lNo, tbStok.nStokID, tbStok.sKodu AS sKodu, tbStok.sAciklama AS sStokAciklama, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lBrutFiyat, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari, 0) AS Iskonto, tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbAlisVeris.sMagaza, tbStok.sRenk, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = tbStokFisiDetayi.sFiyatTipi) AS gFiyat, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR, (SELECT TOP 1 ISNULL(tbStokFisiDetayi.dteFisTarihi, '01/01/1900') as dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID and tbStokFisiDetayi.dteFisTarihi <= tbAlisVeris.dteFaturaTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM tbStok RIGHT OUTER JOIN tbMusteri INNER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID LEFT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND tbAlisveris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & " UNION ALL SELECT tbAlisVeris.nAlisverisID, tbMusteri.nMusteriID, tbMusteri.lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, tbAlisVeris.dteFaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, tbAlisVeris.lFaturaNo AS lNo, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama AS sStokAciklama, tbAlisverisSiparis.lGCMiktar AS Miktar, tbAlisverisSiparis.lBrutFiyat AS Fiyat, tbAlisverisSiparis.lIskontoTutari AS Iskonto, tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar, tbAlisverisSiparis.sOdemeKodu, tbAlisverisSiparis.sFiyatTipi, tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu, tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu, tbAlisverisSiparis.nGirisCikis AS GirisCikis, tbAlisVeris.sMagaza, tbStok.sRenk, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = tbAlisVerisSiparis.sFiyatTipi) AS gFiyat, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID and tbStokFisiDetayi.dteFisTarihi <= tbAlisVeris.dteFaturaTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE tbAlisveris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & ") t " & kriter_hediyeli & " ORDER BY nAlisVerisID, lNo")
        Else
            cmd.CommandText = sorgu_query_MobileFaaliyet("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT ISNULL(tbStokFisiDetayi.nAlisverisID, '') as nAlisverisID, tbMusteri.nMusteriID, tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, tbStokFisiDetayi.dteFisTarihi AS dteTarih, tbStokFisiDetayi.sFisTipi AS fisTipi, tbStokFisiDetayi.lFisNo AS lNo, tbStok.nStokID, tbStok.sKodu AS sKodu, tbStok.sAciklama AS sStokAciklama, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lBrutFiyat, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari, 0) AS Iskonto, tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo as sMagaza, tbStok.sRenk, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = tbStokFisiDetayi.sFiyatTipi) AS gFiyat, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR, (SELECT TOP 1 ISNULL(tbStokFisiDetayi.dteFisTarihi, '01/01/1900') as dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FS') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM tbStok RIGHT OUTER JOIN tbMusteri INNER JOIN tbStokFisiDetayi INNER JOIN tbDepo ON tbStokFisiDetayi.sDepo = tbDepo.sDepo ON tbMusteri.nMusteriID = tbStokFisiDetayi.nMusteriID LEFT OUTER JOIN tbAlisVeris ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbStokFisiDetayi.sFisTipi = 'DC' OR tbStokFisiDetayi.sFisTipi = 'FS') AND tbStokFisiDetayi.dteFisTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & " UNION ALL SELECT ISNULL(tbStokFisiDetayi.nAlisverisID, '') as nAlisverisID, tbMusteri.nMusteriID, tbMusteri.lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, tbStokFisiDetayi.dteFisTarihi AS dteTarih, tbStokFisiDetayi.sFisTipi AS fisTipi, tbStokFisiDetayi.lFisNo AS lNo, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama AS sStokAciklama, tbAlisverisSiparis.lGCMiktar AS Miktar, tbAlisverisSiparis.lBrutFiyat AS Fiyat, tbAlisverisSiparis.lIskontoTutari AS Iskonto, tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar, tbAlisverisSiparis.sOdemeKodu, tbAlisverisSiparis.sFiyatTipi, tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu, tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu, tbAlisverisSiparis.nGirisCikis AS GirisCikis, tbStokFisiDetayi.sDepo as sMagaza, tbStok.sRenk, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = tbAlisVerisSiparis.sFiyatTipi) AS gFiyat, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FS') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM tbAlisverisSiparis INNER JOIN tbStokFisiDetayi ON tbAlisverisSiparis.nAlisverisID = tbStokFisiDetayi.nAlisverisID INNER JOIN tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE tbStokFisiDetayi.dteFisTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & ") t " & kriter_hediyeli & " ORDER BY lNo")
        End If
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Function sorgu_kriter_string_MobileFaaliyet(ByVal deger As String, ByVal kriter As String) As String
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
    Private Function sorgu_query_MobileFaaliyet(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano_MobileFaaliyet.ToString)
        query = Replace(query, "!D", "D000" + donemno_MobileFaaliyet.ToString)
        Return query
    End Function
    Private Sub kontrol_oran_MobileFaaliyet()
        Dim oranekmaliyet As Decimal = 0
        Dim dr As DataRow
        For Each dr In dataset1_MobileFaaliyet.Tables(0).Rows
            dr("GERCEKFIYAT") = dr("lGirisFiyat") * ((dr("nKdvOrani") + 100) / 100)
            Try
                dr("ISKONTO") = (dr("lMalIskontoTutari") + dr("lDipIskontoTutari3")) / dr("lMalBedeli")
                If CType(dr("lEkmaliyet1"), Decimal) <> 0 Then
                    oranekmaliyet = CType(dr("lEkmaliyet1"), Decimal) / CType(dr("lMalBedeli") - dr("lMalIskontoTutari"), Decimal)
                    dr("EKMASRAF") = oranekmaliyet
                    dr("GERCEKFIYAT") = dr("GERCEKFIYAT") * ((100 + (oranekmaliyet * 100)) / 100)
                End If
            Catch ex As Exception
            End Try
            dr("GERCEKTOPLAM") = (dr("GERCEKFIYAT")) * (Math.Abs(dr("lGirisMiktar1")))
            oranekmaliyet = 0
            Dim dr1 As DataRow
            ds_alislar_MobileFaaliyet = sorgu_alislar_MobileFaaliyet(dr("dteFisTarihi"), dr("lFisNo"), dr("sKodu"))
            Dim sayi As Integer = 0
            For Each dr1 In ds_alislar_MobileFaaliyet.Tables(0).Rows
                sayi += 1
                If dr1("EKMALIYET") <> 0 Then
                    dr1("ORANEKMALIYET") = dr1("EKMALIYET") / dr1("FATURATUTARI")
                End If
                dr1("NETMALIYET") = dr1("KDVLITUTAR") * ((100 + (dr1("ORANEKMALIYET") * 100)) / 100)
                If sayi = 1 Then
                    dr("ONCEKIMALIYET") = FormatNumber(dr1("NETMALIYET"), 2)
                ElseIf sayi = 2 Then
                End If
                If dr("ONCEKIMALIYET") = 0 Then
                    dr("Durum") = "Yeni"
                End If
                dr("Fark") = FormatNumber((Math.Abs(dr("GERCEKFIYAT"))) - (Math.Abs(dr("ONCEKIMALIYET"))), 2)
                Try
                    dr("FarkOran") = dr("Fark") / dr("ONCEKIMALIYET")
                Catch ex As Exception
                    dr("FarkOran") = 0
                End Try
                If dr("Fark") > 0 Then
                    dr("Durum") = "Pahalı"
                ElseIf dr("Fark") < 0 Then
                    dr("Durum") = "Ucuz"
                End If
            Next
        Next
        dr = Nothing
    End Sub
    Private Sub kontrol_oran_satis_MobileFaaliyet()
        Dim dr As DataRow
        Dim netmaliyet As Decimal = 0
        Dim normalfiyat As Decimal = 0
        Dim fiyattipi As String = ""
        For Each dr In dataset1_MobileFaaliyet.Tables(0).Rows
            If dr("sKodu").ToString <> "" Then
                Try
                    netmaliyet = dr("MALIYET") * dr("Miktar")
                Catch ex As Exception
                    netmaliyet = 0
                End Try
                Try
                    dr("ORAN1") = ((dr("lNetTutar") - netmaliyet) / netmaliyet)
                    dr("KAR") = dr("lNetTutar") - netmaliyet
                Catch ex As Exception
                    dr("ORAN1") = 0
                    dr("KAR") = dr("lNetTutar") - netmaliyet
                End Try
                If dr("nGirisCikis") <> 5 Then
                    If Trim(dr("sFiyatTipi").ToString) <> "HD" Then
                        fiyattipi = Trim(dr("sFiyatTipi").ToString)
                        If fiyattipi = Trim(sFiyat3) Then
                            If Math.Abs(dr("Fiyat")) <> sorgu_sayi_MobileFaaliyet(dr("ONAY"), 0) Then
                                dr("NORMALFIYAT") = sorgu_sayi_MobileFaaliyet(dr("ONAY"), 0)
                                dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                                normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                                dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR")
                                dr("FIYATFARKI") = dr("Fiyat") - normalfiyat
                            End If
                        ElseIf fiyattipi = Trim(sFiyat2) Then
                            If Math.Abs(dr("Fiyat")) <> sorgu_sayi_MobileFaaliyet(dr("ALTIAY"), 0) Then
                                dr("NORMALFIYAT") = sorgu_sayi_MobileFaaliyet(dr("ALTIAY"), 0)
                                dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                                normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                                dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR")
                                dr("FIYATFARKI") = dr("Fiyat") - normalfiyat
                            End If
                        ElseIf fiyattipi = Trim(sFiyat1) Then
                            If Math.Abs(dr("Fiyat")) <> sorgu_sayi_MobileFaaliyet(dr("PESIN"), 0) Then
                                dr("NORMALFIYAT") = sorgu_sayi_MobileFaaliyet(dr("PESIN"), 0)
                                dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                                normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                                dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR")
                                dr("FIYATFARKI") = dr("Fiyat") - normalfiyat
                            End If
                        End If
                    Else
                        If fiyattipi = Trim(sFiyat3) Then
                            dr("NORMALFIYAT") = sorgu_sayi_MobileFaaliyet(dr("ONAY"), 0)
                            dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                            dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR") + 0.01
                            dr("FIYATFARKI") = dr("Fiyat") - normalfiyat + +0.01
                        ElseIf fiyattipi = Trim(sFiyat2) Then
                            dr("NORMALFIYAT") = sorgu_sayi_MobileFaaliyet(dr("ALTIAY"), 0)
                            dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                            dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR") + 0.01
                            dr("FIYATFARKI") = dr("Fiyat") - normalfiyat + 0.01
                        ElseIf fiyattipi = Trim(sFiyat1) Then
                            dr("NORMALFIYAT") = sorgu_sayi_MobileFaaliyet(dr("PESIN"), 0)
                            dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                            dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR") + 0.01
                            dr("FIYATFARKI") = dr("Fiyat") - normalfiyat + 0.01
                        End If
                    End If
                End If
            End If
        Next
        dr = Nothing
    End Sub
    Private Function kontrol_fark_MobileFaaliyet(Optional ByVal islem As Integer = 0)
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim dr2 As DataRow
        Dim nAlisVerisID As String = ""
        Dim fark As Decimal = 0
        Dim alisverisler As String = "("
        Dim toplamsayi = dataset1_MobileFaaliyet.Tables(0).Rows.Count
        Dim sayi As Int64 = 0
        For Each dr In dataset1_MobileFaaliyet.Tables(0).Rows
            sayi += 1
            If nAlisVerisID <> Trim(dr("nAlisVerisID")) Then
                If fark < 0 Then
                    fark = 0
                    If islem = 1 Then
                        dr2 = DataSet2_MobileFaaliyet.Tables(0).NewRow
                        dr2(0) = nAlisVerisID.ToString
                        DataSet2_MobileFaaliyet.Tables(0).Rows.Add(dr2)
                        fark = 0
                    End If
                ElseIf fark > 0 Then
                    fark = 0
                    If islem = 2 Then
                        dr2 = DataSet2_MobileFaaliyet.Tables(0).NewRow
                        dr2(0) = nAlisVerisID.ToString
                        DataSet2_MobileFaaliyet.Tables(0).Rows.Add(dr2)
                        fark = 0
                    End If
                Else
                    fark = 0
                End If
                nAlisVerisID = Trim(dr("nAlisVerisID"))
                fark += dr("FARK")
            Else
                fark += dr("FARK")
            End If
        Next
        Try
            toplamsayi = DataSet2_MobileFaaliyet.Tables(0).Rows.Count
        Catch ex As Exception
        End Try
        sayi = 0
        alisverisler = "("
        For Each dr1 In DataSet2_MobileFaaliyet.Tables(0).Rows
            alisverisler += "'" & dr1(0) & "'"
            sayi += 1
            If sayi < toplamsayi Then
                alisverisler += ","
            End If
        Next
        alisverisler += ")"
        dr = Nothing
        dr1 = Nothing
        sayi = Nothing
        toplamsayi = Nothing
        Return alisverisler
    End Function
    Private Function sorgu_sayi_MobileFaaliyet(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Function sorgu_tarih_MobileFaaliyet(ByVal deger As Object, ByVal sonuc As DateTime) As DateTime
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub kontrol_hazirla_MobileFaaliyet()
        Dim dr As DataRow
        hareket_kaydet_sifirla_MobileFaaliyet()
        For Each dr In dataset1_MobileFaaliyet.Tables(0).Rows
            hareket_kaydet_yeni_MobileFaaliyet(dr("nStokFisiID"), dr("sKodu"), Microsoft.VisualBasic.Left(dr("sAciklama"), 50), dr("sRenk"), sorgu_sayi_MobileFaaliyet(dr("lGirisMiktar1"), 0), sorgu_sayi_MobileFaaliyet(dr("lGirisMiktar2"), 0), sorgu_sayi_MobileFaaliyet(dr("lGirisFiyat"), 0), sorgu_sayi_MobileFaaliyet(dr("lGirisTutar"), 0), dr("sFiyatTipi"), sorgu_sayi_MobileFaaliyet(dr("lBrutFiyat"), 0), sorgu_sayi_MobileFaaliyet(dr("lBrutTutar"), 0), sorgu_sayi_MobileFaaliyet(dr("nIskontoYuzdesi"), 0), sorgu_sayi_MobileFaaliyet(dr("lIskontoTutari"), 0), dr("sDovizCinsi"), sorgu_sayi_MobileFaaliyet(dr("lDovizFiyat"), 0), dr("nSiparisID").ToString, dr("Expr1"), dr("dteIrsaliyeTarihi"), dr("lIrsaliyeNo"), dr("sDepo"), dr("nStokID"), dr("nFirmaID"), dr("nIrsaliyeFisiID").ToString, dr("sStokIslem"), sorgu_sayi_MobileFaaliyet(dr("nOtvOrani"), 0), sorgu_sayi_MobileFaaliyet(dr("nKdvOrani"), 0), dr("nIslemID"), sorgu_sayi_MobileFaaliyet(dr("ISK1"), 0), sorgu_sayi_MobileFaaliyet(dr("ISK2"), 0), sorgu_sayi_MobileFaaliyet(dr("ISK3"), 0), sorgu_sayi_MobileFaaliyet(dr("ISK4"), 0), sorgu_sayi_MobileFaaliyet(dr("GERCEKFIYAT"), 0), sorgu_sayi_MobileFaaliyet(dr("ISKONTO"), 0), sorgu_sayi_MobileFaaliyet(dr("ISKONTOTUTAR"), 0), sorgu_sayi_MobileFaaliyet(dr("GERCEKTOPLAM"), 0), sorgu_sayi_MobileFaaliyet(dr("Fark"), 0), sorgu_sayi_MobileFaaliyet(dr("FarkOran"), 0), sorgu_sayi_MobileFaaliyet(dr("EKMASRAF"), 0), sorgu_sayi_MobileFaaliyet(dr("ONCEKIMALIYET"), 0), dr("Durum"), dr("FirmaKodu"), Microsoft.VisualBasic.Left(dr("FirmaAdi"), 50), dr("sFisTipi"), dr("dteFisTarihi"), dr("nGirisCikis"), dr("lFisNo"), sorgu_sayi_MobileFaaliyet(dr("lToplamMiktar"), 0), sorgu_sayi_MobileFaaliyet(dr("lMalBedeli"), 0), sorgu_sayi_MobileFaaliyet(dr("lMalIskontoTutari"), 0), sorgu_sayi_MobileFaaliyet(dr("lDipIskontoTutari3"), 0), sorgu_sayi_MobileFaaliyet(dr("lNetTutar"), 0))
        Next
        dr = Nothing
    End Sub
    Private Function nullCevir_MobileFaaliyet(ByVal dbn As Object, ByVal tur As Integer) As Object
        If IsDBNull(dbn) Then
            If tur = 1 Then
                dbn = ""
            ElseIf tur = 2 Then
                dbn = 0
            End If
        End If
        Return dbn
    End Function
    Private Sub satis_kontrol_hazirla_MobileFaaliyet()
        Dim dr As DataRow
        satis_hareket_kaydet_sifirla_MobileFaaliyet()
        If dataset1_MobileFaaliyet.Tables(0).Rows.Count > 0 Then
            For Each dr In dataset1_MobileFaaliyet.Tables(0).Rows
                satis_hareket_kaydet_yeni_MobileFaaliyet(nullCevir_MobileFaaliyet(dr("nAlisVerisID"), 1), nullCevir_MobileFaaliyet(dr("nMusteriID"), 2), nullCevir_MobileFaaliyet(dr("lKodu"), 1), nullCevir_MobileFaaliyet(dr("sMusteriAdi"), 1), dr("dteTarih"), nullCevir_MobileFaaliyet(dr("fisTipi"), 1), nullCevir_MobileFaaliyet(dr("lNo"), 1), nullCevir_MobileFaaliyet(dr("nStokID"), 2), nullCevir_MobileFaaliyet(dr("sKodu"), 1), nullCevir_MobileFaaliyet(dr("sStokAciklama"), 1), sorgu_sayi_MobileFaaliyet(dr("Miktar"), 0), sorgu_sayi_MobileFaaliyet(dr("Fiyat"), 0), sorgu_sayi_MobileFaaliyet(dr("Iskonto"), 0), sorgu_sayi_MobileFaaliyet(dr("lNetTutar"), 0), nullCevir_MobileFaaliyet(dr("sOdemeKodu"), 1), nullCevir_MobileFaaliyet(dr("sFiyatTipi"), 1), nullCevir_MobileFaaliyet(dr("sSaticiRumuzu"), 1), nullCevir_MobileFaaliyet(dr("sKasiyerRumuzu"), 1), nullCevir_MobileFaaliyet(dr("nGirisCikis"), 2), nullCevir_MobileFaaliyet(dr("sMagaza"), 1), nullCevir_MobileFaaliyet(dr("sRenk"), 1), sorgu_sayi_MobileFaaliyet(dr("PESIN"), 0), sorgu_sayi_MobileFaaliyet(dr("ONAY"), 0), sorgu_sayi_MobileFaaliyet(dr("ALTIAY"), 0), sorgu_sayi_MobileFaaliyet(dr("MALIYET"), 0), sorgu_sayi_MobileFaaliyet(dr("gFiyat"), 0), sorgu_sayi_MobileFaaliyet(dr("ORAN1"), 0), sorgu_sayi_MobileFaaliyet(dr("KAR"), 0), sorgu_sayi_MobileFaaliyet(dr("FARK"), 0), sorgu_sayi_MobileFaaliyet(dr("FIYATFARKI"), 0), sorgu_sayi_MobileFaaliyet(dr("NORMALFIYAT"), 0), sorgu_sayi_MobileFaaliyet(dr("NORMALTUTAR"), 0), sorgu_tarih_MobileFaaliyet(dr("SonAlisTarihi"), "01/01/1900"))
            Next
        End If
        dr = Nothing
    End Sub
    Private Sub hareket_kaydet_sifirla_MobileFaaliyet()
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection_MobileFaaliyet
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query_MobileFaaliyet("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  Truncate Table aEmirAlisDetay ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub satis_hareket_kaydet_sifirla_MobileFaaliyet()
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection_MobileFaaliyet
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query_MobileFaaliyet("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  Truncate Table aEmirSatisDetay ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub hareket_kaydet_yeni_MobileFaaliyet(ByVal nStokFisiID As Integer, ByVal sKodu As String, ByVal sAciklama As String, ByVal sRenk As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal sFiyatTipi As String, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal Expr1 As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal sDepo As String, ByVal nStokID As Int64, ByVal nFirmaID As Int64, ByVal nIrsaliyeFisiID As String, ByVal sStokIslem As String, ByVal nOtvOrani As Decimal, ByVal nKdvOrani As Decimal, ByVal nIslemID As Int64, ByVal ISK1 As Decimal, ByVal ISK2 As Decimal, ByVal ISK3 As Decimal, ByVal ISK4 As Decimal, ByVal GERCEKFIYAT As Decimal, ByVal ISKONTO As Decimal, ByVal ISKONTOTUTAR As Decimal, ByVal GERCEKTOPLAM As Decimal, ByVal Fark As Decimal, ByVal FarkOran As Decimal, ByVal EKMASRAF As Decimal, ByVal ONCEKIMALIYET As Decimal, ByVal Durum As String, ByVal FirmaKodu As String, ByVal FirmaAdi As String, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal nGirisCikis As Integer, ByVal lFisNo As Int64, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal lDipIskontoTutari3 As Decimal, ByVal lNetTutar As Decimal)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection_MobileFaaliyet
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query_MobileFaaliyet("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  INSERT INTO aEmirAlisDetay                       (nStokFisiID, sKodu, sAciklama, sRenk, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, Expr1, dteIrsaliyeTarihi, lIrsaliyeNo, sDepo, nStokID, nFirmaID, nIrsaliyeFisiID, sStokIslem, nOtvOrani, nKdvOrani, nIslemID, ISK1, ISK2, ISK3, ISK4, GERCEKFIYAT, ISKONTO, ISKONTOTUTAR, GERCEKTOPLAM, Fark, FarkOran, EKMASRAF,ONCEKIMALIYET, Durum, FirmaKodu, FirmaAdi, sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, lToplamMiktar, lMalBedeli, lMalIskontoTutari,lDipIskontoTutari3, lNetTutar) VALUES     (" & nStokFisiID & ", '" & sKodu & "', N'" & sAciklama & "', '" & sRenk & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & " , '" & sFiyatTipi & "', " & lBrutFiyat & ", " & lBrutTutar & ", " & nIskontoYuzdesi & "," & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", 0, '" & Expr1 & "', '" & dteIrsaliyeTarihi & "', " & lIrsaliyeNo & ", '" & sDepo & "', " & nStokID & ", " & nFirmaID & ", 0, '" & sStokIslem & "'," & nOtvOrani & ", " & nKdvOrani & ", " & nIslemID & ", " & ISK1 & ", " & ISK2 & ", " & ISK3 & ", " & ISK4 & ", " & GERCEKFIYAT & ", " & ISKONTO & ", " & ISKONTOTUTAR & ", " & GERCEKTOPLAM & ", " & Fark & ", " & FarkOran & ", " & EKMASRAF & "," & ONCEKIMALIYET & ", '" & Durum & "', '" & FirmaKodu & "', '" & FirmaAdi & "', '" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & ", " & lFisNo & ", " & lToplamMiktar & ", " & lMalBedeli & ", " & lMalIskontoTutari & ", " & lDipIskontoTutari3 & ", " & lNetTutar & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub satis_hareket_kaydet_yeni_MobileFaaliyet(ByVal nAlisverisID As String, ByVal nMusteriID As Int64, ByVal lKodu As String, ByVal sMusteriAdi As String, ByVal dteTarih As DateTime, ByVal fisTipi As String, ByVal lNo As String, ByVal nStokID As Int64, ByVal sKodu As String, ByVal sStokAciklama As String, ByVal Miktar As Decimal, ByVal Fiyat As Decimal, ByVal Iskonto As Decimal, ByVal lNetTutar As Decimal, ByVal sOdemeKodu As String, ByVal sFiyatTipi As String, ByVal sSaticiRumuzu As String, ByVal sKasiyerRumuzu As String, ByVal nGirisCikis As Int64, ByVal sMagaza As String, ByVal sRenk As String, ByVal PESIN As Decimal, ByVal ONAY As Decimal, ByVal ALTIAY As Decimal, ByVal MALIYET As Decimal, ByVal gFiyat As Decimal, ByVal ORAN1 As Decimal, ByVal KAR As Decimal, ByVal FARK As Decimal, ByVal FIYATFARKI As Decimal, ByVal NORMALFIYAT As Decimal, ByVal NORMALTUTAR As Decimal, ByVal SonAlisTarihi As DateTime)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection_MobileFaaliyet
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query_MobileFaaliyet("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  INSERT INTO aEmirSatisDetay (nAlisverisID, nMusteriID, lKodu, sMusteriAdi, dteTarih, fisTipi, lNo, nStokID, sKodu, sStokAciklama, Miktar, Fiyat, Iskonto, lNetTutar, sOdemeKodu, sFiyatTipi, sSaticiRumuzu, sKasiyerRumuzu, nGirisCikis, sMagaza, sRenk, PESIN, ONAY, ALTIAY, MALIYET, gFiyat, ORAN1, KAR, FARK, FIYATFARKI, NORMALFIYAT, NORMALTUTAR, SonAlisTarihi) VALUES     ('" & nAlisverisID & "', " & nMusteriID & ", '" & lKodu & "', '" & sMusteriAdi & "', '" & dteTarih & "', '" & fisTipi & "', '" & lNo & "', " & nStokID & ", '" & sKodu & "', '" & sStokAciklama & "', " & Miktar & ", " & Fiyat & ", " & Iskonto & ", " & lNetTutar & ", '" & sOdemeKodu & "', '" & sFiyatTipi & "', '" & sSaticiRumuzu & "', '" & sKasiyerRumuzu & "', " & nGirisCikis & ", '" & sMagaza & "', '" & sRenk & "', " & PESIN & ", " & ONAY & ", " & ALTIAY & ", " & MALIYET & ", " & gFiyat & ", " & ORAN1 & ", " & KAR & ", " & FARK & ", " & FIYATFARKI & ", " & NORMALFIYAT & ", " & NORMALTUTAR & ", '" & SonAlisTarihi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_alislar_MobileFaaliyet(ByVal tarih As DateTime, ByVal fisno As String, ByVal stokkodu As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection_MobileFaaliyet
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query_MobileFaaliyet("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 2 tbStokFisiDetayi.lFisNo AS FISNO, tbStokFisiDetayi.dteFisTarihi AS TARIH, tbStokFisiDetayi.lGirisFiyat AS BIRIMMALIYET, tbStokFisiDetayi.lGirisMiktar1 AS MIKTAR, tbStokFisiDetayi.lBrutFiyat AS BIRIMFIYAT, tbStokFisiDetayi.lIskontoTutari AS ISKONTO, tbStokFisiDetayi.nKdvOrani AS KDV, tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS KDVLITUTAR, baslik.lToplamMiktar AS FATURAMIKTARI, baslik.lMalBedeli - baslik.lMalIskontoTutari AS FATURATUTARI, baslik.lEkmaliyet1 AS EKMALIYET, tbStok.sKodu AS STOKKODU, tbStok.sAciklama AS STOKADI,CAST(0 AS MONEY) AS ORANEKMALIYET,CAST(0 AS MONEY) AS NETMALIYET FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiMaster baslik ON tbStokFisiDetayi.nStokFisiID = baslik.nStokFisiID WHERE (tbStokFisiDetayi.nGirisCikis = 1) AND (tbStokFisiDetayi.dteFisTarihi  < '" & tarih & "') AND (tbFirma.sKodu LIKE '3%') and (tbstok.sKodu ='" & stokkodu & "') ORDER BY tbStokFisiDetayi.dteFisTarihi DESC, tbStokFisiDetayi.lFisNo")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub raporla_MobileFaaliyet(ByVal status As Integer, Optional ByVal YeniTarih As String = "", Optional ByVal IstekID As String = "")
        Dim file1 As String
        Dim ara As String
        Dim frx As New TfrxReportClass
        Dim ds As New TfrxUserDataSetClass
        Dim qr_hareket As New TfrxADOQuery
        frx.ClearReport()
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("Fast Reports").CreateSubKey("connections").SetValue("UGURLU", connection_MobileFaaliyet)
        file1 = "c:\Formlar\Raporlar\Faaliyet_Kontrol_Mobile.fr3"
        frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
        frx.LoadReportFromFile(file1)
        Dim str As String = ""
        Dim strArr() As String
        str = YeniTarih
        strArr = str.Split(".")
        str = strArr(0) & "/" & strArr(1) & "/" & strArr(2)
        frx.SetVariable("IslemTarihi", "'" & str & " 00:00:00'")
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
            If IstekRapor_MobileFaaliyet = 0 Then
                frx.ExportToHTML("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih & "\Perakende\Faaliyet.html", False, True, False, False, True, False)
            Else
                frx.ExportToHTML("C:\xampp\htdocs\FaaliyetRaporlar\" & YeniTarih & "\Fatura\Faaliyet.html", False, True, False, False, True, False)
            End If
            FaaliyetDurumDegistir_MobileFaaliyet(1, 2, IstekID, "1")
        Catch ex As Exception
            FaaliyetDurumDegistir_MobileFaaliyet(1, 0, IstekID, "1")
        End Try
    End Sub
End Class
