Imports DevExpress.XtraEditors
Public Class frm_uretim_yerleri
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
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCARINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUNVAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADRESSEVK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEFON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFAX As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVERGIDAIRESI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVERGINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPONO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPOKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents ps1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents DataSet4 As System.Data.DataSet
    Friend WithEvents btn_kaydet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_fax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_telefon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_vergino As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_vergidairesi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_adres As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_unvan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_ad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_kod As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_depo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_uretim_yerleri))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
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
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCARINO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUNVAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colADRESSEVK = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTELEFON = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFAX = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVERGIDAIRESI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colVERGINO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDEPONO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDEPOKODU = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.sec_depo = New DevExpress.XtraEditors.LookUpEdit
        Me.btn_kaydet = New DevExpress.XtraEditors.SimpleButton
        Me.Label10 = New DevExpress.XtraEditors.LabelControl
        Me.Label9 = New DevExpress.XtraEditors.LabelControl
        Me.Label8 = New DevExpress.XtraEditors.LabelControl
        Me.txt_fax = New DevExpress.XtraEditors.TextEdit
        Me.txt_telefon = New DevExpress.XtraEditors.TextEdit
        Me.txt_vergino = New DevExpress.XtraEditors.TextEdit
        Me.txt_vergidairesi = New DevExpress.XtraEditors.TextEdit
        Me.txt_adres = New DevExpress.XtraEditors.MemoEdit
        Me.Label7 = New DevExpress.XtraEditors.LabelControl
        Me.Label6 = New DevExpress.XtraEditors.LabelControl
        Me.Label5 = New DevExpress.XtraEditors.LabelControl
        Me.Label4 = New DevExpress.XtraEditors.LabelControl
        Me.Label3 = New DevExpress.XtraEditors.LabelControl
        Me.txt_unvan = New DevExpress.XtraEditors.TextEdit
        Me.txt_ad = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.txt_kod = New DevExpress.XtraEditors.TextEdit
        Me.ps1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.DataSet4 = New System.Data.DataSet
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
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_telefon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_vergino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_vergidairesi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_adres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_unvan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(756, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(758, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 389)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 40)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(742, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(662, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 48)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 341)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 337)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(814, 311)
        Me.XtraTabPage1.Text = "Üretim Yerleri"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(814, 311)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem16, Me.MenuItem17, Me.MenuItem18, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem12, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem13, Me.MenuItem7, Me.MenuItem8, Me.MenuItem14, Me.MenuItem9, Me.MenuItem10, Me.MenuItem15, Me.MenuItem11})
        '
        'MenuItem16
        '
        Me.MenuItem16.DefaultItem = True
        Me.MenuItem16.Index = 0
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem16.Text = "Tamam"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 1
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem17.Text = "Vazgeç"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 2
        Me.MenuItem18.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 3
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem1.Text = "Ekle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 4
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem2.Text = "Düzelt"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 5
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem3.Text = "Sil"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 6
        Me.MenuItem12.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 7
        Me.MenuItem4.Text = "Görünümü Düzenle"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 8
        Me.MenuItem5.Text = "Görünümü Kaydet"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 9
        Me.MenuItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem6.Text = "Görünümü Yazdýr"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 10
        Me.MenuItem13.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 11
        Me.MenuItem7.Text = "Filtrele"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 12
        Me.MenuItem8.Text = "Gruplandýr"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 13
        Me.MenuItem14.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 14
        Me.MenuItem9.Text = "Satýrlarý Aç"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 15
        Me.MenuItem10.Text = "Satýrlarý Kapat"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 16
        Me.MenuItem15.Text = "-"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 17
        Me.MenuItem11.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem11.Text = "Ekraný Kapla"
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
        Me.DataColumn1.ColumnName = "IND"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "KOD"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "AD"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "CARINO"
        Me.DataColumn4.DataType = GetType(Long)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "UNVAN"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "ADRESSEVK"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "TELEFON"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "FAX"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "VERGIDAIRESI"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "VERGINO"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "DEPONO"
        Me.DataColumn11.DataType = GetType(Long)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "DEPOKODU"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.colKOD, Me.colAD, Me.colCARINO, Me.colUNVAN, Me.colADRESSEVK, Me.colTELEFON, Me.colFAX, Me.colVERGIDAIRESI, Me.colVERGINO, Me.colDEPONO, Me.colDEPOKODU})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(647, 291, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colIND
        '
        Me.colIND.Caption = "Kayýt No"
        Me.colIND.FieldName = "IND"
        Me.colIND.Name = "colIND"
        Me.colIND.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "IND", "{0} Kayýt")})
        Me.colIND.Visible = True
        Me.colIND.VisibleIndex = 0
        '
        'colKOD
        '
        Me.colKOD.Caption = "ÜretimYeriKodu"
        Me.colKOD.FieldName = "KOD"
        Me.colKOD.Name = "colKOD"
        Me.colKOD.Visible = True
        Me.colKOD.VisibleIndex = 1
        '
        'colAD
        '
        Me.colAD.Caption = "ÜretimYeriAdý"
        Me.colAD.FieldName = "AD"
        Me.colAD.Name = "colAD"
        Me.colAD.Visible = True
        Me.colAD.VisibleIndex = 2
        '
        'colCARINO
        '
        Me.colCARINO.Caption = "CariHesapNo"
        Me.colCARINO.FieldName = "CARINO"
        Me.colCARINO.Name = "colCARINO"
        '
        'colUNVAN
        '
        Me.colUNVAN.Caption = "Ünvan"
        Me.colUNVAN.FieldName = "UNVAN"
        Me.colUNVAN.Name = "colUNVAN"
        '
        'colADRESSEVK
        '
        Me.colADRESSEVK.Caption = "SevkAdresi"
        Me.colADRESSEVK.FieldName = "ADRESSEVK"
        Me.colADRESSEVK.Name = "colADRESSEVK"
        Me.colADRESSEVK.Visible = True
        Me.colADRESSEVK.VisibleIndex = 3
        '
        'colTELEFON
        '
        Me.colTELEFON.Caption = "Telefon"
        Me.colTELEFON.FieldName = "TELEFON"
        Me.colTELEFON.Name = "colTELEFON"
        Me.colTELEFON.Visible = True
        Me.colTELEFON.VisibleIndex = 4
        '
        'colFAX
        '
        Me.colFAX.Caption = "Fax"
        Me.colFAX.FieldName = "FAX"
        Me.colFAX.Name = "colFAX"
        Me.colFAX.Visible = True
        Me.colFAX.VisibleIndex = 5
        '
        'colVERGIDAIRESI
        '
        Me.colVERGIDAIRESI.Caption = "Vergi Dairesi"
        Me.colVERGIDAIRESI.FieldName = "VERGIDAIRESI"
        Me.colVERGIDAIRESI.Name = "colVERGIDAIRESI"
        '
        'colVERGINO
        '
        Me.colVERGINO.Caption = "Vergi No"
        Me.colVERGINO.FieldName = "VERGINO"
        Me.colVERGINO.Name = "colVERGINO"
        '
        'colDEPONO
        '
        Me.colDEPONO.Caption = "DepoNo"
        Me.colDEPONO.FieldName = "DEPONO"
        Me.colDEPONO.Name = "colDEPONO"
        '
        'colDEPOKODU
        '
        Me.colDEPOKODU.Caption = "DepoKodu"
        Me.colDEPOKODU.FieldName = "DEPOKODU"
        Me.colDEPOKODU.Name = "colDEPOKODU"
        Me.colDEPOKODU.Visible = True
        Me.colDEPOKODU.VisibleIndex = 6
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.SimpleButton3)
        Me.XtraTabPage2.Controls.Add(Me.sec_depo)
        Me.XtraTabPage2.Controls.Add(Me.btn_kaydet)
        Me.XtraTabPage2.Controls.Add(Me.Label10)
        Me.XtraTabPage2.Controls.Add(Me.Label9)
        Me.XtraTabPage2.Controls.Add(Me.Label8)
        Me.XtraTabPage2.Controls.Add(Me.txt_fax)
        Me.XtraTabPage2.Controls.Add(Me.txt_telefon)
        Me.XtraTabPage2.Controls.Add(Me.txt_vergino)
        Me.XtraTabPage2.Controls.Add(Me.txt_vergidairesi)
        Me.XtraTabPage2.Controls.Add(Me.txt_adres)
        Me.XtraTabPage2.Controls.Add(Me.Label7)
        Me.XtraTabPage2.Controls.Add(Me.Label6)
        Me.XtraTabPage2.Controls.Add(Me.Label5)
        Me.XtraTabPage2.Controls.Add(Me.Label4)
        Me.XtraTabPage2.Controls.Add(Me.Label3)
        Me.XtraTabPage2.Controls.Add(Me.txt_unvan)
        Me.XtraTabPage2.Controls.Add(Me.txt_ad)
        Me.XtraTabPage2.Controls.Add(Me.Label2)
        Me.XtraTabPage2.Controls.Add(Me.txt_kod)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.PageVisible = False
        Me.XtraTabPage2.Size = New System.Drawing.Size(814, 311)
        Me.XtraTabPage2.Text = "Taným"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(185, 240)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(73, 23)
        Me.SimpleButton3.TabIndex = 40
        Me.SimpleButton3.Text = "&Vazgeç"
        '
        'sec_depo
        '
        Me.sec_depo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sec_depo.EnterMoveNextControl = True
        Me.sec_depo.Location = New System.Drawing.Point(104, 213)
        Me.sec_depo.Name = "sec_depo"
        Me.sec_depo.Properties.AutoSearchColumnIndex = 1
        Me.sec_depo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo.Properties.CaseSensitiveSearch = True
        Me.sec_depo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("IND", "KayýtNo", 24, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DEPOKODU", "Depo", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.sec_depo.Properties.DisplayMember = "DEPOKODU"
        Me.sec_depo.Properties.ImmediatePopup = True
        Me.sec_depo.Properties.NullText = "[Depo Seç]"
        Me.sec_depo.Properties.ShowFooter = False
        Me.sec_depo.Properties.ShowHeader = False
        Me.sec_depo.Properties.ValueMember = "IND"
        Me.sec_depo.Size = New System.Drawing.Size(154, 20)
        Me.sec_depo.TabIndex = 39
        '
        'btn_kaydet
        '
        Me.btn_kaydet.Image = CType(resources.GetObject("btn_kaydet.Image"), System.Drawing.Image)
        Me.btn_kaydet.Location = New System.Drawing.Point(104, 240)
        Me.btn_kaydet.Name = "btn_kaydet"
        Me.btn_kaydet.Size = New System.Drawing.Size(75, 23)
        Me.btn_kaydet.TabIndex = 38
        Me.btn_kaydet.Text = "&Kaydet"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 212)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Depo :"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(16, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Fax :"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(16, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Telefon :"
        '
        'txt_fax
        '
        Me.txt_fax.EnterMoveNextControl = True
        Me.txt_fax.Location = New System.Drawing.Point(104, 194)
        Me.txt_fax.Name = "txt_fax"
        Me.txt_fax.Properties.MaxLength = 20
        Me.txt_fax.Size = New System.Drawing.Size(153, 20)
        Me.txt_fax.TabIndex = 33
        '
        'txt_telefon
        '
        Me.txt_telefon.EnterMoveNextControl = True
        Me.txt_telefon.Location = New System.Drawing.Point(104, 175)
        Me.txt_telefon.Name = "txt_telefon"
        Me.txt_telefon.Properties.MaxLength = 20
        Me.txt_telefon.Size = New System.Drawing.Size(153, 20)
        Me.txt_telefon.TabIndex = 32
        '
        'txt_vergino
        '
        Me.txt_vergino.EnterMoveNextControl = True
        Me.txt_vergino.Location = New System.Drawing.Point(104, 156)
        Me.txt_vergino.Name = "txt_vergino"
        Me.txt_vergino.Properties.MaxLength = 15
        Me.txt_vergino.Size = New System.Drawing.Size(153, 20)
        Me.txt_vergino.TabIndex = 31
        '
        'txt_vergidairesi
        '
        Me.txt_vergidairesi.EnterMoveNextControl = True
        Me.txt_vergidairesi.Location = New System.Drawing.Point(104, 137)
        Me.txt_vergidairesi.Name = "txt_vergidairesi"
        Me.txt_vergidairesi.Properties.MaxLength = 15
        Me.txt_vergidairesi.Size = New System.Drawing.Size(153, 20)
        Me.txt_vergidairesi.TabIndex = 30
        '
        'txt_adres
        '
        Me.txt_adres.EnterMoveNextControl = True
        Me.txt_adres.Location = New System.Drawing.Point(104, 90)
        Me.txt_adres.Name = "txt_adres"
        Me.txt_adres.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_adres.Size = New System.Drawing.Size(345, 48)
        Me.txt_adres.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "VergiNo :"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "VergiDairesi :"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Sevk Adresi :"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Firma Ünvaný :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Yer Adý :"
        '
        'txt_unvan
        '
        Me.txt_unvan.EnterMoveNextControl = True
        Me.txt_unvan.Location = New System.Drawing.Point(104, 71)
        Me.txt_unvan.Name = "txt_unvan"
        Me.txt_unvan.Properties.MaxLength = 50
        Me.txt_unvan.Size = New System.Drawing.Size(345, 20)
        Me.txt_unvan.TabIndex = 23
        '
        'txt_ad
        '
        Me.txt_ad.EnterMoveNextControl = True
        Me.txt_ad.Location = New System.Drawing.Point(104, 52)
        Me.txt_ad.Name = "txt_ad"
        Me.txt_ad.Properties.MaxLength = 50
        Me.txt_ad.Size = New System.Drawing.Size(145, 20)
        Me.txt_ad.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Yer Kodu :"
        '
        'txt_kod
        '
        Me.txt_kod.EnterMoveNextControl = True
        Me.txt_kod.Location = New System.Drawing.Point(104, 33)
        Me.txt_kod.Name = "txt_kod"
        Me.txt_kod.Properties.MaxLength = 50
        Me.txt_kod.Size = New System.Drawing.Size(145, 20)
        Me.txt_kod.TabIndex = 20
        '
        'ps1
        '
        Me.ps1.Links.AddRange(New Object() {Me.printlink1})
        '
        'printlink1
        '
        Me.printlink1.Component = Me.GridControl1
        '
        '
        '
        Me.printlink1.ImageCollection.ImageStream = CType(resources.GetObject("printlink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Üretim Yerleri Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Üretim Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps1
        Me.printlink1.PrintingSystemBase = Me.ps1
        '
        'DataSet4
        '
        Me.DataSet4.DataSetName = "NewDataSet"
        Me.DataSet4.Locale = New System.Globalization.CultureInfo("tr-TR")
        '
        'frm_uretim_yerleri
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_uretim_yerleri"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Üretim Yerleri"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_telefon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_vergino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_vergidairesi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_adres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_unvan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim islem As String
    Dim kayitno As Int64
    Dim dr As DataRow
    Dim satir
    Private Sub frm_uretim_yerleri_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        dataload_yerler()
        dataload_depo()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        sorgu_s()
    End Sub
    Private Sub ekran_full()
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\URETIM\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\URETIM\" & Me.Name.ToString & "")
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
    End Sub
    Private Sub dataload_yerler()
        DataSet1 = sorgu(sorgu_query("SELECT     *  FROM         TBLUREURETIMYERLERI"))
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Select()
        GridControl1.Focus()
    End Sub
    Private Sub dataload_depo()
        DataSet4 = sorgu(sorgu_query("SELECT     sDepo,sAciklama FROM tbDepo  ORDER BY sDepo"))
        sec_depo.Properties.DataSource = DataSet4.Tables(0)
        sec_depo.Refresh()
        sec_depo.ItemIndex = 0
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
    End Function
    Private Sub ekle(ByVal KOD As String, ByVal AD As String, ByVal CARINO As Int64, ByVal UNVAN As String, ByVal ADRESSEVK As String, ByVal TELEFON As String, ByVal FAX As String, ByVal VERGIDAIRESI As String, ByVal VERGINO As String, ByVal DEPONO As Int64, ByVal DEPOKODU As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO TBLUREURETIMYERLERI                       (KOD, AD, CARINO, UNVAN, ADRESSEVK, TELEFON, FAX, VERGIDAIRESI, VERGINO, DEPONO, DEPOKODU) VALUES     ('" & KOD & "', '" & AD & "', " & CARINO & ", '" & UNVAN & "', '" & ADRESSEVK & "', '" & TELEFON & "', '" & FAX & "', '" & VERGIDAIRESI & "', '" & VERGINO & "' ,'" & DEPONO & "', '" & DEPOKODU & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub duzelt(ByVal ind As Int64, ByVal KOD As String, ByVal AD As String, ByVal CARINO As Int64, ByVal UNVAN As String, ByVal ADRESSEVK As String, ByVal TELEFON As String, ByVal FAX As String, ByVal VERGIDAIRESI As String, ByVal VERGINO As String, ByVal DEPONO As Int64, ByVal DEPOKODU As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    TBLUREURETIMYERLERI SET              KOD = '" & KOD & "', AD = '" & AD & "', CARINO = " & CARINO & ", UNVAN = '" & UNVAN & "', ADRESSEVK = '" & ADRESSEVK & "', TELEFON = '" & TELEFON & "', FAX = '" & FAX & "', VERGIDAIRESI = '" & VERGIDAIRESI & "', VERGINO = '" & VERGINO & "', DEPONO ='" & DEPONO & "', DEPOKODU = '" & DEPOKODU & "' WHERE IND =" & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub sil(ByVal ind As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM TBLUREURETIMYERLERI WHERE IND = " & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        ekran_full()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        printlink1.CreateDocument(ps1)
        ps1.PreviewFormEx.ShowDialog()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        GridView1.OptionsCustomization.AllowFilter = True
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        GridView1.OptionsCustomization.AllowGroup = True
        GridView1.OptionsView.ShowGroupPanel = True
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        kayit_ekle()
    End Sub
    Private Sub kayit_ekle()
        XtraTabPage1.PageVisible = False
        XtraTabPage2.PageVisible = True
        XtraTabControl1.SelectedTabPageIndex = 1
        txt_kod.Focus()
        txt_kod.Select()
        islem = "ekle"
        kayitno = 0
        txt_kod.EditValue = ""
        txt_ad.EditValue = ""
        txt_unvan.EditValue = ""
        txt_adres.EditValue = ""
        txt_telefon.EditValue = ""
        txt_fax.EditValue = ""
        txt_vergidairesi.EditValue = ""
        txt_vergino.EditValue = ""
        sec_depo.EditValue = 1
    End Sub
    Private Sub btn_kaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_kaydet.Click
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = False
        XtraTabControl1.SelectedTabPageIndex = 0
        GridControl1.Focus()
        GridControl1.Select()
        kaydet()
        dataload_yerler()
        If islem = "duzelt" Then
            GridView1.FocusedRowHandle = satir
        End If
    End Sub
    Private Sub kaydet()
        If islem = "ekle" Then
            ekle(txt_kod.Text, txt_ad.Text, 0, txt_unvan.Text, txt_adres.Text, txt_telefon.Text, txt_fax.Text, txt_vergidairesi.Text, txt_vergino.Text, sec_depo.EditValue, sec_depo.Text)
            'ekle(txt_kullanici.Text, txt_sifre.Text, txt_ad.Text, txt_soyad.Text, sec_firma.EditValue, sec_donem.EditValue, sec_depo.EditValue)
        ElseIf islem = "duzelt" Then
            duzelt(kayitno, txt_kod.Text, txt_ad.Text, 0, txt_unvan.Text, txt_adres.Text, txt_telefon.Text, txt_fax.Text, txt_vergidairesi.Text, txt_vergino.Text, sec_depo.EditValue, sec_depo.Text)
            'duzelt(txt_kullanici.Text, txt_sifre.Text, txt_ad.Text, txt_soyad.Text, sec_firma.EditValue, sec_donem.EditValue, sec_depo.EditValue, kayitno)
        End If
    End Sub
    Private Sub kayit_duzelt()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            satir = GridView1.FocusedRowHandle
            kayitno = dr("IND")
            txt_kod.Text = dr("KOD").ToString
            txt_ad.Text = dr("AD").ToString
            txt_unvan.Text = dr("UNVAN").ToString
            txt_adres.Text = dr("ADRESSEVK").ToString
            txt_vergidairesi.Text = dr("VERGIDAIRESI").ToString
            txt_vergino.Text = dr("VERGINO").ToString
            txt_telefon.Text = dr("TELEFON").ToString
            txt_fax.Text = dr("FAX").ToString
            'Try
            '    sec_firma.EditValue = dr("FIRMA")
            'Catch ex As Exception
            '    sec_firma.EditValue = 100
            'End Try
            'Try
            '    sec_donem.EditValue = dr("DONEM")
            'Catch ex As Exception
            '    sec_donem.EditValue = 1
            'End Try
            Try
                sec_depo.EditValue = dr("DEPO")
            Catch ex As Exception
                sec_depo.EditValue = 1
            End Try
            XtraTabPage1.PageVisible = False
            XtraTabPage2.PageVisible = True
            XtraTabControl1.SelectedTabPageIndex = 1
            txt_kod.Focus()
            txt_kod.Select()
            islem = "duzelt"
        End If
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        kayit_duzelt()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        Me.Close()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        sorgu_s()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            sorgu_s()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        sorgu_s()
    End Sub
    Private Sub sorgu_s()
        Me.DialogResult = DialogResult.OK
    End Sub
    Private Sub kayit_sil()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            satir = GridView1.FocusedRowHandle
            kayitno = dr("IND")
            If kayitno > 100 Then
                If XtraMessageBox.Show(kayitno & vbTab & Sorgu_sDil("Nolu Üretim Yeri Kaydýný Silmek istediðinize eminmisiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    sil(kayitno)
                End If
            End If
            dataload_yerler()
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        kayit_sil()
    End Sub
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = False
        XtraTabControl1.SelectedTabPageIndex = 0
        GridControl1.Focus()
        GridControl1.Select()
        dataload_yerler()
        If islem = "duzelt" Then
            GridView1.FocusedRowHandle = satir
        End If
    End Sub
End Class
