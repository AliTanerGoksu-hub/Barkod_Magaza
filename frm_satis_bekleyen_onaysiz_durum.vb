Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Public Class frm_satis_bekleyen_onaysiz_durum
    Inherits DevExpress.XtraEditors.XtraForm
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
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
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents collKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMusteri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsModel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenkAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBeden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKavala As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBrutFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFaturaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteFaturaTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTeslimEdilecek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteOnayTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTeslimEdilen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colIZAHAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colMEVCUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSiparis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents colSINIF1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sinif1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_satis_bekleyen_onaysiz_durum))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.collKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMusteri = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsModel = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsRenkAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsKavala = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMiktar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collBrutFiyat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDepo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collFaturaNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteFaturaTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteTeslimEdilecek = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteOnayTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteTeslimEdilen = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colIZAHAT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMEVCUT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSiparis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSINIF1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_sinif1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
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
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sinif1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lbl_istihbarat)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 72)
        Me.PanelControl1.TabIndex = 2
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_istihbarat.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(776, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(46, 11)
        Me.lbl_istihbarat.TabIndex = 34
        Me.lbl_istihbarat.Text = "istihbarat..."
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(110, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Aþaðýda Onaysýz Satýþlarýn Listesini Görmektesiniz..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
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
        Me.Label2.Location = New System.Drawing.Point(89, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton3.TabIndex = 5
        Me.SimpleButton3.Text = "&Ara F3"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(729, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.TabIndex = 4
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(649, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 72)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 287)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 283)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(818, 250)
        Me.XtraTabPage1.Text = "Satýþlar"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sinif1})
        Me.GridControl1.Size = New System.Drawing.Size(818, 250)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem14, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem24, Me.MenuItem20, Me.MenuItem19, Me.MenuItem15, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7, Me.MenuItem8, Me.MenuItem16, Me.MenuItem9, Me.MenuItem10, Me.MenuItem17, Me.MenuItem11, Me.MenuItem12, Me.MenuItem18, Me.MenuItem13})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem1.Text = "Ara"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 1
        Me.MenuItem14.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem2.Text = "Envanter"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 3
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem3.Text = "Satýþý Göster"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 4
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem4.Text = "Müþteri Göster"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 5
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem24.Text = "Sipariþlerini Göster"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 6
        Me.MenuItem20.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 7
        Me.MenuItem19.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem22, Me.MenuItem23})
        Me.MenuItem19.Text = "Raporla"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 0
        Me.MenuItem21.Text = "Önizle"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 1
        Me.MenuItem22.Text = "Dizayn"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 2
        Me.MenuItem23.Text = "Yazdýr"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 8
        Me.MenuItem15.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 9
        Me.MenuItem5.Text = "Görünümü Düzenle"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 10
        Me.MenuItem6.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 11
        Me.MenuItem7.Text = "Görünümü Kaydet"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 12
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem8.Text = "Görünümü Yazdýr"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 13
        Me.MenuItem16.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 14
        Me.MenuItem9.Text = "Filtrele"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 15
        Me.MenuItem10.Text = "Gruplandýr"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 16
        Me.MenuItem17.Text = "-"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 17
        Me.MenuItem11.Text = "Satýrlarý Aç"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 18
        Me.MenuItem12.Text = "Satýrlarý Kapat"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 19
        Me.MenuItem18.Text = "-"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 20
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem13.Text = "Ekraný Kapla"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "lKodu"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Musteri"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sKodu"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sModel"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sRenk"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sRenkAdi"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "sBeden"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sKavala"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sAciklama"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Miktar"
        Me.DataColumn10.DataType = GetType(Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "lBrutFiyat"
        Me.DataColumn11.DataType = GetType(Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "Tutar"
        Me.DataColumn12.DataType = GetType(Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "Depo"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "lFaturaNo"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "dteFaturaTarihi"
        Me.DataColumn15.DataType = GetType(Date)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "dteTeslimEdilecek"
        Me.DataColumn16.DataType = GetType(Date)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "dteOnayTarihi"
        Me.DataColumn17.DataType = GetType(Date)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "dteTeslimEdilen"
        Me.DataColumn18.DataType = GetType(Date)
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.collKodu, Me.colMusteri, Me.colsKodu, Me.colsModel, Me.colsRenk, Me.colsRenkAdi, Me.colsBeden, Me.colsKavala, Me.colsAciklama, Me.colMiktar, Me.collBrutFiyat, Me.colTutar, Me.colDepo, Me.collFaturaNo, Me.coldteFaturaTarihi, Me.coldteTeslimEdilecek, Me.coldteOnayTarihi, Me.coldteTeslimEdilen, Me.colIZAHAT, Me.colMEVCUT, Me.colSiparis, Me.colSINIF1})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(342, 287, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", Me.colsKodu, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", Me.colMiktar, "{0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", Me.colTutar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", Nothing, " :{0} prç Ürün"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", Nothing, "Toplam : {0:#,0.##} Adet"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", Nothing, "ToplamTutar: {0:#,0.00}")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'collKodu
        '
        Me.collKodu.Caption = "Müþteri Kodu"
        Me.collKodu.FieldName = "lKodu"
        Me.collKodu.Name = "collKodu"
        Me.collKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "lKodu", "{0} Kayýt")})
        Me.collKodu.Visible = True
        Me.collKodu.VisibleIndex = 3
        Me.collKodu.Width = 49
        '
        'colMusteri
        '
        Me.colMusteri.Caption = "Müþteri"
        Me.colMusteri.FieldName = "Musteri"
        Me.colMusteri.Name = "colMusteri"
        Me.colMusteri.Visible = True
        Me.colMusteri.VisibleIndex = 4
        Me.colMusteri.Width = 81
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Stok Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 5
        Me.colsKodu.Width = 46
        '
        'colsModel
        '
        Me.colsModel.Caption = "Model"
        Me.colsModel.FieldName = "sModel"
        Me.colsModel.Name = "colsModel"
        '
        'colsRenk
        '
        Me.colsRenk.Caption = "RenkKodu"
        Me.colsRenk.FieldName = "sRenk"
        Me.colsRenk.Name = "colsRenk"
        '
        'colsRenkAdi
        '
        Me.colsRenkAdi.Caption = "Renk Adý"
        Me.colsRenkAdi.FieldName = "sRenkAdi"
        Me.colsRenkAdi.Name = "colsRenkAdi"
        Me.colsRenkAdi.Visible = True
        Me.colsRenkAdi.VisibleIndex = 7
        Me.colsRenkAdi.Width = 44
        '
        'colsBeden
        '
        Me.colsBeden.Caption = "Beden"
        Me.colsBeden.FieldName = "sBeden"
        Me.colsBeden.Name = "colsBeden"
        '
        'colsKavala
        '
        Me.colsKavala.Caption = "Kavala"
        Me.colsKavala.FieldName = "sKavala"
        Me.colsKavala.Name = "colsKavala"
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Stok Adý"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 6
        Me.colsAciklama.Width = 73
        '
        'colMiktar
        '
        Me.colMiktar.Caption = "Miktar"
        Me.colMiktar.DisplayFormat.FormatString = "#,0.##"
        Me.colMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMiktar.FieldName = "Miktar"
        Me.colMiktar.Name = "colMiktar"
        Me.colMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", "{0:#,0.00}")})
        Me.colMiktar.Visible = True
        Me.colMiktar.VisibleIndex = 8
        Me.colMiktar.Width = 44
        '
        'collBrutFiyat
        '
        Me.collBrutFiyat.Caption = "Birim Fiyat"
        Me.collBrutFiyat.DisplayFormat.FormatString = "#,0.00"
        Me.collBrutFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutFiyat.FieldName = "lBrutFiyat"
        Me.collBrutFiyat.Name = "collBrutFiyat"
        Me.collBrutFiyat.Visible = True
        Me.collBrutFiyat.VisibleIndex = 9
        Me.collBrutFiyat.Width = 44
        '
        'colTutar
        '
        Me.colTutar.Caption = "Tutar"
        Me.colTutar.DisplayFormat.FormatString = "#,0.00"
        Me.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTutar.FieldName = "Tutar"
        Me.colTutar.Name = "colTutar"
        Me.colTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", "{0:#,0.00}")})
        Me.colTutar.Visible = True
        Me.colTutar.VisibleIndex = 10
        Me.colTutar.Width = 38
        '
        'colDepo
        '
        Me.colDepo.Caption = "Depo"
        Me.colDepo.FieldName = "Depo"
        Me.colDepo.Name = "colDepo"
        Me.colDepo.Visible = True
        Me.colDepo.VisibleIndex = 11
        Me.colDepo.Width = 95
        '
        'collFaturaNo
        '
        Me.collFaturaNo.Caption = "Fiþ No"
        Me.collFaturaNo.FieldName = "lFaturaNo"
        Me.collFaturaNo.Name = "collFaturaNo"
        Me.collFaturaNo.Visible = True
        Me.collFaturaNo.VisibleIndex = 2
        Me.collFaturaNo.Width = 48
        '
        'coldteFaturaTarihi
        '
        Me.coldteFaturaTarihi.Caption = "Tarih"
        Me.coldteFaturaTarihi.FieldName = "dteFaturaTarihi"
        Me.coldteFaturaTarihi.Name = "coldteFaturaTarihi"
        Me.coldteFaturaTarihi.Visible = True
        Me.coldteFaturaTarihi.VisibleIndex = 1
        Me.coldteFaturaTarihi.Width = 42
        '
        'coldteTeslimEdilecek
        '
        Me.coldteTeslimEdilecek.Caption = "Termin Tarihi"
        Me.coldteTeslimEdilecek.FieldName = "dteTeslimEdilecek"
        Me.coldteTeslimEdilecek.Name = "coldteTeslimEdilecek"
        '
        'coldteOnayTarihi
        '
        Me.coldteOnayTarihi.Caption = "Onay Tarihi"
        Me.coldteOnayTarihi.FieldName = "dteOnayTarihi"
        Me.coldteOnayTarihi.Name = "coldteOnayTarihi"
        '
        'coldteTeslimEdilen
        '
        Me.coldteTeslimEdilen.Caption = "Teslim Tarihi"
        Me.coldteTeslimEdilen.FieldName = "dteTeslimEdilen"
        Me.coldteTeslimEdilen.Name = "coldteTeslimEdilen"
        '
        'colIZAHAT
        '
        Me.colIZAHAT.Caption = "Ýzahat"
        Me.colIZAHAT.FieldName = "IZAHAT"
        Me.colIZAHAT.Name = "colIZAHAT"
        Me.colIZAHAT.Visible = True
        Me.colIZAHAT.VisibleIndex = 0
        Me.colIZAHAT.Width = 35
        '
        'colMEVCUT
        '
        Me.colMEVCUT.Caption = "Mevcut"
        Me.colMEVCUT.DisplayFormat.FormatString = "#,0.00"
        Me.colMEVCUT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMEVCUT.FieldName = "Mevcut"
        Me.colMEVCUT.Name = "colMEVCUT"
        Me.colMEVCUT.Visible = True
        Me.colMEVCUT.VisibleIndex = 12
        '
        'colSiparis
        '
        Me.colSiparis.Caption = "Sipariþ"
        Me.colSiparis.DisplayFormat.FormatString = "#,0.00"
        Me.colSiparis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSiparis.FieldName = "Siparis"
        Me.colSiparis.Name = "colSiparis"
        Me.colSiparis.Visible = True
        Me.colSiparis.VisibleIndex = 13
        '
        'colSINIF1
        '
        Me.colSINIF1.Caption = "Sýnýf 1"
        Me.colSINIF1.ColumnEdit = Me.sec_sinif1
        Me.colSINIF1.FieldName = "SINIF1"
        Me.colSINIF1.Name = "colSINIF1"
        Me.colSINIF1.Visible = True
        Me.colSINIF1.VisibleIndex = 14
        '
        'sec_sinif1
        '
        Me.sec_sinif1.AutoHeight = False
        Me.sec_sinif1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sinif1.DisplayMember = "ACIKLAMA"
        Me.sec_sinif1.Name = "sec_sinif1"
        Me.sec_sinif1.ValueMember = "IND"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Onay Bekleyen Satýþlar", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Satýþ Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Ara,F3"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Stok Kartý ,F4"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Musteri Kartý,F5"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Envanter,F6"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Stok Hareketleri ,F7"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Siparisler,F8"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Excel"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Text"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Mail"
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
        'frm_satis_bekleyen_onaysiz_durum
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_satis_bekleyen_onaysiz_durum"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Onay Bekleyen Satýþlar"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sinif1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public status As Boolean
    Dim kriter
    Public firmakodu
    Public firmaadi
    Public adres
    Public personel
    Public kod1
    Public kod2
    Public kod3
    Public kod4
    Public kod5
    Public telefon
    Public istihbarat
    Public firmatipi
    Public kayitno
    Public aktif
    Public tarih1
    Public tarih2
    Public limit
    Public stokkodu
    Public malincinsi
    Public stokkod1
    Public stokkod2
    Public stokkod3
    Public stokkod4
    Public stokkod5
    Public qfirmakodu
    Public qfirmaadi
    Public qadres
    Public qpersonel
    Public qkod1
    Public qkod2
    Public qkod3
    Public qkod4
    Public qkod5
    Public qtelefon
    Public qistihbarat
    Public qfirmatipi
    Public qkayitno
    Public qaktif
    Public qtarih
    Public qlimit
    Public qstokkodu
    Public qmalincinsi
    Public qstokkod1
    Public qstokkod2
    Public qstokkod3
    Public qstokkod4
    Public qstokkod5
    Public carino
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Dim count
    Public language
    Public frf_islem As String = "mektup"
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim adapter As New OleDb.OleDbDataAdapter
    Public islemstatus As Boolean = False
    Private Sub frm_satis_bekleyen_onaysiz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.GC.Collect()
        System.GC.GetTotalMemory(True)
        System.GC.SuppressFinalize(Me)
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        If islemstatus = True Then
            dataload(0)
        End If
        dataload_sinif1()
    End Sub
    Private Sub ara()
        Dim frm As New frm_cari_ara
        carino = 0
        frm.language = language
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.rowTARIH.Visible = True
        frm.rowLIMIT.Visible = True
        frm.rowSTOKKOD1.Properties.Caption = "Stok Sýnýf 1"
        frm.rowSTOKKOD2.Properties.Caption = "Stok Sýnýf 2"
        frm.rowSTOKKOD3.Properties.Caption = "Stok Sýnýf 3"
        frm.rowSTOKKOD4.Properties.Caption = "Stok Sýnýf 4"
        frm.rowSTOKKOD5.Properties.Caption = "Stok Sýnýf 5"
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            kayitno = frm.kayitno
            firmakodu = frm.firmakodu
            firmaadi = frm.firmaadi
            adres = frm.adres
            personel = frm.personel
            kod1 = frm.kod1
            kod2 = frm.kod2
            kod3 = frm.kod3
            kod4 = frm.kod4
            kod5 = frm.kod5
            istihbarat = frm.istihbarat
            telefon = frm.telefon
            firmatipi = frm.firmatipi
            aktif = frm.aktif
            tarih1 = frm.tarih2
            tarih2 = frm.tarih2
            limit = frm.limit
            stokkod1 = frm.stokkod1
            stokkod2 = frm.stokkod2
            stokkod3 = frm.stokkod3
            stokkod4 = frm.stokkod4
            stokkod5 = frm.stokkod5
            qkayitno = frm.qkayitno
            qfirmakodu = frm.qfirmakodu
            qfirmaadi = frm.qfirmaadi
            qadres = frm.qadres
            qpersonel = frm.qpersonel
            qkod1 = frm.qkod1
            qkod2 = frm.qkod2
            qkod3 = frm.qkod3
            qkod4 = frm.qkod4
            qkod5 = frm.qkod5
            qistihbarat = frm.qistihbarat
            qtelefon = frm.qtelefon
            qfirmatipi = frm.qfirmatipi
            qaktif = frm.qaktif
            qtarih = frm.qtarih
            qlimit = frm.qlimit
            qstokkod1 = frm.qstokkod1
            qstokkod2 = frm.qstokkod2
            qstokkod3 = frm.qstokkod3
            qstokkod4 = frm.qstokkod4
            qstokkod5 = frm.qstokkod5
            dataload()
        End If
        frm.DataSet1.Clear()
        frm.DataSet1.Dispose()
        frm.DataSet1 = Nothing
        frm.VGridControl1.Dispose()
        frm.VGridControl1 = Nothing
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub ara_kriter(Optional ByVal islem As Integer = 0)
        Dim frm As New frm_cari_ara
        carino = 0
        frm.language = language
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.rowTARIH.Visible = True
        frm.rowLIMIT.Visible = True
        frm.rowSTOKKODU.Properties.Caption = "Stok Kodu"
        frm.rowMALINCINSI.Properties.Caption = "Stok Adý"
        frm.rowSTOKKOD1.Properties.Caption = "Stok Sýnýf 1"
        frm.rowSTOKKOD2.Properties.Caption = "Stok Sýnýf 2"
        frm.rowSTOKKOD3.Properties.Caption = "Stok Sýnýf 3"
        frm.rowSTOKKOD4.Properties.Caption = "Stok Sýnýf 4"
        frm.rowSTOKKOD5.Properties.Caption = "Stok Sýnýf 5"
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            kayitno = frm.kayitno
            firmakodu = frm.firmakodu
            firmaadi = frm.firmaadi
            adres = frm.adres
            personel = frm.personel
            kod1 = frm.kod1
            kod2 = frm.kod2
            kod3 = frm.kod3
            kod4 = frm.kod4
            kod5 = frm.kod5
            istihbarat = frm.istihbarat
            telefon = frm.telefon
            firmatipi = frm.firmatipi
            aktif = frm.aktif
            tarih1 = frm.tarih1
            tarih2 = frm.tarih2
            limit = frm.limit
            stokkodu = frm.stokkodu
            malincinsi = frm.malincinsi
            stokkod1 = frm.stokkod1
            stokkod2 = frm.stokkod2
            stokkod3 = frm.stokkod3
            stokkod4 = frm.stokkod4
            stokkod5 = frm.stokkod5
            qkayitno = frm.qkayitno
            qfirmakodu = frm.qfirmakodu
            qfirmaadi = frm.qfirmaadi
            qadres = frm.qadres
            qpersonel = frm.qpersonel
            qkod1 = frm.qkod1
            qkod2 = frm.qkod2
            qkod3 = frm.qkod3
            qkod4 = frm.qkod4
            qkod5 = frm.qkod5
            qistihbarat = frm.qistihbarat
            qtelefon = frm.qtelefon
            qfirmatipi = frm.qfirmatipi
            qaktif = frm.qaktif
            qtarih = frm.qtarih
            qlimit = frm.qlimit
            qstokkodu = frm.qstokkodu
            qmalincinsi = frm.qmalincinsi
            qstokkod1 = frm.qstokkod1
            qstokkod2 = frm.qstokkod2
            qstokkod3 = frm.qstokkod3
            qstokkod4 = frm.qstokkod4
            qstokkod5 = frm.qstokkod5
            dataload(islem)
        End If
        frm.DataSet1.Clear()
        frm.DataSet1.Dispose()
        frm.DataSet1 = Nothing
        frm.VGridControl1.Dispose()
        frm.VGridControl1 = Nothing
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub gorunum_yazdir()
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
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
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\" & Me.Name.ToString & "")
    End Sub
    Private Sub dataload_sinif1()
        sec_sinif1.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSinifKodu AS IND, sAciklama AS ACIKLAMA FROM         tbSSinif1 WHERE     (sSinifKodu <> '') ORDER BY sSinifKodu")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Public Sub dataload(Optional ByVal islem As Integer = 0)
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        DataSet1.Clear()
        cari(islem)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Focus()
        GridControl1.Select()
        If carino > 0 And carino < 100 Then
            sorgu()
        End If
        Label2.Text = Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...", sDil)
        Label2.Refresh()
        Me.Refresh()
        'If XtraMessageBox.Show(Sorgu_sDil("Müþteri Analizi Hesaplamasýna Baþlamak Ýstediðinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
        '    taksit_kontrol()
        'End If
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        con.Close()
        Return DS
    End Function
    Private Sub cari(Optional ByVal islem As Integer = 0)
        kriter = ""
        If carino <> 0 Then
            kriter += " WHERE ( tbMusteri.nMusteriID = " & carino & ") "
        Else
            'kriter += " WHERE ( tbMusteri.nMusteriID >= 0) "
            If firmakodu <> "" Then
                kriter += " AND ( tbMusteri.lKodu " & sorgu_kriter_string(firmakodu, qfirmakodu) & " )"
            End If
            If firmaadi <> "" Then
                kriter += " AND (  (tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi) " & sorgu_kriter_string(firmaadi, qfirmaadi) & ")"
            End If
            If adres <> "" Then
                kriter += " AND ( tbMusteri.sEvAdresi1  " & sorgu_kriter_string(adres, qadres) & " )"
            End If
            If telefon <> "" Then
                kriter += " and ( tbMusteri.sEvTelefonu " & sorgu_kriter_string(telefon, qtelefon) & " )"
            End If
            'Açýklama Kontrol
            If stokkod1 <> "" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif1.sAciklama " & sorgu_kriter_string(stokkod1, qstokkod1) & " )"
            End If
            If stokkod2 <> "" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif2.sAciklama " & sorgu_kriter_string(stokkod2, qstokkod2) & " )"
            End If
            If stokkod3 <> "" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif3.sAciklama " & sorgu_kriter_string(stokkod3, qstokkod3) & " )"
            End If
            If stokkod4 <> "" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif4.sAciklama " & sorgu_kriter_string(stokkod4, qstokkod4) & " )"
            End If
            If stokkod5 <> "" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif5.sAciklama " & sorgu_kriter_string(stokkod5, qstokkod5) & " )"
            End If
            If stokkod1 <> "" Then
                kriter += " and ( tbStokSinifi.sSinifKodu1 " & sorgu_kriter_string(stokkod1, qstokkod1) & " )"
            End If
            If stokkod2 <> "" Then
                kriter += " and ( tbStokSinifi.sSinifKodu2 " & sorgu_kriter_string(stokkod2, qstokkod2) & " )"
            End If
            If stokkod3 <> "" Then
                kriter += " and ( tbStokSinifi.sSinifKodu3 " & sorgu_kriter_string(stokkod3, qstokkod3) & " )"
            End If
            If stokkod4 <> "" Then
                kriter += " and ( tbStokSinifi.sSinifKodu4 " & sorgu_kriter_string(stokkod4, qstokkod4) & " )"
            End If
            If stokkod5 <> "" Then
                kriter += " and ( tbStokSinifi.sSinifKodu5 " & sorgu_kriter_string(stokkod5, qstokkod5) & " )"
            End If
            'If istihbarat <> "" Then
            '    kriter += " and (( tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + '  ' + tbMusteri.sAciklama5) " & sorgu_kriter_string(istihbarat, qistihbarat) & " )"
            'End If
            'Stok Kontrol
            If stokkodu <> "" Then
                kriter += " AND ( tbStok.sKodu " & sorgu_kriter_string(stokkodu, qstokkodu) & " )"
            End If
            If malincinsi <> "" Then
                kriter += " AND ( tbStok.sAciklama " & sorgu_kriter_string(malincinsi, qmalincinsi) & " )"
            End If
            'Sýnýf Kontrol
            If kod1 <> "" Then
                kriter += " and (  tbMusteriSinifi.sSinifKodu1 " & sorgu_kriter_string(kod1, qkod1) & " )"
            End If
            If kod2 <> "" Then
                kriter += " and (  tbMusteriSinifi.sSinifKodu2 " & sorgu_kriter_string(kod2, qkod2) & " )"
            End If
            If kod3 <> "" Then
                kriter += " and (  tbMusteriSinifi.sSinifKodu3 " & sorgu_kriter_string(kod3, qkod3) & " )"
            End If
            If kod4 <> "" Then
                kriter += " and (  tbMusteriSinifi.sSinifKodu4 " & sorgu_kriter_string(kod4, qkod4) & " )"
            End If
            If kod5 <> "" Then
                kriter += " and (  tbMusteriSinifi.sSinifKodu5 " & sorgu_kriter_string(kod5, qkod5) & " )"
            End If
            If kayitno <> "" Then
                kriter += " and (tbMusteri.nMusteriID " & sorgu_kriter_string(kayitno, qkayitno) & " )"
            End If
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  tbAlisveris.nAlisverisID AS ALISVERISNO, tbAlisveris.sFistipi AS IZAHAT,tbMusteri.nMusteriID,tbMusteri.lKodu, rtrim(tbMusteri.sAdi) + ' ' + rtrim(tbMusteri.sSoyadi) AS Musteri,tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT, tbStok.sKodu, tbStok.sModel, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbStok.sKavala, tbStok.sAciklama, (tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS Miktar, tbAlisverisSiparis.lBrutFiyat, ((tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari) * (tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) / tbAlisverisSiparis.lGCMiktar) AS Tutar, rtrim(tbDepo.sDepo) + ' ' + rtrim(tbDepo.sAciklama) AS Depo, tbAlisveris.lFaturaNo, tbAlisveris.dteFaturaTarihi, tbAlisverisSiparis.dteTeslimEdilecek, dteOnayTarihi, dteTeslimEdilen, CASE tbAlisverisSiparis.bekalan2 WHEN '' THEN '01/01/1900' ELSE (SELECT dteIslemTarihi FROM tbStokFisiDetayi WHERE nIslemID = tbAlisverisSiparis.bEkAlan2) END,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut FROM tbAlisverisSiparis, tbAlisveris, tbMusteri, tbStok, tbRenk, tbDepo WHERE tbAlisverisSiparis.nAlisverisID = tbAlisveris.nAlisverisID AND tbAlisverisSiparis.nGirisCikis = 3 AND tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1 AND tbAlisveris.nMusteriID = tbMusteri.nMusteriID AND tbAlisverisSiparis.nStokID = tbStok.nStokID AND tbAlisverisSiparis.sMagazaKodu = tbDepo.sDepo AND tbStok.sRenk = tbRenk.sRenk AND tbMusteri.lKodu BETWEEN 0 AND 999999999 AND tbAlisveris.dteFaturaTarihi BETWEEN '" & tarih1.ToString.Substring(0, 10) & "' AND '" & tarih2.ToString.Substring(0, 10) & "' AND (tbAlisveris.sFisTipi = 'SP' OR tbAlisveris.sFisTipi = 'SK') AND tbAlisverisSiparis.dteOnayTarihi = '01/01/1900' AND tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048' " & kriter & " ORDER BY tbAlisverisSiparis.dteTeslimEdilecek, tbMusteri.lKodu, tbStok.sKodu")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  tbAlisveris.nAlisverisID AS ALISVERISNO, tbAlisveris.sFistipi AS IZAHAT,tbMusteri.nMusteriID,tbMusteri.lKodu, rtrim(tbMusteri.sAdi) + ' ' + rtrim(tbMusteri.sSoyadi) AS Musteri,tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT, tbStok.sKodu, tbStok.sModel, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbStok.sKavala, tbStok.sAciklama, (tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS Miktar, tbAlisverisSiparis.lBrutFiyat, ((tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari) * (tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) / tbAlisverisSiparis.lGCMiktar) AS Tutar, rtrim(tbDepo.sDepo) + ' ' + rtrim(tbDepo.sAciklama) AS Depo, tbAlisveris.lFaturaNo, tbAlisveris.dteFaturaTarihi, tbAlisverisSiparis.dteTeslimEdilecek, dteOnayTarihi, dteTeslimEdilen, CASE tbAlisverisSiparis.bekalan2 WHEN '' THEN '01/01/1900' ELSE (SELECT dteIslemTarihi FROM tbStokFisiDetayi WHERE nIslemID = tbAlisverisSiparis.bEkAlan2) END,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut,(SELECT SUM(lKalanMiktar) AS siparis FROM (SELECT tbFirma.sKodu AS sFirmaKodu , tbFirma.sAciklama AS sFirmaAdi , tbstok.nstokID , tbStok.sKodu AS sModel , tbStok.sRenk AS sRenk , tbRenk.sRenkAdi AS sRenkAdi , tbStok.sBeden AS sBeden , tbStok.sAciklama , '' AS dteIlkSevkiyatTarihi , STR(tbSiparis.lSiparisNo) + ' - ' + LTRIM(STR(tbSiparis.nSiparisID)) AS sSipNo , tbSiparis.dteSiparisTarihi AS dteSiparisTarihi , tbSiparis.dteTeslimTarihi AS dteTeslimTarihi , tbSiparis.sSiparisIslem , tbSiparis.lMiktari AS SiparisMiktari , SUM(ISNULL(tbStokFisiDetayi.lSevkMiktari , 0)) AS lSevkMiktari , SUM(ISNULL(tbStokFisiDetayi.lSevkIadeMiktari , 0)) AS lSevkIadeMiktari , SUM(ISNULL(tbStokFisiDetayi.lSevkIadeTutari , 0)) AS lSevkIadeTutari , tbSiparis.lReserveMiktari , tbSiparis.lMiktari - SUM(ISNULL(tbStokFisiDetayi.lSevkMiktari , 0)) + SUM(ISNULL(tbStokFisiDetayi.lSevkIadeMiktari , 0)) AS lKalanMiktar FROM (SELECT nSiparisID , isnull(abs(SUM(lGirisMiktar1 * (nGirisCikis - 2))) , 0) lSevkMiktari , isnull(abs(SUM(lGirisTutar * (nGirisCikis - 2))) , 0) lSevkTutari , isnull(abs(SUM(lGirisMiktar1 * (nGirisCikis - 1))) , 0) lSevkIadeMiktari , isnull(abs(SUM(lGirisTutar * (nGirisCikis - 1))) , 0) lSevkIadeTutari FROM tbStokFisiDetayi , tbStok , tbFirma WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID AND tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID AND dteIslemTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND nSiparisID IS NOT NULL GROUP BY nSiparisID) tbStokFisiDetayi RIGHT OUTER JOIN tbStok INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk AND tbStok.sRenk = tbRenk.sRenk INNER JOIN tbSiparis INNER JOIN tbParti ON tbSiparis.nPartiID = tbParti.nPartiID INNER JOIN tbFirma ON tbSiparis.nFirmaID = tbFirma.nFirmaID ON tbStok.nStokID = tbSiparis.nStokID ON tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID WHERE (tbSiparis.bKapandimi = 0) AND (tbSiparis.nSiparisTipi = 2) GROUP BY tbStok.nStokID , tbStok.sKodu , tbStok.sBeden , tbStok.sAciklama , tbFirma.sKodu , tbFirma.sAciklama , tbSiparis.lSiparisNo , tbSiparis.nSiparisID , tbSiparis.dteSiparisTarihi , tbSiparis.dteTeslimTarihi , tbSiparis.sSiparisIslem , tbSiparis.lMiktari , tbSiparis.lReserveMiktari , tbStok.sRenk , tbRenk.sRenkAdi , tbSiparis.nValorGun , CAST(tbSiparis.bKapandimi AS int)) t WHERE (lKalanMiktar > 0) and t.nStokID= tbstok.nStokID) AS Siparis,(SELECT     TOP 1 sSinifKodu1 FROM         tbStokSinifi where nStokID = tbStok.nStokID) AS SINIF1 FROM tbAlisverisSiparis, tbAlisveris, tbMusteri, tbStok, tbRenk, tbDepo,tbMusteriSinifi,tbStokSinifi WHERE tbAlisverisSiparis.nAlisverisID = tbAlisveris.nAlisverisID AND tbAlisverisSiparis.nGirisCikis = 3 AND tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1 AND tbAlisveris.nMusteriID = tbMusteri.nMusteriID AND tbMusteriSinifi.nMusteriID = tbMusteri.nMusteriID AND tbAlisverisSiparis.nStokID = tbStok.nStokID AND tbStokSinifi.nStokID = tbStok.nStokID AND tbAlisverisSiparis.sMagazaKodu = tbDepo.sDepo AND tbStok.sRenk = tbRenk.sRenk AND tbMusteri.lKodu BETWEEN 0 AND 999999999 AND tbAlisveris.dteFaturaTarihi BETWEEN '" & tarih1.ToString.Substring(0, 10) & "' AND '" & tarih2.ToString.Substring(0, 10) & "' AND (tbAlisveris.sFisTipi = 'SP' OR tbAlisveris.sFisTipi = 'SK') AND tbAlisverisSiparis.dteOnayTarihi = '01/01/1900' AND tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048' " & kriter & " ORDER BY tbAlisverisSiparis.dteTeslimEdilecek, tbMusteri.lKodu, tbStok.sKodu")
        kriter = cmd.CommandText
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(DataSet1.Tables(0))
        conn.Close()
        cmd = Nothing
        adapter = Nothing
        N = Nothing
    End Sub
    Private Sub sorgu()
        If GridView1.RowCount > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.Close()
        End If
    End Sub
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Baþlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "Ýçerir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
        ElseIf kriter = "Ýçermez" Then
            sorgu_kriter = "  NOT LIKE '%" & deger & "%' "
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
    Private Sub analiz_envanter()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_envanter
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.stokkodu = dr("sKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_musteri_karti
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("lKodu")
            frm.musteriID = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub stok_satis_detay()
        If GridView1.RowCount > 0 Then
            Dim frm As New frm_stok_cari_satis
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            frm.status = True
            frm.firmano = 100
            frm.donemno = 1
            frm.connection = connection
            frm.islemstatus = True
            frm.stokno = dr("ALISVERISNO")
            frm.fistipi = Trim(dr("IZAHAT").ToString)
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_siparis_bekleyen_tumu()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_siparis_verilen_bekleyen
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sKodu")
            frm.siparis_stok = True
            'frm.nFirmaID = dr("nFirmaID")
            'frm.sec_firma.Checked = True
            'frm.sec_giris.Text = "Giriþler"
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
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
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_pdf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Metin Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyalarý(*.pdf) |*.pdf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara_kriter(1)
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        ara_kriter(1)
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        gorunum_yazdir()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If MenuItem9.Checked = False Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem9.Checked = True
        ElseIf MenuItem9.Checked = True Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem9.Checked = False
        End If
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        If MenuItem10.Checked = False Then
            GridView1.OptionsView.ShowGroupPanel = True
            GridView1.OptionsCustomization.AllowGroup = True
            MenuItem10.Checked = True
        ElseIf MenuItem10.Checked = True Then
            GridView1.OptionsView.ShowGroupPanel = False
            GridView1.OptionsCustomization.AllowGroup = False
            MenuItem10.Checked = False
        End If
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
        Try
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            lbl_istihbarat.Text = dr("ISTIHBARAT")
            dr = Nothing
        Catch ex As Exception
        End Try

    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        analiz_envanter()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        stok_satis_detay()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        analiz_musteri_karti()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        analiz_siparis_bekleyen_tumu()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        ara()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        analiz_musteri_karti()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        'analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_siparis_bekleyen_tumu()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        raporla_pdf()
    End Sub
End Class
