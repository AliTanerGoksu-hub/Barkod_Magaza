Imports FastReport
Imports Microsoft.Win32
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Alerter
Imports System.IO
Public Class frm_stok
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents sec_pResim As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents colPESIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colALTIAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colONAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents colsKisaAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbFiyatDegisti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btn_Ara As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Ekle As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Duzelt As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Sil As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btn_Yazdir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_FiyatDuzenle As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Envanter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_StokHareketleri As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Transferler As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colnStokTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFIYAT4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBirimCinsi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnBirimCarpan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents sKavala As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbYeni As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBEKLEYEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlinanSiparis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVerilenSiparis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnHacim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnAgirlik As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMEVCUT2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBirimCinsi2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents coldteFiyatTespit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents dPanelSiniflandirma As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents dPanelAlternatif As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents ControlContainer1 As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents dPanelResim As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents ControlContainer2 As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents dPanelRecete As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents ControlContainer3 As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents dPanelEnvanter As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents ControlContainer4 As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents dPanelTanım As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents ControlContainer5 As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents lbl_sKodu As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sPicture As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lbl_sMevcut As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_sBirimCinsi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_sBarkod As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_sKisaAdi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_sAciklama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_sBekleyen As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Fiyat4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Fiyat3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Fiyat2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Fiyat1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_sNet As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGIREN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIKAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKALAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_sEnvanterAciklama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_sSiniflandirmaAciklama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnMusteriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_Siniflar As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbSatisYapilamaz As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sSinifKodu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_sAlternatifAciklama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn39 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn42 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn44 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn45 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn46 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn47 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn48 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn49 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn51 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn52 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn53 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn54 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn55 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn56 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn57 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn58 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn59 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn60 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn61 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn62 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn63 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn64 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn65 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn66 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn67 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn68 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn69 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn70 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents colSec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chk_Sec As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents colSINIF1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSINIF10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWebGoruntule As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWebTavsiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsOzelNot As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition6 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition7 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition8 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition9 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition10 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition11 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition12 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition13 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition14 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition15 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colMEVCUT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbFiyatDegisti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStokTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbYeni = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn45 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn51 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn57 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSec = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chk_Sec = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colnStokID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsMODEL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBarkod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPESIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colALTIAY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colONAY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKisaAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFIYAT4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBirimCinsi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnBirimCarpan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsOzelNot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sKavala = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBEKLEYEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlinanSiparis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVerilenSiparis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnHacim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnAgirlik = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMEVCUT2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBirimCinsi2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteFiyatTespit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDovizCinsi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSINIF10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_pResim = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.colWebGoruntule = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWebTavsiye = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_renk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem39 = New System.Windows.Forms.MenuItem()
        Me.MenuItem40 = New System.Windows.Forms.MenuItem()
        Me.MenuItem41 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem38 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.MenuItem36 = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.btn_Ara = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Ekle = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Duzelt = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Sil = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Yazdir = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_FiyatDuzenle = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Envanter = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_StokHareketleri = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Transferler = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.dPanelResim = New DevExpress.XtraBars.Docking.DockPanel()
        Me.ControlContainer2 = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.dPanelTanım = New DevExpress.XtraBars.Docking.DockPanel()
        Me.ControlContainer5 = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.lbl_sNet = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_sBekleyen = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Fiyat4 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Fiyat3 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Fiyat2 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Fiyat1 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_sMevcut = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_sBirimCinsi = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_sBarkod = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_sKisaAdi = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_sAciklama = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_sKodu = New DevExpress.XtraEditors.LabelControl()
        Me.sPicture = New DevExpress.XtraEditors.PictureEdit()
        Me.dPanelRecete = New DevExpress.XtraBars.Docking.DockPanel()
        Me.ControlContainer3 = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.dPanelAlternatif = New DevExpress.XtraBars.Docking.DockPanel()
        Me.ControlContainer1 = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.GridControl5 = New DevExpress.XtraGrid.GridControl()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn39 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn42 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn44 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn46 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn47 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn48 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn49 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn52 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn53 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn54 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn55 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn56 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn58 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn59 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn60 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn61 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn62 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn63 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn64 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn65 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn66 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn67 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn68 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn69 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn70 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lbl_sAlternatifAciklama = New DevExpress.XtraEditors.LabelControl()
        Me.dPanelEnvanter = New DevExpress.XtraBars.Docking.DockPanel()
        Me.ControlContainer4 = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGIREN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCIKAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKALAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lbl_sEnvanterAciklama = New DevExpress.XtraEditors.LabelControl()
        Me.dPanelSiniflandirma = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnMusteriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSinifTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSinifKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_Siniflar = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbSatisYapilamaz = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSinifKodu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.lbl_sSiniflandirmaAciklama = New DevExpress.XtraEditors.LabelControl()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
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
        CType(Me.chk_Sec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_pResim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dPanelResim.SuspendLayout()
        Me.dPanelTanım.SuspendLayout()
        Me.ControlContainer5.SuspendLayout()
        CType(Me.sPicture.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dPanelRecete.SuspendLayout()
        Me.dPanelAlternatif.SuspendLayout()
        Me.ControlContainer1.SuspendLayout()
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dPanelEnvanter.SuspendLayout()
        Me.ControlContainer4.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dPanelSiniflandirma.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_Siniflar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinifKodu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colMEVCUT
        '
        Me.colMEVCUT.Caption = "Mevcut"
        Me.colMEVCUT.DisplayFormat.FormatString = "#,0.####"
        Me.colMEVCUT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMEVCUT.FieldName = "Mevcut"
        Me.colMEVCUT.Name = "colMEVCUT"
        Me.colMEVCUT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Mevcut", "{0:#,0.####}")})
        Me.colMEVCUT.Visible = True
        Me.colMEVCUT.VisibleIndex = 3
        Me.colMEVCUT.Width = 73
        '
        'colbFiyatDegisti
        '
        Me.colbFiyatDegisti.Caption = "Fiyatı Değişti"
        Me.colbFiyatDegisti.FieldName = "bFiyatDegisti"
        Me.colbFiyatDegisti.Name = "colbFiyatDegisti"
        '
        'colnStokTipi
        '
        Me.colnStokTipi.Caption = "Stok Tipi"
        Me.colnStokTipi.FieldName = "nStokTipi"
        Me.colnStokTipi.Name = "colnStokTipi"
        Me.colnStokTipi.OptionsColumn.ShowCaption = False
        Me.colnStokTipi.OptionsColumn.ShowInCustomizationForm = False
        '
        'colbYeni
        '
        Me.colbYeni.Caption = "Yeni"
        Me.colbYeni.FieldName = "bYeni"
        Me.colbYeni.Name = "colbYeni"
        '
        'GridColumn45
        '
        Me.GridColumn45.Caption = "Mevcut"
        Me.GridColumn45.DisplayFormat.FormatString = "#,0.####"
        Me.GridColumn45.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn45.FieldName = "Mevcut"
        Me.GridColumn45.Name = "GridColumn45"
        Me.GridColumn45.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Mevcut", "{0:#,0.####}")})
        Me.GridColumn45.Visible = True
        Me.GridColumn45.VisibleIndex = 2
        Me.GridColumn45.Width = 232
        '
        'GridColumn50
        '
        Me.GridColumn50.Caption = "Fiyatı Değişti"
        Me.GridColumn50.FieldName = "bFiyatDegisti"
        Me.GridColumn50.Name = "GridColumn50"
        '
        'GridColumn51
        '
        Me.GridColumn51.Caption = "Stok Tipi"
        Me.GridColumn51.FieldName = "nStokTipi"
        Me.GridColumn51.Name = "GridColumn51"
        Me.GridColumn51.OptionsColumn.ShowCaption = False
        Me.GridColumn51.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumn57
        '
        Me.GridColumn57.Caption = "Yeni"
        Me.GridColumn57.FieldName = "bYeni"
        Me.GridColumn57.Name = "GridColumn57"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Mevcut"
        Me.GridColumn12.DisplayFormat.FormatString = "#,0.####"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "Mevcut"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Mevcut", "{0:#,0.####}")})
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 2
        Me.GridColumn12.Width = 216
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Fiyatı Değişti"
        Me.GridColumn17.FieldName = "bFiyatDegisti"
        Me.GridColumn17.Name = "GridColumn17"
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Stok Tipi"
        Me.GridColumn18.FieldName = "nStokTipi"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.ShowCaption = False
        Me.GridColumn18.OptionsColumn.ShowInCustomizationForm = False
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Yeni"
        Me.GridColumn24.FieldName = "bYeni"
        Me.GridColumn24.Name = "GridColumn24"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1364, 74)
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(153, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1209, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Aşağıda Stok Kartlarının Listesini Görmektesiniz.İşlem Yapmak istediğiniz Stok Ka" &
    "rtını seçmek için [Tamam] butonuna tıklayınız, yeniden Arama yapmak için ise [Ar" &
    "a] butonuna tıklayınız."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 535)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1364, 61)
        Me.PanelControl2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "*** Kayıt Bulunamadı...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(1228, 13)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(120, 34)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1108, 13)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 34)
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
        Me.PanelControl3.Size = New System.Drawing.Size(1364, 461)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1360, 457)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1358, 418)
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
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_renk, Me.sec_pResim, Me.chk_Sec})
        Me.GridControl1.Size = New System.Drawing.Size(1358, 418)
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nStokID"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sKodu"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sAciklama"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sRenk"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sBeden"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sMODEL"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "sBarkod"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "MEVCUT"
        Me.DataColumn8.DataType = GetType(Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "pResim"
        Me.DataColumn9.DataType = GetType(Byte())
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
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSec, Me.colnStokID, Me.colsKodu, Me.colsAciklama, Me.colsRenk, Me.colsBeden, Me.colsMODEL, Me.colsBarkod, Me.colMEVCUT, Me.colPESIN, Me.colALTIAY, Me.colONAY, Me.colsKisaAdi, Me.colbFiyatDegisti, Me.colnStokTipi, Me.colsFIYAT4, Me.colsBirimCinsi1, Me.colnBirimCarpan, Me.colsOzelNot, Me.sKavala, Me.colbYeni, Me.colBEKLEYEN, Me.colAlinanSiparis, Me.colVerilenSiparis, Me.colnHacim, Me.colnAgirlik, Me.colsDepo1, Me.colsDepo2, Me.colsDepo3, Me.colsDepo4, Me.colsDepo5, Me.colMEVCUT2, Me.colsBirimCinsi2, Me.coldteFiyatTespit, Me.colSINIF1, Me.colsDovizCinsi, Me.colsDepo6, Me.colSINIF2, Me.colSINIF3, Me.colSINIF4, Me.colSINIF5, Me.colSINIF6, Me.colSINIF7, Me.colSINIF8, Me.colSINIF9, Me.colSINIF10, Me.colsDepo7, Me.colsDepo9, Me.colFIYAT5, Me.colFIYAT6, Me.colFIYAT7, Me.colFIYAT8, Me.colFIYAT9, Me.colFIYAT10, Me.colResim, Me.colWebGoruntule, Me.colWebTavsiye})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(617, 339, 208, 156)
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.colMEVCUT
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.colMEVCUT
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition2.Value1 = "0"
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Appearance.Options.UseForeColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.colbFiyatDegisti
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition3.Value1 = "0"
        StyleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.Silver
        StyleFormatCondition4.Appearance.Options.UseForeColor = True
        StyleFormatCondition4.ApplyToRow = True
        StyleFormatCondition4.Column = Me.colnStokTipi
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition4.Value1 = "5"
        StyleFormatCondition5.Appearance.ForeColor = System.Drawing.Color.Purple
        StyleFormatCondition5.Appearance.Options.UseForeColor = True
        StyleFormatCondition5.ApplyToRow = True
        StyleFormatCondition5.Column = Me.colbYeni
        StyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition5.Expression = "1"
        StyleFormatCondition5.Value1 = "1"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4, StyleFormatCondition5})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colSec
        '
        Me.colSec.Caption = "Seç"
        Me.colSec.ColumnEdit = Me.chk_Sec
        Me.colSec.FieldName = "Sec"
        Me.colSec.Name = "colSec"
        ' Me.colSec.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean] ' Bound kolona çevrildi
        Me.colSec.Visible = True
        Me.colSec.VisibleIndex = 0
        Me.colSec.Width = 50
        '
        'chk_Sec
        '
        Me.chk_Sec.AutoHeight = False
        Me.chk_Sec.Name = "chk_Sec"
        '
        'colnStokID
        '
        Me.colnStokID.Caption = "Kayıt No"
        Me.colnStokID.FieldName = "nStokID"
        Me.colnStokID.Name = "colnStokID"
        Me.colnStokID.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "nStokID", "{0} Kayıt")})
        Me.colnStokID.Width = 72
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Stok Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", "{0} Kayıt")})
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 1
        Me.colsKodu.Width = 124
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Stok Adı"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 2
        Me.colsAciklama.Width = 274
        '
        'colsRenk
        '
        Me.colsRenk.Caption = "Renk"
        Me.colsRenk.FieldName = "sRenkAdi"
        Me.colsRenk.Name = "colsRenk"
        Me.colsRenk.Width = 82
        '
        'colsBeden
        '
        Me.colsBeden.Caption = "Beden"
        Me.colsBeden.FieldName = "sBeden"
        Me.colsBeden.Name = "colsBeden"
        Me.colsBeden.Width = 82
        '
        'colsMODEL
        '
        Me.colsMODEL.Caption = "ModelNo"
        Me.colsMODEL.FieldName = "sModel"
        Me.colsMODEL.Name = "colsMODEL"
        Me.colsMODEL.Width = 109
        '
        'colsBarkod
        '
        Me.colsBarkod.Caption = "Barkod"
        Me.colsBarkod.FieldName = "sBarkod"
        Me.colsBarkod.Name = "colsBarkod"
        Me.colsBarkod.Width = 154
        '
        'colPESIN
        '
        Me.colPESIN.Caption = "1. Satış Fiyatı"
        Me.colPESIN.DisplayFormat.FormatString = "#,0.00#"
        Me.colPESIN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPESIN.FieldName = "lFiyat1"
        Me.colPESIN.Name = "colPESIN"
        Me.colPESIN.Visible = True
        Me.colPESIN.VisibleIndex = 5
        Me.colPESIN.Width = 92
        '
        'colALTIAY
        '
        Me.colALTIAY.Caption = "2. Satış Fiyatı"
        Me.colALTIAY.DisplayFormat.FormatString = "#,0.00#"
        Me.colALTIAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colALTIAY.FieldName = "lFiyat2"
        Me.colALTIAY.Name = "colALTIAY"
        Me.colALTIAY.Visible = True
        Me.colALTIAY.VisibleIndex = 6
        Me.colALTIAY.Width = 92
        '
        'colONAY
        '
        Me.colONAY.Caption = "3. Satış Fiyatı"
        Me.colONAY.DisplayFormat.FormatString = "#,0.00#"
        Me.colONAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colONAY.FieldName = "lFiyat3"
        Me.colONAY.Name = "colONAY"
        Me.colONAY.Visible = True
        Me.colONAY.VisibleIndex = 7
        Me.colONAY.Width = 102
        '
        'colsKisaAdi
        '
        Me.colsKisaAdi.Caption = "KisaAdi"
        Me.colsKisaAdi.FieldName = "sKisaAdi"
        Me.colsKisaAdi.Name = "colsKisaAdi"
        Me.colsKisaAdi.Width = 64
        '
        'colsFIYAT4
        '
        Me.colsFIYAT4.Caption = "4. Satış Fiyatı"
        Me.colsFIYAT4.DisplayFormat.FormatString = "#,0.00#"
        Me.colsFIYAT4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colsFIYAT4.FieldName = "lFiyat4"
        Me.colsFIYAT4.Name = "colsFIYAT4"
        '
        'colsBirimCinsi1
        '
        Me.colsBirimCinsi1.Caption = "Birim"
        Me.colsBirimCinsi1.FieldName = "sBirimCinsi1"
        Me.colsBirimCinsi1.Name = "colsBirimCinsi1"
        Me.colsBirimCinsi1.Visible = True
        Me.colsBirimCinsi1.VisibleIndex = 4
        Me.colsBirimCinsi1.Width = 54
        '
        'colnBirimCarpan
        '
        Me.colnBirimCarpan.Caption = "Koli İçi"
        Me.colnBirimCarpan.DisplayFormat.FormatString = "#,0.##"
        Me.colnBirimCarpan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnBirimCarpan.FieldName = "nBirimCarpan"
        Me.colnBirimCarpan.Name = "colnBirimCarpan"
        Me.colnBirimCarpan.Width = 54
        '
        'colsOzelNot
        '
        Me.colsOzelNot.Caption = "Özel Not"
        Me.colsOzelNot.FieldName = "sOzelNot"
        Me.colsOzelNot.Name = "colsOzelNot"
        '
        'sKavala
        '
        Me.sKavala.Caption = "Kavala"
        Me.sKavala.FieldName = "sKavala"
        Me.sKavala.Name = "sKavala"
        '
        'colBEKLEYEN
        '
        Me.colBEKLEYEN.Caption = "Bekleyen"
        Me.colBEKLEYEN.DisplayFormat.FormatString = "#,#.####"
        Me.colBEKLEYEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBEKLEYEN.FieldName = "BEKLEYEN"
        Me.colBEKLEYEN.Name = "colBEKLEYEN"
        Me.colBEKLEYEN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BEKLEYEN", "{0:#,0.####}")})
        '
        'colAlinanSiparis
        '
        Me.colAlinanSiparis.Caption = "AS"
        Me.colAlinanSiparis.DisplayFormat.FormatString = "#,#.####"
        Me.colAlinanSiparis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAlinanSiparis.FieldName = "AlinanSiparis"
        Me.colAlinanSiparis.Name = "colAlinanSiparis"
        Me.colAlinanSiparis.OptionsColumn.ShowInCustomizationForm = False
        Me.colAlinanSiparis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AlinanSiparis", "{0:#,0.####}")})
        '
        'colVerilenSiparis
        '
        Me.colVerilenSiparis.Caption = "VS"
        Me.colVerilenSiparis.DisplayFormat.FormatString = "#,#.####"
        Me.colVerilenSiparis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVerilenSiparis.FieldName = "VerilenSiparis"
        Me.colVerilenSiparis.Name = "colVerilenSiparis"
        Me.colVerilenSiparis.OptionsColumn.ShowInCustomizationForm = False
        Me.colVerilenSiparis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VerilenSiparis", "{0:#,0.####}")})
        '
        'colnHacim
        '
        Me.colnHacim.Caption = "Hacim"
        Me.colnHacim.FieldName = "nHacim"
        Me.colnHacim.Name = "colnHacim"
        '
        'colnAgirlik
        '
        Me.colnAgirlik.Caption = "Agirlik"
        Me.colnAgirlik.FieldName = "nAgirlik"
        Me.colnAgirlik.Name = "colnAgirlik"
        '
        'colsDepo1
        '
        Me.colsDepo1.Caption = "Depo1"
        Me.colsDepo1.DisplayFormat.FormatString = "#,0.###"
        Me.colsDepo1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colsDepo1.FieldName = "sDepo1"
        Me.colsDepo1.Name = "colsDepo1"
        Me.colsDepo1.OptionsColumn.ShowInCustomizationForm = False
        Me.colsDepo1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sDepo1", "{0:#,0.###}")})
        Me.colsDepo1.Width = 54
        '
        'colsDepo2
        '
        Me.colsDepo2.Caption = "Depo2"
        Me.colsDepo2.DisplayFormat.FormatString = "#,0.###"
        Me.colsDepo2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colsDepo2.FieldName = "sDepo2"
        Me.colsDepo2.Name = "colsDepo2"
        Me.colsDepo2.OptionsColumn.ShowInCustomizationForm = False
        Me.colsDepo2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sDepo2", "{0:#,0.###}")})
        Me.colsDepo2.Width = 54
        '
        'colsDepo3
        '
        Me.colsDepo3.Caption = "Depo3"
        Me.colsDepo3.DisplayFormat.FormatString = "#,0.###"
        Me.colsDepo3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colsDepo3.FieldName = "sDepo3"
        Me.colsDepo3.Name = "colsDepo3"
        Me.colsDepo3.OptionsColumn.ShowInCustomizationForm = False
        Me.colsDepo3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sDepo3", "{0:#,0.###}")})
        Me.colsDepo3.Width = 54
        '
        'colsDepo4
        '
        Me.colsDepo4.Caption = "Depo4"
        Me.colsDepo4.DisplayFormat.FormatString = "#,0.###"
        Me.colsDepo4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colsDepo4.FieldName = "sDepo4"
        Me.colsDepo4.Name = "colsDepo4"
        Me.colsDepo4.OptionsColumn.ShowInCustomizationForm = False
        Me.colsDepo4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sDepo4", "{0:#,0.###}")})
        Me.colsDepo4.Width = 54
        '
        'colsDepo5
        '
        Me.colsDepo5.Caption = "Depo5"
        Me.colsDepo5.DisplayFormat.FormatString = "#,0.###"
        Me.colsDepo5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colsDepo5.FieldName = "sDepo5"
        Me.colsDepo5.Name = "colsDepo5"
        Me.colsDepo5.OptionsColumn.ShowInCustomizationForm = False
        Me.colsDepo5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sDepo5", "{0:#,0.###}")})
        Me.colsDepo5.Width = 71
        '
        'colMEVCUT2
        '
        Me.colMEVCUT2.Caption = "Mevcut2"
        Me.colMEVCUT2.DisplayFormat.FormatString = "#,0.###"
        Me.colMEVCUT2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMEVCUT2.FieldName = "Mevcut2"
        Me.colMEVCUT2.Name = "colMEVCUT2"
        Me.colMEVCUT2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Mevcut2", "{0:#,0.###}")})
        Me.colMEVCUT2.Width = 54
        '
        'colsBirimCinsi2
        '
        Me.colsBirimCinsi2.Caption = "Birim2"
        Me.colsBirimCinsi2.FieldName = "sBirimCinsi2"
        Me.colsBirimCinsi2.Name = "colsBirimCinsi2"
        '
        'coldteFiyatTespit
        '
        Me.coldteFiyatTespit.Caption = "FiyatTespit"
        Me.coldteFiyatTespit.FieldName = "dteFiyatTespitTarihi"
        Me.coldteFiyatTespit.Name = "coldteFiyatTespit"
        '
        'colSINIF1
        '
        Me.colSINIF1.Caption = "SINIF1"
        Me.colSINIF1.FieldName = "SINIF1"
        Me.colSINIF1.Name = "colSINIF1"
        Me.colSINIF1.Visible = True
        Me.colSINIF1.VisibleIndex = 12
        '
        'colsDovizCinsi
        '
        Me.colsDovizCinsi.Caption = "Pb"
        Me.colsDovizCinsi.FieldName = "sDovizCinsi"
        Me.colsDovizCinsi.Name = "colsDovizCinsi"
        '
        'colsDepo6
        '
        Me.colsDepo6.Caption = "Depo6"
        Me.colsDepo6.FieldName = "sDepo6"
        Me.colsDepo6.Name = "colsDepo6"
        Me.colsDepo6.OptionsColumn.ShowInCustomizationForm = False
        '
        'colSINIF2
        '
        Me.colSINIF2.Caption = "SINIF2"
        Me.colSINIF2.FieldName = "SINIF2"
        Me.colSINIF2.Name = "colSINIF2"
        Me.colSINIF2.OptionsColumn.ShowInCustomizationForm = False
        Me.colSINIF2.Visible = True
        Me.colSINIF2.VisibleIndex = 8
        '
        'colSINIF3
        '
        Me.colSINIF3.Caption = "SINIF3"
        Me.colSINIF3.FieldName = "SINIF3"
        Me.colSINIF3.Name = "colSINIF3"
        Me.colSINIF3.OptionsColumn.ShowInCustomizationForm = False
        Me.colSINIF3.Visible = True
        Me.colSINIF3.VisibleIndex = 9
        '
        'colSINIF4
        '
        Me.colSINIF4.Caption = "SINIF4"
        Me.colSINIF4.FieldName = "SINIF4"
        Me.colSINIF4.Name = "colSINIF4"
        Me.colSINIF4.OptionsColumn.ShowInCustomizationForm = False
        Me.colSINIF4.Visible = True
        Me.colSINIF4.VisibleIndex = 10
        '
        'colSINIF5
        '
        Me.colSINIF5.Caption = "SINIF5"
        Me.colSINIF5.FieldName = "SINIF5"
        Me.colSINIF5.Name = "colSINIF5"
        Me.colSINIF5.OptionsColumn.ShowInCustomizationForm = False
        Me.colSINIF5.Visible = True
        Me.colSINIF5.VisibleIndex = 11
        '
        'colSINIF6
        '
        Me.colSINIF6.Caption = "SINIF6"
        Me.colSINIF6.FieldName = "SINIF6"
        Me.colSINIF6.Name = "colSINIF6"
        Me.colSINIF6.OptionsColumn.ShowInCustomizationForm = False
        '
        'colSINIF7
        '
        Me.colSINIF7.Caption = "SINIF7"
        Me.colSINIF7.FieldName = "SINIF7"
        Me.colSINIF7.Name = "colSINIF7"
        Me.colSINIF7.OptionsColumn.ShowInCustomizationForm = False
        '
        'colSINIF8
        '
        Me.colSINIF8.Caption = "SINIF8"
        Me.colSINIF8.FieldName = "SINIF8"
        Me.colSINIF8.Name = "colSINIF8"
        Me.colSINIF8.OptionsColumn.ShowInCustomizationForm = False
        '
        'colSINIF9
        '
        Me.colSINIF9.Caption = "SINIF9"
        Me.colSINIF9.FieldName = "SINIF9"
        Me.colSINIF9.Name = "colSINIF9"
        Me.colSINIF9.OptionsColumn.ShowInCustomizationForm = False
        '
        'colSINIF10
        '
        Me.colSINIF10.Caption = "SINIF10"
        Me.colSINIF10.FieldName = "SINIF10"
        Me.colSINIF10.Name = "colSINIF10"
        Me.colSINIF10.OptionsColumn.ShowInCustomizationForm = False
        '
        'colsDepo7
        '
        Me.colsDepo7.Caption = "sDepo7"
        Me.colsDepo7.DisplayFormat.FormatString = "#,0.###"
        Me.colsDepo7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colsDepo7.FieldName = "sDepo7"
        Me.colsDepo7.Name = "colsDepo7"
        Me.colsDepo7.OptionsColumn.ShowInCustomizationForm = False
        '
        'colsDepo9
        '
        Me.colsDepo9.Caption = "sDepo9"
        Me.colsDepo9.DisplayFormat.FormatString = "#,0.###"
        Me.colsDepo9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colsDepo9.FieldName = "sDepo9"
        Me.colsDepo9.Name = "colsDepo9"
        Me.colsDepo9.OptionsColumn.ShowInCustomizationForm = False
        '
        'colFIYAT5
        '
        Me.colFIYAT5.Caption = "5. Satış Fiyatı"
        Me.colFIYAT5.DisplayFormat.FormatString = "#,0.00#"
        Me.colFIYAT5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT5.FieldName = "FIYAT5"
        Me.colFIYAT5.Name = "colFIYAT5"
        '
        'colFIYAT6
        '
        Me.colFIYAT6.Caption = "6. Satış Fiyatı"
        Me.colFIYAT6.DisplayFormat.FormatString = "#,0.00#"
        Me.colFIYAT6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT6.FieldName = "FIYAT6"
        Me.colFIYAT6.Name = "colFIYAT6"
        '
        'colFIYAT7
        '
        Me.colFIYAT7.Caption = "7. Satış Fiyatı"
        Me.colFIYAT7.DisplayFormat.FormatString = "#,0.00#"
        Me.colFIYAT7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT7.FieldName = "FIYAT7"
        Me.colFIYAT7.Name = "colFIYAT7"
        '
        'colFIYAT8
        '
        Me.colFIYAT8.Caption = "8. Satış Fiyatı"
        Me.colFIYAT8.DisplayFormat.FormatString = "#,0.00#"
        Me.colFIYAT8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT8.FieldName = "FIYAT8"
        Me.colFIYAT8.Name = "colFIYAT8"
        '
        'colFIYAT9
        '
        Me.colFIYAT9.Caption = "9. Satış Fiyatı"
        Me.colFIYAT9.DisplayFormat.FormatString = "#,0.00#"
        Me.colFIYAT9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT9.FieldName = "FIYAT9"
        Me.colFIYAT9.Name = "colFIYAT9"
        '
        'colFIYAT10
        '
        Me.colFIYAT10.Caption = "10. Satış Fiyatı"
        Me.colFIYAT10.DisplayFormat.FormatString = "#,0.00#"
        Me.colFIYAT10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT10.FieldName = "FIYAT10"
        Me.colFIYAT10.Name = "colFIYAT10"
        '
        'colResim
        '
        Me.colResim.Caption = "Resim"
        Me.colResim.ColumnEdit = Me.sec_pResim
        Me.colResim.FieldName = "pResim"
        Me.colResim.Name = "colResim"
        Me.colResim.Visible = True
        Me.colResim.VisibleIndex = 13
        '
        'sec_pResim
        '
        Me.sec_pResim.Name = "sec_pResim"
        '
        'colWebGoruntule
        '
        Me.colWebGoruntule.Caption = "Web Görüntüle"
        Me.colWebGoruntule.FieldName = "bWebGoruntule"
        Me.colWebGoruntule.Name = "colWebGoruntule"
        '
        'colWebTavsiye
        '
        Me.colWebTavsiye.Caption = "Web Tavsiye"
        Me.colWebTavsiye.FieldName = "bWebTavsiye"
        Me.colWebTavsiye.Name = "colWebTavsiye"
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
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem39, Me.MenuItem40, Me.MenuItem41, Me.MenuItem15, Me.MenuItem16, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem12, Me.MenuItem30, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem21, Me.MenuItem19, Me.MenuItem27, Me.MenuItem20, Me.MenuItem28, Me.MenuItem26, Me.MenuItem29, Me.MenuItem31, Me.MenuItem13, Me.MenuItem7, Me.MenuItem8, Me.MenuItem9, Me.MenuItem14, Me.MenuItem25, Me.MenuItem10, Me.MenuItem11, Me.MenuItem18, Me.MenuItem17})
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 0
        Me.MenuItem39.Text = "Tümünü Seç"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 1
        Me.MenuItem40.Text = "Seçimi Kaldır"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 2
        Me.MenuItem41.Text = "Seçimi Ters Çevir"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 3
        Me.MenuItem15.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem15.Text = "Ara"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 4
        Me.MenuItem16.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 5
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem1.Text = "Ekle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 6
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem2.Text = "Düzenle"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 7
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem3.Text = "Sil"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 8
        Me.MenuItem12.Text = "-"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 9
        Me.MenuItem30.Shortcut = System.Windows.Forms.Shortcut.CtrlB
        Me.MenuItem30.Text = "Birim Çevrimi"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 10
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItem4.Text = "Fiyat Düzenle"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 11
        Me.MenuItem5.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem5.Text = "Envanter"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 12
        Me.MenuItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlF6
        Me.MenuItem6.Text = "Model Envanter"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 13
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem21.Text = "Stok Hareketleri"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 14
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.CtrlF7
        Me.MenuItem19.Text = "Transfer Hareketleri"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 15
        Me.MenuItem27.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItem27.Text = "Karlılık Akış Tablosu"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 16
        Me.MenuItem20.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem22, Me.MenuItem23, Me.MenuItem24})
        Me.MenuItem20.Text = "Raporla"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 0
        Me.MenuItem22.Text = "Önizle"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 1
        Me.MenuItem23.Text = "Dizayn"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 2
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.CtrlE
        Me.MenuItem24.Text = "Yazdır"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 17
        Me.MenuItem28.Shortcut = System.Windows.Forms.Shortcut.CtrlL
        Me.MenuItem28.Text = "Alternatifleri"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 18
        Me.MenuItem26.Shortcut = System.Windows.Forms.Shortcut.F11
        Me.MenuItem26.Text = "Resim Göster"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 19
        Me.MenuItem29.Shortcut = System.Windows.Forms.Shortcut.CtrlT
        Me.MenuItem29.Text = "Protokol"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 20
        Me.MenuItem31.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem38, Me.MenuItem32, Me.MenuItem33, Me.MenuItem34, Me.MenuItem35, Me.MenuItem36, Me.MenuItem37})
        Me.MenuItem31.Text = "Analiz"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 0
        Me.MenuItem38.Text = "Tanımlar"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 1
        Me.MenuItem32.Text = "Sınıflandırma"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 2
        Me.MenuItem33.Text = "Resim"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 3
        Me.MenuItem34.Text = "Envanter"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 4
        Me.MenuItem35.Text = "Alternatif"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 5
        Me.MenuItem36.Text = "Eşlenik"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 6
        Me.MenuItem37.Text = "Reçete"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 21
        Me.MenuItem13.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 22
        Me.MenuItem7.Text = "Görünüm Düzenle"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 23
        Me.MenuItem8.Text = "Görünümü Kaydet"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 24
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem9.Text = "Görünümü Yazdır"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 25
        Me.MenuItem14.Text = "-"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 26
        Me.MenuItem25.Text = "Hızlı Filtre"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 27
        Me.MenuItem10.Text = "Filtrele"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 28
        Me.MenuItem11.Text = "Gruplandır"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 29
        Me.MenuItem18.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 30
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Stok Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Stok İşlemleri", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
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
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Ara, Me.btn_Ekle, Me.btn_Duzelt, Me.btn_Sil, Me.btn_FiyatDuzenle, Me.btn_Envanter, Me.BarButtonItem7, Me.btn_StokHareketleri, Me.btn_Transferler, Me.btn_Yazdir, Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 11
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Ara), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Ekle, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Duzelt, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Sil, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Yazdir, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_FiyatDuzenle, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Envanter, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_StokHareketleri, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Transferler, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btn_Ara
        '
        Me.btn_Ara.Caption = "Ara ,F3"
        Me.btn_Ara.Id = 0
        Me.btn_Ara.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_Ara.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_Ara.Name = "btn_Ara"
        '
        'btn_Ekle
        '
        Me.btn_Ekle.Caption = "Ekle ,Insert"
        Me.btn_Ekle.Id = 1
        Me.btn_Ekle.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_Ekle.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_Ekle.Name = "btn_Ekle"
        '
        'btn_Duzelt
        '
        Me.btn_Duzelt.Caption = "Düzelt ,F4"
        Me.btn_Duzelt.Id = 2
        Me.btn_Duzelt.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_Duzelt.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_Duzelt.Name = "btn_Duzelt"
        '
        'btn_Sil
        '
        Me.btn_Sil.Caption = "Sil ,Ctrl+Del"
        Me.btn_Sil.Id = 3
        Me.btn_Sil.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_Sil.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_Sil.Name = "btn_Sil"
        '
        'btn_Yazdir
        '
        Me.btn_Yazdir.Caption = "Yazdır ,Ctrl+P"
        Me.btn_Yazdir.Id = 9
        Me.btn_Yazdir.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_Yazdir.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_Yazdir.Name = "btn_Yazdir"
        '
        'btn_FiyatDuzenle
        '
        Me.btn_FiyatDuzenle.Caption = "Fiyatlandır ,Ctrl+F"
        Me.btn_FiyatDuzenle.Id = 4
        Me.btn_FiyatDuzenle.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_FiyatDuzenle.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_FiyatDuzenle.Name = "btn_FiyatDuzenle"
        '
        'btn_Envanter
        '
        Me.btn_Envanter.Caption = "Envanter ,F6"
        Me.btn_Envanter.Id = 5
        Me.btn_Envanter.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_Envanter.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_Envanter.Name = "btn_Envanter"
        '
        'btn_StokHareketleri
        '
        Me.btn_StokHareketleri.Caption = "Hareketler ,F7"
        Me.btn_StokHareketleri.Id = 7
        Me.btn_StokHareketleri.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_StokHareketleri.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_StokHareketleri.Name = "btn_StokHareketleri"
        '
        'btn_Transferler
        '
        Me.btn_Transferler.Caption = "Transferler ,Ctrl+F7"
        Me.btn_Transferler.Id = 8
        Me.btn_Transferler.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btn_Transferler.ItemAppearance.Normal.Options.UseFont = True
        Me.btn_Transferler.Name = "btn_Transferler"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Excel"
        Me.BarButtonItem1.Id = 10
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1364, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 596)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1364, 34)
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
        Me.barDockControlRight.Location = New System.Drawing.Point(1364, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 596)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.HiddenPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dPanelResim, Me.dPanelRecete, Me.dPanelAlternatif, Me.dPanelEnvanter, Me.dPanelSiniflandirma, Me.dPanelTanım})
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'dPanelResim
        '
        Me.dPanelResim.Controls.Add(Me.ControlContainer2)
        Me.dPanelResim.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.dPanelResim.ID = New System.Guid("cfe6a9a6-815d-4c7a-888e-6d2b6ab122d3")
        Me.dPanelResim.Location = New System.Drawing.Point(4, 23)
        Me.dPanelResim.Name = "dPanelResim"
        Me.dPanelResim.OriginalSize = New System.Drawing.Size(192, 352)
        Me.dPanelResim.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.dPanelResim.SavedIndex = 5
        Me.dPanelResim.SavedParent = Me.dPanelTanım
        Me.dPanelResim.SavedTabbed = True
        Me.dPanelResim.Size = New System.Drawing.Size(192, 352)
        Me.dPanelResim.Text = "Resimler"
        Me.dPanelResim.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        '
        'ControlContainer2
        '
        Me.ControlContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ControlContainer2.Name = "ControlContainer2"
        Me.ControlContainer2.Size = New System.Drawing.Size(192, 352)
        Me.ControlContainer2.TabIndex = 0
        '
        'dPanelTanım
        '
        Me.dPanelTanım.Controls.Add(Me.ControlContainer5)
        Me.dPanelTanım.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.dPanelTanım.ID = New System.Guid("2dc76531-d100-4ce8-98e9-1e7fe097d358")
        Me.dPanelTanım.Location = New System.Drawing.Point(0, 0)
        Me.dPanelTanım.Name = "dPanelTanım"
        Me.dPanelTanım.OriginalSize = New System.Drawing.Size(227, 350)
        Me.dPanelTanım.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.dPanelTanım.SavedIndex = 0
        Me.dPanelTanım.Size = New System.Drawing.Size(227, 406)
        Me.dPanelTanım.Text = "Tanımlar"
        Me.dPanelTanım.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        '
        'ControlContainer5
        '
        Me.ControlContainer5.Controls.Add(Me.lbl_sNet)
        Me.ControlContainer5.Controls.Add(Me.lbl_sBekleyen)
        Me.ControlContainer5.Controls.Add(Me.lbl_Fiyat4)
        Me.ControlContainer5.Controls.Add(Me.lbl_Fiyat3)
        Me.ControlContainer5.Controls.Add(Me.lbl_Fiyat2)
        Me.ControlContainer5.Controls.Add(Me.lbl_Fiyat1)
        Me.ControlContainer5.Controls.Add(Me.lbl_sMevcut)
        Me.ControlContainer5.Controls.Add(Me.lbl_sBirimCinsi)
        Me.ControlContainer5.Controls.Add(Me.lbl_sBarkod)
        Me.ControlContainer5.Controls.Add(Me.lbl_sKisaAdi)
        Me.ControlContainer5.Controls.Add(Me.lbl_sAciklama)
        Me.ControlContainer5.Controls.Add(Me.lbl_sKodu)
        Me.ControlContainer5.Controls.Add(Me.sPicture)
        Me.ControlContainer5.Location = New System.Drawing.Point(4, 23)
        Me.ControlContainer5.Name = "ControlContainer5"
        Me.ControlContainer5.Size = New System.Drawing.Size(219, 379)
        Me.ControlContainer5.TabIndex = 0
        '
        'lbl_sNet
        '
        Me.lbl_sNet.AllowHtmlString = True
        Me.lbl_sNet.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_sNet.Location = New System.Drawing.Point(3, 255)
        Me.lbl_sNet.Name = "lbl_sNet"
        Me.lbl_sNet.Size = New System.Drawing.Size(27, 19)
        Me.lbl_sNet.TabIndex = 12
        Me.lbl_sNet.Text = "***"
        '
        'lbl_sBekleyen
        '
        Me.lbl_sBekleyen.AllowHtmlString = True
        Me.lbl_sBekleyen.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_sBekleyen.Location = New System.Drawing.Point(3, 242)
        Me.lbl_sBekleyen.Name = "lbl_sBekleyen"
        Me.lbl_sBekleyen.Size = New System.Drawing.Size(27, 19)
        Me.lbl_sBekleyen.TabIndex = 11
        Me.lbl_sBekleyen.Text = "***"
        '
        'lbl_Fiyat4
        '
        Me.lbl_Fiyat4.AllowHtmlString = True
        Me.lbl_Fiyat4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_Fiyat4.Location = New System.Drawing.Point(3, 324)
        Me.lbl_Fiyat4.Name = "lbl_Fiyat4"
        Me.lbl_Fiyat4.Size = New System.Drawing.Size(27, 19)
        Me.lbl_Fiyat4.TabIndex = 10
        Me.lbl_Fiyat4.Text = "***"
        '
        'lbl_Fiyat3
        '
        Me.lbl_Fiyat3.AllowHtmlString = True
        Me.lbl_Fiyat3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_Fiyat3.Location = New System.Drawing.Point(3, 310)
        Me.lbl_Fiyat3.Name = "lbl_Fiyat3"
        Me.lbl_Fiyat3.Size = New System.Drawing.Size(27, 19)
        Me.lbl_Fiyat3.TabIndex = 9
        Me.lbl_Fiyat3.Text = "***"
        '
        'lbl_Fiyat2
        '
        Me.lbl_Fiyat2.AllowHtmlString = True
        Me.lbl_Fiyat2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_Fiyat2.Location = New System.Drawing.Point(3, 296)
        Me.lbl_Fiyat2.Name = "lbl_Fiyat2"
        Me.lbl_Fiyat2.Size = New System.Drawing.Size(27, 19)
        Me.lbl_Fiyat2.TabIndex = 8
        Me.lbl_Fiyat2.Text = "***"
        '
        'lbl_Fiyat1
        '
        Me.lbl_Fiyat1.AllowHtmlString = True
        Me.lbl_Fiyat1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_Fiyat1.Location = New System.Drawing.Point(3, 282)
        Me.lbl_Fiyat1.Name = "lbl_Fiyat1"
        Me.lbl_Fiyat1.Size = New System.Drawing.Size(27, 19)
        Me.lbl_Fiyat1.TabIndex = 7
        Me.lbl_Fiyat1.Text = "***"
        '
        'lbl_sMevcut
        '
        Me.lbl_sMevcut.AllowHtmlString = True
        Me.lbl_sMevcut.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_sMevcut.Location = New System.Drawing.Point(3, 229)
        Me.lbl_sMevcut.Name = "lbl_sMevcut"
        Me.lbl_sMevcut.Size = New System.Drawing.Size(27, 19)
        Me.lbl_sMevcut.TabIndex = 6
        Me.lbl_sMevcut.Text = "***"
        '
        'lbl_sBirimCinsi
        '
        Me.lbl_sBirimCinsi.AllowHtmlString = True
        Me.lbl_sBirimCinsi.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_sBirimCinsi.Location = New System.Drawing.Point(2, 198)
        Me.lbl_sBirimCinsi.Name = "lbl_sBirimCinsi"
        Me.lbl_sBirimCinsi.Size = New System.Drawing.Size(27, 19)
        Me.lbl_sBirimCinsi.TabIndex = 5
        Me.lbl_sBirimCinsi.Text = "***"
        '
        'lbl_sBarkod
        '
        Me.lbl_sBarkod.AllowHtmlString = True
        Me.lbl_sBarkod.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_sBarkod.Location = New System.Drawing.Point(2, 184)
        Me.lbl_sBarkod.Name = "lbl_sBarkod"
        Me.lbl_sBarkod.Size = New System.Drawing.Size(27, 19)
        Me.lbl_sBarkod.TabIndex = 4
        Me.lbl_sBarkod.Text = "***"
        '
        'lbl_sKisaAdi
        '
        Me.lbl_sKisaAdi.AllowHtmlString = True
        Me.lbl_sKisaAdi.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_sKisaAdi.Location = New System.Drawing.Point(2, 170)
        Me.lbl_sKisaAdi.Name = "lbl_sKisaAdi"
        Me.lbl_sKisaAdi.Size = New System.Drawing.Size(27, 19)
        Me.lbl_sKisaAdi.TabIndex = 3
        Me.lbl_sKisaAdi.Text = "***"
        '
        'lbl_sAciklama
        '
        Me.lbl_sAciklama.AllowHtmlString = True
        Me.lbl_sAciklama.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_sAciklama.Location = New System.Drawing.Point(2, 156)
        Me.lbl_sAciklama.Name = "lbl_sAciklama"
        Me.lbl_sAciklama.Size = New System.Drawing.Size(27, 19)
        Me.lbl_sAciklama.TabIndex = 2
        Me.lbl_sAciklama.Text = "***"
        '
        'lbl_sKodu
        '
        Me.lbl_sKodu.AllowHtmlString = True
        Me.lbl_sKodu.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_sKodu.Location = New System.Drawing.Point(2, 142)
        Me.lbl_sKodu.Name = "lbl_sKodu"
        Me.lbl_sKodu.Size = New System.Drawing.Size(27, 19)
        Me.lbl_sKodu.TabIndex = 1
        Me.lbl_sKodu.Text = "***"
        '
        'sPicture
        '
        Me.sPicture.Dock = System.Windows.Forms.DockStyle.Top
        Me.sPicture.Location = New System.Drawing.Point(0, 0)
        Me.sPicture.MenuManager = Me.BarManager1
        Me.sPicture.Name = "sPicture"
        Me.sPicture.Properties.ShowMenu = False
        Me.sPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.sPicture.Size = New System.Drawing.Size(219, 136)
        Me.sPicture.TabIndex = 0
        '
        'dPanelRecete
        '
        Me.dPanelRecete.Controls.Add(Me.ControlContainer3)
        Me.dPanelRecete.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.dPanelRecete.ID = New System.Guid("730c0d6e-5a1e-46f9-9726-fb97b5d96c98")
        Me.dPanelRecete.Location = New System.Drawing.Point(4, 23)
        Me.dPanelRecete.Name = "dPanelRecete"
        Me.dPanelRecete.OriginalSize = New System.Drawing.Size(192, 352)
        Me.dPanelRecete.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.dPanelRecete.SavedIndex = 4
        Me.dPanelRecete.SavedParent = Me.dPanelTanım
        Me.dPanelRecete.SavedTabbed = True
        Me.dPanelRecete.Size = New System.Drawing.Size(192, 352)
        Me.dPanelRecete.Text = "Reçete"
        Me.dPanelRecete.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        '
        'ControlContainer3
        '
        Me.ControlContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ControlContainer3.Name = "ControlContainer3"
        Me.ControlContainer3.Size = New System.Drawing.Size(192, 352)
        Me.ControlContainer3.TabIndex = 0
        '
        'dPanelAlternatif
        '
        Me.dPanelAlternatif.Controls.Add(Me.ControlContainer1)
        Me.dPanelAlternatif.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.dPanelAlternatif.FloatVertical = True
        Me.dPanelAlternatif.ID = New System.Guid("a8c8370b-c31d-450c-9b75-bccf96fdb981")
        Me.dPanelAlternatif.Location = New System.Drawing.Point(4, 23)
        Me.dPanelAlternatif.Name = "dPanelAlternatif"
        Me.dPanelAlternatif.OriginalSize = New System.Drawing.Size(227, 350)
        Me.dPanelAlternatif.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.dPanelAlternatif.SavedIndex = 0
        Me.dPanelAlternatif.SavedParent = Me.dPanelTanım
        Me.dPanelAlternatif.SavedTabbed = True
        Me.dPanelAlternatif.Size = New System.Drawing.Size(227, 352)
        Me.dPanelAlternatif.Text = "Alternatifler"
        Me.dPanelAlternatif.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        '
        'ControlContainer1
        '
        Me.ControlContainer1.Controls.Add(Me.GridControl5)
        Me.ControlContainer1.Controls.Add(Me.LabelControl1)
        Me.ControlContainer1.Controls.Add(Me.GridControl4)
        Me.ControlContainer1.Controls.Add(Me.lbl_sAlternatifAciklama)
        Me.ControlContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ControlContainer1.Name = "ControlContainer1"
        Me.ControlContainer1.Size = New System.Drawing.Size(227, 352)
        Me.ControlContainer1.TabIndex = 0
        '
        'GridControl5
        '
        Me.GridControl5.DataMember = "Table1"
        Me.GridControl5.DataSource = Me.DataSet1
        Me.GridControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl5.Location = New System.Drawing.Point(0, 234)
        Me.GridControl5.MainView = Me.GridView5
        Me.GridControl5.Name = "GridControl5"
        Me.GridControl5.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2})
        Me.GridControl5.Size = New System.Drawing.Size(227, 118)
        Me.GridControl5.TabIndex = 7
        Me.GridControl5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
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
        Me.GridView5.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView5.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView5.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView5.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView5.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView5.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView5.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView5.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn38, Me.GridColumn39, Me.GridColumn40, Me.GridColumn41, Me.GridColumn42, Me.GridColumn43, Me.GridColumn44, Me.GridColumn45, Me.GridColumn46, Me.GridColumn47, Me.GridColumn48, Me.GridColumn49, Me.GridColumn50, Me.GridColumn51, Me.GridColumn52, Me.GridColumn53, Me.GridColumn54, Me.GridColumn55, Me.GridColumn56, Me.GridColumn57, Me.GridColumn58, Me.GridColumn59, Me.GridColumn60, Me.GridColumn61, Me.GridColumn62, Me.GridColumn63, Me.GridColumn64, Me.GridColumn65, Me.GridColumn66, Me.GridColumn67, Me.GridColumn68, Me.GridColumn69, Me.GridColumn70})
        Me.GridView5.CustomizationFormBounds = New System.Drawing.Rectangle(617, 339, 208, 156)
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition6.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition6.Appearance.Options.UseFont = True
        StyleFormatCondition6.Appearance.Options.UseForeColor = True
        StyleFormatCondition6.Column = Me.GridColumn45
        StyleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition6.Value1 = "0"
        StyleFormatCondition7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition7.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition7.Appearance.Options.UseFont = True
        StyleFormatCondition7.Appearance.Options.UseForeColor = True
        StyleFormatCondition7.Column = Me.GridColumn45
        StyleFormatCondition7.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition7.Value1 = "0"
        StyleFormatCondition8.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition8.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition8.Appearance.Options.UseBackColor = True
        StyleFormatCondition8.Appearance.Options.UseForeColor = True
        StyleFormatCondition8.ApplyToRow = True
        StyleFormatCondition8.Column = Me.GridColumn50
        StyleFormatCondition8.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition8.Value1 = "0"
        StyleFormatCondition9.Appearance.ForeColor = System.Drawing.Color.Silver
        StyleFormatCondition9.Appearance.Options.UseForeColor = True
        StyleFormatCondition9.ApplyToRow = True
        StyleFormatCondition9.Column = Me.GridColumn51
        StyleFormatCondition9.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition9.Value1 = "5"
        StyleFormatCondition10.Appearance.ForeColor = System.Drawing.Color.Purple
        StyleFormatCondition10.Appearance.Options.UseForeColor = True
        StyleFormatCondition10.ApplyToRow = True
        StyleFormatCondition10.Column = Me.GridColumn57
        StyleFormatCondition10.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition10.Expression = "1"
        StyleFormatCondition10.Value1 = "1"
        Me.GridView5.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition6, StyleFormatCondition7, StyleFormatCondition8, StyleFormatCondition9, StyleFormatCondition10})
        Me.GridView5.GridControl = Me.GridControl5
        Me.GridView5.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.GridView5.OptionsBehavior.Editable = False
        Me.GridView5.OptionsCustomization.AllowFilter = False
        Me.GridView5.OptionsCustomization.AllowGroup = False
        Me.GridView5.OptionsNavigation.UseTabKey = False
        Me.GridView5.OptionsSelection.MultiSelect = True
        Me.GridView5.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView5.OptionsView.ShowFooter = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.OptionsView.ShowIndicator = False
        '
        'GridColumn38
        '
        Me.GridColumn38.Caption = "Kayıt No"
        Me.GridColumn38.FieldName = "nStokID"
        Me.GridColumn38.Name = "GridColumn38"
        Me.GridColumn38.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "nStokID", "{0} Kayıt")})
        Me.GridColumn38.Width = 72
        '
        'GridColumn39
        '
        Me.GridColumn39.Caption = "Kod"
        Me.GridColumn39.FieldName = "sKodu"
        Me.GridColumn39.Name = "GridColumn39"
        Me.GridColumn39.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", "{0} Kayıt")})
        Me.GridColumn39.Visible = True
        Me.GridColumn39.VisibleIndex = 0
        Me.GridColumn39.Width = 279
        '
        'GridColumn40
        '
        Me.GridColumn40.Caption = "Açıklama"
        Me.GridColumn40.FieldName = "sAciklama"
        Me.GridColumn40.Name = "GridColumn40"
        Me.GridColumn40.Visible = True
        Me.GridColumn40.VisibleIndex = 1
        Me.GridColumn40.Width = 443
        '
        'GridColumn41
        '
        Me.GridColumn41.Caption = "Renk"
        Me.GridColumn41.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.GridColumn41.FieldName = "sRenk"
        Me.GridColumn41.Name = "GridColumn41"
        Me.GridColumn41.Width = 82
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sRenkAdi", "Renk")})
        Me.RepositoryItemLookUpEdit2.DisplayMember = "sRenkAdi"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.RepositoryItemLookUpEdit2.ShowFooter = False
        Me.RepositoryItemLookUpEdit2.ShowHeader = False
        Me.RepositoryItemLookUpEdit2.ShowLines = False
        Me.RepositoryItemLookUpEdit2.ValueMember = "sRenk"
        '
        'GridColumn42
        '
        Me.GridColumn42.Caption = "Beden"
        Me.GridColumn42.FieldName = "sBeden"
        Me.GridColumn42.Name = "GridColumn42"
        Me.GridColumn42.Width = 82
        '
        'GridColumn43
        '
        Me.GridColumn43.Caption = "ModelNo"
        Me.GridColumn43.FieldName = "sModel"
        Me.GridColumn43.Name = "GridColumn43"
        Me.GridColumn43.Width = 109
        '
        'GridColumn44
        '
        Me.GridColumn44.Caption = "Barkod"
        Me.GridColumn44.FieldName = "sBarkod"
        Me.GridColumn44.Name = "GridColumn44"
        Me.GridColumn44.Width = 154
        '
        'GridColumn46
        '
        Me.GridColumn46.Caption = "Fiyat"
        Me.GridColumn46.DisplayFormat.FormatString = "#,0.00#"
        Me.GridColumn46.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn46.FieldName = "PESIN"
        Me.GridColumn46.Name = "GridColumn46"
        Me.GridColumn46.Visible = True
        Me.GridColumn46.VisibleIndex = 3
        Me.GridColumn46.Width = 316
        '
        'GridColumn47
        '
        Me.GridColumn47.Caption = "2. Satış Fiyatı"
        Me.GridColumn47.DisplayFormat.FormatString = "#,0.00#"
        Me.GridColumn47.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn47.FieldName = "ALTIAY"
        Me.GridColumn47.Name = "GridColumn47"
        Me.GridColumn47.Width = 92
        '
        'GridColumn48
        '
        Me.GridColumn48.Caption = "3. Satış Fiyatı"
        Me.GridColumn48.DisplayFormat.FormatString = "#,0.00#"
        Me.GridColumn48.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn48.FieldName = "ONAY"
        Me.GridColumn48.Name = "GridColumn48"
        Me.GridColumn48.Width = 102
        '
        'GridColumn49
        '
        Me.GridColumn49.Caption = "KisaAdi"
        Me.GridColumn49.FieldName = "sKisaAdi"
        Me.GridColumn49.Name = "GridColumn49"
        Me.GridColumn49.Width = 64
        '
        'GridColumn52
        '
        Me.GridColumn52.Caption = "4. Satış Fiyatı"
        Me.GridColumn52.DisplayFormat.FormatString = "#,0.00#"
        Me.GridColumn52.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn52.FieldName = "FIYAT4"
        Me.GridColumn52.Name = "GridColumn52"
        '
        'GridColumn53
        '
        Me.GridColumn53.Caption = "Birim"
        Me.GridColumn53.FieldName = "sBirimCinsi1"
        Me.GridColumn53.Name = "GridColumn53"
        Me.GridColumn53.Width = 54
        '
        'GridColumn54
        '
        Me.GridColumn54.Caption = "Koli İçi"
        Me.GridColumn54.DisplayFormat.FormatString = "#,0.##"
        Me.GridColumn54.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn54.FieldName = "nBirimCarpan"
        Me.GridColumn54.Name = "GridColumn54"
        Me.GridColumn54.Width = 54
        '
        'GridColumn55
        '
        Me.GridColumn55.Caption = "Özel Not"
        Me.GridColumn55.FieldName = "sOzelNot"
        Me.GridColumn55.Name = "GridColumn55"
        '
        'GridColumn56
        '
        Me.GridColumn56.Caption = "Kavala"
        Me.GridColumn56.FieldName = "sKavala"
        Me.GridColumn56.Name = "GridColumn56"
        '
        'GridColumn58
        '
        Me.GridColumn58.Caption = "Bekleyen"
        Me.GridColumn58.DisplayFormat.FormatString = "#,#.####"
        Me.GridColumn58.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn58.FieldName = "BEKLEYEN"
        Me.GridColumn58.Name = "GridColumn58"
        Me.GridColumn58.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BEKLEYEN", "{0:#,0.####}")})
        '
        'GridColumn59
        '
        Me.GridColumn59.Caption = "AS"
        Me.GridColumn59.DisplayFormat.FormatString = "#,#.####"
        Me.GridColumn59.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn59.FieldName = "AlinanSiparis"
        Me.GridColumn59.Name = "GridColumn59"
        Me.GridColumn59.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AlinanSiparis", "{0:#,0.####}")})
        '
        'GridColumn60
        '
        Me.GridColumn60.Caption = "VS"
        Me.GridColumn60.DisplayFormat.FormatString = "#,#.####"
        Me.GridColumn60.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn60.FieldName = "VerilenSiparis"
        Me.GridColumn60.Name = "GridColumn60"
        Me.GridColumn60.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VerilenSiparis", "{0:#,0.####}")})
        '
        'GridColumn61
        '
        Me.GridColumn61.Caption = "Hacim"
        Me.GridColumn61.FieldName = "nHacim"
        Me.GridColumn61.Name = "GridColumn61"
        '
        'GridColumn62
        '
        Me.GridColumn62.Caption = "Agirlik"
        Me.GridColumn62.FieldName = "nAgirlik"
        Me.GridColumn62.Name = "GridColumn62"
        '
        'GridColumn63
        '
        Me.GridColumn63.Caption = "Depo1"
        Me.GridColumn63.DisplayFormat.FormatString = "#,0.###"
        Me.GridColumn63.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn63.FieldName = "sDepo1"
        Me.GridColumn63.Name = "GridColumn63"
        Me.GridColumn63.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sDepo1", "{0:#,0.###}")})
        Me.GridColumn63.Width = 54
        '
        'GridColumn64
        '
        Me.GridColumn64.Caption = "Depo2"
        Me.GridColumn64.DisplayFormat.FormatString = "#,0.###"
        Me.GridColumn64.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn64.FieldName = "sDepo2"
        Me.GridColumn64.Name = "GridColumn64"
        Me.GridColumn64.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sDepo2", "{0:#,0.###}")})
        Me.GridColumn64.Width = 54
        '
        'GridColumn65
        '
        Me.GridColumn65.Caption = "Depo3"
        Me.GridColumn65.DisplayFormat.FormatString = "#,0.###"
        Me.GridColumn65.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn65.FieldName = "sDepo3"
        Me.GridColumn65.Name = "GridColumn65"
        Me.GridColumn65.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sDepo3", "{0:#,0.###}")})
        Me.GridColumn65.Width = 54
        '
        'GridColumn66
        '
        Me.GridColumn66.Caption = "Depo4"
        Me.GridColumn66.DisplayFormat.FormatString = "#,0.###"
        Me.GridColumn66.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn66.FieldName = "sDepo4"
        Me.GridColumn66.Name = "GridColumn66"
        Me.GridColumn66.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sDepo4", "{0:#,0.###}")})
        Me.GridColumn66.Width = 54
        '
        'GridColumn67
        '
        Me.GridColumn67.Caption = "Depo5"
        Me.GridColumn67.DisplayFormat.FormatString = "#,0.###"
        Me.GridColumn67.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn67.FieldName = "sDepo5"
        Me.GridColumn67.Name = "GridColumn67"
        Me.GridColumn67.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sDepo5", "{0:#,0.###}")})
        Me.GridColumn67.Width = 71
        '
        'GridColumn68
        '
        Me.GridColumn68.Caption = "Mevcut2"
        Me.GridColumn68.DisplayFormat.FormatString = "#,0.###"
        Me.GridColumn68.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn68.FieldName = "Mevcut2"
        Me.GridColumn68.Name = "GridColumn68"
        Me.GridColumn68.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Mevcut2", "{0:#,0.###}")})
        Me.GridColumn68.Width = 54
        '
        'GridColumn69
        '
        Me.GridColumn69.Caption = "Birim2"
        Me.GridColumn69.FieldName = "sBirimCinsi2"
        Me.GridColumn69.Name = "GridColumn69"
        '
        'GridColumn70
        '
        Me.GridColumn70.Caption = "FiyatTespit"
        Me.GridColumn70.FieldName = "dteFiyatTespitTarihi"
        Me.GridColumn70.Name = "GridColumn70"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl1.Location = New System.Drawing.Point(0, 214)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(147, 20)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Çapraz Stok Listesi"
        '
        'GridControl4
        '
        Me.GridControl4.DataMember = "Table1"
        Me.GridControl4.DataSource = Me.DataSet1
        Me.GridControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridControl4.Location = New System.Drawing.Point(0, 20)
        Me.GridControl4.MainView = Me.GridView3
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.GridControl4.Size = New System.Drawing.Size(227, 194)
        Me.GridControl4.TabIndex = 5
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
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
        Me.GridView3.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView3.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView3.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27, Me.GridColumn28, Me.GridColumn29, Me.GridColumn30, Me.GridColumn31, Me.GridColumn32, Me.GridColumn33, Me.GridColumn34, Me.GridColumn35, Me.GridColumn36, Me.GridColumn37})
        Me.GridView3.CustomizationFormBounds = New System.Drawing.Rectangle(617, 339, 208, 156)
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition11.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition11.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition11.Appearance.Options.UseFont = True
        StyleFormatCondition11.Appearance.Options.UseForeColor = True
        StyleFormatCondition11.Column = Me.GridColumn12
        StyleFormatCondition11.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition11.Value1 = "0"
        StyleFormatCondition12.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition12.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition12.Appearance.Options.UseFont = True
        StyleFormatCondition12.Appearance.Options.UseForeColor = True
        StyleFormatCondition12.Column = Me.GridColumn12
        StyleFormatCondition12.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition12.Value1 = "0"
        StyleFormatCondition13.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition13.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition13.Appearance.Options.UseBackColor = True
        StyleFormatCondition13.Appearance.Options.UseForeColor = True
        StyleFormatCondition13.ApplyToRow = True
        StyleFormatCondition13.Column = Me.GridColumn17
        StyleFormatCondition13.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition13.Value1 = "0"
        StyleFormatCondition14.Appearance.ForeColor = System.Drawing.Color.Silver
        StyleFormatCondition14.Appearance.Options.UseForeColor = True
        StyleFormatCondition14.ApplyToRow = True
        StyleFormatCondition14.Column = Me.GridColumn18
        StyleFormatCondition14.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition14.Value1 = "5"
        StyleFormatCondition15.Appearance.ForeColor = System.Drawing.Color.Purple
        StyleFormatCondition15.Appearance.Options.UseForeColor = True
        StyleFormatCondition15.ApplyToRow = True
        StyleFormatCondition15.Column = Me.GridColumn24
        StyleFormatCondition15.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition15.Expression = "1"
        StyleFormatCondition15.Value1 = "1"
        Me.GridView3.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition11, StyleFormatCondition12, StyleFormatCondition13, StyleFormatCondition14, StyleFormatCondition15})
        Me.GridView3.GridControl = Me.GridControl4
        Me.GridView3.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsNavigation.UseTabKey = False
        Me.GridView3.OptionsSelection.MultiSelect = True
        Me.GridView3.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Kayıt No"
        Me.GridColumn5.FieldName = "nStokID"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "nStokID", "{0} Kayıt")})
        Me.GridColumn5.Width = 72
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Kod"
        Me.GridColumn6.FieldName = "sKodu"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", "{0} Kayıt")})
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 279
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Açıklama"
        Me.GridColumn7.FieldName = "sAciklama"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        Me.GridColumn7.Width = 472
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Renk"
        Me.GridColumn8.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn8.FieldName = "sRenk"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Width = 82
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sRenkAdi", "Renk")})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "sRenkAdi"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.RepositoryItemLookUpEdit1.ShowFooter = False
        Me.RepositoryItemLookUpEdit1.ShowHeader = False
        Me.RepositoryItemLookUpEdit1.ShowLines = False
        Me.RepositoryItemLookUpEdit1.ValueMember = "sRenk"
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Beden"
        Me.GridColumn9.FieldName = "sBeden"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Width = 82
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "ModelNo"
        Me.GridColumn10.FieldName = "sModel"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Width = 109
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Barkod"
        Me.GridColumn11.FieldName = "sBarkod"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Width = 154
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Fiyat"
        Me.GridColumn13.DisplayFormat.FormatString = "#,0.00#"
        Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn13.FieldName = "PESIN"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 3
        Me.GridColumn13.Width = 303
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "2. Satış Fiyatı"
        Me.GridColumn14.DisplayFormat.FormatString = "#,0.00#"
        Me.GridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn14.FieldName = "ALTIAY"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Width = 92
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "3. Satış Fiyatı"
        Me.GridColumn15.DisplayFormat.FormatString = "#,0.00#"
        Me.GridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn15.FieldName = "ONAY"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Width = 102
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "KisaAdi"
        Me.GridColumn16.FieldName = "sKisaAdi"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Width = 64
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "4. Satış Fiyatı"
        Me.GridColumn19.DisplayFormat.FormatString = "#,0.00#"
        Me.GridColumn19.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn19.FieldName = "FIYAT4"
        Me.GridColumn19.Name = "GridColumn19"
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Birim"
        Me.GridColumn20.FieldName = "sBirimCinsi1"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.Width = 54
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Koli İçi"
        Me.GridColumn21.DisplayFormat.FormatString = "#,0.##"
        Me.GridColumn21.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn21.FieldName = "nBirimCarpan"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Width = 54
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Özel Not"
        Me.GridColumn22.FieldName = "sOzelNot"
        Me.GridColumn22.Name = "GridColumn22"
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Kavala"
        Me.GridColumn23.FieldName = "sKavala"
        Me.GridColumn23.Name = "GridColumn23"
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "Bekleyen"
        Me.GridColumn25.DisplayFormat.FormatString = "#,#.####"
        Me.GridColumn25.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn25.FieldName = "BEKLEYEN"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BEKLEYEN", "{0:#,0.####}")})
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "AS"
        Me.GridColumn26.DisplayFormat.FormatString = "#,#.####"
        Me.GridColumn26.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn26.FieldName = "AlinanSiparis"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AlinanSiparis", "{0:#,0.####}")})
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "VS"
        Me.GridColumn27.DisplayFormat.FormatString = "#,#.####"
        Me.GridColumn27.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn27.FieldName = "VerilenSiparis"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VerilenSiparis", "{0:#,0.####}")})
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "Hacim"
        Me.GridColumn28.FieldName = "nHacim"
        Me.GridColumn28.Name = "GridColumn28"
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "Agirlik"
        Me.GridColumn29.FieldName = "nAgirlik"
        Me.GridColumn29.Name = "GridColumn29"
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "Depo1"
        Me.GridColumn30.DisplayFormat.FormatString = "#,0.###"
        Me.GridColumn30.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn30.FieldName = "sDepo1"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sDepo1", "{0:#,0.###}")})
        Me.GridColumn30.Width = 54
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "Depo2"
        Me.GridColumn31.DisplayFormat.FormatString = "#,0.###"
        Me.GridColumn31.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn31.FieldName = "sDepo2"
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sDepo2", "{0:#,0.###}")})
        Me.GridColumn31.Width = 54
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "Depo3"
        Me.GridColumn32.DisplayFormat.FormatString = "#,0.###"
        Me.GridColumn32.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn32.FieldName = "sDepo3"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sDepo3", "{0:#,0.###}")})
        Me.GridColumn32.Width = 54
        '
        'GridColumn33
        '
        Me.GridColumn33.Caption = "Depo4"
        Me.GridColumn33.DisplayFormat.FormatString = "#,0.###"
        Me.GridColumn33.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn33.FieldName = "sDepo4"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sDepo4", "{0:#,0.###}")})
        Me.GridColumn33.Width = 54
        '
        'GridColumn34
        '
        Me.GridColumn34.Caption = "Depo5"
        Me.GridColumn34.DisplayFormat.FormatString = "#,0.###"
        Me.GridColumn34.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn34.FieldName = "sDepo5"
        Me.GridColumn34.Name = "GridColumn34"
        Me.GridColumn34.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "sDepo5", "{0:#,0.###}")})
        Me.GridColumn34.Width = 71
        '
        'GridColumn35
        '
        Me.GridColumn35.Caption = "Mevcut2"
        Me.GridColumn35.DisplayFormat.FormatString = "#,0.###"
        Me.GridColumn35.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn35.FieldName = "Mevcut2"
        Me.GridColumn35.Name = "GridColumn35"
        Me.GridColumn35.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Mevcut2", "{0:#,0.###}")})
        Me.GridColumn35.Width = 54
        '
        'GridColumn36
        '
        Me.GridColumn36.Caption = "Birim2"
        Me.GridColumn36.FieldName = "sBirimCinsi2"
        Me.GridColumn36.Name = "GridColumn36"
        '
        'GridColumn37
        '
        Me.GridColumn37.Caption = "FiyatTespit"
        Me.GridColumn37.FieldName = "dteFiyatTespitTarihi"
        Me.GridColumn37.Name = "GridColumn37"
        '
        'lbl_sAlternatifAciklama
        '
        Me.lbl_sAlternatifAciklama.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_sAlternatifAciklama.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_sAlternatifAciklama.Location = New System.Drawing.Point(0, 0)
        Me.lbl_sAlternatifAciklama.Name = "lbl_sAlternatifAciklama"
        Me.lbl_sAlternatifAciklama.Size = New System.Drawing.Size(15, 20)
        Me.lbl_sAlternatifAciklama.TabIndex = 4
        Me.lbl_sAlternatifAciklama.Text = "%"
        '
        'dPanelEnvanter
        '
        Me.dPanelEnvanter.Controls.Add(Me.ControlContainer4)
        Me.dPanelEnvanter.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.dPanelEnvanter.ID = New System.Guid("61b02fc2-f71b-47ff-a03c-074afc134222")
        Me.dPanelEnvanter.Location = New System.Drawing.Point(589, 0)
        Me.dPanelEnvanter.Name = "dPanelEnvanter"
        Me.dPanelEnvanter.OriginalSize = New System.Drawing.Size(235, 200)
        Me.dPanelEnvanter.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.dPanelEnvanter.SavedIndex = 0
        Me.dPanelEnvanter.SavedParent = Me.dPanelTanım
        Me.dPanelEnvanter.SavedTabbed = True
        Me.dPanelEnvanter.Size = New System.Drawing.Size(235, 406)
        Me.dPanelEnvanter.Text = "Envanter"
        Me.dPanelEnvanter.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        '
        'ControlContainer4
        '
        Me.ControlContainer4.Controls.Add(Me.GridControl3)
        Me.ControlContainer4.Controls.Add(Me.lbl_sEnvanterAciklama)
        Me.ControlContainer4.Location = New System.Drawing.Point(4, 23)
        Me.ControlContainer4.Name = "ControlContainer4"
        Me.ControlContainer4.Size = New System.Drawing.Size(227, 379)
        Me.ControlContainer4.TabIndex = 0
        '
        'GridControl3
        '
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(0, 20)
        Me.GridControl3.MainView = Me.GridView4
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(227, 359)
        Me.GridControl3.TabIndex = 3
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Appearance.FocusedCell.BackColor = System.Drawing.Color.Turquoise
        Me.GridView4.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView4.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView4.Appearance.FocusedRow.BackColor = System.Drawing.Color.Turquoise
        Me.GridView4.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView4.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView4.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Turquoise
        Me.GridView4.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView4.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colGIREN, Me.colCIKAN, Me.colKALAN, Me.GridColumn2, Me.GridColumn3})
        Me.GridView4.CustomizationFormBounds = New System.Drawing.Rectangle(806, 484, 208, 170)
        Me.GridView4.DetailHeight = 160
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.GridControl = Me.GridControl3
        Me.GridView4.GroupFormat = "{0}: {1} {2}"
        Me.GridView4.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView4.IndicatorWidth = 12
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsCustomization.AllowFilter = False
        Me.GridView4.OptionsCustomization.AllowGroup = False
        Me.GridView4.OptionsDetail.ShowDetailTabs = False
        Me.GridView4.OptionsView.ShowFooter = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Depo"
        Me.GridColumn1.FieldName = "sAciklama"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sAciklama", "{0} Kayıt")})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 120
        '
        'colGIREN
        '
        Me.colGIREN.Caption = "Giren"
        Me.colGIREN.DisplayFormat.FormatString = "#,0.####"
        Me.colGIREN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGIREN.FieldName = "GIREN"
        Me.colGIREN.Name = "colGIREN"
        Me.colGIREN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GIREN", "{0:#,0.####}")})
        Me.colGIREN.Width = 74
        '
        'colCIKAN
        '
        Me.colCIKAN.Caption = "Çıkan"
        Me.colCIKAN.DisplayFormat.FormatString = "#,0.####"
        Me.colCIKAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCIKAN.FieldName = "CIKAN"
        Me.colCIKAN.Name = "colCIKAN"
        Me.colCIKAN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CIKAN", "{0:#,0.####}")})
        Me.colCIKAN.Width = 72
        '
        'colKALAN
        '
        Me.colKALAN.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colKALAN.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colKALAN.AppearanceCell.Options.UseFont = True
        Me.colKALAN.AppearanceCell.Options.UseForeColor = True
        Me.colKALAN.Caption = "Mevcut"
        Me.colKALAN.DisplayFormat.FormatString = "#,#.##"
        Me.colKALAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKALAN.FieldName = "KALAN"
        Me.colKALAN.Name = "colKALAN"
        Me.colKALAN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KALAN", "{0:#,0.####}")})
        Me.colKALAN.Visible = True
        Me.colKALAN.VisibleIndex = 1
        Me.colKALAN.Width = 72
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Mevcut"
        Me.GridColumn2.DisplayFormat.FormatString = "#,0.####"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "MEVCUT"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Width = 93
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn3.AppearanceCell.ForeColor = System.Drawing.Color.Navy
        Me.GridColumn3.AppearanceCell.Options.UseFont = True
        Me.GridColumn3.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn3.Caption = "Bekleyen"
        Me.GridColumn3.CustomizationCaption = "Bekleyen"
        Me.GridColumn3.DisplayFormat.FormatString = "#,#.##"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "BEKLEYEN"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BEKLEYEN", "{0:#,0.##}")})
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 80
        '
        'lbl_sEnvanterAciklama
        '
        Me.lbl_sEnvanterAciklama.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_sEnvanterAciklama.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_sEnvanterAciklama.Location = New System.Drawing.Point(0, 0)
        Me.lbl_sEnvanterAciklama.Name = "lbl_sEnvanterAciklama"
        Me.lbl_sEnvanterAciklama.Size = New System.Drawing.Size(15, 20)
        Me.lbl_sEnvanterAciklama.TabIndex = 2
        Me.lbl_sEnvanterAciklama.Text = "%"
        '
        'dPanelSiniflandirma
        '
        Me.dPanelSiniflandirma.Controls.Add(Me.DockPanel1_Container)
        Me.dPanelSiniflandirma.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.dPanelSiniflandirma.ID = New System.Guid("efbeb2bf-87af-43f9-8752-cace4f7faa11")
        Me.dPanelSiniflandirma.Location = New System.Drawing.Point(4, 23)
        Me.dPanelSiniflandirma.Name = "dPanelSiniflandirma"
        Me.dPanelSiniflandirma.OriginalSize = New System.Drawing.Size(227, 350)
        Me.dPanelSiniflandirma.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.dPanelSiniflandirma.SavedIndex = 1
        Me.dPanelSiniflandirma.SavedParent = Me.dPanelTanım
        Me.dPanelSiniflandirma.SavedTabbed = True
        Me.dPanelSiniflandirma.Size = New System.Drawing.Size(219, 352)
        Me.dPanelSiniflandirma.Text = "Sınıflandırma"
        Me.dPanelSiniflandirma.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.GridControl2)
        Me.DockPanel1_Container.Controls.Add(Me.lbl_sSiniflandirmaAciklama)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(219, 352)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "Table1"
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 20)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sSinifKodu, Me.sec_Siniflar})
        Me.GridControl2.Size = New System.Drawing.Size(219, 332)
        Me.GridControl2.TabIndex = 5
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnMusteriID, Me.colsSinifTipi, Me.colsSinifKodu, Me.GridColumn4, Me.colbSatisYapilamaz})
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
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
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colnMusteriID
        '
        Me.colnMusteriID.Caption = "Müşteri ID"
        Me.colnMusteriID.FieldName = "nMusteriID"
        Me.colnMusteriID.Name = "colnMusteriID"
        Me.colnMusteriID.OptionsColumn.AllowEdit = False
        Me.colnMusteriID.OptionsColumn.AllowFocus = False
        '
        'colsSinifTipi
        '
        Me.colsSinifTipi.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.colsSinifTipi.AppearanceCell.Options.UseFont = True
        Me.colsSinifTipi.Caption = "Sınıf Tipi"
        Me.colsSinifTipi.FieldName = "sSinifTipi"
        Me.colsSinifTipi.Name = "colsSinifTipi"
        Me.colsSinifTipi.OptionsColumn.AllowEdit = False
        Me.colsSinifTipi.OptionsColumn.AllowFocus = False
        Me.colsSinifTipi.Visible = True
        Me.colsSinifTipi.VisibleIndex = 0
        '
        'colsSinifKodu
        '
        Me.colsSinifKodu.Caption = "Sınıf"
        Me.colsSinifKodu.ColumnEdit = Me.sec_Siniflar
        Me.colsSinifKodu.FieldName = "sSinifKodu"
        Me.colsSinifKodu.Name = "colsSinifKodu"
        Me.colsSinifKodu.OptionsColumn.AllowEdit = False
        Me.colsSinifKodu.Visible = True
        Me.colsSinifKodu.VisibleIndex = 1
        '
        'sec_Siniflar
        '
        Me.sec_Siniflar.AutoHeight = False
        Me.sec_Siniflar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_Siniflar.DisplayMember = "sSinifKodu"
        Me.sec_Siniflar.Name = "sec_Siniflar"
        Me.sec_Siniflar.NullText = ""
        Me.sec_Siniflar.ValueMember = "sSinifKodu"
        Me.sec_Siniflar.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsBehavior.Editable = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.EnableAppearanceEvenRow = True
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowIndicator = False
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GridColumn4.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.GridColumn4.AppearanceCell.Options.UseFont = True
        Me.GridColumn4.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn4.Caption = "Açıklama"
        Me.GridColumn4.FieldName = "sAciklama"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.AllowFocus = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'colbSatisYapilamaz
        '
        Me.colbSatisYapilamaz.Caption = "Satış Yapılamaz"
        Me.colbSatisYapilamaz.FieldName = "bSatisYapilamaz"
        Me.colbSatisYapilamaz.Name = "colbSatisYapilamaz"
        Me.colbSatisYapilamaz.OptionsColumn.AllowEdit = False
        Me.colbSatisYapilamaz.OptionsColumn.AllowFocus = False
        '
        'sec_sSinifKodu
        '
        Me.sec_sSinifKodu.AutoHeight = False
        Me.sec_sSinifKodu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinifKodu.DisplayMember = "sSinifKodu"
        Me.sec_sSinifKodu.Name = "sec_sSinifKodu"
        Me.sec_sSinifKodu.NullText = "[Sınıflar]"
        Me.sec_sSinifKodu.ValueMember = "sSinifKodu"
        '
        'lbl_sSiniflandirmaAciklama
        '
        Me.lbl_sSiniflandirmaAciklama.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_sSiniflandirmaAciklama.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_sSiniflandirmaAciklama.Location = New System.Drawing.Point(0, 0)
        Me.lbl_sSiniflandirmaAciklama.Name = "lbl_sSiniflandirmaAciklama"
        Me.lbl_sSiniflandirmaAciklama.Size = New System.Drawing.Size(15, 20)
        Me.lbl_sSiniflandirmaAciklama.TabIndex = 3
        Me.lbl_sSiniflandirmaAciklama.Text = "%"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Model Envanter"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'frm_stok
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 20)
        Me.ClientSize = New System.Drawing.Size(1364, 630)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Kart Listesi"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
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
        CType(Me.chk_Sec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_pResim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dPanelResim.ResumeLayout(False)
        Me.dPanelTanım.ResumeLayout(False)
        Me.ControlContainer5.ResumeLayout(False)
        Me.ControlContainer5.PerformLayout()
        CType(Me.sPicture.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dPanelRecete.ResumeLayout(False)
        Me.dPanelAlternatif.ResumeLayout(False)
        Me.ControlContainer1.ResumeLayout(False)
        Me.ControlContainer1.PerformLayout()
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dPanelEnvanter.ResumeLayout(False)
        Me.ControlContainer4.ResumeLayout(False)
        Me.ControlContainer4.PerformLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dPanelSiniflandirma.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel1_Container.PerformLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_Siniflar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinifKodu, System.ComponentModel.ISupportInitialize).EndInit()
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
    Public depo
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
    Public secenek
    Public alternatif As String = ""
    Public sKdvTipi As String = ""
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
    Public qsecenek
    Public qalternatif As String = "Eşittir"
    Public qsKdvTipi As String = "Başlar"
    Public Uretim As Boolean = False
    Dim dr As DataRow
    Dim count
    Public mevcut
    Public yeni
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    'Dim qr_hareket As New TfrxADOQuery
    Public frf_islem As String = "mektup"
    Public islemstatus As Boolean = False
    Public bFatura As Boolean = False
    Public okut As Boolean = False
    Public sFiyatTipi As String = ""
    ' Çoklu seçim için değişkenler
    Public SeciliStokIDListesi As New List(Of Long)
    ' Filtre değiştiğinde seçimlerin kaybolmaması için HashSet
    Private SeciliStokIDSet As New HashSet(Of Long)
    Public SeciliStokBilgileri As New List(Of Dictionary(Of String, Object))
    Private Sub frm_stok_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("STOK").SetValue("set_dPanelAlternatif", dPanelAlternatif.Visibility)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("STOK").SetValue("set_dPanelEnvanter", dPanelEnvanter.Visibility)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("STOK").SetValue("set_dPanelRecete", dPanelRecete.Visibility)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("STOK").SetValue("set_dPanelResim", dPanelResim.Visibility)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("STOK").SetValue("set_dPanelSiniflandirma", dPanelSiniflandirma.Visibility)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("STOK").SetValue("set_dPanelTanım", dPanelTanım.Visibility)
        'Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("STOK").SetValue("set_dPanelIndex", panelContainer1.ActiveChildIndex)
    End Sub
    Private Sub frm_stok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        colsDepo1.Caption = sDepo1Aciklama
        colsDepo2.Caption = sDepo2Aciklama
        colsDepo3.Caption = sDepo3Aciklama
        colsDepo4.Caption = sDepo4Aciklama
        colsDepo5.Caption = sDepo5Aciklama
        colsDepo6.Caption = sDepo6Aciklama
        colPESIN.Caption = sFiyat1Aciklama
        colALTIAY.Caption = sFiyat2Aciklama
        colONAY.Caption = sFiyat3Aciklama
        colsFIYAT4.Caption = sFiyat4Aciklama
        colFIYAT5.Caption = sFiyat5Aciklama
        colSINIF1.Caption = sStokSinifTipi1
        colSINIF1.Caption = sStokSinifTipi1
        colSINIF2.Caption = sStokSinifTipi2
        colSINIF3.Caption = sStokSinifTipi3
        colSINIF4.Caption = sStokSinifTipi4
        colSINIF5.Caption = sStokSinifTipi5
        colSINIF6.Caption = sStokSinifTipi6
        colSINIF7.Caption = sStokSinifTipi7
        colSINIF8.Caption = sStokSinifTipi8
        colSINIF9.Caption = sStokSinifTipi9
        colSINIF10.Caption = sStokSinifTipi10
        Me.Hide()
        If status = False Then
            count = ""
            Dim frm As New frm_stok_ara
            frm.connection = connection
            frm.firmano = firmano
            frm.donemno = donemno
            frm.rowKRITER.Visible = True
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
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
                secenek = frm.secenek
                depo = frm.depo
                sKdvTipi = frm.sKdvTipi
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
                mevcut = frm.mevcut
                yeni = frm.yeni
                qgelismis = frm.qgelismis
                qsecenek = frm.qsecenek
                qdepo = frm.qdepo
                qsKdvTipi = frm.qsKdvTipi
                Me.Show()
                frm.stokkodu = Nothing
                frm.malincinsi = Nothing
                frm.barkod = Nothing
                frm.muadilbarkod = Nothing
                frm.birim = Nothing
                frm.depo = Nothing
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
                frm.sKdvTipi = Nothing
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
                frm.qsKdvTipi = Nothing
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
                frm = Nothing
                dataload()
                Cursor.Current = Cursors.Default
                Cursor.Hide()
            Else
                frm.stokkodu = Nothing
                frm.malincinsi = Nothing
                frm.barkod = Nothing
                frm.muadilbarkod = Nothing
                frm.birim = Nothing
                frm.depo = Nothing
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
                frm.sKdvTipi = Nothing
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
                frm.qsKdvTipi = Nothing
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
                frm = Nothing
                Me.Close()
            End If
        Else
            count = "TOP 1000"
            dataload()
        End If
        Try
            If GridView1.RowCount = 0 Then
            ElseIf GridView1.RowCount = 1 Then
                If islemstatus = True Then
                    If sil = False Then
                        sorgula(True)
                    End If
                End If
            Else
            End If
        Catch ex As Exception
        End Try
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
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
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "")
        Try
            If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STOK").GetValue("set_dPanelAlternatif") = "Visible" Then
                dPanelAlternatif.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            Else
                dPanelAlternatif.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            End If
        Catch ex As Exception
            dPanelAlternatif.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        End Try
        Try
            If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STOK").GetValue("set_dPanelEnvanter") = "Visible" Then
                dPanelEnvanter.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            Else
                dPanelEnvanter.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            End If
        Catch ex As Exception
            dPanelEnvanter.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        End Try
        Try
            If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STOK").GetValue("set_dPanelRecete") = "Visible" Then
                dPanelRecete.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            Else
                dPanelRecete.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            End If
        Catch ex As Exception
            dPanelRecete.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        End Try
        Try
            If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STOK").GetValue("set_dPanelResim") = "Visible" Then
                dPanelResim.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            Else
                dPanelResim.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            End If
        Catch ex As Exception
            dPanelResim.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        End Try
        Try
            If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STOK").GetValue("set_dPanelSiniflandirma") = "Visible" Then
                dPanelSiniflandirma.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            Else
                dPanelSiniflandirma.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            End If

        Catch ex As Exception
            dPanelSiniflandirma.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        End Try
        Try
            If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STOK").GetValue("set_dPanelTanım") = "Visible" Then
                dPanelTanım.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            Else
                dPanelTanım.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            End If
        Catch ex As Exception
            dPanelTanım.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        End Try
        'Try
        '    panelContainer1.ActiveChildIndex = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STOK").GetValue("set_dPanelIndex")
        'Catch ex As Exception
        '    panelContainer1.ActiveChildIndex = 0
        'End Try
    End Sub
    'Private Sub gorunum_yukle()
    '    For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
    '        btn.Caption = Sorgu_sDil(btn.Caption, sDil)
    '    Next
    '    Try
    '    Catch ex As Exception
    '    End Try
    '    Try
    '        If nFontSize > 0 Then
    '            Dim sayi As Single = nFontSize
    '            GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
    '            GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
    '            GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
    '            'VGrid_Baslik.Appearance.RecordValue.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
    '            sayi = Nothing
    '        End If
    '    Catch ex As Exception
    '    End Try
    '    For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
    '        clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
    '    Next
    '    Dim tab As Object
    '    For Each tab In XtraTabControl1.TabPages
    '        tab.text = Sorgu_sDil(tab.text, sDil)
    '    Next
    '    Dim itm
    '    For Each itm In ContextMenu1.MenuItems
    '        itm.text = Sorgu_sDil(itm.text, sDil)
    '    Next
    '    SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
    '    SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
    '    GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "")
    '    Try
    '        If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STOK").GetValue("set_dPanelAlternatif") = "Visible" Then
    '            dPanelAlternatif.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
    '        Else
    '            dPanelAlternatif.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
    '        End If
    '    Catch ex As Exception
    '        dPanelAlternatif.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
    '    End Try
    '    Try
    '        If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STOK").GetValue("set_dPanelEnvanter") = "Visible" Then
    '            dPanelEnvanter.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
    '        Else
    '            dPanelEnvanter.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
    '        End If
    '    Catch ex As Exception
    '        dPanelEnvanter.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
    '    End Try
    '    Try
    '        If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STOK").GetValue("set_dPanelRecete") = "Visible" Then
    '            dPanelRecete.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
    '        Else
    '            dPanelRecete.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
    '        End If
    '    Catch ex As Exception
    '        dPanelRecete.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
    '    End Try
    '    Try
    '        If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STOK").GetValue("set_dPanelResim") = "Visible" Then
    '            dPanelResim.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
    '        Else
    '            dPanelResim.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
    '        End If
    '    Catch ex As Exception
    '        dPanelResim.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
    '    End Try
    '    Try
    '        If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STOK").GetValue("set_dPanelSiniflandirma") = "Visible" Then
    '            dPanelSiniflandirma.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
    '        Else
    '            dPanelSiniflandirma.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
    '        End If
    '    Catch ex As Exception
    '        dPanelSiniflandirma.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
    '    End Try
    '    Try
    '        If Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STOK").GetValue("set_dPanelTanım") = "Visible" Then
    '            dPanelTanım.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
    '        Else
    '            dPanelTanım.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
    '        End If
    '    Catch ex As Exception
    '        dPanelTanım.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
    '    End Try
    '    ''Try
    '    ''    panelContainer1.ActiveChildIndex = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STOK").GetValue("set_dPanelIndex")
    '    ''Catch ex As Exception
    '    ''    panelContainer1.ActiveChildIndex = 0
    '    ''End Try
    '    'Dim colSecim As New DevExpress.XtraGrid.Columns.GridColumn()
    '    'colSecim.Caption = "Seç"
    '    'colSecim.FieldName = "Sec"
    '    'colSecim.Visible = True
    '    'colSecim.VisibleIndex = 0
    '    'colSecim.OptionsColumn.AllowEdit = True
    '    'colSecim.OptionsColumn.ReadOnly = False

    '    'Dim chkEdit As New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
    '    'GridControl1.RepositoryItems.Add(chkEdit)
    '    'colSecim.ColumnEdit = chkEdit

    '    '' Kolon daha önce eklenmemişse ekle
    '    'If GridView1.Columns.ColumnByFieldName("Sec") Is Nothing Then
    '    '    GridView1.Columns.Insert(0, colSecim)
    '    'End If

    '    '' Grid düzenlemeye izin ver
    '    'GridView1.OptionsBehavior.Editable = True

    '    '' Veri kaynağına "Sec" kolonunu ekle
    '    'Dim dt As DataTable = TryCast(GridControl1.DataSource, DataTable)
    '    'If dt IsNot Nothing AndAlso Not dt.Columns.Contains("Sec") Then
    '    '    dt.Columns.Add("Sec", GetType(Boolean))
    '    'End If
    '    'With GridView1
    '    '    .OptionsSelection.MultiSelect = True
    '    '    .OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
    '    'End With
    'End Sub
    Private Sub dataload_depo()
        sec_renk.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbRenk")).Tables(0) 'DataSet2.Tables(0)
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
    Private Sub ara()
        Dim frm As New frm_stok_ara
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.rowKRITER.Visible = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
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
            secenek = frm.secenek
            depo = frm.depo
            sKdvTipi = frm.sKdvTipi
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
            qsecenek = frm.qsecenek
            qdepo = frm.qdepo
            qsKdvTipi = frm.qsKdvTipi
            mevcut = frm.mevcut
            yeni = frm.yeni
            dataload()
            Cursor.Current = Cursors.Default
            Cursor.Hide()
        End If
        frm.stokkodu = Nothing
        frm.malincinsi = Nothing
        frm.barkod = Nothing
        frm.muadilbarkod = Nothing
        frm.birim = Nothing
        frm.depo = Nothing
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
        frm.sKdvTipi = Nothing
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
        frm.qsKdvTipi = Nothing
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
        frm = Nothing
    End Sub
    Private Sub sorgula(Optional ByVal bLoad As Boolean = False)
        If GridView1.RowCount > 0 Then
            Dim seciliUrunler As New List(Of DataRow)
            SeciliStokIDListesi.Clear()
            SeciliStokBilgileri.Clear()
            
            ' 1. ÖNCE Ctrl/Shift ile seçilen satırları kontrol et (GetSelectedRows)
            Dim selectedRows As Integer() = GridView1.GetSelectedRows()
            If selectedRows IsNot Nothing AndAlso selectedRows.Length > 0 Then
                For Each rowHandle As Integer In selectedRows
                    If rowHandle >= 0 Then
                        Dim dr As DataRow = GridView1.GetDataRow(rowHandle)
                        If dr IsNot Nothing AndAlso Not seciliUrunler.Contains(dr) Then
                            seciliUrunler.Add(dr)
                            ' StokID'yi HashSet'e de ekle
                            If dr.Table.Columns.Contains("nStokID") AndAlso dr("nStokID") IsNot DBNull.Value Then
                                SeciliStokIDSet.Add(Convert.ToInt64(dr("nStokID")))
                            End If
                        End If
                    End If
                Next
            ElseIf GridView1.FocusedRowHandle >= 0 Then
                ' Hiç seçim yoksa odaklı satırı seç (Enter ile tek satır seçimi)
                GridView1.SelectRow(GridView1.FocusedRowHandle)
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                If dr IsNot Nothing Then
                    seciliUrunler.Add(dr)
                    If dr.Table.Columns.Contains("nStokID") AndAlso dr("nStokID") IsNot DBNull.Value Then
                        SeciliStokIDSet.Add(Convert.ToInt64(dr("nStokID")))
                    End If
                End If
            End If
            
            ' 2. SONRA Checkbox seçili satırları al ve SelectRow ile işaretle
            For i As Integer = 0 To GridView1.RowCount - 1
                Dim isChecked As Boolean = False

                If GridView1.Columns.ColumnByFieldName("Sec") IsNot Nothing Then
                    Try
                        isChecked = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Sec"))
                    Catch ex As Exception
                        isChecked = False
                    End Try
                End If

                If isChecked Then
                    Dim dr As DataRow = GridView1.GetDataRow(i)
                    If dr IsNot Nothing AndAlso Not seciliUrunler.Contains(dr) Then
                        seciliUrunler.Add(dr)
                        ' StokID'yi HashSet'e de ekle
                        If dr.Table.Columns.Contains("nStokID") AndAlso dr("nStokID") IsNot DBNull.Value Then
                            SeciliStokIDSet.Add(Convert.ToInt64(dr("nStokID")))
                        End If
                        ' Satırı SelectRow ile işaretle (GetSelectedRows için)
                        GridView1.SelectRow(i)
                    End If
                End If
            Next

            ' 3. HashSet'teki seçimleri de ekle
            SeciliStokIDListesi.AddRange(SeciliStokIDSet)

            ' 4. Eğer hiç seçim yapılmadıysa, odaklı satırı ekle
            If seciliUrunler.Count = 0 AndAlso GridView1.FocusedRowHandle >= 0 Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                If dr IsNot Nothing Then seciliUrunler.Add(dr)
            End If

            ' Önce TÜM filtreleri kaldır (görünmeyen satırları da seçebilmek için)
            GridView1.ClearColumnsFilter()
            GridView1.ActiveFilterString = ""
            Application.DoEvents() ' Grid'in güncellenmesini bekle
            
            ' HashSet'teki TÜM seçimleri DataTable'dan bul ve ekle
            Dim dt As DataTable = TryCast(GridControl1.DataSource, DataTable)
            If dt IsNot Nothing Then
                ' Önce tüm satır seçimlerini temizle
                GridView1.ClearSelection()
                
                For Each nStokID As Long In SeciliStokIDSet
                    Try
                        ' DataTable'da bu StokID'yi bul
                        Dim foundRows() As DataRow = dt.Select("nStokID = " & nStokID)
                        If foundRows.Length > 0 Then
                            Dim drSecili As DataRow = foundRows(0)
                            
                            ' StokID'yi listeye ekle
                            SeciliStokIDListesi.Add(nStokID)
                            
                            ' Stok bilgilerini dictionary'e ekle
                            Dim stokBilgi As New Dictionary(Of String, Object)
                            For Each col As DataColumn In drSecili.Table.Columns
                                stokBilgi(col.ColumnName) = drSecili(col.ColumnName)
                            Next
                            SeciliStokBilgileri.Add(stokBilgi)
                        End If
                    Catch ex As Exception
                        ' Hata durumunda devam et
                    End Try
                Next
                
                ' Grid'i yenile ve satırları seç
                GridView1.RefreshData()
                Application.DoEvents()
                
                For i As Integer = 0 To GridView1.RowCount - 1
                    Dim dr As DataRow = GridView1.GetDataRow(i)
                    If dr IsNot Nothing AndAlso dr.Table.Columns.Contains("nStokID") AndAlso dr("nStokID") IsNot DBNull.Value Then
                        Dim nStokID As Long = Convert.ToInt64(dr("nStokID"))
                        If SeciliStokIDSet.Contains(nStokID) Then
                            GridView1.SelectRow(i)
                        End If
                    End If
                Next
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If

        System.GC.Collect()
        System.GC.GetTotalMemory(True)
        System.GC.SuppressFinalize(Me)
    End Sub

    Private Sub dataload()
        dataload_depo()
        DataSet1 = stok()
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing

        ' ✅ Checkbox kolonu ekle
        Dim dt As DataTable = TryCast(GridControl1.DataSource, DataTable)
        If dt IsNot Nothing Then
            If Not dt.Columns.Contains("Sec") Then
                Dim col As New DataColumn("Sec", GetType(Boolean))
                col.DefaultValue = False ' Varsayılan False
                dt.Columns.Add(col)
            End If
        End If

        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub stok_yeni()
        If KayitSiniri_kontrol("tbStok", "", nKayitSinir) = True Then
            Dim frm As New frm_stok_kart_kisa
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.sModel = ""
            frm.nStokID = 0
            frm.sKodu = ""
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    stokkodu = frm.sModel
                    qstokkodu = "Başlar"
                    gelismis = ""
                    qgelismis = "İçerir"
                    dataload()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub tbStok_sil(ByVal nStokID As Int64, ByVal sModel As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokSinifi from tbStok where tbStok.nStokID = tbStokSinifi.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokBarkodu from tbStok where tbStok.nStokID = tbStokBarkodu.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokFiyati from tbStok  where tbStok.nStokID = tbStokFiyati.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokBirimCevrimi from tbStok where tbStok.nStokID = tbStokBirimCevrimi.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokMuhasebeEntegrasyon from tbStok where tbStok.nStokID = tbStokMuhasebeEntegrasyon.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokOdemePlani from tbStok  where tbStok.nStokID = tbStokOdemePlani.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokSayim from tbStok where tbStok.nStokID = tbStokSayim.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokDil from tbStok where tbStok.nStokID = tbStokDil.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokAciklama from tbStok where tbStok.nStokID = tbStokAciklama.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStok where sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokUzunNot where sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbStokResim where sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbStokMuhasebeEntegrasyon where nStokID IN (Select nStokID from tbStok where sModel = N'" & sModel & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(sKodu,0) as sKodu FROM         tbStok WHERE     (nStokID < " & nStokID & " ) ORDER BY sKodu DESC ")
            XtraMessageBox.Show(Sorgu_sDil("Kayıt Başarıyla Silindi...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm,Hareket Görmüş Kaydı Silemezsiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 ROLLBACK TRAN")
            cmd.ExecuteNonQuery()
        End Try
        con.Close()
    End Sub
    Private Function KayitSiniri_kontrol(ByVal tbTable As String, ByVal kriter As String, ByVal nKayitSinir As Integer) As Boolean
        Dim pass As Boolean = False
        If nKayitSinir > 0 Then
            Dim yetki As Int64 = Sorgu_tbKayitSayisi(tbTable, kriter, nKayitSinir)
            If yetki = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Üzgünüm Kısıtlı Kullanım.Maximum Kayıt Sınırını Aşamazsınız...!" & vbCrLf & "Lütfen Yetkili Satıcınızla Görüşün...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                status = True
                pass = False
            ElseIf yetki = 1 Then
                pass = True
            End If
        Else
            pass = True
        End If
        Return pass
    End Function
    Private Function Sorgu_tbKayitSayisi(ByVal tbTable As String, ByVal kriter As String, ByVal nKayitSinir As Integer) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitsayisi As Int64 = 0
        Dim formkayitsayisi As Int64 = 0
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS Kayit FROM         " & tbTable & "  " & kriter & " ")
        formkayitsayisi = cmd.ExecuteScalar
        con.Close()
        If formkayitsayisi >= nKayitSinir Then
            kayitsayisi = 0
        Else
            kayitsayisi = 1
        End If
        Return kayitsayisi
        'kayitsayisi = Nothing
        formkayitsayisi = Nothing
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub stok_duzelt()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokID")
            frm.sKodu = dr("sKodu")
            frm.sModel = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            Dim satir = GridView1.FocusedRowHandle
            dataload()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub stok_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Stokları Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
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
            XtraMessageBox.Show(Sorgu_sDil("İşlem Tamamlandı...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            dataload()
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ara()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        ' Checkbox ile seçilen ürünleri SeciliStokIDSet'e ekle
        For i As Integer = 0 To GridView1.RowCount - 1
            Try
                Dim isChecked As Boolean = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Sec"))
                If isChecked Then
                    Dim dr As DataRow = GridView1.GetDataRow(i)
                    If dr IsNot Nothing AndAlso dr.Table.Columns.Contains("nStokID") AndAlso dr("nStokID") IsNot DBNull.Value Then
                        SeciliStokIDSet.Add(Convert.ToInt64(dr("nStokID")))
                    End If
                    GridView1.SelectRow(i)
                End If
            Catch ex As Exception
                ' Hata durumunda devam et
            End Try
        Next

        sorgula()
    End Sub
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Başlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE N'%" & deger & "' "
        ElseIf kriter = "İçerir" Then
            sorgu_kriter = " LIKE N'%" & deger & "%' "
        ElseIf kriter = "Boş" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklı" Then
            sorgu_kriter = " <> N'" & deger & "' "
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = " >  N'" & deger & "' "
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = " < N'" & deger & "' "
        ElseIf kriter = "Eşittir" Then
            sorgu_kriter = " = N'" & deger & "' "
        End If
        Return sorgu_kriter
    End Function
    Public Function stok(Optional ByVal bAlternatif As Boolean = False, Optional ByVal sAlternatif As String = "") As DataSet
        Dim kriter As String = ""
        Dim kriter2 As String = ""
        Dim kriter_depo As String = ""
        Dim kriter_depo_siparis As String = ""
        kriter = "WHERE (stok.skodu is not null ) "
        If bAlternatif = True Then
            'alternatif = sAlternatif
            If alternatif <> "" Then
                kriter += " AND stok.nStokID IN (Select nStokID from tbStokAlternatif where sModel " & sorgu_kriter_string(alternatif, qalternatif) & ")"
                kriter += " OR stok.sModel IN (SELECT tbStokAlternatif.sModel FROM tbStokAlternatif INNER JOIN tbStok ON tbStokAlternatif.nStokID = tbStok.nStokID WHERE (tbStok.sModel  " & sorgu_kriter_string(alternatif, qalternatif) & "))"
                'kriter += " AND stok.nStokID IN (SELECT DISTINCT tbStok.nStokID FROM tbStokAlternatif INNER JOIN tbStok ON tbStokAlternatif.nStokID = tbStok.nStokID WHERE (tbStok.sModel " & sorgu_kriter_string(alternatif, qalternatif) & ") OR (tbStokAlternatif.sModel " & sorgu_kriter_string(alternatif, qalternatif) & "))"
            End If
        Else
            If stokkodu <> "" Then
                kriter += " AND (stok.skodu " & sorgu_kriter_string(stokkodu, qstokkodu) & ")"
            End If
            If malincinsi <> "" Then
                'kriter += " AND (stok.saciklama " & sorgu_kriter_string(malincinsi, qmalincinsi) & ") or (stok.sOzelNot " & sorgu_kriter_string(malincinsi, qmalincinsi) & ")"
                kriter += " AND (stok.saciklama " & sorgu_kriter_string(malincinsi, qmalincinsi) & ") "
            End If
            If barkod <> "" Then
                'kriter += " AND (barkod.sbarkod " & sorgu_kriter_string(barkod, qbarkod) & ")"
                kriter += " AND stok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(barkod, qbarkod) & ")"
                okut = True
            Else
                okut = False
            End If
            If alternatif <> "" Then
                kriter += " AND stok.nStokID IN (Select nStokID from tbStokAlternatif where sModel " & sorgu_kriter_string(alternatif, qalternatif) & ")"
                kriter += " OR stok.sModel IN (SELECT tbStokAlternatif.sModel FROM tbStokAlternatif INNER JOIN tbStok ON tbStokAlternatif.nStokID = tbStok.nStokID WHERE (tbStok.sModel  " & sorgu_kriter_string(alternatif, qalternatif) & "))"
                'kriter += " AND stok.nStokID IN (SELECT DISTINCT tbStok.nStokID FROM tbStokAlternatif INNER JOIN tbStok ON tbStokAlternatif.nStokID = tbStok.nStokID WHERE (tbStok.sModel " & sorgu_kriter_string(alternatif, qalternatif) & ") OR (tbStokAlternatif.sModel " & sorgu_kriter_string(alternatif, qalternatif) & "))"
            End If
            If kod9 <> "" Then
                kriter += " AND (stok.srenk " & sorgu_kriter_string(kod1, qkod1) & " )"
            End If
            If kod10 <> "" Then
                kriter += " AND (stok.sbeden " & sorgu_kriter_string(kod2, qkod2) & ")"
            End If
            If kod1 <> "" Then
                kriter += " AND Stok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif1.sAciklama " & sorgu_kriter_string(kod1, qkod1) & " )"
            End If
            If kod2 <> "" Then
                kriter += " AND Stok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif2.sAciklama " & sorgu_kriter_string(kod2, qkod2) & " )"
            End If
            If kod3 <> "" Then
                kriter += " AND Stok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif3.sAciklama " & sorgu_kriter_string(kod3, qkod3) & " )"
            End If
            If kod4 <> "" Then
                kriter += " AND Stok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif4.sAciklama " & sorgu_kriter_string(kod4, qkod4) & " )"
            End If
            If kod5 <> "" Then
                kriter += " AND Stok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif5.sAciklama " & sorgu_kriter_string(kod5, qkod5) & " )"
            End If
            If kod6 <> "" Then
                kriter += " AND Stok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu WHERE tbSSinif6.sAciklama " & sorgu_kriter_string(kod6, qkod6) & " )"
            End If
            If kod7 <> "" Then
                kriter += " AND Stok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu WHERE tbSSinif7.sAciklama " & sorgu_kriter_string(kod7, qkod7) & " )"
            End If
            If kod8 <> "" Then
                kriter += " AND Stok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu WHERE tbSSinif8.sAciklama " & sorgu_kriter_string(kod8, qkod8) & " )"
            End If
            If kayitno <> "" Then
                kriter += " AND (stok.nStokID " & sorgu_kriter_string(kayitno, qkayitno) & ")"
            End If
            If gelismis <> "" Then
                'kriter += " AND (stok.skodu " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (stok.saciklama " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (stok.sKisaAdi " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (barkod.sbarkod " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (stok.srenk " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (stok.sbeden " & sorgu_kriter_string(gelismis, qgelismis) & ") "
                kriter += " AND (stok.skodu " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (stok.saciklama " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (stok.sOzelNot " & sorgu_kriter_string(gelismis, qgelismis) & ")OR  (stok.sKisaAdi " & sorgu_kriter_string(gelismis, qgelismis) & ") OR stok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(gelismis, qgelismis) & ")  OR (stok.srenk " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (stok.sbeden " & sorgu_kriter_string(gelismis, qgelismis) & ") "
            End If
            If muadilbarkod <> "" Then
                kriter += " AND (stok.sKisaAdi " & sorgu_kriter_string(muadilbarkod, qmuadilbarkod) & ")"
            End If
            If aktif = 0 Then
                kriter += " AND (stok.nStokTipi =5) "
            ElseIf Uretim = True Then
                kriter += " AND (stok.nStokTipi <> 5) "
            ElseIf aktif <> 0 Then
                kriter += " AND (stok.nStokTipi < 5) "
            End If
            If sStokSinirla <> "" Then
                kriter += " AND (stok.sKodu like '" & sStokSinirla & "%') "
            End If
            If sKdvTipi <> "" Then
                kriter += " AND (stok.sKdvTipi like '" & sKdvTipi & "%') "
            End If
            If depo <> "" Then
                kriter_depo += " AND (tbStokFisiDetayi.sDepo " & sorgu_kriter_string(depo, qdepo) & ")"
            End If
            If bFatura = True Then
                depo = sDepo
                qdepo = "Başlar"
                kriter_depo = " AND (tbStokFisiDetayi.sDepo " & sorgu_kriter_string(depo, qdepo) & ")"
                kriter_depo_siparis += " AND (tbAlisVeris.sMagaza " & sorgu_kriter_string(depo, qdepo) & ")"
            End If
            If secenek <> "" Then
                If secenek = "[Tümü]" Then
                ElseIf secenek = "Artılar" Then
                    kriter2 = " WHERE Mevcut > 0 "
                ElseIf secenek = "Eksiler" Then
                    kriter2 = " WHERE Mevcut < 0 "
                ElseIf secenek = "Bitenler" Then
                    kriter2 = " WHERE Mevcut = 0 "
                End If
            End If
        End If
        If kriter = "WHERE (stok.skodu is not null )  AND (stok.nStokTipi < 5) " Then
            If nKayitSinir > 0 Then
                count = " TOP " & nKayitSinir & " "
            Else
                count = " TOP 1000 "
            End If
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        cmd.CommandTimeout = False
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd

        'If sFiyatTipi <> "" Then
        '    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " *,lOzelFiyat = CASE WHEN lCariFiyat <> 0 THEN lCariFiyat WHEN lUstFiyat = 0 THEN PESIN ELSE lUstFiyat END FROM (SELECT stok.nStokID, stok.sKodu, stok.sAciklama, stok.sKisaAdi,stok.nHacim,stok.nAgirlik,stok.sBeden, stok.sKavala,stok.sModel, barkod.sBarkod,stok.nStokTipi,stok.nFiyatlandirma,stok.sDovizCinsi,stok.nIskontoYuzdesi,stok.nPrim,stok.bEksiyeDusulebilirmi,stok.bEksideUyarsinmi,stok.sKdvTipi,stok.sOzelNot,stok.sBirimCinsi1, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID " & kriter_depo & ") AS Mevcut, (SELECT SUM(tbSiparis.lMiktari - tbSevkiyat.lSevkMiktari) AS AlinanSiparis FROM tbStok INNER JOIN tbSiparis ON tbStok.nStokID = tbSiparis.nStokID LEFT OUTER JOIN (SELECT SUM(lCikisMiktar1) AS lSevkMiktari , nSiparisID FROM tbStokFisiDetayi WHERE (nSiparisID IS NOT NULL) GROUP BY nSiparisID) tbSevkiyat ON tbSiparis.nSiparisID = tbSevkiyat.nSiparisID WHERE (tbSiparis.nSiparisTipi = 1) AND (tbSiparis.bKapandimi = 0) and (tbSiparis.nStokID = Stok.nStokID)) AS AlinanSiparis,(SELECT SUM(tbSiparis.lMiktari - tbSevkiyat.lSevkMiktari) AS VS FROM tbStok INNER JOIN tbSiparis ON tbStok.nStokID = tbSiparis.nStokID LEFT OUTER JOIN (SELECT SUM(lGirisMiktar1) AS lSevkMiktari , nSiparisID FROM tbStokFisiDetayi WHERE (nSiparisID IS NOT NULL) GROUP BY nSiparisID) tbSevkiyat ON tbSiparis.nSiparisID = tbSevkiyat.nSiparisID WHERE (tbSiparis.nSiparisTipi = 2) AND (tbSiparis.bKapandimi = 0) and (tbSiparis.nStokID = Stok.nStokID)) AS VerilenSiparis,(SELECT ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1), 0) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbStok.nStokID = stok.nStokID) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_depo_siparis & " GROUP BY tbStok.sKodu) AS BEKLEYEN,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS MALIYET,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS PESIN, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS ONAY, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS ALTIAY,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS lFiyat4,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyatA & "') AS ALISFIYATI,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "') AS lCariFiyat,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & Microsoft.VisualBasic.Left(sFiyatTipi, 1) & "') AS lUstFiyat, tbRenk.sRenkAdi, stok.sRenk,tbStokSinifi.sSinifKodu1,tbKdv.nKdvOrani,Stok.nIskontoYuzdesiAV,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS nBirimCarpan,CAST((SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID) / ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS MONEY) AS Mevcut2,(CONVERT(char(10), '" & dteSistemTarihi & "', 103)) dteSistemTarihi,(SELECT     MAX(dteFiyatTespitTarihi) AS nKayit FROM         tbStokFiyati WHERE      (sFiyatTipi IN ('" & sFiyat1 & "', '" & sFiyat2 & "', '" & sFiyat3 & "')) and nStokID = Stok.nStokID) dteFiyatTespitTarihi,(SELECT     COUNT(DISTINCT nStokID) AS nKayit FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi between '" & DateAdd(DateInterval.Day, -3, dteSistemTarihi) & "' and '" & dteSistemTarihi & "') AND (sFiyatTipi IN ('" & sFiyat1 & "', '" & sFiyat2 & "', '" & sFiyat3 & "')) and nStokID = Stok.nStokID) bFiyatDegisti,bYeni = Case When (CONVERT(char(10), Stok.dteKayitTarihi, 103) = '" & Today & "') Then 1 else 0 END,tbDepoDetayi.sDepo1, tbDepoDetayi.sDepo2, tbDepoDetayi.sDepo3, tbDepoDetayi.sDepo4, tbDepoDetayi.sDepo5,tbDepoDetayi.sDepo6,tbStokResim.pResim,tbSSinif1.sAciklama AS SINIF1 FROM tbStok stok LEFT OUTER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk  INNER JOIN tbKdv ON stok.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT nStokID , SUM(sDepo1) AS sDepo1 , SUM(sDepo2) AS sDepo2 , SUM(sDepo3) AS sDepo3 , SUM(sDepo4) AS sDepo4 , SUM(sDepo5) AS sDepo5,sum(sDepo6) as sDepo6 FROM (SELECT  nStokID , CASE WHEN RTRIM(UPPER(sDepo)) = 'D001' THEN lGirisMiktar1 - lCikisMiktar1 ELSE 0 END AS sDepo1 , CASE WHEN RTRIM(UPPER(sDepo)) = 'D002' THEN lGirisMiktar1 - lCikisMiktar1 ELSE 0 END AS sDepo2 , CASE WHEN RTRIM(UPPER(sDepo)) = 'D003' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo3 , CASE WHEN RTRIM(UPPER(sDepo)) = 'D004' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo4 , CASE WHEN RTRIM(UPPER(sDepo)) = 'D005' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo5,CASE WHEN RTRIM(UPPER(sDepo)) = 'D099' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo6 FROM tbStokFisiDetayi) tbStokFisiDetayi GROUP BY nStokID) tbDepoDetayi ON Stok.nStokID = tbDepoDetayi.nStokID LEFT OUTER JOIN tbStokResim ON stok.sModel = tbStokResim.sModel AND tbStokResim.nSira = 0 INNER JOIN                       tbStokSinifi ON Stok.nStokID = tbStokSinifi.nStokID INNER JOIN                       tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu " & kriter & ") AS T " & kriter2 & " ORDER BY sKodu")
        'Else
        '    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " * FROM (SELECT stok.nStokID, stok.sKodu, stok.sAciklama, stok.sKisaAdi,stok.nHacim,stok.nAgirlik,stok.sBeden, stok.sKavala,stok.sModel, barkod.sBarkod,stok.nStokTipi,stok.nFiyatlandirma,stok.sDovizCinsi,stok.nIskontoYuzdesi,stok.nPrim,stok.bEksiyeDusulebilirmi,stok.bEksideUyarsinmi,stok.sKdvTipi,stok.sOzelNot,stok.sBirimCinsi1, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID " & kriter_depo & ") AS Mevcut, (SELECT SUM(tbSiparis.lMiktari - tbSevkiyat.lSevkMiktari) AS AlinanSiparis FROM tbStok INNER JOIN tbSiparis ON tbStok.nStokID = tbSiparis.nStokID LEFT OUTER JOIN (SELECT SUM(lCikisMiktar1) AS lSevkMiktari , nSiparisID FROM tbStokFisiDetayi WHERE (nSiparisID IS NOT NULL) GROUP BY nSiparisID) tbSevkiyat ON tbSiparis.nSiparisID = tbSevkiyat.nSiparisID WHERE (tbSiparis.nSiparisTipi = 1) AND (tbSiparis.bKapandimi = 0) and (tbSiparis.nStokID = Stok.nStokID)) AS AlinanSiparis,(SELECT SUM(tbSiparis.lMiktari - tbSevkiyat.lSevkMiktari) AS VS FROM tbStok INNER JOIN tbSiparis ON tbStok.nStokID = tbSiparis.nStokID LEFT OUTER JOIN (SELECT SUM(lGirisMiktar1) AS lSevkMiktari , nSiparisID FROM tbStokFisiDetayi WHERE (nSiparisID IS NOT NULL) GROUP BY nSiparisID) tbSevkiyat ON tbSiparis.nSiparisID = tbSevkiyat.nSiparisID WHERE (tbSiparis.nSiparisTipi = 2) AND (tbSiparis.bKapandimi = 0) and (tbSiparis.nStokID = Stok.nStokID)) AS VerilenSiparis,(SELECT ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1), 0) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbStok.nStokID = stok.nStokID) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_depo_siparis & " GROUP BY tbStok.sKodu) AS BEKLEYEN,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS MALIYET,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS PESIN, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS ONAY, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS ALTIAY,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS lFiyat4,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyatA & "') AS ALISFIYATI, tbRenk.sRenkAdi, tbStokSinifi.sSinifKodu1,stok.sRenk,tbKdv.nKdvOrani,Stok.nIskontoYuzdesiAV,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS nBirimCarpan,CAST((SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID) / ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS MONEY) AS Mevcut2,(CONVERT(char(10), '" & dteSistemTarihi & "', 103)) dteSistemTarihi,(SELECT     MAX(dteFiyatTespitTarihi) AS nKayit FROM         tbStokFiyati WHERE      (sFiyatTipi IN ('" & sFiyat1 & "', '" & sFiyat2 & "', '" & sFiyat3 & "')) and nStokID = Stok.nStokID) dteFiyatTespitTarihi,(SELECT     COUNT(DISTINCT nStokID) AS nKayit FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi between '" & DateAdd(DateInterval.Day, -3, dteSistemTarihi) & "' and '" & dteSistemTarihi & "') AND (sFiyatTipi IN ('" & sFiyat1 & "', '" & sFiyat2 & "', '" & sFiyat3 & "')) and nStokID = Stok.nStokID) bFiyatDegisti,bYeni = Case When (CONVERT(char(10), Stok.dteKayitTarihi, 103) = '" & Today & "') Then 1 else 0 END,tbDepoDetayi.sDepo1, tbDepoDetayi.sDepo2, tbDepoDetayi.sDepo3, tbDepoDetayi.sDepo4, tbDepoDetayi.sDepo5,tbDepoDetayi.sDepo6,tbStokResim.pResim,tbSSinif1.sAciklama AS SINIF1 FROM tbStok stok LEFT OUTER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk  INNER JOIN tbKdv ON stok.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT nStokID , SUM(sDepo1) AS sDepo1 , SUM(sDepo2) AS sDepo2 , SUM(sDepo3) AS sDepo3 , SUM(sDepo4) AS sDepo4 , SUM(sDepo5) AS sDepo5,sum(sDepo6) as sDepo6 FROM (SELECT  nStokID , CASE WHEN RTRIM(UPPER(sDepo)) = 'D001' THEN lGirisMiktar1 - lCikisMiktar1 ELSE 0 END AS sDepo1 , CASE WHEN RTRIM(UPPER(sDepo)) = 'D002' THEN lGirisMiktar1 - lCikisMiktar1 ELSE 0 END AS sDepo2 , CASE WHEN RTRIM(UPPER(sDepo)) = 'D003' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo3 , CASE WHEN RTRIM(UPPER(sDepo)) = 'D004' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo4 , CASE WHEN RTRIM(UPPER(sDepo)) = 'D005' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo5,CASE WHEN RTRIM(UPPER(sDepo)) = 'D099' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo6 FROM tbStokFisiDetayi) tbStokFisiDetayi GROUP BY nStokID) tbDepoDetayi ON Stok.nStokID = tbDepoDetayi.nStokID LEFT OUTER JOIN tbStokResim ON stok.sModel = tbStokResim.sModel AND tbStokResim.nSira = 0 INNER JOIN                       tbStokSinifi ON Stok.nStokID = tbStokSinifi.nStokID INNER JOIN                       tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu " & kriter & ") AS T " & kriter2 & " ORDER BY sKodu")
        'End If

        If sFiyatTipi <> "" Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " *,lOzelFiyat = CASE WHEN lCariFiyat <> 0 THEN lCariFiyat WHEN lUstFiyat = 0 THEN lFiyat1 ELSE lUstFiyat END FROM (SELECT stok.nStokID, stok.sKodu, tbStokSinifi.sSinifKodu1 as sSinifKodu1,stok.sAciklama, stok.sKisaAdi,stok.nHacim,stok.nAgirlik,stok.sBeden, stok.sKavala,stok.sModel,stok.bWebGoruntule,stok.bWebTavsiye, barkod.sBarkod,stok.nStokTipi,stok.nFiyatlandirma,stok.sDovizCinsi,stok.nIskontoYuzdesi,stok.nPrim,stok.bEksiyeDusulebilirmi,stok.bEksideUyarsinmi,stok.sKdvTipi,stok.sOzelNot,stok.sBirimCinsi1,stok.sBirimCinsi2,stok.bEk1, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID " & kriter_depo & ") AS Mevcut, (SELECT ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1), 0) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbStok.nStokID = stok.nStokID) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_depo_siparis & " GROUP BY tbStok.sKodu) AS BEKLEYEN,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS MALIYET,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS lFiyat3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS lFiyat4,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyatA & "') AS ALISFIYATI,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "') AS lCariFiyat,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & Microsoft.VisualBasic.Left(sFiyatTipi, 1) & "') AS lUstFiyat, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat5 & "'),0) AS lFiyat5,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat6 & "'),0) AS lFiyat6,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat7 & "'),0) AS lFiyat7,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat8 & "'),0) AS lFiyat8,ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat9 & "'),0) AS lFiyat9,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat10 & "'),0) AS lFiyat10,tbRenk.sRenkAdi, stok.sRenk,tbKdv.nKdvOrani,Stok.nIskontoYuzdesiAV,ISNULL((SELECT ISNULL(lOran, 0) FROM tbStokBirimCevrimi WHERE nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS nBirimCarpan,CAST((SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID) / ISNULL((SELECT ISNULL(lOran, 0) FROM tbStokBirimCevrimi WHERE nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS MONEY) AS Mevcut2,(CONVERT(char(10), '" & dteSistemTarihi & "', 103)) dteSistemTarihi,(SELECT MAX(dteFiyatTespitTarihi) AS nKayit FROM tbStokFiyati WHERE (sFiyatTipi IN ('" & sFiyat1 & "', '" & sFiyat2 & "', '" & sFiyat3 & "')) and nStokID = Stok.nStokID) dteFiyatTespitTarihi,(SELECT COUNT(DISTINCT nStokID) AS nKayit FROM tbStokFiyati WHERE (dteFiyatTespitTarihi between '" & DateAdd(DateInterval.Day, -3, dteSistemTarihi) & "' and '" & dteSistemTarihi & "') AND (sFiyatTipi IN ('" & sFiyat1 & "', '" & sFiyat2 & "', '" & sFiyat3 & "')) and nStokID = Stok.nStokID) bFiyatDegisti,bYeni = Case When (CONVERT(char(10), Stok.dteKayitTarihi, 103) = '" & Today & "') Then 1 else 0 END,tbSSinif1.sAciklama AS SINIF1,tbSSinif2.sAciklama AS SINIF2,tbSSinif3.sAciklama AS SINIF3,tbSSinif4.sAciklama AS SINIF4,tbSSinif5.sAciklama AS SINIF5 FROM tbStok stok LEFT OUTER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk  INNER JOIN tbKdv ON stok.sKdvTipi = tbKdv.sKdvTipi INNER JOIN tbStokSinifi ON Stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu " & kriter & ") AS T " & kriter2 & " ORDER BY sKodu")
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " * FROM (SELECT stok.nStokID, stok.sKodu,tbStokSinifi.sSinifKodu1 as sSinifKodu1, stok.sAciklama, stok.sKisaAdi,stok.nHacim,stok.nAgirlik,stok.sBeden,stok.bWebGoruntule,stok.bWebTavsiye, stok.sKavala,stok.sModel, barkod.sBarkod,stok.nStokTipi,stok.nFiyatlandirma,stok.sDovizCinsi,stok.nIskontoYuzdesi,stok.nPrim,stok.bEksiyeDusulebilirmi,stok.bEksideUyarsinmi,stok.sKdvTipi,stok.sOzelNot,stok.sBirimCinsi1,stok.sBirimCinsi2,Stok.bEk1, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID " & kriter_depo & ") AS Mevcut, (SELECT ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1), 0) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbStok.nStokID = stok.nStokID) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_depo_siparis & " GROUP BY tbStok.sKodu) AS BEKLEYEN,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS MALIYET,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS lFiyat3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS lFiyat4,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyatA & "') AS ALISFIYATI, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat5 & "'),0) AS lFiyat5,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat6 & "'),0) AS FIYAT6,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat7 & "'),0) AS lFiyat7,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat8 & "'),0) AS lFiyat8,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat9 & "'),0) AS lFiyat9,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat10 & "'),0) AS lFiyat10,tbRenk.sRenkAdi, tbSSinif1.sAciklama AS SINIF1,tbSSinif2.sAciklama AS SINIF2,tbSSinif3.sAciklama AS SINIF3,tbSSinif4.sAciklama AS SINIF4,tbSSinif5.sAciklama AS SINIF5,stok.sRenk,tbKdv.nKdvOrani,Stok.nIskontoYuzdesiAV,ISNULL((SELECT ISNULL(lOran, 0) FROM tbStokBirimCevrimi WHERE nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS nBirimCarpan,CAST((SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID) / ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS MONEY) AS Mevcut2,(CONVERT(char(10), '" & dteSistemTarihi & "', 103)) dteSistemTarihi,(SELECT MAX(dteFiyatTespitTarihi) AS nKayit FROM tbStokFiyati WHERE (sFiyatTipi IN ('" & sFiyat1 & "', '" & sFiyat2 & "', '" & sFiyat3 & "')) and nStokID = Stok.nStokID) dteFiyatTespitTarihi,(SELECT COUNT(DISTINCT nStokID) AS nKayit FROM tbStokFiyati WHERE (dteFiyatTespitTarihi between '" & DateAdd(DateInterval.Day, -3, dteSistemTarihi) & "' and '" & dteSistemTarihi & "') AND (sFiyatTipi IN ('" & sFiyat1 & "', '" & sFiyat2 & "', '" & sFiyat3 & "')) and nStokID = Stok.nStokID) bFiyatDegisti,bYeni = Case When (CONVERT(char(10), Stok.dteKayitTarihi, 103) = '" & Today & "') Then 1 else 0 END FROM tbStok stok LEFT OUTER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk  INNER JOIN tbKdv ON stok.sKdvTipi = tbKdv.sKdvTipi  INNER JOIN tbStokSinifi ON Stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu " & kriter & ") AS T " & kriter2 & " ORDER BY sKodu")
        End If
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function stokAlternatif(Optional ByVal bAlternatif As Boolean = False, Optional ByVal sAlternatif As String = "") As DataSet
        Dim kriter As String = ""
        Dim kriter2 As String = ""
        Dim kriter_depo As String = ""
        Dim kriter_depo_siparis As String = ""
        kriter = "WHERE (stok.skodu is not null ) "
        If bAlternatif = True Then
            If sAlternatif <> "" Then
                kriter += " AND stok.nStokID IN (Select nStokID from tbStokAlternatif where sModel " & sorgu_kriter_string(sAlternatif, qalternatif) & ")"
                kriter += " OR stok.sModel IN (SELECT tbStokAlternatif.sModel FROM tbStokAlternatif INNER JOIN tbStok ON tbStokAlternatif.nStokID = tbStok.nStokID WHERE (tbStok.sModel  " & sorgu_kriter_string(sAlternatif, qalternatif) & "))"
                'kriter += " AND stok.nStokID IN (SELECT DISTINCT tbStok.nStokID FROM tbStokAlternatif INNER JOIN tbStok ON tbStokAlternatif.nStokID = tbStok.nStokID WHERE (tbStok.sModel " & sorgu_kriter_string(alternatif, qalternatif) & ") OR (tbStokAlternatif.sModel " & sorgu_kriter_string(alternatif, qalternatif) & "))"
            End If
        Else
            If stokkodu <> "" Then
                kriter += " AND (stok.skodu " & sorgu_kriter_string(stokkodu, qstokkodu) & ")"
            End If
            If malincinsi <> "" Then
                'kriter += " AND (stok.saciklama " & sorgu_kriter_string(malincinsi, qmalincinsi) & ") or (stok.sOzelNot " & sorgu_kriter_string(malincinsi, qmalincinsi) & ")"
                kriter += " AND (stok.saciklama " & sorgu_kriter_string(malincinsi, qmalincinsi) & ") "
            End If
            If barkod <> "" Then
                'kriter += " AND (barkod.sbarkod " & sorgu_kriter_string(barkod, qbarkod) & ")"
                kriter += " AND stok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(barkod, qbarkod) & ")"
                okut = True
            Else
                okut = False
            End If
            If alternatif <> "" Then
                kriter += " AND stok.nStokID IN (Select nStokID from tbStokAlternatif where sModel " & sorgu_kriter_string(alternatif, qalternatif) & ")"
                kriter += " OR stok.sModel IN (SELECT tbStokAlternatif.sModel FROM tbStokAlternatif INNER JOIN tbStok ON tbStokAlternatif.nStokID = tbStok.nStokID WHERE (tbStok.sModel  " & sorgu_kriter_string(alternatif, qalternatif) & "))"
                'kriter += " AND stok.nStokID IN (SELECT DISTINCT tbStok.nStokID FROM tbStokAlternatif INNER JOIN tbStok ON tbStokAlternatif.nStokID = tbStok.nStokID WHERE (tbStok.sModel " & sorgu_kriter_string(alternatif, qalternatif) & ") OR (tbStokAlternatif.sModel " & sorgu_kriter_string(alternatif, qalternatif) & "))"
            End If
            If kod9 <> "" Then
                kriter += " AND (stok.srenk " & sorgu_kriter_string(kod1, qkod1) & " )"
            End If
            If kod10 <> "" Then
                kriter += " AND (stok.sbeden " & sorgu_kriter_string(kod2, qkod2) & ")"
            End If
            If kod1 <> "" Then
                kriter += " AND Stok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif1.sAciklama " & sorgu_kriter_string(kod1, qkod1) & " )"
            End If
            If kod2 <> "" Then
                kriter += " AND Stok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif2.sAciklama " & sorgu_kriter_string(kod2, qkod2) & " )"
            End If
            If kod3 <> "" Then
                kriter += " AND Stok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif3.sAciklama " & sorgu_kriter_string(kod3, qkod3) & " )"
            End If
            If kod4 <> "" Then
                kriter += " AND Stok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif4.sAciklama " & sorgu_kriter_string(kod4, qkod4) & " )"
            End If
            If kod5 <> "" Then
                kriter += " AND Stok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif5.sAciklama " & sorgu_kriter_string(kod5, qkod5) & " )"
            End If
            If kod6 <> "" Then
                kriter += " AND Stok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu WHERE tbSSinif6.sAciklama " & sorgu_kriter_string(kod6, qkod6) & " )"
            End If
            If kod7 <> "" Then
                kriter += " AND Stok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu WHERE tbSSinif7.sAciklama " & sorgu_kriter_string(kod7, qkod7) & " )"
            End If
            If kod8 <> "" Then
                kriter += " AND Stok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu WHERE tbSSinif8.sAciklama " & sorgu_kriter_string(kod8, qkod8) & " )"
            End If
            If kayitno <> "" Then
                kriter += " AND (stok.nStokID " & sorgu_kriter_string(kayitno, qkayitno) & ")"
            End If
            If gelismis <> "" Then
                'kriter += " AND (stok.skodu " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (stok.saciklama " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (stok.sKisaAdi " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (barkod.sbarkod " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (stok.srenk " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (stok.sbeden " & sorgu_kriter_string(gelismis, qgelismis) & ") "
                kriter += " AND (stok.skodu " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (stok.saciklama " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (stok.sOzelNot " & sorgu_kriter_string(gelismis, qgelismis) & ")OR  (stok.sKisaAdi " & sorgu_kriter_string(gelismis, qgelismis) & ") OR stok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(gelismis, qgelismis) & ")  OR (stok.srenk " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (stok.sbeden " & sorgu_kriter_string(gelismis, qgelismis) & ") "
            End If
            If muadilbarkod <> "" Then
                kriter += " AND (stok.sKisaAdi " & sorgu_kriter_string(muadilbarkod, qmuadilbarkod) & ")"
            End If
            If aktif = 0 Then
                kriter += " AND (stok.nStokTipi =5) "
            Else
                kriter += " AND (stok.nStokTipi < 5) "
            End If
            If sStokSinirla <> "" Then
                kriter += " AND (stok.sKodu like '" & sStokSinirla & "%') "
            End If
            If sKdvTipi <> "" Then
                kriter += " AND (stok.sKdvTipi like '" & sKdvTipi & "%') "
            End If
            If depo <> "" Then
                kriter_depo += " AND (tbStokFisiDetayi.sDepo " & sorgu_kriter_string(depo, qdepo) & ")"
            End If
            If bFatura = True Then
                depo = sDepo
                qdepo = "Başlar"
                kriter_depo = " AND (tbStokFisiDetayi.sDepo " & sorgu_kriter_string(depo, qdepo) & ")"
                kriter_depo_siparis += " AND (tbAlisVeris.sMagaza " & sorgu_kriter_string(depo, qdepo) & ")"
            End If
            If secenek <> "" Then
                If secenek = "[Tümü]" Then
                ElseIf secenek = "Artılar" Then
                    kriter2 = " WHERE Mevcut > 0 "
                ElseIf secenek = "Eksiler" Then
                    kriter2 = " WHERE Mevcut < 0 "
                ElseIf secenek = "Bitenler" Then
                    kriter2 = " WHERE Mevcut = 0 "
                End If
            End If
        End If
        If kriter = "WHERE (stok.skodu is not null )  AND (stok.nStokTipi < 5) " Then
            If nKayitSinir > 0 Then
                count = " TOP " & nKayitSinir & " "
            Else
                count = " TOP 1000 "
            End If
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        cmd.CommandTimeout = False
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'If sFiyatTipi <> "" Then
        '    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " *,lOzelFiyat = CASE WHEN lCariFiyat <> 0 THEN lCariFiyat WHEN lUstFiyat = 0 THEN PESIN ELSE lUstFiyat END FROM (SELECT stok.nStokID, stok.sKodu, stok.sAciklama, stok.sKisaAdi,stok.nHacim,stok.nAgirlik,stok.sBeden, stok.sKavala,stok.sModel, barkod.sBarkod,stok.nStokTipi,stok.nFiyatlandirma,stok.nIskontoYuzdesi,stok.nPrim,stok.bEksiyeDusulebilirmi,stok.bEksideUyarsinmi,stok.sKdvTipi,stok.sOzelNot,stok.sBirimCinsi1, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID " & kriter_depo & ") AS Mevcut, (SELECT SUM(tbSiparis.lMiktari - tbSevkiyat.lSevkMiktari) AS AlinanSiparis FROM tbStok INNER JOIN tbSiparis ON tbStok.nStokID = tbSiparis.nStokID LEFT OUTER JOIN (SELECT SUM(lCikisMiktar1) AS lSevkMiktari , nSiparisID FROM tbStokFisiDetayi WHERE (nSiparisID IS NOT NULL) GROUP BY nSiparisID) tbSevkiyat ON tbSiparis.nSiparisID = tbSevkiyat.nSiparisID WHERE (tbSiparis.nSiparisTipi = 1) AND (tbSiparis.bKapandimi = 0) and (tbSiparis.nStokID = Stok.nStokID)) AS AlinanSiparis,(SELECT SUM(tbSiparis.lMiktari - tbSevkiyat.lSevkMiktari) AS VS FROM tbStok INNER JOIN tbSiparis ON tbStok.nStokID = tbSiparis.nStokID LEFT OUTER JOIN (SELECT SUM(lGirisMiktar1) AS lSevkMiktari , nSiparisID FROM tbStokFisiDetayi WHERE (nSiparisID IS NOT NULL) GROUP BY nSiparisID) tbSevkiyat ON tbSiparis.nSiparisID = tbSevkiyat.nSiparisID WHERE (tbSiparis.nSiparisTipi = 2) AND (tbSiparis.bKapandimi = 0) and (tbSiparis.nStokID = Stok.nStokID)) AS VerilenSiparis,(SELECT ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1), 0) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbStok.nStokID = stok.nStokID) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_depo_siparis & " GROUP BY tbStok.sKodu) AS BEKLEYEN,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS MALIYET,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS PESIN, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS ONAY, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS ALTIAY,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS lFiyat4,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyatA & "') AS ALISFIYATI,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "') AS lCariFiyat,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & Microsoft.VisualBasic.Left(sFiyatTipi, 1) & "') AS lUstFiyat, tbRenk.sRenkAdi, stok.sRenk,(SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = Stok.nStokID) AS sSinifKodu1,tbKdv.nKdvOrani,Stok.nIskontoYuzdesiAV,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS nBirimCarpan,CAST((SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID) / ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS MONEY) AS Mevcut2,(SELECT     COUNT(DISTINCT nStokID) AS nKayit FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi = '" & Today & "') AND (sFiyatTipi IN ('" & sFiyat1 & "', '" & sFiyat2 & "', '" & sFiyat3 & "')) and nStokID = Stok.nStokID) bFiyatDegisti,bYeni = Case When (CONVERT(char(10), Stok.dteKayitTarihi, 103) = '" & Today & "') Then 1 else 0 END FROM tbStok stok LEFT OUTER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk  INNER JOIN tbKdv ON stok.sKdvTipi = tbKdv.sKdvTipi " & kriter & ") AS T " & kriter2 & " ORDER BY sKodu")
        '    'colPESIN.FieldName = "lOzelFiyat"
        'Else
        '    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " * FROM (SELECT stok.nStokID, stok.sKodu, stok.sAciklama, stok.sKisaAdi,stok.nHacim,stok.nAgirlik,stok.sBeden, stok.sKavala,stok.sModel, barkod.sBarkod,stok.nStokTipi,stok.nFiyatlandirma,stok.nIskontoYuzdesi,stok.nPrim,stok.bEksiyeDusulebilirmi,stok.bEksideUyarsinmi,stok.sKdvTipi,stok.sOzelNot,stok.sBirimCinsi1, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID " & kriter_depo & ") AS Mevcut, (SELECT SUM(tbSiparis.lMiktari - tbSevkiyat.lSevkMiktari) AS AlinanSiparis FROM tbStok INNER JOIN tbSiparis ON tbStok.nStokID = tbSiparis.nStokID LEFT OUTER JOIN (SELECT SUM(lCikisMiktar1) AS lSevkMiktari , nSiparisID FROM tbStokFisiDetayi WHERE (nSiparisID IS NOT NULL) GROUP BY nSiparisID) tbSevkiyat ON tbSiparis.nSiparisID = tbSevkiyat.nSiparisID WHERE (tbSiparis.nSiparisTipi = 1) AND (tbSiparis.bKapandimi = 0) and (tbSiparis.nStokID = Stok.nStokID)) AS AlinanSiparis,(SELECT SUM(tbSiparis.lMiktari - tbSevkiyat.lSevkMiktari) AS VS FROM tbStok INNER JOIN tbSiparis ON tbStok.nStokID = tbSiparis.nStokID LEFT OUTER JOIN (SELECT SUM(lGirisMiktar1) AS lSevkMiktari , nSiparisID FROM tbStokFisiDetayi WHERE (nSiparisID IS NOT NULL) GROUP BY nSiparisID) tbSevkiyat ON tbSiparis.nSiparisID = tbSevkiyat.nSiparisID WHERE (tbSiparis.nSiparisTipi = 2) AND (tbSiparis.bKapandimi = 0) and (tbSiparis.nStokID = Stok.nStokID)) AS VerilenSiparis,(SELECT ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1), 0) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbStok.nStokID = stok.nStokID) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_depo_siparis & " GROUP BY tbStok.sKodu) AS BEKLEYEN,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS MALIYET,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS PESIN, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS ONAY, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS ALTIAY,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS lFiyat4,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyatA & "') AS ALISFIYATI, tbRenk.sRenkAdi, (SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = Stok.nStokID) AS sSinifKodu1,stok.sRenk,tbKdv.nKdvOrani,Stok.nIskontoYuzdesiAV,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS nBirimCarpan,CAST((SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID) / ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS MONEY) AS Mevcut2,(SELECT     COUNT(DISTINCT nStokID) AS nKayit FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi = '" & Today & "') AND (sFiyatTipi IN ('" & sFiyat1 & "', '" & sFiyat2 & "', '" & sFiyat3 & "')) and nStokID = Stok.nStokID) bFiyatDegisti,bYeni = Case When (CONVERT(char(10), Stok.dteKayitTarihi, 103) = '" & Today & "') Then 1 else 0 END FROM tbStok stok LEFT OUTER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk  INNER JOIN tbKdv ON stok.sKdvTipi = tbKdv.sKdvTipi " & kriter & ") AS T " & kriter2 & " ORDER BY sKodu")
        'End If
        'If sFiyatTipi <> "" Then
        '    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " *,lOzelFiyat = CASE WHEN lCariFiyat <> 0 THEN lCariFiyat WHEN lUstFiyat = 0 THEN PESIN ELSE lUstFiyat END FROM (SELECT     nStokID, sKodu, sAciklama,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID " & kriter_depo & ") AS Mevcut,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS PESIN,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "') AS lCariFiyat,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & Microsoft.VisualBasic.Left(sFiyatTipi, 1) & "') AS lUstFiyat FROM         tbStok stok " & kriter & ") AS T " & kriter2 & " ORDER BY sKodu")
        'Else
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " * FROM (SELECT nStokID, sKodu, sAciklama, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID " & kriter_depo & ") AS Mevcut,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS PESIN FROM tbStok stok " & kriter & ") AS T " & kriter2 & " ORDER BY sKodu")
        'End If
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
        If GridView1.RowCount > 0 Then
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
    Private Sub analiz_hareket_transfer()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri_transfer
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            'frm.stokno = dr("nStokId")
            frm.stokkodu = Trim(dr("sKodu"))
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
    Private Sub analiz_envanter_model()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_envanter_model
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.modelno = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_hareket()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'stkdll.firmano = firmano
        'stkdll.donemno = donemno
        'stkdll.connection = connection
        'stkdll.stokno = dr("IND")
        'stkdll.rptfiyatanalizi(dr("IND"), 100, dr("MALINCINSI"), 2)
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
    Private Sub analiz_stok_Alternatif()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.aktif = 1
            frm.alternatif = dr("sKodu")
            frm.qalternatif = "Eşittir"
            frm.status = True
            If yetki_kontrol(kullanici, "frm_Stok_Alternatif") = True Then
                frm.ShowDialog()
            End If
        End If
    End Sub
    Private Sub analiz_protokol()
        'If sLicenseModule.Items.Contains("Protokol") = True Then
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_tbStokCariProtokol
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokID")
            frm.nFirmaID = 0
            frm.txt_musteriNo.Text = dr("sKodu")
            frm.lbl_Firma.Text = dr("sAciklama")
            frm.bFirma = False
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
        'End If
    End Sub
    Private Sub analiz_resim()
        If GridView1.RowCount > 0 Then
            Dim satir = GridView1.FocusedRowHandle
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim dsResim As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT     * FROM         tbStokResim WHERE     (sModel = '" & dr("sModel") & "') Order by nSira"))
            If dsResim.Tables(0).Rows.Count > 0 Then
                dr = dsResim.Tables(0).Rows(0)
                Try
                    Dim frm As New frm_tbResim
                    frm.dsResim = dsResim
                    frm.bTekResim = False
                    frm.ShowDialog()
                    frm.Close()
                    frm.Dispose()
                    frm = Nothing
                Catch ex As Exception
                End Try
                dsResim = Nothing
                satir = Nothing
            End If
        End If
    End Sub
    Private Sub stok_fiyat()
        If GridView1.RowCount > 0 Then
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
            frm.sKavala = dr("sKavala")
            frm.txt_musteriNo.Text = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            Dim satir = GridView1.FocusedRowHandle
            dataload()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
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
                dr = DataSet1.Tables(0).NewRow
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
    Private Sub sBirimCinsi_sec(Optional ByVal bAktar As Boolean = False)
        Dim frm As New frm_tbStokBirim
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sModel = dr("sModel").ToString
        frm.sBirimCinsi = dr("sBirimCinsi1").ToString
        frm.lMiktar = CType(dr("Mevcut"), Decimal)
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            'If dr_baslik("bKilitli") = False Then
            '    Dim dr1 As DataRow
            '    dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            '    'If bAktar = False Then
            '    '    If dr_baslik("nGirisCikis") = 1 Or dr_baslik("nGirisCikis") = 2 Then
            '    '        dr("lGirisMiktar1") = dr1("lBol") * dr1("lOran")
            '    '    ElseIf dr_baslik("nGirisCikis") = 3 Or dr_baslik("nGirisCikis") = 4 Then
            '    '        dr("lCikisMiktar1") = dr1("lBol") * dr1("lOran")
            '    '    End If
            '    'Else
            '    dr("lFiyat") = dr("lBrutFiyat") / dr("lBirimMiktar")
            '    dr("lBirimMiktar") = dr1("lOran")
            '    dr("sBirimCinsi") = dr1("sBirimCinsi")
            '    dr("lFiyat") = dr("lBrutFiyat") * dr("lBirimMiktar")
            '    'End If
            '    dr1 = Nothing
            '    GridView1.UpdateCurrentRow()
            '    tutar_hesapla()
            'End If
        End If
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Excel Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyaları(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.xls"
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
            SaveFileDialog1.FileName = "Rapor.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla(ByVal nIslem As Integer, Optional ByVal bDirekt As Boolean = False, Optional ByVal bMiktarli As Integer = 1)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyaları (*.fr*) |*.fr*"
        OpenFileDialog1.FileName = "c:\Formlar\Etiket\Etiket" & sRaporUzanti & ""
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'guncelle_fiyattipi()
            Dim sFile = OpenFileDialog1.FileName.ToString
            If Microsoft.VisualBasic.Right(sFile, 3) = "fr3" Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                Dim kriter As String = ""
                If bDirekt = False Then
                    kriter = satir_kontrol()
                    report_create_stok(sFile, kriter, nIslem, sorgu_sayi(dr("Mevcut") * bMiktarli, 1), sorgu_sayi(dr("PESIN"), 0), sorgu_sayi(dr("ALTIAY"), 0), sorgu_sayi(dr("ONAY"), 0), sorgu_sayi(dr("FIYAT4"), 0), dr("sKodu").ToString, dr("sModel").ToString, dr("sAciklama").ToString, dr("sBarkod").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sorgu_sayi(dr("Mevcut") * bMiktarli, 1))
                Else
                    Dim dr1 As DataRow
                    For Each dr1 In DataSet1.Tables(0).Rows
                        report_create_stok(sFile, " WHERE stok.nStokId =" & dr1("nStokID") & "", nIslem, sorgu_sayi(dr1("Mevcut") * bMiktarli, 1), sorgu_sayi(dr1("PESIN"), 0), sorgu_sayi(dr1("ALTIAY"), 0), sorgu_sayi(dr1("ONAY"), 0), sorgu_sayi(dr1("FIYAT4"), 0), dr("sKodu").ToString, dr("sModel").ToString, dr("sAciklama").ToString, dr("sBarkod").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sorgu_sayi(dr("Mevcut") * bMiktarli, 1))
                    Next
                End If
                sFile = Nothing
                kriter = Nothing
            ElseIf Microsoft.VisualBasic.Right(sFile, 3) = "frx" Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                Dim kriter As String = ""
                If bDirekt = False Then
                    kriter = satir_kontrol()
                    report_create(nIslem, sFile, kriter, sorgu_sayi(dr("Mevcut") * bMiktarli, 1))
                Else
                    Dim dr1 As DataRow
                    For Each dr1 In DataSet1.Tables(0).Rows
                        report_create(nIslem, sFile, " WHERE stok.nStokId =" & dr1("nStokID") & "", sorgu_sayi(dr1("Mevcut") * bMiktarli, 1))
                    Next
                End If
                sFile = Nothing
                kriter = Nothing
            End If
        End If
    End Sub
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer, ByVal miktar As Decimal, ByVal fiyat1 As Decimal, ByVal fiyat2 As Decimal, ByVal fiyat3 As Decimal, ByVal fiyat4 As Decimal, ByVal sKodu As String, ByVal sModel As String, ByVal sAciklama As String, ByVal sBarkod As String, ByVal sRenk As String, ByVal sBeden As String, ByVal lMiktar As String)
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
            qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT 0 as sPartiNo,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS lFiyat1, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS lFiyat3, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS lFiyat2,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS lFiyat4, ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS lBirimCarpan,barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.sKavala,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ")
            Dim qr_connection As New FastReport.TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_hareket.DataBase = qr_connection
            frx.PrintOptions.Collate = False
            'If sec_sPrint.Checked = True Then
            '    frx.PrintOptions.Printer = sPrint
            'Else
            'End If
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
            args(2) = "" & sorgu_query("set transaction isolation level read uncommitted SELECT 0 as sPartiNo,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS lFiyat1, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS lFiyat3, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS lFiyat2,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS lFiyat4, ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS lBirimCarpan,barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.sKavala,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ") & ""
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
                MessageBox.Show("Raporlama İşlemi İçin LOG Oluşturulumadı!")
            End Try
            If File.Exists(Directory.GetCurrentDirectory() & "\RaporServis.exe") = True Then
                Dim sInfo As New ProcessStartInfo(Directory.GetCurrentDirectory() & "\RaporServis.exe ", """" & yeniYol & """")
                Process.Start(sInfo)
            Else
                MessageBox.Show("Lütfen 'RaporServis.exe' eklentisini uygulama dizinine kopyalayın.")
            End If
        End If
        stokno = Nothing
        satir_line = Nothing
    End Sub
    Private Sub report_create(ByVal nIslem As Integer, ByVal sFile As String, ByVal kriter As String, Optional ByVal bMiktarli As Integer = 1)
        Dim report As New FastReport.Report
        report.Load(sFile)
        Dim ds_etiket As DataSet
        ds_etiket = sorgu(sorgu_query("set transaction isolation level read uncommitted SELECT 0 as sPartiNo,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS lFiyat1, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS lFiyat3, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS lFiyat2,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS lFiyat4, barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.sKavala,stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " "), "Etiket")
        report.RegisterData(ds_etiket)
        report.RegisterData(ds_tbParamGenel)
        report.ScriptLanguage = FastReport.Language.Vb
        report.PrintSettings.Collate = False
        'If sec_sPrint.Checked = True Then
        '    report.PrintSettings.Printer = sPrint
        'Else
        'End If
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
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        'If GridView1.SelectedRowsCount > 1 Then
        '    Dim sayi = GridView1.FocusedRowHandle + 1
        '    Dim sayi1 = GridView1.SelectedRowsCount
        '    GridView1.FocusedColumn = colSTOKKODU
        '    Me.colSTOKKODU.SummaryItem.DisplayFormat = "Kayıt:{0}/Satır:" & sayi & "/Seçili:" & sayi1 & ""
        'ElseIf GridView1.SelectedRowsCount = 1 Then
        '    Dim sayi = GridView1.FocusedRowHandle + 1
        '    Me.colSTOKKODU.SummaryItem.DisplayFormat = "Kayıt:{0}"
        'End If
        Try
            satir_info()
        Catch ex As Exception
        End Try
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub satir_info()
        If GridView1.SelectedRowsCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            lbl_sKodu.Text = "Stok Kodu: <b>" & Trim(dr("sKodu")) & " <b>"
            lbl_sAciklama.Text = "Stok Aciklama: <b>" & Trim(dr("sAciklama")) & " <b>"
            lbl_sKisaAdi.Text = "KısaKod: <b>" & Trim(dr("sKisaAdi")) & " <b>"
            lbl_sBarkod.Text = "Barkod: <b>" & Trim(dr("sKodu")) & " <b>"
            lbl_sBirimCinsi.Text = "Birim: <b>" & Trim(dr("sBirimCinsi1")) & " <b>"
            lbl_sMevcut.Text = "Mevcut: <b>" & Microsoft.VisualBasic.Format(dr("Mevcut"), "#,0.###") & " <b>"
            lbl_sBekleyen.Text = "Bekleyen: <b>" & Microsoft.VisualBasic.Format(sorgu_sayi(dr("BEKLEYEN"), 0), "#,0.###") & " <b>"
            lbl_sNet.Text = "Net: <b>" & Microsoft.VisualBasic.Format(sorgu_sayi(dr("Mevcut"), 0) - sorgu_sayi(dr("BEKLEYEN"), 0), "#,0.###") & " <b>"
            lbl_Fiyat1.Text = "Fiyat 1: <b>" & Microsoft.VisualBasic.Format(dr("lFiyat1"), "#,0.###") & " <b>"
            lbl_Fiyat2.Text = "Fiyat 2: <b>" & Microsoft.VisualBasic.Format(dr("lFiyat2"), "#,0.###") & " <b>"
            lbl_Fiyat3.Text = "Fiyat 3: <b>" & Microsoft.VisualBasic.Format(dr("lFiyat3"), "#,0.###") & " <b>"
            lbl_Fiyat4.Text = "Fiyat 4: <b>" & Microsoft.VisualBasic.Format(dr("lFiyat4"), "#,0.###") & " <b>"
            sPicture.EditValue = dr("pResim")
            'PictureBox1.DataBindings = dr("pResim")
        End If
        If dPanelEnvanter.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible Then
            satir_stok_mevcut_info()
        End If
        If dPanelSiniflandirma.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible Then
            satir_stok_sinif_info()
        End If
        If dPanelAlternatif.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible Then
            satir_stok_alternatif_info()
        End If
    End Sub
    Private Sub satir_stok_mevcut_info()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            lbl_sEnvanterAciklama.Text = dr("sAciklama")
            If Trim(dr("sRenkAdi").ToString) <> "" Then
                lbl_sEnvanterAciklama.Text += vbTab & " (" & dr("sRenkAdi") & " )"
            End If
            Dim ds_envanter As DataSet
            ds_envanter = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sAciklama, SUM(GIREN) AS GIREN, SUM(CIKAN) AS CIKAN, SUM(KALAN) AS KALAN,SUM(BEKLEYEN) AS BEKLEYEN, sBarkod, STOKKODU, STOKADI, sRenk, sBeden, lAsgariMiktar, lAzamiMiktar, sModel FROM (SELECT depo.sAciklama , 0 AS GIREN , 0 AS CIKAN , 0 AS KALAN , barkod.sBarkod , stok.sKodu AS STOKKODU , stok.sAciklama AS STOKADI , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu ='" & Trim(dr("sKodu")) & "') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') GROUP BY depo.sAciklama , barkod.sBarkod , stok.sKodu , stok.sAciklama , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel UNION SELECT depo.sAciklama , ISNULL(SUM(hareket.lGirisMiktar1) , 0) AS GIREN , ISNULL(SUM(hareket.lCikisMiktar1) , 0) AS CIKAN , ISNULL(SUM(hareket.lGirisMiktar1 - hareket.lCikisMiktar1) , 0) AS KALAN , barkod.sBarkod , stok.sKodu AS STOKKODU , stok.sAciklama AS STOKADI , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , 0 AS BEKLEYEN FROM tbStokBarkodu barkod INNER JOIN tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo ON barkod.nStokID = stok.nStokID and barkod.nKisim = 0 WHERE (stok.sKodu = '" & Trim(dr("sKodu")) & "') GROUP BY depo.sAciklama , stok.nStokID , barkod.sBarkod , stok.sKodu , stok.sAciklama , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , depo.sDepo) TT GROUP BY sAciklama, sBarkod, STOKKODU, STOKADI, sRenk, sBeden, lAsgariMiktar, lAzamiMiktar, sModel"))
            GridControl3.DataSource = ds_envanter.Tables(0)
            GridControl3.DataMember = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub satir_stok_sinif_info()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            lbl_sSiniflandirmaAciklama.Text = dr("sAciklama")
            Dataload_tbStokSinifi(dr("sModel"))
            dr = Nothing
        End If
    End Sub
    Private Sub satir_stok_alternatif_info()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            lbl_sSiniflandirmaAciklama.Text = dr("sAciklama")
            Dim ds_Alternatif As DataSet = stokAlternatif(True, dr("sModel"))
            GridControl4.DataSource = ds_Alternatif.Tables(0)
            GridControl4.DataMember = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub Dataload_tbStokSinifi(ByVal sModel As String)
        Dim kriter As String = ""
        kriter += " SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
        kriter += " SELECT TOP 1 1 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi01 FROM tbParamStok) AS sSinifTipi, tbSSinif1.sSinifKodu, tbSSinif1.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 2 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi02 FROM tbParamStok) AS sSinifTipi, tbSSinif2.sSinifKodu, tbSSinif2.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 3 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi03 FROM tbParamStok) AS sSinifTipi, tbSSinif3.sSinifKodu, tbSSinif3.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 4 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi04 FROM tbParamStok) AS sSinifTipi, tbSSinif4.sSinifKodu, tbSSinif4.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 5 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi05 FROM tbParamStok) AS sSinifTipi, tbSSinif5.sSinifKodu, tbSSinif5.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 6 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi06 FROM tbParamStok) AS sSinifTipi, tbSSinif6.sSinifKodu, tbSSinif6.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 7 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi07 FROM tbParamStok) AS sSinifTipi, tbSSinif7.sSinifKodu, tbSSinif7.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 8 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi08 FROM tbParamStok) AS sSinifTipi, tbSSinif8.sSinifKodu, tbSSinif8.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 9 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi09 FROM tbParamStok) AS sSinifTipi, tbSSinif9.sSinifKodu, tbSSinif9.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 10 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi10 FROM tbParamStok) AS sSinifTipi, tbSSinif10.sSinifKodu, tbSSinif10.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 11 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi11 FROM tbParamStok) AS sSinifTipi, tbSSinif11.sSinifKodu, tbSSinif11.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 12 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi12 FROM tbParamStok) AS sSinifTipi, tbSSinif12.sSinifKodu, tbSSinif12.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 13 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi13 FROM tbParamStok) AS sSinifTipi, tbSSinif13.sSinifKodu, tbSSinif13.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 14 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi14 FROM tbParamStok) AS sSinifTipi, tbSSinif14.sSinifKodu, tbSSinif14.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 15 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi15 FROM tbParamStok) AS sSinifTipi, tbSSinif15.sSinifKodu, tbSSinif15.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        Dim ds_tbStokSinifi As DataSet
        ds_tbStokSinifi = sorgu(sorgu_query("" & kriter & ""))
        GridControl2.DataMember = Nothing
        GridControl2.DataSource = ds_tbStokSinifi.Tables(0)
    End Sub
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        ara()
    End Sub

    Private Sub GridView1_ShowingEditor(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridView1.ShowingEditor
        ' Sadece checkbox kolonunda düzenlemeye izin ver
        If GridView1.FocusedColumn IsNot Nothing Then
            If GridView1.FocusedColumn.FieldName <> "Sec" Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub GridControl1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridControl1.MouseWheel
        ' Checkbox kolonunda iken scroll çalışsın diye edit modundan çık
        If GridView1.FocusedColumn IsNot Nothing Then
            If GridView1.FocusedColumn.FieldName = "Sec" Then
                GridView1.CloseEditor()
            End If
        End If
    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        ' Checkbox değeri değiştiğinde edit modundan çık ve focus'u başka kolona kaydır
        If e.Column.FieldName = "Sec" Then
            GridView1.CloseEditor()
            GridView1.UpdateCurrentRow()

            ' Focus'u bir sonraki kolona kaydır (scroll çalışsın diye)
            Dim nextColumn As DevExpress.XtraGrid.Columns.GridColumn = Nothing
            For i As Integer = 1 To GridView1.Columns.Count - 1
                If GridView1.Columns(i).Visible Then
                    nextColumn = GridView1.Columns(i)
                    Exit For
                End If
            Next

            If nextColumn IsNot Nothing Then
                GridView1.FocusedColumn = nextColumn
            End If
        End If
    End Sub

    Private Sub GridView1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridView1.MouseUp
        ' Mouse tuşu bırakıldığında edit modundan çık ve focus değiştir
        If GridView1.FocusedColumn IsNot Nothing Then
            If GridView1.FocusedColumn.FieldName = "Sec" Then
                GridView1.CloseEditor()

                ' Focus'u başka kolona kaydır
                Dim nextColumn As DevExpress.XtraGrid.Columns.GridColumn = Nothing
                For i As Integer = 1 To GridView1.Columns.Count - 1
                    If GridView1.Columns(i).Visible Then
                        nextColumn = GridView1.Columns(i)
                        Exit For
                    End If
                Next

                If nextColumn IsNot Nothing Then
                    GridView1.FocusedColumn = nextColumn
                End If
            End If
        End If
    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        sorgula()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            sorgula()
        ElseIf e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        stok_duzelt()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        stok_yeni()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
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
        If islemstatus = False Then
            e.Cancel = True
            Me.Hide()
        Else
            'Me.Hide()
            'PanelControl1 = Nothing
            'PanelControl2 = Nothing
            'PanelControl3 = Nothing
            ''XtraTabControl1 = Nothing
            ''XtraTabPage1 = Nothing
            ''GridControl1 = Nothing
            ''GridView1 = Nothing
            'SimpleButton1 = Nothing
            'SimpleButton2 = Nothing
            'SimpleButton3 = Nothing
            'PictureBox1 = Nothing
            ''Label1 = Nothing
            ''DataSet1 = Nothing
            ''DataTable1 = Nothing
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
            ''Label2 = Nothing
            'MenuItem17 = Nothing
            'MenuItem18 = Nothing
            ''DataColumn1 = Nothing
            ''DataColumn2 = Nothing
            ''DataColumn3 = Nothing
            ''DataColumn4 = Nothing
            ''DataColumn5 = Nothing
            ''DataColumn6 = Nothing
            ''DataColumn7 = Nothing
            ''DataColumn8 = Nothing
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
            'colPESIN = Nothing
            'colALTIAY = Nothing
            'colONAY = Nothing
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
            'dr = Nothing
            'count = Nothing
            ''Me.Close()
            ''Me.Dispose()
            'System.GC.Collect()
            'System.GC.GetTotalMemory(True)
            'System.GC.SuppressFinalize(Me)
        End If
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
        stok_sil()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub MenuItem19_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        analiz_hareket_transfer()
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        If MenuItem25.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem25.Checked = True
        ElseIf MenuItem25.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem25.Checked = False
        End If
    End Sub
    Private Sub btn_Ara_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Ara.ItemClick
        ara()
    End Sub
    Private Sub btn_Ekle_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Ekle.ItemClick
        stok_yeni()
    End Sub
    Private Sub btn_Duzelt_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Duzelt.ItemClick
        stok_duzelt()
    End Sub
    Private Sub btn_Sil_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Sil.ItemClick
        stok_sil()
    End Sub
    Private Sub btn_Yazdir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Yazdir.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub btn_FiyatDuzenle_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_FiyatDuzenle.ItemClick
        stok_fiyat()
    End Sub
    Private Sub btn_Envanter_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Envanter.ItemClick
        analiz_envanter()
    End Sub
    Private Sub btn_StokHareketleri_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_StokHareketleri.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub btn_Transferler_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Transferler.ItemClick
        analiz_hareket_transfer()
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        analiz_resim()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        raporla_excel()
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        analiz_stok_KarlilikAkisTablosu()
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        analiz_stok_Alternatif()
    End Sub
    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        analiz_protokol()
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        sBirimCinsi_sec()
    End Sub
    Private Sub docpanelcontainer_kontrol()
        'If MenuItem32.Checked = True Or MenuItem33.Checked Or MenuItem34.Checked = True Or MenuItem35.Checked = True Or MenuItem37.Checked = True Then
        '    panelContainer1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
        'Else
        '    panelContainer1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        'End If
    End Sub
    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        If MenuItem32.Checked = False Then
            dPanelSiniflandirma.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            MenuItem32.Checked = True
        Else
            dPanelSiniflandirma.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            MenuItem32.Checked = False
        End If
        docpanelcontainer_kontrol()
    End Sub
    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        If MenuItem33.Checked = False Then
            dPanelResim.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            MenuItem33.Checked = True
        Else
            dPanelResim.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            MenuItem33.Checked = False
        End If
        docpanelcontainer_kontrol()
    End Sub
    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        If MenuItem34.Checked = False Then
            dPanelEnvanter.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            MenuItem34.Checked = True
        Else
            dPanelEnvanter.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            MenuItem34.Checked = False
        End If
        docpanelcontainer_kontrol()
    End Sub
    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        If MenuItem35.Checked = False Then
            dPanelAlternatif.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            MenuItem35.Checked = True
        Else
            dPanelAlternatif.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            MenuItem35.Checked = False
        End If
        docpanelcontainer_kontrol()
    End Sub
    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click
        If MenuItem37.Checked = False Then
            dPanelRecete.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            MenuItem37.Checked = True
        Else
            dPanelRecete.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            MenuItem37.Checked = False
        End If
        docpanelcontainer_kontrol()
    End Sub
    Private Sub panelContainer1_VisibilityChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking.VisibilityChangedEventArgs)
        If dPanelAlternatif.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden Then
            MenuItem35.Checked = False
        Else
            MenuItem35.Checked = True
        End If
        If dPanelEnvanter.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden Then
            MenuItem34.Checked = False
        Else
            MenuItem34.Checked = True
        End If
        If dPanelRecete.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden Then
            MenuItem37.Checked = False
        Else
            MenuItem37.Checked = True
        End If
        If dPanelResim.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden Then
            MenuItem33.Checked = False
        Else
            MenuItem33.Checked = True
        End If
        If dPanelSiniflandirma.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden Then
            MenuItem32.Checked = False
        Else
            MenuItem32.Checked = True
        End If
        If dPanelTanım.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden Then
            MenuItem38.Checked = False
        Else
            MenuItem38.Checked = True
        End If
    End Sub
    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        If MenuItem38.Checked = False Then
            dPanelTanım.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            MenuItem38.Checked = True
        Else
            dPanelTanım.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            MenuItem38.Checked = False
        End If
        docpanelcontainer_kontrol()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        raporla(0)
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        raporla(2)
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        raporla(1)
    End Sub

    ' ====== Çoklu Seçim İçin Yeni Metodlar ======
    Private Sub MenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem39.Click
        ' Tümünü Seç
        If GridView1.RowCount > 0 Then
            For i As Integer = 0 To GridView1.RowCount - 1
                Dim dr As DataRow = GridView1.GetDataRow(i)
                If dr IsNot Nothing AndAlso dr.Table.Columns.Contains("nStokID") AndAlso dr("nStokID") IsNot DBNull.Value Then
                    SeciliStokIDSet.Add(Convert.ToInt64(dr("nStokID")))
                End If
                GridView1.SetRowCellValue(i, "Sec", True)
            Next
        End If
    End Sub

    Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem40.Click
        ' Seçimi Kaldır
        If GridView1.RowCount > 0 Then
            SeciliStokIDSet.Clear()
            For i As Integer = 0 To GridView1.RowCount - 1
                GridView1.SetRowCellValue(i, "Sec", False)
            Next
        End If
    End Sub

    Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
        ' Seçimi Ters Çevir
        If GridView1.RowCount > 0 Then
            For i As Integer = 0 To GridView1.RowCount - 1
                Dim currentValue As Boolean = False
                Try
                    currentValue = Convert.ToBoolean(GridView1.GetRowCellValue(i, "Sec"))
                Catch ex As Exception
                    currentValue = False
                End Try
                GridView1.SetRowCellValue(i, "Sec", Not currentValue)
            Next
        End If
    End Sub

    ' Sec kolonu değeri değiştiğinde HashSet'i güncelle ve satırı seç/seçimi kaldır
    Private Sub GridView1_CellValueChanged_Sec(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If e.Column.FieldName = "Sec" Then
            Dim dr As DataRow = GridView1.GetDataRow(e.RowHandle)
            If dr IsNot Nothing AndAlso dr.Table.Columns.Contains("nStokID") AndAlso dr("nStokID") IsNot DBNull.Value Then
                Dim nStokID As Long = Convert.ToInt64(dr("nStokID"))
                Dim isChecked As Boolean = Convert.ToBoolean(e.Value)
                
                If isChecked Then
                    SeciliStokIDSet.Add(nStokID)
                    ' Satırı DevExpress seçimine de ekle
                    GridView1.SelectRow(e.RowHandle)
                Else
                    SeciliStokIDSet.Remove(nStokID)
                    ' Satırı DevExpress seçiminden çıkar
                    GridView1.UnselectRow(e.RowHandle)
                End If
            End If
        End If
    End Sub
    
    ' Filtre değiştiğinde seçimleri geri yükle
    Private Sub GridView1_ColumnFilterChanged_Restore(sender As Object, e As EventArgs) Handles GridView1.ColumnFilterChanged
        SecimleriBound()
    End Sub
    
    ' HashSet'teki seçimleri DataTable'a uygula
    Private Sub SecimleriBound()
        Dim dt As DataTable = TryCast(GridControl1.DataSource, DataTable)
        If dt Is Nothing Then Exit Sub
        
        For Each dr As DataRow In dt.Rows
            If dr.Table.Columns.Contains("nStokID") AndAlso dr("nStokID") IsNot DBNull.Value Then
                Dim nStokID As Long = Convert.ToInt64(dr("nStokID"))
                dr("Sec") = SeciliStokIDSet.Contains(nStokID)
            End If
        Next
    End Sub

End Class
