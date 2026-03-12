Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_stok_servis_liste
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
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_renk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Dataset1 As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
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
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBELGENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMANO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMAKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMAADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBELGETIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGIRIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIADE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIPTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKAYITTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSONUC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADRES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEFON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYETKILI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_konum_stok As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_kriter_stok As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara_stok As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DataSet2 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
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
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents DataColumn65 As System.Data.DataColumn
    Friend WithEvents DataColumn66 As System.Data.DataColumn
    Friend WithEvents DataColumn67 As System.Data.DataColumn
    Friend WithEvents DataColumn68 As System.Data.DataColumn
    Friend WithEvents DataColumn69 As System.Data.DataColumn
    Friend WithEvents DataColumn70 As System.Data.DataColumn
    Friend WithEvents DataColumn71 As System.Data.DataColumn
    Friend WithEvents DataColumn72 As System.Data.DataColumn
    Friend WithEvents DataColumn73 As System.Data.DataColumn
    Friend WithEvents DataColumn74 As System.Data.DataColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEVRAKNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colREFNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMALINCINSI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBARCODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGIREN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIKAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBIRIM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTUTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUCRET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGARANTILI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAKSESUAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSERINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colARIZA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMARKA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMODEL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATICI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATISTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATISBELGENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATISBELGETIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSATISDEPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSERVIS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYETKILISATICI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTATUS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSERVISTIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMATIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBASLIKACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colILETISIM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKSERVISTIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_belgeno As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_satici As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_servis As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents sec_kirik As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_musteri As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_irtibat As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_teslimat As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ContextMenu2 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents printlink2 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents sec_garantili As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem17 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem18 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem19 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem20 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem21 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem22 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem23 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem24 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_stok_durum As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ds_stok_islemtipi As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn75 As System.Data.DataColumn
    Friend WithEvents DataColumn76 As System.Data.DataColumn
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents collMevcut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMALIYET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem57 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem54 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem56 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem58 As System.Windows.Forms.MenuItem
    Friend WithEvents BarButtonItem25 As DevExpress.XtraBars.BarButtonItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_servis_liste))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colSTOKSERVISTIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_stok_durum = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.DataTable3 = New System.Data.DataTable()
        Me.DataColumn75 = New System.Data.DataColumn()
        Me.DataColumn76 = New System.Data.DataColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.ContextMenu2 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem57 = New System.Windows.Forms.MenuItem()
        Me.MenuItem54 = New System.Windows.Forms.MenuItem()
        Me.MenuItem55 = New System.Windows.Forms.MenuItem()
        Me.MenuItem56 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MenuItem53 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.MenuItem36 = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.MenuItem38 = New System.Windows.Forms.MenuItem()
        Me.MenuItem39 = New System.Windows.Forms.MenuItem()
        Me.MenuItem40 = New System.Windows.Forms.MenuItem()
        Me.MenuItem41 = New System.Windows.Forms.MenuItem()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem46 = New System.Windows.Forms.MenuItem()
        Me.MenuItem44 = New System.Windows.Forms.MenuItem()
        Me.MenuItem52 = New System.Windows.Forms.MenuItem()
        Me.MenuItem45 = New System.Windows.Forms.MenuItem()
        Me.MenuItem47 = New System.Windows.Forms.MenuItem()
        Me.MenuItem42 = New System.Windows.Forms.MenuItem()
        Me.MenuItem43 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem49 = New System.Windows.Forms.MenuItem()
        Me.MenuItem50 = New System.Windows.Forms.MenuItem()
        Me.MenuItem48 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem51 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem58 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.Dataset1 = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.DataColumn21 = New System.Data.DataColumn()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBELGENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRMANO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRMAKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRMAADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBELGETIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGIRIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIADE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIPTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKAYITTARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSONUC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADRES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTELEFON = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYETKILI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_renk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.DataSet2 = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
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
        Me.DataColumn64 = New System.Data.DataColumn()
        Me.DataColumn65 = New System.Data.DataColumn()
        Me.DataColumn66 = New System.Data.DataColumn()
        Me.DataColumn67 = New System.Data.DataColumn()
        Me.DataColumn68 = New System.Data.DataColumn()
        Me.DataColumn69 = New System.Data.DataColumn()
        Me.DataColumn70 = New System.Data.DataColumn()
        Me.DataColumn71 = New System.Data.DataColumn()
        Me.DataColumn72 = New System.Data.DataColumn()
        Me.DataColumn73 = New System.Data.DataColumn()
        Me.DataColumn74 = New System.Data.DataColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEVRAKNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colREFNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOKNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOKKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMALINCINSI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBARCODE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGIREN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCIKAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBIRIM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTUTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUCRET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGARANTILI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAKSESUAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSERINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colARIZA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMARKA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMODEL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATICI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATISTARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATISBELGENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATISBELGETIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSATISDEPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSERVIS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYETKILISATICI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTATUS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSERVISTIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRMATIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBASLIKACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colILETISIM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMevcut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMALIYET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_garantili = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_teslimat = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_belgeno = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label10 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_satici = New DevExpress.XtraEditors.ButtonEdit()
        Me.txt_servis = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label9 = New DevExpress.XtraEditors.LabelControl()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
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
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.sec_kirik = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_musteri = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_irtibat = New DevExpress.XtraEditors.CheckEdit()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink2 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem25 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem18 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem19 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem20 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem24 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem21 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem22 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem23 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.ds_stok_islemtipi = New System.Data.DataSet()
        CType(Me.sec_stok_durum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dataset1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_garantili.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_teslimat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_belgeno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_satici.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_servis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.sec_kirik.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_musteri.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_irtibat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_stok_islemtipi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colSTOKSERVISTIPI
        '
        Me.colSTOKSERVISTIPI.Caption = "StokDurumu"
        Me.colSTOKSERVISTIPI.ColumnEdit = Me.sec_stok_durum
        Me.colSTOKSERVISTIPI.FieldName = "STOKISLEMTIPI"
        Me.colSTOKSERVISTIPI.Name = "colSTOKSERVISTIPI"
        Me.colSTOKSERVISTIPI.Visible = True
        Me.colSTOKSERVISTIPI.VisibleIndex = 12
        Me.colSTOKSERVISTIPI.Width = 62
        '
        'sec_stok_durum
        '
        Me.sec_stok_durum.AutoHeight = False
        Me.sec_stok_durum.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_stok_durum.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "Açýklama")})
        Me.sec_stok_durum.DataSource = Me.DataTable3
        Me.sec_stok_durum.DisplayMember = "ACIKLAMA"
        Me.sec_stok_durum.Name = "sec_stok_durum"
        Me.sec_stok_durum.ValueMember = "STOKISLEMTIPI"
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn75, Me.DataColumn76})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "STOKISLEMTIPI"
        '
        'DataColumn76
        '
        Me.DataColumn76.ColumnName = "ACIKLAMA"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 22)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 52)
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Appearance.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Servis Ýþlemleri Listesi Aþaðýdadýr."
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton4)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 386)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 43)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Enabled = False
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(83, 9)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton4.TabIndex = 4
        Me.SimpleButton4.Text = "&Ekle"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(176, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(8, 9)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Text = "&Ara F3"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(739, 9)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(664, 9)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
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
        Me.PanelControl3.Size = New System.Drawing.Size(824, 312)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.ContextMenu = Me.ContextMenu2
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 308)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'ContextMenu2
        '
        Me.ContextMenu2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem27, Me.MenuItem28, Me.MenuItem57, Me.MenuItem54, Me.MenuItem55, Me.MenuItem56, Me.MenuItem29, Me.MenuItem30, Me.MenuItem31, Me.MenuItem32, Me.MenuItem33, Me.MenuItem34, Me.MenuItem53, Me.MenuItem35, Me.MenuItem36, Me.MenuItem37, Me.MenuItem38, Me.MenuItem39, Me.MenuItem40, Me.MenuItem41})
        '
        'MenuItem27
        '
        Me.MenuItem27.DefaultItem = True
        Me.MenuItem27.Index = 0
        Me.MenuItem27.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem27.Text = "Tamam"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 1
        Me.MenuItem28.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem28.Text = "Vazgeç"
        '
        'MenuItem57
        '
        Me.MenuItem57.Index = 2
        Me.MenuItem57.Text = "-"
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 3
        Me.MenuItem54.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem54.Text = "Envanter"
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 4
        Me.MenuItem55.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem55.Text = "Stok Hareketleri"
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 5
        Me.MenuItem56.Shortcut = System.Windows.Forms.Shortcut.CtrlF7
        Me.MenuItem56.Text = "Transfer Hareketleri"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 6
        Me.MenuItem29.Text = "-"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 7
        Me.MenuItem30.Text = "Görünümü Düzenle"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 8
        Me.MenuItem31.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 9
        Me.MenuItem32.Text = "Görünümü Kaydet"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 10
        Me.MenuItem33.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem33.Text = "Görünümü Yazdýr"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 11
        Me.MenuItem34.Text = "-"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 12
        Me.MenuItem53.Text = "Hýzlý Filtre"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 13
        Me.MenuItem35.Text = "Filtrele"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 14
        Me.MenuItem36.Text = "Gruplandýr"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 15
        Me.MenuItem37.Text = "-"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 16
        Me.MenuItem38.Text = "Satýrlarý Aç"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 17
        Me.MenuItem39.Text = "Satýrlarý Kapat"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 18
        Me.MenuItem40.Text = "-"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 19
        Me.MenuItem41.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem41.Text = "Ekraný Kapla"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.ContextMenu = Me.ContextMenu1
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(818, 275)
        Me.XtraTabPage1.Text = "Servis Ýþlemleri"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem15, Me.MenuItem2, Me.MenuItem16, Me.MenuItem1, Me.MenuItem3, Me.MenuItem46, Me.MenuItem44, Me.MenuItem52, Me.MenuItem45, Me.MenuItem47, Me.MenuItem42, Me.MenuItem43, Me.MenuItem20, Me.MenuItem49, Me.MenuItem50, Me.MenuItem48, Me.MenuItem25, Me.MenuItem26, Me.MenuItem51, Me.MenuItem4, Me.MenuItem13, Me.MenuItem7, Me.MenuItem8, Me.MenuItem9, Me.MenuItem14, Me.MenuItem58, Me.MenuItem10, Me.MenuItem11, Me.MenuItem18, Me.MenuItem17})
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 0
        Me.MenuItem15.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem15.Text = "Ara"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem2.Text = "Düzenle"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 2
        Me.MenuItem16.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 3
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem1.Text = "Müþterilerden Giriþ"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 4
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlIns
        Me.MenuItem3.Text = "Firmalardan Giriþ"
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 5
        Me.MenuItem46.Text = "-"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 6
        Me.MenuItem44.Text = "Onarým"
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 7
        Me.MenuItem52.Text = "Müþteri Ürünü Onar"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 8
        Me.MenuItem45.Text = "Servis Ýptali"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 9
        Me.MenuItem47.Text = "-"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 10
        Me.MenuItem42.Text = "Servise Ürün Gönder"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 11
        Me.MenuItem43.Text = "Servisten Ürün Giriþi Yap"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 12
        Me.MenuItem20.Text = "-"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 13
        Me.MenuItem49.Text = "Firmaya Müþteri Ürünü Gönder"
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 14
        Me.MenuItem50.Text = "Firmadan Müþteri Ürünü Giriþi Yap"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 15
        Me.MenuItem48.Text = "-"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 16
        Me.MenuItem25.Text = "Müþteriye Teslim Et"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 17
        Me.MenuItem26.Text = "Firmaya Teslim Et"
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 18
        Me.MenuItem51.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Enabled = False
        Me.MenuItem4.Index = 19
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem6, Me.MenuItem12, Me.MenuItem19, Me.MenuItem24, Me.MenuItem21, Me.MenuItem22, Me.MenuItem23})
        Me.MenuItem4.Text = "Raporla"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.Text = "Hata Kaydý Düþülenler"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 1
        Me.MenuItem6.Text = "Açýklama Kaydý Düþülenler"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 2
        Me.MenuItem12.Text = "Okutulmayanlar"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 3
        Me.MenuItem19.Text = "Tümü"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 4
        Me.MenuItem24.Text = "-"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 5
        Me.MenuItem21.Text = "Çýkýþý Yapýlmayan Kredili Satýþlar"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 6
        Me.MenuItem22.Text = "Çýkýþý Yapýlmayan Peþin Satýþlar"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 7
        Me.MenuItem23.Text = "Çýkýþý Yapýlmayan Sonradan Teslimler"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 20
        Me.MenuItem13.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 21
        Me.MenuItem7.Text = "Görünümü Düzenle"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 22
        Me.MenuItem8.Text = "Görünümü Kaydet"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 23
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem9.Text = "Görünümü Yazdýr"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 24
        Me.MenuItem14.Text = "-"
        '
        'MenuItem58
        '
        Me.MenuItem58.Index = 25
        Me.MenuItem58.Text = "Hýzlý Filtrele"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 26
        Me.MenuItem10.Text = "Filtrele"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 27
        Me.MenuItem11.Text = "Gruplandýr"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 28
        Me.MenuItem18.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 29
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem17.Text = "Tam Ekran"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.Dataset1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_renk})
        Me.GridControl1.Size = New System.Drawing.Size(818, 275)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'Dataset1
        '
        Me.Dataset1.DataSetName = "NewDataSet"
        Me.Dataset1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.Dataset1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn20, Me.DataColumn21, Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "IND"
        Me.DataColumn20.DataType = GetType(Long)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "TARIH"
        Me.DataColumn21.DataType = GetType(Date)
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "BELGENO"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "FIRMANO"
        Me.DataColumn2.DataType = GetType(Long)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "FIRMAKODU"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "FIRMAADI"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "BELGETIPI"
        Me.DataColumn5.DataType = GetType(Long)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "ACIKLAMA"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "KOD1"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "KOD2"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "KOD3"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "KOD4"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "KOD5"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "GIRIS"
        Me.DataColumn12.DataType = GetType(Boolean)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "IADE"
        Me.DataColumn13.DataType = GetType(Boolean)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "IPTAL"
        Me.DataColumn14.DataType = GetType(Boolean)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "KAYITTARIHI"
        Me.DataColumn15.DataType = GetType(Date)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "SONUC"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "ADRES"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "TELEFON"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "YETKILI"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.colTARIH, Me.colBELGENO, Me.colFIRMANO, Me.colFIRMAKODU, Me.colFIRMAADI, Me.colBELGETIPI, Me.colACIKLAMA, Me.colKOD1, Me.colKOD2, Me.colKOD3, Me.colKOD4, Me.colKOD5, Me.colGIRIS, Me.colIADE, Me.colIPTAL, Me.colKAYITTARIHI, Me.colSONUC, Me.colADRES, Me.colTELEFON, Me.colYETKILI})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(419, 321, 208, 156)
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", Nothing, "{0:#,0.##}")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colIND
        '
        Me.colIND.Caption = "Kayýt No"
        Me.colIND.FieldName = "IND"
        Me.colIND.Name = "colIND"
        Me.colIND.Visible = True
        Me.colIND.VisibleIndex = 0
        Me.colIND.Width = 45
        '
        'colTARIH
        '
        Me.colTARIH.Caption = "Tarih"
        Me.colTARIH.FieldName = "TARIH"
        Me.colTARIH.Name = "colTARIH"
        Me.colTARIH.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TARIH", "{0} Kayýt")})
        Me.colTARIH.Visible = True
        Me.colTARIH.VisibleIndex = 1
        Me.colTARIH.Width = 68
        '
        'colBELGENO
        '
        Me.colBELGENO.Caption = "Belge No"
        Me.colBELGENO.FieldName = "BELGENO"
        Me.colBELGENO.Name = "colBELGENO"
        Me.colBELGENO.Visible = True
        Me.colBELGENO.VisibleIndex = 3
        Me.colBELGENO.Width = 56
        '
        'colFIRMANO
        '
        Me.colFIRMANO.Caption = "Firma No"
        Me.colFIRMANO.FieldName = "FIRMANO"
        Me.colFIRMANO.Name = "colFIRMANO"
        '
        'colFIRMAKODU
        '
        Me.colFIRMAKODU.Caption = "Firma Kodu"
        Me.colFIRMAKODU.FieldName = "FIRMAKODU"
        Me.colFIRMAKODU.Name = "colFIRMAKODU"
        Me.colFIRMAKODU.Visible = True
        Me.colFIRMAKODU.VisibleIndex = 4
        Me.colFIRMAKODU.Width = 61
        '
        'colFIRMAADI
        '
        Me.colFIRMAADI.Caption = "Firma Adý"
        Me.colFIRMAADI.FieldName = "FIRMAADI"
        Me.colFIRMAADI.Name = "colFIRMAADI"
        Me.colFIRMAADI.Visible = True
        Me.colFIRMAADI.VisibleIndex = 5
        Me.colFIRMAADI.Width = 134
        '
        'colBELGETIPI
        '
        Me.colBELGETIPI.Caption = "Belge Tipi"
        Me.colBELGETIPI.FieldName = "BELGETIPI"
        Me.colBELGETIPI.Name = "colBELGETIPI"
        Me.colBELGETIPI.Visible = True
        Me.colBELGETIPI.VisibleIndex = 2
        Me.colBELGETIPI.Width = 37
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.Caption = "Açýklama"
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 8
        Me.colACIKLAMA.Width = 71
        '
        'colKOD1
        '
        Me.colKOD1.Caption = "1.ÖzelKod"
        Me.colKOD1.FieldName = "KOD1"
        Me.colKOD1.Name = "colKOD1"
        Me.colKOD1.Visible = True
        Me.colKOD1.VisibleIndex = 6
        Me.colKOD1.Width = 69
        '
        'colKOD2
        '
        Me.colKOD2.Caption = "2.ÖzelKod"
        Me.colKOD2.FieldName = "KOD2"
        Me.colKOD2.Name = "colKOD2"
        Me.colKOD2.Visible = True
        Me.colKOD2.VisibleIndex = 7
        Me.colKOD2.Width = 98
        '
        'colKOD3
        '
        Me.colKOD3.Caption = "3.ÖzelKod"
        Me.colKOD3.FieldName = "KOD3"
        Me.colKOD3.Name = "colKOD3"
        '
        'colKOD4
        '
        Me.colKOD4.Caption = "4.ÖzelKod"
        Me.colKOD4.FieldName = "KOD4"
        Me.colKOD4.Name = "colKOD4"
        '
        'colKOD5
        '
        Me.colKOD5.Caption = "5.ÖzelKod"
        Me.colKOD5.FieldName = "KOD5"
        Me.colKOD5.Name = "colKOD5"
        '
        'colGIRIS
        '
        Me.colGIRIS.Caption = "Giriþ"
        Me.colGIRIS.FieldName = "GIRIS"
        Me.colGIRIS.Name = "colGIRIS"
        '
        'colIADE
        '
        Me.colIADE.Caption = "Ýade"
        Me.colIADE.FieldName = "IADE"
        Me.colIADE.Name = "colIADE"
        '
        'colIPTAL
        '
        Me.colIPTAL.Caption = "Ýptal"
        Me.colIPTAL.FieldName = "IPTAL"
        Me.colIPTAL.Name = "colIPTAL"
        '
        'colKAYITTARIHI
        '
        Me.colKAYITTARIHI.Caption = "Kayýt Tarihi"
        Me.colKAYITTARIHI.FieldName = "KAYITTARIHI"
        Me.colKAYITTARIHI.Name = "colKAYITTARIHI"
        '
        'colSONUC
        '
        Me.colSONUC.Caption = "Sonuç"
        Me.colSONUC.FieldName = "SONUC"
        Me.colSONUC.Name = "colSONUC"
        '
        'colADRES
        '
        Me.colADRES.Caption = "Adres"
        Me.colADRES.FieldName = "ADRES"
        Me.colADRES.Name = "colADRES"
        Me.colADRES.Width = 147
        '
        'colTELEFON
        '
        Me.colTELEFON.Caption = "Telefon"
        Me.colTELEFON.FieldName = "TELEFON"
        Me.colTELEFON.Name = "colTELEFON"
        Me.colTELEFON.Width = 147
        '
        'colYETKILI
        '
        Me.colYETKILI.Caption = "Yetkili"
        Me.colYETKILI.FieldName = "YETKILI"
        Me.colYETKILI.Name = "colYETKILI"
        Me.colYETKILI.Width = 176
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
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.PanelControl6)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl5)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(818, 275)
        Me.XtraTabPage2.Text = "Servis/Ürün/Arýza Takip"
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.GridControl2)
        Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl6.Location = New System.Drawing.Point(0, 126)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(818, 125)
        Me.PanelControl6.TabIndex = 2
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "Table1"
        Me.GridControl2.DataSource = Me.DataSet2
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 2)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_stok_durum})
        Me.GridControl2.Size = New System.Drawing.Size(814, 121)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "NewDataSet"
        Me.DataSet2.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet2.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54, Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58, Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64, Me.DataColumn65, Me.DataColumn66, Me.DataColumn67, Me.DataColumn68, Me.DataColumn69, Me.DataColumn70, Me.DataColumn71, Me.DataColumn72, Me.DataColumn73, Me.DataColumn74})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "IND"
        Me.DataColumn22.DataType = GetType(Long)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "EVRAKNO"
        Me.DataColumn23.DataType = GetType(Long)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "REFNO"
        Me.DataColumn24.DataType = GetType(Long)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "STOKNO"
        Me.DataColumn25.DataType = GetType(Long)
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
        Me.DataColumn28.ColumnName = "BARCODE"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "GIREN"
        Me.DataColumn29.DataType = GetType(Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "CIKAN"
        Me.DataColumn30.DataType = GetType(Decimal)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "BIRIM"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "FIYAT"
        Me.DataColumn32.DataType = GetType(Decimal)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "TUTAR"
        Me.DataColumn33.DataType = GetType(Decimal)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "UCRET"
        Me.DataColumn34.DataType = GetType(Decimal)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "GARANTILI"
        Me.DataColumn35.DataType = GetType(Boolean)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "ACIKLAMA"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "AKSESUAR"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "SERINO"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "ARIZA"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "MARKA"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "MODEL"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "SATICI"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "SATISTARIHI"
        Me.DataColumn43.DataType = GetType(Date)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "SATISBELGENO"
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "SATISBELGETIPI"
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "sDepo"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "SATISDEPO"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "SERVIS"
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "YETKILISATICI"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "STATUS"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "KAYITTARIHI"
        Me.DataColumn51.DataType = GetType(Date)
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "SERVISTIPI"
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "TARIH"
        Me.DataColumn53.DataType = GetType(Date)
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "BELGENO"
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "FIRMATIPI"
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "FIRMANO"
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "FIRMAKODU"
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "FIRMAADI"
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "BELGETIPI"
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "BASLIKACIKLAMA"
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "KOD1"
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "KOD2"
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "KOD3"
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "KOD4"
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "KOD5"
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "ILETISIM"
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "GIRIS"
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "IADE"
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "IPTAL"
        '
        'DataColumn70
        '
        Me.DataColumn70.ColumnName = "SONUC"
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "ADRES"
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "TELEFON"
        '
        'DataColumn73
        '
        Me.DataColumn73.ColumnName = "YETKILI"
        '
        'DataColumn74
        '
        Me.DataColumn74.ColumnName = "STOKSERVISTIPI"
        '
        'GridView2
        '
        Me.GridView2.Appearance.Empty.Options.UseBackColor = True
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
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colEVRAKNO, Me.colREFNO, Me.colSTOKNO, Me.colSTOKKODU, Me.colMALINCINSI, Me.colBARCODE, Me.colGIREN, Me.colCIKAN, Me.colBIRIM, Me.colFIYAT, Me.colTUTAR, Me.colUCRET, Me.colGARANTILI, Me.GridColumn2, Me.colAKSESUAR, Me.colSERINO, Me.colARIZA, Me.colMARKA, Me.colMODEL, Me.colSATICI, Me.colSATISTARIHI, Me.colSATISBELGENO, Me.colSATISBELGETIPI, Me.colsDepo, Me.colSATISDEPO, Me.colSERVIS, Me.colYETKILISATICI, Me.colSTATUS, Me.GridColumn3, Me.colSERVISTIPI, Me.GridColumn4, Me.GridColumn5, Me.colFIRMATIPI, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.colBASLIKACIKLAMA, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.colILETISIM, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.colSTOKSERVISTIPI, Me.collMevcut, Me.colMALIYET})
        Me.GridView2.CustomizationFormBounds = New System.Drawing.Rectangle(505, 245, 208, 170)
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle))
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colSTOKSERVISTIPI
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "10"
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colSTOKSERVISTIPI
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "1"
        StyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition3.Appearance.Options.UseForeColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.colSTOKSERVISTIPI
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = "4"
        Me.GridView2.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GIREN", Nothing, "Miktar:{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "STOKKODU", Nothing, "{0} Kayýt")})
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
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Kayýt No"
        Me.GridColumn1.FieldName = "IND"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'colEVRAKNO
        '
        Me.colEVRAKNO.Caption = "Evrak No"
        Me.colEVRAKNO.FieldName = "EVRAKNO"
        Me.colEVRAKNO.Name = "colEVRAKNO"
        '
        'colREFNO
        '
        Me.colREFNO.Caption = "RefNo"
        Me.colREFNO.FieldName = "REFNO"
        Me.colREFNO.Name = "colREFNO"
        '
        'colSTOKNO
        '
        Me.colSTOKNO.Caption = "Stok No"
        Me.colSTOKNO.FieldName = "STOKNO"
        Me.colSTOKNO.Name = "colSTOKNO"
        '
        'colSTOKKODU
        '
        Me.colSTOKKODU.Caption = "Stok Kodu"
        Me.colSTOKKODU.FieldName = "STOKKODU"
        Me.colSTOKKODU.Name = "colSTOKKODU"
        Me.colSTOKKODU.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "STOKKODU", "{0} Kayýt")})
        Me.colSTOKKODU.Visible = True
        Me.colSTOKKODU.VisibleIndex = 0
        Me.colSTOKKODU.Width = 58
        '
        'colMALINCINSI
        '
        Me.colMALINCINSI.Caption = "Stok Adý"
        Me.colMALINCINSI.FieldName = "MALINCINSI"
        Me.colMALINCINSI.Name = "colMALINCINSI"
        Me.colMALINCINSI.Visible = True
        Me.colMALINCINSI.VisibleIndex = 1
        Me.colMALINCINSI.Width = 85
        '
        'colBARCODE
        '
        Me.colBARCODE.Caption = "Barcode"
        Me.colBARCODE.FieldName = "BARCODE"
        Me.colBARCODE.Name = "colBARCODE"
        '
        'colGIREN
        '
        Me.colGIREN.Caption = "Giren"
        Me.colGIREN.DisplayFormat.FormatString = "#,0.##"
        Me.colGIREN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGIREN.FieldName = "GIREN"
        Me.colGIREN.Name = "colGIREN"
        Me.colGIREN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GIREN", "{0:#,0.##}")})
        Me.colGIREN.Visible = True
        Me.colGIREN.VisibleIndex = 2
        Me.colGIREN.Width = 42
        '
        'colCIKAN
        '
        Me.colCIKAN.Caption = "Çýkan"
        Me.colCIKAN.DisplayFormat.FormatString = "#,0.##"
        Me.colCIKAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCIKAN.FieldName = "CIKAN"
        Me.colCIKAN.Name = "colCIKAN"
        '
        'colBIRIM
        '
        Me.colBIRIM.Caption = "Birim"
        Me.colBIRIM.FieldName = "BIRIM"
        Me.colBIRIM.Name = "colBIRIM"
        Me.colBIRIM.Visible = True
        Me.colBIRIM.VisibleIndex = 3
        Me.colBIRIM.Width = 42
        '
        'colFIYAT
        '
        Me.colFIYAT.Caption = "Fiyat"
        Me.colFIYAT.DisplayFormat.FormatString = "#,0.00"
        Me.colFIYAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT.FieldName = "FIYAT"
        Me.colFIYAT.Name = "colFIYAT"
        '
        'colTUTAR
        '
        Me.colTUTAR.Caption = "Tutar"
        Me.colTUTAR.DisplayFormat.FormatString = "#,0.00"
        Me.colTUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTUTAR.FieldName = "TUTAR"
        Me.colTUTAR.Name = "colTUTAR"
        '
        'colUCRET
        '
        Me.colUCRET.Caption = "Ücret"
        Me.colUCRET.FieldName = "UCRET"
        Me.colUCRET.Name = "colUCRET"
        Me.colUCRET.Visible = True
        Me.colUCRET.VisibleIndex = 4
        Me.colUCRET.Width = 42
        '
        'colGARANTILI
        '
        Me.colGARANTILI.Caption = "Garantili?"
        Me.colGARANTILI.FieldName = "GARANTILI"
        Me.colGARANTILI.Name = "colGARANTILI"
        Me.colGARANTILI.Visible = True
        Me.colGARANTILI.VisibleIndex = 5
        Me.colGARANTILI.Width = 42
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Þikayet..."
        Me.GridColumn2.FieldName = "ACIKLAMA"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 6
        Me.GridColumn2.Width = 42
        '
        'colAKSESUAR
        '
        Me.colAKSESUAR.Caption = "Aksesuar"
        Me.colAKSESUAR.FieldName = "AKSESUAR"
        Me.colAKSESUAR.Name = "colAKSESUAR"
        '
        'colSERINO
        '
        Me.colSERINO.Caption = "seriNo"
        Me.colSERINO.FieldName = "SERINO"
        Me.colSERINO.Name = "colSERINO"
        '
        'colARIZA
        '
        Me.colARIZA.Caption = "Arýza"
        Me.colARIZA.FieldName = "ARIZA"
        Me.colARIZA.Name = "colARIZA"
        Me.colARIZA.Visible = True
        Me.colARIZA.VisibleIndex = 7
        Me.colARIZA.Width = 20
        '
        'colMARKA
        '
        Me.colMARKA.Caption = "Marka"
        Me.colMARKA.FieldName = "MARKA"
        Me.colMARKA.Name = "colMARKA"
        '
        'colMODEL
        '
        Me.colMODEL.Caption = "Model"
        Me.colMODEL.FieldName = "MODEL"
        Me.colMODEL.Name = "colMODEL"
        '
        'colSATICI
        '
        Me.colSATICI.Caption = "SatýþýYapan"
        Me.colSATICI.FieldName = "SATICI"
        Me.colSATICI.Name = "colSATICI"
        '
        'colSATISTARIHI
        '
        Me.colSATISTARIHI.Caption = "FaturaTarihi"
        Me.colSATISTARIHI.FieldName = "SATISTARIHI"
        Me.colSATISTARIHI.Name = "colSATISTARIHI"
        '
        'colSATISBELGENO
        '
        Me.colSATISBELGENO.Caption = "FaturaNo"
        Me.colSATISBELGENO.FieldName = "SATISBELGENO"
        Me.colSATISBELGENO.Name = "colSATISBELGENO"
        '
        'colSATISBELGETIPI
        '
        Me.colSATISBELGETIPI.Caption = "FaturaTipi"
        Me.colSATISBELGETIPI.FieldName = "SATISBELGETIPI"
        Me.colSATISBELGETIPI.Name = "colSATISBELGETIPI"
        '
        'colsDepo
        '
        Me.colsDepo.Caption = "Depo"
        Me.colsDepo.FieldName = "sDepo"
        Me.colsDepo.Name = "colsDepo"
        '
        'colSATISDEPO
        '
        Me.colSATISDEPO.Caption = "FaturaDepo"
        Me.colSATISDEPO.FieldName = "SATISDEPO"
        Me.colSATISDEPO.Name = "colSATISDEPO"
        '
        'colSERVIS
        '
        Me.colSERVIS.Caption = "YetkiliServis"
        Me.colSERVIS.FieldName = "SERVIS"
        Me.colSERVIS.Name = "colSERVIS"
        Me.colSERVIS.Visible = True
        Me.colSERVIS.VisibleIndex = 8
        Me.colSERVIS.Width = 21
        '
        'colYETKILISATICI
        '
        Me.colYETKILISATICI.Caption = "YetkiliSatýcý"
        Me.colYETKILISATICI.FieldName = "YETKILISATICI"
        Me.colYETKILISATICI.Name = "colYETKILISATICI"
        Me.colYETKILISATICI.Width = 47
        '
        'colSTATUS
        '
        Me.colSTATUS.Caption = "Durum"
        Me.colSTATUS.FieldName = "STATUS"
        Me.colSTATUS.Name = "colSTATUS"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Kayýt Tarihi"
        Me.GridColumn3.FieldName = "KAYITTARIHI"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'colSERVISTIPI
        '
        Me.colSERVISTIPI.Caption = "Kýrýk?"
        Me.colSERVISTIPI.FieldName = "SERVISTIPI"
        Me.colSERVISTIPI.Name = "colSERVISTIPI"
        Me.colSERVISTIPI.Visible = True
        Me.colSERVISTIPI.VisibleIndex = 9
        Me.colSERVISTIPI.Width = 51
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "ServisTarihi"
        Me.GridColumn4.FieldName = "TARIH"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 10
        Me.GridColumn4.Width = 51
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "ServisNo"
        Me.GridColumn5.FieldName = "BELGENO"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Width = 47
        '
        'colFIRMATIPI
        '
        Me.colFIRMATIPI.Caption = "Müþteri?"
        Me.colFIRMATIPI.FieldName = "FIRMATIPI"
        Me.colFIRMATIPI.Name = "colFIRMATIPI"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Hesap No"
        Me.GridColumn6.FieldName = "FIRMANO"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Hesap Kodu"
        Me.GridColumn7.FieldName = "FIRMAKODU"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Width = 47
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "HesapAdý"
        Me.GridColumn8.FieldName = "FIRMAADI"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 11
        Me.GridColumn8.Width = 77
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "ServisTipi"
        Me.GridColumn9.FieldName = "BELGETIPI"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'colBASLIKACIKLAMA
        '
        Me.colBASLIKACIKLAMA.Caption = "ServisAçýklama"
        Me.colBASLIKACIKLAMA.FieldName = "BASLIKACIKLAMA"
        Me.colBASLIKACIKLAMA.Name = "colBASLIKACIKLAMA"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "1.ÖzelKod"
        Me.GridColumn10.FieldName = "KOD1"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "2.ÖzelKod"
        Me.GridColumn11.FieldName = "KOD2"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "3.ÖzelKod"
        Me.GridColumn12.FieldName = "KOD3"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "4.ÖzelKod"
        Me.GridColumn13.FieldName = "KOD4"
        Me.GridColumn13.Name = "GridColumn13"
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "5.ÖzelKod"
        Me.GridColumn14.FieldName = "KOD5"
        Me.GridColumn14.Name = "GridColumn14"
        '
        'colILETISIM
        '
        Me.colILETISIM.Caption = "Ýletiþim"
        Me.colILETISIM.FieldName = "ILETISIM"
        Me.colILETISIM.Name = "colILETISIM"
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Giriþ?"
        Me.GridColumn15.FieldName = "GIRIS"
        Me.GridColumn15.Name = "GridColumn15"
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Ýade?"
        Me.GridColumn16.FieldName = "IADE"
        Me.GridColumn16.Name = "GridColumn16"
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Ýptal?"
        Me.GridColumn17.FieldName = "IPTAL"
        Me.GridColumn17.Name = "GridColumn17"
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "ServisSonucu"
        Me.GridColumn18.FieldName = "SONUC"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Adres"
        Me.GridColumn19.FieldName = "ADRES"
        Me.GridColumn19.Name = "GridColumn19"
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Telefon"
        Me.GridColumn20.FieldName = "TELEFON"
        Me.GridColumn20.Name = "GridColumn20"
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "YetkiliKiþi"
        Me.GridColumn21.FieldName = "YETKILI"
        Me.GridColumn21.Name = "GridColumn21"
        '
        'collMevcut
        '
        Me.collMevcut.Caption = "Mevcut"
        Me.collMevcut.DisplayFormat.FormatString = "#,0.###"
        Me.collMevcut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMevcut.FieldName = "lMevcut"
        Me.collMevcut.Name = "collMevcut"
        Me.collMevcut.Visible = True
        Me.collMevcut.VisibleIndex = 13
        '
        'colMALIYET
        '
        Me.colMALIYET.Caption = "Maliyet"
        Me.colMALIYET.DisplayFormat.FormatString = "#,0.##"
        Me.colMALIYET.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMALIYET.FieldName = "MALIYET"
        Me.colMALIYET.Name = "colMALIYET"
        Me.colMALIYET.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MALIYET", "{0:#,0.00}")})
        '
        'PanelControl5
        '
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl5.Location = New System.Drawing.Point(0, 251)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(818, 24)
        Me.PanelControl5.TabIndex = 1
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.GroupControl1)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(818, 126)
        Me.PanelControl4.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_garantili)
        Me.GroupControl1.Controls.Add(Me.sec_teslimat)
        Me.GroupControl1.Controls.Add(Me.txt_belgeno)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Controls.Add(Me.txt_satici)
        Me.GroupControl1.Controls.Add(Me.txt_servis)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.Label4)
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
        Me.GroupControl1.Controls.Add(Me.SimpleButton6)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Controls.Add(Me.sec_kirik)
        Me.GroupControl1.Controls.Add(Me.sec_musteri)
        Me.GroupControl1.Controls.Add(Me.sec_irtibat)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(590, 122)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Ara"
        '
        'sec_garantili
        '
        Me.sec_garantili.Location = New System.Drawing.Point(4, 91)
        Me.sec_garantili.Name = "sec_garantili"
        Me.sec_garantili.Properties.Caption = "Garantili?"
        Me.sec_garantili.Size = New System.Drawing.Size(66, 19)
        Me.sec_garantili.TabIndex = 72
        '
        'sec_teslimat
        '
        Me.sec_teslimat.EditValue = "Bekleyen"
        Me.sec_teslimat.EnterMoveNextControl = True
        Me.sec_teslimat.Location = New System.Drawing.Point(249, 91)
        Me.sec_teslimat.Name = "sec_teslimat"
        Me.sec_teslimat.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_teslimat.Properties.Appearance.Options.UseBackColor = True
        Me.sec_teslimat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_teslimat.Properties.Items.AddRange(New Object() {"[Tümü]", "Bekleyen", "TümBekleyen", "TeslimEdilen", "Serviste", "FirmayaGönderilen", "FirmadanGelen", "Onarýlan", "Ýptal"})
        Me.sec_teslimat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_teslimat.Size = New System.Drawing.Size(88, 20)
        Me.sec_teslimat.TabIndex = 71
        '
        'txt_belgeno
        '
        Me.txt_belgeno.EnterMoveNextControl = True
        Me.txt_belgeno.Location = New System.Drawing.Point(400, 25)
        Me.txt_belgeno.Name = "txt_belgeno"
        Me.txt_belgeno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_belgeno.Size = New System.Drawing.Size(120, 20)
        Me.txt_belgeno.TabIndex = 70
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(352, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Belge:"
        '
        'txt_satici
        '
        Me.txt_satici.EnterMoveNextControl = True
        Me.txt_satici.Location = New System.Drawing.Point(400, 69)
        Me.txt_satici.Name = "txt_satici"
        Me.txt_satici.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_satici.Size = New System.Drawing.Size(120, 20)
        Me.txt_satici.TabIndex = 68
        '
        'txt_servis
        '
        Me.txt_servis.EnterMoveNextControl = True
        Me.txt_servis.Location = New System.Drawing.Point(400, 47)
        Me.txt_servis.Name = "txt_servis"
        Me.txt_servis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_servis.Size = New System.Drawing.Size(120, 20)
        Me.txt_servis.TabIndex = 67
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(352, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Servis:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(352, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Satýcý:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Stoklar:"
        '
        'sec_konum_stok
        '
        Me.sec_konum_stok.EditValue = "Kod"
        Me.sec_konum_stok.EnterMoveNextControl = True
        Me.sec_konum_stok.Location = New System.Drawing.Point(184, 47)
        Me.sec_konum_stok.Name = "sec_konum_stok"
        Me.sec_konum_stok.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum_stok.Properties.Items.AddRange(New Object() {"Kod", "Ad"})
        Me.sec_konum_stok.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum_stok.Size = New System.Drawing.Size(83, 20)
        Me.sec_konum_stok.TabIndex = 52
        '
        'sec_kriter_stok
        '
        Me.sec_kriter_stok.EditValue = "Baþlar"
        Me.sec_kriter_stok.EnterMoveNextControl = True
        Me.sec_kriter_stok.Location = New System.Drawing.Point(267, 47)
        Me.sec_kriter_stok.Name = "sec_kriter_stok"
        Me.sec_kriter_stok.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter_stok.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter_stok.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter_stok.Size = New System.Drawing.Size(70, 20)
        Me.sec_kriter_stok.TabIndex = 53
        '
        'txt_ara_stok
        '
        Me.txt_ara_stok.EnterMoveNextControl = True
        Me.txt_ara_stok.Location = New System.Drawing.Point(72, 47)
        Me.txt_ara_stok.Name = "txt_ara_stok"
        Me.txt_ara_stok.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara_stok.Properties.Appearance.Options.UseFont = True
        Me.txt_ara_stok.Properties.MaxLength = 15
        Me.txt_ara_stok.Size = New System.Drawing.Size(112, 20)
        Me.txt_ara_stok.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Hesaplar:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(270, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "arasýndaki"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Tarih:"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(184, 25)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(83, 20)
        Me.DateEdit2.TabIndex = 50
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(72, 25)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(96, 20)
        Me.DateEdit1.TabIndex = 49
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Adý"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(184, 69)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Kodu", "Adý"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(83, 20)
        Me.sec_konum.TabIndex = 55
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(398, 91)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(122, 20)
        Me.SimpleButton6.TabIndex = 57
        Me.SimpleButton6.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(267, 69)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(70, 20)
        Me.sec_kriter.TabIndex = 56
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(72, 69)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(112, 20)
        Me.txt_ara.TabIndex = 54
        '
        'sec_kirik
        '
        Me.sec_kirik.Location = New System.Drawing.Point(200, 91)
        Me.sec_kirik.Name = "sec_kirik"
        Me.sec_kirik.Properties.Caption = "Kýrýk?"
        Me.sec_kirik.Size = New System.Drawing.Size(49, 19)
        Me.sec_kirik.TabIndex = 48
        '
        'sec_musteri
        '
        Me.sec_musteri.Location = New System.Drawing.Point(70, 91)
        Me.sec_musteri.Name = "sec_musteri"
        Me.sec_musteri.Properties.Caption = "Müþteri?"
        Me.sec_musteri.Size = New System.Drawing.Size(66, 19)
        Me.sec_musteri.TabIndex = 47
        '
        'sec_irtibat
        '
        Me.sec_irtibat.Location = New System.Drawing.Point(136, 91)
        Me.sec_irtibat.Name = "sec_irtibat"
        Me.sec_irtibat.Properties.Caption = "Ýrtibatlý?"
        Me.sec_irtibat.Size = New System.Drawing.Size(64, 19)
        Me.sec_irtibat.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(165, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "ve"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"", "Servis Ýþlemleri Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"[User Name]", "Stok Servis Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
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
        Me.printlink2.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink2.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Ürün Servis/Arýza/Kýrýk  Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Servis Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink2.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink2.PrintingSystem = Me.ps
        Me.printlink2.PrintingSystemBase = Me.ps
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarSubItem2, Me.BarSubItem3, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem15, Me.BarButtonItem16, Me.BarSubItem4, Me.BarButtonItem17, Me.BarButtonItem18, Me.BarButtonItem19, Me.BarButtonItem20, Me.BarButtonItem21, Me.BarButtonItem22, Me.BarButtonItem23, Me.BarButtonItem24, Me.BarButtonItem25})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 29
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem3, True)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Custom 3"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Tanýmlar"
        Me.BarSubItem1.Id = 0
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem16)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Servis Tanýmlarý"
        Me.BarButtonItem1.Id = 3
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Personel Tanýmlarý"
        Me.BarButtonItem2.Id = 4
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Ýþlem Kodu Tanýmlarý"
        Me.BarButtonItem3.Id = 5
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem16
        '
        Me.BarButtonItem16.Caption = "Arýza Tipleri"
        Me.BarButtonItem16.Id = 18
        Me.BarButtonItem16.Name = "BarButtonItem16"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Raporlar"
        Me.BarSubItem2.Id = 1
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem25)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Faaliyet Raporu"
        Me.BarButtonItem4.Id = 6
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Müþteri Þikayetleri"
        Me.BarButtonItem5.Id = 7
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Müþteriden Giriþler"
        Me.BarButtonItem6.Id = 8
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Müþteriye Teslim Edilenler"
        Me.BarButtonItem7.Id = 9
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Servise Gönderilenler"
        Me.BarButtonItem8.Id = 10
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Servisten Gelenler"
        Me.BarButtonItem9.Id = 11
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem25
        '
        Me.BarButtonItem25.Caption = "Ürün Daðýlýmý"
        Me.BarButtonItem25.Id = 28
        Me.BarButtonItem25.Name = "BarButtonItem25"
        '
        'BarSubItem4
        '
        Me.BarSubItem4.Caption = "Ýþlemler"
        Me.BarSubItem4.Id = 19
        Me.BarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem17), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem18), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem19, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem20), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem24, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem21), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem22, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem23)})
        Me.BarSubItem4.Name = "BarSubItem4"
        '
        'BarButtonItem17
        '
        Me.BarButtonItem17.Caption = "Müþteriden Giriþ"
        Me.BarButtonItem17.Id = 20
        Me.BarButtonItem17.Name = "BarButtonItem17"
        '
        'BarButtonItem18
        '
        Me.BarButtonItem18.Caption = "Firmadan Giriþ"
        Me.BarButtonItem18.Id = 21
        Me.BarButtonItem18.Name = "BarButtonItem18"
        '
        'BarButtonItem19
        '
        Me.BarButtonItem19.Caption = "Servise Ürün Çýkýþ"
        Me.BarButtonItem19.Id = 22
        Me.BarButtonItem19.Name = "BarButtonItem19"
        '
        'BarButtonItem20
        '
        Me.BarButtonItem20.Caption = "Servisten Ürün Giriþ"
        Me.BarButtonItem20.Id = 23
        Me.BarButtonItem20.Name = "BarButtonItem20"
        '
        'BarButtonItem24
        '
        Me.BarButtonItem24.Caption = "Onarým"
        Me.BarButtonItem24.Id = 27
        Me.BarButtonItem24.Name = "BarButtonItem24"
        '
        'BarButtonItem21
        '
        Me.BarButtonItem21.Caption = "Servis Ýptali"
        Me.BarButtonItem21.Id = 24
        Me.BarButtonItem21.Name = "BarButtonItem21"
        '
        'BarButtonItem22
        '
        Me.BarButtonItem22.Caption = "Müþteri Teslim Et"
        Me.BarButtonItem22.Id = 25
        Me.BarButtonItem22.Name = "BarButtonItem22"
        '
        'BarButtonItem23
        '
        Me.BarButtonItem23.Caption = "Firmaya Gönder"
        Me.BarButtonItem23.Id = 26
        Me.BarButtonItem23.Name = "BarButtonItem23"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "Analiz"
        Me.BarSubItem3.Id = 2
        Me.BarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem14), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem15)})
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Þikayet Analizi"
        Me.BarButtonItem10.Id = 12
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Servis Analizi"
        Me.BarButtonItem11.Id = 13
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Ürün Grubu Analizi"
        Me.BarButtonItem12.Id = 14
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Personel Analizi"
        Me.BarButtonItem13.Id = 15
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "Satýþ Personeli Analizi"
        Me.BarButtonItem14.Id = 16
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "Kasiyer Analizi"
        Me.BarButtonItem15.Id = 17
        Me.BarButtonItem15.Name = "BarButtonItem15"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 429)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 407)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 407)
        '
        'ds_stok_islemtipi
        '
        Me.ds_stok_islemtipi.DataSetName = "NewDataSet"
        Me.ds_stok_islemtipi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_stok_islemtipi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'frm_stok_servis_liste
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_servis_liste"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servis Fiþleri"
        CType(Me.sec_stok_durum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dataset1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_garantili.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_teslimat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_belgeno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_satici.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_servis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.sec_kirik.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_musteri.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_irtibat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_stok_islemtipi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public status As Boolean = False
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
    Public ilktarih
    Public sontarih
    Public ilkbelge
    Public sonbelge
    Public firmakodu
    Public firmaadi
    Public personel
    Public depo
    Public parabirimi
    Public kur
    Public aciklama
    Public kdvdahil
    Public kapali
    Public qilktarih
    Public qsontarih
    Public qilkbelge
    Public qsonbelge
    Public qfirmakodu
    Public qfirmaadi
    Public qpersonel
    Public qparabirimi
    Public qkur
    Public qaciklama
    Public qkdvdahil
    Public qkapali
    Dim dr As DataRow
    Dim count
    Public mevcut
    Public yeni
    Public nTur As String = ""
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Private Sub frm_stok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Hide()
        DateEdit1.EditValue = dteSistemTarihi '"01/01/" + Today.Year.ToString
        DateEdit2.EditValue = dteSistemTarihi '"31/12/" + Today.Year.ToString
        If status = False Then
            count = ""
            Dim frm As New frm_fatura_ara
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.rowSTOKKODU.Visible = False
            frm.rowMALINCINSI.Visible = False
            frm.kullanici = kullanici
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                kayitno = frm.kayitno
                ilktarih = frm.ilktarih
                sontarih = frm.sontarih
                ilkbelge = frm.ilkbelge
                sonbelge = frm.sonbelge
                firmakodu = frm.firmakodu
                firmaadi = frm.firmaadi
                parabirimi = frm.parabirimi
                kur = frm.kur
                personel = frm.personel
                depo = frm.depo
                kod1 = frm.kod1
                kod2 = frm.kod2
                kdvdahil = frm.kdvdahil
                kapali = frm.kapali
                qkayitno = frm.qkayitno
                qilktarih = frm.qilktarih
                qsontarih = frm.qsontarih
                qilkbelge = frm.qilkbelge
                qsonbelge = frm.qsonbelge
                qfirmakodu = frm.qfirmakodu
                qfirmaadi = frm.qfirmaadi
                qparabirimi = frm.qparabirimi
                qkur = frm.qkur
                qpersonel = frm.qpersonel
                qdepo = frm.qdepo
                qkod1 = frm.qkod1
                qkod2 = frm.qkod2
                qkdvdahil = frm.qkdvdahil
                qkapali = frm.qkapali
                Dataset1.Clear()
                Dataset1.Dispose()
                dataload()
                frm.DataSet1.Clear()
                frm.DataSet1.Dispose()
                frm.DataSet1 = Nothing
                frm.SimpleButton1 = Nothing
                frm.SimpleButton2 = Nothing
                frm.PanelControl1.Dispose()
                frm.PanelControl1 = Nothing
                frm.PanelControl2.Dispose()
                frm.PanelControl2 = Nothing
                frm.PanelControl3.Dispose()
                frm.PanelControl3 = Nothing
                frm.PictureBox1.Dispose()
                frm.PictureBox1 = Nothing
                frm.VGridControl1.Dispose()
                frm.VGridControl1 = Nothing
                frm.XtraTabControl1.Dispose()
                frm.XtraTabControl1 = Nothing
                frm.XtraTabPage1.Dispose()
                frm.XtraTabPage1 = Nothing
                frm.Label1.Dispose()
                frm.Label1 = Nothing
                frm.Dispose()
                frm.Close()
                frm = Nothing
                'Me.Show()
            Else
                Try
                    Me.Close()
                Catch ex As Exception
                End Try
            End If
        End If
        'stok_islemleri.firmano = firmano
        'stok_islemleri.donemno = donemno
        'stok_islemleri.connection = connection
        'If GridView1.RowCount = 0 Then
        'ElseIf GridView1.RowCount = 1 Then
        '    'If sil = False Then
        '    '    sorgu()
        '    'End If
        'Else
        'End If
        If kullanici = 1 Or kullanici = 1 Or kullanici = 2 Or kullanici = 3 Or kullanici = 70 Or kullanici = 58 Or kullanici = 6 Or kullanici = 84 Or kullanici = 66 Or kullanici = 76 Then
            colMALIYET.FieldName = "MALIYET"
        Else
            colMALIYET.FieldName = "lMaliyet"
        End If
        stok_islem_tipleri()
        Try
            gorunum_yukle()
            gorunum_yukle_urun()
        Catch ex As Exception
        End Try
    End Sub
    Public Sub nTurAc()
        If nTur = "Müþterilerden Giriþ" Then
            stok_yeni()
        ElseIf nTur = "Firmalardan Giriþ" Then
            stok_yeni(True)
        ElseIf nTur = "Ürün Onarýmý" Then
            stok_yeni_servis_onarim(True)
        ElseIf nTur = "Müþteri Ürünü Onar" Then
            stok_yeni_servis_onarim()
        ElseIf nTur = "Servis Ýptali" Then
        ElseIf nTur = "Servise Ürün Gönder" Then
            stok_yeni_servisecikis(True)
        ElseIf nTur = "Servisten Ürün Giriþi Yap" Then
            stok_yeni_servistengiris(True)
        ElseIf nTur = "Müþteriye Teslim Et" Then
            stok_yeni_teslimat()
        ElseIf nTur = "Firmaya Teslim Et" Then
            stok_yeni_teslimat(True)
        ElseIf nTur = "Servis Tanýmlarý" Then
            servis_listesi()
        ElseIf nTur = "Personel Tanýmlarý" Then
        ElseIf nTur = "Ýþlem Kodu Tanýmlarý" Then
        ElseIf nTur = "Arýza Tipleri" Then
            ariza_tipleri()
        End If
        nTur = ""
    End Sub
    Private Sub stok_islem_tipleri()
        Dim dr1 As DataRow = ds_stok_islemtipi.Tables(0).NewRow
        dr1(0) = 0
        dr1(1) = "Bekliyor"
        ds_stok_islemtipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_stok_islemtipi.Tables(0).NewRow()
        dr1(0) = 1
        dr1(1) = "Serviste"
        ds_stok_islemtipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_stok_islemtipi.Tables(0).NewRow()
        dr1(0) = 2
        dr1(1) = "ServistenGeldi"
        ds_stok_islemtipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_stok_islemtipi.Tables(0).NewRow()
        dr1(0) = 3
        dr1(1) = "Onarýldý"
        ds_stok_islemtipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_stok_islemtipi.Tables(0).NewRow()
        dr1(0) = 4
        dr1(1) = "Firmada"
        ds_stok_islemtipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_stok_islemtipi.Tables(0).NewRow()
        dr1(0) = 5
        dr1(1) = "FirmadanGeldi"
        ds_stok_islemtipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_stok_islemtipi.Tables(0).NewRow()
        dr1(0) = 9
        dr1(1) = "TeslimEdildi"
        ds_stok_islemtipi.Tables(0).Rows.Add(dr1)
        dr1 = ds_stok_islemtipi.Tables(0).NewRow()
        dr1(0) = 10
        dr1(1) = "Ýptal"
        ds_stok_islemtipi.Tables(0).Rows.Add(dr1)
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "")
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
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        SimpleButton4.Text = Sorgu_sDil(SimpleButton4.Text, sDil)
        SimpleButton6.Text = Sorgu_sDil(SimpleButton6.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "")
    End Sub
    Private Sub gorunum_kaydet_urun()
        GridView2.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\SERVIS\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle_urun()
        Try
            If nFontSize > 0 Then
                Dim sayi As Single = nFontSize
                GridView2.Appearance.Row.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView2.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                'VGrid_Baslik.Appearance.RecordValue.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                sayi = Nothing
            End If
        Catch ex As Exception
        End Try
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView2.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        GridView2.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\SERVIS\" & Me.Name.ToString & "")
    End Sub
    Private Sub dataload_depo()
        sec_renk.DataSource = sorgu(sorgu_query("SELECT * FROM tbRenk")).Tables(0) 'DataSet2.Tables(0)
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
    Private Sub ara()
        Dim frm As New frm_fatura_ara
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.rowSTOKKODU.Visible = False
        frm.rowMALINCINSI.Visible = False
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            kayitno = frm.kayitno
            ilktarih = frm.ilktarih
            sontarih = frm.sontarih
            ilkbelge = frm.ilkbelge
            sonbelge = frm.sonbelge
            firmakodu = frm.firmakodu
            firmaadi = frm.firmaadi
            parabirimi = frm.parabirimi
            kur = frm.kur
            personel = frm.personel
            depo = frm.depo
            kod1 = frm.kod1
            kod2 = frm.kod2
            kdvdahil = frm.kdvdahil
            kapali = frm.kapali
            qkayitno = frm.qkayitno
            qilktarih = frm.qilktarih
            qsontarih = frm.qsontarih
            qilkbelge = frm.qilkbelge
            qsonbelge = frm.qsonbelge
            qfirmakodu = frm.qfirmakodu
            qfirmaadi = frm.qfirmaadi
            qparabirimi = frm.qparabirimi
            qkur = frm.qkur
            qpersonel = frm.qpersonel
            qdepo = frm.qdepo
            qkod1 = frm.qkod1
            qkod2 = frm.qkod2
            qkdvdahil = frm.qkdvdahil
            qkapali = frm.qkapali
            Dataset1.Clear()
            Dataset1.Dispose()
            dataload()
        Else
            Me.Close()
        End If
        frm.DataSet1.Clear()
        frm.DataSet1.Dispose()
        frm.DataSet1 = Nothing
        frm.SimpleButton1 = Nothing
        frm.SimpleButton2 = Nothing
        frm.PanelControl1.Dispose()
        frm.PanelControl1 = Nothing
        frm.PanelControl2.Dispose()
        frm.PanelControl2 = Nothing
        frm.PanelControl3.Dispose()
        frm.PanelControl3 = Nothing
        frm.PictureBox1.Dispose()
        frm.PictureBox1 = Nothing
        frm.VGridControl1.Dispose()
        frm.VGridControl1 = Nothing
        frm.XtraTabControl1.Dispose()
        frm.XtraTabControl1 = Nothing
        frm.XtraTabPage1.Dispose()
        frm.XtraTabPage1 = Nothing
        frm.Label1.Dispose()
        frm.Label1 = Nothing
        frm.Dispose()
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub sorgu()
        If GridView1.RowCount > 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
        System.GC.Collect()
        System.GC.GetTotalMemory(True)
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub dataload()
        dataload_depo()
        Dataset1 = stok()
        GridControl1.DataSource = Dataset1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub stok_yeni(Optional ByVal firmatipi As Boolean = False)
        Dim frm As New frm_stok_servis
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.firmatipi = firmatipi
        frm.kullanici = kullanici
        frm.yeni = True
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
        dataload()
    End Sub
    Private Sub stok_yeni_teslimat(Optional ByVal firmatipi As Boolean = False)
        Dim frm As New frm_stok_servis_teslimat
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.firmatipi = firmatipi
        frm.kullanici = kullanici
        frm.yeni = True
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
        dataload()
    End Sub
    Private Sub stok_yeni_servisecikis(Optional ByVal firmatipi As Boolean = False)
        Dim frm As New frm_stok_servis_servisecikis
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.firmatipi = firmatipi
        frm.kullanici = kullanici
        frm.yeni = True
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
        dataload()
    End Sub
    Private Sub stok_yeni_servistengiris(Optional ByVal firmatipi As Boolean = False)
        Dim frm As New frm_stok_servis_servistengiris
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.firmatipi = firmatipi
        frm.kullanici = kullanici
        frm.yeni = True
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
        dataload()
    End Sub
    Private Sub stok_yeni_servis_onarim(Optional ByVal firmatipi As Boolean = False)
        Dim frm As New frm_stok_servis_onarim
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.firmatipi = firmatipi
        frm.kullanici = kullanici
        frm.yeni = True
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
        dataload()
    End Sub
    Private Sub stok_duzelt()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("BELGETIPI") = "K" Then
                Dim frm As New frm_stok_servis
                frm.connection = connection
                frm.firmano = firmano
                frm.donemno = donemno
                frm.belgeind = dr("IND")
                frm.status = True
                frm.kullanici = kullanici
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
            ElseIf dr("BELGETIPI") = "T" Then
                Dim frm As New frm_stok_servis_teslimat
                frm.connection = connection
                frm.firmano = firmano
                frm.donemno = donemno
                frm.belgeind = dr("IND")
                frm.status = True
                frm.kullanici = kullanici
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
            ElseIf dr("BELGETIPI") = "SC" Then
                Dim frm As New frm_stok_servis_servisecikis
                frm.connection = connection
                frm.firmano = firmano
                frm.donemno = donemno
                frm.belgeind = dr("IND")
                frm.status = True
                frm.kullanici = kullanici
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
            ElseIf dr("BELGETIPI") = "SG" Then
                Dim frm As New frm_stok_servis_servistengiris
                frm.connection = connection
                frm.firmano = firmano
                frm.donemno = donemno
                frm.belgeind = dr("IND")
                frm.status = True
                frm.kullanici = kullanici
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
            ElseIf dr("BELGETIPI") = "O" Then
                Dim frm As New frm_stok_servis_onarim
                frm.connection = connection
                frm.firmano = firmano
                frm.donemno = donemno
                frm.belgeind = dr("IND")
                frm.status = True
                frm.kullanici = kullanici
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
            End If
            Dim satir = GridView1.FocusedRowHandle
            dataload()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub stok_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            'dr = DataSet1.Tables(0).Rows(0)
            'stok_islemleri.kart_sil(dr("IND"), False)
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
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            dataload()
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        sorgu()
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
        kriter = "WHERE (IND> 0) AND FIRMANO <> 0"
        'If stokkodu <> "" Then
        '    kriter += " AND (STOKKODU " & sorgu_kriter_string(stokkodu, qstokkodu) & ")"
        'End If
        'If malincinsi <> "" Then
        '    kriter += " AND (MALINCINSI " & sorgu_kriter_string(malincinsi, qmalincinsi) & ")"
        'End If
        'If barkod <> "" Then
        '    kriter += " AND (BARKOD " & sorgu_kriter_string(barkod, qbarkod) & ")"
        'End If
        If kayitno <> "" Then
            kriter += " AND (IND " & sorgu_kriter_string(kayitno, qkayitno) & ")"
        End If
        If ilktarih <> "" And sontarih <> "" Then
            kriter += " AND (TARIH BETWEEN '" & ilktarih & "' AND '" & sontarih & "')"
        End If
        If ilkbelge <> "" And sonbelge = "" Then
            kriter += " AND (BELGENO LIKE '" & ilkbelge & " %')"
        ElseIf ilkbelge <> "" And sonbelge <> "" Then
            kriter += " AND (BELGENO BETWEEN '" & ilkbelge & " ' AND '" & sonbelge & "')"
        End If
        If firmakodu <> "" Then
            kriter += " AND (FIRMAKODU " & sorgu_kriter_string(firmakodu, qfirmakodu) & " )"
        End If
        If firmaadi <> "" Then
            kriter += " AND (FIRMAADI " & sorgu_kriter_string(firmaadi, qfirmaadi) & " )"
        End If
        If kod1 <> "" Then
            kriter += " AND (KOD1 " & sorgu_kriter_string(kod1, qkod1) & " )"
        End If
        If kod2 <> "" Then
            kriter += " AND (KOD2 " & sorgu_kriter_string(kod2, qkod2) & " )"
        End If
        If aciklama <> "" Then
            kriter += " AND (ACIKLAMA " & sorgu_kriter_string(aciklama, qaciklama) & " )"
        End If
        If depo <> "" Then
            kriter += " AND (DEPO " & sorgu_kriter_string(depo, qdepo) & " )"
        End If
        'If personel <> "" Then
        '    kriter += " AND (PERSONEL  " & sorgu_kriter_string(depo, qdepo) & " )"
        'End If
        'If kapali <> "" Then
        '    If kapali = True Then
        '        kapali = "1"
        '    Else
        '        kapali = "2"
        '    End If
        '    kriter += " AND (Baslik.sGirisCikis " & sorgu_kriter_string(kapali, qkapali) & " )"
        'End If
        'If gelismis <> "" Then
        '    kriter += " AND (stok.skodu " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (stok.saciklama " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (barkod.sbarkod " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (stok.srenk " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (stok.sbeden " & sorgu_kriter_string(gelismis, qgelismis) & ") "
        'End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM ASTOKSERVISBASLIK " & kriter & " ORDER BY IND DESC")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function stok_servis(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara_stok As String, ByVal konum_stok As String, ByVal ara_kriter_stok As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal musteri As Boolean, ByVal irtibat As Boolean, ByVal teslimat As String, ByVal kirik As Boolean, ByVal belgeno As String, ByVal servis As String, ByVal satici As String, ByVal garantili As Boolean) As DataSet
        Dim kriter
        kriter = "WHERE (BASLIK.IND> 0) AND BASLIK.FIRMANO <> 0 AND BASLIK.TARIH BETWEEN '" & tarih1 & "' AND '" & tarih2 & "'"
        If ara_stok.ToString <> "" Then
            If konum_stok = "Kod" Then
                kriter += " AND( HAREKET.STOKKODU " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf konum_stok = "Ad" Then
                kriter += " AND ( HAREKET.MALINCINSI " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            End If
        End If
        If ara.ToString <> "" Then
            If sec_konum.Text = "Kodu" Then
                kriter += " AND( BASLIK.FIRMAKODU " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Adý" Then
                kriter += " AND( BASLIK.FIRMAADI " & sorgu_kriter_string(ara, ara_kriter) & " )"
            End If
        End If
        Dim kriter2 As String = ""
        If teslimat = "[Tümü]" Then
        ElseIf teslimat = "Bekleyen" Then
            kriter2 = " WHERE STOKISLEMTIPI IN(0,2) "
        ElseIf teslimat = "TümBekleyen" Then
            kriter2 = " WHERE STOKISLEMTIPI IN(0,1,2) "
        ElseIf teslimat = "Serviste" Then
            kriter2 = " WHERE STOKISLEMTIPI IN(1) "
        ElseIf teslimat = "TeslimEdilen" Then
            kriter2 = " WHERE STOKISLEMTIPI IN(9) "
        ElseIf teslimat = "Onarýlan" Then
            kriter2 = " WHERE STOKISLEMTIPI IN(3) "
        ElseIf teslimat = "Ýptal" Then
            kriter2 = " WHERE STOKISLEMTIPI IN(10) "
        ElseIf teslimat = "FirmayaGönderilen" Then
            kriter2 = " WHERE STOKISLEMTIPI IN(4) "
        ElseIf teslimat = "FirmadanGelen" Then
            kriter2 = " WHERE STOKISLEMTIPI IN(5) "
        End If
        If kirik = True Then
            kriter += " AND ( HAREKET.SERVISTIPI =1 )"
        End If
        If garantili = True Then
            kriter += " AND ( HAREKET.GARANTILI =1 )"
        End If
        If musteri = True Then
            kriter += " AND (BASLIK.FIRMATIPI =0 )"
        End If
        If irtibat = True Then
            kriter += " AND (BASLIK.ILETISIM <> '' )"
        End If
        If satici <> "" Then
            kriter += " AND ( HAREKET.YETKILISATICI ='" & satici & "' )"
        End If
        If servis <> "" Then
            kriter += " AND ( HAREKET.SERVIS ='" & servis & "' )"
        End If
        'If stokkodu <> "" Then
        '    kriter += " AND (STOKKODU " & sorgu_kriter_string(stokkodu, qstokkodu) & ")"
        'End If
        'If malincinsi <> "" Then
        '    kriter += " AND (MALINCINSI " & sorgu_kriter_string(malincinsi, qmalincinsi) & ")"
        'End If
        'If barkod <> "" Then
        '    kriter += " AND (BARKOD " & sorgu_kriter_string(barkod, qbarkod) & ")"
        'End If
        'If kayitno <> "" Then
        '    kriter += " AND (IND " & sorgu_kriter_string(kayitno, qkayitno) & ")"
        'End If
        'If ilktarih <> "" And sontarih <> "" Then
        '    kriter += " AND (TARIH BETWEEN '" & ilktarih & "' AND '" & sontarih & "')"
        'End If
        'If ilkbelge <> "" And sonbelge = "" Then
        '    kriter += " AND (BELGENO LIKE '" & ilkbelge & " %')"
        'ElseIf ilkbelge <> "" And sonbelge <> "" Then
        '    kriter += " AND (BELGENO BETWEEN '" & ilkbelge & " ' AND '" & sonbelge & "')"
        'End If
        'If firmakodu <> "" Then
        '    kriter += " AND (FIRMAKODU " & sorgu_kriter_string(firmakodu, qfirmakodu) & " )"
        'End If
        'If firmaadi <> "" Then
        '    kriter += " AND (FIRMAADI " & sorgu_kriter_string(firmaadi, qfirmaadi) & " )"
        'End If
        'If kod1 <> "" Then
        '    kriter += " AND (KOD1 " & sorgu_kriter_string(kod1, qkod1) & " )"
        'End If
        'If kod2 <> "" Then
        '    kriter += " AND (KOD2 " & sorgu_kriter_string(kod2, qkod2) & " )"
        'End If
        'If aciklama <> "" Then
        '    kriter += " AND (ACIKLAMA " & sorgu_kriter_string(aciklama, qaciklama) & " )"
        'End If
        'If depo <> "" Then
        '    kriter += " AND (DEPO " & sorgu_kriter_string(depo, qdepo) & " )"
        'End If
        'If personel <> "" Then
        '    kriter += " AND (PERSONEL  " & sorgu_kriter_string(depo, qdepo) & " )"
        'End If
        'If kapali <> "" Then
        '    If kapali = True Then
        '        kapali = "1"
        '    Else
        '        kapali = "2"
        '    End If
        '    kriter += " AND (Baslik.sGirisCikis " & sorgu_kriter_string(kapali, qkapali) & " )"
        'End If
        'If gelismis <> "" Then
        '    kriter += " AND (stok.skodu " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (stok.saciklama " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (barkod.sbarkod " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (stok.srenk " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (stok.sbeden " & sorgu_kriter_string(gelismis, qgelismis) & ") "
        'End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM ASTOKSERVISBASLIK " & kriter & " ORDER BY IND DESC")
        cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT HAREKET.* , (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE HAREKET.STOKNO = tbStokFisiDetayi.nStokID) AS lMevcut,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = HAREKET.STOKNO AND sFiyatTipi = '" & sFiyatM & "'),0) AS MALIYET,(SELECT TOP 1 ISLEMTIPI FROM ASTOKSERVISHAREKETLERI WHERE REFNO = HAREKET.IND AND REFBASLIK = HAREKET.EVRAKNO ORDER BY ISLEMTIPI DESC) AS STOKISLEMTIPI , BASLIK.TARIH AS TARIH , BASLIK.BELGENO AS BELGENO , BASLIK.FIRMATIPI , BASLIK.FIRMANO , BASLIK.FIRMAKODU , BASLIK.FIRMAADI , BASLIK.BELGETIPI , BASLIK.ACIKLAMA AS BASLIKACIKLAMA , BASLIK.KOD1 , BASLIK.KOD2 , BASLIK.KOD3 , BASLIK.KOD4 , BASLIK.KOD5 , BASLIK.ILETISIM , BASLIK.GIRIS , BASLIK.IADE , BASLIK.IPTAL , BASLIK.SONUC , BASLIK.ADRES , BASLIK.TELEFON , BASLIK.YETKILI FROM ASTOKSERVISDETAY HAREKET INNER JOIN ASTOKSERVISBASLIK BASLIK ON HAREKET.EVRAKNO = BASLIK.IND  " & kriter & ") T " & kriter2 & " ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    'Public Function stok_servis(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara_stok As String, ByVal konum_stok As String, ByVal ara_kriter_stok As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal musteri As Boolean, ByVal irtibat As Boolean, ByVal teslimat As String, ByVal kirik As Boolean, ByVal belgeno As String, ByVal servis As String, ByVal satici As String, ByVal garantili As Boolean) As DataSet
    '    Dim kriter
    '    'kriter = "WHERE (BASLIK.IND> 0) AND BASLIK.FIRMANO <> 0 AND BASLIK.TARIH BETWEEN '" & tarih1 & "' AND '" & tarih2 & "'"
    '    'If ara_stok.ToString <> "" Then
    '    '    If konum_stok = "Kod" Then
    '    '        kriter += " AND( HAREKET.STOKKODU " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
    '    '    ElseIf konum_stok = "Ad" Then
    '    '        kriter += " AND ( HAREKET.MALINCINSI " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
    '    '    End If
    '    'End If
    '    'If ara.ToString <> "" Then
    '    '    If sec_konum.Text = "Kodu" Then
    '    '        kriter += " AND( BASLIK.FIRMAKODU " & sorgu_kriter_string(ara, ara_kriter) & " )"
    '    '    ElseIf sec_konum.Text = "Adý" Then
    '    '        kriter += " AND( BASLIK.FIRMAADI " & sorgu_kriter_string(ara, ara_kriter) & " )"
    '    '    End If
    '    'End If
    '    'Dim kriter2 As String = ""
    '    'If teslimat = "[Tümü]" Then
    '    'ElseIf teslimat = "Bekleyen" Then
    '    '    kriter2 = " WHERE STOKISLEMTIPI IN(0,2) "
    '    'ElseIf teslimat = "TümBekleyen" Then
    '    '    kriter2 = " WHERE STOKISLEMTIPI IN(0,1,2) "
    '    'ElseIf teslimat = "Serviste" Then
    '    '    kriter2 = " WHERE STOKISLEMTIPI IN(1) "
    '    'ElseIf teslimat = "TeslimEdilen" Then
    '    '    kriter2 = " WHERE STOKISLEMTIPI IN(9) "
    '    'ElseIf teslimat = "Onarýlan" Then
    '    '    'kriter2 = " WHERE STOKISLEMTIPI IN(3) "
    '    '    kriter2 = " WHERE BELGETIPI = 'K' "
    '    'ElseIf teslimat = "Ýptal" Then
    '    '    kriter2 = " WHERE STOKISLEMTIPI IN(10) "
    '    'ElseIf teslimat = "FirmayaGönderilen" Then
    '    '    kriter2 = " WHERE STOKISLEMTIPI IN(4) "
    '    'ElseIf teslimat = "FirmadanGelen" Then
    '    '    kriter2 = " WHERE STOKISLEMTIPI IN(5) "
    '    'End If
    '    'If kirik = True Then
    '    '    kriter += " AND ( HAREKET.SERVISTIPI =1 )"
    '    'End If
    '    'If garantili = True Then
    '    '    kriter += " AND ( HAREKET.GARANTILI =1 )"
    '    'End If
    '    'If musteri = True Then
    '    '    kriter += " AND (BASLIK.FIRMATIPI =0 )"
    '    'End If
    '    'If irtibat = True Then
    '    '    kriter += " AND (BASLIK.ILETISIM <> '' )"
    '    'End If
    '    'If satici <> "" Then
    '    '    kriter += " AND ( HAREKET.YETKILISATICI ='" & satici & "' )"
    '    'End If
    '    'If servis <> "" Then
    '    '    kriter += " AND ( HAREKET.SERVIS ='" & servis & "' )"
    '    'End If
    '    kriter = "WHERE (HAREKET.IND > 0) AND HAREKET.FIRMANO <> 0 AND HAREKET.TARIH BETWEEN '" & tarih1 & "' AND '" & tarih2 & "'"
    '    If ara_stok.ToString <> "" Then
    '        If konum_stok = "Kod" Then
    '            kriter += " AND (STOK.STOKKODU " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
    '        ElseIf konum_stok = "Ad" Then
    '            kriter += " AND (STOK.MALINCINSI " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
    '        End If
    '    End If
    '    If ara.ToString <> "" Then
    '        If sec_konum.Text = "Kodu" Then
    '            kriter += " AND (HAREKET.FIRMANO IN (Select ASTOKSERVISBASLIK.FIRMANO From ASTOKSERVISBASLIK Where ASTOKSERVISBASLIK.FIRMAKODU " & sorgu_kriter_string(ara, ara_kriter) & "))"
    '        ElseIf sec_konum.Text = "Adý" Then
    '            kriter += " AND (HAREKET.FIRMANO IN (Select ASTOKSERVISBASLIK.FIRMANO From ASTOKSERVISBASLIK Where ASTOKSERVISBASLIK.FIRMAADI " & sorgu_kriter_string(ara, ara_kriter) & "))"
    '        End If
    '    End If
    '    Dim kriter2 As String = ""
    '    If teslimat = "[Tümü]" Then
    '    ElseIf teslimat = "Bekleyen" Then
    '        kriter2 = " AND HAREKET.ISLEMTIPI IN(0, 2) "
    '    ElseIf teslimat = "TümBekleyen" Then
    '        kriter2 = " AND HAREKET.ISLEMTIPI IN(0, 1, 2) "
    '    ElseIf teslimat = "Serviste" Then
    '        kriter2 = " AND HAREKET.ISLEMTIPI IN(1) "
    '    ElseIf teslimat = "TeslimEdilen" Then
    '        kriter2 = " AND HAREKET.ISLEMTIPI IN(9) "
    '    ElseIf teslimat = "Onarýlan" Then
    '        kriter2 = " AND HAREKET.ISLEMTIPI IN(3) "
    '    ElseIf teslimat = "Ýptal" Then
    '        kriter2 = " AND HAREKET.ISLEMTIPI IN(10) "
    '    ElseIf teslimat = "FirmayaGönderilen" Then
    '        kriter2 = " AND HAREKET.ISLEMTIPI IN(4) "
    '    ElseIf teslimat = "FirmadanGelen" Then
    '        kriter2 = " AND HAREKET.ISLEMTIPI IN(5) "
    '    End If
    '    If kirik = True Then
    '        kriter += " AND (STOK.SERVISTIPI = 1)"
    '    End If
    '    If garantili = True Then
    '        kriter += " AND (STOK.GARANTILI = 1)"
    '    End If
    '    If musteri = True Then
    '        kriter += " AND (FIRMATIPI = 0)"
    '    End If
    '    If irtibat = True Then
    '        kriter += " AND (ILETISIM <> '')"
    '    End If
    '    If satici <> "" Then
    '        kriter += " AND (STOK.YETKILISATICI ='" & satici & "')"
    '    End If
    '    If servis <> "" Then
    '        kriter += " AND (STOK.SERVIS ='" & servis & "')"
    '    End If
    '    'If stokkodu <> "" Then
    '    '    kriter += " AND (STOKKODU " & sorgu_kriter_string(stokkodu, qstokkodu) & ")"
    '    'End If
    '    'If malincinsi <> "" Then
    '    '    kriter += " AND (MALINCINSI " & sorgu_kriter_string(malincinsi, qmalincinsi) & ")"
    '    'End If
    '    'If barkod <> "" Then
    '    '    kriter += " AND (BARKOD " & sorgu_kriter_string(barkod, qbarkod) & ")"
    '    'End If
    '    'If kayitno <> "" Then
    '    '    kriter += " AND (IND " & sorgu_kriter_string(kayitno, qkayitno) & ")"
    '    'End If
    '    'If ilktarih <> "" And sontarih <> "" Then
    '    '    kriter += " AND (TARIH BETWEEN '" & ilktarih & "' AND '" & sontarih & "')"
    '    'End If
    '    'If ilkbelge <> "" And sonbelge = "" Then
    '    '    kriter += " AND (BELGENO LIKE '" & ilkbelge & " %')"
    '    'ElseIf ilkbelge <> "" And sonbelge <> "" Then
    '    '    kriter += " AND (BELGENO BETWEEN '" & ilkbelge & " ' AND '" & sonbelge & "')"
    '    'End If
    '    'If firmakodu <> "" Then
    '    '    kriter += " AND (FIRMAKODU " & sorgu_kriter_string(firmakodu, qfirmakodu) & " )"
    '    'End If
    '    'If firmaadi <> "" Then
    '    '    kriter += " AND (FIRMAADI " & sorgu_kriter_string(firmaadi, qfirmaadi) & " )"
    '    'End If
    '    'If kod1 <> "" Then
    '    '    kriter += " AND (KOD1 " & sorgu_kriter_string(kod1, qkod1) & " )"
    '    'End If
    '    'If kod2 <> "" Then
    '    '    kriter += " AND (KOD2 " & sorgu_kriter_string(kod2, qkod2) & " )"
    '    'End If
    '    'If aciklama <> "" Then
    '    '    kriter += " AND (ACIKLAMA " & sorgu_kriter_string(aciklama, qaciklama) & " )"
    '    'End If
    '    'If depo <> "" Then
    '    '    kriter += " AND (DEPO " & sorgu_kriter_string(depo, qdepo) & " )"
    '    'End If
    '    'If personel <> "" Then
    '    '    kriter += " AND (PERSONEL  " & sorgu_kriter_string(depo, qdepo) & " )"
    '    'End If
    '    'If kapali <> "" Then
    '    '    If kapali = True Then
    '    '        kapali = "1"
    '    '    Else
    '    '        kapali = "2"
    '    '    End If
    '    '    kriter += " AND (Baslik.sGirisCikis " & sorgu_kriter_string(kapali, qkapali) & " )"
    '    'End If
    '    'If gelismis <> "" Then
    '    '    kriter += " AND (stok.skodu " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (stok.saciklama " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (barkod.sbarkod " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (stok.srenk " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (stok.sbeden " & sorgu_kriter_string(gelismis, qgelismis) & ") "
    '    'End If
    '    Dim conn As New OleDb.OleDbConnection
    '    Dim cmd As New OleDb.OleDbCommand
    '    Dim adapter As New OleDb.OleDbDataAdapter
    '    conn.ConnectionString = connection
    '    adapter.SelectCommand = cmd
    '    'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM ASTOKSERVISBASLIK " & kriter & " ORDER BY IND DESC")
    '    'cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT HAREKET.* , (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE HAREKET.STOKNO = tbStokFisiDetayi.nStokID) AS lMevcut,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = HAREKET.STOKNO AND sFiyatTipi = '" & sFiyatM & "'),0) AS MALIYET,(SELECT TOP 1 ISLEMTIPI FROM ASTOKSERVISHAREKETLERI WHERE REFNO = HAREKET.IND AND REFBASLIK = HAREKET.EVRAKNO ORDER BY ISLEMTIPI DESC) AS STOKISLEMTIPI , BASLIK.TARIH AS TARIH , BASLIK.BELGENO AS BELGENO , BASLIK.FIRMATIPI , BASLIK.FIRMANO , BASLIK.FIRMAKODU , BASLIK.FIRMAADI , BASLIK.BELGETIPI , BASLIK.ACIKLAMA AS BASLIKACIKLAMA , BASLIK.KOD1 , BASLIK.KOD2 , BASLIK.KOD3 , BASLIK.KOD4 , BASLIK.KOD5 , BASLIK.ILETISIM , BASLIK.GIRIS , BASLIK.IADE , BASLIK.IPTAL , BASLIK.SONUC , BASLIK.ADRES , BASLIK.TELEFON , BASLIK.YETKILI FROM ASTOKSERVISDETAY HAREKET INNER JOIN ASTOKSERVISBASLIK BASLIK ON HAREKET.EVRAKNO = BASLIK.IND  " & kriter & ") T " & kriter2 & " ")
    '    cmd.CommandText = sorgu_query("Set Dateformat DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT STOK.*, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) FROM tbStokFisiDetayi WHERE STOK.STOKNO = tbStokFisiDetayi.nStokID) AS lMevcut, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = STOK.STOKNO AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, HAREKET.ISLEMTIPI AS STOKISLEMTIPI, HAREKET.IND, HAREKET.ISLEMTIPI, HAREKET.TARIH AS TARIH, HAREKET.BELGENO AS BELGENO, (Select Top 1 ASTOKSERVISBASLIK.FIRMATIPI From ASTOKSERVISBASLIK Where ASTOKSERVISBASLIK.FIRMANO = HAREKET.FIRMANO) AS FIRMATIPI, HAREKET.FIRMANO, (Select Top 1 ASTOKSERVISBASLIK.FIRMAKODU From ASTOKSERVISBASLIK Where ASTOKSERVISBASLIK.FIRMANO = HAREKET.FIRMANO) AS FIRMAKODU, (Select Top 1 ASTOKSERVISBASLIK.FIRMAADI From ASTOKSERVISBASLIK Where ASTOKSERVISBASLIK.FIRMANO = HAREKET.FIRMANO) AS FIRMAADI, HAREKET.BELGETIPI, HAREKET.ACIKLAMA AS BASLIKACIKLAMA, (Select Top 1 ASTOKSERVISBASLIK.KOD1 From ASTOKSERVISBASLIK Where ASTOKSERVISBASLIK.IND = HAREKET.EVRAKNO) AS KOD1, (Select Top 1 ASTOKSERVISBASLIK.KOD2 From ASTOKSERVISBASLIK Where ASTOKSERVISBASLIK.IND = HAREKET.EVRAKNO) AS KOD2,(Select Top 1 ASTOKSERVISBASLIK.KOD3 From ASTOKSERVISBASLIK Where ASTOKSERVISBASLIK.IND = HAREKET.EVRAKNO) AS KOD3,(Select Top 1 ASTOKSERVISBASLIK.KOD4 From ASTOKSERVISBASLIK Where ASTOKSERVISBASLIK.IND = HAREKET.EVRAKNO) AS KOD4,(Select Top 1 ASTOKSERVISBASLIK.KOD5 From ASTOKSERVISBASLIK Where ASTOKSERVISBASLIK.IND = HAREKET.EVRAKNO) AS KOD5,(Select Top 1 ASTOKSERVISBASLIK.ILETISIM From ASTOKSERVISBASLIK Where ASTOKSERVISBASLIK.IND = HAREKET.EVRAKNO) AS ILETISIM,(Select Top 1 ASTOKSERVISBASLIK.GIRIS From ASTOKSERVISBASLIK Where ASTOKSERVISBASLIK.IND = HAREKET.EVRAKNO) AS GIRIS,(Select Top 1 ASTOKSERVISBASLIK.IADE From ASTOKSERVISBASLIK Where ASTOKSERVISBASLIK.IND = HAREKET.EVRAKNO) AS IADE,(Select Top 1 ASTOKSERVISBASLIK.IPTAL From ASTOKSERVISBASLIK Where ASTOKSERVISBASLIK.IND = HAREKET.EVRAKNO) AS IPTAL,(Select Top 1 ASTOKSERVISBASLIK.SONUC From ASTOKSERVISBASLIK Where ASTOKSERVISBASLIK.IND = HAREKET.EVRAKNO) AS SONUC,(Select Top 1 ASTOKSERVISBASLIK.ADRES From ASTOKSERVISBASLIK Where ASTOKSERVISBASLIK.IND = HAREKET.EVRAKNO) AS ADRES,(Select Top 1 ASTOKSERVISBASLIK.TELEFON From ASTOKSERVISBASLIK Where ASTOKSERVISBASLIK.IND = HAREKET.EVRAKNO) AS TELEFON,(Select Top 1 ASTOKSERVISBASLIK.YETKILI From ASTOKSERVISBASLIK Where ASTOKSERVISBASLIK.IND = HAREKET.EVRAKNO) AS YETKILI FROM ASTOKSERVISHAREKETLERI HAREKET INNER JOIN ASTOKSERVISDETAY STOK ON HAREKET.REFNO = STOK.IND " & kriter & " " & kriter2 & "")
    '    cmd.Connection = conn
    '    conn.Open()
    '    Dim Datastoklar1 As New DataSet
    '    Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
    '    conn.Close()
    '    Return Datastoklar1
    'End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub analiz_envanter_model()
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
    End Sub
    Private Sub analiz_hareket()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'stkdll.firmano = firmano
        'stkdll.donemno = donemno
        'stkdll.connection = connection
        'stkdll.stokno = dr("IND")
        'stkdll.rptfiyatanalizi(dr("IND"), 100, dr("MALINCINSI"), 2)
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
            frm.sRenk = "" 'dr("sRenk")
            frm.sBeden = "" 'dr("sBeden")
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
                dr = Dataset1.Tables(0).NewRow
                dr1 = GridView1.GetDataRow(s)
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
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        ara()
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        stok_duzelt()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            stok_duzelt()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        stok_duzelt()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        stok_yeni()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
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
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_envanter()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_envanter_model()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stok_fiyat()
    End Sub
    Private Sub frm_stok_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
        Me.Hide()
        'Me.Hide()
        'PanelControl1.Dispose()
        'PanelControl2.Dispose()
        ''PanelControl3.Dispose()
        'SimpleButton1.Dispose()
        'SimpleButton2.Dispose()
        'SimpleButton3.Dispose()
        'ContextMenu1.Dispose()
        'PanelControl1 = Nothing
        'PanelControl2 = Nothing
        ''PanelControl3 = Nothing
        'SimpleButton1 = Nothing
        'SimpleButton2 = Nothing
        'SimpleButton3 = Nothing
        'ContextMenu1 = Nothing
        'status = Nothing
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
        ''XtraTabPage1.Dispose()
        ''XtraTabPage1 = Nothing
        ''stok_islemleri = Nothing
        ''stkdll = Nothing
        'dr = Nothing
        'count = Nothing
        'ps.ClearContent()
        'ps.Dispose()
        'ps = Nothing
        'printlink1.Dispose()
        'printlink1 = Nothing
        'System.GC.Collect()
        'System.GC.GetTotalMemory(True)
        'System.GC.SuppressFinalize(Me)
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
        stok_yeni(True)
    End Sub
    Private Sub servis_listesi()
        Dim frm As New frm_stok_servisci
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub ariza_tipleri()
        Dim frm As New frm_stok_servis_arizatipleri
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub firma()
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            txt_satici.Text = dr1("sKodu")
        End If
    End Sub
    Private Sub servis()
        Dim frm As New frm_stok_servisci
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            txt_servis.Text = dr1("KODU")
        End If
    End Sub
    Private Sub analiz_stok_dagilim()
        Dim frm As New frm_stok_servis_dagilim
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.tarih1 = Today
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        stok_yeni()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        servis_listesi()
    End Sub
    Private Sub BarButtonItem16_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        ariza_tipleri()
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        stok_yeni_teslimat()
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        stok_yeni_teslimat(True)
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        DataSet2 = stok_servis(DateEdit1.EditValue, DateEdit2.EditValue, txt_ara_stok.Text, sec_konum_stok.Text, sec_kriter_stok.Text, txt_ara.Text, sec_konum.Text, sec_kriter.Text, sec_musteri.Checked, sec_irtibat.Checked, sec_teslimat.Text, sec_kirik.Checked, Trim(txt_belgeno.Text), Trim(txt_servis.Text), Trim(txt_satici.Text), sec_garantili.Checked)
        GridControl2.DataSource = DataSet2.Tables(0)
        GridControl2.DataMember = Nothing
        GridControl2.Refresh()
        GridControl2.Focus()
        GridControl2.Select()
    End Sub
    Private Sub txt_satici_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_satici.ButtonPressed
        firma()
    End Sub
    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        printlink2.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        GridView2.ColumnsCustomization()
    End Sub
    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView2.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        GridView2.OptionsView.ShowGroupPanel = True
        GridView2.OptionsCustomization.AllowGroup = True
    End Sub
    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        GridView2.ExpandAllGroups()
    End Sub
    Private Sub MenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem39.Click
        GridView2.CollapseAllGroups()
    End Sub
    Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        gorunum_kaydet_urun()
    End Sub
    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem42.Click
        stok_yeni_servisecikis(True)
    End Sub
    Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem43.Click
        stok_yeni_servistengiris(True)
    End Sub
    Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem44.Click
        stok_yeni_servis_onarim(True)
    End Sub
    Private Sub txt_servis_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_servis.KeyDown
        If e.KeyCode = Keys.F4 Then
            servis()
        ElseIf e.KeyCode = Keys.Space Then
            servis()
        End If
    End Sub
    Private Sub txt_servis_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_servis.ButtonPressed
        servis()
    End Sub
    Private Sub txt_satici_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_satici.KeyDown
        If e.KeyCode = Keys.F4 Then
            firma()
        ElseIf e.KeyCode = Keys.Space Then
            firma()
        End If
    End Sub
    Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem49.Click
        stok_yeni_servisecikis(False)
    End Sub
    Private Sub MenuItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem50.Click
        stok_yeni_servistengiris(False)
    End Sub
    Private Sub MenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem52.Click
        stok_yeni_servis_onarim()
    End Sub
    Private Sub GridView2_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView2.SelectionChanged
        If GridView2.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView2.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView2.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView2.SelectedRowsCount
        ElseIf GridView2.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView2.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView2.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub BarButtonItem25_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        analiz_stok_dagilim()
    End Sub
    Private Sub MenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem53.Click
        If MenuItem53.Checked = False Then
            GridView2.OptionsView.ShowAutoFilterRow = True
            GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView2.OptionsCustomization.AllowFilter = True
            MenuItem53.Checked = True
        ElseIf MenuItem53.Checked = True Then
            GridView2.OptionsView.ShowAutoFilterRow = False
            GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView2.OptionsCustomization.AllowFilter = False
            MenuItem53.Checked = False
        End If
    End Sub
    Private Sub MenuItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem54.Click
        analiz_envanter()
    End Sub
    Private Sub analiz_envanter()
        If GridView2.RowCount > 0 Then
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
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
        End If
    End Sub
    Private Sub analiz_hareket_transfer()
        If GridView2.RowCount > 0 Then
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri_transfer
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            'frm.stokno = dr("nStokId")
            frm.stokkodu = Trim(dr("STOKKODU"))
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
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("STOKKODU")
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
            frm.Label1.Text = dr("MALINCINSI") & vbCrLf & frm.Label1.Text
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub MenuItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem55.Click
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem56.Click
        analiz_hareket_transfer()
    End Sub
    Private Sub MenuItem58_Click(sender As System.Object, e As System.EventArgs) Handles MenuItem58.Click
        If MenuItem58.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem58.Checked = True
        ElseIf MenuItem58.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem58.Checked = False
        End If
    End Sub
End Class