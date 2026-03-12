''' =============================================
''' AUDIT LOGGER ENTEGRASYON ÖRNEKLERİ
''' Her modül için kullanım örnekleri
''' =============================================

Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class AuditLogEntegrasyonOrnekleri

#Region "1. SİPARİŞ MODÜLÜ - frm_tbSiparis"
    ''' <summary>
    ''' Yeni sipariş oluşturma
    ''' </summary>
    Public Sub Siparis_YeniKayit(siparisID As Long, siparisNo As String, conn As Object)
        Try
            ' Sipariş bilgilerini JSON'a çevir
            Dim siparisData As String = AuditLogger.ToJson(New With {
                .SiparisID = siparisID,
                .SiparisNo = siparisNo,
                .Tarih = DateTime.Now,
                .Durum = "Yeni"
            })

            ' Log kaydet
            AuditLogger.LogInsert(
                AuditLogger.ModulAdi.SIPARIS,
                "tbSiparis",
                siparisID,
                siparisNo,
                siparisData,
                "Yeni sipariş oluşturuldu",
                conn
            )

        Catch ex As Exception
            Debug.WriteLine($"Sipariş log hatası: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Sipariş güncelleme
    ''' </summary>
    Public Sub Siparis_Guncelle(siparisID As Long, siparisNo As String, alanAdi As String, 
                                 eskiDeger As Object, yeniDeger As Object, conn As Object)
        Try
            AuditLogger.LogUpdate(
                AuditLogger.ModulAdi.SIPARIS,
                "tbSiparis",
                siparisID,
                siparisNo,
                alanAdi,
                eskiDeger?.ToString(),
                yeniDeger?.ToString(),
                $"{alanAdi} değiştirildi: {eskiDeger} -> {yeniDeger}",
                conn
            )

        Catch ex As Exception
            Debug.WriteLine($"Sipariş güncelleme log hatası: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Toplu sipariş güncelleme
    ''' </summary>
    Public Sub Siparis_TopluGuncelle(siparisID As Long, siparisNo As String, 
                                      degisiklikler As Dictionary(Of String, String()), conn As Object)
        Try
            ' Örnek degisiklikler:
            ' degisiklikler("sFirmaKodu") = {"ESK_FIRMA", "YEN_FIRMA"}
            ' degisiklikler("lNetTutar") = {"1000.00", "1500.00"}

            AuditLogger.LogUpdateBulk(
                AuditLogger.ModulAdi.SIPARIS,
                "tbSiparis",
                siparisID,
                siparisNo,
                degisiklikler,
                "Sipariş bilgileri toplu güncellendi",
                conn
            )

        Catch ex As Exception
            Debug.WriteLine($"Sipariş toplu güncelleme log hatası: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Sipariş silme (Soft Delete)
    ''' </summary>
    Public Sub Siparis_Sil(siparisID As Long, siparisNo As String, conn As Object)
        Try
            ' Önce sipariş bilgilerini al ve JSON'a çevir
            Dim siparisData As String = SiparisVerileriniAl(siparisID, conn)

            ' Soft delete: bSilindi = 1
            SiparisTablosunuGuncelle(siparisID, True, conn)

            ' Log kaydet
            AuditLogger.LogDelete(
                AuditLogger.ModulAdi.SIPARIS,
                "tbSiparis",
                siparisID,
                siparisNo,
                siparisData,
                "Sipariş silindi",
                conn
            )

        Catch ex As Exception
            Debug.WriteLine($"Sipariş silme log hatası: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Sipariş onaylama
    ''' </summary>
    Public Sub Siparis_Onayla(siparisID As Long, siparisNo As String, conn As Object)
        Try
            AuditLogger.LogApprove(
                AuditLogger.ModulAdi.SIPARIS,
                "tbSiparis",
                siparisID,
                siparisNo,
                "Sipariş sevk onayı verildi",
                conn
            )

        Catch ex As Exception
            Debug.WriteLine($"Sipariş onaylama log hatası: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Sipariş satır ekleme
    ''' </summary>
    Public Sub Siparis_SatirEkle(siparisID As Long, siparisNo As String, satirNo As Integer, 
                                  stokKodu As String, miktar As Decimal, conn As Object)
        Try
            Dim satirData As String = AuditLogger.ToJson(New With {
                .SatirNo = satirNo,
                .StokKodu = stokKodu,
                .Miktar = miktar
            })

            AuditLogger.LogInsert(
                AuditLogger.ModulAdi.SIPARIS,
                "tbSiparisDetay",
                siparisID,
                $"{siparisNo} - Satır {satirNo}",
                satirData,
                $"Sipariş satırı eklendi: {stokKodu} x {miktar}",
                conn
            )

        Catch ex As Exception
            Debug.WriteLine($"Sipariş satır ekleme log hatası: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Sipariş satır silme
    ''' </summary>
    Public Sub Siparis_SatirSil(siparisID As Long, siparisNo As String, satirNo As Integer, 
                                 stokKodu As String, conn As Object)
        Try
            AuditLogger.LogDelete(
                AuditLogger.ModulAdi.SIPARIS,
                "tbSiparisDetay",
                siparisID,
                $"{siparisNo} - Satır {satirNo}",
                $"{{""StokKodu"":""{stokKodu}""}}",
                $"Sipariş satırı silindi: {stokKodu}",
                conn
            )

        Catch ex As Exception
            Debug.WriteLine($"Sipariş satır silme log hatası: {ex.Message}")
        End Try
    End Sub

    ' Helper metodlar
    Private Function SiparisVerileriniAl(siparisID As Long, conn As Object) As String
        ' Sipariş verilerini çek ve JSON'a çevir
        ' Örnek implementasyon
        Return "{""SiparisID"":" & siparisID & "}"
    End Function

    Private Sub SiparisTablosunuGuncelle(siparisID As Long, silindi As Boolean, conn As Object)
        ' UPDATE tbSiparis SET bSilindi=1, dteSilinmeTarihi=GETDATE(), sSilenKullanici='...' WHERE nSiparisID=siparisID
    End Sub
#End Region

#Region "2. FATURA MODÜLÜ - frm_fatura"
    ''' <summary>
    ''' Yeni fatura oluşturma
    ''' </summary>
    Public Sub Fatura_YeniKayit(fisID As Long, fisNo As String, fisTipi As String, conn As Object)
        Try
            Dim faturaData As String = AuditLogger.ToJson(New With {
                .FisID = fisID,
                .FisNo = fisNo,
                .FisTipi = fisTipi,
                .Tarih = DateTime.Now
            })

            AuditLogger.LogInsert(
                AuditLogger.ModulAdi.FATURA,
                "tbStokFisiMaster",
                fisID,
                fisNo,
                faturaData,
                $"{fisTipi} faturası oluşturuldu",
                conn
            )

        Catch ex As Exception
            Debug.WriteLine($"Fatura log hatası: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Fatura tutar değişikliği
    ''' </summary>
    Public Sub Fatura_TutarDegistir(fisID As Long, fisNo As String, eskiTutar As Decimal, 
                                     yeniTutar As Decimal, conn As Object)
        Try
            AuditLogger.LogUpdate(
                AuditLogger.ModulAdi.FATURA,
                "tbStokFisiMaster",
                fisID,
                fisNo,
                "lNetTutar",
                eskiTutar.ToString("N2"),
                yeniTutar.ToString("N2"),
                $"Fatura tutarı değiştirildi: {eskiTutar:N2} TL -> {yeniTutar:N2} TL",
                conn
            )

        Catch ex As Exception
            Debug.WriteLine($"Fatura tutar değişiklik log hatası: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Fatura iskonto değişikliği
    ''' </summary>
    Public Sub Fatura_IskontoDegistir(fisID As Long, fisNo As String, eskiIskonto As Decimal, 
                                       yeniIskonto As Decimal, conn As Object)
        Try
            AuditLogger.LogUpdate(
                AuditLogger.ModulAdi.FATURA,
                "tbStokFisiMaster",
                fisID,
                fisNo,
                "lIskonto",
                eskiIskonto.ToString("N2"),
                yeniIskonto.ToString("N2"),
                $"Fatura iskontosu değiştirildi: %{eskiIskonto} -> %{yeniIskonto}",
                conn
            )

        Catch ex As Exception
            Debug.WriteLine($"Fatura iskonto değişiklik log hatası: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Fatura silme
    ''' </summary>
    Public Sub Fatura_Sil(fisID As Long, fisNo As String, conn As Object)
        Try
            Dim faturaData As String = FaturaVerileriniAl(fisID, conn)

            ' Soft delete
            FaturaTablosunuGuncelle(fisID, True, conn)

            AuditLogger.LogDelete(
                AuditLogger.ModulAdi.FATURA,
                "tbStokFisiMaster",
                fisID,
                fisNo,
                faturaData,
                "Fatura silindi",
                conn
            )

        Catch ex As Exception
            Debug.WriteLine($"Fatura silme log hatası: {ex.Message}")
        End Try
    End Sub

    Private Function FaturaVerileriniAl(fisID As Long, conn As Object) As String
        Return "{""FisID"":" & fisID & "}"
    End Function

    Private Sub FaturaTablosunuGuncelle(fisID As Long, silindi As Boolean, conn As Object)
        ' UPDATE tbStokFisiMaster SET bSilindi=1, dteSilinmeTarihi=GETDATE(), sSilenKullanici='...'
    End Sub
#End Region

#Region "3. PERAKENDE MODÜLÜ - frm_perakende"
    ''' <summary>
    ''' Perakende satış kaydı
    ''' </summary>
    Public Sub Perakende_SatisKayit(fisID As Long, fisNo As String, tutar As Decimal, conn As Object)
        Try
            Dim satisData As String = AuditLogger.ToJson(New With {
                .FisID = fisID,
                .FisNo = fisNo,
                .Tutar = tutar,
                .Tarih = DateTime.Now
            })

            AuditLogger.LogInsert(
                AuditLogger.ModulAdi.PERAKENDE,
                "tbStokFisiMaster",
                fisID,
                fisNo,
                satisData,
                $"Perakende satış: {tutar:N2} TL",
                conn
            )

        Catch ex As Exception
            Debug.WriteLine($"Perakende satış log hatası: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Perakende ödeme değişikliği
    ''' </summary>
    Public Sub Perakende_OdemeDegistir(fisID As Long, fisNo As String, odemeSekli As String, 
                                        eskiTutar As Decimal, yeniTutar As Decimal, conn As Object)
        Try
            AuditLogger.LogUpdate(
                AuditLogger.ModulAdi.PERAKENDE,
                "tbPerakendeOdeme",
                fisID,
                fisNo,
                $"OdemeTutar_{odemeSekli}",
                eskiTutar.ToString("N2"),
                yeniTutar.ToString("N2"),
                $"{odemeSekli} ödeme tutarı değişti: {eskiTutar:N2} -> {yeniTutar:N2} TL",
                conn
            )

        Catch ex As Exception
            Debug.WriteLine($"Perakende ödeme değişiklik log hatası: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Perakende satış iptali
    ''' </summary>
    Public Sub Perakende_SatisIptal(fisID As Long, fisNo As String, conn As Object)
        Try
            AuditLogger.LogCancel(
                AuditLogger.ModulAdi.PERAKENDE,
                "tbStokFisiMaster",
                fisID,
                fisNo,
                "Perakende satış iptal edildi",
                conn
            )

        Catch ex As Exception
            Debug.WriteLine($"Perakende iptal log hatası: {ex.Message}")
        End Try
    End Sub
#End Region

#Region "4. STOK MODÜLÜ - frm_Stok"
    ''' <summary>
    ''' Yeni stok kartı
    ''' </summary>
    Public Sub Stok_YeniKart(stokID As Long, stokKodu As String, stokAdi As String, conn As Object)
        Try
            Dim stokData As String = AuditLogger.ToJson(New With {
                .StokID = stokID,
                .StokKodu = stokKodu,
                .StokAdi = stokAdi
            })

            AuditLogger.LogInsert(
                AuditLogger.ModulAdi.STOK,
                "tbStok",
                stokID,
                stokKodu,
                stokData,
                $"Yeni stok kartı: {stokKodu} - {stokAdi}",
                conn
            )

        Catch ex As Exception
            Debug.WriteLine($"Stok kart log hatası: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Stok fiyat değişikliği
    ''' </summary>
    Public Sub Stok_FiyatDegistir(stokID As Long, stokKodu As String, fiyatTipi As String,
                                   eskiFiyat As Decimal, yeniFiyat As Decimal, conn As Object)
        Try
            AuditLogger.LogUpdate(
                AuditLogger.ModulAdi.STOK,
                "tbStok",
                stokID,
                stokKodu,
                fiyatTipi,
                eskiFiyat.ToString("N2"),
                yeniFiyat.ToString("N2"),
                $"{stokKodu} {fiyatTipi} değişti: {eskiFiyat:N2} -> {yeniFiyat:N2} TL",
                conn
            )

        Catch ex As Exception
            Debug.WriteLine($"Stok fiyat değişiklik log hatası: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Stok kartı silme
    ''' </summary>
    Public Sub Stok_KartSil(stokID As Long, stokKodu As String, conn As Object)
        Try
            Dim stokData As String = StokVerileriniAl(stokID, conn)

            ' Soft delete
            StokTablosunuGuncelle(stokID, True, conn)

            AuditLogger.LogDelete(
                AuditLogger.ModulAdi.STOK,
                "tbStok",
                stokID,
                stokKodu,
                stokData,
                "Stok kartı silindi",
                conn
            )

        Catch ex As Exception
            Debug.WriteLine($"Stok silme log hatası: {ex.Message}")
        End Try
    End Sub

    Private Function StokVerileriniAl(stokID As Long, conn As Object) As String
        Return "{""StokID"":" & stokID & "}"
    End Function

    Private Sub StokTablosunuGuncelle(stokID As Long, silindi As Boolean, conn As Object)
        ' UPDATE tbStok SET bSilindi=1, dteSilinmeTarihi=GETDATE(), sSilenKullanici='...'
    End Sub
#End Region

#Region "5. MÜŞTERİ MODÜLÜ - frm_Musteri_kart"
    ''' <summary>
    ''' Yeni müşteri kartı
    ''' </summary>
    Public Sub Musteri_YeniKart(cariID As Long, cariKodu As String, cariUnvan As String, conn As Object)
        Try
            Dim musteriData As String = AuditLogger.ToJson(New With {
                .CariID = cariID,
                .CariKodu = cariKodu,
                .CariUnvan = cariUnvan
            })

            AuditLogger.LogInsert(
                AuditLogger.ModulAdi.MUSTERI,
                "tbCari",
                cariID,
                cariKodu,
                musteriData,
                $"Yeni müşteri: {cariKodu} - {cariUnvan}",
                conn
            )

        Catch ex As Exception
            Debug.WriteLine($"Müşteri kart log hatası: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Müşteri bilgi güncelleme
    ''' </summary>
    Public Sub Musteri_BilgiGuncelle(cariID As Long, cariKodu As String, alanAdi As String,
                                      eskiDeger As String, yeniDeger As String, conn As Object)
        Try
            AuditLogger.LogUpdate(
                AuditLogger.ModulAdi.MUSTERI,
                "tbCari",
                cariID,
                cariKodu,
                alanAdi,
                eskiDeger,
                yeniDeger,
                $"{cariKodu} {alanAdi} güncellendi",
                conn
            )

        Catch ex As Exception
            Debug.WriteLine($"Müşteri güncelleme log hatası: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Müşteri kartı silme
    ''' </summary>
    Public Sub Musteri_KartSil(cariID As Long, cariKodu As String, conn As Object)
        Try
            Dim musteriData As String = MusteriVerileriniAl(cariID, conn)

            ' Soft delete
            CariTablosunuGuncelle(cariID, True, conn)

            AuditLogger.LogDelete(
                AuditLogger.ModulAdi.MUSTERI,
                "tbCari",
                cariID,
                cariKodu,
                musteriData,
                "Müşteri kartı silindi",
                conn
            )

        Catch ex As Exception
            Debug.WriteLine($"Müşteri silme log hatası: {ex.Message}")
        End Try
    End Sub

    Private Function MusteriVerileriniAl(cariID As Long, conn As Object) As String
        Return "{""CariID"":" & cariID & "}"
    End Function

    Private Sub CariTablosunuGuncelle(cariID As Long, silindi As Boolean, conn As Object)
        ' UPDATE tbCari SET bSilindi=1, dteSilinmeTarihi=GETDATE(), sSilenKullanici='...'
    End Sub
#End Region

#Region "6. FİNANS MODÜLÜ - frm_Finans"
    ''' <summary>
    ''' Yeni finans hareketi
    ''' </summary>
    Public Sub Finans_YeniHareket(finansID As Long, islemNo As String, islemTipi As String, 
                                   tutar As Decimal, conn As Object)
        Try
            Dim finansData As String = AuditLogger.ToJson(New With {
                .FinansID = finansID,
                .IslemNo = islemNo,
                .IslemTipi = islemTipi,
                .Tutar = tutar,
                .Tarih = DateTime.Now
            })

            AuditLogger.LogInsert(
                AuditLogger.ModulAdi.FINANS,
                "tbFinans",
                finansID,
                islemNo,
                finansData,
                $"{islemTipi} işlemi: {tutar:N2} TL",
                conn
            )

        Catch ex As Exception
            Debug.WriteLine($"Finans hareket log hatası: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Finans tutar değişikliği
    ''' </summary>
    Public Sub Finans_TutarDegistir(finansID As Long, islemNo As String, eskiTutar As Decimal, 
                                     yeniTutar As Decimal, conn As Object)
        Try
            AuditLogger.LogUpdate(
                AuditLogger.ModulAdi.FINANS,
                "tbFinans",
                finansID,
                islemNo,
                "lTutar",
                eskiTutar.ToString("N2"),
                yeniTutar.ToString("N2"),
                $"Finans tutarı değişti: {eskiTutar:N2} -> {yeniTutar:N2} TL",
                conn
            )

        Catch ex As Exception
            Debug.WriteLine($"Finans tutar değişiklik log hatası: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Finans işlemi silme
    ''' </summary>
    Public Sub Finans_IslemSil(finansID As Long, islemNo As String, conn As Object)
        Try
            Dim finansData As String = FinansVerileriniAl(finansID, conn)

            AuditLogger.LogDelete(
                AuditLogger.ModulAdi.FINANS,
                "tbFinans",
                finansID,
                islemNo,
                finansData,
                "Finans işlemi silindi",
                conn
            )

        Catch ex As Exception
            Debug.WriteLine($"Finans silme log hatası: {ex.Message}")
        End Try
    End Sub

    Private Function FinansVerileriniAl(finansID As Long, conn As Object) As String
        Return "{""FinansID"":" & finansID & "}"
    End Function
#End Region

#Region "KULLANIM ÖRNEĞİ - Sipariş Formunda"
    ''' <summary>
    ''' Sipariş formunda kaydet butonuna basıldığında
    ''' </summary>
    Public Sub Ornek_SiparisDegisiklikTakip()
        ' ====================================
        ' ÖNCEKİ KOD (Eski değerleri sakla)
        ' ====================================
        Dim eskiSiparisRow As DataRow = Nothing ' Mevcut kayıt
        
        ' ====================================
        ' KAYDETME İŞLEMİ (Mevcut kodunuz)
        ' ====================================
        Dim siparisID As Long = 12345
        Dim siparisNo As String = "SIP-2025-001"
        ' ... kaydetme işlemleri ...
        
        ' ====================================
        ' YENİ KOD (Değişiklikleri logla)
        ' ====================================
        Dim conn As Object = Nothing ' Veritabanı bağlantınız
        
        Try
            If eskiSiparisRow IsNot Nothing Then
                ' GÜNCELLEME - Değişiklikleri bul ve logla
                Dim yeniSiparisRow As DataRow = Nothing ' Güncel kayıt
                Dim degisiklikler As Dictionary(Of String, String()) = AuditLogger.GetDegisiklikler(eskiSiparisRow, yeniSiparisRow)
                
                If degisiklikler.Count > 0 Then
                    Dim ornekEntegrasyon As New AuditLogEntegrasyonOrnekleri()
                    ornekEntegrasyon.Siparis_TopluGuncelle(siparisID, siparisNo, degisiklikler, conn)
                End If
            Else
                ' YENİ KAYIT
                Dim ornekEntegrasyon As New AuditLogEntegrasyonOrnekleri()
                ornekEntegrasyon.Siparis_YeniKayit(siparisID, siparisNo, conn)
            End If
            
        Catch ex As Exception
            ' Log hatası uygulamayı etkilemez
            Debug.WriteLine($"Audit log hatası: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Sipariş satırı eklendiğinde
    ''' </summary>
    Public Sub Ornek_SiparisSatirEkle()
        Dim siparisID As Long = 12345
        Dim siparisNo As String = "SIP-2025-001"
        Dim satirNo As Integer = 1
        Dim stokKodu As String = "URN-001"
        Dim miktar As Decimal = 10
        Dim conn As Object = Nothing
        
        ' Satır ekleme işlemi (mevcut kodunuz)
        ' ...
        
        ' Log kaydet
        Try
            Dim ornekEntegrasyon As New AuditLogEntegrasyonOrnekleri()
            ornekEntegrasyon.Siparis_SatirEkle(siparisID, siparisNo, satirNo, stokKodu, miktar, conn)
        Catch ex As Exception
            Debug.WriteLine($"Audit log hatası: {ex.Message}")
        End Try
    End Sub

    ''' <summary>
    ''' Sipariş onaylandığında
    ''' </summary>
    Public Sub Ornek_SiparisOnayla()
        Dim siparisID As Long = 12345
        Dim siparisNo As String = "SIP-2025-001"
        Dim conn As Object = Nothing
        
        ' Onay işlemi (mevcut kodunuz)
        ' UPDATE tbSiparis SET bOnaylandi=1 WHERE nSiparisID=siparisID
        
        ' Log kaydet
        Try
            Dim ornekEntegrasyon As New AuditLogEntegrasyonOrnekleri()
            ornekEntegrasyon.Siparis_Onayla(siparisID, siparisNo, conn)
        Catch ex As Exception
            Debug.WriteLine($"Audit log hatası: {ex.Message}")
        End Try
    End Sub
#End Region
End Class
