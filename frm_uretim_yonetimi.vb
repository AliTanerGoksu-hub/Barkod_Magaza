Imports DevExpress.XtraEditors
Public Class frm_uretim_yonetimi
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
    Friend WithEvents panel_info As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents panel_mesaj As DevExpress.XtraEditors.PanelControl
    Friend WithEvents panel_baslik As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SplitterControl2 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents panel_hareket As DevExpress.XtraEditors.PanelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents VGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem5 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ds_baslik As System.Data.DataSet
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
    Friend WithEvents rowIND As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSTOKNO As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKULLANICI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSONERISIMTARIHI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowTUTAR As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSTOKKODU As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMALINCINSI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowBIRIM As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowFIYAT As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowKDV As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowOZELKOD As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowACIKLAMA As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSATISFIYATI As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowRESIM As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents DataSet2 As System.Data.DataSet
    Friend WithEvents DataSet3 As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
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
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDETAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFISNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMALINCINSI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTERMIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURETIMEBASLAMATARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURETIMBITISTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURETIMYERIKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOZELKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_resim As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents BarButtonItem17 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem6 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem18 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem19 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem20 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem21 As DevExpress.XtraBars.BarButtonItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_uretim_yonetimi))
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.panel_info = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.panel_mesaj = New DevExpress.XtraEditors.PanelControl()
        Me.panel_baslik = New DevExpress.XtraEditors.PanelControl()
        Me.VGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
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
        Me.sec_resim = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.rowIND = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSTOKNO = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKULLANICI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSONERISIMTARIHI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSTOKKODU = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMALINCINSI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBIRIM = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSATISFIYATI = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowFIYAT = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowKDV = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowOZELKOD = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowACIKLAMA = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowRESIM = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowTUTAR = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.SplitterControl2 = New DevExpress.XtraEditors.SplitterControl()
        Me.panel_hareket = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.DataSet2 = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
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
        Me.DataColumn27 = New System.Data.DataColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDETAY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFISNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOKKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMALINCINSI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTERMIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURETIMEBASLAMATARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURETIMBITISTARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colURETIMYERIKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOZELKOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem21 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem20 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem5 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem6 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem18 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem19 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.DataSet3 = New System.Data.DataSet()
        CType(Me.panel_info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_info.SuspendLayout()
        CType(Me.panel_mesaj, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_baslik.SuspendLayout()
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_resim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel_hareket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_hareket.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(0, 22)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(6, 537)
        Me.SplitterControl1.TabIndex = 1
        Me.SplitterControl1.TabStop = False
        Me.SplitterControl1.Visible = False
        '
        'panel_info
        '
        Me.panel_info.Controls.Add(Me.SimpleButton2)
        Me.panel_info.Controls.Add(Me.SimpleButton1)
        Me.panel_info.Controls.Add(Me.Label2)
        Me.panel_info.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_info.Location = New System.Drawing.Point(6, 22)
        Me.panel_info.Name = "panel_info"
        Me.panel_info.Size = New System.Drawing.Size(818, 28)
        Me.panel_info.TabIndex = 2
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Appearance.Options.UseForeColor = True
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(793, 2)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(24, 25)
        Me.SimpleButton2.TabIndex = 8
        Me.SimpleButton2.Text = ">>"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(769, 2)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(24, 25)
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "<<"
        '
        'Label2
        '
        Me.Label2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Appearance.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(2, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "[Üretim : ]"
        '
        'panel_mesaj
        '
        Me.panel_mesaj.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_mesaj.Location = New System.Drawing.Point(6, 516)
        Me.panel_mesaj.Name = "panel_mesaj"
        Me.panel_mesaj.Size = New System.Drawing.Size(818, 43)
        Me.panel_mesaj.TabIndex = 3
        Me.panel_mesaj.Visible = False
        '
        'panel_baslik
        '
        Me.panel_baslik.Controls.Add(Me.VGridControl1)
        Me.panel_baslik.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_baslik.Location = New System.Drawing.Point(6, 50)
        Me.panel_baslik.Name = "panel_baslik"
        Me.panel_baslik.Size = New System.Drawing.Size(818, 156)
        Me.panel_baslik.TabIndex = 4
        '
        'VGridControl1
        '
        Me.VGridControl1.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.VGridControl1.Appearance.Empty.Options.UseBackColor = True
        Me.VGridControl1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Transparent
        Me.VGridControl1.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.Transparent
        Me.VGridControl1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.VGridControl1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.VGridControl1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.VGridControl1.BandsInterval = 3
        Me.VGridControl1.CustomizationFormBounds = New System.Drawing.Rectangle(806, 387, 208, 252)
        Me.VGridControl1.DataSource = Me.ds_baslik
        Me.VGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.BandsView
        Me.VGridControl1.Location = New System.Drawing.Point(2, 2)
        Me.VGridControl1.Name = "VGridControl1"
        Me.VGridControl1.OptionsBehavior.Editable = False
        Me.VGridControl1.RecordWidth = 197
        Me.VGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_resim})
        Me.VGridControl1.RowHeaderWidth = 138
        Me.VGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowIND, Me.rowSTOKNO, Me.rowKULLANICI, Me.rowSONERISIMTARIHI, Me.rowSTOKKODU, Me.rowMALINCINSI, Me.rowBIRIM, Me.rowSATISFIYATI, Me.rowFIYAT, Me.rowKDV, Me.rowOZELKOD, Me.rowACIKLAMA, Me.rowRESIM, Me.rowTUTAR})
        Me.VGridControl1.Size = New System.Drawing.Size(814, 152)
        Me.VGridControl1.TabIndex = 0
        Me.VGridControl1.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView
        '
        'ds_baslik
        '
        Me.ds_baslik.DataSetName = "NewDataSet"
        Me.ds_baslik.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_baslik.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14})
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
        Me.DataColumn3.ColumnName = "KULLANICI"
        Me.DataColumn3.DataType = GetType(Long)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "SONERISIMTARIHI"
        Me.DataColumn4.DataType = GetType(Date)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "TUTAR"
        Me.DataColumn5.DataType = GetType(Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "STOKKODU"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "MALINCINSI"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "BIRIM"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "FIYAT"
        Me.DataColumn9.DataType = GetType(Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "KDV"
        Me.DataColumn10.DataType = GetType(Long)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "OZELKOD"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "ACIKLAMA"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "SATISFIYATI"
        Me.DataColumn13.DataType = GetType(Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "RESIM"
        Me.DataColumn14.DataType = GetType(Byte())
        '
        'sec_resim
        '
        Me.sec_resim.Name = "sec_resim"
        Me.sec_resim.NullText = "[Yüklü Resim Bulunamadý...]"
        Me.sec_resim.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        '
        'rowIND
        '
        Me.rowIND.Name = "rowIND"
        Me.rowIND.Properties.Caption = "Kayýt No"
        Me.rowIND.Properties.FieldName = "IND"
        Me.rowIND.Visible = False
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
        'rowSTOKKODU
        '
        Me.rowSTOKKODU.Name = "rowSTOKKODU"
        Me.rowSTOKKODU.Properties.Caption = "Stok Kodu"
        Me.rowSTOKKODU.Properties.FieldName = "STOKKODU"
        '
        'rowMALINCINSI
        '
        Me.rowMALINCINSI.Name = "rowMALINCINSI"
        Me.rowMALINCINSI.Properties.Caption = "Malýncýnsý"
        Me.rowMALINCINSI.Properties.FieldName = "MALINCINSI"
        '
        'rowBIRIM
        '
        Me.rowBIRIM.Name = "rowBIRIM"
        Me.rowBIRIM.Properties.Caption = "Birim"
        Me.rowBIRIM.Properties.FieldName = "BIRIM"
        '
        'rowSATISFIYATI
        '
        Me.rowSATISFIYATI.Name = "rowSATISFIYATI"
        Me.rowSATISFIYATI.Properties.Caption = "SatýþFiyatý"
        Me.rowSATISFIYATI.Properties.FieldName = "SATISFIYATI"
        Me.rowSATISFIYATI.Properties.Format.FormatString = "#,0.00"
        Me.rowSATISFIYATI.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowFIYAT
        '
        Me.rowFIYAT.Name = "rowFIYAT"
        Me.rowFIYAT.Properties.Caption = "Maliyet"
        Me.rowFIYAT.Properties.FieldName = "FIYAT"
        Me.rowFIYAT.Properties.Format.FormatString = "#,0.00"
        Me.rowFIYAT.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowKDV
        '
        Me.rowKDV.Name = "rowKDV"
        Me.rowKDV.Properties.Caption = "Kdv"
        Me.rowKDV.Properties.FieldName = "KDV"
        Me.rowKDV.Properties.Format.FormatString = "#,0"
        Me.rowKDV.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'rowOZELKOD
        '
        Me.rowOZELKOD.Name = "rowOZELKOD"
        Me.rowOZELKOD.Properties.Caption = "ÖzelKod"
        Me.rowOZELKOD.Properties.FieldName = "OZELKOD"
        '
        'rowACIKLAMA
        '
        Me.rowACIKLAMA.Name = "rowACIKLAMA"
        Me.rowACIKLAMA.Properties.Caption = "Açýklama"
        Me.rowACIKLAMA.Properties.FieldName = "ACIKLAMA"
        '
        'rowRESIM
        '
        Me.rowRESIM.Name = "rowRESIM"
        Me.rowRESIM.Properties.Caption = "Resim"
        Me.rowRESIM.Properties.FieldName = "RESIM"
        Me.rowRESIM.Properties.RowEdit = Me.sec_resim
        '
        'rowTUTAR
        '
        Me.rowTUTAR.Name = "rowTUTAR"
        Me.rowTUTAR.Properties.Caption = "ToplamMaliyet"
        Me.rowTUTAR.Properties.FieldName = "TUTAR"
        Me.rowTUTAR.Properties.Format.FormatString = "#,0.00"
        Me.rowTUTAR.Properties.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rowTUTAR.Visible = False
        '
        'SplitterControl2
        '
        Me.SplitterControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterControl2.Location = New System.Drawing.Point(6, 206)
        Me.SplitterControl2.Name = "SplitterControl2"
        Me.SplitterControl2.Size = New System.Drawing.Size(818, 6)
        Me.SplitterControl2.TabIndex = 5
        Me.SplitterControl2.TabStop = False
        '
        'panel_hareket
        '
        Me.panel_hareket.Controls.Add(Me.XtraTabControl1)
        Me.panel_hareket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_hareket.Location = New System.Drawing.Point(6, 212)
        Me.panel_hareket.Name = "panel_hareket"
        Me.panel_hareket.Size = New System.Drawing.Size(818, 304)
        Me.panel_hareket.TabIndex = 6
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(814, 300)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(812, 267)
        Me.XtraTabPage1.Text = "Üretim..."
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = Nothing
        Me.GridControl1.DataSource = Me.DataSet2
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(812, 267)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2, Me.GridView1})
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "NewDataSet"
        Me.DataSet2.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet2.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "IND"
        Me.DataColumn15.DataType = GetType(Long)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "KOD"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "DETAY"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "TARIH"
        Me.DataColumn18.DataType = GetType(Date)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "FISNO"
        Me.DataColumn19.DataType = GetType(Long)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "STOKKODU"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "MALINCINSI"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "MIKTAR"
        Me.DataColumn22.DataType = GetType(Decimal)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "TERMIN"
        Me.DataColumn23.DataType = GetType(Date)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "URETIMEBASLAMATARIHI"
        Me.DataColumn24.DataType = GetType(Date)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "URETIMBITISTARIHI"
        Me.DataColumn25.DataType = GetType(Date)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "URETIMYERIKODU"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "OZELKOD"
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
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.colKOD, Me.colDETAY, Me.colTARIH, Me.colFISNO, Me.colSTOKKODU, Me.colMALINCINSI, Me.colMIKTAR, Me.colTERMIN, Me.colURETIMEBASLAMATARIHI, Me.colURETIMBITISTARIHI, Me.colURETIMYERIKODU, Me.colOZELKOD})
        Me.GridView2.CustomizationFormBounds = New System.Drawing.Rectangle(576, 334, 208, 170)
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.IndicatorWidth = 35
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colIND
        '
        Me.colIND.Caption = "Kayýt No"
        Me.colIND.FieldName = "IND"
        Me.colIND.Name = "colIND"
        '
        'colKOD
        '
        Me.colKOD.Caption = "Durum"
        Me.colKOD.FieldName = "KOD"
        Me.colKOD.Name = "colKOD"
        Me.colKOD.Visible = True
        Me.colKOD.VisibleIndex = 9
        Me.colKOD.Width = 121
        '
        'colDETAY
        '
        Me.colDETAY.Caption = "Detay"
        Me.colDETAY.FieldName = "DETAY"
        Me.colDETAY.Name = "colDETAY"
        '
        'colTARIH
        '
        Me.colTARIH.Caption = "Tarih"
        Me.colTARIH.FieldName = "TARIH"
        Me.colTARIH.Name = "colTARIH"
        Me.colTARIH.Visible = True
        Me.colTARIH.VisibleIndex = 1
        Me.colTARIH.Width = 116
        '
        'colFISNO
        '
        Me.colFISNO.Caption = "Fiþ No"
        Me.colFISNO.FieldName = "FISNO"
        Me.colFISNO.Name = "colFISNO"
        Me.colFISNO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "FISNO", "{0} Kayýt")})
        Me.colFISNO.Visible = True
        Me.colFISNO.VisibleIndex = 0
        Me.colFISNO.Width = 116
        '
        'colSTOKKODU
        '
        Me.colSTOKKODU.Caption = "Stok Kodu"
        Me.colSTOKKODU.FieldName = "STOKKODU"
        Me.colSTOKKODU.Name = "colSTOKKODU"
        Me.colSTOKKODU.Visible = True
        Me.colSTOKKODU.VisibleIndex = 2
        Me.colSTOKKODU.Width = 116
        '
        'colMALINCINSI
        '
        Me.colMALINCINSI.Caption = "Stok Adý"
        Me.colMALINCINSI.FieldName = "MALINCINSI"
        Me.colMALINCINSI.Name = "colMALINCINSI"
        Me.colMALINCINSI.Visible = True
        Me.colMALINCINSI.VisibleIndex = 3
        Me.colMALINCINSI.Width = 199
        '
        'colMIKTAR
        '
        Me.colMIKTAR.Caption = "Miktar"
        Me.colMIKTAR.DisplayFormat.FormatString = "#,0.####"
        Me.colMIKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMIKTAR.FieldName = "MIKTAR"
        Me.colMIKTAR.Name = "colMIKTAR"
        Me.colMIKTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", "{0:#,0.####}")})
        Me.colMIKTAR.Visible = True
        Me.colMIKTAR.VisibleIndex = 4
        Me.colMIKTAR.Width = 101
        '
        'colTERMIN
        '
        Me.colTERMIN.Caption = "Termin"
        Me.colTERMIN.FieldName = "TERMIN"
        Me.colTERMIN.Name = "colTERMIN"
        Me.colTERMIN.Visible = True
        Me.colTERMIN.VisibleIndex = 5
        Me.colTERMIN.Width = 101
        '
        'colURETIMEBASLAMATARIHI
        '
        Me.colURETIMEBASLAMATARIHI.Caption = "ÜretimeBaþla"
        Me.colURETIMEBASLAMATARIHI.FieldName = "URETIMEBASLAMATARIHI"
        Me.colURETIMEBASLAMATARIHI.Name = "colURETIMEBASLAMATARIHI"
        Me.colURETIMEBASLAMATARIHI.Visible = True
        Me.colURETIMEBASLAMATARIHI.VisibleIndex = 7
        Me.colURETIMEBASLAMATARIHI.Width = 101
        '
        'colURETIMBITISTARIHI
        '
        Me.colURETIMBITISTARIHI.Caption = "ÜretimBitiþ"
        Me.colURETIMBITISTARIHI.FieldName = "URETIMBITISTARIHI"
        Me.colURETIMBITISTARIHI.Name = "colURETIMBITISTARIHI"
        Me.colURETIMBITISTARIHI.Visible = True
        Me.colURETIMBITISTARIHI.VisibleIndex = 8
        Me.colURETIMBITISTARIHI.Width = 142
        '
        'colURETIMYERIKODU
        '
        Me.colURETIMYERIKODU.Caption = "ÜretimYeri"
        Me.colURETIMYERIKODU.FieldName = "URETIMYERIKODU"
        Me.colURETIMYERIKODU.Name = "colURETIMYERIKODU"
        Me.colURETIMYERIKODU.Width = 49
        '
        'colOZELKOD
        '
        Me.colOZELKOD.Caption = "ÖzelKod"
        Me.colOZELKOD.FieldName = "OZELKOD"
        Me.colOZELKOD.Name = "colOZELKOD"
        Me.colOZELKOD.Visible = True
        Me.colOZELKOD.VisibleIndex = 6
        Me.colOZELKOD.Width = 120
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'BarManager1
        '
        Me.BarManager1.AllowCustomization = False
        Me.BarManager1.AllowMoveBarOnToolbar = False
        Me.BarManager1.AllowQuickCustomization = False
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarSubItem2, Me.BarSubItem3, Me.BarSubItem4, Me.BarSubItem5, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem9, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem5, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem15, Me.BarButtonItem16, Me.BarButtonItem17, Me.BarSubItem6, Me.BarButtonItem18, Me.BarButtonItem19, Me.BarButtonItem20, Me.BarButtonItem21})
        Me.BarManager1.MainMenu = Me.Bar1
        Me.BarManager1.MaxItemId = 27
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 1"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem6)})
        Me.Bar1.OptionsBar.MultiLine = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Custom 1"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Tanýmlar"
        Me.BarSubItem1.Id = 0
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem14)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Maliyet Unsurlarý"
        Me.BarButtonItem1.Id = 5
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Kalite Gruplarý"
        Me.BarButtonItem2.Id = 6
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Üretim Yerleri"
        Me.BarButtonItem3.Id = 7
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Üretim Pozisyonlarý"
        Me.BarButtonItem11.Id = 15
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Üretim Araçlarý"
        Me.BarButtonItem12.Id = 16
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Üretim Birimleri"
        Me.BarButtonItem13.Id = 17
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "Üretim Vardiyalarý"
        Me.BarButtonItem14.Id = 18
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Hareketler"
        Me.BarSubItem2.Id = 1
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem15), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem16)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "Hammadde Ýhtiyaç Tablosu"
        Me.BarButtonItem15.Id = 19
        Me.BarButtonItem15.Name = "BarButtonItem15"
        '
        'BarButtonItem16
        '
        Me.BarButtonItem16.Caption = "Genel Hammade Tablosu"
        Me.BarButtonItem16.Id = 20
        Me.BarButtonItem16.Name = "BarButtonItem16"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "Ýþlemler"
        Me.BarSubItem3.Id = 2
        Me.BarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem21), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem20), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem17, True)})
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Yeni Üretim Reçetesi"
        Me.BarButtonItem4.Id = 8
        Me.BarButtonItem4.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Insert))
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Yeni Üretim Planlamasý"
        Me.BarButtonItem6.Id = 10
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem21
        '
        Me.BarButtonItem21.Caption = "Yeni Satýn Alma Emri"
        Me.BarButtonItem21.Id = 26
        Me.BarButtonItem21.Name = "BarButtonItem21"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Üretim Reçetesi Listesi"
        Me.BarButtonItem9.Id = 9
        Me.BarButtonItem9.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5)
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Üretim Planlamasý Listesi"
        Me.BarButtonItem7.Id = 11
        Me.BarButtonItem7.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem20
        '
        Me.BarButtonItem20.Caption = "Satýn Alma Emirleri"
        Me.BarButtonItem20.Id = 25
        Me.BarButtonItem20.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem20.Name = "BarButtonItem20"
        '
        'BarButtonItem17
        '
        Me.BarButtonItem17.Caption = "Reçete Düzelt"
        Me.BarButtonItem17.Id = 21
        Me.BarButtonItem17.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
        Me.BarButtonItem17.Name = "BarButtonItem17"
        '
        'BarSubItem4
        '
        Me.BarSubItem4.Caption = "Raporlar"
        Me.BarSubItem4.Id = 3
        Me.BarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10)})
        Me.BarSubItem4.Name = "BarSubItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Üretim Raporu"
        Me.BarButtonItem5.Id = 13
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Planlama Raporu"
        Me.BarButtonItem10.Id = 14
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarSubItem5
        '
        Me.BarSubItem5.Caption = "Analiz"
        Me.BarSubItem5.Id = 4
        Me.BarSubItem5.Name = "BarSubItem5"
        '
        'BarSubItem6
        '
        Me.BarSubItem6.Caption = "Üretim"
        Me.BarSubItem6.Id = 22
        Me.BarSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem18), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem19)})
        Me.BarSubItem6.Name = "BarSubItem6"
        '
        'BarButtonItem18
        '
        Me.BarButtonItem18.Caption = "Yeni Ýþ Emri"
        Me.BarButtonItem18.Id = 23
        Me.BarButtonItem18.Name = "BarButtonItem18"
        '
        'BarButtonItem19
        '
        Me.BarButtonItem19.Caption = "Eski Ýþ Emirleri"
        Me.BarButtonItem19.Id = 24
        Me.BarButtonItem19.Name = "BarButtonItem19"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 559)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 537)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 537)
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "BarButtonItem8"
        Me.BarButtonItem8.Id = 12
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "NewDataSet"
        Me.DataSet3.Locale = New System.Globalization.CultureInfo("tr-TR")
        '
        'frm_uretim_yonetimi
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 559)
        Me.Controls.Add(Me.panel_hareket)
        Me.Controls.Add(Me.SplitterControl2)
        Me.Controls.Add(Me.panel_baslik)
        Me.Controls.Add(Me.panel_mesaj)
        Me.Controls.Add(Me.panel_info)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_uretim_yonetimi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Üretim Ýþlemleri"
        CType(Me.panel_info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_info.ResumeLayout(False)
        Me.panel_info.PerformLayout()
        CType(Me.panel_mesaj, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_baslik.ResumeLayout(False)
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_baslik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_resim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel_hareket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_hareket.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public connection
    Public firmano
    Public firma
    Public donemno
    Public donem
    Public stokno = 99
    Public stok
    Public userno
    Public username
    Public depono As Integer = 1
    Public kullanici As String = ""
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim dr As DataRow
    Private Sub frm_uretim_yonetimi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = connection
        cmd.Connection = con
        'stokno = 99
        If stokno = 99 Then
            stokno = stokno_bul(stokno, ">", "ASC")
        End If
        'stok_islemleri.firmano = firmano
        'stok_islemleri.firma = firma
        'stok_islemleri.donemno = donemno
        'stok_islemleri.donem = donem
        'stok_islemleri.userno = userno
        'stok_islemleri.username = username
        'stok_islemleri.connection = connection
        If stokno = 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Sisteme Kayýtlý Stok Kartý Bulunamadý ! Yeni Kayýt Eklemek Ýstermisiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                'stok_yeni()
                stokno = stokno_bul(stok, ">", "DESC")
            End If
        Else
            Try
                dataload_stok(stokno)
            Catch ex As Exception
            End Try
            'dataload_stok(stokno)
        End If
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        recete_yeni()
    End Sub
    Private Sub recete_yeni()
        Dim frm As New frm_uretim_recete
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.Uretim = True
        frm.ShowDialog()
        dataload_stok(stokno)
    End Sub
    Private Sub uretim_yeni()
        Dim frm As New frm_uretim_emir
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.ShowDialog()
        dataload_stok(stokno)
    End Sub
    Private Sub uretim_liste()
        Dim frm As New frm_uretim_emir_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.ShowDialog()
        dataload_stok(stokno)
    End Sub
    Private Sub recete_duzelt()
        Dim frm As New frm_uretim_recete
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.ShowDialog()
    End Sub
    Private Sub plan_yeni()
        Dim frm As New frm_uretim_plan
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.ShowDialog()
    End Sub
    Private Sub satinalma_yeni()
        Dim frm As New frm_uretim_satinalma
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.ShowDialog()
    End Sub
    Private Sub plan_liste()
        Dim frm As New frm_uretim_plan_liste
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.firma = firma
        frm.donem = donem
        frm.username = username
        frm.userno = userno
        frm.depono = depono
        frm.ShowDialog()
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub satinalma_liste()
        Dim frm As New frm_uretim_satinalma_liste
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.firma = firma
        frm.donem = donem
        frm.username = username
        frm.userno = userno
        frm.depono = depono
        frm.ShowDialog()
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub uretim_yerleri()
        Dim frm As New frm_uretim_yerleri
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.ShowDialog()
    End Sub
    Private Sub maliyet_unsurlari()
        Dim frm As New frm_uretim_maliyet_unsurlari
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.ShowDialog()
    End Sub
    Private Sub uretim_pozisyonlari()
        Dim frm As New frm_uretim_pozisyonlari
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.ShowDialog()
    End Sub
    Private Sub uretim_araclari()
        Dim frm As New frm_uretim_araclari
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.ShowDialog()
    End Sub
    Private Sub uretim_birimleri()
        Dim frm As New frm_uretim_birimleri
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.ShowDialog()
    End Sub
    Private Sub uretim_vardiyalari()
        Dim frm As New ým
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.ShowDialog()
    End Sub
    Private Sub rpt_ihtiyac()
        Dim frm As New frm_uretim_ihtiyac_liste
        frm.status = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.userno = userno
        frm.ShowDialog()
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub rpt_hammadde()
        Dim frm As New frm_uretim_hammadde_liste
        frm.status = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.userno = userno
        frm.ShowDialog()
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub ara(ByVal status As Boolean)
        Dim frm As New frm_uretim_recete_liste
        'frm.status = status
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.firma = firma
        frm.donem = donem
        frm.username = username
        frm.userno = userno
        frm.depono = depono
        If frm.ShowDialog(Me) = DialogResult.OK Then
            Dim dr1 As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            stokno = dr1("IND")
            dr1 = Nothing
            dataload_stok(stokno)
        End If
        frm.DataSet1.Clear()
        frm.DataSet1.Dispose()
        frm.DataSet1 = Nothing
        frm.SimpleButton1 = Nothing
        frm.SimpleButton2 = Nothing
        frm.SimpleButton3 = Nothing
        frm.GridControl1.Dispose()
        frm.GridControl1 = Nothing
        frm.GridView1.Dispose()
        frm.GridView1 = Nothing
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\URETIM\YONETIM\" & Me.Name.ToString & "")
        GridView2.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\URETIM\YONETIM\" & Me.Name.ToString & "")
        'GridView3.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\YONETIM\" & Me.Name.ToString & "")
        VGridControl1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\URETIM\YONETIM\BASLIK\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\URETIM\YONETIM\" & Me.Name.ToString & "")
        GridView2.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\URETIM\YONETIM\" & Me.Name.ToString & "")
        'GridView3.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\YONETIM\" & Me.Name.ToString & "")
        VGridControl1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\URETIM\YONETIM\BASLIK\" & Me.Name.ToString & "")
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
    End Sub
    Public Sub dataload_stok(ByVal stokno As Integer)
        con.ConnectionString = connection
        cmd.Connection = con
        If stokno = 99 Then
            stokno = stokno_bul(stokno, ">", "ASC")
        End If
        If stokno > 0 Then
            ds_baslik.Clear()
            ds_baslik.Dispose()
            DataSet2.Clear()
            DataSet2.Dispose()
            ds_baslik = sorgu(sorgu_query("SELECT R.IND, R.STOKNO, R.KULLANICI, R.SONERISIMTARIHI, R.TUTAR, R.STOKKODU, R.MALINCINSI, R.BIRIM, R.FIYAT, R.KDV, R.OZELKOD, R.ACIKLAMA, R.STOKTIPI, R.SATISFIYATI FROM TBLURERECETELIST R LEFT OUTER JOIN tbStok S ON S.nStokID = R.STOKNO WHERE R.IND =" & stokno & ""))
            DataSet2 = sorgu(sorgu_query("SELECT CASE WHEN T .ENTEGRE = 0 THEN '[BAÞLAMAMIÞ]' ELSE '[TAMAMLANMIÞ]' END AS KOD, T .IND, T .DETAY, T .TARIH, T .FISNO, T .STOKKODU, T .MALINCINSI, T .MIKTAR, T .TERMIN, T .URETIMEBASLAMATARIHI, T .URETIMBITISTARIHI, P.URETIMYERIKODU, T .OZELKOD FROM TBLUREURETIMLIST AS T, TBLUREURETIMPOZ AS P WHERE T.IND = (T.IND * P.EVRAKNO) AND T.POZNO = (P.SIRANO * T.POZNO) AND T.RECETENO = " & stokno & " ORDER BY TARIH"))
            Try
                'DataSet3 = sorgu(sorgu_query("SELECT NEWID() AS TEKIL, BAS.IND AS BELGEIND, BAS.BELGENO, BAS.TARIH, HAR.STOKKODU, HAR.MALINCINSI, HAR.STOKTIPI, HAR.ENVANTER, DEPOGIRIS.DEPOKODU AS GIRDIGIDEPO, DEPOCIKIS.DEPOKODU AS CIKTIGIDEPO, BAS.DEPO AS CIKISDEPONO, HAR.DEPO AS GIRISDEPONO, HAR.ACIKLAMA, HAR.STOKNO, HAR.IND AS IND, BAS.BELGETIPI FROM TBLDEPOHARBASLIK BAS INNER JOIN TBLDEPOHARHAREKET HAR ON HAR.EVRAKNO = BAS.IND INNER JOIN TBLDEPOLAR DEPOCIKIS ON DEPOCIKIS.IND = BAS.DEPO INNER JOIN TBLDEPOLAR DEPOGIRIS ON DEPOGIRIS.IND = HAR.DEPO WHERE HAR.STOKNO =" & stokno & " ORDER BY BAS.TARIH"))
                'GridControl2.DataSource = DataSet3.Tables(0)
                'GridControl2.DataMember = Nothing
            Catch ex As Exception
            End Try
            VGridControl1.DataSource = ds_baslik.Tables(0)
            VGridControl1.DataMember = Nothing
            GridControl1.DataSource = DataSet2.Tables(0)
            GridControl1.DataMember = Nothing
            VGridControl1.Refresh()
            GridControl1.Focus()
            GridControl1.Select()
            'Dim dr As DataRow
            'Dim kalan = 0
            'For Each dr In DataSet2.Tables(0).Rows
            '    kalan = kalan + (dr("GIREN") - dr("CIKAN"))
            '    dr("KALAN") = kalan
            'Next
            'colKALAN.SummaryItem.DisplayFormat = "" & FormatNumber((kalan), 4).ToString
            GridView1.UpdateSummary()
            GridView1.UpdateTotalSummary()
            Try
                dr = ds_baslik.Tables(0).Rows(0)
                Label2.Text = "[Üretim Yönetimi] Stokkodu : " & dr("STOKKODU") & vbTab & vbTab & "  Stok Adý : " & dr("MALINCINSI")
            Catch ex As Exception
            End Try
            'dr = Nothing
            'kalan = Nothing
        Else
        End If
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
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
        DS = Nothing
        N = Nothing
    End Function
    Private Sub sonraki_stok()
        stokno = stokno_bul(stokno, ">", "ASC")
        dataload_stok(stokno)
    End Sub
    Private Sub onceki_stok()
        stokno = stokno_bul(stokno, "<", "DESC")
        dataload_stok(stokno)
    End Sub
    Private Sub ilk_stok()
        stokno = stokno_bul(99, ">", "ASC")
        dataload_stok(stokno)
    End Sub
    Private Sub son_stok()
        stokno = stokno_bul(99, ">", "DESC")
        dataload_stok(stokno)
    End Sub
    Private Function stokno_bul(ByVal stokno As Integer, ByVal kriter As String, ByVal kriter2 As String) As Integer
        con.Open()
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(IND,0) AS IND FROM TBLSTOKLAR WHERE  IND " & kriter & " " & stokno & " AND IND > 99 ORDER BY IND " & kriter2 & "")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(RECETE.IND,0) AS IND FROM TBLURERECETELIST RECETE LEFT OUTER JOIN tbStok STOKLAR ON STOKLAR.nStokID = RECETE.STOKNO WHERE  RECETE.IND " & kriter & " " & stokno & " AND RECETE.IND > 0 ORDER BY RECETE.IND " & kriter2 & "")
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
        kayitno = Nothing
    End Function
    Private Sub duzelt_baslik()
        Try
            If stokno > 0 Then
                Dim frm As New frm_uretim_recete
                frm.connection = connection
                frm.firmano = firmano
                frm.donemno = donemno
                frm.firma = firma
                frm.donem = donem
                frm.username = username
                frm.userno = userno
                frm.depono = depono
                frm.belgeind = stokno
                frm.ShowDialog()
                frm.Dispose()
                frm.Close()
                frm = Nothing
                dataload_stok(stokno)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub duzelt_hareket()
        Try
            If GridView2.RowCount > 0 Then
                Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
                Dim frm As New frm_uretim_emir
                frm.connection = connection
                frm.firmano = firmano
                frm.donemno = donemno
                frm.firma = firma
                frm.donem = donem
                frm.username = username
                frm.userno = userno
                frm.depono = depono
                frm.belgeind = dr("IND")
                frm.ShowDialog()
                frm.Dispose()
                frm.Close()
                frm = Nothing
                Dim satir = GridView2.FocusedRowHandle
                dataload_stok(stokno)
                GridView1.FocusedRowHandle = satir
                satir = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        ara(True)
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        onceki_stok()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        sonraki_stok()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        plan_yeni()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        uretim_yerleri()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        maliyet_unsurlari()
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        uretim_pozisyonlari()
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        uretim_araclari()
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        uretim_birimleri()
    End Sub
    Private Sub BarButtonItem14_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        uretim_vardiyalari()
    End Sub
    Private Sub BarButtonItem15_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        rpt_ihtiyac()
    End Sub
    Private Sub BarButtonItem16_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        rpt_hammadde()
    End Sub
    Private Sub BarButtonItem17_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        duzelt_baslik()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Üretim Yönetimi Ekranýndan Çýkmak Ýstediðinize Eminmisiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.Right Then
            sonraki_stok()
        ElseIf e.KeyCode = Keys.Left Then
            onceki_stok()
        End If
    End Sub
    Private Sub GridView2_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView2.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView2.KeyDown
        If e.KeyCode = Keys.Enter Then
            duzelt_hareket()
        End If
    End Sub
    Private Sub GridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView2.DoubleClick
        duzelt_hareket()
    End Sub
    Private Sub BarButtonItem18_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        uretim_yeni()
    End Sub
    Private Sub frm_uretim_yonetimi_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
        Me.Hide()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        plan_liste()
    End Sub
    Private Sub BarButtonItem20_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        satinalma_liste()
    End Sub
    Private Sub BarButtonItem21_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        satinalma_yeni()
    End Sub
    Private Sub BarButtonItem19_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        uretim_liste()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
End Class
