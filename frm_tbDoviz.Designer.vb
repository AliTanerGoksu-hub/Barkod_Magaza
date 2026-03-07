<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_tbDoviz
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tbDoviz))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.sec_sDovizCinsi = New DevExpress.XtraEditors.LookUpEdit
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.sec_lDovizKuru = New DevExpress.XtraEditors.CalcEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txt_lDovizTutar = New DevExpress.XtraEditors.CalcEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txt_lTutar = New DevExpress.XtraEditors.CalcEdit
        CType(Me.sec_sDovizCinsi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_lDovizKuru.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lDovizTutar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lTutar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(41, 46)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Doviz:"
        '
        'sec_sDovizCinsi
        '
        Me.sec_sDovizCinsi.EnterMoveNextControl = True
        Me.sec_sDovizCinsi.Location = New System.Drawing.Point(78, 42)
        Me.sec_sDovizCinsi.Name = "sec_sDovizCinsi"
        Me.sec_sDovizCinsi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sDovizCinsi.Properties.Appearance.Options.UseBackColor = True
        Me.sec_sDovizCinsi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sDovizCinsi.Properties.DisplayMember = "sKod"
        Me.sec_sDovizCinsi.Properties.NullText = ""
        Me.sec_sDovizCinsi.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_sDovizCinsi.Properties.ValueMember = "sKod"
        Me.sec_sDovizCinsi.Size = New System.Drawing.Size(210, 22)
        Me.sec_sDovizCinsi.TabIndex = 1
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(202, 126)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(86, 24)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(78, 126)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(124, 24)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Tamam"
        '
        'sec_lDovizKuru
        '
        Me.sec_lDovizKuru.EnterMoveNextControl = True
        Me.sec_lDovizKuru.Location = New System.Drawing.Point(78, 64)
        Me.sec_lDovizKuru.Name = "sec_lDovizKuru"
        Me.sec_lDovizKuru.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_lDovizKuru.Properties.Appearance.Options.UseBackColor = True
        Me.sec_lDovizKuru.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_lDovizKuru.Properties.DisplayFormat.FormatString = "#,0.0000"
        Me.sec_lDovizKuru.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_lDovizKuru.Properties.EditFormat.FormatString = "#,0.0000"
        Me.sec_lDovizKuru.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_lDovizKuru.Properties.NullText = "0.0000"
        Me.sec_lDovizKuru.Size = New System.Drawing.Size(210, 22)
        Me.sec_lDovizKuru.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(51, 67)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Kur:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(15, 91)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "DövizTutar:"
        '
        'txt_lDovizTutar
        '
        Me.txt_lDovizTutar.EnterMoveNextControl = True
        Me.txt_lDovizTutar.Location = New System.Drawing.Point(78, 86)
        Me.txt_lDovizTutar.Name = "txt_lDovizTutar"
        Me.txt_lDovizTutar.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lDovizTutar.Properties.Appearance.Options.UseBackColor = True
        Me.txt_lDovizTutar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_lDovizTutar.Properties.DisplayFormat.FormatString = "#,0.0000"
        Me.txt_lDovizTutar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_lDovizTutar.Properties.EditFormat.FormatString = "#,0.0000"
        Me.txt_lDovizTutar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_lDovizTutar.Properties.NullText = "0.0000"
        Me.txt_lDovizTutar.Size = New System.Drawing.Size(210, 22)
        Me.txt_lDovizTutar.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(41, 23)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl4.TabIndex = 13
        Me.LabelControl4.Text = "Tutar:"
        '
        'txt_lTutar
        '
        Me.txt_lTutar.Enabled = False
        Me.txt_lTutar.EnterMoveNextControl = True
        Me.txt_lTutar.Location = New System.Drawing.Point(78, 20)
        Me.txt_lTutar.Name = "txt_lTutar"
        Me.txt_lTutar.Properties.Appearance.BackColor = System.Drawing.Color.Silver
        Me.txt_lTutar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_lTutar.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txt_lTutar.Properties.Appearance.Options.UseBackColor = True
        Me.txt_lTutar.Properties.Appearance.Options.UseFont = True
        Me.txt_lTutar.Properties.Appearance.Options.UseForeColor = True
        Me.txt_lTutar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_lTutar.Properties.DisplayFormat.FormatString = "#,0.0000"
        Me.txt_lTutar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_lTutar.Properties.EditFormat.FormatString = "#,0.0000"
        Me.txt_lTutar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_lTutar.Properties.NullText = "0.0000"
        Me.txt_lTutar.Properties.ReadOnly = True
        Me.txt_lTutar.Size = New System.Drawing.Size(210, 22)
        Me.txt_lTutar.TabIndex = 0
        '
        'frm_tbDoviz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 162)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txt_lTutar)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txt_lDovizTutar)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.sec_lDovizKuru)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.sec_sDovizCinsi)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_tbDoviz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DovizCinsi"
        CType(Me.sec_sDovizCinsi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_lDovizKuru.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lDovizTutar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lTutar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sDovizCinsi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_lDovizKuru As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lDovizTutar As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lTutar As DevExpress.XtraEditors.CalcEdit
End Class
