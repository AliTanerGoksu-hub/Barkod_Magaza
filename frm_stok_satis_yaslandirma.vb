Imports System.Windows.Forms
Imports DevExpress.XtraExport
Imports DevExpress.XtraGrid.Export
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraPivotGrid
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_stok_satis_yaslandirma
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
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_konum_stok As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_kriter_stok As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara_stok As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
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
    Friend WithEvents Panelstatus As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bar2 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents barlabel2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents barlabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bar As DevExpress.XtraEditors.ProgressBarControl
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
    Friend WithEvents fieldnAlisverisID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldnMusteriID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlKodu As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsMusteriAdi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fielddteTarih As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldfisTipi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlNo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldnStokID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsKodu As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsStokAciklama As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMiktar As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFiyat As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldIskonto As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlNetTutar As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsOdemeKodu As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsFiyatTipi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsSaticiRumuzu As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsKasiyerRumuzu As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldnGirisCikis As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsMagaza As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsRenk As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldORAN1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPESIN As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldALTIAY As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldONAY As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldKAR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFARK As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNORMALFIYAT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldNORMALTUTAR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMALIYET As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldFIYATFARKI As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldKAT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMSINIF1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMSINIF2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMSINIF3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMSINIF4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMSINIF5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSSINIF1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSSINIF2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSSINIF3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSSINIF4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldSSINIF5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents GridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sirala As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ceTopValuesShowOthers As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents icbField As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents seTop As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents fieldSatici As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents sec_MaliyetTipi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents fieldsRenkAdi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsSemt As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsIl As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsUlke As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsVergiDairesi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlPrimTutari As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsKat As DevExpress.XtraPivotGrid.PivotGridField
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_satis_yaslandirma))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.sec_MaliyetTipi = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label10 = New DevExpress.XtraEditors.LabelControl
        Me.Label3 = New DevExpress.XtraEditors.LabelControl
        Me.sec_konum_stok = New DevExpress.XtraEditors.ComboBoxEdit
        Me.sec_kriter_stok = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txt_ara_stok = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New DevExpress.XtraEditors.LabelControl
        Me.Label6 = New DevExpress.XtraEditors.LabelControl
        Me.Label7 = New DevExpress.XtraEditors.LabelControl
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label8 = New DevExpress.XtraEditors.LabelControl
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.Label4 = New DevExpress.XtraEditors.LabelControl
        Me.sec_sirala = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label9 = New DevExpress.XtraEditors.LabelControl
        Me.ceTopValuesShowOthers = New DevExpress.XtraEditors.CheckEdit
        Me.icbField = New DevExpress.XtraEditors.ComboBoxEdit
        Me.seTop = New DevExpress.XtraEditors.SpinEdit
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.Panelstatus = New DevExpress.XtraEditors.PanelControl
        Me.bar2 = New DevExpress.XtraEditors.ProgressBarControl
        Me.barlabel2 = New DevExpress.XtraEditors.LabelControl
        Me.barlabel = New DevExpress.XtraEditors.LabelControl
        Me.bar = New DevExpress.XtraEditors.ProgressBarControl
        Me.GridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.DataSet1 = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.DataColumn6 = New System.Data.DataColumn
        Me.DataColumn7 = New System.Data.DataColumn
        Me.DataColumn8 = New System.Data.DataColumn
        Me.DataColumn9 = New System.Data.DataColumn
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
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.fieldnAlisverisID = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldnMusteriID = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldlKodu = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsMusteriAdi = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fielddteTarih = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldfisTipi = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldlNo = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldnStokID = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsKodu = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsStokAciklama = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMiktar = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFiyat = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldIskonto = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldlNetTutar = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsOdemeKodu = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsFiyatTipi = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsSaticiRumuzu = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsKasiyerRumuzu = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldnGirisCikis = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsMagaza = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsRenk = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldORAN1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldPESIN = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldALTIAY = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldONAY = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldKAR = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFARK = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNORMALFIYAT = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldNORMALTUTAR = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMALIYET = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldFIYATFARKI = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldKAT = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMSINIF1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMSINIF2 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMSINIF3 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMSINIF4 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldMSINIF5 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSSINIF1 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSSINIF2 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSSINIF3 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSSINIF4 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSSINIF5 = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldSatici = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsKat = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsRenkAdi = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsSemt = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsIl = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsUlke = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsVergiDairesi = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldlPrimTutari = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsGun = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsHafta = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsAy = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsQuarter = New DevExpress.XtraPivotGrid.PivotGridField
        Me.fieldsYil = New DevExpress.XtraPivotGrid.PivotGridField
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar4 = New DevExpress.XtraBars.Bar
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_MaliyetTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum_stok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter_stok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara_stok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.sec_sirala.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceTopValuesShowOthers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icbField.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seTop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelstatus.SuspendLayout()
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.Size = New System.Drawing.Size(824, 123)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_MaliyetTipi)
        Me.GroupControl1.Controls.Add(Me.Label10)
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
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(451, 119)
        Me.GroupControl1.TabIndex = 38
        Me.GroupControl1.Text = "Ara"
        '
        'sec_MaliyetTipi
        '
        Me.sec_MaliyetTipi.EditValue = "Stok Kartýndan"
        Me.sec_MaliyetTipi.EnterMoveNextControl = True
        Me.sec_MaliyetTipi.Location = New System.Drawing.Point(56, 94)
        Me.sec_MaliyetTipi.Name = "sec_MaliyetTipi"
        Me.sec_MaliyetTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_MaliyetTipi.Properties.Items.AddRange(New Object() {"Stok Kartýndan", "Maliyetlendirmeden"})
        Me.sec_MaliyetTipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_MaliyetTipi.Size = New System.Drawing.Size(196, 20)
        Me.sec_MaliyetTipi.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(12, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Maliyet:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(13, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Stoklar:"
        '
        'sec_konum_stok
        '
        Me.sec_konum_stok.EditValue = "Kod"
        Me.sec_konum_stok.EnterMoveNextControl = True
        Me.sec_konum_stok.Location = New System.Drawing.Point(168, 54)
        Me.sec_konum_stok.Name = "sec_konum_stok"
        Me.sec_konum_stok.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum_stok.Properties.Items.AddRange(New Object() {"Kod", "Ad", "Barkod", "Sýnýf1", "Sýnýf2", "Sýnýf3", "Sýnýf4", "Sýnýf5"})
        Me.sec_konum_stok.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum_stok.Size = New System.Drawing.Size(83, 20)
        Me.sec_konum_stok.TabIndex = 3
        '
        'sec_kriter_stok
        '
        Me.sec_kriter_stok.EditValue = "Baþlar"
        Me.sec_kriter_stok.EnterMoveNextControl = True
        Me.sec_kriter_stok.Location = New System.Drawing.Point(251, 54)
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
        Me.txt_ara_stok.Location = New System.Drawing.Point(56, 54)
        Me.txt_ara_stok.Name = "txt_ara_stok"
        Me.txt_ara_stok.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara_stok.Properties.Appearance.Options.UseFont = True
        Me.txt_ara_stok.Properties.MaxLength = 15
        Me.txt_ara_stok.Size = New System.Drawing.Size(112, 20)
        Me.txt_ara_stok.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(4, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Hesaplar:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(254, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "arasýndaki"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(22, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Tarih:"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(168, 34)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit2.Size = New System.Drawing.Size(83, 20)
        Me.DateEdit2.TabIndex = 1
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(56, 34)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DateEdit1.Size = New System.Drawing.Size(96, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Adý+Soyadý"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(168, 74)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Adý+Soyadý", "Kodu", "Adý", "Soyadý", "Ýstihbarat", "EvAdresi", "ÝþAdresi", "EvTelefonu", "ÝþTelefonu", "Gsm", "DoðumYeri", "1.Kefil Adý", "2.Kefil Adý", "Sýnýf1", "Sýnýf2", "Sýnýf3", "Sýnýf4", "Sýnýf5"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(83, 20)
        Me.sec_konum.TabIndex = 6
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = Global.business_smart.My.Resources.Resources.find
        Me.SimpleButton3.Location = New System.Drawing.Point(251, 94)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 20)
        Me.SimpleButton3.TabIndex = 9
        Me.SimpleButton3.Text = "&Listele"
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(56, 74)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(112, 20)
        Me.txt_ara.TabIndex = 5
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(251, 74)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(64, 20)
        Me.sec_kriter.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(151, 34)
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
        Me.lbl_istihbarat.Location = New System.Drawing.Point(547, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(275, 119)
        Me.lbl_istihbarat.TabIndex = 33
        Me.lbl_istihbarat.Text = "istihbarat..."
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
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
        Me.PictureBox1.Size = New System.Drawing.Size(94, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label4)
        Me.PanelControl2.Controls.Add(Me.sec_sirala)
        Me.PanelControl2.Controls.Add(Me.Label9)
        Me.PanelControl2.Controls.Add(Me.ceTopValuesShowOthers)
        Me.PanelControl2.Controls.Add(Me.icbField)
        Me.PanelControl2.Controls.Add(Me.seTop)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 350)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 56)
        Me.PanelControl2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(176, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Sýrala :"
        '
        'sec_sirala
        '
        Me.sec_sirala.EditValue = "lNetTutar"
        Me.sec_sirala.EnterMoveNextControl = True
        Me.sec_sirala.Location = New System.Drawing.Point(216, 30)
        Me.sec_sirala.Name = "sec_sirala"
        Me.sec_sirala.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sirala.Properties.Items.AddRange(New Object() {"lNetTutar", "TOPLAMMALIYET", "Miktar", "KAR", "A-Z / Z-A"})
        Me.sec_sirala.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sirala.Size = New System.Drawing.Size(88, 20)
        Me.sec_sirala.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(168, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "TopList :"
        '
        'ceTopValuesShowOthers
        '
        Me.ceTopValuesShowOthers.EditValue = True
        Me.ceTopValuesShowOthers.Location = New System.Drawing.Point(360, 8)
        Me.ceTopValuesShowOthers.Name = "ceTopValuesShowOthers"
        Me.ceTopValuesShowOthers.Properties.Caption = "Diðerlerini Topla"
        Me.ceTopValuesShowOthers.Size = New System.Drawing.Size(98, 19)
        Me.ceTopValuesShowOthers.TabIndex = 14
        '
        'icbField
        '
        Me.icbField.EditValue = "StokKod1"
        Me.icbField.EnterMoveNextControl = True
        Me.icbField.Location = New System.Drawing.Point(216, 8)
        Me.icbField.Name = "icbField"
        Me.icbField.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.icbField.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.icbField.Size = New System.Drawing.Size(88, 20)
        Me.icbField.TabIndex = 12
        '
        'seTop
        '
        Me.seTop.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seTop.EnterMoveNextControl = True
        Me.seTop.Location = New System.Drawing.Point(304, 8)
        Me.seTop.Name = "seTop"
        Me.seTop.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seTop.Size = New System.Drawing.Size(56, 20)
        Me.seTop.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(6, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = Global.business_smart.My.Resources.Resources.button_cancel
        Me.SimpleButton2.Location = New System.Drawing.Point(738, 16)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = Global.business_smart.My.Resources.Resources.button_ok
        Me.SimpleButton1.Location = New System.Drawing.Point(663, 16)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.Panelstatus)
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 123)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 227)
        Me.PanelControl3.TabIndex = 0
        '
        'Panelstatus
        '
        Me.Panelstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panelstatus.Controls.Add(Me.bar2)
        Me.Panelstatus.Controls.Add(Me.barlabel2)
        Me.Panelstatus.Controls.Add(Me.barlabel)
        Me.Panelstatus.Controls.Add(Me.bar)
        Me.Panelstatus.Location = New System.Drawing.Point(229, 59)
        Me.Panelstatus.Name = "Panelstatus"
        Me.Panelstatus.Size = New System.Drawing.Size(367, 108)
        Me.Panelstatus.TabIndex = 13
        Me.Panelstatus.Visible = False
        '
        'bar2
        '
        Me.bar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar2.Location = New System.Drawing.Point(8, 73)
        Me.bar2.Name = "bar2"
        Me.bar2.Properties.ShowTitle = True
        Me.bar2.Size = New System.Drawing.Size(343, 18)
        Me.bar2.TabIndex = 3
        '
        'barlabel2
        '
        Me.barlabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barlabel2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
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
        Me.bar.Size = New System.Drawing.Size(343, 18)
        Me.bar.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridControl1.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridControl1.Appearance.Empty.Options.UseBackColor = True
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataMember = Nothing
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldnAlisverisID, Me.fieldnMusteriID, Me.fieldlKodu, Me.fieldsMusteriAdi, Me.fielddteTarih, Me.fieldfisTipi, Me.fieldlNo, Me.fieldnStokID, Me.fieldsKodu, Me.fieldsStokAciklama, Me.fieldMiktar, Me.fieldFiyat, Me.fieldIskonto, Me.fieldlNetTutar, Me.fieldsOdemeKodu, Me.fieldsFiyatTipi, Me.fieldsSaticiRumuzu, Me.fieldsKasiyerRumuzu, Me.fieldnGirisCikis, Me.fieldsMagaza, Me.fieldsRenk, Me.fieldORAN1, Me.fieldPESIN, Me.fieldALTIAY, Me.fieldONAY, Me.fieldKAR, Me.fieldFARK, Me.fieldNORMALFIYAT, Me.fieldNORMALTUTAR, Me.fieldMALIYET, Me.fieldFIYATFARKI, Me.fieldKAT, Me.fieldMSINIF1, Me.fieldMSINIF2, Me.fieldMSINIF3, Me.fieldMSINIF4, Me.fieldMSINIF5, Me.fieldSSINIF1, Me.fieldSSINIF2, Me.fieldSSINIF3, Me.fieldSSINIF4, Me.fieldSSINIF5, Me.fieldSatici, Me.fieldsKat, Me.fieldsRenkAdi, Me.fieldsSemt, Me.fieldsIl, Me.fieldsUlke, Me.fieldsVergiDairesi, Me.fieldlPrimTutari, Me.fieldsGun, Me.fieldsHafta, Me.fieldsAy, Me.fieldsQuarter, Me.fieldsYil})
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea
        Me.GridControl1.OptionsDataField.AreaIndex = 0
        Me.GridControl1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridControl1.Size = New System.Drawing.Size(820, 223)
        Me.GridControl1.TabIndex = 0
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem15, Me.MenuItem16, Me.MenuItem17, Me.MenuItem18, Me.MenuItem19, Me.MenuItem21, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        Me.MenuItem14.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem14.Text = "Vazgeç"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 2
        Me.MenuItem15.Text = "-"
        '
        'MenuItem16
        '
        Me.MenuItem16.Enabled = False
        Me.MenuItem16.Index = 3
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem16.Text = "Kalan Taksitler"
        '
        'MenuItem17
        '
        Me.MenuItem17.Enabled = False
        Me.MenuItem17.Index = 4
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem17.Text = "Kalan Satýþlar"
        '
        'MenuItem18
        '
        Me.MenuItem18.Enabled = False
        Me.MenuItem18.Index = 5
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem18.Text = "Satýþlar"
        '
        'MenuItem19
        '
        Me.MenuItem19.Enabled = False
        Me.MenuItem19.Index = 6
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem19.Text = "Müþteri Kartý"
        '
        'MenuItem21
        '
        Me.MenuItem21.Enabled = False
        Me.MenuItem21.Index = 7
        Me.MenuItem21.Text = "Envanter"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 8
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 9
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 10
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 11
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 12
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 13
        Me.MenuItem10.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 14
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 15
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 16
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 17
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 18
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 19
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 20
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42})
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
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "ORAN1"
        Me.DataColumn22.DataType = GetType(Decimal)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "PESIN"
        Me.DataColumn23.DataType = GetType(Decimal)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "ALTIAY"
        Me.DataColumn24.DataType = GetType(Decimal)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "ONAY"
        Me.DataColumn25.DataType = GetType(Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "KAR"
        Me.DataColumn26.DataType = GetType(Decimal)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "FARK"
        Me.DataColumn27.DataType = GetType(Decimal)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "NORMALFIYAT"
        Me.DataColumn28.DataType = GetType(Decimal)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "NORMALTUTAR"
        Me.DataColumn29.DataType = GetType(Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "MALIYET"
        Me.DataColumn30.DataType = GetType(Decimal)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "FIYATFARKI"
        Me.DataColumn31.DataType = GetType(Decimal)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "KAT"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "MSINIF1"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "MSINIF2"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "MSINIF3"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "MSINIF4"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "MSINIF5"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "SSINIF1"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "SSINIF2"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "SSINIF3"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "SSINIF4"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "SSINIF5"
        '
        'fieldnAlisverisID
        '
        Me.fieldnAlisverisID.AreaIndex = 0
        Me.fieldnAlisverisID.Caption = "AlýþVeriþ No"
        Me.fieldnAlisverisID.FieldName = "nAlisverisID"
        Me.fieldnAlisverisID.Name = "fieldnAlisverisID"
        Me.fieldnAlisverisID.Visible = False
        '
        'fieldnMusteriID
        '
        Me.fieldnMusteriID.AreaIndex = 1
        Me.fieldnMusteriID.Caption = "Müþteri No"
        Me.fieldnMusteriID.FieldName = "nMusteriID"
        Me.fieldnMusteriID.Name = "fieldnMusteriID"
        Me.fieldnMusteriID.Visible = False
        '
        'fieldlKodu
        '
        Me.fieldlKodu.AreaIndex = 0
        Me.fieldlKodu.Caption = "Müþteri Kodu"
        Me.fieldlKodu.FieldName = "lKodu"
        Me.fieldlKodu.Name = "fieldlKodu"
        Me.fieldlKodu.Visible = False
        '
        'fieldsMusteriAdi
        '
        Me.fieldsMusteriAdi.AreaIndex = 0
        Me.fieldsMusteriAdi.Caption = "Müþteri"
        Me.fieldsMusteriAdi.FieldName = "sMusteriAdi"
        Me.fieldsMusteriAdi.Name = "fieldsMusteriAdi"
        Me.fieldsMusteriAdi.Visible = False
        '
        'fielddteTarih
        '
        Me.fielddteTarih.AreaIndex = 8
        Me.fielddteTarih.Caption = "Tarih"
        Me.fielddteTarih.CellFormat.FormatString = "d"
        Me.fielddteTarih.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fielddteTarih.FieldName = "dteTarih"
        Me.fielddteTarih.Name = "fielddteTarih"
        '
        'fieldfisTipi
        '
        Me.fieldfisTipi.AreaIndex = 3
        Me.fieldfisTipi.Caption = "Fiþ Tipi"
        Me.fieldfisTipi.FieldName = "fisTipi"
        Me.fieldfisTipi.GrandTotalText = "FiþToplamlarý"
        Me.fieldfisTipi.Name = "fieldfisTipi"
        '
        'fieldlNo
        '
        Me.fieldlNo.AreaIndex = 1
        Me.fieldlNo.Caption = "Fiþ No"
        Me.fieldlNo.FieldName = "lNo"
        Me.fieldlNo.Name = "fieldlNo"
        Me.fieldlNo.Visible = False
        '
        'fieldnStokID
        '
        Me.fieldnStokID.AreaIndex = 0
        Me.fieldnStokID.Caption = "Stok No"
        Me.fieldnStokID.FieldName = "nStokID"
        Me.fieldnStokID.Name = "fieldnStokID"
        Me.fieldnStokID.Visible = False
        '
        'fieldsKodu
        '
        Me.fieldsKodu.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldsKodu.AreaIndex = 0
        Me.fieldsKodu.Caption = "Stok Kodu"
        Me.fieldsKodu.FieldName = "sKodu"
        Me.fieldsKodu.Name = "fieldsKodu"
        Me.fieldsKodu.Width = 124
        '
        'fieldsStokAciklama
        '
        Me.fieldsStokAciklama.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldsStokAciklama.AreaIndex = 1
        Me.fieldsStokAciklama.Caption = "Stok Adý"
        Me.fieldsStokAciklama.FieldName = "sStokAciklama"
        Me.fieldsStokAciklama.Name = "fieldsStokAciklama"
        Me.fieldsStokAciklama.Width = 210
        '
        'fieldMiktar
        '
        Me.fieldMiktar.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldMiktar.AreaIndex = 0
        Me.fieldMiktar.Caption = "Miktar"
        Me.fieldMiktar.CellFormat.FormatString = "#,0.####"
        Me.fieldMiktar.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldMiktar.FieldName = "Miktar"
        Me.fieldMiktar.Name = "fieldMiktar"
        Me.fieldMiktar.Width = 57
        '
        'fieldFiyat
        '
        Me.fieldFiyat.AreaIndex = 0
        Me.fieldFiyat.Caption = "Fiyat"
        Me.fieldFiyat.FieldName = "Fiyat"
        Me.fieldFiyat.Name = "fieldFiyat"
        Me.fieldFiyat.Visible = False
        '
        'fieldIskonto
        '
        Me.fieldIskonto.AreaIndex = 0
        Me.fieldIskonto.Caption = "Ýskonto"
        Me.fieldIskonto.FieldName = "Iskonto"
        Me.fieldIskonto.Name = "fieldIskonto"
        Me.fieldIskonto.Visible = False
        '
        'fieldlNetTutar
        '
        Me.fieldlNetTutar.AreaIndex = 1
        Me.fieldlNetTutar.Caption = "Tutar"
        Me.fieldlNetTutar.CellFormat.FormatString = "#,0.00"
        Me.fieldlNetTutar.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlNetTutar.FieldName = "lNetTutar"
        Me.fieldlNetTutar.Name = "fieldlNetTutar"
        '
        'fieldsOdemeKodu
        '
        Me.fieldsOdemeKodu.AreaIndex = 0
        Me.fieldsOdemeKodu.Caption = "Ödeme Kodu"
        Me.fieldsOdemeKodu.FieldName = "sOdemeKodu"
        Me.fieldsOdemeKodu.Name = "fieldsOdemeKodu"
        Me.fieldsOdemeKodu.Visible = False
        '
        'fieldsFiyatTipi
        '
        Me.fieldsFiyatTipi.AreaIndex = 0
        Me.fieldsFiyatTipi.Caption = "FiyatTipi"
        Me.fieldsFiyatTipi.FieldName = "sFiyatTipi"
        Me.fieldsFiyatTipi.Name = "fieldsFiyatTipi"
        Me.fieldsFiyatTipi.Visible = False
        '
        'fieldsSaticiRumuzu
        '
        Me.fieldsSaticiRumuzu.AreaIndex = 0
        Me.fieldsSaticiRumuzu.Caption = "Satýcý"
        Me.fieldsSaticiRumuzu.FieldName = "sSaticiRumuzu"
        Me.fieldsSaticiRumuzu.Name = "fieldsSaticiRumuzu"
        Me.fieldsSaticiRumuzu.Visible = False
        '
        'fieldsKasiyerRumuzu
        '
        Me.fieldsKasiyerRumuzu.AreaIndex = 14
        Me.fieldsKasiyerRumuzu.Caption = "Kasiyer"
        Me.fieldsKasiyerRumuzu.FieldName = "sKasiyerRumuzu"
        Me.fieldsKasiyerRumuzu.Name = "fieldsKasiyerRumuzu"
        Me.fieldsKasiyerRumuzu.Visible = False
        '
        'fieldnGirisCikis
        '
        Me.fieldnGirisCikis.AreaIndex = 2
        Me.fieldnGirisCikis.Caption = "Giriþ/Çýkýþ"
        Me.fieldnGirisCikis.FieldName = "nGirisCikis"
        Me.fieldnGirisCikis.Name = "fieldnGirisCikis"
        Me.fieldnGirisCikis.Visible = False
        '
        'fieldsMagaza
        '
        Me.fieldsMagaza.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldsMagaza.AreaIndex = 0
        Me.fieldsMagaza.Caption = "Maðaza"
        Me.fieldsMagaza.FieldName = "sMagaza"
        Me.fieldsMagaza.GrandTotalText = "MaðazaToplamlarý"
        Me.fieldsMagaza.Name = "fieldsMagaza"
        Me.fieldsMagaza.Visible = False
        Me.fieldsMagaza.Width = 88
        '
        'fieldsRenk
        '
        Me.fieldsRenk.AreaIndex = 15
        Me.fieldsRenk.Caption = "Renk"
        Me.fieldsRenk.FieldName = "sRenk"
        Me.fieldsRenk.Name = "fieldsRenk"
        Me.fieldsRenk.Visible = False
        '
        'fieldORAN1
        '
        Me.fieldORAN1.AreaIndex = 16
        Me.fieldORAN1.Caption = "% Oran"
        Me.fieldORAN1.FieldName = "ORAN1"
        Me.fieldORAN1.Name = "fieldORAN1"
        Me.fieldORAN1.Visible = False
        '
        'fieldPESIN
        '
        Me.fieldPESIN.AreaIndex = 17
        Me.fieldPESIN.Caption = "Fiyat1"
        Me.fieldPESIN.FieldName = "PESIN"
        Me.fieldPESIN.Name = "fieldPESIN"
        Me.fieldPESIN.Visible = False
        '
        'fieldALTIAY
        '
        Me.fieldALTIAY.AreaIndex = 18
        Me.fieldALTIAY.Caption = "Fiyat2"
        Me.fieldALTIAY.FieldName = "ALTIAY"
        Me.fieldALTIAY.Name = "fieldALTIAY"
        Me.fieldALTIAY.Visible = False
        '
        'fieldONAY
        '
        Me.fieldONAY.AreaIndex = 19
        Me.fieldONAY.Caption = "Fiyat3"
        Me.fieldONAY.FieldName = "ONAY"
        Me.fieldONAY.Name = "fieldONAY"
        Me.fieldONAY.Visible = False
        '
        'fieldKAR
        '
        Me.fieldKAR.AreaIndex = 2
        Me.fieldKAR.Caption = "Kar"
        Me.fieldKAR.CellFormat.FormatString = "#,0.00"
        Me.fieldKAR.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldKAR.FieldName = "KAR"
        Me.fieldKAR.Name = "fieldKAR"
        '
        'fieldFARK
        '
        Me.fieldFARK.AreaIndex = 21
        Me.fieldFARK.Caption = "Tutar Farký"
        Me.fieldFARK.FieldName = "FARK"
        Me.fieldFARK.Name = "fieldFARK"
        Me.fieldFARK.Visible = False
        '
        'fieldNORMALFIYAT
        '
        Me.fieldNORMALFIYAT.AreaIndex = 22
        Me.fieldNORMALFIYAT.Caption = "Normal Fiyat"
        Me.fieldNORMALFIYAT.FieldName = "NORMALFIYAT"
        Me.fieldNORMALFIYAT.Name = "fieldNORMALFIYAT"
        Me.fieldNORMALFIYAT.Visible = False
        '
        'fieldNORMALTUTAR
        '
        Me.fieldNORMALTUTAR.AreaIndex = 23
        Me.fieldNORMALTUTAR.Caption = "Normal Tutar"
        Me.fieldNORMALTUTAR.FieldName = "NORMALTUTAR"
        Me.fieldNORMALTUTAR.Name = "fieldNORMALTUTAR"
        Me.fieldNORMALTUTAR.Visible = False
        '
        'fieldMALIYET
        '
        Me.fieldMALIYET.AreaIndex = 23
        Me.fieldMALIYET.Caption = "Maliyet"
        Me.fieldMALIYET.FieldName = "MALIYET"
        Me.fieldMALIYET.Name = "fieldMALIYET"
        Me.fieldMALIYET.Visible = False
        '
        'fieldFIYATFARKI
        '
        Me.fieldFIYATFARKI.AreaIndex = 23
        Me.fieldFIYATFARKI.Caption = "Fiyat Farký"
        Me.fieldFIYATFARKI.FieldName = "FIYATFARKI"
        Me.fieldFIYATFARKI.Name = "fieldFIYATFARKI"
        Me.fieldFIYATFARKI.Visible = False
        '
        'fieldKAT
        '
        Me.fieldKAT.AreaIndex = 23
        Me.fieldKAT.Caption = "Kat"
        Me.fieldKAT.FieldName = "KAT"
        Me.fieldKAT.Name = "fieldKAT"
        Me.fieldKAT.Visible = False
        '
        'fieldMSINIF1
        '
        Me.fieldMSINIF1.AreaIndex = 0
        Me.fieldMSINIF1.Caption = "Müþteri Sýnýf 1"
        Me.fieldMSINIF1.FieldName = "MSINIF1"
        Me.fieldMSINIF1.Name = "fieldMSINIF1"
        Me.fieldMSINIF1.Visible = False
        '
        'fieldMSINIF2
        '
        Me.fieldMSINIF2.AreaIndex = 23
        Me.fieldMSINIF2.Caption = "Müþteri Sýnýf 2"
        Me.fieldMSINIF2.FieldName = "MSINIF2"
        Me.fieldMSINIF2.Name = "fieldMSINIF2"
        Me.fieldMSINIF2.Visible = False
        '
        'fieldMSINIF3
        '
        Me.fieldMSINIF3.AreaIndex = 22
        Me.fieldMSINIF3.Caption = "Müþteri Sýnýf 3"
        Me.fieldMSINIF3.FieldName = "MSINIF3"
        Me.fieldMSINIF3.Name = "fieldMSINIF3"
        Me.fieldMSINIF3.Visible = False
        '
        'fieldMSINIF4
        '
        Me.fieldMSINIF4.AreaIndex = 30
        Me.fieldMSINIF4.Caption = "Müþteri Sýnýf 4"
        Me.fieldMSINIF4.FieldName = "MSINIF4"
        Me.fieldMSINIF4.Name = "fieldMSINIF4"
        Me.fieldMSINIF4.Visible = False
        '
        'fieldMSINIF5
        '
        Me.fieldMSINIF5.AreaIndex = 31
        Me.fieldMSINIF5.Caption = "Müþteri Sýnýf 5"
        Me.fieldMSINIF5.FieldName = "MSINIF5"
        Me.fieldMSINIF5.Name = "fieldMSINIF5"
        Me.fieldMSINIF5.Visible = False
        '
        'fieldSSINIF1
        '
        Me.fieldSSINIF1.AreaIndex = 0
        Me.fieldSSINIF1.Caption = "Stok Sýnýf 1"
        Me.fieldSSINIF1.FieldName = "SSINIF1"
        Me.fieldSSINIF1.Name = "fieldSSINIF1"
        '
        'fieldSSINIF2
        '
        Me.fieldSSINIF2.AreaIndex = 33
        Me.fieldSSINIF2.Caption = "Stok Sýnýf 2"
        Me.fieldSSINIF2.FieldName = "SSINIF2"
        Me.fieldSSINIF2.Name = "fieldSSINIF2"
        Me.fieldSSINIF2.Visible = False
        '
        'fieldSSINIF3
        '
        Me.fieldSSINIF3.AreaIndex = 32
        Me.fieldSSINIF3.Caption = "Stok Sýnýf 3"
        Me.fieldSSINIF3.FieldName = "SSINIF3"
        Me.fieldSSINIF3.Name = "fieldSSINIF3"
        Me.fieldSSINIF3.Visible = False
        '
        'fieldSSINIF4
        '
        Me.fieldSSINIF4.AreaIndex = 33
        Me.fieldSSINIF4.Caption = "Stok Sýnýf 4"
        Me.fieldSSINIF4.FieldName = "SSINIF4"
        Me.fieldSSINIF4.Name = "fieldSSINIF4"
        Me.fieldSSINIF4.Visible = False
        '
        'fieldSSINIF5
        '
        Me.fieldSSINIF5.AreaIndex = 32
        Me.fieldSSINIF5.Caption = "Stok Sýnýf 5"
        Me.fieldSSINIF5.FieldName = "SSINIF5"
        Me.fieldSSINIF5.Name = "fieldSSINIF5"
        Me.fieldSSINIF5.Visible = False
        '
        'fieldSatici
        '
        Me.fieldSatici.AreaIndex = 2
        Me.fieldSatici.Caption = "Satici"
        Me.fieldSatici.FieldName = "Satici"
        Me.fieldSatici.Name = "fieldSatici"
        Me.fieldSatici.Visible = False
        '
        'fieldsKat
        '
        Me.fieldsKat.AreaIndex = 2
        Me.fieldsKat.Caption = "Kat"
        Me.fieldsKat.FieldName = "sKat"
        Me.fieldsKat.Name = "fieldsKat"
        Me.fieldsKat.Visible = False
        '
        'fieldsRenkAdi
        '
        Me.fieldsRenkAdi.AreaIndex = 10
        Me.fieldsRenkAdi.Caption = "Renk Adý"
        Me.fieldsRenkAdi.FieldName = "sRenkAdi"
        Me.fieldsRenkAdi.Name = "fieldsRenkAdi"
        Me.fieldsRenkAdi.Visible = False
        '
        'fieldsSemt
        '
        Me.fieldsSemt.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldsSemt.AreaIndex = 2
        Me.fieldsSemt.Caption = "Semt"
        Me.fieldsSemt.FieldName = "sSemt"
        Me.fieldsSemt.Name = "fieldsSemt"
        Me.fieldsSemt.Visible = False
        '
        'fieldsIl
        '
        Me.fieldsIl.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldsIl.AreaIndex = 1
        Me.fieldsIl.Caption = "il"
        Me.fieldsIl.FieldName = "sIl"
        Me.fieldsIl.Name = "fieldsIl"
        Me.fieldsIl.Visible = False
        '
        'fieldsUlke
        '
        Me.fieldsUlke.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldsUlke.AreaIndex = 2
        Me.fieldsUlke.Caption = "Ulke"
        Me.fieldsUlke.FieldName = "sUlke"
        Me.fieldsUlke.Name = "fieldsUlke"
        Me.fieldsUlke.Visible = False
        '
        'fieldsVergiDairesi
        '
        Me.fieldsVergiDairesi.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldsVergiDairesi.AreaIndex = 3
        Me.fieldsVergiDairesi.Caption = "Vergi Dairesi"
        Me.fieldsVergiDairesi.FieldName = "sVergiDairesi"
        Me.fieldsVergiDairesi.Name = "fieldsVergiDairesi"
        Me.fieldsVergiDairesi.Visible = False
        '
        'fieldlPrimTutari
        '
        Me.fieldlPrimTutari.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldlPrimTutari.AreaIndex = 4
        Me.fieldlPrimTutari.Caption = "Prim"
        Me.fieldlPrimTutari.CellFormat.FormatString = "#,0.0000"
        Me.fieldlPrimTutari.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldlPrimTutari.FieldName = "lPrimTutari"
        Me.fieldlPrimTutari.Name = "fieldlPrimTutari"
        Me.fieldlPrimTutari.Visible = False
        '
        'fieldsGun
        '
        Me.fieldsGun.AreaIndex = 5
        Me.fieldsGun.Caption = "Gün"
        Me.fieldsGun.FieldName = "sGun"
        Me.fieldsGun.Name = "fieldsGun"
        '
        'fieldsHafta
        '
        Me.fieldsHafta.AreaIndex = 4
        Me.fieldsHafta.Caption = "Hafta"
        Me.fieldsHafta.FieldName = "sHafta"
        Me.fieldsHafta.Name = "fieldsHafta"
        '
        'fieldsAy
        '
        Me.fieldsAy.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldsAy.AreaIndex = 0
        Me.fieldsAy.Caption = "Ay"
        Me.fieldsAy.FieldName = "sAy"
        Me.fieldsAy.Name = "fieldsAy"
        '
        'fieldsQuarter
        '
        Me.fieldsQuarter.AreaIndex = 6
        Me.fieldsQuarter.Caption = "Qarter"
        Me.fieldsQuarter.FieldName = "sQuarter"
        Me.fieldsQuarter.Name = "fieldsQuarter"
        '
        'fieldsYil
        '
        Me.fieldsYil.AreaIndex = 7
        Me.fieldsYil.Caption = "Yil"
        Me.fieldsYil.FieldName = "sYil"
        Me.fieldsYil.Name = "fieldsYil"
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
        Me.printlink1.Landscape = True
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Satýþ Analizleri", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Retail-Maðaza Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1})
        Me.BarManager1.MaxItemId = 1
        Me.BarManager1.StatusBar = Me.Bar4
        '
        'Bar4
        '
        Me.Bar4.BarName = "Status bar"
        Me.Bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar4.DockCol = 0
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1)})
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
        'frm_stok_satis_yaslandirma
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
        Me.Name = "frm_stok_satis_yaslandirma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Satis Yaslandirma"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_MaliyetTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum_stok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter_stok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara_stok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.sec_sirala.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceTopValuesShowOthers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icbField.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seTop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelstatus.ResumeLayout(False)
        Me.Panelstatus.PerformLayout()
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        DateEdit1.EditValue = dteSistemTarihi '"01/01/" + Today.Year.ToString
        DateEdit2.EditValue = dteSistemTarihi '"31/12/" + Today.Year.ToString
        DateEdit1.Focus()
        DateEdit1.Select()
        If txt_ara.EditValue <> "" Then
        Else
            txt_ara.EditValue = ""
        End If
        txt_ara_stok.EditValue = ""
        dataload_renk()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub dataload_renk()
        'sec_renk.DataSource = sorgu(sorgu_query("SELECT * FROM tbRenk")).Tables(0) 'DataSet2.Tables(0)
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
        'GridView1.ColumnsCustomization()
        GridControl1.FieldsCustomization()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        'GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        'GridView1.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        'GridView1.OptionsView.ShowGroupPanel = True
        'GridView1.OptionsCustomization.AllowGroup = True
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        'GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        'GridView1.CollapseAllGroups()
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
        Dim kriter As String = ""
        kriter += Microsoft.VisualBasic.Left(DateEdit1.EditValue.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(DateEdit2.EditValue.ToString, 10) & " Tarihleri Arasýndaki Satýþlar" & vbCrLf
        'kriter += "Limit = " & txt_altlimit.EditValue & "-" & txt_ustlimit.EditValue
        printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Stok Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridControl1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "\")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        'GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraPivotGrid.PivotGridField In GridControl1.Fields
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim itm
        For Each itm In ContextMenu1.MenuItems
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        GridControl1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "\")
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
    Public Function stok(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara_stok As String, ByVal konum_stok As String, ByVal ara_kriter_stok As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal MaliyetTipi As Integer) As DataSet
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
            ElseIf sec_konum.Text = "Sýnýf1" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif1.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum.Text = "Sýnýf2" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif2.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum.Text = "Sýnýf3" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif3.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum.Text = "Sýnýf4" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif4.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum.Text = "Sýnýf5" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif5.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            ElseIf sec_konum.Text = "Barkod" Then
                kriter += " AND tbStok.nStokID IN ( SELECT     tbStok.nStokID  FROM         tbStok INNER JOIN                       tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID WHERE tbStokBarkodu.sBarkod " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            End If
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        If firmatipi = False Then
            'cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , tbMusteri.lKodu AS lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih , tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo , tbStok.nStokID , tbStok.sKodu AS sKodu , tbStok.sAciklama AS sStokAciklama , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lBrutFiyat , 0) AS Fiyat , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar AS lNetTutar , tbStokFisiDetayi.sOdemeKodu , tbStokFisiDetayi.sFiyatTipi , tbStokFisiDetayi.sSaticiRumuzu , tbStokFisiDetayi.sKasiyerRumuzu , tbStokFisiDetayi.nGirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '"& sFiyat1 &"') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '"& sFiyat3 &"') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '"& sFiyat2 &"') AS ALTIAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '"& sFiyatM &"') AS MALIYET, CAST(0 AS MONEY) AS ORAN1,CAST(0 AS MONEY) AS KAR,CAST(0 AS MONEY) AS FARK,CAST(0 AS MONEY) AS FIYATFARKI,CAST(0 AS MONEY) AS NORMALFIYAT,CAST(0 AS MONEY) AS NORMALTUTAR FROM tbStok RIGHT OUTER JOIN tbMusteri INNER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID LEFT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND tbAlisveris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & " UNION ALL SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , tbMusteri.lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih , tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo , tbStok.nStokID , tbStok.sKodu , tbStok.sAciklama AS sStokAciklama , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lBrutFiyat AS Fiyat , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar AS lNetTutar , tbAlisverisSiparis.sOdemeKodu , tbAlisverisSiparis.sFiyatTipi , tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu , tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu , tbAlisverisSiparis.nGirisCikis AS GirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '"& sFiyat1 &"') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '"& sFiyat3 &"') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '"& sFiyat2 &"') AS ALTIAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '"& sFiyatM &"') AS MALIYET, CAST(0 AS MONEY) AS ORAN1,CAST(0 AS MONEY) AS KAR,CAST(0 AS MONEY) AS FARK,CAST(0 AS MONEY) AS FIYATFARKI,CAST(0 AS MONEY) AS NORMALFIYAT,CAST(0 AS MONEY) AS NORMALTUTAR FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE tbAlisveris.dteFaturaTarihi between '" & tarih1 & " ' and '" & tarih2 & "' " & kriter & "  ) t ORDER BY dteTarih,lNo")
            'cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT t.*, tbMSinif1.sAciklama AS MSINIF1, tbMSinif2.sAciklama AS MSINIF2, tbMSinif3.sAciklama AS MSINIF3, tbMSinif4.sAciklama AS MSINIF4, tbMSinif5.sAciklama AS MSINIF5, tbSSinif1.sAciklama AS SSINIF1, tbSSinif2.sAciklama AS SSINIF2, tbSSinif3.sAciklama AS SSINIF3, tbSSinif4.sAciklama AS SSINIF4, tbSSinif5.sAciklama AS SSINIF5 FROM (SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , tbMusteri.lKodu AS lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih , tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo , tbStok.nStokID , tbStok.sKodu AS sKodu , tbStok.sAciklama AS sStokAciklama , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lBrutFiyat , 0) AS Fiyat , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar AS lNetTutar , tbStokFisiDetayi.sOdemeKodu , tbStokFisiDetayi.sFiyatTipi , tbStokFisiDetayi.sSaticiRumuzu , tbStokFisiDetayi.sKasiyerRumuzu , tbStokFisiDetayi.nGirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '"& sFiyat1 &"') AS PESIN , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '"& sFiyat3 &"') AS ONAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '"& sFiyat2 &"') AS ALTIAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '"& sFiyatM &"') AS MALIYET , CAST(0 AS MONEY) AS ORAN1 , CAST(0 AS MONEY) AS KAR , CAST(0 AS MONEY) AS FARK , CAST(0 AS MONEY) AS FIYATFARKI , CAST(0 AS MONEY) AS NORMALFIYAT , CAST(0 AS MONEY) AS NORMALTUTAR FROM tbStok RIGHT OUTER JOIN tbMusteri INNER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID LEFT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND tbAlisveris.dteFaturaTarihi BETWEEN '" & tarih1 & " ' and '" & tarih2 & "' " & kriter & " UNION ALL SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , tbMusteri.lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih , tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo , tbStok.nStokID , tbStok.sKodu , tbStok.sAciklama AS sStokAciklama , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lBrutFiyat AS Fiyat , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar AS lNetTutar , tbAlisverisSiparis.sOdemeKodu , tbAlisverisSiparis.sFiyatTipi , tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu , tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu , tbAlisverisSiparis.nGirisCikis AS GirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '"& sFiyat1 &"') AS PESIN , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '"& sFiyat3 &"') AS ONAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '"& sFiyat2 &"') AS ALTIAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '"& sFiyatM &"') AS MALIYET , CAST(0 AS MONEY) AS ORAN1 , CAST(0 AS MONEY) AS KAR , CAST(0 AS MONEY) AS FARK , CAST(0 AS MONEY) AS FIYATFARKI , CAST(0 AS MONEY) AS NORMALFIYAT , CAST(0 AS MONEY) AS NORMALTUTAR FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE tbAlisveris.dteFaturaTarihi BETWEEN '" & tarih1 & " ' and '" & tarih2 & "' " & kriter & ") t INNER JOIN tbMusteriSinifi ON t.nMusteriID = tbMusteriSinifi.nMusteriID INNER JOIN tbMSinif1 ON tbMusteriSinifi.sSinifKodu1 = tbMSinif1.sSinifKodu INNER JOIN tbMSinif2 ON tbMusteriSinifi.sSinifKodu2 = tbMSinif2.sSinifKodu INNER JOIN tbMSinif3 ON tbMusteriSinifi.sSinifKodu3 = tbMSinif3.sSinifKodu INNER JOIN tbMSinif4 ON tbMusteriSinifi.sSinifKodu4 = tbMSinif4.sSinifKodu INNER JOIN tbMSinif5 ON tbMusteriSinifi.sSinifKodu5 = tbMSinif5.sSinifKodu INNER JOIN tbStokSinifi ON t.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu ORDER BY t.dteTarih, t.lNo")
            If islem = 0 Then
                cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT t.*, tbMSinif1.sAciklama AS MSINIF1, tbMSinif2.sAciklama AS MSINIF2, tbMSinif3.sAciklama AS MSINIF3, tbMSinif4.sAciklama AS MSINIF4, tbMSinif5.sAciklama AS MSINIF5, tbSSinif1.sAciklama AS SSINIF1, tbSSinif2.sAciklama AS SSINIF2, tbSSinif3.sAciklama AS SSINIF3, tbSSinif4.sAciklama AS SSINIF4, tbSSinif5.sAciklama AS SSINIF5, tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici, tbSaticiKatlari.sKat FROM (SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , CAST(tbMusteri.lKodu AS NVARCHAR(60)) AS lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih , tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo , tbStok.nStokID , tbStok.sKodu AS sKodu , tbStok.sAciklama AS sStokAciklama , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lBrutFiyat , 0) AS Fiyat , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbStokFisiDetayi.sOdemeKodu , tbStokFisiDetayi.sFiyatTipi , tbStokFisiDetayi.sSaticiRumuzu , tbStokFisiDetayi.sKasiyerRumuzu , tbStokFisiDetayi.nGirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk ,(SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sBeden, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET ,tbStokFisiDetayi.lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1 , CAST(0 AS MONEY) AS KAR , CAST(0 AS MONEY) AS FARK , CAST(0 AS MONEY) AS FIYATFARKI , CAST(0 AS MONEY) AS NORMALFIYAT , CAST(0 AS MONEY) AS NORMALTUTAR FROM tbStok RIGHT OUTER JOIN tbMusteri INNER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID LEFT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND tbAlisveris.dteFaturaTarihi BETWEEN '" & tarih1 & " ' and '" & tarih2 & "' " & kriter & " UNION ALL SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , CAST(tbMusteri.lKodu AS NVARCHAR(60)) AS lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih , tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo , tbStok.nStokID , tbStok.sKodu , tbStok.sAciklama AS sStokAciklama , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lBrutFiyat AS Fiyat , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbAlisverisSiparis.sOdemeKodu , tbAlisverisSiparis.sFiyatTipi , tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu , tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu , tbAlisverisSiparis.nGirisCikis AS GirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk ,(SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sBeden, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET , CAST(0 AS MONEY) lMaliyetFiyat,CAST(0 AS MONEY) AS ORAN1 , CAST(0 AS MONEY) AS KAR , CAST(0 AS MONEY) AS FARK , CAST(0 AS MONEY) AS FIYATFARKI , CAST(0 AS MONEY) AS NORMALFIYAT , CAST(0 AS MONEY) AS NORMALTUTAR FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE tbAlisveris.dteFaturaTarihi BETWEEN '" & tarih1 & " ' and '" & tarih2 & "' " & kriter & ") t INNER JOIN tbMusteriSinifi ON t.nMusteriID = tbMusteriSinifi.nMusteriID INNER JOIN tbMSinif1 ON tbMusteriSinifi.sSinifKodu1 = tbMSinif1.sSinifKodu INNER JOIN tbMSinif2 ON tbMusteriSinifi.sSinifKodu2 = tbMSinif2.sSinifKodu INNER JOIN tbMSinif3 ON tbMusteriSinifi.sSinifKodu3 = tbMSinif3.sSinifKodu INNER JOIN tbMSinif4 ON tbMusteriSinifi.sSinifKodu4 = tbMSinif4.sSinifKodu INNER JOIN tbMSinif5 ON tbMusteriSinifi.sSinifKodu5 = tbMSinif5.sSinifKodu INNER JOIN tbStokSinifi ON t.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu LEFT OUTER JOIN tbSaticiKatlari ON t.sSaticiRumuzu COLLATE Turkish_CI_AS = tbSaticiKatlari.sSaticiRumuzu ORDER BY t.dteTarih, t.lNo")
            ElseIf islem = 1 Then
                cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT t.*, tbSSinif1.sAciklama AS SSINIF1, tbSSinif2.sAciklama AS SSINIF2, tbSSinif3.sAciklama AS SSINIF3, tbSSinif4.sAciklama AS SSINIF4, tbSSinif5.sAciklama AS SSINIF5, tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici, tbSaticiKatlari.sKat FROM (SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , CAST(tbMusteri.lKodu AS NVARCHAR(60)) AS lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih , DAY(tbAlisVeris.dteFaturaTarihi) AS sGun, { fn WEEK(tbAlisVeris.dteFaturaTarihi) } AS sHafta, MONTH(tbAlisVeris.dteFaturaTarihi) AS sAy, { fn QUARTER(tbAlisVeris.dteFaturaTarihi) } AS sQuarter, YEAR(tbAlisVeris.dteFaturaTarihi) AS sYil,tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo , tbStok.nStokID , tbStok.sKodu AS sKodu , tbStok.sAciklama AS sStokAciklama , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lBrutFiyat , 0) AS Fiyat , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbStokFisiDetayi.sOdemeKodu , tbStokFisiDetayi.sFiyatTipi , tbStokFisiDetayi.sSaticiRumuzu , tbStokFisiDetayi.sKasiyerRumuzu , tbStokFisiDetayi.nGirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk ,(SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sBeden, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET ,tbStokFisiDetayi.lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1 , CAST(0 AS MONEY) AS KAR , CAST(0 AS MONEY) AS FARK , CAST(0 AS MONEY) AS FIYATFARKI , CAST(0 AS MONEY) AS NORMALFIYAT , CAST(0 AS MONEY) AS NORMALTUTAR FROM tbStok RIGHT OUTER JOIN tbMusteri INNER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID LEFT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND tbAlisveris.dteFaturaTarihi BETWEEN '" & tarih1 & " ' and '" & tarih2 & "' " & kriter & " UNION ALL SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , CAST(tbMusteri.lKodu AS NVARCHAR(60)) AS lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih , DAY(tbAlisVeris.dteFaturaTarihi) AS sGun, { fn WEEK(tbAlisVeris.dteFaturaTarihi) } AS sHafta, MONTH(tbAlisVeris.dteFaturaTarihi) AS sAy, { fn QUARTER(tbAlisVeris.dteFaturaTarihi) } AS sQuarter, YEAR(tbAlisVeris.dteFaturaTarihi) AS sYil,tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo , tbStok.nStokID , tbStok.sKodu , tbStok.sAciklama AS sStokAciklama , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lBrutFiyat AS Fiyat , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbAlisverisSiparis.sOdemeKodu , tbAlisverisSiparis.sFiyatTipi , tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu , tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu , tbAlisverisSiparis.nGirisCikis AS GirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk ,(SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sBeden,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET , CAST(0 AS MONEY) lMaliyetFiyat,CAST(0 AS MONEY) AS ORAN1 , CAST(0 AS MONEY) AS KAR , CAST(0 AS MONEY) AS FARK , CAST(0 AS MONEY) AS FIYATFARKI , CAST(0 AS MONEY) AS NORMALFIYAT , CAST(0 AS MONEY) AS NORMALTUTAR FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE tbAlisveris.dteFaturaTarihi BETWEEN '" & tarih1 & " ' and '" & tarih2 & "' " & kriter & " UNION ALL SELECT CAST(tbStokFisiDetayi.nStokFisiID AS NVARCHAR(20)) AS nAlisVerisID, tbStokFisiDetayi.nFirmaID AS nMusteriID, tbFirma.sKodu AS lKodu, tbFirma.sAciklama AS sMusteriAdi, tbStokFisiDetayi.dteFisTarihi AS dteTarih, DAY(tbStokFisiDetayi.dteFisTarihi) AS sGun, { fn WEEK(tbStokFisiDetayi.dteFisTarihi) } AS sHafta, MONTH(tbStokFisiDetayi.dteFisTarihi) AS sAy, { fn QUARTER(tbStokFisiDetayi.dteFisTarihi) } AS sQuarter, YEAR(tbStokFisiDetayi.dteFisTarihi) AS sYil,tbStokFisiMaster.sFisTipi AS fisTipi, tbStokFisiMaster.lFisNo AS lNo, tbStok.nStokID, tbStok.sKodu AS sKodu, tbStok.sAciklama AS sStokAciklama, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto,  cast(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lNetTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo AS sMagaza, tbStok.sRenk, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sBeden, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, tbStokFisiDetayi.lMaliyetFiyat,CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR FROM tbFirma INNER JOIN tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID ON tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID LEFT OUTER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiDetayi.sFisTipi IN ('FS','DC')) AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & ") t INNER JOIN tbStokSinifi ON t.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu LEFT OUTER JOIN tbSaticiKatlari ON t.sSaticiRumuzu COLLATE Turkish_CI_AS = tbSaticiKatlari.sSaticiRumuzu ORDER BY t.dteTarih, t.lNo")
            ElseIf islem = 2 Then
                cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT t.*, tbMSinif1.sAciklama AS MSINIF1, tbMSinif2.sAciklama AS MSINIF2, tbMSinif3.sAciklama AS MSINIF3, tbMSinif4.sAciklama AS MSINIF4, tbMSinif5.sAciklama AS MSINIF5, tbSSinif1.sAciklama AS SSINIF1, tbSSinif2.sAciklama AS SSINIF2, tbSSinif3.sAciklama AS SSINIF3, tbSSinif4.sAciklama AS SSINIF4, tbSSinif5.sAciklama AS SSINIF5, tbSaticiKatlari.sAdi + ' ' + tbSaticiKatlari.sSoyadi AS Satici, tbSaticiKatlari.sKat FROM (SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , CAST(tbMusteri.lKodu AS NVARCHAR(60)) AS lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih , tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo , tbStok.nStokID , tbStok.sKodu AS sKodu , tbStok.sAciklama AS sStokAciklama , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lBrutFiyat , 0) AS Fiyat , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbStokFisiDetayi.sOdemeKodu , tbStokFisiDetayi.sFiyatTipi , tbStokFisiDetayi.sSaticiRumuzu , tbStokFisiDetayi.sKasiyerRumuzu , tbStokFisiDetayi.nGirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk ,(SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sBeden, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET ,tbStokFisiDetayi.lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1 , CAST(0 AS MONEY) AS KAR , CAST(0 AS MONEY) AS FARK , CAST(0 AS MONEY) AS FIYATFARKI , CAST(0 AS MONEY) AS NORMALFIYAT , CAST(0 AS MONEY) AS NORMALTUTAR FROM tbStok RIGHT OUTER JOIN tbMusteri INNER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID LEFT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND tbAlisveris.dteFaturaTarihi BETWEEN '" & tarih1 & " ' and '" & tarih2 & "' " & kriter & " UNION ALL SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , CAST(tbMusteri.lKodu AS NVARCHAR(60)) AS lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih , tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo , tbStok.nStokID , tbStok.sKodu , tbStok.sAciklama AS sStokAciklama , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lBrutFiyat AS Fiyat , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbAlisverisSiparis.sOdemeKodu , tbAlisverisSiparis.sFiyatTipi , tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu , tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu , tbAlisverisSiparis.nGirisCikis AS GirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk ,(SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sBeden,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET , CAST(0 AS MONEY) lMaliyetFiyat,CAST(0 AS MONEY) AS ORAN1 , CAST(0 AS MONEY) AS KAR , CAST(0 AS MONEY) AS FARK , CAST(0 AS MONEY) AS FIYATFARKI , CAST(0 AS MONEY) AS NORMALFIYAT , CAST(0 AS MONEY) AS NORMALTUTAR FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE tbAlisveris.dteFaturaTarihi BETWEEN '" & tarih1 & " ' and '" & tarih2 & "' " & kriter & " UNION ALL SELECT CAST(tbStokFisiDetayi.nStokFisiID AS NVARCHAR(20)) AS nAlisVerisID, tbStokFisiDetayi.nFirmaID AS nMusteriID, tbFirma.sKodu AS lKodu, tbFirma.sAciklama AS sMusteriAdi, tbStokFisiDetayi.dteFisTarihi AS dteTarih, tbStokFisiMaster.sFisTipi AS fisTipi, tbStokFisiMaster.lFisNo AS lNo, tbStok.nStokID, tbStok.sKodu AS sKodu, tbStok.sAciklama AS sStokAciklama, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto,  cast(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lNetTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo AS sMagaza, tbStok.sRenk, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sBeden, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, tbStokFisiDetayi.lMaliyetFiyat,CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR FROM tbFirma INNER JOIN tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID ON tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID LEFT OUTER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiDetayi.sFisTipi IN( 'FS','DC')) AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & ") t INNER JOIN tbMusteriSinifi ON t.nMusteriID = tbMusteriSinifi.nMusteriID INNER JOIN tbMSinif1 ON tbMusteriSinifi.sSinifKodu1 = tbMSinif1.sSinifKodu INNER JOIN tbMSinif2 ON tbMusteriSinifi.sSinifKodu2 = tbMSinif2.sSinifKodu INNER JOIN tbMSinif3 ON tbMusteriSinifi.sSinifKodu3 = tbMSinif3.sSinifKodu INNER JOIN tbMSinif4 ON tbMusteriSinifi.sSinifKodu4 = tbMSinif4.sSinifKodu INNER JOIN tbMSinif5 ON tbMusteriSinifi.sSinifKodu5 = tbMSinif5.sSinifKodu INNER JOIN tbStokSinifi ON t.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu LEFT OUTER JOIN tbSaticiKatlari ON t.sSaticiRumuzu COLLATE Turkish_CI_AS = tbSaticiKatlari.sSaticiRumuzu ORDER BY t.dteTarih, t.lNo")
            ElseIf islem = 3 Then
                cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT t.*, tbFSinif1.sAciklama AS MSINIF1, tbFSinif2.sAciklama AS MSINIF2, tbFSinif3.sAciklama AS MSINIF3, tbFSinif4.sAciklama AS MSINIF4, tbFSinif5.sAciklama AS MSINIF5, tbSSinif1.sAciklama AS SSINIF1, tbSSinif2.sAciklama AS SSINIF2, tbSSinif3.sAciklama AS SSINIF3, tbSSinif4.sAciklama AS SSINIF4, tbSSinif5.sAciklama AS SSINIF5, tbFirma.sSemt, tbFirma.sIl, tbFirma.sUlke, tbFirma.sVergiDairesi FROM (SELECT CAST(tbStokFisiDetayi.nStokFisiID AS NVARCHAR(20)) AS nAlisVerisID , tbStokFisiDetayi.nFirmaID AS nMusteriID , tbFirma.sKodu AS lKodu , tbFirma.sAciklama AS sMusteriAdi , tbStokFisiDetayi.dteFisTarihi AS dteTarih , tbStokFisiMaster.sFisTipi AS fisTipi , tbStokFisiMaster.lFisNo AS lNo , tbStok.nStokID , tbStok.sKodu AS sKodu , tbStok.sAciklama AS sStokAciklama , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 , 0) AS Fiyat , ISNULL(tbStokFisiDetayi.lIskontoTutari * (100 + tbStokFisiDetayi.nKdvOrani) / 100 , 0) AS Iskonto , CAST(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lNetTutar , ISNULL((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nPrim / 100), 0) AS lPrimTutari,tbStokFisiDetayi.sOdemeKodu , tbStokFisiDetayi.sFiyatTipi , tbStokFisiDetayi.sSaticiRumuzu , tbStokFisiDetayi.sKasiyerRumuzu , tbStokFisiDetayi.nGirisCikis , tbStokFisiDetayi.sDepo AS sMagaza , tbStok.sRenk , (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi , tbStok.sBeden , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY , (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET , tbStokFisiDetayi.lMaliyetFiyat , CAST(0 AS MONEY) AS ORAN1 , CAST(0 AS MONEY) AS KAR , CAST(0 AS MONEY) AS FARK , CAST(0 AS MONEY) AS FIYATFARKI , CAST(0 AS MONEY) AS NORMALFIYAT , CAST(0 AS MONEY) AS NORMALTUTAR FROM tbFirma INNER JOIN tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID ON tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID LEFT OUTER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiDetayi.sFisTipi = 'FS') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') " & kriter & ") t INNER JOIN tbFirmaSinifi ON t.nMusteriID = tbFirmaSinifi.nFirmaID INNER JOIN tbFSinif1 ON tbFirmaSinifi.sSinifKodu1 = tbFSinif1.sSinifKodu INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu INNER JOIN tbStokSinifi ON t.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbFirma ON t.nMusteriID = tbFirma.nFirmaID LEFT OUTER JOIN tbSaticiKatlari ON t.sSaticiRumuzu COLLATE Turkish_CI_AS = tbSaticiKatlari.sSaticiRumuzu ORDER BY t.dteTarih, t.lNo")
            End If
        ElseIf firmatipi = True Then
            cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.CAST(nStokFisiID as CHAR(60)) as nAlisVerisID, tbFirma.nFirmaID as nMusteriID, tbFirma.sKodu AS lKodu, tbFirma.sAciklama as sMusteriAdi, tbStokFisiMaster.dteFisTarihi AS dteTarih, tbStokFisiMaster.sFisTipi AS fisTipi, tbStokFisiMaster.lFisNo AS lNo, tbStok.nStokID, tbStok.sKodu AS sKodu, tbStok.sAciklama AS sStokAciklama, ISNULL(tbStokFisiDetayi.lGirisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lBrutFiyat, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari, 0) AS Iskonto, tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbStok.sRenk,(SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi,tbStokFisiDetayi.sDepo as sMagaza FROM tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE tbStokFisiDetayi.nGirisCikis= 1 and tbStokFisiDetayi.dteFisTarihi between '" & tarih1 & " ' and '" & tarih2 & "' " & kriter & "")
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
    Private Sub yetki_kontrol()
        Dim yetki As Int64 = Sorgu_Yetki(kullanici, Me.Name)
        If yetki = 0 Then
            Me.Hide()
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm Yetkiniz Yok!" & vbCrLf & "Lütfen Sistem Yönecinizle Görüþün...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        ElseIf yetki = 1 Then
        End If
    End Sub
    Private Function Sorgu_Yetki(ByVal kasiyerno As Int64, ByVal Form As String, Optional ByVal islem As Integer = 0, Optional ByVal bYetki As Integer = 0) As Int64
        Dim kriter
        kriter = " WHERE     (Personel.PersonelNo = " & kasiyerno & ") AND (Forms.Form = '" & Form & "') "
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitsayisi As Int64 = 0
        Dim formkayitsayisi As Int64 = 0
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS Kayit FROM         aEmirForms WHERE     (Form = '" & Form & "')")
        formkayitsayisi = cmd.ExecuteScalar
        If formkayitsayisi = 0 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO aEmirForms (Modul, Form, Aciklama, DefaultYetki) VALUES     ('Genel', '" & Form & "', '" & Form & "', " & bYetki & ")")
            cmd.ExecuteNonQuery()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(CAST(Personel.Yetki AS int), 0) AS Yetki FROM         aPersonelYetki Personel INNER JOIN                       aEmirForms Forms ON Personel.Form = Forms.Form  " & kriter & "")
        kayitsayisi = cmd.ExecuteScalar
        con.Close()
        If islem = 1 Then
            If kayitsayisi = 0 Then
                kayitsayisi = 1
            ElseIf kayitsayisi = 1 Then
                kayitsayisi = 0
            End If
        End If
        Return kayitsayisi
        'kayitsayisi = Nothing
        formkayitsayisi = Nothing
    End Function
    Private Sub kontrol_oran(ByVal MaliyetTipi As Integer)
        Panelstatus.Visible = True
        bar.Properties.Maximum = DataSet1.Tables(0).Rows.Count
        barlabel.Text = "Toplam Satýr Sayýsý : " & DataSet1.Tables(0).Rows.Count
        bar.Position = 0
        Dim dr As DataRow
        Dim netmaliyet As Decimal = 0
        Dim fiyattipi As String = ""
        For Each dr In DataSet1.Tables(0).Rows
            barlabel.Text = "StokKodu:" & dr("sKodu").ToString & vbTab & "Adý:" & dr("sStokAciklama").ToString
            barlabel.Refresh()
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
            End If
            Try
                dr("ORAN1") = ((dr("lNetTutar") - netmaliyet) / netmaliyet)
                dr("KAR") = dr("lNetTutar") - netmaliyet
            Catch ex As Exception
                dr("ORAN1") = 0
                dr("KAR") = dr("lNetTutar") - netmaliyet
            End Try
            If dr("nGirisCikis") <> 5 Then
                If Trim(dr("sFiyatTipi").ToString) <> "HD" Then
                    fiyattipi = Trim(dr("sFiyatTipi").ToString)
                    If fiyattipi = "10AY" Then
                        If Math.Abs(dr("Fiyat")) <> sorgu_sayi(dr("ONAY"), 0) Then
                            dr("NORMALFIYAT") = sorgu_sayi(dr("ONAY"), 0)
                            dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR")
                            dr("FIYATFARKI") = dr("Fiyat") - dr("NORMALFIYAT")
                        End If
                    ElseIf fiyattipi = "6 AY" Then
                        If Math.Abs(dr("Fiyat")) <> sorgu_sayi(dr("ALTIAY"), 0) Then
                            dr("NORMALFIYAT") = sorgu_sayi(dr("ALTIAY"), 0)
                            dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR")
                            dr("FIYATFARKI") = dr("Fiyat") - dr("NORMALFIYAT")
                        End If
                    ElseIf fiyattipi = "PS" Then
                        If Math.Abs(dr("Fiyat")) <> sorgu_sayi(dr("PESIN"), 0) Then
                            dr("NORMALFIYAT") = sorgu_sayi(dr("PESIN"), 0)
                            dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR")
                            dr("FIYATFARKI") = dr("Fiyat") - dr("NORMALFIYAT")
                        End If
                    End If
                Else
                    If fiyattipi = "10AY" Then
                        dr("NORMALFIYAT") = sorgu_sayi(dr("ONAY"), 0)
                        dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                        dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR") + 0.01
                        dr("FIYATFARKI") = (dr("Fiyat") - dr("NORMALFIYAT")) + +0.01
                    ElseIf fiyattipi = "6 AY" Then
                        dr("NORMALFIYAT") = sorgu_sayi(dr("ALTIAY"), 0)
                        dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                        dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR") + 0.01
                        dr("FIYATFARKI") = (dr("Fiyat") - dr("NORMALFIYAT")) + 0.01
                    ElseIf fiyattipi = "PS" Then
                        dr("NORMALFIYAT") = sorgu_sayi(dr("PESIN"), 0)
                        dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                        dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR") + 0.01
                        dr("FIYATFARKI") = (dr("Fiyat") - dr("NORMALFIYAT")) + 0.01
                    End If
                End If
            End If
            bar.Position = bar.Position + 1
            bar.Refresh()
        Next
        bar.Position = 0
        Panelstatus.Visible = False
        dr = Nothing
    End Sub
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara_stok As String, ByVal konum_stok As String, ByVal ara_kriter_stok As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal MaliyetTipi As Integer)
        DataSet1 = stok(tarih1, tarih2, ara_stok, konum_stok, ara_kriter_stok, ara, konum, ara_kriter, MaliyetTipi)
        kontrol_oran(MaliyetTipi)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        'GridView1.CollapseAllGroups()
        'kontrol_oran()
        InitComboBoxes()
        icbField.SelectedIndex = icbField.Properties.Items.Count - 1
    End Sub
    Private Sub InitComboBoxes()
        Dim field As PivotGridField
        For Each field In GridControl1.Fields
            If field.SortBySummaryInfo.Field Is fieldExtendedPrice Then
                icbField.Properties.Items.Add(New ImageComboBoxItem(field.Caption.ToString(), field, -1))
            End If
        Next
    End Sub
    Private Sub icbField_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbField.SelectedIndexChanged
        GridControl1.BeginUpdate()
        'SetFieldTop()
        If icbField.Text = "StokSýnýf1" Then
            seTop.EditValue = fieldSSINIF1.TopValueCount
            ceTopValuesShowOthers.Checked = fieldSSINIF1.TopValueShowOthers
        ElseIf icbField.Text = "StokSýnýf2" Then
            seTop.EditValue = fieldSSINIF2.TopValueCount
            ceTopValuesShowOthers.Checked = fieldSSINIF2.TopValueShowOthers
        ElseIf icbField.Text = "StokSýnýf3" Then
            seTop.EditValue = fieldSSINIF3.TopValueCount
            ceTopValuesShowOthers.Checked = fieldSSINIF3.TopValueShowOthers
        ElseIf icbField.Text = "StokSýnýf4" Then
            seTop.EditValue = fieldSSINIF4.TopValueCount
            ceTopValuesShowOthers.Checked = fieldSSINIF4.TopValueShowOthers
        ElseIf icbField.Text = "StokSýnýf5" Then
            seTop.EditValue = fieldSSINIF5.TopValueCount
            ceTopValuesShowOthers.Checked = fieldSSINIF5.TopValueShowOthers
        ElseIf icbField.Text = "MüþteriSýnýf1" Then
            seTop.EditValue = fieldMSINIF1.TopValueCount
            ceTopValuesShowOthers.Checked = fieldMSINIF1.TopValueShowOthers
        ElseIf icbField.Text = "MüþteriSýnýf2" Then
            seTop.EditValue = fieldMSINIF2.TopValueCount
            ceTopValuesShowOthers.Checked = fieldMSINIF2.TopValueShowOthers
        ElseIf icbField.Text = "MüþteriSýnýf3" Then
            seTop.EditValue = fieldMSINIF3.TopValueCount
            ceTopValuesShowOthers.Checked = fieldMSINIF3.TopValueShowOthers
        ElseIf icbField.Text = "MüþteriSýnýf4" Then
            seTop.EditValue = fieldMSINIF4.TopValueCount
            ceTopValuesShowOthers.Checked = fieldMSINIF4.TopValueShowOthers
        ElseIf icbField.Text = "MüþteriSýnýf5" Then
            seTop.EditValue = fieldMSINIF5.TopValueCount
            ceTopValuesShowOthers.Checked = fieldMSINIF5.TopValueShowOthers
            'ElseIf icbField.Text = "BelgeÖzelKod1" Then
            '    seTop.EditValue = fieldBELGEKOD1.TopValueCount
            '    ceTopValuesShowOthers.Checked = fieldBELGEKOD2.TopValueShowOthers
            'ElseIf icbField.Text = "BelgeÖzelKod2" Then
            '    seTop.EditValue = fieldBELGEKOD2.TopValueCount
            '    ceTopValuesShowOthers.Checked = fieldBELGEKOD2.TopValueShowOthers
        ElseIf icbField.Text = "Maðaza" Then
            seTop.EditValue = fieldsMagaza.TopValueCount
            ceTopValuesShowOthers.Checked = fieldsMagaza.TopValueShowOthers
        ElseIf icbField.Text = "Miktar" Then
            seTop.EditValue = fieldMiktar.TopValueCount
            ceTopValuesShowOthers.Checked = fieldMiktar.TopValueShowOthers
        ElseIf icbField.Text = "Tutar" Then
            seTop.EditValue = fieldlNetTutar.TopValueCount
            ceTopValuesShowOthers.Checked = fieldlNetTutar.TopValueShowOthers
            'ElseIf icbField.Text = "ToplamMaliyet" Then
            '    seTop.EditValue = fieldTOPLAMMALIYET.TopValueCount
            '    ceTopValuesShowOthers.Checked = fieldTOPLAMMALIYET.TopValueShowOthers
        ElseIf icbField.Text = "Kar" Then
            seTop.EditValue = fieldKAR.TopValueCount
            ceTopValuesShowOthers.Checked = fieldKAR.TopValueShowOthers
        ElseIf icbField.Text = "FisTipi" Then
            seTop.EditValue = fieldfisTipi.TopValueCount
            ceTopValuesShowOthers.Checked = fieldfisTipi.TopValueShowOthers
        ElseIf icbField.Text = "Tarih" Then
            seTop.EditValue = fielddteTarih.TopValueCount
            ceTopValuesShowOthers.Checked = fielddteTarih.TopValueShowOthers
            'ElseIf icbField.Text = "Ay" Then
            '    seTop.EditValue = fieldAY.TopValueCount
            '    ceTopValuesShowOthers.Checked = fieldAY.TopValueShowOthers
            'ElseIf icbField.Text = "HAFTA" Then
            '    seTop.EditValue = fieldHAFTA.TopValueCount
            '    ceTopValuesShowOthers.Checked = fieldHAFTA.TopValueShowOthers
            'ElseIf icbField.Text = "Gün" Then
            '    seTop.EditValue = fieldGUN.TopValueCount
            '    ceTopValuesShowOthers.Checked = fieldGUN.TopValueShowOthers
            'ElseIf icbField.Text = "YIL" Then
            '    seTop.EditValue = fieldYIL.TopValueCount
            '    ceTopValuesShowOthers.Checked = fieldYIL.TopValueShowOthers
        ElseIf icbField.Text = "Satýcý" Then
            seTop.EditValue = fieldsSaticiRumuzu.TopValueCount
            ceTopValuesShowOthers.Checked = fieldsSaticiRumuzu.TopValueShowOthers
        End If
        GridControl1.EndUpdate()
    End Sub
    Private Sub SetFieldTop()
        If TypeOf icbField.EditValue Is PivotGridField Then
            'Dim field As PivotGridField = icbField.EditValue
            'field.TopValueCount = Convert.ToInt32(seTop.Value)
            'field.TopValueShowOthers = ceTopValuesShowOthers.Checked
            If icbField.Text = "StokSýnýf1" Then
                fieldSSINIF1.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldSSINIF1.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala.Text <> "A-Z / Z-A" Then
                    fieldSSINIF1.SortBySummaryInfo.FieldName = sec_sirala.Text
                    fieldSSINIF1.SortMode = PivotSortMode.Value
                Else
                    fieldSSINIF1.SortBySummaryInfo.FieldName = Nothing
                    fieldSSINIF1.SortMode = PivotSortMode.Default
                End If
            ElseIf icbField.Text = "StokSýnýf2" Then
                fieldSSINIF2.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldSSINIF2.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala.Text <> "A-Z / Z-A" Then
                    fieldSSINIF2.SortBySummaryInfo.FieldName = sec_sirala.Text
                    fieldSSINIF2.SortMode = PivotSortMode.Value
                Else
                    fieldSSINIF2.SortBySummaryInfo.FieldName = Nothing
                    fieldSSINIF2.SortMode = PivotSortMode.Default
                End If
            ElseIf icbField.Text = "StokSýnýf3" Then
                fieldSSINIF3.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldSSINIF3.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala.Text <> "A-Z / Z-A" Then
                    fieldSSINIF3.SortBySummaryInfo.FieldName = sec_sirala.Text
                    fieldSSINIF3.SortMode = PivotSortMode.Value
                Else
                    fieldSSINIF3.SortBySummaryInfo.FieldName = Nothing
                    fieldSSINIF3.SortMode = PivotSortMode.Default
                End If
            ElseIf icbField.Text = "StokSýnýf4" Then
                fieldSSINIF4.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldSSINIF4.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala.Text <> "A-Z / Z-A" Then
                    fieldSSINIF4.SortBySummaryInfo.FieldName = sec_sirala.Text
                    fieldSSINIF4.SortMode = PivotSortMode.Value
                Else
                    fieldSSINIF4.SortBySummaryInfo.FieldName = Nothing
                    fieldSSINIF4.SortMode = PivotSortMode.Default
                End If
            ElseIf icbField.Text = "StokSýnýf5" Then
                fieldSSINIF5.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldSSINIF5.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala.Text <> "A-Z / Z-A" Then
                    fieldSSINIF5.SortBySummaryInfo.FieldName = sec_sirala.Text
                    fieldSSINIF5.SortMode = PivotSortMode.Value
                Else
                    fieldSSINIF5.SortBySummaryInfo.FieldName = Nothing
                    fieldSSINIF5.SortMode = PivotSortMode.Default
                End If
            ElseIf icbField.Text = "MüþteriSýnýf1" Then
                fieldMSINIF1.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldMSINIF1.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala.Text <> "A-Z / Z-A" Then
                    fieldMSINIF1.SortBySummaryInfo.FieldName = sec_sirala.Text
                    fieldMSINIF1.SortMode = PivotSortMode.Value
                Else
                    fieldMSINIF1.SortBySummaryInfo.FieldName = Nothing
                    fieldMSINIF1.SortMode = PivotSortMode.Default
                End If
            ElseIf icbField.Text = "MüþteriSýnýf2" Then
                fieldMSINIF2.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldMSINIF2.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala.Text <> "A-Z / Z-A" Then
                    fieldMSINIF2.SortBySummaryInfo.FieldName = sec_sirala.Text
                    fieldMSINIF2.SortMode = PivotSortMode.Value
                Else
                    fieldMSINIF2.SortBySummaryInfo.FieldName = Nothing
                    fieldMSINIF2.SortMode = PivotSortMode.Default
                End If
            ElseIf icbField.Text = "MüþteriSýnýf3" Then
                fieldMSINIF3.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldMSINIF3.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala.Text <> "A-Z / Z-A" Then
                    fieldMSINIF3.SortBySummaryInfo.FieldName = sec_sirala.Text
                    fieldMSINIF3.SortMode = PivotSortMode.Value
                Else
                    fieldMSINIF3.SortBySummaryInfo.FieldName = Nothing
                    fieldMSINIF3.SortMode = PivotSortMode.Default
                End If
            ElseIf icbField.Text = "MüþteriSýnýf4" Then
                fieldMSINIF4.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldMSINIF4.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala.Text <> "A-Z / Z-A" Then
                    fieldMSINIF4.SortBySummaryInfo.FieldName = sec_sirala.Text
                    fieldMSINIF4.SortMode = PivotSortMode.Value
                Else
                    fieldMSINIF4.SortBySummaryInfo.FieldName = Nothing
                    fieldMSINIF4.SortMode = PivotSortMode.Default
                End If
            ElseIf icbField.Text = "MüþteriSýnýf5" Then
                fieldMSINIF5.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldMSINIF5.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala.Text <> "A-Z / Z-A" Then
                    fieldMSINIF5.SortBySummaryInfo.FieldName = sec_sirala.Text
                    fieldMSINIF5.SortMode = PivotSortMode.Value
                Else
                    fieldMSINIF5.SortBySummaryInfo.FieldName = Nothing
                    fieldMSINIF5.SortMode = PivotSortMode.Default
                End If
            ElseIf icbField.Text = "Maðaza" Then
                fieldsMagaza.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldsMagaza.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala.Text <> "A-Z / Z-A" Then
                    fieldsMagaza.SortBySummaryInfo.FieldName = sec_sirala.Text
                    fieldsMagaza.SortMode = PivotSortMode.Value
                Else
                    fieldsMagaza.SortBySummaryInfo.FieldName = Nothing
                    fieldsMagaza.SortMode = PivotSortMode.Default
                End If
            ElseIf icbField.Text = "Miktar" Then
                fieldMiktar.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldMiktar.TopValueShowOthers = ceTopValuesShowOthers.Checked
                'If sec_sirala.Text <> "A-Z / Z-A" Then
                '    fieldCARIKOD1.SortBySummaryInfo.FieldName = sec_sirala.Text
                '    fieldCARIKOD1.SortMode = PivotSortMode.Value
                'Else
                '    fieldCARIKOD1.SortBySummaryInfo.FieldName = Nothing
                '    fieldCARIKOD1.SortMode = PivotSortMode.Default
                'End If
            ElseIf icbField.Text = "Tutar" Then
                fieldlNetTutar.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldlNetTutar.TopValueShowOthers = ceTopValuesShowOthers.Checked
                'ElseIf icbField.Text = "ToplamMaliyet" Then
                '    fieldTOPLAMMALIYET.TopValueCount = Convert.ToInt32(seTop.Value)
                '    fieldTOPLAMMALIYET.TopValueShowOthers = ceTopValuesShowOthers.Checked
            ElseIf icbField.Text = "Kar" Then
                fieldKAR.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldKAR.TopValueShowOthers = ceTopValuesShowOthers.Checked
            ElseIf icbField.Text = "FiþTipi" Then
                fieldfisTipi.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldfisTipi.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala.Text <> "A-Z / Z-A" Then
                    fieldfisTipi.SortBySummaryInfo.FieldName = sec_sirala.Text
                    fieldfisTipi.SortMode = PivotSortMode.Value
                Else
                    fieldfisTipi.SortBySummaryInfo.FieldName = Nothing
                    fieldfisTipi.SortMode = PivotSortMode.Default
                End If
            ElseIf icbField.Text = "Tarih" Then
                fielddteTarih.TopValueCount = Convert.ToInt32(seTop.Value)
                fielddteTarih.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala.Text <> "A-Z / Z-A" Then
                    fielddteTarih.SortBySummaryInfo.FieldName = sec_sirala.Text
                    fielddteTarih.SortMode = PivotSortMode.Value
                Else
                    fielddteTarih.SortBySummaryInfo.FieldName = Nothing
                    fielddteTarih.SortMode = PivotSortMode.Default
                End If
            ElseIf icbField.Text = "StokAdý" Then
                fieldsStokAciklama.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldsStokAciklama.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala.Text <> "A-Z / Z-A" Then
                    fieldsStokAciklama.SortBySummaryInfo.FieldName = sec_sirala.Text
                    fieldsStokAciklama.SortMode = PivotSortMode.Value
                Else
                    fieldsStokAciklama.SortBySummaryInfo.FieldName = Nothing
                    fieldsStokAciklama.SortMode = PivotSortMode.Default
                End If
                'ElseIf icbField.Text = "Ay" Then
                '    fieldAY.TopValueCount = Convert.ToInt32(seTop.Value)
                '    fieldAY.TopValueShowOthers = ceTopValuesShowOthers.Checked
                '    If sec_sirala.Text <> "A-Z / Z-A" Then
                '        fieldAY.SortBySummaryInfo.FieldName = sec_sirala.Text
                '        fieldAY.SortMode = PivotSortMode.Value
                '    Else
                '        fieldAY.SortBySummaryInfo.FieldName = Nothing
                '        fieldAY.SortMode = PivotSortMode.Default
                '    End If
                'ElseIf icbField.Text = "HAFTA" Then
                '    fieldHAFTA.TopValueCount = Convert.ToInt32(seTop.Value)
                '    fieldHAFTA.TopValueShowOthers = ceTopValuesShowOthers.Checked
                '    If sec_sirala.Text <> "A-Z / Z-A" Then
                '        fieldHAFTA.SortBySummaryInfo.FieldName = sec_sirala.Text
                '        fieldHAFTA.SortMode = PivotSortMode.Value
                '    Else
                '        fieldHAFTA.SortBySummaryInfo.FieldName = Nothing
                '        fieldHAFTA.SortMode = PivotSortMode.Default
                '    End If
                'ElseIf icbField.Text = "QUARTER" Then
                '    fieldQUARTER.TopValueCount = Convert.ToInt32(seTop.Value)
                '    fieldQUARTER.TopValueShowOthers = ceTopValuesShowOthers.Checked
                '    If sec_sirala.Text <> "A-Z / Z-A" Then
                '        fieldQUARTER.SortBySummaryInfo.FieldName = sec_sirala.Text
                '        fieldQUARTER.SortMode = PivotSortMode.Value
                '    Else
                '        fieldQUARTER.SortBySummaryInfo.FieldName = Nothing
                '        fieldQUARTER.SortMode = PivotSortMode.Default
                '    End If
                'ElseIf icbField.Text = "YIL" Then
                '    fieldYIL.TopValueCount = Convert.ToInt32(seTop.Value)
                '    fieldYIL.TopValueShowOthers = ceTopValuesShowOthers.Checked
                '    If sec_sirala.Text <> "A-Z / Z-A" Then
                '        fieldYIL.SortBySummaryInfo.FieldName = sec_sirala.Text
                '        fieldYIL.SortMode = PivotSortMode.Value
                '    Else
                '        fieldYIL.SortBySummaryInfo.FieldName = Nothing
                '        fieldYIL.SortMode = PivotSortMode.Default
                '    End If
            ElseIf icbField.Text = "Satýcý" Then
                fieldsSaticiRumuzu.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldsSaticiRumuzu.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala.Text <> "A-Z / Z-A" Then
                    fieldsSaticiRumuzu.SortBySummaryInfo.FieldName = sec_sirala.Text
                    fieldsSaticiRumuzu.SortMode = PivotSortMode.Value
                Else
                    fieldsSaticiRumuzu.SortBySummaryInfo.FieldName = Nothing
                    fieldsSaticiRumuzu.SortMode = PivotSortMode.Default
                End If
            ElseIf icbField.Text = "Kat" Then
                fieldsKat.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldsKat.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala.Text <> "A-Z / Z-A" Then
                    fieldsKat.SortBySummaryInfo.FieldName = sec_sirala.Text
                    fieldsKat.SortMode = PivotSortMode.Value
                Else
                    fieldsKat.SortBySummaryInfo.FieldName = Nothing
                    fieldsKat.SortMode = PivotSortMode.Default
                End If
            ElseIf icbField.Text = "Satici" Then
                fieldSatici.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldSatici.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala.Text <> "A-Z / Z-A" Then
                    fieldSatici.SortBySummaryInfo.FieldName = sec_sirala.Text
                    fieldSatici.SortMode = PivotSortMode.Value
                Else
                    fieldSatici.SortBySummaryInfo.FieldName = Nothing
                    fieldSatici.SortMode = PivotSortMode.Default
                End If
            End If
        End If
    End Sub
    Private Sub stok_satis_detay()
        'If GridView1.RowCount > 0 Then
        '    Dim frm As New frm_stok_cari_satis
        '    Dim dr As DataRow
        '    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    frm.status = True
        '    frm.firmano = 100
        '    frm.donemno = 1
        '    frm.connection = connection
        '    frm.islemstatus = True
        '    frm.stokno = dr("nAlisverisID")
        '    frm.fistipi = Trim(dr("sFisTipi").ToString)
        '    frm.ShowDialog()
        '    frm.Close()
        '    dr = Nothing
        'End If
    End Sub
    Private Sub analiz_musteri_karti()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_musteri_karti
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.musterino = dr("lKodu")
        '    frm.musteriID = dr("nMusteriID")
        '    frm.ShowDialog()
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub analiz_acik_faturalar_analiz()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_cari_faturalar_acik_analiz
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.musterino = dr("nMusteriID")
        '    frm.ShowDialog()
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub analiz_acik_faturalar()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_cari_faturalar_acik
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.musterino = dr("nMusteriID")
        '    frm.ShowDialog()
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub analiz_musteri_satislar()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_cari_faturalar_kapatma
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.musterino = dr("lKodu")
        '    frm.musteriID = dr("nMusteriID")
        '    frm.ShowDialog()
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub analiz_envanter()
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow
        '    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim frm As New frm_stok_envanter
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.stokno = dr("nStokId")
        '    frm.stokkodu = dr("sKodu")
        '    frm.ShowDialog()
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stok_satis_detay()
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs)
        'If GridView1.SelectedRowsCount > 1 Then
        '    Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        'ElseIf GridView1.SelectedRowsCount = 1 Then
        '    Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        'Else
        '    Label2.Text = ""
        'End If
        'Dim dr As DataRow
        'dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'lbl_istihbarat.Text = dr("ISTIHBARAT")
        'dr = Nothing
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
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
        loading()
    End Sub
    Sub loading()
        SimpleButton3.Enabled = False
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        'Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, txt_ara_stok.EditValue, sec_konum_stok.EditValue, sec_kriter_stok.EditValue, txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, sec_MaliyetTipi.SelectedIndex)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        SimpleButton3.Enabled = True
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        analiz_envanter()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If islemstatus = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                'Me.Close()
            End If
        End If
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If islemstatus = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            'Me.Close()
        End If
    End Sub
    Private Sub ceTopValuesShowOthers_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceTopValuesShowOthers.CheckedChanged
        SetFieldTop()
    End Sub
    Private Sub seTop_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seTop.EditValueChanged
        SetFieldTop()
    End Sub
    Private Sub sec_sirala_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sirala.SelectedIndexChanged
        SetFieldTop()
    End Sub
    Friend WithEvents fieldsGun As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsHafta As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsAy As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsQuarter As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsYil As DevExpress.XtraPivotGrid.PivotGridField
End Class
