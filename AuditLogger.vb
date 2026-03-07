Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Text
Imports System.Collections.Generic
Imports Newtonsoft.Json

''' <summary>
''' Audit Log Helper Class
''' Tüm modüllerdeki işlemleri kaydeden merkezi loglama sınıfı
''' Versiyon: 1.0
''' Oluşturma: 2025-12-11
''' </summary>
Public Class AuditLogger
#Region "Enums"
    ''' <summary>
    ''' İşlem Tipleri
    ''' </summary>
    Public Enum IslemTipi
        INSERT      ' Yeni kayıt
        UPDATE      ' Güncelleme
        DELETE      ' Silme
        APPROVE     ' Onay
        CANCEL      ' İptal
        RESTORE     ' Geri yükleme
        ROLLBACK    ' Geri alma
        VIEW        ' Görüntüleme
        PRINT       ' Yazdırma
        EXPORT      ' Dışa aktarma
    End Enum

    ''' <summary>
    ''' Modül Adları
    ''' </summary>
    Public Enum ModulAdi
        SIPARIS     ' Sipariş
        FATURA      ' Fatura
        PERAKENDE   ' Perakende
        STOK        ' Stok
        MUSTERI     ' Müşteri/Cari
        FINANS      ' Finans
        ETICARET    ' E-Ticaret
        PERSONEL    ' Personel
        PARAMETRE   ' Parametre
        SISTEM      ' Sistem
    End Enum
#End Region

