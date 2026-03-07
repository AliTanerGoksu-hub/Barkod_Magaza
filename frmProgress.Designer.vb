Partial Class frmProgress
    Inherits DevExpress.XtraEditors.XtraForm
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.progressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.labelControl1 = New DevExpress.XtraEditors.GroupControl
        Me.lbl_Caption = New DevExpress.XtraEditors.LabelControl
        CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.labelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.labelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'progressBarControl1
        '
        Me.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.progressBarControl1.Location = New System.Drawing.Point(2, 94)
        Me.progressBarControl1.Name = "progressBarControl1"
        Me.progressBarControl1.Properties.ShowTitle = True
        Me.progressBarControl1.Size = New System.Drawing.Size(472, 17)
        Me.progressBarControl1.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.AllowHtmlString = True
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl2.Location = New System.Drawing.Point(12, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(16, 14)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "0/0"
        '
        'LabelControl3
        '
        Me.LabelControl3.AllowHtmlString = True
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl3.Location = New System.Drawing.Point(11, 72)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(59, 14)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "Geçen Süre:"
        '
        'labelControl1
        '
        Me.labelControl1.Controls.Add(Me.lbl_Caption)
        Me.labelControl1.Controls.Add(Me.progressBarControl1)
        Me.labelControl1.Controls.Add(Me.LabelControl3)
        Me.labelControl1.Controls.Add(Me.LabelControl2)
        Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelControl1.Location = New System.Drawing.Point(0, 0)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(476, 113)
        Me.labelControl1.TabIndex = 4
        Me.labelControl1.Text = "Progress"
        '
        'lbl_Caption
        '
        Me.lbl_Caption.AllowHtmlString = True
        Me.lbl_Caption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lbl_Caption.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_Caption.Location = New System.Drawing.Point(2, 22)
        Me.lbl_Caption.Name = "lbl_Caption"
        Me.lbl_Caption.Size = New System.Drawing.Size(472, 14)
        Me.lbl_Caption.TabIndex = 4
        Me.lbl_Caption.Text = "***"
        '
        'frmProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 113)
        Me.ControlBox = False
        Me.Controls.Add(Me.labelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmProgress"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.progressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.labelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.labelControl1.ResumeLayout(False)
        Me.labelControl1.PerformLayout()
        Me.ResumeLayout(False)
    End Sub
    Private progressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Private WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Private WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelControl1 As DevExpress.XtraEditors.GroupControl
    Private WithEvents lbl_Caption As DevExpress.XtraEditors.LabelControl
End Class
