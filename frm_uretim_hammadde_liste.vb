Imports DevExpress.XtraEditors
Public Class frm_uretim_hammadde_liste
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
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
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
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDETAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOKKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMALINCINSI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBIRIM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBIRIMMIKTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKDV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBARCODE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISLEMTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSONERISIMTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKULLANICI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTUR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEPOKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMALIYETTURU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMIKTARTURU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURETIMCIKISHESAPKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYANSITMAHESAPKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPOZISYONNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIKISPOZISYONNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIREORANI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colARACLINENO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURUNKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colURUNADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTUTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_uretim_hammadde_liste))
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDETAY = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSTOKNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSTOKKODU = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMALINCINSI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBIRIM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBIRIMMIKTAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKDV = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIYAT = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBARCODE = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colISLEMTARIHI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSONERISIMTARIHI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKULLANICI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colORAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTUR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDEPOKODU = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMALIYETTURU = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMIKTARTURU = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colURETIMCIKISHESAPKODU = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colYANSITMAHESAPKODU = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPOZISYONNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCIKISPOZISYONNO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFIREORANI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colARACLINENO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colURUNKODU = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colURUNADI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTUTAR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
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
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(726, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
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
        Me.PanelControl3.Size = New System.Drawing.Size(824, 334)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 330)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(814, 304)
        Me.XtraTabPage1.Text = "Kartlar..."
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(814, 304)
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "IND"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "DETAY"
        Me.DataColumn2.DataType = GetType(Long)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "EVRAKNO"
        Me.DataColumn3.DataType = GetType(Long)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "STOKNO"
        Me.DataColumn4.DataType = GetType(Long)
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "STOKKODU"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "MALINCINSI"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "MIKTAR"
        Me.DataColumn7.DataType = GetType(Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "BIRIM"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "BIRIMMIKTAR"
        Me.DataColumn9.DataType = GetType(Decimal)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "KDV"
        Me.DataColumn10.DataType = GetType(Long)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "FIYAT"
        Me.DataColumn11.DataType = GetType(Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "BARCODE"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "ISLEMTARIHI"
        Me.DataColumn13.DataType = GetType(Date)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "SONERISIMTARIHI"
        Me.DataColumn14.DataType = GetType(Date)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "KULLANICI"
        Me.DataColumn15.DataType = GetType(Long)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "ORAN"
        Me.DataColumn16.DataType = GetType(Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "TUR"
        Me.DataColumn17.DataType = GetType(Long)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "DEPOKODU"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "ACIKLAMA"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "MALIYETTURU"
        Me.DataColumn20.DataType = GetType(Long)
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "MIKTARTURU"
        Me.DataColumn21.DataType = GetType(Long)
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "URETIMCIKISHESAPKODU"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "YANSITMAHESAPKODU"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "POZISYONNO"
        Me.DataColumn24.DataType = GetType(Long)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "CIKISPOZISYONNO"
        Me.DataColumn25.DataType = GetType(Long)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "FIREORANI"
        Me.DataColumn26.DataType = GetType(Long)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "ARACLINENO"
        Me.DataColumn27.DataType = GetType(Long)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "URUNKODU"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "URUNADI"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "TUTAR"
        Me.DataColumn30.DataType = GetType(Decimal)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "KOD"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.colDETAY, Me.colSTOKNO, Me.colSTOKKODU, Me.colMALINCINSI, Me.colMIKTAR, Me.colBIRIM, Me.colBIRIMMIKTAR, Me.colKDV, Me.colFIYAT, Me.colBARCODE, Me.colISLEMTARIHI, Me.colSONERISIMTARIHI, Me.colKULLANICI, Me.colORAN, Me.colTUR, Me.colDEPOKODU, Me.colACIKLAMA, Me.colMALIYETTURU, Me.colMIKTARTURU, Me.colURETIMCIKISHESAPKODU, Me.colYANSITMAHESAPKODU, Me.colPOZISYONNO, Me.colCIKISPOZISYONNO, Me.colFIREORANI, Me.colARACLINENO, Me.colURUNKODU, Me.colURUNADI, Me.colTUTAR, Me.colKOD})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(300, 209, 217, 348)
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", Me.colMIKTAR, "{0:#,0.00##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BIRIMMIKTAR", Me.colBIRIMMIKTAR, "{0:#,0.00##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ORAN", Me.colORAN, "{0:#,0.00##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", Me.colTUTAR, "{0:#,0.00##}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "STOKKODU", Me.colSTOKKODU, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FIREORANI", Me.colFIREORANI, "{0:#,0.00##}")})
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
        'colIND
        '
        Me.colIND.Caption = "Kayýt No"
        Me.colIND.FieldName = "IND"
        Me.colIND.Name = "colIND"
        '
        'colDETAY
        '
        Me.colDETAY.Caption = "Detay"
        Me.colDETAY.FieldName = "DETAY"
        Me.colDETAY.Name = "colDETAY"
        '
        'colSTOKNO
        '
        Me.colSTOKNO.Caption = "Stok No"
        Me.colSTOKNO.FieldName = "STOKNO"
        Me.colSTOKNO.Name = "colSTOKNO"
        '
        'colSTOKKODU
        '
        Me.colSTOKKODU.Caption = "Stok Kodu"
        Me.colSTOKKODU.FieldName = "STOKKODU"
        Me.colSTOKKODU.Name = "colSTOKKODU"
        Me.colSTOKKODU.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "STOKKODU", "{0} Kayýt")})
        Me.colSTOKKODU.Visible = True
        Me.colSTOKKODU.VisibleIndex = 1
        Me.colSTOKKODU.Width = 79
        '
        'colMALINCINSI
        '
        Me.colMALINCINSI.Caption = "Stok Adý"
        Me.colMALINCINSI.FieldName = "MALINCINSI"
        Me.colMALINCINSI.Name = "colMALINCINSI"
        Me.colMALINCINSI.Visible = True
        Me.colMALINCINSI.VisibleIndex = 2
        Me.colMALINCINSI.Width = 79
        '
        'colMIKTAR
        '
        Me.colMIKTAR.Caption = "Miktar"
        Me.colMIKTAR.DisplayFormat.FormatString = "#,0.00##"
        Me.colMIKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMIKTAR.FieldName = "MIKTAR"
        Me.colMIKTAR.Name = "colMIKTAR"
        Me.colMIKTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MIKTAR", "{0:#,0.00##}")})
        Me.colMIKTAR.Visible = True
        Me.colMIKTAR.VisibleIndex = 3
        Me.colMIKTAR.Width = 79
        '
        'colBIRIM
        '
        Me.colBIRIM.Caption = "Birim"
        Me.colBIRIM.FieldName = "BIRIM"
        Me.colBIRIM.Name = "colBIRIM"
        Me.colBIRIM.Visible = True
        Me.colBIRIM.VisibleIndex = 4
        Me.colBIRIM.Width = 79
        '
        'colBIRIMMIKTAR
        '
        Me.colBIRIMMIKTAR.Caption = "Birim Miktar"
        Me.colBIRIMMIKTAR.DisplayFormat.FormatString = "#,0.00##"
        Me.colBIRIMMIKTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBIRIMMIKTAR.FieldName = "BIRIMMIKTAR"
        Me.colBIRIMMIKTAR.Name = "colBIRIMMIKTAR"
        Me.colBIRIMMIKTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BIRIMMIKTAR", "{0:#,0.00##}")})
        Me.colBIRIMMIKTAR.Visible = True
        Me.colBIRIMMIKTAR.VisibleIndex = 5
        Me.colBIRIMMIKTAR.Width = 79
        '
        'colKDV
        '
        Me.colKDV.Caption = "Kdv"
        Me.colKDV.DisplayFormat.FormatString = "#,0"
        Me.colKDV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKDV.FieldName = "KDV"
        Me.colKDV.Name = "colKDV"
        Me.colKDV.Visible = True
        Me.colKDV.VisibleIndex = 6
        Me.colKDV.Width = 41
        '
        'colFIYAT
        '
        Me.colFIYAT.Caption = "Fiyat"
        Me.colFIYAT.DisplayFormat.FormatString = "#,0.00##"
        Me.colFIYAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT.FieldName = "FIYAT"
        Me.colFIYAT.Name = "colFIYAT"
        Me.colFIYAT.Visible = True
        Me.colFIYAT.VisibleIndex = 7
        Me.colFIYAT.Width = 65
        '
        'colBARCODE
        '
        Me.colBARCODE.Caption = "Barcode"
        Me.colBARCODE.FieldName = "BARCODE"
        Me.colBARCODE.Name = "colBARCODE"
        '
        'colISLEMTARIHI
        '
        Me.colISLEMTARIHI.Caption = "Ýþlem Tarihi"
        Me.colISLEMTARIHI.FieldName = "ISLEMTARIHI"
        Me.colISLEMTARIHI.Name = "colISLEMTARIHI"
        '
        'colSONERISIMTARIHI
        '
        Me.colSONERISIMTARIHI.Caption = "SonEriþimTarihi"
        Me.colSONERISIMTARIHI.FieldName = "SONERISIMTARIHI"
        Me.colSONERISIMTARIHI.Name = "colSONERISIMTARIHI"
        '
        'colKULLANICI
        '
        Me.colKULLANICI.Caption = "Kaydeden"
        Me.colKULLANICI.FieldName = "KULLANICI"
        Me.colKULLANICI.Name = "colKULLANICI"
        '
        'colORAN
        '
        Me.colORAN.Caption = "Oran"
        Me.colORAN.DisplayFormat.FormatString = "#,0.00##"
        Me.colORAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN.FieldName = "ORAN"
        Me.colORAN.Name = "colORAN"
        Me.colORAN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ORAN", "{0:#,0.00##}")})
        Me.colORAN.Visible = True
        Me.colORAN.VisibleIndex = 9
        Me.colORAN.Width = 103
        '
        'colTUR
        '
        Me.colTUR.Caption = "Tür"
        Me.colTUR.FieldName = "TUR"
        Me.colTUR.Name = "colTUR"
        '
        'colDEPOKODU
        '
        Me.colDEPOKODU.Caption = "DepoKodu"
        Me.colDEPOKODU.FieldName = "DEPOKODU"
        Me.colDEPOKODU.Name = "colDEPOKODU"
        Me.colDEPOKODU.Visible = True
        Me.colDEPOKODU.VisibleIndex = 10
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.Caption = "Açýklama"
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        '
        'colMALIYETTURU
        '
        Me.colMALIYETTURU.Caption = "MaliyetTürü"
        Me.colMALIYETTURU.FieldName = "MALIYETTURU"
        Me.colMALIYETTURU.Name = "colMALIYETTURU"
        '
        'colMIKTARTURU
        '
        Me.colMIKTARTURU.Caption = "MiktarTürü"
        Me.colMIKTARTURU.FieldName = "MIKTARTURU"
        Me.colMIKTARTURU.Name = "colMIKTARTURU"
        '
        'colURETIMCIKISHESAPKODU
        '
        Me.colURETIMCIKISHESAPKODU.Caption = "ÜretimÇýkýþHesapKodu"
        Me.colURETIMCIKISHESAPKODU.FieldName = "URETIMCIKISHESAPKODU"
        Me.colURETIMCIKISHESAPKODU.Name = "colURETIMCIKISHESAPKODU"
        '
        'colYANSITMAHESAPKODU
        '
        Me.colYANSITMAHESAPKODU.Caption = "YansýtmaHesapKodu"
        Me.colYANSITMAHESAPKODU.FieldName = "YANSITMAHESAPKODU"
        Me.colYANSITMAHESAPKODU.Name = "colYANSITMAHESAPKODU"
        '
        'colPOZISYONNO
        '
        Me.colPOZISYONNO.Caption = "PozisyonNo"
        Me.colPOZISYONNO.FieldName = "POZISYONNO"
        Me.colPOZISYONNO.Name = "colPOZISYONNO"
        '
        'colCIKISPOZISYONNO
        '
        Me.colCIKISPOZISYONNO.Caption = "ÇýkýþPozisyonNo"
        Me.colCIKISPOZISYONNO.FieldName = "CIKISPOZISYONNO"
        Me.colCIKISPOZISYONNO.Name = "colCIKISPOZISYONNO"
        '
        'colFIREORANI
        '
        Me.colFIREORANI.Caption = "Fire"
        Me.colFIREORANI.DisplayFormat.FormatString = "#,0.00##"
        Me.colFIREORANI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIREORANI.FieldName = "FIREORANI"
        Me.colFIREORANI.Name = "colFIREORANI"
        '
        'colARACLINENO
        '
        Me.colARACLINENO.Caption = "AraçNo"
        Me.colARACLINENO.FieldName = "ARACLINENO"
        Me.colARACLINENO.Name = "colARACLINENO"
        '
        'colURUNKODU
        '
        Me.colURUNKODU.Caption = "ÜrünKodu"
        Me.colURUNKODU.FieldName = "URUNKODU"
        Me.colURUNKODU.Name = "colURUNKODU"
        Me.colURUNKODU.Width = 79
        '
        'colURUNADI
        '
        Me.colURUNADI.Caption = "ÜrünAdý"
        Me.colURUNADI.FieldName = "URUNADI"
        Me.colURUNADI.Name = "colURUNADI"
        Me.colURUNADI.Visible = True
        Me.colURUNADI.VisibleIndex = 0
        Me.colURUNADI.Width = 79
        '
        'colTUTAR
        '
        Me.colTUTAR.Caption = "Tutar"
        Me.colTUTAR.DisplayFormat.FormatString = "#,0.00##"
        Me.colTUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTUTAR.FieldName = "TUTAR"
        Me.colTUTAR.Name = "colTUTAR"
        Me.colTUTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", "{0:#,0.00##}")})
        Me.colTUTAR.Visible = True
        Me.colTUTAR.VisibleIndex = 8
        Me.colTUTAR.Width = 87
        '
        'colKOD
        '
        Me.colKOD.Caption = "Pozisyon"
        Me.colKOD.FieldName = "KOD"
        Me.colKOD.Name = "colKOD"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem15, Me.MenuItem16, Me.MenuItem7, Me.MenuItem8, Me.MenuItem9, Me.MenuItem19, Me.MenuItem14, Me.MenuItem10, Me.MenuItem11, Me.MenuItem18, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem17})
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
        'MenuItem7
        '
        Me.MenuItem7.Index = 2
        Me.MenuItem7.Text = "Görünümü Düzenle"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 3
        Me.MenuItem8.Text = "Görünümü Kaydet"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 4
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem9.Text = "Görünümü Yazdýr"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 5
        Me.MenuItem19.Text = "Yazdýr"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 6
        Me.MenuItem14.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 7
        Me.MenuItem10.Text = "Filtrele"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 8
        Me.MenuItem11.Text = "Gruplandýr"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 9
        Me.MenuItem18.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 10
        Me.MenuItem1.Text = "Satýrlarý Aç"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 11
        Me.MenuItem2.Text = "Satýrlarý Kapat"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 12
        Me.MenuItem3.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 13
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"", "Üretim Reçeteleri Genel Hammadde Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"[User Name]", "Üretim Ýþlemleri", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_uretim_hammadde_liste
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_uretim_hammadde_liste"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hammadde Listesi"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
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
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public status As Boolean
    Public connection
    Public firmano
    Public donemno
    Public stokno
    Public userno
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
    Private Sub frm_stok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        If status = False Then
            count = ""
            Dim frm As New frm_stok_ara
            frm.connection = connection
            frm.firmano = firmano
            frm.donemno = donemno
            If frm.ShowDialog(Me) = DialogResult.OK Then
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
            If sil = False Then
                'sorgu()
            End If
        Else
        End If
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
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
    Private Sub ara()
        Dim frm As New frm_stok_ara
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        If frm.ShowDialog(Me) = DialogResult.OK Then
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
            Me.DialogResult = DialogResult.OK
        Else
            Me.DialogResult = DialogResult.Cancel
        End If
        System.GC.Collect()
        System.GC.GetTotalMemory(True)
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub dataload()
        'DataSet1.Clear()
        'DataSet1.Dispose()
        DataSet1 = stok()
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        'GridView1.SelectRow(0)
    End Sub
    Private Sub stok_yeni(Optional ByVal sBarkod As String = "")
        If KayitSiniri_kontrol("tbStok", "", nKayitSinir) = True Then
            Dim frm As New frm_stok_kart_kisa
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.sModel = ""
            frm.nStokID = 0
            frm.sKodu = ""
            frm.txt_sKodu.Text = sBarkod
            frm.txt_sBarkod.Text = sBarkod
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_stok_karti()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("IND")
            frm.sKodu = dr("STOKKODU")
            frm.sModel = dr("MODEL")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
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
        kriter = " WHERE (U.TUR IN (0, 2)) "
        If stokkodu <> "" Then
            kriter += " AND (S.STOKKODU " & sorgu_kriter_string(stokkodu, qstokkodu) & ")"
        End If
        If malincinsi <> "" Then
            kriter += " AND (S.MALINCINSI " & sorgu_kriter_string(malincinsi, qmalincinsi) & ")"
        End If
        If barkod <> "" Then
            kriter += " AND (TBLBIRIMLEREX.BARCODE " & sorgu_kriter_string(barkod, qbarkod) & ")"
        End If
        If birim <> "" Then
            kriter += " AND (TBLBIRIMLEREX.BIRIMADI " & sorgu_kriter_string(birim, qbirim) & ")"
        End If
        If kod1 <> "" Then
            kriter += " AND (S.KOD1 " & sorgu_kriter_string(kod1, qkod1) & " )"
        End If
        If kod2 <> "" Then
            kriter += " AND (S.KOD2 " & sorgu_kriter_string(kod2, qkod2) & ")"
        End If
        If kod3 <> "" Then
            kriter += " AND (S.KOD3 " & sorgu_kriter_string(kod3, qkod3) & ")"
        End If
        If kod4 <> "" Then
            kriter += " AND (S.KOD4 " & sorgu_kriter_string(kod4, qkod4) & ")"
        End If
        If kod5 <> "" Then
            kriter += " AND (S.KOD5 " & sorgu_kriter_string(kod5, qkod5) & ")"
        End If
        If kod6 <> "" Then
            kriter += " AND (S.KOD6 " & sorgu_kriter_string(kod6, qkod6) & ")"
        End If
        If kod7 <> "" Then
            kriter += " AND (S.KOD7 " & sorgu_kriter_string(kod7, qkod7) & ")"
        End If
        If kod8 <> "" Then
            kriter += " AND (S.KOD8 " & sorgu_kriter_string(kod8, qkod8) & ")"
        End If
        If kod9 <> "" Then
            kriter += " AND (S.KOD9 " & sorgu_kriter_string(kod9, qkod9) & ")"
        End If
        If kod10 <> "" Then
            kriter += " AND (S.KOD10 " & sorgu_kriter_string(kod10, qkod10) & ")"
        End If
        If istihbarat <> "" Then
            kriter += " AND (S.ISTIHBARAT " & sorgu_kriter_string(istihbarat, qistihbarat) & ")"
        End If
        If satisfiyati1 <> "" Then
            kriter += " AND (TBLBIRIMLEREX.SATISFIYATI1 " & sorgu_kriter_string(satisfiyati1, qsatisfiyati1) & ")"
        End If
        If satisfiyati2 <> "" Then
            kriter += " AND (TBLBIRIMLEREX.SATISFIYATI2 " & sorgu_kriter_string(satisfiyati2, qsatisfiyati2) & ")"
        End If
        If satisfiyati3 <> "" Then
            kriter += " AND (TBLBIRIMLEREX.SATISFIYATI3 " & sorgu_kriter_string(satisfiyati3, qsatisfiyati3) & ")"
        End If
        'If stokno <> "" Then
        '    kriter += " AND (U.STOKNO " & sorgu_kriter_string(stokno, "Eþittir") & ")"
        'End If
        If kayitno <> "" Then
            kriter += " AND (U.STOKNO " & sorgu_kriter_string(kayitno, qkayitno) & ")"
        End If
        If aktif <> "" Then
            kriter += " AND (S.STATUS " & sorgu_kriter_string(aktif, qaktif) & ")"
        End If
        If sil = True Then
            kriter += " AND S.IND NOT IN (SELECT STOKNO FROM TBLSTOKHAREKETLERI) "
        End If
        If gelismis <> "" Then
            kriter += " AND (S.STOKKODU " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (STK.MALINCINSI " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (TBLBIRIMLEREX.BARCODE " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (STK.KOD1 " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (STK.KOD2 " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (STK.KOD3 " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (STK.KOD4 " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (STK.KOD5 " & sorgu_kriter_string(gelismis, qgelismis) & ")"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  " & count & " STK.IND, STK.STOKKODU, STK.MALINCINSI, TBLBIRIMLEREX.BIRIMADI, STK.STOKTIPI, STK.STATUS, STK.KOD1, STK.KOD2, STK.KOD3, STK.KOD4, STK.KOD5, STK.KOD6, STK.KOD7, STK.KOD8, STK.KOD9, STK.KOD10, TBLBIRIMLEREX.CARPAN, TBLBIRIMLEREX.BARCODE, TBLBIRIMLEREX.BARCODESTD, TBLBIRIMLEREX.ACIKLAMA, ISNULL(TBLBIRIMLEREX.KDV,0) AS KDV, TBLBIRIMLEREX.SATISFIYATI1, TBLBIRIMLEREX.SATISFIYATI2, TBLBIRIMLEREX.SATISFIYATI3, TBLBIRIMLEREX.PB1, TBLBIRIMLEREX.PB2, TBLBIRIMLEREX.PB3, ISNULL(STK.ALISFIYATI,0) AS ALISFIYATI, ISNULL(STK.MALIYET,0) AS MALIYET, TBLBIRIMLEREX.IND AS BIRIMNO, TBLBIRIMLEREX.KDVDAHIL, (SELECT SUM(GIREN - CIKAN) FROM TBLSTOKHAREKETLERI WHERE STOKNO = STK.IND) AS ENVANTER FROM *!FTBLSTOKLAR STK INNER JOIN *!FTBLBIRIMLEREX TBLBIRIMLEREX ON STK.BIRIMEX = TBLBIRIMLEREX.IND AND STK.IND = TBLBIRIMLEREX.STOKNO  " & kriter & "   ORDER BY STK.STOKKODU")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " TBLRECETE.IND, TBLRECETE.STOKKODU, TBLRECETE.MALINCINSI, TBLRECETE.OZELKOD, TBLRECETE.SONERISIMTARIHI, TBLRECETE.STANDARTSURE, TBLRECETE.MIKTAR, STK.KOD1, STK.KOD2, STK.KOD3, STK.KOD4, STK.KOD5, STK.KOD6, STK.KOD7, STK.KOD8, STK.KOD9, STK.KOD10 FROM F0100TBLURERECETELIST TBLRECETE INNER JOIN F0100TBLSTOKLAR STK ON TBLRECETE.STOKNO = STK.IND INNER JOIN F0100TBLBIRIMLEREX TBLBIRIMLEREX ON STK.IND = TBLBIRIMLEREX.STOKNO AND STK.ANABIRIM = TBLBIRIMLEREX.IND " & kriter & " ORDER BY STK.STOKKODU")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT HAR.IND, HAR.DETAY, HAR.EVRAKNO, HAR.STOKNO, HAR.STOKKODU, HAR.MALINCINSI, HAR.MIKTAR, HAR.BIRIM, HAR.BIRIMMIKTAR, HAR.KDV, HAR.FIYAT, HAR.BARCODE, HAR.ISLEMTARIHI, HAR.SONERISIMTARIHI, HAR.KULLANICI, HAR.ORAN, HAR.TUR, DEPOLAR.DEPOKODU, HAR.ACIKLAMA, HAR.MALIYETTURU, HAR.MIKTARTURU, HAR.URETIMCIKISHESAPKODU, HAR.YANSITMAHESAPKODU, HAR.POZISYONNO, HAR.CIKISPOZISYONNO, HAR.FIREORANI, HAR.ARACLINENO, BAS.STOKKODU AS URUNKODU, BAS.MALINCINSI AS URUNADI, HAR.MIKTAR * HAR.FIYAT AS TUTAR, POZ.KOD FROM TBLURERECETEPOZ POZ INNER JOIN TBLURERECETE HAR ON POZ.EVRAKNO = HAR.EVRAKNO AND POZ.SIRANO = HAR.POZISYONNO RIGHT OUTER JOIN TBLURERECETELIST BAS ON HAR.EVRAKNO = BAS.IND LEFT OUTER JOIN TBLDEPOLAR DEPOLAR ON HAR.DEPONO = DEPOLAR.IND")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT HAR.IND, HAR.DETAY, HAR.EVRAKNO, HAR.STOKNO, HAR.STOKKODU, HAR.MALINCINSI, HAR.MIKTAR, HAR.BIRIM, HAR.BIRIMMIKTAR, HAR.KDV, HAR.FIYAT, HAR.BARCODE, HAR.ISLEMTARIHI, HAR.SONERISIMTARIHI, HAR.KULLANICI, HAR.ORAN, HAR.TUR, DEPOLAR.sDepo AS DEPOKODU, HAR.ACIKLAMA, HAR.MALIYETTURU, HAR.MIKTARTURU, HAR.URETIMCIKISHESAPKODU, HAR.YANSITMAHESAPKODU, HAR.POZISYONNO, HAR.CIKISPOZISYONNO, HAR.FIREORANI, HAR.ARACLINENO, BAS.STOKKODU AS URUNKODU, BAS.MALINCINSI AS URUNADI, HAR.MIKTAR * HAR.FIYAT AS TUTAR, POZ.KOD FROM TBLURERECETEPOZ POZ INNER JOIN TBLURERECETE HAR ON POZ.EVRAKNO = HAR.EVRAKNO AND POZ.SIRANO = HAR.POZISYONNO RIGHT OUTER JOIN TBLURERECETELIST BAS ON HAR.EVRAKNO = BAS.IND LEFT OUTER JOIN tbDepo DEPOLAR ON HAR.DEPONO = DEPOLAR.sDepo")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "tbHammadde")
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
        frm.stokno = dr("IND")
        frm.stokkodu = dr("STOKKODU")
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub analiz_stok_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("STOKKODU")
            frm.sec_giris.Text = "Giriþler"
            frm.kullanici = kullanici
            frm.islemstatus = True
            If yetki_kontrol(kullanici, frm.Name) = True Then
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub stok_fiyat()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_fiyatlandir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("IND")
            frm.sModel = dr("MODEL")
            frm.sKodu = dr("STOKKODU")
            'frm.sRenk = dr("sRenk")
            'frm.sBeden = dr("sBeden")
            frm.txt_musteriNo.Text = dr("MODEL")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
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
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_stok_karti()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stok_yeni()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
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
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_envanter()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stok_fiyat()
    End Sub
    Private Sub frm_stok_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.Hide()
        PanelControl1.Dispose()
        PanelControl2.Dispose()
        'PanelControl3.Dispose()
        SimpleButton1.Dispose()
        SimpleButton2.Dispose()
        SimpleButton3.Dispose()
        ContextMenu1.Dispose()
        PanelControl1 = Nothing
        PanelControl2 = Nothing
        'PanelControl3 = Nothing
        SimpleButton1 = Nothing
        SimpleButton2 = Nothing
        SimpleButton3 = Nothing
        ContextMenu1 = Nothing
        status = Nothing
        connection = Nothing
        firmano = Nothing
        donemno = Nothing
        stokno = Nothing
        userno = Nothing
        stokkodu = Nothing
        malincinsi = Nothing
        barkod = Nothing
        muadilbarkod = Nothing
        birim = Nothing
        kod1 = Nothing
        kod2 = Nothing
        kod3 = Nothing
        kod4 = Nothing
        kod5 = Nothing
        kod6 = Nothing
        kod7 = Nothing
        kod8 = Nothing
        kod9 = Nothing
        kod10 = Nothing
        satisfiyati1 = Nothing
        satisfiyati2 = Nothing
        satisfiyati3 = Nothing
        istihbarat = Nothing
        kayitno = Nothing
        qkayitno = Nothing
        qstokkodu = Nothing
        qmalincinsi = Nothing
        qbarkod = Nothing
        qmuadilbarkod = Nothing
        qkod1 = Nothing
        qkod2 = Nothing
        qkod3 = Nothing
        qkod4 = Nothing
        qkod5 = Nothing
        qkod6 = Nothing
        qkod7 = Nothing
        qkod8 = Nothing
        qkod9 = Nothing
        qkod10 = Nothing
        qistihbarat = Nothing
        qbirim = Nothing
        qdepo = Nothing
        qsatisfiyati1 = Nothing
        qsatisfiyati2 = Nothing
        qsatisfiyati3 = Nothing
        'XtraTabPage1.Dispose()
        'XtraTabPage1 = Nothing
        dr = Nothing
        count = Nothing
        ps.ClearContent()
        ps.Dispose()
        ps = Nothing
        printlink1.Dispose()
        printlink1 = Nothing
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
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
    End Sub
    Private Sub MenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        GridView1.CollapseAllGroups()
    End Sub
End Class
