Imports FastReport
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports Microsoft.Win32
Public Class frm_stok_cari_alis_karlilik
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
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents DataTable2 As System.Data.DataTable
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
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn75 As System.Data.DataColumn
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
    Friend WithEvents colnStokFisiID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collGirisMiktar1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collGirisMiktar2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collGirisFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collGirisTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIskontoYuzdesi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collIskontoTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnSiparisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISKONTOLAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteIrsaliyeTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collIrsaliyeNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStokID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnFirmaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIrsaliyeFisiID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsStokIslem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnOTVOrani As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKdvOrani As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIslemID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGERCEKFIYAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGERCEKTOPLAM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISK3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISK4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEKMASRAF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBrutFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBrutTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colONCEKIMALIYET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPESIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colALTIAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colONAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKAR1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKAR2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKAR3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dataset1 As System.Data.DataSet
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents colbFiyatDegisti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnFarkOran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDurum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents lbl_Karlilik As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents sec_oran As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents sec_fiyat As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Panelstatus As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ProgressBarControl1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents barlabel2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents barlabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bar As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents colTOPLAMMALIYET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents colSINIF5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKAR4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKAR5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFiyat4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents colbYeni As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents sec_sFiltre As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents sec_bKdvHaric As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents collFiyat5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKAR6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteFiyatTespitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFiyat6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKAR7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFiyat7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFiyat8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFiyat9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFiyat10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKAR8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKAR9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKAR10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKAR11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colMALIYET As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_cari_alis_karlilik))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition6 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition7 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition8 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colORAN1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_oran = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colORAN2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbFiyatDegisti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbYeni = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.sec_bKdvHaric = New DevExpress.XtraEditors.CheckEdit()
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
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.lbl_Karlilik = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Panelstatus = New DevExpress.XtraEditors.PanelControl()
        Me.ProgressBarControl1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.barlabel2 = New DevExpress.XtraEditors.LabelControl()
        Me.barlabel = New DevExpress.XtraEditors.LabelControl()
        Me.bar = New DevExpress.XtraEditors.ProgressBarControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.dataset1 = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn27 = New System.Data.DataColumn()
        Me.DataColumn28 = New System.Data.DataColumn()
        Me.DataColumn29 = New System.Data.DataColumn()
        Me.DataColumn30 = New System.Data.DataColumn()
        Me.DataColumn31 = New System.Data.DataColumn()
        Me.DataColumn32 = New System.Data.DataColumn()
        Me.DataColumn33 = New System.Data.DataColumn()
        Me.DataColumn34 = New System.Data.DataColumn()
        Me.DataColumn35 = New System.Data.DataColumn()
        Me.DataColumn36 = New System.Data.DataColumn()
        Me.DataColumn37 = New System.Data.DataColumn()
        Me.DataColumn38 = New System.Data.DataColumn()
        Me.DataColumn39 = New System.Data.DataColumn()
        Me.DataColumn40 = New System.Data.DataColumn()
        Me.DataColumn41 = New System.Data.DataColumn()
        Me.DataColumn42 = New System.Data.DataColumn()
        Me.DataColumn43 = New System.Data.DataColumn()
        Me.DataColumn44 = New System.Data.DataColumn()
        Me.DataColumn45 = New System.Data.DataColumn()
        Me.DataColumn46 = New System.Data.DataColumn()
        Me.DataColumn47 = New System.Data.DataColumn()
        Me.DataColumn48 = New System.Data.DataColumn()
        Me.DataColumn49 = New System.Data.DataColumn()
        Me.DataColumn50 = New System.Data.DataColumn()
        Me.DataColumn51 = New System.Data.DataColumn()
        Me.DataColumn52 = New System.Data.DataColumn()
        Me.DataColumn53 = New System.Data.DataColumn()
        Me.DataColumn54 = New System.Data.DataColumn()
        Me.DataColumn55 = New System.Data.DataColumn()
        Me.DataColumn56 = New System.Data.DataColumn()
        Me.DataColumn75 = New System.Data.DataColumn()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnStokFisiID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collGirisMiktar1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collGirisMiktar2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collGirisFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collGirisTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIskontoYuzdesi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collIskontoTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDovizCinsi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnSiparisID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISKONTOLAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteIrsaliyeTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collIrsaliyeNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStokID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnFirmaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIrsaliyeFisiID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsStokIslem = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnOTVOrani = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKdvOrani = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIslemID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGERCEKFIYAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGERCEKTOPLAM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISK1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISK2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISK3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISK4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEKMASRAF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBrutFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBrutTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colONCEKIMALIYET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPESIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_fiyat = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colALTIAY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colONAY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKAR1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKAR2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKAR3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMALIYET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnFarkOran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDurum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTOPLAMMALIYET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKAR4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKAR5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFiyat4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFiyat5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKAR6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteFiyatTespitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFiyat6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKAR7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFiyat7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFiyat8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFiyat9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFiyat10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKAR8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKAR9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKAR10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKAR11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_sFiltre = New DevExpress.XtraEditors.RadioGroup()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.sec_oran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.sec_bKdvHaric.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelstatus.SuspendLayout()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataset1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_fiyat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_sFiltre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colORAN1
        '
        Me.colORAN1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colORAN1.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colORAN1.AppearanceCell.Options.UseBackColor = True
        Me.colORAN1.Caption = "%Oran1"
        Me.colORAN1.ColumnEdit = Me.sec_oran
        Me.colORAN1.DisplayFormat.FormatString = "#,0.00"
        Me.colORAN1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN1.FieldName = "ORAN1"
        Me.colORAN1.Name = "colORAN1"
        Me.colORAN1.Visible = True
        Me.colORAN1.VisibleIndex = 8
        Me.colORAN1.Width = 70
        '
        'sec_oran
        '
        Me.sec_oran.AutoHeight = False
        Me.sec_oran.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_oran.Name = "sec_oran"
        '
        'colORAN2
        '
        Me.colORAN2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colORAN2.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colORAN2.AppearanceCell.Options.UseBackColor = True
        Me.colORAN2.Caption = "%Oran2"
        Me.colORAN2.ColumnEdit = Me.sec_oran
        Me.colORAN2.DisplayFormat.FormatString = "#,0.00"
        Me.colORAN2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN2.FieldName = "ORAN2"
        Me.colORAN2.Name = "colORAN2"
        Me.colORAN2.Width = 53
        '
        'colORAN3
        '
        Me.colORAN3.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colORAN3.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colORAN3.AppearanceCell.Options.UseBackColor = True
        Me.colORAN3.Caption = "%Oran3"
        Me.colORAN3.ColumnEdit = Me.sec_oran
        Me.colORAN3.DisplayFormat.FormatString = "#,0.00"
        Me.colORAN3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN3.FieldName = "ORAN3"
        Me.colORAN3.Name = "colORAN3"
        Me.colORAN3.Width = 60
        '
        'colbFiyatDegisti
        '
        Me.colbFiyatDegisti.Caption = "Fiyatý Deðiþti?"
        Me.colbFiyatDegisti.FieldName = "bFiyatDegisti"
        Me.colbFiyatDegisti.Name = "colbFiyatDegisti"
        Me.colbFiyatDegisti.OptionsColumn.AllowFocus = False
        '
        'colbYeni
        '
        Me.colbYeni.Caption = "Yeni?"
        Me.colbYeni.FieldName = "bYeni"
        Me.colbYeni.Name = "colbYeni"
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
        Me.Label1.Size = New System.Drawing.Size(162, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fatura Karlýlýk Analizi Aþaðýdadýr..."
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
        Me.PanelControl2.Controls.Add(Me.sec_bKdvHaric)
        Me.PanelControl2.Controls.Add(Me.lbl_Karlilik)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 380)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'sec_bKdvHaric
        '
        Me.sec_bKdvHaric.Location = New System.Drawing.Point(5, 27)
        Me.sec_bKdvHaric.MenuManager = Me.BarManager1
        Me.sec_bKdvHaric.Name = "sec_bKdvHaric"
        Me.sec_bKdvHaric.Properties.Caption = "Kdv Haric"
        Me.sec_bKdvHaric.Size = New System.Drawing.Size(75, 19)
        Me.sec_bKdvHaric.TabIndex = 8
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
        Me.BarButtonItem1.Caption = "Stok Kartý ,F4"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Fiyatlandir,Ctrl+F"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Envanter,F6"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Hareketler ,F7"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Excel"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Text"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Mail"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Fiyatlarý Güncelle"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem9.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F11)
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Föy Oluþtur"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 428)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 428)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 428)
        '
        'lbl_Karlilik
        '
        Me.lbl_Karlilik.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_Karlilik.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_Karlilik.Location = New System.Drawing.Point(7, 8)
        Me.lbl_Karlilik.Name = "lbl_Karlilik"
        Me.lbl_Karlilik.Size = New System.Drawing.Size(7, 13)
        Me.lbl_Karlilik.TabIndex = 7
        Me.lbl_Karlilik.Text = "*"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(106, 30)
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
        Me.PanelControl3.Controls.Add(Me.Panelstatus)
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Controls.Add(Me.GroupControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 324)
        Me.PanelControl3.TabIndex = 0
        '
        'Panelstatus
        '
        Me.Panelstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panelstatus.Appearance.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panelstatus.Appearance.Options.UseBackColor = True
        Me.Panelstatus.Controls.Add(Me.ProgressBarControl1)
        Me.Panelstatus.Controls.Add(Me.barlabel2)
        Me.Panelstatus.Controls.Add(Me.barlabel)
        Me.Panelstatus.Controls.Add(Me.bar)
        Me.Panelstatus.Location = New System.Drawing.Point(145, 108)
        Me.Panelstatus.Name = "Panelstatus"
        Me.Panelstatus.Size = New System.Drawing.Size(535, 108)
        Me.Panelstatus.TabIndex = 13
        Me.Panelstatus.Visible = False
        '
        'ProgressBarControl1
        '
        Me.ProgressBarControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBarControl1.Location = New System.Drawing.Point(8, 73)
        Me.ProgressBarControl1.Name = "ProgressBarControl1"
        Me.ProgressBarControl1.Properties.ShowTitle = True
        Me.ProgressBarControl1.Size = New System.Drawing.Size(511, 18)
        Me.ProgressBarControl1.TabIndex = 3
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
        Me.GridControl1.DataSource = Me.dataset1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 63)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_oran, Me.sec_fiyat})
        Me.GridControl1.Size = New System.Drawing.Size(820, 259)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem26, Me.MenuItem13, Me.MenuItem14, Me.MenuItem20, Me.MenuItem17, Me.MenuItem18, Me.MenuItem19, Me.MenuItem16, Me.MenuItem27, Me.MenuItem28, Me.MenuItem29, Me.MenuItem15, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem22, Me.MenuItem21, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem25, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 0
        Me.MenuItem26.Shortcut = System.Windows.Forms.Shortcut.ShiftF1
        Me.MenuItem26.Text = "Hesap Makinasý"
        '
        'MenuItem13
        '
        Me.MenuItem13.DefaultItem = True
        Me.MenuItem13.Index = 1
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem13.Text = "Tamam"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 2
        Me.MenuItem14.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem14.Text = "Vazgeç"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 3
        Me.MenuItem20.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 4
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem17.Text = "Stok Kartý"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 5
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem18.Text = "Stok Hareketleri"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 6
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItem19.Text = "Fiyat Degistir"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 7
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem16.Text = "Envanter"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 8
        Me.MenuItem27.Shortcut = System.Windows.Forms.Shortcut.CtrlE
        Me.MenuItem27.Text = "Etiket Yazdýr"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 9
        Me.MenuItem28.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItem28.Text = "Karlýlýk Akýþ Tablosu"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 10
        Me.MenuItem29.Text = "Fiyat Deðiþim Föyüne Aktar"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 11
        Me.MenuItem15.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 12
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 13
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 14
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 15
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 16
        Me.MenuItem10.Text = "-"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 17
        Me.MenuItem22.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem23, Me.MenuItem24})
        Me.MenuItem22.Text = "Raporla"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 0
        Me.MenuItem23.Text = "Excel"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 1
        Me.MenuItem24.Text = "Text"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 18
        Me.MenuItem21.Text = "Hýzlý Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 19
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 20
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 21
        Me.MenuItem11.Text = "-"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 22
        Me.MenuItem25.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem25.Text = "Deðer Yay"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 23
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 24
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 25
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 26
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem9.Text = "Ekraný Kapla"
        '
        'dataset1
        '
        Me.dataset1.DataSetName = "NewDataSet"
        Me.dataset1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.dataset1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn75, Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "nStokFisiID"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "sKodu"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "sAciklama"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "lGirisMiktar1"
        Me.DataColumn30.DataType = GetType(Decimal)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "lGirisMiktar2"
        Me.DataColumn31.DataType = GetType(Decimal)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "lGirisFiyat"
        Me.DataColumn32.DataType = GetType(Decimal)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "lGirisTutar"
        Me.DataColumn33.DataType = GetType(Decimal)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "nIskontoYuzdesi"
        Me.DataColumn34.DataType = GetType(Decimal)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "lIskontoTutari"
        Me.DataColumn35.DataType = GetType(Decimal)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "sDovizCinsi"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "lDovizFiyat"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "nSiparisID"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "ISKONTOLAR"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "dteIrsaliyeTarihi"
        Me.DataColumn40.DataType = GetType(Date)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "lIrsaliyeNo"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "sDepo"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "nStokID"
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "nFirmaID"
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "nIrsaliyeFisiID"
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "sStokIslem"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "nOTVOrani"
        Me.DataColumn47.DataType = GetType(Decimal)
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "nKdvOrani"
        Me.DataColumn48.DataType = GetType(Decimal)
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "nIslemID"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "GERCEKFIYAT"
        Me.DataColumn50.DataType = GetType(Decimal)
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "GERCEKTOPLAM"
        Me.DataColumn51.DataType = GetType(Decimal)
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "ISK1"
        Me.DataColumn52.DataType = GetType(Decimal)
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "ISK2"
        Me.DataColumn53.DataType = GetType(Decimal)
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "ISK3"
        Me.DataColumn54.DataType = GetType(Decimal)
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "ISK4"
        Me.DataColumn55.DataType = GetType(Decimal)
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "EKMASRAF"
        Me.DataColumn56.DataType = GetType(Decimal)
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "ONCEKIMALIYET"
        Me.DataColumn75.DataType = GetType(Decimal)
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "PESIN"
        Me.DataColumn1.DataType = GetType(Decimal)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "ONAY"
        Me.DataColumn2.DataType = GetType(Decimal)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "ALTIAY"
        Me.DataColumn3.DataType = GetType(Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "MALIYET"
        Me.DataColumn4.DataType = GetType(Decimal)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "ORAN1"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "ORAN2"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "ORAN3"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "lEkMaliyet1"
        Me.DataColumn8.DataType = GetType(Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "KAR1"
        Me.DataColumn9.DataType = GetType(Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "KAR2"
        Me.DataColumn10.DataType = GetType(Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "KAR3"
        Me.DataColumn11.DataType = GetType(Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "PESINTUTAR"
        Me.DataColumn12.DataType = GetType(Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "ONAYTUTAR"
        Me.DataColumn13.DataType = GetType(Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "ALTIAYTUTAR"
        Me.DataColumn14.DataType = GetType(Decimal)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnStokFisiID, Me.colsKodu, Me.colsAciklama, Me.collGirisMiktar1, Me.collGirisMiktar2, Me.collGirisFiyat, Me.collGirisTutar, Me.colnIskontoYuzdesi, Me.collIskontoTutari, Me.colsDovizCinsi, Me.collDovizFiyat, Me.colnSiparisID, Me.colISKONTOLAR, Me.coldteIrsaliyeTarihi, Me.collIrsaliyeNo, Me.colsDepo, Me.colnStokID, Me.colnFirmaID, Me.colnIrsaliyeFisiID, Me.colsStokIslem, Me.colnOTVOrani, Me.colnKdvOrani, Me.colnIslemID, Me.colGERCEKFIYAT, Me.colGERCEKTOPLAM, Me.colISK1, Me.colISK2, Me.colISK3, Me.colISK4, Me.colEKMASRAF, Me.collBrutFiyat, Me.collBrutTutar, Me.colONCEKIMALIYET, Me.colPESIN, Me.colALTIAY, Me.colONAY, Me.colORAN1, Me.colORAN2, Me.colORAN3, Me.colKAR1, Me.colKAR2, Me.colKAR3, Me.colMALIYET, Me.colbFiyatDegisti, Me.colnFarkOran, Me.collFark, Me.colsDurum, Me.colTOPLAMMALIYET, Me.colORAN, Me.colKAR, Me.colSINIF5, Me.colORAN4, Me.colORAN5, Me.colKAR4, Me.colKAR5, Me.collFiyat4, Me.colbYeni, Me.collFiyat5, Me.colORAN6, Me.colKAR6, Me.coldteFiyatTespitTarihi, Me.collFiyat6, Me.colKAR7, Me.collFiyat7, Me.collFiyat8, Me.collFiyat9, Me.collFiyat10, Me.colORAN7, Me.colORAN8, Me.colORAN9, Me.colORAN10, Me.colKAR8, Me.colKAR9, Me.colKAR10, Me.colKAR11})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(665, 336, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Blue
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.colORAN1
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.colORAN1
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Blue
        StyleFormatCondition3.Appearance.Options.UseForeColor = True
        StyleFormatCondition3.Column = Me.colORAN2
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition4.Appearance.Options.UseForeColor = True
        StyleFormatCondition4.Column = Me.colORAN2
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition5.Appearance.ForeColor = System.Drawing.Color.Blue
        StyleFormatCondition5.Appearance.Options.UseForeColor = True
        StyleFormatCondition5.Column = Me.colORAN3
        StyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition5.Value1 = "0"
        StyleFormatCondition6.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition6.Appearance.Options.UseForeColor = True
        StyleFormatCondition6.Column = Me.colORAN3
        StyleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition6.Value1 = "0"
        StyleFormatCondition7.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition7.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition7.Appearance.Options.UseBackColor = True
        StyleFormatCondition7.Appearance.Options.UseForeColor = True
        StyleFormatCondition7.ApplyToRow = True
        StyleFormatCondition7.Column = Me.colbFiyatDegisti
        StyleFormatCondition7.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition7.Value1 = "0"
        StyleFormatCondition8.Appearance.ForeColor = System.Drawing.Color.Purple
        StyleFormatCondition8.Appearance.Options.UseForeColor = True
        StyleFormatCondition8.ApplyToRow = True
        StyleFormatCondition8.Column = Me.colbYeni
        StyleFormatCondition8.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition8.Expression = "1"
        StyleFormatCondition8.Value1 = "1"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4, StyleFormatCondition5, StyleFormatCondition6, StyleFormatCondition7, StyleFormatCondition8})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colnStokFisiID
        '
        Me.colnStokFisiID.Caption = "Evrak No"
        Me.colnStokFisiID.FieldName = "nStokFisiID"
        Me.colnStokFisiID.Name = "colnStokFisiID"
        Me.colnStokFisiID.OptionsColumn.AllowFocus = False
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Stok Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.OptionsColumn.AllowFocus = False
        Me.colsKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", "{0} Kayýt")})
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 0
        Me.colsKodu.Width = 76
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Stok Adý"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.OptionsColumn.AllowFocus = False
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 1
        Me.colsAciklama.Width = 198
        '
        'collGirisMiktar1
        '
        Me.collGirisMiktar1.Caption = "Miktar1"
        Me.collGirisMiktar1.DisplayFormat.FormatString = "#,0.##"
        Me.collGirisMiktar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGirisMiktar1.FieldName = "lGirisMiktar1"
        Me.collGirisMiktar1.Name = "collGirisMiktar1"
        Me.collGirisMiktar1.OptionsColumn.AllowFocus = False
        Me.collGirisMiktar1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGirisMiktar1", "{0:#,0.##}")})
        Me.collGirisMiktar1.Visible = True
        Me.collGirisMiktar1.VisibleIndex = 2
        Me.collGirisMiktar1.Width = 66
        '
        'collGirisMiktar2
        '
        Me.collGirisMiktar2.Caption = "Miktar2"
        Me.collGirisMiktar2.FieldName = "lGirisMiktar2"
        Me.collGirisMiktar2.Name = "collGirisMiktar2"
        Me.collGirisMiktar2.OptionsColumn.AllowFocus = False
        '
        'collGirisFiyat
        '
        Me.collGirisFiyat.Caption = "Birim Fiyat"
        Me.collGirisFiyat.DisplayFormat.FormatString = "#,0.00"
        Me.collGirisFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGirisFiyat.FieldName = "lGirisFiyat"
        Me.collGirisFiyat.Name = "collGirisFiyat"
        Me.collGirisFiyat.OptionsColumn.AllowFocus = False
        Me.collGirisFiyat.Width = 58
        '
        'collGirisTutar
        '
        Me.collGirisTutar.Caption = "Birim Tutar"
        Me.collGirisTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collGirisTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGirisTutar.FieldName = "lGirisTutar"
        Me.collGirisTutar.Name = "collGirisTutar"
        Me.collGirisTutar.OptionsColumn.AllowFocus = False
        Me.collGirisTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGirisTutar", "{0:#,0.00}")})
        Me.collGirisTutar.Width = 51
        '
        'colnIskontoYuzdesi
        '
        Me.colnIskontoYuzdesi.Caption = "%TopIsk"
        Me.colnIskontoYuzdesi.FieldName = "nIskontoYuzdesi"
        Me.colnIskontoYuzdesi.Name = "colnIskontoYuzdesi"
        Me.colnIskontoYuzdesi.OptionsColumn.AllowFocus = False
        '
        'collIskontoTutari
        '
        Me.collIskontoTutari.Caption = "Iskonto"
        Me.collIskontoTutari.FieldName = "lIskontoTutari"
        Me.collIskontoTutari.Name = "collIskontoTutari"
        Me.collIskontoTutari.OptionsColumn.AllowFocus = False
        '
        'colsDovizCinsi
        '
        Me.colsDovizCinsi.Caption = "Pb"
        Me.colsDovizCinsi.FieldName = "sDovizCinsi"
        Me.colsDovizCinsi.Name = "colsDovizCinsi"
        Me.colsDovizCinsi.OptionsColumn.AllowFocus = False
        Me.colsDovizCinsi.Width = 30
        '
        'collDovizFiyat
        '
        Me.collDovizFiyat.Caption = "Döviz Fiyatý"
        Me.collDovizFiyat.FieldName = "lDovizFiyat"
        Me.collDovizFiyat.Name = "collDovizFiyat"
        Me.collDovizFiyat.OptionsColumn.AllowFocus = False
        Me.collDovizFiyat.Width = 51
        '
        'colnSiparisID
        '
        Me.colnSiparisID.Caption = "Sipariþ No"
        Me.colnSiparisID.FieldName = "nSiparisID"
        Me.colnSiparisID.Name = "colnSiparisID"
        Me.colnSiparisID.OptionsColumn.AllowFocus = False
        '
        'colISKONTOLAR
        '
        Me.colISKONTOLAR.Caption = "Ýskontolar"
        Me.colISKONTOLAR.FieldName = "ISKONTOLAR"
        Me.colISKONTOLAR.Name = "colISKONTOLAR"
        Me.colISKONTOLAR.OptionsColumn.AllowFocus = False
        Me.colISKONTOLAR.Width = 77
        '
        'coldteIrsaliyeTarihi
        '
        Me.coldteIrsaliyeTarihi.Caption = "Ýrsaliye Tarihi"
        Me.coldteIrsaliyeTarihi.FieldName = "dteIrsaliyeTarihi"
        Me.coldteIrsaliyeTarihi.Name = "coldteIrsaliyeTarihi"
        Me.coldteIrsaliyeTarihi.OptionsColumn.AllowFocus = False
        '
        'collIrsaliyeNo
        '
        Me.collIrsaliyeNo.Caption = "Ýrsaliye No"
        Me.collIrsaliyeNo.FieldName = "lIrsaliyeNo"
        Me.collIrsaliyeNo.Name = "collIrsaliyeNo"
        Me.collIrsaliyeNo.OptionsColumn.AllowFocus = False
        '
        'colsDepo
        '
        Me.colsDepo.Caption = "Depo"
        Me.colsDepo.FieldName = "sDepo"
        Me.colsDepo.Name = "colsDepo"
        Me.colsDepo.OptionsColumn.AllowFocus = False
        Me.colsDepo.Width = 36
        '
        'colnStokID
        '
        Me.colnStokID.Caption = "Stok No"
        Me.colnStokID.FieldName = "nStokID"
        Me.colnStokID.Name = "colnStokID"
        Me.colnStokID.OptionsColumn.AllowFocus = False
        '
        'colnFirmaID
        '
        Me.colnFirmaID.Caption = "Firma No"
        Me.colnFirmaID.FieldName = "nFirmaID"
        Me.colnFirmaID.Name = "colnFirmaID"
        Me.colnFirmaID.OptionsColumn.AllowFocus = False
        '
        'colnIrsaliyeFisiID
        '
        Me.colnIrsaliyeFisiID.Caption = "IrsaliyeFisiNo"
        Me.colnIrsaliyeFisiID.FieldName = "nIrsaliyeFisiID"
        Me.colnIrsaliyeFisiID.Name = "colnIrsaliyeFisiID"
        Me.colnIrsaliyeFisiID.OptionsColumn.AllowFocus = False
        '
        'colsStokIslem
        '
        Me.colsStokIslem.Caption = "Stok Ýþlem"
        Me.colsStokIslem.FieldName = "sStokIslem"
        Me.colsStokIslem.Name = "colsStokIslem"
        Me.colsStokIslem.OptionsColumn.AllowFocus = False
        '
        'colnOTVOrani
        '
        Me.colnOTVOrani.Caption = "Otv"
        Me.colnOTVOrani.FieldName = "nOTVOrani"
        Me.colnOTVOrani.Name = "colnOTVOrani"
        Me.colnOTVOrani.OptionsColumn.AllowFocus = False
        '
        'colnKdvOrani
        '
        Me.colnKdvOrani.Caption = "Kdv"
        Me.colnKdvOrani.DisplayFormat.FormatString = "#,0.##"
        Me.colnKdvOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnKdvOrani.FieldName = "nKdvOrani"
        Me.colnKdvOrani.Name = "colnKdvOrani"
        Me.colnKdvOrani.OptionsColumn.AllowFocus = False
        Me.colnKdvOrani.Width = 29
        '
        'colnIslemID
        '
        Me.colnIslemID.Caption = "Kayýt No"
        Me.colnIslemID.FieldName = "nIslemID"
        Me.colnIslemID.Name = "colnIslemID"
        Me.colnIslemID.OptionsColumn.AllowFocus = False
        '
        'colGERCEKFIYAT
        '
        Me.colGERCEKFIYAT.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGERCEKFIYAT.AppearanceCell.Options.UseFont = True
        Me.colGERCEKFIYAT.Caption = "Gerçek Fiyat"
        Me.colGERCEKFIYAT.DisplayFormat.FormatString = "#,0.00"
        Me.colGERCEKFIYAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGERCEKFIYAT.FieldName = "GERCEKFIYAT"
        Me.colGERCEKFIYAT.Name = "colGERCEKFIYAT"
        Me.colGERCEKFIYAT.OptionsColumn.AllowFocus = False
        Me.colGERCEKFIYAT.Visible = True
        Me.colGERCEKFIYAT.VisibleIndex = 5
        Me.colGERCEKFIYAT.Width = 78
        '
        'colGERCEKTOPLAM
        '
        Me.colGERCEKTOPLAM.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGERCEKTOPLAM.AppearanceCell.Options.UseFont = True
        Me.colGERCEKTOPLAM.Caption = "GerçekToplam"
        Me.colGERCEKTOPLAM.DisplayFormat.FormatString = "#,0.00"
        Me.colGERCEKTOPLAM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGERCEKTOPLAM.FieldName = "GERCEKTOPLAM"
        Me.colGERCEKTOPLAM.Name = "colGERCEKTOPLAM"
        Me.colGERCEKTOPLAM.OptionsColumn.AllowFocus = False
        Me.colGERCEKTOPLAM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GERCEKTOPLAM", "{0:#,0.00}")})
        Me.colGERCEKTOPLAM.Visible = True
        Me.colGERCEKTOPLAM.VisibleIndex = 3
        Me.colGERCEKTOPLAM.Width = 80
        '
        'colISK1
        '
        Me.colISK1.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colISK1.AppearanceCell.Options.UseFont = True
        Me.colISK1.AppearanceCell.Options.UseForeColor = True
        Me.colISK1.Caption = "% Ýsk. 1"
        Me.colISK1.DisplayFormat.FormatString = "#,0.00"
        Me.colISK1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISK1.FieldName = "ISK1"
        Me.colISK1.GroupFormat.FormatString = "#,#.##"
        Me.colISK1.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISK1.Name = "colISK1"
        Me.colISK1.OptionsColumn.AllowFocus = False
        Me.colISK1.Width = 32
        '
        'colISK2
        '
        Me.colISK2.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colISK2.AppearanceCell.Options.UseFont = True
        Me.colISK2.AppearanceCell.Options.UseForeColor = True
        Me.colISK2.Caption = "% Ýsk. 2"
        Me.colISK2.DisplayFormat.FormatString = "#,0.00"
        Me.colISK2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISK2.FieldName = "ISK2"
        Me.colISK2.GroupFormat.FormatString = "#,#.##"
        Me.colISK2.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISK2.Name = "colISK2"
        Me.colISK2.OptionsColumn.AllowFocus = False
        Me.colISK2.Width = 30
        '
        'colISK3
        '
        Me.colISK3.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colISK3.AppearanceCell.Options.UseFont = True
        Me.colISK3.AppearanceCell.Options.UseForeColor = True
        Me.colISK3.Caption = "% Ýsk. 3"
        Me.colISK3.DisplayFormat.FormatString = "#,0.00"
        Me.colISK3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISK3.FieldName = "ISK3"
        Me.colISK3.GroupFormat.FormatString = "#,#.##"
        Me.colISK3.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISK3.Name = "colISK3"
        Me.colISK3.OptionsColumn.AllowFocus = False
        Me.colISK3.Width = 32
        '
        'colISK4
        '
        Me.colISK4.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colISK4.AppearanceCell.Options.UseFont = True
        Me.colISK4.AppearanceCell.Options.UseForeColor = True
        Me.colISK4.Caption = "% Ýsk. 4"
        Me.colISK4.DisplayFormat.FormatString = "#,0.00"
        Me.colISK4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISK4.FieldName = "ISK4"
        Me.colISK4.GroupFormat.FormatString = "#,#.##"
        Me.colISK4.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISK4.Name = "colISK4"
        Me.colISK4.OptionsColumn.AllowFocus = False
        Me.colISK4.Width = 31
        '
        'colEKMASRAF
        '
        Me.colEKMASRAF.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colEKMASRAF.AppearanceCell.Options.UseForeColor = True
        Me.colEKMASRAF.Caption = "%EkMasraf"
        Me.colEKMASRAF.DisplayFormat.FormatString = "P"
        Me.colEKMASRAF.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEKMASRAF.FieldName = "EKMASRAF"
        Me.colEKMASRAF.GroupFormat.FormatString = "#,#.##"
        Me.colEKMASRAF.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEKMASRAF.Name = "colEKMASRAF"
        Me.colEKMASRAF.OptionsColumn.AllowFocus = False
        Me.colEKMASRAF.Width = 29
        '
        'collBrutFiyat
        '
        Me.collBrutFiyat.Caption = "Fiyat"
        Me.collBrutFiyat.DisplayFormat.FormatString = "#,0.00"
        Me.collBrutFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutFiyat.FieldName = "lBrutFiyat"
        Me.collBrutFiyat.Name = "collBrutFiyat"
        Me.collBrutFiyat.OptionsColumn.AllowFocus = False
        Me.collBrutFiyat.Width = 58
        '
        'collBrutTutar
        '
        Me.collBrutTutar.Caption = "Tutar"
        Me.collBrutTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collBrutTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutTutar.FieldName = "lBrutTutar"
        Me.collBrutTutar.Name = "collBrutTutar"
        Me.collBrutTutar.OptionsColumn.AllowFocus = False
        Me.collBrutTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBrutTutar", "{0:#,0.00}")})
        Me.collBrutTutar.Width = 79
        '
        'colONCEKIMALIYET
        '
        Me.colONCEKIMALIYET.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colONCEKIMALIYET.AppearanceCell.Options.UseForeColor = True
        Me.colONCEKIMALIYET.Caption = "Önceki Maliyet"
        Me.colONCEKIMALIYET.DisplayFormat.FormatString = "#,#.####"
        Me.colONCEKIMALIYET.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colONCEKIMALIYET.FieldName = "ONCEKIMALIYET"
        Me.colONCEKIMALIYET.Name = "colONCEKIMALIYET"
        Me.colONCEKIMALIYET.OptionsColumn.AllowFocus = False
        Me.colONCEKIMALIYET.Visible = True
        Me.colONCEKIMALIYET.VisibleIndex = 6
        Me.colONCEKIMALIYET.Width = 74
        '
        'colPESIN
        '
        Me.colPESIN.Caption = "Fiyat1"
        Me.colPESIN.ColumnEdit = Me.sec_fiyat
        Me.colPESIN.DisplayFormat.FormatString = "#,0.00"
        Me.colPESIN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPESIN.FieldName = "PESIN"
        Me.colPESIN.Name = "colPESIN"
        Me.colPESIN.Visible = True
        Me.colPESIN.VisibleIndex = 4
        Me.colPESIN.Width = 29
        '
        'sec_fiyat
        '
        Me.sec_fiyat.AutoHeight = False
        Me.sec_fiyat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_fiyat.Name = "sec_fiyat"
        '
        'colALTIAY
        '
        Me.colALTIAY.Caption = "Fiyat2"
        Me.colALTIAY.ColumnEdit = Me.sec_fiyat
        Me.colALTIAY.DisplayFormat.FormatString = "#,0.00"
        Me.colALTIAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colALTIAY.FieldName = "ALTIAY"
        Me.colALTIAY.Name = "colALTIAY"
        Me.colALTIAY.Width = 29
        '
        'colONAY
        '
        Me.colONAY.Caption = "Fiyat3"
        Me.colONAY.ColumnEdit = Me.sec_fiyat
        Me.colONAY.DisplayFormat.FormatString = "#,0.00"
        Me.colONAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colONAY.FieldName = "ONAY"
        Me.colONAY.Name = "colONAY"
        Me.colONAY.Width = 29
        '
        'colKAR1
        '
        Me.colKAR1.Caption = "1. Fiyat Kar"
        Me.colKAR1.DisplayFormat.FormatString = "#,0.00"
        Me.colKAR1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKAR1.FieldName = "KAR1"
        Me.colKAR1.Name = "colKAR1"
        Me.colKAR1.OptionsColumn.AllowFocus = False
        Me.colKAR1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KAR1", "{0:#,0.00}")})
        Me.colKAR1.Visible = True
        Me.colKAR1.VisibleIndex = 7
        Me.colKAR1.Width = 61
        '
        'colKAR2
        '
        Me.colKAR2.Caption = "2. Fiyat Kar"
        Me.colKAR2.DisplayFormat.FormatString = "#,0.00"
        Me.colKAR2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKAR2.FieldName = "KAR2"
        Me.colKAR2.Name = "colKAR2"
        Me.colKAR2.OptionsColumn.AllowFocus = False
        Me.colKAR2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KAR2", "{0:#,0.00}")})
        Me.colKAR2.Width = 63
        '
        'colKAR3
        '
        Me.colKAR3.Caption = "3. Fiyat Kar"
        Me.colKAR3.DisplayFormat.FormatString = "#,0.00"
        Me.colKAR3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKAR3.FieldName = "KAR3"
        Me.colKAR3.Name = "colKAR3"
        Me.colKAR3.OptionsColumn.AllowFocus = False
        Me.colKAR3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KAR3", "{0:#,0.00}")})
        Me.colKAR3.Width = 55
        '
        'colMALIYET
        '
        Me.colMALIYET.Caption = "Maliyet"
        Me.colMALIYET.DisplayFormat.FormatString = "#,0.00"
        Me.colMALIYET.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMALIYET.FieldName = "MALIYET"
        Me.colMALIYET.Name = "colMALIYET"
        Me.colMALIYET.OptionsColumn.AllowFocus = False
        '
        'colnFarkOran
        '
        Me.colnFarkOran.Caption = "Fark Oraný"
        Me.colnFarkOran.DisplayFormat.FormatString = "p"
        Me.colnFarkOran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnFarkOran.FieldName = "nFarkOran"
        Me.colnFarkOran.Name = "colnFarkOran"
        Me.colnFarkOran.OptionsColumn.AllowFocus = False
        Me.colnFarkOran.Visible = True
        Me.colnFarkOran.VisibleIndex = 10
        Me.colnFarkOran.Width = 63
        '
        'collFark
        '
        Me.collFark.Caption = "Fark"
        Me.collFark.DisplayFormat.FormatString = "#,#.####"
        Me.collFark.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collFark.FieldName = "lFark"
        Me.collFark.Name = "collFark"
        Me.collFark.OptionsColumn.AllowFocus = False
        Me.collFark.Visible = True
        Me.collFark.VisibleIndex = 9
        Me.collFark.Width = 50
        '
        'colsDurum
        '
        Me.colsDurum.Caption = "Durum"
        Me.colsDurum.FieldName = "sDurum"
        Me.colsDurum.Name = "colsDurum"
        Me.colsDurum.OptionsColumn.AllowFocus = False
        '
        'colTOPLAMMALIYET
        '
        Me.colTOPLAMMALIYET.Caption = "ToplamMaliyet"
        Me.colTOPLAMMALIYET.DisplayFormat.FormatString = "#,0.00"
        Me.colTOPLAMMALIYET.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTOPLAMMALIYET.FieldName = "TOPLAMMALIYET"
        Me.colTOPLAMMALIYET.Name = "colTOPLAMMALIYET"
        Me.colTOPLAMMALIYET.OptionsColumn.AllowEdit = False
        Me.colTOPLAMMALIYET.OptionsColumn.AllowFocus = False
        Me.colTOPLAMMALIYET.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOPLAMMALIYET", "{0:#,0.00}")})
        '
        'colORAN
        '
        Me.colORAN.Caption = "Marj%"
        Me.colORAN.DisplayFormat.FormatString = "P"
        Me.colORAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN.FieldName = "ORAN"
        Me.colORAN.Name = "colORAN"
        Me.colORAN.OptionsColumn.AllowEdit = False
        Me.colORAN.OptionsColumn.AllowFocus = False
        Me.colORAN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ORAN", "{0:#,0.00}")})
        '
        'colKAR
        '
        Me.colKAR.Caption = "Kar"
        Me.colKAR.DisplayFormat.FormatString = "#,0.00"
        Me.colKAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKAR.FieldName = "KAR"
        Me.colKAR.Name = "colKAR"
        Me.colKAR.OptionsColumn.AllowEdit = False
        Me.colKAR.OptionsColumn.AllowFocus = False
        Me.colKAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KAR", "{0:#,0.00}")})
        '
        'colSINIF5
        '
        Me.colSINIF5.AppearanceCell.BackColor = System.Drawing.Color.Silver
        Me.colSINIF5.AppearanceCell.Options.UseBackColor = True
        Me.colSINIF5.Caption = "Sýnýf 5"
        Me.colSINIF5.FieldName = "SINIF5"
        Me.colSINIF5.Name = "colSINIF5"
        Me.colSINIF5.OptionsColumn.AllowEdit = False
        Me.colSINIF5.OptionsColumn.ReadOnly = True
        '
        'colORAN4
        '
        Me.colORAN4.Caption = "%Oran4"
        Me.colORAN4.ColumnEdit = Me.sec_oran
        Me.colORAN4.DisplayFormat.FormatString = "#,0.00"
        Me.colORAN4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN4.FieldName = "ORAN4"
        Me.colORAN4.Name = "colORAN4"
        '
        'colORAN5
        '
        Me.colORAN5.Caption = "%Oran5"
        Me.colORAN5.ColumnEdit = Me.sec_oran
        Me.colORAN5.DisplayFormat.FormatString = "#,0.00"
        Me.colORAN5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN5.FieldName = "ORAN5"
        Me.colORAN5.Name = "colORAN5"
        '
        'colKAR4
        '
        Me.colKAR4.Caption = "4. Fiyat Kar"
        Me.colKAR4.DisplayFormat.FormatString = "#,0.00"
        Me.colKAR4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKAR4.FieldName = "KAR4"
        Me.colKAR4.Name = "colKAR4"
        Me.colKAR4.OptionsColumn.AllowFocus = False
        Me.colKAR4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KAR4", "{0:#,0.00}")})
        '
        'colKAR5
        '
        Me.colKAR5.Caption = "5. Fiyat Kar"
        Me.colKAR5.DisplayFormat.FormatString = "#,0.00"
        Me.colKAR5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKAR5.FieldName = "KAR5"
        Me.colKAR5.Name = "colKAR5"
        Me.colKAR5.OptionsColumn.AllowFocus = False
        Me.colKAR5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KAR5", "{0:#,0.00}")})
        '
        'collFiyat4
        '
        Me.collFiyat4.Caption = "Fiyat4"
        Me.collFiyat4.ColumnEdit = Me.sec_fiyat
        Me.collFiyat4.DisplayFormat.FormatString = "#,0.00"
        Me.collFiyat4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collFiyat4.FieldName = "lFiyat4"
        Me.collFiyat4.Name = "collFiyat4"
        '
        'collFiyat5
        '
        Me.collFiyat5.Caption = "Fiyat5"
        Me.collFiyat5.ColumnEdit = Me.sec_fiyat
        Me.collFiyat5.DisplayFormat.FormatString = "#,0.00##"
        Me.collFiyat5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collFiyat5.FieldName = "lFiyat5"
        Me.collFiyat5.Name = "collFiyat5"
        '
        'colORAN6
        '
        Me.colORAN6.Caption = "%Oran6"
        Me.colORAN6.DisplayFormat.FormatString = "#,0.00"
        Me.colORAN6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN6.FieldName = "ORAN6"
        Me.colORAN6.Name = "colORAN6"
        '
        'colKAR6
        '
        Me.colKAR6.Caption = "6. Fiyat Kar"
        Me.colKAR6.DisplayFormat.FormatString = "#,0.00"
        Me.colKAR6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKAR6.FieldName = "KAR6"
        Me.colKAR6.Name = "colKAR6"
        '
        'coldteFiyatTespitTarihi
        '
        Me.coldteFiyatTespitTarihi.Caption = "FiyatTespitTarihi"
        Me.coldteFiyatTespitTarihi.FieldName = "dteFiyatTespitTarihi"
        Me.coldteFiyatTespitTarihi.Name = "coldteFiyatTespitTarihi"
        Me.coldteFiyatTespitTarihi.OptionsColumn.ReadOnly = True
        '
        'collFiyat6
        '
        Me.collFiyat6.Caption = "Fiyat6"
        Me.collFiyat6.ColumnEdit = Me.sec_fiyat
        Me.collFiyat6.DisplayFormat.FormatString = "#,0.00"
        Me.collFiyat6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collFiyat6.FieldName = "lFiyat6"
        Me.collFiyat6.Name = "collFiyat6"
        '
        'colKAR7
        '
        Me.colKAR7.Caption = "7. Fiyat Kar"
        Me.colKAR7.ColumnEdit = Me.sec_oran
        Me.colKAR7.DisplayFormat.FormatString = "#,0.00"
        Me.colKAR7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKAR7.FieldName = "KAR7"
        Me.colKAR7.Name = "colKAR7"
        '
        'collFiyat7
        '
        Me.collFiyat7.Caption = "Fiyat7"
        Me.collFiyat7.ColumnEdit = Me.sec_fiyat
        Me.collFiyat7.DisplayFormat.FormatString = "#,0.00"
        Me.collFiyat7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collFiyat7.FieldName = "lFiyat7"
        Me.collFiyat7.Name = "collFiyat7"
        '
        'collFiyat8
        '
        Me.collFiyat8.Caption = "Fiyat8"
        Me.collFiyat8.ColumnEdit = Me.sec_fiyat
        Me.collFiyat8.DisplayFormat.FormatString = "#,0.00"
        Me.collFiyat8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collFiyat8.FieldName = "lFiyat8"
        Me.collFiyat8.Name = "collFiyat8"
        '
        'collFiyat9
        '
        Me.collFiyat9.Caption = "Fiyat9"
        Me.collFiyat9.ColumnEdit = Me.sec_fiyat
        Me.collFiyat9.DisplayFormat.FormatString = "#,0.00"
        Me.collFiyat9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collFiyat9.FieldName = "lFiyat9"
        Me.collFiyat9.Name = "collFiyat9"
        '
        'collFiyat10
        '
        Me.collFiyat10.Caption = "Fiyat10"
        Me.collFiyat10.ColumnEdit = Me.sec_fiyat
        Me.collFiyat10.DisplayFormat.FormatString = "#,0.00"
        Me.collFiyat10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collFiyat10.FieldName = "lFiyat10"
        Me.collFiyat10.Name = "collFiyat10"
        '
        'colORAN7
        '
        Me.colORAN7.Caption = "%Oran7"
        Me.colORAN7.ColumnEdit = Me.sec_oran
        Me.colORAN7.FieldName = "ORAN7"
        Me.colORAN7.Name = "colORAN7"
        '
        'colORAN8
        '
        Me.colORAN8.Caption = "%Oran8"
        Me.colORAN8.ColumnEdit = Me.sec_oran
        Me.colORAN8.FieldName = "ORAN8"
        Me.colORAN8.Name = "colORAN8"
        '
        'colORAN9
        '
        Me.colORAN9.Caption = "%Oran9"
        Me.colORAN9.ColumnEdit = Me.sec_oran
        Me.colORAN9.FieldName = "ORAN9"
        Me.colORAN9.Name = "colORAN9"
        '
        'colORAN10
        '
        Me.colORAN10.Caption = "%Oran10"
        Me.colORAN10.ColumnEdit = Me.sec_oran
        Me.colORAN10.FieldName = "ORAN10"
        Me.colORAN10.Name = "colORAN10"
        '
        'colKAR8
        '
        Me.colKAR8.Caption = "8. Fiyat Kar"
        Me.colKAR8.DisplayFormat.FormatString = "#,0.00"
        Me.colKAR8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKAR8.FieldName = "KAR8"
        Me.colKAR8.Name = "colKAR8"
        Me.colKAR8.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KAR8", "{0:#,0.00}")})
        '
        'colKAR9
        '
        Me.colKAR9.Caption = "9. Fiyat Kar"
        Me.colKAR9.DisplayFormat.FormatString = "#,0.00"
        Me.colKAR9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKAR9.FieldName = "KAR9"
        Me.colKAR9.Name = "colKAR9"
        Me.colKAR9.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KAR9", "{0:#,0.00}")})
        '
        'colKAR10
        '
        Me.colKAR10.Caption = "10. Fiyat Kar"
        Me.colKAR10.DisplayFormat.FormatString = "#,0.00"
        Me.colKAR10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKAR10.Name = "colKAR10"
        Me.colKAR10.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:#,0.00}")})
        '
        'colKAR11
        '
        Me.colKAR11.Caption = "Özel Fiyat Kar"
        Me.colKAR11.DisplayFormat.FormatString = "#,0.00"
        Me.colKAR11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKAR11.FieldName = "KAR11"
        Me.colKAR11.Name = "colKAR11"
        Me.colKAR11.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KAR11", "{0:#,0.00}")})
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_sFiltre)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(820, 61)
        Me.GroupControl1.TabIndex = 14
        Me.GroupControl1.Text = "Listeleme Kriterleri"
        '
        'sec_sFiltre
        '
        Me.sec_sFiltre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sec_sFiltre.Location = New System.Drawing.Point(2, 15)
        Me.sec_sFiltre.MenuManager = Me.BarManager1
        Me.sec_sFiltre.Name = "sec_sFiltre"
        Me.sec_sFiltre.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sec_sFiltre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_sFiltre.Properties.Appearance.Options.UseBackColor = True
        Me.sec_sFiltre.Properties.Appearance.Options.UseFont = True
        Me.sec_sFiltre.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Tümü"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Farklý Gelenler"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Yeni Ürünler"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Fiyatý Deðiþenler"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Promosyonlar"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Zararýna Fiyat-1"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Zararýna Fiyat-2"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Zararýna Fiyat-3"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Zararýna Satýþlar")})
        Me.sec_sFiltre.Size = New System.Drawing.Size(816, 44)
        Me.sec_sFiltre.TabIndex = 0
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Fatura Karlýlýk Analizi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_stok_cari_alis_karlilik
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 450)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_cari_alis_karlilik"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fatura Karlýlýk Analizi"
        CType(Me.sec_oran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.sec_bKdvHaric.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelstatus.ResumeLayout(False)
        Me.Panelstatus.PerformLayout()
        CType(Me.ProgressBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataset1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_fiyat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.sec_sFiltre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public kullanici
    Public fistipi As String
    Public tarih As DateTime
    Public firmaID As String
    Public nStokFisiID As String = ""
    Public sAciklama As String = ""
    Public nSiparisTipi As Integer = 0
    Public fisno As String
    Public nGirisCikis As String
    Public sFiyatTipi As String
    Public bKdvKontrolluMaliyet As String = "False"
    Dim ds_alislar As DataSet
    Dim ds_stok As DataSet
    Dim dr As DataRow
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        colPESIN.Caption = sFiyat1Aciklama
        colALTIAY.Caption = sFiyat2Aciklama
        colONAY.Caption = sFiyat3Aciklama
        collFiyat4.Caption = sFiyat4Aciklama
        collFiyat5.Caption = sFiyat5Aciklama
        collFiyat6.Caption = sFiyat6Aciklama
        collFiyat7.Caption = sFiyat7Aciklama
        collFiyat8.Caption = sFiyat8Aciklama
        collFiyat9.Caption = sFiyat9Aciklama
        collFiyat10.Caption = sFiyat10Aciklama
        'Try
        '    bKdvKontrolluMaliyet = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("FIS").GetValue("bKdvKontrolluMaliyet").ToString
        'Catch ex As Exception
        '    bKdvKontrolluMaliyet = True
        '    Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("FIS").SetValue("bKdvKontrolluMaliyet", bKdvKontrolluMaliyet.ToString())
        'End Try
        If sDatabaseGenel = "UGURLU" Then
            sec_bKdvHaric.Checked = Boolean.Parse(bKdvKontrolluMaliyet)
        End If
        If nGirisCikis = 1 Or nGirisCikis = 2 Then
            colTOPLAMMALIYET.OptionsColumn.ShowInCustomizationForm = False
            colTOPLAMMALIYET.Visible = False
            colKAR.OptionsColumn.ShowInCustomizationForm = False
            colKAR.Visible = False
            colORAN.OptionsColumn.ShowInCustomizationForm = False
            colORAN.Visible = False
        ElseIf nGirisCikis = 3 Or nGirisCikis = 4 Then
            colKAR.OptionsColumn.ShowInCustomizationForm = True
            colORAN.OptionsColumn.ShowInCustomizationForm = True
            colMALIYET.OptionsColumn.ShowInCustomizationForm = True
            colMALIYET.VisibleIndex = colGERCEKFIYAT.VisibleIndex + 1
            colKAR.Visible = True
            colORAN.Visible = True
            colMALIYET.Visible = True
            colKAR1.OptionsColumn.ShowInCustomizationForm = False
            colKAR2.OptionsColumn.ShowInCustomizationForm = False
            colKAR3.OptionsColumn.ShowInCustomizationForm = False
            colORAN1.OptionsColumn.ShowInCustomizationForm = False
            colORAN2.OptionsColumn.ShowInCustomizationForm = False
            colORAN3.OptionsColumn.ShowInCustomizationForm = False
            collFark.OptionsColumn.ShowInCustomizationForm = False
            colnFarkOran.OptionsColumn.ShowInCustomizationForm = False
            colONCEKIMALIYET.OptionsColumn.ShowInCustomizationForm = False
            colsDurum.OptionsColumn.ShowInCustomizationForm = False
            colKAR1.Visible = False
            colKAR2.Visible = False
            colKAR3.Visible = False
            colKAR4.Visible = False
            colKAR5.Visible = False
            colKAR6.Visible = False
            colKAR7.Visible = False
            colKAR8.Visible = False
            colKAR9.Visible = False
            colKAR10.Visible = False
            colORAN1.Visible = False
            colORAN2.Visible = False
            colORAN3.Visible = False
            colORAN4.Visible = False
            colORAN5.Visible = False
            colORAN6.Visible = False
            colORAN7.Visible = False
            colORAN8.Visible = False
            colORAN9.Visible = False
            colORAN10.Visible = False
            collFark.Visible = False
            colnFarkOran.Visible = False
            colONCEKIMALIYET.Visible = False
            colsDurum.Visible = False
        End If
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
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
        GridView1.SaveLayoutToRegistry("SOFTWARE\BARKODYAZILIM\VIEW\MAGAZA\" & Me.Name.ToString & "\" & nGirisCikis & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
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
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BARKODYAZILIM\VIEW\MAGAZA\" & Me.Name.ToString & "\" & nGirisCikis & "")
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
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If fistipi = "AS" Or fistipi = "VS" Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSiparis.nSiparisID AS nStokFisiID, tbFirma.sKodu as sFirmaKodu,tbFirma.sAciklama as sFirmaAdi,tbSiparis.dteSiparisTarihi AS dteFisTarihi, tbStok.sKodu, tbStok.sModel, tbStok.nFiyatlandirma, tbStok.sRenk, tbStok.sBeden, tbStok.sKavala, tbStok.nStokID AS STOKNO, tbStok.sAciklama, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani, (SELECT     MAX(dteFiyatTespitTarihi) AS nKayit FROM         tbStokFiyati WHERE      (sFiyatTipi IN ('" & sFiyat1 & "', '" & sFiyat2 & "', '" & sFiyat3 & "')) and nStokID = tbStok.nStokID) dteFiyatTespitTarihi,(SELECT COUNT(DISTINCT nStokID) AS nKayit FROM tbStokFiyati WHERE (dteFiyatTespitTarihi between '" & DateAdd(DateInterval.Day, -3, dteSistemTarihi) & "' and '" & dteSistemTarihi & "') AND (sFiyatTipi IN ('" & sFiyat1 & "' , '" & sFiyat2 & "' , '" & sFiyat3 & "')) AND nStokID = tbStok.nStokID) AS bFiyatDegisti, CASE WHEN (CONVERT (char(10) , tbStok.dteKayitTarihi , 103) = '" & dteSistemTarihi & "') THEN 1 ELSE 0 END AS bYeni, CASE WHEN tbSiparis.nSiparisTipi = 2 THEN lMiktari ELSE 0 END AS lGirisMiktar1, 0 AS lGirisMiktari2, CASE WHEN tbSiparis.nSiparisTipi = 1 OR tbSiparis.nSiparisTipi = 3 THEN lMiktari ELSE 0 END AS lCikisMiktar1, 0 AS lCikisMiktar2, CASE WHEN tbSiparis.nSiparisTipi = 2 THEN lTutari / lMiktari ELSE 0 END AS lGirisFiyat, CASE WHEN tbSiparis.nSiparisTipi = 1 OR tbSiparis.nSiparisTipi = 3 THEN lTutari / lMiktari ELSE 0 END AS lCikisFiyat, CASE WHEN tbSiparis.nSiparisTipi = 2 THEN lTutari ELSE 0 END AS lGirisTutar, CASE WHEN tbSiparis.nSiparisTipi = 1 OR tbSiparis.nSiparisTipi = 3 THEN lTutari ELSE 0 END AS lCikisTutar, tbSiparis.sFiyatTipi, tbSiparis.lFiyati AS lBrutFiyat, tbSiparis.lIskontosuzTutari AS lBrutTutar, tbSiparis.nIskontoYuzdesi, tbSiparis.lIskontosuzTutari - tbSiparis.lTutari AS lIskontoTutari, tbSiparis.sDovizCinsi, tbSiparis.lDovizFiyati, 0 AS lIlaveMaliyetTutar, 0 AS lEkIlaveMaliyetTutar, tbSiparis.nSiparisID, tbSiparis.dteSiparisTarihi AS dteIrsaliyeTarihi, 0 AS lIrsaliyeNo, tbSiparis.sDepo, tbSiparis.nStokID, tbSiparis.nFirmaID, '' AS nIrsaliyeFisiID, '' AS sStokIslem, 0 AS nOTVOrani, tbSiparis.nKdvOrani, tbSiparis.nSiparisID AS nIslemID, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 39, 5) AS MONEY) AS ISK4, CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, CAST(0 AS MONEY) AS EKMASRAF, CAST(0 AS MONEY) AS ONCEKIMALIYET, '01/01/1900' AS ONCEKIALISTARIHI, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ALTIAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS lFiyat4, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat5 & "') AS lFiyat5,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat6 & "') AS lFiyat6,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat7 & "') AS lFiyat7,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat8 & "') AS lFiyat8,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat9 & "') AS lFiyat9,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat10 & "') AS lFiyat10,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "') AS lOzelFiyat, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, (SELECT ISNULL(tbSSinif5.sAciklama , '') AS sAciklama FROM tbStokSinifi INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE (tbStokSinifi.nStokID = tbSiparis.nStokID)) AS SINIF5, CAST(0 AS MONEY) AS TOPLAMMALIYET, CAST(0 AS MONEY) AS ORAN, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS ORAN2, CAST(0 AS MONEY) AS ORAN3, CAST(0 AS MONEY) AS ORAN4, CAST(0 AS MONEY) AS ORAN5,CAST(0 AS MONEY) AS ORAN6,CAST(0 AS MONEY) AS ORAN7,CAST(0 AS MONEY) AS ORAN8,CAST(0 AS MONEY) AS ORAN9,CAST(0 AS MONEY) AS ORAN10,CAST(0 AS MONEY) AS ORAN11, 0 AS lEkMaliyet1, 0 AS lEkMaliyet2, 0 AS lEkMaliyet3, 0 AS lEkMaliyet4, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS KAR1, CAST(0 AS MONEY) AS KAR2, CAST(0 AS MONEY) AS KAR3, CAST(0 AS MONEY) AS KAR4, CAST(0 AS MONEY) AS KAR5, CAST(0 AS MONEY) AS KAR6,CAST(0 AS MONEY) AS KAR7,CAST(0 AS MONEY) AS KAR8,CAST(0 AS MONEY) AS KAR9,CAST(0 AS MONEY) AS KAR10,CAST(0 AS MONEY) AS KAR11,CAST(0 AS MONEY) AS PESINTUTAR, CAST(0 AS MONEY) AS ONAYTUTAR, CAST(0 AS MONEY) AS ALTIAYTUTAR, CAST(0 AS MONEY) AS FIYATTUTAR4, CAST(0 AS MONEY) AS FIYATTUTAR5, CAST(0 AS MONEY) AS FIYATTUTAR6,CAST(0 AS MONEY) AS FIYATTUTAR7,CAST(0 AS MONEY) AS FIYATTUTAR8,CAST(0 AS MONEY) AS FIYATTUTAR9,CAST(0 AS MONEY) AS FIYATTUTAR10,CAST(0 AS MONEY) AS FIYATTUTAR11,CAST(0 AS MONEY) AS lFark, CAST(0 AS MONEY) AS nFarkOran, 'Normal' AS sDurum, tbSiparis.dteSiparisTarihi AS dteFisTarihi, tbSiparis.lSiparisNo, tbSiparis.lIskontosuzTutari AS lMalBedeli, tbSiparis.lTutari AS lNetTutar, tbSiparis.lIskontosuzTutari - tbSiparis.lTutari AS lMalIskontoTutari FROM tbSiparis INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID INNER JOIN                       tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID WHERE tbSiparis.dteSiparisTarihi = '" & tarih & "' and (tbSiparis.nFirmaID = " & firmaID & ") AND (tbSiparis.lSiparisNo = " & fisno & " ) and tbSiparis.nSiparisTipi = " & nSiparisTipi & " ")
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.dteFisTarihi,tbFirma.sKodu as sFirmaKodu,tbFirma.sAciklama as sFirmaAdi,tbStok.sKodu,tbStok.sModel,tbStok.nFiyatlandirma,tbStok.sRenk,tbStok.sBeden,tbStok.sKavala,tbStokFisiDetayi.nStokID as STOKNO, tbStok.sAciklama, (SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani,(SELECT     MAX(dteFiyatTespitTarihi) AS nKayit FROM         tbStokFiyati WHERE      (sFiyatTipi IN ('" & sFiyat1 & "', '" & sFiyat2 & "', '" & sFiyat3 & "')) and nStokID = tbStok.nStokID) dteFiyatTespitTarihi,(SELECT     COUNT(DISTINCT nStokID) AS nKayit FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi between '" & DateAdd(DateInterval.Day, -3, dteSistemTarihi) & "' and '" & dteSistemTarihi & "') AND (sFiyatTipi IN ('" & sFiyat1 & "', '" & sFiyat2 & "', '" & sFiyat3 & "')) and nStokID = tbStok.nStokID) bFiyatDegisti,bYeni = Case When (CONVERT(char(10), tbStok.dteKayitTarihi, 103) = '" & dteSistemTarihi & "') Then 1 else 0 END,tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.lGirisMiktar2,tbStokFisiDetayi.lCikisMiktar1, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lCikisFiyat,tbStokFisiDetayi.lGirisTutar,tbStokFisiDetayi.lCikisTutar, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.nIskontoYuzdesi, tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.sDovizCinsi, tbStokFisiDetayi.lDovizFiyat, tbStokFisiDetayi.lIlaveMaliyetTutar,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,tbStokFisiDetayi.nSiparisID, tbStokFisiDetayi.sAciklama AS Expr1, tbStokFisiDetayi.dteIrsaliyeTarihi, tbStokFisiDetayi.lIrsaliyeNo, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.nStokID, tbStokFisiDetayi.nFirmaID, tbStokFisiDetayi.nIrsaliyeFisiID, tbStokFisiDetayi.sStokIslem, tbStokFisiDetayi.nOTVOrani, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.nIslemID, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, CAST(0 AS MONEY) AS EKMASRAF, CAST(0 AS MONEY) AS ONCEKIMALIYET,'01/01/1900' as ONCEKIALISTARIHI, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS lFiyat4,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat5 & "') AS lFiyat5,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat6 & "') AS lFiyat6,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat7 & "') AS lFiyat7,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat8 & "') AS lFiyat8,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat9 & "') AS lFiyat9,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat10 & "') AS lFiyat10,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "') AS lOzelFiyat, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, (SELECT     ISNULL(tbSSinif5.sAciklama,'') as sAciklama FROM         tbStokSinifi INNER JOIN                       tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE     (tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID)) AS SINIF5,CAST(0 AS MONEY) AS TOPLAMMALIYET,CAST(0 AS MONEY) AS ORAN,CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS ORAN2, CAST(0 AS MONEY) AS ORAN3, CAST(0 AS MONEY) AS ORAN4,CAST(0 AS MONEY) AS ORAN5,CAST(0 AS MONEY) AS ORAN6,CAST(0 AS MONEY) AS ORAN7,CAST(0 AS MONEY) AS ORAN8,CAST(0 AS MONEY) AS ORAN9,CAST(0 AS MONEY) AS ORAN10,CAST(0 AS MONEY) AS ORAN11,tbStokFisiMaster.lEkmaliyet1,tbStokFisiMaster.lEkmaliyet3,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiMaster.nStokFisiID and nIslemID =0 ) AS lEkMaliyet4, CAST(0 AS MONEY) AS KAR,CAST(0 AS MONEY) AS KAR1, CAST(0 AS MONEY) AS KAR2, CAST(0 AS MONEY) AS KAR3,CAST(0 AS MONEY) AS KAR4,CAST(0 AS MONEY) AS KAR5,CAST(0 AS MONEY) AS KAR6,CAST(0 AS MONEY) AS KAR7, CAST(0 AS MONEY) AS KAR8,CAST(0 AS MONEY) AS KAR9,CAST(0 AS MONEY) AS KAR10,CAST(0 AS MONEY) AS KAR11,CAST(0 AS MONEY) AS PESINTUTAR, CAST(0 AS MONEY) AS ONAYTUTAR, CAST(0 AS MONEY) AS ALTIAYTUTAR,CAST(0 AS MONEY) AS FIYATTUTAR4,CAST(0 AS MONEY) AS FIYATTUTAR5,CAST(0 AS MONEY) AS FIYATTUTAR6,CAST(0 AS MONEY) AS FIYATTUTAR7,CAST(0 AS MONEY) AS FIYATTUTAR8,CAST(0 AS MONEY) AS FIYATTUTAR9,CAST(0 AS MONEY) AS FIYATTUTAR10,CAST(0 AS MONEY) AS FIYATTUTAR11,CAST(0 AS MONEY) AS lFark,CAST(0 AS MONEY) AS nFarkOran,'Normal' AS sDurum,tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.lMalBedeli,tbStokFisiMaster.lNetTutar, tbStokFisiMaster.lMalIskontoTutari FROM tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN                       tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID WHERE (tbStokFisiMaster.sFisTipi = '" & fistipi & "') AND (tbStokFisiMaster.dteFisTarihi = '" & tarih & "') AND (tbStokFisiMaster.nFirmaID = '" & firmaID & "') AND (tbStokFisiMaster.lFisNo = '" & fisno & "') AND (tbStokFisiMaster.nGirisCikis = " & nGirisCikis & ") ORDER BY  tbStokFisiDetayi.nEkSaha1,tbStokFisiDetayi.nIslemID")
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
    Private Sub dataload()
        dataset1 = stok()
        GridControl1.DataSource = dataset1.Tables(0)
        GridControl1.DataMember = Nothing
        kontrol_oran()
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
        GridView1.UpdateSummary()
        GridView1.UpdateTotalSummary()
        Dim dr As DataRow
        Dim kar As Decimal = 0
        Dim kar1 As Decimal = 0
        Dim kar2 As Decimal = 0
        Dim kar3 As Decimal = 0
        Dim kar4 As Decimal = 0
        Dim kar5 As Decimal = 0
        Dim kar6 As Decimal = 0
        Dim kar7 As Decimal = 0
        Dim kar8 As Decimal = 0
        Dim kar9 As Decimal = 0
        Dim kar10 As Decimal = 0
        Dim lMaliyet As Decimal = 0
        For Each dr In dataset1.Tables(0).Rows
            kar += dr("KAR")
            kar1 += dr("KAR1")
            kar2 += dr("KAR2")
            kar3 += dr("KAR3")
            kar4 += dr("KAR4")
            kar5 += dr("KAR5")
            kar6 += dr("KAR6")
            kar7 += dr("KAR7")
            kar8 += dr("KAR8")
            kar9 += dr("KAR9")
            kar10 += dr("KAR10")
            If nGirisCikis = 3 Or nGirisCikis = 4 Then
                lMaliyet += dr("TOPLAMMALIYET")
            ElseIf nGirisCikis = 1 Or nGirisCikis = 2 Then
                lMaliyet += dr("GERCEKTOPLAM")
            End If
        Next
        Try
            If nGirisCikis = 3 Or nGirisCikis = 4 Then
                lbl_Karlilik.Text = "Ortalama Karlýlýk = %" & FormatNumber((kar / lMaliyet) * 100, 2)
                colORAN.SummaryItem.DisplayFormat = "%" & FormatNumber((kar / lMaliyet) * 100, 2)
            ElseIf nGirisCikis = 1 Or nGirisCikis = 2 Then
                lbl_Karlilik.Text = "Ortalama Karlýlýk, Fiyat1 = %" & FormatNumber((kar1 / lMaliyet) * 100, 2) & " Fiyat2 = %" & FormatNumber((kar2 / lMaliyet) * 100, 2) & " Fiyat3 = %" & FormatNumber((kar3 / lMaliyet) * 100, 2)
                colORAN1.SummaryItem.DisplayFormat = "%" & FormatNumber((kar1 / lMaliyet) * 100, 2)
                colORAN2.SummaryItem.DisplayFormat = "%" & FormatNumber((kar2 / lMaliyet) * 100, 2)
                colORAN3.SummaryItem.DisplayFormat = "%" & FormatNumber((kar3 / lMaliyet) * 100, 2)
                colORAN4.SummaryItem.DisplayFormat = "%" & FormatNumber((kar4 / lMaliyet) * 100, 2)
                colORAN5.SummaryItem.DisplayFormat = "%" & FormatNumber((kar5 / lMaliyet) * 100, 2)
                colORAN6.SummaryItem.DisplayFormat = "%" & FormatNumber((kar6 / lMaliyet) * 100, 2)
                colORAN7.SummaryItem.DisplayFormat = "%" & FormatNumber((kar7 / lMaliyet) * 100, 2)
                colORAN8.SummaryItem.DisplayFormat = "%" & FormatNumber((kar8 / lMaliyet) * 100, 2)
                colORAN9.SummaryItem.DisplayFormat = "%" & FormatNumber((kar9 / lMaliyet) * 100, 2)
                colORAN10.SummaryItem.DisplayFormat = "%" & FormatNumber((kar10 / lMaliyet) * 100, 2)
            End If
        Catch ex As Exception
        End Try
        kar1 = Nothing
        kar2 = Nothing
        kar3 = Nothing
        kar4 = Nothing
        kar5 = Nothing
        kar6 = Nothing
        kar7 = Nothing
        kar8 = Nothing
        kar9 = Nothing
        kar10 = Nothing
        lMaliyet = Nothing
    End Sub
    Public Function sorgu_alislar(ByVal tarih As DateTime, ByVal fisno As String, ByVal stokkodu As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 tbStokFisiDetayi.lFisNo AS FISNO, tbStokFisiDetayi.dteFisTarihi AS TARIH, tbStokFisiDetayi.lGirisFiyat AS BIRIMMALIYET, tbStokFisiDetayi.lGirisMiktar1 AS MIKTAR, tbStokFisiDetayi.lBrutFiyat AS BIRIMFIYAT, tbStokFisiDetayi.lIskontoTutari AS ISKONTO, tbStokFisiDetayi.nKdvOrani AS KDV, tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS KDVLITUTAR, baslik.lToplamMiktar AS FATURAMIKTARI, baslik.lMalBedeli - baslik.lMalIskontoTutari AS FATURATUTARI, baslik.lEkmaliyet1 AS EKMALIYET, tbStok.sKodu AS STOKKODU, tbStok.sAciklama AS STOKADI,CAST(0 AS MONEY) AS ORANEKMALIYET,CAST(0 AS MONEY) AS NETMALIYET FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiMaster baslik ON tbStokFisiDetayi.nStokFisiID = baslik.nStokFisiID WHERE (tbStokFisiDetayi.nGirisCikis = 1) AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbStokFisiDetayi.dteFisTarihi  < '" & tarih & "') AND (tbFirma.sKodu LIKE '3%') and (tbstok.sKodu ='" & stokkodu & "') ORDER BY tbStokFisiDetayi.dteFisTarihi DESC, tbStokFisiDetayi.lFisNo")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 2 tbStokFisiDetayi.lFisNo AS FISNO, tbStokFisiDetayi.dteFisTarihi AS TARIH, tbStokFisiDetayi.lGirisFiyat AS BIRIMMALIYET, tbStokFisiDetayi.lGirisMiktar1 AS MIKTAR, tbStokFisiDetayi.lBrutFiyat AS BIRIMFIYAT, tbStokFisiDetayi.lIskontoTutari AS ISKONTO, tbStokFisiDetayi.nKdvOrani AS KDV, tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS KDVLITUTAR, baslik.lToplamMiktar AS FATURAMIKTARI, baslik.lMalBedeli - baslik.lMalIskontoTutari AS FATURATUTARI, baslik.lEkmaliyet1 AS EKMALIYET, tbStok.sKodu AS STOKKODU, tbStok.sAciklama AS STOKADI,CAST(0 AS MONEY) AS ORANEKMALIYET,CAST(0 AS MONEY) AS NETMALIYET FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiMaster baslik ON tbStokFisiDetayi.nStokFisiID = baslik.nStokFisiID WHERE (tbStokFisiDetayi.nGirisCikis = 1) AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbStokFisiDetayi.dteFisTarihi  < '" & tarih & "') AND (tbFirma.sKodu LIKE '3%') and (tbstok.sKodu ='" & stokkodu & "') ORDER BY tbStokFisiDetayi.dteFisTarihi DESC, tbStokFisiDetayi.lFisNo")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 2 tbStokFisiDetayi.lFisNo AS FISNO, tbStokFisiDetayi.dteFisTarihi AS TARIH, tbStokFisiDetayi.lGirisFiyat AS BIRIMMALIYET, tbStokFisiDetayi.lGirisMiktar1 AS MIKTAR, tbStokFisiDetayi.lBrutFiyat AS BIRIMFIYAT, tbStokFisiDetayi.lIskontoTutari AS ISKONTO, tbStokFisiDetayi.nKdvOrani AS KDV, tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS KDVLITUTAR, baslik.lToplamMiktar AS FATURAMIKTARI, baslik.lMalBedeli - baslik.lMalIskontoTutari AS FATURATUTARI, baslik.lEkmaliyet1 AS EKMALIYET, tbStok.sKodu AS STOKKODU, tbStok.sAciklama AS STOKADI,CAST(0 AS MONEY) AS ORANEKMALIYET,CAST(0 AS MONEY) AS NETMALIYET FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiMaster baslik ON tbStokFisiDetayi.nStokFisiID = baslik.nStokFisiID WHERE (tbStokFisiDetayi.nGirisCikis = 1) AND (tbStokFisiDetayi.dteFisTarihi  < = '" & tarih & "') AND (tbFirma.sKodu LIKE '3%') AND (tbStokFisiDetayi.lFisNo <> '" & fisno & "') and (tbstok.sKodu ='" & stokkodu & "') ORDER BY tbStokFisiDetayi.dteFisTarihi DESC, tbStokFisiDetayi.lFisNo")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub kontrol_oran()
        Dim oranekmaliyet As Decimal = 0
        Dim dr As DataRow
        Dim lMiktar As Decimal = 0
        Dim maliyet As Decimal = 0
        For Each dr In dataset1.Tables(0).Rows
            If nGirisCikis = 1 Or nGirisCikis = 2 Then
                maliyet = (dr("lGirisTutar")) / dr("lGirisMiktar1")
                If sec_bKdvHaric.Checked = False Then
                    If dr("nKdvOrani") <> dr("nStokKdvOrani") Then
                        If bKdvKontrolluMaliyet = True Then
                            maliyet = maliyet * ((dr("nStokKdvOrani") + 100) / 100)
                        Else
                            maliyet = maliyet * ((dr("nKdvOrani") + 100) / 100)
                        End If
                    Else
                        maliyet = maliyet * ((dr("nKdvOrani") + 100) / 100)
                    End If
                End If
                maliyet = (maliyet) - (Math.Abs((dr("lIlaveMaliyetTutar") + dr("lEkIlaveMaliyetTutar")) / dr("lGirisMiktar1")))
                dr("GERCEKFIYAT") = maliyet
            ElseIf nGirisCikis = 3 Or nGirisCikis = 4 Then
                dr("GERCEKFIYAT") = dr("lCikisFiyat") * ((dr("nKdvOrani") + 100) / 100)
            End If
            'MsgBox(dr_toplam("lNetTutar"))
            Try
                If CType(dr("lEkmaliyet1") + dr("lEkMaliyet3") + dr("lEkMaliyet4"), Decimal) <> 0 Then
                    oranekmaliyet = CType(dr("lEkmaliyet1") + dr("lEkmaliyet3") + dr("lEkMaliyet4"), Decimal) / CType(dr("lNetTutar") - (dr("lEkmaliyet1")), Decimal)
                    dr("EKMASRAF") = oranekmaliyet
                    dr("GERCEKFIYAT") = dr("GERCEKFIYAT") + (dr("GERCEKFIYAT") * (((oranekmaliyet * 100)) / 100))
                End If
            Catch ex As Exception
            End Try
            dr("MALIYET") = sorgu_sayi(dr("MALIYET"), 0)
            If nGirisCikis = 1 Or nGirisCikis = 2 Then
                dr("GERCEKTOPLAM") = dr("GERCEKFIYAT") * dr("lGirisMiktar1")
                dr("TOPLAMMALIYET") = sorgu_sayi(dr("MALIYET"), 0) * sorgu_sayi(dr("lGirisMiktar1"), 0)
                lMiktar = dr("lGirisMiktar1")
            ElseIf nGirisCikis = 3 Or nGirisCikis = 4 Then
                dr("GERCEKTOPLAM") = dr("GERCEKFIYAT") * dr("lCikisMiktar1")
                dr("TOPLAMMALIYET") = sorgu_sayi(dr("MALIYET"), 0) * sorgu_sayi(dr("lCikisMiktar1"), 0)
                lMiktar = dr("lCikisMiktar1")
            End If
            oranekmaliyet = 0
            dr("PESIN") = sorgu_sayi(dr("PESIN"), 0)
            dr("ALTIAY") = sorgu_sayi(dr("ALTIAY"), 0)
            dr("ONAY") = sorgu_sayi(dr("ONAY"), 0)
            dr("lFiyat4") = sorgu_sayi(dr("lFiyat4"), 0)
            dr("lFiyat5") = sorgu_sayi(dr("lFiyat5"), 0)
            dr("lFiyat6") = sorgu_sayi(dr("lFiyat6"), 0)
            dr("lFiyat7") = sorgu_sayi(dr("lFiyat7"), 0)
            dr("lFiyat8") = sorgu_sayi(dr("lFiyat8"), 0)
            dr("lFiyat9") = sorgu_sayi(dr("lFiyat9"), 0)
            dr("lFiyat10") = sorgu_sayi(dr("lFiyat10"), 0)
            'dr("GERCEKTOPLAM") = dr("GERCEKFIYAT") * dr("lGirisMiktar1")
            If nGirisCikis = 1 Or nGirisCikis = 2 Then
                Dim dr1 As DataRow
                ds_alislar = sorgu_alislar(dr("dteFisTarihi"), dr("lFisNo"), dr("sKodu"))
                Dim sayi As Integer = 0
                For Each dr1 In ds_alislar.Tables(0).Rows
                    sayi += 1
                    dr1("ORANEKMALIYET") = 0
                    dr1("NETMALIYET") = dr1("KDVLITUTAR") * ((100 + (dr1("ORANEKMALIYET") * 100)) / 100)
                    If sayi = 1 Then
                        dr("ONCEKIMALIYET") = dr1("NETMALIYET")
                        dr("ONCEKIALISTARIHI") = dr1("TARIH")
                    End If
                Next
            End If
            Try
                If dr("TOPLAMMALIYET") <> 0 Then
                    dr("ORAN") = ((dr("GERCEKTOPLAM") - dr("TOPLAMMALIYET")) / dr("TOPLAMMALIYET"))
                    dr("KAR") = dr("GERCEKTOPLAM") - dr("TOPLAMMALIYET")
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("PESIN") <> 0 Then
                    'dr("ORAN1") = ((dr("PESIN") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
                    dr("ORAN1") = ((dr("PESIN") - dr("MALIYET")) / dr("MALIYET")) * 100
                    dr("PESINTUTAR") = dr("PESIN") * lMiktar
                    dr("KAR1") = dr("PESINTUTAR") - dr("GERCEKTOPLAM")
                Else
                    dr("PESINTUTAR") = 0
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("ALTIAY") <> 0 Then
                    dr("ORAN2") = ((dr("ALTIAY") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
                    dr("ALTIAYTUTAR") = dr("ALTIAY") * lMiktar
                    dr("KAR2") = dr("ALTIAYTUTAR") - dr("GERCEKTOPLAM")
                Else
                    dr("ALTIAYTUTAR") = 0
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("ONAY") <> 0 Then
                    dr("ORAN3") = ((dr("ONAY") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
                    dr("ONAYTUTAR") = dr("ONAY") * lMiktar
                    dr("KAR3") = dr("ONAYTUTAR") - dr("GERCEKTOPLAM")
                Else
                    dr("ONAYTUTAR") = 0
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("lFiyat4") <> 0 Then
                    dr("ORAN4") = ((dr("lFiyat4") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
                    dr("FIYATTUTAR4") = dr("lFiyat4") * lMiktar
                    dr("KAR4") = dr("FIYATTUTAR4") - dr("GERCEKTOPLAM")
                Else
                    dr("FIYATTUTAR4") = 0
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("lFiyat5") <> 0 Then
                    dr("ORAN5") = ((dr("lFiyat5") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
                    dr("FIYATTUTAR5") = dr("lFiyat5") * lMiktar
                    dr("KAR5") = dr("FIYATTUTAR5") - dr("GERCEKTOPLAM")
                Else
                    dr("FIYATTUTAR4") = 0
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("lFiyat6") <> 0 Then
                    dr("ORAN6") = ((dr("lFiyat6") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
                    dr("FIYATTUTAR6") = dr("lFiyat6") * lMiktar
                    dr("KAR6") = dr("FIYATTUTAR6") - dr("GERCEKTOPLAM")
                Else
                    dr("FIYATTUTAR6") = 0
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("lFiyat7") <> 0 Then
                    dr("ORAN7") = ((dr("lFiyat7") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
                    dr("FIYATTUTAR7") = dr("lFiyat7") * lMiktar
                    dr("KAR7") = dr("FIYATTUTAR7") - dr("GERCEKTOPLAM")
                Else
                    dr("FIYATTUTAR7") = 0
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("lFiyat8") <> 0 Then
                    dr("ORAN8") = ((dr("lFiyat8") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
                    dr("FIYATTUTAR8") = dr("lFiyat8") * lMiktar
                    dr("KAR8") = dr("FIYATTUTAR8") - dr("GERCEKTOPLAM")
                Else
                    dr("FIYATTUTAR8") = 0
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("lFiyat9") <> 0 Then
                    dr("ORAN9") = ((dr("lFiyat9") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
                    dr("FIYATTUTAR9") = dr("lFiyat9") * lMiktar
                    dr("KAR9") = dr("FIYATTUTAR9") - dr("GERCEKTOPLAM")
                Else
                    dr("FIYATTUTAR9") = 0
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("lFiyat10") <> 0 Then
                    dr("ORAN10") = ((dr("lFiyat10") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
                    dr("FIYATTUTAR10") = dr("lFiyat10") * lMiktar
                    dr("KAR10") = dr("FIYATTUTAR10") - dr("GERCEKTOPLAM")
                Else
                    dr("FIYATTUTAR10") = 0
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("lOzelFiyat") <> 0 Then
                    dr("ORAN11") = ((dr("lOzelFiyat") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
                    dr("FIYATTUTAR11") = dr("lOzelFiyat") * lMiktar
                    dr("KAR11") = dr("FIYATTUTAR11") - dr("GERCEKTOPLAM")
                Else
                    dr("FIYATTUTAR11") = 0
                End If
            Catch ex As Exception
            End Try
            dr("lGirisMiktar1") = lMiktar
            If dr("ONCEKIMALIYET") = 0 Then
                If dr("GERCEKFIYAT") = 0 Then
                    If ds_alislar.Tables(0).Rows.Count = 0 Then
                        dr("sDurum") = "ÝlkGiriþ"
                    Else
                        dr("sDurum") = "Yeni"
                    End If
                Else
                    dr("sDurum") = "Bedelsiz"
                End If
            End If
            dr("lFark") = FormatNumber((Math.Abs(dr("GERCEKFIYAT"))) - (Math.Abs(dr("ONCEKIMALIYET"))), 2)
            Try
                dr("nFarkOran") = dr("lFark") / dr("ONCEKIMALIYET")
            Catch ex As Exception
                dr("nFarkOran") = 0
            End Try
            If dr("lFark") > 0 Then
                If dr("ONCEKIMALIYET") = 0 Then
                    If dr("GERCEKFIYAT") = 0 Then
                        If ds_alislar.Tables(0).Rows.Count = 0 Then
                            dr("sDurum") = "ÝlkGiriþ"
                        Else
                            dr("sDurum") = "Bedelsiz"
                        End If
                    Else
                        'If ds_alislar.Tables(0).Rows.Count = 0 Then
                        '    dr("sDurum") = "ÝlkGiriþ"
                        'Else
                        dr("sDurum") = "Pahalý"
                        'End If
                    End If
                Else
                    dr("sDurum") = "Pahalý"
                End If
            ElseIf dr("lFark") < 0 Then
                dr("sDurum") = "Ucuz"
            ElseIf dr("lFark") = 0 Then
                'dr("Durum") = "Normal"
            End If
        Next
        lMiktar = Nothing
        maliyet = Nothing
    End Sub
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub oran_kontrol()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.BeginEdit()
            Dim lMiktar As Decimal = 0
            If nGirisCikis = 1 Or nGirisCikis = 2 Then
                dr("GERCEKTOPLAM") = dr("GERCEKFIYAT") * dr("lGirisMiktar1")
                lMiktar = dr("lGirisMiktar1")
            ElseIf nGirisCikis = 3 Or nGirisCikis = 4 Then
                dr("GERCEKTOPLAM") = dr("GERCEKFIYAT") * dr("lCikisMiktar1")
                lMiktar = dr("lCikisMiktar1")
            End If
            Try
                If dr("PESIN") <> 0 Then
                    'dr("ORAN1") = ((dr("PESIN") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
                    dr("ORAN1") = ((dr("PESIN") - dr("MALIYET")) / dr("MALIYET")) * 100
                    dr("PESINTUTAR") = dr("PESIN") * lMiktar
                    dr("KAR1") = dr("PESINTUTAR") - dr("GERCEKTOPLAM")
                Else
                    dr("PESINTUTAR") = 0
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("ALTIAY") <> 0 Then
                    dr("ORAN2") = ((dr("ALTIAY") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
                    dr("ALTIAYTUTAR") = dr("ALTIAY") * lMiktar
                    dr("KAR2") = dr("ALTIAYTUTAR") - dr("GERCEKTOPLAM")
                Else
                    dr("ALTIAYTUTAR") = 0
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("ONAY") <> 0 Then
                    dr("ORAN3") = ((dr("ONAY") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
                    dr("ONAYTUTAR") = dr("ONAY") * lMiktar
                    dr("KAR3") = dr("ONAYTUTAR") - dr("GERCEKTOPLAM")
                Else
                    dr("ONAYTUTAR") = 0
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("lFiyat4") <> 0 Then
                    dr("ORAN4") = ((dr("lFiyat4") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
                    dr("FIYATTUTAR4") = dr("lFiyat4") * lMiktar
                    dr("KAR4") = dr("FIYATTUTAR4") - dr("GERCEKTOPLAM")
                Else
                    dr("FIYATTUTAR4") = 0
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("lFiyat5") <> 0 Then
                    dr("ORAN5") = ((dr("lFiyat5") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
                    dr("FIYATTUTAR5") = dr("lFiyat5") * lMiktar
                    dr("KAR5") = dr("FIYATTUTAR5") - dr("GERCEKTOPLAM")
                Else
                    dr("FIYATTUTAR5") = 0
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("lFiyat6") <> 0 Then
                    dr("ORAN6") = ((dr("lFiyat6") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
                    dr("FIYATTUTAR6") = dr("lFiyat6") * lMiktar
                    dr("KAR6") = dr("FIYATTUTAR6") - dr("GERCEKTOPLAM")
                Else
                    dr("FIYATTUTAR6") = 0
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("lFiyat7") <> 0 Then
                    dr("ORAN7") = ((dr("lFiyat7") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
                    dr("FIYATTUTAR7") = dr("lFiyat7") * lMiktar
                    dr("KAR7") = dr("FIYATTUTAR7") - dr("GERCEKTOPLAM")
                Else
                    dr("FIYATTUTAR7") = 0
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("lFiyat8") <> 0 Then
                    dr("ORAN8") = ((dr("lFiyat8") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
                    dr("FIYATTUTAR8") = dr("lFiyat8") * lMiktar
                    dr("KAR8") = dr("FIYATTUTAR8") - dr("GERCEKTOPLAM")
                Else
                    dr("FIYATTUTAR8") = 0
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("lFiyat9") <> 0 Then
                    dr("ORAN9") = ((dr("lFiyat9") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
                    dr("FIYATTUTAR9") = dr("lFiyat9") * lMiktar
                    dr("KAR9") = dr("FIYATTUTAR9") - dr("GERCEKTOPLAM")
                Else
                    dr("FIYATTUTAR9") = 0
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("lFiyat10") <> 0 Then
                    dr("ORAN10") = ((dr("lFiyat10") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
                    dr("FIYATTUTAR10") = dr("lFiyat10") * lMiktar
                    dr("KAR10") = dr("FIYATTUTAR10") - dr("GERCEKTOPLAM")
                Else
                    dr("FIYATTUTAR10") = 0
                End If
            Catch ex As Exception
            End Try
            dr.EndEdit()
            'girdi_tutar_hesapla()
            dr = Nothing
        End If
    End Sub
    Private Sub fiyat_kontrol()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.BeginEdit()
            Dim lMiktar As Decimal = 0
            If nGirisCikis = 1 Or nGirisCikis = 2 Then
                dr("GERCEKTOPLAM") = dr("GERCEKFIYAT") * dr("lGirisMiktar1")
                lMiktar = dr("lGirisMiktar1")
            ElseIf nGirisCikis = 3 Or nGirisCikis = 4 Then
                dr("GERCEKTOPLAM") = dr("GERCEKFIYAT") * dr("lCikisMiktar1")
                lMiktar = dr("lCikisMiktar1")
            End If
            If dr("ORAN1") <> 0 Then
                dr("PESIN") = dr("GERCEKFIYAT") * ((dr("ORAN1") + 100) / 100)
                dr("PESINTUTAR") = dr("PESIN") * lMiktar
                dr("KAR1") = dr("PESINTUTAR") - dr("GERCEKTOPLAM")
            End If
            If dr("ORAN2") <> 0 Then
                dr("ALTIAY") = dr("GERCEKFIYAT") * ((dr("ORAN2") + 100) / 100)
                dr("ALTIAYTUTAR") = dr("ALTIAY") * lMiktar
                dr("KAR2") = dr("ALTIAYTUTAR") - dr("GERCEKTOPLAM")
            End If
            If dr("ORAN3") <> 0 Then
                dr("ONAY") = dr("GERCEKFIYAT") * ((dr("ORAN3") + 100) / 100)
                dr("ONAYTUTAR") = dr("ONAY") * lMiktar
                dr("KAR3") = dr("ONAYTUTAR") - dr("GERCEKTOPLAM")
            End If
            If dr("ORAN4") <> 0 Then
                dr("lFiyat4") = dr("GERCEKFIYAT") * ((dr("ORAN3") + 100) / 100)
                dr("FIYATTUTAR4") = dr("lFiyat4") * lMiktar
                dr("KAR4") = dr("FIYATTUTAR4") - dr("GERCEKTOPLAM")
            End If
            If dr("ORAN5") <> 0 Then
                dr("lFiyat5") = dr("GERCEKFIYAT") * ((dr("ORAN5") + 100) / 100)
                dr("FIYATTUTAR5") = dr("lFiyat5") * lMiktar
                dr("KAR5") = dr("FIYATTUTAR5") - dr("GERCEKTOPLAM")
            End If
            If dr("ORAN6") <> 0 Then
                dr("lFiyat6") = dr("GERCEKFIYAT") * ((dr("ORAN6") + 100) / 100)
                dr("FIYATTUTAR6") = dr("lFiyat6") * lMiktar
                dr("KAR6") = dr("FIYATTUTAR6") - dr("GERCEKTOPLAM")
            End If
            If dr("ORAN7") <> 0 Then
                dr("lFiyat7") = dr("GERCEKFIYAT") * ((dr("ORAN7") + 100) / 100)
                dr("FIYATTUTAR7") = dr("lFiyat7") * lMiktar
                dr("KAR7") = dr("FIYATTUTAR7") - dr("GERCEKTOPLAM")
            End If
            If dr("ORAN8") <> 0 Then
                dr("lFiyat8") = dr("GERCEKFIYAT") * ((dr("ORAN8") + 100) / 100)
                dr("FIYATTUTAR8") = dr("lFiyat8") * lMiktar
                dr("KAR8") = dr("FIYATTUTAR8") - dr("GERCEKTOPLAM")
            End If
            If dr("ORAN9") <> 0 Then
                dr("lFiyat9") = dr("GERCEKFIYAT") * ((dr("ORAN9") + 100) / 100)
                dr("FIYATTUTAR9") = dr("lFiyat9") * lMiktar
                dr("KAR9") = dr("FIYATTUTAR9") - dr("GERCEKTOPLAM")
            End If
            If dr("ORAN10") <> 0 Then
                dr("lFiyat10") = dr("GERCEKFIYAT") * ((dr("ORAN10") + 100) / 100)
                dr("FIYATTUTAR10") = dr("lFiyat10") * lMiktar
                dr("KAR10") = dr("FIYATTUTAR10") - dr("GERCEKTOPLAM")
            End If
            dr.EndEdit()
            dr = Nothing
            'girdi_tutar_hesapla()
        End If
    End Sub
    Private Sub degeryay(ByVal columnkriter As String)
        'kl = CType(Me.BindingContext(DataView1), CurrencyManager)
        Dim durum
        Dim sayi = GridView1.RowCount  'kl.Count
        Dim satir = GridView1.FocusedRowHandle 'kl.Position
        Dim TOPLAM = sayi - GridView1.FocusedRowHandle 'kl.Position
        Dim Ý As Integer
        Ý = 0
        Dim dr_hareket As DataRow
        Dim dr As DataRow
        dr_hareket = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        durum = dr_hareket("" & columnkriter & "")
        'kl.Position += 1
        For Ý = 1 To TOPLAM
            dr_hareket = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr_hareket.BeginEdit()
            dr_hareket("" & columnkriter & "") = durum
            dr_hareket.EndEdit()
            'hesapla()
            'maliyetkontrol()
            'GridView1.FocusedRowHandle += 1
            If columnkriter = "ORAN1" Or columnkriter = "ORAN2" Or columnkriter = "ORAN3" Or columnkriter = "ORAN4" Or columnkriter = "ORAN5" Or columnkriter = "ORAN6" Or columnkriter = "ORAN7" Or columnkriter = "ORAN8" Or columnkriter = "ORAN9" Or columnkriter = "ORAN10" Then
                GridView1.PostEditor()
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dr.EndEdit()
                fiyat_kontrol()
            ElseIf columnkriter = "PESIN" Or columnkriter = "ALTIAY" Or columnkriter = "ONAY" Or columnkriter = "lFiyat4" Or columnkriter = "lFiyat5" Or columnkriter = "lFiyat6" Or columnkriter = "lFiyat7" Or columnkriter = "lFiyat8" Or columnkriter = "lFiyat9" Or columnkriter = "lFiyat10" Then
                GridView1.PostEditor()
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dr.EndEdit()
                oran_kontrol()
            End If
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
            'frm.sRenk = dr("sRenk")
            'frm.sBeden = dr("sBeden")
            frm.txt_musteriNo.Text = dr("sModel")
            frm.kullanici = kullanici
            Dim satir As Integer = GridView1.FocusedRowHandle
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            dataload()
            GridView1.FocusedRowHandle = satir
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
            frm.Label1.Text = dr("sAciklama") & vbCrLf & frm.Label1.Text
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
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_envanter()
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
    Private Sub frm_stok_cari_alis_karlilik_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'PanelControl1 = Nothing
        'PanelControl2 = Nothing
        'PanelControl3 = Nothing
        'Label2 = Nothing
        'SimpleButton2 = Nothing
        'SimpleButton1 = Nothing
        'Label1 = Nothing
        'PictureBox1 = Nothing
        'GridControl1 = Nothing
        'GridView1 = Nothing
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
        'ps = Nothing
        'printlink1 = Nothing
        'MenuItem16 = Nothing
        'DataTable2 = Nothing
        'DataColumn27 = Nothing
        'DataColumn28 = Nothing
        'DataColumn29 = Nothing
        'DataColumn30 = Nothing
        'DataColumn31 = Nothing
        'DataColumn32 = Nothing
        'DataColumn33 = Nothing
        'DataColumn34 = Nothing
        'DataColumn35 = Nothing
        'DataColumn36 = Nothing
        'DataColumn37 = Nothing
        'DataColumn38 = Nothing
        'DataColumn39 = Nothing
        'DataColumn40 = Nothing
        'DataColumn41 = Nothing
        'DataColumn42 = Nothing
        'DataColumn43 = Nothing
        'DataColumn44 = Nothing
        'DataColumn45 = Nothing
        'DataColumn46 = Nothing
        'DataColumn47 = Nothing
        'DataColumn48 = Nothing
        'DataColumn49 = Nothing
        'DataColumn50 = Nothing
        'DataColumn51 = Nothing
        'DataColumn52 = Nothing
        'DataColumn53 = Nothing
        'DataColumn54 = Nothing
        'DataColumn55 = Nothing
        'DataColumn56 = Nothing
        'DataColumn75 = Nothing
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
        'colnStokFisiID = Nothing
        'colsKodu = Nothing
        'colsAciklama = Nothing
        'collGirisMiktar1 = Nothing
        'collGirisMiktar2 = Nothing
        'collGirisFiyat = Nothing
        'collGirisTutar = Nothing
        'colnIskontoYuzdesi = Nothing
        'collIskontoTutari = Nothing
        'colsDovizCinsi = Nothing
        'collDovizFiyat = Nothing
        'colnSiparisID = Nothing
        'colISKONTOLAR = Nothing
        'coldteIrsaliyeTarihi = Nothing
        'collIrsaliyeNo = Nothing
        'colsDepo = Nothing
        'colnStokID = Nothing
        'colnFirmaID = Nothing
        'colnIrsaliyeFisiID = Nothing
        'colsStokIslem = Nothing
        'colnOTVOrani = Nothing
        'colnKdvOrani = Nothing
        'colnIslemID = Nothing
        'colGERCEKFIYAT = Nothing
        'colGERCEKTOPLAM = Nothing
        'colISK1 = Nothing
        'colISK2 = Nothing
        'colISK3 = Nothing
        'colISK4 = Nothing
        'colEKMASRAF = Nothing
        'collBrutFiyat = Nothing
        'collBrutTutar = Nothing
        'colONCEKIMALIYET = Nothing
        'colPESIN = Nothing
        'colALTIAY = Nothing
        'colONAY = Nothing
        'colORAN1 = Nothing
        'colORAN2 = Nothing
        'colORAN3 = Nothing
        'colKAR1 = Nothing
        'colKAR2 = Nothing
        'colKAR3 = Nothing
        'dataset1 = Nothing
        'colMALIYET = Nothing
        'firmano = Nothing
        'donemno = Nothing
        'connection = Nothing
        'musterino = Nothing
        'fistipi = Nothing
        'tarih = Nothing
        'firmaID = Nothing
        'fisno = Nothing
        'ngiriscikis = Nothing
        'ds_alislar = Nothing
        'Me.Close()
        'Me.Dispose()
        System.GC.Collect()
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        analiz_stok_karti()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        stok_fiyat()
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
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        raporla_excel()
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
    Private Sub raporla_rtf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Metin Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
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
    Private Sub MenuItem24_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        raporla_text()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        analiz_stok_karti()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        stok_satis_detay()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        raporla_rtf()
    End Sub
    Private Sub sec_oran_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_oran.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            fiyat_kontrol()
        ElseIf e.KeyCode = Keys.Right Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            fiyat_kontrol()
        ElseIf e.KeyCode = Keys.Up Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            fiyat_kontrol()
        ElseIf e.KeyCode = Keys.Down Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            fiyat_kontrol()
        ElseIf e.KeyCode = Keys.Left Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            fiyat_kontrol()
        End If
    End Sub
    Private Sub sec_fiyat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_fiyat.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            oran_kontrol()
        ElseIf e.KeyCode = Keys.Right Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            oran_kontrol()
        ElseIf e.KeyCode = Keys.Up Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            oran_kontrol()
        ElseIf e.KeyCode = Keys.Down Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            oran_kontrol()
        ElseIf e.KeyCode = Keys.Left Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            oran_kontrol()
        End If
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView1.FocusedColumn().Caption & "] Kolonundaki verileri Aþaðý Doðru Yaymak istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                degeryay(GridView1.FocusedColumn().FieldName)
            End If
        End If
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        calculator()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Ürünlerin Satýþ Fiyatlarýný Güncellemek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            guncelle_satis()
        End If
    End Sub
    Private Sub dataload_stok(ByVal stokno As Int64)
        Dim kriter
        kriter = "WHERE (nStokID = " & stokno & ")  "
        ds_stok = sorgu(sorgu_query("SELECT     * FROM  tbStok " & kriter & ""))
    End Sub
    Private Sub guncelle_satis()
        Panelstatus.Visible = True
        bar.Properties.Maximum = GridView1.RowCount
        barlabel.Text = "Toplam Satýr Sayýsý : " & GridView1.RowCount
        bar.Position = 0
        Dim dr As DataRow
        Dim dr1 As DataRow
        duzelt_sifir_fiyat()
        For Each dr In dataset1.Tables(0).Rows
            dataload_stok(dr("STOKNO"))
            For Each dr1 In ds_stok.Tables(0).Rows
                Dim fiyat As Decimal = 0
                '///////////////////////////////////10 AYLIK FÝYAT
                Try
                    fiyat = sorgu_stok_fiyat(sFiyat3, dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                dr("ONAY") = sorgu_sayi(dr("ONAY"), 0)
                dr("ALTIAY") = sorgu_sayi(dr("ALTIAY"), 0)
                dr("PESIN") = sorgu_sayi(dr("PESIN"), 0)
                If fiyat = 0 And dr("ONAY") <> 0 Then
                    Try
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat3, dr("ONAY"), dteSistemTarihi)
                        tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat3, dr("ONAY"), dteSistemTarihi, kullaniciadi)
                    Catch ex As Exception
                    End Try
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("ONAY"), sFiyat3)
                ElseIf fiyat <> dr("ONAY") Then
                    tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat3, dr("ONAY"), dteSistemTarihi)
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("ONAY"), sFiyat3)
                ElseIf dr("ONAY") = 0 Then
                    'Sýfýr fiyat kontrolü
                    If bFiyatSifirGirilsin = False Then
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat3, dr("ONAY"), dteSistemTarihi)
                    Else
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat3, dr("ONAY"), dteSistemTarihi)
                    End If
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat3)
                End If
                '/////////////////////////////////////6 AYLIK FÝYAT
                Try
                    fiyat = sorgu_stok_fiyat(sFiyat2, dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 And dr("ALTIAY") <> 0 Then
                    Try
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat2, dr("ALTIAY"), dteSistemTarihi)
                        tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat2, dr("ALTIAY"), dteSistemTarihi, kullaniciadi)
                    Catch ex As Exception
                    End Try
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("ALTIAY"), sFiyat2)
                ElseIf fiyat <> dr("ALTIAY") Then
                    tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat2, dr("ALTIAY"), dteSistemTarihi)
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("ALTIAY"), sFiyat2)
                ElseIf dr("ALTIAY") = 0 Then
                    'Sýfýr fiyat kontrolü
                    If bFiyatSifirGirilsin = False Then
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat2, dr("ALTIAY"), dteSistemTarihi)
                    Else
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat2, dr("ALTIAY"), dteSistemTarihi)
                    End If
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat2)
                End If
                ''/////////////////////////////////////////////PEÞÝN
                Try
                    fiyat = sorgu_stok_fiyat(sFiyat1, dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 And dr("PESIN") <> 0 Then
                    Try
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat1, dr("PESIN"), dteSistemTarihi)
                        tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat1, dr("PESIN"), dteSistemTarihi, kullaniciadi)
                    Catch ex As Exception
                    End Try
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat1)
                ElseIf fiyat <> dr("PESIN") Then
                    tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat1, dr("PESIN"), dteSistemTarihi)
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat1)
                ElseIf dr("PESIN") = 0 Then
                    If bFiyatSifirGirilsin = False Then
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat1, dr("PESIN"), dteSistemTarihi)
                    Else
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat1, dr("PESIN"), dteSistemTarihi)
                    End If
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat1)
                End If
                '/////////////////////////////////////Fiyat4
                dr("lFiyat4") = sorgu_sayi(dr("lFiyat4"), 0)
                Try
                    fiyat = sorgu_stok_fiyat(sFiyat4, dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 And dr("lFiyat4") <> 0 Then
                    Try
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat4, dr("lFiyat4"), dteSistemTarihi)
                        tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat4, dr("lFiyat4"), dteSistemTarihi, kullaniciadi)
                    Catch ex As Exception
                    End Try
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("lFiyat4"), sFiyat4)
                ElseIf fiyat <> dr("lFiyat4") Then
                    tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat4, dr("lFiyat4"), dteSistemTarihi)
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("lFiyat4"), sFiyat4)
                ElseIf dr("lFiyat4") = 0 Then
                    'Sýfýr fiyat kontrolü
                    If bFiyatSifirGirilsin = False Then
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat4, dr("lFiyat4"), dteSistemTarihi)
                    Else
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat4, dr("lFiyat4"), dteSistemTarihi)
                    End If
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat4)
                End If
                fiyat = Nothing
                '/////////////////////////////////////Fiyat5
                dr("lFiyat5") = sorgu_sayi(dr("lFiyat5"), 0)
                Try
                    fiyat = sorgu_stok_fiyat(sFiyat5, dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 And dr("lFiyat5") <> 0 Then
                    Try
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat5, dr("lFiyat5"), dteSistemTarihi)
                        tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat5, dr("lFiyat5"), dteSistemTarihi, kullaniciadi)
                    Catch ex As Exception
                    End Try
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("lFiyat5"), sFiyat5)
                ElseIf fiyat <> dr("lFiyat5") Then
                    tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat5, dr("lFiyat5"), dteSistemTarihi)
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("lFiyat5"), sFiyat5)
                ElseIf dr("lFiyat5") = 0 Then
                    'Sýfýr fiyat kontrolü
                    If bFiyatSifirGirilsin = False Then
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat5, dr("lFiyat5"), dteSistemTarihi)
                    Else
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat5, dr("lFiyat5"), dteSistemTarihi)
                    End If
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat5)
                End If
                fiyat = Nothing
                '/////////////////////////////////////Fiyat6
                dr("lFiyat6") = sorgu_sayi(dr("lFiyat6"), 0)
                Try
                    fiyat = sorgu_stok_fiyat(sFiyat6, dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 And dr("lFiyat6") <> 0 Then
                    Try
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat6, dr("lFiyat6"), dteSistemTarihi)
                        tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat6, dr("lFiyat6"), dteSistemTarihi, kullaniciadi)
                    Catch ex As Exception
                    End Try
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("lFiyat6"), sFiyat6)
                ElseIf fiyat <> dr("lFiyat6") Then
                    tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat6, dr("lFiyat6"), dteSistemTarihi)
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("lFiyat6"), sFiyat6)
                ElseIf dr("lFiyat6") = 0 Then
                    'Sýfýr fiyat kontrolü
                    If bFiyatSifirGirilsin = False Then
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat6, dr("lFiyat6"), dteSistemTarihi)
                    Else
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat6, dr("lFiyat6"), dteSistemTarihi)
                    End If
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat6)
                End If
                fiyat = Nothing
                '/////////////////////////////////////Fiyat7
                dr("lFiyat7") = sorgu_sayi(dr("lFiyat7"), 0)
                Try
                    fiyat = sorgu_stok_fiyat(sFiyat7, dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 And dr("lFiyat7") <> 0 Then
                    Try
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat7, dr("lFiyat7"), dteSistemTarihi)
                        tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat7, dr("lFiyat7"), dteSistemTarihi, kullaniciadi)
                    Catch ex As Exception
                    End Try
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("lFiyat7"), sFiyat7)
                ElseIf fiyat <> dr("lFiyat7") Then
                    tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat7, dr("lFiyat7"), dteSistemTarihi)
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("lFiyat7"), sFiyat7)
                ElseIf dr("lFiyat7") = 0 Then
                    'Sýfýr fiyat kontrolü
                    If bFiyatSifirGirilsin = False Then
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat7, dr("lFiyat7"), dteSistemTarihi)
                    Else
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat7, dr("lFiyat7"), dteSistemTarihi)
                    End If
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat7)
                End If
                fiyat = Nothing
                '/////////////////////////////////////Fiyat8
                dr("lFiyat8") = sorgu_sayi(dr("lFiyat8"), 0)
                Try
                    fiyat = sorgu_stok_fiyat(sFiyat8, dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 And dr("lFiyat8") <> 0 Then
                    Try
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat8, dr("lFiyat8"), dteSistemTarihi)
                        tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat8, dr("lFiyat8"), dteSistemTarihi, kullaniciadi)
                    Catch ex As Exception
                    End Try
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("lFiyat8"), sFiyat8)
                ElseIf fiyat <> dr("lFiyat8") Then
                    tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat8, dr("lFiyat8"), dteSistemTarihi)
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("lFiyat8"), sFiyat8)
                ElseIf dr("lFiyat8") = 0 Then
                    'Sýfýr fiyat kontrolü
                    If bFiyatSifirGirilsin = False Then
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat8, dr("lFiyat8"), dteSistemTarihi)
                    Else
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat8, dr("lFiyat8"), dteSistemTarihi)
                    End If
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat8)
                End If
                fiyat = Nothing
                '/////////////////////////////////////Fiyat9
                dr("lFiyat9") = sorgu_sayi(dr("lFiyat9"), 0)
                Try
                    fiyat = sorgu_stok_fiyat(sFiyat9, dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 And dr("lFiyat9") <> 0 Then
                    Try
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat9, dr("lFiyat9"), dteSistemTarihi)
                        tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat9, dr("lFiyat9"), dteSistemTarihi, kullaniciadi)
                    Catch ex As Exception
                    End Try
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("lFiyat9"), sFiyat9)
                ElseIf fiyat <> dr("lFiyat9") Then
                    tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat9, dr("lFiyat9"), dteSistemTarihi)
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("lFiyat9"), sFiyat9)
                ElseIf dr("lFiyat9") = 0 Then
                    'Sýfýr fiyat kontrolü
                    If bFiyatSifirGirilsin = False Then
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat9, dr("lFiyat9"), dteSistemTarihi)
                    Else
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat9, dr("lFiyat9"), dteSistemTarihi)
                    End If
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat9)
                End If
                fiyat = Nothing
                '/////////////////////////////////////Fiyat10
                dr("lFiyat10") = sorgu_sayi(dr("lFiyat10"), 0)
                Try
                    fiyat = sorgu_stok_fiyat(sFiyat10, dr("STOKNO"))
                Catch ex As Exception
                    fiyat = 0
                End Try
                If fiyat = 0 And dr("lFiyat10") <> 0 Then
                    Try
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat10, dr("lFiyat10"), dteSistemTarihi)
                        tbStokFiyati_ekle_yeni(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat10, dr("lFiyat10"), dteSistemTarihi, kullaniciadi)
                    Catch ex As Exception
                    End Try
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("lFiyat10"), sFiyat10)
                ElseIf fiyat <> dr("lFiyat10") Then
                    tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat10, dr("lFiyat10"), dteSistemTarihi)
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("lFiyat10"), sFiyat10)
                ElseIf dr("lFiyat10") = 0 Then
                    'Sýfýr fiyat kontrolü
                    If bFiyatSifirGirilsin = False Then
                        tbStokFiyati_ekle_sil(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat10, dr("lFiyat10"), dteSistemTarihi)
                    Else
                        tbStokFiyati_ekle_duzelt(dr1("nFiyatlandirma"), dr1("sModel"), dr1("sRenk"), dr1("sBeden"), sFiyat10, dr("lFiyat10"), dteSistemTarihi)
                    End If
                    takip_ekle_stok_fiyatdegisim(dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), dr("PESIN"), sFiyat10)
                End If
                fiyat = Nothing
            Next
            bar.Position = bar.Position + 1
            bar.Refresh()
        Next
        bar.Position = 0
        Panelstatus.Visible = False
        dr = Nothing
        XtraMessageBox.Show(Sorgu_sDil("Stok Fiyatlarý Baþarýyla Deðiþtirilmiþtir...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        dataload()
    End Sub
    Private Sub tbStokFiyati_ekle_yeni(ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String, ByVal lFiyat As Decimal, ByVal dteFiyatTespitTarihi As DateTime, ByVal sKullaniciAdi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        cmd.CommandTimeout = Nothing
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
        If lFiyat = 0 And bFiyatSifirGirilsin = False Then
            If nFiyatlandirma = 0 Then
                cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED delete tbStokFiyati from tbStok where tbStok.nStokID = tbStokFiyati.nStokID       and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "'"
            ElseIf nFiyatlandirma = 1 Then
                cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED delete tbStokFiyati from tbStok where tbStok.nStokID = tbStokFiyati.nStokID       and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "'"
            ElseIf nFiyatlandirma = 2 Then
                cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED delete tbStokFiyati from tbStok where tbStok.nStokID = tbStokFiyati.nStokID       and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "' and sBeden ='" & sBeden & "'"
            End If
        Else
            If nFiyatlandirma = 0 Then
                cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED update tbStokFiyati set lFiyat = " & lFiyat & " , dteFiyatTespitTarihi = '" & dteFiyatTespitTarihi & "' , dteKayitTarihi = getdate() from tbStok where tbStok.nStokID = tbStokFiyati.nStokID and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "'"
            ElseIf nFiyatlandirma = 1 Then
                cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED update tbStokFiyati set lFiyat = " & lFiyat & " , dteFiyatTespitTarihi = '" & dteFiyatTespitTarihi & "' , dteKayitTarihi = getdate() from tbStok where tbStok.nStokID = tbStokFiyati.nStokID and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "'"
            ElseIf nFiyatlandirma = 2 Then
                cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED update tbStokFiyati set lFiyat = " & lFiyat & " , dteFiyatTespitTarihi = '" & dteFiyatTespitTarihi & "' , dteKayitTarihi = getdate() from tbStok where tbStok.nStokID = tbStokFiyati.nStokID and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "' and sBeden = '" & sBeden & "' "
            End If
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
    Private Sub duzelt_fiyat(ByVal stokno As Int64, ByVal fiyattipi As String, ByVal fiyat As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    tbStokFiyati SET              lFiyat =" & fiyat & " , dteFiyatTespittarihi = '" & Today & "' where nStokID =" & stokno & " AND sFiyatTipi ='" & fiyattipi & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd.Dispose()
        con.Dispose()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub duzelt_sifir_fiyat()
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY DELETE FROM    tbStokFiyati Where lFiyat = 0")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd.Dispose()
        con.Dispose()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub duzelt_fiyat_renk(ByVal stokno As Int64, ByVal fiyattipi As String, ByVal fiyat As Decimal, ByVal modelno As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    tbStokFiyati SET              lFiyat =" & fiyat & ", dteFiyatTespittarihi = '" & Today & "' where nStokID IN (Select nStokID from tbStok where sModel ='" & modelno & "') AND sFiyatTipi ='" & fiyattipi & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd.Dispose()
        con.Dispose()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub ekle_fiyat(ByVal stokno As Int64, ByVal fiyattipi As String, ByVal fiyat As Decimal, ByVal sKullaniciAdi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFiyati SET              lFiyat =" & fiyat & " where nStokID =" & stokno & " AND sFiyatTipi ='" & fiyattipi & "'")
        If fiyat = 0 Then
            cmd.CommandText = sorgu_query("DELETE FROM tbStokFiyati    Where sFiyatTipi ='" & fiyattipi & "' and nStokID = " & stokno & " ")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFiyati                       (nStokID, sFiyatTipi, lFiyat, dteFiyatTespitTarihi, sKullaniciAdi, dteKayitTarihi) VALUES     (" & stokno & ", '" & fiyattipi & "', " & fiyat & " ,'" & Today & "', '" & sKullaniciAdi & "', GETDATE())")
        End If
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFiyati                       (nStokID, sFiyatTipi, lFiyat, dteFiyatTespitTarihi, sKullaniciAdi, dteKayitTarihi) VALUES     (" & stokno & ", '" & fiyattipi & "', " & fiyat & " ,'" & Today & "', 'MUHASEBE', GETDATE())")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd.Dispose()
        con.Dispose()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function sorgu_stok_fiyat(ByVal sFiyatTipi As String, ByVal nStokID As Int64) As Decimal
        Dim kriter
        kriter = "WHERE     (nStokID = " & nStokID & ") and (sFiyatTipi= '" & sFiyatTipi & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lFiyat,0) AS FIYAT FROM         tbStokFiyati " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        conn.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub raporla_etiket(ByVal islem As Integer, Optional ByVal carpan As Int64 = 1)
        Dim file As String
        Dim fiyat1 As Decimal = 0
        Dim fiyat2 As Decimal = 0
        Dim fiyat3 As Decimal = 0
        Dim miktar As Decimal = 0
        OpenFileDialog1.Filter = "EtiketDosyalarý(*.fr*) |*.fr*"
        OpenFileDialog1.FileName = "c:\Formlar\Etiket\Etiket" & sRaporUzanti & ""
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If islem = 3 Then
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
                        file = OpenFileDialog1.FileName.ToString
                        fiyat1 = 0 'dr("FIYAT1")
                        fiyat2 = 0 'dr("FIYAT2")
                        fiyat3 = 0 'dr("FIYAT3")
                        If nGirisCikis = 1 Or nGirisCikis = 2 Then
                            miktar = Math.Abs(dr1("lGirisMiktar1")) * carpan
                        ElseIf nGirisCikis = 3 Or nGirisCikis = 4 Then
                            miktar = Math.Abs(dr1("lCikisMiktar1")) * carpan
                        End If
                        If Microsoft.VisualBasic.Right(file, 3) = "fr3" Then
                            report_create_etiket(file, satir_kontrol_etiket, islem, miktar, fiyat1, fiyat2, fiyat3)
                        ElseIf Microsoft.VisualBasic.Right(file, 3) = "frx" Then
                            report_create_etiketX(file, satir_kontrol_etiket, islem, miktar, fiyat1, fiyat2, fiyat3)
                        End If
                    Next
                End If
            Else
                file = OpenFileDialog1.FileName.ToString
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                fiyat1 = 0 'dr("FIYAT1")
                fiyat2 = 0 'dr("FIYAT2")
                fiyat3 = 0 'dr("FIYAT3")
                If nGirisCikis = 1 Or nGirisCikis = 2 Then
                    miktar = Math.Abs(dr("lGirisMiktar1")) * carpan
                ElseIf nGirisCikis = 3 Or nGirisCikis = 4 Then
                    miktar = Math.Abs(dr("lCikisMiktar1")) * carpan
                End If
                'report_create_etiketX(file, satir_kontrol_etiket, islem, miktar, fiyat1, fiyat2, fiyat3)
                If Microsoft.VisualBasic.Right(file, 3) = "fr3" Then
                    report_create_etiket(file, satir_kontrol_etiket, islem, miktar, fiyat1, fiyat2, fiyat3)
                ElseIf Microsoft.VisualBasic.Right(file, 3) = "frx" Then
                    report_create_etiketX(file, satir_kontrol_etiket, islem, miktar, fiyat1, fiyat2, fiyat3)
                End If
            End If
        End If
        fiyat1 = Nothing
        fiyat2 = Nothing
        fiyat3 = Nothing
        miktar = Nothing
        file = Nothing
    End Sub
    Private Function satir_kontrol_etiket()
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
                satir += dr1("nStokID").ToString
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
    Private Sub report_create_etiketX(ByVal sFile As String, ByVal kriter As String, ByVal nIslem As Integer, ByVal bMiktarli As Decimal, ByVal fiyat1 As Decimal, ByVal fiyat2 As Decimal, ByVal fiyat3 As Decimal)
        Dim report As New FastReport.Report
        report.Load(sFile)
        Dim ds_etiket As DataSet
        ds_etiket = sorgu(sorgu_query("set transaction isolation level read uncommitted SELECT PESIN = CASE WHEN FIYAT <> 0 THEN FIYAT ELSE FIYAT1 END, * FROM (SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS FIYAT1, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sAktifFiyatTipi & "') AS FIYAT,barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ) tbStok"), "Etiket")
        report.RegisterData(ds_etiket)
        report.RegisterData(ds_tbParamGenel)
        report.ScriptLanguage = Language.Vb
        If nIslem = 0 Then
            report.Show()
        ElseIf nIslem = 2 Then
            report.Design()
        ElseIf nIslem = 1 Then
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
    Private Sub report_create_etiket(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer, ByVal miktar As Decimal, ByVal fiyat1 As Decimal, ByVal fiyat2 As Decimal, ByVal fiyat3 As Decimal)
        Dim stokno = 0
        Dim satir_line = "100"
        Dim frx As New TfrxReportClass
        Dim qr_hareket As New TfrxADOQuery
        Dim qr_hareket_model As New TfrxADOQuery
        Dim qr_baslik As New TfrxADOQuery
        Dim qr_toplam As New TfrxADOQuery
        frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
        frx.LoadReportFromFile(dosya)
        frx.SetVariable("FIRMANO", "" & firmano & "")
        frx.SetVariable("DONEMNO", "" & donemno & "")
        frx.SetVariable("STOKNO", "" & stokno & "")
        frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
        frx.SetVariable("FIYAT1", "" & fiyat1 & "")
        frx.SetVariable("FIYAT2", "" & fiyat2 & "")
        frx.SetVariable("FIYAT3", "" & fiyat3 & "")
        frx.SetVariable("FIYAT", "'" & fiyat_gizle_tumu(FormatNumber(fiyat1, 2), FormatNumber(fiyat2, 2), FormatNumber(fiyat3, 2)) & "'")
        qr_hareket = frx.FindObject("qr_hareket")
        'qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, barkod.sBarkod, stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI,stok.sKisaAdi, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " GROUP BY stok.nStokID, barkod.sBarkod, stok.sKodu, stok.sKisaAdi,stok.sAciklama, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi")
        qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT PESIN = CASE WHEN FIYAT <> 0 THEN FIYAT ELSE FIYAT1 END, * FROM (SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS FIYAT1, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sAktifFiyatTipi & "') AS FIYAT,barkod.sBarkod, stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI,stok.sKisaAdi, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ) tbStok")
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
            'frx.PrepareReport(True)
            frx.DesignReport()
        ElseIf status = 3 Then
            frx.PrepareReport(True)
            frx.PrintOptions.Collate = False
            frx.PrintOptions.Copies = miktar
            frx.PrintOptions.ShowDialog = False
            frx.PrintReport()
        End If
        stokno = Nothing
        satir_line = Nothing
        qr_hareket = Nothing
        qr_connection = Nothing
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
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        raporla_etiket(0)
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        analiz_stok_KarlilikAkisTablosu()
    End Sub
    Private Sub RadioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sFiltre.SelectedIndexChanged
        If sec_sFiltre.SelectedIndex = 0 Then
            GridView1.ClearColumnsFilter()
        ElseIf sec_sFiltre.SelectedIndex = 1 Then
            GridView1.ClearColumnsFilter()
            GridView1.Columns("nFarkOran").FilterInfo = New ColumnFilterInfo("[nFarkOran] <> 0")
        ElseIf sec_sFiltre.SelectedIndex = 2 Then
            GridView1.ClearColumnsFilter()
            GridView1.Columns("bYeni").FilterInfo = New ColumnFilterInfo("[bYeni] = '1'")
        ElseIf sec_sFiltre.SelectedIndex = 3 Then
            GridView1.ClearColumnsFilter()
            GridView1.Columns("bFiyatDegisti").FilterInfo = New ColumnFilterInfo("[bFiyatDegisti] = '1'")
        ElseIf sec_sFiltre.SelectedIndex = 4 Then
            GridView1.ClearColumnsFilter()
            GridView1.Columns("ISK1").FilterInfo = New ColumnFilterInfo("[ISK1] > 90")
        ElseIf sec_sFiltre.SelectedIndex = 5 Then
            GridView1.ClearColumnsFilter()
            GridView1.Columns("ORAN1").FilterInfo = New ColumnFilterInfo("[ORAN1] < 0")
        ElseIf sec_sFiltre.SelectedIndex = 6 Then
            GridView1.ClearColumnsFilter()
            GridView1.Columns("ORAN2").FilterInfo = New ColumnFilterInfo("[ORAN2] < 0")
        ElseIf sec_sFiltre.SelectedIndex = 7 Then
            GridView1.ClearColumnsFilter()
            GridView1.Columns("ORAN3").FilterInfo = New ColumnFilterInfo("[ORAN3] < 0")
        ElseIf sec_sFiltre.SelectedIndex = 8 Then
            GridView1.ClearColumnsFilter()
            GridView1.Columns("KAR").FilterInfo = New ColumnFilterInfo("[KAR] < 0.00")
        End If
    End Sub
    Private Sub sec_bKdvHaric_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bKdvHaric.CheckStateChanged
        'Try
        bKdvKontrolluMaliyet = sec_bKdvHaric.Checked
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("FIS").SetValue("bKdvKontrolluMaliyet", bKdvKontrolluMaliyet.ToString())
        dataload()
        'Catch ex As Exception
        'End Try
    End Sub
    Private Function fiyat_degisim_baslik_kaydet_yeni(ByVal TARIH As DateTime, ByVal BELGENO As String, ByVal ACIKLAMA As String, ByVal KOD1 As String, ByVal KOD2 As String, ByVal KOD3 As String, ByVal KOD4 As String, ByVal KOD5 As String, ByVal SONUC As String, ByVal bKilitli As Byte, ByVal HATIRLAT As DateTime) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO ASTOKFIYATDEGISIMBASLIK                       (TARIH, BELGENO, ACIKLAMA, KOD1, KOD2, KOD3, KOD4, KOD5, SONUC,bKilitli,HATIRLAT) VALUES     ('" & TARIH & "', '" & BELGENO & "', '" & ACIKLAMA & "', '" & KOD1 & "', '" & KOD2 & "', '" & KOD3 & "', '" & KOD4 & "', '" & KOD5 & "', '" & SONUC & "'," & bKilitli & ",'" & HATIRLAT & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
        cmd.Dispose()
        con.Dispose()
        cmd = Nothing
        con = Nothing
    End Function
    Private Function fiyat_degisim_hareket_kaydet_yeni(ByVal EVRAKNO As Int64, ByVal TARIH As DateTime, ByVal FISTARIHI As DateTime, ByVal FISNO As String, ByVal FIRMAKODU As String, ByVal FIRMAADI As String, ByVal STOKNO As Int64, ByVal STOKKODU As String, ByVal STOKADI As String, ByVal MIKTAR As Decimal, ByVal BIRIMMALIYET As Decimal, ByVal BIRIMFIYAT As Decimal, ByVal ISKONTO As Decimal, ByVal KDV As Decimal, ByVal KDVLITUTAR As Decimal, ByVal FATURAMIKTARI As Decimal, ByVal FATURATUTARI As Decimal, ByVal EKMALIYET As Decimal, ByVal RENK As String, ByVal PESIN As Decimal, ByVal ONAY As Decimal, ByVal ALTIAY As Decimal, ByVal ORANEKMALIYET As Decimal, ByVal ORAN1 As Decimal, ByVal ORAN2 As Decimal, ByVal ORAN3 As Decimal, ByVal SONALISMALIYETI As Decimal, ByVal ONCEKIALISMALIYETI As Decimal, ByVal ONCEKIALISTARIHI As DateTime, ByVal SONALISTARIHI As DateTime, ByVal NETMALIYET As Decimal, ByVal STATUS As Integer, ByVal SONUC As String, ByVal FIYAT1 As Decimal, ByVal FIYAT2 As Decimal, ByVal FIYAT3 As Decimal, ByVal MALIYET As Decimal, ByVal ONBESAY As Decimal, ByVal ORAN4 As Decimal, ByVal FIYAT4 As Decimal, ByVal FIYAT5 As Decimal, ByVal EFIYAT5 As Decimal, ByVal FIYAT6 As Decimal, ByVal EFIYAT6 As Decimal, ByVal FIYAT7 As Decimal, ByVal EFIYAT7 As Decimal, ByVal FIYAT8 As Decimal, ByVal EFIYAT8 As Decimal, ByVal FIYAT9 As Decimal, ByVal EFIYAT9 As Decimal, ByVal FIYAT10 As Decimal, ByVal EFIYAT10 As Decimal, ByVal ORAN5 As Decimal, ByVal ORAN6 As Decimal, ByVal ORAN7 As Decimal, ByVal ORAN8 As Decimal, ByVal ORAN9 As Decimal, ByVal ORAN10 As Decimal) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO ASTOKFIYATDEGISIMDETAY                       (EVRAKNO, TARIH, FISTARIHI, FISNO, FIRMAKODU, FIRMAADI, STOKNO, STOKKODU, STOKADI, MIKTAR, BIRIMMALIYET, BIRIMFIYAT, ISKONTO, KDV,  KDVLITUTAR, FATURAMIKTARI, FATURATUTARI, EKMALIYET, RENK, PESIN, ONAY, ALTIAY, ORANEKMALIYET, ORAN1, ORAN2, ORAN3, SONALISMALIYETI, ONCEKIALISMALIYETI, ONCEKIALISTARIHI, SONALISTARIHI, NETMALIYET, STATUS, SONUC,FIYAT1,FIYAT2,FIYAT3,MALIYET,ONBESAY,ORAN4,FIYAT4,FIYAT5,EFIYAT5,FIYAT6,EFIYAT6,FIYAT7,EFIYAT7,FIYAT8,EFIYAT8,FIYAT9,EFIYAT9,FIYAT10,EFIYAT10,ORAN5,ORAN6,ORAN7,ORAN8,ORAN9,ORAN10) VALUES     (" & EVRAKNO & ", '" & TARIH & "', '" & FISTARIHI & "', '" & FISNO & "', '" & FIRMAKODU & "', '" & FIRMAADI & "', " & STOKNO & ", '" & STOKKODU & "', '" & STOKADI & "', " & MIKTAR & " , " & BIRIMMALIYET & " , " & BIRIMFIYAT & " , " & ISKONTO & ", " & KDV & ", " & KDVLITUTAR & ", " & FATURAMIKTARI & " , " & FATURATUTARI & " , " & EKMALIYET & " , '" & RENK & "', " & PESIN & " , " & ONAY & " , " & ALTIAY & " , " & ORANEKMALIYET & " , " & ORAN1 & " , " & ORAN2 & " , " & ORAN3 & " , " & SONALISMALIYETI & " , " & ONCEKIALISMALIYETI & " , '" & ONCEKIALISTARIHI & "', '" & SONALISTARIHI & "' , " & NETMALIYET & ", " & STATUS & ", '" & SONUC & "'," & FIYAT1 & "," & FIYAT2 & "," & FIYAT3 & "," & MALIYET & "," & ONBESAY & "," & ORAN4 & "," & FIYAT4 & "," & FIYAT5 & "," & EFIYAT5 & "," & FIYAT6 & "," & EFIYAT6 & "," & FIYAT7 & "," & EFIYAT7 & "," & FIYAT8 & "," & EFIYAT8 & "," & FIYAT9 & "," & EFIYAT9 & "," & FIYAT10 & "," & EFIYAT10 & "," & ORAN5 & "," & ORAN6 & "," & ORAN7 & "," & ORAN8 & "," & ORAN9 & "," & ORAN10 & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
        cmd.Dispose()
        con.Dispose()
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        fiyat_degisim_olustur()
    End Sub
    Private Sub fiyat_degisim_olustur()
        If MessageBox.Show(Sorgu_sDil("Fiyat Deðiþim Föyüne Aktarmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim IND As Int64 = 0
            IND = fiyat_degisim_baslik_kaydet_yeni(dteSistemTarihi, fisno, sAciklama, sAciklama, "", "", "", "", "Bekliyor...", 0, "01/01/1900")
            Dim dr As DataRow
            Dim dr1 As DataRow
            For Each dr In dataset1.Tables(0).Rows
                ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStok.sKodu, tbStok.sAciklama, tbRenk.sRenkAdi ,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS lFiyat4,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat5 & "') AS lFiyat5,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat6 & "') AS lFiyat6,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat7 & "') AS lFiyat7,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat8 & "') AS lFiyat8,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat9 & "') AS lFiyat9,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat10 & "') AS lFiyat10 FROM         tbStok INNER JOIN                       tbRenk ON tbStok.sRenk = tbRenk.sRenk Where tbStok.sKodu = '" & dr("sKodu") & "'"))
                For Each dr1 In ds_stok.Tables(0).Rows
                    fiyat_degisim_hareket_kaydet_yeni(IND, tarih, dr("dteFisTarihi"), dr("lFisNo"), dr("sFirmaKodu"), dr("sFirmaAdi"), dr("STOKNO"), dr("sKodu"), dr("sAciklama"), dr("lCikisMiktar1"), dr("GERCEKFIYAT"), dr("GERCEKFIYAT"), dr("lIskontoTutari"), dr("nKdvOrani"), dr("GERCEKFIYAT"), dr("lCikisMiktar1"), dr("lNetTutar"), dr("lEkMaliyet1") + dr("lEkMaliyet3") + dr("lEkMaliyet4"), dr("sRenk"), dr("PESIN"), dr("ONAY"), dr("ALTIAY"), dr("EKMASRAF"), dr("ORAN1"), dr("ORAN2"), dr("ORAN3"), dr("ONCEKIMALIYET"), dr("ONCEKIMALIYET"), dr("ONCEKIALISTARIHI"), dr("ONCEKIALISTARIHI"), dr("GERCEKFIYAT"), 0, "", sorgu_sayi(dr1("PESIN"), 0), sorgu_sayi(dr1("ALTIAY"), 0), sorgu_sayi(dr1("ONAY"), 0), dr("MALIYET"), dr("lFiyat4"), dr("ORAN4"), sorgu_sayi(dr1("lFiyat4"), 0), dr("lFiyat5"), sorgu_sayi(dr1("lFiyat5"), 0), dr("lFiyat6"), sorgu_sayi(dr1("lFiyat6"), 0), dr("lFiyat7"), sorgu_sayi(dr1("lFiyat7"), 0), dr("lFiyat8"), sorgu_sayi(dr1("lFiyat8"), 0), dr("lFiyat9"), sorgu_sayi(dr1("lFiyat9"), 0), dr("lFiyat10"), sorgu_sayi(dr1("lFiyat10"), 0), dr("ORAN5"), dr("ORAN6"), dr("ORAN7"), dr("ORAN8"), dr("ORAN9"), dr("ORAN10"))
                Next
            Next
            Dim frm As New frm_stok_fiyat_degisim
            frm.connection = connection
            frm.firmano = firmano
            frm.donemno = donemno
            frm.belgeind = IND
            frm.status = True
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            'IND = Nothing
            'MsgBox(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...!", sDil), MsgBoxStyle.Information, Sorgu_sDil("Dikkat", sDil))
        End If
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        fiyat_degisim_olustur()
    End Sub
End Class
