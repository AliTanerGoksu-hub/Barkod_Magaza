Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_emir_kasa_mahsup
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
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents collBorcTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAlacakTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnFirmaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBAKIYE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMAADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteIslemTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvrakNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHangiUygulama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHareketTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKullaniciAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizMiktari1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizKuru1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizMiktari2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizKuru2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteValorTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_uygulama As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_firmakod As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_emir_kasa_mahsup))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
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
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
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
        Me.collBorcTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collAlacakTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnFirmaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBAKIYE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRMAADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteIslemTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEvrakNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsHangiUygulama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsHareketTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKullaniciAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDovizCinsi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizMiktari1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizKuru1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDovizCinsi2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizMiktari2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizKuru2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteValorTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_firmakod = New DevExpress.XtraEditors.ButtonEdit()
        Me.sec_uygulama = New DevExpress.XtraEditors.ComboBoxEdit()
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
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
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.txt_firmakod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_uygulama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kasiyer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 22)
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
        Me.PanelControl2.Controls.Add(Me.lbl_istihbarat)
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Controls.Add(Me.SimpleButton4)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 351)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 56)
        Me.PanelControl2.TabIndex = 1
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_istihbarat.Location = New System.Drawing.Point(2, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(71, 13)
        Me.lbl_istihbarat.TabIndex = 10
        Me.lbl_istihbarat.Text = "*Ýstihbarat*"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(88, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(8, 27)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton4.TabIndex = 8
        Me.SimpleButton4.Text = "&Yazdýr"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(736, 27)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(656, 27)
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
        Me.PanelControl3.Location = New System.Drawing.Point(0, 78)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 273)
        Me.PanelControl3.TabIndex = 0
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.GridControl1)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl5.Location = New System.Drawing.Point(2, 57)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(820, 214)
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
        Me.GridControl1.Size = New System.Drawing.Size(816, 210)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem20, Me.MenuItem19, Me.MenuItem15, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7, Me.MenuItem8, Me.MenuItem16, Me.MenuItem4, Me.MenuItem9, Me.MenuItem10, Me.MenuItem17, Me.MenuItem11, Me.MenuItem12, Me.MenuItem18, Me.MenuItem13})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem1.Text = "Ara"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "Kasa/Kasiyer Raporu"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem3.Text = "Firma Kartý"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 3
        Me.MenuItem20.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 4
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
        Me.MenuItem15.Index = 5
        Me.MenuItem15.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 6
        Me.MenuItem5.Text = "Görünümü Düzenle"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 7
        Me.MenuItem6.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 8
        Me.MenuItem7.Text = "Görünümü Kaydet"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 9
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem8.Text = "Görünümü Yazdýr"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 10
        Me.MenuItem16.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 11
        Me.MenuItem4.Text = "Hýzlý Filtre"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 12
        Me.MenuItem9.Text = "Filtrele"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 13
        Me.MenuItem10.Text = "Gruplandýr"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 14
        Me.MenuItem17.Text = "-"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 15
        Me.MenuItem11.Text = "Satýrlarý Aç"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 16
        Me.MenuItem12.Text = "Satýrlarý Kapat"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 17
        Me.MenuItem18.Text = "-"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 18
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
        Me.DataColumn1.ColumnName = "lBorcTutar"
        Me.DataColumn1.DataType = GetType(Decimal)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "lAlacakTutar"
        Me.DataColumn2.DataType = GetType(Decimal)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "nFirmaID"
        Me.DataColumn3.DataType = GetType(Long)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sKodu"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sAciklama"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "KOD"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "BAKIYE"
        Me.DataColumn7.DataType = GetType(Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "FIRMAADI"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "dteIslemTarihi"
        Me.DataColumn9.DataType = GetType(Date)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "sEvrakNo"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sHangiUygulama"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sHareketTipi"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "sKullaniciAdi"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sDovizCinsi1"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "lDovizMiktari1"
        Me.DataColumn15.DataType = GetType(Decimal)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "lDovizKuru1"
        Me.DataColumn16.DataType = GetType(Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "sDovizCinsi2"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "lDovizMiktari2"
        Me.DataColumn18.DataType = GetType(Decimal)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "lDovizKuru2"
        Me.DataColumn19.DataType = GetType(Decimal)
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "dteValorTarihi"
        Me.DataColumn20.DataType = GetType(Date)
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
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.collBorcTutar, Me.collAlacakTutar, Me.colnFirmaID, Me.colsKodu, Me.colsAciklama, Me.colKOD, Me.colBAKIYE, Me.colFIRMAADI, Me.coldteIslemTarihi, Me.colsEvrakNo, Me.colsHangiUygulama, Me.colsHareketTipi, Me.colsKullaniciAdi, Me.colsDovizCinsi1, Me.collDovizMiktari1, Me.collDovizKuru1, Me.colsDovizCinsi2, Me.collDovizMiktari2, Me.collDovizKuru2, Me.coldteValorTarihi})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(816, 320, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TARIH", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacaktutar", Nothing, "Giren: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcTutar", Nothing, "Çýkan: {0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteIslemTarihi", Me.coldteIslemTarihi, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcTutar", Me.collBorcTutar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacaktutar", Me.collAlacakTutar, "{0:#,0.00}")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'collBorcTutar
        '
        Me.collBorcTutar.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.collBorcTutar.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.collBorcTutar.AppearanceCell.Options.UseFont = True
        Me.collBorcTutar.AppearanceCell.Options.UseForeColor = True
        Me.collBorcTutar.Caption = "Çýkan"
        Me.collBorcTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collBorcTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBorcTutar.FieldName = "lBorcTutar"
        Me.collBorcTutar.Name = "collBorcTutar"
        Me.collBorcTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorcTutar", "{0:#,0.00}")})
        Me.collBorcTutar.Visible = True
        Me.collBorcTutar.VisibleIndex = 8
        Me.collBorcTutar.Width = 72
        '
        'collAlacakTutar
        '
        Me.collAlacakTutar.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.collAlacakTutar.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.collAlacakTutar.AppearanceCell.Options.UseFont = True
        Me.collAlacakTutar.AppearanceCell.Options.UseForeColor = True
        Me.collAlacakTutar.Caption = "Giren"
        Me.collAlacakTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collAlacakTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collAlacakTutar.FieldName = "lAlacaktutar"
        Me.collAlacakTutar.Name = "collAlacakTutar"
        Me.collAlacakTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacaktutar", "{0:#,0.00}")})
        Me.collAlacakTutar.Visible = True
        Me.collAlacakTutar.VisibleIndex = 7
        Me.collAlacakTutar.Width = 62
        '
        'colnFirmaID
        '
        Me.colnFirmaID.Caption = "Firma Kayýt No"
        Me.colnFirmaID.FieldName = "nFirmaID"
        Me.colnFirmaID.Name = "colnFirmaID"
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Firma Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 4
        Me.colsKodu.Width = 58
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Açýklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 6
        Me.colsAciklama.Width = 125
        '
        'colKOD
        '
        Me.colKOD.Caption = "Kodlama"
        Me.colKOD.FieldName = "KOD"
        Me.colKOD.Name = "colKOD"
        Me.colKOD.Visible = True
        Me.colKOD.VisibleIndex = 3
        Me.colKOD.Width = 36
        '
        'colBAKIYE
        '
        Me.colBAKIYE.Caption = "Bakiye"
        Me.colBAKIYE.DisplayFormat.FormatString = "{0:#,#0.00(B);#,#0.00(A);-}"
        Me.colBAKIYE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBAKIYE.FieldName = "BAKIYE"
        Me.colBAKIYE.Name = "colBAKIYE"
        Me.colBAKIYE.Visible = True
        Me.colBAKIYE.VisibleIndex = 9
        Me.colBAKIYE.Width = 92
        '
        'colFIRMAADI
        '
        Me.colFIRMAADI.Caption = "Firma Adý"
        Me.colFIRMAADI.FieldName = "FIRMAADI"
        Me.colFIRMAADI.Name = "colFIRMAADI"
        Me.colFIRMAADI.Visible = True
        Me.colFIRMAADI.VisibleIndex = 5
        Me.colFIRMAADI.Width = 83
        '
        'coldteIslemTarihi
        '
        Me.coldteIslemTarihi.Caption = "Tarih"
        Me.coldteIslemTarihi.FieldName = "dteIslemTarihi"
        Me.coldteIslemTarihi.Name = "coldteIslemTarihi"
        Me.coldteIslemTarihi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteIslemTarihi", "{0} Kayýt")})
        Me.coldteIslemTarihi.Visible = True
        Me.coldteIslemTarihi.VisibleIndex = 0
        Me.coldteIslemTarihi.Width = 52
        '
        'colsEvrakNo
        '
        Me.colsEvrakNo.Caption = "Evrak No"
        Me.colsEvrakNo.FieldName = "sEvrakNo"
        Me.colsEvrakNo.Name = "colsEvrakNo"
        Me.colsEvrakNo.Width = 145
        '
        'colsHangiUygulama
        '
        Me.colsHangiUygulama.Caption = "Uygulama"
        Me.colsHangiUygulama.FieldName = "sHangiUygulama"
        Me.colsHangiUygulama.Name = "colsHangiUygulama"
        Me.colsHangiUygulama.Visible = True
        Me.colsHangiUygulama.VisibleIndex = 2
        Me.colsHangiUygulama.Width = 35
        '
        'colsHareketTipi
        '
        Me.colsHareketTipi.Caption = "Hareket Tipi"
        Me.colsHareketTipi.FieldName = "sHareketTipi"
        Me.colsHareketTipi.Name = "colsHareketTipi"
        Me.colsHareketTipi.Visible = True
        Me.colsHareketTipi.VisibleIndex = 1
        Me.colsHareketTipi.Width = 29
        '
        'colsKullaniciAdi
        '
        Me.colsKullaniciAdi.Caption = "Kullanýcý Adý"
        Me.colsKullaniciAdi.FieldName = "sKullaniciAdi"
        Me.colsKullaniciAdi.Name = "colsKullaniciAdi"
        '
        'colsDovizCinsi1
        '
        Me.colsDovizCinsi1.Caption = "Döviz Cinsi 1"
        Me.colsDovizCinsi1.FieldName = "sDovizCinsi1"
        Me.colsDovizCinsi1.Name = "colsDovizCinsi1"
        '
        'collDovizMiktari1
        '
        Me.collDovizMiktari1.Caption = "Döviz Miktarý 1"
        Me.collDovizMiktari1.FieldName = "lDovizMiktari1"
        Me.collDovizMiktari1.Name = "collDovizMiktari1"
        '
        'collDovizKuru1
        '
        Me.collDovizKuru1.Caption = "Döviz Kuru 1"
        Me.collDovizKuru1.FieldName = "lDovizKuru1"
        Me.collDovizKuru1.Name = "collDovizKuru1"
        '
        'colsDovizCinsi2
        '
        Me.colsDovizCinsi2.Caption = "Döviz Cinsi 2"
        Me.colsDovizCinsi2.FieldName = "sDovizCinsi2"
        Me.colsDovizCinsi2.Name = "colsDovizCinsi2"
        '
        'collDovizMiktari2
        '
        Me.collDovizMiktari2.Caption = "Döviz Miktarý 2"
        Me.collDovizMiktari2.FieldName = "lDovizMiktari2"
        Me.collDovizMiktari2.Name = "collDovizMiktari2"
        '
        'collDovizKuru2
        '
        Me.collDovizKuru2.Caption = "Döviz Kuru 2"
        Me.collDovizKuru2.FieldName = "lDovizKuru2"
        Me.collDovizKuru2.Name = "collDovizKuru2"
        '
        'coldteValorTarihi
        '
        Me.coldteValorTarihi.Caption = "Valör Tarihi"
        Me.coldteValorTarihi.FieldName = "dteValorTarihi"
        Me.coldteValorTarihi.Name = "coldteValorTarihi"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.LabelControl4)
        Me.PanelControl4.Controls.Add(Me.LabelControl3)
        Me.PanelControl4.Controls.Add(Me.LabelControl2)
        Me.PanelControl4.Controls.Add(Me.LabelControl1)
        Me.PanelControl4.Controls.Add(Me.txt_firmakod)
        Me.PanelControl4.Controls.Add(Me.sec_uygulama)
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
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(489, 26)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl4.TabIndex = 20
        Me.LabelControl4.Text = "Kriter:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(632, 8)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl3.TabIndex = 19
        Me.LabelControl3.Text = "Arasýndaki"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(336, 26)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl2.TabIndex = 18
        Me.LabelControl2.Text = "Hesap:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(336, 8)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl1.TabIndex = 17
        Me.LabelControl1.Text = "Tarih:"
        '
        'txt_firmakod
        '
        Me.txt_firmakod.EnterMoveNextControl = True
        Me.txt_firmakod.Location = New System.Drawing.Point(384, 26)
        Me.txt_firmakod.Name = "txt_firmakod"
        Me.txt_firmakod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_firmakod.Size = New System.Drawing.Size(100, 20)
        Me.txt_firmakod.TabIndex = 14
        '
        'sec_uygulama
        '
        Me.sec_uygulama.EditValue = "[Tümü]"
        Me.sec_uygulama.EnterMoveNextControl = True
        Me.sec_uygulama.Location = New System.Drawing.Point(528, 26)
        Me.sec_uygulama.Name = "sec_uygulama"
        Me.sec_uygulama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_uygulama.Properties.Appearance.Options.UseBackColor = True
        Me.sec_uygulama.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_uygulama.Properties.Items.AddRange(New Object() {"[Tümü]", "Kasa", "Mahsup", "Hareket", "Fatura", "Verilen Çekler", "Ödenen Çekler", "Ödenecek Çekler", "Verilen Senetler", "Ödenen Senetler", "Ödenecek Senetler", "Alýnan Çekler", "Tahsil Edilen Çekler", "Alýnan Senetler", "Tahsilat Edilen Senetler", "Fiyat Farklarý", "Firma Personel Maaþlarý"})
        Me.sec_uygulama.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_uygulama.Size = New System.Drawing.Size(100, 20)
        Me.sec_uygulama.TabIndex = 15
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Enabled = False
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(632, 27)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(100, 20)
        Me.SimpleButton5.TabIndex = 15
        Me.SimpleButton5.Text = "&Listele"
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
        Me.DateEdit2.Location = New System.Drawing.Point(528, 8)
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
        Me.btn_baglan.Size = New System.Drawing.Size(248, 23)
        Me.btn_baglan.TabIndex = 11
        Me.btn_baglan.Text = "&Baðlan"
        '
        'txt_kasiyer
        '
        Me.txt_kasiyer.Enabled = False
        Me.txt_kasiyer.EnterMoveNextControl = True
        Me.txt_kasiyer.Location = New System.Drawing.Point(144, 8)
        Me.txt_kasiyer.Name = "txt_kasiyer"
        Me.txt_kasiyer.Properties.MaxLength = 10
        Me.txt_kasiyer.Size = New System.Drawing.Size(168, 20)
        Me.txt_kasiyer.TabIndex = 10
        '
        'txt_kod
        '
        Me.txt_kod.Location = New System.Drawing.Point(64, 8)
        Me.txt_kod.Name = "txt_kod"
        Me.txt_kod.Properties.MaxLength = 10
        Me.txt_kod.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_kod.Size = New System.Drawing.Size(80, 20)
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
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.BarButtonItem1, Me.BarSubItem2, Me.BarSubItem3, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem15, Me.BarButtonItem16})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 19
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem3)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Custom 3"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Tanýmlar"
        Me.BarSubItem1.Id = 0
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Ödeme Þekli Baðantýlarý"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Kredi Kartlarý Banka Ödeme Raporu"
        Me.BarButtonItem2.Id = 4
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Satýcý Personel Kat Baðlantýlarý"
        Me.BarButtonItem4.Id = 6
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Kredi Kartlarý Banka Ödeme Raporu Detayý"
        Me.BarButtonItem9.Id = 11
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Ýþlemler"
        Me.BarSubItem2.Id = 2
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "Raporlar"
        Me.BarSubItem3.Id = 3
        Me.BarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True)})
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Firma Bekleyen Sipariþleri"
        Me.BarButtonItem5.Id = 7
        Me.BarButtonItem5.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Müþteri Bekleyen Satýþlarý"
        Me.BarButtonItem6.Id = 8
        Me.BarButtonItem6.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Fatura Karlýlýk Analizi"
        Me.BarButtonItem7.Id = 9
        Me.BarButtonItem7.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z))
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Ekstre"
        Me.BarButtonItem8.Id = 10
        Me.BarButtonItem8.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F5))
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Custom 4"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem14, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem15, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem16, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Custom 4"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "*"
        Me.BarButtonItem3.Id = 5
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "Firma Kartý,F4"
        Me.BarButtonItem14.Id = 16
        Me.BarButtonItem14.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem14.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "Kasa/Kasiyer Raporu"
        Me.BarButtonItem15.Id = 17
        Me.BarButtonItem15.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem15.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem15.Name = "BarButtonItem15"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Yazdýr,Ctl+P"
        Me.BarButtonItem10.Id = 12
        Me.BarButtonItem10.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem10.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Excel"
        Me.BarButtonItem11.Id = 13
        Me.BarButtonItem11.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem11.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Text"
        Me.BarButtonItem12.Id = 14
        Me.BarButtonItem12.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem12.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Mail"
        Me.BarButtonItem13.Id = 15
        Me.BarButtonItem13.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem13.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem16
        '
        Me.BarButtonItem16.Caption = "Çýkýþ"
        Me.BarButtonItem16.Id = 18
        Me.BarButtonItem16.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem16.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem16.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape)
        Me.BarButtonItem16.Name = "BarButtonItem16"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 407)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 385)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 385)
        '
        'frm_emir_kasa_mahsup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_emir_kasa_mahsup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kasa Ýþlemleri"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
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
        CType(Me.txt_firmakod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_uygulama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kasiyer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Dim ds_alis As DataSet
    Dim ds_satir_firma As DataSet
    Dim ds_stok_fisi_detay As DataSet
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
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += Microsoft.VisualBasic.Left(DateEdit1.EditValue.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(DateEdit2.EditValue.ToString, 10) & " Tarihleri Arasýndaki Genel Ýþlemler" & vbCrLf
        kriter += " Ýþlemler = " & sec_uygulama.Text & ""
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Financial Managment-Finansman Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\ISEMIRLERI\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
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
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton4.Text = Sorgu_sDil(SimpleButton4.Text, sDil)
        SimpleButton5.Text = Sorgu_sDil(SimpleButton5.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\ISEMIRLERI\" & Me.Name.ToString & "")
    End Sub
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal kasiyerno As String, ByVal uygulama As String)
        Dim kriter As String = ""
        If uygulama = "Ödenecek Çekler" Then
            kriter += " WHERE (tbFirmaHareketi.dteValorTarihi between '" & tarih1 & "' and '" & tarih2 & "')"
        ElseIf uygulama = "Ödenecek Senetler" Then
            kriter += " WHERE (tbFirmaHareketi.dteValorTarihi between '" & tarih1 & "' and '" & tarih2 & "')"
        Else
            kriter += " WHERE (tbFirmaHareketi.dteIslemTarihi between '" & tarih1 & "' and '" & tarih2 & "')"
        End If
        If Trim(kasiyerno) = "VC" Then
        Else
            kriter += " AND tbFirmaHareketi.sKullaniciAdi ='" & kasiyerno & "' "
        End If
        If Trim(txt_firmakod.Text) <> "" Then
            kriter += " AND tbFirma.sKodu like '" & Trim(txt_firmakod.Text) & "%' "
        End If
        If uygulama = "[Tümü]" Then
        ElseIf uygulama = "Kasa" Then
            kriter += " AND tbFirmaHareketi.sHangiUygulama ='KASA' "
        ElseIf uygulama = "Mahsup" Then
            kriter += " AND tbFirmaHareketi.sHangiUygulama ='MUH' "
        ElseIf uygulama = "Hareket" Then
            kriter += " AND tbFirmaHareketi.sHangiUygulama ='' "
        ElseIf uygulama = "Alýnan Çekler" Then
            kriter += " AND tbFirmaHareketi.sHangiUygulama ='AC' and tbFirmaHareketi.lAlacakTutar > 0 "
        ElseIf uygulama = "Tahsil Edilen Çekler" Then
            kriter += " AND tbFirmaHareketi.sHangiUygulama ='AC' and tbFirmaHareketi.lBorcTutar > 0 "
        ElseIf uygulama = "Alýnan Senetler" Then
            kriter += " AND tbFirmaHareketi.sHangiUygulama ='AS' and tbFirmaHareketi.lAlacakTutar > 0"
        ElseIf uygulama = "Tahsil Edilen Senetler" Then
            kriter += " AND tbFirmaHareketi.sHangiUygulama ='AS' and tbFirmaHareketi.lBorcTutar > 0"
        ElseIf uygulama = "Verilen Çekler" Then
            kriter += " AND tbFirmaHareketi.sHangiUygulama ='BC' and tbFirmaHareketi.lBorcTutar > 0 "
        ElseIf uygulama = "Ödenen Çekler" Then
            kriter += " AND tbFirmaHareketi.sHangiUygulama ='BC' and tbFirmaHareketi.lAlacakTutar > 0 "
        ElseIf uygulama = "Ödenecek Çekler" Then
            kriter += " AND tbFirmaHareketi.sHangiUygulama ='BC' and tbFirmaHareketi.lBorcTutar > 0 "
        ElseIf uygulama = "Verilen Senetler" Then
            kriter += " AND tbFirmaHareketi.sHangiUygulama ='BS' and tbFirmaHareketi.lBorcTutar > 0"
        ElseIf uygulama = "Ödenen Senetler" Then
            kriter += " AND tbFirmaHareketi.sHangiUygulama ='BS' and tbFirmaHareketi.lAlacakTutar > 0"
        ElseIf uygulama = "Ödenecek Senetler" Then
            kriter += " AND tbFirmaHareketi.sHangiUygulama ='BS' and tbFirmaHareketi.lBorcTutar > 0"
        ElseIf uygulama = "Fatura" Then
            kriter += " AND tbFirmaHareketi.sHangiUygulama ='FA' "
        ElseIf uygulama = "Fiyat Farklarý" Then
            kriter += " AND tbFirmaHareketi.sCariIslem ='FF' "
        ElseIf uygulama = "Firma Personel Maaþlarý" Then
            kriter += " AND tbFirmaHareketi.sCariIslem ='PM' "
        End If
        'DataSet1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMuhasebeFisi.nFisSiraID AS IND, tbMuhasebeFisi.nHesapID AS HESAPNO, tbMuhasebeFisi.sAciklama AS ACIKLAMA, tbMuhasebeFisi.lGirenMiktar AS GIRENMIKTAR, tbMuhasebeFisi.lCikanMiktar AS CIKANMIKTARI, tbMuhasebeFisi.lBorcTutar AS BORC, tbMuhasebeFisi.lAlacakTutar AS ALACAK, tbMuhasebeFisi.sMasrafYontemi AS MASRAFYONTEMI, tbMuhasebeFisi.nKasaID AS KASANO, tbMuhasebeFisi.nCariHareketID AS CARIHAREKETNO, tbHesapPlani.sKodu AS FIRMAKODU, tbHesapPlani.sAciklama AS FIRMAADI, tbFirmaHareketi.nFirmaID AS FIRMANO, tbFirmaHareketi.sEvrakNo AS EVRAKNO, tbFirmaHareketi.dteValorTarihi AS VADE, tbFirmaHareketi.sCariIslem AS CARIISLEM, tbFirma.sKodu AS HESAPKODU, tbFirma.sAciklama AS HESAPADI, tbMuhasebeFisi.sDovizCinsi1 AS PB, tbMuhasebeFisi.lDovizMiktari1 AS DOVIZTUTAR, tbMuhasebeFisi.lDovizKuru1 AS KUR, tbMuhasebeFisi.sDovizCinsi2 AS PB2, tbMuhasebeFisi.lDovizMiktari2 AS DOVIZTUTAR2, tbMuhasebeFisi.lDovizKuru2 AS KUR2, tbMuhasebeFisi.nSatir AS SATIR, tbMuhasebeFisi.sMuhFisTipi AS FISTIPI, tbMuhasebeFisi.dteFisTarihi AS TARIH,SUBSTRING(tbFirma.sKodu, 1, 3) AS KOD,(SELECT SUM(lBorcTutar - lAlacakTutar) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS BAKIYE FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID INNER JOIN tbMuhasebeFisi INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID ON tbFirmaHareketi.nHareketID = tbMuhasebeFisi.nCariHareketID " & kriter & "  ORDER BY SUBSTRING(tbFirma.sKodu, 1, 3),tbMuhasebeFisi.nFisSiraID"))
        'DataSet1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacaktutar, tbFirma.nFirmaID, tbFirma.sKodu, SUBSTRING(tbFirma.sKodu, 1, 3) AS KOD, (SELECT SUM(lBorcTutar - lAlacakTutar) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS BAKIYE, tbFirma.sAciklama AS FIRMAADI, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.sAciklama, tbFirmaHareketi.sEvrakNo, tbFirmaHareketi.sHangiUygulama, tbFirmaHareketi.sHareketTipi, tbFirmaHareketi.sKullaniciAdi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, tbFirmaHareketi.sDovizCinsi2, tbFirmaHareketi.lDovizMiktari2, tbFirmaHareketi.lDovizKuru2, tbFirmaHareketi.dteValorTarihi FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID " & kriter & "  GROUP BY tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.sAciklama, tbFirmaHareketi.sEvrakNo, tbFirmaHareketi.sHangiUygulama, tbFirmaHareketi.sHareketTipi, tbFirmaHareketi.sKullaniciAdi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, tbFirmaHareketi.sDovizCinsi2, tbFirmaHareketi.lDovizMiktari2, tbFirmaHareketi.lDovizKuru2, tbFirmaHareketi.dteValorTarihi ORDER BY tbFirma.sKodu"))
        DataSet1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacaktutar, tbFirma.nFirmaID, tbFirma.sKodu, SUBSTRING(tbFirma.sKodu, 1, 3) AS KOD, (SELECT SUM(lBorcTutar - lAlacakTutar) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS BAKIYE, tbFirma.sAciklama AS FIRMAADI, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.sAciklama, tbFirmaHareketi.sEvrakNo AS lFisNo,tbFirmaHareketi.sHangiUygulama, tbFirmaHareketi.sHangiUygulama AS IslemTipi, tbFirmaHareketi.sHareketTipi, tbFirmaHareketi.sKullaniciAdi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, tbFirmaHareketi.sDovizCinsi2, tbFirmaHareketi.lDovizMiktari2, tbFirmaHareketi.lDovizKuru2, tbFirmaHareketi.dteValorTarihi, ISNULL(tbStokFisiOdemePlani.nStokFisiID, 0) AS nStokFisiID, (SELECT sAciklama FROM tbCariIslem WHERE sCariIslem = tbFirmaHareketi.sCariIslem) AS sIslem, ISNULL(tbStokFisiMaster.nGirisCikis, 0) AS nGirisCikis, (SELECT nCekSenetID FROM tbCekSenet WHERE lCekSenetNo = CAST(tbFirmaHareketi.sEvrakNo AS MONEY) AND sCekSenetTipi = tbFirmaHareketi.sHangiUygulama AND dteVadeTarihi = tbFirmaHareketi.dteValorTarihi) AS nCekSenetID, tbFirmaHareketi.nHareketID FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiOdemePlani INNER JOIN tbGirisCikis INNER JOIN tbStokFisiMaster ON tbGirisCikis.nGirisCikis = tbStokFisiMaster.nGirisCikis ON tbStokFisiOdemePlani.nStokFisiID = tbStokFisiMaster.nStokFisiID ON tbFirmaHareketi.nHareketID = tbStokFisiOdemePlani.nCariHareketID " & kriter & " GROUP BY tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirmaHareketi.nHareketID, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.sAciklama, tbFirmaHareketi.sEvrakNo, tbFirmaHareketi.sHangiUygulama, tbFirmaHareketi.sHareketTipi, tbFirmaHareketi.sCariIslem, tbFirmaHareketi.sKullaniciAdi, tbFirmaHareketi.sDovizCinsi1, tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.lDovizKuru1, tbFirmaHareketi.sDovizCinsi2, tbFirmaHareketi.lDovizMiktari2, tbFirmaHareketi.lDovizKuru2, tbFirmaHareketi.dteValorTarihi, tbStokFisiOdemePlani.nStokFisiID, tbStokFisiMaster.nGirisCikis ORDER BY tbFirma.sKodu"))
        'ds_kasiyer = sorgu(sorgu_query("SELECT     sKasiyerRumuzu AS IND, sAdi + ' ' + sSoyadi AS KASIYER, sSifresi AS SIFRE, sDepo AS DEPO FROM         tbKasiyer WHERE     (sKasiyerRumuzu <> '')"))
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Select()
        GridControl1.Focus()
    End Sub
    Private Sub dataload_alis(ByVal ilktarih As DateTime, ByVal sontarih As DateTime, ByVal lFisno As String, ByVal nFirmaID As Int64)
        Dim kriter As String = ""
        kriter += " and tbStokFisiMaster.lFisNo = '" & lFisno & "' and tbFirma.nFirmaID = '" & nFirmaID & "'"
        'ds_alis = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CONVERT (char(10), tbStokFisiMaster.dteFisTarihi, 103) AS dteFisTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.sDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sDepo) AS Depo, tbFirma.sKodu, tbFirma.sAciklama, tbStokFisiMaster.sTransferDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sTransferDepo) AS tDepo, CONVERT (char(1), tbStokFisiMaster.bFaturayaDonustumu) AS sFaturalasti, CONVERT (char(1), tbStokFisiMaster.bMuhasebeyeIslendimi) AS Muhasebelesti, tbHareketTipi.sHareketTipi + ' ' + tbHareketTipi.sAciklama AS sHareketTipi, RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama1, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama2, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama3, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama4, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama5, '')) AS sNot,  tbStokFisiMaster.bFisTamamlandimi AS Tamamlandi, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.lNetTutar AS lNetTutar, CONVERT (char(1), tbStokFisiMaster.bHizmetFaturasimi) AS Hizmet, tbStokFisiMaster.nFirmaID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.nStokFisiID FROM tbFirma INNER JOIN tbStokFisiMaster ON tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID WHERE (tbStokFisiMaster.sFisTipi = 'FA') AND (tbStokFisiMaster.nGirisCikis = 1 OR tbStokFisiMaster.nGirisCikis = 2) AND (tbStokFisiMaster.dteFisTarihi BETWEEN '" & ilktarih & "' AND '" & sontarih & "') AND (tbStokFisiMaster.lFisNo BETWEEN 0 AND 999999999) AND (tbStokFisiMaster.lNetTutar BETWEEN - 999999999999.99 AND 999999999999.99) " & kriter & " ORDER BY tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo"))
        ds_alis = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CONVERT (char(10), tbStokFisiMaster.dteFisTarihi, 103) AS dteFisTarihi, tbStokFisiMaster.lFisNo, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.sDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sDepo) AS Depo, tbFirma.sKodu, tbFirma.sAciklama, tbStokFisiMaster.sTransferDepo, (SELECT sAciklama FROM tbDepo WHERE sDepo = tbStokFisiMaster.sTransferDepo) AS tDepo, CONVERT (char(1), tbStokFisiMaster.bFaturayaDonustumu) AS sFaturalasti, CONVERT (char(1), tbStokFisiMaster.bMuhasebeyeIslendimi) AS Muhasebelesti, tbHareketTipi.sHareketTipi + ' ' + tbHareketTipi.sAciklama AS sHareketTipi, RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama1, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama2, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama3, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama4, '')) + ' ' + RTRIM(ISNULL(tbStokFisiAciklamasi.sAciklama5, '')) AS sNot,  tbStokFisiMaster.bFisTamamlandimi AS Tamamlandi, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.lNetTutar AS lNetTutar, CONVERT (char(1), tbStokFisiMaster.bHizmetFaturasimi) AS Hizmet, tbStokFisiMaster.nFirmaID, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.lKdv1+ tbStokFisiMaster.lKdv2+ tbStokFisiMaster.lKdv3+ tbStokFisiMaster.lKdv4+ tbStokFisiMaster.lKdv5 as KdvTutari,tbStokFisiMaster.lKdvMatrahi1+tbStokFisiMaster.lKdvMatrahi2+tbStokFisiMaster.lKdvMatrahi3+tbStokFisiMaster.lKdvMatrahi4+tbStokFisiMaster.lKdvMatrahi5 as KdvMatrahi,tbStokFisiMaster.lEkmaliyet1+tbStokFisiMaster.lEkmaliyet2+tbStokFisiMaster.lEkmaliyet3 as EkMaliyet, tbStokFisiMaster.lMalIskontoTutari,tbStokFisiMaster.lMalBedeli,CAST(0 AS MONEY) AS ISKONTO,tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari AS FATURATUTARI,CAST(0 AS MONEY) AS EkOran FROM tbFirma INNER JOIN tbStokFisiMaster ON tbFirma.nFirmaID = tbStokFisiMaster.nFirmaID INNER JOIN tbHareketTipi ON tbStokFisiMaster.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID WHERE (tbStokFisiMaster.sFisTipi = 'FA') AND (tbStokFisiMaster.nGirisCikis = 1 OR tbStokFisiMaster.nGirisCikis = 2) AND (tbStokFisiMaster.dteFisTarihi BETWEEN '" & ilktarih & "' AND '" & sontarih & "') AND (tbStokFisiMaster.lFisNo BETWEEN 0 AND 999999999) AND (tbStokFisiMaster.lNetTutar BETWEEN - 999999999999.99 AND 999999999999.99) " & kriter & " ORDER BY tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.lFisNo"))
    End Sub
    Private Sub dataload_fis_detay(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String)
        Dim kriter
        kriter = "WHERE (tbStokFisiDetayi.sFisTipi = '" & sFistipi & "') and (tbStokFisiDetayi.dteFisTarihi = '" & dteFisTarihi & "') and (tbStokFisiDetayi.lFisNo = '" & lFisno & "') and (tbStokFisiDetayi.nFirmaID= '" & nFirmaID & "') and (tbStokFisiDetayi.nGirisCikis = '" & nGirisCikis & "')  "
        ds_stok_fisi_detay = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiDetayi.nStokID, tbStok.sKodu FROM         tbStokFisiDetayi INNER JOIN                       tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID " & kriter & ""))
    End Sub
    Private Function satir_kontrol_nStokID(Optional ByVal etiket As Boolean = False)
        Dim satir As String = " ("
        If etiket = True Then
            satir = "WHERE stok.nStokId IN ("
        End If
        Dim i As Integer = 0
        Dim toplamsayi = ds_stok_fisi_detay.Tables(0).Rows.Count
        Dim sayi = 0
        Dim dr1 As DataRow
        For Each dr1 In ds_stok_fisi_detay.Tables(0).Rows
            satir += dr1("nStokID").ToString
            sayi += 1
            If sayi < toplamsayi Then
                satir += ","
            ElseIf sayi = toplamsayi Then
                satir += ")"
            End If
        Next
        Return satir
    End Function
    Private Function sorgu(ByVal query As String) As DataSet
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
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
    'Private Sub analiz_alis()
    '    If GridView1.RowCount > 0 Then
    '        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
    '        If Trim(dr("sHangiUygulama").ToString) = "FA" Then
    '            Dim frm As New frm_stok_cari_alis
    '            frm.firmano = firmano
    '            frm.donemno = donemno
    '            frm.connection = connection
    '            Dim dr1 As DataRow
    '            'dataload_alis(dr("dteIslemTarihi"), dr("dteIslemTarihi"), dr("sEvrakNo"), dr("nFirmaID"))
    '            dr1 = ds_alis.Tables(0).Rows(0)
    '            'frm.musterino = dr("sKodu")
    '            frm.fisno = dr1("lFisNo")
    '            frm.tarih = dr1("dteFisTarihi")
    '            frm.fistipi = dr1("sFisTipi")
    '            frm.firmaID = dr1("nFirmaID")
    '            frm.ngiriscikis = dr1("nGirisCikis")
    '            frm.kullanici = kullanici
    '            If yetki_kontrol(kullanici, frm.Name) = True Then
    '                frm.ShowDialog()
    '            End If
    '            frm.Close()
    '            frm.Dispose()
    '            frm = Nothing
    '        End If
    '    End If
    'End Sub
    Private Sub fis_duzelt()
        If GridView1.RowCount > 0 Then
            If yetki_kontrol(kullanici, "frm_Cari_Hareket_Duzelt") = True Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                If Trim(dr("IslemTipi")) = "FA" Or Trim(dr("IslemTipi")) = "FS" Or Trim(dr("IslemTipi")) = "DG" Or Trim(dr("IslemTipi")) = "DC" Or Trim(dr("IslemTipi")) = "HA" Or Trim(dr("IslemTipi")) = "HS" Or Trim(dr("IslemTipi")) = "MM" Then
                    Dim frm As New frm_fatura
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.connection = connection
                    frm.lFisNo = dr("lFisNo")
                    frm.dteFisTarihi = dr("dteIslemTarihi")
                    frm.sFisTipi = dr("IslemTipi")
                    'frm.nFirmaID = dr("nFirmaID")
                    'frm.nGirisCikis = dr("nGirisCikis")
                    frm.nStokFisiID = dr("nStokFisiID")
                    frm.kullanici = kullanici
                    If yetki_kontrol(kullanici, frm.Name) = True Then
                        frm.ShowDialog()
                    End If
                    frm.Close()
                    frm.Dispose()
                    frm = Nothing
                    dr = Nothing
                    Dim satir = GridView1.FocusedRowHandle
                    GridView1.FocusedRowHandle = satir
                    satir = Nothing
                ElseIf Trim(dr("sHangiUygulama")) = "MUH" Then
                    Dim frm As New frm_tbMuhasebeFisi
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.connection = connection
                    frm.dteFisTarihi = dr("dteIslemTarihi")
                    frm.lFisNo = dr("lFisNo")
                    'frm.txt_lYevmiyeNo.EditValue = dr("lYevmiyeNo")
                    frm.kullanici = kullanici
                    If yetki_kontrol(kullanici, frm.Name) = True Then
                        frm.ShowDialog()
                        Dim satir As String = GridView1.FocusedRowHandle
                        'dataload()
                        GridView1.FocusedRowHandle = satir
                        satir = Nothing
                    End If
                    frm.Close()
                    frm.Dispose()
                    frm = Nothing
                ElseIf Trim(dr("sHangiUygulama")) = "" Then
                    Dim frm As New frm_tbFirmaHareketi
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.connection = connection
                    frm.txt_dteTarih1.EditValue = dr("dteIslemTarihi")
                    frm.txt_dteTarih2.EditValue = dr("dteIslemTarihi")
                    frm.sKodu = dr("sKodu")
                    frm.txt_musteriNo.Text = dr("sKodu")
                    frm.nHareketID = dr("nHareketID")
                    frm.kullanici = kullanici
                    frm.islemstatus = True
                    If yetki_kontrol(kullanici, frm.Name) = True Then
                        frm.ShowDialog()
                        Dim satir As String = GridView1.FocusedRowHandle
                        'dataload()
                        GridView1.FocusedRowHandle = satir
                        satir = Nothing
                    End If
                    frm.Close()
                    frm.Dispose()
                    frm = Nothing
                ElseIf Trim(dr("sHangiUygulama")) = "KASA" Then
                    Dim frm As New frm_tbNakitKasa
                    frm.firmano = firmano
                    frm.donemno = donemno
                    frm.connection = connection
                    frm.txt_dteIslemTarihi1.EditValue = dr("dteIslemTarihi")
                    frm.txt_dteIslemTarihi2.EditValue = dr("dteIslemTarihi")
                    frm.nHareketID = dr("nHareketID")
                    frm.sFirmaKodu = dr("sKodu")
                    frm.nFirmaid = dr("nFirmaID")
                    frm.kullanici = kullanici
                    frm.islemstatus = True
                    If yetki_kontrol(kullanici, frm.Name) = True Then
                        frm.ShowDialog()
                        Dim satir As String = GridView1.FocusedRowHandle
                        'dataload()
                        GridView1.FocusedRowHandle = satir
                        satir = Nothing
                    End If
                    frm.Close()
                    frm.Dispose()
                    frm = Nothing
                ElseIf Trim(dr("sHangiUygulama")) = "BC" Or Trim(dr("sHangiUygulama")) = "BS" Or Trim(dr("sHangiUygulama")) = "AC" Or Trim(dr("sHangiUygulama")) = "AS" Then
                    analiz_tbCekSenet_Hareket()
                End If
            End If
        End If
    End Sub
    Private Sub analiz_tbCekSenet_Hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_tbCekSenet_Hareketleri
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nCekSenetID = dr("nCekSenetID")
            frm.lCekSenetNo = dr("lFisNo")
            frm.sCekSenetTipi = dr("sHangiUygulama")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_karlilik()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Trim(dr("sHangiUygulama").ToString) = "FA" Then
                Dim frm As New frm_stok_cari_alis_karlilik
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                Dim dr1 As DataRow
                'dataload_alis(dr("dteIslemTarihi"), dr("dteIslemTarihi"), dr("sEvrakNo"), dr("nFirmaID"))
                dr1 = ds_alis.Tables(0).Rows(0)
                frm.fistipi = dr1("sFisTipi")
                frm.tarih = dr1("dteFisTarihi")
                frm.firmaID = dr1("nFirmaID")
                frm.fisno = dr1("lFisNo")
                frm.nGirisCikis = dr1("nGirisCikis")
                frm.kullanici = kullanici
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
            End If
        End If
    End Sub
    Private Sub analiz_siparis_bekleyen_tumu()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_siparis_verilen_bekleyen
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sKodu")
            'frm.nFirmaID = dr("nFirmaID")
            'frm.sec_firma.Checked = True
            'frm.sec_giris.Text = "Giriþler"
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_cari_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_hareketler_ozet
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sKodu")
            'frm.nFirmaID = dr("nFirmaID")
            'frm.sec_firma.Checked = True
            'frm.sec_giris.Text = "Giriþler"
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(dr("sKodu")))) = True Then
                    frm.ShowDialog()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_bekleyen(ByVal stoklar As String)
        Dim frm As New frm_satis_bekleyen_onaysiz
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.kasiyerno = kasiyerno
        'frm.kasiyer = kasiyer
        'frm.stokkodu = stokkodu
        frm.stoklar = stoklar
        frm.tarih1 = "01/01/1900"
        frm.tarih2 = "31/12/2048"
        'frm.qstokkodu = "Eþittir"
        frm.islemstatus = True
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub satir_firma_info()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            ds_satir_firma = sorgu_firma_info(dr("nFirmaID"))
            Dim dr1 As DataRow = ds_satir_firma.Tables(0).Rows(0)
            BarButtonItem3.Caption = dr1("sAciklama") & vbTab & "    Iskontosu: " & dr1("nOzelIskontosu") & " Kredilimiti: " & dr1("lKrediLimiti") & "   Borç: " & FormatNumber(dr1("BORC"), 2) & "   Alacak: " & FormatNumber(dr1("ALACAK"), 2) & "   Bakiye: " & FormatNumber(dr1("BAKIYE"), 2)
            Label2.Refresh()
            dr1 = Nothing
        End If
    End Sub
    Private Sub satir_fatura_info()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dataload_alis(dr("dteIslemTarihi"), dr("dteIslemTarihi"), dr("sEvrakNo"), dr("nFirmaID"))
            Dim dr1 As DataRow = ds_alis.Tables(0).Rows(0)
            Try
                If CType(dr1("lMalIskontoTutari"), Decimal) <> 0 Then
                    dr1("ISKONTO") = (dr1("lMalIskontoTutari") / dr1("lMalBedeli")) * 100
                Else
                    dr1("ISKONTO") = 0
                End If
                'dr1("ISKONTO") = (dr1("lMalIskontoTutari") / dr1("lMalBedeli")) * 100
                If CType(dr1("Ekmaliyet"), Decimal) <> 0 Then
                    dr1("EkOran") = CType(dr1("Ekmaliyet"), Decimal) / CType(dr1("lMalBedeli") - dr1("lMalIskontoTutari"), Decimal)
                    dr1("EkOran") = dr1("EkOran") * 100
                End If
            Catch ex As Exception
            End Try
            lbl_istihbarat.Text = "FisTarihi: " & dr1("dteFisTarihi") & " FisNo: " & dr1("lFisNo") & " Miktar : " & dr1("lToplamMiktar") & " Tutar: " & FormatNumber(dr1("lMalBedeli"), 2) & " Iskonto: %" & FormatNumber(dr1("ISKONTO"), 2) & "/ " & FormatNumber(dr1("lMalIskontoTutari"), 2) & " KdvTutarý: " & FormatNumber(dr1("KdvTutari"), 2) & " EkMaliyet: %" & FormatNumber(dr1("EkOran"), 2) & "/ " & FormatNumber(dr1("EkMaliyet"), 2) & " NetTutar: " & FormatNumber(dr1("lNetTutar"), 2)
            'BarButtonItem3.Caption = dr1("sAciklama") & vbTab & "    Iskontosu: " & dr1("nOzelIskontosu") & " Kredilimiti: " & dr1("lKrediLimiti") & "   Borç: " & FormatNumber(dr1("BORC"), 2) & "   Alacak: " & FormatNumber(dr1("ALACAK"), 2) & "   Bakiye: " & FormatNumber(dr1("BAKIYE"), 2)
            lbl_istihbarat.Refresh()
            dr1 = Nothing
        End If
    End Sub
    Private Function sorgu_firma_info(ByVal nFirmaID As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti, SUM(tbFirmaHareketi.lBorcTutar) AS BORC, SUM(tbFirmaHareketi.lAlacakTutar) AS ALACAK, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS BAKIYE FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE tbFirma.nFirmaID ='" & nFirmaID & "' GROUP BY tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        Return DS
        con = Nothing
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
                XtraMessageBox.Show(Sorgu_sDil("Bekleyen Ýþlemleriniz Var... Lütfen Bekleyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
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
    Private Sub odemesekilleri_baglanti_firma()
        Dim frm As New frm_emir_odemesekli_firma
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub satici_personel_baglanti_kat()
        Dim frm As New frm_emir_satici_katlar
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub analiz_kredikartlari_banka_odemeleri()
        Dim frm As New frm_emir_kredikartlari_banka_odemeleri
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub analiz_kredikartlari_banka_odemeleri_detay()
        Dim frm As New frm_emir_kredikartlari_banka_odemeleri_detay
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", label, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
        label = Nothing
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ekle()
    End Sub
    Private Sub SimpleButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If btn_baglan.Text = "Baðlantýyý Kes" Then
            dataload(DateEdit1.EditValue, DateEdit2.EditValue, kasiyerno, sec_uygulama.Text)
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
        'If Trim(kasiyerno) <> "" Then
        '    Dim sayi As Int64
        '    sayi = kayit_kontrol()
        '    If sayi = 0 Then
        '        e.Cancel = True
        '        Me.Hide()
        '    ElseIf sayi = 1 Then
        '        XtraMessageBox.Show(Sorgu_sDil("Bekleyen Ýþlemleriniz Var...Lütfen Bekleyiniz...!")
        '        e.Cancel = True
        '    End If
        'End If
        e.Cancel = True
        Me.Hide()
    End Sub
    Private Function kayit_kontrol() As Int64
        Dim sayi As Integer = 0
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, kasiyerno, sec_uygulama.Text)
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
                    dataload(DateEdit1.EditValue, DateEdit2.EditValue, kasiyerno, sec_uygulama.Text)
                End If
            ElseIf Trim(kasiyerno) = "YÖ" Or Trim(kasiyerno) = "MB" Then
                If XtraMessageBox.Show(dr("StokKodu") & Sorgu_sDil("  Kodlu Stoðun Fiyatýný Eski Fiyatý Ýle Deðiþtirmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    duzelt_fiyat(dr("StokNo"), dr("FiyatTipi"), dr("eFiyat"))
                    duzelt2(dr("IND"), Sorgu_sDil("Tamamlandý...", sDil), 1, "Fiyat Deðiþim Emri")
                    XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dataload(DateEdit1.EditValue, DateEdit2.EditValue, kasiyerno, sec_uygulama.Text)
                End If
            Else
                XtraMessageBox.Show(Sorgu_sDil("Yetkiniz Yok...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, kasiyerno, sec_uygulama.Text)
    End Sub
    Private Sub SimpleButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton4_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        gorunum_yazdir()
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
        Try
            satir_firma_info()
        Catch ex As Exception
        End Try
        Try
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Trim(dr("sHangiUygulama").ToString) = "FA" Then
                satir_fatura_info()
            ElseIf Trim(dr("sHangiUygulama").ToString) = "BC" Then
                lbl_istihbarat.Text = "Çek : " & dr("sAciklama") & " Vadesi : " & dr("dteValorTarihi")
            ElseIf Trim(dr("sHangiUygulama").ToString) = "BS" Then
                lbl_istihbarat.Text = "Senet : " & dr("sAciklama")
            Else
                lbl_istihbarat.Text = dr("sAciklama")
            End If
            dr = Nothing
        Catch ex As Exception
        End Try
    End Sub
    Private Sub musteri()
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            txt_firmakod.Text = Trim(dr1("sKodu"))
            txt_firmakod.Focus()
            txt_firmakod.SelectAll()
        End If
    End Sub
    Private Sub rpt_kasa_kasiyer()
        Dim frm As New frm_emir_kasa_kasiyer
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub analiz_Firma_karti()
        If GridView1.RowCount > 0 Then
            Dim frm As New frm_firma_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sKodu = dr("sKodu")
            frm.nFirmaID = dr("nFirmaID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
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
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        fis_duzelt()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            fis_duzelt()
        ElseIf e.KeyCode = Keys.F4 Then
            fis_duzelt()
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        odemesekilleri_baglanti_firma()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        analiz_kredikartlari_banka_odemeleri()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        satici_personel_baglanti_kat()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        analiz_karlilik()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_siparis_bekleyen_tumu()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Trim(dr("sHangiUygulama").ToString) = "FA" Then
                Dim dr1 As DataRow
                'dataload_alis(dr("dteIslemTarihi"), dr("dteIslemTarihi"), dr("sEvrakNo"), dr("nFirmaID"))
                dr1 = ds_alis.Tables(0).Rows(0)
                dataload_fis_detay(dr1("sFisTipi"), dr1("nGirisCikis"), dr1("dteFisTarihi"), dr1("lFisNo"), dr1("nFirmaID"))
                analiz_bekleyen(satir_kontrol_nStokID)
                dr1 = Nothing
            End If
        End If
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        analiz_cari_hareket()
    End Sub
    Private Sub txt_firmakod_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_firmakod.ButtonClick
        musteri()
    End Sub
    Private Sub txt_firmakod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_firmakod.KeyDown
        If e.KeyCode = Keys.F4 Then
            musteri()
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        DateEdit1.Focus()
        DateEdit1.Select()
    End Sub
    Private Sub MenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        rpt_kasa_kasiyer()
    End Sub
    Private Sub MenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        analiz_Firma_karti()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        analiz_kredikartlari_banka_odemeleri_detay()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        GridView1.OptionsView.ShowAutoFilterRow = True
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView1.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        raporla_pdf()
    End Sub
    Private Sub BarButtonItem14_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        analiz_Firma_karti()
    End Sub
    Private Sub BarButtonItem15_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        rpt_kasa_kasiyer()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Genel Kasa Ekranýný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub BarButtonItem16_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Genel Kasa Ekranýný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
