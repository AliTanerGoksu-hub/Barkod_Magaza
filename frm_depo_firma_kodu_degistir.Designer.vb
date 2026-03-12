<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_depo_firma_kodu_degistir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_depo_firma_kodu_degistir))
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl92 = New DevExpress.XtraEditors.LabelControl()
        Me.depoKodu = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.depoAciklama = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_tbFirma = New DevExpress.XtraEditors.ButtonEdit()
        Me.eskiFirmaKodu = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.eskiFirmaAciklama = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.yeniFirmaAciklama = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.depoKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.sec_tbFirma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(234, 184)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(148, 184)
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
        Me.PanelControl2.Size = New System.Drawing.Size(326, 216)
        Me.PanelControl2.TabIndex = 86
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(74, 92)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(169, 24)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Lütfen Bekleyiniz..."
        '
        'sec_tbFirma
        '
        Me.sec_tbFirma.EditValue = "0"
        Me.sec_tbFirma.Location = New System.Drawing.Point(100, 127)
        Me.sec_tbFirma.Name = "sec_tbFirma"
        Me.sec_tbFirma.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_tbFirma.Properties.NullText = "[MüþteriNo]"
        Me.sec_tbFirma.Size = New System.Drawing.Size(214, 20)
        Me.sec_tbFirma.TabIndex = 87
        '
        'eskiFirmaKodu
        '
        Me.eskiFirmaKodu.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eskiFirmaKodu.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.eskiFirmaKodu.Location = New System.Drawing.Point(103, 71)
        Me.eskiFirmaKodu.Name = "eskiFirmaKodu"
        Me.eskiFirmaKodu.Size = New System.Drawing.Size(0, 13)
        Me.eskiFirmaKodu.TabIndex = 89
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(12, 71)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl4.TabIndex = 88
        Me.LabelControl4.Text = "Firma Kodu:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(12, 130)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl5.TabIndex = 90
        Me.LabelControl5.Text = "Yeni Firma Kodu:"
        '
        'eskiFirmaAciklama
        '
        Me.eskiFirmaAciklama.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eskiFirmaAciklama.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.eskiFirmaAciklama.Location = New System.Drawing.Point(103, 100)
        Me.eskiFirmaAciklama.Name = "eskiFirmaAciklama"
        Me.eskiFirmaAciklama.Size = New System.Drawing.Size(0, 13)
        Me.eskiFirmaAciklama.TabIndex = 92
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.Location = New System.Drawing.Point(12, 100)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl7.TabIndex = 91
        Me.LabelControl7.Text = "Firma Açýklama:"
        '
        'yeniFirmaAciklama
        '
        Me.yeniFirmaAciklama.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.yeniFirmaAciklama.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.yeniFirmaAciklama.Location = New System.Drawing.Point(103, 159)
        Me.yeniFirmaAciklama.Name = "yeniFirmaAciklama"
        Me.yeniFirmaAciklama.Size = New System.Drawing.Size(0, 13)
        Me.yeniFirmaAciklama.TabIndex = 94
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.Location = New System.Drawing.Point(12, 159)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl9.TabIndex = 93
        Me.LabelControl9.Text = "Firma Açýklama:"
        '
        'frm_depo_firma_kodu_degistir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 216)
        Me.Controls.Add(Me.yeniFirmaAciklama)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.eskiFirmaAciklama)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.eskiFirmaKodu)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.sec_tbFirma)
        Me.Controls.Add(Me.depoAciklama)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.depoKodu)
        Me.Controls.Add(Me.LabelControl92)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(342, 254)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(342, 254)
        Me.Name = "frm_depo_firma_kodu_degistir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Depo Firma Kodu Deðiþtirme"
        CType(Me.depoKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.sec_tbFirma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents sec_tbFirma As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents eskiFirmaKodu As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eskiFirmaAciklama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents yeniFirmaAciklama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
End Class
