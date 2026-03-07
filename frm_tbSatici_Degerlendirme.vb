Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_tbSatici_Degerlendirme
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
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
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
    Friend WithEvents colSINIF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents collBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSenetRisk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCekRisk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTahsilat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collSatis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collIade As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMaliyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collOran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collSiparisMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collSiparisTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collSiparisDahilTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collSonBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_depo As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents sec_grid As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sSatici As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
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
    Friend WithEvents colsAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnPrim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collSabitPrim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPrim1Baslangic As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPrim1Bitis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPrim1Oran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPrim2Baslangic As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPrim2Bitis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPrim2Oran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPrim3Baslangic As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPrim3Bitis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPrim3Oran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPrim4Baslangic As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPrim4Bitis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPrim4Oran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPrim5Baslangic As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPrim5Bitis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPrim5Oran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPrim1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPrim2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPrim3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPrim4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collPrim5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNetPrim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collGecikenBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_nVadeFarki As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nGun2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_nGun1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents collGecikenKesinti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_nIslem As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colISKONTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_DC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_FS As DevExpress.XtraEditors.CheckEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_tbSatici_Degerlendirme))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.collOran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_DC = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_FS = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_nIslem = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_nVadeFarki = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nGun2 = New DevExpress.XtraEditors.TextEdit()
        Me.txt_nGun1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_depo = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.sec_grid = New DevExpress.XtraEditors.PopupContainerControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSEC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSINIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBakiye = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSenetRisk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCekRisk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collTahsilat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collSatis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collIade = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMaliyet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collSiparisMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collSiparisTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collSiparisDahilTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collSonBakiye = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSoyadi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnPrim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collSabitPrim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPrim1Baslangic = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPrim1Bitis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPrim1Oran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPrim2Baslangic = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPrim2Bitis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPrim2Oran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPrim3Baslangic = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPrim3Bitis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPrim3Oran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPrim4Baslangic = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPrim4Bitis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPrim4Oran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPrim5Baslangic = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPrim5Bitis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPrim5Oran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPrim1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPrim2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPrim3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPrim4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collPrim5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNetPrim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collGecikenBakiye = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collGecikenKesinti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISKONTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSatici = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_DC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_FS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_nIslem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nVadeFarki.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nGun2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nGun1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sec_grid.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSatici, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'collOran
        '
        Me.collOran.Caption = "Marj"
        Me.collOran.DisplayFormat.FormatString = "P"
        Me.collOran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collOran.FieldName = "lOran"
        Me.collOran.Name = "collOran"
        Me.collOran.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.collOran.Visible = True
        Me.collOran.VisibleIndex = 11
        Me.collOran.Width = 60
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Controls.Add(Me.lbl_istihbarat)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 106)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_DC)
        Me.GroupControl1.Controls.Add(Me.sec_FS)
        Me.GroupControl1.Controls.Add(Me.sec_nIslem)
        Me.GroupControl1.Controls.Add(Me.txt_nVadeFarki)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.txt_nGun2)
        Me.GroupControl1.Controls.Add(Me.txt_nGun1)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.sec_depo)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(681, 102)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Text = "Ara"
        '
        'sec_DC
        '
        Me.sec_DC.Location = New System.Drawing.Point(406, 44)
        Me.sec_DC.Name = "sec_DC"
        Me.sec_DC.Properties.Caption = "DC"
        Me.sec_DC.Size = New System.Drawing.Size(44, 19)
        Me.sec_DC.TabIndex = 43
        '
        'sec_FS
        '
        Me.sec_FS.EditValue = True
        Me.sec_FS.Location = New System.Drawing.Point(370, 44)
        Me.sec_FS.Name = "sec_FS"
        Me.sec_FS.Properties.Caption = "FS"
        Me.sec_FS.Size = New System.Drawing.Size(36, 19)
        Me.sec_FS.TabIndex = 42
        '
        'sec_nIslem
        '
        Me.sec_nIslem.EditValue = "Satış"
        Me.sec_nIslem.EnterMoveNextControl = True
        Me.sec_nIslem.Location = New System.Drawing.Point(244, 65)
        Me.sec_nIslem.Name = "sec_nIslem"
        Me.sec_nIslem.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_nIslem.Properties.Items.AddRange(New Object() {"Satış", "Hesap"})
        Me.sec_nIslem.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_nIslem.Size = New System.Drawing.Size(50, 20)
        Me.sec_nIslem.TabIndex = 34
        '
        'txt_nVadeFarki
        '
        Me.txt_nVadeFarki.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nVadeFarki.EnterMoveNextControl = True
        Me.txt_nVadeFarki.Location = New System.Drawing.Point(193, 65)
        Me.txt_nVadeFarki.Name = "txt_nVadeFarki"
        Me.txt_nVadeFarki.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nVadeFarki.Size = New System.Drawing.Size(52, 20)
        Me.txt_nVadeFarki.TabIndex = 30
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.Location = New System.Drawing.Point(102, 69)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl8.TabIndex = 32
        Me.LabelControl8.Text = "ve"
        '
        'txt_nGun2
        '
        Me.txt_nGun2.EditValue = "9999"
        Me.txt_nGun2.EnterMoveNextControl = True
        Me.txt_nGun2.Location = New System.Drawing.Point(120, 65)
        Me.txt_nGun2.Name = "txt_nGun2"
        Me.txt_nGun2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_nGun2.Properties.Appearance.Options.UseFont = True
        Me.txt_nGun2.Properties.MaxLength = 15
        Me.txt_nGun2.Size = New System.Drawing.Size(36, 20)
        Me.txt_nGun2.TabIndex = 29
        '
        'txt_nGun1
        '
        Me.txt_nGun1.EditValue = "0"
        Me.txt_nGun1.EnterMoveNextControl = True
        Me.txt_nGun1.Location = New System.Drawing.Point(56, 65)
        Me.txt_nGun1.Name = "txt_nGun1"
        Me.txt_nGun1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_nGun1.Properties.Appearance.Options.UseFont = True
        Me.txt_nGun1.Properties.MaxLength = 15
        Me.txt_nGun1.Size = New System.Drawing.Size(40, 20)
        Me.txt_nGun1.TabIndex = 28
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.Location = New System.Drawing.Point(6, 67)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl9.TabIndex = 31
        Me.LabelControl9.Text = "Gecikme:"
        '
        'sec_depo
        '
        Me.sec_depo.EditValue = "[Tümü]"
        Me.sec_depo.EnterMoveNextControl = True
        Me.sec_depo.Location = New System.Drawing.Point(293, 65)
        Me.sec_depo.Name = "sec_depo"
        Me.sec_depo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo.Properties.ShowPopupCloseButton = False
        Me.sec_depo.Size = New System.Drawing.Size(75, 20)
        Me.sec_depo.TabIndex = 6
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(6, 42)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl4.TabIndex = 14
        Me.LabelControl4.Text = "Firma:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(296, 24)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "Arasındaki"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(163, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(12, 13)
        Me.LabelControl1.TabIndex = 12
        Me.LabelControl1.Text = "ve"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(5, 24)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Tarih:"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = New Date(2007, 6, 16, 19, 41, 57, 199)
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(192, 21)
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
        Me.DateEdit1.Location = New System.Drawing.Point(56, 21)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Kodu"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(193, 43)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Kodu", "Adı", "Adres", "İstihbarat", "Sınıf1", "Sınıf2", "Sınıf3", "Sınıf4", "Sınıf5"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(100, 20)
        Me.sec_konum.TabIndex = 3
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = Global.business_smart.My.Resources.Resources.find
        Me.SimpleButton3.Location = New System.Drawing.Point(367, 65)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 20)
        Me.SimpleButton3.TabIndex = 7
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Başlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(293, 43)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Başlar", "Biter", "Eşittir", "İçerir", "Boş", "Dolu", "Farklı", "Büyük", "Küçük", "Aralık"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(75, 20)
        Me.sec_kriter.TabIndex = 4
        '
        'txt_ara
        '
        Me.txt_ara.EditValue = "120"
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(56, 43)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(137, 20)
        Me.txt_ara.TabIndex = 2
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.Location = New System.Drawing.Point(158, 69)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl10.TabIndex = 33
        Me.LabelControl10.Text = "VFarki:"
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
        Me.PictureBox1.Size = New System.Drawing.Size(94, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(777, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(45, 13)
        Me.lbl_istihbarat.TabIndex = 38
        Me.lbl_istihbarat.Text = "istihbarat"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 359)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*** Kayıt Bulunamadı...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = Global.business_smart.My.Resources.Resources.button_cancel
        Me.SimpleButton2.Location = New System.Drawing.Point(738, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = Global.business_smart.My.Resources.Resources.button_ok
        Me.SimpleButton1.Location = New System.Drawing.Point(663, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.sec_grid)
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 106)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 253)
        Me.PanelControl3.TabIndex = 0
        '
        'sec_grid
        '
        Me.sec_grid.Controls.Add(Me.GridControl2)
        Me.sec_grid.Location = New System.Drawing.Point(284, 74)
        Me.sec_grid.Name = "sec_grid"
        Me.sec_grid.Size = New System.Drawing.Size(256, 128)
        Me.sec_grid.TabIndex = 5
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(256, 128)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSEC, Me.colKOD, Me.GridColumn1})
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
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
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Açıklama"
        Me.GridColumn1.FieldName = "ACIKLAMA"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowFocus = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 128
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
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sSatici})
        Me.GridControl1.Size = New System.Drawing.Size(820, 249)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem15, Me.MenuItem16, Me.MenuItem19, Me.MenuItem18, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem17, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem16.Text = "İletişim Bilgileri"
        '
        'MenuItem19
        '
        Me.MenuItem19.Enabled = False
        Me.MenuItem19.Index = 4
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem19.Text = "Firma Kartı"
        '
        'MenuItem18
        '
        Me.MenuItem18.Enabled = False
        Me.MenuItem18.Index = 5
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem18.Text = "Firma Hareketleri"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 6
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 7
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 8
        Me.MenuItem2.Text = "Başlık Değiştir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 9
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 10
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdır"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 11
        Me.MenuItem10.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 12
        Me.MenuItem17.Text = "Hızlı Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 13
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 14
        Me.MenuItem6.Text = "Gruplandır"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 15
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 16
        Me.MenuItem7.Text = "Satırları Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 17
        Me.MenuItem8.Text = "Satırları Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 18
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 19
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem9.Text = "Ekranı Kapla"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nFirmaID"
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
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "lKrediLimiti"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Adres"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "ISTIHBARAT"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "SINIF1"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "SINIF2"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "SINIF3"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "SINIF4"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "SINIF5"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSINIF, Me.collBakiye, Me.colSenetRisk, Me.colCekRisk, Me.collTahsilat, Me.collSatis, Me.collIade, Me.collNet, Me.collMaliyet, Me.collKar, Me.collOran, Me.collSiparisMiktar, Me.collSiparisTutar, Me.collSiparisDahilTutar, Me.collSonBakiye, Me.colsAdi, Me.colsSoyadi, Me.colnPrim, Me.collSabitPrim, Me.collPrim1Baslangic, Me.collPrim1Bitis, Me.collPrim1Oran, Me.collPrim2Baslangic, Me.collPrim2Bitis, Me.collPrim2Oran, Me.collPrim3Baslangic, Me.collPrim3Bitis, Me.collPrim3Oran, Me.collPrim4Baslangic, Me.collPrim4Bitis, Me.collPrim4Oran, Me.collPrim5Baslangic, Me.collPrim5Bitis, Me.collPrim5Oran, Me.collPrim1, Me.collPrim2, Me.collPrim3, Me.collPrim4, Me.collPrim5, Me.collNetPrim, Me.collGecikenBakiye, Me.collGecikenKesinti, Me.colISKONTO})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(755, 311, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.collOran
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition1.Expression = "0"
        StyleFormatCondition1.Tag = "0"
        StyleFormatCondition1.Value1 = "0"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak İstediğiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "SINIF", Nothing, "{0} Kayıt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "SINIF", Nothing, "{0} Kayıt")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colSINIF
        '
        Me.colSINIF.Caption = "Sınıflandırma"
        Me.colSINIF.FieldName = "SINIF"
        Me.colSINIF.Name = "colSINIF"
        Me.colSINIF.Visible = True
        Me.colSINIF.VisibleIndex = 0
        Me.colSINIF.Width = 92
        '
        'collBakiye
        '
        Me.collBakiye.Caption = "Bakiye"
        Me.collBakiye.DisplayFormat.FormatString = "#,0.00(B);#,0.00(A);#,0.00(-)"
        Me.collBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBakiye.FieldName = "lBakiye"
        Me.collBakiye.Name = "collBakiye"
        Me.collBakiye.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBakiye", "{0:#,0.00(B);#,0.00(A);#,0.00(-)}")})
        Me.collBakiye.Visible = True
        Me.collBakiye.VisibleIndex = 3
        Me.collBakiye.Width = 102
        '
        'colSenetRisk
        '
        Me.colSenetRisk.Caption = "Senet Risk"
        Me.colSenetRisk.DisplayFormat.FormatString = "#,0.00"
        Me.colSenetRisk.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSenetRisk.FieldName = "SenetRisk"
        Me.colSenetRisk.Name = "colSenetRisk"
        Me.colSenetRisk.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SenetRisk", "{0:#,0.00}")})
        '
        'colCekRisk
        '
        Me.colCekRisk.Caption = "Çek Riski"
        Me.colCekRisk.DisplayFormat.FormatString = "#,0.00"
        Me.colCekRisk.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCekRisk.FieldName = "CekRisk"
        Me.colCekRisk.Name = "colCekRisk"
        Me.colCekRisk.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CekRisk", "{0:#,0.00}")})
        '
        'collTahsilat
        '
        Me.collTahsilat.Caption = "Tahsilat"
        Me.collTahsilat.DisplayFormat.FormatString = "#,0.00"
        Me.collTahsilat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collTahsilat.FieldName = "lTahsilat"
        Me.collTahsilat.Name = "collTahsilat"
        Me.collTahsilat.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lTahsilat", "{0:#,0.00}")})
        Me.collTahsilat.Visible = True
        Me.collTahsilat.VisibleIndex = 5
        Me.collTahsilat.Width = 92
        '
        'collSatis
        '
        Me.collSatis.Caption = "Satış"
        Me.collSatis.DisplayFormat.FormatString = "#,0.00"
        Me.collSatis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collSatis.FieldName = "lSatis"
        Me.collSatis.Name = "collSatis"
        Me.collSatis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSatis", "{0:#,0.00}")})
        Me.collSatis.Visible = True
        Me.collSatis.VisibleIndex = 6
        Me.collSatis.Width = 85
        '
        'collIade
        '
        Me.collIade.Caption = "İade"
        Me.collIade.DisplayFormat.FormatString = "#,0.00"
        Me.collIade.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collIade.FieldName = "lIade"
        Me.collIade.Name = "collIade"
        Me.collIade.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lIade", "{0:#,0.00}")})
        Me.collIade.Visible = True
        Me.collIade.VisibleIndex = 7
        Me.collIade.Width = 89
        '
        'collNet
        '
        Me.collNet.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.collNet.AppearanceCell.Options.UseFont = True
        Me.collNet.Caption = "Net"
        Me.collNet.DisplayFormat.FormatString = "#,0.00"
        Me.collNet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collNet.FieldName = "lNet"
        Me.collNet.Name = "collNet"
        Me.collNet.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNet", "{0:#,0.00}")})
        Me.collNet.Visible = True
        Me.collNet.VisibleIndex = 9
        Me.collNet.Width = 91
        '
        'collMaliyet
        '
        Me.collMaliyet.Caption = "Maliyet"
        Me.collMaliyet.DisplayFormat.FormatString = "#,0.00"
        Me.collMaliyet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMaliyet.FieldName = "lMaliyet"
        Me.collMaliyet.Name = "collMaliyet"
        Me.collMaliyet.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMaliyet", "{0:#,0.00}")})
        '
        'collKar
        '
        Me.collKar.Caption = "Kar"
        Me.collKar.DisplayFormat.FormatString = "#,0.00"
        Me.collKar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKar.FieldName = "lKar"
        Me.collKar.Name = "collKar"
        Me.collKar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKar", "{0:#,0.00}")})
        Me.collKar.Visible = True
        Me.collKar.VisibleIndex = 10
        Me.collKar.Width = 76
        '
        'collSiparisMiktar
        '
        Me.collSiparisMiktar.Caption = "Sipariş Miktarı"
        Me.collSiparisMiktar.DisplayFormat.FormatString = "#,0.00"
        Me.collSiparisMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collSiparisMiktar.FieldName = "lSiparisMiktar"
        Me.collSiparisMiktar.Name = "collSiparisMiktar"
        Me.collSiparisMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSiparisMiktar", "{0:#,0.00}")})
        '
        'collSiparisTutar
        '
        Me.collSiparisTutar.Caption = "Sipariş Tutarı"
        Me.collSiparisTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collSiparisTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collSiparisTutar.FieldName = "lSiparisTutar"
        Me.collSiparisTutar.Name = "collSiparisTutar"
        Me.collSiparisTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSiparisTutar", "{0:#,0.00}")})
        '
        'collSiparisDahilTutar
        '
        Me.collSiparisDahilTutar.Caption = "Sipariş Dahil Tutar"
        Me.collSiparisDahilTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collSiparisDahilTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collSiparisDahilTutar.FieldName = "lSiparisDahilTutar"
        Me.collSiparisDahilTutar.Name = "collSiparisDahilTutar"
        Me.collSiparisDahilTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSiparisDahilTutar", "{0:#,0.00}")})
        '
        'collSonBakiye
        '
        Me.collSonBakiye.Caption = "Son Bakiye"
        Me.collSonBakiye.DisplayFormat.FormatString = "#,0.00(B);#,0.00(A);#,0.00(-)"
        Me.collSonBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collSonBakiye.FieldName = "lSonBakiye"
        Me.collSonBakiye.Name = "collSonBakiye"
        Me.collSonBakiye.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSonBakiye", "{0:#,0.00(B);#,0.00(A);#,0.00(-)}")})
        '
        'colsAdi
        '
        Me.colsAdi.Caption = "Adı"
        Me.colsAdi.FieldName = "sAdi"
        Me.colsAdi.Name = "colsAdi"
        Me.colsAdi.Visible = True
        Me.colsAdi.VisibleIndex = 1
        Me.colsAdi.Width = 111
        '
        'colsSoyadi
        '
        Me.colsSoyadi.Caption = "Soyadi"
        Me.colsSoyadi.FieldName = "sSoyadi"
        Me.colsSoyadi.Name = "colsSoyadi"
        Me.colsSoyadi.Visible = True
        Me.colsSoyadi.VisibleIndex = 2
        Me.colsSoyadi.Width = 116
        '
        'colnPrim
        '
        Me.colnPrim.Caption = "Prim Oranı"
        Me.colnPrim.DisplayFormat.FormatString = "P"
        Me.colnPrim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnPrim.FieldName = "nPrim"
        Me.colnPrim.Name = "colnPrim"
        Me.colnPrim.Visible = True
        Me.colnPrim.VisibleIndex = 13
        Me.colnPrim.Width = 89
        '
        'collSabitPrim
        '
        Me.collSabitPrim.Caption = "Sabit Prim"
        Me.collSabitPrim.DisplayFormat.FormatString = "#,0.00"
        Me.collSabitPrim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collSabitPrim.FieldName = "lSabitPrim"
        Me.collSabitPrim.Name = "collSabitPrim"
        Me.collSabitPrim.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSabitPrim", "{0:#,0.00}")})
        Me.collSabitPrim.Width = 37
        '
        'collPrim1Baslangic
        '
        Me.collPrim1Baslangic.Caption = "Prim 1 Başlangıç"
        Me.collPrim1Baslangic.DisplayFormat.FormatString = "#,0.00"
        Me.collPrim1Baslangic.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPrim1Baslangic.FieldName = "lPrim1Baslangic"
        Me.collPrim1Baslangic.Name = "collPrim1Baslangic"
        Me.collPrim1Baslangic.Width = 37
        '
        'collPrim1Bitis
        '
        Me.collPrim1Bitis.Caption = "Prim 1 Bitiş"
        Me.collPrim1Bitis.DisplayFormat.FormatString = "#,0.00"
        Me.collPrim1Bitis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPrim1Bitis.FieldName = "lPrim1Bitis"
        Me.collPrim1Bitis.Name = "collPrim1Bitis"
        Me.collPrim1Bitis.Width = 37
        '
        'collPrim1Oran
        '
        Me.collPrim1Oran.Caption = "Prim 1 Oran"
        Me.collPrim1Oran.DisplayFormat.FormatString = "#,0.00"
        Me.collPrim1Oran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPrim1Oran.FieldName = "lPrim1Oran"
        Me.collPrim1Oran.Name = "collPrim1Oran"
        Me.collPrim1Oran.Width = 37
        '
        'collPrim2Baslangic
        '
        Me.collPrim2Baslangic.Caption = "Prim 2 Başlangıç"
        Me.collPrim2Baslangic.DisplayFormat.FormatString = "#,0.00"
        Me.collPrim2Baslangic.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPrim2Baslangic.FieldName = "lPrim2Baslangic"
        Me.collPrim2Baslangic.Name = "collPrim2Baslangic"
        Me.collPrim2Baslangic.Width = 37
        '
        'collPrim2Bitis
        '
        Me.collPrim2Bitis.Caption = "Prim 2 Bitiş"
        Me.collPrim2Bitis.DisplayFormat.FormatString = "#,0.00"
        Me.collPrim2Bitis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPrim2Bitis.FieldName = "lPrim2Bitis"
        Me.collPrim2Bitis.Name = "collPrim2Bitis"
        Me.collPrim2Bitis.Width = 37
        '
        'collPrim2Oran
        '
        Me.collPrim2Oran.Caption = "Prim 2 Oran"
        Me.collPrim2Oran.DisplayFormat.FormatString = "#,0.00"
        Me.collPrim2Oran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPrim2Oran.FieldName = "lPrim2Oran"
        Me.collPrim2Oran.Name = "collPrim2Oran"
        Me.collPrim2Oran.Width = 37
        '
        'collPrim3Baslangic
        '
        Me.collPrim3Baslangic.Caption = "Prim 3 Başlangıç"
        Me.collPrim3Baslangic.DisplayFormat.FormatString = "#,0.00"
        Me.collPrim3Baslangic.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPrim3Baslangic.FieldName = "lPrim3Baslangic"
        Me.collPrim3Baslangic.Name = "collPrim3Baslangic"
        Me.collPrim3Baslangic.Width = 37
        '
        'collPrim3Bitis
        '
        Me.collPrim3Bitis.Caption = "Prim 3 Bitiş"
        Me.collPrim3Bitis.DisplayFormat.FormatString = "#,0.00"
        Me.collPrim3Bitis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPrim3Bitis.FieldName = "lPrim3Bitis"
        Me.collPrim3Bitis.Name = "collPrim3Bitis"
        Me.collPrim3Bitis.Width = 37
        '
        'collPrim3Oran
        '
        Me.collPrim3Oran.Caption = "Prim 3 Oran"
        Me.collPrim3Oran.DisplayFormat.FormatString = "#,0.00"
        Me.collPrim3Oran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPrim3Oran.FieldName = "lPrim3Oran"
        Me.collPrim3Oran.Name = "collPrim3Oran"
        Me.collPrim3Oran.Width = 37
        '
        'collPrim4Baslangic
        '
        Me.collPrim4Baslangic.Caption = "Prim 4 Başlangıç"
        Me.collPrim4Baslangic.DisplayFormat.FormatString = "#,0.00"
        Me.collPrim4Baslangic.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPrim4Baslangic.FieldName = "lPrim4Baslangic"
        Me.collPrim4Baslangic.Name = "collPrim4Baslangic"
        Me.collPrim4Baslangic.Width = 37
        '
        'collPrim4Bitis
        '
        Me.collPrim4Bitis.Caption = "Prim 4 Bitiş"
        Me.collPrim4Bitis.DisplayFormat.FormatString = "#,0.00"
        Me.collPrim4Bitis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPrim4Bitis.FieldName = "lPrim4Bitis"
        Me.collPrim4Bitis.Name = "collPrim4Bitis"
        Me.collPrim4Bitis.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.collPrim4Bitis.Width = 37
        '
        'collPrim4Oran
        '
        Me.collPrim4Oran.Caption = "Prim 4 Oran"
        Me.collPrim4Oran.DisplayFormat.FormatString = "#,0.00"
        Me.collPrim4Oran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPrim4Oran.FieldName = "lPrim4Oran"
        Me.collPrim4Oran.Name = "collPrim4Oran"
        Me.collPrim4Oran.Width = 37
        '
        'collPrim5Baslangic
        '
        Me.collPrim5Baslangic.Caption = "Prim 5 Başlangıç"
        Me.collPrim5Baslangic.DisplayFormat.FormatString = "#,0.00"
        Me.collPrim5Baslangic.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPrim5Baslangic.FieldName = "lPrim5Baslangic"
        Me.collPrim5Baslangic.Name = "collPrim5Baslangic"
        Me.collPrim5Baslangic.Width = 37
        '
        'collPrim5Bitis
        '
        Me.collPrim5Bitis.Caption = "Prim 4 Bitiş"
        Me.collPrim5Bitis.DisplayFormat.FormatString = "#,0.00"
        Me.collPrim5Bitis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPrim5Bitis.FieldName = "lPrim5Bitis"
        Me.collPrim5Bitis.Name = "collPrim5Bitis"
        Me.collPrim5Bitis.Width = 37
        '
        'collPrim5Oran
        '
        Me.collPrim5Oran.Caption = "Prim 5 Oran"
        Me.collPrim5Oran.DisplayFormat.FormatString = "#,0.00"
        Me.collPrim5Oran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPrim5Oran.FieldName = "lPrim5Oran"
        Me.collPrim5Oran.Name = "collPrim5Oran"
        Me.collPrim5Oran.Width = 37
        '
        'collPrim1
        '
        Me.collPrim1.Caption = "Prim 1"
        Me.collPrim1.DisplayFormat.FormatString = "#,0.00"
        Me.collPrim1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPrim1.FieldName = "lPrim1"
        Me.collPrim1.Name = "collPrim1"
        Me.collPrim1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lPrim1", "{0:#,0.00}")})
        Me.collPrim1.Width = 37
        '
        'collPrim2
        '
        Me.collPrim2.Caption = "Prim 2"
        Me.collPrim2.DisplayFormat.FormatString = "#,0.00"
        Me.collPrim2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPrim2.FieldName = "lPrim2"
        Me.collPrim2.Name = "collPrim2"
        Me.collPrim2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lPrim2", "{0:#,0.00}")})
        Me.collPrim2.Width = 37
        '
        'collPrim3
        '
        Me.collPrim3.Caption = "Prim 3"
        Me.collPrim3.DisplayFormat.FormatString = "#,0.00"
        Me.collPrim3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPrim3.FieldName = "lPrim3"
        Me.collPrim3.Name = "collPrim3"
        Me.collPrim3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lPrim3", "{0:#,0.00}")})
        Me.collPrim3.Width = 37
        '
        'collPrim4
        '
        Me.collPrim4.Caption = "Prim 4"
        Me.collPrim4.DisplayFormat.FormatString = "#,0.00"
        Me.collPrim4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPrim4.FieldName = "lPrim4"
        Me.collPrim4.Name = "collPrim4"
        Me.collPrim4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lPrim4", "{0:#,0.00}")})
        Me.collPrim4.Width = 37
        '
        'collPrim5
        '
        Me.collPrim5.Caption = "Prim 5"
        Me.collPrim5.DisplayFormat.FormatString = "#,0.00"
        Me.collPrim5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collPrim5.FieldName = "lPrim5"
        Me.collPrim5.Name = "collPrim5"
        Me.collPrim5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lPrim5", "{0:#,0.00}")})
        Me.collPrim5.Width = 37
        '
        'collNetPrim
        '
        Me.collNetPrim.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.collNetPrim.AppearanceCell.Options.UseFont = True
        Me.collNetPrim.Caption = "Net Prim"
        Me.collNetPrim.DisplayFormat.FormatString = "#,#.##"
        Me.collNetPrim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collNetPrim.FieldName = "lNetPrim"
        Me.collNetPrim.Name = "collNetPrim"
        Me.collNetPrim.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetPrim", "{0:#,0.00}")})
        Me.collNetPrim.Visible = True
        Me.collNetPrim.VisibleIndex = 12
        Me.collNetPrim.Width = 73
        '
        'collGecikenBakiye
        '
        Me.collGecikenBakiye.Caption = "Geciken Bakiye"
        Me.collGecikenBakiye.DisplayFormat.FormatString = "#,0.00"
        Me.collGecikenBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGecikenBakiye.FieldName = "lGecikenBakiye"
        Me.collGecikenBakiye.Name = "collGecikenBakiye"
        Me.collGecikenBakiye.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGecikenBakiye", "{0:#,0.00}")})
        Me.collGecikenBakiye.Visible = True
        Me.collGecikenBakiye.VisibleIndex = 4
        Me.collGecikenBakiye.Width = 98
        '
        'collGecikenKesinti
        '
        Me.collGecikenKesinti.Caption = "Gecikme Kesintisi"
        Me.collGecikenKesinti.DisplayFormat.FormatString = "#,0.00"
        Me.collGecikenKesinti.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGecikenKesinti.FieldName = "lGecikenKesinti"
        Me.collGecikenKesinti.Name = "collGecikenKesinti"
        Me.collGecikenKesinti.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGecikenKesinti", "{0:#,0.00}")})
        '
        'colISKONTO
        '
        Me.colISKONTO.Caption = "İskonto"
        Me.colISKONTO.DisplayFormat.FormatString = "#,0.00"
        Me.colISKONTO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colISKONTO.FieldName = "ISKONTO"
        Me.colISKONTO.Name = "colISKONTO"
        Me.colISKONTO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ISKONTO", "{0:#,0.00}")})
        Me.colISKONTO.Visible = True
        Me.colISKONTO.VisibleIndex = 8
        Me.colISKONTO.Width = 93
        '
        'sec_sSatici
        '
        Me.sec_sSatici.AutoHeight = False
        Me.sec_sSatici.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSatici.DisplayMember = "SATICI"
        Me.sec_sSatici.Name = "sec_sSatici"
        Me.sec_sSatici.ValueMember = "sSaticiRumuzu"
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
        Me.printlink1.Owner = Nothing
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Firmalar Karlılık Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Firma Hesapları Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
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
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5})
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True)})
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
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Yazdır,Ctrl+P"
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
        'frm_tbSatici_Degerlendirme
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
        Me.Name = "frm_tbSatici_Degerlendirme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Satıcı Degerlendirme"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_DC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_FS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_nIslem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nVadeFarki.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nGun2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nGun1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sec_grid.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSatici, System.ComponentModel.ISupportInitialize).EndInit()
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
    Public sModul As String = "Cari"
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_satici As New DataSet
    Public sFiyatTipi As String = ""
    Public sDepo As String = ""
    Public islemstatus As Boolean = False
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        DateEdit1.EditValue = dteSistemTarihi
        DateEdit2.EditValue = dteSistemTarihi
        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        txt_ara.EditValue = ""
        DateEdit1.Focus()
        DateEdit1.Select()
        dataload_satici()
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
        kriter += Microsoft.VisualBasic.Left(DateEdit1.EditValue.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(DateEdit2.EditValue.ToString, 10) & " Tarihleri Arasındaki Satıcı Personel Değerlendirme Listesi" & vbCrLf
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Financial Managment-Finans Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
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
    Private Sub dataload_satici()
        sec_sSatici.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu , sAdi + ' ' + sSoyadi AS SATICI  FROM         tbSatici where bAktif =1")).Tables(0)
        ds_satici = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST('0' as bit) AS SEC, sSaticiRumuzu AS KOD, sAdi + ' ' + sSoyadi AS ACIKLAMA FROM         tbSatici where bAktif =1"))
        GridControl2.DataSource = ds_satici.Tables(0)
        GridControl2.DataMember = Nothing
        If sDepo <> "" Then
            sec_depo.Text = sDepo.ToString
            sec_depo.EditValue = sDepo.ToString
        End If
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandTimeout = Nothing
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        conn.Close()
        Return DS
    End Function
    Public Function sorgu_lKalanBakiye(ByVal sSaticiRumuzu As String, ByVal nGun1 As Int64, ByVal nGun2 As Int64, ByVal nVadeFarki As Decimal) As Decimal
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        Dim lKalanBakiye As Decimal = 0
        cmd.CommandTimeout = Nothing
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(lKalan),0) AS lKalan FROM (SELECT lTutar - lKarsilananTutar AS lKalan FROM (SELECT tbFirmaHareketi.lBorcTutar AS lTutar , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE tbFirmaKapama.nOdemeId > 0 AND tbFirmaKapama.nKarsilamaId = tbFirmaHareketi.nHareketId) , 0) AS lKarsilananTutar , DATEDIFF(day , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi) AS nOpsiyon , ROUND(CAST(GETDATE() - (CAST(tbFirmaHareketi.dteValorTarihi AS INT) + 1) AS FLOAT) , 0) AS nGecikme FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID WHERE (tbFirmaHareketi.lBorcTutar <> 0) AND tbFirmaHareketi.dteIslemTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND (tbFirma.sSaticiRumuzu IN ('" & sSaticiRumuzu & "')) AND (tbFirma.bAktif = 1) and tbFirma.sKodu Not LIKE '800%' AND ROUND(CAST(GETDATE() - (CAST(tbFirmaHareketi.dteValorTarihi AS INT) + 1) AS FLOAT) , 0) BETWEEN " & nGun1 & " AND " & nGun2 & ") tbTemp WHERE (lTutar <> lKarsilananTutar)) tbTempVade")
        lKalanBakiye = sorgu_sayi(cmd.ExecuteScalar, 0)
        Return lKalanBakiye
        conn.Close()
    End Function
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
    Public Function stok(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sSiniflandirma As String, ByVal sSaticiRumuzu As String) As DataSet
        Dim kriter As String = ""
        If sec_konum.Text = "Kodu" Then
            kriter += " WHERE ( tbFirma.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Adı" Then
            kriter += " WHERE ( tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "İstihbarat" Then
            kriter += " WHERE (( tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + '  ' + tbFirmaAciklamasi.sAciklama5) " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Adres" Then
            kriter += " WHERE ( tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu  " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Sınıf1" Then
            kriter += " WHERE (tbFSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Sınıf2" Then
            kriter += " WHERE (tbFSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Sınıf3" Then
            kriter += " WHERE (tbFSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Sınıf4" Then
            kriter += " WHERE (tbFSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Sınıf5" Then
            kriter += " WHERE (tbFSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Adı+Soyadı" Then
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
                kriter += " WHERE ( tbMusteri.sAdi " & sorgu_kriter_string(adi, ara_kriter) & " )"
            End If
            If soyadi.ToString <> "" Then
                kriter += " AND ( tbMusteri.sSoyadi " & sorgu_kriter_string(soyadi, ara_kriter) & " )"
            End If
        Else
        End If
        If sSaticiRumuzu.ToString <> "" And sSaticiRumuzu <> "[Tümü]" Then
            kriter += " AND (tbFirma.sSaticiRumuzu IN (" & sSaticiRumuzu & " ))"
        End If
        If sModul = "Cari" Then
            kriter += " and tbFirma.sKodu not like '102%' "
            If sCariSinirla <> "" Then
                kriter += " and tbFirma.sKodu like '" & sCariSinirla & "%' "
            End If
            If sCariSinifKoduSinirla <> "" Then
                kriter += " and tbFirma.nFirmaID IN (SELECT     nFirmaID FROM         tbFirmaSinifi WHERE     (sSinifKodu1 IN (" & sCariSinifKoduSinirla & ")))"
            End If
        ElseIf sModul = "Banka" Then
            kriter += " and tbFirma.sKodu like '102%' "
            If sBankaSinirla <> "" Then
                kriter += " and tbFirma.sKodu like '" & sBankaSinirla & "%' "
            End If
        End If
        kriter += " and (tbFirma.bAktif =1) "
        Dim sFisTipi_kriter As String = ""
        If sModul = "Perakende" Then
            If sec_FS.Checked = True Or sec_DC.Checked = True Then
                If sec_FS.Checked = True And sec_DC.Checked = True Then
                    sFisTipi_kriter = "'K','P'"
                ElseIf sec_FS.Checked = True And sec_DC.Checked = False Then
                    sFisTipi_kriter = "'K','P'"
                ElseIf sec_FS.Checked = False And sec_DC.Checked = True Then
                    sFisTipi_kriter = "'P'"
                End If
            Else
                sFisTipi_kriter = "'K','P'"
            End If
        Else
            If sec_FS.Checked = True Or sec_DC.Checked = True Then
                If sec_FS.Checked = True And sec_DC.Checked = True Then
                    sFisTipi_kriter = "'FS','DC'"
                ElseIf sec_FS.Checked = True And sec_DC.Checked = False Then
                    sFisTipi_kriter = "'FS'"
                ElseIf sec_FS.Checked = False And sec_DC.Checked = True Then
                    sFisTipi_kriter = "'DC'"
                End If
            Else
                sFisTipi_kriter = "'FS','DC'"
            End If
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        If sModul = "Cari" Then
            If sec_nIslem.SelectedIndex = 0 Then
                'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *,Satis.Net-ISKONTO AS lNet,Satis.Kar-ISKONTO as lKar,lOran = CASE WHEN (Satis.Kar-ISKONTO) <> 0 AND (Satis.lMaliyet) <> 0 THEN ((Satis.Kar-ISKONTO) / (Satis.lMaliyet))  ELSE 0 END FROM (SELECT sSaticiRumuzu AS SINIF, sAdi, sSoyadi, nPrim, lSabitPrim, lPrim1Baslangic, lPrim1Bitis, lPrim1Oran, lPrim2Baslangic, lPrim2Bitis, lPrim2Oran, lPrim3Baslangic, lPrim3Bitis, lPrim3Oran, lPrim4Baslangic, lPrim4Bitis, lPrim4Oran, lPrim5Baslangic, lPrim5Bitis, lPrim5Oran,CAST(0 AS MONEY) AS lPrim1,CAST(0 AS MONEY) AS lPrim2,CAST(0 AS MONEY) AS lPrim3,CAST(0 AS MONEY) AS lPrim4,CAST(0 AS MONEY) AS lPrim5,CAST(0 AS MONEY) AS lNetPrim, SUM(Firma.lBakiye) AS lBakiye,CAST(0 AS MONEY) lGecikenBakiye, CAST(0 AS MONEY) AS lGecikenKesinti,SUM(lSonBakiye) AS lSonBakiye, SUM(lTahsilat) AS lTahsilat, MAX(lIskonto) AS ISKONTO,SUM(CekRisk) AS CekRisk, SUM(SenetRisk) AS SenetRisk, SUM(Siparis.lSiparisMiktar) AS lSiparisMiktar, SUM(Siparis.lSiparisTutarDahil) AS lSiparisDahilTutar, SUM(Siparis.lTutar) AS lSiparisTutar FROM (SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti, tbFirma.sSemt, tbFirma.sIl, tbFirma.sUlke, tbFirma.sSaticiRumuzu,tbSatici.sAdi, tbSatici.sSoyadi, tbSatici.nPrim, tbSatici.lSabitPrim, tbSatici.lPrim1Baslangic, tbSatici.lPrim1Bitis, tbSatici.lPrim1Oran, tbSatici.lPrim2Baslangic, tbSatici.lPrim2Bitis, tbSatici.lPrim2Oran, tbSatici.lPrim3Baslangic, tbSatici.lPrim3Bitis, tbSatici.lPrim3Oran, tbSatici.lPrim4Baslangic, tbSatici.lPrim4Bitis, tbSatici.lPrim4Oran, tbSatici.lPrim5Baslangic, tbSatici.lPrim5Bitis, tbSatici.lPrim5Oran,tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT, tbFSinif1.sAciklama AS SINIF1, tbFSinif2.sAciklama AS SINIF2, tbFSinif3.sAciklama AS SINIF3, tbFSinif4.sAciklama AS SINIF4, tbFSinif5.sAciklama AS SINIF5, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail], (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND dteIslemTarihi <= '" & tarih2 & "') AS lBakiye, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lSonBakiye, (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk, (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk, (SELECT TOP 1 dteFisTarihi FROM tbStokFisiMaster WHERE (sFisTipi = 'FS') AND tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID AND tbStokFisiMaster.nGirisCikis = 3 AND dteFisTarihi <= '" & tarih2 & "' ORDER BY dteFisTarihi DESC) AS dteSonSatisTarihi, (SELECT SUM(lAlacakTutar) AS lTahsilat FROM tbFirmaHareketi WHERE (lAlacakTutar > 0) AND (dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND nFirmaID = tbFirma.nFirmaID) AS lTahsilat,(SELECT ISNULL(SUM(tHareket.lBorcTutar),0) AS lTahsilat FROM tbFirma tFirma INNER JOIN tbFirmaHareketi tHareket ON tFirma.nFirmaID = tHareket.nFirmaID WHERE (tFirma.sKodu LIKE '800%') AND (tFirma.sKodu LIKE '%-18-%') AND tFirma.sSaticiRumuzu = tbFirma.sSaticiRumuzu and (tHareket.lBorcTutar > 0) AND (tHareket.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) AS lIskonto, (SELECT TOP 1 dteIslemTarihi FROM tbFirmaHareketi WHERE (lAlacakTutar > 0) AND (dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND nFirmaID = tbFirma.nFirmaID ORDER BY dteIslemTarihi DESC) AS dteSonTahsilatTarihi FROM tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu RIGHT OUTER JOIN tbFirma LEFT OUTER JOIN tbFirmaAciklamasi ON tbFirma.nFirmaID = tbFirmaAciklamasi.nFirmaID ON tbFirmaSinifi.nFirmaID = tbFirma.nFirmaID INNER JOIN tbSatici ON tbFirma.sSaticiRumuzu = tbSatici.sSaticiRumuzu " & kriter & ") Firma LEFT OUTER JOIN (SELECT nFirmaID, SUM(lKalan) AS lSiparisMiktar, SUM(lTutari) AS lSiparisTutarDahil, SUM(lIskontosuzTutari) AS lTutar FROM (SELECT tbFirma.nFirmaID, ISNULL(tbSiparis.lMiktari, 0) - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) AS lKalan, ((tbSiparis.lTutari / tbSiparis.lMiktari) * (tbSiparis.lMiktari - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0))) * (100 + tbSiparis.nKdvOrani) / 100 AS lTutari, (ISNULL(tbSiparis.lIskontosuzTutari / tbSiparis.lMiktari, 1) * (tbSiparis.lMiktari - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0))) * (100 + tbSiparis.nKdvOrani) / 100 AS lIskontosuzTutari FROM tbFirma INNER JOIN tbSiparis ON tbFirma.nFirmaID = tbSiparis.nFirmaID INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID LEFT OUTER JOIN tbStokFisiDetayi WITH(INDEX (tbStokFisiDetayi_index12)) ON tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID WHERE (tbSiparis.bKapandimi = 0) AND (tbSiparis.lSiparisNo BETWEEN 1 AND 999999999) AND (tbSiparis.dteSiparisTarihi BETWEEN '01/01/1900' AND '" & tarih2 & "') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 1, 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 31, 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (tbSiparis.nSiparisTipi = 1) GROUP BY tbFirma.nFirmaID, tbSiparis.nSiparisID, tbSiparis.lMiktari, tbSiparis.nKdvOrani, tbSiparis.lFiyati, tbSiparis.lTutari, tbSiparis.nIskontoYuzdesi, tbSiparis.lIskontosuzTutari HAVING (ISNULL(tbSiparis.lMiktari, 0) - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) <> 0)) DERIVEDTBL GROUP BY nFirmaID) Siparis ON Firma.nFirmaID = Siparis.nFirmaID GROUP BY sSaticiRumuzu,sAdi, sSoyadi, nPrim, lSabitPrim, lPrim1Baslangic, lPrim1Bitis, lPrim1Oran, lPrim2Baslangic, lPrim2Bitis, lPrim2Oran, lPrim3Baslangic, lPrim3Bitis, lPrim3Oran, lPrim4Baslangic, lPrim4Bitis, lPrim4Oran, lPrim5Baslangic, lPrim5Bitis, lPrim5Oran ) SaticiListesi LEFT OUTER JOIN (SELECT sSaticiRumuzu, SUM(lSatis) AS lSatis, SUM(lIade) AS lIade, SUM(lSatis - abs(lIade)) AS Net, SUM(lMaliyet) AS lMaliyet, SUM(lSatis - abs(lIade)) - SUM(lMaliyet) AS Kar FROM (SELECT sSaticiRumuzu, SUM(CAST(lCikisTutar * (100 + nKdvOrani) / 100 AS FLOAT)) AS lSatis, CAST(0 AS Money) AS lIade, SUM(CAST(lMaliyetTutar  AS FLOAT)) AS lMaliyet, CAST(0 AS Money) AS lKar, CAST(0 AS Money) AS lOran FROM tbStokFisiDetayi WHERE (sFisTipi IN ('FS','DC')) AND (nGirisCikis = 3) AND dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY sSaticiRumuzu, nGirisCikis UNION ALL SELECT sSaticiRumuzu, CAST(0 AS Money) AS lSatis, SUM(CAST(lCikisTutar * (100 + nKdvOrani) / 100 AS FLOAT)) AS lIade, SUM(CAST(lMaliyetTutar  AS FLOAT)) AS lMaliyet, CAST(0 AS Money) AS lKar, CAST(0 AS Money) AS lOran FROM tbStokFisiDetayi WHERE (sFisTipi IN ('FS','DC')) AND (nGirisCikis = 4) AND dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY sSaticiRumuzu, nGirisCikis) DERIVEDTBL GROUP BY sSaticiRumuzu) Satis ON SaticiListesi.SINIF = Satis.sSaticiRumuzu")
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *,Satis.Net-ISKONTO AS lNet,Satis.Kar-ISKONTO as lKar,lOran = CASE WHEN (Satis.Kar-ISKONTO) <> 0 AND (Satis.lMaliyet) <> 0 THEN ((Satis.Kar-ISKONTO) / (Satis.lMaliyet))  ELSE 0 END FROM (SELECT sSaticiRumuzu AS SINIF, sAdi, sSoyadi, nPrim, lSabitPrim, lPrim1Baslangic, lPrim1Bitis, lPrim1Oran, lPrim2Baslangic, lPrim2Bitis, lPrim2Oran, lPrim3Baslangic, lPrim3Bitis, lPrim3Oran, lPrim4Baslangic, lPrim4Bitis, lPrim4Oran, lPrim5Baslangic, lPrim5Bitis, lPrim5Oran,CAST(0 AS MONEY) AS lPrim1,CAST(0 AS MONEY) AS lPrim2,CAST(0 AS MONEY) AS lPrim3,CAST(0 AS MONEY) AS lPrim4,CAST(0 AS MONEY) AS lPrim5,CAST(0 AS MONEY) AS lNetPrim, SUM(Firma.lBakiye) AS lBakiye,CAST(0 AS MONEY) lGecikenBakiye, CAST(0 AS MONEY) AS lGecikenKesinti,SUM(lSonBakiye) AS lSonBakiye, SUM(lTahsilat) AS lTahsilat, MAX(lIskonto) AS ISKONTO,SUM(CekRisk) AS CekRisk, SUM(SenetRisk) AS SenetRisk, SUM(Siparis.lSiparisMiktar) AS lSiparisMiktar, SUM(Siparis.lSiparisTutarDahil) AS lSiparisDahilTutar, SUM(Siparis.lTutar) AS lSiparisTutar FROM (SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti, tbFirma.sSemt, tbFirma.sIl, tbFirma.sUlke, tbSatici.sSaticiRumuzu,tbSatici.sAdi, tbSatici.sSoyadi, tbSatici.nPrim, tbSatici.lSabitPrim, tbSatici.lPrim1Baslangic, tbSatici.lPrim1Bitis, tbSatici.lPrim1Oran, tbSatici.lPrim2Baslangic, tbSatici.lPrim2Bitis, tbSatici.lPrim2Oran, tbSatici.lPrim3Baslangic, tbSatici.lPrim3Bitis, tbSatici.lPrim3Oran, tbSatici.lPrim4Baslangic, tbSatici.lPrim4Bitis, tbSatici.lPrim4Oran, tbSatici.lPrim5Baslangic, tbSatici.lPrim5Bitis, tbSatici.lPrim5Oran,tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT, tbFSinif1.sAciklama AS SINIF1, tbFSinif2.sAciklama AS SINIF2, tbFSinif3.sAciklama AS SINIF3, tbFSinif4.sAciklama AS SINIF4, tbFSinif5.sAciklama AS SINIF5, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail], (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND dteIslemTarihi <= '" & tarih2 & "') AS lBakiye, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lSonBakiye, (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk, (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk, (SELECT TOP 1 dteFisTarihi FROM tbStokFisiMaster WHERE (sFisTipi = 'FS') AND tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID AND tbStokFisiMaster.nGirisCikis = 3 AND dteFisTarihi <= '" & tarih2 & "' ORDER BY dteFisTarihi DESC) AS dteSonSatisTarihi, (SELECT SUM(lAlacakTutar) AS lTahsilat FROM tbFirmaHareketi WHERE (lAlacakTutar > 0) AND (dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND nFirmaID = tbFirma.nFirmaID) AS lTahsilat,(SELECT ISNULL(SUM(tHareket.lBorcTutar),0) AS lTahsilat FROM tbFirma tFirma INNER JOIN tbFirmaHareketi tHareket ON tFirma.nFirmaID = tHareket.nFirmaID WHERE (tFirma.sKodu LIKE '800%') AND (tFirma.sKodu LIKE '%-18-%') AND tFirma.sSaticiRumuzu = tbFirma.sSaticiRumuzu and (tHareket.lBorcTutar > 0) AND (tHareket.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) AS lIskonto, (SELECT TOP 1 dteIslemTarihi FROM tbFirmaHareketi WHERE (lAlacakTutar > 0) AND (dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND nFirmaID = tbFirma.nFirmaID ORDER BY dteIslemTarihi DESC) AS dteSonTahsilatTarihi FROM tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu RIGHT OUTER JOIN tbFirma LEFT OUTER JOIN tbFirmaAciklamasi ON tbFirma.nFirmaID = tbFirmaAciklamasi.nFirmaID ON tbFirmaSinifi.nFirmaID = tbFirma.nFirmaID RIGHT OUTER JOIN tbSatici ON tbFirma.sSaticiRumuzu = tbSatici.sSaticiRumuzu ) Firma LEFT OUTER JOIN (SELECT nFirmaID, SUM(lKalan) AS lSiparisMiktar, SUM(lTutari) AS lSiparisTutarDahil, SUM(lIskontosuzTutari) AS lTutar FROM (SELECT tbFirma.nFirmaID, ISNULL(tbSiparis.lMiktari, 0) - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) AS lKalan, ((tbSiparis.lTutari / tbSiparis.lMiktari) * (tbSiparis.lMiktari - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0))) * (100 + tbSiparis.nKdvOrani) / 100 AS lTutari, (ISNULL(tbSiparis.lIskontosuzTutari / tbSiparis.lMiktari, 1) * (tbSiparis.lMiktari - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0))) * (100 + tbSiparis.nKdvOrani) / 100 AS lIskontosuzTutari FROM tbFirma INNER JOIN tbSiparis ON tbFirma.nFirmaID = tbSiparis.nFirmaID INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID LEFT OUTER JOIN tbStokFisiDetayi WITH(INDEX (tbStokFisiDetayi_index12)) ON tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID WHERE (tbSiparis.bKapandimi = 0) AND (tbSiparis.lSiparisNo BETWEEN 1 AND 999999999) AND (tbSiparis.dteSiparisTarihi BETWEEN '01/01/1900' AND '" & tarih2 & "') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 1, 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 31, 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (tbSiparis.nSiparisTipi = 1) GROUP BY tbFirma.nFirmaID, tbSiparis.nSiparisID, tbSiparis.lMiktari, tbSiparis.nKdvOrani, tbSiparis.lFiyati, tbSiparis.lTutari, tbSiparis.nIskontoYuzdesi, tbSiparis.lIskontosuzTutari HAVING (ISNULL(tbSiparis.lMiktari, 0) - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) <> 0)) DERIVEDTBL GROUP BY nFirmaID) Siparis ON Firma.nFirmaID = Siparis.nFirmaID GROUP BY sSaticiRumuzu,sAdi, sSoyadi, nPrim, lSabitPrim, lPrim1Baslangic, lPrim1Bitis, lPrim1Oran, lPrim2Baslangic, lPrim2Bitis, lPrim2Oran, lPrim3Baslangic, lPrim3Bitis, lPrim3Oran, lPrim4Baslangic, lPrim4Bitis, lPrim4Oran, lPrim5Baslangic, lPrim5Bitis, lPrim5Oran ) SaticiListesi LEFT OUTER JOIN (SELECT sSaticiRumuzu, SUM(lSatis) AS lSatis, SUM(lIade) AS lIade, SUM(lSatis - abs(lIade)) AS Net, SUM(lMaliyet) AS lMaliyet, SUM(lSatis - abs(lIade)) - SUM(lMaliyet) AS Kar FROM (SELECT sSaticiRumuzu, SUM(CAST(lCikisTutar * (100 + nKdvOrani) / 100 AS FLOAT)) AS lSatis, CAST(0 AS Money) AS lIade, SUM(CAST(lMaliyetTutar  AS FLOAT)) AS lMaliyet, CAST(0 AS Money) AS lKar, CAST(0 AS Money) AS lOran FROM tbStokFisiDetayi WHERE (sFisTipi IN (" & sFisTipi_kriter & ")) AND (nGirisCikis = 3) AND dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY sSaticiRumuzu, nGirisCikis UNION ALL SELECT sSaticiRumuzu, CAST(0 AS Money) AS lSatis, SUM(CAST(lCikisTutar * (100 + nKdvOrani) / 100 AS FLOAT)) AS lIade, SUM(CAST(lMaliyetTutar  AS FLOAT)) AS lMaliyet, CAST(0 AS Money) AS lKar, CAST(0 AS Money) AS lOran FROM tbStokFisiDetayi WHERE (sFisTipi IN (" & sFisTipi_kriter & ")) AND (nGirisCikis = 4) AND dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY sSaticiRumuzu, nGirisCikis) DERIVEDTBL GROUP BY sSaticiRumuzu) Satis ON SaticiListesi.SINIF = Satis.sSaticiRumuzu Order by SaticiListesi.SINIF")
            ElseIf sec_nIslem.SelectedIndex = 1 Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSaticiRumuzu AS SINIF, sAdi, sSoyadi, nPrim, lSabitPrim, lPrim1Baslangic, lPrim1Bitis, lPrim1Oran, lPrim2Baslangic, lPrim2Bitis, lPrim2Oran, lPrim3Baslangic, lPrim3Bitis, lPrim3Oran, lPrim4Baslangic, lPrim4Bitis, lPrim4Oran, lPrim5Baslangic, lPrim5Bitis, lPrim5Oran,CAST(0 AS MONEY) AS lPrim1,CAST(0 AS MONEY) AS lPrim2,CAST(0 AS MONEY) AS lPrim3,CAST(0 AS MONEY) AS lPrim4,CAST(0 AS MONEY) AS lPrim5,CAST(0 AS MONEY) AS lNetPrim, SUM(Firma.lBakiye) AS lBakiye,CAST(0 AS MONEY) lGecikenBakiye, CAST(0 AS MONEY) AS lGecikenKesinti,SUM(lSonBakiye) AS lSonBakiye, SUM(Satis.lSatis) AS lSatis, SUM(lTahsilat) AS lTahsilat,MAX(lIskonto) AS ISKONTO, SUM(CekRisk) AS CekRisk, SUM(SenetRisk) AS SenetRisk, SUM(Satis.lIade) AS lIade, ISNULL(SUM(Satis.lNet)-MAX(lIskonto),0) AS lNet, SUM(Satis.lMaliyet) AS lMaliyet, SUM(Satis.lKar)-MAX(lIskonto)AS lKar, SUM(Siparis.lSiparisMiktar) AS lSiparisMiktar, SUM(Siparis.lSiparisTutarDahil) AS lSiparisDahilTutar, SUM(Siparis.lTutar) AS lSiparisTutar, lOran = CASE WHEN SUM(Satis.lKar)-MAX(lIskonto)<> 0 AND SUM(Satis.lMaliyet) <> 0 THEN ((SUM(Satis.lKar)-MAX(lIskonto)) / SUM(Satis.lMaliyet))  ELSE 0 END FROM (SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti, tbFirma.sSemt, tbFirma.sIl, tbFirma.sUlke, tbFirma.sSaticiRumuzu,tbSatici.sAdi, tbSatici.sSoyadi, tbSatici.nPrim, tbSatici.lSabitPrim, tbSatici.lPrim1Baslangic, tbSatici.lPrim1Bitis, tbSatici.lPrim1Oran, tbSatici.lPrim2Baslangic, tbSatici.lPrim2Bitis, tbSatici.lPrim2Oran, tbSatici.lPrim3Baslangic, tbSatici.lPrim3Bitis, tbSatici.lPrim3Oran, tbSatici.lPrim4Baslangic, tbSatici.lPrim4Bitis, tbSatici.lPrim4Oran, tbSatici.lPrim5Baslangic, tbSatici.lPrim5Bitis, tbSatici.lPrim5Oran,tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT, tbFSinif1.sAciklama AS SINIF1, tbFSinif2.sAciklama AS SINIF2, tbFSinif3.sAciklama AS SINIF3, tbFSinif4.sAciklama AS SINIF4, tbFSinif5.sAciklama AS SINIF5, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail], (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND dteIslemTarihi <= '" & tarih2 & "') AS lBakiye, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lSonBakiye, (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk, (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk, (SELECT TOP 1 dteFisTarihi FROM tbStokFisiMaster WHERE (sFisTipi = 'FS') AND tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID AND tbStokFisiMaster.nGirisCikis = 3 AND dteFisTarihi <= '" & tarih2 & "' ORDER BY dteFisTarihi DESC) AS dteSonSatisTarihi, (SELECT SUM(lAlacakTutar) AS lTahsilat FROM tbFirmaHareketi WHERE (lAlacakTutar > 0) AND (dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND nFirmaID = tbFirma.nFirmaID) AS lTahsilat, (SELECT ISNULL(SUM(tHareket.lBorcTutar),0) AS lTahsilat FROM tbFirma tFirma INNER JOIN tbFirmaHareketi tHareket ON tFirma.nFirmaID = tHareket.nFirmaID WHERE (tFirma.sKodu LIKE '800%') AND (tFirma.sKodu LIKE '%-18-%') AND tFirma.sSaticiRumuzu = tbFirma.sSaticiRumuzu and (tHareket.lBorcTutar > 0) AND (tHareket.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) AS lIskonto,(SELECT TOP 1 dteIslemTarihi FROM tbFirmaHareketi WHERE (lAlacakTutar > 0) AND (dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND nFirmaID = tbFirma.nFirmaID ORDER BY dteIslemTarihi DESC) AS dteSonTahsilatTarihi FROM tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu RIGHT OUTER JOIN tbFirma LEFT OUTER JOIN tbFirmaAciklamasi ON tbFirma.nFirmaID = tbFirmaAciklamasi.nFirmaID ON tbFirmaSinifi.nFirmaID = tbFirma.nFirmaID INNER JOIN tbSatici ON tbFirma.sSaticiRumuzu = tbSatici.sSaticiRumuzu " & kriter & ") Firma LEFT OUTER JOIN (SELECT nFirmaID, SUM(lKalan) AS lSiparisMiktar, SUM(lTutari) AS lSiparisTutarDahil, SUM(lIskontosuzTutari) AS lTutar FROM (SELECT tbFirma.nFirmaID, ISNULL(tbSiparis.lMiktari, 0) - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) AS lKalan, ((tbSiparis.lTutari / tbSiparis.lMiktari) * (tbSiparis.lMiktari - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0))) * (100 + tbSiparis.nKdvOrani) / 100 AS lTutari, (ISNULL(tbSiparis.lIskontosuzTutari / tbSiparis.lMiktari, 1) * (tbSiparis.lMiktari - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0))) * (100 + tbSiparis.nKdvOrani) / 100 AS lIskontosuzTutari FROM tbFirma INNER JOIN tbSiparis ON tbFirma.nFirmaID = tbSiparis.nFirmaID INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID LEFT OUTER JOIN tbStokFisiDetayi WITH(INDEX (tbStokFisiDetayi_index12)) ON tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID WHERE (tbSiparis.bKapandimi = 0) AND (tbSiparis.lSiparisNo BETWEEN 1 AND 999999999) AND (tbSiparis.dteSiparisTarihi BETWEEN '01/01/1900' AND '" & tarih2 & "') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 1, 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 31, 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (tbSiparis.nSiparisTipi = 1) GROUP BY tbFirma.nFirmaID, tbSiparis.nSiparisID, tbSiparis.lMiktari, tbSiparis.nKdvOrani, tbSiparis.lFiyati, tbSiparis.lTutari, tbSiparis.nIskontoYuzdesi, tbSiparis.lIskontosuzTutari HAVING (ISNULL(tbSiparis.lMiktari, 0) - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) <> 0)) DERIVEDTBL GROUP BY nFirmaID) Siparis ON Firma.nFirmaID = Siparis.nFirmaID LEFT OUTER JOIN (SELECT nFirmaID, SUM(lSatis) AS lSatis, SUM(lIade) AS lIade, SUM(lSatis - abs(lIade)) AS lNet, SUM(lMaliyet) AS lMaliyet, SUM(lSatis - abs(lIade)) - SUM(lMaliyet) AS lKar FROM (SELECT nFirmaID, SUM(CAST(lCikisTutar * (100 + nKdvOrani) / 100 AS FLOAT)) AS lSatis, CAST(0 AS Money) AS lIade, SUM(CAST(lMaliyetTutar AS FLOAT)) AS lMaliyet, CAST(0 AS Money) AS lKar, CAST(0 AS Money) AS lOran FROM tbStokFisiDetayi WHERE (sFisTipi IN (" & sFisTipi_kriter & ")) AND (nGirisCikis = 3) AND dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY nFirmaID, nGirisCikis UNION ALL SELECT nFirmaID, CAST(0 AS Money) AS lSatis, SUM(CAST(lCikisTutar * (100 + nKdvOrani) / 100 AS FLOAT)) AS lIade, SUM(CAST(lMaliyetTutar AS FLOAT)) AS lMaliyet, CAST(0 AS Money) AS lKar, CAST(0 AS Money) AS lOran FROM tbStokFisiDetayi WHERE (sFisTipi IN (" & sFisTipi_kriter & ")) AND (nGirisCikis = 4) AND dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY nFirmaID, nGirisCikis) DERIVEDTBL GROUP BY nFirmaID) Satis ON Firma.nFirmaID = Satis.nFirmaID GROUP BY sSaticiRumuzu,sAdi, sSoyadi, nPrim, lSabitPrim, lPrim1Baslangic, lPrim1Bitis, lPrim1Oran, lPrim2Baslangic, lPrim2Bitis, lPrim2Oran, lPrim3Baslangic, lPrim3Bitis, lPrim3Oran, lPrim4Baslangic, lPrim4Bitis, lPrim4Oran, lPrim5Baslangic, lPrim5Bitis, lPrim5Oran Order by sSaticiRumuzu")
            End If
        ElseIf sModul = "Perakende" Then
            ' cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *,Satis.Net-ISKONTO AS lNet,Satis.Kar-ISKONTO as lKar,lOran = CASE WHEN (Satis.Kar-ISKONTO) <> 0 AND (Satis.lMaliyet) <> 0 THEN ((Satis.Kar-ISKONTO) / (Satis.lMaliyet))  ELSE 0 END FROM (SELECT sSaticiRumuzu AS SINIF, sAdi, sSoyadi, nPrim, lSabitPrim, lPrim1Baslangic, lPrim1Bitis, lPrim1Oran, lPrim2Baslangic, lPrim2Bitis, lPrim2Oran, lPrim3Baslangic, lPrim3Bitis, lPrim3Oran, lPrim4Baslangic, lPrim4Bitis, lPrim4Oran, lPrim5Baslangic, lPrim5Bitis, lPrim5Oran,CAST(0 AS MONEY) AS lPrim1,CAST(0 AS MONEY) AS lPrim2,CAST(0 AS MONEY) AS lPrim3,CAST(0 AS MONEY) AS lPrim4,CAST(0 AS MONEY) AS lPrim5,CAST(0 AS MONEY) AS lNetPrim, SUM(Firma.lBakiye) AS lBakiye,CAST(0 AS MONEY) lGecikenBakiye, CAST(0 AS MONEY) AS lGecikenKesinti,SUM(lSonBakiye) AS lSonBakiye, SUM(lTahsilat) AS lTahsilat, MAX(lIskonto) AS ISKONTO,SUM(CekRisk) AS CekRisk, SUM(SenetRisk) AS SenetRisk, SUM(Siparis.lSiparisMiktar) AS lSiparisMiktar, SUM(Siparis.lSiparisTutarDahil) AS lSiparisDahilTutar, SUM(Siparis.lTutar) AS lSiparisTutar FROM (SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti, tbFirma.sSemt, tbFirma.sIl, tbFirma.sUlke, tbSatici.sSaticiRumuzu,tbSatici.sAdi, tbSatici.sSoyadi, tbSatici.nPrim, tbSatici.lSabitPrim, tbSatici.lPrim1Baslangic, tbSatici.lPrim1Bitis, tbSatici.lPrim1Oran, tbSatici.lPrim2Baslangic, tbSatici.lPrim2Bitis, tbSatici.lPrim2Oran, tbSatici.lPrim3Baslangic, tbSatici.lPrim3Bitis, tbSatici.lPrim3Oran, tbSatici.lPrim4Baslangic, tbSatici.lPrim4Bitis, tbSatici.lPrim4Oran, tbSatici.lPrim5Baslangic, tbSatici.lPrim5Bitis, tbSatici.lPrim5Oran,tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT, tbFSinif1.sAciklama AS SINIF1, tbFSinif2.sAciklama AS SINIF2, tbFSinif3.sAciklama AS SINIF3, tbFSinif4.sAciklama AS SINIF4, tbFSinif5.sAciklama AS SINIF5, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail], (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND dteIslemTarihi <= '" & tarih2 & "') AS lBakiye, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lSonBakiye, (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk, (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk, (SELECT TOP 1 dteFisTarihi FROM tbStokFisiMaster WHERE (sFisTipi IN ('K','P')) AND tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID AND tbStokFisiMaster.nGirisCikis = 3 AND dteFisTarihi <= '" & tarih2 & "' ORDER BY dteFisTarihi DESC) AS dteSonSatisTarihi, (SELECT SUM(lAlacakTutar) AS lTahsilat FROM tbFirmaHareketi WHERE (lAlacakTutar > 0) AND (dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND nFirmaID = tbFirma.nFirmaID) AS lTahsilat,(SELECT ISNULL(SUM(tHareket.lBorcTutar),0) AS lTahsilat FROM tbFirma tFirma INNER JOIN tbFirmaHareketi tHareket ON tFirma.nFirmaID = tHareket.nFirmaID WHERE (tFirma.sKodu LIKE '800%') AND (tFirma.sKodu LIKE '%-18-%') AND tFirma.sSaticiRumuzu = tbFirma.sSaticiRumuzu and (tHareket.lBorcTutar > 0) AND (tHareket.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) AS lIskonto, (SELECT TOP 1 dteIslemTarihi FROM tbFirmaHareketi WHERE (lAlacakTutar > 0) AND (dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND nFirmaID = tbFirma.nFirmaID ORDER BY dteIslemTarihi DESC) AS dteSonTahsilatTarihi FROM tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu RIGHT OUTER JOIN tbFirma LEFT OUTER JOIN tbFirmaAciklamasi ON tbFirma.nFirmaID = tbFirmaAciklamasi.nFirmaID ON tbFirmaSinifi.nFirmaID = tbFirma.nFirmaID RIGHT OUTER JOIN tbSatici ON tbFirma.sSaticiRumuzu = tbSatici.sSaticiRumuzu ) Firma LEFT OUTER JOIN (SELECT nFirmaID, SUM(lKalan) AS lSiparisMiktar, SUM(lTutari) AS lSiparisTutarDahil, SUM(lIskontosuzTutari) AS lTutar FROM (SELECT tbFirma.nFirmaID, ISNULL(tbSiparis.lMiktari, 0) - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) AS lKalan, ((tbSiparis.lTutari / tbSiparis.lMiktari) * (tbSiparis.lMiktari - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0))) * (100 + tbSiparis.nKdvOrani) / 100 AS lTutari, (ISNULL(tbSiparis.lIskontosuzTutari / tbSiparis.lMiktari, 1) * (tbSiparis.lMiktari - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0))) * (100 + tbSiparis.nKdvOrani) / 100 AS lIskontosuzTutari FROM tbFirma INNER JOIN tbSiparis ON tbFirma.nFirmaID = tbSiparis.nFirmaID INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID LEFT OUTER JOIN tbStokFisiDetayi WITH(INDEX (tbStokFisiDetayi_index12)) ON tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID WHERE (tbSiparis.bKapandimi = 0) AND (tbSiparis.lSiparisNo BETWEEN 1 AND 999999999) AND (tbSiparis.dteSiparisTarihi BETWEEN '01/01/1900' AND '" & tarih2 & "') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 1, 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 31, 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (tbSiparis.nSiparisTipi = 1) GROUP BY tbFirma.nFirmaID, tbSiparis.nSiparisID, tbSiparis.lMiktari, tbSiparis.nKdvOrani, tbSiparis.lFiyati, tbSiparis.lTutari, tbSiparis.nIskontoYuzdesi, tbSiparis.lIskontosuzTutari HAVING (ISNULL(tbSiparis.lMiktari, 0) - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) <> 0)) DERIVEDTBL GROUP BY nFirmaID) Siparis ON Firma.nFirmaID = Siparis.nFirmaID GROUP BY sSaticiRumuzu,sAdi, sSoyadi, nPrim, lSabitPrim, lPrim1Baslangic, lPrim1Bitis, lPrim1Oran, lPrim2Baslangic, lPrim2Bitis, lPrim2Oran, lPrim3Baslangic, lPrim3Bitis, lPrim3Oran, lPrim4Baslangic, lPrim4Bitis, lPrim4Oran, lPrim5Baslangic, lPrim5Bitis, lPrim5Oran ) SaticiListesi LEFT OUTER JOIN (SELECT sSaticiRumuzu, SUM(lSatis) AS lSatis, SUM(lIade) AS lIade, SUM(lSatis - abs(lIade)) AS Net, SUM(lMaliyet) AS lMaliyet, SUM(lSatis - abs(lIade)) - SUM(lMaliyet) AS Kar FROM (SELECT sSaticiRumuzu, SUM(CAST(lCikisTutar * (100 + nKdvOrani) / 100 AS FLOAT)) AS lSatis, CAST(0 AS Money) AS lIade, SUM(CAST(lMaliyetTutar  AS FLOAT)) AS lMaliyet, CAST(0 AS Money) AS lKar, CAST(0 AS Money) AS lOran FROM tbStokFisiDetayi WHERE (sFisTipi IN (" & sFisTipi_kriter & ")) AND (nGirisCikis = 3) AND dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY sSaticiRumuzu, nGirisCikis UNION ALL SELECT sSaticiRumuzu, CAST(0 AS Money) AS lSatis, SUM(CAST(lCikisTutar * (100 + nKdvOrani) / 100 AS FLOAT)) AS lIade, SUM(CAST(lMaliyetTutar  AS FLOAT)) AS lMaliyet, CAST(0 AS Money) AS lKar, CAST(0 AS Money) AS lOran FROM tbStokFisiDetayi WHERE (sFisTipi IN (" & sFisTipi_kriter & ")) AND (nGirisCikis = 4) AND dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY sSaticiRumuzu, nGirisCikis) DERIVEDTBL GROUP BY sSaticiRumuzu) Satis ON SaticiListesi.SINIF = Satis.sSaticiRumuzu Order by SaticiListesi.SINIF")
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *,Satis.Net-ISKONTO AS lNet,Satis.Kar-ISKONTO as lKar,lOran = CASE WHEN (Satis.Kar-ISKONTO) <> 0 AND (Satis.lMaliyet) <> 0 THEN ((Satis.Kar-ISKONTO) / (Satis.lMaliyet))  ELSE 0 END FROM (SELECT sSaticiRumuzu AS SINIF, sAdi, sSoyadi, nPrim, lSabitPrim, lPrim1Baslangic, lPrim1Bitis, lPrim1Oran, lPrim2Baslangic, lPrim2Bitis, lPrim2Oran, lPrim3Baslangic, lPrim3Bitis, lPrim3Oran, lPrim4Baslangic, lPrim4Bitis, lPrim4Oran, lPrim5Baslangic, lPrim5Bitis, lPrim5Oran,CAST(0 AS MONEY) AS lPrim1,CAST(0 AS MONEY) AS lPrim2,CAST(0 AS MONEY) AS lPrim3,CAST(0 AS MONEY) AS lPrim4,CAST(0 AS MONEY) AS lPrim5,CAST(0 AS MONEY) AS lNetPrim, SUM(Firma.lBakiye) AS lBakiye,CAST(0 AS MONEY) lGecikenBakiye, CAST(0 AS MONEY) AS lGecikenKesinti,SUM(lSonBakiye) AS lSonBakiye, SUM(lTahsilat) AS lTahsilat, MAX(lIskonto) AS ISKONTO,SUM(CekRisk) AS CekRisk, SUM(SenetRisk) AS SenetRisk, SUM(Siparis.lSiparisMiktar) AS lSiparisMiktar, SUM(Siparis.lSiparisTutarDahil) AS lSiparisDahilTutar, SUM(Siparis.lTutar) AS lSiparisTutar FROM (SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti, tbFirma.sSemt, tbFirma.sIl, tbFirma.sUlke, tbSatici.sSaticiRumuzu,tbSatici.sAdi, tbSatici.sSoyadi, tbSatici.nPrim, tbSatici.lSabitPrim, tbSatici.lPrim1Baslangic, tbSatici.lPrim1Bitis, tbSatici.lPrim1Oran, tbSatici.lPrim2Baslangic, tbSatici.lPrim2Bitis, tbSatici.lPrim2Oran, tbSatici.lPrim3Baslangic, tbSatici.lPrim3Bitis, tbSatici.lPrim3Oran, tbSatici.lPrim4Baslangic, tbSatici.lPrim4Bitis, tbSatici.lPrim4Oran, tbSatici.lPrim5Baslangic, tbSatici.lPrim5Bitis, tbSatici.lPrim5Oran,tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT, tbFSinif1.sAciklama AS SINIF1, tbFSinif2.sAciklama AS SINIF2, tbFSinif3.sAciklama AS SINIF3, tbFSinif4.sAciklama AS SINIF4, tbFSinif5.sAciklama AS SINIF5, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail], (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND dteIslemTarihi <= '" & tarih2 & "') AS lBakiye, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lSonBakiye, (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk, (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk, (SELECT TOP 1 dteFisTarihi FROM tbStokFisiMaster WHERE (sFisTipi IN ('K','P')) AND tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID AND tbStokFisiMaster.nGirisCikis = 3 AND dteFisTarihi <= '" & tarih2 & "' ORDER BY dteFisTarihi DESC) AS dteSonSatisTarihi, (SELECT SUM(lAlacakTutar) AS lTahsilat FROM tbFirmaHareketi WHERE (lAlacakTutar > 0) AND (dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND nFirmaID = tbFirma.nFirmaID) AS lTahsilat,(SELECT ISNULL(SUM(tHareket.lBorcTutar),0) AS lTahsilat FROM tbFirma tFirma INNER JOIN tbFirmaHareketi tHareket ON tFirma.nFirmaID = tHareket.nFirmaID WHERE (tFirma.sKodu LIKE '800%') AND (tFirma.sKodu LIKE '%-18-%') AND tFirma.sSaticiRumuzu = tbFirma.sSaticiRumuzu and (tHareket.lBorcTutar > 0) AND (tHareket.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) AS lIskonto, (SELECT TOP 1 dteIslemTarihi FROM tbFirmaHareketi WHERE (lAlacakTutar > 0) AND (dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND nFirmaID = tbFirma.nFirmaID ORDER BY dteIslemTarihi DESC) AS dteSonTahsilatTarihi FROM tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu RIGHT OUTER JOIN tbFirma LEFT OUTER JOIN tbFirmaAciklamasi ON tbFirma.nFirmaID = tbFirmaAciklamasi.nFirmaID ON tbFirmaSinifi.nFirmaID = tbFirma.nFirmaID RIGHT OUTER JOIN tbSatici ON tbFirma.sSaticiRumuzu = tbSatici.sSaticiRumuzu ) Firma LEFT OUTER JOIN (SELECT nFirmaID, SUM(lKalan) AS lSiparisMiktar, SUM(lTutari) AS lSiparisTutarDahil, SUM(lIskontosuzTutari) AS lTutar FROM (SELECT tbFirma.nFirmaID, ISNULL(tbSiparis.lMiktari, 0) - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) AS lKalan, ((tbSiparis.lTutari / tbSiparis.lMiktari) * (tbSiparis.lMiktari - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0))) * (100 + tbSiparis.nKdvOrani) / 100 AS lTutari, (ISNULL(tbSiparis.lIskontosuzTutari / tbSiparis.lMiktari, 1) * (tbSiparis.lMiktari - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0))) * (100 + tbSiparis.nKdvOrani) / 100 AS lIskontosuzTutari FROM tbFirma INNER JOIN tbSiparis ON tbFirma.nFirmaID = tbSiparis.nFirmaID INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID LEFT OUTER JOIN tbStokFisiDetayi WITH(INDEX (tbStokFisiDetayi_index12)) ON tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID WHERE (tbSiparis.bKapandimi = 0) AND (tbSiparis.lSiparisNo BETWEEN 1 AND 999999999) AND (tbSiparis.dteSiparisTarihi BETWEEN '01/01/1900' AND '" & tarih2 & "') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 1, 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 31, 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (tbSiparis.nSiparisTipi = 1) GROUP BY tbFirma.nFirmaID, tbSiparis.nSiparisID, tbSiparis.lMiktari, tbSiparis.nKdvOrani, tbSiparis.lFiyati, tbSiparis.lTutari, tbSiparis.nIskontoYuzdesi, tbSiparis.lIskontosuzTutari HAVING (ISNULL(tbSiparis.lMiktari, 0) - ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) <> 0)) DERIVEDTBL GROUP BY nFirmaID) Siparis ON Firma.nFirmaID = Siparis.nFirmaID GROUP BY sSaticiRumuzu,sAdi, sSoyadi, nPrim, lSabitPrim, lPrim1Baslangic, lPrim1Bitis, lPrim1Oran, lPrim2Baslangic, lPrim2Bitis, lPrim2Oran, lPrim3Baslangic, lPrim3Bitis, lPrim3Oran, lPrim4Baslangic, lPrim4Bitis, lPrim4Oran, lPrim5Baslangic, lPrim5Bitis, lPrim5Oran ) SaticiListesi LEFT OUTER JOIN (SELECT sSaticiRumuzu, SUM(lSatis) AS lSatis, SUM(lIade) AS lIade, SUM(lSatis - abs(lIade)) AS Net, SUM(lMaliyet) AS lMaliyet, SUM(lSatis - abs(lIade)) - SUM(lMaliyet) AS Kar FROM (SELECT sSaticiRumuzu, SUM(CAST(lCikisTutar * (100 + nKdvOrani) / 100 AS FLOAT)) AS lSatis, CAST(0 AS Money) AS lIade, SUM(CAST(lMaliyetTutar  AS FLOAT)) AS lMaliyet, CAST(0 AS Money) AS lKar, CAST(0 AS Money) AS lOran FROM tbStokFisiDetayi WHERE (sFisTipi IN (" & sFisTipi_kriter & ")) AND (nGirisCikis = 3) AND dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY sSaticiRumuzu, nGirisCikis UNION ALL SELECT sSaticiRumuzu, CAST(0 AS Money) AS lSatis, SUM(CAST(lCikisTutar * (100 + nKdvOrani) / 100 AS FLOAT)) AS lIade, SUM(CAST(lMaliyetTutar  AS FLOAT)) AS lMaliyet, CAST(0 AS Money) AS lKar, CAST(0 AS Money) AS lOran FROM tbStokFisiDetayi WHERE (sFisTipi IN (" & sFisTipi_kriter & ")) AND (nGirisCikis = 4) AND dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY sSaticiRumuzu, nGirisCikis) DERIVEDTBL GROUP BY sSaticiRumuzu) Satis ON SaticiListesi.SINIF = Satis.sSaticiRumuzu Order by SaticiListesi.SINIF")

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
    Private Sub dataload(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sSiniflandirma As String, ByVal sSaticiRumuzu As String, ByVal nGun1 As Int64, ByVal nGun2 As Int64, ByVal nVadeFarki As Decimal)
        DataSet1 = stok(ara, konum, ara_kriter, tarih1, tarih2, sSiniflandirma, sSaticiRumuzu)
        Dim dr As DataRow
        Dim lToplamKar As Decimal = 0
        Dim lToplamMaliyet As Decimal = 0
        Dim nYuzdelik As Decimal = 0
        For Each dr In DataSet1.Tables(0).Rows
            dr("lSatis") = sorgu_sayi(dr("lSatis"), 0)
            dr("lIade") = sorgu_sayi(dr("lIade"), 0)
            dr("lMaliyet") = sorgu_sayi(dr("lMaliyet"), 0)
            dr("lNet") = sorgu_sayi(dr("lNet"), 0)
            dr("lKar") = sorgu_sayi(dr("lKar"), 0)
            dr("lGecikenBakiye") = sorgu_sayi(sorgu_lKalanBakiye(dr("SINIF"), txt_nGun1.EditValue, txt_nGun2.EditValue, txt_nVadeFarki.EditValue), 0)
            If txt_nVadeFarki.EditValue <> 0 And dr("lGecikenBakiye") <> 0 Then
                dr("lGecikenKesinti") = (dr("lGecikenBakiye") * txt_nVadeFarki.EditValue) / 100
            Else
                dr("lGecikenKesinti") = 0
            End If
            If dr("lPrim1Oran") <> 0 Then
                If dr("lNet") <= dr("lPrim1Bitis") And dr("lNet") >= dr("lPrim1Baslangic") Then
                    dr("lPrim1") = (dr("lNet") * dr("lPrim1Oran")) / 100
                ElseIf dr("lNet") <= dr("lPrim2Bitis") And dr("lNet") >= dr("lPrim2Baslangic") Then
                    dr("lPrim2") = (dr("lNet") * dr("lPrim2Oran")) / 100
                ElseIf dr("lNet") <= dr("lPrim3Bitis") And dr("lNet") >= dr("lPrim3Baslangic") Then
                    dr("lPrim3") = (dr("lNet") * dr("lPrim3Oran")) / 100
                ElseIf dr("lNet") <= dr("lPrim4Bitis") And dr("lNet") >= dr("lPrim4Baslangic") Then
                    dr("lPrim4") = (dr("lNet") * dr("lPrim4Oran")) / 100
                ElseIf dr("lNet") <= dr("lPrim5Bitis") And dr("lNet") >= dr("lPrim5Baslangic") Then
                    dr("lPrim5") = (dr("lNet") * dr("lPrim5Oran")) / 100
                End If
                dr("lNetPrim") = (dr("lSabitPrim") + dr("lPrim1") + dr("lPrim2") + dr("lPrim3") + dr("lPrim4") + dr("lPrim5")) - dr("lGecikenKesinti")
                Try
                    dr("nPrim") = dr("lNetPrim") / dr("lNet")
                Catch ex As Exception
                    dr("nPrim") = 0
                End Try
            Else
                dr("lNetPrim") = dr("lSabitPrim") + ((dr("lNet") * dr("nPrim")) / 100)
            End If
            lToplamKar = lToplamKar + sorgu_sayi(dr("lKar"), 0)
            lToplamMaliyet = lToplamMaliyet + sorgu_sayi(dr("lMaliyet"), 0)
        Next
        dr = Nothing
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
        GridView1.BestFitColumns()
        Try
            nYuzdelik = (lToplamKar / lToplamMaliyet) * 100
        Catch ex As Exception
            nYuzdelik = 0
        End Try
        collOran.SummaryItem.DisplayFormat = "%" & FormatNumber(nYuzdelik, 2).ToString
        'Sınıflandırma Satışları
        lToplamKar = 0
        lToplamMaliyet = 0
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
    Private Sub analiz_Firma_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_firma_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sKodu = dr("sKodu")
            frm.nFirmaID = dr("nFirmaID")
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
    Private Sub analiz_cari_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_hareketler_ozet
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(dr("sKodu")))) = True Then
                    frm.ShowDialog()
                End If
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
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stok_satis_detay()
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
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
        Try
            If GridView1.RowCount > 0 Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                lbl_istihbarat.Text = dr("ISTIHBARAT").ToString
                dr = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            'If XtraMessageBox.Show(Sorgu_sDil("Açık Faturalar Kontrol Ekranından Çıkmak İstediğinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If islemstatus = True Then
            If GridView1.RowCount > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                XtraMessageBox.Show(Sorgu_sDil("Kayıt Bulunamadı", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            Me.Close()
        End If
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ara()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        analiz_Firma_karti()
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
        dataload(txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, DateEdit1.EditValue, DateEdit2.EditValue, "", sec_depo.Text, txt_nGun1.EditValue, txt_nGun2.EditValue, txt_nVadeFarki.EditValue)
        Label2.Text = Sorgu_sDil("Tamamlandı...", sDil)
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
                    XtraMessageBox.Show(Sorgu_sDil("Kayıt Bulunamadı", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
            End If
        End If
    End Sub
    Private Sub MenuItem16_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_iletisim()
    End Sub
    Private Sub MenuItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        If MenuItem17.Checked = False Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowAutoFilterRow = True
            MenuItem17.Checked = True
        ElseIf MenuItem17.Checked = True Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowAutoFilterRow = False
            MenuItem17.Checked = False
        End If
    End Sub
    Private Sub MenuItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        analiz_cari_hareket()
    End Sub

    Private Sub sec_depo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_depo.QueryPopUp
        sec_depo.Properties.PopupControl = sec_grid
        GridControl2.DataSource = ds_satici.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_depo_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_depo.QueryResultValue
        Dim s As String = deger(ds_satici)
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
        Return s.ToString
    End Function

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

    Private Sub GridView2_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView2.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub

End Class
