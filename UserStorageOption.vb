Option Strict Off
Option Explicit On
Imports System.IO
Imports System.IO.IsolatedStorage
Imports System.Xml.Serialization
Imports System.Configuration
''' <summary>
''' Possible locations to save user settings.
''' </summary>
Public Enum UserStorageOption
    ''' <summary>
    ''' Settings will be stored in isolated storage.
    ''' </summary>
    IsolatedStorage
    ''' <summary>
    ''' Settings will be stored in the registry.
    ''' </summary>
    Registry
    ''' <summary>
    ''' Settings will be stored in text files in the
    ''' application directory.
    ''' </summary>
    File
End Enum
''' <summary>
''' Contains base functionality for user settings storage.
''' </summary>
''' <remarks>
''' To store user settings, inherit from this class to create your own
''' settings class. Within that class use standard XmlSerialization rules
''' to declare your fields and properties.
''' </remarks>
Public MustInherit Class UserSettingsBase
    Private mOption As UserStorageOption = _
      UserStorageOption.IsolatedStorage
    Private mSection As String
    ''' <summary>
    ''' Creates a UserSettings object that stores its settings
    ''' in isolated storage in a section based on the class name.
    ''' </summary>
    Public Sub New()
        mSection = Me.GetType.Name
    End Sub
    ''' <summary>
    ''' Creates a UserSettings object that stores its settings
    ''' in the specified storage location in a section based 
    ''' on the class name.
    ''' </summary>
    ''' <param name="StorageOption">The storage location for the settings.</param>
    Public Sub New(ByVal StorageOption As UserStorageOption)
        mOption = StorageOption
        mSection = Me.GetType.Name
    End Sub
    ''' <summary>
    ''' Creates a UserSettings object that stores its settings
    ''' in the specified storage location in a section named
    ''' per the parameter value.
    ''' </summary>
    ''' <param name="StorageOption">The storage location for the settings.</param>
    ''' <param name="Section">The section name in which the settings should be stored.</param>
    Public Sub New(ByVal StorageOption As UserStorageOption, ByVal Section As String)
        mOption = StorageOption
        mSection = Section
    End Sub
    ''' <summary>
    ''' The section name in which the settings are stored.
    ''' </summary>
    ''' <returns>The section name.</returns>
    Public ReadOnly Property Section() As String
        Get
            Return mSection
        End Get
    End Property
    ''' <summary>
    ''' The location where the settings are stored.
    ''' </summary>
    ''' <returns>The location where settings are stored.</returns>
    <Xml.Serialization.XmlIgnore()> _
    Public Property StorageOption() As UserStorageOption
        Get
            Return mOption
        End Get
        Set(ByVal Value As UserStorageOption)
            mOption = Value
        End Set
    End Property
