<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_stok_kodu_degistir
    Inherits DevExpress.XtraEditors.XtraForm
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_kodu_degistir))
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl92 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_eskiModel = New DevExpress.XtraEditors.ButtonEdit()
        Me.TamamB = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_sKisaAdi = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txt_eskiModel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sKisaAdi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(234, 130)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Enabled = False
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(154, 130)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "&Tamam"
        '
        'LabelControl92
        '
        Me.LabelControl92.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl92.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl92.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl92.Name = "LabelControl92"
        Me.LabelControl92.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl92.TabIndex = 68
        Me.LabelControl92.Text = "Eski Kod:"
        '
        'txt_eskiModel
        '
        Me.txt_eskiModel.Location = New System.Drawing.Point(68, 9)
        Me.txt_eskiModel.Name = "txt_eskiModel"
        Me.txt_eskiModel.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txt_eskiModel.Properties.Appearance.Options.UseForeColor = True
        Me.txt_eskiModel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_eskiModel.Size = New System.Drawing.Size(152, 20)
        Me.txt_eskiModel.TabIndex = 67
        '
        'TamamB
        '
        Me.TamamB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TamamB.Enabled = False
        Me.TamamB.Location = New System.Drawing.Point(234, 7)
        Me.TamamB.Name = "TamamB"
        Me.TamamB.Size = New System.Drawing.Size(80, 24)
        Me.TamamB.TabIndex = 69
        Me.TamamB.Text = "&Tamam"
        '
        'txt_sKisaAdi
        '
        Me.txt_sKisaAdi.Enabled = False
        Me.txt_sKisaAdi.EnterMoveNextControl = True
        Me.txt_sKisaAdi.Location = New System.Drawing.Point(68, 96)
        Me.txt_sKisaAdi.Name = "txt_sKisaAdi"
        Me.txt_sKisaAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKisaAdi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKisaAdi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKisaAdi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKisaAdi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKisaAdi.Properties.MaxLength = 20
        Me.txt_sKisaAdi.Size = New System.Drawing.Size(152, 20)
        Me.txt_sKisaAdi.TabIndex = 70
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(12, 99)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl1.TabIndex = 71
        Me.LabelControl1.Text = "Yeni Kod:"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SimpleButton4.Enabled = False
        Me.SimpleButton4.Location = New System.Drawing.Point(234, 94)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton4.TabIndex = 72
        Me.SimpleButton4.Text = "&Kontrol Et"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(12, 42)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl2.TabIndex = 73
        Me.LabelControl2.Text = "nStokID:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(68, 42)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl3.TabIndex = 74
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(68, 70)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl4.TabIndex = 76
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(12, 70)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl5.TabIndex = 75
        Me.LabelControl5.Text = "Açýklama:"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl6)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(326, 162)
        Me.PanelControl2.TabIndex = 87
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.LabelControl6.Location = New System.Drawing.Point(74, 66)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(169, 24)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "Lütfen Bekleyiniz..."
        '
        'frm_stok_kodu_degistir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 162)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txt_sKisaAdi)
        Me.Controls.Add(Me.TamamB)
        Me.Controls.Add(Me.LabelControl92)
        Me.Controls.Add(Me.txt_eskiModel)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(342, 200)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(342, 200)
        Me.Name = "frm_stok_kodu_degistir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Kodu Deðiþtirme"
        CType(Me.txt_eskiModel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sKisaAdi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl92 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_eskiModel As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents TamamB As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_sKisaAdi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
End Class