#Region "Properties"
    ''' <summary>
    ''' Aktif kullanıcı adı (Global değişkenden alınacak)
    ''' </summary>
    Public Shared Property AktifKullanici As String = ""

    ''' <summary>
    ''' Uygulama versiyonu
    ''' </summary>
    Public Shared Property UygulamaVersiyon As String = "1.0.0"

    ''' <summary>
    ''' Loglama aktif mi?
    ''' </summary>
    Public Shared Property LoglamaAktif As Boolean = True

    ''' <summary>
    ''' Detaylı loglama (alan bazında)
    ''' </summary>
    Public Shared Property DetayliLoglama As Boolean = True

    ''' <summary>
    ''' Sistem bilgilerini cache'le (performans için)
    ''' </summary>
    Private Shared _sistemBilgileriCache As SistemBilgileri = Nothing
    Private Shared _cacheOlusturmaZamani As DateTime = DateTime.MinValue
#End Region

#Region "Structures"
    ''' <summary>
    ''' Sistem bilgileri yapısı
    ''' </summary>
    Private Structure SistemBilgileri
        Public BilgisayarAdi As String
        Public IPAdresi As String
        Public MACAdres As String
        Public WindowsKullanici As String
    End Structure

    ''' <summary>
    ''' Audit log kaydı yapısı
    ''' </summary>
    Public Structure AuditLogKayit
        Public ModulAdi As String
        Public TabloAdi As String
        Public KayitID As Long?
        Public KayitReferans As String
        Public IslemTipi As String
        Public IslemAciklama As String
        Public AlanAdi As String
        Public EskiDeger As String
        Public YeniDeger As String
        Public JsonData As String
        Public KullaniciAdi As String
        Public WindowsKullanici As String
        Public BilgisayarAdi As String
        Public IPAdresi As String
        Public MACAdres As String
        Public UygulamaVersiyon As String
        Public IslemSuresi As Integer?
        Public EkNotlar As String
    End Structure
#End Region

#Region "Public Methods"
    ''' <summary>
    ''' Yeni kayıt oluşturma logla
    ''' </summary>
    Public Shared Function LogInsert(modul As ModulAdi, tabloAdi As String, kayitID As Long, 
                                      kayitReferans As String, jsonData As String, 
                                      Optional aciklama As String = "", 
                                      Optional conn As Object = Nothing) As Boolean
        If Not LoglamaAktif Then Return True

        Try
            Dim kayit As New AuditLogKayit With {
                .ModulAdi = modul.ToString(),
                .TabloAdi = tabloAdi,
                .KayitID = kayitID,
                .KayitReferans = kayitReferans,
                .IslemTipi = IslemTipi.INSERT.ToString(),
                .IslemAciklama = If(String.IsNullOrEmpty(aciklama), "Yeni kayıt oluşturuldu", aciklama),
                .JsonData = jsonData
            }

            Return LogKaydet(kayit, conn)
        Catch ex As Exception
            LogHata("LogInsert", ex)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Güncelleme işlemini logla
    ''' </summary>
    Public Shared Function LogUpdate(modul As ModulAdi, tabloAdi As String, kayitID As Long,
                                      kayitReferans As String, alanAdi As String,
                                      eskiDeger As String, yeniDeger As String,
                                      Optional aciklama As String = "",
                                      Optional conn As Object = Nothing) As Boolean
        If Not LoglamaAktif Then Return True

        Try
            ' Değer değişmemişse logla
            If eskiDeger = yeniDeger Then Return True

            Dim kayit As New AuditLogKayit With {
                .ModulAdi = modul.ToString(),
                .TabloAdi = tabloAdi,
                .KayitID = kayitID,
                .KayitReferans = kayitReferans,
                .IslemTipi = IslemTipi.UPDATE.ToString(),
                .IslemAciklama = If(String.IsNullOrEmpty(aciklama), $"{alanAdi} güncellendi", aciklama),
                .AlanAdi = alanAdi,
                .EskiDeger = eskiDeger,
                .YeniDeger = yeniDeger
            }

            Return LogKaydet(kayit, conn)
        Catch ex As Exception
            LogHata("LogUpdate", ex)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Toplu güncelleme işlemini logla
    ''' </summary>
    Public Shared Function LogUpdateBulk(modul As ModulAdi, tabloAdi As String, kayitID As Long,
                                         kayitReferans As String, degisiklikler As Dictionary(Of String, String()),
                                         Optional aciklama As String = "",
                                         Optional conn As Object = Nothing) As Boolean
        If Not LoglamaAktif Then Return True
        If degisiklikler Is Nothing OrElse degisiklikler.Count = 0 Then Return True

        Try
            Dim basarili As Boolean = True

            For Each kvp As KeyValuePair(Of String, String()) In degisiklikler
                Dim alanAdi As String = kvp.Key
                Dim eskiDeger As String = If(kvp.Value.Length > 0, kvp.Value(0), "")
                Dim yeniDeger As String = If(kvp.Value.Length > 1, kvp.Value(1), "")

                basarili = basarili And LogUpdate(modul, tabloAdi, kayitID, kayitReferans, 
                                                   alanAdi, eskiDeger, yeniDeger, aciklama, conn)
            Next

            Return basarili
        Catch ex As Exception
            LogHata("LogUpdateBulk", ex)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Silme işlemini logla (Soft Delete)
    ''' </summary>
    Public Shared Function LogDelete(modul As ModulAdi, tabloAdi As String, kayitID As Long,
                                      kayitReferans As String, jsonData As String,
                                      Optional aciklama As String = "",
                                      Optional conn As Object = Nothing) As Boolean
        If Not LoglamaAktif Then Return True

        Try
            Dim kayit As New AuditLogKayit With {
                .ModulAdi = modul.ToString(),
                .TabloAdi = tabloAdi,
                .KayitID = kayitID,
                .KayitReferans = kayitReferans,
                .IslemTipi = IslemTipi.DELETE.ToString(),
                .IslemAciklama = If(String.IsNullOrEmpty(aciklama), "Kayıt silindi", aciklama),
                .JsonData = jsonData
            }

            Return LogKaydet(kayit, conn)
        Catch ex As Exception
            LogHata("LogDelete", ex)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Onay işlemini logla
    ''' </summary>
    Public Shared Function LogApprove(modul As ModulAdi, tabloAdi As String, kayitID As Long,
                                       kayitReferans As String,
                                       Optional aciklama As String = "",
                                       Optional conn As Object = Nothing) As Boolean
        If Not LoglamaAktif Then Return True

        Try
            Dim kayit As New AuditLogKayit With {
                .ModulAdi = modul.ToString(),
                .TabloAdi = tabloAdi,
                .KayitID = kayitID,
                .KayitReferans = kayitReferans,
                .IslemTipi = IslemTipi.APPROVE.ToString(),
                .IslemAciklama = If(String.IsNullOrEmpty(aciklama), "Kayıt onaylandı", aciklama)
            }

            Return LogKaydet(kayit, conn)
        Catch ex As Exception
            LogHata("LogApprove", ex)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' İptal işlemini logla
    ''' </summary>
    Public Shared Function LogCancel(modul As ModulAdi, tabloAdi As String, kayitID As Long,
                                      kayitReferans As String,
                                      Optional aciklama As String = "",
                                      Optional conn As Object = Nothing) As Boolean
        If Not LoglamaAktif Then Return True

        Try
            Dim kayit As New AuditLogKayit With {
                .ModulAdi = modul.ToString(),
                .TabloAdi = tabloAdi,
                .KayitID = kayitID,
                .KayitReferans = kayitReferans,
                .IslemTipi = IslemTipi.CANCEL.ToString(),
                .IslemAciklama = If(String.IsNullOrEmpty(aciklama), "Kayıt iptal edildi", aciklama)
            }

            Return LogKaydet(kayit, conn)
        Catch ex As Exception
            LogHata("LogCancel", ex)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Geri yükleme işlemini logla
    ''' </summary>
    Public Shared Function LogRestore(modul As ModulAdi, tabloAdi As String, kayitID As Long,
                                       kayitReferans As String, jsonData As String,
                                       Optional aciklama As String = "",
                                       Optional conn As Object = Nothing) As Boolean
        If Not LoglamaAktif Then Return True

        Try
            Dim kayit As New AuditLogKayit With {
                .ModulAdi = modul.ToString(),
                .TabloAdi = tabloAdi,
                .KayitID = kayitID,
                .KayitReferans = kayitReferans,
                .IslemTipi = IslemTipi.RESTORE.ToString(),
                .IslemAciklama = If(String.IsNullOrEmpty(aciklama), "Silinen kayıt geri yüklendi", aciklama),
                .JsonData = jsonData
            }

            Return LogKaydet(kayit, conn)
        Catch ex As Exception
            LogHata("LogRestore", ex)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Kayıt geçmişini getir
    ''' </summary>
    Public Shared Function GetKayitGecmisi(modul As ModulAdi, kayitID As Long, 
                                            Optional conn As Object = Nothing) As DataTable
        Try
            Dim dt As New DataTable()
            Dim baglanti As Object = If(conn, YeniBaglanti())
            Dim cmd As Object

            ' SQL Server veya Access'e göre komut oluştur
            If TypeOf baglanti Is SqlConnection Then
                cmd = New SqlCommand("sp_AuditLog_KayitGecmisi", baglanti)
                DirectCast(cmd, SqlCommand).CommandType = CommandType.StoredProcedure
                DirectCast(cmd, SqlCommand).Parameters.AddWithValue("@sModulAdi", modul.ToString())
                DirectCast(cmd, SqlCommand).Parameters.AddWithValue("@nKayitID", kayitID)
            Else
                ' Access için sorgu
                Dim query As String = "SELECT * FROM tbAuditLog WHERE sModulAdi=? AND nKayitID=? ORDER BY dteIslemZamani DESC"
                cmd = New OleDbCommand(query, baglanti)
                DirectCast(cmd, OleDbCommand).Parameters.AddWithValue("@sModulAdi", modul.ToString())
                DirectCast(cmd, OleDbCommand).Parameters.AddWithValue("@nKayitID", kayitID)
            End If

            ' Bağlantı kapalıysa aç
            If baglanti.State = ConnectionState.Closed Then baglanti.Open()

            ' Veriyi doldur
            If TypeOf baglanti Is SqlConnection Then
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            Else
                Dim da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End If

            ' Bağlantıyı kapat (eğer biz açtıysak)
            If conn Is Nothing Then baglanti.Close()

            Return dt
        Catch ex As Exception
            LogHata("GetKayitGecmisi", ex)
            Return New DataTable()
        End Try
    End Function

    ''' <summary>
    ''' Silinen kayıtları getir
    ''' </summary>
    Public Shared Function GetSilinenKayitlar(modul As ModulAdi, Optional conn As Object = Nothing) As DataTable
        Try
            Dim dt As New DataTable()
            Dim baglanti As Object = If(conn, YeniBaglanti())
            Dim query As String = "SELECT * FROM tbAuditLog WHERE sModulAdi=? AND sIslemTipi='DELETE' AND bGeriAlindi=0 ORDER BY dteIslemZamani DESC"

            Dim cmd As Object
            If TypeOf baglanti Is SqlConnection Then
                cmd = New SqlCommand(query.Replace("?", "@p"), baglanti)
                DirectCast(cmd, SqlCommand).Parameters.AddWithValue("@p", modul.ToString())
            Else
                cmd = New OleDbCommand(query, baglanti)
                DirectCast(cmd, OleDbCommand).Parameters.AddWithValue("@p", modul.ToString())
            End If

            If baglanti.State = ConnectionState.Closed Then baglanti.Open()

            If TypeOf baglanti Is SqlConnection Then
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            Else
                Dim da As New OleDbDataAdapter(cmd)
                da.Fill(dt)
            End If

            If conn Is Nothing Then baglanti.Close()

            Return dt
        Catch ex As Exception
            LogHata("GetSilinenKayitlar", ex)
            Return New DataTable()
        End Try
    End Function
