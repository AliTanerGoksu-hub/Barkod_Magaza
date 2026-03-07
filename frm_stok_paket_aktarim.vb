Imports System.IO
Imports DevExpress.XtraEditors
Public Class frm_stok_paket_aktarim
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelControl92 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_musteriNo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
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
    Friend WithEvents colnKayitID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBarcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStokFisiID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnHareketID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMusteri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsStokKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsStokAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBeden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
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
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bar1 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sMagaza As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents collTeslimEdilecek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collTeslimEdilen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_paket_aktarim))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl92 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_musteriNo = New DevExpress.XtraEditors.ButtonEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnKayitID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBarcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStokFisiID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnHareketID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMusteri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFisNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsStokKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsStokAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collTeslimEdilecek = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collTeslimEdilen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.txt_sMagaza = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.bar1 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.txt_sMagaza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 56)
        Me.PanelControl1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Appearance.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(96, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Paket Aktarým Tanýmlarý Aþaðýdadýr..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl92)
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.txt_musteriNo)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 381)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'LabelControl92
        '
        Me.LabelControl92.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl92.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl92.Location = New System.Drawing.Point(11, 14)
        Me.LabelControl92.Name = "LabelControl92"
        Me.LabelControl92.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl92.TabIndex = 71
        Me.LabelControl92.Text = "Dosya:"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(344, 14)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(80, 20)
        Me.SimpleButton3.TabIndex = 70
        Me.SimpleButton3.Text = "&Oku"
        '
        'txt_musteriNo
        '
        Me.txt_musteriNo.EditValue = "C:\NEBIM900\NEBIME\TES.SAY"
        Me.txt_musteriNo.Location = New System.Drawing.Point(56, 14)
        Me.txt_musteriNo.Name = "txt_musteriNo"
        Me.txt_musteriNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_musteriNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_musteriNo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_musteriNo.Properties.Appearance.Options.UseForeColor = True
        Me.txt_musteriNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_musteriNo.Properties.MaxLength = 13
        Me.txt_musteriNo.Size = New System.Drawing.Size(280, 20)
        Me.txt_musteriNo.TabIndex = 69
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(738, 13)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 68
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(658, 13)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 67
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Controls.Add(Me.PanelControl4)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 325)
        Me.PanelControl3.TabIndex = 2
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
        Me.GridControl1.Size = New System.Drawing.Size(820, 281)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem17, Me.MenuItem20, Me.MenuItem19, Me.MenuItem18, Me.MenuItem2, Me.MenuItem3, Me.MenuItem13, Me.MenuItem5, Me.MenuItem4, Me.MenuItem6, Me.MenuItem7, Me.MenuItem14, Me.MenuItem8, Me.MenuItem9, Me.MenuItem15, Me.MenuItem10, Me.MenuItem11, Me.MenuItem16, Me.MenuItem12})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "Oku"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 1
        Me.MenuItem17.Text = "Aktar"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 2
        Me.MenuItem20.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem20.Text = "Envanter"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 3
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem19.Text = "Fiþi Göster"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 4
        Me.MenuItem18.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 5
        Me.MenuItem2.Text = "Tamam"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 6
        Me.MenuItem3.Text = "Vazgeç"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 7
        Me.MenuItem13.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 8
        Me.MenuItem5.Text = "Hýzlý Filtre"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 9
        Me.MenuItem4.Text = "Görünümü Düzenle"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 10
        Me.MenuItem6.Text = "Görünümü Kaydet"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 11
        Me.MenuItem7.Text = "Görünümü Yazdýr"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 12
        Me.MenuItem14.Text = "-"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 13
        Me.MenuItem8.Text = "Filtrele"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 14
        Me.MenuItem9.Text = "Gruplandýr"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 15
        Me.MenuItem15.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 16
        Me.MenuItem10.Text = "Satýrlarý Aç"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 17
        Me.MenuItem11.Text = "Satýrlarý Kapat"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 18
        Me.MenuItem16.Text = "-"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 19
        Me.MenuItem12.Text = "Ekraný Kapla"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.AutoIncrement = True
        Me.DataColumn1.ColumnName = "nKayitID"
        Me.DataColumn1.DataType = GetType(Integer)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "lNo"
        Me.DataColumn2.DataType = GetType(Decimal)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "lKodu"
        Me.DataColumn3.DataType = GetType(Decimal)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sBarkod"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "lMiktar"
        Me.DataColumn5.DataType = GetType(Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "nStokFisiID"
        Me.DataColumn6.DataType = GetType(Long)
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "nHareketID"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "Musteri"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sAciklama"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "lFisNo"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "bStatus"
        Me.DataColumn11.DataType = GetType(Boolean)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "dteKayitTarihi"
        Me.DataColumn12.DataType = GetType(Date)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "lTeslimEdilecek"
        Me.DataColumn13.DataType = GetType(Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "lTeslimEdilen"
        Me.DataColumn14.DataType = GetType(Decimal)
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnKayitID, Me.collNo, Me.collKodu, Me.colsBarcode, Me.collMiktar, Me.colnStokFisiID, Me.colnHareketID, Me.colMusteri, Me.colsAciklama, Me.collFisNo, Me.colbStatus, Me.coldteKayitTarihi, Me.colsStokKodu, Me.colsStokAciklama, Me.colsRenk, Me.colsBeden, Me.collTeslimEdilecek, Me.collTeslimEdilen})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(506, 316, 208, 305)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMiktar", Me.collMiktar, "{0:#,0.####}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sBarkod", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sBarkod", Me.colsBarcode, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMiktar", Nothing, "{0:#,0.####} Adet")})
        Me.GridView1.IndicatorWidth = 12
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colnKayitID
        '
        Me.colnKayitID.Caption = "KayitID"
        Me.colnKayitID.FieldName = "nAktarimID"
        Me.colnKayitID.Name = "colnKayitID"
        '
        'collNo
        '
        Me.collNo.Caption = "No"
        Me.collNo.FieldName = "lNo"
        Me.collNo.Name = "collNo"
        Me.collNo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "lNo", "{0} Kayýt")})
        Me.collNo.Width = 55
        '
        'collKodu
        '
        Me.collKodu.Caption = "Kodu"
        Me.collKodu.FieldName = "lKodu"
        Me.collKodu.Name = "collKodu"
        Me.collKodu.Visible = True
        Me.collKodu.VisibleIndex = 0
        Me.collKodu.Width = 53
        '
        'colsBarcode
        '
        Me.colsBarcode.Caption = "Barkod"
        Me.colsBarcode.FieldName = "sBarkod"
        Me.colsBarcode.Name = "colsBarcode"
        Me.colsBarcode.Visible = True
        Me.colsBarcode.VisibleIndex = 2
        Me.colsBarcode.Width = 130
        '
        'collMiktar
        '
        Me.collMiktar.Caption = "Miktar"
        Me.collMiktar.DisplayFormat.FormatString = "#,0.####"
        Me.collMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collMiktar.FieldName = "lMiktar"
        Me.collMiktar.Name = "collMiktar"
        Me.collMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMiktar", "{0:#,0.0##}")})
        Me.collMiktar.Visible = True
        Me.collMiktar.VisibleIndex = 5
        Me.collMiktar.Width = 67
        '
        'colnStokFisiID
        '
        Me.colnStokFisiID.Caption = "Stok Fiþi ID"
        Me.colnStokFisiID.FieldName = "nStokFisiID"
        Me.colnStokFisiID.Name = "colnStokFisiID"
        Me.colnStokFisiID.Width = 34
        '
        'colnHareketID
        '
        Me.colnHareketID.Caption = "HareketID"
        Me.colnHareketID.FieldName = "nHareketID"
        Me.colnHareketID.Name = "colnHareketID"
        Me.colnHareketID.Width = 34
        '
        'colMusteri
        '
        Me.colMusteri.Caption = "Musteri"
        Me.colMusteri.FieldName = "Musteri"
        Me.colMusteri.Name = "colMusteri"
        Me.colMusteri.Visible = True
        Me.colMusteri.VisibleIndex = 1
        Me.colMusteri.Width = 133
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Açýklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 6
        Me.colsAciklama.Width = 212
        '
        'collFisNo
        '
        Me.collFisNo.Caption = "Fiþ No"
        Me.collFisNo.FieldName = "lFisNo"
        Me.collFisNo.Name = "collFisNo"
        Me.collFisNo.Width = 34
        '
        'colbStatus
        '
        Me.colbStatus.Caption = "Status"
        Me.colbStatus.FieldName = "bStatus"
        Me.colbStatus.Name = "colbStatus"
        Me.colbStatus.Width = 34
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "Kayýt Tarihi"
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        '
        'colsStokKodu
        '
        Me.colsStokKodu.Caption = "Stok Kodu"
        Me.colsStokKodu.FieldName = "sStokKodu"
        Me.colsStokKodu.Name = "colsStokKodu"
        Me.colsStokKodu.Width = 34
        '
        'colsStokAciklama
        '
        Me.colsStokAciklama.Caption = "Stok Adý"
        Me.colsStokAciklama.FieldName = "sStokAciklama"
        Me.colsStokAciklama.Name = "colsStokAciklama"
        Me.colsStokAciklama.Visible = True
        Me.colsStokAciklama.VisibleIndex = 3
        Me.colsStokAciklama.Width = 188
        '
        'colsRenk
        '
        Me.colsRenk.Caption = "Renk"
        Me.colsRenk.FieldName = "sRenk"
        Me.colsRenk.Name = "colsRenk"
        Me.colsRenk.Visible = True
        Me.colsRenk.VisibleIndex = 4
        Me.colsRenk.Width = 66
        '
        'colsBeden
        '
        Me.colsBeden.Caption = "Beden"
        Me.colsBeden.FieldName = "sBeden"
        Me.colsBeden.Name = "colsBeden"
        Me.colsBeden.Width = 64
        '
        'collTeslimEdilecek
        '
        Me.collTeslimEdilecek.Caption = "TeslimEdilecek"
        Me.collTeslimEdilecek.DisplayFormat.FormatString = "#,0.####"
        Me.collTeslimEdilecek.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collTeslimEdilecek.FieldName = "lTeslimEdilecek"
        Me.collTeslimEdilecek.Name = "collTeslimEdilecek"
        Me.collTeslimEdilecek.Visible = True
        Me.collTeslimEdilecek.VisibleIndex = 7
        '
        'collTeslimEdilen
        '
        Me.collTeslimEdilen.Caption = "TeslimEdilen"
        Me.collTeslimEdilen.DisplayFormat.FormatString = "#,0.####"
        Me.collTeslimEdilen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collTeslimEdilen.FieldName = "lTeslimEdilen"
        Me.collTeslimEdilen.Name = "collTeslimEdilen"
        Me.collTeslimEdilen.Visible = True
        Me.collTeslimEdilen.VisibleIndex = 8
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.txt_sMagaza)
        Me.PanelControl4.Controls.Add(Me.LabelControl2)
        Me.PanelControl4.Controls.Add(Me.Label1)
        Me.PanelControl4.Controls.Add(Me.bar1)
        Me.PanelControl4.Controls.Add(Me.LabelControl1)
        Me.PanelControl4.Controls.Add(Me.DateEdit1)
        Me.PanelControl4.Controls.Add(Me.SimpleButton4)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(2, 283)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(820, 40)
        Me.PanelControl4.TabIndex = 0
        '
        'txt_sMagaza
        '
        Me.txt_sMagaza.EnterMoveNextControl = True
        Me.txt_sMagaza.Location = New System.Drawing.Point(216, 6)
        Me.txt_sMagaza.Name = "txt_sMagaza"
        Me.txt_sMagaza.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sMagaza.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sMagaza.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sMagaza.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sMagaza.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sMagaza.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sMagaza.Properties.DisplayMember = "sDepo"
        Me.txt_sMagaza.Properties.NullText = "[Maðaza]"
        Me.txt_sMagaza.Properties.ValueMember = "sDepo"
        Me.txt_sMagaza.Size = New System.Drawing.Size(120, 20)
        Me.txt_sMagaza.TabIndex = 76
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(160, 6)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl2.TabIndex = 77
        Me.LabelControl2.Text = "Maðaza:"
        '
        'Label1
        '
        Me.Label1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Label1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Location = New System.Drawing.Point(800, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "***"
        '
        'bar1
        '
        Me.bar1.Location = New System.Drawing.Point(55, 26)
        Me.bar1.Name = "bar1"
        Me.bar1.Size = New System.Drawing.Size(369, 12)
        Me.bar1.TabIndex = 74
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(8, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl1.TabIndex = 73
        Me.LabelControl1.Text = "Tarih:"
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(56, 5)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(100, 20)
        Me.DateEdit1.TabIndex = 72
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(344, 5)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(80, 20)
        Me.SimpleButton4.TabIndex = 71
        Me.SimpleButton4.Text = "&Kontrol"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Teslimat Aktarýmý", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Paketleme Fiþleri", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_stok_paket_aktarim
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_paket_aktarim"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paket Aktarým"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.txt_sMagaza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Public sMagaza As String = ""
    Public status As Boolean = False
    Public islemstatus As Boolean = False
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim miktar As Decimal = 0
    Dim detay_miktar As Decimal = 0
    Dim ds_baslik As DataSet
    Dim ds_hareket As DataSet
    Dim ds_detay As DataSet
    Dim ds_iade As DataSet
    Dim dr_baslik As DataRow
    Private Sub frm_stok_paket_aktarim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        DateEdit1.EditValue = dteSistemTarihi
        dataload_tbDepo()
        txt_sMagaza.EditValue = sMagaza
        If islemstatus = True Then
            ara()
        End If
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\PAKET\" & Me.Name.ToString & "")
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
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        SimpleButton4.Text = Sorgu_sDil(SimpleButton4.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\PAKET\" & Me.Name.ToString & "")
    End Sub
    Private Sub dosya_ac(ByVal dosya As String)
        DataSet1.Tables(0).Clear()
        Dim lKodu As String = "0"
        FileOpen(1, dosya, OpenMode.Input, OpenAccess.Default)
        aStokPaketAktarim_kaydet_sil()
        While Not EOF(1)
            Dim a As Object = LineInput(1).Split(",")
            If Len(Trim(a(0))) < 12 Then
                If lKodu <> Trim(a(0)) Then
                    lKodu = Trim(a(0))
                End If
            Else
                Dim dr As DataRow = DataSet1.Tables(0).NewRow
                dr("lKodu") = lKodu
                dr("sBarkod") = Trim(a(0))
                dr("lMiktar") = a(1)
                aStokPaketAktarim_kaydet_yeni(dr("lKodu"), dr("sBarkod"), dr("lMiktar"), Now)
                DataSet1.Tables(0).Rows.Add(dr)
            End If
        End While
        FileClose(1)
        ara()
    End Sub
    Private Sub ara()
        dataload_aStokPaketAktarim(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbAktarim.nAktarimID, tbAktarim.lKodu, tbAktarim.sBarkod, tbAktarim.lMiktar, tbAktarim.dteKayitTarihi, tbStok.nStokID,tbStok.sKodu as sStokKodu, tbStok.sAciklama as sStokAciklama, tbStok.sRenk,  tbStok.sBeden, tbStok.sModel,tbStok.sBirimCinsi1, tbMusteri.nMusteriID,tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri FROM         aStokPaketAktarim tbAktarim INNER JOIN tbStokBarkodu ON tbAktarim.sBarkod = tbStokBarkodu.sBarkod INNER JOIN tbStok ON tbStokBarkodu.nStokID = tbStok.nStokID INNER JOIN  tbMusteri ON tbAktarim.lKodu = tbMusteri.lKodu Order by tbAktarim.lKodu"))
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub txt_musteriNo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musteriNo.ButtonClick
        OpenFileDialog1.Filter = "Aktarým Dosyalarý(*.SAY) |*.SAY"
        OpenFileDialog1.InitialDirectory = "C:\NEBIM900\NEBIME"
        OpenFileDialog1.FileName = "C:\NEBIM900\NEBIME\TES.SAY"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_musteriNo.Text = OpenFileDialog1.FileName.ToString
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        If Trim(txt_musteriNo.Text) <> "" Then
            Try
                dosya_ac(Trim(txt_musteriNo.Text))
            Catch ex As Exception
                XtraMessageBox.Show(Sorgu_sDil("Dosya Eriþim Hatasý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub
    Private Sub dataload_tbDepo()
        txt_sMagaza.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo, sAciklama FROM         tbDepo Where sDepo <> '' ")).Tables(0)
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Function sorgu(ByVal query As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
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
    Private Sub dataload_aStokPaketAktarim(ByVal query As String)
        Try
            DataSet1.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim N As Integer = adapter.Fill(DataSet1.Tables(0))
        con.Close()
    End Sub
    Private Sub aStokPaketAktarim_kaydet_yeni(ByVal lKodu As String, ByVal sBarkod As String, ByVal lMiktar As Decimal, ByVal dteKayitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO aStokPaketAktarim (lKodu, sBarkod, lMiktar, dteKayitTarihi) VALUES     ('" & lKodu & "', '" & sBarkod & "', " & lMiktar & ", '" & dteKayitTarihi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub aStokPaketAktarim_kaydet_sil()
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED TRUNCATE TABLE aStokPaketAktarim ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function sorgu_baslik_kontrol(ByVal tarih As DateTime, ByVal fistarihi As DateTime, ByVal izahat As String, ByVal firmakodu As String, ByVal fisno As String, ByVal DEPO As String) As Int64
        Dim kriter
        kriter = "WHERE (FISTARIHI = '" & fistarihi & "') AND (FIRMAKODU = '" & firmakodu & "') AND (FISNO = '" & fisno & "') AND (IZAHAT = '" & izahat & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(IND, 0) AS KAYIT  FROM         ASTOKPAKETBASLIK " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_hareket_kontrol(ByVal IND As String, ByVal BARCODE As String) As Int64
        Dim kriter
        kriter = "WHERE EVRAKNO = '" & IND & "' AND  BARCODE = '" & BARCODE & "' "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(IND, 0) AS KAYIT  FROM         ASTOKPAKETDETAY " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub kontrol()
        Dim dr As DataRow
        Dim sayi = DataSet1.Tables(0).Rows.Count
        bar1.Properties.Maximum = sayi
        bar1.Position = 0
        Dim lKodu As String = ""
        For Each dr In DataSet1.Tables(0).Rows
            ds_detay = sorgu_hareket(DateEdit1.EditValue, "PF", dr("lKodu"), dr("lKodu"))
            If ds_detay.Tables(0).Rows.Count > 0 Then
                dr("nStokFisiID") = sorgu_baslik_kontrol(DateEdit1.EditValue, DateEdit1.EditValue, "PF", dr("lKodu"), dr("lKodu"), "")
                If dr("nStokFisiID") > 0 Then
                    If lKodu.ToString <> dr("lKodu").ToString Then
                        loaded(dr("nStokFisiID"))
                        lKodu = dr("lKodu").ToString
                    End If
                    loaded(dr("nStokFisiID"))
                    If dr("lMiktar") <= stok_kontrol_miktar(dr("sBarkod"), dr("lMiktar"), 0) Then
                        dr("nHareketID") = hareket_kaydet_yeni(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FISNO"), dr_baslik("IZAHAT"), dr_baslik("FISTARIHI"), dr("nStokID"), dr("sStokKodu"), dr("sStokAciklama"), dr("sBarkod"), dr("sRenk"), dr("sBeden"), dr("sModel"), dr("lMiktar"), txt_sMagaza.EditValue, 1, 0, "", 1)
                        dr("sAciklama") = "Aktarýldý"
                    Else
                        dr("nHareketID") = sorgu_hareket_kontrol(dr("nStokFisiID"), dr("sBarkod"))
                        If dr("nHareketID") > 0 Then
                            dr("sAciklama") = "Aktarýlmýþ"
                        Else
                            dr("sAciklama") = "Listede Yok"
                        End If
                    End If
                    dr("lTeslimEdilecek") = stok_kontrol_miktar(dr("sBarkod"), dr("lMiktar"), 1)
                    dr("lTeslimEdilen") = stok_kontrol_miktar(dr("sBarkod"), dr("lMiktar"), 2)
                Else
                    Dim belgeno As String = ""
                    Try
                        belgeno = belgeno_kontrol(dataload_belgeno().ToString).ToString
                    Catch ex As Exception
                        belgeno = "A-000001"
                    End Try
                    dr("nStokFisiID") = baslik_kaydet_yeni(dr("nMusteriID"), dr("lKodu").ToString, dr("Musteri").ToString, dr("sAdi").ToString, dr("sSoyadi").ToString, belgeno.ToString, DateEdit1.EditValue, DateEdit1.EditValue, "PF", dr("lKodu").ToString, txt_sMagaza.Text, "AKTARIM", "", "", "", "", "", 0, Now, 0, 0, Now)
                    loaded(dr("nStokFisiID"))
                    If dr("lMiktar") <= stok_kontrol_miktar(dr("sBarkod"), dr("lMiktar"), 0) Then
                        dr("nHareketID") = hareket_kaydet_yeni(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FISNO"), dr_baslik("IZAHAT"), dr_baslik("FISTARIHI"), dr("nStokID"), dr("sStokKodu"), dr("sStokAciklama"), dr("sBarkod"), dr("sRenk"), dr("sBeden"), dr("sModel"), dr("lMiktar"), txt_sMagaza.EditValue, 1, 0, "", 1)
                        dr("sAciklama") = "Aktarýldý"
                    Else
                        dr("nHareketID") = sorgu_hareket_kontrol(dr("nStokFisiID"), dr("sBarkod"))
                        If dr("nHareketID") > 0 Then
                            dr("sAciklama") = "Aktarýlmýþ"
                        Else
                            dr("sAciklama") = "Listede Yok"
                        End If
                    End If
                    dr("lTeslimEdilecek") = stok_kontrol_miktar(dr("sBarkod"), dr("lMiktar"), 1)
                    dr("lTeslimEdilen") = stok_kontrol_miktar(dr("sBarkod"), dr("lMiktar"), 2)
                End If
                loaded(dr("nStokFisiID"))
                toplam_hesapla()
                Dim dr1 As DataRow = ds_detay.Tables(0).Rows(0)
                baslik_kaydet_degistir(dr_baslik("IND"), dr_baslik("FIRMANO"), dr_baslik("FIRMAKODU"), dr_baslik("FIRMAADI"), dr_baslik("ADI"), dr_baslik("SOYADI"), dr_baslik("BELGENO"), dr_baslik("FISTARIHI"), dr_baslik("TARIH"), dr_baslik("IZAHAT"), dr_baslik("FISNO"), dr_baslik("DEPO"), "AKTARIM", dr_baslik("KOD2"), dr_baslik("KOD3"), dr_baslik("KOD4"), dr_baslik("KOD5"), dr_baslik("ACIKLAMA"), dr_baslik("USERNO"), dr_baslik("KAYITTARIHI"), detay_miktar, miktar, dr1("dteKayitTarihi"))
                dr1 = Nothing
            Else
                dr("sAciklama") = "Fiþ Bulunamadý..."
            End If
            bar1.Position += 1
            bar1.Refresh()
        Next
        bar1.Position = 0
        bar1.Refresh()
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub stok_duzelt()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_paket
            frm.connection = connection
            frm.firmano = firmano
            frm.donemno = donemno
            frm.belgeind = dr("nStokFisiID")
            frm.status = True
            frm.kullanici = kullanici
            frm.ShowDialog()
            frm.Close()
            frm.Dispose()
            frm = Nothing
            Dim satir = GridView1.FocusedRowHandle
            GridView1.FocusedRowHandle = satir
            satir = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_envanter()
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_stok_envanter
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.stokno = dr("nStokID")
        frm.stokkodu = dr("sStokKodu")
        frm.kullanici = kullanici
        frm.ShowDialog()
        frm.Close()
        frm.Dispose()
        frm = Nothing
        dr = Nothing
    End Sub
    Private Sub loaded(ByVal IND As String)
        dataload_baslik(IND)
        dataload_harekets(IND)
        dr_baslik = ds_baslik.Tables(0).Rows(0)
        'ds_detay = sorgu_hareket(dr_baslik("FISTARIHI"), dr_baslik("IZAHAT"), dr_baslik("FIRMAKODU"), dr_baslik("FISNO"))
    End Sub
    Private Sub dataload_baslik(ByVal IND As String)
        Try
            ds_baslik.Tables(0).Clear()
        Catch ex As Exception
        End Try
        ds_baslik = sorgu_baslik(IND)
    End Sub
    Private Function sorgu_baslik(ByVal IND As String) As DataSet
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM ASTOKPAKETBASLIK WHERE IND ='" & IND & "'")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        Return DS
    End Function
    Private Sub dataload_harekets(ByVal IND As String)
        ds_hareket = sorgu_harekets(IND)
    End Sub
    Private Function sorgu_harekets(ByVal IND As String) As DataSet
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         ASTOKPAKETDETAY WHERE EVRAKNO =" & IND & "")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "HAREKET")
        con.Close()
        Return DS
    End Function
    Private Function baslik_kaydet_yeni(ByVal FIRMANO As Int64, ByVal FIRMAKODU As String, ByVal FIRMAADI As String, ByVal ADI As String, ByVal SOYADI As String, ByVal BELGENO As String, ByVal FISTARIHI As DateTime, ByVal TARIH As DateTime, ByVal IZAHAT As String, ByVal FISNO As String, ByVal DEPO As String, ByVal KOD1 As String, ByVal KOD2 As String, ByVal KOD3 As String, ByVal KOD4 As String, ByVal KOD5 As String, ByVal ACIKLAMA As String, ByVal USERNO As Int64, ByVal KAYITTARIHI As DateTime, ByVal MIKTAR As Decimal, ByVal TESLIMAT As Decimal, ByVal FISKAYITTARIHI As DateTime) As Int64
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO ASTOKPAKETBASLIK (FIRMANO, FIRMAKODU, FIRMAADI,ADI, SOYADI, BELGENO, FISTARIHI, TARIH, IZAHAT, FISNO, DEPO, KOD1, KOD2, KOD3, KOD4, KOD5, ACIKLAMA, USERNO, KAYITTARIHI, MIKTAR,TESLIMAT,FISKAYITTARIHI) VALUES     (" & FIRMANO & ", '" & FIRMAKODU & "', '" & FIRMAADI & "','" & ADI & "', '" & SOYADI & "', '" & BELGENO & "', '" & FISTARIHI & "', '" & TARIH & "', '" & IZAHAT & "', '" & FISNO & "', '" & DEPO & "', '" & KOD1 & "', '" & KOD2 & "', '" & KOD3 & "', '" & KOD4 & "', '" & KOD5 & "', '" & ACIKLAMA & "', " & USERNO & ",  '" & KAYITTARIHI & "', " & MIKTAR & "," & TESLIMAT & ",'" & FISKAYITTARIHI & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
    End Function
    Private Function hareket_kaydet_yeni(ByVal EVRAKNO As Int64, ByVal FIRMANO As Int64, ByVal FISNO As String, ByVal IZAHAT As String, ByVal TARIH As DateTime, ByVal STOKNO As Int64, ByVal STOKKODU As String, ByVal MALINCINSI As String, ByVal BARCODE As String, ByVal RENK As String, ByVal BEDEN As String, ByVal MODEL As String, ByVal MIKTAR As Decimal, ByVal DEPO As String, ByVal MEVCUT As Byte, ByVal HATA As Byte, ByVal ACIKLAMA As String, ByVal okut As Byte) As Int64
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.ConnectionString = connection
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO ASTOKPAKETDETAY (EVRAKNO, FIRMANO, FISNO, IZAHAT, TARIH, STOKNO, STOKKODU, MALINCINSI, BARCODE, RENK, BEDEN, MODEL, MIKTAR, DEPO, MEVCUT, HATA, ACIKLAMA,OKUT) VALUES     (" & EVRAKNO & ", " & FIRMANO & ", '" & FISNO & "', '" & Trim(IZAHAT) & "', '" & TARIH & "', " & STOKNO & ", '" & STOKKODU & "', '" & MALINCINSI & "', '" & BARCODE & "', '" & RENK & "', '" & BEDEN & "', '" & MODEL & "', " & MIKTAR & ", '" & Trim(DEPO) & "', " & MEVCUT & ", " & HATA & ", '" & ACIKLAMA & "'," & okut & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
    End Function
    Private Sub baslik_kaydet_degistir(ByVal evrakno As Int64, ByVal FIRMANO As Int64, ByVal FIRMAKODU As String, ByVal FIRMAADI As String, ByVal ADI As String, ByVal SOYADI As String, ByVal BELGENO As String, ByVal FISTARIHI As DateTime, ByVal TARIH As DateTime, ByVal IZAHAT As String, ByVal FISNO As String, ByVal DEPO As String, ByVal KOD1 As String, ByVal KOD2 As String, ByVal KOD3 As String, ByVal KOD4 As String, ByVal KOD5 As String, ByVal ACIKLAMA As String, ByVal USERNO As Int64, ByVal KAYITTARIHI As DateTime, ByVal MIKTAR As Decimal, ByVal TESLIMAT As Decimal, ByVal FISKAYITTARIHI As DateTime)
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.ConnectionString = connection
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    ASTOKPAKETBASLIK SET              FIRMANO = " & FIRMANO & ", FIRMAKODU = '" & FIRMAKODU & "', FIRMAADI ='" & FIRMAADI & "',ADI = '" & ADI & "', SOYADI = '" & SOYADI & "', BELGENO = '" & BELGENO & "', FISTARIHI = '" & FISTARIHI & "',FISKAYITTARIHI = '" & FISKAYITTARIHI & "', KAYITTARIHI = '" & KAYITTARIHI & "',TARIH = '" & TARIH & "',IZAHAT = '" & IZAHAT & "', FISNO = '" & FISNO & "', DEPO = '" & DEPO & "', KOD1 = '" & KOD1 & "', KOD2 = '" & KOD2 & "', KOD3 = '" & KOD3 & "', KOD4 = '" & KOD4 & "', KOD5 = '" & KOD5 & "', ACIKLAMA = '" & ACIKLAMA & "', USERNO = " & USERNO & ", MIKTAR = " & MIKTAR & ",TESLIMAT =" & TESLIMAT & " WHERE IND = " & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub hareket_kaydet_degistir(ByVal ind As Int64, ByVal EVRAKNO As Int64, ByVal FIRMANO As Int64, ByVal FISNO As String, ByVal IZAHAT As String, ByVal TARIH As DateTime, ByVal STOKNO As Int64, ByVal STOKKODU As String, ByVal MALINCINSI As String, ByVal BARCODE As String, ByVal RENK As String, ByVal BEDEN As String, ByVal MODEL As String, ByVal MIKTAR As Decimal, ByVal DEPO As String, ByVal MEVCUT As Byte, ByVal HATA As Byte, ByVal ACIKLAMA As String, ByVal okut As Byte)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    ASTOKPAKETDETAY SET              EVRAKNO = " & EVRAKNO & ", FIRMANO = " & FIRMANO & ", FISNO = '" & FISNO & "', IZAHAT = '" & IZAHAT & "', TARIH = '" & TARIH & "', STOKNO = " & STOKNO & ", STOKKODU = '" & STOKKODU & "', MALINCINSI = '" & MALINCINSI & "', BARCODE = '" & BARCODE & "', RENK = '" & RENK & "', BEDEN = '" & BEDEN & "', MODEL = '" & MODEL & "', MIKTAR = " & MIKTAR & ", DEPO = '" & DEPO & "', MEVCUT = " & MEVCUT & ", HATA = " & HATA & ",OKUT =" & okut & ", ACIKLAMA = '" & ACIKLAMA & "' WHERE IND = " & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub baslik_kaydet_sil(ByVal evrakno As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM ASTOKPAKETBASLIK  WHERE IND = " & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub hareket_kaydet_sil(ByVal evrakno As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM ASTOKPAKETDETAY  WHERE IND = " & evrakno & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_hareket(ByVal tarih As DateTime, ByVal izahat As String, ByVal firmakodu As String, ByVal fisno As String) As DataSet
        Dim kriter
        Dim kriter2 = ""
        kriter = "WHERE (Hareket.dteFisTarihi = '" & tarih & "') AND (Musteri.lKodu = '" & firmakodu & "') AND (Hareket.lFisNo = " & fisno & ") AND (Hareket.sFisTipi = '" & izahat & "') "
        'ds_iade = sorgu_iade_fisler(dr_baslik("FISTARIHI"), dr_baslik("IZAHAT"), dr_baslik("FIRMAKODU"), dr_baslik("FISNO"))
        'Dim dr1 As DataRow
        'For Each dr1 In ds_iade.Tables(0).Rows
        '    kriter2 += " UNION ALL SELECT Hareket.dteKayitTarihi,Hareket.dteFisTarihi AS TARIH, Musteri.nMusteriID AS FIRMANO, Musteri.lKodu AS FIRMAKODU, Hareket.lFisNo AS FISNO, Musteri.sAdi AS ADI, Musteri.sSoyadi AS SOYADI, Hareket.lFisNo AS FISNO, Hareket.sDepo AS DEPONO, Stok.sKodu AS STOKKODU, Stok.sAciklama AS MALINCINSI, tbStokBarkodu.sBarkod AS BARKOD, tbRenk.sRenkAdi AS RENK, Hareket.lCikisMiktar1 AS MIKTAR, Stok.sModel AS MODEL, Hareket.sFisTipi AS IZAHAT, Hareket.sSaticiRumuzu AS SATICI, Hareket.sKasiyerRumuzu AS KASIYER, Hareket.nIslemID AS IND FROM tbStokFisiDetayi Hareket INNER JOIN tbMusteri Musteri ON Hareket.nMusteriID = Musteri.nMusteriID INNER JOIN tbStok Stok ON Hareket.nStokID = Stok.nStokID INNER JOIN tbStokBarkodu ON Stok.nStokID = tbStokBarkodu.nStokID INNER JOIN tbRenk ON Stok.sRenk = tbRenk.sRenk WHERE Hareket.nAlisVerisID = '" & dr1("nAlisVerisID") & "' "
        'Next
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Hareket.dteKayitTarihi,Hareket.dteFisTarihi AS TARIH, Musteri.nMusteriID AS FIRMANO, Musteri.lKodu AS FIRMAKODU, Hareket.lFisNo AS FISNO, Musteri.sAdi AS ADI, Musteri.sSoyadi AS SOYADI, Hareket.lFisNo AS FISNO, Hareket.sDepo AS DEPONO, Stok.sKodu AS STOKKODU, Stok.sAciklama AS MALINCINSI, tbStokBarkodu.sBarkod AS BARKOD, tbRenk.sRenkAdi AS RENK, Hareket.lCikisMiktar1 AS MIKTAR, Stok.sModel AS MODEL, Hareket.sFisTipi AS IZAHAT, Hareket.sSaticiRumuzu AS SATICI, Hareket.sKasiyerRumuzu AS KASIYER, Hareket.nIslemID AS IND FROM tbStokFisiDetayi Hareket INNER JOIN tbMusteri Musteri ON Hareket.nMusteriID = Musteri.nMusteriID INNER JOIN tbStok Stok ON Hareket.nStokID = Stok.nStokID INNER JOIN tbStokBarkodu ON Stok.nStokID = tbStokBarkodu.nStokID INNER JOIN tbRenk ON Stok.sRenk = tbRenk.sRenk " & kriter & " " & kriter2 & "")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
        kriter = Nothing
        kriter2 = Nothing
    End Function
    Public Function sorgu_iade_fisler(ByVal tarih As DateTime, ByVal izahat As String, ByVal firmakodu As String, ByVal fisno As String) As DataSet
        Dim kriter
        kriter = "WHERE (Hareket.dteFaturaTarihi = '" & tarih & "') AND (Musteri.lKodu = '" & firmakodu & "') AND (Hareket.lFaturaNo = " & fisno & ") AND (Hareket.sFisTipi = '" & izahat & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     DISTINCT tbOdeme.nAlisverisID FROM         tbOdeme INNER JOIN                       tbAlisVeris Hareket ON tbOdeme.nIadeAlisverisID = Hareket.nAlisverisID INNER JOIN tbMusteri Musteri ON Hareket.nMusteriID = Musteri.nMusteriID " & kriter & "")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub toplam_hesapla()
        Dim dr As DataRow
        miktar = 0
        detay_miktar = 0
        For Each dr In ds_hareket.Tables(0).Rows
            miktar = miktar + dr("MIKTAR")
        Next
        For Each dr In ds_detay.Tables(0).Rows
            detay_miktar = detay_miktar + dr("MIKTAR")
        Next
        Try
            If dr_baslik("lKodu") = 0 Then
                Label1.Text = "Yeni Paket Fiþi" & vbCrLf & "Lütfen Teslim Fiþi Bilgilerini Girin...!"
                Me.Label1.ForeColor = System.Drawing.Color.Red
                Label1.BackColor = System.Drawing.Color.White
            Else
                Dim fark As Decimal = detay_miktar - miktar
                If fark = 0 Then
                    Label1.Text = "Teslimat Bitti..!" & vbCrLf & "Yeni Belge Açýn"
                    Me.Label1.ForeColor = System.Drawing.Color.Black
                    Label1.BackColor = System.Drawing.Color.White
                ElseIf fark > 0 Then
                    Label1.Text = "Kalan Teslim Edilecek Ürün Sayýsý : " & vbCrLf & FormatNumber(Math.Abs(fark), 2)
                    Me.Label1.ForeColor = System.Drawing.Color.Blue
                    Label1.BackColor = System.Drawing.Color.Yellow
                ElseIf fark < 0 Then
                    Label1.Text = "Fazla Teslim Edilen Ürün Sayýsý : " & vbCrLf & FormatNumber(Math.Abs(fark), 2)
                    Me.Label1.ForeColor = System.Drawing.Color.Red
                    Label1.BackColor = System.Drawing.Color.Yellow
                End If
            End If
            If Label1.Visible = False Then
                Label1.Visible = True
            Else
                Label1.Visible = False
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Function stok_kontrol_miktar(ByVal stokkodu As String, ByVal miktar As Decimal, Optional ByVal islem As Integer = 0) As Decimal
        Dim dr As DataRow
        Dim DR1 As DataRow
        Dim sayi As Decimal = 0
        Dim satis_miktar As Decimal = 0
        For Each dr In ds_detay.Tables(0).Rows
            If Trim(dr("BARKOD")) = Trim(stokkodu) Then
                satis_miktar += dr("MIKTAR")
            End If
        Next
        Dim teslim_miktar As Decimal = 0
        For Each DR1 In ds_hareket.Tables(0).Rows
            If Trim(DR1("BARCODE")) = Trim(stokkodu) Then
                teslim_miktar += DR1("MIKTAR")
            End If
        Next
        If islem = 0 Then
            sayi = (satis_miktar - teslim_miktar)
        ElseIf islem = 1 Then
            sayi = satis_miktar
        ElseIf islem = 2 Then
            sayi = teslim_miktar
        End If
        Return sayi
    End Function
    Private Function belgeno_kontrol(ByVal belgeno As String, Optional ByVal islem As Integer = 0) As String
        Dim seri
        Dim no
        Dim evrak_no
        evrak_no = belgeno
        evrak_no = evrak_no.Replace(0, "")
        evrak_no = evrak_no.Replace(1, "")
        evrak_no = evrak_no.Replace(2, "")
        evrak_no = evrak_no.Replace(3, "")
        evrak_no = evrak_no.Replace(4, "")
        evrak_no = evrak_no.Replace(5, "")
        evrak_no = evrak_no.Replace(6, "")
        evrak_no = evrak_no.Replace(7, "")
        evrak_no = evrak_no.Replace(8, "")
        evrak_no = evrak_no.Replace(9, "")
        'txtbelgeseri.EditValue = evrak_no
        seri = evrak_no
        If evrak_no = "" Then
            seri = "A-"
        End If
        evrak_no = belgeno
        evrak_no = evrak_no.Replace("A", "")
        evrak_no = evrak_no.Replace("B", "")
        evrak_no = evrak_no.Replace("C", "")
        evrak_no = evrak_no.Replace("Ç", "")
        evrak_no = evrak_no.Replace("D", "")
        evrak_no = evrak_no.Replace("E", "")
        evrak_no = evrak_no.Replace("F", "")
        evrak_no = evrak_no.Replace("G", "")
        evrak_no = evrak_no.Replace("H", "")
        evrak_no = evrak_no.Replace("I", "")
        evrak_no = evrak_no.Replace("Ý", "")
        evrak_no = evrak_no.Replace("J", "")
        evrak_no = evrak_no.Replace("K", "")
        evrak_no = evrak_no.Replace("L", "")
        evrak_no = evrak_no.Replace("M", "")
        evrak_no = evrak_no.Replace("N", "")
        evrak_no = evrak_no.Replace("O", "")
        evrak_no = evrak_no.Replace("Ö", "")
        evrak_no = evrak_no.Replace("P", "")
        evrak_no = evrak_no.Replace("R", "")
        evrak_no = evrak_no.Replace("S", "")
        evrak_no = evrak_no.Replace("Þ", "")
        evrak_no = evrak_no.Replace("T", "")
        evrak_no = evrak_no.Replace("U", "")
        evrak_no = evrak_no.Replace("Ü", "")
        evrak_no = evrak_no.Replace("V", "")
        evrak_no = evrak_no.Replace("Y", "")
        evrak_no = evrak_no.Replace("Z", "")
        evrak_no = evrak_no.Replace("X", "")
        evrak_no = evrak_no.Replace("W", "")
        evrak_no = evrak_no.Replace("_", "")
        evrak_no = evrak_no.Replace("-", "")
        evrak_no = evrak_no.Replace("*", "")
        evrak_no = evrak_no.Replace("/", "")
        evrak_no = evrak_no.Replace("+", "")
        Try
            If islem = 0 Then
                no = CType(evrak_no, Integer) + 1
            Else
                no = CType(evrak_no, Integer)
            End If
            no = columnuzunlukinteger_sifir(no.ToString, 6)
            belgeno = seri + no.ToString
        Catch ex As Exception
            belgeno = seri + columnuzunlukinteger_sifir(1, 6)
        End Try
        Return belgeno
    End Function
    Private Function dataload_belgeno() As String
        Dim sonuc
        Try
            con.ConnectionString = connection
            cmd.Connection = con
            con.Open()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(BELGENO,'A-000001') AS BELGENO FROM ASTOKPAKETBASLIK WHERE IND = (SELECT ISNULL(MAX(IND),0) FROM ASTOKPAKETBASLIK  WHERE  BELGENO LIKE 'A%')")
            sonuc = cmd.ExecuteScalar
            con.Close()
            If CStr(sonuc).ToString = "" Then
                sonuc = "A-000000"
            End If
        Catch ex As Exception
            sonuc = "A-000000"
        End Try
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Return sonuc
        sonuc = Nothing
    End Function
    Private Function columnuzunlukinteger_sifir(ByVal deger As String, ByVal uzunluk As Integer) As String
        Dim stringhedef = Trim(deger)
        Dim hedefuzunluk = Len(stringhedef)
        If Len(stringhedef) < uzunluk Then
            Dim fark = uzunluk - hedefuzunluk
            Dim i As Integer
            For i = 1 To fark
                stringhedef = stringhedef.Insert(0, "0")
            Next
            fark = Nothing
            i = Nothing
        Else
            stringhedef = Microsoft.VisualBasic.Left(stringhedef, uzunluk)
        End If
        Return stringhedef
    End Function
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If status = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Me.Close()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        If MenuItem5.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsView.ShowAutoFilterRow = True
            MenuItem5.Checked = True
        ElseIf MenuItem5.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsView.ShowAutoFilterRow = False
            MenuItem5.Checked = False
        End If
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        If MenuItem8.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            MenuItem8.Checked = True
        ElseIf MenuItem8.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            MenuItem8.Checked = False
        End If
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If MenuItem9.Checked = False Then
            GridView1.OptionsCustomization.AllowGroup = True
            GridView1.OptionsView.ShowGroupPanel = True
            MenuItem9.Checked = True
        ElseIf MenuItem9.Checked = True Then
            GridView1.OptionsCustomization.AllowGroup = False
            GridView1.OptionsView.ShowGroupPanel = False
            MenuItem9.Checked = False
        End If
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        If XtraMessageBox.Show(Sorgu_sDil("Kontrollü Aktarým Ýþlemine Baþlamak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            kontrol()
        End If
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        stok_duzelt()
    End Sub
    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        analiz_envanter()
    End Sub
End Class
