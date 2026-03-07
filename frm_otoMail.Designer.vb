<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_otoMail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_otoMail))
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_sKod = New DevExpress.XtraEditors.LabelControl()
        Me.durum = New DevExpress.XtraEditors.CheckEdit()
        Me.adres = New DevExpress.XtraEditors.TextEdit()
        Me.zaman = New System.Windows.Forms.NumericUpDown()
        Me.saatPicker = New System.Windows.Forms.DateTimePicker()
        CType(Me.durum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zaman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(393, 133)
        Me.SimpleButton2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(273, 133)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "&Tamam"
        '
        'lbl_sKod
        '
        Me.lbl_sKod.Location = New System.Drawing.Point(18, 26)
        Me.lbl_sKod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_sKod.Name = "lbl_sKod"
        Me.lbl_sKod.Size = New System.Drawing.Size(65, 19)
        Me.lbl_sKod.TabIndex = 3
        Me.lbl_sKod.Text = "Adresler:"
        '
        'durum
        '
        Me.durum.EditValue = True
        Me.durum.Location = New System.Drawing.Point(285, 72)
        Me.durum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.durum.Name = "durum"
        Me.durum.Properties.Caption = "Otomatik Gönderim Aktif."
        Me.durum.Size = New System.Drawing.Size(228, 24)
        Me.durum.TabIndex = 0
        '
        'adres
        '
        Me.adres.Location = New System.Drawing.Point(93, 22)
        Me.adres.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.adres.Name = "adres"
        Me.adres.Size = New System.Drawing.Size(420, 26)
        Me.adres.TabIndex = 14
        '
        'zaman
        '
        Me.zaman.Location = New System.Drawing.Point(93, 60)
        Me.zaman.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.zaman.Maximum = New Decimal(New Integer() {1440, 0, 0, 0})
        Me.zaman.Name = "zaman"
        Me.zaman.Size = New System.Drawing.Size(94, 27)
        Me.zaman.TabIndex = 15
        Me.zaman.Visible = False
        '
        'saatPicker
        '
        Me.saatPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.saatPicker.Location = New System.Drawing.Point(93, 99)
        Me.saatPicker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.saatPicker.Name = "saatPicker"
        Me.saatPicker.ShowUpDown = True
        Me.saatPicker.Size = New System.Drawing.Size(148, 27)
        Me.saatPicker.TabIndex = 16
        '
        'frm_otoMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 186)
        Me.Controls.Add(Me.saatPicker)
        Me.Controls.Add(Me.zaman)
        Me.Controls.Add(Me.adres)
        Me.Controls.Add(Me.lbl_sKod)
        Me.Controls.Add(Me.durum)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_otoMail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Otomatik Mail Gönderim Ayarlarý"
        CType(Me.durum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_sKod As DevExpress.XtraEditors.LabelControl
    Friend WithEvents durum As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents adres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents zaman As System.Windows.Forms.NumericUpDown
    Friend WithEvents saatPicker As System.Windows.Forms.DateTimePicker ' Ekleyin
End Class