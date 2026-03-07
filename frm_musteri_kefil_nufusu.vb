Public Class frm_musteri_kefil_nufusu
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
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl92 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_musteriNo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl12 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txt_sSigortaNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl51 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sAileIl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl49 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sAilePostaKodu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl48 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sAileSemt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl47 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sAileAdresi2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sAileAdresi1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl46 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sCuzdanKayitNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sCuzdanVerNedeni As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sCuzdanVerilenYer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteNufusCuzdanTarihi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sKutukSiraNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sKutukCiltNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sKutukMahalle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sKutukIlce As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sKutukIl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sAnneAdi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sBabaAdi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ds_tbKefilNufusu As System.Data.DataSet
    Friend WithEvents DataTable8 As System.Data.DataTable
    Friend WithEvents DataColumn102 As System.Data.DataColumn
    Friend WithEvents DataColumn103 As System.Data.DataColumn
    Friend WithEvents DataColumn104 As System.Data.DataColumn
    Friend WithEvents DataColumn105 As System.Data.DataColumn
    Friend WithEvents DataColumn106 As System.Data.DataColumn
    Friend WithEvents DataColumn107 As System.Data.DataColumn
    Friend WithEvents DataColumn108 As System.Data.DataColumn
    Friend WithEvents DataColumn109 As System.Data.DataColumn
    Friend WithEvents DataColumn110 As System.Data.DataColumn
    Friend WithEvents DataColumn111 As System.Data.DataColumn
    Friend WithEvents DataColumn112 As System.Data.DataColumn
    Friend WithEvents DataColumn113 As System.Data.DataColumn
    Friend WithEvents DataColumn114 As System.Data.DataColumn
    Friend WithEvents DataColumn115 As System.Data.DataColumn
    Friend WithEvents DataColumn116 As System.Data.DataColumn
    Friend WithEvents DataColumn117 As System.Data.DataColumn
    Friend WithEvents DataColumn118 As System.Data.DataColumn
    Friend WithEvents DataColumn119 As System.Data.DataColumn
    Friend WithEvents DataColumn120 As System.Data.DataColumn
    Friend WithEvents DataColumn121 As System.Data.DataColumn
    Friend WithEvents DataColumn122 As System.Data.DataColumn
    Friend WithEvents txt_sHitap2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_sHitap1 As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_musteri_kefil_nufusu))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl92 = New DevExpress.XtraEditors.LabelControl
        Me.txt_musteriNo = New DevExpress.XtraEditors.ButtonEdit
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl12 = New DevExpress.XtraEditors.PanelControl
        Me.txt_sHitap2 = New DevExpress.XtraEditors.LookUpEdit
        Me.ds_tbKefilNufusu = New System.Data.DataSet
        Me.DataTable8 = New System.Data.DataTable
        Me.DataColumn102 = New System.Data.DataColumn
        Me.DataColumn103 = New System.Data.DataColumn
        Me.DataColumn104 = New System.Data.DataColumn
        Me.DataColumn105 = New System.Data.DataColumn
        Me.DataColumn106 = New System.Data.DataColumn
        Me.DataColumn107 = New System.Data.DataColumn
        Me.DataColumn108 = New System.Data.DataColumn
        Me.DataColumn109 = New System.Data.DataColumn
        Me.DataColumn110 = New System.Data.DataColumn
        Me.DataColumn111 = New System.Data.DataColumn
        Me.DataColumn112 = New System.Data.DataColumn
        Me.DataColumn113 = New System.Data.DataColumn
        Me.DataColumn114 = New System.Data.DataColumn
        Me.DataColumn115 = New System.Data.DataColumn
        Me.DataColumn116 = New System.Data.DataColumn
        Me.DataColumn117 = New System.Data.DataColumn
        Me.DataColumn118 = New System.Data.DataColumn
        Me.DataColumn119 = New System.Data.DataColumn
        Me.DataColumn120 = New System.Data.DataColumn
        Me.DataColumn121 = New System.Data.DataColumn
        Me.DataColumn122 = New System.Data.DataColumn
        Me.txt_sHitap1 = New DevExpress.XtraEditors.LookUpEdit
        Me.txt_sSigortaNo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl51 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sAileIl = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl49 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sAilePostaKodu = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl48 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sAileSemt = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl47 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sAileAdresi2 = New DevExpress.XtraEditors.TextEdit
        Me.txt_sAileAdresi1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl46 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sCuzdanKayitNo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sCuzdanVerNedeni = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sCuzdanVerilenYer = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl
        Me.txt_dteNufusCuzdanTarihi = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sKutukSiraNo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sKutukCiltNo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sKutukMahalle = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sKutukIlce = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sKutukIl = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sAnneAdi = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sBabaAdi = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GroupControl12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl12.SuspendLayout()
        CType(Me.txt_sHitap2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbKefilNufusu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sHitap1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sSigortaNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAileIl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAilePostaKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAileSemt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAileAdresi2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAileAdresi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sCuzdanKayitNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sCuzdanVerNedeni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sCuzdanVerilenYer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteNufusCuzdanTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteNufusCuzdanTarihi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sKutukSiraNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sKutukCiltNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sKutukMahalle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sKutukIlce.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sKutukIl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAnneAdi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sBabaAdi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 56)
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Müþteri Kefili Nüfus Bilgisi Tanýmlarý Aþaðýdadýr..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl92)
        Me.PanelControl2.Controls.Add(Me.txt_musteriNo)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 381)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'LabelControl92
        '
        Me.LabelControl92.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl92.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl92.Location = New System.Drawing.Point(11, 13)
        Me.LabelControl92.Name = "LabelControl92"
        Me.LabelControl92.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl92.TabIndex = 64
        Me.LabelControl92.Text = "MüþterNo:"
        '
        'txt_musteriNo
        '
        Me.txt_musteriNo.Enabled = False
        Me.txt_musteriNo.Location = New System.Drawing.Point(90, 12)
        Me.txt_musteriNo.Name = "txt_musteriNo"
        Me.txt_musteriNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_musteriNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_musteriNo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_musteriNo.Properties.Appearance.Options.UseForeColor = True
        Me.txt_musteriNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_musteriNo.Size = New System.Drawing.Size(100, 20)
        Me.txt_musteriNo.TabIndex = 63
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(733, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 62
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(658, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 61
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 325)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 321)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GroupControl12)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(814, 293)
        Me.XtraTabPage1.Text = "Kimlik..."
        '
        'GroupControl12
        '
        Me.GroupControl12.Controls.Add(Me.txt_sHitap2)
        Me.GroupControl12.Controls.Add(Me.txt_sHitap1)
        Me.GroupControl12.Controls.Add(Me.txt_sSigortaNo)
        Me.GroupControl12.Controls.Add(Me.LabelControl51)
        Me.GroupControl12.Controls.Add(Me.txt_sAileIl)
        Me.GroupControl12.Controls.Add(Me.LabelControl49)
        Me.GroupControl12.Controls.Add(Me.txt_sAilePostaKodu)
        Me.GroupControl12.Controls.Add(Me.LabelControl48)
        Me.GroupControl12.Controls.Add(Me.txt_sAileSemt)
        Me.GroupControl12.Controls.Add(Me.LabelControl47)
        Me.GroupControl12.Controls.Add(Me.txt_sAileAdresi2)
        Me.GroupControl12.Controls.Add(Me.txt_sAileAdresi1)
        Me.GroupControl12.Controls.Add(Me.LabelControl46)
        Me.GroupControl12.Controls.Add(Me.txt_sCuzdanKayitNo)
        Me.GroupControl12.Controls.Add(Me.LabelControl45)
        Me.GroupControl12.Controls.Add(Me.txt_sCuzdanVerNedeni)
        Me.GroupControl12.Controls.Add(Me.LabelControl44)
        Me.GroupControl12.Controls.Add(Me.txt_sCuzdanVerilenYer)
        Me.GroupControl12.Controls.Add(Me.LabelControl43)
        Me.GroupControl12.Controls.Add(Me.txt_dteNufusCuzdanTarihi)
        Me.GroupControl12.Controls.Add(Me.LabelControl42)
        Me.GroupControl12.Controls.Add(Me.txt_sKutukSiraNo)
        Me.GroupControl12.Controls.Add(Me.LabelControl41)
        Me.GroupControl12.Controls.Add(Me.txt_sKutukCiltNo)
        Me.GroupControl12.Controls.Add(Me.LabelControl40)
        Me.GroupControl12.Controls.Add(Me.txt_sKutukMahalle)
        Me.GroupControl12.Controls.Add(Me.LabelControl39)
        Me.GroupControl12.Controls.Add(Me.txt_sKutukIlce)
        Me.GroupControl12.Controls.Add(Me.LabelControl38)
        Me.GroupControl12.Controls.Add(Me.txt_sKutukIl)
        Me.GroupControl12.Controls.Add(Me.LabelControl37)
        Me.GroupControl12.Controls.Add(Me.txt_sAnneAdi)
        Me.GroupControl12.Controls.Add(Me.LabelControl35)
        Me.GroupControl12.Controls.Add(Me.LabelControl36)
        Me.GroupControl12.Controls.Add(Me.txt_sBabaAdi)
        Me.GroupControl12.Controls.Add(Me.LabelControl34)
        Me.GroupControl12.Controls.Add(Me.LabelControl33)
        Me.GroupControl12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl12.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl12.Name = "GroupControl12"
        Me.GroupControl12.Size = New System.Drawing.Size(814, 293)
        Me.GroupControl12.TabIndex = 67
        '
        'txt_sHitap2
        '
        Me.txt_sHitap2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbKefilNufusu, "Table1.sHitapAnne", True))
        Me.txt_sHitap2.EnterMoveNextControl = True
        Me.txt_sHitap2.Location = New System.Drawing.Point(76, 60)
        Me.txt_sHitap2.Name = "txt_sHitap2"
        Me.txt_sHitap2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sHitap2.Properties.Appearance.Options.UseBackColor = True
        Me.txt_sHitap2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sHitap2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sHitap2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sHitap2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sHitap2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sHitap2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sHitap2.Properties.DisplayMember = "sHitap"
        Me.txt_sHitap2.Properties.NullText = "[Hitap]"
        Me.txt_sHitap2.Properties.ValueMember = "sHitap"
        Me.txt_sHitap2.Size = New System.Drawing.Size(100, 20)
        Me.txt_sHitap2.TabIndex = 64
        '
        'ds_tbKefilNufusu
        '
        Me.ds_tbKefilNufusu.DataSetName = "NewDataSet"
        Me.ds_tbKefilNufusu.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbKefilNufusu.Tables.AddRange(New System.Data.DataTable() {Me.DataTable8})
        '
        'DataTable8
        '
        Me.DataTable8.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn102, Me.DataColumn103, Me.DataColumn104, Me.DataColumn105, Me.DataColumn106, Me.DataColumn107, Me.DataColumn108, Me.DataColumn109, Me.DataColumn110, Me.DataColumn111, Me.DataColumn112, Me.DataColumn113, Me.DataColumn114, Me.DataColumn115, Me.DataColumn116, Me.DataColumn117, Me.DataColumn118, Me.DataColumn119, Me.DataColumn120, Me.DataColumn121, Me.DataColumn122})
        Me.DataTable8.TableName = "Table1"
        '
        'DataColumn102
        '
        Me.DataColumn102.ColumnName = "nMusteriID"
        Me.DataColumn102.DataType = GetType(Long)
        '
        'DataColumn103
        '
        Me.DataColumn103.ColumnName = "sDin"
        '
        'DataColumn104
        '
        Me.DataColumn104.ColumnName = "sKutukIl"
        '
        'DataColumn105
        '
        Me.DataColumn105.ColumnName = "sKutukIlce"
        '
        'DataColumn106
        '
        Me.DataColumn106.ColumnName = "sKutukMahalle"
        '
        'DataColumn107
        '
        Me.DataColumn107.ColumnName = "sKutukCiltNo"
        '
        'DataColumn108
        '
        Me.DataColumn108.ColumnName = "sKutukSiraNo"
        '
        'DataColumn109
        '
        Me.DataColumn109.ColumnName = "dteNufusCuzdanTarihi"
        Me.DataColumn109.DataType = GetType(Date)
        '
        'DataColumn110
        '
        Me.DataColumn110.ColumnName = "sCuzdanVerilenYer"
        '
        'DataColumn111
        '
        Me.DataColumn111.ColumnName = "sCuzdanVerNedeni"
        '
        'DataColumn112
        '
        Me.DataColumn112.ColumnName = "sCuzdanKayitNo"
        '
        'DataColumn113
        '
        Me.DataColumn113.ColumnName = "sAnneAdi"
        '
        'DataColumn114
        '
        Me.DataColumn114.ColumnName = "sBabaAdi"
        '
        'DataColumn115
        '
        Me.DataColumn115.ColumnName = "sAileAdresi1"
        '
        'DataColumn116
        '
        Me.DataColumn116.ColumnName = "sAileAdresi2"
        '
        'DataColumn117
        '
        Me.DataColumn117.ColumnName = "sAileSemt"
        '
        'DataColumn118
        '
        Me.DataColumn118.ColumnName = "sAilePostaKodu"
        '
        'DataColumn119
        '
        Me.DataColumn119.ColumnName = "sAileIl"
        '
        'DataColumn120
        '
        Me.DataColumn120.ColumnName = "sAileTelefonu"
        '
        'DataColumn121
        '
        Me.DataColumn121.ColumnName = "sHitapAnne"
        '
        'DataColumn122
        '
        Me.DataColumn122.ColumnName = "sHitapBaba"
        '
        'txt_sHitap1
        '
        Me.txt_sHitap1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbKefilNufusu, "Table1.sHitapBaba", True))
        Me.txt_sHitap1.EnterMoveNextControl = True
        Me.txt_sHitap1.Location = New System.Drawing.Point(76, 20)
        Me.txt_sHitap1.Name = "txt_sHitap1"
        Me.txt_sHitap1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sHitap1.Properties.Appearance.Options.UseBackColor = True
        Me.txt_sHitap1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sHitap1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sHitap1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sHitap1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sHitap1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sHitap1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sHitap1.Properties.DisplayMember = "sHitap"
        Me.txt_sHitap1.Properties.NullText = "[Hitap]"
        Me.txt_sHitap1.Properties.ValueMember = "sHitap"
        Me.txt_sHitap1.Size = New System.Drawing.Size(100, 20)
        Me.txt_sHitap1.TabIndex = 62
        '
        'txt_sSigortaNo
        '
        Me.txt_sSigortaNo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbKefilNufusu, "Table1.sAileTelefonu", True))
        Me.txt_sSigortaNo.EnterMoveNextControl = True
        Me.txt_sSigortaNo.Location = New System.Drawing.Point(563, 180)
        Me.txt_sSigortaNo.Name = "txt_sSigortaNo"
        Me.txt_sSigortaNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sSigortaNo.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sSigortaNo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sSigortaNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sSigortaNo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sSigortaNo.Properties.MaxLength = 60
        Me.txt_sSigortaNo.Size = New System.Drawing.Size(224, 20)
        Me.txt_sSigortaNo.TabIndex = 82
        '
        'LabelControl51
        '
        Me.LabelControl51.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl51.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl51.Location = New System.Drawing.Point(491, 180)
        Me.LabelControl51.Name = "LabelControl51"
        Me.LabelControl51.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl51.TabIndex = 100
        Me.LabelControl51.Text = "GsmNo:"
        '
        'txt_sAileIl
        '
        Me.txt_sAileIl.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbKefilNufusu, "Table1.sAileIl", True))
        Me.txt_sAileIl.EnterMoveNextControl = True
        Me.txt_sAileIl.Location = New System.Drawing.Point(563, 160)
        Me.txt_sAileIl.Name = "txt_sAileIl"
        Me.txt_sAileIl.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAileIl.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAileIl.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAileIl.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAileIl.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAileIl.Properties.MaxLength = 20
        Me.txt_sAileIl.Size = New System.Drawing.Size(224, 20)
        Me.txt_sAileIl.TabIndex = 80
        '
        'LabelControl49
        '
        Me.LabelControl49.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl49.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl49.Location = New System.Drawing.Point(491, 160)
        Me.LabelControl49.Name = "LabelControl49"
        Me.LabelControl49.Size = New System.Drawing.Size(10, 13)
        Me.LabelControl49.TabIndex = 98
        Me.LabelControl49.Text = "Ýl:"
        '
        'txt_sAilePostaKodu
        '
        Me.txt_sAilePostaKodu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbKefilNufusu, "Table1.sAilePostaKodu", True))
        Me.txt_sAilePostaKodu.EnterMoveNextControl = True
        Me.txt_sAilePostaKodu.Location = New System.Drawing.Point(563, 140)
        Me.txt_sAilePostaKodu.Name = "txt_sAilePostaKodu"
        Me.txt_sAilePostaKodu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAilePostaKodu.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAilePostaKodu.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAilePostaKodu.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAilePostaKodu.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAilePostaKodu.Size = New System.Drawing.Size(80, 20)
        Me.txt_sAilePostaKodu.TabIndex = 79
        '
        'LabelControl48
        '
        Me.LabelControl48.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl48.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl48.Location = New System.Drawing.Point(491, 140)
        Me.LabelControl48.Name = "LabelControl48"
        Me.LabelControl48.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl48.TabIndex = 97
        Me.LabelControl48.Text = "PostaKodu:"
        '
        'txt_sAileSemt
        '
        Me.txt_sAileSemt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbKefilNufusu, "Table1.sAileSemt", True))
        Me.txt_sAileSemt.EnterMoveNextControl = True
        Me.txt_sAileSemt.Location = New System.Drawing.Point(563, 120)
        Me.txt_sAileSemt.Name = "txt_sAileSemt"
        Me.txt_sAileSemt.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAileSemt.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAileSemt.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAileSemt.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAileSemt.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAileSemt.Properties.MaxLength = 60
        Me.txt_sAileSemt.Size = New System.Drawing.Size(224, 20)
        Me.txt_sAileSemt.TabIndex = 78
        '
        'LabelControl47
        '
        Me.LabelControl47.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl47.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl47.Location = New System.Drawing.Point(491, 120)
        Me.LabelControl47.Name = "LabelControl47"
        Me.LabelControl47.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl47.TabIndex = 96
        Me.LabelControl47.Text = "Semt:"
        '
        'txt_sAileAdresi2
        '
        Me.txt_sAileAdresi2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbKefilNufusu, "Table1.sAileAdresi2", True))
        Me.txt_sAileAdresi2.EnterMoveNextControl = True
        Me.txt_sAileAdresi2.Location = New System.Drawing.Point(563, 100)
        Me.txt_sAileAdresi2.Name = "txt_sAileAdresi2"
        Me.txt_sAileAdresi2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAileAdresi2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAileAdresi2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAileAdresi2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAileAdresi2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAileAdresi2.Properties.MaxLength = 60
        Me.txt_sAileAdresi2.Size = New System.Drawing.Size(224, 20)
        Me.txt_sAileAdresi2.TabIndex = 77
        '
        'txt_sAileAdresi1
        '
        Me.txt_sAileAdresi1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbKefilNufusu, "Table1.sAileAdresi1", True))
        Me.txt_sAileAdresi1.EnterMoveNextControl = True
        Me.txt_sAileAdresi1.Location = New System.Drawing.Point(563, 80)
        Me.txt_sAileAdresi1.Name = "txt_sAileAdresi1"
        Me.txt_sAileAdresi1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAileAdresi1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAileAdresi1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAileAdresi1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAileAdresi1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAileAdresi1.Properties.MaxLength = 60
        Me.txt_sAileAdresi1.Size = New System.Drawing.Size(224, 20)
        Me.txt_sAileAdresi1.TabIndex = 76
        '
        'LabelControl46
        '
        Me.LabelControl46.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl46.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl46.Location = New System.Drawing.Point(491, 80)
        Me.LabelControl46.Name = "LabelControl46"
        Me.LabelControl46.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl46.TabIndex = 95
        Me.LabelControl46.Text = "AileAdresi:"
        '
        'txt_sCuzdanKayitNo
        '
        Me.txt_sCuzdanKayitNo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbKefilNufusu, "Table1.sCuzdanKayitNo", True))
        Me.txt_sCuzdanKayitNo.EnterMoveNextControl = True
        Me.txt_sCuzdanKayitNo.Location = New System.Drawing.Point(563, 60)
        Me.txt_sCuzdanKayitNo.Name = "txt_sCuzdanKayitNo"
        Me.txt_sCuzdanKayitNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sCuzdanKayitNo.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sCuzdanKayitNo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sCuzdanKayitNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sCuzdanKayitNo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sCuzdanKayitNo.Properties.MaxLength = 60
        Me.txt_sCuzdanKayitNo.Size = New System.Drawing.Size(144, 20)
        Me.txt_sCuzdanKayitNo.TabIndex = 75
        '
        'LabelControl45
        '
        Me.LabelControl45.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl45.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl45.Location = New System.Drawing.Point(491, 60)
        Me.LabelControl45.Name = "LabelControl45"
        Me.LabelControl45.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl45.TabIndex = 94
        Me.LabelControl45.Text = "T.C.KimlikNo:"
        '
        'txt_sCuzdanVerNedeni
        '
        Me.txt_sCuzdanVerNedeni.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbKefilNufusu, "Table1.sCuzdanVerNedeni", True))
        Me.txt_sCuzdanVerNedeni.EnterMoveNextControl = True
        Me.txt_sCuzdanVerNedeni.Location = New System.Drawing.Point(563, 40)
        Me.txt_sCuzdanVerNedeni.Name = "txt_sCuzdanVerNedeni"
        Me.txt_sCuzdanVerNedeni.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sCuzdanVerNedeni.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sCuzdanVerNedeni.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sCuzdanVerNedeni.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sCuzdanVerNedeni.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sCuzdanVerNedeni.Properties.MaxLength = 60
        Me.txt_sCuzdanVerNedeni.Size = New System.Drawing.Size(224, 20)
        Me.txt_sCuzdanVerNedeni.TabIndex = 74
        '
        'LabelControl44
        '
        Me.LabelControl44.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl44.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl44.Location = New System.Drawing.Point(491, 40)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl44.TabIndex = 93
        Me.LabelControl44.Text = "VeriliþNedeni:"
        '
        'txt_sCuzdanVerilenYer
        '
        Me.txt_sCuzdanVerilenYer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbKefilNufusu, "Table1.sCuzdanVerilenYer", True))
        Me.txt_sCuzdanVerilenYer.EnterMoveNextControl = True
        Me.txt_sCuzdanVerilenYer.Location = New System.Drawing.Point(563, 20)
        Me.txt_sCuzdanVerilenYer.Name = "txt_sCuzdanVerilenYer"
        Me.txt_sCuzdanVerilenYer.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sCuzdanVerilenYer.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sCuzdanVerilenYer.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sCuzdanVerilenYer.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sCuzdanVerilenYer.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sCuzdanVerilenYer.Properties.MaxLength = 60
        Me.txt_sCuzdanVerilenYer.Size = New System.Drawing.Size(224, 20)
        Me.txt_sCuzdanVerilenYer.TabIndex = 73
        '
        'LabelControl43
        '
        Me.LabelControl43.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl43.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl43.Location = New System.Drawing.Point(491, 20)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl43.TabIndex = 92
        Me.LabelControl43.Text = "VerilenYer:"
        '
        'txt_dteNufusCuzdanTarihi
        '
        Me.txt_dteNufusCuzdanTarihi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbKefilNufusu, "Table1.dteNufusCuzdanTarihi", True))
        Me.txt_dteNufusCuzdanTarihi.EditValue = Nothing
        Me.txt_dteNufusCuzdanTarihi.EnterMoveNextControl = True
        Me.txt_dteNufusCuzdanTarihi.Location = New System.Drawing.Point(76, 200)
        Me.txt_dteNufusCuzdanTarihi.Name = "txt_dteNufusCuzdanTarihi"
        Me.txt_dteNufusCuzdanTarihi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteNufusCuzdanTarihi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteNufusCuzdanTarihi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_dteNufusCuzdanTarihi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_dteNufusCuzdanTarihi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_dteNufusCuzdanTarihi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteNufusCuzdanTarihi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_dteNufusCuzdanTarihi.Size = New System.Drawing.Size(100, 20)
        Me.txt_dteNufusCuzdanTarihi.TabIndex = 72
        '
        'LabelControl42
        '
        Me.LabelControl42.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl42.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl42.Location = New System.Drawing.Point(4, 200)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl42.TabIndex = 91
        Me.LabelControl42.Text = "CüzdanTarihi:"
        '
        'txt_sKutukSiraNo
        '
        Me.txt_sKutukSiraNo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbKefilNufusu, "Table1.sKutukSiraNo", True))
        Me.txt_sKutukSiraNo.EnterMoveNextControl = True
        Me.txt_sKutukSiraNo.Location = New System.Drawing.Point(76, 180)
        Me.txt_sKutukSiraNo.Name = "txt_sKutukSiraNo"
        Me.txt_sKutukSiraNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKutukSiraNo.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKutukSiraNo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKutukSiraNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKutukSiraNo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKutukSiraNo.Properties.MaxLength = 60
        Me.txt_sKutukSiraNo.Size = New System.Drawing.Size(100, 20)
        Me.txt_sKutukSiraNo.TabIndex = 71
        '
        'LabelControl41
        '
        Me.LabelControl41.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl41.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl41.Location = New System.Drawing.Point(4, 180)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl41.TabIndex = 90
        Me.LabelControl41.Text = "KütükSýraNo:"
        '
        'txt_sKutukCiltNo
        '
        Me.txt_sKutukCiltNo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbKefilNufusu, "Table1.sKutukCiltNo", True))
        Me.txt_sKutukCiltNo.EnterMoveNextControl = True
        Me.txt_sKutukCiltNo.Location = New System.Drawing.Point(76, 160)
        Me.txt_sKutukCiltNo.Name = "txt_sKutukCiltNo"
        Me.txt_sKutukCiltNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKutukCiltNo.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKutukCiltNo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKutukCiltNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKutukCiltNo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKutukCiltNo.Properties.MaxLength = 60
        Me.txt_sKutukCiltNo.Size = New System.Drawing.Size(100, 20)
        Me.txt_sKutukCiltNo.TabIndex = 70
        '
        'LabelControl40
        '
        Me.LabelControl40.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl40.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl40.Location = New System.Drawing.Point(4, 160)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl40.TabIndex = 89
        Me.LabelControl40.Text = "KütükCiltNo:"
        '
        'txt_sKutukMahalle
        '
        Me.txt_sKutukMahalle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbKefilNufusu, "Table1.sKutukMahalle", True))
        Me.txt_sKutukMahalle.EnterMoveNextControl = True
        Me.txt_sKutukMahalle.Location = New System.Drawing.Point(76, 140)
        Me.txt_sKutukMahalle.Name = "txt_sKutukMahalle"
        Me.txt_sKutukMahalle.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKutukMahalle.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKutukMahalle.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKutukMahalle.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKutukMahalle.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKutukMahalle.Properties.MaxLength = 60
        Me.txt_sKutukMahalle.Size = New System.Drawing.Size(160, 20)
        Me.txt_sKutukMahalle.TabIndex = 69
        '
        'LabelControl39
        '
        Me.LabelControl39.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl39.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl39.Location = New System.Drawing.Point(4, 140)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl39.TabIndex = 88
        Me.LabelControl39.Text = "KütükMahalle:"
        '
        'txt_sKutukIlce
        '
        Me.txt_sKutukIlce.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbKefilNufusu, "Table1.sKutukIlce", True))
        Me.txt_sKutukIlce.EnterMoveNextControl = True
        Me.txt_sKutukIlce.Location = New System.Drawing.Point(76, 120)
        Me.txt_sKutukIlce.Name = "txt_sKutukIlce"
        Me.txt_sKutukIlce.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKutukIlce.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKutukIlce.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKutukIlce.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKutukIlce.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKutukIlce.Properties.MaxLength = 60
        Me.txt_sKutukIlce.Size = New System.Drawing.Size(160, 20)
        Me.txt_sKutukIlce.TabIndex = 67
        '
        'LabelControl38
        '
        Me.LabelControl38.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl38.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl38.Location = New System.Drawing.Point(4, 120)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl38.TabIndex = 87
        Me.LabelControl38.Text = "KütükÝlçe:"
        '
        'txt_sKutukIl
        '
        Me.txt_sKutukIl.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbKefilNufusu, "Table1.sKutukIl", True))
        Me.txt_sKutukIl.EnterMoveNextControl = True
        Me.txt_sKutukIl.Location = New System.Drawing.Point(76, 100)
        Me.txt_sKutukIl.Name = "txt_sKutukIl"
        Me.txt_sKutukIl.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKutukIl.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKutukIl.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKutukIl.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKutukIl.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKutukIl.Properties.MaxLength = 60
        Me.txt_sKutukIl.Size = New System.Drawing.Size(160, 20)
        Me.txt_sKutukIl.TabIndex = 66
        '
        'LabelControl37
        '
        Me.LabelControl37.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl37.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl37.Location = New System.Drawing.Point(4, 100)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl37.TabIndex = 86
        Me.LabelControl37.Text = "KütükÝl:"
        '
        'txt_sAnneAdi
        '
        Me.txt_sAnneAdi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbKefilNufusu, "Table1.sAnneAdi", True))
        Me.txt_sAnneAdi.EnterMoveNextControl = True
        Me.txt_sAnneAdi.Location = New System.Drawing.Point(76, 80)
        Me.txt_sAnneAdi.Name = "txt_sAnneAdi"
        Me.txt_sAnneAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAnneAdi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAnneAdi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAnneAdi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAnneAdi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAnneAdi.Properties.MaxLength = 60
        Me.txt_sAnneAdi.Size = New System.Drawing.Size(224, 20)
        Me.txt_sAnneAdi.TabIndex = 65
        '
        'LabelControl35
        '
        Me.LabelControl35.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl35.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl35.Location = New System.Drawing.Point(4, 80)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl35.TabIndex = 85
        Me.LabelControl35.Text = "AnneAdý:"
        '
        'LabelControl36
        '
        Me.LabelControl36.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl36.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl36.Location = New System.Drawing.Point(4, 60)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl36.TabIndex = 84
        Me.LabelControl36.Text = "AnneHitap:"
        '
        'txt_sBabaAdi
        '
        Me.txt_sBabaAdi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbKefilNufusu, "Table1.sBabaAdi", True))
        Me.txt_sBabaAdi.EnterMoveNextControl = True
        Me.txt_sBabaAdi.Location = New System.Drawing.Point(76, 40)
        Me.txt_sBabaAdi.Name = "txt_sBabaAdi"
        Me.txt_sBabaAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sBabaAdi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sBabaAdi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sBabaAdi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sBabaAdi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sBabaAdi.Properties.MaxLength = 60
        Me.txt_sBabaAdi.Size = New System.Drawing.Size(224, 20)
        Me.txt_sBabaAdi.TabIndex = 63
        '
        'LabelControl34
        '
        Me.LabelControl34.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl34.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl34.Location = New System.Drawing.Point(4, 40)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl34.TabIndex = 83
        Me.LabelControl34.Text = "BabaAdý:"
        '
        'LabelControl33
        '
        Me.LabelControl33.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl33.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl33.Location = New System.Drawing.Point(4, 20)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl33.TabIndex = 68
        Me.LabelControl33.Text = "BabaHitap:"
        '
        'frm_musteri_kefil_nufusu
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_musteri_kefil_nufusu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Müþteri Kefili Nüfus Bilgileri..."
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GroupControl12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl12.ResumeLayout(False)
        Me.GroupControl12.PerformLayout()
        CType(Me.txt_sHitap2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbKefilNufusu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sHitap1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sSigortaNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAileIl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAilePostaKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAileSemt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAileAdresi2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAileAdresi1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sCuzdanKayitNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sCuzdanVerNedeni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sCuzdanVerilenYer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteNufusCuzdanTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteNufusCuzdanTarihi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sKutukSiraNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sKutukCiltNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sKutukMahalle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sKutukIlce.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sKutukIl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAnneAdi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sBabaAdi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public nMusteriID
    Public lKodu
    Public tablo As String
    Public kullanici
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_tbHitap As DataSet
    Private Sub frm_musteri_kefil_nufusu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload(nMusteriID)
        dataload_tbHitap()
    End Sub
    Private Sub dataload(ByVal nMusteriID As String)
        If sorgu_tbMusteriTablo_kontrol(nMusteriID, tablo) = 0 Then
            tbKefilNufusu_kaydet_yeni(tablo, nMusteriID, "", "", "", "", "", "", "01/01/1900", "", "", "", "", "", "", "", "", "", "", "", "", "")
        End If
        Dataload_tbKefilNufusu(nMusteriID, tablo)
    End Sub
    Private Sub dataload_tbHitap()
        ds_tbHitap = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbHitap"))
        txt_sHitap1.Properties.DataSource = ds_tbHitap.Tables(0)
        txt_sHitap2.Properties.DataSource = ds_tbHitap.Tables(0)
    End Sub
    Public Function sorgu_tbMusteriTablo_kontrol(ByVal nMusteriID As String, ByVal Tablo As String) As Int64
        Dim kriter
        kriter = "WHERE (nMusteriID = '" & nMusteriID & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         " & Tablo & "  " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Sub Dataload_tbKefilNufusu(ByVal nMusteriID As String, ByVal tablo As String)
        Try
            ds_tbKefilNufusu.Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         " & tablo & " WHERE nMusteriID ='" & nMusteriID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbKefilNufusu, "Table1")
        conn.Close()
    End Sub
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Baþlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "Ýçerir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
        ElseIf kriter = "Boþ" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklý" Then
            sorgu_kriter = " <> '" & deger & "' "
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = " >  '" & deger & "' "
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = " < '" & deger & "' "
        ElseIf kriter = "Eþittir" Then
            sorgu_kriter = " = '" & deger & "' "
        End If
        Return sorgu_kriter
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Function sorgu(ByVal query As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        con.Close()
        Return DS
    End Function
    Private Sub tbKefilNufusu_kaydet_yeni(ByVal tablo As String, ByVal nMusteriID As String, ByVal sDin As String, ByVal sKutukIl As String, ByVal sKutukIlce As String, ByVal sKutukMahalle As String, ByVal sKutukCiltNo As String, ByVal sKutukSiraNo As String, ByVal dteNufusCuzdanTarihi As DateTime, ByVal sCuzdanVerilenYer As String, ByVal sCuzdanVerNedeni As String, ByVal sCuzdanKayitNo As String, ByVal sAnneAdi As String, ByVal sBabaAdi As String, ByVal sAileAdresi1 As String, ByVal sAileAdresi2 As String, ByVal sAileSemt As String, ByVal sAilePostaKodu As String, ByVal sAileIl As String, ByVal sAileTelefonu As String, ByVal sHitapAnne As String, ByVal sHitapBaba As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO " & tablo & " (nMusteriID, sDin, sKutukIl, sKutukIlce, sKutukMahalle, sKutukCiltNo, sKutukSiraNo, dteNufusCuzdanTarihi, sCuzdanVerilenYer, sCuzdanVerNedeni, sCuzdanKayitNo, sAnneAdi, sBabaAdi, sAileAdresi1, sAileAdresi2, sAileSemt, sAilePostaKodu, sAileIl, sAileTelefonu, sHitapAnne, sHitapBaba) VALUES     ('" & nMusteriID & "', '" & sDin & "', '" & sKutukIl & "', '" & sKutukIlce & "', '" & sKutukMahalle & "', '" & sKutukCiltNo & "', '" & sKutukSiraNo & "', '" & dteNufusCuzdanTarihi & "','" & sCuzdanVerilenYer & "', '" & sCuzdanVerNedeni & "', '" & sCuzdanKayitNo & "', '" & sAnneAdi & "', '" & sBabaAdi & "', '" & sAileAdresi1 & "', '" & sAileAdresi2 & "', '" & sAileSemt & "', '" & sAilePostaKodu & "', '" & sAileIl & "', '" & sAileTelefonu & "', '" & sHitapAnne & "', '" & sHitapBaba & "') ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbKefilNufusu_kaydet_duzelt(ByVal tablo As String, ByVal nMusteriID As String, ByVal sDin As String, ByVal sKutukIl As String, ByVal sKutukIlce As String, ByVal sKutukMahalle As String, ByVal sKutukCiltNo As String, ByVal sKutukSiraNo As String, ByVal dteNufusCuzdanTarihi As DateTime, ByVal sCuzdanVerilenYer As String, ByVal sCuzdanVerNedeni As String, ByVal sCuzdanKayitNo As String, ByVal sAnneAdi As String, ByVal sBabaAdi As String, ByVal sAileAdresi1 As String, ByVal sAileAdresi2 As String, ByVal sAileSemt As String, ByVal sAilePostaKodu As String, ByVal sAileIl As String, ByVal sAileTelefonu As String, ByVal sHitapAnne As String, ByVal sHitapBaba As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    " & tablo & " SET              sDin = '" & sDin & "', sKutukIl = '" & sKutukIl & "', sKutukIlce = '" & sKutukIlce & "', sKutukMahalle = '" & sKutukMahalle & "', sKutukCiltNo = '" & sKutukCiltNo & "', sKutukSiraNo = '" & sKutukSiraNo & "', dteNufusCuzdanTarihi = '" & dteNufusCuzdanTarihi & "', sCuzdanVerilenYer = '" & sCuzdanVerilenYer & "', sCuzdanVerNedeni = '" & sCuzdanVerNedeni & "', sCuzdanKayitNo = '" & sCuzdanKayitNo & "', sAnneAdi = '" & sAnneAdi & "', sBabaAdi = '" & sBabaAdi & "', sAileAdresi1 = '" & sAileAdresi1 & "', sAileAdresi2 = '" & sAileAdresi2 & "', sAileSemt = '" & sAileSemt & "', sAilePostaKodu = '" & sAilePostaKodu & "', sAileIl = '" & sAileIl & "', sAileTelefonu = '" & sAileTelefonu & "', sHitapAnne = '" & sHitapAnne & "', sHitapBaba = '" & sHitapBaba & "' Where nMusteriID = '" & nMusteriID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub kaydet_tumu()
        'Müþteri Nüfusu
        Dim dr As DataRow
        dr = ds_tbKefilNufusu.Tables(0).Rows(0)
        tbKefilNufusu_kaydet_duzelt(tablo, nMusteriID, dr("sDin"), dr("sKutukIl"), dr("sKutukIlce"), dr("sKutukMahalle"), dr("sKutukCiltNo"), dr("sKutukSiraNo"), dr("dteNufusCuzdanTarihi"), dr("sCuzdanVerilenYer"), dr("sCuzdanVerNedeni"), dr("sCuzdanKayitNo"), dr("sAnneAdi"), dr("sBabaAdi"), dr("sAileAdresi1"), dr("sAileAdresi2"), dr("sAileSemt"), dr("sAilePostaKodu"), dr("sAileIl"), dr("sAileTelefonu"), dr("sHitapAnne"), dr("sHitapBaba"))
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        kaydet_tumu()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
End Class
