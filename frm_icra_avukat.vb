Imports DevExpress.XtraEditors
Public Class frm_icra_avukat
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
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ds_avukat As System.Data.DataSet
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
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUnvan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAdres As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsTelefon1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsTelefon2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsTelefon3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUrl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents sGsm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_vazgec As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_kaydet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
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
    Friend WithEvents txt_sUrl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sEMail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sGsm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sFax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sTelefon3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sTelefon2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sTelefon1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sAdres As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_sAciklama As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_sUnvan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_sSoyadi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sAdi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sKodu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_icra_avukat))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.ds_avukat = New System.Data.DataSet
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsSoyadi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsUnvan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAdres = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsTelefon1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsTelefon2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsTelefon3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsFax = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsEmail = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsUrl = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sGsm = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.txt_sAciklama = New DevExpress.XtraEditors.MemoEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txt_sUnvan = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sSoyadi = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sAdi = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sKodu = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btn_vazgec = New DevExpress.XtraEditors.SimpleButton
        Me.btn_kaydet = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sUrl = New DevExpress.XtraEditors.TextEdit
        Me.txt_sEMail = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sGsm = New DevExpress.XtraEditors.TextEdit
        Me.txt_sFax = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sTelefon3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sTelefon2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sTelefon1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txt_sAdres = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
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
        CType(Me.ds_avukat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txt_sAciklama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txt_sUnvan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sSoyadi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAdi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txt_sUrl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sEMail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sGsm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sFax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sTelefon3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sTelefon2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sTelefon1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAdres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(111, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(710, 58)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Aþaðýda Avukat Hesaplarýn Listesini Görmektesiniz.Ýþlem Yapmak istediðiniz Avukat" & _
            " hesabýný seçmek için [Tamam] butonuna týklayýnýz, yeniden Arama yapmak için ise" & _
            " [Ara] butonuna týklayýnýz."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(108, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 381)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(88, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(384, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(736, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton2.TabIndex = 6
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(656, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 24)
        Me.SimpleButton1.TabIndex = 5
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
        Me.XtraTabControl1.Location = New System.Drawing.Point(3, 3)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(818, 311)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GridControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(814, 284)
        Me.XtraTabPage1.Text = "Avukatlar..."
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenu = Me.ContextMenu1
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.ds_avukat
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(814, 284)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem14, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem20, Me.MenuItem19, Me.MenuItem15, Me.MenuItem5, Me.MenuItem7, Me.MenuItem8, Me.MenuItem16, Me.MenuItem6, Me.MenuItem9, Me.MenuItem10, Me.MenuItem17, Me.MenuItem11, Me.MenuItem12, Me.MenuItem18, Me.MenuItem13})
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
        'MenuItem7
        '
        Me.MenuItem7.Index = 9
        Me.MenuItem7.Text = "Görünümü Kaydet"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 10
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem8.Text = "Görünümü Yazdýr"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 11
        Me.MenuItem16.Text = "-"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 12
        Me.MenuItem6.Text = "Hýzlý Filtre"
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
        'ds_avukat
        '
        Me.ds_avukat.DataSetName = "NewDataSet"
        Me.ds_avukat.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_avukat.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "sKodu"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sAdi"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sSoyadi"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sUnvan"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sAdres"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sTelefon1"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "sTelefon2"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sTelefon3"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sFax"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "sEmail"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sUrl"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sAciklama"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "sGsm"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsKodu, Me.colsAdi, Me.colsSoyadi, Me.colsUnvan, Me.colsAdres, Me.colsTelefon1, Me.colsTelefon2, Me.colsTelefon3, Me.colsFax, Me.colsEmail, Me.colsUrl, Me.colsAciklama, Me.sGsm})
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
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.SummaryItem.DisplayFormat = "{0} Kayýt"
        Me.colsKodu.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 0
        '
        'colsAdi
        '
        Me.colsAdi.Caption = "Adý"
        Me.colsAdi.FieldName = "sAdi"
        Me.colsAdi.Name = "colsAdi"
        Me.colsAdi.Visible = True
        Me.colsAdi.VisibleIndex = 1
        '
        'colsSoyadi
        '
        Me.colsSoyadi.Caption = "Soyadi"
        Me.colsSoyadi.FieldName = "sSoyadi"
        Me.colsSoyadi.Name = "colsSoyadi"
        Me.colsSoyadi.Visible = True
        Me.colsSoyadi.VisibleIndex = 2
        '
        'colsUnvan
        '
        Me.colsUnvan.Caption = "Ünvan"
        Me.colsUnvan.FieldName = "sUnvan"
        Me.colsUnvan.Name = "colsUnvan"
        '
        'colsAdres
        '
        Me.colsAdres.Caption = "Adres"
        Me.colsAdres.FieldName = "sAdres"
        Me.colsAdres.Name = "colsAdres"
        '
        'colsTelefon1
        '
        Me.colsTelefon1.Caption = "Telefon 1"
        Me.colsTelefon1.FieldName = "sTelefon1"
        Me.colsTelefon1.Name = "colsTelefon1"
        Me.colsTelefon1.Visible = True
        Me.colsTelefon1.VisibleIndex = 3
        '
        'colsTelefon2
        '
        Me.colsTelefon2.Caption = "Telefon 2"
        Me.colsTelefon2.FieldName = "sTelefon2"
        Me.colsTelefon2.Name = "colsTelefon2"
        '
        'colsTelefon3
        '
        Me.colsTelefon3.Caption = "Telefon 3"
        Me.colsTelefon3.FieldName = "sTelefon3"
        Me.colsTelefon3.Name = "colsTelefon3"
        '
        'colsFax
        '
        Me.colsFax.Caption = "Fax"
        Me.colsFax.FieldName = "sFax"
        Me.colsFax.Name = "colsFax"
        '
        'colsEmail
        '
        Me.colsEmail.Caption = "Email"
        Me.colsEmail.FieldName = "sEmail"
        Me.colsEmail.Name = "colsEmail"
        '
        'colsUrl
        '
        Me.colsUrl.Caption = "Url"
        Me.colsUrl.FieldName = "sUrl"
        Me.colsUrl.Name = "colsUrl"
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Açýklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        '
        'sGsm
        '
        Me.sGsm.Caption = "Gsm"
        Me.sGsm.FieldName = "sGsm"
        Me.sGsm.Name = "sGsm"
        Me.sGsm.Visible = True
        Me.sGsm.VisibleIndex = 4
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GroupControl2)
        Me.XtraTabPage2.Controls.Add(Me.GroupControl1)
        Me.XtraTabPage2.Controls.Add(Me.btn_vazgec)
        Me.XtraTabPage2.Controls.Add(Me.btn_kaydet)
        Me.XtraTabPage2.Controls.Add(Me.GroupControl3)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.PageVisible = False
        Me.XtraTabPage2.Size = New System.Drawing.Size(814, 284)
        Me.XtraTabPage2.Text = "Taným..."
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txt_sAciklama)
        Me.GroupControl2.Location = New System.Drawing.Point(432, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(238, 133)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Not..."
        '
        'txt_sAciklama
        '
        Me.txt_sAciklama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_sAciklama.EnterMoveNextControl = True
        Me.txt_sAciklama.Location = New System.Drawing.Point(3, 19)
        Me.txt_sAciklama.Name = "txt_sAciklama"
        Me.txt_sAciklama.Properties.MaxLength = 200
        Me.txt_sAciklama.Size = New System.Drawing.Size(232, 111)
        Me.txt_sAciklama.TabIndex = 8
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txt_sUnvan)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txt_sSoyadi)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txt_sAdi)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txt_sKodu)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(408, 134)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Avukat Bilgileri"
        '
        'txt_sUnvan
        '
        Me.txt_sUnvan.EnterMoveNextControl = True
        Me.txt_sUnvan.Location = New System.Drawing.Point(80, 88)
        Me.txt_sUnvan.Name = "txt_sUnvan"
        Me.txt_sUnvan.Properties.MaxLength = 200
        Me.txt_sUnvan.Size = New System.Drawing.Size(320, 42)
        Me.txt_sUnvan.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(8, 88)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Ünvan:"
        '
        'txt_sSoyadi
        '
        Me.txt_sSoyadi.EnterMoveNextControl = True
        Me.txt_sSoyadi.Location = New System.Drawing.Point(80, 66)
        Me.txt_sSoyadi.Name = "txt_sSoyadi"
        Me.txt_sSoyadi.Properties.MaxLength = 20
        Me.txt_sSoyadi.Size = New System.Drawing.Size(320, 22)
        Me.txt_sSoyadi.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(8, 66)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Soyad:"
        '
        'txt_sAdi
        '
        Me.txt_sAdi.EnterMoveNextControl = True
        Me.txt_sAdi.Location = New System.Drawing.Point(80, 44)
        Me.txt_sAdi.Name = "txt_sAdi"
        Me.txt_sAdi.Properties.MaxLength = 20
        Me.txt_sAdi.Size = New System.Drawing.Size(320, 22)
        Me.txt_sAdi.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(8, 44)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(17, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Ad:"
        '
        'txt_sKodu
        '
        Me.txt_sKodu.EnterMoveNextControl = True
        Me.txt_sKodu.Location = New System.Drawing.Point(80, 22)
        Me.txt_sKodu.Name = "txt_sKodu"
        Me.txt_sKodu.Properties.MaxLength = 3
        Me.txt_sKodu.Size = New System.Drawing.Size(100, 22)
        Me.txt_sKodu.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(8, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Kod:"
        '
        'btn_vazgec
        '
        Me.btn_vazgec.Image = CType(resources.GetObject("btn_vazgec.Image"), System.Drawing.Image)
        Me.btn_vazgec.Location = New System.Drawing.Point(136, 258)
        Me.btn_vazgec.Name = "btn_vazgec"
        Me.btn_vazgec.Size = New System.Drawing.Size(136, 23)
        Me.btn_vazgec.TabIndex = 4
        Me.btn_vazgec.Text = "&Vazgeç"
        '
        'btn_kaydet
        '
        Me.btn_kaydet.Image = CType(resources.GetObject("btn_kaydet.Image"), System.Drawing.Image)
        Me.btn_kaydet.Location = New System.Drawing.Point(8, 258)
        Me.btn_kaydet.Name = "btn_kaydet"
        Me.btn_kaydet.Size = New System.Drawing.Size(128, 23)
        Me.btn_kaydet.TabIndex = 3
        Me.btn_kaydet.Text = "&Kaydet"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.LabelControl12)
        Me.GroupControl3.Controls.Add(Me.LabelControl10)
        Me.GroupControl3.Controls.Add(Me.txt_sUrl)
        Me.GroupControl3.Controls.Add(Me.txt_sEMail)
        Me.GroupControl3.Controls.Add(Me.LabelControl11)
        Me.GroupControl3.Controls.Add(Me.txt_sGsm)
        Me.GroupControl3.Controls.Add(Me.txt_sFax)
        Me.GroupControl3.Controls.Add(Me.LabelControl8)
        Me.GroupControl3.Controls.Add(Me.txt_sTelefon3)
        Me.GroupControl3.Controls.Add(Me.LabelControl9)
        Me.GroupControl3.Controls.Add(Me.txt_sTelefon2)
        Me.GroupControl3.Controls.Add(Me.LabelControl7)
        Me.GroupControl3.Controls.Add(Me.txt_sTelefon1)
        Me.GroupControl3.Controls.Add(Me.LabelControl6)
        Me.GroupControl3.Controls.Add(Me.txt_sAdres)
        Me.GroupControl3.Controls.Add(Me.LabelControl5)
        Me.GroupControl3.Location = New System.Drawing.Point(8, 127)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(662, 117)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "Ýletiþim"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl12.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl12.Location = New System.Drawing.Point(412, 68)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl12.TabIndex = 25
        Me.LabelControl12.Text = "Web:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.Location = New System.Drawing.Point(414, 24)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl10.TabIndex = 24
        Me.LabelControl10.Text = "Gsm:"
        '
        'txt_sUrl
        '
        Me.txt_sUrl.EnterMoveNextControl = True
        Me.txt_sUrl.Location = New System.Drawing.Point(456, 68)
        Me.txt_sUrl.Name = "txt_sUrl"
        Me.txt_sUrl.Properties.MaxLength = 50
        Me.txt_sUrl.Size = New System.Drawing.Size(200, 22)
        Me.txt_sUrl.TabIndex = 23
        '
        'txt_sEMail
        '
        Me.txt_sEMail.EnterMoveNextControl = True
        Me.txt_sEMail.Location = New System.Drawing.Point(456, 46)
        Me.txt_sEMail.Name = "txt_sEMail"
        Me.txt_sEMail.Properties.MaxLength = 50
        Me.txt_sEMail.Size = New System.Drawing.Size(200, 22)
        Me.txt_sEMail.TabIndex = 21
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl11.Location = New System.Drawing.Point(406, 46)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl11.TabIndex = 20
        Me.LabelControl11.Text = "E-Mail:"
        '
        'txt_sGsm
        '
        Me.txt_sGsm.EnterMoveNextControl = True
        Me.txt_sGsm.Location = New System.Drawing.Point(456, 24)
        Me.txt_sGsm.Name = "txt_sGsm"
        Me.txt_sGsm.Properties.MaxLength = 100
        Me.txt_sGsm.Size = New System.Drawing.Size(200, 22)
        Me.txt_sGsm.TabIndex = 19
        '
        'txt_sFax
        '
        Me.txt_sFax.EnterMoveNextControl = True
        Me.txt_sFax.Location = New System.Drawing.Point(264, 88)
        Me.txt_sFax.Name = "txt_sFax"
        Me.txt_sFax.Properties.MaxLength = 20
        Me.txt_sFax.Size = New System.Drawing.Size(136, 22)
        Me.txt_sFax.TabIndex = 17
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.Location = New System.Drawing.Point(216, 88)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl8.TabIndex = 16
        Me.LabelControl8.Text = "Fax:"
        '
        'txt_sTelefon3
        '
        Me.txt_sTelefon3.EnterMoveNextControl = True
        Me.txt_sTelefon3.Location = New System.Drawing.Point(80, 88)
        Me.txt_sTelefon3.Name = "txt_sTelefon3"
        Me.txt_sTelefon3.Properties.MaxLength = 20
        Me.txt_sTelefon3.Size = New System.Drawing.Size(136, 22)
        Me.txt_sTelefon3.TabIndex = 15
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.Location = New System.Drawing.Point(8, 88)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl9.TabIndex = 14
        Me.LabelControl9.Text = "Telefon3:"
        '
        'txt_sTelefon2
        '
        Me.txt_sTelefon2.EnterMoveNextControl = True
        Me.txt_sTelefon2.Location = New System.Drawing.Point(264, 66)
        Me.txt_sTelefon2.Name = "txt_sTelefon2"
        Me.txt_sTelefon2.Properties.MaxLength = 20
        Me.txt_sTelefon2.Size = New System.Drawing.Size(136, 22)
        Me.txt_sTelefon2.TabIndex = 13
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.Location = New System.Drawing.Point(216, 66)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl7.TabIndex = 12
        Me.LabelControl7.Text = "Telefon2:"
        '
        'txt_sTelefon1
        '
        Me.txt_sTelefon1.EnterMoveNextControl = True
        Me.txt_sTelefon1.Location = New System.Drawing.Point(80, 66)
        Me.txt_sTelefon1.Name = "txt_sTelefon1"
        Me.txt_sTelefon1.Properties.MaxLength = 20
        Me.txt_sTelefon1.Size = New System.Drawing.Size(136, 22)
        Me.txt_sTelefon1.TabIndex = 11
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.Location = New System.Drawing.Point(8, 66)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "Telefon1:"
        '
        'txt_sAdres
        '
        Me.txt_sAdres.EnterMoveNextControl = True
        Me.txt_sAdres.Location = New System.Drawing.Point(80, 24)
        Me.txt_sAdres.Name = "txt_sAdres"
        Me.txt_sAdres.Properties.MaxLength = 200
        Me.txt_sAdres.Size = New System.Drawing.Size(320, 42)
        Me.txt_sAdres.TabIndex = 9
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(8, 24)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "Adres:"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"", "Avukat Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"www.barkodyazilim.com", "Ýcra Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_icra_avukat
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 429)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_icra_avukat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Avukatlar..."
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
        CType(Me.ds_avukat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.txt_sAciklama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txt_sUnvan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sSoyadi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAdi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.txt_sUrl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sEMail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sGsm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sFax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sTelefon3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sTelefon2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sTelefon1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAdres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public connection
    Public firmano
    Public donemno
    Public kasiyerno As Int64
    Public kullanici
    Dim islem As String
    Public status As Boolean = False
    Public islemstatus As Boolean = False
    Public takip As Boolean = False
    Public kayitno As String = ""
    Dim dr As DataRow
    Dim satir
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Public kriter As String = ""
    Private Sub frm_icra_avukat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\PERSONEL\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\PERSONEL\" & Me.Name.ToString & "")
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
        'MsgBox(kriter)
        If kayitno <> "" Then
            kriter += " WHERE sKodu = '" & kayitno & "'"
        Else
            If takip = False Then
                kriter = ""
            End If
        End If
        ds_avukat = sorgu(sorgu_query("SELECT     * FROM         aEmirIcraAvukat " & kriter & ""))
        GridControl1.DataSource = ds_avukat.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Select()
        GridControl1.Focus()
        If islemstatus = True Then
            kayit_duzelt()
        End If
    End Sub
    Private Sub kayit_ekle()
        XtraTabPage1.PageVisible = False
        XtraTabPage2.PageVisible = True
        XtraTabControl1.SelectedTabPageIndex = 1
        txt_sKodu.Text = ""
        txt_sAdi.Text = ""
        txt_sSoyadi.Text = ""
        txt_sUnvan.Text = ""
        txt_sAdres.Text = ""
        txt_sTelefon1.Text = ""
        txt_sTelefon2.Text = ""
        txt_sTelefon3.Text = ""
        txt_sFax.Text = ""
        txt_sGsm.Text = ""
        txt_sEMail.Text = ""
        txt_sUrl.Text = ""
        txt_sAciklama.Text = ""
        txt_sKodu.Focus()
        txt_sKodu.SelectAll()
        islem = "ekle"
    End Sub
    Private Sub kaydet()
        If islem = "ekle" Then
            ekle(txt_sKodu.EditValue, txt_sAdi.Text, txt_sSoyadi.Text, txt_sUnvan.Text, txt_sAdres.Text, txt_sTelefon1.Text, txt_sTelefon2.Text, txt_sTelefon3.Text, txt_sFax.Text, txt_sGsm.Text, txt_sEMail.Text, txt_sUrl.Text, txt_sAciklama.Text)
        ElseIf islem = "duzelt" Then
            duzelt(txt_sKodu.EditValue, txt_sAdi.Text, txt_sSoyadi.Text, txt_sUnvan.Text, txt_sAdres.Text, txt_sTelefon1.Text, txt_sTelefon2.Text, txt_sTelefon3.Text, txt_sFax.Text, txt_sGsm.Text, txt_sEMail.Text, txt_sUrl.Text, txt_sAciklama.Text)
        End If
    End Sub
    Private Sub kayit_duzelt()
        If GridView1.RowCount > 0 Then
            'dataload_dept()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            satir = GridView1.FocusedRowHandle
            kayitno = dr("sKodu")
            txt_sKodu.Text = dr("sKodu").ToString
            txt_sAdi.Text = dr("sAdi").ToString
            txt_sSoyadi.Text = dr("sSoyadi").ToString
            txt_sUnvan.Text = dr("sUnvan").ToString
            txt_sAdres.Text = dr("sAdres").ToString
            txt_sTelefon1.Text = dr("sTelefon1").ToString
            txt_sTelefon2.Text = dr("sTelefon2").ToString
            txt_sTelefon3.Text = dr("sTelefon3").ToString
            txt_sFax.Text = dr("sFax").ToString
            txt_sGsm.Text = dr("sGsm").ToString
            txt_sEMail.Text = dr("sEMail").ToString
            txt_sUrl.Text = dr("sUrl").ToString
            txt_sAciklama.Text = dr("sAciklama").ToString
            XtraTabPage1.PageVisible = False
            XtraTabPage2.PageVisible = True
            XtraTabControl1.SelectedTabPageIndex = 1
            txt_sKodu.Focus()
            txt_sKodu.Select()
            islem = "duzelt"
        End If
    End Sub
    Private Sub ekle(ByVal sKodu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal sUnvan As String, ByVal sAdres As String, ByVal sTelefon1 As String, ByVal sTelefon2 As String, ByVal sTelefon3 As String, ByVal sFax As String, ByVal sGsm As String, ByVal sEmail As String, ByVal sUrl As String, ByVal sAciklama As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO aEmirIcraAvukat (sKodu, sAdi, sSoyadi, sUnvan, sAdres, sTelefon1, sTelefon2, sTelefon3, sFax, sGsm, sEmail, sUrl, sAciklama) VALUES     ('" & sKodu & "', '" & sAdi & "', '" & sSoyadi & "', '" & sUnvan & "', '" & sAdres & "', '" & sTelefon1 & "' , '" & sTelefon2 & "', '" & sTelefon3 & "', '" & sFax & "', '" & sGsm & "', '" & sEmail & "', '" & sUrl & "', '" & sAciklama & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub duzelt(ByVal sKodu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal sUnvan As String, ByVal sAdres As String, ByVal sTelefon1 As String, ByVal sTelefon2 As String, ByVal sTelefon3 As String, ByVal sFax As String, ByVal sGsm As String, ByVal sEmail As String, ByVal sUrl As String, ByVal sAciklama As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    aEmirIcraAvukat SET              sAdi = '" & sAdi & "', sSoyadi = '" & sSoyadi & "', sUnvan = '" & sUnvan & "', sAdres = '" & sAdres & "', sTelefon1 = '" & sTelefon1 & "', sTelefon2 = '" & sTelefon2 & "', sTelefon3 = '" & sTelefon3 & "', sFax = '" & sFax & "', sGsm = '" & sGsm & "', sEmail = '" & sEmail & "', sUrl = '" & sUrl & "', sAciklama = '" & sAciklama & "' WHERE sKodu = '" & sKodu & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub kayit_sil()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            satir = GridView1.FocusedRowHandle
            kayitno = dr("sKodu")
            If kayitno > 0 Then
                If XtraMessageBox.Show(kayitno & vbTab & Sorgu_sDil("Kodlu Avukat Kaydýný Silmek istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    sil(kayitno)
                End If
            End If
            dataload()
        End If
    End Sub
    Private Sub sil(ByVal sKodu As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("DELETE FROM aEmirIcraAvukat WHERE sKodu = '" & sKodu & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        kayit_ekle()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        kayit_duzelt()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
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
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If MenuItem6.Checked = False Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowAutoFilterRow = True
            MenuItem6.Checked = True
        ElseIf MenuItem6.Checked = True Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowAutoFilterRow = False
            MenuItem6.Checked = False
        End If
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        kayit_sil()
    End Sub
    Private Sub btn_kaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_kaydet.Click
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = False
        XtraTabControl1.SelectedTabPageIndex = 0
        GridControl1.Focus()
        GridControl1.Select()
        kaydet()
        kayitno = ""
        If islemstatus = True Then
            Me.Close()
        Else
            dataload()
        End If
        If islem = "duzelt" Then
            GridView1.FocusedRowHandle = satir
        End If
    End Sub
    Private Sub btn_vazgec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_vazgec.Click
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = False
        XtraTabControl1.SelectedTabPageIndex = 0
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If status = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.Close()
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
