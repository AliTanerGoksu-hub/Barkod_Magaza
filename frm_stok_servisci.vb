Imports DevExpress.XtraEditors
Public Class frm_stok_servisci
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
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
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
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents btn_kaydet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_vazgec As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_hareket_dept As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
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
    Friend WithEvents colIND As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKODU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYETKILI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVERGIDAIRESI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVERGINO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEFON1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEFON2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTELEFON3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGSM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADRES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAKTIF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKAYITTARIHI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_kod As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_aktif As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents colISTIHBARAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_yetkili As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_adres As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_tel1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_tel2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_gsm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_tel3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_vergidairesi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_vergino As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_kod1 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_kod2 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_kod3 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_kod4 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_kod5 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_istihbarat As DevExpress.XtraEditors.MemoEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_servisci))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIND = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKODU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYETKILI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVERGIDAIRESI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVERGINO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTELEFON1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTELEFON2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTELEFON3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGSM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADRES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAKTIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKAYITTARIHI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISTIHBARAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_hareket_dept = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Label17 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_istihbarat = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_kod5 = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label16 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_kod4 = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label15 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_kod3 = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label14 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_kod2 = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label13 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_kod1 = New DevExpress.XtraEditors.ButtonEdit()
        Me.Label12 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_aktif = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_vergino = New DevExpress.XtraEditors.TextEdit()
        Me.Label10 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_vergidairesi = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New DevExpress.XtraEditors.LabelControl()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_gsm = New DevExpress.XtraEditors.TextEdit()
        Me.txt_tel3 = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.Label11 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_tel2 = New DevExpress.XtraEditors.TextEdit()
        Me.txt_tel1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_adres = New DevExpress.XtraEditors.MemoEdit()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_yetkili = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_ad = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_kod = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_vazgec = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_kaydet = New DevExpress.XtraEditors.SimpleButton()
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
        CType(Me.sec_hareket_dept, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txt_istihbarat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kod5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kod4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kod3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kod2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kod1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_aktif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_vergino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_vergidairesi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_gsm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tel3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tel2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tel1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_adres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_yetkili.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 64)
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(110, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(894, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Aþaðýda Servis Hesaplarýn Listesini Görmektesiniz.Ýþlem Yapmak istediðiniz Servis" & _
    " hesabýný seçmek için [Tamam] butonuna týklayýnýz, yeniden Arama yapmak için ise" & _
    " [Ara] butonuna týklayýnýz."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.SimpleButton3)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 381)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton3.TabIndex = 5
        Me.SimpleButton3.Text = "&Ara F3"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(729, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.TabIndex = 4
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(649, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 64)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 317)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(820, 313)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(814, 285)
        Me.XtraTabPage1.Text = "Servisler..."
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
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_hareket_dept})
        Me.GridControl1.Size = New System.Drawing.Size(814, 285)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem14, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem20, Me.MenuItem19, Me.MenuItem15, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7, Me.MenuItem8, Me.MenuItem16, Me.MenuItem9, Me.MenuItem10, Me.MenuItem17, Me.MenuItem11, Me.MenuItem12, Me.MenuItem18, Me.MenuItem13})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem1.Text = "Ara"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 1
        Me.MenuItem14.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem2.Text = "Ekle"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 3
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem3.Text = "Düzelt"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 4
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem4.Text = "Sil"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 5
        Me.MenuItem20.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 6
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
        Me.MenuItem15.Index = 7
        Me.MenuItem15.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 8
        Me.MenuItem5.Text = "Görünümü Düzenle"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 9
        Me.MenuItem6.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 10
        Me.MenuItem7.Text = "Görünümü Kaydet"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 11
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem8.Text = "Görünümü Yazdýr"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 12
        Me.MenuItem16.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 13
        Me.MenuItem9.Text = "Filtrele"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 14
        Me.MenuItem10.Text = "Gruplandýr"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 15
        Me.MenuItem17.Text = "-"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 16
        Me.MenuItem11.Text = "Satýrlarý Aç"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 17
        Me.MenuItem12.Text = "Satýrlarý Kapat"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 18
        Me.MenuItem18.Text = "-"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 19
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "IND"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "KODU"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "ADI"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "YETKILI"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "VERGIDAIRESI"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "VERGINO"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "TELEFON1"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "TELEFON2"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "TELEFON3"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "GSM"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "ADRES"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "KOD1"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "KOD2"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "KOD3"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "KOD4"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "KOD5"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "AKTIF"
        Me.DataColumn17.DataType = GetType(Boolean)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "KAYITTARIHI"
        Me.DataColumn18.DataType = GetType(Char)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "ISTIHBARAT"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIND, Me.colKODU, Me.colADI, Me.colYETKILI, Me.colVERGIDAIRESI, Me.colVERGINO, Me.colTELEFON1, Me.colTELEFON2, Me.colTELEFON3, Me.colGSM, Me.colADRES, Me.colKOD1, Me.colKOD2, Me.colKOD3, Me.colKOD4, Me.colKOD5, Me.colAKTIF, Me.colKAYITTARIHI, Me.colISTIHBARAT})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(391, 282, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "PERSONELKODU", Nothing, "{0} Kayýt")})
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
        Me.colIND.Width = 91
        '
        'colKODU
        '
        Me.colKODU.Caption = "ServisKodu"
        Me.colKODU.FieldName = "KODU"
        Me.colKODU.Name = "colKODU"
        Me.colKODU.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "KODU", "{0} Kayýt")})
        Me.colKODU.Visible = True
        Me.colKODU.VisibleIndex = 0
        Me.colKODU.Width = 66
        '
        'colADI
        '
        Me.colADI.Caption = "ServisAdý"
        Me.colADI.FieldName = "ADI"
        Me.colADI.Name = "colADI"
        Me.colADI.Visible = True
        Me.colADI.VisibleIndex = 1
        Me.colADI.Width = 122
        '
        'colYETKILI
        '
        Me.colYETKILI.Caption = "Yetkili"
        Me.colYETKILI.FieldName = "YETKILI"
        Me.colYETKILI.Name = "colYETKILI"
        Me.colYETKILI.Visible = True
        Me.colYETKILI.VisibleIndex = 2
        Me.colYETKILI.Width = 92
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
        'colTELEFON1
        '
        Me.colTELEFON1.Caption = "Telefon 1"
        Me.colTELEFON1.FieldName = "TELEFON1"
        Me.colTELEFON1.Name = "colTELEFON1"
        Me.colTELEFON1.Visible = True
        Me.colTELEFON1.VisibleIndex = 3
        Me.colTELEFON1.Width = 55
        '
        'colTELEFON2
        '
        Me.colTELEFON2.Caption = "Telefon 2"
        Me.colTELEFON2.FieldName = "TELEFON2"
        Me.colTELEFON2.Name = "colTELEFON2"
        Me.colTELEFON2.Width = 35
        '
        'colTELEFON3
        '
        Me.colTELEFON3.Caption = "Fax"
        Me.colTELEFON3.FieldName = "TELEFON3"
        Me.colTELEFON3.Name = "colTELEFON3"
        Me.colTELEFON3.Width = 49
        '
        'colGSM
        '
        Me.colGSM.Caption = "Gsm"
        Me.colGSM.FieldName = "GSM"
        Me.colGSM.Name = "colGSM"
        Me.colGSM.Visible = True
        Me.colGSM.VisibleIndex = 4
        Me.colGSM.Width = 56
        '
        'colADRES
        '
        Me.colADRES.Caption = "Adres"
        Me.colADRES.FieldName = "ADRES"
        Me.colADRES.Name = "colADRES"
        Me.colADRES.Visible = True
        Me.colADRES.VisibleIndex = 5
        Me.colADRES.Width = 56
        '
        'colKOD1
        '
        Me.colKOD1.Caption = "1.ÖzelKod"
        Me.colKOD1.FieldName = "KOD1"
        Me.colKOD1.Name = "colKOD1"
        Me.colKOD1.Visible = True
        Me.colKOD1.VisibleIndex = 6
        Me.colKOD1.Width = 56
        '
        'colKOD2
        '
        Me.colKOD2.Caption = "2.ÖzelKod"
        Me.colKOD2.FieldName = "KOD2"
        Me.colKOD2.Name = "colKOD2"
        Me.colKOD2.Visible = True
        Me.colKOD2.VisibleIndex = 7
        '
        'colKOD3
        '
        Me.colKOD3.Caption = "3.ÖzelKod"
        Me.colKOD3.FieldName = "KOD3"
        Me.colKOD3.Name = "colKOD3"
        '
        'colKOD4
        '
        Me.colKOD4.Caption = "4.ÖzelKod"
        Me.colKOD4.FieldName = "KOD4"
        Me.colKOD4.Name = "colKOD4"
        '
        'colKOD5
        '
        Me.colKOD5.Caption = "5.ÖzelKod"
        Me.colKOD5.FieldName = "KOD5"
        Me.colKOD5.Name = "colKOD5"
        '
        'colAKTIF
        '
        Me.colAKTIF.Caption = "Aktif?"
        Me.colAKTIF.FieldName = "AKTIF"
        Me.colAKTIF.Name = "colAKTIF"
        Me.colAKTIF.Width = 61
        '
        'colKAYITTARIHI
        '
        Me.colKAYITTARIHI.Caption = "Kayýt Tarihi"
        Me.colKAYITTARIHI.FieldName = "KAYITTARIHI"
        Me.colKAYITTARIHI.Name = "colKAYITTARIHI"
        '
        'colISTIHBARAT
        '
        Me.colISTIHBARAT.Caption = "Ýstihbarat"
        Me.colISTIHBARAT.FieldName = "ISTIHBARAT"
        Me.colISTIHBARAT.Name = "colISTIHBARAT"
        '
        'sec_hareket_dept
        '
        Me.sec_hareket_dept.AutoHeight = False
        Me.sec_hareket_dept.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_hareket_dept.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACIKLAMA", "ACIKLAMA")})
        Me.sec_hareket_dept.DisplayMember = "ACIKLAMA"
        Me.sec_hareket_dept.Name = "sec_hareket_dept"
        Me.sec_hareket_dept.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_hareket_dept.ValueMember = "IND"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.PanelControl5)
        Me.XtraTabPage2.Controls.Add(Me.PanelControl4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.PageVisible = False
        Me.XtraTabPage2.Size = New System.Drawing.Size(814, 285)
        Me.XtraTabPage2.Text = "Taným..."
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.GroupControl2)
        Me.PanelControl5.Controls.Add(Me.GroupControl1)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl5.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(814, 245)
        Me.PanelControl5.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.Label17)
        Me.GroupControl2.Controls.Add(Me.txt_istihbarat)
        Me.GroupControl2.Controls.Add(Me.txt_kod5)
        Me.GroupControl2.Controls.Add(Me.Label16)
        Me.GroupControl2.Controls.Add(Me.txt_kod4)
        Me.GroupControl2.Controls.Add(Me.Label15)
        Me.GroupControl2.Controls.Add(Me.txt_kod3)
        Me.GroupControl2.Controls.Add(Me.Label14)
        Me.GroupControl2.Controls.Add(Me.txt_kod2)
        Me.GroupControl2.Controls.Add(Me.Label13)
        Me.GroupControl2.Controls.Add(Me.txt_kod1)
        Me.GroupControl2.Controls.Add(Me.Label12)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl2.Location = New System.Drawing.Point(298, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(288, 241)
        Me.GroupControl2.TabIndex = 6
        Me.GroupControl2.Text = "Ek Bilgiler:"
        '
        'Label17
        '
        Me.Label17.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label17.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(5, 141)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 13)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "istihbarat;"
        '
        'txt_istihbarat
        '
        Me.txt_istihbarat.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ISTIHBARAT", True))
        Me.txt_istihbarat.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txt_istihbarat.EnterMoveNextControl = True
        Me.txt_istihbarat.Location = New System.Drawing.Point(2, 159)
        Me.txt_istihbarat.Name = "txt_istihbarat"
        Me.txt_istihbarat.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_istihbarat.Properties.Appearance.Options.UseForeColor = True
        Me.txt_istihbarat.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_istihbarat.Size = New System.Drawing.Size(284, 80)
        Me.txt_istihbarat.TabIndex = 13
        '
        'txt_kod5
        '
        Me.txt_kod5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.KOD5", True))
        Me.txt_kod5.EnterMoveNextControl = True
        Me.txt_kod5.Location = New System.Drawing.Point(72, 112)
        Me.txt_kod5.Name = "txt_kod5"
        Me.txt_kod5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_kod5.Properties.MaxLength = 20
        Me.txt_kod5.Size = New System.Drawing.Size(208, 20)
        Me.txt_kod5.TabIndex = 12
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 112)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 13)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "5.ÖzelKod:"
        '
        'txt_kod4
        '
        Me.txt_kod4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.KOD4", True))
        Me.txt_kod4.EnterMoveNextControl = True
        Me.txt_kod4.Location = New System.Drawing.Point(72, 90)
        Me.txt_kod4.Name = "txt_kod4"
        Me.txt_kod4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_kod4.Properties.MaxLength = 20
        Me.txt_kod4.Size = New System.Drawing.Size(208, 20)
        Me.txt_kod4.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 90)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "4.ÖzelKod:"
        '
        'txt_kod3
        '
        Me.txt_kod3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.KOD3", True))
        Me.txt_kod3.EnterMoveNextControl = True
        Me.txt_kod3.Location = New System.Drawing.Point(72, 68)
        Me.txt_kod3.Name = "txt_kod3"
        Me.txt_kod3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_kod3.Properties.MaxLength = 20
        Me.txt_kod3.Size = New System.Drawing.Size(208, 20)
        Me.txt_kod3.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "3.ÖzelKod:"
        '
        'txt_kod2
        '
        Me.txt_kod2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.KOD2", True))
        Me.txt_kod2.EnterMoveNextControl = True
        Me.txt_kod2.Location = New System.Drawing.Point(72, 46)
        Me.txt_kod2.Name = "txt_kod2"
        Me.txt_kod2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_kod2.Properties.MaxLength = 20
        Me.txt_kod2.Size = New System.Drawing.Size(208, 20)
        Me.txt_kod2.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "2.ÖzelKod:"
        '
        'txt_kod1
        '
        Me.txt_kod1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.KOD1", True))
        Me.txt_kod1.EnterMoveNextControl = True
        Me.txt_kod1.Location = New System.Drawing.Point(72, 24)
        Me.txt_kod1.Name = "txt_kod1"
        Me.txt_kod1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_kod1.Properties.MaxLength = 20
        Me.txt_kod1.Size = New System.Drawing.Size(208, 20)
        Me.txt_kod1.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "1.ÖzelKod:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_aktif)
        Me.GroupControl1.Controls.Add(Me.txt_vergino)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Controls.Add(Me.txt_vergidairesi)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.txt_gsm)
        Me.GroupControl1.Controls.Add(Me.txt_tel3)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.Label11)
        Me.GroupControl1.Controls.Add(Me.txt_tel2)
        Me.GroupControl1.Controls.Add(Me.txt_tel1)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.txt_adres)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.txt_yetkili)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.txt_ad)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.txt_kod)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(296, 241)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "Personel Bilgileri"
        '
        'sec_aktif
        '
        Me.sec_aktif.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.AKTIF", True))
        Me.sec_aktif.EditValue = True
        Me.sec_aktif.Location = New System.Drawing.Point(62, 218)
        Me.sec_aktif.Name = "sec_aktif"
        Me.sec_aktif.Properties.Caption = "Aktif"
        Me.sec_aktif.Size = New System.Drawing.Size(75, 19)
        Me.sec_aktif.TabIndex = 24
        '
        'txt_vergino
        '
        Me.txt_vergino.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.VERGINO", True))
        Me.txt_vergino.EnterMoveNextControl = True
        Me.txt_vergino.Location = New System.Drawing.Point(64, 196)
        Me.txt_vergino.Name = "txt_vergino"
        Me.txt_vergino.Properties.MaxLength = 20
        Me.txt_vergino.Size = New System.Drawing.Size(216, 20)
        Me.txt_vergino.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 196)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "VergiNo:"
        '
        'txt_vergidairesi
        '
        Me.txt_vergidairesi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.VERGIDAIRESI", True))
        Me.txt_vergidairesi.EnterMoveNextControl = True
        Me.txt_vergidairesi.Location = New System.Drawing.Point(64, 174)
        Me.txt_vergidairesi.Name = "txt_vergidairesi"
        Me.txt_vergidairesi.Properties.MaxLength = 20
        Me.txt_vergidairesi.Size = New System.Drawing.Size(216, 20)
        Me.txt_vergidairesi.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 174)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "VergiD..:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(160, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Gsm:"
        '
        'txt_gsm
        '
        Me.txt_gsm.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.GSM", True))
        Me.txt_gsm.EnterMoveNextControl = True
        Me.txt_gsm.Location = New System.Drawing.Point(192, 152)
        Me.txt_gsm.Name = "txt_gsm"
        Me.txt_gsm.Properties.MaxLength = 20
        Me.txt_gsm.Size = New System.Drawing.Size(88, 20)
        Me.txt_gsm.TabIndex = 18
        '
        'txt_tel3
        '
        Me.txt_tel3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.TELEFON3", True))
        Me.txt_tel3.EnterMoveNextControl = True
        Me.txt_tel3.Location = New System.Drawing.Point(64, 152)
        Me.txt_tel3.Name = "txt_tel3"
        Me.txt_tel3.Properties.MaxLength = 20
        Me.txt_tel3.Size = New System.Drawing.Size(90, 20)
        Me.txt_tel3.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Fax:"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(158, 134)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Tel2:"
        '
        'txt_tel2
        '
        Me.txt_tel2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.TELEFON2", True))
        Me.txt_tel2.EnterMoveNextControl = True
        Me.txt_tel2.Location = New System.Drawing.Point(192, 130)
        Me.txt_tel2.Name = "txt_tel2"
        Me.txt_tel2.Properties.MaxLength = 20
        Me.txt_tel2.Size = New System.Drawing.Size(88, 20)
        Me.txt_tel2.TabIndex = 12
        '
        'txt_tel1
        '
        Me.txt_tel1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.TELEFON1", True))
        Me.txt_tel1.EnterMoveNextControl = True
        Me.txt_tel1.Location = New System.Drawing.Point(64, 130)
        Me.txt_tel1.Name = "txt_tel1"
        Me.txt_tel1.Properties.MaxLength = 20
        Me.txt_tel1.Size = New System.Drawing.Size(90, 20)
        Me.txt_tel1.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(5, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Te1:"
        '
        'txt_adres
        '
        Me.txt_adres.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ADRES", True))
        Me.txt_adres.EnterMoveNextControl = True
        Me.txt_adres.Location = New System.Drawing.Point(64, 90)
        Me.txt_adres.Name = "txt_adres"
        Me.txt_adres.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_adres.Size = New System.Drawing.Size(216, 40)
        Me.txt_adres.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Adres:"
        '
        'txt_yetkili
        '
        Me.txt_yetkili.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.YETKILI", True))
        Me.txt_yetkili.EnterMoveNextControl = True
        Me.txt_yetkili.Location = New System.Drawing.Point(64, 68)
        Me.txt_yetkili.Name = "txt_yetkili"
        Me.txt_yetkili.Properties.MaxLength = 50
        Me.txt_yetkili.Size = New System.Drawing.Size(216, 20)
        Me.txt_yetkili.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(9, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Yetkili:"
        '
        'txt_ad
        '
        Me.txt_ad.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.ADI", True))
        Me.txt_ad.EnterMoveNextControl = True
        Me.txt_ad.Location = New System.Drawing.Point(64, 46)
        Me.txt_ad.Name = "txt_ad"
        Me.txt_ad.Properties.MaxLength = 50
        Me.txt_ad.Size = New System.Drawing.Size(216, 20)
        Me.txt_ad.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(9, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Adý:"
        '
        'txt_kod
        '
        Me.txt_kod.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSet1, "Table1.KODU", True))
        Me.txt_kod.EnterMoveNextControl = True
        Me.txt_kod.Location = New System.Drawing.Point(64, 24)
        Me.txt_kod.Name = "txt_kod"
        Me.txt_kod.Properties.MaxLength = 20
        Me.txt_kod.Size = New System.Drawing.Size(216, 20)
        Me.txt_kod.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(9, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kodu:"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.btn_vazgec)
        Me.PanelControl4.Controls.Add(Me.btn_kaydet)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(0, 245)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(814, 40)
        Me.PanelControl4.TabIndex = 1
        '
        'btn_vazgec
        '
        Me.btn_vazgec.Image = CType(resources.GetObject("btn_vazgec.Image"), System.Drawing.Image)
        Me.btn_vazgec.Location = New System.Drawing.Point(168, 8)
        Me.btn_vazgec.Name = "btn_vazgec"
        Me.btn_vazgec.Size = New System.Drawing.Size(136, 23)
        Me.btn_vazgec.TabIndex = 1
        Me.btn_vazgec.Text = "&Vazgeç"
        '
        'btn_kaydet
        '
        Me.btn_kaydet.Image = CType(resources.GetObject("btn_kaydet.Image"), System.Drawing.Image)
        Me.btn_kaydet.Location = New System.Drawing.Point(32, 8)
        Me.btn_kaydet.Name = "btn_kaydet"
        Me.btn_kaydet.Size = New System.Drawing.Size(128, 23)
        Me.btn_kaydet.TabIndex = 0
        Me.btn_kaydet.Text = "&Kaydet"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Servis Noktalarý Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Servis Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_stok_servisci
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_servisci"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servis Noktalarý Listesi"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
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
        CType(Me.sec_hareket_dept, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txt_istihbarat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kod5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kod4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kod3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kod2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kod1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_aktif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_vergino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_vergidairesi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_gsm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tel3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tel2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tel1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_adres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_yetkili.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public connection
    Public firmano
    Public donemno
    Public kullanici
    Dim islem As String
    Dim kayitno As Int64
    Dim dr As DataRow
    Dim satir
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Public islemstatus As Boolean = False
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If islemstatus = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.Close()
        End If
    End Sub
    Private Sub frm_personel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload()
        dataload_dept()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
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
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
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
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
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
        txt_kod.Text = ""
        txt_ad.Text = ""
        txt_yetkili.Text = ""
        txt_vergidairesi.Text = ""
        txt_vergino.Text = ""
        txt_tel1.Text = ""
        txt_tel2.Text = ""
        txt_tel3.Text = ""
        txt_gsm.Text = ""
        txt_adres.Text = ""
        txt_kod1.Text = ""
        txt_kod2.Text = ""
        txt_kod3.Text = ""
        txt_kod4.Text = ""
        txt_kod4.Text = ""
        txt_istihbarat.Text = ""
        sec_aktif.EditValue = -1
    End Sub
    Private Sub ekle(ByVal KODU As String, ByVal ADI As String, ByVal YETKILI As String, ByVal VERGIDAIRESI As String, ByVal VERGINO As String, ByVal TELEFON1 As String, ByVal TELEFON2 As String, ByVal TELEFON3 As String, ByVal GSM As String, ByVal ADRES As String, ByVal KOD1 As String, ByVal KOD2 As String, ByVal KOD3 As String, ByVal KOD4 As String, ByVal KOD5 As String, ByVal ISTIHBARAT As String, ByVal AKTIF As Integer, ByVal KAYITTARIHI As DateTime)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO ASTOKSERVISCI                       (KODU, ADI, YETKILI, VERGIDAIRESI, VERGINO, TELEFON1, TELEFON2, TELEFON3, GSM, ADRES, KOD1, KOD2, KOD3, KOD4, KOD5, ISTIHBARAT, AKTIF, KAYITTARIHI) VALUES     ('" & KODU & "', '" & ADI & "', '" & YETKILI & "', '" & VERGIDAIRESI & "' , '" & VERGINO & "' , '" & TELEFON1 & "' , '" & TELEFON2 & "' , '" & TELEFON3 & "' , '" & GSM & "' , '" & ADRES & "', '" & KOD1 & "', '" & KOD2 & "', '" & KOD3 & "', '" & KOD4 & "', '" & KOD5 & "', '" & ISTIHBARAT & "',  " & AKTIF & " , GETDATE())")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub duzelt(ByVal ind As Int64, ByVal KODU As String, ByVal ADI As String, ByVal YETKILI As String, ByVal VERGIDAIRESI As String, ByVal VERGINO As String, ByVal TELEFON1 As String, ByVal TELEFON2 As String, ByVal TELEFON3 As String, ByVal GSM As String, ByVal ADRES As String, ByVal KOD1 As String, ByVal KOD2 As String, ByVal KOD3 As String, ByVal KOD4 As String, ByVal KOD5 As String, ByVal ISTIHBARAT As String, ByVal AKTIF As Integer, ByVal KAYITTARIHI As DateTime)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    ASTOKSERVISCI SET              KODU = '" & KODU & "', ADI = '" & ADI & "', YETKILI = '" & YETKILI & "', VERGIDAIRESI = '" & VERGIDAIRESI & "', VERGINO = '" & VERGINO & "', TELEFON1 = '" & TELEFON1 & "',  TELEFON2 = '" & TELEFON2 & "', TELEFON3 = '" & TELEFON3 & "', GSM = '" & GSM & "', ADRES = '" & ADRES & "',  KOD1 = '" & KOD1 & "', KOD2 = '" & KOD2 & "', KOD3 = '" & KOD3 & "', KOD4 = '" & KOD4 & "', KOD5 = '" & KOD5 & "', ISTIHBARAT = '" & ISTIHBARAT & "', AKTIF = " & AKTIF & "   WHERE IND =" & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
        'Try
        '    Dim da As New OleDb.OleDbDataAdapter
        '    da.UpdateCommand = cmd
        '    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE APERSONEL SET RESIM = ? WHERE (IND = " & kayitno & ")")
        '    cmd.Parameters.Add(New System.Data.OleDb.OleDbParameter("RESIM", System.Data.OleDb.OleDbType.VarBinary, 2147483647, "RESIM"))
        '    da.Update(DataSet1.Tables(0))
        '    da = Nothing
        'Catch ex As Exception
        '    XtraMessageBox.Show(ex.Message.ToString)
        'End Try
    End Sub
    Private Sub sil(ByVal ind As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM ASTOKSERVISCI WHERE IND = " & ind & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub dataload_dept()
        'sec_dept.Properties.DataSource = sorgu(sorgu_query("SELECT * FROM APERSONELDEPT")).Tables(0) 'DataSet2.Tables(0)
        sec_hareket_dept.DataSource = sorgu(sorgu_query("SELECT * FROM APERSONELDEPT")).Tables(0) 'DataSet2.Tables(0)
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
    Private Sub dataload()
        DataSet1 = sorgu(sorgu_query("SELECT     * FROM         ASTOKSERVISCI"))
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Select()
        GridControl1.Focus()
    End Sub
    Private Sub sil()
        XtraMessageBox.Show(Sorgu_sDil("Hatalý Ýþlem", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        kayit_duzelt()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        kayit_sil()
    End Sub
    Private Sub kayit_sil()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            satir = GridView1.FocusedRowHandle
            kayitno = dr("IND")
            If kayitno > 0 Then
                If XtraMessageBox.Show(kayitno & vbTab & Sorgu_sDil("Nolu Personel Kaydýný Silmek istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    sil(kayitno)
                End If
            End If
            dataload()
        End If
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\PERSONEL\" & Me.Name.ToString & "")
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
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\PERSONEL\" & Me.Name.ToString & "")
    End Sub
    Private Sub btn_kaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_kaydet.Click
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = False
        XtraTabControl1.SelectedTabPageIndex = 0
        GridControl1.Focus()
        GridControl1.Select()
        kaydet()
        dataload()
        If islem = "duzelt" Then
            GridView1.FocusedRowHandle = satir
        End If
    End Sub
    Private Sub kaydet()
        If islem = "ekle" Then
            ekle(txt_kod.EditValue, txt_ad.EditValue, txt_yetkili.Text, txt_vergidairesi.Text, txt_vergino.Text, txt_tel1.Text, txt_tel2.Text, txt_tel3.Text, txt_gsm.Text, txt_adres.Text, txt_kod1.Text, txt_kod2.Text, txt_kod3.Text, txt_kod4.Text, txt_kod5.Text, txt_istihbarat.Text, sec_aktif.Checked, Now)
            'ekle(txt_kullanici.Text, txt_sifre.Text, txt_ad.Text, txt_soyad.Text, sec_firma.EditValue, sec_donem.EditValue, sec_depo.EditValue)
        ElseIf islem = "duzelt" Then
            duzelt(kayitno, txt_kod.EditValue, txt_ad.EditValue, txt_yetkili.Text, txt_vergidairesi.Text, txt_vergino.Text, txt_tel1.Text, txt_tel2.Text, txt_tel3.Text, txt_gsm.Text, txt_adres.Text, txt_kod1.Text, txt_kod2.Text, txt_kod3.Text, txt_kod4.Text, txt_kod5.Text, txt_istihbarat.Text, sec_aktif.Checked, Now)
            'duzelt(txt_kullanici.Text, txt_sifre.Text, txt_ad.Text, txt_soyad.Text, sec_firma.EditValue, sec_donem.EditValue, sec_depo.EditValue, kayitno)
        End If
    End Sub
    Private Sub kayit_duzelt()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            satir = GridView1.FocusedRowHandle
            kayitno = dr("IND")
            txt_kod.Text = dr("KODU").ToString
            txt_ad.Text = dr("ADI").ToString
            txt_yetkili.Text = dr("YETKILI").ToString
            txt_vergidairesi.Text = dr("VERGIDAIRESI").ToString
            txt_vergino.Text = dr("VERGINO").ToString
            txt_tel1.Text = dr("TELEFON1").ToString
            txt_tel2.Text = dr("TELEFON2").ToString
            txt_tel3.Text = dr("TELEFON3").ToString
            txt_gsm.Text = dr("GSM").ToString
            txt_adres.Text = dr("ADRES").ToString
            txt_kod1.Text = dr("KOD1").ToString
            txt_kod2.Text = dr("KOD2").ToString
            txt_kod3.Text = dr("KOD3").ToString
            txt_kod4.Text = dr("KOD4").ToString
            txt_kod4.Text = dr("KOD5").ToString
            txt_istihbarat.Text = dr("ISTIHBARAT").ToString
            sec_aktif.EditValue = dr("AKTIF")
            XtraTabPage1.PageVisible = False
            XtraTabPage2.PageVisible = True
            XtraTabControl1.SelectedTabPageIndex = 1
            txt_kod.Focus()
            txt_kod.Select()
            islem = "duzelt"
        End If
    End Sub
    Private Sub btn_vazgec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_vazgec.Click
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = False
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub
    Private Sub sec_aktif_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btn_kaydet.Focus()
            btn_kaydet.Select()
        End If
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub sec_aktif_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_aktif.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_kod1.Focus()
            txt_kod1.Select()
        End If
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
            If islemstatus = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
            End If
        End If
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        If islemstatus = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
        End If
    End Sub
End Class
