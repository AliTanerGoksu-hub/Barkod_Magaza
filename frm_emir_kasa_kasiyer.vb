Imports FastReport
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_emir_kasa_kasiyer
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
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ds_magaza As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents ds_kasa As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents ds_kasiyer As System.Data.DataSet
    Friend WithEvents DataTable4 As System.Data.DataTable
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents ds_harekettipi As System.Data.DataSet
    Friend WithEvents DataTable5 As System.Data.DataTable
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents ds_fistipi As System.Data.DataSet
    Friend WithEvents DataTable6 As System.Data.DataTable
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents colSEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_depo As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents sec_kasakasiyer As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents sec_harekettipi As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents sec_fistipi As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents sec_grid As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_kasatipi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ContextMenu2 As System.Windows.Forms.ContextMenu
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
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents colSýnýf As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAciklama1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIZAHAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcol1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcol2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcol3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcol4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcol5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcol6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents colcol7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents colcol8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBoxLink1 As DevExpress.XtraPrintingLinks.RichTextBoxLink
    Friend WithEvents CompositeLink1 As DevExpress.XtraPrintingLinks.CompositeLink
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents TimeEdit2 As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents TimeEdit1 As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents sec_bKesintiDus As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_bPoslar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_bNakitler As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_sSubeMagaza As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SimpleButton17 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton18 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sAciklama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteBordroTarihi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_emir_kasa_kasiyer))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIZAHAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSýnýf = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_kasatipi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_fistipi = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.sec_grid = New DevExpress.XtraEditors.PopupContainerControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu2 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSEC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_harekettipi = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.sec_kasakasiyer = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.sec_depo = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.TimeEdit2 = New DevExpress.XtraEditors.TimeEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.TimeEdit1 = New DevExpress.XtraEditors.TimeEdit()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sAciklama = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteBordroTarihi = New DevExpress.XtraEditors.DateEdit()
        Me.sec_bKesintiDus = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_bPoslar = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_bNakitler = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_sSubeMagaza = New DevExpress.XtraEditors.LookUpEdit()
        Me.SimpleButton17 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton18 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
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
        Me.DataColumn28 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAciklama1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcol1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcol2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcol3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcol4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcol5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcol6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcol7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcol8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.CompositeLink1 = New DevExpress.XtraPrintingLinks.CompositeLink(Me.components)
        Me.RichTextBoxLink1 = New DevExpress.XtraPrintingLinks.RichTextBoxLink()
        Me.ds_magaza = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.ds_kasa = New System.Data.DataSet()
        Me.DataTable3 = New System.Data.DataTable()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
        Me.ds_kasiyer = New System.Data.DataSet()
        Me.DataTable4 = New System.Data.DataTable()
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.DataColumn21 = New System.Data.DataColumn()
        Me.ds_harekettipi = New System.Data.DataSet()
        Me.DataTable5 = New System.Data.DataTable()
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        Me.ds_fistipi = New System.Data.DataSet()
        Me.DataTable6 = New System.Data.DataTable()
        Me.DataColumn25 = New System.Data.DataColumn()
        Me.DataColumn26 = New System.Data.DataColumn()
        Me.DataColumn27 = New System.Data.DataColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_kasatipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_fistipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sec_grid.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_harekettipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kasakasiyer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.txt_sAciklama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteBordroTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteBordroTarihi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bKesintiDus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bPoslar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bNakitler.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSubeMagaza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompositeLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RichTextBoxLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_magaza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_kasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_kasiyer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_harekettipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_fistipi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        '
        'colIZAHAT
        '
        Me.colIZAHAT.FieldName = "IZAHAT"
        Me.colIZAHAT.Name = "colIZAHAT"
        Me.colIZAHAT.Visible = True
        Me.colIZAHAT.VisibleIndex = 2
        Me.colIZAHAT.Width = 65
        '
        'colSýnýf
        '
        Me.colSýnýf.FieldName = "Sýnýf"
        Me.colSýnýf.Name = "colSýnýf"
        Me.colSýnýf.Visible = True
        Me.colSýnýf.VisibleIndex = 0
        Me.colSýnýf.Width = 52
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 130)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.sec_kasatipi)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.sec_fistipi)
        Me.GroupControl1.Controls.Add(Me.sec_harekettipi)
        Me.GroupControl1.Controls.Add(Me.sec_kasakasiyer)
        Me.GroupControl1.Controls.Add(Me.sec_depo)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.TimeEdit2)
        Me.GroupControl1.Controls.Add(Me.TimeEdit1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(726, 126)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Text = "Ara"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.Location = New System.Drawing.Point(432, 81)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl9.TabIndex = 25
        Me.LabelControl9.Text = "Ýçerir"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.Location = New System.Drawing.Point(432, 61)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl8.TabIndex = 24
        Me.LabelControl8.Text = "Ýçerir"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.Location = New System.Drawing.Point(432, 41)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl7.TabIndex = 23
        Me.LabelControl7.Text = "Ýçerir"
        '
        'sec_kasatipi
        '
        Me.sec_kasatipi.EditValue = "Kasiyer:"
        Me.sec_kasatipi.EnterMoveNextControl = True
        Me.sec_kasatipi.Location = New System.Drawing.Point(5, 61)
        Me.sec_kasatipi.Name = "sec_kasatipi"
        Me.sec_kasatipi.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sec_kasatipi.Properties.Appearance.Options.UseBackColor = True
        Me.sec_kasatipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kasatipi.Properties.Items.AddRange(New Object() {"Kasiyer:", "Kasa:"})
        Me.sec_kasatipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kasatipi.Size = New System.Drawing.Size(67, 20)
        Me.sec_kasatipi.TabIndex = 3
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.Location = New System.Drawing.Point(7, 81)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(17, 13)
        Me.LabelControl6.TabIndex = 20
        Me.LabelControl6.Text = "HT:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(7, 41)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl5.TabIndex = 19
        Me.LabelControl5.Text = "Maðaza:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(225, 85)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl4.TabIndex = 18
        Me.LabelControl4.Text = "Fiþler:"
        '
        'sec_fistipi
        '
        Me.sec_fistipi.EditValue = "[Tümü]"
        Me.sec_fistipi.EnterMoveNextControl = True
        Me.sec_fistipi.Location = New System.Drawing.Point(256, 81)
        Me.sec_fistipi.Name = "sec_fistipi"
        Me.sec_fistipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_fistipi.Properties.PopupControl = Me.sec_grid
        Me.sec_fistipi.Properties.ShowPopupCloseButton = False
        Me.sec_fistipi.Size = New System.Drawing.Size(170, 20)
        Me.sec_fistipi.TabIndex = 6
        '
        'sec_grid
        '
        Me.sec_grid.Controls.Add(Me.GridControl2)
        Me.sec_grid.Location = New System.Drawing.Point(144, 24)
        Me.sec_grid.Name = "sec_grid"
        Me.sec_grid.Size = New System.Drawing.Size(232, 128)
        Me.sec_grid.TabIndex = 1
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenu = Me.ContextMenu2
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(232, 128)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'ContextMenu2
        '
        Me.ContextMenu2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem17, Me.MenuItem18})
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 0
        Me.MenuItem17.Text = "Tümünü Seç"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 1
        Me.MenuItem18.Text = "Tümünü Kaldýr"
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
        'sec_harekettipi
        '
        Me.sec_harekettipi.EditValue = "[Tümü]"
        Me.sec_harekettipi.EnterMoveNextControl = True
        Me.sec_harekettipi.Location = New System.Drawing.Point(72, 81)
        Me.sec_harekettipi.Name = "sec_harekettipi"
        Me.sec_harekettipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_harekettipi.Properties.ShowPopupCloseButton = False
        Me.sec_harekettipi.Size = New System.Drawing.Size(147, 20)
        Me.sec_harekettipi.TabIndex = 5
        '
        'sec_kasakasiyer
        '
        Me.sec_kasakasiyer.EditValue = "[Tümü]"
        Me.sec_kasakasiyer.EnterMoveNextControl = True
        Me.sec_kasakasiyer.Location = New System.Drawing.Point(72, 61)
        Me.sec_kasakasiyer.Name = "sec_kasakasiyer"
        Me.sec_kasakasiyer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kasakasiyer.Properties.ShowPopupCloseButton = False
        Me.sec_kasakasiyer.Size = New System.Drawing.Size(354, 20)
        Me.sec_kasakasiyer.TabIndex = 4
        '
        'sec_depo
        '
        Me.sec_depo.EditValue = "[Tümü]"
        Me.sec_depo.EnterMoveNextControl = True
        Me.sec_depo.Location = New System.Drawing.Point(72, 41)
        Me.sec_depo.Name = "sec_depo"
        Me.sec_depo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo.Properties.ShowPopupCloseButton = False
        Me.sec_depo.Size = New System.Drawing.Size(354, 20)
        Me.sec_depo.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(432, 25)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "Arasýndaki"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(238, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl1.TabIndex = 12
        Me.LabelControl1.Text = "ve"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(7, 21)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Tarih:"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = New Date(2007, 6, 16, 19, 41, 57, 199)
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(256, 21)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit2.TabIndex = 1
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = New Date(2007, 6, 16, 19, 41, 51, 511)
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(72, 21)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(88, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(72, 101)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(354, 20)
        Me.SimpleButton3.TabIndex = 7
        Me.SimpleButton3.Text = "&Listele"
        '
        'TimeEdit2
        '
        Me.TimeEdit2.EditValue = New Date(2010, 12, 12, 0, 0, 0, 0)
        Me.TimeEdit2.Location = New System.Drawing.Point(356, 21)
        Me.TimeEdit2.MenuManager = Me.BarManager1
        Me.TimeEdit2.Name = "TimeEdit2"
        Me.TimeEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TimeEdit2.Size = New System.Drawing.Size(70, 20)
        Me.TimeEdit2.TabIndex = 27
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarSubItem1, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10})
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
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Ara,F3"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Detay,F7"
        Me.BarButtonItem10.Id = 10
        Me.BarButtonItem10.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem10.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem10.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Excel"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Text"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Mail"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Raporla"
        Me.BarSubItem1.Id = 5
        Me.BarSubItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarSubItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Önizle"
        Me.BarButtonItem6.Id = 6
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Dizayn"
        Me.BarButtonItem7.Id = 7
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Yazdýr"
        Me.BarButtonItem8.Id = 8
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Görünümü Yazdýr"
        Me.BarButtonItem9.Id = 9
        Me.BarButtonItem9.Name = "BarButtonItem9"
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
        'TimeEdit1
        '
        Me.TimeEdit1.EditValue = New Date(2010, 12, 12, 0, 0, 0, 0)
        Me.TimeEdit1.Location = New System.Drawing.Point(160, 21)
        Me.TimeEdit1.MenuManager = Me.BarManager1
        Me.TimeEdit1.Name = "TimeEdit1"
        Me.TimeEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.TimeEdit1.Size = New System.Drawing.Size(70, 20)
        Me.TimeEdit1.TabIndex = 26
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
        Me.PictureBox1.Size = New System.Drawing.Size(94, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton4)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 359)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = Global.business_smart.My.Resources.Resources.replace2
        Me.SimpleButton4.Location = New System.Drawing.Point(12, 8)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton4.TabIndex = 7
        Me.SimpleButton4.Text = "&Entegre"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(141, 15)
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
        Me.PanelControl3.Controls.Add(Me.GroupControl6)
        Me.PanelControl3.Controls.Add(Me.RichTextBox1)
        Me.PanelControl3.Controls.Add(Me.sec_grid)
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 130)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 229)
        Me.PanelControl3.TabIndex = 0
        '
        'GroupControl6
        '
        Me.GroupControl6.Controls.Add(Me.LabelControl11)
        Me.GroupControl6.Controls.Add(Me.txt_sAciklama)
        Me.GroupControl6.Controls.Add(Me.LabelControl10)
        Me.GroupControl6.Controls.Add(Me.txt_dteBordroTarihi)
        Me.GroupControl6.Controls.Add(Me.sec_bKesintiDus)
        Me.GroupControl6.Controls.Add(Me.sec_bPoslar)
        Me.GroupControl6.Controls.Add(Me.sec_bNakitler)
        Me.GroupControl6.Controls.Add(Me.sec_sSubeMagaza)
        Me.GroupControl6.Controls.Add(Me.SimpleButton17)
        Me.GroupControl6.Controls.Add(Me.SimpleButton18)
        Me.GroupControl6.Controls.Add(Me.LabelControl28)
        Me.GroupControl6.Location = New System.Drawing.Point(280, 27)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(264, 160)
        Me.GroupControl6.TabIndex = 86
        Me.GroupControl6.Text = "Entegrasyon Parametreleri"
        Me.GroupControl6.Visible = False
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl11.Location = New System.Drawing.Point(26, 48)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl11.TabIndex = 77
        Me.LabelControl11.Text = "Açýklama:"
        '
        'txt_sAciklama
        '
        Me.txt_sAciklama.EditValue = "Perakende Entegre"
        Me.txt_sAciklama.Location = New System.Drawing.Point(82, 44)
        Me.txt_sAciklama.MenuManager = Me.BarManager1
        Me.txt_sAciklama.Name = "txt_sAciklama"
        Me.txt_sAciklama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAciklama.Properties.Appearance.Options.UseBackColor = True
        Me.txt_sAciklama.Size = New System.Drawing.Size(166, 20)
        Me.txt_sAciklama.TabIndex = 76
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.Location = New System.Drawing.Point(42, 22)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl10.TabIndex = 75
        Me.LabelControl10.Text = "Tarih:"
        '
        'txt_dteBordroTarihi
        '
        Me.txt_dteBordroTarihi.EditValue = New Date(2007, 6, 16, 19, 41, 57, 199)
        Me.txt_dteBordroTarihi.EnterMoveNextControl = True
        Me.txt_dteBordroTarihi.Location = New System.Drawing.Point(82, 22)
        Me.txt_dteBordroTarihi.Name = "txt_dteBordroTarihi"
        Me.txt_dteBordroTarihi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_dteBordroTarihi.Properties.Appearance.Options.UseBackColor = True
        Me.txt_dteBordroTarihi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteBordroTarihi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteBordroTarihi.Size = New System.Drawing.Size(166, 20)
        Me.txt_dteBordroTarihi.TabIndex = 74
        '
        'sec_bKesintiDus
        '
        Me.sec_bKesintiDus.Location = New System.Drawing.Point(168, 110)
        Me.sec_bKesintiDus.MenuManager = Me.BarManager1
        Me.sec_bKesintiDus.Name = "sec_bKesintiDus"
        Me.sec_bKesintiDus.Properties.Caption = "Kesinti Düþ"
        Me.sec_bKesintiDus.Size = New System.Drawing.Size(75, 19)
        Me.sec_bKesintiDus.TabIndex = 73
        '
        'sec_bPoslar
        '
        Me.sec_bPoslar.EditValue = True
        Me.sec_bPoslar.Location = New System.Drawing.Point(80, 110)
        Me.sec_bPoslar.MenuManager = Me.BarManager1
        Me.sec_bPoslar.Name = "sec_bPoslar"
        Me.sec_bPoslar.Properties.Caption = "Poslar"
        Me.sec_bPoslar.Size = New System.Drawing.Size(75, 19)
        Me.sec_bPoslar.TabIndex = 72
        '
        'sec_bNakitler
        '
        Me.sec_bNakitler.EditValue = True
        Me.sec_bNakitler.Location = New System.Drawing.Point(80, 92)
        Me.sec_bNakitler.MenuManager = Me.BarManager1
        Me.sec_bNakitler.Name = "sec_bNakitler"
        Me.sec_bNakitler.Properties.Caption = "Nakitler"
        Me.sec_bNakitler.Size = New System.Drawing.Size(75, 19)
        Me.sec_bNakitler.TabIndex = 71
        '
        'sec_sSubeMagaza
        '
        Me.sec_sSubeMagaza.EnterMoveNextControl = True
        Me.sec_sSubeMagaza.Location = New System.Drawing.Point(82, 66)
        Me.sec_sSubeMagaza.MenuManager = Me.BarManager1
        Me.sec_sSubeMagaza.Name = "sec_sSubeMagaza"
        Me.sec_sSubeMagaza.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sSubeMagaza.Properties.Appearance.Options.UseBackColor = True
        Me.sec_sSubeMagaza.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSubeMagaza.Properties.DisplayMember = "sSubeMagaza"
        Me.sec_sSubeMagaza.Properties.NullText = "[sSubeMagaza]"
        Me.sec_sSubeMagaza.Properties.ValueMember = "sSubeMagaza"
        Me.sec_sSubeMagaza.Size = New System.Drawing.Size(166, 20)
        Me.sec_sSubeMagaza.TabIndex = 70
        '
        'SimpleButton17
        '
        Me.SimpleButton17.Image = CType(resources.GetObject("SimpleButton17.Image"), System.Drawing.Image)
        Me.SimpleButton17.Location = New System.Drawing.Point(170, 130)
        Me.SimpleButton17.Name = "SimpleButton17"
        Me.SimpleButton17.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton17.TabIndex = 69
        Me.SimpleButton17.Text = "&Vazgeç"
        '
        'SimpleButton18
        '
        Me.SimpleButton18.Image = CType(resources.GetObject("SimpleButton18.Image"), System.Drawing.Image)
        Me.SimpleButton18.Location = New System.Drawing.Point(82, 130)
        Me.SimpleButton18.Name = "SimpleButton18"
        Me.SimpleButton18.Size = New System.Drawing.Size(82, 24)
        Me.SimpleButton18.TabIndex = 68
        Me.SimpleButton18.Text = "&Kaydet"
        '
        'LabelControl28
        '
        Me.LabelControl28.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl28.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl28.Location = New System.Drawing.Point(44, 67)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl28.TabIndex = 67
        Me.LabelControl28.Text = "Kasa:"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(84, 85)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(216, 102)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = "Kasayý Tutan" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "1.Kontrol" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "2.Kontrol" & Global.Microsoft.VisualBasic.ChrW(10) & "---------------------" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "--------------" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "--" & _
    "-----------" & Global.Microsoft.VisualBasic.ChrW(10) & "      Ad:" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "      Ad:" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "     Ad:" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Soyad:" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Soyad:" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Soyad:" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Ýmza" & _
    ":" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Ýmza:" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "  " & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "  Ýmza:"
        Me.RichTextBox1.Visible = False
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
        Me.GridControl1.Size = New System.Drawing.Size(820, 225)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem15, Me.MenuItem16, Me.MenuItem19, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        Me.MenuItem16.Index = 3
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem16.Text = "Detay Göster"
        '
        'MenuItem19
        '
        Me.MenuItem19.Enabled = False
        Me.MenuItem19.Index = 4
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem19.Text = "Firma Kartý"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 5
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 6
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 7
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 8
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 9
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 10
        Me.MenuItem10.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 11
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 12
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 13
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 14
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 15
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 16
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 17
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn28})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Sýnýf"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "Aciklama"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "IZAHAT"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "MIKTAR"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "col1"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "col2"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "col3"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "col4"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "col5"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "col6"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Status"
        Me.DataColumn11.DataType = GetType(Boolean)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "col7"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "col8"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSýnýf, Me.colAciklama1, Me.colIZAHAT, Me.colMIKTAR, Me.colcol1, Me.colcol2, Me.colcol3, Me.colcol4, Me.colcol5, Me.colcol6, Me.colStatus, Me.colcol7, Me.colcol8})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(755, 311, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Black
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colStatus
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Tag = False
        StyleFormatCondition1.Value1 = False
        StyleFormatCondition2.Appearance.Options.UseTextOptions = True
        StyleFormatCondition2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colStatus
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Tag = True
        StyleFormatCondition2.Value1 = True
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Appearance.Options.UseFont = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.colIZAHAT
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Tag = "Toplam"
        StyleFormatCondition3.Value1 = "Toplam"
        StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition4.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        StyleFormatCondition4.Appearance.Options.UseBackColor = True
        StyleFormatCondition4.Appearance.Options.UseFont = True
        StyleFormatCondition4.ApplyToRow = True
        StyleFormatCondition4.Column = Me.colSýnýf
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition4.Tag = "Baþlýk"
        StyleFormatCondition4.Value1 = "Baþlýk"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayýt")})
        Me.GridView1.IndicatorWidth = 12
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsPrint.PrintHeader = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowColumnHeaders = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colAciklama1
        '
        Me.colAciklama1.FieldName = "Aciklama"
        Me.colAciklama1.Name = "colAciklama1"
        Me.colAciklama1.Visible = True
        Me.colAciklama1.VisibleIndex = 1
        Me.colAciklama1.Width = 115
        '
        'colMIKTAR
        '
        Me.colMIKTAR.DisplayFormat.FormatString = "#,0.00"
        Me.colMIKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMIKTAR.FieldName = "MIKTAR"
        Me.colMIKTAR.Name = "colMIKTAR"
        Me.colMIKTAR.Visible = True
        Me.colMIKTAR.VisibleIndex = 3
        Me.colMIKTAR.Width = 55
        '
        'colcol1
        '
        Me.colcol1.DisplayFormat.FormatString = "#,0.00"
        Me.colcol1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colcol1.FieldName = "col1"
        Me.colcol1.Name = "colcol1"
        Me.colcol1.Visible = True
        Me.colcol1.VisibleIndex = 5
        Me.colcol1.Width = 78
        '
        'colcol2
        '
        Me.colcol2.DisplayFormat.FormatString = "#,0.00"
        Me.colcol2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colcol2.FieldName = "col2"
        Me.colcol2.Name = "colcol2"
        Me.colcol2.Visible = True
        Me.colcol2.VisibleIndex = 6
        Me.colcol2.Width = 78
        '
        'colcol3
        '
        Me.colcol3.DisplayFormat.FormatString = "#,0.00"
        Me.colcol3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colcol3.FieldName = "col3"
        Me.colcol3.Name = "colcol3"
        Me.colcol3.Visible = True
        Me.colcol3.VisibleIndex = 7
        Me.colcol3.Width = 80
        '
        'colcol4
        '
        Me.colcol4.DisplayFormat.FormatString = "#,0.00"
        Me.colcol4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colcol4.FieldName = "col4"
        Me.colcol4.Name = "colcol4"
        Me.colcol4.Visible = True
        Me.colcol4.VisibleIndex = 8
        Me.colcol4.Width = 83
        '
        'colcol5
        '
        Me.colcol5.DisplayFormat.FormatString = "#,0.00"
        Me.colcol5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colcol5.FieldName = "col5"
        Me.colcol5.Name = "colcol5"
        Me.colcol5.Visible = True
        Me.colcol5.VisibleIndex = 9
        Me.colcol5.Width = 77
        '
        'colcol6
        '
        Me.colcol6.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colcol6.AppearanceCell.Options.UseFont = True
        Me.colcol6.DisplayFormat.FormatString = "#,0.00"
        Me.colcol6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colcol6.FieldName = "col6"
        Me.colcol6.Name = "colcol6"
        Me.colcol6.Visible = True
        Me.colcol6.VisibleIndex = 10
        Me.colcol6.Width = 95
        '
        'colcol7
        '
        Me.colcol7.FieldName = "col7"
        Me.colcol7.Name = "colcol7"
        Me.colcol7.Visible = True
        Me.colcol7.VisibleIndex = 4
        Me.colcol7.Width = 40
        '
        'colcol8
        '
        Me.colcol8.Caption = "Kapali"
        Me.colcol8.FieldName = "col8"
        Me.colcol8.Name = "colcol8"
        Me.colcol8.Width = 31
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
        Me.printlink1.Owner = Me.CompositeLink1
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Firma Kayýtlarý", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Firma Hesaplarý Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'CompositeLink1
        '
        '
        '
        '
        Me.CompositeLink1.ImageCollection.ImageStream = CType(resources.GetObject("CompositeLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.CompositeLink1.Links.AddRange(New Object() {Me.printlink1, Me.RichTextBoxLink1})
        Me.CompositeLink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.CompositeLink1.Owner = Nothing
        Me.CompositeLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.CompositeLink1.PrintingSystem = Me.ps
        Me.CompositeLink1.PrintingSystemBase = Me.ps
        '
        'RichTextBoxLink1
        '
        '
        '
        '
        Me.RichTextBoxLink1.ImageCollection.ImageStream = CType(resources.GetObject("RichTextBoxLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.RichTextBoxLink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.RichTextBoxLink1.Owner = Me.CompositeLink1
        Me.RichTextBoxLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.RichTextBoxLink1.PrintingSystem = Me.ps
        Me.RichTextBoxLink1.PrintingSystemBase = Me.ps
        Me.RichTextBoxLink1.RichTextBox = Me.RichTextBox1
        '
        'ds_magaza
        '
        Me.ds_magaza.DataSetName = "NewDataSet"
        Me.ds_magaza.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_magaza.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn13, Me.DataColumn14, Me.DataColumn15})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "SEC"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "KOD"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "ACIKLAMA"
        '
        'ds_kasa
        '
        Me.ds_kasa.DataSetName = "NewDataSet"
        Me.ds_kasa.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_kasa.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn16, Me.DataColumn17, Me.DataColumn18})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "SEC"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "KOD"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "ACIKLAMA"
        '
        'ds_kasiyer
        '
        Me.ds_kasiyer.DataSetName = "NewDataSet"
        Me.ds_kasiyer.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_kasiyer.Tables.AddRange(New System.Data.DataTable() {Me.DataTable4})
        '
        'DataTable4
        '
        Me.DataTable4.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn19, Me.DataColumn20, Me.DataColumn21})
        Me.DataTable4.TableName = "Table1"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "SEC"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "KOD"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "ACIKLAMA"
        '
        'ds_harekettipi
        '
        Me.ds_harekettipi.DataSetName = "NewDataSet"
        Me.ds_harekettipi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_harekettipi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable5})
        '
        'DataTable5
        '
        Me.DataTable5.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn22, Me.DataColumn23, Me.DataColumn24})
        Me.DataTable5.TableName = "Table1"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "SEC"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "KOD"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "ACIKLAMA"
        '
        'ds_fistipi
        '
        Me.ds_fistipi.DataSetName = "NewDataSet"
        Me.ds_fistipi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_fistipi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable6})
        '
        'DataTable6
        '
        Me.DataTable6.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn25, Me.DataColumn26, Me.DataColumn27})
        Me.DataTable6.TableName = "Table1"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "SEC"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "KOD"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "ACIKLAMA"
        '
        'frm_emir_kasa_kasiyer
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
        Me.Name = "frm_emir_kasa_kasiyer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kasa Raporu"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_kasatipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_fistipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sec_grid.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_harekettipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kasakasiyer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        Me.GroupControl6.PerformLayout()
        CType(Me.txt_sAciklama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteBordroTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteBordroTarihi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bKesintiDus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bPoslar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bNakitler.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSubeMagaza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompositeLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RichTextBoxLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_magaza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_kasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_kasiyer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_harekettipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_fistipi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public kullanici
    Public bKasaKasiyer As Boolean = False
    Public islemstatus As Boolean = False
    Dim ds1 As DataSet
    Dim ds_Faaliyet As New DataSet
    Dim ds_SatisKarlilik As DataSet
    Dim ds_SubeMagaza As DataSet
    Dim ds_OdemeSekli As DataSet
    Dim nakit As Decimal = 0
    Dim nakit_pesinat As Decimal = 0
    Dim nakits_pesinat As Decimal = 0
    Dim masraf As Decimal = 0
    Public pos As Boolean = False
    Public nPosIslem As Integer = 0
    Dim nOdemeTipi As Int64 = 0
    Dim nBankaFirmaID As Int64 = 0
    Dim nKesintiFirmaID As Int64 = 0
    Dim nKesintiHesapID As Int64 = 0
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        If pos = False Then
            DateEdit1.EditValue = dteSistemTarihi
            DateEdit2.EditValue = dteSistemTarihi
            txt_dteBordroTarihi.EditValue = dteSistemTarihi
            dataload_depo()
            colcol7.Visible = False
            colcol8.Visible = False
        Else
            colcol7.Visible = True
            colcol8.Visible = True
            colcol8.Caption = ""
            colcol8.VisibleIndex = 5
            dataload_depo_pos()
        End If
        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        DateEdit1.Focus()
        DateEdit1.Select()
        If pos = True Then
            ara()
        End If
        Me.WindowState = FormWindowState.Normal
    End Sub
    Private Sub dataload_depo()
        ds_magaza = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, sDepo AS KOD, sAciklama AS ACIKLAMA FROM         tbDepo WHERE sDepo <> '' ORDER BY sDepo"))
        ds_kasiyer = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, sKasiyerRumuzu AS KOD, sAdi + ' ' + sSoyadi AS ACIKLAMA FROM         tbKasiyer WHERE     (sKasiyerRumuzu <> '') ORDER BY sAdi"))
        ds_kasa = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, nKasaNo AS KOD, sAciklama AS ACIKLAMA FROM         tbParekendeKasa"))
        ds_harekettipi = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, sHareketTipi AS KOD, sAciklama AS ACIKLAMA FROM         tbHareketTipi WHERE     (sHareketTipi <> '') and (aktif = 1)"))
        ds_fistipi = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, sFisTipi AS KOD, sAciklama AS ACIKLAMA FROM         tbFisTipi WHERE     (bSatismi = 1) AND (sFisTipi IN ('CP', 'K', 'KS', 'KVF', 'P', 'PAD', 'PD', 'PTX', 'SK', 'SP'))"))
        ds_SubeMagaza = sorgu(sorgu_query("SELECT     sSubeMagaza, sAciklama  FROM         tbSubeMagaza"))
        sec_sSubeMagaza.Properties.DataSource = ds_SubeMagaza.Tables(0)
        sec_sSubeMagaza.EditValue = sSubeMagaza
        If Trim(sDepo) = "D001" Or Trim(sDepo) = "D002" Or Trim(sDepo) = "D012" Or Trim(sDepo) = "D013" Then
            'sec_depo.EditValue = "'" & sDepo & "'"
            If kullanici > 3 Then
                sec_depo.Properties.ReadOnly = False
            Else
                sec_depo.Properties.ReadOnly = False
            End If
        Else
            If kullanici > 3 Then
                sec_depo.EditValue = "'" & sDepo & "'"
                sec_depo.Properties.ReadOnly = True
            Else
                'sec_sDepo.EditValue = sDepo
                sec_depo.Properties.ReadOnly = False
            End If
            'sec_sDepo.EditValue = sDepo
            'sec_sDepo.Properties.ReadOnly = False
        End If
    End Sub
    Private Sub dataload_depo_pos()
        ds_magaza = sorgu(sorgu_query("SELECT     DISTINCT CAST('0' as bit) AS SEC, sMagazaKodu AS KOD, '' AS ACIKLAMA FROM         BTBLINTERSATIS WHERE sMagazaKodu <> '' and sKullanici = '" & kullanici & "' ORDER BY sMagazaKodu"))
        ds_kasiyer = sorgu(sorgu_query("SELECT     DISTINCT CAST('0' as bit) AS SEC, sKasiyerRumuzu AS KOD, '' AS ACIKLAMA FROM         BTBLINTERSATIS WHERE     (sKasiyerRumuzu <> '') and sKullanici = '" & kullanici & "' ORDER BY sKasiyerRumuzu"))
        ds_kasa = sorgu(sorgu_query("SELECT     DISTINCT CAST('0' as bit) AS SEC, sKasaNo AS KOD, '' AS ACIKLAMA FROM         BTBLINTERSATIS WHERE     (sKasaNo <> '') and sKullanici = '" & kullanici & "' ORDER BY sKasaNo"))
        ds_harekettipi = sorgu(sorgu_query("SELECT     DISTINCT CAST('0' as bit) AS SEC, sHareketTipi AS KOD, sAciklama AS ACIKLAMA FROM         tbHareketTipi WHERE     (sHareketTipi <> '') and (aktif = 1) "))
        ds_fistipi = sorgu(sorgu_query("SELECT     DISTINCT CAST('0' as bit) AS SEC, sFisTipi AS KOD, '' AS ACIKLAMA FROM         BTBLINTERSATIS WHERE     sFisTipi <>'' and sKullanici = '" & kullanici & "' order by sFisTipi"))
    End Sub
    Private Sub dataload_satislar(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String, ByVal saat1 As DateTime, ByVal saat2 As DateTime)
        Dim kriter As String = ""
        kriter = " AND a.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "'"
        If saat1 = "00:00:00" Then
        Else
            kriter = " AND a.dteKayitTarihi BETWEEN '" & tarih1 & " " & saat1 & "' AND '" & tarih2 & " " & saat2 & "'"
        End If
        'MsgBox(saat1 & vbTab & saat2)
        If kasiyer <> "[Tümü]" Then
            If kasatipi = "Kasa:" Then
                kriter += " AND a.nKasaNo IN ( " & kasiyer & " ) "
            ElseIf kasatipi = "Kasiyer:" Then
                kriter += " AND a.sKasiyerRumuzu IN ( " & kasiyer & " ) "
            End If
        End If
        If sMagaza <> "[Tümü]" Then
            kriter += " AND a.sMagaza IN ( " & sMagaza & " )"
        End If
        If harekettipi <> "[Tümü]" Then
            kriter += " AND a.sHareketTipi IN ( " & harekettipi & " )"
        End If
        If fistipi <> "[Tümü]" Then
            kriter += " AND a.sFisTipi IN ( " & fistipi & " )"
        End If
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Aciklama, Bos1, Bos2, Bos3, nGirisCikis, Malbedeli, IskontoTutari, VadeKdvOrani, VadeKdvMatrahi, VadeFarki, KdvTutari, Miktar, KDVMatrahi, NetTutar FROM (SELECT b.sAciklama AS Aciklama , '' AS Bos1 , '' AS Bos2 , '' AS Bos3 , a.nGirisCikis AS nGirisCikis , Malbedeli = CASE WHEN a.sFisTipi = 'CP' THEN SUM(lNetTutar) ELSE SUM(a.lMalBedeli) END , SUM(a.lMalIskontoTutari + a.lDipIskontoTutari) AS IskontoTutari , 0 AS VadeKdvOrani , SUM(a.lVadeKdvMatrahi) AS VadeKdvMatrahi , SUM(a.lVadeFarki) AS VadeFarki , SUM(a.lKdv1 + a.lKdv2 + a.lKdv3 + a.lKdv4 + a.lKdv5 + a.lVadeKdv) AS KdvTutari , SUM(a.lToplamMiktar) AS Miktar , SUM(a.lKdvMatrahi1 + a.lKdvMatrahi2 + a.lKdvMatrahi3 + a.lKdvMatrahi4 + a.lKdvMatrahi5 + a.lVadeKdvMatrahi) AS KDVMatrahi , SUM(a.lNetTutar + a.lVadeFarki) AS NetTutar FROM tbAlisVeris a , tbFisTipi b , tbKasiyer , tbParekendeKasa c WHERE a.sFisTipi = b.sFisTipi AND a.sFisTipi <> 'KA' AND a.sFisTipi <> 'PAD' AND a.nKasaNo = c.nKasaNo AND a.sKasiyerRumuzu = tbKasiyer.sKasiyerRumuzu  " & kriter & " GROUP BY b.sAciklama , a.nGirisCikis , a.sFisTipi UNION ALL SELECT b.sAciklama + ' Toplamý' AS Aciklama , 'Toplam' AS Bos1 , '' AS Bos2 , '' AS Bos3 , 0 AS nGirisCikis , SUM(a.lMalBedeli) AS MalBedeli , SUM(a.lMalIskontoTutari + a.lDipIskontoTutari) AS IskontoTutari , 0 AS VadeKdvOrani , SUM(a.lVadeKdvMatrahi) AS VadeKdvMatrahi , SUM(a.lVadeFarki) AS VadeFarki , SUM(a.lKdv1 + a.lKdv2 + a.lKdv3 + a.lKdv4 + a.lKdv5 + a.lVadeKdv) AS KdvTutari , SUM(a.lToplamMiktar) AS Miktar , SUM(a.lKdvMatrahi1 + a.lKdvMatrahi2 + a.lKdvMatrahi3 + a.lKdvMatrahi4 + a.lKdvMatrahi5 + a.lVadeKdvMatrahi) AS KDVMatrahi , SUM(a.lNetTutar + a.lVadeFarki) AS NetTutar FROM tbAlisVeris a , tbFisTipi b , tbKasiyer , tbParekendeKasa c WHERE a.sFisTipi = b.sFisTipi AND (a.sFisTipi = 'K' OR a.sFisTipi = 'P') AND a.nKasaNo = c.nKasaNo AND a.sKasiyerRumuzu = tbKasiyer.sKasiyerRumuzu " & kriter & " GROUP BY b.sAciklama) temp111 ORDER BY Aciklama, Bos1"))
        Dim dr As DataRow
        Dim dr1 As DataRow
        dr = DataSet1.Tables(0).NewRow
        dr("Sýnýf") = "Baþlýk"
        dr("Aciklama") = "AlýþVeriþ Þekli"
        dr("MIKTAR") = "Adet"
        dr("IZAHAT") = "BelgeTipi"
        dr("col1") = "Brüt Satýþ"
        dr("col2") = "Iskonto"
        dr("col3") = "VadeFarký"
        dr("col4") = "KdvMatrahý"
        dr("col5") = "KdvTutarý"
        dr("col6") = "NetTutar"
        'dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        Dim miktar As Decimal = 0
        Dim col1 As Decimal = 0
        Dim col2 As Decimal = 0
        Dim col3 As Decimal = 0
        Dim col4 As Decimal = 0
        Dim col5 As Decimal = 0
        Dim col6 As Decimal = 0
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Sýnýf") = "Satýþlar"
            dr("Aciklama") = dr1("Aciklama")
            dr("MIKTAR") = FormatNumber(dr1("Miktar"), 2)
            If dr1("nGirisCikis") = 3 Then
                dr("IZAHAT") = "Normal"
            ElseIf dr1("nGirisCikis") = 4 Then
                dr("IZAHAT") = "Iade"
            ElseIf dr1("nGirisCikis") = 0 Then
                dr("IZAHAT") = "Toplam"
            End If
            'dr("IZAHAT") = dr1("nGirisCikis")
            dr("col1") = FormatNumber(dr1("Malbedeli"), 2)
            dr("col2") = FormatNumber(dr1("IskontoTutari"), 2)
            dr("col3") = FormatNumber(dr1("VadeFarki"), 2)
            dr("col4") = FormatNumber(dr1("KDVMatrahi"), 2)
            dr("col5") = FormatNumber(dr1("KdvTutari"), 2)
            dr("col6") = FormatNumber(dr1("NetTutar"), 2)
            dr("Status") = 1
            DataSet1.Tables(0).Rows.Add(dr)
            If dr1("nGirisCikis") <> 0 Then
                miktar += dr("MIKTAR")
                col1 += CType(dr("col1"), Decimal)
                col2 += CType(dr("col2"), Decimal)
                col3 += CType(dr("col3"), Decimal)
                col4 += CType(dr("col4"), Decimal)
                col5 += CType(dr("col5"), Decimal)
                col6 += CType(dr("col6"), Decimal)
            End If
        Next
        dr = DataSet1.Tables(0).NewRow
        dr("Sýnýf") = "Satýþlar"
        dr("Aciklama") = "GenelToplam"
        dr("MIKTAR") = FormatNumber(miktar, 2)
        dr("IZAHAT") = ""
        dr("col1") = FormatNumber(col1, 2)
        dr("col2") = FormatNumber(col2, 2)
        dr("col3") = FormatNumber(col3, 2)
        dr("col4") = FormatNumber(col4, 2)
        dr("col5") = FormatNumber(col5, 2)
        dr("col6") = FormatNumber(col6, 2)
        'dr("col7") = FormatNumber(col7, 0)
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
    End Sub
    Private Sub dataload_satislar_faaliyet(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String)
        Dim kriter_satis As String = ""
        Dim kriter_odeme As String = ""
        kriter_satis = " Where tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "'"
        kriter_odeme = " WHERE (tbOdeme.nOdemeKodu = 2) AND (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') "
        If kasiyer <> "[Tümü]" Then
            If kasatipi = "Kasa:" Then
                kriter_satis += " AND tbAlisVeris.nKasaNo IN ( " & kasiyer & " ) "
                kriter_odeme += " AND tbOdeme.nKasaNo IN ( " & kasiyer & " ) "
            ElseIf kasatipi = "Kasiyer:" Then
                kriter_satis += " AND tbAlisVeris.sKasiyerRumuzu IN ( " & kasiyer & " ) "
                kriter_odeme += " AND tbOdeme.sKasiyerRumuzu IN ( " & kasiyer & " ) "
            End If
        End If
        If sMagaza <> "[Tümü]" Then
            kriter_satis += " AND tbAlisVeris.sMagaza IN ( " & sMagaza & " )"
            kriter_odeme += " AND tbOdeme.sMagaza IN ( " & sMagaza & " )"
        End If
        If harekettipi <> "[Tümü]" Then
            kriter_satis += " AND tbAlisVeris.sHareketTipi IN ( " & harekettipi & " )"
        End If
        If fistipi <> "[Tümü]" Then
            kriter_satis += " AND tbAlisVeris.sFisTipi IN ( " & fistipi & " )"
        End If
        'DataSet1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *,0 AS STATUS FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbAlisVeris.lFaturaNo AS BELGENO , tbAlisVeris.dteFaturaTarihi AS TARIH , tbAlisVeris.lToplamMiktar AS MIKTAR , tbAlisVeris.lNetTutar AS TUTAR , (SELECT ISNULL(SUM(lOdemeTutar) , 0) AS lOdemeTutar FROM (SELECT ISNULL(SUM(lOdemeTutar) , 0) AS lOdemeTutar FROM tbOdeme WHERE (nOdemeKodu = 1) AND (nAlisverisID = tbAlisVeris.nAlisVerisID) UNION ALL SELECT - SUM(lOdemeTutar) AS lOdemeTutar FROM tbOdeme WHERE (nAlisverisID = tbAlisVeris.nAlisVerisID) AND (nOdemeKodu = 3)) Kapatma) AS TAHSILAT,tbAlisVeris.nAlisverisID AS ALISVERISNO , tbAlisVeris.sFisTipi AS IZAHAT , tbAlisVeris.lVadeFarki AS VADEFARKI , tbAlisVeris.sMagaza AS MAGAZA , tbAlisVeris.sKasiyerRumuzu AS KASIYER , tbAlisVeris.nGirisCikis AS GIRIS , tbAlisVeris.sYaziIle AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,tbAlisVeris.dteKayitTarihi AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 as ISTIHBARAT FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID " & kriter_satis & "  AND (tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'SK' OR tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'KVF' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX' OR tbAlisVeris.sFisTipi = 'KS') UNION ALL SELECT nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , SUM(TUTAR) AS TUTAR ,SUM(TAHSILAT) AS TAHSILAT, '0' AS ALISVERISNO , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,KAYIT,SOZLESME,ISTIHBARAT FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbOdeme.lOdemeNo AS BELGENO , tbOdeme.dteOdemeTarihi AS TARIH , 0 AS MIKTAR , 0 AS TUTAR ,SUM(tbOdeme.lOdemeTutar) AS TAHSILAT , tbOdeme.nAlisverisID AS ALISVERISNO , 'OD' AS IZAHAT , 0 AS VADEFARKI , tbOdeme.sMagaza AS MAGAZA , tbOdeme.sKasiyerRumuzu AS KASIYER , 3 AS GIRIS , ' ' AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,MAX(tbOdeme.dteKayitTarihi) AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 as ISTIHBARAT FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbOdeme ON tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID " & kriter_odeme & " GROUP BY tbMusteri.nMusteriID,tbMusteri.lKodu , tbMusteri.sAdi , tbMusteri.sSoyadi , tbOdeme.lOdemeNo , tbOdeme.dteOdemeTarihi , tbOdeme.nAlisverisID , tbOdeme.sMagaza , tbOdeme.sKasiyerRumuzu , tbMusteri.dteDogumTarihi , tbMusteri.dteEvlilikTarihi,tbOdeme.dteKayitTarihi,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 ) TT GROUP BY nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,KAYIT,SOZLESME,ISTIHBARAT) T ORDER BY TARIH,KAYIT"))
        ds_Faaliyet = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *,0 AS STATUS FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbAlisVeris.lFaturaNo AS BELGENO , tbAlisVeris.dteFaturaTarihi AS TARIH , tbAlisVeris.lToplamMiktar AS MIKTAR , tbAlisVeris.lNetTutar AS TUTAR ,tbAlisVeris.lMalIskontoTutari + tbAlisVeris.lDipIskontoTutari AS ISKONTO, (SELECT ISNULL(SUM(lOdemeTutar) , 0) AS lOdemeTutar FROM (SELECT ISNULL(SUM(lOdemeTutar) , 0) AS lOdemeTutar FROM tbOdeme WHERE (nOdemeKodu = 1) AND (nAlisverisID = tbAlisVeris.nAlisVerisID) UNION ALL SELECT - SUM(lOdemeTutar) AS lOdemeTutar FROM tbOdeme WHERE (nAlisverisID = tbAlisVeris.nAlisVerisID) AND (nOdemeKodu = 3)) Kapatma) AS TAHSILAT,(SELECT ISNULL(SUM(tbOdeme.lOdemeTutar) , 0) AS lOdeme FROM tbOdeme INNER JOIN tbOdemeSekli ON tbOdeme.sOdemeSekli = tbOdemeSekli.sOdemeSekli WHERE (tbOdemeSekli.nOdemeTipi = 1) AND (tbOdeme.nOdemeKodu = 1) AND (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND tbOdeme.nAlisVerisID = tbAlisVeris.nAlisVerisID) AS lNakit , (SELECT ISNULL(SUM(tbOdeme.lOdemeTutar) , 0) AS lOdeme FROM tbOdeme INNER JOIN tbOdemeSekli ON tbOdeme.sOdemeSekli = tbOdemeSekli.sOdemeSekli WHERE (tbOdemeSekli.nOdemeTipi = 2) AND (tbOdeme.nOdemeKodu = 1) AND (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND tbOdeme.nAlisVerisID = tbAlisVeris.nAlisVerisID) AS lVisa , (SELECT ISNULL(SUM(tbOdeme.lOdemeTutar) , 0) AS lOdeme FROM tbOdeme INNER JOIN tbOdemeSekli ON tbOdeme.sOdemeSekli = tbOdemeSekli.sOdemeSekli WHERE (tbOdemeSekli.nOdemeTipi NOT IN (1 , 2)) AND (tbOdeme.nOdemeKodu = 1) AND (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND tbOdeme.nAlisVerisID = tbAlisVeris.nAlisVerisID) AS lDiger ,(SELECT ISNULL(-SUM(tbOdeme.lOdemeTutar) , 0) AS lOdeme FROM tbOdeme INNER JOIN tbOdemeSekli ON tbOdeme.sOdemeSekli = tbOdemeSekli.sOdemeSekli WHERE (tbOdemeSekli.nOdemeTipi =1) AND (tbOdeme.nOdemeKodu = 3) AND (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND tbOdeme.nAlisVerisID = tbAlisVeris.nAlisVerisID) AS lTaksit,(SELECT ISNULL(SUM(lTutari), 0) FROM tbTaksit WHERE nAlisVerisID = tbAlisVeris.nAlisverisID) AS lTaksitTutari, (SELECT ISNULL(COUNT(dteTarihi), 0) FROM tbTaksit WHERE nAlisVerisID = tbAlisVeris.nAlisverisID) AS nTaksitSayisi,tbAlisVeris.nAlisverisID AS ALISVERISNO , tbAlisVeris.sFisTipi AS IZAHAT , tbAlisVeris.lVadeFarki AS VADEFARKI , tbAlisVeris.sMagaza AS MAGAZA , tbAlisVeris.sKasiyerRumuzu AS KASIYER , tbAlisVeris.nGirisCikis AS GIRIS , tbAlisVeris.sYaziIle AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,tbAlisVeris.dteKayitTarihi AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 as ISTIHBARAT FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID " & kriter_satis & "  AND (tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'SK' OR tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'KVF' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX' OR tbAlisVeris.sFisTipi = 'KS') UNION ALL SELECT nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , SUM(TUTAR) AS TUTAR ,0 AS ISKONTO,SUM(TAHSILAT) AS TAHSILAT,sum(lNakit) as lNakit,sum(lVisa) as lVisa,sum(lDiger), '0' as lTaksit,'0' AS lTaksitTutari, '0' AS nTaksitSayisi,'0' AS ALISVERISNO , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,KAYIT,SOZLESME,ISTIHBARAT FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbOdeme.lOdemeNo AS BELGENO , tbOdeme.dteOdemeTarihi AS TARIH , 0 AS MIKTAR , 0 AS TUTAR ,SUM(tbOdeme.lOdemeTutar) AS TAHSILAT ,lNakit = CASE WHEN (tbOdemeSekli.nOdemeTipi = 1) AND (tbOdeme.nOdemeKodu = 2) THEN ISNULL(SUM(tbOdeme.lOdemeTutar), 0) ELSE 0 END, lVisa = CASE WHEN (tbOdemeSekli.nOdemeTipi = 2) AND (tbOdeme.nOdemeKodu = 2) THEN ISNULL(SUM(tbOdeme.lOdemeTutar), 0) ELSE 0 END, lDiger = CASE WHEN (tbOdemeSekli.nOdemeTipi NOT IN (1, 2)) AND (tbOdeme.nOdemeKodu = 2) THEN ISNULL(SUM(tbOdeme.lOdemeTutar), 0) ELSE 0 END, tbOdeme.nAlisverisID AS ALISVERISNO , 'OD' AS IZAHAT , 0 AS VADEFARKI , tbOdeme.sMagaza AS MAGAZA , tbOdeme.sKasiyerRumuzu AS KASIYER , 3 AS GIRIS , ' ' AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,MAX(tbOdeme.dteKayitTarihi) AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 as ISTIHBARAT FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbOdeme ON tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID INNER JOIN tbOdemeSekli ON tbOdeme.sOdemeSekli = tbOdemeSekli.sOdemeSekli " & kriter_odeme & " GROUP BY tbMusteri.nMusteriID,tbMusteri.lKodu , tbMusteri.sAdi , tbMusteri.sSoyadi , tbOdeme.lOdemeNo , tbOdeme.dteOdemeTarihi , tbOdeme.nAlisverisID , tbOdeme.sMagaza , tbOdemeSekli.nOdemeTipi, tbOdeme.nOdemeKodu,tbOdeme.sKasiyerRumuzu , tbMusteri.dteDogumTarihi , tbMusteri.dteEvlilikTarihi,tbOdeme.dteKayitTarihi,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 ) TT GROUP BY nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,KAYIT,SOZLESME,ISTIHBARAT) T ORDER BY TARIH,KAYIT"), "tbFaaliyet")
    End Sub
    Private Sub dataload_satislar_karlilik(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String)
        Dim kriter_satis As String = ""
        Dim kriter_odeme As String = ""
        kriter_satis = " Where tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "'"
        kriter_odeme = " WHERE (tbOdeme.nOdemeKodu = 2) AND (tbOdeme.dteOdemeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') "
        If kasiyer <> "[Tümü]" Then
            If kasatipi = "Kasa:" Then
                kriter_satis += " AND tbAlisVeris.nKasaNo IN ( " & kasiyer & " ) "
                kriter_odeme += " AND tbOdeme.nKasaNo IN ( " & kasiyer & " ) "
            ElseIf kasatipi = "Kasiyer:" Then
                kriter_satis += " AND tbAlisVeris.sKasiyerRumuzu IN ( " & kasiyer & " ) "
                kriter_odeme += " AND tbOdeme.sKasiyerRumuzu IN ( " & kasiyer & " ) "
            End If
        End If
        If sMagaza <> "[Tümü]" Then
            kriter_satis += " AND tbAlisVeris.sMagaza IN ( " & sMagaza & " )"
            kriter_odeme += " AND tbOdeme.sMagaza IN ( " & sMagaza & " )"
        End If
        If harekettipi <> "[Tümü]" Then
            kriter_satis += " AND tbAlisVeris.sHareketTipi IN ( " & harekettipi & " )"
        End If
        If fistipi <> "[Tümü]" Then
            kriter_satis += " AND tbAlisVeris.sFisTipi IN ( " & fistipi & " )"
        End If
        'DataSet1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *,0 AS STATUS FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbAlisVeris.lFaturaNo AS BELGENO , tbAlisVeris.dteFaturaTarihi AS TARIH , tbAlisVeris.lToplamMiktar AS MIKTAR , tbAlisVeris.lNetTutar AS TUTAR , (SELECT ISNULL(SUM(lOdemeTutar) , 0) AS lOdemeTutar FROM (SELECT ISNULL(SUM(lOdemeTutar) , 0) AS lOdemeTutar FROM tbOdeme WHERE (nOdemeKodu = 1) AND (nAlisverisID = tbAlisVeris.nAlisVerisID) UNION ALL SELECT - SUM(lOdemeTutar) AS lOdemeTutar FROM tbOdeme WHERE (nAlisverisID = tbAlisVeris.nAlisVerisID) AND (nOdemeKodu = 3)) Kapatma) AS TAHSILAT,tbAlisVeris.nAlisverisID AS ALISVERISNO , tbAlisVeris.sFisTipi AS IZAHAT , tbAlisVeris.lVadeFarki AS VADEFARKI , tbAlisVeris.sMagaza AS MAGAZA , tbAlisVeris.sKasiyerRumuzu AS KASIYER , tbAlisVeris.nGirisCikis AS GIRIS , tbAlisVeris.sYaziIle AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,tbAlisVeris.dteKayitTarihi AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 as ISTIHBARAT FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID " & kriter_satis & "  AND (tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'SK' OR tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'KVF' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX' OR tbAlisVeris.sFisTipi = 'KS') UNION ALL SELECT nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , SUM(TUTAR) AS TUTAR ,SUM(TAHSILAT) AS TAHSILAT, '0' AS ALISVERISNO , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,KAYIT,SOZLESME,ISTIHBARAT FROM (SELECT tbMusteri.nMusteriID,tbMusteri.lKodu AS FIRMAKODU , tbMusteri.sAdi AS ADI , tbMusteri.sSoyadi AS SOYADI , tbOdeme.lOdemeNo AS BELGENO , tbOdeme.dteOdemeTarihi AS TARIH , 0 AS MIKTAR , 0 AS TUTAR ,SUM(tbOdeme.lOdemeTutar) AS TAHSILAT , tbOdeme.nAlisverisID AS ALISVERISNO , 'OD' AS IZAHAT , 0 AS VADEFARKI , tbOdeme.sMagaza AS MAGAZA , tbOdeme.sKasiyerRumuzu AS KASIYER , 3 AS GIRIS , ' ' AS YAZI , tbMusteri.dteDogumTarihi AS DOGUMTARIHI , tbMusteri.dteEvlilikTarihi AS EVLILIKTARIHI,MAX(tbOdeme.dteKayitTarihi) AS KAYIT,(SELECT     TOP 1 nKartNo FROM          tbMusteriKarti WHERE      nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 as ISTIHBARAT FROM tbAlisVeris INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbOdeme ON tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID " & kriter_odeme & " GROUP BY tbMusteri.nMusteriID,tbMusteri.lKodu , tbMusteri.sAdi , tbMusteri.sSoyadi , tbOdeme.lOdemeNo , tbOdeme.dteOdemeTarihi , tbOdeme.nAlisverisID , tbOdeme.sMagaza , tbOdeme.sKasiyerRumuzu , tbMusteri.dteDogumTarihi , tbMusteri.dteEvlilikTarihi,tbOdeme.dteKayitTarihi,tbMusteri.sAciklama1+ ' '+tbMusteri.sAciklama2 + ' '+ tbMusteri.sAciklama3 + ' '+ tbMusteri.sAciklama4 + ' '+ tbMusteri.sAciklama5 ) TT GROUP BY nMusteriID,FIRMAKODU , ADI , SOYADI , BELGENO , TARIH , MIKTAR , IZAHAT , VADEFARKI , MAGAZA , KASIYER , GIRIS , YAZI , DOGUMTARIHI , EVLILIKTARIHI,KAYIT,SOZLESME,ISTIHBARAT) T ORDER BY TARIH,KAYIT"))
        ds_SatisKarlilik = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , tbMusteri.lKodu AS lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih , tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo ,tbAlisVeris.lNetTutar as lGenelToplam, tbStok.nStokID , tbStok.sKodu AS sKodu , tbStok.sModel,tbStok.sAciklama AS sStokAciklama , ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar , ISNULL(tbStokFisiDetayi.lBrutFiyat , 0) AS Fiyat , ISNULL(tbStokFisiDetayi.lIskontoTutari , 0) AS Iskonto , tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar , tbStokFisiDetayi.sOdemeKodu , tbStokFisiDetayi.sFiyatTipi , tbStokFisiDetayi.sSaticiRumuzu , tbStokFisiDetayi.sKasiyerRumuzu , tbStokFisiDetayi.nGirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk,tbStok.sBeden,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET,tbStokFisiDetayi.lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1,CAST(0 AS MONEY) AS KAR,CAST(0 AS MONEY) AS FARK,CAST(0 AS MONEY) AS FIYATFARKI,CAST(0 AS MONEY) AS NORMALFIYAT,CAST(0 AS MONEY) AS NORMALTUTAR,(SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE  (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID and tbStokFisiDetayi.dteFisTarihi < = tbAlisVeris.dteFaturaTarihi   ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM tbStok RIGHT OUTER JOIN tbMusteri INNER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID LEFT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID " & kriter_satis & " AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX')  UNION ALL SELECT tbAlisVeris.nAlisverisID , tbMusteri.nMusteriID , tbMusteri.lKodu , tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi , tbAlisVeris.dteFaturaTarihi AS dteTarih , tbAlisVeris.sFisTipi AS fisTipi , tbAlisVeris.lFaturaNo AS lNo , tbAlisVeris.lNetTutar as lGenelToplam,tbStok.nStokID , tbStok.sKodu , tbStok.sModel,tbStok.sAciklama AS sStokAciklama , tbAlisverisSiparis.lGCMiktar AS Miktar , tbAlisverisSiparis.lBrutFiyat AS Fiyat , tbAlisverisSiparis.lIskontoTutari AS Iskonto , tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar , tbAlisverisSiparis.sOdemeKodu , tbAlisverisSiparis.sFiyatTipi , tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu , tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu , tbAlisverisSiparis.nGirisCikis AS GirisCikis , tbAlisVeris.sMagaza , tbStok.sRenk,tbStok.sBeden,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, CAST(0 AS MONEY) lMaliyetFiyat,CAST(0 AS MONEY) AS ORAN1,CAST(0 AS MONEY) AS KAR,CAST(0 AS MONEY) AS FARK,CAST(0 AS MONEY) AS FIYATFARKI,CAST(0 AS MONEY) AS NORMALFIYAT,CAST(0 AS MONEY) AS NORMALTUTAR,(SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID and tbStokFisiDetayi.dteFisTarihi < = tbAlisVeris.dteFaturaTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID " & kriter_satis & "  ) t ORDER BY dteTarih,lNo"), "tbSatisKarlilik")
        Dim dr As DataRow
        Dim netmaliyet As Decimal = 0
        Dim normalfiyat As Decimal = 0
        Dim fiyattipi As String = ""
        Dim MaliyetTipi As Integer = 0
        For Each dr In ds_SatisKarlilik.Tables(0).Rows
            If dr("sKodu").ToString <> "" Then
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
                dr("MALIYET") = netmaliyet
                Try
                    dr("ORAN1") = ((dr("lNetTutar") - (netmaliyet)) / netmaliyet)
                    dr("KAR") = dr("lNetTutar") - (netmaliyet)
                Catch ex As Exception
                    dr("ORAN1") = 0
                    dr("KAR") = dr("lNetTutar") - (netmaliyet)
                End Try
                If dr("nGirisCikis") <> 5 Then
                    If Trim(dr("sFiyatTipi").ToString) <> "HD" Then
                        fiyattipi = Trim(dr("sFiyatTipi").ToString)
                        If fiyattipi = Trim(sFiyat3) Then
                            If Math.Abs(dr("Fiyat")) <> sorgu_sayi(dr("ONAY"), 0) Then
                                dr("NORMALFIYAT") = sorgu_sayi(dr("ONAY"), 0)
                                dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                                normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                                dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR")
                                dr("FIYATFARKI") = dr("Fiyat") - normalfiyat
                            End If
                        ElseIf fiyattipi = Trim(sFiyat2) Then
                            If Math.Abs(dr("Fiyat")) <> sorgu_sayi(dr("ALTIAY"), 0) Then
                                dr("NORMALFIYAT") = sorgu_sayi(dr("ALTIAY"), 0)
                                dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                                normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                                dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR")
                                dr("FIYATFARKI") = dr("Fiyat") - normalfiyat
                            End If
                        ElseIf fiyattipi = Trim(sFiyat1) Then
                            If Math.Abs(dr("Fiyat")) <> sorgu_sayi(dr("PESIN"), 0) Then
                                dr("NORMALFIYAT") = sorgu_sayi(dr("PESIN"), 0)
                                dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                                normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                                dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR")
                                dr("FIYATFARKI") = dr("Fiyat") - normalfiyat
                            End If
                        End If
                    Else
                        'fiyattipi = Trim(dr("sFiyatTipi").ToString)
                        If fiyattipi = Trim(sFiyat3) Then
                            dr("NORMALFIYAT") = sorgu_sayi(dr("ONAY"), 0)
                            dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                            dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR") + 0.01
                            dr("FIYATFARKI") = (dr("Fiyat") - normalfiyat) + +0.01
                        ElseIf fiyattipi = Trim(sFiyat2) Then
                            dr("NORMALFIYAT") = sorgu_sayi(dr("ALTIAY"), 0)
                            dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                            dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR") + 0.01
                            dr("FIYATFARKI") = (dr("Fiyat") - normalfiyat) + 0.01
                        ElseIf fiyattipi = Trim(sFiyat1) Then
                            dr("NORMALFIYAT") = sorgu_sayi(dr("PESIN"), 0)
                            dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                            dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR") + 0.01
                            dr("FIYATFARKI") = (dr("Fiyat") - normalfiyat) + 0.01
                        End If
                    End If
                End If
            End If
        Next
        dr = Nothing
    End Sub
    Private Sub dataload_satislar_pos(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String, Optional ByVal nPosIslem As Integer = 3)
        Dim kriter As String = ""
        kriter = " AND a.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "'"
        If kasiyer <> "[Tümü]" Then
            If kasatipi = "Kasa:" Then
                kriter += " AND a.sKasaNo IN ( " & kasiyer & " ) "
            ElseIf kasatipi = "Kasiyer:" Then
                kriter += " AND a.sKasiyerRumuzu IN ( " & kasiyer & " ) "
            End If
        End If
        If sMagaza <> "[Tümü]" Then
            kriter += " AND a.sMagazaKodu IN ( " & sMagaza & " )"
        End If
        'If harekettipi <> "[Tümü]" Then
        '    kriter += " AND a.sHareketTipi IN ( " & harekettipi & " )"
        'End If
        If fistipi <> "[Tümü]" Then
            kriter += " AND a.sFisTipi IN ( " & fistipi & " )"
        End If
        kriter += " and a.sKullanici = '" & kullanici & "'"
        If nPosIslem = 3 Then
            ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Aciklama, nKayit,bKapali,Bos1, Bos2, Bos3, nGirisCikis,bKapali, Malbedeli, IskontoTutari, VadeKdvOrani, VadeKdvMatrahi, VadeFarki, KdvTutari, Miktar, KDVMatrahi, NetTutar FROM (SELECT b.sAciklama AS Aciklama ,COUNT(DISTINCT lFisNo) AS nKayit,a.bKapali, '' AS Bos1 , '' AS Bos2 , '' AS Bos3 , 3 AS nGirisCikis ,SUM(a.lBrutTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS Malbedeli , SUM(a.lIskontoTutari) AS IskontoTutari , 0 AS VadeKdvOrani , 0 AS VadeKdvMatrahi , 0 AS VadeFarki , SUM(a.lTutar) - SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KdvTutari , SUM(a.lMiktar) AS Miktar , SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KDVMatrahi , SUM(a.lTutar) AS NetTutar FROM BTBLINTERSATIS a INNER JOIN tbFisTipi b ON a.sFisTipi = b.sFisTipi INNER JOIN tbKdv ON a.sKdvTipi = tbKdv.sKdvTipi  WHERE (a.nGirisCikis < 6) AND (a.nStatus = 0) " & kriter & " GROUP BY b.sAciklama,a.bKapali UNION ALL SELECT b.sAciklama + ' Toplamý' AS Aciklama ,COUNT(DISTINCT lFisNo) AS nKayit, 1 as bKapali,'Toplam' AS Bos1 , '' AS Bos2 , '' AS Bos3 , 0 AS nGirisCikis , SUM(a.lBrutTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS Malbedeli , SUM(a.lIskontoTutari) AS IskontoTutari , 0 AS VadeKdvOrani , 0 AS VadeKdvMatrahi , 0 AS VadeFarki , SUM(a.lTutar) - SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KdvTutari , SUM(a.lMiktar) AS Miktar , SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KDVMatrahi , SUM(a.lTutar) AS NetTutar FROM BTBLINTERSATIS a INNER JOIN tbFisTipi b ON a.sFisTipi = b.sFisTipi INNER JOIN tbKdv ON a.sKdvTipi = tbKdv.sKdvTipi WHERE (a.nGirisCikis < 6) AND (a.nStatus = 0) " & kriter & " GROUP BY b.sAciklama) temp111 ORDER BY Aciklama, Bos1"))
        ElseIf nPosIslem = 4 Then
            'ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Aciklama,sKod,nKayit,bKapali,Bos1, Bos2, Bos3, nGirisCikis, Malbedeli, IskontoTutari, VadeKdvOrani, VadeKdvMatrahi, VadeFarki, KdvTutari, Miktar, KDVMatrahi, NetTutar FROM (SELECT b.sAciklama AS Aciklama ,a.sKdvTipi AS sKod, Count(DISTINCT lFisNo) as nKayit,Yekun.bKapali,'' AS Bos1 , '' AS Bos2 , '' AS Bos3 , 3 AS nGirisCikis , SUM(a.lBrutTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS Malbedeli , SUM(a.lIskontoTutari) AS IskontoTutari , 0 AS VadeKdvOrani , 0 AS VadeKdvMatrahi , 0 AS VadeFarki , SUM(a.lTutar) - SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KdvTutari , SUM(a.lMiktar) AS Miktar , SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KDVMatrahi , SUM(a.lTutar) AS NetTutar FROM BTBLINTERSATIS a INNER JOIN tbFisTipi b ON a.sFisTipi = b.sFisTipi INNER JOIN tbKdv ON a.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT nAlisVerisID , sFisTipi , lFisNo as FisNo , dteKayitTarihi , nMusteriID , bKapali , sKullanici FROM BTBLINTERSATIS WHERE nGirisCikis = 11 AND sKullanici = '" & kullanici & "') Yekun ON a.nAlisVerisID = Yekun.nAlisVerisID AND a.sFisTipi = Yekun.sFisTipi AND a.lFisNo = Yekun.FisNo AND a.dteKayitTarihi = Yekun.dteKayitTarihi WHERE (a.nGirisCikis < 6) AND (a.nStatus = 0) " & kriter & " GROUP BY b.sAciklama,a.sKdvTipi,Yekun.bKapali UNION ALL SELECT b.sAciklama + ' Toplamý' AS Aciklama ,'' sKod, Count(DISTINCT lFisNo) as nKayit,1 as bKapali,'Toplam' AS Bos1 , '' AS Bos2 , '' AS Bos3 , 0 AS nGirisCikis , SUM(a.lBrutTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS Malbedeli , SUM(a.lIskontoTutari) AS IskontoTutari , 0 AS VadeKdvOrani , 0 AS VadeKdvMatrahi , 0 AS VadeFarki , SUM(a.lTutar) - SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KdvTutari , SUM(a.lMiktar) AS Miktar , SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KDVMatrahi , SUM(a.lTutar) AS NetTutar FROM BTBLINTERSATIS a INNER JOIN tbFisTipi b ON a.sFisTipi = b.sFisTipi INNER JOIN tbKdv ON a.sKdvTipi = tbKdv.sKdvTipi WHERE (a.nGirisCikis < 6) AND (a.nStatus = 0) " & kriter & " GROUP BY b.sAciklama) temp111 ORDER BY Aciklama, Bos1"))
            ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Aciklama,sKod,nKayit,bKapali,Bos1, Bos2, Bos3, nGirisCikis, Malbedeli, IskontoTutari, VadeKdvOrani, VadeKdvMatrahi, VadeFarki, KdvTutari, Miktar, KDVMatrahi, NetTutar FROM (SELECT b.sAciklama AS Aciklama ,a.sKdvTipi AS sKod, Count(DISTINCT lFisNo) as nKayit,1 as bKapali,'' AS Bos1 , '' AS Bos2 , '' AS Bos3 , 3 AS nGirisCikis , SUM(a.lBrutTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS Malbedeli , SUM(a.lIskontoTutari) AS IskontoTutari , 0 AS VadeKdvOrani , 0 AS VadeKdvMatrahi , 0 AS VadeFarki , SUM(a.lTutar) - SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KdvTutari , SUM(a.lMiktar) AS Miktar , SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KDVMatrahi , SUM(a.lTutar) AS NetTutar FROM BTBLINTERSATIS a INNER JOIN tbFisTipi b ON a.sFisTipi = b.sFisTipi INNER JOIN tbKdv ON a.sKdvTipi = tbKdv.sKdvTipi  WHERE (a.nGirisCikis < 6) AND (a.nStatus = 0) " & kriter & " GROUP BY b.sAciklama,a.sKdvTipi UNION ALL SELECT b.sAciklama + ' Toplamý' AS Aciklama ,'' sKod, Count(DISTINCT lFisNo) as nKayit,1 as bKapali,'Toplam' AS Bos1 , '' AS Bos2 , '' AS Bos3 , 0 AS nGirisCikis , SUM(a.lBrutTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS Malbedeli , SUM(a.lIskontoTutari) AS IskontoTutari , 0 AS VadeKdvOrani , 0 AS VadeKdvMatrahi , 0 AS VadeFarki , SUM(a.lTutar) - SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KdvTutari , SUM(a.lMiktar) AS Miktar , SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KDVMatrahi , SUM(a.lTutar) AS NetTutar FROM BTBLINTERSATIS a INNER JOIN tbFisTipi b ON a.sFisTipi = b.sFisTipi INNER JOIN tbKdv ON a.sKdvTipi = tbKdv.sKdvTipi WHERE (a.nGirisCikis < 6) AND (a.nStatus = 0) " & kriter & " GROUP BY b.sAciklama) temp111 ORDER BY Aciklama, sKod"))
        ElseIf nPosIslem = 5 Then
            'ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Aciklama,sKod,nKayit,bKapali,Bos1, Bos2, Bos3, nGirisCikis, Malbedeli, IskontoTutari, VadeKdvOrani, VadeKdvMatrahi, VadeFarki, KdvTutari, Miktar, KDVMatrahi, NetTutar FROM (SELECT b.sAciklama AS Aciklama ,DATEPART(HH, a.dteKayitTarihi) AS sKod, Count(DISTINCT lFisNo) as nKayit,Yekun.bKapali,'' AS Bos1 , '' AS Bos2 , '' AS Bos3 , 3 AS nGirisCikis , SUM(a.lBrutTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS Malbedeli , SUM(a.lIskontoTutari) AS IskontoTutari , 0 AS VadeKdvOrani , 0 AS VadeKdvMatrahi , 0 AS VadeFarki , SUM(a.lTutar) - SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KdvTutari , SUM(a.lMiktar) AS Miktar , SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KDVMatrahi , SUM(a.lTutar) AS NetTutar FROM BTBLINTERSATIS a INNER JOIN tbFisTipi b ON a.sFisTipi = b.sFisTipi INNER JOIN tbKdv ON a.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT nAlisVerisID , sFisTipi , lFisNo as FisNo , dteKayitTarihi , nMusteriID , bKapali , sKullanici FROM BTBLINTERSATIS WHERE nGirisCikis = 11 AND sKullanici = '" & kullanici & "') Yekun ON a.nAlisVerisID = Yekun.nAlisVerisID AND a.sFisTipi = Yekun.sFisTipi AND a.lFisNo = Yekun.FisNo AND a.dteKayitTarihi = Yekun.dteKayitTarihi WHERE (a.nGirisCikis < 6) AND (a.nStatus = 0) " & kriter & " GROUP BY b.sAciklama,DATEPART(HH, a.dteKayitTarihi) UNION ALL SELECT b.sAciklama + ' Toplamý' AS Aciklama ,'' sKod,Count(DISTINCT lFisNo) as nKayit, 1 as bKapali,'Toplam' AS Bos1 , '' AS Bos2 , '' AS Bos3 , 0 AS nGirisCikis , SUM(a.lBrutTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS Malbedeli , SUM(a.lIskontoTutari) AS IskontoTutari , 0 AS VadeKdvOrani , 0 AS VadeKdvMatrahi , 0 AS VadeFarki , SUM(a.lTutar) - SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KdvTutari , SUM(a.lMiktar) AS Miktar , SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KDVMatrahi , SUM(a.lTutar) AS NetTutar FROM BTBLINTERSATIS a INNER JOIN tbFisTipi b ON a.sFisTipi = b.sFisTipi INNER JOIN tbKdv ON a.sKdvTipi = tbKdv.sKdvTipi WHERE (a.nGirisCikis < 6) AND (a.nStatus = 0) " & kriter & " GROUP BY b.sAciklama) temp111 ORDER BY Aciklama, Bos1"))
            ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Aciklama,sKod,nKayit,bKapali,Bos1, Bos2, Bos3, nGirisCikis, Malbedeli, IskontoTutari, VadeKdvOrani, VadeKdvMatrahi, VadeFarki, KdvTutari, Miktar, KDVMatrahi, NetTutar FROM (SELECT b.sAciklama AS Aciklama ,DATEPART(HH, a.dteKayitTarihi) AS sKod, Count(DISTINCT lFisNo) as nKayit,a.bKapali,'' AS Bos1 , '' AS Bos2 , '' AS Bos3 , 3 AS nGirisCikis , SUM(a.lBrutTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS Malbedeli , SUM(a.lIskontoTutari) AS IskontoTutari , 0 AS VadeKdvOrani , 0 AS VadeKdvMatrahi , 0 AS VadeFarki , SUM(a.lTutar) - SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KdvTutari , SUM(a.lMiktar) AS Miktar , SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KDVMatrahi , SUM(a.lTutar) AS NetTutar FROM BTBLINTERSATIS a INNER JOIN tbFisTipi b ON a.sFisTipi = b.sFisTipi INNER JOIN tbKdv ON a.sKdvTipi = tbKdv.sKdvTipi  WHERE (a.nGirisCikis < 6) AND (a.nStatus = 0) " & kriter & " GROUP BY b.sAciklama,DATEPART(HH, a.dteKayitTarihi),a.bKapali UNION ALL SELECT b.sAciklama + ' Toplamý' AS Aciklama ,'' sKod,Count(DISTINCT lFisNo) as nKayit, 1 as bKapali,'Toplam' AS Bos1 , '' AS Bos2 , '' AS Bos3 , 0 AS nGirisCikis , SUM(a.lBrutTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS Malbedeli , SUM(a.lIskontoTutari) AS IskontoTutari , 0 AS VadeKdvOrani , 0 AS VadeKdvMatrahi , 0 AS VadeFarki , SUM(a.lTutar) - SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KdvTutari , SUM(a.lMiktar) AS Miktar , SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KDVMatrahi , SUM(a.lTutar) AS NetTutar FROM BTBLINTERSATIS a INNER JOIN tbFisTipi b ON a.sFisTipi = b.sFisTipi INNER JOIN tbKdv ON a.sKdvTipi = tbKdv.sKdvTipi WHERE (a.nGirisCikis < 6) AND (a.nStatus = 0) " & kriter & " GROUP BY b.sAciklama) temp111 ORDER BY Aciklama, sKod"))
        ElseIf nPosIslem = 6 Then
            'ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Aciklama,sKod,nKayit,bKapali,Bos1, Bos2, Bos3, nGirisCikis, Malbedeli, IskontoTutari, VadeKdvOrani, VadeKdvMatrahi, VadeFarki, KdvTutari, Miktar, KDVMatrahi, NetTutar FROM (SELECT b.sAciklama AS Aciklama ,a.sKasiyerRumuzu as sKod,Count(DISTINCT lFisNo) as nKayit, Yekun.bKapali,'' AS Bos1 , '' AS Bos2 , '' AS Bos3 , 3 AS nGirisCikis , SUM(a.lBrutTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS Malbedeli , SUM(a.lIskontoTutari) AS IskontoTutari , 0 AS VadeKdvOrani , 0 AS VadeKdvMatrahi , 0 AS VadeFarki , SUM(a.lTutar) - SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KdvTutari , SUM(a.lMiktar) AS Miktar , SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KDVMatrahi , SUM(a.lTutar) AS NetTutar FROM BTBLINTERSATIS a INNER JOIN tbFisTipi b ON a.sFisTipi = b.sFisTipi INNER JOIN tbKdv ON a.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT nAlisVerisID , sFisTipi , lFisNo as FisNo , dteKayitTarihi , nMusteriID , bKapali , sKullanici FROM BTBLINTERSATIS WHERE nGirisCikis = 11 AND sKullanici = '" & kullanici & "') Yekun ON a.nAlisVerisID = Yekun.nAlisVerisID AND a.sFisTipi = Yekun.sFisTipi AND a.lFisNo = Yekun.FisNo AND a.dteKayitTarihi = Yekun.dteKayitTarihi WHERE (a.nGirisCikis < 6) AND (a.nStatus = 0) " & kriter & " GROUP BY b.sAciklama,a.sKasiyerRumuzu,Yekun.bKapali UNION ALL SELECT b.sAciklama + ' Toplamý' AS Aciklama , '' sKod,Count(DISTINCT lFisNo) as nKayit,1 as bKapali,'Toplam' AS Bos1 , '' AS Bos2 , '' AS Bos3 , 0 AS nGirisCikis , SUM(a.lBrutTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS Malbedeli , SUM(a.lIskontoTutari) AS IskontoTutari , 0 AS VadeKdvOrani , 0 AS VadeKdvMatrahi , 0 AS VadeFarki , SUM(a.lTutar) - SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KdvTutari , SUM(a.lMiktar) AS Miktar , SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KDVMatrahi , SUM(a.lTutar) AS NetTutar FROM BTBLINTERSATIS a INNER JOIN tbFisTipi b ON a.sFisTipi = b.sFisTipi INNER JOIN tbKdv ON a.sKdvTipi = tbKdv.sKdvTipi WHERE (a.nGirisCikis < 6) AND (a.nStatus = 0) " & kriter & " GROUP BY b.sAciklama) temp111 ORDER BY Aciklama, Bos1"))
            ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Aciklama,sKod,nKayit,bKapali,Bos1, Bos2, Bos3, nGirisCikis, Malbedeli, IskontoTutari, VadeKdvOrani, VadeKdvMatrahi, VadeFarki, KdvTutari, Miktar, KDVMatrahi, NetTutar FROM (SELECT b.sAciklama AS Aciklama ,a.sKasiyerRumuzu as sKod,Count(DISTINCT lFisNo) as nKayit, 1 as bKapali,'' AS Bos1 , '' AS Bos2 , '' AS Bos3 , 3 AS nGirisCikis , SUM(a.lBrutTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS Malbedeli , SUM(a.lIskontoTutari) AS IskontoTutari , 0 AS VadeKdvOrani , 0 AS VadeKdvMatrahi , 0 AS VadeFarki , SUM(a.lTutar) - SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KdvTutari , SUM(a.lMiktar) AS Miktar , SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KDVMatrahi , SUM(a.lTutar) AS NetTutar FROM BTBLINTERSATIS a INNER JOIN tbFisTipi b ON a.sFisTipi = b.sFisTipi INNER JOIN tbKdv ON a.sKdvTipi = tbKdv.sKdvTipi  WHERE (a.nGirisCikis < 6) AND (a.nStatus = 0) " & kriter & " GROUP BY b.sAciklama,a.sKasiyerRumuzu UNION ALL SELECT b.sAciklama + ' Toplamý' AS Aciklama , '' sKod,Count(DISTINCT lFisNo) as nKayit,1 as bKapali,'Toplam' AS Bos1 , '' AS Bos2 , '' AS Bos3 , 0 AS nGirisCikis , SUM(a.lBrutTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS Malbedeli , SUM(a.lIskontoTutari) AS IskontoTutari , 0 AS VadeKdvOrani , 0 AS VadeKdvMatrahi , 0 AS VadeFarki , SUM(a.lTutar) - SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KdvTutari , SUM(a.lMiktar) AS Miktar , SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KDVMatrahi , SUM(a.lTutar) AS NetTutar FROM BTBLINTERSATIS a INNER JOIN tbFisTipi b ON a.sFisTipi = b.sFisTipi INNER JOIN tbKdv ON a.sKdvTipi = tbKdv.sKdvTipi WHERE (a.nGirisCikis < 6) AND (a.nStatus = 0) " & kriter & " GROUP BY b.sAciklama) temp111 ORDER BY Aciklama, sKod"))
        ElseIf nPosIslem = 7 Then
            'ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Aciklama,sKod,nKayit,bKapali,Bos1, Bos2, Bos3, nGirisCikis, Malbedeli, IskontoTutari, VadeKdvOrani, VadeKdvMatrahi, VadeFarki, KdvTutari, Miktar, KDVMatrahi, NetTutar FROM (SELECT b.sAciklama AS Aciklama , a.sKasaNo as sKod,Count(DISTINCT lFisNo) as nKayit,Yekun.bKapali,'' AS Bos1 , '' AS Bos2 , '' AS Bos3 , 3 AS nGirisCikis , SUM(a.lBrutTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS Malbedeli , SUM(a.lIskontoTutari) AS IskontoTutari , 0 AS VadeKdvOrani , 0 AS VadeKdvMatrahi , 0 AS VadeFarki , SUM(a.lTutar) - SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KdvTutari , SUM(a.lMiktar) AS Miktar , SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KDVMatrahi , SUM(a.lTutar) AS NetTutar FROM BTBLINTERSATIS a INNER JOIN tbFisTipi b ON a.sFisTipi = b.sFisTipi INNER JOIN tbKdv ON a.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT nAlisVerisID , sFisTipi , lFisNo as FisNo , dteKayitTarihi , nMusteriID , bKapali , sKullanici FROM BTBLINTERSATIS WHERE nGirisCikis = 11 AND sKullanici = '" & kullanici & "') Yekun ON a.nAlisVerisID = Yekun.nAlisVerisID AND a.sFisTipi = Yekun.sFisTipi AND a.lFisNo = Yekun.FisNo AND a.dteKayitTarihi = Yekun.dteKayitTarihi WHERE (a.nGirisCikis < 6) AND (a.nStatus = 0) " & kriter & " GROUP BY b.sAciklama,a.sKasaNo,Yekun.bKapali UNION ALL SELECT b.sAciklama + ' Toplamý' AS Aciklama , '' sKod,Count(DISTINCT lFisNo) as nKayit,1 as bKapali,'Toplam' AS Bos1 , '' AS Bos2 , '' AS Bos3 , 0 AS nGirisCikis , SUM(a.lBrutTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS Malbedeli , SUM(a.lIskontoTutari) AS IskontoTutari , 0 AS VadeKdvOrani , 0 AS VadeKdvMatrahi , 0 AS VadeFarki , SUM(a.lTutar) - SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KdvTutari , SUM(a.lMiktar) AS Miktar , SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KDVMatrahi , SUM(a.lTutar) AS NetTutar FROM BTBLINTERSATIS a INNER JOIN tbFisTipi b ON a.sFisTipi = b.sFisTipi INNER JOIN tbKdv ON a.sKdvTipi = tbKdv.sKdvTipi WHERE (a.nGirisCikis < 6) AND (a.nStatus = 0) " & kriter & " GROUP BY b.sAciklama) temp111 ORDER BY Aciklama, Bos1"))
            ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Aciklama,sKod,nKayit,bKapali,Bos1, Bos2, Bos3, nGirisCikis, Malbedeli, IskontoTutari, VadeKdvOrani, VadeKdvMatrahi, VadeFarki, KdvTutari, Miktar, KDVMatrahi, NetTutar FROM (SELECT b.sAciklama AS Aciklama , a.sKasaNo as sKod,Count(DISTINCT lFisNo) as nKayit,1 as bKapali,'' AS Bos1 , '' AS Bos2 , '' AS Bos3 , 3 AS nGirisCikis , SUM(a.lBrutTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS Malbedeli , SUM(a.lIskontoTutari) AS IskontoTutari , 0 AS VadeKdvOrani , 0 AS VadeKdvMatrahi , 0 AS VadeFarki , SUM(a.lTutar) - SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KdvTutari , SUM(a.lMiktar) AS Miktar , SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KDVMatrahi , SUM(a.lTutar) AS NetTutar FROM BTBLINTERSATIS a INNER JOIN tbFisTipi b ON a.sFisTipi = b.sFisTipi INNER JOIN tbKdv ON a.sKdvTipi = tbKdv.sKdvTipi WHERE (a.nGirisCikis < 6) AND (a.nStatus = 0) " & kriter & " GROUP BY b.sAciklama,a.sKasaNo UNION ALL SELECT b.sAciklama + ' Toplamý' AS Aciklama , '' sKod,Count(DISTINCT lFisNo) as nKayit,1 as bKapali,'Toplam' AS Bos1 , '' AS Bos2 , '' AS Bos3 , 0 AS nGirisCikis , SUM(a.lBrutTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS Malbedeli , SUM(a.lIskontoTutari) AS IskontoTutari , 0 AS VadeKdvOrani , 0 AS VadeKdvMatrahi , 0 AS VadeFarki , SUM(a.lTutar) - SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KdvTutari , SUM(a.lMiktar) AS Miktar , SUM(a.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS KDVMatrahi , SUM(a.lTutar) AS NetTutar FROM BTBLINTERSATIS a INNER JOIN tbFisTipi b ON a.sFisTipi = b.sFisTipi INNER JOIN tbKdv ON a.sKdvTipi = tbKdv.sKdvTipi WHERE (a.nGirisCikis < 6) AND (a.nStatus = 0) " & kriter & " GROUP BY b.sAciklama) temp111 ORDER BY Aciklama, sKod"))
        End If
        Dim dr As DataRow
        Dim dr1 As DataRow
        dr = DataSet1.Tables(0).NewRow
        dr("Sýnýf") = "Baþlýk"
        dr("Aciklama") = "AlýþVeriþ Þekli"
        dr("MIKTAR") = "Adet"
        If nPosIslem = 3 Then
            dr("IZAHAT") = "BelgeTipi"
        ElseIf nPosIslem = 4 Then
            dr("IZAHAT") = "KdvTipi"
        ElseIf nPosIslem = 5 Then
            dr("IZAHAT") = "Saat"
        ElseIf nPosIslem = 6 Then
            dr("IZAHAT") = "Kasiyer"
        ElseIf nPosIslem = 7 Then
            dr("IZAHAT") = "Kasa"
        End If
        dr("col1") = "Brüt Satýþ"
        dr("col2") = "Iskonto"
        dr("col3") = "VadeFarký"
        dr("col4") = "KdvMatrahý"
        dr("col5") = "KdvTutarý"
        dr("col6") = "NetTutar"
        dr("col7") = "Kayit"
        'dr("col8") = "Kapali"
        dr("col8") = ""
        'dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        Dim miktar As Decimal = 0
        Dim col1 As Decimal = 0
        Dim col2 As Decimal = 0
        Dim col3 As Decimal = 0
        Dim col4 As Decimal = 0
        Dim col5 As Decimal = 0
        Dim col6 As Decimal = 0
        Dim col7 As Decimal = 0
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Sýnýf") = "Satýþlar"
            dr("Aciklama") = dr1("Aciklama")
            dr("MIKTAR") = FormatNumber(dr1("Miktar"), 2)
            If nPosIslem = 3 Then
                If dr1("nGirisCikis") = 3 Then
                    If dr1("bKapali") = 1 Then
                        dr("IZAHAT") = "Normal"
                        dr("col8") = "K"
                    ElseIf dr1("bKapali") = 0 Then
                        dr("IZAHAT") = "Normal"
                        dr("col8") = "A"
                    End If
                ElseIf dr1("nGirisCikis") = 4 Then
                    If dr1("bKapali") = 1 Then
                        dr("IZAHAT") = "Iade"
                        dr("col8") = "K"
                    ElseIf dr1("bKapali") = 0 Then
                        dr("IZAHAT") = "Iade"
                        dr("col8") = "A"
                    End If
                ElseIf dr1("nGirisCikis") = 0 Then
                    dr("IZAHAT") = "Toplam"
                End If
            Else
                If dr1("nGirisCikis") = 3 Then
                    dr("IZAHAT") = dr1("sKod")
                ElseIf dr1("nGirisCikis") = 4 Then
                    dr("IZAHAT") = dr1("sKod")
                ElseIf dr1("nGirisCikis") = 0 Then
                    dr("IZAHAT") = "Toplam"
                End If
            End If
            'dr("IZAHAT") = dr1("nGirisCikis")
            dr("col1") = FormatNumber(dr1("Malbedeli"), 2)
            dr("col2") = FormatNumber(dr1("IskontoTutari"), 2)
            dr("col3") = FormatNumber(dr1("VadeFarki"), 2)
            dr("col4") = FormatNumber(dr1("KDVMatrahi"), 2)
            dr("col5") = FormatNumber(dr1("KdvTutari"), 2)
            dr("col6") = FormatNumber(dr1("NetTutar"), 2)
            dr("col7") = FormatNumber(dr1("nKayit"), 0)
            'dr("col8") = dr1("bKapali")
            dr("Status") = 1
            DataSet1.Tables(0).Rows.Add(dr)
            If dr1("nGirisCikis") <> 0 Then
                miktar += dr("MIKTAR")
                col1 += CType(dr("col1"), Decimal)
                col2 += CType(dr("col2"), Decimal)
                col3 += CType(dr("col3"), Decimal)
                col4 += CType(dr("col4"), Decimal)
                col5 += CType(dr("col5"), Decimal)
                col6 += CType(dr("col6"), Decimal)
                'col7 += CType(dr("col7"), Decimal)
            Else
                col7 += CType(dr("col7"), Decimal)
            End If
        Next
        dr = DataSet1.Tables(0).NewRow
        dr("Sýnýf") = "Satýþlar"
        dr("Aciklama") = "GenelToplam"
        dr("MIKTAR") = FormatNumber(miktar, 2)
        dr("IZAHAT") = ""
        dr("col1") = FormatNumber(col1, 2)
        dr("col2") = FormatNumber(col2, 2)
        dr("col3") = FormatNumber(col3, 2)
        dr("col4") = FormatNumber(col4, 2)
        dr("col5") = FormatNumber(col5, 2)
        dr("col6") = FormatNumber(col6, 2)
        dr("col7") = FormatNumber(col7, 0)
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
    End Sub
    Private Sub dataload_odemesayisi(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String)
        Dim kriter As String = ""
        kriter = " AND (dteOdemeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') "
        If kasiyer <> "[Tümü]" Then
            If kasatipi = "Kasa:" Then
                kriter += " AND b.nKasaNo IN ( " & kasiyer & " ) "
            ElseIf kasatipi = "Kasiyer:" Then
                kriter += " AND b.sKasiyerRumuzu IN ( " & kasiyer & " ) "
            End If
        End If
        If sMagaza <> "[Tümü]" Then
            kriter += " AND b.sMagaza IN ( " & sMagaza & " )"
        End If
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(DISTINCT lMakbuzNo) AS Sayi FROM         tbOdeme b WHERE     (nOdemeKodu = 2) " & kriter & " "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Sýnýf") = "Ödemeler"
            dr("Aciklama") = "ÖdemeYapanMüþteri"
            dr("MIKTAR") = dr1("Sayi")
            dr("Status") = 0
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_fis_sayilari(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String)
        Dim kriter As String = ""
        kriter = " AND (dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') "
        If kasiyer <> "[Tümü]" Then
            If kasatipi = "Kasa:" Then
                kriter += " AND b.sKasaNo IN ( " & kasiyer & " ) "
            ElseIf kasatipi = "Kasiyer:" Then
                kriter += " AND b.sKasiyerRumuzu IN ( " & kasiyer & " ) "
            End If
        End If
        If sMagaza <> "[Tümü]" Then
            kriter += " AND b.sMagazaKodu IN ( " & sMagaza & " )"
        End If
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sFisTipi, sAciklama, nStatus, bKapali, COUNT(DISTINCT lFisNo) AS nKayit, SUM(lNetTutar) AS lNetTutar FROM (SELECT a.sFisTipi , a.bKapali , a.lFisNo , b.sAciklama , a.nStatus , a.lNetTutar FROM BTBLINTERSATIS a INNER JOIN tbFisTipi b ON a.sFisTipi = b.sFisTipi WHERE (a.nGirisCikis IN (11 , 30)) " & kriter & ") DERIVEDTBL GROUP BY sFisTipi, sAciklama, bKapali, nStatus ORDER BY sFisTipi, sAciklama, nStatus"))
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim bKapali As String = ""
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Sýnýf") = "Fisler"
            If dr1("bKapali") = True Then
                bKapali = "K"
            ElseIf dr1("bKapali") = False Then
                bKapali = "A"
            End If
            If dr1("nStatus") = 0 Then
                dr("Aciklama") = Trim(dr1("sAciklama")) & "-" & bKapali & "-Normal"
                dr("col1") = FormatNumber(dr1("lNetTutar"), 2)
            ElseIf dr1("nStatus") = 1 Then
                dr("Aciklama") = Trim(dr1("sAciklama")) & "-" & bKapali & "-Iptal"
                dr("col1") = FormatNumber(dr1("lNetTutar"), 2)
            ElseIf dr1("nStatus") = 2 Then
                dr("Aciklama") = Trim(dr1("sAciklama")) & "-" & bKapali & "-AskýyaAlýnan"
                dr("col1") = FormatNumber(dr1("lNetTutar"), 2)
            ElseIf dr1("nStatus") = 3 Then
                dr("Aciklama") = Trim(dr1("sAciklama")) & "-" & bKapali & "-Faturalanan"
                dr("col1") = FormatNumber(dr1("lNetTutar"), 2)
            End If
            dr("MIKTAR") = dr1("nKayit")
            If dr1("nKayit") > 0 Then
                dr("col2") = "Ort:" & FormatNumber(dr1("lNetTutar") / dr1("nKayit"), 2)
            End If
            dr("Status") = 0
            DataSet1.Tables(0).Rows.Add(dr)
        Next
    End Sub
    Private Sub dataload_yenikayitsayisi(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String)
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(*) AS Sayi FROM         tbMusteri a WHERE     (CAST(CONVERT(char(10), dteKayitTarihi, 103) AS smalldatetime) BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')"))
        Dim dr As DataRow
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            dr = DataSet1.Tables(0).NewRow
            dr("Sýnýf") = "Ödemeler"
            dr("Aciklama") = "YeniAçýlanMüþteri"
            dr("MIKTAR") = dr1("Sayi")
            dr("Status") = 0
            DataSet1.Tables(0).Rows.Add(dr)
        Next
        nakit = nakit - (masraf)
        dr = DataSet1.Tables(0).NewRow
        'dr("Sýnýf") = "Nakit"
        'dr("Aciklama") = "NakitleriToplamý"
        'dr("MIKTAR") = 0
        'dr("IZAHAT") = ""
        'dr("col1") = FormatNumber(top_kredipesinat, 2)
        'dr("col2") = FormatNumber(top_pesinpesinat, 2)
        'dr("col3") = FormatNumber(top_krediodeme, 2)
        'dr("col4") = FormatNumber(top_krediiade, 2)
        dr("col5") = "NakitKasa"
        dr("col6") = FormatNumber(nakit, 2)
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
    End Sub
    Private Function odemeSekliSorgula(ByVal tipNo As String) As String
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = "SELECT nOdemeTipi FROM tbOdemeSekli WHERE sOdemeSekli = '" & tipNo & "'"
        tipNo = cmd.ExecuteScalar
        con.Close()
        Return tipNo
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub dataload_Odemeler(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String, ByVal saat1 As DateTime, ByVal saat2 As DateTime)
        Dim kriter As String = ""
        kriter = " AND (b.dteOdemeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') "
        If saat1 = "00:00:00" Then
        Else
            kriter = " AND a.dteKayitTarihi BETWEEN '" & tarih1 & " " & saat1 & "' AND '" & tarih2 & " " & saat2 & "'"
        End If
        If kasiyer <> "[Tümü]" Then
            If kasatipi = "Kasa:" Then
                kriter += " AND b.nKasaNo IN ( " & kasiyer & " ) "
            ElseIf kasatipi = "Kasiyer:" Then
                kriter += " AND b.sKasiyerRumuzu IN ( " & kasiyer & " ) "
            End If
        End If
        If sMagaza <> "[Tümü]" Then
            kriter += " AND b.sMagaza IN ( " & sMagaza & " )"
        End If
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT OdemeSekli, sAciklama1, nOdemeTipi, SUM(Odeme) AS Odeme, COUNT(DISTINCT lMakbuzNo) as nKayit,sFisTipi, nOdemeKodu, nGirisCikis FROM (SELECT CASE WHEN a.sFisTipi = 'KS' THEN 'Sli' ELSE substring(c.sAciklama , 1 , 3) END AS sAciklama , d.sAciklama AS sAciklama1 , SUM(b.lOdemeTutar) AS Odeme , b.lMakbuzNo,b.sKasiyerRumuzu , tbKasiyer.sAdi , tbKasiyer.sSoyadi , CASE WHEN a.sFisTipi = 'KS' THEN 'S ' + d.sOdemeSekli ELSE d.sOdemeSekli END AS OdemeSekli , k.nOdemeTipi , b.lOdemeNo , a.sFisTipi , b.sDovizCinsi , k.sAciklama AS Expr2 , b.nOdemeKodu , a.nGirisCikis FROM tbOdemeKodu c INNER JOIN tbOdeme b ON c.nOdemeKodu = b.nOdemeKodu INNER JOIN tbOdemeSekli d ON b.sOdemeSekli = d.sOdemeSekli INNER JOIN tbAlisVeris a ON b.nAlisverisID = a.nAlisverisID INNER JOIN tbKasiyer ON b.sKasiyerRumuzu = tbKasiyer.sKasiyerRumuzu INNER JOIN tbOdemeTipi k ON d.nOdemeTipi = k.nOdemeTipi INNER JOIN tbFisTipi f ON a.sFisTipi = f.sFisTipi WHERE (a.sFisTipi <> 'KA') " & kriter & " GROUP BY c.sAciklama , b.sKasiyerRumuzu , d.sAciklama , tbKasiyer.sAdi , tbKasiyer.sSoyadi , d.sOdemeSekli , k.nOdemeTipi , b.lOdemeNo , b.lMakbuzNo,a.sFisTipi , b.sDovizCinsi , k.sAciklama , b.nOdemeKodu , a.nGirisCikis) TT GROUP BY OdemeSekli, sAciklama1, nOdemeTipi, sFisTipi, nOdemeKodu, nGirisCikis ORDER BY OdemeSekli, nGirisCikis, nOdemeKodu"))
        Dim dr As DataRow
        Dim dr1 As DataRow
        dr = DataSet1.Tables(0).NewRow
        dr("Status") = 1
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("Sýnýf") = "Baþlýk"
        dr("Aciklama") = "ÖdemeÞekli"
        dr("MIKTAR") = "Kayýt"
        dr("IZAHAT") = "Kod"
        dr("col1") = "KR.Peþinatý"
        dr("col2") = "PeþinSatýþ"
        dr("col3") = "KK.Ödeme"
        dr("col4") = "KR.Iadesi"
        dr("col5") = "PeþinatIadesý"
        dr("col6") = "Toplam"
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        Dim miktar As Decimal = 0
        Dim col1 As Decimal = 0
        Dim col2 As Decimal = 0
        Dim col3 As Decimal = 0
        Dim col4 As Decimal = 0
        Dim col5 As Decimal = 0
        Dim col6 As Decimal = 0
        Dim Odeme As String = ""
        Dim odemeaciklama As String = ""
        'Dim nakit As Decimal = 0
        Dim kredi As Decimal = 0
        Dim kredipesinat As Decimal = 0
        Dim pesinsatis As Decimal = 0
        Dim krediodeme As Decimal = 0
        Dim krediiade As Decimal = 0
        Dim pesinatiade As Decimal = 0
        Dim sayi As Integer = 0
        Dim toplam As Integer = 0
        toplam = ds1.Tables(0).Rows.Count
        Dim top_kredipesinat As Decimal = 0
        Dim top_pesinpesinat As Decimal = 0
        Dim top_krediodeme As Decimal = 0
        Dim top_krediiade As Decimal = 0
        Dim top_pesinatiade As Decimal = 0
        Dim top_toplam As Decimal = 0
        nakit = 0
        kredi = 0
        masraf = 0
        For Each dr1 In ds1.Tables(0).Rows
            sayi += 1
            If sayi > 1 Then
                If Trim(dr1("OdemeSekli")) <> Odeme Then
                    dr = DataSet1.Tables(0).NewRow
                    dr("Sýnýf") = "Ödemeler"
                    dr("Aciklama") = odemeaciklama
                    dr("MIKTAR") = dr1("nKayit")
                    dr("IZAHAT") = Odeme
                    dr("col1") = FormatNumber(kredipesinat, 2)
                    dr("col2") = FormatNumber(pesinsatis, 2)
                    dr("col3") = FormatNumber(krediodeme, 2)
                    dr("col4") = FormatNumber(krediiade, 2)
                    dr("col5") = FormatNumber(pesinatiade, 2)
                    dr("col6") = FormatNumber(kredipesinat + pesinsatis + krediodeme + krediiade + pesinatiade, 2)
                    Try
                        If dr("IZAHAT").ToString.Length > 1 Then
                            If odemeSekliSorgula(Trim(dr("IZAHAT"))) = "1" Then
                                nakit = nakit + CType(dr("col6"), Decimal)
                            ElseIf dr("IZAHAT") = "S N" Or Trim(dr("IZAHAT")) = "H" Then
                                nakit_pesinat = CType(dr("col6"), Decimal)
                                nakit = nakit + nakit_pesinat
                            ElseIf dr("IZAHAT").ToString.Substring(0, 2) = "S " And dr("IZAHAT") <> "S N" Then
                                nakits_pesinat = CType(dr("col6"), Decimal)
                            End If
                        Else
                            If odemeSekliSorgula(Trim(dr("IZAHAT"))) = "1" Then
                                nakit = nakit + CType(dr("col6"), Decimal)
                            ElseIf dr("IZAHAT") = "S N" Or Trim(dr("IZAHAT")) = "H" Then
                                nakit_pesinat = CType(dr("col6"), Decimal)
                                nakit = nakit + nakit_pesinat
                            ElseIf dr("IZAHAT").ToString.Substring(0, 1) = "S" And dr("IZAHAT") <> "S N" Then
                                nakits_pesinat = CType(dr("col6"), Decimal)
                            End If
                        End If
                    Catch ex As Exception
                        MessageBox.Show("HATA")
                    End Try
                    dr("Status") = 1
                    top_kredipesinat += CType(dr("col1"), Decimal)
                    top_pesinpesinat += CType(dr("col2"), Decimal)
                    top_krediodeme += CType(dr("col3"), Decimal)
                    top_krediiade += CType(dr("col4"), Decimal)
                    top_pesinatiade += CType(dr("col5"), Decimal)
                    top_toplam += CType(dr("col6"), Decimal)
                    DataSet1.Tables(0).Rows.Add(dr)
                    kredipesinat = 0
                    pesinsatis = 0
                    krediodeme = 0
                    krediiade = 0
                    pesinatiade = 0
                    Odeme = Trim(dr1("OdemeSekli"))
                    miktar = 0
                    odemeaciklama = dr1("sAciklama1")
                End If
            Else
                miktar = 0
                Odeme = Trim(dr1("OdemeSekli"))
                odemeaciklama = dr1("sAciklama1")
            End If
            'Nakitleri Toplam
            If dr1("nOdemeTipi") = 1 Then
                If Trim(dr1("OdemeSekli")) = "N" Then
                    'nakit += dr1("Odeme")
                End If
            ElseIf dr1("nOdemeTipi") = 2 Then
                kredi += dr1("Odeme")
                miktar += dr1("nKayit")
            End If
            'Normal Ödemeleri Ayýkla
            If dr1("nGirisCikis") = 3 Then
                If dr1("nOdemeKodu") = 1 Then
                    If Trim(dr1("sFisTipi")) = "K" Or Trim(dr1("sFisTipi")) = "SK" Or Trim(dr1("sFisTipi")) = "SP" Or Trim(dr1("sFisTipi")) = "KS" Then
                        kredipesinat += dr1("Odeme")
                        miktar += dr1("nKayit")
                    ElseIf Trim(dr1("sFisTipi")) = "P" Then
                        pesinsatis += dr1("Odeme")
                        miktar += dr1("nKayit")
                    End If
                ElseIf dr1("nOdemeKodu") = 2 Then
                    krediodeme += dr1("odeme")
                    miktar += dr1("nKayit")
                ElseIf dr1("nOdemeKodu") = 3 Then
                End If
                'Ýade Ödemeleri Ayýkla
            ElseIf dr1("nGirisCikis") = 4 Then
                If dr1("nOdemeKodu") = 1 Then
                    If Trim(dr1("sFisTipi")) = "K" Or Trim(dr1("sFisTipi")) = "SK" Or Trim(dr1("sFisTipi")) = "SP" Then
                        krediiade += dr1("Odeme")
                    ElseIf Trim(dr1("sFisTipi")) = "P" Then
                        pesinatiade += dr1("Odeme")
                    End If
                ElseIf dr1("nOdemeKodu") = 2 Then
                ElseIf dr1("nOdemeKodu") = 3 Then
                End If
            End If
            If sayi = toplam Then
                dr = DataSet1.Tables(0).NewRow
                dr("Sýnýf") = "Ödemeler"
                dr("Aciklama") = odemeaciklama
                dr("MIKTAR") = miktar
                dr("IZAHAT") = Odeme
                dr("col1") = FormatNumber(kredipesinat, 2)
                dr("col2") = FormatNumber(pesinsatis, 2)
                dr("col3") = FormatNumber(krediodeme, 2)
                dr("col4") = FormatNumber(krediiade, 2)
                dr("col5") = FormatNumber(pesinatiade, 2)
                dr("col6") = FormatNumber(kredipesinat + pesinsatis + krediodeme + krediiade + pesinatiade, 2)
                If dr("IZAHAT").ToString.Length > 1 Then
                    If odemeSekliSorgula(Trim(dr("IZAHAT"))) = "1" Then
                        nakit = nakit + CType(dr("col6"), Decimal)
                    ElseIf dr("IZAHAT") = "S N" Or Trim(dr("IZAHAT")) = "H" Then
                        nakit_pesinat = CType(dr("col6"), Decimal)
                        nakit = nakit + nakit_pesinat
                    ElseIf dr("IZAHAT").ToString.Substring(0, 2) = "S " And dr("IZAHAT") <> "S N" Then
                        nakits_pesinat = CType(dr("col6"), Decimal)
                    End If
                Else
                    If odemeSekliSorgula(Trim(dr("IZAHAT"))) = "1" Then
                        nakit = nakit + CType(dr("col6"), Decimal)
                    ElseIf dr("IZAHAT") = "S N" Or Trim(dr("IZAHAT")) = "H" Then
                        nakit_pesinat = CType(dr("col6"), Decimal)
                        nakit = nakit + nakit_pesinat
                    ElseIf dr("IZAHAT").ToString.Substring(0, 1) = "S" And dr("IZAHAT") <> "S N" Then
                        nakits_pesinat = CType(dr("col6"), Decimal)
                    End If
                End If
                dr("Status") = 1
                top_kredipesinat += CType(dr("col1"), Decimal)
                top_pesinpesinat += CType(dr("col2"), Decimal)
                top_krediodeme += CType(dr("col3"), Decimal)
                top_krediiade += CType(dr("col4"), Decimal)
                top_pesinatiade += CType(dr("col5"), Decimal)
                top_toplam += CType(dr("col6"), Decimal)
                DataSet1.Tables(0).Rows.Add(dr)
                kredipesinat = 0
                pesinsatis = 0
                krediodeme = 0
                krediiade = 0
                pesinatiade = 0
                Odeme = Trim(dr1("OdemeSekli"))
                odemeaciklama = dr1("sAciklama1")
            End If
        Next
        dr = DataSet1.Tables(0).NewRow
        dr("Sýnýf") = "Ödemeler"
        dr("Aciklama") = "ÖdemelerinToplamý"
        dr("MIKTAR") = 0
        dr("IZAHAT") = ""
        dr("col1") = FormatNumber(top_kredipesinat, 2)
        dr("col2") = FormatNumber(top_pesinpesinat, 2)
        dr("col3") = FormatNumber(top_krediodeme, 2)
        dr("col4") = FormatNumber(top_krediiade, 2)
        dr("col5") = FormatNumber(top_pesinatiade, 2)
        dr("col6") = FormatNumber(top_toplam, 2)
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("Sýnýf") = "Nakit"
        dr("Aciklama") = "NakitlerinToplamý"
        dr("MIKTAR") = 0
        dr("IZAHAT") = ""
        'dr("col1") = FormatNumber(top_kredipesinat, 2)
        'dr("col2") = FormatNumber(top_pesinpesinat, 2)
        'dr("col3") = FormatNumber(top_krediodeme, 2)
        'dr("col4") = FormatNumber(top_krediiade, 2)
        'dr("col5") = FormatNumber(top_pesinatiade, 2)
        dr("col6") = FormatNumber(nakit, 2)
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("Sýnýf") = "Nakit"
        dr("Aciklama") = "Avanslar"
        dr("MIKTAR") = 0
        dr("IZAHAT") = ""
        'dr("col1") = FormatNumber(top_kredipesinat, 2)
        'dr("col2") = FormatNumber(top_pesinpesinat, 2)
        'dr("col3") = FormatNumber(top_krediodeme, 2)
        'dr("col4") = FormatNumber(top_krediiade, 2)
        'dr("col5") = FormatNumber(top_pesinatiade, 2)
        dr("col6") = FormatNumber(nakit_pesinat + nakits_pesinat, 2)
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("Sýnýf") = "Kredi"
        dr("Aciklama") = "KredilerinToplamý"
        dr("MIKTAR") = 0
        dr("IZAHAT") = ""
        'dr("col1") = FormatNumber(top_kredipesinat, 2)
        'dr("col2") = FormatNumber(top_pesinpesinat, 2)
        'dr("col3") = FormatNumber(top_krediodeme, 2)
        'dr("col4") = FormatNumber(top_krediiade, 2)
        'dr("col5") = FormatNumber(top_pesinatiade, 2)
        dr("col6") = FormatNumber(kredi, 2)
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        'masraflar 
        dataload_masraflar(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi)
    End Sub
    Private Sub dataload_Odemeler_pos(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String)
        Dim kriter As String = ""
        kriter = " AND (a.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') "
        If kasiyer <> "[Tümü]" Then
            If kasatipi = "Kasa:" Then
                kriter += " AND b.sKasaNo IN ( " & kasiyer & " ) "
            ElseIf kasatipi = "Kasiyer:" Then
                kriter += " AND b.sKasiyerRumuzu IN ( " & kasiyer & " ) "
            End If
        End If
        If sMagaza <> "[Tümü]" Then
            kriter += " AND a.sMagazaKodu IN ( " & sMagaza & " )"
        End If
        kriter += " AND a.sKullanici = '" & kullanici & "'"
        'ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT OdemeSekli, sAciklama1, nOdemeTipi, SUM(Odeme) AS Odeme, sFisTipi, nOdemeKodu, nGirisCikis FROM (SELECT a.sOdemeKodu AS OdemeSekli , d.sAciklama AS sAciklama1 , d.nOdemeTipi , a.lOdemeTutar AS Odeme , a.sFisTipi , d.nOdemeTipi AS nOdemeKodu , 3 AS nGirisCikis FROM BTBLINTERSATIS a INNER JOIN tbOdemeSekli d ON a.sOdemeKodu = d.sOdemeSekli WHERE (a.nGirisCikis IN (9 , 10)) " & kriter & " ) DERIVEDTBL GROUP BY OdemeSekli, sAciklama1, nOdemeTipi, sFisTipi, nOdemeKodu, nGirisCikis ORDER BY OdemeSekli, nGirisCikis, nOdemeKodu"))
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT OdemeSekli, sAciklama1, nOdemeTipi, SUM(Odeme) AS Odeme, sFisTipi, nOdemeKodu, nGirisCikis FROM (SELECT a.sOdemeKodu AS OdemeSekli , d.sAciklama AS sAciklama1 , d.nOdemeTipi , a.lOdemeTutar AS Odeme , a.sFisTipi , d.nOdemeTipi AS nOdemeKodu , 3 AS nGirisCikis FROM BTBLINTERSATIS a INNER JOIN tbOdemeSekli d ON a.sOdemeKodu = d.sOdemeSekli WHERE (a.nGirisCikis IN (9 , 10)) AND (a.bKapali = 1) " & kriter & " )  DERIVEDTBL GROUP BY OdemeSekli, sAciklama1, nOdemeTipi, sFisTipi, nOdemeKodu, nGirisCikis ORDER BY OdemeSekli, nGirisCikis, nOdemeKodu"))
        Dim dr As DataRow
        Dim dr1 As DataRow
        dr = DataSet1.Tables(0).NewRow
        dr("Status") = 1
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("Sýnýf") = "Baþlýk"
        dr("Aciklama") = "ÖdemeÞekli"
        dr("MIKTAR") = ""
        dr("IZAHAT") = "Kod"
        dr("col1") = "KR.Peþinatý"
        dr("col2") = "PeþinSatýþ"
        dr("col3") = "KK.Ödeme"
        dr("col4") = "KR.Iadesi"
        dr("col5") = "PeþinatIadesý"
        dr("col6") = "Toplam"
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        Dim miktar As Decimal = 0
        Dim col1 As Decimal = 0
        Dim col2 As Decimal = 0
        Dim col3 As Decimal = 0
        Dim col4 As Decimal = 0
        Dim col5 As Decimal = 0
        Dim col6 As Decimal = 0
        Dim Odeme As String = ""
        Dim odemeaciklama As String = ""
        'Dim nakit As Decimal = 0
        Dim kredi As Decimal = 0
        Dim kredipesinat As Decimal = 0
        Dim pesinsatis As Decimal = 0
        Dim krediodeme As Decimal = 0
        Dim krediiade As Decimal = 0
        Dim pesinatiade As Decimal = 0
        Dim sayi As Integer = 0
        Dim toplam As Integer = 0
        toplam = ds1.Tables(0).Rows.Count
        Dim top_kredipesinat As Decimal = 0
        Dim top_pesinpesinat As Decimal = 0
        Dim top_krediodeme As Decimal = 0
        Dim top_krediiade As Decimal = 0
        Dim top_pesinatiade As Decimal = 0
        Dim top_toplam As Decimal = 0
        nakit = 0
        kredi = 0
        masraf = 0
        For Each dr1 In ds1.Tables(0).Rows
            sayi += 1
            If sayi > 1 Then
                If Trim(dr1("OdemeSekli")) <> Odeme Then
                    dr = DataSet1.Tables(0).NewRow
                    dr("Sýnýf") = "Ödemeler"
                    dr("Aciklama") = odemeaciklama
                    dr("MIKTAR") = ""
                    dr("IZAHAT") = Odeme
                    dr("col1") = FormatNumber(kredipesinat, 2)
                    dr("col2") = FormatNumber(pesinsatis, 2)
                    dr("col3") = FormatNumber(krediodeme, 2)
                    dr("col4") = FormatNumber(krediiade, 2)
                    dr("col5") = FormatNumber(pesinatiade, 2)
                    dr("col6") = FormatNumber(kredipesinat + pesinsatis + krediodeme + krediiade + pesinatiade, 2)
                    If dr("IZAHAT") = "N" Or dr("IZAHAT") = "H" Then
                        nakit = CType(dr("col6"), Decimal)
                    End If
                    dr("Status") = 1
                    top_kredipesinat += CType(dr("col1"), Decimal)
                    top_pesinpesinat += CType(dr("col2"), Decimal)
                    top_krediodeme += CType(dr("col3"), Decimal)
                    top_krediiade += CType(dr("col4"), Decimal)
                    top_pesinatiade += CType(dr("col5"), Decimal)
                    top_toplam += CType(dr("col6"), Decimal)
                    DataSet1.Tables(0).Rows.Add(dr)
                    kredipesinat = 0
                    pesinsatis = 0
                    krediodeme = 0
                    krediiade = 0
                    pesinatiade = 0
                    Odeme = Trim(dr1("OdemeSekli"))
                    odemeaciklama = dr1("sAciklama1")
                End If
            Else
                Odeme = Trim(dr1("OdemeSekli"))
                odemeaciklama = dr1("sAciklama1")
            End If
            'Nakitleri Toplam
            If dr1("nOdemeTipi") = 1 Then
                If Trim(dr1("OdemeSekli")) = "N" Then
                    'nakit += dr1("Odeme")
                End If
            ElseIf dr1("nOdemeTipi") = 2 Then
                kredi += dr1("Odeme")
            End If
            'Normal Ödemeleri Ayýkla
            If dr1("nGirisCikis") = 3 Then
                If dr1("nOdemeKodu") = 1 Then
                    If Trim(dr1("sFisTipi")) = "K" Or Trim(dr1("sFisTipi")) = "SK" Or Trim(dr1("sFisTipi")) = "SP" Then
                        kredipesinat += dr1("Odeme")
                    ElseIf Trim(dr1("sFisTipi")) = "P" Then
                        pesinsatis += dr1("Odeme")
                    End If
                ElseIf dr1("nOdemeKodu") = 2 Then
                    krediodeme += dr1("odeme")
                ElseIf dr1("nOdemeKodu") = 3 Then
                End If
                'Ýade Ödemeleri Ayýkla
            ElseIf dr1("nGirisCikis") = 4 Then
                If dr1("nOdemeKodu") = 1 Then
                    If Trim(dr1("sFisTipi")) = "K" Or Trim(dr1("sFisTipi")) = "SK" Or Trim(dr1("sFisTipi")) = "SP" Then
                        krediiade += dr1("Odeme")
                    ElseIf Trim(dr1("sFisTipi")) = "P" Then
                        pesinatiade += dr1("Odeme")
                    End If
                ElseIf dr1("nOdemeKodu") = 2 Then
                ElseIf dr1("nOdemeKodu") = 3 Then
                End If
            End If
            If sayi = toplam Then
                dr = DataSet1.Tables(0).NewRow
                dr("Sýnýf") = "Ödemeler"
                dr("Aciklama") = odemeaciklama
                dr("MIKTAR") = ""
                dr("IZAHAT") = Odeme
                dr("col1") = FormatNumber(kredipesinat, 2)
                dr("col2") = FormatNumber(pesinsatis, 2)
                dr("col3") = FormatNumber(krediodeme, 2)
                dr("col4") = FormatNumber(krediiade, 2)
                dr("col5") = FormatNumber(pesinatiade, 2)
                dr("col6") = FormatNumber(kredipesinat + pesinsatis + krediodeme + krediiade + pesinatiade, 2)
                If dr("IZAHAT") = "N" Or dr("IZAHAT") = "H" Then
                    nakit = CType(dr("col6"), Decimal)
                End If
                dr("Status") = 1
                top_kredipesinat += CType(dr("col1"), Decimal)
                top_pesinpesinat += CType(dr("col2"), Decimal)
                top_krediodeme += CType(dr("col3"), Decimal)
                top_krediiade += CType(dr("col4"), Decimal)
                top_pesinatiade += CType(dr("col5"), Decimal)
                top_toplam += CType(dr("col6"), Decimal)
                DataSet1.Tables(0).Rows.Add(dr)
                kredipesinat = 0
                pesinsatis = 0
                krediodeme = 0
                krediiade = 0
                pesinatiade = 0
                Odeme = Trim(dr1("OdemeSekli"))
                odemeaciklama = dr1("sAciklama1")
            End If
        Next
        dr = DataSet1.Tables(0).NewRow
        dr("Sýnýf") = "Ödemeler"
        dr("Aciklama") = "ÖdemelerinToplamý"
        dr("MIKTAR") = 0
        dr("IZAHAT") = ""
        dr("col1") = FormatNumber(top_kredipesinat, 2)
        dr("col2") = FormatNumber(top_pesinpesinat, 2)
        dr("col3") = FormatNumber(top_krediodeme, 2)
        dr("col4") = FormatNumber(top_krediiade, 2)
        dr("col5") = FormatNumber(top_pesinatiade, 2)
        dr("col6") = FormatNumber(top_toplam, 2)
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("Sýnýf") = "Nakit"
        dr("Aciklama") = "NakitlerinToplamý"
        dr("MIKTAR") = 0
        dr("IZAHAT") = ""
        'dr("col1") = FormatNumber(top_kredipesinat, 2)
        'dr("col2") = FormatNumber(top_pesinpesinat, 2)
        'dr("col3") = FormatNumber(top_krediodeme, 2)
        'dr("col4") = FormatNumber(top_krediiade, 2)
        'dr("col5") = FormatNumber(top_pesinatiade, 2)
        dr("col6") = FormatNumber(nakit, 2)
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        dr = DataSet1.Tables(0).NewRow
        dr("Sýnýf") = "Kredi"
        dr("Aciklama") = "KredilerinToplamý"
        dr("MIKTAR") = 0
        dr("IZAHAT") = ""
        'dr("col1") = FormatNumber(top_kredipesinat, 2)
        'dr("col2") = FormatNumber(top_pesinpesinat, 2)
        'dr("col3") = FormatNumber(top_krediodeme, 2)
        'dr("col4") = FormatNumber(top_krediiade, 2)
        'dr("col5") = FormatNumber(top_pesinatiade, 2)
        dr("col6") = FormatNumber(kredi, 2)
        dr("Status") = 0
        DataSet1.Tables(0).Rows.Add(dr)
        'masraflar 
        dataload_masraflar(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi)
    End Sub
    Private Sub dataload_masraflar(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String)
        Dim kriter As String = ""
        kriter = " AND (a.dteMasrafTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') "
        If kasiyer <> "[Tümü]" Then
            If kasatipi = "Kasa:" Then
                kriter += " AND a.nKasaNo IN ( " & kasiyer & " ) "
            ElseIf kasatipi = "Kasiyer:" Then
                kriter += " AND a.sKasiyerRumuzu IN ( " & kasiyer & " ) "
            End If
        End If
        If sMagaza <> "[Tümü]" Then
            kriter += " AND a.sMagaza IN ( " & sMagaza & " )"
        End If
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED select isnull(sum(a.lTutar), 0) as lTutar from tbMagazaMasrafi as a , tbParekendeKasa as b,tbKasiyer Where a.nKasaNo = b.nKasaNo and a.sKasiyerRumuzu = tbKasiyer.sKasiyerRumuzu  " & kriter & " "))
        Dim dr As DataRow
        Dim dr1 As DataRow
        masraf = 0
        For Each dr1 In ds1.Tables(0).Rows
            masraf += dr1("lTutar")
        Next
        Dim lMasraf As Decimal
        If masraf <> 0 Then
            lMasraf = -(masraf)
            dr = DataSet1.Tables(0).NewRow
            dr("Sýnýf") = "Masraf"
            dr("Aciklama") = "MasraflarýnToplamý"
            dr("MIKTAR") = 0
            dr("IZAHAT") = ""
            'dr("col1") = FormatNumber(top_kredipesinat, 2)
            'dr("col2") = FormatNumber(top_pesinpesinat, 2)
            'dr("col3") = FormatNumber(top_krediodeme, 2)
            'dr("col4") = FormatNumber(top_krediiade, 2)
            'dr("col5") = FormatNumber(top_pesinatiade, 2)
            dr("col6") = FormatNumber(lMasraf, 2)
            dr("Status") = 0
            DataSet1.Tables(0).Rows.Add(dr)
        End If
        dr = Nothing
        dr1 = Nothing
        lMasraf = Nothing
    End Sub
    Private Function sorgu(ByVal query As String, Optional ByVal sTable As String = "TABLE1") As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, sTable)
        conn.Close()
        Return DS
        adapter = Nothing
        cmd = Nothing
    End Function
    Private Sub raporla(ByVal nIslem As Integer)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyalarý (Form*.frx) |Form*.frx"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Perakende\Form.frx"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Perakende"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            Dim report As New FastReport.Report
            report.Load(sFile)
            report.RegisterData(DataSet1)
            Try
                report.RegisterData(ds_Faaliyet)
            Catch ex As Exception
            End Try
            Try
                report.RegisterData(ds_SatisKarlilik)
            Catch ex As Exception
            End Try
            'report.RegisterData(ds_tbBankaKodu)
            report.RegisterData(ds_tbParamGenel)
            Dim kriter As String = ""
            kriter += DateEdit1.EditValue.ToLongDateString & " ve " & DateEdit2.EditValue.ToLongDateString & " Tarihleri Arasýndaki Kasa Raporu" & vbCrLf
            kriter += "Maðazalar:" & sec_depo.Text & sec_kasatipi.Text & " " & sec_kasakasiyer.Text & " HareketTipi: " & sec_harekettipi.Text & " FiþTipi: " & sec_fistipi.Text
            report.SetParameterValue("Kriter", kriter)
            'report.SetParameterValue("lBordroNo", txt_lBordroNo.EditValue)
            'report.SetParameterValue("sCekSenetTipi", sec_sCekSenetTipi.Text)
            'report.SetParameterValue("sCekSenetIslem", sec_nCekSenetIslem.Text)
            'report.SetParameterValue("sFirmaKodu", txt_musteriNo.Text)
            'report.SetParameterValue("sFirmaAciklama", lbl_Firma.Text)
            report.ScriptLanguage = Language.Vb
            If nIslem = 0 Then
                report.Show()
            ElseIf nIslem = 1 Then
                report.Design()
            ElseIf nIslem = 2 Then
                report.Print()
            End If
            report.Dispose()
            report = Nothing
        End If
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
        Dim kriter As String = ""
        kriter += DateEdit1.EditValue.ToLongDateString & " ve " & DateEdit2.EditValue.ToLongDateString & " Tarihleri Arasýndaki Kasa Raporu" & vbCrLf
        kriter += "Maðazalar:" & sec_depo.Text & sec_kasatipi.Text & " " & sec_kasakasiyer.Text & " HareketTipi: " & sec_harekettipi.Text & " FiþTipi: " & sec_fistipi.Text
        CompositeLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Financial Managment-Finans Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        CompositeLink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
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
    Public Function stok(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime) As DataSet
        Dim kriter As String = ""
        'If sec_konum.Text = "Kodu" Then
        '    kriter += " WHERE ( tbFirma.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
        'ElseIf sec_konum.Text = "Adý" Then
        '    kriter += " WHERE ( tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        'ElseIf sec_konum.Text = "Ýstihbarat" Then
        '    kriter += " WHERE (( tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + '  ' + tbFirmaAciklamasi.sAciklama5) " & sorgu_kriter_string(ara, ara_kriter) & " )"
        'ElseIf sec_konum.Text = "Adres" Then
        '    kriter += " WHERE ( tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu  " & sorgu_kriter_string(ara, ara_kriter) & " )"
        'ElseIf sec_konum.Text = "Sýnýf1" Then
        '    kriter += " WHERE (tbFSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        'ElseIf sec_konum.Text = "Sýnýf2" Then
        '    kriter += " WHERE (tbFSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        'ElseIf sec_konum.Text = "Sýnýf3" Then
        '    kriter += " WHERE (tbFSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        'ElseIf sec_konum.Text = "Sýnýf4" Then
        '    kriter += " WHERE (tbFSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        'ElseIf sec_konum.Text = "Sýnýf5" Then
        '    kriter += " WHERE (tbFSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        'ElseIf sec_konum.Text = "Adý+Soyadý" Then
        '    Dim adi As String = ""
        '    Dim soyadi As String = ""
        '    Dim x
        '    If CStr(ara.ToString) <> "" Then
        '        x = (ara).IndexOf(" ", 1, (ara.Length - 1))
        '        If x = -1 Then
        '            adi = ara
        '        Else
        '            adi = (ara).Substring(0, x)
        '            soyadi = (ara).Substring((x + 1), (ara).Length - (x + 1))
        '            If IsNumeric(ara) Then
        '            Else
        '            End If
        '        End If
        '    End If
        '    'MsgBox(Sorgu_sDil("Adi :" & vbTab & adi & vbCrLf & "Soyadi :" & vbTab & soyadi)
        '    If adi.ToString <> "" Then
        '        kriter += " WHERE ( tbMusteri.sAdi " & sorgu_kriter_string(adi, ara_kriter) & " )"
        '    End If
        '    If soyadi.ToString <> "" Then
        '        kriter += " AND ( tbMusteri.sSoyadi " & sorgu_kriter_string(soyadi, ara_kriter) & " )"
        '    End If
        'Else
        'End If
        kriter += " AND tbFirma.dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih2.ToString, 10) + " 23:59:59" & "' "
        'kriter = "WHERE tbMusteri.dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 23:59:59" & "' "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti, tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT, tbFSinif1.sAciklama AS SINIF1, tbFSinif2.sAciklama AS SINIF2, tbFSinif3.sAciklama AS SINIF3, tbFSinif4.sAciklama AS SINIF4, tbFSinif5.sAciklama AS SINIF5 FROM tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu RIGHT OUTER JOIN tbFirma LEFT OUTER JOIN tbFirmaAciklamasi ON tbFirma.nFirmaID = tbFirmaAciklamasi.nFirmaID ON tbFirmaSinifi.nFirmaID = tbFirma.nFirmaID " & kriter & " ORDER BY tbFirma.sKodu")
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
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sMagaza As String, ByVal kasatipi As String, ByVal kasiyer As String, ByVal harekettipi As String, ByVal fistipi As String, ByVal saat1 As DateTime, ByVal saat2 As DateTime)
        DataSet1.Tables(0).Clear()
        If pos = False Then
            dataload_satislar(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi, saat1, saat2)
            dataload_Odemeler(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi, saat1, saat2)
            dataload_odemesayisi(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi)
            dataload_yenikayitsayisi(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi)
            If bKasaKasiyer = True Then
                dataload_satislar_faaliyet(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi)
                dataload_satislar_karlilik(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi)
            End If
        ElseIf pos = True Then
            If nPosIslem = 3 Then
                dataload_satislar_pos(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi)
                dataload_Odemeler_pos(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi)
                dataload_fis_sayilari(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi)
                dataload_odemesayisi(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi)
                dataload_yenikayitsayisi(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi)
            Else
                dataload_satislar_pos(tarih1, tarih2, sMagaza, kasatipi, kasiyer, harekettipi, fistipi, nPosIslem)
            End If
        End If
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
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
    Private Sub analiz_musteri_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_musteri_karti
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("lKodu")
            frm.musteriID = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_acik_faturalar_analiz()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_acik_analiz
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_acik_faturalar()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_acik
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_iletisim()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_firma_iletisim
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("nFirmaID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_satislar()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_kapatma
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("lKodu")
            frm.musteriID = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_hareket_ekstre()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_ekstre
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("lKodu")
            frm.musteriID = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub girdi_tutar_hesapla()
        Dim dr As DataRow
        If GridView2.RowCount > 0 Then
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            dr.BeginEdit()
            dr.EndEdit()
            GridControl2.Focus()
            GridControl2.Select()
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stok_satis_detay()
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
        If islemstatus = True Then
            If GridView1.RowCount > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunamadý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            Me.Close()
        End If
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ara()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        analiz_musteri_karti()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_musteri_satislar()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_acik_faturalar()
    End Sub
    Private Sub MenuItem16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        DataSet1.Tables(0).Clear()
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, sec_depo.Text, sec_kasatipi.Text, sec_kasakasiyer.Text, sec_harekettipi.Text, sec_fistipi.Text, TimeEdit1.Text, TimeEdit2.Text)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_musteri_hareket_ekstre()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If islemstatus = True Then
                If GridView1.RowCount > 0 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunamadý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
            End If
        End If
    End Sub
    Private Sub MenuItem16_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        detay()
    End Sub
    Private Sub sec_depo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_depo.QueryPopUp
        sec_fistipi.Properties.PopupControl = Nothing
        sec_harekettipi.Properties.PopupControl = Nothing
        sec_kasakasiyer.Properties.PopupControl = Nothing
        sec_depo.Properties.PopupControl = sec_grid
        GridControl2.DataSource = ds_magaza.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_fistipi_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_fistipi.QueryPopUp
        sec_fistipi.Properties.PopupControl = sec_grid
        sec_harekettipi.Properties.PopupControl = Nothing
        sec_kasakasiyer.Properties.PopupControl = Nothing
        sec_depo.Properties.PopupControl = Nothing
        GridControl2.DataSource = ds_fistipi.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_kasakasiyer_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_kasakasiyer.QueryPopUp
        sec_fistipi.Properties.PopupControl = Nothing
        sec_harekettipi.Properties.PopupControl = Nothing
        sec_kasakasiyer.Properties.PopupControl = sec_grid
        sec_depo.Properties.PopupControl = Nothing
        If sec_kasatipi.Text = "Kasa:" Then
            GridControl2.DataSource = ds_kasa.Tables(0)
        ElseIf sec_kasatipi.Text = "Kasiyer:" Then
            GridControl2.DataSource = ds_kasiyer.Tables(0)
        End If
        'GridControl2.DataSource = ds_kasiyer.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_harekettipi_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_harekettipi.QueryPopUp
        sec_fistipi.Properties.PopupControl = Nothing
        sec_harekettipi.Properties.PopupControl = sec_grid
        sec_kasakasiyer.Properties.PopupControl = Nothing
        sec_depo.Properties.PopupControl = Nothing
        GridControl2.DataSource = ds_harekettipi.Tables(0)
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
    Private Sub raporla_pdf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Metin Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyalarý(*.pdf) |*.pdf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub ClosePopup()
        If Not sec_grid.OwnerEdit Is Nothing Then
            sec_grid.OwnerEdit.ClosePopup()
        End If
    End Sub
    Private Sub sec_fistipi_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_fistipi.QueryResultValue
        Dim s As String = deger(ds_fistipi)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub sec_harekettipi_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_harekettipi.QueryResultValue
        Dim s As String = deger(ds_harekettipi)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub sec_kasakasiyer_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_kasakasiyer.QueryResultValue
        Dim s As String = ""
        If sec_kasatipi.Text = "Kasa:" Then
            s = deger(ds_kasa)
        ElseIf sec_kasatipi.Text = "Kasiyer:" Then
            s = deger(ds_kasiyer)
        End If
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub GridView2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        girdi_tutar_hesapla()
    End Sub
    Private Sub MenuItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
    End Sub
    Private Sub sec_depo_QueryCloseUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_depo.QueryCloseUp
    End Sub
    Private Sub GridControl2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl2.KeyDown
        If e.KeyCode = Keys.F4 Then
            ClosePopup()
        ElseIf e.KeyCode = Keys.Escape Then
            ClosePopup()
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        DateEdit1.Focus()
        DateEdit1.SelectAll()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_pdf()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        raporla(0)
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        raporla(1)
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        raporla(2)
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        detay()
    End Sub
    Private Sub detay()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("Sýnýf") = "Satýþlar" Then
                Dim frm As New frm_stok_pesin_liste
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.sKasiyerler = sec_kasakasiyer.Text
                frm.sDepolar = sec_depo.Text
                frm.DateEdit1.EditValue = DateEdit1.EditValue
                frm.DateEdit2.EditValue = DateEdit2.EditValue
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                End If
            ElseIf dr("Sýnýf") = "Ödemeler" Then
                Dim frm As New frm_perakende_odeme_liste
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.status = True
                frm.sKasiyerler = sec_kasakasiyer.Text
                frm.sDepolar = sec_depo.Text
                frm.DateEdit1.EditValue = DateEdit1.EditValue
                frm.DateEdit2.EditValue = DateEdit2.EditValue
                frm.txt_sOdemeSekli.Text = dr("IZAHAT")
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                End If
            End If
        End If
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        GroupControl6.Visible = True
        txt_dteBordroTarihi.EditValue = DateEdit2.EditValue
        sec_sSubeMagaza.Focus()
        sec_sSubeMagaza.Select()
    End Sub
    Private Sub SimpleButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton17.Click
        GroupControl6.Visible = False
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub SimpleButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton18.Click
        If XtraMessageBox.Show(sec_sSubeMagaza.EditValue & " için Kasa Entegrasyonu Ýþlemine Baþlamak Ýstediðinize Emin misiniz?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            'MsgBox("Hazýr Deðil", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            GroupControl6.Visible = False
            GridControl1.Focus()
            GridControl1.Select()
            entegre(sec_sSubeMagaza.EditValue, txt_dteBordroTarihi.EditValue, txt_sAciklama.Text)
        End If
    End Sub
    Private Sub entegre(ByVal sSubeMagaza As String, ByVal dteBordroTarihi As DateTime, ByVal sAciklama As String)
        If sec_bNakitler.Checked = True Then
            Entegre_Nakit(sSubeMagaza, dteBordroTarihi, sAciklama)
        End If
        If sec_bPoslar.Checked = True Or sec_bKesintiDus.Checked = True Then
            entegre_Pos(sSubeMagaza, dteBordroTarihi, sAciklama)
        End If
    End Sub
    Private Sub Entegre_Nakit(ByVal sSubeMagaza As String, ByVal dteBordroTarihi As DateTime, ByVal sAciklama As String)
        ds_OdemeSekli = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbOdeme.sOdemeSekli, tbOdeme.nOdemeTipi,tbOdeme.sAciklama, tbOdeme.nFirmaID,tbFirma.nFirmaID AS nHesapID, tbFirma.nHesapID AS nKesintiHesapID FROM aEmirOdemeSekliFirma tbOdeme INNER JOIN tbFirma ON tbOdeme.KnFirmaID = tbFirma.nFirmaID")) '.Tables(0)
        Dim dr As DataRow
        Dim lNakit As Decimal = 0
        Dim lKredi As Decimal = 0
        Dim sOdemeSekli As String = ""
        Dim sFisTipi As String = "TCG"
        Dim nGirisCikis As Int64 = 1
        'Dim dteBordroTarihi As DateTime = Today
        Dim nBordroID As Int64 = 0
        Dim lBordroNo As Int64 = sorgu_lBordroNo()
        Dim nFirmaID As Int64 = 0
        nBordroID = tbFirmaBordroMaster_kaydet_yeni(dteBordroTarihi, lBordroNo, sFisTipi, nGirisCikis, "", -1, sAciklama, "", "", "", "", "", Now, 0, sSubeMagaza, sHareketTipi)
        For Each dr In DataSet1.Tables(0).Rows
            If dr("Sýnýf").ToString = "Ödemeler" Then
                If dr("IZAHAT").ToString = "N" Then
                    lNakit += dr("col6")
                    nFirmaID = cari_kontrol("100-" & sec_sSubeMagaza.EditValue)
                    tbFirmaBordroDetay_kaydet(nFirmaID, sFisTipi, dr("IZAHAT"), dr("col6"), nBordroID, dteBordroTarihi, lBordroNo, sAciklama, sec_sSubeMagaza.EditValue)
                End If
            End If
        Next
        XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        analiz_fis(nBordroID, sFisTipi, nGirisCikis)
    End Sub
    Private Sub entegre_Pos(ByVal sSubeMagaza As String, ByVal dteBordroTarihi As DateTime, ByVal sAciklama As String)
        ds_OdemeSekli = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbOdeme.sOdemeSekli, tbOdeme.nOdemeTipi,tbOdeme.sAciklama, tbOdeme.nFirmaID,tbFirma.nFirmaID AS nHesapID, tbFirma.nHesapID AS nKesintiHesapID FROM aEmirOdemeSekliFirma tbOdeme INNER JOIN tbFirma ON tbOdeme.KnFirmaID = tbFirma.nFirmaID")) '.Tables(0)
        Dim dr As DataRow
        Dim lNakit As Decimal = 0
        Dim lKredi As Decimal = 0
        Dim sOdemeSekli As String = ""
        Dim sFisTipi As String = "TCC"
        Dim nGirisCikis As Int64 = 3
        'Dim dteBordroTarihi As DateTime = Today
        Dim nBordroID As Int64 = 0
        Dim lBordroNo As Int64 = sorgu_lBordroNo()
        Dim nFirmaID As Int64 = 0
        nBordroID = tbFirmaBordroMaster_kaydet_yeni(dteBordroTarihi, lBordroNo, sFisTipi, nGirisCikis, "", -1, sAciklama, "", "", "", "", "", Now, 0, sSubeMagaza, sHareketTipi)
        For Each dr In DataSet1.Tables(0).Rows
            If dr("Sýnýf").ToString = "Ödemeler" Then
                If dr("IZAHAT").ToString = "N" Then

                ElseIf dr("IZAHAT").ToString = "" Then
                Else
                    nOdemeTipi = 0
                    sOdemeSekli = dr("IZAHAT").ToString
                    nKesintiHesaplari(dr("IZAHAT").ToString)
                    If nOdemeTipi = 2 Then
                        lKredi = sorgu_sayi(dr("col6"), 0)
                        nFirmaID = nBankaFirmaID
                        If sec_bKesintiDus.Checked = True Then
                            Dim lKesinti As Decimal = tbAVTaksitKart_Olustur(sOdemeSekli, lKredi, dteBordroTarihi)
                            If lKesinti = 0 Then
                                tbFirmaBordroDetay_kaydet(nFirmaID, sFisTipi, dr("IZAHAT"), dr("col6"), nBordroID, dteBordroTarihi, lBordroNo, sAciklama, sec_sSubeMagaza.EditValue)
                            Else
                                nFirmaID = nBankaFirmaID
                                tbFirmaBordroDetay_kaydet(nFirmaID, sFisTipi, dr("IZAHAT"), lKredi - lKesinti, nBordroID, dteBordroTarihi, lBordroNo, sAciklama, sec_sSubeMagaza.EditValue)
                                nFirmaID = nKesintiFirmaID
                                tbFirmaBordroDetay_kaydet(nFirmaID, sFisTipi, dr("IZAHAT"), lKesinti, nBordroID, dteBordroTarihi, lBordroNo, sAciklama, sec_sSubeMagaza.EditValue)
                            End If
                        Else
                            tbFirmaBordroDetay_kaydet(nFirmaID, sFisTipi, dr("IZAHAT"), dr("col6"), nBordroID, dteBordroTarihi, lBordroNo, sAciklama, sec_sSubeMagaza.EditValue)
                        End If
                    End If
                End If
            End If
        Next
        XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        analiz_fis(nBordroID, sFisTipi, nGirisCikis)
    End Sub
    Private Sub analiz_fis(ByVal nBordroID As Int64, ByVal sFisTipi As String, ByVal nGirisCikis As Int64)
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_tbFirmaBordro
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.sFisTipi = sFisTipi
        frm.nGirisCikis = nGirisCikis
        frm.nBordroID = nBordroID
        frm.sFisTipi = sFisTipi
        frm.nGirisCikis = nGirisCikis
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()

        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub tbFirmaBordroDetay_kaydet(ByVal nFirmaID As Int64, ByVal sFisTipi As String, ByVal sCariIslem As String, ByVal lTutar As Decimal, ByVal nBordroID As Int64, ByVal dteBordroTarihi As DateTime, ByVal lBordroNo As Int64, ByVal sAciklama As String, ByVal sSubeMagaza As String)
        Dim nHareketID As Int64 = sorgu_nCariHareketID()
        Dim nKasaIslemID As String = ""
        Dim nBordroSatirID As String = ""
        sAciklama = dteBordroTarihi & "\" & sAciklama
        Dim sEvrakNo As String = lBordroNo
        Dim nHesapID As Int64 = 0
        Try
            sorgula_nStokID("INSERT INTO tbCariIslem                       (sCariIslem, sAciklama) VALUES     ('" & sCariIslem & "', '')")
        Catch ex As Exception
        End Try
        If sCariIslem = "N" Then
            nKasaIslemID = sorgu_nKasaIslemID()
        Else
            nKasaIslemID = ""
        End If
        Dim lBorcTutar As Decimal = 0
        Dim lAlacakTutar As Decimal = 0
        If Trim(sFisTipi) = "TCG" Then
            lBorcTutar = 0
            lAlacakTutar = lTutar
        ElseIf Trim(sFisTipi) = "TCC" Then
            lBorcTutar = lTutar
            lAlacakTutar = 0
        End If
        tbFirmaBordroDetay_kaydet_yeni(0, nBordroID, nHareketID, nKasaIslemID, nBordroSatirID, nFirmaID, dteBordroTarihi, dteBordroTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, 0, sFisTipi, sHareketTipi, kullaniciadi, Now, "", 0, 0, "", 0, 0, kullaniciadi, Now)
        nHareketID = tbFirmaHareketi_kaydet_yeni(nHareketID, nFirmaID, dteBordroTarihi, dteBordroTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, 0, sFisTipi, sHareketTipi, kullaniciadi, Now, "", 0, 0, "", 0, 0, kullaniciadi, Now)
        nCariHareketID_degistir(nHareketID)
        If sCariIslem = "N" Then
            nKasaIslemID = tbNakitKasa_kaydet_yeni(nKasaIslemID, sSubeMagaza, dteBordroTarihi, lAlacakTutar, lBorcTutar, sAciklama, nHareketID, nFirmaID, nHesapID, sFisTipi, sHareketTipi, kullaniciadi, Now, 0, "", "", 0, 0, "", 0, 0, kullaniciadi, Now)
        Else
            nKasaIslemID = ""
        End If
    End Sub
    Private Sub nCariHareketID_degistir(ByVal nCariHareketID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = '" & nCariHareketID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_nCariHareketID() As Int64
        Dim kriter As String = ""
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nHareketID), 0) + 1 AS nCariHareketID FROM         tbFirmaHareketi")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        con.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        cmd = Nothing
    End Function
    Public Function sorgu_lBordroNo() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(lBordroNo + 1, 1) AS lBordroNo FROM tbCekSenetBordro ORDER BY lBordroNo DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_nKasaIslemID() As Int64
        'Dim kriter As String = ""
        ''kriter = "WHERE (sKodu = '" & kod & "')  "
        'Dim conn As New OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim adapter As New OleDb.OleDbDataAdapter
        ''MsgBox(connection_resmi)
        'conn.ConnectionString = sConnection
        'cmd.Connection = conn
        'conn.Open()
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      ISNULL(MAX(nKasaIslemID) + 1, 0) AS nKasaIslemID  FROM         tbNakitKasa ")
        'Dim kayitsayisi = cmd.ExecuteScalar
        ''cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nSonID,0) + 1 AS nKasaIslemID FROM         tbCariSiraNo WHERE     (nSiraIndex = 2)")
        ''Dim kayitsayisi = cmd.ExecuteScalar
        'If kayitsayisi = 0 Then
        '    kayitsayisi = 1
        'End If
        'Return kayitsayisi
        Return 1
    End Function
    Private Sub nKesintiHesaplari(ByVal sOdemeSekli As String)
        Dim dr As DataRow
        For Each dr In ds_OdemeSekli.Tables(0).Rows
            If Trim(dr("sOdemeSekli")) = Trim(sOdemeSekli) Then
                nOdemeTipi = dr("nOdemeTipi")
                nBankaFirmaID = dr("nFirmaID")
                nKesintiFirmaID = dr("nHesapID")
                nKesintiHesapID = dr("nKesintiHesapID")
            End If
        Next
    End Sub
    Private Function cari_kontrol(ByVal sKodu As String) As Int64
        Dim cari_kayit_sayisi As Int64 = 0
        Dim nFirmaID As Int64 = 0
        cari_kayit_sayisi = sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select ISNULL(nFirmaID,0) from tbFirma Where sKodu = '" & sKodu & "'")
        If cari_kayit_sayisi = 0 Then
            nFirmaID = firma_kaydet_yeni(sKodu, "Kasiyer Kasalarý", 0, 0, "01/01/1900", 0, "", "", "", "", "", "", "", "", "", 0, "", kullanici, Now, "")
            firma_siniflari_kaydet_yeni(nFirmaID, "", "", "", "", "")
        Else
            nFirmaID = cari_kayit_sayisi
        End If
        Return nFirmaID
    End Function
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
    Private Function tbFirmaBordroMaster_kaydet_yeni(ByVal dteBordroTarihi As DateTime, ByVal lBordroNo As Int64, ByVal sFisTipi As String, ByVal nGirisCikis As Integer, ByVal sSaticiRumuzu As String, ByVal nFirmaID As Integer, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal sKullanici As String, ByVal dteKayitTarihi As DateTime, ByVal bKilitli As Byte, ByVal sSubeMagaza As String, ByVal sHareketTipi As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim nKayitNo As Integer = 0
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaBordroMaster (dteBordroTarihi, lBordroNo, sFisTipi, nGirisCikis, sSaticiRumuzu, nFirmaID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, sKullanici,  dteKayitTarihi,bKilitli,sSubeMagaza,sHareketTipi) VALUES     ('" & dteBordroTarihi & "', " & lBordroNo & ", '" & sFisTipi & "', " & nGirisCikis & ", '" & sSaticiRumuzu & "', " & nFirmaID & ", '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "', '" & sKullanici & "', '" & dteKayitTarihi & "'," & bKilitli & ",'" & sSubeMagaza & "','" & sHareketTipi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nKayitNo = cmd.ExecuteScalar
        Return nKayitNo
        con.Close()
    End Function
    Private Function tbFirmaBordroDetay_kaydet_yeni(ByVal nKayitID As Int64, ByVal nBordroID As Int64, ByVal nHareketID As String, ByVal nKasaIslemID As String, ByVal nBordroSatirID As String, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim nKayitNo As Int64 = 0
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbFirmaBordroDetay                       (nBordroID,nHareketID,nKasaIslemID,nBordroSatirID,nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     (" & nBordroID & ",'" & nHareketID & "' ,'" & nKasaIslemID & "','" & nBordroSatirID & "','" & nFirmaID & "', '" & dteIslemTarihi & "', '" & dteValorTarihi & "', '" & sCariIslem & "', N'" & sAciklama & "', " & lBorcTutar & ", " & lAlacakTutar & " , '" & sEvrakNo & "', " & lVadeFarki & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & " , '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & " , '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nKayitNo = cmd.ExecuteScalar
        con.Close()
        Return nKayitNo
    End Function
    Private Function tbNakitKasa_kaydet_yeni(ByVal nKasaIslemID As Int64, ByVal sSube As String, ByVal dteIslemTarihi As DateTime, ByVal lTahsilTutar As Decimal, ByVal lTediyeTutar As Decimal, ByVal sAciklama As String, ByVal nCariHareketID As String, ByVal nFirmaID As Int64, ByVal nHesapID As Int64, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bMuhasebeyeIslendimi As Byte, ByVal sMasrafYontemi As String, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, Optional ByVal nCekSenetIslem As Integer = 1) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If nCekSenetIslem = 11 Then
            nCariHareketID = "NULL"
        End If
        sAciklama = Microsoft.VisualBasic.Left(sAciklama, 59)
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbNakitKasa ( sSube, dteIslemTarihi, lTahsilTutar, lTediyeTutar, sAciklama, nCariHareketID, nFirmaID, nHesapID, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, bMuhasebeyeIslendimi, sMasrafYontemi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ( '" & sSube & "', '" & dteIslemTarihi & "', " & lTahsilTutar & ", " & lTediyeTutar & ", N'" & sAciklama & "', " & nCariHareketID & ", " & nFirmaID & ", " & nHesapID & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bMuhasebeyeIslendimi & ", '" & sMasrafYontemi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nKasaIslemID = cmd.ExecuteScalar
        Return nKasaIslemID
        con.Close()
        nKasaIslemID_degistir(nKasaIslemID)
    End Function
    Private Sub nKasaIslemID_degistir(ByVal nKasaIslemID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = '" & nKasaIslemID & "' where nSiraIndex = 2")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Function tbFirmaHareketi_kaydet_yeni(ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'If Trim(sCariIslem) = "" Then
        '    sHangiUygulama = 'sFisTipi
        'End If
        If Trim(sDovizCinsi2) <> "" Then
            If lDovizKuru2 = 0 Then
                lDovizKuru2 = 1
            End If
            sDovizCinsi1 = sDovizCinsi2
            lDovizKuru1 = lDovizKuru2
            lDovizMiktari1 = lDovizMiktari2
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbFirmaHareketi                       (nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nFirmaID & "', '" & dteIslemTarihi & "', '" & dteValorTarihi & "', '" & sCariIslem & "', N'" & sAciklama & "', " & lBorcTutar & ", " & lAlacakTutar & " , '" & sEvrakNo & "', " & lVadeFarki & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & " , '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & " , '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nHareketID = cmd.ExecuteScalar
        Return nHareketID
        con.Close()
    End Function
    Private Function tbAVTaksitKart_Olustur(ByVal sOdemeSekli As String, ByVal lOdemeTutar As Decimal, ByVal dteFisTarihi As DateTime) As Decimal
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        Dim ds_tbBankaOdemeSekli As DataSet = sorgu(sorgu_query("SET              DATEFIRST 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *,0 as nSatisGun FROM         tbBankaOdemeSekli Where sOdemeSekli = '" & sOdemeSekli & "'"))
        Dim dr As DataRow
        Dim lKesinti As Decimal = 0
        For Each dr In ds_tbBankaOdemeSekli.Tables(0).Rows
            Dim i As Integer
            Dim dteTarihi As DateTime
            Dim TaksitSayisi As Int64 = dr("nTaksitSayisi")
            Dim nTaksitID As String = ""
            Dim dteBaslangic As DateTime = dteFisTarihi
            Dim lTaksitTutari As Decimal = 0
            Dim lIadeTutari As Decimal = 0
            Dim lPuan As Decimal = 0
            Dim lPuanKdv As Decimal = 0
            Dim lServisBedeli As Decimal = 0
            Dim lKomisyonTutari As Decimal = 0
            Dim lKomisyonTutari2 As Decimal = 0
            Dim lKomisyon As Decimal = 0
            Dim lIadeTutar As Decimal = 0
            Dim lNetTutar As Decimal = 0
            Dim bEkle As Boolean = True
            Dim nEkle As Integer = 0
            If lOdemeTutar > 0 Then
                lTaksitTutari = lOdemeTutar / TaksitSayisi
                lIadeTutar = 0
            ElseIf lOdemeTutar < 0 Then
                lIadeTutari = lOdemeTutar / TaksitSayisi
                lTaksitTutari = 0
            End If
            dteTarihi = dteBaslangic
            dr("nSatisGun") = dteFisTarihi.Day
            'Satis Gunu Protokol Kontrolu
            'Cuma
            If dr("nSatisGun") = 5 Then
                If dr("bS_Cuma_Pazar") = False And dr("bs_Cuma_Pazartesi") = False Then
                    dteTarihi = dteBaslangic
                ElseIf dr("bS_Cuma_Pazar") = True And dr("bs_Cuma_Pazartesi") = True Then
                    dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    bEkle = False
                ElseIf dr("bS_Cuma_Pazar") = True And dr("bs_Cuma_Pazartesi") = False Then
                    dteTarihi = DateAdd(DateInterval.Day, 2, dteTarihi)
                    bEkle = False
                ElseIf dr("bS_Cuma_Pazar") = False And dr("bs_Cuma_Pazartesi") = True Then
                    dteTarihi = DateAdd(DateInterval.Day, 3, dteTarihi)
                    bEkle = False
                End If
                dteBaslangic = dteTarihi
                'Cumartesi
            ElseIf dr("nSatisGun") = 6 Then
                If dr("bS_Cumartesi_Pazar") = False And dr("bS_Cumartesi_Pazartesi") = False Then
                    dteTarihi = dteBaslangic
                ElseIf dr("bS_Cumartesi_Pazar") = True And dr("bS_Cumartesi_Pazartesi") = False Then
                    dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    bEkle = False
                ElseIf dr("bS_Cumartesi_Pazar") = False And dr("bS_Cumartesi_Pazartesi") = True Then
                    dteTarihi = DateAdd(DateInterval.Day, 2, dteTarihi)
                    bEkle = False
                End If
                dteBaslangic = dteTarihi
                'Pazar
            ElseIf dr("nSatisGun") = 7 Then
                If dr("bS_Pazar_Pazartesi") = False Then
                    dteTarihi = dteBaslangic
                ElseIf dr("bS_Pazar_Pazartesi") = True Then
                    dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    bEkle = False
                End If
                dteBaslangic = dteTarihi
            End If
            dteBaslangic = dteTarihi
            'Taksit Hesapla
            For i = 1 To TaksitSayisi
                'Bonus Hesapla
                If dr("nBonusOrani") <> 0 Then
                    lPuan = (lOdemeTutar * dr("nBonusOrani")) / 100
                    If dr("nBonus_KdvOrani") <> 0 Then
                        lPuanKdv = (lPuan * dr("nBonus_KdvOrani")) / 100
                    End If
                End If
                'Komisyon Hesapla
                If dr("nKomisyonOrani") <> 0 Then
                    lKomisyonTutari = (lTaksitTutari * dr("nKomisyonOrani")) / 100
                    If dr("nKomisyon_Kdv_Orani") <> 0 Then
                        lKomisyonTutari += (lKomisyonTutari * dr("nKomisyon_Kdv_Orani")) / 100
                    End If
                End If
                lKomisyon = lKomisyonTutari
                'Ek Komisyon Hesapla
                If dr("nKomisyonOrani_2") <> 0 Then
                    If dr("nKomisyonOrani_2_Aciklama") = 0 Then
                        lKomisyonTutari2 += (lOdemeTutar * dr("nKomisyonOrani_2")) / 100
                    ElseIf dr("nKomisyonOrani_2_Aciklama") = 1 Then
                    ElseIf dr("nKomisyonOrani_2_Aciklama") = 2 Then
                        lKomisyonTutari2 += ((lOdemeTutar - lKomisyonTutari) * dr("nKomisyonOrani_2")) / 100
                    End If
                End If
                'Taksit Protokol Kontrolu
                If i > 1 Then
                    If dr("nTaksit") = 2 Then
                        If dr("bTaksit_Satis") = 0 Then
                            If dr("nTaksit" & i & "") <> 0 Then
                                dteTarihi = DateAdd(DateInterval.Day, dr("nTaksit" & i & ""), dteTarihi)
                            Else
                                dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                            End If
                        ElseIf dr("bTaksit_Satis") <> 0 Then
                            If dr("nTaksit" & i & "") <> 0 Then
                                dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                            Else
                                dteTarihi = DateAdd(DateInterval.Month, i, dr("dteKayitTarihi"))
                            End If
                        End If
                    Else
                        dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                    End If
                    If dr("nBonus_Puan") = 0 Then
                        lPuan = 0
                        lPuanKdv = 0
                    ElseIf dr("nBonus_Puan") = 2 Then
                        lPuan = 0
                        lPuanKdv = 0
                    ElseIf dr("nBonus_Puan") = 3 Then
                        lPuan = 0
                        lPuanKdv = 0
                    End If
                    If dr("bKomisyon_IlkTaksit") = 1 Then
                        lKomisyonTutari = 0
                    End If
                    'ElseIf i = 2 Then
                    '    dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                    '    'If bEkle = True Then
                    '    '    dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    '    'End If
                ElseIf i = 1 Then
                    'Ýlk Taksit
                    lKomisyonTutari += lKomisyonTutari2
                    If dr("nTaksit") = 0 Then
                        Dim gun As Integer = 0
                        Dim ay As Integer = 0
                        Dim yil As Integer = 0
                        gun = dteTarihi.Day
                        ay = dteTarihi.Month
                        yil = dteTarihi.Year
                        If gun > 0 And dteTarihi.Day <= dr("nAlisGun1") Then
                            If dr("bS_Bulundugu_Ay1") = 0 Then
                                dteTarihi = dr("nTaksitGun1").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay1") = 1 Then
                                dteTarihi = dr("nTaksitGun1").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay1") = 2 Then
                                dteTarihi = dr("nTaksitGun1").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        ElseIf gun >= dr("nAlisGun1") And gun <= dr("nAlisGun2") Then
                            If dr("bS_Bulundugu_Ay2") = 0 Then
                                dteTarihi = dr("nTaksitGun2").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay2") = 1 Then
                                dteTarihi = dr("nTaksitGun2").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay2") = 2 Then
                                dteTarihi = dr("nTaksitGun2").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        ElseIf gun >= dr("nAlisGun2") And gun <= dr("nAlisGun3") Then
                            If dr("bS_Bulundugu_Ay3") = 0 Then
                                dteTarihi = dr("nTaksitGun3").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay3") = 1 Then
                                dteTarihi = dr("nTaksitGun3").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay3") = 2 Then
                                dteTarihi = dr("nTaksitGun3").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        ElseIf gun >= dr("nAlisGun3") And gun <= dr("nAlisGun4") Then
                            If dr("bS_Bulundugu_Ay4") = 0 Then
                                dteTarihi = dr("nTaksitGun4").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay4") = 1 Then
                                dteTarihi = dr("nTaksitGun4").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay4") = 2 Then
                                dteTarihi = dr("nTaksitGun4").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        ElseIf gun >= dr("nAlisGun4") And gun <= dr("nAlisGun5") Then
                            If dr("bS_Bulundugu_Ay5") = 0 Then
                                dteTarihi = dr("nTaksitGun5").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay5") = 1 Then
                                dteTarihi = dr("nTaksitGun5").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay5") = 2 Then
                                dteTarihi = dr("nTaksitGun5").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        ElseIf gun >= dr("nAlisGun5") And gun <= dr("nAlisGun6") Then
                            If dr("bS_Bulundugu_Ay6") = 0 Then
                                dteTarihi = dr("nTaksitGun6").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay6") = 1 Then
                                dteTarihi = dr("nTaksitGun6").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay6") = 2 Then
                                dteTarihi = dr("nTaksitGun6").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        End If
                    ElseIf dr("nTaksit") = 1 Then
                        dteTarihi = DateAdd(DateInterval.Day, dr("nIlkTaksitSonra"), dteBaslangic)
                    ElseIf dr("nTaksit") = 2 Then
                        If dr("bTaksit_Satis") = 0 Then
                            'dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                            dteTarihi = DateAdd(DateInterval.Day, dr("nTaksit1"), dteBaslangic)
                        ElseIf dr("bTaksit_Satis") = 1 Then
                            'MsgBox(dteBaslangic)
                            'If bEkle = True Then
                            If dr("nSatisGun") = 5 Then
                                dteTarihi = DateAdd(DateInterval.Day, 2, dr("dteOdemeTarihi"))
                                nEkle = 2
                            ElseIf dr("nSatisGun") = 6 Then
                                dteTarihi = DateAdd(DateInterval.Day, 1, dr("dteOdemeTarihi"))
                                nEkle = 1
                            ElseIf dr("nSatisGun") = 7 Then
                                dteTarihi = DateAdd(DateInterval.Day, 0, dr("dteOdemeTarihi"))
                                nEkle = 0
                            End If
                            'End If
                            dteTarihi = DateAdd(DateInterval.Day, dr("nTaksit1"), dteTarihi)
                        ElseIf dr("bTaksit_Satis") = 2 Then
                            dteTarihi = DateAdd(DateInterval.Day, dr("nTaksit1"), dr("dteOdemeTarihi"))
                        End If
                    ElseIf dr("nTaksit") = 3 Then
                        dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                        dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    End If
                End If
                'Servis Bedeli Hesapla
                If dr("nBSMV") <> 0 Then
                    If dr("bServisAlisveristen") = 0 Then
                        lServisBedeli = (lKomisyon * dr("nBSMV")) / 1000
                    ElseIf dr("bServisAlisveristen") = 1 Then
                        lServisBedeli = (lKomisyonTutari * dr("nBSMV")) / 1000
                    ElseIf dr("bServisAlisveristen") = 2 Then
                        lServisBedeli = (lTaksitTutari * dr("nBSMV")) / 100
                    End If
                End If
                'Puan Protokol Kontrolu
                If dr("nBonus_Puan") = 2 Then
                    lPuan = 0
                    lPuanKdv = 0
                ElseIf dr("nBonus_Puan") = 3 Then
                    lPuan = 0
                    lPuanKdv = 0
                End If
                'Taksit Gunu Kontrolu
                If dteTarihi.DayOfWeek = DayOfWeek.Saturday Then
                    If dr("bT_Cumartesi_Pazartesi") = True Then
                        dteTarihi = DateAdd(DateInterval.Day, 2, dteTarihi)
                        nEkle = 2
                    End If
                ElseIf dteTarihi.DayOfWeek = DayOfWeek.Sunday Then
                    If dr("bT_Pazar_Pazartesi") = True Then
                        dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                        nEkle = 1
                    End If
                End If
                'Ekle
                'tbAVTaksitKart_kaydet_ekle(dr("nOdemeID"), dr("sOdemeSekli"), dteTarihi, lTaksitTutari, lIadeTutari, lPuan, lPuanKdv, lServisBedeli, lKomisyonTutari, 0, kullanici, "01/01/1900", kullanici, Today)
                'If dr("nTaksit") <> 3 Then
                '    If nEkle > 0 Then
                '        dteTarihi = DateAdd(DateInterval.Day, -nEkle, dteTarihi)
                '        nEkle = 0
                '    End If
                'End If
                If dr("nTaksit") = 2 Then
                    If dr("bTaksit_Satis") = 1 Or dr("bTaksit_Satis") = 2 Then
                        If nEkle > 0 Then
                            dteTarihi = DateAdd(DateInterval.Day, -nEkle, dteTarihi)
                            nEkle = 0
                        End If
                    End If
                ElseIf dr("nTaksit") = 0 Then
                    If nEkle > 0 Then
                        dteTarihi = DateAdd(DateInterval.Day, -nEkle, dteTarihi)
                        nEkle = 0
                    End If
                End If
                'Taksit Protokol Kontrolu
                'If i = 1 Then
                '    If bEkle = True Then
                '        dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                '    End If
                'ElseIf i = 2 Then
                '    If bEkle = True Then
                '        dteTarihi = DateAdd(DateInterval.Day, -1, dteTarihi)
                '    End If
                'End If
            Next
            'Bonus Hesapla
            If dr("nBonusOrani") <> 0 Then
                lPuan = (lOdemeTutar * dr("nBonusOrani")) / 100
                If dr("nBonus_KdvOrani") <> 0 Then
                    lPuanKdv = (lPuan * dr("nBonus_KdvOrani")) / 100
                End If
            End If
            If dr("nBonus_Puan") = 2 Then
                'tbAVTaksitKart_kaydet_ekle(dr("nOdemeID"), dr("sOdemeSekli"), dr("dteOdemeTarihi"), 0, 0, lPuan, lPuanKdv, 0, 0, 0, kullanici, "01/01/1900", kullanici, Today)
                'lbl_lPuan.Text = lPuan
                'lbl_lPuanKdv.Text = lPuanKdv
            ElseIf dr("nBonus_Puan") = 3 Then
                'tbAVTaksitKart_kaydet_ekle(dr("nOdemeID"), dr("sOdemeSekli"), DateAdd(DateInterval.Day, 1, dr("dteOdemeTarihi")), 0, 0, lPuan, lPuanKdv, 0, 0, 0, kullanici, "01/01/1900", kullanici, Today)
                'lbl_lPuan.Text = lPuan
                'lbl_lPuanKdv.Text = lPuanKdv
            End If
            'lbl_dteTarih.Text = dteTarihi
            'lbl_lTaksitTutari.Text = Format(lTaksitTutari, "#,0.00")
            'lbl_lIadeTutari.Text = Format(lIadeTutar, "#,0.00")
            'lbl_lPuan.Text = Format(lPuan, "#,0.00")
            'lbl_lPuanKdv.Text = Format(lPuanKdv, "#,0.00")
            'lbl_lServisBedeli.Text = Format(lServisBedeli, "#,0.00")
            'lbl_lKomisyonTutari.Text = Format(lKomisyonTutari, "#,0.00")
            lNetTutar = lOdemeTutar - (lPuan + lPuanKdv + lServisBedeli + lKomisyonTutari)
            lKesinti = lOdemeTutar - lNetTutar
            'lbl_lNetTutar.Text = Format(lNetTutar, "#,0.00##")
        Next
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
        Return lKesinti
    End Function
End Class
