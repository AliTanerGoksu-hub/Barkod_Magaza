Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports Microsoft.Win32
Public Class frm_stok_fiyatlandir_model
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
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_musteriNo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ds_tbStokAcilim As System.Data.DataSet
    Friend WithEvents txt_nFiyatlandirma As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents colnStokID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsModel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBeden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ds_tbStokFiyat As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents colsFiyatTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTespitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKavala As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ds_tbStok As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
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
    Friend WithEvents colsRenkAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kisayol_model As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents kisayol_fiyat As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents printlink2 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents sec_tutar As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents colOran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStokID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteIslemTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnFirmaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnMusteriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFisTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteFisTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnGirisCikis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFiyatTipi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBrutFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBrutTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIskontoYuzdesi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKdvOrani As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collIskontoTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHareketTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStokFisiID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnAlisverisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHesapKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHesapAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFiyati As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label_stok As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ds_tbStokBakiyesi As System.Data.DataSet
    Friend WithEvents DataTable4 As System.Data.DataTable
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit12 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents colsDovizCinsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents c As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_fiyatlandir_model))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.colOran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collFiyat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_tutar = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Label_stok = New DevExpress.XtraEditors.LabelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.sec_sRenk = New DevExpress.XtraEditors.ComboBoxEdit
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.c = New DevExpress.XtraBars.BarButtonItem
        Me.sec_sFiyatTipi = New DevExpress.XtraEditors.ComboBoxEdit
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit
        Me.ds_tbStokBakiyesi = New System.Data.DataSet
        Me.DataTable4 = New System.Data.DataTable
        Me.DataColumn43 = New System.Data.DataColumn
        Me.DataColumn44 = New System.Data.DataColumn
        Me.DataColumn45 = New System.Data.DataColumn
        Me.DataColumn46 = New System.Data.DataColumn
        Me.DataColumn47 = New System.Data.DataColumn
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit8 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit9 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit10 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit11 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit12 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me.txt_nFiyatlandirma = New DevExpress.XtraEditors.LookUpEdit
        Me.ds_tbStok = New System.Data.DataSet
        Me.DataTable3 = New System.Data.DataTable
        Me.DataColumn10 = New System.Data.DataColumn
        Me.DataColumn11 = New System.Data.DataColumn
        Me.DataColumn12 = New System.Data.DataColumn
        Me.DataColumn13 = New System.Data.DataColumn
        Me.DataColumn14 = New System.Data.DataColumn
        Me.DataColumn15 = New System.Data.DataColumn
        Me.DataColumn16 = New System.Data.DataColumn
        Me.DataColumn17 = New System.Data.DataColumn
        Me.DataColumn18 = New System.Data.DataColumn
        Me.DataColumn19 = New System.Data.DataColumn
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
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txt_musteriNo = New DevExpress.XtraEditors.ButtonEdit
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.kisayol_fiyat = New System.Windows.Forms.ContextMenu
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.ds_tbStokFiyat = New System.Data.DataSet
        Me.DataTable2 = New System.Data.DataTable
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colsFiyatTipi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteTespitTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsDovizCinsi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsRenkAdi1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsKavala1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.kisayol_model = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.ds_tbStokAcilim = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colnStokID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsModel = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsKavala = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsRenkAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.collMiktar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnStokID1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsKodu1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklama1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteIslemTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnFirmaID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnMusteriID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsFisTipi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteFisTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collFisNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnGirisCikis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsDepo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsFiyatTipi1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collBrutFiyat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collBrutTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnIskontoYuzdesi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnKdvOrani = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collIskontoTutari = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsHareketTipi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnStokFisiID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnAlisverisID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsHesapKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsHesapAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collFiyati = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink2 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.sec_tutar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.sec_sRenk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sFiyatTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbStokBakiyesi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nFiyatlandirma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbStokFiyat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbStokAcilim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink2.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colOran
        '
        Me.colOran.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colOran.AppearanceCell.BorderColor = System.Drawing.Color.Navy
        Me.colOran.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colOran.AppearanceCell.Options.UseBackColor = True
        Me.colOran.AppearanceCell.Options.UseBorderColor = True
        Me.colOran.AppearanceCell.Options.UseFont = True
        Me.colOran.Caption = "% Oran"
        Me.colOran.DisplayFormat.FormatString = "#,#.##"
        Me.colOran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOran.FieldName = "Oran"
        Me.colOran.Name = "colOran"
        Me.colOran.OptionsColumn.AllowFocus = False
        Me.colOran.Width = 73
        '
        'collFiyat
        '
        Me.collFiyat.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.collFiyat.AppearanceCell.ForeColor = System.Drawing.Color.Navy
        Me.collFiyat.AppearanceCell.Options.UseFont = True
        Me.collFiyat.AppearanceCell.Options.UseForeColor = True
        Me.collFiyat.Caption = "Fiyat"
        Me.collFiyat.ColumnEdit = Me.sec_tutar
        Me.collFiyat.DisplayFormat.FormatString = "#,0.00#"
        Me.collFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collFiyat.FieldName = "lFiyat"
        Me.collFiyat.Name = "collFiyat"
        Me.collFiyat.OptionsColumn.AllowFocus = False
        Me.collFiyat.Width = 116
        '
        'sec_tutar
        '
        Me.sec_tutar.AutoHeight = False
        Me.sec_tutar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_tutar.DisplayFormat.FormatString = "#,0.00##"
        Me.sec_tutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_tutar.EditFormat.FormatString = "#,0.00##"
        Me.sec_tutar.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_tutar.Name = "sec_tutar"
        Me.sec_tutar.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        '
        'colStatus
        '
        Me.colStatus.Caption = "Durum"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 0
        Me.colStatus.Width = 59
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label_stok)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 56)
        Me.PanelControl1.TabIndex = 0
        '
        'Label_stok
        '
        Me.Label_stok.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label_stok.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label_stok.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Label_stok.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Label_stok.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label_stok.Location = New System.Drawing.Point(96, 15)
        Me.Label_stok.Name = "Label_stok"
        Me.Label_stok.Size = New System.Drawing.Size(8, 16)
        Me.Label_stok.TabIndex = 79
        Me.Label_stok.Text = "*"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Stok Kartı Fiyat Tanımları Aşağıdadır..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.sec_sRenk)
        Me.PanelControl2.Controls.Add(Me.sec_sFiyatTipi)
        Me.PanelControl2.Controls.Add(Me.PanelControl5)
        Me.PanelControl2.Controls.Add(Me.txt_nFiyatlandirma)
        Me.PanelControl2.Controls.Add(Me.LabelControl9)
        Me.PanelControl2.Controls.Add(Me.LabelControl8)
        Me.PanelControl2.Controls.Add(Me.txt_musteriNo)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 320)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 86)
        Me.PanelControl2.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(530, 59)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl2.TabIndex = 82
        Me.LabelControl2.Text = "Renk:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(425, 58)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl1.TabIndex = 81
        Me.LabelControl1.Text = "FiyatTipi:"
        '
        'sec_sRenk
        '
        Me.sec_sRenk.Location = New System.Drawing.Point(564, 55)
        Me.sec_sRenk.MenuManager = Me.BarManager1
        Me.sec_sRenk.Name = "sec_sRenk"
        Me.sec_sRenk.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.sec_sRenk.Properties.Appearance.Options.UseBackColor = True
        Me.sec_sRenk.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sRenk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sRenk.Size = New System.Drawing.Size(88, 20)
        Me.sec_sRenk.TabIndex = 80
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.c, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem3, Me.BarButtonItem6})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Caption, Me.BarButtonItem5, "Excel", True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.Appearance.Options.UseFont = True
        Me.BarButtonItem1.Caption = "Çıkış,Esc"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.Appearance.Options.UseFont = True
        Me.BarButtonItem4.Caption = "Yazdır,Ctrl+P"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.Appearance.Options.UseFont = True
        Me.BarButtonItem5.Caption = "E"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.Appearance.Options.UseFont = True
        Me.BarButtonItem3.Caption = "Text"
        Me.BarButtonItem3.Id = 5
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.Appearance.Options.UseFont = True
        Me.BarButtonItem6.Caption = "Mail"
        Me.BarButtonItem6.Id = 6
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 406)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 406)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 406)
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.Appearance.Options.UseFont = True
        Me.BarButtonItem2.Caption = "Renk,R"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'c
        '
        Me.c.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.c.Appearance.Options.UseFont = True
        Me.c.Caption = "Beden,B"
        Me.c.Id = 2
        Me.c.Name = "c"
        '
        'sec_sFiyatTipi
        '
        Me.sec_sFiyatTipi.Location = New System.Drawing.Point(475, 55)
        Me.sec_sFiyatTipi.MenuManager = Me.BarManager1
        Me.sec_sFiyatTipi.Name = "sec_sFiyatTipi"
        Me.sec_sFiyatTipi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sFiyatTipi.Properties.Appearance.Options.UseBackColor = True
        Me.sec_sFiyatTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sFiyatTipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sFiyatTipi.Size = New System.Drawing.Size(49, 20)
        Me.sec_sFiyatTipi.TabIndex = 79
        '
        'PanelControl5
        '
        Me.PanelControl5.Appearance.BackColor = System.Drawing.Color.Black
        Me.PanelControl5.Appearance.Options.UseBackColor = True
        Me.PanelControl5.Controls.Add(Me.LabelControl7)
        Me.PanelControl5.Controls.Add(Me.TextEdit7)
        Me.PanelControl5.Controls.Add(Me.LabelControl6)
        Me.PanelControl5.Controls.Add(Me.TextEdit6)
        Me.PanelControl5.Controls.Add(Me.LabelControl5)
        Me.PanelControl5.Controls.Add(Me.TextEdit5)
        Me.PanelControl5.Controls.Add(Me.LabelControl4)
        Me.PanelControl5.Controls.Add(Me.TextEdit4)
        Me.PanelControl5.Controls.Add(Me.LabelControl3)
        Me.PanelControl5.Controls.Add(Me.TextEdit3)
        Me.PanelControl5.Controls.Add(Me.TextEdit8)
        Me.PanelControl5.Controls.Add(Me.TextEdit9)
        Me.PanelControl5.Controls.Add(Me.TextEdit10)
        Me.PanelControl5.Controls.Add(Me.TextEdit11)
        Me.PanelControl5.Controls.Add(Me.TextEdit12)
        Me.PanelControl5.Controls.Add(Me.LabelControl23)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl5.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl5.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.PanelControl5.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(820, 45)
        Me.PanelControl5.TabIndex = 78
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Location = New System.Drawing.Point(529, 4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(110, 18)
        Me.LabelControl7.TabIndex = 74
        Me.LabelControl7.Text = "Kalan"
        '
        'TextEdit7
        '
        Me.TextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStokBakiyesi, "Table1.nKalan", True))
        Me.TextEdit7.EditValue = 0
        Me.TextEdit7.Enabled = False
        Me.TextEdit7.EnterMoveNextControl = True
        Me.TextEdit7.Location = New System.Drawing.Point(531, 20)
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.TextEdit7.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit7.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit7.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit7.Properties.Appearance.Options.UseFont = True
        Me.TextEdit7.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit7.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit7.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit7.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit7.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit7.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit7.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit7.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit7.Properties.DisplayFormat.FormatString = "#,0.####"
        Me.TextEdit7.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit7.Properties.EditFormat.FormatString = "#,0.####"
        Me.TextEdit7.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit7.Properties.MaxLength = 60
        Me.TextEdit7.Properties.NullText = "0.00"
        Me.TextEdit7.Properties.ReadOnly = True
        Me.TextEdit7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit7.Size = New System.Drawing.Size(110, 18)
        Me.TextEdit7.TabIndex = 73
        '
        'ds_tbStokBakiyesi
        '
        Me.ds_tbStokBakiyesi.DataSetName = "NewDataSet"
        Me.ds_tbStokBakiyesi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbStokBakiyesi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable4})
        '
        'DataTable4
        '
        Me.DataTable4.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47})
        Me.DataTable4.TableName = "Table1"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "nGiris"
        Me.DataColumn43.DataType = GetType(Decimal)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "nGirisIade"
        Me.DataColumn44.DataType = GetType(Decimal)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "nCikis"
        Me.DataColumn45.DataType = GetType(Decimal)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "nCikisIade"
        Me.DataColumn46.DataType = GetType(Decimal)
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "nKalan"
        Me.DataColumn47.DataType = GetType(Decimal)
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Location = New System.Drawing.Point(422, 4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(107, 18)
        Me.LabelControl6.TabIndex = 72
        Me.LabelControl6.Text = "İade Alınan"
        '
        'TextEdit6
        '
        Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStokBakiyesi, "Table1.nCikisIade", True))
        Me.TextEdit6.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TextEdit6.Enabled = False
        Me.TextEdit6.EnterMoveNextControl = True
        Me.TextEdit6.Location = New System.Drawing.Point(422, 20)
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.TextEdit6.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit6.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit6.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit6.Properties.Appearance.Options.UseFont = True
        Me.TextEdit6.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit6.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit6.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit6.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit6.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit6.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit6.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit6.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit6.Properties.DisplayFormat.FormatString = "#,0.####"
        Me.TextEdit6.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit6.Properties.EditFormat.FormatString = "#,0.####"
        Me.TextEdit6.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit6.Properties.MaxLength = 60
        Me.TextEdit6.Properties.NullText = "0.00"
        Me.TextEdit6.Properties.ReadOnly = True
        Me.TextEdit6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit6.Size = New System.Drawing.Size(107, 18)
        Me.TextEdit6.TabIndex = 71
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Location = New System.Drawing.Point(313, 4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(107, 18)
        Me.LabelControl5.TabIndex = 70
        Me.LabelControl5.Text = "Çıkış"
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStokBakiyesi, "Table1.nCikis", True))
        Me.TextEdit5.EditValue = "0"
        Me.TextEdit5.Enabled = False
        Me.TextEdit5.EnterMoveNextControl = True
        Me.TextEdit5.Location = New System.Drawing.Point(313, 20)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.TextEdit5.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit5.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit5.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit5.Properties.Appearance.Options.UseFont = True
        Me.TextEdit5.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit5.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit5.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit5.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit5.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit5.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit5.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit5.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit5.Properties.DisplayFormat.FormatString = "#,0.####"
        Me.TextEdit5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit5.Properties.EditFormat.FormatString = "#,0.####"
        Me.TextEdit5.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit5.Properties.MaxLength = 60
        Me.TextEdit5.Properties.NullText = "0.00"
        Me.TextEdit5.Properties.ReadOnly = True
        Me.TextEdit5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit5.Size = New System.Drawing.Size(107, 18)
        Me.TextEdit5.TabIndex = 69
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(204, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(107, 18)
        Me.LabelControl4.TabIndex = 68
        Me.LabelControl4.Text = "İade Edilen"
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStokBakiyesi, "Table1.nGirisIade", True))
        Me.TextEdit4.EditValue = "0"
        Me.TextEdit4.Enabled = False
        Me.TextEdit4.EnterMoveNextControl = True
        Me.TextEdit4.Location = New System.Drawing.Point(204, 20)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.TextEdit4.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit4.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit4.Properties.Appearance.Options.UseFont = True
        Me.TextEdit4.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit4.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit4.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit4.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit4.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit4.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit4.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit4.Properties.DisplayFormat.FormatString = "#,0.####"
        Me.TextEdit4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit4.Properties.EditFormat.FormatString = "#,0.####"
        Me.TextEdit4.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit4.Properties.MaxLength = 60
        Me.TextEdit4.Properties.NullText = "0.00"
        Me.TextEdit4.Properties.ReadOnly = True
        Me.TextEdit4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit4.Size = New System.Drawing.Size(107, 18)
        Me.TextEdit4.TabIndex = 67
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(91, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(107, 18)
        Me.LabelControl3.TabIndex = 66
        Me.LabelControl3.Text = "Giriş"
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStokBakiyesi, "Table1.nGiris", True))
        Me.TextEdit3.EditValue = "0"
        Me.TextEdit3.Enabled = False
        Me.TextEdit3.EnterMoveNextControl = True
        Me.TextEdit3.Location = New System.Drawing.Point(91, 20)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.TextEdit3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit3.Properties.Appearance.Options.UseFont = True
        Me.TextEdit3.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit3.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit3.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit3.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit3.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit3.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit3.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit3.Properties.DisplayFormat.FormatString = "#,0.####"
        Me.TextEdit3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit3.Properties.EditFormat.FormatString = "#,0.####"
        Me.TextEdit3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit3.Properties.MaxLength = 60
        Me.TextEdit3.Properties.NullText = "0.00"
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit3.Size = New System.Drawing.Size(111, 18)
        Me.TextEdit3.TabIndex = 65
        '
        'TextEdit8
        '
        Me.TextEdit8.EditValue = 0
        Me.TextEdit8.Enabled = False
        Me.TextEdit8.EnterMoveNextControl = True
        Me.TextEdit8.Location = New System.Drawing.Point(531, 44)
        Me.TextEdit8.Name = "TextEdit8"
        Me.TextEdit8.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.TextEdit8.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit8.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit8.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit8.Properties.Appearance.Options.UseFont = True
        Me.TextEdit8.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit8.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit8.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit8.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit8.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit8.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit8.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit8.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit8.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit8.Properties.DisplayFormat.FormatString = "#,0.####"
        Me.TextEdit8.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit8.Properties.EditFormat.FormatString = "#,0.####"
        Me.TextEdit8.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit8.Properties.MaxLength = 60
        Me.TextEdit8.Properties.NullText = "0.00"
        Me.TextEdit8.Properties.ReadOnly = True
        Me.TextEdit8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit8.Size = New System.Drawing.Size(110, 18)
        Me.TextEdit8.TabIndex = 82
        Me.TextEdit8.Visible = False
        '
        'TextEdit9
        '
        Me.TextEdit9.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TextEdit9.Enabled = False
        Me.TextEdit9.EnterMoveNextControl = True
        Me.TextEdit9.Location = New System.Drawing.Point(422, 44)
        Me.TextEdit9.Name = "TextEdit9"
        Me.TextEdit9.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.TextEdit9.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit9.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit9.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit9.Properties.Appearance.Options.UseFont = True
        Me.TextEdit9.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit9.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit9.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit9.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit9.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit9.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit9.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit9.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit9.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit9.Properties.DisplayFormat.FormatString = "#,0.####"
        Me.TextEdit9.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit9.Properties.EditFormat.FormatString = "#,0.####"
        Me.TextEdit9.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit9.Properties.MaxLength = 60
        Me.TextEdit9.Properties.NullText = "0.00"
        Me.TextEdit9.Properties.ReadOnly = True
        Me.TextEdit9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit9.Size = New System.Drawing.Size(107, 18)
        Me.TextEdit9.TabIndex = 81
        Me.TextEdit9.Visible = False
        '
        'TextEdit10
        '
        Me.TextEdit10.EditValue = "0"
        Me.TextEdit10.Enabled = False
        Me.TextEdit10.EnterMoveNextControl = True
        Me.TextEdit10.Location = New System.Drawing.Point(313, 44)
        Me.TextEdit10.Name = "TextEdit10"
        Me.TextEdit10.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.TextEdit10.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit10.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit10.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit10.Properties.Appearance.Options.UseFont = True
        Me.TextEdit10.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit10.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit10.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit10.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit10.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit10.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit10.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit10.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit10.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit10.Properties.DisplayFormat.FormatString = "#,0.####"
        Me.TextEdit10.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit10.Properties.EditFormat.FormatString = "#,0.####"
        Me.TextEdit10.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit10.Properties.MaxLength = 60
        Me.TextEdit10.Properties.NullText = "0.00"
        Me.TextEdit10.Properties.ReadOnly = True
        Me.TextEdit10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit10.Size = New System.Drawing.Size(107, 18)
        Me.TextEdit10.TabIndex = 80
        Me.TextEdit10.Visible = False
        '
        'TextEdit11
        '
        Me.TextEdit11.EditValue = "0"
        Me.TextEdit11.Enabled = False
        Me.TextEdit11.EnterMoveNextControl = True
        Me.TextEdit11.Location = New System.Drawing.Point(204, 44)
        Me.TextEdit11.Name = "TextEdit11"
        Me.TextEdit11.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.TextEdit11.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit11.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit11.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit11.Properties.Appearance.Options.UseFont = True
        Me.TextEdit11.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit11.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit11.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit11.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit11.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit11.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit11.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit11.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit11.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit11.Properties.DisplayFormat.FormatString = "#,0.####"
        Me.TextEdit11.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit11.Properties.EditFormat.FormatString = "#,0.####"
        Me.TextEdit11.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit11.Properties.MaxLength = 60
        Me.TextEdit11.Properties.NullText = "0.00"
        Me.TextEdit11.Properties.ReadOnly = True
        Me.TextEdit11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit11.Size = New System.Drawing.Size(107, 18)
        Me.TextEdit11.TabIndex = 79
        Me.TextEdit11.Visible = False
        '
        'TextEdit12
        '
        Me.TextEdit12.EditValue = "0"
        Me.TextEdit12.Enabled = False
        Me.TextEdit12.EnterMoveNextControl = True
        Me.TextEdit12.Location = New System.Drawing.Point(91, 44)
        Me.TextEdit12.Name = "TextEdit12"
        Me.TextEdit12.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.TextEdit12.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit12.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit12.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit12.Properties.Appearance.Options.UseFont = True
        Me.TextEdit12.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit12.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit12.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit12.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit12.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit12.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit12.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit12.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit12.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit12.Properties.DisplayFormat.FormatString = "#,0.####"
        Me.TextEdit12.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit12.Properties.EditFormat.FormatString = "#,0.####"
        Me.TextEdit12.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit12.Properties.MaxLength = 60
        Me.TextEdit12.Properties.NullText = "0.00"
        Me.TextEdit12.Properties.ReadOnly = True
        Me.TextEdit12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit12.Size = New System.Drawing.Size(111, 18)
        Me.TextEdit12.TabIndex = 78
        Me.TextEdit12.Visible = False
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl23.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl23.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl23.Location = New System.Drawing.Point(54, 48)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl23.TabIndex = 77
        Me.LabelControl23.Text = "Tutar:"
        Me.LabelControl23.Visible = False
        '
        'txt_nFiyatlandirma
        '
        Me.txt_nFiyatlandirma.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.nFiyatlandirma", True))
        Me.txt_nFiyatlandirma.EnterMoveNextControl = True
        Me.txt_nFiyatlandirma.Location = New System.Drawing.Point(288, 54)
        Me.txt_nFiyatlandirma.Name = "txt_nFiyatlandirma"
        Me.txt_nFiyatlandirma.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_nFiyatlandirma.Properties.Appearance.Options.UseFont = True
        Me.txt_nFiyatlandirma.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nFiyatlandirma.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nFiyatlandirma.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nFiyatlandirma.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nFiyatlandirma.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nFiyatlandirma.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_nFiyatlandirma.Properties.DisplayMember = "sAciklama"
        Me.txt_nFiyatlandirma.Properties.NullText = "[Fiyatlandırma]"
        Me.txt_nFiyatlandirma.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.txt_nFiyatlandirma.Properties.ValueMember = "nFiyatlandirma"
        Me.txt_nFiyatlandirma.Size = New System.Drawing.Size(131, 20)
        Me.txt_nFiyatlandirma.TabIndex = 76
        '
        'ds_tbStok
        '
        Me.ds_tbStok.DataSetName = "NewDataSet"
        Me.ds_tbStok.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbStok.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "nStokID"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sKodu"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sAciklama"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "sKisaAdi"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "nStokTipi"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sBedenTipi"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "sKavalaTipi"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "sRenk"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "sBeden"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "sKavala"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sBirimCinsi1"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "sBirimCinsi2"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "nIskontoYuzdesi"
        Me.DataColumn22.DataType = GetType(Decimal)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "sKdvTipi"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "nTeminSuresi"
        Me.DataColumn24.DataType = GetType(Long)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "lAsgariMiktar"
        Me.DataColumn25.DataType = GetType(Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "lAzamiMiktar"
        Me.DataColumn26.DataType = GetType(Decimal)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "sOzelNot"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "nFiyatlandirma"
        Me.DataColumn28.DataType = GetType(Long)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "sModel"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "sKullaniciAdi"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "dteKayitTarihi"
        Me.DataColumn31.DataType = GetType(Date)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "bEksiyeDusulebilirmi"
        Me.DataColumn32.DataType = GetType(Boolean)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "sDefaultAsortiTipi"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "bEksideUyarsinmi"
        Me.DataColumn34.DataType = GetType(Boolean)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "bOTVVar"
        Me.DataColumn35.DataType = GetType(Boolean)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "sOTVTipi"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "nIskontoYuzdesiAV"
        Me.DataColumn37.DataType = GetType(Long)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "bEk1"
        Me.DataColumn38.DataType = GetType(Boolean)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "nEk2"
        Me.DataColumn39.DataType = GetType(Long)
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.Location = New System.Drawing.Point(208, 54)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl9.TabIndex = 77
        Me.LabelControl9.Text = "Fiyatlandırma:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.Location = New System.Drawing.Point(5, 54)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl8.TabIndex = 70
        Me.LabelControl8.Text = "Model:"
        '
        'txt_musteriNo
        '
        Me.txt_musteriNo.Location = New System.Drawing.Point(43, 54)
        Me.txt_musteriNo.Name = "txt_musteriNo"
        Me.txt_musteriNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_musteriNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_musteriNo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_musteriNo.Properties.Appearance.Options.UseForeColor = True
        Me.txt_musteriNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txt_musteriNo.Properties.MaxLength = 13
        Me.txt_musteriNo.Size = New System.Drawing.Size(157, 20)
        Me.txt_musteriNo.TabIndex = 69
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = Global.business_smart.My.Resources.Resources.button_cancel
        Me.SimpleButton2.Location = New System.Drawing.Point(733, 54)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 21)
        Me.SimpleButton2.TabIndex = 68
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = Global.business_smart.My.Resources.Resources.button_ok
        Me.SimpleButton1.Location = New System.Drawing.Point(658, 54)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 21)
        Me.SimpleButton1.TabIndex = 67
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GridControl2)
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Controls.Add(Me.PanelControl4)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 264)
        Me.PanelControl3.TabIndex = 2
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenu = Me.kisayol_fiyat
        Me.GridControl2.DataMember = "Table1"
        Me.GridControl2.DataSource = Me.ds_tbStokFiyat
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(86, 66)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_tutar})
        Me.GridControl2.Size = New System.Drawing.Size(736, 196)
        Me.GridControl2.TabIndex = 2
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'kisayol_fiyat
        '
        Me.kisayol_fiyat.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem18, Me.MenuItem20, Me.MenuItem21, Me.MenuItem19, Me.MenuItem3, Me.MenuItem10, Me.MenuItem5, Me.MenuItem4, Me.MenuItem12, Me.MenuItem6, Me.MenuItem7, Me.MenuItem11, Me.MenuItem8, Me.MenuItem9, Me.MenuItem16, Me.MenuItem15})
        '
        'MenuItem18
        '
        Me.MenuItem18.DefaultItem = True
        Me.MenuItem18.Index = 0
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem18.Text = "Fiyat Tarihcesi"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 1
        Me.MenuItem20.Shortcut = System.Windows.Forms.Shortcut.CtrlF7
        Me.MenuItem20.Text = "Stok Hareketleri"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 2
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItem21.Text = "Karlılık Akış Tablosu"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 3
        Me.MenuItem19.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 4
        Me.MenuItem3.Text = "Görünümü Düzenle"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 5
        Me.MenuItem10.Text = "Görünümü Kaydet"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 6
        Me.MenuItem5.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem5.Text = "Görünümü Yazdır"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 7
        Me.MenuItem4.Text = "-"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 8
        Me.MenuItem12.Text = "Hızlı Filtre"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 9
        Me.MenuItem6.Text = "Filtrele"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 10
        Me.MenuItem7.Text = "Gruplandır"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 11
        Me.MenuItem11.Text = "-"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 12
        Me.MenuItem8.Text = "Satırları Aç"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 13
        Me.MenuItem9.Text = "Satırları Kapat"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 14
        Me.MenuItem16.Text = "-"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 15
        Me.MenuItem15.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem15.Text = "Model Seç"
        '
        'ds_tbStokFiyat
        '
        Me.ds_tbStokFiyat.DataSetName = "NewDataSet"
        Me.ds_tbStokFiyat.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbStokFiyat.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sFiyatTipi"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "sAciklama"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "lFiyat"
        Me.DataColumn8.DataType = GetType(Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "dteTespitTarihi"
        Me.DataColumn9.DataType = GetType(Date)
        '
        'GridView2
        '
        Me.GridView2.Appearance.Empty.Options.UseBackColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsFiyatTipi, Me.colsAciklama, Me.collFiyat, Me.coldteTespitTarihi, Me.colOran, Me.colsDovizCinsi, Me.colsRenkAdi1, Me.colsKavala1})
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Navy
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.colOran
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.colOran
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition2.Value1 = "0"
        StyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Navy
        StyleFormatCondition3.Appearance.Options.UseForeColor = True
        StyleFormatCondition3.Column = Me.collFiyat
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition3.Value1 = "0"
        Me.GridView2.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.IndicatorWidth = 12
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colsFiyatTipi
        '
        Me.colsFiyatTipi.AppearanceCell.BackColor = System.Drawing.SystemColors.Control
        Me.colsFiyatTipi.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colsFiyatTipi.AppearanceCell.Options.UseBackColor = True
        Me.colsFiyatTipi.AppearanceCell.Options.UseFont = True
        Me.colsFiyatTipi.Caption = "FiyatTipi"
        Me.colsFiyatTipi.FieldName = "sFiyatTipi"
        Me.colsFiyatTipi.Name = "colsFiyatTipi"
        Me.colsFiyatTipi.OptionsColumn.AllowEdit = False
        Me.colsFiyatTipi.OptionsColumn.AllowFocus = False
        Me.colsFiyatTipi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sFiyatTipi", "{0} Kayıt")})
        Me.colsFiyatTipi.Visible = True
        Me.colsFiyatTipi.VisibleIndex = 0
        Me.colsFiyatTipi.Width = 56
        '
        'colsAciklama
        '
        Me.colsAciklama.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlDark
        Me.colsAciklama.AppearanceCell.Options.UseBackColor = True
        Me.colsAciklama.Caption = "Açıklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.OptionsColumn.AllowEdit = False
        Me.colsAciklama.OptionsColumn.AllowFocus = False
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 1
        Me.colsAciklama.Width = 126
        '
        'coldteTespitTarihi
        '
        Me.coldteTespitTarihi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.coldteTespitTarihi.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.coldteTespitTarihi.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.coldteTespitTarihi.AppearanceCell.Options.UseBackColor = True
        Me.coldteTespitTarihi.AppearanceCell.Options.UseFont = True
        Me.coldteTespitTarihi.AppearanceCell.Options.UseForeColor = True
        Me.coldteTespitTarihi.Caption = "TespitTarihi"
        Me.coldteTespitTarihi.FieldName = "dteFiyatTespitTarihi"
        Me.coldteTespitTarihi.Name = "coldteTespitTarihi"
        Me.coldteTespitTarihi.OptionsColumn.AllowFocus = False
        Me.coldteTespitTarihi.Width = 99
        '
        'colsDovizCinsi
        '
        Me.colsDovizCinsi.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlDark
        Me.colsDovizCinsi.AppearanceCell.Options.UseBackColor = True
        Me.colsDovizCinsi.Caption = "PB"
        Me.colsDovizCinsi.FieldName = "sDovizCinsi"
        Me.colsDovizCinsi.Name = "colsDovizCinsi"
        Me.colsDovizCinsi.OptionsColumn.AllowEdit = False
        Me.colsDovizCinsi.OptionsColumn.AllowFocus = False
        Me.colsDovizCinsi.Visible = True
        Me.colsDovizCinsi.VisibleIndex = 2
        Me.colsDovizCinsi.Width = 33
        '
        'colsRenkAdi1
        '
        Me.colsRenkAdi1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colsRenkAdi1.AppearanceCell.Options.UseBackColor = True
        Me.colsRenkAdi1.Caption = "Renk"
        Me.colsRenkAdi1.FieldName = "sRenkAdi"
        Me.colsRenkAdi1.Name = "colsRenkAdi1"
        Me.colsRenkAdi1.OptionsColumn.AllowFocus = False
        Me.colsRenkAdi1.Visible = True
        Me.colsRenkAdi1.VisibleIndex = 3
        '
        'colsKavala1
        '
        Me.colsKavala1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colsKavala1.AppearanceCell.Options.UseBackColor = True
        Me.colsKavala1.Caption = "Kavala"
        Me.colsKavala1.FieldName = "sKavala"
        Me.colsKavala1.Name = "colsKavala1"
        Me.colsKavala1.OptionsColumn.AllowFocus = False
        Me.colsKavala1.Visible = True
        Me.colsKavala1.VisibleIndex = 4
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.kisayol_model
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.ds_tbStokAcilim
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GridControl1.Location = New System.Drawing.Point(2, 66)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(84, 196)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        Me.GridControl1.Visible = False
        '
        'kisayol_model
        '
        Me.kisayol_model.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem17, Me.MenuItem14, Me.MenuItem13})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Görünümü Kaydet"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 2
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem17.Text = "Görünümü Yazdır"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 3
        Me.MenuItem14.Text = "-"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 4
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem13.Text = "Fiyat Seç"
        '
        'ds_tbStokAcilim
        '
        Me.ds_tbStokAcilim.DataSetName = "NewDataSet"
        Me.ds_tbStokAcilim.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbStokAcilim.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nStokID"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sModel"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sKodu"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sRenk"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sBeden"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnStokID, Me.colsModel, Me.colsKodu, Me.colsRenk, Me.colsBeden, Me.colsKavala, Me.colsRenkAdi})
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 12
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colnStokID
        '
        Me.colnStokID.Caption = "nStokID"
        Me.colnStokID.FieldName = "nStokID"
        Me.colnStokID.Name = "colnStokID"
        '
        'colsModel
        '
        Me.colsModel.Caption = "Model"
        Me.colsModel.FieldName = "sModel"
        Me.colsModel.Name = "colsModel"
        Me.colsModel.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sModel", "{0} Kayıt")})
        Me.colsModel.Visible = True
        Me.colsModel.VisibleIndex = 0
        Me.colsModel.Width = 83
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "sKodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        '
        'colsRenk
        '
        Me.colsRenk.Caption = "Renk"
        Me.colsRenk.FieldName = "sRenk"
        Me.colsRenk.Name = "colsRenk"
        '
        'colsBeden
        '
        Me.colsBeden.Caption = "Beden"
        Me.colsBeden.FieldName = "sBeden"
        Me.colsBeden.Name = "colsBeden"
        Me.colsBeden.Visible = True
        Me.colsBeden.VisibleIndex = 2
        Me.colsBeden.Width = 57
        '
        'colsKavala
        '
        Me.colsKavala.Caption = "Kavala"
        Me.colsKavala.FieldName = "sKavala"
        Me.colsKavala.Name = "colsKavala"
        '
        'colsRenkAdi
        '
        Me.colsRenkAdi.Caption = "Renk Adı"
        Me.colsRenkAdi.FieldName = "sRenkAdi"
        Me.colsRenkAdi.Name = "colsRenkAdi"
        Me.colsRenkAdi.Visible = True
        Me.colsRenkAdi.VisibleIndex = 1
        Me.colsRenkAdi.Width = 110
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.GridControl3)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(820, 64)
        Me.PanelControl4.TabIndex = 0
        '
        'GridControl3
        '
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(2, 2)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(816, 60)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.Empty.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView3.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colStatus, Me.collMiktar, Me.collTutar, Me.colnStokID1, Me.colsKodu1, Me.colsAciklama1, Me.coldteIslemTarihi, Me.colnFirmaID, Me.colnMusteriID, Me.colsFisTipi, Me.coldteFisTarihi, Me.collFisNo, Me.colnGirisCikis, Me.colsDepo, Me.colsFiyatTipi1, Me.collBrutFiyat, Me.collBrutTutar, Me.colnIskontoYuzdesi, Me.colnKdvOrani, Me.collIskontoTutari, Me.colsHareketTipi, Me.colnStokFisiID, Me.colnAlisverisID, Me.colsHesapKodu, Me.colsHesapAdi, Me.collFiyati})
        Me.GridView3.CustomizationFormBounds = New System.Drawing.Rectangle(719, 237, 208, 173)
        Me.GridView3.DetailHeight = 160
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.Navy
        StyleFormatCondition4.Appearance.Options.UseForeColor = True
        StyleFormatCondition4.ApplyToRow = True
        StyleFormatCondition4.Column = Me.colStatus
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition4.Tag = "SonAlis"
        StyleFormatCondition4.Value1 = "SonAlis"
        StyleFormatCondition5.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition5.Appearance.Options.UseForeColor = True
        StyleFormatCondition5.ApplyToRow = True
        StyleFormatCondition5.Column = Me.colStatus
        StyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition5.Tag = "SonSatis"
        StyleFormatCondition5.Value1 = "SonSatis"
        Me.GridView3.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition4, StyleFormatCondition5})
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.GroupFormat = "{0}: {1} {2}"
        Me.GridView3.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView3.IndicatorWidth = 12
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsCustomization.AllowSort = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'collMiktar
        '
        Me.collMiktar.Caption = "Miktar"
        Me.collMiktar.DisplayFormat.FormatString = "#,0.00##"
        Me.collMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMiktar.FieldName = "lMiktar"
        Me.collMiktar.Name = "collMiktar"
        Me.collMiktar.Visible = True
        Me.collMiktar.VisibleIndex = 2
        Me.collMiktar.Width = 52
        '
        'collTutar
        '
        Me.collTutar.Caption = "Tutar"
        Me.collTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collTutar.FieldName = "lTutar"
        Me.collTutar.Name = "collTutar"
        Me.collTutar.Visible = True
        Me.collTutar.VisibleIndex = 4
        Me.collTutar.Width = 65
        '
        'colnStokID1
        '
        Me.colnStokID1.Caption = "Stok ID"
        Me.colnStokID1.FieldName = "nStokID"
        Me.colnStokID1.Name = "colnStokID1"
        '
        'colsKodu1
        '
        Me.colsKodu1.Caption = "Kodu"
        Me.colsKodu1.FieldName = "sKodu"
        Me.colsKodu1.Name = "colsKodu1"
        '
        'colsAciklama1
        '
        Me.colsAciklama1.Caption = "Açıklama"
        Me.colsAciklama1.FieldName = "sAciklama"
        Me.colsAciklama1.Name = "colsAciklama1"
        '
        'coldteIslemTarihi
        '
        Me.coldteIslemTarihi.Caption = "İşlem Tarihi"
        Me.coldteIslemTarihi.FieldName = "dteIslemTarihi"
        Me.coldteIslemTarihi.Name = "coldteIslemTarihi"
        '
        'colnFirmaID
        '
        Me.colnFirmaID.Caption = "FirmaID"
        Me.colnFirmaID.FieldName = "nFirmaID"
        Me.colnFirmaID.Name = "colnFirmaID"
        '
        'colnMusteriID
        '
        Me.colnMusteriID.Caption = "MusteriID"
        Me.colnMusteriID.FieldName = "nMusteriID"
        Me.colnMusteriID.Name = "colnMusteriID"
        '
        'colsFisTipi
        '
        Me.colsFisTipi.Caption = "FisTipi"
        Me.colsFisTipi.FieldName = "sFisTipi"
        Me.colsFisTipi.Name = "colsFisTipi"
        Me.colsFisTipi.Visible = True
        Me.colsFisTipi.VisibleIndex = 6
        Me.colsFisTipi.Width = 42
        '
        'coldteFisTarihi
        '
        Me.coldteFisTarihi.Caption = "Fiş Tarihi"
        Me.coldteFisTarihi.FieldName = "dteFisTarihi"
        Me.coldteFisTarihi.Name = "coldteFisTarihi"
        Me.coldteFisTarihi.Visible = True
        Me.coldteFisTarihi.VisibleIndex = 5
        Me.coldteFisTarihi.Width = 85
        '
        'collFisNo
        '
        Me.collFisNo.Caption = "Fiş No"
        Me.collFisNo.FieldName = "lFisNo"
        Me.collFisNo.Name = "collFisNo"
        Me.collFisNo.Visible = True
        Me.collFisNo.VisibleIndex = 7
        Me.collFisNo.Width = 50
        '
        'colnGirisCikis
        '
        Me.colnGirisCikis.Caption = "Giriş/Çıkış"
        Me.colnGirisCikis.FieldName = "nGirisCikis"
        Me.colnGirisCikis.Name = "colnGirisCikis"
        '
        'colsDepo
        '
        Me.colsDepo.Caption = "Depo"
        Me.colsDepo.FieldName = "sDepo"
        Me.colsDepo.Name = "colsDepo"
        '
        'colsFiyatTipi1
        '
        Me.colsFiyatTipi1.Caption = "FiyatTipi"
        Me.colsFiyatTipi1.FieldName = "sFiyatTipi"
        Me.colsFiyatTipi1.Name = "colsFiyatTipi1"
        '
        'collBrutFiyat
        '
        Me.collBrutFiyat.Caption = "Brüt Fiyat"
        Me.collBrutFiyat.DisplayFormat.FormatString = "#,0.00##"
        Me.collBrutFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutFiyat.FieldName = "lBrutFiyat"
        Me.collBrutFiyat.Name = "collBrutFiyat"
        '
        'collBrutTutar
        '
        Me.collBrutTutar.Caption = "Brüt Tutar"
        Me.collBrutTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collBrutTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutTutar.FieldName = "lBrutTutar"
        Me.collBrutTutar.Name = "collBrutTutar"
        '
        'colnIskontoYuzdesi
        '
        Me.colnIskontoYuzdesi.Caption = "% İsk."
        Me.colnIskontoYuzdesi.FieldName = "nIskontoYuzdesi"
        Me.colnIskontoYuzdesi.Name = "colnIskontoYuzdesi"
        Me.colnIskontoYuzdesi.Visible = True
        Me.colnIskontoYuzdesi.VisibleIndex = 8
        Me.colnIskontoYuzdesi.Width = 40
        '
        'colnKdvOrani
        '
        Me.colnKdvOrani.Caption = "Kdv"
        Me.colnKdvOrani.FieldName = "nKdvOrani"
        Me.colnKdvOrani.Name = "colnKdvOrani"
        Me.colnKdvOrani.Visible = True
        Me.colnKdvOrani.VisibleIndex = 10
        Me.colnKdvOrani.Width = 39
        '
        'collIskontoTutari
        '
        Me.collIskontoTutari.Caption = "Iskonto"
        Me.collIskontoTutari.DisplayFormat.FormatString = "#,0.00"
        Me.collIskontoTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collIskontoTutari.FieldName = "lIskontoTutari"
        Me.collIskontoTutari.Name = "collIskontoTutari"
        Me.collIskontoTutari.Visible = True
        Me.collIskontoTutari.VisibleIndex = 9
        Me.collIskontoTutari.Width = 49
        '
        'colsHareketTipi
        '
        Me.colsHareketTipi.Caption = "HT"
        Me.colsHareketTipi.FieldName = "sHareketTipi"
        Me.colsHareketTipi.Name = "colsHareketTipi"
        '
        'colnStokFisiID
        '
        Me.colnStokFisiID.Caption = "Stok Fişi ID"
        Me.colnStokFisiID.FieldName = "nStokFisiID"
        Me.colnStokFisiID.Name = "colnStokFisiID"
        '
        'colnAlisverisID
        '
        Me.colnAlisverisID.Caption = "Alışveriş ID"
        Me.colnAlisverisID.FieldName = "nAlisverisID"
        Me.colnAlisverisID.Name = "colnAlisverisID"
        '
        'colsHesapKodu
        '
        Me.colsHesapKodu.Caption = "Hesap Kodu"
        Me.colsHesapKodu.FieldName = "sHesapKodu"
        Me.colsHesapKodu.Name = "colsHesapKodu"
        '
        'colsHesapAdi
        '
        Me.colsHesapAdi.Caption = "HesapAdi"
        Me.colsHesapAdi.FieldName = "sHesapAdi"
        Me.colsHesapAdi.Name = "colsHesapAdi"
        Me.colsHesapAdi.Visible = True
        Me.colsHesapAdi.VisibleIndex = 1
        Me.colsHesapAdi.Width = 111
        '
        'collFiyati
        '
        Me.collFiyati.Caption = "Fiyat"
        Me.collFiyati.DisplayFormat.FormatString = "#,0.00##"
        Me.collFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collFiyati.FieldName = "lFiyat"
        Me.collFiyati.Name = "collFiyati"
        Me.collFiyati.Visible = True
        Me.collFiyati.VisibleIndex = 3
        Me.collFiyati.Width = 60
        '
        'ps
        '
        Me.ps.Links.AddRange(New Object() {Me.printlink1, Me.printlink2})
        '
        'printlink1
        '
        Me.printlink1.Component = Me.GridControl1
        '
        '
        '
        Me.printlink1.ImageCollection.ImageStream = CType(resources.GetObject("printlink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Stok Model/Renk/Beden", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Stok Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'printlink2
        '
        Me.printlink2.Component = Me.GridControl2
        '
        '
        '
        Me.printlink2.ImageCollection.ImageStream = CType(resources.GetObject("printlink2.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink2.Margins = New System.Drawing.Printing.Margins(20, 0, 60, 60)
        Me.printlink2.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Stok Fiyatları", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Stok Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink2.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink2.PrintingSystem = Me.ps
        Me.printlink2.PrintingSystemBase = Me.ps
        '
        'frm_stok_fiyatlandir_model
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
        Me.Name = "frm_stok_fiyatlandir_model"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Fiyatlandır..."
        CType(Me.sec_tutar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.sec_sRenk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sFiyatTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        Me.PanelControl5.PerformLayout()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbStokBakiyesi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nFiyatlandirma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbStokFiyat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbStokAcilim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink2.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public nStokID
    Public sKodu
    Public sModel
    Public sRenk As String
    Public sBeden As String
    Public sKavala As String
    Public kullanici
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_stok As DataSet
    Dim ds_nStokID As DataSet
    Dim ds_tbFiyatTipi As DataSet
    Dim ds_tbFiyatlandirma As DataSet
    Dim ds_tbStokSonHareket As DataSet
    Dim yuklendi As Boolean = False
    Public nAST As Integer = 0
    Dim maliyet As Decimal = 0
    Private Sub frm_stok_fiyatlandir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If sModel = "" Then
            stok_sec()
        Else
            txt_musteriNo.EditValue = sModel
            dataload(sModel)
        End If
        dataload_tbFiyatlandirma()
        dataload_tbFiyatTipi()
        'txt_dteFiyatTespitTarihi.EditValue = dteSistemTarihi
        GridControl2.Focus()
        GridControl2.Select()

        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        GridView1.ClearColumnsFilter()
        If Trim(sRenk) <> "" Then
            GridView1.Columns("sRenk").FilterInfo = New ColumnFilterInfo("[sRenk] LIKE '" & sRenk & "%'")
        End If
        If Trim(sBeden) <> "" Then
            GridView1.Columns("sBeden").FilterInfo = New ColumnFilterInfo("[sBeden] LIKE '" & sBeden & "%'")
        End If
        If Trim(sKavala) <> "" Then
            GridView1.Columns("sKavala").FilterInfo = New ColumnFilterInfo("[sKavala] LIKE '" & sKavala & "%'")
        End If
    End Sub
    Private Sub dataload_tbFiyatlandirma()
        ds_tbFiyatlandirma = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFiyatlandirma"))
        txt_nFiyatlandirma.Properties.DataSource = ds_tbFiyatlandirma.Tables(0)
    End Sub
    Public Sub Dataload_tbStokBakiyesi(ByVal sModel As String)
        Try
            ds_tbStokBakiyesi.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST(ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS MONEY) AS  nGiris, CAST(ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS MONEY) AS nGirisIade, CAST(ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS MONEY) AS nCikis, CAST(ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS MONEY) AS nCikisIade, CAST(ISNULL((SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1)), 0) AS MONEY) AS nKalan FROM tbStokFisiDetayi WITH (INDEX (tbStokFisiDetayi_index8)) INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStok.sKodu = '" & sModel & "') AND tbStokFisiDetayi.sFisTipi NOT IN ('T','DG','DC') ")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST(ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS MONEY) AS  nGiris, CAST(ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS MONEY) AS nGirisIade, CAST(ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS MONEY) AS nCikis, CAST(ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS MONEY) AS nCikisIade, (SELECT     SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) AS nKalan FROM         tbStokFisiDetayi INNER JOIN                       tbStok Stok ON tbStokFisiDetayi.nStokID = Stok.nStokID Where Stok.sModel = '" & sModel & "') nKalan FROM tbStokFisiDetayi WITH (INDEX (tbStokFisiDetayi_index8)) INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStok.sKodu = '" & sModel & "') AND tbStokFisiDetayi.sFisTipi NOT IN ('T','DG','DC') ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbStokBakiyesi, "Table1")
        conn.Close()
    End Sub
    Private Sub dataload_tbFiyatTipi()
        ds_tbFiyatTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFiyatTipi,sAciklama FROM         tbFiyatTipi Where (nAST <> 4) and (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%') Order by sFiyatTipi"))
        Dim dr As DataRow
        sec_sFiyatTipi.Properties.Items.Clear()
        For Each dr In ds_tbFiyatTipi.Tables(0).Rows
            sec_sFiyatTipi.Properties.Items.Add(Trim(dr("sFiyatTipi")))
        Next
        'txt_sFiyatTipi.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
    End Sub
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Başlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "İçerir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
        ElseIf kriter = "Boş" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklı" Then
            sorgu_kriter = " <> '" & deger & "' "
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = " >  '" & deger & "' "
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = " < '" & deger & "' "
        ElseIf kriter = "Eşittir" Then
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
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "\Model")
        GridView2.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "\Fiyat")
        'GridView3.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "\Analiz")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView2.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView3.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Label1.Text = Sorgu_sDil(Label1.Text, sDil)
        LabelControl3.Text = Sorgu_sDil(LabelControl3.Text, sDil)
        LabelControl4.Text = Sorgu_sDil(LabelControl4.Text, sDil)
        LabelControl5.Text = Sorgu_sDil(LabelControl5.Text, sDil)
        LabelControl6.Text = Sorgu_sDil(LabelControl6.Text, sDil)
        LabelControl7.Text = Sorgu_sDil(LabelControl7.Text, sDil)
        LabelControl8.Text = Sorgu_sDil(LabelControl8.Text, sDil)
        LabelControl9.Text = Sorgu_sDil(LabelControl9.Text, sDil)
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "\Model")
        GridView2.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "\Fiyat")
        'GridView3.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "\Analiz")
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
            nStokID = dr1("nStokID")
            sKodu = dr1("sKodu")
            sModel = dr1("sModel")
            txt_musteriNo.EditValue = sModel
            stok_kontrol()
            dr1 = Nothing
        End If
    End Sub
    Private Sub stok_kontrol()
        If Trim(txt_musteriNo.EditValue).ToString <> "" Then
            Dim kontrol = sorgu_stok_kontrol(txt_musteriNo.EditValue)
            If kontrol = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Kayıt Bulunumadı...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf kontrol = 1 Then
                dataload_stok(txt_musteriNo.EditValue)
                Dim dr As DataRow
                For Each dr In ds_stok.Tables(0).Rows
                    'txt_Musteri.EditValue = dr("MUSTERI")
                    sKodu = dr("sKodu")
                    nStokID = dr("nStokID")
                    sModel = dr("sModel")
                    dataload(sModel)
                Next
                dr = Nothing
            End If
        End If
    End Sub
    Public Function sorgu_stok_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu like '" & kod & "%') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         tbStok " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_stok(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (sKodu like  '" & kod & "%') "
        ds_stok = sorgu(sorgu_query("SELECT     top 1 nStokID,sKodu,sAciklama,sModel FROM         tbStok " & kriter & ""))
    End Sub
    Private Sub dataload(ByVal sModel As String)
        Dataload_tbStok(sModel)
        Dataload_tbStokAcilimi(sModel)
        Dataload_tbStokFiyat(sModel)
        Dataload_tbStokSonHareket(sModel)
        GridControl3.DataSource = ds_tbStokSonHareket.Tables(0)
        GridControl3.DataMember = Nothing
        yuklendi = True
    End Sub
    Public Sub Dataload_tbStok(ByVal sModel As String)
        Try
            ds_tbStok.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 * From tbStok WHERE sModel ='" & sModel & "'")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbStok, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbStokAcilimi(ByVal sModel As String)
        Try
            ds_tbStokAcilim.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokID, sModel, sKodu,sAciklama, sRenk, sBeden ,sKavala,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi FROM tbStok WHERE sModel = '" & sModel & "'")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbStokAcilim, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbStokSonHareket(ByVal sModel As String)
        ds_tbStokSonHareket = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT TOP 1 'SonAlis' AS Status, tbStokFisiDetayi.lGirisMiktar1 AS lMiktar, tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 as lFiyat,tbStokFisiDetayi.lGirisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lTutar, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStokFisiDetayi.dteIslemTarihi, tbStokFisiDetayi.nFirmaID, tbStokFisiDetayi.nMusteriID, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.nIskontoYuzdesi, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.sHareketTipi, tbStokFisiDetayi.nStokFisiID, tbStokFisiDetayi.nAlisverisID, sHesapKodu = CASE WHEN tbStokFisiDetayi.nMusteriID > 0 THEN CAST(tbMusteri.lKodu AS NVARCHAR(20)) ELSE tbFirma.sKodu END, sHesapAdi = CASE WHEN tbStokFisiDetayi.nMusteriID > 0 THEN tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi ELSE tbFirma.sAciklama END FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk LEFT OUTER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID LEFT OUTER JOIN tbAlisVeris a ON tbStokFisiDetayi.nAlisverisID = a.nAlisverisID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 and tbStok.sKodu = '" & sModel & "' ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS Ta UNION ALL SELECT * FROM (SELECT TOP 1 'SonSatis' AS Status, tbStokFisiDetayi.lCikisMiktar1 AS lMiktar, tbStokFisiDetayi.lCikisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 as lFiyat,tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lTutar, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStokFisiDetayi.dteIslemTarihi, tbStokFisiDetayi.nFirmaID, tbStokFisiDetayi.nMusteriID, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.nIskontoYuzdesi, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.sHareketTipi, tbStokFisiDetayi.nStokFisiID, tbStokFisiDetayi.nAlisverisID, sHesapKodu = CASE WHEN tbStokFisiDetayi.nMusteriID > 0 THEN CAST(tbMusteri.lKodu AS NVARCHAR(20)) ELSE tbFirma.sKodu END, sHesapAdi = CASE WHEN tbStokFisiDetayi.nMusteriID > 0 THEN tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi ELSE tbFirma.sAciklama END FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk LEFT OUTER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID LEFT OUTER JOIN tbAlisVeris a ON tbStokFisiDetayi.nAlisverisID = a.nAlisverisID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi NOT IN ('T', 'DC')) AND (tbFisTipi.bSatismi = 1) AND tbStokFisiDetayi.nGirisCikis = 3 and tbStok.sKodu = '" & sModel & "' ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS Ts"))
        GridControl3.DataSource = ds_tbStokSonHareket.Tables(0)
        GridControl3.DataMember = Nothing
        GridControl3.Enabled = True
        GridView3.OptionsBehavior.Editable = False
        GridView3.OptionsBehavior.ReadOnly = True
    End Sub
    Public Sub Dataload_tbStokFiyat(ByVal sModel As String, Optional ByVal nAST As Integer = 0)
        Try
            ds_tbStokFiyat.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim sFiyatlar As String = ""
        Dim drb As DataRow
        Dim sBedenler As New ListBox
        Dim nIndex As Int16 = 10
        For Each drb In ds_tbStokAcilim.Tables(0).Rows
            drb("sBeden") = Trim(drb("sBeden").ToString)
            drb("sRenkAdi") = Trim(drb("sRenkAdi"))
            If drb("sBeden") = "" Then
                drb("sBeden") = "Yok"
            End If
            If sBedenler.Items.Contains(drb("sBeden")) = False And drb("sBeden") <> "" Then
                If drb("sBeden") = "Yok" Then
                    sFiyatlar += " ,(SELECT     ISNULL(tbStokFiyati.lFiyat, 0) AS lFiyat FROM         tbStokFiyati INNER JOIN                       tbStok tbStoklar ON tbStokFiyati.nStokID = tbStoklar.nStokID AND sFiyatTipi = tbFiyatTipi.sFiyatTipi and tbStoklar.sModel = tbStok.sModel and tbStoklar.sRenk = tbStok.sRenk and tbStoklar.sKavala = tbStok.sKavala and tbStoklar.sBeden = '') AS '" & drb("sBeden") & "' "
                Else
                    sFiyatlar += " ,(SELECT     ISNULL(tbStokFiyati.lFiyat, 0) AS lFiyat FROM         tbStokFiyati INNER JOIN                       tbStok tbStoklar ON tbStokFiyati.nStokID = tbStoklar.nStokID AND sFiyatTipi = tbFiyatTipi.sFiyatTipi and tbStoklar.sModel = tbStok.sModel and tbStoklar.sRenk = tbStok.sRenk and tbStoklar.sKavala = tbStok.sKavala and tbStoklar.sBeden = '" & drb("sBeden") & "') AS '" & drb("sBeden").ToString.Replace(" ", "") & "' "
                End If
                drb("sBeden") = drb("sBeden").ToString.Replace(" ", "")
                If GridView2.Columns.Contains(GridView2.Columns(drb("sBeden").ToString)) = False Then
                    GridView2.Columns.AddField(drb("sBeden").ToString)
                    GridView2.Columns(drb("sBeden").ToString).Visible = True
                    GridView2.Columns(drb("sBeden").ToString).VisibleIndex = nIndex
                    GridView2.Columns(drb("sBeden").ToString).FieldName = drb("sBeden").ToString
                    GridView2.Columns(drb("sBeden").ToString).ColumnEdit = Me.sec_tutar
                    GridView2.Columns(drb("sBeden").ToString).Caption = drb("sBeden").ToString
                    'GridView2.Columns(drb("sBeden").ToString).AppearanceCell.BackColor = Color.Yellow
                    GridView2.Columns(drb("sBeden").ToString).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    GridView2.Columns(drb("sBeden").ToString).DisplayFormat.FormatString = "#,0.##"
                    'GridView2.Columns(drb("sBeden").ToString).SummaryItem.DisplayFormat = "{0:#,0.##}"
                    'GridView2.Columns(drb("sBeden").ToString).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    sBedenler.Items.Add(drb("sBeden"))
                    nIndex += 1
                End If
            End If
            If sec_sRenk.Properties.Items.Contains("") = False Then
                sec_sRenk.Properties.Items.Add("")
            End If
            If sec_sRenk.Properties.Items.Contains(drb("sRenkAdi")) = False Then
                sec_sRenk.Properties.Items.Add(drb("sRenkAdi"))
            End If
        Next
        sBeden = Nothing
        drb = Nothing
        Dim kriter_nAST As String
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If nAST = 0 Then
            kriter_nAST = " AND (tbFiyatTipi.nAST <> 4)"
        Else
            kriter_nAST = " AND (tbFiyatTipi.nAST = " & nAST & ")"
        End If
        If yetki_kontrol(kullanici, "Stok AlisFiyatini Gor", False, 1) = False Then
            kriter_nAST += " AND (tbFiyatTipi.sFiyatTipi <> '" & sFiyatA & "')"
        End If
        If yetki_kontrol(kullanici, "Stok MaliyetFiyatini Gor", False, 1) = False Then
            kriter_nAST += " AND (tbFiyatTipi.sFiyatTipi <> '" & sFiyatM & "')"
        End If
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT RTRIM(tbFiyatTipi.sFiyatTipi) as sFiyatTipi, tbFiyatTipi.sAciklama,tbFiyatTipi.sDovizCinsi,  ISNULL(tbStokFiyati.lFiyat, 0) AS lFiyat, tbStokFiyati.dteFiyatTespitTarihi,Cast(0 as Money) as Oran,tbRenk.sRenkAdi, tbStok.sKavala " & sFiyatlar & " FROM tbStok INNER JOIN tbStokFiyati ON tbStok.nStokID = tbStokFiyati.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk RIGHT OUTER JOIN tbFiyatTipi ON tbStokFiyati.sFiyatTipi = tbFiyatTipi.sFiyatTipi AND tbStokFiyati.nStokID IN (SELECT nStokID FROM tbStok WHERE sModel = '" & sModel & "') WHERE (tbFiyatTipi.sFiyatTipi <> '') " & kriter_nAST & "  ")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT RTRIM(tbFiyatTipi.sFiyatTipi) AS sFiyatTipi, tbFiyatTipi.sAciklama, tbFiyatTipi.sDovizCinsi, tbStok.sKavala, tbStok.sRenk, tbRenk.sRenkAdi, CAST(0 AS Money) AS lFiyat, CAST(0 AS Money) AS Oran " & sFiyatlar & " FROM tbStok INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk CROSS JOIN tbFiyatTipi WHERE (tbStok.sModel = '" & sModel & "') AND (tbFiyatTipi.sFiyatTipi <> '') " & kriter_nAST & "  ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbStokFiyat, "Table1")
        conn.Close()
        maliyet = 0
        Dim dr1 As DataRow
        For Each dr1 In ds_tbStokFiyat.Tables(0).Rows
            If Trim(dr1("sFiyatTipi").ToString) = Trim(sFiyatM.ToString) Then
                maliyet = dr1("lFiyat")
            End If
        Next
        dr1 = Nothing
        Dim dr2 As DataRow
        If maliyet <> 0 Then
            For Each dr2 In ds_tbStokFiyat.Tables(0).Rows
                If dr2("lFiyat") <> 0 Then
                    dr2("Oran") = ((dr2("lFiyat") - maliyet) / maliyet) * 100
                End If
            Next
        End If
        dr2 = Nothing
        GridControl2.DataSource = ds_tbStokFiyat.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Public Sub Dataload_tbStokFiyat_sRenk(ByVal sModel As String, ByVal sRenk As String)
        Try
            ds_tbStokFiyat.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        Dim kriter_nAST As String = ""
        If yetki_kontrol(kullanici, "Stok AlisFiyatini Gor", False, 1) = False Then
            kriter_nAST += " AND (tbFiyatTipi.sFiyatTipi <> '" & sFiyatA & "')"
        End If
        If yetki_kontrol(kullanici, "Stok MaliyetFiyatini Gor", False, 1) = False Then
            kriter_nAST += " AND (tbFiyatTipi.sFiyatTipi <> '" & sFiyatM & "')"
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT RTRIM(tbFiyatTipi.sFiyatTipi) as sFiyatTipi, tbFiyatTipi.sAciklama,  ISNULL(tbStokFiyati.lFiyat, 0) AS lFiyat, tbStokFiyati.dteFiyatTespitTarihi,Cast(0 as Money) as Oran FROM tbFiyatTipi LEFT OUTER JOIN tbStokFiyati ON tbFiyatTipi.sFiyatTipi = tbStokFiyati.sFiyatTipi AND tbStokFiyati.nStokID IN (SELECT nStokID FROM tbStok WHERE sModel = '" & sModel & "' and sRenk = '" & sRenk & "') WHERE (tbFiyatTipi.sFiyatTipi <> '') AND (tbFiyatTipi.nAST <> 4) " & kriter_nAST & "  ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbStokFiyat, "Table1")
        conn.Close()
        maliyet = 0
        Dim dr1 As DataRow
        For Each dr1 In ds_tbStokFiyat.Tables(0).Rows
            If Trim(dr1("sFiyatTipi").ToString) = Trim(sFiyatM.ToString) Then
                maliyet = dr1("lFiyat")
            End If
        Next
        dr1 = Nothing
        Dim dr2 As DataRow
        If maliyet <> 0 Then
            For Each dr2 In ds_tbStokFiyat.Tables(0).Rows
                If dr2("lFiyat") <> 0 Then
                    dr2("Oran") = ((dr2("lFiyat") - maliyet) / maliyet) * 100
                End If
            Next
        End If
        dr2 = Nothing
        GridControl2.DataSource = ds_tbStokFiyat.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Public Sub Dataload_tbStokFiyat_sRenk_sBeden(ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String)
        Try
            ds_tbStokFiyat.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        Dim kriter_nAST As String = ""
        If yetki_kontrol(kullanici, "Stok AlisFiyatini Gor", False, 1) = False Then
            kriter_nAST += " AND (tbFiyatTipi.sFiyatTipi <> '" & sFiyatA & "')"
        End If
        If yetki_kontrol(kullanici, "Stok MaliyetFiyatini Gor", False, 1) = False Then
            kriter_nAST += " AND (tbFiyatTipi.sFiyatTipi <> '" & sFiyatM & "')"
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT RTRIM(tbFiyatTipi.sFiyatTipi) as sFiyatTipi, tbFiyatTipi.sAciklama,  ISNULL(tbStokFiyati.lFiyat, 0) AS lFiyat, tbStokFiyati.dteFiyatTespitTarihi,Cast(0 as Money) as Oran FROM tbFiyatTipi LEFT OUTER JOIN tbStokFiyati ON tbFiyatTipi.sFiyatTipi = tbStokFiyati.sFiyatTipi AND tbStokFiyati.nStokID IN (SELECT nStokID FROM tbStok WHERE sModel = '" & sModel & "' and sRenk ='" & sRenk & "' and sBeden = '" & sBeden & "') WHERE (tbFiyatTipi.sFiyatTipi <> '') AND (tbFiyatTipi.nAST <> 4) " & kriter_nAST & " ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbStokFiyat, "Table1")
        conn.Close()
        maliyet = 0
        Dim dr1 As DataRow
        For Each dr1 In ds_tbStokFiyat.Tables(0).Rows
            If Trim(dr1("sFiyatTipi").ToString) = Trim(sFiyatM.ToString) Then
                maliyet = dr1("lFiyat")
            End If
        Next
        dr1 = Nothing
        Dim dr2 As DataRow
        If maliyet <> 0 Then
            For Each dr2 In ds_tbStokFiyat.Tables(0).Rows
                If dr2("lFiyat") <> 0 Then
                    dr2("Oran") = ((dr2("lFiyat") - maliyet) / maliyet) * 100
                End If
            Next
        End If
        dr2 = Nothing
        GridControl2.DataSource = ds_tbStokFiyat.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Function sorgu_tbStokFiyati_kontrol(ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String) As Decimal
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim kayitsayisi As Int64
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        If nFiyatlandirma = 0 Then
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT COUNT(*) AS Kayit FROM tbFiyatTipi INNER JOIN (SELECT DISTINCT (sFiyatTipi) AS sFiyatTipi , lFiyat , dteFiyatTespitTarihi FROM tbStokFiyati , tbStok WHERE tbStokFiyati.nStokID = tbStok.nStokID AND sFiyatTipi = '" & sFiyatTipi & "' AND tbStok.sModel = '" & sModel & "') Fiyat ON tbFiyatTipi.sFiyatTipi = Fiyat.sFiyatTipi WHERE (tbFiyatTipi.sFiyatTipi <> '') AND (tbFiyatTipi.sFiyatTipi = '" & sFiyatTipi & "')"
        ElseIf nFiyatlandirma = 1 Then
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT COUNT(*) AS Kayit FROM tbFiyatTipi INNER JOIN (SELECT DISTINCT (sFiyatTipi) AS sFiyatTipi , lFiyat , dteFiyatTespitTarihi FROM tbStokFiyati , tbStok WHERE tbStokFiyati.nStokID = tbStok.nStokID AND sFiyatTipi = '" & sFiyatTipi & "' AND tbStok.sModel = '" & sModel & "' and tbStok.sRenk = '" & sRenk & "') Fiyat ON tbFiyatTipi.sFiyatTipi = Fiyat.sFiyatTipi WHERE (tbFiyatTipi.sFiyatTipi <> '') AND (tbFiyatTipi.sFiyatTipi = '" & sFiyatTipi & "')"
        ElseIf nFiyatlandirma = 2 Then
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT COUNT(*) AS Kayit FROM tbFiyatTipi INNER JOIN (SELECT DISTINCT (sFiyatTipi) AS sFiyatTipi , lFiyat , dteFiyatTespitTarihi FROM tbStokFiyati , tbStok WHERE tbStokFiyati.nStokID = tbStok.nStokID AND sFiyatTipi = '" & sFiyatTipi & "' AND tbStok.sModel = '" & sModel & "'and tbStok.sRenk = '" & sRenk & "' and tbStok.sBeden = '" & sBeden & "') Fiyat ON tbFiyatTipi.sFiyatTipi = Fiyat.sFiyatTipi WHERE (tbFiyatTipi.sFiyatTipi <> '') AND (tbFiyatTipi.sFiyatTipi = '" & sFiyatTipi & "')"
        End If
        kayitsayisi = cmd.ExecuteScalar()
        con.Close()
        Return kayitsayisi
    End Function
    Private Sub tbStokFiyati_ekle_yeni(ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String, ByVal lFiyat As Decimal, ByVal dteFiyatTespitTarihi As DateTime, ByVal sKullaniciAdi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = "set implicit_transactions on "
        cmd.ExecuteNonQuery()
        If nFiyatlandirma = 0 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & sKullaniciAdi & "' , getdate ()  from tbStok where sModel = '" & sModel & "'"
        ElseIf nFiyatlandirma = 1 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & sKullaniciAdi & "' , getdate ()  from tbStok where sModel = '" & sModel & "' and sRenk ='" & sRenk & "'"
        ElseIf nFiyatlandirma = 2 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & sKullaniciAdi & "' , getdate ()  from tbStok where sModel = '" & sModel & "' and sRenk ='" & sRenk & "' and sBeden ='" & sBeden & "'"
        End If
        cmd.ExecuteNonQuery()
        cmd.CommandText = "IF @@TRANCOUNT > 0 COMMIT TRAN"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "set implicit_transactions off "
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFiyati_ekle_duzelt(ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String, ByVal lFiyat As Decimal, ByVal dteFiyatTespitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = "set implicit_transactions on "
        cmd.ExecuteNonQuery()
        If nFiyatlandirma = 0 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED update tbStokFiyati set lFiyat = " & lFiyat & " , dteFiyatTespitTarihi = '" & dteFiyatTespitTarihi & "' , dteKayitTarihi = getdate() from tbStok where tbStok.nStokID = tbStokFiyati.nStokID and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "'"
        ElseIf nFiyatlandirma = 1 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED update tbStokFiyati set lFiyat = " & lFiyat & " , dteFiyatTespitTarihi = '" & dteFiyatTespitTarihi & "' , dteKayitTarihi = getdate() from tbStok where tbStok.nStokID = tbStokFiyati.nStokID and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "'"
        ElseIf nFiyatlandirma = 2 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED update tbStokFiyati set lFiyat = " & lFiyat & " , dteFiyatTespitTarihi = '" & dteFiyatTespitTarihi & "' , dteKayitTarihi = getdate() from tbStok where tbStok.nStokID = tbStokFiyati.nStokID and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "' and sBeden = '" & sBeden & "' "
        End If
        cmd.ExecuteNonQuery()
        cmd.CommandText = "IF @@TRANCOUNT > 0 COMMIT TRAN"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "set implicit_transactions off "
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFiyati_ekle_sil(ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String, ByVal lFiyat As Decimal, ByVal dteFiyatTespitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = "set implicit_transactions on "
        cmd.ExecuteNonQuery()
        If nFiyatlandirma = 0 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED delete tbStokFiyati from tbStok where tbStok.nStokID = tbStokFiyati.nStokID       and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "'"
        ElseIf nFiyatlandirma = 1 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED delete tbStokFiyati from tbStok where tbStok.nStokID = tbStokFiyati.nStokID       and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "'"
        ElseIf nFiyatlandirma = 2 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED delete tbStokFiyati from tbStok where tbStok.nStokID = tbStokFiyati.nStokID       and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "' and sBeden ='" & sBeden & "'"
        End If
        cmd.ExecuteNonQuery()
        cmd.CommandText = "IF @@TRANCOUNT > 0 COMMIT TRAN"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "set implicit_transactions off "
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFiyatTarihcesi()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            Dim dr1 As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr1 = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Dim frm As New frm_stok_fiyat_tarihce
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokID")
            frm.sKodu = dr("sKodu")
            frm.sModel = dr("sModel")
            frm.sFiyatTipi = dr1("sFiyatTipi")
            frm.kullanici = kullanici
            frm.Label_stok.Text = Label_stok.Text
            'If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
            'End If
            Dim satir = GridView1.FocusedRowHandle
            GridView1.FocusedRowHandle = satir
            satir = Nothing
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_stok_hareket()
        Dim frm As New frm_stok_hareketleri
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = sKodu
        frm.sModel = sModel
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
        'frm.Label1.Text = txt_sAdi.Text & vbCrLf & frm.Label1.Text
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub analiz_stok_KarlilikAkisTablosu()
        Dim dr As DataRow
        dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
        Dim frm As New frm_Stok_Satis_Maliyetlendir
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.txt_sStokKodu.Text = sKodu
        frm.bAnaliz = True
        If yetki_kontrol(kullanici, "frm_Stok_KarlilikAkisTablosu") = True Then
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                If XtraMessageBox.Show(Sorgu_sDil("Maliyet Fiyatını Güncellemek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Dim lMaliyet As Decimal = 0
                    lMaliyet = frm.lbl_lSonAlisMaliyeti.Text
                    Dim dr1 As DataRow
                    Dim sayi As Integer = -1
                    Dim satir_sayi As Integer = -2
                    GridView2.ClearColumnsFilter()
                    For Each dr1 In ds_tbStokFiyat.Tables(0).Rows
                        sayi += 1
                        If dr1("sFiyatTipi") = sFiyatM Then
                            satir_sayi = sayi
                            GridView2.FocusedRowHandle = satir_sayi
                            GridView2.SelectRow(satir_sayi)
                            dr("lFiyat") = lMaliyet
                        End If
                    Next
                    If satir_sayi = -2 Then
                    Else
                        GridView2.FocusedColumn = collFiyat
                        GridView2.PostEditor()
                        dr("lFiyat") = lMaliyet
                        dr.EndEdit()
                        Fiyatlandir()
                    End If
                    dr1 = Nothing
                End If
            End If
        End If
        frm.Close()
        frm.Dispose()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If yuklendi = True Then
            If GridView1.RowCount > 0 Then
                Try
                    Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                    Label_stok.Text = dr("sAciklama").ToString
                    If Trim(dr("sRenk").ToString) <> "" Then
                        Label_stok.Text += " Renk : " & Trim(dr("sRenkAdi").ToString)
                    End If
                    If Trim(dr("sBeden").ToString) <> "" Then
                        Label_stok.Text += " Beden : " & Trim(dr("sBeden").ToString)
                    End If
                    If txt_nFiyatlandirma.EditValue = 0 Then
                    ElseIf txt_nFiyatlandirma.EditValue = 1 Then
                        Dataload_tbStokFiyat_sRenk(dr("sModel"), dr("sRenk"))
                    ElseIf txt_nFiyatlandirma.EditValue = 2 Then
                        Dataload_tbStokFiyat_sRenk_sBeden(dr("sModel"), dr("sRenk"), dr("sBeden"))
                    End If
                    Dataload_tbStokSonHareket(Trim(dr("sKodu").ToString))
                    Dataload_tbStokBakiyesi(Trim(dr("sKodu").ToString))
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub
    Private Sub GridView2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        Fiyatlandir()
    End Sub
    Private Sub Fiyatlandir()
        If GridView2.RowCount > 0 Then
            GridView2.PostEditor()
            Dim dr As DataRow
            Dim sayi As Int64 = 0
            Dim satir = GridView2.FocusedRowHandle
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            dr.EndEdit()
            If GridView2.FocusedColumn.Name.ToString = colOran.Name.ToString Then
                If maliyet <> 0 Then
                    dr(GridView2.FocusedColumn.FieldName) = maliyet * ((dr("Oran") + 100) / 100)
                End If
            End If
            'MsgBox(GridView2.FocusedColumn.Caption)
            Dim beden As String = GridView2.FocusedColumn.Caption
            If dr(GridView2.FocusedColumn.FieldName) = 0 Then
                tbStokFiyati_ekle_sil(txt_nFiyatlandirma.EditValue, sModel, dr("sRenk"), beden, dr("sFiyatTipi"), dr(GridView2.FocusedColumn.FieldName), Today)
            ElseIf dr(GridView2.FocusedColumn.FieldName) > 0 Then
                sayi = sorgu_tbStokFiyati_kontrol(txt_nFiyatlandirma.EditValue, sModel, dr("sRenk"), beden, dr("sFiyatTipi"))
                If sayi = 0 Then
                    tbStokFiyati_ekle_yeni(txt_nFiyatlandirma.EditValue, sModel, dr("sRenk"), beden, dr("sFiyatTipi"), dr(GridView2.FocusedColumn.FieldName), Today, kullaniciadi)
                ElseIf sayi = 1 Then
                    tbStokFiyati_ekle_duzelt(txt_nFiyatlandirma.EditValue, sModel, dr("sRenk"), beden, dr("sFiyatTipi"), dr(GridView2.FocusedColumn.FieldName), Today)
                End If
            ElseIf dr(GridView2.FocusedColumn.FieldName) < 0 Then
                dr(GridView2.FocusedColumn.FieldName) = 0
                tbStokFiyati_ekle_sil(txt_nFiyatlandirma.EditValue, sModel, dr("sRenk"), beden, dr("sFiyatTipi"), dr(GridView2.FocusedColumn.FieldName), Today)
            End If
            If txt_nFiyatlandirma.EditValue = 0 Then
                Dataload_tbStokFiyat(sModel)
            ElseIf txt_nFiyatlandirma.EditValue = 1 Then
                Dataload_tbStokFiyat(sModel)
                'Dataload_tbStokFiyat_sRenk(sModel, dr("sRenk"))
            ElseIf txt_nFiyatlandirma.EditValue = 2 Then
                Dataload_tbStokFiyat(sModel)
                'Dataload_tbStokFiyat_sRenk_sBeden(sModel, dr("sRenk"), dr(GridView2.FocusedColumn.FieldName.ToString))
            End If
            GridView2.FocusedRowHandle = satir
            sayi = Nothing
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        GridView2.ColumnsCustomization()
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If MenuItem6.Checked = False Then
            GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView2.OptionsCustomization.AllowFilter = True
            MenuItem6.Checked = True
        ElseIf MenuItem6.Checked = True Then
            GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView2.OptionsCustomization.AllowFilter = False
            MenuItem6.Checked = False
        End If
    End Sub
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        If MenuItem12.Checked = False Then
            GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView2.OptionsCustomization.AllowFilter = True
            GridView2.OptionsView.ShowAutoFilterRow = True
            MenuItem12.Checked = True
        ElseIf MenuItem12.Checked = True Then
            GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView2.OptionsCustomization.AllowFilter = False
            GridView2.OptionsView.ShowAutoFilterRow = False
            MenuItem12.Checked = False
        End If
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        If MenuItem7.Checked = False Then
            GridView2.OptionsView.ShowGroupPanel = True
            GridView2.OptionsCustomization.AllowGroup = True
            MenuItem7.Checked = True
        ElseIf MenuItem7.Checked = True Then
            GridView2.OptionsView.ShowGroupPanel = False
            GridView2.OptionsCustomization.AllowGroup = False
            MenuItem7.Checked = False
        End If
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        GridView2.ExpandAllGroups()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        GridView2.CollapseAllGroups()
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        GridControl2.Focus()
        GridControl2.Select()
    End Sub
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        printlink2.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub GridControl2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl2.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        tbStokFiyatTarihcesi()
    End Sub
    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        analiz_stok_KarlilikAkisTablosu()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Excel Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyaları(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_text()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Text Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Text Dosyaları(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_pdf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Metin Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyaları(*.pdf) |*.pdf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        raporla_pdf()
    End Sub
    Private Sub tbRenk_kaldir()
        Dim frm As New frm_tbRenk
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.kriter = " Where (sRenk IN (SELECT DISTINCT sRenk FROM          tbStok WHERE      sModel = N'" & sModel & "'))"
        frm.islemstatus = True
        frm.bSec = False
        If yetki_kontrol(kullanici, frm.Name) = True Then
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dr1 As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                sRenk = dr1("sRenk").ToString
                If Trim(sRenk) <> "" Then
                    GridView1.ClearColumnsFilter()
                    GridView1.Columns("sRenk").FilterInfo = New ColumnFilterInfo("[sRenk] LIKE '" & sRenk & "%'")
                End If
                dr1 = Nothing
            End If
        End If
    End Sub
    Private Sub tbBeden_kaldir()
        Dim frm As New frm_tbBeden
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.kriter = " Where (sBeden IN (SELECT DISTINCT sBeden FROM          tbStok WHERE      sModel = N'" & sModel & "'))"
        frm.islemstatus = True
        frm.bSec = False
        If yetki_kontrol(kullanici, frm.Name) = True Then
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dr1 As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                sBeden = dr1("sBeden").ToString
                If Trim(sBeden) <> "" Then
                    GridView1.ClearColumnsFilter()
                    GridView1.Columns("sBeden").FilterInfo = New ColumnFilterInfo("[sBeden] LIKE '" & sBeden & "%'")
                End If
                dr1 = Nothing
            End If
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        tbRenk_kaldir()
    End Sub
    Private Sub c_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles c.ItemClick
        tbBeden_kaldir()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stok_fiyat()
    End Sub
    Private Sub stok_fiyat()
        If GridView1.RowCount > 0 Then
            Dim frm As New frm_stok_fiyatlandir_model
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = nStokID
            frm.sModel = sModel
            frm.sKodu = sKodu
            frm.sRenk = sRenk
            frm.sBeden = sBeden
            frm.txt_musteriNo.Text = sModel
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Friend WithEvents colsRenkAdi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKavala1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sRenk As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_sFiyatTipi As DevExpress.XtraEditors.ComboBoxEdit
    Private Sub sec_sRenk_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sRenk.EditValueChanged
        GridView2.ClearColumnsFilter()
        If Trim(sec_sRenk.Text) <> "" Then
            GridView2.Columns("sRenkAdi").FilterInfo = New ColumnFilterInfo("[sRenkAdi] LIKE '" & sec_sRenk.Text & "%'")
        End If
        If Trim(sec_sFiyatTipi.Text) <> "" Then
            'GridView2.ClearColumnsFilter()
            GridView2.Columns("sFiyatTipi").FilterInfo = New ColumnFilterInfo("[sFiyatTipi] LIKE '" & sec_sFiyatTipi.Text & "%'")
        End If
        GridControl2.Focus()
        GridControl2.Select()
    End Sub
    Private Sub sec_sFiyatTipi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sFiyatTipi.EditValueChanged
        GridView2.ClearColumnsFilter()
        If Trim(sec_sRenk.Text) <> "" Then
            GridView2.Columns("sRenkAdi").FilterInfo = New ColumnFilterInfo("[sRenkAdi] LIKE '" & sec_sRenk.Text & "%'")
        End If
        If Trim(sec_sFiyatTipi.Text) <> "" Then
            'GridView2.ClearColumnsFilter()
            GridView2.Columns("sFiyatTipi").FilterInfo = New ColumnFilterInfo("[sFiyatTipi] LIKE '" & sec_sFiyatTipi.Text & "%'")
        End If
        GridControl2.Focus()
        GridControl2.Select()
    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
