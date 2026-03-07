Imports DevExpress.XtraEditors
Public Class frm_musteri_onaybekleyen
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
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
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
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents colnMusteriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMagaza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMusteri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnCinsiyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAylikGelir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKartAcilisTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIskontoPesin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIskontoKredili As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUnvan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsVergiDairesi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsVergiNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbYazismaEvAdresinemi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsYeriAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsAdresi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIsTelefonu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvAdresi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEvTelefonu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSigortaNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbEvlimi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteEvlilikTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteDogumTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDogumYeri As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsEhliyetNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKanGrubu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISTIHBARAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsGSM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSOZLESME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSýnýf1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSýnýf2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSýnýf3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSýnýf4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSýnýf5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panelstatus As DevExpress.XtraEditors.PanelControl
    Friend WithEvents barlabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bar As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_kefil As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colKefilSayisi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_tarih As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_SINIF2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_SINIF5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_musteri_onaybekleyen))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_tarih = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_kefil = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Panelstatus = New DevExpress.XtraEditors.PanelControl()
        Me.barlabel = New DevExpress.XtraEditors.LabelControl()
        Me.bar = New DevExpress.XtraEditors.ProgressBarControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
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
        Me.DataColumn21 = New System.Data.DataColumn()
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        Me.DataColumn25 = New System.Data.DataColumn()
        Me.DataColumn26 = New System.Data.DataColumn()
        Me.DataColumn27 = New System.Data.DataColumn()
        Me.DataColumn28 = New System.Data.DataColumn()
        Me.DataColumn29 = New System.Data.DataColumn()
        Me.DataColumn30 = New System.Data.DataColumn()
        Me.DataColumn31 = New System.Data.DataColumn()
        Me.DataColumn32 = New System.Data.DataColumn()
        Me.DataColumn33 = New System.Data.DataColumn()
        Me.DataColumn34 = New System.Data.DataColumn()
        Me.DataColumn35 = New System.Data.DataColumn()
        Me.DataColumn36 = New System.Data.DataColumn()
        Me.DataColumn37 = New System.Data.DataColumn()
        Me.DataColumn38 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnMusteriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsMagaza = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSoyadi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMusteri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnCinsiyet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collAylikGelir = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKartAcilisTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIskontoPesin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIskontoKredili = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUnvan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsVergiDairesi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsVergiNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbYazismaEvAdresinemi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIsYeriAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIsAdresi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIsTelefonu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEvAdresi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEvTelefonu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSigortaNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbEvlimi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteEvlilikTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteDogumTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDogumYeri = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsEhliyetNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKanGrubu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISTIHBARAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsGSM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSOZLESME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSýnýf1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSýnýf2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_SINIF2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSýnýf3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSýnýf4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSýnýf5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_SINIF5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colKefilSayisi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_tarih.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kefil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelstatus.SuspendLayout()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_SINIF2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_SINIF5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Controls.Add(Me.lbl_istihbarat)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 80)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_tarih)
        Me.GroupControl1.Controls.Add(Me.sec_kefil)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(459, 76)
        Me.GroupControl1.TabIndex = 35
        Me.GroupControl1.Text = "Ara"
        '
        'sec_tarih
        '
        Me.sec_tarih.EditValue = "Teslim Tarihi:"
        Me.sec_tarih.Location = New System.Drawing.Point(9, 23)
        Me.sec_tarih.Name = "sec_tarih"
        Me.sec_tarih.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.sec_tarih.Properties.Appearance.Options.UseBackColor = True
        Me.sec_tarih.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.sec_tarih.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_tarih.Properties.Items.AddRange(New Object() {"Satýþ Tarihi:", "Teslim Tarihi:"})
        Me.sec_tarih.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_tarih.Size = New System.Drawing.Size(88, 18)
        Me.sec_tarih.TabIndex = 39
        '
        'sec_kefil
        '
        Me.sec_kefil.EditValue = "[Tümü]"
        Me.sec_kefil.EnterMoveNextControl = True
        Me.sec_kefil.Location = New System.Drawing.Point(359, 21)
        Me.sec_kefil.Name = "sec_kefil"
        Me.sec_kefil.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kefil.Properties.Items.AddRange(New Object() {"[Tümü]", "Kefil Yok", "Kefil Var", "Yeni Kayýt"})
        Me.sec_kefil.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kefil.Size = New System.Drawing.Size(78, 20)
        Me.sec_kefil.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(46, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Müþteriler:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(299, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "arasýndaki"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(213, 21)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(83, 20)
        Me.DateEdit2.TabIndex = 1
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(102, 21)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(96, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Adý+Soyadý"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(214, 42)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Adý+Soyadý", "Kodu", "Adý", "Soyadý", "Ýstihbarat", "EvAdresi", "ÝþAdresi", "EvTelefonu", "ÝþTelefonu", "Gsm", "DoðumYeri", "1.Kefil Adý", "2.Kefil Adý", "Sýnýf1", "Sýnýf2", "Sýnýf3", "Sýnýf4", "Sýnýf5"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(83, 20)
        Me.sec_konum.TabIndex = 3
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(361, 42)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 20)
        Me.SimpleButton3.TabIndex = 5
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(297, 42)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(64, 20)
        Me.sec_kriter.TabIndex = 4
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(102, 42)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(112, 20)
        Me.txt_ara.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(199, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "ve"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(555, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(267, 13)
        Me.lbl_istihbarat.TabIndex = 37
        Me.lbl_istihbarat.Text = "istihbarat"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 399)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
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
        Me.PanelControl3.Controls.Add(Me.Panelstatus)
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 80)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 319)
        Me.PanelControl3.TabIndex = 0
        '
        'Panelstatus
        '
        Me.Panelstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panelstatus.Controls.Add(Me.barlabel)
        Me.Panelstatus.Controls.Add(Me.bar)
        Me.Panelstatus.Location = New System.Drawing.Point(176, 127)
        Me.Panelstatus.Name = "Panelstatus"
        Me.Panelstatus.Size = New System.Drawing.Size(472, 64)
        Me.Panelstatus.TabIndex = 2
        Me.Panelstatus.Visible = False
        '
        'barlabel
        '
        Me.barlabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barlabel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.barlabel.Appearance.ForeColor = System.Drawing.Color.Black
        Me.barlabel.Location = New System.Drawing.Point(8, 14)
        Me.barlabel.Name = "barlabel"
        Me.barlabel.Size = New System.Drawing.Size(46, 13)
        Me.barlabel.TabIndex = 3
        Me.barlabel.Text = "barlabel"
        '
        'bar
        '
        Me.bar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar.Location = New System.Drawing.Point(8, 33)
        Me.bar.Name = "bar"
        Me.bar.Properties.ShowTitle = True
        Me.bar.Size = New System.Drawing.Size(456, 18)
        Me.bar.TabIndex = 2
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
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_SINIF2, Me.sec_SINIF5})
        Me.GridControl1.Size = New System.Drawing.Size(820, 315)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem15, Me.MenuItem16, Me.MenuItem17, Me.MenuItem18, Me.MenuItem23, Me.MenuItem19, Me.MenuItem24, Me.MenuItem26, Me.MenuItem22, Me.MenuItem21, Me.MenuItem25, Me.MenuItem20, Me.MenuItem1, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem2, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        'MenuItem16
        '
        Me.MenuItem16.Index = 3
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem16.Text = "Kalan Taksitler"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 4
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem17.Text = "Kalan Satýþlar"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 5
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.ShiftF7
        Me.MenuItem18.Text = "Satýþlar"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 6
        Me.MenuItem23.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem23.Text = "Bekleyen Satýþlar"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 7
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem19.Text = "Müþteri Kartý"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 8
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.CtrlF4
        Me.MenuItem24.Text = "Müþteri Düzenle"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 9
        Me.MenuItem26.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItem26.Text = "Karlýlýk Akýþ Tablosu"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 10
        Me.MenuItem22.Text = "-"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 11
        Me.MenuItem21.Text = "Takibe Al"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 12
        Me.MenuItem25.Text = "SMS Gönder"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 13
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 14
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 15
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 16
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 17
        Me.MenuItem10.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 18
        Me.MenuItem2.Text = "Hýzlý Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 19
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 20
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 21
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 22
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 23
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 24
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 25
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem9.Text = "Ekraný Kapla"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nMusteriID"
        Me.DataColumn1.DataType = GetType(Long)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sMagaza"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "lKodu"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sAdi"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sSoyadi"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "Musteri"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "nCinsiyet"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = " lAylikGelir"
        Me.DataColumn8.DataType = GetType(Decimal)
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "dteKartAcilisTarihi"
        Me.DataColumn9.DataType = GetType(Date)
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "nIskontoPesin"
        Me.DataColumn10.DataType = GetType(Decimal)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "nIskontoKredili"
        Me.DataColumn11.DataType = GetType(Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sUnvan"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "sVergiDairesi"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sVergiNo"
        Me.DataColumn14.DataType = GetType(System.TimeSpan)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "bYazismaEvAdresinemi"
        Me.DataColumn15.DataType = GetType(Boolean)
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "sEmail"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "sIsYeriAdi"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "sIsAdresi"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "sIsTelefonu"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sEvAdresi"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "sEvTelefonu"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "sSigortaNo"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "bEvlimi"
        Me.DataColumn23.DataType = GetType(Boolean)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "dteEvlilikTarihi"
        Me.DataColumn24.DataType = GetType(Date)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "dteDogumTarihi"
        Me.DataColumn25.DataType = GetType(Date)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "sDogumYeri"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "sEhliyetNo"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "sKanGrubu"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "dteKayitTarihi"
        Me.DataColumn29.DataType = GetType(Date)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "ISTIHBARAT"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "sGSM"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "sFax"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "SOZLESME"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "Sýnýf1"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "Sýnýf2"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "Sýnýf3"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "Sýnýf4"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "Sýnýf5"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnMusteriID, Me.colsMagaza, Me.collKodu, Me.colsAdi, Me.colsSoyadi, Me.colMusteri, Me.colnCinsiyet, Me.collAylikGelir, Me.coldteKartAcilisTarihi, Me.colnIskontoPesin, Me.colnIskontoKredili, Me.colsUnvan, Me.colsVergiDairesi, Me.colsVergiNo, Me.colbYazismaEvAdresinemi, Me.colsEmail, Me.colsIsYeriAdi, Me.colsIsAdresi, Me.colsIsTelefonu, Me.colsEvAdresi, Me.colsEvTelefonu, Me.colsSigortaNo, Me.colbEvlimi, Me.coldteEvlilikTarihi, Me.coldteDogumTarihi, Me.colsDogumYeri, Me.colsEhliyetNo, Me.colsKanGrubu, Me.coldteKayitTarihi, Me.colISTIHBARAT, Me.colsGSM, Me.colsFax, Me.colSOZLESME, Me.colSýnýf1, Me.colSýnýf2, Me.colSýnýf3, Me.colSýnýf4, Me.colSýnýf5, Me.colKefilSayisi})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(268, 320, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Me.colMusteri, "{0} Kayýt")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colnMusteriID
        '
        Me.colnMusteriID.Caption = "Kayýt No"
        Me.colnMusteriID.FieldName = "nMusteriID"
        Me.colnMusteriID.Name = "colnMusteriID"
        Me.colnMusteriID.OptionsColumn.AllowEdit = False
        Me.colnMusteriID.Width = 37
        '
        'colsMagaza
        '
        Me.colsMagaza.Caption = "Maðaza"
        Me.colsMagaza.FieldName = "sMagaza"
        Me.colsMagaza.Name = "colsMagaza"
        Me.colsMagaza.OptionsColumn.AllowEdit = False
        Me.colsMagaza.Width = 50
        '
        'collKodu
        '
        Me.collKodu.Caption = "Müþteri Kodu"
        Me.collKodu.FieldName = "lKodu"
        Me.collKodu.Name = "collKodu"
        Me.collKodu.OptionsColumn.AllowEdit = False
        Me.collKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "lKodu", "{0} Kayýt")})
        Me.collKodu.Visible = True
        Me.collKodu.VisibleIndex = 0
        Me.collKodu.Width = 62
        '
        'colsAdi
        '
        Me.colsAdi.Caption = "Adý"
        Me.colsAdi.FieldName = "sAdi"
        Me.colsAdi.Name = "colsAdi"
        Me.colsAdi.OptionsColumn.AllowEdit = False
        Me.colsAdi.Width = 178
        '
        'colsSoyadi
        '
        Me.colsSoyadi.Caption = "Soyadý"
        Me.colsSoyadi.FieldName = "sSoyadi"
        Me.colsSoyadi.Name = "colsSoyadi"
        Me.colsSoyadi.OptionsColumn.AllowEdit = False
        Me.colsSoyadi.Width = 178
        '
        'colMusteri
        '
        Me.colMusteri.Caption = "Müþteri"
        Me.colMusteri.FieldName = "Musteri"
        Me.colMusteri.Name = "colMusteri"
        Me.colMusteri.OptionsColumn.AllowEdit = False
        Me.colMusteri.Visible = True
        Me.colMusteri.VisibleIndex = 1
        Me.colMusteri.Width = 91
        '
        'colnCinsiyet
        '
        Me.colnCinsiyet.Caption = "Cinsiyet"
        Me.colnCinsiyet.FieldName = "nCinsiyet"
        Me.colnCinsiyet.Name = "colnCinsiyet"
        Me.colnCinsiyet.OptionsColumn.AllowEdit = False
        Me.colnCinsiyet.Width = 72
        '
        'collAylikGelir
        '
        Me.collAylikGelir.Caption = "Aylýk Gelir"
        Me.collAylikGelir.FieldName = " lAylikGelir"
        Me.collAylikGelir.Name = "collAylikGelir"
        Me.collAylikGelir.OptionsColumn.AllowEdit = False
        '
        'coldteKartAcilisTarihi
        '
        Me.coldteKartAcilisTarihi.Caption = "Kart Açýlýþ Tarihi"
        Me.coldteKartAcilisTarihi.FieldName = "dteKartAcilisTarihi"
        Me.coldteKartAcilisTarihi.Name = "coldteKartAcilisTarihi"
        Me.coldteKartAcilisTarihi.OptionsColumn.AllowEdit = False
        Me.coldteKartAcilisTarihi.Width = 81
        '
        'colnIskontoPesin
        '
        Me.colnIskontoPesin.Caption = "Ýskonto Peþin"
        Me.colnIskontoPesin.FieldName = "nIskontoPesin"
        Me.colnIskontoPesin.Name = "colnIskontoPesin"
        Me.colnIskontoPesin.OptionsColumn.AllowEdit = False
        '
        'colnIskontoKredili
        '
        Me.colnIskontoKredili.Caption = "Ýskonto Kredili"
        Me.colnIskontoKredili.FieldName = "nIskontoKredili"
        Me.colnIskontoKredili.Name = "colnIskontoKredili"
        Me.colnIskontoKredili.OptionsColumn.AllowEdit = False
        '
        'colsUnvan
        '
        Me.colsUnvan.Caption = "Ünvan"
        Me.colsUnvan.FieldName = "sUnvan"
        Me.colsUnvan.Name = "colsUnvan"
        Me.colsUnvan.OptionsColumn.AllowEdit = False
        '
        'colsVergiDairesi
        '
        Me.colsVergiDairesi.Caption = "Vergi Dairesi"
        Me.colsVergiDairesi.FieldName = "sVergiDairesi"
        Me.colsVergiDairesi.Name = "colsVergiDairesi"
        Me.colsVergiDairesi.OptionsColumn.AllowEdit = False
        '
        'colsVergiNo
        '
        Me.colsVergiNo.Caption = "Vergi No"
        Me.colsVergiNo.FieldName = "sVergiNo"
        Me.colsVergiNo.Name = "colsVergiNo"
        Me.colsVergiNo.OptionsColumn.AllowEdit = False
        '
        'colbYazismaEvAdresinemi
        '
        Me.colbYazismaEvAdresinemi.Caption = "YazismaEvAdresinemi"
        Me.colbYazismaEvAdresinemi.FieldName = "bYazismaEvAdresinemi"
        Me.colbYazismaEvAdresinemi.Name = "colbYazismaEvAdresinemi"
        Me.colbYazismaEvAdresinemi.OptionsColumn.AllowEdit = False
        '
        'colsEmail
        '
        Me.colsEmail.Caption = "Email"
        Me.colsEmail.FieldName = "sEmail"
        Me.colsEmail.Name = "colsEmail"
        Me.colsEmail.OptionsColumn.AllowEdit = False
        '
        'colsIsYeriAdi
        '
        Me.colsIsYeriAdi.Caption = "Ýþ Yeri Adý"
        Me.colsIsYeriAdi.FieldName = "sIsYeriAdi"
        Me.colsIsYeriAdi.Name = "colsIsYeriAdi"
        Me.colsIsYeriAdi.OptionsColumn.AllowEdit = False
        '
        'colsIsAdresi
        '
        Me.colsIsAdresi.Caption = "Ýþ Adresi"
        Me.colsIsAdresi.FieldName = "sIsAdresi"
        Me.colsIsAdresi.Name = "colsIsAdresi"
        Me.colsIsAdresi.OptionsColumn.AllowEdit = False
        '
        'colsIsTelefonu
        '
        Me.colsIsTelefonu.Caption = "Ýþ Telefonu"
        Me.colsIsTelefonu.FieldName = "sIsTelefonu"
        Me.colsIsTelefonu.Name = "colsIsTelefonu"
        Me.colsIsTelefonu.OptionsColumn.AllowEdit = False
        '
        'colsEvAdresi
        '
        Me.colsEvAdresi.Caption = "Ev Adresi"
        Me.colsEvAdresi.FieldName = "sEvAdresi"
        Me.colsEvAdresi.Name = "colsEvAdresi"
        Me.colsEvAdresi.OptionsColumn.AllowEdit = False
        Me.colsEvAdresi.Visible = True
        Me.colsEvAdresi.VisibleIndex = 3
        Me.colsEvAdresi.Width = 117
        '
        'colsEvTelefonu
        '
        Me.colsEvTelefonu.Caption = "Ev Telefonu"
        Me.colsEvTelefonu.FieldName = "sEvTelefonu"
        Me.colsEvTelefonu.Name = "colsEvTelefonu"
        Me.colsEvTelefonu.OptionsColumn.AllowEdit = False
        Me.colsEvTelefonu.Visible = True
        Me.colsEvTelefonu.VisibleIndex = 4
        Me.colsEvTelefonu.Width = 77
        '
        'colsSigortaNo
        '
        Me.colsSigortaNo.Caption = "Sigorta No"
        Me.colsSigortaNo.FieldName = "sSigortaNo"
        Me.colsSigortaNo.Name = "colsSigortaNo"
        Me.colsSigortaNo.OptionsColumn.AllowEdit = False
        '
        'colbEvlimi
        '
        Me.colbEvlimi.Caption = "Evlimi"
        Me.colbEvlimi.FieldName = "bEvlimi"
        Me.colbEvlimi.Name = "colbEvlimi"
        Me.colbEvlimi.OptionsColumn.AllowEdit = False
        '
        'coldteEvlilikTarihi
        '
        Me.coldteEvlilikTarihi.Caption = "Evlilik Tarihi"
        Me.coldteEvlilikTarihi.FieldName = "dteEvlilikTarihi"
        Me.coldteEvlilikTarihi.Name = "coldteEvlilikTarihi"
        Me.coldteEvlilikTarihi.OptionsColumn.AllowEdit = False
        '
        'coldteDogumTarihi
        '
        Me.coldteDogumTarihi.Caption = "Doðum Tarihi"
        Me.coldteDogumTarihi.FieldName = "dteDogumTarihi"
        Me.coldteDogumTarihi.Name = "coldteDogumTarihi"
        Me.coldteDogumTarihi.OptionsColumn.AllowEdit = False
        '
        'colsDogumYeri
        '
        Me.colsDogumYeri.Caption = "Doðum Yeri"
        Me.colsDogumYeri.FieldName = "sDogumYeri"
        Me.colsDogumYeri.Name = "colsDogumYeri"
        Me.colsDogumYeri.OptionsColumn.AllowEdit = False
        '
        'colsEhliyetNo
        '
        Me.colsEhliyetNo.Caption = "Ehliyet No"
        Me.colsEhliyetNo.FieldName = "sEhliyetNo"
        Me.colsEhliyetNo.Name = "colsEhliyetNo"
        Me.colsEhliyetNo.OptionsColumn.AllowEdit = False
        '
        'colsKanGrubu
        '
        Me.colsKanGrubu.Caption = "Kan Grubu"
        Me.colsKanGrubu.FieldName = "sKanGrubu"
        Me.colsKanGrubu.Name = "colsKanGrubu"
        Me.colsKanGrubu.OptionsColumn.AllowEdit = False
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "Kayýt Tarihi"
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        Me.coldteKayitTarihi.OptionsColumn.AllowEdit = False
        Me.coldteKayitTarihi.Visible = True
        Me.coldteKayitTarihi.VisibleIndex = 2
        Me.coldteKayitTarihi.Width = 57
        '
        'colISTIHBARAT
        '
        Me.colISTIHBARAT.Caption = "ISTIHBARAT"
        Me.colISTIHBARAT.FieldName = "ISTIHBARAT"
        Me.colISTIHBARAT.Name = "colISTIHBARAT"
        Me.colISTIHBARAT.OptionsColumn.AllowEdit = False
        '
        'colsGSM
        '
        Me.colsGSM.Caption = "GSM"
        Me.colsGSM.FieldName = "sGSM"
        Me.colsGSM.Name = "colsGSM"
        Me.colsGSM.OptionsColumn.AllowEdit = False
        Me.colsGSM.Visible = True
        Me.colsGSM.VisibleIndex = 5
        Me.colsGSM.Width = 48
        '
        'colsFax
        '
        Me.colsFax.Caption = "Fax"
        Me.colsFax.FieldName = "sFax"
        Me.colsFax.Name = "colsFax"
        Me.colsFax.OptionsColumn.AllowEdit = False
        '
        'colSOZLESME
        '
        Me.colSOZLESME.Caption = "Sözleþme No"
        Me.colSOZLESME.FieldName = "SOZLESME"
        Me.colSOZLESME.Name = "colSOZLESME"
        Me.colSOZLESME.OptionsColumn.AllowEdit = False
        Me.colSOZLESME.Visible = True
        Me.colSOZLESME.VisibleIndex = 10
        Me.colSOZLESME.Width = 65
        '
        'colSýnýf1
        '
        Me.colSýnýf1.Caption = "Sýnýf 1"
        Me.colSýnýf1.FieldName = "Sýnýf1"
        Me.colSýnýf1.Name = "colSýnýf1"
        Me.colSýnýf1.OptionsColumn.AllowEdit = False
        Me.colSýnýf1.Visible = True
        Me.colSýnýf1.VisibleIndex = 6
        Me.colSýnýf1.Width = 53
        '
        'colSýnýf2
        '
        Me.colSýnýf2.Caption = "Sýnýf 2"
        Me.colSýnýf2.ColumnEdit = Me.sec_SINIF2
        Me.colSýnýf2.FieldName = "Sýnýf2"
        Me.colSýnýf2.Name = "colSýnýf2"
        Me.colSýnýf2.Visible = True
        Me.colSýnýf2.VisibleIndex = 7
        '
        'sec_SINIF2
        '
        Me.sec_SINIF2.AutoHeight = False
        Me.sec_SINIF2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_SINIF2.DisplayMember = "sAciklama"
        Me.sec_SINIF2.Name = "sec_SINIF2"
        Me.sec_SINIF2.NullText = ""
        Me.sec_SINIF2.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_SINIF2.ValueMember = "sSinifKodu"
        '
        'colSýnýf3
        '
        Me.colSýnýf3.Caption = "Sýnýf 3"
        Me.colSýnýf3.FieldName = "Sýnýf3"
        Me.colSýnýf3.Name = "colSýnýf3"
        Me.colSýnýf3.OptionsColumn.AllowEdit = False
        Me.colSýnýf3.Visible = True
        Me.colSýnýf3.VisibleIndex = 9
        Me.colSýnýf3.Width = 78
        '
        'colSýnýf4
        '
        Me.colSýnýf4.Caption = "Sýnýf 4"
        Me.colSýnýf4.FieldName = "Sýnýf4"
        Me.colSýnýf4.Name = "colSýnýf4"
        Me.colSýnýf4.OptionsColumn.AllowEdit = False
        '
        'colSýnýf5
        '
        Me.colSýnýf5.Caption = "Sýnýf 5"
        Me.colSýnýf5.ColumnEdit = Me.sec_SINIF5
        Me.colSýnýf5.FieldName = "Sýnýf5"
        Me.colSýnýf5.Name = "colSýnýf5"
        Me.colSýnýf5.Visible = True
        Me.colSýnýf5.VisibleIndex = 8
        '
        'sec_SINIF5
        '
        Me.sec_SINIF5.AutoHeight = False
        Me.sec_SINIF5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_SINIF5.DisplayMember = "sAciklama"
        Me.sec_SINIF5.Name = "sec_SINIF5"
        Me.sec_SINIF5.NullText = "[sAciklama]"
        Me.sec_SINIF5.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_SINIF5.ValueMember = "sSinifKodu"
        '
        'colKefilSayisi
        '
        Me.colKefilSayisi.Caption = "Kefil Sayýsý"
        Me.colKefilSayisi.FieldName = "KefilSayisi"
        Me.colKefilSayisi.Name = "colKefilSayisi"
        Me.colKefilSayisi.OptionsColumn.AllowEdit = False
        Me.colKefilSayisi.Visible = True
        Me.colKefilSayisi.VisibleIndex = 11
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Satýþ Onayý Bekleyen Müþteriler", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Crm-Müþteri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10})
        Me.BarManager1.MaxItemId = 10
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Musteri Karti,F4"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Satýþlar ,F7"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Kalan Satýþlar,F6"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Kalan Taksitler,F8"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Ekstre"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Notlar ,F9"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Excel"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Text"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Mail"
        Me.BarButtonItem10.Id = 9
        Me.BarButtonItem10.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem10.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem10.Name = "BarButtonItem10"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 447)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 447)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 447)
        '
        'frm_musteri_onaybekleyen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(824, 469)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_musteri_onaybekleyen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Satýþ Onayý Bekleyen Müþteriler"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_tarih.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kefil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelstatus.ResumeLayout(False)
        Me.Panelstatus.PerformLayout()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_SINIF2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_SINIF5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public kullanici
    Public kasiyer
    Public kasiyerno
    Dim dr As DataRow
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        DateEdit1.EditValue = dteSistemTarihi
        DateEdit2.EditValue = dteSistemTarihi
        DateEdit1.Focus()
        DateEdit1.Select()
        txt_ara.EditValue = ""
        dataload_sinif()
        'dataload()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView1.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        GridView1.OptionsView.ShowGroupPanel = True
        GridView1.OptionsCustomization.AllowGroup = True
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        GridView1.CollapseAllGroups()
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
        Dim kriter As String = ""
        kriter += Microsoft.VisualBasic.Left(DateEdit1.EditValue.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(DateEdit2.EditValue.ToString, 10) & " Tarihleri Arasýndaki Satýþ Sonrasý Onay Bekleyen Müþteriler" & vbCrLf
        printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Crm-Müþteri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
        kriter = Nothing
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
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
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Sub dataload_sinif()
        sec_SINIF2.DataSource = sorgu(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbMSinif2")).Tables(0) 'DataSet2.Tables(0)
        sec_SINIF5.DataSource = sorgu(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbMSinif5")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        con.Close()
        Return DS
    End Function
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
    Public Function stok(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal kefil_kriter As String) As DataSet
        Dim kriter
        'kriter = "WHERE tbMusteri.dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih2.ToString, 10) + " 23:59:59" & "' "
        kriter = "WHERE tbMusteri.lKodu > 0 "
        If ara.ToString <> "" Then
            If sec_konum.Text = "Kodu" Then
                kriter += " AND ( tbMusteri.lKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Adý" Then
                kriter += " AND ( tbMusteri.sAdi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Soyadý" Then
                kriter += " AND ( tbMusteri.sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Ýstihbarat" Then
                kriter += " AND (( tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + '  ' + tbMusteri.sAciklama5) " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "EvAdresi" Then
                kriter += " AND (tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu + ' ' + tbMusteri.sEvIl  " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "ÝþAdresi" Then
                kriter += " AND (tbMusteri.sIsAdresi1 + ' ' + tbMusteri.sIsAdresi2 + ' ' + tbMusteri.sIsSemt + ' ' + tbMusteri.sIsIl + ' ' + tbMusteri.sIsPostaKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "EvTelefonu" Then
                kriter += " AND ( tbMusteri.sEvTelefonu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "ÝþTelefonu" Then
                kriter += " AND ( tbMusteri.sIsTelefonu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Gsm" Then
                kriter += " AND ( tbMusteri.sGsm " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "DoðumYeri" Then
                kriter += " AND ( tbMusteri.sDogumYeri " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "1.Kefil Adý" Then
                kriter += " AND tbMusteri.nMusteriID IN (Select nMusteriID from tbMusteriKefil1 where sAdi + ' ' + sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "2.Kefil Adý" Then
                kriter += " AND tbMusteri.nMusteriID IN (Select nMusteriID from tbMusteriKefil2 where sAdi + ' ' + sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf1" Then
                kriter += " AND (tbMSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf2" Then
                kriter += " AND (tbMSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf3" Then
                kriter += " AND (tbMSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf4" Then
                kriter += " AND (tbMSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sýnýf5" Then
                kriter += " AND (tbMSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Adý+Soyadý" Then
                Dim adi As String = ""
                Dim soyadi As String = ""
                Dim x
                If CStr(ara.ToString) <> "" Then
                    x = (ara).IndexOf(" ", 1, (ara.Length - 1))
                    If x = -1 Then
                        adi = ara
                    Else
                        adi = (ara).Substring(0, x)
                        soyadi = (ara).Substring((x + 1), (ara).Length - (x + 1))
                    End If
                End If
                'MsgBox(Sorgu_sDil("Adi :" & vbTab & adi & vbCrLf & "Soyadi :" & vbTab & soyadi)
                If adi.ToString <> "" Then
                    kriter += " AND ( tbMusteri.sAdi " & sorgu_kriter_string(adi, ara_kriter) & " )"
                End If
                If soyadi.ToString <> "" Then
                    kriter += " AND ( tbMusteri.sSoyadi " & sorgu_kriter_string(soyadi, ara_kriter) & " )"
                End If
            End If
        End If
        If sec_tarih.Text = "Satýþ Tarihi:" Then
            kriter += " AND tbMusteri.nMusteriID IN (SELECT DISTINCT nMusteriID FROM (SELECT tbAlisVeris.nAlisverisID AS ALISVERISNO , tbAlisVeris.sFisTipi AS IZAHAT , tbMusteri.nMusteriID , tbStok.sKodu , tbStok.sModel , tbStok.sRenk , tbRenk.sRenkAdi , tbStok.sBeden , tbStok.sKavala , tbStok.sAciklama , (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut , (SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1 , tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1 AS Miktar , tbAlisverisSiparis.lBrutFiyat , (tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari) * (tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) / tbAlisverisSiparis.lGCMiktar AS Tutar , RTRIM(tbDepo.sDepo) + ' ' + RTRIM(tbDepo.sAciklama) AS Depo , tbAlisVeris.lFaturaNo , tbAlisVeris.dteFaturaTarihi , tbAlisverisSiparis.dteTeslimEdilecek , tbAlisverisSiparis.dteOnayTarihi , tbAlisverisSiparis.dteTeslimEdilen , CASE tbAlisverisSiparis.bekalan2 WHEN '' THEN '01/01/1900' ELSE (SELECT dteIslemTarihi FROM tbStokFisiDetayi WHERE nIslemID = tbAlisverisSiparis.bEkAlan2) END AS Expr1 FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID INNER JOIN tbDepo ON tbAlisverisSiparis.sMagazaKodu = tbDepo.sDepo INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbMusteri.lKodu BETWEEN 0 AND 999999999) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048')) t)"
        ElseIf sec_tarih.Text = "Teslim Tarihi:" Then
            kriter += " AND tbMusteri.nMusteriID IN (SELECT DISTINCT nMusteriID FROM (SELECT tbAlisVeris.nAlisverisID AS ALISVERISNO , tbAlisVeris.sFisTipi AS IZAHAT , tbMusteri.nMusteriID , tbStok.sKodu , tbStok.sModel , tbStok.sRenk , tbRenk.sRenkAdi , tbStok.sBeden , tbStok.sKavala , tbStok.sAciklama , (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut , (SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1 , tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1 AS Miktar , tbAlisverisSiparis.lBrutFiyat , (tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari) * (tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) / tbAlisverisSiparis.lGCMiktar AS Tutar , RTRIM(tbDepo.sDepo) + ' ' + RTRIM(tbDepo.sAciklama) AS Depo , tbAlisVeris.lFaturaNo , tbAlisVeris.dteFaturaTarihi , tbAlisverisSiparis.dteTeslimEdilecek , tbAlisverisSiparis.dteOnayTarihi , tbAlisverisSiparis.dteTeslimEdilen , CASE tbAlisverisSiparis.bekalan2 WHEN '' THEN '01/01/1900' ELSE (SELECT dteIslemTarihi FROM tbStokFisiDetayi WHERE nIslemID = tbAlisverisSiparis.bEkAlan2) END AS Expr1 FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID INNER JOIN tbDepo ON tbAlisverisSiparis.sMagazaKodu = tbDepo.sDepo INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbMusteri.lKodu BETWEEN 0 AND 999999999) AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') ) t)"
        End If
        If kefil_kriter = "[Tümü]" Then
        ElseIf kefil_kriter = "Kefil Var" Then
            kriter += " AND tbMusteri.nMusteriID IN (SELECT nMusteriID FROM (SELECT * FROM tbMusteriKefil1 WHERE sAdi <> '' UNION ALL SELECT * FROM tbMusteriKefil2 WHERE sAdi <> '') Kefil)  "
        ElseIf kefil_kriter = "Kefil Yok" Then
            kriter += " AND tbMusteri.nMusteriID NOT IN (SELECT nMusteriID FROM (SELECT * FROM tbMusteriKefil1 WHERE sAdi <> '' UNION ALL SELECT * FROM tbMusteriKefil2 WHERE sAdi <> '') Kefil)  "
        ElseIf kefil_kriter = "Yeni Kayýt" Then
            kriter += " AND tbMusteri.dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih2.ToString, 10) + " 23:59:59" & "' "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.sMagaza, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS Musteri, tbMusteri.nCinsiyet, tbMusteri.lAylikGelir, tbMusteri.dteKartAcilisTarihi, tbMusteri.nIskontoPesin, tbMusteri.nIskontoKredili, tbMusteri.sUnvan, tbMusteri.sVergiDairesi, tbMusteri.sVergiNo, tbMusteri.bYazismaEvAdresinemi, tbMusteri.sEmail, tbMusteri.sIsYeriAdi, tbMusteri.sIsAdresi1 + ' ' + tbMusteri.sIsAdresi2 + ' ' + tbMusteri.sIsSemt + ' ' + tbMusteri.sIsIl + ' ' + tbMusteri.sIsPostaKodu AS sIsAdresi, tbMusteri.sIsTelefonu, tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu + ' ' + tbMusteri.sEvIl AS sEvAdresi, tbMusteri.sEvTelefonu, tbMusteri.sSigortaNo, tbMusteri.bEvlimi, tbMusteri.dteEvlilikTarihi, tbMusteri.dteDogumTarihi, tbMusteri.sDogumYeri, tbMusteri.sEhliyetNo, tbMusteri.sKanGrubu, tbMusteri.dteKayitTarihi, tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + ' ' + tbMusteri.sAciklama5 AS ISTIHBARAT, tbMusteri.sGSM, tbMusteri.sFax, (SELECT TOP 1 nKartNo FROM tbMusteriKarti WHERE nMusteriID = tbMusteri.nMusteriID ORDER BY dteKayitTarihi DESC) AS SOZLESME, tbMSinif1.sAciklama AS Sýnýf1, tbMSinif2.sSinifKodu AS Sýnýf2, tbMSinif3.sAciklama AS Sýnýf3, tbMSinif4.sAciklama AS Sýnýf4, tbMSinif5.sSinifKodu AS Sýnýf5,(SELECT ISNULL(COUNT(*),0) AS KefilSayisi FROM (SELECT * FROM tbMusteriKefil1 WHERE sAdi <> '' UNION ALL SELECT * FROM tbMusteriKefil2 WHERE sAdi <> '') Kefil WHERE (nMusteriID = tbMusteri.nMusteriID)) as KefilSayisi FROM tbMusteri INNER JOIN tbMusteriSinifi ON tbMusteri.nMusteriID = tbMusteriSinifi.nMusteriID INNER JOIN tbMSinif1 ON tbMusteriSinifi.sSinifKodu1 = tbMSinif1.sSinifKodu INNER JOIN tbMSinif2 ON tbMusteriSinifi.sSinifKodu2 = tbMSinif2.sSinifKodu INNER JOIN tbMSinif3 ON tbMusteriSinifi.sSinifKodu3 = tbMSinif3.sSinifKodu INNER JOIN tbMSinif4 ON tbMusteriSinifi.sSinifKodu4 = tbMSinif4.sSinifKodu INNER JOIN tbMSinif5 ON tbMusteriSinifi.sSinifKodu5 = tbMSinif5.sSinifKodu " & kriter & " ")
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
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal kefil_kriter As String)
        DataSet1 = stok(tarih1, tarih2, ara, konum, ara_kriter, kefil_kriter)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub tutar_hesapla()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            tbMusteriSinifi_kaydet_degistir(dr("nMusteriID"), dr("Sýnýf2"))
        End If
    End Sub
    Private Sub tbMusteriSinifi_kaydet_degistir(ByVal nMusteriID As String, ByVal sSinifKodu2 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMusteriSinifi  SET              sSinifKodu2 = '" & sSinifKodu2 & "'  WHERE nMusteriID = '" & nMusteriID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub stok_satis_detay()
        If GridView1.RowCount > 0 Then
            Dim frm As New frm_stok_cari_satis
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            frm.status = True
            frm.firmano = 100
            frm.donemno = 1
            frm.connection = connection
            frm.islemstatus = True
            frm.stokno = dr("nAlisverisID")
            frm.fistipi = Trim(dr("sFisTipi").ToString)
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_musteri_karti
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("lKodu")
            frm.musteriID = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_duzenle()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_musteri_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.lKodu = dr("lKodu")
            frm.nMusteriID = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_acik_faturalar_analiz()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_acik_analiz
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_acik_faturalar()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_acik
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_satislar()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_kapatma
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("lKodu")
            frm.musteriID = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_hareket_ekstre()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_ekstre
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("lKodu")
            frm.musteriID = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub musteri_notlari()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_musteri_karti_aciklama
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kayitno = dr("nMusteriID")
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
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stok_satis_detay()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        Try
            If GridView1.SelectedRowsCount > 1 Then
                Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
            ElseIf GridView1.SelectedRowsCount = 1 Then
                Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
            Else
                Label2.Text = ""
            End If
            If GridView1.RowCount > 0 Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                lbl_istihbarat.Text = dr("ISTIHBARAT")
                dr = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            'If XtraMessageBox.Show(Sorgu_sDil("Açýk Faturalar Kontrol Ekranýndan Çýkmak Ýstediðinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        analiz_musteri_karti()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        analiz_musteri_satislar()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        analiz_acik_faturalar()
    End Sub
    Private Sub MenuItem16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, sec_kefil.Text)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub SMS_Gonder()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayýtlara SMS Göndermek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim frm As New frm_Perakende_SMS_Gonder
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    If Trim(dr("sGSM")) <> "" Then
                        Dim dr1 As DataRow = frm.DataSet1.Tables(0).NewRow
                        dr1("nIslemID") = 0
                        dr1("sSMSID") = 0
                        dr1("dteGonderimTarihi") = Today
                        dr1("sMesaj") = ""
                        dr1("nMusteriID") = dr("nMusteriID")
                        dr1("lKodu") = dr("lKodu")
                        dr1("sAdi") = dr("sAdi")
                        dr1("sSoyadi") = dr("sSoyadi")
                        dr1("sTelefon") = dr("sGSM")
                        dr1("dteUpdateTarihi") = Now
                        dr1("lDurum") = 0
                        dr1("lBakiye") = 0
                        frm.DataSet1.Tables(0).Rows.Add(dr1)
                    End If
                Next
            End If
            'MsgBox(Sorgu_sDil("Ýþlem Tamamlandý...!",sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
            s = Nothing
            arr = Nothing
            i = Nothing
            dr = Nothing
            frm.ShowDialog()
        End If
    End Sub
    Private Sub analiz_musteri_KarlilikAkisTablosu(Optional ByVal islem As Integer = 0)
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_satis_karlilik
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.DateEdit1.EditValue = "01/01/1900"
            frm.DateEdit2.EditValue = dteSistemTarihi
            frm.txt_ara.Text = ""
            frm.txt_ara_stok.Text = ""
            frm.sec_MaliyetTipi.Text = "Stok Kartýndan"
            frm.kriter_musteriID = "AND tbMusteri.nMusteriID = " & dr("nMusteriID") & " "
            If islem = 3 Then
                frm.kriter_fistipi = "'DC'"
                frm.islem = 2
            Else
                frm.islem = islem
            End If
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            dr = Nothing
            frm = Nothing
        End If
    End Sub
    Private Sub takibe_al()
        Dim frm As New frm_emir_musteri_takip_toplu
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kasiyerno = kasiyerno
        frm.kasiyer = kasiyer
        frm.txt_takip_aciklama.Text = ""
        frm.status = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr As DataRow
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim toplamsayi = GridView1.SelectedRowsCount
            Dim sayi = 0
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                Panelstatus.Visible = True
                bar.Properties.Maximum = GridView1.SelectedRowsCount
                barlabel.Text = "Toplam Satýr Sayýsý : " & GridView1.SelectedRowsCount
                bar.Position = 0
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    barlabel.Text = "MüþteriKodu:" & dr("lKodu").ToString & vbTab & "Adý:" & dr("Musteri").ToString
                    barlabel.Refresh()
                    takib_ekle(frm.txt_tarih.EditValue, frm.sec_takiptipi.Text, frm.txt_takip_aciklama.Text, frm.sec_personel.EditValue, frm.sec_personel.Text, dr("nMusteriID"), dr("lKodu"), dr("sAdi"), dr("sSoyadi"), Microsoft.VisualBasic.Left(dr("Musteri"), 50), "Bekliyor", Microsoft.VisualBasic.Left(("01.01.1900").ToString, 10) + " " + "00:00:00", "", "", False, "01.01.1900", 0, False, "", "", "", "", "", False)
                    bar.Position = bar.Position + 1
                    bar.Refresh()
                Next
                bar.Position = 0
                Panelstatus.Visible = False
                dr = Nothing
            End If
            frm.Dispose()
            frm.Close()
            System.GC.SuppressFinalize(frm)
            frm = Nothing
            XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub takib_ekle(ByVal dteTarih As DateTime, ByVal TakipTipi As String, ByVal TakipAciklama As String, ByVal PersonelNo As Int64, ByVal Personel As String, ByVal nMusteriID As String, ByVal lKodu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal Musteri As String, ByVal Sonuc As String, ByVal IletisimTarihi As DateTime, ByVal IletisimSekli As String, ByVal IlgiliKisi As String, ByVal Gelecekmi As Byte, ByVal GTarih As DateTime, ByVal Tutar As Decimal, ByVal Odendi As Byte, ByVal Istihbarat As String, ByVal Aciklama1 As String, ByVal Aciklama2 As String, ByVal Aciklama3 As String, ByVal Aciklama4 As String, ByVal Status As Byte)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        'Dim ilk_personel As Decimal = 0
        'ilk_personel = sorgu_ilkpersonelno(nMusteriID).ToString
        'If ilk_personel > 0 Then
        '    PersonelNo = ilk_personel
        '    Personel = sorgu_ilkpersoneladi(ilk_personel)
        'Else
        'End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO aEmirMusteriTakip                       (dteTarih, TakipTipi, TakipAciklama, PersonelNo, Personel, nMusteriID,lKodu, sAdi, sSoyadi, Musteri, Sonuc, IletisimTarihi, IletisimSekli, IlgiliKisi, Gelecekmi, GTarih, Tutar, Odendi, Istihbarat, Aciklama1, Aciklama2, Aciklama3, Aciklama4, Status,KayitTarihi,ErisimTarihi) VALUES     ('" & dteTarih & "', '" & TakipTipi & "', '" & TakipAciklama & "', " & PersonelNo & ", '" & Personel & "','" & nMusteriID & "', '" & lKodu & "', '" & sAdi & "', '" & sSoyadi & "', '" & Musteri & "', '" & Sonuc & "', '" & IletisimTarihi & "', '" & IletisimSekli & "', '" & IlgiliKisi & "', " & Gelecekmi & ", '" & GTarih & "', " & Tutar & " , " & Odendi & ", '" & Istihbarat & "', '" & Aciklama1 & "', '" & Aciklama2 & "', '" & Aciklama3 & "', '" & Aciklama4 & "', " & Status & " ,'" & Now & "','" & Now & "')")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
        'ilk_personel = Nothing
    End Sub
    Public Function sorgu_ilkpersonelno(ByVal nMusteriID) As Int64
        Dim kriter
        kriter = "WHERE (nMusteriID = '" & nMusteriID & "') and TakipTipi <> 'Teslimat' "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(PersonelNo, 0) AS PersonelNo FROM         aEmirMusteriTakip " & kriter & " ORDER BY IND DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_ilkpersoneladi(ByVal PersonelNo As Int64) As String
        Dim kriter
        kriter = "WHERE (IND = '" & PersonelNo & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     PERSONELADI FROM         APERSONEL        " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub analiz_bekleyen()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_satis_bekleyen_onaysiz
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.firmakodu = dr("lKodu").ToString
            frm.tarih1 = "01/01/1900"
            frm.tarih2 = "31/12/2048"
            frm.qfirmakodu = "Eþittir"
            frm.islemstatus = True
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            dr = Nothing
            frm = Nothing
        End If
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        takibe_al()
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        analiz_bekleyen()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView1.OptionsCustomization.AllowFilter = True
        GridView1.OptionsView.ShowAutoFilterRow = True
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            tutar_hesapla()
        End If
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        analiz_musteri_duzenle()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        analiz_musteri_karti()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        analiz_musteri_satislar()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        analiz_acik_faturalar()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_musteri_hareket_ekstre()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        musteri_notlari()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        raporla_pdf()
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        SMS_Gonder()
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        analiz_musteri_KarlilikAkisTablosu()
    End Sub
End Class
