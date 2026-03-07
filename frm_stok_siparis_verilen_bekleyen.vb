Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_stok_siparis_verilen_bekleyen
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
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
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
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents colsFirmaKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFirmaAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsModel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenkAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBeden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKavala As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSatirAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteIlkSevkiyatTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBirimCinsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSipNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteSiparisTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTeslimTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSiparisIslem As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSiparisMiktari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSiparisTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSiparisTutari1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSiparisTutari2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collSevkMiktari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collSevkTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKalanMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKalanTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsPartiKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collGirisMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collGirisTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collEnvanterMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collEnvanterTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFarkMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFarkTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKrediLimiti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnValorGun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbKapandimi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBirimFiyati As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizKuru As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizFiyati As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collSevkIadeMiktari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collToplamRisk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBirimFiyati1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents collBirimFiyati2 As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_siparis_verilen_bekleyen))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.Label1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.Label2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
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
        Me.DataColumn32 = New System.Data.DataColumn
        Me.DataColumn33 = New System.Data.DataColumn
        Me.DataColumn34 = New System.Data.DataColumn
        Me.DataColumn35 = New System.Data.DataColumn
        Me.DataColumn36 = New System.Data.DataColumn
        Me.DataColumn37 = New System.Data.DataColumn
        Me.DataColumn38 = New System.Data.DataColumn
        Me.DataColumn39 = New System.Data.DataColumn
        Me.DataColumn40 = New System.Data.DataColumn
        Me.DataColumn41 = New System.Data.DataColumn
        Me.DataColumn42 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colsFirmaKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsFirmaAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsModel = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsRenkAdi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsKavala = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsSatirAciklama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteIlkSevkiyatTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsBirimCinsi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsSipNo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteSiparisTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.coldteTeslimTarihi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsSiparisIslem = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSiparisMiktari = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSiparisTutari = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSiparisTutari1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSiparisTutari2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collSevkMiktari = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collSevkTutari = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collKalanMiktar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collKalanTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsPartiKodu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collGirisMiktar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collGirisTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collEnvanterMiktar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collEnvanterTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collFarkMiktar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collFarkTutar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collKrediLimiti = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnValorGun = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colbKapandimi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collBirimFiyati = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsDovizCinsi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collDovizKuru = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collDovizFiyati = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collSevkIadeMiktari = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collBakiye = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collToplamRisk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collBirimFiyati1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.collBirimFiyati2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
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
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(191, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Verilen Sipariþlerin Durumu Aþaðýdadýr..."
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
        Me.PanelControl2.Location = New System.Drawing.Point(0, 359)
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
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 303)
        Me.PanelControl3.TabIndex = 0
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
        Me.GridControl1.Size = New System.Drawing.Size(820, 299)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem16, Me.MenuItem15, Me.MenuItem17, Me.MenuItem18, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem19, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        'MenuItem16
        '
        Me.MenuItem16.Index = 2
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem16.Text = "Envanter"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 3
        Me.MenuItem15.Text = "-"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 4
        Me.MenuItem17.Text = "Sipariþi Kapat"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 5
        Me.MenuItem18.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 6
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 7
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 8
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 9
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 10
        Me.MenuItem10.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 11
        Me.MenuItem19.Text = "Hýzlý Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 12
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 13
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 14
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 15
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 16
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 17
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 18
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "sFirmaKodu"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sFirmaAdi"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sModel"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sRenk"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sRenkAdi"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sBeden"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "sKavala"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sAciklama"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sSatirAciklama"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "dteIlkSevkiyatTarihi"
        Me.DataColumn10.DataType = GetType(Date)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sBirimCinsi"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sSipNo"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "dteSiparisTarihi"
        Me.DataColumn13.DataType = GetType(Date)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "dteTeslimTarihi"
        Me.DataColumn14.DataType = GetType(Date)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sSiparisIslem"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "SiparisMiktari"
        Me.DataColumn16.DataType = GetType(Decimal)
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "SiparisTutari"
        Me.DataColumn17.DataType = GetType(Decimal)
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "SiparisTutari1"
        Me.DataColumn18.DataType = GetType(Decimal)
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "SiparisTutari2"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "lSevkMiktari"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "lSevkTutari"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "lKalanMiktar"
        Me.DataColumn22.DataType = GetType(Decimal)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "lKalanTutar"
        Me.DataColumn23.DataType = GetType(Decimal)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "sPartiKodu"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "lGirisMiktar"
        Me.DataColumn25.DataType = GetType(Decimal)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "lGirisTutar"
        Me.DataColumn26.DataType = GetType(Decimal)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "lEnvanterMiktar"
        Me.DataColumn27.DataType = GetType(Decimal)
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "lEnvanterTutar"
        Me.DataColumn28.DataType = GetType(Decimal)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "lFarkMiktar"
        Me.DataColumn29.DataType = GetType(Decimal)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "lFarkTutar"
        Me.DataColumn30.DataType = GetType(Decimal)
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "lKrediLimiti"
        Me.DataColumn31.DataType = GetType(Decimal)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "nValorGun"
        Me.DataColumn32.DataType = GetType(Long)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "bKapandimi"
        Me.DataColumn33.DataType = GetType(Boolean)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "lBirimFiyati"
        Me.DataColumn34.DataType = GetType(Decimal)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "sDovizCinsi"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "lDovizKuru"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "lDovizFiyati"
        Me.DataColumn37.DataType = GetType(Decimal)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "lSevkIadeMiktari"
        Me.DataColumn38.DataType = GetType(Decimal)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "lBakiye"
        Me.DataColumn39.DataType = GetType(Decimal)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "lToplamRisk"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "lBirimFiyati1"
        Me.DataColumn41.DataType = GetType(Decimal)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "lBirimFiyati2"
        Me.DataColumn42.DataType = GetType(Decimal)
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsFirmaKodu, Me.colsFirmaAdi, Me.colsModel, Me.colsRenk, Me.colsRenkAdi, Me.colsBeden, Me.colsKavala, Me.colsAciklama, Me.colsSatirAciklama, Me.coldteIlkSevkiyatTarihi, Me.colsBirimCinsi, Me.colsSipNo, Me.coldteSiparisTarihi, Me.coldteTeslimTarihi, Me.colsSiparisIslem, Me.colSiparisMiktari, Me.colSiparisTutari, Me.colSiparisTutari1, Me.colSiparisTutari2, Me.collSevkMiktari, Me.collSevkTutari, Me.collKalanMiktar, Me.collKalanTutar, Me.colsPartiKodu, Me.collGirisMiktar, Me.collGirisTutar, Me.collEnvanterMiktar, Me.collEnvanterTutar, Me.collFarkMiktar, Me.collFarkTutar, Me.collKrediLimiti, Me.colnValorGun, Me.colbKapandimi, Me.collBirimFiyati, Me.colsDovizCinsi, Me.collDovizKuru, Me.collDovizFiyati, Me.collSevkIadeMiktari, Me.collBakiye, Me.collToplamRisk, Me.collBirimFiyati1, Me.collBirimFiyati2})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(493, 378, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sFirmaKodu", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SiparisMiktari", Nothing, "SiparisMiktari : {0:#,0.00} prç"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSevkMiktari", Nothing, "SevkMiktari {0:#,0.00} prç"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalanMiktar", Nothing, "KalanMiktar: {0:#,0.00} prç"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "sModel", Me.colsModel, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SiparisMiktari", Me.colSiparisMiktari, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSevkMiktari", Me.collSevkMiktari, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalanMiktar", Me.collKalanMiktar, "{0:#,0.00}")})
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
        'colsFirmaKodu
        '
        Me.colsFirmaKodu.Caption = "Firma Kodu"
        Me.colsFirmaKodu.FieldName = "sFirmaKodu"
        Me.colsFirmaKodu.Name = "colsFirmaKodu"
        '
        'colsFirmaAdi
        '
        Me.colsFirmaAdi.Caption = "Firma Adý"
        Me.colsFirmaAdi.FieldName = "sFirmaAdi"
        Me.colsFirmaAdi.Name = "colsFirmaAdi"
        Me.colsFirmaAdi.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sFirmaAdi", "{0} Kayýt")})
        Me.colsFirmaAdi.Visible = True
        Me.colsFirmaAdi.VisibleIndex = 0
        '
        'colsModel
        '
        Me.colsModel.Caption = "Stok Kodu"
        Me.colsModel.FieldName = "sModel"
        Me.colsModel.Name = "colsModel"
        Me.colsModel.Visible = True
        Me.colsModel.VisibleIndex = 1
        '
        'colsRenk
        '
        Me.colsRenk.Caption = "Renk"
        Me.colsRenk.FieldName = "sRenk"
        Me.colsRenk.Name = "colsRenk"
        '
        'colsRenkAdi
        '
        Me.colsRenkAdi.Caption = "Renk Adý"
        Me.colsRenkAdi.FieldName = "sRenkAdi"
        Me.colsRenkAdi.Name = "colsRenkAdi"
        Me.colsRenkAdi.Visible = True
        Me.colsRenkAdi.VisibleIndex = 3
        '
        'colsBeden
        '
        Me.colsBeden.Caption = "Beden"
        Me.colsBeden.FieldName = "sBeden"
        Me.colsBeden.Name = "colsBeden"
        '
        'colsKavala
        '
        Me.colsKavala.Caption = "Kavala"
        Me.colsKavala.FieldName = "sKavala"
        Me.colsKavala.Name = "colsKavala"
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Stok Adý"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 2
        '
        'colsSatirAciklama
        '
        Me.colsSatirAciklama.Caption = "Açýklama"
        Me.colsSatirAciklama.FieldName = "sSatirAciklama"
        Me.colsSatirAciklama.Name = "colsSatirAciklama"
        '
        'coldteIlkSevkiyatTarihi
        '
        Me.coldteIlkSevkiyatTarihi.Caption = "Ýlk Sevkiyat Tarihi"
        Me.coldteIlkSevkiyatTarihi.FieldName = "dteIlkSevkiyatTarihi"
        Me.coldteIlkSevkiyatTarihi.Name = "coldteIlkSevkiyatTarihi"
        '
        'colsBirimCinsi
        '
        Me.colsBirimCinsi.Caption = "Birim"
        Me.colsBirimCinsi.FieldName = "sBirimCinsi"
        Me.colsBirimCinsi.Name = "colsBirimCinsi"
        '
        'colsSipNo
        '
        Me.colsSipNo.Caption = "Sipariþ No"
        Me.colsSipNo.FieldName = "sSipNo"
        Me.colsSipNo.Name = "colsSipNo"
        Me.colsSipNo.Visible = True
        Me.colsSipNo.VisibleIndex = 4
        '
        'coldteSiparisTarihi
        '
        Me.coldteSiparisTarihi.Caption = "Sipariþ Tarihi"
        Me.coldteSiparisTarihi.FieldName = "dteSiparisTarihi"
        Me.coldteSiparisTarihi.Name = "coldteSiparisTarihi"
        Me.coldteSiparisTarihi.Visible = True
        Me.coldteSiparisTarihi.VisibleIndex = 5
        '
        'coldteTeslimTarihi
        '
        Me.coldteTeslimTarihi.Caption = "Teslim Tarihi"
        Me.coldteTeslimTarihi.FieldName = "dteTeslimTarihi"
        Me.coldteTeslimTarihi.Name = "coldteTeslimTarihi"
        Me.coldteTeslimTarihi.Visible = True
        Me.coldteTeslimTarihi.VisibleIndex = 6
        '
        'colsSiparisIslem
        '
        Me.colsSiparisIslem.Caption = "Sipariþ Ýþlem"
        Me.colsSiparisIslem.FieldName = "sSiparisIslem"
        Me.colsSiparisIslem.Name = "colsSiparisIslem"
        '
        'colSiparisMiktari
        '
        Me.colSiparisMiktari.Caption = "Miktar"
        Me.colSiparisMiktari.DisplayFormat.FormatString = "#,0.00"
        Me.colSiparisMiktari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSiparisMiktari.FieldName = "SiparisMiktari"
        Me.colSiparisMiktari.Name = "colSiparisMiktari"
        Me.colSiparisMiktari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SiparisMiktari", "{0:#,0.00}")})
        Me.colSiparisMiktari.Visible = True
        Me.colSiparisMiktari.VisibleIndex = 7
        '
        'colSiparisTutari
        '
        Me.colSiparisTutari.Caption = "Sipariþ Tutarý"
        Me.colSiparisTutari.DisplayFormat.FormatString = "#,0.00"
        Me.colSiparisTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSiparisTutari.FieldName = "SiparisTutari"
        Me.colSiparisTutari.Name = "colSiparisTutari"
        Me.colSiparisTutari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SiparisTutari", "{0:#,0.00}")})
        '
        'colSiparisTutari1
        '
        Me.colSiparisTutari1.Caption = "Sipariþ Tutarý 1"
        Me.colSiparisTutari1.DisplayFormat.FormatString = "#,0.00"
        Me.colSiparisTutari1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSiparisTutari1.FieldName = "SiparisTutari1"
        Me.colSiparisTutari1.Name = "colSiparisTutari1"
        '
        'colSiparisTutari2
        '
        Me.colSiparisTutari2.Caption = "Sipariþ Tutarý 2"
        Me.colSiparisTutari2.DisplayFormat.FormatString = "#,0.00"
        Me.colSiparisTutari2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSiparisTutari2.FieldName = "SiparisTutari2"
        Me.colSiparisTutari2.Name = "colSiparisTutari2"
        '
        'collSevkMiktari
        '
        Me.collSevkMiktari.Caption = "Gelen"
        Me.collSevkMiktari.DisplayFormat.FormatString = "#,0.00"
        Me.collSevkMiktari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collSevkMiktari.FieldName = "lSevkMiktari"
        Me.collSevkMiktari.Name = "collSevkMiktari"
        Me.collSevkMiktari.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lSevkMiktari", "{0:#,0.00}")})
        Me.collSevkMiktari.Visible = True
        Me.collSevkMiktari.VisibleIndex = 8
        '
        'collSevkTutari
        '
        Me.collSevkTutari.Caption = "Sevk Tutarý"
        Me.collSevkTutari.DisplayFormat.FormatString = "#,0.00"
        Me.collSevkTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collSevkTutari.FieldName = "lSevkTutari"
        Me.collSevkTutari.Name = "collSevkTutari"
        '
        'collKalanMiktar
        '
        Me.collKalanMiktar.Caption = "Kalan"
        Me.collKalanMiktar.DisplayFormat.FormatString = "#,0.00"
        Me.collKalanMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKalanMiktar.FieldName = "lKalanMiktar"
        Me.collKalanMiktar.Name = "collKalanMiktar"
        Me.collKalanMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lKalanMiktar", "{0:#,0.00}")})
        Me.collKalanMiktar.Visible = True
        Me.collKalanMiktar.VisibleIndex = 9
        '
        'collKalanTutar
        '
        Me.collKalanTutar.Caption = "Kalan Tutar"
        Me.collKalanTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collKalanTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKalanTutar.FieldName = "lKalanTutar"
        Me.collKalanTutar.Name = "collKalanTutar"
        '
        'colsPartiKodu
        '
        Me.colsPartiKodu.Caption = "Parti Kodu"
        Me.colsPartiKodu.FieldName = "sPartiKodu"
        Me.colsPartiKodu.Name = "colsPartiKodu"
        '
        'collGirisMiktar
        '
        Me.collGirisMiktar.Caption = "Giriþ Miktarý"
        Me.collGirisMiktar.DisplayFormat.FormatString = "#,0.00"
        Me.collGirisMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGirisMiktar.FieldName = "lGirisMiktar"
        Me.collGirisMiktar.Name = "collGirisMiktar"
        '
        'collGirisTutar
        '
        Me.collGirisTutar.Caption = "Giriþ Tutarý"
        Me.collGirisTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collGirisTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGirisTutar.FieldName = "lGirisTutar"
        Me.collGirisTutar.Name = "collGirisTutar"
        '
        'collEnvanterMiktar
        '
        Me.collEnvanterMiktar.Caption = "Envanter Miktarý"
        Me.collEnvanterMiktar.DisplayFormat.FormatString = "#,0.00"
        Me.collEnvanterMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collEnvanterMiktar.FieldName = "lEnvanterMiktar"
        Me.collEnvanterMiktar.Name = "collEnvanterMiktar"
        '
        'collEnvanterTutar
        '
        Me.collEnvanterTutar.Caption = "Envanter Tutarý"
        Me.collEnvanterTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collEnvanterTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collEnvanterTutar.FieldName = "lEnvanterTutar"
        Me.collEnvanterTutar.Name = "collEnvanterTutar"
        '
        'collFarkMiktar
        '
        Me.collFarkMiktar.Caption = "Fark Miktarý"
        Me.collFarkMiktar.DisplayFormat.FormatString = "#,0.00"
        Me.collFarkMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collFarkMiktar.FieldName = "lFarkMiktar"
        Me.collFarkMiktar.Name = "collFarkMiktar"
        '
        'collFarkTutar
        '
        Me.collFarkTutar.Caption = "Fark Tutarý"
        Me.collFarkTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collFarkTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collFarkTutar.FieldName = "lFarkTutar"
        Me.collFarkTutar.Name = "collFarkTutar"
        '
        'collKrediLimiti
        '
        Me.collKrediLimiti.Caption = "Kredi Limiti"
        Me.collKrediLimiti.DisplayFormat.FormatString = "#,0.00"
        Me.collKrediLimiti.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collKrediLimiti.FieldName = "lKrediLimiti"
        Me.collKrediLimiti.Name = "collKrediLimiti"
        '
        'colnValorGun
        '
        Me.colnValorGun.Caption = "ValorGun"
        Me.colnValorGun.DisplayFormat.FormatString = "#,0.00"
        Me.colnValorGun.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnValorGun.FieldName = "nValorGun"
        Me.colnValorGun.Name = "colnValorGun"
        '
        'colbKapandimi
        '
        Me.colbKapandimi.Caption = "Kapandýmý"
        Me.colbKapandimi.FieldName = "bKapandimi"
        Me.colbKapandimi.Name = "colbKapandimi"
        '
        'collBirimFiyati
        '
        Me.collBirimFiyati.Caption = "Birim Fiyatý"
        Me.collBirimFiyati.DisplayFormat.FormatString = "#,0.00"
        Me.collBirimFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBirimFiyati.FieldName = "lBirimFiyati"
        Me.collBirimFiyati.Name = "collBirimFiyati"
        '
        'colsDovizCinsi
        '
        Me.colsDovizCinsi.Caption = "Döviz Cinsi"
        Me.colsDovizCinsi.DisplayFormat.FormatString = "#,0.00"
        Me.colsDovizCinsi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colsDovizCinsi.FieldName = "sDovizCinsi"
        Me.colsDovizCinsi.Name = "colsDovizCinsi"
        '
        'collDovizKuru
        '
        Me.collDovizKuru.Caption = "Döviz Kuru"
        Me.collDovizKuru.DisplayFormat.FormatString = "#,0.00"
        Me.collDovizKuru.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizKuru.FieldName = "lDovizKuru"
        Me.collDovizKuru.Name = "collDovizKuru"
        '
        'collDovizFiyati
        '
        Me.collDovizFiyati.Caption = "Döviz Fiyatý"
        Me.collDovizFiyati.DisplayFormat.FormatString = "#,0.00"
        Me.collDovizFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collDovizFiyati.FieldName = "lDovizFiyati"
        Me.collDovizFiyati.Name = "collDovizFiyati"
        '
        'collSevkIadeMiktari
        '
        Me.collSevkIadeMiktari.Caption = "Sevk Ýade Miktari"
        Me.collSevkIadeMiktari.DisplayFormat.FormatString = "#,0.00"
        Me.collSevkIadeMiktari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collSevkIadeMiktari.FieldName = "lSevkIadeMiktari"
        Me.collSevkIadeMiktari.Name = "collSevkIadeMiktari"
        '
        'collBakiye
        '
        Me.collBakiye.Caption = "Bakiye"
        Me.collBakiye.DisplayFormat.FormatString = "#,0.00"
        Me.collBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBakiye.FieldName = "lBakiye"
        Me.collBakiye.Name = "collBakiye"
        '
        'collToplamRisk
        '
        Me.collToplamRisk.Caption = "Toplam Risk"
        Me.collToplamRisk.DisplayFormat.FormatString = "#,0.00"
        Me.collToplamRisk.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collToplamRisk.FieldName = "lToplamRisk"
        Me.collToplamRisk.Name = "collToplamRisk"
        '
        'collBirimFiyati1
        '
        Me.collBirimFiyati1.Caption = "Birim Fiyatý 1"
        Me.collBirimFiyati1.DisplayFormat.FormatString = "#,0.00"
        Me.collBirimFiyati1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBirimFiyati1.FieldName = "lBirimFiyati1"
        Me.collBirimFiyati1.Name = "collBirimFiyati1"
        '
        'collBirimFiyati2
        '
        Me.collBirimFiyati2.Caption = "Birim Fiyatý 2"
        Me.collBirimFiyati2.DisplayFormat.FormatString = "#,0.00"
        Me.collBirimFiyati2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBirimFiyati2.FieldName = "lBirimFiyati2"
        Me.collBirimFiyati2.Name = "collBirimFiyati2"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Bekleyen Sipariþler", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Sipariþ Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7})
        Me.BarManager1.MaxItemId = 7
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Stok Kartý ,F4"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Envanter,F6"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Stok Hareketleri ,F7"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Excel"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Text"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Mail"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 407)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 22)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 407)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 407)
        '
        'frm_stok_siparis_verilen_bekleyen
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
        Me.Name = "frm_stok_siparis_verilen_bekleyen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bekleyen Verilen Sipariþler"
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
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public siparis_stok As Boolean = False
    Public kullanici
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
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
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
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
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
        Dim kriter As String = ""
        Dim kriter2 As String = ""
        'kriter = "WHERE (stok.skodu is not null ) "
        If musterino.ToString <> "" Then
            'kriter += " AND tbFirma.sKodu = '" & musterino & "'"
            If siparis_stok = True Then
                kriter += " AND tbStok.sKodu = '" & musterino & "'"
            Else
                kriter += " AND tbFirma.sKodu = '" & musterino & "'"
            End If
        End If
        kriter2 = " WHERE lKalanMiktar > 0"
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        '(SELECT ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1) , 0) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok stok ON tbAlisverisSiparis.nStokID = stok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (stok.nStokID = Satislar.nStokID) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_siparis_magaza & "  GROUP BY stok.sKodu) AS Bekleyen
        'cmd.CommandText = sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu, sSinifAciklama, sFirmaKodu, sFirmaAdi, sModel, sRenk, sRenkAdi, sBeden, sKavala, sAciklama, sSatirAciklama, dteIlkSevkiyatTarihi, sBirimCinsi, sSipNo, dteSiparisTarihi, dteTeslimtarihi, sSiparisIslem, SiparisMiktari, SiparisTutari, SiparisTutari1, SiparisTutari2, lSevkMiktari, lSevkTutari, lReserveMiktari - lSevkMiktari + lsevkIadeMiktari, lKalanMiktar, KalanTutar, sPartiKodu, lGirisMiktar, lGirisTutar, lEnvanterMiktar, lEnvanterTutar, lFarkMiktar, lFarkTutar, lKrediLimiti, nValorGun, cast(bKapandimi AS int) bKapandimi, lBirimFiyati, sDovizCinsi, lDovizKuru, lDovizFiyati, lSevkIadeMiktari, lSevkIadeTutari, lBakiye, lToplamRisk, lBirimFiyati1, lBirimFiyati2 FROM (SELECT '' AS sSinifKodu, '' AS sSinifAciklama, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAdi, tbStok.sKodu AS sModel, tbStok.sRenk AS sRenk, tbRenk.sRenkAdi AS sRenkAdi, tbStok.sBeden AS sBeden, '' AS sKavala, tbstok.sAciklama, '' AS sSatirAciklama, '' AS dteIlkSevkiyatTarihi, '' AS sBirimCinsi, Str(tbSiparis.lSiparisNo) + ' - ' + ltrim(str(tbSiparis.nSiparisID)) AS sSipNo, tbSiparis.dteSiparisTarihi AS dteSiparisTarihi, tbSiparis.dteTeslimTarihi AS dteTeslimTarihi, sSiparisIslem, lMiktari AS SiparisMiktari, 0 AS SiparisTutari, 0 AS SiparisTutari1, 0 AS SiparisTutari2, SUM(Isnull(lSevkMiktari, 0)) AS lSevkMiktari, SUM(Isnull(lSevkTutari, 0)) AS lSevkTutari, SUM(Isnull(lSevkIadeMiktari, 0)) AS lSevkIadeMiktari, SUM(Isnull(lSevkIadeTutari, 0)) AS lSevkIadeTutari, lReserveMiktari, lMiktari - SUM(IsNull(lSevkMiktari, 0)) + SUM(IsNull(lSevkIadeMiktari, 0)) AS lKalanMiktar, SUM(lTutari) - SUM(IsNull(lSevkTutari, 0)) + SUM(IsNull(lSevkIadeTutari, 0)) KalanTutar, '' sPartiKodu, 0 lGirisMiktar, 0 lGirisTutar, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStokFisiDetayi.nStokID = tbStok.nStokID ) AS lEnvanterMiktar, 0 lEnvanterTutar, 0 lFarkMiktar, 0 lFarkTutar, 0 lKrediLimiti, '' AS sModel_Order, nValorGun, cast(tbSiparis.bKapandimi AS int) bKapandimi, 0 AS lBirimFiyati, '' sDovizCinsi, 0 lDovizKuru, 0 lDovizFiyati, 0 AS lBakiye, 0 AS lToplamRisk, 0 AS lBirimFiyati1, 0 AS lBirimFiyati2 FROM tbFirma, tbParti, tbStok, tbsiparis LEFT OUTER JOIN (SELECT nSiparisID, isnull(abs(SUM(lGirisMiktar1 * (nGirisCikis - 2))), 0) lSevkMiktari, isnull(abs(SUM(lGirisTutar * (nGirisCikis - 2))), 0) lSevkTutari, isnull(abs(SUM(lGirisMiktar1 * (nGirisCikis - 1))), 0) lSevkIadeMiktari, isnull(abs(SUM(lGirisTutar * (nGirisCikis - 1))), 0) lSevkIadeTutari FROM tbStokFisiDetayi, tbStok, tbFirma WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID AND tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID AND dteIslemTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND nSiparisID IS NOT NULL GROUP BY nSiparisID) AS tbStokFisiDetayi ON tbSiparis.nSiparisID = tbStokFisiDetayi.nSiparisID, tbRenk WHERE tbParti.nPartiId = tbSiparis.nPartiId AND tbFirma.nFirmaID = tbSiparis.nFirmaID AND tbSiparis.bKapandimi = 0 AND tbStok.sRenk = tbRenk.sRenk AND tbStok.nStokID = tbSiparis.nStokID AND tbSiparis.nSiparisTipi = 2 AND tbStok.sRenk = tbRenk.sRenk " & kriter & " GROUP BY tbStok.nStokID,tbStok.sKodu, tbstok.sBeden, tbStok.sAciklama, tbFirma.sKodu, tbFirma.sAciklama, tbSiparis.lSiparisNo, tbSiparis.nSiparisID, tbSiparis.dteSiparisTarihi, tbSiparis.dteTeslimTarihi, sSiparisIslem, lMiktari, lReserveMiktari, tbStok.sRenk, tbRenk.sRenkAdi, nValorGun, cast(bKapandimi AS int)) tbTempGenel WHERE lKalanMiktar BETWEEN 1 AND 9999999999.9999 ORDER BY sFirmaKodu, sModel, sRenk, sBeden, sKavala ")
        cmd.CommandText = sorgu_query("SET dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu, sSinifAciklama, nFirmaID,sFirmaKodu, sFirmaAdi, nStokID,sKodu,sModel, sRenk, sRenkAdi, sBeden, sKavala, lMevcut,sAciklama, sSatirAciklama, dteIlkSevkiyatTarihi, sBirimCinsi, sSipNo, dteSiparisTarihi, lSiparisNo,nSiparisTipi,nSiparisID,dteTeslimtarihi, sSiparisIslem, SiparisMiktari, SiparisTutari, SiparisTutari1, SiparisTutari2, lSevkMiktari, lSevkTutari, lReserveMiktari - lSevkMiktari + lsevkIadeMiktari, lKalanMiktar, KalanTutar, sPartiKodu, lGirisMiktar, lGirisTutar, lEnvanterMiktar, lEnvanterTutar, lFarkMiktar, lFarkTutar, lKrediLimiti, nValorGun, cast(bKapandimi AS int) bKapandimi, lBirimFiyati, sDovizCinsi, lDovizKuru, lDovizFiyati, lSevkIadeMiktari, lSevkIadeTutari, lBakiye, lToplamRisk, lBirimFiyati1, lBirimFiyati2 FROM (SELECT '' AS sSinifKodu, '' AS sSinifAciklama, tbFirma.nFirmaID,tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAdi, tbStok.nStokID,tbStok.sKodu,tbStok.sModel AS sModel, tbStok.sRenk AS sRenk, tbRenk.sRenkAdi AS sRenkAdi, tbStok.sBeden AS sBeden, tbStok.sKavala AS sKavala, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS lMevcut,tbstok.sAciklama, '' AS sSatirAciklama, '' AS dteIlkSevkiyatTarihi, '' AS sBirimCinsi, Str(tbSiparis.lSiparisNo) + ' - ' + ltrim(str(tbSiparis.nSiparisID)) AS sSipNo, tbSiparis.dteSiparisTarihi AS dteSiparisTarihi, tbSiparis.lSiparisNo,tbSiparis.nSiparisTipi,tbSiparis.nSiparisID,tbSiparis.dteTeslimTarihi AS dteTeslimTarihi, sSiparisIslem, lMiktari AS SiparisMiktari, 0 AS SiparisTutari, 0 AS SiparisTutari1, 0 AS SiparisTutari2, SUM(Isnull(lSevkMiktari, 0)) AS lSevkMiktari, SUM(Isnull(lSevkTutari, 0)) AS lSevkTutari, SUM(Isnull(lSevkIadeMiktari, 0)) AS lSevkIadeMiktari, SUM(Isnull(lSevkIadeTutari, 0)) AS lSevkIadeTutari, lReserveMiktari, lMiktari - SUM(IsNull(lSevkMiktari, 0)) + SUM(IsNull(lSevkIadeMiktari, 0)) AS lKalanMiktar, SUM(lTutari) - SUM(IsNull(lSevkTutari, 0)) + SUM(IsNull(lSevkIadeTutari, 0)) KalanTutar, '' sPartiKodu, 0 lGirisMiktar, 0 lGirisTutar, 0 lEnvanterMiktar, 0 lEnvanterTutar, 0 lFarkMiktar, 0 lFarkTutar, 0 lKrediLimiti, '' AS sModel_Order, nValorGun, cast(tbSiparis.bKapandimi AS int) bKapandimi, 0 AS lBirimFiyati, '' sDovizCinsi, 0 lDovizKuru, 0 lDovizFiyati, 0 AS lBakiye, 0 AS lToplamRisk, 0 AS lBirimFiyati1, 0 AS lBirimFiyati2 FROM tbFirma, tbParti, tbStok, tbsiparis LEFT OUTER JOIN (SELECT nSiparisID, isnull(abs(SUM(lGirisMiktar1 * (nGirisCikis - 2))), 0) lSevkMiktari, isnull(abs(SUM(lGirisTutar * (nGirisCikis - 2))), 0) lSevkTutari, isnull(abs(SUM(lGirisMiktar1 * (nGirisCikis - 1))), 0) lSevkIadeMiktari, isnull(abs(SUM(lGirisTutar * (nGirisCikis - 1))), 0) lSevkIadeTutari FROM tbStokFisiDetayi, tbStok, tbFirma WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID AND tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID AND dteIslemTarihi BETWEEN '01/01/1900' AND '31/12/2078' AND nSiparisID IS NOT NULL GROUP BY nSiparisID) AS tbStokFisiDetayi ON tbSiparis.nSiparisID = tbStokFisiDetayi.nSiparisID, tbRenk WHERE tbParti.nPartiId = tbSiparis.nPartiId AND tbFirma.nFirmaID = tbSiparis.nFirmaID AND tbSiparis.bKapandimi = 0 AND tbStok.sRenk = tbRenk.sRenk AND tbStok.nStokID = tbSiparis.nStokID AND tbSiparis.nSiparisTipi = 2 AND tbStok.sRenk = tbRenk.sRenk " & kriter & " GROUP BY tbStok.nStokID,tbStok.sKodu, tbStok.sModel,tbstok.sBeden,tbStok.sKavala, tbStok.sAciklama, tbFirma.nFirmaID,tbFirma.sKodu, tbFirma.sAciklama, tbSiparis.lSiparisNo, tbSiparis.nSiparisTipi,tbSiparis.nSiparisID, tbSiparis.dteSiparisTarihi, tbSiparis.dteTeslimTarihi, sSiparisIslem, lMiktari, lReserveMiktari, tbStok.sRenk, tbRenk.sRenkAdi, nValorGun, cast(bKapandimi AS int)) tbTempGenel " & kriter2 & " ORDER BY sFirmaKodu, sModel, sRenk, sBeden, sKavala ")
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
    Private Sub dataload()
        DataSet1 = stok()
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
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
    Private Sub analiz_envanter()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_envanter
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.stokno = dr("nStokId")
            frm.stokkodu = dr("sKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_stok_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokId")
            frm.sKodu = dr("sKodu")
            frm.sModel = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_stok_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sKodu")
            frm.nFirmaID = 0
            frm.sec_firma.Checked = False
            frm.sec_giris.Text = "Çýkýþlar"
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
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_envanter()
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
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
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
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        analiz_stok_karti()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        raporla_pdf()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        satir_degistir(True)
    End Sub
    Private Sub tbSiparis_degistir(ByVal nSiparisID As String, ByVal bkapandimi As Integer, Optional ByVal uyari As Boolean = True)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbSiparis SET              bKapandimi =" & bkapandimi & "  Where nSiparisID =" & nSiparisID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(sModel,'') as sModel FROM         tbStok WHERE     (sModel < '" & sModel & "' ) ORDER BY sModel DESC ")
            'sModel = cmd.ExecuteScalar
            'txt_musteriNo.EditValue = sModel
            If uyari = True Then
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Baþarýyla Degistirildi...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'stok_kontrol()
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm,Islem Hatasý Lutfen tekrar Deneyinizi...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 ROLLBACK TRAN")
            cmd.ExecuteNonQuery()
        End Try
        con.Close()
    End Sub
    Private Sub satir_degistir(Optional ByVal kapali As Boolean = False)
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayýtlarý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim s As String
                Dim arr As Integer()
                Dim i As Integer
                Dim toplamsayi = GridView1.SelectedRowsCount
                Dim sayi = 0
                arr = GridView1.GetSelectedRows()
                Dim dr1 As DataRow
                If arr Is Nothing Then
                Else
                    Array.Sort(arr)
                    'bar.Properties.Maximum = GridView1.SelectedRowsCount
                    'panelstatus.Visible = True
                    'bar.Visible = True
                    'bar.Position = 0
                    For Each i In arr
                        s = i.ToString
                        dr1 = GridView1.GetDataRow(s)
                        tbSiparis_degistir(dr1("nSiparisID"), kapali, False)
                        'bar.Position += 1
                        'bar.Refresh()
                    Next
                    XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'panelstatus.Visible = False
                    'bar.Visible = False
                End If
                dr1 = Nothing
                dataload()
            End If
        End If
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        If MenuItem19.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem19.Checked = True
        ElseIf MenuItem19.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem19.Checked = True
        End If
    End Sub
End Class
