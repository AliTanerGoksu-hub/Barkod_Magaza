Imports DevExpress.XtraEditors
Public Class frm_personel_takip
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
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grd_PersonelTakip As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Dataset1 As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_maazeret_aciklama As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents sec_maazeret As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_sef_sifre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sef_kodu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_giris As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_personel_sifre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_personel_kodu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_magaza As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_yetkili As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_yetkili_sifre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_yetkili_kod As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_resim As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents Lbl_tarih As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txt_personel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sef As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_sure As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_izahat As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_vardiya As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBELGENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGIRISSAAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIKISSAAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSURE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMAGAZA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVARDIYA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIZAHAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYETKILIKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYETKILI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPERSONELKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPERSONEL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEFKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMAZERET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGIRIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGECGIRIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIKIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGECCIKIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTATUS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbl_kalan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_gecen As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_baslama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_bitis As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_baslama As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_personel_takip))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_izahat = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_sef = New DevExpress.XtraEditors.TextEdit()
        Me.txt_personel = New DevExpress.XtraEditors.TextEdit()
        Me.Label14 = New DevExpress.XtraEditors.LabelControl()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_maazeret_aciklama = New DevExpress.XtraEditors.MemoEdit()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_maazeret = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_sef_sifre = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sef_kodu = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_giris = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_personel_sifre = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_personel_kodu = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_vardiya = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label18 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_baslama = New DevExpress.XtraEditors.TimeEdit()
        Me.Label17 = New DevExpress.XtraEditors.LabelControl()
        Me.Label10 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sure = New DevExpress.XtraEditors.SpinEdit()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_magaza = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label15 = New DevExpress.XtraEditors.LabelControl()
        Me.Label13 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_yetkili = New DevExpress.XtraEditors.TextEdit()
        Me.txt_yetkili_sifre = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_yetkili_kod = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.grd_PersonelTakip = New DevExpress.XtraGrid.GridControl()
        Me.Dataset1 = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBELGENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGIRISSAAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCIKISSAAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSURE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMAGAZA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVARDIYA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIZAHAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYETKILIKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYETKILI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPERSONELKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPERSONEL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSEFKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSEF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMAZERET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGIRIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGECGIRIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCIKIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGECCIKIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTATUS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_resim = New DevExpress.XtraEditors.PictureEdit()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Lbl_tarih = New DevExpress.XtraEditors.LabelControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.lbl_bitis = New DevExpress.XtraEditors.LabelControl()
        Me.Label19 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_kalan = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_gecen = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_baslama = New DevExpress.XtraEditors.LabelControl()
        Me.Label16 = New DevExpress.XtraEditors.LabelControl()
        Me.Label12 = New DevExpress.XtraEditors.LabelControl()
        Me.Label11 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_izahat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sef.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_personel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_maazeret_aciklama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_maazeret.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sef_sifre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sef_kodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_personel_sifre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_personel_kodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.sec_vardiya.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_baslama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sure.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_magaza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_yetkili.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_yetkili_sifre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_yetkili_kod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.grd_PersonelTakip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dataset1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.sec_resim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.SimpleButton5)
        Me.GroupControl1.Controls.Add(Me.sec_izahat)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.txt_sef)
        Me.GroupControl1.Controls.Add(Me.txt_personel)
        Me.GroupControl1.Controls.Add(Me.Label14)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.txt_maazeret_aciklama)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.sec_maazeret)
        Me.GroupControl1.Controls.Add(Me.txt_sef_sifre)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.txt_sef_kodu)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.btn_giris)
        Me.GroupControl1.Controls.Add(Me.txt_personel_sifre)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.txt_personel_kodu)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Enabled = False
        Me.GroupControl1.Location = New System.Drawing.Point(16, 128)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(328, 227)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Giriþ/Çýkýþ Ýþlemleri"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(248, 198)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(72, 23)
        Me.SimpleButton5.TabIndex = 15
        Me.SimpleButton5.Text = "Sifre"
        '
        'sec_izahat
        '
        Me.sec_izahat.EditValue = "Normal"
        Me.sec_izahat.Location = New System.Drawing.Point(88, 24)
        Me.sec_izahat.Name = "sec_izahat"
        Me.sec_izahat.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_izahat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_izahat.Properties.Appearance.Options.UseBackColor = True
        Me.sec_izahat.Properties.Appearance.Options.UseFont = True
        Me.sec_izahat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_izahat.Properties.Items.AddRange(New Object() {"Normal", "Ýzinli", "Maazeretli", "GünlükÝzin", "HaftalýkÝzin", "AylýkÝzin", "YýllýkÝzin"})
        Me.sec_izahat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_izahat.Size = New System.Drawing.Size(232, 20)
        Me.sec_izahat.TabIndex = 0
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(172, 198)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(72, 23)
        Me.SimpleButton3.TabIndex = 10
        Me.SimpleButton3.Text = "Yeni"
        '
        'txt_sef
        '
        Me.txt_sef.Enabled = False
        Me.txt_sef.Location = New System.Drawing.Point(152, 112)
        Me.txt_sef.Name = "txt_sef"
        Me.txt_sef.Size = New System.Drawing.Size(168, 20)
        Me.txt_sef.TabIndex = 6
        '
        'txt_personel
        '
        Me.txt_personel.Enabled = False
        Me.txt_personel.Location = New System.Drawing.Point(152, 68)
        Me.txt_personel.Name = "txt_personel"
        Me.txt_personel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_personel.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_personel.Properties.Appearance.Options.UseFont = True
        Me.txt_personel.Properties.Appearance.Options.UseForeColor = True
        Me.txt_personel.Size = New System.Drawing.Size(168, 20)
        Me.txt_personel.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Ýzahat:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Açýklama:"
        '
        'txt_maazeret_aciklama
        '
        Me.txt_maazeret_aciklama.Enabled = False
        Me.txt_maazeret_aciklama.EnterMoveNextControl = True
        Me.txt_maazeret_aciklama.Location = New System.Drawing.Point(88, 156)
        Me.txt_maazeret_aciklama.Name = "txt_maazeret_aciklama"
        Me.txt_maazeret_aciklama.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_maazeret_aciklama.Size = New System.Drawing.Size(232, 42)
        Me.txt_maazeret_aciklama.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "MazeretKodu:"
        '
        'sec_maazeret
        '
        Me.sec_maazeret.Enabled = False
        Me.sec_maazeret.EnterMoveNextControl = True
        Me.sec_maazeret.Location = New System.Drawing.Point(88, 134)
        Me.sec_maazeret.Name = "sec_maazeret"
        Me.sec_maazeret.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sec_maazeret.Properties.Appearance.Options.UseBackColor = True
        Me.sec_maazeret.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_maazeret.Properties.NullText = "[Mazeretler]"
        Me.sec_maazeret.Size = New System.Drawing.Size(232, 20)
        Me.sec_maazeret.TabIndex = 7
        '
        'txt_sef_sifre
        '
        Me.txt_sef_sifre.Enabled = False
        Me.txt_sef_sifre.Location = New System.Drawing.Point(88, 112)
        Me.txt_sef_sifre.Name = "txt_sef_sifre"
        Me.txt_sef_sifre.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_sef_sifre.Size = New System.Drawing.Size(64, 20)
        Me.txt_sef_sifre.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Þifre:"
        '
        'txt_sef_kodu
        '
        Me.txt_sef_kodu.Enabled = False
        Me.txt_sef_kodu.Location = New System.Drawing.Point(88, 90)
        Me.txt_sef_kodu.Name = "txt_sef_kodu"
        Me.txt_sef_kodu.Size = New System.Drawing.Size(232, 20)
        Me.txt_sef_kodu.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "YetkiliKodu:"
        '
        'btn_giris
        '
        Me.btn_giris.Enabled = False
        Me.btn_giris.Image = CType(resources.GetObject("btn_giris.Image"), System.Drawing.Image)
        Me.btn_giris.Location = New System.Drawing.Point(88, 198)
        Me.btn_giris.Name = "btn_giris"
        Me.btn_giris.Size = New System.Drawing.Size(80, 23)
        Me.btn_giris.TabIndex = 9
        Me.btn_giris.Text = "Kaydet"
        '
        'txt_personel_sifre
        '
        Me.txt_personel_sifre.Enabled = False
        Me.txt_personel_sifre.Location = New System.Drawing.Point(88, 68)
        Me.txt_personel_sifre.Name = "txt_personel_sifre"
        Me.txt_personel_sifre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_personel_sifre.Properties.Appearance.Options.UseFont = True
        Me.txt_personel_sifre.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_personel_sifre.Size = New System.Drawing.Size(64, 20)
        Me.txt_personel_sifre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Þifre:"
        '
        'txt_personel_kodu
        '
        Me.txt_personel_kodu.Location = New System.Drawing.Point(88, 46)
        Me.txt_personel_kodu.Name = "txt_personel_kodu"
        Me.txt_personel_kodu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_personel_kodu.Properties.Appearance.Options.UseFont = True
        Me.txt_personel_kodu.Properties.MaxLength = 7
        Me.txt_personel_kodu.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_personel_kodu.Size = New System.Drawing.Size(232, 20)
        Me.txt_personel_kodu.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PersonelKodu:"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl2.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl2.Controls.Add(Me.sec_vardiya)
        Me.GroupControl2.Controls.Add(Me.Label18)
        Me.GroupControl2.Controls.Add(Me.txt_baslama)
        Me.GroupControl2.Controls.Add(Me.Label17)
        Me.GroupControl2.Controls.Add(Me.Label10)
        Me.GroupControl2.Controls.Add(Me.txt_sure)
        Me.GroupControl2.Controls.Add(Me.SimpleButton4)
        Me.GroupControl2.Controls.Add(Me.sec_magaza)
        Me.GroupControl2.Controls.Add(Me.Label15)
        Me.GroupControl2.Controls.Add(Me.Label13)
        Me.GroupControl2.Controls.Add(Me.txt_yetkili)
        Me.GroupControl2.Controls.Add(Me.txt_yetkili_sifre)
        Me.GroupControl2.Controls.Add(Me.Label8)
        Me.GroupControl2.Controls.Add(Me.txt_yetkili_kod)
        Me.GroupControl2.Controls.Add(Me.Label9)
        Me.GroupControl2.Location = New System.Drawing.Point(16, 11)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(512, 118)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Maðaza Bilgileri"
        '
        'sec_vardiya
        '
        Me.sec_vardiya.EnterMoveNextControl = True
        Me.sec_vardiya.Location = New System.Drawing.Point(408, 24)
        Me.sec_vardiya.Name = "sec_vardiya"
        Me.sec_vardiya.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_vardiya.Properties.Appearance.Options.UseBackColor = True
        Me.sec_vardiya.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_vardiya.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IND", "No"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("GRUPADI", "Vardiya")})
        Me.sec_vardiya.Properties.DisplayMember = "GRUPADI"
        Me.sec_vardiya.Properties.NullText = ""
        Me.sec_vardiya.Properties.ValueMember = "IND"
        Me.sec_vardiya.Size = New System.Drawing.Size(72, 20)
        Me.sec_vardiya.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(352, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 13)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Vardiya:"
        '
        'txt_baslama
        '
        Me.txt_baslama.EditValue = New Date(2007, 3, 10, 8, 0, 0, 0)
        Me.txt_baslama.EnterMoveNextControl = True
        Me.txt_baslama.Location = New System.Drawing.Point(408, 46)
        Me.txt_baslama.Name = "txt_baslama"
        Me.txt_baslama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_baslama.Properties.Appearance.Options.UseBackColor = True
        Me.txt_baslama.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_baslama.Size = New System.Drawing.Size(72, 20)
        Me.txt_baslama.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(320, 44)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 13)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "BaþlamaSaati:"
        '
        'Label10
        '
        Me.Label10.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(480, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "dk."
        '
        'txt_sure
        '
        Me.txt_sure.EditValue = New Decimal(New Integer() {15, 0, 0, 0})
        Me.txt_sure.EnterMoveNextControl = True
        Me.txt_sure.Location = New System.Drawing.Point(408, 68)
        Me.txt_sure.Name = "txt_sure"
        Me.txt_sure.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sure.Properties.Appearance.Options.UseBackColor = True
        Me.txt_sure.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_sure.Properties.MaxLength = 2
        Me.txt_sure.Properties.MaxValue = New Decimal(New Integer() {3, 0, 0, 0})
        Me.txt_sure.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_sure.Size = New System.Drawing.Size(72, 20)
        Me.txt_sure.TabIndex = 6
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(344, 90)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(136, 24)
        Me.SimpleButton4.TabIndex = 7
        Me.SimpleButton4.Text = "&Baþla"
        '
        'sec_magaza
        '
        Me.sec_magaza.EditValue = "Merkez"
        Me.sec_magaza.EnterMoveNextControl = True
        Me.sec_magaza.Location = New System.Drawing.Point(88, 69)
        Me.sec_magaza.Name = "sec_magaza"
        Me.sec_magaza.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.sec_magaza.Properties.Appearance.Options.UseBackColor = True
        Me.sec_magaza.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_magaza.Properties.Items.AddRange(New Object() {"Merkez", "Þube1", "Þube2", "Þube3", "Þube4", "Þube5", "Þube6", "Þube7", "Þube6", "Þube9", "Þube10"})
        Me.sec_magaza.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_magaza.Size = New System.Drawing.Size(88, 20)
        Me.sec_magaza.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(40, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Maðaza:"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(328, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "ÝþlemSüresi:"
        '
        'txt_yetkili
        '
        Me.txt_yetkili.EditValue = ""
        Me.txt_yetkili.Enabled = False
        Me.txt_yetkili.EnterMoveNextControl = True
        Me.txt_yetkili.Location = New System.Drawing.Point(175, 44)
        Me.txt_yetkili.Name = "txt_yetkili"
        Me.txt_yetkili.Size = New System.Drawing.Size(137, 20)
        Me.txt_yetkili.TabIndex = 2
        '
        'txt_yetkili_sifre
        '
        Me.txt_yetkili_sifre.EditValue = ""
        Me.txt_yetkili_sifre.Location = New System.Drawing.Point(88, 25)
        Me.txt_yetkili_sifre.Name = "txt_yetkili_sifre"
        Me.txt_yetkili_sifre.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_yetkili_sifre.Size = New System.Drawing.Size(88, 20)
        Me.txt_yetkili_sifre.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(23, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Þifre:"
        '
        'txt_yetkili_kod
        '
        Me.txt_yetkili_kod.EditValue = ""
        Me.txt_yetkili_kod.EnterMoveNextControl = True
        Me.txt_yetkili_kod.Location = New System.Drawing.Point(88, 47)
        Me.txt_yetkili_kod.Name = "txt_yetkili_kod"
        Me.txt_yetkili_kod.Properties.ReadOnly = True
        Me.txt_yetkili_kod.Size = New System.Drawing.Size(88, 20)
        Me.txt_yetkili_kod.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(24, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "YetkiliKodu:"
        '
        'GroupControl3
        '
        Me.GroupControl3.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl3.AppearanceCaption.ForeColor = System.Drawing.Color.Navy
        Me.GroupControl3.AppearanceCaption.Options.UseFont = True
        Me.GroupControl3.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl3.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl3.Controls.Add(Me.grd_PersonelTakip)
        Me.GroupControl3.Location = New System.Drawing.Point(16, 357)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(512, 192)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "Giriþ/Çýkýþ Listesi"
        '
        'grd_PersonelTakip
        '
        Me.grd_PersonelTakip.DataMember = "Table1"
        Me.grd_PersonelTakip.DataSource = Me.Dataset1
        Me.grd_PersonelTakip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grd_PersonelTakip.Location = New System.Drawing.Point(2, 21)
        Me.grd_PersonelTakip.MainView = Me.GridView1
        Me.grd_PersonelTakip.Name = "grd_PersonelTakip"
        Me.grd_PersonelTakip.Size = New System.Drawing.Size(508, 169)
        Me.grd_PersonelTakip.TabIndex = 0
        Me.grd_PersonelTakip.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'Dataset1
        '
        Me.Dataset1.DataSetName = "NewDataSet"
        Me.Dataset1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.Dataset1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.TableName = "Table1"
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.colTARIH, Me.colBELGENO, Me.colGIRISSAAT, Me.colCIKISSAAT, Me.colSURE, Me.colMAGAZA, Me.colVARDIYA, Me.colIZAHAT, Me.colYETKILIKODU, Me.colYETKILI, Me.colPERSONELKODU, Me.colPERSONEL, Me.colSEFKODU, Me.colSEF, Me.colMAZERET, Me.colACIKLAMA, Me.colGIRIS, Me.colGECGIRIS, Me.colCIKIS, Me.colGECCIKIS, Me.colSTATUS})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(425, 419, 208, 156)
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.grd_PersonelTakip
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", Nothing, "{0:#,0.##}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colIND
        '
        Me.colIND.Caption = "Kayýt No"
        Me.colIND.FieldName = "IND"
        Me.colIND.Name = "colIND"
        '
        'colTARIH
        '
        Me.colTARIH.Caption = "Tarih"
        Me.colTARIH.FieldName = "TARIH"
        Me.colTARIH.Name = "colTARIH"
        Me.colTARIH.Visible = True
        Me.colTARIH.VisibleIndex = 0
        Me.colTARIH.Width = 39
        '
        'colBELGENO
        '
        Me.colBELGENO.Caption = "Belge No"
        Me.colBELGENO.FieldName = "BELGENO"
        Me.colBELGENO.Name = "colBELGENO"
        Me.colBELGENO.Width = 47
        '
        'colGIRISSAAT
        '
        Me.colGIRISSAAT.Caption = "Açýlýþ"
        Me.colGIRISSAAT.DisplayFormat.FormatString = "HH:mm"
        Me.colGIRISSAAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colGIRISSAAT.FieldName = "GIRISSAAT"
        Me.colGIRISSAAT.Name = "colGIRISSAAT"
        Me.colGIRISSAAT.Visible = True
        Me.colGIRISSAAT.VisibleIndex = 1
        Me.colGIRISSAAT.Width = 40
        '
        'colCIKISSAAT
        '
        Me.colCIKISSAAT.Caption = "Kapanýþ"
        Me.colCIKISSAAT.DisplayFormat.FormatString = "HH:mm"
        Me.colCIKISSAAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colCIKISSAAT.FieldName = "CIKISSAAT"
        Me.colCIKISSAAT.Name = "colCIKISSAAT"
        Me.colCIKISSAAT.Visible = True
        Me.colCIKISSAAT.VisibleIndex = 2
        Me.colCIKISSAAT.Width = 47
        '
        'colSURE
        '
        Me.colSURE.Caption = "Süre"
        Me.colSURE.FieldName = "SURE"
        Me.colSURE.Name = "colSURE"
        Me.colSURE.Width = 42
        '
        'colMAGAZA
        '
        Me.colMAGAZA.Caption = "Maðaza"
        Me.colMAGAZA.FieldName = "MAGAZA"
        Me.colMAGAZA.Name = "colMAGAZA"
        '
        'colVARDIYA
        '
        Me.colVARDIYA.Caption = "Vardiya"
        Me.colVARDIYA.FieldName = "VARDIYA"
        Me.colVARDIYA.Name = "colVARDIYA"
        '
        'colIZAHAT
        '
        Me.colIZAHAT.Caption = "Ýzahat"
        Me.colIZAHAT.FieldName = "IZAHAT"
        Me.colIZAHAT.Name = "colIZAHAT"
        Me.colIZAHAT.Visible = True
        Me.colIZAHAT.VisibleIndex = 3
        Me.colIZAHAT.Width = 42
        '
        'colYETKILIKODU
        '
        Me.colYETKILIKODU.Caption = "YetkiliKodu"
        Me.colYETKILIKODU.FieldName = "YETKILIKODU"
        Me.colYETKILIKODU.Name = "colYETKILIKODU"
        '
        'colYETKILI
        '
        Me.colYETKILI.Caption = "Yetkili"
        Me.colYETKILI.FieldName = "YETKILI"
        Me.colYETKILI.Name = "colYETKILI"
        Me.colYETKILI.Width = 42
        '
        'colPERSONELKODU
        '
        Me.colPERSONELKODU.Caption = "PersonelKodu"
        Me.colPERSONELKODU.FieldName = "PERSONELKODU"
        Me.colPERSONELKODU.Name = "colPERSONELKODU"
        '
        'colPERSONEL
        '
        Me.colPERSONEL.Caption = "Personel"
        Me.colPERSONEL.FieldName = "PERSONEL"
        Me.colPERSONEL.Name = "colPERSONEL"
        Me.colPERSONEL.Visible = True
        Me.colPERSONEL.VisibleIndex = 4
        Me.colPERSONEL.Width = 83
        '
        'colSEFKODU
        '
        Me.colSEFKODU.Caption = "SefKodu"
        Me.colSEFKODU.FieldName = "SEFKODU"
        Me.colSEFKODU.Name = "colSEFKODU"
        '
        'colSEF
        '
        Me.colSEF.Caption = "Sef"
        Me.colSEF.FieldName = "SEF"
        Me.colSEF.Name = "colSEF"
        '
        'colMAZERET
        '
        Me.colMAZERET.Caption = "Maazeret"
        Me.colMAZERET.FieldName = "MAZERET"
        Me.colMAZERET.Name = "colMAZERET"
        Me.colMAZERET.Width = 42
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.Caption = "Açýklama"
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 5
        Me.colACIKLAMA.Width = 85
        '
        'colGIRIS
        '
        Me.colGIRIS.Caption = "GiriþSaati"
        Me.colGIRIS.DisplayFormat.FormatString = "HH:mm"
        Me.colGIRIS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colGIRIS.FieldName = "GIRIS"
        Me.colGIRIS.Name = "colGIRIS"
        Me.colGIRIS.Visible = True
        Me.colGIRIS.VisibleIndex = 6
        Me.colGIRIS.Width = 48
        '
        'colGECGIRIS
        '
        Me.colGECGIRIS.Caption = "GeçGiriþ?"
        Me.colGECGIRIS.FieldName = "GECGIRIS"
        Me.colGECGIRIS.Name = "colGECGIRIS"
        Me.colGECGIRIS.Width = 42
        '
        'colCIKIS
        '
        Me.colCIKIS.Caption = "ÇýkýþSaati"
        Me.colCIKIS.DisplayFormat.FormatString = "HH:mm"
        Me.colCIKIS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colCIKIS.FieldName = "CIKIS"
        Me.colCIKIS.Name = "colCIKIS"
        Me.colCIKIS.Visible = True
        Me.colCIKIS.VisibleIndex = 7
        Me.colCIKIS.Width = 51
        '
        'colGECCIKIS
        '
        Me.colGECCIKIS.Caption = "GeçÇýkýþ?"
        Me.colGECCIKIS.FieldName = "GECCIKIS"
        Me.colGECCIKIS.Name = "colGECCIKIS"
        Me.colGECCIKIS.Width = 55
        '
        'colSTATUS
        '
        Me.colSTATUS.Caption = "Çýktý?"
        Me.colSTATUS.FieldName = "STATUS"
        Me.colSTATUS.Name = "colSTATUS"
        Me.colSTATUS.Visible = True
        Me.colSTATUS.VisibleIndex = 8
        Me.colSTATUS.Width = 69
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl4.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl4.Controls.Add(Me.sec_resim)
        Me.GroupControl4.Controls.Add(Me.Label3)
        Me.GroupControl4.Location = New System.Drawing.Point(352, 128)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(179, 226)
        Me.GroupControl4.TabIndex = 3
        Me.GroupControl4.Text = "Personel"
        '
        'sec_resim
        '
        Me.sec_resim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sec_resim.Location = New System.Drawing.Point(2, 34)
        Me.sec_resim.Name = "sec_resim"
        Me.sec_resim.Properties.NullText = "[Resim Bulunamadý]"
        Me.sec_resim.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.sec_resim.Size = New System.Drawing.Size(175, 190)
        Me.sec_resim.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(2, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "[Personel Adý]"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(374, 557)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 83)
        Me.SimpleButton1.TabIndex = 8
        Me.SimpleButton1.Text = "&Bitir"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(449, 557)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 83)
        Me.SimpleButton2.TabIndex = 9
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'Lbl_tarih
        '
        Me.Lbl_tarih.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Lbl_tarih.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lbl_tarih.Location = New System.Drawing.Point(24, 561)
        Me.Lbl_tarih.Name = "Lbl_tarih"
        Me.Lbl_tarih.Size = New System.Drawing.Size(16, 16)
        Me.Lbl_tarih.TabIndex = 6
        Me.Lbl_tarih.Text = "**"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.lbl_bitis)
        Me.GroupControl5.Controls.Add(Me.Label19)
        Me.GroupControl5.Controls.Add(Me.lbl_kalan)
        Me.GroupControl5.Controls.Add(Me.lbl_gecen)
        Me.GroupControl5.Controls.Add(Me.lbl_baslama)
        Me.GroupControl5.Controls.Add(Me.Label16)
        Me.GroupControl5.Controls.Add(Me.Label12)
        Me.GroupControl5.Controls.Add(Me.Label11)
        Me.GroupControl5.Location = New System.Drawing.Point(200, 558)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(168, 82)
        Me.GroupControl5.TabIndex = 7
        Me.GroupControl5.Text = "Ýþlemler"
        '
        'lbl_bitis
        '
        Me.lbl_bitis.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_bitis.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_bitis.Location = New System.Drawing.Point(80, 64)
        Me.lbl_bitis.Name = "lbl_bitis"
        Me.lbl_bitis.Size = New System.Drawing.Size(7, 13)
        Me.lbl_bitis.TabIndex = 20
        Me.lbl_bitis.Text = "*"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(8, 64)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(23, 13)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Bitiþ:"
        '
        'lbl_kalan
        '
        Me.lbl_kalan.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_kalan.Location = New System.Drawing.Point(80, 49)
        Me.lbl_kalan.Name = "lbl_kalan"
        Me.lbl_kalan.Size = New System.Drawing.Size(7, 13)
        Me.lbl_kalan.TabIndex = 18
        Me.lbl_kalan.Text = "*"
        '
        'lbl_gecen
        '
        Me.lbl_gecen.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_gecen.Location = New System.Drawing.Point(80, 36)
        Me.lbl_gecen.Name = "lbl_gecen"
        Me.lbl_gecen.Size = New System.Drawing.Size(7, 13)
        Me.lbl_gecen.TabIndex = 17
        Me.lbl_gecen.Text = "*"
        '
        'lbl_baslama
        '
        Me.lbl_baslama.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_baslama.Location = New System.Drawing.Point(80, 21)
        Me.lbl_baslama.Name = "lbl_baslama"
        Me.lbl_baslama.Size = New System.Drawing.Size(7, 13)
        Me.lbl_baslama.TabIndex = 16
        Me.lbl_baslama.Text = "*"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(13, 46)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "KalanSüre:"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(4, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "GeçenSüre:"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Baþlama:"
        '
        'frm_personel_takip
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(532, 650)
        Me.Controls.Add(Me.GroupControl5)
        Me.Controls.Add(Me.Lbl_tarih)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_personel_takip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personel Takip"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_izahat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sef.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_personel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_maazeret_aciklama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_maazeret.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sef_sifre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sef_kodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_personel_sifre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_personel_kodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.sec_vardiya.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_baslama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sure.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_magaza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_yetkili.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_yetkili_sifre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_yetkili_kod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.grd_PersonelTakip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dataset1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.sec_resim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
    Public status As Boolean = False
    Public connection
    Public firmano
    Public donemno
    Public stokno
    Public userno
    Public kullanici
    Dim ds_kasiyer As DataSet
    Dim ds_personel As DataSet
    Dim ds_kayit As DataSet
    Dim dr As DataRow
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Public kasiyerno
    Public kasiyer
    Public personelno
    Public personel
    Public sefno
    Public sef
    Public basla As Boolean = False
    Public baslamasaati As DateTime
    Public bitissaati As DateTime
    Public sure As Integer
    Public sayi
    Public belgeno
    Public giriscikis As Boolean = False
    Public RecID As Int64 = 0
    Public RecStatus As Int64 = 0
    Public islemstatus As Boolean = False
    Private Sub frm_personel_takip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload_kasiyer()
        dataload_personel()
        dataload_vardiya()
        txt_baslama.EditValue = Now
        txt_yetkili_sifre.Focus()
        txt_yetkili_sifre.Select()
        Timer1.Enabled = True
        Try
            belgeno = belgeno_kontrol(dataload_belgeno().ToString).ToString
            con.Close()
        Catch ex As Exception
            belgeno = "000001"
        End Try
    End Sub
    Private Sub dataload_kasiyer()
        ds_kasiyer = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sKasiyerRumuzu AS IND, sAdi + ' ' + sSoyadi AS KASIYER, sSifresi AS SIFRE, sDepo AS DEPO FROM         tbKasiyer WHERE     (sKasiyerRumuzu <> '')"))
    End Sub
    Private Sub dataload_personel()
        ds_personel = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     IND,PERSONELKODU,PERSONELADI,SIFRE,ONAY FROM APERSONEL WHERE AKTIF = 1 ORDER BY PERSONELKODU"))
    End Sub
    Private Sub dataload_vardiya()
        sec_vardiya.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM APERSONELVARDIYALIST ORDER BY IND ")).Tables(0)
        sec_vardiya.ItemIndex = 0
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        conn.Close()
        Return DS
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub yetki_kontrol()
        Dim yetki As Int64 = Sorgu_Yetki(kullanici, Me.Name)
        If yetki = 0 Then
            Me.Hide()
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm Yetkiniz Yok!" & vbCrLf & "Lütfen Sistem Yönecinizle Görüþün...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            status = True
            Me.Close()
        ElseIf yetki = 1 Then
        End If
    End Sub
    Private Function Sorgu_Yetki(ByVal kasiyerno As Int64, ByVal Form As String, Optional ByVal islem As Integer = 0, Optional ByVal bYetki As Integer = 0) As Int64
        Dim kriter
        kriter = " WHERE     (Personel.PersonelNo = " & kasiyerno & ") AND (Forms.Form = '" & Form & "') "
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitsayisi As Int64 = 0
        Dim formkayitsayisi As Int64 = 0
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS Kayit FROM         aEmirForms WHERE     (Form = '" & Form & "')")
        formkayitsayisi = cmd.ExecuteScalar
        If formkayitsayisi = 0 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO aEmirForms (Modul, Form, Aciklama, DefaultYetki) VALUES     ('Genel', '" & Form & "', '" & Form & "', " & bYetki & ")")
            cmd.ExecuteNonQuery()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(CAST(Personel.Yetki AS int), 0) AS Yetki FROM         aPersonelYetki Personel INNER JOIN                       aEmirForms Forms ON Personel.Form = Forms.Form  " & kriter & "")
        kayitsayisi = cmd.ExecuteScalar
        con.Close()
        If islem = 1 Then
            If kayitsayisi = 0 Then
                kayitsayisi = 1
            ElseIf kayitsayisi = 1 Then
                kayitsayisi = 0
            End If
        End If
        Return kayitsayisi
        'kayitsayisi = Nothing
        formkayitsayisi = Nothing
    End Function
    Private Function belgeno_kontrol(ByVal belgeno As String, Optional ByVal islem As Integer = 0) As String
        Dim seri
        Dim no
        Dim evrak_no
        evrak_no = belgeno
        evrak_no = evrak_no.Replace(0, "")
        evrak_no = evrak_no.Replace(1, "")
        evrak_no = evrak_no.Replace(2, "")
        evrak_no = evrak_no.Replace(3, "")
        evrak_no = evrak_no.Replace(4, "")
        evrak_no = evrak_no.Replace(5, "")
        evrak_no = evrak_no.Replace(6, "")
        evrak_no = evrak_no.Replace(7, "")
        evrak_no = evrak_no.Replace(8, "")
        evrak_no = evrak_no.Replace(9, "")
        'txtbelgeseri.EditValue = evrak_no
        seri = evrak_no
        If evrak_no = "" Then
            seri = ""
        End If
        evrak_no = belgeno
        evrak_no = evrak_no.Replace("A", "")
        evrak_no = evrak_no.Replace("B", "")
        evrak_no = evrak_no.Replace("C", "")
        evrak_no = evrak_no.Replace("Ç", "")
        evrak_no = evrak_no.Replace("D", "")
        evrak_no = evrak_no.Replace("E", "")
        evrak_no = evrak_no.Replace("F", "")
        evrak_no = evrak_no.Replace("G", "")
        evrak_no = evrak_no.Replace("H", "")
        evrak_no = evrak_no.Replace("I", "")
        evrak_no = evrak_no.Replace("Ý", "")
        evrak_no = evrak_no.Replace("J", "")
        evrak_no = evrak_no.Replace("K", "")
        evrak_no = evrak_no.Replace("L", "")
        evrak_no = evrak_no.Replace("M", "")
        evrak_no = evrak_no.Replace("N", "")
        evrak_no = evrak_no.Replace("O", "")
        evrak_no = evrak_no.Replace("Ö", "")
        evrak_no = evrak_no.Replace("P", "")
        evrak_no = evrak_no.Replace("R", "")
        evrak_no = evrak_no.Replace("S", "")
        evrak_no = evrak_no.Replace("Þ", "")
        evrak_no = evrak_no.Replace("T", "")
        evrak_no = evrak_no.Replace("U", "")
        evrak_no = evrak_no.Replace("Ü", "")
        evrak_no = evrak_no.Replace("V", "")
        evrak_no = evrak_no.Replace("Y", "")
        evrak_no = evrak_no.Replace("Z", "")
        evrak_no = evrak_no.Replace("X", "")
        evrak_no = evrak_no.Replace("W", "")
        evrak_no = evrak_no.Replace("_", "")
        evrak_no = evrak_no.Replace("-", "")
        evrak_no = evrak_no.Replace("*", "")
        evrak_no = evrak_no.Replace("/", "")
        evrak_no = evrak_no.Replace("+", "")
        Try
            If islem = 0 Then
                no = CType(evrak_no, Integer) + 1
            Else
                no = CType(evrak_no, Integer)
            End If
            no = columnuzunlukinteger_sifir(no.ToString, 6)
            belgeno = seri + no.ToString
        Catch ex As Exception
            belgeno = seri + columnuzunlukinteger_sifir(1, 6)
        End Try
        Return belgeno
    End Function
    Private Function dataload_belgeno() As String
        Dim sonuc
        Try
            con.ConnectionString = connection
            cmd.Connection = con
            con.Open()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SELECT ISNULL(BELGENO,'000001') AS BELGENO FROM APERSONELTAKIP WHERE IND = (SELECT ISNULL(MAX(BELGENO),0) FROM APERSONELTAKIP  WHERE  TARIH < '" & Today & "')")
            sonuc = cmd.ExecuteScalar
            con.Close()
            If CStr(sonuc).ToString = "" Then
                sonuc = "000000"
            End If
        Catch ex As Exception
            sonuc = "000000"
        End Try
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return sonuc
        sonuc = Nothing
    End Function
    Private Function columnuzunlukinteger_sifir(ByVal deger As String, ByVal uzunluk As Integer) As String
        Dim stringhedef = Trim(deger)
        Dim hedefuzunluk = Len(stringhedef)
        If Len(stringhedef) < uzunluk Then
            Dim fark = uzunluk - hedefuzunluk
            Dim i As Integer
            For i = 1 To fark
                stringhedef = stringhedef.Insert(0, "0")
            Next
            fark = Nothing
            i = Nothing
        Else
            stringhedef = Microsoft.VisualBasic.Left(stringhedef, uzunluk)
        End If
        Return stringhedef
    End Function
    Public Function sorgu_cari_kontrol(ByVal tarih As DateTime, ByVal belgeno As String, ByVal izahat As String, ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (PERSONELKODU = '" & kod & "') AND TARIH ='" & tarih & "' AND BELGENO = '" & belgeno & "' AND IZAHAT ='" & izahat & "' "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         APERSONELTAKIP " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_kayit_kontrol(ByVal tarih As DateTime, ByVal magaza As String, ByVal vardiya As String) As DataSet
        Dim kriter
        kriter = "WHERE  TARIH ='" & tarih & "' AND MAGAZA = '" & magaza & "' AND VARDIYA ='" & vardiya & "' "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'conn.ConnectionString = connection
        'cmd.Connection = conn
        'conn.Open()
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         APERSONELTAKIP " & kriter & "")
        'Dim kayitsayisi = cmd.ExecuteScalar
        'Return kayitsayisi
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         APERSONELTAKIP " & kriter & " ORDER BY IND DESC")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "APERSONELTAKIP")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_cari_kontrol_kayitno(ByVal tarih As DateTime, ByVal belgeno As String, ByVal izahat As String, ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (PERSONELKODU = '" & kod & "') AND TARIH ='" & tarih & "' AND BELGENO = '" & belgeno & "' AND IZAHAT ='" & izahat & "' "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(IND, 0) AS KAYIT  FROM         APERSONELTAKIP " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_cari_kontrol_kayitno_cikti(ByVal tarih As DateTime, ByVal belgeno As String, ByVal izahat As String, ByVal kod As String) As Boolean
        Dim kriter
        kriter = "WHERE (PERSONELKODU = '" & kod & "') AND TARIH ='" & tarih & "' AND BELGENO = '" & belgeno & "' AND IZAHAT ='" & izahat & "' "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(STATUS, 0) AS KAYIT  FROM         APERSONELTAKIP " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub kasiyer_kontrol()
        Dim sonuc As Boolean = False
        For Each dr In ds_kasiyer.Tables(0).Rows
            If dr("SIFRE") = txt_yetkili_sifre.Text Then
                kasiyerno = dr("IND")
                kasiyer = dr("KASIYER")
                sonuc = True
            End If
        Next
        If sonuc = True Then
            txt_yetkili_kod.Text = kasiyerno
            txt_yetkili.EditValue = kasiyer
            txt_yetkili_kod.Enabled = False
            txt_yetkili_sifre.Enabled = False
            grd_PersonelTakip.Enabled = True
            SimpleButton4.Enabled = True
            status = True
            txt_personel_kodu.Focus()
            txt_personel_kodu.SelectAll()
        ElseIf sonuc = False Then
            txt_yetkili.EditValue = ""
            txt_yetkili_sifre.Enabled = True
            txt_yetkili_sifre.EditValue = ""
            grd_PersonelTakip.Enabled = False
            txt_yetkili_sifre.Focus()
            txt_yetkili_sifre.SelectAll()
            status = False
            SimpleButton4.Enabled = False
            XtraMessageBox.Show(Sorgu_sDil("Þifre Hatalý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub personel_kod_kontrol()
        Dim sonuc As Boolean = False
        For Each dr In ds_personel.Tables(0).Rows
            If dr("PERSONELKODU") = "0" + txt_personel_kodu.Text Then
                personelno = dr("IND")
                personel = dr("PERSONELADI")
                sonuc = True
            End If
        Next
        If sonuc = True Then
            If sec_izahat.Text = "GünlükÝzin" Then
                btn_giris.Enabled = True
                SimpleButton5.Enabled = True
                btn_giris.Focus()
                btn_giris.Select()
            ElseIf sec_izahat.Text = "HaftalýkÝzin" Then
                btn_giris.Enabled = True
                SimpleButton5.Enabled = True
                btn_giris.Focus()
                btn_giris.Select()
            ElseIf sec_izahat.Text = "AylýkÝzin" Then
                btn_giris.Enabled = True
                SimpleButton5.Enabled = True
                btn_giris.Focus()
                btn_giris.Select()
            ElseIf sec_izahat.Text = "YýllýkÝzin" Then
                btn_giris.Enabled = True
                SimpleButton5.Enabled = True
                btn_giris.Focus()
                btn_giris.Select()
            Else
                txt_personel_sifre.Enabled = True
                txt_personel_sifre.Focus()
                txt_personel_sifre.Select()
            End If
            'txt_personel_sifre.Enabled = True
            'txt_personel_sifre.Focus()
            'txt_personel_sifre.Select()
            txt_personel.Text = personel
            txt_personel_kodu.Properties.ReadOnly = True
        ElseIf sonuc = False Then
            txt_personel_kodu.Focus()
            txt_personel_kodu.Select()
            btn_giris.Enabled = False
            SimpleButton5.Enabled = False
            status = False
            XtraMessageBox.Show(Sorgu_sDil("Personel Hatalý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub giriscikis_kontrol()
        If Trim(txt_personel_kodu.EditValue).ToString <> "" Then
            Dim kontrol = sorgu_cari_kontrol(Today, belgeno, sec_izahat.Text, txt_personel_kodu.EditValue)
            If kontrol = 0 Then
                'MsgBox(Sorgu_sDil("Kayýt Bulunumadý...",sDil),  MessageBoxIcon.Exclamation)
                giriscikis = False
            ElseIf kontrol = 1 Then
                giriscikis = True
                RecID = sorgu_cari_kontrol_kayitno(Today, belgeno, sec_izahat.Text, txt_personel_kodu.EditValue)
                RecStatus = sorgu_cari_kontrol_kayitno_cikti(Today, belgeno, sec_izahat.Text, txt_personel_kodu.EditValue)
                'MsgBox(RecStatus)
            End If
        End If
    End Sub
    Private Sub personel_sifre_kontrol()
        Dim sonuc As Boolean = False
        For Each dr In ds_personel.Tables(0).Rows
            If dr("PERSONELKODU") = "0" + txt_personel_kodu.Text Then
                If dr("SIFRE") = txt_personel_sifre.Text Then
                    sonuc = True
                End If
            End If
        Next
        If sonuc = True Then
            If sec_izahat.Text = "Ýzinli" Then
                txt_maazeret_aciklama.Focus()
                txt_maazeret_aciklama.Select()
            Else
                btn_giris.Focus()
                btn_giris.Select()
            End If
            txt_personel_sifre.Properties.ReadOnly = True
            btn_giris.Enabled = True
            SimpleButton5.Enabled = True
        ElseIf sonuc = False Then
            status = False
            XtraMessageBox.Show(Sorgu_sDil("Þifre Hatalý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_personel_sifre.Focus()
            txt_personel_sifre.SelectAll()
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub txt_yetkili_sifre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_yetkili_sifre.KeyDown
        If e.KeyCode = Keys.Enter Then
            kasiyer_kontrol()
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Lbl_tarih.Text = Now.ToLongDateString & vbCrLf & Now.ToLongTimeString
        If basla = True Then
            If sayi <= sure Then
                'bar.Position += 1
                sayi += 1
                'lbl_gecen.Text = CStr(sayi) + " sn"
                lbl_gecen.Text = CStr(DateDiff(DateInterval.Second, baslamasaati, Now)) + " sn"
                'lbl_kalan.Text = CStr((sure - sayi)) + " sn"
                If DateDiff(DateInterval.Second, Now, bitissaati) < 0 Then
                    lbl_kalan.Text = "Süre Bitti..."
                Else
                    lbl_kalan.Text = DateDiff(DateInterval.Second, Now, bitissaati)
                End If
                'sayi += 1
                'bar.Refresh()
            Else
                'Timer1.Enabled = False
                'kontrol_kaydet_degistir()
            End If
        End If
    End Sub
    Private Sub txt_personel_kodu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_personel_kodu.KeyDown
        If e.KeyCode = Keys.Enter Then
            personel_kod_kontrol()
        End If
    End Sub
    Private Sub txt_personel_sifre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_personel_sifre.KeyDown
        If e.KeyCode = Keys.Enter Then
            personel_sifre_kontrol()
        End If
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        ds_kayit = sorgu_kayit_kontrol(Today, sec_magaza.Text, sec_vardiya.EditValue)
        grd_PersonelTakip.DataSource = ds_kayit.Tables(0)
        grd_PersonelTakip.DataMember = Nothing
        If ds_kayit.Tables(0).Rows.Count > 0 Then
            For Each dr In ds_kayit.Tables(0).Rows
                belgeno = dr("BELGENO")
                sure = dr("SURE")
                Try
                    baslamasaati = dr("GIRISSAAT")
                Catch ex As Exception
                    baslamasaati = Now
                End Try
                'bitissaati = dr("CIKISSAAT")
                If islemstatus = True Then
                    Try
                        baslamasaati = dr("CIKISSAAT")
                    Catch ex As Exception
                        baslamasaati = Now
                    End Try
                End If
            Next
        Else
            sure = txt_sure.EditValue * 60
            baslamasaati = txt_baslama.EditValue
        End If
        baslamasaati = txt_baslama.EditValue
        bitissaati = DateAdd(DateInterval.Second, sure, baslamasaati)
        lbl_bitis.Text = bitissaati.ToLongTimeString
        'MsgBox(bitissaati)
        GroupControl2.Enabled = False
        GroupControl1.Enabled = True
        sure = txt_sure.EditValue * 60
        'lbl_baslama.Text = Now.ToLongTimeString
        'baslamasaati = Now
        lbl_baslama.Text = baslamasaati.ToLongTimeString
        basla = True
        'lbl_gecen.Text = Now.Hour - lbl_baslama.Text
        'lbl_kalan.Text = (Now.Hour + sure) - Now.Hour
        txt_personel_kodu.Focus()
        txt_personel_kodu.Select()
    End Sub
    Private Sub yeni()
        personelno = 0
        personel = ""
        txt_personel_kodu.Text = ""
        txt_personel_sifre.Text = ""
        txt_personel.Text = ""
        txt_personel_kodu.Properties.ReadOnly = False
        txt_personel_kodu.Enabled = True
        txt_personel_sifre.Properties.ReadOnly = False
        txt_personel_sifre.Enabled = False
        txt_personel.Properties.ReadOnly = False
        txt_personel.Enabled = False
        txt_sef_kodu.Text = ""
        txt_sef.Text = ""
        txt_sef_sifre.Text = ""
        sec_maazeret.ItemIndex = 0
        txt_maazeret_aciklama.Text = ""
        txt_personel_kodu.Focus()
        txt_personel_kodu.Select()
        btn_giris.Enabled = False
        SimpleButton5.Enabled = False
    End Sub
    Private Function ekle(ByVal TARIH As DateTime, ByVal BELGENO As String, ByVal SAAT As DateTime, ByVal SURE As Integer, ByVal MAGAZA As String, ByVal vardiya As Int64, ByVal IZAHAT As String, ByVal YETKILIKODU As String, ByVal YETKILI As String, ByVal PERSONELKODU As String, ByVal PERSONEL As String, ByVal SEFKODU As String, ByVal SEF As String, ByVal MAZERET As String, ByVal ACIKLAMA As String, ByVal GIRIS As DateTime, ByVal gecgiris As Integer, ByVal cikis As DateTime, ByVal GECCIKIS As Integer) As Int64
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitno As Int64
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO APERSONELTAKIP                       (TARIH, BELGENO, GIRISSAAT, SURE, MAGAZA, VARDIYA,IZAHAT, YETKILIKODU, YETKILI, PERSONELKODU, PERSONEL, SEFKODU, SEF, MAZERET, ACIKLAMA, GIRIS, GECGIRIS,STATUS) VALUES     ('" & TARIH & "', '" & BELGENO & "', '" & SAAT & "', " & SURE & ", '" & MAGAZA & "'," & vardiya & ", '" & IZAHAT & "', '" & YETKILIKODU & "', '" & YETKILI & "', '" & PERSONELKODU & "', '" & PERSONEL & "', '" & SEFKODU & "' , '" & SEF & "' , '" & MAZERET & "', '" & ACIKLAMA & "', '" & GIRIS & "', '" & gecgiris & "',0)")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Private Function ekle_cikis(ByVal TARIH As DateTime, ByVal BELGENO As String, ByVal SAAT As DateTime, ByVal SURE As Integer, ByVal MAGAZA As String, ByVal vardiya As Int64, ByVal IZAHAT As String, ByVal YETKILIKODU As String, ByVal YETKILI As String, ByVal PERSONELKODU As String, ByVal PERSONEL As String, ByVal SEFKODU As String, ByVal SEF As String, ByVal MAZERET As String, ByVal ACIKLAMA As String, ByVal GIRIS As DateTime, ByVal gecgiris As Integer, ByVal cikis As DateTime, ByVal GECCIKIS As Integer) As Int64
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitno As Int64
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO APERSONELTAKIP                       (TARIH, BELGENO, CIKISSAAT, SURE, MAGAZA, VARDIYA,IZAHAT, YETKILIKODU, YETKILI, PERSONELKODU, PERSONEL, SEFKODU, SEF, MAZERET, ACIKLAMA, CIKIS, GECCIKIS,STATUS) VALUES     ('" & TARIH & "', '" & BELGENO & "', '" & SAAT & "', " & SURE & ", '" & MAGAZA & "'," & vardiya & ", '" & IZAHAT & "', '" & YETKILIKODU & "', '" & YETKILI & "', '" & PERSONELKODU & "', '" & PERSONEL & "', '" & SEFKODU & "' , '" & SEF & "' , '" & MAZERET & "', '" & ACIKLAMA & "', '" & GIRIS & "', '" & gecgiris & "',1)")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Private Sub duzelt(ByVal IND As Int64, ByVal TARIH As DateTime, ByVal BELGENO As String, ByVal SAAT As DateTime, ByVal SURE As Integer, ByVal MAGAZA As String, ByVal IZAHAT As String, ByVal YETKILIKODU As String, ByVal YETKILI As String, ByVal PERSONELKODU As String, ByVal PERSONEL As String, ByVal SEFKODU As String, ByVal SEF As String, ByVal MAZERET As String, ByVal ACIKLAMA As String, ByVal GIRIS As DateTime, ByVal gecgiris As Integer, ByVal cikis As DateTime, ByVal GECCIKIS As Integer)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    APERSONELTAKIP SET              TARIH = TARIH, BELGENO = BELGENO, SAAT = SAAT, SURE = SURE, MAGAZA = MAGAZA, IZAHAT = IZAHAT, YETKILIKODU = YETKILIKODU, YETKILI = YETKILI, PERSONELKODU = PERSONELKODU, PERSONEL = PERSONEL, SEFKODU = SEFKODU, SEF = SEF, MAZERET = MAZERET, ACIKLAMA = ACIKLAMA, GIRIS = GIRIS, GECGIRIS = GECGIRIS, CIKIS = CIKIS, GECCIKIS = GECCIKIS WHERE IND =" & IND & "")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    APERSONELTAKIP SET               CIKISSAAT = '" & SAAT & "', GECCIKIS = " & GECCIKIS & ",CIKIS = '" & cikis & "', STATUS=1 WHERE IND =" & IND & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub duzelt_sifre(ByVal IND As Int64, ByVal personelkodu As String, ByVal personel As String, ByVal sifre As String, ByVal onay As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    APERSONEL SET              SIFRE ='" & sifre & "', ONAY ='" & onay & "' WHERE IND =" & IND & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub duzelt_giris(ByVal IND As Int64, ByVal TARIH As DateTime, ByVal BELGENO As String, ByVal SAAT As DateTime, ByVal SURE As Integer, ByVal MAGAZA As String, ByVal IZAHAT As String, ByVal YETKILIKODU As String, ByVal YETKILI As String, ByVal PERSONELKODU As String, ByVal PERSONEL As String, ByVal SEFKODU As String, ByVal SEF As String, ByVal MAZERET As String, ByVal ACIKLAMA As String, ByVal GIRIS As DateTime, ByVal gecgiris As Integer, ByVal cikis As DateTime, ByVal GECCIKIS As Integer)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    APERSONELTAKIP SET              TARIH = TARIH, BELGENO = BELGENO, SAAT = SAAT, SURE = SURE, MAGAZA = MAGAZA, IZAHAT = IZAHAT, YETKILIKODU = YETKILIKODU, YETKILI = YETKILI, PERSONELKODU = PERSONELKODU, PERSONEL = PERSONEL, SEFKODU = SEFKODU, SEF = SEF, MAZERET = MAZERET, ACIKLAMA = ACIKLAMA, GIRIS = GIRIS, GECGIRIS = GECGIRIS, CIKIS = CIKIS, GECCIKIS = GECCIKIS WHERE IND =" & IND & "")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    APERSONELTAKIP SET               GIRISSAAT = '" & SAAT & "', GECGIRIS = " & gecgiris & ",GIRIS = '" & GIRIS & "', STATUS=0 WHERE IND =" & IND & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub kaydet()
        Dim gecgiris = 0
        Dim geccikis = 0
        If DateDiff(DateInterval.Second, Now, bitissaati) < 0 Then
            gecgiris = 1
            gecgiris = 1
        End If
        If giriscikis = False Then
            ekle(Today, belgeno, baslamasaati, sure, sec_magaza.Text, sec_vardiya.EditValue, sec_izahat.Text, txt_yetkili_kod.Text, txt_yetkili.Text, txt_personel_kodu.Text, txt_personel.Text, txt_sef_kodu.Text, txt_sef.Text, sec_maazeret.EditValue, txt_maazeret_aciklama.Text, Now, gecgiris, Now, geccikis)
            XtraMessageBox.Show(Sorgu_sDil("Sayýn : " & txt_personel.Text & vbCrLf & "Giriþ Ýþleminiz Tamamlandý..", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            If sec_izahat.Text = "Ýzinli" Then
                duzelt_giris(RecID, Today, belgeno, baslamasaati, sure, sec_magaza.Text, sec_izahat.Text, txt_yetkili_kod.Text, txt_yetkili.Text, txt_personel_kodu.Text, txt_personel.Text, txt_sef_kodu.Text, txt_sef.Text, sec_maazeret.EditValue, txt_maazeret_aciklama.Text, Now, gecgiris, Now, geccikis)
            Else
            End If
        ElseIf giriscikis = True Then
            duzelt(RecID, Today, belgeno, baslamasaati, sure, sec_magaza.Text, sec_izahat.Text, txt_yetkili_kod.Text, txt_yetkili.Text, txt_personel_kodu.Text, txt_personel.Text, txt_sef_kodu.Text, txt_sef.Text, sec_maazeret.EditValue, txt_maazeret_aciklama.Text, Now, gecgiris, Now, geccikis)
            XtraMessageBox.Show(Sorgu_sDil("Sayýn : " & txt_personel.Text & vbCrLf & "Çýkýþ Ýþleminiz Tamamlandý..", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'ekle(Today, belgeno, baslamasaati, sure, sec_magaza.Text, sec_izahat.Text, txt_yetkili_kod.Text, txt_yetkili.Text, txt_personel_kodu.Text, txt_personel.Text, txt_sef_kodu.Text, txt_sef.Text, sec_maazeret.EditValue, txt_maazeret_aciklama.Text, Now, 0, Now, 0)
        'MsgBox(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        yeni()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        yeni()
    End Sub
    Private Sub btn_giris_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_giris.Click
        giriscikis_kontrol()
        If islemstatus = False Then
            If giriscikis = True Then
                'MsgBox(Sorgu_sDil("Sayýn : " & txt_personel.Text & vbCrLf & "Giriþ Kaydýnýz Daha Önce Yapýlmýþ, Lütfen Bilgilerinizi Kontrol Ediniz...",sDil),  MessageBoxIcon.Exclamation)
                'yeni()
                If sec_izahat.Text = "Ýzinli" Then
                    duzelt_giris(RecID, Today, belgeno, baslamasaati, sure, sec_magaza.Text, sec_izahat.Text, txt_yetkili_kod.Text, txt_yetkili.Text, txt_personel_kodu.Text, txt_personel.Text, txt_sef_kodu.Text, txt_sef.Text, sec_maazeret.EditValue, txt_maazeret_aciklama.Text, Now, 0, Now, 0)
                    yeni()
                Else
                    XtraMessageBox.Show(Sorgu_sDil("Sayýn : " & txt_personel.Text & vbCrLf & "Giriþ Kaydýnýz Daha Önce Yapýlmýþ, Lütfen Bilgilerinizi Kontrol Ediniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    yeni()
                End If
            Else
                kaydet()
            End If
        ElseIf islemstatus = True Then
            If giriscikis = False Then
                If sec_izahat.Text = "Ýzinli" Then
                    'MsgBox(Sorgu_sDil("Sayýn : " & txt_personel.Text & vbCrLf & "Giriþ Kaydýnýz Bulunmamaktadýr, Lütfen Bilgilerinizi Kontrol Ediniz...",sDil),  MessageBoxIcon.Exclamation)
                    ekle_cikis(Today, belgeno, baslamasaati, sure, sec_magaza.Text, sec_vardiya.EditValue, sec_izahat.Text, txt_yetkili_kod.Text, txt_yetkili.Text, txt_personel_kodu.Text, txt_personel.Text, txt_sef_kodu.Text, txt_sef.Text, sec_maazeret.EditValue, txt_maazeret_aciklama.Text, Now, 0, Now, 0)
                    yeni()
                Else
                    XtraMessageBox.Show(Sorgu_sDil("Sayýn : " & txt_personel.Text & vbCrLf & "Giriþ Kaydýnýz Bulunmamaktadýr, Lütfen Bilgilerinizi Kontrol Ediniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    ekle_cikis(Today, belgeno, baslamasaati, sure, sec_magaza.Text, sec_vardiya.EditValue, sec_izahat.Text, txt_yetkili_kod.Text, txt_yetkili.Text, txt_personel_kodu.Text, txt_personel.Text, txt_sef_kodu.Text, txt_sef.Text, sec_maazeret.EditValue, txt_maazeret_aciklama.Text, Now, 0, Now, 0)
                    yeni()
                End If
            Else
                If RecStatus = 0 Then
                    kaydet()
                ElseIf RecStatus = -1 Then
                    XtraMessageBox.Show(Sorgu_sDil("Sayýn : " & txt_personel.Text & vbCrLf & "Çýkýþ Kaydýnýz Daha Önce Yapýlmýþ, Lütfen Bilgilerinizi Kontrol Ediniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    yeni()
                End If
            End If
        End If
        'kaydet()
        grd_PersonelTakip.DataSource = sorgu_kayit_kontrol(Today, sec_magaza.Text, sec_vardiya.EditValue).Tables(0)
        grd_PersonelTakip.DataMember = Nothing
    End Sub
    Private Sub sec_izahat_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_izahat.SelectedIndexChanged
        If sec_izahat.Text = "Ýzinli" Then
            If islemstatus = True Then
                txt_maazeret_aciklama.Enabled = True
            End If
        Else
            txt_maazeret_aciklama.Enabled = False
        End If
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        If personelno <> 0 And btn_giris.Enabled = True Then
            Dim frm As New frm_personel_sifre_degistir
            frm.txt_personel_kodu.Text = txt_personel_kodu.Text
            frm.txt_personel.Text = personel
            'frm.kullanici = kullanici
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Try
                    duzelt_sifre(personelno, txt_personel_kodu.Text, personel, Trim(frm.txt_sifre.Text), Trim(frm.txt_onay.Text))
                    XtraMessageBox.Show(Sorgu_sDil("Yeni Þifreniz Bir sonraki Oturumda Geçerli Olacaktýr...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    XtraMessageBox.Show(Sorgu_sDil("Hata Oluþtu Tekrar Deneyiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                'MsgBox(Sorgu_sDil("Yeni Þifreniz: " & frm.txt_sifre.Text, MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
                'MsgBox(Sorgu_sDil("Kontrol Edildi")
            End If
        End If
    End Sub
End Class
