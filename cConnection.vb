Imports System.IO
Public Class cConnection
    Private m_strFileName As String
    Private ReadOnly sDatabase As String = ""
    Private m_strConnectionText As String
    Private m_strProvider As String
    Private m_strPesistSecurity As String
    Private m_strIntegradedSecurity As String
    Private m_strReconstructed As String
    Private m_strSqlConnection As String
    Private ReadOnly m_strDefaultFilename As String
    Private m_strDatasource As String
    Private m_strPassword As String
    Private m_strUserID As String
    Private m_strCatalog As String 'Database
    Private m_strCurrent As String = "Current Language=Türkçe;"
    Private m_strApplication As String = "Application Name=ERP;"
    Public Event CloseApplication()
#Region "Public Methods"
    'To pass native login information to the application
    Public Sub GetLogonInformation(ByRef strServerName As String, ByRef strUserID As String, ByRef strPassword As String, ByRef strDatabaseName As String)
        strServerName = m_strDatasource
        strPassword = m_strPassword
        strUserID = m_strUserID
        strDatabaseName = m_strCatalog
    End Sub
    Public Function GetSQLConnectionString() As String
        ReconstructSQLConnectionString()
        Return m_strReconstructed
    End Function
    Public Function GetcSQLConnectionString() As String
        ReconstructSQLConnectionString()
        Return m_strSqlConnection
    End Function
    Public Function GetDatabase() As String
        ReconstructSQLConnectionString()
        Return m_strCatalog
    End Function
    Public Function GetSunucu() As String
        ReconstructSQLConnectionString()
        Return m_strDatasource
    End Function
    Public Function GetOracleConnectionString() As String
        ReconstructOracleConnectionString()
        Return m_strReconstructed
    End Function
#End Region
#Region "Constructors"
    Public Sub New()
        m_strDefaultFilename = "wfp.udl"
        ReadFromFile()
        SplitConnectionString()
    End Sub
    Public Sub New(ByRef strDefaultFilename As String, ByRef slDatabase As String)
        m_strDefaultFilename = strDefaultFilename
        sDatabase = slDatabase
        ReadFromFile()
        SplitConnectionString()
        'MsgBox(sDatabase)
    End Sub
#End Region
#Region "Recostruction"
    Private Sub ReconstructSQLConnectionString()
        m_strSqlConnection = m_strDatasource & ";"
        m_strSqlConnection &= m_strCatalog & ";"
        m_strSqlConnection &= m_strPesistSecurity & ";"
        'OLEDB
        m_strReconstructed = m_strProvider & ";"
        m_strReconstructed &= m_strPesistSecurity & ";"
        If Not IsNothing(m_strIntegradedSecurity) Then
            m_strReconstructed &= m_strIntegradedSecurity & ";"
            m_strSqlConnection &= m_strIntegradedSecurity & ";"
        Else
            m_strReconstructed &= m_strPassword & ";"
            m_strSqlConnection &= m_strPassword & ";"
            If Not m_strUserID.Length = 0 Then
                m_strReconstructed &= m_strUserID & ";"
                m_strSqlConnection &= m_strUserID & ";"
            End If
        End If
        m_strReconstructed &= m_strCatalog & ";"
        m_strReconstructed &= m_strDatasource & ";"
        m_strReconstructed &= m_strCurrent & ";"
        m_strReconstructed &= m_strApplication & ";"
        'SQL
        m_strSqlConnection &= m_strApplication & ";"
        m_strSqlConnection &= m_strCurrent & ";"
        m_strCatalog = m_strCatalog.Substring(16)
        m_strDatasource = m_strDatasource.Substring(12)
        m_strCurrent = m_strCurrent.Substring(17)
        m_strApplication = m_strApplication.Substring(17)
        If Not IsNothing(m_strPassword) Then
            m_strPassword = m_strPassword.Substring(9)
            m_strUserID = m_strUserID.Substring(8)
        End If
    End Sub
    Private Sub ReconstructOracleConnectionString()
        If IsNothing(m_strIntegradedSecurity) Then
            m_strReconstructed &= m_strPassword & ";"
            m_strReconstructed &= m_strUserID & ";"
        Else
            m_strReconstructed &= m_strIntegradedSecurity & ";"
        End If
        m_strReconstructed &= m_strDatasource & ";"
        m_strReconstructed &= m_strCurrent & ";"
        m_strReconstructed &= m_strApplication & ";"
        m_strDatasource = m_strDatasource.Substring(12)
        m_strCurrent = m_strCurrent.Substring(17)
        m_strApplication = m_strApplication.Substring(17)
        If Not IsNothing(m_strPassword) Then
            m_strPassword = m_strPassword.Substring(9)
            m_strUserID = m_strUserID.Substring(8)
        End If
    End Sub
