<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_fis_depo_kodu_degistir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_fis_depo_kodu_degistir))
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl92 = New DevExpress.XtraEditors.LabelControl()
        Me.eskiDepoKodu = New DevExpress.XtraEditors.LookUpEdit()
        Me.yeniDepoKodu = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.eskiDepoAciklama = New DevExpress.XtraEditors.LabelControl()
        Me.yeniDepoAciklama = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.fisNoF = New DevExpress.XtraEditors.CheckEdit()
        Me.fisTarihiF = New DevExpress.XtraEditors.CheckEdit()
        Me.fisTipiF = New DevExpress.XtraEditors.CheckEdit()
        Me.fisTipiAciklama = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.fisNoBit = New DevExpress.XtraEditors.SpinEdit()
        Me.fisNoBas = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.fisTarih2 = New DevExpress.XtraEditors.DateEdit()
        Me.fisTarih1 = New DevExpress.XtraEditors.DateEdit()
        Me.fisTipi = New DevExpress.XtraEditors.LookUpEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.eskiDepoKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yeniDepoKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.fisNoF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fisTarihiF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fisTipiF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fisNoBit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fisNoBas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fisTarih2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fisTarih2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fisTarih1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fisTarih1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fisTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(234, 267)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(148, 267)
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
        Me.LabelControl92.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl92.TabIndex = 68
        Me.LabelControl92.Text = "Eski Depo Kodu:"
        '
        'eskiDepoKodu
        '
        Me.eskiDepoKodu.Location = New System.Drawing.Point(100, 9)
        Me.eskiDepoKodu.Name = "eskiDepoKodu"
        Me.eskiDepoKodu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eskiDepoKodu.Properties.DisplayMember = "sDepo"
        Me.eskiDepoKodu.Properties.NullText = ""
        Me.eskiDepoKodu.Properties.ValueMember = "sDepo"
        Me.eskiDepoKodu.Size = New System.Drawing.Size(214, 20)
        Me.eskiDepoKodu.TabIndex = 77
        '
        'yeniDepoKodu
        '
        Me.yeniDepoKodu.Location = New System.Drawing.Point(100, 68)
        Me.yeniDepoKodu.Name = "yeniDepoKodu"
        Me.yeniDepoKodu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.yeniDepoKodu.Properties.DisplayMember = "sDepo"
        Me.yeniDepoKodu.Properties.NullText = ""
        Me.yeniDepoKodu.Properties.ValueMember = "sDepo"
        Me.yeniDepoKodu.Size = New System.Drawing.Size(214, 20)
        Me.yeniDepoKodu.TabIndex = 79
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(12, 71)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl1.TabIndex = 78
        Me.LabelControl1.Text = "Yeni Depo Kodu:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(12, 42)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl2.TabIndex = 80
        Me.LabelControl2.Text = "Eski Depo Açýklama:"
        '
        'eskiDepoAciklama
        '
        Me.eskiDepoAciklama.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eskiDepoAciklama.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.eskiDepoAciklama.Location = New System.Drawing.Point(112, 42)
        Me.eskiDepoAciklama.Name = "eskiDepoAciklama"
        Me.eskiDepoAciklama.Size = New System.Drawing.Size(0, 13)
        Me.eskiDepoAciklama.TabIndex = 81
        '
        'yeniDepoAciklama
        '
        Me.yeniDepoAciklama.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.yeniDepoAciklama.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.yeniDepoAciklama.Location = New System.Drawing.Point(112, 100)
        Me.yeniDepoAciklama.Name = "yeniDepoAciklama"
        Me.yeniDepoAciklama.Size = New System.Drawing.Size(0, 13)
        Me.yeniDepoAciklama.TabIndex = 83
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(12, 100)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl5.TabIndex = 82
        Me.LabelControl5.Text = "Yeni Depo Açýklama:"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.EditValue = True
        Me.CheckEdit1.Location = New System.Drawing.Point(10, 128)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Filtre"
        Me.CheckEdit1.Size = New System.Drawing.Size(75, 19)
        Me.CheckEdit1.TabIndex = 84
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.fisNoF)
        Me.PanelControl1.Controls.Add(Me.fisTarihiF)
        Me.PanelControl1.Controls.Add(Me.fisTipiF)
        Me.PanelControl1.Controls.Add(Me.fisTipiAciklama)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl10)
        Me.PanelControl1.Controls.Add(Me.fisNoBit)
        Me.PanelControl1.Controls.Add(Me.fisNoBas)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.fisTarih2)
        Me.PanelControl1.Controls.Add(Me.fisTarih1)
        Me.PanelControl1.Controls.Add(Me.fisTipi)
        Me.PanelControl1.Location = New System.Drawing.Point(0, 150)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(325, 112)
        Me.PanelControl1.TabIndex = 85
        '
        'fisNoF
        '
        Me.fisNoF.Location = New System.Drawing.Point(10, 86)
        Me.fisNoF.Name = "fisNoF"
        Me.fisNoF.Properties.Caption = "Fiþ NO:"
        Me.fisNoF.Size = New System.Drawing.Size(75, 19)
        Me.fisNoF.TabIndex = 96
        '
        'fisTarihiF
        '
        Me.fisTarihiF.Location = New System.Drawing.Point(10, 57)
        Me.fisTarihiF.Name = "fisTarihiF"
        Me.fisTarihiF.Properties.Caption = "Fiþ Tarihi:"
        Me.fisTarihiF.Size = New System.Drawing.Size(75, 19)
        Me.fisTarihiF.TabIndex = 95
        '
        'fisTipiF
        '
        Me.fisTipiF.Location = New System.Drawing.Point(10, 2)
        Me.fisTipiF.Name = "fisTipiF"
        Me.fisTipiF.Properties.Caption = "Fiþ Tipi:"
        Me.fisTipiF.Size = New System.Drawing.Size(75, 19)
        Me.fisTipiF.TabIndex = 94
        '
        'fisTipiAciklama
        '
        Me.fisTipiAciklama.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.fisTipiAciklama.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.fisTipiAciklama.Location = New System.Drawing.Point(103, 33)
        Me.fisTipiAciklama.Name = "fisTipiAciklama"
        Me.fisTipiAciklama.Size = New System.Drawing.Size(0, 13)
        Me.fisTipiAciklama.TabIndex = 93
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(12, 33)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl4.TabIndex = 92
        Me.LabelControl4.Text = "Fiþ Tipi Açýklama:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.Location = New System.Drawing.Point(205, 90)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl10.TabIndex = 87
        Me.LabelControl10.Text = "-"
        '
        'fisNoBit
        '
        Me.fisNoBit.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.fisNoBit.Enabled = False
        Me.fisNoBit.Location = New System.Drawing.Point(214, 86)
        Me.fisNoBit.Name = "fisNoBit"
        Me.fisNoBit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.fisNoBit.Size = New System.Drawing.Size(100, 20)
        Me.fisNoBit.TabIndex = 86
        '
        'fisNoBas
        '
        Me.fisNoBas.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.fisNoBas.Enabled = False
        Me.fisNoBas.Location = New System.Drawing.Point(100, 86)
        Me.fisNoBas.Name = "fisNoBas"
        Me.fisNoBas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.fisNoBas.Size = New System.Drawing.Size(100, 20)
        Me.fisNoBas.TabIndex = 85
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.Location = New System.Drawing.Point(205, 59)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl8.TabIndex = 83
        Me.LabelControl8.Text = "-"
        '
        'fisTarih2
        '
        Me.fisTarih2.EditValue = Nothing
        Me.fisTarih2.Enabled = False
        Me.fisTarih2.Location = New System.Drawing.Point(214, 56)
        Me.fisTarih2.Name = "fisTarih2"
        Me.fisTarih2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fisTarih2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.fisTarih2.Size = New System.Drawing.Size(100, 20)
        Me.fisTarih2.TabIndex = 82
        '
        'fisTarih1
        '
        Me.fisTarih1.EditValue = Nothing
        Me.fisTarih1.Enabled = False
        Me.fisTarih1.Location = New System.Drawing.Point(100, 56)
        Me.fisTarih1.Name = "fisTarih1"
        Me.fisTarih1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fisTarih1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.fisTarih1.Size = New System.Drawing.Size(100, 20)
        Me.fisTarih1.TabIndex = 81
        '
        'fisTipi
        '
        Me.fisTipi.Enabled = False
        Me.fisTipi.Location = New System.Drawing.Point(100, 2)
        Me.fisTipi.Name = "fisTipi"
        Me.fisTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fisTipi.Properties.DisplayMember = "sFisTipi"
        Me.fisTipi.Properties.NullText = ""
        Me.fisTipi.Properties.ValueMember = "sFisTipi"
        Me.fisTipi.Size = New System.Drawing.Size(214, 20)
        Me.fisTipi.TabIndex = 79
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl6)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(326, 299)
        Me.PanelControl2.TabIndex = 88
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.LabelControl6.Location = New System.Drawing.Point(74, 119)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(169, 24)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "Lütfen Bekleyiniz..."
        '
        'frm_fis_depo_kodu_degistir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 299)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.yeniDepoAciklama)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.eskiDepoAciklama)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.yeniDepoKodu)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.eskiDepoKodu)
        Me.Controls.Add(Me.LabelControl92)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(342, 337)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(342, 337)
        Me.Name = "frm_fis_depo_kodu_degistir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Depo Hareketleri Kaydýr"
        CType(Me.eskiDepoKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yeniDepoKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.fisNoF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fisTarihiF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fisTipiF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fisNoBit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fisNoBas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fisTarih2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fisTarih2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fisTarih1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fisTarih1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fisTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl92 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eskiDepoKodu As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents yeniDepoKodu As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eskiDepoAciklama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents yeniDepoAciklama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents fisTipi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents fisTarih2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents fisTarih1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents fisNoBit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents fisNoBas As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents fisTipiAciklama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents fisNoF As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents fisTarihiF As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents fisTipiF As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
End Class
