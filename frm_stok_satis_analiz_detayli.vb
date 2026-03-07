Imports Microsoft.Win32
Imports FastReport
Imports DevExpress.XtraEditors
Public Class frm_stok_satis_analiz_detayli
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
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel_satis As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SplitterControl3 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents Panel_satislar_sinif As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel_satislar_personel As DevExpress.XtraEditors.PanelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPERIYOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIskonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMUSTERISAYISI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaliyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMagaza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIadeTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIadeMusteri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToplamTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToplamMusteri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYuzdeSinif As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSaticiRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSatici As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents Grid_satis As DevExpress.XtraGrid.GridControl
    Friend WithEvents Grid_tahsilat As DevExpress.XtraGrid.GridControl
    Friend WithEvents Grid_satis_sinif As DevExpress.XtraGrid.GridControl
    Friend WithEvents Grid_satis_personel As DevExpress.XtraGrid.GridControl
    Friend WithEvents Grid_satis_kat As DevExpress.XtraGrid.GridControl
    Friend WithEvents sKat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_sinif As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colPrimKat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrimPersonel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_grid As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_depo As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFISSAYISI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFISORTALAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl_SonOkuma As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colTur As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYuzde As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTurTahsilat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTurStok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTurSatici As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTurKat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSatisSinifAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSatisSinifSayi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_satis_analiz_detayli))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_SonOkuma = New DevExpress.XtraEditors.LabelControl()
        Me.sec_grid = New DevExpress.XtraEditors.PopupContainerControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSEC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_depo = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel_satislar_sinif = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.Grid_satis_sinif = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYuzdeSinif = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTurStok = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_sinif = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SplitterControl3 = New DevExpress.XtraEditors.SplitterControl()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel_satislar_personel = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Grid_satis_personel = New DevExpress.XtraGrid.GridControl()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSaticiRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSatici = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sKat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrimPersonel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTurSatici = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.Grid_satis_kat = New DevExpress.XtraGrid.GridControl()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrimKat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTurKat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel_satis = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.Grid_satis = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPERIYOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSinifKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIskonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMUSTERISAYISI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYuzde = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaliyet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFISSAYISI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFISORTALAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTur = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.Grid_tahsilat = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsMagaza = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIadeTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIadeMusteri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colToplamTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colToplamMusteri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTurTahsilat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSatisSinifAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSatisSinifSayi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.DataSet1 = New System.Data.DataSet()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sec_grid.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.Panel_satislar_sinif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_satislar_sinif.SuspendLayout()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.Grid_satis_sinif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.sec_sinif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.Panel_satislar_personel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_satislar_personel.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.Grid_satis_personel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.Grid_satis_kat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.Panel_satis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_satis.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.Grid_satis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.Grid_tahsilat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lbl_SonOkuma)
        Me.PanelControl1.Controls.Add(Me.sec_grid)
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 88)
        Me.PanelControl1.TabIndex = 0
        '
        'lbl_SonOkuma
        '
        Me.lbl_SonOkuma.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_SonOkuma.Location = New System.Drawing.Point(804, 2)
        Me.lbl_SonOkuma.Name = "lbl_SonOkuma"
        Me.lbl_SonOkuma.Size = New System.Drawing.Size(18, 13)
        Me.lbl_SonOkuma.TabIndex = 46
        Me.lbl_SonOkuma.Text = "***"
        '
        'sec_grid
        '
        Me.sec_grid.Controls.Add(Me.GridControl2)
        Me.sec_grid.Location = New System.Drawing.Point(499, 12)
        Me.sec_grid.Name = "sec_grid"
        Me.sec_grid.Size = New System.Drawing.Size(232, 128)
        Me.sec_grid.TabIndex = 42
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView8
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(232, 128)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView8})
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSEC, Me.colKOD, Me.colACIKLAMA})
        Me.GridView8.DetailHeight = 160
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.GridControl = Me.GridControl2
        Me.GridView8.GroupFormat = "{0}: {1} {2}"
        Me.GridView8.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView8.IndicatorWidth = 12
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsCustomization.AllowFilter = False
        Me.GridView8.OptionsCustomization.AllowGroup = False
        Me.GridView8.OptionsDetail.ShowDetailTabs = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        Me.GridView8.OptionsView.ShowIndicator = False
        '
        'colSEC
        '
        Me.colSEC.Caption = "Seçim"
        Me.colSEC.FieldName = "SEC"
        Me.colSEC.Name = "colSEC"
        Me.colSEC.Visible = True
        Me.colSEC.VisibleIndex = 0
        Me.colSEC.Width = 48
        '
        'colKOD
        '
        Me.colKOD.Caption = "Kod"
        Me.colKOD.FieldName = "KOD"
        Me.colKOD.Name = "colKOD"
        Me.colKOD.OptionsColumn.AllowFocus = False
        Me.colKOD.Visible = True
        Me.colKOD.VisibleIndex = 1
        Me.colKOD.Width = 52
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.Caption = "Açýklama"
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.OptionsColumn.AllowFocus = False
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 2
        Me.colACIKLAMA.Width = 128
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.sec_depo)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Location = New System.Drawing.Point(112, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(352, 82)
        Me.GroupControl1.TabIndex = 45
        Me.GroupControl1.Text = "Kriter"
        '
        'sec_depo
        '
        Me.sec_depo.EditValue = "[Tümü]"
        Me.sec_depo.EnterMoveNextControl = True
        Me.sec_depo.Location = New System.Drawing.Point(64, 50)
        Me.sec_depo.Name = "sec_depo"
        Me.sec_depo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo.Properties.PopupControl = Me.sec_grid
        Me.sec_depo.Properties.ShowPopupCloseButton = False
        Me.sec_depo.Size = New System.Drawing.Size(97, 20)
        Me.sec_depo.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Maðaza:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(272, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "arasýndaki"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Tarih :"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(165, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "ve"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(184, 23)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(83, 20)
        Me.DateEdit2.TabIndex = 1
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(64, 23)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(96, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(184, 49)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(83, 20)
        Me.SimpleButton3.TabIndex = 3
        Me.SimpleButton3.Text = "&Listele"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 44
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarSubItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Çýkýþ"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Raporla"
        Me.BarSubItem1.Id = 1
        Me.BarSubItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarSubItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Önizle"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Dizayn"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Yazdýr"
        Me.BarButtonItem4.Id = 4
        Me.BarButtonItem4.Name = "BarButtonItem4"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 596)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 596)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 596)
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 548)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(731, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 13
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(656, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 12
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.Panel_satislar_sinif)
        Me.PanelControl3.Controls.Add(Me.SplitterControl3)
        Me.PanelControl3.Controls.Add(Me.PanelControl5)
        Me.PanelControl3.Controls.Add(Me.PanelControl4)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 88)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 460)
        Me.PanelControl3.TabIndex = 2
        '
        'Panel_satislar_sinif
        '
        Me.Panel_satislar_sinif.Controls.Add(Me.PanelControl7)
        Me.Panel_satislar_sinif.Controls.Add(Me.PanelControl6)
        Me.Panel_satislar_sinif.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_satislar_sinif.Location = New System.Drawing.Point(384, 176)
        Me.Panel_satislar_sinif.Name = "Panel_satislar_sinif"
        Me.Panel_satislar_sinif.Size = New System.Drawing.Size(438, 282)
        Me.Panel_satislar_sinif.TabIndex = 4
        '
        'PanelControl7
        '
        Me.PanelControl7.Controls.Add(Me.Grid_satis_sinif)
        Me.PanelControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl7.Location = New System.Drawing.Point(2, 32)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Size = New System.Drawing.Size(434, 248)
        Me.PanelControl7.TabIndex = 1
        '
        'Grid_satis_sinif
        '
        Me.Grid_satis_sinif.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_satis_sinif.Location = New System.Drawing.Point(2, 2)
        Me.Grid_satis_sinif.MainView = Me.GridView3
        Me.Grid_satis_sinif.Name = "Grid_satis_sinif"
        Me.Grid_satis_sinif.Size = New System.Drawing.Size(430, 244)
        Me.Grid_satis_sinif.TabIndex = 0
        Me.Grid_satis_sinif.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView3.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.colYuzdeSinif, Me.GridColumn10, Me.GridColumn24, Me.colTurStok})
        Me.GridView3.CustomizationFormBounds = New System.Drawing.Rectangle(724, 373, 208, 170)
        Me.GridView3.DetailHeight = 160
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.GridControl = Me.Grid_satis_sinif
        Me.GridView3.GroupFormat = "{0}: {1} {2}"
        Me.GridView3.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView3.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", Nothing, "{0:#,0.00} prç"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", Nothing, "Tutar:{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "sKodu", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", Nothing, "{0:#,0.00}")})
        Me.GridView3.IndicatorWidth = 12
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsDetail.ShowDetailTabs = False
        Me.GridView3.OptionsPrint.ExpandAllGroups = False
        Me.GridView3.OptionsSelection.MultiSelect = True
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Periyod"
        Me.GridColumn1.FieldName = "PERIYOD"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PERIYOD", "{0} Kayýt")})
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Sýnýf Kodu"
        Me.GridColumn2.FieldName = "sSinifKodu"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 31
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Açýklama"
        Me.GridColumn3.FieldName = "sAciklama"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 76
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Miktar"
        Me.GridColumn4.DisplayFormat.FormatString = "#,#.####"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "Miktar"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 32
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Iskonto"
        Me.GridColumn5.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Iskonto"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iskonto", "{0:#,0.00}")})
        Me.GridColumn5.Width = 39
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Tutar"
        Me.GridColumn6.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "Tutar"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        Me.GridColumn6.Width = 62
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Müþteri"
        Me.GridColumn7.DisplayFormat.FormatString = "#,#"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "MUSTERISAYISI"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 7
        Me.GridColumn7.Width = 42
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Maliyet"
        Me.GridColumn8.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "Maliyet"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Maliyet", "{0:#,0.00}")})
        Me.GridColumn8.Width = 39
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Kar"
        Me.GridColumn9.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "Kar"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 5
        Me.GridColumn9.Width = 50
        '
        'colYuzdeSinif
        '
        Me.colYuzdeSinif.Caption = "Yüzde"
        Me.colYuzdeSinif.DisplayFormat.FormatString = "P"
        Me.colYuzdeSinif.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colYuzdeSinif.FieldName = "Yuzde"
        Me.colYuzdeSinif.Name = "colYuzdeSinif"
        Me.colYuzdeSinif.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.colYuzdeSinif.Visible = True
        Me.colYuzdeSinif.VisibleIndex = 6
        Me.colYuzdeSinif.Width = 45
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Fis"
        Me.GridColumn10.FieldName = "FISSAYISI"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 8
        Me.GridColumn10.Width = 20
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "FisOrt"
        Me.GridColumn24.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn24.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn24.FieldName = "FISORTALAMA"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 9
        Me.GridColumn24.Width = 20
        '
        'colTurStok
        '
        Me.colTurStok.Caption = "Tür"
        Me.colTurStok.FieldName = "Tur"
        Me.colTurStok.MinWidth = 50
        Me.colTurStok.Name = "colTurStok"
        Me.colTurStok.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.colTurStok.Visible = True
        Me.colTurStok.VisibleIndex = 0
        Me.colTurStok.Width = 50
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.SimpleButton4)
        Me.PanelControl6.Controls.Add(Me.sec_sinif)
        Me.PanelControl6.Controls.Add(Me.LabelControl1)
        Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl6.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(434, 30)
        Me.PanelControl6.TabIndex = 0
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(160, 6)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(83, 20)
        Me.SimpleButton4.TabIndex = 2
        Me.SimpleButton4.Text = "Listele"
        '
        'sec_sinif
        '
        Me.sec_sinif.EditValue = "1"
        Me.sec_sinif.Location = New System.Drawing.Point(104, 6)
        Me.sec_sinif.Name = "sec_sinif"
        Me.sec_sinif.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sinif.Properties.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.sec_sinif.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sinif.Size = New System.Drawing.Size(56, 20)
        Me.sec_sinif.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(8, 9)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "StokSýnýflandýrma:"
        '
        'SplitterControl3
        '
        Me.SplitterControl3.Location = New System.Drawing.Point(378, 176)
        Me.SplitterControl3.Name = "SplitterControl3"
        Me.SplitterControl3.Size = New System.Drawing.Size(6, 282)
        Me.SplitterControl3.TabIndex = 3
        Me.SplitterControl3.TabStop = False
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.Panel_satislar_personel)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl5.Location = New System.Drawing.Point(2, 176)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(376, 282)
        Me.PanelControl5.TabIndex = 2
        '
        'Panel_satislar_personel
        '
        Me.Panel_satislar_personel.Controls.Add(Me.XtraTabControl1)
        Me.Panel_satislar_personel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_satislar_personel.Location = New System.Drawing.Point(2, 2)
        Me.Panel_satislar_personel.Name = "Panel_satislar_personel"
        Me.Panel_satislar_personel.Size = New System.Drawing.Size(372, 278)
        Me.Panel_satislar_personel.TabIndex = 1
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(368, 274)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Grid_satis_personel)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(366, 241)
        Me.XtraTabPage1.Text = "Personel Satýþlarý"
        '
        'Grid_satis_personel
        '
        Me.Grid_satis_personel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_satis_personel.Location = New System.Drawing.Point(0, 0)
        Me.Grid_satis_personel.MainView = Me.GridView5
        Me.Grid_satis_personel.Name = "Grid_satis_personel"
        Me.Grid_satis_personel.Size = New System.Drawing.Size(366, 241)
        Me.Grid_satis_personel.TabIndex = 0
        Me.Grid_satis_personel.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5, Me.GridView4})
        '
        'GridView5
        '
        Me.GridView5.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView5.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView5.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView5.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView5.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView5.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView5.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView5.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView5.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11, Me.colsSaticiRumuzu, Me.colSatici, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.sKat, Me.colPrimPersonel, Me.GridColumn23, Me.GridColumn25, Me.colTurSatici})
        Me.GridView5.CustomizationFormBounds = New System.Drawing.Rectangle(522, 322, 208, 170)
        Me.GridView5.DetailHeight = 160
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.GridControl = Me.Grid_satis_personel
        Me.GridView5.GroupFormat = "{0}: {1} {2}"
        Me.GridView5.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView5.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", Nothing, "{0:#,0.00} prç"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", Nothing, "Tutar:{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "sKodu", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", Nothing, "{0:#,0.00}")})
        Me.GridView5.IndicatorWidth = 12
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.Editable = False
        Me.GridView5.OptionsCustomization.AllowFilter = False
        Me.GridView5.OptionsCustomization.AllowGroup = False
        Me.GridView5.OptionsDetail.ShowDetailTabs = False
        Me.GridView5.OptionsPrint.ExpandAllGroups = False
        Me.GridView5.OptionsSelection.MultiSelect = True
        Me.GridView5.OptionsView.ShowFooter = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.OptionsView.ShowIndicator = False
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Periyod"
        Me.GridColumn11.FieldName = "PERIYOD"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PERIYOD", "{0} Kayýt")})
        '
        'colsSaticiRumuzu
        '
        Me.colsSaticiRumuzu.Caption = "Satýcý Rumuzu"
        Me.colsSaticiRumuzu.FieldName = "sSaticiRumuzu"
        Me.colsSaticiRumuzu.Name = "colsSaticiRumuzu"
        Me.colsSaticiRumuzu.Width = 55
        '
        'colSatici
        '
        Me.colSatici.Caption = "Satýcý"
        Me.colSatici.FieldName = "Satici"
        Me.colSatici.Name = "colSatici"
        Me.colSatici.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.colSatici.Width = 42
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Miktar"
        Me.GridColumn12.DisplayFormat.FormatString = "#,#.####"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "Miktar"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 1
        Me.GridColumn12.Width = 34
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Iskonto"
        Me.GridColumn13.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn13.FieldName = "Iskonto"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iskonto", "{0:#,0.00}")})
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Tutar"
        Me.GridColumn14.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn14.FieldName = "Tutar"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 2
        Me.GridColumn14.Width = 40
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Müþteri"
        Me.GridColumn15.DisplayFormat.FormatString = "#,#"
        Me.GridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn15.FieldName = "MUSTERISAYISI"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 3
        Me.GridColumn15.Width = 49
        '
        'sKat
        '
        Me.sKat.Caption = "Kat"
        Me.sKat.FieldName = "sKat"
        Me.sKat.Name = "sKat"
        Me.sKat.Width = 36
        '
        'colPrimPersonel
        '
        Me.colPrimPersonel.Caption = "Prim"
        Me.colPrimPersonel.DisplayFormat.FormatString = "#,0.00"
        Me.colPrimPersonel.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrimPersonel.FieldName = "Prim"
        Me.colPrimPersonel.Name = "colPrimPersonel"
        Me.colPrimPersonel.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Prim", "{0:#,0.00}")})
        Me.colPrimPersonel.Width = 130
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Fis"
        Me.GridColumn23.FieldName = "FISSAYISI"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 4
        Me.GridColumn23.Width = 31
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "FisOrt"
        Me.GridColumn25.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn25.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn25.FieldName = "FISORTALAMA"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 5
        Me.GridColumn25.Width = 39
        '
        'colTurSatici
        '
        Me.colTurSatici.Caption = "Tür"
        Me.colTurSatici.FieldName = "Tur"
        Me.colTurSatici.MinWidth = 50
        Me.colTurSatici.Name = "colTurSatici"
        Me.colTurSatici.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.colTurSatici.Visible = True
        Me.colTurSatici.VisibleIndex = 0
        Me.colTurSatici.Width = 50
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.Grid_satis_personel
        Me.GridView4.Name = "GridView4"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.Grid_satis_kat)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(366, 241)
        Me.XtraTabPage2.Text = "Kat Satýþlarý"
        '
        'Grid_satis_kat
        '
        Me.Grid_satis_kat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_satis_kat.Location = New System.Drawing.Point(0, 0)
        Me.Grid_satis_kat.MainView = Me.GridView7
        Me.Grid_satis_kat.Name = "Grid_satis_kat"
        Me.Grid_satis_kat.Size = New System.Drawing.Size(366, 241)
        Me.Grid_satis_kat.TabIndex = 0
        Me.Grid_satis_kat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView7, Me.GridView6})
        '
        'GridView7
        '
        Me.GridView7.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView7.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView7.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView7.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView7.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView7.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView7.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView7.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView7.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView7.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView7.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView7.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView7.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView7.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView7.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.colPrimKat, Me.colTurKat})
        Me.GridView7.CustomizationFormBounds = New System.Drawing.Rectangle(522, 322, 208, 170)
        Me.GridView7.DetailHeight = 160
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.GridControl = Me.Grid_satis_kat
        Me.GridView7.GroupFormat = "{0}: {1} {2}"
        Me.GridView7.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView7.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", Nothing, "{0:#,0.00} prç"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", Nothing, "Tutar:{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "sKodu", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", Nothing, "{0:#,0.00}")})
        Me.GridView7.IndicatorWidth = 12
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsBehavior.Editable = False
        Me.GridView7.OptionsCustomization.AllowFilter = False
        Me.GridView7.OptionsCustomization.AllowGroup = False
        Me.GridView7.OptionsDetail.ShowDetailTabs = False
        Me.GridView7.OptionsPrint.ExpandAllGroups = False
        Me.GridView7.OptionsSelection.MultiSelect = True
        Me.GridView7.OptionsView.ShowFooter = True
        Me.GridView7.OptionsView.ShowGroupPanel = False
        Me.GridView7.OptionsView.ShowIndicator = False
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Periyod"
        Me.GridColumn16.FieldName = "PERIYOD"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PERIYOD", "{0} Kayýt")})
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Kat"
        Me.GridColumn17.FieldName = "sKat"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 1
        Me.GridColumn17.Width = 60
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Satýcý"
        Me.GridColumn18.FieldName = "sAciklama"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Miktar"
        Me.GridColumn19.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn19.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn19.FieldName = "Miktar"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 2
        Me.GridColumn19.Width = 60
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Iskonto"
        Me.GridColumn20.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn20.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn20.FieldName = "Iskonto"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iskonto", "{0:#,0.00}")})
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Tutar"
        Me.GridColumn21.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn21.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn21.FieldName = "Tutar"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 3
        Me.GridColumn21.Width = 60
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Müþteri"
        Me.GridColumn22.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn22.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn22.FieldName = "MUSTERISAYISI"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 5
        Me.GridColumn22.Width = 60
        '
        'colPrimKat
        '
        Me.colPrimKat.Caption = "Prim"
        Me.colPrimKat.DisplayFormat.FormatString = "#,0.00"
        Me.colPrimKat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrimKat.FieldName = "Prim"
        Me.colPrimKat.Name = "colPrimKat"
        Me.colPrimKat.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.colPrimKat.Visible = True
        Me.colPrimKat.VisibleIndex = 4
        Me.colPrimKat.Width = 60
        '
        'colTurKat
        '
        Me.colTurKat.Caption = "Tür"
        Me.colTurKat.FieldName = "Tur"
        Me.colTurKat.MinWidth = 50
        Me.colTurKat.Name = "colTurKat"
        Me.colTurKat.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.colTurKat.Visible = True
        Me.colTurKat.VisibleIndex = 0
        Me.colTurKat.Width = 50
        '
        'GridView6
        '
        Me.GridView6.GridControl = Me.Grid_satis_kat
        Me.GridView6.Name = "GridView6"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.Panel_satis)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(820, 174)
        Me.PanelControl4.TabIndex = 0
        '
        'Panel_satis
        '
        Me.Panel_satis.Controls.Add(Me.XtraTabControl2)
        Me.Panel_satis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_satis.Location = New System.Drawing.Point(2, 2)
        Me.Panel_satis.Name = "Panel_satis"
        Me.Panel_satis.Size = New System.Drawing.Size(816, 170)
        Me.Panel_satis.TabIndex = 0
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl2.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage3
        Me.XtraTabControl2.Size = New System.Drawing.Size(812, 166)
        Me.XtraTabControl2.TabIndex = 1
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.Grid_satis)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(810, 133)
        Me.XtraTabPage3.Text = "Satýþlar"
        '
        'Grid_satis
        '
        Me.Grid_satis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_satis.Location = New System.Drawing.Point(0, 0)
        Me.Grid_satis.MainView = Me.GridView1
        Me.Grid_satis.Name = "Grid_satis"
        Me.Grid_satis.Size = New System.Drawing.Size(810, 133)
        Me.Grid_satis.TabIndex = 0
        Me.Grid_satis.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPERIYOD, Me.colsSinifKodu, Me.colsAciklama, Me.colMiktar, Me.colIskonto, Me.colTutar, Me.colMUSTERISAYISI, Me.colYuzde, Me.colMaliyet, Me.colKar, Me.colFISSAYISI, Me.colFISORTALAMA, Me.colTur})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(522, 322, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.Grid_satis
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 12
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colPERIYOD
        '
        Me.colPERIYOD.Caption = "Periyod"
        Me.colPERIYOD.FieldName = "PERIYOD"
        Me.colPERIYOD.Name = "colPERIYOD"
        Me.colPERIYOD.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PERIYOD", "{0} Kayýt")})
        '
        'colsSinifKodu
        '
        Me.colsSinifKodu.Caption = "Maðaza"
        Me.colsSinifKodu.FieldName = "sMagaza"
        Me.colsSinifKodu.Name = "colsSinifKodu"
        Me.colsSinifKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.colsSinifKodu.Visible = True
        Me.colsSinifKodu.VisibleIndex = 1
        Me.colsSinifKodu.Width = 37
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Açýklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        '
        'colMiktar
        '
        Me.colMiktar.Caption = "Miktar"
        Me.colMiktar.DisplayFormat.FormatString = "#,#.####"
        Me.colMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMiktar.FieldName = "Miktar"
        Me.colMiktar.Name = "colMiktar"
        Me.colMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "Miktar", "{0:#,0.00}")})
        Me.colMiktar.Visible = True
        Me.colMiktar.VisibleIndex = 2
        Me.colMiktar.Width = 37
        '
        'colIskonto
        '
        Me.colIskonto.Caption = "Iskonto"
        Me.colIskonto.DisplayFormat.FormatString = "#,0.00"
        Me.colIskonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIskonto.FieldName = "Iskonto"
        Me.colIskonto.Name = "colIskonto"
        Me.colIskonto.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Iskonto", "{0:#,0.00}")})
        '
        'colTutar
        '
        Me.colTutar.Caption = "Tutar"
        Me.colTutar.DisplayFormat.FormatString = "#,0.00"
        Me.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTutar.FieldName = "Tutar"
        Me.colTutar.Name = "colTutar"
        Me.colTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.colTutar.Visible = True
        Me.colTutar.VisibleIndex = 3
        Me.colTutar.Width = 43
        '
        'colMUSTERISAYISI
        '
        Me.colMUSTERISAYISI.Caption = "Müþteri Sayýsý"
        Me.colMUSTERISAYISI.DisplayFormat.FormatString = "#,#"
        Me.colMUSTERISAYISI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMUSTERISAYISI.FieldName = "MUSTERISAYISI"
        Me.colMUSTERISAYISI.Name = "colMUSTERISAYISI"
        Me.colMUSTERISAYISI.Visible = True
        Me.colMUSTERISAYISI.VisibleIndex = 6
        Me.colMUSTERISAYISI.Width = 56
        '
        'colYuzde
        '
        Me.colYuzde.Caption = "Yüzde"
        Me.colYuzde.DisplayFormat.FormatString = "P"
        Me.colYuzde.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colYuzde.FieldName = "Yuzde"
        Me.colYuzde.Name = "colYuzde"
        Me.colYuzde.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.colYuzde.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.colYuzde.Visible = True
        Me.colYuzde.VisibleIndex = 5
        Me.colYuzde.Width = 50
        '
        'colMaliyet
        '
        Me.colMaliyet.Caption = "Maliyet"
        Me.colMaliyet.DisplayFormat.FormatString = "#,0.00"
        Me.colMaliyet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMaliyet.FieldName = "Maliyet"
        Me.colMaliyet.Name = "colMaliyet"
        Me.colMaliyet.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Maliyet", "{0:#,0.00}")})
        '
        'colKar
        '
        Me.colKar.Caption = "Kar"
        Me.colKar.DisplayFormat.FormatString = "#,0.00"
        Me.colKar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKar.FieldName = "Kar"
        Me.colKar.Name = "colKar"
        Me.colKar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "Kar", "{0:#,0.00}")})
        Me.colKar.Visible = True
        Me.colKar.VisibleIndex = 4
        Me.colKar.Width = 33
        '
        'colFISSAYISI
        '
        Me.colFISSAYISI.Caption = "Fis"
        Me.colFISSAYISI.FieldName = "FISSAYISI"
        Me.colFISSAYISI.Name = "colFISSAYISI"
        Me.colFISSAYISI.Visible = True
        Me.colFISSAYISI.VisibleIndex = 7
        Me.colFISSAYISI.Width = 30
        '
        'colFISORTALAMA
        '
        Me.colFISORTALAMA.Caption = "FisOrt"
        Me.colFISORTALAMA.DisplayFormat.FormatString = "#,0.00"
        Me.colFISORTALAMA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFISORTALAMA.FieldName = "FISORTALAMA"
        Me.colFISORTALAMA.Name = "colFISORTALAMA"
        Me.colFISORTALAMA.Visible = True
        Me.colFISORTALAMA.VisibleIndex = 8
        Me.colFISORTALAMA.Width = 47
        '
        'colTur
        '
        Me.colTur.Caption = "Tür"
        Me.colTur.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTur.FieldName = "Tur"
        Me.colTur.MinWidth = 35
        Me.colTur.Name = "colTur"
        Me.colTur.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "Tur", "", "")})
        Me.colTur.Visible = True
        Me.colTur.VisibleIndex = 0
        Me.colTur.Width = 35
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.Grid_tahsilat)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(810, 133)
        Me.XtraTabPage4.Text = "Tahsilatlar"
        '
        'Grid_tahsilat
        '
        Me.Grid_tahsilat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_tahsilat.Location = New System.Drawing.Point(0, 0)
        Me.Grid_tahsilat.MainView = Me.GridView2
        Me.Grid_tahsilat.Name = "Grid_tahsilat"
        Me.Grid_tahsilat.Size = New System.Drawing.Size(810, 133)
        Me.Grid_tahsilat.TabIndex = 0
        Me.Grid_tahsilat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
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
        Me.GridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsMagaza, Me.colIadeTutar, Me.colIadeMusteri, Me.colToplamTutar, Me.colToplamMusteri, Me.colTurTahsilat})
        Me.GridView2.CustomizationFormBounds = New System.Drawing.Rectangle(477, 314, 208, 170)
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.Grid_tahsilat
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sOdemeSekli", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTaksitTutari", Nothing, "Tutar: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKomisyonTutari", Nothing, "Komisyon: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lServisBedeli", Nothing, "Servis: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lPuan", Nothing, "Puan: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lPuanKdv", Nothing, "PuanKdv: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", Nothing, "Net: {0:#,0.00}")})
        Me.GridView2.IndicatorWidth = 12
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsPrint.ExpandAllGroups = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colsMagaza
        '
        Me.colsMagaza.Caption = "Maðaza"
        Me.colsMagaza.FieldName = "sMagaza"
        Me.colsMagaza.Name = "colsMagaza"
        Me.colsMagaza.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.colsMagaza.Visible = True
        Me.colsMagaza.VisibleIndex = 1
        Me.colsMagaza.Width = 51
        '
        'colIadeTutar
        '
        Me.colIadeTutar.Caption = "Ýade Tutar"
        Me.colIadeTutar.DisplayFormat.FormatString = "#,0.00"
        Me.colIadeTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIadeTutar.FieldName = "IadeTutar"
        Me.colIadeTutar.Name = "colIadeTutar"
        Me.colIadeTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.colIadeTutar.Visible = True
        Me.colIadeTutar.VisibleIndex = 2
        '
        'colIadeMusteri
        '
        Me.colIadeMusteri.Caption = "Ýade Müþteri"
        Me.colIadeMusteri.DisplayFormat.FormatString = "#,0"
        Me.colIadeMusteri.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIadeMusteri.FieldName = "IadeMusteri"
        Me.colIadeMusteri.Name = "colIadeMusteri"
        Me.colIadeMusteri.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.colIadeMusteri.Visible = True
        Me.colIadeMusteri.VisibleIndex = 3
        '
        'colToplamTutar
        '
        Me.colToplamTutar.Caption = "Toplam Tutar"
        Me.colToplamTutar.DisplayFormat.FormatString = "#,0.00"
        Me.colToplamTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colToplamTutar.FieldName = "ToplamTutar"
        Me.colToplamTutar.Name = "colToplamTutar"
        Me.colToplamTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.colToplamTutar.Visible = True
        Me.colToplamTutar.VisibleIndex = 4
        Me.colToplamTutar.Width = 53
        '
        'colToplamMusteri
        '
        Me.colToplamMusteri.Caption = "Sayý"
        Me.colToplamMusteri.DisplayFormat.FormatString = "#,0"
        Me.colToplamMusteri.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colToplamMusteri.FieldName = "ToplamMusteri"
        Me.colToplamMusteri.Name = "colToplamMusteri"
        Me.colToplamMusteri.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.colToplamMusteri.Visible = True
        Me.colToplamMusteri.VisibleIndex = 5
        Me.colToplamMusteri.Width = 39
        '
        'colTurTahsilat
        '
        Me.colTurTahsilat.Caption = "Tür"
        Me.colTurTahsilat.FieldName = "TUR"
        Me.colTurTahsilat.MinWidth = 50
        Me.colTurTahsilat.Name = "colTurTahsilat"
        Me.colTurTahsilat.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.colTurTahsilat.Visible = True
        Me.colTurTahsilat.VisibleIndex = 0
        Me.colTurTahsilat.Width = 50
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.GridControl1)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(810, 133)
        Me.XtraTabPage5.Text = "Satýþ Sýnýflarý"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView9
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(810, 133)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView9})
        '
        'GridView9
        '
        Me.GridView9.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView9.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView9.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView9.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView9.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView9.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView9.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView9.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView9.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView9.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView9.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView9.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView9.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView9.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView9.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSatisSinifAdi, Me.colSatisSinifSayi})
        Me.GridView9.CustomizationFormBounds = New System.Drawing.Rectangle(477, 314, 208, 170)
        Me.GridView9.DetailHeight = 160
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.GridControl = Me.GridControl1
        Me.GridView9.GroupFormat = "{0}: {1} {2}"
        Me.GridView9.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView9.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sOdemeSekli", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTaksitTutari", Nothing, "Tutar: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKomisyonTutari", Nothing, "Komisyon: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lServisBedeli", Nothing, "Servis: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lPuan", Nothing, "Puan: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lPuanKdv", Nothing, "PuanKdv: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", Nothing, "Net: {0:#,0.00}")})
        Me.GridView9.IndicatorWidth = 12
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsBehavior.Editable = False
        Me.GridView9.OptionsCustomization.AllowFilter = False
        Me.GridView9.OptionsCustomization.AllowGroup = False
        Me.GridView9.OptionsDetail.ShowDetailTabs = False
        Me.GridView9.OptionsPrint.ExpandAllGroups = False
        Me.GridView9.OptionsSelection.MultiSelect = True
        Me.GridView9.OptionsView.ShowFooter = True
        Me.GridView9.OptionsView.ShowGroupPanel = False
        Me.GridView9.OptionsView.ShowIndicator = False
        '
        'colSatisSinifAdi
        '
        Me.colSatisSinifAdi.Caption = "Sýnýf Adý"
        Me.colSatisSinifAdi.FieldName = "sAciklama"
        Me.colSatisSinifAdi.Name = "colSatisSinifAdi"
        Me.colSatisSinifAdi.Visible = True
        Me.colSatisSinifAdi.VisibleIndex = 0
        '
        'colSatisSinifSayi
        '
        Me.colSatisSinifSayi.Caption = "Sayý"
        Me.colSatisSinifSayi.FieldName = "sayi"
        Me.colSatisSinifSayi.Name = "colSatisSinifSayi"
        Me.colSatisSinifSayi.Visible = True
        Me.colSatisSinifSayi.VisibleIndex = 1
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "PERIYOD"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sMagaza"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sAciklama"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "Miktar"
        Me.DataColumn4.DataType = GetType(Decimal)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "Iskonto"
        Me.DataColumn5.DataType = GetType(Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Tutar"
        Me.DataColumn6.DataType = GetType(Decimal)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "MUSTERISAYISI"
        Me.DataColumn7.DataType = GetType(Long)
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'Timer1
        '
        '
        'frm_stok_satis_analiz_detayli
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 618)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_satis_analiz_detayli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detaylý Alýþ-Veriþ Analizi"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sec_grid.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.Panel_satislar_sinif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_satislar_sinif.ResumeLayout(False)
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        CType(Me.Grid_satis_sinif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        Me.PanelControl6.PerformLayout()
        CType(Me.sec_sinif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.Panel_satislar_personel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_satislar_personel.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.Grid_satis_personel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.Grid_satis_kat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.Panel_satis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_satis.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.Grid_satis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.Grid_tahsilat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage5.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Dim ds_MAGAZA As DataSet
    Dim ds_tbSatisMagaza As DataSet
    Dim ds_tbSatisSinif As DataSet
    Dim ds_tbSatisSatici As DataSet
    Dim ds_tbSatisSaticiKat As DataSet
    Dim ds_tbSatisTahsilat As DataSet
    Dim ds_tbSSinif As DataSet
    Dim ds_tbSatisMagazaDagilim As DataSet
    Dim ds_tbSatisVadeDagilim As DataSet
    Public bFatura As Boolean = False
    Private Sub frm_stok_satis_analiz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateEdit1.EditValue = dteSistemTarihi
        DateEdit2.EditValue = dteSistemTarihi
        dataload_magaza()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dataload_magaza()
        ds_MAGAZA = sorgu(sorgu_query("SELECT CAST('0' as bit) AS SEC, sDepo AS KOD, sAciklama AS ACIKLAMA FROM tbDepo WHERE sDepo <> '' ORDER BY sDepo"), "Table1")
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub gorunum_yukle()
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView2.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView3.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView4.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView5.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView6.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView7.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim tab As Object
        For Each tab In XtraTabControl1.TabPages
            tab.text = Sorgu_sDil(tab.text, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        SimpleButton4.Text = Sorgu_sDil(SimpleButton4.Text, sDil)
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub ara()
        colsMagaza.Caption = Sorgu_sDil("Maðaza", sDil)
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        Label2.Refresh()
        DataSet1.Clear()
        Label2.Text = Sorgu_sDil("Satýþlar Okunuyor...", sDil)
        Label2.Refresh()
        dataload_satis(DateEdit1.EditValue, DateEdit2.EditValue, sec_depo.Text)
        Label2.Text = Sorgu_sDil("Tahsilatlar Okunuyor...", sDil)
        Label2.Refresh()
        dataload_tahsilat(DateEdit1.EditValue, DateEdit2.EditValue, sec_depo.Text)
        Label2.Text = Sorgu_sDil("Satýþ Sýnýflarý...", sDil)
        Label2.Refresh()
        dataload_SSinif()
        Label2.Text = Sorgu_sDil("Sýnýflandýrmalý Satýþlar Okunuyor...", sDil)
        Label2.Refresh()
        dataload_satis_sinif(DateEdit1.EditValue, DateEdit2.EditValue, sec_depo.Text, sec_sinif.Text)
        Label2.Text = Sorgu_sDil("Personel Satýþlarý Okunuyor...", sDil)
        Label2.Refresh()
        dataload_satis_satici(DateEdit1.EditValue, DateEdit2.EditValue, sec_depo.Text)
        Label2.Text = Sorgu_sDil("Kat Satýþlarý Okunuyor...", sDil)
        Label2.Refresh()
        dataload_satis_kat(DateEdit1.EditValue, DateEdit2.EditValue, sec_depo.Text)
        'Label2.Text = Sorgu_sDil("Satýþlar Vade Daðýlýmý Okunuyor...", sDil)
        'Label2.Refresh()
        'dataload_satis_vadeler(DateEdit1.EditValue, DateEdit2.EditValue, sec_depo.Text)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
        Dim dr As DataRow
        Dim lToplamKar As Decimal = 0
        Dim lToplamMaliyet As Decimal = 0
        Dim nYuzdelik As Decimal = 0
        'Magaza Satýþlarý
        For Each dr In ds_tbSatisMagaza.Tables(0).Rows
            lToplamKar = lToplamKar + sorgu_sayi(dr("Kar"), 0)
            lToplamMaliyet = lToplamMaliyet + sorgu_sayi(dr("Maliyet"), 0)
        Next
        Try
            nYuzdelik = (lToplamKar / lToplamMaliyet) * 100
        Catch ex As Exception
            nYuzdelik = 0
        End Try
        'colYuzde.SummaryItem.DisplayFormat = "%" & FormatNumber(nYuzdelik, 2).ToString
        'Sýnýflandýrma Satýþlarý
        lToplamKar = 0
        lToplamMaliyet = 0
        For Each dr In ds_tbSatisSinif.Tables(0).Rows
            lToplamKar = lToplamKar + sorgu_sayi(dr("Kar"), 0)
            lToplamMaliyet = lToplamMaliyet + sorgu_sayi(dr("Maliyet"), 0)
        Next
        Try
            nYuzdelik = (lToplamKar / lToplamMaliyet) * 100
        Catch ex As Exception
            nYuzdelik = 0
        End Try
        colYuzdeSinif.SummaryItem.DisplayFormat = "%" & FormatNumber(nYuzdelik, 2).ToString
        lbl_SonOkuma.Text = Now
        Try
            satis_ortalama_hesap()
            tahsilat_ortalama_hesap()
            satis_sinif_ortalama_hesap()
            satis_satici_ortalama_hesap()
            satis_kat_ortalama_hesap()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub satis_ortalama_hesap()
        Dim sayi As Double = 0
        Dim i As Integer = 0
        Dim sutun As String = ""
        sutun = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Tur")
        GridView1.Columns("Tur").SummaryItem.DisplayFormat = sutun
        For i = 0 To GridView1.RowCount - 1
            If GridView1.GetRowCellValue(i, "Tur") = sutun Then
                sayi += 1
            End If
        Next
        GridView1.Columns(1).SummaryItem.DisplayFormat = Int32.Parse(sayi) & " Kayýt"
        sayi = 0
        For i = 0 To GridView1.RowCount - 1
            If GridView1.GetRowCellValue(i, "Tur") = sutun Then
                sayi += Double.Parse(GridView1.GetRowCellValue(i, "Miktar"))
            End If
        Next
        GridView1.Columns("Miktar").SummaryItem.DisplayFormat = FormatNumber(sayi, 2)
        sayi = 0
        For i = 0 To GridView1.RowCount - 1
            If GridView1.GetRowCellValue(i, "Tur") = sutun Then
                sayi += Double.Parse(GridView1.GetRowCellValue(i, "Tutar"))
            End If
        Next
        GridView1.Columns("Tutar").SummaryItem.DisplayFormat = FormatNumber(sayi, 2)
        sayi = 0
        For i = 0 To GridView1.RowCount - 1
            If GridView1.GetRowCellValue(i, "Tur") = sutun Then
                sayi += Double.Parse(GridView1.GetRowCellValue(i, "Kar"))
            End If
        Next
        GridView1.Columns("Kar").SummaryItem.DisplayFormat = FormatNumber(sayi, 2)
        sayi = 0
        For i = 0 To GridView1.RowCount - 1
            If GridView1.GetRowCellValue(i, "Tur") = sutun Then
                sayi += Double.Parse(GridView1.GetRowCellValue(i, "Yuzde"))
            End If
        Next
        sayi = sayi / 3
        colYuzde.SummaryItem.DisplayFormat = "%" & (sayi.ToString().Substring(2, 4)).Substring(0, 2) & "." & (sayi.ToString().Substring(2, 4)).Substring(2, 2)
    End Sub
    Private Sub tahsilat_ortalama_hesap()
        Dim sayi As Double = 0
        Dim i As Integer = 0
        Dim sutun As String = ""
        sutun = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "TUR")
        GridView2.Columns("TUR").SummaryItem.DisplayFormat = sutun
        For i = 0 To GridView2.RowCount - 1
            If GridView2.GetRowCellValue(i, "TUR") = sutun Then
                sayi += 1
            End If
        Next
        GridView2.Columns(0).SummaryItem.DisplayFormat = Int32.Parse(sayi) & " Kayýt"
        sayi = 0
        For i = 0 To GridView2.RowCount - 1
            If GridView2.GetRowCellValue(i, "TUR") = sutun Then
                sayi += Double.Parse(GridView2.GetRowCellValue(i, "IadeTutar"))
            End If
        Next
        GridView2.Columns("IadeTutar").SummaryItem.DisplayFormat = FormatNumber(sayi, 2)
        sayi = 0
        For i = 0 To GridView2.RowCount - 1
            If GridView2.GetRowCellValue(i, "TUR") = sutun Then
                sayi += Double.Parse(GridView2.GetRowCellValue(i, "IadeMusteri"))
            End If
        Next
        GridView2.Columns("IadeMusteri").SummaryItem.DisplayFormat = sayi
        sayi = 0
        For i = 0 To GridView2.RowCount - 1
            If GridView2.GetRowCellValue(i, "TUR") = sutun Then
                sayi += Double.Parse(GridView2.GetRowCellValue(i, "ToplamTutar"))
            End If
        Next
        GridView2.Columns("ToplamTutar").SummaryItem.DisplayFormat = FormatNumber(sayi, 2)
        sayi = 0
        For i = 0 To GridView2.RowCount - 1
            If GridView2.GetRowCellValue(i, "TUR") = sutun Then
                sayi += Double.Parse(GridView2.GetRowCellValue(i, "ToplamMusteri"))
            End If
        Next
        GridView2.Columns("ToplamMusteri").SummaryItem.DisplayFormat = sayi
    End Sub
    Private Sub satis_sinif_ortalama_hesap()
        Dim sayi As Double = 0
        Dim i As Integer = 0
        Dim sutun As String = ""
        sutun = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "Tur")
        GridView3.Columns("Tur").SummaryItem.DisplayFormat = sutun
        For i = 0 To GridView3.RowCount - 1
            If GridView3.GetRowCellValue(i, "Tur") = sutun Then
                sayi += 1
            End If
        Next
        GridView3.Columns("sAciklama").SummaryItem.DisplayFormat = Int32.Parse(sayi) & " Kayýt"
        sayi = 0
        For i = 0 To GridView3.RowCount - 1
            If GridView3.GetRowCellValue(i, "Tur") = sutun Then
                sayi += Double.Parse(GridView3.GetRowCellValue(i, "Miktar"))
            End If
        Next
        GridView3.Columns("Miktar").SummaryItem.DisplayFormat = FormatNumber(sayi, 2)
        sayi = 0
        For i = 0 To GridView3.RowCount - 1
            If GridView3.GetRowCellValue(i, "Tur") = sutun Then
                sayi += Double.Parse(cevir_sinif_dbNull(i, "Tutar"))
            End If
        Next
        GridView3.Columns("Tutar").SummaryItem.DisplayFormat = FormatNumber(sayi, 2)
        sayi = 0
        For i = 0 To GridView3.RowCount - 1
            If GridView3.GetRowCellValue(i, "Tur") = sutun Then
                sayi += Double.Parse(cevir_sinif_dbNull(i, "Kar"))
            End If
        Next
        GridView3.Columns("Kar").SummaryItem.DisplayFormat = FormatNumber(sayi, 2)
        sayi = 0
        For i = 0 To GridView3.RowCount - 1
            If GridView3.GetRowCellValue(i, "Tur") = sutun Then
                sayi += Double.Parse(GridView3.GetRowCellValue(i, "Yuzde"))
            End If
        Next
        sayi = sayi / 3
        colYuzdeSinif.SummaryItem.DisplayFormat = "%" & (sayi.ToString().Substring(2, 4)).Substring(0, 2) & "." & (sayi.ToString().Substring(2, 4)).Substring(2, 2)
    End Sub
    Private Function cevir_sinif_dbNull(ByVal row As Integer, ByVal col As String) As String
        If IsDBNull(GridView3.GetRowCellValue(row, col)) Then
            Return "0"
        Else
            Return GridView3.GetRowCellValue(row, col)
        End If
    End Function
    Private Sub satis_satici_ortalama_hesap()
        Dim sayi As Double = 0
        Dim i As Integer = 0
        Dim sutun As String = ""
        sutun = GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "Tur")
        GridView5.Columns("Tur").SummaryItem.DisplayFormat = sutun
        For i = 0 To GridView5.RowCount - 1
            If GridView5.GetRowCellValue(i, "Tur") = sutun Then
                sayi += 1
            End If
        Next
        GridView5.Columns("Satici").SummaryItem.DisplayFormat = Int32.Parse(sayi) & " Kayýt"
        sayi = 0
        For i = 0 To GridView5.RowCount - 1
            If GridView5.GetRowCellValue(i, "Tur") = sutun Then
                sayi += Double.Parse(GridView5.GetRowCellValue(i, "Miktar"))
            End If
        Next
        GridView5.Columns("Miktar").SummaryItem.DisplayFormat = FormatNumber(sayi, 2)
        sayi = 0
        For i = 0 To GridView5.RowCount - 1
            If GridView5.GetRowCellValue(i, "Tur") = sutun Then
                sayi += Double.Parse(cevir_satici_dbNull(i, "Tutar"))
            End If
        Next
        GridView5.Columns("Tutar").SummaryItem.DisplayFormat = FormatNumber(sayi, 2)
    End Sub
    Private Function cevir_satici_dbNull(ByVal row As Integer, ByVal col As String) As String
        If (IsDBNull(GridView5.GetRowCellValue(row, col))) Then
            Return "0"
        Else
            Return GridView5.GetRowCellValue(row, col)
        End If
    End Function
    Private Sub satis_kat_ortalama_hesap()
        Dim sayi As Double = 0
        Dim i As Integer = 0
        Dim sutun As String = ""
        sutun = GridView7.GetRowCellValue(GridView7.FocusedRowHandle, "Tur")
        GridView7.Columns("Tur").SummaryItem.DisplayFormat = sutun
        For i = 0 To GridView7.RowCount - 1
            If GridView7.GetRowCellValue(i, "Tur") = sutun Then
                sayi += 1
            End If
        Next
        GridView7.Columns("sKat").SummaryItem.DisplayFormat = Int32.Parse(sayi) & " Kayýt"
        sayi = 0
        For i = 0 To GridView7.RowCount - 1
            If GridView7.GetRowCellValue(i, "Tur") = sutun Then
                sayi += Double.Parse(GridView7.GetRowCellValue(i, "Miktar"))
            End If
        Next
        GridView7.Columns("Miktar").SummaryItem.DisplayFormat = FormatNumber(sayi, 2)
        sayi = 0
        For i = 0 To GridView7.RowCount - 1
            If GridView7.GetRowCellValue(i, "Tur") = sutun Then
                sayi += Double.Parse(cevir_kat_dbNull(i, "Tutar"))
            End If
        Next
        GridView7.Columns("Tutar").SummaryItem.DisplayFormat = FormatNumber(sayi, 2)
        sayi = 0
        For i = 0 To GridView7.RowCount - 1
            If GridView7.GetRowCellValue(i, "Tur") = sutun Then
                sayi += Double.Parse(cevir_kat_dbNull(i, "Prim"))
            End If
        Next
        GridView7.Columns("Prim").SummaryItem.DisplayFormat = FormatNumber(sayi, 2)
    End Sub
    Private Function cevir_kat_dbNull(ByVal row As Integer, ByVal col As String) As String
        If (IsDBNull(GridView7.GetRowCellValue(row, col))) Then
            Return "0"
        Else
            Return GridView7.GetRowCellValue(row, col)
        End If
    End Function
    Private Sub dataload_satis(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, Optional ByVal sinifno As Integer = 1)
        Dim count_sirala = ""
        Dim kriter As String = ""
        Dim kriter_magaza = ""
        Dim count = ""
        count_sirala = " SUM(lNetTutar) DESC,"
        kriter += " WHERE dteFaturaTarihi Between '" & tarih1 & "' and '" & tarih2 & "' "
        If Trim(sMagaza.ToString) <> "" And sMagaza <> "[Tümü]" Then
            kriter_magaza += " AND tbAlisVeris.sMagaza IN ( " & sMagaza & " )"
            kriter += "  and sMagaza IN ( " & sMagaza & " )"
        End If
        ds_tbSatisMagaza = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " '' AS PERIYOD, 'Hepsi' as Tur, sMagaza, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar, Yuzde = CASE WHEN SUM(Miktar) = 0 THEN 0 ELSE (SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0))) / SUM(Miktar*ISNULL(Maliyet, 0.01)) END,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI, COUNT(DISTINCT nAlisVerisID) AS FISSAYISI,SUM(lNetTutar)/COUNT(DISTINCT nAlisVerisID) FISORTALAMA   FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & " UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & ") Satislar " & kriter & " GROUP BY sMagaza, sMagaza UNION ALL SELECT " & count & " '' AS PERIYOD, 'Kredili-Peþin' as Tur, sMagaza, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar, Yuzde = CASE WHEN SUM(Miktar) = 0 THEN 0 ELSE (SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0))) / SUM(Miktar*ISNULL(Maliyet, 0.01)) END,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI, COUNT(DISTINCT nAlisVerisID) AS FISSAYISI,SUM(lNetTutar)/COUNT(DISTINCT nAlisVerisID) FISORTALAMA   FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' AND tbAlisVeris.sFisTipi = 'K') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & " UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & ") Satislar " & kriter & " GROUP BY sMagaza, sMagaza UNION ALL SELECT " & count & " '' AS PERIYOD, 'Kredili' as Tur, sMagaza, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar, Yuzde = CASE WHEN SUM(Miktar) = 0 THEN 0 ELSE (SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0))) / SUM(Miktar*ISNULL(Maliyet, 0.01)) END,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI, COUNT(DISTINCT nAlisVerisID) AS FISSAYISI,SUM(lNetTutar)/COUNT(DISTINCT nAlisVerisID) FISORTALAMA   FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'K') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & " UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & ") Satislar " & kriter & " GROUP BY sMagaza, sMagaza UNION ALL SELECT " & count & " '' AS PERIYOD, 'Peþin' as Tur, sMagaza, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar, Yuzde = CASE WHEN SUM(Miktar) = 0 THEN 0 ELSE (SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0))) / SUM(Miktar*ISNULL(Maliyet, 0.01)) END,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI, COUNT(DISTINCT nAlisVerisID) AS FISSAYISI,SUM(lNetTutar)/COUNT(DISTINCT nAlisVerisID) FISORTALAMA   FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & " UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & ") Satislar " & kriter & " GROUP BY sMagaza, sMagaza;"), "tbSatisMagaza")
        Grid_satis.DataSource = ds_tbSatisMagaza.Tables(0)
        Grid_satis.DataMember = Nothing
        'ds_tbSatisMagazaDagilim = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " '' AS PERIYOD, sMagaza, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar, Yuzde = CASE WHEN SUM(Miktar) = 0 THEN 0 ELSE(SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0))) / SUM(Miktar*ISNULL(Maliyet, 0.01)) END,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI, COUNT(DISTINCT nAlisVerisID) AS FISSAYISI,SUM(lNetTutar)/COUNT(DISTINCT nAlisVerisID) FISORTALAMA  FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar-tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) Satislar " & kriter & " GROUP BY sMagaza HAVING SUM(lNetTutar)>0 ORDER BY " & count_sirala & " sMagaza"), "tbSatisMagazaDagilim")
    End Sub
    Private Sub dataload_tahsilat(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, Optional ByVal sinifno As Integer = 1)
        Dim count_sirala = ""
        Dim kriter As String = ""
        Dim count = ""
        Dim kriter_magaza = ""
        If Trim(sMagaza.ToString) <> "" And sMagaza <> "[Tümü]" Then
            kriter_magaza += " AND tbOdeme.sMagaza IN ( " & sMagaza & " )"
        End If
        ds_tbSatisTahsilat = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT 'Hepsi' as TUR, sMagaza, SUM(IadeTutar) AS IadeTutar, SUM(IadeMusteri) AS IadeMusteri, SUM(ToplamTutar) AS ToplamTutar, SUM(ToplamMusteri) AS ToplamMusteri FROM (SELECT tbOdeme.sMagaza, 0 AS IadeTutar, 0 AS IadeMusteri, SUM(tbOdeme.lOdemeTutar) AS ToplamTutar, COUNT(DISTINCT tbAlisVeris.nMusteriID) AS ToplamMusteri FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi between '" & tarih1 & "' and '" & tarih2 & "')" & kriter_magaza & " and (tbOdeme.nOdemeKodu IN(1,2,3)) GROUP BY tbOdeme.sMagaza UNION ALL SELECT tbOdeme.sMagaza, 0 AS IadeTutar, 0 AS IadeMusteri, 0 AS ToplamTutar, 0 AS ToplamMusteri FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi between '" & tarih1 & "' and '" & tarih2 & "')" & kriter_magaza & " AND (tbOdeme.nOdemeKodu IN(1,2,3)) AND tbOdeme.sOdemeSekli <> 'D' GROUP BY tbOdeme.sMagaza UNION ALL SELECT tbOdeme.sMagaza, 0 AS IadeTutar, 0 AS IadeMusteri, 0 AS ToplamTutar, 0 AS ToplamMusteri FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi between '" & tarih1 & "' and '" & tarih2 & "') " & kriter_magaza & " AND (tbOdeme.nOdemeKodu IN(1,2,3)) GROUP BY tbOdeme.sMagaza UNION ALL SELECT tbOdeme.sMagaza, SUM(ABS(tbOdeme.lOdemeTutar)) AS IadeTutar, COUNT(DISTINCT tbAlisVeris.nMusteriID) AS IadeMusteri, 0 AS ToplamTutar, 0 AS ToplamMusteri FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi between '" & tarih1 & "' and '" & tarih2 & "')  AND (tbAlisVeris.nGirisCikis = 4) " & kriter_magaza & " and tbOdeme.sOdemeSekli <> 'D' GROUP BY tbOdeme.sMagaza) T GROUP BY sMagaza UNION ALL SELECT (Select sAciklama from tbOdemeKodu where nOdemeKodu=1) as TUR, sMagaza, SUM(IadeTutar) AS IadeTutar, SUM(IadeMusteri) AS IadeMusteri, SUM(ToplamTutar) AS ToplamTutar, SUM(ToplamMusteri) AS ToplamMusteri FROM (SELECT tbOdeme.sMagaza, 0 AS IadeTutar, 0 AS IadeMusteri, SUM(tbOdeme.lOdemeTutar) AS ToplamTutar, COUNT(DISTINCT tbAlisVeris.nMusteriID) AS ToplamMusteri FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi between '" & tarih1 & "' and '" & tarih2 & "') " & kriter_magaza & " and (tbOdeme.nOdemeKodu IN(1)) GROUP BY tbOdeme.sMagaza UNION ALL SELECT tbOdeme.sMagaza, 0 AS IadeTutar, 0 AS IadeMusteri, 0 AS ToplamTutar, 0 AS ToplamMusteri FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi between '" & tarih1 & "' and '" & tarih2 & "') " & kriter_magaza & " AND (tbOdeme.nOdemeKodu IN(1)) AND tbOdeme.sOdemeSekli <> 'D' GROUP BY tbOdeme.sMagaza UNION ALL SELECT tbOdeme.sMagaza, 0 AS IadeTutar, 0 AS IadeMusteri, 0 AS ToplamTutar, 0 AS ToplamMusteri FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi between '" & tarih1 & "' and '" & tarih2 & "') " & kriter_magaza & " AND (tbOdeme.nOdemeKodu IN(1)) GROUP BY tbOdeme.sMagaza UNION ALL SELECT tbOdeme.sMagaza, SUM(ABS(tbOdeme.lOdemeTutar)) AS IadeTutar, COUNT(DISTINCT tbAlisVeris.nMusteriID) AS IadeMusteri, 0 AS ToplamTutar, 0 AS ToplamMusteri FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi between '" & tarih1 & "' and '" & tarih2 & "') AND (tbAlisVeris.nGirisCikis = 4) " & kriter_magaza & " and tbOdeme.sOdemeSekli <> 'D' GROUP BY tbOdeme.sMagaza) T GROUP BY sMagaza UNION ALL SELECT (Select sAciklama from tbOdemeKodu where nOdemeKodu=2) as TUR, sMagaza, SUM(IadeTutar) AS IadeTutar, SUM(IadeMusteri) AS IadeMusteri, SUM(ToplamTutar) AS ToplamTutar, SUM(ToplamMusteri) AS ToplamMusteri FROM (SELECT tbOdeme.sMagaza, 0 AS IadeTutar, 0 AS IadeMusteri, SUM(tbOdeme.lOdemeTutar) AS ToplamTutar, COUNT(DISTINCT tbAlisVeris.nMusteriID) AS ToplamMusteri FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi between '" & tarih1 & "' and '" & tarih2 & "') " & kriter_magaza & " and (tbOdeme.nOdemeKodu IN(2)) GROUP BY tbOdeme.sMagaza UNION ALL SELECT tbOdeme.sMagaza, 0 AS IadeTutar, 0 AS IadeMusteri, 0 AS ToplamTutar, 0 AS ToplamMusteri FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi between '" & tarih1 & "' and '" & tarih2 & "') " & kriter_magaza & " AND (tbOdeme.nOdemeKodu IN(2)) AND tbOdeme.sOdemeSekli <> 'D' GROUP BY tbOdeme.sMagaza UNION ALL SELECT tbOdeme.sMagaza, 0 AS IadeTutar, 0 AS IadeMusteri, 0 AS ToplamTutar, 0 AS ToplamMusteri FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi between '" & tarih1 & "' and '" & tarih2 & "') " & kriter_magaza & " AND (tbOdeme.nOdemeKodu IN(2)) GROUP BY tbOdeme.sMagaza UNION ALL SELECT tbOdeme.sMagaza, SUM(ABS(tbOdeme.lOdemeTutar)) AS IadeTutar, COUNT(DISTINCT tbAlisVeris.nMusteriID) AS IadeMusteri, 0 AS ToplamTutar, 0 AS ToplamMusteri FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi between '" & tarih1 & "' and '" & tarih2 & "') AND (tbAlisVeris.nGirisCikis = 4) " & kriter_magaza & " and tbOdeme.sOdemeSekli <> 'D' GROUP BY tbOdeme.sMagaza ) T GROUP BY sMagaza UNION ALL SELECT (Select sAciklama from tbOdemeKodu where nOdemeKodu=3) as TUR, sMagaza, SUM(IadeTutar) AS IadeTutar, SUM(IadeMusteri) AS IadeMusteri, SUM(ToplamTutar) AS ToplamTutar, SUM(ToplamMusteri) AS ToplamMusteri FROM (SELECT tbOdeme.sMagaza, 0 AS IadeTutar, 0 AS IadeMusteri, SUM(tbOdeme.lOdemeTutar) AS ToplamTutar, COUNT(DISTINCT tbAlisVeris.nMusteriID) AS ToplamMusteri FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi between '" & tarih1 & "' and '" & tarih2 & "') " & kriter_magaza & " and (tbOdeme.nOdemeKodu IN(3)) GROUP BY tbOdeme.sMagaza UNION ALL SELECT tbOdeme.sMagaza, 0 AS IadeTutar, 0 AS IadeMusteri, 0 AS ToplamTutar, 0 AS ToplamMusteri FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi between '" & tarih1 & "' and '" & tarih2 & "') " & kriter_magaza & " AND (tbOdeme.nOdemeKodu IN(3)) AND tbOdeme.sOdemeSekli <> 'D' GROUP BY tbOdeme.sMagaza UNION ALL SELECT tbOdeme.sMagaza, 0 AS IadeTutar, 0 AS IadeMusteri, 0 AS ToplamTutar, 0 AS ToplamMusteri FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi between '" & tarih1 & "' and '" & tarih2 & "') " & kriter_magaza & " AND (tbOdeme.nOdemeKodu IN(3)) GROUP BY tbOdeme.sMagaza UNION ALL SELECT tbOdeme.sMagaza, SUM(ABS(tbOdeme.lOdemeTutar)) AS IadeTutar, COUNT(DISTINCT tbAlisVeris.nMusteriID) AS IadeMusteri, 0 AS ToplamTutar, 0 AS ToplamMusteri FROM tbOdeme INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbOdeme.dteOdemeTarihi between '" & tarih1 & "' and '" & tarih2 & "') AND (tbAlisVeris.nGirisCikis = 4) " & kriter_magaza & " and tbOdeme.sOdemeSekli <> 'D' GROUP BY tbOdeme.sMagaza ) T GROUP BY sMagaza"), "tbSatisTahsilat")
        Grid_tahsilat.DataSource = ds_tbSatisTahsilat.Tables(0)
        Grid_tahsilat.DataMember = Nothing
    End Sub
    Private Sub dataload_SSinif()
        ds_tbSSinif = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sAciklama, (Select COUNT(*) from tbAlisVeris where tbMSinif2.sSinifKodu = tbAlisVeris.Sinif2) as sayi from tbMSinif2 where sSinifKodu<>''"), "tbMusteriSinifi")
        GridControl1.DataSource = ds_tbSSinif.Tables(0)
        GridControl1.DataMember = Nothing
    End Sub
    Private Sub dataload_satis_sinif(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, Optional ByVal sinifno As Integer = 1)
        Dim count_sirala = ""
        Dim kriter As String = ""
        Dim count = ""
        count_sirala = " SUM(lNetTutar) DESC,"
        kriter += " WHERE dteFaturaTarihi Between '" & tarih1 & "' and '" & tarih2 & "' "
        Dim kriter_magaza = ""
        If Trim(sMagaza.ToString) <> "" And sMagaza <> "[Tümü]" Then
            kriter_magaza += " AND tbAlisVeris.sMagaza IN ( " & sMagaza & " )"
            kriter += "  and sMagaza IN ( " & sMagaza & " )"
        End If
        ds_tbSatisSinif = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT 'Hepsi' AS Tur, " & count & " '' AS PERIYOD, sSinifKodu, sAciklama, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar, Yuzde = CASE WHEN SUM(Miktar) = 0 THEN 0 ELSE (SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0.01))) / SUM(Miktar*ISNULL(Maliyet, 0.01)) END,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI, COUNT(DISTINCT nAlisVerisID) AS FISSAYISI,SUM(lNetTutar)/COUNT(DISTINCT nAlisVerisID) FISORTALAMA  FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0.01) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & " UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & ") Satislar " & kriter & " GROUP BY sSinifKodu, sAciklama, sSinifKodu, sAciklama UNION ALL SELECT 'Kredili-Peþin' AS Tur, " & count & " '' AS PERIYOD, sSinifKodu, sAciklama, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar, Yuzde = CASE WHEN SUM(Miktar) = 0 THEN 0 ELSE (SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0.01))) / SUM(Miktar*ISNULL(Maliyet, 0.01)) END,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI, COUNT(DISTINCT nAlisVerisID) AS FISSAYISI,SUM(lNetTutar)/COUNT(DISTINCT nAlisVerisID) FISORTALAMA  FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0.01) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' AND tbAlisVeris.sFisTipi = 'K') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & " UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & ") Satislar " & kriter & " GROUP BY sSinifKodu, sAciklama, sSinifKodu, sAciklama UNION ALL SELECT 'Kredili' AS Tur, " & count & " '' AS PERIYOD, sSinifKodu, sAciklama, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar, Yuzde = CASE WHEN SUM(Miktar) = 0 THEN 0 ELSE (SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0.01))) / SUM(Miktar*ISNULL(Maliyet, 0.01)) END,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI, COUNT(DISTINCT nAlisVerisID) AS FISSAYISI,SUM(lNetTutar)/COUNT(DISTINCT nAlisVerisID) FISORTALAMA  FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0.01) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'K') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & " UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & ") Satislar " & kriter & " GROUP BY sSinifKodu, sAciklama, sSinifKodu, sAciklama UNION ALL SELECT 'Peþin' AS Tur, " & count & " '' AS PERIYOD, sSinifKodu, sAciklama, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar, Yuzde = CASE WHEN SUM(Miktar) = 0 THEN 0 ELSE (SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0.01))) / SUM(Miktar*ISNULL(Maliyet, 0.01)) END,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI, COUNT(DISTINCT nAlisVerisID) AS FISSAYISI,SUM(lNetTutar)/COUNT(DISTINCT nAlisVerisID) FISORTALAMA  FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0.01) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & " UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & ") Satislar " & kriter & " GROUP BY sSinifKodu, sAciklama, sSinifKodu, sAciklama"), "tbSatisSinif")
        Grid_satis_sinif.DataSource = ds_tbSatisSinif.Tables(0)
        Grid_satis_sinif.DataMember = Nothing
    End Sub
    Private Sub dataload_satis_satici(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, Optional ByVal sinifno As Integer = 1)
        Dim count_sirala = ""
        Dim kriter As String = ""
        Dim count = ""
        count_sirala = " SUM(lNetTutar) DESC,"
        kriter += " WHERE dteFaturaTarihi Between '" & tarih1 & "' and '" & tarih2 & "' "
        Dim kriter_magaza = ""
        If Trim(sMagaza.ToString) <> "" And sMagaza <> "[Tümü]" Then
            kriter_magaza += " AND tbAlisVeris.sMagaza IN ( " & sMagaza & " )"
            kriter += "  and sMagaza IN ( " & sMagaza & " )"
        End If
        'Grid_satis_personel.DataSource = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '' AS PERIYOD, sKat,sSaticiRumuzu, Satici, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI, COUNT(DISTINCT nAlisVerisID) AS FISSAYISI,SUM(lNetTutar)/COUNT(DISTINCT nAlisVerisID) FISORTALAMA  FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisveris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar AS lNetTutar , tbStokFisiDetayi.sSaticiRumuzu , tbSaticiKatlari.sKat,tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici FROM tbAlisVeris LEFT OUTER JOIN tbSaticiKatlari INNER JOIN tbStokFisiDetayi ON tbSaticiKatlari.sSaticiRumuzu = tbStokFisiDetayi.sSaticiRumuzu ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisveris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar AS lNetTutar , tbAlisverisSiparis.sSaticiRumuzu , tbSaticiKatlari.sKat,tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbSaticiKatlari ON tbAlisverisSiparis.sSaticiRumuzu = tbSaticiKatlari.sSaticiRumuzu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) Satislar " & kriter & "  GROUP BY sKat,sSaticiRumuzu, Satici ORDER BY sKat,sSaticiRumuzu, Satici")).Tables(0)
        ds_tbSatisSatici = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT 'Hepsi' AS Tur, '' AS PERIYOD, sKat,sSaticiRumuzu, Satici, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Prim) Prim, COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI, COUNT(DISTINCT nAlisVerisID) AS FISSAYISI,SUM(lNetTutar)/COUNT(DISTINCT nAlisVerisID) FISORTALAMA  FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto ,ISNULL(tbStokFisiDetayi.lPrimTutari , 0) AS Prim, tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbStokFisiDetayi.sSaticiRumuzu , tbSaticiKatlari.sKat , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici , tbDepo.lKiraBedeli AS Kota , tbDepo.nMagazaM2 AS KatOran , tbDepo.nDepoM2 AS PersonelOran FROM tbDepo INNER JOIN tbSaticiKatlari INNER JOIN tbStokFisiDetayi ON tbSaticiKatlari.sSaticiRumuzu = tbStokFisiDetayi.sSaticiRumuzu ON tbDepo.sDepo = tbSaticiKatlari.sKat RIGHT OUTER JOIN tbAlisVeris ON tbStokFisiDetayi.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & " UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto ,tbAlisverisSiparis.lPrimTutari AS Prim , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbAlisverisSiparis.sSaticiRumuzu , tbSaticiKatlari.sKat , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici , tbDepo.lKiraBedeli AS Kota , tbDepo.nMagazaM2 AS KatOran , tbDepo.nDepoM2 AS PersonelOran FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbSaticiKatlari ON tbAlisverisSiparis.sSaticiRumuzu = tbSaticiKatlari.sSaticiRumuzu INNER JOIN tbDepo ON tbSaticiKatlari.sKat = tbDepo.sDepo WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & ") Satislar " & kriter & " GROUP BY sKat,PersonelOran,sSaticiRumuzu, Satici, sSaticiRumuzu, Satici UNION ALL SELECT 'Kredili-Peþin' AS Tur, '' AS PERIYOD, sKat, sSaticiRumuzu, Satici, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Prim) Prim, COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI, COUNT(DISTINCT nAlisVerisID) AS FISSAYISI,SUM(lNetTutar)/COUNT(DISTINCT nAlisVerisID) FISORTALAMA  FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto ,ISNULL(tbStokFisiDetayi.lPrimTutari , 0) AS Prim, tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbStokFisiDetayi.sSaticiRumuzu , tbSaticiKatlari.sKat , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici , tbDepo.lKiraBedeli AS Kota , tbDepo.nMagazaM2 AS KatOran , tbDepo.nDepoM2 AS PersonelOran FROM tbDepo INNER JOIN tbSaticiKatlari INNER JOIN tbStokFisiDetayi ON tbSaticiKatlari.sSaticiRumuzu = tbStokFisiDetayi.sSaticiRumuzu ON tbDepo.sDepo = tbSaticiKatlari.sKat RIGHT OUTER JOIN tbAlisVeris ON tbStokFisiDetayi.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' AND tbAlisVeris.sFisTipi = 'K') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & " UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto ,tbAlisverisSiparis.lPrimTutari AS Prim , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbAlisverisSiparis.sSaticiRumuzu , tbSaticiKatlari.sKat , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici , tbDepo.lKiraBedeli AS Kota , tbDepo.nMagazaM2 AS KatOran , tbDepo.nDepoM2 AS PersonelOran FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbSaticiKatlari ON tbAlisverisSiparis.sSaticiRumuzu = tbSaticiKatlari.sSaticiRumuzu INNER JOIN tbDepo ON tbSaticiKatlari.sKat = tbDepo.sDepo WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & ") Satislar " & kriter & " GROUP BY sKat,PersonelOran,sSaticiRumuzu, Satici, sSaticiRumuzu, Satici UNION ALL SELECT 'Kredili' AS Tur, '' AS PERIYOD, sKat, sSaticiRumuzu, Satici, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Prim) Prim, COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI, COUNT(DISTINCT nAlisVerisID) AS FISSAYISI,SUM(lNetTutar)/COUNT(DISTINCT nAlisVerisID) FISORTALAMA  FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto ,ISNULL(tbStokFisiDetayi.lPrimTutari , 0) AS Prim, tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbStokFisiDetayi.sSaticiRumuzu , tbSaticiKatlari.sKat , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici , tbDepo.lKiraBedeli AS Kota , tbDepo.nMagazaM2 AS KatOran , tbDepo.nDepoM2 AS PersonelOran FROM tbDepo INNER JOIN tbSaticiKatlari INNER JOIN tbStokFisiDetayi ON tbSaticiKatlari.sSaticiRumuzu = tbStokFisiDetayi.sSaticiRumuzu ON tbDepo.sDepo = tbSaticiKatlari.sKat RIGHT OUTER JOIN tbAlisVeris ON tbStokFisiDetayi.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'K') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & " UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto ,tbAlisverisSiparis.lPrimTutari AS Prim , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbAlisverisSiparis.sSaticiRumuzu , tbSaticiKatlari.sKat , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici , tbDepo.lKiraBedeli AS Kota , tbDepo.nMagazaM2 AS KatOran , tbDepo.nDepoM2 AS PersonelOran FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbSaticiKatlari ON tbAlisverisSiparis.sSaticiRumuzu = tbSaticiKatlari.sSaticiRumuzu INNER JOIN tbDepo ON tbSaticiKatlari.sKat = tbDepo.sDepo WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & ") Satislar " & kriter & " GROUP BY sKat,PersonelOran,sSaticiRumuzu, Satici, sSaticiRumuzu, Satici UNION ALL SELECT 'Peþin' AS Tur, '' AS PERIYOD, sKat, sSaticiRumuzu, Satici, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Prim) Prim, COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI, COUNT(DISTINCT nAlisVerisID) AS FISSAYISI,SUM(lNetTutar)/COUNT(DISTINCT nAlisVerisID) FISORTALAMA  FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto ,ISNULL(tbStokFisiDetayi.lPrimTutari , 0) AS Prim, tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbStokFisiDetayi.sSaticiRumuzu , tbSaticiKatlari.sKat , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici , tbDepo.lKiraBedeli AS Kota , tbDepo.nMagazaM2 AS KatOran , tbDepo.nDepoM2 AS PersonelOran FROM tbDepo INNER JOIN tbSaticiKatlari INNER JOIN tbStokFisiDetayi ON tbSaticiKatlari.sSaticiRumuzu = tbStokFisiDetayi.sSaticiRumuzu ON tbDepo.sDepo = tbSaticiKatlari.sKat RIGHT OUTER JOIN tbAlisVeris ON tbStokFisiDetayi.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & " UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto ,tbAlisverisSiparis.lPrimTutari AS Prim , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbAlisverisSiparis.sSaticiRumuzu , tbSaticiKatlari.sKat , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici , tbDepo.lKiraBedeli AS Kota , tbDepo.nMagazaM2 AS KatOran , tbDepo.nDepoM2 AS PersonelOran FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbSaticiKatlari ON tbAlisverisSiparis.sSaticiRumuzu = tbSaticiKatlari.sSaticiRumuzu INNER JOIN tbDepo ON tbSaticiKatlari.sKat = tbDepo.sDepo WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & ") Satislar " & kriter & " GROUP BY sKat,PersonelOran,sSaticiRumuzu, Satici, sSaticiRumuzu, Satici"), "tbSatisSatici")
        Grid_satis_personel.DataSource = ds_tbSatisSatici.Tables(0)
        Grid_satis_personel.DataMember = Nothing
    End Sub
    Private Sub dataload_satis_kat(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, Optional ByVal sinifno As Integer = 1)
        Dim count_sirala = ""
        Dim kriter As String = ""
        Dim count = ""
        count_sirala = " SUM(lNetTutar) DESC,"
        kriter += " WHERE dteFaturaTarihi Between '" & tarih1 & "' and '" & tarih2 & "' "
        Dim kriter_magaza = ""
        If Trim(sMagaza.ToString) <> "" And sMagaza <> "[Tümü]" Then
            kriter_magaza += " AND tbAlisVeris.sMagaza IN ( " & sMagaza & " )"
            kriter += "  and sMagaza IN ( " & sMagaza & " )"
        End If
        'Grid_satis_kat.DataSource = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '' AS PERIYOD, sKat,SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI, COUNT(DISTINCT nAlisVerisID) AS FISSAYISI,SUM(lNetTutar)/COUNT(DISTINCT nAlisVerisID) FISORTALAMA  FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisveris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar AS lNetTutar , tbStokFisiDetayi.sSaticiRumuzu , tbSaticiKatlari.sKat,tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici FROM tbAlisVeris LEFT OUTER JOIN tbSaticiKatlari INNER JOIN tbStokFisiDetayi ON tbSaticiKatlari.sSaticiRumuzu = tbStokFisiDetayi.sSaticiRumuzu ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisveris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar AS lNetTutar , tbAlisverisSiparis.sSaticiRumuzu , tbSaticiKatlari.sKat,tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbSaticiKatlari ON tbAlisverisSiparis.sSaticiRumuzu = tbSaticiKatlari.sSaticiRumuzu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) Satislar " & kriter & "  GROUP BY sKat ORDER BY sKat")).Tables(0)
        ds_tbSatisSaticiKat = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT 'Hepsi' AS Tur, '' AS PERIYOD, sKat, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(lNetTutar) * (KatOran / 100) AS Prim, COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI, COUNT(DISTINCT nAlisVerisID) AS FISSAYISI,SUM(lNetTutar)/COUNT(DISTINCT nAlisVerisID) FISORTALAMA  FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbStokFisiDetayi.sSaticiRumuzu , tbSaticiKatlari.sKat , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici , tbDepo.lKiraBedeli AS Kota , tbDepo.nMagazaM2 AS KatOran , tbDepo.nDepoM2 AS PersonelOran FROM tbDepo INNER JOIN tbSaticiKatlari INNER JOIN tbStokFisiDetayi ON tbSaticiKatlari.sSaticiRumuzu = tbStokFisiDetayi.sSaticiRumuzu ON tbDepo.sDepo = tbSaticiKatlari.sKat RIGHT OUTER JOIN tbAlisVeris ON tbStokFisiDetayi.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & " UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbAlisverisSiparis.sSaticiRumuzu , tbSaticiKatlari.sKat , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici , tbDepo.lKiraBedeli AS Kota , tbDepo.nMagazaM2 AS KatOran , tbDepo.nDepoM2 AS PersonelOran FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbSaticiKatlari ON tbAlisverisSiparis.sSaticiRumuzu = tbSaticiKatlari.sSaticiRumuzu INNER JOIN tbDepo ON tbSaticiKatlari.sKat = tbDepo.sDepo WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & ") Satislar " & kriter & " GROUP BY sKat, KatOran UNION ALL SELECT 'Kredili-Peþin' AS Tur, '' AS PERIYOD, sKat, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(lNetTutar) * (KatOran / 100) AS Prim, COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI, COUNT(DISTINCT nAlisVerisID) AS FISSAYISI,SUM(lNetTutar)/COUNT(DISTINCT nAlisVerisID) FISORTALAMA  FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbStokFisiDetayi.sSaticiRumuzu , tbSaticiKatlari.sKat , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici , tbDepo.lKiraBedeli AS Kota , tbDepo.nMagazaM2 AS KatOran , tbDepo.nDepoM2 AS PersonelOran FROM tbDepo INNER JOIN tbSaticiKatlari INNER JOIN tbStokFisiDetayi ON tbSaticiKatlari.sSaticiRumuzu = tbStokFisiDetayi.sSaticiRumuzu ON tbDepo.sDepo = tbSaticiKatlari.sKat RIGHT OUTER JOIN tbAlisVeris ON tbStokFisiDetayi.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' AND tbAlisVeris.sFisTipi = 'K') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & " UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbAlisverisSiparis.sSaticiRumuzu , tbSaticiKatlari.sKat , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici , tbDepo.lKiraBedeli AS Kota , tbDepo.nMagazaM2 AS KatOran , tbDepo.nDepoM2 AS PersonelOran FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbSaticiKatlari ON tbAlisverisSiparis.sSaticiRumuzu = tbSaticiKatlari.sSaticiRumuzu INNER JOIN tbDepo ON tbSaticiKatlari.sKat = tbDepo.sDepo WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & ") Satislar " & kriter & " GROUP BY sKat, KatOran UNION ALL SELECT 'Kredili' AS Tur, '' AS PERIYOD, sKat, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(lNetTutar) * (KatOran / 100) AS Prim, COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI, COUNT(DISTINCT nAlisVerisID) AS FISSAYISI,SUM(lNetTutar)/COUNT(DISTINCT nAlisVerisID) FISORTALAMA  FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbStokFisiDetayi.sSaticiRumuzu , tbSaticiKatlari.sKat , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici , tbDepo.lKiraBedeli AS Kota , tbDepo.nMagazaM2 AS KatOran , tbDepo.nDepoM2 AS PersonelOran FROM tbDepo INNER JOIN tbSaticiKatlari INNER JOIN tbStokFisiDetayi ON tbSaticiKatlari.sSaticiRumuzu = tbStokFisiDetayi.sSaticiRumuzu ON tbDepo.sDepo = tbSaticiKatlari.sKat RIGHT OUTER JOIN tbAlisVeris ON tbStokFisiDetayi.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'K') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & " UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbAlisverisSiparis.sSaticiRumuzu , tbSaticiKatlari.sKat , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici , tbDepo.lKiraBedeli AS Kota , tbDepo.nMagazaM2 AS KatOran , tbDepo.nDepoM2 AS PersonelOran FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbSaticiKatlari ON tbAlisverisSiparis.sSaticiRumuzu = tbSaticiKatlari.sSaticiRumuzu INNER JOIN tbDepo ON tbSaticiKatlari.sKat = tbDepo.sDepo WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & ") Satislar " & kriter & " GROUP BY sKat, KatOran UNION ALL SELECT 'Peþin' AS Tur, '' AS PERIYOD, sKat, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(lNetTutar) * (KatOran / 100) AS Prim, COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI, COUNT(DISTINCT nAlisVerisID) AS FISSAYISI,SUM(lNetTutar)/COUNT(DISTINCT nAlisVerisID) FISORTALAMA  FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbStokFisiDetayi.sSaticiRumuzu , tbSaticiKatlari.sKat , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici , tbDepo.lKiraBedeli AS Kota , tbDepo.nMagazaM2 AS KatOran , tbDepo.nDepoM2 AS PersonelOran FROM tbDepo INNER JOIN tbSaticiKatlari INNER JOIN tbStokFisiDetayi ON tbSaticiKatlari.sSaticiRumuzu = tbStokFisiDetayi.sSaticiRumuzu ON tbDepo.sDepo = tbSaticiKatlari.sKat RIGHT OUTER JOIN tbAlisVeris ON tbStokFisiDetayi.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & " UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID, tbAlisVeris.nAlisverisID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbAlisverisSiparis.sSaticiRumuzu , tbSaticiKatlari.sKat , tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici , tbDepo.lKiraBedeli AS Kota , tbDepo.nMagazaM2 AS KatOran , tbDepo.nDepoM2 AS PersonelOran FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbSaticiKatlari ON tbAlisverisSiparis.sSaticiRumuzu = tbSaticiKatlari.sSaticiRumuzu INNER JOIN tbDepo ON tbSaticiKatlari.sKat = tbDepo.sDepo WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter_magaza & ") Satislar " & kriter & " GROUP BY sKat, KatOran"), "tbSatisSaticiKat")
        Grid_satis_kat.DataSource = ds_tbSatisSaticiKat.Tables(0)
        Grid_satis_kat.DataMember = Nothing
    End Sub
    Private Function genel_toplamlar()
        Dim sayi As Double = 0
        Dim i As Integer = 0
        Dim sutun As String = ""
        sutun = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Tur")
        GridView1.Columns("Tur").SummaryItem.DisplayFormat = sutun
        For i = 0 To GridView1.RowCount - 1
            If GridView1.GetRowCellValue(i, "Tur") = sutun Then
                sayi += 1
            End If
        Next
        Dim ds As New DataSet
        Dim dt As DataTable
        Dim dr As DataRow
        Dim idCoulumn As DataColumn
        Dim nameCoulumn As DataColumn
        'Dim i As Integer
        dt = New DataTable()
        idCoulumn = New DataColumn("ID", Type.GetType("System.Int32"))
        nameCoulumn = New DataColumn("Name", Type.GetType("System.String"))
        dt.Columns.Add(idCoulumn)
        dt.Columns.Add(nameCoulumn)
        dr = dt.NewRow()
        dr("ID") = 1
        dr("Name") = "Name1"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("ID") = 2
        dr("Name") = "Name2"
        dt.Rows.Add(dr)
        ds.Tables.Add(dt)
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Function sorgu(ByVal query As String, ByVal sTable As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Try
            Dim N As Integer = adapter.Fill(DS, sTable)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
        conn.Close()
        Return DS
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub detay_sinif()
        If GridView3.RowCount > 0 Then
            Dim dr As DataRow = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            Dim frm As New frm_stok_satis
            frm.bFatura = bFatura
            frm.islemstatus = True
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.islem = 0
            frm.Status = True
            frm.txt_ara_stok.Text = dr("sAciklama").ToString
            frm.sec_konum_stok.Text = "Sýnýf" & sec_sinif.Text
            frm.DateEdit1.EditValue = DateEdit1.EditValue
            frm.DateEdit2.EditValue = DateEdit2.EditValue
            frm.kullanici = kullanici
            frm.sec_kriter_stok.Text = "Eþittir"
            If GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "Tur") = "Hepsi" Then
                frm.fisTipi = ""
            ElseIf GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "Tur") = "Kredili-Peþin" Then
                frm.fisTipi = "AND (tbAlisVeris.sFisTipi IN('K','P','SK','SP'))"
            ElseIf GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "Tur") = "Kredili" Then
                frm.fisTipi = "AND (tbAlisVeris.sFisTipi IN('K','SK'))"
            ElseIf GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "Tur") = "Peþin" Then
                frm.fisTipi = "AND (tbAlisVeris.sFisTipi IN('P','SP'))"
            End If
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            dr = Nothing
            frm = Nothing
        End If
    End Sub
    Private Sub detay_depo()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_satis
            frm.bFatura = bFatura
            frm.islemstatus = True
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.islem = 0
            frm.status = True
            frm.sec_depo.Text = "'" & Trim(dr("sMagaza").ToString) & "'"
            'frm.txt_ara_stok.Text = dr("sAciklama").ToString
            'frm.sec_konum_stok.Text = "Sýnýf" & sec_sinif.Text
            frm.DateEdit1.EditValue = DateEdit1.EditValue
            frm.DateEdit2.EditValue = DateEdit2.EditValue
            frm.kullanici = kullanici
            If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Tur") = "Hepsi" Then
                frm.fisTipi = ""
            ElseIf GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Tur") = "Kredili-Peþin" Then
                frm.fisTipi = "AND (tbAlisVeris.sFisTipi IN('K','P','SK','SP'))"
            ElseIf GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Tur") = "Kredili" Then
                frm.fisTipi = "AND (tbAlisVeris.sFisTipi IN('K','SK'))"
            ElseIf GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Tur") = "Peþin" Then
                frm.fisTipi = "AND (tbAlisVeris.sFisTipi IN('P','SP'))"
            End If
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            dr = Nothing
            frm = Nothing
        End If
    End Sub
    Private Sub detay_satici()
        If GridView5.RowCount > 0 Then
            Dim dr As DataRow = GridView5.GetDataRow(GridView5.FocusedRowHandle)
            Dim frm As New frm_stok_satis
            frm.bFatura = bFatura
            frm.islemstatus = True
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.islem = 0
            frm.Status = True
            frm.sSaticiRumuzu = "'" & Trim(dr("sSaticiRumuzu").ToString) & "'"
            frm.kullanici = kullanici
            frm.DateEdit1.EditValue = DateEdit1.EditValue
            frm.DateEdit2.EditValue = DateEdit2.EditValue
            If GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "Tur") = "Hepsi" Then
                frm.fisTipi = ""
            ElseIf GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "Tur") = "Kredili-Peþin" Then
                frm.fisTipi = "AND (tbAlisVeris.sFisTipi IN('K','P','SK','SP'))"
            ElseIf GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "Tur") = "Kredili" Then
                frm.fisTipi = "AND (tbAlisVeris.sFisTipi IN('K','SK'))"
            ElseIf GridView5.GetRowCellValue(GridView5.FocusedRowHandle, "Tur") = "Peþin" Then
                frm.fisTipi = "AND (tbAlisVeris.sFisTipi IN('P','SP'))"
            End If
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            dr = Nothing
            frm = Nothing
        End If
    End Sub
    Private Sub raporla_faaliyet(ByVal rapor As Integer, ByVal nislem As Integer, Optional ByVal bTumu As Boolean = False)
        'Try
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyalarý (*.frx*) |*.frx*"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\NakitKasa\FormAnaliz" & sRaporUzanti & ""
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\NakitKasa"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Microsoft.VisualBasic.Right(sFile, 3) = "frx" Then
                Dim report As New FastReport.Report
                report.Load(sFile)
                report.RegisterData(ds_tbParamGenel)
                report.RegisterData(ds_tbSatisMagaza)
                report.RegisterData(ds_tbSatisSatici)
                report.RegisterData(ds_tbSatisSaticiKat)
                report.RegisterData(ds_tbSatisSinif)
                report.RegisterData(ds_tbSatisTahsilat)
                report.RegisterData(ds_tbSSinif)
                report.SetParameterValue("dteIslemTarihi1", DateEdit1.EditValue)
                report.SetParameterValue("dteIslemTarihi2", DateEdit2.EditValue)
                report.SetParameterValue("sMagaza", sec_depo.Text)
                report.ScriptLanguage = Language.Vb
                If nislem = 0 Then
                    report.Show()
                ElseIf nislem = 2 Then
                    report.Design()
                ElseIf nislem = 1 Then
                    report.Print()
                End If
                report.Dispose()
                report = Nothing
                'ElseIf Microsoft.VisualBasic.Right(sFile, 3) = "fr3" Then
                '    report_create_stok(sFile, " WHERE nKasaIslemID = " & dr("nKasaIslemID") & "", nislem, dr("lTahsilTutar"), dr("lTediyeTutar"))
            End If
        End If
        'Catch ex As Exception
        'End Try
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Label2.Text = "Sýnýflandýrma Satýþlarý Okunuyor..."
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        dataload_satis_sinif(DateEdit1.EditValue, DateEdit2.EditValue, sec_depo.Text, sec_sinif.Text)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Label2.Refresh()
    End Sub
    Private Sub Grid_satis_sinif_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid_satis_sinif.DoubleClick
        detay_sinif()
    End Sub
    Private Sub Grid_satis_sinif_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid_satis_sinif.KeyDown
        If e.KeyCode = Keys.Enter Then
            detay_sinif()
        End If
    End Sub
    Private Sub Grid_satis_personel_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid_satis_personel.DoubleClick
        detay_satici()
    End Sub
    Private Sub Grid_satis_personel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid_satis_personel.KeyDown
        If e.KeyCode = Keys.Enter Then
            detay_satici()
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
    Private Sub Grid_satis_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid_satis.DoubleClick
        detay_depo()
    End Sub
    Private Sub Grid_satis_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid_satis.KeyDown
        If e.KeyCode = Keys.Enter Then
            detay_depo()
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        raporla_faaliyet(0, 0)
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_faaliyet(0, 2)
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_faaliyet(0, 1)
    End Sub
    Private Sub sec_depo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_depo.QueryPopUp
        sec_depo.Properties.PopupControl = sec_grid
        GridControl2.DataSource = ds_magaza.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_depo_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_depo.QueryResultValue
        Dim s As String = deger(ds_magaza)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub ClosePopup()
        If Not sec_grid.OwnerEdit Is Nothing Then
            sec_grid.OwnerEdit.ClosePopup()
        End If
    End Sub
    Private Function deger(ByVal ds As DataSet) As String
        Dim dr As DataRow
        Dim s As String = ""
        Dim satir As String = ""
        Dim sayi As Integer = 0
        Dim sayi1 As Integer = 0
        For Each dr In ds.Tables(0).Rows
            If dr("SEC") = True Then
                sayi += 1
            End If
        Next
        For Each dr In ds.Tables(0).Rows
            If dr("SEC") = True Then
                sayi1 += 1
                s += "'" + Trim(dr("KOD")).ToString + "'"
                satir += Trim(dr("ACIKLAMA"))
                If sayi1 < sayi Then
                    s += ","
                    satir += ","
                End If
            End If
        Next
        sayi1 = Nothing
        sayi = Nothing
        Return s.ToString
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ara()
    End Sub
    Private Sub GridView1_RowCellClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView1.RowCellClick
        satis_ortalama_hesap()
    End Sub
    Private Sub GridView2_RowCellClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView2.RowCellClick
        tahsilat_ortalama_hesap()
    End Sub
    Private Sub GridView3_RowCellClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView3.RowCellClick
        satis_sinif_ortalama_hesap()
    End Sub
    Private Sub GridView5_RowCellClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView5.RowCellClick
        satis_satici_ortalama_hesap()
    End Sub
    Private Sub GridView7_RowCellClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView7.RowCellClick
        satis_kat_ortalama_hesap()
    End Sub
End Class
