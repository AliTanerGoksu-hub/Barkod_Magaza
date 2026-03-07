<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pesin_satis_sil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pesin_satis_sil))
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl92 = New DevExpress.XtraEditors.LabelControl()
        Me.depoKodu = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.depoAciklama = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.fisTarihiF = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.fisTarih2 = New DevExpress.XtraEditors.DateEdit()
        Me.fisTarih1 = New DevExpress.XtraEditors.DateEdit()
        CType(Me.depoKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.fisTarihiF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fisTarih2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fisTarih2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fisTarih1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fisTarih1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(234, 97)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(148, 97)
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
        Me.LabelControl92.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl92.TabIndex = 68
        Me.LabelControl92.Text = "Depo Kodu:"
        '
        'depoKodu
        '
        Me.depoKodu.Location = New System.Drawing.Point(100, 9)
        Me.depoKodu.Name = "depoKodu"
        Me.depoKodu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.depoKodu.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sDepo", "Depo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sAciklama", "Açýklama")})
        Me.depoKodu.Properties.DisplayMember = "sDepo"
        Me.depoKodu.Properties.NullText = ""
        Me.depoKodu.Properties.ValueMember = "sDepo"
        Me.depoKodu.Size = New System.Drawing.Size(214, 20)
        Me.depoKodu.TabIndex = 77
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(12, 42)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl2.TabIndex = 80
        Me.LabelControl2.Text = "Depo Açýklama:"
        '
        'depoAciklama
        '
        Me.depoAciklama.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.depoAciklama.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.depoAciklama.Location = New System.Drawing.Point(103, 42)
        Me.depoAciklama.Name = "depoAciklama"
        Me.depoAciklama.Size = New System.Drawing.Size(0, 13)
        Me.depoAciklama.TabIndex = 81
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(326, 129)
        Me.PanelControl2.TabIndex = 86
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(79, 52)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(169, 24)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Lütfen Bekleyiniz..."
        '
        'fisTarihiF
        '
        Me.fisTarihiF.Location = New System.Drawing.Point(10, 71)
        Me.fisTarihiF.Name = "fisTarihiF"
        Me.fisTarihiF.Properties.Caption = "Fiþ Tarihi:"
        Me.fisTarihiF.Size = New System.Drawing.Size(75, 19)
        Me.fisTarihiF.TabIndex = 99
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.Location = New System.Drawing.Point(205, 73)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl8.TabIndex = 98
        Me.LabelControl8.Text = "-"
        '
        'fisTarih2
        '
        Me.fisTarih2.EditValue = Nothing
        Me.fisTarih2.Enabled = False
        Me.fisTarih2.Location = New System.Drawing.Point(214, 70)
        Me.fisTarih2.Name = "fisTarih2"
        Me.fisTarih2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fisTarih2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.fisTarih2.Size = New System.Drawing.Size(100, 20)
        Me.fisTarih2.TabIndex = 97
        '
        'fisTarih1
        '
        Me.fisTarih1.EditValue = Nothing
        Me.fisTarih1.Enabled = False
        Me.fisTarih1.Location = New System.Drawing.Point(100, 70)
        Me.fisTarih1.Name = "fisTarih1"
        Me.fisTarih1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fisTarih1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.fisTarih1.Size = New System.Drawing.Size(100, 20)
        Me.fisTarih1.TabIndex = 96
        '
        'frm_pesin_satis_sil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 129)
        Me.Controls.Add(Me.fisTarihiF)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.fisTarih2)
        Me.Controls.Add(Me.fisTarih1)
        Me.Controls.Add(Me.depoAciklama)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.depoKodu)
        Me.Controls.Add(Me.LabelControl92)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(342, 167)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(342, 167)
        Me.Name = "frm_pesin_satis_sil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peþin Satýþ Silme"
        CType(Me.depoKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.fisTarihiF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fisTarih2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fisTarih2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fisTarih1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fisTarih1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl92 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents depoKodu As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents depoAciklama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents fisTarihiF As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents fisTarih2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents fisTarih1 As DevExpress.XtraEditors.DateEdit
End Class
