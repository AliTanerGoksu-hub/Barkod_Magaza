<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frm_Musteri_Bakiye
    Inherits System.Windows.Forms.Form
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
        Me.components = New System.ComponentModel.Container
        Me.lbl_sAciklama = New DevExpress.XtraEditors.LabelControl
        Me.lbl_sKodu = New DevExpress.XtraEditors.LabelControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.Button2 = New DevExpress.XtraEditors.ButtonEdit
        Me.Button3 = New DevExpress.XtraEditors.ButtonEdit
        Me.dg = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.colsYil = New System.Windows.Forms.DataGridTextBoxColumn
        Me.coldteTarih = New System.Windows.Forms.DataGridTextBoxColumn
        Me.collKalan = New System.Windows.Forms.DataGridTextBoxColumn
        Me.colnGecikme = New System.Windows.Forms.DataGridTextBoxColumn
        Me.lbl_Geciken = New DevExpress.XtraEditors.LabelControl
        Me.lbl_Bakiye = New DevExpress.XtraEditors.LabelControl
        Me.lbl_Geciken_Taksit = New DevExpress.XtraEditors.LabelControl
        Me.lbl_Geciken_Tutar = New DevExpress.XtraEditors.LabelControl
        Me.lbl_Geciken1 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_Bakiye1 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_Geciken_Taksit1 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_Geciken_Tutar1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel1 = New DevExpress.XtraEditors.PanelControl
        Me.lbl_baslik = New DevExpress.XtraEditors.LabelControl
        Me.lbl_Saat = New DevExpress.XtraEditors.LabelControl
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New DevExpress.XtraEditors.ButtonEdit
        CType(Me.Button2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Button1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_sAciklama
        '
        Me.lbl_sAciklama.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_sAciklama.Location = New System.Drawing.Point(57, 33)
        Me.lbl_sAciklama.Name = "lbl_sAciklama"
        Me.lbl_sAciklama.Size = New System.Drawing.Size(7, 13)
        Me.lbl_sAciklama.TabIndex = 117
        Me.lbl_sAciklama.Text = "*"
        '
        'lbl_sKodu
        '
        Me.lbl_sKodu.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_sKodu.Location = New System.Drawing.Point(56, 16)
        Me.lbl_sKodu.Name = "lbl_sKodu"
        Me.lbl_sKodu.Size = New System.Drawing.Size(7, 13)
        Me.lbl_sKodu.TabIndex = 118
        Me.lbl_sKodu.Text = "*"
        '
        'Label2
        '
        Me.Label2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label2.Location = New System.Drawing.Point(7, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Adı:"
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label1.Location = New System.Drawing.Point(7, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Kodu:"
        '
        'Button2
        '
        Me.Button2.EditValue = "&Çıkış"
        Me.Button2.Location = New System.Drawing.Point(170, 259)
        Me.Button2.Name = "Button2"
        Me.Button2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Button2.Properties.Appearance.Options.UseFont = True
        Me.Button2.Size = New System.Drawing.Size(57, 20)
        Me.Button2.TabIndex = 108
        '
        'Button3
        '
        Me.Button3.EditValue = "&Tamam"
        Me.Button3.Location = New System.Drawing.Point(100, 259)
        Me.Button3.Name = "Button3"
        Me.Button3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Button3.Properties.Appearance.Options.UseFont = True
        Me.Button3.Size = New System.Drawing.Size(70, 20)
        Me.Button3.TabIndex = 107
        '
        'dg
        '
        Me.dg.AllowSorting = False
        Me.dg.AlternatingBackColor = System.Drawing.Color.WhiteSmoke
        Me.dg.BackColor = System.Drawing.Color.Gainsboro
        Me.dg.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dg.CaptionBackColor = System.Drawing.Color.DarkKhaki
        Me.dg.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg.CaptionForeColor = System.Drawing.Color.Black
        Me.dg.CaptionVisible = False
        Me.dg.DataMember = ""
        Me.dg.FlatMode = True
        Me.dg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg.ForeColor = System.Drawing.Color.Black
        Me.dg.GridLineColor = System.Drawing.Color.Silver
        Me.dg.HeaderBackColor = System.Drawing.Color.Black
        Me.dg.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg.HeaderForeColor = System.Drawing.Color.White
        Me.dg.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dg.Location = New System.Drawing.Point(7, 57)
        Me.dg.Name = "dg"
        Me.dg.ParentRowsBackColor = System.Drawing.Color.LightGray
        Me.dg.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dg.ReadOnly = True
        Me.dg.SelectionBackColor = System.Drawing.Color.Firebrick
        Me.dg.SelectionForeColor = System.Drawing.Color.White
        Me.dg.Size = New System.Drawing.Size(225, 167)
        Me.dg.TabIndex = 106
        Me.dg.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AllowSorting = False
        Me.DataGridTableStyle1.DataGrid = Me.dg
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.colsYil, Me.coldteTarih, Me.collKalan, Me.colnGecikme})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TABLE1"
        Me.DataGridTableStyle1.ReadOnly = True
        Me.DataGridTableStyle1.RowHeadersVisible = False
        '
        'colsYil
        '
        Me.colsYil.Format = ""
        Me.colsYil.FormatInfo = Nothing
        Me.colsYil.HeaderText = "Yıl"
        Me.colsYil.MappingName = "sYil"
        Me.colsYil.Width = 40
        '
        'coldteTarih
        '
        Me.coldteTarih.Format = ""
        Me.coldteTarih.FormatInfo = Nothing
        Me.coldteTarih.HeaderText = "Vade"
        Me.coldteTarih.MappingName = "dteTarihi"
        Me.coldteTarih.Width = 80
        '
        'collKalan
        '
        Me.collKalan.Format = ""
        Me.collKalan.FormatInfo = Nothing
        Me.collKalan.HeaderText = "Kalan"
        Me.collKalan.MappingName = "KALAN"
        Me.collKalan.Width = 50
        '
        'colnGecikme
        '
        Me.colnGecikme.Format = ""
        Me.colnGecikme.FormatInfo = Nothing
        Me.colnGecikme.HeaderText = "Gün"
        Me.colnGecikme.MappingName = "GECIKME"
        Me.colnGecikme.Width = 30
        '
        'lbl_Geciken
        '
        Me.lbl_Geciken.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Geciken.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_Geciken.Location = New System.Drawing.Point(62, 227)
        Me.lbl_Geciken.Name = "lbl_Geciken"
        Me.lbl_Geciken.Size = New System.Drawing.Size(7, 13)
        Me.lbl_Geciken.TabIndex = 116
        Me.lbl_Geciken.Text = "*"
        '
        'lbl_Bakiye
        '
        Me.lbl_Bakiye.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Bakiye.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_Bakiye.Location = New System.Drawing.Point(62, 241)
        Me.lbl_Bakiye.Name = "lbl_Bakiye"
        Me.lbl_Bakiye.Size = New System.Drawing.Size(7, 13)
        Me.lbl_Bakiye.TabIndex = 115
        Me.lbl_Bakiye.Text = "*"
        '
        'lbl_Geciken_Taksit
        '
        Me.lbl_Geciken_Taksit.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Geciken_Taksit.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_Geciken_Taksit.Location = New System.Drawing.Point(175, 227)
        Me.lbl_Geciken_Taksit.Name = "lbl_Geciken_Taksit"
        Me.lbl_Geciken_Taksit.Size = New System.Drawing.Size(7, 13)
        Me.lbl_Geciken_Taksit.TabIndex = 114
        Me.lbl_Geciken_Taksit.Text = "*"
        '
        'lbl_Geciken_Tutar
        '
        Me.lbl_Geciken_Tutar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Geciken_Tutar.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_Geciken_Tutar.Location = New System.Drawing.Point(176, 241)
        Me.lbl_Geciken_Tutar.Name = "lbl_Geciken_Tutar"
        Me.lbl_Geciken_Tutar.Size = New System.Drawing.Size(7, 13)
        Me.lbl_Geciken_Tutar.TabIndex = 113
        Me.lbl_Geciken_Tutar.Text = "*"
        '
        'lbl_Geciken1
        '
        Me.lbl_Geciken1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lbl_Geciken1.Location = New System.Drawing.Point(8, 227)
        Me.lbl_Geciken1.Name = "lbl_Geciken1"
        Me.lbl_Geciken1.Size = New System.Drawing.Size(41, 13)
        Me.lbl_Geciken1.TabIndex = 112
        Me.lbl_Geciken1.Text = "Geciken:"
        '
        'lbl_Bakiye1
        '
        Me.lbl_Bakiye1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lbl_Bakiye1.Location = New System.Drawing.Point(8, 241)
        Me.lbl_Bakiye1.Name = "lbl_Bakiye1"
        Me.lbl_Bakiye1.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Bakiye1.TabIndex = 111
        Me.lbl_Bakiye1.Text = "Toplam:"
        '
        'lbl_Geciken_Taksit1
        '
        Me.lbl_Geciken_Taksit1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lbl_Geciken_Taksit1.Location = New System.Drawing.Point(136, 227)
        Me.lbl_Geciken_Taksit1.Name = "lbl_Geciken_Taksit1"
        Me.lbl_Geciken_Taksit1.Size = New System.Drawing.Size(24, 13)
        Me.lbl_Geciken_Taksit1.TabIndex = 110
        Me.lbl_Geciken_Taksit1.Text = "Sayı:"
        '
        'lbl_Geciken_Tutar1
        '
        Me.lbl_Geciken_Tutar1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lbl_Geciken_Tutar1.Location = New System.Drawing.Point(136, 241)
        Me.lbl_Geciken_Tutar1.Name = "lbl_Geciken_Tutar1"
        Me.lbl_Geciken_Tutar1.Size = New System.Drawing.Size(24, 13)
        Me.lbl_Geciken_Tutar1.TabIndex = 109
        Me.lbl_Geciken_Tutar1.Text = "Sayı:"
        '
        'Panel1
        '
        Me.Panel1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Appearance.Options.UseBackColor = True
        Me.Panel1.Controls.Add(Me.lbl_baslik)
        Me.Panel1.Controls.Add(Me.lbl_Saat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 14)
        Me.Panel1.TabIndex = 0
        '
        'lbl_baslik
        '
        Me.lbl_baslik.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_baslik.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_baslik.Appearance.ForeColor = System.Drawing.Color.White
        Me.lbl_baslik.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_baslik.Location = New System.Drawing.Point(2, 2)
        Me.lbl_baslik.Name = "lbl_baslik"
        Me.lbl_baslik.Size = New System.Drawing.Size(7, 13)
        Me.lbl_baslik.TabIndex = 0
        Me.lbl_baslik.Text = "*"
        '
        'lbl_Saat
        '
        Me.lbl_Saat.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_Saat.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Saat.Appearance.ForeColor = System.Drawing.Color.White
        Me.lbl_Saat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_Saat.Location = New System.Drawing.Point(231, 2)
        Me.lbl_Saat.Name = "lbl_Saat"
        Me.lbl_Saat.Size = New System.Drawing.Size(7, 13)
        Me.lbl_Saat.TabIndex = 1
        Me.lbl_Saat.Text = "*"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button1
        '
        Me.Button1.EditValue = "Aylık"
        Me.Button1.Location = New System.Drawing.Point(7, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Button1.Properties.Appearance.Options.UseFont = True
        Me.Button1.Size = New System.Drawing.Size(70, 20)
        Me.Button1.TabIndex = 121
        '
        'frm_Musteri_Bakiye
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(240, 290)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lbl_Geciken_Tutar1)
        Me.Controls.Add(Me.lbl_Geciken_Taksit1)
        Me.Controls.Add(Me.lbl_Bakiye1)
        Me.Controls.Add(Me.lbl_Geciken1)
        Me.Controls.Add(Me.lbl_Geciken_Tutar)
        Me.Controls.Add(Me.lbl_Geciken_Taksit)
        Me.Controls.Add(Me.lbl_Bakiye)
        Me.Controls.Add(Me.lbl_Geciken)
        Me.Controls.Add(Me.lbl_sAciklama)
        Me.Controls.Add(Me.lbl_sKodu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Musteri_Bakiye"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Button2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Button1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Friend WithEvents lbl_sAciklama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_sKodu As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Button2 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents Button3 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents dg As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents lbl_Geciken As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Bakiye As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Geciken_Taksit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Geciken_Tutar As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Geciken1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Bakiye1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Geciken_Taksit1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Geciken_Tutar1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents coldteTarih As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents collKalan As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents colnGecikme As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Panel1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lbl_baslik As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Saat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents colsYil As System.Windows.Forms.DataGridTextBoxColumn
End Class
