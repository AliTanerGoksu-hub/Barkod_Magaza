' ============================================================================
' E-TİCARET LOGLAMA SİSTEMİ
' Dosya: EticaretLogger.vb
' Tarih: 2026-02-19
' Açıklama: Merkezi loglama sistemi - C:\eticaret\log klasörüne yazar
' ============================================================================
' KULLANIM:
'   EticaretLogger.Log("Mesaj")
'   EticaretLogger.LogError("Hata mesajı", ex)
'   EticaretLogger.LogWarning("Uyarı")
'   EticaretLogger.LogInfo("Bilgi")
'   EticaretLogger.LogDebug("Debug bilgisi")
'   EticaretLogger.LogApi("API çağrısı", "endpoint", responseCode)
'   EticaretLogger.LogDatabase("SQL sorgusu", "tablo adı")
' ============================================================================

Imports System.IO
Imports System.Text
Imports System.Threading

''' <summary>
''' Merkezi e-ticaret loglama sistemi
''' Tüm loglar C:\eticaret\log klasörüne yazılır
''' </summary>
Public Class EticaretLogger
    
    ' Log klasörü yolu
    Private Shared ReadOnly LOG_FOLDER As String = "C:\eticaret\log"
    
    ' Log dosyası önekleri
    Private Shared ReadOnly LOG_PREFIX_GENERAL As String = "eticaret_"
    Private Shared ReadOnly LOG_PREFIX_ERROR As String = "error_"
    Private Shared ReadOnly LOG_PREFIX_API As String = "api_"
    Private Shared ReadOnly LOG_PREFIX_DATABASE As String = "db_"
    Private Shared ReadOnly LOG_PREFIX_SYNC As String = "sync_"
    Private Shared ReadOnly LOG_PREFIX_TRENDYOL As String = "trendyol_"
    
    ' Thread safety için lock object
    Private Shared ReadOnly _lockObject As New Object()
    
    ' Log seviyeleri
    Public Enum LogLevel
        DEBUG = 0
        INFO = 1
        WARNING = 2
        [ERROR] = 3
        CRITICAL = 4
    End Enum
    
    ' Minimum log seviyesi (DEBUG = tümü, ERROR = sadece hatalar)
    Public Shared MinimumLogLevel As LogLevel = LogLevel.DEBUG
    
