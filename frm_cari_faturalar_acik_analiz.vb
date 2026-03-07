Imports DevExpress.XtraEditors
Public Class frm_cari_faturalar_acik_analiz
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
    Friend WithEvents DataSet1 As System.Data.DataSet
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
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents fieldnMusteriID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldkodu As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTUTAR As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTAHSILAT As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldKALAN As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldAY As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldYIL As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fielddteTarihi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsFisTipi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fielddteFaturaTarihi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlFaturaNo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlToplamMiktar As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlPesinat As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldlNetTutar As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsYaziIle As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldnKasaNo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fielddteKayitTarihi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldnAlisverisID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsAdi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsSoyadi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField7 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField8 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField9 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField10 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField11 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField12 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField13 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField14 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField15 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField16 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField17 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField18 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField19 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridField20 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cari_faturalar_acik_analiz))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
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
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.PivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField7 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField8 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField9 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField10 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField11 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField12 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField13 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField14 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField15 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField16 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField17 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField18 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField19 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridField20 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 56)
        Me.PanelControl1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kalan Ödemeler Analizi Ekraný Aþaðýdadýr..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 357)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "***"
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
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 301)
        Me.PanelControl3.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridControl1.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridControl1.Appearance.Empty.Options.UseBackColor = True
        Me.GridControl1.Appearance.FieldValueGrandTotal.BackColor = System.Drawing.Color.Silver
        Me.GridControl1.Appearance.FieldValueGrandTotal.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridControl1.Appearance.FieldValueGrandTotal.ForeColor = System.Drawing.Color.Black
        Me.GridControl1.Appearance.FieldValueGrandTotal.Options.UseBackColor = True
        Me.GridControl1.Appearance.FieldValueGrandTotal.Options.UseForeColor = True
        Me.GridControl1.Appearance.GrandTotalCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridControl1.Appearance.GrandTotalCell.ForeColor = System.Drawing.Color.Black
        Me.GridControl1.Appearance.GrandTotalCell.Options.UseBackColor = True
        Me.GridControl1.Appearance.GrandTotalCell.Options.UseForeColor = True
        Me.GridControl1.Appearance.TotalCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridControl1.Appearance.TotalCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridControl1.Appearance.TotalCell.ForeColor = System.Drawing.Color.Black
        Me.GridControl1.Appearance.TotalCell.Options.UseBackColor = True
        Me.GridControl1.Appearance.TotalCell.Options.UseForeColor = True
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataMember = Nothing
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.PivotGridField1, Me.PivotGridField2, Me.PivotGridField3, Me.PivotGridField4, Me.PivotGridField5, Me.PivotGridField6, Me.PivotGridField7, Me.PivotGridField8, Me.PivotGridField9, Me.PivotGridField10, Me.PivotGridField11, Me.PivotGridField12, Me.PivotGridField13, Me.PivotGridField14, Me.PivotGridField15, Me.PivotGridField16, Me.PivotGridField17, Me.PivotGridField18, Me.PivotGridField19, Me.PivotGridField20})
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.OptionsBehavior.ApplyBestFitOnFieldDragging = True
        Me.GridControl1.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridControl1.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridControl1.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridControl1.OptionsPrint.PrintHorzLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridControl1.OptionsPrint.PrintVertLines = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridControl1.OptionsView.ShowColumnHeaders = False
        Me.GridControl1.OptionsView.ShowDataHeaders = False
        Me.GridControl1.Size = New System.Drawing.Size(820, 297)
        Me.GridControl1.TabIndex = 0
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
        Me.DataColumn1.ColumnName = "nMusteriID"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "kodu"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "TUTAR"
        Me.DataColumn3.DataType = GetType(Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "TAHSILAT"
        Me.DataColumn4.DataType = GetType(Decimal)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "KALAN"
        Me.DataColumn5.DataType = GetType(Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "AY"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "YIL"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "dteTarihi"
        Me.DataColumn8.DataType = GetType(Date)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sFisTipi"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "dteFaturaTarihi"
        Me.DataColumn10.DataType = GetType(Date)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "lFaturaNo"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "lToplamMiktar"
        Me.DataColumn12.DataType = GetType(Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "lPesinat"
        Me.DataColumn13.DataType = GetType(Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "lNetTutar"
        Me.DataColumn14.DataType = GetType(Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sYaziIle"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "nKasaNo"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "dteKayitTarihi"
        Me.DataColumn17.DataType = GetType(Date)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "nAlisverisID"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "sAdi"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sSoyadi"
        '
        'PivotGridField1
        '
        Me.PivotGridField1.AreaIndex = 0
        Me.PivotGridField1.Caption = "Müþteri No"
        Me.PivotGridField1.FieldName = "nMusteriID"
        Me.PivotGridField1.Name = "PivotGridField1"
        '
        'PivotGridField2
        '
        Me.PivotGridField2.AreaIndex = 1
        Me.PivotGridField2.Caption = "Müþteri Kodu"
        Me.PivotGridField2.FieldName = "kodu"
        Me.PivotGridField2.Name = "PivotGridField2"
        Me.PivotGridField2.Visible = False
        '
        'PivotGridField3
        '
        Me.PivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField3.AreaIndex = 0
        Me.PivotGridField3.Caption = "Tutar"
        Me.PivotGridField3.CellFormat.FormatString = "#,0.00"
        Me.PivotGridField3.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField3.FieldName = "TUTAR"
        Me.PivotGridField3.Name = "PivotGridField3"
        Me.PivotGridField3.Width = 64
        '
        'PivotGridField4
        '
        Me.PivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField4.AreaIndex = 1
        Me.PivotGridField4.Caption = "Ödenen"
        Me.PivotGridField4.CellFormat.FormatString = "#,0.00"
        Me.PivotGridField4.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField4.FieldName = "TAHSILAT"
        Me.PivotGridField4.Name = "PivotGridField4"
        Me.PivotGridField4.Width = 66
        '
        'PivotGridField5
        '
        Me.PivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.PivotGridField5.AreaIndex = 2
        Me.PivotGridField5.Caption = "Kalan"
        Me.PivotGridField5.CellFormat.FormatString = "#,0.00"
        Me.PivotGridField5.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PivotGridField5.FieldName = "KALAN"
        Me.PivotGridField5.Name = "PivotGridField5"
        Me.PivotGridField5.Width = 66
        '
        'PivotGridField6
        '
        Me.PivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField6.AreaIndex = 1
        Me.PivotGridField6.Caption = "Ay"
        Me.PivotGridField6.CellFormat.FormatString = "M"
        Me.PivotGridField6.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField6.FieldName = "AY"
        Me.PivotGridField6.Name = "PivotGridField6"
        Me.PivotGridField6.Width = 97
        '
        'PivotGridField7
        '
        Me.PivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.PivotGridField7.AreaIndex = 0
        Me.PivotGridField7.Caption = "Yýl"
        Me.PivotGridField7.FieldName = "YIL"
        Me.PivotGridField7.Name = "PivotGridField7"
        Me.PivotGridField7.Width = 67
        '
        'PivotGridField8
        '
        Me.PivotGridField8.AreaIndex = 3
        Me.PivotGridField8.Caption = "Tarih"
        Me.PivotGridField8.FieldName = "dteTarihi"
        Me.PivotGridField8.Name = "PivotGridField8"
        Me.PivotGridField8.Width = 37
        '
        'PivotGridField9
        '
        Me.PivotGridField9.AreaIndex = 1
        Me.PivotGridField9.Caption = "Fiþ Tipi"
        Me.PivotGridField9.FieldName = "sFisTipi"
        Me.PivotGridField9.Name = "PivotGridField9"
        '
        'PivotGridField10
        '
        Me.PivotGridField10.AreaIndex = 2
        Me.PivotGridField10.Caption = "AlýþVeriþTarihi"
        Me.PivotGridField10.CellFormat.FormatString = "d"
        Me.PivotGridField10.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PivotGridField10.FieldName = "dteFaturaTarihi"
        Me.PivotGridField10.Name = "PivotGridField10"
        '
        'PivotGridField11
        '
        Me.PivotGridField11.AreaIndex = 4
        Me.PivotGridField11.Caption = "FaturaNo"
        Me.PivotGridField11.FieldName = "lFaturaNo"
        Me.PivotGridField11.Name = "PivotGridField11"
        Me.PivotGridField11.Visible = False
        '
        'PivotGridField12
        '
        Me.PivotGridField12.AreaIndex = 4
        Me.PivotGridField12.Caption = "Toplam Miktar"
        Me.PivotGridField12.FieldName = "lToplamMiktar"
        Me.PivotGridField12.Name = "PivotGridField12"
        Me.PivotGridField12.Visible = False
        '
        'PivotGridField13
        '
        Me.PivotGridField13.AreaIndex = 4
        Me.PivotGridField13.Caption = "Peþinat"
        Me.PivotGridField13.FieldName = "lPesinat"
        Me.PivotGridField13.Name = "PivotGridField13"
        Me.PivotGridField13.Visible = False
        '
        'PivotGridField14
        '
        Me.PivotGridField14.AreaIndex = 8
        Me.PivotGridField14.Caption = "FaturaTutarý"
        Me.PivotGridField14.FieldName = "lNetTutar"
        Me.PivotGridField14.Name = "PivotGridField14"
        Me.PivotGridField14.Visible = False
        '
        'PivotGridField15
        '
        Me.PivotGridField15.AreaIndex = 9
        Me.PivotGridField15.Caption = "YazýlÝle"
        Me.PivotGridField15.FieldName = "sYaziIle"
        Me.PivotGridField15.Name = "PivotGridField15"
        Me.PivotGridField15.Visible = False
        '
        'PivotGridField16
        '
        Me.PivotGridField16.AreaIndex = 10
        Me.PivotGridField16.Caption = "KasaNo"
        Me.PivotGridField16.FieldName = "nKasaNo"
        Me.PivotGridField16.Name = "PivotGridField16"
        Me.PivotGridField16.Visible = False
        '
        'PivotGridField17
        '
        Me.PivotGridField17.AreaIndex = 11
        Me.PivotGridField17.Caption = "Kayýt Saati"
        Me.PivotGridField17.FieldName = "dteKayitTarihi"
        Me.PivotGridField17.Name = "PivotGridField17"
        Me.PivotGridField17.Visible = False
        '
        'PivotGridField18
        '
        Me.PivotGridField18.AreaIndex = 4
        Me.PivotGridField18.Caption = "AlýþVeriþ No"
        Me.PivotGridField18.FieldName = "nAlisverisID"
        Me.PivotGridField18.Name = "PivotGridField18"
        Me.PivotGridField18.Visible = False
        '
        'PivotGridField19
        '
        Me.PivotGridField19.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.PivotGridField19.AreaIndex = 0
        Me.PivotGridField19.Caption = "Ad"
        Me.PivotGridField19.FieldName = "sAdi"
        Me.PivotGridField19.Name = "PivotGridField19"
        '
        'PivotGridField20
        '
        Me.PivotGridField20.AreaIndex = 4
        Me.PivotGridField20.Caption = "Soyad"
        Me.PivotGridField20.FieldName = "sSoyadi"
        Me.PivotGridField20.Name = "PivotGridField20"
        Me.PivotGridField20.Visible = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem15, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Kalan Ödemeler", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2})
        Me.BarManager1.MaxItemId = 2
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Çýkýþ"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape)
        Me.BarButtonItem2.Name = "BarButtonItem2"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 405)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 24)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 405)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 405)
        '
        'frm_cari_faturalar_acik_analiz
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
        Me.Name = "frm_cari_faturalar_acik_analiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ödemeler Analizi"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino As String
    Public kullanici As String
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        dataload()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
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
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridControl1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\ANALIZ\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
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
        GridControl1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\ANALIZ\" & Me.Name.ToString & "")
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
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.lKodu AS kodu, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN,  CAST(MONTH(dteTarihi) AS VARCHAR(2)) + '.' + DATENAME(month, dteTarihi) AS AY, YEAR(tbTaksit.dteTarihi) AS YIL, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbAlisVeris.nAlisverisID, tbMusteri.sAdi as Ad, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sAdi, tbMusteri.sSoyadi FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & musterino & ") GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbMusteri.sAdi  , tbMusteri.sSoyadi, tbMusteri.sEvAdresi1, tbMusteri.sEvAdresi2, tbMusteri.sEvSemt, tbMusteri.sEvPostaKodu, tbMusteri.sEvIl, tbMusteri.sEvTelefonu, tbMusteri.sGSM, tbAlisVeris.nAlisverisID, tbMusteri.sAdi, tbMusteri.sSoyadi HAVING (ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) <> 0) ORDER BY tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo")
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
    Private Sub dataload()
        DataSet1 = stok()
        GridControl1.DataMember = Nothing
        GridControl1.DataSource = DataSet1.Tables(0)
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        'GridView1.CollapseAllGroups()
    End Sub
    Private Sub stok_satis_detay()
        'If GridControl1.RowCount > 0 Then
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
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Açýk Faturalar Kontrol Ekranýndan Çýkmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click
    End Sub
    Private Sub GridControl1_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub frm_cari_faturalar_acik_analiz_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'PanelControl1 = Nothing
        'PanelControl2 = Nothing
        'PanelControl3 = Nothing
        'Label2 = Nothing
        'SimpleButton2 = Nothing
        'SimpleButton1 = Nothing
        'Label1 = Nothing
        'PictureBox1 = Nothing
        'DataSet1 = Nothing
        'ContextMenu1 = Nothing
        'MenuItem1 = Nothing
        'MenuItem2 = Nothing
        'MenuItem3 = Nothing
        'MenuItem4 = Nothing
        'MenuItem5 = Nothing
        'MenuItem6 = Nothing
        'MenuItem7 = Nothing
        'MenuItem8 = Nothing
        'MenuItem9 = Nothing
        'MenuItem10 = Nothing
        'MenuItem11 = Nothing
        'MenuItem12 = Nothing
        'MenuItem13 = Nothing
        'MenuItem14 = Nothing
        'MenuItem15 = Nothing
        'ps = Nothing
        'DataTable1 = Nothing
        'DataColumn1 = Nothing
        'DataColumn2 = Nothing
        'DataColumn3 = Nothing
        'DataColumn4 = Nothing
        'DataColumn5 = Nothing
        'DataColumn6 = Nothing
        'DataColumn7 = Nothing
        'DataColumn8 = Nothing
        'DataColumn9 = Nothing
        'DataColumn10 = Nothing
        'DataColumn11 = Nothing
        'DataColumn12 = Nothing
        'DataColumn13 = Nothing
        'DataColumn14 = Nothing
        'DataColumn15 = Nothing
        'DataColumn16 = Nothing
        'DataColumn17 = Nothing
        'DataColumn18 = Nothing
        'DataColumn19 = Nothing
        'DataColumn20 = Nothing
        'printlink1 = Nothing
        'MenuItem16 = Nothing
        'fieldnMusteriID = Nothing
        'fieldkodu = Nothing
        'fieldTUTAR = Nothing
        'fieldTAHSILAT = Nothing
        'fieldKALAN = Nothing
        'fieldAY = Nothing
        'fieldYIL = Nothing
        'fielddteTarihi = Nothing
        'fieldsFisTipi = Nothing
        'fielddteFaturaTarihi = Nothing
        'fieldlFaturaNo = Nothing
        'fieldlToplamMiktar = Nothing
        'fieldlPesinat = Nothing
        'fieldlNetTutar = Nothing
        'fieldsYaziIle = Nothing
        'fieldnKasaNo = Nothing
        'fielddteKayitTarihi = Nothing
        'fieldnAlisverisID = Nothing
        'fieldsAdi = Nothing
        'fieldsSoyadi = Nothing
        'PivotGridField1 = Nothing
        'PivotGridField2 = Nothing
        'PivotGridField3 = Nothing
        'PivotGridField4 = Nothing
        'PivotGridField5 = Nothing
        'PivotGridField6 = Nothing
        'PivotGridField7 = Nothing
        'PivotGridField8 = Nothing
        'PivotGridField9 = Nothing
        'PivotGridField10 = Nothing
        'PivotGridField11 = Nothing
        'PivotGridField12 = Nothing
        'PivotGridField13 = Nothing
        'PivotGridField14 = Nothing
        'PivotGridField15 = Nothing
        'PivotGridField16 = Nothing
        'PivotGridField17 = Nothing
        'PivotGridField18 = Nothing
        'PivotGridField19 = Nothing
        'PivotGridField20 = Nothing
        'GridControl1 = Nothing
        'Me.Close()
        System.GC.Collect()
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub
End Class
