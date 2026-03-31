Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Helpers
Imports DevExpress.XtraGrid.Columns
Public Class frm_stok_satis_karlilik
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
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents lbl_istihbarat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents colnAlisverisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnMusteriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMusteriAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTarih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfisTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnStokID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsStokAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIskonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collNetTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsOdemeKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsFiyatTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSaticiRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKasiyerRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnGirisCikis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsMagaza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_konum_stok As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_kriter_stok As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara_stok As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_renk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colORAN1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPESIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colALTIAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colONAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFARK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNORMALFIYAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNORMALTUTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYATFARKI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSonAlisTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_MaliyetTipi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sKat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sKat As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
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
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents colMALIYET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents colONBESAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_bZararinaSatislar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents urunBazli As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Grid2StokNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid2StokKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid2StokAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid2Miktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid2Fiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid2Iskonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid2NetTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Grid2Oran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid2Fiyat1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid2Fiyat2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid2Fiyat3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid2Kar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid2TutarFarki As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid2NormalFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid2NormalTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid2FiyatFarki As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Grid2Maliyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid2Fiyat4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataSet2 As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_depo As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents sec_smagaza As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents sec_grid As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSEC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colACIKLAMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_kriter_firma As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents sec_satici As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_satis_karlilik))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.Grid2Oran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORAN1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.sec_kriter_firma = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_smagaza = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.sec_depo = New DevExpress.XtraEditors.PopupContainerEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.urunBazli = New DevExpress.XtraEditors.CheckEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar4 = New DevExpress.XtraBars.Bar()
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
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.sec_MaliyetTipi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_konum_stok = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.sec_kriter_stok = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara_stok = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label8 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_istihbarat = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.sec_bZararinaSatislar = New DevExpress.XtraEditors.CheckEdit()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.sec_grid = New DevExpress.XtraEditors.PopupContainerControl()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSEC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colACIKLAMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.DataSet2 = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.DataColumn30 = New System.Data.DataColumn()
        Me.DataColumn31 = New System.Data.DataColumn()
        Me.DataColumn32 = New System.Data.DataColumn()
        Me.DataColumn33 = New System.Data.DataColumn()
        Me.DataColumn34 = New System.Data.DataColumn()
        Me.DataColumn35 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        Me.DataColumn25 = New System.Data.DataColumn()
        Me.DataColumn36 = New System.Data.DataColumn()
        Me.DataColumn37 = New System.Data.DataColumn()
        Me.DataColumn38 = New System.Data.DataColumn()
        Me.DataColumn39 = New System.Data.DataColumn()
        Me.DataColumn40 = New System.Data.DataColumn()
        Me.DataColumn41 = New System.Data.DataColumn()
        Me.DataColumn42 = New System.Data.DataColumn()
        Me.DataColumn43 = New System.Data.DataColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Grid2StokNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid2StokKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid2StokAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid2Miktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid2Fiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid2Iskonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid2NetTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid2Fiyat1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid2Fiyat2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid2Fiyat3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid2Kar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid2TutarFarki = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid2NormalFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid2NormalTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid2FiyatFarki = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid2Maliyet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Grid2Fiyat4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnAlisverisID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnMusteriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsMusteriAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteTarih = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colfisTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnStokID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsStokAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIskonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNetTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsOdemeKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsFiyatTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSaticiRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_satici = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colsKasiyerRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnGirisCikis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsMagaza = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_renk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colPESIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colALTIAY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colONAY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFARK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNORMALFIYAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNORMALTUTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYATFARKI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSonAlisTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sKat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sKat = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colMALIYET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colONBESAY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_kriter_firma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_smagaza.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.urunBazli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_MaliyetTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum_stok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter_stok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara_stok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.sec_bZararinaSatislar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sec_grid.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_satici, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sKat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid2Oran
        '
        Me.Grid2Oran.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Grid2Oran.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Grid2Oran.AppearanceCell.Options.UseBackColor = True
        Me.Grid2Oran.Caption = "Oran"
        Me.Grid2Oran.DisplayFormat.FormatString = "P"
        Me.Grid2Oran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Grid2Oran.FieldName = "ORAN1"
        Me.Grid2Oran.Name = "Grid2Oran"
        Me.Grid2Oran.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "ORAN1", "AVG={0:P}")})
        Me.Grid2Oran.Width = 49
        '
        'colORAN1
        '
        Me.colORAN1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colORAN1.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colORAN1.AppearanceCell.Options.UseBackColor = True
        Me.colORAN1.Caption = "Oran"
        Me.colORAN1.DisplayFormat.FormatString = "P"
        Me.colORAN1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colORAN1.FieldName = "ORAN1"
        Me.colORAN1.Name = "colORAN1"
        Me.colORAN1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.colORAN1.Visible = True
        Me.colORAN1.VisibleIndex = 12
        Me.colORAN1.Width = 49
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.lbl_istihbarat)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1075, 199)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_kriter_firma)
        Me.GroupControl1.Controls.Add(Me.sec_smagaza)
        Me.GroupControl1.Controls.Add(Me.sec_depo)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.urunBazli)
        Me.GroupControl1.Controls.Add(Me.sec_MaliyetTipi)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.sec_konum_stok)
        Me.GroupControl1.Controls.Add(Me.sec_kriter_stok)
        Me.GroupControl1.Controls.Add(Me.txt_ara_stok)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.DateEdit2)
        Me.GroupControl1.Controls.Add(Me.DateEdit1)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(153, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(535, 195)
        Me.GroupControl1.TabIndex = 38
        Me.GroupControl1.Text = "Ara"
        '
        'sec_kriter_firma
        '
        Me.sec_kriter_firma.EditValue = "Boþ"
        Me.sec_kriter_firma.EnterMoveNextControl = True
        Me.sec_kriter_firma.Location = New System.Drawing.Point(414, 121)
        Me.sec_kriter_firma.Name = "sec_kriter_firma"
        Me.sec_kriter_firma.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter_firma.Properties.Items.AddRange(New Object() {"Firma", "Boþ"})
        Me.sec_kriter_firma.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter_firma.Size = New System.Drawing.Size(103, 26)
        Me.sec_kriter_firma.TabIndex = 48
        '
        'sec_smagaza
        '
        Me.sec_smagaza.EditValue = "[Tümü]"
        Me.sec_smagaza.EnterMoveNextControl = True
        Me.sec_smagaza.Location = New System.Drawing.Point(235, 150)
        Me.sec_smagaza.Name = "sec_smagaza"
        Me.sec_smagaza.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_smagaza.Properties.ShowPopupCloseButton = False
        Me.sec_smagaza.Size = New System.Drawing.Size(179, 26)
        Me.sec_smagaza.TabIndex = 44
        '
        'sec_depo
        '
        Me.sec_depo.EditValue = "[Tümü]"
        Me.sec_depo.EnterMoveNextControl = True
        Me.sec_depo.Location = New System.Drawing.Point(102, 150)
        Me.sec_depo.Name = "sec_depo"
        Me.sec_depo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_depo.Properties.ShowPopupCloseButton = False
        Me.sec_depo.Size = New System.Drawing.Size(132, 26)
        Me.sec_depo.TabIndex = 47
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(46, 154)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(43, 19)
        Me.LabelControl1.TabIndex = 45
        Me.LabelControl1.Text = "Satýcý:"
        '
        'urunBazli
        '
        Me.urunBazli.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.urunBazli.Enabled = False
        Me.urunBazli.Location = New System.Drawing.Point(533, 124)
        Me.urunBazli.MenuManager = Me.BarManager1
        Me.urunBazli.Name = "urunBazli"
        Me.urunBazli.Properties.Caption = "Ürün Bazlý"
        Me.urunBazli.Size = New System.Drawing.Size(0, 24)
        Me.urunBazli.TabIndex = 43
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar4})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13})
        Me.BarManager1.MaxItemId = 13
        Me.BarManager1.StatusBar = Me.Bar4
        '
        'Bar4
        '
        Me.Bar4.BarName = "Status bar"
        Me.Bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar4.DockCol = 0
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13, True)})
        Me.Bar4.OptionsBar.AllowQuickCustomization = False
        Me.Bar4.OptionsBar.DrawDragBorder = False
        Me.Bar4.OptionsBar.UseWholeRow = True
        Me.Bar4.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Stok Kartý"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Fiyatlandýr"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Envanter"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Stok Hareketleri"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Müþteri Kartý"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Satýþlar"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Ekstre"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Kalan Satýþlar"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Kalan Taksitler"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Yazdýr,Ctrl+P"
        Me.BarButtonItem10.Id = 9
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Excel"
        Me.BarButtonItem11.Id = 10
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Text"
        Me.BarButtonItem12.Id = 11
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Mail"
        Me.BarButtonItem13.Id = 12
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1075, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 576)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1075, 35)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 576)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1075, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 576)
        '
        'sec_MaliyetTipi
        '
        Me.sec_MaliyetTipi.EditValue = "Stok Kartýndan"
        Me.sec_MaliyetTipi.EnterMoveNextControl = True
        Me.sec_MaliyetTipi.Location = New System.Drawing.Point(102, 121)
        Me.sec_MaliyetTipi.Name = "sec_MaliyetTipi"
        Me.sec_MaliyetTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_MaliyetTipi.Properties.Items.AddRange(New Object() {"Stok Kartýndan", "Maliyetlendirmeden", "Satýþ Günündeki Maliyet", "FIFO (Ýlk Giren Ýlk Çýkar)", "LIFO (Son Giren Ýlk Çýkar)", "Aðýrlýklý Ortalama", "Hareketli Ortalama", "Gerçek Parti Maliyeti", "Standart Maliyet"})
        Me.sec_MaliyetTipi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_MaliyetTipi.Size = New System.Drawing.Size(312, 26)
        Me.sec_MaliyetTipi.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(32, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 19)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Maliyet:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(34, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 19)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Stoklar:"
        '
        'sec_konum_stok
        '
        Me.sec_konum_stok.EditValue = "Kod"
        Me.sec_konum_stok.EnterMoveNextControl = True
        Me.sec_konum_stok.Location = New System.Drawing.Point(282, 64)
        Me.sec_konum_stok.Name = "sec_konum_stok"
        Me.sec_konum_stok.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum_stok.Properties.Items.AddRange(New Object() {"Kod", "Ad", "Barkod", "Sýnýf1", "Sýnýf2", "Sýnýf3", "Sýnýf4", "Sýnýf5"})
        Me.sec_konum_stok.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum_stok.Size = New System.Drawing.Size(132, 26)
        Me.sec_konum_stok.TabIndex = 3
        '
        'sec_kriter_stok
        '
        Me.sec_kriter_stok.EditValue = "Baþlar"
        Me.sec_kriter_stok.EnterMoveNextControl = True
        Me.sec_kriter_stok.Location = New System.Drawing.Point(414, 64)
        Me.sec_kriter_stok.Name = "sec_kriter_stok"
        Me.sec_kriter_stok.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter_stok.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter_stok.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter_stok.Size = New System.Drawing.Size(103, 26)
        Me.sec_kriter_stok.TabIndex = 4
        '
        'txt_ara_stok
        '
        Me.txt_ara_stok.EnterMoveNextControl = True
        Me.txt_ara_stok.Location = New System.Drawing.Point(102, 64)
        Me.txt_ara_stok.Name = "txt_ara_stok"
        Me.txt_ara_stok.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara_stok.Properties.Appearance.Options.UseFont = True
        Me.txt_ara_stok.Properties.MaxLength = 15
        Me.txt_ara_stok.Size = New System.Drawing.Size(180, 28)
        Me.txt_ara_stok.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(19, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 19)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Hesaplar:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(418, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 19)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "arasýndaki"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(48, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 19)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Tarih:"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = Nothing
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(282, 36)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(132, 26)
        Me.DateEdit2.TabIndex = 1
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(102, 36)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(154, 26)
        Me.DateEdit1.TabIndex = 0
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Adý+Soyadý"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(282, 93)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Adý+Soyadý", "Kodu", "Adý", "Soyadý", "Ýstihbarat", "EvAdresi", "ÝþAdresi", "EvTelefonu", "ÝþTelefonu", "Gsm", "DoðumYeri", "1.Kefil Adý", "2.Kefil Adý", "MSýnýf1", "MSýnýf2", "MSýnýf3", "MSýnýf4", "MSýnýf5", "FSýnýf1", "FSýnýf2", "FSýnýf3", "FSýnýf4", "FSýnýf5"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(132, 26)
        Me.sec_konum.TabIndex = 6
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(414, 150)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(109, 29)
        Me.SimpleButton3.TabIndex = 9
        Me.SimpleButton3.Text = "&Listele"
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(102, 93)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(180, 28)
        Me.txt_ara.TabIndex = 5
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Baþlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(414, 93)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Baþlar", "Biter", "Eþittir", "Ýçerir", "Boþ", "Dolu", "Farklý", "Büyük", "Küçük", "Aralýk"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(103, 26)
        Me.sec_kriter.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(261, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 19)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "ve"
        '
        'lbl_istihbarat
        '
        Me.lbl_istihbarat.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_istihbarat.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lbl_istihbarat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_istihbarat.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_istihbarat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_istihbarat.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_istihbarat.Location = New System.Drawing.Point(688, 2)
        Me.lbl_istihbarat.Name = "lbl_istihbarat"
        Me.lbl_istihbarat.Size = New System.Drawing.Size(385, 195)
        Me.lbl_istihbarat.TabIndex = 33
        Me.lbl_istihbarat.Text = "istihbarat..."
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(153, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 19)
        Me.Label1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 195)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.sec_bZararinaSatislar)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 486)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1075, 90)
        Me.PanelControl2.TabIndex = 1
        '
        'sec_bZararinaSatislar
        '
        Me.sec_bZararinaSatislar.Location = New System.Drawing.Point(8, 6)
        Me.sec_bZararinaSatislar.MenuManager = Me.BarManager1
        Me.sec_bZararinaSatislar.Name = "sec_bZararinaSatislar"
        Me.sec_bZararinaSatislar.Properties.Caption = "Zararýna Satýþlar"
        Me.sec_bZararinaSatislar.Size = New System.Drawing.Size(232, 24)
        Me.sec_bZararinaSatislar.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*** Kayýt Bulunamadý...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(938, 33)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(120, 34)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(818, 33)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 34)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.sec_grid)
        Me.PanelControl3.Controls.Add(Me.GridControl2)
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 199)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1075, 287)
        Me.PanelControl3.TabIndex = 0
        '
        'sec_grid
        '
        Me.sec_grid.Controls.Add(Me.GridControl3)
        Me.sec_grid.Location = New System.Drawing.Point(256, 61)
        Me.sec_grid.Name = "sec_grid"
        Me.sec_grid.Size = New System.Drawing.Size(410, 183)
        Me.sec_grid.TabIndex = 3
        '
        'GridControl3
        '
        Me.GridControl3.Location = New System.Drawing.Point(-5, 0)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(410, 183)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSEC, Me.colKOD, Me.colACIKLAMA})
        Me.GridView3.DetailHeight = 160
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.GroupFormat = "{0}: {1} {2}"
        Me.GridView3.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView3.IndicatorWidth = 12
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsDetail.ShowDetailTabs = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'colSEC
        '
        Me.colSEC.Caption = "Seçim"
        Me.colSEC.FieldName = "SEC"
        Me.colSEC.Name = "colSEC"
        Me.colSEC.Visible = True
        Me.colSEC.VisibleIndex = 0
        Me.colSEC.Width = 48
        '
        'colKOD
        '
        Me.colKOD.Caption = "Kod"
        Me.colKOD.FieldName = "KOD"
        Me.colKOD.Name = "colKOD"
        Me.colKOD.OptionsColumn.AllowFocus = False
        Me.colKOD.Visible = True
        Me.colKOD.VisibleIndex = 1
        Me.colKOD.Width = 52
        '
        'colACIKLAMA
        '
        Me.colACIKLAMA.Caption = "Açýklama"
        Me.colACIKLAMA.FieldName = "ACIKLAMA"
        Me.colACIKLAMA.Name = "colACIKLAMA"
        Me.colACIKLAMA.OptionsColumn.AllowFocus = False
        Me.colACIKLAMA.Visible = True
        Me.colACIKLAMA.VisibleIndex = 2
        Me.colACIKLAMA.Width = 128
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenu = Me.ContextMenu1
        Me.GridControl2.DataMember = "Table1"
        Me.GridControl2.DataSource = Me.DataSet2
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 2)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit3})
        Me.GridControl2.Size = New System.Drawing.Size(1071, 283)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        Me.GridControl2.Visible = False
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem15, Me.MenuItem16, Me.MenuItem17, Me.MenuItem18, Me.MenuItem19, Me.MenuItem21, Me.MenuItem22, Me.MenuItem23, Me.MenuItem24, Me.MenuItem25, Me.MenuItem27, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem26, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem18.Text = "Satýþlar"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 6
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.MenuItem19.Text = "Müþteri Kartý"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 7
        Me.MenuItem21.Text = "Envanter"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 8
        Me.MenuItem22.Text = "Müþteri Ekstresi"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 9
        Me.MenuItem23.Text = "Stok Ekstresi"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 10
        Me.MenuItem24.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem24.Text = "Stok Kartý"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 11
        Me.MenuItem25.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItem25.Text = "Stok Fiyatlandir"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 12
        Me.MenuItem27.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItem27.Text = "Karlýlýk Akýþ Tablosu"
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
        'MenuItem26
        '
        Me.MenuItem26.Index = 19
        Me.MenuItem26.Text = "Hýzlý Filtre"
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
        'DataSet2
        '
        Me.DataSet2.DataSetName = "NewDataSet"
        Me.DataSet2.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet2.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn22, Me.DataColumn30, Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn36, Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41, Me.DataColumn42, Me.DataColumn43})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "nStokID"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "sKodu"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "sStokAciklama"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "Miktar"
        Me.DataColumn32.DataType = GetType(Decimal)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "Fiyat"
        Me.DataColumn33.DataType = GetType(Decimal)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "Iskonto"
        Me.DataColumn34.DataType = GetType(Decimal)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "lNetTutar"
        Me.DataColumn35.DataType = GetType(Decimal)
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "KAR"
        Me.DataColumn23.DataType = GetType(Decimal)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "ORAN1"
        Me.DataColumn24.DataType = GetType(Decimal)
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "MALIYET"
        Me.DataColumn25.DataType = GetType(Decimal)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "PESIN"
        Me.DataColumn36.DataType = GetType(Decimal)
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "ALTIAY"
        Me.DataColumn37.DataType = GetType(Decimal)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "ONAY"
        Me.DataColumn38.DataType = GetType(Decimal)
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "FARK"
        Me.DataColumn39.DataType = GetType(Decimal)
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "NORMALFIYAT"
        Me.DataColumn40.DataType = GetType(Decimal)
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "NORMALTUTAR"
        Me.DataColumn41.DataType = GetType(Decimal)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "FIYATFARKI"
        Me.DataColumn42.DataType = GetType(Decimal)
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "ONBESAY"
        Me.DataColumn43.DataType = GetType(Decimal)
        '
        'GridView2
        '
        Me.GridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Grid2StokNo, Me.Grid2StokKodu, Me.Grid2StokAdi, Me.Grid2Miktar, Me.Grid2Fiyat, Me.Grid2Iskonto, Me.Grid2NetTutar, Me.Grid2Oran, Me.Grid2Fiyat1, Me.Grid2Fiyat2, Me.Grid2Fiyat3, Me.Grid2Kar, Me.Grid2TutarFarki, Me.Grid2NormalFiyat, Me.Grid2NormalTutar, Me.Grid2FiyatFarki, Me.Grid2Maliyet, Me.Grid2Fiyat4})
        Me.GridView2.CustomizationFormBounds = New System.Drawing.Rectangle(522, 322, 208, 170)
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Blue
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.Grid2Oran
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.Grid2Oran
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition2.Value1 = "0"
        Me.GridView2.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", Nothing, "{0:#,0.00} prç"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", Nothing, "Tutar:{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "sKodu", Me.Grid2StokKodu, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", Me.Grid2Miktar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", Me.Grid2NetTutar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FARK", Me.Grid2TutarFarki, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "nStokID", Me.Grid2StokNo, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "ORAN1", Me.Grid2Oran, "")})
        Me.GridView2.IndicatorWidth = 35
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'Grid2StokNo
        '
        Me.Grid2StokNo.Caption = "Stok No"
        Me.Grid2StokNo.FieldName = "nStokID"
        Me.Grid2StokNo.Name = "Grid2StokNo"
        '
        'Grid2StokKodu
        '
        Me.Grid2StokKodu.Caption = "Stok Kodu"
        Me.Grid2StokKodu.FieldName = "sKodu"
        Me.Grid2StokKodu.Name = "Grid2StokKodu"
        Me.Grid2StokKodu.Visible = True
        Me.Grid2StokKodu.VisibleIndex = 0
        Me.Grid2StokKodu.Width = 70
        '
        'Grid2StokAdi
        '
        Me.Grid2StokAdi.Caption = "Stok Adý"
        Me.Grid2StokAdi.FieldName = "sStokAciklama"
        Me.Grid2StokAdi.Name = "Grid2StokAdi"
        Me.Grid2StokAdi.Visible = True
        Me.Grid2StokAdi.VisibleIndex = 1
        Me.Grid2StokAdi.Width = 140
        '
        'Grid2Miktar
        '
        Me.Grid2Miktar.Caption = "Miktar"
        Me.Grid2Miktar.DisplayFormat.FormatString = "#,0.##"
        Me.Grid2Miktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Grid2Miktar.FieldName = "Miktar"
        Me.Grid2Miktar.Name = "Grid2Miktar"
        Me.Grid2Miktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", "{0:#,0.00}")})
        Me.Grid2Miktar.Visible = True
        Me.Grid2Miktar.VisibleIndex = 2
        Me.Grid2Miktar.Width = 39
        '
        'Grid2Fiyat
        '
        Me.Grid2Fiyat.Caption = "Fiyat"
        Me.Grid2Fiyat.DisplayFormat.FormatString = "#,0.00##"
        Me.Grid2Fiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Grid2Fiyat.FieldName = "Fiyat"
        Me.Grid2Fiyat.Name = "Grid2Fiyat"
        Me.Grid2Fiyat.Visible = True
        Me.Grid2Fiyat.VisibleIndex = 3
        Me.Grid2Fiyat.Width = 50
        '
        'Grid2Iskonto
        '
        Me.Grid2Iskonto.Caption = "Iskonto"
        Me.Grid2Iskonto.DisplayFormat.FormatString = "#,0.00"
        Me.Grid2Iskonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Grid2Iskonto.FieldName = "Iskonto"
        Me.Grid2Iskonto.Name = "Grid2Iskonto"
        '
        'Grid2NetTutar
        '
        Me.Grid2NetTutar.Caption = "Net Tutar"
        Me.Grid2NetTutar.DisplayFormat.FormatString = "#,0.00"
        Me.Grid2NetTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Grid2NetTutar.FieldName = "lNetTutar"
        Me.Grid2NetTutar.Name = "Grid2NetTutar"
        Me.Grid2NetTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", "{0:#,0.00}")})
        Me.Grid2NetTutar.Visible = True
        Me.Grid2NetTutar.VisibleIndex = 4
        Me.Grid2NetTutar.Width = 55
        '
        'Grid2Fiyat1
        '
        Me.Grid2Fiyat1.Caption = "Fiyat1"
        Me.Grid2Fiyat1.DisplayFormat.FormatString = "#,0.00"
        Me.Grid2Fiyat1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Grid2Fiyat1.FieldName = "PESIN"
        Me.Grid2Fiyat1.Name = "Grid2Fiyat1"
        '
        'Grid2Fiyat2
        '
        Me.Grid2Fiyat2.Caption = "Fiyat2"
        Me.Grid2Fiyat2.DisplayFormat.FormatString = "#,0.00"
        Me.Grid2Fiyat2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Grid2Fiyat2.FieldName = "ALTIAY"
        Me.Grid2Fiyat2.Name = "Grid2Fiyat2"
        '
        'Grid2Fiyat3
        '
        Me.Grid2Fiyat3.Caption = "Fiyat3"
        Me.Grid2Fiyat3.DisplayFormat.FormatString = "#,0.00"
        Me.Grid2Fiyat3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Grid2Fiyat3.FieldName = "ONAY"
        Me.Grid2Fiyat3.Name = "Grid2Fiyat3"
        '
        'Grid2Kar
        '
        Me.Grid2Kar.Caption = "Kar"
        Me.Grid2Kar.DisplayFormat.FormatString = "#,0.00"
        Me.Grid2Kar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Grid2Kar.FieldName = "KAR"
        Me.Grid2Kar.Name = "Grid2Kar"
        Me.Grid2Kar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KAR", "{0:#,0.00}")})
        Me.Grid2Kar.Visible = True
        Me.Grid2Kar.VisibleIndex = 6
        Me.Grid2Kar.Width = 44
        '
        'Grid2TutarFarki
        '
        Me.Grid2TutarFarki.Caption = "Tutar Farký"
        Me.Grid2TutarFarki.DisplayFormat.FormatString = "#,0.00"
        Me.Grid2TutarFarki.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Grid2TutarFarki.FieldName = "FARK"
        Me.Grid2TutarFarki.Name = "Grid2TutarFarki"
        Me.Grid2TutarFarki.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FARK", "{0:#,0.00}")})
        '
        'Grid2NormalFiyat
        '
        Me.Grid2NormalFiyat.Caption = "Normal Fiyat"
        Me.Grid2NormalFiyat.DisplayFormat.FormatString = "#,0.00"
        Me.Grid2NormalFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Grid2NormalFiyat.FieldName = "NORMALFIYAT"
        Me.Grid2NormalFiyat.Name = "Grid2NormalFiyat"
        '
        'Grid2NormalTutar
        '
        Me.Grid2NormalTutar.Caption = "Normal Tutar"
        Me.Grid2NormalTutar.DisplayFormat.FormatString = "#,0.00"
        Me.Grid2NormalTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Grid2NormalTutar.FieldName = "NORMALTUTAR"
        Me.Grid2NormalTutar.Name = "Grid2NormalTutar"
        '
        'Grid2FiyatFarki
        '
        Me.Grid2FiyatFarki.Caption = "Fiyat Farký"
        Me.Grid2FiyatFarki.DisplayFormat.FormatString = "#,0.00"
        Me.Grid2FiyatFarki.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Grid2FiyatFarki.FieldName = "FIYATFARKI"
        Me.Grid2FiyatFarki.Name = "Grid2FiyatFarki"
        '
        'Grid2Maliyet
        '
        Me.Grid2Maliyet.Caption = "Maliyet"
        Me.Grid2Maliyet.DisplayFormat.FormatString = "#,0.00"
        Me.Grid2Maliyet.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Grid2Maliyet.FieldName = "MALIYET"
        Me.Grid2Maliyet.Name = "Grid2Maliyet"
        Me.Grid2Maliyet.Visible = True
        Me.Grid2Maliyet.VisibleIndex = 5
        '
        'Grid2Fiyat4
        '
        Me.Grid2Fiyat4.Caption = "Fiyat4"
        Me.Grid2Fiyat4.DisplayFormat.FormatString = "#,0.00"
        Me.Grid2Fiyat4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Grid2Fiyat4.FieldName = "ONBESAY"
        Me.Grid2Fiyat4.Name = "Grid2Fiyat4"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sRenkAdi", "Renk")})
        Me.RepositoryItemLookUpEdit2.DisplayMember = "sRenkAdi"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.ValueMember = "sRenk"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "SATICI"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = "[Satýcýlar]"
        Me.RepositoryItemLookUpEdit1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.RepositoryItemLookUpEdit1.ShowFooter = False
        Me.RepositoryItemLookUpEdit1.ShowHeader = False
        Me.RepositoryItemLookUpEdit1.ShowLines = False
        Me.RepositoryItemLookUpEdit1.ValueMember = "sSaticiRumuzu"
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.DisplayMember = "sKat"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.ValueMember = "sSaticiRumuzu"
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
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_renk, Me.sec_satici})
        Me.GridControl1.Size = New System.Drawing.Size(1071, 283)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nAlisverisID"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "nMusteriID"
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "lKodu"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sMusteriAdi"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "dteTarih"
        Me.DataColumn5.DataType = GetType(Date)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "fisTipi"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "lNo"
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "nStokID"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sKodu"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "sStokAciklama"
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "Miktar"
        Me.DataColumn11.DataType = GetType(Decimal)
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "Fiyat"
        Me.DataColumn12.DataType = GetType(Decimal)
        '
        'DataColumn13
        '
        Me.DataColumn13.ColumnName = "Iskonto"
        Me.DataColumn13.DataType = GetType(Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "lNetTutar"
        Me.DataColumn14.DataType = GetType(Decimal)
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "sOdemeKodu"
        '
        'DataColumn16
        '
        Me.DataColumn16.ColumnName = "sFiyatTipi"
        '
        'DataColumn17
        '
        Me.DataColumn17.ColumnName = "sSaticiRumuzu"
        '
        'DataColumn18
        '
        Me.DataColumn18.ColumnName = "sKasiyerRumuzu"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "nGirisCikis"
        '
        'DataColumn20
        '
        Me.DataColumn20.ColumnName = "sMagaza"
        '
        'DataColumn21
        '
        Me.DataColumn21.ColumnName = "sRenk"
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnAlisverisID, Me.colnMusteriID, Me.collKodu, Me.colsMusteriAdi, Me.coldteTarih, Me.colfisTipi, Me.collNo, Me.colnStokID, Me.colsKodu, Me.colsStokAciklama, Me.colMiktar, Me.colFiyat, Me.colIskonto, Me.collNetTutar, Me.colsOdemeKodu, Me.colsFiyatTipi, Me.colsSaticiRumuzu, Me.colsKasiyerRumuzu, Me.colnGirisCikis, Me.colsMagaza, Me.colsRenk, Me.colORAN1, Me.colPESIN, Me.colALTIAY, Me.colONAY, Me.colKAR, Me.colFARK, Me.colNORMALFIYAT, Me.colNORMALTUTAR, Me.colFIYATFARKI, Me.colSonAlisTarihi, Me.sKat, Me.colMALIYET, Me.colONBESAY})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(522, 322, 208, 170)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Blue
        StyleFormatCondition3.Appearance.Options.UseForeColor = True
        StyleFormatCondition3.Column = Me.colORAN1
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition3.Value1 = "0"
        StyleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition4.Appearance.Options.UseForeColor = True
        StyleFormatCondition4.ApplyToRow = True
        StyleFormatCondition4.Column = Me.colORAN1
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition4.Value1 = "0"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition3, StyleFormatCondition4})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", Nothing, "{0:#,0.00} prç"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", Nothing, "Tutar:{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "sKodu", Me.colsKodu, "{0} Kayýt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", Me.colMiktar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", Me.collNetTutar, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FARK", Me.colFARK, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "nStokID", Me.colnStokID, "")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colnAlisverisID
        '
        Me.colnAlisverisID.Caption = "AlýþVeriþ No"
        Me.colnAlisverisID.FieldName = "nAlisverisID"
        Me.colnAlisverisID.Name = "colnAlisverisID"
        '
        'colnMusteriID
        '
        Me.colnMusteriID.Caption = "Müþteri No"
        Me.colnMusteriID.FieldName = "nMusteriID"
        Me.colnMusteriID.Name = "colnMusteriID"
        '
        'collKodu
        '
        Me.collKodu.Caption = "Müþteri Kodu"
        Me.collKodu.FieldName = "lKodu"
        Me.collKodu.Name = "collKodu"
        Me.collKodu.Width = 55
        '
        'colsMusteriAdi
        '
        Me.colsMusteriAdi.Caption = "HesapAdý"
        Me.colsMusteriAdi.FieldName = "sMusteriAdi"
        Me.colsMusteriAdi.Name = "colsMusteriAdi"
        Me.colsMusteriAdi.Visible = True
        Me.colsMusteriAdi.VisibleIndex = 3
        Me.colsMusteriAdi.Width = 120
        '
        'coldteTarih
        '
        Me.coldteTarih.Caption = "Tarih"
        Me.coldteTarih.FieldName = "dteTarih"
        Me.coldteTarih.Name = "coldteTarih"
        Me.coldteTarih.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteTarih", "{0} Kayýt")})
        Me.coldteTarih.Visible = True
        Me.coldteTarih.VisibleIndex = 0
        Me.coldteTarih.Width = 63
        '
        'colfisTipi
        '
        Me.colfisTipi.Caption = "Fiþ Tipi"
        Me.colfisTipi.FieldName = "fisTipi"
        Me.colfisTipi.Name = "colfisTipi"
        Me.colfisTipi.Visible = True
        Me.colfisTipi.VisibleIndex = 1
        Me.colfisTipi.Width = 42
        '
        'collNo
        '
        Me.collNo.Caption = "Fiþ No"
        Me.collNo.FieldName = "lNo"
        Me.collNo.Name = "collNo"
        Me.collNo.Visible = True
        Me.collNo.VisibleIndex = 2
        Me.collNo.Width = 44
        '
        'colnStokID
        '
        Me.colnStokID.Caption = "Stok No"
        Me.colnStokID.FieldName = "nStokID"
        Me.colnStokID.Name = "colnStokID"
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Stok Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 4
        Me.colsKodu.Width = 70
        '
        'colsStokAciklama
        '
        Me.colsStokAciklama.Caption = "Stok Adý"
        Me.colsStokAciklama.FieldName = "sStokAciklama"
        Me.colsStokAciklama.Name = "colsStokAciklama"
        Me.colsStokAciklama.Visible = True
        Me.colsStokAciklama.VisibleIndex = 5
        Me.colsStokAciklama.Width = 140
        '
        'colMiktar
        '
        Me.colMiktar.Caption = "Miktar"
        Me.colMiktar.DisplayFormat.FormatString = "#,0.##"
        Me.colMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMiktar.FieldName = "Miktar"
        Me.colMiktar.Name = "colMiktar"
        Me.colMiktar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Miktar", "{0:#,0.00}")})
        Me.colMiktar.Visible = True
        Me.colMiktar.VisibleIndex = 6
        Me.colMiktar.Width = 39
        '
        'colFiyat
        '
        Me.colFiyat.Caption = "Fiyat"
        Me.colFiyat.DisplayFormat.FormatString = "#,0.00##"
        Me.colFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFiyat.FieldName = "Fiyat"
        Me.colFiyat.Name = "colFiyat"
        Me.colFiyat.Visible = True
        Me.colFiyat.VisibleIndex = 7
        Me.colFiyat.Width = 50
        '
        'colIskonto
        '
        Me.colIskonto.Caption = "Iskonto"
        Me.colIskonto.DisplayFormat.FormatString = "#,0.00"
        Me.colIskonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colIskonto.FieldName = "Iskonto"
        Me.colIskonto.Name = "colIskonto"
        '
        'collNetTutar
        '
        Me.collNetTutar.Caption = "Net Tutar"
        Me.collNetTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collNetTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collNetTutar.FieldName = "lNetTutar"
        Me.collNetTutar.Name = "collNetTutar"
        Me.collNetTutar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lNetTutar", "{0:#,0.00}")})
        Me.collNetTutar.Visible = True
        Me.collNetTutar.VisibleIndex = 8
        Me.collNetTutar.Width = 55
        '
        'colsOdemeKodu
        '
        Me.colsOdemeKodu.Caption = "Ödeme Kodu"
        Me.colsOdemeKodu.FieldName = "sOdemeKodu"
        Me.colsOdemeKodu.Name = "colsOdemeKodu"
        Me.colsOdemeKodu.Width = 70
        '
        'colsFiyatTipi
        '
        Me.colsFiyatTipi.Caption = "FiyatTipi"
        Me.colsFiyatTipi.FieldName = "sFiyatTipi"
        Me.colsFiyatTipi.Name = "colsFiyatTipi"
        Me.colsFiyatTipi.Width = 56
        '
        'colsSaticiRumuzu
        '
        Me.colsSaticiRumuzu.Caption = "Satici"
        Me.colsSaticiRumuzu.ColumnEdit = Me.sec_satici
        Me.colsSaticiRumuzu.FieldName = "sSaticiRumuzu"
        Me.colsSaticiRumuzu.Name = "colsSaticiRumuzu"
        Me.colsSaticiRumuzu.Visible = True
        Me.colsSaticiRumuzu.VisibleIndex = 9
        Me.colsSaticiRumuzu.Width = 43
        '
        'sec_satici
        '
        Me.sec_satici.AutoHeight = False
        Me.sec_satici.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_satici.DisplayMember = "SATICI"
        Me.sec_satici.Name = "sec_satici"
        Me.sec_satici.NullText = "[Satýcýlar]"
        Me.sec_satici.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_satici.ShowFooter = False
        Me.sec_satici.ShowHeader = False
        Me.sec_satici.ShowLines = False
        Me.sec_satici.ValueMember = "sSaticiRumuzu"
        '
        'colsKasiyerRumuzu
        '
        Me.colsKasiyerRumuzu.Caption = "Kasiyer"
        Me.colsKasiyerRumuzu.FieldName = "sKasiyerRumuzu"
        Me.colsKasiyerRumuzu.Name = "colsKasiyerRumuzu"
        Me.colsKasiyerRumuzu.Width = 64
        '
        'colnGirisCikis
        '
        Me.colnGirisCikis.Caption = "Giriþ/Çýkýþ"
        Me.colnGirisCikis.FieldName = "nGirisCikis"
        Me.colnGirisCikis.Name = "colnGirisCikis"
        Me.colnGirisCikis.Width = 54
        '
        'colsMagaza
        '
        Me.colsMagaza.Caption = "Maðaza"
        Me.colsMagaza.FieldName = "sMagaza"
        Me.colsMagaza.Name = "colsMagaza"
        Me.colsMagaza.Visible = True
        Me.colsMagaza.VisibleIndex = 10
        Me.colsMagaza.Width = 55
        '
        'colsRenk
        '
        Me.colsRenk.Caption = "Renk"
        Me.colsRenk.ColumnEdit = Me.sec_renk
        Me.colsRenk.FieldName = "sRenk"
        Me.colsRenk.Name = "colsRenk"
        '
        'sec_renk
        '
        Me.sec_renk.AutoHeight = False
        Me.sec_renk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_renk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("sRenkAdi", "Renk")})
        Me.sec_renk.DisplayMember = "sRenkAdi"
        Me.sec_renk.Name = "sec_renk"
        Me.sec_renk.NullText = ""
        Me.sec_renk.ValueMember = "sRenk"
        '
        'colPESIN
        '
        Me.colPESIN.Caption = "Fiyat1"
        Me.colPESIN.DisplayFormat.FormatString = "#,0.00"
        Me.colPESIN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPESIN.FieldName = "PESIN"
        Me.colPESIN.Name = "colPESIN"
        '
        'colALTIAY
        '
        Me.colALTIAY.Caption = "Fiyat2"
        Me.colALTIAY.DisplayFormat.FormatString = "#,0.00"
        Me.colALTIAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colALTIAY.FieldName = "ALTIAY"
        Me.colALTIAY.Name = "colALTIAY"
        '
        'colONAY
        '
        Me.colONAY.Caption = "Fiyat3"
        Me.colONAY.DisplayFormat.FormatString = "#,0.00"
        Me.colONAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colONAY.FieldName = "ONAY"
        Me.colONAY.Name = "colONAY"
        '
        'colKAR
        '
        Me.colKAR.Caption = "Kar"
        Me.colKAR.DisplayFormat.FormatString = "#,0.00"
        Me.colKAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKAR.FieldName = "KAR"
        Me.colKAR.Name = "colKAR"
        Me.colKAR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KAR", "{0:#,0.00}")})
        Me.colKAR.Visible = True
        Me.colKAR.VisibleIndex = 11
        Me.colKAR.Width = 44
        '
        'colFARK
        '
        Me.colFARK.Caption = "Tutar Farký"
        Me.colFARK.DisplayFormat.FormatString = "#,0.00"
        Me.colFARK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFARK.FieldName = "FARK"
        Me.colFARK.Name = "colFARK"
        Me.colFARK.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FARK", "{0:#,0.00}")})
        '
        'colNORMALFIYAT
        '
        Me.colNORMALFIYAT.Caption = "Normal Fiyat"
        Me.colNORMALFIYAT.DisplayFormat.FormatString = "#,0.00"
        Me.colNORMALFIYAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNORMALFIYAT.FieldName = "NORMALFIYAT"
        Me.colNORMALFIYAT.Name = "colNORMALFIYAT"
        '
        'colNORMALTUTAR
        '
        Me.colNORMALTUTAR.Caption = "Normal Tutar"
        Me.colNORMALTUTAR.DisplayFormat.FormatString = "#,0.00"
        Me.colNORMALTUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNORMALTUTAR.FieldName = "NORMALTUTAR"
        Me.colNORMALTUTAR.Name = "colNORMALTUTAR"
        '
        'colFIYATFARKI
        '
        Me.colFIYATFARKI.Caption = "Fiyat Farký"
        Me.colFIYATFARKI.DisplayFormat.FormatString = "#,0.00"
        Me.colFIYATFARKI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYATFARKI.FieldName = "FIYATFARKI"
        Me.colFIYATFARKI.Name = "colFIYATFARKI"
        '
        'colSonAlisTarihi
        '
        Me.colSonAlisTarihi.Caption = "Son Alýþ Tarihi"
        Me.colSonAlisTarihi.FieldName = "SonAlisTarihi"
        Me.colSonAlisTarihi.Name = "colSonAlisTarihi"
        '
        'sKat
        '
        Me.sKat.Caption = "Kat"
        Me.sKat.ColumnEdit = Me.sec_sKat
        Me.sKat.FieldName = "sSaticiRumuzu"
        Me.sKat.Name = "sKat"
        '
        'sec_sKat
        '
        Me.sec_sKat.AutoHeight = False
        Me.sec_sKat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sKat.DisplayMember = "sKat"
        Me.sec_sKat.Name = "sec_sKat"
        Me.sec_sKat.ValueMember = "sSaticiRumuzu"
        '
        'colMALIYET
        '
        Me.colMALIYET.Caption = "Maliyet"
        Me.colMALIYET.DisplayFormat.FormatString = "#,0.00"
        Me.colMALIYET.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMALIYET.FieldName = "MALIYET"
        Me.colMALIYET.Name = "colMALIYET"
        '
        'colONBESAY
        '
        Me.colONBESAY.Caption = "Fiyat4"
        Me.colONBESAY.DisplayFormat.FormatString = "#,0.00"
        Me.colONBESAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colONBESAY.FieldName = "ONBESAY"
        Me.colONBESAY.Name = "colONBESAY"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Satýþ Kontrol", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Crm-Müþteri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_stok_satis_karlilik
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 20)
        Me.ClientSize = New System.Drawing.Size(1075, 611)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_satis_karlilik"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Satýþ Karlýlýk Analizi"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_kriter_firma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_smagaza.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_depo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.urunBazli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_MaliyetTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum_stok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter_stok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara_stok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.sec_bZararinaSatislar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.sec_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sec_grid.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_satici, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sKat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public kullanici
    Public islemstatus As Boolean = False
    Public firmatipi As Boolean = False
    Public islem As Integer = 0
    Public kriter_fistipi As String = "'FS'"
    Public kriter_musteriID As String = ""
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_satici As New DataSet
    Dim ds_magaza As New DataSet
    Dim ds_tbStoklar As DataSet
    Dim ds_tbAlislar As DataSet
    Dim ds_tbSatislar As DataSet
    Dim lBasitMaliyet As Decimal = 0
    Dim lGirisMaliyet As Decimal = 0
    Dim tarih1 As DateTime
    Dim grid2V As Boolean = False
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        If kriter_musteriID = "" Then
            DateEdit1.EditValue = dteSistemTarihi '"01/01/" + Today.Year.ToString
            DateEdit2.EditValue = dteSistemTarihi '"31/12/" + Today.Year.ToString
            DateEdit1.Focus()
            DateEdit1.Select()
        Else
            loading()
            GridControl1.Focus()
            GridControl1.Select()
        End If
        If txt_ara.EditValue <> "" Then
        Else
            txt_ara.EditValue = ""
        End If
        txt_ara_stok.EditValue = ""
        dataload_renk()
        dataload_satici()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub dataload_renk()
        sec_renk.DataSource = sorgu(sorgu_query("SELECT * FROM tbRenk")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub dataload_satici()
        'sec_satici.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu , sAdi + ' ' + sSoyadi AS SATICI,sKat  FROM         tbSaticiKatlari ")).Tables(0)
        'sec_sKat.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu , sAdi + ' ' + sSoyadi AS SATICI,sKat  FROM         tbSaticiKatlari ")).Tables(0)
        sec_satici.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu , sAdi + ' ' + sSoyadi AS SATICI  FROM         tbSatici where bAktif =1")).Tables(0)
        ds_satici = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST('0' as bit) AS SEC, sSaticiRumuzu AS KOD, sAdi + ' ' + sSoyadi AS ACIKLAMA FROM         tbSatici where bAktif =1"))
        ds_magaza = sorgu(sorgu_query("SELECT     CAST('0' as bit) AS SEC, sDepo AS KOD, sAciklama AS ACIKLAMA FROM         tbDepo WHERE sDepo <> '' ORDER BY sDepo"))
        GridControl3.DataSource = ds_satici.Tables(0)
        GridControl3.DataMember = Nothing
        
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
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        If urunBazli.Checked = True Then
            GridView2.ColumnsCustomization()
        Else
            GridView1.ColumnsCustomization()
        End If
    End Sub
  
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        If urunBazli.Checked = True Then
            If MenuItem5.Checked = False Then
                GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
                GridView2.OptionsCustomization.AllowFilter = True
                MenuItem5.Checked = True
            Else
                GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                GridView2.OptionsCustomization.AllowFilter = False
                MenuItem5.Checked = False
            End If
        Else
            If MenuItem5.Checked = False Then
                GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
                GridView1.OptionsCustomization.AllowFilter = True
                MenuItem5.Checked = True
            Else
                GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                GridView1.OptionsCustomization.AllowFilter = False
                MenuItem5.Checked = False
            End If
        End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If urunBazli.Checked = True Then
            If MenuItem6.Checked = False Then
                GridView2.OptionsView.ShowGroupPanel = True
                GridView2.OptionsCustomization.AllowGroup = True
                MenuItem6.Checked = True
            Else
                GridView2.OptionsView.ShowGroupPanel = False
                GridView2.OptionsCustomization.AllowGroup = False
                MenuItem6.Checked = False
            End If
        Else
            If MenuItem6.Checked = False Then
                GridView1.OptionsView.ShowGroupPanel = True
                GridView1.OptionsCustomization.AllowGroup = True
                MenuItem6.Checked = True
            Else
                GridView1.OptionsView.ShowGroupPanel = False
                GridView1.OptionsCustomization.AllowGroup = False
                MenuItem6.Checked = False
            End If
        End If
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        If urunBazli.Checked = True Then
            GridView2.ExpandAllGroups()
        Else
            GridView1.ExpandAllGroups()
        End If
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        If urunBazli.Checked = True Then
            GridView2.CollapseAllGroups()
        Else
            GridView1.CollapseAllGroups()
        End If
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
        kriter += Microsoft.VisualBasic.Left(DateEdit1.EditValue.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(DateEdit2.EditValue.ToString, 10) & " Tarihleri Arasýndaki Satýþlar" & vbCrLf
        'kriter += "Limit = " & txt_altlimit.EditValue & "-" & txt_ustlimit.EditValue
        printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Crm-Müþteri Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        If urunBazli.Checked = True Then
            GridView2.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "2")
        Else
            GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        End If
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
        GridView2.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "2")
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
    Public Function stok(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara_stok As String, ByVal konum_stok As String, ByVal ara_kriter_stok As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal MaliyetTipi As Integer, ByVal satici As String, ByVal smagaza As String) As DataSet
        If sec_kriter_firma.Text = "Firma" Then
            firmatipi = True
        End If
        Dim kriter As String = ""
        If ara.ToString <> "" Then
            If sec_konum.Text = "Kodu" Then
                If firmatipi = False Then
                    kriter += " AND (tbMusteri.lKodu " & sorgu_kriter_string(ara, ara_kriter) & ")"
                Else
                    kriter += " AND (tbFirma.sKodu " & sorgu_kriter_string(ara, ara_kriter) & ")"
                End If
            ElseIf sec_konum.Text = "Adý" Then
                If firmatipi = False Then
                    kriter += " AND (tbMusteri.sAdi " & sorgu_kriter_string(ara, ara_kriter) & ")"
                Else
                    kriter += " AND (tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
                End If
            ElseIf sec_konum.Text = "Soyadý" Then
                kriter += " AND (tbMusteri.sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "Ýstihbarat" Then
                kriter += " AND ((tbMusteri.sAciklama1 + ' ' + tbMusteri.sAciklama2 + ' ' + tbMusteri.sAciklama3 + ' ' + tbMusteri.sAciklama4 + '  ' + tbMusteri.sAciklama5) " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "EvAdresi" Then
                kriter += " AND (tbMusteri.sEvAdresi1 + ' ' + tbMusteri.sEvAdresi2 + ' ' + tbMusteri.sEvSemt + ' ' + tbMusteri.sEvPostaKodu + ' ' + tbMusteri.sEvIl " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "ÝþAdresi" Then
                kriter += " AND (tbMusteri.sIsAdresi1 + ' ' + tbMusteri.sIsAdresi2 + ' ' + tbMusteri.sIsSemt + ' ' + tbMusteri.sIsIl + ' ' + tbMusteri.sIsPostaKodu " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "EvTelefonu" Then
                kriter += " AND (tbMusteri.sEvTelefonu " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "ÝþTelefonu" Then
                kriter += " AND (tbMusteri.sIsTelefonu " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "Gsm" Then
                kriter += " AND (tbMusteri.sGsm " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "DoðumYeri" Then
                kriter += " AND (tbMusteri.sDogumYeri " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "1.Kefil Adý" Then
                kriter += " AND tbMusteri.nMusteriID IN (Select nMusteriID from tbMusteriKefil1 where sAdi + ' ' + sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "2.Kefil Adý" Then
                kriter += " AND tbMusteri.nMusteriID IN (Select nMusteriID from tbMusteriKefil2 where sAdi + ' ' + sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "MSýnýf1" Then
                kriter += " AND (tbMSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "MSýnýf2" Then
                kriter += " AND (tbMSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "MSýnýf3" Then
                kriter += " AND (tbMSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "MSýnýf4" Then
                kriter += " AND (tbMSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "MSýnýf5" Then
            ElseIf sec_konum.Text = "FSýnýf1" Then
                kriter += " AND (tbFSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "FSýnýf2" Then
                kriter += " AND (tbFSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "FSýnýf3" Then
                kriter += " AND (tbFSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "FSýnýf4" Then
                kriter += " AND (tbFSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum.Text = "FSýnýf5" Then
                kriter += " AND (tbFSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
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
                    kriter += " AND (tbMusteri.sAdi " & sorgu_kriter_string(adi, ara_kriter) & ")"
                End If
                If soyadi.ToString <> "" Then
                    kriter += " AND (tbMusteri.sSoyadi " & sorgu_kriter_string(soyadi, ara_kriter) & ")"
                End If
            End If
        End If
        Dim kriter_satici As String = ""
        Dim kriter_satici1 As String = ""
        Dim kriter_magaza As String = ""
        Dim kriter_siparis_magaza As String = ""
        If satici <> "[Tümü]" Then
            kriter_satici += "  AND tbStokFisiDetayi.sSaticiRumuzu IN ( " & satici & " )"
            kriter_satici1 += "  AND tbAlisverisSiparis.sSaticiRumuzu IN ( " & satici & " )"

        End If
        If smagaza <> "[Tümü]" Then
            If islem = 0 Then
                kriter += " AND tbAlisVeris.sMagaza IN ( " & smagaza & " )"
                kriter_magaza += " AND tbStokFisiDetayi.sDepo IN (" & smagaza & " ) "
                kriter_siparis_magaza += " AND tbAlisVeris.sMagaza IN ( " & smagaza & " )"
            Else
                kriter += " AND tbStokFisiDetayi.sDepo IN ( " & smagaza & " )"
                kriter_magaza += " AND tbStokFisiDetayi.sDepo IN (" & smagaza & " ) "
                kriter_siparis_magaza += " AND tbAlisVeris.sMagaza IN ( " & smagaza & " )"
            End If
        End If

        If ara_stok.ToString <> "" Then
            If konum_stok = "Kod" Then
                kriter += " AND (tbStok.sKodu " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & ")"
            ElseIf konum_stok = "Ad" Then
                kriter += " AND (tbStok.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & ")"
                'ElseIf konum_stok = "Soyadý" Then
                '   kriter += " AND (tbMusteri.sSoyadi " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf sec_konum_stok.Text = "Sýnýf1" Then
                kriter += " AND tbStok.nStokID IN (SELECT tbStok.nStokID FROM tbStok INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif1.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & ")"
            ElseIf sec_konum_stok.Text = "Sýnýf2" Then
                kriter += " AND tbStok.nStokID IN (SELECT tbStok.nStokID FROM tbStok INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif2.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & ")"
            ElseIf sec_konum_stok.Text = "Sýnýf3" Then
                kriter += " AND tbStok.nStokID IN (SELECT tbStok.nStokID FROM tbStok INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif3.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & ")"
            ElseIf sec_konum_stok.Text = "Sýnýf4" Then
                kriter += " AND tbStok.nStokID IN (SELECT tbStok.nStokID FROM tbStok INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif4.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & ")"
            ElseIf sec_konum_stok.Text = "Sýnýf5" Then
                kriter += " AND tbStok.nStokID IN (SELECT tbStok.nStokID FROM tbStok INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif5.sAciklama " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & ")"
            ElseIf sec_konum_stok.Text = "Barkod" Then
                kriter += " AND tbStok.nStokID IN (SELECT tbStok.nStokID FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID WHERE tbStokBarkodu.sBarkod " & sorgu_kriter_string(ara_stok, ara_kriter_stok) & " )"
            End If
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        If firmatipi = False Then
            If islem = 0 Then
                cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbAlisVeris.nAlisverisID, tbMusteri.nMusteriID, tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, tbAlisVeris.dteFaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, tbAlisVeris.lFaturaNo AS lNo, tbStokFisiDetayi.nIslemID, tbStok.nStokID, tbStok.sKodu AS sKodu, tbStok.sModel, tbStok.sAciklama AS sStokAciklama, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lBrutFiyat, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari, 0) AS Iskonto, ISNULL(tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari, 0) AS lNetTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbAlisVeris.sMagaza, tbStok.sRenk, tbStok.sBeden, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS PESIN, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS ONAY, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'), 0) AS ONBESAY, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS ALTIAY, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, tbStokFisiDetayi.lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID and tbStokFisiDetayi.dteFisTarihi <= tbAlisVeris.dteFaturaTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM tbStok RIGHT OUTER JOIN tbMusteri INNER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID LEFT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND tbAlisveris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & " " & kriter_musteriID & " UNION ALL SELECT tbAlisVeris.nAlisverisID, tbMusteri.nMusteriID, tbMusteri.lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, tbAlisVeris.dteFaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, tbAlisVeris.lFaturaNo AS lNo, 0 as nIslemID, tbStok.nStokID, tbStok.sKodu, tbStok.sModel, tbStok.sAciklama AS sStokAciklama, tbAlisverisSiparis.lGCMiktar AS Miktar, ISNULL(tbAlisverisSiparis.lBrutFiyat, 0) AS Fiyat, ISNULL(tbAlisverisSiparis.lIskontoTutari, 0) AS Iskonto, ISNULL(tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari, 0) AS lNetTutar, tbAlisverisSiparis.sOdemeKodu, tbAlisverisSiparis.sFiyatTipi, tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu, tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu, tbAlisverisSiparis.nGirisCikis AS GirisCikis, tbAlisVeris.sMagaza, tbStok.sRenk, tbStok.sBeden, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS PESIN, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS ONAY, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'), 0) AS ONBESAY, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS ALTIAY, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, CAST(0 AS MONEY) lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID and tbStokFisiDetayi.dteFisTarihi <= tbAlisVeris.dteFaturaTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE tbAlisveris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & kriter_musteriID & ") t ORDER BY nStokID, dteTarih, lNo")
                'cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbAlisVeris.nAlisverisID, tbMusteri.nMusteriID, tbMusteri.lKodu AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, tbAlisVeris.dteFaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, tbAlisVeris.lFaturaNo AS lNo, tbStokFisiDetayi.nIslemID, tbStok.nStokID, tbStok.sKodu AS sKodu, tbStok.sModel, tbStok.sAciklama AS sStokAciklama, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lBrutFiyat, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari, 0) AS Iskonto, ISNULL(tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari, 0) AS lNetTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbAlisVeris.sMagaza, tbStok.sRenk, tbStok.sBeden, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS PESIN, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS ONAY, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'), 0) AS ONBESAY, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS ALTIAY, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, tbStokFisiDetayi.lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID and tbStokFisiDetayi.dteFisTarihi <= tbAlisVeris.dteFaturaTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM tbStok RIGHT OUTER JOIN tbMusteri INNER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID LEFT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND tbAlisveris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & " " & kriter_musteriID & " UNION ALL SELECT tbAlisVeris.nAlisverisID, tbMusteri.nMusteriID, tbMusteri.lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, tbAlisVeris.dteFaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, tbAlisVeris.lFaturaNo AS lNo, 0 as nIslemID, tbStok.nStokID, tbStok.sKodu, tbStok.sModel, tbStok.sAciklama AS sStokAciklama, tbAlisverisSiparis.lGCMiktar AS Miktar, ISNULL(tbAlisverisSiparis.lBrutFiyat, 0) AS Fiyat, ISNULL(tbAlisverisSiparis.lIskontoTutari, 0) AS Iskonto, ISNULL(tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari, 0) AS lNetTutar, tbAlisverisSiparis.sOdemeKodu, tbAlisverisSiparis.sFiyatTipi, tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu, tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu, tbAlisverisSiparis.nGirisCikis AS GirisCikis, tbAlisVeris.sMagaza, tbStok.sRenk, tbStok.sBeden, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS PESIN, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS ONAY, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'), 0) AS ONBESAY, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS ALTIAY, ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, CAST(0 AS MONEY) lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID and tbStokFisiDetayi.dteFisTarihi <= tbAlisVeris.dteFaturaTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID  INNER JOIN tbStokFisiDetayi ON  tbStokFisiDetayi.sDepo= tbStokFisiDetayi.sDepo WHERE tbAlisveris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & kriter_musteriID & ") t " & kriter_satici & " ORDER BY nStokID, dteTarih, lNo")
            ElseIf islem = 1 Then
                'cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbAlisVeris.nAlisverisID, tbMusteri.nMusteriID, CAST(tbMusteri.lKodu AS NVARCHAR(60)) AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, tbAlisVeris.dteFaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, tbAlisVeris.lFaturaNo AS lNo, tbStokFisiDetayi.nIslemID, tbStok.nStokID, tbStok.sKodu AS sKodu, tbStok.sModel, tbStok.sAciklama AS sStokAciklama, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lBrutFiyat, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari, 0) AS Iskonto, tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbAlisVeris.sMagaza, tbStok.sRenk, tbStok.sBeden, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS ONBESAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, tbStokFisiDetayi.lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID and tbStokFisiDetayi.dteFisTarihi <= tbAlisVeris.dteFaturaTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM tbStok RIGHT OUTER JOIN tbMusteri INNER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID LEFT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND tbAlisveris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & " UNION ALL SELECT tbAlisVeris.nAlisverisID, tbMusteri.nMusteriID, CAST(tbMusteri.lKodu AS NVARCHAR(60)) AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, tbAlisVeris.dteFaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, tbAlisVeris.lFaturaNo AS lNo, 0 AS nIslemID, tbStok.nStokID, tbStok.sKodu, tbStok.sModel, tbStok.sAciklama AS sStokAciklama, tbAlisverisSiparis.lGCMiktar AS Miktar, tbAlisverisSiparis.lBrutFiyat AS Fiyat, tbAlisverisSiparis.lIskontoTutari AS Iskonto, tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar, tbAlisverisSiparis.sOdemeKodu, tbAlisverisSiparis.sFiyatTipi, tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu, tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu, tbAlisverisSiparis.nGirisCikis AS GirisCikis, tbAlisVeris.sMagaza, tbStok.sRenk, tbStok.sBeden, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS ONBESAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, CAST(0 AS MONEY) AS lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID and tbStokFisiDetayi.dteFisTarihi <= tbAlisVeris.dteFaturaTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE tbAlisveris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "'" & kriter & " UNION ALL SELECT CAST(tbStokFisiDetayi.nStokFisiID AS NVARCHAR(20)) AS nAlisVerisID, tbStokFisiDetayi.nFirmaID AS nMusteriID, tbFirma.sKodu AS lKodu, tbFirma.sAciklama AS sMusteriAdi, tbStokFisiDetayi.dteFisTarihi AS dteTarih, tbStokFisiMaster.sFisTipi AS fisTipi, tbStokFisiMaster.lFisNo AS lNo, tbStokFisiDetayi.nIslemID, tbStok.nStokID, tbStok.sKodu AS sKodu, tbStok.sModel, tbStok.sAciklama AS sStokAciklama, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, cast(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lNetTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo AS sMagaza, tbStok.sRenk, tbStok.sBeden, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS ONBESAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, tbStokFisiDetayi.lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID AND tbStokFisiDetayi.dteFisTarihi <= tbStokFisiMaster.dteFisTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM tbFirma INNER JOIN tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID ON tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID LEFT OUTER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiDetayi.sFisTipi = 'FS') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) t ORDER BY nStokID, dteTarih, lNo")
                'cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT CAST(tbStokFisiDetayi.nStokFisiID AS NVARCHAR(20)) AS nAlisVerisID, tbStokFisiDetayi.nFirmaID AS nMusteriID, tbFirma.sKodu AS lKodu, tbFirma.sAciklama AS sMusteriAdi, tbStokFisiDetayi.dteFisTarihi AS dteTarih,tbStokFisiMaster.sFisTipi AS fisTipi, tbStokFisiMaster.lFisNo AS lNo,tbStokFisiDetayi.nIslemID, tbStok.nStokID, tbStok.sKodu AS sKodu,tbStok.sModel, tbStok.sAciklama AS sStokAciklama, (CASE WHEN (select bTersOran from tbStokBirimCevrimi br where (br.nStokID = tbStokFisiDetayi.nStokID) and (br.sBirimCinsi = tbStokFisiDetayi.sBirimCinsi)) = 0 then ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) else (ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0)) / (ISNULL(tbStokFisiDetayi.lBirimMiktar, 0)) end) AS Miktar,ISNULL(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, cast(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lNetTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo AS sMagaza, tbStok.sRenk, tbStok.sBeden, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS ONBESAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, tbStokFisiDetayi.lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FS') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID AND tbStokFisiDetayi.dteFisTarihi <= tbStokFisiMaster.dteFisTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC ) AS SonAlisTarihi FROM tbFirma INNER JOIN tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID ON tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID INNER JOIN tbFirmaSinifi on tbFirmaSinifi.nFirmaID = tbFirma.nFirmaID  INNER JOIN tbFSinif1 on tbFirmaSinifi.sSinifKodu1 = tbFSinif1.sSinifKodu LEFT OUTER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiDetayi.sFisTipi = 'FS') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' and '" & tarih2 & "' " & kriter & ")  ORDER BY nStokID, dteTarih, lNo ")
                'cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbAlisVeris.nAlisverisID, tbMusteri.nMusteriID, CAST(tbMusteri.lKodu AS NVARCHAR(60)) AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, tbAlisVeris.dteFaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, tbAlisVeris.lFaturaNo AS lNo, tbStokFisiDetayi.nIslemID, tbStok.nStokID, tbStok.sKodu AS sKodu, tbStok.sModel, tbStok.sAciklama AS sStokAciklama, (CASE WHEN (select bTersOran from tbStokBirimCevrimi br where (br.nStokID = tbStokFisiDetayi.nStokID) and (br.sBirimCinsi = tbStokFisiDetayi.sBirimCinsi)) = 0 then ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) else (ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0)) / (ISNULL(tbStokFisiDetayi.lBirimMiktar, 0)) end) AS Miktar, ISNULL(tbStokFisiDetayi.lBrutFiyat, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari, 0) AS Iskonto, tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbAlisVeris.sMagaza, tbStok.sRenk, tbStok.sBeden, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS ONBESAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, tbStokFisiDetayi.lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID and tbStokFisiDetayi.dteFisTarihi <= tbAlisVeris.dteFaturaTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM tbStok RIGHT OUTER JOIN tbMusteri INNER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID LEFT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID INNER JOIN tbFirmaSinifi on tbFirmaSinifi.nFirmaID = tbFirmaSinifi.nFirmaID INNER JOIN tbFSinif1 on tbFirmaSinifi.sSinifKodu1 = tbFSinif1.sSinifKodu INNER JOIN tbFSinif2 on tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 on tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 on tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 on tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'FA') AND tbAlisveris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & " UNION ALL SELECT tbAlisVeris.nAlisverisID, tbMusteri.nMusteriID, CAST(tbMusteri.lKodu AS NVARCHAR(60)) AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, tbAlisVeris.dteFaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, tbAlisVeris.lFaturaNo AS lNo, 0 AS nIslemID, tbStok.nStokID, tbStok.sKodu, tbStok.sModel, tbStok.sAciklama AS sStokAciklama, tbAlisverisSiparis.lGCMiktar AS Miktar, tbAlisverisSiparis.lBrutFiyat AS Fiyat, tbAlisverisSiparis.lIskontoTutari AS Iskonto, tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar, tbAlisverisSiparis.sOdemeKodu, tbAlisverisSiparis.sFiyatTipi, tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu, tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu, tbAlisverisSiparis.nGirisCikis AS GirisCikis, tbAlisVeris.sMagaza, tbStok.sRenk, tbStok.sBeden, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS ONBESAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, CAST(0 AS MONEY) AS lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID and tbStokFisiDetayi.dteFisTarihi <= tbAlisVeris.dteFaturaTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID  WHERE tbAlisveris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "' UNION ALL SELECT CAST(tbStokFisiDetayi.nStokFisiID AS NVARCHAR(20)) AS nAlisVerisID, tbStokFisiDetayi.nFirmaID AS nMusteriID, tbFirma.sKodu AS lKodu, tbFirma.sAciklama AS sMusteriAdi, tbStokFisiDetayi.dteFisTarihi AS dteTarih, tbStokFisiMaster.sFisTipi AS fisTipi, tbStokFisiMaster.lFisNo AS lNo, tbStokFisiDetayi.nIslemID, tbStok.nStokID, tbStok.sKodu AS sKodu, tbStok.sModel, tbStok.sAciklama AS sStokAciklama, (CASE WHEN (select bTersOran from tbStokBirimCevrimi br where (br.nStokID = tbStokFisiDetayi.nStokID) and (br.sBirimCinsi = tbStokFisiDetayi.sBirimCinsi)) = 0 then ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) else (ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0)) / (ISNULL(tbStokFisiDetayi.lBirimMiktar, 0)) end) AS Miktar, ISNULL(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, cast(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lNetTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo AS sMagaza, tbStok.sRenk, tbStok.sBeden, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS ONBESAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, tbStokFisiDetayi.lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID AND tbStokFisiDetayi.dteFisTarihi <= tbStokFisiMaster.dteFisTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM tbFirma INNER JOIN tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID ON tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID INNER JOIN tbFirmaSinifi on tbFirmaSinifi.nFirmaID = tbFirma.nFirmaID  INNER JOIN tbFSinif1 on tbFirmaSinifi.sSinifKodu1 = tbFSinif1.sSinifKodu INNER JOIN tbFSinif2 on tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 on tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 on tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 on tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu LEFT OUTER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID    " & kriter_satici & " AND (tbStokFisiDetayi.sFisTipi = 'FS') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' and '" & tarih2 & "' " & kriter & " )) t ORDER BY nStokID, dteTarih, lNo")
                cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbAlisVeris.nAlisverisID, tbMusteri.nMusteriID, CAST(tbMusteri.lKodu AS NVARCHAR(60)) AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, tbAlisVeris.dteFaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, tbAlisVeris.lFaturaNo AS lNo, tbStokFisiDetayi.nIslemID, tbStok.nStokID, tbStok.sKodu AS sKodu, tbStok.sModel, tbStok.sAciklama AS sStokAciklama,ISNULL(tbStokFisiDetayi.lCikisMiktar1 , 0) AS Miktar ,  ISNULL(tbStokFisiDetayi.lBrutFiyat, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari, 0) AS Iskonto, tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbAlisVeris.sMagaza, tbStok.sRenk, tbStok.sBeden, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS ONBESAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, tbStokFisiDetayi.lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID and tbStokFisiDetayi.dteFisTarihi <= tbAlisVeris.dteFaturaTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM tbStok RIGHT OUTER JOIN tbMusteri INNER JOIN tbAlisVeris INNER JOIN tbDepo ON tbAlisVeris.sMagaza = tbDepo.sDepo ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID LEFT OUTER JOIN tbStokFisiDetayi ON tbAlisVeris.nAlisverisID = tbStokFisiDetayi.nAlisverisID ON tbStok.nStokID = tbStokFisiDetayi.nStokID WHERE (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbAlisVeris.sFisTipi = 'P' OR tbAlisVeris.sFisTipi = 'K' OR tbAlisVeris.sFisTipi = 'Ks' OR tbAlisVeris.sFisTipi = 'PD' OR tbAlisVeris.sFisTipi = 'PTX') AND tbAlisveris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter_satici & " " & kriter_siparis_magaza & " UNION ALL SELECT tbAlisVeris.nAlisverisID, tbMusteri.nMusteriID, CAST(tbMusteri.lKodu AS NVARCHAR(60)) AS lKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sMusteriAdi, tbAlisVeris.dteFaturaTarihi AS dteTarih, tbAlisVeris.sFisTipi AS fisTipi, tbAlisVeris.lFaturaNo AS lNo, 0 AS nIslemID, tbStok.nStokID, tbStok.sKodu, tbStok.sModel, tbStok.sAciklama AS sStokAciklama, tbAlisverisSiparis.lGCMiktar AS Miktar, tbAlisverisSiparis.lBrutFiyat AS Fiyat, tbAlisverisSiparis.lIskontoTutari AS Iskonto, tbAlisverisSiparis.lBrutTutar - tbAlisverisSiparis.lIskontoTutari AS lNetTutar, tbAlisverisSiparis.sOdemeKodu, tbAlisverisSiparis.sFiyatTipi, tbAlisverisSiparis.sSaticiRumuzu AS SaticiRumuzu, tbAlisverisSiparis.sKasiyerRumuzu AS KasiyerRumuzu, tbAlisverisSiparis.nGirisCikis AS GirisCikis, tbAlisVeris.sMagaza, tbStok.sRenk, tbStok.sBeden, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS ONBESAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, CAST(0 AS MONEY) AS lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID and tbStokFisiDetayi.dteFisTarihi <= tbAlisVeris.dteFaturaTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE tbAlisveris.dteFaturaTarihi between '" & tarih1 & "' and '" & tarih2 & "'  " & kriter_satici1 & " " & kriter_siparis_magaza & " UNION ALL SELECT CAST(tbStokFisiDetayi.nStokFisiID AS NVARCHAR(20)) AS nAlisVerisID, tbStokFisiDetayi.nFirmaID AS nMusteriID, tbFirma.sKodu AS lKodu, tbFirma.sAciklama AS sMusteriAdi, tbStokFisiDetayi.dteFisTarihi AS dteTarih, tbStokFisiMaster.sFisTipi AS fisTipi, tbStokFisiMaster.lFisNo AS lNo, tbStokFisiDetayi.nIslemID, tbStok.nStokID, tbStok.sKodu AS sKodu, tbStok.sModel, tbStok.sAciklama AS sStokAciklama, (CASE WHEN (select bTersOran from tbStokBirimCevrimi br where (br.nStokID = tbStokFisiDetayi.nStokID) and (br.sBirimCinsi = tbStokFisiDetayi.sBirimCinsi)) = 0 then ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) else (ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0)) / (ISNULL(tbStokFisiDetayi.lBirimMiktar, 0)) end) AS Miktar, ISNULL(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, cast(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lNetTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo AS sMagaza, tbStok.sRenk, tbStok.sBeden, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS ONBESAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET, tbStokFisiDetayi.lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID AND tbStokFisiDetayi.dteFisTarihi <= tbStokFisiMaster.dteFisTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM  tbFirma INNER JOIN tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID ON tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID LEFT OUTER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiDetayi.sFisTipi = 'FS') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' " & kriter_satici & " " & kriter & " )) t ORDER BY nStokID, dteTarih, lNo")
            ElseIf islem = 2 Then
                cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT CAST(tbStokFisiDetayi.nStokFisiID AS NVARCHAR(20)) AS nAlisVerisID, tbStokFisiDetayi.nFirmaID AS nMusteriID, tbFirma.sKodu AS lKodu, tbFirma.sAciklama AS sMusteriAdi, tbStokFisiDetayi.dteFisTarihi AS dteTarih, tbStokFisiMaster.sFisTipi AS fisTipi, tbStokFisiMaster.lFisNo AS lNo, tbStokFisiDetayi.nIslemID, tbStok.nStokID, tbStok.sKodu AS sKodu, tbStok.sModel, tbStok.sAciklama AS sStokAciklama, ISNULL(tbStokFisiDetayi.lCikisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari * (100 + tbStokFisiDetayi.nKdvOrani) / 100, 0) AS Iskonto, cast(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lNetTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo AS sMagaza, tbStok.sRenk, tbStok.sBeden, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS ONBESAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, (SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET,tbStokFisiDetayi.lMaliyetFiyat, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS FARK, CAST(0 AS MONEY) AS FIYATFARKI, CAST(0 AS MONEY) AS NORMALFIYAT, CAST(0 AS MONEY) AS NORMALTUTAR, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID AND tbStokFisiDetayi.dteFisTarihi <= tbStokFisiMaster.dteFisTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS SonAlisTarihi FROM tbFirma INNER JOIN tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID ON tbFirma.nFirmaID = tbStokFisiDetayi.nFirmaID LEFT OUTER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiDetayi.sFisTipi = " & kriter_fistipi & ") " & kriter_musteriID & " AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "')) t ORDER BY nStokID, dteTarih, lNo")
            End If
        ElseIf firmatipi = True Then
            cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST(tbStokFisiMaster.nStokFisiID as CHAR(60)) as nAlisVerisID, tbFirma.nFirmaID as nMusteriID, tbFirma.sKodu AS lKodu, tbFirma.sAciklama as sMusteriAdi, tbStokFisiMaster.dteFisTarihi AS dteTarih, tbStokFisiMaster.sFisTipi AS fisTipi, tbStokFisiMaster.lFisNo AS lNo, tbStok.nStokID, tbStok.sKodu AS sKodu,tbStok.sModel,tbStok.sBeden, tbStok.sAciklama AS sStokAciklama, ISNULL(tbStokFisiDetayi.lGirisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lBrutFiyat, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari, 0) AS Iskonto, tbStokFisiDetayi.lPrimTutari as Prim,tbStokFisiDetayi.lCikisTutar AS lNetTutar,tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbStok.sRenk,tbStokFisiDetayi.sDepo as sMagaza FROM tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE tbStokFisiDetayi.nGirisCikis= 1 and tbStokFisiDetayi.dteFisTarihi between '" & tarih1 & " ' and '" & tarih2 & "' " & kriter & "")
            'cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.CAST(nStokFisiID as CHAR(60)) as nAlisVerisID, tbFirma.nFirmaID as nMusteriID, tbFirma.sKodu AS lKodu, tbFirma.sAciklama as sMusteriAdi, tbStokFisiMaster.dteFisTarihi AS dteTarih, tbStokFisiMaster.sFisTipi AS fisTipi, tbStokFisiMaster.lFisNo AS lNo, tbStokFisiDetayi.nIslemID, tbStok.nStokID, tbStok.sKodu AS sKodu, tbStok.sModel, tbStok.sAciklama AS sStokAciklama, ISNULL(tbStokFisiDetayi.lGirisMiktar1, 0) AS Miktar, ISNULL(tbStokFisiDetayi.lBrutFiyat, 0) AS Fiyat, ISNULL(tbStokFisiDetayi.lIskontoTutari, 0) AS Iskonto, tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari AS lNetTutar, tbStokFisiDetayi.sOdemeKodu, tbStokFisiDetayi.sFiyatTipi, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sKasiyerRumuzu, tbStokFisiDetayi.nGirisCikis, tbStok.sRenk, tbStokFisiDetayi.sDepo as sMagaza, tbStok.sRenk, tbStok.sBeden FROM tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE tbStokFisiDetayi.nGirisCikis = 1 and tbStokFisiDetayi.dteFisTarihi between '" & tarih1 & "' and '" & tarih2 & "'" & kriter & " Order by tbStok.nStokID")
        End If
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
    Private Sub kontrol_oran(ByVal MaliyetTipi As Integer)
        Dim dr As DataRow
        Dim netmaliyet As Decimal = 0
        Dim normalfiyat As Decimal = 0
        Dim maliyet As Decimal = 0
        Dim fiyattipi As String = ""
        If MaliyetTipi = 1 Then
            colMALIYET.FieldName = "lMaliyetFiyat"
        Else
            colMALIYET.FieldName = "MALIYET"
        End If
        Dim lToplamKar As Decimal = 0
        Dim lToplamMaliyet As Decimal = 0
        Dim nYuzdelik As Decimal = 0
        Dim nStokID As Int64 = 0
        Progress.ShowProgress(DataSet1.Tables(0).Rows.Count(), Sorgu_sDil("Stoklar Kontrol Ediliyor...", sDil))
        Dim nIndex As Integer = 0
        For Each dr In DataSet1.Tables(0).Rows
            If dr("sKodu").ToString <> "" Then
                If MaliyetTipi = 0 Then
                    Try
                        netmaliyet = dr("MALIYET") * dr("Miktar")
                    Catch ex As Exception
                        netmaliyet = 0
                    End Try
                ElseIf MaliyetTipi = 1 Then
                    Try
                        If Trim(dr("fisTipi")) = "SK" Or Trim(dr("fisTipi")) = "SP" Then
                            netmaliyet = dr("MALIYET") * dr("Miktar")
                        Else
                            netmaliyet = dr("lMaliyetFiyat") * dr("Miktar")
                        End If
                    Catch ex As Exception
                        netmaliyet = 0
                    End Try
                ElseIf MaliyetTipi = 2 Then
                    tarih1 = dr("dteTarih")
                    ds_tbAlislar = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY SELECT TOP 1 tbStokFisiDetayi.nIslemID, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.nStokID, tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.lMaliyetFiyat, tbStokFisiDetayi.lMaliyetTutar, tbStokFisiDetayi.lIlaveMaliyetTutar, tbStokFisiMaster.lMalBedeli AS lMalBedeli, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.lMalIskontoTutari AS lMalIskontotuTutari, tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3 AS lDipIskontoTutari, tbStokFisiMaster.lEkmaliyet1, tbStokFisiMaster.lEkmaliyet2, tbStokFisiMaster.lEkmaliyet3, (SELECT ISNULL(SUM(lTutar), 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiMaster.nStokFisiID and nIslemID = 0) AS lEkMaliyet4, (SELECT ISNULL(SUM(lTutar), 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar, CAST(0 AS money) AS nEkOran, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani FROM tbStokFisiDetayi INNER JOIN tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStokFisiDetayi.nGirisCikis IN (1)) and tbStokFisiDetayi.lGirisMiktar1 > 0 AND (tbStokFisiDetayi.dteFisTarihi <= '" & tarih1 & "') AND tbStokFisiDetayi.nStokID = " & dr("nStokID") & " and tbStokFisiDetayi.sFisTipi <> 'T' ORDER BY tbStokFisiDetayi.nStokID, tbStokFisiDetayi.dteFisTarihi DESC"))
                    dr("MALIYET") = sorgu_sayi(maliyet_kontrol(), 0)
                    maliyet = dr("MALIYET")
                    Try
                        netmaliyet = dr("MALIYET") * dr("Miktar")
                    Catch ex As Exception
                        netmaliyet = 0
                    End Try
                ElseIf MaliyetTipi >= 3 AndAlso MaliyetTipi <= 8 Then
                    tarih1 = dr("dteTarih")
                    nStokID = dr("nStokID")
                    maliyet = MaliyetHesaplayici.HesaplaMaliyet(nStokID, tarih1, MaliyetTipi)
                    dr("MALIYET") = sorgu_sayi(maliyet, 0)
                    Try
                        netmaliyet = dr("MALIYET") * dr("Miktar")
                    Catch ex As Exception
                        netmaliyet = 0
                    End Try
                End If
                Try
                    dr("ORAN1") = ((dr("lNetTutar") - (netmaliyet)) / netmaliyet)
                    dr("KAR") = dr("lNetTutar") - (netmaliyet)
                Catch ex As Exception
                    dr("ORAN1") = 0
                    dr("KAR") = dr("lNetTutar") - (netmaliyet)
                End Try
                lToplamKar = lToplamKar + sorgu_sayi(dr("KAR"), 0)
                lToplamMaliyet = lToplamMaliyet + sorgu_sayi(netmaliyet, 0)
                If dr("nGirisCikis") <> 5 Then
                    If Trim(dr("sFiyatTipi").ToString) <> "HD" Then
                        fiyattipi = Trim(dr("sFiyatTipi").ToString).ToUpper()
                        'MessageBox.Show(fiyattipi.ToUpper())
                        If fiyattipi = Trim(sFiyat3).ToUpper() Then
                            If Math.Abs(dr("Fiyat")) <> sorgu_sayi(dr("ONAY"), 0) Then
                                dr("NORMALFIYAT") = sorgu_sayi(dr("ONAY"), 0)
                                dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                                normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                                dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR")
                                dr("FIYATFARKI") = dr("Fiyat") - normalfiyat
                            End If
                        ElseIf fiyattipi = Trim(sFiyat2).ToUpper() Then
                            If Math.Abs(dr("Fiyat")) <> sorgu_sayi(dr("ALTIAY"), 0) Then
                                dr("NORMALFIYAT") = sorgu_sayi(dr("ALTIAY"), 0)
                                dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                                normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                                dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR")
                                dr("FIYATFARKI") = dr("Fiyat") - normalfiyat
                            End If
                        ElseIf fiyattipi = Trim(sFiyat1).ToUpper() Then
                            If Math.Abs(dr("Fiyat")) <> sorgu_sayi(dr("PESIN"), 0) Then
                                dr("NORMALFIYAT") = sorgu_sayi(dr("PESIN"), 0)
                                dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                                normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                                dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR")
                                dr("FIYATFARKI") = dr("Fiyat") - normalfiyat
                            End If
                        ElseIf fiyattipi = Trim(sFiyat4).ToUpper() Then
                            If Math.Abs(dr("Fiyat")) <> sorgu_sayi(dr("ONBESAY"), 0) Then
                                dr("NORMALFIYAT") = sorgu_sayi(dr("ONBESAY"), 0)
                                dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                                normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                                dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR")
                                dr("FIYATFARKI") = dr("Fiyat") - normalfiyat
                            End If
                            'ElseIf fiyattipi = "15AY" Then
                            '    MessageBox.Show("15AY bu")
                            '    If Math.Abs(dr("Fiyat")) <> sorgu_sayi(dr("ONBESAY"), 0) Then
                            '        dr("NORMALFIYAT") = sorgu_sayi(dr("ONBESAY"), 0)
                            '        dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            '        normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                            '        dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR")
                            '        dr("FIYATFARKI") = dr("Fiyat") - normalfiyat
                            '        MessageBox.Show("normalfiyat: " + normalfiyat + "|FiyatFarký: " + dr("FIYATFARKI"))
                            '    End If
                        End If
                    Else
                        'fiyattipi = Trim(dr("sFiyatTipi").ToString)
                        If fiyattipi = Trim(sFiyat3).ToUpper() Then
                            dr("NORMALFIYAT") = sorgu_sayi(dr("ONAY"), 0)
                            dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                            dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR") + 0.01
                            dr("FIYATFARKI") = (dr("Fiyat") - normalfiyat) + +0.01
                        ElseIf fiyattipi = Trim(sFiyat2).ToUpper() Then
                            dr("NORMALFIYAT") = sorgu_sayi(dr("ALTIAY"), 0)
                            dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                            dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR") + 0.01
                            dr("FIYATFARKI") = (dr("Fiyat") - normalfiyat) + 0.01
                        ElseIf fiyattipi = Trim(sFiyat1).ToUpper() Then
                            dr("NORMALFIYAT") = sorgu_sayi(dr("PESIN"), 0)
                            dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                            dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR") + 0.01
                            dr("FIYATFARKI") = (dr("Fiyat") - normalfiyat) + 0.01
                        ElseIf fiyattipi = Trim(sFiyat4).ToUpper() Then
                            dr("NORMALFIYAT") = sorgu_sayi(dr("ONBESAY"), 0)
                            dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                            dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR") + 0.01
                            dr("FIYATFARKI") = (dr("Fiyat") - normalfiyat) + 0.01
                            'ElseIf fiyattipi = "15AY" Then
                            '    dr("NORMALFIYAT") = sorgu_sayi(dr("ONBESAY"), 0)
                            '    dr("NORMALTUTAR") = dr("NORMALFIYAT") * dr("Miktar")
                            '    normalfiyat = dr("NORMALFIYAT") * dr("Miktar") / Math.Abs(dr("Miktar"))
                            '    dr("FARK") = dr("lNetTutar") - dr("NORMALTUTAR") + 0.01
                            '    dr("FIYATFARKI") = (dr("Fiyat") - normalfiyat) + 0.01
                        End If
                    End If
                End If
            End If
            nIndex = nIndex + 1
            Progress.Progress(nIndex, Sorgu_sDil("StokKodu:", sDil) & dr("sKodu").ToString & vbTab & Sorgu_sDil("Adý:", sDil) & dr("sStokAciklama").ToString)
        Next
        Try
            nYuzdelik = (lToplamKar / lToplamMaliyet) * 100
        Catch ex As Exception
            nYuzdelik = 0
        End Try
        colORAN1.SummaryItem.DisplayFormat = "%" & FormatNumber(nYuzdelik, 2).ToString
        Grid2Oran.SummaryItem.DisplayFormat = "%" & FormatNumber(nYuzdelik, 2).ToString
        dr = Nothing
        Progress.HideProgress()
    End Sub
    Private Function maliyet_kontrol() As Decimal
        Dim maliyet As Decimal = 0
        Dim oranekmaliyet As Decimal = 0
        Dim dr3 As DataRow
        Dim lToplamMiktar As Decimal = 0
        Dim lToplamMaliyet As Decimal = 0
        Dim lToplamTutar As Decimal = 0

        ' Alis fiyati KDV dahil mi kontrolu
        Dim bAlisKdvDahil As Boolean = False
        Try
            Dim dtKdvKontrol As DataSet = sorgu(sorgu_query("SELECT ISNULL(bKdvDahilmi, 0) AS bKdvDahilmi FROM tbFiyatTipi WHERE RTRIM(sFiyatTipi) = '" & Trim(KeyCode.sFiyatA) & "'"))
            If dtKdvKontrol IsNot Nothing AndAlso dtKdvKontrol.Tables(0).Rows.Count > 0 Then
                Dim result = dtKdvKontrol.Tables(0).Rows(0)("bKdvDahilmi")
                If TypeOf result Is Boolean Then
                    bAlisKdvDahil = CBool(result)
                Else
                    bAlisKdvDahil = (Convert.ToInt32(result) <> 0)
                End If
            End If
        Catch
        End Try

        For Each dr3 In ds_tbAlislar.Tables(0).Rows
            maliyet = (dr3("lGirisTutar")) / dr3("lGirisMiktar1")
            If bAlisKdvDahil = False Then
                ' Alis fiyati KDV HARIC - KDV ekle
                If dr3("nKdvOrani") <> dr3("nStokKdvOrani") Then
                    If bKdvKontrolluMaliyet = True Then
                        maliyet = maliyet * ((dr3("nStokKdvOrani") + 100) / 100)
                    Else
                        maliyet = maliyet * ((dr3("nKdvOrani") + 100) / 100)
                    End If
                Else
                    maliyet = maliyet * ((dr3("nKdvOrani") + 100) / 100)
                End If
            End If
            ' bAlisKdvDahil = True ise KDV eklenmez, fiyat zaten KDV dahil
            maliyet = (maliyet) - (Math.Abs((dr3("lIlaveMaliyetTutar") + dr3("lEkIlaveMaliyetTutar")) / dr3("lGirisMiktar1")))
            Try
                If CType(dr3("lEkmaliyet1") + dr3("lEkMaliyet3") + dr3("lEkMaliyet4"), Decimal) <> 0 Then
                    oranekmaliyet = CType(dr3("lEkmaliyet1") + dr3("lEkmaliyet3") + dr3("lEkMaliyet4"), Decimal) / CType(dr3("lNetTutar") - (dr3("lEkmaliyet1")), Decimal)
                    maliyet = maliyet + (maliyet * (((oranekmaliyet * 100)) / 100))
                End If
            Catch ex As Exception
            End Try
            dr3("lMaliyetFiyat") = maliyet
            'dr3("lGirisTutar") = dr3("lGirisTutar") * ((dr3("nKdvOrani") + 100) / 100)
            lToplamMiktar += dr3("lGirisMiktar1")
            lToplamMaliyet += dr3("lGirisMiktar1") * dr3("lMaliyetFiyat")
            lToplamTutar += dr3("lGirisTutar") * ((dr3("nKdvOrani") + 100) / 100)
        Next
        Try
            lBasitMaliyet = lToplamMaliyet / lToplamMiktar
        Catch ex As Exception
            lBasitMaliyet = 0
        End Try
        Try
            lGirisMaliyet = lToplamTutar / lToplamMiktar
        Catch ex As Exception
            lGirisMaliyet = 0
        End Try
        Return maliyet
    End Function
    Private Function lMaliyet_hesapla(ByVal lMiktar As Decimal, ByVal tarih As DateTime) As Decimal
        Dim dr As DataRow
        Dim tutar As Decimal = 0
        Dim lSonMiktar As Decimal = 0
        Dim lIlkMiktar As Decimal = 0
        Dim lSonMaliyet As Decimal = 0
        Dim lOrjMiktar As Decimal = lMiktar
        'lMiktar = Math.Abs(lMiktar)
        lSonMiktar = lMiktar
        lIlkMiktar = lMiktar
        Dim nIslemID As Int64 = 0
        If lMiktar < 0 Then
            For Each dr In ds_tbAlislar.Tables(0).Rows
                If lMiktar < 0 And dr("dteFisTarihi") <= tarih Then
                    tutar = dr("lMaliyetFiyat") * lMiktar
                    nIslemID = dr("nIslemID")
                End If
            Next
        End If
        For Each dr In ds_tbAlislar.Tables(0).Rows
            If lMiktar < 0 And dr("dteFisTarihi") <= tarih And nIslemID = dr("nIslemID") Then
                dr("lGirisMiktar1") = dr("lGirisMiktar1") + Math.Abs(lMiktar)
            End If
            If dr("lGirisMiktar1") > 0 And lSonMiktar > 0 Then
                If lMiktar > dr("lGirisMiktar1") Then
                    'tutar += dr("lMaliyetFiyat") * (lMiktar - dr("lGirisMiktar1"))
                    lSonMaliyet = dr("lMaliyetFiyat")
                    tutar += dr("lMaliyetFiyat") * (dr("lGirisMiktar1"))
                    lMiktar -= dr("lGirisMiktar1")
                    dr("lGirisMiktar1") = 0
                ElseIf lSonMiktar = dr("lGirisMiktar1") Then
                    tutar += dr("lMaliyetFiyat") * dr("lGirisMiktar1")
                    lSonMaliyet = dr("lMaliyetFiyat")
                    'lMiktar = lMiktar - dr("lGirisMiktar1")
                    lMiktar = 0
                    dr("lGirisMiktar1") = 0
                ElseIf lSonMiktar < dr("lGirisMiktar1") Then
                    tutar += dr("lMaliyetFiyat") * (lMiktar)
                    lSonMaliyet = dr("lMaliyetFiyat")
                    dr("lGirisMiktar1") = dr("lGirisMiktar1") - lMiktar
                    lMiktar = 0
                End If
                lSonMiktar = lMiktar
            End If
        Next
        If lSonMiktar > 0 Then
            Try
                tutar = tutar / (lIlkMiktar - lMiktar)
                tutar = tutar * lIlkMiktar
            Catch ex As Exception
                tutar = lIlkMiktar * lSonMaliyet
            End Try
        End If
        Return tutar
    End Function
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub dataload(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal ara_stok As String, ByVal konum_stok As String, ByVal ara_kriter_stok As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal MaliyetTipi As Integer, ByVal satici As String, ByVal sMagaza As String)
        DataSet1 = stok(tarih1, tarih2, ara_stok, konum_stok, ara_kriter_stok, ara, konum, ara_kriter, MaliyetTipi, satici, sMagaza)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
        kontrol_oran(MaliyetTipi)

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
    Private Sub analiz_envanter()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            If urunBazli.Checked = True Then
                dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Else
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            End If
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
    Private Sub analiz_stok_hareket()
        Dim dr As DataRow
        If GridView1.RowCount > 0 Then
            If urunBazli.Checked = True Then
                dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Else
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            End If
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
    Private Sub analiz_stok_karti()
        Dim dr As DataRow
        If GridView1.RowCount > 0 Then
            If urunBazli.Checked = True Then
                dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Else
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            End If
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokId")
            frm.sKodu = dr("sKodu")
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            cmd.Connection = con
            con.ConnectionString = connection
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sModel FROM tbStok where nStokID = " & dr("nStokId") & "")
            frm.sModel = cmd.ExecuteScalar.ToString()
            con.Close()
            cmd = Nothing
            con = Nothing
            'frm.sModel = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub stok_fiyat()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            If urunBazli.Checked = True Then
                dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Else
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            End If
            Dim frm As New frm_stok_fiyatlandir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokId")
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            cmd.Connection = con
            con.ConnectionString = connection
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sModel FROM tbStok where nStokID = " & dr("nStokId") & "")
            frm.sModel = cmd.ExecuteScalar.ToString()
            frm.txt_musteriNo.Text = cmd.ExecuteScalar.ToString()
            'frm.sModel = dr("sModel")
            frm.sKodu = dr("sKodu")
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sRenk FROM tbStok where nStokID = " & dr("nStokId") & "")
            frm.sRenk = cmd.ExecuteScalar.ToString()
            'frm.sRenk = dr("sRenk")
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sBeden FROM tbStok where nStokID = " & dr("nStokId") & "")
            frm.sBeden = cmd.ExecuteScalar.ToString()
            'frm.sBeden = dr("sBeden")
            con.Close()
            cmd = Nothing
            con = Nothing
            'frm.txt_musteriNo.Text = dr("sModel")
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
            frm.nIslemID = dr("nIslemID")
            frm.bAnaliz = True
            If yetki_kontrol(kullanici, "frm_Stok_KarlilikAkisTablosu") = True Then
                frm.ShowDialog()
            End If
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
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
        'Dim dr As DataRow
        'dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'lbl_istihbarat.Text = dr("ISTIHBARAT")
        'dr = Nothing
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
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.Close()
        End If
        'Me.Close()
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
        loading()
    End Sub
    Sub loading()
        SimpleButton3.Enabled = False
        urunBazli.Enabled = False
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        DataSet2.Tables(0).Clear()
        GridControl2.Visible = False
        GridControl1.Visible = True
        urunBazli.Checked = False
        grid2V = False
        'Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        dataload(DateEdit1.EditValue, DateEdit2.EditValue, txt_ara_stok.EditValue, sec_konum_stok.EditValue, sec_kriter_stok.EditValue, txt_ara.Text, sec_konum.Text, sec_kriter.Text, sec_MaliyetTipi.SelectedIndex, sec_depo.Text, sec_smagaza.Text)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        SimpleButton3.Enabled = True
        urunBazli.Enabled = True
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Function deger(ByVal ds As DataSet) As String
        Dim dr As DataRow
        Dim s As String = ""
        Dim satir As String = ""
        Dim sayi As Integer = 0
        Dim sayi1 As Integer = 0
        For Each dr In ds.Tables(0).Rows
            If dr("SEC") = True Then
                sayi += 1
            End If
        Next
        For Each dr In ds.Tables(0).Rows
            If dr("SEC") = True Then
                sayi1 += 1
                s += "'" + Trim(dr("KOD")).ToString + "'"
                satir += Trim(dr("ACIKLAMA"))
                If sayi1 < sayi Then
                    s += ","
                    satir += ","
                End If
            End If
        Next
        sayi1 = Nothing
        sayi = Nothing
        Return s.ToString
    End Function
    Private Sub sec_depo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_depo.QueryPopUp
        sec_depo.Properties.PopupControl = sec_grid
        GridControl3.DataSource = ds_satici.Tables(0)
        GridControl3.DataMember = Nothing
    End Sub
    Private Sub sec_depo_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_depo.QueryResultValue
        Dim s As String = deger(ds_satici)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub sec_magaza_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_smagaza.QueryPopUp
        sec_depo.Properties.PopupControl = Nothing
        sec_smagaza.Properties.PopupControl = sec_grid
        GridControl3.DataSource = ds_magaza.Tables(0)
        GridControl3.DataMember = Nothing
    End Sub
    Private Sub sec_magaza_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_smagaza.QueryResultValue
        Dim s As String = deger(ds_magaza)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        analiz_envanter()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If islemstatus = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        If islemstatus = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        analiz_musteri_hareket_ekstre()
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        analiz_stok_karti()
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        stok_fiyat()
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        If urunBazli.Checked = True Then
            If MenuItem26.Checked = False Then
                GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
                GridView2.OptionsCustomization.AllowFilter = True
                GridView2.OptionsView.ShowAutoFilterRow = True
                MenuItem26.Checked = True
            ElseIf MenuItem26.Checked = True Then
                GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                GridView2.OptionsCustomization.AllowFilter = False
                GridView2.OptionsView.ShowAutoFilterRow = False
                MenuItem26.Checked = False
            End If
        Else
            If MenuItem26.Checked = False Then
                GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
                GridView1.OptionsCustomization.AllowFilter = True
                GridView1.OptionsView.ShowAutoFilterRow = True
                MenuItem26.Checked = True
            ElseIf MenuItem26.Checked = True Then
                GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                GridView1.OptionsCustomization.AllowFilter = False
                GridView1.OptionsView.ShowAutoFilterRow = False
                MenuItem26.Checked = False
            End If
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        analiz_stok_karti()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        stok_fiyat()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_musteri_karti()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_musteri_satislar()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        analiz_musteri_hareket_ekstre()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        analiz_acik_faturalar()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        raporla_pdf()
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        analiz_stok_KarlilikAkisTablosu()
    End Sub
    Private Sub sec_bZararinaSatislar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sec_bZararinaSatislar.CheckedChanged
        If urunBazli.Checked = True Then
            If sec_bZararinaSatislar.Checked = True Then
                GridView2.ClearColumnsFilter()
                GridView2.Columns("KAR").FilterInfo = New ColumnFilterInfo("[KAR] < 0 ")
            Else
                GridView2.ClearColumnsFilter()
            End If
        Else
            If sec_bZararinaSatislar.Checked = True Then
                GridView1.ClearColumnsFilter()
                GridView1.Columns("KAR").FilterInfo = New ColumnFilterInfo("[KAR] < 0 ")
            Else
                GridView1.ClearColumnsFilter()
            End If
        End If
    End Sub
    Private Sub urunBazli_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles urunBazli.CheckedChanged
        If urunBazli.Checked = False Then
            GridControl2.Visible = False
            GridControl1.Visible = True
            BarButtonItem5.Enabled = True
            BarButtonItem6.Enabled = True
            BarButtonItem7.Enabled = True
            BarButtonItem8.Enabled = True
            BarButtonItem9.Enabled = True
            MenuItem16.Enabled = True
            MenuItem17.Enabled = True
            MenuItem18.Enabled = True
            MenuItem19.Enabled = True
            MenuItem22.Enabled = True
            MenuItem27.Enabled = True
        Else
            SimpleButton3.Enabled = False
            urunBazli.Enabled = False
            Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
            Label2.Refresh()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            GridControl1.Visible = False
            GridControl2.Visible = True
            BarButtonItem5.Enabled = False
            BarButtonItem6.Enabled = False
            BarButtonItem7.Enabled = False
            BarButtonItem8.Enabled = False
            BarButtonItem9.Enabled = False
            MenuItem16.Enabled = False
            MenuItem17.Enabled = False
            MenuItem18.Enabled = False
            MenuItem19.Enabled = False
            MenuItem22.Enabled = False
            MenuItem27.Enabled = False
            If grid2V = False And GridView1.RowCount > 1 Then
                grid2V = True
                Dim dr As DataRow
                Dim i As Integer = 0
                Dim i1 As Integer = 0
                Dim i2 As Integer = 0
                Dim yIndex As Integer = 0
                Dim tnStokID As String = ""
                Dim tsKodu As String = ""
                Dim tsStokAciklama As String = ""
                Dim tMiktar As Decimal = 0
                Dim tFiyat As Decimal = 0
                Dim tIskonto As Decimal = 0
                Dim tlNetTutar As Decimal = 0
                Dim tORAN1 As Decimal = 0
                Dim tPESIN As Decimal = 0
                Dim tALTIAY As Decimal = 0
                Dim tONAY As Decimal = 0
                Dim tKAR As Decimal = 0
                Dim tFARK As Decimal = 0
                Dim tNORMALFIYAT As Decimal = 0
                Dim tNORMALTUTAR As Decimal = 0
                Dim tFIYATFARKI As Decimal = 0
                Dim tMALIYET As Decimal = 0
                Dim tONBESAY As Decimal = 0
                Dim tsKoduA(20000) As String
                Dim ypm As Boolean = False
                DataSet2.Tables(0).Clear()
                For Each dr In DataSet1.Tables(0).Rows
                    If Trim(dr("sKodu").ToString()) <> "" Then
                        If i >= 1 Then
                            ypm = False
                            For i1 = 0 To i
                                If tsKoduA(i1) = Trim(dr("sKodu").ToString()) Then
                                    ypm = True
                                End If
                            Next
                            If ypm = False Then
                                tsKoduA(i) = Trim(dr("sKodu").ToString())
                                i += 1
                            End If
                        Else
                            tsKoduA(i) = Trim(dr("sKodu").ToString())
                            i += 1
                        End If
                    End If
                Next
                For i1 = 0 To i
                    tnStokID = ""
                    tsKodu = ""
                    tsStokAciklama = ""
                    tMiktar = 0
                    tFiyat = 0
                    tIskonto = 0
                    tlNetTutar = 0
                    tORAN1 = 0
                    tPESIN = 0
                    tALTIAY = 0
                    tONAY = 0
                    tKAR = 0
                    tFARK = 0
                    tNORMALFIYAT = 0
                    tNORMALTUTAR = 0
                    tFIYATFARKI = 0
                    tMALIYET = 0
                    tONBESAY = 0
                    For Each dr In DataSet1.Tables(0).Rows
                        If Trim(dr("sKodu").ToString()) <> "" Then
                            If tsKoduA(i1) = Trim(dr("sKodu").ToString()) Then
                                tnStokID = Trim(dr("nStokID").ToString())
                                tsKodu = Trim(dr("sKodu").ToString())
                                tsStokAciklama = Trim(dr("sStokAciklama").ToString())
                                tMiktar += Decimal.Parse(dr("Miktar").ToString())
                                If Decimal.Parse(dr("Miktar").ToString()) > 0 Then
                                    tFiyat += Decimal.Parse(dr("Fiyat").ToString())
                                    tMALIYET += Decimal.Parse(dr("MALIYET").ToString())
                                Else
                                    tFiyat += (Decimal.Parse(dr("Fiyat").ToString()) * -1)
                                    tMALIYET += (Decimal.Parse(dr("MALIYET").ToString()) * -1)
                                End If
                                tIskonto += Decimal.Parse(dr("Iskonto").ToString())
                                tlNetTutar += Decimal.Parse(dr("lNetTutar").ToString())
                                tPESIN += Decimal.Parse(dr("PESIN").ToString())
                                tALTIAY += Decimal.Parse(dr("ALTIAY").ToString())
                                tONAY += Decimal.Parse(dr("ONAY").ToString())
                                tFARK += Decimal.Parse(dr("FARK").ToString())
                                tNORMALFIYAT += Decimal.Parse(dr("NORMALFIYAT").ToString())
                                tNORMALTUTAR += Decimal.Parse(dr("NORMALTUTAR").ToString())
                                tFIYATFARKI += Decimal.Parse(dr("FIYATFARKI").ToString())
                                tONBESAY += Decimal.Parse(dr("ONBESAY").ToString())
                                'tKAR += dr("lNetTutar") - (dr("MALIYET") * dr("Miktar"))
                            End If
                        End If
                    Next
                    tKAR = tlNetTutar - tMALIYET
                    Try
                        'tORAN1 += (dr("lNetTutar") - (dr("MALIYET") * dr("Miktar"))) / (dr("MALIYET") * dr("Miktar"))
                        tORAN1 = tKAR / tMALIYET
                    Catch ex As Exception
                        tORAN1 = 0
                    End Try
                    GridView2.AddNewRow()
                    yIndex = GridView2.FocusedRowHandle
                    GridView2.SetRowCellValue(yIndex, "nStokID", tnStokID)
                    GridView2.SetRowCellValue(yIndex, "sKodu", tsKodu)
                    GridView2.SetRowCellValue(yIndex, "sStokAciklama", tsStokAciklama)
                    GridView2.SetRowCellValue(yIndex, "Miktar", tMiktar)
                    GridView2.SetRowCellValue(yIndex, "Fiyat", tFiyat)
                    GridView2.SetRowCellValue(yIndex, "Iskonto", tIskonto)
                    GridView2.SetRowCellValue(yIndex, "lNetTutar", tlNetTutar)
                    GridView2.SetRowCellValue(yIndex, "ORAN1", tORAN1)
                    GridView2.SetRowCellValue(yIndex, "PESIN", tPESIN)
                    GridView2.SetRowCellValue(yIndex, "ALTIAY", tALTIAY)
                    GridView2.SetRowCellValue(yIndex, "ONAY", tONAY)
                    GridView2.SetRowCellValue(yIndex, "KAR", tKAR)
                    GridView2.SetRowCellValue(yIndex, "FARK", tFARK)
                    GridView2.SetRowCellValue(yIndex, "NORMALFIYAT", tNORMALFIYAT)
                    GridView2.SetRowCellValue(yIndex, "NORMALTUTAR", tNORMALTUTAR)
                    GridView2.SetRowCellValue(yIndex, "FIYATFARKI", tFIYATFARKI)
                    GridView2.SetRowCellValue(yIndex, "MALIYET", tMALIYET)
                    GridView2.SetRowCellValue(yIndex, "ONBESAY", tONBESAY)
                    GridView2.UpdateCurrentRow()
                    GridView2.RefreshData()
                Next
            End If
            Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
            SimpleButton3.Enabled = True
            urunBazli.Enabled = True
            Cursor.Current = Cursors.Default
            Cursor.Hide()
            GridView2.FocusedRowHandle = 0
        End If
    End Sub
    Private Sub sec_MaliyetTipi_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles sec_MaliyetTipi.SelectedIndexChanged
        If sec_MaliyetTipi.SelectedIndex <> 0 Then
            urunBazli.Enabled = False
        Else
            urunBazli.Enabled = True
        End If
    End Sub

 
End Class
