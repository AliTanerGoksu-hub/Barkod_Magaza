Public Class frmMasterLogonInfo
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
    Friend WithEvents lblMessage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblServer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents btnOK As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMasterLogonInfo))
        Me.lblMessage = New DevExpress.XtraEditors.LabelControl
        Me.lblServer = New DevExpress.XtraEditors.LabelControl
        Me.Label3 = New DevExpress.XtraEditors.LabelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.btnCancel = New DevExpress.XtraEditors.ButtonEdit
        Me.btnOK = New DevExpress.XtraEditors.ButtonEdit
        CType(Me.btnCancel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnOK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblMessage.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMessage.Location = New System.Drawing.Point(0, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(482, 39)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = resources.GetString("lblMessage.Text")
        '
        'lblServer
        '
        Me.lblServer.Location = New System.Drawing.Point(8, 65)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(87, 13)
        Me.lblServer.TabIndex = 1
        Me.lblServer.Text = "Server name : {0}"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username : "
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Password : "
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(80, 90)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(176, 21)
        Me.txtUsername.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(80, 111)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(176, 21)
        Me.txtPassword.TabIndex = 5
        '
        'btnCancel
        '
        Me.btnCancel.EditValue = "&Cancel"
        Me.btnCancel.Location = New System.Drawing.Point(395, 142)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 20)
        Me.btnCancel.TabIndex = 7
        '
        'btnOK
        '
        Me.btnOK.EditValue = "&OK"
        Me.btnOK.Location = New System.Drawing.Point(320, 142)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 20)
        Me.btnOK.TabIndex = 6
        '
        'frmMasterLogonInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(482, 169)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblServer)
        Me.Controls.Add(Me.lblMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMasterLogonInfo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SQL Server Login Information"
        CType(Me.btnCancel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnOK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
#End Region
#Region " Private Variables "
    'Error Reporting
    Private m_Username As String
    Private m_Password As String
#End Region
#Region " Constructors "
    Public Sub New(ByVal Server As String)
        Me.New()
        'Add any initialization after the InitializeComponent() call
        lblMessage.Text = lblMessage.Text.Replace("{0}", Server)
        lblServer.Text = lblServer.Text.Replace("{0}", Server)
        Username = String.Empty
        Password = String.Empty
    End Sub
#End Region
#Region " Properties "
    Public Property Username() As String
        Get
            Return m_Username
        End Get
        Set(ByVal Value As String)
            m_Username = Value
        End Set
    End Property
    Public Property Password() As String
        Get
            Return m_Password
        End Get
        Set(ByVal Value As String)
            m_Password = Value
        End Set
    End Property
#End Region
#Region " Event Handlers "
    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged
        m_Username = CType(sender, TextBox).Text
    End Sub
    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        m_Password = CType(sender, TextBox).Text
    End Sub
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
#End Region
    Private Sub btnCancel_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.EditValueChanged
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Private Sub btnOK_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.EditValueChanged
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class
