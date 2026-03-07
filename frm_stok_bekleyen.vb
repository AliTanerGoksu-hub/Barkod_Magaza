Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_stok_bekleyen
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
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents DataSet1 As System.Data.DataSet
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
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGIREN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIKAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKALAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMEVCUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToplamAlinan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToplamVerilen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPESIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colONAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colALTIAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBarkod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBeden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAsgariMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAzamiMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsModel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBEKLEYEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
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
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents sec_renk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_bekleyen))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colGIREN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCIKAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKALAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMEVCUT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colToplamAlinan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colToplamVerilen = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPESIN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colONAY = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colALTIAY = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsBarkod = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSTOKKODU = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSTOKADI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sec_renk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collAsgariMiktar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collAzamiMiktar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsModel = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsDepo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBEKLEYEN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
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
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 52)
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(867, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Aþaðýda Stok Kartlarýnýn Listesini Görmektesiniz.Ýþlem Yapmak istediðiniz Stok Ka" & _
            "rtýný seçmek için [Tamam] butonuna týklayýnýz, yeniden Arama yapmak için ise [Ar" & _
            "a] butonuna týklayýnýz."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 363)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 43)
        Me.PanelControl2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(96, 13)
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
        Me.PanelControl3.Location = New System.Drawing.Point(0, 52)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 311)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 307)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(814, 279)
        Me.XtraTabPage1.Text = "Kartlar..."
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = Nothing
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_renk})
        Me.GridControl1.Size = New System.Drawing.Size(814, 279)
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "sAciklama"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "GIREN"
        Me.DataColumn2.DataType = GetType(Decimal)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "CIKAN"
        Me.DataColumn3.DataType = GetType(Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "KALAN"
        Me.DataColumn4.DataType = GetType(Decimal)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "MEVCUT"
        Me.DataColumn5.DataType = GetType(Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "ToplamAlinan"
        Me.DataColumn6.DataType = GetType(Decimal)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "ToplamVerilen"
        Me.DataColumn7.DataType = GetType(Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "PESIN"
        Me.DataColumn8.DataType = GetType(Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "ONAY"
        Me.DataColumn9.DataType = GetType(Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "ALTIAY"
        Me.DataColumn10.DataType = GetType(Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sBarkod"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "STOKKODU"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "STOKADI"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sRenk"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sBeden"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "lAsgariMiktar"
        Me.DataColumn16.DataType = GetType(Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "lAzamiMiktar"
        Me.DataColumn17.DataType = GetType(Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "sModel"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "sDepo"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "BEKLEYEN"
        Me.DataColumn20.DataType = GetType(Decimal)
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsAciklama, Me.colGIREN, Me.colCIKAN, Me.colKALAN, Me.colMEVCUT, Me.colToplamAlinan, Me.colToplamVerilen, Me.colPESIN, Me.colONAY, Me.colALTIAY, Me.colsBarkod, Me.colSTOKKODU, Me.colSTOKADI, Me.colsRenk, Me.colsBeden, Me.collAsgariMiktar, Me.collAzamiMiktar, Me.colsModel, Me.colsDepo, Me.colBEKLEYEN})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(517, 266, 208, 156)
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GIREN", Me.colGIREN, "{0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CIKAN", Me.colCIKAN, "{0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KALAN", Me.colKALAN, "{0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ToplamVerilen", Me.colToplamVerilen, "{0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BEKLEYEN", Me.colBEKLEYEN, "{0:#,0.##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, "MEVCUT", Nothing, "(Mevcut : {0:#,0.##})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BEKLEYEN", Nothing, "(Bekleyen : {0:#,0.##})"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Max, "ToplamVerilen", Nothing, "(Sipariþ : {0:#,0.##})")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsNavigation.UseTabKey = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Depo"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 4
        Me.colsAciklama.Width = 101
        '
        'colGIREN
        '
        Me.colGIREN.Caption = "Giren"
        Me.colGIREN.DisplayFormat.FormatString = "#,0.##"
        Me.colGIREN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGIREN.FieldName = "GIREN"
        Me.colGIREN.Name = "colGIREN"
        Me.colGIREN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "GIREN", "{0:#,0.####}")})
        '
        'colCIKAN
        '
        Me.colCIKAN.Caption = "Çýkan"
        Me.colCIKAN.DisplayFormat.FormatString = "#,0.##"
        Me.colCIKAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCIKAN.FieldName = "CIKAN"
        Me.colCIKAN.Name = "colCIKAN"
        Me.colCIKAN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CIKAN", "{0:#,0.####}")})
        '
        'colKALAN
        '
        Me.colKALAN.Caption = "Depo Mevcudu"
        Me.colKALAN.DisplayFormat.FormatString = "#,0.##"
        Me.colKALAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKALAN.FieldName = "KALAN"
        Me.colKALAN.Name = "colKALAN"
        Me.colKALAN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KALAN", "{0:#,0.####}")})
        Me.colKALAN.Visible = True
        Me.colKALAN.VisibleIndex = 5
        Me.colKALAN.Width = 104
        '
        'colMEVCUT
        '
        Me.colMEVCUT.Caption = "Mevcut"
        Me.colMEVCUT.DisplayFormat.FormatString = "#,0.##"
        Me.colMEVCUT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMEVCUT.FieldName = "MEVCUT"
        Me.colMEVCUT.Name = "colMEVCUT"
        Me.colMEVCUT.Width = 64
        '
        'colToplamAlinan
        '
        Me.colToplamAlinan.Caption = "AlýnanSipariþ"
        Me.colToplamAlinan.DisplayFormat.FormatString = "#,0.##"
        Me.colToplamAlinan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colToplamAlinan.FieldName = "ToplamAlinan"
        Me.colToplamAlinan.Name = "colToplamAlinan"
        Me.colToplamAlinan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ToplamAlinan", "{0:#,0.####}")})
        '
        'colToplamVerilen
        '
        Me.colToplamVerilen.Caption = "VerilenSipariþ"
        Me.colToplamVerilen.DisplayFormat.FormatString = "#,0.##"
        Me.colToplamVerilen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colToplamVerilen.FieldName = "ToplamVerilen"
        Me.colToplamVerilen.Name = "colToplamVerilen"
        Me.colToplamVerilen.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ToplamVerilen", "{0:#,0.####}")})
        Me.colToplamVerilen.Visible = True
        Me.colToplamVerilen.VisibleIndex = 7
        Me.colToplamVerilen.Width = 103
        '
        'colPESIN
        '
        Me.colPESIN.Caption = "Fiyat1"
        Me.colPESIN.DisplayFormat.FormatString = "#,0.##"
        Me.colPESIN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPESIN.FieldName = "PESIN"
        Me.colPESIN.Name = "colPESIN"
        Me.colPESIN.Width = 80
        '
        'colONAY
        '
        Me.colONAY.Caption = "10Taksitli"
        Me.colONAY.DisplayFormat.FormatString = "#,0.##"
        Me.colONAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colONAY.FieldName = "ONAY"
        Me.colONAY.Name = "colONAY"
        Me.colONAY.Width = 72
        '
        'colALTIAY
        '
        Me.colALTIAY.Caption = "6Taksit"
        Me.colALTIAY.DisplayFormat.FormatString = "#,0.##"
        Me.colALTIAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colALTIAY.FieldName = "ALTIAY"
        Me.colALTIAY.Name = "colALTIAY"
        Me.colALTIAY.Width = 72
        '
        'colsBarkod
        '
        Me.colsBarkod.Caption = "Barkod"
        Me.colsBarkod.FieldName = "sBarkod"
        Me.colsBarkod.Name = "colsBarkod"
        Me.colsBarkod.Visible = True
        Me.colsBarkod.VisibleIndex = 1
        Me.colsBarkod.Width = 109
        '
        'colSTOKKODU
        '
        Me.colSTOKKODU.Caption = "Stok Kodu"
        Me.colSTOKKODU.FieldName = "STOKKODU"
        Me.colSTOKKODU.Name = "colSTOKKODU"
        Me.colSTOKKODU.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "STOKKODU", "{0} Kayýt")})
        Me.colSTOKKODU.Visible = True
        Me.colSTOKKODU.VisibleIndex = 0
        Me.colSTOKKODU.Width = 105
        '
        'colSTOKADI
        '
        Me.colSTOKADI.Caption = "Stok Adý"
        Me.colSTOKADI.FieldName = "STOKADI"
        Me.colSTOKADI.Name = "colSTOKADI"
        Me.colSTOKADI.Visible = True
        Me.colSTOKADI.VisibleIndex = 2
        Me.colSTOKADI.Width = 168
        '
        'colsRenk
        '
        Me.colsRenk.Caption = "Renk"
        Me.colsRenk.ColumnEdit = Me.sec_renk
        Me.colsRenk.FieldName = "sRenk"
        Me.colsRenk.Name = "colsRenk"
        Me.colsRenk.Visible = True
        Me.colsRenk.VisibleIndex = 3
        Me.colsRenk.Width = 64
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
        'colsBeden
        '
        Me.colsBeden.Caption = "Beden"
        Me.colsBeden.FieldName = "sBeden"
        Me.colsBeden.Name = "colsBeden"
        '
        'collAsgariMiktar
        '
        Me.collAsgariMiktar.Caption = "Asgari Miktar"
        Me.collAsgariMiktar.DisplayFormat.FormatString = "#,0.##"
        Me.collAsgariMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collAsgariMiktar.FieldName = "lAsgariMiktar"
        Me.collAsgariMiktar.Name = "collAsgariMiktar"
        '
        'collAzamiMiktar
        '
        Me.collAzamiMiktar.Caption = "Azami Miktar"
        Me.collAzamiMiktar.DisplayFormat.FormatString = "#,0.##"
        Me.collAzamiMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collAzamiMiktar.FieldName = "lAzamiMiktar"
        Me.collAzamiMiktar.Name = "collAzamiMiktar"
        '
        'colsModel
        '
        Me.colsModel.Caption = "Model"
        Me.colsModel.FieldName = "sModel"
        Me.colsModel.Name = "colsModel"
        '
        'colsDepo
        '
        Me.colsDepo.Caption = "DepoNo"
        Me.colsDepo.FieldName = "sDepo"
        Me.colsDepo.Name = "colsDepo"
        Me.colsDepo.Width = 61
        '
        'colBEKLEYEN
        '
        Me.colBEKLEYEN.Caption = "Bekleyen"
        Me.colBEKLEYEN.DisplayFormat.FormatString = "#,0.##"
        Me.colBEKLEYEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBEKLEYEN.FieldName = "BEKLEYEN"
        Me.colBEKLEYEN.Name = "colBEKLEYEN"
        Me.colBEKLEYEN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BEKLEYEN", "{0:#,0.####}")})
        Me.colBEKLEYEN.Visible = True
        Me.colBEKLEYEN.VisibleIndex = 6
        Me.colBEKLEYEN.Width = 95
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem15, Me.MenuItem16, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem12, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem13, Me.MenuItem7, Me.MenuItem8, Me.MenuItem9, Me.MenuItem19, Me.MenuItem14, Me.MenuItem10, Me.MenuItem11, Me.MenuItem18, Me.MenuItem17})
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 0
        Me.MenuItem15.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem15.Text = "Ara"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 1
        Me.MenuItem16.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 2
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem1.Text = "Ekle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 3
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem2.Text = "Düzenle"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 4
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem3.Text = "Sil"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 5
        Me.MenuItem12.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 6
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItem4.Text = "Fiyat Düzenle"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 7
        Me.MenuItem5.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem5.Text = "Envanter"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 8
        Me.MenuItem6.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem6.Text = "Hareket Analizi"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 9
        Me.MenuItem13.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 10
        Me.MenuItem7.Text = "Görünümü Düzenle"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 11
        Me.MenuItem8.Text = "Görünümü Kaydet"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 12
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem9.Text = "Görünümü Yazdýr"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 13
        Me.MenuItem19.Text = "Yazdýr"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 14
        Me.MenuItem14.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 15
        Me.MenuItem10.Text = "Filtrele"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 16
        Me.MenuItem11.Text = "Gruplandýr"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 17
        Me.MenuItem18.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 18
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"", "Stok Mevcut Yönetimi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"[User Name]", "Stok Ýþlemleri", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10})
        Me.BarManager1.MaxItemId = 10
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Ekle,Insert"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Düzelt,F4"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Sil,Ctrl+Del"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Fiyatlandir,Ctrl+F"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Envanter,F6"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Stok Hareketleri ,F7"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Excel"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Text"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Mail"
        Me.BarButtonItem10.Id = 9
        Me.BarButtonItem10.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem10.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem10.Name = "BarButtonItem10"
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
        'frm_stok_bekleyen
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
        Me.Name = "frm_stok_bekleyen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Kart Listesi"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
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
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Dim dr As DataRow
    Dim count
    Public mevcut
    Public yeni
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Private Sub frm_stok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Hide()
        If status = False Then
            count = ""
            Dim frm As New frm_stok_ara
            frm.connection = connection
            frm.firmano = firmano
            frm.donemno = donemno
            frm.kullanici = kullanici
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
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
                Me.Show()
                frm.stokkodu = Nothing
                frm.malincinsi = Nothing
                frm.barkod = Nothing
                frm.muadilbarkod = Nothing
                frm.birim = Nothing
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
                frm.Dispose()
                frm = Nothing
                dataload()
            Else
                frm.stokkodu = Nothing
                frm.malincinsi = Nothing
                frm.barkod = Nothing
                frm.muadilbarkod = Nothing
                frm.birim = Nothing
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
                frm.Dispose()
                frm = Nothing
                Me.Close()
            End If
        Else
            count = "TOP 1000"
            dataload()
        End If
        'stok_islemleri.firmano = firmano
        'stok_islemleri.donemno = donemno
        'stok_islemleri.connection = connection
        If GridView1.RowCount = 0 Then
        ElseIf GridView1.RowCount = 1 Then
            'If sil = False Then
            '    sorgu()
            'End If
        Else
        End If
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
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "")
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
        Dim frm As New frm_stok_ara
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
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
            mevcut = frm.mevcut
            yeni = frm.yeni
            dataload()
        End If
        frm.stokkodu = Nothing
        frm.malincinsi = Nothing
        frm.barkod = Nothing
        frm.muadilbarkod = Nothing
        frm.birim = Nothing
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
        frm.Dispose()
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
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        dataload_depo()
        'DataSet1.Clear()
        'DataSet1.Dispose()
        DataSet1 = stok()
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        Label2.Text = Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...", sDil)
        Label2.Refresh()
        'GridView1.SelectRow(0)
    End Sub
    Private Sub stok_yeni()
        'stok_islemleri.kart_yeni()
    End Sub
    Private Sub stok_duzelt()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            'stok_islemleri.kart_duzelt(dr("IND"), dr("STOKKODU"), dr("MALINCINSI"))
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
        kriter = "WHERE (stok.skodu is not null ) "
        If stokkodu <> "" Then
            kriter += " AND (stok.skodu " & sorgu_kriter_string(stokkodu, qstokkodu) & ")"
        End If
        If malincinsi <> "" Then
            kriter += " AND (stok.saciklama " & sorgu_kriter_string(malincinsi, qmalincinsi) & ")"
        End If
        If barkod <> "" Then
            kriter += " AND (barkod.sbarkod " & sorgu_kriter_string(barkod, qbarkod) & ")"
        End If
        'If birim <> "" Then
        '    kriter += " AND (TBLBIRIMLEREX.BIRIMADI " & sorgu_kriter_string(birim, qbirim) & ")"
        'End If
        If kod1 <> "" Then
            kriter += " AND (stok.srenk " & sorgu_kriter_string(kod1, qkod1) & " )"
        End If
        If kod2 <> "" Then
            kriter += " AND (stok.sbeden " & sorgu_kriter_string(kod2, qkod2) & ")"
        End If
        If kod3 <> "" Then
            kriter += " AND Stok.nStokID IN ( SELECT     tbStok.nStokID FROM         tbStok INNER JOIN  tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif1.sAciklama " & sorgu_kriter_string(kod3, qkod3) & " )"
        End If
        'If kod3 <> "" Then
        '    kriter += " AND (STK.KOD3 " & sorgu_kriter_string(kod3, qkod3) & ")"
        'End If
        'If kod4 <> "" Then
        '    kriter += " AND (STK.KOD4 " & sorgu_kriter_string(kod4, qkod4) & ")"
        'End If
        'If kod5 <> "" Then
        '    kriter += " AND (STK.KOD5 " & sorgu_kriter_string(kod5, qkod5) & ")"
        'End If
        'If kod6 <> "" Then
        '    kriter += " AND (STK.KOD6 " & sorgu_kriter_string(kod6, qkod6) & ")"
        'End If
        'If kod7 <> "" Then
        '    kriter += " AND (STK.KOD7 " & sorgu_kriter_string(kod7, qkod7) & ")"
        'End If
        'If kod8 <> "" Then
        '    kriter += " AND (STK.KOD8 " & sorgu_kriter_string(kod8, qkod8) & ")"
        'End If
        'If kod9 <> "" Then
        '    kriter += " AND (STK.KOD9 " & sorgu_kriter_string(kod9, qkod9) & ")"
        'End If
        'If kod10 <> "" Then
        '    kriter += " AND (STK.KOD10 " & sorgu_kriter_string(kod10, qkod10) & ")"
        'End If
        'If istihbarat <> "" Then
        '    kriter += " AND (STK.ISTIHBARAT " & sorgu_kriter_string(istihbarat, qistihbarat) & ")"
        'End If
        'If satisfiyati1 <> "" Then
        '    kriter += " AND (TBLBIRIMLEREX.SATISFIYATI1 " & sorgu_kriter_string(satisfiyati1, qsatisfiyati1) & ")"
        'End If
        'If satisfiyati2 <> "" Then
        '    kriter += " AND (TBLBIRIMLEREX.SATISFIYATI2 " & sorgu_kriter_string(satisfiyati2, qsatisfiyati2) & ")"
        'End If
        'If satisfiyati3 <> "" Then
        '    kriter += " AND (TBLBIRIMLEREX.SATISFIYATI3 " & sorgu_kriter_string(satisfiyati3, qsatisfiyati3) & ")"
        'End If
        If kayitno <> "" Then
            kriter += " AND (stok.nStokID " & sorgu_kriter_string(kayitno, qkayitno) & ")"
        End If
        'If aktif <> "" Then
        '    kriter += " AND (STK.STATUS " & sorgu_kriter_string(aktif, qaktif) & ")"
        'End If
        'If sil = True Then
        '    kriter += " AND STK.IND NOT IN (SELECT STOKNO FROM *!F!DTBLSTOKHAREKETLERI) "
        'End If
        If gelismis <> "" Then
            kriter += " AND (stok.skodu " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (stok.saciklama " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (barkod.sbarkod " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (stok.srenk " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (stok.sbeden " & sorgu_kriter_string(gelismis, qgelismis) & ") "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " stok.nStokID,stok.sKodu, stok.sAciklama, stok.sRenk, stok.sBeden, stok.sModel, barkod.sBarkod, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID " & kriter & " ORDER BY stok.sKodu")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT depo.sAciklama, ISNULL(SUM(hareket.lGirisMiktar1), 0) AS GIREN, ISNULL(SUM(hareket.lCikisMiktar1), 0) AS CIKAN, ISNULL(SUM(hareket.lGirisMiktar1 - hareket.lCikisMiktar1), 0) AS KALAN, (SELECT isnull(SUM(lgirismiktar1 - lcikismiktar1) , 0) AS MEVCUT FROM tbStokFisiDetayi WHERE nSTOKID = stok.nStokID) AS MEVCUT, (SELECT isnull(SUM(tbSiparis.lMiktari) , 0) FROM tbSiparis WHERE tbSiparis.nSiparisTipi = 1 AND tbSiparis.bKapandimi = 0 AND tbSiparis.nStokID = Stok.nStokID) AS ToplamAlinan, (SELECT isnull(SUM(tbSiparis.lMiktari) , 0) FROM tbSiparis WHERE tbSiparis.nSiparisTipi = 2 AND tbSiparis.bKapandimi = 0 AND tbSiparis.nStokID = Stok.nStokID) AS ToplamVerilen, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, barkod.sBarkod, stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, depo.sDepo, (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS SatisMiktar FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND tbAlisverisSiparis.nStokID = stok.nStokID AND tbAlisverisSiparis.sMagazaKodu = depo.sDepo HAVING (SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) > 0)) AS BEKLEYEN FROM tbStokBarkodu barkod INNER JOIN tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo ON barkod.nStokID = stok.nStokID and barkod.nKisim = 0 " & kriter & " GROUP BY depo.sAciklama, stok.nStokID, barkod.sBarkod, stok.sKodu, stok.sAciklama, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, depo.sDepo")
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
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_stok_envanter
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.stokno = dr("nStokId")
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
        'stkdll.firmano = firmano
        'stkdll.donemno = donemno
        'stkdll.connection = connection
        'stkdll.stokno = dr("IND")
        'stkdll.birimno = dr("IND")
        'stkdll.rptenvanteranalizi(dr("IND"), dr("MALINCINSI"))
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
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.xls"
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
            SaveFileDialog1.FileName = "Rapor.txt"
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
            SaveFileDialog1.FileName = "Rapor.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        'If GridView1.SelectedRowsCount > 1 Then
        '    Dim sayi = GridView1.FocusedRowHandle + 1
        '    Dim sayi1 = GridView1.SelectedRowsCount
        '    GridView1.FocusedColumn = colSTOKKODU
        '    Me.colSTOKKODU.SummaryItem.DisplayFormat = "Kayýt:{0}/Satýr:" & sayi & "/Seçili:" & sayi1 & ""
        'ElseIf GridView1.SelectedRowsCount = 1 Then
        '    Dim sayi = GridView1.FocusedRowHandle + 1
        '    Me.colSTOKKODU.SummaryItem.DisplayFormat = "Kayýt:{0}"
        'End If
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
        sorgu()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            sorgu()
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
        ps.PreviewFormEx.ShowDialog()
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
        analiz_hareket()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        stok_fiyat()
    End Sub
    Private Sub frm_stok_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
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
        System.GC.Collect()
        System.GC.GetTotalMemory(True)
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
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        stok_yeni()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        stok_duzelt()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        stok_sil()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        stok_fiyat()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_hareket()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        raporla_pdf()
    End Sub
End Class
