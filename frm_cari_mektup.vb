Public Class frm_cari_mektup
    Inherits DevExpress.XtraEditors.XtraForm
#Region " Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_musteriadi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_musterikodu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_musterino As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_izahat As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_kod5 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_kod4 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_kod3 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_kod2 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_kod1 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_aciklama As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents sec_tarih As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_form As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cari_mektup))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txt_musteriadi = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_musterikodu = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_musterino = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_form = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label13 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_izahat = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label12 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_kod5 = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label11 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_kod4 = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label10 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_kod3 = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_kod2 = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_kod1 = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_aciklama = New DevExpress.XtraEditors.MemoEdit()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_tarih = New DevExpress.XtraEditors.DateEdit()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txt_musteriadi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_musterikodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_musterino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_form.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_izahat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kod5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kod4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kod3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kod2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kod1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_aciklama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_tarih.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_tarih.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(328, 56)
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Müþteri Mektup Bilgileri Aþaðýdaki Gibidir."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 431)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(328, 40)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(241, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(166, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GroupControl2)
        Me.PanelControl3.Controls.Add(Me.GroupControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(328, 375)
        Me.PanelControl3.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txt_musteriadi)
        Me.GroupControl2.Controls.Add(Me.Label4)
        Me.GroupControl2.Controls.Add(Me.txt_musterikodu)
        Me.GroupControl2.Controls.Add(Me.Label3)
        Me.GroupControl2.Controls.Add(Me.txt_musterino)
        Me.GroupControl2.Controls.Add(Me.Label2)
        Me.GroupControl2.Location = New System.Drawing.Point(8, 272)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(310, 97)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Müþteri Bilgileri"
        '
        'txt_musteriadi
        '
        Me.txt_musteriadi.Enabled = False
        Me.txt_musteriadi.EnterMoveNextControl = True
        Me.txt_musteriadi.Location = New System.Drawing.Point(96, 68)
        Me.txt_musteriadi.Name = "txt_musteriadi"
        Me.txt_musteriadi.Properties.ReadOnly = True
        Me.txt_musteriadi.Size = New System.Drawing.Size(208, 20)
        Me.txt_musteriadi.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(5, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "MüþteriAdý:"
        '
        'txt_musterikodu
        '
        Me.txt_musterikodu.Enabled = False
        Me.txt_musterikodu.EnterMoveNextControl = True
        Me.txt_musterikodu.Location = New System.Drawing.Point(96, 46)
        Me.txt_musterikodu.Name = "txt_musterikodu"
        Me.txt_musterikodu.Properties.ReadOnly = True
        Me.txt_musterikodu.Size = New System.Drawing.Size(208, 20)
        Me.txt_musterikodu.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "MüþteriKodu:"
        '
        'txt_musterino
        '
        Me.txt_musterino.Enabled = False
        Me.txt_musterino.EnterMoveNextControl = True
        Me.txt_musterino.Location = New System.Drawing.Point(96, 24)
        Me.txt_musterino.Name = "txt_musterino"
        Me.txt_musterino.Properties.ReadOnly = True
        Me.txt_musterino.Size = New System.Drawing.Size(208, 20)
        Me.txt_musterino.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "MüþteriNo:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_form)
        Me.GroupControl1.Controls.Add(Me.Label13)
        Me.GroupControl1.Controls.Add(Me.sec_izahat)
        Me.GroupControl1.Controls.Add(Me.Label12)
        Me.GroupControl1.Controls.Add(Me.txt_kod5)
        Me.GroupControl1.Controls.Add(Me.Label11)
        Me.GroupControl1.Controls.Add(Me.txt_kod4)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Controls.Add(Me.txt_kod3)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.txt_kod2)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.txt_kod1)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.txt_aciklama)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.sec_tarih)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 9)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(312, 257)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Mektup Bilgileri"
        '
        'sec_form
        '
        Me.sec_form.EditValue = "C:\Formlar\Mektup\"
        Me.sec_form.EnterMoveNextControl = True
        Me.sec_form.Location = New System.Drawing.Point(96, 68)
        Me.sec_form.Name = "sec_form"
        Me.sec_form.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_form.Properties.MaxLength = 50
        Me.sec_form.Size = New System.Drawing.Size(208, 20)
        Me.sec_form.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "MektupFormatý:"
        '
        'sec_izahat
        '
        Me.sec_izahat.EditValue = "Taksit Gecikme Mektubu 1"
        Me.sec_izahat.EnterMoveNextControl = True
        Me.sec_izahat.Location = New System.Drawing.Point(96, 46)
        Me.sec_izahat.Name = "sec_izahat"
        Me.sec_izahat.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_izahat.Properties.Appearance.Options.UseBackColor = True
        Me.sec_izahat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_izahat.Properties.Items.AddRange(New Object() {"Taksit Gecikme Mektubu 1", "Taksit Gecikme Mektubu 2", "Promosyon Mektubu", "Kutlama Mektubu", "Tebrik Mektubu", "Ekstere Mektubu", "Kalan Taksit Mektubu", "Kalan Ödemeler Mektubu", "Servis Mektubu"})
        Me.sec_izahat.Properties.MaxLength = 50
        Me.sec_izahat.Size = New System.Drawing.Size(208, 20)
        Me.sec_izahat.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Ýzahat:"
        '
        'txt_kod5
        '
        Me.txt_kod5.EnterMoveNextControl = True
        Me.txt_kod5.Location = New System.Drawing.Point(96, 226)
        Me.txt_kod5.Name = "txt_kod5"
        Me.txt_kod5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_kod5.Properties.MaxLength = 50
        Me.txt_kod5.Size = New System.Drawing.Size(208, 20)
        Me.txt_kod5.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 226)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Kod5:"
        '
        'txt_kod4
        '
        Me.txt_kod4.EnterMoveNextControl = True
        Me.txt_kod4.Location = New System.Drawing.Point(96, 204)
        Me.txt_kod4.Name = "txt_kod4"
        Me.txt_kod4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_kod4.Properties.MaxLength = 50
        Me.txt_kod4.Size = New System.Drawing.Size(208, 20)
        Me.txt_kod4.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 204)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Kod4:"
        '
        'txt_kod3
        '
        Me.txt_kod3.EnterMoveNextControl = True
        Me.txt_kod3.Location = New System.Drawing.Point(96, 182)
        Me.txt_kod3.Name = "txt_kod3"
        Me.txt_kod3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_kod3.Properties.MaxLength = 50
        Me.txt_kod3.Size = New System.Drawing.Size(208, 20)
        Me.txt_kod3.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Kod3:"
        '
        'txt_kod2
        '
        Me.txt_kod2.EnterMoveNextControl = True
        Me.txt_kod2.Location = New System.Drawing.Point(96, 160)
        Me.txt_kod2.Name = "txt_kod2"
        Me.txt_kod2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_kod2.Properties.MaxLength = 50
        Me.txt_kod2.Size = New System.Drawing.Size(208, 20)
        Me.txt_kod2.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Kod2:"
        '
        'txt_kod1
        '
        Me.txt_kod1.EnterMoveNextControl = True
        Me.txt_kod1.Location = New System.Drawing.Point(96, 138)
        Me.txt_kod1.Name = "txt_kod1"
        Me.txt_kod1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_kod1.Properties.MaxLength = 50
        Me.txt_kod1.Size = New System.Drawing.Size(208, 20)
        Me.txt_kod1.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Kod1:"
        '
        'txt_aciklama
        '
        Me.txt_aciklama.EnterMoveNextControl = True
        Me.txt_aciklama.Location = New System.Drawing.Point(96, 90)
        Me.txt_aciklama.Name = "txt_aciklama"
        Me.txt_aciklama.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_aciklama.Size = New System.Drawing.Size(208, 48)
        Me.txt_aciklama.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Açýklama:"
        '
        'sec_tarih
        '
        Me.sec_tarih.EditValue = Nothing
        Me.sec_tarih.EnterMoveNextControl = True
        Me.sec_tarih.Location = New System.Drawing.Point(96, 24)
        Me.sec_tarih.Name = "sec_tarih"
        Me.sec_tarih.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_tarih.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_tarih.Size = New System.Drawing.Size(208, 20)
        Me.sec_tarih.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tarih:"
        '
        'frm_cari_mektup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(328, 471)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_cari_mektup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mektup"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txt_musteriadi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_musterikodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_musterino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_form.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_izahat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kod5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kod4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kod3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kod2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kod1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_aciklama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_tarih.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_tarih.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public kullanici As String
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub frm_cari_mektup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sec_tarih.EditValue = dteSistemTarihi
    End Sub
    Private Sub GroupControl2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupControl2.Paint
    End Sub
    Private Sub sec_form_dosya()
        OpenFileDialog1.Filter = "Mektup Dosyalarý (Mektup*.fr3) |Mektup*.fr3"
        OpenFileDialog1.InitialDirectory = sec_form.Text
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            sec_form.Text = OpenFileDialog1.FileName.ToString
        End If
    End Sub
    Private Sub sec_form_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles sec_form.ButtonClick
        sec_form_dosya()
    End Sub
End Class
