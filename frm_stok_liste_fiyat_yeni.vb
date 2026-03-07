Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_stok_liste_fiyat_yeni
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
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents colnStokID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKisaAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStokTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBedenTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKavalaTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBeden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKavala As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBirimCinsi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBirimCinsi2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIskontoYuzdesi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKdvTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnTeminSuresi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAsgariMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAzamiMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsOzelNot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnFiyatlandirma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsModel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKullaniciAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbEksiyeDusulebilirmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDefaultAsortiTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbEksideUyarsinmi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbOtvVar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsOTVTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnIskontoYuzdesiAV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbEK1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbEK2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBarkod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSinif15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colISTIHBARAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMevcut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_renk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colFIYAT1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORAN3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panelstatus As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bar2 As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents barlabel2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents barlabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bar As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sec_sSinif1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinif2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinif3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinif4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinif5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinif6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinif7 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinif8 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinif9 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinif10 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinif11 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinif12 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinif13 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinif14 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sSinif15 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Gp_Kodlama As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_sAltHesap As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txt_sAnaHesap As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_bOzelNotGirilmemis As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents colnAciklamaUzunluk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_bCheckDigit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colsCheckDigit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_Fiyattipi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents sec_nSinifNo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents colORAN4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYATA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYATM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents colnEn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnBoy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnYukseklik As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnHacim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnAgirlik As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_nSayi As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colnPrim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_bPasif As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_liste_fiyat_yeni))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colMevcut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_bPasif = New DevExpress.XtraEditors.CheckEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar4 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.sec_nSinifNo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_Fiyattipi = New DevExpress.XtraEditors.LookUpEdit()
        Me.sec_bCheckDigit = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_bOzelNotGirilmemis = New DevExpress.XtraEditors.CheckEdit()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.Gp_Kodlama = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_sAltHesap = New DevExpress.XtraEditors.ButtonEdit()
        Me.txt_sAnaHesap = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.Panelstatus = New DevExpress.XtraEditors.PanelControl()
        Me.bar2 = New DevExpress.XtraEditors.ProgressBarControl()
        Me.barlabel2 = New DevExpress.XtraEditors.LabelControl()
        Me.barlabel = New DevExpress.XtraEditors.LabelControl()
        Me.bar = New DevExpress.XtraEditors.ProgressBarControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
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
        Me.DataColumn39 = New System.Data.DataColumn()
        Me.DataColumn40 = New System.Data.DataColumn()
        Me.DataColumn41 = New System.Data.DataColumn()
        Me.DataColumn42 = New System.Data.DataColumn()
        Me.DataColumn43 = New System.Data.DataColumn()
        Me.DataColumn44 = New System.Data.DataColumn()
        Me.DataColumn45 = New System.Data.DataColumn()
        Me.DataColumn46 = New System.Data.DataColumn()
        Me.DataColumn47 = New System.Data.DataColumn()
        Me.DataColumn48 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnStokID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKisaAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStokTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBedenTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKavalaTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_renk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKavala = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBirimCinsi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBirimCinsi2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIskontoYuzdesi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKdvTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnTeminSuresi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collAsgariMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collAzamiMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsOzelNot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnFiyatlandirma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsModel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKullaniciAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbEksiyeDusulebilirmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDefaultAsortiTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbEksideUyarsinmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbOtvVar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsOTVTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIskontoYuzdesiAV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbEK1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbEK2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBarkod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSinif1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSinif2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSinif2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSinif3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSinif3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSinif4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSinif4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSinif5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSinif5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSinif6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSinif6 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSinif7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSinif7 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSinif8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSinif8 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSinif9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSinif9 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSinif10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSinif10 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSinif11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSinif11 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSinif12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSinif12 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSinif13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSinif13 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSinif14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSinif14 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSinif15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSinif15 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colISTIHBARAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnAciklamaUzunluk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsCheckDigit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYATA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYATM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDovizCinsi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnEn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_nSayi = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colnBoy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnYukseklik = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnHacim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnAgirlik = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnPrim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_bPasif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_nSinifNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_Fiyattipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bCheckDigit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bOzelNotGirilmemis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.Gp_Kodlama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gp_Kodlama.SuspendLayout()
        CType(Me.txt_sAltHesap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAnaHesap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelstatus.SuspendLayout()
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinif1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinif2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinif3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinif4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinif5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinif6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinif7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinif8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinif9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinif10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinif11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinif12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinif13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinif14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinif15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_nSayi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colMevcut
        '
        Me.colMevcut.Caption = "Mevcut"
        Me.colMevcut.DisplayFormat.FormatString = "#,0.####"
        Me.colMevcut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMevcut.FieldName = "Mevcut"
        Me.colMevcut.Name = "colMevcut"
        Me.colMevcut.OptionsColumn.AllowEdit = False
        Me.colMevcut.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Mevcut", "{0:#,0.00}")})
        Me.colMevcut.Visible = True
        Me.colMevcut.VisibleIndex = 3
        Me.colMevcut.Width = 51
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(824, 88)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_bPasif)
        Me.GroupControl1.Controls.Add(Me.sec_nSinifNo)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.sec_Fiyattipi)
        Me.GroupControl1.Controls.Add(Me.sec_bCheckDigit)
        Me.GroupControl1.Controls.Add(Me.sec_bOzelNotGirilmemis)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(96, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(726, 84)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Text = "Ara"
        '
        'sec_bPasif
        '
        Me.sec_bPasif.Location = New System.Drawing.Point(513, 17)
        Me.sec_bPasif.MenuManager = Me.BarManager1
        Me.sec_bPasif.Name = "sec_bPasif"
        Me.sec_bPasif.Properties.Caption = "Pasif Stoklar"
        Me.sec_bPasif.Size = New System.Drawing.Size(120, 19)
        Me.sec_bPasif.TabIndex = 56
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar4})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12})
        Me.BarManager1.MaxItemId = 12
        Me.BarManager1.StatusBar = Me.Bar4
        '
        'Bar4
        '
        Me.Bar4.BarName = "Status bar"
        Me.Bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar4.DockCol = 0
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True)})
        Me.Bar4.OptionsBar.AllowQuickCustomization = False
        Me.Bar4.OptionsBar.DrawDragBorder = False
        Me.Bar4.OptionsBar.UseWholeRow = True
        Me.Bar4.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Ara,F3"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Sýralý Kod Ver"
        Me.BarButtonItem10.Id = 9
        Me.BarButtonItem10.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem10.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Deðer Yay"
        Me.BarButtonItem12.Id = 11
        Me.BarButtonItem12.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem12.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Ekle,Insert"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Düzelt,F4"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Sil,Ctrl+Del"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete))
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Fiyatlandir,Ctrl+F"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Envanter,F6"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Hareketler ,F7"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem8.Name = "BarButtonItem8"
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
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Transferler,F8"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Deðer Yay,F9"
        Me.BarButtonItem11.Id = 10
        Me.BarButtonItem11.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem11.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'sec_nSinifNo
        '
        Me.sec_nSinifNo.EditValue = "1"
        Me.sec_nSinifNo.EnterMoveNextControl = True
        Me.sec_nSinifNo.Location = New System.Drawing.Point(423, 42)
        Me.sec_nSinifNo.Name = "sec_nSinifNo"
        Me.sec_nSinifNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_nSinifNo.Properties.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.sec_nSinifNo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_nSinifNo.Size = New System.Drawing.Size(48, 20)
        Me.sec_nSinifNo.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(471, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "sýz:"
        '
        'sec_Fiyattipi
        '
        Me.sec_Fiyattipi.EnterMoveNextControl = True
        Me.sec_Fiyattipi.Location = New System.Drawing.Point(354, 42)
        Me.sec_Fiyattipi.Name = "sec_Fiyattipi"
        Me.sec_Fiyattipi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_Fiyattipi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_Fiyattipi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_Fiyattipi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_Fiyattipi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_Fiyattipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_Fiyattipi.Properties.DisplayMember = "sFiyatTipi"
        Me.sec_Fiyattipi.Properties.NullText = "[FiyatTipi]"
        Me.sec_Fiyattipi.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_Fiyattipi.Properties.ValueMember = "sFiyatTipi"
        Me.sec_Fiyattipi.Size = New System.Drawing.Size(64, 20)
        Me.sec_Fiyattipi.TabIndex = 53
        '
        'sec_bCheckDigit
        '
        Me.sec_bCheckDigit.Location = New System.Drawing.Point(378, 18)
        Me.sec_bCheckDigit.MenuManager = Me.BarManager1
        Me.sec_bCheckDigit.Name = "sec_bCheckDigit"
        Me.sec_bCheckDigit.Properties.Caption = "CheckDigit Kontrol"
        Me.sec_bCheckDigit.Size = New System.Drawing.Size(120, 19)
        Me.sec_bCheckDigit.TabIndex = 52
        '
        'sec_bOzelNotGirilmemis
        '
        Me.sec_bOzelNotGirilmemis.Location = New System.Drawing.Point(279, 20)
        Me.sec_bOzelNotGirilmemis.MenuManager = Me.BarManager1
        Me.sec_bOzelNotGirilmemis.Name = "sec_bOzelNotGirilmemis"
        Me.sec_bOzelNotGirilmemis.Properties.Caption = "Not Girilmemiþ"
        Me.sec_bOzelNotGirilmemis.Size = New System.Drawing.Size(120, 19)
        Me.sec_bOzelNotGirilmemis.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Tarih:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(172, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "ve"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(192, 20)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(81, 20)
        Me.DateEdit2.TabIndex = 1
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(80, 20)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(88, 20)
        Me.DateEdit1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Stoklar:"
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Ad"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(193, 42)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Kod", "Ad", "Barkod", "Sýnýf1", "Sýnýf2", "Sýnýf3", "Sýnýf4", "Sýnýf5", "Sýnýf6", "Sýnýf7", "Sýnýf8", "Sýnýf9", "Sýnýf10", "Sýnýf11", "Sýnýf12", "Sýnýf13", "Sýnýf14", "Sýnýf15"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(80, 20)
        Me.sec_konum.TabIndex = 4
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(273, 42)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(75, 20)
        Me.sec_kriter.TabIndex = 5
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(80, 42)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(113, 20)
        Me.txt_ara.TabIndex = 3
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(515, 42)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 20)
        Me.SimpleButton3.TabIndex = 6
        Me.SimpleButton3.Text = "&Listele"
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
        Me.PictureBox1.Size = New System.Drawing.Size(94, 84)
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
        Me.PanelControl3.Controls.Add(Me.Gp_Kodlama)
        Me.PanelControl3.Controls.Add(Me.Panelstatus)
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 88)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 271)
        Me.PanelControl3.TabIndex = 0
        '
        'Gp_Kodlama
        '
        Me.Gp_Kodlama.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gp_Kodlama.Controls.Add(Me.SimpleButton4)
        Me.Gp_Kodlama.Controls.Add(Me.SimpleButton5)
        Me.Gp_Kodlama.Controls.Add(Me.txt_sAltHesap)
        Me.Gp_Kodlama.Controls.Add(Me.txt_sAnaHesap)
        Me.Gp_Kodlama.Controls.Add(Me.LabelControl6)
        Me.Gp_Kodlama.Controls.Add(Me.LabelControl5)
        Me.Gp_Kodlama.Location = New System.Drawing.Point(280, 82)
        Me.Gp_Kodlama.Name = "Gp_Kodlama"
        Me.Gp_Kodlama.Size = New System.Drawing.Size(265, 107)
        Me.Gp_Kodlama.TabIndex = 13
        Me.Gp_Kodlama.Text = "SýraKod Ver"
        Me.Gp_Kodlama.Visible = False
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(180, 78)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton4.TabIndex = 7
        Me.SimpleButton4.Text = "&Vazgeç"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(100, 78)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton5.TabIndex = 6
        Me.SimpleButton5.Text = "&Tamam"
        '
        'txt_sAltHesap
        '
        Me.txt_sAltHesap.Location = New System.Drawing.Point(100, 45)
        Me.txt_sAltHesap.Name = "txt_sAltHesap"
        Me.txt_sAltHesap.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_sAltHesap.Size = New System.Drawing.Size(155, 20)
        Me.txt_sAltHesap.TabIndex = 3
        '
        'txt_sAnaHesap
        '
        Me.txt_sAnaHesap.Location = New System.Drawing.Point(100, 23)
        Me.txt_sAnaHesap.Name = "txt_sAnaHesap"
        Me.txt_sAnaHesap.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_sAnaHesap.Size = New System.Drawing.Size(155, 20)
        Me.txt_sAnaHesap.TabIndex = 2
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(13, 48)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl6.TabIndex = 1
        Me.LabelControl6.Text = "Alt Hesap"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 24)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl5.TabIndex = 0
        Me.LabelControl5.Text = "Ana Hesap"
        '
        'Panelstatus
        '
        Me.Panelstatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panelstatus.Appearance.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panelstatus.Appearance.Options.UseBackColor = True
        Me.Panelstatus.Controls.Add(Me.bar2)
        Me.Panelstatus.Controls.Add(Me.barlabel2)
        Me.Panelstatus.Controls.Add(Me.barlabel)
        Me.Panelstatus.Controls.Add(Me.bar)
        Me.Panelstatus.Location = New System.Drawing.Point(229, 81)
        Me.Panelstatus.Name = "Panelstatus"
        Me.Panelstatus.Size = New System.Drawing.Size(367, 108)
        Me.Panelstatus.TabIndex = 12
        Me.Panelstatus.Visible = False
        '
        'bar2
        '
        Me.bar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar2.Location = New System.Drawing.Point(8, 73)
        Me.bar2.Name = "bar2"
        Me.bar2.Properties.ShowTitle = True
        Me.bar2.Size = New System.Drawing.Size(343, 18)
        Me.bar2.TabIndex = 3
        '
        'barlabel2
        '
        Me.barlabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barlabel2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.barlabel2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.barlabel2.Location = New System.Drawing.Point(8, 50)
        Me.barlabel2.Name = "barlabel2"
        Me.barlabel2.Size = New System.Drawing.Size(53, 13)
        Me.barlabel2.TabIndex = 2
        Me.barlabel2.Text = "barlabel2"
        '
        'barlabel
        '
        Me.barlabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barlabel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.barlabel.Appearance.ForeColor = System.Drawing.Color.Black
        Me.barlabel.Location = New System.Drawing.Point(8, 4)
        Me.barlabel.Name = "barlabel"
        Me.barlabel.Size = New System.Drawing.Size(46, 13)
        Me.barlabel.TabIndex = 1
        Me.barlabel.Text = "barlabel"
        '
        'bar
        '
        Me.bar.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bar.Location = New System.Drawing.Point(8, 23)
        Me.bar.Name = "bar"
        Me.bar.Properties.ShowTitle = True
        Me.bar.Size = New System.Drawing.Size(343, 18)
        Me.bar.TabIndex = 0
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
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_renk, Me.sec_sSinif1, Me.sec_sSinif2, Me.sec_sSinif3, Me.sec_sSinif4, Me.sec_sSinif5, Me.sec_sSinif6, Me.sec_sSinif7, Me.sec_sSinif8, Me.sec_sSinif9, Me.sec_sSinif10, Me.sec_sSinif11, Me.sec_sSinif12, Me.sec_sSinif13, Me.sec_sSinif14, Me.sec_sSinif15, Me.sec_nSayi})
        Me.GridControl1.Size = New System.Drawing.Size(820, 267)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem26, Me.MenuItem27, Me.MenuItem16, Me.MenuItem17, Me.MenuItem19, Me.MenuItem14, Me.MenuItem13, Me.MenuItem25, Me.MenuItem20, Me.MenuItem21, Me.MenuItem23, Me.MenuItem22, Me.MenuItem24, Me.MenuItem18, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem15, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 0
        Me.MenuItem26.Text = "Sýnýf Tanýmlarý"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 1
        Me.MenuItem27.Text = "-"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 2
        Me.MenuItem16.Text = "Barkod Ata Ean8"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 3
        Me.MenuItem17.Text = "Barkod Ata Ean13"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 4
        Me.MenuItem19.Text = "Barkod Ata StokKodu"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 5
        Me.MenuItem14.Text = "-"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 6
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.F11
        Me.MenuItem13.Text = "Resim Göster"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 7
        Me.MenuItem25.Text = "-"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 8
        Me.MenuItem20.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem20.Text = "Stok Kartý"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 9
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem21.Text = "Envanter"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 10
        Me.MenuItem23.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItem23.Text = "Fiyatlandýr"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 11
        Me.MenuItem22.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem22.Text = "Stok Hareketleri"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 12
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItem24.Text = "Karlýlýk Akýþ Tablosu"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 13
        Me.MenuItem18.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 14
        Me.MenuItem1.Text = "Görünümü Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 15
        Me.MenuItem2.Text = "Baþlýk Deðiþtir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 16
        Me.MenuItem3.Text = "Görünümü Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 17
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünümü Yazdýr"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 18
        Me.MenuItem10.Text = "-"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 19
        Me.MenuItem15.Text = "Hýzlý Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 20
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 21
        Me.MenuItem6.Text = "Gruplandýr"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 22
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 23
        Me.MenuItem7.Text = "Satýrlarý Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 24
        Me.MenuItem8.Text = "Satýrlarý Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 25
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 26
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
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47, Me.DataColumn48})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nStokID"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "sKodu"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "sAciklama"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sKisaAdi"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "nStokTipi"
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sBedenTipi"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "sKavalaTipi"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sRenk"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sBeden"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "sKavala"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sBirimCinsi1"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "sBirimCinsi2"
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "nIskontoYuzdesi"
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sKdvTipi"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "nTeminSuresi"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "lAsgariMiktar"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "lAzamiMiktar"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "sOzelNot"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "nFiyatlandirma"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sModel"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "sKullaniciAdi"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "dteKayitTarihi"
        Me.DataColumn22.DataType = GetType(Date)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "bEksiyeDusebilirmi"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "sDefaultAsortiTipi"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "bEksideUyarsinmi"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "bOtvVar"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "sOTVTipi"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "nIskontoYuzdesiAV"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "bEK1"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "bEK2"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "sBarkod"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "Sinif1"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "Sinif2"
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "Sinif3"
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "Sinif4"
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "Sinif5"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "Sinif6"
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "Sinif7"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "Sinif8"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "Sinif9"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "Sinif10"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "Sinif11"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "Sinif12"
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "Sinif13"
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "Sinif14"
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "Sinif15"
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "ISTIHBARAT"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "Mevcut"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnStokID, Me.colsKodu, Me.colsAciklama, Me.colsKisaAdi, Me.colnStokTipi, Me.colsBedenTipi, Me.colsKavalaTipi, Me.colsRenk, Me.colsBeden, Me.colsKavala, Me.colsBirimCinsi1, Me.colsBirimCinsi2, Me.colnIskontoYuzdesi, Me.colsKdvTipi, Me.colnTeminSuresi, Me.collAsgariMiktar, Me.collAzamiMiktar, Me.colsOzelNot, Me.colnFiyatlandirma, Me.colsModel, Me.colsKullaniciAdi, Me.coldteKayitTarihi, Me.colbEksiyeDusulebilirmi, Me.colsDefaultAsortiTipi, Me.colbEksideUyarsinmi, Me.colbOtvVar, Me.colsOTVTipi, Me.colnIskontoYuzdesiAV, Me.colbEK1, Me.colbEK2, Me.colsBarkod, Me.colSinif1, Me.colSinif2, Me.colSinif3, Me.colSinif4, Me.colSinif5, Me.colSinif6, Me.colSinif7, Me.colSinif8, Me.colSinif9, Me.colSinif10, Me.colSinif11, Me.colSinif12, Me.colSinif13, Me.colSinif14, Me.colSinif15, Me.colISTIHBARAT, Me.colMevcut, Me.colFIYAT1, Me.colFIYAT2, Me.colFIYAT3, Me.colFIYAT4, Me.colORAN1, Me.colORAN2, Me.colORAN3, Me.colnAciklamaUzunluk, Me.colsCheckDigit, Me.colORAN4, Me.colFIYATA, Me.colFIYATM, Me.colsDovizCinsi, Me.colnEn, Me.colnBoy, Me.colnYukseklik, Me.colnHacim, Me.colnAgirlik, Me.colnPrim})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(755, 311, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.colMevcut
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Navy
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.colMevcut
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition2.Value1 = "0"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayýt")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colnStokID
        '
        Me.colnStokID.Caption = "Kayýt No"
        Me.colnStokID.FieldName = "nStokID"
        Me.colnStokID.Name = "colnStokID"
        Me.colnStokID.OptionsColumn.AllowEdit = False
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Stok Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", "{0} Kayýt")})
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 1
        Me.colsKodu.Width = 110
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Stok Adý"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 2
        Me.colsAciklama.Width = 208
        '
        'colsKisaAdi
        '
        Me.colsKisaAdi.Caption = "Kýsa Adý"
        Me.colsKisaAdi.FieldName = "sKisaAdi"
        Me.colsKisaAdi.Name = "colsKisaAdi"
        '
        'colnStokTipi
        '
        Me.colnStokTipi.Caption = "Stok Tipi"
        Me.colnStokTipi.FieldName = "nStokTipi"
        Me.colnStokTipi.Name = "colnStokTipi"
        '
        'colsBedenTipi
        '
        Me.colsBedenTipi.Caption = "Beden Tipi"
        Me.colsBedenTipi.FieldName = "sBedenTipi"
        Me.colsBedenTipi.Name = "colsBedenTipi"
        '
        'colsKavalaTipi
        '
        Me.colsKavalaTipi.Caption = "Kavala Tipi"
        Me.colsKavalaTipi.FieldName = "sKavalaTipi"
        Me.colsKavalaTipi.Name = "colsKavalaTipi"
        '
        'colsRenk
        '
        Me.colsRenk.Caption = "Renk"
        Me.colsRenk.ColumnEdit = Me.sec_renk
        Me.colsRenk.FieldName = "sRenk"
        Me.colsRenk.Name = "colsRenk"
        Me.colsRenk.Width = 53
        '
        'sec_renk
        '
        Me.sec_renk.AutoHeight = False
        Me.sec_renk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_renk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sRenkAdi", "Renk")})
        Me.sec_renk.DisplayMember = "sRenkAdi"
        Me.sec_renk.Name = "sec_renk"
        Me.sec_renk.ValueMember = "sRenk"
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
        'colsBirimCinsi1
        '
        Me.colsBirimCinsi1.Caption = "Birim 1"
        Me.colsBirimCinsi1.FieldName = "sBirimCinsi1"
        Me.colsBirimCinsi1.Name = "colsBirimCinsi1"
        '
        'colsBirimCinsi2
        '
        Me.colsBirimCinsi2.Caption = "Birim 2"
        Me.colsBirimCinsi2.FieldName = "sBirimCinsi2"
        Me.colsBirimCinsi2.Name = "colsBirimCinsi2"
        '
        'colnIskontoYuzdesi
        '
        Me.colnIskontoYuzdesi.Caption = "Ýskonto Yüzdesi"
        Me.colnIskontoYuzdesi.FieldName = "nIskontoYuzdesi"
        Me.colnIskontoYuzdesi.Name = "colnIskontoYuzdesi"
        '
        'colsKdvTipi
        '
        Me.colsKdvTipi.Caption = "Kdv Tipi"
        Me.colsKdvTipi.FieldName = "sKdvTipi"
        Me.colsKdvTipi.Name = "colsKdvTipi"
        '
        'colnTeminSuresi
        '
        Me.colnTeminSuresi.Caption = "Temin Süresi"
        Me.colnTeminSuresi.FieldName = "nTeminSuresi"
        Me.colnTeminSuresi.Name = "colnTeminSuresi"
        '
        'collAsgariMiktar
        '
        Me.collAsgariMiktar.Caption = "Asgari Miktar"
        Me.collAsgariMiktar.FieldName = "lAsgariMiktar"
        Me.collAsgariMiktar.Name = "collAsgariMiktar"
        '
        'collAzamiMiktar
        '
        Me.collAzamiMiktar.Caption = "Azami Miktar"
        Me.collAzamiMiktar.FieldName = "lAzamiMiktar"
        Me.collAzamiMiktar.Name = "collAzamiMiktar"
        '
        'colsOzelNot
        '
        Me.colsOzelNot.Caption = "Özel Not"
        Me.colsOzelNot.FieldName = "sOzelNot"
        Me.colsOzelNot.Name = "colsOzelNot"
        '
        'colnFiyatlandirma
        '
        Me.colnFiyatlandirma.Caption = "Fiyatlandirma"
        Me.colnFiyatlandirma.FieldName = "nFiyatlandirma"
        Me.colnFiyatlandirma.Name = "colnFiyatlandirma"
        '
        'colsModel
        '
        Me.colsModel.Caption = "Model"
        Me.colsModel.FieldName = "sModel"
        Me.colsModel.Name = "colsModel"
        '
        'colsKullaniciAdi
        '
        Me.colsKullaniciAdi.Caption = "Kullanýcý Adý"
        Me.colsKullaniciAdi.FieldName = "sKullaniciAdi"
        Me.colsKullaniciAdi.Name = "colsKullaniciAdi"
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "Kayýt Tarihi"
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        Me.coldteKayitTarihi.Visible = True
        Me.coldteKayitTarihi.VisibleIndex = 0
        Me.coldteKayitTarihi.Width = 64
        '
        'colbEksiyeDusulebilirmi
        '
        Me.colbEksiyeDusulebilirmi.Caption = "Eksiye Düþebilirmi"
        Me.colbEksiyeDusulebilirmi.FieldName = "bEksiyeDusulebilirmi"
        Me.colbEksiyeDusulebilirmi.Name = "colbEksiyeDusulebilirmi"
        '
        'colsDefaultAsortiTipi
        '
        Me.colsDefaultAsortiTipi.Caption = "DefaultAsortiTipi"
        Me.colsDefaultAsortiTipi.FieldName = "sDefaultAsortiTipi"
        Me.colsDefaultAsortiTipi.Name = "colsDefaultAsortiTipi"
        '
        'colbEksideUyarsinmi
        '
        Me.colbEksideUyarsinmi.Caption = "Ekside Uyarsýnmý"
        Me.colbEksideUyarsinmi.FieldName = "bEksideUyarsinmi"
        Me.colbEksideUyarsinmi.Name = "colbEksideUyarsinmi"
        '
        'colbOtvVar
        '
        Me.colbOtvVar.Caption = "Otv Var"
        Me.colbOtvVar.FieldName = "bOtvVar"
        Me.colbOtvVar.Name = "colbOtvVar"
        '
        'colsOTVTipi
        '
        Me.colsOTVTipi.Caption = "OTV Tipi"
        Me.colsOTVTipi.FieldName = "sOTVTipi"
        Me.colsOTVTipi.Name = "colsOTVTipi"
        '
        'colnIskontoYuzdesiAV
        '
        Me.colnIskontoYuzdesiAV.Caption = "Ýskonto Yüzdesi AV"
        Me.colnIskontoYuzdesiAV.FieldName = "nIskontoYuzdesiAV"
        Me.colnIskontoYuzdesiAV.Name = "colnIskontoYuzdesiAV"
        '
        'colbEK1
        '
        Me.colbEK1.Caption = "EK1"
        Me.colbEK1.FieldName = "bEK1"
        Me.colbEK1.Name = "colbEK1"
        '
        'colbEK2
        '
        Me.colbEK2.Caption = "EK2"
        Me.colbEK2.FieldName = "bEK2"
        Me.colbEK2.Name = "colbEK2"
        '
        'colsBarkod
        '
        Me.colsBarkod.Caption = "Barkod"
        Me.colsBarkod.FieldName = "sBarkod"
        Me.colsBarkod.Name = "colsBarkod"
        Me.colsBarkod.OptionsColumn.AllowEdit = False
        '
        'colSinif1
        '
        Me.colSinif1.Caption = "Sýnýf 1"
        Me.colSinif1.ColumnEdit = Me.sec_sSinif1
        Me.colSinif1.FieldName = "Sinif1"
        Me.colSinif1.Name = "colSinif1"
        Me.colSinif1.Width = 69
        '
        'sec_sSinif1
        '
        Me.sec_sSinif1.AutoHeight = False
        Me.sec_sSinif1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinif1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sKodu", "Kod"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sAciklama", "Aciklama")})
        Me.sec_sSinif1.DisplayMember = "sAciklama"
        Me.sec_sSinif1.Name = "sec_sSinif1"
        Me.sec_sSinif1.ValueMember = "sSinifKodu"
        '
        'colSinif2
        '
        Me.colSinif2.Caption = "Sýnýf 2"
        Me.colSinif2.ColumnEdit = Me.sec_sSinif2
        Me.colSinif2.FieldName = "Sinif2"
        Me.colSinif2.Name = "colSinif2"
        Me.colSinif2.Width = 59
        '
        'sec_sSinif2
        '
        Me.sec_sSinif2.AutoHeight = False
        Me.sec_sSinif2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinif2.DisplayMember = "sAciklama"
        Me.sec_sSinif2.Name = "sec_sSinif2"
        Me.sec_sSinif2.ValueMember = "sSinifKodu"
        '
        'colSinif3
        '
        Me.colSinif3.Caption = "Sýnýf 3"
        Me.colSinif3.ColumnEdit = Me.sec_sSinif3
        Me.colSinif3.FieldName = "Sinif3"
        Me.colSinif3.Name = "colSinif3"
        Me.colSinif3.Width = 94
        '
        'sec_sSinif3
        '
        Me.sec_sSinif3.AutoHeight = False
        Me.sec_sSinif3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinif3.DisplayMember = "sAciklama"
        Me.sec_sSinif3.Name = "sec_sSinif3"
        Me.sec_sSinif3.ValueMember = "sSinifKodu"
        '
        'colSinif4
        '
        Me.colSinif4.Caption = "Sýnýf 4"
        Me.colSinif4.ColumnEdit = Me.sec_sSinif4
        Me.colSinif4.FieldName = "Sinif4"
        Me.colSinif4.Name = "colSinif4"
        '
        'sec_sSinif4
        '
        Me.sec_sSinif4.AutoHeight = False
        Me.sec_sSinif4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinif4.DisplayMember = "sAciklama"
        Me.sec_sSinif4.Name = "sec_sSinif4"
        Me.sec_sSinif4.ValueMember = "sSinifKodu"
        '
        'colSinif5
        '
        Me.colSinif5.Caption = "Sýnýf 5"
        Me.colSinif5.ColumnEdit = Me.sec_sSinif5
        Me.colSinif5.FieldName = "Sinif5"
        Me.colSinif5.Name = "colSinif5"
        '
        'sec_sSinif5
        '
        Me.sec_sSinif5.AutoHeight = False
        Me.sec_sSinif5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinif5.DisplayMember = "sAciklama"
        Me.sec_sSinif5.Name = "sec_sSinif5"
        Me.sec_sSinif5.ValueMember = "sSinifKodu"
        '
        'colSinif6
        '
        Me.colSinif6.Caption = "Sýnýf 6"
        Me.colSinif6.ColumnEdit = Me.sec_sSinif6
        Me.colSinif6.FieldName = "Sinif6"
        Me.colSinif6.Name = "colSinif6"
        '
        'sec_sSinif6
        '
        Me.sec_sSinif6.AutoHeight = False
        Me.sec_sSinif6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinif6.DisplayMember = "sAciklama"
        Me.sec_sSinif6.Name = "sec_sSinif6"
        Me.sec_sSinif6.ValueMember = "sSinifKodu"
        '
        'colSinif7
        '
        Me.colSinif7.Caption = "Sýnýf 7"
        Me.colSinif7.ColumnEdit = Me.sec_sSinif7
        Me.colSinif7.FieldName = "Sinif7"
        Me.colSinif7.Name = "colSinif7"
        '
        'sec_sSinif7
        '
        Me.sec_sSinif7.AutoHeight = False
        Me.sec_sSinif7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinif7.DisplayMember = "sAciklama"
        Me.sec_sSinif7.Name = "sec_sSinif7"
        Me.sec_sSinif7.ValueMember = "sSinifKodu"
        '
        'colSinif8
        '
        Me.colSinif8.Caption = "Sýnýf 8"
        Me.colSinif8.ColumnEdit = Me.sec_sSinif8
        Me.colSinif8.FieldName = "Sinif8"
        Me.colSinif8.Name = "colSinif8"
        '
        'sec_sSinif8
        '
        Me.sec_sSinif8.AutoHeight = False
        Me.sec_sSinif8.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinif8.DisplayMember = "sAciklama"
        Me.sec_sSinif8.Name = "sec_sSinif8"
        Me.sec_sSinif8.ValueMember = "sSinifKodu"
        '
        'colSinif9
        '
        Me.colSinif9.Caption = "Sýnýf 9"
        Me.colSinif9.ColumnEdit = Me.sec_sSinif9
        Me.colSinif9.FieldName = "Sinif9"
        Me.colSinif9.Name = "colSinif9"
        '
        'sec_sSinif9
        '
        Me.sec_sSinif9.AutoHeight = False
        Me.sec_sSinif9.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinif9.DisplayMember = "sAciklama"
        Me.sec_sSinif9.Name = "sec_sSinif9"
        Me.sec_sSinif9.ValueMember = "sSinifKodu"
        '
        'colSinif10
        '
        Me.colSinif10.Caption = "Sýnýf 10"
        Me.colSinif10.ColumnEdit = Me.sec_sSinif10
        Me.colSinif10.FieldName = "Sinif10"
        Me.colSinif10.Name = "colSinif10"
        '
        'sec_sSinif10
        '
        Me.sec_sSinif10.AutoHeight = False
        Me.sec_sSinif10.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinif10.DisplayMember = "sAciklama"
        Me.sec_sSinif10.Name = "sec_sSinif10"
        Me.sec_sSinif10.ValueMember = "sSinifKodu"
        '
        'colSinif11
        '
        Me.colSinif11.Caption = "Sýnýf 11"
        Me.colSinif11.ColumnEdit = Me.sec_sSinif11
        Me.colSinif11.FieldName = "Sinif11"
        Me.colSinif11.Name = "colSinif11"
        '
        'sec_sSinif11
        '
        Me.sec_sSinif11.AutoHeight = False
        Me.sec_sSinif11.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinif11.DisplayMember = "sAciklama"
        Me.sec_sSinif11.Name = "sec_sSinif11"
        Me.sec_sSinif11.ValueMember = "sSinifKodu"
        '
        'colSinif12
        '
        Me.colSinif12.Caption = "Sýnýf 12"
        Me.colSinif12.ColumnEdit = Me.sec_sSinif12
        Me.colSinif12.FieldName = "Sinif12"
        Me.colSinif12.Name = "colSinif12"
        '
        'sec_sSinif12
        '
        Me.sec_sSinif12.AutoHeight = False
        Me.sec_sSinif12.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinif12.DisplayMember = "sAciklama"
        Me.sec_sSinif12.Name = "sec_sSinif12"
        Me.sec_sSinif12.ValueMember = "sSinifKodu"
        '
        'colSinif13
        '
        Me.colSinif13.Caption = "Sýnýf 13"
        Me.colSinif13.ColumnEdit = Me.sec_sSinif13
        Me.colSinif13.FieldName = "Sinif13"
        Me.colSinif13.Name = "colSinif13"
        '
        'sec_sSinif13
        '
        Me.sec_sSinif13.AutoHeight = False
        Me.sec_sSinif13.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinif13.DisplayMember = "sAciklama"
        Me.sec_sSinif13.Name = "sec_sSinif13"
        Me.sec_sSinif13.ValueMember = "sSinifKodu"
        '
        'colSinif14
        '
        Me.colSinif14.Caption = "Sýnýf 14"
        Me.colSinif14.ColumnEdit = Me.sec_sSinif14
        Me.colSinif14.FieldName = "Sinif14"
        Me.colSinif14.Name = "colSinif14"
        '
        'sec_sSinif14
        '
        Me.sec_sSinif14.AutoHeight = False
        Me.sec_sSinif14.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinif14.DisplayMember = "sAciklama"
        Me.sec_sSinif14.Name = "sec_sSinif14"
        Me.sec_sSinif14.ValueMember = "sSinifKodu"
        '
        'colSinif15
        '
        Me.colSinif15.Caption = "Sýnýf 15"
        Me.colSinif15.ColumnEdit = Me.sec_sSinif15
        Me.colSinif15.FieldName = "Sinif15"
        Me.colSinif15.Name = "colSinif15"
        '
        'sec_sSinif15
        '
        Me.sec_sSinif15.AutoHeight = False
        Me.sec_sSinif15.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinif15.DisplayMember = "sAciklama"
        Me.sec_sSinif15.Name = "sec_sSinif15"
        Me.sec_sSinif15.ValueMember = "sSinifKodu"
        '
        'colISTIHBARAT
        '
        Me.colISTIHBARAT.Caption = "ISTIHBARAT"
        Me.colISTIHBARAT.FieldName = "ISTIHBARAT"
        Me.colISTIHBARAT.Name = "colISTIHBARAT"
        Me.colISTIHBARAT.OptionsColumn.AllowEdit = False
        '
        'colFIYAT1
        '
        Me.colFIYAT1.Caption = "Fiyat1"
        Me.colFIYAT1.DisplayFormat.FormatString = "#,0.00"
        Me.colFIYAT1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT1.FieldName = "FIYAT1"
        Me.colFIYAT1.Name = "colFIYAT1"
        Me.colFIYAT1.OptionsColumn.AllowEdit = False
        Me.colFIYAT1.Visible = True
        Me.colFIYAT1.VisibleIndex = 4
        Me.colFIYAT1.Width = 90
        '
        'colFIYAT2
        '
        Me.colFIYAT2.Caption = "Fiyat2"
        Me.colFIYAT2.DisplayFormat.FormatString = "#,0.00"
        Me.colFIYAT2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT2.FieldName = "FIYAT2"
        Me.colFIYAT2.Name = "colFIYAT2"
        Me.colFIYAT2.OptionsColumn.AllowEdit = False
        Me.colFIYAT2.Width = 68
        '
        'colFIYAT3
        '
        Me.colFIYAT3.Caption = "Fiyat3"
        Me.colFIYAT3.DisplayFormat.FormatString = "#,0.00"
        Me.colFIYAT3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT3.FieldName = "FIYAT3"
        Me.colFIYAT3.Name = "colFIYAT3"
        Me.colFIYAT3.OptionsColumn.AllowEdit = False
        Me.colFIYAT3.Width = 63
        '
        'colFIYAT4
        '
        Me.colFIYAT4.Caption = "Maliyet"
        Me.colFIYAT4.DisplayFormat.FormatString = "#,0.00"
        Me.colFIYAT4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT4.FieldName = "FIYAT4"
        Me.colFIYAT4.Name = "colFIYAT4"
        Me.colFIYAT4.OptionsColumn.AllowEdit = False
        Me.colFIYAT4.Width = 98
        '
        'colORAN1
        '
        Me.colORAN1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colORAN1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colORAN1.AppearanceCell.Options.UseBackColor = True
        Me.colORAN1.AppearanceCell.Options.UseFont = True
        Me.colORAN1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colORAN1.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.colORAN1.AppearanceHeader.Options.UseFont = True
        Me.colORAN1.AppearanceHeader.Options.UseForeColor = True
        Me.colORAN1.Caption = "Oran 1"
        Me.colORAN1.DisplayFormat.FormatString = "P"
        Me.colORAN1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN1.FieldName = "ORAN1"
        Me.colORAN1.Name = "colORAN1"
        Me.colORAN1.OptionsColumn.AllowEdit = False
        Me.colORAN1.Visible = True
        Me.colORAN1.VisibleIndex = 5
        Me.colORAN1.Width = 71
        '
        'colORAN2
        '
        Me.colORAN2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colORAN2.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colORAN2.AppearanceCell.Options.UseBackColor = True
        Me.colORAN2.AppearanceCell.Options.UseFont = True
        Me.colORAN2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colORAN2.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.colORAN2.AppearanceHeader.Options.UseFont = True
        Me.colORAN2.AppearanceHeader.Options.UseForeColor = True
        Me.colORAN2.Caption = "Oran 2"
        Me.colORAN2.DisplayFormat.FormatString = "P"
        Me.colORAN2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN2.FieldName = "ORAN2"
        Me.colORAN2.Name = "colORAN2"
        Me.colORAN2.OptionsColumn.AllowEdit = False
        Me.colORAN2.Width = 66
        '
        'colORAN3
        '
        Me.colORAN3.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colORAN3.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colORAN3.AppearanceCell.Options.UseBackColor = True
        Me.colORAN3.AppearanceCell.Options.UseFont = True
        Me.colORAN3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colORAN3.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.colORAN3.AppearanceHeader.Options.UseFont = True
        Me.colORAN3.AppearanceHeader.Options.UseForeColor = True
        Me.colORAN3.Caption = "Oran 3"
        Me.colORAN3.DisplayFormat.FormatString = "P"
        Me.colORAN3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN3.FieldName = "ORAN3"
        Me.colORAN3.Name = "colORAN3"
        Me.colORAN3.OptionsColumn.AllowEdit = False
        '
        'colnAciklamaUzunluk
        '
        Me.colnAciklamaUzunluk.Caption = "AUzunluk"
        Me.colnAciklamaUzunluk.FieldName = "nAciklamaUzunluk"
        Me.colnAciklamaUzunluk.Name = "colnAciklamaUzunluk"
        '
        'colsCheckDigit
        '
        Me.colsCheckDigit.Caption = "CheckDigit"
        Me.colsCheckDigit.FieldName = "sCheckDigit"
        Me.colsCheckDigit.Name = "colsCheckDigit"
        '
        'colORAN4
        '
        Me.colORAN4.Caption = "Oran 4"
        Me.colORAN4.DisplayFormat.FormatString = "#,0.00"
        Me.colORAN4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN4.FieldName = "ORAN4"
        Me.colORAN4.Name = "colORAN4"
        '
        'colFIYATA
        '
        Me.colFIYATA.Caption = "Alis Fiyati"
        Me.colFIYATA.DisplayFormat.FormatString = "#,0.00##"
        Me.colFIYATA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYATA.FieldName = "ALIS"
        Me.colFIYATA.Name = "colFIYATA"
        '
        'colFIYATM
        '
        Me.colFIYATM.Caption = "Maliyet"
        Me.colFIYATM.DisplayFormat.FormatString = "#,0.00##"
        Me.colFIYATM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYATM.FieldName = "MALIYET"
        Me.colFIYATM.Name = "colFIYATM"
        '
        'colsDovizCinsi
        '
        Me.colsDovizCinsi.Caption = "Pb"
        Me.colsDovizCinsi.FieldName = "sDovizCinsi"
        Me.colsDovizCinsi.Name = "colsDovizCinsi"
        '
        'colnEn
        '
        Me.colnEn.Caption = "En"
        Me.colnEn.ColumnEdit = Me.sec_nSayi
        Me.colnEn.DisplayFormat.FormatString = "#,0.###"
        Me.colnEn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnEn.FieldName = "nEn"
        Me.colnEn.Name = "colnEn"
        '
        'sec_nSayi
        '
        Me.sec_nSayi.AutoHeight = False
        Me.sec_nSayi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_nSayi.Name = "sec_nSayi"
        '
        'colnBoy
        '
        Me.colnBoy.Caption = "Boy"
        Me.colnBoy.ColumnEdit = Me.sec_nSayi
        Me.colnBoy.DisplayFormat.FormatString = "#,0.###"
        Me.colnBoy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnBoy.FieldName = "nBoy"
        Me.colnBoy.Name = "colnBoy"
        '
        'colnYukseklik
        '
        Me.colnYukseklik.Caption = "Yukseklik"
        Me.colnYukseklik.ColumnEdit = Me.sec_nSayi
        Me.colnYukseklik.DisplayFormat.FormatString = "#,0.###"
        Me.colnYukseklik.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnYukseklik.FieldName = "nYukseklik"
        Me.colnYukseklik.Name = "colnYukseklik"
        '
        'colnHacim
        '
        Me.colnHacim.Caption = "Hacim"
        Me.colnHacim.ColumnEdit = Me.sec_nSayi
        Me.colnHacim.DisplayFormat.FormatString = "#,0.###"
        Me.colnHacim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnHacim.FieldName = "nHacim"
        Me.colnHacim.Name = "colnHacim"
        '
        'colnAgirlik
        '
        Me.colnAgirlik.Caption = "Agirlik"
        Me.colnAgirlik.ColumnEdit = Me.sec_nSayi
        Me.colnAgirlik.DisplayFormat.FormatString = "#,0.###"
        Me.colnAgirlik.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnAgirlik.FieldName = "nAgirlik"
        Me.colnAgirlik.Name = "colnAgirlik"
        '
        'colnPrim
        '
        Me.colnPrim.Caption = "Prim"
        Me.colnPrim.ColumnEdit = Me.sec_nSayi
        Me.colnPrim.DisplayFormat.FormatString = "#,0.###"
        Me.colnPrim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnPrim.FieldName = "nPrim"
        Me.colnPrim.Name = "colnPrim"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Stok Fiyatlarý Karlýlýk Listesi", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Stok Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_stok_liste_fiyat_yeni
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
        Me.Name = "frm_stok_liste_fiyat_yeni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Yeni Açýlan Stoklar"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_bPasif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_nSinifNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_Fiyattipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bCheckDigit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bOzelNotGirilmemis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.Gp_Kodlama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gp_Kodlama.ResumeLayout(False)
        Me.Gp_Kodlama.PerformLayout()
        CType(Me.txt_sAltHesap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAnaHesap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panelstatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelstatus.ResumeLayout(False)
        Me.Panelstatus.PerformLayout()
        CType(Me.bar2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinif1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinif2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinif3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinif4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinif5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinif6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinif7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinif8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinif9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinif10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinif11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinif12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinif13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinif14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinif15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_nSayi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection As String = ""
    Public musterino As String = 0
    Public kullanici As String = ""
    Dim nKayitSinir As Integer = 0
    Public bBarkodsuz As Boolean = False
    Public bFiyatsiz As Boolean = False
    Public bSinifsiz As Boolean = False
    Dim ds_tbFiyatTipi As DataSet
    Public islemstatus As Boolean = False
    Dim loaded As Boolean = False
    Dim status As Boolean = False
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        colFIYAT1.Caption = sFiyat1Aciklama
        colFIYAT2.Caption = sFiyat2Aciklama
        colFIYAT3.Caption = sFiyat3Aciklama
        colFIYAT4.Caption = sFiyat4Aciklama
        colSinif1.Caption = sStokSinifTipi1
        colSinif2.Caption = sStokSinifTipi2
        colSinif3.Caption = sStokSinifTipi3
        colSinif4.Caption = sStokSinifTipi4
        colSinif5.Caption = sStokSinifTipi5
        colSinif6.Caption = sStokSinifTipi6
        colSinif7.Caption = sStokSinifTipi7
        colSinif8.Caption = sStokSinifTipi8
        colSinif9.Caption = sStokSinifTipi9
        colSinif10.Caption = sStokSinifTipi10
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        dataload_sinif()
        dataload_renk()
        dataload_tbFiyatTipi()
        If bBarkodsuz = False Then
            DateEdit1.EditValue = dteSistemTarihi
            DateEdit2.EditValue = dteSistemTarihi
        Else
            DateEdit1.EditValue = "01/01/1900"
            DateEdit2.EditValue = dteSistemTarihi
        End If
        If bFiyatsiz = True Then
            sec_Fiyattipi.Visible = True
            sec_Fiyattipi.EditValue = sFiyat1
        Else
            sec_Fiyattipi.Visible = False
            sec_Fiyattipi.EditValue = ""
            DateEdit1.EditValue = "01/01/1900"
            DateEdit2.EditValue = dteSistemTarihi
        End If
        If bSinifsiz = True Then
            sec_nSinifNo.Visible = True
            sec_nSinifNo.EditValue = 1
        Else
            sec_nSinifNo.Visible = False
            sec_nSinifNo.EditValue = 1
            DateEdit1.EditValue = "01/01/1900"
            DateEdit2.EditValue = dteSistemTarihi
        End If
        txt_ara.EditValue = ""
        'txt_ara.Focus()
        'txt_ara.Select()
        DateEdit1.Focus()
        DateEdit1.Select()
        loaded = True
    End Sub
    Private Sub dataload_sinif()
        sec_sSinif1.DataSource = sorgu(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif1 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinif2.DataSource = sorgu(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif2 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinif3.DataSource = sorgu(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif3 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinif4.DataSource = sorgu(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif4 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinif5.DataSource = sorgu(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif5 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinif6.DataSource = sorgu(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif6 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinif7.DataSource = sorgu(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif7 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinif8.DataSource = sorgu(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif8 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinif9.DataSource = sorgu(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif9 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinif10.DataSource = sorgu(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif10 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinif11.DataSource = sorgu(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif11 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinif12.DataSource = sorgu(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif12 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinif13.DataSource = sorgu(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif13 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinif14.DataSource = sorgu(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif14 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)
        sec_sSinif15.DataSource = sorgu(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif15 Order by sAciklama")).Tables(0) 'DataSet2.Tables(0)ss
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
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += Microsoft.VisualBasic.Left(DateEdit1.EditValue.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(DateEdit2.EditValue.ToString, 10) & " Tarihleri Arasýndaki Yeni Stoklar" & vbCrLf
        'kriter += "Fiyat = " & sec_fiyat.Text
        printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Stok Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
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
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        SimpleButton4.Text = Sorgu_sDil(SimpleButton4.Text, sDil)
        SimpleButton5.Text = Sorgu_sDil(SimpleButton5.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Sub dataload_renk()
        sec_renk.DataSource = sorgu(sorgu_query("SELECT * FROM tbRenk")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub dataload_tbFiyatTipi()
        ds_tbFiyatTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFiyatTipi,sAciklama FROM         tbFiyatTipi Where sFiyatTipi <>'' and (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%')"))
        sec_Fiyattipi.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_Fiyattipi.EditValue = sFiyatM
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        conn.Close()
        Return DS
        cmd = Nothing
        adapter = Nothing
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
            sorgu_kriter = " = N'" & deger & "' "
        End If
        Return sorgu_kriter
    End Function
    Public Function stok(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime) As DataSet
        Dim kriter As String = ""
        kriter = "WHERE tbStok.dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih2.ToString, 10) + " 23:59:59" & "'  "
        If sec_bPasif.Checked = True Then
            kriter += " and tbStok.nStokTipi = 5 "
        ElseIf sec_bPasif.Checked = False Then
            kriter += " and tbStok.nStokTipi < 5 "
        End If
        Dim kriter_fiyat = ""
        If Trim(ara).ToString <> "" Then
            If konum = "Kod" Then
                kriter += " AND( tbStok.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Ad" Then
                kriter += " AND ( tbStok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Barkod" Then
                kriter += " AND (tbStok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(ara, ara_kriter) & ") "
            ElseIf konum = "Sýnýf1" Then
                kriter += " AND ( tbSSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf2" Then
                kriter += " AND ( tbSSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf3" Then
                kriter += " AND ( tbSSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf4" Then
                kriter += " AND ( tbSSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf5" Then
                kriter += " AND ( tbSSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf6" Then
                kriter += " AND ( tbSSinif6.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf7" Then
                kriter += " AND ( tbSSinif7.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf8" Then
                kriter += " AND ( tbSSinif8.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf9" Then
                kriter += " AND ( tbSSinif9.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf10" Then
                kriter += " AND ( tbSSinif10.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf11" Then
                kriter += " AND ( tbSSinif11.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf12" Then
                kriter += " AND ( tbSSinif12.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf13" Then
                kriter += " AND ( tbSSinif13.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf14" Then
                kriter += " AND ( tbSSinif14.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf15" Then
                kriter += " AND ( tbSSinif15.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            End If
        End If
        If sec_bOzelNotGirilmemis.Checked = True Then
            kriter += " AND (tbStok.sOzelNot ='')"
        End If
        If sStokSinirla <> "" Then
            kriter += " AND (tbStok.sKodu like '" & sStokSinirla & "%') "
        End If
        If bBarkodsuz = True Then
            kriter += " AND (tbStok.nStokID NOT IN (Select nStokID from tbStokBarkodu))"
        End If
        If bFiyatsiz = True Then
            If sec_Fiyattipi.EditValue = "" Then
            Else
                kriter += " AND (tbStok.nStokID NOT IN (Select nStokID from tbStokFiyati Where sFiyatTipi = '" & sec_Fiyattipi.EditValue & "'))"
            End If
        End If
        If bSinifsiz = True Then
            kriter += " AND (tbStok.nStokID IN (SELECT     nStokID FROM         tbStokSinifi  WHERE     sSinifKodu" & sec_nSinifNo.Text & " = ''))"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*,'' as sCheckDigit,lEN(tbStok.sAciklama) nAciklamaUzunluk, tbStok.sModel as Model,tbStokBarkodu.sBarkod, tbSSinif1.sSinifKodu AS Sinif1, tbSSinif2.sSinifKodu AS Sinif2, tbSSinif3.sSinifKodu AS Sinif3, tbSSinif4.sSinifKodu AS Sinif4, tbSSinif5.sSinifKodu AS Sinif5, tbSSinif6.sSinifKodu AS Sinif6, tbSSinif7.sSinifKodu AS Sinif7, tbSSinif8.sSinifKodu AS Sinif8, tbSSinif9.sSinifKodu AS Sinif9, tbSSinif10.sSinifKodu AS Sinif10, tbSSinif11.sSinifKodu AS Sinif11, tbSSinif12.sSinifKodu AS Sinif12, tbSSinif13.sSinifKodu AS Sinif13, tbSSinif14.sSinifKodu AS Sinif14, tbSSinif15.sSinifKodu AS Sinif15, ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10, '') AS ISTIHBARAT,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = N'" & sFiyat1 & "') AS FIYAT1, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = N'" & sFiyat2 & "') AS FIYAT2,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = N'" & sFiyat3 & "') AS FIYAT3,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = N'" & sFiyat4 & "') AS FIYAT4,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = N'" & sFiyatA & "') AS ALIS,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = N'" & sFiyatM & "') AS MALIYET,CAST(0 as Money) as ORAN1,CAST(0 as Money) as ORAN2,CAST(0 as Money) as ORAN3,CAST(0 as Money) as ORAN4  FROM tbStok LEFT OUTER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim= 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " ORDER BY tbStok.sKodu")
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
    Private Sub kontrol_oran()
        Panelstatus.Visible = True
        bar.Properties.Maximum = GridView1.RowCount
        barlabel.Text = "Toplam Satýr Sayýsý : " & GridView1.RowCount
        bar.Position = 0
        Dim dr As DataRow
        For Each dr In DataSet1.Tables(0).Rows
            barlabel.Text = "StokKodu:" & dr("sKodu").ToString & vbTab & "Adý:" & dr("sAciklama").ToString
            barlabel.Refresh()
            'If dr("EKMALIYET") <> 0 Then
            '    dr("ORANEKMALIYET") = dr("EKMALIYET") / dr("FATURATUTARI")
            'End If
            'dr("NETMALIYET") = dr("KDVLITUTAR") * ((100 + (dr("ORANEKMALIYET") * 100)) / 100)
            'Karlýlýk Kontrol
            Try
                If dr("FIYAT1") <> 0 Then
                    dr("ORAN1") = ((dr("FIYAT1") - dr("MALIYET")) / dr("MALIYET"))
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("FIYAT2") <> 0 Then
                    dr("ORAN2") = ((dr("FIYAT2") - dr("MALIYET")) / dr("MALIYET"))
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("FIYAT3") <> 0 Then
                    dr("ORAN3") = ((dr("FIYAT3") - dr("MALIYET")) / dr("MALIYET"))
                End If
            Catch ex As Exception
            End Try
            Try
                If dr("FIYAT4") <> 0 Then
                    dr("ORAN4") = ((dr("FIYAT4") - dr("MALIYET")) / dr("MALIYET"))
                End If
            Catch ex As Exception
            End Try
            If sec_bCheckDigit.Checked = True Then
                Dim lCheckDigit As Decimal = -1
                If Len(Trim(dr("sBarkod").ToString)) >= 12 Then
                    If IsNumeric(Trim(dr("sBarkod").ToString)) = True Then
                        lCheckDigit = Ean13_CheckSum(Microsoft.VisualBasic.Left(Trim(dr("sBarkod").ToString), 12))
                    End If
                ElseIf Len(Trim(dr("sBarkod").ToString)) >= 7 Then
                    If IsNumeric(Trim(dr("sBarkod").ToString)) = True Then
                        lCheckDigit = EAN8_Checksum(Microsoft.VisualBasic.Left(Trim(dr("sBarkod").ToString), 7))
                    End If
                End If
                If Len(Trim(dr("sBarkod").ToString)) = 8 Then
                    If Microsoft.VisualBasic.Right(Trim(dr("sBarkod").ToString), 1) = lCheckDigit Then
                        dr("sCheckDigit") = "Ean8"
                    Else
                        dr("sCheckDigit") = "Ean8-Hatali"
                    End If
                ElseIf Len(Trim(dr("sBarkod").ToString)) = 13 Then
                    If Microsoft.VisualBasic.Right(Trim(dr("sBarkod").ToString), 1) = lCheckDigit Then
                        dr("sCheckDigit") = "Ean13"
                    Else
                        dr("sCheckDigit") = "Ean13-Hatali"
                    End If
                Else
                    dr("sCheckDigit") = "-"
                End If
            End If
            bar.Position = bar.Position + 1
            bar.Refresh()
        Next
        bar.Position = 0
        Panelstatus.Visible = False
        dr = Nothing
    End Sub
    Private Function Ean13_CheckSum(ByVal barcode As String) As Integer
        Dim X As Integer = 0
        Dim Y As Integer = 0
        Dim j As Integer = 11
        Dim m_checksum As Integer = 0
        Try
            For i As Integer = 1 To 12
                If i Mod 2 = 0 Then
                    X += Val(barcode(j))
                Else
                    Y += Val(barcode(j))
                End If
                j -= 1
            Next
            Dim Z As Integer = X + (3 * Y)
            'first(way)
            'Dim m_CheckSum As Integer = ((10 - (Z Mod 10)) Mod 10)
            'second way
            Dim M As Integer = Z
            Do Until (M Mod 10 = 0)
                M += 1
            Loop
            m_checksum = M - Z
            Return m_checksum
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
    Private Function EAN8_Checksum(ByVal EAN8_Barcode As String) As String
        'http://www.barcodeisland.com/ean8.phtml
        Dim ChecksumCalculation As Integer = 0
        Dim Position As Int32 = 1
        For i As Integer = EAN8_Barcode.Length - 1 To 0 Step -1
            If Position Mod 2 = 1 Then
                'odd position
                ChecksumCalculation += Convert.ToInt32(EAN8_Barcode.Substring(i, 1)) * 3
            Else
                'even position
                ChecksumCalculation += Convert.ToInt32(EAN8_Barcode.Substring(i, 1)) * 1
            End If
            Position += 1
        Next
        Dim Checksum As Integer = 10 - (ChecksumCalculation Mod 10)
        Return Microsoft.VisualBasic.Right(Convert.ToString(Checksum), 1)
    End Function
    Private Sub dataload(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        DataSet1 = stok(ara, konum, ara_kriter, tarih1, tarih2)
        kontrol_oran()
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub analiz_resim()
        If GridView1.RowCount > 0 Then
            Dim satir = GridView1.FocusedRowHandle
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim dsResim As DataSet = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT * FROM tbStokResmi WHERE (sModel = '" & dr("sModel") & "') Order by nSira")
            If dsResim.Tables(0).Rows.Count > 0 Then
                dr = dsResim.Tables(0).Rows(0)
                Try
                    Dim frm As New frm_tbResim
                    frm.dsResim = dsResim
                    frm.bTekResim = False
                    frm.ShowDialog()
                    frm.Close()
                    frm.Dispose()
                    frm = Nothing
                Catch ex As Exception
                End Try
                dsResim = Nothing
                satir = Nothing
            End If
        End If
    End Sub
    Private Sub analiz_envanter()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
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
    Private Sub stok_duzelt()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokID")
            frm.sKodu = dr("sKodu")
            frm.sModel = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            Dim satir = GridView1.FocusedRowHandle
            ara()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
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
            frm.Label1.Text = dr("sAciklama") & vbCrLf & frm.Label1.Text
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_stok_KarlilikAkisTablosu()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_Stok_Satis_Maliyetlendir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.txt_sStokKodu.Text = dr("sKodu")
            frm.bAnaliz = True
            If yetki_kontrol(kullanici, "frm_Stok_KarlilikAkisTablosu") = True Then
                frm.ShowDialog()
            End If
        End If
    End Sub
    Private Function KayitSiniri_kontrol(ByVal tbTable, ByVal kriter, ByVal nKayitSinir) As Boolean
        Dim pass As Boolean = False
        If nKayitSinir > 0 Then
            Dim yetki As Int64 = Sorgu_tbKayitSayisi(tbTable, kriter, nKayitSinir)
            If yetki = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Üzgünüm Kýsýtlý Kullaným.Maximum Kayýt Sýnýrýný Aþamazsýnýz...!" & vbCrLf & "Lütfen Yetkili Satýcýnýzla Görüþün...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                status = True
                pass = False
            ElseIf yetki = 1 Then
                pass = True
            End If
        Else
            pass = True
        End If
        Return pass
    End Function
    Private Function Sorgu_tbKayitSayisi(ByVal tbTable As String, ByVal kriter As String, ByVal nKayitSinir As Integer) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitsayisi As Int64 = 0
        Dim formkayitsayisi As Int64 = 0
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(*), 0) AS Kayit FROM " & tbTable & "  " & kriter & " ")
        formkayitsayisi = cmd.ExecuteScalar
        con.Close()
        If formkayitsayisi >= nKayitSinir Then
            kayitsayisi = 0
        Else
            kayitsayisi = 1
        End If
        Return kayitsayisi
        'kayitsayisi = Nothing
        formkayitsayisi = Nothing
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub stok_yeni()
        If KayitSiniri_kontrol("tbStok", "", nKayitSinir) = True Then
            Dim frm As New frm_stok_kart_kisa
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.sModel = ""
            frm.nStokID = 0
            frm.sKodu = ""
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    If XtraMessageBox.Show(Sorgu_sDil("Yeni Stok Kartý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        stok_yeni()
                    Else
                        txt_ara.Text = frm.sModel
                        txt_ara.Focus()
                        txt_ara.SelectAll()
                    End If
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub stok_fiyat()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_fiyatlandir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokId")
            frm.sModel = dr("sModel")
            frm.sKodu = dr("sKodu")
            frm.sRenk = dr("sRenk")
            frm.sBeden = dr("sBeden")
            frm.txt_musteriNo.Text = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            Dim satir = GridView1.FocusedRowHandle
            ara()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub tbStok_sil(ByVal sModel As String, Optional ByVal uyari As Boolean = True)
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
            cmd.CommandText = sorgu_query("delete tbStokSinifi from tbStok where tbStok.nStokID = tbStokSinifi.nStokID and sModel = N'" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokBarkodu from tbStok where tbStok.nStokID = tbStokBarkodu.nStokID and sModel = N'" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokFiyati from tbStok  where tbStok.nStokID = tbStokFiyati.nStokID and sModel = N'" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokBirimCevrimi from tbStok where tbStok.nStokID = tbStokBirimCevrimi.nStokID and sModel = N'" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokMuhasebeEntegrasyon from tbStok where tbStok.nStokID = tbStokMuhasebeEntegrasyon.nStokID and sModel = N'" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokOdemePlani from tbStok  where tbStok.nStokID = tbStokOdemePlani.nStokID and sModel = N'" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokSayim from tbStok where tbStok.nStokID = tbStokSayim.nStokID and sModel = N'" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokDil from tbStok where tbStok.nStokID = tbStokDil.nStokID and sModel = N'" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokAciklama from tbStok where tbStok.nStokID = tbStokAciklama.nStokID and sModel = N'" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStok where sModel = N'" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokUzunNot where sModel = N'" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbStokResim where sModel = N'" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(sModel,'') as sModel FROM         tbStok WHERE     (sModel < '" & sModel & "' ) ORDER BY sModel DESC ")
            'sModel = cmd.ExecuteScalar
            'txt_musteriNo.EditValue = sModel
            If uyari = True Then
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Baþarýyla Silindi...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'stok_kontrol()
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm,Hareket Görmüþ Kaydý Silemezsiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 ROLLBACK TRAN")
            cmd.ExecuteNonQuery()
        End Try
        con.Close()
    End Sub
    Private Sub sati_sil()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayýtlarý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                bar.Properties.Maximum = GridView1.RowCount
                'panelstatus.Visible = True
                bar.Visible = True
                bar.Position = 0
                For Each dr In DataSet1.Tables(0).Rows
                    tbStok_sil(dr("sModel"), False)
                    bar.Position += 1
                    bar.Refresh()
                Next
                DataSet1.Clear()
                XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                dr = Nothing
                'panelstatus.Visible = False
                bar.Visible = False
            End If
            dr = Nothing
            ara()
        End If
    End Sub
    Private Sub satir_sil()
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
                    bar.Properties.Maximum = GridView1.SelectedRowsCount
                    'panelstatus.Visible = True
                    bar.Visible = True
                    bar.Position = 0
                    For Each i In arr
                        s = i.ToString
                        dr1 = GridView1.GetDataRow(s)
                        tbStok_sil(dr1("sModel"), False)
                        bar.Position += 1
                        bar.Refresh()
                    Next
                    DataSet1.Clear()
                    XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'panelstatus.Visible = False
                    bar.Visible = False
                End If
                dr1 = Nothing
                ara()
            End If
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            tutar_hesapla()
        End If
    End Sub
    Private Sub tutar_hesapla()
        If loaded = True Then
            If GridView1.RowCount > 0 Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dr("nAciklamaUzunluk") = Len(Trim(dr("sAciklama")))
                Dim nHacim As Decimal = 0
                nHacim = sorgu_sayi(dr("nEn"), 0) * sorgu_sayi(dr("nBoy"), 0) * sorgu_sayi(dr("nYukseklik"), 0)
                dr("nHacim") = nHacim
                dr.EndEdit()
                tbStok_kaydet_duzelt(dr("nStokID"), dr("sKodu").ToString, dr("sAciklama"), dr("sKisaAdi"), dr("nStokTipi"), dr("sBedenTipi").ToString, dr("sKavalaTipi").ToString, dr("sRenk").ToString, dr("sBeden").ToString, dr("sKavala").ToString, dr("sBirimCinsi1"), dr("sBirimCinsi2"), dr("nIskontoYuzdesi"), dr("sKdvTipi"), dr("nTeminSuresi"), dr("lAsgariMiktar"), dr("lAzamiMiktar"), dr("sOzelNot"), dr("nFiyatlandirma"), dr("sModel"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("bEksiyeDusulebilirmi"), dr("sDefaultAsortiTipi"), dr("bEksideUyarsinmi"), dr("bOTVVar"), dr("sOTVTipi"), dr("nIskontoYuzdesiAV"), dr("bEk1"), dr("nEk2"), dr("nPrim"), sorgu_sayi(dr("nEn"), 0), sorgu_sayi(dr("nBoy"), 0), sorgu_sayi(dr("nYukseklik"), 0), sorgu_sayi(dr("nHacim"), 0), sorgu_sayi(dr("nAgirlik"), 0), dr("sDovizCinsi"), dr("Model"))
                If GridView1.FocusedColumn.Name = colSinif1.Name.ToString Then
                    tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif1"), 1)
                ElseIf GridView1.FocusedColumn.Name = colSinif2.Name.ToString Then
                    tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif2"), 2)
                ElseIf GridView1.FocusedColumn.Name = colSinif3.Name.ToString Then
                    tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif3"), 3)
                ElseIf GridView1.FocusedColumn.Name = colSinif4.Name.ToString Then
                    tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif4"), 4)
                ElseIf GridView1.FocusedColumn.Name = colSinif5.Name.ToString Then
                    tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif5"), 5)
                ElseIf GridView1.FocusedColumn.Name = colSinif6.Name.ToString Then
                    tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif6"), 6)
                ElseIf GridView1.FocusedColumn.Name = colSinif7.Name.ToString Then
                    tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif7"), 7)
                ElseIf GridView1.FocusedColumn.Name = colSinif8.Name.ToString Then
                    tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif8"), 8)
                ElseIf GridView1.FocusedColumn.Name = colSinif9.Name.ToString Then
                    tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif9"), 9)
                ElseIf GridView1.FocusedColumn.Name = colSinif10.Name.ToString Then
                    tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif10"), 10)
                ElseIf GridView1.FocusedColumn.Name = colSinif11.Name.ToString Then
                    tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif11"), 11)
                ElseIf GridView1.FocusedColumn.Name = colSinif12.Name.ToString Then
                    tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif12"), 12)
                ElseIf GridView1.FocusedColumn.Name = colSinif13.Name.ToString Then
                    tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif13"), 13)
                ElseIf GridView1.FocusedColumn.Name = colSinif14.Name.ToString Then
                    tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif14"), 14)
                ElseIf GridView1.FocusedColumn.Name = colSinif15.Name.ToString Then
                    tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif15"), 15)
                End If
                'tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif1"), 1)
                'tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif2"), 2)
                'tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif3"), 3)
                'tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif4"), 4)
                'tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif5"), 5)
                'tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif6"), 6)
                'tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif7"), 7)
                'tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif8"), 8)
                'tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif9"), 9)
                'tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif10"), 10)
                'tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif11"), 11)
                'tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif12"), 12)
                'tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif13"), 13)
                'tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif14"), 14)
                'tbStokSinifi_kaydet_duzelt(dr("Model"), dr("Sinif15"), 15)
                If status = False Then
                    'ara()
                End If
            End If
        End If
    End Sub
    Private Sub tbStok_kaydet_duzelt(ByVal nStokID As Int64, ByVal sKodu As String, ByVal sAciklama As String, ByVal sKisaAdi As String, ByVal nStokTipi As Int64, ByVal sBedenTipi As String, ByVal sKavalaTipi As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sKavala As String, ByVal sBirimCinsi1 As String, ByVal sBirimCinsi2 As String, ByVal nIskontoYuzdesi As Decimal, ByVal sKdvTipi As String, ByVal nTeminSuresi As Decimal, ByVal lAsgariMiktar As Decimal, ByVal lAzamiMiktar As Decimal, ByVal sOzelNot As String, ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bEksiyeDusulebilirmi As Byte, ByVal sDefaultAsortiTipi As String, ByVal bEksideUyarsinmi As Byte, ByVal bOTVVar As Byte, ByVal sOTVTipi As String, ByVal nIskontoYuzdesiAV As Decimal, ByVal bEk1 As Byte, ByVal nEk2 As String, ByVal nPrim As Decimal, ByVal nEn As Decimal, ByVal nBoy As Decimal, ByVal nYukseklik As Decimal, ByVal nHacim As Decimal, ByVal nAgirlik As Decimal, ByVal sDovizCinsi As String, ByVal Model As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStok SET sKodu = N'" & sKodu & "',sAciklama = N'" & sAciklama & "', sKisaAdi = N'" & sKisaAdi & "', nStokTipi = " & nStokTipi & ", sBedenTipi = N'" & sBedenTipi & "', sKavalaTipi = N'" & sKavalaTipi & "', sRenk = N'" & sRenk & "' ,sBeden = N'" & sBeden & "',sBirimCinsi1 = N'" & sBirimCinsi1 & "', sBirimCinsi2 = N'" & sBirimCinsi2 & "', nIskontoYuzdesi = " & nIskontoYuzdesi & ",sKdvTipi = N'" & sKdvTipi & "', nTeminSuresi = N'" & nTeminSuresi & "', lAsgariMiktar = " & lAsgariMiktar & ", lAzamiMiktar = " & lAzamiMiktar & ", sOzelNot = N'" & sOzelNot & "', nFiyatlandirma = " & nFiyatlandirma & ",bEksiyeDusulebilirmi = " & bEksiyeDusulebilirmi & ", sDefaultAsortiTipi = N'" & sDefaultAsortiTipi & "', bEksideUyarsinmi = " & bEksideUyarsinmi & ", bOTVVar = " & bOTVVar & ", sOTVTipi = N'" & sOTVTipi & "', nIskontoYuzdesiAV =" & nIskontoYuzdesiAV & ", bEk1 = " & bEk1 & ", nEk2 = " & nEk2 & ",nPrim=" & nPrim & ",nEn = " & nEn & ",nBoy = " & nBoy & ",nYukseklik = " & nYukseklik & ",nHacim = " & nHacim & ",nAgirlik = " & nAgirlik & ",sDovizCinsi = '" & sDovizCinsi & "',sModel = N'" & sModel & "'  Where nStokID= N'" & nStokID & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub tbStokSinifi_kaydet_duzelt(ByVal sModel As String, ByVal sSinifKodu As String, ByVal sSinifNo As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokSinifi SET sSinifKodu" & sSinifNo & " = N'" & sSinifKodu & "' where nStokID IN (Select nStokID from tbStok where sModel = N'" & sModel & "' )")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub deger_yay()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView1.FocusedColumn().Caption & "] Kolonundaki verileri Aþaðý Doðru Yaymak istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                status = True
                degeryay(GridView1.FocusedColumn().FieldName)
                status = False
            End If
        End If
    End Sub
    Private Sub otomatik_kod()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Hesap Kodu Kolonundaki verileri Aþaðý Doðru Yaymak istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                status = True
                otomatikKod(txt_sAnaHesap.Text, txt_sAltHesap.Text)
                status = False
            End If
        End If
    End Sub
    Private Sub degeryay(ByVal columnkriter As String)
        'kl = CType(Me.BindingContext(DataView1), CurrencyManager)
        Dim durum
        Dim sayi = GridView1.RowCount  'kl.Count
        Dim satir = GridView1.FocusedRowHandle 'kl.Position
        Dim TOPLAM = sayi - GridView1.FocusedRowHandle 'kl.Position
        Dim Ý As Integer
        Ý = 0
        Dim dr_hareket As DataRow
        dr_hareket = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        durum = dr_hareket("" & columnkriter & "")
        'kl.Position += 1
        For Ý = 1 To TOPLAM
            dr_hareket = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr_hareket.BeginEdit()
            dr_hareket("" & columnkriter & "") = durum
            dr_hareket.EndEdit()
            If columnkriter = "Sinif1" Then
                tbStokSinifi_kaydet_duzelt(dr_hareket("Model"), dr_hareket("Sinif1"), 1)
            ElseIf columnkriter = "Sinif2" Then
                tbStokSinifi_kaydet_duzelt(dr_hareket("Model"), dr_hareket("Sinif2"), 2)
            ElseIf columnkriter = "Sinif3" Then
                tbStokSinifi_kaydet_duzelt(dr_hareket("Model"), dr_hareket("Sinif3"), 3)
            ElseIf columnkriter = "Sinif4" Then
                tbStokSinifi_kaydet_duzelt(dr_hareket("Model"), dr_hareket("Sinif4"), 4)
            ElseIf columnkriter = "Sinif5" Then
                tbStokSinifi_kaydet_duzelt(dr_hareket("Model"), dr_hareket("Sinif5"), 5)
            ElseIf columnkriter = "Sinif6" Then
                tbStokSinifi_kaydet_duzelt(dr_hareket("Model"), dr_hareket("Sinif6"), 6)
            ElseIf columnkriter = "Sinif7" Then
                tbStokSinifi_kaydet_duzelt(dr_hareket("Model"), dr_hareket("Sinif7"), 7)
            ElseIf columnkriter = "Sinif8" Then
                tbStokSinifi_kaydet_duzelt(dr_hareket("Model"), dr_hareket("Sinif8"), 8)
            ElseIf columnkriter = "Sinif9" Then
                tbStokSinifi_kaydet_duzelt(dr_hareket("Model"), dr_hareket("Sinif9"), 9)
            ElseIf columnkriter = "Sinif10" Then
                tbStokSinifi_kaydet_duzelt(dr_hareket("Model"), dr_hareket("Sinif10"), 10)
            ElseIf columnkriter = "Sinif11" Then
                tbStokSinifi_kaydet_duzelt(dr_hareket("Model"), dr_hareket("Sinif11"), 11)
            ElseIf columnkriter = "Sinif12" Then
                tbStokSinifi_kaydet_duzelt(dr_hareket("Model"), dr_hareket("Sinif12"), 12)
            ElseIf columnkriter = "Sinif13" Then
                tbStokSinifi_kaydet_duzelt(dr_hareket("Model"), dr_hareket("Sinif13"), 13)
            ElseIf columnkriter = "Sinif14" Then
                tbStokSinifi_kaydet_duzelt(dr_hareket("Model"), dr_hareket("Sinif14"), 14)
            ElseIf columnkriter = "Sinif15" Then
                tbStokSinifi_kaydet_duzelt(dr_hareket("Model"), dr_hareket("Sinif15"), 15)
            Else
                tutar_hesapla()
            End If
            GridView1.FocusedRowHandle += 1
        Next
        'kl.Position = satir
        GridView1.FocusedRowHandle = satir
        GridView1.GetDataRow(satir)
        durum = Nothing
        sayi = Nothing
        satir = Nothing
        Ý = Nothing
    End Sub
    Private Sub otomatikKod(ByVal sAnaHesap As String, ByVal sAltHesap As String)
        Dim durum
        Dim sUzunluk As String = Len(sAltHesap)
        Dim sayi = GridView1.RowCount
        Dim satir = GridView1.FocusedRowHandle
        Dim TOPLAM = sayi - GridView1.FocusedRowHandle
        Dim Ý As Integer
        Ý = 0
        Dim dr_hareket As DataRow
        dr_hareket = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        durum = dr_hareket("sKodu")
        'kl.Position += 1
        For Ý = 1 To TOPLAM
            dr_hareket = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr_hareket.BeginEdit()
            sAltHesap = CType(sAltHesap, Integer) + 1
            dr_hareket("sKodu") = sAnaHesap.ToString & sayiuzunlukkontrol(sAltHesap, sUzunluk).ToString
            dr_hareket.EndEdit()
            tutar_hesapla()
            GridView1.FocusedRowHandle += 1
        Next
        'kl.Position = satir
        GridView1.FocusedRowHandle = satir
        GridView1.GetDataRow(satir)
        durum = Nothing
        sayi = Nothing
        satir = Nothing
        Ý = Nothing
    End Sub
    Private Sub sBarkodAta(ByVal islem As Integer)
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim toplamsayi = GridView1.SelectedRowsCount
        Dim sayi = 0
        Panelstatus.Visible = True
        bar.Properties.Maximum = GridView1.RowCount
        barlabel.Text = "Toplam Satýr Sayýsý : " & GridView1.RowCount
        bar.Position = 0
        arr = GridView1.GetSelectedRows()
        Dim dr As DataRow
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr = GridView1.GetDataRow(s)
                barlabel.Text = "StokKodu:" & dr("sKodu").ToString & vbTab & "Adý:" & dr("sAciklama").ToString
                barlabel.Refresh()
                tbStokBarkodu_kaydet_yeni(dr("sKodu"), islem)
                bar.Position += 1
                bar.Refresh()
            Next
        End If
        bar.Position = 0
        Panelstatus.Visible = False
        ara()
    End Sub
    Private Sub sBarkodAtaStokKodu()
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim toplamsayi = GridView1.SelectedRowsCount
        Dim sayi = 0
        Panelstatus.Visible = True
        bar.Properties.Maximum = GridView1.RowCount
        barlabel.Text = "Toplam Satýr Sayýsý : " & GridView1.RowCount
        bar.Position = 0
        arr = GridView1.GetSelectedRows()
        Dim dr As DataRow
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr = GridView1.GetDataRow(s)
                barlabel.Text = "StokKodu:" & dr("sKodu").ToString & vbTab & "Adý:" & dr("sAciklama").ToString
                barlabel.Refresh()
                If dr("sBarkod").ToString = "" Then
                    Try
                        tbStokBarkod_kaydet_yeni(dr("nStokID"), dr("sKodu").ToString, 0, 0, "", "")
                        dr("sBarkod") = dr("sKodu").ToString
                    Catch ex As Exception
                    End Try
                End If
                bar.Position += 1
                bar.Refresh()
            Next
        End If
        bar.Position = 0
        Panelstatus.Visible = False
        ara()
    End Sub
    Private Sub tbStokBarkod_kaydet_yeni(ByVal nStokID As Int64, ByVal sBarkod As String, ByVal nKisim As Int64, ByVal nFirmaID As Int64, ByVal sKarsiStokKodu As String, ByVal sKarsiStokAciklama As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokBarkodu (nStokID, sBarkod, nKisim, nFirmaID, sKarsiStokKodu, sKarsiStokAciklama) VALUES     (" & nStokID & ", '" & sBarkod & "', " & nKisim & ", " & nFirmaID & ", '" & sKarsiStokKodu & "', '" & sKarsiStokAciklama & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokBarkodu_kaydet_yeni(ByVal sModel As String, ByVal islem As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("sp_NebEanOlustur '" & sModel & "' , '" & sModel & "' , 0 , 0 , '' , '' , " & islem & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function sayiuzunlukkontrol(ByVal deger As String, ByVal uzunluk As String) As String
        Dim degeruzunluk As Integer = uzunluk
        Dim muzunluk = Len(deger)
        If Len(deger) < uzunluk Then
            Dim degerfark As Integer = degeruzunluk - muzunluk
            Dim i As Integer
            For i = 1 To degerfark
                deger = deger.Insert(0, "0")
            Next
        Else
            deger = Microsoft.VisualBasic.Left(deger, uzunluk)
        End If
        Return deger
    End Function
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
        If islemstatus = True Then
            If GridView1.RowCount > 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunamadý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            Me.Close()
        End If
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dataload(txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, DateEdit1.EditValue, DateEdit2.EditValue)
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        dataload(txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, DateEdit1.EditValue, DateEdit2.EditValue)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If islemstatus = True Then
                If GridView1.RowCount > 0 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunamadý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        DateEdit1.Focus()
        DateEdit1.SelectAll()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        stok_yeni()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        stok_duzelt()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        stok_fiyat()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        If MenuItem15.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem15.Checked = True
        ElseIf MenuItem15.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem15.Checked = False
        End If
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        Gp_Kodlama.Visible = True
        txt_sAnaHesap.Focus()
        txt_sAnaHesap.SelectAll()
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        deger_yay()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Gp_Kodlama.Visible = False
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        otomatik_kod()
        Gp_Kodlama.Visible = False
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        sBarkodAta(1)
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        sBarkodAta(0)
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub MenuItem13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        analiz_resim()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        If XtraMessageBox.Show(Sorgu_sDil("Barkodu Olmayan Stoklarýn Barkod Kýsmýna StokKodunu Atamak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            sBarkodAtaStokKodu()
        End If
    End Sub
    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        stok_duzelt()
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        analiz_envanter()
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        stok_fiyat()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        analiz_stok_KarlilikAkisTablosu()
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        siniflandir()
    End Sub
    Private Sub siniflandir()
        Dim frm As New frm_ozelkod_tanimla
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        End If
        dataload_sinif()
    End Sub
End Class