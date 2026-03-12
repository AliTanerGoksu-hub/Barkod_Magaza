Imports DevExpress.XtraEditors
Public Class frmSignIn
    Inherits DevExpress.XtraEditors.XtraForm
#Region " Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboServer As System.Windows.Forms.ComboBox
    Friend WithEvents cboDatabase As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents btnCancel As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboDomain As System.Windows.Forms.ComboBox
    Friend WithEvents btnRefreshDatabase As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents ilMain As System.Windows.Forms.ImageList
    Friend WithEvents btnRefreshServer As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents btnRefreshDomain As DevExpress.XtraEditors.ButtonEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboServer = New System.Windows.Forms.ComboBox
        Me.cboDatabase = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.btnOK = New DevExpress.XtraEditors.ButtonEdit
        Me.btnCancel = New DevExpress.XtraEditors.ButtonEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboDomain = New System.Windows.Forms.ComboBox
        Me.btnRefreshDatabase = New DevExpress.XtraEditors.ButtonEdit
        Me.ilMain = New System.Windows.Forms.ImageList(Me.components)
        Me.btnRefreshServer = New DevExpress.XtraEditors.ButtonEdit
        Me.btnRefreshDomain = New DevExpress.XtraEditors.ButtonEdit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCancel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRefreshDatabase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRefreshServer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRefreshDomain.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 189)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Server"
        '
        'cboServer
        '
        Me.cboServer.Location = New System.Drawing.Point(204, 56)
        Me.cboServer.Name = "cboServer"
        Me.cboServer.Size = New System.Drawing.Size(172, 21)
        Me.cboServer.TabIndex = 4
        '
        'cboDatabase
        '
        Me.cboDatabase.Location = New System.Drawing.Point(204, 95)
        Me.cboDatabase.Name = "cboDatabase"
        Me.cboDatabase.Size = New System.Drawing.Size(172, 21)
        Me.cboDatabase.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Database"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(116, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "SQL Username"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(204, 134)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(172, 21)
        Me.txtUsername.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(116, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "SQL Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(204, 168)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(172, 21)
        Me.txtPassword.TabIndex = 12
        '
        'btnOK
        '
        Me.btnOK.EditValue = "&Ok"
        Me.btnOK.Location = New System.Drawing.Point(392, 164)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 20)
        Me.btnOK.TabIndex = 13
        '
        'btnCancel
        '
        Me.btnCancel.EditValue = "&Cancel"
        Me.btnCancel.Location = New System.Drawing.Point(392, 134)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 20)
        Me.btnCancel.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(116, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Domain"
        '
        'cboDomain
        '
        Me.cboDomain.Location = New System.Drawing.Point(204, 17)
        Me.cboDomain.Name = "cboDomain"
        Me.cboDomain.Size = New System.Drawing.Size(172, 21)
        Me.cboDomain.TabIndex = 1
        '
        'btnRefreshDatabase
        '
        Me.btnRefreshDatabase.Location = New System.Drawing.Point(380, 95)
        Me.btnRefreshDatabase.Name = "btnRefreshDatabase"
        Me.btnRefreshDatabase.Size = New System.Drawing.Size(21, 20)
        Me.btnRefreshDatabase.TabIndex = 8
        '
        'ilMain
        '
        Me.ilMain.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ilMain.ImageSize = New System.Drawing.Size(16, 16)
        Me.ilMain.TransparentColor = System.Drawing.Color.Magenta
        '
        'btnRefreshServer
        '
        Me.btnRefreshServer.Location = New System.Drawing.Point(380, 56)
        Me.btnRefreshServer.Name = "btnRefreshServer"
        Me.btnRefreshServer.Size = New System.Drawing.Size(21, 20)
        Me.btnRefreshServer.TabIndex = 5
        '
        'btnRefreshDomain
        '
        Me.btnRefreshDomain.Location = New System.Drawing.Point(380, 17)
        Me.btnRefreshDomain.Name = "btnRefreshDomain"
        Me.btnRefreshDomain.Size = New System.Drawing.Size(21, 20)
        Me.btnRefreshDomain.TabIndex = 2
        '
        'frmSignIn
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(478, 187)
        Me.Controls.Add(Me.btnRefreshDomain)
        Me.Controls.Add(Me.btnRefreshServer)
        Me.Controls.Add(Me.btnRefreshDatabase)
        Me.Controls.Add(Me.cboDomain)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.cboDatabase)
        Me.Controls.Add(Me.cboServer)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSignIn"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sign In"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCancel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRefreshDatabase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRefreshServer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRefreshDomain.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
#End Region
#Region " Private Variables "
    Private m_Domain As String
    Private m_Server As String
    Private m_Database As String
    Private m_Username As String
    Private m_Password As String
#End Region
#Region " Constructors "
    Public Sub New(ByVal settings As ApplicationSettings)
        Me.New()
        Me.pLoadDomains()
        Me.Domain = settings.SignIn_DomainName
        Me.pLoadServers(m_Domain)
        Me.Server = settings.SignIn_ServerName
        Me.Database = settings.SignIn_DataBase
        Me.SQLUsername = settings.SignIn_Username
    End Sub