#End Region

#Region "Private Methods"
    ''' <summary>
    ''' Log kaydını veritabanına kaydet
    ''' </summary>
    Private Shared Function LogKaydet(kayit As AuditLogKayit, Optional conn As Object = Nothing) As Boolean
        Try
            ' Sistem bilgilerini al
            Dim sistemBilgi As SistemBilgileri = GetSistemBilgileri()

            ' Kayıt bilgilerini tamamla
            kayit.KullaniciAdi = If(String.IsNullOrEmpty(AktifKullanici), "Sistem", AktifKullanici)
            kayit.WindowsKullanici = sistemBilgi.WindowsKullanici
            kayit.BilgisayarAdi = sistemBilgi.BilgisayarAdi
            kayit.IPAdresi = sistemBilgi.IPAdresi
            kayit.MACAdres = sistemBilgi.MACAdres
            kayit.UygulamaVersiyon = UygulamaVersiyon

            ' Veritabanına kaydet
            Dim baglanti As Object = If(conn, YeniBaglanti())
            Dim cmd As Object

            If TypeOf baglanti Is SqlConnection Then
                ' SQL Server için
                cmd = New SqlCommand("sp_AuditLog_Kaydet", baglanti)
                With DirectCast(cmd, SqlCommand)
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@sModulAdi", kayit.ModulAdi)
                    .Parameters.AddWithValue("@sTabloAdi", kayit.TabloAdi)
                    .Parameters.AddWithValue("@nKayitID", If(kayit.KayitID, DBNull.Value))
                    .Parameters.AddWithValue("@sKayitReferans", If(kayit.KayitReferans, DBNull.Value))
                    .Parameters.AddWithValue("@sIslemTipi", kayit.IslemTipi)
                    .Parameters.AddWithValue("@sIslemAciklama", If(kayit.IslemAciklama, DBNull.Value))
                    .Parameters.AddWithValue("@sAlanAdi", If(kayit.AlanAdi, DBNull.Value))
                    .Parameters.AddWithValue("@sEskiDeger", If(kayit.EskiDeger, DBNull.Value))
                    .Parameters.AddWithValue("@sYeniDeger", If(kayit.YeniDeger, DBNull.Value))
                    .Parameters.AddWithValue("@sJsonData", If(kayit.JsonData, DBNull.Value))
                    .Parameters.AddWithValue("@sKullaniciAdi", kayit.KullaniciAdi)
                    .Parameters.AddWithValue("@sWindowsKullanici", If(kayit.WindowsKullanici, DBNull.Value))
                    .Parameters.AddWithValue("@sBilgisayarAdi", If(kayit.BilgisayarAdi, DBNull.Value))
                    .Parameters.AddWithValue("@sIPAdresi", If(kayit.IPAdresi, DBNull.Value))
                    .Parameters.AddWithValue("@sMACAdres", If(kayit.MACAdres, DBNull.Value))
                    .Parameters.AddWithValue("@sUygulamaVersiyon", If(kayit.UygulamaVersiyon, DBNull.Value))
                    .Parameters.AddWithValue("@nIslemSuresi", If(kayit.IslemSuresi, DBNull.Value))
                    .Parameters.AddWithValue("@sEkNotlar", If(kayit.EkNotlar, DBNull.Value))

                    Dim outputParam As New SqlParameter("@nYeniAuditLogID", SqlDbType.BigInt)
                    outputParam.Direction = ParameterDirection.Output
                    .Parameters.Add(outputParam)
                End With
            Else
                ' Access için INSERT sorgusu
                Dim query As String = "INSERT INTO tbAuditLog (sModulAdi, sTabloAdi, nKayitID, sKayitReferans, " &
                                     "sIslemTipi, sIslemAciklama, sAlanAdi, sEskiDeger, sYeniDeger, sJsonData, " &
                                     "sKullaniciAdi, sWindowsKullanici, dteIslemZamani, sBilgisayarAdi, sIPAdresi, " &
                                     "sMACAdres, sUygulamaVersiyon, nIslemSuresi, sEkNotlar) " &
                                     "VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"

                cmd = New OleDbCommand(query, baglanti)
                With DirectCast(cmd, OleDbCommand)
                    .Parameters.AddWithValue("@p1", kayit.ModulAdi)
                    .Parameters.AddWithValue("@p2", kayit.TabloAdi)
                    .Parameters.AddWithValue("@p3", If(kayit.KayitID, DBNull.Value))
                    .Parameters.AddWithValue("@p4", If(kayit.KayitReferans, DBNull.Value))
                    .Parameters.AddWithValue("@p5", kayit.IslemTipi)
                    .Parameters.AddWithValue("@p6", If(kayit.IslemAciklama, DBNull.Value))
                    .Parameters.AddWithValue("@p7", If(kayit.AlanAdi, DBNull.Value))
                    .Parameters.AddWithValue("@p8", If(kayit.EskiDeger, DBNull.Value))
                    .Parameters.AddWithValue("@p9", If(kayit.YeniDeger, DBNull.Value))
                    .Parameters.AddWithValue("@p10", If(kayit.JsonData, DBNull.Value))
                    .Parameters.AddWithValue("@p11", kayit.KullaniciAdi)
                    .Parameters.AddWithValue("@p12", If(kayit.WindowsKullanici, DBNull.Value))
                    .Parameters.AddWithValue("@p13", DateTime.Now)
                    .Parameters.AddWithValue("@p14", If(kayit.BilgisayarAdi, DBNull.Value))
                    .Parameters.AddWithValue("@p15", If(kayit.IPAdresi, DBNull.Value))
                    .Parameters.AddWithValue("@p16", If(kayit.MACAdres, DBNull.Value))
                    .Parameters.AddWithValue("@p17", If(kayit.UygulamaVersiyon, DBNull.Value))
                    .Parameters.AddWithValue("@p18", If(kayit.IslemSuresi, DBNull.Value))
                    .Parameters.AddWithValue("@p19", If(kayit.EkNotlar, DBNull.Value))
                End With
            End If

            ' Bağlantı kapalıysa aç
            If baglanti.State = ConnectionState.Closed Then baglanti.Open()

            ' Komutu çalıştır
            If TypeOf cmd Is SqlCommand Then
                DirectCast(cmd, SqlCommand).ExecuteNonQuery()
            Else
                DirectCast(cmd, OleDbCommand).ExecuteNonQuery()
            End If

            ' Bağlantıyı kapat (eğer biz açtıysak)
            If conn Is Nothing Then baglanti.Close()

            Return True
        Catch ex As Exception
            LogHata("LogKaydet", ex)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Sistem bilgilerini al (cache ile)
    ''' </summary>
    Private Shared Function GetSistemBilgileri() As SistemBilgileri
        Try
            ' Cache 5 dakikadan eskiyse yenile
            If _sistemBilgileriCache.BilgisayarAdi Is Nothing OrElse 
               (DateTime.Now - _cacheOlusturmaZamani).TotalMinutes > 5 Then

                Dim bilgi As New SistemBilgileri With {
                    .BilgisayarAdi = Environment.MachineName,
                    .WindowsKullanici = Environment.UserDomainName & "\" & Environment.UserName,
                    .IPAdresi = GetLocalIPAddress(),
                    .MACAdres = GetMACAddress()
                }

                _sistemBilgileriCache = bilgi
                _cacheOlusturmaZamani = DateTime.Now
            End If

            Return _sistemBilgileriCache
        Catch ex As Exception
            LogHata("GetSistemBilgileri", ex)
            Return New SistemBilgileri()
        End Try
    End Function

    ''' <summary>
    ''' Yerel IP adresini al
    ''' </summary>
    Private Shared Function GetLocalIPAddress() As String
        Try
            Dim host As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName())
            For Each ip As IPAddress In host.AddressList
                If ip.AddressFamily = Sockets.AddressFamily.InterNetwork Then
                    Return ip.ToString()
                End If
            Next
            Return "0.0.0.0"
        Catch ex As Exception
            Return "0.0.0.0"
        End Try
    End Function

    ''' <summary>
    ''' MAC adresini al
    ''' </summary>
    Private Shared Function GetMACAddress() As String
        Try
            Dim macAddresses As New StringBuilder()
            Dim interfaces() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()

            For Each adapter As NetworkInterface In interfaces
                If adapter.OperationalStatus = OperationalStatus.Up AndAlso 
                   adapter.NetworkInterfaceType <> NetworkInterfaceType.Loopback Then
                    Dim properties As IPInterfaceProperties = adapter.GetIPProperties()
                    Dim mac As PhysicalAddress = adapter.GetPhysicalAddress()
                    
                    If mac IsNot Nothing AndAlso mac.ToString() <> "" Then
                        If macAddresses.Length > 0 Then macAddresses.Append("; ")
                        macAddresses.Append(mac.ToString())
                    End If
                End If
            Next

            Return If(macAddresses.Length > 0, macAddresses.ToString(), "N/A")
        Catch ex As Exception
            Return "N/A"
        End Try
    End Function

    ''' <summary>
    ''' Yeni bağlantı oluştur (Registry'den bağlantı string alır)
    ''' </summary>
    Private Shared Function YeniBaglanti() As Object
        Try
            ' Registry'den bağlantı string al (Form1'deki yöntemle aynı)
            Dim connectionString As String = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("UGURLU").ToString()
            
            Dim conn As New OleDbConnection()
            conn.ConnectionString = connectionString
            Return conn
        Catch ex As Exception
            LogHata("YeniBaglanti", ex)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Hata logla (konsola veya dosyaya)
    ''' </summary>
    Private Shared Sub LogHata(metodAdi As String, ex As Exception)
        Try
            Dim hataMsg As String = $"[AUDIT LOG HATASI] {DateTime.Now:yyyy-MM-dd HH:mm:ss} - {metodAdi}: {ex.Message}"
            Console.WriteLine(hataMsg)
            Debug.WriteLine(hataMsg)
            
            ' İsteğe bağlı: Dosyaya yazabilirsiniz
            ' System.IO.File.AppendAllText("AuditLogHatalari.txt", hataMsg & vbCrLf)
        Catch
            ' Hata loglama bile başarısız olursa sessizce devam et
        End Try
    End Sub
#End Region

#Region "Helper Methods"
    ''' <summary>
    ''' Nesneyi JSON'a çevir
    ''' </summary>
    Public Shared Function ToJson(obj As Object) As String
        Try
            Return JsonConvert.SerializeObject(obj, Formatting.None)
        Catch ex As Exception
            Return "{""error"":""JSON serialize hatası""}"
        End Try
    End Function

    ''' <summary>
    ''' DataRow'u JSON'a çevir
    ''' </summary>
    Public Shared Function DataRowToJson(row As DataRow) As String
        Try
            Dim dict As New Dictionary(Of String, Object)
            For Each col As DataColumn In row.Table.Columns
                dict(col.ColumnName) = If(IsDBNull(row(col)), Nothing, row(col))
            Next
            Return ToJson(dict)
        Catch ex As Exception
            Return "{""error"":""DataRow serialize hatası""}"
        End Try
    End Function

    ''' <summary>
    ''' Değerleri karşılaştır ve değişiklikleri döndür
    ''' </summary>
    Public Shared Function GetDegisiklikler(eskiRow As DataRow, yeniRow As DataRow) As Dictionary(Of String, String())
        Dim degisiklikler As New Dictionary(Of String, String())

        Try
            For Each col As DataColumn In eskiRow.Table.Columns
                Dim eskiDeger As String = If(IsDBNull(eskiRow(col)), "", eskiRow(col).ToString())
                Dim yeniDeger As String = If(IsDBNull(yeniRow(col)), "", yeniRow(col).ToString())

                If eskiDeger <> yeniDeger Then
                    degisiklikler(col.ColumnName) = {eskiDeger, yeniDeger}
                End If
            Next
        Catch ex As Exception
            LogHata("GetDegisiklikler", ex)
        End Try

        Return degisiklikler
    End Function
#End Region
End Class
