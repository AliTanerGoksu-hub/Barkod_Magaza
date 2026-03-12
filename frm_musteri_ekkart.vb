Imports DevExpress.XtraEditors
Public Class frm_musteri_ekkart
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
    Friend WithEvents ds_tbMusteriEkKart As System.Data.DataSet
    Friend WithEvents DataTable4 As System.Data.DataTable
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl63 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl64 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl65 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl66 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl67 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl68 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl69 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl58 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl59 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl60 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl61 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl62 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl54 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl57 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl56 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl55 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl53 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl52 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sIsTelefonu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sIsIl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sIsPostaKodu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sIsSemt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sIsAdresi2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sIsAdresi1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sIsYeriAdi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sEvIl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sEvPostaKodu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sEvSemt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sEvTelefonu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sEvAdresi2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sEvAdresi1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_lAylikGelir As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txt_sSigortaNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sSoyadi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sAdi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sHitap1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_sUnvan1 As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_musteri_ekkart))
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
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl
        Me.txt_sEmail = New DevExpress.XtraEditors.TextEdit
        Me.ds_tbMusteriEkKart = New System.Data.DataSet
        Me.DataTable4 = New System.Data.DataTable
        Me.DataColumn20 = New System.Data.DataColumn
        Me.DataColumn21 = New System.Data.DataColumn
        Me.DataColumn22 = New System.Data.DataColumn
        Me.DataColumn23 = New System.Data.DataColumn
        Me.DataColumn24 = New System.Data.DataColumn
        Me.DataColumn25 = New System.Data.DataColumn
        Me.DataColumn26 = New System.Data.DataColumn
        Me.DataColumn27 = New System.Data.DataColumn
        Me.DataColumn28 = New System.Data.DataColumn
        Me.DataColumn29 = New System.Data.DataColumn
        Me.DataColumn30 = New System.Data.DataColumn
        Me.DataColumn31 = New System.Data.DataColumn
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.DataColumn43 = New System.Data.DataColumn
        Me.LabelControl63 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl64 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sIsTelefonu = New DevExpress.XtraEditors.TextEdit
        Me.txt_sIsIl = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl65 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sIsPostaKodu = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl66 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sIsSemt = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl67 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl68 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sIsAdresi2 = New DevExpress.XtraEditors.TextEdit
        Me.txt_sIsAdresi1 = New DevExpress.XtraEditors.TextEdit
        Me.txt_sIsYeriAdi = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl69 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl
        Me.txt_sEvIl = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl58 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sEvPostaKodu = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl59 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sEvSemt = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl60 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl61 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sEvTelefonu = New DevExpress.XtraEditors.TextEdit
        Me.txt_sEvAdresi2 = New DevExpress.XtraEditors.TextEdit
        Me.txt_sEvAdresi1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl62 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.txt_sHitap1 = New DevExpress.XtraEditors.LookUpEdit
        Me.txt_sUnvan1 = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl54 = New DevExpress.XtraEditors.LabelControl
        Me.txt_lAylikGelir = New DevExpress.XtraEditors.CalcEdit
        Me.LabelControl57 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sSigortaNo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl56 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl55 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sSoyadi = New DevExpress.XtraEditors.TextEdit
        Me.txt_sAdi = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl53 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl52 = New DevExpress.XtraEditors.LabelControl
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
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.txt_sEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbMusteriEkKart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sIsTelefonu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sIsIl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sIsPostaKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sIsSemt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sIsAdresi2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sIsAdresi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sIsYeriAdi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.txt_sEvIl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sEvPostaKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sEvSemt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sEvTelefonu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sEvAdresi2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sEvAdresi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.txt_sHitap1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sUnvan1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lAylikGelir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sSigortaNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sSoyadi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAdi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(184, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Müþteri Ek Kartý Tanýmlarý Aþaðýdadýr..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 6
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
        Me.LabelControl92.Location = New System.Drawing.Point(11, 12)
        Me.LabelControl92.Name = "LabelControl92"
        Me.LabelControl92.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl92.TabIndex = 60
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
        Me.txt_musteriNo.Size = New System.Drawing.Size(224, 20)
        Me.txt_musteriNo.TabIndex = 59
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(734, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 58
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(654, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 57
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
        Me.XtraTabControl1.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.XtraTabControl1.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.XtraTabControl1.AppearancePage.HeaderActive.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.HeaderActive.Options.UseForeColor = True
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
        Me.XtraTabPage1.Controls.Add(Me.GroupControl6)
        Me.XtraTabPage1.Controls.Add(Me.GroupControl5)
        Me.XtraTabPage1.Controls.Add(Me.GroupControl4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(814, 293)
        Me.XtraTabPage1.Text = "Genel..."
        '
        'GroupControl6
        '
        Me.GroupControl6.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl6.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupControl6.AppearanceCaption.Options.UseFont = True
        Me.GroupControl6.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl6.Controls.Add(Me.txt_sEmail)
        Me.GroupControl6.Controls.Add(Me.LabelControl63)
        Me.GroupControl6.Controls.Add(Me.LabelControl64)
        Me.GroupControl6.Controls.Add(Me.txt_sIsTelefonu)
        Me.GroupControl6.Controls.Add(Me.txt_sIsIl)
        Me.GroupControl6.Controls.Add(Me.LabelControl65)
        Me.GroupControl6.Controls.Add(Me.txt_sIsPostaKodu)
        Me.GroupControl6.Controls.Add(Me.LabelControl66)
        Me.GroupControl6.Controls.Add(Me.txt_sIsSemt)
        Me.GroupControl6.Controls.Add(Me.LabelControl67)
        Me.GroupControl6.Controls.Add(Me.LabelControl68)
        Me.GroupControl6.Controls.Add(Me.txt_sIsAdresi2)
        Me.GroupControl6.Controls.Add(Me.txt_sIsAdresi1)
        Me.GroupControl6.Controls.Add(Me.txt_sIsYeriAdi)
        Me.GroupControl6.Controls.Add(Me.LabelControl69)
        Me.GroupControl6.Location = New System.Drawing.Point(5, 167)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(802, 116)
        Me.GroupControl6.TabIndex = 6
        Me.GroupControl6.Text = "Ýþ Adresi"
        '
        'txt_sEmail
        '
        Me.txt_sEmail.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriEkKart, "Table1.sEmail", True))
        Me.txt_sEmail.EnterMoveNextControl = True
        Me.txt_sEmail.Location = New System.Drawing.Point(544, 81)
        Me.txt_sEmail.Name = "txt_sEmail"
        Me.txt_sEmail.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEmail.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEmail.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sEmail.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sEmail.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sEmail.Size = New System.Drawing.Size(224, 20)
        Me.txt_sEmail.TabIndex = 19
        '
        'ds_tbMusteriEkKart
        '
        Me.ds_tbMusteriEkKart.DataSetName = "NewDataSet"
        Me.ds_tbMusteriEkKart.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbMusteriEkKart.Tables.AddRange(New System.Data.DataTable() {Me.DataTable4})
        '
        'DataTable4
        '
        Me.DataTable4.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43})
        Me.DataTable4.TableName = "Table1"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "nEkKartID"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "nMusteriID"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "sAdi"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "sSoyadi"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "sUnvan"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "sEmail"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "sIsYeriAdi"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "sIsAdresi1"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "sIsAdresi2"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "sIsSemt"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "sIsPostaKodu"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "sIsIl"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "sIsTelefonu"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "sEvAdresi1"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "sEvAdresi2"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "sEvSemt"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "sEvPostaKodu"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "sEvIl"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "sEvTelefonu"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "lAylikGelir"
        Me.DataColumn39.DataType = GetType(Decimal)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "sSigortaNo"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "sHitap"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "sKullaniciAdi"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "dteKayitTarihi"
        Me.DataColumn43.DataType = GetType(Date)
        '
        'LabelControl63
        '
        Me.LabelControl63.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl63.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl63.Location = New System.Drawing.Point(472, 81)
        Me.LabelControl63.Name = "LabelControl63"
        Me.LabelControl63.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl63.TabIndex = 36
        Me.LabelControl63.Text = "E-Mail:"
        '
        'LabelControl64
        '
        Me.LabelControl64.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl64.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl64.Location = New System.Drawing.Point(8, 81)
        Me.LabelControl64.Name = "LabelControl64"
        Me.LabelControl64.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl64.TabIndex = 35
        Me.LabelControl64.Text = "Telefon:"
        '
        'txt_sIsTelefonu
        '
        Me.txt_sIsTelefonu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriEkKart, "Table1.sIsTelefonu", True))
        Me.txt_sIsTelefonu.EnterMoveNextControl = True
        Me.txt_sIsTelefonu.Location = New System.Drawing.Point(80, 81)
        Me.txt_sIsTelefonu.Name = "txt_sIsTelefonu"
        Me.txt_sIsTelefonu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsTelefonu.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsTelefonu.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sIsTelefonu.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sIsTelefonu.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sIsTelefonu.Properties.Mask.EditMask = "(999) 000-00-00"
        Me.txt_sIsTelefonu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txt_sIsTelefonu.Properties.Mask.SaveLiteral = False
        Me.txt_sIsTelefonu.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_sIsTelefonu.Properties.MaxLength = 20
        Me.txt_sIsTelefonu.Size = New System.Drawing.Size(144, 20)
        Me.txt_sIsTelefonu.TabIndex = 15
        '
        'txt_sIsIl
        '
        Me.txt_sIsIl.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriEkKart, "Table1.sIsIl", True))
        Me.txt_sIsIl.EnterMoveNextControl = True
        Me.txt_sIsIl.Location = New System.Drawing.Point(544, 61)
        Me.txt_sIsIl.Name = "txt_sIsIl"
        Me.txt_sIsIl.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsIl.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsIl.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sIsIl.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sIsIl.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sIsIl.Properties.MaxLength = 20
        Me.txt_sIsIl.Size = New System.Drawing.Size(224, 20)
        Me.txt_sIsIl.TabIndex = 18
        '
        'LabelControl65
        '
        Me.LabelControl65.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl65.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl65.Location = New System.Drawing.Point(472, 61)
        Me.LabelControl65.Name = "LabelControl65"
        Me.LabelControl65.Size = New System.Drawing.Size(10, 13)
        Me.LabelControl65.TabIndex = 32
        Me.LabelControl65.Text = "Ýl:"
        '
        'txt_sIsPostaKodu
        '
        Me.txt_sIsPostaKodu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriEkKart, "Table1.sIsPostaKodu", True))
        Me.txt_sIsPostaKodu.EnterMoveNextControl = True
        Me.txt_sIsPostaKodu.Location = New System.Drawing.Point(544, 41)
        Me.txt_sIsPostaKodu.Name = "txt_sIsPostaKodu"
        Me.txt_sIsPostaKodu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsPostaKodu.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsPostaKodu.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sIsPostaKodu.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sIsPostaKodu.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sIsPostaKodu.Properties.MaxLength = 20
        Me.txt_sIsPostaKodu.Size = New System.Drawing.Size(96, 20)
        Me.txt_sIsPostaKodu.TabIndex = 17
        '
        'LabelControl66
        '
        Me.LabelControl66.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl66.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl66.Location = New System.Drawing.Point(472, 41)
        Me.LabelControl66.Name = "LabelControl66"
        Me.LabelControl66.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl66.TabIndex = 30
        Me.LabelControl66.Text = "PostaKodu:"
        '
        'txt_sIsSemt
        '
        Me.txt_sIsSemt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriEkKart, "Table1.sIsSemt", True))
        Me.txt_sIsSemt.EnterMoveNextControl = True
        Me.txt_sIsSemt.Location = New System.Drawing.Point(544, 21)
        Me.txt_sIsSemt.Name = "txt_sIsSemt"
        Me.txt_sIsSemt.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsSemt.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsSemt.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sIsSemt.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sIsSemt.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sIsSemt.Properties.MaxLength = 60
        Me.txt_sIsSemt.Size = New System.Drawing.Size(224, 20)
        Me.txt_sIsSemt.TabIndex = 16
        '
        'LabelControl67
        '
        Me.LabelControl67.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl67.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl67.Location = New System.Drawing.Point(472, 21)
        Me.LabelControl67.Name = "LabelControl67"
        Me.LabelControl67.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl67.TabIndex = 28
        Me.LabelControl67.Text = "Semt:"
        '
        'LabelControl68
        '
        Me.LabelControl68.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl68.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl68.Location = New System.Drawing.Point(8, 41)
        Me.LabelControl68.Name = "LabelControl68"
        Me.LabelControl68.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl68.TabIndex = 27
        Me.LabelControl68.Text = "Adres:"
        '
        'txt_sIsAdresi2
        '
        Me.txt_sIsAdresi2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriEkKart, "Table1.sIsAdresi2", True))
        Me.txt_sIsAdresi2.EnterMoveNextControl = True
        Me.txt_sIsAdresi2.Location = New System.Drawing.Point(80, 61)
        Me.txt_sIsAdresi2.Name = "txt_sIsAdresi2"
        Me.txt_sIsAdresi2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsAdresi2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsAdresi2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sIsAdresi2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sIsAdresi2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sIsAdresi2.Properties.MaxLength = 60
        Me.txt_sIsAdresi2.Size = New System.Drawing.Size(224, 20)
        Me.txt_sIsAdresi2.TabIndex = 14
        '
        'txt_sIsAdresi1
        '
        Me.txt_sIsAdresi1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriEkKart, "Table1.sIsAdresi1", True))
        Me.txt_sIsAdresi1.EnterMoveNextControl = True
        Me.txt_sIsAdresi1.Location = New System.Drawing.Point(80, 41)
        Me.txt_sIsAdresi1.Name = "txt_sIsAdresi1"
        Me.txt_sIsAdresi1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsAdresi1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsAdresi1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sIsAdresi1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sIsAdresi1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sIsAdresi1.Properties.MaxLength = 60
        Me.txt_sIsAdresi1.Size = New System.Drawing.Size(224, 20)
        Me.txt_sIsAdresi1.TabIndex = 13
        '
        'txt_sIsYeriAdi
        '
        Me.txt_sIsYeriAdi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriEkKart, "Table1.sIsYeriAdi", True))
        Me.txt_sIsYeriAdi.EnterMoveNextControl = True
        Me.txt_sIsYeriAdi.Location = New System.Drawing.Point(80, 21)
        Me.txt_sIsYeriAdi.Name = "txt_sIsYeriAdi"
        Me.txt_sIsYeriAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsYeriAdi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIsYeriAdi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sIsYeriAdi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sIsYeriAdi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sIsYeriAdi.Properties.MaxLength = 60
        Me.txt_sIsYeriAdi.Size = New System.Drawing.Size(224, 20)
        Me.txt_sIsYeriAdi.TabIndex = 12
        '
        'LabelControl69
        '
        Me.LabelControl69.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl69.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl69.Location = New System.Drawing.Point(8, 21)
        Me.LabelControl69.Name = "LabelControl69"
        Me.LabelControl69.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl69.TabIndex = 23
        Me.LabelControl69.Text = "ÝþYeriAdý:"
        '
        'GroupControl5
        '
        Me.GroupControl5.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl5.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupControl5.AppearanceCaption.Options.UseFont = True
        Me.GroupControl5.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl5.Controls.Add(Me.txt_sEvIl)
        Me.GroupControl5.Controls.Add(Me.LabelControl58)
        Me.GroupControl5.Controls.Add(Me.txt_sEvPostaKodu)
        Me.GroupControl5.Controls.Add(Me.LabelControl59)
        Me.GroupControl5.Controls.Add(Me.txt_sEvSemt)
        Me.GroupControl5.Controls.Add(Me.LabelControl60)
        Me.GroupControl5.Controls.Add(Me.LabelControl61)
        Me.GroupControl5.Controls.Add(Me.txt_sEvTelefonu)
        Me.GroupControl5.Controls.Add(Me.txt_sEvAdresi2)
        Me.GroupControl5.Controls.Add(Me.txt_sEvAdresi1)
        Me.GroupControl5.Controls.Add(Me.LabelControl62)
        Me.GroupControl5.Location = New System.Drawing.Point(5, 66)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(802, 92)
        Me.GroupControl5.TabIndex = 5
        Me.GroupControl5.Text = "Ev Adresi"
        '
        'txt_sEvIl
        '
        Me.txt_sEvIl.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriEkKart, "Table1.sEvIl", True))
        Me.txt_sEvIl.EnterMoveNextControl = True
        Me.txt_sEvIl.Location = New System.Drawing.Point(544, 61)
        Me.txt_sEvIl.Name = "txt_sEvIl"
        Me.txt_sEvIl.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvIl.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvIl.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sEvIl.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sEvIl.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sEvIl.Properties.MaxLength = 20
        Me.txt_sEvIl.Size = New System.Drawing.Size(224, 20)
        Me.txt_sEvIl.TabIndex = 11
        '
        'LabelControl58
        '
        Me.LabelControl58.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl58.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl58.Location = New System.Drawing.Point(472, 61)
        Me.LabelControl58.Name = "LabelControl58"
        Me.LabelControl58.Size = New System.Drawing.Size(10, 13)
        Me.LabelControl58.TabIndex = 32
        Me.LabelControl58.Text = "Ýl:"
        '
        'txt_sEvPostaKodu
        '
        Me.txt_sEvPostaKodu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriEkKart, "Table1.sEvPostaKodu", True))
        Me.txt_sEvPostaKodu.EnterMoveNextControl = True
        Me.txt_sEvPostaKodu.Location = New System.Drawing.Point(544, 41)
        Me.txt_sEvPostaKodu.Name = "txt_sEvPostaKodu"
        Me.txt_sEvPostaKodu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvPostaKodu.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvPostaKodu.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sEvPostaKodu.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sEvPostaKodu.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sEvPostaKodu.Properties.MaxLength = 20
        Me.txt_sEvPostaKodu.Size = New System.Drawing.Size(96, 20)
        Me.txt_sEvPostaKodu.TabIndex = 10
        '
        'LabelControl59
        '
        Me.LabelControl59.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl59.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl59.Location = New System.Drawing.Point(472, 41)
        Me.LabelControl59.Name = "LabelControl59"
        Me.LabelControl59.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl59.TabIndex = 30
        Me.LabelControl59.Text = "PostaKodu:"
        '
        'txt_sEvSemt
        '
        Me.txt_sEvSemt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriEkKart, "Table1.sEvSemt", True))
        Me.txt_sEvSemt.EnterMoveNextControl = True
        Me.txt_sEvSemt.Location = New System.Drawing.Point(544, 21)
        Me.txt_sEvSemt.Name = "txt_sEvSemt"
        Me.txt_sEvSemt.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvSemt.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvSemt.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sEvSemt.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sEvSemt.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sEvSemt.Properties.MaxLength = 60
        Me.txt_sEvSemt.Size = New System.Drawing.Size(224, 20)
        Me.txt_sEvSemt.TabIndex = 9
        '
        'LabelControl60
        '
        Me.LabelControl60.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl60.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl60.Location = New System.Drawing.Point(472, 21)
        Me.LabelControl60.Name = "LabelControl60"
        Me.LabelControl60.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl60.TabIndex = 28
        Me.LabelControl60.Text = "Semt:"
        '
        'LabelControl61
        '
        Me.LabelControl61.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl61.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl61.Location = New System.Drawing.Point(8, 61)
        Me.LabelControl61.Name = "LabelControl61"
        Me.LabelControl61.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl61.TabIndex = 27
        Me.LabelControl61.Text = "Telefon:"
        '
        'txt_sEvTelefonu
        '
        Me.txt_sEvTelefonu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriEkKart, "Table1.sEvTelefonu", True))
        Me.txt_sEvTelefonu.EnterMoveNextControl = True
        Me.txt_sEvTelefonu.Location = New System.Drawing.Point(80, 61)
        Me.txt_sEvTelefonu.Name = "txt_sEvTelefonu"
        Me.txt_sEvTelefonu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvTelefonu.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvTelefonu.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sEvTelefonu.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sEvTelefonu.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sEvTelefonu.Properties.Mask.EditMask = "(999) 000-00-00"
        Me.txt_sEvTelefonu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txt_sEvTelefonu.Properties.Mask.SaveLiteral = False
        Me.txt_sEvTelefonu.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txt_sEvTelefonu.Properties.MaxLength = 20
        Me.txt_sEvTelefonu.Size = New System.Drawing.Size(136, 20)
        Me.txt_sEvTelefonu.TabIndex = 8
        '
        'txt_sEvAdresi2
        '
        Me.txt_sEvAdresi2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriEkKart, "Table1.sEvAdresi2", True))
        Me.txt_sEvAdresi2.EnterMoveNextControl = True
        Me.txt_sEvAdresi2.Location = New System.Drawing.Point(80, 41)
        Me.txt_sEvAdresi2.Name = "txt_sEvAdresi2"
        Me.txt_sEvAdresi2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvAdresi2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvAdresi2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sEvAdresi2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sEvAdresi2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sEvAdresi2.Properties.MaxLength = 60
        Me.txt_sEvAdresi2.Size = New System.Drawing.Size(224, 20)
        Me.txt_sEvAdresi2.TabIndex = 7
        '
        'txt_sEvAdresi1
        '
        Me.txt_sEvAdresi1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriEkKart, "Table1.sEvAdresi1", True))
        Me.txt_sEvAdresi1.EnterMoveNextControl = True
        Me.txt_sEvAdresi1.Location = New System.Drawing.Point(80, 21)
        Me.txt_sEvAdresi1.Name = "txt_sEvAdresi1"
        Me.txt_sEvAdresi1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvAdresi1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sEvAdresi1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sEvAdresi1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sEvAdresi1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sEvAdresi1.Properties.MaxLength = 60
        Me.txt_sEvAdresi1.Size = New System.Drawing.Size(224, 20)
        Me.txt_sEvAdresi1.TabIndex = 6
        '
        'LabelControl62
        '
        Me.LabelControl62.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl62.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl62.Location = New System.Drawing.Point(8, 21)
        Me.LabelControl62.Name = "LabelControl62"
        Me.LabelControl62.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl62.TabIndex = 23
        Me.LabelControl62.Text = "Adres:"
        '
        'GroupControl4
        '
        Me.GroupControl4.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl4.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupControl4.AppearanceCaption.Options.UseFont = True
        Me.GroupControl4.AppearanceCaption.Options.UseForeColor = True
        Me.GroupControl4.Controls.Add(Me.txt_sHitap1)
        Me.GroupControl4.Controls.Add(Me.txt_sUnvan1)
        Me.GroupControl4.Controls.Add(Me.LabelControl54)
        Me.GroupControl4.Controls.Add(Me.txt_lAylikGelir)
        Me.GroupControl4.Controls.Add(Me.LabelControl57)
        Me.GroupControl4.Controls.Add(Me.txt_sSigortaNo)
        Me.GroupControl4.Controls.Add(Me.LabelControl56)
        Me.GroupControl4.Controls.Add(Me.LabelControl55)
        Me.GroupControl4.Controls.Add(Me.txt_sSoyadi)
        Me.GroupControl4.Controls.Add(Me.txt_sAdi)
        Me.GroupControl4.Controls.Add(Me.LabelControl53)
        Me.GroupControl4.Controls.Add(Me.LabelControl52)
        Me.GroupControl4.Location = New System.Drawing.Point(5, 2)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(802, 67)
        Me.GroupControl4.TabIndex = 4
        Me.GroupControl4.Text = "Özel Bilgiler"
        '
        'txt_sHitap1
        '
        Me.txt_sHitap1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriEkKart, "Table1.sHitap", True))
        Me.txt_sHitap1.EnterMoveNextControl = True
        Me.txt_sHitap1.Location = New System.Drawing.Point(80, 20)
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
        Me.txt_sHitap1.TabIndex = 0
        '
        'txt_sUnvan1
        '
        Me.txt_sUnvan1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriEkKart, "Table1.sUnvan", True))
        Me.txt_sUnvan1.EnterMoveNextControl = True
        Me.txt_sUnvan1.Location = New System.Drawing.Point(540, 21)
        Me.txt_sUnvan1.Name = "txt_sUnvan1"
        Me.txt_sUnvan1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sUnvan1.Properties.Appearance.Options.UseBackColor = True
        Me.txt_sUnvan1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sUnvan1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sUnvan1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sUnvan1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sUnvan1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sUnvan1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sUnvan1.Properties.DisplayMember = "sUnvan"
        Me.txt_sUnvan1.Properties.NullText = "[Ünvan]"
        Me.txt_sUnvan1.Properties.ValueMember = "sUnvan"
        Me.txt_sUnvan1.Size = New System.Drawing.Size(100, 20)
        Me.txt_sUnvan1.TabIndex = 3
        '
        'LabelControl54
        '
        Me.LabelControl54.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl54.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl54.Location = New System.Drawing.Point(182, 40)
        Me.LabelControl54.Name = "LabelControl54"
        Me.LabelControl54.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl54.TabIndex = 36
        Me.LabelControl54.Text = "Soyad:"
        '
        'txt_lAylikGelir
        '
        Me.txt_lAylikGelir.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriEkKart, "Table1.lAylikGelir", True))
        Me.txt_lAylikGelir.EnterMoveNextControl = True
        Me.txt_lAylikGelir.Location = New System.Drawing.Point(676, 41)
        Me.txt_lAylikGelir.Name = "txt_lAylikGelir"
        Me.txt_lAylikGelir.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lAylikGelir.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lAylikGelir.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lAylikGelir.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lAylikGelir.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lAylikGelir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_lAylikGelir.Size = New System.Drawing.Size(88, 20)
        Me.txt_lAylikGelir.TabIndex = 5
        '
        'LabelControl57
        '
        Me.LabelControl57.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl57.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl57.Location = New System.Drawing.Point(644, 41)
        Me.LabelControl57.Name = "LabelControl57"
        Me.LabelControl57.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl57.TabIndex = 34
        Me.LabelControl57.Text = "Gelir:"
        '
        'txt_sSigortaNo
        '
        Me.txt_sSigortaNo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriEkKart, "Table1.sSigortaNo", True))
        Me.txt_sSigortaNo.EnterMoveNextControl = True
        Me.txt_sSigortaNo.Location = New System.Drawing.Point(540, 41)
        Me.txt_sSigortaNo.Name = "txt_sSigortaNo"
        Me.txt_sSigortaNo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sSigortaNo.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sSigortaNo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sSigortaNo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sSigortaNo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sSigortaNo.Properties.MaxLength = 60
        Me.txt_sSigortaNo.Size = New System.Drawing.Size(100, 20)
        Me.txt_sSigortaNo.TabIndex = 4
        '
        'LabelControl56
        '
        Me.LabelControl56.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl56.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl56.Location = New System.Drawing.Point(468, 41)
        Me.LabelControl56.Name = "LabelControl56"
        Me.LabelControl56.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl56.TabIndex = 32
        Me.LabelControl56.Text = "SigortaNo:"
        '
        'LabelControl55
        '
        Me.LabelControl55.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl55.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl55.Location = New System.Drawing.Point(468, 21)
        Me.LabelControl55.Name = "LabelControl55"
        Me.LabelControl55.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl55.TabIndex = 31
        Me.LabelControl55.Text = "Ünvan:"
        '
        'txt_sSoyadi
        '
        Me.txt_sSoyadi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriEkKart, "Table1.sSoyadi", True))
        Me.txt_sSoyadi.EnterMoveNextControl = True
        Me.txt_sSoyadi.Location = New System.Drawing.Point(216, 40)
        Me.txt_sSoyadi.Name = "txt_sSoyadi"
        Me.txt_sSoyadi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sSoyadi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sSoyadi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sSoyadi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sSoyadi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sSoyadi.Properties.MaxLength = 60
        Me.txt_sSoyadi.Size = New System.Drawing.Size(88, 20)
        Me.txt_sSoyadi.TabIndex = 2
        '
        'txt_sAdi
        '
        Me.txt_sAdi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbMusteriEkKart, "Table1.sAdi", True))
        Me.txt_sAdi.EnterMoveNextControl = True
        Me.txt_sAdi.Location = New System.Drawing.Point(80, 40)
        Me.txt_sAdi.Name = "txt_sAdi"
        Me.txt_sAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAdi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAdi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAdi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAdi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAdi.Properties.MaxLength = 60
        Me.txt_sAdi.Size = New System.Drawing.Size(100, 20)
        Me.txt_sAdi.TabIndex = 1
        '
        'LabelControl53
        '
        Me.LabelControl53.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl53.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl53.Location = New System.Drawing.Point(8, 40)
        Me.LabelControl53.Name = "LabelControl53"
        Me.LabelControl53.Size = New System.Drawing.Size(17, 13)
        Me.LabelControl53.TabIndex = 26
        Me.LabelControl53.Text = "Ad:"
        '
        'LabelControl52
        '
        Me.LabelControl52.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl52.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl52.Location = New System.Drawing.Point(8, 20)
        Me.LabelControl52.Name = "LabelControl52"
        Me.LabelControl52.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl52.TabIndex = 7
        Me.LabelControl52.Text = "Hitap:"
        '
        'frm_musteri_ekkart
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_musteri_ekkart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Müþteri Ek Kartý"
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
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        Me.GroupControl6.PerformLayout()
        CType(Me.txt_sEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbMusteriEkKart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sIsTelefonu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sIsIl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sIsPostaKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sIsSemt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sIsAdresi2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sIsAdresi1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sIsYeriAdi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        CType(Me.txt_sEvIl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sEvPostaKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sEvSemt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sEvTelefonu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sEvAdresi2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sEvAdresi1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.txt_sHitap1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sUnvan1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lAylikGelir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sSigortaNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sSoyadi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAdi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public nMusteriID As String
    Public nEkKartID As String
    Public lKodu
    Public kullanici
    Dim status As Boolean = False
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_cari As DataSet
    Dim ds_tbUnvan As DataSet
    Dim ds_tbHitap As DataSet
    Private Sub frm_musteri_ekkart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If nEkKartID = "" Then
            nEkKartID = tbMusteriEkKart_kaydet_yeni(nMusteriID, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 0, "", "Sayýn", kullanici, Now)
        Else
        End If
        Dataload_tbMusteriEkKart(nMusteriID, nEkKartID)
        dataload_tbHitap()
        dataload_tbUnvan()
        XtraTabControl1.Focus()
        XtraTabControl1.Select()
        XtraTabControl1.SelectedTabPageIndex = 0
        txt_sAdi.Focus()
        txt_sAdi.SelectAll()
    End Sub
    Private Sub dataload_tbUnvan()
        ds_tbUnvan = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbUnvan"))
        txt_sUnvan1.Properties.DataSource = ds_tbUnvan.Tables(0)
    End Sub
    Private Sub dataload_tbHitap()
        ds_tbHitap = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbHitap"))
        txt_sHitap1.Properties.DataSource = ds_tbHitap.Tables(0)
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
    Public Sub Dataload_tbMusteriEkKart(ByVal nMusteriID As String, ByVal nEkKartID As String)
        Try
            ds_tbMusteriEkKart.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM           tbMusteriEkKart WHERE nMusteriID ='" & nMusteriID & "' and nEkKartID = '" & nEkKartID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbMusteriEkKart, "Table1")
        conn.Close()
    End Sub
    Private Function tbMusteriEkKart_kaydet_yeni(ByVal nMusteriID As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal sUnvan As String, ByVal sEmail As String, ByVal sIsYeriAdi As String, ByVal sIsAdresi1 As String, ByVal sIsAdresi2 As String, ByVal sIsSemt As String, ByVal sIsPostaKodu As String, ByVal sIsIl As String, ByVal sIsTelefonu As String, ByVal sEvAdresi1 As String, ByVal sEvAdresi2 As String, ByVal sEvSemt As String, ByVal sEvPostaKodu As String, ByVal sEvIl As String, ByVal sEvTelefonu As String, ByVal lAylikGelir As Decimal, ByVal sSigortaNo As String, ByVal sHitap As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime) As Int64
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteriEkKart (nMusteriID, sAdi, sSoyadi, sUnvan, sEmail, sIsYeriAdi, sIsAdresi1, sIsAdresi2, sIsSemt, sIsPostaKodu, sIsIl, sIsTelefonu, sEvAdresi1, sEvAdresi2, sEvSemt, sEvPostaKodu, sEvIl, sEvTelefonu, lAylikGelir, sSigortaNo, sHitap, sKullaniciAdi, dteKayitTarihi) VALUES     ('" & nMusteriID & "', '" & sAdi & "', '" & sSoyadi & "', '" & sUnvan & "', '" & sEmail & "', '" & sIsYeriAdi & "', '" & sIsAdresi1 & "', '" & sIsAdresi2 & "', '" & sIsSemt & "', '" & sIsPostaKodu & "', '" & sIsIl & "', '" & sIsTelefonu & "', '" & sEvAdresi1 & "', '" & sEvAdresi2 & "', '" & sEvSemt & "', '" & sEvPostaKodu & "', '" & sEvIl & "', '" & sEvTelefonu & "', " & lAylikGelir & ", '" & sSigortaNo & "', '" & sHitap & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Private Sub tbMusteriEkKart_kaydet_duzelt(ByVal nEkKartID As String, ByVal nMusteriID As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal sUnvan As String, ByVal sEmail As String, ByVal sIsYeriAdi As String, ByVal sIsAdresi1 As String, ByVal sIsAdresi2 As String, ByVal sIsSemt As String, ByVal sIsPostaKodu As String, ByVal sIsIl As String, ByVal sIsTelefonu As String, ByVal sEvAdresi1 As String, ByVal sEvAdresi2 As String, ByVal sEvSemt As String, ByVal sEvPostaKodu As String, ByVal sEvIl As String, ByVal sEvTelefonu As String, ByVal lAylikGelir As Decimal, ByVal sSigortaNo As String, ByVal sHitap As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMusteriEkKart SET              sAdi = '" & sAdi & "', sSoyadi = '" & sSoyadi & "', sUnvan = '" & sUnvan & "', sEmail = '" & sEmail & "', sIsYeriAdi = '" & sIsYeriAdi & "', sIsAdresi1 = '" & sIsAdresi1 & "', sIsAdresi2 = '" & sIsAdresi2 & "', sIsSemt = '" & sIsSemt & "', sIsPostaKodu = '" & sIsPostaKodu & "', sIsIl = '" & sIsIl & "', sIsTelefonu = '" & sIsTelefonu & "', sEvAdresi1 = '" & sEvAdresi1 & "', sEvAdresi2 = '" & sEvAdresi2 & "', sEvSemt = '" & sEvSemt & "', sEvPostaKodu = '" & sEvPostaKodu & "', sEvIl = '" & sEvIl & "', sEvTelefonu = '" & sEvTelefonu & "', lAylikGelir = " & lAylikGelir & ", sSigortaNo = '" & sSigortaNo & "', sHitap = '" & sHitap & "', sKullaniciAdi = '" & sKullaniciAdi & "' Where nMusteriID = '" & nMusteriID & "' and nEkKartID = '" & nEkKartID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriEkKart_kaydet_sil(ByVal nEkKartID As String, ByVal nMusteriID As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Delete From tbMusteriEkKart Where nMusteriID = '" & nMusteriID & "' and nEkKartID = '" & nEkKartID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMusteriEkKart_kaydet()
        If Trim(txt_sAdi.Text) = "" Then
            XtraMessageBox.Show(Sorgu_sDil("Ad Kýsmýný Boþ Geçemezsiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_sAdi.Focus()
            txt_sAdi.SelectAll()
        ElseIf Trim(txt_sSoyadi.Text) = "" Then
            XtraMessageBox.Show(Sorgu_sDil("Soyad Kýsmýný Boþ Geçemezsiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_sSoyadi.Focus()
            txt_sSoyadi.SelectAll()
        Else
            Dim dr As DataRow = ds_tbMusteriEkKart.Tables(0).Rows(0)
            tbMusteriEkKart_kaydet_duzelt(nEkKartID, nMusteriID, dr("sAdi"), dr("sSoyadi"), dr("sUnvan"), dr("sEmail"), dr("sIsYeriAdi"), dr("sIsAdresi1"), dr("sIsAdresi2"), dr("sIsSemt"), dr("sIsPostaKodu"), dr("sIsIl"), dr("sIsTelefonu"), dr("sEvAdresi1"), dr("sEvAdresi2"), dr("sEvSemt"), dr("sEvPostaKodu"), dr("sEvIl"), dr("sEvTelefonu"), dr("lAylikGelir"), dr("sSigortaNo"), dr("sHitap"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
            Me.Close()
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        tbMusteriEkKart_kaydet()
    End Sub
End Class