#End Region
#Region " Properties "
    Public Property Domain() As String
        Get
            Return m_Domain
        End Get
        Set(ByVal Value As String)
            m_Domain = Value
            cboDomain.Text = m_Domain
        End Set
    End Property
    Public Property Server() As String
        Get
            Return m_Server
        End Get
        Set(ByVal Value As String)
            m_Server = Value
            cboServer.Text = m_Server
        End Set
    End Property
    Public Property Database() As String
        Get
            Return m_Database
        End Get
        Set(ByVal Value As String)
            m_Database = Value
            cboDatabase.Text = m_Database
        End Set
    End Property
    Public Property SQLUsername() As String
        Get
            Return m_Username
        End Get
        Set(ByVal Value As String)
            m_Username = Value
            txtUsername.Text = m_Username
        End Set
    End Property
    Public Property SQLPassword() As String
        Get
            Return m_Password
        End Get
        Set(ByVal Value As String)
            m_Password = Value
            txtPassword.Text = m_Password
        End Set
    End Property
#End Region
#Region " Event Handlers "
    Private Sub frmSignIn_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If cboDomain.Text.Equals("") Then
            cboDomain.Focus()
        ElseIf cboServer.Text.Equals("") Then
            cboServer.Focus()
        ElseIf cboDatabase.Text.Equals("") Then
            cboDatabase.Focus()
        ElseIf txtUsername.Text.Equals("") Then
            txtUsername.Focus()
        ElseIf txtPassword.Text.Equals("") Then
            txtPassword.Focus()
        Else
            btnOK.Focus()
        End If
    End Sub
    Private Sub cboDomain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDomain.SelectedIndexChanged
        Me.Cursor = Windows.Forms.Cursors.WaitCursor
        Me.pLoadServers(CType(sender, System.Windows.Forms.ComboBox).Text)
        Me.Cursor = Windows.Forms.Cursors.Default
    End Sub
    Private Sub cboDomain_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDomain.TextChanged
        m_Domain = CType(sender, System.Windows.Forms.ComboBox).Text
    End Sub
    Private Sub cboServer_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboServer.SelectedIndexChanged
        Me.Cursor = Windows.Forms.Cursors.WaitCursor
        pLoadDataBases(CType(sender, System.Windows.Forms.ComboBox).Text)
        Me.Cursor = Windows.Forms.Cursors.Default
    End Sub
    Private Sub cboServer_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboServer.TextChanged
        m_Server = CType(sender, System.Windows.Forms.ComboBox).Text
    End Sub
    Private Sub cboDatabase_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDatabase.TextChanged
        m_Database = CType(sender, System.Windows.Forms.ComboBox).Text
    End Sub
    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged
        m_Username = CType(sender, TextBox).Text
    End Sub
    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        m_Password = CType(sender, TextBox).Text
    End Sub
    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub btnRefreshDomain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshDomain.Click
        Me.pLoadDomains()
    End Sub
    Private Sub btnRefreshServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshServer.Click
        Me.pLoadServers(m_Domain)
    End Sub
    Private Sub btnRefreshDatabase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshDatabase.Click
        Me.pLoadDataBases(m_Server)
    End Sub
#End Region
#Region " Procedures "
    Protected Sub pLoadDomains()
        Dim myServerInfos() As ServerInfo = SQLConnector.GetSQLServers(SQLConnector.EServerTypes.SV_TYPE_DOMAIN_ENUM)
        cboDomain.Items.Clear()
        cboDomain.Items.Add("* (Primary Domain)")
        For Each myServerInfo As ServerInfo In myServerInfos
            cboDomain.Items.Add(myServerInfo.Name)
        Next
    End Sub
    Protected Sub pLoadServers(ByVal DomainName As String)
        Dim sDomainName As String = CStr(IIf(DomainName = "* (Primary Domain)", Nothing, DomainName))
        Dim myServerInfos() As ServerInfo = SQLConnector.GetSQLServers(SQLConnector.EServerTypes.SV_TYPE_SQLSERVER, sDomainName)
        cboServer.Items.Clear()
        For Each myServerInfo As ServerInfo In myServerInfos
            cboServer.Items.Add(myServerInfo.Name)
        Next
    End Sub
    Protected Sub pLoadDataBases(ByVal ServerName As String)
        Dim sDatabases() As String = SQLConnector.GetDatabases(ServerName)
        Try
            sDatabases = SQLConnector.GetDatabases(ServerName)
        Catch ex As SqlClient.SqlException
            If ex.Number = 18456 Then
                Dim frmLogon As New frmMasterLogonInfo(ServerName)
                If frmLogon.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Try
                        sDatabases = SQLConnector.GetDatabases(ServerName, frmLogon.Username, frmLogon.Password)
                    Catch exep As SqlClient.SqlException
                        XtraMessageBox.Show(exep.Message, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End Try
                End If
            End If
        Finally
            cboDatabase.Items.Clear()
            If Not sDatabases Is Nothing Then
                Dim sDatabase
                For Each sDatabase In sDatabases
                    cboDatabase.Items.Add(sDatabase)
                Next
            End If
        End Try
    End Sub
#End Region
    Private Sub btnCancel_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.EditValueChanged
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Private Sub btnOK_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.EditValueChanged
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class
