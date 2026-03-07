Imports System
Imports System.Runtime.InteropServices
Imports FastReport
Imports System.IO
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_stok_etiket
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
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents colnStokID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBeden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMODEL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBarkod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMEVCUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_renk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents colMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_sPrint As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents colFIYAT4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents colsEan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sFiyatTipi4 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sAktifFiyatTipi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents sec_sFiyatTipi3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents sec_sFiyatTipi2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents sec_sFiyatTipi1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colsKavala As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents Koli_barkod As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_etiket))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Koli_barkod = New DevExpress.XtraEditors.CheckEdit()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_sPrint = New DevExpress.XtraEditors.CheckEdit()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.DataSet1 = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnStokID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsMODEL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBarkod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMEVCUT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKavala = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_renk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_sFiyatTipi4 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_sAktifFiyatTipi = New DevExpress.XtraEditors.LookUpEdit()
        Me.sec_sFiyatTipi3 = New DevExpress.XtraEditors.LookUpEdit()
        Me.sec_sFiyatTipi2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.sec_sFiyatTipi1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.Koli_barkod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.sec_sPrint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_sFiyatTipi4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sAktifFiyatTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sFiyatTipi3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sFiyatTipi2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sFiyatTipi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.Koli_barkod)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(816, 74)
        Me.PanelControl1.TabIndex = 2
        '
        'Koli_barkod
        '
        Me.Koli_barkod.Location = New System.Drawing.Point(163, 44)
        Me.Koli_barkod.Name = "Koli_barkod"
        Me.Koli_barkod.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Koli_barkod.Properties.Appearance.Options.UseForeColor = True
        Me.Koli_barkod.Properties.Caption = "Koli Barkod"
        Me.Koli_barkod.Size = New System.Drawing.Size(170, 24)
        Me.Koli_barkod.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(153, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(898, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Stok Etiket Listesi Aþaðýdadýr... Stok Kartlarýndan veya Hareket Fiþlerinden Seçi" &
    "m yaparak Liste oluþturabilir Döküm alabilirsiniz."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton6)
        Me.PanelControl2.Controls.Add(Me.sec_sPrint)
        Me.PanelControl2.Controls.Add(Me.SimpleButton5)
        Me.PanelControl2.Controls.Add(Me.SimpleButton4)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 309)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(816, 79)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(493, 11)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(171, 35)
        Me.SimpleButton6.TabIndex = 7
        Me.SimpleButton6.Text = "&Katlarýný Yazdýr"
        '
        'sec_sPrint
        '
        Me.sec_sPrint.Location = New System.Drawing.Point(10, 47)
        Me.sec_sPrint.Name = "sec_sPrint"
        Me.sec_sPrint.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.sec_sPrint.Properties.Appearance.Options.UseForeColor = True
        Me.sec_sPrint.Properties.Caption = "Varsayýlan Yazýcý"
        Me.sec_sPrint.Size = New System.Drawing.Size(769, 24)
        Me.sec_sPrint.TabIndex = 6
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(333, 11)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(160, 35)
        Me.SimpleButton5.TabIndex = 5
        Me.SimpleButton5.Text = "&Yazdýr"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(173, 11)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(160, 35)
        Me.SimpleButton4.TabIndex = 4
        Me.SimpleButton4.Text = "&Stoklar"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(664, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(13, 11)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(160, 35)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Text = "&Fiþler"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(680, 11)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(560, 11)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 74)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(816, 235)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(812, 231)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(810, 192)
        Me.XtraTabPage1.Text = "Kartlar..."
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_renk})
        Me.GridControl1.Size = New System.Drawing.Size(810, 192)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "STOKNO"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "STOKKODU"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "MALINCINSI"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "RENK"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "BEDEN"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "MODEL"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "BARKOD"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "MEVCUT"
        Me.DataColumn8.DataType = GetType(Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "MIKTAR"
        Me.DataColumn9.DataType = GetType(Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "lFiyat1"
        Me.DataColumn10.DataType = GetType(Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "lFiyat2"
        Me.DataColumn11.DataType = GetType(Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "lFiyat3"
        Me.DataColumn12.DataType = GetType(Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "lFiyat4"
        Me.DataColumn13.DataType = GetType(Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "UZUNLUK"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "lFiyat5"
        Me.DataColumn15.DataType = GetType(Decimal)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnStokID, Me.colsKodu, Me.colsAciklama, Me.colsRenk, Me.colsBeden, Me.colsMODEL, Me.colsBarkod, Me.colMEVCUT, Me.colMIKTAR, Me.colFIYAT1, Me.colFIYAT2, Me.colFIYAT3, Me.colFIYAT4, Me.colsEan, Me.colsKavala, Me.colFIYAT5})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(617, 339, 208, 156)
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colnStokID
        '
        Me.colnStokID.Caption = "Kayýt No"
        Me.colnStokID.FieldName = "STOKNO"
        Me.colnStokID.Name = "colnStokID"
        Me.colnStokID.OptionsColumn.AllowEdit = False
        Me.colnStokID.OptionsColumn.AllowFocus = False
        Me.colnStokID.OptionsColumn.ReadOnly = True
        Me.colnStokID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "nStokID", "{0} Kayýt")})
        Me.colnStokID.Width = 72
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Stok Kodu"
        Me.colsKodu.FieldName = "STOKKODU"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.OptionsColumn.AllowEdit = False
        Me.colsKodu.OptionsColumn.AllowFocus = False
        Me.colsKodu.OptionsColumn.ReadOnly = True
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 0
        Me.colsKodu.Width = 130
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Stok Adý"
        Me.colsAciklama.FieldName = "MALINCINSI"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.OptionsColumn.AllowEdit = False
        Me.colsAciklama.OptionsColumn.AllowFocus = False
        Me.colsAciklama.OptionsColumn.ReadOnly = True
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 1
        Me.colsAciklama.Width = 172
        '
        'colsRenk
        '
        Me.colsRenk.Caption = "Renk"
        Me.colsRenk.FieldName = "RENK"
        Me.colsRenk.Name = "colsRenk"
        Me.colsRenk.OptionsColumn.AllowEdit = False
        Me.colsRenk.OptionsColumn.AllowFocus = False
        Me.colsRenk.OptionsColumn.ReadOnly = True
        Me.colsRenk.Width = 82
        '
        'colsBeden
        '
        Me.colsBeden.Caption = "Beden"
        Me.colsBeden.FieldName = "BEDEN"
        Me.colsBeden.Name = "colsBeden"
        Me.colsBeden.OptionsColumn.AllowEdit = False
        Me.colsBeden.OptionsColumn.AllowFocus = False
        Me.colsBeden.OptionsColumn.ReadOnly = True
        Me.colsBeden.Width = 82
        '
        'colsMODEL
        '
        Me.colsMODEL.Caption = "ModelNo"
        Me.colsMODEL.FieldName = "MODEL"
        Me.colsMODEL.Name = "colsMODEL"
        Me.colsMODEL.OptionsColumn.AllowEdit = False
        Me.colsMODEL.OptionsColumn.AllowFocus = False
        Me.colsMODEL.OptionsColumn.ReadOnly = True
        Me.colsMODEL.Width = 109
        '
        'colsBarkod
        '
        Me.colsBarkod.Caption = "Barkod"
        Me.colsBarkod.FieldName = "BARKOD"
        Me.colsBarkod.Name = "colsBarkod"
        Me.colsBarkod.OptionsColumn.AllowEdit = False
        Me.colsBarkod.OptionsColumn.AllowFocus = False
        Me.colsBarkod.OptionsColumn.ReadOnly = True
        Me.colsBarkod.Visible = True
        Me.colsBarkod.VisibleIndex = 2
        Me.colsBarkod.Width = 169
        '
        'colMEVCUT
        '
        Me.colMEVCUT.Caption = "Mevcut"
        Me.colMEVCUT.DisplayFormat.FormatString = "#,0.##"
        Me.colMEVCUT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMEVCUT.FieldName = "Mevcut"
        Me.colMEVCUT.Name = "colMEVCUT"
        Me.colMEVCUT.OptionsColumn.AllowEdit = False
        Me.colMEVCUT.OptionsColumn.AllowFocus = False
        Me.colMEVCUT.OptionsColumn.ReadOnly = True
        Me.colMEVCUT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Mevcut", "{0:#,0.##}")})
        Me.colMEVCUT.Width = 86
        '
        'colMIKTAR
        '
        Me.colMIKTAR.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMIKTAR.AppearanceHeader.Options.UseFont = True
        Me.colMIKTAR.Caption = "Miktar"
        Me.colMIKTAR.DisplayFormat.FormatString = "#,0.##"
        Me.colMIKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMIKTAR.FieldName = "MIKTAR"
        Me.colMIKTAR.Name = "colMIKTAR"
        Me.colMIKTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", "{0:#,0.##}")})
        Me.colMIKTAR.Visible = True
        Me.colMIKTAR.VisibleIndex = 3
        Me.colMIKTAR.Width = 83
        '
        'colFIYAT1
        '
        Me.colFIYAT1.Caption = "1. Satýþ Fiyatý"
        Me.colFIYAT1.DisplayFormat.FormatString = "#,0.00"
        Me.colFIYAT1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT1.FieldName = "lFiyat1"
        Me.colFIYAT1.Name = "colFIYAT1"
        Me.colFIYAT1.Visible = True
        Me.colFIYAT1.VisibleIndex = 4
        Me.colFIYAT1.Width = 83
        '
        'colFIYAT2
        '
        Me.colFIYAT2.Caption = "2. Satýþ Fiyatý"
        Me.colFIYAT2.DisplayFormat.FormatString = "#,0.00"
        Me.colFIYAT2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT2.FieldName = "lFiyat2"
        Me.colFIYAT2.Name = "colFIYAT2"
        Me.colFIYAT2.Visible = True
        Me.colFIYAT2.VisibleIndex = 5
        Me.colFIYAT2.Width = 83
        '
        'colFIYAT3
        '
        Me.colFIYAT3.Caption = "3. Satýþ Fiyatý"
        Me.colFIYAT3.DisplayFormat.FormatString = "#,0.00"
        Me.colFIYAT3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT3.FieldName = "lFiyat3"
        Me.colFIYAT3.Name = "colFIYAT3"
        Me.colFIYAT3.Visible = True
        Me.colFIYAT3.VisibleIndex = 6
        Me.colFIYAT3.Width = 87
        '
        'colFIYAT4
        '
        Me.colFIYAT4.Caption = "4. Satýþ Fiyatý"
        Me.colFIYAT4.DisplayFormat.FormatString = "#,0.00"
        Me.colFIYAT4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT4.FieldName = "lFiyat4"
        Me.colFIYAT4.Name = "colFIYAT4"
        Me.colFIYAT4.Visible = True
        Me.colFIYAT4.VisibleIndex = 7
        '
        'colsEan
        '
        Me.colsEan.AppearanceCell.BackColor = System.Drawing.Color.Silver
        Me.colsEan.AppearanceCell.Options.UseBackColor = True
        Me.colsEan.Caption = "Uzunluk"
        Me.colsEan.FieldName = "UZUNLUK"
        Me.colsEan.Name = "colsEan"
        Me.colsEan.OptionsColumn.ReadOnly = True
        Me.colsEan.UnboundExpression = "Len(trim(BARKOD))"
        '
        'colsKavala
        '
        Me.colsKavala.Caption = "Kavala"
        Me.colsKavala.FieldName = "sKavala"
        Me.colsKavala.Name = "colsKavala"
        Me.colsKavala.OptionsColumn.AllowEdit = False
        Me.colsKavala.OptionsColumn.AllowFocus = False
        Me.colsKavala.OptionsColumn.ReadOnly = True
        '
        'colFIYAT5
        '
        Me.colFIYAT5.Caption = "5. Satýþ Fiyatý"
        Me.colFIYAT5.FieldName = "lFiyat5"
        Me.colFIYAT5.Name = "colFIYAT5"
        Me.colFIYAT5.Visible = True
        Me.colFIYAT5.VisibleIndex = 8
        '
        'sec_renk
        '
        Me.sec_renk.AutoHeight = False
        Me.sec_renk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_renk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sRenkAdi", "Renk")})
        Me.sec_renk.DisplayMember = "sRenkAdi"
        Me.sec_renk.Name = "sec_renk"
        Me.sec_renk.NullText = ""
        Me.sec_renk.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_renk.ShowFooter = False
        Me.sec_renk.ShowHeader = False
        Me.sec_renk.ShowLines = False
        Me.sec_renk.ValueMember = "sRenk"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GroupControl1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(810, 192)
        Me.XtraTabPage2.Text = "Fiyat Tipleri"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl15)
        Me.GroupControl1.Controls.Add(Me.sec_sFiyatTipi4)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.sec_sAktifFiyatTipi)
        Me.GroupControl1.Controls.Add(Me.sec_sFiyatTipi3)
        Me.GroupControl1.Controls.Add(Me.sec_sFiyatTipi2)
        Me.GroupControl1.Controls.Add(Me.sec_sFiyatTipi1)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(458, 207)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Normal Fiyat"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl15.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl15.Location = New System.Drawing.Point(40, 123)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(58, 19)
        Me.LabelControl15.TabIndex = 90
        Me.LabelControl15.Text = "4. Fiyat:"
        '
        'sec_sFiyatTipi4
        '
        Me.sec_sFiyatTipi4.EnterMoveNextControl = True
        Me.sec_sFiyatTipi4.Location = New System.Drawing.Point(115, 123)
        Me.sec_sFiyatTipi4.Name = "sec_sFiyatTipi4"
        Me.sec_sFiyatTipi4.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sFiyatTipi4.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sFiyatTipi4.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_sFiyatTipi4.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_sFiyatTipi4.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_sFiyatTipi4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sFiyatTipi4.Properties.DisplayMember = "sAciklama"
        Me.sec_sFiyatTipi4.Properties.NullText = "[FiyatTipi]"
        Me.sec_sFiyatTipi4.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_sFiyatTipi4.Properties.ValueMember = "sFiyatTipi"
        Me.sec_sFiyatTipi4.Size = New System.Drawing.Size(309, 26)
        Me.sec_sFiyatTipi4.TabIndex = 82
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(-5, 151)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(104, 19)
        Me.LabelControl4.TabIndex = 87
        Me.LabelControl4.Text = "Aktif FiyatTipi:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(40, 94)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(58, 19)
        Me.LabelControl3.TabIndex = 86
        Me.LabelControl3.Text = "3. Fiyat:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(40, 66)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(58, 19)
        Me.LabelControl1.TabIndex = 85
        Me.LabelControl1.Text = "2. Fiyat:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(40, 37)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(58, 19)
        Me.LabelControl2.TabIndex = 84
        Me.LabelControl2.Text = "1. Fiyat:"
        '
        'sec_sAktifFiyatTipi
        '
        Me.sec_sAktifFiyatTipi.EnterMoveNextControl = True
        Me.sec_sAktifFiyatTipi.Location = New System.Drawing.Point(115, 151)
        Me.sec_sAktifFiyatTipi.Name = "sec_sAktifFiyatTipi"
        Me.sec_sAktifFiyatTipi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sAktifFiyatTipi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sAktifFiyatTipi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_sAktifFiyatTipi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_sAktifFiyatTipi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_sAktifFiyatTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sAktifFiyatTipi.Properties.DisplayMember = "sAciklama"
        Me.sec_sAktifFiyatTipi.Properties.NullText = "[FiyatTipi]"
        Me.sec_sAktifFiyatTipi.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_sAktifFiyatTipi.Properties.ValueMember = "sFiyatTipi"
        Me.sec_sAktifFiyatTipi.Size = New System.Drawing.Size(309, 26)
        Me.sec_sAktifFiyatTipi.TabIndex = 83
        '
        'sec_sFiyatTipi3
        '
        Me.sec_sFiyatTipi3.EnterMoveNextControl = True
        Me.sec_sFiyatTipi3.Location = New System.Drawing.Point(115, 94)
        Me.sec_sFiyatTipi3.Name = "sec_sFiyatTipi3"
        Me.sec_sFiyatTipi3.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sFiyatTipi3.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sFiyatTipi3.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_sFiyatTipi3.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_sFiyatTipi3.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_sFiyatTipi3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sFiyatTipi3.Properties.DisplayMember = "sAciklama"
        Me.sec_sFiyatTipi3.Properties.NullText = "[FiyatTipi]"
        Me.sec_sFiyatTipi3.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_sFiyatTipi3.Properties.ValueMember = "sFiyatTipi"
        Me.sec_sFiyatTipi3.Size = New System.Drawing.Size(309, 26)
        Me.sec_sFiyatTipi3.TabIndex = 81
        '
        'sec_sFiyatTipi2
        '
        Me.sec_sFiyatTipi2.EnterMoveNextControl = True
        Me.sec_sFiyatTipi2.Location = New System.Drawing.Point(115, 66)
        Me.sec_sFiyatTipi2.Name = "sec_sFiyatTipi2"
        Me.sec_sFiyatTipi2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sFiyatTipi2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sFiyatTipi2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_sFiyatTipi2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_sFiyatTipi2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_sFiyatTipi2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sFiyatTipi2.Properties.DisplayMember = "sAciklama"
        Me.sec_sFiyatTipi2.Properties.NullText = "[FiyatTipi]"
        Me.sec_sFiyatTipi2.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_sFiyatTipi2.Properties.ValueMember = "sFiyatTipi"
        Me.sec_sFiyatTipi2.Size = New System.Drawing.Size(309, 26)
        Me.sec_sFiyatTipi2.TabIndex = 80
        '
        'sec_sFiyatTipi1
        '
        Me.sec_sFiyatTipi1.EnterMoveNextControl = True
        Me.sec_sFiyatTipi1.Location = New System.Drawing.Point(115, 37)
        Me.sec_sFiyatTipi1.Name = "sec_sFiyatTipi1"
        Me.sec_sFiyatTipi1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sFiyatTipi1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sFiyatTipi1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_sFiyatTipi1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_sFiyatTipi1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_sFiyatTipi1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sFiyatTipi1.Properties.DisplayMember = "sAciklama"
        Me.sec_sFiyatTipi1.Properties.NullText = "[FiyatTipi]"
        Me.sec_sFiyatTipi1.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_sFiyatTipi1.Properties.ValueMember = "sFiyatTipi"
        Me.sec_sFiyatTipi1.Size = New System.Drawing.Size(309, 26)
        Me.sec_sFiyatTipi1.TabIndex = 79
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem15, Me.MenuItem16, Me.MenuItem1, Me.MenuItem28, Me.MenuItem30, Me.MenuItem27, Me.MenuItem2, Me.MenuItem3, Me.MenuItem26, Me.MenuItem21, Me.MenuItem19, Me.MenuItem12, Me.MenuItem29, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem20, Me.MenuItem13, Me.MenuItem7, Me.MenuItem8, Me.MenuItem9, Me.MenuItem14, Me.MenuItem31, Me.MenuItem10, Me.MenuItem11, Me.MenuItem18, Me.MenuItem17})
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 0
        Me.MenuItem15.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem15.Text = "Ara"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 1
        Me.MenuItem16.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 2
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem1.Text = "Stoklardan Ekle"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 3
        Me.MenuItem28.Text = "Yeni Açýlan Stoklardan Ekle"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 4
        Me.MenuItem30.Text = "Fiyatý Deðiþen Stoklardan Ekle"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 5
        Me.MenuItem27.Shortcut = System.Windows.Forms.Shortcut.ShiftIns
        Me.MenuItem27.Text = "Stoklardan Ekle Envanterli"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 6
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlIns
        Me.MenuItem2.Text = "Fiþlerden Ekle"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 7
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem3.Text = "Satýr Sil"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 8
        Me.MenuItem26.Text = "-"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 9
        Me.MenuItem21.Text = "Deðer Yay"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 10
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem19.Text = "Listeyi Temizle"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 11
        Me.MenuItem12.Text = "-"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 12
        Me.MenuItem29.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem29.Text = "Stok Kartý"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 13
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItem4.Text = "Fiyat Düzenle"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 14
        Me.MenuItem5.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem5.Text = "Envanter"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 15
        Me.MenuItem6.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem6.Text = "Model Envanter"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 16
        Me.MenuItem20.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem22, Me.MenuItem23, Me.MenuItem24, Me.MenuItem25})
        Me.MenuItem20.Text = "Etiket"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 0
        Me.MenuItem22.Text = "Etiket Önizle"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 1
        Me.MenuItem23.Text = "Etiket Dizayn"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 2
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.CtrlE
        Me.MenuItem24.Text = "Etiket Yazdýr"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 3
        Me.MenuItem25.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem25.Text = "Etiket Direkt Yazdýr"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 17
        Me.MenuItem13.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 18
        Me.MenuItem7.Text = "Görünümü Düzenle"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 19
        Me.MenuItem8.Text = "Görünümü Kaydet"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 20
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem9.Text = "Görünümü Yazdýr"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 21
        Me.MenuItem14.Text = "-"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 22
        Me.MenuItem31.Text = "Hýzlý Filtre"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 23
        Me.MenuItem10.Text = "Filtrele"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 24
        Me.MenuItem11.Text = "Gruplandýr"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 25
        Me.MenuItem18.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 26
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem17.Text = "Tam Ekran"
        '
        'ps
        '
        Me.ps.Links.AddRange(New Object() {Me.printlink1})
        '
        'printlink1
        '
        Me.printlink1.Component = Me.GridControl1
        '
        '
        '
        Me.printlink1.ImageCollection.ImageStream = CType(resources.GetObject("printlink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink1.Owner = Nothing
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"", "Stok Etiket Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"[User Name]", "Stok Ýþlemleri", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10})
        Me.BarManager1.MaxItemId = 10
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Satýr Ekle"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Fislerden Ekle"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Envanterden Ekle"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Satýr Sil"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Listeyi Temizle"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Fiyat Duzenle"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Envanter"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Yazdýr"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "DirektYazdýr"
        Me.BarButtonItem10.Id = 9
        Me.BarButtonItem10.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem10.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(816, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 388)
        Me.barDockControlBottom.Size = New System.Drawing.Size(816, 30)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 388)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(816, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 388)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Ara"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'frm_stok_etiket
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 20)
        Me.ClientSize = New System.Drawing.Size(816, 418)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_etiket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Etiket Listesi"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.Koli_barkod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.sec_sPrint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_sFiyatTipi4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sAktifFiyatTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sFiyatTipi3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sFiyatTipi2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sFiyatTipi1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public status As Boolean
    Public connection
    Public firmano
    Public donemno
    Public stokno
    Public userno
    Public kullanici
    Public stokkodu
    Public malincinsi
    Public barkod
    Public muadilbarkod
    Public birim
    Public kod1
    Public kod2
    Public kod3
    Public kod4
    Public kod5
    Public kod6
    Public kod7
    Public kod8
    Public kod9
    Public kod10
    Public satisfiyati1
    Public satisfiyati2
    Public satisfiyati3
    Public istihbarat
    Public kayitno
    Public aktif
    Public sil As Boolean = False
    Public gelismis
    Public qkayitno
    Public qstokkodu
    Public qmalincinsi
    Public qbarkod
    Public qmuadilbarkod
    Public qkod1
    Public qkod2
    Public qkod3
    Public qkod4
    Public qkod5
    Public qkod6
    Public qkod7
    Public qkod8
    Public qkod9
    Public qkod10
    Public qistihbarat
    Public qbirim
    Public qdepo
    Public qsatisfiyati1
    Public qsatisfiyati2
    Public qsatisfiyati3
    Public qaktif
    Public qgelismis
    Dim dr As DataRow
    Dim count
    Public mevcut
    Public yeni
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Public frf_islem As String = "mektup"
    Dim sPrint As String = ""
    Public sFiyat1 As String = "1"
    Public sFiyat2 As String = "2"
    Public sFiyat3 As String = "3"
    Public sFiyat4 As String = "4"
    Public sAktifFiyatTipi As String = "1"
    Dim ds_tbFiyatTipi As DataSet
    Private Sub frm_stok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        colFIYAT1.Caption = sFiyat1Aciklama
        colFIYAT2.Caption = sFiyat2Aciklama
        colFIYAT3.Caption = sFiyat3Aciklama
        colFIYAT4.Caption = sFiyat4Aciklama
        colFIYAT5.Caption = sFiyat5Aciklama
        Dim ara As String = ""
        Try
            ara = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Microsoft").OpenSubKey("Windows NT").OpenSubKey("CurrentVersion").OpenSubKey("Windows").GetValue("Device").ToString()
        Catch ex As Exception
            ara = ""
        End Try
        'MsgBox(ara)
        Dim adi As String = ""
        Dim soyadi As String = ""
        Dim x
        If CStr(ara.ToString) <> "" Then
            x = (ara).IndexOf(",", 1, (ara.Length - 1))
            If x = -1 Then
                adi = ara
            Else
                adi = (ara).Substring(0, x)
                soyadi = (ara).Substring((x + 1), (ara).Length - (x + 1))
                If IsNumeric(ara) Then
                Else
                End If
            End If
        End If
        'MsgBox(Sorgu_sDil("Adi :" & vbTab & adi & vbCrLf & "Soyadi :" & vbTab & soyadi)
        'MsgBox(adi)
        sPrint = adi
        sec_sPrint.Text = sPrint
        'frx.PrintOptions.Printer = adi
        'Me.Hide()
        'If status = False Then
        '    count = ""
        '    Dim frm As New frm_stok_ara
        '    frm.connection = connection
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    If frm.ShowDialog(Me) = DialogResult.OK Then
        '        kayitno = frm.ind
        '        stokkodu = frm.stokkodu
        '        malincinsi = frm.malincinsi
        '        barkod = frm.barkod
        '        muadilbarkod = frm.muadilbarkod
        '        kod1 = frm.kod1
        '        kod2 = frm.kod2
        '        kod3 = frm.kod3
        '        kod4 = frm.kod4
        '        kod5 = frm.kod5
        '        kod6 = frm.kod6
        '        kod7 = frm.kod7
        '        kod8 = frm.kod8
        '        kod9 = frm.kod9
        '        kod10 = frm.kod10
        '        birim = frm.birim
        '        satisfiyati1 = frm.satisfiyati1
        '        satisfiyati2 = frm.satisfiyati2
        '        satisfiyati3 = frm.satisfiyati3
        '        istihbarat = frm.istihbarat
        '        aktif = frm.aktif
        '        gelismis = frm.gelismis
        '        qkayitno = frm.qind
        '        qstokkodu = frm.qstokkodu
        '        qmalincinsi = frm.qmalincinsi
        '        qbarkod = frm.qbarkod
        '        qmuadilbarkod = frm.qmuadilbarkod
        '        qkod1 = frm.qkod1
        '        qkod2 = frm.qkod2
        '        qkod3 = frm.qkod3
        '        qkod4 = frm.qkod4
        '        qkod5 = frm.qkod5
        '        qkod6 = frm.qkod6
        '        qkod7 = frm.qkod7
        '        qkod8 = frm.qkod8
        '        qkod9 = frm.qkod9
        '        qkod10 = frm.qkod10
        '        qbirim = frm.qbirim
        '        qsatisfiyati1 = frm.qsatisfiyati1
        '        qsatisfiyati2 = frm.qsatisfiyati2
        '        qsatisfiyati3 = frm.qsatisfiyati3
        '        qistihbarat = frm.qistihbarat
        '        qaktif = frm.qaktif
        '        mevcut = frm.mevcut
        '        yeni = frm.yeni
        '        qgelismis = frm.qgelismis
        '        Me.Show()
        '        frm.stokkodu = Nothing
        '        frm.malincinsi = Nothing
        '        frm.barkod = Nothing
        '        frm.muadilbarkod = Nothing
        '        frm.birim = Nothing
        '        frm.kod1 = Nothing
        '        frm.kod2 = Nothing
        '        frm.kod3 = Nothing
        '        frm.kod4 = Nothing
        '        frm.kod5 = Nothing
        '        frm.kod6 = Nothing
        '        frm.kod7 = Nothing
        '        frm.kod8 = Nothing
        '        frm.kod9 = Nothing
        '        frm.kod10 = Nothing
        '        frm.satisfiyati1 = Nothing
        '        frm.satisfiyati2 = Nothing
        '        frm.satisfiyati3 = Nothing
        '        frm.istihbarat = Nothing
        '        frm.ind = Nothing
        '        frm.qind = Nothing
        '        frm.qstokkodu = Nothing
        '        frm.qmalincinsi = Nothing
        '        frm.qbarkod = Nothing
        '        frm.qmuadilbarkod = Nothing
        '        frm.qkod1 = Nothing
        '        frm.qkod2 = Nothing
        '        frm.qkod3 = Nothing
        '        frm.qkod4 = Nothing
        '        frm.qkod5 = Nothing
        '        frm.qkod6 = Nothing
        '        frm.qkod7 = Nothing
        '        frm.qkod8 = Nothing
        '        frm.qkod9 = Nothing
        '        frm.qkod10 = Nothing
        '        frm.qistihbarat = Nothing
        '        frm.qbirim = Nothing
        '        frm.qdepo = Nothing
        '        frm.qsatisfiyati1 = Nothing
        '        frm.qsatisfiyati2 = Nothing
        '        frm.qsatisfiyati3 = Nothing
        '        frm.PanelControl1.Dispose()
        '        frm.PanelControl1 = Nothing
        '        frm.PanelControl2.Dispose()
        '        frm.PanelControl2 = Nothing
        '        frm.PanelControl3.Dispose()
        '        frm.PanelControl3 = Nothing
        '        frm.PictureBox1.Dispose()
        '        frm.PictureBox1 = Nothing
        '        frm.SimpleButton1 = Nothing
        '        frm.SimpleButton2 = Nothing
        '        frm.DataSet1.Clear()
        '        frm.DataSet1.Dispose()
        '        frm.DataSet1 = Nothing
        '        frm.VGridControl1.Dispose()
        '        frm.VGridControl1 = Nothing
        '        frm.Dispose()
        '        frm = Nothing
        '        dataload()
        '    Else
        '        frm.stokkodu = Nothing
        '        frm.malincinsi = Nothing
        '        frm.barkod = Nothing
        '        frm.muadilbarkod = Nothing
        '        frm.birim = Nothing
        '        frm.kod1 = Nothing
        '        frm.kod2 = Nothing
        '        frm.kod3 = Nothing
        '        frm.kod4 = Nothing
        '        frm.kod5 = Nothing
        '        frm.kod6 = Nothing
        '        frm.kod7 = Nothing
        '        frm.kod8 = Nothing
        '        frm.kod9 = Nothing
        '        frm.kod10 = Nothing
        '        frm.satisfiyati1 = Nothing
        '        frm.satisfiyati2 = Nothing
        '        frm.satisfiyati3 = Nothing
        '        frm.istihbarat = Nothing
        '        frm.ind = Nothing
        '        frm.qind = Nothing
        '        frm.qstokkodu = Nothing
        '        frm.qmalincinsi = Nothing
        '        frm.qbarkod = Nothing
        '        frm.qmuadilbarkod = Nothing
        '        frm.qkod1 = Nothing
        '        frm.qkod2 = Nothing
        '        frm.qkod3 = Nothing
        '        frm.qkod4 = Nothing
        '        frm.qkod5 = Nothing
        '        frm.qkod6 = Nothing
        '        frm.qkod7 = Nothing
        '        frm.qkod8 = Nothing
        '        frm.qkod9 = Nothing
        '        frm.qkod10 = Nothing
        '        frm.qistihbarat = Nothing
        '        frm.qbirim = Nothing
        '        frm.qdepo = Nothing
        '        frm.qsatisfiyati1 = Nothing
        '        frm.qsatisfiyati2 = Nothing
        '        frm.qsatisfiyati3 = Nothing
        '        frm.PanelControl1.Dispose()
        '        frm.PanelControl1 = Nothing
        '        frm.PanelControl2.Dispose()
        '        frm.PanelControl2 = Nothing
        '        frm.PanelControl3.Dispose()
        '        frm.PanelControl3 = Nothing
        '        frm.PictureBox1.Dispose()
        '        frm.PictureBox1 = Nothing
        '        frm.SimpleButton1 = Nothing
        '        frm.SimpleButton2 = Nothing
        '        frm.DataSet1.Clear()
        '        frm.DataSet1.Dispose()
        '        frm.DataSet1 = Nothing
        '        frm.VGridControl1.Dispose()
        '        frm.VGridControl1 = Nothing
        '        frm.Dispose()
        '        frm = Nothing
        '        Me.Close()
        '    End If
        'Else
        '    count = "TOP 1000"
        '    dataload()
        'End If
        ''stok_islemleri.firmano = firmano
        ''stok_islemleri.donemno = donemno
        ''stok_islemleri.connection = connection
        'If GridView1.RowCount = 0 Then
        'ElseIf GridView1.RowCount = 1 Then
        '    'If sil = False Then
        '    '    sorgu()
        '    'End If
        'Else
        'End If
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        dataload_tbFiyatTipi()
    End Sub
    Private Sub dataload_tbFiyatTipi()
        ds_tbFiyatTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     RTRIM(sFiyatTipi) as sFiyatTipi,sAciklama FROM         tbFiyatTipi where (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%')"))
        sec_sFiyatTipi1.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sFiyatTipi2.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sFiyatTipi3.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sFiyatTipi4.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sAktifFiyatTipi.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sFiyatTipi1.EditValue = sFiyat1
        sec_sFiyatTipi2.EditValue = sFiyat2
        sec_sFiyatTipi3.EditValue = sFiyat3
        sec_sFiyatTipi4.EditValue = sFiyat4
        sec_sAktifFiyatTipi.EditValue = sAktifFiyatTipi
    End Sub
    Private Sub guncelle_fiyattipi()
        sFiyat1 = sec_sFiyatTipi1.EditValue
        sFiyat2 = sec_sFiyatTipi2.EditValue
        sFiyat3 = sec_sFiyatTipi3.EditValue
        sFiyat4 = sec_sFiyatTipi4.EditValue
        sAktifFiyatTipi = sec_sAktifFiyatTipi.EditValue
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        Try
        Catch ex As Exception
        End Try
        Try
            If nFontSize > 0 Then
                Dim sayi As Single = nFontSize
                GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                'VGrid_Baslik.Appearance.RecordValue.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                sayi = Nothing
            End If
        Catch ex As Exception
        End Try
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim tab As Object
        For Each tab In XtraTabControl1.TabPages
            tab.text = Sorgu_sDil(tab.text, sDil)
        Next
        Dim itm
        For Each itm In ContextMenu1.MenuItems
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        SimpleButton4.Text = Sorgu_sDil(SimpleButton4.Text, sDil)
        SimpleButton5.Text = Sorgu_sDil(SimpleButton5.Text, sDil)
        SimpleButton6.Text = Sorgu_sDil(SimpleButton6.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "")
    End Sub
    Private Sub dataload_depo()
        sec_renk.DataSource = sorgu(sorgu_query("SELECT * FROM tbRenk")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Function sorgu(ByVal query As String, Optional ByVal sTable As String = "TABLE1") As DataSet
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, sTable)
        conn.Close()
        Return DS
    End Function
    Private Sub degeryay(ByVal columnkriter As String)
        'kl = CType(Me.BindingContext(DataView1), CurrencyManager)
        Dim durum
        Dim sayi = GridView1.RowCount  'kl.Count
        Dim satir = GridView1.FocusedRowHandle 'kl.Position
        Dim TOPLAM = sayi - GridView1.FocusedRowHandle 'kl.Position
        Dim Ý As Integer
        Ý = 0
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        durum = dr("" & columnkriter & "")
        'kl.Position += 1
        For Ý = 1 To TOPLAM
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.BeginEdit()
            dr("" & columnkriter & "") = durum
            dr.EndEdit()
            hesapla()
            'maliyetkontrol()
            GridView1.FocusedRowHandle += 1
        Next
        'kl.Position = satir
        GridView1.FocusedRowHandle = satir
        GridView1.GetDataRow(satir)
        durum = Nothing
        sayi = Nothing
        satir = Nothing
        Ý = Nothing
    End Sub
    Private Sub ara()
        Dim frm As New frm_stok_ara
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            kayitno = frm.ind
            stokkodu = frm.stokkodu
            malincinsi = frm.malincinsi
            barkod = frm.barkod
            muadilbarkod = frm.muadilbarkod
            kod1 = frm.kod1
            kod2 = frm.kod2
            kod3 = frm.kod3
            kod4 = frm.kod4
            kod5 = frm.kod5
            kod6 = frm.kod6
            kod7 = frm.kod7
            kod8 = frm.kod8
            kod9 = frm.kod9
            kod10 = frm.kod10
            birim = frm.birim
            satisfiyati1 = frm.satisfiyati1
            satisfiyati2 = frm.satisfiyati2
            satisfiyati3 = frm.satisfiyati3
            istihbarat = frm.istihbarat
            aktif = frm.aktif
            gelismis = frm.gelismis
            qkayitno = frm.qind
            qstokkodu = frm.qstokkodu
            qmalincinsi = frm.qmalincinsi
            qbarkod = frm.qbarkod
            qmuadilbarkod = frm.qmuadilbarkod
            qkod1 = frm.qkod1
            qkod2 = frm.qkod2
            qkod3 = frm.qkod3
            qkod4 = frm.qkod4
            qkod5 = frm.qkod5
            qkod6 = frm.qkod6
            qkod7 = frm.qkod7
            qkod8 = frm.qkod8
            qkod9 = frm.qkod9
            qkod10 = frm.qkod10
            qbirim = frm.qbirim
            qsatisfiyati1 = frm.qsatisfiyati1
            qsatisfiyati2 = frm.qsatisfiyati2
            qsatisfiyati3 = frm.qsatisfiyati3
            qistihbarat = frm.qistihbarat
            qaktif = frm.qaktif
            qgelismis = frm.qgelismis
            mevcut = frm.mevcut
            yeni = frm.yeni
            dataload()
        End If
        frm.stokkodu = Nothing
        frm.malincinsi = Nothing
        frm.barkod = Nothing
        frm.muadilbarkod = Nothing
        frm.birim = Nothing
        frm.kod1 = Nothing
        frm.kod2 = Nothing
        frm.kod3 = Nothing
        frm.kod4 = Nothing
        frm.kod5 = Nothing
        frm.kod6 = Nothing
        frm.kod7 = Nothing
        frm.kod8 = Nothing
        frm.kod9 = Nothing
        frm.kod10 = Nothing
        frm.satisfiyati1 = Nothing
        frm.satisfiyati2 = Nothing
        frm.satisfiyati3 = Nothing
        frm.istihbarat = Nothing
        frm.ind = Nothing
        frm.qind = Nothing
        frm.qstokkodu = Nothing
        frm.qmalincinsi = Nothing
        frm.qbarkod = Nothing
        frm.qmuadilbarkod = Nothing
        frm.qkod1 = Nothing
        frm.qkod2 = Nothing
        frm.qkod3 = Nothing
        frm.qkod4 = Nothing
        frm.qkod5 = Nothing
        frm.qkod6 = Nothing
        frm.qkod7 = Nothing
        frm.qkod8 = Nothing
        frm.qkod9 = Nothing
        frm.qkod10 = Nothing
        frm.qistihbarat = Nothing
        frm.qbirim = Nothing
        frm.qdepo = Nothing
        frm.qsatisfiyati1 = Nothing
        frm.qsatisfiyati2 = Nothing
        frm.qsatisfiyati3 = Nothing
        frm.PanelControl1.Dispose()
        frm.PanelControl1 = Nothing
        frm.PanelControl2.Dispose()
        frm.PanelControl2 = Nothing
        frm.PanelControl3.Dispose()
        frm.PanelControl3 = Nothing
        frm.PictureBox1.Dispose()
        frm.PictureBox1 = Nothing
        frm.SimpleButton1 = Nothing
        frm.SimpleButton2 = Nothing
        frm.DataSet1.Clear()
        frm.DataSet1.Dispose()
        frm.DataSet1 = Nothing
        frm.VGridControl1.Dispose()
        frm.VGridControl1 = Nothing
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub satir_ekle(ByVal yeni As Boolean)
        Dim frm As New frm_stok_fisler
        Dim dr As DataRow
        Dim dr1 As DataRow
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = DataSet1.Tables(0).NewRow
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr("STOKNO") = dr1("STOKNO")
                    dr("STOKKODU") = dr1("STOKKODU")
                    dr("MALINCINSI") = dr1("MALINCINSI")
                    dr("BARKOD") = dr1("BARKOD")
                    dr("MODEL") = dr1("MODEL")
                    dr("RENK") = dr1("RENK")
                    dr("BEDEN") = dr1("sBeden")
                    Try
                        dr("lFiyat1") = CType(dr1("lFiyat1"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat1") = 0
                    End Try
                    Try
                        dr("lFiyat2") = CType(dr1("lFiyat2"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat2") = 0
                    End Try
                    Try
                        dr("lFiyat3") = CType(dr1("lFiyat3"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat3") = 0
                    End Try
                    Try
                        dr("lFiyat4") = CType(dr1("lFiyat4"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat4") = 0
                    End Try
                    Try
                        dr("lFiyat5") = CType(dr1("lFiyat5"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat5") = 0
                    End Try
                    dr("MIKTAR") = dr1("MIKTAR")
                    dr("UZUNLUK") = Len(Trim(dr("BARKOD").ToString))
                    DataSet1.Tables(0).Rows.Add(dr)
                    Me.Refresh()
                Next
                yeni = frm.yeni
                frm.DataSet1.Clear()
                frm.DataSet1.Dispose()
                frm.DataSet1 = Nothing
                frm.SimpleButton1 = Nothing
                frm.SimpleButton2 = Nothing
                frm.SimpleButton3 = Nothing
                frm.GridControl1.Dispose()
                frm.GridControl1 = Nothing
                frm.GridView1.Dispose()
                frm.GridView1 = Nothing
                frm.XtraTabControl1.Dispose()
                frm.XtraTabControl1 = Nothing
                frm.XtraTabPage1.Dispose()
                frm.XtraTabPage1 = Nothing
                frm.Label1.Dispose()
                frm.Label1 = Nothing
                frm.Label2.Dispose()
                frm.Label2 = Nothing
                frm.Close()
                frm.Dispose()
                frm = Nothing
                If yeni = True Then
                    satir_ekle(True)
                End If
                dr = Nothing
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
            End If
        End If
        GridView1.UpdateTotalSummary()
        'GridControl1.Select()
        'GridControl1.Focus()
        'GridView1.Focus()
        If GridView1.RowCount > 0 Then
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
            GridView1.SelectRow(GridView1.FocusedRowHandle)
            PanelControl3.Focus()
            GridControl1.Focus()
        End If
    End Sub
    Private Sub satir_ekle_stok(ByVal yeni As Boolean, Optional ByVal miktarsec As Boolean = False)
        Dim frm As New frm_stok
        frm.islemstatus = True
        Dim dr As DataRow
        Dim dr1 As DataRow
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = DataSet1.Tables(0).NewRow
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr("STOKNO") = dr1("nStokId")
                    dr("STOKKODU") = dr1("sKodu")
                    dr("MALINCINSI") = dr1("sAciklama")
                    dr("BARKOD") = dr1("sBarkod")
                    dr("MODEL") = dr1("sModel")
                    dr("RENK") = dr1("sRenkAdi")
                    dr("BEDEN") = dr1("sBeden")
                    Try
                        dr("lFiyat1") = CType(dr1("lFiyat1"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat1") = 0
                    End Try
                    Try
                        dr("lFiyat2") = CType(dr1("lFiyat2"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat2") = 0
                    End Try
                    Try
                        dr("lFiyat3") = CType(dr1("lFiyat3"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat3") = 0
                    End Try
                    Try
                        dr("lFiyat4") = CType(dr1("lFiyat4"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat4") = 0
                    End Try
                    Try
                        dr("lFiyat5") = CType(dr1("lFiyat5"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat5") = 0
                    End Try
                    If miktarsec = True Then
                        If dr1("Mevcut") <> 0 Then
                            dr("MIKTAR") = dr1("Mevcut")
                        Else
                            dr("MIKTAR") = 1
                        End If
                    Else
                        dr("MIKTAR") = 1
                    End If
                    dr("UZUNLUK") = Len(Trim(dr("BARKOD").ToString))
                    DataSet1.Tables(0).Rows.Add(dr)
                    Me.Refresh()
                Next
                yeni = frm.yeni
                frm.DataSet1.Clear()
                frm.DataSet1.Dispose()
                frm.DataSet1 = Nothing
                frm.SimpleButton1 = Nothing
                frm.SimpleButton2 = Nothing
                frm.GridControl1.Dispose()
                frm.GridControl1 = Nothing
                frm.GridView1.Dispose()
                frm.GridView1 = Nothing
                frm.XtraTabControl1.Dispose()
                frm.XtraTabControl1 = Nothing
                frm.XtraTabPage1.Dispose()
                frm.XtraTabPage1 = Nothing
                frm.Label1.Dispose()
                frm.Label1 = Nothing
                frm.Label2.Dispose()
                frm.Label2 = Nothing
                frm.Close()
                frm.Dispose()
                frm = Nothing
                If yeni = True Then
                    satir_ekle_stok(True)
                End If
                dr = Nothing
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
            End If
        End If
        GridView1.UpdateTotalSummary()
        'GridControl1.Select()
        'GridControl1.Focus()
        'GridView1.Focus()
        If GridView1.RowCount > 0 Then
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
            GridView1.SelectRow(GridView1.FocusedRowHandle)
            PanelControl3.Focus()
            GridControl1.Focus()
        End If
    End Sub
    Private Sub satir_ekle_stok1(ByVal yeni As Boolean, Optional ByVal miktarsec As Boolean = False)
        Dim frm As New frm_stok1
        frm.islemstatus = True
        Dim dr As DataRow
        Dim dr1 As DataRow
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = DataSet1.Tables(0).NewRow
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr("STOKNO") = dr1("nStokId")
                    dr("STOKKODU") = dr1("sKodu")
                    dr("MALINCINSI") = dr1("sAciklama")
                    dr("BARKOD") = dr1("sBarkod")
                    dr("MODEL") = dr1("sModel")
                    dr("RENK") = dr1("sRenkAdi")
                    dr("BEDEN") = dr1("sBeden")
                    Try
                        dr("lFiyat1") = CType(dr1("lFiyat1"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat1") = 0
                    End Try
                    Try
                        dr("lFiyat2") = CType(dr1("lFiyat2"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat2") = 0
                    End Try
                    Try
                        dr("lFiyat3") = CType(dr1("lFiyat3"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat3") = 0
                    End Try
                    Try
                        dr("lFiyat4") = CType(dr1("lFiyat4"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat4") = 0
                    End Try
                    Try
                        dr("lFiyat5") = CType(dr1("lFiyat5"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat5") = 0
                    End Try
                    If miktarsec = True Then
                        If dr1("Mevcut") <> 0 Then
                            dr("MIKTAR") = dr1("Mevcut")
                        Else
                            dr("MIKTAR") = 1
                        End If
                    Else
                        dr("MIKTAR") = 1
                    End If
                    dr("UZUNLUK") = Len(Trim(dr("BARKOD").ToString))
                    DataSet1.Tables(0).Rows.Add(dr)
                    Me.Refresh()
                Next
                yeni = frm.yeni
                frm.DataSet1.Clear()
                frm.DataSet1.Dispose()
                frm.DataSet1 = Nothing
                frm.SimpleButton1 = Nothing
                frm.SimpleButton2 = Nothing
                frm.GridControl1.Dispose()
                frm.GridControl1 = Nothing
                frm.GridView1.Dispose()
                frm.GridView1 = Nothing
                frm.XtraTabControl1.Dispose()
                frm.XtraTabControl1 = Nothing
                frm.XtraTabPage1.Dispose()
                frm.XtraTabPage1 = Nothing
                frm.Label1.Dispose()
                frm.Label1 = Nothing
                frm.Label2.Dispose()
                frm.Label2 = Nothing
                frm.Close()
                frm.Dispose()
                frm = Nothing
                If yeni = True Then
                    satir_ekle_stok(True)
                End If
                dr = Nothing
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
            End If
        End If
        GridView1.UpdateTotalSummary()
        'GridControl1.Select()
        'GridControl1.Focus()
        'GridView1.Focus()
        If GridView1.RowCount > 0 Then
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
            GridView1.SelectRow(GridView1.FocusedRowHandle)
            PanelControl3.Focus()
            GridControl1.Focus()
        End If
    End Sub
    Private Sub satir_ekle_stok_yeniler(ByVal yeni As Boolean, Optional ByVal miktarsec As Boolean = False)
        Dim frm As New frm_stok_yeniler
        frm.islemstatus = True
        Dim dr As DataRow
        Dim dr1 As DataRow
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = DataSet1.Tables(0).NewRow
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr("STOKNO") = dr1("nStokId")
                    dr("STOKKODU") = dr1("sKodu")
                    dr("MALINCINSI") = dr1("sAciklama")
                    dr("BARKOD") = dr1("sBarkod")
                    dr("MODEL") = dr1("sModel")
                    dr("RENK") = dr1("sRenkAdi")
                    dr("BEDEN") = dr1("sBeden")
                    Try
                        dr("lFiyat1") = CType(dr1("lFiyat1"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat1") = 0
                    End Try
                    Try
                        dr("lFiyat2") = CType(dr1("lFiyat2"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat2") = 0
                    End Try
                    Try
                        dr("lFiyat3") = CType(dr1("lFiyat3"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat3") = 0
                    End Try
                    Try
                        dr("lFiyat4") = CType(dr1("lFiyat4"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat4") = 0
                    End Try
                    If miktarsec = True Then
                        If dr1("Mevcut") <> 0 Then
                            dr("MIKTAR") = dr1("Mevcut")
                        Else
                            dr("MIKTAR") = 1
                        End If
                    Else
                        dr("MIKTAR") = 1
                    End If
                    dr("UZUNLUK") = Len(Trim(dr("BARKOD").ToString))
                    DataSet1.Tables(0).Rows.Add(dr)
                    Me.Refresh()
                Next
                yeni = frm.yeni
                frm.DataSet1.Clear()
                frm.DataSet1.Dispose()
                frm.DataSet1 = Nothing
                frm.SimpleButton1 = Nothing
                frm.SimpleButton2 = Nothing
                frm.GridControl1.Dispose()
                frm.GridControl1 = Nothing
                frm.GridView1.Dispose()
                frm.GridView1 = Nothing
                frm.XtraTabControl1.Dispose()
                frm.XtraTabControl1 = Nothing
                frm.XtraTabPage1.Dispose()
                frm.XtraTabPage1 = Nothing
                frm.Label1.Dispose()
                frm.Label1 = Nothing
                frm.Label2.Dispose()
                frm.Label2 = Nothing
                frm.Close()
                frm.Dispose()
                frm = Nothing
                If yeni = True Then
                    satir_ekle_stok(True)
                End If
                dr = Nothing
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
            End If
        End If
        GridView1.UpdateTotalSummary()
        'GridControl1.Select()
        'GridControl1.Focus()
        'GridView1.Focus()
        If GridView1.RowCount > 0 Then
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
            GridView1.SelectRow(GridView1.FocusedRowHandle)
            PanelControl3.Focus()
            GridControl1.Focus()
        End If
    End Sub
    Private Sub satir_ekle_stok_degisenler(ByVal yeni As Boolean, Optional ByVal miktarsec As Boolean = False)
        Dim frm As New frm_stok_fiyatidegisen
        frm.islemstatus = True
        Dim dr As DataRow
        Dim dr1 As DataRow
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = DataSet1.Tables(0).NewRow
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr("STOKNO") = dr1("nStokId")
                    dr("STOKKODU") = dr1("sKodu")
                    dr("MALINCINSI") = dr1("sAciklama")
                    dr("BARKOD") = dr1("sBarkod")
                    dr("MODEL") = dr1("sModel")
                    dr("RENK") = dr1("sRenkAdi")
                    dr("BEDEN") = dr1("sBeden")
                    Try
                        dr("lFiyat1") = CType(dr1("lFiyat1"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat1") = 0
                    End Try
                    Try
                        dr("lFiyat2") = CType(dr1("lFiyat2"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat2") = 0
                    End Try
                    Try
                        dr("lFiyat3") = CType(dr1("lFiyat3"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat3") = 0
                    End Try
                    Try
                        dr("lFiyat4") = CType(dr1("lFiyat4"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat4") = 0
                    End Try
                    If miktarsec = True Then
                        If dr1("Mevcut") <> 0 Then
                            dr("MIKTAR") = dr1("Mevcut")
                        Else
                            dr("MIKTAR") = 1
                        End If
                    Else
                        dr("MIKTAR") = 1
                    End If
                    dr("UZUNLUK") = Len(Trim(dr("BARKOD").ToString))
                    DataSet1.Tables(0).Rows.Add(dr)
                    Me.Refresh()
                Next
                yeni = frm.yeni
                frm.DataSet1.Clear()
                frm.DataSet1.Dispose()
                frm.DataSet1 = Nothing
                frm.SimpleButton1 = Nothing
                frm.SimpleButton2 = Nothing
                frm.GridControl1.Dispose()
                frm.GridControl1 = Nothing
                frm.GridView1.Dispose()
                frm.GridView1 = Nothing
                frm.XtraTabControl1.Dispose()
                frm.XtraTabControl1 = Nothing
                frm.XtraTabPage1.Dispose()
                frm.XtraTabPage1 = Nothing
                frm.Label1.Dispose()
                frm.Label1 = Nothing
                frm.Label2.Dispose()
                frm.Label2 = Nothing
                frm.Close()
                frm.Dispose()
                frm = Nothing
                If yeni = True Then
                    satir_ekle_stok_degisenler(True)
                End If
                dr = Nothing
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
            End If
        End If
        GridView1.UpdateTotalSummary()
        'GridControl1.Select()
        'GridControl1.Focus()
        'GridView1.Focus()
        If GridView1.RowCount > 0 Then
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
            GridView1.SelectRow(GridView1.FocusedRowHandle)
            PanelControl3.Focus()
            GridControl1.Focus()
        End If
    End Sub
    Private Sub satir_ekle_stok_envanterli(ByVal yeni As Boolean, Optional ByVal miktarsec As Boolean = False)
        Dim frm As New frm_stok
        frm.islemstatus = True
        Dim dr As DataRow
        Dim dr1 As DataRow
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = frm.GridView1.GetDataRow(s)
                    If dr1("Mevcut") > 0 Then
                        dr = DataSet1.Tables(0).NewRow
                        dr("STOKNO") = dr1("nStokId")
                        dr("STOKKODU") = dr1("sKodu")
                        dr("MALINCINSI") = dr1("sAciklama")
                        dr("BARKOD") = dr1("sBarkod")
                        dr("MODEL") = dr1("sModel")
                        dr("RENK") = dr1("sRenkAdi")
                        dr("BEDEN") = dr1("sBeden")
                        Try
                            dr("lFiyat1") = CType(dr1("lFiyat1"), Decimal)
                        Catch ex As Exception
                            dr("lFiyat1") = 0
                        End Try
                        Try
                            dr("lFiyat2") = CType(dr1("lFiyat2"), Decimal)
                        Catch ex As Exception
                            dr("lFiyat2") = 0
                        End Try
                        Try
                            dr("lFiyat3") = CType(dr1("lFiyat3"), Decimal)
                        Catch ex As Exception
                            dr("lFiyat3") = 0
                        End Try
                        Try
                            dr("lFiyat4") = CType(dr1("lFiyat4"), Decimal)
                        Catch ex As Exception
                            dr("lFiyat4") = 0
                        End Try
                        If miktarsec = True Then
                            If dr1("Mevcut") <> 0 Then
                                dr("MIKTAR") = dr1("Mevcut")
                            Else
                                dr("MIKTAR") = 1
                            End If
                        Else
                            dr("MIKTAR") = 1
                        End If
                        dr("UZUNLUK") = Len(Trim(dr("BARKOD").ToString))
                        DataSet1.Tables(0).Rows.Add(dr)
                    End If
                    Me.Refresh()
                Next
                yeni = frm.yeni
                frm.DataSet1.Clear()
                frm.DataSet1.Dispose()
                frm.DataSet1 = Nothing
                frm.SimpleButton1 = Nothing
                frm.SimpleButton2 = Nothing
                frm.GridControl1.Dispose()
                frm.GridControl1 = Nothing
                frm.GridView1.Dispose()
                frm.GridView1 = Nothing
                frm.XtraTabControl1.Dispose()
                frm.XtraTabControl1 = Nothing
                frm.XtraTabPage1.Dispose()
                frm.XtraTabPage1 = Nothing
                frm.Label1.Dispose()
                frm.Label1 = Nothing
                frm.Label2.Dispose()
                frm.Label2 = Nothing
                frm.Close()
                frm.Dispose()
                frm = Nothing
                If yeni = True Then
                    satir_ekle_stok(True)
                End If
                dr = Nothing
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
            End If
        End If
        GridView1.UpdateTotalSummary()
        'GridControl1.Select()
        'GridControl1.Focus()
        'GridView1.Focus()
        If GridView1.RowCount > 0 Then
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
            GridView1.SelectRow(GridView1.FocusedRowHandle)
            PanelControl3.Focus()
            GridControl1.Focus()
        End If
    End Sub
    Private Sub dataload()
        dataload_depo()
        'DataSet1.Clear()
        'DataSet1.Dispose()
        DataSet1 = stok()
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        'GridView1.SelectRow(0)
    End Sub
    Private Sub stok_yeni()
        'stok_islemleri.kart_yeni()
    End Sub
    Private Sub stok_duzelt()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("STOKNO")
            frm.sKodu = dr("STOKKODU")
            frm.sModel = dr("MODEL")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub stok_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            'dr = DataSet1.Tables(0).Rows(0)
            'stok_islemleri.kart_sil(dr("IND"), False)
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr1 As DataRow
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = GridView1.GetDataRow(s)
                    'stok_islemleri.kart_sil(dr1("IND"), False)
                    'If stok_islemleri.sil = True Then
                    '    'dr1.Delete()
                    '    'dr1.AcceptChanges()
                    'End If
                Next
            End If
            s = Nothing
            arr = Nothing
            i = Nothing
            dr1 = Nothing
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            dataload()
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        satir_ekle(False)
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
    Public Function stok() As DataSet
        Dim kriter
        kriter = "WHERE (stok.skodu is not null ) "
        If stokkodu <> "" Then
            kriter += " AND (stok.skodu " & sorgu_kriter_string(stokkodu, qstokkodu) & ")"
        End If
        If malincinsi <> "" Then
            kriter += " AND (stok.saciklama " & sorgu_kriter_string(malincinsi, qmalincinsi) & ")"
        End If
        If barkod <> "" Then
            kriter += " AND (barkod.sbarkod " & sorgu_kriter_string(barkod, qbarkod) & ")"
        End If
        'If birim <> "" Then
        '    kriter += " AND (TBLBIRIMLEREX.BIRIMADI " & sorgu_kriter_string(birim, qbirim) & ")"
        'End If
        If kod1 <> "" Then
            kriter += " AND (stok.srenk " & sorgu_kriter_string(kod1, qkod1) & " )"
        End If
        If kod2 <> "" Then
            kriter += " AND (stok.sbeden " & sorgu_kriter_string(kod2, qkod2) & ")"
        End If
        'If kod3 <> "" Then
        '    kriter += " AND (STK.KOD3 " & sorgu_kriter_string(kod3, qkod3) & ")"
        'End If
        'If kod4 <> "" Then
        '    kriter += " AND (STK.KOD4 " & sorgu_kriter_string(kod4, qkod4) & ")"
        'End If
        'If kod5 <> "" Then
        '    kriter += " AND (STK.KOD5 " & sorgu_kriter_string(kod5, qkod5) & ")"
        'End If
        'If kod6 <> "" Then
        '    kriter += " AND (STK.KOD6 " & sorgu_kriter_string(kod6, qkod6) & ")"
        'End If
        'If kod7 <> "" Then
        '    kriter += " AND (STK.KOD7 " & sorgu_kriter_string(kod7, qkod7) & ")"
        'End If
        'If kod8 <> "" Then
        '    kriter += " AND (STK.KOD8 " & sorgu_kriter_string(kod8, qkod8) & ")"
        'End If
        'If kod9 <> "" Then
        '    kriter += " AND (STK.KOD9 " & sorgu_kriter_string(kod9, qkod9) & ")"
        'End If
        'If kod10 <> "" Then
        '    kriter += " AND (STK.KOD10 " & sorgu_kriter_string(kod10, qkod10) & ")"
        'End If
        'If istihbarat <> "" Then
        '    kriter += " AND (STK.ISTIHBARAT " & sorgu_kriter_string(istihbarat, qistihbarat) & ")"
        'End If
        'If satisfiyati1 <> "" Then
        '    kriter += " AND (TBLBIRIMLEREX.SATISFIYATI1 " & sorgu_kriter_string(satisfiyati1, qsatisfiyati1) & ")"
        'End If
        'If satisfiyati2 <> "" Then
        '    kriter += " AND (TBLBIRIMLEREX.SATISFIYATI2 " & sorgu_kriter_string(satisfiyati2, qsatisfiyati2) & ")"
        'End If
        'If satisfiyati3 <> "" Then
        '    kriter += " AND (TBLBIRIMLEREX.SATISFIYATI3 " & sorgu_kriter_string(satisfiyati3, qsatisfiyati3) & ")"
        'End If
        If kayitno <> "" Then
            kriter += " AND (stok.nStokID " & sorgu_kriter_string(kayitno, qkayitno) & ")"
        End If
        'If aktif <> "" Then
        '    kriter += " AND (STK.STATUS " & sorgu_kriter_string(aktif, qaktif) & ")"
        'End If
        'If sil = True Then
        '    kriter += " AND STK.IND NOT IN (SELECT STOKNO FROM *!F!DTBLSTOKHAREKETLERI) "
        'End If
        If gelismis <> "" Then
            kriter += " AND (stok.skodu " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (stok.saciklama " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (barkod.sbarkod " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (stok.srenk " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (stok.sbeden " & sorgu_kriter_string(gelismis, qgelismis) & ") "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " stok.nStokID,stok.sKodu, stok.sAciklama, stok.sRenk, stok.sBeden, stok.sModel, barkod.sBarkod, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 " & kriter & " ORDER BY stok.sKodu")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub analiz_envanter()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_stok_envanter
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.stokno = dr("STOKNO")
        frm.stokkodu = dr("STOKKODU")
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub analiz_envanter_model()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_stok_envanter_model
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.modelno = dr("MODEL")
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub analiz_hareket()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'stkdll.firmano = firmano
        'stkdll.donemno = donemno
        'stkdll.connection = connection
        'stkdll.stokno = dr("IND")
        'stkdll.rptfiyatanalizi(dr("IND"), 100, dr("MALINCINSI"), 2)
    End Sub
    Private Sub stok_fiyat()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_fiyatlandir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("STOKNO")
            frm.sModel = dr("MODEL")
            frm.sKodu = dr("STOKKODU")
            'frm.sRenk = dr("sRenk")
            'frm.sBeden = dr("sBeden")
            frm.txt_musteriNo.Text = dr("MODEL")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Function satir_kontrol()
        Dim satir As String = "WHERE stok.nStokId IN ("
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim toplamsayi = GridView1.SelectedRowsCount
        Dim sayi = 0
        arr = GridView1.GetSelectedRows()
        Dim dr1 As DataRow
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr1 = GridView1.GetDataRow(s)
                satir += dr1("STOKNO").ToString
                sayi += 1
                If sayi < toplamsayi Then
                    satir += ","
                ElseIf sayi = toplamsayi Then
                    satir += ")"
                End If
            Next
        End If
        Return satir
    End Function
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer, ByVal miktar As Decimal, ByVal fiyat1 As Decimal, ByVal fiyat2 As Decimal, ByVal fiyat3 As Decimal, ByVal fiyat4 As Decimal, ByVal fiyat5 As Decimal, ByVal sKodu As String, ByVal sModel As String, ByVal sAciklama As String, ByVal sBarkod As String, ByVal sRenk As String, ByVal sBeden As String, ByVal lMiktar As String)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New FastReport.TfrxReport
            Dim qr_hareket As New FastReport.TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            frx.SetVariable("lFiyat1", "" & fiyat1 & "")
            frx.SetVariable("lFiyat2", "" & fiyat2 & "")
            frx.SetVariable("lFiyat3", "" & fiyat3 & "")
            frx.SetVariable("lFiyat1", "" & fiyat1 & "")
            frx.SetVariable("lFiyat2", "" & fiyat2 & "")
            frx.SetVariable("lFiyat3", "" & fiyat3 & "")
            frx.SetVariable("lFiyat4", "" & fiyat4 & "")
            frx.SetVariable("lFiyat5", "" & fiyat5 & "")
            frx.SetVariable("sKodu", "'" & sKodu & "'")
            frx.SetVariable("sAciklama", "'" & sAciklama & "'")
            frx.SetVariable("sBarkod", "'" & sBarkod & "'")
            frx.SetVariable("sRenk", "'" & sRenk & "'")
            frx.SetVariable("sBeden", "'" & sBeden & "'")
            frx.SetVariable("lMiktar", "" & lMiktar & "")
            frx.SetVariable("FIYAT", "'" & fiyat_gizle_tumu(FormatNumber(fiyat1, 2), FormatNumber(fiyat2, 2), FormatNumber(fiyat3, 2)) & "'")
            'frx.SetVariable("HD_PESIN_tl", "" & fiyat_gizle(FormatNumber(fiyat1, 2)).ToString & "")
            'frx.SetVariable("HD_ALTIAY_tl", "" & fiyat_gizle_tl(FormatNumber(fiyat2, 2)).ToString & "")
            'frx.SetVariable("HD_ONAY_tl", "" & fiyat_gizle_tl(FormatNumber(fiyat3, 2)).ToString & "")
            qr_hareket = frx.FindObject("qr_hareket")
            If Koli_barkod.Checked = True Then

                'qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT 0 as sPartiNo,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS FIYAT4, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat5 & "') AS FIYAT5, ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS lBirimCarpan,barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.sKavala,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = Stok.sKdvTipi) as nKdvOrani,stok.sBirimCinsi1,stok.sBirimCinsi2,tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 2 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ")
                'qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT 0 as sPartiNo,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS FIYAT4, ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS lBirimCarpan,barkod.sBarkod, stok.nStokID,tbStokAciklama.sAciklama1,tbStokAciklama.sAciklama2,tbStokAciklama.sAciklama3,tbStokAciklama.sAciklama4,tbStokAciklama.sAciklama5,tbStokAciklama.sAciklama6,tbStokAciklama.sAciklama7,tbStokAciklama.sAciklama8,tbStokAciklama.sAciklama9,tbStokAciklama.sAciklama10,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, (Select sAciklama From tbBirimCinsi Where tbBirimCinsi.sBirimCinsi=stok.sBirimCinsi1) as sBirimCinsi1A, (Select sAciklama From tbBirimCinsi Where tbBirimCinsi.sBirimCinsi=stok.sBirimCinsi2) as sBirimCinsi2A, stok.sRenk, stok.sBeden, stok.sKavala,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = Stok.sKdvTipi) as nKdvOrani,stok.sBirimCinsi1,stok.sBirimCinsi2,tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokAciklama ON stok.nStokID = tbStokAciklama.nStokID  INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ") & ""
                qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT 0 as sPartiNo,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS lFiyat1, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS lFiyat3, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS lFiyat2,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS lFiyat4, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '') AS lFiyat5, ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS lBirimCarpan,barkod.sBarkod, (Select sBarkod From tbStokBarkodu Where tbStokBarkodu.sBirimCinsi= 'KO' and tbStokBarkodu.nStokID=stok.nStokID) as KoliBarkod, (Select sBarkod From tbStokBarkodu Where tbStokBarkodu.sBirimCinsi = 'PK' and tbStokBarkodu.nStokID=stok.nStokID) as PaketBarkod,(Select sBarkod From tbStokBarkodu Where tbStokBarkodu.sBirimCinsi='KT' and tbStokBarkodu.nStokID=stok.nStokID) as KutuBarkod, (Select sBarkod From tbStokBarkodu Where tbStokBarkodu.sBirimCinsi='GR' and tbStokBarkodu.nStokID=stok.nStokID) as GramBarkod,(Select sBarkod From tbStokBarkodu Where tbStokBarkodu.sBirimCinsi='KG' and tbStokBarkodu.nStokID=stok.nStokID) as KiloBarkod, (Select sBarkod From tbStokBarkodu Where tbStokBarkodu.sBirimCinsi='MT' and tbStokBarkodu.nStokID=stok.nStokID) as MetreBarkod, stok.sOzelNot, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, (Select sAciklama From tbBirimCinsi Where tbBirimCinsi.sBirimCinsi=stok.sBirimCinsi1) as sBirimCinsi1A, (Select sAciklama From tbBirimCinsi Where tbBirimCinsi.sBirimCinsi=stok.sBirimCinsi2) as sBirimCinsi2A,stok.sRenk, stok.sBeden, stok.sKavala,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = Stok.sKdvTipi) as nKdvOrani,stok.sBirimCinsi1,stok.sBirimCinsi2,tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ") & ""

            Else
                'qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT 0 as sPartiNo,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS FIYAT4, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat5 & "') AS FIYAT5, ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS lBirimCarpan,barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.sKavala,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = Stok.sKdvTipi) as nKdvOrani,stok.sBirimCinsi1,stok.sBirimCinsi2,tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ")
                'qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT 0 as sPartiNo,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS FIYAT4, ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS lBirimCarpan,barkod.sBarkod, stok.nStokID,tbStokAciklama.sAciklama1,tbStokAciklama.sAciklama2,tbStokAciklama.sAciklama3,tbStokAciklama.sAciklama4,tbStokAciklama.sAciklama5,tbStokAciklama.sAciklama6,tbStokAciklama.sAciklama7,tbStokAciklama.sAciklama8,tbStokAciklama.sAciklama9,tbStokAciklama.sAciklama10,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI,  (Select sAciklama From tbBirimCinsi Where tbBirimCinsi.sBirimCinsi=stok.sBirimCinsi1) as sBirimCinsi1A, (Select sAciklama From tbBirimCinsi Where tbBirimCinsi.sBirimCinsi=stok.sBirimCinsi2) as sBirimCinsi2A, stok.sRenk, stok.sBeden, stok.sKavala,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = Stok.sKdvTipi) as nKdvOrani,stok.sBirimCinsi1,stok.sBirimCinsi2,tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokAciklama ON stok.nStokID = tbStokAciklama.nStokID  INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ") & ""
                qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT 0 as sPartiNo,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '1') AS lFiyat1, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '3') AS lFiyat3, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '2') AS lFiyat2,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '4') AS lFiyat4, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '') AS lFiyat5, ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS lBirimCarpan,barkod.sBarkod, stok.sOzelNot, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, (Select sAciklama From tbBirimCinsi Where tbBirimCinsi.sBirimCinsi=stok.sBirimCinsi1) as sBirimCinsi1A, (Select sAciklama From tbBirimCinsi Where tbBirimCinsi.sBirimCinsi=stok.sBirimCinsi2) as sBirimCinsi2A,stok.sRenk, stok.sBeden, stok.sKavala,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = Stok.sKdvTipi) as nKdvOrani,stok.sBirimCinsi1,stok.sBirimCinsi2,tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ") & ""

            End If
            Dim qr_connection As New FastReport.TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_hareket.DataBase = qr_connection
            frx.PrintOptions.Collate = False
            If sec_sPrint.Checked = True Then
                frx.PrintOptions.Printer = sPrint
            Else
            End If
            If status = 0 Then
                frx.PrepareReport(True)
                frx.ShowReport()
            ElseIf status = 1 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = miktar
                frx.PrintReport()
            ElseIf status = 2 Then
                frx.PrepareReport(True)
                frx.DesignReport()
            ElseIf status = 3 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = miktar
                frx.PrintOptions.ShowDialog = False
                frx.PrintReport()
            End If
            qr_hareket = Nothing
            qr_connection = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(2) = "" & sorgu_query("set transaction isolation level read uncommitted SELECT 0 as sPartiNo,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS lFiyat1, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS lFiyat3, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS lFiyat2,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS lFiyat4, ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS lBirimCarpan,barkod.sBarkod, stok.nStokID,tbStokAciklama.sAciklama1,tbStokAciklama.sAciklama2,tbStokAciklama.sAciklama3,tbStokAciklama.sAciklama4,tbStokAciklama.sAciklama5,tbStokAciklama.sAciklama6,tbStokAciklama.sAciklama7,tbStokAciklama.sAciklama8,tbStokAciklama.sAciklama9,tbStokAciklama.sAciklama10,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.sKavala,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = Stok.sKdvTipi) as nKdvOrani,stok.sBirimCinsi1,stok.sBirimCinsi2,tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokAciklama ON stok.nStokID = tbStokAciklama.nStokID  INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ") & ""
            args(3) = "qr_hareket"
            args(4) = "" & status.ToString() & ""
            args(5) = "18"
            args(6) = "FIRMANO"
            args(7) = "" & firmano.ToString() & ""
            args(8) = "DONEMNO"
            args(9) = "" & donemno.ToString() & ""
            args(10) = "STOKNO"
            args(11) = "" & stokno.ToString() & ""
            args(12) = "SATIRLINE"
            args(13) = "'" & satir_line.ToString() & "'"
            args(14) = "lFiyat1"
            args(15) = "" & fiyat1.ToString() & ""
            args(16) = "lFiyat2"
            args(17) = "" & fiyat2.ToString() & ""
            args(18) = "lFiyat3"
            args(19) = "" & fiyat3.ToString() & ""
            args(20) = "lFiyat1"
            args(21) = "" & fiyat1.ToString() & ""
            args(22) = "lFiyat2"
            args(23) = "" & fiyat2.ToString() & ""
            args(24) = "lFiyat3"
            args(25) = "" & fiyat3.ToString() & ""
            args(26) = "lFiyat4"
            args(27) = "" & fiyat4.ToString() & ""
            args(28) = "sKodu"
            args(29) = "'" & sKodu.ToString() & "'"
            args(30) = "sAciklama"
            args(31) = "'" & sAciklama.ToString() & "'"
            args(32) = "sBarkod"
            args(33) = "'" & sBarkod.ToString() & "'"
            args(34) = "sRenk"
            args(35) = "'" & sRenk.ToString() & "'"
            args(36) = "sBeden"
            args(37) = "'" & sBeden.ToString() & "'"
            args(38) = "lMiktar"
            args(39) = "" & lMiktar.ToString() & ""
            args(40) = "FIYAT"
            args(41) = "'" & fiyat_gizle_tumu(FormatNumber(fiyat1, 2), FormatNumber(fiyat2, 2), FormatNumber(fiyat3, 2)).ToString() & "'"
            processYol = args(0)
            For i As Integer = 1 To 41
                processYol += "|" & args(i)
            Next
            Dim objReader As StreamWriter
            Dim yeniYol As String
            Dim Generator As System.Random = New System.Random()
            Try
                yeniYol = Directory.GetCurrentDirectory() & "\" & Generator.Next().ToString() & "_veriler.txt"
                objReader = New StreamWriter(yeniYol)
                objReader.Write(processYol)
                objReader.Close()
            Catch Ex As Exception
                MessageBox.Show("Raporlama Ýþlemi Ýçin LOG Oluþturulumadý!")
            End Try
            If File.Exists(Directory.GetCurrentDirectory() & "\RaporServis.exe") = True Then
                Dim sInfo As New ProcessStartInfo(Directory.GetCurrentDirectory() & "\RaporServis.exe ", """" & yeniYol & """")
                Process.Start(sInfo)
            Else
                MessageBox.Show("Lütfen 'RaporServis.exe' eklentisini uygulama dizinine kopyalayýn.")
            End If
        End If
            stokno = Nothing
            satir_line = Nothing
    End Sub
    Private Function fiyat_gizle(ByVal deger As String) As String
        Dim x
        Dim mevcut
        Dim deger1 As String = ""
        Dim fiyat As String = FormatNumber(deger, 2)
        If CStr(fiyat) <> "" Then
            x = (fiyat).IndexOf(".", 1, (fiyat).Length - 1)
            If x = -1 Then
                mevcut = 1
            Else
                mevcut = (fiyat).Substring(0, x)
                deger1 = (fiyat).Substring((x + 1), (fiyat).Length - (x + 1)).ToString + "." + mevcut.ToString
            End If
        End If
        Return deger1.ToString
        x = Nothing
        mevcut = Nothing
        fiyat = Nothing
    End Function
    Private Function fiyat_gizle_tumu(ByVal fiyat1 As String, ByVal fiyat2 As String, ByVal fiyat3 As String)
        Dim deger1 As String = ""
        Dim deger2 As String = ""
        Dim deger3 As String = ""
        deger1 = fiyat_gizle(FormatNumber(fiyat1, 2)).ToString
        deger2 = fiyat_gizle(FormatNumber(fiyat2, 2)).ToString
        deger3 = fiyat_gizle(FormatNumber(fiyat3, 2)).ToString
        Return deger1 + "-" + deger2 + "-" + deger3
        deger1 = Nothing
        deger2 = Nothing
        deger3 = Nothing
    End Function
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    'Private Function fiyat_gizle_kr(ByVal deger) As String
    '    Dim x
    '    Dim mevcut
    '    Dim deger1
    '    Dim fiyat As String = FormatNumber(deger, 2)
    '    If CStr(fiyat) <> "" Then
    '        x = (fiyat).IndexOf(".", 1, (fiyat).Length - 1)
    '        If x = -1 Then
    '            mevcut = 1
    '        Else
    '            mevcut = (fiyat).Substring(0, x)
    '            deger1 = (fiyat).Substring((x + 1), (fiyat).Length - (x + 1)).ToString
    '        End If
    '    End If
    '    Return mevcut.ToString
    '    x = Nothing
    '    mevcut = Nothing
    '    fiyat = Nothing
    'End Function
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        'If GridView1.SelectedRowsCount > 1 Then
        '    Dim sayi = GridView1.FocusedRowHandle + 1
        '    Dim sayi1 = GridView1.SelectedRowsCount
        '    GridView1.FocusedColumn = colSTOKKODU
        '    Me.colSTOKKODU.SummaryItem.DisplayFormat = "Kayýt:{0}/Satýr:" & sayi & "/Seçili:" & sayi1 & ""
        'ElseIf GridView1.SelectedRowsCount = 1 Then
        '    Dim sayi = GridView1.FocusedRowHandle + 1
        '    Me.colSTOKKODU.SummaryItem.DisplayFormat = "Kayýt:{0}"
        'End If
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        satir_ekle_stok(False)
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        satir_ekle(False)
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        'stok_yeni()
        satir_ekle_stok(False)
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        printlink1.CreateDocument(ps)
        ps.PreviewFormEx.ShowDialog()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView1.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        GridView1.OptionsView.ShowGroupPanel = True
        GridView1.OptionsCustomization.AllowGroup = True
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        analiz_envanter()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        analiz_envanter_model()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        stok_fiyat()
    End Sub
    Private Sub frm_stok_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'e.Cancel = True
        'Me.Hide()
        'status = Nothing
        'connection = Nothing
        'firmano = Nothing
        'donemno = Nothing
        'stokno = Nothing
        'userno = Nothing
        'stokkodu = Nothing
        'malincinsi = Nothing
        'barkod = Nothing
        'muadilbarkod = Nothing
        'birim = Nothing
        'kod1 = Nothing
        'kod2 = Nothing
        'kod3 = Nothing
        'kod4 = Nothing
        'kod5 = Nothing
        'kod6 = Nothing
        'kod7 = Nothing
        'kod8 = Nothing
        'kod9 = Nothing
        'kod10 = Nothing
        'satisfiyati1 = Nothing
        'satisfiyati2 = Nothing
        'satisfiyati3 = Nothing
        'istihbarat = Nothing
        'kayitno = Nothing
        'qkayitno = Nothing
        'qstokkodu = Nothing
        'qmalincinsi = Nothing
        'qbarkod = Nothing
        'qmuadilbarkod = Nothing
        'qkod1 = Nothing
        'qkod2 = Nothing
        'qkod3 = Nothing
        'qkod4 = Nothing
        'qkod5 = Nothing
        'qkod6 = Nothing
        'qkod7 = Nothing
        'qkod8 = Nothing
        'qkod9 = Nothing
        'qkod10 = Nothing
        'qistihbarat = Nothing
        'qbirim = Nothing
        'qdepo = Nothing
        'qsatisfiyati1 = Nothing
        'qsatisfiyati2 = Nothing
        'qsatisfiyati3 = Nothing
        'PanelControl1 = Nothing
        'PanelControl2 = Nothing
        'PanelControl3 = Nothing
        'XtraTabControl1 = Nothing
        'XtraTabPage1 = Nothing
        'GridControl1 = Nothing
        'GridView1 = Nothing
        'SimpleButton1 = Nothing
        'SimpleButton2 = Nothing
        'SimpleButton3 = Nothing
        'DataSet1 = Nothing
        'DataTable1 = Nothing
        'ContextMenu1 = Nothing
        'MenuItem1 = Nothing
        'MenuItem2 = Nothing
        'MenuItem3 = Nothing
        'MenuItem4 = Nothing
        'MenuItem5 = Nothing
        'MenuItem6 = Nothing
        'MenuItem7 = Nothing
        'MenuItem8 = Nothing
        'MenuItem9 = Nothing
        'MenuItem10 = Nothing
        'MenuItem11 = Nothing
        'MenuItem12 = Nothing
        'MenuItem13 = Nothing
        'MenuItem14 = Nothing
        'MenuItem15 = Nothing
        'MenuItem16 = Nothing
        'ps = Nothing
        'printlink1 = Nothing
        'Label2 = Nothing
        'MenuItem17 = Nothing
        'MenuItem18 = Nothing
        'DataColumn1 = Nothing
        'DataColumn2 = Nothing
        'DataColumn3 = Nothing
        'DataColumn4 = Nothing
        'DataColumn5 = Nothing
        'DataColumn6 = Nothing
        'DataColumn7 = Nothing
        'DataColumn8 = Nothing
        'colnStokID = Nothing
        'colsKodu = Nothing
        'colsAciklama = Nothing
        'colsRenk = Nothing
        'colsBeden = Nothing
        'colsMODEL = Nothing
        'colsBarkod = Nothing
        'colMEVCUT = Nothing
        'sec_renk = Nothing
        'MenuItem20 = Nothing
        'MenuItem22 = Nothing
        'MenuItem23 = Nothing
        'MenuItem24 = Nothing
        'OpenFileDialog1 = Nothing
        'Label1 = Nothing
        'PictureBox1 = Nothing
        'DataColumn9 = Nothing
        'DataColumn10 = Nothing
        'DataColumn11 = Nothing
        'DataColumn12 = Nothing
        'colMIKTAR = Nothing
        'colFIYAT1 = Nothing
        'colFIYAT2 = Nothing
        'colFIYAT3 = Nothing
        'MenuItem21 = Nothing
        'MenuItem25 = Nothing
        'MenuItem19 = Nothing
        'MenuItem26 = Nothing
        'SimpleButton4 = Nothing
        'SimpleButton5 = Nothing
        'MenuItem27 = Nothing
        'Me.Close()
        'Me.Dispose()
        System.GC.Collect()
        System.GC.GetTotalMemory(True)
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        gorunum_kaydet()
    End Sub
    Private Sub frm_stok_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        satir_sil()
    End Sub
    Private Sub satir_sil()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                If dr("STOKNO").ToString <> "" Then
                    'sevkiyat_sil_aktar(dr("IND"), evrakno)
                End If
                'DataTable1.Rows.RemoveAt(GridView1.FocusedRowHandle - 1)
                DataSet1.Tables(0).Rows.Remove(dr)
                'dr.Delete()
                'dr.AcceptChanges()
                'GridControl1.EndUpdate()
                'DataSet1.EndInit()
                'GridControl1.Select()
                'GridControl1.Focus()
                GridView1.UpdateTotalSummary()
                If GridView1.RowCount > 0 Then
                    'GridView1.FocusedRowHandle = GridView1.RowCount - 1
                    GridView1.SelectRow(GridView1.FocusedRowHandle)
                End If
                GridControl1.Focus()
                GridControl1.Select()
            End If
        End If
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        raporla(0)
    End Sub
    Private Sub raporla(ByVal nIslem As Integer, Optional ByVal bDirekt As Boolean = False, Optional ByVal bMiktarli As Integer = 1)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyalarý (*.fr*) |*.fr*"
        OpenFileDialog1.FileName = "c:\Formlar\Etiket\Etiket" & sRaporUzanti & ""
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            guncelle_fiyattipi()
            Dim sFile = OpenFileDialog1.FileName.ToString
            If Microsoft.VisualBasic.Right(sFile, 3) = "fr3" Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                Dim kriter As String = ""
                If bDirekt = False Then
                    kriter = satir_kontrol()
                    report_create_stok(sFile, kriter, nIslem, sorgu_sayi(dr("MIKTAR") * bMiktarli, 1), sorgu_sayi(dr("lFiyat1"), 0), sorgu_sayi(dr("lFiyat2"), 0), sorgu_sayi(dr("lFiyat3"), 0), sorgu_sayi(dr("lFiyat4"), 0), sorgu_sayi(dr("lFiyat5"), 0), dr("STOKKODU").ToString, dr("MODEL").ToString, dr("MALINCINSI").ToString, dr("BARKOD").ToString, dr("RENK").ToString, dr("BEDEN").ToString, sorgu_sayi(dr("MIKTAR") * bMiktarli, 1))
                Else
                    Dim dr1 As DataRow
                    For Each dr1 In DataSet1.Tables(0).Rows
                        report_create_stok(sFile, " WHERE stok.nStokId =" & dr1("STOKNO") & "", nIslem, sorgu_sayi(dr1("MIKTAR") * bMiktarli, 1), sorgu_sayi(dr1("lFiyat1"), 0), sorgu_sayi(dr1("lFiyat2"), 0), sorgu_sayi(dr1("lFiyat3"), 0), sorgu_sayi(dr1("lFiyat4"), 0), sorgu_sayi(dr1("lFiyat5"), 0), dr("STOKKODU").ToString, dr("MODEL").ToString, dr("MALINCINSI").ToString, dr("BARKOD").ToString, dr("RENK").ToString, dr("BEDEN").ToString, sorgu_sayi(dr("MIKTAR") * bMiktarli, 1))
                    Next
                End If
                sFile = Nothing
                kriter = Nothing
            ElseIf Microsoft.VisualBasic.Right(sFile, 3) = "frx" Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                Dim kriter As String = ""
                If bDirekt = False Then
                    kriter = satir_kontrol()
                    report_create(nIslem, sFile, kriter, sorgu_sayi(dr("MIKTAR") * bMiktarli, 1))
                Else
                    Dim dr1 As DataRow
                    For Each dr1 In DataSet1.Tables(0).Rows
                        report_create(nIslem, sFile, " WHERE stok.nStokId =" & dr1("STOKNO") & "", sorgu_sayi(dr1("MIKTAR") * bMiktarli, 1))
                    Next
                End If
                sFile = Nothing
                kriter = Nothing
            End If
        End If
    End Sub
    Private Sub report_create(ByVal nIslem As Integer, ByVal sFile As String, ByVal kriter As String, Optional ByVal bMiktarli As Integer = 1)
        Dim report As New FastReport.Report
        report.Load(sFile)
        Dim ds_etiket As DataSet
        'Sorguya Stok 2.Birim Cinsi Miktar Bilgisi Eklendi.
        ds_etiket = sorgu(sorgu_query("set transaction isolation level read uncommitted SELECT 0 as sPartiNo, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS lFiyat1, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS lFiyat3, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS lFiyat2, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS FIYAT4, barkod.sBarkod, stok.nStokID, stok.sOzelNot, stok.sKisaAdi, stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, (Select sAciklama From tbBirimCinsi Where tbBirimCinsi.sBirimCinsi=stok.sBirimCinsi1) as sBirimCinsi1A, (Select sAciklama From tbBirimCinsi Where tbBirimCinsi.sBirimCinsi=stok.sBirimCinsi2) as sBirimCinsi2A, (Select Convert(varchar, Convert(decimal, lBirimMiktar)) From tbStokBarkodu Where tbStokBarkodu.nStokID=stok.nStokID and tbStokBarkodu.sBirimCinsi=stok.sBirimCinsi2) as lBirimMiktar, tbStokBirimCevrimi.lOran as lBirimMiktar2,(Select sBarkod From tbStokBarkodu Where tbStokBarkodu.sBirimCinsi= 'KO' and tbStokBarkodu.nStokID=stok.nStokID) as KoliBarkod, (Select sBarkod From tbStokBarkodu Where tbStokBarkodu.sBirimCinsi = 'PK' and tbStokBarkodu.nStokID=stok.nStokID) as PaketBarkod,(Select sBarkod From tbStokBarkodu Where tbStokBarkodu.sBirimCinsi='KT' and tbStokBarkodu.nStokID=stok.nStokID) as KutuBarkod, (Select sBarkod From tbStokBarkodu Where tbStokBarkodu.sBirimCinsi='GR' and tbStokBarkodu.nStokID=stok.nStokID) as GramBarkod,(Select sBarkod From tbStokBarkodu Where tbStokBarkodu.sBirimCinsi='KG' and tbStokBarkodu.nStokID=stok.nStokID) as KiloBarkod, (Select sBarkod From tbStokBarkodu Where tbStokBarkodu.sBirimCinsi='MT' and tbStokBarkodu.nStokID=stok.nStokID) as MetreBarkod, stok.sRenk, stok.sBeden, stok.sKavala,stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,(SELECT nKdvOrani FROM tbKdv Where sKdvTipi = Stok.sKdvTipi) as nKdvOrani, stok.sBirimCinsi1, stok.sBirimCinsi2, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBirimCevrimi ON (stok.nStokID = tbStokBirimCevrimi.nStokID and tbStokBirimCevrimi.sBirimCinsi = stok.sBirimCinsi2) INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " "), "Etiket")
        report.RegisterData(ds_etiket)
        report.RegisterData(ds_tbParamGenel)
        report.ScriptLanguage = FastReport.Language.Vb
        report.PrintSettings.Collate = False
        If sec_sPrint.Checked = True Then
            report.PrintSettings.Printer = sPrint
        Else
        End If
        If nIslem = 0 Then
            report.Show()
        ElseIf nIslem = 2 Then
            report.Design()
        ElseIf nIslem = 1 Then
            report.PrintSettings.Copies = bMiktarli
            report.Print()
        ElseIf nIslem = 3 Then
            report.PrintSettings.Copies = bMiktarli
            report.PrintSettings.ShowDialog = False
            report.Print()
        End If
        ds_etiket = Nothing
        report.Dispose()
        report = Nothing
    End Sub
    Private Sub yazdir_direkt(Optional ByVal bMiktarli As Integer = 1)
        Dim file As String
        Dim dr1 As DataRow
        Dim fiyat1 As Decimal = 0
        Dim fiyat2 As Decimal = 0
        Dim fiyat3 As Decimal = 0
        Dim fiyat4 As Decimal = 0
        Dim fiyat5 As Decimal = 0
        Dim miktar As Decimal = 0
        OpenFileDialog1.Filter = "EtiketDosyalarý(*.fr3) |*.fr3"
        OpenFileDialog1.FileName = "c:\Formlar\Etiket\Etiket.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        Dim dr As DataRow
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            For Each dr1 In DataSet1.Tables(0).Rows
                fiyat1 = dr1("lFiyat1")
                fiyat2 = dr1("lFiyat2")
                fiyat3 = dr1("lFiyat3")
                fiyat4 = dr1("lFiyat4")
                fiyat5 = dr1("lFiyat5")
                miktar = dr1("MIKTAR") * bMiktarli
                report_create_stok(file, " WHERE stok.nStokId =" & dr1("STOKNO") & "", 3, miktar, fiyat1, fiyat2, fiyat3, fiyat4, fiyat5, dr1("STOKKODU").ToString, dr1("MODEL").ToString, dr1("MALINCINSI").ToString, dr1("BARKOD").ToString, dr1("RENK").ToString, dr1("BEDEN").ToString, sorgu_sayi(dr1("MIKTAR"), 1))
            Next
        End If
        fiyat1 = Nothing
        fiyat2 = Nothing
        fiyat3 = Nothing
        miktar = Nothing
        dr = Nothing
        file = Nothing
        dr1 = Nothing
    End Sub
    Private Sub raporla1(ByVal islem As Integer)
        Dim file As String
        Dim fiyat1 As Decimal = 0
        Dim fiyat2 As Decimal = 0
        Dim fiyat3 As Decimal = 0
        Dim fiyat4 As Decimal = 0
        Dim fiyat5 As Decimal = 0
        Dim miktar As Decimal = 0
        OpenFileDialog1.Filter = "EtiketDosyalarý(*.fr3) |*.fr3"
        OpenFileDialog1.FileName = "c:\Formlar\Etiket\Etiket.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        Dim dr As DataRow
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            fiyat1 = dr("lFiyat1")
            fiyat2 = dr("lFiyat2")
            fiyat3 = dr("lFiyat3")
            fiyat4 = dr("lFiyat4")
            fiyat5 = dr("lFiyat5")
            miktar = dr("MIKTAR")
            report_create_stok(file, satir_kontrol, islem, miktar, fiyat1, fiyat2, fiyat3, fiyat4, fiyat5, dr("STOKKODU").ToString, dr("MODEL").ToString, dr("MALINCINSI").ToString, dr("BARKOD").ToString, dr("RENK").ToString, dr("BEDEN").ToString, sorgu_sayi(dr("MIKTAR"), 1))
        End If
        fiyat1 = Nothing
        fiyat2 = Nothing
        fiyat3 = Nothing
        miktar = Nothing
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        raporla(2)
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        raporla(1)
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        raporla(3, True)
    End Sub
    Private Sub satir_temizle()
        If XtraMessageBox.Show(Sorgu_sDil("Satýrlarýn Tümünü Silmek istediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            DataSet1.Clear()
            DataSet1.Dispose()
        Else
        End If
    End Sub
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub hesapla()
        If DataSet1.Tables(0).Rows.Count > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            GridView1.PostEditor()
            GridControl1.Update()
            If dr("MIKTAR") = 0 Then
                dr("MIKTAR") = 1
            End If
            dr.EndEdit()
            'sevkiyat_degistir_aktar(dr("IND"), evrakno, personel, dr("STOKNO"), dr("STOKKODU"), dr("STOKADI"), dr("Y1"), dr("Y2"), dr("Y3"), dr("MIKTAR"), dr("IADE"), dr("SATIS"), dr("FIYAT"), dr("TUTAR"), txt_iskonto.Text)
            DataSet1.Tables(0).EndInit()
            GridView1.UpdateTotalSummary()
        End If
    End Sub
    Private Sub MenuItem19_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        satir_temizle()
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            hesapla()
        End If
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        If Koli_barkod.Checked = True Then

            satir_ekle_stok1(False)
        Else
            satir_ekle_stok(False)
        End If
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView1.FocusedColumn().Caption & "] Kolonundaki verileri Aþaðý Doðru Yaymak istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                degeryay(GridView1.FocusedColumn().FieldName)
                Cursor.Current = Cursors.Default
                Cursor.Hide()
            End If
        End If
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        raporla(3, True)
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        satir_ekle_stok_envanterli(False, True)
    End Sub
    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        satir_ekle_stok(False)
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        satir_ekle(False)
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        satir_ekle_stok(False, True)
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        satir_temizle()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        stok_fiyat()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        raporla(0)
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        yazdir_direkt()
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        Dim deger = ""
        deger = InputBox("Yazdýrma Çarpaný", "Yazdýrma Çarpaný", 1).ToString
        If deger.ToString <> "" Then
            'yazdir_direkt(deger)
            raporla(3, True, deger)
        End If
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        satir_ekle_stok_yeniler(False)
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Etiket Ekranýný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        stok_duzelt()
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        satir_ekle_stok_degisenler(False)
    End Sub
    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        If MenuItem31.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsView.ShowAutoFilterRow = True
            MenuItem31.Checked = True
        ElseIf MenuItem31.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsView.ShowAutoFilterRow = False
            MenuItem31.Checked = False
        End If
    End Sub
    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
    End Sub
End Class
