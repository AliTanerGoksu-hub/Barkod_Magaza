Imports System.Windows.Forms
Imports DevExpress.XtraExport
Imports DevExpress.XtraGrid.Export
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Wizard
Imports DevExpress.XtraCharts.Design
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors.Controls
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_stok_satis_ciro_sinif_analiz
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
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_periyod As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_baslik As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chColorEach As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_renk As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents printlink2 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents sec_yeni As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_alisveris As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents sec_satici As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sinifno As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_kayitsayisi As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents sec_sirala As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents GridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldPERIYOD As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsSinifKodu As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsAciklama As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMiktar As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldIskonto As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTutar As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMUSTERISAYISI As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldYil As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAy As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldGUN1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHafta As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMaliyet As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldYuzde As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldKar As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldCeyrek As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents Label11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ceTopValuesShowOthers As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents icbField As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents seTop As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents sec_sirala2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents sec_depo As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents sec_grid As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_nGorunum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents fieldMevcut As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsMagaza As DevExpress.XtraPivotGrid.PivotGridField
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_satis_ciro_sinif_analiz))
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_depo = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.sec_sirala = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_kayitsayisi = New DevExpress.XtraEditors.SpinEdit()
        Me.Label10 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_sinifno = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label9 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_satici = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_alisveris = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_yeni = New DevExpress.XtraEditors.CheckEdit()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_periyod = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.sec_nGorunum = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_sirala2 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ceTopValuesShowOthers = New DevExpress.XtraEditors.CheckEdit()
        Me.icbField = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.seTop = New DevExpress.XtraEditors.SpinEdit()
        Me.sec_baslik = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_renk = New DevExpress.XtraEditors.CheckEdit()
        Me.chColorEach = New DevExpress.XtraEditors.CheckEdit()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label11 = New DevExpress.XtraEditors.LabelControl()
        Me.Label12 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.sec_grid = New DevExpress.XtraEditors.PopupContainerControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSEC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.fieldPERIYOD = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldsSinifKodu = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldsAciklama = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMiktar = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldIskonto = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTutar = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMUSTERISAYISI = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldYil = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldAy = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldGUN1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHafta = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMaliyet = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldYuzde = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldKar = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldCeyrek = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldsMagaza = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMevcut = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
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
        Me.DataSet1 = New System.Data.DataSet()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink2 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sirala.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kayitsayisi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sinifno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_satici.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_alisveris.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_yeni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_periyod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.sec_nGorunum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sirala2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceTopValuesShowOthers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icbField.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seTop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_baslik.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_renk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chColorEach.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sec_grid.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink2.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 149)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_depo)
        Me.GroupControl1.Controls.Add(Me.sec_sirala)
        Me.GroupControl1.Controls.Add(Me.sec_kayitsayisi)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Controls.Add(Me.sec_sinifno)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.sec_satici)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.sec_alisveris)
        Me.GroupControl1.Controls.Add(Me.sec_yeni)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.sec_periyod)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(726, 145)
        Me.GroupControl1.TabIndex = 38
        Me.GroupControl1.Text = "Ara"
        '
        'sec_depo
        '
        Me.sec_depo.EditValue = "[Tümü]"
        Me.sec_depo.EnterMoveNextControl = True
        Me.sec_depo.Location = New System.Drawing.Point(64, 50)
        Me.sec_depo.Name = "sec_depo"
        Me.sec_depo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo.Properties.ShowPopupCloseButton = False
        Me.sec_depo.Size = New System.Drawing.Size(200, 20)
        Me.sec_depo.TabIndex = 2
        '
        'sec_sirala
        '
        Me.sec_sirala.EditValue = "Tutar"
        Me.sec_sirala.Enabled = False
        Me.sec_sirala.EnterMoveNextControl = True
        Me.sec_sirala.Location = New System.Drawing.Point(264, 110)
        Me.sec_sirala.Name = "sec_sirala"
        Me.sec_sirala.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sirala.Properties.Items.AddRange(New Object() {"Miktar", "Iskonto", "Tutar", "Kar", "MüþteriSayýsý"})
        Me.sec_sirala.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sirala.Size = New System.Drawing.Size(80, 20)
        Me.sec_sirala.TabIndex = 47
        '
        'sec_kayitsayisi
        '
        Me.sec_kayitsayisi.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.sec_kayitsayisi.EnterMoveNextControl = True
        Me.sec_kayitsayisi.Location = New System.Drawing.Point(184, 110)
        Me.sec_kayitsayisi.Name = "sec_kayitsayisi"
        Me.sec_kayitsayisi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_kayitsayisi.Size = New System.Drawing.Size(80, 20)
        Me.sec_kayitsayisi.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(160, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Top:"
        '
        'sec_sinifno
        '
        Me.sec_sinifno.EditValue = "1"
        Me.sec_sinifno.EnterMoveNextControl = True
        Me.sec_sinifno.Location = New System.Drawing.Point(64, 70)
        Me.sec_sinifno.Name = "sec_sinifno"
        Me.sec_sinifno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sinifno.Properties.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.sec_sinifno.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sinifno.Size = New System.Drawing.Size(40, 20)
        Me.sec_sinifno.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(36, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Sýnýf:"
        '
        'sec_satici
        '
        Me.sec_satici.EnterMoveNextControl = True
        Me.sec_satici.Location = New System.Drawing.Point(104, 70)
        Me.sec_satici.Name = "sec_satici"
        Me.sec_satici.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_satici.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IND", 10, "KayýtNo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SATICI", 35, "Satýcý")})
        Me.sec_satici.Properties.DisplayMember = "SATICI"
        Me.sec_satici.Properties.NullText = "[Sýnýflar]"
        Me.sec_satici.Properties.ValueMember = "IND"
        Me.sec_satici.Size = New System.Drawing.Size(160, 20)
        Me.sec_satici.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(14, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "AlýþVeriþ :"
        '
        'sec_alisveris
        '
        Me.sec_alisveris.EditValue = "[Tümü]"
        Me.sec_alisveris.EnterMoveNextControl = True
        Me.sec_alisveris.Location = New System.Drawing.Point(64, 90)
        Me.sec_alisveris.Name = "sec_alisveris"
        Me.sec_alisveris.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.sec_alisveris.Properties.Appearance.Options.UseForeColor = True
        Me.sec_alisveris.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_alisveris.Properties.Items.AddRange(New Object() {"[Tümü]", "Kredili Satýþlar", "Kredili", "Sonradan Teslim Kredili", "Peþin", "Peþin Satýþlar", "Sonradan Teslim Peþin"})
        Me.sec_alisveris.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_alisveris.Size = New System.Drawing.Size(200, 20)
        Me.sec_alisveris.TabIndex = 5
        '
        'sec_yeni
        '
        Me.sec_yeni.Location = New System.Drawing.Point(264, 70)
        Me.sec_yeni.Name = "sec_yeni"
        Me.sec_yeni.Properties.Caption = "Yeni Müþteri"
        Me.sec_yeni.Size = New System.Drawing.Size(88, 19)
        Me.sec_yeni.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(17, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Periyod :"
        '
        'sec_periyod
        '
        Me.sec_periyod.EditValue = "Günlük"
        Me.sec_periyod.EnterMoveNextControl = True
        Me.sec_periyod.Location = New System.Drawing.Point(64, 110)
        Me.sec_periyod.Name = "sec_periyod"
        Me.sec_periyod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_periyod.Properties.Items.AddRange(New Object() {"Günlük", "Haftalýk", "Haftanýn Günü", "Aylýk", "Quarter", "Yýllýk"})
        Me.sec_periyod.Properties.ReadOnly = True
        Me.sec_periyod.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_periyod.Size = New System.Drawing.Size(96, 20)
        Me.sec_periyod.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Maðaza :"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(272, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "arasýndaki"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(29, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Tarih :"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(161, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "ve"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(181, 30)
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
        Me.DateEdit1.Location = New System.Drawing.Point(64, 30)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(96, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(352, 110)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 20)
        Me.SimpleButton3.TabIndex = 8
        Me.SimpleButton3.Text = "&Listele"
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
        Me.PictureBox1.Size = New System.Drawing.Size(94, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.sec_nGorunum)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.sec_sirala2)
        Me.PanelControl2.Controls.Add(Me.ceTopValuesShowOthers)
        Me.PanelControl2.Controls.Add(Me.icbField)
        Me.PanelControl2.Controls.Add(Me.seTop)
        Me.PanelControl2.Controls.Add(Me.sec_baslik)
        Me.PanelControl2.Controls.Add(Me.sec_renk)
        Me.PanelControl2.Controls.Add(Me.chColorEach)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Controls.Add(Me.Label11)
        Me.PanelControl2.Controls.Add(Me.Label12)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 381)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'sec_nGorunum
        '
        Me.sec_nGorunum.EditValue = "0"
        Me.sec_nGorunum.Location = New System.Drawing.Point(76, 1)
        Me.sec_nGorunum.Name = "sec_nGorunum"
        Me.sec_nGorunum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_nGorunum.Properties.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.sec_nGorunum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_nGorunum.Size = New System.Drawing.Size(73, 20)
        Me.sec_nGorunum.TabIndex = 53
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl1.Location = New System.Drawing.Point(7, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl1.TabIndex = 52
        Me.LabelControl1.Text = "GörünümTipi:"
        '
        'sec_sirala2
        '
        Me.sec_sirala2.EditValue = "Tutar"
        Me.sec_sirala2.EnterMoveNextControl = True
        Me.sec_sirala2.Location = New System.Drawing.Point(203, 26)
        Me.sec_sirala2.Name = "sec_sirala2"
        Me.sec_sirala2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sirala2.Properties.Items.AddRange(New Object() {"Tutar", "Maliyet", "Miktar", "Kar", "A-Z / Z-A"})
        Me.sec_sirala2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sirala2.Size = New System.Drawing.Size(88, 20)
        Me.sec_sirala2.TabIndex = 22
        '
        'ceTopValuesShowOthers
        '
        Me.ceTopValuesShowOthers.EditValue = True
        Me.ceTopValuesShowOthers.Location = New System.Drawing.Point(363, 2)
        Me.ceTopValuesShowOthers.Name = "ceTopValuesShowOthers"
        Me.ceTopValuesShowOthers.Properties.Caption = "Diðerlerini Topla"
        Me.ceTopValuesShowOthers.Size = New System.Drawing.Size(98, 19)
        Me.ceTopValuesShowOthers.TabIndex = 20
        '
        'icbField
        '
        Me.icbField.EditValue = "Açýklama"
        Me.icbField.EnterMoveNextControl = True
        Me.icbField.Location = New System.Drawing.Point(203, 2)
        Me.icbField.Name = "icbField"
        Me.icbField.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.icbField.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.icbField.Size = New System.Drawing.Size(88, 20)
        Me.icbField.TabIndex = 18
        '
        'seTop
        '
        Me.seTop.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seTop.EnterMoveNextControl = True
        Me.seTop.Location = New System.Drawing.Point(299, 2)
        Me.seTop.Name = "seTop"
        Me.seTop.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.seTop.Size = New System.Drawing.Size(56, 20)
        Me.seTop.TabIndex = 19
        '
        'sec_baslik
        '
        Me.sec_baslik.EditValue = True
        Me.sec_baslik.Location = New System.Drawing.Point(560, 24)
        Me.sec_baslik.Name = "sec_baslik"
        Me.sec_baslik.Properties.Caption = "Baþlýk Göster"
        Me.sec_baslik.Size = New System.Drawing.Size(96, 19)
        Me.sec_baslik.TabIndex = 16
        '
        'sec_renk
        '
        Me.sec_renk.Location = New System.Drawing.Point(464, 24)
        Me.sec_renk.Name = "sec_renk"
        Me.sec_renk.Properties.Caption = "Yüzdeyi Göster"
        Me.sec_renk.Size = New System.Drawing.Size(96, 19)
        Me.sec_renk.TabIndex = 15
        '
        'chColorEach
        '
        Me.chColorEach.EditValue = True
        Me.chColorEach.Location = New System.Drawing.Point(464, 8)
        Me.chColorEach.Name = "chColorEach"
        Me.chColorEach.Properties.Caption = "Renklendir"
        Me.chColorEach.Size = New System.Drawing.Size(80, 19)
        Me.chColorEach.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(43, 30)
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
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(155, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Sýrala :"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(155, 2)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "TopList :"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 149)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 232)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 228)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.sec_grid)
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(818, 195)
        Me.XtraTabPage1.Text = "Ta&blo..."
        '
        'sec_grid
        '
        Me.sec_grid.Controls.Add(Me.GridControl2)
        Me.sec_grid.Location = New System.Drawing.Point(163, 3)
        Me.sec_grid.Name = "sec_grid"
        Me.sec_grid.Size = New System.Drawing.Size(232, 128)
        Me.sec_grid.TabIndex = 50
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(232, 128)
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
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataMember = Nothing
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldPERIYOD, Me.fieldsSinifKodu, Me.fieldsAciklama, Me.fieldMiktar, Me.fieldIskonto, Me.fieldTutar, Me.fieldMUSTERISAYISI, Me.fieldYil, Me.fieldAy, Me.fieldGUN1, Me.fieldHafta, Me.fieldMaliyet, Me.fieldYuzde, Me.fieldKar, Me.fieldCeyrek, Me.fieldsMagaza, Me.fieldMevcut})
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
        Me.GridControl1.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea
        Me.GridControl1.OptionsDataField.AreaIndex = 3
        Me.GridControl1.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridControl1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridControl1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridControl1.OptionsPrint.PrintRowHeaders = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridControl1.Size = New System.Drawing.Size(818, 195)
        Me.GridControl1.TabIndex = 0
        '
        'fieldPERIYOD
        '
        Me.fieldPERIYOD.AreaIndex = 0
        Me.fieldPERIYOD.Caption = "Periyod"
        Me.fieldPERIYOD.FieldName = "PERIYOD"
        Me.fieldPERIYOD.Name = "fieldPERIYOD"
        Me.fieldPERIYOD.Visible = False
        '
        'fieldsSinifKodu
        '
        Me.fieldsSinifKodu.AreaIndex = 1
        Me.fieldsSinifKodu.Caption = "Sýnýf Kodu"
        Me.fieldsSinifKodu.FieldName = "sSinifKodu"
        Me.fieldsSinifKodu.Name = "fieldsSinifKodu"
        Me.fieldsSinifKodu.Visible = False
        '
        'fieldsAciklama
        '
        Me.fieldsAciklama.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldsAciklama.AreaIndex = 0
        Me.fieldsAciklama.Caption = "Açýklama"
        Me.fieldsAciklama.FieldName = "sAciklama"
        Me.fieldsAciklama.Name = "fieldsAciklama"
        '
        'fieldMiktar
        '
        Me.fieldMiktar.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldMiktar.AreaIndex = 0
        Me.fieldMiktar.CellFormat.FormatString = "#,0.####"
        Me.fieldMiktar.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldMiktar.FieldName = "Miktar"
        Me.fieldMiktar.Name = "fieldMiktar"
        '
        'fieldIskonto
        '
        Me.fieldIskonto.AreaIndex = 0
        Me.fieldIskonto.FieldName = "Iskonto"
        Me.fieldIskonto.Name = "fieldIskonto"
        Me.fieldIskonto.Visible = False
        '
        'fieldTutar
        '
        Me.fieldTutar.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldTutar.AreaIndex = 1
        Me.fieldTutar.CellFormat.FormatString = "#,0.00"
        Me.fieldTutar.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldTutar.FieldName = "Tutar"
        Me.fieldTutar.Name = "fieldTutar"
        '
        'fieldMUSTERISAYISI
        '
        Me.fieldMUSTERISAYISI.AreaIndex = 0
        Me.fieldMUSTERISAYISI.Caption = "Müþteri Sayýsý"
        Me.fieldMUSTERISAYISI.CellFormat.FormatString = "#,0.####"
        Me.fieldMUSTERISAYISI.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldMUSTERISAYISI.FieldName = "MUSTERISAYISI"
        Me.fieldMUSTERISAYISI.Name = "fieldMUSTERISAYISI"
        '
        'fieldYil
        '
        Me.fieldYil.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldYil.AreaIndex = 0
        Me.fieldYil.Caption = "Yýl"
        Me.fieldYil.FieldName = "Yil"
        Me.fieldYil.Name = "fieldYil"
        '
        'fieldAy
        '
        Me.fieldAy.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldAy.AreaIndex = 2
        Me.fieldAy.FieldName = "Ay"
        Me.fieldAy.Name = "fieldAy"
        '
        'fieldGUN1
        '
        Me.fieldGUN1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldGUN1.AreaIndex = 1
        Me.fieldGUN1.FieldName = "GUN"
        Me.fieldGUN1.Name = "fieldGUN1"
        '
        'fieldHafta
        '
        Me.fieldHafta.AreaIndex = 2
        Me.fieldHafta.FieldName = "Hafta"
        Me.fieldHafta.Name = "fieldHafta"
        '
        'fieldMaliyet
        '
        Me.fieldMaliyet.AreaIndex = 2
        Me.fieldMaliyet.CellFormat.FormatString = "#,0.00"
        Me.fieldMaliyet.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldMaliyet.FieldName = "Maliyet"
        Me.fieldMaliyet.Name = "fieldMaliyet"
        Me.fieldMaliyet.Visible = False
        '
        'fieldYuzde
        '
        Me.fieldYuzde.AreaIndex = 2
        Me.fieldYuzde.FieldName = "Yuzde"
        Me.fieldYuzde.Name = "fieldYuzde"
        Me.fieldYuzde.Visible = False
        '
        'fieldKar
        '
        Me.fieldKar.AreaIndex = 4
        Me.fieldKar.CellFormat.FormatString = "#,0.00"
        Me.fieldKar.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldKar.FieldName = "Kar"
        Me.fieldKar.Name = "fieldKar"
        '
        'fieldCeyrek
        '
        Me.fieldCeyrek.AreaIndex = 3
        Me.fieldCeyrek.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldCeyrek.FieldName = "Ceyrek"
        Me.fieldCeyrek.Name = "fieldCeyrek"
        '
        'fieldsMagaza
        '
        Me.fieldsMagaza.AreaIndex = 1
        Me.fieldsMagaza.Caption = "Maðaza"
        Me.fieldsMagaza.FieldName = "sMagaza"
        Me.fieldsMagaza.Name = "fieldsMagaza"
        '
        'fieldMevcut
        '
        Me.fieldMevcut.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldMevcut.AreaIndex = 1
        Me.fieldMevcut.Caption = "Mevcut"
        Me.fieldMevcut.CellFormat.FormatString = "#,0.####"
        Me.fieldMevcut.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldMevcut.FieldName = "Mevcut"
        Me.fieldMevcut.Name = "fieldMevcut"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.ChartControl1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(814, 200)
        Me.XtraTabPage2.Text = "&Grafik..."
        '
        'ChartControl1
        '
        Me.ChartControl1.DataSource = Me.GridControl1
        XyDiagram1.AxisX.Label.ResolveOverlappingMode = DevExpress.XtraCharts.AxisLabelResolveOverlappingMode.HideOverlapped
        XyDiagram1.AxisX.Label.Staggered = True
        XyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram1.AxisX.Range.SideMarginsEnabled = True
        XyDiagram1.AxisX.Title.Text = "Açýklama Mevcut"
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
        XyDiagram1.AxisY.Range.SideMarginsEnabled = True
        XyDiagram1.AxisY.Title.Text = "Miktar Tutar"
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChartControl1.Legend.MaxHorizontalPercentage = 30.0R
        Me.ChartControl1.Location = New System.Drawing.Point(0, 0)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesDataMember = "Series"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl1.SeriesTemplate.ArgumentDataMember = "Arguments"
        Me.ChartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        SideBySideBarSeriesLabel1.LineVisible = True
        SideBySideBarSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
        Me.ChartControl1.SeriesTemplate.Label = SideBySideBarSeriesLabel1
        Me.ChartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values"
        Me.ChartControl1.Size = New System.Drawing.Size(814, 200)
        Me.ChartControl1.TabIndex = 0
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "PERIYOD"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sSinifKodu"
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
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Yil"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "Ay"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "Hafta"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Maliyet"
        Me.DataColumn11.DataType = GetType(Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "Yuzde"
        Me.DataColumn12.DataType = GetType(Decimal)
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        'MenuItem20
        '
        Me.MenuItem20.Index = 2
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 3
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 4
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 5
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 6
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 7
        Me.MenuItem10.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 8
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 9
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 10
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 11
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 12
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 13
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 14
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem9.Text = "Ekraný Kapla"
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
        Me.printlink1.Landscape = True
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink1.Owner = Nothing
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Periyodik Ciro Analizi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Retail Managment- Satýþ Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'printlink2
        '
        Me.printlink2.Component = Me.ChartControl1
        '
        '
        '
        Me.printlink2.ImageCollection.ImageStream = CType(resources.GetObject("printlink2.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink2.Landscape = True
        Me.printlink2.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink2.Owner = Nothing
        Me.printlink2.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Satýþ Ciro Grafiði", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Retail Managment-Satýþ Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink2.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink2.PrintingSystem = Me.ps
        Me.printlink2.PrintingSystemBase = Me.ps
        '
        'PivotGridField2
        '
        Me.PivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField2.AreaIndex = 1
        Me.PivotGridField2.CellFormat.FormatString = "#,0.00"
        Me.PivotGridField2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField2.FieldName = "Tutar"
        Me.PivotGridField2.Name = "PivotGridField2"
        '
        'frm_stok_satis_ciro_sinif_analiz
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_satis_ciro_sinif_analiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sýnýflandýrmalar Periyodik Satýþ Cirolarý"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sirala.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kayitsayisi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sinifno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_satici.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_alisveris.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_yeni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_periyod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.sec_nGorunum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sirala2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceTopValuesShowOthers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icbField.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seTop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_baslik.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_renk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chColorEach.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sec_grid.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink2.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
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
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_magaza As DataSet
    Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        firmano = "100"
        donemno = "1"
        DateEdit1.EditValue = dteSistemTarihi '"01/01/" + Today.Year.ToString
        DateEdit2.EditValue = dteSistemTarihi '"31/12/" + Today.Year.ToString
        DateEdit1.Focus()
        DateEdit1.Select()
        dataload_renk()
        dataload_satici(1)
        ChartControl1.DataSource = GridControl1
        ChartControl1.SeriesDataMember = "Series"
        ChartControl1.SeriesTemplate.ArgumentDataMember = "Arguments"
        ChartControl1.SeriesTemplate.ValueDataMembers.AddRange(New String() {"Values"})
        ChartControl1.SeriesTemplate.LegendPointOptions.PointView = PointView.ArgumentAndValues
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub dataload_renk()
        ds_magaza = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, sDepo AS KOD, sAciklama AS ACIKLAMA FROM         tbDepo WHERE sDepo <> '' ORDER BY sDepo"))
        'sec_renk.DataSource = sorgu(sorgu_query("SELECT * FROM tbRenk")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub dataload_satici(Optional ByVal sinifno As Integer = 1)
        sec_satici.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSinifKodu AS IND, sAciklama AS SATICI FROM         tbSSinif" & sinifno & " ")).Tables(0)
        sec_satici.ItemIndex = 0
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
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            GridControl1.FieldsCustomization()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            degistir_grafik()
        End If
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
        Dim kriter As String = ""
        kriter += Microsoft.VisualBasic.Left(DateEdit1.EditValue.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(DateEdit2.EditValue.ToString, 10) & " Tarihleri Arasýndaki Satýþlar Ciro Analizi" & vbCrLf
        kriter += "Maðaza = " & sec_depo.Text & vbTab & "Periyod = " & sec_periyod.Text
        If sec_yeni.Checked = True Then
            kriter += " YeniMüþteriler = Evet"
        End If
        kriter += " Sýnýflandýrma = " & sec_sinifno.Text
        kriter += " Sýnýf = " & sec_satici.Text
        If sec_kayitsayisi.EditValue > 0 Then
            kriter += " Ýlk = " & sec_kayitsayisi.EditValue
            kriter += " Sýralama = " & sec_sirala.Text
        End If
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Retail Managment-Satýþ Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
            printlink1.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            Me.printlink2.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Retail Managment-Satýþ Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
            printlink2.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        End If
    End Sub
    Private Sub gorunum_kaydet()
        GridControl1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "\" & sec_nGorunum.Text & "\")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
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
        GridControl1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "\" & sec_nGorunum.Text & "\")
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
    Public Function stok(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal depo As String, ByVal periyod As String, ByVal yenikayit As Boolean, ByVal alisveris As String, ByVal sinifno As Integer, ByVal satici As String, ByVal kayitsayisi As Decimal, ByVal siralama As String) As DataSet
        Dim kriter As String = ""
        Dim mevcutB As String = ""
        mevcutB = " ISNULL((select SUM(lGirisMiktar1 - lCikisMiktar1) as mevcut from tbStokFisiDetayi where nStokID IN (select DISTINCT(tbStokSinifi.nStokID) from tbStokSinifi where tbStokSinifi.sSinifKodu" & sinifno & " = sSinifKodu) HAVING SUM(lGirisMiktar1 - lCikisMiktar1) <> 0), 0) as Mevcut, "
        Dim count = ""
        Dim count_sirala = ""
        kriter += " WHERE dteFaturaTarihi Between '" & tarih1 & "' and '" & tarih2 & "' "
        If depo <> "[Tümü]" Then
            kriter += " AND sMagaza IN ( " & depo & " ) "
        End If
        If yenikayit = True Then
            kriter += " AND nMusteriID IN (Select nMusteriID From tbMusteri WHERE dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih2.ToString, 10) + " 23:59:59" & "' )"
        End If
        If alisveris = "[Tümü]" Then
        ElseIf alisveris = "Kredili Satýþlar" Then
            kriter += " AND sFisTipi IN ('K','SK') "
        ElseIf alisveris = "Kredili" Then
            kriter += " AND sFisTipi IN ('K') "
        ElseIf alisveris = "Sonradan Teslim Kredili" Then
            kriter += " AND sFisTipi IN ('SK') "
        ElseIf alisveris = "Peþin Satýþlar" Then
            kriter += " AND sFisTipi IN ('P','SP') "
        ElseIf alisveris = "Peþin" Then
            kriter += " AND sFisTipi IN ('P') "
        ElseIf alisveris = "Sonradan Teslim Peþin" Then
            kriter += " AND sFisTipi IN ('SP') "
        End If
        If Trim(satici.ToString) <> "" Then
            kriter += " AND sSinifKodu = '" & satici & "' "
        End If
        If kayitsayisi > 0 Then
            count = " TOP " & kayitsayisi & " "
            If siralama = "Tutar" Then
                count_sirala = " SUM(lNetTutar) DESC,"
            ElseIf siralama = "Miktar" Then
                count_sirala = " SUM(Miktar) DESC,"
            ElseIf siralama = "Iskonto" Then
                count_sirala = " SUM(Iskonto) DESC,"
            ElseIf siralama = "MüþteriSayýsý" Then
                count_sirala = " COUNT(DISTINCT nMusteriID) DESC,"
            ElseIf siralama = "Kar" Then
                count_sirala = " SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) DESC,"
            End If
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        If islem = 0 Then
            If periyod = "Günlük" Then
                If Trim(satici.ToString) <> "" Then
                    'cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " DAY(dteFaturaTarihi) AS PERIYOD, sSinifKodu, sAciklama, SUM(Miktar) AS Miktar, SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar,SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar, (SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0.01))) / SUM(Miktar*ISNULL(Maliyet, 0.01)) AS Yuzde,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0.01) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '"& sFiyatM &"') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '"& sFiyatM &"') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) Satislar " & kriter & " GROUP BY DAY(dteFaturaTarihi),sSinifKodu, sAciklama ORDER BY " & count_sirala & " DAY(dteFaturaTarihi),sSinifKodu, sAciklama")
                    cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " '' AS PERIYOD, YEAR(dteFaturaTarihi) AS Yil, { fn QUARTER(dteFaturaTarihi) } AS Ceyrek,MONTH(dteFaturaTarihi) AS Ay, DAY (dteFaturaTarihi) AS GUN, { fn WEEK(dteFaturaTarihi) } AS Hafta,sSinifKodu, sAciklama,{ fn UCASE(sMagaza) } AS sMagaza, SUM(Miktar) AS Miktar, " & mevcutB & " SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0.01) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) Satislar " & kriter & " GROUP BY YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama ORDER BY " & count_sirala & " YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama")
                    ''Me.ChartControl1.Series(0).ArgumentDataMember = "PERIYOD"
                Else
                    ''Me.ChartControl1.Series(0).ArgumentDataMember = "sAciklama"
                    cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " '' AS PERIYOD, YEAR(dteFaturaTarihi) AS Yil, { fn QUARTER(dteFaturaTarihi) } AS Ceyrek,MONTH(dteFaturaTarihi) AS Ay, DAY (dteFaturaTarihi) AS GUN, { fn WEEK(dteFaturaTarihi) } AS Hafta,sSinifKodu, sAciklama,{ fn UCASE(sMagaza) } AS sMagaza, SUM(Miktar) AS Miktar, " & mevcutB & " SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0.01) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) Satislar " & kriter & " GROUP BY YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama ORDER BY " & count_sirala & " YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama")
                End If
            ElseIf periyod = "Aylýk" Then
                ''Me.ChartControl1.Series(0).ArgumentDataMember = "PERIYOD"
                cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  " & count & " YEAR(dteFaturaTarihi) AS Yil, { fn QUARTER(dteFaturaTarihi) } AS Ceyrek,MONTH(dteFaturaTarihi) AS Ay, DAY (dteFaturaTarihi) AS GUN, { fn WEEK(dteFaturaTarihi) } AS Hafta,DBO.AYTOSTR(MONTH(dteFaturaTarihi)) AS PERIYOD, sSinifKodu, sAciklama,{ fn UCASE(sMagaza) } AS sMagaza, SUM(Miktar) AS Miktar, " & mevcutB & " SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar,SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar, COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0.01) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) Satislar " & kriter & " GROUP BY YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama ORDER BY " & count_sirala & " YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama")
            ElseIf periyod = "Haftalýk" Then
                ''Me.ChartControl1.Series(0).ArgumentDataMember = "PERIYOD"
                cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " YEAR(dteFaturaTarihi) AS Yil, { fn QUARTER(dteFaturaTarihi) } AS Ceyrek,MONTH(dteFaturaTarihi) AS Ay, DAY (dteFaturaTarihi) AS GUN, { fn WEEK(dteFaturaTarihi) } AS Hafta,{ fn WEEK(dteFaturaTarihi) } AS PERIYOD, sSinifKodu, sAciklama,{ fn UCASE(sMagaza) } AS sMagaza, SUM(Miktar) AS Miktar, " & mevcutB & " SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0.01) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) Satislar " & kriter & " GROUP BY YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama ORDER BY " & count_sirala & " YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama")
            ElseIf periyod = "Yýllýk" Then
                'Me.ChartControl1.Series(0).ArgumentDataMember = "PERIYOD"
                cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " YEAR(dteFaturaTarihi) AS Yil, { fn QUARTER(dteFaturaTarihi) } AS Ceyrek,MONTH(dteFaturaTarihi) AS Ay, DAY (dteFaturaTarihi) AS GUN, { fn WEEK(dteFaturaTarihi) } AS Hafta,YEAR(dteFaturaTarihi) AS PERIYOD, sSinifKodu, sAciklama,{ fn UCASE(sMagaza) } AS sMagaza, SUM(Miktar) AS Miktar, " & mevcutB & " SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0.01) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) Satislar " & kriter & " GROUP BY YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama ORDER BY " & count_sirala & " YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama")
            ElseIf periyod = "Haftanýn Günü" Then
                'Me.ChartControl1.Series(0).ArgumentDataMember = "PERIYOD"
                cmd.CommandText = sorgu_query("set dateformat dmy SET DATEFIRST 1 SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " YEAR(dteFaturaTarihi) AS Yil, { fn QUARTER(dteFaturaTarihi) } AS Ceyrek,MONTH(dteFaturaTarihi) AS Ay, DAY (dteFaturaTarihi) AS GUN, { fn WEEK(dteFaturaTarihi) } AS Hafta,DATENAME(DW, dteFaturaTarihi) AS PERIYOD,DATEPART(DW, dteFaturaTarihi), sSinifKodu, sAciklama, { fn UCASE(sMagaza) } AS sMagaza,SUM(Miktar) AS Miktar, " & mevcutB & " SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0.01) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) Satislar " & kriter & " GROUP BY YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },DATEPART(DW, dteFaturaTarihi),sMagaza,sSinifKodu, sAciklama ORDER BY " & count_sirala & " YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },DATEPART(DW, dteFaturaTarihi),sMagaza,sSinifKodu, sAciklama")
            ElseIf periyod = "Quarter" Then
                'Me.ChartControl1.Series(0).ArgumentDataMember = "PERIYOD"
                cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " YEAR(dteFaturaTarihi) AS Yil, { fn QUARTER(dteFaturaTarihi) } AS Ceyrek,MONTH(dteFaturaTarihi) AS Ay, DAY (dteFaturaTarihi) AS GUN, { fn WEEK(dteFaturaTarihi) } AS Hafta,{ fn QUARTER(dteFaturaTarihi) } AS PERIYOD, sSinifKodu, sAciklama,{ fn UCASE(sMagaza) } AS sMagaza, SUM(Miktar) AS Miktar, " & mevcutB & " SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0.01) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama ,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MaliyetFROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) Satislar " & kriter & " GROUP BY YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama ORDER BY " & count_sirala & " YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama")
            End If
        ElseIf islem = 1 Then
            If periyod = "Günlük" Then
                If Trim(satici.ToString) <> "" Then
                    cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " '' AS PERIYOD, YEAR(dteFaturaTarihi) AS Yil, { fn QUARTER(dteFaturaTarihi) } AS Ceyrek,MONTH(dteFaturaTarihi) AS Ay, DAY (dteFaturaTarihi) AS GUN, { fn WEEK(dteFaturaTarihi) } AS Hafta,sSinifKodu, sAciklama,{ fn UCASE(sMagaza) } AS sMagaza, SUM(Miktar) AS Miktar, " & mevcutB & " SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0.01) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbStokFisiDetayi.dteFisTarihi AS dteFaturaTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.sDepo AS Magaza, tbStokFisiDetayi.nFirmaID AS nMusteriID, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lIskontoTutari * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, (tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar, tbSSinif" & sinifno & ".sSinifKodu, tbSSinif" & sinifno & ".sAciklama, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = 'FS')) Satislar " & kriter & " GROUP BY YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama ORDER BY " & count_sirala & " YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama")
                    'Me.ChartControl1.Series(0).ArgumentDataMember = "PERIYOD"
                Else
                    'Me.ChartControl1.Series(0).ArgumentDataMember = "sAciklama"
                    cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " '' AS PERIYOD, YEAR(dteFaturaTarihi) AS Yil, { fn QUARTER(dteFaturaTarihi) } AS Ceyrek,MONTH(dteFaturaTarihi) AS Ay, DAY (dteFaturaTarihi) AS GUN, { fn WEEK(dteFaturaTarihi) } AS Hafta,sSinifKodu, sAciklama,{ fn UCASE(sMagaza) } AS sMagaza, SUM(Miktar) AS Miktar, " & mevcutB & " SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0.01) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbStokFisiDetayi.dteFisTarihi AS dteFaturaTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.sDepo AS Magaza, tbStokFisiDetayi.nFirmaID AS nMusteriID, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lIskontoTutari * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, (tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar, tbSSinif" & sinifno & ".sSinifKodu, tbSSinif" & sinifno & ".sAciklama, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = 'FS')) Satislar " & kriter & " GROUP BY YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama ORDER BY " & count_sirala & " YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama")
                End If
            ElseIf periyod = "Aylýk" Then
                'Me.ChartControl1.Series(0).ArgumentDataMember = "PERIYOD"
                cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  " & count & " YEAR(dteFaturaTarihi) AS Yil, { fn QUARTER(dteFaturaTarihi) } AS Ceyrek,MONTH(dteFaturaTarihi) AS Ay, DAY (dteFaturaTarihi) AS GUN, { fn WEEK(dteFaturaTarihi) } AS Hafta,DBO.AYTOSTR(MONTH(dteFaturaTarihi)) AS PERIYOD, sSinifKodu, sAciklama,{ fn UCASE(sMagaza) } AS sMagaza, SUM(Miktar) AS Miktar, " & mevcutB & " SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar,SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar, COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0.01) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbStokFisiDetayi.dteFisTarihi AS dteFaturaTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.sDepo AS Magaza, tbStokFisiDetayi.nFirmaID AS nMusteriID, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lIskontoTutari * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, (tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar, tbSSinif" & sinifno & ".sSinifKodu, tbSSinif" & sinifno & ".sAciklama, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = 'FS')) Satislar " & kriter & " GROUP BY YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama ORDER BY " & count_sirala & " YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama")
            ElseIf periyod = "Haftalýk" Then
                'Me.ChartControl1.Series(0).ArgumentDataMember = "PERIYOD"
                cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " YEAR(dteFaturaTarihi) AS Yil, { fn QUARTER(dteFaturaTarihi) } AS Ceyrek,MONTH(dteFaturaTarihi) AS Ay, DAY (dteFaturaTarihi) AS GUN, { fn WEEK(dteFaturaTarihi) } AS Hafta,{ fn WEEK(dteFaturaTarihi) } AS PERIYOD, sSinifKodu, sAciklama,{ fn UCASE(sMagaza) } AS sMagaza, SUM(Miktar) AS Miktar, " & mevcutB & " SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0.01) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbStokFisiDetayi.dteFisTarihi AS dteFaturaTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.sDepo AS Magaza, tbStokFisiDetayi.nFirmaID AS nMusteriID, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lIskontoTutari * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, (tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar, tbSSinif" & sinifno & ".sSinifKodu, tbSSinif" & sinifno & ".sAciklama, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = 'FS')) Satislar " & kriter & " GROUP BY YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama ORDER BY " & count_sirala & " YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama")
            ElseIf periyod = "Yýllýk" Then
                'Me.ChartControl1.Series(0).ArgumentDataMember = "PERIYOD"
                cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " YEAR(dteFaturaTarihi) AS Yil, { fn QUARTER(dteFaturaTarihi) } AS Ceyrek,MONTH(dteFaturaTarihi) AS Ay, DAY (dteFaturaTarihi) AS GUN, { fn WEEK(dteFaturaTarihi) } AS Hafta,YEAR(dteFaturaTarihi) AS PERIYOD, sSinifKodu, sAciklama,{ fn UCASE(sMagaza) } AS sMagaza, SUM(Miktar) AS Miktar, " & mevcutB & " SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0.01) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbStokFisiDetayi.dteFisTarihi AS dteFaturaTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.sDepo AS Magaza, tbStokFisiDetayi.nFirmaID AS nMusteriID, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lIskontoTutari * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, (tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar, tbSSinif" & sinifno & ".sSinifKodu, tbSSinif" & sinifno & ".sAciklama, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = 'FS')) Satislar " & kriter & " GROUP BY YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama ORDER BY " & count_sirala & " YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama")
            ElseIf periyod = "Haftanýn Günü" Then
                'Me.ChartControl1.Series(0).ArgumentDataMember = "PERIYOD"
                cmd.CommandText = sorgu_query("set dateformat dmy SET DATEFIRST 1 SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " YEAR(dteFaturaTarihi) AS Yil, { fn QUARTER(dteFaturaTarihi) } AS Ceyrek,MONTH(dteFaturaTarihi) AS Ay, DAY (dteFaturaTarihi) AS GUN, { fn WEEK(dteFaturaTarihi) } AS Hafta,DATENAME(DW, dteFaturaTarihi) AS PERIYOD,DATEPART(DW, dteFaturaTarihi), sSinifKodu, sAciklama, { fn UCASE(sMagaza) } AS sMagaza,SUM(Miktar) AS Miktar, " & mevcutB & " SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0.01) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbStokFisiDetayi.dteFisTarihi AS dteFaturaTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.sDepo AS Magaza, tbStokFisiDetayi.nFirmaID AS nMusteriID, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lIskontoTutari * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, (tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar, tbSSinif" & sinifno & ".sSinifKodu, tbSSinif" & sinifno & ".sAciklama, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = 'FS')) Satislar " & kriter & " GROUP BY YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },DATEPART(DW, dteFaturaTarihi),sMagaza,sSinifKodu, sAciklama ORDER BY " & count_sirala & " YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },DATEPART(DW, dteFaturaTarihi),sMagaza,sSinifKodu, sAciklama")
            ElseIf periyod = "Quarter" Then
                'Me.ChartControl1.Series(0).ArgumentDataMember = "PERIYOD"
                cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " YEAR(dteFaturaTarihi) AS Yil, { fn QUARTER(dteFaturaTarihi) } AS Ceyrek,MONTH(dteFaturaTarihi) AS Ay, DAY (dteFaturaTarihi) AS GUN, { fn WEEK(dteFaturaTarihi) } AS Hafta,{ fn QUARTER(dteFaturaTarihi) } AS PERIYOD, sSinifKodu, sAciklama,{ fn UCASE(sMagaza) } AS sMagaza, SUM(Miktar) AS Miktar, " & mevcutB & " SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0.01) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama ,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MaliyetFROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbStokFisiDetayi.dteFisTarihi AS dteFaturaTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.sDepo AS Magaza, tbStokFisiDetayi.nFirmaID AS nMusteriID, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lIskontoTutari * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, (tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar, tbSSinif" & sinifno & ".sSinifKodu, tbSSinif" & sinifno & ".sAciklama, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = 'FS')) Satislar " & kriter & " GROUP BY YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama ORDER BY " & count_sirala & " YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama")
            End If
        ElseIf islem = 2 Then
            If periyod = "Günlük" Then
                If Trim(satici.ToString) <> "" Then
                    cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " '' AS PERIYOD, YEAR(dteFaturaTarihi) AS Yil, { fn QUARTER(dteFaturaTarihi) } AS Ceyrek,MONTH(dteFaturaTarihi) AS Ay, DAY (dteFaturaTarihi) AS GUN, { fn WEEK(dteFaturaTarihi) } AS Hafta,sSinifKodu, sAciklama,{ fn UCASE(sMagaza) } AS sMagaza, SUM(Miktar) AS Miktar, " & mevcutB & " SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0.01) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbStokFisiDetayi.dteFisTarihi AS dteFaturaTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.sDepo AS Magaza, tbStokFisiDetayi.nFirmaID AS nMusteriID, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lIskontoTutari * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, (tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar, tbSSinif" & sinifno & ".sSinifKodu, tbSSinif" & sinifno & ".sAciklama, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = " & kriter_fistipi & ")) Satislar " & kriter & " GROUP BY YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama ORDER BY " & count_sirala & " YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama")
                    'Me.ChartControl1.Series(0).ArgumentDataMember = "PERIYOD"
                Else
                    'Me.ChartControl1.Series(0).ArgumentDataMember = "sAciklama"
                    cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " '' AS PERIYOD, YEAR(dteFaturaTarihi) AS Yil, { fn QUARTER(dteFaturaTarihi) } AS Ceyrek,MONTH(dteFaturaTarihi) AS Ay, DAY (dteFaturaTarihi) AS GUN, { fn WEEK(dteFaturaTarihi) } AS Hafta,sSinifKodu, sAciklama,{ fn UCASE(sMagaza) } AS sMagaza, SUM(Miktar) AS Miktar, " & mevcutB & " SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0.01) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisVeris LEFT OUTER JOIN tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbAlisVeris.dteFaturaTarihi , tbAlisVeris.sFisTipi , tbAlisVeris.sMagaza , tbAlisVeris.nMusteriID , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbSSinif" & sinifno & ".sSinifKodu , tbSSinif" & sinifno & ".sAciklama,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbAlisVerisSiparis.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStokSinifi ON tbAlisverisSiparis.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif" & sinifno & " ON tbStokSinifi.sSinifKodu" & sinifno & " = tbSSinif" & sinifno & ".sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') UNION ALL SELECT tbStokFisiDetayi.dteFisTarihi AS dteFaturaTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.sDepo AS Magaza, tbStokFisiDetayi.nFirmaID AS nMusteriID, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lIskontoTutari * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, (tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar, tbSSinif" & sinifno & ".sSinifKodu, tbSSinif" & sinifno & ".sAciklama, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = " & kriter_fistipi & ")) Satislar " & kriter & " GROUP BY YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama ORDER BY " & count_sirala & " YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama")
                End If
            ElseIf periyod = "Aylýk" Then
                'Me.ChartControl1.Series(0).ArgumentDataMember = "PERIYOD"
                cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  " & count & " YEAR(dteFaturaTarihi) AS Yil, { fn QUARTER(dteFaturaTarihi) } AS Ceyrek,MONTH(dteFaturaTarihi) AS Ay, DAY (dteFaturaTarihi) AS GUN, { fn WEEK(dteFaturaTarihi) } AS Hafta,DBO.AYTOSTR(MONTH(dteFaturaTarihi)) AS PERIYOD, sSinifKodu, sAciklama,{ fn UCASE(sMagaza) } AS sMagaza, SUM(Miktar) AS Miktar, " & mevcutB & " SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar,SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar, COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbStokFisiDetayi.dteFisTarihi AS dteFaturaTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.sDepo AS Magaza, tbStokFisiDetayi.nFirmaID AS nMusteriID, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lIskontoTutari * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, (tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar, tbSSinif" & sinifno & ".sSinifKodu, tbSSinif" & sinifno & ".sAciklama, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = " & kriter_fistipi & ")) Satislar " & kriter & " GROUP BY YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama ORDER BY " & count_sirala & " YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama")
            ElseIf periyod = "Haftalýk" Then
                'Me.ChartControl1.Series(0).ArgumentDataMember = "PERIYOD"
                cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " YEAR(dteFaturaTarihi) AS Yil, { fn QUARTER(dteFaturaTarihi) } AS Ceyrek,MONTH(dteFaturaTarihi) AS Ay, DAY (dteFaturaTarihi) AS GUN, { fn WEEK(dteFaturaTarihi) } AS Hafta,{ fn WEEK(dteFaturaTarihi) } AS PERIYOD, sSinifKodu, sAciklama,{ fn UCASE(sMagaza) } AS sMagaza, SUM(Miktar) AS Miktar, " & mevcutB & " SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbStokFisiDetayi.dteFisTarihi AS dteFaturaTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.sDepo AS Magaza, tbStokFisiDetayi.nFirmaID AS nMusteriID, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lIskontoTutari * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, (tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar, tbSSinif" & sinifno & ".sSinifKodu, tbSSinif" & sinifno & ".sAciklama, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = " & kriter_fistipi & ")) Satislar " & kriter & " GROUP BY YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama ORDER BY " & count_sirala & " YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama")
            ElseIf periyod = "Yýllýk" Then
                'Me.ChartControl1.Series(0).ArgumentDataMember = "PERIYOD"
                cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " YEAR(dteFaturaTarihi) AS Yil, { fn QUARTER(dteFaturaTarihi) } AS Ceyrek,MONTH(dteFaturaTarihi) AS Ay, DAY (dteFaturaTarihi) AS GUN, { fn WEEK(dteFaturaTarihi) } AS Hafta,YEAR(dteFaturaTarihi) AS PERIYOD, sSinifKodu, sAciklama,{ fn UCASE(sMagaza) } AS sMagaza, SUM(Miktar) AS Miktar, " & mevcutB & " SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbStokFisiDetayi.dteFisTarihi AS dteFaturaTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.sDepo AS Magaza, tbStokFisiDetayi.nFirmaID AS nMusteriID, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lIskontoTutari * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, (tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar, tbSSinif" & sinifno & ".sSinifKodu, tbSSinif" & sinifno & ".sAciklama, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = " & kriter_fistipi & ")) Satislar " & kriter & " GROUP BY YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama ORDER BY " & count_sirala & " YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama")
            ElseIf periyod = "Haftanýn Günü" Then
                'Me.ChartControl1.Series(0).ArgumentDataMember = "PERIYOD"
                cmd.CommandText = sorgu_query("set dateformat dmy SET DATEFIRST 1 SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " YEAR(dteFaturaTarihi) AS Yil, { fn QUARTER(dteFaturaTarihi) } AS Ceyrek,MONTH(dteFaturaTarihi) AS Ay, DAY (dteFaturaTarihi) AS GUN, { fn WEEK(dteFaturaTarihi) } AS Hafta,DATENAME(DW, dteFaturaTarihi) AS PERIYOD,DATEPART(DW, dteFaturaTarihi), sSinifKodu, sAciklama, { fn UCASE(sMagaza) } AS sMagaza,SUM(Miktar) AS Miktar, " & mevcutB & " SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbStokFisiDetayi.dteFisTarihi AS dteFaturaTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.sDepo AS Magaza, tbStokFisiDetayi.nFirmaID AS nMusteriID, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lIskontoTutari * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, (tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar, tbSSinif" & sinifno & ".sSinifKodu, tbSSinif" & sinifno & ".sAciklama, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = " & kriter_fistipi & ")) Satislar " & kriter & " GROUP BY YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },DATEPART(DW, dteFaturaTarihi),sMagaza,sSinifKodu, sAciklama ORDER BY " & count_sirala & " YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },DATEPART(DW, dteFaturaTarihi),sMagaza,sSinifKodu, sAciklama")
            ElseIf periyod = "Quarter" Then
                'Me.ChartControl1.Series(0).ArgumentDataMember = "PERIYOD"
                cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " YEAR(dteFaturaTarihi) AS Yil, { fn QUARTER(dteFaturaTarihi) } AS Ceyrek,MONTH(dteFaturaTarihi) AS Ay, DAY (dteFaturaTarihi) AS GUN, { fn WEEK(dteFaturaTarihi) } AS Hafta,{ fn QUARTER(dteFaturaTarihi) } AS PERIYOD, sSinifKodu, sAciklama,{ fn UCASE(sMagaza) } AS sMagaza, SUM(Miktar) AS Miktar, " & mevcutB & " SUM(Iskonto) AS Iskonto, SUM(lNetTutar) AS Tutar, SUM(Miktar * ISNULL(Maliyet, 0)) AS Maliyet, SUM(lNetTutar) - SUM(Miktar * ISNULL(Maliyet, 0)) AS Kar,COUNT(DISTINCT nMusteriID) AS MUSTERISAYISI FROM (SELECT tbStokFisiDetayi.dteFisTarihi AS dteFaturaTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.sDepo AS Magaza, tbStokFisiDetayi.nFirmaID AS nMusteriID, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lIskontoTutari * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, (tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar, tbSSinif" & sinifno & ".sSinifKodu, tbSSinif" & sinifno & ".sAciklama, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = " & kriter_fistipi & ")) Satislar " & kriter & " GROUP BY YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama ORDER BY " & count_sirala & " YEAR(dteFaturaTarihi), { fn QUARTER(dteFaturaTarihi) }, MONTH(dteFaturaTarihi), DAY(dteFaturaTarihi), { fn WEEK(dteFaturaTarihi) },sMagaza,sSinifKodu, sAciklama")
            End If
        End If
        'UNION ALL SELECT tbStokFisiDetayi.dteFisTarihi AS dteFaturaTarihi, tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.sDepo AS Magaza, tbStokFisiDetayi.nFirmaID AS nMusteriID, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lIskontoTutari * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, (tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS lNetTutar, tbSSinif" & sinifno & ".sSinifKodu, tbSSinif" & sinifno & ".sAciklama, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS Maliyet FROM tbSSinif" & sinifno & " INNER JOIN tbStokSinifi ON tbSSinif" & sinifno & ".sSinifKodu = tbStokSinifi.sSinifKodu" & sinifno & " INNER JOIN tbStokFisiDetayi ON tbStokSinifi.nStokID = tbStokFisiDetayi.nStokID WHERE (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbStokFisiDetayi.sFisTipi = 'FS')
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
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal depo As String, ByVal periyod As String, ByVal yenikayit As Boolean, ByVal alisveris As String, ByVal sinifno As Integer, ByVal satici As String, ByVal kayitsayisi As Decimal, ByVal siralama As String)
        DataSet1 = stok(tarih1, tarih2, depo, periyod, yenikayit, alisveris, sinifno, satici, kayitsayisi, siralama)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        'GridView1.CollapseAllGroups()
        ChartControl1.DataSource = GridControl1
        ChartControl1.Refresh()
        icbField.Properties.Items.Clear()
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
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
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
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        'Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, Trim(sec_depo.Text), sec_periyod.Text, sec_yeni.Checked, sec_alisveris.Text, sec_sinifno.Text, Trim(sec_satici.EditValue.ToString), sec_kayitsayisi.EditValue, sec_sirala.Text)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
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
    Private Sub degistir_grafik()
        Dim chartWizard_Renamed As ChartWizard = New ChartWizard(Me.ChartControl1)
        chartWizard_Renamed.ShowDialog()
        If TypeOf ChartControl1.Series(0).View Is SeriesViewColorEachSupportBase Then
            chColorEach.Enabled = True
            chColorEach.Checked = CType(ChartControl1.Series(0).View, SeriesViewColorEachSupportBase).ColorEach
        ElseIf TypeOf ChartControl1.Series(0).View Is SeriesView3DColorEachSupportBase Then
            chColorEach.Enabled = True
            chColorEach.Checked = CType(ChartControl1.Series(0).View, SeriesView3DColorEachSupportBase).ColorEach
        Else
            ChartControl1.Series(0).Label.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            chColorEach.Enabled = False
            chColorEach.Checked = False
        End If
    End Sub
    Private Sub chColorEach_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chColorEach.CheckedChanged
        If chColorEach.Enabled Then
            Dim series As Series
            For Each series In ChartControl1.Series
                If TypeOf ChartControl1.Series(0).View Is SeriesViewColorEachSupportBase Then
                    CType(ChartControl1.Series(0).View, SeriesViewColorEachSupportBase).ColorEach = chColorEach.Checked
                ElseIf TypeOf ChartControl1.Series(0).View Is SeriesView3DColorEachSupportBase Then
                    CType(ChartControl1.Series(0).View, SeriesView3DColorEachSupportBase).ColorEach = chColorEach.Checked
                End If
            Next series
        End If
    End Sub
    Private Sub sec_baslik_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_baslik.CheckedChanged
        If sec_baslik.Checked = True Then
            ChartControl1.Series(0).Label.PointOptions.PointView = PointView.ArgumentAndValues
        ElseIf sec_baslik.Checked = False Then
            ChartControl1.Series(0).Label.PointOptions.PointView = PointView.Values
        End If
    End Sub
    Private Sub sec_renk_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_renk.CheckedChanged
        If sec_renk.Checked = True Then
            ChartControl1.Series(0).Label.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
        ElseIf sec_renk.Checked = False Then
            ChartControl1.Series(0).Label.PointOptions.ValueNumericOptions.Format = NumericFormat.Number
        End If
    End Sub
    Private Sub sec_satici_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_satici.EditValueChanged
        If Trim(sec_satici.EditValue.ToString) = "" Then
            sec_periyod.Text = "Günlük"
            sec_periyod.Properties.ReadOnly = True
        Else
            sec_periyod.Text = "Günlük"
            sec_periyod.Properties.ReadOnly = False
        End If
    End Sub
    Private Sub sec_sinifno_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sinifno.SelectedValueChanged
        dataload_satici(sec_sinifno.Text)
    End Sub
    Private Sub sec_kayitsayisi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_kayitsayisi.EditValueChanged
        If sec_kayitsayisi.EditValue > 0 Then
            sec_sirala.Enabled = True
        Else
            sec_sirala.Enabled = False
        End If
    End Sub
    Private Sub icbField_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbField.SelectedIndexChanged
        GridControl1.BeginUpdate()
        'SetFieldTop()
        If icbField.Text = "SýnýfKodu" Then
            seTop.EditValue = fieldsSinifKodu.TopValueCount
            ceTopValuesShowOthers.Checked = fieldsSinifKodu.TopValueShowOthers
        ElseIf icbField.Text = "Açýklama" Then
            seTop.EditValue = fieldsAciklama.TopValueCount
            ceTopValuesShowOthers.Checked = fieldsAciklama.TopValueShowOthers
        ElseIf icbField.Text = "Maðaza" Then
            seTop.EditValue = fieldsMagaza.TopValueCount
            ceTopValuesShowOthers.Checked = fieldsMagaza.TopValueShowOthers
        ElseIf icbField.Text = "Miktar" Then
            seTop.EditValue = fieldMiktar.TopValueCount
            ceTopValuesShowOthers.Checked = fieldMiktar.TopValueShowOthers
        ElseIf icbField.Text = "Tutar" Then
            seTop.EditValue = fieldTutar.TopValueCount
            ceTopValuesShowOthers.Checked = fieldTutar.TopValueShowOthers
        ElseIf icbField.Text = "Maliyet" Then
            seTop.EditValue = fieldMaliyet.TopValueCount
            ceTopValuesShowOthers.Checked = fieldMaliyet.TopValueShowOthers
        ElseIf icbField.Text = "Kar" Then
            seTop.EditValue = fieldKar.TopValueCount
            ceTopValuesShowOthers.Checked = fieldKar.TopValueShowOthers
        ElseIf icbField.Text = "Ay" Then
            seTop.EditValue = fieldAy.TopValueCount
            ceTopValuesShowOthers.Checked = fieldAy.TopValueShowOthers
        ElseIf icbField.Text = "Gun" Then
            seTop.EditValue = fieldGUN1.TopValueCount
            ceTopValuesShowOthers.Checked = fieldGUN1.TopValueShowOthers
        ElseIf icbField.Text = "Hafta" Then
            seTop.EditValue = fieldHafta.TopValueCount
            ceTopValuesShowOthers.Checked = fieldHafta.TopValueShowOthers
        ElseIf icbField.Text = "Yýl" Then
            seTop.EditValue = fieldYil.TopValueCount
            ceTopValuesShowOthers.Checked = fieldYil.TopValueShowOthers
        End If
        GridControl1.EndUpdate()
    End Sub
    Private Sub SetFieldTop()
        If TypeOf icbField.EditValue Is PivotGridField Then
            If icbField.Text = "SýnýfKodu" Then
                fieldsSinifKodu.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldsSinifKodu.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala2.Text <> "A-Z / Z-A" Then
                    fieldsSinifKodu.SortBySummaryInfo.FieldName = sec_sirala2.Text
                    fieldsSinifKodu.SortMode = PivotSortMode.Value
                Else
                    fieldsSinifKodu.SortBySummaryInfo.FieldName = Nothing
                    fieldsSinifKodu.SortMode = PivotSortMode.Default
                End If
            ElseIf icbField.Text = "Açýklama" Then
                fieldsAciklama.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldsAciklama.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala2.Text <> "A-Z / Z-A" Then
                    fieldsAciklama.SortBySummaryInfo.FieldName = sec_sirala2.Text
                    fieldsAciklama.SortMode = PivotSortMode.Value
                Else
                    fieldsAciklama.SortBySummaryInfo.FieldName = Nothing
                    fieldsAciklama.SortMode = PivotSortMode.Default
                End If
            ElseIf icbField.Text = "Maðaza" Then
                fieldsMagaza.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldsMagaza.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala2.Text <> "A-Z / Z-A" Then
                    fieldsMagaza.SortBySummaryInfo.FieldName = sec_sirala2.Text
                    fieldsMagaza.SortMode = PivotSortMode.Value
                Else
                    fieldsMagaza.SortBySummaryInfo.FieldName = Nothing
                    fieldsMagaza.SortMode = PivotSortMode.Default
                End If
            ElseIf icbField.Text = "Miktar" Then
                fieldMiktar.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldMiktar.TopValueShowOthers = ceTopValuesShowOthers.Checked
            ElseIf icbField.Text = "Tutar" Then
                fieldTutar.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldTutar.TopValueShowOthers = ceTopValuesShowOthers.Checked
            ElseIf icbField.Text = "ToplamMaliyet" Then
                fieldMaliyet.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldMaliyet.TopValueShowOthers = ceTopValuesShowOthers.Checked
            ElseIf icbField.Text = "Kar" Then
                fieldKar.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldKar.TopValueShowOthers = ceTopValuesShowOthers.Checked
            ElseIf icbField.Text = "Ay" Then
                fieldAy.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldAy.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala2.Text <> "A-Z / Z-A" Then
                    fieldAy.SortBySummaryInfo.FieldName = sec_sirala2.Text
                    fieldAy.SortMode = PivotSortMode.Value
                Else
                    fieldAy.SortBySummaryInfo.FieldName = Nothing
                    fieldAy.SortMode = PivotSortMode.Default
                End If
            ElseIf icbField.Text = "Gun" Then
                fieldGUN1.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldGUN1.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala2.Text <> "A-Z / Z-A" Then
                    fieldGUN1.SortBySummaryInfo.FieldName = sec_sirala2.Text
                    fieldGUN1.SortMode = PivotSortMode.Value
                Else
                    fieldGUN1.SortBySummaryInfo.FieldName = Nothing
                    fieldGUN1.SortMode = PivotSortMode.Default
                End If
            ElseIf icbField.Text = "Hafta" Then
                fieldHafta.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldHafta.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala2.Text <> "A-Z / Z-A" Then
                    fieldHafta.SortBySummaryInfo.FieldName = sec_sirala2.Text
                    fieldHafta.SortMode = PivotSortMode.Value
                Else
                    fieldHafta.SortBySummaryInfo.FieldName = Nothing
                    fieldHafta.SortMode = PivotSortMode.Default
                End If
            ElseIf icbField.Text = "Ceyrek" Then
                fieldCeyrek.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldCeyrek.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala2.Text <> "A-Z / Z-A" Then
                    fieldCeyrek.SortBySummaryInfo.FieldName = sec_sirala2.Text
                    fieldCeyrek.SortMode = PivotSortMode.Value
                Else
                    fieldCeyrek.SortBySummaryInfo.FieldName = Nothing
                    fieldCeyrek.SortMode = PivotSortMode.Default
                End If
            ElseIf icbField.Text = "Yýl" Then
                fieldYil.TopValueCount = Convert.ToInt32(seTop.Value)
                fieldYil.TopValueShowOthers = ceTopValuesShowOthers.Checked
                If sec_sirala2.Text <> "A-Z / Z-A" Then
                    fieldYil.SortBySummaryInfo.FieldName = sec_sirala2.Text
                    fieldYil.SortMode = PivotSortMode.Value
                Else
                    fieldYil.SortBySummaryInfo.FieldName = Nothing
                    fieldYil.SortMode = PivotSortMode.Default
                End If
            End If
        End If
    End Sub
    Private Sub seTop_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seTop.EditValueChanged
        SetFieldTop()
    End Sub
    Private Sub sec_sirala2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sirala2.SelectedIndexChanged
        SetFieldTop()
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
    Private Sub sec_nGorunum_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_nGorunum.SelectedIndexChanged
        gorunum_yukle()
    End Sub
End Class