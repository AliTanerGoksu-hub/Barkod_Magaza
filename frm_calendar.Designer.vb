<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_calendar
    Inherits DevExpress.XtraEditors.XtraForm
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_calendar))
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_YilFarki = New DevExpress.XtraEditors.LabelControl
        Me.lbl_AyFarki = New DevExpress.XtraEditors.LabelControl
        Me.lbl_HaftaFarki = New DevExpress.XtraEditors.LabelControl
        Me.lbl_GunFarki = New DevExpress.XtraEditors.LabelControl
        Me.btn_Hesapla = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.lbl_Tarih = New DevExpress.XtraEditors.LabelControl
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup
        Me.txt_nYil = New DevExpress.XtraEditors.SpinEdit
        Me.txt_nAy = New DevExpress.XtraEditors.SpinEdit
        Me.txt_nHafta = New DevExpress.XtraEditors.SpinEdit
        Me.txt_nGun = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit3 = New DevExpress.XtraEditors.DateEdit
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nYil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nAy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nHafta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nGun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(796, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "**"
        '
        'Timer1
        '
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MonthCalendar1.Location = New System.Drawing.Point(110, 178)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.RightToLeftLayout = True
        Me.MonthCalendar1.ShowWeekNumbers = True
        Me.MonthCalendar1.TabIndex = 4
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.lbl_YilFarki)
        Me.GroupControl1.Controls.Add(Me.lbl_AyFarki)
        Me.GroupControl1.Controls.Add(Me.lbl_HaftaFarki)
        Me.GroupControl1.Controls.Add(Me.lbl_GunFarki)
        Me.GroupControl1.Controls.Add(Me.btn_Hesapla)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(394, 21)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(402, 348)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "Tarih Farkı"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(142, 168)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(14, 13)
        Me.LabelControl10.TabIndex = 12
        Me.LabelControl10.Text = "Yıl:"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(139, 149)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(17, 13)
        Me.LabelControl9.TabIndex = 11
        Me.LabelControl9.Text = "Ay:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(125, 129)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl8.TabIndex = 10
        Me.LabelControl8.Text = "Hafta:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(133, 110)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl7.TabIndex = 9
        Me.LabelControl7.Text = "Gün:"
        '
        'lbl_YilFarki
        '
        Me.lbl_YilFarki.Location = New System.Drawing.Point(171, 167)
        Me.lbl_YilFarki.Name = "lbl_YilFarki"
        Me.lbl_YilFarki.Size = New System.Drawing.Size(12, 13)
        Me.lbl_YilFarki.TabIndex = 8
        Me.lbl_YilFarki.Text = "..."
        '
        'lbl_AyFarki
        '
        Me.lbl_AyFarki.Location = New System.Drawing.Point(171, 148)
        Me.lbl_AyFarki.Name = "lbl_AyFarki"
        Me.lbl_AyFarki.Size = New System.Drawing.Size(12, 13)
        Me.lbl_AyFarki.TabIndex = 7
        Me.lbl_AyFarki.Text = "..."
        '
        'lbl_HaftaFarki
        '
        Me.lbl_HaftaFarki.Location = New System.Drawing.Point(171, 129)
        Me.lbl_HaftaFarki.Name = "lbl_HaftaFarki"
        Me.lbl_HaftaFarki.Size = New System.Drawing.Size(12, 13)
        Me.lbl_HaftaFarki.TabIndex = 6
        Me.lbl_HaftaFarki.Text = "..."
        '
        'lbl_GunFarki
        '
        Me.lbl_GunFarki.Location = New System.Drawing.Point(171, 110)
        Me.lbl_GunFarki.Name = "lbl_GunFarki"
        Me.lbl_GunFarki.Size = New System.Drawing.Size(12, 13)
        Me.lbl_GunFarki.TabIndex = 5
        Me.lbl_GunFarki.Text = "..."
        '
        'btn_Hesapla
        '
        Me.btn_Hesapla.Location = New System.Drawing.Point(171, 81)
        Me.btn_Hesapla.Name = "btn_Hesapla"
        Me.btn_Hesapla.Size = New System.Drawing.Size(100, 23)
        Me.btn_Hesapla.TabIndex = 4
        Me.btn_Hesapla.Text = "Hesapla"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(122, 62)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Tarih2:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(122, 42)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Tarih1:"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Location = New System.Drawing.Point(171, 55)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit2.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit2.TabIndex = 1
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(171, 35)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit1.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.SimpleButton1)
        Me.GroupControl2.Controls.Add(Me.lbl_Tarih)
        Me.GroupControl2.Controls.Add(Me.RadioGroup1)
        Me.GroupControl2.Controls.Add(Me.txt_nYil)
        Me.GroupControl2.Controls.Add(Me.MonthCalendar1)
        Me.GroupControl2.Controls.Add(Me.txt_nAy)
        Me.GroupControl2.Controls.Add(Me.txt_nHafta)
        Me.GroupControl2.Controls.Add(Me.txt_nGun)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.LabelControl11)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.DateEdit3)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl2.Location = New System.Drawing.Point(0, 21)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(394, 348)
        Me.GroupControl2.TabIndex = 6
        Me.GroupControl2.Text = "Gün Hesapla"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(110, 133)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(148, 23)
        Me.SimpleButton1.TabIndex = 23
        Me.SimpleButton1.Text = "Hesapla"
        '
        'lbl_Tarih
        '
        Me.lbl_Tarih.Location = New System.Drawing.Point(112, 153)
        Me.lbl_Tarih.Name = "lbl_Tarih"
        Me.lbl_Tarih.Size = New System.Drawing.Size(12, 13)
        Me.lbl_Tarih.TabIndex = 22
        Me.lbl_Tarih.Text = "..."
        '
        'RadioGroup1
        '
        Me.RadioGroup1.Location = New System.Drawing.Point(168, 51)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Ekle"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Çıkar")})
        Me.RadioGroup1.Size = New System.Drawing.Size(90, 80)
        Me.RadioGroup1.TabIndex = 21
        '
        'txt_nYil
        '
        Me.txt_nYil.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nYil.Location = New System.Drawing.Point(110, 111)
        Me.txt_nYil.Name = "txt_nYil"
        Me.txt_nYil.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_nYil.Size = New System.Drawing.Size(52, 20)
        Me.txt_nYil.TabIndex = 20
        '
        'txt_nAy
        '
        Me.txt_nAy.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nAy.Location = New System.Drawing.Point(110, 91)
        Me.txt_nAy.Name = "txt_nAy"
        Me.txt_nAy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_nAy.Size = New System.Drawing.Size(52, 20)
        Me.txt_nAy.TabIndex = 19
        '
        'txt_nHafta
        '
        Me.txt_nHafta.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nHafta.Location = New System.Drawing.Point(110, 71)
        Me.txt_nHafta.Name = "txt_nHafta"
        Me.txt_nHafta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_nHafta.Size = New System.Drawing.Size(52, 20)
        Me.txt_nHafta.TabIndex = 18
        '
        'txt_nGun
        '
        Me.txt_nGun.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nGun.Location = New System.Drawing.Point(110, 51)
        Me.txt_nGun.Name = "txt_nGun"
        Me.txt_nGun.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_nGun.Size = New System.Drawing.Size(52, 20)
        Me.txt_nGun.TabIndex = 17
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(45, 110)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(14, 13)
        Me.LabelControl4.TabIndex = 16
        Me.LabelControl4.Text = "Yıl:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(42, 91)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(17, 13)
        Me.LabelControl5.TabIndex = 15
        Me.LabelControl5.Text = "Ay:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(28, 71)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl6.TabIndex = 14
        Me.LabelControl6.Text = "Hafta:"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(36, 52)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl11.TabIndex = 13
        Me.LabelControl11.Text = "Gün:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(31, 28)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "Tarih:"
        '
        'DateEdit3
        '
        Me.DateEdit3.EditValue = Nothing
        Me.DateEdit3.Location = New System.Drawing.Point(110, 25)
        Me.DateEdit3.Name = "DateEdit3"
        Me.DateEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit3.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit3.Size = New System.Drawing.Size(148, 20)
        Me.DateEdit3.TabIndex = 1
        '
        'frm_calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 369)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_calendar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Takvim"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nYil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nAy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nHafta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nGun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_YilFarki As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_AyFarki As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_HaftaFarki As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_GunFarki As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_Hesapla As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbl_Tarih As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txt_nYil As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_nAy As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_nHafta As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_nGun As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit3 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
