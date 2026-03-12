Imports FastReport
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Imports System.IO
Public Class frm_stok_etikettalep_liste
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
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
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBELGENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKAYITTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents colDEPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSONUC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txt_kasiyer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_kod As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sec_sonuc As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents colAKTIF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTDEPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clSTOKNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clSTOKKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clMALINCINSI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clRENK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents clACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents colTRANSFER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clMEVCUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents Label10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGIREN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIKAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKALAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMEVCUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBEKLEYEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_grid As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_tDepo As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_depo As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents colbKilitli As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colnTransfer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents colsKullanici As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKullaniciUpdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_ArtiEksi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_etikettalep_liste))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colAKTIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_ArtiEksi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.sec_tDepo = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_depo = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_sonuc = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_kasiyer = New DevExpress.XtraEditors.TextEdit()
        Me.txt_kod = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.sec_grid = New DevExpress.XtraEditors.PopupContainerControl()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSEC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.Dataset1 = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.DataColumn21 = New System.Data.DataColumn()
        Me.DataColumn29 = New System.Data.DataColumn()
        Me.DataColumn30 = New System.Data.DataColumn()
        Me.DataColumn31 = New System.Data.DataColumn()
        Me.DataColumn32 = New System.Data.DataColumn()
        Me.DataColumn33 = New System.Data.DataColumn()
        Me.DataColumn34 = New System.Data.DataColumn()
        Me.DataColumn36 = New System.Data.DataColumn()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBELGENO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKAYITTARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSONUC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTDEPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTRANSFER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbKilitli = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnTransfer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKullanici = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKullaniciUpdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_renk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.clMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clSTOKNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clSTOKKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clMALINCINSI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clRENK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.clMEVCUT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label9 = New DevExpress.XtraEditors.LabelControl()
        Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGIREN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCIKAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKALAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMEVCUT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBEKLEYEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label10 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_ArtiEksi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_tDepo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sonuc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kasiyer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sec_grid.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dataset1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel2.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colAKTIF
        '
        Me.colAKTIF.Caption = "Aktif"
        Me.colAKTIF.FieldName = "AKTIF"
        Me.colAKTIF.Name = "colAKTIF"
        Me.colAKTIF.Visible = True
        Me.colAKTIF.VisibleIndex = 11
        Me.colAKTIF.Width = 119
        '
        'colMIKTAR
        '
        Me.colMIKTAR.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colMIKTAR.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colMIKTAR.AppearanceCell.Options.UseBackColor = True
        Me.colMIKTAR.AppearanceCell.Options.UseFont = True
        Me.colMIKTAR.Caption = "Miktar"
        Me.colMIKTAR.DisplayFormat.FormatString = "#,0.####"
        Me.colMIKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMIKTAR.FieldName = "MIKTAR"
        Me.colMIKTAR.Name = "colMIKTAR"
        Me.colMIKTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", "{0:#,0.####}")})
        Me.colMIKTAR.Visible = True
        Me.colMIKTAR.VisibleIndex = 6
        Me.colMIKTAR.Width = 54
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 141)
        Me.PanelControl1.TabIndex = 2
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_ArtiEksi)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Controls.Add(Me.sec_tDepo)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.sec_depo)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.sec_sonuc)
        Me.GroupControl1.Controls.Add(Me.txt_kasiyer)
        Me.GroupControl1.Controls.Add(Me.txt_kod)
        Me.GroupControl1.Controls.Add(Me.SimpleButton5)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(386, 137)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Ara"
        '
        'sec_ArtiEksi
        '
        Me.sec_ArtiEksi.EditValue = "Artýlar"
        Me.sec_ArtiEksi.Location = New System.Drawing.Point(324, 25)
        Me.sec_ArtiEksi.Name = "sec_ArtiEksi"
        Me.sec_ArtiEksi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_ArtiEksi.Properties.Items.AddRange(New Object() {"Tümü", "Artýlar", "Eksiler"})
        Me.sec_ArtiEksi.Size = New System.Drawing.Size(56, 20)
        Me.sec_ArtiEksi.TabIndex = 64
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.Location = New System.Drawing.Point(30, 105)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl8.TabIndex = 63
        Me.LabelControl8.Text = "Stok:"
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Ad"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(159, 105)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Kod", "Ad", "Barkod", "Seri No"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(55, 20)
        Me.sec_konum.TabIndex = 9
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(214, 105)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(50, 20)
        Me.sec_kriter.TabIndex = 10
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(69, 105)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(90, 20)
        Me.txt_ara.TabIndex = 8
        '
        'sec_tDepo
        '
        Me.sec_tDepo.EditValue = "[Tümü]"
        Me.sec_tDepo.EnterMoveNextControl = True
        Me.sec_tDepo.Location = New System.Drawing.Point(184, 65)
        Me.sec_tDepo.Name = "sec_tDepo"
        Me.sec_tDepo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_tDepo.Properties.ShowPopupCloseButton = False
        Me.sec_tDepo.Size = New System.Drawing.Size(80, 20)
        Me.sec_tDepo.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(26, 65)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl3.TabIndex = 59
        Me.LabelControl3.Text = "Depo:"
        '
        'sec_depo
        '
        Me.sec_depo.EditValue = "[Tümü]"
        Me.sec_depo.EnterMoveNextControl = True
        Me.sec_depo.Location = New System.Drawing.Point(69, 65)
        Me.sec_depo.Name = "sec_depo"
        Me.sec_depo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo.Properties.ShowPopupCloseButton = False
        Me.sec_depo.Size = New System.Drawing.Size(90, 20)
        Me.sec_depo.TabIndex = 4
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(165, 70)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl7.TabIndex = 57
        Me.LabelControl7.Text = "-->"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(163, 49)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl6.TabIndex = 55
        Me.LabelControl6.Text = "ve"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(272, 45)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl5.TabIndex = 54
        Me.LabelControl5.Text = "Arasýndaki"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(22, 85)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl4.TabIndex = 53
        Me.LabelControl4.Text = "Sonuç:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(27, 45)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl2.TabIndex = 51
        Me.LabelControl2.Text = "Tarih:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(24, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl1.TabIndex = 50
        Me.LabelControl1.Text = "Yetkili:"
        '
        'sec_sonuc
        '
        Me.sec_sonuc.EditValue = "Bekliyor..."
        Me.sec_sonuc.EnterMoveNextControl = True
        Me.sec_sonuc.Location = New System.Drawing.Point(69, 85)
        Me.sec_sonuc.Name = "sec_sonuc"
        Me.sec_sonuc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sonuc.Properties.Items.AddRange(New Object() {"[Tümü]", "Bekliyor...", "Tamamlandý...", "Ýptal Edildi...", "Ürün Talebi...", "Sipariþ Talebi...", "Sayým...", "Takip..."})
        Me.sec_sonuc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sonuc.Size = New System.Drawing.Size(195, 20)
        Me.sec_sonuc.TabIndex = 6
        '
        'txt_kasiyer
        '
        Me.txt_kasiyer.Enabled = False
        Me.txt_kasiyer.EnterMoveNextControl = True
        Me.txt_kasiyer.Location = New System.Drawing.Point(136, 25)
        Me.txt_kasiyer.Name = "txt_kasiyer"
        Me.txt_kasiyer.Properties.MaxLength = 10
        Me.txt_kasiyer.Size = New System.Drawing.Size(128, 20)
        Me.txt_kasiyer.TabIndex = 1
        '
        'txt_kod
        '
        Me.txt_kod.Location = New System.Drawing.Point(69, 25)
        Me.txt_kod.Name = "txt_kod"
        Me.txt_kod.Properties.MaxLength = 10
        Me.txt_kod.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_kod.Size = New System.Drawing.Size(67, 20)
        Me.txt_kod.TabIndex = 0
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(270, 105)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(92, 20)
        Me.SimpleButton5.TabIndex = 7
        Me.SimpleButton5.Text = "&Listele"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(184, 45)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.ReadOnly = True
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(80, 20)
        Me.DateEdit2.TabIndex = 3
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(69, 45)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.ReadOnly = True
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(90, 20)
        Me.DateEdit1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Location = New System.Drawing.Point(482, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 137)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ürün Bazlý Talep Emirleri Aþaðýdadýr..."
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton7)
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
        'SimpleButton7
        '
        Me.SimpleButton7.Location = New System.Drawing.Point(159, 10)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(85, 23)
        Me.SimpleButton7.TabIndex = 64
        Me.SimpleButton7.Text = "Talep Karþýlaþtýr"
        Me.SimpleButton7.Visible = False
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(83, 10)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton4.TabIndex = 6
        Me.SimpleButton4.Text = "&Yenile"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(246, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Enabled = False
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(8, 10)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Text = "&Ekle"
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
        Me.PanelControl3.Location = New System.Drawing.Point(0, 141)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 245)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 241)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.sec_grid)
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(818, 208)
        Me.XtraTabPage1.Text = "Fiþler"
        '
        'sec_grid
        '
        Me.sec_grid.Controls.Add(Me.GridControl4)
        Me.sec_grid.Location = New System.Drawing.Point(160, 51)
        Me.sec_grid.Name = "sec_grid"
        Me.sec_grid.Size = New System.Drawing.Size(232, 128)
        Me.sec_grid.TabIndex = 3
        '
        'GridControl4
        '
        Me.GridControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl4.Location = New System.Drawing.Point(0, 0)
        Me.GridControl4.MainView = Me.GridView5
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.Size = New System.Drawing.Size(232, 128)
        Me.GridControl4.TabIndex = 0
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
        '
        'GridView5
        '
        Me.GridView5.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView5.Appearance.Empty.Options.UseBackColor = True
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSEC, Me.colKOD, Me.GridColumn1})
        Me.GridView5.DetailHeight = 160
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.GridControl = Me.GridControl4
        Me.GridView5.GroupFormat = "{0}: {1} {2}"
        Me.GridView5.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView5.IndicatorWidth = 12
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsCustomization.AllowFilter = False
        Me.GridView5.OptionsCustomization.AllowGroup = False
        Me.GridView5.OptionsDetail.ShowDetailTabs = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.OptionsView.ShowIndicator = False
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
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Açýklama"
        Me.GridColumn1.FieldName = "ACIKLAMA"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowFocus = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 128
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
        Me.GridControl1.Size = New System.Drawing.Size(818, 208)
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
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn20, Me.DataColumn21, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn36, Me.DataColumn1, Me.DataColumn2, Me.DataColumn3})
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
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "KOD1"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "KOD2"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "KOD3"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "KOD4"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "KOD5"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "ACIKLAMA"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "KAYITTARIHI"
        Me.DataColumn36.DataType = GetType(Date)
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "BELGENO"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "DEPO"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "SONUC"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.colTARIH, Me.colBELGENO, Me.colKOD1, Me.colKOD2, Me.colKOD3, Me.colKOD4, Me.colKOD5, Me.colACIKLAMA, Me.colKAYITTARIHI, Me.colSONUC, Me.colAKTIF, Me.colMIKTAR, Me.colTDEPO, Me.colTRANSFER, Me.colbKilitli, Me.colDEPO, Me.colnTransfer, Me.colsKullanici, Me.colsKullaniciUpdate})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(286, 377, 208, 156)
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colAKTIF
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = False
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.colMIKTAR
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition2.Value1 = "0"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", Nothing, "{0:#,0.##}")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colIND
        '
        Me.colIND.Caption = "Kayýt No"
        Me.colIND.FieldName = "IND"
        Me.colIND.Name = "colIND"
        Me.colIND.Visible = True
        Me.colIND.VisibleIndex = 0
        Me.colIND.Width = 30
        '
        'colTARIH
        '
        Me.colTARIH.Caption = "Tarih"
        Me.colTARIH.FieldName = "TARIH"
        Me.colTARIH.Name = "colTARIH"
        Me.colTARIH.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TARIH", "{0} Kayýt")})
        Me.colTARIH.Visible = True
        Me.colTARIH.VisibleIndex = 1
        Me.colTARIH.Width = 49
        '
        'colBELGENO
        '
        Me.colBELGENO.Caption = "Belge No"
        Me.colBELGENO.FieldName = "BELGENO"
        Me.colBELGENO.Name = "colBELGENO"
        Me.colBELGENO.Visible = True
        Me.colBELGENO.VisibleIndex = 2
        Me.colBELGENO.Width = 55
        '
        'colKOD1
        '
        Me.colKOD1.Caption = "1.ÖzelKod"
        Me.colKOD1.FieldName = "KOD1"
        Me.colKOD1.Name = "colKOD1"
        Me.colKOD1.Visible = True
        Me.colKOD1.VisibleIndex = 3
        Me.colKOD1.Width = 46
        '
        'colKOD2
        '
        Me.colKOD2.Caption = "2.ÖzelKod"
        Me.colKOD2.FieldName = "KOD2"
        Me.colKOD2.Name = "colKOD2"
        Me.colKOD2.Visible = True
        Me.colKOD2.VisibleIndex = 4
        Me.colKOD2.Width = 61
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
        Me.colKOD5.Visible = True
        Me.colKOD5.VisibleIndex = 9
        Me.colKOD5.Width = 34
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.Caption = "Açýklama"
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 5
        Me.colACIKLAMA.Width = 148
        '
        'colKAYITTARIHI
        '
        Me.colKAYITTARIHI.Caption = "Kayýt Saati"
        Me.colKAYITTARIHI.DisplayFormat.FormatString = "T"
        Me.colKAYITTARIHI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colKAYITTARIHI.FieldName = "KAYITTARIHI"
        Me.colKAYITTARIHI.Name = "colKAYITTARIHI"
        Me.colKAYITTARIHI.Visible = True
        Me.colKAYITTARIHI.VisibleIndex = 7
        Me.colKAYITTARIHI.Width = 65
        '
        'colSONUC
        '
        Me.colSONUC.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colSONUC.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSONUC.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colSONUC.AppearanceCell.Options.UseBackColor = True
        Me.colSONUC.AppearanceCell.Options.UseFont = True
        Me.colSONUC.AppearanceCell.Options.UseForeColor = True
        Me.colSONUC.Caption = "Sonuç"
        Me.colSONUC.FieldName = "SONUC"
        Me.colSONUC.Name = "colSONUC"
        Me.colSONUC.Visible = True
        Me.colSONUC.VisibleIndex = 10
        Me.colSONUC.Width = 46
        '
        'colTDEPO
        '
        Me.colTDEPO.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colTDEPO.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colTDEPO.AppearanceCell.ForeColor = System.Drawing.Color.Navy
        Me.colTDEPO.AppearanceCell.Options.UseBackColor = True
        Me.colTDEPO.AppearanceCell.Options.UseFont = True
        Me.colTDEPO.AppearanceCell.Options.UseForeColor = True
        Me.colTDEPO.Caption = "-> GiriþDeposu"
        Me.colTDEPO.DisplayFormat.FormatString = "-> {0}"
        Me.colTDEPO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colTDEPO.FieldName = "TDEPO"
        Me.colTDEPO.Name = "colTDEPO"
        Me.colTDEPO.Width = 85
        '
        'colTRANSFER
        '
        Me.colTRANSFER.Caption = "Transfer?"
        Me.colTRANSFER.FieldName = "TRANSFER"
        Me.colTRANSFER.Name = "colTRANSFER"
        Me.colTRANSFER.Width = 57
        '
        'colbKilitli
        '
        Me.colbKilitli.Caption = "Kilitli?"
        Me.colbKilitli.FieldName = "bKilitli"
        Me.colbKilitli.Name = "colbKilitli"
        Me.colbKilitli.Visible = True
        Me.colbKilitli.VisibleIndex = 12
        Me.colbKilitli.Width = 46
        '
        'colDEPO
        '
        Me.colDEPO.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colDEPO.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDEPO.AppearanceCell.ForeColor = System.Drawing.Color.Navy
        Me.colDEPO.AppearanceCell.Options.UseBackColor = True
        Me.colDEPO.AppearanceCell.Options.UseFont = True
        Me.colDEPO.AppearanceCell.Options.UseForeColor = True
        Me.colDEPO.Caption = "Depo"
        Me.colDEPO.FieldName = "DEPO"
        Me.colDEPO.Name = "colDEPO"
        Me.colDEPO.Visible = True
        Me.colDEPO.VisibleIndex = 8
        Me.colDEPO.Width = 54
        '
        'colnTransfer
        '
        Me.colnTransfer.Caption = "TransferEdilen"
        Me.colnTransfer.DisplayFormat.FormatString = "#,0.##"
        Me.colnTransfer.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnTransfer.FieldName = "nTransfer"
        Me.colnTransfer.Name = "colnTransfer"
        Me.colnTransfer.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nTransfer", "{0:#,0.####}")})
        '
        'colsKullanici
        '
        Me.colsKullanici.Caption = "Kullanýcý"
        Me.colsKullanici.FieldName = "sKullanici"
        Me.colsKullanici.Name = "colsKullanici"
        '
        'colsKullaniciUpdate
        '
        Me.colsKullaniciUpdate.Caption = "Kullanýcý Update"
        Me.colsKullaniciUpdate.FieldName = "sKullaniciUpdate"
        Me.colsKullaniciUpdate.Name = "colsKullaniciUpdate"
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
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem15, Me.MenuItem27, Me.MenuItem28, Me.MenuItem33, Me.MenuItem35, Me.MenuItem31, Me.MenuItem29, Me.MenuItem32, Me.MenuItem30, Me.MenuItem25, Me.MenuItem16, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem20, Me.MenuItem4, Me.MenuItem13, Me.MenuItem7, Me.MenuItem8, Me.MenuItem9, Me.MenuItem14, Me.MenuItem24, Me.MenuItem10, Me.MenuItem11, Me.MenuItem18, Me.MenuItem17})
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 0
        Me.MenuItem15.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.MenuItem15.Text = "Stok Ara"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 1
        Me.MenuItem27.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem27.Text = "Yenile"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 2
        Me.MenuItem28.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem28.Text = "Envanter"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 3
        Me.MenuItem33.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem33.Text = "Transfer Hareketleri"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 4
        Me.MenuItem35.Text = "Transfer Miktarlarýný Kontrol Et"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 5
        Me.MenuItem31.Text = "-"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 6
        Me.MenuItem29.Text = "Detay Göster"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 7
        Me.MenuItem32.Text = "Detay Envanter Göster"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 8
        Me.MenuItem30.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem30.Text = "Detaylar"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 9
        Me.MenuItem25.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem26, Me.MenuItem34})
        Me.MenuItem25.Text = "Kilit"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 0
        Me.MenuItem26.Text = "Kilitle"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 1
        Me.MenuItem34.Text = "Kilit Kaldýr"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 10
        Me.MenuItem16.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Enabled = False
        Me.MenuItem1.Index = 11
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem1.Text = "Ekle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 12
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem2.Text = "Düzenle"
        '
        'MenuItem3
        '
        Me.MenuItem3.Enabled = False
        Me.MenuItem3.Index = 13
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem3.Text = "Sil"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 14
        Me.MenuItem20.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 15
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem6, Me.MenuItem12, Me.MenuItem23, Me.MenuItem19, Me.MenuItem21, Me.MenuItem22})
        Me.MenuItem4.Text = "Raporla"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.Text = "Stok Envanter Listesi"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 1
        Me.MenuItem6.Text = "Stok Envanter Depo Daðýlýmý"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 2
        Me.MenuItem12.Text = "Stok Envanteri (-)Eksiye Düþenler"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 3
        Me.MenuItem23.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 4
        Me.MenuItem19.Text = "Önizle"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 5
        Me.MenuItem21.Text = "Dizayn"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 6
        Me.MenuItem22.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem22.Text = "Yazdýr"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 16
        Me.MenuItem13.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 17
        Me.MenuItem7.Text = "Görünümü Düzenle"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 18
        Me.MenuItem8.Text = "Görünümü Kaydet"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 19
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem9.Text = "Görünümü Yazdýr"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 20
        Me.MenuItem14.Text = "-"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 21
        Me.MenuItem24.Text = "Hýzlý Filtre"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 22
        Me.MenuItem10.Text = "Filtrele"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 23
        Me.MenuItem11.Text = "Gruplandýr"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 24
        Me.MenuItem18.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 25
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"", "Ürün Bazlý Talep Listesi ", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"[User Name]", "Talep Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.HiddenPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1, Me.DockPanel2})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
        Me.DockPanel1.ID = New System.Guid("135ea2d7-4ccc-4e3b-99f0-1ecd7830fdf7")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 286)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(0, 0)
        Me.DockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
        Me.DockPanel1.SavedIndex = 0
        Me.DockPanel1.Size = New System.Drawing.Size(656, 134)
        Me.DockPanel1.TabText = "Detay"
        Me.DockPanel1.Text = "detaylar"
        Me.DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.GridControl2)
        Me.DockPanel1_Container.Controls.Add(Me.Label9)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 25)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(650, 106)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 13)
        Me.GridControl2.MainView = Me.GridView3
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(650, 93)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3, Me.GridView2})
        '
        'GridView3
        '
        Me.GridView3.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.Empty.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedCell.BackColor = System.Drawing.Color.Turquoise
        Me.GridView3.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.Turquoise
        Me.GridView3.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Turquoise
        Me.GridView3.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView3.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clMIKTAR, Me.clSTOKNO, Me.clSTOKKODU, Me.clMALINCINSI, Me.clRENK, Me.clACIKLAMA, Me.clMEVCUT})
        Me.GridView3.DetailHeight = 160
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.GridControl = Me.GridControl2
        Me.GridView3.GroupFormat = "{0}: {1} {2}"
        Me.GridView3.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView3.IndicatorWidth = 12
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsDetail.ShowDetailTabs = False
        Me.GridView3.OptionsNavigation.UseTabKey = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'clMIKTAR
        '
        Me.clMIKTAR.Caption = "Miktar"
        Me.clMIKTAR.FieldName = "MIKTAR"
        Me.clMIKTAR.Name = "clMIKTAR"
        Me.clMIKTAR.Visible = True
        Me.clMIKTAR.VisibleIndex = 0
        Me.clMIKTAR.Width = 68
        '
        'clSTOKNO
        '
        Me.clSTOKNO.Caption = "Stok No"
        Me.clSTOKNO.FieldName = "STOKNO"
        Me.clSTOKNO.Name = "clSTOKNO"
        '
        'clSTOKKODU
        '
        Me.clSTOKKODU.Caption = "Stok Kodu"
        Me.clSTOKKODU.FieldName = "STOKKODU"
        Me.clSTOKKODU.Name = "clSTOKKODU"
        Me.clSTOKKODU.Visible = True
        Me.clSTOKKODU.VisibleIndex = 1
        Me.clSTOKKODU.Width = 103
        '
        'clMALINCINSI
        '
        Me.clMALINCINSI.Caption = "Stok Adý"
        Me.clMALINCINSI.FieldName = "MALINCINSI"
        Me.clMALINCINSI.Name = "clMALINCINSI"
        Me.clMALINCINSI.Visible = True
        Me.clMALINCINSI.VisibleIndex = 2
        Me.clMALINCINSI.Width = 210
        '
        'clRENK
        '
        Me.clRENK.Caption = "Renk"
        Me.clRENK.FieldName = "RENK"
        Me.clRENK.Name = "clRENK"
        Me.clRENK.Visible = True
        Me.clRENK.VisibleIndex = 3
        '
        'clACIKLAMA
        '
        Me.clACIKLAMA.Caption = "Not"
        Me.clACIKLAMA.FieldName = "ACIKLAMA"
        Me.clACIKLAMA.Name = "clACIKLAMA"
        Me.clACIKLAMA.Visible = True
        Me.clACIKLAMA.VisibleIndex = 4
        Me.clACIKLAMA.Width = 121
        '
        'clMEVCUT
        '
        Me.clMEVCUT.Caption = "Mevcut"
        Me.clMEVCUT.DisplayFormat.FormatString = "#,0.####"
        Me.clMEVCUT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clMEVCUT.FieldName = "MEVCUT"
        Me.clMEVCUT.Name = "clMEVCUT"
        Me.clMEVCUT.Visible = True
        Me.clMEVCUT.VisibleIndex = 5
        Me.clMEVCUT.Width = 69
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Label9"
        '
        'DockPanel2
        '
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
        Me.DockPanel2.FloatLocation = New System.Drawing.Point(594, 366)
        Me.DockPanel2.FloatSize = New System.Drawing.Size(280, 197)
        Me.DockPanel2.ID = New System.Guid("57f2deb2-0a92-4993-aefe-c5fab3e8e349")
        Me.DockPanel2.Location = New System.Drawing.Point(-32768, -32768)
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel2.SavedIndex = 0
        Me.DockPanel2.Size = New System.Drawing.Size(280, 197)
        Me.DockPanel2.Text = "DepoMevcutlarý"
        Me.DockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.GridControl3)
        Me.DockPanel2_Container.Controls.Add(Me.Label10)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(3, 22)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(274, 172)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'GridControl3
        '
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(0, 13)
        Me.GridControl3.MainView = Me.GridView4
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(274, 159)
        Me.GridControl3.TabIndex = 1
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
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsAciklama, Me.colGIREN, Me.colCIKAN, Me.colKALAN, Me.colMEVCUT, Me.colBEKLEYEN})
        Me.GridView4.CustomizationFormBounds = New System.Drawing.Rectangle(806, 484, 208, 170)
        Me.GridView4.DetailHeight = 160
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.GridControl = Me.GridControl3
        Me.GridView4.GroupFormat = "{0}: {1} {2}"
        Me.GridView4.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
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
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Depo"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sAciklama", "{0} Kayýt")})
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 0
        Me.colsAciklama.Width = 120
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
        Me.colCIKAN.Caption = "Çýkan"
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
        'colMEVCUT
        '
        Me.colMEVCUT.Caption = "Mevcut"
        Me.colMEVCUT.DisplayFormat.FormatString = "#,0.####"
        Me.colMEVCUT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMEVCUT.FieldName = "MEVCUT"
        Me.colMEVCUT.Name = "colMEVCUT"
        Me.colMEVCUT.Width = 93
        '
        'colBEKLEYEN
        '
        Me.colBEKLEYEN.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colBEKLEYEN.AppearanceCell.ForeColor = System.Drawing.Color.Navy
        Me.colBEKLEYEN.AppearanceCell.Options.UseFont = True
        Me.colBEKLEYEN.AppearanceCell.Options.UseForeColor = True
        Me.colBEKLEYEN.Caption = "Bekleyen"
        Me.colBEKLEYEN.CustomizationCaption = "Bekleyen"
        Me.colBEKLEYEN.DisplayFormat.FormatString = "#,#.##"
        Me.colBEKLEYEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBEKLEYEN.FieldName = "BEKLEYEN"
        Me.colBEKLEYEN.Name = "colBEKLEYEN"
        Me.colBEKLEYEN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BEKLEYEN", "{0:#,0.##}")})
        Me.colBEKLEYEN.Visible = True
        Me.colBEKLEYEN.VisibleIndex = 2
        Me.colBEKLEYEN.Width = 80
        '
        'Label10
        '
        Me.Label10.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(8, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "%"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Location = New System.Drawing.Point(60, 0)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(130, 23)
        Me.SimpleButton6.TabIndex = 1
        Me.SimpleButton6.Text = "Talep-Transfer Karþýlaþtýr"
        '
        'frm_stok_etikettalep_liste
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_etikettalep_liste"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ürün Bazlý Talep Listesi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_ArtiEksi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_tDepo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sonuc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kasiyer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sec_grid.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dataset1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel1_Container.PerformLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel2.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        Me.DockPanel2_Container.PerformLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public status As Boolean = False
    Public connection
    Public firmano
    Public donemno
    Public stokno
    Public userno
    Public kasiyer
    Public kasiyerno
    Public kullanici
    Public yetkiBakma As Boolean = False
    Dim kayitno
    Dim qkayitno
    Dim ilkbelge
    Dim sonbelge
    Dim kod1
    Dim kod2
    Dim qkod1
    Dim qkod2
    Dim depo
    Dim tDepo
    Dim qdepo
    Dim ilktarih
    Dim sontarih
    Dim sonuc
    Dim qsonuc
    Dim aciklama
    Dim qaciklama
    Dim dr As DataRow
    Dim count
    Public mevcut
    Public yeni
    Public frf_islem As String = "mektup"
    Dim depokodu As String
    Dim ds_kasiyer As DataSet
    Dim ds_detay As DataSet
    Dim ds_depo As DataSet
    Dim ds_tDepo As DataSet
    Public belgetipi As Integer = 0
    Public bSayim As Boolean = False
    Public nIndler As String = ""
    Dim seriNO As String = ""
    Dim belgeNo_talepTransfer As String = ""
    Dim bBaskaKullaniciEvraki As Boolean = False
    Public UrunBazliTalepEkraniMi As Boolean = False
    Private Sub frm_stok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        '    depokodu = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("DEPOKODU").ToString
        '    If depokodu <> "True" Then
        '        sec_depo.Text = "'" & depokodu & "'"
        '    Else
        '        sec_depo.Text = "[Tümü]"
        '    End If
        'Catch ex As Exception
        '    'dr("DEPO") = "1KAT"
        '    Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("DEPOKODU", "True")
        'End Try
        If Trim(txt_ara.Text) = "" Then
            sec_depo.Text = "'" & sDepo & "'"
            DateEdit1.EditValue = dteSistemTarihi
            DateEdit2.EditValue = dteSistemTarihi
        End If
        qdepo = "Eþittir"
        dataload_depo_pos()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        If Label1.Text = "Etiket Talep Formlarý..." Then
            SimpleButton7.Visible = True
        ElseIf Label1.Text = "Transfer Talep Formlarý..." Then
            SimpleButton7.Visible = True
        End If
        Me.WindowState = FormWindowState.Maximized
        Me.Refresh()
        dataload_kasiyer()
        If belgetipi = 1 Then
            colKOD1.Caption = "Satýcý"
            colKOD5.Caption = "Döküm?"
            colACIKLAMA.Caption = "Müþteri"
        End If
        If belgetipi = 2 Then
            colKOD1.Caption = "Teslim Eden"
            colACIKLAMA.Caption = "Teslim Alan"
            colTRANSFER.Visible = True
            colTDEPO.Visible = True
            colDEPO.Caption = "ÇýkýþDeposu->"
            Label1.BackColor = System.Drawing.Color.Crimson
            PictureBox1.BackColor = Label1.BackColor
            GroupControl1.BackColor = Label1.BackColor
            DateEdit1.Properties.ReadOnly = True
            DateEdit2.Properties.ReadOnly = True
        ElseIf belgetipi = 0 Then
            Label1.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(0, Byte))
            PictureBox1.BackColor = Label1.BackColor
            GroupControl1.BackColor = Label1.BackColor
            DateEdit1.Properties.ReadOnly = False
            DateEdit2.Properties.ReadOnly = False
        ElseIf belgetipi = 1 Then
            Label1.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
            PictureBox1.BackColor = Label1.BackColor
            GroupControl1.BackColor = Label1.BackColor
            DateEdit1.Properties.ReadOnly = False
            DateEdit2.Properties.ReadOnly = False
        End If
        'Try
        '    dataload()
        'Catch ex As Exception
        'End Try
        If bSayim = True Then
            sec_sonuc.Text = "Sayým..."
            sec_sonuc.Enabled = False
            DateEdit1.Properties.ReadOnly = True
            DateEdit2.Properties.ReadOnly = True
        End If
        If sDatabaseGenel = "UGURLU" Then
            If yetkiBakma = True Then
                SimpleButton3.Enabled = True
                MenuItem1.Enabled = True
            End If
        Else
            SimpleButton3.Enabled = True
            MenuItem1.Enabled = True
        End If
    End Sub
    Private Sub dataload_depo_pos()
        ds_depo = sorgu(sorgu_query("SELECT     DISTINCT CAST('0' as bit) AS SEC, sdepo AS KOD, sAciklama AS ACIKLAMA FROM         tbDepo Order by sDepo"))
        ds_tDepo = sorgu(sorgu_query("SELECT     DISTINCT CAST('0' as bit) AS SEC, sdepo AS KOD, sAciklama AS ACIKLAMA FROM         tbDepo Order by sDepo"))
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
        SimpleButton5.Text = Sorgu_sDil(SimpleButton5.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "")
    End Sub
    Private Sub dataload_kasiyer()
        ds_kasiyer = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sKasiyerRumuzu AS IND, sAdi + ' ' + sSoyadi AS KASIYER, sSifresi AS SIFRE, sDepo AS DEPO, bBaskaKullaniciEvraki FROM tbKasiyer WHERE (sKasiyerRumuzu <> '')"))
    End Sub
    Private Sub dataload_depo()
        sec_renk.DataSource = sorgu(sorgu_query("SELECT * FROM tbRenk")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        conn.Close()
        Return DS
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub kasiyer_kontrol()
            Dim sonuc As Boolean = False
            For Each dr In ds_kasiyer.Tables(0).Rows
                If dr("SIFRE") = txt_kod.Text Then
                    kasiyerno = dr("IND")
                kasiyer = dr("KASIYER")
                If sDatabaseGenel = "UGURLU" Then
                    bBaskaKullaniciEvraki = Boolean.Parse(dr("bBaskaKullaniciEvraki").ToString())
                End If
                sonuc = True
            End If
 Next

        If sonuc = True Then
            txt_kasiyer.EditValue = kasiyer
            txt_kod.Enabled = False
            If Trim(kasiyerno) = "VC" Then
                DateEdit1.Properties.ReadOnly = False
                DateEdit2.Properties.ReadOnly = False
                sec_depo.Properties.ReadOnly = False
                sec_sonuc.Properties.ReadOnly = False
            ElseIf Trim(kasiyerno) = "YÖ" Or Trim(kasiyerno) = "MB" Or Trim(kasiyerno) = "ALI" Then
                DateEdit1.Properties.ReadOnly = False
                DateEdit2.Properties.ReadOnly = False
                sec_depo.Properties.ReadOnly = False
                sec_sonuc.Properties.ReadOnly = False
            Else
            End If
            DateEdit1.Focus()
            DateEdit1.SelectAll()
            status = True
            GridControl1.Enabled = True
            If sDatabaseGenel = "UGURLU" And kullaniciKodu <> "Admin" And kullaniciKodu <> "ALI" Then
                If yetkiBakma = False Then
                    If yetki_kontrol1(kasiyer, "frm_transfer_ekle", True, 0, 1) = True Then
                        SimpleButton3.Enabled = True
                        MenuItem1.Enabled = True
                    End If
                End If
            Else
                SimpleButton3.Enabled = True
                MenuItem1.Enabled = True
            End If
        ElseIf sonuc = False Then
            txt_kasiyer.EditValue = ""
            txt_kod.Enabled = True
            txt_kod.EditValue = ""
            GridControl1.Enabled = False
            txt_kod.Focus()
            txt_kod.SelectAll()
            status = False
            XtraMessageBox.Show(Sorgu_sDil("Þifre Hatalý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub sorgu()
        If GridView1.RowCount > 0 Then
            nIndler = satir_kontrol2()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
        System.GC.Collect()
        System.GC.GetTotalMemory(True)
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub dataload()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        ilktarih = (DateEdit1.EditValue).ToString
        sontarih = (DateEdit2.EditValue).ToString
        If sec_depo.Text <> "[Tümü]" Then
            depo = sec_depo.Text
        Else
            depo = ""
        End If
        If sec_tDepo.Text <> "[Tümü]" Then
            tDepo = sec_tDepo.Text
        Else
            tDepo = ""
        End If
        If bSayim = True Then
            sec_sonuc.Text = "Sayým..."
        End If
        If sec_sonuc.Text <> "[Tümü]" Then
            sonuc = sec_sonuc.Text
        Else
            sonuc = ""
        End If
        qdepo = "Eþittir"
        qsonuc = "Eþittir"
        dataload_depo()
        'DataSet1.Clear()
        'DataSet1.Dispose()
        Dataset1 = stok(sec_depo.Text, sec_tDepo.Text, txt_ara.EditValue, sec_konum.Text, sec_kriter.Text)
        GridControl1.DataSource = Dataset1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub stok_yeni()
        Dim frm As New frm_stok_etikettalep
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.kasiyer = kasiyer
        frm.kasiyerno = kasiyerno
        frm.belgetipi = belgetipi
        frm.kullaniciNo = kullaniciKodu
        frm.kullanici = kullanici
        frm.bSayim = bSayim
        If yetki_kontrol(kullanici, belgetipi & frm.Name) = True Then
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
            If bBaskaKullaniciEvraki = True Then
                If dr("KOD4") = Microsoft.VisualBasic.Left(kasiyer, 50) Then
                    Dim frm As New frm_stok_etikettalep
                    frm.connection = connection
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.kasiyer = kasiyer
                    frm.kasiyerno = kasiyerno
                    frm.belgetipi = belgetipi
                    frm.yeniYetki = SimpleButton3.Enabled
                    frm.belgeind = dr("IND")
                    If Trim(txt_ara.Text) <> "" Then
                        frm.sStokAciklama = Trim(txt_ara.Text)
                        frm.sStokKonum = sec_konum.Text
                        frm.sStokKriter = sec_kriter.Text
                    End If
                    frm.status = True
                    frm.kullanici = kullanici
                    If yetki_kontrol(kullanici, belgetipi & frm.Name) = True Then
                        frm.ShowDialog()
                    End If
                    frm.Close()
                    frm.Dispose()
                    frm = Nothing
                    Dim satir = GridView1.FocusedRowHandle
                    dataload()
                    GridView1.FocusedRowHandle = satir
                    satir = Nothing
                Else
                    XtraMessageBox.Show(Sorgu_sDil("Baþka Kullanýcý Evrakýna Müdahale Yetkiniz Bulunmamaktadýr!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If txt_kasiyer.Text.Length > 2 Then
                    Dim frm As New frm_stok_etikettalep
                    frm.connection = connection
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.kasiyer = kasiyer
                    frm.kasiyerno = kasiyerno
                    frm.belgetipi = belgetipi
                    frm.yeniYetki = SimpleButton3.Enabled
                    frm.belgeind = dr("IND")
                    If Trim(txt_ara.Text) <> "" Then
                        frm.sStokAciklama = Trim(txt_ara.Text)
                        frm.sStokKonum = sec_konum.Text
                        frm.sStokKriter = sec_kriter.Text
                    End If
                    frm.status = True
                    frm.kullanici = kullanici
                    If yetki_kontrol(kullanici, belgetipi & frm.Name) = True Then
                        frm.ShowDialog()
                    End If
                    frm.Close()
                    frm.Dispose()
                    frm = Nothing
                    Dim satir = GridView1.FocusedRowHandle
                    dataload()
                    GridView1.FocusedRowHandle = satir
                    satir = Nothing
                Else
                    'XtraMessageBox.Show(Sorgu_sDil("Lütfen Kasiyer Giriþi Yapýnýz.", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'txt_kasiyer.Focus()
                    Dim frm As New frm_stok_etikettalep
                    frm.connection = connection
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.kasiyer = kasiyer
                    frm.kasiyerno = kasiyerno
                    frm.belgetipi = belgetipi
                    frm.yeniYetki = SimpleButton3.Enabled
                    frm.belgeind = dr("IND")
                    If Trim(txt_ara.Text) <> "" Then
                        frm.sStokAciklama = Trim(txt_ara.Text)
                        frm.sStokKonum = sec_konum.Text
                        frm.sStokKriter = sec_kriter.Text
                    End If
                    frm.status = True
                    frm.bKilitliMi = True
                    frm.kullanici = kullanici
                    If yetki_kontrol(kullanici, belgetipi & frm.Name) = True Then
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
            End If
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
        stok_yeni()
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
    Private Function seriNoBul(ByVal serNO As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokID FROM tbStokFisiSeriNo WHERE sSeri='" & serNO & "'")
        Try
            seriNO = cmd.ExecuteScalar
        Catch ex As Exception
            seriNO = ""
        End Try
    End Function
    Public Function stok(ByVal sDepo As String, ByVal tDepo As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String) As DataSet
        Dim kriter
        kriter = "WHERE (BASLIK.IND> 0 ) "
        If kayitno <> "" Then
            kriter += " AND (BASLIK.IND " & sorgu_kriter_string(kayitno, qkayitno) & ")"
        End If
        If ilktarih <> "" And sontarih <> "" Then
            kriter += " AND (BASLIK.TARIH BETWEEN '" & ilktarih & "' AND '" & sontarih & "')"
        End If
        If ilkbelge <> "" And sonbelge = "" Then
            kriter += " AND (BASLIK.BELGENO LIKE '" & ilkbelge & " %')"
        ElseIf ilkbelge <> "" And sonbelge <> "" Then
            kriter += " AND (BASLIK.BELGENO BETWEEN '" & ilkbelge & " ' AND '" & sonbelge & "')"
        End If
        If kod1 <> "" Then
            kriter += " AND (BASLIK.KOD1 " & sorgu_kriter_string(kod1, qkod1) & " )"
        End If
        If kod2 <> "" Then
            kriter += " AND (BASLIK.KOD2 " & sorgu_kriter_string(kod2, qkod2) & " )"
        End If
        If aciklama <> "" Then
            kriter += " AND (BASLIK.ACIKLAMA " & sorgu_kriter_string(aciklama, qaciklama) & " )"
        End If
        If sDepo <> "[Tümü]" Then
            kriter += " AND BASLIK.DEPO IN ( " & sDepo & " )"
        End If
        If tDepo <> "[Tümü]" Then
            kriter += " AND BASLIK.TDEPO IN ( " & tDepo & " )"
        End If
        'If depo <> "" Then
        '    kriter += " AND (DEPO " & sorgu_kriter_string(depo, qdepo) & " )"
        'End If
        'If tDepo <> "" Then
        '    kriter += " AND (TDEPO " & sorgu_kriter_string(tDepo, qdepo) & " )"
        'End If
        If sonuc <> "" Then
            kriter += " AND (BASLIK.SONUC " & sorgu_kriter_string(sonuc, qsonuc) & " )"
        End If
        kriter += " AND (BASLIK.BELGETIPI= " & belgetipi & ") "
        If Trim(ara).ToString <> "" Then
            If konum = "Kod" Then
                kriter += " AND (HAREKET.STOKKODU " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Ad" Then
                kriter += " AND (HAREKET.MALINCINSI " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Barkod" Then
                kriter += " AND (HAREKET.BARCODE " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Seri No" Then
                seriNoBul(ara)
                kriter += " AND (HAREKET.STOKNO " & sorgu_kriter_string(seriNO, ara_kriter) & ")"
            End If
        End If
        'kriter += " AND (SELECT ISNULL(SUM(MIKTAR),0) AS MIKTAR FROM ASTOKETIKETTALEPDETAY WHERE EVRAKNO = ASTOKETIKETTALEPBASLIK.IND ) <> 0"
        Dim kriterArtiEksi As String = ""
        If Trim(sec_ArtiEksi.Text) = "Tümü" Then
            kriterArtiEksi = ""
        ElseIf Trim(sec_ArtiEksi.Text) = "Artýlar" Then
            kriterArtiEksi = "HAVING (SUM(HAREKET.MIKTAR) > 0)"
        ElseIf Trim(sec_ArtiEksi.Text) = "Eksiler" Then
            kriterArtiEksi = "HAVING (SUM(HAREKET.MIKTAR) < 0)"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *,(SELECT ISNULL(SUM(MIKTAR),0) FROM ASTOKETIKETTALEPDETAY WHERE EVRAKNO = ASTOKETIKETTALEPBASLIK.IND) AS MIKTAR FROM ASTOKETIKETTALEPBASLIK  " & kriter & " ORDER BY IND DESC")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT BASLIK.IND, BASLIK.TARIH, BASLIK.BELGETIPI, BASLIK.BELGENO, BASLIK.DEPO, BASLIK.TDEPO, BASLIK.KOD1, BASLIK.KOD2, BASLIK.KOD3, BASLIK.KOD4, BASLIK.KOD5, CAST(BASLIK.ACIKLAMA AS NVARCHAR(255)) AS ACIKLAMA, BASLIK.KAYITTARIHI, BASLIK.SONUC, BASLIK.AKTIF, BASLIK.TRANSFER, BASLIK.HESAPNO, BASLIK.HESAPADI, BASLIK.bKilitli, SUM(HAREKET.MIKTAR) AS MIKTAR,CAST(0 AS MONEY) AS nTransfer, ISNULL(BASLIK.sKullanici, '') as sKullanici, ISNULL(BASLIK.sKullaniciUpdate, '') as sKullaniciUpdate FROM ASTOKETIKETTALEPBASLIK BASLIK INNER JOIN ASTOKETIKETTALEPDETAY HAREKET ON BASLIK.IND = HAREKET.EVRAKNO " & kriter & " GROUP BY BASLIK.IND, BASLIK.TARIH, BASLIK.BELGETIPI, BASLIK.BELGENO, BASLIK.DEPO, BASLIK.TDEPO, BASLIK.KOD1, BASLIK.KOD2, BASLIK.KOD3, BASLIK.KOD4, BASLIK.KOD5, CAST(BASLIK.ACIKLAMA AS NVARCHAR(255)), BASLIK.KAYITTARIHI, BASLIK.SONUC, BASLIK.AKTIF, BASLIK.TRANSFER, BASLIK.HESAPNO, BASLIK.HESAPADI, BASLIK.bKilitli, BASLIK.sKullanici, BASLIK.sKullaniciUpdate " & kriterArtiEksi & " ORDER BY BASLIK.IND DESC")
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
        Dim satir As String = " ("
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
                satir += dr1("IND").ToString
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
    Private Function satir_kontrol2()
        Dim satir As String = ""
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
                satir += dr1("IND").ToString
                sayi += 1
                If sayi < toplamsayi Then
                    satir += ","
                ElseIf sayi = toplamsayi Then
                    'satir += ")"
                End If
            Next
        End If
        Return satir
    End Function
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim qr_hareket As New TfrxADOQuery
            Dim qr_baslik As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT STOKNO, STOKKODU, MALINCINSI, BARCODE, RENK, BEDEN, MODEL, DEPO, SUM(MIKTAR) AS MIKTAR FROM ASTOKETIKETTALEPDETAY WHERE (EVRAKNO IN " & kriter & " ) GROUP BY STOKNO, STOKKODU, MALINCINSI, BARCODE, RENK, BEDEN, MODEL, DEPO ORDER BY MALINCINSI")
            qr_baslik = frx.FindObject("qr_baslik")
            qr_baslik.Query = sorgu_query("set transaction isolation level read uncommitted SELECT * FROM ASTOKETIKETTALEPBASLIK WHERE IND IN " & kriter & "")
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
                frx.PrintOptions.Copies = 1
                frx.PrintReport()
            ElseIf status = 2 Then
                frx.PrepareReport(True)
                frx.DesignReport()
            ElseIf status = 3 Then
            End If
            qr_hareket = Nothing
            qr_baslik = Nothing
            qr_connection = Nothing
            frx = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(2) = "" & sorgu_query("set transaction isolation level read uncommitted SELECT STOKNO, STOKKODU, MALINCINSI, BARCODE, RENK, BEDEN, MODEL, DEPO, SUM(MIKTAR) AS MIKTAR FROM ASTOKETIKETTALEPDETAY WHERE (EVRAKNO IN " & kriter & " ) GROUP BY STOKNO, STOKKODU, MALINCINSI, BARCODE, RENK, BEDEN, MODEL, DEPO ORDER BY MALINCINSI") & "é" & sorgu_query("set transaction isolation level read uncommitted SELECT * FROM ASTOKETIKETTALEPBASLIK WHERE IND IN " & kriter & "") & ""
            args(3) = "qr_hareketéqr_baslik"
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
    Private Sub report_create_stok_olmayan(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim qr_hareket As New TfrxADOQuery
            Dim qr_baslik As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sorgu_query("SELECT Hareket.dteFisTarihi AS TARIH, Musteri.nMusteriID AS FIRMANO, Musteri.lKodu AS FIRMAKODU, Hareket.lFisNo AS FISNO, Musteri.sAdi AS ADI, Musteri.sSoyadi AS SOYADI, Hareket.lFisNo AS FISNO, Hareket.sDepo AS DEPONO, Stok.sKodu AS STOKKODU, Stok.sAciklama AS MALINCINSI, tbStokBarkodu.sBarkod AS BARKOD, tbRenk.sRenkAdi AS RENK, Hareket.lCikisMiktar1 AS MIKTAR, Stok.sModel AS MODEL, Hareket.sFisTipi AS IZAHAT, Hareket.sSaticiRumuzu AS SATICI, Hareket.sKasiyerRumuzu AS KASIYER, Hareket.nIslemID AS IND, Hareket.nGirisCikis AS CIKIS FROM tbStokFisiDetayi Hareket INNER JOIN tbMusteri Musteri ON Hareket.nMusteriID = Musteri.nMusteriID INNER JOIN tbStok Stok ON Hareket.nStokID = Stok.nStokID INNER JOIN tbStokBarkodu ON Stok.nStokID = tbStokBarkodu.nStokID INNER JOIN tbRenk ON Stok.sRenk = tbRenk.sRenk " & kriter & " ORDER BY Hareket.nGirisCikis, Hareket.sDepo,Hareket.nMusteriID, Hareket.lFisNo ")
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
                frx.PrintOptions.Copies = 1
                frx.PrintReport()
            ElseIf status = 2 Then
                frx.PrepareReport(True)
                frx.DesignReport()
            ElseIf status = 3 Then
            End If
            qr_baslik = Nothing
            qr_hareket = Nothing
            qr_connection = Nothing
            frx = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(2) = "" & sorgu_query("SELECT Hareket.dteFisTarihi AS TARIH, Musteri.nMusteriID AS FIRMANO, Musteri.lKodu AS FIRMAKODU, Hareket.lFisNo AS FISNO, Musteri.sAdi AS ADI, Musteri.sSoyadi AS SOYADI, Hareket.lFisNo AS FISNO, Hareket.sDepo AS DEPONO, Stok.sKodu AS STOKKODU, Stok.sAciklama AS MALINCINSI, tbStokBarkodu.sBarkod AS BARKOD, tbRenk.sRenkAdi AS RENK, Hareket.lCikisMiktar1 AS MIKTAR, Stok.sModel AS MODEL, Hareket.sFisTipi AS IZAHAT, Hareket.sSaticiRumuzu AS SATICI, Hareket.sKasiyerRumuzu AS KASIYER, Hareket.nIslemID AS IND, Hareket.nGirisCikis AS CIKIS FROM tbStokFisiDetayi Hareket INNER JOIN tbMusteri Musteri ON Hareket.nMusteriID = Musteri.nMusteriID INNER JOIN tbStok Stok ON Hareket.nStokID = Stok.nStokID INNER JOIN tbStokBarkodu ON Stok.nStokID = tbStokBarkodu.nStokID INNER JOIN tbRenk ON Stok.sRenk = tbRenk.sRenk " & kriter & " ORDER BY Hareket.nGirisCikis, Hareket.sDepo,Hareket.nMusteriID, Hareket.lFisNo ") & ""
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
        Try
            If GridView1.RowCount > 0 Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                If Label1.Text = "Etiket Talep Formlarý..." Then
                    belgeNo_talepTransfer = dr("BELGENO")
                ElseIf Label1.Text = "Transfer Talep Formlarý..." Then
                    belgeNo_talepTransfer = dr("KOD3")
                End If
                dr = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        stok_ara()
    End Sub
    Private Sub stok_ara()
        Dim frm As New frm_stok
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        stok_duzelt()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            stok_duzelt()
        ElseIf e.KeyCode = Keys.Escape Then
            'Me.Close()
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
        'Me.Hide()
        'PanelControl1 = Nothing
        'PanelControl2 = Nothing
        'PanelControl3 = Nothing
        'XtraTabControl1 = Nothing
        'XtraTabPage1 = Nothing
        'GridControl1 = Nothing
        'GridView1 = Nothing
        'SimpleButton1 = Nothing
        'SimpleButton2 = Nothing
        'SimpleButton3 = Nothing
        'PictureBox1 = Nothing
        'Label1 = Nothing
        'ContextMenu1 = Nothing
        'MenuItem1 = Nothing
        'MenuItem2 = Nothing
        'MenuItem3 = Nothing
        'MenuItem7 = Nothing
        'MenuItem8 = Nothing
        'MenuItem9 = Nothing
        'MenuItem10 = Nothing
        'MenuItem11 = Nothing
        'MenuItem13 = Nothing
        'MenuItem14 = Nothing
        'MenuItem15 = Nothing
        'MenuItem16 = Nothing
        'ps = Nothing
        'printlink1 = Nothing
        'Label2 = Nothing
        'MenuItem17 = Nothing
        'MenuItem18 = Nothing
        'sec_renk = Nothing
        'OpenFileDialog1 = Nothing
        'Dataset1 = Nothing
        'DataTable2 = Nothing
        'DataColumn20 = Nothing
        'DataColumn21 = Nothing
        'DataColumn29 = Nothing
        'DataColumn30 = Nothing
        'DataColumn31 = Nothing
        'DataColumn32 = Nothing
        'DataColumn33 = Nothing
        'DataColumn34 = Nothing
        'DataColumn36 = Nothing
        'colIND = Nothing
        'colTARIH = Nothing
        'colBELGENO = Nothing
        'colKOD1 = Nothing
        'colKOD2 = Nothing
        'colKOD3 = Nothing
        'colKOD4 = Nothing
        'colKOD5 = Nothing
        'colACIKLAMA = Nothing
        'colKAYITTARIHI = Nothing
        'MenuItem4 = Nothing
        'MenuItem5 = Nothing
        'MenuItem6 = Nothing
        'MenuItem20 = Nothing
        'DataColumn1 = Nothing
        'DataColumn2 = Nothing
        'DataColumn3 = Nothing
        'colDEPO = Nothing
        'colSONUC = Nothing
        'SimpleButton4 = Nothing
        'GroupControl1 = Nothing
        'txt_kasiyer = Nothing
        'txt_kod = Nothing
        'LabelControl4 = Nothing
        'sec_depo = Nothing
        'SimpleButton5 = Nothing
        'LabelControl3 = Nothing
        'LabelControl6 = Nothing
        'LabelControl1 = Nothing
        'LabelControl2 = Nothing
        'DateEdit2 = Nothing
        'DateEdit1 = Nothing
        'LabelControl4 = Nothing
        'sec_sonuc = Nothing
        'MenuItem27 = Nothing
        'colAKTIF = Nothing
        'colMIKTAR = Nothing
        'colTDEPO = Nothing
        'DockManager1 = Nothing
        'DockPanel1 = Nothing
        'DockPanel1_Container = Nothing
        'Label9 = Nothing
        'GridControl2 = Nothing
        'GridView2 = Nothing
        'GridView3 = Nothing
        'clMIKTAR = Nothing
        'clSTOKNO = Nothing
        'clSTOKKODU = Nothing
        'clMALINCINSI = Nothing
        'clRENK = Nothing
        'MenuItem28 = Nothing
        ''hideContainerBottom = Nothing
        'clACIKLAMA = Nothing
        'MenuItem29 = Nothing
        'colTRANSFER = Nothing
        'clMEVCUT = Nothing
        'MenuItem30 = Nothing
        'MenuItem31 = Nothing
        'DockPanel2 = Nothing
        'DockPanel2_Container = Nothing
        'Label10 = Nothing
        'GridControl3 = Nothing
        'GridView4 = Nothing
        'colsAciklama = Nothing
        'colGIREN = Nothing
        'colCIKAN = Nothing
        'colKALAN = Nothing
        'colMEVCUT = Nothing
        'colBEKLEYEN = Nothing
        'MenuItem32 = Nothing
        'status = Nothing
        'connection = Nothing
        'firmano = Nothing
        'donemno = Nothing
        'stokno = Nothing
        'userno = Nothing
        'kayitno = Nothing
        'qkayitno = Nothing
        'ilkbelge = Nothing
        'sonbelge = Nothing
        'kod1 = Nothing
        'kod2 = Nothing
        'qkod1 = Nothing
        'qkod2 = Nothing
        'depo = Nothing
        'qdepo = Nothing
        'ilktarih = Nothing
        'sontarih = Nothing
        'sonuc = Nothing
        'qsonuc = Nothing
        'aciklama = Nothing
        'qaciklama = Nothing
        'dr = Nothing
        'count = Nothing
        'mevcut = Nothing
        'yeni = Nothing
        'qr_hareket = Nothing
        'frf_islem = Nothing
        'depokodu = Nothing
        'ds_kasiyer = Nothing
        'kasiyerno = Nothing
        'kasiyer = Nothing
        'belgetipi = Nothing
        'Me.Close()
        'Me.Dispose()
        System.GC.Collect()
        System.GC.SuppressFinalize(Me)
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
    Private Sub raporla(ByVal rapor As Integer, ByVal islem As Integer)
        Dim file As String
        OpenFileDialog1.Filter = "Rapor Dosyalarý (*.fr3) |*.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Etiket Talep"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            report_create_stok(file, satir_kontrol, islem)
        End If
        file = Nothing
    End Sub
    Private Sub rpt_Stok_liste_envanter()
        Dim frm As New frm_stok_liste_envanter
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub rpt_Stok_liste_envanter_eksi()
        Dim frm As New frm_stok_liste_envanter_eksi
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub rpt_stok_envanter_depo_dagilim()
        Dim frm As New frm_stok_envanter_dagilim
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub MenuItem19_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        raporla(3, 0)
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        raporla(4, 0)
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Try
            dataload()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        Try
            dataload()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txt_kod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_kod.KeyDown
        If e.KeyCode = Keys.Enter Then
            kasiyer_kontrol()
        End If
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        Try
            dataload()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub analiz_envanter()
        If GridView3.RowCount > 0 Then
            dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
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
        If GridView3.RowCount > 0 Then
            dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri_transfer
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            'frm.stokno = dr("STOKNO")
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
    Private Sub satir_stok_info()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Label9.Text = "Tarih: " & dr("TARIH") & vbTab & " BelgeNo: " & dr("BELGENO") & vbTab & " Depo: " & dr("DEPO")
            ds_detay = sorgu(sorgu_query("SELECT     cast(MIKTAR as money) as MIKTAR ,STOKNO,STOKKODU,MALINCINSI,RENK,ACIKLAMA,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE  tbStokFisiDetayi.nStokID = ASTOKETIKETTALEPDETAY.STOKNO) AS MEVCUT FROM         ASTOKETIKETTALEPDETAY WHERE EVRAKNO =" & dr("IND") & " "))
            GridControl2.DataSource = ds_detay.Tables(0)
            GridControl2.DataMember = Nothing
            If MenuItem32.Checked = True Then
                satir_stok_mevcut_info()
            End If
            dr = Nothing
        End If
    End Sub
    Private Sub satir_stok_mevcut_info()
        If GridView3.RowCount > 0 Then
            Dim dr As DataRow = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            Label10.Text = dr("MALINCINSI")
            If Trim(dr("RENK").ToString) <> "" Then
                Label10.Text += vbTab & " (" & dr("RENK") & " )"
            End If
            ds_detay = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sAciklama, SUM(GIREN) AS GIREN, SUM(CIKAN) AS CIKAN, SUM(KALAN) AS KALAN,SUM(BEKLEYEN) AS BEKLEYEN, sBarkod, STOKKODU, STOKADI, sRenk, sBeden, lAsgariMiktar, lAzamiMiktar, sModel FROM (SELECT depo.sAciklama , 0 AS GIREN , 0 AS CIKAN , 0 AS KALAN , barkod.sBarkod , stok.sKodu AS STOKKODU , stok.sAciklama AS STOKADI , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu ='" & Trim(dr("STOKKODU")) & "') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') GROUP BY depo.sAciklama , barkod.sBarkod , stok.sKodu , stok.sAciklama , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel UNION SELECT depo.sAciklama , ISNULL(SUM(hareket.lGirisMiktar1) , 0) AS GIREN , ISNULL(SUM(hareket.lCikisMiktar1) , 0) AS CIKAN , ISNULL(SUM(hareket.lGirisMiktar1 - hareket.lCikisMiktar1) , 0) AS KALAN , barkod.sBarkod , stok.sKodu AS STOKKODU , stok.sAciklama AS STOKADI , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , 0 AS BEKLEYEN FROM tbStokBarkodu barkod INNER JOIN tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo ON barkod.nStokID = stok.nStokID and barkod.nKisim = 0 WHERE (stok.sKodu = '" & Trim(dr("STOKKODU")) & "') GROUP BY depo.sAciklama , stok.nStokID , barkod.sBarkod , stok.sKodu , stok.sAciklama , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , depo.sDepo) TT GROUP BY sAciklama, sBarkod, STOKKODU, STOKADI, sRenk, sBeden, lAsgariMiktar, lAzamiMiktar, sModel"))
            GridControl3.DataSource = ds_detay.Tables(0)
            GridControl3.DataMember = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide Or DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible Then
            Try
                satir_stok_info()
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        If DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible Then
            analiz_envanter()
        End If
    End Sub
    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        If MenuItem29.Checked = False Then
            DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            MenuItem29.Checked = True
        ElseIf MenuItem29.Checked = True Then
            DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            MenuItem29.Checked = False
        End If
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        If MenuItem30.Checked = False Then
            GridControl2.Focus()
            GridControl2.Select()
            MenuItem30.Checked = True
        ElseIf MenuItem30.Checked = True Then
            GridControl1.Focus()
            GridControl1.Select()
            MenuItem30.Checked = False
        End If
    End Sub
    Private Sub GridView3_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView3.FocusedRowChanged
        If DockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide Or DockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible Then
            Try
                satir_stok_mevcut_info()
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        If MenuItem32.Checked = False Then
            DockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
            satir_stok_mevcut_info()
            MenuItem32.Checked = True
            GridControl1.Focus()
            GridControl1.Select()
        ElseIf MenuItem32.Checked = True Then
            DockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            MenuItem32.Checked = False
            GridControl1.Focus()
            GridControl1.Select()
        End If
    End Sub
    Private Sub DockPanel2_VisibilityChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking.VisibilityChangedEventArgs) Handles DockPanel2.VisibilityChanged
        If DockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden Then
            MenuItem32.Checked = False
        ElseIf DockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible Then
            MenuItem32.Checked = True
        End If
    End Sub
    Private Sub DockPanel1_VisibilityChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking.VisibilityChangedEventArgs) Handles DockPanel1.VisibilityChanged
        If DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden Then
            MenuItem29.Checked = False
        ElseIf DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible Then
            MenuItem29.Checked = True
        End If
    End Sub
    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        If DockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible Then
            analiz_hareket_transfer()
        End If
    End Sub
    Private Sub MenuItem5_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        rpt_Stok_liste_envanter()
    End Sub
    Private Sub MenuItem6_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        rpt_stok_envanter_depo_dagilim()
    End Sub
    Private Sub MenuItem12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        rpt_Stok_liste_envanter_eksi()
    End Sub
    Private Sub MenuItem21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        raporla(0, 1)
    End Sub
    Private Sub MenuItem22_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        raporla(0, 2)
    End Sub
    Private Sub MenuItem19_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        raporla(0, 0)
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        If MenuItem24.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem24.Checked = True
        ElseIf MenuItem24.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem24.Checked = True
        End If
    End Sub
    Private Sub sec_depo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_depo.QueryPopUp
        sec_tDepo.Properties.PopupControl = Nothing
        sec_depo.Properties.PopupControl = sec_grid
        GridControl4.DataSource = ds_depo.Tables(0)
        GridControl4.DataMember = Nothing
    End Sub
    Private Sub sec_depo_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_depo.QueryResultValue
        Dim s As String = deger(ds_depo)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
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
        'If s.ToString <> "" Then
        '    e.Value = s.ToString
        'Else
        '    e.Value = "[Tümü]"
        'End If
        Return s.ToString
    End Function
    Private Sub satirlar_kilit(ByVal bKilitli As Byte)
        Dim arr As Integer()
        Dim i As Integer
        Dim sayi As Integer = 0
        Dim nFirmaID As String = ""
        Dim s As String = ""
        Dim dr As DataRow
        arr = GridView1.GetSelectedRows()
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr = GridView1.GetDataRow(s)
                tbSiparisAciklamasi_Kilit(dr("IND"), bKilitli)
            Next
        End If
        XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub tbSiparisAciklamasi_Kilit(ByVal IND As Int64, ByVal bKilitli As Byte)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    ASTOKETIKETTALEPBASLIK  SET  bKilitli = " & bKilitli & " where IND =" & IND & "")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
    End Sub
    Private Sub sec_tDepo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_tDepo.QueryPopUp
        sec_tDepo.Properties.PopupControl = sec_grid
        sec_depo.Properties.PopupControl = Nothing
        GridControl4.DataSource = ds_tDepo.Tables(0)
        GridControl4.DataMember = Nothing
    End Sub
    Private Sub sec_tDepo_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_tDepo.QueryResultValue
        Dim s As String = deger(ds_tDepo)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        If kullanici < 3 Then
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Fis Kayýtlarýný Kilitlemek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                satirlar_kilit(1)
            End If
        End If
    End Sub
    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        If kullanici < 3 Then
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Bordro Kayýtlarýnýn Kilitlerini Kaldýrmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                satirlar_kilit(0)
            End If
        End If
    End Sub
    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Bordro Kayýtlarýnýn Transfer Miktarlarýný Kontrol Etmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            Dim dr As DataRow
            For Each dr In Dataset1.Tables(0).Rows
                dr("nTransfer") = sorgula_Decimal("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select SUM(lCikisMiktar1) from tbStokFisiDetayi where sFisTipi ='T' and nGirisCikis =3 and lFisNo = " & dr("IND") & " AND dteFisTarihi = '" & dr("TARIH") & "'")
            Next
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...", sDil) & vbCrLf & Sorgu_sDil("Kontrol Eþleþtirme Yapabilirsiniz...!", sDil), Sorgu_sDil("Dikat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        Dim frm As New frm_Talep_Transfer_Teslim
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.belgeNo_talepTransfer = belgeNo_talepTransfer
        frm.Show()
    End Sub
End Class
