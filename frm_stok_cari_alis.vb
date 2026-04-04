Imports FastReport
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Imports System.IO
Public Class frm_stok_cari_alis
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
    Friend WithEvents ds_baslik As System.Data.DataSet
    Friend WithEvents ds_hareket As System.Data.DataSet
    Friend WithEvents ds_toplam As System.Data.DataSet
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem5 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Panel_baslik As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel_toplamlar As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel_satir As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents Panel_hareket As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents VGrid_baslik As DevExpress.XtraVerticalGrid.VGridControl
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
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents rownFirmaID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsKodu As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAciklama As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rownOzelIskontosu As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlKrediLimiti As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsFiyatTipi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowADRES As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsVergiDairesi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsVergiNo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rownStokFisiID As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsFisTipi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowdteFisTarihi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rownGirisCikis As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlFisNo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowbPesinmi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowbListelendimi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowbHizmetFaturasimi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowbFisTamamlandimi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowbMuhasebeyeIslendimi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsHareketTipi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowdteKayitTarih As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAciklama1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAciklama2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAciklama3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAciklama4 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowsAciklama5 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents categoryTanýmlar As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryFirmaBilgileri As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categoryAçýklamalar As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents categorySorgular As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents VGrid_toplam As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents VGrid_masraf As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents VGrid_iskonto As DevExpress.XtraVerticalGrid.VGridControl
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
    Friend WithEvents ds_masraf As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents EditorRow1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlEkMaliyet1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlEkMaliyet2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlEkMaliyet3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents ds_iskonto As System.Data.DataSet
    Friend WithEvents DataTable4 As System.Data.DataTable
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents DataColumn65 As System.Data.DataColumn
    Friend WithEvents DataColumn66 As System.Data.DataColumn
    Friend WithEvents EditorRow2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlDipIskontoTutari3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDIPISK1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowDIPISK2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents DataTable5 As System.Data.DataTable
    Friend WithEvents DataColumn67 As System.Data.DataColumn
    Friend WithEvents DataColumn68 As System.Data.DataColumn
    Friend WithEvents DataColumn69 As System.Data.DataColumn
    Friend WithEvents DataColumn70 As System.Data.DataColumn
    Friend WithEvents DataColumn71 As System.Data.DataColumn
    Friend WithEvents DataColumn72 As System.Data.DataColumn
    Friend WithEvents DataColumn73 As System.Data.DataColumn
    Friend WithEvents DataColumn74 As System.Data.DataColumn
    Friend WithEvents EditorRow3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlToplamMiktar As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlMalBedeli As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlMalIskontoTutari As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents EditorRow4 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rownKdvOrani1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents row_lKdvMatrahi1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowlNetTutar As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem6 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents collBrutFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBrutTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataColumn75 As System.Data.DataColumn
    Friend WithEvents colONCEKIMALIYET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem17 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem18 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem19 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem20 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem21 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem22 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem23 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_Renk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BarButtonItem24 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem25 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem26 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem27 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem28 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem29 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rowIskonto As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowEkMaliyet As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BarButtonItem30 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MultiEditorRowProperties1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties3 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties4 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties5 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties6 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties7 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties8 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents BarButtonItem32 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem33 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem34 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DataColumn76 As System.Data.DataColumn
    Friend WithEvents rownEvrakNo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents BarButtonItem31 As DevExpress.XtraBars.BarButtonItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_cari_alis))
        Me.MultiEditorRowProperties1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties4 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties5 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties6 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties7 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties8 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.ds_baslik = New System.Data.DataSet()
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
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        Me.DataColumn25 = New System.Data.DataColumn()
        Me.DataColumn26 = New System.Data.DataColumn()
        Me.DataColumn76 = New System.Data.DataColumn()
        Me.ds_hareket = New System.Data.DataSet()
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
        Me.ds_toplam = New System.Data.DataSet()
        Me.DataTable5 = New System.Data.DataTable()
        Me.DataColumn67 = New System.Data.DataColumn()
        Me.DataColumn68 = New System.Data.DataColumn()
        Me.DataColumn69 = New System.Data.DataColumn()
        Me.DataColumn70 = New System.Data.DataColumn()
        Me.DataColumn71 = New System.Data.DataColumn()
        Me.DataColumn72 = New System.Data.DataColumn()
        Me.DataColumn73 = New System.Data.DataColumn()
        Me.DataColumn74 = New System.Data.DataColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem27 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem28 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem26 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem29 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem30 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem31 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem32 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem33 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem34 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem23 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem24 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem25 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem6 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem18 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem19 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem20 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem21 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem22 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem5 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Panel_baslik = New DevExpress.XtraEditors.PanelControl()
        Me.VGrid_baslik = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.categoryTanýmlar = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rownStokFisiID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsFisTipi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowdteFisTarihi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rownGirisCikis = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlFisNo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rownEvrakNo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsHareketTipi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowdteKayitTarih = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categoryFirmaBilgileri = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rownFirmaID = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsKodu = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsAciklama = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rownOzelIskontosu = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlKrediLimiti = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsFiyatTipi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowADRES = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsVergiDairesi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsVergiNo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categoryAçýklamalar = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowsAciklama1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsAciklama2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsAciklama3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsAciklama4 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowsAciklama5 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categorySorgular = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowbPesinmi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowbListelendimi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowbHizmetFaturasimi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowbFisTamamlandimi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowbMuhasebeyeIslendimi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.Panel_toplamlar = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.VGrid_iskonto = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.ds_iskonto = New System.Data.DataSet()
        Me.DataTable4 = New System.Data.DataTable()
        Me.DataColumn61 = New System.Data.DataColumn()
        Me.DataColumn62 = New System.Data.DataColumn()
        Me.DataColumn63 = New System.Data.DataColumn()
        Me.DataColumn64 = New System.Data.DataColumn()
        Me.DataColumn65 = New System.Data.DataColumn()
        Me.DataColumn66 = New System.Data.DataColumn()
        Me.EditorRow2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDIPISK1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowDIPISK2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rowlDipIskontoTutari3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.VGrid_masraf = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.ds_masraf = New System.Data.DataSet()
        Me.DataTable3 = New System.Data.DataTable()
        Me.DataColumn57 = New System.Data.DataColumn()
        Me.DataColumn58 = New System.Data.DataColumn()
        Me.DataColumn59 = New System.Data.DataColumn()
        Me.DataColumn60 = New System.Data.DataColumn()
        Me.EditorRow1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlEkMaliyet1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlEkMaliyet2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlEkMaliyet3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.VGrid_toplam = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.EditorRow3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlToplamMiktar = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlMalBedeli = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlMalIskontoTutari = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowIskonto = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.EditorRow4 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowEkMaliyet = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.rownKdvOrani1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.row_lKdvMatrahi1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowlNetTutar = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.Panel_satir = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.Panel_hareket = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
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
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_Renk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_hareket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_toplam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_baslik.SuspendLayout()
        CType(Me.VGrid_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_toplamlar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_toplamlar.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.VGrid_iskonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_iskonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.VGrid_masraf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_masraf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.VGrid_toplam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_satir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_satir.SuspendLayout()
        CType(Me.Panel_hareket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_hareket.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_Renk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MultiEditorRowProperties1
        '
        Me.MultiEditorRowProperties1.Caption = "Ýskonto1"
        Me.MultiEditorRowProperties1.FieldName = "nDipIskontoYuzdesi1"
        '
        'MultiEditorRowProperties2
        '
        Me.MultiEditorRowProperties2.FieldName = "lDipIskontoTutari1"
        '
        'MultiEditorRowProperties3
        '
        Me.MultiEditorRowProperties3.Caption = "Ýskonto2"
        Me.MultiEditorRowProperties3.FieldName = "nDipIskontoYuzdesi2"
        '
        'MultiEditorRowProperties4
        '
        Me.MultiEditorRowProperties4.FieldName = "lDipIskontoTutari2"
        '
        'MultiEditorRowProperties5
        '
        Me.MultiEditorRowProperties5.Caption = "Ýskonto"
        Me.MultiEditorRowProperties5.FieldName = "lMalIskontoTutari"
        '
        'MultiEditorRowProperties6
        '
        Me.MultiEditorRowProperties6.FieldName = "ISKONTO"
        Me.MultiEditorRowProperties6.Format.FormatString = "P"
        Me.MultiEditorRowProperties6.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'MultiEditorRowProperties7
        '
        Me.MultiEditorRowProperties7.Caption = "Ek Maliyet"
        Me.MultiEditorRowProperties7.FieldName = "lEkmaliyet1"
        Me.MultiEditorRowProperties7.Format.FormatString = "#,0.00"
        Me.MultiEditorRowProperties7.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'MultiEditorRowProperties8
        '
        Me.MultiEditorRowProperties8.FieldName = "EkOran"
        Me.MultiEditorRowProperties8.Format.FormatString = "P"
        Me.MultiEditorRowProperties8.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MultiEditorRowProperties8.ReadOnly = True
        '
        'ds_baslik
        '
        Me.ds_baslik.DataSetName = "NewDataSet"
        Me.ds_baslik.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_baslik.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn76})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nFirmaID"
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
        Me.DataColumn4.ColumnName = "nOzelIskontosu"
        Me.DataColumn4.DataType = GetType(Decimal)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "lKrediLimiti"
        Me.DataColumn5.DataType = GetType(Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sFiyatTipi"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "ADRES"
        Me.DataColumn7.DataType = GetType(System.TimeSpan)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sVergiDairesi "
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sVergiNo"
        Me.DataColumn9.DataType = GetType(System.TimeSpan)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "nStokFisiID"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sFisTipi"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "dteFisTarihi"
        Me.DataColumn12.DataType = GetType(Date)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "nGirisCikis"
        Me.DataColumn13.DataType = GetType(System.TimeSpan)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "lFisNo"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "bPesinmi"
        Me.DataColumn15.DataType = GetType(Boolean)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "bListelendimi"
        Me.DataColumn16.DataType = GetType(Boolean)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "bHizmetFaturasimi"
        Me.DataColumn17.DataType = GetType(Boolean)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "bFisTamamlandimi"
        Me.DataColumn18.DataType = GetType(Boolean)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "bMuhasebeyeIslendimi"
        Me.DataColumn19.DataType = GetType(Boolean)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sHareketTipi"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "dteKayitTarih"
        Me.DataColumn21.DataType = GetType(Date)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "sAciklama1"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "sAciklama2"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "sAciklama3"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "sAciklama4"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "sAciklama5"
        '
        'DataColumn76
        '
        Me.DataColumn76.ColumnName = "nEvrakNo"
        '
        'ds_hareket
        '
        Me.ds_hareket.DataSetName = "NewDataSet"
        Me.ds_hareket.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_hareket.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn75})
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
        'ds_toplam
        '
        Me.ds_toplam.DataSetName = "NewDataSet"
        Me.ds_toplam.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_toplam.Tables.AddRange(New System.Data.DataTable() {Me.DataTable5})
        '
        'DataTable5
        '
        Me.DataTable5.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn67, Me.DataColumn68, Me.DataColumn69, Me.DataColumn70, Me.DataColumn71, Me.DataColumn72, Me.DataColumn73, Me.DataColumn74})
        Me.DataTable5.TableName = "Table1"
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "nStokFisiID"
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "lToplamMiktar"
        Me.DataColumn68.DataType = GetType(Decimal)
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "lMalBedeli"
        Me.DataColumn69.DataType = GetType(Decimal)
        '
        'DataColumn70
        '
        Me.DataColumn70.ColumnName = "lMalIskontoTutari"
        Me.DataColumn70.DataType = GetType(Decimal)
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "lEkmaliyet1"
        Me.DataColumn71.DataType = GetType(Decimal)
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "nKdvOrani1"
        Me.DataColumn72.DataType = GetType(Decimal)
        '
        'DataColumn73
        '
        Me.DataColumn73.ColumnName = " lKdvMatrahi1"
        Me.DataColumn73.DataType = GetType(Decimal)
        '
        'DataColumn74
        '
        Me.DataColumn74.ColumnName = "lNetTutar"
        Me.DataColumn74.DataType = GetType(Decimal)
        '
        'BarManager1
        '
        Me.BarManager1.AllowCustomization = False
        Me.BarManager1.AllowMoveBarOnToolbar = False
        Me.BarManager1.AllowQuickCustomization = False
        Me.BarManager1.AllowShowToolbarsPopup = False
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarSubItem2, Me.BarSubItem3, Me.BarSubItem4, Me.BarSubItem5, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarSubItem6, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem15, Me.BarButtonItem16, Me.BarButtonItem17, Me.BarButtonItem18, Me.BarButtonItem19, Me.BarButtonItem20, Me.BarButtonItem21, Me.BarButtonItem22, Me.BarButtonItem23, Me.BarButtonItem24, Me.BarButtonItem25, Me.BarButtonItem26, Me.BarButtonItem27, Me.BarButtonItem28, Me.BarButtonItem29, Me.BarButtonItem30, Me.BarButtonItem31, Me.BarButtonItem32, Me.BarButtonItem33, Me.BarButtonItem34})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 40
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem5)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Custom 3"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Belge"
        Me.BarSubItem1.Id = 0
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem14, True)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Belge Dizayn"
        Me.BarButtonItem11.Id = 16
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Belge Önizle"
        Me.BarButtonItem12.Id = 17
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Belge Yazdýr"
        Me.BarButtonItem13.Id = 18
        Me.BarButtonItem13.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2)
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "Belgeyi Ýptal Et"
        Me.BarButtonItem14.Id = 19
        Me.BarButtonItem14.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y))
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Satýr"
        Me.BarSubItem2.Id = 1
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem27), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem28)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarButtonItem27
        '
        Me.BarButtonItem27.Caption = "Stok Kartý"
        Me.BarButtonItem27.Id = 32
        Me.BarButtonItem27.Name = "BarButtonItem27"
        '
        'BarButtonItem28
        '
        Me.BarButtonItem28.Caption = "Stok Ýsimleri"
        Me.BarButtonItem28.Id = 33
        Me.BarButtonItem28.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
        Me.BarButtonItem28.Name = "BarButtonItem28"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "Araçlar"
        Me.BarSubItem3.Id = 2
        Me.BarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem26, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem29), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem30), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem31), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem32, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem33), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem34)})
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Hesap Makinesi"
        Me.BarButtonItem3.Id = 7
        Me.BarButtonItem3.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F1))
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem26
        '
        Me.BarButtonItem26.Caption = "Faturalaþtýr"
        Me.BarButtonItem26.Id = 31
        Me.BarButtonItem26.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F3))
        Me.BarButtonItem26.Name = "BarButtonItem26"
        '
        'BarButtonItem29
        '
        Me.BarButtonItem29.Caption = "Tarih/BelgeNo Deðiþtir"
        Me.BarButtonItem29.Id = 34
        Me.BarButtonItem29.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F4))
        Me.BarButtonItem29.Name = "BarButtonItem29"
        '
        'BarButtonItem30
        '
        Me.BarButtonItem30.Caption = "Cari Kart"
        Me.BarButtonItem30.Id = 35
        Me.BarButtonItem30.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5)
        Me.BarButtonItem30.Name = "BarButtonItem30"
        '
        'BarButtonItem31
        '
        Me.BarButtonItem31.Caption = "Stok Kartý"
        Me.BarButtonItem31.Id = 36
        Me.BarButtonItem31.Name = "BarButtonItem31"
        '
        'BarButtonItem32
        '
        Me.BarButtonItem32.Caption = "Faturayý Al Ayný"
        Me.BarButtonItem32.Id = 37
        Me.BarButtonItem32.Name = "BarButtonItem32"
        '
        'BarButtonItem33
        '
        Me.BarButtonItem33.Caption = "Faturayý Al Ters"
        Me.BarButtonItem33.Id = 38
        Me.BarButtonItem33.Name = "BarButtonItem33"
        '
        'BarButtonItem34
        '
        Me.BarButtonItem34.Caption = "Faturayý Al Ters Kod+Ýsimle Kontrol"
        Me.BarButtonItem34.Id = 39
        Me.BarButtonItem34.Name = "BarButtonItem34"
        '
        'BarSubItem4
        '
        Me.BarSubItem4.Caption = "Analiz"
        Me.BarSubItem4.Id = 3
        Me.BarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem15), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem23), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem16, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem24), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem25)})
        Me.BarSubItem4.Name = "BarSubItem4"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Kar/Zarar Analizi"
        Me.BarButtonItem4.Id = 9
        Me.BarButtonItem4.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z))
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Envanter"
        Me.BarButtonItem5.Id = 10
        Me.BarButtonItem5.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Envanter Model"
        Me.BarButtonItem6.Id = 11
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Kdv Analizi"
        Me.BarButtonItem7.Id = 12
        Me.BarButtonItem7.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K))
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Stok Hareketleri"
        Me.BarButtonItem8.Id = 13
        Me.BarButtonItem8.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "Stok Fiyatlarý"
        Me.BarButtonItem15.Id = 20
        Me.BarButtonItem15.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
        Me.BarButtonItem15.Name = "BarButtonItem15"
        '
        'BarButtonItem23
        '
        Me.BarButtonItem23.Caption = "Stok Fiyatlarý Tümü"
        Me.BarButtonItem23.Id = 28
        Me.BarButtonItem23.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F))
        Me.BarButtonItem23.Name = "BarButtonItem23"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Cari Hareketleri"
        Me.BarButtonItem9.Id = 14
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Cari Kartý"
        Me.BarButtonItem10.Id = 15
        Me.BarButtonItem10.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F5))
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem16
        '
        Me.BarButtonItem16.Caption = "Firma Bekleyen Sipariþler"
        Me.BarButtonItem16.Id = 21
        Me.BarButtonItem16.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8)
        Me.BarButtonItem16.Name = "BarButtonItem16"
        '
        'BarButtonItem24
        '
        Me.BarButtonItem24.Caption = "Müþteri Bekleyen Sipariþler"
        Me.BarButtonItem24.Id = 29
        Me.BarButtonItem24.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F8))
        Me.BarButtonItem24.Name = "BarButtonItem24"
        '
        'BarButtonItem25
        '
        Me.BarButtonItem25.Caption = "Stoklar Bekleyen Karþýlama Durumu"
        Me.BarButtonItem25.Id = 30
        Me.BarButtonItem25.Name = "BarButtonItem25"
        '
        'BarSubItem6
        '
        Me.BarSubItem6.Caption = "Görünüm"
        Me.BarSubItem6.Id = 8
        Me.BarSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem17), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem18), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem19), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem20), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem21), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem22, True)})
        Me.BarSubItem6.Name = "BarSubItem6"
        '
        'BarButtonItem17
        '
        Me.BarButtonItem17.Caption = "Baþlýk"
        Me.BarButtonItem17.Id = 22
        Me.BarButtonItem17.Name = "BarButtonItem17"
        '
        'BarButtonItem18
        '
        Me.BarButtonItem18.Caption = "Hareketler"
        Me.BarButtonItem18.Id = 23
        Me.BarButtonItem18.Name = "BarButtonItem18"
        '
        'BarButtonItem19
        '
        Me.BarButtonItem19.Caption = "Toplamlar"
        Me.BarButtonItem19.Id = 24
        Me.BarButtonItem19.Name = "BarButtonItem19"
        '
        'BarButtonItem20
        '
        Me.BarButtonItem20.Caption = "Masraflar"
        Me.BarButtonItem20.Id = 25
        Me.BarButtonItem20.Name = "BarButtonItem20"
        '
        'BarButtonItem21
        '
        Me.BarButtonItem21.Caption = "Dip Ýskontolar"
        Me.BarButtonItem21.Id = 26
        Me.BarButtonItem21.Name = "BarButtonItem21"
        '
        'BarButtonItem22
        '
        Me.BarButtonItem22.Caption = "Görünümü Kaydet"
        Me.BarButtonItem22.Id = 27
        Me.BarButtonItem22.Name = "BarButtonItem22"
        '
        'BarSubItem5
        '
        Me.BarSubItem5.Caption = "Ekran"
        Me.BarSubItem5.Id = 4
        Me.BarSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2)})
        Me.BarSubItem5.Name = "BarSubItem5"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Tam Ekran"
        Me.BarButtonItem2.Id = 6
        Me.BarButtonItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Custom 4"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Custom 4"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Status"
        Me.BarButtonItem1.Id = 5
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(824, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 584)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 24)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 562)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 562)
        '
        'Panel_baslik
        '
        Me.Panel_baslik.Controls.Add(Me.VGrid_baslik)
        Me.Panel_baslik.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_baslik.Location = New System.Drawing.Point(0, 22)
        Me.Panel_baslik.Name = "Panel_baslik"
        Me.Panel_baslik.Size = New System.Drawing.Size(824, 160)
        Me.Panel_baslik.TabIndex = 4
        '
        'VGrid_baslik
        '
        Me.VGrid_baslik.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.VGrid_baslik.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.VGrid_baslik.Appearance.Empty.Options.UseBackColor = True
        Me.VGrid_baslik.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.VGrid_baslik.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.Transparent
        Me.VGrid_baslik.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.VGrid_baslik.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VGrid_baslik.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.VGrid_baslik.CustomizationFormBounds = New System.Drawing.Rectangle(484, 166, 208, 252)
        Me.VGrid_baslik.DataMember = Nothing
        Me.VGrid_baslik.DataSource = Me.ds_baslik
        Me.VGrid_baslik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGrid_baslik.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.BandsView
        Me.VGrid_baslik.Location = New System.Drawing.Point(2, 2)
        Me.VGrid_baslik.Name = "VGrid_baslik"
        Me.VGrid_baslik.RecordWidth = 112
        Me.VGrid_baslik.RowHeaderWidth = 102
        Me.VGrid_baslik.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.categoryTanýmlar, Me.categoryFirmaBilgileri, Me.categoryAçýklamalar, Me.categorySorgular})
        Me.VGrid_baslik.Size = New System.Drawing.Size(820, 156)
        Me.VGrid_baslik.TabIndex = 0
        Me.VGrid_baslik.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView
        '
        'categoryTanýmlar
        '
        Me.categoryTanýmlar.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rownStokFisiID, Me.rowsFisTipi, Me.rowdteFisTarihi, Me.rownGirisCikis, Me.rowlFisNo, Me.rownEvrakNo, Me.rowsHareketTipi, Me.rowdteKayitTarih})
        Me.categoryTanýmlar.Name = "categoryTanýmlar"
        Me.categoryTanýmlar.Properties.Caption = "Tanýmlar"
        '
        'rownStokFisiID
        '
        Me.rownStokFisiID.Name = "rownStokFisiID"
        Me.rownStokFisiID.Properties.Caption = "Kayýt No"
        Me.rownStokFisiID.Properties.FieldName = "nStokFisiID"
        '
        'rowsFisTipi
        '
        Me.rowsFisTipi.Name = "rowsFisTipi"
        Me.rowsFisTipi.Properties.Caption = "FisTipi"
        Me.rowsFisTipi.Properties.FieldName = "sFisTipi"
        '
        'rowdteFisTarihi
        '
        Me.rowdteFisTarihi.Name = "rowdteFisTarihi"
        Me.rowdteFisTarihi.Properties.Caption = "Tarih"
        Me.rowdteFisTarihi.Properties.FieldName = "dteFisTarihi"
        '
        'rownGirisCikis
        '
        Me.rownGirisCikis.Name = "rownGirisCikis"
        Me.rownGirisCikis.Properties.Caption = "Giriþ/Çýkýþ"
        Me.rownGirisCikis.Properties.FieldName = "nGirisCikis"
        '
        'rowlFisNo
        '
        Me.rowlFisNo.Name = "rowlFisNo"
        Me.rowlFisNo.Properties.Caption = "Belge No"
        Me.rowlFisNo.Properties.FieldName = "lFisNo"
        '
        'rownEvrakNo
        '
        Me.rownEvrakNo.Name = "rownEvrakNo"
        Me.rownEvrakNo.Properties.Caption = "Evrak No"
        Me.rownEvrakNo.Properties.FieldName = "nEvrakNo"
        '
        'rowsHareketTipi
        '
        Me.rowsHareketTipi.Name = "rowsHareketTipi"
        Me.rowsHareketTipi.Properties.Caption = "Hareket Tipi"
        Me.rowsHareketTipi.Properties.FieldName = "sHareketTipi"
        '
        'rowdteKayitTarih
        '
        Me.rowdteKayitTarih.Name = "rowdteKayitTarih"
        Me.rowdteKayitTarih.Properties.Caption = "Kayýt Saati"
        Me.rowdteKayitTarih.Properties.FieldName = "dteKayitTarihi"
        Me.rowdteKayitTarih.Properties.Format.FormatString = "HH:mm"
        Me.rowdteKayitTarih.Properties.Format.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'categoryFirmaBilgileri
        '
        Me.categoryFirmaBilgileri.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rownFirmaID, Me.rowsKodu, Me.rowsAciklama, Me.rownOzelIskontosu, Me.rowlKrediLimiti, Me.rowsFiyatTipi, Me.rowADRES, Me.rowsVergiDairesi, Me.rowsVergiNo})
        Me.categoryFirmaBilgileri.Name = "categoryFirmaBilgileri"
        Me.categoryFirmaBilgileri.Properties.Caption = "FirmaBilgileri"
        '
        'rownFirmaID
        '
        Me.rownFirmaID.Name = "rownFirmaID"
        Me.rownFirmaID.Properties.Caption = "Firma No"
        Me.rownFirmaID.Properties.FieldName = "nFirmaID"
        Me.rownFirmaID.Visible = False
        '
        'rowsKodu
        '
        Me.rowsKodu.Height = 16
        Me.rowsKodu.Name = "rowsKodu"
        Me.rowsKodu.Properties.Caption = "Firma Kodu"
        Me.rowsKodu.Properties.FieldName = "sKodu"
        '
        'rowsAciklama
        '
        Me.rowsAciklama.Name = "rowsAciklama"
        Me.rowsAciklama.Properties.Caption = "Firma Adý"
        Me.rowsAciklama.Properties.FieldName = "sAciklama"
        '
        'rownOzelIskontosu
        '
        Me.rownOzelIskontosu.Name = "rownOzelIskontosu"
        Me.rownOzelIskontosu.Properties.Caption = "ÝskontoOraný"
        Me.rownOzelIskontosu.Properties.FieldName = "nOzelIskontosu"
        '
        'rowlKrediLimiti
        '
        Me.rowlKrediLimiti.Name = "rowlKrediLimiti"
        Me.rowlKrediLimiti.Properties.Caption = "Kredi Limiti"
        Me.rowlKrediLimiti.Properties.FieldName = "lKrediLimiti"
        Me.rowlKrediLimiti.Visible = False
        '
        'rowsFiyatTipi
        '
        Me.rowsFiyatTipi.Name = "rowsFiyatTipi"
        Me.rowsFiyatTipi.Properties.Caption = "FiyatTipi"
        Me.rowsFiyatTipi.Properties.FieldName = "sFiyatTipi"
        Me.rowsFiyatTipi.Visible = False
        '
        'rowADRES
        '
        Me.rowADRES.Name = "rowADRES"
        Me.rowADRES.Properties.Caption = "Adres"
        Me.rowADRES.Properties.FieldName = "ADRES"
        '
        'rowsVergiDairesi
        '
        Me.rowsVergiDairesi.Name = "rowsVergiDairesi"
        Me.rowsVergiDairesi.Properties.Caption = "VergiDairesi "
        Me.rowsVergiDairesi.Properties.FieldName = "sVergiDairesi "
        '
        'rowsVergiNo
        '
        Me.rowsVergiNo.Name = "rowsVergiNo"
        Me.rowsVergiNo.Properties.Caption = "Vergi No"
        Me.rowsVergiNo.Properties.FieldName = "sVergiNo"
        '
        'categoryAçýklamalar
        '
        Me.categoryAçýklamalar.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowsAciklama1, Me.rowsAciklama2, Me.rowsAciklama3, Me.rowsAciklama4, Me.rowsAciklama5})
        Me.categoryAçýklamalar.Name = "categoryAçýklamalar"
        Me.categoryAçýklamalar.Properties.Caption = "Açýklamalar"
        '
        'rowsAciklama1
        '
        Me.rowsAciklama1.Name = "rowsAciklama1"
        Me.rowsAciklama1.Properties.Caption = "Açýklama 1"
        Me.rowsAciklama1.Properties.FieldName = "sAciklama1"
        '
        'rowsAciklama2
        '
        Me.rowsAciklama2.Name = "rowsAciklama2"
        Me.rowsAciklama2.Properties.Caption = "Açýklama 2"
        Me.rowsAciklama2.Properties.FieldName = "sAciklama2"
        '
        'rowsAciklama3
        '
        Me.rowsAciklama3.Name = "rowsAciklama3"
        Me.rowsAciklama3.Properties.Caption = "Açýklama 3"
        Me.rowsAciklama3.Properties.FieldName = "sAciklama3"
        '
        'rowsAciklama4
        '
        Me.rowsAciklama4.Name = "rowsAciklama4"
        Me.rowsAciklama4.Properties.Caption = "Açýklama 4"
        Me.rowsAciklama4.Properties.FieldName = "sAciklama4"
        '
        'rowsAciklama5
        '
        Me.rowsAciklama5.Name = "rowsAciklama5"
        Me.rowsAciklama5.Properties.Caption = "Açýklama 5"
        Me.rowsAciklama5.Properties.FieldName = "sAciklama5"
        '
        'categorySorgular
        '
        Me.categorySorgular.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowbPesinmi, Me.rowbListelendimi, Me.rowbHizmetFaturasimi, Me.rowbFisTamamlandimi, Me.rowbMuhasebeyeIslendimi})
        Me.categorySorgular.Name = "categorySorgular"
        Me.categorySorgular.Properties.Caption = "Sorgular"
        Me.categorySorgular.Visible = False
        '
        'rowbPesinmi
        '
        Me.rowbPesinmi.Name = "rowbPesinmi"
        Me.rowbPesinmi.Properties.Caption = "Pesinmi?"
        Me.rowbPesinmi.Properties.FieldName = "bPesinmi"
        '
        'rowbListelendimi
        '
        Me.rowbListelendimi.Name = "rowbListelendimi"
        Me.rowbListelendimi.Properties.Caption = "Listelendimi?"
        Me.rowbListelendimi.Properties.FieldName = "bListelendimi"
        '
        'rowbHizmetFaturasimi
        '
        Me.rowbHizmetFaturasimi.Name = "rowbHizmetFaturasimi"
        Me.rowbHizmetFaturasimi.Properties.Caption = "HizmetFaturasimi?"
        Me.rowbHizmetFaturasimi.Properties.FieldName = "bHizmetFaturasimi"
        '
        'rowbFisTamamlandimi
        '
        Me.rowbFisTamamlandimi.Name = "rowbFisTamamlandimi"
        Me.rowbFisTamamlandimi.Properties.Caption = "Fiþ Tamamlandýmý ?"
        Me.rowbFisTamamlandimi.Properties.FieldName = "bFisTamamlandimi"
        '
        'rowbMuhasebeyeIslendimi
        '
        Me.rowbMuhasebeyeIslendimi.Name = "rowbMuhasebeyeIslendimi"
        Me.rowbMuhasebeyeIslendimi.Properties.Caption = "Muhasebeye Ýþlendimi?"
        Me.rowbMuhasebeyeIslendimi.Properties.FieldName = "bMuhasebeyeIslendimi"
        '
        'Panel_toplamlar
        '
        Me.Panel_toplamlar.Controls.Add(Me.GroupControl3)
        Me.Panel_toplamlar.Controls.Add(Me.GroupControl2)
        Me.Panel_toplamlar.Controls.Add(Me.GroupControl1)
        Me.Panel_toplamlar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_toplamlar.Location = New System.Drawing.Point(0, 464)
        Me.Panel_toplamlar.Name = "Panel_toplamlar"
        Me.Panel_toplamlar.Size = New System.Drawing.Size(824, 120)
        Me.Panel_toplamlar.TabIndex = 5
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.VGrid_iskonto)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(264, 2)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(318, 116)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "DipÝskontolar"
        '
        'VGrid_iskonto
        '
        Me.VGrid_iskonto.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.VGrid_iskonto.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.VGrid_iskonto.Appearance.Empty.Options.UseBackColor = True
        Me.VGrid_iskonto.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.VGrid_iskonto.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.Transparent
        Me.VGrid_iskonto.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.VGrid_iskonto.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VGrid_iskonto.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.VGrid_iskonto.CustomizationFormBounds = New System.Drawing.Rectangle(358, 323, 208, 252)
        Me.VGrid_iskonto.DataMember = Nothing
        Me.VGrid_iskonto.DataSource = Me.ds_iskonto
        Me.VGrid_iskonto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGrid_iskonto.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
        Me.VGrid_iskonto.Location = New System.Drawing.Point(2, 15)
        Me.VGrid_iskonto.Name = "VGrid_iskonto"
        Me.VGrid_iskonto.RecordWidth = 115
        Me.VGrid_iskonto.RowHeaderWidth = 85
        Me.VGrid_iskonto.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.EditorRow2, Me.rowDIPISK1, Me.rowDIPISK2, Me.rowlDipIskontoTutari3})
        Me.VGrid_iskonto.Size = New System.Drawing.Size(314, 99)
        Me.VGrid_iskonto.TabIndex = 0
        '
        'ds_iskonto
        '
        Me.ds_iskonto.DataSetName = "NewDataSet"
        Me.ds_iskonto.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_iskonto.Tables.AddRange(New System.Data.DataTable() {Me.DataTable4})
        '
        'DataTable4
        '
        Me.DataTable4.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66})
        Me.DataTable4.TableName = "Table1"
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "nStokFisiID"
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "nDipIskontoYuzdesi1"
        Me.DataColumn62.DataType = GetType(Decimal)
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "lDipIskontoTutari1"
        Me.DataColumn63.DataType = GetType(Decimal)
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "nDipIskontoYuzdesi2"
        Me.DataColumn64.DataType = GetType(Decimal)
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "lDipIskontoTutari2"
        Me.DataColumn65.DataType = GetType(Decimal)
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "lDipIskontoTutari3"
        Me.DataColumn66.DataType = GetType(Decimal)
        '
        'EditorRow2
        '
        Me.EditorRow2.Name = "EditorRow2"
        Me.EditorRow2.Properties.Caption = "Stok Fiþi ID"
        Me.EditorRow2.Properties.FieldName = "nStokFisiID"
        Me.EditorRow2.Visible = False
        '
        'rowDIPISK1
        '
        Me.rowDIPISK1.Name = "rowDIPISK1"
        Me.rowDIPISK1.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties1, Me.MultiEditorRowProperties2})
        '
        'rowDIPISK2
        '
        Me.rowDIPISK2.Height = 16
        Me.rowDIPISK2.Name = "rowDIPISK2"
        Me.rowDIPISK2.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties3, Me.MultiEditorRowProperties4})
        '
        'rowlDipIskontoTutari3
        '
        Me.rowlDipIskontoTutari3.Name = "rowlDipIskontoTutari3"
        Me.rowlDipIskontoTutari3.Properties.Caption = "Ýskonto3Tutarý"
        Me.rowlDipIskontoTutari3.Properties.FieldName = "lDipIskontoTutari3"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.VGrid_masraf)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl2.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(262, 116)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Masraflar/Maliyetler"
        '
        'VGrid_masraf
        '
        Me.VGrid_masraf.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.VGrid_masraf.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.VGrid_masraf.Appearance.Empty.Options.UseBackColor = True
        Me.VGrid_masraf.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.VGrid_masraf.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.Transparent
        Me.VGrid_masraf.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.VGrid_masraf.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VGrid_masraf.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.VGrid_masraf.CustomizationFormBounds = New System.Drawing.Rectangle(766, 435, 208, 252)
        Me.VGrid_masraf.DataMember = Nothing
        Me.VGrid_masraf.DataSource = Me.ds_masraf
        Me.VGrid_masraf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGrid_masraf.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
        Me.VGrid_masraf.Location = New System.Drawing.Point(2, 15)
        Me.VGrid_masraf.Name = "VGrid_masraf"
        Me.VGrid_masraf.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.EditorRow1, Me.rowlEkMaliyet1, Me.rowlEkMaliyet2, Me.rowlEkMaliyet3})
        Me.VGrid_masraf.Size = New System.Drawing.Size(258, 99)
        Me.VGrid_masraf.TabIndex = 0
        '
        'ds_masraf
        '
        Me.ds_masraf.DataSetName = "NewDataSet"
        Me.ds_masraf.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_masraf.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "nStokFisiID"
        Me.DataColumn57.DataType = GetType(Long)
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "lEkMaliyet1"
        Me.DataColumn58.DataType = GetType(Decimal)
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "lEkMaliyet2"
        Me.DataColumn59.DataType = GetType(Decimal)
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "lEkMaliyet3"
        Me.DataColumn60.DataType = GetType(Decimal)
        '
        'EditorRow1
        '
        Me.EditorRow1.Name = "EditorRow1"
        Me.EditorRow1.Properties.Caption = "Stok Fiþi ID"
        Me.EditorRow1.Properties.FieldName = "nStokFisiID"
        Me.EditorRow1.Visible = False
        '
        'rowlEkMaliyet1
        '
        Me.rowlEkMaliyet1.Name = "rowlEkMaliyet1"
        Me.rowlEkMaliyet1.Properties.Caption = "Ek Maliyet 1"
        Me.rowlEkMaliyet1.Properties.FieldName = "lEkMaliyet1"
        '
        'rowlEkMaliyet2
        '
        Me.rowlEkMaliyet2.Name = "rowlEkMaliyet2"
        Me.rowlEkMaliyet2.Properties.Caption = "Ek Maliyet 2"
        Me.rowlEkMaliyet2.Properties.FieldName = "lEkMaliyet2"
        '
        'rowlEkMaliyet3
        '
        Me.rowlEkMaliyet3.Name = "rowlEkMaliyet3"
        Me.rowlEkMaliyet3.Properties.Caption = "Ek Maliyet 3"
        Me.rowlEkMaliyet3.Properties.FieldName = "lEkMaliyet3"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.VGrid_toplam)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl1.Location = New System.Drawing.Point(582, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(240, 116)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "FaturaToplamlarý"
        '
        'VGrid_toplam
        '
        Me.VGrid_toplam.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.VGrid_toplam.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.VGrid_toplam.Appearance.Empty.Options.UseBackColor = True
        Me.VGrid_toplam.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.VGrid_toplam.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.Transparent
        Me.VGrid_toplam.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.VGrid_toplam.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VGrid_toplam.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.VGrid_toplam.CustomizationFormBounds = New System.Drawing.Rectangle(613, 352, 208, 252)
        Me.VGrid_toplam.DataMember = Nothing
        Me.VGrid_toplam.DataSource = Me.ds_toplam
        Me.VGrid_toplam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGrid_toplam.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
        Me.VGrid_toplam.Location = New System.Drawing.Point(2, 15)
        Me.VGrid_toplam.Name = "VGrid_toplam"
        Me.VGrid_toplam.OptionsBehavior.Editable = False
        Me.VGrid_toplam.OptionsBehavior.ResizeRowHeaders = False
        Me.VGrid_toplam.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.EditorRow3, Me.rowlToplamMiktar, Me.rowlMalBedeli, Me.rowlMalIskontoTutari, Me.rowIskonto, Me.EditorRow4, Me.rowEkMaliyet, Me.rownKdvOrani1, Me.row_lKdvMatrahi1, Me.rowlNetTutar})
        Me.VGrid_toplam.Size = New System.Drawing.Size(236, 99)
        Me.VGrid_toplam.TabIndex = 0
        '
        'EditorRow3
        '
        Me.EditorRow3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.EditorRow3.Appearance.Options.UseFont = True
        Me.EditorRow3.Name = "EditorRow3"
        Me.EditorRow3.Properties.Caption = "Stok Fiþi ID"
        Me.EditorRow3.Properties.FieldName = "nStokFisiID"
        Me.EditorRow3.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.EditorRow3.Visible = False
        '
        'rowlToplamMiktar
        '
        Me.rowlToplamMiktar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rowlToplamMiktar.Appearance.Options.UseFont = True
        Me.rowlToplamMiktar.Name = "rowlToplamMiktar"
        Me.rowlToplamMiktar.Properties.Caption = "Toplam Miktar"
        Me.rowlToplamMiktar.Properties.FieldName = "lToplamMiktar"
        Me.rowlToplamMiktar.Properties.Format.FormatString = "#,0.00"
        Me.rowlToplamMiktar.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rowlToplamMiktar.Visible = False
        '
        'rowlMalBedeli
        '
        Me.rowlMalBedeli.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rowlMalBedeli.Appearance.Options.UseFont = True
        Me.rowlMalBedeli.Name = "rowlMalBedeli"
        Me.rowlMalBedeli.Properties.Caption = "Mal Bedeli"
        Me.rowlMalBedeli.Properties.FieldName = "lMalBedeli"
        Me.rowlMalBedeli.Properties.Format.FormatString = "#,0.00"
        Me.rowlMalBedeli.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowlMalIskontoTutari
        '
        Me.rowlMalIskontoTutari.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rowlMalIskontoTutari.Appearance.Options.UseFont = True
        Me.rowlMalIskontoTutari.Name = "rowlMalIskontoTutari"
        Me.rowlMalIskontoTutari.Properties.Caption = "Ýskonto Tutarý"
        Me.rowlMalIskontoTutari.Properties.FieldName = "lMalIskontoTutari"
        Me.rowlMalIskontoTutari.Properties.Format.FormatString = "#,0.00"
        Me.rowlMalIskontoTutari.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rowlMalIskontoTutari.Visible = False
        '
        'rowIskonto
        '
        Me.rowIskonto.Name = "rowIskonto"
        Me.rowIskonto.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties5, Me.MultiEditorRowProperties6})
        '
        'EditorRow4
        '
        Me.EditorRow4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.EditorRow4.Appearance.Options.UseFont = True
        Me.EditorRow4.Name = "EditorRow4"
        Me.EditorRow4.Properties.Caption = "Ek Maliyet"
        Me.EditorRow4.Properties.FieldName = "lEkmaliyet1"
        Me.EditorRow4.Properties.Format.FormatString = "#,0.00"
        Me.EditorRow4.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.EditorRow4.Visible = False
        '
        'rowEkMaliyet
        '
        Me.rowEkMaliyet.Name = "rowEkMaliyet"
        Me.rowEkMaliyet.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties7, Me.MultiEditorRowProperties8})
        '
        'rownKdvOrani1
        '
        Me.rownKdvOrani1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rownKdvOrani1.Appearance.Options.UseFont = True
        Me.rownKdvOrani1.Name = "rownKdvOrani1"
        Me.rownKdvOrani1.Properties.Caption = "Kdv"
        Me.rownKdvOrani1.Properties.FieldName = "nKdvOrani1"
        Me.rownKdvOrani1.Properties.Format.FormatString = "#,0.00"
        Me.rownKdvOrani1.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'row_lKdvMatrahi1
        '
        Me.row_lKdvMatrahi1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.row_lKdvMatrahi1.Appearance.Options.UseFont = True
        Me.row_lKdvMatrahi1.Name = "row_lKdvMatrahi1"
        Me.row_lKdvMatrahi1.Properties.Caption = " KdvMatrahi"
        Me.row_lKdvMatrahi1.Properties.FieldName = " lKdvMatrahi1"
        Me.row_lKdvMatrahi1.Properties.Format.FormatString = "#,0.00"
        Me.row_lKdvMatrahi1.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.row_lKdvMatrahi1.Visible = False
        '
        'rowlNetTutar
        '
        Me.rowlNetTutar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.rowlNetTutar.Appearance.ForeColor = System.Drawing.Color.Red
        Me.rowlNetTutar.Appearance.Options.UseFont = True
        Me.rowlNetTutar.Appearance.Options.UseForeColor = True
        Me.rowlNetTutar.Name = "rowlNetTutar"
        Me.rowlNetTutar.Properties.Caption = "Yekün"
        Me.rowlNetTutar.Properties.FieldName = "lNetTutar"
        Me.rowlNetTutar.Properties.Format.FormatString = "#,0.00"
        Me.rowlNetTutar.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'Panel_satir
        '
        Me.Panel_satir.Controls.Add(Me.Label2)
        Me.Panel_satir.Controls.Add(Me.Label1)
        Me.Panel_satir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_satir.Location = New System.Drawing.Point(0, 440)
        Me.Panel_satir.Name = "Panel_satir"
        Me.Panel_satir.Size = New System.Drawing.Size(824, 24)
        Me.Panel_satir.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Appearance.ForeColor = System.Drawing.Color.Purple
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(69, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "satýr % / %"
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "satýr % / %"
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterControl1.Location = New System.Drawing.Point(0, 182)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(824, 6)
        Me.SplitterControl1.TabIndex = 7
        Me.SplitterControl1.TabStop = False
        '
        'Panel_hareket
        '
        Me.Panel_hareket.Controls.Add(Me.GridControl1)
        Me.Panel_hareket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_hareket.Location = New System.Drawing.Point(0, 188)
        Me.Panel_hareket.Name = "Panel_hareket"
        Me.Panel_hareket.Size = New System.Drawing.Size(824, 252)
        Me.Panel_hareket.TabIndex = 8
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.ds_hareket
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_Renk})
        Me.GridControl1.Size = New System.Drawing.Size(820, 248)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnStokFisiID, Me.colsKodu, Me.colsAciklama, Me.collGirisMiktar1, Me.collGirisMiktar2, Me.collGirisFiyat, Me.collGirisTutar, Me.colnIskontoYuzdesi, Me.collIskontoTutari, Me.colsDovizCinsi, Me.collDovizFiyat, Me.colnSiparisID, Me.colISKONTOLAR, Me.coldteIrsaliyeTarihi, Me.collIrsaliyeNo, Me.colsDepo, Me.colnStokID, Me.colnFirmaID, Me.colnIrsaliyeFisiID, Me.colsStokIslem, Me.colnOTVOrani, Me.colnKdvOrani, Me.colnIslemID, Me.colGERCEKFIYAT, Me.colGERCEKTOPLAM, Me.colISK1, Me.colISK2, Me.colISK3, Me.colISK4, Me.colEKMASRAF, Me.collBrutFiyat, Me.collBrutTutar, Me.colONCEKIMALIYET, Me.colsRenk})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(573, 256, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 12
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colnStokFisiID
        '
        Me.colnStokFisiID.Caption = "Evrak No"
        Me.colnStokFisiID.FieldName = "nStokFisiID"
        Me.colnStokFisiID.Name = "colnStokFisiID"
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Stok Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", "{0} Kayýt")})
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 0
        Me.colsKodu.Width = 86
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Stok Adý"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 1
        Me.colsAciklama.Width = 164
        '
        'collGirisMiktar1
        '
        Me.collGirisMiktar1.Caption = "Miktar1"
        Me.collGirisMiktar1.DisplayFormat.FormatString = "#,0.##"
        Me.collGirisMiktar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGirisMiktar1.FieldName = "lGirisMiktar1"
        Me.collGirisMiktar1.Name = "collGirisMiktar1"
        Me.collGirisMiktar1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGirisMiktar1", "{0:#,0.##}")})
        Me.collGirisMiktar1.Visible = True
        Me.collGirisMiktar1.VisibleIndex = 2
        Me.collGirisMiktar1.Width = 46
        '
        'collGirisMiktar2
        '
        Me.collGirisMiktar2.Caption = "Miktar2"
        Me.collGirisMiktar2.FieldName = "lGirisMiktar2"
        Me.collGirisMiktar2.Name = "collGirisMiktar2"
        '
        'collGirisFiyat
        '
        Me.collGirisFiyat.Caption = "Birim Fiyat"
        Me.collGirisFiyat.DisplayFormat.FormatString = "#,0.00"
        Me.collGirisFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGirisFiyat.FieldName = "lGirisFiyat"
        Me.collGirisFiyat.Name = "collGirisFiyat"
        Me.collGirisFiyat.Width = 58
        '
        'collGirisTutar
        '
        Me.collGirisTutar.Caption = "Birim Tutar"
        Me.collGirisTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collGirisTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGirisTutar.FieldName = "lGirisTutar"
        Me.collGirisTutar.Name = "collGirisTutar"
        Me.collGirisTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGirisTutar", "{0:#,0.00}")})
        Me.collGirisTutar.Width = 51
        '
        'colnIskontoYuzdesi
        '
        Me.colnIskontoYuzdesi.Caption = "%TopIsk"
        Me.colnIskontoYuzdesi.FieldName = "nIskontoYuzdesi"
        Me.colnIskontoYuzdesi.Name = "colnIskontoYuzdesi"
        '
        'collIskontoTutari
        '
        Me.collIskontoTutari.Caption = "Iskonto"
        Me.collIskontoTutari.FieldName = "lIskontoTutari"
        Me.collIskontoTutari.Name = "collIskontoTutari"
        '
        'colsDovizCinsi
        '
        Me.colsDovizCinsi.Caption = "Pb"
        Me.colsDovizCinsi.FieldName = "sDovizCinsi"
        Me.colsDovizCinsi.Name = "colsDovizCinsi"
        Me.colsDovizCinsi.Width = 30
        '
        'collDovizFiyat
        '
        Me.collDovizFiyat.Caption = "Döviz Fiyatý"
        Me.collDovizFiyat.FieldName = "lDovizFiyat"
        Me.collDovizFiyat.Name = "collDovizFiyat"
        Me.collDovizFiyat.Width = 51
        '
        'colnSiparisID
        '
        Me.colnSiparisID.Caption = "Sipariþ No"
        Me.colnSiparisID.FieldName = "nSiparisID"
        Me.colnSiparisID.Name = "colnSiparisID"
        '
        'colISKONTOLAR
        '
        Me.colISKONTOLAR.Caption = "Ýskontolar"
        Me.colISKONTOLAR.FieldName = "ISKONTOLAR"
        Me.colISKONTOLAR.Name = "colISKONTOLAR"
        Me.colISKONTOLAR.Width = 77
        '
        'coldteIrsaliyeTarihi
        '
        Me.coldteIrsaliyeTarihi.Caption = "Ýrsaliye Tarihi"
        Me.coldteIrsaliyeTarihi.FieldName = "dteIrsaliyeTarihi"
        Me.coldteIrsaliyeTarihi.Name = "coldteIrsaliyeTarihi"
        '
        'collIrsaliyeNo
        '
        Me.collIrsaliyeNo.Caption = "Ýrsaliye No"
        Me.collIrsaliyeNo.FieldName = "lIrsaliyeNo"
        Me.collIrsaliyeNo.Name = "collIrsaliyeNo"
        '
        'colsDepo
        '
        Me.colsDepo.Caption = "Depo"
        Me.colsDepo.FieldName = "sDepo"
        Me.colsDepo.Name = "colsDepo"
        Me.colsDepo.Visible = True
        Me.colsDepo.VisibleIndex = 5
        Me.colsDepo.Width = 36
        '
        'colnStokID
        '
        Me.colnStokID.Caption = "Stok No"
        Me.colnStokID.FieldName = "nStokID"
        Me.colnStokID.Name = "colnStokID"
        '
        'colnFirmaID
        '
        Me.colnFirmaID.Caption = "Firma No"
        Me.colnFirmaID.FieldName = "nFirmaID"
        Me.colnFirmaID.Name = "colnFirmaID"
        '
        'colnIrsaliyeFisiID
        '
        Me.colnIrsaliyeFisiID.Caption = "IrsaliyeFisiNo"
        Me.colnIrsaliyeFisiID.FieldName = "nIrsaliyeFisiID"
        Me.colnIrsaliyeFisiID.Name = "colnIrsaliyeFisiID"
        '
        'colsStokIslem
        '
        Me.colsStokIslem.Caption = "Stok Ýþlem"
        Me.colsStokIslem.FieldName = "sStokIslem"
        Me.colsStokIslem.Name = "colsStokIslem"
        '
        'colnOTVOrani
        '
        Me.colnOTVOrani.Caption = "Otv"
        Me.colnOTVOrani.FieldName = "nOTVOrani"
        Me.colnOTVOrani.Name = "colnOTVOrani"
        '
        'colnKdvOrani
        '
        Me.colnKdvOrani.Caption = "Kdv"
        Me.colnKdvOrani.DisplayFormat.FormatString = "#,0.##"
        Me.colnKdvOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnKdvOrani.FieldName = "nKdvOrani"
        Me.colnKdvOrani.Name = "colnKdvOrani"
        Me.colnKdvOrani.Visible = True
        Me.colnKdvOrani.VisibleIndex = 6
        Me.colnKdvOrani.Width = 29
        '
        'colnIslemID
        '
        Me.colnIslemID.Caption = "Kayýt No"
        Me.colnIslemID.FieldName = "nIslemID"
        Me.colnIslemID.Name = "colnIslemID"
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
        Me.colGERCEKFIYAT.Visible = True
        Me.colGERCEKFIYAT.VisibleIndex = 13
        Me.colGERCEKFIYAT.Width = 90
        '
        'colGERCEKTOPLAM
        '
        Me.colGERCEKTOPLAM.Caption = "GerçekToplam"
        Me.colGERCEKTOPLAM.DisplayFormat.FormatString = "#,0.00"
        Me.colGERCEKTOPLAM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGERCEKTOPLAM.FieldName = "GERCEKTOPLAM"
        Me.colGERCEKTOPLAM.Name = "colGERCEKTOPLAM"
        Me.colGERCEKTOPLAM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GERCEKTOPLAM", "{0:#,0.00}")})
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
        Me.colISK1.Visible = True
        Me.colISK1.VisibleIndex = 7
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
        Me.colISK2.Visible = True
        Me.colISK2.VisibleIndex = 8
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
        Me.colISK3.Visible = True
        Me.colISK3.VisibleIndex = 9
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
        Me.colISK4.Visible = True
        Me.colISK4.VisibleIndex = 10
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
        Me.colEKMASRAF.Visible = True
        Me.colEKMASRAF.VisibleIndex = 11
        Me.colEKMASRAF.Width = 29
        '
        'collBrutFiyat
        '
        Me.collBrutFiyat.Caption = "Fiyat"
        Me.collBrutFiyat.DisplayFormat.FormatString = "#,0.00"
        Me.collBrutFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutFiyat.FieldName = "lBrutFiyat"
        Me.collBrutFiyat.Name = "collBrutFiyat"
        Me.collBrutFiyat.Visible = True
        Me.collBrutFiyat.VisibleIndex = 3
        Me.collBrutFiyat.Width = 46
        '
        'collBrutTutar
        '
        Me.collBrutTutar.Caption = "Tutar"
        Me.collBrutTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collBrutTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutTutar.FieldName = "lBrutTutar"
        Me.collBrutTutar.Name = "collBrutTutar"
        Me.collBrutTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBrutTutar", "{0:#,0.00}")})
        Me.collBrutTutar.Visible = True
        Me.collBrutTutar.VisibleIndex = 4
        Me.collBrutTutar.Width = 55
        '
        'colONCEKIMALIYET
        '
        Me.colONCEKIMALIYET.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colONCEKIMALIYET.AppearanceCell.Options.UseForeColor = True
        Me.colONCEKIMALIYET.Caption = "Önceki Maliyet"
        Me.colONCEKIMALIYET.DisplayFormat.FormatString = "#,0.00"
        Me.colONCEKIMALIYET.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colONCEKIMALIYET.FieldName = "ONCEKIMALIYET"
        Me.colONCEKIMALIYET.Name = "colONCEKIMALIYET"
        Me.colONCEKIMALIYET.Visible = True
        Me.colONCEKIMALIYET.VisibleIndex = 12
        Me.colONCEKIMALIYET.Width = 62
        '
        'colsRenk
        '
        Me.colsRenk.Caption = "Renk"
        Me.colsRenk.ColumnEdit = Me.sec_Renk
        Me.colsRenk.FieldName = "sRenk"
        Me.colsRenk.Name = "colsRenk"
        '
        'sec_Renk
        '
        Me.sec_Renk.AutoHeight = False
        Me.sec_Renk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_Renk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sRenkAdi", "sRenk")})
        Me.sec_Renk.DisplayMember = "sRenkAdi"
        Me.sec_Renk.Name = "sec_Renk"
        Me.sec_Renk.ValueMember = "sRenk"
        '
        'frm_stok_cari_alis
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 608)
        Me.Controls.Add(Me.Panel_hareket)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.Panel_satir)
        Me.Controls.Add(Me.Panel_toplamlar)
        Me.Controls.Add(Me.Panel_baslik)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_cari_alis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alýþ Faturasý"
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_hareket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_toplam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_baslik.ResumeLayout(False)
        CType(Me.VGrid_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_toplamlar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_toplamlar.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.VGrid_iskonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_iskonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.VGrid_masraf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_masraf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.VGrid_toplam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_satir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_satir.ResumeLayout(False)
        Me.Panel_satir.PerformLayout()
        CType(Me.Panel_hareket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_hareket.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_Renk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public status As Boolean
    Public connection
    Public connection_ors
    Public connection_resmi
    Public firmano
    Public donemno
    Public stokno
    Public userno
    Public kullanici
    Dim dr_baslik As DataRow
    Dim dr_hareket As DataRow
    Dim dr_toplam As DataRow
    Dim dr_masraf As DataSet
    Dim dr_iskonto As DataSet
    'Dim cmd As New OleDb.OleDbCommand
    'Dim con As New OleDb.OleDbConnection
    'Dim adapter As New OleDb.OleDbDataAdapter
    Public belgeind As Int64
    Public miktar As Decimal = 0
    Public detay_miktar As Decimal = 0
    Dim depokodu As String
    Dim dr As DataRow
    Dim ds_satici As DataSet
    Dim ds_alislar As DataSet
    Dim ds_satir_stok As DataSet
    Dim ds_satir_firma As DataSet
    Public fistipi As String
    Public tarih As DateTime
    Public firmaID As String
    Public fisno As String
    ' === SIPARIS RISK GOSTERGESI ===
    Private pnlSiparisRisk As Panel
    Private lblSiparisRisk As Label
    Public ngiriscikis As String
    Dim ds_stok As DataSet
    Dim ds_stok_fisi As DataSet
    Dim ds_stok_barkod As DataSet
    Dim ds_stok_fiyat As DataSet
    Dim ds_stok_fiyatTipi As DataSet
    Dim ds_stok_sinif As DataSet
    Dim ds_firma As DataSet
    Dim ds_renk As DataSet
    Dim ds_depo As DataSet
    Dim ds_HareketTipi As DataSet
    Dim ds_saticilar As DataSet
    Dim yuklendi As Boolean = False
    Private Sub frm_stok_cari_alis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection_resmi = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("ugurlu_resmi")
        Try
            loaded()
        Catch ex As Exception
            Me.Close()
        End Try
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        yuklendi = True
        satir_info()
        Try : SiparisRiskKontrol() : Catch : End Try
    End Sub
    Private Sub loaded()
        dataload_renk()
        dataload_baslik()
        dataload_harekets()
        satir_firma_info()
        GridControl1.Focus()
        GridControl1.Select()
        'sec_depo_baslik.DataSource = sorgu_s(sorgu_query("SELECT sDepo AS DEPOKODU, sAciklama AS DEPOADI FROM tbDepo ORDER BY sDepo")).Tables(0) 'DataSet2.Tables(0)
        'sec_depo_hareket.DataSource = sorgu_s(sorgu_query("SELECT sDepo AS DEPOKODU, sAciklama AS DEPOADI FROM tbDepo ORDER BY sDepo")).Tables(0) 'DataSet2.Tables(0)
        'dataload_satici()
        dr_baslik = ds_baslik.Tables(0).Rows(0)
        'dr_masraf = ds_masraf.Tables(0).Rows(0)
        dr_toplam = ds_toplam.Tables(0).Rows(0)
        kontrol_oran()
        fis_resmi_kayit_kontrol()
    End Sub
    Private Sub fis_resmi_kayit_kontrol()
        Dim fis_kayit_sayisi As Int64 = 0
        Dim cari_kayit_sayisi As Int64 = 0
        Dim nFirmaID As Int64 = 0
        Dim dr_cari As DataRow
        Try
            cari_kayit_sayisi = sorgu_firma_kontrol(dr_baslik("sKodu"))
        Catch ex As Exception
        End Try
        If cari_kayit_sayisi = 0 Then
            'MsgBox(dr_baslik("sKodu") & " Kodlu Firma Kaydý Bulunamadý",sDil), MessageBoxIcon.Warning)
            'dataload_cari(dr_baslik("sKodu"))
            'dr_cari = ds_firma.Tables(0).Rows(0)
            'nFirmaID = firma_kaydet_yeni(dr_cari("sKodu"), dr_cari("sAciklama"), dr_cari("nOzelIskontosu"), dr_cari("lKrediLimiti"), dr_cari("dteMutabakatTarihi"), dr_cari("nVadeGun"), dr_cari("sHitap"), dr_cari("sAdres1"), dr_cari("sAdres2"), dr_cari("sSemt"), dr_cari("sIl"), dr_cari("sUlke"), dr_cari("sPostaKodu"), dr_cari("sVergiDairesi"), dr_cari("sVergiNo"), 0, dr_cari("sOzelNot"), dr_cari("sKullaniciAdi"), dr_cari("dteKayitTarihi"), dr_cari("sFiyatTipi"))
            'firma_siniflari_kaydet_yeni(nFirmaID, "", "", "", "", "")
        Else
            nFirmaID = sorgu_nfirmaID(dr_baslik("sKodu"))
            'MsgBox(nFirmaID)
            'MsgBox(dr_baslik("sKodu") & " Kodlu Firma Kaydý Var...", sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat", sDil))
            fis_kayit_sayisi = sorgu_fis_kontrol(dr_baslik("sFisTipi"), dr_baslik("nGirisCikis"), dr_baslik("dteFisTarihi"), dr_baslik("lFisNo"), nFirmaID)
            If fis_kayit_sayisi = 0 Then
                'Me.Text = "Alýþ Faturasý" + "(Belgenin Kaydý Var...)"
            Else
                Me.Text = "Alýþ Faturasý" + " (Belgenin Resmi Kaydý Var...)"
            End If
        End If
        'fis_kayit_sayisi = sorgu_fis_kontrol(dr_baslik("sFisTipi"), dr_baslik("nGirisCikis"), dr_baslik("dteFisTarihi"), dr_baslik("lFisNo"), nFirmaID)
        'If fis_kayit_sayisi = 0 Then
        '    'Me.Text = "Alýþ Faturasý" + "(Belgenin Kaydý Var...)"
        'Else
        '    Me.Text = "Alýþ Faturasý" + "(Belgenin Resmi Kaydý Var...)"
        'End If
        fis_kayit_sayisi = Nothing
        fis_kayit_sayisi = Nothing
        cari_kayit_sayisi = Nothing
        nFirmaID = Nothing
        dr_cari = Nothing
    End Sub
    Private Sub dataload_renk()
        sec_Renk.DataSource = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbRenk")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub dataload_baslik()
        ds_baslik.Tables(0).Clear()
        ds_baslik = sorgu_baslik("")
        ds_masraf = sorgu_masraf("")
        ds_iskonto = sorgu_iskonto("")
        ds_toplam = sorgu_toplam("")
        Dim dr1 As DataRow
        For Each dr1 In ds_toplam.Tables(0).Rows
            Try
                dr1("ISKONTO") = (dr1("lMalIskontoTutari") + dr1("lDipIskontoTutari3")) / dr1("lMalBedeli")
                dr1("lMalIskontoTutari") = dr1("lMalIskontoTutari") + dr1("lDipIskontoTutari3")
                If CType(dr1("lEkmaliyet1"), Decimal) <> 0 Then
                    dr1("EkOran") = CType(dr1("lEkmaliyet1"), Decimal) / CType(dr1("lMalBedeli") - dr1("lMalIskontoTutari"), Decimal)
                End If
            Catch ex As Exception
            End Try
        Next
        dr1 = Nothing
        VGrid_baslik.DataSource = ds_baslik
        VGrid_baslik.DataMember = "BASLIK"
        VGrid_baslik.Refresh()
        VGrid_masraf.DataSource = ds_masraf
        VGrid_masraf.DataMember = "BASLIK"
        VGrid_masraf.Refresh()
        VGrid_iskonto.DataSource = ds_iskonto
        VGrid_iskonto.DataMember = "BASLIK"
        VGrid_iskonto.Refresh()
        VGrid_toplam.DataSource = ds_toplam
        VGrid_toplam.DataMember = "BASLIK"
        VGrid_toplam.Refresh()
    End Sub
    Private Sub dataload_harekets()
        ds_hareket = sorgu_harekets("")
        GridControl1.DataSource = ds_hareket.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.RefreshDataSource()
        GridControl1.Refresh()
        GridControl1.Select()
    End Sub
    Public Function sorgu_alislar(ByVal tarih As DateTime, ByVal fisno As String, ByVal stokkodu As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 2 tbStokFisiDetayi.lFisNo AS FISNO, tbStokFisiDetayi.dteFisTarihi AS TARIH, tbStokFisiDetayi.lGirisFiyat AS BIRIMMALIYET, tbStokFisiDetayi.lGirisMiktar1 AS MIKTAR, tbStokFisiDetayi.lBrutFiyat AS BIRIMFIYAT, tbStokFisiDetayi.lIskontoTutari AS ISKONTO, tbStokFisiDetayi.nKdvOrani AS KDV, tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS KDVLITUTAR, baslik.lToplamMiktar AS FATURAMIKTARI, baslik.lMalBedeli - baslik.lMalIskontoTutari AS FATURATUTARI, baslik.lEkmaliyet1 AS EKMALIYET, tbStok.sKodu AS STOKKODU, tbStok.sAciklama AS STOKADI,CAST(0 AS MONEY) AS ORANEKMALIYET,CAST(0 AS MONEY) AS NETMALIYET FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiMaster baslik ON tbStokFisiDetayi.nStokFisiID = baslik.nStokFisiID WHERE (tbStokFisiDetayi.nGirisCikis = 1) AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbStokFisiDetayi.dteFisTarihi  < '" & tarih & "') AND (tbFirma.sKodu LIKE '3%') and (tbstok.sKodu ='" & stokkodu & "') ORDER BY tbStokFisiDetayi.dteFisTarihi DESC, tbStokFisiDetayi.lFisNo")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 2 tbStokFisiDetayi.lFisNo AS FISNO, tbStokFisiDetayi.dteFisTarihi AS TARIH, tbStokFisiDetayi.lGirisFiyat AS BIRIMMALIYET, tbStokFisiDetayi.lGirisMiktar1 AS MIKTAR, tbStokFisiDetayi.lBrutFiyat AS BIRIMFIYAT, tbStokFisiDetayi.lIskontoTutari AS ISKONTO, tbStokFisiDetayi.nKdvOrani AS KDV, tbStokFisiDetayi.lGirisFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS KDVLITUTAR, baslik.lToplamMiktar AS FATURAMIKTARI, baslik.lMalBedeli - baslik.lMalIskontoTutari AS FATURATUTARI, baslik.lEkmaliyet1 AS EKMALIYET, tbStok.sKodu AS STOKKODU, tbStok.sAciklama AS STOKADI,CAST(0 AS MONEY) AS ORANEKMALIYET,CAST(0 AS MONEY) AS NETMALIYET FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiMaster baslik ON tbStokFisiDetayi.nStokFisiID = baslik.nStokFisiID WHERE (tbStokFisiDetayi.nGirisCikis = 1) AND (tbStokFisiDetayi.dteFisTarihi  < = '" & tarih & "') AND (tbFirma.sKodu LIKE '3%') AND (tbStokFisiDetayi.lFisNo <> '" & fisno & "') and (tbstok.sKodu ='" & stokkodu & "') ORDER BY tbStokFisiDetayi.dteFisTarihi DESC, tbStokFisiDetayi.lFisNo")
        cmd.Connection = con
        con.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        con.Close()
        Return Datastoklar1
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Sub kontrol_oran()
        Dim oranekmaliyet As Decimal = 0
        For Each dr In ds_hareket.Tables(0).Rows
            'dr("ISK1") = DR("Expr1")
            dr("GERCEKFIYAT") = dr("lGirisFiyat") * ((dr("nKdvOrani") + 100) / 100)
            'MsgBox(dr_toplam("lNetTutar"))
            Try
                If CType(dr_toplam("lEkmaliyet1"), Decimal) <> 0 Then
                    oranekmaliyet = CType(dr_toplam("lEkmaliyet1"), Decimal) / CType(dr_toplam("lMalBedeli") - dr_toplam("lMalIskontoTutari"), Decimal)
                    dr("EKMASRAF") = oranekmaliyet
                    dr("GERCEKFIYAT") = dr("GERCEKFIYAT") * ((100 + (oranekmaliyet * 100)) / 100)
                End If
            Catch ex As Exception
            End Try
            dr("GERCEKTOPLAM") = dr("GERCEKFIYAT") * dr("lGirisMiktar1")
            oranekmaliyet = 0
            'dr("GERCEKTOPLAM") = dr("GERCEKFIYAT") * dr("lGirisMiktar1")
            Dim dr1 As DataRow
            ds_alislar = sorgu_alislar(dr_baslik("dteFisTarihi"), dr_baslik("lFisNo"), dr("sKodu"))
            Dim sayi As Integer = 0
            For Each dr1 In ds_alislar.Tables(0).Rows
                sayi += 1
                If dr1("EKMALIYET") <> 0 Then
                    dr1("ORANEKMALIYET") = dr1("EKMALIYET") / dr1("FATURATUTARI")
                End If
                dr1("NETMALIYET") = dr1("KDVLITUTAR") * ((100 + (dr1("ORANEKMALIYET") * 100)) / 100)
                If sayi = 1 Then
                    dr("ONCEKIMALIYET") = dr1("NETMALIYET")
                    'dr("SONALISTARIHI") = dr1("TARIH")
                ElseIf sayi = 2 Then
                    'dr("ONCEKIALISMALIYETI") = dr1("NETMALIYET")
                    'dr("ONCEKIALISTARIHI") = dr1("TARIH")
                End If
            Next
        Next
    End Sub
    Private Sub gorunum_kaydet()
        VGrid_baslik.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\FA\BASLIK\" & Me.Name.ToString & "")
        VGrid_toplam.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\FA\TOPLAM\" & Me.Name.ToString & "")
        VGrid_masraf.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\FA\MASRAF\" & Me.Name.ToString & "")
        VGrid_iskonto.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\FA\ISKONTO\" & Me.Name.ToString & "")
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\FA\HAREKET\" & Me.Name.ToString & "")
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
        'VGrid_baslik.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\FA\BASLIK\" & Me.Name.ToString & "")
        'VGrid_toplam.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\FA\TOPLAM\" & Me.Name.ToString & "")
        'VGrid_masraf.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\FA\MASRAF\" & Me.Name.ToString & "")
        'VGrid_iskonto.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\FA\ISKONTO\" & Me.Name.ToString & "")
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CARI\FA\HAREKET\" & Me.Name.ToString & "")
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        calculator()
    End Sub
    Private Sub calculator()
        Dim frm As New frm_calc
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Function sorgu_baslik(ByVal kriter As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti, tbFirma.sFiyatTipi, tbFirma.sAdres1 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS ADRES, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lFisNo, tbStokFisiMaster.bPesinmi, tbStokFisiMaster.bListelendimi, tbStokFisiMaster.bHizmetFaturasimi, tbStokFisiMaster.bFisTamamlandimi, tbStokFisiMaster.bMuhasebeyeIslendimi, tbStokFisiMaster.sHareketTipi, tbStokFisiMaster.dteKayitTarihi, tbStokFisiAciklamasi.sAciklama1, tbStokFisiAciklamasi.sAciklama2, tbStokFisiAciklamasi.sAciklama3, tbStokFisiAciklamasi.sAciklama4, tbStokFisiAciklamasi.sAciklama5, tbStokFisiMaster.nEvrakNo FROM tbStokFisiMaster INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID WHERE (tbStokFisiMaster.sFisTipi = '" & fistipi & "') AND (tbStokFisiMaster.dteFisTarihi = '" & tarih & "') AND (tbStokFisiMaster.nFirmaID = '" & firmaID & "') AND (tbStokFisiMaster.lFisNo = '" & fisno & "') AND (tbStokFisiMaster.nGirisCikis = " & ngiriscikis & ")")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_stok_info(ByVal stokkodu As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TS.sBarkod, TS.STOKKODU, TS.STOKADI, TS.sRenk, TS.sBeden, TS.lAsgariMiktar, TS.lAzamiMiktar, TS.sModel, CAST(SUM(TS.GIREN) AS MONEY) AS  GIREN, CAST(SUM(TS.CIKAN) AS MONEY) AS CIKAN, CAST(SUM(TS.KALAN) AS MONEY) AS KALAN, CAST(SUM(TS.BEKLEYEN) AS MONEY) AS  BEKLEYEN, tbRenk.sRenkAdi FROM (SELECT sAciklama , SUM(GIREN) AS GIREN , SUM(CIKAN) AS CIKAN , SUM(KALAN) AS KALAN , SUM(BEKLEYEN) AS BEKLEYEN , sBarkod , STOKKODU , STOKADI , sRenk , sBeden , lAsgariMiktar , lAzamiMiktar , sModel FROM (SELECT depo.sAciklama , 0 AS GIREN , 0 AS CIKAN , 0 AS KALAN , barkod.sBarkod , stok.sKodu AS STOKKODU , stok.sAciklama AS STOKADI , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu = '" & stokkodu & "') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') GROUP BY depo.sAciklama , barkod.sBarkod , stok.sKodu , stok.sAciklama , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel UNION SELECT depo.sAciklama , ISNULL(SUM(hareket.lGirisMiktar1) , 0) AS GIREN , ISNULL(SUM(hareket.lCikisMiktar1) , 0) AS CIKAN , ISNULL(SUM(hareket.lGirisMiktar1 - hareket.lCikisMiktar1) , 0) AS KALAN , barkod.sBarkod , stok.sKodu AS STOKKODU , stok.sAciklama AS STOKADI , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , 0 AS BEKLEYEN FROM tbStokBarkodu barkod INNER JOIN tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo ON barkod.nStokID = stok.nStokID and barkod.nKisim = 0 WHERE (stok.sKodu = '" & stokkodu & "' and hareket.sFistipi <> 'T') GROUP BY depo.sAciklama , stok.nStokID , barkod.sBarkod , stok.sKodu , stok.sAciklama , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , depo.sDepo) TT GROUP BY sAciklama , sBarkod , STOKKODU , STOKADI , sRenk , sBeden , lAsgariMiktar , lAzamiMiktar , sModel) TS INNER JOIN tbRenk ON TS.sRenk COLLATE Turkish_CI_AS = tbRenk.sRenk GROUP BY TS.sBarkod, TS.STOKKODU, TS.STOKADI, TS.sRenk, TS.sBeden, TS.lAsgariMiktar, TS.lAzamiMiktar, TS.sModel, tbRenk.sRenkAdi")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_firma_info(ByVal nFirmaID As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti, SUM(tbFirmaHareketi.lBorcTutar) AS BORC, SUM(tbFirmaHareketi.lAlacakTutar) AS ALACAK, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS BAKIYE FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE tbFirma.nFirmaID ='" & nFirmaID & "' GROUP BY tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
    End Function
    Private Function sorgu_masraf(ByVal kriter As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokFisiID, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3 FROM tbStokFisiMaster WHERE (sFisTipi = '" & fistipi & "') AND (dteFisTarihi = '" & tarih & "') AND (nFirmaID = '" & firmaID & "') AND (lFisNo = '" & fisno & "') AND (nGirisCikis = " & ngiriscikis & ")")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_iskonto(ByVal kriter As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokFisiID, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3 FROM tbStokFisiMaster WHERE (sFisTipi = '" & fistipi & "') AND (dteFisTarihi = '" & tarih & "') AND (nFirmaID = '" & firmaID & "') AND (lFisNo = '" & fisno & "') AND (nGirisCikis = " & ngiriscikis & ")")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_toplam(ByVal kriter As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokFisiID, lMalIskontoTutari,lToplamMiktar, lMalBedeli, lMalIskontoTutari, lEkmaliyet1, lKdv1+lKdv2+lKdv3+lKdv4+lKdv5 as nKdvOrani1, lKdvMatrahi1, lNetTutar,CAST(0 AS MONEY) as ISKONTO,CAST(0 AS MONEY) AS EkOran,lDipIskontoTutari1 + lDipIskontoTutari2 + lDipIskontoTutari3 AS lDipIskontoTutari3 FROM tbStokFisiMaster WHERE (sFisTipi = '" & fistipi & "') AND (dteFisTarihi = '" & tarih & "') AND (nFirmaID = '" & firmaID & "') AND (lFisNo = '" & fisno & "') AND (nGirisCikis = " & ngiriscikis & ")")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_harekets(ByVal kriter As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        If Trim(fistipi) = "FA" Then
            Me.Text = "Alýþ Faturasý"
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.nStokFisiID, tbStok.sKodu, tbStok.sAciklama,tbStok.sRenk, tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.lGirisMiktar2, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.nIskontoYuzdesi, tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.sDovizCinsi, tbStokFisiDetayi.lDovizFiyat, tbStokFisiDetayi.nSiparisID, tbStokFisiDetayi.sAciklama AS Expr1, tbStokFisiDetayi.dteIrsaliyeTarihi, tbStokFisiDetayi.lIrsaliyeNo, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.nStokID, tbStokFisiDetayi.nFirmaID, tbStokFisiDetayi.nIrsaliyeFisiID, tbStokFisiDetayi.sStokIslem, tbStokFisiDetayi.nOTVOrani, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.sSaticiRumuzu,tbStokFisiDetayi.nIslemID,CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) ISK4,CAST(0 AS MONEY) AS GERCEKFIYAT,CAST(0 AS MONEY) AS GERCEKTOPLAM,CAST(0 AS MONEY) AS EKMASRAF,CAST(0 AS MONEY) AS ONCEKIMALIYET FROM tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiMaster.sFisTipi = '" & fistipi & "') AND (tbStokFisiMaster.dteFisTarihi = '" & tarih & "') AND (tbStokFisiMaster.nFirmaID = '" & firmaID & "') AND (tbStokFisiMaster.lFisNo = '" & fisno & "') AND (tbStokFisiMaster.nGirisCikis = " & ngiriscikis & ") ORDER BY tbStokFisiDetayi.nIslemID")
        ElseIf Trim(fistipi) = "FS" Then
            Me.Text = "Satýþ Faturasý"
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.nStokFisiID, tbStok.sKodu, tbStok.sAciklama,tbStok.sRenk, tbStokFisiDetayi.lCikisMiktar1 AS lGirisMiktar1, tbStokFisiDetayi.lGirisMiktar2, tbStokFisiDetayi.lCikisFiyat as lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.nIskontoYuzdesi, tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.sDovizCinsi, tbStokFisiDetayi.lDovizFiyat, tbStokFisiDetayi.nSiparisID, tbStokFisiDetayi.sAciklama AS Expr1, tbStokFisiDetayi.dteIrsaliyeTarihi, tbStokFisiDetayi.lIrsaliyeNo, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.nStokID, tbStokFisiDetayi.nFirmaID, tbStokFisiDetayi.nIrsaliyeFisiID, tbStokFisiDetayi.sStokIslem, tbStokFisiDetayi.nOTVOrani, tbStokFisiDetayi.sSaticiRumuzu,tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.nIslemID,CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) ISK4,CAST(0 AS MONEY) AS GERCEKFIYAT,CAST(0 AS MONEY) AS GERCEKTOPLAM,CAST(0 AS MONEY) AS EKMASRAF,CAST(0 AS MONEY) AS ONCEKIMALIYET FROM tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiMaster.sFisTipi = '" & fistipi & "') AND (tbStokFisiMaster.dteFisTarihi = '" & tarih & "') AND (tbStokFisiMaster.nFirmaID = '" & firmaID & "') AND (tbStokFisiMaster.lFisNo = '" & fisno & "') AND (tbStokFisiMaster.nGirisCikis = " & ngiriscikis & ") ORDER BY tbStokFisiDetayi.nIslemID")
        End If
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.nStokFisiID, tbStok.sKodu, tbStok.sAciklama,tbStok.sRenk, tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.lGirisMiktar2, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.nIskontoYuzdesi, tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.sDovizCinsi, tbStokFisiDetayi.lDovizFiyat, tbStokFisiDetayi.nSiparisID, tbStokFisiDetayi.sAciklama AS Expr1, tbStokFisiDetayi.dteIrsaliyeTarihi, tbStokFisiDetayi.lIrsaliyeNo, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.nStokID, tbStokFisiDetayi.nFirmaID, tbStokFisiDetayi.nIrsaliyeFisiID, tbStokFisiDetayi.sStokIslem, tbStokFisiDetayi.nOTVOrani, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.nIslemID,CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) ISK4,CAST(0 AS MONEY) AS GERCEKFIYAT,CAST(0 AS MONEY) AS GERCEKTOPLAM,CAST(0 AS MONEY) AS EKMASRAF,CAST(0 AS MONEY) AS ONCEKIMALIYET FROM tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiMaster.sFisTipi = '" & fistipi & "') AND (tbStokFisiMaster.dteFisTarihi = '" & tarih & "') AND (tbStokFisiMaster.nFirmaID = '" & firmaID & "') AND (tbStokFisiMaster.lFisNo = '" & fisno & "') AND (tbStokFisiMaster.nGirisCikis = " & ngiriscikis & ") ORDER BY tbStokFisiDetayÝ.nIslemID")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "HAREKET")
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_stok_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection_resmi
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbStok " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        con = Nothing
    End Function
    Public Function sorgu_nStokID(ByVal kod As String, Optional ByVal sAciklama As String = "") As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        If sAciklama = "" Then
        Else
            kriter += " AND (sAciklama = '" & sAciklama & "')"
        End If
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection_resmi
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nStokID, 0) AS nStokID FROM         tbStok " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        con = Nothing
    End Function
    Public Function sorgu_stok_sAciklama(ByVal kod As String) As String
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection_resmi
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(sAciklama, 0) AS sAciklama FROM         tbStok " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub dataload_stok(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        ds_stok = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbStok " & kriter & ""))
    End Sub
    Private Sub dataload_fis_master(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String)
        Dim kriter
        kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        ds_stok_fisi = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbStokFisiMaster " & kriter & ""))
    End Sub
    Private Sub dataload_fis_detay(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String)
        Dim kriter
        kriter = "WHERE (tbStokFisiDetayi.sFisTipi = '" & sFistipi & "') and (tbStokFisiDetayi.dteFisTarihi = '" & dteFisTarihi & "') and (tbStokFisiDetayi.lFisNo = '" & lFisno & "') and (tbStokFisiDetayi.nFirmaID= '" & nFirmaID & "') and (tbStokFisiDetayi.nGirisCikis = '" & nGirisCikis & "')  "
        ds_stok_fisi = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.*, tbStok.sKodu,tbStok.sAciklama as sStokAciklama FROM         tbStokFisiDetayi INNER JOIN                       tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & ""))
    End Sub
    Private Sub dataload_fis_firma_hareket(ByVal sFistipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String)
        Dim kriter
        kriter = "WHERE (sHangiUygulama = '" & sFistipi & "') and (dteIslemTarihi = '" & dteFisTarihi & "') and (sEvrakNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "')  "
        ds_stok_fisi = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
    End Sub
    Private Sub fis_firma_hareket_degistir(ByVal sFistipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String, ByVal ylFisno As String, ByVal ydteFisTarihi As DateTime)
        Dim kriter
        kriter = "WHERE (sHangiUygulama = '" & sFistipi & "') and (dteIslemTarihi = '" & dteFisTarihi & "') and (sEvrakNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "')  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbFirmaHareketi SET sEvrakNo= '" & ylFisno & "',sAciklama= 'Evrak No: " & ylFisno & "',dteIslemTarihi = '" & ydteFisTarihi & "',dteValorTarihi= '" & ydteFisTarihi & "'          " & kriter & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub fis_detay_degistir(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String, ByVal ylFisno As String, ByVal ydteFisTarihi As DateTime)
        Dim kriter
        kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiDetayi SET lFisNo= '" & ylFisno & "',dteIslemTarihi = '" & ydteFisTarihi & "',dteFisTarihi= '" & ydteFisTarihi & "'          " & kriter & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub fis_Master_degistir(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String, ByVal ylFisno As String, ByVal ydteFisTarihi As DateTime, ByVal nEvrakNo As String)
        Dim kriter
        kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiMaster SET lFisNo= '" & ylFisno & "',dteFisTarihi = '" & ydteFisTarihi & "',dteValorTarihi= '" & ydteFisTarihi & "', nEvrakNo = '" & nEvrakNo & "'          " & kriter & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub fis_Master_fisno_degistir(ByVal nstokFisiID As String)
        'kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection_resmi
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = '" & nstokFisiID & "' where nSiraIndex = 2")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub fis_detay_fisno_degistir(ByVal nstokIslemID As String)
        'kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection_resmi
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = '" & nstokIslemID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub fis_Master_nCariHareketID_degistir(ByVal nCariHareketID As String)
        'kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection_resmi
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = '" & nCariHareketID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub dataload_fis_aciklama(ByVal nStokFisiID As String)
        Dim kriter
        kriter = "WHERE (nStokFisiID = '" & nStokFisiID & "') "
        ds_stok_fisi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM           tbStokFisiAciklamasi " & kriter & ""))
    End Sub
    Private Sub dataload_stok_barkod(ByVal nStokID As String)
        Dim kriter
        kriter = "WHERE (nStokID = '" & nStokID & "') "
        ds_stok_barkod = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbStokBarkodu " & kriter & ""))
    End Sub
    Private Sub dataload_stok_fiyat(ByVal nStokID As String)
        Dim kriter
        kriter = "WHERE (nStokID = '" & nStokID & "') "
        ds_stok_fiyat = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbStokFiyati " & kriter & ""))
    End Sub
    Private Sub dataload_stok_fiyatTipi()
        ds_stok_fiyatTipi = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbFiyatTipi"))
    End Sub
    Private Sub dataload_depo(ByVal sDepo As String)
        Dim kriter
        kriter = "WHERE (sDepo = '" & sDepo & "') "
        ds_depo = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbDepo " & kriter & ""))
    End Sub
    Private Sub dataload_HareketTipi(ByVal sHareketTipi As String)
        Dim kriter
        kriter = "WHERE (sHareketTipi = '" & sHareketTipi & "') and (aktif = 1) "
        ds_HareketTipi = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbHareketTipi " & kriter & ""))
    End Sub
    Private Sub dataload_satici(ByVal sSaticiRumuzu As String)
        Dim kriter
        kriter = "WHERE (sSaticiRumuzu = '" & sSaticiRumuzu & "') "
        ds_saticilar = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbSatici " & kriter & ""))
    End Sub
    Private Sub dataload_stok_sinif(ByVal nStokID As String)
        Dim kriter
        kriter = "WHERE (nStokID = '" & nStokID & "') "
        ds_stok_sinif = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbStokSinifi " & kriter & ""))
    End Sub
    Private Sub dataload_stok_sinif1(ByVal sStokSinifi As String, ByVal sinifno As Integer)
        Dim kriter
        kriter = "WHERE (sSinifKodu = '" & sStokSinifi & "') "
        ds_stok_sinif = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM          tbSSinif" & sinifno & " " & kriter & ""))
    End Sub
    Private Sub dataload_cari(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        ds_firma = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirma " & kriter & ""))
    End Sub
    Private Sub dataload_sRenk(ByVal sRenk As String)
        Dim kriter
        kriter = "WHERE (sRenk = '" & sRenk & "') "
        ds_renk = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbRenk " & kriter & ""))
    End Sub
    Public Function sorgu_firma_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        'MsgBox(connection_resmi)
        con.ConnectionString = connection_resmi
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbFirma " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        con.Close()
        Return kayitsayisi
        cmd = Nothing
        con = Nothing
    End Function
    Public Function sorgu_fis_kontrol(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String, Optional ByVal resmi As Boolean = True) As Int64
        Dim kriter
        kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        'MsgBox(connection_resmi)
        If resmi = True Then
            con.ConnectionString = connection_resmi
        ElseIf resmi = False Then
            con.ConnectionString = connection
        End If
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbStokFisiMaster " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        con.Close()
        Return kayitsayisi
        cmd = Nothing
        con = Nothing
    End Function
    Public Function sorgu_nfirmaID(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        'MsgBox(connection_resmi)
        con.ConnectionString = connection_resmi
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nFirmaID,0) AS nFirmaID FROM         tbFirma " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        con = Nothing
    End Function
    Public Function sorgu_nStokFisiID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        'MsgBox(connection_resmi)
        con.ConnectionString = connection_resmi
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nStokFisiID+1,0) AS nStokFisiID FROM         tbStokFisiMaster " & kriter & " Order by nStokFisiID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        con.Close()
        Return kayitsayisi
        cmd = Nothing
        con = Nothing
    End Function
    Public Function sorgu_nStokIslemID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        'MsgBox(connection_resmi)
        con.ConnectionString = connection_resmi
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nIslemID + 1, 0) AS nStokIslemID  FROM         tbStokFisiDetayi " & kriter & " ORDER BY nIslemID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        con.Close()
        Return kayitsayisi
        cmd = Nothing
        con = Nothing
    End Function
    Private Function sorgu(ByVal query As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_nCariHareketID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        'MsgBox(connection_resmi)
        con.ConnectionString = connection_resmi
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nHareketID + 1, 0) AS nCariHareketID  FROM         tbFirmaHareketi " & kriter & " ORDER BY nHareketID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        con.Close()
        Return kayitsayisi
        cmd = Nothing
        con = Nothing
    End Function
    Public Function sorgu_Renk_kontrol(ByVal sRenk As String) As Int64
        Dim kriter
        kriter = "WHERE (sRenk = '" & sRenk & "')  "
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection_resmi
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbRenk " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        con.Close()
        Return kayitsayisi
        cmd = Nothing
        con = Nothing
    End Function
    Public Function sorgu_Satici_kontrol(ByVal sSaticiRumuzu As String) As Int64
        Dim kriter
        kriter = "WHERE (sSaticiRumuzu = '" & sSaticiRumuzu & "')  "
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection_resmi
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbSatici " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        con.Close()
        Return kayitsayisi
        cmd = Nothing
        con = Nothing
    End Function
    Public Function sorgu_Sinif_kontrol(ByVal sSinifKodu As String, ByVal sinifno As Integer) As Int64
        Dim kriter
        kriter = "WHERE (sSinifKodu = '" & sSinifKodu & "')  "
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        'MsgBox(connection_resmi)
        con.ConnectionString = connection_resmi
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM          tbSSinif" & sinifno & " " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        con.Close()
        Return kayitsayisi
        cmd = Nothing
        con = Nothing
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Function columnuzunlukinteger_sifir(ByVal deger As String, ByVal uzunluk As Integer) As String
        Dim stringhedef = Trim(deger)
        Dim hedefuzunluk = Len(stringhedef)
        If Len(stringhedef) < uzunluk Then
            Dim fark = uzunluk - hedefuzunluk
            Dim i As Integer
            For i = 1 To fark
                stringhedef = stringhedef.Insert(0, "0")
            Next
            fark = Nothing
            i = Nothing
        Else
            stringhedef = Microsoft.VisualBasic.Left(stringhedef, uzunluk)
        End If
        Return stringhedef
    End Function
    Private Sub analiz_envanter()
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
    End Sub
    Private Sub analiz_Firma_karti()
        Dim frm As New frm_firma_kart
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sKodu = dr_baslik("sKodu")
        frm.nFirmaID = dr_baslik("nFirmaID")
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub analiz_stok_adi()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim stok_kayit_sayisi As Int64 = 0
            stok_kayit_sayisi = sorgu_stok_kontrol(Trim(dr("sKodu")))
            If stok_kayit_sayisi = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Resmi Stok Kaydý Bulunumadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim frm As New frm_stok_karti_adi
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.connection_resmi = connection_resmi
                frm.nStokID = dr("nStokId")
                frm.txt_stokkodu.Text = dr("sKodu")
                frm.txt_aciklama1.Text = dr("sAciklama")
                frm.nStokID_resmi = sorgu_nStokID(Trim(dr("sKodu")))
                frm.txt_aciklama2.Text = sorgu_stok_sAciklama(Trim(dr("sKodu")))
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
    Private Sub analiz_bekleyen(ByVal stoklar As String)
        Dim frm As New frm_satis_bekleyen_onaysiz
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.kasiyerno = kasiyerno
        'frm.kasiyer = kasiyer
        'frm.stokkodu = stokkodu
        frm.stoklar = stoklar
        frm.tarih1 = "01/01/1900"
        frm.tarih2 = "31/12/2048"
        'frm.qstokkodu = "Eþittir"
        frm.islemstatus = True
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub analiz_bekleyen_stok_durum(ByVal stoklar As String)
        Dim frm As New frm_satis_bekleyen_stok_durum
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.stokkodu = stokkodu
        frm.status = True
        frm.stoklar = stoklar
        frm.islemstatus = False
        'frm.tarih1 = "01/01/1900"
        'frm.tarih2 = "31/12/2048"
        'frm.qstokkodu = "Eþittir"
        frm.islemstatus = True
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
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
            frm.nFirmaID = dr("nFirmaID")
            frm.sec_firma.Checked = True
            frm.sec_giris.Text = "Giriþler"
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_siparis_bekleyen_tumu()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_siparis_verilen_bekleyen
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr_baslik("sKodu")
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
    Private Sub analiz_cari_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_hareketler_ozet
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr_baslik("sKodu")
            'frm.nFirmaID = dr("nFirmaID")
            'frm.sec_firma.Checked = True
            'frm.sec_giris.Text = "Giriþler"
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(dr_baslik("sKodu")))) = True Then
                    frm.ShowDialog()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_stok_karlilik()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_stok_karlilik
        frm.status = True
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.stokno = dr("STOKNO")
        frm.stokkodu = dr("sKodu")
        frm.qstokkodu = "Eþittir"
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub analiz_karlilik_tumu(ByVal stoklar As String)
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_stok_karlilik
        frm.status = True
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.stoklar = stoklar
        frm.qstoklar = "Eþittir"
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub analiz_karlilik()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_stok_cari_alis_karlilik
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.fistipi = fistipi
        frm.tarih = tarih
        frm.firmaID = firmaID
        frm.fisno = fisno
        frm.nGirisCikis = ngiriscikis
        frm.kullanici = kullanici
        If Decimal.Parse(GridView1.GetRowCellValue(0, "nKdvOrani").ToString()) = 0 Then
            frm.bKdvKontrolluMaliyet = "True"
        Else
            frm.bKdvKontrolluMaliyet = "False"
        End If
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub satir_info()
        Try
            If GridView1.RowCount > 0 Then
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                ds_satir_stok = sorgu_stok_info(dr("sKodu"))
                Dim dr1 As DataRow = ds_satir_stok.Tables(0).Rows(0)
                If dr1("sRenkAdi").ToString <> "" Then
                    Label2.Text = dr1("STOKADI") & " (Renk: " & dr1("sRenkAdi") & ") Giren: " & dr1("GIREN") & " Çýkan: " & dr1("CIKAN") & " Mevcut: " & dr1("KALAN") & " Bekleyen: " & dr1("BEKLEYEN")
                Else
                    Label2.Text = dr1("STOKADI") & " Giren: " & dr1("GIREN") & " Çýkan: " & dr1("CIKAN") & " Mevcut: " & dr1("KALAN") & " Bekleyen: " & dr1("BEKLEYEN")
                End If
                'Label2.Text = dr1("STOKADI") & " Renk: " & dr1("sRenkAdi") & " Giren: " & dr1("GIREN") & "Çýkan: " & dr1("CIKAN") & " Kalan: " & dr1("KALAN") & " Bekleyen: " & dr1("BEKLEYEN")
                Label2.Refresh()
                dr1 = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub satir_firma_info()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            ds_satir_firma = sorgu_firma_info(dr("nFirmaID"))
            Dim dr1 As DataRow = ds_satir_firma.Tables(0).Rows(0)
            BarButtonItem1.Caption = dr1("sAciklama") & vbTab & "    Iskontosu: " & dr1("nOzelIskontosu") & " Kredilimiti: " & dr1("lKrediLimiti") & "   Borç: " & FormatNumber(dr1("BORC"), 2) & "   Alacak: " & FormatNumber(dr1("ALACAK"), 2) & "   Bakiye: " & FormatNumber(dr1("BAKIYE"), 2)
            Label2.Refresh()
            dr1 = Nothing
        End If
    End Sub
    Private Function satir_kontrol(Optional ByVal etiket As Boolean = False)
        Dim satir As String = " ("
        If etiket = True Then
            satir = "WHERE stok.nStokId IN ("
        End If
        Dim toplamsayi = GridView1.RowCount
        Dim sayi = 0
        Dim dr1 As DataRow
        For Each dr1 In ds_hareket.Tables(0).Rows
            satir += dr1("nStokID").ToString
            sayi += 1
            If sayi < toplamsayi Then
                satir += ","
            ElseIf sayi = toplamsayi Then
                satir += ")"
            End If
        Next
        Return satir
    End Function
    Private Sub raporla(ByVal rapor As Integer, ByVal islem As Integer)
        Dim file As String
        Dim kriter As String = ""
        OpenFileDialog1.Title = "Rapor Seç..."
        If Trim(dr_baslik("sFisTipi")) = "FS" Then
            OpenFileDialog1.Filter = "Rapor Dosyalarý (Fatura_Satis*.fr3) |Fatura_Satis*.fr3"
            OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Dokumler\Fatura_Satis.fr3"
            OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Dokumler"
            kriter = " vwSatisFaturasi WHERE     (Fis_TanimlamaNo = " & dr_baslik("nStokFisiID") & ") AND (Fis_Tarihi = '" & dr_baslik("dteFisTarihi") & "') AND (Fis_No = " & dr_baslik("lFisNo") & ")"
        ElseIf Trim(dr_baslik("sFisTipi")) = "FA" Then
            OpenFileDialog1.Filter = "Rapor Dosyalarý (Fatura_Alis*.fr3) |Fatura_Alis*.fr3"
            OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Dokumler\Fatura_Alis.fr3"
            OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Dokumler"
            kriter = " vwAlisFaturasi WHERE     (Fis_TanimlamaNo = " & dr_baslik("nStokFisiID") & ") AND (Fis_Tarihi = '" & dr_baslik("dteFisTarihi") & "') AND (Fis_No = " & dr_baslik("lFisNo") & ")"
        End If
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            report_create_stok(file, kriter, islem)
        End If
    End Sub
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim ds1 As New TfrxUserDataSetClass
            Dim qr_baslik As New TfrxADOQuery
            Dim qr_hareket As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            'qr_hareket.CommandTimeout = Nothing
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT * FROM " & kriter & " ")
            frx.OldStyleProgress = True
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_baslik.DataBase = qr_connection
            qr_hareket.DataBase = qr_connection
            If status = 0 Then
                frx.PreviewOptions.ZoomMode = frxZoomMode.zm_PageWidth
                frx.DisableDialogs = True
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
            End If
            qr_hareket = Nothing
            qr_connection = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(2) = "" & sorgu_query("set transaction isolation level read uncommitted SELECT * FROM " & kriter & " ") & ""
            args(3) = "qr_hareket"
            args(4) = "" & status.ToString() & ""
            args(5) = "4"
            args(6) = "FIRMANO"
            args(7) = "" & firmano.ToString() & ""
            args(8) = "DONEMNO"
            args(9) = "" & donemno.ToString() & ""
            args(10) = "STOKNO"
            args(11) = "" & stokno.ToString() & ""
            args(12) = "SATIRLINE"
            args(13) = "'" & satir_line.ToString() & "'"
            processYol = args(0)
            For i As Integer = 1 To 13
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
    Private Function stok_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal sKisaAdi As String, ByVal nStokTipi As Int64, ByVal sBedenTipi As String, ByVal sKavalaTipi As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sKavala As String, ByVal sBirimCinsi1 As String, ByVal sBirimCinsi2 As String, ByVal nIskontoYuzdesi As Decimal, ByVal sKdvTipi As String, ByVal nTeminSuresi As Decimal, ByVal lAsgariMiktar As Decimal, ByVal lAzamiMiktar As Decimal, ByVal sOzelNot As String, ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bEksiyeDusulebilirmi As Byte, ByVal sDefaultAsortiTipi As String, ByVal bEksideUyarsinmi As Byte, ByVal bOTVVar As Byte, ByVal sOTVTipi As String, ByVal nIskontoYuzdesiAV As Decimal, ByVal bEk1 As Byte, ByVal nEk2 As String) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStok                       (sKodu, sAciklama, sKisaAdi, nStokTipi, sBedenTipi, sKavalaTipi, sRenk, sBeden, sKavala, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi, nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, sModel, sKullaniciAdi, dteKayitTarihi, bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2) VALUES     ('" & sKodu & "', N'" & sAciklama & "', '" & sKisaAdi & "', '" & nStokTipi & "', '" & sBedenTipi & "', '" & sKavalaTipi & "', '" & sRenk & "', '" & sBeden & "', '" & sKavala & "', '" & sBirimCinsi1 & "', '" & sBirimCinsi2 & "', " & nIskontoYuzdesi & " , '" & sKdvTipi & "', " & nTeminSuresi & " , " & lAsgariMiktar & " , " & lAzamiMiktar & " , '" & sOzelNot & "', '" & nFiyatlandirma & "', '" & sModel & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bEksiyeDusulebilirmi & " , '" & sDefaultAsortiTipi & "', " & bEksideUyarsinmi & " , " & bOTVVar & " , '" & sOTVTipi & "' , '" & nIskontoYuzdesiAV & "', '" & bEk1 & "', '" & nEk2 & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        cmd = Nothing
        con = Nothing
        Return hareketno
    End Function
    Private Function firma_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal nOzelIskontosu As Decimal, ByVal lKrediLimiti As Decimal, ByVal dteMutabakatTarihi As DateTime, ByVal nVadeGun As Int64, ByVal sHitap As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal nHesapID As Int64, ByVal sOzelNot As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sFiyatTipi As String) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbFirma                       (sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, dteMutabakatTarihi, nVadeGun, sHitap, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, nHesapID, sOzelNot, sKullaniciAdi, dteKayitTarihi, sFiyatTipi) VALUES     ('" & sKodu & "', N'" & sAciklama & "', " & nOzelIskontosu & ", " & lKrediLimiti & ", '" & dteMutabakatTarihi & "', " & nVadeGun & " , '" & sHitap & "', '" & sAdres1 & "', '" & sAdres2 & "', '" & sSemt & "', '" & sIl & "', '" & sUlke & "', '" & sPostaKodu & "',  '" & sVergiDairesi & "', '" & sVergiNo & "', " & nHesapID & " , '" & sOzelNot & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sFiyatTipi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        cmd = Nothing
        con = Nothing
        Return hareketno
    End Function
    Private Function master_kaydet_yeni(ByVal nStokFisiID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal nGirisCikis As Int64, ByVal lFisNo As Int64, ByVal nFirmaID As Int64, ByVal sDepo As String, ByVal dteValorTarihi As DateTime, ByVal bPesinmi As Byte, ByVal bListelendimi As Byte, ByVal bHizmetFaturasimi As Byte, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi1 As Decimal, ByVal lDipIskontoTutari1 As Decimal, ByVal nDipIskontoYuzdesi2 As Decimal, ByVal lDipIskontoTutari2 As Decimal, ByVal lDipIskontoTutari3 As Decimal, ByVal lEkmaliyet1 As Decimal, ByVal lEkmaliyet2 As Decimal, ByVal lEkmaliyet3 As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lNetTutar As Decimal, ByVal nTevkifatKdvOrani As Decimal, ByVal lTevkifatKdvMatrahi As Decimal, ByVal lTevkifatKdv As Decimal, ByVal sCariIslem As String, ByVal nCariHareketID As String, ByVal nKasaIslemID As String, ByVal sCariKdvIslem As String, ByVal nCariKdvHareketID As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal bFisTamamlandimi As Byte, ByVal lTransferFisiID As Int64, ByVal nTransferFirmaID As String, ByVal sTransferDepo As String, ByVal bFaturayaDonustumu As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sYaziIle As String, ByVal nOTVOrani1 As Decimal, ByVal lOTVMatrahi1 As Decimal, ByVal lOTV1 As Decimal, ByVal nOTVOrani2 As Decimal, ByVal lOTVMatrahi2 As Decimal, ByVal lOTV2 As Decimal, ByVal nEvrakNo As String) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If

        ' === PARAMETRIK VALOR TARIHI KONTROLU ===
        ' tbSistemAyar'dan VALOR_TARIHI_ZORUNLU ayarini kontrol et
        If bPesinmi = 0 AndAlso nFirmaID > 0 Then
            Try
                Dim cmdAyar As New OleDb.OleDbCommand
                cmdAyar.Connection = con
                cmdAyar.CommandText = sorgu_query("SELECT ISNULL(sAyarDeger,'0') FROM tbSistemAyar WHERE sAyarKodu='VALOR_TARIHI_ZORUNLU'")
                Dim sValorZorunlu As String = ""
                Try : sValorZorunlu = cmdAyar.ExecuteScalar().ToString() : Catch : End Try

                If sValorZorunlu = "1" AndAlso dteValorTarihi.Date = dteFisTarihi.Date Then
                    ' Firma kartindan vade gun bilgisini al
                    cmdAyar.CommandText = sorgu_query("SELECT ISNULL(nVadeGun,0) FROM tbFirma WHERE nFirmaID=" & nFirmaID)
                    Dim nVadeGunFirma As Integer = 0
                    Try : nVadeGunFirma = CInt(cmdAyar.ExecuteScalar()) : Catch : End Try
                    If nVadeGunFirma > 0 Then
                        dteValorTarihi = dteFisTarihi.AddDays(nVadeGunFirma)
                    End If
                End If

                ' === KREDI LIMIT KONTROLU (Opsiyonel) ===
                cmdAyar.CommandText = sorgu_query("SELECT ISNULL(sAyarDeger,'0') FROM tbSistemAyar WHERE sAyarKodu='SIPARIS_LIMIT_KONTROL'")
                Dim sLimitKontrol As String = ""
                Try : sLimitKontrol = cmdAyar.ExecuteScalar().ToString() : Catch : End Try

                If sLimitKontrol = "1" Then
                    cmdAyar.CommandText = sorgu_query("SELECT ISNULL(lKrediLimiti,0) FROM tbFirma WHERE nFirmaID=" & nFirmaID)
                    Dim lKrediLimiti As Decimal = 0
                    Try : lKrediLimiti = CDec(cmdAyar.ExecuteScalar()) : Catch : End Try

                    If lKrediLimiti > 0 Then
                        cmdAyar.CommandText = sorgu_query("SELECT ISNULL(SUM(CASE WHEN sBorcAlacak='B' THEN lTutar ELSE 0 END),0) - ISNULL(SUM(CASE WHEN sBorcAlacak='A' THEN lTutar ELSE 0 END),0) FROM tbFirmaHareketi WHERE nFirmaID=" & nFirmaID)
                        Dim lMevcutBakiye As Decimal = 0
                        Try : lMevcutBakiye = CDec(cmdAyar.ExecuteScalar()) : Catch : End Try

                        If (lMevcutBakiye + lNetTutar) > lKrediLimiti Then
                            Dim sonuc = MessageBox.Show("UYARI: Bu fatura ile birlikte kredi limiti asilacak!" & vbCrLf & _
                                "Kredi Limiti: " & lKrediLimiti.ToString("N2") & vbCrLf & _
                                "Mevcut Bakiye: " & lMevcutBakiye.ToString("N2") & vbCrLf & _
                                "Fatura Tutari: " & lNetTutar.ToString("N2") & vbCrLf & _
                                "Yeni Bakiye: " & (lMevcutBakiye + lNetTutar).ToString("N2") & vbCrLf & vbCrLf & _
                                "Devam etmek istiyor musunuz?", "Kredi Limit Uyarisi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If sonuc = DialogResult.No Then
                                con.Close()
                                Return 0
                            End If
                        End If
                    End If
                End If

                cmdAyar = Nothing
            Catch ex As Exception
                ' Ayar kontrolu basarisiz olsa bile fatura kaydini engellemiyoruz
            End Try
        End If
        ' === PARAMETRIK KONTROLLER SONU ===

        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sCariIslem, nCariHareketID, nKasaIslemID, sCariKdvIslem, nCariKdvHareketID, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID, nTransferFirmaID, sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " , '" & sCariIslem & "', '" & nCariHareketID & "', '" & nKasaIslemID & "', '" & sCariKdvIslem & "', '" & nCariKdvHareketID & "', '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "', '" & nTransferFirmaID & "', '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & ")")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID,  sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2, nEvrakNo) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " ,  '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "',  '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & ", '" & nEvrakNo & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nStokFisiID = cmd.ExecuteScalar
        Return nStokFisiID
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Private Function detay_kaydet_yeni(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As Int64, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, ByVal lBirimMiktar As Decimal, ByVal sBirimCinsi As String) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", '" & nSiparisID & "', '" & nReceteNo & "', '" & nTransferID & "', '" & sTransferDepo & "', " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", '" & nTransferFirmaID & "',  '" & nAlisverisID & "', '" & nStokFisiID & "', '" & nIrsaliyeFisiID & "', '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi,lBirimMiktar,sBirimCinsi) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  NULL, '" & nStokFisiID & "', NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "'," & lBirimMiktar & ",'" & sBirimCinsi & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
            nIslemID = cmd.ExecuteScalar
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
        Return nIslemID
        'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        'Dim hareketno = cmd.ExecuteScalar
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Public Function sorgu_tbAlisVerisAdres_kontrol(ByVal nStokFisiID As String) As Int64
        Dim kriter
        kriter = "WHERE (nStokFisiID = '" & nStokFisiID & "') "
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        con.ConnectionString = connection_resmi
        cmd.Connection = con
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(*), 0) AS KAYIT FROM         tbStokFisiPesinAdres " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        con.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        con = Nothing
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub tbAlisVerisAdres_kaydet_yeni(ByVal nStokFisiID As String, ByVal sAciklama As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal sSubeMagaza As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiPesinAdres (nStokFisiID, sAciklama, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, sSubeMagaza) VALUES     ('" & nStokFisiID & "', N'" & sAciklama & "', '" & sAdres1 & "', '" & sAdres2 & "', '" & sSemt & "', '" & sIl & "', '" & sUlke & "', '" & sPostaKodu & "', '" & sVergiDairesi & "', '" & sVergiNo & "', '" & sSubeMagaza & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub aciklama_kaydet_yeni(ByVal nStokFisiID As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiAciklamasi (nStokFisiID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5) VALUES     ('" & nStokFisiID & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub odemeplani_kaydet_yeni(ByVal nStokFisiID As String, ByVal dteVadeTarihi As DateTime, ByVal lTutari As Decimal, ByVal sCariIslem As String, ByVal nCariHareketID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbStokFisiOdemePlani (nStokFisiID, dteVadeTarihi, lTutari, sCariIslem, nCariHareketID) VALUES     ('" & nStokFisiID & "', '" & dteVadeTarihi & "', " & lTutari & ", '" & sCariIslem & "', '" & nCariHareketID & "')")
        cmd.ExecuteNonQuery()
        'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        'Dim hareketno = cmd.ExecuteScalar
        con.Close()
        cmd = Nothing
        con = Nothing
        'Return hareketno
    End Sub
    Private Function firmahareketi_kaydet_yeni(ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbFirmaHareketi (nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES ('" & nFirmaID & "', '" & dteIslemTarihi & "', '" & dteValorTarihi & "', '" & sCariIslem & "', N'" & sAciklama & "', " & lBorcTutar & ", " & lAlacakTutar & ", '" & sEvrakNo & "', " & lVadeFarki & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nHareketID = cmd.ExecuteScalar
        con.Close()
        Return nHareketID
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub stok_renk_kaydet_yeni(ByVal sRenk As String, ByVal sRenkAdi As String, ByVal lRenkNo As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbRenk (sRenk, sRenkAdi, lRenkNo) VALUES ('" & sRenk & "', '" & sRenkAdi & "', '" & lRenkNo & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub stok_sinif_kaydet_yeni(ByVal sSinifKodu As String, ByVal sAciklama As String, ByVal sinifno As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSSinif" & sinifno & " (sSinifKodu, sAciklama) VALUES ('" & sSinifKodu & "', '" & sAciklama & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub stok_barkod_kaydet_yeni(ByVal nStokID As Int64, ByVal sBarkod As String, ByVal nKisim As Int64, ByVal nFirmaID As String, ByVal sKarsiStokKodu As String, ByVal sKarsiStokAciklama As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokBarkodu (nStokID, sBarkod, nKisim, nFirmaID, sKarsiStokKodu, sKarsiStokAciklama) VALUES     ('" & nStokID & "', '" & sBarkod & "', '" & nKisim & "', '" & nFirmaID & "', '" & sKarsiStokKodu & "', '" & sKarsiStokAciklama & "')")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            XtraMessageBox.Show(sBarkod & vbCrLf & "Barkodu Sistemde Kayýtlý Aktarýlamadý", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub stok_siniflari_kaydet_yeni(ByVal nStokID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String, ByVal sSinifKodu6 As String, ByVal sSinifKodu7 As String, ByVal sSinifKodu8 As String, ByVal sSinifKodu9 As String, ByVal sSinifKodu10 As String, ByVal sSinifKodu11 As String, ByVal sSinifKodu12 As String, ByVal sSinifKodu13 As String, ByVal sSinifKodu14 As String, ByVal sSinifKodu15 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Try
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokSinifi (nStokID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, sSinifKodu11, sSinifKodu12, sSinifKodu13, sSinifKodu14, sSinifKodu15) VALUES     ('" & nStokID & "', '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "', '" & sSinifKodu6 & "', '" & sSinifKodu7 & "', '" & sSinifKodu8 & "', '" & sSinifKodu9 & "', '" & sSinifKodu10 & "', '" & sSinifKodu11 & "', '" & sSinifKodu12 & "', '" & sSinifKodu13 & "', '" & sSinifKodu14 & "', '" & sSinifKodu15 & "')")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokBirimCevrimi_kaydet_yeni(ByVal sBirimCinsi As String, ByVal lOran As Decimal, ByVal sModel As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokBirimCevrimi select nStokID , '" & sBirimCinsi & "' , " & lOran & ", 0 from tbStok where sModel = '" & sModel & "' ")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        con.Close()
    End Sub
    Private Sub tbBirimCinsi_kaydet_yeni(ByVal sBirimCinsi As String, ByVal sAciklama As String, ByVal nOndalik As Int64, Optional ByVal sDatabase As String = "")
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbBirimCinsi (sBirimCinsi, sAciklama, nOndalik) VALUES     ('" & sBirimCinsi & "', '" & sAciklama & "', " & nOndalik & ")")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        con.Close()
    End Sub
    Private Sub tbSatici_kaydet_yeni(ByVal sSaticiRumuzu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal nPrim As Decimal, ByVal sAciklama As String, ByVal lSabitPrim As Decimal, ByVal lPrim1Baslangic As Decimal, ByVal lPrim1Bitis As Decimal, ByVal lPrim1Oran As Decimal, ByVal lPrim2Baslangic As Decimal, ByVal lPrim2Bitis As Decimal, ByVal lPrim2Oran As Decimal, ByVal lPrim3Baslangic As Decimal, ByVal lPrim3Bitis As Decimal, ByVal lPrim3Oran As Decimal, ByVal lPrim4Baslangic As Decimal, ByVal lPrim4Bitis As Decimal, ByVal lPrim4Oran As Decimal, ByVal lPrim5Baslangic As Decimal, ByVal lPrim5Bitis As Decimal, ByVal lPrim5Oran As Decimal, ByVal bAktif As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSatici (sSaticiRumuzu, sAdi, sSoyadi, nPrim, sAciklama, lSabitPrim, lPrim1Baslangic, lPrim1Bitis, lPrim1Oran, lPrim2Baslangic, lPrim2Bitis, lPrim2Oran, lPrim3Baslangic,  lPrim3Bitis, lPrim3Oran, lPrim4Baslangic, lPrim4Bitis, lPrim4Oran, lPrim5Baslangic, lPrim5Bitis, lPrim5Oran, bAktif) VALUES     ('" & sSaticiRumuzu & "', '" & sAdi & "', '" & sSoyadi & "', " & nPrim & ", '" & sAciklama & "', " & lSabitPrim & ", " & lPrim1Baslangic & ", " & lPrim1Bitis & ", " & lPrim1Oran & ", " & lPrim2Baslangic & ", " & lPrim2Bitis & ", " & lPrim2Oran & ", " & lPrim3Baslangic & ", " & lPrim3Bitis & ", " & lPrim3Oran & ", " & lPrim4Baslangic & ", " & lPrim4Bitis & ", " & lPrim4Oran & ", " & lPrim5Baslangic & ", " & lPrim5Bitis & ", " & lPrim5Oran & ", " & bAktif & ")")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        con.Close()
    End Sub
    Private Sub tbIl_kaydet_yeni(ByVal sIl As String, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbIl (sIl) VALUES     ('" & sIl & "')")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        con.Close()
    End Sub
    Private Sub tbUlke_kaydet_yeni(ByVal sUlke As String, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbUlke (sUlke) VALUES     ('" & sUlke & "')")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        con.Close()
    End Sub
    Private Sub tbStokFiyati_ekle_yeni(ByVal nStokID As Int64, ByVal sFiyatTipi As String, ByVal lFiyat As Decimal, ByVal dteFiyatTespitTarihi As DateTime, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection_resmi
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = "set implicit_transactions on "
        cmd.ExecuteNonQuery()
        'If nFiyatlandirma = 0 Then
        '    cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , 'MUHASEBE' , getdate ()  from tbStok where sModel = '" & sModel & "'"
        'ElseIf nFiyatlandirma = 1 Then
        '    cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , 'MUHASEBE' , getdate ()  from tbStok where sModel = '" & sModel & "' and sRenk ='" & sRenk & "'"
        'ElseIf nFiyatlandirma = 2 Then
        '    cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , 'MUHASEBE' , getdate ()  from tbStok where sModel = '" & sModel & "' and sRenk ='" & sRenk & "' and sBeden ='" & sBeden & "'"
        'End If
        cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFiyati (nStokID, sFiyatTipi, lFiyat, dteFiyatTespitTarihi, sKullaniciAdi, dteKayitTarihi)  VALUES     (" & nStokID & ", '" & sFiyatTipi & "', " & lFiyat & ",'" & dteFiyatTespitTarihi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "')"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "IF @@TRANCOUNT > 0 COMMIT TRAN"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "set implicit_transactions off "
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub firma_siniflari_kaydet_yeni(ByVal nFirmaID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection_resmi
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaSinifi                       (nFirmaID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5) VALUES     ('" & nFirmaID & "', '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem15_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        analiz_stok_karlilik()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Fatura Ekranýný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If GridView1.SelectedRowsCount > 1 Then
            Label1.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label1.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label1.Text = ""
        End If
    End Sub
    Private Sub BarButtonItem16_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        analiz_siparis_bekleyen_tumu()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        analiz_cari_hareket()
    End Sub
    Private Sub BarButtonItem22_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        gorunum_kaydet()
    End Sub
    Private Sub BarButtonItem18_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub BarButtonItem17_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        VGrid_baslik.RowsCustomization()
    End Sub
    Private Sub BarButtonItem19_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        VGrid_toplam.RowsCustomization()
    End Sub
    Private Sub BarButtonItem20_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        VGrid_masraf.RowsCustomization()
    End Sub
    Private Sub BarButtonItem21_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        VGrid_iskonto.RowsCustomization()
    End Sub
    Private Sub BarButtonItem23_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        If GridView1.RowCount > 0 Then
            analiz_karlilik_tumu(satir_kontrol)
        End If
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        analiz_karlilik()
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Try
            If yuklendi = True Then
                Try
                    satir_info()
                Catch ex As Exception
                End Try
            End If
            'satir_info()
        Catch ex As Exception
            Label2.Text = "*"
        End Try
    End Sub
    Private Sub BarButtonItem24_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        If GridView1.RowCount > 0 Then
            analiz_bekleyen(satir_kontrol)
        End If
    End Sub
    Private Sub BarButtonItem25_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        If GridView1.RowCount > 0 Then
            analiz_bekleyen_stok_durum(satir_kontrol)
        End If
    End Sub
    Private Sub BarButtonItem26_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem26.ItemClick
        faturalastir()
    End Sub
    Private Sub sqlSorguYaz(ByVal sorgu As String, Optional ByVal msg As Boolean = True)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection_resmi
        cmd.Connection = con
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.CommandText = sorgu
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            con.Close()
            If msg = True Then
                MessageBox.Show(ex.Message.ToString())
            End If
        End Try
        con.Close()
    End Sub
    Private Sub faturalastir(Optional ByVal bTers As Boolean = False, Optional ByVal bTamKontrol As Boolean = False)
        If XtraMessageBox.Show(Sorgu_sDil("Faturanýn Resmi Kaydýný Kontrol Etmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim dr As DataRow
            Dim dr_stok As DataRow
            Dim dr_cari As DataRow
            Dim dr_stok_barkod As DataRow
            Dim dr_renk As DataRow
            Dim dr_stok_sinifi As DataRow
            Dim dr_stok_sinif As DataRow
            Dim fis_kayit_sayisi As Int64 = 0
            Dim stok_kayit_sayisi As Int64 = 0
            Dim cari_kayit_sayisi As Int64 = 0
            Dim renk_kayit_sayisi As Int64 = 0
            Dim sinif_kayit_sayisi As Int64 = 0
            Dim barkod_var As Boolean = False
            Dim nStokID As Int64 = 0
            Dim nFirmaID As Int64 = 0
            Dim nStokFisiID As Int64 = 0
            Dim nIslemID As Int64 = 0
            Dim nHareketID As Int64 = 0
            If XtraMessageBox.Show(Sorgu_sDil("Farklý Bir Firma Hesabýnda kontrol etmek Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                cari_kayit_sayisi = sorgu_firma_kontrol(dr_baslik("sKodu"))
                If cari_kayit_sayisi = 0 Then
                    'MsgBox(dr_baslik("sKodu") & " Kodlu Firma Kaydý Bulunamadý",sDil), MessageBoxIcon.Warning)
                    dataload_cari(dr_baslik("sKodu"))
                    dr_cari = ds_firma.Tables(0).Rows(0)
                    tbIl_kaydet_yeni(dr_cari("sIl"))
                    tbUlke_kaydet_yeni(dr_cari("sUlke"))
                    nFirmaID = firma_kaydet_yeni(dr_cari("sKodu"), dr_cari("sAciklama"), dr_cari("nOzelIskontosu"), dr_cari("lKrediLimiti"), dr_cari("dteMutabakatTarihi"), dr_cari("nVadeGun"), dr_cari("sHitap"), dr_cari("sAdres1"), dr_cari("sAdres2"), dr_cari("sSemt"), dr_cari("sIl"), dr_cari("sUlke"), dr_cari("sPostaKodu"), dr_cari("sVergiDairesi"), dr_cari("sVergiNo"), 0, dr_cari("sOzelNot"), dr_cari("sKullaniciAdi"), dr_cari("dteKayitTarihi"), dr_cari("sFiyatTipi"))
                    firma_siniflari_kaydet_yeni(nFirmaID, "", "", "", "", "")
                End If
                nFirmaID = sorgu_nfirmaID(dr_baslik("sKodu"))
            Else
                Dim frm As New frm_firma_liste
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection_resmi
                'frm.musterino = dr_baslik("sKodu")
                frm.islemstatus = True
                frm.kullanici = kullanici
                If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Dim dr1 As DataRow
                    dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                    nFirmaID = Trim(dr1("nFirmaID"))
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
            End If
            'cari_kayit_sayisi = sorgu_firma_kontrol(dr_baslik("sKodu"))
            'If cari_kayit_sayisi = 0 Then
            '    'MsgBox(dr_baslik("sKodu") & " Kodlu Firma Kaydý Bulunamadý",sDil), MessageBoxIcon.Warning)
            '    dataload_cari(dr_baslik("sKodu"))
            '    dr_cari = ds_firma.Tables(0).Rows(0)
            '    nFirmaID = firma_kaydet_yeni(dr_cari("sKodu"), dr_cari("sAciklama"), dr_cari("nOzelIskontosu"), dr_cari("lKrediLimiti"), dr_cari("dteMutabakatTarihi"), dr_cari("nVadeGun"), dr_cari("sHitap"), dr_cari("sAdres1"), dr_cari("sAdres2"), dr_cari("sSemt"), dr_cari("sIl"), dr_cari("sUlke"), dr_cari("sPostaKodu"), dr_cari("sVergiDairesi"), dr_cari("sVergiNo"), 0, dr_cari("sOzelNot"), dr_cari("sKullaniciAdi"), dr_cari("dteKayitTarihi"), dr_cari("sFiyatTipi"))
            '    firma_siniflari_kaydet_yeni(nFirmaID, "", "", "", "", "")
            'Else
            '    If XtraMessageBox.Show(Sorgu_sDil("Farklý Bir Firma Hesabýnda kontrol etmek Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            '        nFirmaID = sorgu_nfirmaID(dr_baslik("sKodu"))
            '    Else
            '        Dim frm As New frm_firma_liste
            '        frm.firmano = firmano
            '        frm.donemno = donemno
            '        frm.connection = connection_resmi
            '        'frm.musterino = dr_baslik("sKodu")
            '        frm.islemstatus = True
            '        frm.kullanici = kullanici
            '        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            '            Dim dr1 As DataRow
            '            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            '            nFirmaID = Trim(dr1("nFirmaID"))
            '        End If
            '        frm.Close()
            '        frm.Dispose()
            '        frm = Nothing
            '    End If
            '    'MsgBox(nFirmaID)
            '    'MsgBox(dr_baslik("sKodu") & " Kodlu Firma Kaydý Var...",sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
            'End If
            Dim sqlSorgu As String = ""
            'tbStok Keys Sil
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStok__nFiyatla__3B0BC30C]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStok]')) ALTER TABLE [dbo].[tbStok] DROP CONSTRAINT [FK__tbStok__nFiyatla__3B0BC30C]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStok__nStokTip__3552E9B6]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStok]')) ALTER TABLE [dbo].[tbStok] DROP CONSTRAINT [FK__tbStok__nStokTip__3552E9B6]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStok__sBedenTi__36470DEF]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStok]')) ALTER TABLE [dbo].[tbStok] DROP CONSTRAINT [FK__tbStok__sBedenTi__36470DEF]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStok__sBirimCi__382F5661]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStok]')) ALTER TABLE [dbo].[tbStok] DROP CONSTRAINT [FK__tbStok__sBirimCi__382F5661]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStok__sBirimCi__39237A9A]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStok]')) ALTER TABLE [dbo].[tbStok] DROP CONSTRAINT [FK__tbStok__sBirimCi__39237A9A]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStok__sDefault__3BFFE745]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStok]')) ALTER TABLE [dbo].[tbStok] DROP CONSTRAINT [FK__tbStok__sDefault__3BFFE745]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStok__sKavalaT__373B3228]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStok]')) ALTER TABLE [dbo].[tbStok] DROP CONSTRAINT [FK__tbStok__sKavalaT__373B3228]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStok__sKdvTipi__345EC57D]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStok]')) ALTER TABLE [dbo].[tbStok] DROP CONSTRAINT [FK__tbStok__sKdvTipi__345EC57D]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStok__sOTVTipi__3CF40B7E]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStok]')) ALTER TABLE [dbo].[tbStok] DROP CONSTRAINT [FK__tbStok__sOTVTipi__3CF40B7E]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStok__sRenk__3A179ED3]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStok]')) ALTER TABLE [dbo].[tbStok] DROP CONSTRAINT [FK__tbStok__sRenk__3A179ED3]"
            sqlSorguYaz(sqlSorgu)
            'tbStokFiyati Keys Sil
            'sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFiy__sFiya__51EF2864]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFiyati]')) ALTER TABLE [dbo].[tbStokFiyati] DROP CONSTRAINT [FK__tbStokFiy__sFiya__51EF2864]"
            'sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFiy__nStok__52E34C9D]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFiyati]')) ALTER TABLE [dbo].[tbStokFiyati] DROP CONSTRAINT [FK__tbStokFiy__nStok__52E34C9D]"
            sqlSorguYaz(sqlSorgu)
            'tbStokSinifi Keys Sil
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokSin__nStok__638EB5B2]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokSinifi]')) ALTER TABLE [dbo].[tbStokSinifi] DROP CONSTRAINT [FK__tbStokSin__nStok__638EB5B2]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokSin__sSini__6482D9EB]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokSinifi]')) ALTER TABLE [dbo].[tbStokSinifi] DROP CONSTRAINT [FK__tbStokSin__sSini__6482D9EB]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokSin__sSini__6576FE24]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokSinifi]')) ALTER TABLE [dbo].[tbStokSinifi] DROP CONSTRAINT [FK__tbStokSin__sSini__6576FE24]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokSin__sSini__666B225D]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokSinifi]')) ALTER TABLE [dbo].[tbStokSinifi] DROP CONSTRAINT [FK__tbStokSin__sSini__666B225D]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokSin__sSini__675F4696]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokSinifi]')) ALTER TABLE [dbo].[tbStokSinifi] DROP CONSTRAINT [FK__tbStokSin__sSini__675F4696]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokSin__sSini__68536ACF]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokSinifi]')) ALTER TABLE [dbo].[tbStokSinifi] DROP CONSTRAINT [FK__tbStokSin__sSini__68536ACF]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokSin__sSini__69478F08]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokSinifi]')) ALTER TABLE [dbo].[tbStokSinifi] DROP CONSTRAINT [FK__tbStokSin__sSini__69478F08]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokSin__sSini__6A3BB341]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokSinifi]')) ALTER TABLE [dbo].[tbStokSinifi] DROP CONSTRAINT [FK__tbStokSin__sSini__6A3BB341]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokSin__sSini__6B2FD77A]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokSinifi]')) ALTER TABLE [dbo].[tbStokSinifi] DROP CONSTRAINT [FK__tbStokSin__sSini__6B2FD77A]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokSin__sSini__6C23FBB3]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokSinifi]')) ALTER TABLE [dbo].[tbStokSinifi] DROP CONSTRAINT [FK__tbStokSin__sSini__6C23FBB3]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokSin__sSini__6D181FEC]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokSinifi]')) ALTER TABLE [dbo].[tbStokSinifi] DROP CONSTRAINT [FK__tbStokSin__sSini__6D181FEC]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokSin__sSini__6E0C4425]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokSinifi]')) ALTER TABLE [dbo].[tbStokSinifi] DROP CONSTRAINT [FK__tbStokSin__sSini__6E0C4425]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokSin__sSini__6F00685E]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokSinifi]')) ALTER TABLE [dbo].[tbStokSinifi] DROP CONSTRAINT [FK__tbStokSin__sSini__6F00685E]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokSin__sSini__6FF48C97]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokSinifi]')) ALTER TABLE [dbo].[tbStokSinifi] DROP CONSTRAINT [FK__tbStokSin__sSini__6FF48C97]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokSin__sSini__70E8B0D0]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokSinifi]')) ALTER TABLE [dbo].[tbStokSinifi] DROP CONSTRAINT [FK__tbStokSin__sSini__70E8B0D0]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokSin__sSini__71DCD509]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokSinifi]')) ALTER TABLE [dbo].[tbStokSinifi] DROP CONSTRAINT [FK__tbStokSin__sSini__71DCD509]"
            sqlSorguYaz(sqlSorgu)
            'tbStokAciklama Keys Sil
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokAci__nStok__351DDF8C]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokAciklama]')) ALTER TABLE [dbo].[tbStokAciklama] DROP CONSTRAINT [FK__tbStokAci__nStok__351DDF8C]"
            sqlSorguYaz(sqlSorgu)
            'tbStokBarkodu Keys Sil
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokBar__nFirm__40C49C62]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokBarkodu]')) ALTER TABLE [dbo].[tbStokBarkodu] DROP CONSTRAINT [FK__tbStokBar__nFirm__40C49C62]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokBar__nStok__3FD07829]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokBarkodu]')) ALTER TABLE [dbo].[tbStokBarkodu] DROP CONSTRAINT [FK__tbStokBar__nStok__3FD07829]"
            sqlSorguYaz(sqlSorgu)
            'tbStokBirimCevrimi Keys Sil
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokBir__sBiri__44952D46]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokBirimCevrimi]')) ALTER TABLE [dbo].[tbStokBirimCevrimi] DROP CONSTRAINT [FK__tbStokBir__sBiri__44952D46]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokBir__nStok__43A1090D]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokBirimCevrimi]')) ALTER TABLE [dbo].[tbStokBirimCevrimi] DROP CONSTRAINT [FK__tbStokBir__nStok__43A1090D]"
            sqlSorguYaz(sqlSorgu)
            'Fiyat Tipi Kaydet
            dataload_stok_fiyatTipi()
            Dim dr5 As DataRow
            For Each dr5 In ds_stok_fiyatTipi.Tables(0).Rows
                sqlSorguYaz("if (Select count(*) from tbFiyatTipi Where sFiyatTipi = '" & dr5("sFiyatTipi") & "') < 1 begin insert into tbFiyatTipi(sFiyatTipi, sAciklama, nAST, bKdvDahilmi, bDovizeBaglimi, sDovizCinsi, sHangiKur, aktif, aktifDepo) values('" & dr5("sFiyatTipi") & "', '" & dr5("sAciklama") & "', " & dr5("nAST") & ", '" & dr5("bKdvDahilmi") & "', '" & dr5("bDovizeBaglimi") & "', '" & dr5("sDovizCinsi") & "', '" & dr5("sHangiKur") & "', '" & dr5("aktif") & "', '" & dr5("aktifDepo") & "') END")
            Next
            dr5 = Nothing
            For Each dr In ds_hareket.Tables(0).Rows
                stok_kayit_sayisi = sorgu_stok_kontrol(Trim(dr("sKodu")))
                If stok_kayit_sayisi = 0 Then
                    'MsgBox(dr("sKodu") & " Kodlu Stok Kaydý Bulunamadý", sDil), MessageBoxIcon.Warning)
                    'Stok Bilgini Çek
                    dataload_stok(dr("sKodu"))
                    'Stok Barkod Bilgisini Çek
                    'Dim dr_stok_barkod As DataRow
                    dataload_stok_barkod(dr("nStokID"))
                    If ds_stok_barkod.Tables(0).Rows.Count > 0 Then
                        barkod_var = True
                        dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                    Else
                        barkod_var = False
                    End If
                    'Sýnýf Bilgisini Çek
                    dataload_stok_sinif(dr("nStokID"))
                    'datarow yükle
                    dr_stok = ds_stok.Tables(0).Rows(0)
                    'dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                    dr_stok_sinif = ds_stok_sinif.Tables(0).Rows(0)
                    renk_kayit_sayisi = sorgu_Renk_kontrol(dr_stok("sRenk"))
                    If renk_kayit_sayisi = 0 Then
                        dataload_sRenk(dr_stok("sRenk"))
                        dr_renk = ds_renk.Tables(0).Rows(0)
                        stok_renk_kaydet_yeni(dr_renk("sRenk"), dr_renk("sRenkAdi"), dr_renk("lRenkNo"))
                    End If
                    'Stoðu Kaydet
                    'nStokID = stok_kaydet_yeni(dr_stok("sKodu"), dr_stok("sAciklama"), dr_stok("sKisaAdi"), dr_stok("nStokTipi"), dr_stok("sBedenTipi"), dr_stok("sKavalaTipi"), dr_stok("sRenk"), dr_stok("sBeden"), dr_stok("sKavala"), dr_stok("sBirimCinsi1"), dr_stok("sBirimCinsi2"), dr_stok("nIskontoYuzdesi"), dr_stok("sKdvTipi"), dr_stok("nTeminSuresi"), dr_stok("lAsgariMiktar"), dr_stok("lAzamiMiktar"), dr_stok("sOzelNot"), dr_stok("nFiyatlandirma"), dr_stok("sModel"), dr_stok("sKullaniciAdi"), dr_stok("dteKayitTarihi"), dr_stok("bEksiyeDusulebilirmi"), dr_stok("sDefaultAsortiTipi"), 0, dr_stok("bOTVVar"), dr_stok("sOTVTipi"), dr_stok("nIskontoYuzdesiAV"), dr_stok("bEk1"), dr_stok("nEk2"))
                    If bTers = True Then
                        If Trim(dr_stok("sKdvTipi")) = "5.Tip Kdv" Then
                            dr_stok("sKdvTipi") = "04"
                        End If
                    End If
                    tbBirimCinsi_kaydet_yeni(dr_stok("sBirimCinsi1"), dr_stok("sBirimCinsi1"), 3)
                    tbBirimCinsi_kaydet_yeni(dr_stok("sBirimCinsi2"), dr_stok("sBirimCinsi2"), 3)
                    nStokID = stok_kaydet_yeni(dr_stok("sKodu"), dr_stok("sAciklama"), dr_stok("sKisaAdi"), dr_stok("nStokTipi"), "", "", dr_stok("sRenk"), dr_stok("sBeden"), dr_stok("sKavala"), dr_stok("sBirimCinsi1"), dr_stok("sBirimCinsi2"), dr_stok("nIskontoYuzdesi"), dr_stok("sKdvTipi"), dr_stok("nTeminSuresi"), dr_stok("lAsgariMiktar"), dr_stok("lAzamiMiktar"), dr_stok("sOzelNot"), dr_stok("nFiyatlandirma"), dr_stok("sModel"), dr_stok("sKullaniciAdi"), dr_stok("dteKayitTarihi"), dr_stok("bEksiyeDusulebilirmi"), dr_stok("sDefaultAsortiTipi"), 0, dr_stok("bOTVVar"), dr_stok("sOTVTipi"), dr_stok("nIskontoYuzdesiAV"), dr_stok("bEk1"), dr_stok("nEk2"))
                    'Sýnýf Kayýtlarýný Kontrol Et
                    For i As Integer = 1 To 15
                        'MsgBox(dr_stok_sinif("sSinifKodu" & i & ""))
                        sinif_kayit_sayisi = sorgu_Sinif_kontrol(dr_stok_sinif("sSinifKodu" & i & ""), i)
                        If sinif_kayit_sayisi = 0 Then
                            Try
                                dataload_stok_sinif1(dr_stok_sinif("sSinifKodu" & i & ""), i)
                                dr_stok_sinifi = ds_stok_sinif.Tables(0).Rows(0)
                                stok_sinif_kaydet_yeni(dr_stok_sinifi("sSinifKodu"), dr_stok_sinifi("sAciklama"), i)
                            Catch ex As Exception
                            End Try
                        End If
                    Next
                    'sýnýflarý kaydet
                    stok_siniflari_kaydet_yeni(nStokID, dr_stok_sinif("sSinifKodu1"), dr_stok_sinif("sSinifKodu2"), dr_stok_sinif("sSinifKodu3"), dr_stok_sinif("sSinifKodu4"), dr_stok_sinif("sSinifKodu5"), dr_stok_sinif("sSinifKodu6"), dr_stok_sinif("sSinifKodu7"), dr_stok_sinif("sSinifKodu8"), dr_stok_sinif("sSinifKodu9"), dr_stok_sinif("sSinifKodu10"), dr_stok_sinif("sSinifKodu11"), dr_stok_sinif("sSinifKodu12"), dr_stok_sinif("sSinifKodu13"), dr_stok_sinif("sSinifKodu14"), dr_stok_sinif("sSinifKodu15"))
                    'barkodu kaydet
                    If barkod_var = True Then
                        dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                        If dr_stok_barkod("nKisim") = 0 Or dr_stok_barkod("nKisim") = 1 Then
                        Else
                            dr_stok_barkod("nKisim") = 0
                        End If
                        If dr_stok_barkod("sKarsiStokKodu") = Microsoft.VisualBasic.Right(dr_stok_barkod("nStokID"), 6) Then
                            dr_stok_barkod("sKarsiStokKodu") = ""
                        End If
                        stok_barkod_kaydet_yeni(nStokID, dr_stok_barkod("sBarkod"), dr_stok_barkod("nKisim"), dr_stok_barkod("nFirmaID"), dr_stok_barkod("sKarsiStokKodu"), dr_stok_barkod("sKarsiStokAciklama"))
                    End If
                    'fiyatlarý kaydet
                    dataload_stok_fiyat(dr("nStokID"))
                    Dim dr4 As DataRow
                    For Each dr4 In ds_stok_fiyat.Tables(0).Rows
                        tbStokFiyati_ekle_yeni(nStokID, dr4("sFiyatTipi"), dr4("lFiyat"), dr4("dteFiyatTespitTarihi"), dr4("sKullaniciAdi"), dr4("dteKayitTarihi"))
                    Next
                    dr4 = Nothing
                    Dim ds_tbStokBirimCevrimi As DataSet = sorgu(sorgu_query("Select * from tbStokBirimCevrimi where nStokID = " & dr("nStokID") & ""))
                    Dim dr1 As DataRow
                    For Each dr1 In ds_tbStokBirimCevrimi.Tables(0).Rows
                        tbBirimCinsi_kaydet_yeni(dr1("sBirimCinsi"), dr1("sBirimCinsi"), 3)
                        tbStokBirimCevrimi_kaydet_yeni(dr1("sBirimCinsi"), dr1("lOran"), dr("sKodu"))
                    Next
                Else
                    nStokID = sorgu_nStokID(Trim(dr("sKodu")))
                    'MsgBox(dr("sKodu") & " Kodlu Stok Kaydý var..!!!",sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
                    'MsgBox(nStokID)
                End If
                If sorgu_Satici_kontrol(dr("sSaticiRumuzu")) = 0 Then
                    tbSatici_kaydet_yeni(dr("sSaticiRumuzu"), "", "", 0, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1)
                End If
            Next
            'tbStok Keys Ekle
            sqlSorgu = "ALTER TABLE [dbo].[tbStok] WITH NOCHECK ADD CONSTRAINT [FK__tbStok__nFiyatla__3B0BC30C] FOREIGN KEY([nFiyatlandirma]) REFERENCES [dbo].[tbFiyatlandirma] ([nFiyatlandirma])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStok] WITH NOCHECK ADD CONSTRAINT [FK__tbStok__nStokTip__3552E9B6] FOREIGN KEY([nStokTipi]) REFERENCES [dbo].[tbStokTipi] ([nStokTipi])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStok] WITH NOCHECK ADD CONSTRAINT [FK__tbStok__sBedenTi__36470DEF] FOREIGN KEY([sBedenTipi]) REFERENCES [dbo].[tbBedenTipi] ([sBedenTipi])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStok] WITH NOCHECK ADD CONSTRAINT [FK__tbStok__sBirimCi__382F5661] FOREIGN KEY([sBirimCinsi1]) REFERENCES [dbo].[tbBirimCinsi] ([sBirimCinsi])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStok] WITH NOCHECK ADD CONSTRAINT [FK__tbStok__sBirimCi__39237A9A] FOREIGN KEY([sBirimCinsi2]) REFERENCES [dbo].[tbBirimCinsi] ([sBirimCinsi])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStok] WITH NOCHECK ADD CONSTRAINT [FK__tbStok__sDefault__3BFFE745] FOREIGN KEY([sDefaultAsortiTipi]) REFERENCES [dbo].[tbAsorti] ([sAsortiTipi])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStok] WITH NOCHECK ADD CONSTRAINT [FK__tbStok__sKavalaT__373B3228] FOREIGN KEY([sKavalaTipi]) REFERENCES [dbo].[tbKavala] ([sKavalaTipi])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStok] WITH NOCHECK ADD CONSTRAINT [FK__tbStok__sKdvTipi__345EC57D] FOREIGN KEY([sKdvTipi]) REFERENCES [dbo].[tbKdv] ([sKdvTipi])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStok] WITH NOCHECK ADD CONSTRAINT [FK__tbStok__sOTVTipi__3CF40B7E] FOREIGN KEY([sOTVTipi]) REFERENCES [dbo].[tbOTV] ([sOTVTipi])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStok] WITH NOCHECK ADD CONSTRAINT [FK__tbStok__sRenk__3A179ED3] FOREIGN KEY([sRenk]) REFERENCES [dbo].[tbRenk] ([sRenk])"
            sqlSorguYaz(sqlSorgu)
            'tbStokFiyati Keys Ekle
            'sqlSorgu = "ALTER TABLE [dbo].[tbStokFiyati] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFiy__sFiya__51EF2864] FOREIGN KEY([sFiyatTipi]) REFERENCES [dbo].[tbFiyatTipi] ([sFiyatTipi])"
            'sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFiyati] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFiy__nStok__52E34C9D] FOREIGN KEY([nStokID]) REFERENCES [dbo].[tbStok] ([nStokID])"
            sqlSorguYaz(sqlSorgu)
            'tbStokSinifi Keys Ekle
            sqlSorgu = "ALTER TABLE [dbo].[tbStokSinifi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokSin__nStok__638EB5B2] FOREIGN KEY([nStokID]) REFERENCES [dbo].[tbStok] ([nStokID])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokSinifi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokSin__sSini__6482D9EB] FOREIGN KEY([sSinifKodu1]) REFERENCES [dbo].[tbSSinif1] ([sSinifKodu])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokSinifi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokSin__sSini__6576FE24] FOREIGN KEY([sSinifKodu2]) REFERENCES [dbo].[tbSSinif2] ([sSinifKodu])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokSinifi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokSin__sSini__666B225D] FOREIGN KEY([sSinifKodu3]) REFERENCES [dbo].[tbSSinif3] ([sSinifKodu])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokSinifi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokSin__sSini__675F4696] FOREIGN KEY([sSinifKodu4]) REFERENCES [dbo].[tbSSinif4] ([sSinifKodu])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokSinifi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokSin__sSini__68536ACF] FOREIGN KEY([sSinifKodu5]) REFERENCES [dbo].[tbSSinif5] ([sSinifKodu])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokSinifi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokSin__sSini__69478F08] FOREIGN KEY([sSinifKodu6]) REFERENCES [dbo].[tbSSinif6] ([sSinifKodu])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokSinifi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokSin__sSini__6A3BB341] FOREIGN KEY([sSinifKodu7]) REFERENCES [dbo].[tbSSinif7] ([sSinifKodu])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokSinifi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokSin__sSini__6B2FD77A] FOREIGN KEY([sSinifKodu8]) REFERENCES [dbo].[tbSSinif8] ([sSinifKodu])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokSinifi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokSin__sSini__6C23FBB3] FOREIGN KEY([sSinifKodu9]) REFERENCES [dbo].[tbSSinif9] ([sSinifKodu])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokSinifi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokSin__sSini__6D181FEC] FOREIGN KEY([sSinifKodu10]) REFERENCES [dbo].[tbSSinif10] ([sSinifKodu])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokSinifi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokSin__sSini__6E0C4425] FOREIGN KEY([sSinifKodu11]) REFERENCES [dbo].[tbSSinif11] ([sSinifKodu])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokSinifi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokSin__sSini__6F00685E] FOREIGN KEY([sSinifKodu12]) REFERENCES [dbo].[tbSSinif12] ([sSinifKodu])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokSinifi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokSin__sSini__6FF48C97] FOREIGN KEY([sSinifKodu13]) REFERENCES [dbo].[tbSSinif13] ([sSinifKodu])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokSinifi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokSin__sSini__70E8B0D0] FOREIGN KEY([sSinifKodu14]) REFERENCES [dbo].[tbSSinif14] ([sSinifKodu])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokSinifi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokSin__sSini__71DCD509] FOREIGN KEY([sSinifKodu15]) REFERENCES [dbo].[tbSSinif15] ([sSinifKodu])"
            sqlSorguYaz(sqlSorgu)
            'tbStokAciklama Keys Ekle
            sqlSorgu = "ALTER TABLE [dbo].[tbStokAciklama] WITH NOCHECK ADD CONSTRAINT [FK__tbStokAci__nStok__351DDF8C] FOREIGN KEY([nStokID]) REFERENCES [dbo].[tbStok] ([nStokID])"
            sqlSorguYaz(sqlSorgu)
            'tbStokBarkodu Keys Ekle
            sqlSorgu = "ALTER TABLE [dbo].[tbStokBarkodu] WITH NOCHECK ADD CONSTRAINT [FK__tbStokBar__nFirm__40C49C62] FOREIGN KEY([nFirmaID]) REFERENCES [dbo].[tbFirma] ([nFirmaID])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokBarkodu] WITH NOCHECK ADD CONSTRAINT [FK__tbStokBar__nStok__3FD07829] FOREIGN KEY([nStokID]) REFERENCES [dbo].[tbStok] ([nStokID])"
            sqlSorguYaz(sqlSorgu)
            'tbStokBirimCevrimi Keys Ekle
            sqlSorgu = "ALTER TABLE [dbo].[tbStokBirimCevrimi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokBir__sBiri__44952D46] FOREIGN KEY([sBirimCinsi]) REFERENCES [dbo].[tbBirimCinsi] ([sBirimCinsi])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokBirimCevrimi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokBir__nStok__43A1090D] FOREIGN KEY([nStokID]) REFERENCES [dbo].[tbStok] ([nStokID])"
            sqlSorguYaz(sqlSorgu)
            If bTers = True Then
                fis_kayit_sayisi = sorgu_fis_kontrol(dr_baslik("sFisTipi"), dr_baslik("nGirisCikis"), dr_baslik("dteFisTarihi"), dr_baslik("lFisNo"), nFirmaID, False)
            Else
                fis_kayit_sayisi = sorgu_fis_kontrol(dr_baslik("sFisTipi"), dr_baslik("nGirisCikis"), dr_baslik("dteFisTarihi"), dr_baslik("lFisNo"), nFirmaID, True)
            End If
            'tbStokFisiDetayi Keys Sil
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tbStokFisiDetayi_nAlisverisID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK_tbStokFisiDetayi_nAlisverisID]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__nFirm__18EC8089]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__nFirm__18EC8089]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__nFirm__7073AF84]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__nFirm__7073AF84]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__nStok__6F7F8B4B]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__nStok__6F7F8B4B]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__nStok__1BC8ED34]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__nStok__1BC8ED34]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__nTran__1CBD116D]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__nTran__1CBD116D]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__nTran__7EC1CEDB]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__nTran__7EC1CEDB]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sTran__74444068]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sTran__74444068]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sTran__2A170C8B]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sTran__2A170C8B]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StokHareketi_SP]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK_StokHareketi_SP]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StokHareketi_Parti]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK_StokHareketi_Parti]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__nMust__1AD4C8FB]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__nMust__1AD4C8FB]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__nMust__762C88DA]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__nMust__762C88DA]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sDepo__73501C2F]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sDepo__73501C2F]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sDepo__1DB135A6]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sDepo__1DB135A6]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sFiya__7814D14C]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sFiya__7814D14C]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sFiya__2275EAC3]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sFiya__2275EAC3]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sStok__725BF7F6]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sStok__725BF7F6]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sKasi__7720AD13]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sKasi__7720AD13]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sSati__79FD19BE]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sSati__79FD19BE]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sKasi__2552576E]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sKasi__2552576E]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sSati__282EC419]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sSati__282EC419]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sStok__2922E852]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sStok__2922E852]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__nGiri__19E0A4C2]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__nGiri__19E0A4C2]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__nGiri__7167D3BD]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__nGiri__7167D3BD]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sDovi__1EA559DF]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sDovi__1EA559DF]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sDovi__1F997E18]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sDovi__1F997E18]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sDovi__208DA251]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sDovi__208DA251]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sDovi__7908F585]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sDovi__7908F585]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sDovi__7CD98669]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sDovi__7CD98669]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sDovi__7DCDAAA2]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sDovi__7DCDAAA2]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sFisT__2181C68A]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sFisT__2181C68A]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sFisT__753864A1]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sFisT__753864A1]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sHang__00AA174D]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sHang__00AA174D]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sHang__236A0EFC]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sHang__236A0EFC]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sHare__245E3335]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sHare__245E3335]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sHare__7BE56230]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sHare__7BE56230]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sMasr__26467BA7]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sMasr__26467BA7]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sMasr__7FB5F314]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sMasr__7FB5F314]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sOdem__273A9FE0]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sOdem__273A9FE0]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__tbStokFis__sOdem__7AF13DF7]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK__tbStokFis__sOdem__7AF13DF7]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tbStokFisiDetayi_nIrsaliyeFisiID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK_tbStokFisiDetayi_nIrsaliyeFisiID]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tbStokFisiDetayi_nStokFisiID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK_tbStokFisiDetayi_nStokFisiID]"
            sqlSorguYaz(sqlSorgu)
            If fis_kayit_sayisi = 0 Then
                'MsgBox(Sorgu_sDil("Fatura Kaydý Bulunumadý", sDil), MessageBoxIcon.Warning)
                dataload_fis_master(dr_baslik("sFisTipi"), dr_baslik("nGirisCikis"), dr_baslik("dteFisTarihi"), dr_baslik("lFisNo"), dr_baslik("nFirmaID"))
                Dim dr_fatura As DataRow = ds_stok_fisi.Tables(0).Rows(0)
                nStokFisiID = sorgu_nStokFisiID()
                If bTers = True Then
                    If Trim(dr_fatura("sFisTipi")) = "FS" Then
                        dr_fatura("sFisTipi") = "FA"
                        dr_fatura("nGirisCikis") = 1
                    ElseIf Trim(dr_fatura("sFisTipi")) = "FA" Then
                        dr_fatura("sFisTipi") = "FS"
                        dr_fatura("nGirisCikis") = 3
                    End If
                End If
                Dim ds_tbStokFisiPesinAdres As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbStokFisiPesinAdres Where nStokFisiID = '" & dr_baslik("nStokFisiID") & "'"))
                nStokFisiID = master_kaydet_yeni(nStokFisiID, dr_fatura("sFisTipi"), dr_fatura("dteFisTarihi"), dr_fatura("nGirisCikis"), dr_fatura("lFisNo"), nFirmaID, dr_fatura("sDepo"), dr_fatura("dteValorTarihi"), dr_fatura("bPesinmi"), dr_fatura("bListelendimi"), dr_fatura("bHizmetFaturasimi"), dr_fatura("lToplamMiktar"), dr_fatura("lMalBedeli"), dr_fatura("lMalIskontoTutari"), dr_fatura("nDipIskontoYuzdesi1"), dr_fatura("lDipIskontoTutari1"), dr_fatura("nDipIskontoYuzdesi2"), dr_fatura("lDipIskontoTutari2"), dr_fatura("lDipIskontoTutari3"), dr_fatura("lEkMaliyet1"), dr_fatura("lEkMaliyet2"), dr_fatura("lEkMaliyet3"), dr_fatura("nKdvOrani1"), dr_fatura("lKdvMatrahi1"), dr_fatura("lKdv1"), dr_fatura("nKdvOrani2"), dr_fatura("lKdvMatrahi2"), dr_fatura("lKdv2"), dr_fatura("nKdvOrani3"), dr_fatura("lKdvMatrahi3"), dr_fatura("lKdv3"), dr_fatura("nKdvOrani4"), dr_fatura("lKdvMatrahi4"), dr_fatura("lKdv4"), dr_fatura("nKdvOrani5"), dr_fatura("lKdvMatrahi5"), dr_fatura("lKdv5"), dr_fatura("lNetTutar"), dr_fatura("nTevkifatKdvOrani"), dr_fatura("lTevkifatKdvMatrahi"), dr_fatura("lTevkifatKdv"), dr_fatura("sCariIslem").ToString, dr_fatura("nCariHareketID").ToString, dr_fatura("nKasaIslemID").ToString, dr_fatura("sCariKdvIslem").ToString, dr_fatura("nCariKdvHareketID").ToString, dr_fatura("sHareketTipi").ToString, dr_fatura("bMuhasebeyeIslendimi"), dr_fatura("bFisTamamlandimi"), dr_fatura("lTransferFisiID"), dr_fatura("nTransferFirmaID").ToString, dr_fatura("sTransferDepo"), dr_fatura("bFaturayaDonustumu"), dr_fatura("sKullaniciAdi"), dr_fatura("dteKayitTarihi"), dr_fatura("sYaziIle"), dr_fatura("nOTVOrani1"), dr_fatura("lOTVMatrahi1"), dr_fatura("lOTV1"), dr_fatura("nOTVOrani2"), dr_fatura("lOTVMatrahi2"), dr_fatura("lOTV2"), dr_fatura("nEvrakNo"))
                fis_Master_fisno_degistir(nStokFisiID)
                dataload_fis_aciklama(dr_baslik("nStokFisiID"))
                dr_fatura = ds_stok_fisi.Tables(0).Rows(0)
                Dim kayitsayisi = sorgu_tbAlisVerisAdres_kontrol(nStokFisiID)
                If kayitsayisi = 0 Then
                    If ds_tbStokFisiPesinAdres.Tables(0).Rows.Count = 0 Then
                        tbAlisVerisAdres_kaydet_yeni(nStokFisiID, "", "", "", "", "", "Türkiye", "", "", "", "")
                    Else
                        Dim dr_adres As DataRow = ds_tbStokFisiPesinAdres.Tables(0).Rows(0)
                        tbAlisVerisAdres_kaydet_yeni(nStokFisiID, dr_adres("sAciklama"), dr_adres("sAdres1"), dr_adres("sAdres2"), dr_adres("sSemt"), dr_adres("sIl"), dr_adres("sUlke"), dr_adres("sPostaKodu"), dr_adres("sVergiDairesi"), dr_adres("sVergiNo"), dr_adres("sSubeMagaza"))
                    End If
                End If
                aciklama_kaydet_yeni(nStokFisiID, dr_fatura("sAciklama1").ToString, dr_fatura("sAciklama2").ToString, dr_fatura("sAciklama3").ToString, dr_fatura("sAciklama4").ToString, dr_fatura("sAciklama5").ToString)
                dataload_fis_detay(dr_baslik("sFisTipi"), dr_baslik("nGirisCikis"), dr_baslik("dteFisTarihi"), dr_baslik("lFisNo"), dr_baslik("nFirmaID"))
                Dim dr_fhareket As DataRow
                Dim lBirimMiktar As Decimal = 1
                Dim sBirimCinsi As String = ""
                Dim nAktarilanSatir As Integer = 0
                For Each dr_fhareket In ds_stok_fisi.Tables(0).Rows
                    nAktarilanSatir += 1
                    nIslemID = sorgu_nStokIslemID()
                    If bTamKontrol = True Then
                        nStokID = sorgu_nStokID(Trim(dr_fhareket("sKodu")), Trim(dr_fhareket("sStokAciklama")))
                        If nStokID = 0 Then
                            XtraMessageBox.Show("Satir:" & nAktarilanSatir & vbCrLf & "Kod:" & Trim(dr_fhareket("sKodu")) & vbCrLf & "Ýsim :" & Trim(dr_fhareket("sStokAciklama")) & vbCrLf & "Kayýt Eþleniði Bulunamadý", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else
                        nStokID = sorgu_nStokID(Trim(dr_fhareket("sKodu")))
                    End If
                    If Trim(dr_fhareket("sDepo")) = "" Then
                        dr_fhareket("sDepo") = sDepo
                    End If
                    If nStokID <> 0 Then
                        lBirimMiktar = 1
                        Try
                            sBirimCinsi = dr_fhareket("sBirimCinsi")
                        Catch ex As Exception
                            sBirimCinsi = ""
                        End Try
                        If Trim(dr_fhareket("sFisTipi")) = "FS" Then
                            If dr_fhareket("lCikisMiktar2") = 0 Then
                                Try
                                    lBirimMiktar = dr_fhareket("lBirimMiktar")
                                Catch ex As Exception
                                    lBirimMiktar = 1
                                End Try
                            Else
                                lBirimMiktar = dr_fhareket("lCikisMiktar2") / dr_fhareket("lCikisMiktar1")
                                dr_fhareket("lCikisMiktar1") = dr_fhareket("lCikisMiktar2")
                                dr_fhareket("lCikisMiktar2") = 0
                                dr_fhareket("lBrutFiyat") = dr_fhareket("lBrutFiyat") / lBirimMiktar
                                dr_fhareket("lCikisFiyat") = dr_fhareket("lCikisFiyat") / lBirimMiktar
                            End If
                        ElseIf Trim(dr_fhareket("sFisTipi")) = "FA" Then
                            If dr_fhareket("lGirisMiktar2") = 0 Then
                                Try
                                    lBirimMiktar = dr_fhareket("lBirimMiktar")
                                Catch ex As Exception
                                    lBirimMiktar = 1
                                End Try
                            Else
                                lBirimMiktar = dr_fhareket("lGirisMiktar2") / dr_fhareket("lGirisMiktar1")
                                dr_fhareket("lGirisMiktar1") = dr_fhareket("lGirisMiktar2")
                                dr_fhareket("lGirisMiktar2") = 0
                                dr_fhareket("lBrutFiyat") = dr_fhareket("lBrutFiyat") / lBirimMiktar
                                dr_fhareket("lGirisFiyat") = dr_fhareket("lGirisFiyat") / lBirimMiktar
                            End If
                        End If
                        If bTers = True Then
                            If Trim(dr_fhareket("sFisTipi")) = "FS" Then
                                dr_fhareket("sFisTipi") = "FA"
                                dr_fhareket("nGirisCikis") = 1
                            ElseIf Trim(dr_fhareket("sFisTipi")) = "FA" Then
                                dr_fhareket("sFisTipi") = "FS"
                                dr_fhareket("nGirisCikis") = 3
                            End If
                            nIslemID = detay_kaydet_yeni(nIslemID, nStokID, dr_fhareket("dteIslemTarihi"), nFirmaID, dr_fhareket("nMusteriID"), dr_fhareket("sFisTipi"), dr_fhareket("dteFisTarihi"), dr_fhareket("lFisNo"), dr_fhareket("nGirisCikis"), dr_fhareket("sDepo"), dr_fhareket("lReyonFisNo"), dr_fhareket("sStokIslem"), dr_fhareket("sKasiyerRumuzu"), dr_fhareket("sSaticiRumuzu"), dr_fhareket("sOdemeKodu"), dr_fhareket("dteIrsaliyeTarihi"), dr_fhareket("lIrsaliyeNo"), dr_fhareket("lCikisMiktar1"), dr_fhareket("lCikisMiktar2"), dr_fhareket("lCikisFiyat"), dr_fhareket("lCikisTutar"), dr_fhareket("lGirisMiktar1"), dr_fhareket("lGirisMiktar2"), dr_fhareket("lGirisFiyat"), dr_fhareket("lGirisTutar"), dr_fhareket("sFiyatTipi"), dr_fhareket("lBrutFiyat"), dr_fhareket("lBrutTutar"), dr_fhareket("lMaliyetFiyat"), dr_fhareket("lMaliyetTutar"), dr_fhareket("lIlaveMaliyetTutar"), dr_fhareket("nIskontoYuzdesi"), dr_fhareket("lIskontoTutari"), dr_fhareket("sDovizCinsi"), dr_fhareket("lDovizFiyat"), dr_fhareket("nSiparisID").ToString, dr_fhareket("nReceteNo"), dr_fhareket("nTransferID").ToString, dr_fhareket("sTransferDepo").ToString, dr_fhareket("nKdvOrani"), dr_fhareket("nHesapID"), dr_fhareket("sAciklama"), dr_fhareket("sHareketTipi"), dr_fhareket("bMuhasebeyeIslendimi"), dr_fhareket("sKullaniciAdi"), dr_fhareket("dteKayitTarihi"), dr_fhareket("sDovizCinsi1"), dr_fhareket("lDovizMiktari1"), dr_fhareket("lDovizKuru1"), dr_fhareket("sDovizCinsi2"), dr_fhareket("lDovizMiktari2"), dr_fhareket("lDovizKuru2"), dr_fhareket("nOTVOrani"), dr_fhareket("nTransferFirmaID").ToString, dr_fhareket("nAlisverisID").ToString, nStokFisiID, dr_fhareket("nIrsaliyeFisiID").ToString, dr_fhareket("sMasrafYontemi"), dr_fhareket("sHangiUygulama"), dr_fhareket("nEkSaha1"), dr_fhareket("nEkSaha2"), dr_fhareket("bEkSoru1"), dr_fhareket("bEkSoru2"), dr_fhareket("sSonKullaniciAdi"), dr_fhareket("dteSonUpdateTarihi"), lBirimMiktar, sBirimCinsi)
                        Else
                            nIslemID = detay_kaydet_yeni(nIslemID, nStokID, dr_fhareket("dteIslemTarihi"), nFirmaID, dr_fhareket("nMusteriID"), dr_fhareket("sFisTipi"), dr_fhareket("dteFisTarihi"), dr_fhareket("lFisNo"), dr_fhareket("nGirisCikis"), dr_fhareket("sDepo"), dr_fhareket("lReyonFisNo"), dr_fhareket("sStokIslem"), dr_fhareket("sKasiyerRumuzu"), dr_fhareket("sSaticiRumuzu"), dr_fhareket("sOdemeKodu"), dr_fhareket("dteIrsaliyeTarihi"), dr_fhareket("lIrsaliyeNo"), dr_fhareket("lGirisMiktar1"), dr_fhareket("lGirisMiktar2"), dr_fhareket("lGirisFiyat"), dr_fhareket("lGirisTutar"), dr_fhareket("lCikisMiktar1"), dr_fhareket("lCikisMiktar2"), dr_fhareket("lCikisFiyat"), dr_fhareket("lCikisTutar"), dr_fhareket("sFiyatTipi"), dr_fhareket("lBrutFiyat"), dr_fhareket("lBrutTutar"), dr_fhareket("lMaliyetFiyat"), dr_fhareket("lMaliyetTutar"), dr_fhareket("lIlaveMaliyetTutar"), dr_fhareket("nIskontoYuzdesi"), dr_fhareket("lIskontoTutari"), dr_fhareket("sDovizCinsi"), dr_fhareket("lDovizFiyat"), dr_fhareket("nSiparisID").ToString, dr_fhareket("nReceteNo"), dr_fhareket("nTransferID").ToString, dr_fhareket("sTransferDepo").ToString, dr_fhareket("nKdvOrani"), dr_fhareket("nHesapID"), dr_fhareket("sAciklama"), dr_fhareket("sHareketTipi"), dr_fhareket("bMuhasebeyeIslendimi"), dr_fhareket("sKullaniciAdi"), dr_fhareket("dteKayitTarihi"), dr_fhareket("sDovizCinsi1"), dr_fhareket("lDovizMiktari1"), dr_fhareket("lDovizKuru1"), dr_fhareket("sDovizCinsi2"), dr_fhareket("lDovizMiktari2"), dr_fhareket("lDovizKuru2"), dr_fhareket("nOTVOrani"), dr_fhareket("nTransferFirmaID").ToString, dr_fhareket("nAlisverisID").ToString, nStokFisiID, dr_fhareket("nIrsaliyeFisiID").ToString, dr_fhareket("sMasrafYontemi"), dr_fhareket("sHangiUygulama"), dr_fhareket("nEkSaha1"), dr_fhareket("nEkSaha2"), dr_fhareket("bEkSoru1"), dr_fhareket("bEkSoru2"), dr_fhareket("sSonKullaniciAdi"), dr_fhareket("dteSonUpdateTarihi"), lBirimMiktar, sBirimCinsi)
                        End If
                        fis_detay_fisno_degistir(nIslemID)
                    End If
                Next
                'dataload_fis_aciklama(dr_baslik("nStokFisiID"))
                'dr_fatura = ds_stok_fisi.Tables(0).Rows(0)
                'aciklama_kaydet_yeni(nStokFisiID, dr_fatura("sAciklama1"), dr_fatura("sAciklama2"), dr_fatura("sAciklama3"), dr_fatura("sAciklama4"), dr_fatura("sAciklama5"))
                dataload_fis_firma_hareket(dr_baslik("sFisTipi"), dr_baslik("dteFisTarihi"), dr_baslik("lFisNo"), dr_baslik("nFirmaID"))
                Dim dr_firma_hareket As DataRow
                For Each dr_firma_hareket In ds_stok_fisi.Tables(0).Rows
                    nHareketID = sorgu_nCariHareketID()
                    If bTers = True Then
                        If Trim(dr_firma_hareket("sCariIslem")) = "FS" Then
                            dr_firma_hareket("sCariIslem") = "FA"
                            dr_firma_hareket("sHangiUygulama") = "FA"
                        ElseIf Trim(dr_firma_hareket("sCariIslem")) = "FA" Then
                            dr_firma_hareket("sCariIslem") = "FS"
                            dr_firma_hareket("sHangiUygulama") = "FS"
                        End If
                        nHareketID = firmahareketi_kaydet_yeni(nHareketID, nFirmaID, dr_firma_hareket("dteIslemTarihi"), dr_firma_hareket("dteValorTarihi"), dr_firma_hareket("sCariIslem"), dr_firma_hareket("sAciklama"), dr_firma_hareket("lAlacakTutar"), dr_firma_hareket("lBorcTutar"), dr_firma_hareket("sEvrakNo"), dr_firma_hareket("lVadeFarki"), dr_firma_hareket("sHangiUygulama"), dr_firma_hareket("sHareketTipi"), dr_firma_hareket("sKullaniciAdi"), dr_firma_hareket("dteKayitTarihi"), dr_firma_hareket("sDovizCinsi1"), dr_firma_hareket("lDovizMiktari1"), dr_firma_hareket("lDovizKuru1"), dr_firma_hareket("sDovizCinsi2"), dr_firma_hareket("lDovizMiktari2"), dr_firma_hareket("lDovizKuru2"), dr_firma_hareket("sSonKullaniciAdi"), dr_firma_hareket("dteSonUpdateTarihi"))
                    Else
                        nHareketID = firmahareketi_kaydet_yeni(nHareketID, nFirmaID, dr_firma_hareket("dteIslemTarihi"), dr_firma_hareket("dteValorTarihi"), dr_firma_hareket("sCariIslem"), dr_firma_hareket("sAciklama"), dr_firma_hareket("lBorcTutar"), dr_firma_hareket("lAlacakTutar"), dr_firma_hareket("sEvrakNo"), dr_firma_hareket("lVadeFarki"), dr_firma_hareket("sHangiUygulama"), dr_firma_hareket("sHareketTipi"), dr_firma_hareket("sKullaniciAdi"), dr_firma_hareket("dteKayitTarihi"), dr_firma_hareket("sDovizCinsi1"), dr_firma_hareket("lDovizMiktari1"), dr_firma_hareket("lDovizKuru1"), dr_firma_hareket("sDovizCinsi2"), dr_firma_hareket("lDovizMiktari2"), dr_firma_hareket("lDovizKuru2"), dr_firma_hareket("sSonKullaniciAdi"), dr_firma_hareket("dteSonUpdateTarihi"))
                    End If
                    odemeplani_kaydet_yeni(nStokFisiID, dr_baslik("dteFisTarihi"), Math.Abs(dr_firma_hareket("lBorcTutar") - dr_firma_hareket("lAlacakTutar")), dr_firma_hareket("sCariIslem"), nHareketID)
                    fis_Master_nCariHareketID_degistir(nHareketID)
                Next
            Else
                XtraMessageBox.Show(Sorgu_sDil("Fatura Kaydý Mevcut", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'tbStokFisiDetayi Keys Ekle
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK_tbStokFisiDetayi_nAlisverisID] FOREIGN KEY([nAlisverisID]) REFERENCES [dbo].[tbAlisVeris] ([nAlisverisID]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK_tbStokFisiDetayi_nAlisverisID]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__nFirm__18EC8089] FOREIGN KEY([nFirmaID]) REFERENCES [dbo].[tbFirma] ([nFirmaID])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__nFirm__7073AF84] FOREIGN KEY([nFirmaID]) REFERENCES [dbo].[tbFirma] ([nFirmaID]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK__tbStokFis__nFirm__7073AF84]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__nStok__6F7F8B4B] FOREIGN KEY([nStokID]) REFERENCES [dbo].[tbStok] ([nStokID]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK__tbStokFis__nStok__6F7F8B4B]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__nStok__1BC8ED34] FOREIGN KEY([nStokID]) REFERENCES [dbo].[tbStok] ([nStokID])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__nTran__1CBD116D] FOREIGN KEY([nTransferFirmaID]) REFERENCES [dbo].[tbFirma] ([nFirmaID])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__nTran__7EC1CEDB] FOREIGN KEY([nTransferFirmaID]) REFERENCES [dbo].[tbFirma] ([nFirmaID]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK__tbStokFis__nTran__7EC1CEDB]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sTran__74444068] FOREIGN KEY([sTransferDepo]) REFERENCES [dbo].[tbDepo] ([sDepo]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK__tbStokFis__sTran__74444068]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sTran__2A170C8B] FOREIGN KEY([sTransferDepo]) REFERENCES [dbo].[tbDepo] ([sDepo])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK_StokHareketi_SP] FOREIGN KEY([nSiparisID]) REFERENCES [dbo].[tbSiparis] ([nSiparisID]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK_StokHareketi_SP]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK_StokHareketi_Parti] FOREIGN KEY([nHesapID]) REFERENCES [dbo].[tbParti] ([nPartiID]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK_StokHareketi_Parti]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__nMust__1AD4C8FB] FOREIGN KEY([nMusteriID]) REFERENCES [dbo].[tbMusteri] ([nMusteriID])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__nMust__762C88DA] FOREIGN KEY([nMusteriID]) REFERENCES [dbo].[tbMusteri] ([nMusteriID]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK__tbStokFis__nMust__762C88DA]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sDepo__73501C2F] FOREIGN KEY([sDepo]) REFERENCES [dbo].[tbDepo] ([sDepo]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK__tbStokFis__sDepo__73501C2F]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sDepo__1DB135A6] FOREIGN KEY([sDepo]) REFERENCES [dbo].[tbDepo] ([sDepo])"
            sqlSorguYaz(sqlSorgu)
            'sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sFiya__7814D14C] FOREIGN KEY([sFiyatTipi]) REFERENCES [dbo].[tbFiyatTipi] ([sFiyatTipi]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK__tbStokFis__sFiya__7814D14C]"
            'sqlSorguYaz(sqlSorgu)
            'sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sFiya__2275EAC3] FOREIGN KEY([sFiyatTipi]) REFERENCES [dbo].[tbFiyatTipi] ([sFiyatTipi])"
            'sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sStok__725BF7F6] FOREIGN KEY([sStokIslem]) REFERENCES [dbo].[tbStokIslem] ([sStokIslem]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK__tbStokFis__sStok__725BF7F6]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sKasi__7720AD13] FOREIGN KEY([sKasiyerRumuzu]) REFERENCES [dbo].[tbKasiyer] ([sKasiyerRumuzu]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK__tbStokFis__sKasi__7720AD13]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sSati__79FD19BE] FOREIGN KEY([sSaticiRumuzu]) REFERENCES [dbo].[tbSatici] ([sSaticiRumuzu]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK__tbStokFis__sSati__79FD19BE]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sKasi__2552576E] FOREIGN KEY([sKasiyerRumuzu]) REFERENCES [dbo].[tbKasiyer] ([sKasiyerRumuzu])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sSati__282EC419] FOREIGN KEY([sSaticiRumuzu]) REFERENCES [dbo].[tbSatici] ([sSaticiRumuzu])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sStok__2922E852] FOREIGN KEY([sStokIslem]) REFERENCES [dbo].[tbStokIslem] ([sStokIslem])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__nGiri__19E0A4C2] FOREIGN KEY([nGirisCikis]) REFERENCES [dbo].[tbGirisCikis] ([nGirisCikis])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__nGiri__7167D3BD] FOREIGN KEY([nGirisCikis]) REFERENCES [dbo].[tbGirisCikis] ([nGirisCikis]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK__tbStokFis__nGiri__7167D3BD]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sDovi__1EA559DF] FOREIGN KEY([sDovizCinsi]) REFERENCES [dbo].[tbDovizCinsi] ([sDovizCinsi])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sDovi__1F997E18] FOREIGN KEY([sDovizCinsi1]) REFERENCES [dbo].[tbDovizCinsi] ([sDovizCinsi])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sDovi__208DA251] FOREIGN KEY([sDovizCinsi2]) REFERENCES [dbo].[tbDovizCinsi] ([sDovizCinsi])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sDovi__7908F585] FOREIGN KEY([sDovizCinsi]) REFERENCES [dbo].[tbDovizCinsi] ([sDovizCinsi]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK__tbStokFis__sDovi__7908F585]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sDovi__7CD98669] FOREIGN KEY([sDovizCinsi1]) REFERENCES [dbo].[tbDovizCinsi] ([sDovizCinsi]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK__tbStokFis__sDovi__7CD98669]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sDovi__7DCDAAA2] FOREIGN KEY([sDovizCinsi2]) REFERENCES [dbo].[tbDovizCinsi] ([sDovizCinsi]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK__tbStokFis__sDovi__7DCDAAA2]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sFisT__2181C68A] FOREIGN KEY([sFisTipi]) REFERENCES [dbo].[tbFisTipi] ([sFisTipi])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sFisT__753864A1] FOREIGN KEY([sFisTipi]) REFERENCES [dbo].[tbFisTipi] ([sFisTipi]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK__tbStokFis__sFisT__753864A1]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sHang__00AA174D] FOREIGN KEY([sHangiUygulama]) REFERENCES [dbo].[tbUygulama] ([sUygulamaKodu]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK__tbStokFis__sHang__00AA174D]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sHang__236A0EFC] FOREIGN KEY([sHangiUygulama]) REFERENCES [dbo].[tbUygulama] ([sUygulamaKodu])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sHare__245E3335] FOREIGN KEY([sHareketTipi]) REFERENCES [dbo].[tbHareketTipi] ([sHareketTipi])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sHare__7BE56230] FOREIGN KEY([sHareketTipi]) REFERENCES [dbo].[tbHareketTipi] ([sHareketTipi]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK__tbStokFis__sHare__7BE56230]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sMasr__26467BA7] FOREIGN KEY([sMasrafYontemi]) REFERENCES [dbo].[tbMasrafMerkezi] ([sMasrafYontemi])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sMasr__7FB5F314] FOREIGN KEY([sMasrafYontemi]) REFERENCES [dbo].[tbMasrafMerkezi] ([sMasrafYontemi]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK__tbStokFis__sMasr__7FB5F314]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sOdem__273A9FE0] FOREIGN KEY([sOdemeKodu]) REFERENCES [dbo].[tbOdemePlani] ([sOdemeKodu])"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK__tbStokFis__sOdem__7AF13DF7] FOREIGN KEY([sOdemeKodu]) REFERENCES [dbo].[tbOdemePlani] ([sOdemeKodu]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK__tbStokFis__sOdem__7AF13DF7]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK_tbStokFisiDetayi_nIrsaliyeFisiID] FOREIGN KEY([nIrsaliyeFisiID]) REFERENCES [dbo].[tbStokFisiMaster] ([nStokFisiID]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK_tbStokFisiDetayi_nIrsaliyeFisiID]"
            sqlSorguYaz(sqlSorgu)
            sqlSorgu = "ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK_tbStokFisiDetayi_nStokFisiID] FOREIGN KEY([nStokFisiID]) REFERENCES [dbo].[tbStokFisiMaster] ([nStokFisiID]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK_tbStokFisiDetayi_nStokFisiID]"
            sqlSorguYaz(sqlSorgu)
            fis_resmi_kayit_kontrol()
            XtraMessageBox.Show(Sorgu_sDil("Fatura Kayýt Kontrol Ýþlemi Baþarýyla Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            dr = Nothing
            dr_stok = Nothing
            dr_cari = Nothing
            dr_stok_barkod = Nothing
            dr_renk = Nothing
            dr_stok_sinifi = Nothing
            dr_stok_sinif = Nothing
            fis_kayit_sayisi = Nothing
            stok_kayit_sayisi = Nothing
            cari_kayit_sayisi = Nothing
            renk_kayit_sayisi = Nothing
            sinif_kayit_sayisi = Nothing
        End If
    End Sub
    Private Sub firma()
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = dr_baslik("FIRMAKODU")
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            dr_baslik("FIRMANO") = Trim(dr1("nFirmaID"))
        End If
    End Sub
    Private Sub stok_resmi_kayit_kontrol()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim stok_kayit_sayisi As Int64 = 0
            Dim barkod_var As Boolean = False
            Dim nStokID As Int64 = 0
            Dim dr_stok As DataRow
            'Dim dr_stok_barkod As DataRow
            Dim dr_renk As DataRow
            Dim dr_stok_sinifi As DataRow
            Dim dr_stok_sinif As DataRow
            Dim renk_kayit_sayisi As Int64 = 0
            Dim sinif_kayit_sayisi As Int64 = 0
            stok_kayit_sayisi = sorgu_stok_kontrol(Trim(dr("sKodu")))
            If stok_kayit_sayisi = 0 Then
                'MsgBox(dr("sKodu") & " Kodlu Stok Kaydý Bulunamadý",sDil), MessageBoxIcon.Warning)
                'Stok Bilgini Çek
                dataload_stok(dr("sKodu"))
                'Stok Barkod Bilgisini Çek
                Dim dr_stok_barkod As DataRow
                dataload_stok_barkod(dr("nStokID"))
                If ds_stok_barkod.Tables(0).Rows.Count > 0 Then
                    barkod_var = True
                    dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                Else
                    barkod_var = False
                End If
                'Sýnýf Bilgisini Çek
                dataload_stok_sinif(dr("nStokID"))
                'datarowa yükle
                dr_stok = ds_stok.Tables(0).Rows(0)
                'dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                dr_stok_sinif = ds_stok_sinif.Tables(0).Rows(0)
                renk_kayit_sayisi = sorgu_Renk_kontrol(dr_stok("sRenk"))
                If renk_kayit_sayisi = 0 Then
                    dataload_sRenk(dr_stok("sRenk"))
                    dr_renk = ds_renk.Tables(0).Rows(0)
                    stok_renk_kaydet_yeni(dr_renk("sRenk"), dr_renk("sRenkAdi"), dr_renk("lRenkNo"))
                End If
                'Sýnýf Kayýtlarýný Kontrol Et
                For i As Integer = 1 To 15
                    'MsgBox(dr_stok_sinif("sSinifKodu" & i & ""))
                    sinif_kayit_sayisi = sorgu_Sinif_kontrol(dr_stok_sinif("sSinifKodu" & i & ""), i)
                    If sinif_kayit_sayisi = 0 Then
                        dataload_stok_sinif1(dr_stok_sinif("sSinifKodu" & i & " "), i)
                        dr_stok_sinifi = ds_stok_sinif.Tables(0).Rows(0)
                        stok_sinif_kaydet_yeni(dr_stok_sinifi("sStokSinifi"), dr_stok_sinifi("sAciklama"), i)
                    End If
                Next
                'Stoðu Kaydet
                nStokID = stok_kaydet_yeni(dr_stok("sKodu"), dr_stok("sAciklama"), dr_stok("sKisaAdi"), dr_stok("nStokTipi"), dr_stok("sBedenTipi"), dr_stok("sKavalaTipi"), dr_stok("sRenk"), dr_stok("sBeden"), dr_stok("sKavala"), dr_stok("sBirimCinsi1"), dr_stok("sBirimCinsi2"), dr_stok("nIskontoYuzdesi"), dr_stok("sKdvTipi"), dr_stok("nTeminSuresi"), dr_stok("lAsgariMiktar"), dr_stok("lAzamiMiktar"), dr_stok("sOzelNot"), dr_stok("nFiyatlandirma"), dr_stok("sModel"), dr_stok("sKullaniciAdi"), dr_stok("dteKayitTarihi"), dr_stok("bEksiyeDusulebilirmi"), dr_stok("sDefaultAsortiTipi"), dr_stok("bEksideUyarsinmi"), dr_stok("bOTVVar"), dr_stok("sOTVTipi"), dr_stok("nIskontoYuzdesiAV"), dr_stok("bEk1"), dr_stok("nEk2"))
                'barkodu kaydet
                If barkod_var = True Then
                    dr_stok_barkod = ds_stok_barkod.Tables(0).Rows(0)
                    stok_barkod_kaydet_yeni(nStokID, dr_stok_barkod("sBarkod"), dr_stok_barkod("nKisim"), dr_stok_barkod("nFirmaID"), dr_stok_barkod("sKarsiStokKodu"), dr_stok_barkod("sKarsiStokAciklama"))
                End If
                'sýnýflarý kaydet
                stok_siniflari_kaydet_yeni(nStokID, dr_stok_sinif("sSinifKodu1"), dr_stok_sinif("sSinifKodu2"), dr_stok_sinif("sSinifKodu3"), dr_stok_sinif("sSinifKodu4"), dr_stok_sinif("sSinifKodu5"), dr_stok_sinif("sSinifKodu6"), "01", dr_stok_sinif("sSinifKodu8"), dr_stok_sinif("sSinifKodu9"), dr_stok_sinif("sSinifKodu10"), dr_stok_sinif("sSinifKodu11"), dr_stok_sinif("sSinifKodu12"), dr_stok_sinif("sSinifKodu13"), dr_stok_sinif("sSinifKodu14"), dr_stok_sinif("sSinifKodu15"))
            Else
                nStokID = sorgu_nStokID(Trim(dr("sKodu")))
                'MsgBox(dr("sKodu") & " Kodlu Stok Kaydý var..!!!",sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
                'MsgBox(nStokID)
            End If
        End If
    End Sub
    Private Sub belge_tarih_degistir()
        Dim frm As New frm_stok_cari_alis_aciklama
        frm.txt_belgeno.Text = dr_baslik("lFisNo")
        frm.txt_tarih.EditValue = dr_baslik("dteFisTarihi")
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim fis_kayit_sayisi As Int64 = 0
            fis_kayit_sayisi = sorgu_fis_kontrol(dr_baslik("sFisTipi").ToString, dr_baslik("nGirisCikis"), frm.txt_tarih.Text, frm.txt_belgeno.Text, dr_baslik("nFirmaID"), False)
            If fis_kayit_sayisi = 0 Then
                fis_Master_degistir(dr_baslik("sFisTipi"), dr_baslik("nGirisCikis"), dr_baslik("dteFisTarihi"), dr_baslik("lFisNo"), dr_baslik("nFirmaID"), frm.txt_belgeno.EditValue, frm.txt_tarih.EditValue, dr_baslik("nEvrakNo"))
                fis_detay_degistir(dr_baslik("sFisTipi"), dr_baslik("nGirisCikis"), dr_baslik("dteFisTarihi"), dr_baslik("lFisNo"), dr_baslik("nFirmaID"), frm.txt_belgeno.EditValue, frm.txt_tarih.EditValue)
                fis_firma_hareket_degistir(dr_baslik("sFisTipi"), dr_baslik("dteFisTarihi"), dr_baslik("lFisNo"), dr_baslik("nFirmaID"), frm.txt_belgeno.EditValue, frm.txt_tarih.EditValue)
                dr_baslik("dteFisTarihi") = frm.txt_tarih.EditValue
                dr_baslik("lFisNo") = frm.txt_belgeno.Text
                XtraMessageBox.Show(Sorgu_sDil("Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show(Sorgu_sDil("Ayný Belge Numarasý Kullanýlmýþ...!!!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            fis_kayit_sayisi = Nothing
        End If
    End Sub
    Private Sub BarButtonItem28_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        analiz_stok_adi()
    End Sub
    Private Sub BarButtonItem29_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem29.ItemClick
        belge_tarih_degistir()
    End Sub
    Private Sub frm_stok_cari_alis_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'ds_baslik = Nothing
        'ds_hareket = Nothing
        'ds_toplam = Nothing
        'BarManager1 = Nothing
        'barDockControlTop = Nothing
        'barDockControlBottom = Nothing
        'barDockControlLeft = Nothing
        'barDockControlRight = Nothing
        'Bar2 = Nothing
        'Bar3 = Nothing
        'BarSubItem1 = Nothing
        'BarSubItem2 = Nothing
        'BarSubItem3 = Nothing
        'BarSubItem4 = Nothing
        'BarSubItem5 = Nothing
        'BarButtonItem1 = Nothing
        'Panel_baslik = Nothing
        'Panel_toplamlar = Nothing
        'Panel_satir = Nothing
        'GroupControl1 = Nothing
        'GroupControl2 = Nothing
        'GroupControl3 = Nothing
        'SplitterControl1 = Nothing
        'Panel_hareket = Nothing
        'Label1 = Nothing
        'GridControl1 = Nothing
        'GridView1 = Nothing
        'VGrid_baslik = Nothing
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
        'DataColumn19 = Nothing
        'DataColumn20 = Nothing
        'DataColumn21 = Nothing
        'DataColumn22 = Nothing
        'DataColumn23 = Nothing
        'DataColumn24 = Nothing
        'DataColumn25 = Nothing
        'DataColumn26 = Nothing
        'rownFirmaID = Nothing
        'rowsKodu = Nothing
        'rowsAciklama = Nothing
        'rownOzelIskontosu = Nothing
        'rowlKrediLimiti = Nothing
        'rowsFiyatTipi = Nothing
        'rowADRES = Nothing
        'rowsVergiDairesi = Nothing
        'rowsVergiNo = Nothing
        'rownStokFisiID = Nothing
        'rowsFisTipi = Nothing
        'rowdteFisTarihi = Nothing
        'rownGirisCikis = Nothing
        'rowlFisNo = Nothing
        'rowbPesinmi = Nothing
        'rowbListelendimi = Nothing
        'rowbHizmetFaturasimi = Nothing
        'rowbFisTamamlandimi = Nothing
        'rowbMuhasebeyeIslendimi = Nothing
        'rowsHareketTipi = Nothing
        'rowdteKayitTarih = Nothing
        'rowsAciklama1 = Nothing
        'rowsAciklama2 = Nothing
        'rowsAciklama3 = Nothing
        'rowsAciklama4 = Nothing
        'rowsAciklama5 = Nothing
        'categoryTanýmlar = Nothing
        'categoryFirmaBilgileri = Nothing
        'categoryAçýklamalar = Nothing
        'categorySorgular = Nothing
        'VGrid_toplam = Nothing
        'VGrid_masraf = Nothing
        'VGrid_iskonto = Nothing
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
        'ds_masraf = Nothing
        'DataTable3 = Nothing
        'DataColumn57 = Nothing
        'DataColumn58 = Nothing
        'DataColumn59 = Nothing
        'DataColumn60 = Nothing
        'EditorRow1 = Nothing
        'rowlEkMaliyet1 = Nothing
        'rowlEkMaliyet2 = Nothing
        'rowlEkMaliyet3 = Nothing
        'ds_iskonto = Nothing
        'DataTable4 = Nothing
        'DataColumn61 = Nothing
        'DataColumn62 = Nothing
        'DataColumn63 = Nothing
        'DataColumn64 = Nothing
        'DataColumn65 = Nothing
        'DataColumn66 = Nothing
        'EditorRow2 = Nothing
        'rowlDipIskontoTutari3 = Nothing
        'rowDIPISK1 = Nothing
        'rowDIPISK2 = Nothing
        'DataTable5 = Nothing
        'DataColumn67 = Nothing
        'DataColumn68 = Nothing
        'DataColumn69 = Nothing
        'DataColumn70 = Nothing
        'DataColumn71 = Nothing
        'DataColumn72 = Nothing
        'DataColumn73 = Nothing
        'DataColumn74 = Nothing
        'EditorRow3 = Nothing
        'rowlToplamMiktar = Nothing
        'rowlMalBedeli = Nothing
        'rowlMalIskontoTutari = Nothing
        'EditorRow4 = Nothing
        'rownKdvOrani1 = Nothing
        'row_lKdvMatrahi1 = Nothing
        'rowlNetTutar = Nothing
        'BarButtonItem2 = Nothing
        'BarButtonItem3 = Nothing
        'BarSubItem6 = Nothing
        'BarButtonItem4 = Nothing
        'BarButtonItem5 = Nothing
        'BarButtonItem6 = Nothing
        'BarButtonItem7 = Nothing
        'BarButtonItem8 = Nothing
        'BarButtonItem9 = Nothing
        'BarButtonItem10 = Nothing
        'BarButtonItem11 = Nothing
        'BarButtonItem12 = Nothing
        'BarButtonItem13 = Nothing
        'BarButtonItem14 = Nothing
        'collBrutFiyat = Nothing
        'collBrutTutar = Nothing
        'BarButtonItem15 = Nothing
        'BarButtonItem16 = Nothing
        'DataColumn75 = Nothing
        'colONCEKIMALIYET = Nothing
        'BarButtonItem17 = Nothing
        'BarButtonItem18 = Nothing
        'BarButtonItem19 = Nothing
        'BarButtonItem20 = Nothing
        'BarButtonItem21 = Nothing
        'BarButtonItem22 = Nothing
        'BarButtonItem23 = Nothing
        'Label2 = Nothing
        'colsRenk = Nothing
        'sec_Renk = Nothing
        'BarButtonItem24 = Nothing
        'BarButtonItem25 = Nothing
        'BarButtonItem26 = Nothing
        'BarButtonItem27 = Nothing
        'BarButtonItem28 = Nothing
        'BarButtonItem29 = Nothing
        'status = Nothing
        'connection = Nothing
        'connection_resmi = Nothing
        'firmano = Nothing
        'donemno = Nothing
        'stokno = Nothing
        'userno = Nothing
        'dr_baslik = Nothing
        'dr_hareket = Nothing
        'dr_toplam = Nothing
        'dr_masraf = Nothing
        'dr_iskonto = Nothing
        'cmd = Nothing
        'con = Nothing
        'adapter = Nothing
        'belgeind = Nothing
        'miktar = Nothing
        'detay_miktar = Nothing
        'depokodu = Nothing
        'dr = Nothing
        'qr_hareket = Nothing
        'qr_baslik = Nothing
        'ds_satici = Nothing
        'ds_alislar = Nothing
        'ds_satir_stok = Nothing
        'ds_satir_firma = Nothing
        'fistipi = Nothing
        'tarih = Nothing
        'firmaID = Nothing
        'fisno = Nothing
        'ngiriscikis = Nothing
        'ds_stok = Nothing
        'ds_stok_fisi = Nothing
        'ds_stok_barkod = Nothing
        'ds_stok_sinif = Nothing
        'ds_firma = Nothing
        'ds_renk = Nothing
        'yuklendi = Nothing
        'Me.Close()
        System.GC.Collect()
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        raporla(0, 2)
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        raporla(0, 0)
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        raporla(0, 1)
    End Sub
    Private Sub BarButtonItem30_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem30.ItemClick
        analiz_Firma_karti()
    End Sub
    Private Sub BarButtonItem33_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem33.ItemClick
        Dim s = connection_resmi
        connection_resmi = connection_ors
        faturalastir(True)
        connection_resmi = s
    End Sub
    Private Sub BarButtonItem32_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem32.ItemClick
        Dim s = connection_resmi
        connection_resmi = connection_ors
        faturalastir()
        connection_resmi = s
    End Sub
    Private Sub BarButtonItem34_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem34.ItemClick
        Dim s = connection_resmi
        connection_resmi = connection_ors
        faturalastir(True, True)
        connection_resmi = s
    End Sub

    ' === SIPARIS RISK GOSTERGESI ===
    Private Sub SiparisRiskKontrol()
        Try
            Dim sKodu As String = ""
            Try : sKodu = dr_baslik("sKodu").ToString().Trim() : Catch : End Try
            If sKodu = "" Then Exit Sub

            Dim nFid As Int64 = sorgu_nfirmaID(sKodu)
            If nFid <= 0 Then Exit Sub

            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = connection_resmi
            con.Open()
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = con

            ' Bakiye
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & _
                "ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS Bakiye, " & _
                "ISNULL(SUM(CASE WHEN lBorcTutar > 0 AND dteValorTarihi < GETDATE() THEN lBorcTutar - lAlacakTutar ELSE 0 END), 0) AS VadesiGecmis, " & _
                "ISNULL(MAX(CASE WHEN lBorcTutar > 0 AND dteValorTarihi < GETDATE() THEN DATEDIFF(DAY, dteValorTarihi, GETDATE()) ELSE 0 END), 0) AS MaxGecikmeGun " & _
                "FROM tbFirmaHareketi WHERE nFirmaID=" & nFid)
            Dim drRisk As OleDb.OleDbDataReader = cmd.ExecuteReader()
            Dim bakiye As Decimal = 0
            Dim vadesiGecmis As Decimal = 0
            Dim maxGecikmeGun As Integer = 0
            If drRisk.Read() Then
                bakiye = CDec(drRisk("Bakiye"))
                vadesiGecmis = CDec(drRisk("VadesiGecmis"))
                maxGecikmeGun = CInt(drRisk("MaxGecikmeGun"))
            End If
            drRisk.Close()

            ' Kredi limiti
            cmd.CommandText = sorgu_query("SELECT ISNULL(lKrediLimiti,0) FROM tbFirma WHERE nFirmaID=" & nFid)
            Dim krediLimiti As Decimal = 0
            Try : krediLimiti = CDec(cmd.ExecuteScalar()) : Catch : End Try

            ' Bekleyen siparisler
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " & _
                "SELECT ISNULL(COUNT(DISTINCT lSiparisNo),0) AS Adet, ISNULL(SUM(lTutari),0) AS Tutar " & _
                "FROM tbSiparis WHERE nFirmaID=" & nFid & " AND ISNULL(bKapandimi,0)=0")
            Dim drSip As OleDb.OleDbDataReader = cmd.ExecuteReader()
            Dim bekAdet As Integer = 0
            Dim bekTutar As Decimal = 0
            If drSip.Read() Then
                bekAdet = CInt(drSip("Adet"))
                bekTutar = CDec(drSip("Tutar"))
            End If
            drSip.Close()
            con.Close()

            ' Risk Ayari aktif mi?
            Dim sRiskAktif As String = "0"
            Try
                Dim conAyar As New OleDb.OleDbConnection
                conAyar.ConnectionString = connection_resmi
                conAyar.Open()
                Dim cmdA As New OleDb.OleDbCommand
                cmdA.Connection = conAyar
                cmdA.CommandText = sorgu_query("SELECT ISNULL(sAyarDeger,'0') FROM tbSistemAyar WHERE sAyarKodu='RISK_SKORU_AKTIF'")
                Try : sRiskAktif = cmdA.ExecuteScalar().ToString() : Catch : End Try
                conAyar.Close()
            Catch : End Try
            If sRiskAktif <> "1" Then Exit Sub

            ' Skor hesapla
            Dim skor As Integer = 100
            If maxGecikmeGun > 90 Then : skor -= 40
            ElseIf maxGecikmeGun > 60 Then : skor -= 30
            ElseIf maxGecikmeGun > 30 Then : skor -= 20
            ElseIf maxGecikmeGun > 0 Then : skor -= 10
            End If
            If bakiye > 0 AndAlso vadesiGecmis > 0 Then
                If vadesiGecmis / bakiye > 0.5D Then skor -= 15
            End If
            If krediLimiti > 0 Then
                Dim toplamYuk As Decimal = bakiye + bekTutar
                If toplamYuk > krediLimiti Then : skor -= 20
                ElseIf toplamYuk / krediLimiti > 0.9D Then : skor -= 15
                End If
            End If
            skor = Math.Max(0, Math.Min(100, skor))

            If skor >= 70 Then Exit Sub ' Guvenli ise gosterme

            Dim seviye As String = If(skor >= 40, "DIKKAT", "KRITIK")
            Dim renk As Color = If(skor >= 40, Color.FromArgb(243, 156, 18), Color.FromArgb(231, 76, 60))

            Dim metin As String = "RISK: " & skor & "/100 (" & seviye & ") | Bakiye: " & bakiye.ToString("N2") & " TL"
            If vadesiGecmis > 0 Then metin &= " | Geciken: " & vadesiGecmis.ToString("N2") & " (" & maxGecikmeGun & " gun)"
            If krediLimiti > 0 Then metin &= " | Limit: %" & Math.Round(bakiye / krediLimiti * 100, 0)
            If bekAdet > 0 Then metin &= " | Bek.Siparis: " & bekAdet & " adet"

            If pnlSiparisRisk Is Nothing Then
                pnlSiparisRisk = New Panel()
                pnlSiparisRisk.Dock = DockStyle.Top
                pnlSiparisRisk.Height = 30
                pnlSiparisRisk.Padding = New Padding(8, 4, 8, 4)
                pnlSiparisRisk.Visible = True

                lblSiparisRisk = New Label()
                lblSiparisRisk.AutoSize = True
                lblSiparisRisk.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                lblSiparisRisk.ForeColor = Color.White
                lblSiparisRisk.Location = New Point(8, 6)

                pnlSiparisRisk.Controls.Add(lblSiparisRisk)
                Me.Controls.Add(pnlSiparisRisk)
                pnlSiparisRisk.BringToFront()
            End If

            pnlSiparisRisk.BackColor = renk
            lblSiparisRisk.Text = metin
            pnlSiparisRisk.Visible = True

            ' Kritik durum icin uyari goster
            If skor < 40 Then
                MessageBox.Show("DIKKAT: Bu firma KRITIK risk seviyesindedir!" & vbCrLf & vbCrLf & _
                    metin & vbCrLf & vbCrLf & _
                    "Fatura islemini dikkatli yapiniz.", _
                    "Siparis Risk Uyarisi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            ' Risk kontrolu basarisiz olsa bile formu engelleme
        End Try
    End Sub

End Class