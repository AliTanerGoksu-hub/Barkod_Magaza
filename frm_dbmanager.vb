Imports Microsoft.Win32
Imports System.IO
Imports System
Imports DevExpress.XtraEditors
Public Class frm_dbmanager
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
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cumle As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents verikisayol As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents sorgukisayol As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ds_veritabani As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents colname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfilename As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcrdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents veritabani_kisayol As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents ds_tablo As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents colfirma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldonem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltablo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colname1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcrdate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents openfile As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_dbmanager))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.sorgukisayol = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.veritabani_kisayol = New System.Windows.Forms.ContextMenu()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.ds_veritabani = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfilename = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcrdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.ds_tablo = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colfirma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldonem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltablo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colname1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcrdate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.verikisayol = New System.Windows.Forms.ContextMenu()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.cumle = New DevExpress.XtraEditors.MemoEdit()
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.openfile = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_veritabani, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tablo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.cumle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl8.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(792, 56)
        Me.PanelControl1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(718, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton4)
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 393)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(792, 52)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Enabled = False
        Me.SimpleButton4.Location = New System.Drawing.Point(91, 17)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 25)
        Me.SimpleButton4.TabIndex = 5
        Me.SimpleButton4.Text = "Kolon Kontrol"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Enabled = False
        Me.SimpleButton3.Location = New System.Drawing.Point(16, 17)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 25)
        Me.SimpleButton3.TabIndex = 4
        Me.SimpleButton3.Text = "Tablo Kontrol"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(699, 14)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 25)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(624, 14)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 25)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(792, 337)
        Me.PanelControl3.TabIndex = 2
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.ContextMenu = Me.sorgukisayol
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.HeaderButtons = CType(((DevExpress.XtraTab.TabButtons.Prev Or DevExpress.XtraTab.TabButtons.[Next]) _
            Or DevExpress.XtraTab.TabButtons.[Default]), DevExpress.XtraTab.TabButtons)
        Me.XtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(788, 333)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'sorgukisayol
        '
        Me.sorgukisayol.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem21, Me.MenuItem22})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.MenuItem1.Text = "Çalýþtýr"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Dosyadan sorgu Çaðýr"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Sorguyu Kaydet"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 3
        Me.MenuItem21.Text = "Fazla Tahsilatlarý Göster"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 4
        Me.MenuItem22.Text = "Stoklardan Türkçe Karakterleri Kaldýr"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GroupControl2)
        Me.XtraTabPage1.Controls.Add(Me.GroupControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(763, 323)
        Me.XtraTabPage1.Text = "&Sistem"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.BackColor = System.Drawing.Color.Navy
        Me.GroupControl2.AppearanceCaption.BackColor2 = System.Drawing.Color.Navy
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseBackColor = True
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.Label4)
        Me.GroupControl2.Location = New System.Drawing.Point(8, 121)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(741, 195)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Veritabaný Ýnfo"
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(2, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "info"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.AppearanceCaption.BackColor = System.Drawing.Color.Navy
        Me.GroupControl1.AppearanceCaption.BackColor2 = System.Drawing.Color.Navy
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseBackColor = True
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 3)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(741, 112)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Sistem Ýnfo"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DonemNo:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FirmaNo:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Database :"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.PanelControl5)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(763, 323)
        Me.XtraTabPage2.Text = "&Veritabanlarý"
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.GridControl1)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl5.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(763, 280)
        Me.PanelControl5.TabIndex = 1
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.veritabani_kisayol
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.ds_veritabani
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(759, 276)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2, Me.GridView1})
        '
        'veritabani_kisayol
        '
        Me.veritabani_kisayol.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem20})
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 0
        Me.MenuItem20.Text = "Tablolarý Göster"
        '
        'ds_veritabani
        '
        Me.ds_veritabani.DataSetName = "NewDataSet"
        Me.ds_veritabani.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_veritabani.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "name"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "filename"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "crdate"
        '
        'GridView2
        '
        Me.GridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colname, Me.colfilename, Me.colcrdate})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colname
        '
        Me.colname.Caption = "VeriTabanýAdý"
        Me.colname.FieldName = "name"
        Me.colname.Name = "colname"
        Me.colname.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "name", "Sayý : {0}")})
        Me.colname.Visible = True
        Me.colname.VisibleIndex = 0
        Me.colname.Width = 216
        '
        'colfilename
        '
        Me.colfilename.Caption = "DosyaAdý"
        Me.colfilename.FieldName = "filename"
        Me.colfilename.Name = "colfilename"
        Me.colfilename.Visible = True
        Me.colfilename.VisibleIndex = 1
        Me.colfilename.Width = 657
        '
        'colcrdate
        '
        Me.colcrdate.Caption = "Oluþturulma Tarihi"
        Me.colcrdate.FieldName = "crdate"
        Me.colcrdate.Name = "colcrdate"
        Me.colcrdate.Visible = True
        Me.colcrdate.VisibleIndex = 2
        Me.colcrdate.Width = 232
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'PanelControl4
        '
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(0, 280)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(763, 43)
        Me.PanelControl4.TabIndex = 0
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.GridControl2)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(763, 323)
        Me.XtraTabPage3.Text = "&Tablolar"
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "Table1"
        Me.GridControl2.DataSource = Me.ds_tablo
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView4
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(763, 323)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4, Me.GridView3})
        '
        'ds_tablo
        '
        Me.ds_tablo.DataSetName = "NewDataSet"
        Me.ds_tablo.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tablo.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "firma"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "donem"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "tablo"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "name"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "crdate"
        '
        'GridView4
        '
        Me.GridView4.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView4.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView4.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView4.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colfirma, Me.coldonem, Me.coltablo, Me.colname1, Me.colcrdate1})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.GridControl = Me.GridControl2
        Me.GridView4.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsCustomization.AllowGroup = False
        Me.GridView4.OptionsView.ShowFooter = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.OptionsView.ShowIndicator = False
        '
        'colfirma
        '
        Me.colfirma.Caption = "Firma"
        Me.colfirma.FieldName = "firma"
        Me.colfirma.Name = "colfirma"
        Me.colfirma.Visible = True
        Me.colfirma.VisibleIndex = 0
        Me.colfirma.Width = 76
        '
        'coldonem
        '
        Me.coldonem.Caption = "Dönem"
        Me.coldonem.FieldName = "donem"
        Me.coldonem.Name = "coldonem"
        Me.coldonem.Visible = True
        Me.coldonem.VisibleIndex = 1
        Me.coldonem.Width = 107
        '
        'coltablo
        '
        Me.coltablo.Caption = "Tablo"
        Me.coltablo.FieldName = "tablo"
        Me.coltablo.Name = "coltablo"
        Me.coltablo.Visible = True
        Me.coltablo.VisibleIndex = 2
        Me.coltablo.Width = 117
        '
        'colname1
        '
        Me.colname1.Caption = "TabloAdý"
        Me.colname1.FieldName = "name"
        Me.colname1.Name = "colname1"
        Me.colname1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "name", "Tablo Sayýsý : {0}")})
        Me.colname1.Visible = True
        Me.colname1.VisibleIndex = 3
        Me.colname1.Width = 207
        '
        'colcrdate1
        '
        Me.colcrdate1.Caption = "OluþumTarihi"
        Me.colcrdate1.FieldName = "crdate"
        Me.colcrdate1.Name = "colcrdate1"
        Me.colcrdate1.Visible = True
        Me.colcrdate1.VisibleIndex = 4
        Me.colcrdate1.Width = 220
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.GridControl2
        Me.GridView3.Name = "GridView3"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.PanelControl7)
        Me.XtraTabPage4.Controls.Add(Me.SplitterControl1)
        Me.XtraTabPage4.Controls.Add(Me.PanelControl6)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(763, 323)
        Me.XtraTabPage4.Text = "sorgu &iþlem"
        '
        'PanelControl7
        '
        Me.PanelControl7.Controls.Add(Me.GridControl3)
        Me.PanelControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl7.Location = New System.Drawing.Point(0, 121)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(763, 202)
        Me.PanelControl7.TabIndex = 2
        '
        'GridControl3
        '
        Me.GridControl3.ContextMenu = Me.verikisayol
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(2, 2)
        Me.GridControl3.MainView = Me.GridView6
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(759, 198)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6, Me.GridView5})
        '
        'verikisayol
        '
        Me.verikisayol.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem19, Me.MenuItem15, Me.MenuItem16, Me.MenuItem12, Me.MenuItem5, Me.MenuItem13, Me.MenuItem8, Me.MenuItem9, Me.MenuItem14, Me.MenuItem10, Me.MenuItem11})
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "Görünümü Düzenle"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 1
        Me.MenuItem19.Text = "Görünümü Yazdýr"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 2
        Me.MenuItem15.Text = "Sayýsal Veri Görünümü"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 3
        Me.MenuItem16.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem17, Me.MenuItem18})
        Me.MenuItem16.Text = "Veri Görünümü"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 0
        Me.MenuItem17.Text = "Alt Toplam"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 1
        Me.MenuItem18.Text = "Grup Toplam"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 4
        Me.MenuItem12.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 5
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem7})
        Me.MenuItem5.Text = "Kaydet"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.Text = "Text Dosya"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 1
        Me.MenuItem7.Text = "Excel"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 6
        Me.MenuItem13.Text = "-"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 7
        Me.MenuItem8.Text = "Filtrele"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 8
        Me.MenuItem9.Text = "Gruplandýr"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 9
        Me.MenuItem14.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 10
        Me.MenuItem10.Text = "Satýrlarý Aç"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 11
        Me.MenuItem11.Text = "Satýrlarý Kapat"
        '
        'GridView6
        '
        Me.GridView6.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView6.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView6.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView6.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView6.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView6.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.GridControl = Me.GridControl3
        Me.GridView6.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView6.IndicatorWidth = 35
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsBehavior.Editable = False
        Me.GridView6.OptionsView.ColumnAutoWidth = False
        Me.GridView6.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView6.OptionsView.ShowAutoFilterRow = True
        Me.GridView6.OptionsView.ShowFooter = True
        '
        'GridView5
        '
        Me.GridView5.GridControl = Me.GridControl3
        Me.GridView5.Name = "GridView5"
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterControl1.Location = New System.Drawing.Point(0, 115)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(763, 6)
        Me.SplitterControl1.TabIndex = 1
        Me.SplitterControl1.TabStop = False
        '
        'PanelControl6
        '
        Me.PanelControl6.ContextMenu = Me.sorgukisayol
        Me.PanelControl6.Controls.Add(Me.GroupControl3)
        Me.PanelControl6.Controls.Add(Me.PanelControl8)
        Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl6.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(763, 115)
        Me.PanelControl6.TabIndex = 0
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.cumle)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(662, 111)
        Me.GroupControl3.TabIndex = 5
        Me.GroupControl3.Text = "Sorgu Cümlesi"
        '
        'cumle
        '
        Me.cumle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cumle.Location = New System.Drawing.Point(2, 15)
        Me.cumle.Name = "cumle"
        Me.cumle.Size = New System.Drawing.Size(658, 94)
        Me.cumle.TabIndex = 0
        '
        'PanelControl8
        '
        Me.PanelControl8.Controls.Add(Me.SimpleButton5)
        Me.PanelControl8.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl8.Location = New System.Drawing.Point(664, 2)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(97, 111)
        Me.PanelControl8.TabIndex = 4
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Dock = System.Windows.Forms.DockStyle.Right
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(4, 2)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(91, 107)
        Me.SimpleButton5.TabIndex = 3
        Me.SimpleButton5.Text = "&Çalýþtýr"
        '
        'frm_dbmanager
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(792, 445)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_dbmanager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sorgu Yönetimi"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_veritabani, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tablo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.cumle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl8.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public firma
    Public donem
    Public userno
    Public username
    Public connection
    Public kullanici
    Dim database
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim dr As DataRow
    Private Sub frm_dbmanager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = "FirmaAdý : " & firma & vbTab & vbTab & " FirmaNo : " & firmano & ""
        Label3.Text = "DonemAdý : " & donem & vbTab & vbTab & " DonemNo : " & donemno & ""
        veritabanikontrol()
        dataload_veritabani()
    End Sub
    Private Sub veritabanikontrol()
        database = "MASTER"
        veritabanisorgusu()
        con.Open()
        Dim sonuc As String = ""
        Try
            cmd.CommandText = "USE MASTER SELECT @@version"
            sonuc = cmd.ExecuteScalar
        Catch ex As Exception
            cmd.CommandText = "SELECT @@version"
            sonuc = cmd.ExecuteScalar
        End Try
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT filename from master..sysdatabases where name='" & sDatabaseGenel & "'"
        Dim sonuc2 = cmd.ExecuteScalar
        If sonuc2 = "" Then
            'If XtraMessageBox.Show(Sorgu_sDil("Veritabaný Oluþturulmamýþ ...!" & vbCrLf & "Veri Tabaný Oluþturmak Ýstiyorsanýz [Evet] Butonuna Týklayýnýz...",sDil), MessageBoxButtons.YesNo,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            '    veritabaniolustur()
            'End If
        End If
        Label4.Text = "Veri Tabaný Uygulamasý ;" & vbCrLf & sonuc & vbCrLf & "Veritabaný Klasör ; " & vbCrLf & sonuc2
        con.Close()
        'database = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("GlobalParams").GetValue("DataBase")
        veritabanisorgusu()
        sonuc = Nothing
        sonuc2 = Nothing
    End Sub
    Private Sub veritabanisorgusu()
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = con
    End Sub
    Private Sub veritabaniolustur()
        XtraMessageBox.Show(Sorgu_sDil("Üzgünüm Hazýr Deðil...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.CommandTimeout = False
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        conn.Close()
        Return DS
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub sorgu_tablo(ByVal query As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(ds_tablo, "TABLE1")
        conn.Close()
        cmd = Nothing
        adapter = Nothing
    End Sub
    Private Sub tablo_gozlem()
        Dim tabloadi As String = ""
        Dim x As Integer = 0
        Dim name As String = ""
        Dim tablo As String = ""
        For Each dr In ds_tablo.Tables(0).Rows
            Try
                If dr("name").substring(0, 1) = "F" And IsNumeric(dr("name").substring(1, 4)) = True Then
                    dr("firma") = dr("name").substring(0, 5)
                Else
                    dr("firma") = "Model"
                End If
                If dr("name").substring(5, 1) = "D" And IsNumeric(dr("name").substring(6, 4)) = True Then
                    dr("donem") = dr("name").substring(5, 5)
                Else
                    dr("donem") = ""
                End If
                dr("tablo") = Replace(dr("name"), dr("firma") + dr("donem"), "")
            Catch ex As Exception
                dr("firma") = "Model"
                dr("donem") = ""
                dr("tablo") = dr("name")
            End Try
        Next
    End Sub
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
        cmd.CommandTimeout = False
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
    Private Sub dataload_veritabani()
        ds_veritabani = sorgu("select * from master..sysdatabases where name<>'master'")
        GridControl1.DataSource = ds_veritabani.Tables(0)
        GridControl1.DataMember = Nothing
    End Sub
    Private Sub dataload_tablo(ByVal database As String)
        sorgu_tablo("use " & database & "  select * from sysobjects where xtype='U' order by name")
        tablo_gozlem()
    End Sub
    Private Sub tablo_goster()
        Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
        dataload_tablo(dr(0).ToString)
        XtraTabControl1.SelectedTabPageIndex = 2
        GridControl2.Select()
    End Sub
    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        tablo_goster()
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 1 Then
            GridControl1.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 2 Then
            GridControl2.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 3 Then
            cumle.Select()
        End If
    End Sub
    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        tablo_goster()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        sorgu_calistir()
    End Sub
    Private Sub sorgu_calistir()
        Try
            Dim sonuc
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.CommandText = sorgu_query(cumle.EditValue)
            sonuc = cmd.ExecuteNonQuery()
            con.Close()
            If sonuc = -1 Then
                XtraMessageBox.Show(Sorgu_sDil("Baþarýyla Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                Try
                    GridControl3.DataSource = Nothing
                    GridView6.Columns.Clear()
                    GridControl3.DataSource = islemreport(0, sorgu_query(cumle.Text)).Tables(0)
                    GridControl3.DataMember = Nothing
                    GridView1.BestFitColumns()
                Catch ex As Exception
                End Try
            ElseIf sonuc = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Ýþlem gören Kayýt Sayýsý :", sDil) & sonuc, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf sonuc > 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Ýþlem gören Kayýt Sayýsý :", sDil) & sonuc, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            sonuc = Nothing
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Hatalý Sorgu", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Public Function islemreport(ByVal belgetürü, ByVal cumle) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = cumle
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim DT As New DataTable
        Dim N As Integer = adapter.Fill(DS, "SSREPORT")
        conn.Close()
        Return DS
    End Function
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        'kontrol_tablo2()
        kontrol_tablo3()
    End Sub
    Private Sub kontrol_tablo()
        If openfile.ShowDialog = Windows.Forms.DialogResult.OK Then
            XtraMessageBox.Show(openfile.FileName.ToString, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim dosya = openfile.FileName.ToString
            Dim s
            FileOpen(1, dosya, OpenMode.Input)
            Dim oku() As Byte
            Dim z = "c:\" + sorgu() + ".txt"
            Dim sw As StreamWriter = File.AppendText(z)
            'sw.WriteLine("USE BARKOD")
            Do Until EOF(1)
                s = LineInput(1)
                oku = System.Text.Encoding.UTF8.GetBytes(s)
                s = System.Text.Encoding.UTF8.GetString(oku)
                'MsgBox(sorgu_query(s.ToString))
                sw.WriteLine(sorgu_query(s))
            Loop
            FileClose(1)
            sw.Close()
            osql(z)
            'Dim DOSYA1 As New FileInfo(z)
            'If DOSYA1.Exists Then
            '    DOSYA1.Delete()
            'End If
        End If
    End Sub
    Private Sub kontrol_tablo3()
        kontrol_table("*!FTBLCARI", "TBLCARI")
        kontrol_table("*!FTBLSTOKLAR", "TBLSTOKLAR")
        kontrol_table("*!FTBLBIRIMLEREX", "TBLBIRIMLEREX")
        kontrol_table("*!FTBLKDVGRUPLARI", "TBLKDVGRUPLARI")
        kontrol_table("*!FTBLBANKALAR", "TBLBANKALAR")
        kontrol_table("*!FTBLDEPOLAR", "TBLDEPOLAR")
        kontrol_table("*!FTBLPERSONEL", "TBLPERSONEL")
        kontrol_table("*!F!DTBLSTOKHAREKETLERI", "TBLSTOKHAREKETLERI")
        kontrol_table("*!F!DTBLDEPOENVANTER", "TBLDEPOENVANTER")
        kontrol_table("*!F!DTBLGENELODEME", "TBLGENELODEME")
        kontrol_table("*!F!DTBLKASA", "TBLKASA")
        kontrol_table("*!F!DTBLCARIHAREKETLERI", "TBLCARIHAREKETLERI")
        kontrol_table("*!F!DTBLCARIGENELHAREKET", "TBLCARIGENELHAREKET")
        kontrol_table("*!F!DTBLBANKAHAREKETLERI", "TBLBANKAHAREKETLERI")
        kontrol_table("*!F!DTBLBANKAGENELHAREKET", "TBLBANKAGENELHAREKET")
        kontrol_table("*!F!DTBLBANKGIRBASLIK", "TBLBANKGIRBASLIK")
        kontrol_table("*!F!DTBLBANKGIRHAREKET", "TBLBANKGIRHAREKET")
        kontrol_table("*!F!DTBLBANKCIKBASLIK", "TBLBANKCIKBASLIK")
        kontrol_table("*!F!DTBLBANKCIKHAREKET", "TBLBANKCIKHAREKET")
        kontrol_table("*!F!DTBLCARGIRBASLIK", "TBLCARGIRBASLIK")
        kontrol_table("*!F!DTBLCARGIRHAREKET", "TBLCARGIRHAREKET")
        kontrol_table("*!F!DTBLCARCIKBASLIK", "TBLCARCIKBASLIK")
        kontrol_table("*!F!DTBLCARCIKHAREKET", "TBLCARCIKHAREKET")
        kontrol_table("*!F!DTBLALSIPARISLINKS", "TBLALSIPARISLINKS")
        kontrol_table("*!F!DTBLALSIPLIST", "TBLALSIPLIST")
        kontrol_table("*!F!DTBLVERSIPARISLINKS", "TBLVERSIPARISLINKS")
        kontrol_table("*!F!DTBLVERSIPLIST", "TBLVERSIPLIST")
        kontrol_table("*!F!DTBLCEKGIRIS", "TBLCEKGIRIS")
        kontrol_table("*!F!DTBLCEKCIKIS", "TBLCEKCIKIS")
        kontrol_table("*!F!DTBLCEKHAREKETLERI", "TBLCEKHAREKETLERI")
        kontrol_table("*!F!DTBLCEKPORTFOY", "TBLCEKPORTFOY")
        kontrol_table("*!F!DTBLSAHSICEKPORTFOY", "TBLSAHSICEKPORTFOY")
        kontrol_table("*!F!DTBLSENETGIRIS", "TBLSENETGIRIS")
        kontrol_table("*!F!DTBLSENETCIKIS", "TBLSENETCIKIS")
        kontrol_table("*!F!DTBLSENETHAREKETLERI", "TBLSENETHAREKETLERI")
        kontrol_table("*!F!DTBLSENETPORTFOY", "TBLSENETPORTFOY")
        kontrol_table("*!F!DTBLVISAGIRIS", "TBLVISAGIRIS")
        kontrol_table("*!F!DTBLVISAHAREKETLERI", "TBLVISAHAREKETLERI")
        kontrol_table("*!F!DTBLVISAPORTFOY", "TBLVISAPORTFOY")
        kontrol_table("*!F!DTBLTAKSITGIRIS", "TBLTAKSITGIRIS")
        kontrol_table("*!F!DTBLTAKSITHAREKETLERI", "TBLTAKSITHAREKETLERI")
        kontrol_table("*!F!DTBLTAKSITPORTFOY", "TBLTAKSITPORTFOY")
        kontrol_table("*!FTBLCARIKODTAN", "TBLCARIKODTAN")
        kontrol_table("*!FTBLSTOKKODTAN", "TBLSTOKKODTAN")
        kontrol_table("*!FTBLBELGEKODTAN", "TBLBELGEKODTAN")
        kontrol_table("*!FTBLBANKAKODTAN", "TBLBANKAKODTAN")
        kontrol_table("*!F!DTBLSATFATBASLIK", "TBLBASLIK")
        kontrol_table("*!F!DTBLPESININFO", "TBLPESININFO")
        kontrol_table("*!F!DTBLSATFATHAREKET", "TBLHAREKET")
        kontrol_table("*!F!DTBLALFATBASLIK", "TBLBASLIK")
        kontrol_table("*!F!DTBLALFATHAREKET", "TBLHAREKET")
        kontrol_table("*!F!DTBLALSIPBASLIK", "TBLBASLIK")
        kontrol_table("*!F!DTBLALSIPHAREKET", "TBLHAREKET")
        kontrol_table("*!F!DTBLVERSIPBASLIK", "TBLBASLIK")
        kontrol_table("*!F!DTBLVERSIPHAREKET", "TBLHAREKET")
        kontrol_table("*!F!DTBLALIRSBASLIK", "TBLBASLIK")
        kontrol_table("*!F!DTBLALIRSHAREKET", "TBLHAREKET")
        kontrol_table("*!F!DTBLSATIRSBASLIK", "TBLBASLIK")
        kontrol_table("*!F!DTBLSATIRSHAREKET", "TBLHAREKET")
        kontrol_table("*!F!DTBLVERIRSBASLIK", "TBLBASLIK")
        kontrol_table("*!F!DTBLVERIRSHAREKET", "TBLHAREKET")
        kontrol_table("*!F!DTBLREZERVGIRISHAREKET", "TBLHAREKET")
        kontrol_table("*!F!DTBLREZERVGIRISBASLIK", "TBLBASLIK")
        kontrol_table("*!F!DTBLREZERVCIKISHAREKET", "TBLHAREKET")
        kontrol_table("*!F!DTBLREZERVCIKISBASLIK", "TBLBASLIK")
        kontrol_table("*!F!DTBLSTKGIRBASLIK", "TBLBASLIK")
        kontrol_table("*!F!DTBLSTKGIRHAREKET", "TBLHAREKET")
        kontrol_table("*!F!DTBLSTKCIKBASLIK", "TBLBASLIK")
        kontrol_table("*!F!DTBLSTKCIKHAREKET", "TBLHAREKET")
        kontrol_table("*!F!DTBLDEPOHARBASLIK", "TBLBASLIK")
        kontrol_table("*!F!DTBLDEPOHARHAREKET", "TBLHAREKET")
        kontrol_kolon()
        XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub kontrol_table(ByVal tablo As String, ByVal defination As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Try
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT COUNT(*) FROM " & tablo & "")
            Dim sonuc = cmd.ExecuteNonQuery
        Catch ex As Exception
            cmd.CommandText = sorgu_query("CheckATable '" & defination & "','" & tablo & "',1,1")
            cmd.ExecuteNonQuery()
        End Try
    End Sub
    Private Sub kontrol_tablo2()
        Dim kontrol As String = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!FTBLCARI]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLCARI','*!FTBLCARI',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "Cari Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!FTBLBANKALAR]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLBANKALAR','*!FTBLBANKALAR',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "Banka Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!FTBLSTOKLAR]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLSTOKLAR','*!FTBLSTOKLAR',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "STOK Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!FTBLBIRIMLEREX]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLBIRIMLEREX','*!FTBLBIRIMLEREX',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "Birim Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!FTBLKDVGRUPLARI]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLKDVGRUPLARI','*!FTBLGRUPLARI',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "KDV Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!FTBLDEPOLAR]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLDEPOLAR','*!FTBLDEPOLAR',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "DEPOLAR Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLSTOKHAREKETLERI]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLSTOKHAREKETLERI','*!F!DTBLSTOKHAREKETLERI',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "STOKHAREKETLERI Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLDEPOENVANTER]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLDEPOENVANTER','*!F!DTBLDEPOENVANTER',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "DEPOENVANTER Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLGENELODEME]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar
                XtraMessageBox.Show(sonuc)
                If sonuc <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLGENELODEME','*!F!DTBLGENELODEME',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "GENELODEME Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLKASA]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar
                XtraMessageBox.Show(sonuc)
                If sonuc <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLKASA','*!F!DTBLKASA',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "KASA Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLCARIHAREKETLERI]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLCARIHAREKETLERI','*!F!DTBLCARIHAREKETLERI',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "CARÝHAREKETLERI Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLCARIGENELHAREKET]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLCARIGENELHAREKET','*!F!DTBLCARIGENELHAREKET',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "CARÝGENELHAREKET Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLBANKAHAREKETLERI]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLBANKAHAREKETLERI','*!F!DTBLBANKAHAREKETLERI',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "BANKAHAREKETLERI Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLBANKAGENELHAREKET]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLBANKAGENELHAREKET','*!F!DTBLBANKAGENELHAREKET',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "BANKAGENELHAREKET Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLBANKAGIRBASLIK]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLBANKAGIRBASLIK','*!F!DTBLBANKAGIRBASLIK',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "BANKAGIRBASLIK Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLBANKAGIRHAREKET]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLBANKAGIRHAREKET','*!F!DTBLBANKAGIRHAREKET',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "BANKAGIRHAREKET Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLBANKACIKBASLIK]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLBANKACIKBASLIK','*!F!DTBLBANKACIKBASLIK',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "BANKACIKBASLIK Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLBANKACIKHAREKET]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLBANKACIKHAREKET','*!F!DTBLBANKACIKHAREKET',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "BANKACIKHAREKET Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLCARIGIRBASLIK]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLCARIGIRBASLIK','*!F!DTBLCARIGIRBASLIK',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "CARIGIRBASLIK Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLCARIGIRHAREKET]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLCARIGIRHAREKET','*!F!DTBLCARIGIRHAREKET',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "CARIGIRHAREKET Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLCARICIKBASLIK]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLCARICIKBASLIK','*!F!DTBLCARICIKBASLIK',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "CARICIKBASLIK Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLCARICIKHAREKET]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLCARICIKHAREKET','*!F!DTBLCARICIKHAREKET',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "CARICIKHAREKET Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLALSIPARISLINKS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLALSIPARISLINKS','*!F!DTBLALSIPARISLINKS',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "ALSIPARISLINKS Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLALSIPLIST]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLALSIPLIST','*!F!DTBLALSIPLIST',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "ALSIPLIST Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLVERSIPARISLINKS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLVERSIPARISLINKS','*!F!DTBLVERSIPARISLINKS',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "VERSIPARISLINKS Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLVERSIPLIST]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLALSIPLIST','*!F!DTBLVERSIPLIST',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "VERSIPLIST Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            'ÇEK TABLOLARI
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLCEKGIRIS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLCEKGIRIS','*!F!DTBLCEKGIRIS',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "CEKGIRIS Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLCEKCIKIS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLCEKGIRIS','*!F!DTBLCEKCIKIS',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "CEKCIKIS Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLCERHAREKETLERI]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLCEKHAREKETLERI','*!F!DTBLCEKHAREKETLERI',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "CEKHAREKETLERI Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLCEKPORTFOY]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLCEKPORTFOY','*!F!DTBLCEKPORTFOY',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "CEKPORTFOY Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            ' SENET TABLOLARI
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLSENETGIRIS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLSENETGIRIS','*!F!DTBLSENETGIRIS',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "SENETGIRIS Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLSENETCIKIS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLSENETGIRIS','*!F!DTBLSENETCIKIS',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "SENETCIKIS Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLSENETHAREKETLERI]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLSENETHAREKETLERI','*!F!DTBLSENETHAREKETLERI',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "SENETHAREKETLERI Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLSENETPORTFOY]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLSENETPORTFOY','*!F!DTBLSENETPORTFOY',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "SENETPORTFOY Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            ' TAKSIT TABLOLARI
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLTAKSITGIRIS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLTAKSITGIRIS','*!F!DTBLTAKSITGIRIS',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "TAKSITGIRIS Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLTAKSITHAREKETLERI]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLTAKSITHAREKETLERI','*!F!DTBLTAKSITHAREKETLERI',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "TAKSITHAREKETLERI Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLTAKSITPORTFOY]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLTAKSITPORTFOY','*!F!DTBLTAKSITPORTFOY',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "TAKSITPORTFOY Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            'VÝSA TABLOLARI
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLVISAGIRIS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLVISAGIRIS','*!F!DTBLVISAGIRIS',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "VISAGIRIS Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLVISAHAREKETLERI]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLVISAHAREKETLERI','*!F!DTBLVISAHAREKETLERI',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "VISAHAREKETLERI Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!F!DTBLVISAPORTFOY]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLVISAPORTFOY','*!F!DTBLVISAPORTFOY',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "TAKSITPORTFOY Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            ' KOD TANIMLARI
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!FTBLCARIKODTAN]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLCARIKODTAN','*!FTBLCARIKODTAN',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "CARIKODTAN Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!FTBLSTOKKODTAN]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLSTOKKODTAN','*!FTBLSTOKKODTAN',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "STOKKODTAN Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!FTBLBELGEKODTAN]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLBELGEKODTAN','*!FTBLBELGEKODTAN',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "BELGEKODTAN Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[*!FTBLBANKAKODTAN]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
                Dim sonuc = cmd.ExecuteScalar()
                XtraMessageBox.Show(sonuc)
                If sonuc.ToString <> "" Then
                Else
                    cmd.CommandText = sorgu_query("CheckATable 'TBLBANKAKODTAN','*!FTBLBANKAKODTAN',1,1")
                    cmd.ExecuteNonQuery()
                End If
                'MsgBox(sonuc)
                kontrol += "BANKAKODTAN Tablosu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            belgetipi_kontrol("*!F!DTBLALFAT")
            belgetipi_kontrol("*!F!DTBLSATFAT")
            belgetipi_kontrol("*!F!DTBLALSIP")
            belgetipi_kontrol("*!F!DTBLVERSIP")
            belgetipi_kontrol("*!F!DTBLALIRS")
            belgetipi_kontrol("*!F!DTBLSATIRS")
            belgetipi_kontrol("*!F!DTBLSTKGIR")
            belgetipi_kontrol("*!F!DTBLSTKCIK")
            XtraMessageBox.Show(kontrol)
        Catch ex As Exception
        End Try
        XtraMessageBox.Show(kontrol)
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
    Private Sub belgetipi_kontrol(ByVal belgetipi As String)
        Dim kontrol As String = ""
        Try
            cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[" & belgetipi & "BASLIK]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
            Dim sonuc = cmd.ExecuteScalar()
            'MsgBox(sonuc)
            If sonuc.ToString <> "" Then
            Else
                cmd.CommandText = sorgu_query("CheckATable 'TBLBASLIK','" & belgetipi & "BASLIK',1,1")
                cmd.ExecuteNonQuery()
            End If
            'MsgBox(sonuc)
            kontrol += "CARICIKHAREKET Tablosu Eklendi" & vbCrLf & ""
        Catch ex As Exception
        End Try
        Try
            cmd.CommandText = sorgu_query("(select * from dbo.sysobjects where id = object_id(N'[dbo].[" & belgetipi & "HAREKET]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)")
            Dim sonuc = cmd.ExecuteScalar()
            'MsgBox(sonuc)
            If sonuc.ToString <> "" Then
            Else
                cmd.CommandText = sorgu_query("CheckATable 'TBLBASLIK','" & belgetipi & "HAREKET',1,1")
                cmd.ExecuteNonQuery()
            End If
            'MsgBox(sonuc)
            kontrol += "CARICIKHAREKET Tablosu Eklendi" & vbCrLf & ""
        Catch ex As Exception
        End Try
    End Sub
    Private Sub osql(ByVal dosyas As String)
        Dim z As String = "c:\tablokontrol.bat" 'SAVE.FileName.ToString
        Dim DOSYA As New FileInfo(z)
        If DOSYA.Exists Then
            DOSYA.Delete()
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        sw.WriteLine("@echo off")
        sw.WriteLine("ECHO LUTFEN ISLEMIN BITMESINI BEKLEYINIZ...!")
        sw.WriteLine("ECHO Tablolar Oluþturuluyor")
        sw.WriteLine("C:")
        sw.WriteLine("OSQL /U sa /P -i " & dosyas & "")
        sw.Close()
        Process.Start("c:\tablokontrol.bat")
    End Sub
    Private Function sorgu() As String
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim ds As String
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     NEWID()"
        ds = cmd.ExecuteScalar.ToString
        conn.Close()
        Return UCase(ds)
        cmd = Nothing
        ds = Nothing
    End Function
    Private Sub kontrol_kolon()
        Dim kontrol As String = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Try
            Try
                cmd.CommandText = sorgu_query("ALTER TABLE TBLUSERS ADD [DEPO] [int] NULL CONSTRAINT [DF_TBLUSERS_DEPO] DEFAULT (1)")
                cmd.ExecuteNonQuery()
                kontrol += "Kullanýcý tablosuna [DEPO] kolonu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("ALTER TABLE TBLUSERS ADD [DONEM] [int] NULL CONSTRAINT [DF_TBLUSERS_DONEM] DEFAULT (1)")
                cmd.ExecuteNonQuery()
                kontrol += "Kullanýcý tablosuna [DONEM] kolonu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("ALTER TABLE TBLUSERS ADD [FIRMA] [int] NULL CONSTRAINT [DF_TBLUSERS_DEPO] DEFAULT (100)")
                cmd.ExecuteNonQuery()
                kontrol += "Kullanýcý tablosuna [FIRMA] kolonu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("ALTER TABLE *!FTBLCARI ADD [SATISYAPILMASIN] [bit] NULL")
                cmd.ExecuteNonQuery()
                kontrol += "Cari tablosuna [SATISYAPILMASIN] kolonu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("ALTER TABLE *!FTBLCARI ADD [FIYAT] [int] NULL ")
                cmd.ExecuteNonQuery()
                kontrol += "Cari tablosuna [FIYAT] kolonu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("ALTER TABLE *!FTBLCARI ADD [PERSONELNO] [int] NULL")
                cmd.ExecuteNonQuery()
                kontrol += "Cari tablosuna [PERSONELNO] kolonu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("ALTER TABLE *!FTBLCARI ADD [DEPO] [int] NULL")
                cmd.ExecuteNonQuery()
                kontrol += "Cari tablosuna [DEPO] kolonu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("ALTER TABLE *!F!DTBLDEPOENVANTER ADD [ISLEMIND] [int] NULL ")
                cmd.ExecuteNonQuery()
                kontrol += "DepoEnvanteri  tablosuna [ISLEMIND] kolonu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("ALTER TABLE *!FTBLSTOKLAR ADD [KARORANI] [decimal](28, 8) NULL")
                cmd.ExecuteNonQuery()
                kontrol += "Stoklar tablosuna [KARORANI] kolonu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("ALTER TABLE *!FTBLBIRIMLEREX ADD [BIRIM2] [nvarchar] (50) COLLATE Turkish_CI_AS NULL")
                cmd.ExecuteNonQuery()
                kontrol += "Birimler tablosuna [BIRIM2] kolonu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("ALTER TABLE *!FTBLBIRIMLEREX ADD [CARPANBIRIM2] [decimal](28, 8) NULL")
                cmd.ExecuteNonQuery()
                kontrol += "Birimler tablosuna [CARPANBIRIM2] kolonu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("ALTER TABLE *!FTBLBIRIMLEREX ADD [BIRIM3] [nvarchar] (50) COLLATE Turkish_CI_AS NULL")
                cmd.ExecuteNonQuery()
                kontrol += "Birimler tablosuna [BIRIM3] kolonu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            Try
                cmd.CommandText = sorgu_query("ALTER TABLE *!FTBLBIRIMLEREX ADD [CARPANBIRIM3] [decimal](28, 8) NULL")
                cmd.ExecuteNonQuery()
                kontrol += "Birimler tablosuna [CARPANBIRIM3] kolonu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            'KARPÝN KM1
            Try
                cmd.CommandText = sorgu_query("ALTER TABLE CTBLKARPIN ADD [KMBASLANGIC] [decimal](28, 8) NULL")
                cmd.ExecuteNonQuery()
                kontrol += "Karpin tablosuna [KMBASLANGIC] kolonu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            'KARPÝN KM2
            Try
                cmd.CommandText = sorgu_query("ALTER TABLE CTBLKARPIN ADD [KMBITIS] [decimal](28, 8) NULL")
                cmd.ExecuteNonQuery()
                kontrol += "Karpin tablosuna [KMBITIS] kolonu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            'KARPÝN KM2
            Try
                cmd.CommandText = sorgu_query("ALTER TABLE CTBLKARPIN ADD [KMFARK] [decimal](28, 8) NULL")
                cmd.ExecuteNonQuery()
                kontrol += "Karpin tablosuna [KMFARK] kolonu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            'Peþin Ýnfo Tablosuna Ýzahat
            Try
                cmd.CommandText = sorgu_query("ALTER TABLE *!F!DTBLPESININFO ADD [IZAHAT] [decimal](28, 8) NULL")
                cmd.ExecuteNonQuery()
                kontrol += "PeþinÝnfo tablosuna [IZAHAT] kolonu Eklendi" & vbCrLf & ""
            Catch ex As Exception
            End Try
            XtraMessageBox.Show(kontrol)
        Catch ex As Exception
            XtraMessageBox.Show(kontrol)
        End Try
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
    Private Sub tablokontrol()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        kontrol_kolon()
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        cumle.Text = "Select * from tbOdeme where lOdemeTutar > 1000 "
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        sorgu_calistir()
    End Sub
    Private Sub GridView6_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView6.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView6.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_text()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Text Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Text Dosyalarý(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView6.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        raporla_excel()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        raporla_text()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        GridControl3.ShowPrintPreview()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        If XtraMessageBox.Show(Sorgu_sDil("Stok Kartlarýndaki Açýklamalardaki Türkçe Karakterleri Kaldýrmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim sonuc
            cmd.CommandTimeout = Nothing
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStok set sAciklama = REPLACE(sAciklama,'Ý','I')")
            sonuc = cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStok set sAciklama = REPLACE(sAciklama,'Þ','S')")
            sonuc = cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStok set sAciklama = REPLACE(sAciklama,'Ç','C')")
            sonuc = cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStok set sAciklama = REPLACE(sAciklama,'Ð','G')")
            sonuc = cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStok set sAciklama = REPLACE(sAciklama,'Ö','O')")
            sonuc = cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStok set sAciklama = REPLACE(sAciklama,'Ü','U')")
            sonuc = cmd.ExecuteNonQuery()
            con.Close()
            XtraMessageBox.Show(Sorgu_sDil("Baþarýyla Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
