Imports FastReport
Imports DevExpress.XtraEditors
Imports System.IO
Imports Microsoft.Win32
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraPrinting
Imports DevExpress.Data
Imports DevExpress.XtraExport
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTab
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Events
Imports DevExpress.XtraVerticalGrid.Rows
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms
Public Class frm_uretim_emir
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
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents panel_baslik As DevExpress.XtraEditors.PanelControl
    Friend WithEvents panel_toplam As DevExpress.XtraEditors.PanelControl
    Friend WithEvents panel_info As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem6 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem8 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem9 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents ds_baslik As System.Data.DataSet
    Friend WithEvents ds_hareket As System.Data.DataSet
    Friend WithEvents ds_toplam As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents VGrid_baslik As DevExpress.XtraVerticalGrid.VGridControl
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
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem17 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem18 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DataTable2 As System.Data.DataTable
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
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents rowIND As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSTOKNO As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKULLANICI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSONERISIMTARIHI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSTOKKODU As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMALINCINSI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBIRIM As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFIYAT As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKDV As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowOZELKOD As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowACIKLAMA As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSTOKTIPI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMIKTAR As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSATISFIYATI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowURETIMGIRISHESAPKODU As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSTANDARTSURE As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowRESIM As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD4 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD5 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD6 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD7 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD8 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD9 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKOD10 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents ds_pozisyon As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSIRANO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEVRAKNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOZISYONNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURETIMYERINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURETIMYERIKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPONO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPOKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMALIYET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTOPLAMMALIYET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTANDARTSURE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTANDARTBIRIMSURE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSUREHASAPLAMATURU As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents DataColumn65 As System.Data.DataColumn
    Friend WithEvents DataColumn66 As System.Data.DataColumn
    Friend WithEvents DataColumn67 As System.Data.DataColumn
    Friend WithEvents DataColumn68 As System.Data.DataColumn
    Friend WithEvents DataColumn69 As System.Data.DataColumn
    Friend WithEvents DataColumn70 As System.Data.DataColumn
    Friend WithEvents colIND1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDETAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEVRAKNO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMALINCINSI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBIRIM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBARCODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBIRIMMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKDV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISLEMTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSONERISIMTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKULLANICI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTUR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPONO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMALIYETTURU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIKTARTURU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURETIMCIKISHESAPKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYANSITMAHESAPKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOZISYONNO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIKISPOZISYONNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIREORANI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colARACLINENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ds_cikti As System.Data.DataSet
    Friend WithEvents DataTable4 As System.Data.DataTable
    Friend WithEvents DataColumn71 As System.Data.DataColumn
    Friend WithEvents DataColumn72 As System.Data.DataColumn
    Friend WithEvents DataColumn73 As System.Data.DataColumn
    Friend WithEvents DataColumn74 As System.Data.DataColumn
    Friend WithEvents DataColumn75 As System.Data.DataColumn
    Friend WithEvents DataColumn76 As System.Data.DataColumn
    Friend WithEvents DataColumn77 As System.Data.DataColumn
    Friend WithEvents DataColumn78 As System.Data.DataColumn
    Friend WithEvents DataColumn79 As System.Data.DataColumn
    Friend WithEvents DataColumn80 As System.Data.DataColumn
    Friend WithEvents DataColumn81 As System.Data.DataColumn
    Friend WithEvents DataColumn82 As System.Data.DataColumn
    Friend WithEvents DataColumn83 As System.Data.DataColumn
    Friend WithEvents DataColumn84 As System.Data.DataColumn
    Friend WithEvents DataColumn85 As System.Data.DataColumn
    Friend WithEvents DataColumn86 As System.Data.DataColumn
    Friend WithEvents DataColumn87 As System.Data.DataColumn
    Friend WithEvents DataColumn88 As System.Data.DataColumn
    Friend WithEvents DataColumn89 As System.Data.DataColumn
    Friend WithEvents DataColumn90 As System.Data.DataColumn
    Friend WithEvents DataColumn91 As System.Data.DataColumn
    Friend WithEvents DataColumn92 As System.Data.DataColumn
    Friend WithEvents DataColumn93 As System.Data.DataColumn
    Friend WithEvents DataColumn94 As System.Data.DataColumn
    Friend WithEvents DataColumn95 As System.Data.DataColumn
    Friend WithEvents colIND2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDETAY1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEVRAKNO2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKNO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKKODU1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMALINCINSI1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIKTAR1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBIRIM1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBIRIMMIKTAR1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKDV1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBARCODE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISLEMTARIHI1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSONERISIMTARIHI1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKULLANICI1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTUR1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRECETENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTUTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOZISYONNO2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIREORANI1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIREMIKTARI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKALANMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIREYANSIMAORANI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRETUTARI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ds_maliyet As System.Data.DataSet
    Friend WithEvents DataTable5 As System.Data.DataTable
    Friend WithEvents DataColumn96 As System.Data.DataColumn
    Friend WithEvents DataColumn97 As System.Data.DataColumn
    Friend WithEvents DataColumn98 As System.Data.DataColumn
    Friend WithEvents DataColumn99 As System.Data.DataColumn
    Friend WithEvents DataColumn100 As System.Data.DataColumn
    Friend WithEvents rowMASRAF As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMASRAFORANI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowHAMMADDE As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowHAMMADDEORANI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowTOPLAM As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents DataTable6 As System.Data.DataTable
    Friend WithEvents DataColumn101 As System.Data.DataColumn
    Friend WithEvents DataColumn102 As System.Data.DataColumn
    Friend WithEvents DataColumn103 As System.Data.DataColumn
    Friend WithEvents DataColumn104 As System.Data.DataColumn
    Friend WithEvents DataColumn105 As System.Data.DataColumn
    Friend WithEvents DataColumn106 As System.Data.DataColumn
    Friend WithEvents rowBIRIMMALIYET As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKARORANI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKAR As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents EditorRow2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents EditorRow3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowGENELTOPLAM As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents ds_arac As System.Data.DataSet
    Friend WithEvents DataTable7 As System.Data.DataTable
    Friend WithEvents DataColumn107 As System.Data.DataColumn
    Friend WithEvents DataColumn108 As System.Data.DataColumn
    Friend WithEvents DataColumn109 As System.Data.DataColumn
    Friend WithEvents DataColumn110 As System.Data.DataColumn
    Friend WithEvents DataColumn111 As System.Data.DataColumn
    Friend WithEvents DataColumn112 As System.Data.DataColumn
    Friend WithEvents DataColumn113 As System.Data.DataColumn
    Friend WithEvents DataColumn114 As System.Data.DataColumn
    Friend WithEvents DataColumn115 As System.Data.DataColumn
    Friend WithEvents colIND3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSIRANO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEVRAKNO3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colARACNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colARACKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCALISMAUSULU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOZISYONNO3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIKTAR2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBIRIMMIKTAR2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EditorRow30 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents sec_aciklama As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents rowTUTAR As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents sec_girdi_turu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ds_girdi_tur As System.Data.DataSet
    Friend WithEvents DataTable8 As System.Data.DataTable
    Friend WithEvents DataColumn116 As System.Data.DataColumn
    Friend WithEvents DataColumn117 As System.Data.DataColumn
    Friend WithEvents ds_depolar As System.Data.DataSet
    Friend WithEvents sec_depo_girdi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_birim_girdi As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents sec_fiyat_girdi As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents sec_miktar_girdi As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents sec_pozisyon_girdi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_depo_pozisyon As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_pozisyon_cikti As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_fiyat_cikti As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents sec_miktar_cikti As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents sec_fiyat_pozisyon As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents sec_miktar_pozisyon As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colHTUTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn118 As System.Data.DataColumn
    Friend WithEvents ds_cikti_tur As System.Data.DataSet
    Friend WithEvents DataTable9 As System.Data.DataTable
    Friend WithEvents DataColumn119 As System.Data.DataColumn
    Friend WithEvents DataColumn120 As System.Data.DataColumn
    Friend WithEvents sec_tur_cikti As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kisayol_cikti As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents kisayol_pozisyon As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents kisayol_girdi As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents DataColumn121 As System.Data.DataColumn
    Friend WithEvents DataColumn122 As System.Data.DataColumn
    Friend WithEvents DataColumn123 As System.Data.DataColumn
    Friend WithEvents rowFIRE As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFIREORANI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFIREMIKTARI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents BarButtonItem19 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem5 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem20 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem21 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents VGrid_maliyet As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents VGrid_geneltoplam As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents kisayol_arac As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_pozisyon_arac As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_calismausulu_arac As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ds_calismausulu As System.Data.DataSet
    Friend WithEvents DataTable10 As System.Data.DataTable
    Friend WithEvents DataColumn124 As System.Data.DataColumn
    Friend WithEvents DataColumn125 As System.Data.DataColumn
    Friend WithEvents BarButtonItem22 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents VGrid_aciklama As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents sec_resim As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents DataColumn126 As System.Data.DataColumn
    Friend WithEvents DataColumn127 As System.Data.DataColumn
    Friend WithEvents DataColumn128 As System.Data.DataColumn
    Friend WithEvents DataColumn129 As System.Data.DataColumn
    Friend WithEvents DataColumn130 As System.Data.DataColumn
    Friend WithEvents DataColumn131 As System.Data.DataColumn
    Friend WithEvents DataColumn132 As System.Data.DataColumn
    Friend WithEvents rowDURUM As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowTARIH As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFISNO As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPOZNO As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowTERMIN As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowURETIMEBASLAMATARIHI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowURETIMBITISTARIHI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents CategoryRow1 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents CategoryRow2 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents CategoryRow3 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents sec_pozisyon_baslik As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DataColumn133 As System.Data.DataColumn
    Friend WithEvents DataColumn134 As System.Data.DataColumn
    Friend WithEvents DataColumn135 As System.Data.DataColumn
    Friend WithEvents DataColumn136 As System.Data.DataColumn
    Friend WithEvents DataColumn137 As System.Data.DataColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_uretim_emir))
        Me.panel_baslik = New DevExpress.XtraEditors.PanelControl()
        Me.VGrid_baslik = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.ds_baslik = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn21 = New System.Data.DataColumn()
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        Me.DataColumn25 = New System.Data.DataColumn()
        Me.DataColumn26 = New System.Data.DataColumn()
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
        Me.DataColumn126 = New System.Data.DataColumn()
        Me.DataColumn127 = New System.Data.DataColumn()
        Me.DataColumn128 = New System.Data.DataColumn()
        Me.DataColumn129 = New System.Data.DataColumn()
        Me.DataColumn130 = New System.Data.DataColumn()
        Me.DataColumn131 = New System.Data.DataColumn()
        Me.DataColumn132 = New System.Data.DataColumn()
        Me.DataColumn137 = New System.Data.DataColumn()
        Me.DataColumn138 = New System.Data.DataColumn()
        Me.sec_resim = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.sec_pozisyon_baslik = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.rowSTOKNO = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKULLANICI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSONERISIMTARIHI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowACIKLAMA = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSTOKTIPI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowURETIMGIRISHESAPKODU = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD4 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD5 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD6 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD7 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD8 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD9 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKOD10 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDURUM = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.CategoryRow3 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowMIKTAR = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPOZNO = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSTANDARTSURE = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowIND = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowOZELKOD = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.CategoryRow1 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowTARIH = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFISNO = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowTERMIN = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowURETIMEBASLAMATARIHI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowURETIMBITISTARIHI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.CategoryRow2 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowSTOKKODU = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMALINCINSI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBIRIM = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFIYAT = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowTUTAR = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKDV = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSATISFIYATI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowRESIM = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.panel_toplam = New DevExpress.XtraEditors.PanelControl()
        Me.VGrid_maliyet = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.ds_maliyet = New System.Data.DataSet()
        Me.DataTable5 = New System.Data.DataTable()
        Me.DataColumn96 = New System.Data.DataColumn()
        Me.DataColumn97 = New System.Data.DataColumn()
        Me.DataColumn98 = New System.Data.DataColumn()
        Me.DataColumn99 = New System.Data.DataColumn()
        Me.DataColumn100 = New System.Data.DataColumn()
        Me.DataColumn121 = New System.Data.DataColumn()
        Me.DataColumn122 = New System.Data.DataColumn()
        Me.DataColumn123 = New System.Data.DataColumn()
        Me.rowMASRAF = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMASRAFORANI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowHAMMADDE = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowHAMMADDEORANI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFIRE = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFIREMIKTARI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFIREORANI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowTOPLAM = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.VGrid_aciklama = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.sec_aciklama = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.EditorRow30 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.VGrid_geneltoplam = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.ds_toplam = New System.Data.DataSet()
        Me.DataTable6 = New System.Data.DataTable()
        Me.DataColumn101 = New System.Data.DataColumn()
        Me.DataColumn102 = New System.Data.DataColumn()
        Me.DataColumn103 = New System.Data.DataColumn()
        Me.DataColumn104 = New System.Data.DataColumn()
        Me.DataColumn105 = New System.Data.DataColumn()
        Me.DataColumn106 = New System.Data.DataColumn()
        Me.rowBIRIMMALIYET = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKARORANI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKAR = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.EditorRow2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.EditorRow3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowGENELTOPLAM = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.panel_info = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_girdi = New System.Windows.Forms.ContextMenu()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.ds_hareket = New System.Data.DataSet()
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
        Me.DataColumn64 = New System.Data.DataColumn()
        Me.DataColumn65 = New System.Data.DataColumn()
        Me.DataColumn66 = New System.Data.DataColumn()
        Me.DataColumn67 = New System.Data.DataColumn()
        Me.DataColumn68 = New System.Data.DataColumn()
        Me.DataColumn69 = New System.Data.DataColumn()
        Me.DataColumn70 = New System.Data.DataColumn()
        Me.DataColumn118 = New System.Data.DataColumn()
        Me.DataColumn139 = New System.Data.DataColumn()
        Me.DataColumn140 = New System.Data.DataColumn()
        Me.DataColumn141 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIND1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOKNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDETAY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEVRAKNO1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOKKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMALINCINSI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_miktar_girdi = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colBIRIM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_birim_girdi = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colBARCODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBIRIMMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKDV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_fiyat_girdi = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colISLEMTARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSONERISIMTARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKULLANICI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTUR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_girdi_turu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DataTable8 = New System.Data.DataTable()
        Me.DataColumn116 = New System.Data.DataColumn()
        Me.DataColumn117 = New System.Data.DataColumn()
        Me.colDEPONO1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_depo_girdi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colACIKLAMA1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMALIYETTURU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMIKTARTURU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURETIMCIKISHESAPKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYANSITMAHESAPKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOZISYONNO1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_pozisyon_girdi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colCIKISPOZISYONNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIREORANI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colARACLINENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHTUTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDovizCinsi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_DovizCinsi_girdi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.collDovizKuru1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizMiktari1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_pozisyon = New System.Windows.Forms.ContextMenu()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.ds_pozisyon = New System.Data.DataSet()
        Me.DataTable3 = New System.Data.DataTable()
        Me.DataColumn49 = New System.Data.DataColumn()
        Me.DataColumn50 = New System.Data.DataColumn()
        Me.DataColumn51 = New System.Data.DataColumn()
        Me.DataColumn52 = New System.Data.DataColumn()
        Me.DataColumn53 = New System.Data.DataColumn()
        Me.DataColumn54 = New System.Data.DataColumn()
        Me.DataColumn55 = New System.Data.DataColumn()
        Me.DataColumn56 = New System.Data.DataColumn()
        Me.DataColumn57 = New System.Data.DataColumn()
        Me.DataColumn58 = New System.Data.DataColumn()
        Me.DataColumn59 = New System.Data.DataColumn()
        Me.DataColumn60 = New System.Data.DataColumn()
        Me.DataColumn61 = New System.Data.DataColumn()
        Me.DataColumn62 = New System.Data.DataColumn()
        Me.DataColumn63 = New System.Data.DataColumn()
        Me.DataColumn133 = New System.Data.DataColumn()
        Me.DataColumn134 = New System.Data.DataColumn()
        Me.DataColumn135 = New System.Data.DataColumn()
        Me.DataColumn136 = New System.Data.DataColumn()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSIRANO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEVRAKNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOZISYONNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURETIMYERINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURETIMYERIKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEPONO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_depo_pozisyon = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colDEPOKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMALIYET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_fiyat_pozisyon = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colTOPLAMMALIYET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTANDARTSURE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_miktar_pozisyon = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colSTANDARTBIRIMSURE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSUREHASAPLAMATURU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_cikti = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.ds_cikti = New System.Data.DataSet()
        Me.DataTable4 = New System.Data.DataTable()
        Me.DataColumn71 = New System.Data.DataColumn()
        Me.DataColumn72 = New System.Data.DataColumn()
        Me.DataColumn73 = New System.Data.DataColumn()
        Me.DataColumn74 = New System.Data.DataColumn()
        Me.DataColumn75 = New System.Data.DataColumn()
        Me.DataColumn76 = New System.Data.DataColumn()
        Me.DataColumn77 = New System.Data.DataColumn()
        Me.DataColumn78 = New System.Data.DataColumn()
        Me.DataColumn79 = New System.Data.DataColumn()
        Me.DataColumn80 = New System.Data.DataColumn()
        Me.DataColumn81 = New System.Data.DataColumn()
        Me.DataColumn82 = New System.Data.DataColumn()
        Me.DataColumn83 = New System.Data.DataColumn()
        Me.DataColumn84 = New System.Data.DataColumn()
        Me.DataColumn85 = New System.Data.DataColumn()
        Me.DataColumn86 = New System.Data.DataColumn()
        Me.DataColumn87 = New System.Data.DataColumn()
        Me.DataColumn88 = New System.Data.DataColumn()
        Me.DataColumn89 = New System.Data.DataColumn()
        Me.DataColumn90 = New System.Data.DataColumn()
        Me.DataColumn91 = New System.Data.DataColumn()
        Me.DataColumn92 = New System.Data.DataColumn()
        Me.DataColumn93 = New System.Data.DataColumn()
        Me.DataColumn94 = New System.Data.DataColumn()
        Me.DataColumn95 = New System.Data.DataColumn()
        Me.DataColumn142 = New System.Data.DataColumn()
        Me.DataColumn143 = New System.Data.DataColumn()
        Me.DataColumn144 = New System.Data.DataColumn()
        Me.DataColumn145 = New System.Data.DataColumn()
        Me.DataColumn146 = New System.Data.DataColumn()
        Me.DataColumn147 = New System.Data.DataColumn()
        Me.DataColumn148 = New System.Data.DataColumn()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIND2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDETAY1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEVRAKNO2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOKNO1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOKKODU1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMALINCINSI1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMIKTAR1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_miktar_cikti = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colBIRIM1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBIRIMMIKTAR1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKDV1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_fiyat_cikti = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colBARCODE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISLEMTARIHI1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSONERISIMTARIHI1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKULLANICI1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTUR1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_tur_cikti = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DataTable9 = New System.Data.DataTable()
        Me.DataColumn119 = New System.Data.DataColumn()
        Me.DataColumn120 = New System.Data.DataColumn()
        Me.colRECETENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTUTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPOZISYONNO2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_pozisyon_cikti = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colFIREORANI1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIREMIKTARI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKALANMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIREYANSIMAORANI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRETUTARI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEPONO2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sDepo_cikti = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.MIKTAR2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEKMALIYET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEKMALIYETTOPLAM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEKMALIYETSTOKNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEKMALIYETSTOKKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEKMALIYETMALINCINSI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEKMALIYETKDV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_arac = New System.Windows.Forms.ContextMenu()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.ds_arac = New System.Data.DataSet()
        Me.DataTable7 = New System.Data.DataTable()
        Me.DataColumn107 = New System.Data.DataColumn()
        Me.DataColumn108 = New System.Data.DataColumn()
        Me.DataColumn109 = New System.Data.DataColumn()
        Me.DataColumn110 = New System.Data.DataColumn()
        Me.DataColumn111 = New System.Data.DataColumn()
        Me.DataColumn112 = New System.Data.DataColumn()
        Me.DataColumn113 = New System.Data.DataColumn()
        Me.DataColumn114 = New System.Data.DataColumn()
        Me.DataColumn115 = New System.Data.DataColumn()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIND3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSIRANO1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEVRAKNO3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colARACNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colARACKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCALISMAUSULU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_calismausulu_arac = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DataTable10 = New System.Data.DataTable()
        Me.DataColumn124 = New System.Data.DataColumn()
        Me.DataColumn125 = New System.Data.DataColumn()
        Me.colPOZISYONNO3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_pozisyon_arac = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colMIKTAR2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBIRIMMIKTAR2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl5 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_ek = New System.Windows.Forms.ContextMenu()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.MenuItem36 = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.MenuItem38 = New System.Windows.Forms.MenuItem()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_depo_ek = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCiktiEkTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lbl_CiktiMalinCinsi = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_CiktiStokKodu = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_CiktiIND = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem11 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem32 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem19 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem25 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem29 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem30 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem31 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem10 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem27 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem28 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem6 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem5 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem20 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem21 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem22 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem8 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem9 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem18 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem7 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem23 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem24 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem26 = New DevExpress.XtraBars.BarButtonItem()
        Me.ds_girdi_tur = New System.Data.DataSet()
        Me.ds_depolar = New System.Data.DataSet()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ds_cikti_tur = New System.Data.DataSet()
        Me.ds_calismausulu = New System.Data.DataSet()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.panel_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_baslik.SuspendLayout()
        CType(Me.VGrid_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_resim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_pozisyon_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel_toplam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_toplam.SuspendLayout()
        CType(Me.VGrid_maliyet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_maliyet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VGrid_aciklama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_aciklama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VGrid_geneltoplam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_toplam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel_info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_info.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_hareket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_miktar_girdi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_birim_girdi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_fiyat_girdi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_girdi_turu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo_girdi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_pozisyon_girdi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_DovizCinsi_girdi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_pozisyon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo_pozisyon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_fiyat_pozisyon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_miktar_pozisyon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_cikti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_miktar_cikti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_fiyat_cikti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_tur_cikti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_pozisyon_cikti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sDepo_cikti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_arac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_calismausulu_arac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_pozisyon_arac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo_ek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_girdi_tur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_depolar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_cikti_tur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_calismausulu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_baslik
        '
        Me.panel_baslik.Controls.Add(Me.VGrid_baslik)
        Me.panel_baslik.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_baslik.Location = New System.Drawing.Point(0, 22)
        Me.panel_baslik.Name = "panel_baslik"
        Me.panel_baslik.Size = New System.Drawing.Size(824, 138)
        Me.panel_baslik.TabIndex = 0
        '
        'VGrid_baslik
        '
        Me.VGrid_baslik.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VGrid_baslik.Appearance.Empty.Options.UseBackColor = True
        Me.VGrid_baslik.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.VGrid_baslik.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.VGrid_baslik.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VGrid_baslik.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.VGrid_baslik.CustomizationFormBounds = New System.Drawing.Rectangle(557, 258, 208, 252)
        Me.VGrid_baslik.DataMember = Nothing
        Me.VGrid_baslik.DataSource = Me.ds_baslik
        Me.VGrid_baslik.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGrid_baslik.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.BandsView
        Me.VGrid_baslik.Location = New System.Drawing.Point(2, 2)
        Me.VGrid_baslik.Name = "VGrid_baslik"
        Me.VGrid_baslik.OptionsBehavior.UseTabKey = False
        Me.VGrid_baslik.RecordWidth = 200
        Me.VGrid_baslik.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_resim, Me.sec_pozisyon_baslik})
        Me.VGrid_baslik.RowHeaderWidth = 137
        Me.VGrid_baslik.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowSTOKNO, Me.rowKULLANICI, Me.rowSONERISIMTARIHI, Me.rowACIKLAMA, Me.rowSTOKTIPI, Me.rowURETIMGIRISHESAPKODU, Me.rowKOD1, Me.rowKOD2, Me.rowKOD3, Me.rowKOD4, Me.rowKOD5, Me.rowKOD6, Me.rowKOD7, Me.rowKOD8, Me.rowKOD9, Me.rowKOD10, Me.rowDURUM, Me.CategoryRow3, Me.CategoryRow1, Me.CategoryRow2})
        Me.VGrid_baslik.Size = New System.Drawing.Size(820, 134)
        Me.VGrid_baslik.TabIndex = 0
        Me.VGrid_baslik.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView
        '
        'ds_baslik
        '
        Me.ds_baslik.DataSetName = "NewDataSet"
        Me.ds_baslik.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_baslik.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn126, Me.DataColumn127, Me.DataColumn128, Me.DataColumn129, Me.DataColumn130, Me.DataColumn131, Me.DataColumn132, Me.DataColumn137, Me.DataColumn138})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "IND"
        Me.DataColumn21.DataType = GetType(Long)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "STOKNO"
        Me.DataColumn22.DataType = GetType(Long)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "KULLANICI"
        Me.DataColumn23.DataType = GetType(Long)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "SONERISIMTARIHI"
        Me.DataColumn24.DataType = GetType(Date)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "TUTAR"
        Me.DataColumn25.DataType = GetType(Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "STOKKODU"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "MALINCINSI"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "BIRIM"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "FIYAT"
        Me.DataColumn29.DataType = GetType(Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "KDV"
        Me.DataColumn30.DataType = GetType(Long)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "OZELKOD"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "ACIKLAMA"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "STOKTIPI"
        Me.DataColumn33.DataType = GetType(Long)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "MIKTAR"
        Me.DataColumn34.DataType = GetType(Decimal)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "SATISFIYATI"
        Me.DataColumn35.DataType = GetType(Decimal)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "URETIMGIRISHESAPKODU"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "STANDARTSURE"
        Me.DataColumn37.DataType = GetType(Long)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "RESIM"
        Me.DataColumn38.DataType = GetType(Byte())
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "KOD1"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "KOD2"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "KOD3"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "KOD4"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "KOD5"
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "KOD6"
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "KOD7"
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "KOD8"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "KOD9"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "KOD10"
        '
        'DataColumn126
        '
        Me.DataColumn126.ColumnName = "DURUM"
        Me.DataColumn126.DataType = GetType(Long)
        '
        'DataColumn127
        '
        Me.DataColumn127.ColumnName = "TARIH"
        Me.DataColumn127.DataType = GetType(Date)
        '
        'DataColumn128
        '
        Me.DataColumn128.ColumnName = "FISNO"
        '
        'DataColumn129
        '
        Me.DataColumn129.ColumnName = "POZNO"
        Me.DataColumn129.DataType = GetType(Long)
        '
        'DataColumn130
        '
        Me.DataColumn130.ColumnName = "TERMIN"
        Me.DataColumn130.DataType = GetType(Date)
        '
        'DataColumn131
        '
        Me.DataColumn131.ColumnName = "URETIMEBASLAMATARIHI"
        Me.DataColumn131.DataType = GetType(Date)
        '
        'DataColumn132
        '
        Me.DataColumn132.ColumnName = "URETIMBITISTARIHI"
        Me.DataColumn132.DataType = GetType(Date)
        '
        'DataColumn137
        '
        Me.DataColumn137.ColumnName = "RECETENO"
        Me.DataColumn137.DataType = GetType(Long)
        '
        'DataColumn138
        '
        Me.DataColumn138.ColumnName = "ENTEGRE"
        Me.DataColumn138.DataType = GetType(Long)
        '
        'sec_resim
        '
        Me.sec_resim.Name = "sec_resim"
        Me.sec_resim.NullText = "[Yüklü Resim Bulunamadý...]"
        Me.sec_resim.ReadOnly = True
        Me.sec_resim.ShowMenu = False
        Me.sec_resim.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        '
        'sec_pozisyon_baslik
        '
        Me.sec_pozisyon_baslik.AutoHeight = False
        Me.sec_pozisyon_baslik.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_pozisyon_baslik.DisplayMember = "ACIKLAMA"
        Me.sec_pozisyon_baslik.Name = "sec_pozisyon_baslik"
        Me.sec_pozisyon_baslik.NullText = "[Baþlamamýþ]"
        Me.sec_pozisyon_baslik.ValueMember = "IND"
        '
        'rowSTOKNO
        '
        Me.rowSTOKNO.Name = "rowSTOKNO"
        Me.rowSTOKNO.Properties.Caption = "Stok No"
        Me.rowSTOKNO.Properties.FieldName = "STOKNO"
        Me.rowSTOKNO.Visible = False
        '
        'rowKULLANICI
        '
        Me.rowKULLANICI.Name = "rowKULLANICI"
        Me.rowKULLANICI.Properties.Caption = "Kaydeden"
        Me.rowKULLANICI.Properties.FieldName = "KULLANICI"
        Me.rowKULLANICI.Visible = False
        '
        'rowSONERISIMTARIHI
        '
        Me.rowSONERISIMTARIHI.Name = "rowSONERISIMTARIHI"
        Me.rowSONERISIMTARIHI.Properties.Caption = "SonEriþimTarihi"
        Me.rowSONERISIMTARIHI.Properties.FieldName = "SONERISIMTARIHI"
        Me.rowSONERISIMTARIHI.Visible = False
        '
        'rowACIKLAMA
        '
        Me.rowACIKLAMA.Name = "rowACIKLAMA"
        Me.rowACIKLAMA.Properties.Caption = "Açýklama"
        Me.rowACIKLAMA.Properties.FieldName = "ACIKLAMA"
        Me.rowACIKLAMA.Visible = False
        '
        'rowSTOKTIPI
        '
        Me.rowSTOKTIPI.Name = "rowSTOKTIPI"
        Me.rowSTOKTIPI.Properties.Caption = "Stok Tipi"
        Me.rowSTOKTIPI.Properties.FieldName = "STOKTIPI"
        Me.rowSTOKTIPI.Properties.ReadOnly = True
        Me.rowSTOKTIPI.Visible = False
        '
        'rowURETIMGIRISHESAPKODU
        '
        Me.rowURETIMGIRISHESAPKODU.Name = "rowURETIMGIRISHESAPKODU"
        Me.rowURETIMGIRISHESAPKODU.Properties.Caption = "ÜretimGiriþHesapKodu"
        Me.rowURETIMGIRISHESAPKODU.Properties.FieldName = "URETIMGIRISHESAPKODU"
        Me.rowURETIMGIRISHESAPKODU.Visible = False
        '
        'rowKOD1
        '
        Me.rowKOD1.Name = "rowKOD1"
        Me.rowKOD1.Properties.Caption = "Stok 1.ÖzelKod"
        Me.rowKOD1.Properties.FieldName = "KOD1"
        Me.rowKOD1.Properties.ReadOnly = True
        Me.rowKOD1.Visible = False
        '
        'rowKOD2
        '
        Me.rowKOD2.Name = "rowKOD2"
        Me.rowKOD2.Properties.Caption = "Stok 2.ÖzelKod"
        Me.rowKOD2.Properties.FieldName = "KOD2"
        Me.rowKOD2.Properties.ReadOnly = True
        Me.rowKOD2.Visible = False
        '
        'rowKOD3
        '
        Me.rowKOD3.Name = "rowKOD3"
        Me.rowKOD3.Properties.Caption = "Stok 3.ÖzelKod"
        Me.rowKOD3.Properties.FieldName = "KOD3"
        Me.rowKOD3.Properties.ReadOnly = True
        Me.rowKOD3.Visible = False
        '
        'rowKOD4
        '
        Me.rowKOD4.Name = "rowKOD4"
        Me.rowKOD4.Properties.Caption = "Stok 4.ÖzelKod"
        Me.rowKOD4.Properties.FieldName = "KOD4"
        Me.rowKOD4.Properties.ReadOnly = True
        Me.rowKOD4.Visible = False
        '
        'rowKOD5
        '
        Me.rowKOD5.Name = "rowKOD5"
        Me.rowKOD5.Properties.Caption = "Stok 5.ÖzelKod"
        Me.rowKOD5.Properties.FieldName = "KOD5"
        Me.rowKOD5.Properties.ReadOnly = True
        Me.rowKOD5.Visible = False
        '
        'rowKOD6
        '
        Me.rowKOD6.Name = "rowKOD6"
        Me.rowKOD6.Properties.Caption = "Stok 6.ÖzelKod"
        Me.rowKOD6.Properties.FieldName = "KOD6"
        Me.rowKOD6.Properties.ReadOnly = True
        Me.rowKOD6.Visible = False
        '
        'rowKOD7
        '
        Me.rowKOD7.Name = "rowKOD7"
        Me.rowKOD7.Properties.Caption = "Stok 7.ÖzelKod"
        Me.rowKOD7.Properties.FieldName = "KOD7"
        Me.rowKOD7.Properties.ReadOnly = True
        Me.rowKOD7.Visible = False
        '
        'rowKOD8
        '
        Me.rowKOD8.Name = "rowKOD8"
        Me.rowKOD8.Properties.Caption = "Stok 8.ÖzelKod"
        Me.rowKOD8.Properties.FieldName = "KOD8"
        Me.rowKOD8.Properties.ReadOnly = True
        Me.rowKOD8.Visible = False
        '
        'rowKOD9
        '
        Me.rowKOD9.Name = "rowKOD9"
        Me.rowKOD9.Properties.Caption = "Stok 9.ÖzelKod"
        Me.rowKOD9.Properties.FieldName = "KOD9"
        Me.rowKOD9.Properties.ReadOnly = True
        Me.rowKOD9.Visible = False
        '
        'rowKOD10
        '
        Me.rowKOD10.Name = "rowKOD10"
        Me.rowKOD10.Properties.Caption = "Stok 10.ÖzelKod"
        Me.rowKOD10.Properties.FieldName = "KOD10"
        Me.rowKOD10.Properties.ReadOnly = True
        Me.rowKOD10.Visible = False
        '
        'rowDURUM
        '
        Me.rowDURUM.Name = "rowDURUM"
        Me.rowDURUM.Properties.Caption = "Durum"
        Me.rowDURUM.Properties.FieldName = "DURUM"
        Me.rowDURUM.Properties.ReadOnly = True
        Me.rowDURUM.Visible = False
        '
        'CategoryRow3
        '
        Me.CategoryRow3.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowMIKTAR, Me.rowPOZNO, Me.rowSTANDARTSURE, Me.rowIND, Me.rowOZELKOD})
        Me.CategoryRow3.Name = "CategoryRow3"
        Me.CategoryRow3.Properties.Caption = "Üretim"
        '
        'rowMIKTAR
        '
        Me.rowMIKTAR.Name = "rowMIKTAR"
        Me.rowMIKTAR.Properties.Caption = "Miktar"
        Me.rowMIKTAR.Properties.FieldName = "MIKTAR"
        Me.rowMIKTAR.Properties.Format.FormatString = "#,0.####"
        Me.rowMIKTAR.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowPOZNO
        '
        Me.rowPOZNO.Name = "rowPOZNO"
        Me.rowPOZNO.Properties.Caption = "Pozisyon"
        Me.rowPOZNO.Properties.FieldName = "POZNO"
        '
        'rowSTANDARTSURE
        '
        Me.rowSTANDARTSURE.Name = "rowSTANDARTSURE"
        Me.rowSTANDARTSURE.Properties.Caption = "StandartSüre"
        Me.rowSTANDARTSURE.Properties.FieldName = "STANDARTSURE"
        Me.rowSTANDARTSURE.Properties.Format.FormatString = "#,0.00"
        Me.rowSTANDARTSURE.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowIND
        '
        Me.rowIND.Name = "rowIND"
        Me.rowIND.Properties.Caption = "Kayýt No"
        Me.rowIND.Properties.FieldName = "IND"
        Me.rowIND.Properties.ReadOnly = True
        '
        'rowOZELKOD
        '
        Me.rowOZELKOD.Height = 16
        Me.rowOZELKOD.Name = "rowOZELKOD"
        Me.rowOZELKOD.Properties.Caption = "ÖzelKod"
        Me.rowOZELKOD.Properties.FieldName = "OZELKOD"
        '
        'CategoryRow1
        '
        Me.CategoryRow1.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowTARIH, Me.rowFISNO, Me.rowTERMIN, Me.rowURETIMEBASLAMATARIHI, Me.rowURETIMBITISTARIHI})
        Me.CategoryRow1.Name = "CategoryRow1"
        Me.CategoryRow1.Properties.Caption = "Üretim Emri"
        '
        'rowTARIH
        '
        Me.rowTARIH.Name = "rowTARIH"
        Me.rowTARIH.Properties.Caption = "Tarih"
        Me.rowTARIH.Properties.FieldName = "TARIH"
        '
        'rowFISNO
        '
        Me.rowFISNO.Name = "rowFISNO"
        Me.rowFISNO.Properties.Caption = "Belge No"
        Me.rowFISNO.Properties.FieldName = "FISNO"
        '
        'rowTERMIN
        '
        Me.rowTERMIN.Name = "rowTERMIN"
        Me.rowTERMIN.Properties.Caption = "Termin"
        Me.rowTERMIN.Properties.FieldName = "TERMIN"
        '
        'rowURETIMEBASLAMATARIHI
        '
        Me.rowURETIMEBASLAMATARIHI.Name = "rowURETIMEBASLAMATARIHI"
        Me.rowURETIMEBASLAMATARIHI.Properties.Caption = "ÜretimeBaþlamaTarihi"
        Me.rowURETIMEBASLAMATARIHI.Properties.FieldName = "URETIMEBASLAMATARIHI"
        '
        'rowURETIMBITISTARIHI
        '
        Me.rowURETIMBITISTARIHI.Name = "rowURETIMBITISTARIHI"
        Me.rowURETIMBITISTARIHI.Properties.Caption = "UretimiBitirmeTarihi"
        Me.rowURETIMBITISTARIHI.Properties.FieldName = "URETIMBITISTARIHI"
        '
        'CategoryRow2
        '
        Me.CategoryRow2.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowSTOKKODU, Me.rowMALINCINSI, Me.rowBIRIM, Me.rowFIYAT, Me.rowTUTAR, Me.rowKDV, Me.rowSATISFIYATI, Me.rowRESIM})
        Me.CategoryRow2.Name = "CategoryRow2"
        Me.CategoryRow2.Properties.Caption = "Stok Bilgileri"
        '
        'rowSTOKKODU
        '
        Me.rowSTOKKODU.Name = "rowSTOKKODU"
        Me.rowSTOKKODU.Properties.Caption = "Stok Kodu"
        Me.rowSTOKKODU.Properties.FieldName = "STOKKODU"
        Me.rowSTOKKODU.Properties.ReadOnly = True
        '
        'rowMALINCINSI
        '
        Me.rowMALINCINSI.Name = "rowMALINCINSI"
        Me.rowMALINCINSI.Properties.Caption = "Stok Adý"
        Me.rowMALINCINSI.Properties.FieldName = "MALINCINSI"
        Me.rowMALINCINSI.Properties.ReadOnly = True
        '
        'rowBIRIM
        '
        Me.rowBIRIM.Name = "rowBIRIM"
        Me.rowBIRIM.Properties.Caption = "Birim"
        Me.rowBIRIM.Properties.FieldName = "BIRIM"
        Me.rowBIRIM.Properties.ReadOnly = True
        '
        'rowFIYAT
        '
        Me.rowFIYAT.Name = "rowFIYAT"
        Me.rowFIYAT.Properties.Caption = "Fiyat"
        Me.rowFIYAT.Properties.FieldName = "FIYAT"
        Me.rowFIYAT.Properties.Format.FormatString = "#,0.00"
        Me.rowFIYAT.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rowFIYAT.Properties.ReadOnly = True
        '
        'rowTUTAR
        '
        Me.rowTUTAR.Name = "rowTUTAR"
        Me.rowTUTAR.Properties.Caption = "Tutar"
        Me.rowTUTAR.Properties.FieldName = "TUTAR"
        Me.rowTUTAR.Properties.Format.FormatString = "#,0.00"
        Me.rowTUTAR.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rowTUTAR.Properties.ReadOnly = True
        '
        'rowKDV
        '
        Me.rowKDV.Name = "rowKDV"
        Me.rowKDV.Properties.Caption = "Kdv"
        Me.rowKDV.Properties.FieldName = "KDV"
        Me.rowKDV.Properties.Format.FormatString = "#,0"
        Me.rowKDV.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowSATISFIYATI
        '
        Me.rowSATISFIYATI.Name = "rowSATISFIYATI"
        Me.rowSATISFIYATI.Properties.Caption = "SatýþFiyatý"
        Me.rowSATISFIYATI.Properties.FieldName = "SATISFIYATI"
        Me.rowSATISFIYATI.Properties.Format.FormatString = "#,0.00"
        Me.rowSATISFIYATI.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowRESIM
        '
        Me.rowRESIM.Name = "rowRESIM"
        Me.rowRESIM.Properties.Caption = "Resim"
        Me.rowRESIM.Properties.FieldName = "RESIM"
        Me.rowRESIM.Properties.ReadOnly = True
        Me.rowRESIM.Properties.RowEdit = Me.sec_resim
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterControl1.Location = New System.Drawing.Point(0, 160)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(824, 5)
        Me.SplitterControl1.TabIndex = 1
        Me.SplitterControl1.TabStop = False
        '
        'panel_toplam
        '
        Me.panel_toplam.Controls.Add(Me.VGrid_maliyet)
        Me.panel_toplam.Controls.Add(Me.VGrid_aciklama)
        Me.panel_toplam.Controls.Add(Me.VGrid_geneltoplam)
        Me.panel_toplam.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_toplam.Location = New System.Drawing.Point(0, 414)
        Me.panel_toplam.Name = "panel_toplam"
        Me.panel_toplam.Size = New System.Drawing.Size(824, 103)
        Me.panel_toplam.TabIndex = 2
        '
        'VGrid_maliyet
        '
        Me.VGrid_maliyet.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.VGrid_maliyet.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.VGrid_maliyet.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VGrid_maliyet.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.VGrid_maliyet.CustomizationFormBounds = New System.Drawing.Rectangle(806, 402, 208, 252)
        Me.VGrid_maliyet.DataMember = "Table1"
        Me.VGrid_maliyet.DataSource = Me.ds_maliyet
        Me.VGrid_maliyet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGrid_maliyet.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
        Me.VGrid_maliyet.Location = New System.Drawing.Point(216, 2)
        Me.VGrid_maliyet.Name = "VGrid_maliyet"
        Me.VGrid_maliyet.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowMASRAF, Me.rowHAMMADDE, Me.rowFIRE, Me.rowTOPLAM})
        Me.VGrid_maliyet.Size = New System.Drawing.Size(414, 99)
        Me.VGrid_maliyet.TabIndex = 2
        '
        'ds_maliyet
        '
        Me.ds_maliyet.DataSetName = "NewDataSet"
        Me.ds_maliyet.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_maliyet.Tables.AddRange(New System.Data.DataTable() {Me.DataTable5})
        '
        'DataTable5
        '
        Me.DataTable5.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn96, Me.DataColumn97, Me.DataColumn98, Me.DataColumn99, Me.DataColumn100, Me.DataColumn121, Me.DataColumn122, Me.DataColumn123})
        Me.DataTable5.TableName = "Table1"
        '
        'DataColumn96
        '
        Me.DataColumn96.ColumnName = "MASRAF"
        Me.DataColumn96.DataType = GetType(Decimal)
        '
        'DataColumn97
        '
        Me.DataColumn97.ColumnName = "MASRAFORANI"
        Me.DataColumn97.DataType = GetType(Long)
        '
        'DataColumn98
        '
        Me.DataColumn98.ColumnName = "HAMMADDE"
        Me.DataColumn98.DataType = GetType(Decimal)
        '
        'DataColumn99
        '
        Me.DataColumn99.ColumnName = "HAMMADDEORANI"
        Me.DataColumn99.DataType = GetType(Long)
        '
        'DataColumn100
        '
        Me.DataColumn100.ColumnName = "TOPLAM"
        Me.DataColumn100.DataType = GetType(Decimal)
        '
        'DataColumn121
        '
        Me.DataColumn121.ColumnName = "FIRE"
        Me.DataColumn121.DataType = GetType(Decimal)
        '
        'DataColumn122
        '
        Me.DataColumn122.ColumnName = "FIREORANI"
        Me.DataColumn122.DataType = GetType(Decimal)
        '
        'DataColumn123
        '
        Me.DataColumn123.ColumnName = "FIREMIKTARI"
        Me.DataColumn123.DataType = GetType(Decimal)
        '
        'rowMASRAF
        '
        Me.rowMASRAF.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowMASRAFORANI})
        Me.rowMASRAF.Expanded = False
        Me.rowMASRAF.Name = "rowMASRAF"
        Me.rowMASRAF.Properties.Caption = "ToplamMasraf"
        Me.rowMASRAF.Properties.FieldName = "MASRAF"
        Me.rowMASRAF.Properties.Format.FormatString = "#,0.00##"
        Me.rowMASRAF.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowMASRAFORANI
        '
        Me.rowMASRAFORANI.Height = 16
        Me.rowMASRAFORANI.Name = "rowMASRAFORANI"
        Me.rowMASRAFORANI.Properties.Caption = "MasrafOraný%"
        Me.rowMASRAFORANI.Properties.FieldName = "MASRAFORANI"
        Me.rowMASRAFORANI.Properties.Format.FormatString = "#,0.00"
        Me.rowMASRAFORANI.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowHAMMADDE
        '
        Me.rowHAMMADDE.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowHAMMADDEORANI})
        Me.rowHAMMADDE.Expanded = False
        Me.rowHAMMADDE.Height = 16
        Me.rowHAMMADDE.Name = "rowHAMMADDE"
        Me.rowHAMMADDE.Properties.Caption = "ToplamHammadde"
        Me.rowHAMMADDE.Properties.FieldName = "HAMMADDE"
        Me.rowHAMMADDE.Properties.Format.FormatString = "#,0.00##"
        Me.rowHAMMADDE.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowHAMMADDEORANI
        '
        Me.rowHAMMADDEORANI.Name = "rowHAMMADDEORANI"
        Me.rowHAMMADDEORANI.Properties.Caption = "HammaddeOraný%"
        Me.rowHAMMADDEORANI.Properties.FieldName = "HAMMADDEORANI"
        Me.rowHAMMADDEORANI.Properties.Format.FormatString = "#,0.00"
        Me.rowHAMMADDEORANI.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowFIRE
        '
        Me.rowFIRE.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowFIREMIKTARI, Me.rowFIREORANI})
        Me.rowFIRE.Expanded = False
        Me.rowFIRE.Name = "rowFIRE"
        Me.rowFIRE.Properties.Caption = "ToplamFire"
        Me.rowFIRE.Properties.FieldName = "FIRE"
        Me.rowFIRE.Properties.Format.FormatString = "#,0.00##"
        Me.rowFIRE.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowFIREMIKTARI
        '
        Me.rowFIREMIKTARI.Name = "rowFIREMIKTARI"
        Me.rowFIREMIKTARI.Properties.Caption = "FireMiktarý"
        Me.rowFIREMIKTARI.Properties.FieldName = "FIREMIKTARI"
        Me.rowFIREMIKTARI.Properties.Format.FormatString = "#,0.00##"
        Me.rowFIREMIKTARI.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowFIREORANI
        '
        Me.rowFIREORANI.Name = "rowFIREORANI"
        Me.rowFIREORANI.Properties.Caption = "FireOraný%"
        Me.rowFIREORANI.Properties.FieldName = "FIREORANI"
        Me.rowFIREORANI.Properties.Format.FormatString = "#,0.00##"
        Me.rowFIREORANI.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowTOPLAM
        '
        Me.rowTOPLAM.Name = "rowTOPLAM"
        Me.rowTOPLAM.Properties.Caption = "Toplam"
        Me.rowTOPLAM.Properties.FieldName = "TOPLAM"
        Me.rowTOPLAM.Properties.Format.FormatString = "#,0.00##"
        Me.rowTOPLAM.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'VGrid_aciklama
        '
        Me.VGrid_aciklama.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.VGrid_aciklama.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.VGrid_aciklama.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VGrid_aciklama.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.VGrid_aciklama.DataMember = "Table1"
        Me.VGrid_aciklama.DataSource = Me.ds_baslik
        Me.VGrid_aciklama.Dock = System.Windows.Forms.DockStyle.Left
        Me.VGrid_aciklama.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.VGrid_aciklama.Location = New System.Drawing.Point(2, 2)
        Me.VGrid_aciklama.Name = "VGrid_aciklama"
        Me.VGrid_aciklama.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_aciklama})
        Me.VGrid_aciklama.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.EditorRow30})
        Me.VGrid_aciklama.Size = New System.Drawing.Size(214, 99)
        Me.VGrid_aciklama.TabIndex = 1
        '
        'sec_aciklama
        '
        Me.sec_aciklama.LinesCount = 6
        Me.sec_aciklama.Name = "sec_aciklama"
        '
        'EditorRow30
        '
        Me.EditorRow30.Height = 90
        Me.EditorRow30.Name = "EditorRow30"
        Me.EditorRow30.Properties.Caption = "Açýklama"
        Me.EditorRow30.Properties.FieldName = "ACIKLAMA"
        Me.EditorRow30.Properties.RowEdit = Me.sec_aciklama
        '
        'VGrid_geneltoplam
        '
        Me.VGrid_geneltoplam.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.VGrid_geneltoplam.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.VGrid_geneltoplam.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VGrid_geneltoplam.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.VGrid_geneltoplam.CustomizationFormBounds = New System.Drawing.Rectangle(383, 279, 208, 252)
        Me.VGrid_geneltoplam.DataMember = "Table1"
        Me.VGrid_geneltoplam.DataSource = Me.ds_toplam
        Me.VGrid_geneltoplam.Dock = System.Windows.Forms.DockStyle.Right
        Me.VGrid_geneltoplam.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
        Me.VGrid_geneltoplam.Location = New System.Drawing.Point(630, 2)
        Me.VGrid_geneltoplam.Name = "VGrid_geneltoplam"
        Me.VGrid_geneltoplam.OptionsBehavior.Editable = False
        Me.VGrid_geneltoplam.OptionsBehavior.ResizeHeaderPanel = False
        Me.VGrid_geneltoplam.OptionsBehavior.ResizeRowHeaders = False
        Me.VGrid_geneltoplam.OptionsBehavior.ResizeRowValues = False
        Me.VGrid_geneltoplam.OptionsBehavior.UseTabKey = False
        Me.VGrid_geneltoplam.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowBIRIMMALIYET, Me.rowKARORANI, Me.EditorRow2, Me.EditorRow3, Me.rowGENELTOPLAM})
        Me.VGrid_geneltoplam.Size = New System.Drawing.Size(192, 99)
        Me.VGrid_geneltoplam.TabIndex = 0
        Me.VGrid_geneltoplam.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView
        '
        'ds_toplam
        '
        Me.ds_toplam.DataSetName = "NewDataSet"
        Me.ds_toplam.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_toplam.Tables.AddRange(New System.Data.DataTable() {Me.DataTable6})
        '
        'DataTable6
        '
        Me.DataTable6.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn101, Me.DataColumn102, Me.DataColumn103, Me.DataColumn104, Me.DataColumn105, Me.DataColumn106})
        Me.DataTable6.TableName = "Table1"
        '
        'DataColumn101
        '
        Me.DataColumn101.ColumnName = "BIRIMMALIYET"
        Me.DataColumn101.DataType = GetType(Decimal)
        '
        'DataColumn102
        '
        Me.DataColumn102.ColumnName = "KARORANI"
        Me.DataColumn102.DataType = GetType(Decimal)
        '
        'DataColumn103
        '
        Me.DataColumn103.ColumnName = "KAR"
        Me.DataColumn103.DataType = GetType(Decimal)
        '
        'DataColumn104
        '
        Me.DataColumn104.ColumnName = "TOPLAM"
        Me.DataColumn104.DataType = GetType(Decimal)
        '
        'DataColumn105
        '
        Me.DataColumn105.ColumnName = "KDV"
        Me.DataColumn105.DataType = GetType(Decimal)
        '
        'DataColumn106
        '
        Me.DataColumn106.ColumnName = "GENELTOPLAM"
        Me.DataColumn106.DataType = GetType(Decimal)
        '
        'rowBIRIMMALIYET
        '
        Me.rowBIRIMMALIYET.Name = "rowBIRIMMALIYET"
        Me.rowBIRIMMALIYET.Properties.Caption = "BirimMaliyet"
        Me.rowBIRIMMALIYET.Properties.FieldName = "BIRIMMALIYET"
        Me.rowBIRIMMALIYET.Properties.Format.FormatString = "#,0.00##"
        Me.rowBIRIMMALIYET.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowKARORANI
        '
        Me.rowKARORANI.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowKAR})
        Me.rowKARORANI.Expanded = False
        Me.rowKARORANI.Name = "rowKARORANI"
        Me.rowKARORANI.Properties.Caption = "KarOraný%"
        Me.rowKARORANI.Properties.FieldName = "KARORANI"
        Me.rowKARORANI.Properties.Format.FormatString = "#,0.00"
        Me.rowKARORANI.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowKAR
        '
        Me.rowKAR.Name = "rowKAR"
        Me.rowKAR.Properties.Caption = "Kar"
        Me.rowKAR.Properties.FieldName = "KAR"
        Me.rowKAR.Properties.Format.FormatString = "#,0.00##"
        Me.rowKAR.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'EditorRow2
        '
        Me.EditorRow2.Name = "EditorRow2"
        Me.EditorRow2.Properties.Caption = "Toplam"
        Me.EditorRow2.Properties.FieldName = "TOPLAM"
        Me.EditorRow2.Properties.Format.FormatString = "#,0.00##"
        Me.EditorRow2.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'EditorRow3
        '
        Me.EditorRow3.Name = "EditorRow3"
        Me.EditorRow3.Properties.Caption = "Kdv"
        Me.EditorRow3.Properties.FieldName = "KDV"
        Me.EditorRow3.Properties.Format.FormatString = "#,0.00##"
        Me.EditorRow3.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowGENELTOPLAM
        '
        Me.rowGENELTOPLAM.Name = "rowGENELTOPLAM"
        Me.rowGENELTOPLAM.Properties.Caption = "GenelToplam"
        Me.rowGENELTOPLAM.Properties.FieldName = "GENELTOPLAM"
        Me.rowGENELTOPLAM.Properties.Format.FormatString = "#,0.00##"
        Me.rowGENELTOPLAM.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'panel_info
        '
        Me.panel_info.Controls.Add(Me.Label1)
        Me.panel_info.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_info.Location = New System.Drawing.Point(0, 388)
        Me.panel_info.Name = "panel_info"
        Me.panel_info.Size = New System.Drawing.Size(824, 26)
        Me.panel_info.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Satýr : % / %"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl4.Location = New System.Drawing.Point(0, 165)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(824, 223)
        Me.PanelControl4.TabIndex = 4
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 219)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(814, 191)
        Me.XtraTabPage1.Text = "Üretim Girdileri"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.kisayol_girdi
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.ds_hareket
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_girdi_turu, Me.sec_depo_girdi, Me.sec_birim_girdi, Me.sec_fiyat_girdi, Me.sec_miktar_girdi, Me.sec_pozisyon_girdi, Me.sec_DovizCinsi_girdi})
        Me.GridControl1.Size = New System.Drawing.Size(814, 191)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'kisayol_girdi
        '
        Me.kisayol_girdi.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem14, Me.MenuItem20, Me.MenuItem5, Me.MenuItem29, Me.MenuItem28, Me.MenuItem30, Me.MenuItem31, Me.MenuItem16, Me.MenuItem11, Me.MenuItem15, Me.MenuItem17, Me.MenuItem19})
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 0
        Me.MenuItem14.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem14.Text = "Ekle"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 1
        Me.MenuItem20.Shortcut = System.Windows.Forms.Shortcut.CtrlIns
        Me.MenuItem20.Text = "Masraf Ekle"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 2
        Me.MenuItem5.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem5.Text = "Sil"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 3
        Me.MenuItem29.Text = "-"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 4
        Me.MenuItem28.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem28.Text = "Stok Hareketleri"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 5
        Me.MenuItem30.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem30.Text = "Envanter"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 6
        Me.MenuItem31.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItem31.Text = "Fiyatlandir"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 7
        Me.MenuItem16.Text = "-"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 8
        Me.MenuItem11.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem11.Text = "Deðer Yay"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 9
        Me.MenuItem15.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 10
        Me.MenuItem17.Text = "Görünümü Düzenle"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 11
        Me.MenuItem19.Text = "Görünümü Yazdýr"
        '
        'ds_hareket
        '
        Me.ds_hareket.DataSetName = "NewDataSet"
        Me.ds_hareket.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_hareket.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn67, Me.DataColumn68, Me.DataColumn69, Me.DataColumn70, Me.DataColumn118, Me.DataColumn139, Me.DataColumn140, Me.DataColumn141})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "IND"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "STOKNO"
        Me.DataColumn2.DataType = GetType(Long)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "DETAY"
        Me.DataColumn3.DataType = GetType(Long)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "EVRAKNO"
        Me.DataColumn4.DataType = GetType(Long)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "STOKKODU"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "MALINCINSI"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "MIKTAR"
        Me.DataColumn7.DataType = GetType(Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "BIRIM"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "BARCODE"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "BIRIMMIKTAR"
        Me.DataColumn10.DataType = GetType(Decimal)
        Me.DataColumn10.DefaultValue = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "KDV"
        Me.DataColumn11.DataType = GetType(Long)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "FIYAT"
        Me.DataColumn12.DataType = GetType(Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "ISLEMTARIHI"
        Me.DataColumn13.DataType = GetType(Date)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "SONERISIMTARIHI"
        Me.DataColumn14.DataType = GetType(Date)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "KULLANICI"
        Me.DataColumn15.DataType = GetType(Long)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "ORAN"
        Me.DataColumn16.DataType = GetType(Long)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "TUR"
        Me.DataColumn17.DataType = GetType(Long)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "DEPONO"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "ACIKLAMA"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "MALIYETTURU"
        Me.DataColumn20.DataType = GetType(Long)
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "MIKTARTURU"
        Me.DataColumn64.DataType = GetType(Long)
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "URETIMCIKISHESAPKODU"
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "YANSITMAHESAPKODU"
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "POZISYONNO"
        Me.DataColumn67.DataType = GetType(Long)
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "CIKISPOZISYONNO"
        Me.DataColumn68.DataType = GetType(Long)
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "FIREORANI"
        Me.DataColumn69.DataType = GetType(Decimal)
        '
        'DataColumn70
        '
        Me.DataColumn70.ColumnName = "ARACLINENO"
        Me.DataColumn70.DataType = GetType(Long)
        '
        'DataColumn118
        '
        Me.DataColumn118.ColumnName = "TUTAR"
        Me.DataColumn118.DataType = GetType(Decimal)
        '
        'DataColumn139
        '
        Me.DataColumn139.ColumnName = "sDovizCinsi1"
        '
        'DataColumn140
        '
        Me.DataColumn140.ColumnName = "lDovizKuru1"
        Me.DataColumn140.DataType = GetType(Decimal)
        '
        'DataColumn141
        '
        Me.DataColumn141.ColumnName = "lDovizMiktari1"
        Me.DataColumn141.DataType = GetType(Decimal)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND1, Me.colSTOKNO, Me.colDETAY, Me.colEVRAKNO1, Me.colSTOKKODU, Me.colMALINCINSI, Me.colMIKTAR, Me.colBIRIM, Me.colBARCODE, Me.colBIRIMMIKTAR, Me.colKDV, Me.colFIYAT, Me.colISLEMTARIHI, Me.colSONERISIMTARIHI, Me.colKULLANICI, Me.colORAN, Me.colTUR, Me.colDEPONO1, Me.colACIKLAMA1, Me.colMALIYETTURU, Me.colMIKTARTURU, Me.colURETIMCIKISHESAPKODU, Me.colYANSITMAHESAPKODU, Me.colPOZISYONNO1, Me.colCIKISPOZISYONNO, Me.colFIREORANI, Me.colARACLINENO, Me.colHTUTAR, Me.colsDovizCinsi1, Me.collDovizKuru1, Me.collDovizMiktari1})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(496, 228, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
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
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsMenu.EnableFooterMenu = False
        Me.GridView1.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colIND1
        '
        Me.colIND1.Caption = "Kayýt No"
        Me.colIND1.FieldName = "IND"
        Me.colIND1.Name = "colIND1"
        Me.colIND1.OptionsColumn.AllowEdit = False
        '
        'colSTOKNO
        '
        Me.colSTOKNO.Caption = "Stok No"
        Me.colSTOKNO.FieldName = "STOKNO"
        Me.colSTOKNO.Name = "colSTOKNO"
        Me.colSTOKNO.OptionsColumn.AllowEdit = False
        '
        'colDETAY
        '
        Me.colDETAY.Caption = "Detay"
        Me.colDETAY.FieldName = "DETAY"
        Me.colDETAY.Name = "colDETAY"
        Me.colDETAY.OptionsColumn.AllowEdit = False
        '
        'colEVRAKNO1
        '
        Me.colEVRAKNO1.Caption = "Evrak No"
        Me.colEVRAKNO1.FieldName = "EVRAKNO"
        Me.colEVRAKNO1.Name = "colEVRAKNO1"
        Me.colEVRAKNO1.OptionsColumn.AllowEdit = False
        '
        'colSTOKKODU
        '
        Me.colSTOKKODU.Caption = "Stok Kodu"
        Me.colSTOKKODU.FieldName = "STOKKODU"
        Me.colSTOKKODU.Name = "colSTOKKODU"
        Me.colSTOKKODU.OptionsColumn.AllowEdit = False
        Me.colSTOKKODU.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "STOKKODU", "{0} Kayýt")})
        Me.colSTOKKODU.Visible = True
        Me.colSTOKKODU.VisibleIndex = 1
        Me.colSTOKKODU.Width = 66
        '
        'colMALINCINSI
        '
        Me.colMALINCINSI.Caption = "Stok Adý"
        Me.colMALINCINSI.FieldName = "MALINCINSI"
        Me.colMALINCINSI.Name = "colMALINCINSI"
        Me.colMALINCINSI.OptionsColumn.AllowEdit = False
        Me.colMALINCINSI.Visible = True
        Me.colMALINCINSI.VisibleIndex = 2
        Me.colMALINCINSI.Width = 66
        '
        'colMIKTAR
        '
        Me.colMIKTAR.Caption = "Miktar"
        Me.colMIKTAR.ColumnEdit = Me.sec_miktar_girdi
        Me.colMIKTAR.DisplayFormat.FormatString = "#,0.#####"
        Me.colMIKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMIKTAR.FieldName = "MIKTAR"
        Me.colMIKTAR.Name = "colMIKTAR"
        Me.colMIKTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", "{0:#,0.00##}")})
        Me.colMIKTAR.Visible = True
        Me.colMIKTAR.VisibleIndex = 3
        Me.colMIKTAR.Width = 66
        '
        'sec_miktar_girdi
        '
        Me.sec_miktar_girdi.AutoHeight = False
        Me.sec_miktar_girdi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_miktar_girdi.DisplayFormat.FormatString = "#,0.####"
        Me.sec_miktar_girdi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_miktar_girdi.EditFormat.FormatString = "#,0.####"
        Me.sec_miktar_girdi.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_miktar_girdi.Name = "sec_miktar_girdi"
        '
        'colBIRIM
        '
        Me.colBIRIM.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colBIRIM.AppearanceCell.Options.UseBackColor = True
        Me.colBIRIM.Caption = "Birim"
        Me.colBIRIM.ColumnEdit = Me.sec_birim_girdi
        Me.colBIRIM.FieldName = "BIRIM"
        Me.colBIRIM.Name = "colBIRIM"
        Me.colBIRIM.OptionsColumn.AllowEdit = False
        Me.colBIRIM.Visible = True
        Me.colBIRIM.VisibleIndex = 4
        Me.colBIRIM.Width = 66
        '
        'sec_birim_girdi
        '
        Me.sec_birim_girdi.AutoHeight = False
        Me.sec_birim_girdi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_birim_girdi.Name = "sec_birim_girdi"
        Me.sec_birim_girdi.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colBARCODE
        '
        Me.colBARCODE.Caption = "Barcode"
        Me.colBARCODE.FieldName = "BARCODE"
        Me.colBARCODE.Name = "colBARCODE"
        '
        'colBIRIMMIKTAR
        '
        Me.colBIRIMMIKTAR.Caption = "Birim Miktar"
        Me.colBIRIMMIKTAR.DisplayFormat.FormatString = "#,0.#####"
        Me.colBIRIMMIKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBIRIMMIKTAR.FieldName = "BIRIMMIKTAR"
        Me.colBIRIMMIKTAR.Name = "colBIRIMMIKTAR"
        Me.colBIRIMMIKTAR.OptionsColumn.AllowEdit = False
        '
        'colKDV
        '
        Me.colKDV.Caption = "Kdv"
        Me.colKDV.DisplayFormat.FormatString = "#,0.#####"
        Me.colKDV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKDV.FieldName = "KDV"
        Me.colKDV.Name = "colKDV"
        Me.colKDV.Visible = True
        Me.colKDV.VisibleIndex = 5
        Me.colKDV.Width = 66
        '
        'colFIYAT
        '
        Me.colFIYAT.Caption = "Fiyat"
        Me.colFIYAT.ColumnEdit = Me.sec_fiyat_girdi
        Me.colFIYAT.DisplayFormat.FormatString = "#,0.00##"
        Me.colFIYAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT.FieldName = "0"
        Me.colFIYAT.Name = "colFIYAT"
        Me.colFIYAT.Visible = True
        Me.colFIYAT.VisibleIndex = 6
        Me.colFIYAT.Width = 57
        '
        'sec_fiyat_girdi
        '
        Me.sec_fiyat_girdi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_fiyat_girdi.DisplayFormat.FormatString = "#,0.00##"
        Me.sec_fiyat_girdi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_fiyat_girdi.EditFormat.FormatString = "#,0.00##"
        Me.sec_fiyat_girdi.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_fiyat_girdi.Name = "sec_fiyat_girdi"
        '
        'colISLEMTARIHI
        '
        Me.colISLEMTARIHI.Caption = "Ýþlem Tarihi"
        Me.colISLEMTARIHI.FieldName = "ISLEMTARIHI"
        Me.colISLEMTARIHI.Name = "colISLEMTARIHI"
        Me.colISLEMTARIHI.OptionsColumn.AllowEdit = False
        '
        'colSONERISIMTARIHI
        '
        Me.colSONERISIMTARIHI.Caption = "SonEriþimTarihi"
        Me.colSONERISIMTARIHI.FieldName = "SONERISIMTARIHI"
        Me.colSONERISIMTARIHI.Name = "colSONERISIMTARIHI"
        Me.colSONERISIMTARIHI.OptionsColumn.AllowEdit = False
        '
        'colKULLANICI
        '
        Me.colKULLANICI.Caption = "Kaydeden"
        Me.colKULLANICI.FieldName = "KULLANICI"
        Me.colKULLANICI.Name = "colKULLANICI"
        Me.colKULLANICI.OptionsColumn.AllowEdit = False
        '
        'colORAN
        '
        Me.colORAN.Caption = "Oran"
        Me.colORAN.DisplayFormat.FormatString = "#,#.##"
        Me.colORAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN.FieldName = "ORAN"
        Me.colORAN.Name = "colORAN"
        Me.colORAN.OptionsColumn.AllowEdit = False
        Me.colORAN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ORAN", "{0:#,0.00##}")})
        Me.colORAN.Visible = True
        Me.colORAN.VisibleIndex = 10
        Me.colORAN.Width = 67
        '
        'colTUR
        '
        Me.colTUR.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colTUR.AppearanceCell.Options.UseBackColor = True
        Me.colTUR.Caption = "Tür"
        Me.colTUR.ColumnEdit = Me.sec_girdi_turu
        Me.colTUR.FieldName = "TUR"
        Me.colTUR.Name = "colTUR"
        Me.colTUR.OptionsColumn.AllowEdit = False
        Me.colTUR.Visible = True
        Me.colTUR.VisibleIndex = 0
        Me.colTUR.Width = 43
        '
        'sec_girdi_turu
        '
        Me.sec_girdi_turu.AutoHeight = False
        Me.sec_girdi_turu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_girdi_turu.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "Açýklama")})
        Me.sec_girdi_turu.DataSource = Me.DataTable8
        Me.sec_girdi_turu.DisplayMember = "ACIKLAMA"
        Me.sec_girdi_turu.Name = "sec_girdi_turu"
        Me.sec_girdi_turu.NullText = "[Türler]"
        Me.sec_girdi_turu.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_girdi_turu.ShowFooter = False
        Me.sec_girdi_turu.ShowHeader = False
        Me.sec_girdi_turu.ShowLines = False
        Me.sec_girdi_turu.ValueMember = "IND"
        '
        'DataTable8
        '
        Me.DataTable8.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn116, Me.DataColumn117})
        Me.DataTable8.TableName = "Table1"
        '
        'DataColumn116
        '
        Me.DataColumn116.ColumnName = "IND"
        Me.DataColumn116.DataType = GetType(Long)
        '
        'DataColumn117
        '
        Me.DataColumn117.ColumnName = "ACIKLAMA"
        '
        'colDEPONO1
        '
        Me.colDEPONO1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colDEPONO1.AppearanceCell.Options.UseBackColor = True
        Me.colDEPONO1.Caption = "Depo"
        Me.colDEPONO1.ColumnEdit = Me.sec_depo_girdi
        Me.colDEPONO1.FieldName = "DEPONO"
        Me.colDEPONO1.Name = "colDEPONO1"
        Me.colDEPONO1.Visible = True
        Me.colDEPONO1.VisibleIndex = 11
        Me.colDEPONO1.Width = 76
        '
        'sec_depo_girdi
        '
        Me.sec_depo_girdi.AutoHeight = False
        Me.sec_depo_girdi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo_girdi.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sDepo", "Depo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sAciklama", "Aciklama")})
        Me.sec_depo_girdi.DisplayMember = "sDepo"
        Me.sec_depo_girdi.Name = "sec_depo_girdi"
        Me.sec_depo_girdi.NullText = "[Depo]"
        Me.sec_depo_girdi.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_depo_girdi.ShowFooter = False
        Me.sec_depo_girdi.ShowHeader = False
        Me.sec_depo_girdi.ValueMember = "sDepo"
        '
        'colACIKLAMA1
        '
        Me.colACIKLAMA1.Caption = "Açýklama"
        Me.colACIKLAMA1.FieldName = "ACIKLAMA"
        Me.colACIKLAMA1.Name = "colACIKLAMA1"
        '
        'colMALIYETTURU
        '
        Me.colMALIYETTURU.Caption = "MaliyetTürü"
        Me.colMALIYETTURU.FieldName = "MALIYETTURU"
        Me.colMALIYETTURU.Name = "colMALIYETTURU"
        Me.colMALIYETTURU.OptionsColumn.AllowEdit = False
        '
        'colMIKTARTURU
        '
        Me.colMIKTARTURU.Caption = "MiktarTürü"
        Me.colMIKTARTURU.FieldName = "MIKTARTURU"
        Me.colMIKTARTURU.Name = "colMIKTARTURU"
        Me.colMIKTARTURU.OptionsColumn.AllowEdit = False
        '
        'colURETIMCIKISHESAPKODU
        '
        Me.colURETIMCIKISHESAPKODU.Caption = "ÇýkýþHesapKodu"
        Me.colURETIMCIKISHESAPKODU.FieldName = "URETIMCIKISHESAPKODU"
        Me.colURETIMCIKISHESAPKODU.Name = "colURETIMCIKISHESAPKODU"
        '
        'colYANSITMAHESAPKODU
        '
        Me.colYANSITMAHESAPKODU.Caption = "YansýtmaHesapKodu"
        Me.colYANSITMAHESAPKODU.FieldName = "YANSITMAHESAPKODU"
        Me.colYANSITMAHESAPKODU.Name = "colYANSITMAHESAPKODU"
        '
        'colPOZISYONNO1
        '
        Me.colPOZISYONNO1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colPOZISYONNO1.AppearanceCell.Options.UseBackColor = True
        Me.colPOZISYONNO1.Caption = "Pozisyon"
        Me.colPOZISYONNO1.ColumnEdit = Me.sec_pozisyon_girdi
        Me.colPOZISYONNO1.FieldName = "POZISYONNO"
        Me.colPOZISYONNO1.Name = "colPOZISYONNO1"
        Me.colPOZISYONNO1.Visible = True
        Me.colPOZISYONNO1.VisibleIndex = 7
        Me.colPOZISYONNO1.Width = 62
        '
        'sec_pozisyon_girdi
        '
        Me.sec_pozisyon_girdi.AutoHeight = False
        Me.sec_pozisyon_girdi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_pozisyon_girdi.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KOD", "Kod")})
        Me.sec_pozisyon_girdi.DisplayMember = "KOD"
        Me.sec_pozisyon_girdi.Name = "sec_pozisyon_girdi"
        Me.sec_pozisyon_girdi.NullText = "[Pozisyon]"
        Me.sec_pozisyon_girdi.ShowFooter = False
        Me.sec_pozisyon_girdi.ShowHeader = False
        Me.sec_pozisyon_girdi.ShowLines = False
        Me.sec_pozisyon_girdi.ValueMember = "IND"
        '
        'colCIKISPOZISYONNO
        '
        Me.colCIKISPOZISYONNO.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colCIKISPOZISYONNO.AppearanceCell.Options.UseBackColor = True
        Me.colCIKISPOZISYONNO.Caption = "ÇýkýþPozisyonu"
        Me.colCIKISPOZISYONNO.ColumnEdit = Me.sec_pozisyon_girdi
        Me.colCIKISPOZISYONNO.FieldName = "CIKISPOZISYONNO"
        Me.colCIKISPOZISYONNO.Name = "colCIKISPOZISYONNO"
        Me.colCIKISPOZISYONNO.Visible = True
        Me.colCIKISPOZISYONNO.VisibleIndex = 8
        Me.colCIKISPOZISYONNO.Width = 73
        '
        'colFIREORANI
        '
        Me.colFIREORANI.Caption = "FireMiktarý"
        Me.colFIREORANI.DisplayFormat.FormatString = "#,0.#####"
        Me.colFIREORANI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIREORANI.FieldName = "FIREORANI"
        Me.colFIREORANI.Name = "colFIREORANI"
        Me.colFIREORANI.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FIREORANI", "{0:#,0.####}")})
        Me.colFIREORANI.Visible = True
        Me.colFIREORANI.VisibleIndex = 9
        Me.colFIREORANI.Width = 67
        '
        'colARACLINENO
        '
        Me.colARACLINENO.Caption = "AraçNo"
        Me.colARACLINENO.FieldName = "ARACLINENO"
        Me.colARACLINENO.Name = "colARACLINENO"
        Me.colARACLINENO.OptionsColumn.AllowEdit = False
        '
        'colHTUTAR
        '
        Me.colHTUTAR.Caption = "Tutar"
        Me.colHTUTAR.ColumnEdit = Me.sec_fiyat_girdi
        Me.colHTUTAR.DisplayFormat.FormatString = "#,0.00"
        Me.colHTUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colHTUTAR.FieldName = "TUTAR"
        Me.colHTUTAR.GroupFormat.FormatString = "#,0.00"
        Me.colHTUTAR.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colHTUTAR.Name = "colHTUTAR"
        Me.colHTUTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", "{0:#,0.00##}")})
        Me.colHTUTAR.Width = 73
        '
        'colsDovizCinsi1
        '
        Me.colsDovizCinsi1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colsDovizCinsi1.AppearanceCell.Options.UseBackColor = True
        Me.colsDovizCinsi1.Caption = "DovizCinsi"
        Me.colsDovizCinsi1.ColumnEdit = Me.sec_DovizCinsi_girdi
        Me.colsDovizCinsi1.FieldName = "sDovizCinsi1"
        Me.colsDovizCinsi1.Name = "colsDovizCinsi1"
        '
        'sec_DovizCinsi_girdi
        '
        Me.sec_DovizCinsi_girdi.AutoHeight = False
        Me.sec_DovizCinsi_girdi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_DovizCinsi_girdi.DisplayMember = "sDovizCinsi"
        Me.sec_DovizCinsi_girdi.Name = "sec_DovizCinsi_girdi"
        Me.sec_DovizCinsi_girdi.NullText = "[Doviz]"
        Me.sec_DovizCinsi_girdi.ValueMember = "sDovizCinsi"
        '
        'collDovizKuru1
        '
        Me.collDovizKuru1.Caption = "DovizKuru"
        Me.collDovizKuru1.DisplayFormat.FormatString = "#,0.00##"
        Me.collDovizKuru1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizKuru1.FieldName = "lDovizKuru1"
        Me.collDovizKuru1.Name = "collDovizKuru1"
        '
        'collDovizMiktari1
        '
        Me.collDovizMiktari1.Caption = "DovizMiktari"
        Me.collDovizMiktari1.DisplayFormat.FormatString = "#,0.00##"
        Me.collDovizMiktari1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizMiktari1.FieldName = "lDovizMiktari1"
        Me.collDovizMiktari1.Name = "collDovizMiktari1"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridControl2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(814, 191)
        Me.XtraTabPage2.Text = "Pozisyonlar"
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenu = Me.kisayol_pozisyon
        Me.GridControl2.DataMember = "Table1"
        Me.GridControl2.DataSource = Me.ds_pozisyon
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView3
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_depo_pozisyon, Me.sec_fiyat_pozisyon, Me.sec_miktar_pozisyon})
        Me.GridControl2.Size = New System.Drawing.Size(814, 191)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3, Me.GridView2})
        '
        'kisayol_pozisyon
        '
        Me.kisayol_pozisyon.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem7, Me.MenuItem8, Me.MenuItem13, Me.MenuItem9, Me.MenuItem10, Me.MenuItem12})
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 0
        Me.MenuItem7.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem7.Text = "Ekle"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 1
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem8.Text = "Sil"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 2
        Me.MenuItem13.Text = "Üretim Yeri Belirle"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 3
        Me.MenuItem9.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 4
        Me.MenuItem10.Text = "Görünümü Düzenle"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 5
        Me.MenuItem12.Text = "Görünümü Yazdýr"
        '
        'ds_pozisyon
        '
        Me.ds_pozisyon.DataSetName = "NewDataSet"
        Me.ds_pozisyon.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_pozisyon.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn133, Me.DataColumn134, Me.DataColumn135, Me.DataColumn136})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "IND"
        Me.DataColumn49.DataType = GetType(Long)
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "SIRANO"
        Me.DataColumn50.DataType = GetType(Long)
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "KOD"
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "ACIKLAMA"
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "EVRAKNO"
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "POZISYONNO"
        Me.DataColumn54.DataType = GetType(Long)
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "URETIMYERINO"
        Me.DataColumn55.DataType = GetType(Long)
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "URETIMYERIKODU"
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "DEPONO"
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "DEPOKODU"
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "MALIYET"
        Me.DataColumn59.DataType = GetType(Decimal)
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "TOPLAMMALIYET"
        Me.DataColumn60.DataType = GetType(Decimal)
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "STANDARTSURE"
        Me.DataColumn61.DataType = GetType(Decimal)
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "STANDARTBIRIMSURE"
        Me.DataColumn62.DataType = GetType(Decimal)
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "SUREHASAPLAMATURU"
        Me.DataColumn63.DataType = GetType(Long)
        '
        'DataColumn133
        '
        Me.DataColumn133.ColumnName = "GIRISTARIHI"
        Me.DataColumn133.DataType = GetType(Date)
        '
        'DataColumn134
        '
        Me.DataColumn134.ColumnName = "CIKISTARIHI"
        Me.DataColumn134.DataType = GetType(Date)
        '
        'DataColumn135
        '
        Me.DataColumn135.ColumnName = "GIRISMIKTARI"
        Me.DataColumn135.DataType = GetType(Decimal)
        '
        'DataColumn136
        '
        Me.DataColumn136.ColumnName = "CIKISMIKTARI"
        Me.DataColumn136.DataType = GetType(Decimal)
        '
        'GridView3
        '
        Me.GridView3.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.Empty.Options.UseBackColor = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.colSIRANO, Me.colKOD, Me.colACIKLAMA, Me.colEVRAKNO, Me.colPOZISYONNO, Me.colURETIMYERINO, Me.colURETIMYERIKODU, Me.colDEPONO, Me.colDEPOKODU, Me.colMALIYET, Me.colTOPLAMMALIYET, Me.colSTANDARTSURE, Me.colSTANDARTBIRIMSURE, Me.colSUREHASAPLAMATURU})
        Me.GridView3.CustomizationFormBounds = New System.Drawing.Rectangle(267, 235, 208, 170)
        Me.GridView3.DetailHeight = 160
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.GridControl = Me.GridControl2
        Me.GridView3.GroupFormat = "{0}: {1} {2}"
        Me.GridView3.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView3.IndicatorWidth = 35
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsCustomization.AllowSort = False
        Me.GridView3.OptionsDetail.ShowDetailTabs = False
        Me.GridView3.OptionsMenu.EnableColumnMenu = False
        Me.GridView3.OptionsMenu.EnableFooterMenu = False
        Me.GridView3.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colIND
        '
        Me.colIND.Caption = "Kayýt No"
        Me.colIND.FieldName = "IND"
        Me.colIND.Name = "colIND"
        Me.colIND.OptionsColumn.AllowEdit = False
        '
        'colSIRANO
        '
        Me.colSIRANO.Caption = "SýraNo"
        Me.colSIRANO.FieldName = "SIRANO"
        Me.colSIRANO.Name = "colSIRANO"
        Me.colSIRANO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SIRANO", "{0 : Kayýt }")})
        Me.colSIRANO.Visible = True
        Me.colSIRANO.VisibleIndex = 0
        '
        'colKOD
        '
        Me.colKOD.Caption = "Kod"
        Me.colKOD.FieldName = "KOD"
        Me.colKOD.Name = "colKOD"
        Me.colKOD.OptionsColumn.AllowEdit = False
        Me.colKOD.Visible = True
        Me.colKOD.VisibleIndex = 1
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.Caption = "Açýklama"
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 2
        '
        'colEVRAKNO
        '
        Me.colEVRAKNO.Caption = "Evrak No"
        Me.colEVRAKNO.FieldName = "EVRAKNO"
        Me.colEVRAKNO.Name = "colEVRAKNO"
        Me.colEVRAKNO.OptionsColumn.AllowEdit = False
        '
        'colPOZISYONNO
        '
        Me.colPOZISYONNO.Caption = "PozisyonNo"
        Me.colPOZISYONNO.FieldName = "POZISYONNO"
        Me.colPOZISYONNO.Name = "colPOZISYONNO"
        '
        'colURETIMYERINO
        '
        Me.colURETIMYERINO.Caption = "ÜretimYeriNo"
        Me.colURETIMYERINO.FieldName = "URETIMYERINO"
        Me.colURETIMYERINO.Name = "colURETIMYERINO"
        Me.colURETIMYERINO.OptionsColumn.AllowEdit = False
        '
        'colURETIMYERIKODU
        '
        Me.colURETIMYERIKODU.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colURETIMYERIKODU.AppearanceCell.Options.UseBackColor = True
        Me.colURETIMYERIKODU.Caption = "ÜretimYeriKodu"
        Me.colURETIMYERIKODU.FieldName = "URETIMYERIKODU"
        Me.colURETIMYERIKODU.Name = "colURETIMYERIKODU"
        Me.colURETIMYERIKODU.OptionsColumn.AllowEdit = False
        Me.colURETIMYERIKODU.Visible = True
        Me.colURETIMYERIKODU.VisibleIndex = 3
        '
        'colDEPONO
        '
        Me.colDEPONO.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colDEPONO.AppearanceCell.Options.UseBackColor = True
        Me.colDEPONO.Caption = "DepoNo"
        Me.colDEPONO.ColumnEdit = Me.sec_depo_pozisyon
        Me.colDEPONO.FieldName = "DEPONO"
        Me.colDEPONO.Name = "colDEPONO"
        Me.colDEPONO.OptionsColumn.AllowEdit = False
        Me.colDEPONO.Visible = True
        Me.colDEPONO.VisibleIndex = 4
        '
        'sec_depo_pozisyon
        '
        Me.sec_depo_pozisyon.AutoHeight = False
        Me.sec_depo_pozisyon.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo_pozisyon.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sDepo", "Depo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sAciklama", "Aciklama")})
        Me.sec_depo_pozisyon.DisplayMember = "sDepo"
        Me.sec_depo_pozisyon.Name = "sec_depo_pozisyon"
        Me.sec_depo_pozisyon.NullText = "[Depo]"
        Me.sec_depo_pozisyon.ShowFooter = False
        Me.sec_depo_pozisyon.ShowHeader = False
        Me.sec_depo_pozisyon.ShowLines = False
        Me.sec_depo_pozisyon.ValueMember = "sDepo"
        '
        'colDEPOKODU
        '
        Me.colDEPOKODU.Caption = "DepoKodu"
        Me.colDEPOKODU.FieldName = "DEPOKODU"
        Me.colDEPOKODU.Name = "colDEPOKODU"
        '
        'colMALIYET
        '
        Me.colMALIYET.Caption = "Maliyet"
        Me.colMALIYET.ColumnEdit = Me.sec_fiyat_pozisyon
        Me.colMALIYET.DisplayFormat.FormatString = "#,0.00###"
        Me.colMALIYET.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMALIYET.FieldName = "MALIYET"
        Me.colMALIYET.Name = "colMALIYET"
        Me.colMALIYET.OptionsColumn.AllowEdit = False
        '
        'sec_fiyat_pozisyon
        '
        Me.sec_fiyat_pozisyon.AutoHeight = False
        Me.sec_fiyat_pozisyon.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_fiyat_pozisyon.DisplayFormat.FormatString = "#,0.00##"
        Me.sec_fiyat_pozisyon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_fiyat_pozisyon.EditFormat.FormatString = "#,0.00##"
        Me.sec_fiyat_pozisyon.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_fiyat_pozisyon.Name = "sec_fiyat_pozisyon"
        Me.sec_fiyat_pozisyon.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        '
        'colTOPLAMMALIYET
        '
        Me.colTOPLAMMALIYET.Caption = "ToplamMaliyet"
        Me.colTOPLAMMALIYET.ColumnEdit = Me.sec_fiyat_pozisyon
        Me.colTOPLAMMALIYET.DisplayFormat.FormatString = "#,0.00###"
        Me.colTOPLAMMALIYET.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTOPLAMMALIYET.FieldName = "TOPLAMMALIYET"
        Me.colTOPLAMMALIYET.Name = "colTOPLAMMALIYET"
        Me.colTOPLAMMALIYET.OptionsColumn.AllowEdit = False
        Me.colTOPLAMMALIYET.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOPLAMMALIYET", "{0:#,0.00##}")})
        Me.colTOPLAMMALIYET.Visible = True
        Me.colTOPLAMMALIYET.VisibleIndex = 5
        '
        'colSTANDARTSURE
        '
        Me.colSTANDARTSURE.Caption = "StandartSüre"
        Me.colSTANDARTSURE.ColumnEdit = Me.sec_miktar_pozisyon
        Me.colSTANDARTSURE.DisplayFormat.FormatString = "#,0.00###"
        Me.colSTANDARTSURE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSTANDARTSURE.FieldName = "STANDARTSURE"
        Me.colSTANDARTSURE.Name = "colSTANDARTSURE"
        Me.colSTANDARTSURE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "STANDARTSURE", "{0:#,0.00##}")})
        Me.colSTANDARTSURE.Visible = True
        Me.colSTANDARTSURE.VisibleIndex = 6
        '
        'sec_miktar_pozisyon
        '
        Me.sec_miktar_pozisyon.AutoHeight = False
        Me.sec_miktar_pozisyon.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_miktar_pozisyon.DisplayFormat.FormatString = "#,0.####"
        Me.sec_miktar_pozisyon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_miktar_pozisyon.EditFormat.FormatString = "#,0.####"
        Me.sec_miktar_pozisyon.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_miktar_pozisyon.Name = "sec_miktar_pozisyon"
        '
        'colSTANDARTBIRIMSURE
        '
        Me.colSTANDARTBIRIMSURE.Caption = "StandartBirimSüre"
        Me.colSTANDARTBIRIMSURE.ColumnEdit = Me.sec_miktar_pozisyon
        Me.colSTANDARTBIRIMSURE.DisplayFormat.FormatString = "#,0.00###"
        Me.colSTANDARTBIRIMSURE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSTANDARTBIRIMSURE.FieldName = "STANDARTBIRIMSURE"
        Me.colSTANDARTBIRIMSURE.Name = "colSTANDARTBIRIMSURE"
        Me.colSTANDARTBIRIMSURE.Visible = True
        Me.colSTANDARTBIRIMSURE.VisibleIndex = 7
        '
        'colSUREHASAPLAMATURU
        '
        Me.colSUREHASAPLAMATURU.Caption = "SüreHesaplamaTürü"
        Me.colSUREHASAPLAMATURU.ColumnEdit = Me.sec_miktar_pozisyon
        Me.colSUREHASAPLAMATURU.FieldName = "SUREHASAPLAMATURU"
        Me.colSUREHASAPLAMATURU.Name = "colSUREHASAPLAMATURU"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.GridControl3)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(814, 191)
        Me.XtraTabPage3.Text = "Üretim Çýktýlarý"
        '
        'GridControl3
        '
        Me.GridControl3.ContextMenu = Me.kisayol_cikti
        Me.GridControl3.DataMember = "Table1"
        Me.GridControl3.DataSource = Me.ds_cikti
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(0, 0)
        Me.GridControl3.MainView = Me.GridView5
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_pozisyon_cikti, Me.sec_fiyat_cikti, Me.sec_miktar_cikti, Me.sec_tur_cikti, Me.sec_sDepo_cikti})
        Me.GridControl3.Size = New System.Drawing.Size(814, 191)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5, Me.GridView4})
        '
        'kisayol_cikti
        '
        Me.kisayol_cikti.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem27, Me.MenuItem4, Me.MenuItem18, Me.MenuItem25, Me.MenuItem3, Me.MenuItem6})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem1.Text = "Ekle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem2.Text = "Sil"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 2
        Me.MenuItem27.Text = "Ek Maliyet Seç"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "-"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 4
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem18.Text = "Deðer Yay"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 5
        Me.MenuItem25.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 6
        Me.MenuItem3.Text = "Görünümü Düzenle"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 7
        Me.MenuItem6.Text = "Görünümü Yazdýr"
        '
        'ds_cikti
        '
        Me.ds_cikti.DataSetName = "NewDataSet"
        Me.ds_cikti.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_cikti.Tables.AddRange(New System.Data.DataTable() {Me.DataTable4})
        '
        'DataTable4
        '
        Me.DataTable4.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn71, Me.DataColumn72, Me.DataColumn73, Me.DataColumn74, Me.DataColumn75, Me.DataColumn76, Me.DataColumn77, Me.DataColumn78, Me.DataColumn79, Me.DataColumn80, Me.DataColumn81, Me.DataColumn82, Me.DataColumn83, Me.DataColumn84, Me.DataColumn85, Me.DataColumn86, Me.DataColumn87, Me.DataColumn88, Me.DataColumn89, Me.DataColumn90, Me.DataColumn91, Me.DataColumn92, Me.DataColumn93, Me.DataColumn94, Me.DataColumn95, Me.DataColumn142, Me.DataColumn143, Me.DataColumn144, Me.DataColumn145, Me.DataColumn146, Me.DataColumn147, Me.DataColumn148})
        Me.DataTable4.TableName = "Table1"
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "IND"
        Me.DataColumn71.DataType = GetType(Long)
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "DETAY"
        Me.DataColumn72.DataType = GetType(Long)
        '
        'DataColumn73
        '
        Me.DataColumn73.ColumnName = "EVRAKNO"
        Me.DataColumn73.DataType = GetType(Long)
        '
        'DataColumn74
        '
        Me.DataColumn74.ColumnName = "STOKNO"
        Me.DataColumn74.DataType = GetType(Long)
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "STOKKODU"
        '
        'DataColumn76
        '
        Me.DataColumn76.ColumnName = "MALINCINSI"
        '
        'DataColumn77
        '
        Me.DataColumn77.ColumnName = "MIKTAR"
        Me.DataColumn77.DataType = GetType(Decimal)
        '
        'DataColumn78
        '
        Me.DataColumn78.ColumnName = "BIRIM"
        '
        'DataColumn79
        '
        Me.DataColumn79.ColumnName = "BIRIMMIKTAR"
        Me.DataColumn79.DataType = GetType(Decimal)
        '
        'DataColumn80
        '
        Me.DataColumn80.ColumnName = "KDV"
        Me.DataColumn80.DataType = GetType(Long)
        '
        'DataColumn81
        '
        Me.DataColumn81.ColumnName = "FIYAT"
        Me.DataColumn81.DataType = GetType(Decimal)
        '
        'DataColumn82
        '
        Me.DataColumn82.ColumnName = "BARCODE"
        '
        'DataColumn83
        '
        Me.DataColumn83.ColumnName = "ISLEMTARIHI"
        Me.DataColumn83.DataType = GetType(Date)
        '
        'DataColumn84
        '
        Me.DataColumn84.ColumnName = "SONERISIMTARIHI"
        Me.DataColumn84.DataType = GetType(Date)
        '
        'DataColumn85
        '
        Me.DataColumn85.ColumnName = "KULLANICI"
        Me.DataColumn85.DataType = GetType(Long)
        '
        'DataColumn86
        '
        Me.DataColumn86.ColumnName = "ORAN"
        Me.DataColumn86.DataType = GetType(Decimal)
        '
        'DataColumn87
        '
        Me.DataColumn87.ColumnName = "TUR"
        Me.DataColumn87.DataType = GetType(Long)
        '
        'DataColumn88
        '
        Me.DataColumn88.ColumnName = "RECETENO"
        Me.DataColumn88.DataType = GetType(Long)
        '
        'DataColumn89
        '
        Me.DataColumn89.ColumnName = "TUTAR"
        Me.DataColumn89.DataType = GetType(Decimal)
        '
        'DataColumn90
        '
        Me.DataColumn90.ColumnName = "POZISYONNO"
        Me.DataColumn90.DataType = GetType(Long)
        '
        'DataColumn91
        '
        Me.DataColumn91.ColumnName = "FIREORANI"
        Me.DataColumn91.DataType = GetType(Decimal)
        '
        'DataColumn92
        '
        Me.DataColumn92.ColumnName = "FIREMIKTARI"
        Me.DataColumn92.DataType = GetType(Decimal)
        '
        'DataColumn93
        '
        Me.DataColumn93.ColumnName = "KALANMIKTAR"
        Me.DataColumn93.DataType = GetType(Decimal)
        '
        'DataColumn94
        '
        Me.DataColumn94.ColumnName = "FIREYANSIMAORANI"
        Me.DataColumn94.DataType = GetType(Decimal)
        '
        'DataColumn95
        '
        Me.DataColumn95.ColumnName = "FIRETUTARI"
        Me.DataColumn95.DataType = GetType(Decimal)
        '
        'DataColumn142
        '
        Me.DataColumn142.ColumnName = "MIKTAR2"
        Me.DataColumn142.DataType = GetType(Decimal)
        '
        'DataColumn143
        '
        Me.DataColumn143.ColumnName = "EKMALIYET"
        Me.DataColumn143.DataType = GetType(Decimal)
        '
        'DataColumn144
        '
        Me.DataColumn144.ColumnName = "EKMALIYETTOPLAM"
        Me.DataColumn144.DataType = GetType(Decimal)
        '
        'DataColumn145
        '
        Me.DataColumn145.ColumnName = "EKMALIYETSTOKNO"
        Me.DataColumn145.DataType = GetType(Long)
        '
        'DataColumn146
        '
        Me.DataColumn146.ColumnName = "EKMALIYETSTOKKODU"
        '
        'DataColumn147
        '
        Me.DataColumn147.ColumnName = "EKMALIYETMALINCINSI"
        '
        'DataColumn148
        '
        Me.DataColumn148.ColumnName = "EKMALIYETKDV"
        Me.DataColumn148.DataType = GetType(Decimal)
        '
        'GridView5
        '
        Me.GridView5.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView5.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView5.Appearance.Empty.Options.UseBackColor = True
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND2, Me.colDETAY1, Me.colEVRAKNO2, Me.colSTOKNO1, Me.colSTOKKODU1, Me.colMALINCINSI1, Me.colMIKTAR1, Me.colBIRIM1, Me.colBIRIMMIKTAR1, Me.colKDV1, Me.colFIYAT1, Me.colBARCODE1, Me.colISLEMTARIHI1, Me.colSONERISIMTARIHI1, Me.colKULLANICI1, Me.colORAN1, Me.colTUR1, Me.colRECETENO, Me.colTUTAR, Me.colPOZISYONNO2, Me.colFIREORANI1, Me.colFIREMIKTARI, Me.colKALANMIKTAR, Me.colFIREYANSIMAORANI, Me.colFIRETUTARI, Me.colDEPONO2, Me.MIKTAR2, Me.colEKMALIYET, Me.colEKMALIYETTOPLAM, Me.colEKMALIYETSTOKNO, Me.colEKMALIYETSTOKKODU, Me.colEKMALIYETMALINCINSI, Me.colEKMALIYETKDV})
        Me.GridView5.CustomizationFormBounds = New System.Drawing.Rectangle(643, 224, 208, 170)
        Me.GridView5.DetailHeight = 160
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.GridControl = Me.GridControl3
        Me.GridView5.GroupFormat = "{0}: {1} {2}"
        Me.GridView5.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView5.IndicatorWidth = 35
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView5.OptionsCustomization.AllowFilter = False
        Me.GridView5.OptionsCustomization.AllowGroup = False
        Me.GridView5.OptionsCustomization.AllowSort = False
        Me.GridView5.OptionsDetail.ShowDetailTabs = False
        Me.GridView5.OptionsMenu.EnableColumnMenu = False
        Me.GridView5.OptionsMenu.EnableFooterMenu = False
        Me.GridView5.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView5.OptionsSelection.MultiSelect = True
        Me.GridView5.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView5.OptionsView.EnableAppearanceOddRow = True
        Me.GridView5.OptionsView.ShowFooter = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'colIND2
        '
        Me.colIND2.Caption = "Kayýt No"
        Me.colIND2.FieldName = "IND"
        Me.colIND2.Name = "colIND2"
        Me.colIND2.OptionsColumn.AllowEdit = False
        '
        'colDETAY1
        '
        Me.colDETAY1.Caption = "Detay"
        Me.colDETAY1.FieldName = "DETAY"
        Me.colDETAY1.Name = "colDETAY1"
        Me.colDETAY1.OptionsColumn.AllowEdit = False
        '
        'colEVRAKNO2
        '
        Me.colEVRAKNO2.Caption = "Evrak No"
        Me.colEVRAKNO2.FieldName = "EVRAKNO"
        Me.colEVRAKNO2.Name = "colEVRAKNO2"
        Me.colEVRAKNO2.OptionsColumn.AllowEdit = False
        '
        'colSTOKNO1
        '
        Me.colSTOKNO1.Caption = "Stok No"
        Me.colSTOKNO1.FieldName = "STOKNO"
        Me.colSTOKNO1.Name = "colSTOKNO1"
        Me.colSTOKNO1.OptionsColumn.AllowEdit = False
        '
        'colSTOKKODU1
        '
        Me.colSTOKKODU1.Caption = "Stok Kodu"
        Me.colSTOKKODU1.FieldName = "STOKKODU"
        Me.colSTOKKODU1.Name = "colSTOKKODU1"
        Me.colSTOKKODU1.OptionsColumn.AllowEdit = False
        Me.colSTOKKODU1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "STOKKODU", "{0} Kayýt")})
        Me.colSTOKKODU1.Visible = True
        Me.colSTOKKODU1.VisibleIndex = 1
        '
        'colMALINCINSI1
        '
        Me.colMALINCINSI1.Caption = "Stok Adý"
        Me.colMALINCINSI1.FieldName = "MALINCINSI"
        Me.colMALINCINSI1.Name = "colMALINCINSI1"
        Me.colMALINCINSI1.OptionsColumn.AllowEdit = False
        Me.colMALINCINSI1.Visible = True
        Me.colMALINCINSI1.VisibleIndex = 2
        '
        'colMIKTAR1
        '
        Me.colMIKTAR1.Caption = "Miktar"
        Me.colMIKTAR1.ColumnEdit = Me.sec_miktar_cikti
        Me.colMIKTAR1.DisplayFormat.FormatString = "#,#.###"
        Me.colMIKTAR1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMIKTAR1.FieldName = "MIKTAR"
        Me.colMIKTAR1.Name = "colMIKTAR1"
        Me.colMIKTAR1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", "{0:#,0.####}")})
        Me.colMIKTAR1.Visible = True
        Me.colMIKTAR1.VisibleIndex = 3
        '
        'sec_miktar_cikti
        '
        Me.sec_miktar_cikti.AutoHeight = False
        Me.sec_miktar_cikti.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_miktar_cikti.DisplayFormat.FormatString = "#,0.####"
        Me.sec_miktar_cikti.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_miktar_cikti.EditFormat.FormatString = "#,0.####"
        Me.sec_miktar_cikti.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_miktar_cikti.Name = "sec_miktar_cikti"
        '
        'colBIRIM1
        '
        Me.colBIRIM1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colBIRIM1.AppearanceCell.Options.UseBackColor = True
        Me.colBIRIM1.Caption = "Birim"
        Me.colBIRIM1.FieldName = "BIRIM"
        Me.colBIRIM1.Name = "colBIRIM1"
        Me.colBIRIM1.OptionsColumn.AllowEdit = False
        Me.colBIRIM1.Visible = True
        Me.colBIRIM1.VisibleIndex = 4
        '
        'colBIRIMMIKTAR1
        '
        Me.colBIRIMMIKTAR1.Caption = "Birim Miktar"
        Me.colBIRIMMIKTAR1.ColumnEdit = Me.sec_miktar_cikti
        Me.colBIRIMMIKTAR1.DisplayFormat.FormatString = "#,0.00##"
        Me.colBIRIMMIKTAR1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBIRIMMIKTAR1.FieldName = "BIRIMMIKTAR"
        Me.colBIRIMMIKTAR1.Name = "colBIRIMMIKTAR1"
        '
        'colKDV1
        '
        Me.colKDV1.Caption = "Kdv"
        Me.colKDV1.DisplayFormat.FormatString = "#,0.00##"
        Me.colKDV1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKDV1.FieldName = "KDV"
        Me.colKDV1.Name = "colKDV1"
        '
        'colFIYAT1
        '
        Me.colFIYAT1.Caption = "Fiyat"
        Me.colFIYAT1.ColumnEdit = Me.sec_fiyat_cikti
        Me.colFIYAT1.DisplayFormat.FormatString = "#,0.00##"
        Me.colFIYAT1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT1.FieldName = "FIYAT"
        Me.colFIYAT1.Name = "colFIYAT1"
        Me.colFIYAT1.Visible = True
        Me.colFIYAT1.VisibleIndex = 5
        '
        'sec_fiyat_cikti
        '
        Me.sec_fiyat_cikti.AutoHeight = False
        Me.sec_fiyat_cikti.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_fiyat_cikti.DisplayFormat.FormatString = "#,0.00##"
        Me.sec_fiyat_cikti.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_fiyat_cikti.EditFormat.FormatString = "#,0.00##"
        Me.sec_fiyat_cikti.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sec_fiyat_cikti.Name = "sec_fiyat_cikti"
        '
        'colBARCODE1
        '
        Me.colBARCODE1.Caption = "Barcode"
        Me.colBARCODE1.FieldName = "BARCODE"
        Me.colBARCODE1.Name = "colBARCODE1"
        '
        'colISLEMTARIHI1
        '
        Me.colISLEMTARIHI1.Caption = "Ýþlem Tarihi"
        Me.colISLEMTARIHI1.FieldName = "ISLEMTARIHI"
        Me.colISLEMTARIHI1.Name = "colISLEMTARIHI1"
        Me.colISLEMTARIHI1.OptionsColumn.AllowEdit = False
        '
        'colSONERISIMTARIHI1
        '
        Me.colSONERISIMTARIHI1.Caption = "SonEriþimTarihi"
        Me.colSONERISIMTARIHI1.FieldName = "SONERISIMTARIHI"
        Me.colSONERISIMTARIHI1.Name = "colSONERISIMTARIHI1"
        Me.colSONERISIMTARIHI1.OptionsColumn.AllowEdit = False
        '
        'colKULLANICI1
        '
        Me.colKULLANICI1.Caption = "Kaydeden"
        Me.colKULLANICI1.FieldName = "KULLANICI"
        Me.colKULLANICI1.Name = "colKULLANICI1"
        Me.colKULLANICI1.OptionsColumn.AllowEdit = False
        '
        'colORAN1
        '
        Me.colORAN1.Caption = "Oran"
        Me.colORAN1.ColumnEdit = Me.sec_miktar_cikti
        Me.colORAN1.DisplayFormat.FormatString = "#,#.##"
        Me.colORAN1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN1.FieldName = "ORAN"
        Me.colORAN1.Name = "colORAN1"
        Me.colORAN1.OptionsColumn.AllowEdit = False
        Me.colORAN1.Visible = True
        Me.colORAN1.VisibleIndex = 7
        '
        'colTUR1
        '
        Me.colTUR1.Caption = "Tür"
        Me.colTUR1.ColumnEdit = Me.sec_tur_cikti
        Me.colTUR1.FieldName = "TUR"
        Me.colTUR1.Name = "colTUR1"
        Me.colTUR1.Visible = True
        Me.colTUR1.VisibleIndex = 0
        '
        'sec_tur_cikti
        '
        Me.sec_tur_cikti.AutoHeight = False
        Me.sec_tur_cikti.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_tur_cikti.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "Açýklama")})
        Me.sec_tur_cikti.DataSource = Me.DataTable9
        Me.sec_tur_cikti.DisplayMember = "ACIKLAMA"
        Me.sec_tur_cikti.Name = "sec_tur_cikti"
        Me.sec_tur_cikti.NullText = ""
        Me.sec_tur_cikti.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_tur_cikti.ShowFooter = False
        Me.sec_tur_cikti.ShowHeader = False
        Me.sec_tur_cikti.ShowLines = False
        Me.sec_tur_cikti.ValueMember = "IND"
        '
        'DataTable9
        '
        Me.DataTable9.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn119, Me.DataColumn120})
        Me.DataTable9.TableName = "Table1"
        '
        'DataColumn119
        '
        Me.DataColumn119.ColumnName = "IND"
        Me.DataColumn119.DataType = GetType(Long)
        '
        'DataColumn120
        '
        Me.DataColumn120.ColumnName = "ACIKLAMA"
        '
        'colRECETENO
        '
        Me.colRECETENO.Caption = "ReçeteNo"
        Me.colRECETENO.FieldName = "RECETENO"
        Me.colRECETENO.Name = "colRECETENO"
        Me.colRECETENO.OptionsColumn.AllowEdit = False
        '
        'colTUTAR
        '
        Me.colTUTAR.Caption = "Tutar"
        Me.colTUTAR.ColumnEdit = Me.sec_fiyat_cikti
        Me.colTUTAR.DisplayFormat.FormatString = "#,#.###"
        Me.colTUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTUTAR.FieldName = "TUTAR"
        Me.colTUTAR.Name = "colTUTAR"
        Me.colTUTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", "{0:#,0.00}")})
        Me.colTUTAR.Visible = True
        Me.colTUTAR.VisibleIndex = 6
        '
        'colPOZISYONNO2
        '
        Me.colPOZISYONNO2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colPOZISYONNO2.AppearanceCell.Options.UseBackColor = True
        Me.colPOZISYONNO2.Caption = "Pozisyon"
        Me.colPOZISYONNO2.ColumnEdit = Me.sec_pozisyon_cikti
        Me.colPOZISYONNO2.FieldName = "POZISYONNO"
        Me.colPOZISYONNO2.Name = "colPOZISYONNO2"
        Me.colPOZISYONNO2.Visible = True
        Me.colPOZISYONNO2.VisibleIndex = 8
        '
        'sec_pozisyon_cikti
        '
        Me.sec_pozisyon_cikti.AutoHeight = False
        Me.sec_pozisyon_cikti.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_pozisyon_cikti.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KOD", "Kodu")})
        Me.sec_pozisyon_cikti.DisplayMember = "KOD"
        Me.sec_pozisyon_cikti.Name = "sec_pozisyon_cikti"
        Me.sec_pozisyon_cikti.NullText = "[Pozisyon]"
        Me.sec_pozisyon_cikti.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_pozisyon_cikti.ShowFooter = False
        Me.sec_pozisyon_cikti.ShowHeader = False
        Me.sec_pozisyon_cikti.ShowLines = False
        Me.sec_pozisyon_cikti.ValueMember = "IND"
        '
        'colFIREORANI1
        '
        Me.colFIREORANI1.Caption = "FireOraný"
        Me.colFIREORANI1.DisplayFormat.FormatString = "#,0.00##"
        Me.colFIREORANI1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIREORANI1.FieldName = "FIREORANI"
        Me.colFIREORANI1.Name = "colFIREORANI1"
        Me.colFIREORANI1.OptionsColumn.AllowEdit = False
        '
        'colFIREMIKTARI
        '
        Me.colFIREMIKTARI.Caption = "FireMiktarý"
        Me.colFIREMIKTARI.ColumnEdit = Me.sec_miktar_cikti
        Me.colFIREMIKTARI.DisplayFormat.FormatString = "#,0.00##"
        Me.colFIREMIKTARI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIREMIKTARI.FieldName = "FIREMIKTARI"
        Me.colFIREMIKTARI.Name = "colFIREMIKTARI"
        Me.colFIREMIKTARI.OptionsColumn.AllowEdit = False
        '
        'colKALANMIKTAR
        '
        Me.colKALANMIKTAR.Caption = "KalanMiktar"
        Me.colKALANMIKTAR.ColumnEdit = Me.sec_miktar_cikti
        Me.colKALANMIKTAR.DisplayFormat.FormatString = "#,0.00##"
        Me.colKALANMIKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKALANMIKTAR.FieldName = "KALANMIKTAR"
        Me.colKALANMIKTAR.Name = "colKALANMIKTAR"
        Me.colKALANMIKTAR.OptionsColumn.AllowEdit = False
        '
        'colFIREYANSIMAORANI
        '
        Me.colFIREYANSIMAORANI.Caption = "FireYansýmaOraný"
        Me.colFIREYANSIMAORANI.DisplayFormat.FormatString = "#,0.00##"
        Me.colFIREYANSIMAORANI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIREYANSIMAORANI.FieldName = "FIREYANSIMAORANI"
        Me.colFIREYANSIMAORANI.Name = "colFIREYANSIMAORANI"
        Me.colFIREYANSIMAORANI.OptionsColumn.AllowEdit = False
        '
        'colFIRETUTARI
        '
        Me.colFIRETUTARI.Caption = "FireTutarý"
        Me.colFIRETUTARI.DisplayFormat.FormatString = "#,0.00##"
        Me.colFIRETUTARI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIRETUTARI.FieldName = "FIRETUTARI"
        Me.colFIRETUTARI.Name = "colFIRETUTARI"
        Me.colFIRETUTARI.OptionsColumn.AllowEdit = False
        '
        'colDEPONO2
        '
        Me.colDEPONO2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colDEPONO2.AppearanceCell.Options.UseBackColor = True
        Me.colDEPONO2.Caption = "Depo"
        Me.colDEPONO2.ColumnEdit = Me.sec_sDepo_cikti
        Me.colDEPONO2.FieldName = "DEPONO"
        Me.colDEPONO2.Name = "colDEPONO2"
        Me.colDEPONO2.Visible = True
        Me.colDEPONO2.VisibleIndex = 9
        '
        'sec_sDepo_cikti
        '
        Me.sec_sDepo_cikti.AutoHeight = False
        Me.sec_sDepo_cikti.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sDepo_cikti.DisplayMember = "sDepo"
        Me.sec_sDepo_cikti.Name = "sec_sDepo_cikti"
        Me.sec_sDepo_cikti.NullText = "[Depo]"
        Me.sec_sDepo_cikti.ValueMember = "sDepo"
        '
        'MIKTAR2
        '
        Me.MIKTAR2.Caption = "Miktar2"
        Me.MIKTAR2.DisplayFormat.FormatString = "#,#.###"
        Me.MIKTAR2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MIKTAR2.FieldName = "MIKTAR2"
        Me.MIKTAR2.Name = "MIKTAR2"
        Me.MIKTAR2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR2", "{0:#,0.00#}")})
        '
        'colEKMALIYET
        '
        Me.colEKMALIYET.Caption = "EkMaliyet"
        Me.colEKMALIYET.DisplayFormat.FormatString = "#,#.###"
        Me.colEKMALIYET.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEKMALIYET.FieldName = "EKMALIYET"
        Me.colEKMALIYET.Name = "colEKMALIYET"
        Me.colEKMALIYET.Visible = True
        Me.colEKMALIYET.VisibleIndex = 10
        '
        'colEKMALIYETTOPLAM
        '
        Me.colEKMALIYETTOPLAM.Caption = "EkMaliyetTutar"
        Me.colEKMALIYETTOPLAM.DisplayFormat.FormatString = "#,#.###"
        Me.colEKMALIYETTOPLAM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEKMALIYETTOPLAM.FieldName = "EKMALIYETTUTAR"
        Me.colEKMALIYETTOPLAM.Name = "colEKMALIYETTOPLAM"
        Me.colEKMALIYETTOPLAM.OptionsColumn.ReadOnly = True
        Me.colEKMALIYETTOPLAM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EKMALIYETTUTAR", "{0:#,0.00#}")})
        '
        'colEKMALIYETSTOKNO
        '
        Me.colEKMALIYETSTOKNO.Caption = "EkMaliyetStokNo"
        Me.colEKMALIYETSTOKNO.FieldName = "EKMALIYETSTOKNO"
        Me.colEKMALIYETSTOKNO.Name = "colEKMALIYETSTOKNO"
        Me.colEKMALIYETSTOKNO.OptionsColumn.ReadOnly = True
        '
        'colEKMALIYETSTOKKODU
        '
        Me.colEKMALIYETSTOKKODU.Caption = "EkMaliyetKod"
        Me.colEKMALIYETSTOKKODU.FieldName = "EKMALIYETSTOKKODU"
        Me.colEKMALIYETSTOKKODU.Name = "colEKMALIYETSTOKKODU"
        Me.colEKMALIYETSTOKKODU.OptionsColumn.ReadOnly = True
        '
        'colEKMALIYETMALINCINSI
        '
        Me.colEKMALIYETMALINCINSI.Caption = "EkMaliyetAciklama"
        Me.colEKMALIYETMALINCINSI.FieldName = "EKMALIYETMALINCINSI"
        Me.colEKMALIYETMALINCINSI.Name = "colEKMALIYETMALINCINSI"
        Me.colEKMALIYETMALINCINSI.OptionsColumn.ReadOnly = True
        '
        'colEKMALIYETKDV
        '
        Me.colEKMALIYETKDV.Caption = "EkMaliyetKdv"
        Me.colEKMALIYETKDV.FieldName = "EKMALIYETKDV"
        Me.colEKMALIYETKDV.Name = "colEKMALIYETKDV"
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.GridControl3
        Me.GridView4.Name = "GridView4"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.GridControl4)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(814, 191)
        Me.XtraTabPage4.Text = "Üretim Araçlarý"
        '
        'GridControl4
        '
        Me.GridControl4.ContextMenu = Me.kisayol_arac
        Me.GridControl4.DataMember = "Table1"
        Me.GridControl4.DataSource = Me.ds_arac
        Me.GridControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl4.Location = New System.Drawing.Point(0, 0)
        Me.GridControl4.MainView = Me.GridView6
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_pozisyon_arac, Me.sec_calismausulu_arac})
        Me.GridControl4.Size = New System.Drawing.Size(814, 191)
        Me.GridControl4.TabIndex = 0
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6})
        '
        'kisayol_arac
        '
        Me.kisayol_arac.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem22, Me.MenuItem23, Me.MenuItem24, Me.MenuItem26})
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 0
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem21.Text = "Ekle"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 1
        Me.MenuItem22.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem22.Text = "Sil"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 2
        Me.MenuItem23.Text = "-"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 3
        Me.MenuItem24.Text = "Görünümü Düzenle"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 4
        Me.MenuItem26.Text = "Görünümü Yazdýr"
        '
        'ds_arac
        '
        Me.ds_arac.DataSetName = "NewDataSet"
        Me.ds_arac.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_arac.Tables.AddRange(New System.Data.DataTable() {Me.DataTable7})
        '
        'DataTable7
        '
        Me.DataTable7.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn107, Me.DataColumn108, Me.DataColumn109, Me.DataColumn110, Me.DataColumn111, Me.DataColumn112, Me.DataColumn113, Me.DataColumn114, Me.DataColumn115})
        Me.DataTable7.TableName = "Table1"
        '
        'DataColumn107
        '
        Me.DataColumn107.ColumnName = "IND"
        Me.DataColumn107.DataType = GetType(Long)
        '
        'DataColumn108
        '
        Me.DataColumn108.ColumnName = "SIRANO"
        Me.DataColumn108.DataType = GetType(Long)
        '
        'DataColumn109
        '
        Me.DataColumn109.ColumnName = "EVRAKNO"
        Me.DataColumn109.DataType = GetType(Long)
        '
        'DataColumn110
        '
        Me.DataColumn110.ColumnName = "ARACNO"
        Me.DataColumn110.DataType = GetType(Long)
        '
        'DataColumn111
        '
        Me.DataColumn111.ColumnName = "ARACKODU"
        '
        'DataColumn112
        '
        Me.DataColumn112.ColumnName = "CALISMAUSULU"
        Me.DataColumn112.DataType = GetType(Long)
        '
        'DataColumn113
        '
        Me.DataColumn113.ColumnName = "POZISYONNO"
        Me.DataColumn113.DataType = GetType(Long)
        '
        'DataColumn114
        '
        Me.DataColumn114.ColumnName = "MIKTAR"
        Me.DataColumn114.DataType = GetType(Decimal)
        '
        'DataColumn115
        '
        Me.DataColumn115.ColumnName = "BIRIMMIKTAR"
        Me.DataColumn115.DataType = GetType(Decimal)
        '
        'GridView6
        '
        Me.GridView6.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView6.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView6.Appearance.Empty.Options.UseBackColor = True
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND3, Me.colSIRANO1, Me.colEVRAKNO3, Me.colARACNO, Me.colARACKODU, Me.colCALISMAUSULU, Me.colPOZISYONNO3, Me.colMIKTAR2, Me.colBIRIMMIKTAR2})
        Me.GridView6.CustomizationFormBounds = New System.Drawing.Rectangle(752, 188, 208, 170)
        Me.GridView6.DetailHeight = 160
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.GridControl = Me.GridControl4
        Me.GridView6.GroupFormat = "{0}: {1} {2}"
        Me.GridView6.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView6.IndicatorWidth = 35
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView6.OptionsCustomization.AllowFilter = False
        Me.GridView6.OptionsCustomization.AllowGroup = False
        Me.GridView6.OptionsCustomization.AllowSort = False
        Me.GridView6.OptionsDetail.ShowDetailTabs = False
        Me.GridView6.OptionsMenu.EnableColumnMenu = False
        Me.GridView6.OptionsMenu.EnableFooterMenu = False
        Me.GridView6.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView6.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView6.OptionsView.EnableAppearanceOddRow = True
        Me.GridView6.OptionsView.ShowFooter = True
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'colIND3
        '
        Me.colIND3.Caption = "Kayýt No"
        Me.colIND3.FieldName = "IND"
        Me.colIND3.Name = "colIND3"
        Me.colIND3.OptionsColumn.AllowEdit = False
        '
        'colSIRANO1
        '
        Me.colSIRANO1.Caption = "SýraNo"
        Me.colSIRANO1.FieldName = "SIRANO"
        Me.colSIRANO1.Name = "colSIRANO1"
        Me.colSIRANO1.Visible = True
        Me.colSIRANO1.VisibleIndex = 0
        '
        'colEVRAKNO3
        '
        Me.colEVRAKNO3.Caption = "Evrak No"
        Me.colEVRAKNO3.FieldName = "EVRAKNO"
        Me.colEVRAKNO3.Name = "colEVRAKNO3"
        Me.colEVRAKNO3.OptionsColumn.AllowEdit = False
        '
        'colARACNO
        '
        Me.colARACNO.Caption = "AraçNo"
        Me.colARACNO.FieldName = "ARACNO"
        Me.colARACNO.Name = "colARACNO"
        Me.colARACNO.OptionsColumn.AllowEdit = False
        '
        'colARACKODU
        '
        Me.colARACKODU.Caption = "AraçKodu"
        Me.colARACKODU.FieldName = "ARACKODU"
        Me.colARACKODU.Name = "colARACKODU"
        Me.colARACKODU.OptionsColumn.AllowEdit = False
        Me.colARACKODU.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ARACKODU", "{0} Kayýt")})
        Me.colARACKODU.Visible = True
        Me.colARACKODU.VisibleIndex = 1
        Me.colARACKODU.Width = 126
        '
        'colCALISMAUSULU
        '
        Me.colCALISMAUSULU.Caption = "ÇalýþmaUsulü"
        Me.colCALISMAUSULU.ColumnEdit = Me.sec_calismausulu_arac
        Me.colCALISMAUSULU.FieldName = "CALISMAUSULU"
        Me.colCALISMAUSULU.Name = "colCALISMAUSULU"
        Me.colCALISMAUSULU.OptionsColumn.AllowEdit = False
        Me.colCALISMAUSULU.Visible = True
        Me.colCALISMAUSULU.VisibleIndex = 2
        Me.colCALISMAUSULU.Width = 361
        '
        'sec_calismausulu_arac
        '
        Me.sec_calismausulu_arac.AutoHeight = False
        Me.sec_calismausulu_arac.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_calismausulu_arac.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "Açýklama")})
        Me.sec_calismausulu_arac.DataSource = Me.DataTable10
        Me.sec_calismausulu_arac.DisplayMember = "ACIKLAMA"
        Me.sec_calismausulu_arac.Name = "sec_calismausulu_arac"
        Me.sec_calismausulu_arac.NullText = ""
        Me.sec_calismausulu_arac.ShowFooter = False
        Me.sec_calismausulu_arac.ShowHeader = False
        Me.sec_calismausulu_arac.ShowLines = False
        Me.sec_calismausulu_arac.ValueMember = "IND"
        '
        'DataTable10
        '
        Me.DataTable10.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn124, Me.DataColumn125})
        Me.DataTable10.TableName = "Table1"
        '
        'DataColumn124
        '
        Me.DataColumn124.ColumnName = "IND"
        Me.DataColumn124.DataType = GetType(Long)
        '
        'DataColumn125
        '
        Me.DataColumn125.ColumnName = "ACIKLAMA"
        '
        'colPOZISYONNO3
        '
        Me.colPOZISYONNO3.Caption = "Pozisyon"
        Me.colPOZISYONNO3.ColumnEdit = Me.sec_pozisyon_arac
        Me.colPOZISYONNO3.FieldName = "POZISYONNO"
        Me.colPOZISYONNO3.Name = "colPOZISYONNO3"
        Me.colPOZISYONNO3.Visible = True
        Me.colPOZISYONNO3.VisibleIndex = 3
        Me.colPOZISYONNO3.Width = 179
        '
        'sec_pozisyon_arac
        '
        Me.sec_pozisyon_arac.AutoHeight = False
        Me.sec_pozisyon_arac.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_pozisyon_arac.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KOD", "Açýklama")})
        Me.sec_pozisyon_arac.DisplayMember = "KOD"
        Me.sec_pozisyon_arac.Name = "sec_pozisyon_arac"
        Me.sec_pozisyon_arac.NullText = ""
        Me.sec_pozisyon_arac.ShowFooter = False
        Me.sec_pozisyon_arac.ShowHeader = False
        Me.sec_pozisyon_arac.ShowLines = False
        Me.sec_pozisyon_arac.ValueMember = "IND"
        '
        'colMIKTAR2
        '
        Me.colMIKTAR2.Caption = "Miktar"
        Me.colMIKTAR2.FieldName = "MIKTAR"
        Me.colMIKTAR2.Name = "colMIKTAR2"
        '
        'colBIRIMMIKTAR2
        '
        Me.colBIRIMMIKTAR2.Caption = "Birim Miktar"
        Me.colBIRIMMIKTAR2.FieldName = "BIRIMMIKTAR"
        Me.colBIRIMMIKTAR2.Name = "colBIRIMMIKTAR2"
        Me.colBIRIMMIKTAR2.Visible = True
        Me.colBIRIMMIKTAR2.VisibleIndex = 4
        Me.colBIRIMMIKTAR2.Width = 183
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.GridControl5)
        Me.XtraTabPage5.Controls.Add(Me.GroupControl1)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(814, 191)
        Me.XtraTabPage5.Text = "Ek Maliyet"
        '
        'GridControl5
        '
        Me.GridControl5.ContextMenu = Me.kisayol_ek
        Me.GridControl5.DataMember = "Table1"
        Me.GridControl5.DataSource = Me.ds_hareket
        Me.GridControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl5.Location = New System.Drawing.Point(0, 44)
        Me.GridControl5.MainView = Me.GridView7
        Me.GridControl5.Name = "GridControl5"
        Me.GridControl5.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.sec_depo_ek, Me.RepositoryItemButtonEdit1, Me.RepositoryItemCalcEdit1, Me.RepositoryItemSpinEdit1, Me.RepositoryItemLookUpEdit3, Me.RepositoryItemLookUpEdit4})
        Me.GridControl5.Size = New System.Drawing.Size(814, 147)
        Me.GridControl5.TabIndex = 3
        Me.GridControl5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView7})
        '
        'kisayol_ek
        '
        Me.kisayol_ek.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem32, Me.MenuItem33, Me.MenuItem34, Me.MenuItem35, Me.MenuItem36, Me.MenuItem37, Me.MenuItem38})
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 0
        Me.MenuItem32.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem32.Text = "Ekle"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 1
        Me.MenuItem33.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem33.Text = "Sil"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 2
        Me.MenuItem34.Text = "-"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 3
        Me.MenuItem35.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem35.Text = "Deðer Yay"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 4
        Me.MenuItem36.Text = "-"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 5
        Me.MenuItem37.Text = "Görünümü Düzenle"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 6
        Me.MenuItem38.Text = "Görünümü Yazdýr"
        '
        'GridView7
        '
        Me.GridView7.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView7.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView7.Appearance.Empty.Options.UseBackColor = True
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27, Me.colCiktiEkTutar, Me.GridColumn29, Me.GridColumn30, Me.GridColumn31})
        Me.GridView7.CustomizationFormBounds = New System.Drawing.Rectangle(496, 228, 208, 170)
        Me.GridView7.DetailHeight = 160
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.GridControl = Me.GridControl5
        Me.GridView7.GroupFormat = "{0}: {1} {2}"
        Me.GridView7.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView7.IndicatorWidth = 35
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView7.OptionsCustomization.AllowFilter = False
        Me.GridView7.OptionsCustomization.AllowGroup = False
        Me.GridView7.OptionsCustomization.AllowSort = False
        Me.GridView7.OptionsDetail.ShowDetailTabs = False
        Me.GridView7.OptionsMenu.EnableColumnMenu = False
        Me.GridView7.OptionsMenu.EnableFooterMenu = False
        Me.GridView7.OptionsMenu.EnableGroupPanelMenu = False
        Me.GridView7.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView7.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView7.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView7.OptionsView.ShowFooter = True
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Kayýt No"
        Me.GridColumn1.FieldName = "IND"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Stok No"
        Me.GridColumn2.FieldName = "STOKNO"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Evrak No"
        Me.GridColumn4.FieldName = "EVRAKNO"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Stok Kodu"
        Me.GridColumn5.FieldName = "STOKKODU"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "STOKKODU", "{0} Kayýt")})
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        Me.GridColumn5.Width = 94
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Stok Adý"
        Me.GridColumn6.FieldName = "MALINCINSI"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 140
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Miktar"
        Me.GridColumn7.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.GridColumn7.DisplayFormat.FormatString = "#,0.#####"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "MIKTAR"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", "{0:#,0.00##}")})
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 2
        Me.GridColumn7.Width = 86
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatString = "#,0.####"
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.EditFormat.FormatString = "#,0.####"
        Me.RepositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn8.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn8.Caption = "Birim"
        Me.GridColumn8.ColumnEdit = Me.RepositoryItemButtonEdit1
        Me.GridColumn8.FieldName = "BIRIM"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 3
        Me.GridColumn8.Width = 53
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        Me.RepositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Barcode"
        Me.GridColumn9.FieldName = "BARCODE"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Birim Miktar"
        Me.GridColumn10.DisplayFormat.FormatString = "#,0.#####"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "BIRIMMIKTAR"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Kdv"
        Me.GridColumn11.DisplayFormat.FormatString = "#,0.#####"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "KDV"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 4
        Me.GridColumn11.Width = 62
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Fiyat"
        Me.GridColumn12.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.GridColumn12.DisplayFormat.FormatString = "#,0.00##"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "FIYAT"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 5
        Me.GridColumn12.Width = 98
        '
        'RepositoryItemCalcEdit1
        '
        Me.RepositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCalcEdit1.DisplayFormat.FormatString = "#,0.00##"
        Me.RepositoryItemCalcEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemCalcEdit1.EditFormat.FormatString = "#,0.00##"
        Me.RepositoryItemCalcEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemCalcEdit1.Name = "RepositoryItemCalcEdit1"
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Oran"
        Me.GridColumn16.DisplayFormat.FormatString = "#,#.##"
        Me.GridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn16.FieldName = "ORAN"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ORAN", "{0:#,0.00##}")})
        Me.GridColumn16.Width = 66
        '
        'GridColumn17
        '
        Me.GridColumn17.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GridColumn17.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn17.Caption = "Tür"
        Me.GridColumn17.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn17.FieldName = "TUR"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.Width = 57
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "Açýklama")})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.DataTable8
        Me.RepositoryItemLookUpEdit1.DisplayMember = "ACIKLAMA"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = "[Türler]"
        Me.RepositoryItemLookUpEdit1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.RepositoryItemLookUpEdit1.ShowFooter = False
        Me.RepositoryItemLookUpEdit1.ShowHeader = False
        Me.RepositoryItemLookUpEdit1.ShowLines = False
        Me.RepositoryItemLookUpEdit1.ValueMember = "IND"
        '
        'GridColumn18
        '
        Me.GridColumn18.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridColumn18.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn18.Caption = "Depo"
        Me.GridColumn18.ColumnEdit = Me.sec_depo_ek
        Me.GridColumn18.FieldName = "DEPONO"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 7
        Me.GridColumn18.Width = 109
        '
        'sec_depo_ek
        '
        Me.sec_depo_ek.AutoHeight = False
        Me.sec_depo_ek.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo_ek.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sDepo", "Depo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sAciklama", "Aciklama")})
        Me.sec_depo_ek.DisplayMember = "sDepo"
        Me.sec_depo_ek.Name = "sec_depo_ek"
        Me.sec_depo_ek.NullText = "[Depo]"
        Me.sec_depo_ek.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_depo_ek.ShowFooter = False
        Me.sec_depo_ek.ShowHeader = False
        Me.sec_depo_ek.ValueMember = "sDepo"
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Açýklama"
        Me.GridColumn19.FieldName = "ACIKLAMA"
        Me.GridColumn19.Name = "GridColumn19"
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "MaliyetTürü"
        Me.GridColumn20.FieldName = "MALIYETTURU"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.AllowEdit = False
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "MiktarTürü"
        Me.GridColumn21.FieldName = "MIKTARTURU"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.AllowEdit = False
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "ÇýkýþHesapKodu"
        Me.GridColumn22.FieldName = "URETIMCIKISHESAPKODU"
        Me.GridColumn22.Name = "GridColumn22"
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "YansýtmaHesapKodu"
        Me.GridColumn23.FieldName = "YANSITMAHESAPKODU"
        Me.GridColumn23.Name = "GridColumn23"
        '
        'GridColumn24
        '
        Me.GridColumn24.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn24.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn24.Caption = "Pozisyon"
        Me.GridColumn24.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.GridColumn24.FieldName = "POZISYONNO"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Width = 60
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("KOD", "Kod")})
        Me.RepositoryItemLookUpEdit3.DisplayMember = "KOD"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = "[Pozisyon]"
        Me.RepositoryItemLookUpEdit3.ShowFooter = False
        Me.RepositoryItemLookUpEdit3.ShowHeader = False
        Me.RepositoryItemLookUpEdit3.ShowLines = False
        Me.RepositoryItemLookUpEdit3.ValueMember = "IND"
        '
        'GridColumn25
        '
        Me.GridColumn25.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridColumn25.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn25.Caption = "ÇýkýþPozisyonu"
        Me.GridColumn25.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.GridColumn25.FieldName = "CIKISPOZISYONNO"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Width = 72
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "FireMiktarý"
        Me.GridColumn26.DisplayFormat.FormatString = "#,0.#####"
        Me.GridColumn26.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn26.FieldName = "FIREORANI"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FIREORANI", "{0:#,0.####}")})
        Me.GridColumn26.Width = 66
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "AraçNo"
        Me.GridColumn27.FieldName = "ARACLINENO"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.OptionsColumn.AllowEdit = False
        '
        'colCiktiEkTutar
        '
        Me.colCiktiEkTutar.Caption = "Tutar"
        Me.colCiktiEkTutar.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.colCiktiEkTutar.DisplayFormat.FormatString = "#,0.00"
        Me.colCiktiEkTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCiktiEkTutar.FieldName = "TUTAR"
        Me.colCiktiEkTutar.GroupFormat.FormatString = "#,0.00"
        Me.colCiktiEkTutar.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCiktiEkTutar.Name = "colCiktiEkTutar"
        Me.colCiktiEkTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", "{0:#,0.00##}")})
        Me.colCiktiEkTutar.Visible = True
        Me.colCiktiEkTutar.VisibleIndex = 6
        Me.colCiktiEkTutar.Width = 133
        '
        'GridColumn29
        '
        Me.GridColumn29.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridColumn29.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn29.Caption = "DovizCinsi"
        Me.GridColumn29.ColumnEdit = Me.RepositoryItemLookUpEdit4
        Me.GridColumn29.FieldName = "sDovizCinsi1"
        Me.GridColumn29.Name = "GridColumn29"
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.DisplayMember = "sDovizCinsi"
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.NullText = "[Doviz]"
        Me.RepositoryItemLookUpEdit4.ValueMember = "sDovizCinsi"
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "DovizKuru"
        Me.GridColumn30.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.GridColumn30.DisplayFormat.FormatString = "#,0.00##"
        Me.GridColumn30.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn30.FieldName = "lDovizKuru1"
        Me.GridColumn30.Name = "GridColumn30"
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "DovizMiktari"
        Me.GridColumn31.ColumnEdit = Me.RepositoryItemCalcEdit1
        Me.GridColumn31.DisplayFormat.FormatString = "#,0.00##"
        Me.GridColumn31.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn31.FieldName = "lDovizMiktari1"
        Me.GridColumn31.Name = "GridColumn31"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lbl_CiktiMalinCinsi)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.lbl_CiktiStokKodu)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.lbl_CiktiIND)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(814, 44)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Ek Girdiler"
        '
        'lbl_CiktiMalinCinsi
        '
        Me.lbl_CiktiMalinCinsi.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_CiktiMalinCinsi.Location = New System.Drawing.Point(486, 22)
        Me.lbl_CiktiMalinCinsi.Name = "lbl_CiktiMalinCinsi"
        Me.lbl_CiktiMalinCinsi.Size = New System.Drawing.Size(6, 13)
        Me.lbl_CiktiMalinCinsi.TabIndex = 5
        Me.lbl_CiktiMalinCinsi.Text = "*"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(436, 22)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "MalinCinsi:"
        '
        'lbl_CiktiStokKodu
        '
        Me.lbl_CiktiStokKodu.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_CiktiStokKodu.Location = New System.Drawing.Point(183, 22)
        Me.lbl_CiktiStokKodu.Name = "lbl_CiktiStokKodu"
        Me.lbl_CiktiStokKodu.Size = New System.Drawing.Size(6, 13)
        Me.lbl_CiktiStokKodu.TabIndex = 3
        Me.lbl_CiktiStokKodu.Text = "*"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(133, 22)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "StokKodu:"
        '
        'lbl_CiktiIND
        '
        Me.lbl_CiktiIND.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_CiktiIND.Location = New System.Drawing.Point(56, 22)
        Me.lbl_CiktiIND.Name = "lbl_CiktiIND"
        Me.lbl_CiktiIND.Size = New System.Drawing.Size(6, 13)
        Me.lbl_CiktiIND.TabIndex = 1
        Me.lbl_CiktiIND.Text = "*"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(6, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "EvrakNo:"
        '
        'BarManager1
        '
        Me.BarManager1.AllowCustomization = False
        Me.BarManager1.AllowMoveBarOnToolbar = False
        Me.BarManager1.AllowQuickCustomization = False
        Me.BarManager1.AllowShowToolbarsPopup = False
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2})
        Me.BarManager1.CloseButtonAffectAllTabs = False
        Me.BarManager1.Controller = Me.BarAndDockingController1
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarSubItem2, Me.BarSubItem3, Me.BarSubItem4, Me.BarSubItem6, Me.BarSubItem8, Me.BarSubItem9, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem15, Me.BarButtonItem16, Me.BarButtonItem17, Me.BarButtonItem18, Me.BarButtonItem19, Me.BarSubItem5, Me.BarButtonItem20, Me.BarButtonItem21, Me.BarButtonItem22, Me.BarSubItem7, Me.BarButtonItem23, Me.BarButtonItem24, Me.BarButtonItem25, Me.BarButtonItem26, Me.BarSubItem10, Me.BarButtonItem27, Me.BarButtonItem28, Me.BarButtonItem29, Me.BarButtonItem30, Me.BarButtonItem31, Me.BarSubItem11, Me.BarButtonItem32})
        Me.BarManager1.MainMenu = Me.Bar1
        Me.BarManager1.MaxItemId = 45
        Me.BarManager1.StatusBar = Me.Bar2
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 1"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem10), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem9), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem7)})
        Me.Bar1.OptionsBar.MultiLine = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Custom 1"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Belge"
        Me.BarSubItem2.Id = 1
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Reçete Kopyala"
        Me.BarButtonItem1.Id = 9
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Alt Reçete Oluþtur"
        Me.BarButtonItem2.Id = 10
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Demonte Oluþtur"
        Me.BarButtonItem3.Id = 11
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Belge Önizle"
        Me.BarButtonItem4.Id = 12
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Belge Dizayn"
        Me.BarButtonItem5.Id = 13
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Belge Yazdýr"
        Me.BarButtonItem6.Id = 14
        Me.BarButtonItem6.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Belgeyi Ýptal Et"
        Me.BarButtonItem7.Id = 15
        Me.BarButtonItem7.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y))
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "Satýr"
        Me.BarSubItem3.Id = 2
        Me.BarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem11), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem19, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem25), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem29, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem30), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem31)})
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'BarSubItem11
        '
        Me.BarSubItem11.Caption = "Fiyatlarý Güncelle"
        Me.BarSubItem11.Id = 43
        Me.BarSubItem11.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem32)})
        Me.BarSubItem11.Name = "BarSubItem11"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Son Alýþ Þartlarýna Göre"
        Me.BarButtonItem8.Id = 16
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem32
        '
        Me.BarButtonItem32.Caption = "Alýþ Fiyatýna Göre"
        Me.BarButtonItem32.Id = 44
        Me.BarButtonItem32.Name = "BarButtonItem32"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Depolara Daðýt"
        Me.BarButtonItem9.Id = 17
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Ýhtiyaç Tablosu"
        Me.BarButtonItem10.Id = 18
        Me.BarButtonItem10.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem19
        '
        Me.BarButtonItem19.Caption = "Hesap Makinasý"
        Me.BarButtonItem19.Id = 27
        Me.BarButtonItem19.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F1))
        Me.BarButtonItem19.Name = "BarButtonItem19"
        '
        'BarButtonItem25
        '
        Me.BarButtonItem25.Caption = "Satýrlarda Ara"
        Me.BarButtonItem25.Id = 35
        Me.BarButtonItem25.Name = "BarButtonItem25"
        '
        'BarButtonItem29
        '
        Me.BarButtonItem29.Caption = "Etiket Dizayn"
        Me.BarButtonItem29.Id = 40
        Me.BarButtonItem29.Name = "BarButtonItem29"
        '
        'BarButtonItem30
        '
        Me.BarButtonItem30.Caption = "Etiket Yazdýr"
        Me.BarButtonItem30.Id = 41
        Me.BarButtonItem30.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E))
        Me.BarButtonItem30.Name = "BarButtonItem30"
        '
        'BarButtonItem31
        '
        Me.BarButtonItem31.Caption = "Etiketleri Direkt Yazdýr"
        Me.BarButtonItem31.Id = 42
        Me.BarButtonItem31.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F2))
        Me.BarButtonItem31.Name = "BarButtonItem31"
        '
        'BarSubItem10
        '
        Me.BarSubItem10.Caption = "Analiz"
        Me.BarSubItem10.Id = 37
        Me.BarSubItem10.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem27), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem28)})
        Me.BarSubItem10.Name = "BarSubItem10"
        '
        'BarButtonItem27
        '
        Me.BarButtonItem27.Caption = "Envanter"
        Me.BarButtonItem27.Id = 38
        Me.BarButtonItem27.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.BarButtonItem27.Name = "BarButtonItem27"
        '
        'BarButtonItem28
        '
        Me.BarButtonItem28.Caption = "Stok Hareketleri"
        Me.BarButtonItem28.Id = 39
        Me.BarButtonItem28.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem28.Name = "BarButtonItem28"
        '
        'BarSubItem6
        '
        Me.BarSubItem6.Caption = "Görünüm"
        Me.BarSubItem6.Id = 5
        Me.BarSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem22, True)})
        Me.BarSubItem6.Name = "BarSubItem6"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Baþlýk"
        Me.BarButtonItem11.Id = 19
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarSubItem5
        '
        Me.BarSubItem5.Caption = "Toplam"
        Me.BarSubItem5.Id = 28
        Me.BarSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem20), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem21)})
        Me.BarSubItem5.Name = "BarSubItem5"
        '
        'BarButtonItem20
        '
        Me.BarButtonItem20.Caption = "Maliyet"
        Me.BarButtonItem20.Id = 29
        Me.BarButtonItem20.Name = "BarButtonItem20"
        '
        'BarButtonItem21
        '
        Me.BarButtonItem21.Caption = "Genel Toplamlar"
        Me.BarButtonItem21.Id = 30
        Me.BarButtonItem21.Name = "BarButtonItem21"
        '
        'BarButtonItem22
        '
        Me.BarButtonItem22.Caption = "Görünümü Kaydet"
        Me.BarButtonItem22.Id = 31
        Me.BarButtonItem22.Name = "BarButtonItem22"
        '
        'BarSubItem8
        '
        Me.BarSubItem8.Caption = "Ekran"
        Me.BarSubItem8.Id = 7
        Me.BarSubItem8.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem17)})
        Me.BarSubItem8.Name = "BarSubItem8"
        '
        'BarButtonItem17
        '
        Me.BarButtonItem17.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.BarButtonItem17.Caption = "Tam Ekran"
        Me.BarButtonItem17.Id = 25
        Me.BarButtonItem17.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12)
        Me.BarButtonItem17.Name = "BarButtonItem17"
        '
        'BarSubItem9
        '
        Me.BarSubItem9.Caption = "Language"
        Me.BarSubItem9.Id = 8
        Me.BarSubItem9.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem18)})
        Me.BarSubItem9.Name = "BarSubItem9"
        '
        'BarButtonItem18
        '
        Me.BarButtonItem18.Caption = "Dil Deðiþtir"
        Me.BarButtonItem18.Id = 26
        Me.BarButtonItem18.Name = "BarButtonItem18"
        '
        'BarSubItem7
        '
        Me.BarSubItem7.Caption = "Kesinleþtir"
        Me.BarSubItem7.Id = 32
        Me.BarSubItem7.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem23), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem24)})
        Me.BarSubItem7.Name = "BarSubItem7"
        '
        'BarButtonItem23
        '
        Me.BarButtonItem23.Caption = "Üretimi Kesinleþtir"
        Me.BarButtonItem23.Id = 33
        Me.BarButtonItem23.Name = "BarButtonItem23"
        '
        'BarButtonItem24
        '
        Me.BarButtonItem24.Caption = "Fiþi Göster"
        Me.BarButtonItem24.Id = 34
        Me.BarButtonItem24.Name = "BarButtonItem24"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 2"
        Me.Bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DrawDragBorder = False
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Custom 2"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Status"
        Me.BarSubItem1.Id = 0
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.PropertiesBar.AllowLinkLighting = False
        Me.BarAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
        Me.BarAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 517)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 25)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 495)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 495)
        '
        'BarSubItem4
        '
        Me.BarSubItem4.Caption = "Belgeleme"
        Me.BarSubItem4.Id = 3
        Me.BarSubItem4.Name = "BarSubItem4"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Hareketler"
        Me.BarButtonItem12.Id = 20
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Toplam"
        Me.BarButtonItem13.Id = 21
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "Hammadde Ekle"
        Me.BarButtonItem14.Id = 22
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "Maliyet Unsuru Ekle"
        Me.BarButtonItem15.Id = 23
        Me.BarButtonItem15.Name = "BarButtonItem15"
        '
        'BarButtonItem16
        '
        Me.BarButtonItem16.Caption = "Pozisyon Ekle"
        Me.BarButtonItem16.Id = 24
        Me.BarButtonItem16.Name = "BarButtonItem16"
        '
        'BarButtonItem26
        '
        Me.BarButtonItem26.Caption = "BarButtonItem26"
        Me.BarButtonItem26.Id = 36
        Me.BarButtonItem26.Name = "BarButtonItem26"
        '
        'ds_girdi_tur
        '
        Me.ds_girdi_tur.DataSetName = "NewDataSet"
        Me.ds_girdi_tur.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_girdi_tur.Tables.AddRange(New System.Data.DataTable() {Me.DataTable8})
        '
        'ds_depolar
        '
        Me.ds_depolar.DataSetName = "NewDataSet"
        Me.ds_depolar.Locale = New System.Globalization.CultureInfo("tr-TR")
        '
        'Timer1
        '
        '
        'ds_cikti_tur
        '
        Me.ds_cikti_tur.DataSetName = "NewDataSet"
        Me.ds_cikti_tur.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_cikti_tur.Tables.AddRange(New System.Data.DataTable() {Me.DataTable9})
        '
        'ds_calismausulu
        '
        Me.ds_calismausulu.DataSetName = "NewDataSet"
        Me.ds_calismausulu.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_calismausulu.Tables.AddRange(New System.Data.DataTable() {Me.DataTable10})
        '
        'frm_uretim_emir
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 542)
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.panel_info)
        Me.Controls.Add(Me.panel_toplam)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.panel_baslik)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_uretim_emir"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ýþ Emri"
        CType(Me.panel_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_baslik.ResumeLayout(False)
        CType(Me.VGrid_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_resim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_pozisyon_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel_toplam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_toplam.ResumeLayout(False)
        CType(Me.VGrid_maliyet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_maliyet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VGrid_aciklama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_aciklama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VGrid_geneltoplam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_toplam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel_info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_info.ResumeLayout(False)
        Me.panel_info.PerformLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_hareket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_miktar_girdi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_birim_girdi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_fiyat_girdi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_girdi_turu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo_girdi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_pozisyon_girdi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_DovizCinsi_girdi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_pozisyon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo_pozisyon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_fiyat_pozisyon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_miktar_pozisyon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_cikti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_miktar_cikti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_fiyat_cikti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_tur_cikti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_pozisyon_cikti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sDepo_cikti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_arac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_calismausulu_arac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_pozisyon_arac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage5.ResumeLayout(False)
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCalcEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo_ek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_girdi_tur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_depolar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_cikti_tur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_calismausulu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public firma
    Public donemno
    Public donem
    Public userno
    Public username
    Public connection
    Public depono
    Public belgeind As Int64
    Dim dr As DataRow
    Dim dr_baslik As DataRow
    Dim dr_haraket As DataRow
    Dim dr_maliyet As DataRow
    Dim dr_toplam As DataRow
    Dim dr_cikti As DataRow
    Dim dr_pozisyon As DataRow
    Dim dr_arac As DataRow
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim adapter As New OleDb.OleDbDataAdapter
    'alttoplam hesaplarý
    Public toplamhammadde As Decimal = 0
    Public toplammasraf As Decimal = 0
    Public hammaddeorani As Int64 = 0
    Public masraforani As Int64 = 0
    Public masraftoplami As Decimal = 0
    Public toplamfire As Decimal = 0
    Public firemiktari As Decimal = 0
    Public fireorani As Decimal = 0
    Public birimmaliyet As Decimal = 0
    Public karorani As Int64 = 0
    Public kar As Decimal = 0
    Public toplam As Decimal = 0
    Public kdv As Decimal = 0
    Public geneltoplam As Decimal = 0
    Public anamiktar As Decimal = 0
    Dim ds_pozisyon_maliyet As DataSet
    Dim ds_veri As DataSet
    Dim ds_cikti_ek As DataSet
    Dim stutar As Boolean = False
    
    'Reçete Queryleri
    
    Dim sSorgu_baslik As String = ""
    Dim sSorgu_hareket As String = ""
    Dim sSorgu_toplam As String = ""
    Dim sSorgu_iskonto As String = ""
    Dim sSorgu_masraf As String = ""
    Dim sSorgu_pozisyon As String = ""
    Dim sSorgu_arac As String = ""
    Dim sSorgu_Cikti As String = ""
    Dim sSorgu_Cikti_EK As String = ""
    Private Sub frm_uretim_recete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        stok_degistir()
        Try
            loaded()
        Catch ex As Exception
            Me.Close()
        End Try
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub stok_degistir()
        If belgeind = 0 Then
            Dim frm As New frm_uretim_recete_liste
            dr = ds_baslik.Tables(0).NewRow
            dr("IND") = 100
            ds_baslik.Tables(0).Rows.Add(dr)
            dr = ds_baslik.Tables(0).Rows(0)
            frm.connection = connection
            frm.firmano = firmano
            frm.donemno = donemno
            If frm.ShowDialog() = DialogResult.OK Then
                dr = ds_baslik.Tables(0).Rows(0)
                Dim dr1 As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                Dim dr2 As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                dr("RECETENO") = dr1("IND")
                ds_veri = sorgu_recete_baslik(dr("RECETENO"))
                For Each dr1 In ds_veri.Tables(0).Rows
                    dr("STOKNO") = dr1("STOKNO")
                    dr("STOKKODU") = dr1("STOKKODU")
                    dr("MALINCINSI") = dr1("MALINCINSI")
                    dr("BIRIM") = dr1("BIRIM")
                    dr("KDV") = dr1("KDV")
                    dr("TUTAR") = dr1("TUTAR")
                    dr("FIYAT") = dr1("FIYAT")
                    dr("SATISFIYATI") = dr1("SATISFIYATI")
                    dr("STANDARTSURE") = dr1("STANDARTSURE")
                    dr("OZELKOD") = dr1("OZELKOD")
                    dr("ACIKLAMA") = dr1("ACIKLAMA")
                    dr("KULLANICI") = dr1("KULLANICI")
                    dr("MIKTAR") = dr1("MIKTAR")
                    Try
                        dr("FISNO") = belgeno_kontrol(dataload_belgeno().ToString).ToString
                        con.Close()
                    Catch ex As Exception
                        dr("FISNO") = "A-000001"
                    End Try
                    con.Close()
                    dr("TARIH") = Today
                    dr("DURUM") = 2
                    dr("POZNO") = -1
                    dr("TERMIN") = Today
                    dr("URETIMEBASLAMATARIHI") = Today
                    dr("URETIMBITISTARIHI") = Today
                    dr("ENTEGRE") = 0
                    dr("IND") = baslik_kaydet_yeni(dr("STOKNO"), dr("STOKKODU").ToString, dr("MALINCINSI").ToString, dr("OZELKOD").ToString, dr("BIRIM").ToString, dr("FIYAT"), dr("KDV"), dr("KULLANICI"), Today, dr("TUTAR"), "", 0, dr("SATISFIYATI"), "", dr("MIKTAR"), dr("RECETENO"), dr("STANDARTSURE"), dr("DURUM"), dr("TARIH"), dr("FISNO"), dr("POZNO"), dr("TERMIN"), dr("URETIMEBASLAMATARIHI"), dr("URETIMBITISTARIHI"), dr("ENTEGRE"))
                    belgeind = dr("IND")
                Next
                'Çýktýlar
                ds_veri = sorgu_recete_cikti(dr("RECETENO"))
                Dim ds_veri_ek As DataSet
                Dim nEvrakno As Int64 = 0
                For Each dr1 In ds_veri.Tables(0).Rows
                    nEvrakno = cikti_kaydet_yeni(belgeind, dr1("STOKNO"), dr1("STOKKODU"), dr1("MALINCINSI"), dr1("MIKTAR"), dr1("BIRIM"), sorgu_sayi(dr1("BIRIMMIKTAR"), 1), dr1("KDV"), dr1("FIYAT"), dr1("BARCODE").ToString, Today, Today, dr1("KULLANICI"), dr1("ORAN"), dr1("TUR"), dr1("RECETENO"), dr1("TUTAR"), dr1("POZISYONNO"), sorgu_sayi(dr1("FIREORANI"), 0), sorgu_sayi(dr1("FIREMIKTARI"), 0), sorgu_sayi(dr1("KALANMIKTAR"), 0), "D001", dr1("EKMALIYET"), dr1("EKMALIYETTOPLAM"), dr1("EKMALIYETSTOKNO"), dr1("EKMALIYETSTOKKODU"), dr1("EKMALIYETMALINCINSI"), dr1("EKMALIYETKDV"))
                    ds_veri_ek = sorgu_recete_cikti_ek(dr1("IND"))
                    For Each dr2 In ds_veri_ek.Tables(0).Rows
                        cikti_ek_kaydet_yeni(nEvrakno, dr2("STOKNO"), dr2("MIKTAR"), dr2("BIRIM"), dr2("BIRIMMIKTAR"), dr2("KDV"), dr2("FIYAT"), dr2("TUTAR"), dr2("DEPONO"))
                    Next
                Next
                'Girdiler
                ds_veri = sorgu_recete_hareket(dr("RECETENO"))
                For Each dr1 In ds_veri.Tables(0).Rows
                    hareket_kaydet_yeni(belgeind, dr1("STOKNO"), dr1("STOKKODU"), dr1("MALINCINSI"), dr1("MIKTAR"), dr1("BIRIM"), dr1("BIRIMMIKTAR"), dr1("KDV"), dr1("FIYAT"), dr1("BARCODE"), Today, Today, dr1("KULLANICI"), dr1("ORAN"), dr1("TUR"), dr1("DEPONO"), dr1("ACIKLAMA"), dr1("MALIYETTURU"), dr1("MIKTARTURU"), dr1("URETIMCIKISHESAPKODU").ToString, dr1("YANSITMAHESAPKODU").ToString, dr1("POZISYONNO"), dr1("CIKISPOZISYONNO"), dr1("FIREORANI"), dr1("ARACLINENO"), dr1("sDovizCinsi1"), dr1("lDovizKuru1"), dr1("lDovizMiktari1"))
                Next
                'Pozisyonlar
                ds_veri = sorgu_recete_pozisyon(dr("RECETENO"))
                For Each dr1 In ds_veri.Tables(0).Rows
                    pozisyon_kaydet_yeni(belgeind, dr1("SIRANO"), dr1("KOD"), dr1("ACIKLAMA"), dr1("POZISYONNO"), dr1("URETIMYERINO"), dr1("URETIMYERIKODU"), dr1("DEPOKODU"), dr1("DEPONO"), dr1("MALIYET"), dr1("TOPLAMMALIYET"), dr1("STANDARTSURE"), dr1("SUREHESAPLAMATURU"), dr1("STANDARTBIRIMSURE"), Today, Today, 1, 1)
                Next
                'Araçlar
                ds_veri = sorgu_recete_araclar(dr("RECETENO"))
                For Each dr1 In ds_veri.Tables(0).Rows
                    arac_kaydet_yeni(dr1("SIRANO"), belgeind, dr1("ARACNO"), dr1("ARACKODU"), dr1("CALISMAUSULU"), dr1("POZISYONNO"), dr1("MIKTAR"), dr1("BIRIMMIKTAR"))
                Next
                dr1 = Nothing
                dr2 = Nothing
            Else
                Me.Close()
            End If
        Else
        End If
    End Sub
    Private Function belgeno_kontrol(ByVal belgeno As String, Optional ByVal islem As Integer = 0) As String
        Dim seri
        Dim no
        Dim evrak_no
        evrak_no = belgeno
        evrak_no = evrak_no.Replace(0, "")
        evrak_no = evrak_no.Replace(1, "")
        evrak_no = evrak_no.Replace(2, "")
        evrak_no = evrak_no.Replace(3, "")
        evrak_no = evrak_no.Replace(4, "")
        evrak_no = evrak_no.Replace(5, "")
        evrak_no = evrak_no.Replace(6, "")
        evrak_no = evrak_no.Replace(7, "")
        evrak_no = evrak_no.Replace(8, "")
        evrak_no = evrak_no.Replace(9, "")
        'txtbelgeseri.EditValue = evrak_no
        seri = evrak_no
        If evrak_no = "" Then
            seri = "A-"
        End If
        evrak_no = belgeno
        evrak_no = evrak_no.Replace("A", "")
        evrak_no = evrak_no.Replace("B", "")
        evrak_no = evrak_no.Replace("C", "")
        evrak_no = evrak_no.Replace("Ç", "")
        evrak_no = evrak_no.Replace("D", "")
        evrak_no = evrak_no.Replace("E", "")
        evrak_no = evrak_no.Replace("F", "")
        evrak_no = evrak_no.Replace("G", "")
        evrak_no = evrak_no.Replace("H", "")
        evrak_no = evrak_no.Replace("I", "")
        evrak_no = evrak_no.Replace("Ý", "")
        evrak_no = evrak_no.Replace("J", "")
        evrak_no = evrak_no.Replace("K", "")
        evrak_no = evrak_no.Replace("L", "")
        evrak_no = evrak_no.Replace("M", "")
        evrak_no = evrak_no.Replace("N", "")
        evrak_no = evrak_no.Replace("O", "")
        evrak_no = evrak_no.Replace("Ö", "")
        evrak_no = evrak_no.Replace("P", "")
        evrak_no = evrak_no.Replace("R", "")
        evrak_no = evrak_no.Replace("S", "")
        evrak_no = evrak_no.Replace("Þ", "")
        evrak_no = evrak_no.Replace("T", "")
        evrak_no = evrak_no.Replace("U", "")
        evrak_no = evrak_no.Replace("Ü", "")
        evrak_no = evrak_no.Replace("V", "")
        evrak_no = evrak_no.Replace("Y", "")
        evrak_no = evrak_no.Replace("Z", "")
        evrak_no = evrak_no.Replace("X", "")
        evrak_no = evrak_no.Replace("W", "")
        evrak_no = evrak_no.Replace("_", "")
        evrak_no = evrak_no.Replace("-", "")
        evrak_no = evrak_no.Replace("*", "")
        evrak_no = evrak_no.Replace("/", "")
        evrak_no = evrak_no.Replace("+", "")
        Try
            If islem = 0 Then
                no = CType(evrak_no, Integer) + 1
            Else
                no = CType(evrak_no, Integer)
            End If
            no = columnuzunlukinteger_sifir(no.ToString, 6)
            belgeno = seri + no.ToString
        Catch ex As Exception
            belgeno = seri + columnuzunlukinteger_sifir(1, 6)
        End Try
        Return belgeno
    End Function
    Private Function dataload_belgeno() As String
        Dim sonuc
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = connection
            cmd.Connection = con
            con.Open()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(FISNO,'A-000001') AS BELGENO FROM TBLUREURETIMLIST WHERE IND = (SELECT ISNULL(MAX(IND),0) FROM TBLUREURETIMLIST  WHERE  FISNO LIKE 'A%')")
            sonuc = cmd.ExecuteScalar
            con.Close()
            If CStr(sonuc).ToString = "" Then
                sonuc = "A-000000"
            End If
            cmd = Nothing
            con = Nothing
        Catch ex As Exception
            sonuc = "A-000000"
        End Try
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return sonuc
        sonuc = Nothing
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
#Region " Satýr Eklemeleri "
    Private Sub satir_ekle_cikti()
        Dim frm As New frm_stok
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr1 As DataRow
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = ds_cikti.Tables(0).NewRow
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr("STOKNO") = dr1("nStokID")
                    dr("STOKKODU") = dr1("sKodu")
                    dr("MALINCINSI") = dr1("sAciklama")
                    dr("BIRIM") = dr1("sBirimCinsi1")
                    dr("BARCODE") = dr1("sBarkod")
                    dr("KDV") = dr1("nKdvOrani")
                    dr("TUTAR") = 0
                    dr("FIYAT") = sorgu_sayi(dr1("ALISFIYATI"), 0)
                    dr("KULLANICI") = 100
                    dr("MIKTAR") = 1
                    dr("BIRIMMIKTAR") = 1
                    dr("KALANMIKTAR") = 1
                    dr("FIREMIKTARI") = 0
                    dr("FIREORANI") = 0
                    dr("POZISYONNO") = 1
                    dr("TUR") = 0
                    dr("ORAN") = 100
                    dr("DEPONO") = "D001"
                    dr("EKMALIYET") = 0
                    dr("EKMALIYETTOPLAM") = 0
                    dr("EKMALIYETSTOKNO") = 0
                    dr("EKMALIYETSTOKKODU") = ""
                    dr("EKMALIYETMALINCINSI") = ""
                    dr("EKMALIYETKDV") = 0
                    'bURAYI eKLE

                    dr("IND") = cikti_kaydet_yeni(belgeind, dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("MIKTAR"), dr("BIRIM"), dr("BIRIMMIKTAR"), dr("KDV"), dr("FIYAT"), dr("BARCODE"), Now, Now, dr("KULLANICI"), dr("ORAN"), dr("TUR"), belgeind, dr("TUTAR"), dr("POZISYONNO"), dr("FIREORANI"), dr("FIREMIKTARI"), dr("KALANMIKTAR"), dr("DEPONO"), dr("EKMALIYET"), dr("EKMALIYETTOPLAM"), dr("EKMALIYETSTOKNO"), dr("EKMALIYETSTOKKODU"), dr("EKMALIYETMALINCINSI"), dr("EKMALIYETKDV"))
                    ds_cikti.Tables(0).Rows.Add(dr)
                    dr1 = Nothing
                Next
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
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
            End If
        End If
    End Sub
    Private Sub satir_ekle_cikti_maliyet()
        Dim frm As New frm_stok
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        If frm.ShowDialog() = DialogResult.OK Then
            Dim dr As DataRow = GridView5.GetDataRow(GridView5.FocusedRowHandle)
            Dim dr1 As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            dr("EKMALIYETSTOKNO") = dr1("nStokID")
            dr("EKMALIYETSTOKKODU") = dr1("sKodu").ToString
            dr("EKMALIYETMALINCINSI") = dr1("sAciklama").ToString
            dr("EKMALIYETKDV") = dr1("nKdvOrani")
            dr("EKMALIYET") = sorgu_sayi(dr1("MALIYET"), 0)
            dr("EKMALIYETTOPLAM") = dr("EKMALIYET") * dr("MIKTAR")
            cikti_degistir(dr("IND"), belgeind, dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("MIKTAR"), dr("BIRIM"), dr("BIRIMMIKTAR"), dr("MIKTAR2"), dr("KDV"), dr("FIYAT"), dr("BARCODE"), Now, Now, dr("KULLANICI"), 100, dr("TUR"), dr("DEPONO"), belgeind, dr("TUTAR"), dr("POZISYONNO"), dr("FIREORANI"), dr("FIREMIKTARI"), dr("KALANMIKTAR"), dr("EKMALIYET"), dr("EKMALIYETTOPLAM"), dr("EKMALIYETSTOKNO"), dr("EKMALIYETSTOKKODU"), dr("EKMALIYETMALINCINSI"), dr("EKMALIYETKDV"))
            dr1 = Nothing
        Else
        End If
    End Sub
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub satir_ekle_girdi()
        Dim frm As New frm_stok
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr1 As DataRow
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = ds_hareket.Tables(0).NewRow()
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr("STOKKODU") = dr1("sKodu").ToString
                    dr("MALINCINSI") = dr1("sAciklama").ToString
                    dr("BIRIM") = dr1("sBirimCinsi1").ToString
                    dr("BARCODE") = dr1("sBarkod").ToString
                    dr("EVRAKNO") = belgeind
                    dr("KDV") = dr1("nKdvOrani")
                    dr("TUTAR") = 0
                    dr("FIYAT") = sorgu_sayi(dr1("ALISFIYATI"), 0)
                    dr("KULLANICI") = 100
                    dr("MIKTAR") = 1
                    dr("TUR") = 0
                    dr("DEPONO") = 1
                    dr("POZISYONNO") = 1
                    dr("CIKISPOZISYONNO") = 1
                    dr("FIREORANI") = 0
                    dr("ARACLINENO") = 0
                    dr("URETIMCIKISHESAPKODU") = ""
                    dr("YANSITMAHESAPKODU") = ""
                    dr("ORAN") = 100
                    dr("MALIYETTURU") = -1
                    dr("MIKTARTURU") = 1
                    dr("ISLEMTARIHI") = Now
                    dr("SONERISIMTARIHI") = Now
                    dr("BIRIMMIKTAR") = dr_baslik("MIKTAR") / dr("MIKTAR")
                    dr("ACIKLAMA") = ""
                    dr("sDovizCinsi1") = ""
                    dr("lDovizKuru1") = 0
                    dr("lDovizMiktari1") = 0
                    dr("IND") = hareket_kaydet_yeni(belgeind, dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("MIKTAR"), dr("BIRIM"), dr("BIRIMMIKTAR"), dr("KDV"), dr("FIYAT"), dr("BARCODE"), dr("ISLEMTARIHI"), dr("SONERISIMTARIHI"), dr("KULLANICI"), dr("ORAN"), dr("TUR"), dr("DEPONO"), dr("ACIKLAMA"), dr("MALIYETTURU"), dr("MIKTARTURU"), dr("URETIMCIKISHESAPKODU"), dr("YANSITMAHESAPKODU"), dr("POZISYONNO"), dr("CIKISPOZISYONNO"), dr("FIREORANI"), dr("ARACLINENO"), dr("sDovizCinsi1"), dr("lDovizKuru1"), dr("lDovizMiktari1"))
                    ds_hareket.Tables(0).Rows.Add(dr)
                    dr1 = Nothing
                Next
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
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
            End If
        End If
    End Sub
    Private Sub satir_ekle_cikti_ek(ByVal EVRAKNO As Int64)
        Dim frm As New frm_stok
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        'ds_hareket.Tables(0).NewRow()
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr1 As DataRow
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = ds_cikti_ek.Tables(0).NewRow()
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr("STOKNO") = dr1("nStokID")
                    dr("STOKKODU") = dr1("sKodu").ToString
                    dr("MALINCINSI") = dr1("sAciklama").ToString
                    dr("BIRIM") = dr1("sBirimCinsi1").ToString
                    dr("EVRAKNO") = EVRAKNO
                    dr("KDV") = dr1("nKdvOrani")
                    dr("TUTAR") = sorgu_sayi(dr1("MALIYET"), 0)
                    dr("FIYAT") = sorgu_sayi(dr1("MALIYET"), 0)
                    dr("MIKTAR") = 1
                    dr("DEPONO") = sDepo
                    dr("BIRIMMIKTAR") = 1
                    dr("IND") = cikti_ek_kaydet_yeni(EVRAKNO, dr("STOKNO"), dr("MIKTAR"), dr("BIRIM"), dr("BIRIMMIKTAR"), dr("KDV"), dr("FIYAT"), dr("TUTAR"), dr("DEPONO"))
                    ds_cikti_ek.Tables(0).Rows.Add(dr)
                    dr1 = Nothing
                Next
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
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
            End If
        End If
    End Sub
    Private Sub satir_ekle_masraf()
        Dim frm As New frm_uretim_maliyet_unsurlari
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        If frm.ShowDialog() = DialogResult.OK Then
            dr = ds_hareket.Tables(0).NewRow
            Dim dr1 As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            dr("STOKNO") = dr1("IND")
            dr("STOKKODU") = dr1("KOD").ToString
            dr("MALINCINSI") = dr1("AD").ToString
            dr("BIRIM") = dr1("BIRIMADI").ToString
            dr("BARCODE") = ""
            dr("EVRAKNO") = belgeind
            dr("KDV") = 0
            dr("TUTAR") = dr1("TUTAR")
            dr("FIYAT") = dr1("TUTAR")
            dr("KULLANICI") = 100
            dr("MIKTAR") = 1
            dr("TUR") = 1
            dr("DEPONO") = 1
            dr("POZISYONNO") = 1
            dr("CIKISPOZISYONNO") = 1
            dr("FIREORANI") = 0
            dr("ARACLINENO") = 0
            dr("URETIMCIKISHESAPKODU") = ""
            dr("YANSITMAHESAPKODU") = ""
            dr("ORAN") = 100
            dr("MALIYETTURU") = 0
            dr("MIKTARTURU") = 1
            dr("ISLEMTARIHI") = Now
            dr("SONERISIMTARIHI") = Now
            dr("BIRIMMIKTAR") = dr_baslik("MIKTAR") / dr("MIKTAR")
            dr("ACIKLAMA") = ""
            dr("IND") = hareket_kaydet_yeni(belgeind, dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("MIKTAR"), dr("BIRIM"), dr("BIRIMMIKTAR"), dr("KDV"), dr("FIYAT"), dr("BARCODE"), dr("ISLEMTARIHI"), dr("SONERISIMTARIHI"), dr("KULLANICI"), dr("ORAN"), dr("TUR"), dr("DEPONO"), dr("ACIKLAMA"), dr("MALIYETTURU"), dr("MIKTARTURU"), dr("URETIMCIKISHESAPKODU"), dr("YANSITMAHESAPKODU"), dr("POZISYONNO"), dr("CIKISPOZISYONNO"), dr("FIREORANI"), dr("ARACLINENO"), dr("sDovizCinsi1"), dr("lDovizKuru1"), dr("lDovizMiktari1"))
            ds_hareket.Tables(0).Rows.Add(dr)
            dr1 = Nothing
        Else
        End If
    End Sub
    Private Sub satir_ekle_pozisyon()
        Dim frm As New frm_uretim_pozisyonlari
        dr = ds_baslik.Tables(0).Rows(0)
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        If frm.ShowDialog() = DialogResult.OK Then
            dr = ds_pozisyon.Tables(0).NewRow
            Dim dr1 As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            dr("EVRAKNO") = belgeind
            If GridView3.RowCount > 0 Then
                dr("SIRANO") = pozisyon_no_bul(belgeind)
            Else
                dr("SIRANO") = 1
            End If
            dr("KOD") = dr1("KOD")
            dr("ACIKLAMA") = dr1("ACIKLAMA")
            dr("STANDARTSURE") = dr1("SURE")
            dr("POZISYONNO") = dr1("IND")
            dr("DEPONO") = 1
            dr("DEPOKODU") = ""
            dr("MALIYET") = 0
            dr("TOPLAMMALIYET") = 0
            dr("SUREHESAPLAMATURU") = 1
            dr("STANDARTBIRIMSURE") = 0.012
            dr("URETIMYERINO") = 0
            dr("URETIMYERIKODU") = ""
            dr("GIRISTARIHI") = Today
            dr("CIKISTARIHI") = Today
            dr("GIRISMIKTARI") = 1
            dr("CIKISMIKTARI") = 1
            dr("IND") = pozisyon_kaydet_yeni(belgeind, dr("SIRANO"), dr("KOD"), dr("ACIKLAMA"), dr("POZISYONNO"), dr("URETIMYERINO"), dr("URETIMYERIKODU"), dr("DEPOKODU"), dr("DEPONO"), dr("MALIYET"), dr("TOPLAMMALIYET"), dr("STANDARTSURE"), dr("SUREHESAPLAMATURU"), dr("STANDARTBIRIMSURE"), dr("GIRISTARIHI"), dr("CIKISTARIHI"), dr("GIRISMIKTARI"), dr("CIKISMIKTARI"))
            ds_pozisyon.Tables(0).Rows.Add(dr)
            dr1 = Nothing
            dataload_pozisyon_girdi()
            dataload_pozisyon_maliyet()
        Else
        End If
    End Sub
    Private Sub satir_ekle_arac()
        Dim frm As New frm_uretim_araclari
        dr = ds_baslik.Tables(0).Rows(0)
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        If frm.ShowDialog() = DialogResult.OK Then
            dr = ds_arac.Tables(0).NewRow
            Dim dr1 As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            dr("EVRAKNO") = belgeind
            If GridView6.RowCount > 0 Then
                dr("SIRANO") = arac_no_bul(belgeind)
            Else
                dr("SIRANO") = 1
            End If
            dr("ARACKODU") = dr1("KOD")
            dr("ARACNO") = dr1("IND")
            dr("CALISMAUSULU") = dr1("CALISMAUSULU")
            dr("POZISYONNO") = 1
            dr("MIKTAR") = 1
            dr("BIRIMMIKTAR") = 1
            dr("IND") = arac_kaydet_yeni(dr("SIRANO"), belgeind, dr("ARACNO"), dr("ARACKODU"), dr("CALISMAUSULU"), dr("POZISYONNO"), dr("MIKTAR"), dr("BIRIMMIKTAR"))
            ds_arac.Tables(0).Rows.Add(dr)
            dr1 = Nothing
        Else
        End If
    End Sub
    Private Sub satir_duzelt_pozisyon()
        Dim frm As New frm_uretim_yerleri
        dr = ds_baslik.Tables(0).Rows(0)
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        If frm.ShowDialog() = DialogResult.OK Then
            dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            Dim dr1 As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            dr("URETIMYERINO") = dr1("IND")
            dr("URETIMYERIKODU") = dr1("KOD")
            dr("DEPONO") = dr1("DEPONO")
            dr("DEPOKODU") = dr1("DEPOKODU")
            dr1 = Nothing
            pozisyon_degistir(dr("IND"), belgeind, dr("SIRANO"), dr("KOD"), dr("ACIKLAMA"), dr("POZISYONNO"), dr("URETIMYERINO"), dr("URETIMYERIKODU"), dr("DEPOKODU"), dr("DEPONO"), dr("MALIYET"), dr("TOPLAMMALIYET"), dr("STANDARTSURE"), dr("SUREHESAPLAMATURU"), dr("STANDARTBIRIMSURE"), dr("GIRISTARIHI"), dr("CIKISTARIHI"), dr("GIRISMIKTARI"), dr("CIKISMIKTARI"))
        End If
    End Sub
#End Region
#Region " Loaded "
    Private Sub loaded()
        'stok class çalýþtýr
        'stok_islemleri.firmano = firmano
        'stok_islemleri.firma = firma
        'stok_islemleri.donemno = donemno
        'stok_islemleri.donem = donem
        'stok_islemleri.userno = userno
        'stok_islemleri.username = username
        'stok_islemleri.connection = connection
        girdi_turleri()
        cikti_turleri()
        dataload_depo()
        dataload_pozisyon_girdi()
        dataload_calismausulu()
        dataload_alttoplam()
        dataload_maliyet()
        dataload_baslik()
        dataload_pozisyon()
        dataload_hareket()
        dataload_araclar()
        dataload_cikti()
        GridControl1.Focus()
        GridControl1.Select()
        dr_maliyet = ds_maliyet.Tables(0).Rows(0)
        dr_baslik = ds_baslik.Tables(0).Rows(0)
        anamiktar = dr_baslik("MIKTAR")
        dr_toplam = ds_toplam.Tables(0).Rows(0)
        Timer1.Enabled = True
    End Sub
#End Region
#Region " HESAPLAMALAR VE KONTROL "
    Private Function baslik_kaydet_yeni(ByVal STOKNO As Int64, ByVal STOKKODU As String, ByVal MALINCINSI As String, ByVal OZELKOD As String, ByVal BIRIM As String, ByVal FIYAT As Decimal, ByVal KDV As Int64, ByVal KULLANICI As Int64, ByVal SONERISIMTARIHI As DateTime, ByVal TUTAR As Decimal, ByVal ACIKLAMA As String, ByVal STOKTIPI As Int64, ByVal SATISFIYATI As Decimal, ByVal URETIMGIRISHESAPKODU As String, ByVal MIKTAR As Decimal, ByVal RECETENO As Int64, ByVal STANDARTSURE As Int64, ByVal durum As Int64, ByVal tarih As DateTime, ByVal fisno As String, ByVal pozno As Int64, ByVal termin As DateTime, ByVal uretimbaslamatarihi As DateTime, ByVal uretimbitistarihi As DateTime, ByVal ENTEGRE As Int64) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO TBLUREURETIMLIST      (STOKNO, STOKKODU, MALINCINSI, OZELKOD, BIRIM, FIYAT, KDV, KULLANICI, SONERISIMTARIHI, TUTAR, ACIKLAMA, STOKTIPI, SATISFIYATI, URETIMGIRISHESAPKODU, MIKTAR, RECETENO, STANDARTSURE,DURUM,TARIH,FISNO,POZNO,TERMIN,URETIMEBASLAMATARIHI,URETIMBITISTARIHI,ENTEGRE) VALUES     (" & STOKNO & ", '" & STOKKODU & "', '" & MALINCINSI & "' , '" & OZELKOD & "', '" & BIRIM & "', " & FIYAT & ", " & KDV & ", " & KULLANICI & ", '" & SONERISIMTARIHI & "', " & TUTAR & ", '" & ACIKLAMA & "', " & STOKTIPI & ", " & SATISFIYATI & ", '" & URETIMGIRISHESAPKODU & "', " & MIKTAR & ", " & RECETENO & ", " & STANDARTSURE & "," & durum & ",'" & tarih & "','" & fisno & "'," & pozno & ",'" & termin & "','" & uretimbaslamatarihi & "','" & uretimbitistarihi & "'," & ENTEGRE & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        cmd = Nothing
        con = Nothing
        Return hareketno
    End Function
    Private Function hareket_kaydet_yeni(ByVal EVRAKNO As Int64, ByVal STOKNO As Int64, ByVal STOKKODU As String, ByVal MALINCINSI As String, ByVal MIKTAR As Decimal, ByVal BIRIM As String, ByVal BIRIMMIKTAR As Decimal, ByVal KDV As Int64, ByVal FIYAT As Decimal, ByVal BARCODE As String, ByVal ISLEMTARIHI As DateTime, ByVal SONERISIMTARIHI As DateTime, ByVal KULLANICI As Int64, ByVal ORAN As Decimal, ByVal TUR As Int64, ByVal DEPONO As String, ByVal ACIKLAMA As String, ByVal MALIYETTURU As Int64, ByVal MIKTARTURU As Int64, ByVal URETIMCIKISHESAPKODU As String, ByVal YANSITMAHESAPKODU As String, ByVal POZISYONNO As Int64, ByVal CIKISPOZISYONNO As Int64, ByVal FIREORANI As Decimal, ByVal ARACLINENO As Int64, ByVal sDovizCinsi1 As String, ByVal lDovizKuru1 As Decimal, ByVal lDovizMiktari1 As Decimal) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO TBLUREURETIM                       (EVRAKNO, STOKNO, STOKKODU, MALINCINSI, MIKTAR, BIRIM, BIRIMMIKTAR, KDV, FIYAT, BARCODE, ISLEMTARIHI, SONERISIMTARIHI, KULLANICI, ORAN, TUR, DEPONO, ACIKLAMA, MALIYETTURU, MIKTARTURU, URETIMCIKISHESAPKODU, YANSITMAHESAPKODU, POZISYONNO,  CIKISPOZISYONNO, FIREORANI, ARACLINENO,sDovizCinsi1,lDovizKuru1,lDovizMiktari1) VALUES     (" & EVRAKNO & ", " & STOKNO & ", '" & STOKKODU & "', '" & MALINCINSI & "', " & MIKTAR & ", '" & BIRIM & "', " & BIRIMMIKTAR & ", " & KDV & ", " & FIYAT & ", '" & BARCODE & "', '" & ISLEMTARIHI & "', '" & SONERISIMTARIHI & "', " & KULLANICI & "," & ORAN & ", " & TUR & ",'" & DEPONO & "', '" & ACIKLAMA & "', " & MALIYETTURU & ", " & MIKTARTURU & ", '" & URETIMCIKISHESAPKODU & "', '" & YANSITMAHESAPKODU & "', " & POZISYONNO & ", " & CIKISPOZISYONNO & ", " & FIREORANI & ", " & ARACLINENO & ",'" & sDovizCinsi1 & "'," & lDovizKuru1 & "," & lDovizMiktari1 & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        cmd = Nothing
        con = Nothing
        Return hareketno
    End Function
    'BURAYI EKLE
    Private Function cikti_kaydet_yeni(ByVal EVRAKNO As Int64, ByVal STOKNO As Int64, ByVal STOKKODU As String, ByVal MALINCINSI As String, ByVal MIKTAR As Decimal, ByVal BIRIM As String, ByVal BIRIMMIKTAR As Decimal, ByVal KDV As Int64, ByVal FIYAT As Decimal, ByVal BARCODE As String, ByVal ISLEMTARIHI As DateTime, ByVal SONERISIMTARIHI As DateTime, ByVal KULLANICI As Int64, ByVal ORAN As Int64, ByVal TUR As Int64, ByVal RECETENO As Int64, ByVal TUTAR As Decimal, ByVal POZISYONNO As Int64, ByVal FIREORANI As Int64, ByVal FIREMIKTARI As Decimal, ByVal KALANMIKTAR As Decimal, ByVal DEPONO As String, ByVal EKMALIYET As Decimal, ByVal EKMALIYETTOPLAM As Decimal, ByVal EKMALIYETSTOKNO As Int64, ByVal EKMALIYETSTOKKODU As String, ByVal EKMALIYETMALINCINSI As String, ByVal EKMALIYETKDV As Decimal) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO TBLUREURETIMCIKTI                       (EVRAKNO, STOKNO, STOKKODU, MALINCINSI, MIKTAR, BIRIM, BIRIMMIKTAR,KDV, FIYAT, BARCODE, ISLEMTARIHI, SONERISIMTARIHI, KULLANICI, ORAN, TUR, RECETENO, TUTAR, POZISYONNO, FIREORANI, FIREMIKTARI, KALANMIKTAR,DEPONO,EKMALIYET,EKMALIYETTOPLAM,EKMALIYETSTOKNO,EKMALIYETSTOKKODU,EKMALIYETMALINCINSI,EKMALIYETKDV) VALUES     (" & EVRAKNO & ", " & STOKNO & ", '" & STOKKODU & "', '" & MALINCINSI & "', " & MIKTAR & ", '" & BIRIM & "', " & BIRIMMIKTAR & "," & KDV & ", " & FIYAT & ", '" & BARCODE & "', '" & ISLEMTARIHI & "', '" & SONERISIMTARIHI & "', " & KULLANICI & ", " & ORAN & ", " & TUR & ", " & RECETENO & ", " & TUTAR & ", " & POZISYONNO & ", " & FIREORANI & ", " & FIREMIKTARI & ", " & KALANMIKTAR & ",'" & DEPONO & "'," & EKMALIYET & "," & EKMALIYETTOPLAM & "," & EKMALIYETSTOKNO & ",'" & EKMALIYETSTOKKODU & "','" & EKMALIYETMALINCINSI & "'," & EKMALIYETKDV & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        cmd = Nothing
        con = Nothing
        Return hareketno
        con.Close()
    End Function
    Private Function cikti_ek_kaydet_yeni(ByVal EVRAKNO As Int64, ByVal STOKNO As Int64, ByVal MIKTAR As Decimal, ByVal BIRIM As String, ByVal BIRIMMIKTAR As Decimal, ByVal KDV As Decimal, ByVal FIYAT As Decimal, ByVal TUTAR As Decimal, ByVal DEPONO As String) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO TBLUREURETIMCIKTIEKMALIYET                       (EVRAKNO, STOKNO, MIKTAR, BIRIM, BIRIMMIKTAR, KDV,FIYAT, TUTAR, DEPONO) VALUES     (" & EVRAKNO & ", " & STOKNO & ", " & MIKTAR & ", '" & BIRIM & "', " & BIRIMMIKTAR & ", " & KDV & "," & FIYAT & ", " & TUTAR & ", '" & DEPONO & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
    End Function
    Private Function arac_kaydet_yeni(ByVal SIRANO As Int64, ByVal EVRAKNO As Int64, ByVal ARACNO As Int64, ByVal ARACKODU As String, ByVal CALISMAUSULU As Int64, ByVal POZISYONNO As Int64, ByVal MIKTAR As Decimal, ByVal BIRIMMIKTAR As Decimal) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO TBLUREURETIMARAC (SIRANO, EVRAKNO, ARACNO, ARACKODU, CALISMAUSULU, POZISYONNO, MIKTAR, BIRIMMIKTAR) VALUES     (" & SIRANO & ", " & EVRAKNO & ", " & ARACNO & ", '" & ARACKODU & "', " & CALISMAUSULU & ", " & POZISYONNO & ", " & MIKTAR & ", " & BIRIMMIKTAR & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        cmd = Nothing
        con = Nothing
        Return hareketno
    End Function
    Private Function pozisyon_kaydet_yeni(ByVal EVRAKNO As Int64, ByVal SIRANO As Int64, ByVal KOD As String, ByVal ACIKLAMA As String, ByVal POZISYONNO As Int64, ByVal URETIMYERINO As Int64, ByVal URETIMYERIKODU As String, ByVal DEPOKODU As String, ByVal DEPONO As String, ByVal MALIYET As Decimal, ByVal TOPLAMMALIYET As Decimal, ByVal STANDARTSURE As Int64, ByVal SUREHESAPLAMATURU As Int64, ByVal STANDARTBIRIMSURE As Int64, ByVal GIRISTARIHI As DateTime, ByVal CIKISTARIHI As DateTime, ByVal GIRISMIKTARI As Decimal, ByVal CIKISMIKTARI As Decimal) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO TBLUREURETIMPOZ                       (EVRAKNO, SIRANO, KOD, ACIKLAMA, POZISYONNO, URETIMYERINO, URETIMYERIKODU, DEPOKODU, DEPONO, MALIYET, TOPLAMMALIYET,STANDARTSURE, SUREHESAPLAMATURU, STANDARTBIRIMSURE,GIRISTARIHI,CIKISTARIHI,GIRISMIKTARI,CIKISMIKTARI) VALUES     (" & EVRAKNO & ", " & SIRANO & ", '" & KOD & "', '" & ACIKLAMA & "', " & POZISYONNO & ", " & URETIMYERINO & ", '" & URETIMYERIKODU & "', '" & DEPOKODU & "','" & DEPONO & "', " & MALIYET & ", " & TOPLAMMALIYET & " , " & STANDARTSURE & ", " & SUREHESAPLAMATURU & ", " & STANDARTBIRIMSURE & ",'" & GIRISTARIHI & "','" & CIKISTARIHI & "'," & GIRISMIKTARI & "," & CIKISMIKTARI & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        cmd = Nothing
        con = Nothing
        Return hareketno
    End Function
    Private Function pozisyon_no_bul(ByVal EVRAKNO As Int64) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(MAX(SIRANO) + 1,1) AS SIRANO FROM TBLUREURETIMPOZ WHERE (EVRAKNO = " & EVRAKNO & ") GROUP BY EVRAKNO ORDER BY MAX(SIRANO)")
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        cmd = Nothing
        con = Nothing
        Return hareketno
    End Function
    Private Function arac_no_bul(ByVal EVRAKNO As Int64) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(MAX(SIRANO) + 1,1) AS SIRANO FROM TBLUREURETIMARAC WHERE (EVRAKNO = " & EVRAKNO & ") GROUP BY EVRAKNO ORDER BY MAX(SIRANO)")
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        cmd = Nothing
        con = Nothing
        Return hareketno
    End Function
    Private Sub baslik_kaydet_degistir(ByVal evrakno As Int64, ByVal STOKNO As Int64, ByVal STOKKODU As String, ByVal MALINCINSI As String, ByVal OZELKOD As String, ByVal BIRIM As String, ByVal FIYAT As Decimal, ByVal KDV As Int64, ByVal KULLANICI As Int64, ByVal SONERISIMTARIHI As DateTime, ByVal TUTAR As Decimal, ByVal ACIKLAMA As String, ByVal STOKTIPI As Int64, ByVal SATISFIYATI As Decimal, ByVal URETIMGIRISHESAPKODU As String, ByVal MIKTAR As Decimal, ByVal RECETENO As Int64, ByVal STANDARTSURE As Int64, ByVal durum As Int64, ByVal tarih As DateTime, ByVal fisno As String, ByVal pozno As Int64, ByVal termin As DateTime, ByVal uretimbaslamatarihi As DateTime, ByVal uretimbitistarihi As DateTime, ByVal ENTEGRE As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    TBLUREURETIMLIST SET              STOKNO = " & STOKNO & ", STOKKODU = '" & STOKKODU & "' , MALINCINSI = '" & MALINCINSI & "' , OZELKOD = '" & OZELKOD & "' , BIRIM = '" & BIRIM & "' , FIYAT = " & FIYAT & " , KDV = " & KDV & " ,  KULLANICI = " & KULLANICI & ", SONERISIMTARIHI = '" & SONERISIMTARIHI & "' , TUTAR = " & TUTAR & " , ACIKLAMA = '" & ACIKLAMA & "' , STOKTIPI = " & STOKTIPI & " ,   SATISFIYATI = " & SATISFIYATI & " , URETIMGIRISHESAPKODU = '" & URETIMGIRISHESAPKODU & "' , MIKTAR = " & MIKTAR & " , RECETENO = " & RECETENO & " ,  STANDARTSURE = " & STANDARTSURE & ",DURUM =" & durum & ",TARIH ='" & tarih & "',FISNO ='" & fisno & "',POZNO=" & pozno & ",TERMIN ='" & termin & "',URETIMEBASLAMATARIHI ='" & uretimbaslamatarihi & "',URETIMBITISTARIHI ='" & uretimbitistarihi & "',ENTEGRE= " & ENTEGRE & "  WHERE IND = " & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub hareket_kaydet_degistir(ByVal ind As Int64, ByVal EVRAKNO As Int64, ByVal STOKNO As Int64, ByVal STOKKODU As String, ByVal MALINCINSI As String, ByVal MIKTAR As Decimal, ByVal BIRIM As String, ByVal BIRIMMIKTAR As Decimal, ByVal KDV As Int64, ByVal FIYAT As Decimal, ByVal BARCODE As String, ByVal ISLEMTARIHI As DateTime, ByVal SONERISIMTARIHI As DateTime, ByVal KULLANICI As Int64, ByVal ORAN As Int64, ByVal TUR As Int64, ByVal DEPONO As String, ByVal ACIKLAMA As String, ByVal MALIYETTURU As Int64, ByVal MIKTARTURU As Int64, ByVal URETIMCIKISHESAPKODU As String, ByVal YANSITMAHESAPKODU As String, ByVal POZISYONNO As Int64, ByVal CIKISPOZISYONNO As Int64, ByVal FIREORANI As Decimal, ByVal ARACLINENO As Int64, ByVal sDovizCinsi1 As String, ByVal lDovizKuru1 As Decimal, ByVal lDovizMiktari1 As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    TBLUREURETIM SET              EVRAKNO = " & EVRAKNO & ", STOKNO = " & STOKNO & ", STOKKODU = '" & STOKKODU & "', MALINCINSI = '" & MALINCINSI & "', MIKTAR = " & MIKTAR & ", BIRIM = '" & BIRIM & "',  BIRIMMIKTAR = " & BIRIMMIKTAR & ", KDV = " & KDV & ", FIYAT = " & FIYAT & ", BARCODE = '" & BARCODE & "', ISLEMTARIHI = '" & ISLEMTARIHI & "',  SONERISIMTARIHI = '" & SONERISIMTARIHI & "', KULLANICI = " & KULLANICI & ", ORAN = " & ORAN & ", TUR = " & TUR & ", DEPONO ='" & DEPONO & "', ACIKLAMA = '" & ACIKLAMA & "',  MALIYETTURU = " & MALIYETTURU & ", MIKTARTURU = " & MIKTARTURU & ", URETIMCIKISHESAPKODU = '" & URETIMCIKISHESAPKODU & "',  YANSITMAHESAPKODU = '" & YANSITMAHESAPKODU & "', POZISYONNO = " & POZISYONNO & ", CIKISPOZISYONNO = " & CIKISPOZISYONNO & " , FIREORANI = " & FIREORANI & " ,  ARACLINENO = " & ARACLINENO & ",sDovizCinsi1 ='" & sDovizCinsi1 & "',lDovizKuru1 = " & lDovizKuru1 & ",lDovizMiktari1 = " & lDovizMiktari1 & " WHERE IND = " & ind & " AND EVRAKNO =" & EVRAKNO & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub hareket_kaydet_degistir_miktar(ByVal EVRAKNO As Int64, ByVal miktar As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    TBLUREURETIM SET              MIKTAR = BIRIMMIKTAR * " & miktar & " WHERE EVRAKNO = " & EVRAKNO & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub hareket_kaydet_degistir_oran(ByVal EVRAKNO As Int64, ByVal miktar As Decimal, ByVal oran As Decimal, ByVal ind As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    TBLUREURETIM SET              ORAN =" & oran & " WHERE EVRAKNO = " & EVRAKNO & " AND IND =" & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub cikti_ek_kaydet_degistir(ByVal ind As Int64, ByVal EVRAKNO As Int64, ByVal STOKNO As Int64, ByVal MIKTAR As Decimal, ByVal BIRIM As String, ByVal BIRIMMIKTAR As Decimal, ByVal KDV As Decimal, ByVal FIYAT As Decimal, ByVal TUTAR As Decimal, ByVal DEPONO As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    TBLUREURETIMCIKTIEKMALIYET SET              STOKNO = " & STOKNO & ", MIKTAR = " & MIKTAR & ", BIRIM = '" & BIRIM & "', BIRIMMIKTAR = " & BIRIMMIKTAR & ", KDV = " & KDV & ",FIYAT = " & FIYAT & ", TUTAR = " & TUTAR & ", DEPONO = '" & DEPONO & "' WHERE IND = " & ind & " AND EVRAKNO =" & EVRAKNO & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub cikti_degistir(ByVal ind As Int64, ByVal EVRAKNO As Int64, ByVal STOKNO As Int64, ByVal STOKKODU As String, ByVal MALINCINSI As String, ByVal MIKTAR As Decimal, ByVal BIRIM As String, ByVal BIRIMMIKTAR As Decimal, ByVal MIKTAR2 As Decimal, ByVal KDV As Int64, ByVal FIYAT As Decimal, ByVal BARCODE As String, ByVal ISLEMTARIHI As DateTime, ByVal SONERISIMTARIHI As DateTime, ByVal KULLANICI As Int64, ByVal ORAN As Int64, ByVal TUR As Int64, ByVal DEPONO As String, ByVal RECETENO As Int64, ByVal TUTAR As Decimal, ByVal POZISYONNO As Int64, ByVal FIREORANI As Int64, ByVal FIREMIKTARI As Decimal, ByVal KALANMIKTAR As Decimal, ByVal EKMALIYET As Decimal, ByVal EKMALIYETTOPLAM As Decimal, ByVal EKMALIYETSTOKNO As Int64, ByVal EKMALIYETSTOKKODU As String, ByVal EKMALIYETMALINCINSI As String, ByVal EKMALIYETKDV As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    TBLUREURETIMCIKTI SET              EVRAKNO = " & EVRAKNO & ", STOKNO = " & STOKNO & ", STOKKODU = '" & STOKKODU & "', MALINCINSI = '" & MALINCINSI & "', MIKTAR = " & MIKTAR & ", BIRIM = '" & BIRIM & "', BIRIMMIKTAR = " & BIRIMMIKTAR & ",MIKTAR2 = " & MIKTAR2 & ",KDV = " & KDV & " , FIYAT = " & FIYAT & ", BARCODE = '" & BARCODE & "', ISLEMTARIHI = '" & ISLEMTARIHI & "', SONERISIMTARIHI = '" & SONERISIMTARIHI & "', KULLANICI = " & KULLANICI & ", ORAN = " & ORAN & ",  TUR = " & TUR & ", DEPONO = '" & DEPONO & "',RECETENO = " & RECETENO & ", TUTAR = " & TUTAR & ", POZISYONNO = " & POZISYONNO & " , FIREORANI = " & FIREORANI & " , FIREMIKTARI = " & FIREMIKTARI & " , KALANMIKTAR = " & KALANMIKTAR & ",EKMALIYET = " & EKMALIYET & ",EKMALIYETTOPLAM = " & EKMALIYETTOPLAM & ",EKMALIYETSTOKNO = " & EKMALIYETSTOKNO & ",EKMALIYETSTOKKODU = '" & EKMALIYETSTOKKODU & "',EKMALIYETMALINCINSI = '" & EKMALIYETMALINCINSI & "',EKMALIYETKDV = " & EKMALIYETKDV & "  WHERE IND =" & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub cikti_maliyet_degistir(ByVal evrakno As Int64, ByVal miktar As Decimal, ByVal birimmiktar As Decimal, ByVal fiyat As Decimal, ByVal tutar As Decimal, ByVal stokno As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    TBLUREURETIMCIKTI SET             KALANMIKTAR = " & miktar & " ,MIKTAR =" & miktar & ", BIRIMMIKTAR =" & birimmiktar & ", FIYAT =" & fiyat & ", TUTAR =" & tutar & " WHERE     (EVRAKNO = " & evrakno & ") AND (TUR = 0) AND STOKNO = " & stokno & "")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    TBLUREURETIMCIKTI SET           FIYAT =" & fiyat & ", TUTAR =MIKTAR2 * " & fiyat & " WHERE     (EVRAKNO = " & evrakno & ") AND (TUR = 0)")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub pozisyon_degistir(ByVal ind As Int64, ByVal EVRAKNO As Int64, ByVal SIRANO As Int64, ByVal KOD As String, ByVal ACIKLAMA As String, ByVal POZISYONNO As Int64, ByVal URETIMYERINO As Int64, ByVal URETIMYERIKODU As String, ByVal DEPOKODU As String, ByVal DEPONO As String, ByVal MALIYET As Decimal, ByVal TOPLAMMALIYET As Decimal, ByVal STANDARTSURE As Int64, ByVal SUREHESAPLAMATURU As Int64, ByVal STANDARTBIRIMSURE As Int64, ByVal GIRISTARIHI As DateTime, ByVal CIKISTARIHI As DateTime, ByVal GIRISMIKTARI As Decimal, ByVal CIKISMIKTARI As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    TBLUREURETIMPOZ SET              EVRAKNO = " & EVRAKNO & ", SIRANO = " & SIRANO & ", KOD = '" & KOD & "', ACIKLAMA = '" & ACIKLAMA & "', POZISYONNO = " & POZISYONNO & " , URETIMYERINO = " & URETIMYERINO & ", URETIMYERIKODU = '" & URETIMYERIKODU & "', DEPOKODU = '" & DEPOKODU & "', DEPONO ='" & DEPONO & "', MALIYET = " & MALIYET & " , TOPLAMMALIYET = " & TOPLAMMALIYET & " , STANDARTSURE = " & STANDARTSURE & " , SUREHESAPLAMATURU = " & SUREHESAPLAMATURU & " , STANDARTBIRIMSURE = " & STANDARTBIRIMSURE & ",GIRISTARIHI ='" & GIRISTARIHI & "', CIKISTARIHI = '" & CIKISTARIHI & "',GIRISMIKTARI =" & GIRISMIKTARI & ",CIKISMIKTARI =" & CIKISMIKTARI & "  WHERE IND =" & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub pozisyon_degistir_maliyet(ByVal sirano As Int64, ByVal evrakno As Int64, ByVal maliyet As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    TBLUREURETIMPOZ SET              MALIYET =" & maliyet & ", TOPLAMMALIYET =" & maliyet & "  WHERE SIRANO = " & sirano & " AND EVRAKNO = " & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub pozisyon_degistir_maliyet_tumu(ByVal sirano As Int64, ByVal evrakno As Int64, ByVal maliyet As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    TBLUREURETIMPOZ SET              MALIYET =" & maliyet & ", TOPLAMMALIYET =" & maliyet & "  WHERE  EVRAKNO = " & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub arac_degistir(ByVal ind As Int64, ByVal SIRANO As Int64, ByVal EVRAKNO As Int64, ByVal ARACNO As Int64, ByVal ARACKODU As String, ByVal CALISMAUSULU As Int64, ByVal POZISYONNO As Int64, ByVal MIKTAR As Decimal, ByVal BIRIMMIKTAR As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    TBLUREURETIMARAC SET              SIRANO = " & SIRANO & " , EVRAKNO = " & EVRAKNO & " , ARACNO = " & ARACNO & " , ARACKODU = '" & ARACKODU & "' , CALISMAUSULU = " & CALISMAUSULU & " , POZISYONNO = " & POZISYONNO & " , MIKTAR = " & MIKTAR & " , BIRIMMIKTAR = " & BIRIMMIKTAR & "   WHERE IND =" & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub baslik_kaydet_sil(ByVal evrakno As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM    TBLUREURETIMLIST  WHERE IND = " & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub hareket_kaydet_sil(ByVal evrakno As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM TBLUREURETIM  WHERE IND = " & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub cikti_kaydet_sil(ByVal IND As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM TBLUREURETIMCIKTI WHERE IND =" & IND & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub cikti_ek_kaydet_sil(ByVal IND As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM TBLUREURETIMCIKTIEKMALIYET WHERE IND =" & IND & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub arac_kaydet_sil(ByVal IND As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM TBLUREURETIMARAC WHERE IND =" & IND & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub pozisyon_kaydet_sil(ByVal IND As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM TBLUREURETIMPOZ WHERE IND =" & IND & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub belge_iptal(ByVal evrakno As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'Pozisyon Sil
        cmd.CommandText = sorgu_query("DELETE FROM TBLUREURETIMPOZ WHERE EVRAKNO =" & evrakno & "")
        cmd.ExecuteNonQuery()
        'Girde Sil
        cmd.CommandText = sorgu_query("DELETE FROM TBLUREURETIM WHERE EVRAKNO =" & evrakno & "")
        cmd.ExecuteNonQuery()
        'Çýktý Sil
        cmd.CommandText = sorgu_query("DELETE FROM TBLUREURETIMCIKTI WHERE EVRAKNO =" & evrakno & "")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("DELETE FROM TBLUREURETIMCIKTIEKMALIYET WHERE EVRAKNO IN (Select IND from TBLUREURETIMCIKTI WHERE EVRAKNO = " & evrakno & ")")
        cmd.ExecuteNonQuery()
        'Araç Sil
        cmd.CommandText = sorgu_query("DELETE FROM TBLUREURETIMARAC WHERE EVRAKNO =" & evrakno & "")
        cmd.ExecuteNonQuery()
        'Reçete Bilgisi Sil
        cmd.CommandText = sorgu_query("DELETE FROM TBLUREURETIMLIST WHERE IND =" & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub rapor_onizle(ByVal file As String, ByVal statu As Integer)
        Timer1.Enabled = False
        alttoplam_hesapla()
        report_create_uretim(statu, file, 91, "Üretim Ýþ Emri", belgeind, dr_toplam("BIRIMMALIYET"), dr_toplam("KARORANI"), dr_toplam("KAR"), dr_toplam("TOPLAM"), dr_toplam("KDV"), dr_toplam("GENELTOPLAM"), dr_maliyet("MASRAF"), dr_maliyet("MASRAFORANI"), dr_maliyet("HAMMADDE"), dr_maliyet("HAMMADDEORANI"), dr_maliyet("TOPLAM"), dr_maliyet("FIRE"), dr_maliyet("FIREORANI"), dr_maliyet("FIREMIKTARI"))
        Timer1.Enabled = True
    End Sub
    Private Sub raporla(ByVal islem As Integer)
        Dim file As String
        Dim openfiledialog1 As New Windows.Forms.OpenFileDialog
        openfiledialog1.Filter = "Tasarým Dosyalarý (*.fr3) |*.fr3"
        openfiledialog1.InitialDirectory = "C:\FORMLAR\RAPORLAR\URETIM\"
        openfiledialog1.Title = "Tasarým Dosyalarý"
        openfiledialog1.FileName = "Uretim.fr3"
        If openfiledialog1.ShowDialog = DialogResult.OK Then
            file = openfiledialog1.FileName.ToString
            If islem = 0 Then
                rapor_onizle(file, islem)
            ElseIf islem = 1 Then
                rapor_onizle(file, islem)
            ElseIf islem = 2 Then
                rapor_onizle(file, islem)
            End If
        Else
        End If
        openfiledialog1 = Nothing
        file = Nothing
    End Sub
    Public Sub report_create_uretim(ByVal status As Integer, ByVal dosya As String, ByVal izahat As Integer, ByVal belge As String, ByVal belgeind As Int64, ByVal birimmaliyet As Decimal, ByVal karorani As Decimal, ByVal kar As Decimal, ByVal toplam As Decimal, ByVal kdv As Decimal, ByVal geneltoplam As Decimal, ByVal masraf As Decimal, ByVal masraforani As Decimal, ByVal hammadde As Decimal, ByVal hammaddeorani As Decimal, ByVal masraftoplam As Decimal, ByVal fire As Decimal, ByVal fireorani As Decimal, ByVal firemiktari As Decimal)
        Dim s
        Dim stokno = 0
        Dim satir_line = "100"
        Dim evrakno = belgeind
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim qr_baslik As New TfrxADOQuery
            Dim qr_hareket As New TfrxADOQuery
            Dim qr_toplam As New TfrxADOQuery
            Dim qr_iskonto As New TfrxADOQuery
            Dim qr_masraf As New TfrxADOQuery
            Dim qr_kdv As New TfrxADOQuery
            Dim qr_pesininfo As New TfrxADOQuery
            Dim qr_bakiye As New TfrxADOQuery
            Dim qr_pozisyon As New TfrxADOQuery
            Dim qr_arac As New TfrxADOQuery
            Dim qr_cikti As New TfrxADOQuery
            'frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMA", "'" & firma & "'")
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEM", "'" & donem & "'")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("USERNO", "" & userno & "")
            frx.SetVariable("USERNAME", "'" & username & "'")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            frx.SetVariable("EVRAKNO", "" & evrakno & "")
            frx.SetVariable("IZAHAT", "'" & belge.ToString & "'")
            qr_baslik = frx.FindObject("qr_baslik")
            qr_baslik.Query = sSorgu_baslik
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sSorgu_hareket
            'yazideger = belgedll.ygeneltoplam(FormatNumber(geneltoplam, 2))
            qr_toplam = frx.FindObject("qr_geneltoplam")
            qr_toplam.Query = sorgu_query(sorgu_uretim_toplam_string(birimmaliyet, karorani, kar, toplam, kdv, geneltoplam))
            qr_pozisyon = frx.FindObject("qr_pozisyon")
            qr_pozisyon.Query = sSorgu_pozisyon
            qr_arac = frx.FindObject("qr_arac")
            qr_arac.Query = sSorgu_arac
            qr_cikti = frx.FindObject("qr_cikti")
            qr_cikti.Query = sSorgu_Cikti
            'qr_iskonto = frx.FindObject("qr_iskonto")
            'qr_iskonto.Query = sorgu_query(sorgu_iskonto_string(alt1, alt2, alt3, alt4, yuvarlama, kdvisk))
            qr_masraf = frx.FindObject("qr_masraf")
            qr_masraf.Query = sorgu_query(sorgu_uretim_masraf_string(masraf, masraforani, hammadde, hammaddeorani, masraftoplam, fire, fireorani, firemiktari))
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_baslik.DataBase = qr_connection
            qr_hareket.DataBase = qr_connection
            qr_toplam.DataBase = qr_connection
            qr_pozisyon.DataBase = qr_connection
            qr_arac.DataBase = qr_connection
            qr_cikti.DataBase = qr_connection
            qr_masraf.DataBase = qr_connection
            If status = 0 Then
                frx.PrepareReport(True)
                frx.ShowReport()
            ElseIf status = 1 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                'frx.PrintOptions.Copies = 1
                frx.PrintReport()
            ElseIf status = 2 Then
                frx.PrepareReport(True)
                frx.DesignReport()
            End If
            qr_baslik = Nothing
            qr_hareket = Nothing
            qr_toplam = Nothing
            qr_iskonto = Nothing
            qr_masraf = Nothing
            qr_kdv = Nothing
            qr_bakiye = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(4) = "" & status.ToString() & ""
            args(5) = "10"
            args(6) = "FIRMA"
            args(7) = "" & firma.ToString() & ""
            args(8) = "FIRMANO"
            args(9) = "" & firmano.ToString() & ""
            args(10) = "DONEM"
            args(11) = "" & donem.ToString() & ""
            args(12) = "DONEMNO"
            args(13) = "" & donemno.ToString() & ""
            args(14) = "USERNO"
            args(15) = "" & userno & ""
            args(16) = "USERNAME"
            args(17) = "'" & username & "'"
            args(18) = "STOKNO"
            args(19) = "" & stokno & ""
            args(20) = "SATIRLINE"
            args(21) = "'" & satir_line & "'"
            args(22) = "EVRAKNO"
            args(23) = "" & evrakno & ""
            args(24) = "IZAHAT"
            args(25) = "'" & belge.ToString & "'"
            args(2) = "" & sSorgu_baslik & "é" & sSorgu_hareket & "é" & sorgu_query(sorgu_uretim_toplam_string(birimmaliyet, karorani, kar, toplam, kdv, geneltoplam)) & "é" & sSorgu_pozisyon & "é" & sSorgu_arac & "é" & sSorgu_Cikti & "é" & sorgu_query(sorgu_uretim_masraf_string(masraf, masraforani, hammadde, hammaddeorani, masraftoplam, fire, fireorani, firemiktari)) & ""
            args(3) = "qr_baslikéqr_hareketéqr_geneltoplaméqr_pozisyonéqr_aracéqr_ciktiéqr_masraf"
            processYol = args(0)
            For i As Integer = 1 To 25
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
        s = Nothing
        stokno = Nothing
        satir_line = Nothing
        'ado_query = Nothing
        'yenile()
    End Sub
    Private Function sorgu_uretim_baslik_string(ByVal belgeind As Int64) As String
        Dim query = sorgu_query("SELECT RECETE.RECETENO,RECETE.IND,RECETE.DURUM,RECETE.TARIH,RECETE.FISNO,RECETE.POZNO,RECETE.TERMIN,RECETE.URETIMEBASLAMATARIHI,RECETE.URETIMBITISTARIHI, RECETE.STOKNO, RECETE.KULLANICI, RECETE.SONERISIMTARIHI, RECETE.TUTAR, RECETE.STOKKODU, RECETE.MALINCINSI, RECETE.BIRIM, RECETE.FIYAT, RECETE.KDV, RECETE.OZELKOD, RECETE.ACIKLAMA, RECETE.STOKTIPI, RECETE.MIKTAR, RECETE.SATISFIYATI, RECETE.URETIMGIRISHESAPKODU, RECETE.STANDARTSURE, STOK.RESIM, STOK.KOD1, STOK.KOD2, STOK.KOD3, STOK.KOD4, STOK.KOD5, STOK.KOD6, STOK.KOD7, STOK.KOD8, STOK.KOD9, STOK.KOD10 FROM TBLUREURETIMLIST RECETE LEFT OUTER JOIN TBLSTOKLAR STOK ON STOK.IND = RECETE.STOKNO WHERE (RECETE.IND = " & belgeind & ") ORDER BY RECETE.IND")
        Return query
        query = Nothing
    End Function
    Private Function sorgu_uretim_hareket_string(ByVal belgeind As Int64) As String
        Dim query = sorgu_query("SELECT RECETE.IND, RECETE.EVRAKNO, RECETE.STOKNO, RECETE.STOKKODU, RECETE.MALINCINSI, CAST(RECETE.MIKTAR AS FLOAT) AS MIKTAR, RECETE.BIRIM, RECETE.BIRIMMIKTAR, CAST(RECETE.KDV AS FLOAT) AS KDV, RECETE.FIYAT, RECETE.FIYAT * RECETE.MIKTAR AS TUTAR, RECETE.BARCODE, RECETE.ISLEMTARIHI, RECETE.SONERISIMTARIHI, RECETE.KULLANICI, RECETE.ORAN, RECETE.TUR, RECETE.DETAY, RECETE.DEPONO, RECETE.MALIYETTURU, RECETE.ACIKLAMA, RECETE.MIKTARTURU, RECETE.URETIMCIKISHESAPKODU, RECETE.YANSITMAHESAPKODU, RECETE.POZISYONNO, RECETE.CIKISPOZISYONNO, CAST(RECETE.FIREORANI AS FLOAT) AS FIREORANI, RECETE.ARACLINENO, DEPO.DEPOKODU, STOK.ENVANTER, POZISYON.KOD AS POZISYONKODU, POZISYONCIKIS.KOD AS POZISYONCIKISKODU FROM TBLUREURETIM RECETE INNER JOIN TBLUREURETIMPOZ POZISYON ON RECETE.EVRAKNO = POZISYON.EVRAKNO AND RECETE.POZISYONNO = POZISYON.SIRANO INNER JOIN TBLUREURETIMPOZ POZISYONCIKIS ON RECETE.CIKISPOZISYONNO = POZISYONCIKIS.SIRANO AND RECETE.EVRAKNO = POZISYONCIKIS.EVRAKNO LEFT OUTER JOIN TBLDEPOLAR DEPO ON DEPO.IND = RECETE.DEPONO LEFT OUTER JOIN TBLSTOKENVANTER STOK ON STOK.STOKNO = RECETE.STOKNO AND STOK.DEPO = RECETE.DEPONO WHERE (RECETE.EVRAKNO = " & belgeind & ") ORDER BY RECETE.IND")
        Return query
        query = Nothing
    End Function
    Private Function sorgu_uretim_pozisyon_string(ByVal belgeind As Int64) As String
        Dim query = sorgu_query("SELECT IND, SIRANO, KOD, ACIKLAMA, EVRAKNO, POZISYONNO, URETIMYERINO, URETIMYERIKODU, DEPONO, DEPOKODU, MALIYET, TOPLAMMALIYET, STANDARTSURE, STANDARTBIRIMSURE, SUREHESAPLAMATURU,GIRISTARIHI,CIKISTARIHI,GIRISMIKTARI,CIKISMIKTARI FROM TBLUREURETIMPOZ POZ WHERE (EVRAKNO = " & belgeind & ") ORDER BY SIRANO")
        Return query
        query = Nothing
    End Function
    Private Function sorgu_uretim_arac_string(ByVal belgeind As Int64) As String
        Dim query = sorgu_query("SELECT ARAC.IND, ARAC.EVRAKNO, ARAC.ARACNO, ARAC.ARACKODU, ARAC.CALISMAUSULU, ARAC.POZISYONNO, CAST(ARAC.MIKTAR AS FLOAT) AS MIKTAR, ARAC.SIRANO, CAST(ARAC.BIRIMMIKTAR AS FLOAT) AS BIRIMMIKTAR, POZISYON.KOD AS POZISYONKODU FROM TBLUREURETIMARAC ARAC INNER JOIN TBLUREURETIMPOZ POZISYON ON ARAC.EVRAKNO = POZISYON.EVRAKNO AND ARAC.POZISYONNO = POZISYON.SIRANO WHERE (ARAC.EVRAKNO = " & belgeind & ") ORDER BY ARAC.SIRANO")
        Return query
        query = Nothing
    End Function
    Private Function sorgu_uretim_cikti_string(ByVal belgeind As Int64) As String
        Dim query = sorgu_query("SELECT CIKTI.*, POZISYON.KOD AS POZISYONKODU FROM TBLUREURETIMCIKTI CIKTI INNER JOIN TBLUREURETIMPOZ POZISYON ON CIKTI.EVRAKNO = POZISYON.EVRAKNO AND CIKTI.POZISYONNO = POZISYON.SIRANO WHERE (CIKTI.EVRAKNO = " & belgeind & ") ORDER BY CIKTI.IND")
        Return query
        query = Nothing
    End Function
    Private Function sorgu_uretim_toplam_string(ByVal birimmaliyet As Decimal, ByVal karorani As Decimal, ByVal kar As Decimal, ByVal toplam As Decimal, ByVal kdv As Decimal, ByVal geneltoplam As Decimal) As String
        Dim query
        query = "SELECT " & birimmaliyet & " AS BIRIMMALIYET," & karorani & " AS KARORANI," & kar & " AS KAR," & toplam & " AS TOPLAM," & kdv & " AS TOPLAMKDV , " & geneltoplam & " AS GENELTOPLAM  "
        Return query
        query = Nothing
    End Function
    Private Function sorgu_uretim_masraf_string(ByVal masraf As Decimal, ByVal masraforani As Decimal, ByVal hammadde As Decimal, ByVal hammaddeorani As Decimal, ByVal masraftoplam As Decimal, ByVal fire As Decimal, ByVal fireorani As Decimal, ByVal firemiktari As Decimal) As String
        Dim query
        query = "SELECT " & masraf & " AS MASRAFTOPLAMI," & masraforani & " AS MASRAFORANI," & hammadde & " AS HAMMADDETOPLAMI," & hammaddeorani & " AS HAMMADDEORANI, " & masraftoplam & " AS TOPLAMMALIYET,'" & fire & "' AS FIRE,'" & fireorani & "' AS FIREORANI,'" & firemiktari & "' AS FIREMIKTARI "
        Return query
        query = Nothing
    End Function
    Private Sub dataload_baslik()
        ds_baslik.Tables(0).Clear()
        ds_baslik = sorgu_baslik("")
        VGrid_baslik.DataSource = ds_baslik
        VGrid_baslik.DataMember = "BASLIK"
        VGrid_baslik.Refresh()
        VGrid_aciklama.DataMember = Nothing
        VGrid_aciklama.DataSource = ds_baslik
        VGrid_aciklama.DataMember = "BASLIK"
        VGrid_aciklama.Refresh()
    End Sub
    Private Sub dataload_pozisyon()
        ds_pozisyon.Clear()
        ds_pozisyon.Dispose()
        ds_pozisyon = sorgu_pozisyon("")
        GridControl2.DataSource = ds_pozisyon.Tables(0)
        GridControl2.DataMember = Nothing
        GridControl2.RefreshDataSource()
        GridControl2.Refresh()
        GridControl2.Select()
    End Sub
    Private Sub dataload_pozisyon_maliyet()
        ds_pozisyon_maliyet = sorgu_pozisyon_maliyet("")
        pozisyon_degistir_maliyet_tumu(dr("POZISYONNO"), belgeind, 0)
        For Each dr In ds_pozisyon_maliyet.Tables(0).Rows
            pozisyon_degistir_maliyet(dr("POZISYONNO"), belgeind, dr("TUTAR"))
        Next
        dataload_pozisyon()
    End Sub
    Private Sub dataload_hareket()
        ds_hareket = sorgu_hareket("")
        GridControl1.DataSource = ds_hareket.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.RefreshDataSource()
        GridControl1.Refresh()
        GridControl1.Select()
    End Sub
    Private Sub dataload_araclar()
        ds_arac = sorgu_araclar("")
        GridControl4.DataSource = ds_arac.Tables(0)
        GridControl4.DataMember = Nothing
        GridControl4.RefreshDataSource()
        GridControl4.Refresh()
        GridControl4.Select()
    End Sub
    Private Sub dataload_cikti()
        ds_cikti = sorgu_cikti("")
        GridControl3.DataSource = ds_cikti.Tables(0)
        GridControl3.DataMember = Nothing
        GridControl3.RefreshDataSource()
        GridControl3.Refresh()
        GridControl3.Select()
    End Sub
    Private Sub dataload_cikti_ek(ByVal EVRAKNO As Int64, ByVal sStokKodu As String, ByVal sMalinCinsi As String)
        lbl_CiktiIND.Text = EVRAKNO
        lbl_CiktiStokKodu.Text = sStokKodu
        lbl_CiktiMalinCinsi.Text = sMalinCinsi
        ds_cikti_ek = sorgu_cikti_ek(EVRAKNO)
        GridControl5.DataSource = ds_cikti_ek.Tables(0)
        GridControl5.DataMember = Nothing
        GridControl5.RefreshDataSource()
        GridControl5.Refresh()
        GridControl5.Select()
    End Sub
    Private Sub dataload_depo()
        'sec_depo.DataSource = sorgu(sorgu_query("SELECT * FROM TBLDEPOLAR")).Tables(0) 'DataSet2.Tables(0)
        sec_depo_girdi.DataSource = sorgu(sorgu_query("SELECT sDepo,sAciklama FROM tbDepo")).Tables(0) 'DataSet2.Tables(0)
        sec_depo_pozisyon.DataSource = sorgu(sorgu_query("SELECT sDepo,sAciklama FROM tbDepo")).Tables(0) 'DataSet2.Tables(0)
        sec_depo_ek.DataSource = sorgu(sorgu_query("SELECT sDepo,sAciklama FROM tbDepo")).Tables(0)
        sec_sDepo_cikti.DataSource = sorgu(sorgu_query("SELECT sDepo,sAciklama FROM tbDepo")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub dataload_pozisyon_girdi()
        'sec_depo.DataSource = sorgu(sorgu_query("SELECT * FROM TBLDEPOLAR")).Tables(0) 'DataSet2.Tables(0)
        sec_pozisyon_girdi.DataSource = sorgu(sorgu_query("SELECT     SIRANO AS IND,KOD, ACIKLAMA FROM         TBLUREURETIMPOZ WHERE EVRAKNO =" & belgeind & " ORDER BY SIRANO")).Tables(0) 'DataSet2.Tables(0)
        sec_pozisyon_cikti.DataSource = sorgu(sorgu_query("SELECT     SIRANO AS IND,KOD, ACIKLAMA FROM         TBLUREURETIMPOZ WHERE EVRAKNO =" & belgeind & " ORDER BY SIRANO")).Tables(0) 'DataSet2.Tables(0)
        sec_pozisyon_arac.DataSource = sorgu(sorgu_query("SELECT     SIRANO AS IND,KOD, ACIKLAMA FROM         TBLUREURETIMPOZ WHERE EVRAKNO =" & belgeind & " ORDER BY SIRANO")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Function sorgu(ByVal query As String, Optional ByVal sTable As String = "TABLE1", Optional ByVal sConnection As String = "") As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, sTable)
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_baslik(ByVal kriter As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT RECETE.RECETENO,RECETE.IND,RECETE.DURUM,RECETE.TARIH,RECETE.FISNO,RECETE.POZNO,RECETE.TERMIN,RECETE.URETIMEBASLAMATARIHI,RECETE.URETIMBITISTARIHI, RECETE.ENTEGRE,RECETE.STOKNO, RECETE.KULLANICI, RECETE.SONERISIMTARIHI, RECETE.TUTAR, RECETE.STOKKODU, RECETE.MALINCINSI, RECETE.BIRIM, RECETE.FIYAT, RECETE.KDV, RECETE.OZELKOD, RECETE.ACIKLAMA, RECETE.STOKTIPI, RECETE.MIKTAR, RECETE.SATISFIYATI, RECETE.URETIMGIRISHESAPKODU, RECETE.STANDARTSURE FROM TBLUREURETIMLIST RECETE LEFT OUTER JOIN tbStok STOK ON STOK.nStokID = RECETE.STOKNO WHERE (RECETE.IND = " & belgeind & ")")
        sSorgu_baslik = cmd.CommandText
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
    Private Function sorgu_pozisyon(ByVal kriter As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT IND, SIRANO, KOD, ACIKLAMA, EVRAKNO, POZISYONNO, URETIMYERINO, URETIMYERIKODU, DEPONO, DEPOKODU, MALIYET, TOPLAMMALIYET, STANDARTSURE, STANDARTBIRIMSURE, SUREHESAPLAMATURU,GIRISTARIHI,CIKISTARIHI,GIRISMIKTARI,CIKISMIKTARI FROM TBLUREURETIMPOZ POZ WHERE (EVRAKNO = " & belgeind & ") ORDER BY SIRANO")
        sSorgu_pozisyon = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "POZISYON")
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_pozisyon_maliyet(ByVal kriter As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(MIKTAR * FIYAT),0) AS TUTAR, POZISYONNO FROM TBLUREURETIM WHERE (EVRAKNO = " & belgeind & ") GROUP BY POZISYONNO ORDER BY POZISYONNO")
        sSorgu_masraf = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "POZISYON")
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_hareket(ByVal kriter As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT RECETE.IND, RECETE.EVRAKNO, RECETE.STOKNO, RECETE.STOKKODU, RECETE.MALINCINSI, cast(RECETE.MIKTAR as FLOAT) AS MIKTAR, RECETE.BIRIM, RECETE.BIRIMMIKTAR, cast(RECETE.KDV as FLOAT) AS KDV, RECETE.FIYAT,RECETE.FIYAT* RECETE.MIKTAR AS TUTAR, RECETE.BARCODE, RECETE.ISLEMTARIHI, RECETE.SONERISIMTARIHI, RECETE.KULLANICI, RECETE.ORAN, RECETE.TUR, RECETE.DETAY, RECETE.DEPONO, RECETE.MALIYETTURU, RECETE.ACIKLAMA, RECETE.MIKTARTURU, RECETE.URETIMCIKISHESAPKODU, RECETE.YANSITMAHESAPKODU, RECETE.POZISYONNO, RECETE.CIKISPOZISYONNO, cast(ISNULL(RECETE.FIREORANI,0) as FLOAT) AS FIREORANI,RECETE.ARACLINENO, DEPO.sDepo DEPOKODU FROM TBLUREURETIM RECETE LEFT OUTER JOIN tbDepo DEPO ON DEPO.sDepo = RECETE.DEPONO WHERE (RECETE.EVRAKNO = " & belgeind & ")")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT RECETE.IND, RECETE.EVRAKNO, RECETE.STOKNO, RECETE.STOKKODU, RECETE.MALINCINSI, CAST(RECETE.MIKTAR AS FLOAT) AS MIKTAR, RECETE.BIRIM, RECETE.BIRIMMIKTAR, CAST(RECETE.KDV AS FLOAT) AS KDV, RECETE.FIYAT, RECETE.FIYAT * RECETE.MIKTAR AS TUTAR, RECETE.BARCODE, RECETE.ISLEMTARIHI, RECETE.SONERISIMTARIHI, RECETE.KULLANICI, RECETE.ORAN, RECETE.TUR, RECETE.DETAY, RECETE.DEPONO, RECETE.MALIYETTURU, RECETE.ACIKLAMA, RECETE.MIKTARTURU, RECETE.URETIMCIKISHESAPKODU, RECETE.YANSITMAHESAPKODU, RECETE.POZISYONNO, RECETE.CIKISPOZISYONNO, CAST(ISNULL(RECETE.FIREORANI, 0) AS FLOAT) AS FIREORANI, RECETE.ARACLINENO, DEPO.sDepo AS DEPOKODU, GIRISPOZISYON.KOD AS POZISYONKODU, CIKISPOZISYON.KOD AS CIKISPOZISYONKODU,RECETE.sDovizCinsi1,RECETE.lDovizKuru1,RECETE.lDovizMiktari1 FROM TBLUREURETIM RECETE LEFT OUTER JOIN TBLUREURETIMPOZ GIRISPOZISYON ON RECETE.EVRAKNO = GIRISPOZISYON.EVRAKNO AND RECETE.POZISYONNO = GIRISPOZISYON.SIRANO LEFT OUTER JOIN TBLUREURETIMPOZ CIKISPOZISYON ON RECETE.EVRAKNO = CIKISPOZISYON.EVRAKNO AND RECETE.CIKISPOZISYONNO = CIKISPOZISYON.SIRANO LEFT OUTER JOIN tbDepo DEPO ON DEPO.sDepo = RECETE.DEPONO WHERE (RECETE.EVRAKNO = " & belgeind & ")")
        sSorgu_hareket = cmd.CommandText
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
    Private Function sorgu_araclar(ByVal kriter As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT IND, EVRAKNO, ARACNO, ARACKODU, CALISMAUSULU, POZISYONNO, cast(MIKTAR as FLOAT) AS MIKTAR, SIRANO, cast(BIRIMMIKTAR as FLOAT) AS BIRIMMIKTAR FROM TBLUREURETIMARAC WHERE (EVRAKNO = " & belgeind & ")")
        sSorgu_arac = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "ARAC")
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_cikti(ByVal kriter As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TBLUREURETIMCIKTI.*, (SELECT     ISNULL(SUM(TUTAR),0) AS EKMALIYETTOPLAM FROM         TBLUREURETIMCIKTIEKMALIYET WHERE     (EVRAKNO = TBLUREURETIMCIKTI.IND)) AS EKMALIYETTUTAR,TBLUREURETIMPOZ.KOD AS POZISYONKODU FROM TBLUREURETIMCIKTI INNER JOIN TBLUREURETIMPOZ ON TBLUREURETIMCIKTI.EVRAKNO = TBLUREURETIMPOZ.EVRAKNO  WHERE (TBLUREURETIMCIKTI.EVRAKNO = " & belgeind & ")")
        sSorgu_Cikti = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "CIKTI")
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_cikti_ek(ByVal kriter As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TBLEK.*, tbStok.sKodu AS STOKKODU, tbStok.sAciklama AS MALINCINSI FROM TBLUREURETIMCIKTIEKMALIYET TBLEK INNER JOIN tbStok ON TBLEK.STOKNO = tbStok.nStokID WHERE (TBLEK.EVRAKNO = " & kriter & ")")
        sSorgu_Cikti_EK = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "CIKTIEK")
        con.Close()
        Return DS
    End Function
    Private Sub girdi_turleri()
        Dim dr1 As DataRow = ds_girdi_tur.Tables(0).NewRow
        dr1("IND") = 0
        dr1("ACIKLAMA") = "Hammadde"
        ds_girdi_tur.Tables(0).Rows.Add(dr1)
        dr1 = ds_girdi_tur.Tables(0).NewRow
        dr1("IND") = 1
        dr1("ACIKLAMA") = "Maliyet"
        ds_girdi_tur.Tables(0).Rows.Add(dr1)
        dr1 = Nothing
    End Sub
    Private Sub cikti_turleri()
        Dim dr1 As DataRow = ds_cikti_tur.Tables(0).NewRow
        dr1("IND") = 0
        dr1("ACIKLAMA") = "Ana Mamül"
        ds_cikti_tur.Tables(0).Rows.Add(dr1)
        dr1 = ds_cikti_tur.Tables(0).NewRow
        dr1("IND") = 1
        dr1("ACIKLAMA") = "Kalite"
        ds_cikti_tur.Tables(0).Rows.Add(dr1)
        dr1 = ds_cikti_tur.Tables(0).NewRow
        dr1("IND") = 2
        dr1("ACIKLAMA") = "Yan Mamül"
        ds_cikti_tur.Tables(0).Rows.Add(dr1)
        dr1 = ds_cikti_tur.Tables(0).NewRow
        dr1("IND") = 3
        dr1("ACIKLAMA") = "Fire"
        ds_cikti_tur.Tables(0).Rows.Add(dr1)
        dr1 = ds_cikti_tur.Tables(0).NewRow
        dr1("IND") = 4
        dr1("ACIKLAMA") = "Renk/Beden"
        ds_cikti_tur.Tables(0).Rows.Add(dr1)
        dr1 = Nothing
    End Sub
    Private Sub dataload_alttoplam()
        Dim dr1 As DataRow = ds_toplam.Tables(0).NewRow
        dr1("BIRIMMALIYET") = 0
        dr1("KARORANI") = 0
        dr1("KAR") = 0
        dr1("TOPLAM") = 0
        dr1("KDV") = 0
        dr1("GENELTOPLAM") = 0
        ds_toplam.Tables(0).Rows.Add(dr1)
        dr1 = Nothing
    End Sub
    Private Sub dataload_maliyet()
        Dim dr1 As DataRow = ds_maliyet.Tables(0).NewRow
        dr1("MASRAF") = 0
        dr1("MASRAFORANI") = 0
        dr1("HAMMADDE") = 0
        dr1("HAMMADDEORANI") = 0
        dr1("TOPLAM") = 0
        dr1("FIRE") = 0
        dr1("FIREMIKTARI") = 0
        dr1("FIREORANI") = 0
        ds_maliyet.Tables(0).Rows.Add(dr1)
    End Sub
#End Region
#Region " Reçete Bilgileri "
    ' Reçete sorgularý
    Private Function sorgu_recete_baslik(ByVal receteno As Int64) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT RECETE.IND, RECETE.STOKNO, RECETE.KULLANICI, RECETE.SONERISIMTARIHI, RECETE.TUTAR, RECETE.STOKKODU, RECETE.MALINCINSI, RECETE.BIRIM, RECETE.FIYAT, RECETE.KDV, RECETE.OZELKOD, RECETE.ACIKLAMA, RECETE.STOKTIPI, RECETE.MIKTAR, RECETE.SATISFIYATI, RECETE.URETIMGIRISHESAPKODU, RECETE.STANDARTSURE FROM TBLURERECETELIST RECETE LEFT OUTER JOIN tbStok STOK ON STOK.nStokID = RECETE.STOKNO WHERE (RECETE.IND = " & receteno & ")")
        sSorgu_baslik = cmd.CommandText
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
    Private Function sorgu_recete_pozisyon(ByVal receteno As Int64) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT IND, SIRANO, KOD, ACIKLAMA, EVRAKNO, POZISYONNO, URETIMYERINO, URETIMYERIKODU, DEPONO, DEPOKODU, MALIYET, TOPLAMMALIYET, STANDARTSURE, STANDARTBIRIMSURE, SUREHESAPLAMATURU FROM TBLURERECETEPOZ POZ WHERE (EVRAKNO = " & receteno & ") ORDER BY SIRANO")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "POZISYON")
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_recete_hareket(ByVal receteno As Int64) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT RECETE.IND, RECETE.EVRAKNO, RECETE.STOKNO, RECETE.STOKKODU, RECETE.MALINCINSI, CAST(RECETE.MIKTAR AS FLOAT) AS MIKTAR, RECETE.BIRIM, RECETE.BIRIMMIKTAR, CAST(RECETE.KDV AS FLOAT) AS KDV, RECETE.FIYAT, RECETE.FIYAT * RECETE.MIKTAR AS TUTAR, RECETE.BARCODE, RECETE.ISLEMTARIHI, RECETE.SONERISIMTARIHI, RECETE.KULLANICI, RECETE.ORAN, RECETE.TUR, RECETE.DETAY, RECETE.DEPONO, RECETE.MALIYETTURU, RECETE.ACIKLAMA, RECETE.MIKTARTURU, RECETE.URETIMCIKISHESAPKODU, RECETE.YANSITMAHESAPKODU, RECETE.POZISYONNO, RECETE.CIKISPOZISYONNO, CAST(RECETE.FIREORANI AS FLOAT) AS FIREORANI, ISNULL(RECETE.ARACLINENO, 0) AS ARACLINENO, DEPO.sDepo AS DEPOKODU,RECETE.sDovizCinsi1,RECETE.lDovizKuru1,RECETE.lDovizMiktari1 FROM TBLURERECETE RECETE LEFT OUTER JOIN tbDepo DEPO ON DEPO.sDepo = RECETE.DEPONO WHERE (RECETE.EVRAKNO = " & receteno & ")")
        sSorgu_hareket = cmd.CommandText
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
    Private Function sorgu_recete_araclar(ByVal receteno As Int64) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT IND, EVRAKNO, ARACNO, ARACKODU, CALISMAUSULU, POZISYONNO, cast(MIKTAR as FLOAT) AS MIKTAR, SIRANO, cast(BIRIMMIKTAR as FLOAT) AS BIRIMMIKTAR FROM TBLURERECETEARAC WHERE (EVRAKNO = " & receteno & ")")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "ARAC")
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_recete_cikti(ByVal receteno As Int64) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM TBLURERECETECIKTI WHERE EVRAKNO = " & receteno & "")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "CIKTI")
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_recete_cikti_ek(ByVal evrakno As Int64) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM TBLURERECETECIKTIEKMALIYET WHERE EVRAKNO = " & evrakno & "")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "CIKTI")
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
#End Region
#Region " Gorunum "
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\ISEMRI\HAREKET\" & Me.Name.ToString & "")
        GridView3.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\ISEMRI\POZISYON\" & Me.Name.ToString & "")
        GridView5.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\ISEMRI\CIKTI\" & Me.Name.ToString & "")
        GridView6.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\ISEMRI\ARAC\" & Me.Name.ToString & "")
        VGrid_baslik.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\ISEMRI\BASLIK\" & Me.Name.ToString & "")
        VGrid_maliyet.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\ISEMRI\MALIYET\" & Me.Name.ToString & "")
        VGrid_geneltoplam.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\ISEMRI\GENELTOPLAM\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\ISEMRI\HAREKET\" & Me.Name.ToString & "")
        GridView3.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\ISEMRI\POZISYON\" & Me.Name.ToString & "")
        GridView5.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\ISEMRI\CIKTI\" & Me.Name.ToString & "")
        GridView6.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\ISEMRI\ARAC\" & Me.Name.ToString & "")
        'VGrid_baslik.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\ISEMRI\BASLIK\" & Me.Name.ToString & "")
        'VGrid_maliyet.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\ISEMRI\MALIYET\" & Me.Name.ToString & "")
        'VGrid_geneltoplam.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\ISEMRI\GENELTOPLAM\" & Me.Name.ToString & "")
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
    End Sub
#End Region
    Private Sub dataload_calismausulu()
        Dim dr1 As DataRow = ds_calismausulu.Tables(0).NewRow
        dr1("IND") = 0
        dr1("ACIKLAMA") = "Parça Baþý"
        ds_calismausulu.Tables(0).Rows.Add(dr1)
        dr1 = ds_calismausulu.Tables(0).NewRow
        dr1("IND") = 1
        dr1("ACIKLAMA") = "Saatlik"
        ds_calismausulu.Tables(0).Rows.Add(dr1)
        dr1 = ds_calismausulu.Tables(0).NewRow
        dr1("IND") = 2
        dr1("ACIKLAMA") = "Diðer"
        ds_calismausulu.Tables(0).Rows.Add(dr1)
        dr1 = Nothing
    End Sub
    Private Sub alttoplam_hesapla()
        'MASRAF HESAPLA
        toplamhammadde = 0
        toplammasraf = 0
        hammaddeorani = 0
        masraforani = 0
        masraftoplami = 0
        toplamfire = 0
        firemiktari = 0
        fireorani = 0
        'TOPLAM HESAPLA
        birimmaliyet = 0
        karorani = 0
        kar = 0
        toplam = 0
        kdv = 0
        geneltoplam = 0
        Dim miktar As Decimal = 0
        For Each dr In ds_hareket.Tables(0).Rows
            masraftoplami = masraftoplami + (dr("MIKTAR") * dr("FIYAT"))
            If dr("TUR") = 0 Then
                toplamhammadde = toplamhammadde + (dr("MIKTAR") * dr("FIYAT"))
            ElseIf dr("TUR") = 1 Then
                toplammasraf = toplammasraf + (dr("MIKTAR") * dr("FIYAT"))
            Else
            End If
            Try
                If dr("FIREORANI").ToString <> 0 Then
                    firemiktari = firemiktari + dr("FIREORANI")
                    toplamfire = toplamfire + (dr("FIREORANI") * dr("FIYAT"))
                    fireorani = 0
                End If
            Catch ex As Exception
            End Try
            miktar = miktar + dr("MIKTAR")
            kdv = kdv + (dr("TUTAR") * (dr("KDV") / 100))
        Next
        'Maliyet Bilgileri
        If masraftoplami = 0 Then
            masraftoplami = 0.001
        End If
        masraftoplami = masraftoplami + toplamfire
        dr_maliyet("MASRAF") = toplammasraf
        dr_maliyet("MASRAFORANI") = (toplammasraf / masraftoplami) * 100
        dr_maliyet("HAMMADDE") = toplamhammadde
        dr_maliyet("HAMMADDEORANI") = (toplamhammadde / masraftoplami) * 100
        dr_maliyet("TOPLAM") = masraftoplami
        dr_maliyet("FIRE") = toplamfire
        dr_maliyet("FIREMIKTARI") = firemiktari
        Try
            dr_maliyet("FIREORANI") = (firemiktari / miktar) * 100
        Catch ex As Exception
            dr_maliyet("FIREORANI") = 0
        End Try
        'Toplam Bilgileri
        dr_toplam("TOPLAM") = masraftoplami
        dr_toplam("KDV") = kdv
        dr_toplam("BIRIMMALIYET") = (masraftoplami + kdv) / dr_baslik("MIKTAR")
        birimmaliyet = dr_toplam("BIRIMMALIYET") '* ((dr_baslik("KDV") + 100) / 100)
        dr_toplam("KARORANI") = ((dr_baslik("SATISFIYATI") / ((dr_baslik("KDV") + 100) / 100) - birimmaliyet) / birimmaliyet) * 100
        dr_toplam("KAR") = ((dr_baslik("SATISFIYATI") / ((dr_baslik("KDV") + 100) / 100)) - birimmaliyet)
        'dr_toplam("KARORANI") = ((dr_baslik("SATISFIYATI") - birimmaliyet) / birimmaliyet) * 100
        'dr_toplam("KAR") = (dr_baslik("SATISFIYATI") - birimmaliyet)
        dr_toplam("GENELTOPLAM") = masraftoplami + kdv
        'dr("ORAN1") = ((dr("SATISFIYATI1") - dr("MALIYET")) / dr("MALIYET")) * 100
        Label1.Text = "Satýr : " & FormatNumber(GridView1.FocusedRowHandle + 1, 0) & " / " & GridView1.RowCount & " ,Toplam Miktar : [ " & Microsoft.VisualBasic.Format(miktar, "#,0.###") & " ]"
    End Sub
    Private Sub oran_dagilim()
        Timer1.Enabled = False
        alttoplam_hesapla()
        For Each dr In ds_hareket.Tables(0).Rows
            If dr("TUR") = 0 Then
                Try
                    dr("ORAN") = (dr("TUTAR") / dr_maliyet("HAMMADDE")) * 100
                Catch ex As Exception
                    dr("ORAN") = 0
                End Try
            ElseIf dr("TUR") = 1 Then
                Try
                    dr("ORAN") = (dr("TUTAR") / dr_maliyet("MASRAF")) * 100
                Catch ex As Exception
                    dr("ORAN") = 0
                End Try
            End If
            hareket_kaydet_degistir_oran(belgeind, dr("MIKTAR"), dr("ORAN"), dr("IND"))
        Next
        Timer1.Enabled = True
    End Sub
    Private Sub girdi_tutar_hesapla(Optional ByVal nSatir As Int64 = -1)
        If GridView1.RowCount > 0 Then
            If nSatir = -1 Then
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Else
                dr = GridView1.GetDataRow(nSatir)
            End If
            dr.BeginEdit()
            Dim lMiktar As Decimal = 1
            If dr("MIKTAR") = 0 Then
                dr("MIKTAR") = 1
            End If
            lMiktar = dr("MIKTAR")
            If GridView1.FocusedColumn.Name.ToString = colHTUTAR.Name.ToString() Then
                dr("FIYAT") = dr("TUTAR") / dr("MIKTAR")
            Else
                dr("TUTAR") = dr("MIKTAR") * dr("FIYAT")
            End If
            dr("TUTAR") = dr("MIKTAR") * dr("FIYAT")
            If GridView1.FocusedColumn.Name.ToString = collDovizMiktari1.Name.ToString Or GridView1.FocusedColumn.Name.ToString = collDovizKuru1.Name.ToString Then
                If dr("lDovizKuru1") <> 0 And dr("sDovizCinsi1") <> "" Then
                    dr("FIYAT") = (dr("lDovizMiktari1") / lMiktar) * dr("lDovizKuru1")
                    dr("TUTAR") = dr("FIYAT") * lMiktar
                Else
                    dr("lDovizKuru1") = 0
                    dr("lDovizMiktari1") = 0
                End If
            End If
            If dr("lDovizKuru1") <> 0 And dr("sDovizCinsi1") <> "" Then
                dr("lDovizMiktari1") = dr("TUTAR") / dr("lDovizKuru1")
            Else
                dr("lDovizKuru1") = 0
                dr("lDovizMiktari1") = 0
            End If
            dr.EndEdit()
            hareket_kaydet_degistir(dr("IND"), belgeind, dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("MIKTAR"), dr("BIRIM"), dr("MIKTAR") / dr_baslik("MIKTAR"), dr("KDV"), dr("FIYAT"), dr("BARCODE"), Now, Now, dr("KULLANICI"), 0, dr("TUR"), dr("DEPONO"), dr("ACIKLAMA"), dr("MALIYETTURU"), dr("MIKTARTURU"), dr("URETIMCIKISHESAPKODU"), dr("YANSITMAHESAPKODU"), dr("POZISYONNO"), dr("CIKISPOZISYONNO"), dr("FIREORANI"), 0, dr("sDovizCinsi1"), dr("lDovizKuru1"), dr("lDovizMiktari1"))
            Timer1.Enabled = False
            alttoplam_hesapla()
            cikti_maliyet_degistir(belgeind, dr_baslik("MIKTAR"), 1, dr_toplam("TOPLAM") / dr_baslik("MIKTAR"), dr_toplam("TOPLAM"), dr_baslik("STOKNO"))
            Timer1.Enabled = True
            dataload_cikti()
            oran_dagilim()
            dataload_pozisyon_maliyet()
            GridControl1.Focus()
            GridControl1.Select()
        End If
    End Sub
    Private Sub girdi_fiyat_hesapla()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        dr.BeginEdit()
        dr("FIYAT") = dr("TUTAR") / dr("MIKTAR")
        'If dr_baslik("KDV") = True Then
        '    dr("FIYAT") = dr("FIYAT") / ((dr("KDV") + 100) / 100)
        'Else
        '    dr("FIYAT") = dr("BIRIMFIYAT")
        'End If
        dr.EndEdit()
    End Sub
    Private Sub rpt_ihtiyac()
        Dim frm As New frm_uretim_ihtiyac_liste
        frm.status = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        'frm.userno = userno
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        frm.kayitno = dr("STOKNO").ToString
        frm.nUretimID = dr_baslik("IND")
        frm.qkayitno = "Eþittir"
        frm.status = True
        frm.ShowDialog()
        frm.Close()
        frm.Dispose()
        frm = Nothing
        dr = Nothing
    End Sub
    Private Sub calculator()
        Dim frm As New frm_calc
        If frm.ShowDialog = DialogResult.OK Then
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub ekran_full()
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub BarButtonItem17_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        Try
            If XtraTabControl1.SelectedTabPageIndex.ToString = 0 Then
                GridControl1.Focus()
                GridControl1.Select()
            ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 1 Then
                GridControl2.Focus()
                GridControl2.Select()
            ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 2 Then
                GridControl3.Focus()
                GridControl3.Select()
            ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 3 Then
                GridControl4.Focus()
                GridControl4.Select()
            ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 4 Then
                GridControl5.Focus()
                GridControl5.Select()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        alttoplam_hesapla()
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        girdi_tutar_hesapla()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Belgeyi Kapatmak Ýstediðinize Eminmisiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub VGrid_baslik_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles VGrid_baslik.CellValueChanged
        'Vgrid_baslik.PostEditor()
        VGrid_baslik.UpdateFocusedRecord()
        VGrid_baslik.CloseEditor()
        baslik_degistir()
    End Sub
    Private Sub baslik_degistir()
        If GridView1.RowCount > 0 Then
            'baslikdegistir(izahat, dr_baslik("IND"), CInt(dr_baslik("AK")), CInt(dr_baslik("KDV")), dr_baslik("FIRMANO"), dr_baslik("BELGENO").ToString, dr_baslik("PARABIRIMI").ToString, dr_baslik("KUR"), dr_baslik("TARIH"), dr_baslik("ODEMETARIHI"), dr_baslik("TARIH"), dr_baslik("FIRMAKODU").ToString, dr_baslik("FIRMAAD").ToString, dr_baslik("ADRESPOSTA").ToString, dr_baslik("VERGIDAIRESI").ToString, dr_baslik("VERGINO").ToString, dr_baslik("ALTNOT").ToString, dr_baslik("KOD1").ToString, dr_baslik("KOD2").ToString)
            baslik_kaydet_degistir(belgeind, dr_baslik("STOKNO"), dr_baslik("STOKKODU").ToString, dr_baslik("MALINCINSI").ToString, dr_baslik("OZELKOD").ToString, dr_baslik("BIRIM").ToString, dr_baslik("FIYAT"), dr_baslik("KDV"), dr_baslik("KULLANICI"), Now, dr_baslik("TUTAR"), dr_baslik("ACIKLAMA"), 0, dr_baslik("SATISFIYATI"), "", dr_baslik("MIKTAR"), dr_baslik("RECETENO"), dr_baslik("STANDARTSURE"), dr_baslik("DURUM"), dr_baslik("TARIH"), dr_baslik("FISNO"), dr_baslik("POZNO"), dr_baslik("TERMIN"), dr_baslik("URETIMEBASLAMATARIHI"), dr_baslik("URETIMBITISTARIHI"), dr_baslik("ENTEGRE"))
            If anamiktar <> dr_baslik("MIKTAR") Then
                hareket_kaydet_degistir_miktar(belgeind, dr_baslik("MIKTAR"))
                anamiktar = dr_baslik("MIKTAR")
                dataload_hareket()
            End If
            Timer1.Enabled = False
            alttoplam_hesapla()
            cikti_maliyet_degistir(belgeind, dr_baslik("MIKTAR"), 1, dr_toplam("BIRIMMALIYET"), dr_toplam("GENELTOPLAM"), dr_baslik("STOKNO"))
            Timer1.Enabled = True
            dataload_cikti()
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        satir_ekle_cikti()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        satir_ekle_pozisyon()
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        satir_duzelt_pozisyon()
    End Sub
    Private Sub GridView3_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView3.CellValueChanged
        If GridView3.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            pozisyon_degistir(dr("IND"), belgeind, dr("SIRANO"), dr("KOD"), dr("ACIKLAMA"), dr("POZISYONNO"), dr("URETIMYERINO"), dr("URETIMYERIKODU"), dr("DEPOKODU"), dr("DEPONO"), dr("MALIYET"), dr("TOPLAMMALIYET"), dr("STANDARTSURE"), dr("SUREHESAPLAMATURU"), dr("STANDARTBIRIMSURE"), dr("GIRISTARIHI"), dr("CIKISTARIHI"), dr("GIRISMIKTARI"), dr("CIKISMIKTARI"))
            dataload_pozisyon_girdi()
        End If
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        satir_ekle_girdi()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        If GridView3.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Pozisyon Kaydýný Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                pozisyon_kaydet_sil(dr("IND"))
                ds_pozisyon.Tables("POZISYON").Rows.Remove(dr)
                dataload_pozisyon_girdi()
            End If
            dr = Nothing
        End If
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Üretim Emri Kaydýný Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            belge_iptal(belgeind)
            If sorgu_sayi(dr_baslik("ENTEGRE"), 0) <> 0 Then
                fis_sil(sorgu_sayi(dr_baslik("ENTEGRE"), 0), "DG")
            End If
            Me.Close()
        End If
    End Sub
    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        satir_ekle_masraf()
    End Sub
    Private Sub BarButtonItem19_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        calculator()
    End Sub
    Private Sub GridView5_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView5.CellValueChanged
        If GridView5.RowCount > 0 Then
            cikti_tutar_hesapla()
        End If
    End Sub
    Private Sub cikti_tutar_hesapla()
        If GridView5.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView5.GetDataRow(GridView5.FocusedRowHandle)
            If dr("BIRIMMIKTAR") = 0 Then
                dr("BIRIMMIKTAR") = 1
            End If
            dr("MIKTAR2") = dr("MIKTAR") * dr("BIRIMMIKTAR")
            If GridView5.FocusedColumn.Name.ToString = colTUTAR.Name.ToString Then
                dr("FIYAT") = dr("TUTAR") / dr("MIKTAR2")
            Else
                dr("TUTAR") = dr("MIKTAR2") * dr("FIYAT")
            End If
            dr("TUTAR") = dr("MIKTAR2") * dr("FIYAT")
            'cikti_degistir(dr("IND"), belgeind, dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("MIKTAR"), dr("BIRIM"), dr("BIRIMMIKTAR"), dr("MIKTAR2"), dr("KDV"), dr("FIYAT"), dr("BARCODE"), Now, Now, dr("KULLANICI"), dr("ORAN"), dr("TUR"), dr("DEPONO"), belgeind, dr("TUTAR"), dr("POZISYONNO"), dr("FIREORANI"), dr("FIREMIKTARI"), dr("KALANMIKTAR"), dr("EKMALIYET"), dr("EKMALIYETTOPLAM"), dr("EKMALIYETSTOKNO"), dr("EKMALIYETSTOKKODU"), dr("EKMALIYETMALINCINSI"), dr("EKMALIYETKDV"))
            Dim dr1 As DataRow
            Dim miktar2 As Decimal = 0
            Dim tutar As Decimal = 0
            For Each dr1 In ds_cikti.Tables(0).Rows
                miktar2 += dr1("MIKTAR2")
                tutar += dr1("TUTAR")
            Next
            If miktar2 = 0 Then
                miktar2 = dr_baslik("MIKTAR")
            Else
                For Each dr1 In ds_cikti.Tables(0).Rows
                    dr1("ORAN") = (dr1("MIKTAR2") / miktar2) * 100
                    cikti_degistir(dr1("IND"), belgeind, dr1("STOKNO"), dr1("STOKKODU"), dr1("MALINCINSI"), dr1("MIKTAR"), dr1("BIRIM"), dr1("BIRIMMIKTAR"), dr1("MIKTAR2"), dr1("KDV"), dr1("FIYAT"), dr1("BARCODE"), Now, Now, dr1("KULLANICI"), dr1("ORAN"), dr1("TUR"), dr1("DEPONO"), belgeind, dr1("TUTAR"), dr1("POZISYONNO"), dr1("FIREORANI"), dr1("FIREMIKTARI"), dr1("KALANMIKTAR"), dr1("EKMALIYET"), dr1("EKMALIYETTOPLAM"), dr1("EKMALIYETSTOKNO"), dr1("EKMALIYETSTOKKODU"), dr1("EKMALIYETMALINCINSI"), dr1("EKMALIYETKDV"))
                Next
            End If
            If miktar2 = dr_baslik("MIKTAR") Then
                'normal
            Else
                If XtraMessageBox.Show("Üretim Miktarýný Deðiþtirmek Ýstermisiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    dr_baslik("MIKTAR") = miktar2
                    Dim satir = GridView5.FocusedRowHandle
                    baslik_degistir()
                    GridView5.FocusedRowHandle = satir
                End If
            End If
            dr.EndEdit()
            dr1 = Nothing
            miktar2 = Nothing
        End If
    End Sub
    Private Sub cikti_ek_tutar_hesapla()
        Dim dr As DataRow
        dr = GridView7.GetDataRow(GridView7.FocusedRowHandle)
        If dr("BIRIMMIKTAR") = 0 Then
            dr("BIRIMMIKTAR") = 1
        End If
        If GridView7.FocusedColumn.Name.ToString = colCiktiEkTutar.Name.ToString Then
            dr("FIYAT") = dr("TUTAR") / dr("MIKTAR")
        Else
            dr("TUTAR") = dr("MIKTAR") * dr("FIYAT")
        End If
        dr("TUTAR") = dr("MIKTAR") * dr("FIYAT")
        dr.EndEdit()
        cikti_ek_kaydet_degistir(dr("IND"), dr("EVRAKNO"), dr("STOKNO"), dr("MIKTAR"), dr("BIRIM"), dr("BIRIMMIKTAR"), dr("KDV"), dr("FIYAT"), dr("TUTAR"), dr("DEPONO"))
        GridControl5.RefreshDataSource()
        'dataload_cikti()
        GridControl5.Focus()
        GridControl5.Select()
        Dim dr1 As DataRow = GridView5.GetDataRow(GridView5.FocusedRowHandle)
        dr1("EKMALIYET") = sorgu_sayi(ek_maliyet(), 0)
        dr1.EndEdit()
        cikti_tutar_hesapla()
    End Sub
    Private Function ek_maliyet() As Decimal
        Dim dr As DataRow
        Dim lMaliyet As Decimal = 0
        For Each dr In ds_cikti_ek.Tables(0).Rows
            lMaliyet += dr("TUTAR")
        Next
        Return lMaliyet
    End Function
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        VGrid_baslik.RowsCustomization()
    End Sub
    Private Sub BarButtonItem20_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        VGrid_maliyet.RowsCustomization()
    End Sub
    Private Sub BarButtonItem21_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        VGrid_geneltoplam.RowsCustomization()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        If GridView6.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView6.GetDataRow(GridView6.FocusedRowHandle)
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Üretim Araç Kaydýný Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                arac_kaydet_sil(dr("IND"))
                ds_arac.Tables(0).Rows.Remove(dr)
            End If
        End If
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        satir_ekle_arac()
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        GridView6.ColumnsCustomization()
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        GridView3.ColumnsCustomization()
    End Sub
    Private Sub BarButtonItem22_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        gorunum_kaydet()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        If GridView1.RowCount > 0 Then
            rpt_ihtiyac()
        End If
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Girdi Kaydýný Silmek Ýstediðinize Eminmisiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                hareket_kaydet_sil(dr("IND"))
                ds_hareket.Tables(0).Rows.Remove(dr)
            End If
        End If
    End Sub
    Private Sub VGrid_aciklama_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles VGrid_aciklama.CellValueChanged
        Try
            'Vgrid_baslik.PostEditor()
            VGrid_aciklama.UpdateFocusedRecord()
            VGrid_aciklama.CloseEditor()
            If GridView1.RowCount > 0 Then
                'baslikdegistir(izahat, dr_baslik("IND"), CInt(dr_baslik("AK")), CInt(dr_baslik("KDV")), dr_baslik("FIRMANO"), dr_baslik("BELGENO").ToString, dr_baslik("PARABIRIMI").ToString, dr_baslik("KUR"), dr_baslik("TARIH"), dr_baslik("ODEMETARIHI"), dr_baslik("TARIH"), dr_baslik("FIRMAKODU").ToString, dr_baslik("FIRMAAD").ToString, dr_baslik("ADRESPOSTA").ToString, dr_baslik("VERGIDAIRESI").ToString, dr_baslik("VERGINO").ToString, dr_baslik("ALTNOT").ToString, dr_baslik("KOD1").ToString, dr_baslik("KOD2").ToString)
                baslik_kaydet_degistir(belgeind, dr_baslik("STOKNO"), dr_baslik("STOKKODU").ToString, dr_baslik("MALINCINSI").ToString, dr_baslik("OZELKOD").ToString, dr_baslik("BIRIM").ToString, dr_baslik("FIYAT"), dr_baslik("KDV"), dr_baslik("KULLANICI"), Now, dr_baslik("TUTAR"), dr_baslik("ACIKLAMA"), 0, dr_baslik("SATISFIYATI"), "", dr_baslik("MIKTAR"), dr_baslik("RECETENO"), dr_baslik("STANDARTSURE"), dr_baslik("DURUM"), dr_baslik("TARIH"), dr_baslik("FISNO"), dr_baslik("POZNO"), dr_baslik("TERMIN"), dr_baslik("URETIMEBASLAMATARIHI"), dr_baslik("URETIMBITISTARIHI"), dr_baslik("ENTEGRE"))
                If anamiktar <> dr_baslik("MIKTAR") Then
                    hareket_kaydet_degistir_miktar(belgeind, dr_baslik("MIKTAR"))
                    anamiktar = dr_baslik("MIKTAR")
                    dataload_hareket()
                End If
                Timer1.Enabled = False
                alttoplam_hesapla()
                cikti_maliyet_degistir(belgeind, dr_baslik("MIKTAR"), 1, dr_toplam("BIRIMMALIYET"), dr_toplam("GENELTOPLAM"), dr_baslik("STOKNO"))
                Timer1.Enabled = True
                dataload_cikti()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla(2)
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla(0)
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        raporla(1)
    End Sub
    Private Sub frm_uretim_emir_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Me.Hide()
        Timer1.Enabled = False
        Timer1.Dispose()
        Timer1 = Nothing
        ds_baslik.Clear()
        ds_baslik.Dispose()
        ds_baslik = Nothing
        ds_hareket.Clear()
        ds_hareket.Dispose()
        ds_hareket = Nothing
        ds_maliyet.Clear()
        ds_maliyet.Dispose()
        ds_maliyet = Nothing
        ds_toplam.Clear()
        ds_toplam.Dispose()
        ds_toplam = Nothing
        ds_depolar.Clear()
        ds_depolar.Dispose()
        ds_depolar = Nothing
        ds_pozisyon.Clear()
        ds_pozisyon.Dispose()
        ds_pozisyon = Nothing
        ds_arac.Clear()
        ds_arac.Dispose()
        ds_arac = Nothing
        ds_cikti.Clear()
        ds_cikti.Dispose()
        ds_cikti = Nothing
        kisayol_girdi.Dispose()
        kisayol_girdi = Nothing
        kisayol_cikti.Dispose()
        kisayol_cikti = Nothing
        kisayol_pozisyon.Dispose()
        kisayol_pozisyon = Nothing
        kisayol_arac.Dispose()
        kisayol_arac = Nothing
        GridControl1.Dispose()
        GridControl1 = Nothing
        GridView1.Dispose()
        GridView1 = Nothing
        GridControl2.Dispose()
        GridControl2 = Nothing
        GridView2.Dispose()
        GridView2 = Nothing
        GridControl3.Dispose()
        GridControl3 = Nothing
        GridView3.Dispose()
        GridView3 = Nothing
        GridControl4.Dispose()
        GridControl4 = Nothing
        GridView4.Dispose()
        GridView4 = Nothing
        GridView5.Dispose()
        GridView5 = Nothing
        GridView6.Dispose()
        GridView6 = Nothing
        VGrid_baslik.Dispose()
        VGrid_baslik = Nothing
        VGrid_geneltoplam.Dispose()
        VGrid_geneltoplam = Nothing
        VGrid_aciklama.Dispose()
        VGrid_aciklama = Nothing
        VGrid_maliyet.Dispose()
        VGrid_maliyet = Nothing
        BarManager1.Dispose()
        BarManager1 = Nothing
        panel_baslik.Dispose()
        panel_baslik = Nothing
        panel_toplam.Dispose()
        panel_toplam = Nothing
        panel_info.Dispose()
        panel_info = Nothing
        PanelControl4.Dispose()
        PanelControl4 = Nothing
        Bar1.Dispose()
        Bar1 = Nothing
        'frx = Nothing
        firmano = Nothing
        firma = Nothing
        donemno = Nothing
        donem = Nothing
        userno = Nothing
        username = Nothing
        connection = Nothing
        depono = Nothing
        belgeind = Nothing
        dr = Nothing
        dr_baslik = Nothing
        dr_haraket = Nothing
        dr_maliyet = Nothing
        dr_toplam = Nothing
        dr_cikti = Nothing
        dr_pozisyon = Nothing
        dr_arac = Nothing
        cmd = Nothing
        con = Nothing
        adapter = Nothing
        'alttoplam hesaplarý
        toplamhammadde = Nothing
        toplammasraf = Nothing
        hammaddeorani = Nothing
        masraforani = Nothing
        masraftoplami = Nothing
        toplamfire = Nothing
        firemiktari = Nothing
        fireorani = Nothing
        birimmaliyet = Nothing
        karorani = Nothing
        kar = Nothing
        toplam = Nothing
        kdv = Nothing
        geneltoplam = Nothing
        anamiktar = Nothing
        ds_pozisyon_maliyet = Nothing
        ds_veri = Nothing
        stutar = Nothing
        SplitterControl1.Dispose()
        SplitterControl1 = Nothing
        XtraTabControl1.Dispose()
        XtraTabControl1 = Nothing
        XtraTabPage1.Dispose()
        XtraTabPage1 = Nothing
        XtraTabPage2.Dispose()
        XtraTabPage2 = Nothing
        XtraTabPage3.Dispose()
        XtraTabPage3 = Nothing
        XtraTabPage4.Dispose()
        XtraTabPage4 = Nothing
        Me.Dispose()
        Me.Close()
        System.GC.Collect()
        System.GC.GetTotalMemory(True)
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub GridView6_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView6.CellValueChanged
        If GridView6.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView6.GetDataRow(GridView6.FocusedRowHandle)
            arac_degistir(dr("IND"), dr("SIRANO"), belgeind, dr("ARACNO"), dr("ARACKODU"), dr("CALISMAUSULU"), dr("POZISYONNO"), dr("MIKTAR"), dr("BIRIMMIKTAR"))
        End If
    End Sub
    Friend WithEvents BarSubItem7 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem23 As DevExpress.XtraBars.BarButtonItem
    Private Sub BarButtonItem23_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Üretimi Kesinleþtirip Güncellemek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            'dataload_cikti()
            ekle_stok_sayim(dr_baslik("URETIMBITISTARIHI"), "DG", "M", dr_baslik("IND"))
        End If
    End Sub
    Private Sub ekle_stok_sayim(ByVal dteFisTarihi As DateTime, ByVal sFisTipi As String, ByVal sFiyatTipi As String, ByVal lFisNo As Int64)
        Dim nCariHareketID = 0
        Dim nStokFisiID As String = ""
        Dim sHareketTipi As String = ""
        Dim nGirisCikis As Integer = 1
        Dim nFirmaID = 0
        Dim nStokID = 0
        Dim nIslemID = 0
        Dim nKayit = 0
        Dim sDepo As String = ""
        Dim cari_kayit_sayisi As Integer = 0
        Dim fis_kayit_sayisi As Integer = 0
        Dim lNetTutar As Decimal = 0
        Dim lGirisFiyat As Decimal = 0
        Dim lGirisTutar As Decimal = 0
        Dim lCikisFiyat As Decimal = 0
        Dim lCikisTutar As Decimal = 0
        Dim lGirisMiktar1 As Decimal = 0
        Dim lCikisMiktar1 As Decimal = 0
        Dim lBrutFiyat As Decimal = 0
        Dim lBrutTutar As Decimal = 0
        Dim sAciklama As String = "Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00"
        Dim sBirimCinsi As String = ""
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim lBirimMiktar As Decimal = 1
        If sFisTipi = "DG" Then
            nGirisCikis = 1
        ElseIf sFisTipi = "DC" Then
            nGirisCikis = 3
        End If
        'bar2.Position = 0
        'bar2.Properties.Maximum = dataset1.Tables(0).Rows.Count
        cari_kayit_sayisi = sorgu_TBfirma_kontrol("URETIM")
        If cari_kayit_sayisi = 0 Then
            nFirmaID = firma_kaydet_yeni("URETIM", "URETIM", 0, 0, "01/01/1900", 0, "", "", "", "", "", "", "", "", "", 0, "", kullanici, Now, "")
            firma_siniflari_kaydet_yeni(nFirmaID, "", "", "", "", "")
        Else
            nFirmaID = cari_kayit_sayisi
        End If
        dr_baslik("ENTEGRE") = sorgu_sayi(dr_baslik("ENTEGRE"), 0)
        If dr_baslik("ENTEGRE") <> 0 Then
            fis_sil(dr_baslik("ENTEGRE"), "DG")
        End If
        If ds_cikti.Tables(0).Rows.Count > 0 Then
            fis_kayit_sayisi = sorgu_fis_kontrol(sFisTipi, 1, dteFisTarihi, lFisNo, nFirmaID)
            If fis_kayit_sayisi = 0 Then
                If nStokFisiID = "" Then
                    nStokFisiID = sorgu_nStokFisiID()
                    lFisNo = sorgu_lFisNo(nFirmaID, sFisTipi)
                    sHareketTipi = ""
                    nStokFisiID = tbStokFisiMaster_kaydet_yeni(nStokFisiID, sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, "", Today, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "", "", "", "", sHareketTipi, 0, 0, 0, "", "", 0, kullanici, Now, "", 0, 0, 0, 0, 0, 0)
                    'nStokFisiID = tbStokFisiMaster_kaydet_yeni(nStokFisiID, sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, "", Today, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "", "", "", "", sHareketTipi, 0, 0, "", "", "", 0, kullanici, Now, "", 0, 0, 0, 0, 0, 0)
                    tbStokFisiAciklamasi_kaydet_yeni(nStokFisiID, "URETIM-ENTEGRE", "", "", "", "")
                    tbStokFisiMaster_lFisno_degistir(nStokFisiID)
                End If
                Dim kayitsayisi = sorgu_tbAlisVerisAdres_kontrol(nStokFisiID)
                If kayitsayisi = 0 Then
                    tbAlisVerisAdres_kaydet_yeni(nStokFisiID, "", "", "", "", "", "", "", "", "", "")
                Else
                End If
            Else
                nStokFisiID = fis_kayit_sayisi.ToString
            End If
        End If
        For Each dr In ds_cikti.Tables(0).Rows
            'nStokID = sorgu_nStokID(Trim(dr("STOKKODU").ToString)).ToString
            'sDepo = sorgu_sDepo_kontrol(Microsoft.VisualBasic.Left(dr("DEPOKODU"), 4))
            'If sDepo.ToString = 0 Then
            '    sDepo = tbDepo_kaydet_yeni(Microsoft.VisualBasic.Left(dr("DEPOKODU"), 4), Microsoft.VisualBasic.Left(dr("DEPOKODU"), 4), 0, "", "", "", 0, 0, 0, "", 0, "01/01/1900", "01/01/1900", "", 1)
            'Else
            '    sDepo = Microsoft.VisualBasic.Left(dr("DEPOKODU"), 4)
            'End If
            'If Trim(nStokID.ToString) = "" Then
            '    nStokID = tbStok_kaydet_yeni(Microsoft.VisualBasic.Left(sorgu_telefon(dr("STOKKODU").ToString, ""), 20), Microsoft.VisualBasic.Left(sorgu_telefon(dr("MALINCINSI"), ""), 60), dr("IND").ToString, 0, "", "", "", "", "", "", "", 0, "", 0, 0, 0, "", 0, Microsoft.VisualBasic.Left(sorgu_telefon(dr("STOKKODU"), ""), 20), kullanici, Now, 0, "", 0, 0, "", 0, 0, 0)
            '    tbStokSinifi_kaydet_yeni(nStokID, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
            '    If Trim(dr("STOKKODU").ToString) <> "" Then
            '        tbStokBarkodu_kaydet_yeni(nStokID, Trim(dr("STOKKODU").ToString), 0, 0, "", "")
            '    End If
            'End If
            nStokID = dr("STOKNO")
            sDepo = dr("DEPONO")
            sBirimCinsi = dr("BIRIM")
            If dr("MIKTAR") <> 0 Then
                If sFisTipi = "DG" Then
                    lGirisMiktar1 = sorgu_sayi(dr("MIKTAR"), 0)
                    lGirisFiyat = (sorgu_sayi(dr("TUTAR"), 0) / lGirisMiktar1) + sorgu_sayi(dr("EKMALIYETTUTAR"), 0)
                    lGirisTutar = lGirisFiyat * lGirisMiktar1 'sorgu_sayi(dr("TUTAR"), 0) + (sorgu_sayi(dr("EKMALIYETTUTAR"), 0) * sorgu_sayi(dr("MIKTAR"), 1))
                    lCikisMiktar1 = 0
                    lCikisFiyat = 0
                    lCikisTutar = 0
                    lBrutFiyat = lGirisFiyat
                    lBrutTutar = lGirisTutar
                ElseIf sFisTipi = "DC" Then
                    lGirisMiktar1 = 0
                    lGirisFiyat = 0
                    lGirisTutar = 0
                    lCikisMiktar1 = sorgu_sayi(dr("MIKTAR"), 0)
                    lCikisFiyat = (sorgu_sayi(dr("TUTAR"), 0) / lCikisMiktar1) + sorgu_sayi(dr("EKMALIYETTUTAR"), 0)
                    lGirisTutar = lCikisFiyat * lCikisMiktar1
                    lBrutFiyat = lCikisFiyat
                    lBrutTutar = lCikisTutar
                End If
                nIslemID = sorgu_nStokIslemID()
                'Try
                tbStokFisidetay_fatura_kaydet_yeni(nIslemID, nStokID, dteFisTarihi, nFirmaID, 0, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, 0, "", "", "", "", dteFisTarihi, 0, lGirisMiktar1, 0, lGirisFiyat, lGirisTutar, lCikisMiktar1, 0, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi, lBirimMiktar, lBrutFiyat, lBrutTutar, 0, 0, 0, 0, 0, "", 0, "", 0, "", "", 0, 0, sAciklama, sHareketTipi, 0, kullanici, dteFisTarihi, "", 0, 0, "", 0, 0, 0, "", "", nStokFisiID, "", "", "", 0, 0, 0, 0, kullanici, Now)
                fis_detay_fisno_degistir(nIslemID)
                'Catch ex As Exception
                '   XtraMessageBox.Show(Sorgu_sDil(" Aktarýlamadý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                'End Try
                ds_veri = sorgu_cikti_ek(dr("IND"))
                For Each dr1 In ds_veri.Tables(0).Rows
                    nStokID = dr1("STOKNO")
                    sDepo = dr1("DEPONO")
                    sBirimCinsi = dr1("BIRIM")
                    lGirisMiktar1 = -sorgu_sayi(dr1("MIKTAR") * dr("MIKTAR"), 0)
                    lGirisFiyat = sorgu_sayi(dr1("FIYAT"), 0)
                    lGirisTutar = -sorgu_sayi(dr1("TUTAR") * dr("MIKTAR"), 0)
                    lCikisMiktar1 = 0
                    lCikisFiyat = 0
                    lCikisTutar = 0
                    lBrutFiyat = lGirisFiyat
                    lBrutTutar = lGirisTutar
                    nIslemID = sorgu_nStokIslemID()
                    Try
                        tbStokFisidetay_fatura_kaydet_yeni(nIslemID, nStokID, dteFisTarihi, nFirmaID, 0, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, 0, "", "", "", "", dteFisTarihi, 0, lGirisMiktar1, 0, lGirisFiyat, lGirisTutar, lCikisMiktar1, 0, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi, lBirimMiktar, lBrutFiyat, lBrutTutar, 0, 0, 0, 0, 0, "", 0, "", 0, "", "", 0, 0, sAciklama, sHareketTipi, 0, kullanici, dteFisTarihi, "", 0, 0, "", 0, 0, 0, "", "", nStokFisiID, "", "", "", 0, 0, 0, 0, kullanici, Now)
                        fis_detay_fisno_degistir(nIslemID)
                    Catch ex As Exception
                        XtraMessageBox.Show(dr("1sKodu").ToString & Sorgu_sDil(" Aktarýlamadý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                Next
            End If
            'Bar2.Position += 1
            'Bar2.Refresh()
            'lbl_info.Text = Bar2.Position
            'lbl_info.Refresh()
        Next
        For Each dr In ds_hareket.Tables(0).Rows
            If dr("MALIYETTURU") = -1 Then
                nStokID = dr("STOKNO")
                sDepo = dr("DEPONO")
                sBirimCinsi = dr("BIRIM")
                If dr("MIKTAR") <> 0 Then
                    If sFisTipi = "DG" Then
                        lGirisMiktar1 = -sorgu_sayi(dr("MIKTAR"), 0)
                        lGirisFiyat = sorgu_sayi(dr("FIYAT"), 0)
                        lGirisTutar = -sorgu_sayi(dr("TUTAR"), 0)
                        lCikisMiktar1 = 0
                        lCikisFiyat = 0
                        lCikisTutar = 0
                        lBrutFiyat = lGirisFiyat
                        lBrutTutar = lGirisTutar
                    ElseIf sFisTipi = "DC" Then
                        lGirisMiktar1 = 0
                        lGirisFiyat = 0
                        lGirisTutar = 0
                        lCikisMiktar1 = -sorgu_sayi(dr("MIKTAR"), 0)
                        lCikisFiyat = sorgu_sayi(dr("FIYAT"), 0)
                        lCikisTutar = sorgu_sayi(dr("TUTAR"), 0)
                        lBrutFiyat = lCikisFiyat
                        lBrutTutar = lCikisTutar
                    End If
                    nIslemID = sorgu_nStokIslemID()
                    If nStokFisiID = "" Then
                        nStokFisiID = sorgu_nStokFisiID()
                    End If
                    Try
                        tbStokFisidetay_fatura_kaydet_yeni(nIslemID, nStokID, dteFisTarihi, nFirmaID, 0, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, 0, "", "", "", "", dteFisTarihi, 0, lGirisMiktar1, 0, lGirisFiyat, lGirisTutar, lCikisMiktar1, 0, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi, lBirimMiktar, lBrutFiyat, lBrutTutar, 0, 0, 0, 0, 0, "", 0, "", 0, "", "", 0, 0, sAciklama, sHareketTipi, 0, kullanici, dteFisTarihi, "", 0, 0, "", 0, 0, 0, "", "", nStokFisiID, "", "", "", 0, 0, 0, 0, kullanici, Now)
                        fis_detay_fisno_degistir(nIslemID)
                    Catch ex As Exception
                        XtraMessageBox.Show(dr("STOKKODU").ToString & Sorgu_sDil(" Aktarýlamadý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                End If
            End If
            'Bar2.Position += 1
            'Bar2.Refresh()
            'lbl_info.Text = Bar2.Position
            'lbl_info.Refresh()
        Next
        dr_baslik("ENTEGRE") = nStokFisiID
        dr_baslik("URETIMBITISTARIHI") = Today
        baslik_kaydet_degistir(belgeind, dr_baslik("STOKNO"), dr_baslik("STOKKODU").ToString, dr_baslik("MALINCINSI").ToString, dr_baslik("OZELKOD").ToString, dr_baslik("BIRIM").ToString, dr_baslik("FIYAT"), dr_baslik("KDV"), dr_baslik("KULLANICI"), Now, dr_baslik("TUTAR"), dr_baslik("ACIKLAMA"), 0, dr_baslik("SATISFIYATI"), "", dr_baslik("MIKTAR"), dr_baslik("RECETENO"), dr_baslik("STANDARTSURE"), dr_baslik("DURUM"), dr_baslik("TARIH"), dr_baslik("FISNO"), dr_baslik("POZNO"), dr_baslik("TERMIN"), dr_baslik("URETIMEBASLAMATARIHI"), dr_baslik("URETIMBITISTARIHI"), dr_baslik("ENTEGRE"))
        'bar2.Position = 0
        'bar2.Refresh()
        XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub fis_sil(ByVal nStokFisiID As Int64, ByVal sFisTipi As String)
        tbStokFisiMaster_kaydet_sil(nStokFisiID, sFisTipi)
    End Sub
    Private Sub tbStokFisiMaster_kaydet_sil(ByVal nStokFisiID As String, ByVal sFisTipi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'If dr_baslik("nKasaIslemID").ToString <> "" Then
        '    tbNakitKasa_kaydet_sil(dr_baslik("nKasaIslemID").ToString, 0)
        '    'dr_baslik("nKasaIslemID") = ""
        'End If
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFirmaHareketi WHERE     (nHareketID IN (SELECT     nCariHareketID FROM          tbStokFisiOdemePlani WHERE      (nStokFisiID = '" & nStokFisiID & "')))")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiOdemePlani WHERE     (nStokFisiID = '" & nStokFisiID & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiPesinAdres WHERE     (nStokFisiID = '" & nStokFisiID & "')")
            cmd.ExecuteNonQuery()
            If sFisTipi = "PF" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAlisverisSiparis SET              nStokIslemID = NULL, dteTeslimEdilen = '01/01/1900',dteOnayTarihi = '01/01/1900', bTeslimEdildi = 0 WHERE     (nStokIslemID IN (SELECT     nIslemID FROM          tbStokFisiDetayi WHERE      nStokFisiID = '" & nStokFisiID & "' ))")
                cmd.ExecuteNonQuery()
                'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAlisverisSiparis SET nStokIslemID = NULL , dteTeslimEdilen = '01/01/1900' ,dteOnayTarihi = '01/01/1900', bTeslimEdildi = 0 WHERE nStokIslemID IN ( SELECT nIslemID FROM tbStokFisiDetayi WHERE nStokFisiID = '" & nStokFisiID & "') SELECT DISTINCT nStokFisiID INTO #tempSilTrans FROM tbStokFisiDetayi , ( SELECT DISTINCT dteFistarihi , lFisno FROM tbStokFisiMaster , ( SELECT DISTINCT nIrsaliyeFisiID FROM tbStokFisiDetayi WHERE nStokFisiID = '" & nStokFisiID & "' ) AS Irsaliye WHERE Irsaliye.nIrsaliyeFisiID =tbStokFisiMaster.nStokFisiID ) AS TempIrs WHERE tbStokFisiDetayi.sFisTipi= 'T' AND tbStokFisiDetayi.dteFisTarihi = TempIrs.dteFisTarihi AND tbStokFisiDetayi.lFisno = TempIrs.lFisno AND tbStokFisiDetayi.sHangiUygulama = 'PI' DELETE tbStokFisiAciklamasi WHERE nStokFisiID IN ( SELECT * FROM #tempSilTrans) DELETE tbStokFisiDetayi WHERE nStokFisiID IN ( SELECT * FROM #tempSilTrans) DELETE tbStokFisiMaster WHERE nStokFisiID IN ( SELECT * FROM #tempSilTrans) DROP TABLE #tempSilTrans SELECT DISTINCT nStokFisiID INTO #tempSilTrans1 FROM tbStokFisiDetayi , ( SELECT DISTINCT dteFistarihi , lFisno FROM tbStokFisiMaster WHERE nStokFisiID = '" & nStokFisiID & "' ) AS TempIrs WHERE tbStokFisiDetayi.sFisTipi= 'T' AND tbStokFisiDetayi.dteFisTarihi = TempIrs.dteFisTarihi AND tbStokFisiDetayi.lFisno = TempIrs.lFisno AND tbStokFisiDetayi.sHangiUygulama = 'PI' DELETE tbStokFisiAciklamasi WHERE nStokFisiID IN ( SELECT * FROM #tempSilTrans1) DELETE tbStokFisiDetayi WHERE nStokFisiID IN ( SELECT * FROM #tempSilTrans1) DELETE tbStokFisiMaster WHERE nStokFisiID IN ( SELECT * FROM #tempSilTrans1) DROP TABLE #tempSilTrans1 DELETE tbRafHareketi FROM tbStokFisidetayi WHERE tbRafHareketi.nIslemID = tbStokFisidetayi.nIslemID AND nStokFisiID = '" & nStokFisiID & "' SELECT DISTINCT nIrsaliyeFisiID INTO #temp1 FROM tbStokFisiDetayi WHERE nStokFisiID = '" & nStokFisiID & "' DELETE tbStokFisiDetayi WHERE nStokFisiID = '" & nStokFisiID & "' DELETE tbStokFisiOdemePlani WHERE nStokFisiID IN ( SELECT * FROM #temp1 WHERE nIrsaliyeFisiID IS NOT NULL) DELETE tbStokFisiAciklamasi WHERE nStokFisiID IN ( SELECT * FROM #temp1 WHERE nIrsaliyeFisiID IS NOT NULL) DELETE tbStokFisiMaster WHERE nStokFisiID IN ( SELECT * FROM #temp1 WHERE nIrsaliyeFisiID IS NOT NULL) DROP TABLE #Temp1 ")
                'cmd.ExecuteNonQuery()
            End If
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiAciklamasi WHERE     (nStokFisiID = '" & nStokFisiID & "')")
            cmd.ExecuteNonQuery()
            If Trim(sFisTipi) <> "IA" Or Trim(sFisTipi) <> "IS" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiDetayi WHERE     (nStokFisiID = '" & nStokFisiID & "') AND (nIrsaliyeFisiID IS NULL)")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiMaster SET              bFaturayaDonustumu = 0 WHERE     (nStokFisiID IN (SELECT DISTINCT nIrsaliyeFisiID FROM          tbStokFisiDetayi WHERE      nStokFisiID = '" & nStokFisiID & "'))")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiDetayi SET              sFisTipi = 'IA', dteFisTarihi = dteIrsaliyeTarihi, lFisNo = lIrsaliyeNo, nStokFisiID = nIrsaliyeFisiID WHERE     (nStokFisiID = '" & nStokFisiID & "')")
                cmd.ExecuteNonQuery()
            ElseIf Trim(sFisTipi) = "IA" Or Trim(sFisTipi) = "IS" Then
                'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiDetayi WHERE     (nStokFisiID = '" & nStokFisiID & "')")
                'cmd.ExecuteNonQuery()
            End If
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiDetayi WHERE     (nStokFisiID = '" & nStokFisiID & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiMaster WHERE     (nStokFisiID = '" & nStokFisiID & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Hatasý Lütfen Tekrar Deneyiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        cmd.CommandText = sorgu_query("set implicit_transactions off")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiSeriNo WHERE     (nStokFisiID = '" & nStokFisiID & "')")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiEkMaliyet WHERE     (nStokFisiID = '" & nStokFisiID & "')")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
        dr_baslik("ENTEGRE") = 0
        baslik_kaydet_degistir(belgeind, dr_baslik("STOKNO"), dr_baslik("STOKKODU").ToString, dr_baslik("MALINCINSI").ToString, dr_baslik("OZELKOD").ToString, dr_baslik("BIRIM").ToString, dr_baslik("FIYAT"), dr_baslik("KDV"), dr_baslik("KULLANICI"), Now, dr_baslik("TUTAR"), dr_baslik("ACIKLAMA"), 0, dr_baslik("SATISFIYATI"), "", dr_baslik("MIKTAR"), dr_baslik("RECETENO"), dr_baslik("STANDARTSURE"), dr_baslik("DURUM"), dr_baslik("TARIH"), dr_baslik("FISNO"), dr_baslik("POZNO"), dr_baslik("TERMIN"), dr_baslik("URETIMEBASLAMATARIHI"), dr_baslik("URETIMBITISTARIHI"), dr_baslik("ENTEGRE"))
    End Sub
    Public Function sorgu_lFisNo(ByVal nFirmaID As String, ByVal sFisTipi As String, Optional ByVal sDatabase As String = "") As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      ISNULL(MAX(lFisNo), 0) + 1 AS lFisNo FROM         tbStokFisiMaster  Where nFirmaID = '" & nFirmaID & "' ")
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      ISNULL(MAX(lFisNo), 0) + 1 AS lFisNo FROM         tbStokFisiMaster  Where sFisTipi = '" & sFisTipi & "'  ")
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      ISNULL(MAX(lFisNo), 0) + 1 AS lFisNo FROM         tbStokFisiMaster  Where sFisTipi = '" & sFisTipi & "'  AND nStokFisiID IN (Select TOP 10 nStokFisiID from tbStokFisiMaster Where sFisTipi ='" & sFisTipi & "' Order by dteFisTarihi DESC)")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      ISNULL(MAX(lFisNo), 0) + 1 AS lFisNo FROM         tbStokFisiMaster  Where sFisTipi = '" & sFisTipi & "'  AND nStokFisiID IN (Select TOP 3 nStokFisiID from tbStokFisiMaster Where sFisTipi ='" & sFisTipi & "' and nFirmaID = " & nFirmaID & " Order by dteFisTarihi DESC)")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
        conn.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        conn = Nothing
        cmd = Nothing
    End Function
    Public Function sorgu_TBfirma_kontrol(ByVal kod As String, Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nFirmaID, 0) AS KAYIT FROM         tbFirma " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        conn.Close()
        cmd = Nothing
        conn = Nothing
        adapter = Nothing
        Return kayitsayisi
        cmd = Nothing
        conn = Nothing
    End Function
    Public Function sorgu_nStokFisiID(Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim kriter As String = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nStokFisiID), 1) + 1 AS nStokFisiID FROM         tbStokFisiMaster")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        conn = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_nStokIslemID(Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
        conn = Nothing
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_fis_kontrol(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String, Optional ByVal resmi As Boolean = True, Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim kriter
        kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        If resmi = True Then
            conn.ConnectionString = connection
        ElseIf resmi = False Then
            conn.ConnectionString = connection
        End If
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nStokFisiID, 0) AS KAYIT FROM         tbStokFisiMaster " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        conn.Close()
        cmd = Nothing
        conn = Nothing
        adapter = Nothing
        Return kayitsayisi
        cmd = Nothing
        conn = Nothing
    End Function
    Private Sub fis_detay_fisno_degistir(ByVal nstokIslemID As String, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = '" & nstokIslemID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
        conn = Nothing
        cmd = Nothing
    End Sub
    Private Function firma_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal nOzelIskontosu As Decimal, ByVal lKrediLimiti As Decimal, ByVal dteMutabakatTarihi As DateTime, ByVal nVadeGun As Int64, ByVal sHitap As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal nHesapID As Int64, ByVal sOzelNot As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sFiyatTipi As String, Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY INSERT INTO tbFirma                       (sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, dteMutabakatTarihi, nVadeGun, sHitap, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, nHesapID, sOzelNot, sKullaniciAdi, dteKayitTarihi, sFiyatTipi) VALUES     ('" & sKodu & "', N'" & sAciklama & "', " & nOzelIskontosu & ", " & lKrediLimiti & ", '" & dteMutabakatTarihi & "', " & nVadeGun & " , '" & sHitap & "', '" & sAdres1 & "', '" & sAdres2 & "', '" & sSemt & "', '" & sIl & "', '" & sUlke & "', '" & sPostaKodu & "',  '" & sVergiDairesi & "', '" & sVergiNo & "', " & nHesapID & " , '" & sOzelNot & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sFiyatTipi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        cmd = Nothing
        con = Nothing
        Return hareketno
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub firma_siniflari_kaydet_yeni(ByVal nFirmaID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " INSERT INTO tbFirmaSinifi                       (nFirmaID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5) VALUES     ('" & nFirmaID & "', '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function tbStokFisiMaster_kaydet_yeni(ByVal nStokFisiID As String, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal nGirisCikis As Int64, ByVal lFisNo As Int64, ByVal nFirmaID As Int64, ByVal sDepo As String, ByVal dteValorTarihi As DateTime, ByVal bPesinmi As Byte, ByVal bListelendimi As Byte, ByVal bHizmetFaturasimi As Byte, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi1 As Decimal, ByVal lDipIskontoTutari1 As Decimal, ByVal nDipIskontoYuzdesi2 As Decimal, ByVal lDipIskontoTutari2 As Decimal, ByVal lDipIskontoTutari3 As Decimal, ByVal lEkmaliyet1 As Decimal, ByVal lEkmaliyet2 As Decimal, ByVal lEkmaliyet3 As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lNetTutar As Decimal, ByVal nTevkifatKdvOrani As Decimal, ByVal lTevkifatKdvMatrahi As Decimal, ByVal lTevkifatKdv As Decimal, ByVal sCariIslem As String, ByVal nCariHareketID As String, ByVal nKasaIslemID As String, ByVal sCariKdvIslem As String, ByVal nCariKdvHareketID As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal bFisTamamlandimi As Byte, ByVal lTransferFisiID As String, ByVal nTransferFirmaID As String, ByVal sTransferDepo As String, ByVal bFaturayaDonustumu As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sYaziIle As String, ByVal nOTVOrani1 As Decimal, ByVal lOTVMatrahi1 As Decimal, ByVal lOTV1 As Decimal, ByVal nOTVOrani2 As Decimal, ByVal lOTVMatrahi2 As Decimal, ByVal lOTV2 As Decimal, Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sCariIslem, nCariHareketID, nKasaIslemID, sCariKdvIslem, nCariKdvHareketID, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID, nTransferFirmaID, sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " , '" & sCariIslem & "', '" & nCariHareketID & "', '" & nKasaIslemID & "', '" & sCariKdvIslem & "', '" & nCariKdvHareketID & "', '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "', '" & nTransferFirmaID & "', '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & ")")
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID,  sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " ,  '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "',  '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nStokFisiID = cmd.ExecuteScalar
        Return nStokFisiID
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub tbStokFisiAciklamasi_kaydet_yeni(ByVal nStokFisiID As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY INSERT INTO tbStokFisiAciklamasi                       (nStokFisiID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5) VALUES     ('" & nStokFisiID & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFisiMaster_lFisno_degistir(ByVal nstokFisiID As String, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = '" & nstokFisiID & "' where nSiraIndex = 2")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function sorgu_tbAlisVerisAdres_kontrol(ByVal nAlisVerisID As String, Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim kriter
        kriter = "WHERE (nAlisVerisID = '" & nAlisVerisID & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbAlisVerisAdres " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        conn = Nothing
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub tbAlisVerisAdres_kaydet_yeni(ByVal nAlisVerisID As String, ByVal sAciklama As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal sSubeMagaza As String, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbAlisVerisAdres (nAlisVerisID, sAciklama, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, sSubeMagaza) VALUES     ('" & nAlisVerisID & "', N'" & sAciklama & "', '" & sAdres1 & "', '" & sAdres2 & "', '" & sSemt & "', '" & sIl & "', '" & sUlke & "', '" & sPostaKodu & "', '" & sVergiDairesi & "', '" & sVergiNo & "', '" & sSubeMagaza & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function tbStokFisidetay_kaydet_yeni(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As Int64, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  '" & nAlisverisID & "', NULL, NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nIslemID = cmd.ExecuteScalar
        Return nIslemID
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub tbStokFisidetay_fatura_kaydet_yeni(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal sBirimCinsi As String, ByVal lBirimMiktar As Decimal, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As Int64, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi,sBirimCinsi,lBirimMiktar, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , '" & sBirimCinsi & "'," & lBirimMiktar & "," & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  NULL, '" & nStokFisiID & "', NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        GridView5.ColumnsCustomization()
    End Sub
    Friend WithEvents colDEPONO2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sDepo_cikti As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DataColumn138 As System.Data.DataColumn
    Friend WithEvents BarButtonItem24 As DevExpress.XtraBars.BarButtonItem
    Private Sub BarButtonItem24_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        If sorgu_sayi(dr_baslik("ENTEGRE"), 0) <> 0 Then
            fis_duzelt(sorgu_sayi(dr_baslik("ENTEGRE"), 0), "DG ", 1)
        End If
    End Sub
    Private Sub fis_duzelt(ByVal nStokFisiID As String, ByVal sFisTipi As String, ByVal nGirisCikis As Integer)
        Dim frm As New frm_fatura
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.lFisNo = dr_baslik("IND")
        'frm.dteFisTarihi = dr("dteFisTarihi")
        frm.sFisTipi = sFisTipi
        'frm.nFirmaID = dr("nFirmaID")
        frm.nGirisCikis = nGirisCikis
        frm.nStokFisiID = nStokFisiID
        frm.kullanici = kullanici
        'If yetki_kontrol(kullanici, frm.Name) = True Then
        frm.ShowDialog()
        'End If
        frm.Close()
    End Sub
    Private Sub GridView2_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView2.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView3_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView3.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView4_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView4.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView5_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView5.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView6_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView6.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Friend WithEvents colsDovizCinsi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_DovizCinsi_girdi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents collDovizKuru1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizMiktari1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MIKTAR2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEKMALIYET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEKMALIYETTOPLAM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEKMALIYETSTOKNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEKMALIYETSTOKKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEKMALIYETMALINCINSI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEKMALIYETKDV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn139 As System.Data.DataColumn
    Friend WithEvents DataColumn140 As System.Data.DataColumn
    Friend WithEvents DataColumn141 As System.Data.DataColumn
    Friend WithEvents DataColumn142 As System.Data.DataColumn
    Friend WithEvents DataColumn143 As System.Data.DataColumn
    Friend WithEvents DataColumn144 As System.Data.DataColumn
    Friend WithEvents DataColumn145 As System.Data.DataColumn
    Friend WithEvents DataColumn146 As System.Data.DataColumn
    Friend WithEvents DataColumn147 As System.Data.DataColumn
    Friend WithEvents DataColumn148 As System.Data.DataColumn
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView1.FocusedColumn().Caption & "] Kolonundaki verileri Aþaðý Doðru Yaymak istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                'info = False
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                degeryay_girdi(GridView1.FocusedColumn().FieldName)
                'info = True
                Cursor.Current = Cursors.Default
                Cursor.Hide()
            End If
        End If
    End Sub
    Private Sub degeryay_girdi(ByVal columnkriter As String)
        Dim durum
        Dim sayi = GridView1.RowCount  'kl.Count
        Dim satir = GridView1.FocusedRowHandle 'kl.Position
        Dim TOPLAM = sayi - GridView1.FocusedRowHandle 'kl.Position
        Dim t As Int64
        Dim Ý As Integer
        Ý = 0
        Dim dr_hareket As DataRow
        Dim dr As DataRow
        dr_hareket = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        durum = dr_hareket("" & columnkriter & "")
        For Ý = 1 To TOPLAM
            'dr_hareket = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            'dr_hareket.BeginEdit()
            'dr_hareket("" & columnkriter & "") = durum
            'dr_hareket.EndEdit()
            t += 1
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr("" & columnkriter & "") = durum
            dr.EndEdit()
            girdi_tutar_hesapla()
            'toplam_hesapla()
            GridView1.FocusedRowHandle += 1
        Next
        GridView1.FocusedRowHandle = satir
        GridView1.GetDataRow(satir)
        durum = Nothing
        sayi = Nothing
        satir = Nothing
        Ý = Nothing
    End Sub
    Private Sub degeryay_cikti(ByVal columnkriter As String)
        Dim durum
        Dim sayi = GridView5.RowCount  'kl.Count
        Dim satir = GridView5.FocusedRowHandle 'kl.Position
        Dim TOPLAM = sayi - GridView5.FocusedRowHandle 'kl.Position
        Dim t As Int64
        Dim Ý As Integer
        Ý = 0
        Dim dr_hareket As DataRow
        Dim dr As DataRow
        dr_hareket = GridView5.GetDataRow(GridView5.FocusedRowHandle)
        durum = dr_hareket("" & columnkriter & "")
        For Ý = 1 To TOPLAM
            'dr_hareket = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            'dr_hareket.BeginEdit()
            'dr_hareket("" & columnkriter & "") = durum
            'dr_hareket.EndEdit()
            t += 1
            GridView5.PostEditor()
            dr = GridView5.GetDataRow(GridView5.FocusedRowHandle)
            dr("" & columnkriter & "") = durum
            dr.EndEdit()
            cikti_tutar_hesapla()
            'toplam_hesapla()
            GridView5.FocusedRowHandle += 1
        Next
        GridView5.FocusedRowHandle = satir
        GridView5.GetDataRow(satir)
        durum = Nothing
        sayi = Nothing
        satir = Nothing
        Ý = Nothing
    End Sub
    Private Sub degeryay_cikti_ek(ByVal columnkriter As String)
        Dim durum
        Dim sayi = GridView7.RowCount  'kl.Count
        Dim satir = GridView7.FocusedRowHandle 'kl.Position
        Dim TOPLAM = sayi - GridView7.FocusedRowHandle 'kl.Position
        Dim t As Int64
        Dim Ý As Integer
        Ý = 0
        Dim dr_hareket As DataRow
        Dim dr As DataRow
        dr_hareket = GridView7.GetDataRow(GridView7.FocusedRowHandle)
        durum = dr_hareket("" & columnkriter & "")
        For Ý = 1 To TOPLAM
            'dr_hareket = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            'dr_hareket.BeginEdit()
            'dr_hareket("" & columnkriter & "") = durum
            'dr_hareket.EndEdit()
            t += 1
            GridView7.PostEditor()
            dr = GridView7.GetDataRow(GridView7.FocusedRowHandle)
            dr("" & columnkriter & "") = durum
            dr.EndEdit()
            cikti_ek_tutar_hesapla()
            'toplam_hesapla()
            GridView7.FocusedRowHandle += 1
        Next
        GridView7.FocusedRowHandle = satir
        GridView7.GetDataRow(satir)
        durum = Nothing
        sayi = Nothing
        satir = Nothing
        Ý = Nothing
    End Sub
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView5.FocusedColumn().Caption & "] Kolonundaki verileri Aþaðý Doðru Yaymak istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                'info = False
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                degeryay_cikti(GridView5.FocusedColumn().FieldName)
                'info = True
                Cursor.Current = Cursors.Default
                Cursor.Hide()
            End If
        End If
    End Sub
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        EK_Maliyet_Belirle()
    End Sub
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        analiz_stok_hareket()
    End Sub
    Private Sub analiz_stok_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("STOKKODU")
            frm.nFirmaID = 0 'dr("nFirmaID")
            frm.sec_firma.Checked = True
            frm.sec_giris.Text = "Giriþler"
            frm.kullanici = kullanici
            frm.islemstatus = True
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
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
    Private Sub stok_fiyat()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_fiyatlandir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("STOKNO")
            frm.sModel = dr("STOKKODU")
            frm.sKodu = dr("STOKKODU")
            frm.sRenk = "" 'dr("sRenk")
            frm.sBeden = "" 'dr("sBeden")
            frm.txt_musteriNo.Text = dr("STOKKODU")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        analiz_envanter()
    End Sub
    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        stok_fiyat()
    End Sub
    Private Sub satir_ara()
        If GridView1.OptionsView.ShowAutoFilterRow = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
        Else
            GridView1.OptionsView.ShowAutoFilterRow = True
        End If
    End Sub
    Private Sub SonAlisSartlariniUygula(Optional ByVal bFirmaSecili As Boolean = False)
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim ds_SonHareket As DataSet
        Dim sayi As Integer = 0
        GridView1.FocusedColumn = colHTUTAR
        For Each dr In ds_hareket.Tables(0).Rows
            Dim kriter As String = "and dteFisTarihi < '" & dr_baslik("TARIH") & "'"
            'If bFirmaSecili = True Then
            '    kriter += " AND tbStokFisiDetayi.nFirmaID = " & dr_baslik("nFirmaID") & " "
            'End If
            ds_SonHareket = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select TOP 1 lBrutFiyat,lBrutTutar,nKdvOrani,lGirisMiktar1,lGirisFiyat,lGirisTutar,lIlaveMaliyetTutar,nIskontoYuzdesi,lIskontoTutari,CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, CAST(0 AS MONEY) AS ISK5,CAST(0 AS MONEY) AS ISK6,CAST(0 AS MONEY) AS ISK7,CAST(0 AS MONEY) AS ISK8,CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 50, 9) AS MONEY) AS nMasrafSatiri,CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL((ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0) AS lKdvTutari,dbo.ROUNDYTL(tbStokFisiDetayi.lBrutFiyat * tbStokFisiDetayi.lBirimMiktar) AS lFiyat,CAST(dbo.ROUNDYTL(tbStokFisiDetayi.lBrutFiyat*tbStokFisiDetayi.lBirimMiktar) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilFiyat,CAST(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutFiyat,CAST(tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutTutar,lDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutTutar / lDovizKuru1 ELSE lBrutTutar END, lDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN dbo.ROUNDYTL((lBrutFiyat*lBirimMiktar)) / lDovizKuru1 ELSE dbo.ROUNDYTL(lBrutFiyat*lBirimMiktar) END,lDovizBrutFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutFiyat / lDovizKuru1 ELSE lBrutFiyat END, lDahilDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutTutar / lDovizKuru1) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutTutar)* (100 + tbStokFisiDetayi.nKdvOrani) / 100  END, lDahilDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN ((lBrutFiyat*lBirimMiktar) / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE ((lBrutFiyat*lBirimMiktar))* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END,lDahilDovizBrutFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutFiyat / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutFiyat)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END from tbStokFisiDetayi Where sFisTipi ='FA' and nGirisCikis =1 and nStokID = " & dr("STOKNO") & kriter & " Order by dteFisTarihi DESC,dteKayitTarihi DESC"))
            If ds_SonHareket.Tables(0).Rows.Count = 1 Then
                dr1 = ds_SonHareket.Tables(0).Rows(0)
                dr("KDV") = dr1("nKdvOrani")
                'dr("nIskontoYuzdesi") = dr1("nIskontoYuzdesi")
                dr("lFIYAT") = dr1("lGirisFiyat")
                dr("TUTAR") = dr1("MIKTAR") * dr("FIYAT")
                girdi_tutar_hesapla(sayi)
            End If
            sayi += 1
        Next
        dr1 = Nothing
        ds_SonHareket = Nothing
        sayi = Nothing
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Son Alýþ Þartlarýný Uygulamak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            SonAlisSartlariniUygula()
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Tamamlandý...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Friend WithEvents BarButtonItem25 As DevExpress.XtraBars.BarButtonItem
    Private Sub BarButtonItem25_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        satir_ara()
    End Sub
    Friend WithEvents BarSubItem10 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem27 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem28 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem26 As DevExpress.XtraBars.BarButtonItem
    Private Sub BarButtonItem27_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem28_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        analiz_stok_hareket()
    End Sub
    Friend WithEvents BarButtonItem29 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem30 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem31 As DevExpress.XtraBars.BarButtonItem
    Private Sub BarButtonItem29_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem29.ItemClick
        raporla_etiket(2)
    End Sub
    Private Sub BarButtonItem30_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem30.ItemClick
        raporla_etiket(0)
    End Sub
    Private Sub BarButtonItem31_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem31.ItemClick
        Dim deger = ""
        deger = InputBox("Yazdýrma Çarpaný", "Yazdýrma Çarpaný", 1).ToString
        If deger.ToString <> "" Then
            raporla_etiket(3, deger)
            'yazdir_direkt(deger)
        End If
    End Sub
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
                Dim toplamsayi = 0
                Dim sayi = 0
                If XtraTabControl1.SelectedTabPageIndex = 0 Then
                    arr = GridView1.GetSelectedRows()
                    toplamsayi = GridView1.SelectedRowsCount
                ElseIf XtraTabControl1.SelectedTabPageIndex = 2 Then
                    arr = GridView5.GetSelectedRows()
                    toplamsayi = GridView5.SelectedRowsCount
                Else
                    arr = GridView1.GetSelectedRows()
                    toplamsayi = GridView1.SelectedRowsCount
                End If
                Dim dr1 As DataRow
                If arr Is Nothing Then
                Else
                    Array.Sort(arr)
                    For Each i In arr
                        s = i.ToString
                        If XtraTabControl1.SelectedTabPageIndex = 0 Then
                            dr1 = GridView1.GetDataRow(s)
                        ElseIf XtraTabControl1.SelectedTabPageIndex = 2 Then
                            dr1 = GridView5.GetDataRow(s)
                        Else
                            dr1 = GridView1.GetDataRow(s)
                        End If
                        file = OpenFileDialog1.FileName.ToString
                        fiyat1 = 0 'dr("FIYAT1")
                        fiyat2 = 0 'dr("FIYAT2")
                        fiyat3 = 0 'dr("FIYAT3")
                        miktar = Math.Abs(dr1("MIKTAR")) * carpan
                        If Microsoft.VisualBasic.Right(file, 3) = "fr3" Then
                            report_create_etiket(file, "WHERE stok.nStokId IN (" & dr1("STOKNO") & ")", islem, miktar, fiyat1, fiyat2, fiyat3)
                        ElseIf Microsoft.VisualBasic.Right(file, 3) = "frx" Then
                            report_create_etiketX(file, "WHERE stok.nStokId IN (" & dr1("STOKNO") & ")", islem, miktar, fiyat1, fiyat2, fiyat3)
                        End If
                    Next
                End If
            Else
                file = OpenFileDialog1.FileName.ToString
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                fiyat1 = 0 'dr("FIYAT1")
                fiyat2 = 0 'dr("FIYAT2")
                fiyat3 = 0 'dr("FIYAT3")
                miktar = Math.Abs(dr("MIKTAR")) * carpan
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
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            toplamsayi = GridView1.SelectedRowsCount
            arr = GridView1.GetSelectedRows()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 2 Then
            toplamsayi = GridView5.SelectedRowsCount
            arr = GridView5.GetSelectedRows()
        Else
            toplamsayi = GridView1.SelectedRowsCount
            arr = GridView1.GetSelectedRows()
        End If
        Dim sayi = 0
        Dim dr1 As DataRow
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                If XtraTabControl1.SelectedTabPageIndex = 0 Then
                    dr1 = GridView1.GetDataRow(s)
                ElseIf XtraTabControl1.SelectedTabPageIndex = 2 Then
                    dr1 = GridView5.GetDataRow(s)
                Else
                    dr1 = GridView1.GetDataRow(s)
                End If
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
    Private Sub report_create_etiketX(ByVal sFile As String, ByVal kriter As String, ByVal nIslem As Integer, ByVal bMiktarli As Decimal, ByVal fiyat1 As Decimal, ByVal fiyat2 As Decimal, ByVal fiyat3 As Decimal)
        Dim report As New FastReport.Report
        report.Load(sFile)
        Dim ds_etiket As DataSet
        ds_etiket = sorgu(sorgu_query("set transaction isolation level read uncommitted SELECT " & dr_baslik("IND") & " AS sPartiNo," & dr_baslik("TARIH") & " AS dteTarih,PESIN = CASE WHEN FIYAT <> 0 THEN FIYAT ELSE FIYAT1 END, * FROM (SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS FIYAT1, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sAktifFiyatTipi & "') AS FIYAT,barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.sKavala,stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ) tbStok"), "Etiket")
        report.RegisterData(ds_etiket)
        report.RegisterData(ds_tbParamGenel)
        report.ScriptLanguage = Language.Vb
        report.PrintSettings.Collate = False
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
        If IntPtr.Size = 4 Then
            '32 Bit
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
            'qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT PESIN = CASE WHEN FIYAT <> 0 THEN FIYAT ELSE FIYAT1 END, * FROM (SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS FIYAT1, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sAktifFiyatTipi & "') AS FIYAT,barkod.sBarkod, stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI,stok.sKisaAdi, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi,(SELECT     tbSSinif1.sAciklama FROM         tbStokSinifi INNER JOIN                       tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu Where tbStokSinifi.nStokID = tbStok.nStokID) AS SINIF1 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ) tbStok")
            qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT " & dr_baslik("IND") & " AS sPartiNo," & dr_baslik("TARIH") & " AS dteTarih,PESIN = CASE WHEN FIYAT <> 0 THEN FIYAT ELSE FIYAT1 END, * FROM (SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS FIYAT1, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sAktifFiyatTipi & "') AS FIYAT,barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden,stok.sKavala, stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ) tbStok")
            'ds_etiket = sorgu(sorgu_query("set transaction isolation level read uncommitted SELECT PESIN = CASE WHEN FIYAT <> 0 THEN FIYAT ELSE FIYAT1 END, * FROM (SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS FIYAT1, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sAktifFiyatTipi & "') AS FIYAT,barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ) tbStok "), "Etiket")
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_hareket.DataBase = qr_connection
            frx.PrintOptions.Collate = False
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
            qr_hareket = Nothing
            qr_connection = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(2) = "" & sorgu_query("set transaction isolation level read uncommitted SELECT " & dr_baslik("IND") & " AS sPartiNo," & dr_baslik("TARIH") & " AS dteTarih,PESIN = CASE WHEN FIYAT <> 0 THEN FIYAT ELSE FIYAT1 END, * FROM (SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS FIYAT1, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sAktifFiyatTipi & "') AS FIYAT,barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden,stok.sKavala, stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ) tbStok") & ""
            args(3) = "qr_hareket"
            args(4) = "" & status.ToString() & ""
            args(5) = "8"
            args(6) = "FIRMANO"
            args(7) = "" & firmano.ToString() & ""
            args(8) = "DONEMNO"
            args(9) = "" & donemno.ToString() & ""
            args(10) = "STOKNO"
            args(11) = "" & stokno.ToString() & ""
            args(12) = "SATIRLINE"
            args(13) = "'" & satir_line.ToString() & "'"
            args(14) = "FIYAT1"
            args(15) = "" & fiyat1 & ""
            args(16) = "FIYAT2"
            args(17) = "" & fiyat2 & ""
            args(18) = "FIYAT3"
            args(19) = "" & fiyat3 & ""
            args(20) = "FIYAT"
            args(21) = "'" & fiyat_gizle_tumu(FormatNumber(fiyat1, 2), FormatNumber(fiyat2, 2), FormatNumber(fiyat3, 2)) & "'"
            processYol = args(0)
            For i As Integer = 1 To 21
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
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BarSubItem11 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem32 As DevExpress.XtraBars.BarButtonItem
    Private Sub BarButtonItem32_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem32.ItemClick
        sFiyatTipi_toplu()
    End Sub
    Private Sub sFiyatTipi_toplu()
        If XtraMessageBox.Show(Sorgu_sDil("Alýþ FiyatTipini Atamak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim sayi = 0
            Dim say As Integer = -1
            Dim Fiyat As Decimal = 0
            Dim lMiktar As Decimal = 0
            Dim dr As DataRow
            Dim nMaxIskontoYuzdesi = 100
            Dim satir = GridView1.FocusedRowHandle
            For Each dr In ds_hareket.Tables(0).Rows
                Fiyat = 0
                Fiyat = sorgu_stok_fiyat(sFiyatA, dr("STOKNO"))
                If Fiyat <> 0 Then
                    dr("FIYAT") = Fiyat
                    dr("TUTAR") = dr("MIKTAR") * dr("FIYAT")
                    GridView1.FocusedRowHandle = say
                    girdi_tutar_hesapla(sayi)
                End If
                say += 1
            Next
            dr = Nothing
            sayi = Nothing
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Function sorgu_stok_fiyat(ByVal fiyattipi As String, ByVal stokno As Int64) As Decimal
        Dim kriter
        kriter = "WHERE     (sFiyatTipi = '" & fiyattipi & "') AND (nStokID = " & stokno & ")"
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lFiyat, 0) AS FIYAT FROM         tbStokFiyati " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        con.Dispose()
        cmd.Dispose()
        cmd = Nothing
        adapter = Nothing
    End Function
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents kisayol_ek As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_depo_ek As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCiktiEkTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbl_CiktiMalinCinsi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_CiktiStokKodu As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_CiktiIND As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Private Sub GridView7_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView7.CellValueChanged
        cikti_ek_tutar_hesapla()
    End Sub
    Private Sub GridView5_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView5.DoubleClick
        EK_Maliyet_Belirle()
    End Sub
    Private Sub EK_Maliyet_Belirle()
        If GridView5.RowCount > 0 Then
            Dim dr As DataRow = GridView5.GetDataRow(GridView5.FocusedRowHandle)
            dataload_cikti_ek(dr("IND"), dr("STOKKODU"), dr("MALINCINSI"))
            XtraTabControl1.SelectedTabPageIndex = 4
            GridControl5.Focus()
            GridControl5.Select()
        End If
    End Sub
    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        satir_ekle_cikti_ek(lbl_CiktiIND.Text)
    End Sub
    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        If GridView7.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView7.GetDataRow(GridView7.FocusedRowHandle)
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Çýktý Kaydýný Silmek Ýstediðinize Eminmisiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                cikti_ek_kaydet_sil(dr("IND"))
                ds_cikti_ek.Tables(0).Rows.Remove(dr)
            End If
        End If
    End Sub
    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        If GridView7.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView7.FocusedColumn().Caption & "] Kolonundaki verileri Aþaðý Doðru Yaymak istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                'info = False
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                degeryay_cikti_ek(GridView7.FocusedColumn().FieldName)
                'info = True
                Cursor.Current = Cursors.Default
                Cursor.Hide()
            End If
        End If
    End Sub
    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click
        GridView7.ColumnsCustomization()
    End Sub
    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        GridControl5.ShowPrintPreview()
    End Sub

    ' =============================================
    ' URETIM ASAMA YONETIMI FONKSIYONLARI
    ' =============================================
    
    Public Sub UretimAsamalariYukle(ByVal evrakNo As Integer)
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = connection
            cmd.Connection = con
            cmd.CommandText = sorgu_query("SELECT e.nID, e.nUretimEmriID, a.sAsamaKodu, a.sAsamaAdi, e.sDurum, e.dteBaslangic, e.dteBitis, e.lPlanlananMiktar, e.lGerceklesenMiktar, e.lFireMiktar, e.sAciklama FROM tbUretimEmriAsama e INNER JOIN tbUretimAsamaTanim a ON e.nAsamaID = a.nAsamaID WHERE e.nUretimEmriID = " & evrakNo & " ORDER BY a.nSiraNo")
            
            Dim adapter As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            con.Open()
            adapter.Fill(dt)
            con.Close()
            
            If dt.Rows.Count > 0 Then
                Dim mesaj As String = "Uretim Emri Asamalari:" & vbCrLf & vbCrLf
                For Each dr As DataRow In dt.Rows
                    mesaj &= dr("sAsamaAdi").ToString() & " - " & dr("sDurum").ToString()
                    If dr("lGerceklesenMiktar") IsNot DBNull.Value Then
                        mesaj &= " (Gerceklesen: " & Convert.ToDecimal(dr("lGerceklesenMiktar")).ToString("N2") & ")"
                    End If
                    mesaj &= vbCrLf
                Next
                MessageBox.Show(mesaj, "Asama Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Bu uretim emri icin asama bilgisi bulunamadi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            
        Catch ex As Exception
            MessageBox.Show("Asama yukleme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Public Sub MevcutAsamayiTamamla(ByVal evrakNo As Integer, ByVal gerceklesenMiktar As Decimal, ByVal fireMiktar As Decimal, Optional ByVal aciklama As String = "")
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = connection
            cmd.Connection = con
            
            cmd.CommandText = sorgu_query("SELECT e.nAsamaID FROM tbUretimEmriAsama e INNER JOIN tbUretimAsamaTanim a ON e.nAsamaID = a.nAsamaID WHERE e.nUretimEmriID = " & evrakNo & " AND e.sDurum = 'Devam' ORDER BY a.nSiraNo")
            Dim adapter As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            con.Open()
            adapter.Fill(dt)
            
            If dt.Rows.Count = 0 Then
                MessageBox.Show("Devam eden asama bulunamadi.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                con.Close()
                Exit Sub
            End If
            
            Dim nAsamaID As Integer = Convert.ToInt32(dt.Rows(0)("nAsamaID"))
            
            cmd.CommandText = sorgu_query("UPDATE tbUretimEmriAsama SET sDurum = 'Tamamlandi', dteBitis = GETDATE(), dteOnayTarihi = GETDATE(), lGerceklesenMiktar = " & gerceklesenMiktar.ToString().Replace(",", ".") & ", lFireMiktar = " & fireMiktar.ToString().Replace(",", ".") & ", sAciklama = '" & aciklama.Replace("'", "''") & "' WHERE nUretimEmriID = " & evrakNo & " AND nAsamaID = " & nAsamaID)
            cmd.ExecuteNonQuery()
            
            If fireMiktar > 0 Then
                cmd.CommandText = sorgu_query("INSERT INTO tbUretimFire (nUretimEmriID, nAsamaID, lFireMiktar, sFireNedeni) VALUES (" & evrakNo & ", " & nAsamaID & ", " & fireMiktar.ToString().Replace(",", ".") & ", '" & aciklama.Replace("'", "''") & "')")
                cmd.ExecuteNonQuery()
            End If
            
            cmd.CommandText = sorgu_query("SELECT TOP 1 e.nAsamaID FROM tbUretimEmriAsama e INNER JOIN tbUretimAsamaTanim a ON e.nAsamaID = a.nAsamaID WHERE e.nUretimEmriID = " & evrakNo & " AND e.sDurum = 'Bekliyor' ORDER BY a.nSiraNo")
            dt.Clear()
            adapter.Fill(dt)
            
            If dt.Rows.Count > 0 Then
                Dim sonrakiAsamaID As Integer = Convert.ToInt32(dt.Rows(0)("nAsamaID"))
                cmd.CommandText = sorgu_query("UPDATE tbUretimEmriAsama SET sDurum = 'Devam', dteBaslangic = GETDATE(), lPlanlananMiktar = " & gerceklesenMiktar.ToString().Replace(",", ".") & " WHERE nUretimEmriID = " & evrakNo & " AND nAsamaID = " & sonrakiAsamaID)
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("UPDATE TBLUREURETIM SET nMevcutAsamaID = " & sonrakiAsamaID & " WHERE EVRAKNO = " & evrakNo)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Asama tamamlandi, sonraki asamaya gecildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                cmd.CommandText = sorgu_query("UPDATE TBLUREURETIM SET DURUM = 'Tamamlandi', dteGercekBitis = GETDATE() WHERE EVRAKNO = " & evrakNo)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Tum asamalar tamamlandi! Uretim emri kapandi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            
            con.Close()
            
        Catch ex As Exception
            MessageBox.Show("Asama tamamlama hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Public Sub GecikmeKaydet(ByVal evrakNo As Integer, ByVal gecikmeNedeni As String, ByVal gecikmeSuresi As Integer)
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = connection
            cmd.Connection = con
            
            cmd.CommandText = sorgu_query("SELECT nMevcutAsamaID FROM TBLUREURETIM WHERE EVRAKNO = " & evrakNo)
            Dim adapter As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            con.Open()
            adapter.Fill(dt)
            
            Dim nAsamaID As Integer = 0
            If dt.Rows.Count > 0 AndAlso dt.Rows(0)("nMevcutAsamaID") IsNot DBNull.Value Then
                nAsamaID = Convert.ToInt32(dt.Rows(0)("nMevcutAsamaID"))
            End If
            
            cmd.CommandText = sorgu_query("INSERT INTO tbUretimGecikme (nUretimEmriID, nAsamaID, sGecikmeNedeni, nGecikmeSuresi, dteGecikmeBaslangic) VALUES (" & evrakNo & ", " & nAsamaID & ", '" & gecikmeNedeni.Replace("'", "''") & "', " & gecikmeSuresi & ", GETDATE())")
            cmd.ExecuteNonQuery()
            con.Close()
            
            MessageBox.Show("Gecikme kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
        Catch ex As Exception
            MessageBox.Show("Gecikme kaydetme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' =============================================
    ' PARAMETRIK ONAY SISTEMI - YENI FONKSIYONLAR
    ' =============================================
    
    ''' <summary>
    ''' Mevcut asamada onay bekleyen kayitlari gosterir
    ''' </summary>
    Public Sub BekleyenOnaylariGoster(ByVal evrakNo As Integer)
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = connection
            cmd.Connection = con
            
            cmd.CommandText = sorgu_query("SELECT o.nOnayID, a.sAsamaAdi, t.sOnayTurAdi, o.nOnayNo, o.sOnayDurum, o.dteTalepTarihi FROM tbUretimEmriAsamaOnaylar o INNER JOIN tbUretimAsamaTanim a ON o.nAsamaID = a.nAsamaID INNER JOIN tbOnayTurleri t ON o.nOnayTurID = t.nOnayTurID WHERE o.nUretimEmriID = " & evrakNo & " AND o.sOnayDurum = 'Bekliyor' ORDER BY a.nSiraNo, o.nOnayNo")
            
            Dim adapter As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            con.Open()
            adapter.Fill(dt)
            con.Close()
            
            If dt.Rows.Count > 0 Then
                Dim mesaj As String = "BEKLEYEN ONAYLAR" & vbCrLf & vbCrLf
                For Each dr As DataRow In dt.Rows
                    mesaj &= "Asama: " & dr("sAsamaAdi").ToString() & vbCrLf
                    mesaj &= "Onay: " & dr("sOnayTurAdi").ToString() & " (" & dr("nOnayNo").ToString() & ". onay)" & vbCrLf
                    mesaj &= "Talep: " & Convert.ToDateTime(dr("dteTalepTarihi")).ToString("dd.MM.yyyy HH:mm") & vbCrLf & vbCrLf
                Next
                MessageBox.Show(mesaj, "Bekleyen Onaylar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Bekleyen onay bulunmuyor.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            
        Catch ex As Exception
            MessageBox.Show("Bekleyen onaylari yukleme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ''' <summary>
    ''' Asama onayi verir - parametrik sistem ile
    ''' </summary>
    Public Sub AsamaOnayVer(ByVal nOnayID As Integer, ByVal sAciklama As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = connection
            cmd.Connection = con
            con.Open()
            
            ' Onay bilgilerini al
            cmd.CommandText = sorgu_query("SELECT nUretimEmriAsamaID, nUretimEmriID, nAsamaID FROM tbUretimEmriAsamaOnaylar WHERE nOnayID = " & nOnayID)
            Dim adapter As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            
            If dt.Rows.Count = 0 Then
                MessageBox.Show("Onay kaydý bulunamadý.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
                Exit Sub
            End If
            
            Dim nAsamaKayitID As Integer = Convert.ToInt32(dt.Rows(0)("nUretimEmriAsamaID"))
            Dim nEvrakNo As Integer = Convert.ToInt32(dt.Rows(0)("nUretimEmriID"))
            Dim nAsamaID As Integer = Convert.ToInt32(dt.Rows(0)("nAsamaID"))
            
            ' Onay ver
            cmd.CommandText = sorgu_query("UPDATE tbUretimEmriAsamaOnaylar SET sOnayDurum = 'Onaylandi', nOnaylayanID = " & CInt(KeyCode.kullanici) & ", dteOnayTarihi = GETDATE(), sAciklama = '" & sAciklama.Replace("'", "''") & "' WHERE nOnayID = " & nOnayID)
            cmd.ExecuteNonQuery()
            
            ' Gerekli onay sayisini kontrol et
            cmd.CommandText = sorgu_query("SELECT ISNULL(nGerekliOnay, 1) FROM tbUretimAsamaTanim WHERE nAsamaID = " & nAsamaID)
            Dim nGerekliOnay As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            
            cmd.CommandText = sorgu_query("SELECT COUNT(*) FROM tbUretimEmriAsamaOnaylar WHERE nUretimEmriAsamaID = " & nAsamaKayitID & " AND sOnayDurum = 'Onaylandi'")
            Dim nMevcutOnay As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            
            ' Tum onaylar tamamlandiysa asamayi tamamla
            If nMevcutOnay >= nGerekliOnay Then
                cmd.CommandText = sorgu_query("UPDATE tbUretimEmriAsama SET sDurum = 'Tamamlandi', dteBitis = GETDATE() WHERE nID = " & nAsamaKayitID)
                cmd.ExecuteNonQuery()
                
                ' Sonraki asamaya gec
                cmd.CommandText = sorgu_query("SELECT TOP 1 e.nAsamaID, a.sAsamaAdi FROM tbUretimEmriAsama e INNER JOIN tbUretimAsamaTanim a ON e.nAsamaID = a.nAsamaID WHERE e.nUretimEmriID = " & nEvrakNo & " AND e.sDurum = 'Bekliyor' ORDER BY a.nSiraNo")
                dt.Clear()
                adapter.Fill(dt)
                
                If dt.Rows.Count > 0 Then
                    Dim nSonrakiAsamaID As Integer = Convert.ToInt32(dt.Rows(0)("nAsamaID"))
                    Dim sSonrakiAsamaAdi As String = dt.Rows(0)("sAsamaAdi").ToString()
                    
                    cmd.CommandText = sorgu_query("UPDATE tbUretimEmriAsama SET sDurum = 'Devam', dteBaslangic = GETDATE() WHERE nUretimEmriID = " & nEvrakNo & " AND nAsamaID = " & nSonrakiAsamaID)
                    cmd.ExecuteNonQuery()
                    
                    cmd.CommandText = sorgu_query("UPDATE TBLUREURETIM SET nMevcutAsamaID = " & nSonrakiAsamaID & " WHERE EVRAKNO = " & nEvrakNo)
                    cmd.ExecuteNonQuery()
                    
                    ' BILDIRIM - Sonraki asama yetkilisine
                    Try
                        BildirimServisi.UretimSonrakiAsamaBildirimiGonder(nEvrakNo, nSonrakiAsamaID)
                    Catch
                    End Try
                    
                    MessageBox.Show("Onay verildi." & vbCrLf & "Sonraki asama basladi: " & sSonrakiAsamaAdi, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' Tum asamalar bitti
                    cmd.CommandText = sorgu_query("UPDATE TBLUREURETIM SET DURUM = 'Tamamlandi', dteGercekBitis = GETDATE() WHERE EVRAKNO = " & nEvrakNo)
                    cmd.ExecuteNonQuery()
                    
                    MessageBox.Show("TUM ASAMALAR TAMAMLANDI!" & vbCrLf & "Uretim emri basariyla tamamlandi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Onay verildi." & vbCrLf & "Mevcut onay: " & nMevcutOnay & "/" & nGerekliOnay, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            
            con.Close()
            
        Catch ex As Exception
            MessageBox.Show("Onay verme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ''' <summary>
    ''' Asama onayini reddeder
    ''' </summary>
    Public Sub AsamaOnayReddet(ByVal nOnayID As Integer, ByVal sNeden As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = connection
            cmd.Connection = con
            con.Open()
            
            ' Onay bilgilerini al
            cmd.CommandText = sorgu_query("SELECT nUretimEmriID, nAsamaID FROM tbUretimEmriAsamaOnaylar WHERE nOnayID = " & nOnayID)
            Dim adapter As New OleDb.OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            
            If dt.Rows.Count = 0 Then
                MessageBox.Show("Onay kaydý bulunamadý.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                con.Close()
                Exit Sub
            End If
            
            Dim nEvrakNo As Integer = Convert.ToInt32(dt.Rows(0)("nUretimEmriID"))
            Dim nAsamaID As Integer = Convert.ToInt32(dt.Rows(0)("nAsamaID"))
            
            ' Reddet
            cmd.CommandText = sorgu_query("UPDATE tbUretimEmriAsamaOnaylar SET sOnayDurum = 'Reddedildi', nOnaylayanID = " & CInt(KeyCode.kullanici) & ", dteOnayTarihi = GETDATE(), sAciklama = '" & sNeden.Replace("'", "''") & "' WHERE nOnayID = " & nOnayID)
            cmd.ExecuteNonQuery()
            
            ' Uretim emrini durdur
            cmd.CommandText = sorgu_query("UPDATE TBLUREURETIM SET DURUM = 'Beklemede' WHERE EVRAKNO = " & nEvrakNo)
            cmd.ExecuteNonQuery()
            
            ' BILDIRIM
            Try
                Dim cmdAsama As New OleDb.OleDbCommand
                cmdAsama.Connection = con
                cmdAsama.CommandText = sorgu_query("SELECT sAsamaAdi FROM tbUretimAsamaTanim WHERE nAsamaID = " & nAsamaID)
                Dim adapterAsama As New OleDb.OleDbDataAdapter(cmdAsama)
                Dim dtAsama As New DataTable()
                adapterAsama.Fill(dtAsama)
                Dim sAsamaAdi As String = If(dtAsama.Rows.Count > 0, dtAsama.Rows(0)("sAsamaAdi").ToString(), "")
                BildirimServisi.Broadcast("URETIM_ONAY_REDDEDILDI", "Uretim Emri #" & nEvrakNo & vbCrLf & "Asama: " & sAsamaAdi & vbCrLf & "ONAY REDDEDILDI" & vbCrLf & "Neden: " & sNeden, "Onay Reddedildi")
            Catch
            End Try
            
            con.Close()
            
            MessageBox.Show("Onay reddedildi." & vbCrLf & "Uretim emri beklemeye alindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            
        Catch ex As Exception
            MessageBox.Show("Onay reddetme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class