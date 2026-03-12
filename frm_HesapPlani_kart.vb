Imports DevExpress.XtraEditors
Public Class frm_HesapPlani_kart
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
    Friend WithEvents LabelControl92 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_musteriNo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ds_tbFirma As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents ds_tbFirmaYetkilisi As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents DataColumn25 As System.Data.DataColumn
    Friend WithEvents DataColumn26 As System.Data.DataColumn
    Friend WithEvents ds_tbFirmaIletisimi As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn27 As System.Data.DataColumn
    Friend WithEvents DataColumn28 As System.Data.DataColumn
    Friend WithEvents DataColumn29 As System.Data.DataColumn
    Friend WithEvents DataColumn30 As System.Data.DataColumn
    Friend WithEvents ds_tbFirmaAyYekunleri As System.Data.DataSet
    Friend WithEvents DataTable4 As System.Data.DataTable
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sAdi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnMusteriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sSinifKodu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbSatisYapilamaz As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnYetkiliID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnFirmaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsUnvan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsHitap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAdiSoyadi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnIletisimID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnFirmaID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIletisimAraci As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsIletisimAdresi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnAy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnYil As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnSayi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBorc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collAlacak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txt_sAlternatifAciklama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_sHitap1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_sUnvan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ds_tbFirmaSinifi As System.Data.DataSet
    Friend WithEvents DataTable5 As System.Data.DataTable
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ds_tbFirmaBakiyesi As System.Data.DataSet
    Friend WithEvents DataTable6 As System.Data.DataTable
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents collNetBakiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kisayol_yetkili As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents kisayol_iletisim As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents kisayol_aylik As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents kisayol_ana As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FirmaHareketleriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FirmaBakiyeleriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HareketGirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AçýklamaGirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_sKodu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EkleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SonKodToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StokluEkstreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sec_siniflar As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txt_sIl As DevExpress.XtraEditors.LookUpEdit
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
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pnl_yetkililer As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnl_yetkili_status As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_yetkili_yazdir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_yetkili_sil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_yetkili_ekle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnl_iletisim As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnl_iletisim_status As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_iletisim_yazdir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_iletisim_sil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_iletisim_ekle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents sec_IletisimAraci As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents sec_bMiktarVar As DevExpress.XtraEditors.CheckEdit
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
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sAktifPasif As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txt_sNot As DevExpress.XtraEditors.MemoEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_HesapPlani_kart))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem1 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem5 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem6 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip6 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem7 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem6 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip7 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem8 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem7 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip8 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem9 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem8 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip9 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem10 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem9 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem2 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem11 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip10 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem12 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem10 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipTitleItem13 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl92 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_musteriNo = New DevExpress.XtraEditors.ButtonEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.kisayol_ana = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FirmaHareketleriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FirmaBakiyeleriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HareketGirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AçýklamaGirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SonKodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StokluEkstreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_sAktifPasif = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ds_tbFirma = New System.Data.DataSet()
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
        Me.sec_bMiktarVar = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_sIl = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_sKodu = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sAlternatifAciklama = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sAdi = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ds_tbFirmaSinifi = New System.Data.DataSet()
        Me.DataTable5 = New System.Data.DataTable()
        Me.DataColumn37 = New System.Data.DataColumn()
        Me.DataColumn38 = New System.Data.DataColumn()
        Me.DataColumn39 = New System.Data.DataColumn()
        Me.DataColumn40 = New System.Data.DataColumn()
        Me.DataColumn41 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnMusteriID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSinifTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSinifKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_siniflar = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbSatisYapilamaz = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSinifKodu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.pnl_yetkililer = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_yetkili = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.ds_tbFirmaYetkilisi = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        Me.DataColumn25 = New System.Data.DataColumn()
        Me.DataColumn26 = New System.Data.DataColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnYetkiliID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnFirmaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsUnvan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sUnvan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colsHitap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sHitap1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colsAdiSoyadi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pnl_yetkili_status = New DevExpress.XtraEditors.PanelControl()
        Me.btn_yetkili_yazdir = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_yetkili_sil = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_yetkili_ekle = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.pnl_iletisim = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_iletisim = New System.Windows.Forms.ContextMenu()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.ds_tbFirmaIletisimi = New System.Data.DataSet()
        Me.DataTable3 = New System.Data.DataTable()
        Me.DataColumn27 = New System.Data.DataColumn()
        Me.DataColumn28 = New System.Data.DataColumn()
        Me.DataColumn29 = New System.Data.DataColumn()
        Me.DataColumn30 = New System.Data.DataColumn()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnIletisimID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnFirmaID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsIletisimAraci = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_IletisimAraci = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colsIletisimAdresi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pnl_iletisim_status = New DevExpress.XtraEditors.PanelControl()
        Me.btn_iletisim_yazdir = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_iletisim_sil = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_iletisim_ekle = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_aylik = New System.Windows.Forms.ContextMenu()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.ds_tbFirmaAyYekunleri = New System.Data.DataSet()
        Me.DataTable4 = New System.Data.DataTable()
        Me.DataColumn31 = New System.Data.DataColumn()
        Me.DataColumn32 = New System.Data.DataColumn()
        Me.DataColumn33 = New System.Data.DataColumn()
        Me.DataColumn34 = New System.Data.DataColumn()
        Me.DataColumn35 = New System.Data.DataColumn()
        Me.DataColumn36 = New System.Data.DataColumn()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnAy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnYil = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnSayi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBorc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collAlacak = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBakiye = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collNetBakiye = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
        Me.txt_sNot = New DevExpress.XtraEditors.MemoEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.ds_tbFirmaBakiyesi = New System.Data.DataSet()
        Me.DataTable6 = New System.Data.DataTable()
        Me.DataColumn42 = New System.Data.DataColumn()
        Me.DataColumn43 = New System.Data.DataColumn()
        Me.DataColumn44 = New System.Data.DataColumn()
        Me.DataColumn45 = New System.Data.DataColumn()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
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
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.kisayol_ana.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_sAktifPasif.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbFirma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bMiktarVar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sIl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sKodu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAlternatifAciklama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAdi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbFirmaSinifi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_siniflar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinifKodu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.pnl_yetkililer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_yetkililer.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbFirmaYetkilisi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sUnvan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sHitap1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_yetkili_status, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_yetkili_status.SuspendLayout()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.pnl_iletisim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_iletisim.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbFirmaIletisimi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_IletisimAraci, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl_iletisim_status, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_iletisim_status.SuspendLayout()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbFirmaAyYekunleri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage6.SuspendLayout()
        CType(Me.txt_sNot.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbFirmaBakiyesi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(96, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Hesap Kartý Tanýmlarý Aþaðýdadýr..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(94, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl92)
        Me.PanelControl2.Controls.Add(Me.txt_musteriNo)
        Me.PanelControl2.Controls.Add(Me.SimpleButton2)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 359)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(824, 48)
        Me.PanelControl2.TabIndex = 1
        '
        'LabelControl92
        '
        Me.LabelControl92.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl92.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl92.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl92.Location = New System.Drawing.Point(11, 13)
        Me.LabelControl92.Name = "LabelControl92"
        Me.LabelControl92.Size = New System.Drawing.Size(54, 20)
        Me.LabelControl92.TabIndex = 61
        Me.LabelControl92.Text = "HesapKodu:"
        '
        'txt_musteriNo
        '
        Me.txt_musteriNo.Location = New System.Drawing.Point(83, 13)
        Me.txt_musteriNo.Name = "txt_musteriNo"
        Me.txt_musteriNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_musteriNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_musteriNo.Properties.Appearance.Options.UseBackColor = True
        Me.txt_musteriNo.Properties.Appearance.Options.UseForeColor = True
        Me.txt_musteriNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_musteriNo.Size = New System.Drawing.Size(100, 20)
        Me.txt_musteriNo.TabIndex = 59
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = Global.business_smart.My.Resources.Resources.button_cancel
        Me.SimpleButton2.Location = New System.Drawing.Point(733, 13)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton2.TabIndex = 58
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = Global.business_smart.My.Resources.Resources.button_ok
        Me.SimpleButton1.Location = New System.Drawing.Point(658, 13)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 24)
        Me.SimpleButton1.TabIndex = 57
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Controls.Add(Me.PanelControl4)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 56)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(824, 303)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.XtraTabControl1.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.Navy
        Me.XtraTabControl1.AppearancePage.HeaderActive.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.HeaderActive.Options.UseForeColor = True
        Me.XtraTabControl1.ContextMenuStrip = Me.kisayol_ana
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(817, 249)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5, Me.XtraTabPage6})
        '
        'kisayol_ana
        '
        Me.kisayol_ana.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EkleToolStripMenuItem, Me.SilToolStripMenuItem, Me.AraToolStripMenuItem, Me.ToolStripSeparator2, Me.FirmaHareketleriToolStripMenuItem, Me.FirmaBakiyeleriToolStripMenuItem, Me.ToolStripSeparator1, Me.HareketGirToolStripMenuItem, Me.AçýklamaGirToolStripMenuItem, Me.SonKodToolStripMenuItem, Me.StokluEkstreToolStripMenuItem})
        Me.kisayol_ana.Name = "kisayol_ana"
        Me.kisayol_ana.Size = New System.Drawing.Size(184, 214)
        '
        'EkleToolStripMenuItem
        '
        Me.EkleToolStripMenuItem.Name = "EkleToolStripMenuItem"
        Me.EkleToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Insert
        Me.EkleToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.EkleToolStripMenuItem.Text = "Ekle"
        '
        'SilToolStripMenuItem
        '
        Me.SilToolStripMenuItem.Name = "SilToolStripMenuItem"
        Me.SilToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.SilToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.SilToolStripMenuItem.Text = "Sil"
        '
        'AraToolStripMenuItem
        '
        Me.AraToolStripMenuItem.Name = "AraToolStripMenuItem"
        Me.AraToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.AraToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.AraToolStripMenuItem.Text = "Ara"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(180, 6)
        '
        'FirmaHareketleriToolStripMenuItem
        '
        Me.FirmaHareketleriToolStripMenuItem.Name = "FirmaHareketleriToolStripMenuItem"
        Me.FirmaHareketleriToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.FirmaHareketleriToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.FirmaHareketleriToolStripMenuItem.Text = "Firma Hareketleri"
        '
        'FirmaBakiyeleriToolStripMenuItem
        '
        Me.FirmaBakiyeleriToolStripMenuItem.Name = "FirmaBakiyeleriToolStripMenuItem"
        Me.FirmaBakiyeleriToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.FirmaBakiyeleriToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.FirmaBakiyeleriToolStripMenuItem.Text = "Firma Bakiyeleri"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(180, 6)
        '
        'HareketGirToolStripMenuItem
        '
        Me.HareketGirToolStripMenuItem.Name = "HareketGirToolStripMenuItem"
        Me.HareketGirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F7), System.Windows.Forms.Keys)
        Me.HareketGirToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.HareketGirToolStripMenuItem.Text = "Hareket Gir"
        '
        'AçýklamaGirToolStripMenuItem
        '
        Me.AçýklamaGirToolStripMenuItem.Name = "AçýklamaGirToolStripMenuItem"
        Me.AçýklamaGirToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.AçýklamaGirToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.AçýklamaGirToolStripMenuItem.Text = "Açýklama Gir"
        '
        'SonKodToolStripMenuItem
        '
        Me.SonKodToolStripMenuItem.Name = "SonKodToolStripMenuItem"
        Me.SonKodToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.SonKodToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.SonKodToolStripMenuItem.Text = "Son Kod"
        '
        'StokluEkstreToolStripMenuItem
        '
        Me.StokluEkstreToolStripMenuItem.Name = "StokluEkstreToolStripMenuItem"
        Me.StokluEkstreToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.StokluEkstreToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.StokluEkstreToolStripMenuItem.Text = "Stoklu Ekstre"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GroupControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(815, 216)
        Me.XtraTabPage1.Text = "Genel"
        Me.XtraTabPage1.Tooltip = "Genel Bilgiler Bu Bölümden Takip Edilir"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.sec_sAktifPasif)
        Me.GroupControl1.Controls.Add(Me.sec_bMiktarVar)
        Me.GroupControl1.Controls.Add(Me.txt_sIl)
        Me.GroupControl1.Controls.Add(Me.txt_sKodu)
        Me.GroupControl1.Controls.Add(Me.LabelControl19)
        Me.GroupControl1.Controls.Add(Me.LabelControl25)
        Me.GroupControl1.Controls.Add(Me.txt_sAlternatifAciklama)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txt_sAdi)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 7)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(797, 204)
        Me.GroupControl1.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(4, 109)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl2.TabIndex = 88
        Me.LabelControl2.Text = "Aktif/Pasif:"
        '
        'sec_sAktifPasif
        '
        Me.sec_sAktifPasif.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ds_tbFirma, "Table1.sAktifPasif", True))
        Me.sec_sAktifPasif.EditValue = "Aktif"
        Me.sec_sAktifPasif.EnterMoveNextControl = True
        Me.sec_sAktifPasif.Location = New System.Drawing.Point(72, 109)
        Me.sec_sAktifPasif.Name = "sec_sAktifPasif"
        Me.sec_sAktifPasif.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sAktifPasif.Properties.Appearance.Options.UseBackColor = True
        Me.sec_sAktifPasif.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sAktifPasif.Properties.Items.AddRange(New Object() {"Aktif", "Pasif"})
        Me.sec_sAktifPasif.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_sAktifPasif.Size = New System.Drawing.Size(103, 20)
        Me.sec_sAktifPasif.TabIndex = 4
        '
        'ds_tbFirma
        '
        Me.ds_tbFirma.DataSetName = "NewDataSet"
        Me.ds_tbFirma.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbFirma.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "nHesapID"
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
        Me.DataColumn4.ColumnName = "sAlterneAciklama"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "lBilancoSatiri"
        Me.DataColumn5.DataType = GetType(Decimal)
        '
        'DataColumn6
        '
        Me.DataColumn6.ColumnName = "sAktifPasif"
        '
        'DataColumn7
        '
        Me.DataColumn7.ColumnName = "lKarZararSatiri"
        Me.DataColumn7.DataType = GetType(Decimal)
        '
        'DataColumn8
        '
        Me.DataColumn8.ColumnName = "sKarZararGelirGider"
        '
        'DataColumn9
        '
        Me.DataColumn9.ColumnName = "sMasrafYontemi"
        '
        'DataColumn10
        '
        Me.DataColumn10.ColumnName = "bMiktarVar"
        Me.DataColumn10.DataType = GetType(Byte)
        '
        'DataColumn11
        '
        Me.DataColumn11.ColumnName = "sKullaniciAdi"
        '
        'DataColumn12
        '
        Me.DataColumn12.ColumnName = "dteKayitTarihi"
        Me.DataColumn12.DataType = GetType(Date)
        '
        'sec_bMiktarVar
        '
        Me.sec_bMiktarVar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.bMiktarVar", True))
        Me.sec_bMiktarVar.EditValue = True
        Me.sec_bMiktarVar.Location = New System.Drawing.Point(70, 131)
        Me.sec_bMiktarVar.Name = "sec_bMiktarVar"
        Me.sec_bMiktarVar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_bMiktarVar.Properties.Appearance.Options.UseFont = True
        Me.sec_bMiktarVar.Properties.Caption = "Miktar Var"
        Me.sec_bMiktarVar.Size = New System.Drawing.Size(105, 19)
        Me.sec_bMiktarVar.TabIndex = 5
        '
        'txt_sIl
        '
        Me.txt_sIl.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sMasrafYontemi", True))
        Me.txt_sIl.EnterMoveNextControl = True
        Me.txt_sIl.Location = New System.Drawing.Point(72, 87)
        Me.txt_sIl.Name = "txt_sIl"
        Me.txt_sIl.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_sIl.Properties.Appearance.Options.UseBackColor = True
        Me.txt_sIl.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIl.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sIl.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sIl.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sIl.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sIl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sIl.Properties.DisplayMember = "sIl"
        Me.txt_sIl.Properties.NullText = "[MasrafMerkezi]"
        Me.txt_sIl.Properties.ValueMember = "sIl"
        Me.txt_sIl.Size = New System.Drawing.Size(103, 20)
        Me.txt_sIl.TabIndex = 3
        '
        'txt_sKodu
        '
        Me.txt_sKodu.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sKodu", True))
        Me.txt_sKodu.Enabled = False
        Me.txt_sKodu.EnterMoveNextControl = True
        Me.txt_sKodu.Location = New System.Drawing.Point(72, 21)
        Me.txt_sKodu.Name = "txt_sKodu"
        Me.txt_sKodu.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKodu.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKodu.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKodu.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKodu.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKodu.Properties.MaxLength = 20
        Me.txt_sKodu.Size = New System.Drawing.Size(103, 20)
        ToolTipTitleItem1.Text = "Hesap Kodlarý Açýlýmý"
        ToolTipItem1.LeftIndent = 6
        ToolTipTitleItem2.LeftIndent = 6
        ToolTipTitleItem2.Text = "Muhasebe Yönetimi"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        SuperToolTip1.Items.Add(ToolTipSeparatorItem1)
        SuperToolTip1.Items.Add(ToolTipTitleItem2)
        Me.txt_sKodu.SuperTip = SuperToolTip1
        Me.txt_sKodu.TabIndex = 0
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl19.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl19.Location = New System.Drawing.Point(4, 21)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl19.TabIndex = 85
        Me.LabelControl19.Text = "Kodu:"
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl25.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl25.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl25.Location = New System.Drawing.Point(4, 87)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(60, 11)
        Me.LabelControl25.TabIndex = 54
        Me.LabelControl25.Text = "MasrafMerkezi"
        '
        'txt_sAlternatifAciklama
        '
        Me.txt_sAlternatifAciklama.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sAlterneAciklama", True))
        Me.txt_sAlternatifAciklama.EnterMoveNextControl = True
        Me.txt_sAlternatifAciklama.Location = New System.Drawing.Point(72, 65)
        Me.txt_sAlternatifAciklama.Name = "txt_sAlternatifAciklama"
        Me.txt_sAlternatifAciklama.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAlternatifAciklama.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAlternatifAciklama.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAlternatifAciklama.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAlternatifAciklama.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAlternatifAciklama.Properties.MaxLength = 60
        Me.txt_sAlternatifAciklama.Size = New System.Drawing.Size(317, 20)
        Me.txt_sAlternatifAciklama.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(5, 65)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl1.TabIndex = 46
        Me.LabelControl1.Text = "AlternatifAd:"
        '
        'txt_sAdi
        '
        Me.txt_sAdi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirma, "Table1.sAciklama", True))
        Me.txt_sAdi.EnterMoveNextControl = True
        Me.txt_sAdi.Location = New System.Drawing.Point(72, 43)
        Me.txt_sAdi.Name = "txt_sAdi"
        Me.txt_sAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAdi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAdi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAdi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAdi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAdi.Properties.MaxLength = 60
        Me.txt_sAdi.Size = New System.Drawing.Size(317, 20)
        Me.txt_sAdi.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(5, 43)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl3.TabIndex = 44
        Me.LabelControl3.Text = "Adý:"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridControl1)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(815, 216)
        Me.XtraTabPage2.Text = "Sýnýflandýrma"
        Me.XtraTabPage2.Tooltip = "Hesaplarý Sýnýflandýrma Ýþlemi Buradan Yapýlýr"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.ds_tbFirmaSinifi
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sSinifKodu, Me.sec_siniflar})
        Me.GridControl1.Size = New System.Drawing.Size(815, 216)
        Me.GridControl1.TabIndex = 3
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ds_tbFirmaSinifi
        '
        Me.ds_tbFirmaSinifi.DataSetName = "NewDataSet"
        Me.ds_tbFirmaSinifi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbFirmaSinifi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable5})
        '
        'DataTable5
        '
        Me.DataTable5.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn37, Me.DataColumn38, Me.DataColumn39, Me.DataColumn40, Me.DataColumn41})
        Me.DataTable5.TableName = "Table1"
        '
        'DataColumn37
        '
        Me.DataColumn37.ColumnName = "nFirmaID"
        Me.DataColumn37.DataType = GetType(Long)
        '
        'DataColumn38
        '
        Me.DataColumn38.ColumnName = "sSinifTipi"
        '
        'DataColumn39
        '
        Me.DataColumn39.ColumnName = "sSinifKodu"
        '
        'DataColumn40
        '
        Me.DataColumn40.ColumnName = "sAciklama"
        '
        'DataColumn41
        '
        Me.DataColumn41.ColumnName = "bSatisYapilamaz"
        Me.DataColumn41.DataType = GetType(Boolean)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnMusteriID, Me.colsSinifTipi, Me.colsSinifKodu, Me.colsAciklama, Me.colbSatisYapilamaz})
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView1.IndicatorWidth = 12
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colnMusteriID
        '
        Me.colnMusteriID.Caption = "Müþteri ID"
        Me.colnMusteriID.FieldName = "nMusteriID"
        Me.colnMusteriID.Name = "colnMusteriID"
        Me.colnMusteriID.OptionsColumn.AllowEdit = False
        Me.colnMusteriID.OptionsColumn.AllowFocus = False
        '
        'colsSinifTipi
        '
        Me.colsSinifTipi.AppearanceCell.BackColor = System.Drawing.Color.Silver
        Me.colsSinifTipi.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.colsSinifTipi.AppearanceCell.Options.UseBackColor = True
        Me.colsSinifTipi.AppearanceCell.Options.UseFont = True
        Me.colsSinifTipi.Caption = "Sýnýf Tipi"
        Me.colsSinifTipi.FieldName = "sSinifTipi"
        Me.colsSinifTipi.Name = "colsSinifTipi"
        Me.colsSinifTipi.OptionsColumn.AllowEdit = False
        Me.colsSinifTipi.OptionsColumn.AllowFocus = False
        Me.colsSinifTipi.Visible = True
        Me.colsSinifTipi.VisibleIndex = 0
        '
        'colsSinifKodu
        '
        Me.colsSinifKodu.Caption = "Sýnýfý"
        Me.colsSinifKodu.ColumnEdit = Me.sec_siniflar
        Me.colsSinifKodu.FieldName = "sSinifKodu"
        Me.colsSinifKodu.Name = "colsSinifKodu"
        Me.colsSinifKodu.Visible = True
        Me.colsSinifKodu.VisibleIndex = 1
        '
        'sec_siniflar
        '
        Me.sec_siniflar.AutoHeight = False
        Me.sec_siniflar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_siniflar.DisplayMember = "sSinifKodu"
        Me.sec_siniflar.Name = "sec_siniflar"
        Me.sec_siniflar.ValueMember = "sSinifKodu"
        Me.sec_siniflar.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsPrint.EnableAppearanceEvenRow = True
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colsAciklama
        '
        Me.colsAciklama.AppearanceCell.BackColor = System.Drawing.Color.Silver
        Me.colsAciklama.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.colsAciklama.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colsAciklama.AppearanceCell.Options.UseBackColor = True
        Me.colsAciklama.AppearanceCell.Options.UseFont = True
        Me.colsAciklama.AppearanceCell.Options.UseForeColor = True
        Me.colsAciklama.Caption = "Açýklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.OptionsColumn.AllowEdit = False
        Me.colsAciklama.OptionsColumn.AllowFocus = False
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 2
        '
        'colbSatisYapilamaz
        '
        Me.colbSatisYapilamaz.Caption = "Satýþ Yapýlamaz"
        Me.colbSatisYapilamaz.FieldName = "bSatisYapilamaz"
        Me.colbSatisYapilamaz.Name = "colbSatisYapilamaz"
        Me.colbSatisYapilamaz.OptionsColumn.AllowEdit = False
        Me.colbSatisYapilamaz.OptionsColumn.AllowFocus = False
        '
        'sec_sSinifKodu
        '
        Me.sec_sSinifKodu.AutoHeight = False
        Me.sec_sSinifKodu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sSinifKodu.DisplayMember = "sSinifKodu"
        Me.sec_sSinifKodu.Name = "sec_sSinifKodu"
        Me.sec_sSinifKodu.NullText = "[Sýnýflar]"
        Me.sec_sSinifKodu.ValueMember = "sSinifKodu"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.pnl_yetkililer)
        Me.XtraTabPage3.Controls.Add(Me.pnl_yetkili_status)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.PageVisible = False
        Me.XtraTabPage3.Size = New System.Drawing.Size(815, 216)
        Me.XtraTabPage3.Text = "Yetkililer"
        Me.XtraTabPage3.Tooltip = "Hesap Kartý Yetkilileri Buradan Tanýmlanýr"
        '
        'pnl_yetkililer
        '
        Me.pnl_yetkililer.Controls.Add(Me.GridControl2)
        Me.pnl_yetkililer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_yetkililer.Location = New System.Drawing.Point(0, 0)
        Me.pnl_yetkililer.Name = "pnl_yetkililer"
        Me.pnl_yetkililer.Size = New System.Drawing.Size(815, 181)
        Me.pnl_yetkililer.TabIndex = 2
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenu = Me.kisayol_yetkili
        Me.GridControl2.DataMember = "Table1"
        Me.GridControl2.DataSource = Me.ds_tbFirmaYetkilisi
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 2)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sHitap1, Me.sec_sUnvan})
        Me.GridControl2.Size = New System.Drawing.Size(811, 177)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'kisayol_yetkili
        '
        Me.kisayol_yetkili.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem1.Text = "Ekle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem2.Text = "Düzelt"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem3.Text = "Sil"
        '
        'ds_tbFirmaYetkilisi
        '
        Me.ds_tbFirmaYetkilisi.DataSetName = "NewDataSet"
        Me.ds_tbFirmaYetkilisi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbFirmaYetkilisi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn22
        '
        Me.DataColumn22.ColumnName = "nYetkiliID"
        '
        'DataColumn23
        '
        Me.DataColumn23.ColumnName = "nFirmaID"
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "sUnvan"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "sHitap"
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "sAdiSoyadi"
        '
        'GridView2
        '
        Me.GridView2.Appearance.Empty.Options.UseBackColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnYetkiliID, Me.colnFirmaID, Me.colsUnvan, Me.colsHitap, Me.colsAdiSoyadi})
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView2.IndicatorWidth = 12
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colnYetkiliID
        '
        Me.colnYetkiliID.Caption = "Yetkili ID"
        Me.colnYetkiliID.FieldName = "nYetkiliID"
        Me.colnYetkiliID.Name = "colnYetkiliID"
        '
        'colnFirmaID
        '
        Me.colnFirmaID.Caption = "Firma ID"
        Me.colnFirmaID.FieldName = "nFirmaID"
        Me.colnFirmaID.Name = "colnFirmaID"
        '
        'colsUnvan
        '
        Me.colsUnvan.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlDark
        Me.colsUnvan.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.colsUnvan.AppearanceCell.Options.UseBackColor = True
        Me.colsUnvan.AppearanceCell.Options.UseFont = True
        Me.colsUnvan.Caption = "Ünvan"
        Me.colsUnvan.ColumnEdit = Me.sec_sUnvan
        Me.colsUnvan.FieldName = "sUnvan"
        Me.colsUnvan.Name = "colsUnvan"
        Me.colsUnvan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sUnvan", "{0} Kayýt")})
        Me.colsUnvan.Visible = True
        Me.colsUnvan.VisibleIndex = 0
        '
        'sec_sUnvan
        '
        Me.sec_sUnvan.AutoHeight = False
        Me.sec_sUnvan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sUnvan.DisplayMember = "sUnvan"
        Me.sec_sUnvan.Name = "sec_sUnvan"
        Me.sec_sUnvan.NullText = "[Unvan]"
        Me.sec_sUnvan.ValueMember = "sUnvan"
        '
        'colsHitap
        '
        Me.colsHitap.Caption = "Hitap"
        Me.colsHitap.ColumnEdit = Me.sec_sHitap1
        Me.colsHitap.FieldName = "sHitap"
        Me.colsHitap.Name = "colsHitap"
        Me.colsHitap.Visible = True
        Me.colsHitap.VisibleIndex = 1
        '
        'sec_sHitap1
        '
        Me.sec_sHitap1.AutoHeight = False
        Me.sec_sHitap1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sHitap1.DisplayMember = "sHitap"
        Me.sec_sHitap1.Name = "sec_sHitap1"
        Me.sec_sHitap1.NullText = "[Hitap]"
        Me.sec_sHitap1.ValueMember = "sHitap"
        '
        'colsAdiSoyadi
        '
        Me.colsAdiSoyadi.Caption = "Adý Soyadý"
        Me.colsAdiSoyadi.FieldName = "sAdiSoyadi"
        Me.colsAdiSoyadi.Name = "colsAdiSoyadi"
        Me.colsAdiSoyadi.Visible = True
        Me.colsAdiSoyadi.VisibleIndex = 2
        '
        'pnl_yetkili_status
        '
        Me.pnl_yetkili_status.Controls.Add(Me.btn_yetkili_yazdir)
        Me.pnl_yetkili_status.Controls.Add(Me.btn_yetkili_sil)
        Me.pnl_yetkili_status.Controls.Add(Me.btn_yetkili_ekle)
        Me.pnl_yetkili_status.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_yetkili_status.Location = New System.Drawing.Point(0, 181)
        Me.pnl_yetkili_status.Name = "pnl_yetkili_status"
        Me.pnl_yetkili_status.Size = New System.Drawing.Size(815, 35)
        Me.pnl_yetkili_status.TabIndex = 1
        '
        'btn_yetkili_yazdir
        '
        Me.btn_yetkili_yazdir.Location = New System.Drawing.Point(167, 7)
        Me.btn_yetkili_yazdir.Name = "btn_yetkili_yazdir"
        Me.btn_yetkili_yazdir.Size = New System.Drawing.Size(75, 23)
        Me.btn_yetkili_yazdir.TabIndex = 2
        Me.btn_yetkili_yazdir.Text = "&Yazdýr"
        '
        'btn_yetkili_sil
        '
        Me.btn_yetkili_sil.Location = New System.Drawing.Point(86, 7)
        Me.btn_yetkili_sil.Name = "btn_yetkili_sil"
        Me.btn_yetkili_sil.Size = New System.Drawing.Size(75, 23)
        Me.btn_yetkili_sil.TabIndex = 1
        Me.btn_yetkili_sil.Text = "&Sil"
        '
        'btn_yetkili_ekle
        '
        Me.btn_yetkili_ekle.Location = New System.Drawing.Point(5, 7)
        Me.btn_yetkili_ekle.Name = "btn_yetkili_ekle"
        Me.btn_yetkili_ekle.Size = New System.Drawing.Size(75, 23)
        Me.btn_yetkili_ekle.TabIndex = 0
        Me.btn_yetkili_ekle.Text = "&Ekle"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.pnl_iletisim)
        Me.XtraTabPage4.Controls.Add(Me.pnl_iletisim_status)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.PageVisible = False
        Me.XtraTabPage4.Size = New System.Drawing.Size(815, 216)
        Me.XtraTabPage4.Text = "Ýletiþim"
        Me.XtraTabPage4.Tooltip = "Hesap Kartý Iletiþim Bilgileri Buradan Takip Edilir"
        '
        'pnl_iletisim
        '
        Me.pnl_iletisim.Controls.Add(Me.GridControl3)
        Me.pnl_iletisim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_iletisim.Location = New System.Drawing.Point(0, 0)
        Me.pnl_iletisim.Name = "pnl_iletisim"
        Me.pnl_iletisim.Size = New System.Drawing.Size(815, 181)
        Me.pnl_iletisim.TabIndex = 2
        '
        'GridControl3
        '
        Me.GridControl3.ContextMenu = Me.kisayol_iletisim
        Me.GridControl3.DataMember = "Table1"
        Me.GridControl3.DataSource = Me.ds_tbFirmaIletisimi
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(2, 2)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_IletisimAraci})
        Me.GridControl3.Size = New System.Drawing.Size(811, 177)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'kisayol_iletisim
        '
        Me.kisayol_iletisim.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem5, Me.MenuItem6})
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem4.Text = "Ekle"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 1
        Me.MenuItem5.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem5.Text = "Düzelt"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 2
        Me.MenuItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem6.Text = "Sil"
        '
        'ds_tbFirmaIletisimi
        '
        Me.ds_tbFirmaIletisimi.DataSetName = "NewDataSet"
        Me.ds_tbFirmaIletisimi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbFirmaIletisimi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "nIletisimID"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "nFirmaID"
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "sIletisimAraci"
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "sIletisimAdresi"
        '
        'GridView3
        '
        Me.GridView3.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.Empty.Options.UseBackColor = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnIletisimID, Me.colnFirmaID1, Me.colsIletisimAraci, Me.colsIletisimAdresi})
        Me.GridView3.DetailHeight = 160
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.GroupFormat = "{0}: {1} {2}"
        Me.GridView3.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView3.IndicatorWidth = 12
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsDetail.ShowDetailTabs = False
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'colnIletisimID
        '
        Me.colnIletisimID.Caption = "Ýletiþim ID"
        Me.colnIletisimID.FieldName = "nIletisimID"
        Me.colnIletisimID.Name = "colnIletisimID"
        '
        'colnFirmaID1
        '
        Me.colnFirmaID1.Caption = "Firma ID"
        Me.colnFirmaID1.FieldName = "nFirmaID"
        Me.colnFirmaID1.Name = "colnFirmaID1"
        '
        'colsIletisimAraci
        '
        Me.colsIletisimAraci.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlDark
        Me.colsIletisimAraci.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.colsIletisimAraci.AppearanceCell.Options.UseBackColor = True
        Me.colsIletisimAraci.AppearanceCell.Options.UseFont = True
        Me.colsIletisimAraci.Caption = "Ýletiþim Aracý"
        Me.colsIletisimAraci.ColumnEdit = Me.sec_IletisimAraci
        Me.colsIletisimAraci.FieldName = "sIletisimAraci"
        Me.colsIletisimAraci.Name = "colsIletisimAraci"
        Me.colsIletisimAraci.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sIletisimAraci", "{0} Kayýt")})
        Me.colsIletisimAraci.Visible = True
        Me.colsIletisimAraci.VisibleIndex = 0
        '
        'sec_IletisimAraci
        '
        Me.sec_IletisimAraci.AutoHeight = False
        Me.sec_IletisimAraci.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_IletisimAraci.DisplayMember = "sIletisimAraci"
        Me.sec_IletisimAraci.Name = "sec_IletisimAraci"
        Me.sec_IletisimAraci.NullText = "[IletisimAracý]"
        Me.sec_IletisimAraci.ValueMember = "sIletisimAraci"
        '
        'colsIletisimAdresi
        '
        Me.colsIletisimAdresi.Caption = "Ýletiþim Adresi"
        Me.colsIletisimAdresi.FieldName = "sIletisimAdresi"
        Me.colsIletisimAdresi.Name = "colsIletisimAdresi"
        Me.colsIletisimAdresi.Visible = True
        Me.colsIletisimAdresi.VisibleIndex = 1
        '
        'pnl_iletisim_status
        '
        Me.pnl_iletisim_status.Controls.Add(Me.btn_iletisim_yazdir)
        Me.pnl_iletisim_status.Controls.Add(Me.btn_iletisim_sil)
        Me.pnl_iletisim_status.Controls.Add(Me.btn_iletisim_ekle)
        Me.pnl_iletisim_status.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_iletisim_status.Location = New System.Drawing.Point(0, 181)
        Me.pnl_iletisim_status.Name = "pnl_iletisim_status"
        Me.pnl_iletisim_status.Size = New System.Drawing.Size(815, 35)
        Me.pnl_iletisim_status.TabIndex = 1
        '
        'btn_iletisim_yazdir
        '
        Me.btn_iletisim_yazdir.Location = New System.Drawing.Point(167, 7)
        Me.btn_iletisim_yazdir.Name = "btn_iletisim_yazdir"
        Me.btn_iletisim_yazdir.Size = New System.Drawing.Size(75, 23)
        Me.btn_iletisim_yazdir.TabIndex = 2
        Me.btn_iletisim_yazdir.Text = "&Yazdir"
        '
        'btn_iletisim_sil
        '
        Me.btn_iletisim_sil.Location = New System.Drawing.Point(86, 7)
        Me.btn_iletisim_sil.Name = "btn_iletisim_sil"
        Me.btn_iletisim_sil.Size = New System.Drawing.Size(75, 23)
        Me.btn_iletisim_sil.TabIndex = 1
        Me.btn_iletisim_sil.Text = "&Sil"
        '
        'btn_iletisim_ekle
        '
        Me.btn_iletisim_ekle.Location = New System.Drawing.Point(5, 7)
        Me.btn_iletisim_ekle.Name = "btn_iletisim_ekle"
        Me.btn_iletisim_ekle.Size = New System.Drawing.Size(75, 23)
        Me.btn_iletisim_ekle.TabIndex = 0
        Me.btn_iletisim_ekle.Text = "&Ekle"
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.GridControl4)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(815, 216)
        Me.XtraTabPage5.Text = "AyYekünleri"
        Me.XtraTabPage5.Tooltip = "Hesap Kartýnýn Yýl ve Aylar Ýtibariyle Bakiye Analizi Buradan Takip Edilir. Liste" & _
            "lemek için F5 Tuþuna Basýnýz."
        '
        'GridControl4
        '
        Me.GridControl4.ContextMenu = Me.kisayol_aylik
        Me.GridControl4.DataMember = "Table1"
        Me.GridControl4.DataSource = Me.ds_tbFirmaAyYekunleri
        Me.GridControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl4.Location = New System.Drawing.Point(0, 0)
        Me.GridControl4.MainView = Me.GridView5
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.Size = New System.Drawing.Size(815, 216)
        Me.GridControl4.TabIndex = 0
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5, Me.GridView4})
        '
        'kisayol_aylik
        '
        Me.kisayol_aylik.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem7, Me.MenuItem9, Me.MenuItem8})
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 0
        Me.MenuItem7.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.MenuItem7.Text = "Göster"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 1
        Me.MenuItem9.Text = "-"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 2
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem8.Text = "Görünümü Yazdýr"
        '
        'ds_tbFirmaAyYekunleri
        '
        Me.ds_tbFirmaAyYekunleri.DataSetName = "NewDataSet"
        Me.ds_tbFirmaAyYekunleri.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbFirmaAyYekunleri.Tables.AddRange(New System.Data.DataTable() {Me.DataTable4})
        '
        'DataTable4
        '
        Me.DataTable4.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36})
        Me.DataTable4.TableName = "Table1"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "nAy"
        Me.DataColumn31.DataType = GetType(Long)
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "nYil"
        Me.DataColumn32.DataType = GetType(Long)
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "nSayi"
        Me.DataColumn33.DataType = GetType(Long)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "lBorc"
        Me.DataColumn34.DataType = GetType(Decimal)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "lAlacak"
        Me.DataColumn35.DataType = GetType(Decimal)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "lBakiye"
        Me.DataColumn36.DataType = GetType(Decimal)
        '
        'GridView5
        '
        Me.GridView5.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView5.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView5.Appearance.Empty.Options.UseBackColor = True
        Me.GridView5.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView5.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView5.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView5.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView5.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView5.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnAy, Me.colnYil, Me.colnSayi, Me.collBorc, Me.collAlacak, Me.collBakiye, Me.collNetBakiye})
        Me.GridView5.DetailHeight = 160
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.GridControl = Me.GridControl4
        Me.GridView5.GroupFormat = "{0}: {1} {2}"
        Me.GridView5.GroupPanelText = "Gruplamak Ýstediðiniz Kolonu Buraya Sürükleyiniz..."
        Me.GridView5.IndicatorWidth = 12
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.Editable = False
        Me.GridView5.OptionsCustomization.AllowFilter = False
        Me.GridView5.OptionsCustomization.AllowGroup = False
        Me.GridView5.OptionsDetail.ShowDetailTabs = False
        Me.GridView5.OptionsView.ShowFooter = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.OptionsView.ShowIndicator = False
        '
        'colnAy
        '
        Me.colnAy.Caption = "Ay"
        Me.colnAy.FieldName = "sAy"
        Me.colnAy.Name = "colnAy"
        Me.colnAy.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sAy", "{0} Kayýt")})
        Me.colnAy.Visible = True
        Me.colnAy.VisibleIndex = 1
        '
        'colnYil
        '
        Me.colnYil.Caption = "Yil"
        Me.colnYil.FieldName = "nYil"
        Me.colnYil.Name = "colnYil"
        Me.colnYil.Visible = True
        Me.colnYil.VisibleIndex = 0
        '
        'colnSayi
        '
        Me.colnSayi.Caption = "Kayýt"
        Me.colnSayi.FieldName = "nSayi"
        Me.colnSayi.Name = "colnSayi"
        Me.colnSayi.Visible = True
        Me.colnSayi.VisibleIndex = 2
        '
        'collBorc
        '
        Me.collBorc.Caption = "Borç"
        Me.collBorc.DisplayFormat.FormatString = "#,0.00"
        Me.collBorc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBorc.FieldName = "lBorc"
        Me.collBorc.Name = "collBorc"
        Me.collBorc.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBorc", "{0:#,0.00}")})
        Me.collBorc.Visible = True
        Me.collBorc.VisibleIndex = 3
        '
        'collAlacak
        '
        Me.collAlacak.Caption = "Alacak"
        Me.collAlacak.DisplayFormat.FormatString = "#,0.00"
        Me.collAlacak.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collAlacak.FieldName = "lAlacak"
        Me.collAlacak.Name = "collAlacak"
        Me.collAlacak.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lAlacak", "{0:#,0.00}")})
        Me.collAlacak.Visible = True
        Me.collAlacak.VisibleIndex = 4
        '
        'collBakiye
        '
        Me.collBakiye.Caption = "Aylýk Bakiye"
        Me.collBakiye.DisplayFormat.FormatString = "#,#0.00(B);#,#0.00(A);-"
        Me.collBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBakiye.FieldName = "lBakiye"
        Me.collBakiye.Name = "collBakiye"
        Me.collBakiye.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBakiye", "{0:#,#0.00(B);#,#0.00(A);-}")})
        Me.collBakiye.Visible = True
        Me.collBakiye.VisibleIndex = 5
        '
        'collNetBakiye
        '
        Me.collNetBakiye.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.collNetBakiye.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.collNetBakiye.AppearanceCell.Options.UseFont = True
        Me.collNetBakiye.AppearanceCell.Options.UseForeColor = True
        Me.collNetBakiye.Caption = "Bakiye"
        Me.collNetBakiye.DisplayFormat.FormatString = "#,#0.00(B);#,#0.00(A);-"
        Me.collNetBakiye.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collNetBakiye.FieldName = "lNetBakiye"
        Me.collNetBakiye.Name = "collNetBakiye"
        Me.collNetBakiye.Visible = True
        Me.collNetBakiye.VisibleIndex = 6
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.GridControl4
        Me.GridView4.Name = "GridView4"
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.txt_sNot)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(815, 216)
        Me.XtraTabPage6.Text = "Notlar"
        '
        'txt_sNot
        '
        Me.txt_sNot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_sNot.Location = New System.Drawing.Point(0, 0)
        Me.txt_sNot.MenuManager = Me.BarManager1
        Me.txt_sNot.Name = "txt_sNot"
        Me.txt_sNot.Size = New System.Drawing.Size(815, 216)
        Me.txt_sNot.TabIndex = 0
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13})
        Me.BarManager1.MaxItemId = 13
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Ara,F3"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        ToolTipTitleItem3.Text = "Ara"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Farklý bir hesap kartini ekrana getirmek icin kullanilir."
        SuperToolTip2.Items.Add(ToolTipTitleItem3)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.BarButtonItem4.SuperTip = SuperToolTip2
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Ekle,Insert"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Sil,Ctrl+Del"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete))
        Me.BarButtonItem3.Name = "BarButtonItem3"
        ToolTipTitleItem4.Text = "Sil"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Hesap Kartýný Silmek icin Kullanilir. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hesap kartýný silebilmek icin Hareket gör" & _
            "memiþ olmasý gerekmektedir. Hareket gören Hesap kartlarý silinemez, pasif yapýla" & _
            "bilir."
        SuperToolTip3.Items.Add(ToolTipTitleItem4)
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.BarButtonItem3.SuperTip = SuperToolTip3
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Ekstre,F7"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        ToolTipTitleItem5.Text = "Ekstre"
        ToolTipItem4.LeftIndent = 6
        ToolTipItem4.Text = "Hesap kartina ait hesap hareketleri dökümü icin kullanilir. Dövizli veya Yerli pa" & _
            "ra birimi cinsinden alinabilir. Fis Hareketleri Özet, Diger Hesap hareketleri De" & _
            "tayli olarak listelenir."
        SuperToolTip4.Items.Add(ToolTipTitleItem5)
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.BarButtonItem5.SuperTip = SuperToolTip4
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Stoklu Ekstre,Ctrl+S"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
        Me.BarButtonItem7.Name = "BarButtonItem7"
        ToolTipTitleItem6.Text = "Stoklu Ekstre"
        ToolTipItem5.LeftIndent = 6
        ToolTipItem5.Text = "Hesap kartýna ait hareket dökümü alýnýr." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tüm hesap hareketleri detaylý olarak li" & _
            "stelenir." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fis Hareketlerinde Stok detaylarý izlenebilmektedir."
        SuperToolTip5.Items.Add(ToolTipTitleItem6)
        SuperToolTip5.Items.Add(ToolTipItem5)
        Me.BarButtonItem7.SuperTip = SuperToolTip5
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Bakiye,F6"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        ToolTipTitleItem7.Text = "Bakiye"
        ToolTipItem6.LeftIndent = 6
        ToolTipItem6.Text = "Hesap Kartýnýn Bakiye Analizi Ekrana gelir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Farklý Hareket Tiplerine Göre Bakiye " & _
            "Toplamlarý alýnabilir."
        SuperToolTip6.Items.Add(ToolTipTitleItem7)
        SuperToolTip6.Items.Add(ToolTipItem6)
        Me.BarButtonItem6.SuperTip = SuperToolTip6
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Notlar,F8"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F8)
        Me.BarButtonItem8.Name = "BarButtonItem8"
        ToolTipTitleItem8.Text = "Notlar"
        ToolTipItem7.LeftIndent = 6
        SuperToolTip7.Items.Add(ToolTipTitleItem8)
        SuperToolTip7.Items.Add(ToolTipItem7)
        Me.BarButtonItem8.SuperTip = SuperToolTip7
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Sýnýflar,F9"
        Me.BarButtonItem11.Id = 10
        Me.BarButtonItem11.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem11.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem11.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F9)
        Me.BarButtonItem11.Name = "BarButtonItem11"
        ToolTipTitleItem9.Text = "Sýnýflar"
        ToolTipItem8.LeftIndent = 6
        SuperToolTip8.Items.Add(ToolTipTitleItem9)
        SuperToolTip8.Items.Add(ToolTipItem8)
        Me.BarButtonItem11.SuperTip = SuperToolTip8
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Son Kod ,F11"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem9.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F11)
        Me.BarButtonItem9.Name = "BarButtonItem9"
        ToolTipTitleItem10.Text = "Son Kod"
        ToolTipItem9.LeftIndent = 6
        ToolTipTitleItem11.LeftIndent = 6
        ToolTipTitleItem11.Text = "Kayýt Numaralarýnda nerede kalýndýðý listelenir."
        SuperToolTip9.Items.Add(ToolTipTitleItem10)
        SuperToolTip9.Items.Add(ToolTipItem9)
        SuperToolTip9.Items.Add(ToolTipSeparatorItem2)
        SuperToolTip9.Items.Add(ToolTipTitleItem11)
        Me.BarButtonItem9.SuperTip = SuperToolTip9
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "&Hareket Gir,F12"
        Me.BarButtonItem10.Id = 9
        Me.BarButtonItem10.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem10.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem10.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12)
        Me.BarButtonItem10.Name = "BarButtonItem10"
        ToolTipTitleItem12.Text = "Hareket Gir"
        ToolTipItem10.LeftIndent = 6
        ToolTipTitleItem13.LeftIndent = 6
        ToolTipTitleItem13.Text = "Hýzlý Hesap Hareketleri Isle"
        SuperToolTip10.Items.Add(ToolTipTitleItem12)
        SuperToolTip10.Items.Add(ToolTipItem10)
        SuperToolTip10.Items.Add(ToolTipTitleItem13)
        Me.BarButtonItem10.SuperTip = SuperToolTip10
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Çýkýþ"
        Me.BarButtonItem12.Id = 11
        Me.BarButtonItem12.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape)
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Risk"
        Me.BarButtonItem13.Id = 12
        Me.BarButtonItem13.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem13.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem13.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R))
        Me.BarButtonItem13.Name = "BarButtonItem13"
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
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Düzelt,F4"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'PanelControl4
        '
        Me.PanelControl4.Appearance.BackColor = System.Drawing.Color.Black
        Me.PanelControl4.Appearance.Options.UseBackColor = True
        Me.PanelControl4.Controls.Add(Me.LabelControl18)
        Me.PanelControl4.Controls.Add(Me.LabelControl17)
        Me.PanelControl4.Controls.Add(Me.LabelControl10)
        Me.PanelControl4.Controls.Add(Me.TextEdit3)
        Me.PanelControl4.Controls.Add(Me.TextEdit2)
        Me.PanelControl4.Controls.Add(Me.TextEdit1)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(2, 261)
        Me.PanelControl4.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PanelControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(820, 40)
        Me.PanelControl4.TabIndex = 0
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.BackColor = System.Drawing.Color.Black
        Me.LabelControl18.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl18.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl18.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.LabelControl18.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl18.Location = New System.Drawing.Point(580, 4)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(190, 13)
        Me.LabelControl18.TabIndex = 65
        Me.LabelControl18.Text = "Bakiye"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.BackColor = System.Drawing.Color.Black
        Me.LabelControl17.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl17.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.LabelControl17.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl17.Location = New System.Drawing.Point(390, 4)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(190, 13)
        Me.LabelControl17.TabIndex = 64
        Me.LabelControl17.Text = "Alacak"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.BackColor = System.Drawing.Color.Black
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Location = New System.Drawing.Point(200, 4)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(190, 13)
        Me.LabelControl10.TabIndex = 63
        Me.LabelControl10.Text = "Borç"
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirmaBakiyesi, "Table1.lBakiye", True))
        Me.TextEdit3.Enabled = False
        Me.TextEdit3.EnterMoveNextControl = True
        Me.TextEdit3.Location = New System.Drawing.Point(580, 17)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.TextEdit3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit3.Properties.Appearance.Options.UseFont = True
        Me.TextEdit3.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit3.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit3.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit3.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit3.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit3.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit3.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit3.Properties.DisplayFormat.FormatString = "#,#0.00(B);#,#0.00(A);-"
        Me.TextEdit3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit3.Properties.EditFormat.FormatString = "#,#0.00(B);#,#0.00(A);-"
        Me.TextEdit3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit3.Properties.MaxLength = 60
        Me.TextEdit3.Properties.NullText = "0.00"
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit3.Size = New System.Drawing.Size(193, 18)
        Me.TextEdit3.TabIndex = 62
        '
        'ds_tbFirmaBakiyesi
        '
        Me.ds_tbFirmaBakiyesi.DataSetName = "NewDataSet"
        Me.ds_tbFirmaBakiyesi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbFirmaBakiyesi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable6})
        '
        'DataTable6
        '
        Me.DataTable6.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn42, Me.DataColumn43, Me.DataColumn44, Me.DataColumn45})
        Me.DataTable6.TableName = "Table1"
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "nFirmaID"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "lBorc"
        Me.DataColumn43.DataType = GetType(Decimal)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "lAlacak"
        Me.DataColumn44.DataType = GetType(Decimal)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "lBakiye"
        Me.DataColumn45.DataType = GetType(Decimal)
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirmaBakiyesi, "Table1.lAlacak", True))
        Me.TextEdit2.Enabled = False
        Me.TextEdit2.EnterMoveNextControl = True
        Me.TextEdit2.Location = New System.Drawing.Point(390, 17)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit2.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit2.Properties.DisplayFormat.FormatString = "#,0.00##"
        Me.TextEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit2.Properties.EditFormat.FormatString = "#,0.00##"
        Me.TextEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit2.Properties.MaxLength = 60
        Me.TextEdit2.Properties.NullText = "0.00"
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit2.Size = New System.Drawing.Size(190, 18)
        Me.TextEdit2.TabIndex = 61
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbFirmaBakiyesi, "Table1.lBorc", True))
        Me.TextEdit1.Enabled = False
        Me.TextEdit1.EnterMoveNextControl = True
        Me.TextEdit1.Location = New System.Drawing.Point(200, 17)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit1.Properties.DisplayFormat.FormatString = "#,0.00##"
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.EditFormat.FormatString = "#,0.00##"
        Me.TextEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.MaxLength = 60
        Me.TextEdit1.Properties.NullText = "0.00"
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit1.Size = New System.Drawing.Size(190, 18)
        Me.TextEdit1.TabIndex = 60
        '
        'ps
        '
        Me.ps.Links.AddRange(New Object() {Me.printlink1})
        '
        'printlink1
        '
        Me.printlink1.Component = Me.GridControl4
        '
        '
        '
        Me.printlink1.ImageCollection.ImageStream = CType(resources.GetObject("printlink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Aylýk Hesap Ýcmali", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Account Managment", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'frm_HesapPlani_kart
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
        Me.Name = "frm_HesapPlani_kart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Muhasebe HesapPlani Kartý"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.kisayol_ana.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_sAktifPasif.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbFirma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bMiktarVar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sIl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sKodu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAlternatifAciklama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAdi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbFirmaSinifi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_siniflar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinifKodu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.pnl_yetkililer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_yetkililer.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbFirmaYetkilisi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sUnvan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sHitap1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_yetkili_status, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_yetkili_status.ResumeLayout(False)
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.pnl_iletisim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_iletisim.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbFirmaIletisimi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_IletisimAraci, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl_iletisim_status, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_iletisim_status.ResumeLayout(False)
        Me.XtraTabPage5.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbFirmaAyYekunleri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage6.ResumeLayout(False)
        CType(Me.txt_sNot.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbFirmaBakiyesi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public nHesapID As Int64 = 0
    Public sKodu
    Public kullanici
    Public nPage As Int16 = 0
    Public bSil As Boolean = False
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_cari As DataSet
    Dim ds_tbIl As DataSet
    Dim ds_tbUlke As DataSet
    Public yeni As Boolean = False
    Dim bKapat As Boolean = False
    Private Sub frm_firma_kart_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If yeni = True Then
            txt_sKodu.Focus()
            txt_sKodu.SelectAll()
        End If
    End Sub
    Private Sub frm_firma_kart_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub
    Private Sub frm_firma_kart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If nHesapID = 0 Then
            If yeni = False Then
                firma_sec()
            ElseIf yeni = True Then
                dataload(nHesapID)
                SimpleButton1.Text = "&Kaydet"
                XtraTabPage2.PageEnabled = False
                XtraTabPage3.PageEnabled = False
                XtraTabPage4.PageEnabled = False
                XtraTabPage5.PageEnabled = False
                txt_sKodu.Enabled = True
                sec_sAktifPasif.Text = "Aktif"
            End If
        Else
            txt_musteriNo.EditValue = sKodu
            dataload(nHesapID)
        End If
        If bKapat = False Then
            dataload_tbIl()
            dataload_tbHSinif(1)
            'dataload_tbIletisimAraci()
            'dataload_tbMSinif(1)
            If yeni = True Then
                txt_sKodu.Focus()
                txt_sKodu.SelectAll()
            Else
                XtraTabControl1.SelectedTabPageIndex = nPage
                txt_sAdi.Focus()
                txt_sAdi.SelectAll()
            End If
        Else
            Me.Close()
        End If
    End Sub
    Private Sub dataload_tbIl()
        ds_tbIl = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbMasrafMerkezi order by sMasrafYontemi"))
        txt_sIl.Properties.DataSource = ds_tbIl.Tables(0)
    End Sub
    Private Sub dataload_tbHSinif(Optional ByVal sSinifNo As Integer = 1)
        sec_sSinifKodu.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbHSinif" & sSinifNo & "")).Tables(0)
        sec_siniflar.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbHSinif" & sSinifNo & "")).Tables(0)
    End Sub
    Private Sub dataload_tbIletisimAraci()
        sec_IletisimAraci.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbIletisimAraci")).Tables(0)
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
    Public Function sorgu_sKodu_kontrol(ByVal kod As String) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sKodu), 0) AS nKayit FROM         tbHesapPlani WHERE     (sKodu = '" & kod & "') ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Private Sub firma_sec()
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_HesapPlani_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            yeni = False
            SimpleButton1.Text = "&Tamam"
            XtraTabPage2.PageEnabled = True
            XtraTabPage3.PageEnabled = True
            XtraTabPage4.PageEnabled = True
            XtraTabPage5.PageEnabled = True
            txt_sKodu.Enabled = False
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nHesapID = dr1("nHesapID")
            sKodu = dr1("sKodu")
            txt_musteriNo.EditValue = sKodu
            musteri_kontrol()
            dr1 = Nothing
        Else
            bKapat = True
            Me.Close()
        End If
    End Sub
    Private Sub musteri_kontrol()
        If Trim(txt_musteriNo.EditValue).ToString <> "" Then
            Dim kontrol = sorgu_cari_kontrol(txt_musteriNo.EditValue)
            If kontrol = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf kontrol = 1 Then
                dataload_cari(txt_musteriNo.EditValue)
                Dim dr As DataRow
                For Each dr In ds_cari.Tables(0).Rows
                    'txt_Musteri.EditValue = dr("MUSTERI")
                    sKodu = dr("sKodu")
                    nHesapID = dr("nHesapID")
                    dataload(nHesapID)
                Next
                dr = Nothing
            End If
        End If
    End Sub
    Public Function sorgu_cari_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         tbHesapPlani " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_nkayit_kontrol(ByVal nHesapID As String) As Int64
        Dim kriter
        kriter = "WHERE (nHesapID = '" & nHesapID & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select ISNULL(count(nHesapID),0) as nKayit from tbFirmaHareketi " & kriter & " ")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_cari(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        ds_cari = sorgu(sorgu_query("SELECT     nHesapID,sKodu,sAciklama FROM         tbHesapPlani " & kriter & ""))
    End Sub
    Private Sub dataload(ByVal nHesapID As String)
        Dataload_tbFirma(nHesapID)
        Dataload_tbFirmaBakiyesi(nHesapID)
        'Müþteri Sýnýflandýrma Kontrol
        If sorgu_tbFirmaTablo_kontrol(nHesapID, "tbHesapSinifi") = 0 Then
            tbHesapSinifi_kaydet_yeni(nHesapID, "", "", "", "", "")
        End If
        Dataload_tbHesapSinifi(nHesapID)
        'Firma Açýklamasý Kontrol
        'If sorgu_tbFirmaTablo_kontrol(nHesapID, "tbFirmaAciklamasi") = 0 Then
        '    tbFirmaAciklamasi_kaydet_yeni(nHesapID, "", "", "", "", "")
        'End If
        'Dataload_tbFirmaAciklamasi(nHesapID)
        'ds_tbFirmaYetkilisi = Dataload_tbFirmaYetkilisi(nHesapID)
        'GridControl2.DataSource = ds_tbFirmaYetkilisi.Tables(0)
        'GridControl2.DataMember = Nothing
        'ds_tbFirmaIletisimi = Dataload_tbFirmaIletisimi(nHesapID)
        'GridControl3.DataSource = ds_tbFirmaIletisimi.Tables(0)
        'GridControl3.DataMember = Nothing
        'ds_tbFirmaAyYekunleri = Dataload_tbFirmaAyYekunleri(nHesapID)
        'GridControl4.DataSource = ds_tbFirmaAyYekunleri.Tables(0)
        'GridControl4.DataMember = Nothing
    End Sub
    Public Sub Dataload_tbFirma(ByVal nHesapID As String)
        Try
            ds_tbFirma.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbHesapPlani WHERE nHesapID ='" & nHesapID & "'")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbFirma, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbFirmaBakiyesi(ByVal nHesapID As String)
        Try
            ds_tbFirmaBakiyesi.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nHesapID, ISNULL(SUM(lBorcTutar), 0) AS lBorc, ISNULL(SUM(lAlacakTutar), 0) AS lAlacak, ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbMuhasebeFisi WHERE (nHesapID = '" & nHesapID & "') GROUP BY nHesapID")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbFirmaBakiyesi, "Table1")
        conn.Close()
    End Sub
    Private Sub Dataload_tbHesapSinifi(ByVal nMusteriID As String)
        Dim kriter As String = ""
        kriter += " SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
        kriter += " SELECT 1 AS sSinifNo, tbHesapSinifi.nHesapID, (SELECT sSinifTipi01 FROM tbParamMuhasebe) AS sSinifTipi, tbHSinif1.sSinifKodu, tbHSinif1.sAciklama FROM tbHesapSinifi INNER JOIN tbHSinif1 ON tbHesapSinifi.sSinifKodu1 = tbHSinif1.sSinifKodu WHERE (tbHesapSinifi.nHesapID = '" & nHesapID & "')"
        kriter += " UNION ALL"
        kriter += " SELECT 2 AS sSinifNo, tbHesapSinifi.nHesapID, (SELECT sSinifTipi02 FROM tbParamMuhasebe) AS sSinifTipi, tbHSinif2.sSinifKodu, tbHSinif2.sAciklama FROM tbHesapSinifi INNER JOIN tbHSinif2 ON tbHesapSinifi.sSinifKodu2 = tbHSinif2.sSinifKodu WHERE (tbHesapSinifi.nHesapID = '" & nHesapID & "')"
        kriter += " UNION ALL"
        kriter += " SELECT 3 AS sSinifNo, tbHesapSinifi.nHesapID, (SELECT sSinifTipi03 FROM tbParamMuhasebe) AS sSinifTipi, tbHSinif3.sSinifKodu, tbHSinif3.sAciklama FROM tbHesapSinifi INNER JOIN tbHSinif3 ON tbHesapSinifi.sSinifKodu3 = tbHSinif3.sSinifKodu WHERE (tbHesapSinifi.nHesapID = '" & nHesapID & "')"
        kriter += " UNION ALL"
        kriter += " SELECT 4 AS sSinifNo, tbHesapSinifi.nHesapID, (SELECT sSinifTipi04 FROM tbParamMuhasebe) AS sSinifTipi, tbHSinif4.sSinifKodu, tbHSinif4.sAciklama FROM tbHesapSinifi INNER JOIN tbHSinif4 ON tbHesapSinifi.sSinifKodu4 = tbHSinif4.sSinifKodu WHERE (tbHesapSinifi.nHesapID = '" & nHesapID & "')"
        kriter += " UNION ALL"
        kriter += " SELECT 5 AS sSinifNo, tbHesapSinifi.nHesapID, (SELECT sSinifTipi05 FROM tbParamMuhasebe) AS sSinifTipi, tbHSinif5.sSinifKodu, tbHSinif5.sAciklama FROM tbHesapSinifi INNER JOIN tbHSinif5 ON tbHesapSinifi.sSinifKodu5 = tbHSinif5.sSinifKodu WHERE (tbHesapSinifi.nHesapID = '" & nHesapID & "')"
        ds_tbFirmaSinifi = sorgu(sorgu_query("" & kriter & ""))
        GridControl1.DataMember = Nothing
        GridControl1.DataSource = ds_tbFirmaSinifi.Tables(0)
    End Sub
    Public Function Dataload_tbFirmaAciklamasi(ByVal nHesapID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaAciklamasi WHERE nHesapID ='" & nHesapID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function Dataload_tbFirmaYetkilisi(ByVal nHesapID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaYetkilisi WHERE nHesapID ='" & nHesapID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function Dataload_tbFirmaIletisimi(ByVal nHesapID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaIletisimi WHERE nHesapID ='" & nHesapID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function Dataload_tbFirmaAyYekunleri(ByVal nHesapID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("set language Türkçe set dateformat dmy set datefirst 1 SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DATENAME([month], dteFisTarihi) AS sAy, YEAR(dteFisTarihi) AS nYil, COUNT(dteFisTarihi) AS nSayi, SUM(lBorcTutar) AS lBorc, SUM(lAlacakTutar) AS lAlacak, SUM(lBorcTutar) - SUM(lAlacakTutar) AS lBakiye, CAST(0 AS MONEY) AS lNetBakiye FROM tbMuhasebeFisi WHERE (nHesapID = '" & nHesapID & "') GROUP BY DATENAME([month], dteFisTarihi), MONTH(dteFisTarihi),YEAR(dteFisTarihi) ORDER BY YEAR(dteFisTarihi), MONTH(dteFisTarihi) ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Dim dr As DataRow
        Dim bakiye As Decimal = 0
        For Each dr In Datastoklar1.Tables(0).Rows
            bakiye = bakiye + (dr("lBorc") - dr("lAlacak"))
            dr("lNetBakiye") = bakiye
        Next
        Return Datastoklar1
    End Function
    Public Function sorgu_tbFirmaTablo_kontrol(ByVal nHesapID As String, ByVal Tablo As String) As Int64
        Dim kriter
        kriter = "WHERE (nHesapID = '" & nHesapID & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         " & Tablo & "  " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Function tbHesapPlani_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal sAlterneAciklama As String, ByVal lBilancoSatiri As Decimal, ByVal sAktifPasif As String, ByVal lKarZararSatiri As Decimal, ByVal sKarZararGelirGider As String, ByVal sMasrafYontemi As String, ByVal bMiktarVar As Integer, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nHesapID, 0) AS nHesapID  FROM         tbHesapPlani Where sKodu = '" & sKodu & "' ")
        Dim kayitno As String = cmd.ExecuteScalar
        If kayitno = "0" Or kayitno = "" Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbHesapPlani (sKodu, sAciklama, sAlterneAciklama, lBilancoSatiri, sAktifPasif, lKarZararSatiri, sKarZararGelirGider, sMasrafYontemi, bMiktarVar, sKullaniciAdi, dteKayitTarihi) VALUES     ('" & sKodu & "', N'" & sAciklama & "', '" & sAlterneAciklama & "', " & lBilancoSatiri & ", '" & sAktifPasif & "', " & lKarZararSatiri & ", '" & sKarZararGelirGider & "', '" & sMasrafYontemi & "', " & bMiktarVar & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
            kayitno = cmd.ExecuteScalar
        End If
        con.Close()
        Return kayitno
    End Function
    Private Sub tbHesapPlani_kaydet_duzelt(ByVal nHesapID As Int64, ByVal sKodu As String, ByVal sAciklama As String, ByVal sAlterneAciklama As String, ByVal lBilancoSatiri As Decimal, ByVal sAktifPasif As String, ByVal lKarZararSatiri As Decimal, ByVal sKarZararGelirGider As String, ByVal sMasrafYontemi As String, ByVal bMiktarVar As Integer, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbHesapPlani SET              sKodu = '" & sKodu & "', sAciklama = N'" & sAciklama & "', sAlterneAciklama = '" & sAlterneAciklama & "', lBilancoSatiri = " & lBilancoSatiri & ",sAktifPasif = '" & sAktifPasif & "', lKarZararSatiri = " & lKarZararSatiri & ", sKarZararGelirGider = '" & sKarZararGelirGider & "', sMasrafYontemi = '" & sMasrafYontemi & "',bMiktarVar = " & bMiktarVar & ", sKullaniciAdi = '" & sKullaniciAdi & "', dteKayitTarihi = '" & dteKayitTarihi & "'  Where nHesapID = '" & nHesapID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub tbHesapSinifi_kaydet_yeni(ByVal nHesapID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbHesapSinifi (nHesapID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5) VALUES     (" & nHesapID & ", '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbHesapSinifi_kaydet_duzelt(ByVal nHesapID As String, ByVal sSinifKodu As String, ByVal sSinifNo As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbHesapSinifi SET              sSinifKodu" & sSinifNo & " = '" & sSinifKodu & "' where nHesapID = '" & nHesapID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaAciklamasi_kaydet_yeni(ByVal nHesapID As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaAciklamasi (nHesapID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5) VALUES     ('" & nHesapID & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaYetkilisi_kaydet_yeni(ByVal nHesapID As String, ByVal sUnvan As String, ByVal sHitap As String, ByVal sAdiSoyadi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaYetkilisi (nHesapID, sUnvan, sHitap, sAdiSoyadi) VALUES     ('" & nHesapID & "', '" & sUnvan & "', '" & sHitap & "', '" & sAdiSoyadi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaYetkilisi_kaydet_duzelt(ByVal nYetkiliID As String, ByVal nHesapID As String, ByVal sUnvan As String, ByVal sHitap As String, ByVal sAdiSoyadi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbFirmaYetkilisi SET              sUnvan = '" & sUnvan & "', sHitap = '" & sHitap & "', sAdiSoyadi = '" & sAdiSoyadi & "' Where nYetkiliID = '" & nYetkiliID & "' and nHesapID ='" & nHesapID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaYetkilisi_Satir_sil()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow
            Dim satir
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            satir = GridView2.FocusedRowHandle
            If XtraMessageBox.Show(dr("sAdiSoyadi") & vbTab & Sorgu_sDil(" Ýsimli Yetkili Kaydýný Silmek istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                tbFirmaYetkilisi_kaydet_sil(dr("nYetkiliID"), dr("nHesapID"))
            End If
            ds_tbFirmaYetkilisi = Dataload_tbFirmaYetkilisi(nHesapID)
            GridControl2.DataSource = ds_tbFirmaYetkilisi.Tables(0)
            GridControl2.DataMember = Nothing
            GridView2.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub tbFirmaYetkilisi_kaydet_sil(ByVal nYetkiliID As String, ByVal nHesapID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbFirmaYetkilisi  Where nYetkiliID = '" & nYetkiliID & "' and nHesapID ='" & nHesapID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaIletisimi_kaydet_yeni(ByVal nHesapID As String, ByVal sIletisimAraci As String, ByVal sIletisimAdresi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaIletisimi (nHesapID, sIletisimAraci, sIletisimAdresi) VALUES     ('" & nHesapID & "', '" & sIletisimAraci & "', '" & sIletisimAdresi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaIletisimi_kaydet_duzelt(ByVal nIletisimID As String, ByVal nHesapID As String, ByVal sIletisimAraci As String, ByVal sIletisimAdresi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbFirmaIletisimi SET              sIletisimAraci = '" & sIletisimAraci & "', sIletisimAdresi = '" & sIletisimAdresi & "' Where nIletisimID = '" & nIletisimID & "' and nHesapID = '" & nHesapID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaIletisimi_Satir_sil()
        If GridView3.RowCount > 0 Then
            Dim dr As DataRow
            Dim satir
            dr = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            satir = GridView3.FocusedRowHandle
            If XtraMessageBox.Show(dr("sIletisimAdresi") & vbTab & Sorgu_sDil(" Ýletiþim Adres Kaydýný Silmek istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                tbFirmaIletisimi_kaydet_sil(dr("nIletisimID"), dr("nHesapID"))
            End If
            ds_tbFirmaIletisimi = Dataload_tbFirmaIletisimi(nHesapID)
            GridControl3.DataSource = ds_tbFirmaIletisimi.Tables(0)
            GridControl3.DataMember = Nothing
            GridView3.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub tbFirmaIletisimi_kaydet_sil(ByVal nIletisimID As String, ByVal nHesapID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbFirmaIletisimi  Where nIletisimID = '" & nIletisimID & "' and nHesapID = '" & nHesapID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub kaydet_tumu()
        Dim dr As DataRow
        dr = ds_tbFirma.Tables(0).Rows(0)
        If yeni = False Then
            tbHesapPlani_kaydet_duzelt(nHesapID, dr("sKodu"), dr("sAciklama"), dr("sAlterneAciklama"), dr("lBilancoSatiri"), dr("sAktifPasif"), dr("lKarZararSatiri"), dr("sKarZararGelirGider"), dr("sMasrafYontemi"), Math.Abs(sorgu_sayi(dr("bMiktarVar"), 0)), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
            Me.Close()
        ElseIf yeni = True Then
            nHesapID = tbHesapPlani_kaydet_yeni(txt_sKodu.Text, txt_sAdi.Text, "", 0, "", 0, "", "", 0, kullanici, Now)
            'nHesapID = tbFirma_kaydet_yeni(nHesapID, txt_sKodu.EditValue.ToString, dr("sAciklama"), dr("nOzelIskontosu"), dr("lKrediLimiti"), dr("dteMutabakatTarihi"), dr("nVadeGun"), dr("sHitap"), dr("sAdres1"), dr("sAdres2"), dr("sSemt"), dr("sIl"), dr("sUlke"), dr("sPostaKodu"), dr("sVergiDairesi"), dr("sVergiNo"), nHesapID, dr("sOzelNot"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sFiyatTipi"), dr("sSaticiRumuzu").ToString, sorgu_sayi(dr("nOzelIskontosu2"), 0), sorgu_sayi(dr("nOzelIskontosu3"), 0), sorgu_sayi(dr("nOzelIskontosu4"), 0), Math.Abs(sorgu_sayi(dr("bAktif"), 0))).ToString
            tbHesapSinifi_kaydet_yeni(nHesapID, "", "", "", "", "")
            'tbFirmaAciklamasi_kaydet_yeni(nHesapID, "", "", "", "", "")
            sKodu = txt_sKodu.EditValue.ToString
            yeni = False
            SimpleButton1.Text = "&Tamam"
            txt_sKodu.Enabled = False
            XtraTabPage2.PageEnabled = True
            XtraTabPage3.PageEnabled = True
            XtraTabPage4.PageEnabled = True
            XtraTabPage5.PageEnabled = True
            dataload(nHesapID)
            txt_sAdi.Focus()
            txt_sAdi.SelectAll()
        End If
    End Sub
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub tbFirma_Ekle()
        nHesapID = 0
        nHesapID = 0
        yeni = True
        dataload(nHesapID)
        SimpleButton1.Text = "&Kaydet"
        XtraTabPage2.PageEnabled = False
        XtraTabPage3.PageEnabled = False
        XtraTabPage4.PageEnabled = False
        XtraTabPage5.PageEnabled = False
        txt_sKodu.Enabled = True
        txt_musteriNo.EditValue = ""
        txt_sKodu.Focus()
        txt_sKodu.SelectAll()
    End Sub
    Private Sub tbFirma_sil(ByVal nHesapID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If sorgu_nkayit_kontrol(nHesapID) = 0 Then
            If con.State = ConnectionState.Closed = True Then
                con.Open()
            End If
            cmd.CommandText = sorgu_query("set implicit_transactions on")
            cmd.ExecuteNonQuery()
            Try
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete from tbHesapSinifi where nHesapID = " & nHesapID & " ")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete from tbHesapPlani where nHesapID = " & nHesapID & "")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(sKodu,'') as sKodu FROM         tbHesapPlani WHERE     (nHesapID < '" & nHesapID & "' ) ORDER BY sKodu DESC ")
                sKodu = cmd.ExecuteScalar
                txt_musteriNo.EditValue = sKodu
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Baþarýyla Silindi...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                musteri_kontrol()
            Catch ex As Exception
                XtraMessageBox.Show(Sorgu_sDil("Üzgünüm,Hareket Görmüþ Kaydý Silemezsiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 ROLLBACK TRAN")
                cmd.ExecuteNonQuery()
            End Try
            con.Close()
        Else
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm,Hareket Görmüþ Kaydý Silemezsiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub tbFirma_notlari()
        Dim frm As New frm_musteri_karti_aciklama
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kayitno = nHesapID
        frm.firma = True
        frm.kullanici = kullanici
        'Firma Açýklamasý Kontrol
        If sorgu_tbFirmaTablo_kontrol(nHesapID, "tbFirmaAciklamasi") = 0 Then
            tbFirmaAciklamasi_kaydet_yeni(nHesapID, "", "", "", "", "")
        End If
        frm.ShowDialog()
    End Sub
    Private Sub tbFirmaHareketi()
        Dim frm As New frm_tbFirmaHareketi
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.nFirmaID = nHesapID
        frm.sKodu = sKodu
        frm.txt_musteriNo.EditValue = sKodu
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub tbSonKod()
        Dim frm As New frm_tbSonKod
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.islem = "tbHesapPlani"
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            txt_sKodu.EditValue = frm.lbl_Kod.Text
            txt_sKodu.Focus()
            txt_sKodu.SelectAll()
        End If
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub tbSinif(ByVal tablo As String)
        Dim fr As New frm_tbSinif
        fr.firmano = firmano
        fr.donemno = donemno
        fr.connection = connection
        fr.kullanici = kullanici
        fr.Table = tablo
        If yetki_kontrol(kullanici, fr.Name) = True Then
            fr.Show()
        End If
    End Sub
    Private Sub analiz_risk()
        If nHesapID > 0 Then
            Dim frm As New frm_firma_risk
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = nHesapID
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_cari_bakiye()
        If nHesapID > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_Firma_bakiye
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sKodu = sKodu
            frm.txt_musteriNo.EditValue = sKodu
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(frm.sKodu))) = True Then
                    frm.ShowDialog()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_cari_hareket()
        If nHesapID > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_hareketler_ozet
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = sKodu
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(sKodu))) = True Then
                    frm.ShowDialog()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_cari_hareket_detayli()
        If nHesapID > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_hareketler_detayli
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = sKodu
            frm.kullanici = kullanici
            frm.DateEdit1.EditValue = "01/01/1900"
            frm.DateEdit2.EditValue = "31/12/2078"
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(frm.musterino))) = True Then
                    frm.ShowDialog()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            Dim satir = GridView1.FocusedRowHandle
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            GridView1.PostEditor()
            dr.EndEdit()
            tbHesapSinifi_kaydet_duzelt(nHesapID, dr("sSinifKodu"), dr("sSinifNo"))
            Dataload_tbHesapSinifi(nHesapID)
            GridView1.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Try
                dataload_tbHSinif(dr("sSinifNo"))
            Catch ex As Exception
            End Try
            dr = Nothing
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        kaydet_tumu()
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            txt_sAdi.Focus()
            txt_sAdi.SelectAll()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            GridControl1.Focus()
            GridControl1.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 2 Then
            GridControl2.Focus()
            GridControl2.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 3 Then
            GridControl3.Focus()
            GridControl3.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 4 Then
            ds_tbFirmaAyYekunleri = Dataload_tbFirmaAyYekunleri(nHesapID)
            GridControl4.DataSource = ds_tbFirmaAyYekunleri.Tables(0)
            GridControl4.DataMember = Nothing
            GridControl4.Focus()
            GridControl4.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 5 Then
            txt_sNot.Focus()
            txt_sNot.Select()
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        yetkili_ekle()
    End Sub
    Private Sub yetkili_ekle()
        tbFirmaYetkilisi_kaydet_yeni(nHesapID, "", "", "")
        ds_tbFirmaYetkilisi = Dataload_tbFirmaYetkilisi(nHesapID)
        GridControl2.DataSource = ds_tbFirmaYetkilisi.Tables(0)
        GridControl2.DataMember = Nothing
        GridView2.FocusedRowHandle = GridView2.RowCount - 1
    End Sub
    Private Sub yetkili_sil()
        tbFirmaYetkilisi_Satir_sil()
    End Sub
    Private Sub yetkili_yazdir()
        GridControl2.ShowPrintPreview()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        yetkili_sil()
    End Sub
    Private Sub GridView2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        If GridView2.RowCount > 0 Then
            Dim satir = GridView2.FocusedRowHandle
            Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            GridView2.PostEditor()
            dr.EndEdit()
            Try
                tbFirmaYetkilisi_kaydet_duzelt(dr("nYetkiliID"), dr("nHesapID"), dr("sUnvan"), dr("sHitap"), dr("sAdiSoyadi"))
            Catch ex As Exception
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Ýçeride Var", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            ds_tbFirmaYetkilisi = Dataload_tbFirmaYetkilisi(nHesapID)
            GridView2.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        iletisim_ekle()
    End Sub
    Private Sub iletisim_ekle()
        tbFirmaIletisimi_kaydet_yeni(nHesapID, "Telefon", "")
        ds_tbFirmaIletisimi = Dataload_tbFirmaIletisimi(nHesapID)
        GridControl3.DataSource = ds_tbFirmaIletisimi.Tables(0)
        GridControl3.DataMember = Nothing
        GridView3.FocusedRowHandle = GridView3.RowCount - 1
    End Sub
    Private Sub iletisim_sil()
        tbFirmaIletisimi_Satir_sil()
    End Sub
    Private Sub iletisim_yazdir()
        GridControl3.ShowPrintPreview()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        tbFirmaIletisimi_Satir_sil()
    End Sub
    Private Sub GridView3_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView3.CellValueChanged
        If GridView3.RowCount > 0 Then
            Dim satir = GridView3.FocusedRowHandle
            Dim dr As DataRow = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            GridView3.PostEditor()
            dr.EndEdit()
            Try
                tbFirmaIletisimi_kaydet_duzelt(dr("nIletisimID"), dr("nHesapID"), dr("sIletisimAraci"), dr("sIletisimAdresi"))
            Catch ex As Exception
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Ýçeride Var", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            ds_tbFirmaIletisimi = Dataload_tbFirmaIletisimi(nHesapID)
            GridView3.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        ds_tbFirmaAyYekunleri = Dataload_tbFirmaAyYekunleri(nHesapID)
        GridControl4.DataSource = ds_tbFirmaAyYekunleri.Tables(0)
        GridControl4.DataMember = Nothing
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbFirma_notlari()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbFirmaHareketi()
    End Sub
    Private Sub AraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AraToolStripMenuItem.Click
        firma_sec()
    End Sub
    Private Sub FirmaHareketleriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirmaHareketleriToolStripMenuItem.Click
        analiz_cari_hareket()
    End Sub
    Private Sub FirmaBakiyeleriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirmaBakiyeleriToolStripMenuItem.Click
        analiz_cari_bakiye()
    End Sub
    Private Sub HareketGirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HareketGirToolStripMenuItem.Click
        tbFirmaHareketi()
    End Sub
    Private Sub AçýklamaGirToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AçýklamaGirToolStripMenuItem.Click
        tbFirma_notlari()
    End Sub
    Private Sub txt_sKodu_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_sKodu.EditValueChanged
        If yeni = True Then
            'txt_sMuhasebeKodu.EditValue = txt_sKodu.EditValue
        End If
    End Sub
    Private Sub txt_sKodu_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sKodu.Validating
        If yeni = True Then
            txt_sKodu.EditValue = Trim(txt_sKodu.EditValue)
            If sorgu_sKodu_kontrol(txt_sKodu.EditValue) = False Then
                txt_sKodu.ErrorText = txt_sKodu.Text & vbTab & "Kaydý Daha Önce Kullanýlmýþ"
                e.Cancel = True
                txt_sKodu.Focus()
                txt_sKodu.SelectAll()
            End If
        End If
    End Sub
    Private Sub SilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SilToolStripMenuItem.Click
        If XtraMessageBox.Show(Sorgu_sDil("Kaydý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            tbFirma_sil(nHesapID)
        End If
    End Sub
    Private Sub btn_MuhasebeAc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub SonKodToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SonKodToolStripMenuItem.Click
        tbSonKod()
    End Sub
    Private Sub EkleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EkleToolStripMenuItem.Click
        tbFirma_Ekle()
    End Sub
    Private Sub StokluEkstreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StokluEkstreToolStripMenuItem.Click
        analiz_cari_hareket_detayli()
    End Sub
    Private Sub btn_ekle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbFirma_Ekle()
    End Sub
    Private Sub btn_sil_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If XtraMessageBox.Show(Sorgu_sDil("Kaydý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            tbFirma_sil(nHesapID)
        End If
    End Sub
    Private Sub btn_ara_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        firma_sec()
    End Sub
    Private Sub btn_firmahareket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_cari_hareket()
    End Sub
    Private Sub btn_FirmaBakiye_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_cari_bakiye()
    End Sub
    Private Sub btn_HareketGir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbFirmaHareketi()
    End Sub
    Private Sub btn_AciklamaGir_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        tbFirma_notlari()
    End Sub
    Private Sub btn_SonKod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbSonKod()
    End Sub
    Private Sub btn_StokluEkstre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_cari_hareket_detayli()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        firma_sec()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        tbFirma_Ekle()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_cari_hareket()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        analiz_cari_hareket_detayli()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_cari_bakiye()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        tbFirma_notlari()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Kaydý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            tbFirma_sil(nHesapID)
        End If
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        tbSonKod()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        tbFirmaHareketi()
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        tbSinif("tbHSinif")
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        Me.Close()
    End Sub
    Private Sub btn_yetkili_ekle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_yetkili_ekle.Click
        yetkili_ekle()
    End Sub
    Private Sub btn_yetkili_sil_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_yetkili_sil.Click
        yetkili_sil()
    End Sub
    Private Sub btn_yetkili_yazdir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_yetkili_yazdir.Click
        yetkili_yazdir()
    End Sub
    Private Sub btn_iletisim_ekle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_iletisim_ekle.Click
        iletisim_ekle()
    End Sub
    Private Sub btn_iletisim_sil_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_iletisim_sil.Click
        iletisim_sil()
    End Sub
    Private Sub btn_iletisim_yazdir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_iletisim_yazdir.Click
        iletisim_yazdir()
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        analiz_risk()
    End Sub

End Class
