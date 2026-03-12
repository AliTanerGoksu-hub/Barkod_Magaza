' ============================================================================
' KREDİ SERVİSİ
' ============================================================================
' Müşteri kredisi kontrol, harcama ve yükleme işlemleri
' ============================================================================

Imports System.Data.OleDb
Imports System.Collections.Generic
Imports System.IO

Public Class CreditService
    
    Private connectionString As String = connection
    Private ReadOnly logFile As String = "Credit_Service.log"
    
    ''' <summary>
    ''' Kredi yeterli mi kontrol et
    ''' </summary>
    Public Function CheckCredit(musteriID As Integer, requiredAmount As Decimal) As Boolean
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                
                Dim cmd As New OleDbCommand(
                    "SELECT nKullanilabilirKredi FROM tbMusteriKredi WHERE nMusteriID = ? AND bAktif = 1", conn)
                cmd.Parameters.AddWithValue("?", musteriID)
                
                Dim result As Object = cmd.ExecuteScalar()
                
                If result Is Nothing Then
                    ' Müşterinin kredi hesabı yok, oluştur
                    CreateCreditAccount(musteriID)
                    Return False
                End If
                
                Dim mevcutKredi As Decimal = Convert.ToDecimal(result)
                Return mevcutKredi >= requiredAmount
            End Using
        Catch ex As Exception
            Log("ERROR", "CheckCredit", ex.Message)
            Return False
        End Try
    End Function
    
    ''' <summary>
    ''' Günlük limit kontrolü
    ''' </summary>
    Public Function CheckDailyLimit(musteriID As Integer) As Boolean
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                
                Dim cmd As New OleDbCommand(
                    "SELECT nGunlukKullanim, nGunlukLimit, dteGunlukResetTarihi FROM tbMusteriKredi WHERE nMusteriID = ?", conn)
                cmd.Parameters.AddWithValue("?", musteriID)
                
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                
                If reader.Read() Then
                    Dim gunlukKullanim As Integer = Convert.ToInt32(reader("nGunlukKullanim"))
                    Dim gunlukLimit As Integer = Convert.ToInt32(reader("nGunlukLimit"))
                    Dim resetTarihi As Date = Convert.ToDateTime(reader("dteGunlukResetTarihi"))
                    
                    ' Yeni güne geçildiyse reset
                    If resetTarihi < Date.Today Then
                        ResetDailyLimit(musteriID)
                        Return True
                    End If
                    
                    reader.Close()
                    Return gunlukKullanim < gunlukLimit
                End If
                
                reader.Close()
                Return True
            End Using
        Catch ex As Exception
            Log("ERROR", "CheckDailyLimit", ex.Message)
            Return True ' Hata durumunda izin ver
        End Try
    End Function
    
    ''' <summary>
    ''' Kredi düş
    ''' </summary>
    Public Function DeductCredit(musteriID As Integer, amount As Decimal, stokID As Integer, aciklama As String) As Boolean
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                
                ' Kredi ID al
                Dim getKrediIDCmd As New OleDbCommand(
                    "SELECT nKrediID, nKullanilabilirKredi FROM tbMusteriKredi WHERE nMusteriID = ?", conn)
                getKrediIDCmd.Parameters.AddWithValue("?", musteriID)
                
                Dim reader As OleDbDataReader = getKrediIDCmd.ExecuteReader()
                
                If Not reader.Read() Then
                    reader.Close()
                    Return False
                End If
                
                Dim krediID As Integer = Convert.ToInt32(reader("nKrediID"))
                Dim oncekiBakiye As Decimal = Convert.ToDecimal(reader("nKullanilabilirKredi"))
                reader.Close()
                
                Dim yeniBakiye As Decimal = oncekiBakiye - amount
                
                ' Kredi düş
                Dim updateCmd As New OleDbCommand(
                    "UPDATE tbMusteriKredi SET " &
                    "nKullanilabilirKredi = nKullanilabilirKredi - ?, " &
                    "nKullanilanKredi = nKullanilanKredi + ?, " &
                    "nGunlukKullanim = nGunlukKullanim + 1, " &
                    "dteGuncelleme = GETDATE() " &
                    "WHERE nKrediID = ?", conn)
                updateCmd.Parameters.AddWithValue("?", amount)
                updateCmd.Parameters.AddWithValue("?", amount)
                updateCmd.Parameters.AddWithValue("?", krediID)
                updateCmd.ExecuteNonQuery()
                
                ' Hareket kaydet
                Dim hareketCmd As New OleDbCommand(
                    "INSERT INTO tbKrediHareketleri (nMusteriID, nKrediID, sHareketTipi, nMiktar, nStokID, sIslemAciklama, nOncekiBakiye, nYeniBakiye, dteTarih) " &
                    "VALUES (?, ?, 'Kullanim', ?, ?, ?, ?, ?, GETDATE())", conn)
                hareketCmd.Parameters.AddWithValue("?", musteriID)
                hareketCmd.Parameters.AddWithValue("?", krediID)
                hareketCmd.Parameters.AddWithValue("?", -amount)
                hareketCmd.Parameters.AddWithValue("?", stokID)
                hareketCmd.Parameters.AddWithValue("?", aciklama)
                hareketCmd.Parameters.AddWithValue("?", oncekiBakiye)
                hareketCmd.Parameters.AddWithValue("?", yeniBakiye)
                hareketCmd.ExecuteNonQuery()
                
                Log("SUCCESS", "DeductCredit", $"MusteriID={musteriID}, Miktar={amount}, YeniBakiye={yeniBakiye}")
                Return True
            End Using
        Catch ex As Exception
            Log("ERROR", "DeductCredit", ex.Message)
            Return False
        End Try
    End Function
    
    ''' <summary>
    ''' Kredi yükle
    ''' </summary>
    Public Function AddCredit(musteriID As Integer, amount As Decimal, paketID As Integer, aciklama As String) As Boolean
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                
                ' Kredi ID al
                Dim getKrediIDCmd As New OleDbCommand(
                    "SELECT nKrediID, nKullanilabilirKredi FROM tbMusteriKredi WHERE nMusteriID = ?", conn)
                getKrediIDCmd.Parameters.AddWithValue("?", musteriID)
                
                Dim reader As OleDbDataReader = getKrediIDCmd.ExecuteReader()
                
                If Not reader.Read() Then
                    reader.Close()
                    CreateCreditAccount(musteriID)
                    Return AddCredit(musteriID, amount, paketID, aciklama)
                End If
                
                Dim krediID As Integer = Convert.ToInt32(reader("nKrediID"))
                Dim oncekiBakiye As Decimal = Convert.ToDecimal(reader("nKullanilabilirKredi"))
                reader.Close()
                
                Dim yeniBakiye As Decimal = oncekiBakiye + amount
                
                ' Kredi ekle
                Dim updateCmd As New OleDbCommand(
                    "UPDATE tbMusteriKredi SET " &
                    "nKullanilabilirKredi = nKullanilabilirKredi + ?, " &
                    "nToplamKredi = nToplamKredi + ?, " &
                    "dteGuncelleme = GETDATE() " &
                    "WHERE nKrediID = ?", conn)
                updateCmd.Parameters.AddWithValue("?", amount)
                updateCmd.Parameters.AddWithValue("?", amount)
                updateCmd.Parameters.AddWithValue("?", krediID)
                updateCmd.ExecuteNonQuery()
                
                ' Hareket kaydet
                Dim hareketCmd As New OleDbCommand(
                    "INSERT INTO tbKrediHareketleri (nMusteriID, nKrediID, sHareketTipi, nMiktar, nPaketID, sIslemAciklama, nOncekiBakiye, nYeniBakiye, dteTarih) " &
                    "VALUES (?, ?, 'YuklemePaket', ?, ?, ?, ?, ?, GETDATE())", conn)
                hareketCmd.Parameters.AddWithValue("?", musteriID)
                hareketCmd.Parameters.AddWithValue("?", krediID)
                hareketCmd.Parameters.AddWithValue("?", amount)
                hareketCmd.Parameters.AddWithValue("?", paketID)
                hareketCmd.Parameters.AddWithValue("?", aciklama)
                hareketCmd.Parameters.AddWithValue("?", oncekiBakiye)
                hareketCmd.Parameters.AddWithValue("?", yeniBakiye)
                hareketCmd.ExecuteNonQuery()
                
                Log("SUCCESS", "AddCredit", $"MusteriID={musteriID}, Miktar={amount}, YeniBakiye={yeniBakiye}")
                Return True
            End Using
        Catch ex As Exception
            Log("ERROR", "AddCredit", ex.Message)
            Return False
        End Try
    End Function
    
    ''' <summary>
    ''' Kredi hesabı oluştur
    ''' </summary>
    Private Sub CreateCreditAccount(musteriID As Integer)
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                
                ' Müşteri adını al
                Dim getMusteriCmd As New OleDbCommand("SELECT sCariAdi FROM tbMusteri WHERE nMusteriID = ?", conn)
                getMusteriCmd.Parameters.AddWithValue("?", musteriID)
                Dim musteriAdi As String = Convert.ToString(getMusteriCmd.ExecuteScalar())
                
                ' Kredi hesabı oluştur
                Dim cmd As New OleDbCommand(
                    "INSERT INTO tbMusteriKredi (nMusteriID, sMusteriAdi, nToplamKredi, nKullanilabilirKredi, nGunlukLimit, dteGunlukResetTarihi, bAktif, dteOlusturma) " &
                    "VALUES (?, ?, 0, 0, 100, ?, 1, GETDATE())", conn)
                cmd.Parameters.AddWithValue("?", musteriID)
                cmd.Parameters.AddWithValue("?", musteriAdi)
                cmd.Parameters.AddWithValue("?", Date.Today)
                cmd.ExecuteNonQuery()
                
                Log("SUCCESS", "CreateCreditAccount", $"MusteriID={musteriID} için kredi hesabı oluşturuldu")
            End Using
        Catch ex As Exception
            Log("ERROR", "CreateCreditAccount", ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Günlük limiti reset
    ''' </summary>
    Private Sub ResetDailyLimit(musteriID As Integer)
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                
                Dim cmd As New OleDbCommand(
                    "UPDATE tbMusteriKredi SET nGunlukKullanim = 0, dteGunlukResetTarihi = ? WHERE nMusteriID = ?", conn)
                cmd.Parameters.AddWithValue("?", Date.Today)
                cmd.Parameters.AddWithValue("?", musteriID)
                cmd.ExecuteNonQuery()
                
                Log("INFO", "ResetDailyLimit", $"MusteriID={musteriID} günlük limit reset")
            End Using
        Catch ex As Exception
            Log("ERROR", "ResetDailyLimit", ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Kredi bakiyesi getir
    ''' </summary>
    Public Function GetCreditBalance(musteriID As Integer) As Dictionary(Of String, Object)
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                
                Dim cmd As New OleDbCommand(
                    "SELECT nKullanilabilirKredi, nKullanilanKredi, nToplamKredi, nGunlukKullanim, nGunlukLimit, sAktifPaket " &
                    "FROM tbMusteriKredi WHERE nMusteriID = ?", conn)
                cmd.Parameters.AddWithValue("?", musteriID)
                
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                
                If reader.Read() Then
                    Dim balance As New Dictionary(Of String, Object) From {
                        {"kullanilabilir", reader("nKullanilabilirKredi")},
                        {"kullanilan", reader("nKullanilanKredi")},
                        {"toplam", reader("nToplamKredi")},
                        {"gunluk_kullanim", reader("nGunlukKullanim")},
                        {"gunluk_limit", reader("nGunlukLimit")},
                        {"aktif_paket", reader("sAktifPaket")}
                    }
                    
                    reader.Close()
                    Return balance
                End If
                
                reader.Close()
                Return Nothing
            End Using
        Catch ex As Exception
            Log("ERROR", "GetCreditBalance", ex.Message)
            Return Nothing
        End Try
    End Function
    
    Private Sub Log(level As String, func As String, message As String)
        Try
            Dim timestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            Dim logMessage As String = $"[{timestamp}] [{level}] [{func}] {message}"
            Console.WriteLine(logMessage)
            File.AppendAllText(logFile, logMessage & vbCrLf)
        Catch
        End Try
    End Sub
    
End Class
