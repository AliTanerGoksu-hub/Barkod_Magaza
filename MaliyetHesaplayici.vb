Option Strict Off
Option Explicit On
Imports System.Data

' Merkezi Maliyet Hesaplama Modulu
' Tum formlarda kullanilabilecek FIFO, LIFO, Agirlikli Ortalama, Hareketli Ortalama,
' Gercek Parti ve Standart Maliyet yontemlerini icerir.
Module MaliyetHesaplayici

    ' ComboBox icin maliyet yontemi adlari (index sirali)
    Public Function MaliyetYontemiAdlari() As Object()
        Return New Object() {
            "Stok Kartýndan",
            "Maliyetlendirmeden",
            "Satýþ Günündeki Maliyet",
            "FIFO (Ýlk Giren Ýlk Çýkar)",
            "LIFO (Son Giren Ýlk Çýkar)",
            "Aðýrlýklý Ortalama",
            "Hareketli Ortalama",
            "Gerçek Parti Maliyeti",
            "Standart Maliyet"
        }
    End Function

    ' Alis KDV dahil mi bilgisi (onbellek)
    Private _bAlisKdvDahilCached As Integer = -1

    Public Function AlisKdvDahilMi() As Boolean
        If _bAlisKdvDahilCached >= 0 Then Return (_bAlisKdvDahilCached = 1)
        Try
            Dim dtKdvKontrol As DataSet = KeyCode.sorgu(KeyCode.sorgu_query( _
                "SELECT ISNULL(bKdvDahilmi, 0) AS bKdvDahilmi FROM tbFiyatTipi WHERE RTRIM(sFiyatTipi) = '" & Trim(KeyCode.sFiyatA) & "'"))
            If dtKdvKontrol IsNot Nothing AndAlso dtKdvKontrol.Tables(0).Rows.Count > 0 Then
                Dim result = dtKdvKontrol.Tables(0).Rows(0)("bKdvDahilmi")
                If TypeOf result Is Boolean Then
                    _bAlisKdvDahilCached = If(CBool(result), 1, 0)
                Else
                    _bAlisKdvDahilCached = If(Convert.ToInt32(result) <> 0, 1, 0)
                End If
            Else
                _bAlisKdvDahilCached = 0
            End If
        Catch
            _bAlisKdvDahilCached = 0
        End Try
        Return (_bAlisKdvDahilCached = 1)
    End Function

    Public Sub OnbellekSifirla()
        _bAlisKdvDahilCached = -1
    End Sub

    ' Bir stok icin belirli tarihe kadar olan alis kayitlarini getirir
    Public Function AlisKayitlariGetir(nStokID As Int64, tarihLimit As DateTime, Optional siralamaTipi As String = "ASC") As DataSet
        Dim sql As String = KeyCode.sorgu_query( _
            "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY " & _
            "SELECT tbStokFisiDetayi.nIslemID, tbStokFisiDetayi.dteFisTarihi, " & _
            "tbStokFisiDetayi.nStokID, tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.nKdvOrani, " & _
            "tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, " & _
            "tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, " & _
            "tbStokFisiDetayi.lMaliyetFiyat, tbStokFisiDetayi.lMaliyetTutar, " & _
            "tbStokFisiDetayi.lIlaveMaliyetTutar, " & _
            "tbStokFisiMaster.lMalBedeli AS lMalBedeli, tbStokFisiMaster.lNetTutar, " & _
            "tbStokFisiMaster.lMalIskontoTutari AS lMalIskontotuTutari, " & _
            "tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari, " & _
            "tbStokFisiMaster.lEkmaliyet1, tbStokFisiMaster.lEkmaliyet2, tbStokFisiMaster.lEkmaliyet3, " & _
            "(SELECT ISNULL(SUM(lTutar), 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiMaster.nStokFisiID AND nIslemID = 0) AS lEkMaliyet4, " & _
            "(SELECT ISNULL(SUM(lTutar), 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar, " & _
            "CAST(0 AS money) AS nEkOran, " & _
            "(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani " & _
            "FROM tbStokFisiDetayi " & _
            "INNER JOIN tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID " & _
            "INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & _
            "WHERE (tbStokFisiDetayi.nGirisCikis IN (1)) " & _
            "AND tbStokFisiDetayi.lGirisMiktar1 > 0 " & _
            "AND (tbStokFisiDetayi.dteFisTarihi <= '" & tarihLimit.ToString("dd/MM/yyyy") & "') " & _
            "AND tbStokFisiDetayi.nStokID = " & nStokID.ToString() & " " & _
            "AND tbStokFisiDetayi.sFisTipi <> 'T' " & _
            "ORDER BY tbStokFisiDetayi.dteFisTarihi " & siralamaTipi & ", tbStokFisiDetayi.nIslemID " & siralamaTipi)
        Return KeyCode.sorgu(sql)
    End Function

    ' Tek bir alis kaydinin birim maliyetini hesaplar (KDV ve ek maliyet dahil)
    Public Function BirimMaliyetHesapla(dr As DataRow) As Decimal
        Dim maliyet As Decimal = 0
        Dim oranekmaliyet As Decimal = 0

        Try
            maliyet = CDec(dr("lGirisTutar")) / CDec(dr("lGirisMiktar1"))
        Catch
            Return 0
        End Try

        Dim bAlisKdvDahil As Boolean = AlisKdvDahilMi()

        If bAlisKdvDahil = False Then
            If CDec(dr("nKdvOrani")) <> CDec(dr("nStokKdvOrani")) Then
                If bKdvKontrolluMaliyet = True Then
                    maliyet = maliyet * ((CDec(dr("nStokKdvOrani")) + 100) / 100)
                Else
                    maliyet = maliyet * ((CDec(dr("nKdvOrani")) + 100) / 100)
                End If
            Else
                maliyet = maliyet * ((CDec(dr("nKdvOrani")) + 100) / 100)
            End If
        End If

        maliyet = maliyet - Math.Abs((CDec(dr("lIlaveMaliyetTutar")) + CDec(dr("lEkIlaveMaliyetTutar"))) / CDec(dr("lGirisMiktar1")))

        Try
            If CType(CDec(dr("lEkmaliyet1")) + CDec(dr("lEkmaliyet3")) + CDec(dr("lEkMaliyet4")), Decimal) <> 0 Then
                oranekmaliyet = CType(CDec(dr("lEkmaliyet1")) + CDec(dr("lEkmaliyet3")) + CDec(dr("lEkMaliyet4")), Decimal) / _
                    CType(CDec(dr("lNetTutar")) - CDec(dr("lEkmaliyet1")), Decimal)
                maliyet = maliyet + (maliyet * (((oranekmaliyet * 100)) / 100))
            End If
        Catch
        End Try

        Return maliyet
    End Function

    ' FIFO: Ilk giren ilk cikar - en eski alisin birim maliyetini dondurur
    Public Function HesaplaFIFO(dsAlislar As DataSet) As Decimal
        If dsAlislar Is Nothing OrElse dsAlislar.Tables.Count = 0 OrElse dsAlislar.Tables(0).Rows.Count = 0 Then Return 0
        ' ASC sirali: ilk kayit en eski alis
        Return BirimMaliyetHesapla(dsAlislar.Tables(0).Rows(0))
    End Function

    ' LIFO: Son giren ilk cikar - en yeni alisin birim maliyetini dondurur
    Public Function HesaplaLIFO(dsAlislar As DataSet) As Decimal
        If dsAlislar Is Nothing OrElse dsAlislar.Tables.Count = 0 OrElse dsAlislar.Tables(0).Rows.Count = 0 Then Return 0
        ' DESC sirali: ilk kayit en yeni alis
        Return BirimMaliyetHesapla(dsAlislar.Tables(0).Rows(0))
    End Function

    ' Agirlikli Ortalama: Toplam tutar / Toplam miktar
    Public Function HesaplaAgirlikliOrtalama(dsAlislar As DataSet) As Decimal
        If dsAlislar Is Nothing OrElse dsAlislar.Tables.Count = 0 OrElse dsAlislar.Tables(0).Rows.Count = 0 Then Return 0
        Dim lToplamMiktar As Decimal = 0
        Dim lToplamMaliyet As Decimal = 0
        For Each dr As DataRow In dsAlislar.Tables(0).Rows
            Dim birimMaliyet As Decimal = BirimMaliyetHesapla(dr)
            Dim miktar As Decimal = CDec(dr("lGirisMiktar1"))
            lToplamMiktar += miktar
            lToplamMaliyet += miktar * birimMaliyet
        Next
        If lToplamMiktar = 0 Then Return 0
        Return lToplamMaliyet / lToplamMiktar
    End Function

    ' Hareketli Ortalama: Her yeni alis sonrasi ortalama yeniden hesaplanir
    Public Function HesaplaHareketliOrtalama(dsAlislar As DataSet) As Decimal
        If dsAlislar Is Nothing OrElse dsAlislar.Tables.Count = 0 OrElse dsAlislar.Tables(0).Rows.Count = 0 Then Return 0
        Dim mevcutMiktar As Decimal = 0
        Dim mevcutTutar As Decimal = 0
        Dim ortMaliyet As Decimal = 0
        For Each dr As DataRow In dsAlislar.Tables(0).Rows
            Dim birimMaliyet As Decimal = BirimMaliyetHesapla(dr)
            Dim miktar As Decimal = CDec(dr("lGirisMiktar1"))
            mevcutTutar = mevcutTutar + (miktar * birimMaliyet)
            mevcutMiktar = mevcutMiktar + miktar
            If mevcutMiktar > 0 Then
                ortMaliyet = mevcutTutar / mevcutMiktar
            End If
        Next
        Return ortMaliyet
    End Function

    ' Gercek Parti Maliyeti: En son alisin gercek birim maliyeti
    Public Function HesaplaGercekParti(dsAlislar As DataSet) As Decimal
        If dsAlislar Is Nothing OrElse dsAlislar.Tables.Count = 0 OrElse dsAlislar.Tables(0).Rows.Count = 0 Then Return 0
        ' DESC sirali: ilk satir en son alis
        Return BirimMaliyetHesapla(dsAlislar.Tables(0).Rows(0))
    End Function

    ' Standart Maliyet: Stok kartindaki tanimlanan standart fiyattan okur
    Public Function HesaplaStandartMaliyet(nStokID As Int64) As Decimal
        Try
            Dim ds As DataSet = KeyCode.sorgu(KeyCode.sorgu_query( _
                "SELECT ISNULL(lFiyat, 0) AS lFiyat FROM tbStokFiyati WHERE nStokID = " & nStokID.ToString() & _
                " AND sFiyatTipi = '" & Trim(KeyCode.sFiyatA) & "'"))
            If ds IsNot Nothing AndAlso ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                Return CDec(ds.Tables(0).Rows(0)("lFiyat"))
            End If
        Catch
        End Try
        Return 0
    End Function

    ' Ana giris noktasi: Verilen yontem ve parametrelere gore birim maliyet hesaplar
    ' maliyetIndex: ComboBox index (3=FIFO, 4=LIFO, 5=AgirlikliOrt, 6=HareketliOrt, 7=GercekParti, 8=StandartMaliyet)
    Public Function HesaplaMaliyet(nStokID As Int64, tarih As DateTime, maliyetIndex As Integer) As Decimal
        Try
            Select Case maliyetIndex
                Case 3 ' FIFO
                    Dim dsAlislar As DataSet = AlisKayitlariGetir(nStokID, tarih, "ASC")
                    Return HesaplaFIFO(dsAlislar)

                Case 4 ' LIFO
                    Dim dsAlislar As DataSet = AlisKayitlariGetir(nStokID, tarih, "DESC")
                    Return HesaplaLIFO(dsAlislar)

                Case 5 ' Agirlikli Ortalama
                    Dim dsAlislar As DataSet = AlisKayitlariGetir(nStokID, tarih, "ASC")
                    Return HesaplaAgirlikliOrtalama(dsAlislar)

                Case 6 ' Hareketli Ortalama
                    Dim dsAlislar As DataSet = AlisKayitlariGetir(nStokID, tarih, "ASC")
                    Return HesaplaHareketliOrtalama(dsAlislar)

                Case 7 ' Gercek Parti Maliyeti
                    Dim dsAlislar As DataSet = AlisKayitlariGetir(nStokID, tarih, "DESC")
                    Return HesaplaGercekParti(dsAlislar)

                Case 8 ' Standart Maliyet
                    Return HesaplaStandartMaliyet(nStokID)

                Case Else
                    Return 0
            End Select
        Catch ex As Exception
            Return 0
        End Try
    End Function

    ' Envanter degeri icin birim maliyet hesaplar (tarih=bugun, nStokID verilir)
    Public Function EnvanterBirimMaliyet(nStokID As Int64, maliyetIndex As Integer) As Decimal
        Return HesaplaMaliyet(nStokID, DateTime.Now, maliyetIndex)
    End Function

End Module