#Region "Initialization"
    
    ''' <summary>
    ''' Log klasörünü oluştur (yoksa)
    ''' </summary>
    Shared Sub New()
        Try
            If Not Directory.Exists(LOG_FOLDER) Then
                Directory.CreateDirectory(LOG_FOLDER)
            End If
        Catch ex As Exception
            ' Klasör oluşturulamazsa sessizce devam et
            Debug.WriteLine("Log klasörü oluşturulamadı: " & ex.Message)
        End Try
    End Sub
    
#End Region

#Region "Ana Log Metotları"
    
    ''' <summary>
    ''' Genel log kaydı
    ''' </summary>
    Public Shared Sub Log(message As String, Optional level As LogLevel = LogLevel.INFO)
        If level < MinimumLogLevel Then Return
        
        Dim logEntry As String = FormatLogEntry(level.ToString(), message)
        WriteToFile(LOG_PREFIX_GENERAL, logEntry)
        
        ' Hata seviyesi ve üstü ayrı dosyaya da yazılır
        If level >= LogLevel.ERROR Then
            WriteToFile(LOG_PREFIX_ERROR, logEntry)
        End If
    End Sub
    
    ''' <summary>
    ''' Debug log kaydı
    ''' </summary>
    Public Shared Sub LogDebug(message As String)
        Log(message, LogLevel.DEBUG)
    End Sub
    
    ''' <summary>
    ''' Bilgi log kaydı
    ''' </summary>
    Public Shared Sub LogInfo(message As String)
        Log(message, LogLevel.INFO)
    End Sub
    
    ''' <summary>
    ''' Uyarı log kaydı
    ''' </summary>
    Public Shared Sub LogWarning(message As String)
        Log(message, LogLevel.WARNING)
    End Sub
    
    ''' <summary>
    ''' Hata log kaydı (Exception ile)
    ''' </summary>
    Public Shared Sub LogError(message As String, Optional ex As Exception = Nothing)
        Dim fullMessage As String = message
        
        If ex IsNot Nothing Then
            fullMessage &= vbCrLf & "  Exception Type: " & ex.GetType().Name
            fullMessage &= vbCrLf & "  Message: " & ex.Message
            
            If ex.InnerException IsNot Nothing Then
                fullMessage &= vbCrLf & "  Inner Exception: " & ex.InnerException.Message
            End If
            
            fullMessage &= vbCrLf & "  Stack Trace: " & ex.StackTrace
        End If
        
        Log(fullMessage, LogLevel.ERROR)
    End Sub
    
    ''' <summary>
    ''' Kritik hata log kaydı
    ''' </summary>
    Public Shared Sub LogCritical(message As String, Optional ex As Exception = Nothing)
        Dim fullMessage As String = "[CRITICAL] " & message
        
        If ex IsNot Nothing Then
            fullMessage &= vbCrLf & "  Exception Type: " & ex.GetType().Name
            fullMessage &= vbCrLf & "  Message: " & ex.Message
            fullMessage &= vbCrLf & "  Stack Trace: " & ex.StackTrace
        End If
        
        Log(fullMessage, LogLevel.CRITICAL)
    End Sub

#End Region

#Region "Özel Log Metotları"
    
    ''' <summary>
    ''' API çağrısı log kaydı
    ''' </summary>
    Public Shared Sub LogApi(operation As String, endpoint As String, Optional responseCode As Integer = 0, Optional responseBody As String = "", Optional duration As Long = 0)
        Dim sb As New StringBuilder()
        sb.AppendLine("=== API CALL ===")
        sb.AppendLine("  Operation: " & operation)
        sb.AppendLine("  Endpoint: " & endpoint)
        
        If responseCode > 0 Then
            sb.AppendLine("  Response Code: " & responseCode.ToString())
        End If
        
        If duration > 0 Then
            sb.AppendLine("  Duration: " & duration.ToString() & "ms")
        End If
        
        If Not String.IsNullOrEmpty(responseBody) Then
            ' Response body'yi kısalt (çok uzunsa)
            Dim truncatedBody As String = responseBody
            If truncatedBody.Length > 500 Then
                truncatedBody = truncatedBody.Substring(0, 500) & "... [TRUNCATED]"
            End If
            sb.AppendLine("  Response: " & truncatedBody)
        End If
        
        Dim logEntry As String = FormatLogEntry("API", sb.ToString())
        WriteToFile(LOG_PREFIX_API, logEntry)
        WriteToFile(LOG_PREFIX_GENERAL, logEntry)
    End Sub
    
    ''' <summary>
    ''' Trendyol özel log kaydı
    ''' </summary>
    Public Shared Sub LogTrendyol(operation As String, details As String, Optional success As Boolean = True)
        Dim status As String = If(success, "SUCCESS", "FAILED")
        Dim sb As New StringBuilder()
        sb.AppendLine("=== TRENDYOL " & status & " ===")
        sb.AppendLine("  Operation: " & operation)
        sb.AppendLine("  Details: " & details)
        
        Dim logEntry As String = FormatLogEntry("TRENDYOL", sb.ToString())
        WriteToFile(LOG_PREFIX_TRENDYOL, logEntry)
        WriteToFile(LOG_PREFIX_GENERAL, logEntry)
        
        If Not success Then
            WriteToFile(LOG_PREFIX_ERROR, logEntry)
        End If
    End Sub
    
    ''' <summary>
    ''' Veritabanı işlemi log kaydı
    ''' </summary>
    Public Shared Sub LogDatabase(operation As String, tableName As String, Optional recordCount As Integer = 0, Optional sql As String = "")
        Dim sb As New StringBuilder()
        sb.AppendLine("=== DATABASE ===")
        sb.AppendLine("  Operation: " & operation)
        sb.AppendLine("  Table: " & tableName)
        
        If recordCount > 0 Then
            sb.AppendLine("  Records: " & recordCount.ToString())
        End If
        
        If Not String.IsNullOrEmpty(sql) Then
            ' SQL'i kısalt
            Dim truncatedSql As String = sql
            If truncatedSql.Length > 300 Then
                truncatedSql = truncatedSql.Substring(0, 300) & "... [TRUNCATED]"
            End If
            sb.AppendLine("  SQL: " & truncatedSql)
        End If
        
        Dim logEntry As String = FormatLogEntry("DB", sb.ToString())
        WriteToFile(LOG_PREFIX_DATABASE, logEntry)
    End Sub
    
    ''' <summary>
    ''' Senkronizasyon işlemi log kaydı
    ''' </summary>
    Public Shared Sub LogSync(operation As String, productCode As String, Optional success As Boolean = True, Optional details As String = "")
        Dim status As String = If(success, "OK", "FAIL")
        Dim message As String = $"[{status}] {operation} - Product: {productCode}"
        
        If Not String.IsNullOrEmpty(details) Then
            message &= " - " & details
        End If
        
        Dim logEntry As String = FormatLogEntry("SYNC", message)
        WriteToFile(LOG_PREFIX_SYNC, logEntry)
        
        If Not success Then
            WriteToFile(LOG_PREFIX_ERROR, logEntry)
        End If
    End Sub
    
    ''' <summary>
    ''' Sipariş işlemi log kaydı
    ''' </summary>
    Public Shared Sub LogOrder(operation As String, orderNumber As String, Optional success As Boolean = True, Optional details As String = "")
        Dim status As String = If(success, "OK", "FAIL")
        Dim message As String = $"[{status}] {operation} - Order: {orderNumber}"
        
        If Not String.IsNullOrEmpty(details) Then
            message &= " - " & details
        End If
        
        Dim logEntry As String = FormatLogEntry("ORDER", message)
        WriteToFile(LOG_PREFIX_SYNC, logEntry)
        WriteToFile(LOG_PREFIX_GENERAL, logEntry)
    End Sub
    
    ''' <summary>
    ''' Performans ölçümü log kaydı
    ''' </summary>
    Public Shared Sub LogPerformance(operation As String, durationMs As Long, Optional itemCount As Integer = 0)
        Dim message As String = $"PERF: {operation} completed in {durationMs}ms"
        
        If itemCount > 0 Then
            Dim perItem As Double = durationMs / itemCount
            message &= $" ({itemCount} items, {perItem:F2}ms/item)"
        End If
        
        Log(message, LogLevel.DEBUG)
    End Sub

#End Region

#Region "Yardımcı Metotlar"
    
    ''' <summary>
    ''' Log satırını formatla
    ''' </summary>
    Private Shared Function FormatLogEntry(level As String, message As String) As String
        Dim timestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")
        Dim threadId As String = Thread.CurrentThread.ManagedThreadId.ToString().PadLeft(4)
        
        Return $"[{timestamp}] [{level.PadRight(8)}] [T{threadId}] {message}"
    End Function
    
    ''' <summary>
    ''' Dosyaya yaz (thread-safe)
    ''' </summary>
    Private Shared Sub WriteToFile(prefix As String, content As String)
        SyncLock _lockObject
            Try
                ' Günlük dosya adı
                Dim fileName As String = prefix & DateTime.Now.ToString("yyyy-MM-dd") & ".log"
                Dim filePath As String = Path.Combine(LOG_FOLDER, fileName)
                
                ' Dosyaya ekle
                Using writer As New StreamWriter(filePath, True, Encoding.UTF8)
                    writer.WriteLine(content)
                End Using
                
            Catch ex As Exception
                ' Log yazma hatası - sessizce devam et
                Debug.WriteLine("Log yazma hatası: " & ex.Message)
            End Try
        End SyncLock
    End Sub
    
    ''' <summary>
    ''' Eski log dosyalarını temizle
    ''' </summary>
    Public Shared Sub CleanOldLogs(Optional daysToKeep As Integer = 30)
        Try
            If Not Directory.Exists(LOG_FOLDER) Then Return
            
            Dim cutoffDate As DateTime = DateTime.Now.AddDays(-daysToKeep)
            Dim files As String() = Directory.GetFiles(LOG_FOLDER, "*.log")
            Dim deletedCount As Integer = 0
            
            For Each file As String In files
                Dim fileInfo As New FileInfo(file)
                If fileInfo.CreationTime < cutoffDate Then
                    fileInfo.Delete()
                    deletedCount += 1
                End If
            Next
            
            If deletedCount > 0 Then
                LogInfo($"Eski log temizliği: {deletedCount} dosya silindi (>{daysToKeep} gün)")
            End If
            
        Catch ex As Exception
            LogError("Log temizleme hatası", ex)
        End Try
    End Sub
    
    ''' <summary>
    ''' Günlük log dosyasının yolunu döndür
    ''' </summary>
    Public Shared Function GetTodayLogPath(Optional prefix As String = "") As String
        If String.IsNullOrEmpty(prefix) Then prefix = LOG_PREFIX_GENERAL
        Dim fileName As String = prefix & DateTime.Now.ToString("yyyy-MM-dd") & ".log"
        Return Path.Combine(LOG_FOLDER, fileName)
    End Function
    
    ''' <summary>
    ''' Log klasörünü aç
    ''' </summary>
    Public Shared Sub OpenLogFolder()
        Try
            If Directory.Exists(LOG_FOLDER) Then
                Process.Start("explorer.exe", LOG_FOLDER)
            End If
        Catch ex As Exception
            LogError("Log klasörü açılamadı", ex)
        End Try
    End Sub

