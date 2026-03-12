Imports System.Drawing
'--
'-- Generic user error dialog
'--
'-- UI adapted from
'--
'-- Alan Cooper's "About Face: The Essentials of User Interface Design"
'-- Chapter VII, "The End of Errors", pages 423-440
'--
'-- Jeff Atwood
'-- http://www.codinghorror.com
'--
Friend Class ExceptionDialog
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
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents lblScope As System.Windows.Forms.Label
    Friend WithEvents lblAction As System.Windows.Forms.Label
    Friend WithEvents btn1 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents btn2 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents btn3 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblErrorHeading As System.Windows.Forms.Label
    Friend WithEvents lblScopeHeading As System.Windows.Forms.Label
    Friend WithEvents lblActionHeading As System.Windows.Forms.Label
    Friend WithEvents lblMoreHeading As System.Windows.Forms.Label
    Friend WithEvents txtMore As System.Windows.Forms.TextBox
    Friend WithEvents btnMore As DevExpress.XtraEditors.ButtonEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExceptionDialog))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblErrorHeading = New System.Windows.Forms.Label
        Me.lblError = New System.Windows.Forms.Label
        Me.lblScopeHeading = New System.Windows.Forms.Label
        Me.lblScope = New System.Windows.Forms.Label
        Me.lblActionHeading = New System.Windows.Forms.Label
        Me.lblAction = New System.Windows.Forms.Label
        Me.lblMoreHeading = New System.Windows.Forms.Label
        Me.btn1 = New DevExpress.XtraEditors.ButtonEdit
        Me.btn2 = New DevExpress.XtraEditors.ButtonEdit
        Me.btn3 = New DevExpress.XtraEditors.ButtonEdit
        Me.txtMore = New System.Windows.Forms.TextBox
        Me.btnMore = New DevExpress.XtraEditors.ButtonEdit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMore.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(8, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblErrorHeading
        '
        Me.lblErrorHeading.AutoSize = True
        Me.lblErrorHeading.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblErrorHeading.Location = New System.Drawing.Point(48, 4)
        Me.lblErrorHeading.Name = "lblErrorHeading"
        Me.lblErrorHeading.Size = New System.Drawing.Size(96, 13)
        Me.lblErrorHeading.TabIndex = 0
        Me.lblErrorHeading.Text = "What happened"
        '
        'lblError
        '
        Me.lblError.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblError.Location = New System.Drawing.Point(48, 26)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(416, 69)
        Me.lblError.TabIndex = 1
        Me.lblError.Text = "(error message)"
        '
        'lblScopeHeading
        '
        Me.lblScopeHeading.AutoSize = True
        Me.lblScopeHeading.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblScopeHeading.Location = New System.Drawing.Point(8, 99)
        Me.lblScopeHeading.Name = "lblScopeHeading"
        Me.lblScopeHeading.Size = New System.Drawing.Size(136, 13)
        Me.lblScopeHeading.TabIndex = 2
        Me.lblScopeHeading.Text = "How this will affect you"
        '
        'lblScope
        '
        Me.lblScope.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblScope.Location = New System.Drawing.Point(24, 121)
        Me.lblScope.Name = "lblScope"
        Me.lblScope.Size = New System.Drawing.Size(440, 69)
        Me.lblScope.TabIndex = 3
        Me.lblScope.Text = "(scope)"
        '
        'lblActionHeading
        '
        Me.lblActionHeading.AutoSize = True
        Me.lblActionHeading.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblActionHeading.Location = New System.Drawing.Point(8, 194)
        Me.lblActionHeading.Name = "lblActionHeading"
        Me.lblActionHeading.Size = New System.Drawing.Size(148, 13)
        Me.lblActionHeading.TabIndex = 4
        Me.lblActionHeading.Text = "What you can do about it"
        '
        'lblAction
        '
        Me.lblAction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAction.Location = New System.Drawing.Point(24, 215)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(440, 99)
        Me.lblAction.TabIndex = 5
        Me.lblAction.Text = "(action)"
        '
        'lblMoreHeading
        '
        Me.lblMoreHeading.AutoSize = True
        Me.lblMoreHeading.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblMoreHeading.Location = New System.Drawing.Point(8, 323)
        Me.lblMoreHeading.Name = "lblMoreHeading"
        Me.lblMoreHeading.Size = New System.Drawing.Size(105, 13)
        Me.lblMoreHeading.TabIndex = 6
        Me.lblMoreHeading.Text = "More information"
        '
        'btn1
        '
        Me.btn1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn1.EditValue = "Button1"
        Me.btn1.Location = New System.Drawing.Point(220, 549)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 20)
        Me.btn1.TabIndex = 9
        '
        'btn2
        '
        Me.btn2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn2.EditValue = "Button2"
        Me.btn2.Location = New System.Drawing.Point(304, 549)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 20)
        Me.btn2.TabIndex = 10
        '
        'btn3
        '
        Me.btn3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn3.EditValue = "Button3"
        Me.btn3.Location = New System.Drawing.Point(388, 549)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 20)
        Me.btn3.TabIndex = 11
        '
        'txtMore
        '
        Me.txtMore.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMore.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMore.Location = New System.Drawing.Point(8, 349)
        Me.txtMore.Multiline = True
        Me.txtMore.Name = "txtMore"
        Me.txtMore.ReadOnly = True
        Me.txtMore.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMore.Size = New System.Drawing.Size(456, 192)
        Me.txtMore.TabIndex = 8
        Me.txtMore.Text = "(detailed information, such as exception details)"
        '
        'btnMore
        '
        Me.btnMore.EditValue = ">>"
        Me.btnMore.Location = New System.Drawing.Point(112, 319)
        Me.btnMore.Name = "btnMore"
        Me.btnMore.Size = New System.Drawing.Size(28, 20)
        Me.btnMore.TabIndex = 7
        '
        'ExceptionDialog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(472, 581)
        Me.Controls.Add(Me.btnMore)
        Me.Controls.Add(Me.txtMore)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lblMoreHeading)
        Me.Controls.Add(Me.lblActionHeading)
        Me.Controls.Add(Me.lblScopeHeading)
        Me.Controls.Add(Me.lblErrorHeading)
        Me.Controls.Add(Me.lblAction)
        Me.Controls.Add(Me.lblScope)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "ExceptionDialog"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "(app) has encountered a problem"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMore.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
