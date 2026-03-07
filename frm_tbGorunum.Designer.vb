<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tbGorunum
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tbGorunum))
        Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl
        Me.checkEdit2 = New DevExpress.XtraEditors.CheckEdit
        Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.panelControl1 = New DevExpress.XtraEditors.PanelControl
        CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'listBoxControl1
        '
        Me.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listBoxControl1.Items.AddRange(New Object() {"Default"})
        Me.listBoxControl1.Location = New System.Drawing.Point(0, 0)
        Me.listBoxControl1.Name = "listBoxControl1"
        Me.listBoxControl1.Size = New System.Drawing.Size(205, 165)
        Me.listBoxControl1.TabIndex = 5
        '
        'checkEdit2
        '
        Me.checkEdit2.EditValue = True
        Me.checkEdit2.Location = New System.Drawing.Point(-2, 29)
        Me.checkEdit2.Name = "checkEdit2"
        Me.checkEdit2.Properties.Caption = "Allow Form Skin"
        Me.checkEdit2.Size = New System.Drawing.Size(172, 18)
        Me.checkEdit2.TabIndex = 1
        '
        'simpleButton1
        '
        Me.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.simpleButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.simpleButton1.Location = New System.Drawing.Point(0, 165)
        Me.simpleButton1.Name = "simpleButton1"
        Me.simpleButton1.Size = New System.Drawing.Size(205, 23)
        Me.simpleButton1.TabIndex = 3
        Me.simpleButton1.Text = "Değiştir"
        '
        'checkEdit1
        '
        Me.checkEdit1.EditValue = True
        Me.checkEdit1.Location = New System.Drawing.Point(-2, 8)
        Me.checkEdit1.Name = "checkEdit1"
        Me.checkEdit1.Properties.Caption = "Allow Transition Animation"
        Me.checkEdit1.Size = New System.Drawing.Size(172, 18)
        Me.checkEdit1.TabIndex = 0
        '
        'panelControl1
        '
        Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.panelControl1.Controls.Add(Me.checkEdit2)
        Me.panelControl1.Controls.Add(Me.checkEdit1)
        Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelControl1.Location = New System.Drawing.Point(0, 188)
        Me.panelControl1.Name = "panelControl1"
        Me.panelControl1.Size = New System.Drawing.Size(205, 58)
        Me.panelControl1.TabIndex = 4
        '
        'frm_tbGorunum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(205, 246)
        Me.Controls.Add(Me.listBoxControl1)
        Me.Controls.Add(Me.simpleButton1)
        Me.Controls.Add(Me.panelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_tbGorunum"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tema Seçimi"
        CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub
    Private WithEvents listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
    Private WithEvents checkEdit2 As DevExpress.XtraEditors.CheckEdit
    Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
    Private WithEvents panelControl1 As DevExpress.XtraEditors.PanelControl
End Class