#Region " Save "
    ''' <summary>
    ''' Saves the current settings based on the currently
    ''' logged in user, the storage location and section name.
    ''' </summary>
    Public Sub Save()
        Select Case mOption
            Case UserStorageOption.IsolatedStorage
                SaveToIsolatedStorage()
            Case UserStorageOption.Registry
                SaveToRegistry()
            Case UserStorageOption.File
                SaveToFile()
        End Select
    End Sub
    ''' <summary>
    ''' Stores the user settings to isolated storage.
    ''' </summary>
    Private Sub SaveToIsolatedStorage()
        Dim formatter As New XmlSerializer(Me.GetType)
        Dim settingsFile As New IsolatedStorageFileStream( _
          Section & ".xml", FileMode.Create, _
          IsolatedStorageFile.GetUserStoreForDomain)
        Try
            formatter.Serialize(settingsFile, Me)
        Catch ex As Exception
            Throw New UserSettingsException( _
              "User settings could not be saved to isolated storage", ex)
        Finally
            settingsFile.Close()
        End Try
    End Sub
    ''' <summary>
    ''' Stores the user settings to the Windows registry.
    ''' </summary>
    Private Sub SaveToRegistry()
        Dim buffer As New MemoryStream
        Dim formatter As New XmlSerializer(Me.GetType)
        formatter.Serialize(buffer, Me)
        Dim output As String
        output = System.Text.Encoding.ASCII.GetString(buffer.ToArray)
        SaveSetting(GetAppName, Section, "Settings", output)
    End Sub
    ''' <summary>
    ''' Stores the user settings to an XML file.
    ''' </summary>
    Private Sub SaveToFile()
        Dim path As String = GetFilePath(Section)
        Dim outFile As FileStream = File.Create(path)
        Try
            Dim formatter As New XmlSerializer(Me.GetType)
            formatter.Serialize(outFile, Me)
        Catch ex As Exception
            Throw New UserSettingsException( _
              "User settings could not be written to file " & path, ex)
        Finally
            outFile.Close()
        End Try
    End Sub
#End Region
#Region " Restore "
    ''' <summary>
    ''' Creates a new settings object with settings data based
    ''' on the currently logged in user, the storage
    ''' location and section name.
    ''' </summary>
    ''' <returns>The newly populated settings object.</returns>
    Public Function Restore() As UserSettingsBase
        Return Restore(Me.GetType, mSection, mOption)
    End Function
    ''' <summary>
    ''' Creates a new settings object of the specified type
    ''' based on the currently logged in user, the specified
    ''' section name and specified storage location.
    ''' </summary>
    ''' <param name="Type">The type of the settings object to return.</param>
    ''' <param name="Section">The section name containing the settings.</param>
    ''' <param name="StorageOption">The storage location of the settings.</param>
    ''' <returns>The newly populated settings object.</returns>
    Public Shared Function Restore(ByVal Type As Type, ByVal Section As String, ByVal StorageOption As UserStorageOption) As UserSettingsBase
        Return RestoreFromIsolatedStorage(Type, Section)
        Select Case StorageOption
            Case UserStorageOption.IsolatedStorage
                Return RestoreFromIsolatedStorage(Type, Section)
            Case UserStorageOption.Registry
                Return RestoreFromRegistry(Type, Section)
            Case UserStorageOption.File
                Return RestoreFromFile(Type, Section)
        End Select
    End Function
    ''' <summary>
    ''' Restore the user settings from isolated storage.
    ''' </summary>
    ''' <param name="Type">The type of the settings object.</param>
    ''' <param name="Section">The section in which the settings are stored.</param>
    ''' <returns>A populated settings object.</returns>
    Private Shared Function RestoreFromIsolatedStorage(ByVal Type As Type, ByVal Section As String) As UserSettingsBase
        Dim formatter As New System.Xml.Serialization.XmlSerializer(Type)
        Dim settingsFile As IsolatedStorageFileStream
        Try
            settingsFile = New IsolatedStorageFileStream( _
              Section & ".xml", IO.FileMode.Open, _
              IsolatedStorageFile.GetUserStoreForDomain)
        Catch ex As Exception
            Throw New UserSettingsException( _
              "User settings not found in isolated storage", ex)
        End Try
        Try
            Dim buffer(CInt(settingsFile.Length) - 1) As Byte
            settingsFile.Read(buffer, 0, CInt(settingsFile.Length))
            Dim stream As New IO.MemoryStream(buffer)
            Return CType(formatter.Deserialize(stream), UserSettingsBase)
        Catch ex As Exception
            Throw New UserSettingsException( _
              "User settings could not be loaded from isolated storage", ex)
        Finally
            settingsFile.Close()
        End Try
    End Function
    ''' <summary>
    ''' Restore the user settings from the Windows registry.
    ''' </summary>
    ''' <param name="Type">The type of the settings object.</param>
    ''' <param name="Section">The section in which the settings are stored.</param>
    ''' <returns>A populated settings object.</returns>
    Private Shared Function RestoreFromRegistry(ByVal Type As Type, ByVal Section As String) As UserSettingsBase
        Dim text As String
        Try
            text = GetSetting(GetAppName, Section, "Settings")
        Catch ex As Exception
            Throw New UserSettingsException( _
              "User settings not found in registry", ex)
        End Try
        Try
            Dim buffer As New MemoryStream(System.Text.Encoding.ASCII.GetBytes(text))
            Dim formatter As New XmlSerializer(Type)
            Dim settings As UserSettingsBase = CType(formatter.Deserialize(buffer), UserSettingsBase)
            settings.mOption = UserStorageOption.Registry
            Return settings
        Catch ex As Exception
            Throw New UserSettingsException( _
              "User settings could not be loaded from registry", ex)
        End Try
    End Function
    ''' <summary>
    ''' Restore the user settings from an XML file.
    ''' </summary>
    ''' <param name="Type">The type of the settings object.</param>
    ''' <param name="Section">The section in which the settings are stored.</param>
    ''' <returns>A populated settings object.</returns>
    Private Shared Function RestoreFromFile(ByVal Type As Type, ByVal Section As String) As UserSettingsBase
        Dim path As String = GetFilePath(Section)
        Dim inFile As FileStream
        Try
            inFile = File.OpenRead(path)
        Catch ex As Exception
            Throw New UserSettingsException( _
              "User settings file not found " & path, ex)
        End Try
        Try
            Dim formatter As New XmlSerializer(Type)
            Dim buffer(CInt(inFile.Length)) As Byte
            inFile.Read(buffer, 0, CInt(inFile.Length))
            Dim stream As New MemoryStream(buffer)
            stream.Position = 0
            Dim settings As UserSettingsBase = CType(formatter.Deserialize(stream), UserSettingsBase)
            settings.mOption = UserStorageOption.File
            Return settings
        Catch ex As Exception
            Throw New UserSettingsException( _
              "User settings could not be read from file " & path, ex)
        Finally
            inFile.Close()
        End Try
    End Function
