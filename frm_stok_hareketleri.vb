Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_stok_hareketleri
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
    Friend WithEvents DataSet1 As System.Data.DataSet
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
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
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
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents colsFisTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteFisTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collGirisFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collCikisFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collGirisMiktar1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collCikisMiktar1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizKuru1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBrutFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collIskontoTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKdvOrani As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnGirisCikis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnAlisverisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnMusteriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnFirmaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMAADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panelstatus As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bar2 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents barlabel2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents barlabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bar As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents colKALAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBrutTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_giris As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_firma As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents colnStokID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoksKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsModel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenkAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBeden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsStokAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAvYapanAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSaticiRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents colsDovizFiyati As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_sAciklama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_StokKodu As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents btn_Listele As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_sRenk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colISK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISK3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISK4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIskontoYuzdesi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_resmi1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_resmi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents collBrut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sDepo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colsHareketAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_hareketleri))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem1 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem2 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem5 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem6 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem7 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.sec_firma = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_giris = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_sDepo = New DevExpress.XtraEditors.LookUpEdit()
        Me.sec_resmi1 = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_resmi = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_sAciklama = New DevExpress.XtraEditors.LabelControl()
        Me.txt_StokKodu = New DevExpress.XtraEditors.ButtonEdit()
        Me.btn_Listele = New DevExpress.XtraEditors.SimpleButton()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.Panelstatus = New DevExpress.XtraEditors.PanelControl()
        Me.bar2 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.barlabel2 = New DevExpress.XtraEditors.LabelControl()
        Me.barlabel = New DevExpress.XtraEditors.LabelControl()
        Me.bar = New DevExpress.XtraEditors.ProgressBarControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
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
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsFisTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFisNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteFisTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collGirisFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collCikisFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collGirisMiktar1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collCikisMiktar1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizKuru1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDovizCinsi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBrutFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collIskontoTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKdvOrani = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnGirisCikis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnAlisverisID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnMusteriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnFirmaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRMAADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKALAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBrutTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStokID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStoksKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsModel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenkAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sRenk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsStokAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAvYapanAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSaticiRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDovizFiyati = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDovizTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISK1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISK2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISK3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISK4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIskontoYuzdesi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBrut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsHareketAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar4 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.sec_firma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_giris.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.sec_sDepo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_resmi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_resmi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_StokKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelstatus.SuspendLayout()
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sRenk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
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
        Me.PanelControl1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Stok Hareketleri Aþaðýdadýr..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.sec_firma)
        Me.PanelControl2.Controls.Add(Me.sec_giris)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 359)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'sec_firma
        '
        Me.sec_firma.EditValue = True
        Me.sec_firma.Location = New System.Drawing.Point(111, 16)
        Me.sec_firma.Name = "sec_firma"
        Me.sec_firma.Properties.Caption = "Seçili Firma"
        Me.sec_firma.Size = New System.Drawing.Size(75, 19)
        ToolTipTitleItem1.Text = "Seçili Firma Kutucuðu"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Kutucuk Ýþaretli olduðu zaman Ýþlem Gören Hesap ile ilgili Stok Hareketlerini Lis" & _
    "teler"
        ToolTipTitleItem2.LeftIndent = 6
        ToolTipTitleItem2.Text = "F5"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        SuperToolTip1.Items.Add(ToolTipSeparatorItem1)
        SuperToolTip1.Items.Add(ToolTipTitleItem2)
        Me.sec_firma.SuperTip = SuperToolTip1
        Me.sec_firma.TabIndex = 8
        '
        'sec_giris
        '
        Me.sec_giris.EditValue = "Çýkýþlar"
        Me.sec_giris.Location = New System.Drawing.Point(16, 16)
        Me.sec_giris.Name = "sec_giris"
        Me.sec_giris.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_giris.Properties.Appearance.Options.UseFont = True
        Me.sec_giris.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_giris.Properties.Items.AddRange(New Object() {"[Tümü]", "Giriþler", "Çýkýþlar"})
        Me.sec_giris.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_giris.Size = New System.Drawing.Size(88, 20)
        ToolTipTitleItem3.Text = "Ýþlem Tipi"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "[Tümü]:Transfer iþlemleri hariç tüm giriþ çýkýþ hareketlerini listeler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Giriþler " & _
    ":Sadece Stok Giriþ iþlemleri listelenir." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Çýkýþlar: Sadece Stok Çýkýþ Ýþlemleri " & _
    "listelenir."
        SuperToolTip2.Items.Add(ToolTipTitleItem3)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.sec_giris.SuperTip = SuperToolTip2
        Me.sec_giris.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(192, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(738, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(663, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.LabelControl5)
        Me.PanelControl3.Controls.Add(Me.sec_sDepo)
        Me.PanelControl3.Controls.Add(Me.sec_resmi1)
        Me.PanelControl3.Controls.Add(Me.sec_resmi)
        Me.PanelControl3.Controls.Add(Me.LabelControl2)
        Me.PanelControl3.Controls.Add(Me.LabelControl1)
        Me.PanelControl3.Controls.Add(Me.lbl_sAciklama)
        Me.PanelControl3.Controls.Add(Me.txt_StokKodu)
        Me.PanelControl3.Controls.Add(Me.btn_Listele)
        Me.PanelControl3.Controls.Add(Me.DateEdit2)
        Me.PanelControl3.Controls.Add(Me.DateEdit1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 92)
        Me.PanelControl3.TabIndex = 0
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Location = New System.Drawing.Point(15, 43)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(65, 20)
        Me.LabelControl5.TabIndex = 60
        Me.LabelControl5.Text = "Depo:"
        '
        'sec_sDepo
        '
        Me.sec_sDepo.EnterMoveNextControl = True
        Me.sec_sDepo.Location = New System.Drawing.Point(82, 43)
        Me.sec_sDepo.Name = "sec_sDepo"
        Me.sec_sDepo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.sec_sDepo.Properties.Appearance.Options.UseBackColor = True
        Me.sec_sDepo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sDepo.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sDepo.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_sDepo.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_sDepo.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_sDepo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sDepo.Properties.DisplayMember = "sDepo"
        Me.sec_sDepo.Properties.NullText = "[Depo]"
        Me.sec_sDepo.Properties.ValueMember = "sDepo"
        Me.sec_sDepo.Size = New System.Drawing.Size(207, 20)
        Me.sec_sDepo.TabIndex = 59
        '
        'sec_resmi1
        '
        Me.sec_resmi1.Enabled = False
        Me.sec_resmi1.Location = New System.Drawing.Point(336, 23)
        Me.sec_resmi1.Name = "sec_resmi1"
        Me.sec_resmi1.Properties.Caption = "R1"
        Me.sec_resmi1.Size = New System.Drawing.Size(48, 19)
        Me.sec_resmi1.TabIndex = 58
        '
        'sec_resmi
        '
        Me.sec_resmi.Location = New System.Drawing.Point(298, 23)
        Me.sec_resmi.Name = "sec_resmi"
        Me.sec_resmi.Properties.Caption = "R"
        Me.sec_resmi.Size = New System.Drawing.Size(32, 19)
        Me.sec_resmi.TabIndex = 57
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(0, 23)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(80, 20)
        Me.LabelControl2.TabIndex = 26
        Me.LabelControl2.Text = "Tarih:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(0, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(80, 20)
        Me.LabelControl1.TabIndex = 25
        Me.LabelControl1.Text = "StokKodu:"
        '
        'lbl_sAciklama
        '
        Me.lbl_sAciklama.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_sAciklama.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_sAciklama.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_sAciklama.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_sAciklama.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_sAciklama.Location = New System.Drawing.Point(295, 3)
        Me.lbl_sAciklama.Name = "lbl_sAciklama"
        Me.lbl_sAciklama.Size = New System.Drawing.Size(243, 20)
        Me.lbl_sAciklama.TabIndex = 24
        Me.lbl_sAciklama.Text = "*"
        '
        'txt_StokKodu
        '
        Me.txt_StokKodu.EnterMoveNextControl = True
        Me.txt_StokKodu.Location = New System.Drawing.Point(82, 3)
        Me.txt_StokKodu.Name = "txt_StokKodu"
        Me.txt_StokKodu.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_StokKodu.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_StokKodu.Properties.Appearance.Options.UseBackColor = True
        Me.txt_StokKodu.Properties.Appearance.Options.UseForeColor = True
        Me.txt_StokKodu.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_StokKodu.Size = New System.Drawing.Size(207, 20)
        Me.txt_StokKodu.TabIndex = 20
        '
        'btn_Listele
        '
        Me.btn_Listele.Image = Global.business_smart.My.Resources.Resources.find
        Me.btn_Listele.Location = New System.Drawing.Point(82, 63)
        Me.btn_Listele.Name = "btn_Listele"
        Me.btn_Listele.Size = New System.Drawing.Size(207, 23)
        Me.btn_Listele.TabIndex = 23
        Me.btn_Listele.Text = "Ara"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(189, 23)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit2.TabIndex = 22
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = New Date(2018, 1, 1, 0, 0, 0, 0)
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(82, 23)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit1.TabIndex = 21
        '
        'Panelstatus
        '
        Me.Panelstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panelstatus.Appearance.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panelstatus.Appearance.Options.UseBackColor = True
        Me.Panelstatus.Controls.Add(Me.bar2)
        Me.Panelstatus.Controls.Add(Me.barlabel2)
        Me.Panelstatus.Controls.Add(Me.barlabel)
        Me.Panelstatus.Controls.Add(Me.bar)
        Me.Panelstatus.Location = New System.Drawing.Point(135, 42)
        Me.Panelstatus.Name = "Panelstatus"
        Me.Panelstatus.Size = New System.Drawing.Size(535, 108)
        Me.Panelstatus.TabIndex = 12
        Me.Panelstatus.Visible = False
        '
        'bar2
        '
        Me.bar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar2.Location = New System.Drawing.Point(8, 73)
        Me.bar2.Name = "bar2"
        Me.bar2.Properties.ShowTitle = True
        Me.bar2.Size = New System.Drawing.Size(511, 18)
        Me.bar2.TabIndex = 3
        '
        'barlabel2
        '
        Me.barlabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barlabel2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.barlabel2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.barlabel2.Location = New System.Drawing.Point(8, 50)
        Me.barlabel2.Name = "barlabel2"
        Me.barlabel2.Size = New System.Drawing.Size(53, 13)
        Me.barlabel2.TabIndex = 2
        Me.barlabel2.Text = "barlabel2"
        '
        'barlabel
        '
        Me.barlabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barlabel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.barlabel.Appearance.ForeColor = System.Drawing.Color.Black
        Me.barlabel.Location = New System.Drawing.Point(8, 4)
        Me.barlabel.Name = "barlabel"
        Me.barlabel.Size = New System.Drawing.Size(46, 13)
        Me.barlabel.TabIndex = 1
        Me.barlabel.Text = "barlabel"
        '
        'bar
        '
        Me.bar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar.Location = New System.Drawing.Point(8, 23)
        Me.bar.Name = "bar"
        Me.bar.Properties.ShowTitle = True
        Me.bar.Size = New System.Drawing.Size(511, 18)
        Me.bar.TabIndex = 0
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
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sRenk})
        Me.GridControl1.Size = New System.Drawing.Size(820, 207)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem27, Me.MenuItem19, Me.MenuItem18, Me.MenuItem16, Me.MenuItem22, Me.MenuItem17, Me.MenuItem20, Me.MenuItem28, Me.MenuItem15, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem23, Me.MenuItem21, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
        '
        'MenuItem13
        '
        Me.MenuItem13.DefaultItem = True
        Me.MenuItem13.Index = 0
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem13.Text = "Tamam"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 1
        Me.MenuItem14.Text = "Vazgeç"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 2
        Me.MenuItem27.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem27.Text = "Ara"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 3
        Me.MenuItem19.Text = "-"
        '
        'MenuItem18
        '
        Me.MenuItem18.Enabled = False
        Me.MenuItem18.Index = 4
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem18.Text = "Envanter"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 5
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem16.Text = "Faturayý Göster"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 6
        Me.MenuItem22.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem22.Text = "Kapatma Detayý"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 7
        Me.MenuItem17.Text = "Alýþý Göster"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 8
        Me.MenuItem20.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.MenuItem20.Text = "Tüm Firma Kayýtlarýný Göster"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 9
        Me.MenuItem28.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItem28.Text = "Karlýlýk Akýþ Tablosu"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 10
        Me.MenuItem15.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 11
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 12
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 13
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 14
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 15
        Me.MenuItem10.Text = "-"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 16
        Me.MenuItem23.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem24, Me.MenuItem25, Me.MenuItem26})
        Me.MenuItem23.Text = "Raporla"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 0
        Me.MenuItem24.Text = "Önizle"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 1
        Me.MenuItem25.Text = "Dizayn"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 2
        Me.MenuItem26.Text = "Yazdýr"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 17
        Me.MenuItem21.Text = "Hýzlý Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 18
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 19
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 20
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 21
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 22
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 23
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 24
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "sFisTipi"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sAciklama"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "lFisNo"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "dteFisTarihi"
        Me.DataColumn4.DataType = GetType(Date)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "lGirisFiyat"
        Me.DataColumn5.DataType = GetType(Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "lCikisFiyat"
        Me.DataColumn6.DataType = GetType(Decimal)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "lGirisMiktar1"
        Me.DataColumn7.DataType = GetType(Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "lCikisMiktar1"
        Me.DataColumn8.DataType = GetType(Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "lDovizKuru1"
        Me.DataColumn9.DataType = GetType(Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "sDovizCinsi1"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "lBrutFiyat"
        Me.DataColumn11.DataType = GetType(Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "lIskontoTutari"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "nKdvOrani"
        Me.DataColumn13.DataType = GetType(Long)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "nGirisCikis"
        Me.DataColumn14.DataType = GetType(Long)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sDepo"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "nAlisverisID"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "nMusteriID"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "nFirmaID"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "lKodu"
        Me.DataColumn19.DataType = GetType(System.TimeSpan)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "FIRMAADI"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "sKodu"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "FIRMA"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsFisTipi, Me.colsAciklama, Me.collFisNo, Me.coldteFisTarihi, Me.collGirisFiyat, Me.collCikisFiyat, Me.collGirisMiktar1, Me.collCikisMiktar1, Me.collDovizKuru1, Me.colsDovizCinsi1, Me.collBrutFiyat, Me.collIskontoTutari, Me.colnKdvOrani, Me.colnGirisCikis, Me.colsDepo, Me.colnAlisverisID, Me.colnMusteriID, Me.colnFirmaID, Me.collKodu, Me.colFIRMAADI, Me.colsKodu, Me.colFIRMA, Me.colKALAN, Me.collBrutTutar, Me.colnStokID, Me.colStoksKodu, Me.colsModel, Me.colsRenkAdi, Me.colsBeden, Me.colsStokAciklama, Me.colsAvYapanAdi, Me.colsSaticiRumuzu, Me.colsDovizFiyati, Me.colsDovizTutari, Me.colsRenk, Me.colISK1, Me.colISK2, Me.colISK3, Me.colISK4, Me.colnIskontoYuzdesi, Me.collBrut, Me.colsHareketAciklama})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(616, 313, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBrutTutar", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGirisMiktar1", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lCikisMiktar1", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteFisTarihi", Nothing, "{0} Kayýt")})
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
        'colsFisTipi
        '
        Me.colsFisTipi.Caption = "FisTipi"
        Me.colsFisTipi.FieldName = "sFisTipi"
        Me.colsFisTipi.Name = "colsFisTipi"
        Me.colsFisTipi.Visible = True
        Me.colsFisTipi.VisibleIndex = 3
        Me.colsFisTipi.Width = 44
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Fiþ Açýklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Width = 44
        '
        'collFisNo
        '
        Me.collFisNo.Caption = "Fiþ No"
        Me.collFisNo.FieldName = "lFisNo"
        Me.collFisNo.Name = "collFisNo"
        Me.collFisNo.Visible = True
        Me.collFisNo.VisibleIndex = 4
        Me.collFisNo.Width = 44
        '
        'coldteFisTarihi
        '
        Me.coldteFisTarihi.Caption = "Tarih"
        Me.coldteFisTarihi.FieldName = "dteFisTarihi"
        Me.coldteFisTarihi.Name = "coldteFisTarihi"
        Me.coldteFisTarihi.Visible = True
        Me.coldteFisTarihi.VisibleIndex = 2
        Me.coldteFisTarihi.Width = 65
        '
        'collGirisFiyat
        '
        Me.collGirisFiyat.Caption = "Giriþ Fiyat"
        Me.collGirisFiyat.DisplayFormat.FormatString = "#,0.00#"
        Me.collGirisFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGirisFiyat.FieldName = "lGirisFiyat"
        Me.collGirisFiyat.Name = "collGirisFiyat"
        '
        'collCikisFiyat
        '
        Me.collCikisFiyat.Caption = "Çýkýþ Fiyatý"
        Me.collCikisFiyat.DisplayFormat.FormatString = "#,0.00#"
        Me.collCikisFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collCikisFiyat.FieldName = "lCikisFiyat"
        Me.collCikisFiyat.Name = "collCikisFiyat"
        '
        'collGirisMiktar1
        '
        Me.collGirisMiktar1.Caption = "Giren"
        Me.collGirisMiktar1.DisplayFormat.FormatString = "#,0.###"
        Me.collGirisMiktar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGirisMiktar1.FieldName = "lGirisMiktar1"
        Me.collGirisMiktar1.Name = "collGirisMiktar1"
        Me.collGirisMiktar1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGirisMiktar1", "{0:#,0.##}")})
        Me.collGirisMiktar1.Visible = True
        Me.collGirisMiktar1.VisibleIndex = 5
        Me.collGirisMiktar1.Width = 44
        '
        'collCikisMiktar1
        '
        Me.collCikisMiktar1.Caption = "Çýkan"
        Me.collCikisMiktar1.DisplayFormat.FormatString = "#,0.###"
        Me.collCikisMiktar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collCikisMiktar1.FieldName = "lCikisMiktar1"
        Me.collCikisMiktar1.Name = "collCikisMiktar1"
        Me.collCikisMiktar1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lCikisMiktar1", "{0:#,0.##}")})
        Me.collCikisMiktar1.Visible = True
        Me.collCikisMiktar1.VisibleIndex = 6
        Me.collCikisMiktar1.Width = 44
        '
        'collDovizKuru1
        '
        Me.collDovizKuru1.Caption = "Döviz Kuru"
        Me.collDovizKuru1.FieldName = "lDovizKuru1"
        Me.collDovizKuru1.Name = "collDovizKuru1"
        '
        'colsDovizCinsi1
        '
        Me.colsDovizCinsi1.Caption = "Pb"
        Me.colsDovizCinsi1.FieldName = "sDovizCinsi1"
        Me.colsDovizCinsi1.Name = "colsDovizCinsi1"
        '
        'collBrutFiyat
        '
        Me.collBrutFiyat.Caption = "Fiyat"
        Me.collBrutFiyat.DisplayFormat.FormatString = "#,0.00#"
        Me.collBrutFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutFiyat.FieldName = "lBrutFiyat"
        Me.collBrutFiyat.Name = "collBrutFiyat"
        Me.collBrutFiyat.Visible = True
        Me.collBrutFiyat.VisibleIndex = 8
        Me.collBrutFiyat.Width = 44
        '
        'collIskontoTutari
        '
        Me.collIskontoTutari.Caption = "Ýskonto"
        Me.collIskontoTutari.DisplayFormat.FormatString = "#,0.00"
        Me.collIskontoTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collIskontoTutari.FieldName = "lIskontoTutari"
        Me.collIskontoTutari.Name = "collIskontoTutari"
        Me.collIskontoTutari.Width = 55
        '
        'colnKdvOrani
        '
        Me.colnKdvOrani.Caption = "Kdv"
        Me.colnKdvOrani.DisplayFormat.FormatString = "#,0.##"
        Me.colnKdvOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnKdvOrani.FieldName = "nKdvOrani"
        Me.colnKdvOrani.Name = "colnKdvOrani"
        Me.colnKdvOrani.Width = 34
        '
        'colnGirisCikis
        '
        Me.colnGirisCikis.Caption = "Giriþ/Çýkýþ"
        Me.colnGirisCikis.FieldName = "nGirisCikis"
        Me.colnGirisCikis.Name = "colnGirisCikis"
        Me.colnGirisCikis.Width = 44
        '
        'colsDepo
        '
        Me.colsDepo.Caption = "Depo"
        Me.colsDepo.FieldName = "sDepo"
        Me.colsDepo.Name = "colsDepo"
        Me.colsDepo.Visible = True
        Me.colsDepo.VisibleIndex = 10
        Me.colsDepo.Width = 62
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
        'colnFirmaID
        '
        Me.colnFirmaID.Caption = "Firma No"
        Me.colnFirmaID.FieldName = "nFirmaID"
        Me.colnFirmaID.Name = "colnFirmaID"
        '
        'collKodu
        '
        Me.collKodu.Caption = "Hesap Kodu"
        Me.collKodu.FieldName = "HESAPKODU"
        Me.collKodu.Name = "collKodu"
        Me.collKodu.Visible = True
        Me.collKodu.VisibleIndex = 11
        Me.collKodu.Width = 62
        '
        'colFIRMAADI
        '
        Me.colFIRMAADI.Caption = "HesapAdý"
        Me.colFIRMAADI.FieldName = "HESAPADI"
        Me.colFIRMAADI.Name = "colFIRMAADI"
        Me.colFIRMAADI.Visible = True
        Me.colFIRMAADI.VisibleIndex = 12
        Me.colFIRMAADI.Width = 101
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        '
        'colFIRMA
        '
        Me.colFIRMA.Caption = "Firma"
        Me.colFIRMA.FieldName = "FIRMA"
        Me.colFIRMA.Name = "colFIRMA"
        '
        'colKALAN
        '
        Me.colKALAN.Caption = "Kalan"
        Me.colKALAN.DisplayFormat.FormatString = "#,0.####"
        Me.colKALAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKALAN.FieldName = "KALAN"
        Me.colKALAN.Name = "colKALAN"
        Me.colKALAN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "KALAN", "{0:#,0.####}")})
        Me.colKALAN.Visible = True
        Me.colKALAN.VisibleIndex = 7
        Me.colKALAN.Width = 44
        '
        'collBrutTutar
        '
        Me.collBrutTutar.Caption = "BrutTutar"
        Me.collBrutTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collBrutTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutTutar.FieldName = "lBrutTutar"
        Me.collBrutTutar.Name = "collBrutTutar"
        Me.collBrutTutar.Visible = True
        Me.collBrutTutar.VisibleIndex = 9
        Me.collBrutTutar.Width = 42
        '
        'colnStokID
        '
        Me.colnStokID.Caption = "Stok No"
        Me.colnStokID.FieldName = "nStokID"
        Me.colnStokID.Name = "colnStokID"
        '
        'colStoksKodu
        '
        Me.colStoksKodu.Caption = "Stok Kodu"
        Me.colStoksKodu.FieldName = "sStokKodu"
        Me.colStoksKodu.Name = "colStoksKodu"
        Me.colStoksKodu.Visible = True
        Me.colStoksKodu.VisibleIndex = 0
        Me.colStoksKodu.Width = 70
        '
        'colsModel
        '
        Me.colsModel.Caption = "Model"
        Me.colsModel.FieldName = "sModel"
        Me.colsModel.Name = "colsModel"
        '
        'colsRenkAdi
        '
        Me.colsRenkAdi.Caption = "RenkAdi"
        Me.colsRenkAdi.ColumnEdit = Me.sec_sRenk
        Me.colsRenkAdi.FieldName = "sRenk"
        Me.colsRenkAdi.Name = "colsRenkAdi"
        '
        'sec_sRenk
        '
        Me.sec_sRenk.AutoHeight = False
        Me.sec_sRenk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sRenk.DisplayMember = "sRenkAdi"
        Me.sec_sRenk.Name = "sec_sRenk"
        Me.sec_sRenk.NullText = ""
        Me.sec_sRenk.ValueMember = "sRenk"
        '
        'colsBeden
        '
        Me.colsBeden.Caption = "Beden"
        Me.colsBeden.FieldName = "sBeden"
        Me.colsBeden.Name = "colsBeden"
        '
        'colsStokAciklama
        '
        Me.colsStokAciklama.Caption = "Stok Adý"
        Me.colsStokAciklama.FieldName = "sStokAciklama"
        Me.colsStokAciklama.Name = "colsStokAciklama"
        Me.colsStokAciklama.Visible = True
        Me.colsStokAciklama.VisibleIndex = 1
        Me.colsStokAciklama.Width = 95
        '
        'colsAvYapanAdi
        '
        Me.colsAvYapanAdi.Caption = "Av.Yapan"
        Me.colsAvYapanAdi.FieldName = "sAvYapanAdi"
        Me.colsAvYapanAdi.Name = "colsAvYapanAdi"
        '
        'colsSaticiRumuzu
        '
        Me.colsSaticiRumuzu.Caption = "Satici"
        Me.colsSaticiRumuzu.FieldName = "sSaticiRumuzu"
        Me.colsSaticiRumuzu.Name = "colsSaticiRumuzu"
        '
        'colsDovizFiyati
        '
        Me.colsDovizFiyati.Caption = "Döviz Fiyatý"
        Me.colsDovizFiyati.DisplayFormat.FormatString = "#,0.00##"
        Me.colsDovizFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colsDovizFiyati.FieldName = "lDovizFiyati"
        Me.colsDovizFiyati.Name = "colsDovizFiyati"
        '
        'colsDovizTutari
        '
        Me.colsDovizTutari.Caption = "Döviz Tutar"
        Me.colsDovizTutari.DisplayFormat.FormatString = "#,0.00##"
        Me.colsDovizTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colsDovizTutari.FieldName = "lDovizTutari"
        Me.colsDovizTutari.Name = "colsDovizTutari"
        '
        'colsRenk
        '
        Me.colsRenk.Caption = "Renk"
        Me.colsRenk.FieldName = "sRenk"
        Me.colsRenk.Name = "colsRenk"
        '
        'colISK1
        '
        Me.colISK1.Caption = "%Isk1"
        Me.colISK1.DisplayFormat.FormatString = "#,0.##"
        Me.colISK1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISK1.FieldName = "ISK1"
        Me.colISK1.Name = "colISK1"
        '
        'colISK2
        '
        Me.colISK2.Caption = "%Isk2"
        Me.colISK2.DisplayFormat.FormatString = "#,0.##"
        Me.colISK2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISK2.FieldName = "ISK2"
        Me.colISK2.Name = "colISK2"
        '
        'colISK3
        '
        Me.colISK3.Caption = "%Isk3"
        Me.colISK3.DisplayFormat.FormatString = "#,0.##"
        Me.colISK3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISK3.FieldName = "ISK3"
        Me.colISK3.Name = "colISK3"
        '
        'colISK4
        '
        Me.colISK4.Caption = "%Isk4"
        Me.colISK4.DisplayFormat.FormatString = "#,0.##"
        Me.colISK4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISK4.FieldName = "ISK4"
        Me.colISK4.Name = "colISK4"
        '
        'colnIskontoYuzdesi
        '
        Me.colnIskontoYuzdesi.Caption = "%Isk"
        Me.colnIskontoYuzdesi.DisplayFormat.FormatString = "#,0.##"
        Me.colnIskontoYuzdesi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnIskontoYuzdesi.FieldName = "nIskontoYuzdesi"
        Me.colnIskontoYuzdesi.Name = "colnIskontoYuzdesi"
        '
        'collBrut
        '
        Me.collBrut.Caption = "BrutFiyat"
        Me.collBrut.DisplayFormat.FormatString = "#,0.00##"
        Me.collBrut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrut.FieldName = "lBrut"
        Me.collBrut.Name = "collBrut"
        '
        'colsHareketAciklama
        '
        Me.colsHareketAciklama.Caption = "AçýklamaHareket"
        Me.colsHareketAciklama.FieldName = "sHareketAciklama"
        Me.colsHareketAciklama.Name = "colsHareketAciklama"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Stok Hareketleri", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Stok Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar4})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6})
        Me.BarManager1.MaxItemId = 6
        Me.BarManager1.StatusBar = Me.Bar4
        '
        'Bar4
        '
        Me.Bar4.BarName = "Status bar"
        Me.Bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar4.DockCol = 0
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True)})
        Me.Bar4.OptionsBar.AllowQuickCustomization = False
        Me.Bar4.OptionsBar.DrawDragBorder = False
        Me.Bar4.OptionsBar.UseWholeRow = True
        Me.Bar4.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        ToolTipTitleItem4.Text = "Yazdýr"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Ekranda listelen Bilgileri Yazýcýdan çýktý almanýza yardýmcý olur."
        ToolTipTitleItem5.LeftIndent = 6
        ToolTipTitleItem5.Text = "Ctrl+P"
        SuperToolTip3.Items.Add(ToolTipTitleItem4)
        SuperToolTip3.Items.Add(ToolTipItem3)
        SuperToolTip3.Items.Add(ToolTipSeparatorItem2)
        SuperToolTip3.Items.Add(ToolTipTitleItem5)
        Me.BarButtonItem1.SuperTip = SuperToolTip3
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Karlýlýk Akýþ Tablosu"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z))
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "E&xcel"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        ToolTipTitleItem6.Text = "Excel"
        ToolTipItem4.LeftIndent = 6
        ToolTipItem4.Text = "Ekranda listelenen veriyi Microsoft Excel Dosyasý olarak kaydedip incelemenize ya" & _
    "rdýmcý olur."
        SuperToolTip4.Items.Add(ToolTipTitleItem6)
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.BarButtonItem2.SuperTip = SuperToolTip4
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "T&ext"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        ToolTipTitleItem7.Text = "Text"
        ToolTipItem5.LeftIndent = 6
        ToolTipItem5.Text = "Ekranda listelenen veriyi Text Döküman olarak kaydetmenize ve düzenlemenize yardý" & _
    "mcý olur."
        SuperToolTip5.Items.Add(ToolTipTitleItem7)
        SuperToolTip5.Items.Add(ToolTipItem5)
        Me.BarButtonItem3.SuperTip = SuperToolTip5
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "&Mail"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "(R)"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
        Me.BarButtonItem6.Name = "BarButtonItem6"
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
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.Panelstatus)
        Me.PanelControl4.Controls.Add(Me.GridControl1)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl4.Location = New System.Drawing.Point(0, 148)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(824, 211)
        Me.PanelControl4.TabIndex = 8
        '
        'frm_stok_hareketleri
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_hareketleri"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Hareketleri"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.sec_firma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_giris.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.sec_sDepo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_resmi1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_resmi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_StokKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelstatus.ResumeLayout(False)
        Me.Panelstatus.PerformLayout()
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sRenk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public connection_orj
    Public connection_resmi
    Public connection_resmi1
    Public musterino
    Public nMusteriID As Int64 = 0
    Public nFirmaID As Int64 = 0
    Public sModel As String = ""
    Public kullanici
    Public rStokCari As Boolean = False
    Public islemstatus As Boolean = False
    Public bPerakende As Boolean = False
    Public bRapor As Boolean = False
    Dim ds_tbDepo As DataSet
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection_orj = connection
        connection_resmi = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("ugurlu_resmi")
        connection_resmi1 = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("ugurlu_resmi1")
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        txt_StokKodu.Text = musterino
        lbl_sAciklama.Text = "*"
        If bRapor = False Then
            DateEdit1.EditValue = "01/01/2018"
            DateEdit2.EditValue = "31/12/2078"
        End If
        dataload_renk()
        dataload_tbdepo()
        dataload()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
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
        Me.Close()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
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
        Dim itm
        For Each itm In ContextMenu1.MenuItems
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
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
    Public Function stok(ByVal musterino As String, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime) As DataSet
        Dim kriter
        Dim sDetay As String = ""
        kriter = "WHERE (stok.skodu is not null ) "
        Dim kriter2 As String = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If Trim(sec_sDepo.EditValue) = "" Then
            kriter2 += " and (tbStokFisiDetayi.sFisTipi <> 'T') "
        Else
            kriter2 += " and (tbStokFisiDetayi.sDepo IN ('" & sec_sDepo.EditValue & "')) "
        End If
        If sec_giris.Text = "[Tümü]" Then
            kriter2 += " and tbStokFisiDetayi.dteFisTarihi between '" & tarih1 & "' and '" & tarih2 & "' "
        ElseIf sec_giris.Text = "Giriþler" Then
            kriter2 += "  and tbStokFisiDetayi.dteFisTarihi between '" & tarih1 & "' and '" & tarih2 & "' AND (tbStokFisiDetayi.nGirisCikis IN(1,4,2))"
        ElseIf sec_giris.Text = "Çýkýþlar" Then
            kriter2 += " and tbStokFisiDetayi.dteFisTarihi between '" & tarih1 & "' and '" & tarih2 & "' AND (tbStokFisiDetayi.nGirisCikis IN(3,4,2))"
        ElseIf sec_giris.Text = "Teslimatlar" Then
            kriter2 += " and tbStokFisiDetayi.dteFisTarihi between '" & tarih1 & "' and '" & tarih2 & "' AND (tbStokFisiDetayi.sFisTipi ='PF')"
        End If
        'If islemstatus = True And bPerakende = False Then
        'sDetay = " CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4 , "
        sDetay = " CASE WHEN ISNUMERIC(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5)) = 1 THEN CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) ELSE 0 END AS ISK1, CASE WHEN ISNUMERIC(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5)) = 1 THEN CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) ELSE 0 END AS ISK2, CASE WHEN ISNUMERIC(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5)) = 1 THEN CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) ELSE 0 END AS ISK3, CASE WHEN ISNUMERIC(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5)) = 1 THEN CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) ELSE 0 END AS ISK4, "
        'Else
        'sDetay = ""
        'sDetay = " CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4 , "
        'End If
        Dim sFirma As String = ""
        If bPerakende = True Then
            sFirma = " tbStokFisiDetayi.nMusteriID =" & nFirmaID & " "
        Else
            sFirma = " tbStokFisiDetayi.nFirmaID =" & nFirmaID & " "
        End If
        If rStokCari = False Then
            If sec_firma.Checked = True Then
                If nFirmaID > 0 Then
                    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.nStokID,tbStok.sKodu as sStokKodu,tbStok.sAciklama as sStokAciklama,tbStok.sModel,tbStok.sRenk,tbStok.sBeden,tbFisTipi.sFisTipi, tbFisTipi.sAciklama, tbStokFisiDetayi. nIslemID,tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lCikisFiyat, " & sDetay & " tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.lCikisMiktar1, tbStokFisiDetayi.lDovizKuru1, tbStokFisiDetayi.sDovizCinsi1, tbStokFisiDetayi.lBrutFiyat,tbStokFisiDetayi.lBrutFiyat as lDovizFiyati,tbStokFisiDetayi.lBrutTutar as lDovizTutari,tbStokFisiDetayi.lBrutFiyat as lBrut, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.nIskontoYuzdesi,tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.nKdvOrani,tbStokFisiDetayi.lMaliyetFiyat, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sAciklama as sHareketAciklama,tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.nAlisverisID,tbStokFisiDetayi.nStokFisiID, tbStokFisiDetayi.nMusteriID, tbStokFisiDetayi.nFirmaID, tbMusteri.lKodu AS MUSTERIKODU, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS MUSTERIADI, tbFirma.sKodu AS FIRMAKODU, tbFirma.sAciklama AS FIRMAADI, '' AS HESAPKODU, '' AS HESAPADI, CAST(0 AS MONEY) AS KALAN,isnull(baslik.lToplamMiktar,0) AS FATURAMIKTARI, isnull(baslik.lMalBedeli - baslik.lMalIskontoTutari,0) AS FATURATUTARI, isnull(baslik.lEkmaliyet1,0) AS EKMALIYET,(SELECT sAlisVerisYapanAdi + ' ' + sAlisVerisYapanSoyadi FROM tbAlisVeris WHERE nAlisVerisID = tbStokFisiDetayi.nAlisVerisID) AS sAvYapanAdi FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiMaster baslik ON tbStokFisiDetayi.nStokFisiID = baslik.nStokFisiID LEFT OUTER JOIN tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID WHERE  (tbStok.sKodu = '" & musterino & "') AND " & sFirma & " " & kriter2 & " ORDER BY tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lFisNo")
                Else
                    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.nStokID,tbStok.sKodu as sStokKodu,tbStok.sAciklama as sStokAciklama,tbStok.sModel,tbStok.sRenk,tbStok.sBeden,tbFisTipi.sFisTipi, tbFisTipi.sAciklama, tbStokFisiDetayi. nIslemID,tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lCikisFiyat," & sDetay & " tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.lCikisMiktar1, tbStokFisiDetayi.lDovizKuru1, tbStokFisiDetayi.sDovizCinsi1, tbStokFisiDetayi.lBrutFiyat,tbStokFisiDetayi.lBrutFiyat as lDovizFiyati,tbStokFisiDetayi.lBrutTutar as lDovizTutari,tbStokFisiDetayi.lBrutFiyat as lBrut, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.nIskontoYuzdesi,tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.nKdvOrani,tbStokFisiDetayi.lMaliyetFiyat, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sAciklama sHareketAciklama,tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sFisTipi,tbStokFisiDetayi.nAlisverisID,tbStokFisiDetayi.nStokFisiID, tbStokFisiDetayi.nMusteriID, tbStokFisiDetayi.nFirmaID, tbMusteri.lKodu AS MUSTERIKODU, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS MUSTERIADI, tbFirma.sKodu AS FIRMAKODU, tbFirma.sAciklama AS FIRMAADI, '' AS HESAPKODU, '' AS HESAPADI, CAST(0 AS MONEY) AS KALAN,isnull(baslik.lToplamMiktar,0) AS FATURAMIKTARI, isnull(baslik.lMalBedeli - baslik.lMalIskontoTutari,0) AS FATURATUTARI, isnull(baslik.lEkmaliyet1,0) AS EKMALIYET,(SELECT sAlisVerisYapanAdi + ' ' + sAlisVerisYapanSoyadi FROM tbAlisVeris WHERE nAlisVerisID = tbStokFisiDetayi.nAlisVerisID) AS sAvYapanAdi FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiMaster baslik ON tbStokFisiDetayi.nStokFisiID = baslik.nStokFisiID LEFT OUTER JOIN tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID WHERE  (tbStok.sKodu = '" & musterino & "') " & kriter2 & " ORDER BY tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lFisNo")
                End If
            Else
                If sModel = "" Then
                    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.nStokID,tbStok.sKodu as sStokKodu,tbStok.sAciklama as sStokAciklama,tbStok.sModel,tbStok.sRenk,tbStok.sBeden,tbFisTipi.sFisTipi, tbFisTipi.sAciklama, tbStokFisiDetayi. nIslemID,tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lCikisFiyat, " & sDetay & " tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.lCikisMiktar1, tbStokFisiDetayi.lDovizKuru1, tbStokFisiDetayi.sDovizCinsi1, tbStokFisiDetayi.lBrutFiyat,tbStokFisiDetayi.lBrutFiyat as lDovizFiyati,tbStokFisiDetayi.lBrutTutar as lDovizTutari,tbStokFisiDetayi.lBrutFiyat as lBrut, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.nIskontoYuzdesi,tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.nKdvOrani,tbStokFisiDetayi.lMaliyetFiyat, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sAciklama sHareketAciklama,tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sFisTipi,tbStokFisiDetayi.nAlisverisID,tbStokFisiDetayi.nStokFisiID, tbStokFisiDetayi.nMusteriID, tbStokFisiDetayi.nFirmaID, tbMusteri.lKodu AS MUSTERIKODU, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS MUSTERIADI, tbFirma.sKodu AS FIRMAKODU, tbFirma.sAciklama AS FIRMAADI, '' AS HESAPKODU, '' AS HESAPADI, CAST(0 AS MONEY) AS KALAN,isnull(baslik.lToplamMiktar,0) AS FATURAMIKTARI, isnull(baslik.lMalBedeli - baslik.lMalIskontoTutari,0) AS FATURATUTARI, isnull(baslik.lEkmaliyet1,0) AS EKMALIYET,(SELECT sAlisVerisYapanAdi + ' ' + sAlisVerisYapanSoyadi FROM tbAlisVeris WHERE nAlisVerisID = tbStokFisiDetayi.nAlisVerisID) AS sAvYapanAdi FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiMaster baslik ON tbStokFisiDetayi.nStokFisiID = baslik.nStokFisiID LEFT OUTER JOIN tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID WHERE  (tbStok.sKodu = '" & musterino & "') " & kriter2 & " ORDER BY tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lFisNo")
                Else
                    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.nStokID,tbStok.sKodu as sStokKodu,tbStok.sAciklama as sStokAciklama,tbStok.sModel,tbStok.sRenk,tbStok.sBeden,tbFisTipi.sFisTipi, tbFisTipi.sAciklama, tbStokFisiDetayi. nIslemID,tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lCikisFiyat, " & sDetay & " tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.lCikisMiktar1, tbStokFisiDetayi.lDovizKuru1, tbStokFisiDetayi.sDovizCinsi1, tbStokFisiDetayi.lBrutFiyat,tbStokFisiDetayi.lBrutFiyat as lDovizFiyati,tbStokFisiDetayi.lBrutTutar as lDovizTutari,tbStokFisiDetayi.lBrutFiyat as lBrut,tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.nIskontoYuzdesi,tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.nKdvOrani,tbStokFisiDetayi.lMaliyetFiyat, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sAciklama sHareketAciklama,tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sFisTipi,tbStokFisiDetayi.nAlisverisID,tbStokFisiDetayi.nStokFisiID, tbStokFisiDetayi.nMusteriID, tbStokFisiDetayi.nFirmaID, tbMusteri.lKodu AS MUSTERIKODU, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS MUSTERIADI, tbFirma.sKodu AS FIRMAKODU, tbFirma.sAciklama AS FIRMAADI, '' AS HESAPKODU, '' AS HESAPADI, CAST(0 AS MONEY) AS KALAN,isnull(baslik.lToplamMiktar,0) AS FATURAMIKTARI, isnull(baslik.lMalBedeli - baslik.lMalIskontoTutari,0) AS FATURATUTARI, isnull(baslik.lEkmaliyet1,0) AS EKMALIYET,(SELECT sAlisVerisYapanAdi + ' ' + sAlisVerisYapanSoyadi FROM tbAlisVeris WHERE nAlisVerisID = tbStokFisiDetayi.nAlisVerisID) AS sAvYapanAdi FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiMaster baslik ON tbStokFisiDetayi.nStokFisiID = baslik.nStokFisiID LEFT OUTER JOIN tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID WHERE  (tbStok.sModel = '" & musterino & "') " & kriter2 & " ORDER BY tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lFisNo")
                End If
            End If
        ElseIf rStokCari = True Then
            If sec_firma.Checked = True Then
                If nFirmaID > 0 Then
                    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.nStokID,tbStok.sKodu as sStokKodu,tbStok.sAciklama as sStokAciklama,tbStok.sModel,tbStok.sRenk,tbStok.sBeden,tbFisTipi.sFisTipi, tbFisTipi.sAciklama, tbStokFisiDetayi. nIslemID,tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lCikisFiyat, " & sDetay & " tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.lCikisMiktar1, tbStokFisiDetayi.lDovizKuru1, tbStokFisiDetayi.sDovizCinsi1, tbStokFisiDetayi.lBrutFiyat,tbStokFisiDetayi.lBrutFiyat as lDovizFiyati,tbStokFisiDetayi.lBrutTutar as lDovizTutari,tbStokFisiDetayi.lBrutFiyat as lBrut, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.nIskontoYuzdesi,tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.nKdvOrani,tbStokFisiDetayi.lMaliyetFiyat, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sAciklama sHareketAciklama,tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.nAlisverisID,tbStokFisiDetayi.nStokFisiID, tbStokFisiDetayi.nMusteriID, tbStokFisiDetayi.nFirmaID, tbMusteri.lKodu AS MUSTERIKODU, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS MUSTERIADI, tbFirma.sKodu AS FIRMAKODU, tbFirma.sAciklama AS FIRMAADI, '' AS HESAPKODU, '' AS HESAPADI, CAST(0 AS MONEY) AS KALAN,isnull(baslik.lToplamMiktar,0) AS FATURAMIKTARI, isnull(baslik.lMalBedeli - baslik.lMalIskontoTutari,0) AS FATURATUTARI, isnull(baslik.lEkmaliyet1,0) AS EKMALIYET,(SELECT sAlisVerisYapanAdi + ' ' + sAlisVerisYapanSoyadi FROM tbAlisVeris WHERE nAlisVerisID = tbStokFisiDetayi.nAlisVerisID) AS sAvYapanAdi FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiMaster baslik ON tbStokFisiDetayi.nStokFisiID = baslik.nStokFisiID LEFT OUTER JOIN tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID WHERE  " & sFirma & " " & kriter2 & " ORDER BY tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lFisNo")
                Else
                    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.nStokID,tbStok.sKodu as sStokKodu,tbStok.sAciklama as sStokAciklama,tbStok.sModel,tbStok.sRenk,tbStok.sBeden,tbFisTipi.sFisTipi, tbFisTipi.sAciklama, tbStokFisiDetayi. nIslemID,tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lCikisFiyat," & sDetay & "  tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.lCikisMiktar1, tbStokFisiDetayi.lDovizKuru1, tbStokFisiDetayi.sDovizCinsi1, tbStokFisiDetayi.lBrutFiyat,tbStokFisiDetayi.lBrutFiyat as lDovizFiyati,tbStokFisiDetayi.lBrutTutar as lDovizTutari,tbStokFisiDetayi.lBrutFiyat as lBrut, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.nIskontoYuzdesi,tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.nKdvOrani,tbStokFisiDetayi.lMaliyetFiyat, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sAciklama sHareketAciklama,tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sSaticiRumuzu,tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.nAlisverisID,tbStokFisiDetayi.nStokFisiID, tbStokFisiDetayi.nMusteriID, tbStokFisiDetayi.nFirmaID, tbMusteri.lKodu AS MUSTERIKODU, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS MUSTERIADI, tbFirma.sKodu AS FIRMAKODU, tbFirma.sAciklama AS FIRMAADI, '' AS HESAPKODU, '' AS HESAPADI, CAST(0 AS MONEY) AS KALAN,isnull(baslik.lToplamMiktar,0) AS FATURAMIKTARI, isnull(baslik.lMalBedeli - baslik.lMalIskontoTutari,0) AS FATURATUTARI, isnull(baslik.lEkmaliyet1,0) AS EKMALIYET,(SELECT sAlisVerisYapanAdi + ' ' + sAlisVerisYapanSoyadi FROM tbAlisVeris WHERE nAlisVerisID = tbStokFisiDetayi.nAlisVerisID) AS sAvYapanAdi FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiMaster baslik ON tbStokFisiDetayi.nStokFisiID = baslik.nStokFisiID LEFT OUTER JOIN tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID WHERE  " & kriter2 & " ORDER BY tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lFisNo")
                End If
            Else
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.nStokID,tbStok.sKodu as sStokKodu,tbStok.sAciklama as sStokAciklama,tbStok.sModel,tbStok.sRenk,tbStok.sBeden,tbFisTipi.sFisTipi, tbFisTipi.sAciklama, tbStokFisiDetayi. nIslemID,tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lCikisFiyat, " & sDetay & " tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.lCikisMiktar1, tbStokFisiDetayi.lDovizKuru1, tbStokFisiDetayi.sDovizCinsi1, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutFiyat as lDovizFiyati,tbStokFisiDetayi.lBrutTutar as lDovizTutari,tbStokFisiDetayi.lBrutFiyat as lBrut,tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.nIskontoYuzdesi,tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.nKdvOrani,tbStokFisiDetayi.lMaliyetFiyat, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sAciklama sHareketAciklama,tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sSaticiRumuzu,tbStokFisiDetayi.sFisTipi,tbStokFisiDetayi.nAlisverisID,tbStokFisiDetayi.nStokFisiID, tbStokFisiDetayi.nMusteriID, tbStokFisiDetayi.nFirmaID, tbMusteri.lKodu AS MUSTERIKODU, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS MUSTERIADI, tbFirma.sKodu AS FIRMAKODU, tbFirma.sAciklama AS FIRMAADI, '' AS HESAPKODU, '' AS HESAPADI, CAST(0 AS MONEY) AS KALAN,isnull(baslik.lToplamMiktar,0) AS FATURAMIKTARI, isnull(baslik.lMalBedeli - baslik.lMalIskontoTutari,0) AS FATURATUTARI, isnull(baslik.lEkmaliyet1,0) AS EKMALIYET,(SELECT sAlisVerisYapanAdi + ' ' + sAlisVerisYapanSoyadi FROM tbAlisVeris WHERE nAlisVerisID = tbStokFisiDetayi.nAlisVerisID) AS sAvYapanAdi FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiMaster baslik ON tbStokFisiDetayi.nStokFisiID = baslik.nStokFisiID LEFT OUTER JOIN tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID WHERE (tbStokFisiDetayi.sFisTipi <> 'T') " & kriter2 & " ORDER BY tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lFisNo")
            End If
        End If
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFisTipi.sFisTipi, tbFisTipi.sAciklama, tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lCikisFiyat, tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.lCikisMiktar1, tbStokFisiDetayi.lDovizKuru1, tbStokFisiDetayi.sDovizCinsi1, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.nAlisverisID, tbStokFisiDetayi.nMusteriID, tbStokFisiDetayi.nFirmaID, tbMusteri.lKodu AS MUSTERIKODU, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS MUSTERIADI, tbFirma.sKodu AS FIRMAKODU, tbFirma.sAciklama AS FIRMAADI, '' AS HESAPKODU, '' AS HESAPADI, CAST(0 AS MONEY) AS KALAN,isnull(baslik.lToplamMiktar,0) AS FATURAMIKTARI, isnull(baslik.lMalBedeli - baslik.lMalIskontoTutari,0) AS FATURATUTARI, isnull(baslik.lEkmaliyet1,0) AS EKMALIYET FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiMaster baslik ON tbStokFisiDetayi.nStokFisiID = baslik.nStokFisiID LEFT OUTER JOIN tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStok.sKodu = '" & musterino & "') ORDER BY tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lFisNo")
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
    Private Sub analiz_fis()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Trim(dr("nAlisVerisID").ToString) <> "" Then
                stok_satis_detay()
            ElseIf Trim(dr("nStokFisiID").ToString) <> "" Then
                fis_duzelt()
            End If
        End If
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New System.Windows.Forms.SaveFileDialog
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
            Dim SaveFileDialog1 As New System.Windows.Forms.SaveFileDialog
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
    Private Sub raporla_rtf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Metin Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New System.Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyalarý(*.rtf) |*.rtf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.rtf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToRtf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub fis_duzelt()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_fatura
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.lFisNo = dr("lFisNo")
            frm.dteFisTarihi = dr("dteFisTarihi")
            frm.sFisTipi = dr("sFisTipi")
            frm.nFirmaID = dr("nFirmaID")
            frm.nGirisCikis = dr("nGirisCikis")
            frm.nStokFisiID = dr("nStokFisiID")
            frm.nIslemID = dr("nIslemID")
            frm.kullanici = kullanici
            frm.bResmi = sec_resmi.Checked
            Dim satir = GridView1.FocusedRowHandle
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm = Nothing
            dr = Nothing
            dataload()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub stok_satis_detay()
        Dim frm As New frm_Perakende_Satis
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        frm.status = True
        frm.firmano = 100
        frm.donemno = 1
        frm.connection = connection
        frm.islemstatus = True
        frm.nAlisVerisID = dr("nAlisVerisID").ToString
        frm.sFisTipi = Trim(dr("sFisTipi").ToString)
        frm.kullanici = kullanici
        frm.sMagaza = dr("sDepo")
        Dim satir = GridView1.FocusedRowHandle
        If yetki_kontrol(kullanici, Name & "_Perakende_incele") = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
        dr = Nothing
        dataload()
        GridView1.FocusedRowHandle = satir
        satir = Nothing
    End Sub
    Private Sub dataload_renk()
        sec_sRenk.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbRenk")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub dataload_tbdepo()
        ds_tbDepo = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo,sAciklama,nFirmaID FROM         tbDepo"))
        sec_sDepo.Properties.DataSource = ds_tbDepo.Tables(0)
        'sec_sDepo.Text = sDepo

    End Sub
    Private Sub ara()
        dataload()
    End Sub
    Private Sub dataload()
        If txt_StokKodu.Text = "" And nFirmaID = 0 Then
            'XtraMessageBox.Show(Sorgu_sDil("Stok Kodunu Boþ Býrakamazsýnýz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            DataSet1 = stok(txt_StokKodu.Text, DateEdit1.EditValue, DateEdit2.EditValue)
            GridControl1.DataSource = DataSet1.Tables(0)
            GridControl1.DataMember = Nothing
            PanelControl3.Select()
            GridControl1.Focus()
            GridControl1.Select()
            GridView1.CollapseAllGroups()
            kontrol_oran()
            If sec_giris.Text = "[Tümü]" Then
                If rStokCari = False Then
                    colKALAN.Visible = True
                End If
                'kontrol_oran()
            Else
                colKALAN.Visible = False
            End If
            If GridView1.RowCount > 0 Then
                GridView1.ClearSelection()
                GridView1.FocusedRowHandle = GridView1.RowCount - 1
                GridView1.SelectRow(GridView1.FocusedRowHandle)
                GridControl1.Focus()
            End If
            Cursor.Current = Cursors.Default
            Cursor.Hide()
        End If
    End Sub
    Private Sub kontrol_oran()
        Panelstatus.Visible = True
        bar.Properties.Maximum = GridView1.RowCount
        barlabel.Text = "Toplam Satýr Sayýsý : " & GridView1.RowCount
        bar.Position = 0
        Dim dr As DataRow
        Dim kalan = 0
        For Each dr In DataSet1.Tables(0).Rows
            'barlabel.Text = "StokKodu:" & dr("sKodu").ToString & vbTab & "Adý:" & dr("sAciklama").ToString
            barlabel.Refresh()
            If CInt(dr("nFirmaID")) > 0 And CInt(dr("nMusteriID")) = 0 Then
                dr("HESAPKODU") = dr("FIRMAKODU").ToString
                dr("HESAPADI") = dr("FIRMAADI").ToString
            Else
                dr("HESAPKODU") = dr("MUSTERIKODU").ToString
                dr("HESAPADI") = dr("MUSTERIADI").ToString
            End If
            Dim oranekmaliyet As Decimal
            If dr("EKMALIYET") <> 0 Then
                oranekmaliyet = dr("EKMALIYET") / dr("FATURATUTARI")
            End If
            'dr("NETMALIYET") = dr("KDVLITUTAR") * ((100 + (dr("ORANEKMALIYET") * 100)) / 100)
            If dr("nGirisCikis") = 1 Then
                dr("lBrutFiyat") = dr("lGirisFiyat") * ((dr("nKdvOrani") + 100) / 100)
                oranekmaliyet = 0
                If dr("EKMALIYET") <> 0 Then
                    oranekmaliyet = dr("EKMALIYET") / dr("FATURATUTARI")
                    dr("lBrutFiyat") = dr("lBrutFiyat") * ((100 + (oranekmaliyet * 100)) / 100)
                End If
                dr("lBrutTutar") = dr("lBrutFiyat") * dr("lGirisMiktar1")
            ElseIf dr("nGirisCikis") = 2 Then
                dr("lBrutFiyat") = dr("lGirisFiyat") * ((dr("nKdvOrani") + 100) / 100)
                oranekmaliyet = 0
                If dr("EKMALIYET") <> 0 Then
                    oranekmaliyet = dr("EKMALIYET") / dr("FATURATUTARI")
                    dr("lBrutFiyat") = dr("lBrutFiyat") * ((100 + (oranekmaliyet * 100)) / 100)
                End If
                dr("lBrutTutar") = dr("lBrutFiyat") * dr("lGirisMiktar1")
            ElseIf dr("nGirisCikis") = 3 Then
                dr("lBrutFiyat") = dr("lCikisFiyat") * ((dr("nKdvOrani") + 100) / 100)
                oranekmaliyet = 0
                If dr("EKMALIYET") <> 0 Then
                    oranekmaliyet = dr("EKMALIYET") / dr("FATURATUTARI")
                    dr("lBrutFiyat") = dr("lBrutFiyat") * ((100 + (oranekmaliyet * 100)) / 100)
                End If
                dr("lBrutTutar") = dr("lBrutFiyat") * dr("lCikisMiktar1")
            ElseIf dr("nGirisCikis") = 4 Then
                dr("lBrutFiyat") = dr("lCikisFiyat") * ((dr("nKdvOrani") + 100) / 100)
                oranekmaliyet = 0
                If dr("EKMALIYET") <> 0 Then
                    oranekmaliyet = dr("EKMALIYET") / dr("FATURATUTARI")
                    dr("lBrutFiyat") = dr("lBrutFiyat") * ((100 + (oranekmaliyet * 100)) / 100)
                End If
                dr("lBrutTutar") = dr("lBrutFiyat") * dr("lCikisMiktar1")
            End If
            If dr("sDovizCinsi1") <> "" And dr("lDovizKuru1") <> 0 Then
                Try
                    dr("lDovizFiyati") = dr("lBrutFiyat") / dr("lDovizKuru1")
                    dr("lDovizTutari") = dr("lBrutTutar") / dr("lDovizKuru1")
                Catch ex As Exception
                End Try
            End If
            'dr("lBrutFiyat") = dr("lGirisFiyat")
            kalan = kalan + (dr("lGirisMiktar1") - dr("lCikisMiktar1"))
            dr("KALAN") = kalan
            bar.Position = bar.Position + 1
            bar.Refresh()
        Next
        colKALAN.SummaryItem.DisplayFormat = "" & Format((kalan), "#,0.###").ToString
        GridView1.UpdateSummary()
        GridView1.UpdateTotalSummary()
        bar.Position = 0
        Panelstatus.Visible = False
        dr = Nothing
    End Sub
    Private Sub analiz_alis()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_cari_alis
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            'frm.musterino = dr("sKodu")
            frm.fisno = dr("lFisNo")
            frm.tarih = dr("dteFisTarihi")
            frm.fistipi = dr("sFisTipi")
            frm.firmaID = dr("nFirmaID")
            frm.ngiriscikis = dr("nGirisCikis")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_satis_kapatmasi()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("nAlisVerisID").ToString <> "" Then
                Dim frm As New frm_perakende_satis_kapatmasi
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                'frm.musterino = dr("sKodu")
                frm.nAlisVerisID = dr("nAlisVerisID")
                frm.kullanici = kullanici
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
            End If
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
    Private Sub analiz_stok_KarlilikAkisTablosu()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_Stok_Satis_Maliyetlendir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.txt_sStokKodu.Text = dr("sStokKodu")
            frm.bAnaliz = True
            If yetki_kontrol(kullanici, "frm_Stok_KarlilikAkisTablosu") = True Then
                frm.ShowDialog()
            End If
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        stok_satis_detay()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.F4 Then
            analiz_fis()
        ElseIf e.KeyCode = Keys.Enter Then
            If islemstatus = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                analiz_fis()
            End If
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
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            'If XtraMessageBox.Show(Sorgu_sDil("Açýk Faturalar Kontrol Ekranýndan Çýkmak Ýstediðinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        analiz_alis()
    End Sub
    Private Sub sec_giris_QueryCloseUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_giris.QueryCloseUp
        dataload()
    End Sub
    Private Sub sec_firma_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_firma.CheckedChanged
        dataload()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        analiz_envanter()
    End Sub
    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        If sec_firma.Checked = False Then
            sec_firma.Checked = True
        ElseIf sec_firma.Checked = True Then
            sec_firma.Checked = False
        End If
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        If MenuItem21.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem21.Checked = True
        ElseIf MenuItem21.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem21.Checked = False
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_rtf()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        analiz_satis_kapatmasi()
    End Sub
    Private Sub raporla(ByVal nIslem As Integer)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyalarý (Ekstre*.frx) |Ekstre*.frx"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Stok Ekstre\Ekstre.frx"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Stok Ekstre\"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            Dim report As New FastReport.Report
            report.Load(sFile)
            report.RegisterData(DataSet1, "TABLE1")
            report.RegisterData(ds_tbParamGenel)
            'report.RegisterData(dataset2, "TABLE2")
            'report.SetParameterValue("Devreden", lDevir)
            'Try
            '    report.RegisterData(ds_irsaliye, "TABLE3")
            '    report.GetDataSource("Table3").Enabled = True
            'Catch ex As Exception
            'End Try
            'report.GetDataSource("Table1").Enabled = True
            'report.GetDataSource("Table2").Enabled = True
            report.ScriptLanguage = FastReport.Language.Vb
            If nIslem = 0 Then
                report.Show()
            ElseIf nIslem = 1 Then
                report.Design()
            ElseIf nIslem = 2 Then
                'report.Prepare()
                report.Print()
            End If
            report.Dispose()
            report = Nothing
        End If
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        raporla(0)
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        raporla(1)
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        raporla(2)
    End Sub
    Private Sub btn_Listele_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Listele.Click
        dataload()
    End Sub
    Private Sub txt_StokKodu_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_StokKodu.ButtonClick
    End Sub
    Private Sub stok_sec()
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_stok_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            musterino = Trim(dr1("sKodu"))
            sModel = Trim(dr1("sModel"))
            txt_StokKodu.EditValue = Trim(dr1("sKodu"))
            lbl_sAciklama.Text = Trim(dr1("sAciklama"))
            dr1 = Nothing
        Else
        End If
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        txt_StokKodu.Focus()
        txt_StokKodu.SelectAll()
    End Sub
    Private Sub txt_StokKodu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_StokKodu.KeyDown
        If e.KeyCode = Keys.Space Then
            stok_sec()
        End If
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        analiz_stok_KarlilikAkisTablosu()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_stok_KarlilikAkisTablosu()
    End Sub
    Private Sub sec_resmi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_resmi.CheckStateChanged
        If sec_resmi.Checked = True Then
            connection = connection_resmi
            ara()
            sec_resmi1.Checked = False
        ElseIf sec_resmi.Checked = False Then
            connection = connection_orj
            ara()
        End If
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        If sec_resmi.Checked = False Then
            sec_resmi.Checked = True
        ElseIf sec_resmi.Checked = True Then
            sec_resmi.Checked = False
        End If
    End Sub
End Class