#End Region
    Private Sub SizeLabel(ByVal lblAny As Windows.Forms.Label)
        Try
            '-- note that the height is taken as MAXIMUM, so size the label for maximum desired height!
            Dim g As Graphics = Graphics.FromHwnd(lblAny.Handle)
            Dim objSizeF As SizeF = g.MeasureString(lblAny.Text, lblAny.Font, New SizeF(lblAny.Width, lblAny.Height))
            g.Dispose()
            lblAny.Height = Convert.ToInt32(objSizeF.Height)
        Catch ex As System.Security.SecurityException
            '-- do nothing; we can't set label sizes without full trust.
        End Try
    End Sub
    Private Function DetermineDialogResult(ByVal strButtonText As String) As Windows.Forms.DialogResult
        '-- strip any accelerator keys we might have
        strButtonText = strButtonText.Replace("&", "")
        Select Case strButtonText.ToLower
            Case "abort"
                Return Windows.Forms.DialogResult.Abort
            Case "cancel"
                Return Windows.Forms.DialogResult.Cancel
            Case "ignore"
                Return Windows.Forms.DialogResult.Ignore
            Case "no"
                Return Windows.Forms.DialogResult.No
            Case "none"
                Return Windows.Forms.DialogResult.None
            Case "ok"
                Return Windows.Forms.DialogResult.OK
            Case "retry"
                Return Windows.Forms.DialogResult.Retry
            Case "yes"
                Return Windows.Forms.DialogResult.Yes
        End Select
    End Function
    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        Me.Close()
        Me.DialogResult = DetermineDialogResult(btn1.Text)
    End Sub
    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        Me.Close()
        Me.DialogResult = DetermineDialogResult(btn2.Text)
    End Sub
    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        Me.Close()
        Me.DialogResult = DetermineDialogResult(btn3.Text)
    End Sub
    Private Sub UserErrorDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Const intSpacing As Integer = 10
        '-- make sure our window is on top
        Me.TopMost = True
        Me.TopMost = False
        '-- More >> has to be expanded
        Me.txtMore.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMore.Visible = False
        '-- size the labels' height to accommodate the amount of text in them
        SizeLabel(lblScope)
        SizeLabel(lblAction)
        SizeLabel(lblError)
        '-- now shift everything up
        lblScopeHeading.Top = lblError.Top + lblError.Height + intSpacing
        lblScope.Top = lblScopeHeading.Top + lblScopeHeading.Height + intSpacing
        lblActionHeading.Top = lblScope.Top + lblScope.Height + intSpacing
        lblAction.Top = lblActionHeading.Top + lblActionHeading.Height + intSpacing
        lblMoreHeading.Top = lblAction.Top + lblAction.Height + intSpacing
        btnMore.Top = lblMoreHeading.Top - 3
        Me.Height = btnMore.Top + btnMore.Height + intSpacing + 45
        Me.CenterToScreen()
    End Sub
    Private Sub btnMore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMore.Click
        Me.SuspendLayout()
        Me.Height = Me.Height + 300
        Me.txtMore.Top = lblMoreHeading.Top + lblMoreHeading.Height + 10
        Me.txtMore.Height = Me.Height - txtMore.Top - 65
        Me.txtMore.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtMore.Visible = True
        Me.btn3.Focus()
        Me.ResumeLayout()
        btnMore.Visible = False
    End Sub
End Class