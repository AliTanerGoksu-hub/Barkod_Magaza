<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Table_Edit
    Inherits DevExpress.XtraEditors.XtraForm
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
            If Not (dv Is Nothing) Then
                dv.Dispose()
            End If
            If Not (ds Is Nothing) Then
                ds.Dispose()
            End If
            If Not (da Is Nothing) Then
                ds.Dispose()
            End If
            If Not (mySQL Is Nothing) Then
                mySQL.Dispose()
            End If
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Table_Edit))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.tarihSec1 = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.tarihSec2 = New DevExpress.XtraEditors.DateEdit()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Group_Toplu = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sAciklama = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_bYabanci = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_bPuan = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_bVisa = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_nTaksitSayisi = New DevExpress.XtraEditors.SpinEdit()
        Me.txt_sOdemeSekli = New DevExpress.XtraEditors.ButtonEdit()
        Me.grdMain = New DevExpress.XtraGrid.GridControl()
        Me.kisayol = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopluEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DuzeltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GörünümüDüzenleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaþlýkDeðiþtirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GörünümüKaydetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GörünümüYazdýrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HýzlýFiltreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_AltTopluEkle = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.tarihSec1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tarihSec1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tarihSec2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tarihSec2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.Group_Toplu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_Toplu.SuspendLayout()
        CType(Me.txt_sAciklama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bYabanci.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bPuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bVisa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nTaksitSayisi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sOdemeSekli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kisayol.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Panel1)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 56)
        Me.PanelControl1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LabelControl7)
        Me.Panel1.Controls.Add(Me.tarihSec1)
        Me.Panel1.Controls.Add(Me.SimpleButton5)
        Me.Panel1.Controls.Add(Me.LabelControl11)
        Me.Panel1.Controls.Add(Me.LabelControl9)
        Me.Panel1.Controls.Add(Me.tarihSec2)
        Me.Panel1.Location = New System.Drawing.Point(102, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 28)
        Me.Panel1.TabIndex = 47
        Me.Panel1.Visible = False
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Location = New System.Drawing.Point(-10, 5)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(46, 20)
        Me.LabelControl7.TabIndex = 22
        Me.LabelControl7.Text = "Tarih:"
        '
        'tarihSec1
        '
        Me.tarihSec1.EditValue = Nothing
        Me.tarihSec1.EnterMoveNextControl = True
        Me.tarihSec1.Location = New System.Drawing.Point(44, 5)
        Me.tarihSec1.Name = "tarihSec1"
        Me.tarihSec1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tarihSec1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tarihSec1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.tarihSec1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.tarihSec1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.tarihSec1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tarihSec1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.tarihSec1.Size = New System.Drawing.Size(100, 20)
        Me.tarihSec1.TabIndex = 42
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(330, 5)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(75, 20)
        Me.SimpleButton5.TabIndex = 46
        Me.SimpleButton5.Text = "&Listele"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl11.Location = New System.Drawing.Point(144, 5)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(24, 20)
        Me.LabelControl11.TabIndex = 44
        Me.LabelControl11.Text = "ve"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl9.Location = New System.Drawing.Point(275, 5)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(75, 20)
        Me.LabelControl9.TabIndex = 45
        Me.LabelControl9.Text = "Arasýndaki"
        '
        'tarihSec2
        '
        Me.tarihSec2.EditValue = Nothing
        Me.tarihSec2.EnterMoveNextControl = True
        Me.tarihSec2.Location = New System.Drawing.Point(168, 5)
        Me.tarihSec2.Name = "tarihSec2"
        Me.tarihSec2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tarihSec2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tarihSec2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.tarihSec2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.tarihSec2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.tarihSec2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tarihSec2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.tarihSec2.Size = New System.Drawing.Size(100, 20)
        Me.tarihSec2.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Tablo Bilgileri Aþaðýdadýr..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 359)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(9, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(736, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 66
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(661, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 65
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.Group_Toplu)
        Me.PanelControl3.Controls.Add(Me.grdMain)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 303)
        Me.PanelControl3.TabIndex = 0
        '
        'Group_Toplu
        '
        Me.Group_Toplu.Controls.Add(Me.LabelControl3)
        Me.Group_Toplu.Controls.Add(Me.txt_sAciklama)
        Me.Group_Toplu.Controls.Add(Me.LabelControl2)
        Me.Group_Toplu.Controls.Add(Me.LabelControl1)
        Me.Group_Toplu.Controls.Add(Me.SimpleButton4)
        Me.Group_Toplu.Controls.Add(Me.SimpleButton3)
        Me.Group_Toplu.Controls.Add(Me.sec_bYabanci)
        Me.Group_Toplu.Controls.Add(Me.sec_bPuan)
        Me.Group_Toplu.Controls.Add(Me.sec_bVisa)
        Me.Group_Toplu.Controls.Add(Me.txt_nTaksitSayisi)
        Me.Group_Toplu.Controls.Add(Me.txt_sOdemeSekli)
        Me.Group_Toplu.Location = New System.Drawing.Point(267, 67)
        Me.Group_Toplu.Name = "Group_Toplu"
        Me.Group_Toplu.Size = New System.Drawing.Size(254, 169)
        Me.Group_Toplu.TabIndex = 24
        Me.Group_Toplu.Text = "Toplu Ödeme Þekli"
        Me.Group_Toplu.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(9, 66)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "Açýklama:"
        '
        'txt_sAciklama
        '
        Me.txt_sAciklama.Location = New System.Drawing.Point(90, 63)
        Me.txt_sAciklama.Name = "txt_sAciklama"
        Me.txt_sAciklama.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_sAciklama.Size = New System.Drawing.Size(155, 20)
        Me.txt_sAciklama.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(9, 45)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "TaksitSayisi:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(9, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "BankaKodu:"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(171, 141)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton4.TabIndex = 7
        Me.SimpleButton4.Text = "&Vazgeç"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(90, 141)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton3.TabIndex = 6
        Me.SimpleButton3.Text = "&Tamam"
        '
        'sec_bYabanci
        '
        Me.sec_bYabanci.Location = New System.Drawing.Point(90, 118)
        Me.sec_bYabanci.Name = "sec_bYabanci"
        Me.sec_bYabanci.Properties.Caption = "Yabancý"
        Me.sec_bYabanci.Size = New System.Drawing.Size(160, 19)
        Me.sec_bYabanci.TabIndex = 5
        '
        'sec_bPuan
        '
        Me.sec_bPuan.Location = New System.Drawing.Point(90, 102)
        Me.sec_bPuan.Name = "sec_bPuan"
        Me.sec_bPuan.Properties.Caption = "Puan"
        Me.sec_bPuan.Size = New System.Drawing.Size(160, 19)
        Me.sec_bPuan.TabIndex = 4
        '
        'sec_bVisa
        '
        Me.sec_bVisa.Location = New System.Drawing.Point(90, 86)
        Me.sec_bVisa.Name = "sec_bVisa"
        Me.sec_bVisa.Properties.Caption = "Visa"
        Me.sec_bVisa.Size = New System.Drawing.Size(160, 19)
        Me.sec_bVisa.TabIndex = 3
        '
        'txt_nTaksitSayisi
        '
        Me.txt_nTaksitSayisi.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_nTaksitSayisi.EnterMoveNextControl = True
        Me.txt_nTaksitSayisi.Location = New System.Drawing.Point(90, 42)
        Me.txt_nTaksitSayisi.Name = "txt_nTaksitSayisi"
        Me.txt_nTaksitSayisi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nTaksitSayisi.Size = New System.Drawing.Size(75, 20)
        Me.txt_nTaksitSayisi.TabIndex = 1
        '
        'txt_sOdemeSekli
        '
        Me.txt_sOdemeSekli.EnterMoveNextControl = True
        Me.txt_sOdemeSekli.Location = New System.Drawing.Point(90, 21)
        Me.txt_sOdemeSekli.Name = "txt_sOdemeSekli"
        Me.txt_sOdemeSekli.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_sOdemeSekli.Size = New System.Drawing.Size(75, 20)
        Me.txt_sOdemeSekli.TabIndex = 0
        '
        'grdMain
        '
        Me.grdMain.ContextMenuStrip = Me.kisayol
        Me.grdMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdMain.Location = New System.Drawing.Point(2, 2)
        Me.grdMain.MainView = Me.GridView1
        Me.grdMain.Name = "grdMain"
        Me.grdMain.Size = New System.Drawing.Size(820, 299)
        Me.grdMain.TabIndex = 23
        Me.grdMain.UseEmbeddedNavigator = True
        Me.grdMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'kisayol
        '
        Me.kisayol.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EkleToolStripMenuItem, Me.TopluEkleToolStripMenuItem, Me.DuzeltToolStripMenuItem, Me.SilToolStripMenuItem, Me.ToolStripSeparator1, Me.GörünümüDüzenleToolStripMenuItem, Me.BaþlýkDeðiþtirToolStripMenuItem, Me.GörünümüKaydetToolStripMenuItem, Me.GörünümüYazdýrToolStripMenuItem, Me.ToolStripSeparator2, Me.HýzlýFiltreToolStripMenuItem, Me.MenuItem6, Me.MenuItem7, Me.ToolStripSeparator3, Me.MenuItem8, Me.MenuItem9, Me.ToolStripSeparator4, Me.MenuItem10})
        Me.kisayol.Name = "ContextMenuStrip1"
        Me.kisayol.Size = New System.Drawing.Size(209, 336)
        '
        'EkleToolStripMenuItem
        '
        Me.EkleToolStripMenuItem.Name = "EkleToolStripMenuItem"
        Me.EkleToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Insert
        Me.EkleToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.EkleToolStripMenuItem.Text = "Ekle"
        '
        'TopluEkleToolStripMenuItem
        '
        Me.TopluEkleToolStripMenuItem.Name = "TopluEkleToolStripMenuItem"
        Me.TopluEkleToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.TopluEkleToolStripMenuItem.Text = "Toplu Ekle"
        '
        'DuzeltToolStripMenuItem
        '
        Me.DuzeltToolStripMenuItem.Name = "DuzeltToolStripMenuItem"
        Me.DuzeltToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.DuzeltToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.DuzeltToolStripMenuItem.Text = "Duzelt"
        '
        'SilToolStripMenuItem
        '
        Me.SilToolStripMenuItem.Name = "SilToolStripMenuItem"
        Me.SilToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.SilToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.SilToolStripMenuItem.Text = "Sil"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(205, 6)
        '
        'GörünümüDüzenleToolStripMenuItem
        '
        Me.GörünümüDüzenleToolStripMenuItem.Name = "GörünümüDüzenleToolStripMenuItem"
        Me.GörünümüDüzenleToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.GörünümüDüzenleToolStripMenuItem.Text = "Görünümü Düzenle"
        '
        'BaþlýkDeðiþtirToolStripMenuItem
        '
        Me.BaþlýkDeðiþtirToolStripMenuItem.Name = "BaþlýkDeðiþtirToolStripMenuItem"
        Me.BaþlýkDeðiþtirToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.BaþlýkDeðiþtirToolStripMenuItem.Text = "Baþlýk Deðiþtir"
        '
        'GörünümüKaydetToolStripMenuItem
        '
        Me.GörünümüKaydetToolStripMenuItem.Name = "GörünümüKaydetToolStripMenuItem"
        Me.GörünümüKaydetToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.GörünümüKaydetToolStripMenuItem.Text = "Görünümü Kaydet"
        '
        'GörünümüYazdýrToolStripMenuItem
        '
        Me.GörünümüYazdýrToolStripMenuItem.Name = "GörünümüYazdýrToolStripMenuItem"
        Me.GörünümüYazdýrToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.GörünümüYazdýrToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.GörünümüYazdýrToolStripMenuItem.Text = "Görünümü Yazdýr"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(205, 6)
        '
        'HýzlýFiltreToolStripMenuItem
        '
        Me.HýzlýFiltreToolStripMenuItem.Name = "HýzlýFiltreToolStripMenuItem"
        Me.HýzlýFiltreToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.HýzlýFiltreToolStripMenuItem.Text = "Hýzlý Filtre"
        '
        'MenuItem6
        '
        Me.MenuItem6.Name = "MenuItem6"
        Me.MenuItem6.Size = New System.Drawing.Size(208, 22)
        Me.MenuItem6.Text = "Filtrele"
        '
        'MenuItem7
        '
        Me.MenuItem7.Name = "MenuItem7"
        Me.MenuItem7.Size = New System.Drawing.Size(208, 22)
        Me.MenuItem7.Text = "Gruplandýr"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(205, 6)
        '
        'MenuItem8
        '
        Me.MenuItem8.Name = "MenuItem8"
        Me.MenuItem8.Size = New System.Drawing.Size(208, 22)
        Me.MenuItem8.Text = "Satýrlarý Aç"
        '
        'MenuItem9
        '
        Me.MenuItem9.Name = "MenuItem9"
        Me.MenuItem9.Size = New System.Drawing.Size(208, 22)
        Me.MenuItem9.Text = "Satýrlarý Kapat"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(205, 6)
        '
        'MenuItem10
        '
        Me.MenuItem10.Name = "MenuItem10"
        Me.MenuItem10.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.MenuItem10.Size = New System.Drawing.Size(208, 22)
        Me.MenuItem10.Text = "Ekraný Kapla"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grdMain
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'ps
        '
        Me.ps.Links.AddRange(New Object() {Me.printlink1})
        '
        'printlink1
        '
        Me.printlink1.Component = Me.grdMain
        '
        '
        '
        Me.printlink1.ImageCollection.ImageStream = CType(resources.GetObject("printlink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink1.Owner = Nothing
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Tanýmlar", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Veri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.btn_AltTopluEkle})
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_AltTopluEkle, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Excel"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Text"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Mail"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'btn_AltTopluEkle
        '
        Me.btn_AltTopluEkle.Caption = "Toplu Ekle"
        Me.btn_AltTopluEkle.Enabled = False
        Me.btn_AltTopluEkle.Id = 4
        Me.btn_AltTopluEkle.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_AltTopluEkle.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_AltTopluEkle.Name = "btn_AltTopluEkle"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(824, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 407)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 407)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 407)
        '
        'frm_Table_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Table_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tablo Editörü"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.tarihSec1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tarihSec1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tarihSec2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tarihSec2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.Group_Toplu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_Toplu.ResumeLayout(False)
        Me.Group_Toplu.PerformLayout()
        CType(Me.txt_sAciklama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bYabanci.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bPuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bVisa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nTaksitSayisi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sOdemeSekli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kisayol.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents kisayol As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EkleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DuzeltToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GörünümüDüzenleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BaþlýkDeðiþtirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GörünümüKaydetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GörünümüYazdýrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HýzlýFiltreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Group_Toplu As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_AltTopluEkle As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_bYabanci As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_bPuan As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_bVisa As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_nTaksitSayisi As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_sOdemeSekli As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sAciklama As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents TopluEkleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tarihSec2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tarihSec1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
End Class