#End Region
#Region "Spliting"
    Private Sub SplitConnectionString()
        Dim strArray As String() = Nothing
        Dim strString As String = ""
        Dim strProvider As String = ""
        Dim strDRIVER As String = ""
        Dim strSERVER As String = ""
        Dim strUID As String = ""
        Dim strDATABASE As String = ""
        'Const strCURRENT As String = ""
        'Const strAPPLICATION As String = ""
        strArray = m_strConnectionText.Split(";")
        If strArray(0).IndexOf("[oledb]") = -1 Then
            Dim nAnswer As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("This file cannot be read{0}Open another file ?", vbCr), "Read udl File", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error)
            If nAnswer = DialogResult.Yes Then
                ReadFromFile()
                SplitConnectionString()
                Exit Sub
            Else
                Dim strDescription As String = String.Format("Connection Failed.{0}Closing Application", vbCr)
                Err.Raise(vbObjectError + 999, , strDescription)
                RaiseEvent CloseApplication()
            End If
        End If
        For Each strString In strArray
            If strString.IndexOf("Provider") > -1 Then
                strProvider = strString.Substring(strString.IndexOf("Provider"))
                m_strProvider = strProvider
            End If
            If strString.IndexOf("Password") > -1 Then
                m_strPassword = strString
            End If
            If strString.IndexOf("Data") > -1 Then
                m_strDatasource = strString
            End If
            If strString.IndexOf("User") > -1 Then
                m_strUserID = strString
            End If
            'MsgBox(sDatabase)
            'm_strCatalog = "Initial Catalog=" & sDatabase & ""
            If strString.IndexOf("Initial") > -1 Then
                If sDatabase <> "" Then
                    m_strCatalog = String.Format("Initial Catalog={0}", sDatabase)
                Else
                    m_strCatalog = strString
                End If
            End If
            If strString.IndexOf("Current") > -1 Then
                m_strCurrent = strString
            End If
            If strString.IndexOf("Application") > -1 Then
                m_strApplication = strString
            End If
            If strString.IndexOf("Integrated") > -1 Then
                m_strIntegradedSecurity = strString
            End If
            If strString.IndexOf("Persist") > -1 Then
                m_strPesistSecurity = strString
            End If
            If strString.IndexOf("DRIVER") > -1 Then
                strDRIVER = strString.Substring(strString.IndexOf("DRIVER"))
            End If
            If strString.IndexOf("SERVER") > -1 Then
                strSERVER = strString
            End If
            If strString.IndexOf("UID") > -1 Then
                strUID = strString
            End If
            If strString.IndexOf("DATABASE") > -1 Then
                strDATABASE = strString
                strDATABASE = strDATABASE.Remove(strDATABASE.Length - 3, 3)
            End If
        Next
        'Check if the connection string connects to SQLServer or Oracle Server.
        If strProvider.IndexOf("MSDASQL") > -1 Then
            If strDRIVER.IndexOf("SQL Server") > -1 Then
                m_strDatasource = "Data Source" & strSERVER.Substring(6)
                If strUID.Length > 0 Then
                    m_strUserID = "User ID" & strUID.Substring(3)
                End If
                m_strCatalog = "Initial Catalog " & strDATABASE.Substring(8)
            Else
                'not sqlserver database
                Dim nAnswer As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("This file does not connect to SQL Server Database{0}Open another file ?", vbCr), "Read udl File", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error)
                If nAnswer = DialogResult.Yes Then
                    ReadFromFile()
                    SplitConnectionString()
                    Exit Sub
                Else
                    Dim strDescription As String = String.Format("Connection Failed.{0}Closing Application", vbCr)
                    Err.Raise(vbObjectError + 999, , strDescription)
                End If
            End If
        ElseIf strProvider.IndexOf("SQLOLEDB") > -1 Then
            m_strApplication = m_strApplication.Remove(m_strApplication.Length - 1, 1)
        ElseIf strProvider.IndexOf("OraOLEDB") > -1 Then  'Oracle provider for OLEDB
        ElseIf strProvider.IndexOf("MSDAORA") > -1 Then 'Microsoft Provider for Oracle
        Else
            'not Oracle or sqlserver database Connection
            Dim nAnswer As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("This file does not connect to Oracle Server or SQL Database{0}Open another file ?", vbCr), "Read udl File", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error)
            If nAnswer = DialogResult.Yes Then
                ReadFromFile()
                SplitConnectionString()
                Exit Sub
            Else
                Dim strDescription As String = String.Format("Connection Failed.{0}Closing Application", vbCr)
                Err.Raise(vbObjectError + 999, , strDescription)
            End If
        End If
    End Sub
