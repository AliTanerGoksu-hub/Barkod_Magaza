Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_stok_envanter
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
    Friend WithEvents Panel1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel3 As DevExpress.XtraEditors.PanelControl
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
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGIREN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCIKAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKALAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents colMEVCUT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents colBEKLEYEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents colServiste As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Siparis_Verilen As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_Siparis_Alinan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_sServiste As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_sRenk As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_sAciklama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_sKodu As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dteFisTarihi As DevExpress.XtraEditors.DateEdit
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_musteriNo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lbl_ara As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_resmi1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_resmi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_envanter))
        Me.Panel1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.Label9 = New DevExpress.XtraEditors.LabelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_Siparis_Verilen = New DevExpress.XtraEditors.LabelControl()
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
        Me.lbl_Siparis_Alinan = New DevExpress.XtraEditors.LabelControl()
        Me.Label10 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_sServiste = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_sRenk = New DevExpress.XtraEditors.LabelControl()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_sAciklama = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_sKodu = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New DevExpress.XtraEditors.PanelControl()
        Me.sec_resmi1 = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_resmi = New DevExpress.XtraEditors.CheckEdit()
        Me.lbl_ara = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_musteriNo = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dteFisTarihi = New DevExpress.XtraEditors.DateEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel3 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGIREN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCIKAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKALAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMEVCUT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBEKLEYEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colServiste = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.sec_resmi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_resmi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteFisTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dteFisTarihi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbl_Siparis_Verilen)
        Me.Panel1.Controls.Add(Me.lbl_Siparis_Alinan)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lbl_sServiste)
        Me.Panel1.Controls.Add(Me.lbl_sRenk)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lbl_sAciklama)
        Me.Panel1.Controls.Add(Me.lbl_sKodu)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(826, 56)
        Me.Panel1.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(568, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Serviste:"
        '
        'Label9
        '
        Me.Label9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.Location = New System.Drawing.Point(568, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Alýnan Sipariþ:"
        '
        'Label2
        '
        Me.Label2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Stok Adý:"
        '
        'lbl_Siparis_Verilen
        '
        Me.lbl_Siparis_Verilen.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_Siparis_Verilen.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_Siparis_Verilen.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "Table1.STOKADI", True))
        Me.lbl_Siparis_Verilen.Location = New System.Drawing.Point(663, 32)
        Me.lbl_Siparis_Verilen.Name = "lbl_Siparis_Verilen"
        Me.lbl_Siparis_Verilen.Size = New System.Drawing.Size(7, 13)
        Me.lbl_Siparis_Verilen.TabIndex = 25
        Me.lbl_Siparis_Verilen.Text = "*"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8})
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
        Me.DataColumn6.ColumnName = "STOKKODU"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "STOKADI"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "BEKLEYEN"
        Me.DataColumn8.DataType = GetType(Decimal)
        '
        'lbl_Siparis_Alinan
        '
        Me.lbl_Siparis_Alinan.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_Siparis_Alinan.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_Siparis_Alinan.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "Table1.STOKADI", True))
        Me.lbl_Siparis_Alinan.Location = New System.Drawing.Point(663, 19)
        Me.lbl_Siparis_Alinan.Name = "lbl_Siparis_Alinan"
        Me.lbl_Siparis_Alinan.Size = New System.Drawing.Size(7, 13)
        Me.lbl_Siparis_Alinan.TabIndex = 24
        Me.lbl_Siparis_Alinan.Text = "*"
        '
        'Label10
        '
        Me.Label10.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.Location = New System.Drawing.Point(568, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Verilen Sipariþ:"
        '
        'lbl_sServiste
        '
        Me.lbl_sServiste.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_sServiste.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_sServiste.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "Table1.STOKADI", True))
        Me.lbl_sServiste.Location = New System.Drawing.Point(663, 3)
        Me.lbl_sServiste.Name = "lbl_sServiste"
        Me.lbl_sServiste.Size = New System.Drawing.Size(7, 13)
        Me.lbl_sServiste.TabIndex = 21
        Me.lbl_sServiste.Text = "*"
        '
        'lbl_sRenk
        '
        Me.lbl_sRenk.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_sRenk.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_sRenk.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "Table1.STOKADI", True))
        Me.lbl_sRenk.Location = New System.Drawing.Point(211, 32)
        Me.lbl_sRenk.Name = "lbl_sRenk"
        Me.lbl_sRenk.Size = New System.Drawing.Size(7, 13)
        Me.lbl_sRenk.TabIndex = 19
        Me.lbl_sRenk.Text = "*"
        '
        'Label5
        '
        Me.Label5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.Location = New System.Drawing.Point(116, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Renk:"
        '
        'lbl_sAciklama
        '
        Me.lbl_sAciklama.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_sAciklama.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_sAciklama.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "Table1.STOKADI", True))
        Me.lbl_sAciklama.Location = New System.Drawing.Point(211, 19)
        Me.lbl_sAciklama.Name = "lbl_sAciklama"
        Me.lbl_sAciklama.Size = New System.Drawing.Size(7, 13)
        Me.lbl_sAciklama.TabIndex = 17
        Me.lbl_sAciklama.Text = "*"
        '
        'lbl_sKodu
        '
        Me.lbl_sKodu.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_sKodu.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_sKodu.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "Table1.STOKKODU", True))
        Me.lbl_sKodu.Location = New System.Drawing.Point(211, 3)
        Me.lbl_sKodu.Name = "lbl_sKodu"
        Me.lbl_sKodu.Size = New System.Drawing.Size(7, 13)
        Me.lbl_sKodu.TabIndex = 16
        Me.lbl_sKodu.Text = "*"
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(116, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Stok Kodu:"
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(96, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.sec_resmi1)
        Me.Panel2.Controls.Add(Me.sec_resmi)
        Me.Panel2.Controls.Add(Me.lbl_ara)
        Me.Panel2.Controls.Add(Me.LabelControl8)
        Me.Panel2.Controls.Add(Me.txt_musteriNo)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txt_dteFisTarihi)
        Me.Panel2.Controls.Add(Me.SimpleButton2)
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 369)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(826, 40)
        Me.Panel2.TabIndex = 1
        '
        'sec_resmi1
        '
        Me.sec_resmi1.Enabled = False
        Me.sec_resmi1.Location = New System.Drawing.Point(525, 11)
        Me.sec_resmi1.Name = "sec_resmi1"
        Me.sec_resmi1.Properties.Caption = "R1"
        Me.sec_resmi1.Size = New System.Drawing.Size(48, 19)
        Me.sec_resmi1.TabIndex = 75
        '
        'sec_resmi
        '
        Me.sec_resmi.Location = New System.Drawing.Point(487, 11)
        Me.sec_resmi.Name = "sec_resmi"
        Me.sec_resmi.Properties.Caption = "R"
        Me.sec_resmi.Size = New System.Drawing.Size(32, 19)
        Me.sec_resmi.TabIndex = 74
        '
        'lbl_ara
        '
        Me.lbl_ara.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_ara.Location = New System.Drawing.Point(44, 16)
        Me.lbl_ara.Name = "lbl_ara"
        Me.lbl_ara.Size = New System.Drawing.Size(6, 11)
        Me.lbl_ara.TabIndex = 73
        Me.lbl_ara.Text = "*"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.Location = New System.Drawing.Point(6, 11)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl8.TabIndex = 72
        Me.LabelControl8.Text = "Model:"
        '
        'txt_musteriNo
        '
        Me.txt_musteriNo.Location = New System.Drawing.Point(61, 11)
        Me.txt_musteriNo.Name = "txt_musteriNo"
        Me.txt_musteriNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_musteriNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_musteriNo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_musteriNo.Properties.Appearance.Options.UseForeColor = True
        Me.txt_musteriNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_musteriNo.Size = New System.Drawing.Size(157, 20)
        Me.txt_musteriNo.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(239, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Tarih:"
        '
        'txt_dteFisTarihi
        '
        Me.txt_dteFisTarihi.EditValue = Nothing
        Me.txt_dteFisTarihi.Location = New System.Drawing.Point(286, 11)
        Me.txt_dteFisTarihi.MenuManager = Me.BarManager1
        Me.txt_dteFisTarihi.Name = "txt_dteFisTarihi"
        Me.txt_dteFisTarihi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dteFisTarihi.Properties.Appearance.Options.UseBackColor = True
        Me.txt_dteFisTarihi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_dteFisTarihi.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_dteFisTarihi.Size = New System.Drawing.Size(170, 20)
        Me.txt_dteFisTarihi.TabIndex = 1
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8})
        Me.BarManager1.MaxItemId = 8
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Ara,F3"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.BarButtonItem7.Name = "BarButtonItem7"
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
        Me.BarButtonItem2.Caption = "Bekleyenleri Göster,F6"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Servistekileri Göster,F8"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "SeriNolar"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N))
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Verilen Sipariþleri Göster,F7"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Alýnan Sipariþleri Göster"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "(R)"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(826, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 409)
        Me.barDockControlBottom.Size = New System.Drawing.Size(826, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 409)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(826, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 409)
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(741, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(666, 8)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "&Tamam"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GridControl1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(826, 313)
        Me.Panel3.TabIndex = 2
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.DataMember = Nothing
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(822, 309)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem5})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem1.Text = "Görünümü Yazdýr"
        '
        'MenuItem2
        '
        Me.MenuItem2.DefaultItem = True
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem2.Text = "Bekleyenleri Göster"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem3.Text = "Servistekileri Göster"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "Stok Hareketleri"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Text = "Transfer Hareketleri"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsAciklama, Me.colGIREN, Me.colCIKAN, Me.colKALAN, Me.colMEVCUT, Me.colBEKLEYEN, Me.colServiste})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(806, 484, 208, 170)
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
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Depo"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sAciklama", "{0} Kayýt")})
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 0
        Me.colsAciklama.Width = 172
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
        Me.colKALAN.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.colKALAN.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colKALAN.AppearanceCell.Options.UseFont = True
        Me.colKALAN.AppearanceCell.Options.UseForeColor = True
        Me.colKALAN.Caption = "Depo Mevcudu"
        Me.colKALAN.DisplayFormat.FormatString = "#,#.##"
        Me.colKALAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKALAN.FieldName = "KALAN"
        Me.colKALAN.Name = "colKALAN"
        Me.colKALAN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KALAN", "{0:#,0.####}")})
        Me.colKALAN.Visible = True
        Me.colKALAN.VisibleIndex = 1
        Me.colKALAN.Width = 171
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
        Me.colBEKLEYEN.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
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
        Me.colBEKLEYEN.Width = 156
        '
        'colServiste
        '
        Me.colServiste.Caption = "Serviste"
        Me.colServiste.DisplayFormat.FormatString = "#,0.####"
        Me.colServiste.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colServiste.FieldName = "Serviste"
        Me.colServiste.Name = "colServiste"
        Me.colServiste.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Serviste", "{0:#,0.####}")})
        Me.colServiste.Width = 155
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Envanter Durum Raporu", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Stok Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_stok_envanter
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(826, 431)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_stok_envanter"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Envanter Daðýlýmý"
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.sec_resmi1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_resmi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteFisTarihi.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dteFisTarihi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public connection
    Public connection_orj
    Public connection_resmi
    Public connection_resmi1
    Public stokno As String
    Public stokkodu As String
    Public firmano
    Public donemno
    Public kullanici
    Dim bYuklendi As Boolean = False
    Dim ds_stok As DataSet
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
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
        Label1.Text = Sorgu_sDil(Label1.Text, sDil)
        Label2.Text = Sorgu_sDil(Label2.Text, sDil)
        Label3.Text = Sorgu_sDil(Label3.Text, sDil)
        Label5.Text = Sorgu_sDil(Label5.Text, sDil)
        Label8.Text = Sorgu_sDil(Label8.Text, sDil)
        Label9.Text = Sorgu_sDil(Label9.Text, sDil)
        Label10.Text = Sorgu_sDil(Label10.Text, sDil)
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Public Function stok(ByVal stokno As String) As DataSet
        Dim kriter
        'kriter = "WHERE (stok.nStokID= " & stokno & " ) "
        kriter = "WHERE (stok.sKodu= N'" & stokkodu & "' ) "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sAciklama, SUM(GIREN) AS GIREN, SUM(CIKAN) AS CIKAN, SUM(KALAN) AS KALAN,SUM(BEKLEYEN) AS BEKLEYEN, sBarkod, STOKKODU, STOKADI, sRenk, sBeden, lAsgariMiktar, lAzamiMiktar, sModel FROM (SELECT depo.sAciklama , 0 AS GIREN , 0 AS CIKAN , 0 AS KALAN , barkod.sBarkod , stok.sKodu AS STOKKODU , stok.sAciklama AS STOKADI , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo AND depo.bEnvanterGosterme = 0 INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.sKodu ='" & stokkodu & "') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '" & txt_dteFisTarihi.EditValue & "') GROUP BY depo.sAciklama , barkod.sBarkod , stok.sKodu , stok.sAciklama , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel UNION SELECT depo.sAciklama , ISNULL(SUM(hareket.lGirisMiktar1) , 0) AS GIREN , ISNULL(SUM(hareket.lCikisMiktar1) , 0) AS CIKAN , ISNULL(SUM(hareket.lGirisMiktar1 - hareket.lCikisMiktar1) , 0) AS KALAN , barkod.sBarkod , stok.sKodu AS STOKKODU , stok.sAciklama AS STOKADI , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , 0 AS BEKLEYEN FROM tbStokBarkodu barkod INNER JOIN tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo AND depo.bEnvanterGosterme = 0 ON barkod.nStokID = stok.nStokID and barkod.nKisim = 0 WHERE (stok.sKodu = '" & stokkodu & "') and hareket.dteFisTarihi < = '" & txt_dteFisTarihi.EditValue & "' GROUP BY depo.sAciklama , stok.nStokID , barkod.sBarkod , stok.sKodu , stok.sAciklama , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , depo.sDepo) TT GROUP BY sAciklama, sBarkod, STOKKODU, STOKADI, sRenk, sBeden, lAsgariMiktar, lAzamiMiktar, sModel")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function stok_serviste(ByVal stokkodu As String) As Decimal
        Dim kriter
        'kriter = "WHERE (stok.nStokID= " & stokno & " ) "
        kriter = "WHERE (STOKISLEMTIPI IN (0,1, 2,4)) AND (STOKKODU= N'" & stokkodu & "' ) "
        Dim serviste As Decimal = 0
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST(ISNULL(SUM(GIREN),0) AS MONEY) AS MIKTAR FROM (SELECT HAREKET.* , (SELECT TOP 1 ISLEMTIPI FROM ASTOKSERVISHAREKETLERI WHERE REFNO = HAREKET.IND AND REFBASLIK = HAREKET.EVRAKNO ORDER BY ISLEMTIPI DESC) AS STOKISLEMTIPI FROM ASTOKSERVISDETAY HAREKET INNER JOIN ASTOKSERVISBASLIK BASLIK ON HAREKET.EVRAKNO = BASLIK.IND WHERE BASLIK.FIRMATIPI IN (1)) T  " & kriter & " ")
        serviste = cmd.ExecuteScalar
        conn.Close()
        Return serviste
    End Function
    Public Function tbStok_Siparis_Kalan(ByVal sKodu As String, ByVal nSiparisTipi As Integer) As Decimal
        Dim serviste As Decimal = 0
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST(ISNULL(lSiparis - lSevkiyat,0) AS MONEY) AS lKalan FROM (SELECT tbStok.nStokID , tbStok.sModel , tbStok.sKodu , tbStok.sAciklama , SUM(tbSiparis.lMiktari) AS lSiparis , ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1) , 0) AS lSevkiyat FROM tbFirma INNER JOIN tbSiparis ON tbFirma.nFirmaID = tbSiparis.nFirmaID INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID LEFT OUTER JOIN tbStokFisiDetayi WITH (INDEX (tbStokFisiDetayi_index12)) ON tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID WHERE (tbSiparis.bKapandimi = 0) AND (tbSiparis.lSiparisNo BETWEEN 1 AND 999999999) AND (tbSiparis.dteSiparisTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (SUBSTRING(tbSiparis.sSiparisiAlan , 1 , 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (SUBSTRING(tbSiparis.sSiparisiAlan , 31 , 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (tbSiparis.nSiparisTipi = " & nSiparisTipi & ") AND tbStok.sKodu = '" & sKodu & "' GROUP BY tbStok.nStokID , tbStok.sAciklama , tbStok.sModel , tbStok.sKodu) tSiparis WHERE (ISNULL(lSiparis, 0) - ISNULL(lSevkiyat, 0) <> 0) ORDER BY sKodu")
        If nSiparisTipi = 1 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(lKalanMiktar), 0) AS lSiparis FROM (SELECT tbStok.nStokID , tbSiparis.lMiktari - SUM(ISNULL(tbStokFisiDetayi.lSevkMiktari , 0)) + SUM(ISNULL(tbStokFisiDetayi.lSevkIadeMiktari , 0)) AS lKalanMiktar FROM (SELECT nSiparisID , isnull(abs(SUM(lCikisMiktar1 )) , 0) lSevkMiktari , 0 lSevkIadeMiktari  FROM tbStokFisiDetayi , tbStok , tbFirma WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID AND tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID AND dteIslemTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND nSiparisID IS NOT NULL GROUP BY nSiparisID) tbStokFisiDetayi RIGHT OUTER JOIN tbStok INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk AND tbStok.sRenk = tbRenk.sRenk INNER JOIN tbSiparis INNER JOIN tbParti ON tbSiparis.nPartiID = tbParti.nPartiID INNER JOIN tbFirma ON tbSiparis.nFirmaID = tbFirma.nFirmaID ON tbStok.nStokID = tbSiparis.nStokID ON tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID WHERE (tbSiparis.bKapandimi = 0) AND (tbSiparis.nSiparisTipi = " & nSiparisTipi & ") AND tbStok.sKodu = N'" & sKodu & "' GROUP BY tbStok.nStokID , tbStok.sKodu , tbStok.sBeden , tbStok.sAciklama , tbFirma.sKodu , tbFirma.sAciklama , tbSiparis.lSiparisNo , tbSiparis.nSiparisID , tbSiparis.dteSiparisTarihi , tbSiparis.dteTeslimTarihi , tbSiparis.sSiparisIslem , tbSiparis.lMiktari , tbSiparis.lReserveMiktari , tbStok.sRenk , tbRenk.sRenkAdi , tbSiparis.nValorGun , CAST(tbSiparis.bKapandimi AS int)) t WHERE (lKalanMiktar > 0) GROUP BY nStokID")
        ElseIf nSiparisTipi = 2 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(lKalanMiktar), 0) AS lSiparis FROM (SELECT tbStok.nStokID , tbSiparis.lMiktari - SUM(ISNULL(tbStokFisiDetayi.lSevkMiktari , 0)) + SUM(ISNULL(tbStokFisiDetayi.lSevkIadeMiktari , 0)) AS lKalanMiktar FROM (SELECT nSiparisID , isnull(abs(SUM(lGirisMiktar1 * (nGirisCikis - 2))) , 0) lSevkMiktari , isnull(abs(SUM(lGirisTutar * (nGirisCikis - 2))) , 0) lSevkTutari , isnull(abs(SUM(lGirisMiktar1 * (nGirisCikis - 1))) , 0) lSevkIadeMiktari , isnull(abs(SUM(lGirisTutar * (nGirisCikis - 1))) , 0) lSevkIadeTutari FROM tbStokFisiDetayi , tbStok , tbFirma WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID AND tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID AND dteIslemTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND nSiparisID IS NOT NULL GROUP BY nSiparisID) tbStokFisiDetayi RIGHT OUTER JOIN tbStok INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk AND tbStok.sRenk = tbRenk.sRenk INNER JOIN tbSiparis INNER JOIN tbParti ON tbSiparis.nPartiID = tbParti.nPartiID INNER JOIN tbFirma ON tbSiparis.nFirmaID = tbFirma.nFirmaID ON tbStok.nStokID = tbSiparis.nStokID ON tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID WHERE (tbSiparis.bKapandimi = 0) AND (tbSiparis.nSiparisTipi = " & nSiparisTipi & ") AND tbStok.sKodu = N'" & sKodu & "' GROUP BY tbStok.nStokID , tbStok.sKodu , tbStok.sBeden , tbStok.sAciklama , tbFirma.sKodu , tbFirma.sAciklama , tbSiparis.lSiparisNo , tbSiparis.nSiparisID , tbSiparis.dteSiparisTarihi , tbSiparis.dteTeslimTarihi , tbSiparis.sSiparisIslem , tbSiparis.lMiktari , tbSiparis.lReserveMiktari , tbStok.sRenk , tbRenk.sRenkAdi , tbSiparis.nValorGun , CAST(tbSiparis.bKapandimi AS int)) t WHERE (lKalanMiktar > 0) GROUP BY nStokID")
        End If
        serviste = cmd.ExecuteScalar
        conn.Close()
        Return serviste
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub analiz_bekleyen()
        Dim frm As New frm_satis_bekleyen_onaysiz
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.stokkodu = stokkodu
        frm.tarih1 = "01/01/1900"
        frm.tarih2 = "31/12/2048"
        frm.qstokkodu = "Eþittir"
        frm.islemstatus = True
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub analiz_serviste()
        Dim frm As New frm_stok_servis_bekleyen
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.txt_ara_stok.Text = Trim(lbl_sKodu.Text)
        frm.islemstatus = True
        'frm.dataload("01/01/1900", "31/12/2048", Trim(Label3.Text), "Kod", "Baþlar", "", "Adý+Soyadý", "Baþlar")
        'frm.servis = True
        frm.kontrol = True
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub analiz_siparis(ByVal sKodu As String, ByVal nSiparisTipi As Integer)
        Dim frm As New frm_tbSiparis_bekleyen
        frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.kullanici = kullanici
        frm.txt_dteSiparisTarihi1.EditValue = "01/01/1900"
        frm.txt_dteSiparisTarihi2.EditValue = "31/12/2078"
        frm.sStokKodu = sKodu
        'frm.txt_ara.Text = dr_baslik("sKodu").ToString
        'frm.txt_ara.Enabled = False
        'frm.sec_konum.Enabled = False
        'frm.sec_kriter.Enabled = False
        'If dr_baslik("nGirisCikis") = 1 Then
        frm.nSiparisTipi = nSiparisTipi
        'ElseIf dr_baslik("nGirisCikis") = 3 Then
        '    frm.nSiparisTipi = 1
        'End If
        frm.sec_bKapandimi.Checked = False
        frm.sec_bKapandimi.Enabled = False
        frm.ShowDialog()
    End Sub
    Private Sub analiz_StokSeriNo()
        Dim frm As New frm_Stok_SeriNo
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.nStokID = stokno
        frm.ShowDialog()
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub frm_stok_envanter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection_orj = connection
        connection_resmi = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("ugurlu_resmi")
        connection_resmi1 = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("ugurlu_resmi1")
        txt_dteFisTarihi.EditValue = "31/12/2078"
        If stokkodu = "" Then
            'stok_sec()
            txt_musteriNo.Focus()
            txt_musteriNo.SelectAll()
        Else
            txt_musteriNo.EditValue = Trim(stokkodu)
            stok_kontrol()
        End If
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        bYuklendi = True
        If stokkodu = "" Then
            txt_musteriNo.Focus()
            txt_musteriNo.SelectAll()
        End If
    End Sub
    Private Sub stok_sec()
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_stok_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            stokno = dr1("nStokID")
            stokkodu = dr1("sKodu")
            'sModel = dr1("sModel")
            txt_musteriNo.EditValue = Trim(stokkodu)
            stok_kontrol()
            dr1 = Nothing
        End If
    End Sub
    Private Sub ara()
        If stokkodu = "" Then
            'stok_sec()
            txt_musteriNo.Focus()
            txt_musteriNo.SelectAll()
        Else
            txt_musteriNo.EditValue = Trim(stokkodu)
            stok_kontrol()
        End If
    End Sub
    Private Sub stok_kontrol()
        If Trim(txt_musteriNo.EditValue).ToString <> "" Then
            Dim kontrol = sorgu_stok_kontrol(txt_musteriNo.EditValue)
            If kontrol = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                dataload_stok(txt_musteriNo.EditValue)
                Dim dr As DataRow
                For Each dr In ds_stok.Tables(0).Rows
                    'txt_Musteri.EditValue = dr("MUSTERI")
                    stokkodu = dr("sKodu")
                    stokno = dr("nStokID")
                    'sModel = dr("sModel")
                    dataload(stokkodu)
                Next
                dr = Nothing
            End If
        End If
    End Sub
    Public Function sorgu_stok_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu like '" & kod & "%') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         tbStok " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_stok(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (sKodu like  N'" & kod & "%') "
        ds_stok = sorgu(sorgu_query("SELECT     top 1 nStokID,sKodu,sAciklama,sModel FROM         tbStok " & kriter & ""))
    End Sub
    Private Sub dataload(ByVal stokkodu As String)
        'DataSet1.Clear()
        'DataSet1.Dispose()
        DataSet1 = stok(stokno)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        Panel3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        Dim dr As DataRow
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            lbl_sKodu.Text = dr("STOKKODU")
            lbl_sAciklama.Text = dr("STOKADI")
            lbl_sRenk.Text = dr("sRenk")
            lbl_sServiste.Text = stok_serviste(dr("STOKKODU"))
            lbl_Siparis_Alinan.Text = tbStok_Siparis_Kalan(dr("STOKKODU"), 1)
            lbl_Siparis_Verilen.Text = tbStok_Siparis_Kalan(dr("STOKKODU"), 2)
        End If
        'GridView1.SelectRow(0)
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            Me.Close()
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        gorunumu_yazdir()
    End Sub
    Private Sub gorunumu_yazdir()
        Dim kriter As String = ""
        kriter += Microsoft.VisualBasic.Left(txt_dteFisTarihi.EditValue.ToString, 10) & " Tarihinde Stoklar Envanter Depo Daðýlýmý" & vbCrLf
        kriter += "Kod = " & lbl_sKodu.Text & " Aciklama : " & lbl_sAciklama.Text & " Renk: " & lbl_sRenk.Text
        printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Stok Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        analiz_bekleyen()
    End Sub
    Private Sub frm_stok_envanter_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Panel1 = Nothing
        'Panel2 = Nothing
        'Panel3 = Nothing
        'SimpleButton1 = Nothing
        'SimpleButton2 = Nothing
        'GridControl1 = Nothing
        'GridView1 = Nothing
        'DataSet1 = Nothing
        'DataTable1 = Nothing
        'DataColumn1 = Nothing
        'DataColumn2 = Nothing
        'DataColumn3 = Nothing
        'DataColumn4 = Nothing
        'colsAciklama = Nothing
        'colGIREN = Nothing
        'colCIKAN = Nothing
        'colKALAN = Nothing
        'DataColumn5 = Nothing
        'colMEVCUT = Nothing
        'Label1 = Nothing
        'Label2 = Nothing
        'Label3 = Nothing
        'Label4 = Nothing
        'DataColumn6 = Nothing
        'DataColumn7 = Nothing
        'DataColumn8 = Nothing
        'colBEKLEYEN = Nothing
        'Label5 = Nothing
        'Label6 = Nothing
        'ContextMenu1 = Nothing
        'MenuItem1 = Nothing
        'ps = Nothing
        'printlink1 = Nothing
        'MenuItem2 = Nothing
        'connection = Nothing
        'stokno = Nothing
        'stokkodu = Nothing
        'firmano = Nothing
        'donemno = Nothing
        'Me.Close()
        System.GC.Collect()
        System.GC.SuppressFinalize(Me)
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        analiz_serviste()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        gorunumu_yazdir()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        analiz_bekleyen()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        analiz_serviste()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        analiz_StokSeriNo()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_siparis(stokkodu, 2)
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_siparis(stokkodu, 1)
    End Sub
    Private Sub txt_dteFisTarihi_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_dteFisTarihi.TextChanged
        If bYuklendi = True Then
            dataload(stokkodu)
        End If
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        analiz_stok_hareket()
    End Sub
    Private Sub analiz_stok_hareket()
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_stok_hareketleri
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = stokkodu
        frm.nFirmaID = 0
        frm.sec_firma.Checked = False
        frm.sec_giris.Text = "[Tümü]"
        frm.collGirisFiyat.Visible = False
        frm.collGirisFiyat.OptionsColumn.ShowInCustomizationForm = False
        frm.collCikisFiyat.Visible = False
        frm.collCikisFiyat.OptionsColumn.ShowInCustomizationForm = False
        frm.collBrutFiyat.Visible = False
        frm.collBrutFiyat.OptionsColumn.ShowInCustomizationForm = False
        frm.collBrutTutar.Visible = False
        frm.collBrutTutar.OptionsColumn.ShowInCustomizationForm = False
        frm.colnKdvOrani.Visible = False
        frm.colnKdvOrani.OptionsColumn.ShowInCustomizationForm = False
        frm.collIskontoTutari.Visible = False
        frm.collIskontoTutari.OptionsColumn.ShowInCustomizationForm = False
        frm.colnGirisCikis.Visible = False
        frm.MenuItem16.Enabled = False
        frm.MenuItem17.Enabled = False
        frm.MenuItem20.Enabled = False
        frm.Label1.Text = stokkodu & vbCrLf & frm.Label1.Text
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub analiz_hareket_transfer()
        Dim frm As New frm_stok_hareketleri_transfer
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.stokno = dr("nStokId")
        frm.stokkodu = Trim(stokkodu)
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        analiz_hareket_transfer()
    End Sub
    Private Sub txt_musteriNo_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musteriNo.ButtonPressed
        stok_sec()
    End Sub
    Private Sub txt_musteriNo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_musteriNo.EditValueChanged
        If Len(txt_musteriNo.EditValue.ToString) <> 0 Then
            lbl_ara.Text = Len(txt_musteriNo.EditValue.ToString)
        Else
            lbl_ara.Text = "*"
        End If
    End Sub
    Private Sub txt_musteriNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_musteriNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            stok_kontrol()
            txt_musteriNo.Focus()
            txt_musteriNo.SelectAll()
        ElseIf e.KeyCode = Keys.F6 Then
            stok_sec()
        End If
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        stok_sec()
    End Sub
    Private Sub sec_resmi_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_resmi.CheckStateChanged
        If sec_resmi.Checked = True Then
            connection = connection_resmi
            ara()
            sec_resmi1.Checked = False
        ElseIf sec_resmi.Checked = False Then
            connection = connection_orj
            ara()
        End If
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        If sec_resmi.Checked = False Then
            sec_resmi.Checked = True
        ElseIf sec_resmi.Checked = True Then
            sec_resmi.Checked = False
        End If
    End Sub
End Class
