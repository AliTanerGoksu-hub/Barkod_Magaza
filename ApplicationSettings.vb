Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Public Class ApplicationSettings
    Inherits UserSettingsBase
    Protected tMainFormLocation As Point
    Protected tMainFormSize As Size
    Protected tMainFormWindowState As FormWindowState
    Protected sDomainName As String
    Protected sServerName As String
    Protected sDatabase As String
    Protected sUsername As String
    Protected sSandBarLayout As String
    Protected sSandDockLayout As String
    Protected sPort As String
    Protected sServer As String
    Protected sDefaultDomain As String
    Protected bEMailError As Boolean
#Region "Construction"
    Protected Sub pInitialise()
        tMainFormLocation = New Point(0, 0)
        tMainFormSize = New Size(640, 480)
        tMainFormWindowState = FormWindowState.Normal
        sDomainName = "* (Primary Domain)"
        sServerName = String.Empty
        sDatabase = String.Empty
        sUsername = String.Empty
        sSandBarLayout = String.Empty
        sSandDockLayout = String.Empty
        sPort = "25"
        sServer = "localhost"
        sDefaultDomain = "mydomain.com"
        bEMailError = False
    End Sub
    Public Sub New()
        MyBase.New()
        pInitialise()
    End Sub
    Public Sub New(ByVal StorageOption As UserStorageOption)
        MyBase.New(StorageOption)
        pInitialise()
    End Sub
    Public Sub New(ByVal StorageOption As UserStorageOption, ByVal Section As String)
        MyBase.New(StorageOption, Section)
        pInitialise()
    End Sub
#End Region
#Region "Properties"
    Public Property MainForm_Location() As Point
        Get
            Return tMainFormLocation
        End Get
        Set(ByVal Value As Point)
            tMainFormLocation = Value
        End Set
    End Property
    Public Property MainForm_Size() As Size
        Get
            Return tMainFormSize
        End Get
        Set(ByVal Value As Size)
            tMainFormSize = Value
        End Set
    End Property
    Public Property MainForm_WindowState() As FormWindowState
        Get
            Return tMainFormWindowState
        End Get
        Set(ByVal Value As FormWindowState)
            tMainFormWindowState = Value
        End Set
    End Property
    Public Property SignIn_DomainName() As String
        Get
            Return sDomainName
        End Get
        Set(ByVal Value As String)
            sDomainName = Value
        End Set
    End Property
    Public Property SignIn_ServerName() As String
        Get
            Return sServerName
        End Get
        Set(ByVal Value As String)
            sServerName = Value
        End Set
    End Property
    Public Property SignIn_DataBase() As String
        Get
            Return sDatabase
        End Get
        Set(ByVal Value As String)
            sDatabase = Value
        End Set
    End Property
    Public Property SignIn_Username() As String
        Get
            Return sUsername
        End Get
        Set(ByVal Value As String)
            sUsername = Value
        End Set
    End Property
    Public Property Main_SandBarLayout() As String
        Get
            Return sSandBarLayout
        End Get
        Set(ByVal Value As String)
            sSandBarLayout = Value
        End Set
    End Property
    Public Property Main_SandDockLayout() As String
        Get
            Return sSandDockLayout
        End Get
        Set(ByVal Value As String)
            sSandDockLayout = Value
        End Set
    End Property
    Public Property EMail_Port() As String
        Get
            Return sPort
        End Get
        Set(ByVal Value As String)
            sPort = Value
        End Set
    End Property
    Public Property EMail_Server() As String
        Get
            Return sServer
        End Get
        Set(ByVal Value As String)
            sServer = Value
        End Set
    End Property
    Public Property EMail_DefaultDomain() As String
        Get
            Return sDefaultDomain
        End Get
        Set(ByVal Value As String)
            sDefaultDomain = Value
        End Set
    End Property
    Public Property Error_EmailError() As Boolean
        Get
            Return bEMailError
        End Get
        Set(ByVal Value As Boolean)
            bEMailError = Value
        End Set
    End Property
#End Region
End Class