#End Region
#Region "Data Link Files"
    Private Sub ReadFromFile()
        Dim myStreamReader As StreamReader
        Dim strFileName As String
        Try
            m_strFileName = AppDomain.CurrentDomain.BaseDirectory & m_strDefaultFilename
            strFileName = m_strFileName
            'If the UDL file cannot be found Create a new one
            If Not File.Exists(m_strFileName) Then
                m_strFileName = strFileName
                CreateUDLFile(strFileName)
            End If
            myStreamReader = File.OpenText(m_strFileName)
            ' Read the entire file in one pass
            m_strConnectionText = myStreamReader.ReadToEnd()
        Catch exc As Exception
            ' Show the exception to the user.
            Dim strDescription As String = String.Format("File could not be opened or read.{0}Please verify that the filename is correct, and that you have read permissions for the desired directory.{0}{0}Exception: {1}", vbCrLf, exc.Message)
            Err.Raise(vbObjectError + 991, , strDescription)
            RaiseEvent CloseApplication()
        Finally
            ' Close the object if it has been created.
            If Not myStreamReader Is Nothing Then
                myStreamReader.Close()
            End If
        End Try
    End Sub
    Private Shared Sub CreateUDLFile(ByVal strFileName As String)
        'Create an empty text file
        Dim fs As New FileStream(strFileName, FileMode.CreateNew)
        fs.Close()
        'Call Data Link App and write information to it
        Dim prProcess As New ProcessStartInfo() With {.FileName = strFileName}
        Using pProcess As Process = Process.Start(prProcess)
            pProcess.WaitForInputIdle()
            pProcess.WaitForExit()
            pProcess.Close()
        End Using
        'Check if the created file is a valid UDl file, if not, delete it.
        Dim myStreamReader As StreamReader = File.OpenText(strFileName)
        Dim m_strConnectionText As String = myStreamReader.ReadToEnd()
        myStreamReader.Close()
        Dim strArray() As String = m_strConnectionText.Split(";")
        If strArray(0).IndexOf("[oledb]") = -1 Then
            If File.Exists(strFileName) Then
                File.Delete(strFileName)
            End If
        End If
    End Sub
    Public Shared Sub UpdateUDLFile(ByVal strFileName As String)
        Dim prProcess As New ProcessStartInfo() With {.FileName = strFileName}
        Using pProcess As Process = Process.Start(prProcess)
            pProcess.WaitForInputIdle()
            pProcess.WaitForExit()
            pProcess.Close()
        End Using
    End Sub
#End Region
End Class