#End Region

#Region "Başlangıç ve Bitiş Logları"
    
    ''' <summary>
    ''' Uygulama başlangıç logu
    ''' </summary>
    Public Shared Sub LogApplicationStart()
        Dim sb As New StringBuilder()
        sb.AppendLine("================================================================================")
        sb.AppendLine("=== UYGULAMA BAŞLATILDI ===")
        sb.AppendLine("================================================================================")
        sb.AppendLine($"  Tarih/Saat: {DateTime.Now:yyyy-MM-dd HH:mm:ss}")
        sb.AppendLine($"  Kullanıcı: {Environment.UserName}")
        sb.AppendLine($"  Makine: {Environment.MachineName}")
        sb.AppendLine($"  OS: {Environment.OSVersion}")
        sb.AppendLine($"  .NET Version: {Environment.Version}")
        sb.AppendLine("================================================================================")
        
        Log(sb.ToString(), LogLevel.INFO)
    End Sub
    
    ''' <summary>
    ''' Uygulama kapanış logu
    ''' </summary>
    Public Shared Sub LogApplicationEnd()
        Dim sb As New StringBuilder()
        sb.AppendLine("================================================================================")
        sb.AppendLine("=== UYGULAMA KAPATILDI ===")
        sb.AppendLine("================================================================================")
        sb.AppendLine($"  Tarih/Saat: {DateTime.Now:yyyy-MM-dd HH:mm:ss}")
        sb.AppendLine("================================================================================")
        
        Log(sb.ToString(), LogLevel.INFO)
    End Sub
    
    ''' <summary>
    ''' İşlem başlangıç logu (zamanlama için)
    ''' </summary>
    Public Shared Function StartOperation(operationName As String) As Stopwatch
        LogInfo($">>> İşlem Başladı: {operationName}")
        Dim sw As New Stopwatch()
        sw.Start()
        Return sw
    End Function
    
    ''' <summary>
    ''' İşlem bitiş logu (zamanlama ile)
    ''' </summary>
    Public Shared Sub EndOperation(operationName As String, sw As Stopwatch, Optional success As Boolean = True, Optional itemCount As Integer = 0)
        sw.Stop()
        Dim status As String = If(success, "BAŞARILI", "BAŞARISIZ")
        Dim message As String = $"<<< İşlem Bitti: {operationName} - {status} - Süre: {sw.ElapsedMilliseconds}ms"
        
        If itemCount > 0 Then
            message &= $" ({itemCount} kayıt)"
        End If
        
        If success Then
            LogInfo(message)
        Else
            LogWarning(message)
        End If
    End Sub

#End Region

End Class
