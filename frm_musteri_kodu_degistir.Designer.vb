<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_musteri_kodu_degistir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_musteri_kodu_degistir))
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.eskiMusteri = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.yeniMusteriID = New DevExpress.XtraEditors.ButtonEdit()
        Me.yeniMusteri = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.fisNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl92 = New DevExpress.XtraEditors.LabelControl()
        Me.eskiMusteriNo = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.yeniMusteriID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fisNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(209, 156)
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
        Me.SimpleButton1.Location = New System.Drawing.Point(129, 156)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "&Tamam"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(12, 100)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl1.TabIndex = 71
        Me.LabelControl1.Text = "Yeni Müþteri:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(12, 70)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl2.TabIndex = 73
        Me.LabelControl2.Text = "Adý-Soyadý:"
        '
        'eskiMusteri
        '
        Me.eskiMusteri.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eskiMusteri.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.eskiMusteri.Location = New System.Drawing.Point(86, 70)
        Me.eskiMusteri.Name = "eskiMusteri"
        Me.eskiMusteri.Size = New System.Drawing.Size(0, 13)
        Me.eskiMusteri.TabIndex = 74
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl6)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(301, 188)
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
        'yeniMusteriID
        '
        Me.yeniMusteriID.Location = New System.Drawing.Point(83, 97)
        Me.yeniMusteriID.Name = "yeniMusteriID"
        Me.yeniMusteriID.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.yeniMusteriID.Properties.Appearance.Options.UseForeColor = True
        Me.yeniMusteriID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.yeniMusteriID.Size = New System.Drawing.Size(206, 20)
        Me.yeniMusteriID.TabIndex = 88
        '
        'yeniMusteri
        '
        Me.yeniMusteri.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.yeniMusteri.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.yeniMusteri.Location = New System.Drawing.Point(86, 131)
        Me.yeniMusteri.Name = "yeniMusteri"
        Me.yeniMusteri.Size = New System.Drawing.Size(0, 13)
        Me.yeniMusteri.TabIndex = 90
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(12, 131)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl5.TabIndex = 89
        Me.LabelControl5.Text = "Adý-Soyadý:"
        '
        'fisNo
        '
        Me.fisNo.EnterMoveNextControl = True
        Me.fisNo.Location = New System.Drawing.Point(83, 8)
        Me.fisNo.Name = "fisNo"
        Me.fisNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.fisNo.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.fisNo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.fisNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.fisNo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.fisNo.Properties.MaxLength = 20
        Me.fisNo.Size = New System.Drawing.Size(206, 20)
        Me.fisNo.TabIndex = 92
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(12, 11)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl4.TabIndex = 93
        Me.LabelControl4.Text = "Fiþ No:"
        '
        'LabelControl92
        '
        Me.LabelControl92.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl92.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl92.Location = New System.Drawing.Point(12, 40)
        Me.LabelControl92.Name = "LabelControl92"
        Me.LabelControl92.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl92.TabIndex = 68
        Me.LabelControl92.Text = "Eski Müþteri:"
        '
        'eskiMusteriNo
        '
        Me.eskiMusteriNo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eskiMusteriNo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.eskiMusteriNo.Location = New System.Drawing.Point(86, 40)
        Me.eskiMusteriNo.Name = "eskiMusteriNo"
        Me.eskiMusteriNo.Size = New System.Drawing.Size(0, 13)
        Me.eskiMusteriNo.TabIndex = 91
        '
        'frm_musteri_kodu_degistir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 188)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.fisNo)
        Me.Controls.Add(Me.eskiMusteriNo)
        Me.Controls.Add(Me.yeniMusteri)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.yeniMusteriID)
        Me.Controls.Add(Me.eskiMusteri)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl92)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(317, 226)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(317, 226)
        Me.Name = "frm_musteri_kodu_degistir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Müþteri Hareketleri Kaydýr"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.yeniMusteriID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fisNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eskiMusteri As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents yeniMusteriID As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents yeniMusteri As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents fisNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl92 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eskiMusteriNo As DevExpress.XtraEditors.LabelControl
End Class
