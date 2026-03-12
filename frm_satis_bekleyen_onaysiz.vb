Imports System.Windows.Forms
Imports FastReport
Imports DevExpress.XtraEditors
Public Class frm_satis_bekleyen_onaysiz
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
    Friend WithEvents colMevcut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panelstatus As DevExpress.XtraEditors.PanelControl
    Friend WithEvents barlabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bar As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents colsSinifKodu1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_SinifKodu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colMusteriKodlu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents colsSaticiRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSatici As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo1K As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo1B As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo2K As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo2B As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo3K As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo3B As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo7K As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo7B As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo11K As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo11B As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo13K As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo13B As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colsDepo12K As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo12B As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents colsSinif1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinif3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinif5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents colsEvTelefonu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsTelefonu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAdres As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKefil1AdiSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKefil1Adres As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKefil1EvTelefon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKefil1IsTelefon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKefil2AdiSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKefil2Adres As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKefil2EvTelefon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKefil2IsTelefon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbarkod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTakipEmriNotu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTeslimatciAdiSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_satis_bekleyen_onaysiz))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colMevcut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panelstatus = New DevExpress.XtraEditors.PanelControl()
        Me.barlabel = New DevExpress.XtraEditors.LabelControl()
        Me.bar = New DevExpress.XtraEditors.ProgressBarControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
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
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.DataColumn21 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.collKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMusteri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsModel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenkAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKavala = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBrutFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFaturaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteFaturaTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteTeslimEdilecek = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteOnayTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteTeslimEdilen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIZAHAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSinifKodu1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_SinifKodu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colMusteriKodlu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSaticiRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSatici = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo1K = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo1B = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo2K = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo2B = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo3K = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo3B = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo7K = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo7B = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo11K = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo11B = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo13K = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo13B = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo12K = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo12B = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSinif1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSinif3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSinif5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEvTelefonu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIsTelefonu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAdres = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKefil1AdiSoyadi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKefil1Adres = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKefil1EvTelefon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKefil1IsTelefon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKefil2AdiSoyadi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKefil2Adres = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKefil2EvTelefon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKefil2IsTelefon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbarkod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTakipEmriNotu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTeslimatciAdiSoyadi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelstatus.SuspendLayout()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_SinifKodu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colMevcut
        '
        Me.colMevcut.Caption = "Mevcut"
        Me.colMevcut.DisplayFormat.FormatString = "#,0.00"
        Me.colMevcut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMevcut.FieldName = "Mevcut"
        Me.colMevcut.Name = "colMevcut"
        Me.colMevcut.Visible = True
        Me.colMevcut.VisibleIndex = 10
        Me.colMevcut.Width = 116
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.CheckEdit1)
        Me.PanelControl1.Controls.Add(Me.lbl_istihbarat)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 72)
        Me.PanelControl1.TabIndex = 2
        '
        'CheckEdit1
        '
        Me.CheckEdit1.EditValue = True
        Me.CheckEdit1.Location = New System.Drawing.Point(116, 26)
        Me.CheckEdit1.MenuManager = Me.BarManager1
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Müþterileri Grupla"
        Me.CheckEdit1.Size = New System.Drawing.Size(112, 19)
        Me.CheckEdit1.TabIndex = 35
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7})
        Me.BarManager1.MaxItemId = 7
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Musteri Karti,F4"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Envanter,F6"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Satisi Goster,F7"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Excel"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Text"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Mail"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 427)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 427)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 427)
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_istihbarat.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(524, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(298, 68)
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
        Me.PanelControl2.Location = New System.Drawing.Point(0, 379)
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
        Me.PanelControl3.Size = New System.Drawing.Size(824, 307)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 303)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panelstatus)
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(818, 270)
        Me.XtraTabPage1.Text = "Satýþlar"
        '
        'Panelstatus
        '
        Me.Panelstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panelstatus.Controls.Add(Me.barlabel)
        Me.Panelstatus.Controls.Add(Me.bar)
        Me.Panelstatus.Location = New System.Drawing.Point(86, 85)
        Me.Panelstatus.Name = "Panelstatus"
        Me.Panelstatus.Size = New System.Drawing.Size(647, 64)
        Me.Panelstatus.TabIndex = 2
        Me.Panelstatus.Visible = False
        '
        'barlabel
        '
        Me.barlabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barlabel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.barlabel.Appearance.ForeColor = System.Drawing.Color.Black
        Me.barlabel.Location = New System.Drawing.Point(8, 14)
        Me.barlabel.Name = "barlabel"
        Me.barlabel.Size = New System.Drawing.Size(46, 13)
        Me.barlabel.TabIndex = 3
        Me.barlabel.Text = "barlabel"
        '
        'bar
        '
        Me.bar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar.Location = New System.Drawing.Point(8, 33)
        Me.bar.Name = "bar"
        Me.bar.Properties.ShowTitle = True
        Me.bar.Size = New System.Drawing.Size(631, 18)
        Me.bar.TabIndex = 2
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
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_SinifKodu})
        Me.GridControl1.Size = New System.Drawing.Size(818, 270)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem14, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem25, Me.MenuItem24, Me.MenuItem26, Me.MenuItem20, Me.MenuItem19, Me.MenuItem15, Me.MenuItem5, Me.MenuItem7, Me.MenuItem8, Me.MenuItem16, Me.MenuItem6, Me.MenuItem9, Me.MenuItem10, Me.MenuItem17, Me.MenuItem11, Me.MenuItem12, Me.MenuItem18, Me.MenuItem13})
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
        'MenuItem25
        '
        Me.MenuItem25.Index = 5
        Me.MenuItem25.Text = "-"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 6
        Me.MenuItem24.Text = "Takibe Al"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 7
        Me.MenuItem26.Text = "SMS Gönder"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 8
        Me.MenuItem20.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 9
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
        Me.MenuItem15.Index = 10
        Me.MenuItem15.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 11
        Me.MenuItem5.Text = "Görünümü Düzenle"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 12
        Me.MenuItem7.Text = "Görünümü Kaydet"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 13
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem8.Text = "Görünümü Yazdýr"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 14
        Me.MenuItem16.Text = "-"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 15
        Me.MenuItem6.Text = "Hýzlý Filtre"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 16
        Me.MenuItem9.Text = "Filtrele"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 17
        Me.MenuItem10.Text = "Gruplandýr"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 18
        Me.MenuItem17.Text = "-"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 19
        Me.MenuItem11.Text = "Satýrlarý Aç"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 20
        Me.MenuItem12.Text = "Satýrlarý Kapat"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 21
        Me.MenuItem18.Text = "-"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 22
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21})
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
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "Sinif1"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "Sinif2"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "Sinif3"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.collKodu, Me.colMusteri, Me.colsKodu, Me.colsModel, Me.colsRenk, Me.colsRenkAdi, Me.colsBeden, Me.colsKavala, Me.colsAciklama, Me.colMiktar, Me.collBrutFiyat, Me.colTutar, Me.colDepo, Me.collFaturaNo, Me.coldteFaturaTarihi, Me.coldteTeslimEdilecek, Me.coldteOnayTarihi, Me.coldteTeslimEdilen, Me.colIZAHAT, Me.colMevcut, Me.colsSinifKodu1, Me.colMusteriKodlu, Me.colSINIF2, Me.colsSaticiRumuzu, Me.colsSatici, Me.colsDepo1K, Me.colsDepo1B, Me.colsDepo2K, Me.colsDepo2B, Me.colsDepo3K, Me.colsDepo3B, Me.colsDepo7K, Me.colsDepo7B, Me.colsDepo11K, Me.colsDepo11B, Me.colsDepo13K, Me.colsDepo13B, Me.colsDepo12K, Me.colsDepo12B, Me.colsSinif1, Me.colsSinif3, Me.colsSinif5, Me.colsEvTelefonu, Me.colsIsTelefonu, Me.colsAdres, Me.colsKefil1AdiSoyadi, Me.colsKefil1Adres, Me.colsKefil1EvTelefon, Me.colsKefil1IsTelefon, Me.colsKefil2AdiSoyadi, Me.colsKefil2Adres, Me.colsKefil2EvTelefon, Me.colsKefil2IsTelefon, Me.colbarkod, Me.colTakipEmriNotu, Me.colTeslimatciAdiSoyadi})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(342, 287, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.colMevcut
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.colMevcut
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition2.Value1 = "0"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", Me.colsKodu, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", Me.colMiktar, "{0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", Me.colTutar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", Nothing, " :{0} prç Ürün"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", Nothing, "Toplam : {0:#,0.##} Adet"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", Nothing, "ToplamTutar: {0:#,0.00}")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
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
        Me.collKodu.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.collKodu.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[True]
        Me.collKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "lKodu", "{0} Kayýt")})
        Me.collKodu.Visible = True
        Me.collKodu.VisibleIndex = 3
        Me.collKodu.Width = 85
        '
        'colMusteri
        '
        Me.colMusteri.Caption = "Müþteri Adý"
        Me.colMusteri.FieldName = "Musteri"
        Me.colMusteri.Name = "colMusteri"
        Me.colMusteri.Visible = True
        Me.colMusteri.VisibleIndex = 4
        Me.colMusteri.Width = 141
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Stok Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 5
        Me.colsKodu.Width = 80
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
        Me.colsRenkAdi.Width = 76
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
        Me.colsAciklama.Width = 127
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
        Me.colMiktar.Width = 76
        '
        'collBrutFiyat
        '
        Me.collBrutFiyat.Caption = "Birim Fiyat"
        Me.collBrutFiyat.DisplayFormat.FormatString = "#,0.00"
        Me.collBrutFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutFiyat.FieldName = "lBrutFiyat"
        Me.collBrutFiyat.Name = "collBrutFiyat"
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
        Me.colTutar.Width = 38
        '
        'colDepo
        '
        Me.colDepo.Caption = "Depo"
        Me.colDepo.FieldName = "Depo"
        Me.colDepo.Name = "colDepo"
        Me.colDepo.Visible = True
        Me.colDepo.VisibleIndex = 9
        Me.colDepo.Width = 165
        '
        'collFaturaNo
        '
        Me.collFaturaNo.Caption = "Fiþ No"
        Me.collFaturaNo.FieldName = "lFaturaNo"
        Me.collFaturaNo.Name = "collFaturaNo"
        Me.collFaturaNo.Visible = True
        Me.collFaturaNo.VisibleIndex = 2
        Me.collFaturaNo.Width = 83
        '
        'coldteFaturaTarihi
        '
        Me.coldteFaturaTarihi.Caption = "Tarih"
        Me.coldteFaturaTarihi.FieldName = "dteFaturaTarihi"
        Me.coldteFaturaTarihi.Name = "coldteFaturaTarihi"
        Me.coldteFaturaTarihi.Visible = True
        Me.coldteFaturaTarihi.VisibleIndex = 1
        Me.coldteFaturaTarihi.Width = 73
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
        Me.colIZAHAT.Width = 61
        '
        'colsSinifKodu1
        '
        Me.colsSinifKodu1.Caption = "Firma"
        Me.colsSinifKodu1.ColumnEdit = Me.sec_SinifKodu
        Me.colsSinifKodu1.FieldName = "sSinifKodu1"
        Me.colsSinifKodu1.Name = "colsSinifKodu1"
        '
        'sec_SinifKodu
        '
        Me.sec_SinifKodu.AutoHeight = False
        Me.sec_SinifKodu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_SinifKodu.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sSinifKodu1", "SýnýfKodu"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sAciklama", "Açýklama")})
        Me.sec_SinifKodu.DisplayMember = "sAciklama"
        Me.sec_SinifKodu.Name = "sec_SinifKodu"
        Me.sec_SinifKodu.ShowFooter = False
        Me.sec_SinifKodu.ShowHeader = False
        Me.sec_SinifKodu.ShowLines = False
        Me.sec_SinifKodu.ValueMember = "sSinifKodu"
        '
        'colMusteriKodlu
        '
        Me.colMusteriKodlu.Caption = "Müþteri"
        Me.colMusteriKodlu.FieldName = "MusteriKodlu"
        Me.colMusteriKodlu.Name = "colMusteriKodlu"
        '
        'colSINIF2
        '
        Me.colSINIF2.Caption = "TeslimatÞekli"
        Me.colSINIF2.FieldName = "SINIF2"
        Me.colSINIF2.Name = "colSINIF2"
        '
        'colsSaticiRumuzu
        '
        Me.colsSaticiRumuzu.Caption = "SaticiRumuzu"
        Me.colsSaticiRumuzu.FieldName = "sSaticiRumuzu"
        Me.colsSaticiRumuzu.Name = "colsSaticiRumuzu"
        '
        'colsSatici
        '
        Me.colsSatici.Caption = "Satici"
        Me.colsSatici.FieldName = "sSatici"
        Me.colsSatici.Name = "colsSatici"
        Me.colsSatici.Width = 152
        '
        'colsDepo1K
        '
        Me.colsDepo1K.Caption = "D001-Kalan"
        Me.colsDepo1K.FieldName = "D001-Kalan"
        Me.colsDepo1K.Name = "colsDepo1K"
        '
        'colsDepo1B
        '
        Me.colsDepo1B.Caption = "D001-Bekleyen"
        Me.colsDepo1B.FieldName = "D001-Bekleyen"
        Me.colsDepo1B.Name = "colsDepo1B"
        '
        'colsDepo2K
        '
        Me.colsDepo2K.Caption = "D002-Kalan"
        Me.colsDepo2K.FieldName = "D002-Kalan"
        Me.colsDepo2K.Name = "colsDepo2K"
        '
        'colsDepo2B
        '
        Me.colsDepo2B.Caption = "D002-Bekleyen"
        Me.colsDepo2B.FieldName = "D002-Bekleyen"
        Me.colsDepo2B.Name = "colsDepo2B"
        '
        'colsDepo3K
        '
        Me.colsDepo3K.Caption = "D003-Kalan"
        Me.colsDepo3K.FieldName = "D003-Kalan"
        Me.colsDepo3K.Name = "colsDepo3K"
        '
        'colsDepo3B
        '
        Me.colsDepo3B.Caption = "D003-Bekleyen"
        Me.colsDepo3B.FieldName = "D003-Bekleyen"
        Me.colsDepo3B.Name = "colsDepo3B"
        '
        'colsDepo7K
        '
        Me.colsDepo7K.Caption = "D007-Kalan"
        Me.colsDepo7K.FieldName = "D007-Kalan"
        Me.colsDepo7K.Name = "colsDepo7K"
        '
        'colsDepo7B
        '
        Me.colsDepo7B.Caption = "D007-Bekleyen"
        Me.colsDepo7B.FieldName = "D007-Bekleyen"
        Me.colsDepo7B.Name = "colsDepo7B"
        '
        'colsDepo11K
        '
        Me.colsDepo11K.Caption = "D011-Kalan"
        Me.colsDepo11K.FieldName = "D011-Kalan"
        Me.colsDepo11K.Name = "colsDepo11K"
        '
        'colsDepo11B
        '
        Me.colsDepo11B.Caption = "D011-Bekleyen"
        Me.colsDepo11B.FieldName = "D011-Bekleyen"
        Me.colsDepo11B.Name = "colsDepo11B"
        '
        'colsDepo13K
        '
        Me.colsDepo13K.Caption = "D013-Kalan"
        Me.colsDepo13K.FieldName = "D013-Kalan"
        Me.colsDepo13K.Name = "colsDepo13K"
        '
        'colsDepo13B
        '
        Me.colsDepo13B.Caption = "D013-Bekleyen"
        Me.colsDepo13B.FieldName = "D013-Bekleyen"
        Me.colsDepo13B.Name = "colsDepo13B"
        '
        'colsDepo12K
        '
        Me.colsDepo12K.Caption = "D012-Kalan"
        Me.colsDepo12K.FieldName = "D012-Kalan"
        Me.colsDepo12K.Name = "colsDepo12K"
        '
        'colsDepo12B
        '
        Me.colsDepo12B.Caption = "D012-Bekleyen"
        Me.colsDepo12B.FieldName = "D012-Bekleyen"
        Me.colsDepo12B.Name = "colsDepo12B"
        '
        'colsSinif1
        '
        Me.colsSinif1.Caption = "Sýnýf 1"
        Me.colsSinif1.FieldName = "Sinif1"
        Me.colsSinif1.Name = "colsSinif1"
        '
        'colsSinif3
        '
        Me.colsSinif3.Caption = "Sýnýf 3"
        Me.colsSinif3.FieldName = "Sinif3"
        Me.colsSinif3.Name = "colsSinif3"
        '
        'colsSinif5
        '
        Me.colsSinif5.Caption = "Sýnýf 5"
        Me.colsSinif5.FieldName = "Sinif5"
        Me.colsSinif5.Name = "colsSinif5"
        '
        'colsEvTelefonu
        '
        Me.colsEvTelefonu.Caption = "Ev Telefonu"
        Me.colsEvTelefonu.FieldName = "sEvTelefonu"
        Me.colsEvTelefonu.Name = "colsEvTelefonu"
        '
        'colsIsTelefonu
        '
        Me.colsIsTelefonu.Caption = "Ýþ Telefonu"
        Me.colsIsTelefonu.FieldName = "sIsTelefonu"
        Me.colsIsTelefonu.Name = "colsIsTelefonu"
        '
        'colsAdres
        '
        Me.colsAdres.Caption = "Ev Adresi"
        Me.colsAdres.FieldName = "sAdres"
        Me.colsAdres.Name = "colsAdres"
        '
        'colsKefil1AdiSoyadi
        '
        Me.colsKefil1AdiSoyadi.Caption = "Kefil 1 Ad-Soyad"
        Me.colsKefil1AdiSoyadi.FieldName = "sKefil1AdiSoyadi"
        Me.colsKefil1AdiSoyadi.Name = "colsKefil1AdiSoyadi"
        '
        'colsKefil1Adres
        '
        Me.colsKefil1Adres.Caption = "Kefil 1 Ev Adresi"
        Me.colsKefil1Adres.FieldName = "sKefil1Adres"
        Me.colsKefil1Adres.Name = "colsKefil1Adres"
        '
        'colsKefil1EvTelefon
        '
        Me.colsKefil1EvTelefon.Caption = "Kefil 1 Ev Telefonu"
        Me.colsKefil1EvTelefon.FieldName = "sKefil1EvTelefon"
        Me.colsKefil1EvTelefon.Name = "colsKefil1EvTelefon"
        '
        'colsKefil1IsTelefon
        '
        Me.colsKefil1IsTelefon.Caption = "Kefil 1 Ýþ Telefonu"
        Me.colsKefil1IsTelefon.FieldName = "sKefil1IsTelefon"
        Me.colsKefil1IsTelefon.Name = "colsKefil1IsTelefon"
        '
        'colsKefil2AdiSoyadi
        '
        Me.colsKefil2AdiSoyadi.Caption = "Kefil 2 Ad-Soyad"
        Me.colsKefil2AdiSoyadi.FieldName = "sKefil2AdiSoyadi"
        Me.colsKefil2AdiSoyadi.Name = "colsKefil2AdiSoyadi"
        '
        'colsKefil2Adres
        '
        Me.colsKefil2Adres.Caption = "Kefil 2 Adres"
        Me.colsKefil2Adres.FieldName = "sKefil2Adres"
        Me.colsKefil2Adres.Name = "colsKefil2Adres"
        '
        'colsKefil2EvTelefon
        '
        Me.colsKefil2EvTelefon.Caption = "Kefil 2 Ev Telefonu"
        Me.colsKefil2EvTelefon.FieldName = "sKefil2EvTelefon"
        Me.colsKefil2EvTelefon.Name = "colsKefil2EvTelefon"
        '
        'colsKefil2IsTelefon
        '
        Me.colsKefil2IsTelefon.Caption = "Kefil 2 Ýþ Telefonu"
        Me.colsKefil2IsTelefon.FieldName = "sKefil2IsTelefon"
        Me.colsKefil2IsTelefon.Name = "colsKefil2IsTelefon"
        '
        'colbarkod
        '
        Me.colbarkod.Caption = "Barkod"
        Me.colbarkod.FieldName = "barkod"
        Me.colbarkod.Name = "colbarkod"
        '
        'colTakipEmriNotu
        '
        Me.colTakipEmriNotu.Caption = "Takip Emri Notu"
        Me.colTakipEmriNotu.FieldName = "TakipEmriNotu"
        Me.colTakipEmriNotu.Name = "colTakipEmriNotu"
        '
        'colTeslimatciAdiSoyadi
        '
        Me.colTeslimatciAdiSoyadi.Caption = "Teslimatçý Ad-Soyad"
        Me.colTeslimatciAdiSoyadi.FieldName = "TeslimatciAdiSoyadi"
        Me.colTeslimatciAdiSoyadi.Name = "colTeslimatciAdiSoyadi"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Onay Bekleyen Satýþlar", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Satýþ Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_satis_bekleyen_onaysiz
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 449)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_satis_bekleyen_onaysiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Onay Bekleyen Satýþlar"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelstatus.ResumeLayout(False)
        Me.Panelstatus.PerformLayout()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_SinifKodu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public status As Boolean
    Dim kriter
    Public kasiyerno = 0
    Public kasiyer = ""
    Public firmakodu As String
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
    Public stoklar
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
    Public cokluMusteri As Boolean = False
    Public frf_islem As String = "mektup"
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim adapter As New OleDb.OleDbDataAdapter
    Public islemstatus As Boolean = False
    Public parametre_islem As Integer = 0
    Public musteri_takip_karti As Boolean = False
    Public emir_musteri_takipMi As Boolean = False
    Public emir_musteri_takip_kartID As String = ""
    Dim raporSorgusu As String = ""
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
        sec_SinifKodu.DataSource = sorgu(sorgu_query("SELECT     * FROM         tbSSinif1")).Tables(0) 'DataSet2.Tables(0)
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
        Dim kriterDepolar As String = ""
        If emir_musteri_takipMi = True Then
            kriterDepolar = ",ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D001') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket.lGirisMiktar1 - hareket.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D001') and hareket.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'D001-Kalan', "
            kriterDepolar += "ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D001') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D001') and hareket.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'D001-Bekleyen', "
            kriterDepolar += "ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D002') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket.lGirisMiktar1 - hareket.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D002') and hareket.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'D002-Kalan', "
            kriterDepolar += "ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D002') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D002') and hareket.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'D002-Bekleyen', "
            kriterDepolar += "ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D003') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket.lGirisMiktar1 - hareket.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D003') and hareket.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'D003-Kalan', "
            kriterDepolar += "ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D003') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D003') and hareket.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'D003-Bekleyen', "
            kriterDepolar += "ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D007') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket.lGirisMiktar1 - hareket.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D007') and hareket.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'D007-Kalan', "
            kriterDepolar += "ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D007') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D007') and hareket.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'D007-Bekleyen', "
            kriterDepolar += "ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D011') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket.lGirisMiktar1 - hareket.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D011') and hareket.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'D011-Kalan', "
            kriterDepolar += "ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D011') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D011') and hareket.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'D011-Bekleyen', "
            kriterDepolar += "ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D012') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket.lGirisMiktar1 - hareket.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D012') and hareket.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'D012-Kalan', "
            kriterDepolar += "ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D012') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D012') and hareket.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'D012-Bekleyen', "
            kriterDepolar += "ISNULL((SELECT SUM(KALAN) AS KALAN FROM (SELECT 0 AS KALAN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D013') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT ISNULL(SUM(hareket.lGirisMiktar1 - hareket.lCikisMiktar1), 0) AS KALAN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D013') and hareket.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'D013-Kalan', "
            kriterDepolar += "ISNULL((SELECT SUM(BEKLEYEN) AS BEKLEYEN FROM (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D013') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') GROUP BY depo.sDepo UNION SELECT 0 AS BEKLEYEN FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 WHERE (stok.sKodu = tbStok.sKodu) AND (depo.sDepo = 'D013') and hareket.dteFisTarihi <= '31/12/2078' GROUP BY depo.sDepo) as tt), 0) as 'D013-Bekleyen', "
            kriterDepolar += "ISNULL((Select sAciklama From tbSSinif1 Where (sSinifKodu = (Select sSinifKodu1 from tbStokSinifi Where nStokID = tbStok.nStokID))), '') as Sinif1, "
            kriterDepolar += "ISNULL((Select sAciklama From tbSSinif3 Where (sSinifKodu = (Select sSinifKodu3 from tbStokSinifi Where nStokID = tbStok.nStokID))), '') as Sinif3, "
            kriterDepolar += "ISNULL((Select sAciklama From tbSSinif5 Where (sSinifKodu = (Select sSinifKodu5 from tbStokSinifi Where nStokID = tbStok.nStokID))), '') as Sinif5 "
        Else
            kriterDepolar = ""
        End If
        kriter = ""
        If carino <> 0 Then
            kriter += " WHERE (tbMusteri.nMusteriID = " & carino & ") "
        Else
            'kriter += "WHERE ( tbMusteri.nMusteriID >= 0)"
            If firmakodu <> "" Then
                If cokluMusteri = True Then
                    kriter += " AND (tbMusteri.lKodu IN(" & firmakodu & "))"
                Else
                    kriter += " AND (tbMusteri.lKodu " & sorgu_kriter_string(firmakodu, qfirmakodu) & ")"
                End If
            End If
            If emir_musteri_takipMi = True Then
                kriter += " AND ((tbAlisVeris.lFaturaNo IN(Select lFaturaNo From aEmirMusteriTakipUrunler Where IND IN(" & emir_musteri_takip_kartID & "))) AND (tbStok.sKodu IN(Select sKodu From aEmirMusteriTakipUrunler Where IND IN(" & emir_musteri_takip_kartID & "))))"
            End If
            If firmaadi <> "" Then
                kriter += " AND ((tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi) " & sorgu_kriter_string(firmaadi, qfirmaadi) & ")"
            End If
            If adres <> "" Then
                kriter += " AND (tbMusteri.sEvAdresi1  " & sorgu_kriter_string(adres, qadres) & " )"
            End If
            If telefon <> "" Then
                kriter += " and (tbMusteri.sEvTelefonu " & sorgu_kriter_string(telefon, qtelefon) & " )"
            End If
            'Açýklama Kontrol
            If stokkod1 <> "" Then
                kriter += " AND tbStok.nStokID IN(SELECT tbStok.nStokID FROM tbStok INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif1.sAciklama " & sorgu_kriter_string(stokkod1, qstokkod1) & " )"
            End If
            If stokkod2 <> "" Then
                kriter += " AND tbStok.nStokID IN(SELECT tbStok.nStokID FROM tbStok INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif2.sAciklama " & sorgu_kriter_string(stokkod2, qstokkod2) & " )"
            End If
            If stokkod3 <> "" Then
                kriter += " AND tbStok.nStokID IN(SELECT tbStok.nStokID FROM tbStok INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif3.sAciklama " & sorgu_kriter_string(stokkod3, qstokkod3) & " )"
            End If
            If stokkod4 <> "" Then
                kriter += " AND tbStok.nStokID IN(SELECT tbStok.nStokID FROM tbStok INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif4.sAciklama " & sorgu_kriter_string(stokkod4, qstokkod4) & " )"
            End If
            If stokkod5 <> "" Then
                kriter += " AND tbStok.nStokID IN(SELECT tbStok.nStokID FROM tbStok INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif5.sAciklama " & sorgu_kriter_string(stokkod5, qstokkod5) & " )"
            End If
            If stokkod1 <> "" Then
                kriter += " and (tbStokSinifi.sSinifKodu1 " & sorgu_kriter_string(stokkod1, qstokkod1) & ")"
            End If
            If stokkod2 <> "" Then
                kriter += " and (tbStokSinifi.sSinifKodu2 " & sorgu_kriter_string(stokkod2, qstokkod2) & ")"
            End If
            If stokkod3 <> "" Then
                kriter += " and (tbStokSinifi.sSinifKodu3 " & sorgu_kriter_string(stokkod3, qstokkod3) & ")"
            End If
            If stokkod4 <> "" Then
                kriter += " and (tbStokSinifi.sSinifKodu4  " & sorgu_kriter_string(stokkod4, qstokkod4) & ")"
            End If
            If stokkod5 <> "" Then
                kriter += " and (tbStokSinifi.sSinifKodu5 " & sorgu_kriter_string(stokkod5, qstokkod5) & ")"
            End If
            If istihbarat <> "" Then
                kriter += " and ((tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + '  ' + tbMusteri.sAciklama5) " & sorgu_kriter_string(istihbarat, qistihbarat) & ")"
            End If
            'Stok Kontrol
            If stokkodu <> "" Then
                kriter += " AND (tbStok.sKodu " & sorgu_kriter_string(stokkodu, qstokkodu) & ")"
            End If
            If stoklar <> "" Then
                kriter += " AND (tbStok.nStokID IN " & stoklar & ") "
            End If
            If malincinsi <> "" Then
                kriter += " AND (tbStok.sAciklama " & sorgu_kriter_string(malincinsi, qmalincinsi) & ")"
            End If
            'Sýnýf Kontrol
            If kod1 <> "" Then
                kriter += " and (tbMusteriSinifi.sSinifKodu1 " & sorgu_kriter_string(kod1, qkod1) & ")"
            End If
            If kod2 <> "" Then
                kriter += " and (tbMusteriSinifi.sSinifKodu2 " & sorgu_kriter_string(kod2, qkod2) & ")"
            End If
            If kod3 <> "" Then
                kriter += " and (tbMusteriSinifi.sSinifKodu3 " & sorgu_kriter_string(kod3, qkod3) & ")"
            End If
            If kod4 <> "" Then
                kriter += " and (tbMusteriSinifi.sSinifKodu4 " & sorgu_kriter_string(kod4, qkod4) & ")"
            End If
            If kod5 <> "" Then
                kriter += " and (tbMusteriSinifi.sSinifKodu5 " & sorgu_kriter_string(kod5, qkod5) & ")"
            End If
            If kayitno <> "" Then
                kriter += " and (tbMusteri.nMusteriID " & sorgu_kriter_string(kayitno, qkayitno) & ")"
            End If
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If parametre_islem = 0 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbAlisveris.nAlisverisID AS ALISVERISNO, tbAlisveris.sFistipi AS IZAHAT,tbMusteri.nMusteriID,tbMusteri.lKodu,tbMusteri.sAdi,tbMusteri.sSoyadi,tbMusteri.sGSM, rtrim(tbMusteri.sAdi) + ' ' + rtrim(tbMusteri.sSoyadi) AS Musteri, rtrim(tbMusteri.lKodu) + ' ' + rtrim(tbMusteri.sAdi) + ' ' + rtrim(tbMusteri.sSoyadi) AS MusteriKodlu, tbMusteri.sEvTelefonu, tbMusteri.sIsTelefonu, (tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvIl + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu) as sAdres, (select sAdi + ' ' + sSoyadi from tbMusteriKefil1 kefil1 Where kefil1.nMusteriID = tbMusteri.nMusteriID) as sKefil1AdiSoyadi,(select sEvAdresi1 + ' ' + sEvAdresi2 + ' ' + sEvIl + ' ' + sEvSemt + ' ' + sEvPostaKodu from tbMusteriKefil1 kefil1 Where kefil1.nMusteriID = tbMusteri.nMusteriID) as sKefil1Adres,(select sEvTelefonu from tbMusteriKefil1 kefil1 Where kefil1.nMusteriID = tbMusteri.nMusteriID) as sKefil1EvTelefon,(select sIsTelefonu from tbMusteriKefil1 kefil1 Where kefil1.nMusteriID = tbMusteri.nMusteriID) as sKefil1IsTelefon,(select sAdi + ' ' + sSoyadi from tbMusteriKefil2 kefil2 Where kefil2.nMusteriID = tbMusteri.nMusteriID) as sKefil2AdiSoyadi,(select sEvAdresi1 + ' ' + sEvAdresi2 + ' ' + sEvIl + ' ' + sEvSemt + ' ' + sEvPostaKodu from tbMusteriKefil2 kefil2 Where kefil2.nMusteriID = tbMusteri.nMusteriID) as sKefil2Adres,(select sEvTelefonu from tbMusteriKefil2 kefil2 Where kefil2.nMusteriID = tbMusteri.nMusteriID) as sKefil2EvTelefon,(select sIsTelefonu from tbMusteriKefil2 kefil2 Where kefil2.nMusteriID = tbMusteri.nMusteriID) as sKefil2IsTelefon, tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT,(SELECT tbMSinif2.sAciklama FROM tbMusteriSinifi INNER JOIN tbMSinif2 ON tbMusteriSinifi.sSinifKodu2 = tbMSinif2.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = tbMusteri.nMusteriID)) AS SINIF2, tbStok.sKodu, tbStok.sModel, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbStok.sKavala, tbStok.sAciklama, (select Top 1 sBarkod from tbStokBarkodu barkodu Where (barkodu.nStokID = tbStok.nStokID) AND (barkodu.nKisim = 0)) as barkod, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut,(SELECT sSinifKodu1 FROM tbStokSinifi Where nStokID =tbStok.nStokID) AS sSinifKodu1, (tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS Miktar, tbAlisverisSiparis.lBrutFiyat, ((tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari) * (tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) / tbAlisverisSiparis.lGCMiktar) AS Tutar, rtrim(tbDepo.sDepo) + ' ' + rtrim(tbDepo.sAciklama) AS Depo, tbAlisveris.lFaturaNo, tbAlisveris.dteFaturaTarihi, tbAlisverisSiparis.dteTeslimEdilecek, tbAlisVerisSiparis.sSaticiRumuzu,tbSatici.sAdi + ' ' + tbSatici.sSoyadi as sSatici, dteOnayTarihi, dteTeslimEdilen, CASE tbAlisverisSiparis.bekalan2 WHEN '' THEN '01/01/1900' ELSE (SELECT dteIslemTarihi FROM tbStokFisiDetayi WHERE nIslemID = tbAlisverisSiparis.bEkAlan2) END " & kriterDepolar & ", (Select top 1 TakipAciklama From aEmirMusteriTakip where IND IN(select IND from aEmirMusteriTakipUrunler where lFaturaNo =tbAlisVeris.lFaturaNo)) as TakipEmriNotu, (Select top 1 Personel From aEmirMusteriTakip where IND IN(select IND from aEmirMusteriTakipUrunler where lFaturaNo =tbAlisVeris.lFaturaNo)) as TeslimatciAdiSoyadi FROM tbAlisverisSiparis, tbAlisveris, tbMusteri, tbStok, tbRenk, tbDepo,tbSatici,tbMusteriSinifi,tbStokSinifi WHERE tbAlisverisSiparis.nAlisverisID = tbAlisveris.nAlisverisID AND tbAlisverisSiparis.nGirisCikis = 3 AND tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1 AND tbAlisveris.nMusteriID = tbMusteri.nMusteriID AND tbMusteriSinifi.nMusteriID = tbMusteri.nMusteriID AND tbStokSinifi.nStokID = tbStok.nStokID AND tbAlisverisSiparis.nStokID = tbStok.nStokID AND tbAlisverisSiparis.sMagazaKodu = tbDepo.sDepo AND tbAlisVerisSiparis.sSaticiRumuzu = tbSatici.sSaticiRumuzu AND tbStok.sRenk = tbRenk.sRenk AND tbMusteri.lKodu BETWEEN 0 AND 999999999 AND tbAlisveris.dteFaturaTarihi BETWEEN '" & tarih1.ToString.Substring(0, 10) & "' AND '" & tarih2.ToString.Substring(0, 10) & "' AND (tbAlisveris.sFisTipi = 'SP' OR tbAlisveris.sFisTipi = 'SK') AND tbAlisverisSiparis.dteOnayTarihi = '01/01/1900' AND tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048' " & kriter & " ORDER BY tbAlisverisSiparis.dteTeslimEdilecek, tbMusteri.lKodu, tbStok.sKodu")
        ElseIf islem = 1 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '' as sEvTelefonu, '' as sIsTelefonu, '' as sAdres, '' as sKefil1AdiSoyadi, '' as sKefil1Adres, '' as sKefil1EvTelefon, '' as sKefil1IsTelefon, '' as sKefil2AdiSoyadi, '' as sKefil2Adres, '' as sKefil2EvTelefon, '' as sKefil2IsTelefon, '' as barkod, '' as TakipEmriNotu, '' as TeslimatciAdiSoyadi, tbAlisveris.nAlisverisID AS ALISVERISNO, tbAlisveris.sFistipi AS IZAHAT,tbMusteri.nMusteriID,tbMusteri.lKodu,tbMusteri.sAdi,tbMusteri.sSoyadi,tbMusteri.sGSM, rtrim(tbMusteri.sAdi) + ' ' + rtrim(tbMusteri.sSoyadi) AS Musteri,rtrim(tbMusteri.lKodu) + ' ' + rtrim(tbMusteri.sAdi) + ' ' + rtrim(tbMusteri.sSoyadi) AS MusteriKodlu,tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT, (SELECT tbMSinif2.sAciklama FROM tbMusteriSinifi INNER JOIN tbMSinif2 ON tbMusteriSinifi.sSinifKodu2 = tbMSinif2.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = tbMusteri.nMusteriID)) AS SINIF2, tbStok.sKodu, tbStok.sModel, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbStok.sKavala, tbStok.sAciklama,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut,(SELECT sSinifKodu1 FROM tbStokSinifi Where nStokID =tbStok.nStokID) AS sSinifKodu1, (tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS Miktar, tbAlisverisSiparis.lBrutFiyat, ((tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari) * (tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) / tbAlisverisSiparis.lGCMiktar) AS Tutar, rtrim(tbDepo.sDepo) + ' ' + rtrim(tbDepo.sAciklama) AS Depo, tbAlisveris.lFaturaNo, tbAlisveris.dteFaturaTarihi, tbAlisverisSiparis.dteTeslimEdilecek, tbAlisVerisSiparis.sSaticiRumuzu,tbSatici.sAdi + ' ' + tbSatici.sSoyadi as sSatici,dteOnayTarihi, dteTeslimEdilen, CASE tbAlisverisSiparis.bekalan2 WHEN '' THEN '01/01/1900' ELSE (SELECT dteIslemTarihi FROM tbStokFisiDetayi WHERE nIslemID = tbAlisverisSiparis.bEkAlan2) END FROM tbAlisverisSiparis, tbAlisveris, tbMusteri, tbStok, tbRenk, tbDepo,tbSatici,tbMusteriSinifi,tbStokSinifi WHERE tbAlisverisSiparis.nAlisverisID = tbAlisveris.nAlisverisID AND tbAlisverisSiparis.nGirisCikis = 3 AND tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1 AND tbAlisveris.nMusteriID = tbMusteri.nMusteriID AND tbMusteriSinifi.nMusteriID = tbMusteri.nMusteriID AND tbStokSinifi.nStokID = tbStok.nStokID AND tbAlisverisSiparis.nStokID = tbStok.nStokID AND tbAlisverisSiparis.sMagazaKodu = tbDepo.sDepo AND tbAlisVerisSiparis.sSaticiRumuzu = tbSatici.sSaticiRumuzu AND tbStok.sRenk = tbRenk.sRenk AND tbMusteri.lKodu BETWEEN 0 AND 999999999 AND tbAlisveris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048' AND (tbAlisveris.sFisTipi = 'SP' OR tbAlisveris.sFisTipi = 'SK') AND tbAlisverisSiparis.dteOnayTarihi BETWEEN '" & tarih1.ToString.Substring(0, 10) & "' AND '" & tarih2.ToString.Substring(0, 10) & "'  " & kriter & " ORDER BY tbAlisverisSiparis.dteTeslimEdilecek, tbMusteri.lKodu, tbStok.sKodu")
        ElseIf parametre_islem = 2 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '' as sEvTelefonu, '' as sIsTelefonu, '' as sAdres, '' as sKefil1AdiSoyadi, '' as sKefil1Adres, '' as sKefil1EvTelefon, '' as sKefil1IsTelefon, '' as sKefil2AdiSoyadi, '' as sKefil2Adres, '' as sKefil2EvTelefon, '' as sKefil2IsTelefon, '' as barkod, '' as TakipEmriNotu, '' as TeslimatciAdiSoyadi, tbAlisveris.nAlisverisID AS ALISVERISNO, tbAlisveris.sFistipi AS IZAHAT,tbMusteri.nMusteriID,tbMusteri.lKodu,tbMusteri.sAdi,tbMusteri.sSoyadi, tbMusteri.sGSM,rtrim(tbMusteri.sAdi) + ' ' + rtrim(tbMusteri.sSoyadi) AS Musteri,rtrim(tbMusteri.lKodu) + ' ' + rtrim(tbMusteri.sAdi) + ' ' + rtrim(tbMusteri.sSoyadi) AS MusteriKodlu,tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT, (SELECT tbMSinif2.sAciklama FROM tbMusteriSinifi INNER JOIN tbMSinif2 ON tbMusteriSinifi.sSinifKodu2 = tbMSinif2.sSinifKodu WHERE (tbMusteriSinifi.nMusteriID = tbMusteri.nMusteriID)) AS SINIF2, tbStok.sKodu, tbStok.sModel, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbStok.sKavala, tbStok.sAciklama,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, (SELECT sSinifKodu1 FROM tbStokSinifi Where nStokID =tbStok.nStokID) AS sSinifKodu1,(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS Miktar, tbAlisverisSiparis.lBrutFiyat, ((tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari) * (tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) / tbAlisverisSiparis.lGCMiktar) AS Tutar, rtrim(tbDepo.sDepo) + ' ' + rtrim(tbDepo.sAciklama) AS Depo, tbAlisveris.lFaturaNo, tbAlisveris.dteFaturaTarihi, tbAlisverisSiparis.dteTeslimEdilecek, tbAlisVerisSiparis.sSaticiRumuzu,tbSatici.sAdi + ' ' + tbSatici.sSoyadi as sSatici,dteOnayTarihi, dteTeslimEdilen, CASE tbAlisverisSiparis.bekalan2 WHEN '' THEN '01/01/1900' ELSE (SELECT dteIslemTarihi FROM tbStokFisiDetayi WHERE nIslemID = tbAlisverisSiparis.bEkAlan2) END FROM tbAlisverisSiparis, tbAlisveris, tbMusteri, tbStok, tbRenk, tbDepo,tbSatici,tbMusteriSinifi,tbStokSinifi WHERE tbAlisverisSiparis.nAlisverisID = tbAlisveris.nAlisverisID AND tbAlisverisSiparis.nGirisCikis = 3 AND tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1 AND tbAlisveris.nMusteriID = tbMusteri.nMusteriID AND tbMusteriSinifi.nMusteriID = tbMusteri.nMusteriID AND tbStokSinifi.nStokID = tbStok.nStokID AND tbAlisverisSiparis.nStokID = tbStok.nStokID AND tbAlisverisSiparis.sMagazaKodu = tbDepo.sDepo AND tbAlisVerisSiparis.sSaticiRumuzu = tbSatici.sSaticiRumuzu AND tbStok.sRenk = tbRenk.sRenk AND tbMusteri.lKodu BETWEEN 0 AND 999999999 AND tbAlisveris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048' AND (tbAlisveris.sFisTipi = 'SP' OR tbAlisveris.sFisTipi = 'SK')  AND tbAlisverisSiparis.dteTeslimEdilen BETWEEN '" & tarih1.ToString.Substring(0, 10) & "' AND '" & tarih2.ToString.Substring(0, 10) & "' " & kriter & " ORDER BY tbAlisverisSiparis.dteTeslimEdilecek, tbMusteri.lKodu, tbStok.sKodu")
        End If
        kriter = cmd.CommandText
        raporSorgusu = kriter
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(DataSet1.Tables(0))
        conn.Close()
        cmd = Nothing
        adapter = Nothing
        N = Nothing
        If emir_musteri_takipMi = True Then
            CheckEdit1.Visible = True
            collKodu.GroupIndex = 0
            collKodu.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            colsAciklama.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            'GridView1.OptionsView.ShowGroupPanel = True
            colsDepo1K.Visible = True
            colsDepo1B.Visible = True
            colsDepo2K.Visible = True
            colsDepo2B.Visible = True
            colsDepo3K.Visible = True
            colsDepo3B.Visible = True
            colsDepo7K.Visible = True
            colsDepo7B.Visible = True
            colsDepo11K.Visible = True
            colsDepo11B.Visible = True
            colsDepo12K.Visible = True
            colsDepo12B.Visible = True
            colsDepo13K.Visible = True
            colsDepo13B.Visible = True
            colsSinif1.Visible = True
            colsSinif3.Visible = True
            colsSinif5.Visible = True
            SimpleButton3.Enabled = False
            MenuItem19.Enabled = True
        Else
            CheckEdit1.Visible = False
            collKodu.GroupIndex = -1
            collKodu.SortOrder = DevExpress.Data.ColumnSortOrder.None
            'GridView1.OptionsView.ShowGroupPanel = False
            colsDepo1K.Visible = False
            colsDepo1B.Visible = False
            colsDepo2K.Visible = False
            colsDepo2B.Visible = False
            colsDepo3K.Visible = False
            colsDepo3B.Visible = False
            colsDepo7K.Visible = False
            colsDepo7B.Visible = False
            colsDepo11K.Visible = False
            colsDepo11B.Visible = False
            colsDepo12K.Visible = False
            colsDepo12B.Visible = False
            colsDepo13K.Visible = False
            colsDepo13B.Visible = False
            colsSinif1.Visible = False
            colsSinif3.Visible = False
            colsSinif5.Visible = False
            SimpleButton3.Enabled = True
            MenuItem19.Enabled = False
        End If
    End Sub
    Private Sub musteriTakipDepolar()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            For Each dr In DataSet1.Tables(0).Rows

            Next
        End If
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
    Private Sub SMS_Gonder()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayýtlara SMS Göndermek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim frm As New frm_Perakende_SMS_Gonder
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    If Trim(dr("sGSM")) <> "" Then
                        Dim dr1 As DataRow = frm.DataSet1.Tables(0).NewRow
                        dr1("nIslemID") = 0
                        dr1("sSMSID") = 0
                        dr1("dteGonderimTarihi") = Today
                        dr1("sMesaj") = ""
                        dr1("nMusteriID") = dr("nMusteriID")
                        dr1("lKodu") = dr("lKodu")
                        dr1("sAdi") = dr("sAdi")
                        dr1("sSoyadi") = dr("sSoyadi")
                        dr1("sTelefon") = dr("sGSM")
                        dr1("dteUpdateTarihi") = Now
                        dr1("lDurum") = 0
                        dr1("lBakiye") = 0
                        frm.DataSet1.Tables(0).Rows.Add(dr1)
                    End If
                Next
            End If
            'MsgBox(Sorgu_sDil("Ýþlem Tamamlandý...!",sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
            s = Nothing
            arr = Nothing
            i = Nothing
            dr = Nothing
            frm.ShowDialog()
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara_kriter(1)
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If musteri_takip_karti = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            Me.Close()
        End If
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
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        If parametre_islem = 0 Then
            kriter += Microsoft.VisualBasic.Left(tarih1.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(tarih2.ToString, 10) & " Tarihleri Arasýndaki Onay Bekleyen Satýþlar" & vbCrLf
        ElseIf parametre_islem = 1 Then
            kriter += Microsoft.VisualBasic.Left(tarih1.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(tarih2.ToString, 10) & " Tarihleri Arasýndaki Onay Verilen Satýþlar" & vbCrLf
        ElseIf parametre_islem = 2 Then
            kriter += Microsoft.VisualBasic.Left(tarih1.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(tarih2.ToString, 10) & " Tarihleri Arasýndaki Teslim Edilecek Satýþlar" & vbCrLf
        End If
        'kriter += Microsoft.VisualBasic.Left(tarih1.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(tarih2.EditValue.ToString, 10) & " Tarihleri Arasýndaki Satýþlar" & vbCrLf
        printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Stok Teslimat Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
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
        Try
            If GridView1.SelectedRowsCount > 1 Then
                Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
            ElseIf GridView1.SelectedRowsCount = 1 Then
                Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
            Else
                Label2.Text = ""
            End If
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
    Private Sub takibe_al()
        Dim frm As New frm_emir_musteri_takip_toplu
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kasiyerno = kasiyerno
        frm.kasiyer = kasiyer
        frm.txt_takip_aciklama.Text = "Bekleyen Alýþveriþleri var..."
        frm.status = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr As DataRow
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim toplamsayi = GridView1.SelectedRowsCount
            Dim sayi = 0
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                Panelstatus.Visible = True
                bar.Properties.Maximum = GridView1.SelectedRowsCount
                barlabel.Text = "Toplam Satýr Sayýsý : " & GridView1.SelectedRowsCount
                bar.Position = 0
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    barlabel.Text = "MüþteriKodu:" & dr("lKodu").ToString & vbTab & "Adý:" & dr("Musteri").ToString
                    barlabel.Refresh()
                    takib_ekle(frm.txt_tarih.EditValue, frm.sec_takiptipi.Text, frm.txt_takip_aciklama.Text, frm.sec_personel.EditValue, frm.sec_personel.Text, dr("nMusteriID"), dr("lKodu"), dr("sAdi"), dr("sSoyadi"), Microsoft.VisualBasic.Left(dr("Musteri"), 50), "Bekliyor", Microsoft.VisualBasic.Left(("01.01.1900").ToString, 10) + " " + "00:00:00", "", "", False, "01.01.1900", 0, False, "StokKodu: " & dr("sKodu") & "  Adý: " & dr("sAciklama") & "  Miktar: " & dr("Miktar"), "", "", "", "", False)
                    bar.Position = bar.Position + 1
                    bar.Refresh()
                Next
                bar.Position = 0
                Panelstatus.Visible = False
                dr = Nothing
            End If
            frm.Dispose()
            frm.Close()
            System.GC.SuppressFinalize(frm)
            frm = Nothing
            XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub takib_ekle(ByVal dteTarih As DateTime, ByVal TakipTipi As String, ByVal TakipAciklama As String, ByVal PersonelNo As Int64, ByVal Personel As String, ByVal nMusteriID As String, ByVal lKodu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal Musteri As String, ByVal Sonuc As String, ByVal IletisimTarihi As DateTime, ByVal IletisimSekli As String, ByVal IlgiliKisi As String, ByVal Gelecekmi As Byte, ByVal GTarih As DateTime, ByVal Tutar As Decimal, ByVal Odendi As Byte, ByVal Istihbarat As String, ByVal Aciklama1 As String, ByVal Aciklama2 As String, ByVal Aciklama3 As String, ByVal Aciklama4 As String, ByVal Status As Byte)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO aEmirMusteriTakip                       (dteTarih, TakipTipi, TakipAciklama, PersonelNo, Personel, nMusteriID,lKodu, sAdi, sSoyadi, Musteri, Sonuc, IletisimTarihi, IletisimSekli, IlgiliKisi, Gelecekmi, GTarih, Tutar, Odendi, Istihbarat, Aciklama1, Aciklama2, Aciklama3, Aciklama4, Status,KayitTarihi,ErisimTarihi) VALUES     ('" & dteTarih & "', '" & TakipTipi & "', '" & TakipAciklama & "', " & PersonelNo & ", '" & Personel & "','" & nMusteriID & "', '" & lKodu & "', '" & sAdi & "', '" & sSoyadi & "', '" & Musteri & "', '" & Sonuc & "', '" & IletisimTarihi & "', '" & IletisimSekli & "', '" & IlgiliKisi & "', " & Gelecekmi & ", '" & GTarih & "', " & Tutar & " , " & Odendi & ", '" & Istihbarat & "', '" & Aciklama1 & "', '" & Aciklama2 & "', '" & Aciklama3 & "', '" & Aciklama4 & "', " & Status & " ,'" & Now & "','" & Now & "')")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        takibe_al()
    End Sub
    Private Sub frm_satis_bekleyen_onaysiz_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'PanelControl1 = Nothing
        'PanelControl2 = Nothing
        'PanelControl3 = Nothing
        'SimpleButton3 = Nothing
        'SimpleButton2 = Nothing
        'SimpleButton1 = Nothing
        'Label1 = Nothing
        'PictureBox1 = Nothing
        'XtraTabControl1 = Nothing
        'XtraTabPage1 = Nothing
        'GridControl1 = Nothing
        'GridView1 = Nothing
        'DataSet1 = Nothing
        'DataTable1 = Nothing
        'DataColumn1 = Nothing
        'DataColumn2 = Nothing
        'DataColumn3 = Nothing
        'DataColumn4 = Nothing
        'DataColumn5 = Nothing
        'DataColumn6 = Nothing
        'DataColumn7 = Nothing
        'DataColumn8 = Nothing
        'DataColumn9 = Nothing
        'DataColumn10 = Nothing
        'DataColumn11 = Nothing
        'DataColumn12 = Nothing
        'DataColumn13 = Nothing
        'DataColumn14 = Nothing
        'DataColumn15 = Nothing
        'DataColumn16 = Nothing
        'DataColumn17 = Nothing
        'DataColumn18 = Nothing
        'collKodu = Nothing
        'colMusteri = Nothing
        'colsKodu = Nothing
        'colsModel = Nothing
        'colsRenk = Nothing
        'colsRenkAdi = Nothing
        'colsBeden = Nothing
        'colsKavala = Nothing
        'colsAciklama = Nothing
        'colMiktar = Nothing
        'collBrutFiyat = Nothing
        'colTutar = Nothing
        'colDepo = Nothing
        'collFaturaNo = Nothing
        'coldteFaturaTarihi = Nothing
        'coldteTeslimEdilecek = Nothing
        'coldteOnayTarihi = Nothing
        'coldteTeslimEdilen = Nothing
        'ContextMenu1 = Nothing
        'MenuItem1 = Nothing
        'MenuItem14 = Nothing
        'MenuItem2 = Nothing
        'MenuItem3 = Nothing
        'MenuItem4 = Nothing
        'MenuItem20 = Nothing
        'MenuItem19 = Nothing
        'MenuItem21 = Nothing
        'MenuItem22 = Nothing
        'MenuItem23 = Nothing
        'MenuItem15 = Nothing
        'MenuItem5 = Nothing
        'MenuItem6 = Nothing
        'MenuItem7 = Nothing
        'MenuItem8 = Nothing
        'MenuItem16 = Nothing
        'MenuItem9 = Nothing
        'MenuItem10 = Nothing
        'MenuItem17 = Nothing
        'MenuItem11 = Nothing
        'MenuItem12 = Nothing
        'MenuItem18 = Nothing
        'MenuItem13 = Nothing
        'ps = Nothing
        'printlink1 = Nothing
        'Label2 = Nothing
        'colIZAHAT = Nothing
        'lbl_istihbarat = Nothing
        'colMevcut = Nothing
        'Panelstatus = Nothing
        'barlabel = Nothing
        'bar = Nothing
        'MenuItem24 = Nothing
        'MenuItem25 = Nothing
        'status = Nothing
        'kriter = Nothing
        'kasiyerno = Nothing
        'kasiyer = Nothing
        'firmakodu = Nothing
        'firmaadi = Nothing
        'adres = Nothing
        'personel = Nothing
        'kod1 = Nothing
        'kod2 = Nothing
        'kod3 = Nothing
        'kod4 = Nothing
        'kod5 = Nothing
        'telefon = Nothing
        'istihbarat = Nothing
        'firmatipi = Nothing
        'kayitno = Nothing
        'aktif = Nothing
        'tarih1 = Nothing
        'tarih2 = Nothing
        'limit = Nothing
        'stokkodu = Nothing
        'malincinsi = Nothing
        'stokkod1 = Nothing
        'stokkod2 = Nothing
        'stokkod3 = Nothing
        'stokkod4 = Nothing
        'stokkod5 = Nothing
        'stoklar = Nothing
        'qfirmakodu = Nothing
        'qfirmaadi = Nothing
        'qadres = Nothing
        'qpersonel = Nothing
        'qkod1 = Nothing
        'qkod2 = Nothing
        'qkod3 = Nothing
        'qkod4 = Nothing
        'qkod5 = Nothing
        'qtelefon = Nothing
        'qistihbarat = Nothing
        'qfirmatipi = Nothing
        'qkayitno = Nothing
        'qaktif = Nothing
        'qtarih = Nothing
        'qlimit = Nothing
        'qstokkodu = Nothing
        'qmalincinsi = Nothing
        'qstokkod1 = Nothing
        'qstokkod2 = Nothing
        'qstokkod3 = Nothing
        'qstokkod4 = Nothing
        'qstokkod5 = Nothing
        'carino = Nothing
        'firmano = Nothing
        'donemno = Nothing
        'connection = Nothing
        'count = Nothing
        'language = Nothing
        'qr_hareket = Nothing
        'frf_islem = Nothing
        'cmd = Nothing
        'con = Nothing
        'adapter = Nothing
        'islemstatus = Nothing
        'Me.Close()
        System.GC.Collect()
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.xls"
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
            SaveFileDialog1.FileName = "Ekstre.txt"
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
            SaveFileDialog1.FileName = "Ekstre.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If MenuItem6.Checked = False Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowAutoFilterRow = True
            MenuItem6.Checked = True
        ElseIf MenuItem6.Checked = True Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowAutoFilterRow = False
            MenuItem6.Checked = False
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        analiz_musteri_karti()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        stok_satis_detay()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        raporla_pdf()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        SMS_Gonder()
    End Sub
    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            collKodu.GroupIndex = 0
            collKodu.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            colsAciklama.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        Else
            collKodu.GroupIndex = -1
            collKodu.SortOrder = DevExpress.Data.ColumnSortOrder.None
            colsAciklama.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        End If
    End Sub
    Private Sub raporla(ByVal islem As Integer)
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        report_create_stok("C:\Formlar\Raporlar\Etiket Talep\Takip Emirleri Etiket.fr3", "", islem)
        kriter = Nothing
        dr = Nothing
    End Sub
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer)
        Dim stokno = 0
        Dim satir_line = "100"
        '32 Bit
        Dim frx As New TfrxReportClass
        frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
        frx.LoadReportFromFile(dosya)
        frx.SetVariable("FIRMANO", "" & firmano & "")
        frx.SetVariable("DONEMNO", "" & donemno & "")
        frx.SetVariable("STOKNO", "" & stokno & "")
        frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
        Dim qr_hareket As New TfrxADOQuery
        Dim qr_baslik As New TfrxADOQuery
        qr_hareket = frx.FindObject("qr_hareket")
        qr_hareket.Query = sorgu_query(raporSorgusu)
        Dim qr_connection As New TfrxADODatabase
        qr_connection.ConnectionString = connection.ToString
        qr_connection.LoginPrompt = False
        qr_connection.CommandTimeout = Nothing
        qr_connection.Connected = True
        qr_baslik.DataBase = qr_connection
        qr_hareket.DataBase = qr_connection
        frx.PrintOptions.Collate = False
        If status = 0 Then
            'frx.PrepareReport(True)
            frx.PreviewOptions.ZoomMode = frxZoomMode.zm_PageWidth
            frx.OldStyleProgress = True
            frx.ShowReport()
        ElseIf status = 1 Then
            frx.PrepareReport(True)
            frx.PrintOptions.Collate = False
            frx.PrintOptions.Copies = 1
            frx.PrintReport()
        ElseIf status = 2 Then
            frx.PrepareReport(True)
            frx.DesignReport()
        ElseIf status = 3 Then
            frx.PrepareReport(True)
            frx.PrintOptions.Collate = False
            frx.PrintOptions.Copies = 1
            frx.PrintOptions.ShowDialog = False
            frx.PrintReport()
        End If
        qr_hareket = Nothing
        qr_baslik = Nothing
        qr_connection = Nothing
        stokno = Nothing
        satir_line = Nothing
    End Sub
    Private Sub MenuItem21_Click(sender As Object, e As EventArgs) Handles MenuItem21.Click
        raporla(0)
    End Sub
    Private Sub MenuItem22_Click(sender As Object, e As EventArgs) Handles MenuItem22.Click
        raporla(2)
    End Sub
    Private Sub MenuItem23_Click(sender As Object, e As EventArgs) Handles MenuItem23.Click
        raporla(1)
    End Sub
End Class
