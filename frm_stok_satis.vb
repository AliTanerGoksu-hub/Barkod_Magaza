Imports FastReport
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Imports System.IO
Public Class frm_stok_satis
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
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents colnAlisverisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnMusteriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMusteriAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTarih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfisTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStokID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsStokAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIskonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNetTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsOdemeKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFiyatTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSaticiRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKasiyerRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnGirisCikis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMagaza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_konum_stok As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_kriter_stok As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara_stok As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_renk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_Satici As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colsYaziIle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBarkod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_etiket As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents colMaliyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_satic As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_grid As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBrutTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBeden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents colsAlisVerisYapanAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAlisVerisYapanSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
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
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents collPrimTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_MaliyetTipi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Grid2Oran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_depo As DevExpress.XtraEditors.PopupContainerEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_satis))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_MaliyetTipi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_depo = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.sec_grid = New DevExpress.XtraEditors.PopupContainerControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSEC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_satic = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_konum_stok = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_kriter_stok = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara_stok = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.colORAN1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_etiket = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
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
        Me.colnAlisverisID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnMusteriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsMusteriAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteTarih = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfisTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStokID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsStokAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIskonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNetTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsOdemeKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFiyatTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSaticiRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_Satici = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colsKasiyerRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnGirisCikis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsMagaza = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_renk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colsYaziIle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBarkod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaliyet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBrutTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAlisVerisYapanAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAlisVerisYapanSoyadi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPrimTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid2Oran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_MaliyetTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sec_grid.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_satic.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum_stok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter_stok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara_stok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_Satici, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.lbl_istihbarat)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1146, 128)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_MaliyetTipi)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.sec_depo)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.sec_satic)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.sec_konum_stok)
        Me.GroupControl1.Controls.Add(Me.sec_kriter_stok)
        Me.GroupControl1.Controls.Add(Me.txt_ara_stok)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(97, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(817, 124)
        Me.GroupControl1.TabIndex = 38
        Me.GroupControl1.Text = "Ara"
        '
        'sec_MaliyetTipi
        '
        Me.sec_MaliyetTipi.EditValue = "Stok Kartýndan"
        Me.sec_MaliyetTipi.EnterMoveNextControl = True
        Me.sec_MaliyetTipi.Location = New System.Drawing.Point(64, 84)
        Me.sec_MaliyetTipi.Name = "sec_MaliyetTipi"
        Me.sec_MaliyetTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_MaliyetTipi.Properties.Items.AddRange(New Object() {"Stok Kartýndan", "Maliyetlendirmeden", "Satýþ Günündeki Maliyet"})
        Me.sec_MaliyetTipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_MaliyetTipi.Size = New System.Drawing.Size(195, 20)
        Me.sec_MaliyetTipi.TabIndex = 44
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(20, 87)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl1.TabIndex = 45
        Me.LabelControl1.Text = "Maliyet:"
        '
        'sec_depo
        '
        Me.sec_depo.EditValue = "[Tümü]"
        Me.sec_depo.EnterMoveNextControl = True
        Me.sec_depo.Location = New System.Drawing.Point(177, 104)
        Me.sec_depo.Name = "sec_depo"
        Me.sec_depo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo.Properties.PopupControl = Me.sec_grid
        Me.sec_depo.Properties.ShowPopupCloseButton = False
        Me.sec_depo.Size = New System.Drawing.Size(82, 20)
        Me.sec_depo.TabIndex = 43
        '
        'sec_grid
        '
        Me.sec_grid.Controls.Add(Me.GridControl2)
        Me.sec_grid.Location = New System.Drawing.Point(168, 58)
        Me.sec_grid.Name = "sec_grid"
        Me.sec_grid.Size = New System.Drawing.Size(256, 128)
        Me.sec_grid.TabIndex = 2
        '
        'GridControl2
        '
        Me.GridControl2.Location = New System.Drawing.Point(-3, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(256, 128)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSEC, Me.colKOD, Me.colACIKLAMA})
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.IndicatorWidth = 12
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
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
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(17, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Satýcý:"
        '
        'sec_satic
        '
        Me.sec_satic.EditValue = "[Tümü]"
        Me.sec_satic.EnterMoveNextControl = True
        Me.sec_satic.Location = New System.Drawing.Point(64, 104)
        Me.sec_satic.Name = "sec_satic"
        Me.sec_satic.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_satic.Properties.ShowPopupCloseButton = False
        Me.sec_satic.Size = New System.Drawing.Size(113, 20)
        Me.sec_satic.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(9, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Stoklar:"
        '
        'sec_konum_stok
        '
        Me.sec_konum_stok.EditValue = "Kod"
        Me.sec_konum_stok.EnterMoveNextControl = True
        Me.sec_konum_stok.Location = New System.Drawing.Point(176, 44)
        Me.sec_konum_stok.Name = "sec_konum_stok"
        Me.sec_konum_stok.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum_stok.Properties.Items.AddRange(New Object() {"Kod", "Ad", "Barkod", "Sýnýf1", "Sýnýf2", "Sýnýf3", "Sýnýf4", "Sýnýf5", "Sýnýf6", "Sýnýf7", "Sýnýf8", "Sýnýf9", "Sýnýf10"})
        Me.sec_konum_stok.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum_stok.Size = New System.Drawing.Size(83, 20)
        Me.sec_konum_stok.TabIndex = 3
        '
        'sec_kriter_stok
        '
        Me.sec_kriter_stok.EditValue = "Baþlar"
        Me.sec_kriter_stok.EnterMoveNextControl = True
        Me.sec_kriter_stok.Location = New System.Drawing.Point(259, 44)
        Me.sec_kriter_stok.Name = "sec_kriter_stok"
        Me.sec_kriter_stok.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter_stok.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter_stok.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter_stok.Size = New System.Drawing.Size(64, 20)
        Me.sec_kriter_stok.TabIndex = 4
        '
        'txt_ara_stok
        '
        Me.txt_ara_stok.EnterMoveNextControl = True
        Me.txt_ara_stok.Location = New System.Drawing.Point(64, 44)
        Me.txt_ara_stok.Name = "txt_ara_stok"
        Me.txt_ara_stok.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara_stok.Properties.Appearance.Options.UseFont = True
        Me.txt_ara_stok.Properties.MaxLength = 15
        Me.txt_ara_stok.Size = New System.Drawing.Size(112, 20)
        Me.txt_ara_stok.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(0, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Hesaplar:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(259, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "arasýndaki"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(18, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Tarih:"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(176, 24)
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
        Me.DateEdit1.Location = New System.Drawing.Point(64, 24)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(96, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Adý+Soyadý"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(176, 64)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Adý+Soyadý", "Kodu", "Adý", "Soyadý", "Ýstihbarat", "EvAdresi", "ÝþAdresi", "EvTelefonu", "ÝþTelefonu", "Gsm", "DoðumYeri", "1.Kefil Adý", "2.Kefil Adý", "Sýnýf1", "Sýnýf2", "Sýnýf3", "Sýnýf4", "Sýnýf5"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(83, 20)
        Me.sec_konum.TabIndex = 6
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(259, 87)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(65, 20)
        Me.SimpleButton3.TabIndex = 9
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(259, 64)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(64, 20)
        Me.sec_kriter.TabIndex = 7
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(64, 64)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(112, 20)
        Me.txt_ara.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(161, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "ve"
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_istihbarat.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(914, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(230, 124)
        Me.lbl_istihbarat.TabIndex = 33
        Me.lbl_istihbarat.Text = "istihbarat..."
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(97, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'colORAN1
        '
        Me.colORAN1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colORAN1.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colORAN1.AppearanceCell.Options.UseBackColor = True
        Me.colORAN1.Caption = "Oran"
        Me.colORAN1.DisplayFormat.FormatString = "P"
        Me.colORAN1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN1.FieldName = "ORAN1"
        Me.colORAN1.Name = "colORAN1"
        Me.colORAN1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom), New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.colORAN1.Width = 49
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btn_etiket)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 586)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1146, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'btn_etiket
        '
        Me.btn_etiket.Image = CType(resources.GetObject("btn_etiket.Image"), System.Drawing.Image)
        Me.btn_etiket.Location = New System.Drawing.Point(168, 12)
        Me.btn_etiket.Name = "btn_etiket"
        Me.btn_etiket.Size = New System.Drawing.Size(75, 24)
        Me.btn_etiket.TabIndex = 7
        Me.btn_etiket.Text = "&Yazdýr"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(1061, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(986, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.sec_grid)
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 128)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1146, 458)
        Me.PanelControl3.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_renk, Me.sec_Satici})
        Me.GridControl1.Size = New System.Drawing.Size(1142, 454)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem15, Me.MenuItem16, Me.MenuItem17, Me.MenuItem18, Me.MenuItem19, Me.MenuItem21, Me.MenuItem29, Me.MenuItem32, Me.MenuItem30, Me.MenuItem33, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem22, Me.MenuItem28, Me.MenuItem31, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
        '
        'MenuItem13
        '
        Me.MenuItem13.DefaultItem = True
        Me.MenuItem13.Index = 0
        Me.MenuItem13.Text = "Tamam"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 1
        Me.MenuItem14.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem14.Text = "Ara"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 2
        Me.MenuItem15.Text = "-"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 3
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem16.Text = "Kalan Taksitler"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 4
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem17.Text = "Kalan Satýþlar"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 5
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem18.Text = "Satýþlar"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 6
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem19.Text = "Müþteri Kartý"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 7
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem21.Text = "Envanter"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 8
        Me.MenuItem29.Shortcut = System.Windows.Forms.Shortcut.CtrlF4
        Me.MenuItem29.Text = "Stok Kartý"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 9
        Me.MenuItem32.Shortcut = System.Windows.Forms.Shortcut.CtrlF7
        Me.MenuItem32.Text = "Stok Hareketleri"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 10
        Me.MenuItem30.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItem30.Text = "Stok Fiyatlarý"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 11
        Me.MenuItem33.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItem33.Text = "Karlýlýk Akýþ Tablosu"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 12
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 13
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 14
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 15
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 16
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 17
        Me.MenuItem10.Text = "-"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 18
        Me.MenuItem22.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem23, Me.MenuItem24, Me.MenuItem25, Me.MenuItem27, Me.MenuItem26})
        Me.MenuItem22.Text = "Raporla"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 0
        Me.MenuItem23.Text = "Önizle"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 1
        Me.MenuItem24.Text = "Dizayn"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 2
        Me.MenuItem25.Text = "Yazdýr"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 3
        Me.MenuItem27.Text = "-"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 4
        Me.MenuItem26.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem26.Text = "Direkt Yazdýr"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 19
        Me.MenuItem28.Text = "-"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 20
        Me.MenuItem31.Text = "Hýzlý Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 21
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 22
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 23
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 24
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 25
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 26
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 27
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem9.Text = "Ekraný Kapla"
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
        Me.DataColumn1.ColumnName = "nAlisverisID"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "nMusteriID"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "lKodu"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sMusteriAdi"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "dteTarih"
        Me.DataColumn5.DataType = GetType(Date)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "fisTipi"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "lNo"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "nStokID"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sKodu"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "sStokAciklama"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Miktar"
        Me.DataColumn11.DataType = GetType(Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "Fiyat"
        Me.DataColumn12.DataType = GetType(Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "Iskonto"
        Me.DataColumn13.DataType = GetType(Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "lNetTutar"
        Me.DataColumn14.DataType = GetType(Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sOdemeKodu"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "sFiyatTipi"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "sSaticiRumuzu"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "sKasiyerRumuzu"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "nGirisCikis"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sMagaza"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "sRenk"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnAlisverisID, Me.colnMusteriID, Me.colORAN1, Me.collKodu, Me.colsMusteriAdi, Me.coldteTarih, Me.colfisTipi, Me.collNo, Me.colnStokID, Me.colsKodu, Me.colsStokAciklama, Me.colMiktar, Me.colFiyat, Me.colIskonto, Me.collNetTutar, Me.colsOdemeKodu, Me.colsFiyatTipi, Me.colsSaticiRumuzu, Me.colsKasiyerRumuzu, Me.colnGirisCikis, Me.colsMagaza, Me.colsRenk, Me.colsYaziIle, Me.colsBarkod, Me.colMaliyet, Me.collBrutTutar, Me.coldteKayitTarihi, Me.colsBeden, Me.colsAlisVerisYapanAdi, Me.colsAlisVerisYapanSoyadi, Me.collPrimTutari, Me.Grid2Oran, Me.GridColumn1})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(522, 322, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", Nothing, "{0:#,0.00} prç"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", Nothing, "Tutar:{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "sKodu", Me.colsKodu, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", Me.colMiktar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", Me.collNetTutar, "{0:#,0.00}")})
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
        'colnAlisverisID
        '
        Me.colnAlisverisID.Caption = "AlýþVeriþ No"
        Me.colnAlisverisID.FieldName = "nAlisverisID"
        Me.colnAlisverisID.Name = "colnAlisverisID"
        '
        'colnMusteriID
        '
        Me.colnMusteriID.Caption = "Müþteri No"
        Me.colnMusteriID.FieldName = "nMusteriID"
        Me.colnMusteriID.Name = "colnMusteriID"
        '
        'collKodu
        '
        Me.collKodu.Caption = "Müþteri Kodu"
        Me.collKodu.FieldName = "lKodu"
        Me.collKodu.Name = "collKodu"
        Me.collKodu.Width = 55
        '
        'colsMusteriAdi
        '
        Me.colsMusteriAdi.Caption = "HesapAdý"
        Me.colsMusteriAdi.FieldName = "sMusteriAdi"
        Me.colsMusteriAdi.Name = "colsMusteriAdi"
        Me.colsMusteriAdi.Visible = True
        Me.colsMusteriAdi.VisibleIndex = 3
        Me.colsMusteriAdi.Width = 97
        '
        'coldteTarih
        '
        Me.coldteTarih.Caption = "Tarih"
        Me.coldteTarih.FieldName = "dteTarih"
        Me.coldteTarih.Name = "coldteTarih"
        Me.coldteTarih.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteTarih", "{0} Kayýt")})
        Me.coldteTarih.Visible = True
        Me.coldteTarih.VisibleIndex = 0
        Me.coldteTarih.Width = 62
        '
        'colfisTipi
        '
        Me.colfisTipi.Caption = "Fiþ Tipi"
        Me.colfisTipi.FieldName = "fisTipi"
        Me.colfisTipi.Name = "colfisTipi"
        Me.colfisTipi.Visible = True
        Me.colfisTipi.VisibleIndex = 1
        Me.colfisTipi.Width = 41
        '
        'collNo
        '
        Me.collNo.Caption = "Fiþ No"
        Me.collNo.FieldName = "lNo"
        Me.collNo.Name = "collNo"
        Me.collNo.Visible = True
        Me.collNo.VisibleIndex = 2
        Me.collNo.Width = 43
        '
        'colnStokID
        '
        Me.colnStokID.Caption = "Stok No"
        Me.colnStokID.FieldName = "nStokID"
        Me.colnStokID.Name = "colnStokID"
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Stok Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 4
        Me.colsKodu.Width = 62
        '
        'colsStokAciklama
        '
        Me.colsStokAciklama.Caption = "Stok Adý"
        Me.colsStokAciklama.FieldName = "sStokAciklama"
        Me.colsStokAciklama.Name = "colsStokAciklama"
        Me.colsStokAciklama.Visible = True
        Me.colsStokAciklama.VisibleIndex = 5
        Me.colsStokAciklama.Width = 103
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
        Me.colMiktar.VisibleIndex = 6
        Me.colMiktar.Width = 39
        '
        'colFiyat
        '
        Me.colFiyat.Caption = "Fiyat"
        Me.colFiyat.DisplayFormat.FormatString = "#,0.00##"
        Me.colFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFiyat.FieldName = "Fiyat"
        Me.colFiyat.Name = "colFiyat"
        Me.colFiyat.Visible = True
        Me.colFiyat.VisibleIndex = 7
        Me.colFiyat.Width = 39
        '
        'colIskonto
        '
        Me.colIskonto.Caption = "Iskonto"
        Me.colIskonto.FieldName = "Iskonto"
        Me.colIskonto.Name = "colIskonto"
        '
        'collNetTutar
        '
        Me.collNetTutar.Caption = "Net Tutar"
        Me.collNetTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collNetTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collNetTutar.FieldName = "lNetTutar"
        Me.collNetTutar.Name = "collNetTutar"
        Me.collNetTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", "{0:#,0.00}")})
        Me.collNetTutar.Visible = True
        Me.collNetTutar.VisibleIndex = 8
        Me.collNetTutar.Width = 51
        '
        'colsOdemeKodu
        '
        Me.colsOdemeKodu.Caption = "Ödeme Kodu"
        Me.colsOdemeKodu.FieldName = "sOdemeKodu"
        Me.colsOdemeKodu.Name = "colsOdemeKodu"
        Me.colsOdemeKodu.Width = 70
        '
        'colsFiyatTipi
        '
        Me.colsFiyatTipi.Caption = "FiyatTipi"
        Me.colsFiyatTipi.FieldName = "sFiyatTipi"
        Me.colsFiyatTipi.Name = "colsFiyatTipi"
        Me.colsFiyatTipi.Visible = True
        Me.colsFiyatTipi.VisibleIndex = 9
        Me.colsFiyatTipi.Width = 56
        '
        'colsSaticiRumuzu
        '
        Me.colsSaticiRumuzu.Caption = "Satici"
        Me.colsSaticiRumuzu.ColumnEdit = Me.sec_Satici
        Me.colsSaticiRumuzu.FieldName = "sSaticiRumuzu"
        Me.colsSaticiRumuzu.Name = "colsSaticiRumuzu"
        Me.colsSaticiRumuzu.Visible = True
        Me.colsSaticiRumuzu.VisibleIndex = 10
        Me.colsSaticiRumuzu.Width = 41
        '
        'sec_Satici
        '
        Me.sec_Satici.AutoHeight = False
        Me.sec_Satici.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_Satici.DisplayMember = "SATICI"
        Me.sec_Satici.Name = "sec_Satici"
        Me.sec_Satici.NullText = "[Satýcýlar]"
        Me.sec_Satici.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_Satici.ShowFooter = False
        Me.sec_Satici.ShowHeader = False
        Me.sec_Satici.ShowLines = False
        Me.sec_Satici.ValueMember = "sSaticiRumuzu"
        '
        'colsKasiyerRumuzu
        '
        Me.colsKasiyerRumuzu.Caption = "Kasiyer"
        Me.colsKasiyerRumuzu.FieldName = "sKasiyerRumuzu"
        Me.colsKasiyerRumuzu.Name = "colsKasiyerRumuzu"
        Me.colsKasiyerRumuzu.Visible = True
        Me.colsKasiyerRumuzu.VisibleIndex = 11
        Me.colsKasiyerRumuzu.Width = 64
        '
        'colnGirisCikis
        '
        Me.colnGirisCikis.Caption = "Giriþ/Çýkýþ"
        Me.colnGirisCikis.FieldName = "nGirisCikis"
        Me.colnGirisCikis.Name = "colnGirisCikis"
        Me.colnGirisCikis.Width = 54
        '
        'colsMagaza
        '
        Me.colsMagaza.Caption = "Maðaza"
        Me.colsMagaza.FieldName = "sMagaza"
        Me.colsMagaza.Name = "colsMagaza"
        Me.colsMagaza.Visible = True
        Me.colsMagaza.VisibleIndex = 12
        Me.colsMagaza.Width = 64
        '
        'colsRenk
        '
        Me.colsRenk.Caption = "Renk"
        Me.colsRenk.ColumnEdit = Me.sec_renk
        Me.colsRenk.FieldName = "sRenk"
        Me.colsRenk.Name = "colsRenk"
        '
        'sec_renk
        '
        Me.sec_renk.AutoHeight = False
        Me.sec_renk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_renk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sRenkAdi", "Renk")})
        Me.sec_renk.DisplayMember = "sRenkAdi"
        Me.sec_renk.Name = "sec_renk"
        Me.sec_renk.NullText = ""
        Me.sec_renk.ValueMember = "sRenk"
        '
        'colsYaziIle
        '
        Me.colsYaziIle.Caption = "Yazýyla"
        Me.colsYaziIle.FieldName = "sYaziIle"
        Me.colsYaziIle.Name = "colsYaziIle"
        '
        'colsBarkod
        '
        Me.colsBarkod.Caption = "Barcode"
        Me.colsBarkod.FieldName = "sBarkod"
        Me.colsBarkod.Name = "colsBarkod"
        '
        'colMaliyet
        '
        Me.colMaliyet.Caption = "Maliyet"
        Me.colMaliyet.DisplayFormat.FormatString = "#,0.00"
        Me.colMaliyet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMaliyet.FieldName = "MALIYET"
        Me.colMaliyet.Name = "colMaliyet"
        Me.colMaliyet.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MALIYET", "{0:#,0.00}")})
        '
        'collBrutTutar
        '
        Me.collBrutTutar.Caption = "Brüt Tutar"
        Me.collBrutTutar.DisplayFormat.FormatString = "#,0.00##"
        Me.collBrutTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutTutar.FieldName = "lBrutTutar"
        Me.collBrutTutar.Name = "collBrutTutar"
        Me.collBrutTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBrutTutar", "{0:#,0.00##}")})
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "Saat"
        Me.coldteKayitTarihi.DisplayFormat.FormatString = "HH:mm"
        Me.coldteKayitTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        '
        'colsBeden
        '
        Me.colsBeden.Caption = "Beden"
        Me.colsBeden.FieldName = "sBeden"
        Me.colsBeden.Name = "colsBeden"
        '
        'colsAlisVerisYapanAdi
        '
        Me.colsAlisVerisYapanAdi.Caption = "Av.Yapan Adý"
        Me.colsAlisVerisYapanAdi.FieldName = "sAlisVerisYapanAdi"
        Me.colsAlisVerisYapanAdi.Name = "colsAlisVerisYapanAdi"
        '
        'colsAlisVerisYapanSoyadi
        '
        Me.colsAlisVerisYapanSoyadi.Caption = "Av.Yapan Soyadý"
        Me.colsAlisVerisYapanSoyadi.FieldName = "sAlisVerisYapanSoyadi"
        Me.colsAlisVerisYapanSoyadi.Name = "colsAlisVerisYapanSoyadi"
        '
        'collPrimTutari
        '
        Me.collPrimTutari.Caption = "PrimTutari"
        Me.collPrimTutari.DisplayFormat.FormatString = "#,0.00"
        Me.collPrimTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPrimTutari.FieldName = "Prim"
        Me.collPrimTutari.Name = "collPrimTutari"
        Me.collPrimTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Prim", "{0:#,0.00}")})
        '
        'Grid2Oran
        '
        Me.Grid2Oran.Caption = "Oran"
        Me.Grid2Oran.DisplayFormat.FormatString = "P"
        Me.Grid2Oran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Grid2Oran.FieldName = "ORAN1"
        Me.Grid2Oran.Name = "Grid2Oran"
        Me.Grid2Oran.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "ORAN1", "AVG={0:P}")})
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Aðýrlýk"
        Me.GridColumn1.DisplayFormat.FormatString = "#,0.00"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.FieldName = "nAgirlik"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nAgirlik", "{0:#,0.00}")})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 13
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Ödemesi Geciken Müþteri Kayýtlarý", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Crm-Müþteri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13})
        Me.BarManager1.MaxItemId = 13
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Ara"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Stok Kartý"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Fiyatlandýr"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Envanter"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Stok Hareketleri"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Müþteri Kartý"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Satýþlar"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Kalan Satýþlar"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Kalan Taksitler"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem10.Id = 9
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Excel"
        Me.BarButtonItem11.Id = 10
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Text"
        Me.BarButtonItem12.Id = 11
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Mail"
        Me.BarButtonItem13.Id = 12
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1146, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 634)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1146, 24)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 634)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1146, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 634)
        '
        'frm_stok_satis
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1146, 658)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_satis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Müþteri Satýþ Kontrol "
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_MaliyetTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sec_grid.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_satic.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum_stok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter_stok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara_stok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_Satici, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public kullanici
    Public islemstatus As Boolean = False
    Public firmatipi As Boolean = False
    Public islem As Integer = 0
    Public kriter_fistipi As String = "'FS'"
    Public fisTipi As String
    Dim lBasitMaliyet As Decimal = 0
    Dim lGirisMaliyet As Decimal = 0
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_satici As New DataSet
    Dim ds_magaza As DataSet
    Public sFiyatTipi As String = ""
    Public sDepo
    Public sSaticiRumuzu As String = ""
    Public bFatura As Boolean = False
    Public bBekleyen As Boolean = False
    Public bSatilan As Boolean = False
    Public Status As Boolean = False
    Public frf_islem As String = "mektup"
    Public nMusteriID As Integer = 0
    Public nStokID As Integer = 0
    Dim ds_tbAlislar As DataSet
    Dim tarih1 As DateTime
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If sFiyatTipi <> "" Then
            btn_etiket.Visible = True
        Else
            btn_etiket.Visible = False
        End If
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        If islemstatus = False Then
            DateEdit1.EditValue = dteSistemTarihi '"01/01/" + Today.Year.ToString
            DateEdit2.EditValue = dteSistemTarihi '"31/12/" + Today.Year.ToString
        End If
        DateEdit1.Focus()
        DateEdit1.Select()
        If txt_ara.EditValue <> "" Then
        Else
            txt_ara.EditValue = ""
        End If
        If txt_ara_stok.EditValue <> "" Then
            ara()
        Else
            txt_ara_stok.EditValue = ""
        End If
        dataload_renk()
        dataload_satici()
        If sDepo <> "" Then
            ara()
        End If
        If nMusteriID > 0 Then
            ara()
        End If
        'If sec_depo.Text <> "[Tümü]" Then
        '    ara()
        'End If
        If sec_satic.Text <> "" Then
            ara()
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub dataload_renk()
        sec_renk.DataSource = sorgu(sorgu_query("SELECT * FROM tbRenk")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub dataload_satici()
        sec_Satici.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSaticiRumuzu, sAdi + ' ' + sSoyadi AS SATICI FROM tbSatici where bAktif =1")).Tables(0)
        ds_satici = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST('0' as bit) AS SEC, sSaticiRumuzu AS KOD, sAdi + ' ' + sSoyadi AS ACIKLAMA FROM tbSatici where bAktif =1"))
        ds_magaza = sorgu(sorgu_query("SELECT CAST('0' as bit) AS SEC, sDepo AS KOD, sAciklama AS ACIKLAMA FROM tbDepo WHERE sDepo <> '' ORDER BY sDepo"))
        GridControl2.DataSource = ds_satici.Tables(0)
        GridControl2.DataMember = Nothing
        If sSaticiRumuzu <> "" Then
            sec_satic.Text = sSaticiRumuzu.ToString
            sec_satic.EditValue = sSaticiRumuzu.ToString
        End If
        'If Status = False Then
        '    If Trim(sDepo) = "D001" Or Trim(sDepo) = "D012" Or Trim(sDepo) = "D013" Then
        '        sec_depo.EditValue = "'" & sDepo & "'"
        '        If kullanici > 3 Then
        '            sec_depo.Properties.ReadOnly = False
        '        Else
        '            sec_depo.Properties.ReadOnly = False
        '        End If
        '    Else
        '        If kullanici > 3 Then
        '            sec_depo.EditValue = "'" & sDepo & "'"
        '            sec_depo.Properties.ReadOnly = True
        '        Else
        '            'sec_sDepo.EditValue = sDepo
        '            sec_depo.Properties.ReadOnly = False
        '        End If
        '        'sec_sDepo.EditValue = sDepo
        '        'sec_sDepo.Properties.ReadOnly = False
        '    End If
        'End If
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
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView1.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        GridView1.OptionsView.ShowGroupPanel = True
        GridView1.OptionsCustomization.AllowGroup = True
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        Me.Close()
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        'Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, txt_ara_stok.EditValue, sec_konum_stok.EditValue, sec_kriter_stok.EditValue, txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, sec_satic.Text, sec_depo.Text, sec_MaliyetTipi.SelectedIndex)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += Microsoft.VisualBasic.Left(DateEdit1.EditValue.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(DateEdit2.EditValue.ToString, 10) & " Tarihleri Arasýndaki Satýþlar" & vbCrLf
        'kriter += "Limit = " & txt_altlimit.EditValue & "-" & txt_ustlimit.EditValue
        printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Crm-Müþteri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim itm
        For Each itm In ContextMenu1.MenuItems
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
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
    Public Function stok(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara_stok As String, ByVal konum_stok As String, ByVal ara_kriter_stok As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal satici As String, ByVal depo As String, ByVal MaliyetTipi As Integer) As DataSet
        Dim kriter As String = ""
        If ara.ToString <> "" Then
            If sec_konum.Text = "Kodu" Then
                If firmatipi = False Then
                    kriter += " AND( tbMusteri.lKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
                Else
                    kriter += " AND( tbFirma.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
                End If
            ElseIf sec_konum.Text = "Adý" Then
                If firmatipi = False Then
                    kriter += " AND ( tbMusteri.sAdi " & sorgu_kriter_string(ara, ara_kriter) & " )"
                Else
                    kriter += " AND ( tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                End If
            ElseIf sec_konum.Text = "Soyadý" Then
                kriter += " AND ( tbMusteri.sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Ýstihbarat" Then
                kriter += " AND (( tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + '  ' + tbMusteri.sAciklama5) " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "EvAdresi" Then
                kriter += " AND (tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu + ' ' + tbMusteri.sEvIl  " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "ÝþAdresi" Then
                kriter += " AND (tbMusteri.sIsAdresi1 + ' ' + tbMusteri.sIsAdresi2 + ' ' + tbMusteri.sIsSemt + ' ' + tbMusteri.sIsIl + ' ' + tbMusteri.sIsPostaKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "EvTelefonu" Then
                kriter += " AND ( tbMusteri.sEvTelefonu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "ÝþTelefonu" Then
                kriter += " AND ( tbMusteri.sIsTelefonu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Gsm" Then
                kriter += " AND ( tbMusteri.sGsm " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "DoðumYeri" Then
                kriter += " AND ( tbMusteri.sDogumYeri " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "1.Kefil Adý" Then
                kriter += " AND tbMusteri.nMusteriID IN (Select nMusteriID from tbMusteriKefil1 where sAdi + ' ' + sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "2.Kefil Adý" Then
                kriter += " AND tbMusteri.nMusteriID IN (Select nMusteriID from tbMusteriKefil2 where sAdi + ' ' + sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf1" Then
                kriter += " AND (tbMSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf2" Then
                kriter += " AND (tbMSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf3" Then
                kriter += " AND (tbMSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf4" Then
                kriter += " AND (tbMSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf5" Then
                kriter += " AND (tbMSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Adý+Soyadý" Then
                Dim adi As String = ""
                Dim soyadi As String = ""
                Dim x
                If CStr(ara.ToString) <> "" Then
                    x = (ara).IndexOf(" ", 1, (ara.Length - 1))
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
                If adi.ToString <> "" Then
                    kriter += " AND ( tbMusteri.sAdi " & sorgu_kriter_string(adi, ara_kriter) & " )"
                End If
                If soyadi.ToString <> "" Then
                    kriter += " AND ( tbMusteri.sSoyadi " & sorgu_kriter_string(soyadi, ara_kriter) & " )"
                End If
            Else
            End If
        End If
        If ara_stok.ToString <> "" Then
            If konum_stok = "Kod" Then
                kriter += " AND( tbStok.sKodu " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf konum_stok = "Ad" Then
                kriter += " AND ( tbStok.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
                'ElseIf konum_stok = "Soyadý" Then
                '   kriter += " AND ( tbMusteri.sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum_stok.Text = "Sýnýf1" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif1.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum_stok.Text = "Sýnýf2" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif2.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum_stok.Text = "Sýnýf3" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif3.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum_stok.Text = "Sýnýf4" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif4.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum_stok.Text = "Sýnýf5" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif5.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum_stok.Text = "Sýnýf6" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif6.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum_stok.Text = "Sýnýf7" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif7.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum_stok.Text = "Sýnýf8" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif8.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum_stok.Text = "Sýnýf9" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif9.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum_stok.Text = "Sýnýf10" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif10.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum_stok.Text = "Barkod" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID  FROM         tbStok INNER JOIN                       tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID WHERE tbStokBarkodu.sBarkod " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            End If
        End If
        Dim kriter_fiyat_satis As String = ""
        Dim kriter_fiyat_siparis As String = ""
        If sFiyatTipi <> "" Then
            kriter_fiyat_satis = " AND tbStokFisiDetayi.sFiyatTipi ='Pr' "
            kriter_fiyat_siparis = " AND tbAlisVerisSiparis.sFiyatTipi ='Pr' "
        End If
        Dim kriter_satici As String = ""
        If satici <> "[Tümü]" Then
            kriter_satici += " WHERE sSaticiRumuzu IN ( " & satici & " )"
        End If
        If depo <> "[Tümü]" Then
            kriter_fiyat_satis = " AND tbStokFisiDetayi.sDepo IN ( " & depo & " ) "
            kriter_fiyat_siparis = " AND tbAlisVerisSiparis.sMagazaKodu IN ( " & depo & ")  "
        End If
        If nMusteriID > 0 Then
            kriter += " AND tbMusteri.nMusteriID =" & nMusteriID & " "
        End If
        If nStokID <> 0 Then
            kriter += " AND tbStok.nStokID =" & nStokID & " "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        If bBekleyen = True Then
            cmd.CommandText = sorgu_query("SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , tbAlisVeris.sAlisVerisYapanAdi,tbAlisVeris.sAlisVerisYapanSoyadi,tbMusteri.lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih ,tbAlisVeris.dteKayitTarihi, tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo ,tbAlisVerisSiparis.nSiparisID,tbStok.nStokID , tbStok.sKodu ,tbStok.sModel,tbStok.sRenk,tbRenk.sRenkAdi,tbStok.sBeden, tbStok.sAciklama AS sStokAciklama , tbStok.sBirimCinsi1,tbAlisverisSiparis.lGCMiktar AS Miktar ,tbAlisVerisSiparis.nKdvOrani, (ISNULL(tbAlisverisSiparis.lGCMiktar,0) * (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "')) AS MALIYET,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS FIYATM,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'), 0) AS lFiyat4, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS FIYATA,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sAktifFiyatTipi & "'), 0) AS lFiyati,tbAlisverisSiparis.lBrutFiyat , tbAlisverisSiparis.lIskontoTutari , tbAlisverisSiparis.lTutar * (100 + tbAlisverisSiparis.nKdvOrani) / 100 AS lNetTutar ,tbAlisverisSiparis.lBrutTutar, tbAlisVerisSiparis.lFiyat,tbAlisVerisSiparis.lTutar,tbAlisVerisSiparis.nIskontoYuzdesi,tbAlisVerisSiparis.sDovizCinsi1,tbAlisVerisSiparis.lDovizKuru1,tbAlisVerisSiparis.lDovizMiktari1,tbAlisverisSiparis.sOdemeKodu , tbAlisverisSiparis.sFiyatTipi , tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu ,tbAlisVerisSiparis.sSaticiRumuzu, tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu , tbAlisVerisSiparis.sKasiyerRumuzu,tbAlisverisSiparis.nGirisCikis AS GirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk,tbAlisVeris.sYaziIle,(SELECT     TOP 1 sBarkod FROM         tbStokBarkodu where nStokID =tbStok.nStokID) as sBarkod FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk WHERE (tbAlisverisSiparis.bTeslimEdildi = 0) AND(tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND(tbAlisVerisSiparis.lGCMiktar >0 )AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND  tbAlisveris.dteFaturaTarihi between '" & tarih1 & " ' and '" & tarih2 & "' " & kriter_fiyat_siparis & " " & kriter & "")
        ElseIf bSatilan = True Then
            cmd.CommandText = sorgu_query("SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , tbAlisVeris.sAlisVerisYapanAdi,tbAlisVeris.sAlisVerisYapanSoyadi,tbMusteri.lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih ,tbAlisVeris.dteKayitTarihi, tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo ,0 as nSiparisID,tbStok.nStokID , tbStok.sKodu ,tbStok.sModel,tbStok.sRenk,tbRenk.sRenkAdi,tbStok.sBeden, tbStok.sAciklama AS sStokAciklama , tbStok.sBirimCinsi1,tbStokFisiDetayi.lCikisMiktar1 AS Miktar ,tbStokFisiDetayi.nKdvOrani, (ISNULL(tbStokFisiDetayi.lCikisMiktar1,0) * (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "')) AS MALIYET,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS FIYATM,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'), 0) AS lFiyat4, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS FIYATA,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sAktifFiyatTipi & "'), 0) AS lFiyati,tbStokFisiDetayi.lBrutFiyat , tbStokFisiDetayi.lIskontoTutari , tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar ,tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.lCikisFiyat as lFiyat,tbStokFisiDetayi.lCikisTutar as lTutar,tbStokFisiDetayi.nIskontoYuzdesi,tbStokFisiDetayi.sDovizCinsi1,tbStokFisiDetayi.lDovizKuru1,tbStokFisiDetayi.lDovizMiktari1,tbStokFisiDetayi.sOdemeKodu , tbStokFisiDetayi.sFiyatTipi , tbStokFisiDetayi.sSaticiRumuzu AS SaticiRumuzu ,tbStokFisiDetayi.sSaticiRumuzu, tbAlisVeris.sKasiyerRumuzu AS KasiyerRumuzu , tbAlisVeris.sKasiyerRumuzu,tbStokFisiDetayi.nGirisCikis AS GirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk,tbAlisVeris.sYaziIle,(SELECT     TOP 1 sBarkod FROM         tbStokBarkodu where nStokID =tbStok.nStokID) as sBarkod FROM tbStokFisiDetayi INNER JOIN tbAlisVeris ON tbStokFisiDetayi.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk WHERE (tbStokFisiDetayi.nGirisCikis = 3) and (tbStokFisiDetayi.lCikisMiktar1 >0 )AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K')  AND tbAlisveris.dteFaturaTarihi between '" & tarih1 & " ' and '" & tarih2 & "' " & kriter_fiyat_satis & " " & kriter & "")
        Else
            If firmatipi = False Then
                If islem = 0 Then
                    cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , tbAlisVeris.sAlisVerisYapanAdi,tbAlisVeris.sAlisVerisYapanSoyadi,tbMusteri.lKodu AS lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih , tbAlisVeris.dteKayitTarihi,tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo , tbStok.nStokID , tbStok.nAgirlik, tbStok.sKodu AS sKodu ,tbStok.sModel,tbStok.sBeden, tbStok.sAciklama AS sStokAciklama , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , (ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) * (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "')) AS MALIYET, ISNULL(tbStokFisiDetayi.lBrutFiyat , 0) AS Fiyat , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto ,ISNULL(tbStokFisiDetayi.lPrimTutari , 0) AS Prim , tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar ,tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.sOdemeKodu , tbStokFisiDetayi.sFiyatTipi , tbStokFisiDetayi.sSaticiRumuzu , tbStokFisiDetayi.sKasiyerRumuzu , tbStokFisiDetayi.nGirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk,tbAlisVeris.sYaziIle,(SELECT     TOP 1 sBarkod FROM         tbStokBarkodu where nStokID =tbStok.nStokID) as sBarkod FROM tbStok RIGHT OUTER JOIN tbMusteri INNER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID LEFT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') " & fisTipi & " AND tbAlisveris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter_fiyat_satis & " " & kriter & " UNION ALL SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , tbAlisVeris.sAlisVerisYapanAdi,tbAlisVeris.sAlisVerisYapanSoyadi,tbMusteri.lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih ,tbAlisVeris.dteKayitTarihi, tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo , tbStok.nStokID , tbStok.nAgirlik, tbStok.sKodu ,tbStok.sModel,tbStok.sBeden, tbStok.sAciklama AS sStokAciklama , tbAlisverisSiparis.lGCMiktar AS Miktar , (ISNULL(tbAlisverisSiparis.lGCMiktar,0) * (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "')) AS MALIYET,tbAlisverisSiparis.lBrutFiyat AS Fiyat , tbAlisverisSiparis.lIskontoTutari AS Iskonto ,tbAlisverisSiparis.lPrimTutari AS Prim , tbAlisverisSiparis.lTutar * (100 + tbAlisverisSiparis.nKdvOrani) / 100 AS lNetTutar ,tbAlisverisSiparis.lBrutTutar, tbAlisverisSiparis.sOdemeKodu , tbAlisverisSiparis.sFiyatTipi , tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu , tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu , tbAlisverisSiparis.nGirisCikis AS GirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk,tbAlisVeris.sYaziIle,(SELECT     TOP 1 sBarkod FROM         tbStokBarkodu where nStokID =tbStok.nStokID) as sBarkod FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE tbAlisveris.dteFaturaTarihi between '" & tarih1 & " ' and '" & tarih2 & "' " & fisTipi & " " & kriter_fiyat_siparis & " " & kriter & "  ) t " & kriter_satici & " ORDER BY dteTarih,lNo")
                ElseIf islem = 1 Then
                    If MaliyetTipi = 2 Then
                        ' cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , tbAlisVeris.sAlisVerisYapanAdi,tbAlisVeris.sAlisVerisYapanSoyadi,tbMusteri.lKodu AS lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih , tbAlisVeris.dteKayitTarihi,tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo , tbStok.nStokID , tbStok.sKodu AS sKodu ,tbStok.sModel,tbStok.sBeden, tbStok.sAciklama AS sStokAciklama , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , (ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) * (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "')) AS MALIYET, ISNULL(tbStokFisiDetayi.lBrutFiyat , 0) AS Fiyat , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto ,ISNULL(tbStokFisiDetayi.lPrimTutari , 0) AS Prim , tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar ,tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.sOdemeKodu , tbStokFisiDetayi.sFiyatTipi , tbStokFisiDetayi.sSaticiRumuzu , tbStokFisiDetayi.sKasiyerRumuzu , tbStokFisiDetayi.nGirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk,tbAlisVeris.sYaziIle,(SELECT     TOP 1 sBarkod FROM         tbStokBarkodu where nStokID =tbStok.nStokID) as sBarkod FROM tbStok RIGHT OUTER JOIN tbMusteri INNER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID LEFT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND tbAlisveris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter_fiyat_satis & " " & kriter & " UNION ALL SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , tbAlisVeris.sAlisVerisYapanAdi,tbAlisVeris.sAlisVerisYapanSoyadi,tbMusteri.lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih ,tbAlisVeris.dteKayitTarihi, tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo , tbStok.nStokID , tbStok.sKodu ,tbStok.sModel,tbStok.sBeden, tbStok.sAciklama AS sStokAciklama , tbAlisverisSiparis.lGCMiktar AS Miktar , (ISNULL(tbAlisverisSiparis.lGCMiktar,0) * (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "')) AS MALIYET,tbAlisverisSiparis.lBrutFiyat AS Fiyat , tbAlisverisSiparis.lIskontoTutari AS Iskonto ,tbAlisverisSiparis.lPrimTutari AS Prim , tbAlisverisSiparis.lTutar * (100 + tbAlisverisSiparis.nKdvOrani) / 100 AS lNetTutar ,tbAlisverisSiparis.lBrutTutar, tbAlisverisSiparis.sOdemeKodu , tbAlisverisSiparis.sFiyatTipi , tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu , tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu , tbAlisverisSiparis.nGirisCikis AS GirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk,tbAlisVeris.sYaziIle,(SELECT     TOP 1 sBarkod FROM         tbStokBarkodu where nStokID =tbStok.nStokID) as sBarkod FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE tbAlisveris.dteFaturaTarihi between '" & tarih1 & " ' and '" & tarih2 & "' " & kriter_fiyat_siparis & " " & kriter & "  UNION ALL SELECT CAST(tbStokFisiDetayi.nStokFisiID AS NVARCHAR(20)) AS nAlisVerisID, tbStokFisiDetayi.nFirmaID, '' as AlisVerisYapanAdi,'' as sAlisVerisYapanSoyadi,tbStokFisiDetayi.nMusteriID, tbFirma.sAciklama AS sMusteriAdi, tbStokFisiDetayi.dteFisTarihi AS dteTarih, tbStokFisiMaster.dteKayitTarihi, tbStokFisiMaster.sFisTipi AS fisTipi, tbStokFisiMaster.lFisNo AS lNo, tbStok.nStokID, tbStok.sKodu AS sKodu, tbStok.sModel, tbStok.sBeden, tbStok.sAciklama AS sStokAciklama, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) * (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, ISNULL(tbStokFisiDetayi.lBrutFiyat* (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari* (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, tbStokFisiDetayi.lPrimTutari as Prim,tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo AS sMagaza, tbStok.sRenk, tbStokFisiMaster.sYaziIle, (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod FROM tbFirma INNER JOIN tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID ON tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID LEFT OUTER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiDetayi.sFisTipi = 'FS') AND  tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & " ' AND '" & tarih2 & "' " & kriter_fiyat_satis & " " & kriter & ") t " & kriter_satici & " ORDER BY dteTarih,lNo")
                        'cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , tbAlisVeris.sAlisVerisYapanAdi,tbAlisVeris.sAlisVerisYapanSoyadi,tbMusteri.lKodu AS lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih , tbAlisVeris.dteKayitTarihi,tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo , tbStok.nStokID , tbStok.sKodu AS sKodu ,tbStok.sModel,tbStok.sBeden, tbStok.sAciklama AS sStokAciklama , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , (ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) * (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = 'M')) AS MALIYET,tbStokFisiDetayi.lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1,ISNULL(tbStokFisiDetayi.lBrutFiyat , 0) AS Fiyat , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto ,ISNULL(tbStokFisiDetayi.lPrimTutari , 0) AS Prim , tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar ,tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.sOdemeKodu , tbStokFisiDetayi.sFiyatTipi , tbStokFisiDetayi.sSaticiRumuzu , tbStokFisiDetayi.sKasiyerRumuzu , tbStokFisiDetayi.nGirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk,tbAlisVeris.sYaziIle,(SELECT     TOP 1 sBarkod FROM         tbStokBarkodu where nStokID =tbStok.nStokID) as sBarkod FROM tbStok RIGHT OUTER JOIN tbMusteri INNER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID LEFT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND tbAlisveris.dteFaturaTarihi between '18/10/2018' and '18/10/2018'  AND tbStokFisiDetayi.sDepo IN ( 'D001' )   UNION ALL SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , tbAlisVeris.sAlisVerisYapanAdi,tbAlisVeris.sAlisVerisYapanSoyadi,tbMusteri.lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih ,tbAlisVeris.dteKayitTarihi, tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo , tbStok.nStokID , tbStok.sKodu ,tbStok.sModel,tbStok.sBeden, tbStok.sAciklama AS sStokAciklama , tbAlisverisSiparis.lGCMiktar AS Miktar , (ISNULL(tbAlisverisSiparis.lGCMiktar,0) * (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = 'M')) AS MALIYET,CAST(0 AS MONEY) AS lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1,tbAlisverisSiparis.lBrutFiyat AS Fiyat , tbAlisverisSiparis.lIskontoTutari AS Iskonto ,tbAlisverisSiparis.lPrimTutari AS Prim , tbAlisverisSiparis.lTutar * (100 + tbAlisverisSiparis.nKdvOrani) / 100 AS lNetTutar ,tbAlisverisSiparis.lBrutTutar, tbAlisverisSiparis.sOdemeKodu , tbAlisverisSiparis.sFiyatTipi , tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu , tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu , tbAlisverisSiparis.nGirisCikis AS GirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk,tbAlisVeris.sYaziIle,(SELECT     TOP 1 sBarkod FROM         tbStokBarkodu where nStokID =tbStok.nStokID) as sBarkod FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE tbAlisveris.dteFaturaTarihi between '18/10/2018 ' and '18/10/2018'  AND tbAlisVerisSiparis.sMagazaKodu IN ( 'D001')     UNION ALL SELECT CAST(tbStokFisiDetayi.nStokFisiID AS NVARCHAR(20)) AS nAlisVerisID, tbStokFisiDetayi.nFirmaID, '' as AlisVerisYapanAdi,'' as sAlisVerisYapanSoyadi,tbStokFisiDetayi.nMusteriID, tbFirma.sAciklama AS sMusteriAdi, tbStokFisiDetayi.dteFisTarihi AS dteTarih, tbStokFisiMaster.dteKayitTarihi, tbStokFisiMaster.sFisTipi AS fisTipi, tbStokFisiMaster.lFisNo AS lNo, tbStok.nStokID, tbStok.sKodu AS sKodu, tbStok.sModel, tbStok.sBeden, tbStok.sAciklama AS sStokAciklama, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) * (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = 'M') AS MALIYET, tbStokFisiDetayi.lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1,ISNULL(tbStokFisiDetayi.lBrutFiyat* (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari* (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, tbStokFisiDetayi.lPrimTutari as Prim,tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo AS sMagaza, tbStok.sRenk, tbStokFisiMaster.sYaziIle, (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod FROM tbFirma INNER JOIN tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID ON tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID LEFT OUTER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiDetayi.sFisTipi = 'FS') AND  tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & " ' AND '" & tarih2 & "' " & kriter_fiyat_satis & " " & kriter & ") t " & kriter_satici & " ORDER BY dteTarih,lNo")
                        'cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , tbAlisVeris.sAlisVerisYapanAdi,tbAlisVeris.sAlisVerisYapanSoyadi,tbMusteri.lKodu AS lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih , tbAlisVeris.dteKayitTarihi,tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo , tbStok.nStokID , tbStok.sKodu AS sKodu ,tbStok.sModel,tbStok.sBeden, tbStok.sAciklama AS sStokAciklama , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , (ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) * (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = 'M')) AS MALIYET,tbStokFisiDetayi.lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1,CAST(0 AS MONEY) AS KAR,ISNULL(tbStokFisiDetayi.lBrutFiyat , 0) AS Fiyat , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto ,ISNULL(tbStokFisiDetayi.lPrimTutari , 0) AS Prim , tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar ,tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.sOdemeKodu , tbStokFisiDetayi.sFiyatTipi , tbStokFisiDetayi.sSaticiRumuzu , tbStokFisiDetayi.sKasiyerRumuzu , tbStokFisiDetayi.nGirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk,tbAlisVeris.sYaziIle,(SELECT     TOP 1 sBarkod FROM         tbStokBarkodu where nStokID =tbStok.nStokID) as sBarkod FROM tbStok RIGHT OUTER JOIN tbMusteri INNER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID LEFT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND tbAlisveris.dteFaturaTarihi between '18/10/2018' and '18/10/2018'  AND tbStokFisiDetayi.sDepo IN ( 'D001' )   UNION ALL SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , tbAlisVeris.sAlisVerisYapanAdi,tbAlisVeris.sAlisVerisYapanSoyadi,tbMusteri.lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih ,tbAlisVeris.dteKayitTarihi, tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo , tbStok.nStokID , tbStok.sKodu ,tbStok.sModel,tbStok.sBeden, tbStok.sAciklama AS sStokAciklama , tbAlisverisSiparis.lGCMiktar AS Miktar , (ISNULL(tbAlisverisSiparis.lGCMiktar,0) * (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = 'M')) AS MALIYET,CAST(0 AS MONEY) AS lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1,CAST(0 AS MONEY) AS KAR,tbAlisverisSiparis.lBrutFiyat AS Fiyat , tbAlisverisSiparis.lIskontoTutari AS Iskonto ,tbAlisverisSiparis.lPrimTutari AS Prim , tbAlisverisSiparis.lTutar * (100 + tbAlisverisSiparis.nKdvOrani) / 100 AS lNetTutar ,tbAlisverisSiparis.lBrutTutar, tbAlisverisSiparis.sOdemeKodu , tbAlisverisSiparis.sFiyatTipi , tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu , tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu , tbAlisverisSiparis.nGirisCikis AS GirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk,tbAlisVeris.sYaziIle,(SELECT     TOP 1 sBarkod FROM         tbStokBarkodu where nStokID =tbStok.nStokID) as sBarkod FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE tbAlisveris.dteFaturaTarihi between '18/10/2018 ' and '18/10/2018'  AND tbAlisVerisSiparis.sMagazaKodu IN ( 'D001')     UNION ALL SELECT CAST(tbStokFisiDetayi.nStokFisiID AS NVARCHAR(20)) AS nAlisVerisID, tbStokFisiDetayi.nFirmaID, '' as AlisVerisYapanAdi,'' as sAlisVerisYapanSoyadi,tbStokFisiDetayi.nMusteriID, tbFirma.sAciklama AS sMusteriAdi, tbStokFisiDetayi.dteFisTarihi AS dteTarih, tbStokFisiMaster.dteKayitTarihi, tbStokFisiMaster.sFisTipi AS fisTipi, tbStokFisiMaster.lFisNo AS lNo, tbStok.nStokID, tbStok.sKodu AS sKodu, tbStok.sModel, tbStok.sBeden, tbStok.sAciklama AS sStokAciklama, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) * (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = 'M') AS MALIYET, tbStokFisiDetayi.lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1,CAST(0 AS MONEY) AS KAR,ISNULL(tbStokFisiDetayi.lBrutFiyat* (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari* (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, tbStokFisiDetayi.lPrimTutari as Prim,tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo AS sMagaza, tbStok.sRenk, tbStokFisiMaster.sYaziIle, (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod FROM tbFirma INNER JOIN tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID ON tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID LEFT OUTER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiDetayi.sFisTipi = 'FS') AND  tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & " ' AND '" & tarih2 & "' " & kriter_fiyat_satis & " " & kriter & ") t " & kriter_satici & " ORDER BY dteTarih,lNo")
                        cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , tbAlisVeris.sAlisVerisYapanAdi,tbAlisVeris.sAlisVerisYapanSoyadi,tbMusteri.lKodu AS lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih , tbAlisVeris.dteKayitTarihi,tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo , tbStok.nStokID , tbStok.nAgirlik, tbStok.sKodu AS sKodu ,tbStok.sModel,tbStok.sBeden, tbStok.sAciklama AS sStokAciklama ,(SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '1') AS PESIN, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '3') AS ONAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '4') AS ONBESAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '2') AS ALTIAY, ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , (ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) * (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = 'M')) AS MALIYET,tbStokFisiDetayi.lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1,CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT,CAST(0 AS MONEY) AS NORMALTUTAR,ISNULL(tbStokFisiDetayi.lBrutFiyat , 0) AS Fiyat , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto ,(ISNULL(tbStokFisiDetayi.lPrimTutari - tbStokFisiDetayi.lIskontoTutari , 0)) AS Prim , tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar ,tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.sOdemeKodu , tbStokFisiDetayi.sFiyatTipi , tbStokFisiDetayi.sSaticiRumuzu , tbStokFisiDetayi.sKasiyerRumuzu , tbStokFisiDetayi.nGirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk,tbAlisVeris.sYaziIle,(SELECT     TOP 1 sBarkod FROM         tbStokBarkodu where nStokID =tbStok.nStokID) as sBarkod FROM tbStok RIGHT OUTER JOIN tbMusteri INNER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID LEFT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND tbAlisveris.dteFaturaTarihi between '18/10/2018' and '18/10/2018'  AND tbStokFisiDetayi.sDepo IN ( 'D001' )   UNION ALL SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , tbAlisVeris.sAlisVerisYapanAdi,tbAlisVeris.sAlisVerisYapanSoyadi,tbMusteri.lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih ,tbAlisVeris.dteKayitTarihi, tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo , tbStok.nStokID , tbStok.nAgirlik, tbStok.sKodu ,tbStok.sModel,tbStok.sBeden, tbStok.sAciklama AS sStokAciklama ,(SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '1') AS PESIN, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '3') AS ONAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '4') AS ONBESAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '2') AS ALTIAY, tbAlisverisSiparis.lGCMiktar AS Miktar , (ISNULL(tbAlisverisSiparis.lGCMiktar,0) * (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = 'M')) AS MALIYET,CAST(0 AS MONEY) AS lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1,CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT,CAST(0 AS MONEY) AS NORMALTUTAR,tbAlisverisSiparis.lBrutFiyat AS Fiyat , tbAlisverisSiparis.lIskontoTutari AS Iskonto ,tbAlisverisSiparis.lPrimTutari AS Prim , tbAlisverisSiparis.lTutar * (100 + tbAlisverisSiparis.nKdvOrani) / 100 AS lNetTutar ,tbAlisverisSiparis.lBrutTutar, tbAlisverisSiparis.sOdemeKodu , tbAlisverisSiparis.sFiyatTipi , tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu , tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu , tbAlisverisSiparis.nGirisCikis AS GirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk,tbAlisVeris.sYaziIle,(SELECT     TOP 1 sBarkod FROM         tbStokBarkodu where nStokID =tbStok.nStokID) as sBarkod FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE tbAlisveris.dteFaturaTarihi between '18/10/2018 ' and '18/10/2018'  AND tbAlisVerisSiparis.sMagazaKodu IN ( 'D001')     UNION ALL SELECT CAST(tbStokFisiDetayi.nStokFisiID AS NVARCHAR(20)) AS nAlisVerisID, tbStokFisiDetayi.nFirmaID, '' as AlisVerisYapanAdi,'' as sAlisVerisYapanSoyadi,tbStokFisiDetayi.nMusteriID, tbFirma.sAciklama AS sMusteriAdi, tbStokFisiDetayi.dteFisTarihi AS dteTarih, tbStokFisiMaster.dteKayitTarihi, tbStokFisiMaster.sFisTipi AS fisTipi, tbStokFisiMaster.lFisNo AS lNo, tbStok.nStokID, tbStok.nAgirlik, tbStok.sKodu AS sKodu, tbStok.sModel, tbStok.sBeden, tbStok.sAciklama AS sStokAciklama, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '1') AS PESIN, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '3') AS ONAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '4') AS ONBESAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '2') AS ALTIAY,ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) * (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = 'M') AS MALIYET, tbStokFisiDetayi.lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1,CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT,CAST(0 AS MONEY) AS NORMALTUTAR,ISNULL(tbStokFisiDetayi.lBrutFiyat* (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari* (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, tbStokFisiDetayi.lPrimTutari as Prim,tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo AS sMagaza, tbStok.sRenk, tbStokFisiMaster.sYaziIle, (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod FROM tbFirma INNER JOIN tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID ON tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID LEFT OUTER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiDetayi.sFisTipi = 'FS') AND  tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & " ' AND '" & tarih2 & "' " & kriter_fiyat_satis & " " & kriter & ") t " & kriter_satici & " ORDER BY dteTarih,lNo")
                    Else
                        cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , tbAlisVeris.sAlisVerisYapanAdi,tbAlisVeris.sAlisVerisYapanSoyadi,tbMusteri.lKodu AS lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih , tbAlisVeris.dteKayitTarihi,tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo , tbStok.nStokID , tbStok.nAgirlik, tbStok.sKodu AS sKodu ,tbStok.sModel,tbStok.sBeden, tbStok.sAciklama AS sStokAciklama , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , (ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) * (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "')) AS MALIYET, ISNULL(tbStokFisiDetayi.lBrutFiyat , 0) AS Fiyat , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto ,ISNULL(tbStokFisiDetayi.lPrimTutari , 0) AS Prim , tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar ,tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.sOdemeKodu , tbStokFisiDetayi.sFiyatTipi , tbStokFisiDetayi.sSaticiRumuzu , tbStokFisiDetayi.sKasiyerRumuzu , tbStokFisiDetayi.nGirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk,tbAlisVeris.sYaziIle,(SELECT     TOP 1 sBarkod FROM         tbStokBarkodu where nStokID =tbStok.nStokID) as sBarkod FROM tbStok RIGHT OUTER JOIN tbMusteri INNER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID LEFT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND tbAlisveris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter_fiyat_satis & " " & kriter & " UNION ALL SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , tbAlisVeris.sAlisVerisYapanAdi,tbAlisVeris.sAlisVerisYapanSoyadi,tbMusteri.lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih ,tbAlisVeris.dteKayitTarihi, tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo , tbStok.nStokID , tbStok.nAgirlik, tbStok.sKodu ,tbStok.sModel,tbStok.sBeden, tbStok.sAciklama AS sStokAciklama , tbAlisverisSiparis.lGCMiktar AS Miktar , (ISNULL(tbAlisverisSiparis.lGCMiktar,0) * (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "')) AS MALIYET,tbAlisverisSiparis.lBrutFiyat AS Fiyat , tbAlisverisSiparis.lIskontoTutari AS Iskonto ,tbAlisverisSiparis.lPrimTutari AS Prim , tbAlisverisSiparis.lTutar * (100 + tbAlisverisSiparis.nKdvOrani) / 100 AS lNetTutar ,tbAlisverisSiparis.lBrutTutar, tbAlisverisSiparis.sOdemeKodu , tbAlisverisSiparis.sFiyatTipi , tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu , tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu , tbAlisverisSiparis.nGirisCikis AS GirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk,tbAlisVeris.sYaziIle,(SELECT     TOP 1 sBarkod FROM         tbStokBarkodu where nStokID =tbStok.nStokID) as sBarkod FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE tbAlisveris.dteFaturaTarihi between '" & tarih1 & " ' and '" & tarih2 & "' " & kriter_fiyat_siparis & " " & kriter & "  UNION ALL SELECT CAST(tbStokFisiDetayi.nStokFisiID AS NVARCHAR(20)) AS nAlisVerisID, tbStokFisiDetayi.nFirmaID, '' as AlisVerisYapanAdi,'' as sAlisVerisYapanSoyadi,tbStokFisiDetayi.nMusteriID, tbFirma.sAciklama AS sMusteriAdi, tbStokFisiDetayi.dteFisTarihi AS dteTarih, tbStokFisiMaster.dteKayitTarihi, tbStokFisiMaster.sFisTipi AS fisTipi, tbStokFisiMaster.lFisNo AS lNo, tbStok.nStokID, tbStok.nAgirlik, tbStok.sKodu AS sKodu, tbStok.sModel, tbStok.sBeden, tbStok.sAciklama AS sStokAciklama, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) * (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, ISNULL(tbStokFisiDetayi.lBrutFiyat* (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari* (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, tbStokFisiDetayi.lPrimTutari as Prim,tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo AS sMagaza, tbStok.sRenk, tbStokFisiMaster.sYaziIle, (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod FROM tbFirma INNER JOIN tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID ON tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID LEFT OUTER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiDetayi.sFisTipi = 'FS') AND  tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & " ' AND '" & tarih2 & "' " & kriter_fiyat_satis & " " & kriter & ") t " & kriter_satici & " ORDER BY dteTarih,lNo")
                    End If
                ElseIf islem = 2 Then
                    cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT CAST(tbStokFisiDetayi.nStokFisiID AS NVARCHAR(20)) AS nAlisVerisID, tbStokFisiDetayi.nFirmaID, tbStokFisiDetayi.nMusteriID, tbFirma.sKodu as lKodu,tbFirma.sAciklama AS sMusteriAdi, tbStokFisiDetayi.dteFisTarihi AS dteTarih, tbStokFisiMaster.dteKayitTarihi, tbStokFisiMaster.sFisTipi AS fisTipi, tbStokFisiMaster.lFisNo AS lNo, tbStok.nStokID, tbStok.sKodu AS sKodu, tbStok.sModel, tbStok.sBeden, tbStok.sAciklama AS sStokAciklama, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) * (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, ISNULL(tbStokFisiDetayi.lBrutFiyat* (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari* (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, tbStokFisiDetayi.lPrimTutari as Prim,tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo AS sMagaza, tbStok.sRenk, tbStokFisiMaster.sYaziIle, (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod FROM tbFirma INNER JOIN tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID ON tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID LEFT OUTER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiDetayi.sFisTipi IN (" & kriter_fistipi & ")) AND  tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & " ' AND '" & tarih2 & "' " & kriter_fiyat_satis & " " & kriter & ") t " & kriter_satici & " ORDER BY dteTarih,lNo")
                    End If
                ElseIf firmatipi = True Then
                    cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST(tbStokFisiMaster.nStokFisiID as CHAR(60)) as nAlisVerisID, tbFirma.nFirmaID as nMusteriID, tbFirma.sKodu AS lKodu, tbFirma.sAciklama as sMusteriAdi, tbStokFisiMaster.dteFisTarihi AS dteTarih, tbStokFisiMaster.sFisTipi AS fisTipi, tbStokFisiMaster.lFisNo AS lNo, tbStok.nStokID, tbStok.sKodu AS sKodu,tbStok.sModel,tbStok.sBeden, tbStok.sAciklama AS sStokAciklama, ISNULL(tbStokFisiDetayi.lGirisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lBrutFiyat, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari, 0) AS Iskonto, tbStokFisiDetayi.lPrimTutari as Prim,tbStokFisiDetayi.lCikisTutar AS lNetTutar,tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbStok.sRenk,tbStokFisiDetayi.sDepo as sMagaza FROM tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE tbStokFisiDetayi.nGirisCikis= 1 and tbStokFisiDetayi.dteFisTarihi between '" & tarih1 & " ' and '" & tarih2 & "' " & kriter & "")
                End If
            End If
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
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara_stok As String, ByVal konum_stok As String, ByVal ara_kriter_stok As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal satici As String, ByVal depo As String, ByVal MaliyetTipi As Integer)
        DataSet1 = stok(tarih1, tarih2, ara_stok, konum_stok, ara_kriter_stok, ara, konum, ara_kriter, satici, depo, MaliyetTipi)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
        If MaliyetTipi = 2 Then
            kontrol_oran(MaliyetTipi)
        End If
    End Sub
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        'Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, txt_ara_stok.EditValue, sec_konum_stok.EditValue, sec_kriter_stok.EditValue, txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, sec_satic.Text, sec_depo.Text, sec_MaliyetTipi.SelectedIndex)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
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
            frm.stokno = dr("nAlisverisID")
            frm.fistipi = Trim(dr("sFisTipi").ToString)
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_karti()
        If GridView1.RowCount > 0 Then
            'Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            'Dim frm As New frm_musteri_karti
            'frm.firmano = firmano
            'frm.donemno = donemno
            'frm.connection = connection
            'frm.musterino = dr("lKodu")
            'frm.musteriID = dr("nMusteriID")
            'frm.kullanici = kullanici
            'If yetki_kontrol(kullanici, frm.Name) = True Then
            '    frm.ShowDialog()
            'End If
            'frm.Close()
            'frm.Dispose()
            'frm = Nothing
            If GridView1.RowCount > 0 Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                If bFatura = False Then
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
                Else
                    Dim frm As New frm_firma_kart
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.connection = connection
                    frm.sKodu = dr("lKodu")
                    frm.nFirmaID = dr("nFirmaID")
                    frm.kullanici = kullanici
                    If yetki_kontrol(kullanici, frm.Name) = True Then
                        frm.ShowDialog()
                    End If
                    frm.Close()
                    frm.Dispose()
                    frm = Nothing
                End If
                dr = Nothing
            End If
        End If
    End Sub
    Private Sub analiz_acik_faturalar_analiz()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_acik_analiz
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub kontrol_oran(ByVal MaliyetTipi As Integer)
        Dim dr As DataRow
        Dim netmaliyet As Decimal = 0
        Dim normalfiyat As Decimal = 0
        Dim maliyet As Decimal = 0
        Dim fiyattipi As String = ""
        If MaliyetTipi = 0 Then
            colMALIYET.FieldName = "MALIYET"
        ElseIf MaliyetTipi = 1 Then
            colMALIYET.FieldName = "lMaliyetFiyat"
        End If
        Dim lToplamKar As Decimal = 0
        Dim lToplamMaliyet As Decimal = 0
        Dim nYuzdelik As Decimal = 0
        Dim nStokID As Int64 = 0
        Progress.ShowProgress(DataSet1.Tables(0).Rows.Count(), Sorgu_sDil("Stoklar Kontrol Ediliyor...", sDil))
        Dim nIndex As Integer = 0
        For Each dr In DataSet1.Tables(0).Rows
            If dr("sKodu").ToString <> "" Then
                If MaliyetTipi = 0 Then
                    Try
                        netmaliyet = dr("MALIYET") * dr("Miktar")
                    Catch ex As Exception
                        netmaliyet = 0
                    End Try
                ElseIf MaliyetTipi = 1 Then
                    Try
                        If Trim(dr("fisTipi")) = "SK" Or Trim(dr("fisTipi")) = "SP" Then
                            netmaliyet = dr("MALIYET") * dr("Miktar")
                        Else
                            netmaliyet = dr("lMaliyetFiyat") * dr("Miktar")
                        End If
                    Catch ex As Exception
                        netmaliyet = 0
                    End Try
                ElseIf MaliyetTipi = 2 Then
                    tarih1 = dr("dteTarih")
                    ds_tbAlislar = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY SELECT TOP 1 tbStokFisiDetayi.nIslemID, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.nStokID, tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.lMaliyetFiyat, tbStokFisiDetayi.lMaliyetTutar, tbStokFisiDetayi.lIlaveMaliyetTutar, tbStokFisiMaster.lMalBedeli AS lMalBedeli, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.lMalIskontoTutari AS lMalIskontotuTutari, tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari, tbStokFisiMaster.lEkmaliyet1, tbStokFisiMaster.lEkmaliyet2, tbStokFisiMaster.lEkmaliyet3, (SELECT ISNULL(SUM(lTutar), 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiMaster.nStokFisiID and nIslemID = 0) AS lEkMaliyet4, (SELECT ISNULL(SUM(lTutar), 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar, CAST(0 AS money) AS nEkOran, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani FROM tbStokFisiDetayi INNER JOIN tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiDetayi.nGirisCikis IN (1)) and tbStokFisiDetayi.lGirisMiktar1 > 0 AND (tbStokFisiDetayi.dteFisTarihi <= '" & tarih1 & "') AND tbStokFisiDetayi.nStokID = " & dr("nStokID") & " and tbStokFisiDetayi.sFisTipi <> 'T' ORDER BY tbStokFisiDetayi.nStokID, tbStokFisiDetayi.dteFisTarihi DESC"))
                    dr("MALIYET") = sorgu_sayi(maliyet_kontrol(), 0)
                    maliyet = dr("MALIYET")
                    Try
                        netmaliyet = dr("MALIYET") * dr("Miktar")
                    Catch ex As Exception
                        netmaliyet = 0
                    End Try
                End If
                Try
                    dr("ORAN1") = ((dr("lNetTutar") - (netmaliyet)) / netmaliyet)
                    dr("KAR") = dr("lNetTutar") - (netmaliyet)
                Catch ex As Exception
                    dr("ORAN1") = 0
                    dr("KAR") = dr("lNetTutar") - (netmaliyet)
                End Try
                lToplamKar = lToplamKar + sorgu_sayi(dr("KAR"), 0)
                lToplamMaliyet = lToplamMaliyet + sorgu_sayi(netmaliyet, 0)
                If dr("nGirisCikis") <> 5 Then
                    If Trim(dr("sFiyatTipi").ToString) <> "HD" Then
                        fiyattipi = Trim(dr("sFiyatTipi").ToString).ToUpper()
                        'MessageBox.Show(fiyattipi.ToUpper())
                        If fiyattipi = Trim(sFiyat3).ToUpper() Then
                            If Math.Abs(dr("Fiyat")) <> sorgu_sayi(dr("ONAY"), 0) Then
                                dr("NORMALFIYAT") = sorgu_sayi(dr("ONAY"), 0)
                                dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                                normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                                dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR")
                                dr("FIYATFARKI") = dr("Fiyat") - normalfiyat
                            End If
                        ElseIf fiyattipi = Trim(sFiyat2).ToUpper() Then
                            If Math.Abs(dr("Fiyat")) <> sorgu_sayi(dr("ALTIAY"), 0) Then
                                dr("NORMALFIYAT") = sorgu_sayi(dr("ALTIAY"), 0)
                                dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                                normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                                dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR")
                                dr("FIYATFARKI") = dr("Fiyat") - normalfiyat
                            End If
                        ElseIf fiyattipi = Trim(sFiyat1).ToUpper() Then
                            If Math.Abs(dr("Fiyat")) <> sorgu_sayi(dr("PESIN"), 0) Then
                                dr("NORMALFIYAT") = sorgu_sayi(dr("PESIN"), 0)
                                dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                                normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                                dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR")
                                dr("FIYATFARKI") = dr("Fiyat") - normalfiyat
                            End If
                        ElseIf fiyattipi = Trim(sFiyat4).ToUpper() Then
                            If Math.Abs(dr("Fiyat")) <> sorgu_sayi(dr("ONBESAY"), 0) Then
                                dr("NORMALFIYAT") = sorgu_sayi(dr("ONBESAY"), 0)
                                dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                                normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                                dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR")
                                dr("FIYATFARKI") = dr("Fiyat") - normalfiyat
                            End If
                            'ElseIf fiyattipi = "15AY" Then
                            '    MessageBox.Show("15AY bu")
                            '    If Math.Abs(dr("Fiyat")) <> sorgu_sayi(dr("ONBESAY"), 0) Then
                            '        dr("NORMALFIYAT") = sorgu_sayi(dr("ONBESAY"), 0)
                            '        dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            '        normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                            '        dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR")
                            '        dr("FIYATFARKI") = dr("Fiyat") - normalfiyat
                            '        MessageBox.Show("normalfiyat: " + normalfiyat + "|FiyatFarký: " + dr("FIYATFARKI"))
                            '    End If
                        End If
                    Else
                        'fiyattipi = Trim(dr("sFiyatTipi").ToString)
                        If fiyattipi = Trim(sFiyat3).ToUpper() Then
                            dr("NORMALFIYAT") = sorgu_sayi(dr("ONAY"), 0)
                            dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                            dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR") + 0.01
                            dr("FIYATFARKI") = (dr("Fiyat") - normalfiyat) + +0.01
                        ElseIf fiyattipi = Trim(sFiyat2).ToUpper() Then
                            dr("NORMALFIYAT") = sorgu_sayi(dr("ALTIAY"), 0)
                            dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                            dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR") + 0.01
                            dr("FIYATFARKI") = (dr("Fiyat") - normalfiyat) + 0.01
                        ElseIf fiyattipi = Trim(sFiyat1).ToUpper() Then
                            dr("NORMALFIYAT") = sorgu_sayi(dr("PESIN"), 0)
                            dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                            dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR") + 0.01
                            dr("FIYATFARKI") = (dr("Fiyat") - normalfiyat) + 0.01
                        ElseIf fiyattipi = Trim(sFiyat4).ToUpper() Then
                            dr("NORMALFIYAT") = sorgu_sayi(dr("ONBESAY"), 0)
                            dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                            dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR") + 0.01
                            dr("FIYATFARKI") = (dr("Fiyat") - normalfiyat) + 0.01
                            'ElseIf fiyattipi = "15AY" Then
                            '    dr("NORMALFIYAT") = sorgu_sayi(dr("ONBESAY"), 0)
                            '    dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            '    normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                            '    dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR") + 0.01
                            '    dr("FIYATFARKI") = (dr("Fiyat") - normalfiyat) + 0.01
                        End If
                    End If
                End If
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sStokAciklama").ToString)
        Next
        Try
            nYuzdelik = (lToplamKar / lToplamMaliyet) * 100
        Catch ex As Exception
            nYuzdelik = 0
        End Try
        colORAN1.SummaryItem.DisplayFormat = "%" & FormatNumber(nYuzdelik, 2).ToString
        Grid2Oran.SummaryItem.DisplayFormat = "%" & FormatNumber(nYuzdelik, 2).ToString
        dr = Nothing
        Progress.HideProgress()
    End Sub
    Private Function maliyet_kontrol() As Decimal
        Dim maliyet As Decimal = 0
        Dim oranekmaliyet As Decimal = 0
        Dim dr3 As DataRow
        Dim lToplamMiktar As Decimal = 0
        Dim lToplamMaliyet As Decimal = 0
        Dim lToplamTutar As Decimal = 0
        For Each dr3 In ds_tbAlislar.Tables(0).Rows
            maliyet = (dr3("lGirisTutar")) / dr3("lGirisMiktar1")
            If dr3("nKdvOrani") <> dr3("nStokKdvOrani") Then
                If bKdvKontrolluMaliyet = True Then
                    maliyet = maliyet * ((dr3("nStokKdvOrani") + 100) / 100)
                Else
                    maliyet = maliyet * ((dr3("nKdvOrani") + 100) / 100)
                End If
            Else
                maliyet = maliyet * ((dr3("nKdvOrani") + 100) / 100)
            End If
            maliyet = (maliyet) - (Math.Abs((dr3("lIlaveMaliyetTutar") + dr3("lEkIlaveMaliyetTutar")) / dr3("lGirisMiktar1")))
            Try
                If CType(dr3("lEkmaliyet1") + dr3("lEkMaliyet3") + dr3("lEkMaliyet4"), Decimal) <> 0 Then
                    oranekmaliyet = CType(dr3("lEkmaliyet1") + dr3("lEkmaliyet3") + dr3("lEkMaliyet4"), Decimal) / CType(dr3("lNetTutar") - (dr3("lEkmaliyet1")), Decimal)
                    maliyet = maliyet + (maliyet * (((oranekmaliyet * 100)) / 100))
                End If
            Catch ex As Exception
            End Try
            dr3("lMaliyetFiyat") = maliyet
            'dr3("lGirisTutar") = dr3("lGirisTutar") * ((dr3("nKdvOrani") + 100) / 100)
            lToplamMiktar += dr3("lGirisMiktar1")
            lToplamMaliyet += dr3("lGirisMiktar1") * dr3("lMaliyetFiyat")
            lToplamTutar += dr3("lGirisTutar") * ((dr3("nKdvOrani") + 100) / 100)
        Next
        Try
            lBasitMaliyet = lToplamMaliyet / lToplamMiktar
        Catch ex As Exception
            lBasitMaliyet = 0
        End Try
        Try
            lGirisMaliyet = lToplamTutar / lToplamMiktar
        Catch ex As Exception
            lGirisMaliyet = 0
        End Try
        Return maliyet
    End Function
    Private Function lMaliyet_hesapla(ByVal lMiktar As Decimal, ByVal tarih As DateTime) As Decimal
        Dim dr As DataRow
        Dim tutar As Decimal = 0
        Dim lSonMiktar As Decimal = 0
        Dim lIlkMiktar As Decimal = 0
        Dim lSonMaliyet As Decimal = 0
        Dim lOrjMiktar As Decimal = lMiktar
        'lMiktar = Math.Abs(lMiktar)
        lSonMiktar = lMiktar
        lIlkMiktar = lMiktar
        Dim nIslemID As Int64 = 0
        If lMiktar < 0 Then
            For Each dr In ds_tbAlislar.Tables(0).Rows
                If lMiktar < 0 And dr("dteFisTarihi") <= tarih Then
                    tutar = dr("lMaliyetFiyat") * lMiktar
                    nIslemID = dr("nIslemID")
                End If
            Next
        End If
        For Each dr In ds_tbAlislar.Tables(0).Rows
            If lMiktar < 0 And dr("dteFisTarihi") <= tarih And nIslemID = dr("nIslemID") Then
                dr("lGirisMiktar1") = dr("lGirisMiktar1") + Math.Abs(lMiktar)
            End If
            If dr("lGirisMiktar1") > 0 And lSonMiktar > 0 Then
                If lMiktar > dr("lGirisMiktar1") Then
                    'tutar += dr("lMaliyetFiyat") * (lMiktar - dr("lGirisMiktar1"))
                    lSonMaliyet = dr("lMaliyetFiyat")
                    tutar += dr("lMaliyetFiyat") * (dr("lGirisMiktar1"))
                    lMiktar -= dr("lGirisMiktar1")
                    dr("lGirisMiktar1") = 0
                ElseIf lSonMiktar = dr("lGirisMiktar1") Then
                    tutar += dr("lMaliyetFiyat") * dr("lGirisMiktar1")
                    lSonMaliyet = dr("lMaliyetFiyat")
                    'lMiktar = lMiktar - dr("lGirisMiktar1")
                    lMiktar = 0
                    dr("lGirisMiktar1") = 0
                ElseIf lSonMiktar < dr("lGirisMiktar1") Then
                    tutar += dr("lMaliyetFiyat") * (lMiktar)
                    lSonMaliyet = dr("lMaliyetFiyat")
                    dr("lGirisMiktar1") = dr("lGirisMiktar1") - lMiktar
                    lMiktar = 0
                End If
                lSonMiktar = lMiktar
            End If
        Next
        If lSonMiktar > 0 Then
            Try
                tutar = tutar / (lIlkMiktar - lMiktar)
                tutar = tutar * lIlkMiktar
            Catch ex As Exception
                tutar = lIlkMiktar * lSonMaliyet
            End Try
        End If
        Return tutar
    End Function
    Private Sub analiz_acik_faturalar()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_acik
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_satislar()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_kapatma
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
    Private Sub analiz_envanter()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_envanter
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.stokno = dr("nStokId")
            frm.stokkodu = dr("sKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_stok_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokId")
            frm.sKodu = dr("sKodu")
            frm.sModel = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub stok_fiyat()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_fiyatlandir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokId")
            frm.sModel = dr("sModel")
            frm.sKodu = dr("sKodu")
            frm.sRenk = dr("sRenk")
            frm.sBeden = dr("sBeden")
            frm.txt_musteriNo.Text = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_stok_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sKodu")
            frm.nFirmaID = 0
            frm.sec_firma.Checked = False
            frm.sec_giris.Text = "[Tümü]"
            frm.collGirisFiyat.Visible = False
            frm.collGirisFiyat.OptionsColumn.ShowInCustomizationForm = False
            frm.collCikisFiyat.Visible = False
            frm.collCikisFiyat.OptionsColumn.ShowInCustomizationForm = False
            frm.collBrutFiyat.Visible = False
            frm.collBrutFiyat.OptionsColumn.ShowInCustomizationForm = False
            frm.collBrutTutar.Visible = False
            frm.collBrutTutar.OptionsColumn.ShowInCustomizationForm = False
            frm.colnKdvOrani.Visible = False
            frm.colnKdvOrani.OptionsColumn.ShowInCustomizationForm = False
            frm.collIskontoTutari.Visible = False
            frm.collIskontoTutari.OptionsColumn.ShowInCustomizationForm = False
            frm.colnGirisCikis.Visible = False
            frm.MenuItem16.Enabled = False
            frm.MenuItem17.Enabled = False
            frm.MenuItem20.Enabled = False
            frm.Label1.Text = dr("sStokAciklama") & vbCrLf & frm.Label1.Text
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_stok_KarlilikAkisTablosu()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_Stok_Satis_Maliyetlendir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.txt_sStokKodu.Text = dr("sKodu")
            frm.bAnaliz = True
            If yetki_kontrol(kullanici, "frm_Stok_KarlilikAkisTablosu") = True Then
                frm.ShowDialog()
            End If
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stok_satis_detay()
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
        'Dim dr As DataRow
        'dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'lbl_istihbarat.Text = dr("ISTIHBARAT")
        'dr = Nothing
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            'If XtraMessageBox.Show(Sorgu_sDil("Açýk Faturalar Kontrol Ekranýndan Çýkmak Ýstediðinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If islemstatus = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.Close()
        End If
        'Me.Close()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        analiz_musteri_karti()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        analiz_musteri_satislar()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        analiz_acik_faturalar()
    End Sub
    Private Sub MenuItem16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        analiz_envanter()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If islemstatus = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                'Me.Close()
            End If
        End If
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        If islemstatus = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            'Me.Close()
        End If
    End Sub
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer, ByVal miktar As Decimal, ByVal dteTarih As DateTime, ByVal sFisTipi As String, ByVal lFisNo As String, ByVal MusteriNo As Int64, ByVal MusteriKodu As String, ByVal Musteri As String, ByVal StokNo As Int64, ByVal StokKodu As String, ByVal Malincinsi As String, ByVal barkod As String, ByVal liste As String)
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim ds1 As New TfrxUserDataSetClass
            Dim qr_hareket As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            'frx.SetVariable("STOKNO", "" & stokno & "")
            'frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            'frx.SetVariable("PESIN", "" & fiyat1 & "")
            'frx.SetVariable("ALTIAY", "" & fiyat2 & "")
            'frx.SetVariable("ONAY", "" & fiyat3 & "")
            'frx.SetVariable("HD_PESIN_tl", "" & fiyat_gizle(FormatNumber(fiyat1, 2)).ToString & "")
            'frx.SetVariable("HD_ALTIAY_tl", "" & fiyat_gizle_tl(FormatNumber(fiyat2, 2)).ToString & "")
            'frx.SetVariable("HD_ONAY_tl", "" & fiyat_gizle_tl(FormatNumber(fiyat3, 2)).ToString & "")
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT '" & dteTarih & "' as dteTarih,'" & sFisTipi & "' as sFisTipi,'" & lFisNo & "' as lFisNo," & MusteriNo & " as nMusteriID,'" & MusteriKodu & "' as lKodu,'" & Musteri & "' as Musteri," & StokNo & " as StokNo,'" & StokKodu & "' as StokKodu,'" & Malincinsi & "' as Malincinsi,'" & barkod & "' as sBarkod,'" & liste & "' as Liste ")
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_hareket.DataBase = qr_connection
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
            args(2) = "" & sorgu_query("set transaction isolation level read uncommitted SELECT '" & dteTarih & "' as dteTarih,'" & sFisTipi & "' as sFisTipi,'" & lFisNo & "' as lFisNo," & MusteriNo & " as nMusteriID,'" & MusteriKodu & "' as lKodu,'" & Musteri & "' as Musteri," & StokNo & " as StokNo,'" & StokKodu & "' as StokKodu,'" & Malincinsi & "' as Malincinsi,'" & barkod & "' as sBarkod,'" & liste & "' as Liste ") & ""
            args(3) = "qr_hareket"
            args(4) = "" & status.ToString() & ""
            args(5) = "2"
            args(6) = "FIRMANO"
            args(7) = "" & firmano.ToString() & ""
            args(8) = "DONEMNO"
            args(9) = "" & donemno.ToString() & ""
            processYol = args(0)
            For i As Integer = 1 To 9
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
                Dim sInfo As New ProcessStartInfo(Directory.GetCurrentDirectory() & "\RaporServis.exe ", """" & yeniYol.ToString() & """")
                Process.Start(sInfo)
            Else
                MessageBox.Show("Lütfen 'RaporServis.exe' eklentisini uygulama dizinine kopyalayýn.")
            End If
        End If
        StokNo = Nothing
        satir_line = Nothing
    End Sub
    Private Sub yazdir_direkt(ByVal status As Integer)
        Dim file As String
        OpenFileDialog1.Filter = "EtiketDosyalarý(musteri_*.fr3) |musteri_*.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket\musteri_hediye.fr3"
        OpenFileDialog1.FileName = "c:\Formlar\Etiket\musteri_hediye.fr3"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            Dim dr1 As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            report_create_stok(file, " WHERE stok.nStokId =" & dr1("nStokID") & "", status, 1, dr1("dteTarih"), dr1("fisTipi"), dr1("lNo"), dr1("nMusteriID"), dr1("lKodu"), dr1("sMusteriAdi"), dr1("nStokID"), dr1("sKodu"), dr1("sStokAciklama"), dr1("sBarkod"), Microsoft.VisualBasic.Left(dr1("sYaziIle"), 10))
            dr1 = Nothing
        End If
        file = Nothing
        GridControl1.Focus()
        GridControl1.Select()
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
    Private Sub btn_etiket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_etiket.Click
        yazdir_direkt(1)
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        yazdir_direkt(3)
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        yazdir_direkt(0)
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        yazdir_direkt(2)
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        yazdir_direkt(1)
    End Sub
    Private Sub txt_ara_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ara.KeyDown
        If e.KeyCode = Keys.F6 Then
            Dim deger = ""
            deger = InputBox("MüþteriNumarasýný Okutun", "MüþteriKartOkut", "").ToString
            If deger.ToString <> "" Then
                txt_ara.Text = CType(Microsoft.VisualBasic.Left(deger, Len(deger) - 1), Decimal)
            End If
        End If
    End Sub
    Private Sub sec_depo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_satic.QueryPopUp
        'sec_satic.Properties.PopupControl = sec_grid
        'GridControl2.DataSource = ds_satici.Tables(0)
        'GridControl2.DataMember = Nothing
        sec_depo.Properties.PopupControl = Nothing
        sec_satic.Properties.PopupControl = sec_grid
        GridControl2.DataSource = ds_satici.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_depo_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_satic.QueryResultValue
        Dim s As String = deger(ds_satici)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        analiz_stok_karti()
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        stok_fiyat()
    End Sub
    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        If MenuItem31.Checked = False Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowAutoFilterRow = True
            MenuItem31.Checked = True
        ElseIf MenuItem31.Checked = True Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowAutoFilterRow = False
            MenuItem31.Checked = False
        End If
    End Sub
    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        DateEdit1.Focus()
        DateEdit1.SelectAll()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        analiz_stok_karti()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        stok_fiyat()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_musteri_karti()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        analiz_musteri_satislar()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        analiz_acik_faturalar()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        raporla_pdf()
    End Sub
    Private Sub sec_depo_QueryPopUp1(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_depo.QueryPopUp
        sec_satic.Properties.PopupControl = Nothing
        sec_depo.Properties.PopupControl = sec_grid
        GridControl2.DataSource = ds_magaza.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_depo_QueryResultValue1(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_depo.QueryResultValue
        Dim s As String = deger(ds_magaza)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        analiz_stok_KarlilikAkisTablosu()
    End Sub

    Private Sub sec_satic_EditValueChanged(sender As Object, e As EventArgs) Handles sec_satic.EditValueChanged

    End Sub

    Private Sub GridControl2_Click(sender As Object, e As EventArgs) Handles GridControl2.Click

    End Sub
End Class
