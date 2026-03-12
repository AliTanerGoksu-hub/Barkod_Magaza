Imports DevExpress.XtraEditors
Public Class frm_emir_arac_km_takip
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
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
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
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPLAKA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSOFOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIKISKM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIKISSAAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVARISKM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVARISSAAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIKISYERI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISTIKAMET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVARISYERI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAMAC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSONUC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_saat As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
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
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents colSURE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_emir_arac_km_takip))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
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
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPLAKA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSOFOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCIKISKM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCIKISSAAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_saat = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
        Me.colVARISKM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVARISSAAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCIKISYERI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISTIKAMET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVARISYERI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAMAC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSONUC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSURE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
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
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_saat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.DateEdit1)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 56)
        Me.PanelControl1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Appearance.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(616, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tarih:"
        '
        'DateEdit1
        '
        Me.DateEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(664, 16)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.DisplayFormat.FormatString = "D"
        Me.DateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(144, 22)
        Me.DateEdit1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(110, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Araçlarýn KM ve Kullaným Bilgileri aþaðýdadýr..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 389)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 40)
        Me.PanelControl2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(88, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(8, 8)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton3.TabIndex = 4
        Me.SimpleButton3.Text = "&Ekle"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(736, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(656, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 333)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 329)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(818, 296)
        Me.XtraTabPage1.Text = "Tanýmlar"
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
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_saat})
        Me.GridControl1.Size = New System.Drawing.Size(818, 296)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem12, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7, Me.MenuItem13, Me.MenuItem8, Me.MenuItem9, Me.MenuItem14, Me.MenuItem10, Me.MenuItem11, Me.MenuItem16, Me.MenuItem15})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem1.Text = "Satýr Ekle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem2.Text = "Düzelt"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem3.Text = "Satýr Sil"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 3
        Me.MenuItem12.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 4
        Me.MenuItem4.Text = "Görünümü Düzenle"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 5
        Me.MenuItem5.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 6
        Me.MenuItem6.Text = "Görünümü Kaydet"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 7
        Me.MenuItem7.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem7.Text = "Görünümü Yazdýr"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 8
        Me.MenuItem13.Text = "-"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 9
        Me.MenuItem8.Text = "Filtrele"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 10
        Me.MenuItem9.Text = "Gruplandýr"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 11
        Me.MenuItem14.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 12
        Me.MenuItem10.Text = "Satýrlarý Aç"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 13
        Me.MenuItem11.Text = "Satýrlarý Kapat"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 14
        Me.MenuItem16.Text = "-"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 15
        Me.MenuItem15.Text = "Ekraný Kapla"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "IND"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "TARIH"
        Me.DataColumn2.DataType = GetType(Date)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "PLAKA"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "SOFOR"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "CIKISKM"
        Me.DataColumn5.DataType = GetType(Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "CIKISSAAT"
        Me.DataColumn6.DataType = GetType(Date)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "VARISKM"
        Me.DataColumn7.DataType = GetType(Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "VARISSAAT"
        Me.DataColumn8.DataType = GetType(Date)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "KM"
        Me.DataColumn9.DataType = GetType(Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "CIKISYERI"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "ISTIKAMET"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "VARISYERI"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "AMAC"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "ACIKLAMA"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "SONUC"
        Me.DataColumn15.DataType = GetType(Boolean)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "SURE"
        Me.DataColumn16.DataType = GetType(Decimal)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.colTARIH, Me.colPLAKA, Me.colSOFOR, Me.colCIKISKM, Me.colCIKISSAAT, Me.colVARISKM, Me.colVARISSAAT, Me.colKM, Me.colCIKISYERI, Me.colISTIKAMET, Me.colVARISYERI, Me.colAMAC, Me.colACIKLAMA, Me.colSONUC, Me.colSURE})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(533, 404, 208, 170)
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
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.AutoMoveRowFocus = False
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colIND
        '
        Me.colIND.Caption = "Kayýt No"
        Me.colIND.FieldName = "IND"
        Me.colIND.Name = "colIND"
        '
        'colTARIH
        '
        Me.colTARIH.Caption = "Tarih"
        Me.colTARIH.FieldName = "TARIH"
        Me.colTARIH.Name = "colTARIH"
        Me.colTARIH.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TARIH", "{0} Kayýt")})
        Me.colTARIH.Visible = True
        Me.colTARIH.VisibleIndex = 0
        Me.colTARIH.Width = 83
        '
        'colPLAKA
        '
        Me.colPLAKA.Caption = "Plaka"
        Me.colPLAKA.FieldName = "PLAKA"
        Me.colPLAKA.Name = "colPLAKA"
        Me.colPLAKA.Visible = True
        Me.colPLAKA.VisibleIndex = 1
        '
        'colSOFOR
        '
        Me.colSOFOR.Caption = "Þoför"
        Me.colSOFOR.FieldName = "SOFOR"
        Me.colSOFOR.Name = "colSOFOR"
        Me.colSOFOR.Visible = True
        Me.colSOFOR.VisibleIndex = 2
        Me.colSOFOR.Width = 92
        '
        'colCIKISKM
        '
        Me.colCIKISKM.Caption = "ÇýkýþKm"
        Me.colCIKISKM.DisplayFormat.FormatString = "#,0.##"
        Me.colCIKISKM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCIKISKM.FieldName = "CIKISKM"
        Me.colCIKISKM.Name = "colCIKISKM"
        Me.colCIKISKM.Visible = True
        Me.colCIKISKM.VisibleIndex = 3
        Me.colCIKISKM.Width = 48
        '
        'colCIKISSAAT
        '
        Me.colCIKISSAAT.Caption = "ÇýkýþSaati"
        Me.colCIKISSAAT.ColumnEdit = Me.sec_saat
        Me.colCIKISSAAT.DisplayFormat.FormatString = "HH:mm"
        Me.colCIKISSAAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colCIKISSAAT.FieldName = "CIKISSAAT"
        Me.colCIKISSAAT.Name = "colCIKISSAAT"
        Me.colCIKISSAAT.Visible = True
        Me.colCIKISSAAT.VisibleIndex = 4
        Me.colCIKISSAAT.Width = 59
        '
        'sec_saat
        '
        Me.sec_saat.AutoHeight = False
        Me.sec_saat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_saat.DisplayFormat.FormatString = "HH:mm"
        Me.sec_saat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.sec_saat.Name = "sec_saat"
        '
        'colVARISKM
        '
        Me.colVARISKM.Caption = "VarýþKm"
        Me.colVARISKM.DisplayFormat.FormatString = "#,0.##"
        Me.colVARISKM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVARISKM.FieldName = "VARISKM"
        Me.colVARISKM.Name = "colVARISKM"
        Me.colVARISKM.Visible = True
        Me.colVARISKM.VisibleIndex = 5
        Me.colVARISKM.Width = 56
        '
        'colVARISSAAT
        '
        Me.colVARISSAAT.Caption = "VarýþSaati"
        Me.colVARISSAAT.ColumnEdit = Me.sec_saat
        Me.colVARISSAAT.DisplayFormat.FormatString = "HH:mm"
        Me.colVARISSAAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colVARISSAAT.FieldName = "VARISSAAT"
        Me.colVARISSAAT.Name = "colVARISSAAT"
        Me.colVARISSAAT.Visible = True
        Me.colVARISSAAT.VisibleIndex = 6
        Me.colVARISSAAT.Width = 58
        '
        'colKM
        '
        Me.colKM.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colKM.AppearanceCell.Options.UseForeColor = True
        Me.colKM.Caption = "Km"
        Me.colKM.DisplayFormat.FormatString = "#,0.##"
        Me.colKM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKM.FieldName = "KM"
        Me.colKM.Name = "colKM"
        Me.colKM.OptionsColumn.AllowFocus = False
        Me.colKM.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KM", "{0:#,0.00}")})
        Me.colKM.Visible = True
        Me.colKM.VisibleIndex = 7
        Me.colKM.Width = 47
        '
        'colCIKISYERI
        '
        Me.colCIKISYERI.Caption = "ÇýkýþYeri"
        Me.colCIKISYERI.FieldName = "CIKISYERI"
        Me.colCIKISYERI.Name = "colCIKISYERI"
        Me.colCIKISYERI.Visible = True
        Me.colCIKISYERI.VisibleIndex = 9
        Me.colCIKISYERI.Width = 97
        '
        'colISTIKAMET
        '
        Me.colISTIKAMET.Caption = "Ýstikamet"
        Me.colISTIKAMET.FieldName = "ISTIKAMET"
        Me.colISTIKAMET.Name = "colISTIKAMET"
        Me.colISTIKAMET.Visible = True
        Me.colISTIKAMET.VisibleIndex = 10
        Me.colISTIKAMET.Width = 201
        '
        'colVARISYERI
        '
        Me.colVARISYERI.Caption = "VarýþYeri"
        Me.colVARISYERI.FieldName = "VARISYERI"
        Me.colVARISYERI.Name = "colVARISYERI"
        Me.colVARISYERI.Visible = True
        Me.colVARISYERI.VisibleIndex = 11
        Me.colVARISYERI.Width = 107
        '
        'colAMAC
        '
        Me.colAMAC.Caption = "VarsaAmaç?"
        Me.colAMAC.FieldName = "AMAC"
        Me.colAMAC.Name = "colAMAC"
        Me.colAMAC.Visible = True
        Me.colAMAC.VisibleIndex = 12
        Me.colAMAC.Width = 110
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.Caption = "Açýklama"
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 13
        Me.colACIKLAMA.Width = 163
        '
        'colSONUC
        '
        Me.colSONUC.Caption = "Sonuc"
        Me.colSONUC.FieldName = "SONUC"
        Me.colSONUC.Name = "colSONUC"
        '
        'colSURE
        '
        Me.colSURE.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colSURE.AppearanceCell.Options.UseForeColor = True
        Me.colSURE.Caption = "Süre"
        Me.colSURE.DisplayFormat.FormatString = "#,0.00 dk"
        Me.colSURE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSURE.FieldName = "SURE"
        Me.colSURE.Name = "colSURE"
        Me.colSURE.OptionsColumn.AllowFocus = False
        Me.colSURE.Visible = True
        Me.colSURE.VisibleIndex = 8
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(818, 296)
        Me.XtraTabPage2.Text = "Raporlar"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Araç Km/Rut Takibi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Araç Takip Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_emir_arac_km_takip
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_emir_arac_km_takip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Araç Km Takip"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
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
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_saat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim adapter As New OleDb.OleDbDataAdapter
    Public status As Boolean = False
    Private Sub frm_emir_arac_km_takip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateEdit1.EditValue = dteSistemTarihi
        dataload()
        status = True
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub frm_emir_arac_km_takip_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
        Me.Hide()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        satir_ekle()
    End Sub
    Private Sub dataload()
        DataSet1 = sorgu_s(sorgu_query("SELECT     * FROM         aEmirAracKmTakip WHERE TARIH ='" & DateEdit1.EditValue & "'"))
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
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
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Sub satir_ekle()
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim plaka As String = ""
        Dim sofor As String = ""
        Dim cikiskm As Int64
        Dim cikissaat As DateTime
        Dim cikisyeri As String = ""
        dr1 = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        If GridView1.RowCount > 0 Then
            plaka = dr1("PLAKA").ToString
            sofor = dr1("SOFOR").ToString
            cikiskm = dr1("VARISKM")
            cikissaat = dr1("VARISSAAT")
            cikisyeri = dr1("VARISYERI").ToString
        End If
        dr = DataSet1.Tables(0).NewRow
        If GridView1.RowCount > 0 Then
            dr("PLAKA") = plaka
            dr("SOFOR") = sofor
            dr("CIKISKM") = cikiskm
            dr("CIKISSAAT") = cikissaat
            dr("CIKISYERI") = cikisyeri
            dr("AMAC") = dr1("AMAC")
        Else
            dr("PLAKA") = ""
            dr("SOFOR") = ""
            dr("CIKISKM") = 0
            dr("CIKISSAAT") = Now.ToLongTimeString
            dr("CIKISYERI") = ""
            dr("AMAC") = ""
        End If
        dr("TARIH") = DateEdit1.EditValue
        dr("VARISKM") = 0
        dr("VARISSAAT") = dr("CIKISSAAT")
        dr("KM") = 0
        dr("SURE") = DateDiff(DateInterval.Minute, dr("CIKISSAAT"), dr("VARISSAAT"))
        dr("ISTIKAMET") = ""
        dr("ACIKLAMA") = ""
        dr("SONUC") = 0
        dr("IND") = hareket_kaydet_yeni(dr("TARIH"), dr("PLAKA").ToString, dr("SOFOR").ToString, dr("CIKISKM"), dr("CIKISSAAT"), dr("VARISKM"), dr("VARISSAAT"), dr("KM"), dr("SURE"), dr("CIKISYERI").ToString, dr("ISTIKAMET").ToString, dr("VARISYERI").ToString, dr("AMAC").ToString, dr("ACIKLAMA").ToString, dr("SONUC"))
        DataSet1.Tables(0).Rows.Add(dr)
    End Sub
    Private Sub girdi_tutar_hesapla()
        Dim dr As DataRow
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.BeginEdit()
            'If dr("KM") = 0 Then
            '    dr("MIKTAR") = 1
            'End If
            dr("KM") = dr("VARISKM") - dr("CIKISKM")
            dr("SURE") = DateDiff(DateInterval.Minute, dr("CIKISSAAT"), dr("VARISSAAT"))
            If dr("PLAKA") <> "" Then
                dr("SONUC") = 1
            Else
                dr("SONUC") = 0
            End If
            'If GridView1.FocusedColumn.Name.ToString = colHTUTAR.Name.ToString Then
            '    dr("FIYAT") = dr("TUTAR") / dr("MIKTAR")
            'Else
            '    dr("TUTAR") = dr("MIKTAR") * dr("FIYAT")
            'End If
            'dr("TUTAR") = dr("MIKTAR") * dr("FIYAT")
            dr.EndEdit()
            hareket_kaydet_degistir(dr("IND"), dr("TARIH"), dr("PLAKA").ToString, dr("SOFOR").ToString, dr("CIKISKM"), dr("CIKISSAAT"), dr("VARISKM"), dr("VARISSAAT"), dr("KM"), dr("SURE"), dr("CIKISYERI").ToString, dr("ISTIKAMET").ToString, dr("VARISYERI").ToString, dr("AMAC").ToString, dr("ACIKLAMA").ToString, dr("SONUC"))
            'hareket_kaydet_degistir(dr("IND"), dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FISNO"), dr_baslik("IZAHAT"), dr_baslik("FISTARIHI"), dr("STOKNO"), dr("STOKKODU"), dr("MALINCINSI"), dr("BARCODE"), dr("RENK"), dr("BEDEN"), dr("MODEL"), dr("MIKTAR"), dr("DEPO"), sorgu_sayi(Math.Abs(CInt(dr("MEVCUT"))), 0), sorgu_sayi(Math.Abs(CInt(dr(sorgu_sDil("Dikkat",sDil)))), 0), dr("ACIKLAMA"), sorgu_sayi(Math.Abs(CInt(dr("OKUT"))), 0))
            GridControl1.Focus()
            GridControl1.Select()
        End If
    End Sub
    Private Function hareket_kaydet_yeni(ByVal TARIH As DateTime, ByVal PLAKA As String, ByVal SOFOR As String, ByVal CIKISKM As Int64, ByVal CIKISSAAT As DateTime, ByVal VARISKM As Int64, ByVal VARISSAAT As DateTime, ByVal KM As Decimal, ByVal SURE As Decimal, ByVal CIKISYERI As String, ByVal ISTIKAMET As String, ByVal VARISYERI As String, ByVal AMAC As String, ByVal ACIKLAMA As String, ByVal SONUC As Integer) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO aEmirAracKmTakip                       (TARIH, PLAKA, SOFOR, CIKISKM, CIKISSAAT, VARISKM, VARISSAAT, KM, SURE, CIKISYERI, ISTIKAMET, VARISYERI, AMAC, ACIKLAMA, SONUC) VALUES     ('" & TARIH & "', '" & PLAKA & "', '" & SOFOR & "', " & CIKISKM & ", '" & CIKISSAAT & "', " & VARISKM & ", '" & VARISSAAT & "', " & KM & " , " & SURE & " , '" & CIKISYERI & "', '" & ISTIKAMET & "', '" & VARISYERI & "', '" & AMAC & "', '" & ACIKLAMA & "', " & SONUC & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
    End Function
    Private Sub hareket_kaydet_degistir(ByVal ind As Int64, ByVal TARIH As DateTime, ByVal PLAKA As String, ByVal SOFOR As String, ByVal CIKISKM As Int64, ByVal CIKISSAAT As DateTime, ByVal VARISKM As Int64, ByVal VARISSAAT As DateTime, ByVal KM As Decimal, ByVal SURE As Decimal, ByVal CIKISYERI As String, ByVal ISTIKAMET As String, ByVal VARISYERI As String, ByVal AMAC As String, ByVal ACIKLAMA As String, ByVal SONUC As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    aEmirAracKmTakip SET              TARIH = '" & TARIH & "', PLAKA = '" & PLAKA & "', SOFOR = '" & SOFOR & "', CIKISKM = " & CIKISKM & " , CIKISSAAT = '" & CIKISSAAT & "', VARISKM = " & VARISKM & " , VARISSAAT = '" & VARISSAAT & "',  KM = " & KM & " , SURE = " & SURE & " , CIKISYERI = '" & CIKISYERI & "', ISTIKAMET = '" & ISTIKAMET & "', VARISYERI = '" & VARISYERI & "', AMAC = '" & AMAC & "', ACIKLAMA = '" & ACIKLAMA & "',  SONUC = " & SONUC & "  WHERE IND = " & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub hareket_kaydet_sil(ByVal evrakno As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM aEmirAracKmTakip  WHERE IND = " & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function sorgu_s(ByVal query As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        con.Close()
        Return DS
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
            status = True
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
        cmd.CommandTimeout = Nothing
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
    Private Sub satir_sil()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                If dr("IND").ToString <> "" Then
                    hareket_kaydet_sil(dr("IND"))
                End If
                'DataTable1.Rows.RemoveAt(GridView1.FocusedRowHandle - 1)
                DataSet1.Tables(0).Rows.Remove(dr)
                'dr.Delete()
                'dr.AcceptChanges()
                'GridControl1.EndUpdate()
                'DataSet1.EndInit()
                GridControl1.Select()
                GridControl1.Focus()
            End If
        End If
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        girdi_tutar_hesapla()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        satir_ekle()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        satir_sil()
    End Sub
    Private Sub DateEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateEdit1.EditValueChanged
        If status = True Then
            dataload()
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
        If GridView1.SelectedRowsCount > 1 Then
            Label3.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label3.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label3.Text = ""
        End If
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        printlink1.CreateDocument(ps)
        ps.PreviewFormEx.ShowDialog()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        gorunum_kaydet()
    End Sub
End Class
