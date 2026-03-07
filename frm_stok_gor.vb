Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_stok_gor
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
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
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
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblstokkodu As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblstokadi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblbarkod As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblrenk As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblbeden As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblpesin As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl10taksit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl6taksit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblmevcut As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents colBEKLEYEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblsiparis As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents lbl_ara As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_gor))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.lbl_ara = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.lblsiparis = New DevExpress.XtraEditors.LabelControl
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
        Me.Label9 = New DevExpress.XtraEditors.LabelControl
        Me.lblmevcut = New DevExpress.XtraEditors.LabelControl
        Me.Label10 = New DevExpress.XtraEditors.LabelControl
        Me.lbl6taksit = New DevExpress.XtraEditors.LabelControl
        Me.lbl10taksit = New DevExpress.XtraEditors.LabelControl
        Me.lblpesin = New DevExpress.XtraEditors.LabelControl
        Me.Label8 = New DevExpress.XtraEditors.LabelControl
        Me.label7 = New DevExpress.XtraEditors.LabelControl
        Me.label6 = New DevExpress.XtraEditors.LabelControl
        Me.lblbeden = New DevExpress.XtraEditors.LabelControl
        Me.lblrenk = New DevExpress.XtraEditors.LabelControl
        Me.lblbarkod = New DevExpress.XtraEditors.LabelControl
        Me.lblstokadi = New DevExpress.XtraEditors.LabelControl
        Me.lblstokkodu = New DevExpress.XtraEditors.LabelControl
        Me.Label5 = New DevExpress.XtraEditors.LabelControl
        Me.Label4 = New DevExpress.XtraEditors.LabelControl
        Me.Label3 = New DevExpress.XtraEditors.LabelControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
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
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collAsgariMiktar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collAzamiMiktar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsModel = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colBEKLEYEN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lbl_ara)
        Me.PanelControl1.Controls.Add(Me.GroupControl2)
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 176)
        Me.PanelControl1.TabIndex = 0
        '
        'lbl_ara
        '
        Me.lbl_ara.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ara.Location = New System.Drawing.Point(424, 32)
        Me.lbl_ara.Name = "lbl_ara"
        Me.lbl_ara.Size = New System.Drawing.Size(24, 20)
        Me.lbl_ara.TabIndex = 2
        Me.lbl_ara.Text = "*"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseBackColor = True
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.lblsiparis)
        Me.GroupControl2.Controls.Add(Me.Label9)
        Me.GroupControl2.Controls.Add(Me.lblmevcut)
        Me.GroupControl2.Controls.Add(Me.Label10)
        Me.GroupControl2.Controls.Add(Me.lbl6taksit)
        Me.GroupControl2.Controls.Add(Me.lbl10taksit)
        Me.GroupControl2.Controls.Add(Me.lblpesin)
        Me.GroupControl2.Controls.Add(Me.Label8)
        Me.GroupControl2.Controls.Add(Me.label7)
        Me.GroupControl2.Controls.Add(Me.label6)
        Me.GroupControl2.Controls.Add(Me.lblbeden)
        Me.GroupControl2.Controls.Add(Me.lblrenk)
        Me.GroupControl2.Controls.Add(Me.lblbarkod)
        Me.GroupControl2.Controls.Add(Me.lblstokadi)
        Me.GroupControl2.Controls.Add(Me.lblstokkodu)
        Me.GroupControl2.Controls.Add(Me.Label5)
        Me.GroupControl2.Controls.Add(Me.Label4)
        Me.GroupControl2.Controls.Add(Me.Label3)
        Me.GroupControl2.Controls.Add(Me.Label2)
        Me.GroupControl2.Controls.Add(Me.Label1)
        Me.GroupControl2.Location = New System.Drawing.Point(8, 57)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(808, 112)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "StokBilgileri"
        '
        'lblsiparis
        '
        Me.lblsiparis.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsiparis.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "Table1.STOKKODU", True))
        Me.lblsiparis.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblsiparis.ForeColor = System.Drawing.Color.Red
        Me.lblsiparis.Location = New System.Drawing.Point(696, 90)
        Me.lblsiparis.Name = "lblsiparis"
        Me.lblsiparis.Size = New System.Drawing.Size(80, 20)
        Me.lblsiparis.TabIndex = 23
        Me.lblsiparis.Text = "*"
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
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.Location = New System.Drawing.Point(592, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "VerilenSipariþ:"
        '
        'lblmevcut
        '
        Me.lblmevcut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblmevcut.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "Table1.STOKKODU", True))
        Me.lblmevcut.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblmevcut.ForeColor = System.Drawing.Color.Red
        Me.lblmevcut.Location = New System.Drawing.Point(696, 75)
        Me.lblmevcut.Name = "lblmevcut"
        Me.lblmevcut.Size = New System.Drawing.Size(80, 20)
        Me.lblmevcut.TabIndex = 21
        Me.lblmevcut.Text = "*"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.Location = New System.Drawing.Point(592, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "SatýlabilirMevcut:"
        '
        'lbl6taksit
        '
        Me.lbl6taksit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl6taksit.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "Table1.STOKKODU", True))
        Me.lbl6taksit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl6taksit.Location = New System.Drawing.Point(696, 41)
        Me.lbl6taksit.Name = "lbl6taksit"
        Me.lbl6taksit.Size = New System.Drawing.Size(80, 20)
        Me.lbl6taksit.TabIndex = 19
        Me.lbl6taksit.Text = "*"
        '
        'lbl10taksit
        '
        Me.lbl10taksit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl10taksit.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "Table1.STOKKODU", True))
        Me.lbl10taksit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl10taksit.Location = New System.Drawing.Point(696, 59)
        Me.lbl10taksit.Name = "lbl10taksit"
        Me.lbl10taksit.Size = New System.Drawing.Size(80, 20)
        Me.lbl10taksit.TabIndex = 18
        Me.lbl10taksit.Text = "*"
        '
        'lblpesin
        '
        Me.lblpesin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblpesin.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "Table1.STOKKODU", True))
        Me.lblpesin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblpesin.Location = New System.Drawing.Point(696, 24)
        Me.lblpesin.Name = "lblpesin"
        Me.lblpesin.Size = New System.Drawing.Size(80, 20)
        Me.lblpesin.TabIndex = 17
        Me.lblpesin.Text = "*"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Location = New System.Drawing.Point(600, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "6 Taksit Fiyatý:"
        '
        'label7
        '
        Me.label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label7.Location = New System.Drawing.Point(600, 59)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(88, 20)
        Me.label7.TabIndex = 15
        Me.label7.Text = "10 Taksit Fiyatý:"
        '
        'label6
        '
        Me.label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label6.Location = New System.Drawing.Point(600, 24)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(88, 20)
        Me.label6.TabIndex = 14
        Me.label6.Text = "Peþin Fiyatý:"
        '
        'lblbeden
        '
        Me.lblbeden.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "Table1.STOKKODU", True))
        Me.lblbeden.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblbeden.Location = New System.Drawing.Point(80, 88)
        Me.lblbeden.Name = "lblbeden"
        Me.lblbeden.Size = New System.Drawing.Size(336, 20)
        Me.lblbeden.TabIndex = 13
        Me.lblbeden.Text = "*"
        '
        'lblrenk
        '
        Me.lblrenk.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "Table1.STOKKODU", True))
        Me.lblrenk.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblrenk.Location = New System.Drawing.Point(80, 72)
        Me.lblrenk.Name = "lblrenk"
        Me.lblrenk.Size = New System.Drawing.Size(336, 20)
        Me.lblrenk.TabIndex = 12
        Me.lblrenk.Text = "*"
        '
        'lblbarkod
        '
        Me.lblbarkod.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "Table1.STOKKODU", True))
        Me.lblbarkod.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblbarkod.Location = New System.Drawing.Point(80, 56)
        Me.lblbarkod.Name = "lblbarkod"
        Me.lblbarkod.Size = New System.Drawing.Size(336, 20)
        Me.lblbarkod.TabIndex = 11
        Me.lblbarkod.Text = "*"
        '
        'lblstokadi
        '
        Me.lblstokadi.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "Table1.STOKKODU", True))
        Me.lblstokadi.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblstokadi.Location = New System.Drawing.Point(80, 40)
        Me.lblstokadi.Name = "lblstokadi"
        Me.lblstokadi.Size = New System.Drawing.Size(336, 20)
        Me.lblstokadi.TabIndex = 10
        Me.lblstokadi.Text = "*"
        '
        'lblstokkodu
        '
        Me.lblstokkodu.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "Table1.STOKKODU", True))
        Me.lblstokkodu.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblstokkodu.Location = New System.Drawing.Point(80, 24)
        Me.lblstokkodu.Name = "lblstokkodu"
        Me.lblstokkodu.Size = New System.Drawing.Size(336, 20)
        Me.lblstokkodu.TabIndex = 9
        Me.lblstokkodu.Text = "*"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Beden:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Renk:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Barkod:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "StokAdý:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "StokKodu:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Location = New System.Drawing.Point(448, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(368, 48)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Ara"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(275, 22)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 20)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Eþittir"
        Me.sec_kriter.Location = New System.Drawing.Point(200, 22)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(75, 20)
        Me.sec_kriter.TabIndex = 1
        '
        'txt_ara
        '
        Me.txt_ara.Location = New System.Drawing.Point(2, 22)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(198, 20)
        Me.txt_ara.TabIndex = 0
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
        Me.SimpleButton2.Location = New System.Drawing.Point(737, 8)
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
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 176)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 213)
        Me.PanelControl3.TabIndex = 2
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = Nothing
        Me.GridControl1.DataSource = Me.DataSet1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 2)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(820, 209)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsAciklama, Me.colGIREN, Me.colCIKAN, Me.colKALAN, Me.colMEVCUT, Me.colToplamAlinan, Me.colToplamVerilen, Me.colPESIN, Me.colONAY, Me.colALTIAY, Me.colsBarkod, Me.colSTOKKODU, Me.colSTOKADI, Me.colsRenk, Me.colsBeden, Me.collAsgariMiktar, Me.collAzamiMiktar, Me.colsModel, Me.colBEKLEYEN})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(261, 243, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 12
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Depo"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sAciklama", "{0} Kayýt")})
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 0
        Me.colsAciklama.Width = 106
        '
        'colGIREN
        '
        Me.colGIREN.Caption = "Giren"
        Me.colGIREN.FieldName = "GIREN"
        Me.colGIREN.Name = "colGIREN"
        '
        'colCIKAN
        '
        Me.colCIKAN.Caption = "Çýkan"
        Me.colCIKAN.FieldName = "CIKAN"
        Me.colCIKAN.Name = "colCIKAN"
        '
        'colKALAN
        '
        Me.colKALAN.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.colKALAN.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colKALAN.AppearanceCell.Options.UseFont = True
        Me.colKALAN.AppearanceCell.Options.UseForeColor = True
        Me.colKALAN.Caption = "Depo Mevcudu"
        Me.colKALAN.DisplayFormat.FormatString = "#,0.####"
        Me.colKALAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKALAN.FieldName = "KALAN"
        Me.colKALAN.Name = "colKALAN"
        Me.colKALAN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KALAN", "{0:#,0.####}")})
        Me.colKALAN.Visible = True
        Me.colKALAN.VisibleIndex = 1
        Me.colKALAN.Width = 85
        '
        'colMEVCUT
        '
        Me.colMEVCUT.Caption = "Mevcut"
        Me.colMEVCUT.DisplayFormat.FormatString = "#,0.####"
        Me.colMEVCUT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMEVCUT.FieldName = "MEVCUT"
        Me.colMEVCUT.Name = "colMEVCUT"
        Me.colMEVCUT.Visible = True
        Me.colMEVCUT.VisibleIndex = 3
        Me.colMEVCUT.Width = 98
        '
        'colToplamAlinan
        '
        Me.colToplamAlinan.Caption = "AlýnanSipariþ"
        Me.colToplamAlinan.FieldName = "ToplamAlinan"
        Me.colToplamAlinan.Name = "colToplamAlinan"
        '
        'colToplamVerilen
        '
        Me.colToplamVerilen.Caption = "VerilenSipariþ"
        Me.colToplamVerilen.FieldName = "ToplamVerilen"
        Me.colToplamVerilen.Name = "colToplamVerilen"
        '
        'colPESIN
        '
        Me.colPESIN.Caption = "Fiyat1"
        Me.colPESIN.FieldName = "PESIN"
        Me.colPESIN.Name = "colPESIN"
        '
        'colONAY
        '
        Me.colONAY.Caption = "10 Aylýk Fiyatý"
        Me.colONAY.FieldName = "ONAY"
        Me.colONAY.Name = "colONAY"
        '
        'colALTIAY
        '
        Me.colALTIAY.Caption = "6 Aylýk Fiyatý"
        Me.colALTIAY.FieldName = "ALTIAY"
        Me.colALTIAY.Name = "colALTIAY"
        '
        'colsBarkod
        '
        Me.colsBarkod.Caption = "Barkod"
        Me.colsBarkod.FieldName = "sBarkod"
        Me.colsBarkod.Name = "colsBarkod"
        Me.colsBarkod.Width = 99
        '
        'colSTOKKODU
        '
        Me.colSTOKKODU.Caption = "Stok Kodu"
        Me.colSTOKKODU.FieldName = "STOKKODU"
        Me.colSTOKKODU.Name = "colSTOKKODU"
        '
        'colSTOKADI
        '
        Me.colSTOKADI.Caption = "Stok Adý"
        Me.colSTOKADI.FieldName = "STOKADI"
        Me.colSTOKADI.Name = "colSTOKADI"
        '
        'colsRenk
        '
        Me.colsRenk.Caption = "Renk"
        Me.colsRenk.FieldName = "sRenk"
        Me.colsRenk.Name = "colsRenk"
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
        Me.collAsgariMiktar.DisplayFormat.FormatString = "#,0.####"
        Me.collAsgariMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collAsgariMiktar.FieldName = "lAsgariMiktar"
        Me.collAsgariMiktar.Name = "collAsgariMiktar"
        Me.collAsgariMiktar.Visible = True
        Me.collAsgariMiktar.VisibleIndex = 4
        Me.collAsgariMiktar.Width = 90
        '
        'collAzamiMiktar
        '
        Me.collAzamiMiktar.Caption = "Azami Miktar"
        Me.collAzamiMiktar.DisplayFormat.FormatString = "#,0.####"
        Me.collAzamiMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collAzamiMiktar.FieldName = "lAzamiMiktar"
        Me.collAzamiMiktar.Name = "collAzamiMiktar"
        Me.collAzamiMiktar.Visible = True
        Me.collAzamiMiktar.VisibleIndex = 5
        Me.collAzamiMiktar.Width = 96
        '
        'colsModel
        '
        Me.colsModel.Caption = "Model"
        Me.colsModel.FieldName = "sModel"
        Me.colsModel.Name = "colsModel"
        Me.colsModel.Width = 86
        '
        'colBEKLEYEN
        '
        Me.colBEKLEYEN.Caption = "Bekleyen"
        Me.colBEKLEYEN.DisplayFormat.FormatString = "#,0.####"
        Me.colBEKLEYEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBEKLEYEN.FieldName = "BEKLEYEN"
        Me.colBEKLEYEN.Name = "colBEKLEYEN"
        Me.colBEKLEYEN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "BEKLEYEN", "{0:#,0.####}")})
        Me.colBEKLEYEN.Visible = True
        Me.colBEKLEYEN.VisibleIndex = 2
        Me.colBEKLEYEN.Width = 101
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem1.Text = "Tamam"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem2.Text = "Vazgeç"
        '
        'frm_stok_gor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_gor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Ýzle"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public connection
    Public firmano
    Public donemno
    Public kullanici
    Public gelismis
    Public qgelismis
    Dim ds_stok As DataSet
    Dim stokkodu
    Dim stokno
    Dim barcode
    Dim malincinsi
    Dim dr As DataRow
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub frm_stok_gor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
        'If stokkodu <> "" Then
        '    kriter += " AND (stok.skodu " & sorgu_kriter_string(stokkodu, qgelismis) & ")"
        'End If
        'If malincinsi <> "" Then
        '    kriter += " AND (stok.saciklama " & sorgu_kriter_string(malincinsi, qmalincinsi) & ")"
        'End If
        'If barkod <> "" Then
        '    kriter += " AND (barkod.sbarkod " & sorgu_kriter_string(barkod, qbarkod) & ")"
        'End If
        ''If birim <> "" Then
        ''    kriter += " AND (TBLBIRIMLEREX.BIRIMADI " & sorgu_kriter_string(birim, qbirim) & ")"
        ''End If
        'If kod1 <> "" Then
        '    kriter += " AND (stok.srenk " & sorgu_kriter_string(kod1, qkod1) & " )"
        'End If
        'If kod2 <> "" Then
        '    kriter += " AND (stok.sbeden " & sorgu_kriter_string(kod2, qkod2) & ")"
        'End If
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
        'If kayitno <> "" Then
        '    kriter += " AND (stok.nStokID " & sorgu_kriter_string(kayitno, qkayitno) & ")"
        'End If
        'If aktif <> "" Then
        '    kriter += " AND (STK.STATUS " & sorgu_kriter_string(aktif, qaktif) & ")"
        'End If
        'If sil = True Then
        '    kriter += " AND STK.IND NOT IN (SELECT STOKNO FROM *!F!DTBLSTOKHAREKETLERI) "
        'End If
        If gelismis <> "" Then
            kriter = " AND (stok.skodu " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (stok.saciklama " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (barkod.sbarkod " & sorgu_kriter_string(gelismis, qgelismis) & ")  "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sDepo, sAciklama, SUM(GIREN) AS GIREN, SUM(CIKAN) AS CIKAN, SUM(KALAN) AS KALAN,sum(BEKLEYEN) AS BEKLEYEN, sBarkod, nStokID, STOKKODU, STOKADI, sRenk, sBeden, lAsgariMiktar, lAzamiMiktar, sModel, (SELECT isnull(SUM(tbSiparis.lMiktari) , 0) FROM tbSiparis WHERE tbSiparis.nSiparisTipi = 1 AND tbSiparis.bKapandimi = 0 AND tbSiparis.nStokID = TT.nStokID) AS ToplamAlinan, (SELECT isnull(SUM(tbSiparis.lMiktari) , 0) FROM tbSiparis WHERE tbSiparis.nSiparisTipi = 2 AND tbSiparis.bKapandimi = 0 AND tbSiparis.nStokID = TT.nStokID) AS ToplamVerilen, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = TT.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = TT.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = TT.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY FROM (SELECT depo.sDepo , depo.sAciklama , 0 AS GIREN , 0 AS CIKAN , 0 AS KALAN , barkod.sBarkod , stok.nStokID , stok.sKodu AS STOKKODU , stok.sAciklama AS STOKADI , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID INNER JOIN tbDepo depo ON tbAlisverisSiparis.sMagazaKodu = depo.sDepo INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') " & kriter & " AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') GROUP BY depo.sDepo , depo.sAciklama , barkod.sBarkod , stok.nStokID , stok.sKodu , stok.sAciklama , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel UNION SELECT depo.sdepo , depo.sAciklama , ISNULL(SUM(hareket.lGirisMiktar1) , 0) AS GIREN , ISNULL(SUM(hareket.lCikisMiktar1) , 0) AS CIKAN , ISNULL(SUM(hareket.lGirisMiktar1 - hareket.lCikisMiktar1) , 0) AS KALAN , barkod.sBarkod , stok.nStokID , stok.sKodu AS STOKKODU , stok.sAciklama AS STOKADI , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , 0 AS BEKLEYEN FROM tbStokBarkodu barkod INNER JOIN tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo ON barkod.nStokID = stok.nStokID WHERE (stok.sKodu <> '') " & kriter & " GROUP BY depo.sDepo , depo.sAciklama , stok.nStokID , barkod.sBarkod , stok.nStokID , stok.sKodu , stok.sAciklama , stok.sRenk , stok.sBeden , stok.lAsgariMiktar , stok.lAzamiMiktar , stok.sModel , depo.sDepo) TT GROUP BY sDepo, sAciklama, sBarkod, nStokID, STOKKODU, STOKADI, sRenk, sBeden, lAsgariMiktar, lAzamiMiktar, sModel")
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT depo.sAciklama, ISNULL(SUM(hareket.lGirisMiktar1), 0) AS GIREN, ISNULL(SUM(hareket.lCikisMiktar1), 0) AS CIKAN, ISNULL(SUM(hareket.lGirisMiktar1 - hareket.lCikisMiktar1), 0) AS KALAN, (SELECT isnull(SUM(lgirismiktar1 - lcikismiktar1) , 0) AS MEVCUT FROM tbStokFisiDetayi WHERE nSTOKID = stok.nStokID) AS MEVCUT, (SELECT isnull(SUM(tbSiparis.lMiktari) , 0) FROM tbSiparis WHERE tbSiparis.nSiparisTipi = 1 AND tbSiparis.bKapandimi = 0 AND tbSiparis.nStokID = Stok.nStokID) AS ToplamAlinan, (SELECT isnull(SUM(tbSiparis.lMiktari) , 0) FROM tbSiparis WHERE tbSiparis.nSiparisTipi = 2 AND tbSiparis.bKapandimi = 0 AND tbSiparis.nStokID = Stok.nStokID) AS ToplamVerilen, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '"& sFiyat1 &"') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '"& sFiyat3 &"') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '"& sFiyat2 &"') AS ALTIAY, barkod.sBarkod, stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, depo.sDepo, (SELECT SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) AS SatisMiktar FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND tbAlisverisSiparis.nStokID = stok.nStokID AND tbAlisverisSiparis.sMagazaKodu = depo.sDepo HAVING (SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) > 0)) AS BEKLEYEN FROM tbStokBarkodu barkod INNER JOIN tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID INNER JOIN tbDepo depo ON hareket.sDepo = depo.sDepo ON barkod.nStokID = stok.nStokID " & kriter & " GROUP BY depo.sAciklama, stok.nStokID, barkod.sBarkod, stok.sKodu, stok.sAciklama, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, depo.sDepo")
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
        'DataSet1.Clear()
        'DataSet1.Dispose()
        DataSet1 = stok()
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            lblstokkodu.Text = dr("STOKKODU")
            lblstokadi.Text = dr("STOKADI")
            lblbarkod.Text = dr("sBarkod")
            lblrenk.Text = dr("sRenk")
            lblbeden.Text = dr("sBeden")
            lblpesin.Text = FormatNumber(dr("PESIN"), 2)
            lbl10taksit.Text = FormatNumber(dr("ONAY"), 2)
            lbl6taksit.Text = FormatNumber(dr("ALTIAY"), 2)
            'lblmevcut.Text = FormatNumber(dr("MEVCUT") - bekleyen_kontrol(), 2)
            'lblsiparis.Text = FormatNumber(dr("ToplamVerilen"), 2)
            Dim mevcut = 0
            Dim bekleyen As Decimal = 0
            Dim dr1 As DataRow
            For Each dr1 In DataSet1.Tables(0).Rows
                mevcut = mevcut + dr1("KALAN")
                bekleyen = bekleyen + dr1("BEKLEYEN")
            Next
            lblmevcut.Text = FormatNumber(mevcut - bekleyen, 2)
        Else
            XtraMessageBox.Show(gelismis & vbCrLf & Sorgu_sDil("Stok Bulunamadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'GridView1.SelectRow(0)
        txt_ara.Select()
        txt_ara.SelectAll()
    End Sub
    Private Function bekleyen_kontrol() As Decimal
        Dim dr As DataRow
        Dim bekleyen As Decimal = 0
        For Each dr In DataSet1.Tables(0).Rows
            If dr("BEKLEYEN").ToString = "" Then
                dr("BEKLEYEN") = 0
            End If
            bekleyen = bekleyen + dr("BEKLEYEN")
        Next
        Return bekleyen
    End Function
    Private Sub txt_ara_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ara.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dr As DataRow
            Dim kontrol = sorgu_stok_kontrol(txt_ara.EditValue)
            If kontrol = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf kontrol = 1 Then
                dataload_stok(txt_ara.EditValue)
                For Each dr In ds_stok.Tables(0).Rows
                    lblstokadi.Text = dr("Malincinsi")
                    stokkodu = (dr("StokKodu"))
                    stokno = dr("STOKNO")
                    barcode = dr("Barcode")
                    malincinsi = dr("Malincinsi")
                Next
                gor()
            End If
        End If
        'If e.KeyCode = Keys.Enter Then
        '    gor()
        'End If
    End Sub
    Private Sub dataload_stok(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (Stok.sKodu = '" & kod & "') or (Barcode.sBarkod ='" & kod & "') "
        ds_stok = sorgu(sorgu_query("SELECT     Stok.nStokID AS StokNo, Stok.sKodu AS StokKodu, Stok.sAciklama AS Malincinsi, Barcode.sBarkod AS Barcode FROM         tbStok Stok INNER JOIN                       tbStokBarkodu Barcode ON Stok.nStokID = Barcode.nStokID " & kriter & ""))
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
    Public Function sorgu_stok_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (Stok.sKodu = '" & kod & "') or (Barcode.sBarkod ='" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbStok Stok INNER JOIN  tbStokBarkodu Barcode ON Stok.nStokID = Barcode.nStokID " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub gor()
        DataSet1.Clear()
        lblstokkodu.Text = "*"
        lblstokadi.Text = "*"
        lblbarkod.Text = "*"
        lblrenk.Text = "*"
        lblbeden.Text = "*"
        lblpesin.Text = "*"
        lbl10taksit.Text = "*"
        lbl6taksit.Text = "*"
        lblmevcut.Text = "*"
        Try
            gelismis = stokkodu
            qgelismis = sec_kriter.EditValue.ToString
            dataload()
        Catch ex As Exception
            txt_ara.Select()
            txt_ara.SelectAll()
        End Try
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        gor()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Me.Close()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()
    End Sub
    Private Sub txt_ara_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ara.EditValueChanged
        If Len(txt_ara.EditValue.ToString) <> 0 Then
            lbl_ara.Text = Len(txt_ara.EditValue.ToString)
        Else
            lbl_ara.Text = "*"
        End If
    End Sub
    Private Sub frm_stok_gor_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
        Me.Hide()
    End Sub
End Class