#End Region
#Region " Utility functions "
    ''' <summary>
    ''' Returns the name the the running application.
    ''' </summary>
    ''' <remarks>
    ''' Since this relies on the AppDomain name having some
    ''' reasonable meaning, this method may not work in some
    ''' situations. Most notably, it will not work in ASP.NET
    ''' where the AppDomain names are unpredicable and have
    ''' little to no meaning. If you need to store and retrieve
    ''' user setting values in ASP.NET you'll need to enhance
    ''' the UserSettingsBase class to have some other way of
    ''' identifying the name of your application.
    ''' </remarks>
    ''' <returns>The application name.</returns>
    Private Shared Function GetAppName() As String
        Dim app As String = _
          AppDomain.CurrentDomain.FriendlyName
        ' strip off the .exe if any
        If Right(app, 4) = ".exe" Then
            app = Mid(app, 1, Len(app) - 4)
        End If
        Return app
    End Function
    ''' <summary>
    ''' Returns the name of the current user.
    ''' </summary>
    ''' <remarks>
    ''' <para>
    ''' If there is no current user the .NET Framework supplies an
    ''' empty GenericIdentity object, with an empty user name. If
    ''' we get an empty user name we return 'default' instead.
    ''' </para><para>
    ''' If the user identity is a Windows identity the user name
    ''' will include the domain name. Since we're using the user
    ''' name to build a path, the '\' in the name will cause problems
    ''' so we strip out the domain and '\' symbol.
    ''' </para>
    ''' </remarks>
    ''' <returns>The name of the current user.</returns>
    Private Shared Function GetUser() As String
        Dim user As String = _
          Threading.Thread.CurrentPrincipal.Identity.Name
        If Len(user) = 0 Then
            ' if there's no user, set it to default
            user = "default"
        Else
            ' if we got a full domain name, remove the domain
            Dim pos As Integer = InStr(user, "\")
            If pos > 0 Then
                user = Mid(user, pos + 1)
            End If
        End If
        Return user
    End Function
    ''' <summary>
    ''' Returns a full file path to a user-settings file.
    ''' </summary>
    ''' <param name="Section">The section name for these settings.</param>
    ''' <returns>A complete file path (path and name) for the settings file.</returns>
    Private Shared Function GetFilePath(ByVal Section As String) As String
        Dim sb As New System.Text.StringBuilder
        With sb
            'Dim path As String = ConfigurationSettings.AppSettings("SettingsPath")
            Dim path As String = Application.StartupPath
            If Len(path) > 0 Then
                .Append(path)
                If Right(path, 1) <> "\" Then
                    .Append("\")
                End If
            End If
            .Append(GetAppName())
            .Append(".")
            .Append(Section)
            .Append(".")
            .Append(GetUser())
            .Append(".xml")
        End With
        Return sb.ToString
    End Function
#End Region
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
