Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_emir_kasa_genel
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
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txt_kod As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_kasiyer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents btn_baglan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMANO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMAKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMAADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSUBE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTARIH As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBORC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colALACAK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHAREKETNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHESAPNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHAREKETTIPI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKAYITTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDOVIZTUTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKUR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESKIBAKIYE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYENIBAKIYE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents colBAKIYE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_emir_kasa_genel))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRMANO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRMAKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRMAADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSUBE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTARIH = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBORC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colALACAK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHAREKETNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHESAPNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHAREKETTIPI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKAYITTARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDOVIZTUTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKUR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESKIBAKIYE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYENIBAKIYE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBAKIYE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label37 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.btn_baglan = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_kasiyer = New DevExpress.XtraEditors.TextEdit()
        Me.txt_kod = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kasiyer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(110, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Aþaðýda Genel Kasa Ýþlemlerinin Listesini Görmektesiniz..."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton4)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 381)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(8, 16)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton4.TabIndex = 8
        Me.SimpleButton4.Text = "&Yazdýr"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(736, 16)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(656, 16)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.PanelControl5)
        Me.PanelControl3.Controls.Add(Me.PanelControl4)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 325)
        Me.PanelControl3.TabIndex = 0
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.GridControl1)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl5.Location = New System.Drawing.Point(2, 57)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(820, 266)
        Me.PanelControl5.TabIndex = 1
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
        Me.GridControl1.Size = New System.Drawing.Size(816, 262)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem20, Me.MenuItem19, Me.MenuItem15, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7, Me.MenuItem8, Me.MenuItem16, Me.MenuItem2, Me.MenuItem9, Me.MenuItem10, Me.MenuItem17, Me.MenuItem11, Me.MenuItem12, Me.MenuItem18, Me.MenuItem13})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem1.Text = "Ara"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 1
        Me.MenuItem20.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 2
        Me.MenuItem19.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem21, Me.MenuItem22, Me.MenuItem23})
        Me.MenuItem19.Text = "Raporla"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 0
        Me.MenuItem21.Text = "Önizle"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 1
        Me.MenuItem22.Text = "Dizayn"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 2
        Me.MenuItem23.Text = "Yazdýr"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 3
        Me.MenuItem15.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Text = "Görünümü Düzenle"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 5
        Me.MenuItem6.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 6
        Me.MenuItem7.Text = "Görünümü Kaydet"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 7
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem8.Text = "Görünümü Yazdýr"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 8
        Me.MenuItem16.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 9
        Me.MenuItem2.Text = "Hýzlý Filtre"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 10
        Me.MenuItem9.Text = "Filtrele"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 11
        Me.MenuItem10.Text = "Gruplandýr"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 12
        Me.MenuItem17.Text = "-"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 13
        Me.MenuItem11.Text = "Satýrlarý Aç"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 14
        Me.MenuItem12.Text = "Satýrlarý Kapat"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 15
        Me.MenuItem18.Text = "-"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 16
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem13.Text = "Ekraný Kapla"
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
        Me.DataColumn1.ColumnName = "IND"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "FIRMANO"
        Me.DataColumn2.DataType = GetType(Long)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "FIRMAKODU"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "FIRMAADI"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "SUBE"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "TARIH"
        Me.DataColumn6.DataType = GetType(Date)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "BORC"
        Me.DataColumn7.DataType = GetType(Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "ALACAK"
        Me.DataColumn8.DataType = GetType(Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "ACIKLAMA"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "HAREKETNO"
        Me.DataColumn10.DataType = GetType(Long)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "HESAPNO"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "HAREKETTIPI"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "KAYITTARIHI"
        Me.DataColumn13.DataType = GetType(Date)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "PB"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "DOVIZTUTAR"
        Me.DataColumn15.DataType = GetType(Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "KUR"
        Me.DataColumn16.DataType = GetType(Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "KOD"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "ESKIBAKIYE"
        Me.DataColumn18.DataType = GetType(Decimal)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "YENIBAKIYE"
        Me.DataColumn19.DataType = GetType(Decimal)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "BAKIYE"
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
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.colFIRMANO, Me.colFIRMAKODU, Me.colFIRMAADI, Me.colSUBE, Me.colTARIH, Me.colBORC, Me.colALACAK, Me.colACIKLAMA, Me.colHAREKETNO, Me.colHESAPNO, Me.colHAREKETTIPI, Me.colKAYITTARIHI, Me.colPB, Me.colDOVIZTUTAR, Me.colKUR, Me.colKOD, Me.colESKIBAKIYE, Me.colYENIBAKIYE, Me.colBAKIYE})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(397, 197, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TARIH", Me.colTARIH, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BORC", Me.colBORC, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ALACAK", Me.colALACAK, "{0:#,0.00}")})
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
        Me.colIND.Width = 49
        '
        'colFIRMANO
        '
        Me.colFIRMANO.Caption = "Firma No"
        Me.colFIRMANO.FieldName = "FIRMANO"
        Me.colFIRMANO.Name = "colFIRMANO"
        '
        'colFIRMAKODU
        '
        Me.colFIRMAKODU.Caption = "Firma Kodu"
        Me.colFIRMAKODU.FieldName = "FIRMAKODU"
        Me.colFIRMAKODU.Name = "colFIRMAKODU"
        Me.colFIRMAKODU.Visible = True
        Me.colFIRMAKODU.VisibleIndex = 1
        Me.colFIRMAKODU.Width = 47
        '
        'colFIRMAADI
        '
        Me.colFIRMAADI.Caption = "Firma Adý"
        Me.colFIRMAADI.FieldName = "FIRMAADI"
        Me.colFIRMAADI.Name = "colFIRMAADI"
        Me.colFIRMAADI.Visible = True
        Me.colFIRMAADI.VisibleIndex = 2
        Me.colFIRMAADI.Width = 116
        '
        'colSUBE
        '
        Me.colSUBE.Caption = "Þube"
        Me.colSUBE.FieldName = "SUBE"
        Me.colSUBE.Name = "colSUBE"
        '
        'colTARIH
        '
        Me.colTARIH.Caption = "Tarih"
        Me.colTARIH.FieldName = "TARIH"
        Me.colTARIH.Name = "colTARIH"
        Me.colTARIH.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TARIH", "{0} Kayýt")})
        Me.colTARIH.Visible = True
        Me.colTARIH.VisibleIndex = 0
        Me.colTARIH.Width = 52
        '
        'colBORC
        '
        Me.colBORC.Caption = "Giren"
        Me.colBORC.DisplayFormat.FormatString = "#,0.00"
        Me.colBORC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBORC.FieldName = "BORC"
        Me.colBORC.Name = "colBORC"
        Me.colBORC.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BORC", "{0:#,0.00}")})
        Me.colBORC.Visible = True
        Me.colBORC.VisibleIndex = 3
        Me.colBORC.Width = 47
        '
        'colALACAK
        '
        Me.colALACAK.Caption = "Çýkan"
        Me.colALACAK.DisplayFormat.FormatString = "#,0.00"
        Me.colALACAK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colALACAK.FieldName = "ALACAK"
        Me.colALACAK.Name = "colALACAK"
        Me.colALACAK.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ALACAK", "{0:#,0.00}")})
        Me.colALACAK.Visible = True
        Me.colALACAK.VisibleIndex = 4
        Me.colALACAK.Width = 49
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.Caption = "Açýklama"
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 5
        Me.colACIKLAMA.Width = 183
        '
        'colHAREKETNO
        '
        Me.colHAREKETNO.Caption = "Hareket No"
        Me.colHAREKETNO.FieldName = "HAREKETNO"
        Me.colHAREKETNO.Name = "colHAREKETNO"
        '
        'colHESAPNO
        '
        Me.colHESAPNO.Caption = "Hesap No"
        Me.colHESAPNO.FieldName = "HESAPNO"
        Me.colHESAPNO.Name = "colHESAPNO"
        '
        'colHAREKETTIPI
        '
        Me.colHAREKETTIPI.Caption = "Hareket Tipi"
        Me.colHAREKETTIPI.FieldName = "HAREKETTIPI"
        Me.colHAREKETTIPI.Name = "colHAREKETTIPI"
        '
        'colKAYITTARIHI
        '
        Me.colKAYITTARIHI.Caption = "Saat"
        Me.colKAYITTARIHI.DisplayFormat.FormatString = "hh:mm"
        Me.colKAYITTARIHI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colKAYITTARIHI.FieldName = "KAYITTARIHI"
        Me.colKAYITTARIHI.Name = "colKAYITTARIHI"
        Me.colKAYITTARIHI.Visible = True
        Me.colKAYITTARIHI.VisibleIndex = 7
        Me.colKAYITTARIHI.Width = 33
        '
        'colPB
        '
        Me.colPB.Caption = "Pb"
        Me.colPB.FieldName = "PB"
        Me.colPB.Name = "colPB"
        '
        'colDOVIZTUTAR
        '
        Me.colDOVIZTUTAR.Caption = "Döviz Tutar"
        Me.colDOVIZTUTAR.DisplayFormat.FormatString = "#,0.00"
        Me.colDOVIZTUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDOVIZTUTAR.FieldName = "DOVIZTUTAR"
        Me.colDOVIZTUTAR.Name = "colDOVIZTUTAR"
        Me.colDOVIZTUTAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "DOVIZTUTAR", "{0:#,0.00}")})
        '
        'colKUR
        '
        Me.colKUR.Caption = "Kur"
        Me.colKUR.DisplayFormat.FormatString = "#,0.00"
        Me.colKUR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKUR.FieldName = "KUR"
        Me.colKUR.Name = "colKUR"
        '
        'colKOD
        '
        Me.colKOD.Caption = "Kodlama"
        Me.colKOD.FieldName = "KOD"
        Me.colKOD.Name = "colKOD"
        '
        'colESKIBAKIYE
        '
        Me.colESKIBAKIYE.Caption = "Eski Bakiye"
        Me.colESKIBAKIYE.DisplayFormat.FormatString = "{0:#,#0.00(B);#,#0.00(A);-}"
        Me.colESKIBAKIYE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colESKIBAKIYE.FieldName = "ESKIBAKIYE"
        Me.colESKIBAKIYE.Name = "colESKIBAKIYE"
        Me.colESKIBAKIYE.Width = 63
        '
        'colYENIBAKIYE
        '
        Me.colYENIBAKIYE.Caption = "Yeni Bakiye"
        Me.colYENIBAKIYE.DisplayFormat.FormatString = "{0:#,#0.00(B);#,#0.00(A);-}"
        Me.colYENIBAKIYE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colYENIBAKIYE.FieldName = "YENIBAKIYE"
        Me.colYENIBAKIYE.Name = "colYENIBAKIYE"
        Me.colYENIBAKIYE.Width = 54
        '
        'colBAKIYE
        '
        Me.colBAKIYE.Caption = "Bakiye"
        Me.colBAKIYE.DisplayFormat.FormatString = "{0:#,#0.00(B);#,#0.00(A);-}"
        Me.colBAKIYE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBAKIYE.FieldName = "BAKIYE"
        Me.colBAKIYE.Name = "colBAKIYE"
        Me.colBAKIYE.Visible = True
        Me.colBAKIYE.VisibleIndex = 6
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.SimpleButton5)
        Me.PanelControl4.Controls.Add(Me.Label37)
        Me.PanelControl4.Controls.Add(Me.DateEdit2)
        Me.PanelControl4.Controls.Add(Me.DateEdit1)
        Me.PanelControl4.Controls.Add(Me.btn_baglan)
        Me.PanelControl4.Controls.Add(Me.txt_kasiyer)
        Me.PanelControl4.Controls.Add(Me.txt_kod)
        Me.PanelControl4.Controls.Add(Me.Label2)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(820, 55)
        Me.PanelControl4.TabIndex = 0
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Enabled = False
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(383, 30)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(232, 23)
        Me.SimpleButton5.TabIndex = 15
        Me.SimpleButton5.Text = "&Oku"
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(488, 8)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(12, 13)
        Me.Label37.TabIndex = 14
        Me.Label37.Text = "ve"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.Enabled = False
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(512, 8)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit2.TabIndex = 13
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Enabled = False
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(384, 8)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit1.TabIndex = 12
        '
        'btn_baglan
        '
        Me.btn_baglan.Location = New System.Drawing.Point(64, 30)
        Me.btn_baglan.Name = "btn_baglan"
        Me.btn_baglan.Size = New System.Drawing.Size(296, 23)
        Me.btn_baglan.TabIndex = 11
        Me.btn_baglan.Text = "&Baðlan"
        '
        'txt_kasiyer
        '
        Me.txt_kasiyer.Enabled = False
        Me.txt_kasiyer.EnterMoveNextControl = True
        Me.txt_kasiyer.Location = New System.Drawing.Point(167, 8)
        Me.txt_kasiyer.Name = "txt_kasiyer"
        Me.txt_kasiyer.Properties.MaxLength = 10
        Me.txt_kasiyer.Size = New System.Drawing.Size(193, 20)
        Me.txt_kasiyer.TabIndex = 10
        '
        'txt_kod
        '
        Me.txt_kod.Location = New System.Drawing.Point(64, 8)
        Me.txt_kod.Name = "txt_kod"
        Me.txt_kod.Properties.MaxLength = 10
        Me.txt_kod.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_kod.Size = New System.Drawing.Size(104, 20)
        Me.txt_kod.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Kasiyer:"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Genel Kasa Ýþlemleri", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Ýþ Emirleri", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_emir_kasa_genel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_emir_kasa_genel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Genel Kasa"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kasiyer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public connection
    Public firmano
    Public donemno
    Public kasiyerno
    Public kasiyer
    Public kullanici
    Dim ds_kasiyer As DataSet
    Dim ds_satici As DataSet
    Dim ds_fiyattipi As DataSet
    Dim dr As DataRow
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Public status As Boolean = False
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub frm_kasiyer_stok_fiyatlandir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'connection = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("UGURLU")
        'If connection = "" Then
        '    connection = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=BARKOD;Data Source=(local)"
        '    Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("Fast Reports").CreateSubKey("connections").SetValue("UGURLU", connection)
        'End If
        firmano = 100
        donemno = 1
        DateEdit1.EditValue = dteSistemTarihi
        DateEdit2.EditValue = dteSistemTarihi
        dataload_kasiyer()
        dataload_satici()
        dataload_fiyattipi()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        GridControl1.Enabled = False
    End Sub
    Private Sub dataload_kasiyer()
        ds_kasiyer = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sKasiyerRumuzu AS IND, sAdi + ' ' + sSoyadi AS KASIYER, sSifresi AS SIFRE, sDepo AS DEPO FROM         tbKasiyer WHERE     (sKasiyerRumuzu <> '')"))
    End Sub
    Private Sub dataload_satici()
        ds_satici = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu AS IND, sAdi + ' ' + sSoyadi AS SATICI  FROM         tbSatici WHERE     (sSaticiRumuzu <> '') and (bAktif = 1)"))
    End Sub
    Private Sub dataload_fiyattipi()
        ds_fiyattipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFiyatTipi, sAciklama FROM         tbFiyatTipi WHERE     (sFiyatTipi IN ('6 AY', '10AY', 'PS', 'HD')) ORDER BY sFiyatTipi DESC"))
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\ISEMIRLERI\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim itm
        For Each itm In ContextMenu1.MenuItems
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton4.Text = Sorgu_sDil(SimpleButton4.Text, sDil)
        SimpleButton5.Text = Sorgu_sDil(SimpleButton5.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\ISEMIRLERI\" & Me.Name.ToString & "")
    End Sub
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal kasiyerno As String)
        Dim kriter As String = ""
        kriter += " WHERE (tbNakitKasa.dteIslemTarihi  between '" & tarih1 & "' and '" & tarih2 & "' ) "
        If Trim(kasiyerno) = "VC" Then
        Else
            kriter += " AND tbNakitKasa.sKullaniciAdi ='" & kasiyerno & "' "
        End If
        DataSet1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID AS FIRMANO, rtrim(ltrim(tbFirma.sKodu)) AS FIRMAKODU, tbFirma.sAciklama AS FIRMAADI, tbNakitKasa.nKasaIslemID AS IND, tbNakitKasa.sSube AS SUBE, tbNakitKasa.dteIslemTarihi AS TARIH, tbNakitKasa.lTahsilTutar AS BORC, tbNakitKasa.lTediyeTutar AS ALACAK, tbNakitKasa.sAciklama AS ACIKLAMA, tbNakitKasa.nCariHareketID AS HAREKETNO, tbNakitKasa.nHesapID AS HESAPNO, tbNakitKasa.sHareketTipi AS HAREKETTIPI, tbNakitKasa.dteKayitTarihi AS KAYITTARIHI, tbNakitKasa.sDovizCinsi1 AS PB, tbNakitKasa.lDovizMiktari1 AS DOVIZTUTAR, tbNakitKasa.lDovizKuru1 AS KUR, SUBSTRING(tbFirma.sKodu, 1, 3) AS KOD, (SELECT SUM(lBorcTutar - lAlacakTutar) FROM tbFirmaHareketi WHERE nFirmaID = tbNakitKasa.nFirmaID) AS BAKIYE FROM tbNakitKasa INNER JOIN tbFirma ON tbNakitKasa.nFirmaID = tbFirma.nFirmaID " & kriter & " ORDER BY SUBSTRING(tbFirma.sKodu, 1, 3),tbFirma.sKodu"))
        'DataSet1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID AS FIRMANO, rtrim(ltrim(tbFirma.sKodu)) AS FIRMAKODU, tbFirma.sAciklama AS FIRMAADI, tbNakitKasa.nKasaIslemID AS IND, tbNakitKasa.sSube AS SUBE, tbNakitKasa.dteIslemTarihi AS TARIH, tbNakitKasa.lTahsilTutar AS BORC, tbNakitKasa.lTediyeTutar AS ALACAK, tbNakitKasa.sAciklama AS ACIKLAMA, tbNakitKasa.nCariHareketID AS HAREKETNO, tbNakitKasa.nHesapID AS HESAPNO, tbNakitKasa.sHareketTipi AS HAREKETTIPI, tbNakitKasa.dteKayitTarihi AS KAYITTARIHI, tbNakitKasa.sDovizCinsi1 AS PB, tbNakitKasa.lDovizMiktari1 AS DOVIZTUTAR, tbNakitKasa.lDovizKuru1 AS KUR, SUBSTRING(tbFirma.sKodu, 1, 3) AS KOD, (SELECT SUM(lBorcTutar - lAlacakTutar) FROM tbFirmaHareketi WHERE nFirmaID = tbNakitKasa.nFirmaID) AS BAKIYE, (SELECT SUM(lBorcTutar - lAlacakTutar) FROM tbFirmaHareketi WHERE nFirmaID = tbNakitKasa.nFirmaID AND nHareketID < tbNakitKasa.nCariHareketID) AS ESKIBAKIYE, (SELECT SUM(lBorcTutar - lAlacakTutar) FROM tbFirmaHareketi WHERE nFirmaID = tbNakitKasa.nFirmaID AND nHareketID <= tbNakitKasa.nCariHareketID) AS YENIBAKIYE FROM tbNakitKasa INNER JOIN tbFirma ON tbNakitKasa.nFirmaID = tbFirma.nFirmaID " & kriter & " ORDER BY SUBSTRING(tbFirma.sKodu, 1, 3),tbFirma.sKodu"))
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Select()
        GridControl1.Focus()
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_baglan.Click
        If btn_baglan.Text = "Baðlan" Then
            kasiyer_kontrol()
        ElseIf btn_baglan.Text = "Baðlantýyý Kes" Then
            Dim sayi As Int64 = 0
            'sayi = kayit_kontrol()
            If sayi = 0 Then
                txt_kasiyer.EditValue = ""
                txt_kod.Enabled = True
                txt_kod.EditValue = ""
                GridControl1.Enabled = False
                DateEdit1.Enabled = False
                DateEdit2.Enabled = False
                SimpleButton5.Enabled = False
                DataSet1.Clear()
                txt_kod.Focus()
                txt_kod.SelectAll()
            ElseIf sayi = 1 Then
                XtraMessageBox.Show(Sorgu_sDil("Bekleyen Ýþlemleriniz Var...Lütfen Bekleyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub kasiyer_kontrol()
        Dim sonuc As Boolean = False
        For Each dr In ds_kasiyer.Tables(0).Rows
            If dr("SIFRE") = txt_kod.Text Then
                kasiyerno = dr("IND")
                kasiyer = dr("KASIYER")
                sonuc = True
            End If
        Next
        If sonuc = True Then
            txt_kasiyer.EditValue = kasiyer
            txt_kod.Enabled = False
            GridControl1.Enabled = True
            btn_baglan.Text = "Baðlantýyý Kes"
            DateEdit1.Enabled = True
            DateEdit2.Enabled = True
            SimpleButton5.Enabled = True
            DateEdit1.Select()
            DateEdit1.SelectAll()
            'dataload(Today, kasiyerno)
            status = True
        ElseIf sonuc = False Then
            txt_kasiyer.EditValue = ""
            txt_kod.Enabled = True
            txt_kod.EditValue = ""
            'txt_kasiyer.Enabled = True
            DateEdit1.Enabled = True
            DateEdit2.Enabled = True
            SimpleButton5.Enabled = True
            GridControl1.Enabled = False
            btn_baglan.Text = "Baðlan"
            txt_kod.Focus()
            txt_kod.SelectAll()
            status = False
            XtraMessageBox.Show(Sorgu_sDil("Þifre Hatalý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ekle()
        If status = True And Trim(kasiyerno) <> "" Then
            Dim frm As New frm_kasiyer_stok_fiyatlandir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kasiyerno = kasiyerno
            frm.kasiyer = kasiyer
            frm.ds_satici = ds_satici
            frm.ds_fiyattipi = ds_fiyattipi
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.Show()
            End If
        End If
    End Sub
    Private Sub duzelt_fiyat(ByVal stokno As Int64, ByVal fiyattipi As String, ByVal fiyat As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFiyati SET              lFiyat =" & fiyat & " where nStokID =" & stokno & " AND sFiyatTipi ='" & fiyattipi & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub duzelt2(ByVal ind As Int64, ByVal sonuc As String, ByVal status As Integer, ByVal aciklama As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    AEMIRKASIYERSTOKFIYAT SET              Sonuc = '" & sonuc & "', Status = " & status & ", Aciklama = '" & aciklama & "',DegisimTarihi = getdate() WHERE IND =" & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub txt_kod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_kod.KeyDown
        If e.KeyCode = Keys.Enter Then
            kasiyer_kontrol()
        End If
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ekle()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Dim label As String
        label = DateEdit1.EditValue.ToString.Substring(0, 10) & " ve " & DateEdit2.EditValue.ToString.Substring(0, 10) & " Tarihleri Arasýndaki Genel Kasa Ýþlemleri Analizi Aþaðýdadýr..."
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", label, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Cari Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
        label = Nothing
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ekle()
    End Sub
    Private Sub SimpleButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If btn_baglan.Text = "Baðlantýyý Kes" Then
            dataload(DateEdit1.EditValue, DateEdit2.EditValue, kasiyerno)
        End If
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If MenuItem9.Checked = False Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem9.Checked = True
        ElseIf MenuItem9.Checked = True Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem9.Checked = False
        End If
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        If MenuItem10.Checked = False Then
            GridView1.OptionsView.ShowGroupPanel = True
            GridView1.OptionsCustomization.AllowGroup = True
            MenuItem10.Checked = True
        ElseIf MenuItem10.Checked = True Then
            GridView1.OptionsView.ShowGroupPanel = False
            GridView1.OptionsCustomization.AllowGroup = False
            MenuItem10.Checked = False
        End If
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub frm_kasiyer_stok_fiyatlandir_liste_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Me.Hide()
        'PanelControl1 = Nothing
        'PanelControl2 = Nothing
        'PanelControl3 = Nothing
        'PanelControl4 = Nothing
        'PanelControl5 = Nothing
        'GridControl1 = Nothing
        'GridView1 = Nothing
        'txt_kod = Nothing
        'txt_kasiyer = Nothing
        'DataSet1 = Nothing
        'DataTable1 = Nothing
        'ContextMenu1 = Nothing
        'MenuItem1 = Nothing
        'MenuItem20 = Nothing
        'MenuItem19 = Nothing
        'MenuItem21 = Nothing
        'MenuItem22 = Nothing
        'MenuItem23 = Nothing
        'MenuItem15 = Nothing
        'MenuItem5 = Nothing
        'MenuItem6 = Nothing
        'MenuItem7 = Nothing
        'MenuItem8 = Nothing
        'MenuItem16 = Nothing
        'MenuItem9 = Nothing
        'MenuItem10 = Nothing
        'MenuItem17 = Nothing
        'MenuItem11 = Nothing
        'MenuItem12 = Nothing
        'MenuItem18 = Nothing
        'MenuItem13 = Nothing
        'btn_baglan = Nothing
        'Label1 = Nothing
        'PictureBox1 = Nothing
        'Label2 = Nothing
        'ps = Nothing
        'printlink1 = Nothing
        'SimpleButton2 = Nothing
        'SimpleButton1 = Nothing
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
        'colIND = Nothing
        'colFIRMANO = Nothing
        'colFIRMAKODU = Nothing
        'colFIRMAADI = Nothing
        'colSUBE = Nothing
        'colTARIH = Nothing
        'colBORC = Nothing
        'colALACAK = Nothing
        'colACIKLAMA = Nothing
        'colHAREKETNO = Nothing
        'colHESAPNO = Nothing
        'colHAREKETTIPI = Nothing
        'colKAYITTARIHI = Nothing
        'colPB = Nothing
        'colDOVIZTUTAR = Nothing
        'colKUR = Nothing
        'colKOD = Nothing
        'colESKIBAKIYE = Nothing
        'colYENIBAKIYE = Nothing
        'DataColumn20 = Nothing
        'colBAKIYE = Nothing
        'DateEdit1 = Nothing
        'DateEdit2 = Nothing
        'Label37 = Nothing
        'SimpleButton5 = Nothing
        'SimpleButton4 = Nothing
        'Me.Close()
        'Me.Dispose()
        System.GC.Collect()
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Function kayit_kontrol() As Int64
        Dim sayi As Integer = 0
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, kasiyerno)
        For Each dr In DataSet1.Tables(0).Rows
            'If dr(sorgu_sDil("Dikkat",sDil)) = "Bekliyor..." Then
            '    sayi = 1
            'End If
        Next
        Return sayi
        sayi = Nothing
    End Function
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Trim(kasiyerno) = "VC" Then
                If XtraMessageBox.Show(dr("StokKodu") & Sorgu_sDil("  Kodlu Stoðun Fiyatýný Eski Fiyatý Ýle Deðiþtirmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    duzelt_fiyat(dr("StokNo"), dr("FiyatTipi"), dr("eFiyat"))
                    duzelt2(dr("IND"), Sorgu_sDil("Tamamlandý...", sDil), 1, "Fiyat Deðiþim Emri")
                    XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dataload(DateEdit1.EditValue, DateEdit2.EditValue, kasiyerno)
                End If
            ElseIf Trim(kasiyerno) = "YÖ" Or Trim(kasiyerno) = "MB" Then
                If XtraMessageBox.Show(dr("StokKodu") & Sorgu_sDil("  Kodlu Stoðun Fiyatýný Eski Fiyatý Ýle Deðiþtirmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    duzelt_fiyat(dr("StokNo"), dr("FiyatTipi"), dr("eFiyat"))
                    duzelt2(dr("IND"), Sorgu_sDil("Tamamlandý...", sDil), 1, "Fiyat Deðiþim Emri")
                    XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dataload(DateEdit1.EditValue, DateEdit2.EditValue, kasiyerno)
                End If
            Else
                XtraMessageBox.Show(Sorgu_sDil("Yetkiniz Yok...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, kasiyerno)
    End Sub
    Private Sub SimpleButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub MenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        GridView1.OptionsView.ShowAutoFilterRow = True
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView1.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Genel Kasa Ekranýný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
End Class
