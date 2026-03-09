Imports Microsoft.Win32
Imports System.IO
Imports DevExpress.XtraEditors
Imports System.Net
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Net.Http
Imports System.Net.Http.Headers
Public Class frm_stok_kart
    
    
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
    Friend WithEvents Panel_Alt As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelControl92 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_musteriNo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txt_sAdi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sKisaAdi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_bEksiyeDusulebilir As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_bEksiyeDusunceUyar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_lAsgariMiktar As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lAzamiMiktar As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nTeminSuresi As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nIskontoYuzdesiAV As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nIskontoYuzdesi As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_sMiktar As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnMusteriID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSinifKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sSinifKodu As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colsAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbSatisYapilamaz As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ds_tbStok As System.Data.DataSet
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
    Friend WithEvents ds_tbStokSinifi As System.Data.DataSet
    Friend WithEvents DataTable5 As System.Data.DataTable
    Friend WithEvents DataColumn37 As System.Data.DataColumn
    Friend WithEvents DataColumn38 As System.Data.DataColumn
    Friend WithEvents DataColumn39 As System.Data.DataColumn
    Friend WithEvents DataColumn40 As System.Data.DataColumn
    Friend WithEvents DataColumn41 As System.Data.DataColumn
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ds_tbStokAyYekunleri As System.Data.DataSet
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn31 As System.Data.DataColumn
    Friend WithEvents DataColumn32 As System.Data.DataColumn
    Friend WithEvents DataColumn33 As System.Data.DataColumn
    Friend WithEvents DataColumn34 As System.Data.DataColumn
    Friend WithEvents DataColumn35 As System.Data.DataColumn
    Friend WithEvents DataColumn36 As System.Data.DataColumn
    Friend WithEvents DataColumn42 As System.Data.DataColumn
    Friend WithEvents colsAy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsYil As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnGiris As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnGirisIade As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnCikis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnCikisIade As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKalan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ds_tbStokBakiyesi As System.Data.DataSet
    Friend WithEvents DataTable3 As System.Data.DataTable
    Friend WithEvents DataColumn43 As System.Data.DataColumn
    Friend WithEvents DataColumn44 As System.Data.DataColumn
    Friend WithEvents DataColumn45 As System.Data.DataColumn
    Friend WithEvents DataColumn46 As System.Data.DataColumn
    Friend WithEvents DataColumn47 As System.Data.DataColumn
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ds_tbStokAcilim As System.Data.DataSet
    Friend WithEvents DataTable4 As System.Data.DataTable
    Friend WithEvents DataColumn48 As System.Data.DataColumn
    Friend WithEvents DataColumn49 As System.Data.DataColumn
    Friend WithEvents DataColumn50 As System.Data.DataColumn
    Friend WithEvents DataColumn51 As System.Data.DataColumn
    Friend WithEvents DataColumn52 As System.Data.DataColumn
    Friend WithEvents DataColumn53 As System.Data.DataColumn
    Friend WithEvents DataColumn54 As System.Data.DataColumn
    Friend WithEvents fieldnStokID As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsModel As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsKodu As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsRenk As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsBeden As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldsKavala As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldnMevcut As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents txt_nFiyatlandirma As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_sOTVtipi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_sKdvTipi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_sAsortiTipi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_sBirimCinsi2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_sBirimCinsi1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GridControl3 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents kisayol_AyYekun As System.Windows.Forms.ContextMenu
    Friend WithEvents ps As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents printlink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents printlink2 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents fieldsRenkAdi As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents kisayol_rbk As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents txt_OTVvar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents kisayol_ana As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txt_sUzunNot As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ds_tbStokUzunNot As System.Data.DataSet
    Friend WithEvents DataTable6 As System.Data.DataTable
    Friend WithEvents DataColumn55 As System.Data.DataColumn
    Friend WithEvents DataColumn56 As System.Data.DataColumn
    Friend WithEvents DataColumn57 As System.Data.DataColumn
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ds_tbStokBarkodu As System.Data.DataSet
    Friend WithEvents DataTable7 As System.Data.DataTable
    Friend WithEvents DataColumn59 As System.Data.DataColumn
    Friend WithEvents DataColumn60 As System.Data.DataColumn
    Friend WithEvents DataColumn61 As System.Data.DataColumn
    Friend WithEvents DataColumn62 As System.Data.DataColumn
    Friend WithEvents DataColumn63 As System.Data.DataColumn
    Friend WithEvents DataColumn64 As System.Data.DataColumn
    Friend WithEvents colnStokID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBarkod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKisim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnFirmaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKarsiStokKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKarsiStokAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBeden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKavala As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kisayol_barkod As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BarkodAtaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GrnmYazdrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents printlink3 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents colsRenkAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sBarkod As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents sec_Siniflar As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents BarkodAtaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txt_tbStokTipi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ds_tbStokTutari As System.Data.DataSet
    Friend WithEvents DataTable8 As System.Data.DataTable
    Friend WithEvents DataColumn65 As System.Data.DataColumn
    Friend WithEvents DataColumn66 As System.Data.DataColumn
    Friend WithEvents DataColumn67 As System.Data.DataColumn
    Friend WithEvents DataColumn68 As System.Data.DataColumn
    Friend WithEvents DataColumn69 As System.Data.DataColumn
    Friend WithEvents TextEdit9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit12 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_BarkoduSil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_BarkodAtaAna As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_BarkodAtaEan8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_BarkodAtaEan13 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_BarkodAtaMuadil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabPage7 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colsFisTipi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteFisTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collGirisFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collCikisFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collGirisMiktar1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collCikisMiktar1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collDovizKuru1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBrutFiyat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collIskontoTutari As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnKdvOrani As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnGirisCikis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnAlisverisID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMAADI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIRMA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKALAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBrutTutar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStoksKodu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsModel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsStokAciklama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAvYapanAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsSaticiRumuzu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lBirimCarpan As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents DataColumn70 As System.Data.DataColumn
    Friend WithEvents DataColumn71 As System.Data.DataColumn
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nPrim As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton10 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton11 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabPage8 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ds_tbStokResim As System.Data.DataSet
    Friend WithEvents DataTable9 As System.Data.DataTable
    Friend WithEvents DataColumn72 As System.Data.DataColumn
    Friend WithEvents DataColumn73 As System.Data.DataColumn
    Friend WithEvents DataColumn74 As System.Data.DataColumn
    Friend WithEvents DataColumn75 As System.Data.DataColumn
    Friend WithEvents DataColumn76 As System.Data.DataColumn
    Friend WithEvents DataColumn77 As System.Data.DataColumn
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton13 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton12 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl6 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnStokResimID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsModel1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpResim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsAciklama2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKullaniciAdi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteKayitTarihi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnSira As DevExpress.XtraGrid.Columns.GridColumn
    ' YENİ KOLONLAR (nStokID ile gelen)
    Friend WithEvents colsKodu_Resim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsRenkAdi_Resim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsBeden_Resim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKavala_Resim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_pResim As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DataColumn78 As System.Data.DataColumn
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents XtraTabPage9 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_Alternatif_Yazdir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Alternatif_Sil As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Alternatif_Ekle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl7 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton14 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents SimpleButton15 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton16 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabPage10 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridControl8 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_sHesapPlani As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_nKisim As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sYeniKod As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents SimpleButton17 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton18 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton19 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colsBirimCinsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collBirimMiktar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton20 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Group_BarkodGir As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lBarkodMiktar As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents sec_sBarkodBirimCinsi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents sec_sBarkodTipi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btn_BarkodVazgec As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_BarkodKaydet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sBarkod As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents lbl_sBarkod As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_barcodestd As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_checkdigit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_sBirimCinsi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SimpleButton21 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btn_Listele As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_nBoy As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_nEn As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nYukseklik As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn79 As System.Data.DataColumn
    Friend WithEvents DataColumn80 As System.Data.DataColumn
    Friend WithEvents DataColumn81 As System.Data.DataColumn
    Friend WithEvents DataColumn82 As System.Data.DataColumn
    Friend WithEvents DataColumn83 As System.Data.DataColumn
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nAgirlik As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn84 As System.Data.DataColumn
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sDovizCinsi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_nHacim As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lbl_ara As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_BarkodAtaModel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarkodAtaStokKoduToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents txt_tbBedenTipi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BarButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txt_sAlisKdvTipi As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataColumn85 As System.Data.DataColumn
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents DataColumn86 As System.Data.DataColumn
    Friend WithEvents DataColumn87 As System.Data.DataColumn
    Friend WithEvents txt_nWebIskontoYuzdesi As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sec_bWebGoruntule As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DataColumn88 As System.Data.DataColumn
    Friend WithEvents sec_bWebTavsiye As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txt_nOIV As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_OIVVar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents DataColumn89 As System.Data.DataColumn
    Friend WithEvents DataColumn90 As System.Data.DataColumn
    Friend WithEvents sec_bTersOran As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnAIResimEkle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnAIAciklamaEkle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataColumn91 As System.Data.DataColumn
    Friend WithEvents DataColumn92 As System.Data.DataColumn
    Friend WithEvents DataColumn58 As System.Data.DataColumn
    Friend WithEvents ds_Sinif As System.Data.DataSet
    
    ' AI Sekmeleri - Dinamik olarak oluşturulacak
    Private XtraTabPage_SEOBaslik As DevExpress.XtraTab.XtraTabPage
    Private XtraTabPage_KullanimTalimati As DevExpress.XtraTab.XtraTabPage
    Private XtraTabPage_MetaAciklama As DevExpress.XtraTab.XtraTabPage
    Private XtraTabPage_FiyatOptimize As DevExpress.XtraTab.XtraTabPage
    
    Private btnSEOBaslikOlustur As DevExpress.XtraEditors.SimpleButton
    Private txtSEOBaslik As DevExpress.XtraEditors.MemoEdit
    Private lblSEOBaslikInfo As DevExpress.XtraEditors.LabelControl
    
    Private btnKullanimTalimatiOlustur As DevExpress.XtraEditors.SimpleButton
    Private txtKullanimTalimati As DevExpress.XtraEditors.MemoEdit
    Private lblKullanimTalimatiInfo As DevExpress.XtraEditors.LabelControl
    
    Private btnMetaAciklamaOlustur As DevExpress.XtraEditors.SimpleButton
    Private txtMetaAciklama As DevExpress.XtraEditors.MemoEdit
    Private lblMetaAciklamaInfo As DevExpress.XtraEditors.LabelControl
    
    Private btnKategoriOner As DevExpress.XtraEditors.SimpleButton
    
    Private btnFiyatOptimize As DevExpress.XtraEditors.SimpleButton
    Private txtFiyatOptimize As DevExpress.XtraEditors.MemoEdit
    Private lblFiyatOptimizeInfo As DevExpress.XtraEditors.LabelControl
    
    Private aiTabsInitialized As Boolean = False
    
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_kart))
        Dim SuperToolTip38 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem51 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem36 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem5 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip6 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem6 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem6 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip7 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem7 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem7 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip8 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem8 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem8 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip9 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem9 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem9 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem14 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem52 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip39 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem53 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem37 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem15 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem54 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip40 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem55 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem38 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem16 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem56 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip41 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem57 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem39 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem17 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem58 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip42 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem59 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem40 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem18 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem60 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip43 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem61 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem41 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem19 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem62 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip44 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem63 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem42 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem20 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem64 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip45 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem65 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem43 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem21 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem66 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip46 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem67 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem44 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem22 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem68 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip47 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem69 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem45 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem23 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem70 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip48 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem71 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem46 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem24 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem72 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip49 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem73 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem47 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip50 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem74 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem48 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip51 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem75 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem49 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip23 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem34 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem23 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip24 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem35 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem24 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip25 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem36 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem25 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip26 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem37 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem26 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip27 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem38 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem27 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip28 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem39 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem28 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip29 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem40 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem29 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip30 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem41 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem30 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip31 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem42 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip32 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem43 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem31 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim PivotGridCustomTotal2 As DevExpress.XtraPivotGrid.PivotGridCustomTotal = New DevExpress.XtraPivotGrid.PivotGridCustomTotal()
        Dim SuperToolTip33 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem44 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem32 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip34 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem45 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip35 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem46 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem33 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem25 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem76 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip52 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem77 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem50 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipSeparatorItem26 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
        Dim ToolTipTitleItem78 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel_Alt = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_ara = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.ds_tbStok = New System.Data.DataSet()
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
        Me.DataColumn70 = New System.Data.DataColumn()
        Me.DataColumn71 = New System.Data.DataColumn()
        Me.DataColumn79 = New System.Data.DataColumn()
        Me.DataColumn80 = New System.Data.DataColumn()
        Me.DataColumn81 = New System.Data.DataColumn()
        Me.DataColumn82 = New System.Data.DataColumn()
        Me.DataColumn83 = New System.Data.DataColumn()
        Me.DataColumn84 = New System.Data.DataColumn()
        Me.DataColumn85 = New System.Data.DataColumn()
        Me.DataColumn86 = New System.Data.DataColumn()
        Me.DataColumn87 = New System.Data.DataColumn()
        Me.DataColumn88 = New System.Data.DataColumn()
        Me.DataColumn89 = New System.Data.DataColumn()
        Me.DataColumn90 = New System.Data.DataColumn()
        Me.DataColumn91 = New System.Data.DataColumn()
        Me.LabelControl92 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_musteriNo = New DevExpress.XtraEditors.ButtonEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.sec_bTersOran = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_nOIV = New DevExpress.XtraEditors.SpinEdit()
        Me.txt_OIVVar = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_bWebTavsiye = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_nWebIskontoYuzdesi = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_bWebGoruntule = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_sAlisKdvTipi = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_tbBedenTipi = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_nHacim = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sDovizCinsi = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nAgirlik = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nYukseklik = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nBoy = New DevExpress.XtraEditors.SpinEdit()
        Me.txt_nEn = New DevExpress.XtraEditors.SpinEdit()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton17 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton18 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sYeniKod = New DevExpress.XtraEditors.ButtonEdit()
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
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nPrim = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_lBirimCarpan = New DevExpress.XtraEditors.CalcEdit()
        Me.txt_tbStokTipi = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nFiyatlandirma = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nIskontoYuzdesi = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nIskontoYuzdesiAV = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nTeminSuresi = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_lAzamiMiktar = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_lAsgariMiktar = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.sec_bEksiyeDusunceUyar = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_bEksiyeDusulebilir = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_sOTVtipi = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_OTVvar = New DevExpress.XtraEditors.CheckEdit()
        Me.txt_sKdvTipi = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sAsortiTipi = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sBirimCinsi2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sBirimCinsi1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sKisaAdi = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sAdi = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ds_tbStokSinifi = New System.Data.DataSet()
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
        Me.sec_Siniflar = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbSatisYapilamaz = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sSinifKodu = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_AyYekun = New System.Windows.Forms.ContextMenu()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.ds_tbStokAyYekunleri = New System.Data.DataSet()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn31 = New System.Data.DataColumn()
        Me.DataColumn32 = New System.Data.DataColumn()
        Me.DataColumn33 = New System.Data.DataColumn()
        Me.DataColumn34 = New System.Data.DataColumn()
        Me.DataColumn35 = New System.Data.DataColumn()
        Me.DataColumn36 = New System.Data.DataColumn()
        Me.DataColumn42 = New System.Data.DataColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsAy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsYil = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnGiris = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnGirisIade = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnCikis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnCikisIade = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKalan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl3 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.kisayol_rbk = New System.Windows.Forms.ContextMenu()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.ds_tbStokAcilim = New System.Data.DataSet()
        Me.DataTable4 = New System.Data.DataTable()
        Me.DataColumn48 = New System.Data.DataColumn()
        Me.DataColumn49 = New System.Data.DataColumn()
        Me.DataColumn50 = New System.Data.DataColumn()
        Me.DataColumn51 = New System.Data.DataColumn()
        Me.DataColumn52 = New System.Data.DataColumn()
        Me.DataColumn53 = New System.Data.DataColumn()
        Me.DataColumn54 = New System.Data.DataColumn()
        Me.fieldnStokID = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldsModel = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldsKodu = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldsRenk = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldsBeden = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldsKavala = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldnMevcut = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldsRenkAdi = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton21 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton15 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton16 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton10 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton11 = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.Group_BarkodGir = New DevExpress.XtraEditors.GroupControl()
        Me.lbl_barcodestd = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_checkdigit = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_sBarkod = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_lBarkodMiktar = New DevExpress.XtraEditors.SpinEdit()
        Me.sec_sBarkodBirimCinsi = New DevExpress.XtraEditors.LookUpEdit()
        Me.sec_sBarkodTipi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btn_BarkodVazgec = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_BarkodKaydet = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sBarkod = New DevExpress.XtraEditors.ButtonEdit()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.kisayol_barkod = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BarkodAtaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarkodAtaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarkodAtaStokKoduToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GrnmYazdrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ds_tbStokBarkodu = New System.Data.DataSet()
        Me.DataTable7 = New System.Data.DataTable()
        Me.DataColumn59 = New System.Data.DataColumn()
        Me.DataColumn60 = New System.Data.DataColumn()
        Me.DataColumn61 = New System.Data.DataColumn()
        Me.DataColumn62 = New System.Data.DataColumn()
        Me.DataColumn63 = New System.Data.DataColumn()
        Me.DataColumn64 = New System.Data.DataColumn()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnStokID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBarkod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sBarkod = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colnKisim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_nKisim = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colnFirmaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKarsiStokKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKarsiStokAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAciklama1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBeden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKavala = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenkAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBirimCinsi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sBirimCinsi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.collBirimMiktar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_BarkodAtaModel = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton20 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton19 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_BarkodAtaMuadil = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_BarkoduSil = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_BarkodAtaAna = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_BarkodAtaEan8 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_BarkodAtaEan13 = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.btnAIAciklamaEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_sUzunNot = New DevExpress.XtraEditors.MemoEdit()
        Me.ds_tbStokUzunNot = New System.Data.DataSet()
        Me.DataTable6 = New System.Data.DataTable()
        Me.DataColumn55 = New System.Data.DataColumn()
        Me.DataColumn56 = New System.Data.DataColumn()
        Me.DataColumn57 = New System.Data.DataColumn()
        Me.DataColumn58 = New System.Data.DataColumn()
        Me.XtraTabPage8 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl6 = New DevExpress.XtraGrid.GridControl()
        Me.ds_tbStokResim = New System.Data.DataSet()
        Me.DataTable9 = New System.Data.DataTable()
        Me.DataColumn72 = New System.Data.DataColumn()
        Me.DataColumn73 = New System.Data.DataColumn()
        Me.DataColumn74 = New System.Data.DataColumn()
        Me.DataColumn75 = New System.Data.DataColumn()
        Me.DataColumn76 = New System.Data.DataColumn()
        Me.DataColumn77 = New System.Data.DataColumn()
        Me.DataColumn78 = New System.Data.DataColumn()
        Me.DataColumn92 = New System.Data.DataColumn()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnStokResimID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsModel1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnSira = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKodu_Resim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsRenkAdi_Resim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBeden_Resim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKavala_Resim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpResim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_pResim = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.colsAciklama2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsKullaniciAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteKayitTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnAIResimEkle = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton13 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton9 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton12 = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage7 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl5 = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colsFisTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFisNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldteFisTarihi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collGirisFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collCikisFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collGirisMiktar1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collCikisMiktar1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collDovizKuru1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDovizCinsi1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBrutFiyat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collIskontoTutari = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnKdvOrani = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnGirisCikis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnAlisverisID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRMAADI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIRMA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKALAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collBrutTutar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStoksKodu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsModel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsStokAciklama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsAvYapanAdi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsSaticiRumuzu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_Listele = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.XtraTabPage9 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl7 = New DevExpress.XtraGrid.GridControl()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton14 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Alternatif_Yazdir = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Alternatif_Sil = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Alternatif_Ekle = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage10 = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl8 = New DevExpress.XtraGrid.GridControl()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_sHesapPlani = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
        Me.ds_tbStokBakiyesi = New System.Data.DataSet()
        Me.DataTable3 = New System.Data.DataTable()
        Me.DataColumn43 = New System.Data.DataColumn()
        Me.DataColumn44 = New System.Data.DataColumn()
        Me.DataColumn45 = New System.Data.DataColumn()
        Me.DataColumn46 = New System.Data.DataColumn()
        Me.DataColumn47 = New System.Data.DataColumn()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_sMiktar = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit8 = New DevExpress.XtraEditors.TextEdit()
        Me.ds_tbStokTutari = New System.Data.DataSet()
        Me.DataTable8 = New System.Data.DataTable()
        Me.DataColumn65 = New System.Data.DataColumn()
        Me.DataColumn66 = New System.Data.DataColumn()
        Me.DataColumn67 = New System.Data.DataColumn()
        Me.DataColumn68 = New System.Data.DataColumn()
        Me.DataColumn69 = New System.Data.DataColumn()
        Me.TextEdit9 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit10 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit11 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit12 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.printlink2 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.kisayol_ana = New System.Windows.Forms.ContextMenu()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.printlink3 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel_Alt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Alt.SuspendLayout()
        CType(Me.ds_tbStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sec_bTersOran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nOIV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_OIVVar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bWebTavsiye.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nWebIskontoYuzdesi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bWebGoruntule.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAlisKdvTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tbBedenTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nHacim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sDovizCinsi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nAgirlik.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nYukseklik.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nBoy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nEn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.txt_sYeniKod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nPrim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lBirimCarpan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tbStokTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nFiyatlandirma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nIskontoYuzdesi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nIskontoYuzdesiAV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nTeminSuresi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lAzamiMiktar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lAsgariMiktar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bEksiyeDusunceUyar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bEksiyeDusulebilir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sOTVtipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_OTVvar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sKdvTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAsortiTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sBirimCinsi2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sBirimCinsi1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sKisaAdi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sAdi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbStokSinifi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_Siniflar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sSinifKodu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbStokAyYekunleri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbStokAcilim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        Me.XtraTabPage6.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.Group_BarkodGir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_BarkodGir.SuspendLayout()
        CType(Me.txt_lBarkodMiktar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sBarkodBirimCinsi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sBarkodTipi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sBarkod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.kisayol_barkod.SuspendLayout()
        CType(Me.ds_tbStokBarkodu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sBarkod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_nKisim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sBirimCinsi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.txt_sUzunNot.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbStokUzunNot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage8.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.GridControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbStokResim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_pResim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.XtraTabPage7.SuspendLayout()
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage9.SuspendLayout()
        CType(Me.GridControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        Me.XtraTabPage10.SuspendLayout()
        CType(Me.GridControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_sHesapPlani, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbStokBakiyesi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbStokTutari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink2.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink3.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1367, 80)
        Me.PanelControl1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(154, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Stok Kart Tanımları Aşağıdadır..."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Panel_Alt
        '
        Me.Panel_Alt.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Panel_Alt.Appearance.Options.UseBackColor = True
        Me.Panel_Alt.Controls.Add(Me.lbl_ara)
        Me.Panel_Alt.Controls.Add(Me.LabelControl27)
        Me.Panel_Alt.Controls.Add(Me.LabelControl92)
        Me.Panel_Alt.Controls.Add(Me.txt_musteriNo)
        Me.Panel_Alt.Controls.Add(Me.SimpleButton2)
        Me.Panel_Alt.Controls.Add(Me.SimpleButton1)
        Me.Panel_Alt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Alt.Location = New System.Drawing.Point(0, 660)
        Me.Panel_Alt.Name = "Panel_Alt"
        Me.Panel_Alt.Size = New System.Drawing.Size(1367, 70)
        Me.Panel_Alt.TabIndex = 1
        '
        'lbl_ara
        '
        Me.lbl_ara.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_ara.Location = New System.Drawing.Point(118, 23)
        Me.lbl_ara.Name = "lbl_ara"
        Me.lbl_ara.Size = New System.Drawing.Size(9, 17)
        Me.lbl_ara.TabIndex = 68
        Me.lbl_ara.Text = "*"
        '
        'LabelControl27
        '
        Me.LabelControl27.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelControl27.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl27.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl27.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl27.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds_tbStok, "Table1.sAciklama", True))
        Me.LabelControl27.Location = New System.Drawing.Point(402, 24)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(11, 21)
        Me.LabelControl27.TabIndex = 67
        Me.LabelControl27.Text = "*"
        '
        'ds_tbStok
        '
        Me.ds_tbStok.DataSetName = "NewDataSet"
        Me.ds_tbStok.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbStok.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7, Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12, Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19, Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24, Me.DataColumn25, Me.DataColumn26, Me.DataColumn27, Me.DataColumn28, Me.DataColumn29, Me.DataColumn30, Me.DataColumn70, Me.DataColumn71, Me.DataColumn79, Me.DataColumn80, Me.DataColumn81, Me.DataColumn82, Me.DataColumn83, Me.DataColumn84, Me.DataColumn85, Me.DataColumn86, Me.DataColumn87, Me.DataColumn88, Me.DataColumn89, Me.DataColumn90, Me.DataColumn91})
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
        Me.DataColumn13.DataType = GetType(Decimal)
        '
        'DataColumn14
        '
        Me.DataColumn14.ColumnName = "sKdvTipi"
        '
        'DataColumn15
        '
        Me.DataColumn15.ColumnName = "nTeminSuresi"
        Me.DataColumn15.DataType = GetType(Long)
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
        Me.DataColumn18.ColumnName = "sOzelNot"
        '
        'DataColumn19
        '
        Me.DataColumn19.ColumnName = "nFiyatlandirma"
        Me.DataColumn19.DataType = GetType(Long)
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
        Me.DataColumn23.ColumnName = "bEksiyeDusulebilirmi"
        Me.DataColumn23.DataType = GetType(Boolean)
        '
        'DataColumn24
        '
        Me.DataColumn24.ColumnName = "sDefaultAsortiTipi"
        '
        'DataColumn25
        '
        Me.DataColumn25.ColumnName = "bEksideUyarsinmi"
        Me.DataColumn25.DataType = GetType(Boolean)
        '
        'DataColumn26
        '
        Me.DataColumn26.ColumnName = "bOTVVar"
        Me.DataColumn26.DataType = GetType(Boolean)
        '
        'DataColumn27
        '
        Me.DataColumn27.ColumnName = "sOTVTipi"
        '
        'DataColumn28
        '
        Me.DataColumn28.ColumnName = "nIskontoYuzdesiAV"
        Me.DataColumn28.DataType = GetType(Long)
        '
        'DataColumn29
        '
        Me.DataColumn29.ColumnName = "bEk1"
        Me.DataColumn29.DataType = GetType(Boolean)
        '
        'DataColumn30
        '
        Me.DataColumn30.ColumnName = "nEk2"
        Me.DataColumn30.DataType = GetType(Long)
        '
        'DataColumn70
        '
        Me.DataColumn70.ColumnName = "lBirimCarpan"
        Me.DataColumn70.DataType = GetType(Decimal)
        '
        'DataColumn71
        '
        Me.DataColumn71.ColumnName = "nPrim"
        Me.DataColumn71.DataType = GetType(Decimal)
        '
        'DataColumn79
        '
        Me.DataColumn79.ColumnName = "nEn"
        Me.DataColumn79.DataType = GetType(Decimal)
        '
        'DataColumn80
        '
        Me.DataColumn80.ColumnName = "nBoy"
        Me.DataColumn80.DataType = GetType(Decimal)
        '
        'DataColumn81
        '
        Me.DataColumn81.ColumnName = "nYukseklik"
        Me.DataColumn81.DataType = GetType(Decimal)
        '
        'DataColumn82
        '
        Me.DataColumn82.ColumnName = "nHacim"
        Me.DataColumn82.DataType = GetType(Decimal)
        '
        'DataColumn83
        '
        Me.DataColumn83.ColumnName = "nAgirlik"
        Me.DataColumn83.DataType = GetType(Decimal)
        '
        'DataColumn84
        '
        Me.DataColumn84.ColumnName = "sDovizCinsi"
        '
        'DataColumn85
        '
        Me.DataColumn85.ColumnName = "sAlisKdvTipi"
        '
        'DataColumn86
        '
        Me.DataColumn86.ColumnName = "bWebGoruntule"
        Me.DataColumn86.DataType = GetType(Boolean)
        '
        'DataColumn87
        '
        Me.DataColumn87.ColumnName = "nWebIskontoYuzdesi"
        Me.DataColumn87.DataType = GetType(Decimal)
        '
        'DataColumn88
        '
        Me.DataColumn88.ColumnName = "bWebTavsiye"
        Me.DataColumn88.DataType = GetType(Boolean)
        '
        'DataColumn89
        '
        Me.DataColumn89.ColumnName = "nOIV"
        Me.DataColumn89.DataType = GetType(Decimal)
        '
        'DataColumn90
        '
        Me.DataColumn90.ColumnName = "bOIVVar"
        Me.DataColumn90.DataType = GetType(Boolean)
        '
        'DataColumn91
        '
        Me.DataColumn91.Caption = "bTersOran"
        Me.DataColumn91.ColumnName = "bTersOran"
        Me.DataColumn91.DataType = GetType(Boolean)
        '
        'LabelControl92
        '
        Me.LabelControl92.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl92.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl92.Location = New System.Drawing.Point(59, 23)
        Me.LabelControl92.Name = "LabelControl92"
        Me.LabelControl92.Size = New System.Drawing.Size(48, 19)
        Me.LabelControl92.TabIndex = 66
        Me.LabelControl92.Text = "Model:"
        '
        'txt_musteriNo
        '
        Me.txt_musteriNo.Location = New System.Drawing.Point(149, 19)
        Me.txt_musteriNo.Name = "txt_musteriNo"
        Me.txt_musteriNo.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txt_musteriNo.Properties.Appearance.Options.UseForeColor = True
        Me.txt_musteriNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_musteriNo.Size = New System.Drawing.Size(243, 26)
        Me.txt_musteriNo.TabIndex = 0
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(1221, 19)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(120, 34)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1101, 19)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(120, 34)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "&Kaydet"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.XtraTabControl1)
        Me.PanelControl3.Controls.Add(Me.PanelControl4)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 80)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1367, 580)
        Me.PanelControl3.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.XtraTabControl1.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.Navy
        Me.XtraTabControl1.AppearancePage.HeaderActive.Options.UseFont = True
        Me.XtraTabControl1.AppearancePage.HeaderActive.Options.UseForeColor = True
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1363, 512)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage6, Me.XtraTabPage5, Me.XtraTabPage8, Me.XtraTabPage7, Me.XtraTabPage9, Me.XtraTabPage10})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GroupControl1)
        Me.XtraTabPage1.Image = CType(resources.GetObject("XtraTabPage1.Image"), System.Drawing.Image)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1361, 471)
        Me.XtraTabPage1.Text = "Genel"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sec_bTersOran)
        Me.GroupControl1.Controls.Add(Me.txt_nOIV)
        Me.GroupControl1.Controls.Add(Me.txt_OIVVar)
        Me.GroupControl1.Controls.Add(Me.sec_bWebTavsiye)
        Me.GroupControl1.Controls.Add(Me.txt_nWebIskontoYuzdesi)
        Me.GroupControl1.Controls.Add(Me.LabelControl40)
        Me.GroupControl1.Controls.Add(Me.sec_bWebGoruntule)
        Me.GroupControl1.Controls.Add(Me.txt_sAlisKdvTipi)
        Me.GroupControl1.Controls.Add(Me.LabelControl17)
        Me.GroupControl1.Controls.Add(Me.txt_tbBedenTipi)
        Me.GroupControl1.Controls.Add(Me.txt_nHacim)
        Me.GroupControl1.Controls.Add(Me.LabelControl38)
        Me.GroupControl1.Controls.Add(Me.txt_sDovizCinsi)
        Me.GroupControl1.Controls.Add(Me.LabelControl39)
        Me.GroupControl1.Controls.Add(Me.txt_nAgirlik)
        Me.GroupControl1.Controls.Add(Me.LabelControl37)
        Me.GroupControl1.Controls.Add(Me.LabelControl36)
        Me.GroupControl1.Controls.Add(Me.txt_nYukseklik)
        Me.GroupControl1.Controls.Add(Me.LabelControl35)
        Me.GroupControl1.Controls.Add(Me.LabelControl34)
        Me.GroupControl1.Controls.Add(Me.txt_nBoy)
        Me.GroupControl1.Controls.Add(Me.txt_nEn)
        Me.GroupControl1.Controls.Add(Me.GroupControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl26)
        Me.GroupControl1.Controls.Add(Me.LabelControl25)
        Me.GroupControl1.Controls.Add(Me.txt_nPrim)
        Me.GroupControl1.Controls.Add(Me.LabelControl24)
        Me.GroupControl1.Controls.Add(Me.txt_lBirimCarpan)
        Me.GroupControl1.Controls.Add(Me.txt_tbStokTipi)
        Me.GroupControl1.Controls.Add(Me.LabelControl22)
        Me.GroupControl1.Controls.Add(Me.LabelControl15)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.txt_nFiyatlandirma)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.txt_nIskontoYuzdesi)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.txt_nIskontoYuzdesiAV)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.txt_nTeminSuresi)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.txt_lAzamiMiktar)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.txt_lAsgariMiktar)
        Me.GroupControl1.Controls.Add(Me.LabelControl14)
        Me.GroupControl1.Controls.Add(Me.sec_bEksiyeDusunceUyar)
        Me.GroupControl1.Controls.Add(Me.sec_bEksiyeDusulebilir)
        Me.GroupControl1.Controls.Add(Me.txt_sOTVtipi)
        Me.GroupControl1.Controls.Add(Me.txt_OTVvar)
        Me.GroupControl1.Controls.Add(Me.txt_sKdvTipi)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.txt_sAsortiTipi)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txt_sBirimCinsi2)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txt_sBirimCinsi1)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txt_sKisaAdi)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.TextEdit1)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txt_sAdi)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1361, 471)
        Me.GroupControl1.TabIndex = 0
        '
        'sec_bTersOran
        '
        Me.sec_bTersOran.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.bTersOran", True))
        Me.sec_bTersOran.Location = New System.Drawing.Point(294, 111)
        Me.sec_bTersOran.Name = "sec_bTersOran"
        Me.sec_bTersOran.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_bTersOran.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_bTersOran.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_bTersOran.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_bTersOran.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_bTersOran.Properties.Caption = "Ters Oran"
        Me.sec_bTersOran.Size = New System.Drawing.Size(125, 24)
        Me.sec_bTersOran.TabIndex = 105
        '
        'txt_nOIV
        '
        Me.txt_nOIV.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.nOIV", True))
        Me.txt_nOIV.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nOIV.Enabled = False
        Me.txt_nOIV.EnterMoveNextControl = True
        Me.txt_nOIV.Location = New System.Drawing.Point(406, 224)
        Me.txt_nOIV.Name = "txt_nOIV"
        Me.txt_nOIV.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nOIV.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nOIV.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nOIV.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nOIV.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nOIV.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nOIV.Properties.MaxValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.txt_nOIV.Size = New System.Drawing.Size(93, 26)
        ToolTipTitleItem51.Text = "Asgari Miktar"
        ToolTipItem36.LeftIndent = 6
        SuperToolTip38.Items.Add(ToolTipTitleItem51)
        SuperToolTip38.Items.Add(ToolTipItem36)
        Me.txt_nOIV.SuperTip = SuperToolTip38
        Me.txt_nOIV.TabIndex = 104
        '
        'txt_OIVVar
        '
        Me.txt_OIVVar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.bOIVVar", True))
        Me.txt_OIVVar.Location = New System.Drawing.Point(293, 224)
        Me.txt_OIVVar.Name = "txt_OIVVar"
        Me.txt_OIVVar.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_OIVVar.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_OIVVar.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_OIVVar.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_OIVVar.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_OIVVar.Properties.Caption = "Ötv Var:"
        Me.txt_OIVVar.Size = New System.Drawing.Size(101, 24)
        Me.txt_OIVVar.TabIndex = 103
        '
        'sec_bWebTavsiye
        '
        Me.sec_bWebTavsiye.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.bWebTavsiye", True))
        Me.sec_bWebTavsiye.Location = New System.Drawing.Point(237, 307)
        Me.sec_bWebTavsiye.Name = "sec_bWebTavsiye"
        Me.sec_bWebTavsiye.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_bWebTavsiye.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_bWebTavsiye.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_bWebTavsiye.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_bWebTavsiye.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_bWebTavsiye.Properties.Caption = "Web'de Tavsiye Et"
        Me.sec_bWebTavsiye.Size = New System.Drawing.Size(205, 24)
        Me.sec_bWebTavsiye.TabIndex = 102
        '
        'txt_nWebIskontoYuzdesi
        '
        Me.txt_nWebIskontoYuzdesi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.nWebIskontoYuzdesi", True))
        Me.txt_nWebIskontoYuzdesi.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nWebIskontoYuzdesi.EnterMoveNextControl = True
        Me.txt_nWebIskontoYuzdesi.Location = New System.Drawing.Point(1173, 74)
        Me.txt_nWebIskontoYuzdesi.Name = "txt_nWebIskontoYuzdesi"
        Me.txt_nWebIskontoYuzdesi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nWebIskontoYuzdesi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nWebIskontoYuzdesi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nWebIskontoYuzdesi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nWebIskontoYuzdesi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nWebIskontoYuzdesi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nWebIskontoYuzdesi.Size = New System.Drawing.Size(93, 26)
        ToolTipTitleItem1.Text = "Perakende Iskonto"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Perakende Modlnde otomatik iskonto uygulamak icin kullanlr. Girilmis veri orannda" &
    " Perakende Satis modl rne iskonto uygulamaktadr."
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.txt_nWebIskontoYuzdesi.SuperTip = SuperToolTip1
        Me.txt_nWebIskontoYuzdesi.TabIndex = 100
        '
        'LabelControl40
        '
        Me.LabelControl40.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl40.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl40.Location = New System.Drawing.Point(1069, 80)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(95, 19)
        Me.LabelControl40.TabIndex = 101
        Me.LabelControl40.Text = "Web İskonto:"
        '
        'sec_bWebGoruntule
        '
        Me.sec_bWebGoruntule.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.bWebGoruntule", True))
        Me.sec_bWebGoruntule.Location = New System.Drawing.Point(22, 307)
        Me.sec_bWebGoruntule.Name = "sec_bWebGoruntule"
        Me.sec_bWebGoruntule.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_bWebGoruntule.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_bWebGoruntule.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_bWebGoruntule.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_bWebGoruntule.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_bWebGoruntule.Properties.Caption = "Web'de Görüntüle"
        Me.sec_bWebGoruntule.Size = New System.Drawing.Size(205, 24)
        Me.sec_bWebGoruntule.TabIndex = 99
        '
        'txt_sAlisKdvTipi
        '
        Me.txt_sAlisKdvTipi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.sAlisKdvTipi", True))
        Me.txt_sAlisKdvTipi.EnterMoveNextControl = True
        Me.txt_sAlisKdvTipi.Location = New System.Drawing.Point(374, 194)
        Me.txt_sAlisKdvTipi.Name = "txt_sAlisKdvTipi"
        Me.txt_sAlisKdvTipi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAlisKdvTipi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAlisKdvTipi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAlisKdvTipi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAlisKdvTipi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAlisKdvTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sAlisKdvTipi.Properties.DisplayMember = "nKdvOrani"
        Me.txt_sAlisKdvTipi.Properties.NullText = "[Kdv]"
        Me.txt_sAlisKdvTipi.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.txt_sAlisKdvTipi.Properties.ValueMember = "sKdvTipi"
        Me.txt_sAlisKdvTipi.Size = New System.Drawing.Size(125, 26)
        Me.txt_sAlisKdvTipi.TabIndex = 8
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl17.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl17.Location = New System.Drawing.Point(296, 194)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl17.TabIndex = 98
        Me.LabelControl17.Text = "Alış Kdv:"
        '
        'txt_tbBedenTipi
        '
        Me.txt_tbBedenTipi.AllowDrop = True
        Me.txt_tbBedenTipi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.sBedenTipi", True))
        Me.txt_tbBedenTipi.EnterMoveNextControl = True
        Me.txt_tbBedenTipi.Location = New System.Drawing.Point(971, 161)
        Me.txt_tbBedenTipi.Name = "txt_tbBedenTipi"
        Me.txt_tbBedenTipi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_tbBedenTipi.Properties.Appearance.Options.UseFont = True
        Me.txt_tbBedenTipi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_tbBedenTipi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_tbBedenTipi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_tbBedenTipi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_tbBedenTipi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_tbBedenTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_tbBedenTipi.Properties.DisplayMember = "sAciklama"
        Me.txt_tbBedenTipi.Properties.NullText = "[BedenTipleri]"
        Me.txt_tbBedenTipi.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.txt_tbBedenTipi.Properties.ValueMember = "sBedenTipi"
        Me.txt_tbBedenTipi.Size = New System.Drawing.Size(197, 28)
        ToolTipTitleItem2.Text = "BedenTipi"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Beden Tipleri Listesi"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.txt_tbBedenTipi.SuperTip = SuperToolTip2
        Me.txt_tbBedenTipi.TabIndex = 19
        '
        'txt_nHacim
        '
        Me.txt_nHacim.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.nAgirlik", True))
        Me.txt_nHacim.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nHacim.EnterMoveNextControl = True
        Me.txt_nHacim.Location = New System.Drawing.Point(1173, 224)
        Me.txt_nHacim.Name = "txt_nHacim"
        Me.txt_nHacim.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nHacim.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nHacim.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nHacim.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nHacim.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nHacim.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nHacim.Properties.DisplayFormat.FormatString = "#,0.##"
        Me.txt_nHacim.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_nHacim.Size = New System.Drawing.Size(93, 26)
        ToolTipTitleItem3.Text = "Azami Miktar"
        ToolTipItem3.LeftIndent = 6
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.txt_nHacim.SuperTip = SuperToolTip3
        Me.txt_nHacim.TabIndex = 24
        '
        'LabelControl38
        '
        Me.LabelControl38.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl38.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl38.Location = New System.Drawing.Point(1074, 287)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(24, 19)
        Me.LabelControl38.TabIndex = 96
        Me.LabelControl38.Text = "Pb:"
        '
        'txt_sDovizCinsi
        '
        Me.txt_sDovizCinsi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.sDovizCinsi", True))
        Me.txt_sDovizCinsi.EnterMoveNextControl = True
        Me.txt_sDovizCinsi.Location = New System.Drawing.Point(1112, 281)
        Me.txt_sDovizCinsi.Name = "txt_sDovizCinsi"
        Me.txt_sDovizCinsi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sDovizCinsi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sDovizCinsi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sDovizCinsi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sDovizCinsi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sDovizCinsi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sDovizCinsi.Properties.DisplayMember = "sDovizCinsi"
        Me.txt_sDovizCinsi.Properties.NullText = "[DovizCinsi]"
        Me.txt_sDovizCinsi.Properties.ValueMember = "sDovizCinsi"
        Me.txt_sDovizCinsi.Size = New System.Drawing.Size(154, 26)
        ToolTipTitleItem4.Text = "Satici"
        ToolTipItem4.LeftIndent = 6
        ToolTipItem4.Text = "Stok Filerinde ve Raporlarda geerli olmas istenen Satici Personel buradan seilir." &
    ""
        SuperToolTip4.Items.Add(ToolTipTitleItem4)
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.txt_sDovizCinsi.SuperTip = SuperToolTip4
        Me.txt_sDovizCinsi.TabIndex = 26
        '
        'LabelControl39
        '
        Me.LabelControl39.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl39.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl39.Location = New System.Drawing.Point(1096, 259)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(52, 19)
        Me.LabelControl39.TabIndex = 94
        Me.LabelControl39.Text = "Ağırlık:"
        '
        'txt_nAgirlik
        '
        Me.txt_nAgirlik.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.nAgirlik", True))
        Me.txt_nAgirlik.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nAgirlik.EnterMoveNextControl = True
        Me.txt_nAgirlik.Location = New System.Drawing.Point(1173, 253)
        Me.txt_nAgirlik.Name = "txt_nAgirlik"
        Me.txt_nAgirlik.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nAgirlik.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nAgirlik.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nAgirlik.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nAgirlik.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nAgirlik.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nAgirlik.Properties.DisplayFormat.FormatString = "#,0.##"
        Me.txt_nAgirlik.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_nAgirlik.Size = New System.Drawing.Size(93, 26)
        ToolTipTitleItem5.Text = "Azami Miktar"
        ToolTipItem5.LeftIndent = 6
        SuperToolTip5.Items.Add(ToolTipTitleItem5)
        SuperToolTip5.Items.Add(ToolTipItem5)
        Me.txt_nAgirlik.SuperTip = SuperToolTip5
        Me.txt_nAgirlik.TabIndex = 25
        '
        'LabelControl37
        '
        Me.LabelControl37.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl37.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl37.Location = New System.Drawing.Point(1096, 230)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(50, 19)
        Me.LabelControl37.TabIndex = 91
        Me.LabelControl37.Text = "Hacim:"
        '
        'LabelControl36
        '
        Me.LabelControl36.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl36.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl36.Location = New System.Drawing.Point(885, 284)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(72, 19)
        Me.LabelControl36.TabIndex = 90
        Me.LabelControl36.Text = "Yükseklik:"
        '
        'txt_nYukseklik
        '
        Me.txt_nYukseklik.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.nYukseklik", True))
        Me.txt_nYukseklik.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nYukseklik.EnterMoveNextControl = True
        Me.txt_nYukseklik.Location = New System.Drawing.Point(971, 281)
        Me.txt_nYukseklik.Name = "txt_nYukseklik"
        Me.txt_nYukseklik.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nYukseklik.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nYukseklik.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nYukseklik.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nYukseklik.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nYukseklik.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nYukseklik.Properties.DisplayFormat.FormatString = "#,0.##"
        Me.txt_nYukseklik.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_nYukseklik.Size = New System.Drawing.Size(93, 26)
        ToolTipTitleItem6.Text = "Asgari Miktar"
        ToolTipItem6.LeftIndent = 6
        SuperToolTip6.Items.Add(ToolTipTitleItem6)
        SuperToolTip6.Items.Add(ToolTipItem6)
        Me.txt_nYukseklik.SuperTip = SuperToolTip6
        Me.txt_nYukseklik.TabIndex = 23
        '
        'LabelControl35
        '
        Me.LabelControl35.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl35.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl35.Location = New System.Drawing.Point(923, 256)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(32, 19)
        Me.LabelControl35.TabIndex = 88
        Me.LabelControl35.Text = "Boy:"
        '
        'LabelControl34
        '
        Me.LabelControl34.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl34.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl34.Location = New System.Drawing.Point(933, 227)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(24, 19)
        Me.LabelControl34.TabIndex = 87
        Me.LabelControl34.Text = "En:"
        '
        'txt_nBoy
        '
        Me.txt_nBoy.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.nBoy", True))
        Me.txt_nBoy.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nBoy.EnterMoveNextControl = True
        Me.txt_nBoy.Location = New System.Drawing.Point(971, 253)
        Me.txt_nBoy.Name = "txt_nBoy"
        Me.txt_nBoy.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nBoy.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nBoy.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nBoy.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nBoy.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nBoy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nBoy.Properties.DisplayFormat.FormatString = "#,0.##"
        Me.txt_nBoy.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_nBoy.Size = New System.Drawing.Size(93, 26)
        ToolTipTitleItem7.Text = "Asgari Miktar"
        ToolTipItem7.LeftIndent = 6
        SuperToolTip7.Items.Add(ToolTipTitleItem7)
        SuperToolTip7.Items.Add(ToolTipItem7)
        Me.txt_nBoy.SuperTip = SuperToolTip7
        Me.txt_nBoy.TabIndex = 22
        '
        'txt_nEn
        '
        Me.txt_nEn.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.nEn", True))
        Me.txt_nEn.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nEn.EnterMoveNextControl = True
        Me.txt_nEn.Location = New System.Drawing.Point(971, 224)
        Me.txt_nEn.Name = "txt_nEn"
        Me.txt_nEn.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nEn.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nEn.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nEn.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nEn.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nEn.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nEn.Properties.DisplayFormat.FormatString = "#,0.##"
        Me.txt_nEn.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_nEn.Size = New System.Drawing.Size(93, 26)
        ToolTipTitleItem8.Text = "Asgari Miktar"
        ToolTipItem8.LeftIndent = 6
        SuperToolTip8.Items.Add(ToolTipTitleItem8)
        SuperToolTip8.Items.Add(ToolTipItem8)
        Me.txt_nEn.SuperTip = SuperToolTip8
        Me.txt_nEn.TabIndex = 21
        '
        'GroupControl6
        '
        Me.GroupControl6.Controls.Add(Me.SimpleButton17)
        Me.GroupControl6.Controls.Add(Me.SimpleButton18)
        Me.GroupControl6.Controls.Add(Me.LabelControl28)
        Me.GroupControl6.Controls.Add(Me.txt_sYeniKod)
        Me.GroupControl6.Location = New System.Drawing.Point(423, 268)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(422, 126)
        Me.GroupControl6.TabIndex = 84
        Me.GroupControl6.Text = "Kod_Deitir"
        Me.GroupControl6.Visible = False
        '
        'SimpleButton17
        '
        Me.SimpleButton17.Image = CType(resources.GetObject("SimpleButton17.Image"), System.Drawing.Image)
        Me.SimpleButton17.Location = New System.Drawing.Point(267, 81)
        Me.SimpleButton17.Name = "SimpleButton17"
        Me.SimpleButton17.Size = New System.Drawing.Size(120, 35)
        Me.SimpleButton17.TabIndex = 69
        Me.SimpleButton17.Text = "&Vazgeç"
        '
        'SimpleButton18
        '
        Me.SimpleButton18.Image = CType(resources.GetObject("SimpleButton18.Image"), System.Drawing.Image)
        Me.SimpleButton18.Location = New System.Drawing.Point(126, 81)
        Me.SimpleButton18.Name = "SimpleButton18"
        Me.SimpleButton18.Size = New System.Drawing.Size(132, 35)
        Me.SimpleButton18.TabIndex = 68
        Me.SimpleButton18.Text = "&Kaydet"
        '
        'LabelControl28
        '
        Me.LabelControl28.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl28.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl28.Location = New System.Drawing.Point(66, 46)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(48, 19)
        Me.LabelControl28.TabIndex = 67
        Me.LabelControl28.Text = "Model:"
        '
        'txt_sYeniKod
        '
        Me.txt_sYeniKod.Location = New System.Drawing.Point(126, 40)
        Me.txt_sYeniKod.MenuManager = Me.BarManager1
        Me.txt_sYeniKod.Name = "txt_sYeniKod"
        Me.txt_sYeniKod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_sYeniKod.Size = New System.Drawing.Size(261, 26)
        Me.txt_sYeniKod.TabIndex = 0
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem15})
        Me.BarManager1.MaxItemId = 15
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem7, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem9, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem10, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem11, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem12, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem13, True), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem14), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem15)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Ekle"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        ToolTipTitleItem9.Text = "Ekle"
        ToolTipItem9.LeftIndent = 6
        ToolTipItem9.Text = "Yeni Stok kayd Eklemek icin kullanilir."
        ToolTipTitleItem52.LeftIndent = 6
        ToolTipTitleItem52.Text = "Insert"
        SuperToolTip9.Items.Add(ToolTipTitleItem9)
        SuperToolTip9.Items.Add(ToolTipItem9)
        SuperToolTip9.Items.Add(ToolTipSeparatorItem14)
        SuperToolTip9.Items.Add(ToolTipTitleItem52)
        Me.BarButtonItem1.SuperTip = SuperToolTip9
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Kopyala"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K))
        Me.BarButtonItem2.Name = "BarButtonItem2"
        ToolTipTitleItem53.Text = "Kopyala"
        ToolTipItem37.LeftIndent = 6
        ToolTipItem37.Text = "Stok kart bilgilerini kullanarak yeni bir stok kart kaydi Amak icin kullanilir. s" &
    "eri olarak stoklar kopyalanabilir. Renk/Beden/Kavala kaydi girilmis stoklarda ba" &
    "rkodlar ve fiyatlar kopyalanmaz."
        ToolTipTitleItem54.LeftIndent = 6
        ToolTipTitleItem54.Text = "Ctrl+K"
        SuperToolTip39.Items.Add(ToolTipTitleItem53)
        SuperToolTip39.Items.Add(ToolTipItem37)
        SuperToolTip39.Items.Add(ToolTipSeparatorItem15)
        SuperToolTip39.Items.Add(ToolTipTitleItem54)
        Me.BarButtonItem2.SuperTip = SuperToolTip39
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Sil"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete))
        Me.BarButtonItem3.Name = "BarButtonItem3"
        ToolTipTitleItem55.Text = "Sil"
        ToolTipItem38.LeftIndent = 6
        ToolTipItem38.Text = "Stok Kart Kayd silmek icin kullanilir. Stok kartna bal barkodlar,fiyatlar ve stou" &
    "n serileri silinmektedir."
        ToolTipTitleItem56.LeftIndent = 6
        ToolTipTitleItem56.Text = "Ctrl+Delete"
        SuperToolTip40.Items.Add(ToolTipTitleItem55)
        SuperToolTip40.Items.Add(ToolTipItem38)
        SuperToolTip40.Items.Add(ToolTipSeparatorItem16)
        SuperToolTip40.Items.Add(ToolTipTitleItem56)
        Me.BarButtonItem3.SuperTip = SuperToolTip40
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Kod Degistir"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D))
        Me.BarButtonItem4.Name = "BarButtonItem4"
        ToolTipTitleItem57.Text = "Kod Degistir"
        ToolTipItem39.LeftIndent = 6
        ToolTipItem39.Text = "Stok Kodunu degistirmek icin kullanilir. Stok kartna bal model tanmlarda deimekte" &
    "dir. Renk/Bedenli stoklarda kullanmlmas nerilmez."
        ToolTipTitleItem58.LeftIndent = 6
        ToolTipTitleItem58.Text = "Ctrl+D"
        SuperToolTip41.Items.Add(ToolTipTitleItem57)
        SuperToolTip41.Items.Add(ToolTipItem39)
        SuperToolTip41.Items.Add(ToolTipSeparatorItem17)
        SuperToolTip41.Items.Add(ToolTipTitleItem58)
        Me.BarButtonItem4.SuperTip = SuperToolTip41
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Birim Çevir"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B))
        Me.BarButtonItem5.Name = "BarButtonItem5"
        ToolTipTitleItem59.Text = "Birim Cevrimi"
        ToolTipItem40.LeftIndent = 6
        ToolTipTitleItem60.LeftIndent = 6
        ToolTipTitleItem60.Text = "Ctrl+B"
        SuperToolTip42.Items.Add(ToolTipTitleItem59)
        SuperToolTip42.Items.Add(ToolTipItem40)
        SuperToolTip42.Items.Add(ToolTipSeparatorItem18)
        SuperToolTip42.Items.Add(ToolTipTitleItem60)
        Me.BarButtonItem5.SuperTip = SuperToolTip42
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Fiyatlandır"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
        Me.BarButtonItem6.Name = "BarButtonItem6"
        ToolTipTitleItem61.Text = "Stok Fiyatlandr"
        ToolTipItem41.LeftIndent = 6
        ToolTipTitleItem62.LeftIndent = 6
        ToolTipTitleItem62.Text = "Ctrl+F"
        SuperToolTip43.Items.Add(ToolTipTitleItem61)
        SuperToolTip43.Items.Add(ToolTipItem41)
        SuperToolTip43.Items.Add(ToolTipSeparatorItem19)
        SuperToolTip43.Items.Add(ToolTipTitleItem62)
        Me.BarButtonItem6.SuperTip = SuperToolTip43
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Notlar"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F9)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        ToolTipTitleItem63.Text = "Notlar"
        ToolTipItem42.LeftIndent = 6
        ToolTipItem42.Text = "Stok kartna ait Notlar listelenir. Stok listelendiginde veya secildiginde uyarilm" &
    "asini istediimiz notlar buraya kaydedilir."
        ToolTipTitleItem64.LeftIndent = 6
        ToolTipTitleItem64.Text = "F9"
        SuperToolTip44.Items.Add(ToolTipTitleItem63)
        SuperToolTip44.Items.Add(ToolTipItem42)
        SuperToolTip44.Items.Add(ToolTipSeparatorItem20)
        SuperToolTip44.Items.Add(ToolTipTitleItem64)
        Me.BarButtonItem7.SuperTip = SuperToolTip44
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Envanter"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.Name = "BarButtonItem8"
        ToolTipTitleItem65.Text = "Envanter"
        ToolTipItem43.LeftIndent = 6
        ToolTipTitleItem66.LeftIndent = 6
        ToolTipTitleItem66.Text = "F6"
        SuperToolTip45.Items.Add(ToolTipTitleItem65)
        SuperToolTip45.Items.Add(ToolTipItem43)
        SuperToolTip45.Items.Add(ToolTipSeparatorItem21)
        SuperToolTip45.Items.Add(ToolTipTitleItem66)
        Me.BarButtonItem8.SuperTip = SuperToolTip45
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Hareketler"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem9.Name = "BarButtonItem9"
        ToolTipTitleItem67.Text = "Hareketler"
        ToolTipItem44.LeftIndent = 6
        ToolTipTitleItem68.LeftIndent = 6
        ToolTipTitleItem68.Text = "F7"
        SuperToolTip46.Items.Add(ToolTipTitleItem67)
        SuperToolTip46.Items.Add(ToolTipItem44)
        SuperToolTip46.Items.Add(ToolTipSeparatorItem22)
        SuperToolTip46.Items.Add(ToolTipTitleItem68)
        Me.BarButtonItem9.SuperTip = SuperToolTip46
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Transferler"
        Me.BarButtonItem10.Id = 9
        Me.BarButtonItem10.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem10.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem10.Name = "BarButtonItem10"
        ToolTipTitleItem69.Text = "Transferler"
        ToolTipItem45.LeftIndent = 6
        ToolTipTitleItem70.LeftIndent = 6
        ToolTipTitleItem70.Text = "F8"
        SuperToolTip47.Items.Add(ToolTipTitleItem69)
        SuperToolTip47.Items.Add(ToolTipItem45)
        SuperToolTip47.Items.Add(ToolTipSeparatorItem23)
        SuperToolTip47.Items.Add(ToolTipTitleItem70)
        Me.BarButtonItem10.SuperTip = SuperToolTip47
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Sınıflar"
        Me.BarButtonItem11.Id = 10
        Me.BarButtonItem11.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem11.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem11.Name = "BarButtonItem11"
        ToolTipTitleItem71.Text = "Snflar"
        ToolTipItem46.LeftIndent = 6
        ToolTipTitleItem72.LeftIndent = 6
        ToolTipTitleItem72.Text = "F11"
        SuperToolTip48.Items.Add(ToolTipTitleItem71)
        SuperToolTip48.Items.Add(ToolTipItem46)
        SuperToolTip48.Items.Add(ToolTipSeparatorItem24)
        SuperToolTip48.Items.Add(ToolTipTitleItem72)
        Me.BarButtonItem11.SuperTip = SuperToolTip48
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Renkler"
        Me.BarButtonItem12.Id = 11
        Me.BarButtonItem12.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem12.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem12.Name = "BarButtonItem12"
        ToolTipTitleItem73.Text = "Renk"
        ToolTipItem47.LeftIndent = 6
        SuperToolTip49.Items.Add(ToolTipTitleItem73)
        SuperToolTip49.Items.Add(ToolTipItem47)
        Me.BarButtonItem12.SuperTip = SuperToolTip49
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "Bedenler"
        Me.BarButtonItem13.Id = 12
        Me.BarButtonItem13.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem13.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem13.Name = "BarButtonItem13"
        ToolTipTitleItem74.Text = "Bedenler"
        ToolTipItem48.LeftIndent = 6
        SuperToolTip50.Items.Add(ToolTipTitleItem74)
        SuperToolTip50.Items.Add(ToolTipItem48)
        Me.BarButtonItem13.SuperTip = SuperToolTip50
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "Çıkış"
        Me.BarButtonItem14.Id = 13
        Me.BarButtonItem14.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape)
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "Etiket,Ctrl+E"
        Me.BarButtonItem15.Id = 14
        Me.BarButtonItem15.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E))
        Me.BarButtonItem15.Name = "BarButtonItem15"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1367, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 730)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1367, 34)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 730)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1367, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 730)
        '
        'LabelControl26
        '
        Me.LabelControl26.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl26.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl26.Location = New System.Drawing.Point(296, 143)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(45, 19)
        Me.LabelControl26.TabIndex = 83
        Me.LabelControl26.Text = "İçerik:"
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl25.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl25.Location = New System.Drawing.Point(1096, 110)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(55, 19)
        Me.LabelControl25.TabIndex = 82
        Me.LabelControl25.Text = "Prim%:"
        '
        'txt_nPrim
        '
        Me.txt_nPrim.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.nPrim", True))
        Me.txt_nPrim.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nPrim.EnterMoveNextControl = True
        Me.txt_nPrim.Location = New System.Drawing.Point(1173, 104)
        Me.txt_nPrim.Name = "txt_nPrim"
        Me.txt_nPrim.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nPrim.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nPrim.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nPrim.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nPrim.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nPrim.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nPrim.Size = New System.Drawing.Size(93, 26)
        ToolTipTitleItem75.Text = "Toptan iskonto"
        ToolTipItem49.LeftIndent = 6
        SuperToolTip51.Items.Add(ToolTipTitleItem75)
        SuperToolTip51.Items.Add(ToolTipItem49)
        Me.txt_nPrim.SuperTip = SuperToolTip51
        Me.txt_nPrim.TabIndex = 17
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl24.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl24.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ds_tbStok, "Table1.sBirimCinsi1", True))
        Me.LabelControl24.Location = New System.Drawing.Point(504, 137)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(9, 19)
        Me.LabelControl24.TabIndex = 80
        Me.LabelControl24.Text = "*"
        '
        'txt_lBirimCarpan
        '
        Me.txt_lBirimCarpan.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.lBirimCarpan", True))
        Me.txt_lBirimCarpan.EnterMoveNextControl = True
        Me.txt_lBirimCarpan.Location = New System.Drawing.Point(374, 139)
        Me.txt_lBirimCarpan.Name = "txt_lBirimCarpan"
        Me.txt_lBirimCarpan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_lBirimCarpan.Size = New System.Drawing.Size(125, 26)
        ToolTipTitleItem34.Text = "Birimarpan"
        ToolTipItem23.LeftIndent = 6
        ToolTipItem23.Text = "2.Birim arpan Buraya Yazlr"
        SuperToolTip23.Items.Add(ToolTipTitleItem34)
        SuperToolTip23.Items.Add(ToolTipItem23)
        Me.txt_lBirimCarpan.SuperTip = SuperToolTip23
        Me.txt_lBirimCarpan.TabIndex = 5
        '
        'txt_tbStokTipi
        '
        Me.txt_tbStokTipi.AllowDrop = True
        Me.txt_tbStokTipi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.nStokTipi", True))
        Me.txt_tbStokTipi.EnterMoveNextControl = True
        Me.txt_tbStokTipi.Location = New System.Drawing.Point(971, 190)
        Me.txt_tbStokTipi.Name = "txt_tbStokTipi"
        Me.txt_tbStokTipi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_tbStokTipi.Properties.Appearance.Options.UseFont = True
        Me.txt_tbStokTipi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_tbStokTipi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_tbStokTipi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_tbStokTipi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_tbStokTipi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_tbStokTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_tbStokTipi.Properties.DisplayMember = "sAciklama"
        Me.txt_tbStokTipi.Properties.NullText = "[StokTipleri]"
        Me.txt_tbStokTipi.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.txt_tbStokTipi.Properties.ValueMember = "nStokTipi"
        Me.txt_tbStokTipi.Size = New System.Drawing.Size(197, 28)
        ToolTipTitleItem35.Text = "Stok Tipi"
        ToolTipItem24.LeftIndent = 6
        ToolTipItem24.Text = "Farkl Stok Tiplerinde ilemler yaplmaktadr." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Model" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Renkli" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Renk/Bedenli" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Renk/Bed" &
    "en/Kavala" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hizmet (""Maliyet ve Karllk Hesaplanmaz"")" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pasif (""Pasif Stoklar Liste" &
    "lenmez,Islem Grmez"")"
        SuperToolTip24.Items.Add(ToolTipTitleItem35)
        SuperToolTip24.Items.Add(ToolTipItem24)
        Me.txt_tbStokTipi.SuperTip = SuperToolTip24
        Me.txt_tbStokTipi.TabIndex = 20
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl22.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl22.Location = New System.Drawing.Point(888, 193)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(69, 19)
        Me.LabelControl22.TabIndex = 78
        Me.LabelControl22.Text = "Stok Tipi:"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl15.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl15.Location = New System.Drawing.Point(1168, 166)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(83, 19)
        Me.LabelControl15.TabIndex = 77
        Me.LabelControl15.Text = "Kavala Tipi:"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl13.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl13.Location = New System.Drawing.Point(874, 164)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(81, 19)
        Me.LabelControl13.TabIndex = 76
        Me.LabelControl13.Text = "Beden Tipi:"
        '
        'txt_nFiyatlandirma
        '
        Me.txt_nFiyatlandirma.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.nFiyatlandirma", True))
        Me.txt_nFiyatlandirma.EnterMoveNextControl = True
        Me.txt_nFiyatlandirma.Location = New System.Drawing.Point(971, 133)
        Me.txt_nFiyatlandirma.Name = "txt_nFiyatlandirma"
        Me.txt_nFiyatlandirma.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_nFiyatlandirma.Properties.Appearance.Options.UseFont = True
        Me.txt_nFiyatlandirma.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nFiyatlandirma.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nFiyatlandirma.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nFiyatlandirma.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nFiyatlandirma.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nFiyatlandirma.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_nFiyatlandirma.Properties.DisplayMember = "sAciklama"
        Me.txt_nFiyatlandirma.Properties.NullText = "[Fiyatlandrma]"
        Me.txt_nFiyatlandirma.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.txt_nFiyatlandirma.Properties.ValueMember = "nFiyatlandirma"
        Me.txt_nFiyatlandirma.Size = New System.Drawing.Size(295, 28)
        ToolTipTitleItem36.Text = "Stok Fiyatlandrma Modelleri"
        ToolTipItem25.LeftIndent = 6
        SuperToolTip25.Items.Add(ToolTipTitleItem36)
        SuperToolTip25.Items.Add(ToolTipItem25)
        Me.txt_nFiyatlandirma.SuperTip = SuperToolTip25
        Me.txt_nFiyatlandirma.TabIndex = 18
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl12.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl12.Location = New System.Drawing.Point(850, 136)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(101, 19)
        Me.LabelControl12.TabIndex = 75
        Me.LabelControl12.Text = "Fiyatlandırma:"
        '
        'txt_nIskontoYuzdesi
        '
        Me.txt_nIskontoYuzdesi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.nIskontoYuzdesi", True))
        Me.txt_nIskontoYuzdesi.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nIskontoYuzdesi.EnterMoveNextControl = True
        Me.txt_nIskontoYuzdesi.Location = New System.Drawing.Point(971, 104)
        Me.txt_nIskontoYuzdesi.Name = "txt_nIskontoYuzdesi"
        Me.txt_nIskontoYuzdesi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nIskontoYuzdesi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nIskontoYuzdesi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nIskontoYuzdesi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nIskontoYuzdesi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nIskontoYuzdesi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nIskontoYuzdesi.Size = New System.Drawing.Size(93, 26)
        ToolTipTitleItem37.Text = "Toptan iskonto"
        ToolTipItem26.LeftIndent = 6
        SuperToolTip26.Items.Add(ToolTipTitleItem37)
        SuperToolTip26.Items.Add(ToolTipItem26)
        Me.txt_nIskontoYuzdesi.SuperTip = SuperToolTip26
        Me.txt_nIskontoYuzdesi.TabIndex = 16
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl11.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl11.Location = New System.Drawing.Point(835, 107)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(114, 19)
        Me.LabelControl11.TabIndex = 73
        Me.LabelControl11.Text = "Toptan İskonto:"
        '
        'txt_nIskontoYuzdesiAV
        '
        Me.txt_nIskontoYuzdesiAV.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.nIskontoYuzdesiAV", True))
        Me.txt_nIskontoYuzdesiAV.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nIskontoYuzdesiAV.EnterMoveNextControl = True
        Me.txt_nIskontoYuzdesiAV.Location = New System.Drawing.Point(971, 76)
        Me.txt_nIskontoYuzdesiAV.Name = "txt_nIskontoYuzdesiAV"
        Me.txt_nIskontoYuzdesiAV.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nIskontoYuzdesiAV.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nIskontoYuzdesiAV.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nIskontoYuzdesiAV.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nIskontoYuzdesiAV.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nIskontoYuzdesiAV.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nIskontoYuzdesiAV.Size = New System.Drawing.Size(93, 26)
        ToolTipTitleItem38.Text = "Perakende Iskonto"
        ToolTipItem27.LeftIndent = 6
        ToolTipItem27.Text = "Perakende Modlnde otomatik iskonto uygulamak icin kullanlr. Girilmis veri orannda" &
    " Perakende Satis modl rne iskonto uygulamaktadr."
        SuperToolTip27.Items.Add(ToolTipTitleItem38)
        SuperToolTip27.Items.Add(ToolTipItem27)
        Me.txt_nIskontoYuzdesiAV.SuperTip = SuperToolTip27
        Me.txt_nIskontoYuzdesiAV.TabIndex = 15
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl10.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl10.Location = New System.Drawing.Point(808, 79)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(137, 19)
        Me.LabelControl10.TabIndex = 71
        Me.LabelControl10.Text = "Perakende İskonto:"
        '
        'txt_nTeminSuresi
        '
        Me.txt_nTeminSuresi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.nTeminSuresi", True))
        Me.txt_nTeminSuresi.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_nTeminSuresi.EnterMoveNextControl = True
        Me.txt_nTeminSuresi.Location = New System.Drawing.Point(971, 47)
        Me.txt_nTeminSuresi.Name = "txt_nTeminSuresi"
        Me.txt_nTeminSuresi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nTeminSuresi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_nTeminSuresi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_nTeminSuresi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_nTeminSuresi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_nTeminSuresi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_nTeminSuresi.Size = New System.Drawing.Size(93, 26)
        ToolTipTitleItem39.Text = "Temin Sresi"
        ToolTipItem28.LeftIndent = 6
        SuperToolTip28.Items.Add(ToolTipTitleItem39)
        SuperToolTip28.Items.Add(ToolTipItem28)
        Me.txt_nTeminSuresi.SuperTip = SuperToolTip28
        Me.txt_nTeminSuresi.TabIndex = 14
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl9.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl9.Location = New System.Drawing.Point(856, 50)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(99, 19)
        Me.LabelControl9.TabIndex = 69
        Me.LabelControl9.Text = "Temin Süresi:"
        '
        'txt_lAzamiMiktar
        '
        Me.txt_lAzamiMiktar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.lAzamiMiktar", True))
        Me.txt_lAzamiMiktar.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_lAzamiMiktar.EnterMoveNextControl = True
        Me.txt_lAzamiMiktar.Location = New System.Drawing.Point(1173, 19)
        Me.txt_lAzamiMiktar.Name = "txt_lAzamiMiktar"
        Me.txt_lAzamiMiktar.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lAzamiMiktar.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lAzamiMiktar.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lAzamiMiktar.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lAzamiMiktar.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lAzamiMiktar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_lAzamiMiktar.Size = New System.Drawing.Size(93, 26)
        ToolTipTitleItem40.Text = "Azami Miktar"
        ToolTipItem29.LeftIndent = 6
        SuperToolTip29.Items.Add(ToolTipTitleItem40)
        SuperToolTip29.Items.Add(ToolTipItem29)
        Me.txt_lAzamiMiktar.SuperTip = SuperToolTip29
        Me.txt_lAzamiMiktar.TabIndex = 13
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.Location = New System.Drawing.Point(1066, 23)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(98, 19)
        Me.LabelControl8.TabIndex = 67
        Me.LabelControl8.Text = "Azami Miktar:"
        '
        'txt_lAsgariMiktar
        '
        Me.txt_lAsgariMiktar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.lAsgariMiktar", True))
        Me.txt_lAsgariMiktar.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_lAsgariMiktar.EnterMoveNextControl = True
        Me.txt_lAsgariMiktar.Location = New System.Drawing.Point(971, 19)
        Me.txt_lAsgariMiktar.Name = "txt_lAsgariMiktar"
        Me.txt_lAsgariMiktar.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lAsgariMiktar.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lAsgariMiktar.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lAsgariMiktar.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lAsgariMiktar.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lAsgariMiktar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_lAsgariMiktar.Size = New System.Drawing.Size(93, 26)
        ToolTipTitleItem41.Text = "Asgari Miktar"
        ToolTipItem30.LeftIndent = 6
        SuperToolTip30.Items.Add(ToolTipTitleItem41)
        SuperToolTip30.Items.Add(ToolTipItem30)
        Me.txt_lAsgariMiktar.SuperTip = SuperToolTip30
        Me.txt_lAsgariMiktar.TabIndex = 12
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl14.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl14.Location = New System.Drawing.Point(853, 21)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(99, 19)
        Me.LabelControl14.TabIndex = 65
        Me.LabelControl14.Text = "Asgari Miktar:"
        '
        'sec_bEksiyeDusunceUyar
        '
        Me.sec_bEksiyeDusunceUyar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.bEksideUyarsinmi", True))
        Me.sec_bEksiyeDusunceUyar.Location = New System.Drawing.Point(125, 279)
        Me.sec_bEksiyeDusunceUyar.Name = "sec_bEksiyeDusunceUyar"
        Me.sec_bEksiyeDusunceUyar.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_bEksiyeDusunceUyar.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_bEksiyeDusunceUyar.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_bEksiyeDusunceUyar.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_bEksiyeDusunceUyar.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_bEksiyeDusunceUyar.Properties.Caption = "Eksiye Düşünce Uyar"
        Me.sec_bEksiyeDusunceUyar.Size = New System.Drawing.Size(205, 24)
        Me.sec_bEksiyeDusunceUyar.TabIndex = 11
        '
        'sec_bEksiyeDusulebilir
        '
        Me.sec_bEksiyeDusulebilir.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.bEksiyeDusulebilirmi", True))
        Me.sec_bEksiyeDusulebilir.Location = New System.Drawing.Point(125, 251)
        Me.sec_bEksiyeDusulebilir.Name = "sec_bEksiyeDusulebilir"
        Me.sec_bEksiyeDusulebilir.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_bEksiyeDusulebilir.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_bEksiyeDusulebilir.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_bEksiyeDusulebilir.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_bEksiyeDusulebilir.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_bEksiyeDusulebilir.Properties.Caption = "Eksiye Düşebilir"
        Me.sec_bEksiyeDusulebilir.Size = New System.Drawing.Size(166, 24)
        Me.sec_bEksiyeDusulebilir.TabIndex = 10
        '
        'txt_sOTVtipi
        '
        Me.txt_sOTVtipi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.sOTVTipi", True))
        Me.txt_sOTVtipi.EnterMoveNextControl = True
        Me.txt_sOTVtipi.Location = New System.Drawing.Point(128, 223)
        Me.txt_sOTVtipi.Name = "txt_sOTVtipi"
        Me.txt_sOTVtipi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sOTVtipi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sOTVtipi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sOTVtipi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sOTVtipi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sOTVtipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sOTVtipi.Properties.DisplayMember = "sOTVTipi"
        Me.txt_sOTVtipi.Properties.NullText = "[OTV]"
        Me.txt_sOTVtipi.Properties.ReadOnly = True
        Me.txt_sOTVtipi.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.txt_sOTVtipi.Properties.ValueMember = "sOTVTipi"
        Me.txt_sOTVtipi.Size = New System.Drawing.Size(160, 26)
        Me.txt_sOTVtipi.TabIndex = 9
        '
        'txt_OTVvar
        '
        Me.txt_OTVvar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.bOTVVar", True))
        Me.txt_OTVvar.Location = New System.Drawing.Point(22, 223)
        Me.txt_OTVvar.Name = "txt_OTVvar"
        Me.txt_OTVvar.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_OTVvar.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_OTVvar.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_OTVvar.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_OTVvar.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_OTVvar.Properties.Caption = "Ötv Var:"
        Me.txt_OTVvar.Size = New System.Drawing.Size(101, 24)
        Me.txt_OTVvar.TabIndex = 8
        '
        'txt_sKdvTipi
        '
        Me.txt_sKdvTipi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.sKdvTipi", True))
        Me.txt_sKdvTipi.EnterMoveNextControl = True
        Me.txt_sKdvTipi.Location = New System.Drawing.Point(128, 194)
        Me.txt_sKdvTipi.Name = "txt_sKdvTipi"
        Me.txt_sKdvTipi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKdvTipi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKdvTipi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKdvTipi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKdvTipi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKdvTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sKdvTipi.Properties.DisplayMember = "nKdvOrani"
        Me.txt_sKdvTipi.Properties.NullText = "[Kdv]"
        Me.txt_sKdvTipi.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.txt_sKdvTipi.Properties.ValueMember = "sKdvTipi"
        Me.txt_sKdvTipi.Size = New System.Drawing.Size(160, 26)
        Me.txt_sKdvTipi.TabIndex = 7
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.Location = New System.Drawing.Point(40, 199)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(70, 19)
        Me.LabelControl7.TabIndex = 58
        Me.LabelControl7.Text = "Satış Kdv:"
        '
        'txt_sAsortiTipi
        '
        Me.txt_sAsortiTipi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.sDefaultAsortiTipi", True))
        Me.txt_sAsortiTipi.EnterMoveNextControl = True
        Me.txt_sAsortiTipi.Location = New System.Drawing.Point(128, 166)
        Me.txt_sAsortiTipi.Name = "txt_sAsortiTipi"
        Me.txt_sAsortiTipi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAsortiTipi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAsortiTipi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAsortiTipi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAsortiTipi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAsortiTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sAsortiTipi.Properties.DisplayMember = "sAsortiTipi"
        Me.txt_sAsortiTipi.Properties.NullText = "[Asorti]"
        Me.txt_sAsortiTipi.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.txt_sAsortiTipi.Properties.ValueMember = "sAsortiTipi"
        Me.txt_sAsortiTipi.Size = New System.Drawing.Size(160, 26)
        Me.txt_sAsortiTipi.TabIndex = 6
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl6.Location = New System.Drawing.Point(35, 166)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(80, 19)
        Me.LabelControl6.TabIndex = 56
        Me.LabelControl6.Text = "Asorti Tipi:"
        '
        'txt_sBirimCinsi2
        '
        Me.txt_sBirimCinsi2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.sBirimCinsi2", True))
        Me.txt_sBirimCinsi2.EnterMoveNextControl = True
        Me.txt_sBirimCinsi2.Location = New System.Drawing.Point(128, 137)
        Me.txt_sBirimCinsi2.Name = "txt_sBirimCinsi2"
        Me.txt_sBirimCinsi2.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sBirimCinsi2.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sBirimCinsi2.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sBirimCinsi2.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sBirimCinsi2.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sBirimCinsi2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sBirimCinsi2.Properties.DisplayMember = "sBirimCinsi"
        Me.txt_sBirimCinsi2.Properties.NullText = "[Birim]"
        Me.txt_sBirimCinsi2.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.txt_sBirimCinsi2.Properties.ValueMember = "sBirimCinsi"
        Me.txt_sBirimCinsi2.Size = New System.Drawing.Size(160, 26)
        Me.txt_sBirimCinsi2.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(54, 137)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(62, 19)
        Me.LabelControl5.TabIndex = 54
        Me.LabelControl5.Text = "2. Birim:"
        '
        'txt_sBirimCinsi1
        '
        Me.txt_sBirimCinsi1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.sBirimCinsi1", True))
        Me.txt_sBirimCinsi1.EnterMoveNextControl = True
        Me.txt_sBirimCinsi1.Location = New System.Drawing.Point(128, 109)
        Me.txt_sBirimCinsi1.Name = "txt_sBirimCinsi1"
        Me.txt_sBirimCinsi1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sBirimCinsi1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sBirimCinsi1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sBirimCinsi1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sBirimCinsi1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sBirimCinsi1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_sBirimCinsi1.Properties.DisplayMember = "sBirimCinsi"
        Me.txt_sBirimCinsi1.Properties.NullText = "[Birim]"
        Me.txt_sBirimCinsi1.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.txt_sBirimCinsi1.Properties.ValueMember = "sBirimCinsi"
        Me.txt_sBirimCinsi1.Size = New System.Drawing.Size(160, 26)
        ToolTipTitleItem42.Text = "Ana Birim"
        SuperToolTip31.Items.Add(ToolTipTitleItem42)
        Me.txt_sBirimCinsi1.SuperTip = SuperToolTip31
        Me.txt_sBirimCinsi1.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Location = New System.Drawing.Point(40, 109)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(76, 19)
        Me.LabelControl4.TabIndex = 52
        Me.LabelControl4.Text = "Ana Birim:"
        '
        'txt_sKisaAdi
        '
        Me.txt_sKisaAdi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.sKisaAdi", True))
        Me.txt_sKisaAdi.EnterMoveNextControl = True
        Me.txt_sKisaAdi.Location = New System.Drawing.Point(128, 80)
        Me.txt_sKisaAdi.Name = "txt_sKisaAdi"
        Me.txt_sKisaAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKisaAdi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sKisaAdi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sKisaAdi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sKisaAdi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sKisaAdi.Properties.MaxLength = 20
        Me.txt_sKisaAdi.Size = New System.Drawing.Size(390, 26)
        ToolTipTitleItem43.Text = "Kisa Adi"
        ToolTipItem31.LeftIndent = 6
        SuperToolTip32.Items.Add(ToolTipTitleItem43)
        SuperToolTip32.Items.Add(ToolTipItem31)
        Me.txt_sKisaAdi.SuperTip = SuperToolTip32
        Me.txt_sKisaAdi.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl2.Location = New System.Drawing.Point(51, 80)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl2.TabIndex = 50
        Me.LabelControl2.Text = "Kýsa Ad:"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.sOzelNot", True))
        Me.TextEdit1.EnterMoveNextControl = True
        Me.TextEdit1.Location = New System.Drawing.Point(128, 51)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit1.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit1.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit1.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit1.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit1.Properties.MaxLength = 60
        Me.TextEdit1.Size = New System.Drawing.Size(582, 26)
        Me.TextEdit1.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl1.Location = New System.Drawing.Point(45, 51)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(67, 19)
        Me.LabelControl1.TabIndex = 48
        Me.LabelControl1.Text = "Özel Not:"
        '
        'txt_sAdi
        '
        Me.txt_sAdi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.sAciklama", True))
        Me.txt_sAdi.EnterMoveNextControl = True
        Me.txt_sAdi.Location = New System.Drawing.Point(128, 23)
        Me.txt_sAdi.Name = "txt_sAdi"
        Me.txt_sAdi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAdi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_sAdi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_sAdi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_sAdi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_sAdi.Properties.MaxLength = 60
        Me.txt_sAdi.Size = New System.Drawing.Size(582, 26)
        Me.txt_sAdi.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl3.Location = New System.Drawing.Point(86, 23)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(26, 19)
        Me.LabelControl3.TabIndex = 46
        Me.LabelControl3.Text = "Ad:"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GridControl1)
        Me.XtraTabPage2.Image = CType(resources.GetObject("XtraTabPage2.Image"), System.Drawing.Image)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1361, 471)
        Me.XtraTabPage2.Text = "Sınıflar"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.ds_tbStokSinifi
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sSinifKodu, Me.sec_Siniflar})
        Me.GridControl1.Size = New System.Drawing.Size(1361, 471)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ds_tbStokSinifi
        '
        Me.ds_tbStokSinifi.DataSetName = "NewDataSet"
        Me.ds_tbStokSinifi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbStokSinifi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable5})
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
        Me.GridView1.GroupPanelText = "Gruplamak stediiniz Kolonu Buraya Srkleyiniz..."
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
        Me.colnMusteriID.Caption = "Müşteri ID"
        Me.colnMusteriID.FieldName = "nMusteriID"
        Me.colnMusteriID.Name = "colnMusteriID"
        Me.colnMusteriID.OptionsColumn.AllowEdit = False
        Me.colnMusteriID.OptionsColumn.AllowFocus = False
        '
        'colsSinifTipi
        '
        Me.colsSinifTipi.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.colsSinifTipi.AppearanceCell.Options.UseFont = True
        Me.colsSinifTipi.Caption = "Sınıf Tipi"
        Me.colsSinifTipi.FieldName = "sSinifTipi"
        Me.colsSinifTipi.Name = "colsSinifTipi"
        Me.colsSinifTipi.OptionsColumn.AllowEdit = False
        Me.colsSinifTipi.OptionsColumn.AllowFocus = False
        Me.colsSinifTipi.Visible = True
        Me.colsSinifTipi.VisibleIndex = 0
        '
        'colsSinifKodu
        '
        Me.colsSinifKodu.Caption = "Snf"
        Me.colsSinifKodu.ColumnEdit = Me.sec_Siniflar
        Me.colsSinifKodu.FieldName = "sSinifKodu"
        Me.colsSinifKodu.Name = "colsSinifKodu"
        Me.colsSinifKodu.Visible = True
        Me.colsSinifKodu.VisibleIndex = 1
        '
        'sec_Siniflar
        '
        Me.sec_Siniflar.AutoHeight = False
        Me.sec_Siniflar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_Siniflar.DisplayMember = "sSinifKodu"
        Me.sec_Siniflar.Name = "sec_Siniflar"
        Me.sec_Siniflar.NullText = ""
        Me.sec_Siniflar.ValueMember = "sSinifKodu"
        Me.sec_Siniflar.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsBehavior.Editable = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.EnableAppearanceEvenRow = True
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowIndicator = False
        '
        'colsAciklama
        '
        Me.colsAciklama.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.colsAciklama.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colsAciklama.AppearanceCell.Options.UseFont = True
        Me.colsAciklama.AppearanceCell.Options.UseForeColor = True
        Me.colsAciklama.Caption = "Açıklama"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.OptionsColumn.AllowEdit = False
        Me.colsAciklama.OptionsColumn.AllowFocus = False
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 2
        '
        'colbSatisYapilamaz
        '
        Me.colbSatisYapilamaz.Caption = "Satış Yapılamaz"
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
        Me.sec_sSinifKodu.NullText = "[Snflar]"
        Me.sec_sSinifKodu.ValueMember = "sSinifKodu"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.GridControl2)
        Me.XtraTabPage3.Image = CType(resources.GetObject("XtraTabPage3.Image"), System.Drawing.Image)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1357, 476)
        Me.XtraTabPage3.Text = "Aylık Toplamlar"
        '
        'GridControl2
        '
        Me.GridControl2.ContextMenu = Me.kisayol_AyYekun
        Me.GridControl2.DataMember = "Table1"
        Me.GridControl2.DataSource = Me.ds_tbStokAyYekunleri
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(1357, 476)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'kisayol_AyYekun
        '
        Me.kisayol_AyYekun.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem3, Me.MenuItem2})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.MenuItem1.Text = "Gster"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem2.Text = "Grnm Yazdr"
        '
        'ds_tbStokAyYekunleri
        '
        Me.ds_tbStokAyYekunleri.DataSetName = "NewDataSet"
        Me.ds_tbStokAyYekunleri.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbStokAyYekunleri.Tables.AddRange(New System.Data.DataTable() {Me.DataTable2})
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn31, Me.DataColumn32, Me.DataColumn33, Me.DataColumn34, Me.DataColumn35, Me.DataColumn36, Me.DataColumn42})
        Me.DataTable2.TableName = "Table1"
        '
        'DataColumn31
        '
        Me.DataColumn31.ColumnName = "sAy"
        '
        'DataColumn32
        '
        Me.DataColumn32.ColumnName = "sYil"
        '
        'DataColumn33
        '
        Me.DataColumn33.ColumnName = "nGiris"
        Me.DataColumn33.DataType = GetType(Decimal)
        '
        'DataColumn34
        '
        Me.DataColumn34.ColumnName = "nGirisIade"
        Me.DataColumn34.DataType = GetType(Decimal)
        '
        'DataColumn35
        '
        Me.DataColumn35.ColumnName = "nCikis"
        Me.DataColumn35.DataType = GetType(Decimal)
        '
        'DataColumn36
        '
        Me.DataColumn36.ColumnName = "nCikisIade"
        Me.DataColumn36.DataType = GetType(Decimal)
        '
        'DataColumn42
        '
        Me.DataColumn42.ColumnName = "nKalan"
        Me.DataColumn42.DataType = GetType(Decimal)
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
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsAy, Me.colsYil, Me.colnGiris, Me.colnGirisIade, Me.colnCikis, Me.colnCikisIade, Me.colnKalan})
        Me.GridView2.DetailHeight = 160
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.GroupFormat = "{0}: {1} {2}"
        Me.GridView2.GroupPanelText = "Gruplamak stediiniz Kolonu Buraya Srkleyiniz..."
        Me.GridView2.IndicatorWidth = 12
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsDetail.ShowDetailTabs = False
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colsAy
        '
        Me.colsAy.Caption = "Ay"
        Me.colsAy.FieldName = "sAy"
        Me.colsAy.Name = "colsAy"
        Me.colsAy.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sAy", "{0} Kayt")})
        Me.colsAy.Visible = True
        Me.colsAy.VisibleIndex = 1
        '
        'colsYil
        '
        Me.colsYil.Caption = "Yıl"
        Me.colsYil.FieldName = "sYil"
        Me.colsYil.Name = "colsYil"
        Me.colsYil.Visible = True
        Me.colsYil.VisibleIndex = 0
        '
        'colnGiris
        '
        Me.colnGiris.Caption = "Giriş"
        Me.colnGiris.DisplayFormat.FormatString = "#,0.####"
        Me.colnGiris.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnGiris.FieldName = "nGiris"
        Me.colnGiris.Name = "colnGiris"
        Me.colnGiris.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nGiris", "{0:#,0.####}")})
        Me.colnGiris.Visible = True
        Me.colnGiris.VisibleIndex = 2
        '
        'colnGirisIade
        '
        Me.colnGirisIade.Caption = "İade Edilen"
        Me.colnGirisIade.DisplayFormat.FormatString = "#,0.####"
        Me.colnGirisIade.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnGirisIade.FieldName = "nGirisIade"
        Me.colnGirisIade.Name = "colnGirisIade"
        Me.colnGirisIade.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nGirisIade", "{0:#,0.####}")})
        Me.colnGirisIade.Visible = True
        Me.colnGirisIade.VisibleIndex = 3
        '
        'colnCikis
        '
        Me.colnCikis.Caption = "Çıkış"
        Me.colnCikis.DisplayFormat.FormatString = "#,0.####"
        Me.colnCikis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnCikis.FieldName = "nCikis"
        Me.colnCikis.Name = "colnCikis"
        Me.colnCikis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nCikis", "{0:#,0.####}")})
        Me.colnCikis.Visible = True
        Me.colnCikis.VisibleIndex = 4
        '
        'colnCikisIade
        '
        Me.colnCikisIade.Caption = "İade Alınan"
        Me.colnCikisIade.DisplayFormat.FormatString = "#,0.####"
        Me.colnCikisIade.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnCikisIade.FieldName = "nCikisIade"
        Me.colnCikisIade.Name = "colnCikisIade"
        Me.colnCikisIade.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nCikisIade", "{0:#,0.####}")})
        Me.colnCikisIade.Visible = True
        Me.colnCikisIade.VisibleIndex = 5
        '
        'colnKalan
        '
        Me.colnKalan.Caption = "Kalan"
        Me.colnKalan.DisplayFormat.FormatString = "#,0.####"
        Me.colnKalan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnKalan.FieldName = "nKalan"
        Me.colnKalan.Name = "colnKalan"
        Me.colnKalan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nKalan", "{0:#,0.####}")})
        Me.colnKalan.Visible = True
        Me.colnKalan.VisibleIndex = 6
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.GroupControl5)
        Me.XtraTabPage4.Controls.Add(Me.GroupControl4)
        Me.XtraTabPage4.Image = CType(resources.GetObject("XtraTabPage4.Image"), System.Drawing.Image)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(1357, 476)
        Me.XtraTabPage4.Text = "R/B/K"
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.GridControl3)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl5.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(1136, 476)
        Me.GroupControl5.TabIndex = 2
        Me.GroupControl5.Text = "Renk/Beden Alm"
        '
        'GridControl3
        '
        Me.GridControl3.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridControl3.Appearance.Empty.BackColor2 = System.Drawing.Color.Transparent
        Me.GridControl3.Appearance.Empty.Options.UseBackColor = True
        Me.GridControl3.ContextMenu = Me.kisayol_rbk
        Me.GridControl3.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl3.DataMember = "Table1"
        Me.GridControl3.DataSource = Me.ds_tbStokAcilim
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldnStokID, Me.fieldsModel, Me.fieldsKodu, Me.fieldsRenk, Me.fieldsBeden, Me.fieldsKavala, Me.fieldnMevcut, Me.fieldsRenkAdi})
        Me.GridControl3.Location = New System.Drawing.Point(2, 27)
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea
        Me.GridControl3.Size = New System.Drawing.Size(1132, 447)
        Me.GridControl3.TabIndex = 0
        '
        'kisayol_rbk
        '
        Me.kisayol_rbk.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem23, Me.MenuItem21, Me.MenuItem22, Me.MenuItem26, Me.MenuItem24, Me.MenuItem25})
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem6.Text = "Grnm Yazdr"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 1
        Me.MenuItem23.Text = "-"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 2
        Me.MenuItem21.Text = "Renk Ekle"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 3
        Me.MenuItem22.Text = "Renk Kaldr"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 4
        Me.MenuItem26.Text = "-"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 5
        Me.MenuItem24.Text = "Beden Ekle"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 6
        Me.MenuItem25.Text = "Beden Kaldr"
        '
        'ds_tbStokAcilim
        '
        Me.ds_tbStokAcilim.DataSetName = "NewDataSet"
        Me.ds_tbStokAcilim.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbStokAcilim.Tables.AddRange(New System.Data.DataTable() {Me.DataTable4})
        '
        'DataTable4
        '
        Me.DataTable4.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn48, Me.DataColumn49, Me.DataColumn50, Me.DataColumn51, Me.DataColumn52, Me.DataColumn53, Me.DataColumn54})
        Me.DataTable4.TableName = "Table1"
        '
        'DataColumn48
        '
        Me.DataColumn48.ColumnName = "nStokID"
        Me.DataColumn48.DataType = GetType(Long)
        '
        'DataColumn49
        '
        Me.DataColumn49.ColumnName = "sModel"
        '
        'DataColumn50
        '
        Me.DataColumn50.ColumnName = "sKodu"
        '
        'DataColumn51
        '
        Me.DataColumn51.ColumnName = "sRenk"
        '
        'DataColumn52
        '
        Me.DataColumn52.ColumnName = "sBeden"
        '
        'DataColumn53
        '
        Me.DataColumn53.ColumnName = "sKavala"
        '
        'DataColumn54
        '
        Me.DataColumn54.ColumnName = "nMevcut"
        Me.DataColumn54.DataType = GetType(Decimal)
        '
        'fieldnStokID
        '
        Me.fieldnStokID.AreaIndex = 0
        Me.fieldnStokID.Caption = "Kayt No"
        Me.fieldnStokID.FieldName = "nStokID"
        Me.fieldnStokID.Name = "fieldnStokID"
        Me.fieldnStokID.Visible = False
        '
        'fieldsModel
        '
        Me.fieldsModel.AreaIndex = 1
        Me.fieldsModel.Caption = "Model"
        Me.fieldsModel.FieldName = "sModel"
        Me.fieldsModel.Name = "fieldsModel"
        Me.fieldsModel.Visible = False
        '
        'fieldsKodu
        '
        Me.fieldsKodu.AreaIndex = 2
        Me.fieldsKodu.Caption = "Stok Kodu"
        Me.fieldsKodu.FieldName = "sKodu"
        Me.fieldsKodu.Name = "fieldsKodu"
        Me.fieldsKodu.Visible = False
        '
        'fieldsRenk
        '
        Me.fieldsRenk.AreaIndex = 1
        Me.fieldsRenk.Caption = "Renk"
        Me.fieldsRenk.FieldName = "sRenk"
        Me.fieldsRenk.GrandTotalText = "Toplam"
        Me.fieldsRenk.Name = "fieldsRenk"
        Me.fieldsRenk.Visible = False
        '
        'fieldsBeden
        '
        Me.fieldsBeden.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldsBeden.AreaIndex = 0
        Me.fieldsBeden.Caption = "Beden"
        Me.fieldsBeden.FieldName = "sBeden"
        Me.fieldsBeden.GrandTotalText = "Toplam"
        Me.fieldsBeden.Name = "fieldsBeden"
        '
        'fieldsKavala
        '
        Me.fieldsKavala.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldsKavala.AreaIndex = 1
        Me.fieldsKavala.Caption = "Kavala"
        Me.fieldsKavala.FieldName = "sKavala"
        Me.fieldsKavala.Name = "fieldsKavala"
        '
        'fieldnMevcut
        '
        Me.fieldnMevcut.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldnMevcut.AreaIndex = 0
        Me.fieldnMevcut.Caption = "Mevcut"
        Me.fieldnMevcut.CellFormat.FormatString = "#,0.####"
        Me.fieldnMevcut.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        PivotGridCustomTotal2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        PivotGridCustomTotal2.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldnMevcut.CustomTotals.AddRange(New DevExpress.XtraPivotGrid.PivotGridCustomTotal() {PivotGridCustomTotal2})
        Me.fieldnMevcut.FieldName = "nMevcut"
        Me.fieldnMevcut.GrandTotalCellFormat.FormatString = "#,0.####"
        Me.fieldnMevcut.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldnMevcut.Name = "fieldnMevcut"
        Me.fieldnMevcut.TotalCellFormat.FormatString = "#,0.####"
        Me.fieldnMevcut.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldnMevcut.TotalValueFormat.FormatString = "#,0.####"
        Me.fieldnMevcut.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldnMevcut.ValueFormat.FormatString = "#,0.####"
        Me.fieldnMevcut.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'fieldsRenkAdi
        '
        Me.fieldsRenkAdi.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldsRenkAdi.AreaIndex = 0
        Me.fieldsRenkAdi.Caption = "Renk Ad"
        Me.fieldsRenkAdi.FieldName = "sRenkAdi"
        Me.fieldsRenkAdi.GrandTotalText = "Toplam"
        Me.fieldsRenkAdi.Name = "fieldsRenkAdi"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.SimpleButton21)
        Me.GroupControl4.Controls.Add(Me.SimpleButton15)
        Me.GroupControl4.Controls.Add(Me.SimpleButton16)
        Me.GroupControl4.Controls.Add(Me.SimpleButton7)
        Me.GroupControl4.Controls.Add(Me.SimpleButton4)
        Me.GroupControl4.Controls.Add(Me.SimpleButton8)
        Me.GroupControl4.Controls.Add(Me.SimpleButton10)
        Me.GroupControl4.Controls.Add(Me.SimpleButton11)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl4.Location = New System.Drawing.Point(1136, 0)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(221, 476)
        Me.GroupControl4.TabIndex = 1
        Me.GroupControl4.Text = "İşlemler"
        '
        'SimpleButton21
        '
        Me.SimpleButton21.Image = Global.business_smart.My.Resources.Resources.replace2
        Me.SimpleButton21.Location = New System.Drawing.Point(3, 264)
        Me.SimpleButton21.Name = "SimpleButton21"
        Me.SimpleButton21.Size = New System.Drawing.Size(215, 33)
        Me.SimpleButton21.TabIndex = 15
        Me.SimpleButton21.Text = "Eksikleri Tamamla"
        '
        'SimpleButton15
        '
        Me.SimpleButton15.Image = Global.business_smart.My.Resources.Resources.nav_up_right_green
        Me.SimpleButton15.Location = New System.Drawing.Point(0, 223)
        Me.SimpleButton15.Name = "SimpleButton15"
        Me.SimpleButton15.Size = New System.Drawing.Size(214, 33)
        Me.SimpleButton15.TabIndex = 14
        Me.SimpleButton15.Text = "Kavala Kaldır"
        '
        'SimpleButton16
        '
        Me.SimpleButton16.Image = Global.business_smart.My.Resources.Resources.nav_down_right_green
        Me.SimpleButton16.Location = New System.Drawing.Point(0, 190)
        Me.SimpleButton16.Name = "SimpleButton16"
        Me.SimpleButton16.Size = New System.Drawing.Size(214, 33)
        Me.SimpleButton16.TabIndex = 13
        Me.SimpleButton16.Text = "Kavala Ekle"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Image = Global.business_smart.My.Resources.Resources.nav_up_blue
        Me.SimpleButton7.Location = New System.Drawing.Point(3, 66)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(215, 33)
        Me.SimpleButton7.TabIndex = 12
        Me.SimpleButton7.Text = "Renk Kaldır"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(3, 300)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(215, 33)
        Me.SimpleButton4.TabIndex = 11
        Me.SimpleButton4.Text = "Yazdır"
        '
        'SimpleButton8
        '
        Me.SimpleButton8.Image = Global.business_smart.My.Resources.Resources.nav_up_red
        Me.SimpleButton8.Location = New System.Drawing.Point(3, 140)
        Me.SimpleButton8.Name = "SimpleButton8"
        Me.SimpleButton8.Size = New System.Drawing.Size(215, 33)
        Me.SimpleButton8.TabIndex = 9
        Me.SimpleButton8.Text = "Beden Kaldır"
        '
        'SimpleButton10
        '
        Me.SimpleButton10.Image = Global.business_smart.My.Resources.Resources.nav_down_red
        Me.SimpleButton10.Location = New System.Drawing.Point(3, 107)
        Me.SimpleButton10.Name = "SimpleButton10"
        Me.SimpleButton10.Size = New System.Drawing.Size(215, 33)
        Me.SimpleButton10.TabIndex = 7
        Me.SimpleButton10.Text = "Beden Ekle"
        '
        'SimpleButton11
        '
        Me.SimpleButton11.Image = Global.business_smart.My.Resources.Resources.nav_down_blue
        Me.SimpleButton11.Location = New System.Drawing.Point(3, 33)
        Me.SimpleButton11.Name = "SimpleButton11"
        Me.SimpleButton11.Size = New System.Drawing.Size(215, 33)
        Me.SimpleButton11.TabIndex = 6
        Me.SimpleButton11.Text = "Renk Ekle"
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Controls.Add(Me.GroupControl3)
        Me.XtraTabPage6.Controls.Add(Me.GroupControl2)
        Me.XtraTabPage6.Image = CType(resources.GetObject("XtraTabPage6.Image"), System.Drawing.Image)
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(1357, 476)
        Me.XtraTabPage6.Text = "Barkodlar"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.Group_BarkodGir)
        Me.GroupControl3.Controls.Add(Me.GridControl4)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1136, 476)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "Barkod Listesi"
        '
        'Group_BarkodGir
        '
        Me.Group_BarkodGir.Controls.Add(Me.lbl_barcodestd)
        Me.Group_BarkodGir.Controls.Add(Me.lbl_checkdigit)
        Me.Group_BarkodGir.Controls.Add(Me.lbl_sBarkod)
        Me.Group_BarkodGir.Controls.Add(Me.LabelControl32)
        Me.Group_BarkodGir.Controls.Add(Me.LabelControl31)
        Me.Group_BarkodGir.Controls.Add(Me.LabelControl30)
        Me.Group_BarkodGir.Controls.Add(Me.txt_lBarkodMiktar)
        Me.Group_BarkodGir.Controls.Add(Me.sec_sBarkodBirimCinsi)
        Me.Group_BarkodGir.Controls.Add(Me.sec_sBarkodTipi)
        Me.Group_BarkodGir.Controls.Add(Me.btn_BarkodVazgec)
        Me.Group_BarkodGir.Controls.Add(Me.btn_BarkodKaydet)
        Me.Group_BarkodGir.Controls.Add(Me.LabelControl29)
        Me.Group_BarkodGir.Controls.Add(Me.txt_sBarkod)
        Me.Group_BarkodGir.Location = New System.Drawing.Point(328, 66)
        Me.Group_BarkodGir.Name = "Group_BarkodGir"
        Me.Group_BarkodGir.Size = New System.Drawing.Size(499, 221)
        Me.Group_BarkodGir.TabIndex = 85
        Me.Group_BarkodGir.Text = "Barkod Gir"
        Me.Group_BarkodGir.Visible = False
        '
        'lbl_barcodestd
        '
        Me.lbl_barcodestd.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_barcodestd.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_barcodestd.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_barcodestd.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_barcodestd.Location = New System.Drawing.Point(437, 46)
        Me.lbl_barcodestd.Name = "lbl_barcodestd"
        Me.lbl_barcodestd.Size = New System.Drawing.Size(11, 21)
        Me.lbl_barcodestd.TabIndex = 106
        Me.lbl_barcodestd.Text = "*"
        '
        'lbl_checkdigit
        '
        Me.lbl_checkdigit.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lbl_checkdigit.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_checkdigit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_checkdigit.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_checkdigit.Location = New System.Drawing.Point(395, 46)
        Me.lbl_checkdigit.Name = "lbl_checkdigit"
        Me.lbl_checkdigit.Size = New System.Drawing.Size(11, 21)
        Me.lbl_checkdigit.TabIndex = 105
        Me.lbl_checkdigit.Text = "*"
        '
        'lbl_sBarkod
        '
        Me.lbl_sBarkod.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_sBarkod.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_sBarkod.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_sBarkod.Location = New System.Drawing.Point(93, 46)
        Me.lbl_sBarkod.Name = "lbl_sBarkod"
        Me.lbl_sBarkod.Size = New System.Drawing.Size(9, 19)
        Me.lbl_sBarkod.TabIndex = 97
        Me.lbl_sBarkod.Text = "*"
        '
        'LabelControl32
        '
        Me.LabelControl32.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl32.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl32.Location = New System.Drawing.Point(24, 140)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(91, 19)
        Me.LabelControl32.TabIndex = 77
        Me.LabelControl32.Text = "Birim Miktar:"
        '
        'LabelControl31
        '
        Me.LabelControl31.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl31.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl31.Location = New System.Drawing.Point(24, 109)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(43, 19)
        Me.LabelControl31.TabIndex = 76
        Me.LabelControl31.Text = "Birim:"
        '
        'LabelControl30
        '
        Me.LabelControl30.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl30.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl30.Location = New System.Drawing.Point(24, 77)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(33, 19)
        Me.LabelControl30.TabIndex = 75
        Me.LabelControl30.Text = "Tipi:"
        '
        'txt_lBarkodMiktar
        '
        Me.txt_lBarkodMiktar.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.nIskontoYuzdesi", True))
        Me.txt_lBarkodMiktar.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_lBarkodMiktar.EnterMoveNextControl = True
        Me.txt_lBarkodMiktar.Location = New System.Drawing.Point(126, 134)
        Me.txt_lBarkodMiktar.Name = "txt_lBarkodMiktar"
        Me.txt_lBarkodMiktar.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lBarkodMiktar.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_lBarkodMiktar.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.txt_lBarkodMiktar.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txt_lBarkodMiktar.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txt_lBarkodMiktar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_lBarkodMiktar.Size = New System.Drawing.Size(132, 26)
        ToolTipTitleItem44.Text = "Toptan iskonto"
        ToolTipItem32.LeftIndent = 6
        SuperToolTip33.Items.Add(ToolTipTitleItem44)
        SuperToolTip33.Items.Add(ToolTipItem32)
        Me.txt_lBarkodMiktar.SuperTip = SuperToolTip33
        Me.txt_lBarkodMiktar.TabIndex = 74
        '
        'sec_sBarkodBirimCinsi
        '
        Me.sec_sBarkodBirimCinsi.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStok, "Table1.sBirimCinsi1", True))
        Me.sec_sBarkodBirimCinsi.EnterMoveNextControl = True
        Me.sec_sBarkodBirimCinsi.Location = New System.Drawing.Point(126, 103)
        Me.sec_sBarkodBirimCinsi.Name = "sec_sBarkodBirimCinsi"
        Me.sec_sBarkodBirimCinsi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sBarkodBirimCinsi.Properties.Appearance.Options.UseBackColor = True
        Me.sec_sBarkodBirimCinsi.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sBarkodBirimCinsi.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sBarkodBirimCinsi.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.sec_sBarkodBirimCinsi.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.sec_sBarkodBirimCinsi.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.sec_sBarkodBirimCinsi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sBarkodBirimCinsi.Properties.DisplayMember = "sBirimCinsi"
        Me.sec_sBarkodBirimCinsi.Properties.NullText = "[Birim]"
        Me.sec_sBarkodBirimCinsi.Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.DoubleClick
        Me.sec_sBarkodBirimCinsi.Properties.ValueMember = "sBirimCinsi"
        Me.sec_sBarkodBirimCinsi.Size = New System.Drawing.Size(132, 26)
        ToolTipTitleItem45.Text = "Ana Birim"
        SuperToolTip34.Items.Add(ToolTipTitleItem45)
        Me.sec_sBarkodBirimCinsi.SuperTip = SuperToolTip34
        Me.sec_sBarkodBirimCinsi.TabIndex = 71
        '
        'sec_sBarkodTipi
        '
        Me.sec_sBarkodTipi.EditValue = "Master"
        Me.sec_sBarkodTipi.Location = New System.Drawing.Point(126, 71)
        Me.sec_sBarkodTipi.MenuManager = Me.BarManager1
        Me.sec_sBarkodTipi.Name = "sec_sBarkodTipi"
        Me.sec_sBarkodTipi.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sec_sBarkodTipi.Properties.Appearance.Options.UseBackColor = True
        Me.sec_sBarkodTipi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sBarkodTipi.Properties.Items.AddRange(New Object() {"Master", "Muadil", "Koli"})
        Me.sec_sBarkodTipi.Size = New System.Drawing.Size(132, 26)
        Me.sec_sBarkodTipi.TabIndex = 70
        '
        'btn_BarkodVazgec
        '
        Me.btn_BarkodVazgec.Image = CType(resources.GetObject("btn_BarkodVazgec.Image"), System.Drawing.Image)
        Me.btn_BarkodVazgec.Location = New System.Drawing.Point(267, 179)
        Me.btn_BarkodVazgec.Name = "btn_BarkodVazgec"
        Me.btn_BarkodVazgec.Size = New System.Drawing.Size(120, 34)
        Me.btn_BarkodVazgec.TabIndex = 69
        Me.btn_BarkodVazgec.Text = "&Vazge"
        '
        'btn_BarkodKaydet
        '
        Me.btn_BarkodKaydet.Image = CType(resources.GetObject("btn_BarkodKaydet.Image"), System.Drawing.Image)
        Me.btn_BarkodKaydet.Location = New System.Drawing.Point(126, 179)
        Me.btn_BarkodKaydet.Name = "btn_BarkodKaydet"
        Me.btn_BarkodKaydet.Size = New System.Drawing.Size(132, 34)
        Me.btn_BarkodKaydet.TabIndex = 68
        Me.btn_BarkodKaydet.Text = "&Kaydet"
        '
        'LabelControl29
        '
        Me.LabelControl29.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl29.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl29.Location = New System.Drawing.Point(24, 46)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(55, 19)
        Me.LabelControl29.TabIndex = 67
        Me.LabelControl29.Text = "Barkod:"
        '
        'txt_sBarkod
        '
        Me.txt_sBarkod.Location = New System.Drawing.Point(126, 40)
        Me.txt_sBarkod.MenuManager = Me.BarManager1
        Me.txt_sBarkod.Name = "txt_sBarkod"
        Me.txt_sBarkod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_sBarkod.Size = New System.Drawing.Size(261, 26)
        Me.txt_sBarkod.TabIndex = 0
        '
        'GridControl4
        '
        Me.GridControl4.ContextMenuStrip = Me.kisayol_barkod
        Me.GridControl4.DataMember = "Table1"
        Me.GridControl4.DataSource = Me.ds_tbStokBarkodu
        Me.GridControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl4.Location = New System.Drawing.Point(2, 27)
        Me.GridControl4.MainView = Me.GridView3
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sBarkod, Me.sec_nKisim, Me.sec_sBirimCinsi})
        Me.GridControl4.Size = New System.Drawing.Size(1132, 447)
        Me.GridControl4.TabIndex = 0
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'kisayol_barkod
        '
        Me.kisayol_barkod.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.kisayol_barkod.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarkodAtaToolStripMenuItem, Me.BarkodAtaToolStripMenuItem1, Me.BarkodAtaStokKoduToolStripMenuItem, Me.ToolStripSeparator1, Me.GrnmYazdrToolStripMenuItem})
        Me.kisayol_barkod.Name = "kisayol_barkod"
        Me.kisayol_barkod.Size = New System.Drawing.Size(260, 138)
        '
        'BarkodAtaToolStripMenuItem
        '
        Me.BarkodAtaToolStripMenuItem.Name = "BarkodAtaToolStripMenuItem"
        Me.BarkodAtaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.BarkodAtaToolStripMenuItem.Size = New System.Drawing.Size(259, 32)
        Me.BarkodAtaToolStripMenuItem.Text = "Barkod Ata Ean13"
        '
        'BarkodAtaToolStripMenuItem1
        '
        Me.BarkodAtaToolStripMenuItem1.Name = "BarkodAtaToolStripMenuItem1"
        Me.BarkodAtaToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.BarkodAtaToolStripMenuItem1.Size = New System.Drawing.Size(259, 32)
        Me.BarkodAtaToolStripMenuItem1.Text = "Barkod Ata Ean8"
        '
        'BarkodAtaStokKoduToolStripMenuItem
        '
        Me.BarkodAtaStokKoduToolStripMenuItem.Name = "BarkodAtaStokKoduToolStripMenuItem"
        Me.BarkodAtaStokKoduToolStripMenuItem.Size = New System.Drawing.Size(259, 32)
        Me.BarkodAtaStokKoduToolStripMenuItem.Text = "Barkod Ata Stok Kodu"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(256, 6)
        '
        'GrnmYazdrToolStripMenuItem
        '
        Me.GrnmYazdrToolStripMenuItem.Name = "GrnmYazdrToolStripMenuItem"
        Me.GrnmYazdrToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.GrnmYazdrToolStripMenuItem.Size = New System.Drawing.Size(259, 32)
        Me.GrnmYazdrToolStripMenuItem.Text = "Grnm Yazdr"
        '
        'ds_tbStokBarkodu
        '
        Me.ds_tbStokBarkodu.DataSetName = "NewDataSet"
        Me.ds_tbStokBarkodu.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbStokBarkodu.Tables.AddRange(New System.Data.DataTable() {Me.DataTable7})
        '
        'DataTable7
        '
        Me.DataTable7.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn59, Me.DataColumn60, Me.DataColumn61, Me.DataColumn62, Me.DataColumn63, Me.DataColumn64})
        Me.DataTable7.TableName = "Table1"
        '
        'DataColumn59
        '
        Me.DataColumn59.ColumnName = "nStokID"
        Me.DataColumn59.DataType = GetType(Long)
        '
        'DataColumn60
        '
        Me.DataColumn60.ColumnName = "sBarkod"
        '
        'DataColumn61
        '
        Me.DataColumn61.ColumnName = "nKisim"
        Me.DataColumn61.DataType = GetType(Long)
        '
        'DataColumn62
        '
        Me.DataColumn62.ColumnName = "nFirmaID"
        Me.DataColumn62.DataType = GetType(Long)
        '
        'DataColumn63
        '
        Me.DataColumn63.ColumnName = "sKarsiStokKodu"
        '
        'DataColumn64
        '
        Me.DataColumn64.ColumnName = "sKarsiStokAciklama"
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnStokID, Me.colsBarkod, Me.colnKisim, Me.colnFirmaID, Me.colsKarsiStokKodu, Me.colsKarsiStokAciklama, Me.colsKodu, Me.colsAciklama1, Me.colsRenk, Me.colsBeden, Me.colsKavala, Me.colsRenkAdi, Me.colsBirimCinsi, Me.collBirimMiktar})
        Me.GridView3.CustomizationFormBounds = New System.Drawing.Rectangle(475, 269, 208, 168)
        Me.GridView3.DetailHeight = 160
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.GridControl = Me.GridControl4
        Me.GridView3.GroupFormat = "{0}: {1} {2}"
        Me.GridView3.GroupPanelText = "Gruplamak stediiniz Kolonu Buraya Srkleyiniz..."
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
        'colnStokID
        '
        Me.colnStokID.Caption = "Stok ID"
        Me.colnStokID.FieldName = "nStokID"
        Me.colnStokID.Name = "colnStokID"
        Me.colnStokID.OptionsColumn.AllowEdit = False
        Me.colnStokID.OptionsColumn.AllowFocus = False
        Me.colnStokID.OptionsColumn.ReadOnly = True
        '
        'colsBarkod
        '
        Me.colsBarkod.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colsBarkod.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.colsBarkod.AppearanceCell.Options.UseFont = True
        Me.colsBarkod.AppearanceCell.Options.UseForeColor = True
        Me.colsBarkod.Caption = "Barkod"
        Me.colsBarkod.ColumnEdit = Me.sec_sBarkod
        Me.colsBarkod.FieldName = "sBarkod"
        Me.colsBarkod.Name = "colsBarkod"
        Me.colsBarkod.OptionsColumn.ReadOnly = True
        Me.colsBarkod.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sBarkod", "{0} Kayt")})
        Me.colsBarkod.Visible = True
        Me.colsBarkod.VisibleIndex = 5
        Me.colsBarkod.Width = 235
        '
        'sec_sBarkod
        '
        Me.sec_sBarkod.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.sec_sBarkod.AppearanceFocused.Options.UseFont = True
        Me.sec_sBarkod.AutoHeight = False
        Me.sec_sBarkod.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.sec_sBarkod.MaxLength = 20
        Me.sec_sBarkod.Name = "sec_sBarkod"
        '
        'colnKisim
        '
        Me.colnKisim.Caption = "Kısım"
        Me.colnKisim.ColumnEdit = Me.sec_nKisim
        Me.colnKisim.FieldName = "nKisim"
        Me.colnKisim.Name = "colnKisim"
        Me.colnKisim.Visible = True
        Me.colnKisim.VisibleIndex = 4
        Me.colnKisim.Width = 43
        '
        'sec_nKisim
        '
        Me.sec_nKisim.AutoHeight = False
        Me.sec_nKisim.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_nKisim.Items.AddRange(New Object() {"0", "1", "2"})
        Me.sec_nKisim.Name = "sec_nKisim"
        Me.sec_nKisim.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colnFirmaID
        '
        Me.colnFirmaID.Caption = "FirmaID"
        Me.colnFirmaID.FieldName = "nFirmaID"
        Me.colnFirmaID.Name = "colnFirmaID"
        Me.colnFirmaID.OptionsColumn.AllowEdit = False
        Me.colnFirmaID.OptionsColumn.ReadOnly = True
        Me.colnFirmaID.Width = 106
        '
        'colsKarsiStokKodu
        '
        Me.colsKarsiStokKodu.Caption = "Karşı Stok Kodu"
        Me.colsKarsiStokKodu.FieldName = "sKarsiStokKodu"
        Me.colsKarsiStokKodu.Name = "colsKarsiStokKodu"
        Me.colsKarsiStokKodu.OptionsColumn.AllowEdit = False
        Me.colsKarsiStokKodu.OptionsColumn.ReadOnly = True
        Me.colsKarsiStokKodu.Width = 106
        '
        'colsKarsiStokAciklama
        '
        Me.colsKarsiStokAciklama.Caption = "Karşı Stok Açıklama"
        Me.colsKarsiStokAciklama.FieldName = "sKarsiStokAciklama"
        Me.colsKarsiStokAciklama.Name = "colsKarsiStokAciklama"
        Me.colsKarsiStokAciklama.OptionsColumn.AllowEdit = False
        Me.colsKarsiStokAciklama.OptionsColumn.ReadOnly = True
        Me.colsKarsiStokAciklama.Width = 106
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Stok Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.OptionsColumn.AllowEdit = False
        Me.colsKodu.OptionsColumn.AllowFocus = False
        Me.colsKodu.OptionsColumn.ReadOnly = True
        '
        'colsAciklama1
        '
        Me.colsAciklama1.Caption = "Stok Adı"
        Me.colsAciklama1.FieldName = "sAciklama"
        Me.colsAciklama1.Name = "colsAciklama1"
        Me.colsAciklama1.OptionsColumn.AllowEdit = False
        Me.colsAciklama1.OptionsColumn.AllowFocus = False
        Me.colsAciklama1.OptionsColumn.ReadOnly = True
        '
        'colsRenk
        '
        Me.colsRenk.AppearanceCell.BackColor = System.Drawing.SystemColors.Control
        Me.colsRenk.AppearanceCell.Options.UseBackColor = True
        Me.colsRenk.Caption = "Renk"
        Me.colsRenk.FieldName = "sRenk"
        Me.colsRenk.Name = "colsRenk"
        Me.colsRenk.OptionsColumn.AllowEdit = False
        Me.colsRenk.OptionsColumn.AllowFocus = False
        Me.colsRenk.OptionsColumn.ReadOnly = True
        Me.colsRenk.Visible = True
        Me.colsRenk.VisibleIndex = 0
        Me.colsRenk.Width = 54
        '
        'colsBeden
        '
        Me.colsBeden.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colsBeden.AppearanceCell.Options.UseBackColor = True
        Me.colsBeden.Caption = "Beden"
        Me.colsBeden.FieldName = "sBeden"
        Me.colsBeden.Name = "colsBeden"
        Me.colsBeden.OptionsColumn.AllowEdit = False
        Me.colsBeden.OptionsColumn.AllowFocus = False
        Me.colsBeden.OptionsColumn.ReadOnly = True
        Me.colsBeden.Visible = True
        Me.colsBeden.VisibleIndex = 2
        Me.colsBeden.Width = 38
        '
        'colsKavala
        '
        Me.colsKavala.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colsKavala.AppearanceCell.Options.UseBackColor = True
        Me.colsKavala.Caption = "Kavala"
        Me.colsKavala.FieldName = "sKavala"
        Me.colsKavala.Name = "colsKavala"
        Me.colsKavala.OptionsColumn.AllowEdit = False
        Me.colsKavala.OptionsColumn.AllowFocus = False
        Me.colsKavala.OptionsColumn.ReadOnly = True
        Me.colsKavala.Visible = True
        Me.colsKavala.VisibleIndex = 3
        Me.colsKavala.Width = 51
        '
        'colsRenkAdi
        '
        Me.colsRenkAdi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colsRenkAdi.AppearanceCell.Options.UseBackColor = True
        Me.colsRenkAdi.Caption = "Renk Adı"
        Me.colsRenkAdi.FieldName = "sRenkAdi"
        Me.colsRenkAdi.Name = "colsRenkAdi"
        Me.colsRenkAdi.OptionsColumn.AllowEdit = False
        Me.colsRenkAdi.OptionsColumn.AllowFocus = False
        Me.colsRenkAdi.OptionsColumn.ReadOnly = True
        Me.colsRenkAdi.Visible = True
        Me.colsRenkAdi.VisibleIndex = 1
        Me.colsRenkAdi.Width = 127
        '
        'colsBirimCinsi
        '
        Me.colsBirimCinsi.Caption = "Birim"
        Me.colsBirimCinsi.ColumnEdit = Me.sec_sBirimCinsi
        Me.colsBirimCinsi.FieldName = "sBirimCinsi"
        Me.colsBirimCinsi.Name = "colsBirimCinsi"
        Me.colsBirimCinsi.Visible = True
        Me.colsBirimCinsi.VisibleIndex = 6
        Me.colsBirimCinsi.Width = 44
        '
        'sec_sBirimCinsi
        '
        Me.sec_sBirimCinsi.AutoHeight = False
        Me.sec_sBirimCinsi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sBirimCinsi.DisplayMember = "sBirimCinsi"
        Me.sec_sBirimCinsi.Name = "sec_sBirimCinsi"
        Me.sec_sBirimCinsi.NullText = "[Birim]"
        Me.sec_sBirimCinsi.ValueMember = "sBirimCinsi"
        '
        'collBirimMiktar
        '
        Me.collBirimMiktar.Caption = "Miktar"
        Me.collBirimMiktar.DisplayFormat.FormatString = "#,#.###"
        Me.collBirimMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBirimMiktar.FieldName = "lBirimMiktar"
        Me.collBirimMiktar.Name = "collBirimMiktar"
        Me.collBirimMiktar.Visible = True
        Me.collBirimMiktar.VisibleIndex = 7
        Me.collBirimMiktar.Width = 73
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.btn_BarkodAtaModel)
        Me.GroupControl2.Controls.Add(Me.SimpleButton20)
        Me.GroupControl2.Controls.Add(Me.SimpleButton19)
        Me.GroupControl2.Controls.Add(Me.SimpleButton3)
        Me.GroupControl2.Controls.Add(Me.btn_BarkodAtaMuadil)
        Me.GroupControl2.Controls.Add(Me.btn_BarkoduSil)
        Me.GroupControl2.Controls.Add(Me.btn_BarkodAtaAna)
        Me.GroupControl2.Controls.Add(Me.btn_BarkodAtaEan8)
        Me.GroupControl2.Controls.Add(Me.btn_BarkodAtaEan13)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl2.Location = New System.Drawing.Point(1136, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(221, 476)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "lemler"
        '
        'btn_BarkodAtaModel
        '
        Me.btn_BarkodAtaModel.Image = Global.business_smart.My.Resources.Resources.nav_down_green
        Me.btn_BarkodAtaModel.Location = New System.Drawing.Point(3, 99)
        Me.btn_BarkodAtaModel.Name = "btn_BarkodAtaModel"
        Me.btn_BarkodAtaModel.Size = New System.Drawing.Size(215, 32)
        Me.btn_BarkodAtaModel.TabIndex = 8
        Me.btn_BarkodAtaModel.Text = "Stok Kodunu Ata"
        '
        'SimpleButton20
        '
        Me.SimpleButton20.Image = CType(resources.GetObject("SimpleButton20.Image"), System.Drawing.Image)
        Me.SimpleButton20.Location = New System.Drawing.Point(3, 197)
        Me.SimpleButton20.Name = "SimpleButton20"
        Me.SimpleButton20.Size = New System.Drawing.Size(215, 33)
        Me.SimpleButton20.TabIndex = 7
        Me.SimpleButton20.Text = "Koli Barkodu Gir"
        '
        'SimpleButton19
        '
        Me.SimpleButton19.Image = Global.business_smart.My.Resources.Resources.replace2
        Me.SimpleButton19.Location = New System.Drawing.Point(3, 299)
        Me.SimpleButton19.Name = "SimpleButton19"
        Me.SimpleButton19.Size = New System.Drawing.Size(215, 32)
        Me.SimpleButton19.TabIndex = 6
        Me.SimpleButton19.Text = "Barkodu Koda Ata"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(3, 263)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(215, 33)
        Me.SimpleButton3.TabIndex = 5
        Me.SimpleButton3.Text = "Yazdr"
        '
        'btn_BarkodAtaMuadil
        '
        Me.btn_BarkodAtaMuadil.Image = CType(resources.GetObject("btn_BarkodAtaMuadil.Image"), System.Drawing.Image)
        Me.btn_BarkodAtaMuadil.Location = New System.Drawing.Point(3, 164)
        Me.btn_BarkodAtaMuadil.Name = "btn_BarkodAtaMuadil"
        Me.btn_BarkodAtaMuadil.Size = New System.Drawing.Size(215, 33)
        Me.btn_BarkodAtaMuadil.TabIndex = 4
        Me.btn_BarkodAtaMuadil.Text = "Muadil Barkod Gir"
        '
        'btn_BarkoduSil
        '
        Me.btn_BarkoduSil.Image = Global.business_smart.My.Resources.Resources.button_cancel
        Me.btn_BarkoduSil.Location = New System.Drawing.Point(3, 230)
        Me.btn_BarkoduSil.Name = "btn_BarkoduSil"
        Me.btn_BarkoduSil.Size = New System.Drawing.Size(215, 33)
        Me.btn_BarkoduSil.TabIndex = 3
        Me.btn_BarkoduSil.Text = "Barkodu Sil"
        '
        'btn_BarkodAtaAna
        '
        Me.btn_BarkodAtaAna.Image = CType(resources.GetObject("btn_BarkodAtaAna.Image"), System.Drawing.Image)
        Me.btn_BarkodAtaAna.Location = New System.Drawing.Point(3, 131)
        Me.btn_BarkodAtaAna.Name = "btn_BarkodAtaAna"
        Me.btn_BarkodAtaAna.Size = New System.Drawing.Size(215, 33)
        Me.btn_BarkodAtaAna.TabIndex = 2
        Me.btn_BarkodAtaAna.Text = "Barkod Gir"
        '
        'btn_BarkodAtaEan8
        '
        Me.btn_BarkodAtaEan8.Image = Global.business_smart.My.Resources.Resources.barcode1
        Me.btn_BarkodAtaEan8.Location = New System.Drawing.Point(3, 66)
        Me.btn_BarkodAtaEan8.Name = "btn_BarkodAtaEan8"
        Me.btn_BarkodAtaEan8.Size = New System.Drawing.Size(215, 33)
        Me.btn_BarkodAtaEan8.TabIndex = 1
        Me.btn_BarkodAtaEan8.Text = "Barkod Ata Ean8"
        '
        'btn_BarkodAtaEan13
        '
        Me.btn_BarkodAtaEan13.Image = Global.business_smart.My.Resources.Resources.barcode1
        Me.btn_BarkodAtaEan13.Location = New System.Drawing.Point(3, 33)
        Me.btn_BarkodAtaEan13.Name = "btn_BarkodAtaEan13"
        Me.btn_BarkodAtaEan13.Size = New System.Drawing.Size(215, 33)
        Me.btn_BarkodAtaEan13.TabIndex = 0
        Me.btn_BarkodAtaEan13.Text = "Barkod Ata Ean13"
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.btnAIAciklamaEkle)
        Me.XtraTabPage5.Controls.Add(Me.txt_sUzunNot)
        Me.XtraTabPage5.Image = CType(resources.GetObject("XtraTabPage5.Image"), System.Drawing.Image)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(1361, 471)
        Me.XtraTabPage5.Text = "Not"
        '
        'btnAIAciklamaEkle
        '
        Me.btnAIAciklamaEkle.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.btnAIAciklamaEkle.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAIAciklamaEkle.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnAIAciklamaEkle.Appearance.Options.UseBackColor = True
        Me.btnAIAciklamaEkle.Appearance.Options.UseFont = True
        Me.btnAIAciklamaEkle.Appearance.Options.UseForeColor = True
        Me.btnAIAciklamaEkle.Location = New System.Drawing.Point(10, 430)
        Me.btnAIAciklamaEkle.Name = "btnAIAciklamaEkle"
        Me.btnAIAciklamaEkle.Size = New System.Drawing.Size(200, 40)
        Me.btnAIAciklamaEkle.TabIndex = 18
        Me.btnAIAciklamaEkle.Text = "🤖 AI ile Açıklama Oluştur"
        '
        'txt_sUzunNot
        '
        Me.txt_sUzunNot.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStokUzunNot, "Table1.sUzunNot", True))
        Me.txt_sUzunNot.Location = New System.Drawing.Point(0, 0)
        Me.txt_sUzunNot.Name = "txt_sUzunNot"
        Me.txt_sUzunNot.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_sUzunNot.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txt_sUzunNot.Properties.Appearance.Options.UseFont = True
        Me.txt_sUzunNot.Properties.Appearance.Options.UseForeColor = True
        Me.txt_sUzunNot.Size = New System.Drawing.Size(1357, 425)
        Me.txt_sUzunNot.TabIndex = 0
        '
        'ds_tbStokUzunNot
        '
        Me.ds_tbStokUzunNot.DataSetName = "NewDataSet"
        Me.ds_tbStokUzunNot.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbStokUzunNot.Tables.AddRange(New System.Data.DataTable() {Me.DataTable6})
        '
        'DataTable6
        '
        Me.DataTable6.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn55, Me.DataColumn56, Me.DataColumn57, Me.DataColumn58})
        Me.DataTable6.TableName = "Table1"
        '
        'DataColumn55
        '
        Me.DataColumn55.ColumnName = "sModel"
        '
        'DataColumn56
        '
        Me.DataColumn56.ColumnName = "sUzunNot"
        '
        'DataColumn57
        '
        Me.DataColumn57.ColumnName = "sSonKullaniciAdi"
        '
        'DataColumn58
        '
        Me.DataColumn58.ColumnName = "dteSonUpdateTarihi"
        Me.DataColumn58.DataType = GetType(Date)
        '
        'XtraTabPage8
        '
        Me.XtraTabPage8.Controls.Add(Me.PanelControl5)
        Me.XtraTabPage8.Controls.Add(Me.PanelControl2)
        Me.XtraTabPage8.Image = CType(resources.GetObject("XtraTabPage8.Image"), System.Drawing.Image)
        Me.XtraTabPage8.Name = "XtraTabPage8"
        Me.XtraTabPage8.Size = New System.Drawing.Size(1357, 476)
        Me.XtraTabPage8.Text = "Dökümanlar"
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.GridControl6)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl5.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(1357, 416)
        Me.PanelControl5.TabIndex = 2
        '
        'GridControl6
        '
        Me.GridControl6.DataMember = "Table1"
        Me.GridControl6.DataSource = Me.ds_tbStokResim
        Me.GridControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl6.Location = New System.Drawing.Point(2, 2)
        Me.GridControl6.MainView = Me.GridView6
        Me.GridControl6.MenuManager = Me.BarManager1
        Me.GridControl6.Name = "GridControl6"
        Me.GridControl6.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_pResim})
        Me.GridControl6.Size = New System.Drawing.Size(1353, 412)
        Me.GridControl6.TabIndex = 1
        Me.GridControl6.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6})
        '
        'ds_tbStokResim
        '
        Me.ds_tbStokResim.DataSetName = "NewDataSet"
        Me.ds_tbStokResim.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbStokResim.Tables.AddRange(New System.Data.DataTable() {Me.DataTable9})
        '
        'DataTable9
        '
        Me.DataTable9.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn72, Me.DataColumn73, Me.DataColumn74, Me.DataColumn75, Me.DataColumn76, Me.DataColumn77, Me.DataColumn78, Me.DataColumn92})
        Me.DataTable9.TableName = "Table1"
        '
        'DataColumn72
        '
        Me.DataColumn72.ColumnName = "nStokResimID"
        Me.DataColumn72.DataType = GetType(System.Guid)
        '
        'DataColumn73
        '
        Me.DataColumn73.ColumnName = "sModel"
        '
        'DataColumn74
        '
        Me.DataColumn74.ColumnName = "pResim"
        Me.DataColumn74.DataType = GetType(Byte())
        '
        'DataColumn75
        '
        Me.DataColumn75.ColumnName = "sAciklama"
        '
        'DataColumn76
        '
        Me.DataColumn76.ColumnName = "sKullaniciAdi"
        '
        'DataColumn77
        '
        Me.DataColumn77.ColumnName = "dteKayitTarihi"
        Me.DataColumn77.DataType = GetType(Date)
        '
        'DataColumn78
        '
        Me.DataColumn78.ColumnName = "nSira"
        Me.DataColumn78.DataType = GetType(Long)
        '
        'DataColumn92
        '
        Me.DataColumn92.ColumnName = "yol"
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnStokResimID, Me.colsModel1, Me.colnSira, Me.colsKodu_Resim, Me.colsRenkAdi_Resim, Me.colsBeden_Resim, Me.colsKavala_Resim, Me.colpResim, Me.colsAciklama2, Me.colsKullaniciAdi, Me.coldteKayitTarihi})
        Me.GridView6.GridControl = Me.GridControl6
        Me.GridView6.GroupPanelText = "Gruplamak stediiniz Kolonu Buraya Srkleyiniz..."
        Me.GridView6.IndicatorWidth = 35
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView6.OptionsCustomization.AllowFilter = False
        Me.GridView6.OptionsCustomization.AllowGroup = False
        Me.GridView6.OptionsView.ShowFooter = True
        Me.GridView6.OptionsView.ShowGroupPanel = False
        Me.GridView6.OptionsView.ShowIndicator = False
        Me.GridView6.RowHeight = 135
        '
        'colnStokResimID
        '
        Me.colnStokResimID.Caption = "StokResimID"
        Me.colnStokResimID.FieldName = "nStokResimID"
        Me.colnStokResimID.Name = "colnStokResimID"
        Me.colnStokResimID.OptionsColumn.AllowEdit = False
        Me.colnStokResimID.OptionsColumn.AllowFocus = False
        '
        'colsModel1
        '
        Me.colsModel1.Caption = "Model"
        Me.colsModel1.FieldName = "sModel"
        Me.colsModel1.Name = "colsModel1"
        Me.colsModel1.OptionsColumn.AllowEdit = False
        Me.colsModel1.OptionsColumn.AllowFocus = False
        '
        'colnSira
        '
        Me.colnSira.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colnSira.AppearanceCell.Options.UseBackColor = True
        Me.colnSira.Caption = "Sira"
        Me.colnSira.FieldName = "nSira"
        Me.colnSira.Name = "colnSira"
        Me.colnSira.Visible = True
        Me.colnSira.VisibleIndex = 1
        Me.colnSira.Width = 33
        '
        'colsKodu_Resim
        '
        Me.colsKodu_Resim.Caption = "Ürün Kodu"
        Me.colsKodu_Resim.FieldName = "sKodu"
        Me.colsKodu_Resim.Name = "colsKodu_Resim"
        Me.colsKodu_Resim.Visible = True
        Me.colsKodu_Resim.VisibleIndex = 2
        Me.colsKodu_Resim.Width = 120
        '
        'colsRenkAdi_Resim
        '
        Me.colsRenkAdi_Resim.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colsRenkAdi_Resim.AppearanceCell.Options.UseBackColor = True
        Me.colsRenkAdi_Resim.Caption = "Renk"
        Me.colsRenkAdi_Resim.FieldName = "sRenkAdi"
        Me.colsRenkAdi_Resim.Name = "colsRenkAdi_Resim"
        Me.colsRenkAdi_Resim.Visible = True
        Me.colsRenkAdi_Resim.VisibleIndex = 4
        Me.colsRenkAdi_Resim.Width = 80
        '
        'colsBeden_Resim
        '
        Me.colsBeden_Resim.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colsBeden_Resim.AppearanceCell.Options.UseBackColor = True
        Me.colsBeden_Resim.Caption = "Beden"
        Me.colsBeden_Resim.FieldName = "sBeden"
        Me.colsBeden_Resim.Name = "colsBeden_Resim"
        Me.colsBeden_Resim.Visible = True
        Me.colsBeden_Resim.VisibleIndex = 5
        Me.colsBeden_Resim.Width = 50
        '
        'colsKavala_Resim
        '
        Me.colsKavala_Resim.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colsKavala_Resim.AppearanceCell.Options.UseBackColor = True
        Me.colsKavala_Resim.Caption = "Kavala"
        Me.colsKavala_Resim.FieldName = "sKavala"
        Me.colsKavala_Resim.Name = "colsKavala_Resim"
        Me.colsKavala_Resim.Visible = True
        Me.colsKavala_Resim.VisibleIndex = 6
        Me.colsKavala_Resim.Width = 60
        '
        'colpResim
        '
        Me.colpResim.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.colpResim.AppearanceCell.Options.UseBackColor = True
        Me.colpResim.Caption = "Resim"
        Me.colpResim.ColumnEdit = Me.sec_pResim
        Me.colpResim.FieldName = "ResimBytes"
        Me.colpResim.Name = "colpResim"
        Me.colpResim.OptionsColumn.AllowEdit = False
        Me.colpResim.OptionsColumn.AllowFocus = False
        Me.colpResim.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Max, "pResim", "{0} Kayt")})
        Me.colpResim.Visible = True
        Me.colpResim.VisibleIndex = 0
        Me.colpResim.Width = 368
        '
        'sec_pResim
        '
        Me.sec_pResim.Name = "sec_pResim"
        Me.sec_pResim.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        '
        'colsAciklama2
        '
        Me.colsAciklama2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colsAciklama2.AppearanceCell.Options.UseBackColor = True
        Me.colsAciklama2.Caption = "Açıklama"
        Me.colsAciklama2.FieldName = "sAciklama"
        Me.colsAciklama2.Name = "colsAciklama2"
        Me.colsAciklama2.Visible = True
        Me.colsAciklama2.VisibleIndex = 3
        Me.colsAciklama2.Width = 387
        '
        'colsKullaniciAdi
        '
        Me.colsKullaniciAdi.Caption = "Kaydeden"
        Me.colsKullaniciAdi.FieldName = "sKullaniciAdi"
        Me.colsKullaniciAdi.Name = "colsKullaniciAdi"
        Me.colsKullaniciAdi.OptionsColumn.AllowEdit = False
        Me.colsKullaniciAdi.OptionsColumn.AllowFocus = False
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "KayıtTarihi"
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        Me.coldteKayitTarihi.OptionsColumn.AllowEdit = False
        Me.coldteKayitTarihi.OptionsColumn.AllowFocus = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnAIResimEkle)
        Me.PanelControl2.Controls.Add(Me.SimpleButton13)
        Me.PanelControl2.Controls.Add(Me.SimpleButton9)
        Me.PanelControl2.Controls.Add(Me.SimpleButton12)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 416)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1357, 60)
        Me.PanelControl2.TabIndex = 1
        '
        'btnAIResimEkle
        '
        Me.btnAIResimEkle.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAIResimEkle.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAIResimEkle.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnAIResimEkle.Appearance.Options.UseBackColor = True
        Me.btnAIResimEkle.Appearance.Options.UseFont = True
        Me.btnAIResimEkle.Appearance.Options.UseForeColor = True
        Me.btnAIResimEkle.Location = New System.Drawing.Point(540, 9)
        Me.btnAIResimEkle.Name = "btnAIResimEkle"
        Me.btnAIResimEkle.Size = New System.Drawing.Size(150, 40)
        Me.btnAIResimEkle.TabIndex = 17
        Me.btnAIResimEkle.Text = "🖼️ AI Resim Ekle"
        '
        'SimpleButton13
        '
        Me.SimpleButton13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton13.Image = CType(resources.GetObject("SimpleButton13.Image"), System.Drawing.Image)
        Me.SimpleButton13.Location = New System.Drawing.Point(314, 9)
        Me.SimpleButton13.Name = "SimpleButton13"
        Me.SimpleButton13.Size = New System.Drawing.Size(120, 34)
        Me.SimpleButton13.TabIndex = 16
        Me.SimpleButton13.Text = "&Yazdr"
        '
        'SimpleButton9
        '
        Me.SimpleButton9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton9.Image = CType(resources.GetObject("SimpleButton9.Image"), System.Drawing.Image)
        Me.SimpleButton9.Location = New System.Drawing.Point(194, 9)
        Me.SimpleButton9.Name = "SimpleButton9"
        Me.SimpleButton9.Size = New System.Drawing.Size(120, 34)
        Me.SimpleButton9.TabIndex = 15
        Me.SimpleButton9.Text = "&Sil"
        '
        'SimpleButton12
        '
        Me.SimpleButton12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton12.Image = CType(resources.GetObject("SimpleButton12.Image"), System.Drawing.Image)
        Me.SimpleButton12.Location = New System.Drawing.Point(74, 9)
        Me.SimpleButton12.Name = "SimpleButton12"
        Me.SimpleButton12.Size = New System.Drawing.Size(120, 34)
        Me.SimpleButton12.TabIndex = 14
        Me.SimpleButton12.Text = "&Ekle"
        '
        'XtraTabPage7
        '
        Me.XtraTabPage7.Controls.Add(Me.GridControl5)
        Me.XtraTabPage7.Controls.Add(Me.GroupControl7)
        Me.XtraTabPage7.Image = CType(resources.GetObject("XtraTabPage7.Image"), System.Drawing.Image)
        Me.XtraTabPage7.Name = "XtraTabPage7"
        Me.XtraTabPage7.Size = New System.Drawing.Size(1357, 476)
        Me.XtraTabPage7.Text = "Hareketler"
        '
        'GridControl5
        '
        Me.GridControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl5.Location = New System.Drawing.Point(0, 71)
        Me.GridControl5.MainView = Me.GridView4
        Me.GridControl5.Name = "GridControl5"
        Me.GridControl5.Size = New System.Drawing.Size(1357, 405)
        Me.GridControl5.TabIndex = 0
        Me.GridControl5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView4.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView4.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView4.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colsFisTipi, Me.GridColumn1, Me.collFisNo, Me.coldteFisTarihi, Me.collGirisFiyat, Me.collCikisFiyat, Me.collGirisMiktar1, Me.collCikisMiktar1, Me.collDovizKuru1, Me.colsDovizCinsi1, Me.collBrutFiyat, Me.collIskontoTutari, Me.colnKdvOrani, Me.colnGirisCikis, Me.colsDepo, Me.colnAlisverisID, Me.GridColumn2, Me.GridColumn3, Me.collKodu, Me.colFIRMAADI, Me.GridColumn4, Me.colFIRMA, Me.colKALAN, Me.collBrutTutar, Me.GridColumn5, Me.colStoksKodu, Me.colsModel, Me.GridColumn6, Me.GridColumn7, Me.colsStokAciklama, Me.colsAvYapanAdi, Me.colsSaticiRumuzu})
        Me.GridView4.CustomizationFormBounds = New System.Drawing.Rectangle(616, 313, 208, 170)
        Me.GridView4.DetailHeight = 160
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.GridControl = Me.GridControl5
        Me.GridView4.GroupFormat = "{0}: {1} {2}"
        Me.GridView4.GroupPanelText = "Gruplamak stediiniz Kolonu Buraya Srkleyiniz..."
        Me.GridView4.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBrutTutar", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGirisMiktar1", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lCikisMiktar1", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteFisTarihi", Nothing, "{0} Kayt")})
        Me.GridView4.IndicatorWidth = 12
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsCustomization.AllowFilter = False
        Me.GridView4.OptionsCustomization.AllowGroup = False
        Me.GridView4.OptionsDetail.ShowDetailTabs = False
        Me.GridView4.OptionsPrint.ExpandAllGroups = False
        Me.GridView4.OptionsSelection.MultiSelect = True
        Me.GridView4.OptionsView.ShowFooter = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.OptionsView.ShowIndicator = False
        '
        'colsFisTipi
        '
        Me.colsFisTipi.Caption = "FisTipi"
        Me.colsFisTipi.FieldName = "sFisTipi"
        Me.colsFisTipi.Name = "colsFisTipi"
        Me.colsFisTipi.Visible = True
        Me.colsFisTipi.VisibleIndex = 1
        Me.colsFisTipi.Width = 44
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Fiş Açıklama"
        Me.GridColumn1.FieldName = "sAciklama"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Width = 44
        '
        'collFisNo
        '
        Me.collFisNo.Caption = "Fiş No"
        Me.collFisNo.FieldName = "lFisNo"
        Me.collFisNo.Name = "collFisNo"
        Me.collFisNo.Visible = True
        Me.collFisNo.VisibleIndex = 2
        Me.collFisNo.Width = 44
        '
        'coldteFisTarihi
        '
        Me.coldteFisTarihi.Caption = "Tarih"
        Me.coldteFisTarihi.FieldName = "dteFisTarihi"
        Me.coldteFisTarihi.Name = "coldteFisTarihi"
        Me.coldteFisTarihi.Visible = True
        Me.coldteFisTarihi.VisibleIndex = 0
        Me.coldteFisTarihi.Width = 65
        '
        'collGirisFiyat
        '
        Me.collGirisFiyat.Caption = "Giriş Fiyat"
        Me.collGirisFiyat.DisplayFormat.FormatString = "#,0.00"
        Me.collGirisFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGirisFiyat.FieldName = "lGirisFiyat"
        Me.collGirisFiyat.Name = "collGirisFiyat"
        '
        'collCikisFiyat
        '
        Me.collCikisFiyat.Caption = "Çıkış Fiyat"
        Me.collCikisFiyat.DisplayFormat.FormatString = "#,0.00"
        Me.collCikisFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collCikisFiyat.FieldName = "lCikisFiyat"
        Me.collCikisFiyat.Name = "collCikisFiyat"
        '
        'collGirisMiktar1
        '
        Me.collGirisMiktar1.Caption = "Giren"
        Me.collGirisMiktar1.DisplayFormat.FormatString = "#,0.##"
        Me.collGirisMiktar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collGirisMiktar1.FieldName = "lGirisMiktar1"
        Me.collGirisMiktar1.Name = "collGirisMiktar1"
        Me.collGirisMiktar1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGirisMiktar1", "{0:#,0.##}")})
        Me.collGirisMiktar1.Visible = True
        Me.collGirisMiktar1.VisibleIndex = 3
        Me.collGirisMiktar1.Width = 44
        '
        'collCikisMiktar1
        '
        Me.collCikisMiktar1.Caption = "Çıkan"
        Me.collCikisMiktar1.DisplayFormat.FormatString = "#,0.##"
        Me.collCikisMiktar1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collCikisMiktar1.FieldName = "lCikisMiktar1"
        Me.collCikisMiktar1.Name = "collCikisMiktar1"
        Me.collCikisMiktar1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lCikisMiktar1", "{0:#,0.##}")})
        Me.collCikisMiktar1.Visible = True
        Me.collCikisMiktar1.VisibleIndex = 4
        Me.collCikisMiktar1.Width = 44
        '
        'collDovizKuru1
        '
        Me.collDovizKuru1.Caption = "Döviz Kuru"
        Me.collDovizKuru1.FieldName = "lDovizKuru1"
        Me.collDovizKuru1.Name = "collDovizKuru1"
        '
        'colsDovizCinsi1
        '
        Me.colsDovizCinsi1.Caption = "Pb"
        Me.colsDovizCinsi1.FieldName = "sDovizCinsi1"
        Me.colsDovizCinsi1.Name = "colsDovizCinsi1"
        '
        'collBrutFiyat
        '
        Me.collBrutFiyat.Caption = "Fiyat"
        Me.collBrutFiyat.DisplayFormat.FormatString = "#,0.00"
        Me.collBrutFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutFiyat.FieldName = "lBrutFiyat"
        Me.collBrutFiyat.Name = "collBrutFiyat"
        Me.collBrutFiyat.Visible = True
        Me.collBrutFiyat.VisibleIndex = 6
        Me.collBrutFiyat.Width = 44
        '
        'collIskontoTutari
        '
        Me.collIskontoTutari.Caption = "İskonto"
        Me.collIskontoTutari.DisplayFormat.FormatString = "#,0.00"
        Me.collIskontoTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collIskontoTutari.FieldName = "lIskontoTutari"
        Me.collIskontoTutari.Name = "collIskontoTutari"
        Me.collIskontoTutari.Width = 55
        '
        'colnKdvOrani
        '
        Me.colnKdvOrani.Caption = "Kdv"
        Me.colnKdvOrani.DisplayFormat.FormatString = "#,0.##"
        Me.colnKdvOrani.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnKdvOrani.FieldName = "nKdvOrani"
        Me.colnKdvOrani.Name = "colnKdvOrani"
        Me.colnKdvOrani.Width = 34
        '
        'colnGirisCikis
        '
        Me.colnGirisCikis.Caption = "Giriş/Çıkış"
        Me.colnGirisCikis.FieldName = "nGirisCikis"
        Me.colnGirisCikis.Name = "colnGirisCikis"
        Me.colnGirisCikis.Width = 44
        '
        'colsDepo
        '
        Me.colsDepo.Caption = "Depo"
        Me.colsDepo.FieldName = "sDepo"
        Me.colsDepo.Name = "colsDepo"
        Me.colsDepo.Visible = True
        Me.colsDepo.VisibleIndex = 8
        Me.colsDepo.Width = 62
        '
        'colnAlisverisID
        '
        Me.colnAlisverisID.Caption = "Alış Veriş No"
        Me.colnAlisverisID.FieldName = "nAlisverisID"
        Me.colnAlisverisID.Name = "colnAlisverisID"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Müşteri No"
        Me.GridColumn2.FieldName = "nMusteriID"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Firma No"
        Me.GridColumn3.FieldName = "nFirmaID"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'collKodu
        '
        Me.collKodu.Caption = "Hesap Kodu"
        Me.collKodu.FieldName = "HESAPKODU"
        Me.collKodu.Name = "collKodu"
        Me.collKodu.Visible = True
        Me.collKodu.VisibleIndex = 9
        Me.collKodu.Width = 62
        '
        'colFIRMAADI
        '
        Me.colFIRMAADI.Caption = "Hesap Adı"
        Me.colFIRMAADI.FieldName = "HESAPADI"
        Me.colFIRMAADI.Name = "colFIRMAADI"
        Me.colFIRMAADI.Visible = True
        Me.colFIRMAADI.VisibleIndex = 10
        Me.colFIRMAADI.Width = 101
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Kodu"
        Me.GridColumn4.FieldName = "sKodu"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'colFIRMA
        '
        Me.colFIRMA.Caption = "Firma"
        Me.colFIRMA.FieldName = "FIRMA"
        Me.colFIRMA.Name = "colFIRMA"
        '
        'colKALAN
        '
        Me.colKALAN.Caption = "Kalan"
        Me.colKALAN.DisplayFormat.FormatString = "#,0.####"
        Me.colKALAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKALAN.FieldName = "KALAN"
        Me.colKALAN.Name = "colKALAN"
        Me.colKALAN.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "KALAN", "{0:#,0.####}")})
        Me.colKALAN.Visible = True
        Me.colKALAN.VisibleIndex = 5
        Me.colKALAN.Width = 44
        '
        'collBrutTutar
        '
        Me.collBrutTutar.Caption = "Tutar"
        Me.collBrutTutar.DisplayFormat.FormatString = "#,0.00"
        Me.collBrutTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collBrutTutar.FieldName = "lBrutTutar"
        Me.collBrutTutar.Name = "collBrutTutar"
        Me.collBrutTutar.Visible = True
        Me.collBrutTutar.VisibleIndex = 7
        Me.collBrutTutar.Width = 42
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Stok No"
        Me.GridColumn5.FieldName = "nStokID"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'colStoksKodu
        '
        Me.colStoksKodu.Caption = "Stok Kodu"
        Me.colStoksKodu.FieldName = "sStokKodu"
        Me.colStoksKodu.Name = "colStoksKodu"
        Me.colStoksKodu.Width = 70
        '
        'colsModel
        '
        Me.colsModel.Caption = "Model"
        Me.colsModel.FieldName = "sModel"
        Me.colsModel.Name = "colsModel"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Renk"
        Me.GridColumn6.FieldName = "sRenk"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Beden"
        Me.GridColumn7.FieldName = "sBeden"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'colsStokAciklama
        '
        Me.colsStokAciklama.Caption = "Stok Adı"
        Me.colsStokAciklama.FieldName = "sStokAciklama"
        Me.colsStokAciklama.Name = "colsStokAciklama"
        Me.colsStokAciklama.Width = 95
        '
        'colsAvYapanAdi
        '
        Me.colsAvYapanAdi.Caption = "Av.Yapan"
        Me.colsAvYapanAdi.FieldName = "sAvYapanAdi"
        Me.colsAvYapanAdi.Name = "colsAvYapanAdi"
        '
        'colsSaticiRumuzu
        '
        Me.colsSaticiRumuzu.Caption = "Satici"
        Me.colsSaticiRumuzu.FieldName = "sSaticiRumuzu"
        Me.colsSaticiRumuzu.Name = "colsSaticiRumuzu"
        '
        'GroupControl7
        '
        Me.GroupControl7.Controls.Add(Me.btn_Listele)
        Me.GroupControl7.Controls.Add(Me.LabelControl33)
        Me.GroupControl7.Controls.Add(Me.DateEdit2)
        Me.GroupControl7.Controls.Add(Me.DateEdit1)
        Me.GroupControl7.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl7.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(1357, 71)
        Me.GroupControl7.TabIndex = 1
        Me.GroupControl7.Text = "Ara"
        '
        'btn_Listele
        '
        Me.btn_Listele.Image = Global.business_smart.My.Resources.Resources.find
        Me.btn_Listele.Location = New System.Drawing.Point(485, 31)
        Me.btn_Listele.Name = "btn_Listele"
        Me.btn_Listele.Size = New System.Drawing.Size(331, 33)
        Me.btn_Listele.TabIndex = 30
        Me.btn_Listele.Text = "Listele"
        '
        'LabelControl33
        '
        Me.LabelControl33.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl33.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl33.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl33.Location = New System.Drawing.Point(13, 34)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(128, 29)
        Me.LabelControl33.TabIndex = 29
        Me.LabelControl33.Text = "Tarih:"
        '
        'DateEdit2
        '
        Me.DateEdit2.EditValue = New Date(2078, 12, 31, 0, 0, 0, 0)
        Me.DateEdit2.EnterMoveNextControl = True
        Me.DateEdit2.Location = New System.Drawing.Point(315, 36)
        Me.DateEdit2.Name = "DateEdit2"
        Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit2.Size = New System.Drawing.Size(160, 26)
        Me.DateEdit2.TabIndex = 28
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DateEdit1.EnterMoveNextControl = True
        Me.DateEdit1.Location = New System.Drawing.Point(144, 36)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateEdit1.Size = New System.Drawing.Size(160, 26)
        Me.DateEdit1.TabIndex = 27
        '
        'XtraTabPage9
        '
        Me.XtraTabPage9.Controls.Add(Me.GridControl7)
        Me.XtraTabPage9.Controls.Add(Me.PanelControl6)
        Me.XtraTabPage9.Image = Global.business_smart.My.Resources.Resources.signpost
        Me.XtraTabPage9.Name = "XtraTabPage9"
        Me.XtraTabPage9.Size = New System.Drawing.Size(1357, 476)
        Me.XtraTabPage9.Text = "Alternatif"
        '
        'GridControl7
        '
        Me.GridControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl7.Location = New System.Drawing.Point(0, 0)
        Me.GridControl7.MainView = Me.GridView5
        Me.GridControl7.Name = "GridControl7"
        Me.GridControl7.Size = New System.Drawing.Size(1357, 416)
        Me.GridControl7.TabIndex = 3
        Me.GridControl7.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
        '
        'GridView5
        '
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
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn30, Me.GridColumn32, Me.GridColumn33, Me.GridColumn34, Me.GridColumn35, Me.GridColumn36, Me.GridColumn37})
        Me.GridView5.CustomizationFormBounds = New System.Drawing.Rectangle(616, 313, 208, 170)
        Me.GridView5.DetailHeight = 160
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.GridControl = Me.GridControl7
        Me.GridView5.GroupFormat = "{0}: {1} {2}"
        Me.GridView5.GroupPanelText = "Gruplamak stediiniz Kolonu Buraya Srkleyiniz..."
        Me.GridView5.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lBrutTutar", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lGirisMiktar1", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lCikisMiktar1", Nothing, "{0:#,0.00}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "dteFisTarihi", Nothing, "{0} Kayt")})
        Me.GridView5.IndicatorWidth = 12
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.Editable = False
        Me.GridView5.OptionsCustomization.AllowFilter = False
        Me.GridView5.OptionsCustomization.AllowGroup = False
        Me.GridView5.OptionsDetail.ShowDetailTabs = False
        Me.GridView5.OptionsPrint.ExpandAllGroups = False
        Me.GridView5.OptionsSelection.MultiSelect = True
        Me.GridView5.OptionsView.ShowFooter = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.OptionsView.ShowIndicator = False
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "Kalan"
        Me.GridColumn30.DisplayFormat.FormatString = "#,0.####"
        Me.GridColumn30.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn30.FieldName = "KALAN"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "KALAN", "{0:#,0.####}")})
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 3
        Me.GridColumn30.Width = 215
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "Stok No"
        Me.GridColumn32.FieldName = "nStokID"
        Me.GridColumn32.Name = "GridColumn32"
        '
        'GridColumn33
        '
        Me.GridColumn33.Caption = "Stok Kodu"
        Me.GridColumn33.FieldName = "sKodu"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", "{0} Kayt")})
        Me.GridColumn33.Visible = True
        Me.GridColumn33.VisibleIndex = 0
        Me.GridColumn33.Width = 233
        '
        'GridColumn34
        '
        Me.GridColumn34.Caption = "Model"
        Me.GridColumn34.FieldName = "sModel"
        Me.GridColumn34.Name = "GridColumn34"
        '
        'GridColumn35
        '
        Me.GridColumn35.Caption = "Renk"
        Me.GridColumn35.FieldName = "sRenkAdi"
        Me.GridColumn35.Name = "GridColumn35"
        Me.GridColumn35.Visible = True
        Me.GridColumn35.VisibleIndex = 2
        Me.GridColumn35.Width = 361
        '
        'GridColumn36
        '
        Me.GridColumn36.Caption = "Beden"
        Me.GridColumn36.FieldName = "sBeden"
        Me.GridColumn36.Name = "GridColumn36"
        '
        'GridColumn37
        '
        Me.GridColumn37.Caption = "Stok Adı"
        Me.GridColumn37.FieldName = "sAciklama"
        Me.GridColumn37.Name = "GridColumn37"
        Me.GridColumn37.Visible = True
        Me.GridColumn37.VisibleIndex = 1
        Me.GridColumn37.Width = 459
        '
        'PanelControl6
        '
        Me.PanelControl6.Controls.Add(Me.SimpleButton14)
        Me.PanelControl6.Controls.Add(Me.btn_Alternatif_Yazdir)
        Me.PanelControl6.Controls.Add(Me.btn_Alternatif_Sil)
        Me.PanelControl6.Controls.Add(Me.btn_Alternatif_Ekle)
        Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl6.Location = New System.Drawing.Point(0, 416)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(1357, 60)
        Me.PanelControl6.TabIndex = 2
        '
        'SimpleButton14
        '
        Me.SimpleButton14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton14.Image = CType(resources.GetObject("SimpleButton14.Image"), System.Drawing.Image)
        Me.SimpleButton14.Location = New System.Drawing.Point(434, 9)
        Me.SimpleButton14.Name = "SimpleButton14"
        Me.SimpleButton14.Size = New System.Drawing.Size(120, 34)
        Me.SimpleButton14.TabIndex = 17
        Me.SimpleButton14.Text = "&A&ltertanifi"
        '
        'btn_Alternatif_Yazdir
        '
        Me.btn_Alternatif_Yazdir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Alternatif_Yazdir.Image = CType(resources.GetObject("btn_Alternatif_Yazdir.Image"), System.Drawing.Image)
        Me.btn_Alternatif_Yazdir.Location = New System.Drawing.Point(314, 9)
        Me.btn_Alternatif_Yazdir.Name = "btn_Alternatif_Yazdir"
        Me.btn_Alternatif_Yazdir.Size = New System.Drawing.Size(120, 34)
        Me.btn_Alternatif_Yazdir.TabIndex = 16
        Me.btn_Alternatif_Yazdir.Text = "&Yazdr"
        '
        'btn_Alternatif_Sil
        '
        Me.btn_Alternatif_Sil.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Alternatif_Sil.Image = CType(resources.GetObject("btn_Alternatif_Sil.Image"), System.Drawing.Image)
        Me.btn_Alternatif_Sil.Location = New System.Drawing.Point(194, 9)
        Me.btn_Alternatif_Sil.Name = "btn_Alternatif_Sil"
        Me.btn_Alternatif_Sil.Size = New System.Drawing.Size(120, 34)
        Me.btn_Alternatif_Sil.TabIndex = 15
        Me.btn_Alternatif_Sil.Text = "&Sil"
        '
        'btn_Alternatif_Ekle
        '
        Me.btn_Alternatif_Ekle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Alternatif_Ekle.Image = CType(resources.GetObject("btn_Alternatif_Ekle.Image"), System.Drawing.Image)
        Me.btn_Alternatif_Ekle.Location = New System.Drawing.Point(74, 9)
        Me.btn_Alternatif_Ekle.Name = "btn_Alternatif_Ekle"
        Me.btn_Alternatif_Ekle.Size = New System.Drawing.Size(120, 34)
        Me.btn_Alternatif_Ekle.TabIndex = 14
        Me.btn_Alternatif_Ekle.Text = "&Ekle"
        '
        'XtraTabPage10
        '
        Me.XtraTabPage10.Controls.Add(Me.GridControl8)
        Me.XtraTabPage10.Image = Global.business_smart.My.Resources.Resources.help
        Me.XtraTabPage10.Name = "XtraTabPage10"
        Me.XtraTabPage10.Size = New System.Drawing.Size(1357, 476)
        Me.XtraTabPage10.Text = "Muhasebe"
        '
        'GridControl8
        '
        Me.GridControl8.DataMember = "Table1"
        Me.GridControl8.DataSource = Me.ds_tbStokSinifi
        Me.GridControl8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl8.Location = New System.Drawing.Point(0, 0)
        Me.GridControl8.MainView = Me.GridView7
        Me.GridControl8.Name = "GridControl8"
        Me.GridControl8.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_sHesapPlani})
        Me.GridControl8.Size = New System.Drawing.Size(1357, 476)
        Me.GridControl8.TabIndex = 5
        Me.GridControl8.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView7})
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12})
        Me.GridView7.DetailHeight = 160
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.GridControl = Me.GridControl8
        Me.GridView7.GroupFormat = "{0}: {1} {2}"
        Me.GridView7.GroupPanelText = "Gruplamak stediiniz Kolonu Buraya Srkleyiniz..."
        Me.GridView7.IndicatorWidth = 12
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView7.OptionsCustomization.AllowFilter = False
        Me.GridView7.OptionsCustomization.AllowGroup = False
        Me.GridView7.OptionsCustomization.AllowSort = False
        Me.GridView7.OptionsDetail.ShowDetailTabs = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        Me.GridView7.OptionsView.ShowIndicator = False
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Müşteri ID"
        Me.GridColumn8.FieldName = "nMusteriID"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.AllowFocus = False
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GridColumn9.AppearanceCell.Options.UseFont = True
        Me.GridColumn9.Caption = "HesapTipi"
        Me.GridColumn9.FieldName = "sAciklama"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.AllowFocus = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        Me.GridColumn9.Width = 237
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "HesapKodu"
        Me.GridColumn10.ColumnEdit = Me.sec_sHesapPlani
        Me.GridColumn10.FieldName = "nHesapID"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 1
        Me.GridColumn10.Width = 263
        '
        'sec_sHesapPlani
        '
        Me.sec_sHesapPlani.AutoHeight = False
        Me.sec_sHesapPlani.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_sHesapPlani.DisplayMember = "sKodu"
        Me.sec_sHesapPlani.Name = "sec_sHesapPlani"
        Me.sec_sHesapPlani.NullText = ""
        Me.sec_sHesapPlani.ValueMember = "nHesapID"
        Me.sec_sHesapPlani.View = Me.GridView9
        '
        'GridView9
        '
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsBehavior.Editable = False
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView9.OptionsView.ShowAutoFilterRow = True
        Me.GridView9.OptionsView.ShowGroupPanel = False
        Me.GridView9.OptionsView.ShowIndicator = False
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GridColumn11.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.GridColumn11.AppearanceCell.Options.UseFont = True
        Me.GridColumn11.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn11.Caption = "Açıklama"
        Me.GridColumn11.FieldName = "sHesapAciklama"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.OptionsColumn.AllowFocus = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 2
        Me.GridColumn11.Width = 310
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Satış Yapılamaz"
        Me.GridColumn12.FieldName = "bSatisYapilamaz"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.AllowEdit = False
        Me.GridColumn12.OptionsColumn.AllowFocus = False
        '
        'PanelControl4
        '
        Me.PanelControl4.Appearance.BackColor = System.Drawing.Color.Black
        Me.PanelControl4.Appearance.Options.UseBackColor = True
        Me.PanelControl4.Controls.Add(Me.LabelControl21)
        Me.PanelControl4.Controls.Add(Me.TextEdit7)
        Me.PanelControl4.Controls.Add(Me.LabelControl20)
        Me.PanelControl4.Controls.Add(Me.TextEdit6)
        Me.PanelControl4.Controls.Add(Me.LabelControl19)
        Me.PanelControl4.Controls.Add(Me.TextEdit5)
        Me.PanelControl4.Controls.Add(Me.LabelControl18)
        Me.PanelControl4.Controls.Add(Me.TextEdit4)
        Me.PanelControl4.Controls.Add(Me.LabelControl16)
        Me.PanelControl4.Controls.Add(Me.TextEdit3)
        Me.PanelControl4.Controls.Add(Me.lbl_sMiktar)
        Me.PanelControl4.Controls.Add(Me.TextEdit8)
        Me.PanelControl4.Controls.Add(Me.TextEdit9)
        Me.PanelControl4.Controls.Add(Me.TextEdit10)
        Me.PanelControl4.Controls.Add(Me.TextEdit11)
        Me.PanelControl4.Controls.Add(Me.TextEdit12)
        Me.PanelControl4.Controls.Add(Me.LabelControl23)
        Me.PanelControl4.Controls.Add(Me.SimpleButton5)
        Me.PanelControl4.Controls.Add(Me.SimpleButton6)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(2, 514)
        Me.PanelControl4.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.PanelControl4.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(1363, 64)
        Me.PanelControl4.TabIndex = 0
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl21.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl21.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.LabelControl21.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl21.Location = New System.Drawing.Point(846, 6)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(176, 25)
        Me.LabelControl21.TabIndex = 74
        Me.LabelControl21.Text = "Kalan"
        '
        'TextEdit7
        '
        Me.TextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStokBakiyesi, "Table1.nKalan", True))
        Me.TextEdit7.EditValue = 0
        Me.TextEdit7.Enabled = False
        Me.TextEdit7.EnterMoveNextControl = True
        Me.TextEdit7.Location = New System.Drawing.Point(850, 29)
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.TextEdit7.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit7.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit7.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit7.Properties.Appearance.Options.UseFont = True
        Me.TextEdit7.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit7.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit7.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit7.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit7.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit7.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit7.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit7.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit7.Properties.DisplayFormat.FormatString = "#,0.####"
        Me.TextEdit7.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit7.Properties.EditFormat.FormatString = "#,0.####"
        Me.TextEdit7.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit7.Properties.MaxLength = 60
        Me.TextEdit7.Properties.NullText = "0.00"
        Me.TextEdit7.Properties.ReadOnly = True
        Me.TextEdit7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit7.Size = New System.Drawing.Size(176, 26)
        Me.TextEdit7.TabIndex = 73
        '
        'ds_tbStokBakiyesi
        '
        Me.ds_tbStokBakiyesi.DataSetName = "NewDataSet"
        Me.ds_tbStokBakiyesi.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbStokBakiyesi.Tables.AddRange(New System.Data.DataTable() {Me.DataTable3})
        '
        'DataTable3
        '
        Me.DataTable3.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn43, Me.DataColumn44, Me.DataColumn45, Me.DataColumn46, Me.DataColumn47})
        Me.DataTable3.TableName = "Table1"
        '
        'DataColumn43
        '
        Me.DataColumn43.ColumnName = "nGiris"
        Me.DataColumn43.DataType = GetType(Decimal)
        '
        'DataColumn44
        '
        Me.DataColumn44.ColumnName = "nGirisIade"
        Me.DataColumn44.DataType = GetType(Decimal)
        '
        'DataColumn45
        '
        Me.DataColumn45.ColumnName = "nCikis"
        Me.DataColumn45.DataType = GetType(Decimal)
        '
        'DataColumn46
        '
        Me.DataColumn46.ColumnName = "nCikisIade"
        Me.DataColumn46.DataType = GetType(Decimal)
        '
        'DataColumn47
        '
        Me.DataColumn47.ColumnName = "nKalan"
        Me.DataColumn47.DataType = GetType(Decimal)
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl20.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl20.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.LabelControl20.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl20.Location = New System.Drawing.Point(675, 6)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(171, 25)
        Me.LabelControl20.TabIndex = 72
        Me.LabelControl20.Text = "İade Alınan"
        '
        'TextEdit6
        '
        Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStokBakiyesi, "Table1.nCikisIade", True))
        Me.TextEdit6.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TextEdit6.Enabled = False
        Me.TextEdit6.EnterMoveNextControl = True
        Me.TextEdit6.Location = New System.Drawing.Point(675, 29)
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.TextEdit6.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit6.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit6.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit6.Properties.Appearance.Options.UseFont = True
        Me.TextEdit6.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit6.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit6.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit6.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit6.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit6.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit6.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit6.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit6.Properties.DisplayFormat.FormatString = "#,0.####"
        Me.TextEdit6.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit6.Properties.EditFormat.FormatString = "#,0.####"
        Me.TextEdit6.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit6.Properties.MaxLength = 60
        Me.TextEdit6.Properties.NullText = "0.00"
        Me.TextEdit6.Properties.ReadOnly = True
        Me.TextEdit6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit6.Size = New System.Drawing.Size(171, 26)
        Me.TextEdit6.TabIndex = 71
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl19.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl19.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.LabelControl19.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl19.Location = New System.Drawing.Point(501, 6)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(171, 25)
        Me.LabelControl19.TabIndex = 70
        Me.LabelControl19.Text = "Çıkış"
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStokBakiyesi, "Table1.nCikis", True))
        Me.TextEdit5.EditValue = "0"
        Me.TextEdit5.Enabled = False
        Me.TextEdit5.EnterMoveNextControl = True
        Me.TextEdit5.Location = New System.Drawing.Point(501, 29)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.TextEdit5.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit5.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit5.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit5.Properties.Appearance.Options.UseFont = True
        Me.TextEdit5.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit5.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit5.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit5.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit5.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit5.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit5.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit5.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit5.Properties.DisplayFormat.FormatString = "#,0.####"
        Me.TextEdit5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit5.Properties.EditFormat.FormatString = "#,0.####"
        Me.TextEdit5.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit5.Properties.MaxLength = 60
        Me.TextEdit5.Properties.NullText = "0.00"
        Me.TextEdit5.Properties.ReadOnly = True
        Me.TextEdit5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit5.Size = New System.Drawing.Size(171, 26)
        Me.TextEdit5.TabIndex = 69
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl18.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl18.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.LabelControl18.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl18.Location = New System.Drawing.Point(326, 6)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(172, 25)
        Me.LabelControl18.TabIndex = 68
        Me.LabelControl18.Text = "İade Edilen"
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStokBakiyesi, "Table1.nGirisIade", True))
        Me.TextEdit4.EditValue = "0"
        Me.TextEdit4.Enabled = False
        Me.TextEdit4.EnterMoveNextControl = True
        Me.TextEdit4.Location = New System.Drawing.Point(326, 29)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.TextEdit4.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.TextEdit4.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit4.Properties.Appearance.Options.UseFont = True
        Me.TextEdit4.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit4.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit4.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit4.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit4.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit4.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit4.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit4.Properties.DisplayFormat.FormatString = "#,0.####"
        Me.TextEdit4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit4.Properties.EditFormat.FormatString = "#,0.####"
        Me.TextEdit4.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit4.Properties.MaxLength = 60
        Me.TextEdit4.Properties.NullText = "0.00"
        Me.TextEdit4.Properties.ReadOnly = True
        Me.TextEdit4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit4.Size = New System.Drawing.Size(172, 26)
        Me.TextEdit4.TabIndex = 67
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl16.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl16.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.LabelControl16.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl16.Location = New System.Drawing.Point(146, 6)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(171, 25)
        Me.LabelControl16.TabIndex = 66
        Me.LabelControl16.Text = "Giriş"
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStokBakiyesi, "Table1.nGiris", True))
        Me.TextEdit3.EditValue = "0"
        Me.TextEdit3.Enabled = False
        Me.TextEdit3.EnterMoveNextControl = True
        Me.TextEdit3.Location = New System.Drawing.Point(146, 29)
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
        Me.TextEdit3.Properties.DisplayFormat.FormatString = "#,0.####"
        Me.TextEdit3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit3.Properties.EditFormat.FormatString = "#,0.####"
        Me.TextEdit3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit3.Properties.MaxLength = 60
        Me.TextEdit3.Properties.NullText = "0.00"
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit3.Size = New System.Drawing.Size(177, 26)
        Me.TextEdit3.TabIndex = 65
        '
        'lbl_sMiktar
        '
        Me.lbl_sMiktar.Appearance.ForeColor = System.Drawing.Color.White
        Me.lbl_sMiktar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_sMiktar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_sMiktar.Location = New System.Drawing.Point(82, 27)
        Me.lbl_sMiktar.Name = "lbl_sMiktar"
        Me.lbl_sMiktar.Size = New System.Drawing.Size(49, 19)
        Me.lbl_sMiktar.TabIndex = 64
        Me.lbl_sMiktar.Text = "Miktar:"
        '
        'TextEdit8
        '
        Me.TextEdit8.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStokTutari, "Table1.nKalan", True))
        Me.TextEdit8.EditValue = 0
        Me.TextEdit8.Enabled = False
        Me.TextEdit8.EnterMoveNextControl = True
        Me.TextEdit8.Location = New System.Drawing.Point(850, 63)
        Me.TextEdit8.Name = "TextEdit8"
        Me.TextEdit8.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.TextEdit8.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit8.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit8.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit8.Properties.Appearance.Options.UseFont = True
        Me.TextEdit8.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit8.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit8.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit8.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit8.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit8.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit8.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit8.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit8.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit8.Properties.DisplayFormat.FormatString = "#,0.####"
        Me.TextEdit8.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit8.Properties.EditFormat.FormatString = "#,0.####"
        Me.TextEdit8.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit8.Properties.MaxLength = 60
        Me.TextEdit8.Properties.NullText = "0.00"
        Me.TextEdit8.Properties.ReadOnly = True
        Me.TextEdit8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit8.Size = New System.Drawing.Size(176, 26)
        Me.TextEdit8.TabIndex = 82
        Me.TextEdit8.Visible = False
        '
        'ds_tbStokTutari
        '
        Me.ds_tbStokTutari.DataSetName = "NewDataSet"
        Me.ds_tbStokTutari.Locale = New System.Globalization.CultureInfo("tr-TR")
        Me.ds_tbStokTutari.Tables.AddRange(New System.Data.DataTable() {Me.DataTable8})
        '
        'DataTable8
        '
        Me.DataTable8.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn65, Me.DataColumn66, Me.DataColumn67, Me.DataColumn68, Me.DataColumn69})
        Me.DataTable8.TableName = "Table1"
        '
        'DataColumn65
        '
        Me.DataColumn65.ColumnName = "nGiris"
        Me.DataColumn65.DataType = GetType(Decimal)
        '
        'DataColumn66
        '
        Me.DataColumn66.ColumnName = "nGirisIade"
        Me.DataColumn66.DataType = GetType(Decimal)
        '
        'DataColumn67
        '
        Me.DataColumn67.ColumnName = "nCikis"
        Me.DataColumn67.DataType = GetType(Decimal)
        '
        'DataColumn68
        '
        Me.DataColumn68.ColumnName = "nCikisIade"
        Me.DataColumn68.DataType = GetType(Decimal)
        '
        'DataColumn69
        '
        Me.DataColumn69.ColumnName = "nKalan"
        Me.DataColumn69.DataType = GetType(Decimal)
        '
        'TextEdit9
        '
        Me.TextEdit9.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStokTutari, "Table1.nCikisIade", True))
        Me.TextEdit9.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TextEdit9.Enabled = False
        Me.TextEdit9.EnterMoveNextControl = True
        Me.TextEdit9.Location = New System.Drawing.Point(675, 63)
        Me.TextEdit9.Name = "TextEdit9"
        Me.TextEdit9.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.TextEdit9.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit9.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit9.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit9.Properties.Appearance.Options.UseFont = True
        Me.TextEdit9.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit9.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit9.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit9.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit9.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit9.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit9.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit9.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit9.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit9.Properties.DisplayFormat.FormatString = "#,0.####"
        Me.TextEdit9.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit9.Properties.EditFormat.FormatString = "#,0.####"
        Me.TextEdit9.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit9.Properties.MaxLength = 60
        Me.TextEdit9.Properties.NullText = "0.00"
        Me.TextEdit9.Properties.ReadOnly = True
        Me.TextEdit9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit9.Size = New System.Drawing.Size(171, 26)
        Me.TextEdit9.TabIndex = 81
        Me.TextEdit9.Visible = False
        '
        'TextEdit10
        '
        Me.TextEdit10.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStokTutari, "Table1.nCikis", True))
        Me.TextEdit10.EditValue = "0"
        Me.TextEdit10.Enabled = False
        Me.TextEdit10.EnterMoveNextControl = True
        Me.TextEdit10.Location = New System.Drawing.Point(501, 63)
        Me.TextEdit10.Name = "TextEdit10"
        Me.TextEdit10.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.TextEdit10.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit10.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit10.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit10.Properties.Appearance.Options.UseFont = True
        Me.TextEdit10.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit10.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit10.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit10.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit10.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit10.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit10.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit10.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit10.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit10.Properties.DisplayFormat.FormatString = "#,0.####"
        Me.TextEdit10.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit10.Properties.EditFormat.FormatString = "#,0.####"
        Me.TextEdit10.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit10.Properties.MaxLength = 60
        Me.TextEdit10.Properties.NullText = "0.00"
        Me.TextEdit10.Properties.ReadOnly = True
        Me.TextEdit10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit10.Size = New System.Drawing.Size(171, 26)
        Me.TextEdit10.TabIndex = 80
        Me.TextEdit10.Visible = False
        '
        'TextEdit11
        '
        Me.TextEdit11.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStokTutari, "Table1.nGirisIade", True))
        Me.TextEdit11.EditValue = "0"
        Me.TextEdit11.Enabled = False
        Me.TextEdit11.EnterMoveNextControl = True
        Me.TextEdit11.Location = New System.Drawing.Point(326, 63)
        Me.TextEdit11.Name = "TextEdit11"
        Me.TextEdit11.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.TextEdit11.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit11.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit11.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit11.Properties.Appearance.Options.UseFont = True
        Me.TextEdit11.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit11.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit11.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit11.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit11.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit11.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit11.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit11.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit11.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit11.Properties.DisplayFormat.FormatString = "#,0.####"
        Me.TextEdit11.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit11.Properties.EditFormat.FormatString = "#,0.####"
        Me.TextEdit11.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit11.Properties.MaxLength = 60
        Me.TextEdit11.Properties.NullText = "0.00"
        Me.TextEdit11.Properties.ReadOnly = True
        Me.TextEdit11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit11.Size = New System.Drawing.Size(172, 26)
        Me.TextEdit11.TabIndex = 79
        Me.TextEdit11.Visible = False
        '
        'TextEdit12
        '
        Me.TextEdit12.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ds_tbStokTutari, "Table1.nGiris", True))
        Me.TextEdit12.EditValue = "0"
        Me.TextEdit12.Enabled = False
        Me.TextEdit12.EnterMoveNextControl = True
        Me.TextEdit12.Location = New System.Drawing.Point(146, 63)
        Me.TextEdit12.Name = "TextEdit12"
        Me.TextEdit12.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.TextEdit12.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextEdit12.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit12.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit12.Properties.Appearance.Options.UseFont = True
        Me.TextEdit12.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit12.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit12.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TextEdit12.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit12.Properties.AppearanceFocused.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextEdit12.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Black
        Me.TextEdit12.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.TextEdit12.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.TextEdit12.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit12.Properties.DisplayFormat.FormatString = "#,0.####"
        Me.TextEdit12.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit12.Properties.EditFormat.FormatString = "#,0.####"
        Me.TextEdit12.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit12.Properties.MaxLength = 60
        Me.TextEdit12.Properties.NullText = "0.00"
        Me.TextEdit12.Properties.ReadOnly = True
        Me.TextEdit12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextEdit12.Size = New System.Drawing.Size(177, 26)
        Me.TextEdit12.TabIndex = 78
        Me.TextEdit12.Visible = False
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl23.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl23.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl23.Location = New System.Drawing.Point(86, 69)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(44, 19)
        Me.LabelControl23.TabIndex = 77
        Me.LabelControl23.Text = "Tutar:"
        Me.LabelControl23.Visible = False
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton5.Appearance.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton5.Appearance.Options.UseFont = True
        Me.SimpleButton5.Appearance.Options.UseForeColor = True
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(1307, 20)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(35, 31)
        ToolTipTitleItem46.Text = "Sonraki Kart"
        ToolTipItem33.LeftIndent = 6
        ToolTipItem33.Text = "Sonraki Stok Kartn Ekrana Getirir"
        ToolTipTitleItem76.LeftIndent = 6
        ToolTipTitleItem76.Text = "Ctrl+Right"
        SuperToolTip35.Items.Add(ToolTipTitleItem46)
        SuperToolTip35.Items.Add(ToolTipItem33)
        SuperToolTip35.Items.Add(ToolTipSeparatorItem25)
        SuperToolTip35.Items.Add(ToolTipTitleItem76)
        Me.SimpleButton5.SuperTip = SuperToolTip35
        Me.SimpleButton5.TabIndex = 76
        Me.SimpleButton5.Text = ">>"
        '
        'SimpleButton6
        '
        Me.SimpleButton6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton6.Appearance.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SimpleButton6.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton6.Appearance.Options.UseFont = True
        Me.SimpleButton6.Appearance.Options.UseForeColor = True
        Me.SimpleButton6.Image = CType(resources.GetObject("SimpleButton6.Image"), System.Drawing.Image)
        Me.SimpleButton6.Location = New System.Drawing.Point(1267, 20)
        Me.SimpleButton6.Name = "SimpleButton6"
        Me.SimpleButton6.Size = New System.Drawing.Size(40, 31)
        ToolTipTitleItem77.Text = "Onceki Kart"
        ToolTipItem50.LeftIndent = 6
        ToolTipItem50.Text = "Onceki Stok Kartn Ekrana Getirir"
        ToolTipTitleItem78.LeftIndent = 6
        ToolTipTitleItem78.Text = "Ctrl+Left"
        SuperToolTip52.Items.Add(ToolTipTitleItem77)
        SuperToolTip52.Items.Add(ToolTipItem50)
        SuperToolTip52.Items.Add(ToolTipSeparatorItem26)
        SuperToolTip52.Items.Add(ToolTipTitleItem78)
        Me.SimpleButton6.SuperTip = SuperToolTip52
        Me.SimpleButton6.TabIndex = 75
        '
        'ps
        '
        Me.ps.Links.AddRange(New Object() {Me.printlink1, Me.printlink2})
        '
        'printlink1
        '
        Me.printlink1.Component = Me.GridControl2
        '
        '
        '
        Me.printlink1.ImageCollection.ImageStream = CType(resources.GetObject("printlink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink1.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink1.Owner = Nothing
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Aylk Yeknler", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Stok Ynetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink1.PrintingSystem = Me.ps
        Me.printlink1.PrintingSystemBase = Me.ps
        '
        'printlink2
        '
        Me.printlink2.Component = Me.GridControl3
        '
        '
        '
        Me.printlink2.ImageCollection.ImageStream = CType(resources.GetObject("printlink2.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink2.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink2.Owner = Nothing
        Me.printlink2.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Renk/Beden/Kavala", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Stok Ynetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink2.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink2.PrintingSystem = Me.ps
        Me.printlink2.PrintingSystemBase = Me.ps
        '
        'kisayol_ana
        '
        Me.kisayol_ana.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem18, Me.MenuItem14, Me.MenuItem15, Me.MenuItem16, Me.MenuItem28, Me.MenuItem29, Me.MenuItem17, Me.MenuItem10, Me.MenuItem11, Me.MenuItem12, Me.MenuItem4, Me.MenuItem5, Me.MenuItem7, Me.MenuItem13, Me.MenuItem8, Me.MenuItem9, Me.MenuItem19, Me.MenuItem20, Me.MenuItem27, Me.MenuItem30, Me.MenuItem31, Me.MenuItem32})
        '
        'MenuItem18
        '
        Me.MenuItem18.DefaultItem = True
        Me.MenuItem18.Index = 0
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem18.Text = "Stok Se"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 1
        Me.MenuItem14.Shortcut = System.Windows.Forms.Shortcut.Ins
        Me.MenuItem14.Text = "Ekle"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 2
        Me.MenuItem15.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem15.Text = "Dzelt"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 3
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.CtrlDel
        Me.MenuItem16.Text = "Sil"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 4
        Me.MenuItem28.Text = "Kopyala"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 5
        Me.MenuItem29.Shortcut = System.Windows.Forms.Shortcut.CtrlB
        Me.MenuItem29.Text = "Birim Cevrimi"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 6
        Me.MenuItem17.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 7
        Me.MenuItem10.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.MenuItem10.Text = "Tamam"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 8
        Me.MenuItem11.Text = "Vazge"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 9
        Me.MenuItem12.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 10
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem4.Text = "Envanter"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 11
        Me.MenuItem5.Shortcut = System.Windows.Forms.Shortcut.CtrlF6
        Me.MenuItem5.Text = "Model Envanter"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 12
        Me.MenuItem7.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem7.Text = "Stok Hareketleri"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 13
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.CtrlF7
        Me.MenuItem13.Text = "Transfer Hareketleri"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 14
        Me.MenuItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItem8.Text = "Stok Fiyatlandr"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 15
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem9.Text = "Stok Bekleyenleri"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 16
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F9
        Me.MenuItem19.Text = "Aklama Gir"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 17
        Me.MenuItem20.Text = "Renk Ekle"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 18
        Me.MenuItem27.Text = "Snf Tanmlar"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 19
        Me.MenuItem30.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItem30.Text = "Karllk Ak Tablosu"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 20
        Me.MenuItem31.Shortcut = System.Windows.Forms.Shortcut.CtrlL
        Me.MenuItem31.Text = "Alternatifi"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 21
        Me.MenuItem32.Shortcut = System.Windows.Forms.Shortcut.CtrlE
        Me.MenuItem32.Text = "Etiket Yazdr"
        '
        'printlink3
        '
        Me.printlink3.Component = Me.GridControl4
        '
        '
        '
        Me.printlink3.ImageCollection.ImageStream = CType(resources.GetObject("printlink3.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.printlink3.Margins = New System.Drawing.Printing.Margins(20, 20, 60, 60)
        Me.printlink3.Owner = Nothing
        Me.printlink3.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Stok Barkodlar", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Stok Ynetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Me.printlink3.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.printlink3.PrintingSystem = Me.ps
        Me.printlink3.PrintingSystemBase = Me.ps
        '
        'frm_stok_kart
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 20)
        Me.ClientSize = New System.Drawing.Size(1367, 764)
        Me.ContextMenu = Me.kisayol_ana
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.Panel_Alt)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_kart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Kart"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel_Alt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Alt.ResumeLayout(False)
        Me.Panel_Alt.PerformLayout()
        CType(Me.ds_tbStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_musteriNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sec_bTersOran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nOIV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_OIVVar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bWebTavsiye.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nWebIskontoYuzdesi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bWebGoruntule.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAlisKdvTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tbBedenTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nHacim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sDovizCinsi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nAgirlik.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nYukseklik.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nBoy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nEn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        Me.GroupControl6.PerformLayout()
        CType(Me.txt_sYeniKod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nPrim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lBirimCarpan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tbStokTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nFiyatlandirma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nIskontoYuzdesi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nIskontoYuzdesiAV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nTeminSuresi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lAzamiMiktar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lAsgariMiktar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bEksiyeDusunceUyar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bEksiyeDusulebilir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sOTVtipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_OTVvar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sKdvTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAsortiTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sBirimCinsi2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sBirimCinsi1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sKisaAdi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sAdi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbStokSinifi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_Siniflar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sSinifKodu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbStokAyYekunleri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbStokAcilim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.XtraTabPage6.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.Group_BarkodGir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_BarkodGir.ResumeLayout(False)
        Me.Group_BarkodGir.PerformLayout()
        CType(Me.txt_lBarkodMiktar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sBarkodBirimCinsi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sBarkodTipi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sBarkod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.kisayol_barkod.ResumeLayout(False)
        CType(Me.ds_tbStokBarkodu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sBarkod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_nKisim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sBirimCinsi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.XtraTabPage5.ResumeLayout(False)
        CType(Me.txt_sUzunNot.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbStokUzunNot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage8.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.GridControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbStokResim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_pResim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.XtraTabPage7.ResumeLayout(False)
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        CType(Me.DateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage9.ResumeLayout(False)
        CType(Me.GridControl7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        Me.XtraTabPage10.ResumeLayout(False)
        CType(Me.GridControl8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_sHesapPlani, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbStokBakiyesi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbStokTutari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink2.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.printlink3.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
    Public firmano
    Public donemno
    Public connection
    Public nStokID
    Public sKodu As String
    Public sModel As String
    Public kullanici As String = ""
    Public bStokKarti As Boolean = False
    Public bAlternatif As Boolean = False
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_stok As DataSet
    Dim ds_nStokID As DataSet
    Dim ds_tbBirimCinsi As DataSet
    Dim ds_tbAsorti As DataSet
    Dim DS_tbKdv As DataSet
    Dim ds_tbOTV As DataSet
    Dim ds_tbFiyatlandirma As DataSet
    Dim ds_tbRenk As DataSet
    Dim ds_tbBeden As DataSet
    Dim ds_tbKavala As DataSet
    Dim ds_tbStokTipi As DataSet
    Dim ds_tbBedenTipi As DataSet
    Dim ds_tbStokHareket As New DataSet
    Dim ds_tbStokAlternatif As New DataSet
    Dim ds_tbStokMuhasebeEntegrasyon As DataSet
    Dim ds_tbDovizCinsi As DataSet
    Dim sSinifKodu1 As String = ""
    Dim sSinifKodu2 As String = ""
    Dim sSinifKodu3 As String = ""
    Dim sSinifKodu4 As String = ""
    Dim sSinifKodu5 As String = ""
    Dim sSinifKodu6 As String = ""
    Dim sSinifKodu7 As String = ""
    Dim sSinifKodu8 As String = ""
    Dim sSinifKodu9 As String = ""
    Dim sSinifKodu10 As String = ""
    Dim sSinifKodu11 As String = ""
    Dim sSinifKodu12 As String = ""
    Dim sSinifKodu13 As String = ""
    Dim sSinifKodu14 As String = ""
    Dim sSinifKodu15 As String = ""
    Private Sub frm_stok_kart_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim bDevam As Boolean = True
        Dim sUyari As String = ""
        sUyari = sUyariKontrol()
        If sUyari = "" Then
        Else
            XtraMessageBox.Show(sUyari, Sorgu_sDil("Dikkat", sDil))
            bDevam = False
        End If
        If bDevam = False Then
            e.Cancel = True
        Else
            Dispose()
        End If
    End Sub
    Private Function sUyariKontrol() As String
        Dim sUyari As String = ""
        Dim dr As DataRow
        For Each dr In ds_tbStokSinifi.Tables(0).Rows
            If dr("sSinifNo") = 1 Then
                sSinifKodu1 = Trim(dr("sSinifKodu"))
            ElseIf dr("sSinifNo") = 2 Then
                sSinifKodu2 = Trim(dr("sSinifKodu"))
            ElseIf dr("sSinifNo") = 3 Then
                sSinifKodu3 = Trim(dr("sSinifKodu"))
            ElseIf dr("sSinifNo") = 4 Then
                sSinifKodu4 = Trim(dr("sSinifKodu"))
            ElseIf dr("sSinifNo") = 5 Then
                sSinifKodu5 = Trim(dr("sSinifKodu"))
            ElseIf dr("sSinifNo") = 6 Then
                sSinifKodu6 = Trim(dr("sSinifKodu"))
            ElseIf dr("sSinifNo") = 7 Then
                sSinifKodu7 = Trim(dr("sSinifKodu"))
            ElseIf dr("sSinifNo") = 8 Then
                sSinifKodu8 = Trim(dr("sSinifKodu"))
            ElseIf dr("sSinifNo") = 9 Then
                sSinifKodu9 = Trim(dr("sSinifKodu"))
            ElseIf dr("sSinifNo") = 10 Then
                sSinifKodu10 = Trim(dr("sSinifKodu"))
            ElseIf dr("sSinifNo") = 11 Then
                sSinifKodu11 = Trim(dr("sSinifKodu"))
            ElseIf dr("sSinifNo") = 12 Then
                sSinifKodu12 = Trim(dr("sSinifKodu"))
            ElseIf dr("sSinifNo") = 13 Then
                sSinifKodu13 = Trim(dr("sSinifKodu"))
            ElseIf dr("sSinifNo") = 14 Then
                sSinifKodu14 = Trim(dr("sSinifKodu"))
            ElseIf dr("sSinifNo") = 15 Then
                sSinifKodu15 = Trim(dr("sSinifKodu"))
            End If
        Next
        Dim nBarkodSayisi As Int64 = 0
        For Each dr In ds_tbStokBarkodu.Tables(0).Rows
            If sorgu_sayi(dr("nKisim"), 0) = 0 And dr("sBarkod").ToString <> "" Then
                nBarkodSayisi += 1
            End If
        Next
        If nBarkodSayisi = 0 And txt_musteriNo.Text <> "" Then
            sUyari += Sorgu_sDil("Master Barkodu Bo Brakamazsnz...!", sDil)
        End If
        If Trim(txt_sAdi.Text) = "" And bStokAciklamaZorunlumu = True Then
            sUyari += Sorgu_sDil("Aklama Alann Bo Brakamazsnz...!", sDil)
        End If
        If Trim(txt_sKisaAdi.Text) = "" And bKisaAdiZorunlumu = True Then
            sUyari += Sorgu_sDil("KsaAd Alann Bo Brakamazsnz...!", sDil)
        End If
        If Trim(txt_sBirimCinsi1.Text) = "" And bBirimCinsi1Zorunlumu = True Then
            sUyari += Sorgu_sDil("Ana Birim Alann Bo Brakamazsnz...!", sDil)
        End If
        If Trim(txt_sBirimCinsi2.Text) = "" And bBirimCinsi2Zorunlumu = True Then
            sUyari += Sorgu_sDil("2.Birim Alann Bo Brakamazsnz...!", sDil)
        End If
        If txt_nIskontoYuzdesi.Value = 0 And bIskontoYuzdesiZorunlumu = True Then
            sUyari += Sorgu_sDil("Toptan skonto Alann Bo Brakamazsnz...!", sDil)
        End If
        If txt_nIskontoYuzdesiAV.Value = 0 And bIskontoYuzdesiAVZorunlumu = True Then
            sUyari += Sorgu_sDil("Perakende skonto Alann Bo Brakamazsnz...!", sDil)
        End If
        'If Trim(txt_sKdvTipi.EditValue) = "" And bKdvTipiZorunlumu = True Then
        If Trim(txt_sKdvTipi.EditValue.ToString()) = "" And bKdvTipiZorunlumu = True Then
            sUyari += Sorgu_sDil("Kdv Tipi Alann Bo Brakamazsnz...!", sDil)
        End If
        If txt_nTeminSuresi.Value = 0 And bTeminSuresiZorunlumu = True Then
            sUyari += Sorgu_sDil("Temin Sresi Alann Bo Brakamazsnz...!", sDil)
        End If
        If txt_lAsgariMiktar.Value = 0 And bAsgariMiktarZorunlumu = True Then
            sUyari += Sorgu_sDil("Asgari Miktar Alann Bo Brakamazsnz...!", sDil)
        End If
        If txt_lAzamiMiktar.Value = 0 And bAzamiMiktarZorunlumu = True Then
            sUyari += Sorgu_sDil("Azami Miktar Alann Bo Brakamazsnz...!", sDil)
        End If
        If Trim(txt_sUzunNot.Text) = "" And bOzelNotZorunlumu = True Then
            sUyari += Sorgu_sDil("zel Not Alann Bo Brakamazsnz...!", sDil)
        End If
        If txt_nPrim.Value = 0 And bPrimZorunlumu = True Then
            sUyari += Sorgu_sDil("Prim Alann Bo Brakamazsnz...!", sDil)
        End If
        If txt_nAgirlik.Value = 0 And bAgirlikZorunlumu = True Then
            sUyari += Sorgu_sDil("Arlk Alann Bo Brakamazsnz...!", sDil)
        End If
        If txt_nHacim.Value = 0 And bHacimZorunlumu = True Then
            sUyari += Sorgu_sDil("Hacim Alann Bo Brakamazsnz...!", sDil)
        End If
        If sSinifKodu1 = "" And bSinifKodu1Zorunlumu = True Then
            sUyari += Sorgu_sDil("Snf1 Alann Bo Brakamazsnz...!", sDil)
        End If
        If sSinifKodu2 = "" And bSinifKodu2Zorunlumu = True Then
            sUyari += Sorgu_sDil("Snf2 Alann Bo Brakamazsnz...!", sDil)
        End If
        If sSinifKodu3 = "" And bSinifKodu3Zorunlumu = True Then
            sUyari += Sorgu_sDil("Snf3 Alann Bo Brakamazsnz...!", sDil)
        End If
        If sSinifKodu4 = "" And bSinifKodu4Zorunlumu = True Then
            sUyari += Sorgu_sDil("Snf4 Alann Bo Brakamazsnz...!", sDil)
        End If
        If sSinifKodu5 = "" And bSinifKodu5Zorunlumu = True Then
            sUyari += Sorgu_sDil("Snf5 Alann Bo Brakamazsnz...!", sDil)
        End If
        If sSinifKodu6 = "" And bSinifKodu6Zorunlumu = True Then
            sUyari += Sorgu_sDil("Snf6 Alann Bo Brakamazsnz...!", sDil)
        End If
        If sSinifKodu7 = "" And bSinifKodu7Zorunlumu = True Then
            sUyari += Sorgu_sDil("Snf7 Alann Bo Brakamazsnz...!", sDil)
        End If
        If sSinifKodu8 = "" And bSinifKodu8Zorunlumu = True Then
            sUyari += Sorgu_sDil("Snf8 Alann Bo Brakamazsnz...!", sDil)
        End If
        If sSinifKodu9 = "" And bSinifKodu9Zorunlumu = True Then
            sUyari += Sorgu_sDil("Snf9 Alann Bo Brakamazsnz...!", sDil)
        End If
        If sSinifKodu10 = "" And bSinifKodu10Zorunlumu = True Then
            sUyari += Sorgu_sDil("Snf10 Alann Bo Brakamazsnz...!", sDil)
        End If
        If sSinifKodu10 = "" And bSinifKodu10Zorunlumu = True Then
            sUyari += Sorgu_sDil("Snf10 Alann Bo Brakamazsnz...!", sDil)
        End If
        If sSinifKodu11 = "" And bSinifKodu11Zorunlumu = True Then
            sUyari += Sorgu_sDil("Snf11 Alann Bo Brakamazsnz...!", sDil)
        End If
        If sSinifKodu12 = "" And bSinifKodu12Zorunlumu = True Then
            sUyari += Sorgu_sDil("Snf12 Alann Bo Brakamazsnz...!", sDil)
        End If
        If sSinifKodu13 = "" And bSinifKodu13Zorunlumu = True Then
            sUyari += Sorgu_sDil("Snf13 Alann Bo Brakamazsnz...!", sDil)
        End If
        If sSinifKodu14 = "" And bSinifKodu14Zorunlumu = True Then
            sUyari += Sorgu_sDil("Snf14 Alann Bo Brakamazsnz...!", sDil)
        End If
        If sSinifKodu15 = "" And bSinifKodu15Zorunlumu = True Then
            sUyari += Sorgu_sDil("Snf15 Alann Bo Brakamazsnz...!", sDil)
        End If
        Return sUyari
    End Function
    Private Sub frm_stok_kart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        
        If sModel = "" Then
            'stok_sec()
            Panel_Alt.Focus()
            txt_musteriNo.Focus()
            txt_musteriNo.Select()
        Else
            txt_musteriNo.EditValue = Trim(sModel)
            dataload(sModel)
            txt_sAdi.Focus()
            txt_sAdi.SelectAll()
            XtraTabControl1.Focus()
            XtraTabControl1.Select()
            XtraTabControl1.SelectedTabPageIndex = 0
            XtraTabPage9.PageVisible = True
        End If
        dataload_tbBirimCinsi()
        dataload_tbAsorti()
        dataload_tbKdv()
        dataload_tbOTV()
        dataload_tbFiyatlandirma()
        dataload_tbSSinif(1)
        dataload_tbStokTipi()
        dataload_tbBedenTipi()
        dataload_tbDovizCinsi()
        'If bEksiyeDusulebilirmi = True Then
        '    sec_bEksiyeDusulebilir.Checked = True
        'Else
        '    sec_bEksiyeDusulebilir.Checked = False
        'End If
        'If bStokKarti = True Then
        '    XtraTabControl1.SelectedTabPageIndex = 7
        '    GridControl5.Focus()
        '    GridControl5.Select()
        '    If GridView4.RowCount > 0 Then
        '        GridView4.ClearSelection()
        '        GridView4.FocusedRowHandle = GridView4.RowCount - 1
        '        GridView4.SelectRow(GridView4.FocusedRowHandle)
        '        GridControl5.Focus()
        '    End If
        'End If
    End Sub
    Private Sub gorunum_yukle()
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView2.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView3.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView4.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim tab As Object
        For Each tab In XtraTabControl1.TabPages
            tab.text = Sorgu_sDil(tab.text, sDil)
        Next
        LabelControl1.Text = Sorgu_sDil(LabelControl1.Text, sDil)
        LabelControl2.Text = Sorgu_sDil(LabelControl2.Text, sDil)
        LabelControl3.Text = Sorgu_sDil(LabelControl3.Text, sDil)
        LabelControl4.Text = Sorgu_sDil(LabelControl4.Text, sDil)
        LabelControl5.Text = Sorgu_sDil(LabelControl5.Text, sDil)
        LabelControl6.Text = Sorgu_sDil(LabelControl6.Text, sDil)
        LabelControl7.Text = Sorgu_sDil(LabelControl7.Text, sDil)
        LabelControl8.Text = Sorgu_sDil(LabelControl8.Text, sDil)
        LabelControl9.Text = Sorgu_sDil(LabelControl9.Text, sDil)
        LabelControl10.Text = Sorgu_sDil(LabelControl10.Text, sDil)
        LabelControl11.Text = Sorgu_sDil(LabelControl11.Text, sDil)
        LabelControl12.Text = Sorgu_sDil(LabelControl12.Text, sDil)
        LabelControl13.Text = Sorgu_sDil(LabelControl13.Text, sDil)
        LabelControl14.Text = Sorgu_sDil(LabelControl14.Text, sDil)
        LabelControl15.Text = Sorgu_sDil(LabelControl15.Text, sDil)
        LabelControl16.Text = Sorgu_sDil(LabelControl16.Text, sDil)
        lbl_sMiktar.Text = Sorgu_sDil(lbl_sMiktar.Text, sDil)
        LabelControl18.Text = Sorgu_sDil(LabelControl18.Text, sDil)
        LabelControl19.Text = Sorgu_sDil(LabelControl19.Text, sDil)
        LabelControl20.Text = Sorgu_sDil(LabelControl20.Text, sDil)
        LabelControl21.Text = Sorgu_sDil(LabelControl21.Text, sDil)
        LabelControl22.Text = Sorgu_sDil(LabelControl22.Text, sDil)
        LabelControl23.Text = Sorgu_sDil(LabelControl23.Text, sDil)
        LabelControl24.Text = Sorgu_sDil(LabelControl24.Text, sDil)
        LabelControl25.Text = Sorgu_sDil(LabelControl25.Text, sDil)
        LabelControl26.Text = Sorgu_sDil(LabelControl26.Text, sDil)
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
    End Sub
    Private Sub dataload_tbBirimCinsi()
        ds_tbBirimCinsi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbBirimCinsi"))
        txt_sBirimCinsi1.Properties.DataSource = ds_tbBirimCinsi.Tables(0)
        txt_sBirimCinsi2.Properties.DataSource = ds_tbBirimCinsi.Tables(0)
        sec_sBarkodBirimCinsi.Properties.DataSource = ds_tbBirimCinsi.Tables(0)
        sec_sBirimCinsi.DataSource = ds_tbBirimCinsi.Tables(0)
    End Sub
    Private Sub dataload_tbAsorti()
        ds_tbAsorti = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sAsortiTipi FROM tbAsorti"))
        txt_sAsortiTipi.Properties.DataSource = ds_tbAsorti.Tables(0)
    End Sub
    Private Sub dataload_tbKdv()
        DS_tbKdv = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbKdv"))
        txt_sKdvTipi.Properties.DataSource = DS_tbKdv.Tables(0)
        txt_sAlisKdvTipi.Properties.DataSource = DS_tbKdv.Tables(0)
    End Sub
    Private Sub dataload_tbStokTipi()
        ds_tbStokTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbStokTipi"))
        txt_tbStokTipi.Properties.DataSource = ds_tbStokTipi.Tables(0)
    End Sub
    Private Sub dataload_tbBedenTipi()
        ds_tbBedenTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sBedenTipi, sAciklama FROM tbBedenTipi"))
        txt_tbBedenTipi.Properties.DataSource = ds_tbBedenTipi.Tables(0)
    End Sub
    Private Sub dataload_tbOTV()
        ds_tbOTV = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbOTV"))
        txt_sOTVtipi.Properties.DataSource = ds_tbOTV.Tables(0)
    End Sub
    Private Sub dataload_tbDovizCinsi()
        ds_tbDovizCinsi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sDovizCinsi, sAciklama FROM tbDovizCinsi ORDER BY sDovizCinsi"))
        txt_sDovizCinsi.Properties.DataSource = ds_tbDovizCinsi.Tables(0)
    End Sub
    Private Sub dataload_tbRenk(ByVal sModel As String)
        ds_tbRenk = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT sRenk FROM tbStok WHERE (sModel = N'" & sModel & "')"))
    End Sub
    Private Sub dataload_tbBeden(ByVal sModel As String)
        ds_tbBeden = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT sBeden FROM tbStok WHERE (sModel = N'" & sModel & "')"))
    End Sub
    Private Sub dataload_tbKavala(ByVal sModel As String)
        ds_tbKavala = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT sKavala FROM tbStok WHERE (sModel = N'" & sModel & "')"))
    End Sub
    Private Sub dataload_tbFiyatlandirma()
        ds_tbFiyatlandirma = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbFiyatlandirma"))
        txt_nFiyatlandirma.Properties.DataSource = ds_tbFiyatlandirma.Tables(0)
    End Sub
    Private Sub dataload_tbSSinif(Optional ByVal sSinifNo As Integer = 1)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("Select nParametre1 From tbParamStok ")
        Dim eticaret = cmd.ExecuteScalar()
        con.Close()
        If eticaret = 1 Then
            If sSinifNo = 7 Then
                sec_sSinifKodu.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu,sSinifKodu as sSinifKodu7,sSinifKodu2,sSinifKodu3,sSinifKodu4,sSinifKodu5,sSinifKodu6,sSinifKodu, sAciklama FROM tbSSinif" & sSinifNo & "")).Tables(0)
                sec_Siniflar.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu,sSinifKodu as sSinifKodu7,sSinifKodu2,sSinifKodu3,sSinifKodu4,sSinifKodu5,sSinifKodu6,sSinifKodu, sAciklama FROM tbSSinif" & sSinifNo & "")).Tables(0)
            ElseIf sSinifNo = 6 Then
                sec_sSinifKodu.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu,sSinifKodu as sSinifKodu6,sSinifKodu2,sSinifKodu3,sSinifKodu4,sSinifKodu5,sSinifKodu7,sSinifKodu, sAciklama FROM tbSSinif" & sSinifNo & "")).Tables(0)
                sec_Siniflar.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu,sSinifKodu as sSinifKodu6,sSinifKodu2,sSinifKodu3,sSinifKodu4,sSinifKodu5,sSinifKodu7,sSinifKodu, sAciklama FROM tbSSinif" & sSinifNo & "")).Tables(0)
            ElseIf sSinifNo = 5 Then
                sec_sSinifKodu.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu,sSinifKodu as sSinifKodu5,sSinifKodu2,sSinifKodu3,sSinifKodu4,sSinifKodu6,sSinifKodu7,sSinifKodu, sAciklama FROM tbSSinif" & sSinifNo & "")).Tables(0)
                sec_Siniflar.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu,sSinifKodu as sSinifKodu5,sSinifKodu2,sSinifKodu3,sSinifKodu4,sSinifKodu6,sSinifKodu7,sSinifKodu, sAciklama FROM tbSSinif" & sSinifNo & "")).Tables(0)
            ElseIf sSinifNo = 4 Then
                sec_sSinifKodu.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu,sSinifKodu as sSinifKodu4,sSinifKodu2,sSinifKodu3,sSinifKodu5,sSinifKodu6,sSinifKodu7,sSinifKodu, sAciklama FROM tbSSinif" & sSinifNo & "")).Tables(0)
                sec_Siniflar.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu,sSinifKodu as sSinifKodu4,sSinifKodu2,sSinifKodu3,sSinifKodu5,sSinifKodu6,sSinifKodu7,sSinifKodu, sAciklama FROM tbSSinif" & sSinifNo & "")).Tables(0)
            ElseIf sSinifNo = 3 Then
                sec_sSinifKodu.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu,sSinifKodu as sSinifKodu3,sSinifKodu2,sSinifKodu4,sSinifKodu5,sSinifKodu6,sSinifKodu7,sSinifKodu, sAciklama FROM tbSSinif" & sSinifNo & "")).Tables(0)
                sec_Siniflar.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu,sSinifKodu as sSinifKodu3,sSinifKodu2,sSinifKodu4,sSinifKodu5,sSinifKodu6,sSinifKodu7,sSinifKodu, sAciklama FROM tbSSinif" & sSinifNo & "")).Tables(0)
            ElseIf sSinifNo = 2 Then
                sec_sSinifKodu.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu,sSinifKodu as sSinifKodu2,sSinifKodu3,sSinifKodu4,,sSinifKodu5,sSinifKodu6,sSinifKodu7,sSinifKodu, sAciklama FROM tbSSinif" & sSinifNo & "")).Tables(0)
                sec_Siniflar.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu,sSinifKodu as sSinifKodu2,sSinifKodu3,sSinifKodu4,,sSinifKodu5,sSinifKodu6,sSinifKodu7,sSinifKodu, sAciklama FROM tbSSinif" & sSinifNo & "")).Tables(0)
            End If
        Else
            sec_sSinifKodu.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu, sAciklama FROM tbSSinif" & sSinifNo & "")).Tables(0)
            sec_Siniflar.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifKodu, sAciklama FROM tbSSinif" & sSinifNo & "")).Tables(0)
        End If
    End Sub
    Private Sub dataload_tbHesapPlani()
        sec_sHesapPlani.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nHesapID, sKodu, sAciklama FROM tbHesapPlani Order by sKodu")).Tables(0)
    End Sub
    Private Sub dataload_tbIletisimAraci()
        'sec_IletisimAraci.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbIletisimAraci")).Tables(0)
    End Sub
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Balar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "erir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
        ElseIf kriter = "Bo" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farkl" Then
            sorgu_kriter = " <> '" & deger & "' "
        ElseIf kriter = "Byk" Then
            sorgu_kriter = " >  '" & deger & "' "
        ElseIf kriter = "Kk" Then
            sorgu_kriter = " < '" & deger & "' "
        ElseIf kriter = "Eittir" Then
            sorgu_kriter = " = N'" & deger & "' "
        End If
        Return sorgu_kriter
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Function sorgu(ByVal query As String, Optional ByVal sTable As String = "TABLE1") As DataSet
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
        Dim N As Integer = adapter.Fill(DS, sTable)
        con.Close()
        Return DS
    End Function
    Public Function Dataload_tbStokResim(ByVal sModel As String) As DataSet
        ' YENİ YAPI: Her resim zaten ayrı satır olarak geliyor (nSira bazlı)
        Dim ds As New DataSet()
        Dim dt As New DataTable("Table1")

        ' Kolonlar (tbStokResim)
        dt.Columns.Add("nStokResimID", GetType(Integer))  ' INT not GUID
        dt.Columns.Add("sModel", GetType(String))
        dt.Columns.Add("nSira", GetType(Integer))  ' YENİ: Resim sırası (1-11)
        dt.Columns.Add("pResim", GetType(String))  ' Base64 string
        dt.Columns.Add("sAciklama", GetType(String))
        dt.Columns.Add("dteKayitTarihi", GetType(DateTime))
        dt.Columns.Add("sKullaniciAdi", GetType(String))
        dt.Columns.Add("yol", GetType(String))  ' R2 URL
        dt.Columns.Add("ResimBytes", GetType(Byte()))  ' Base64'ten decode edilmiş
        dt.Columns.Add("ResimIndex", GetType(Integer))  ' nSira - 1 (0-based)
        
        ' YENİ Kolonlar (JOIN'den gelen - tbStok + tbRenk)
        dt.Columns.Add("sKodu", GetType(String))  ' Ürün kodu (ör: TS-FP02100001M)
        dt.Columns.Add("sRenk", GetType(String))  ' Renk kodu (ör: 001)
        dt.Columns.Add("sRenkAdi", GetType(String))  ' Renk adı (ör: SIYAH)
        dt.Columns.Add("sBeden", GetType(String))  ' Beden (ör: M, L, XL)
        dt.Columns.Add("sKavala", GetType(String))  ' Kavala kodu

        ds.Tables.Add(dt)

        Using conn As New OleDb.OleDbConnection(connection)
            conn.Open()
            
            ' YENİ YAPI: nStokID ile JOIN yaparak renk/beden/kavala bilgilerini de al
            ' ÖNCELIK: SR tablosundaki sRenk, sBeden, sKavala kullan, yoksa S tablosundan çek
            Using cmd As New OleDb.OleDbCommand(
                "SELECT SR.nStokResimID, SR.sModel, SR.nStokID, SR.nSira, SR.pResim, SR.yol, SR.sAciklama, SR.dteKayitTarihi, SR.sKullaniciAdi, " &
                "S.sKodu, " &
                "ISNULL(SR.sRenk, S.sRenk) AS sRenk, " &
                "R.sRenkAdi, " &
                "ISNULL(SR.sBeden, S.sBeden) AS sBeden, " &
                "ISNULL(SR.sKavala, S.sKavala) AS sKavala " &
                "FROM tbStokResim SR " &
                "LEFT JOIN tbStok S ON SR.nStokID = S.nStokID " &
                "LEFT JOIN tbRenk R ON ISNULL(SR.sRenk, S.sRenk) = R.sRenk " &
                "WHERE SR.sModel = ? " &
                "ORDER BY SR.nSira", conn)
                
                cmd.Parameters.Add("p0", OleDb.OleDbType.VarChar, 50).Value = sModel

                Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ' Her satır zaten bir resim
                        Dim row As DataRow = dt.NewRow()
                        
                        ' SR.nStokResimID (INT) - index 0
                        row("nStokResimID") = If(reader.IsDBNull(0), 0, reader.GetInt32(0))
                        
                        ' SR.sModel - index 1
                        row("sModel") = If(reader.IsDBNull(1), "", reader.GetString(1))
                        
                        ' SR.nStokID - index 2 (YENİ EKLENEN)
                        ' (DataTable'da eklemek için kolonlar aşağıda tanımlanacak)
                        
                        ' SR.nSira (1-11) - index 3
                        Dim nSira As Integer = If(reader.IsDBNull(3), 1, reader.GetInt32(3))
                        row("nSira") = nSira
                        
                        ' SR.pResim (Base64 string) - index 4
                        Dim pResimBase64 As String = If(reader.IsDBNull(4), Nothing, reader.GetString(4))
                        row("pResim") = If(pResimBase64, DBNull.Value)
                        
                        ' Base64'ten byte array'e çevir
                        If Not String.IsNullOrEmpty(pResimBase64) Then
                            Try
                                ' Base64 decode
                                Dim cleanBase64 As String = pResimBase64.Trim().Replace(vbCr, "").Replace(vbLf, "")
                                If cleanBase64.StartsWith("data:image") Then
                                    Dim commaIndex As Integer = cleanBase64.IndexOf(","c)
                                    If commaIndex > 0 Then
                                        cleanBase64 = cleanBase64.Substring(commaIndex + 1)
                                    End If
                                End If
                                Dim imgBytes As Byte() = Convert.FromBase64String(cleanBase64)
                                row("ResimBytes") = imgBytes
                            Catch ex As Exception
                                row("ResimBytes") = DBNull.Value
                            End Try
                        Else
                            row("ResimBytes") = DBNull.Value
                        End If
                        
                        ' SR.yol (R2 URL) - index 5
                        row("yol") = If(reader.IsDBNull(5), DBNull.Value, reader.GetString(5))
                        
                        ' SR.sAciklama - index 6
                        row("sAciklama") = If(reader.IsDBNull(6), "", reader.GetString(6))
                        
                        ' SR.dteKayitTarihi - index 7
                        row("dteKayitTarihi") = If(reader.IsDBNull(7), DBNull.Value, reader.GetDateTime(7))
                        
                        ' SR.sKullaniciAdi - index 8
                        row("sKullaniciAdi") = If(reader.IsDBNull(8), "", reader.GetString(8))
                        
                        ' S.sKodu - index 9 (JOIN'den gelen)
                        row("sKodu") = If(reader.IsDBNull(9), "", reader.GetString(9))
                        
                        ' S.sRenk (kod) - index 10 (JOIN'den gelen)
                        row("sRenk") = If(reader.IsDBNull(10), "", reader.GetString(10))
                        
                        ' R.sRenkAdi - index 11 (JOIN'den gelen)
                        row("sRenkAdi") = If(reader.IsDBNull(11), "", reader.GetString(11))
                        
                        ' S.sBeden - index 12 (JOIN'den gelen)
                        row("sBeden") = If(reader.IsDBNull(12), "", reader.GetString(12))
                        
                        ' S.sKavala - index 13 (JOIN'den gelen)
                        row("sKavala") = If(reader.IsDBNull(13), "", reader.GetString(13))
                        
                        ' ResimIndex (0-based: nSira - 1)
                        row("ResimIndex") = nSira - 1
                        
                        dt.Rows.Add(row)
                    End While
                End Using
            End Using
        End Using

        Return ds
    End Function

    Private Async Function Goster_StokResimleri(ByVal sModel As String) As Task
        ' 1) veri
        ds_tbStokResim = Dataload_tbStokResim(sModel)
        Dim t As DataTable = ds_tbStokResim.Tables(0)
        GridControl6.DataSource = t

        ' 2) PictureEdit hazrl (ayn)
        Dim pic As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit = Nothing
        For Each it As DevExpress.XtraEditors.Repository.RepositoryItem In GridControl6.RepositoryItems
            pic = TryCast(it, DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit)
            If pic IsNot Nothing Then Exit For
        Next
        If pic Is Nothing Then
            pic = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            pic.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            pic.NullText = ""
            GridControl6.RepositoryItems.Add(pic)
        End If

        ' 3) Soldaki Resim stununu ResimBytesa bala (ayn)
        Dim targetCol As DevExpress.XtraGrid.Columns.GridColumn = Nothing
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView6.Columns
            If String.Compare(c.Caption, "Resim", True) = 0 Then
                targetCol = c : Exit For
            End If
        Next
        If targetCol IsNot Nothing Then
            targetCol.FieldName = "ResimBytes"
            targetCol.ColumnEdit = pic
            GridView6.OptionsView.RowAutoHeight = False
            GridView6.RowHeight = 120
            targetCol.Width = 140
            targetCol.OptionsColumn.FixedWidth = True
            pic.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            pic.PictureAlignment = System.Drawing.ContentAlignment.MiddleCenter
            targetCol.VisibleIndex = 0
        Else
            targetCol = GridView6.Columns.AddVisible("ResimBytes", "Resim")
            targetCol.ColumnEdit = pic
            targetCol.VisibleIndex = 0
        End If
        For Each c As DevExpress.XtraGrid.Columns.GridColumn In GridView6.Columns
            If Not Object.ReferenceEquals(c, targetCol) AndAlso String.Compare(c.Caption, "Resim", True) = 0 Then
                c.Visible = False
            End If
        Next
        GridView6.OptionsView.RowAutoHeight = True

        ' 4) *** KRTK KISIM ***  URL'den indir ve grid'i tazele
        Await FillGridImagesAsync(ds_tbStokResim.Tables(0))
        GridControl6.RefreshDataSource()
        GridView6.RefreshData()
        
        ' 5) Renk/Beden/Kavala kolonlarının visible kontrolü
        SetResimKolonlariVisibility(ds_tbStokResim.Tables(0))
    End Function
    
    Private Sub SetResimKolonlariVisibility(dt As DataTable)
        ' Renk/Beden/Kavala kolonları sadece değer varsa visible
        Try
            ' sKodu kontrolü
            Dim hasKodu As Boolean = False
            If dt.Columns.Contains("sKodu") Then
                For Each row As DataRow In dt.Rows
                    If Not IsDBNull(row("sKodu")) AndAlso Not String.IsNullOrEmpty(row("sKodu").ToString()) Then
                        hasKodu = True
                        Exit For
                    End If
                Next
            End If
            colsKodu_Resim.Visible = hasKodu
            
            ' sRenkAdi kontrolü
            Dim hasRenk As Boolean = False
            If dt.Columns.Contains("sRenkAdi") Then
                For Each row As DataRow In dt.Rows
                    If Not IsDBNull(row("sRenkAdi")) AndAlso Not String.IsNullOrEmpty(row("sRenkAdi").ToString()) Then
                        hasRenk = True
                        Exit For
                    End If
                Next
            End If
            colsRenkAdi_Resim.Visible = hasRenk
            
            ' sBeden kontrolü
            Dim hasBeden As Boolean = False
            If dt.Columns.Contains("sBeden") Then
                For Each row As DataRow In dt.Rows
                    If Not IsDBNull(row("sBeden")) AndAlso Not String.IsNullOrEmpty(row("sBeden").ToString()) Then
                        hasBeden = True
                        Exit For
                    End If
                Next
            End If
            colsBeden_Resim.Visible = hasBeden
            
            ' sKavala kontrolü
            Dim hasKavala As Boolean = False
            If dt.Columns.Contains("sKavala") Then
                For Each row As DataRow In dt.Rows
                    If Not IsDBNull(row("sKavala")) AndAlso Not String.IsNullOrEmpty(row("sKavala").ToString()) Then
                        hasKavala = True
                        Exit For
                    End If
                Next
            End If
            colsKavala_Resim.Visible = hasKavala
            
            Debug.WriteLine($"[SetResimKolonlariVisibility] sKodu={hasKodu}, sRenkAdi={hasRenk}, sBeden={hasBeden}, sKavala={hasKavala}")
        Catch ex As Exception
            Debug.WriteLine($"[SetResimKolonlariVisibility] Hata: {ex.Message}")
        End Try
    End Sub
    Private Async Function FillGridImagesAsync(dt As DataTable) As Task
        If Not dt.Columns.Contains("ResimBytes") Then
            dt.Columns.Add("ResimBytes", GetType(Byte()))
        End If

        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls
        
        Dim lokalKlasor As String = "C:\Eticaret\Stok Resim\"
        
        For Each r As DataRow In dt.Rows
            Dim hasBytes As Boolean =
            (Not IsDBNull(r("ResimBytes")) AndAlso TryCast(r("ResimBytes"), Byte()) IsNot Nothing AndAlso DirectCast(r("ResimBytes"), Byte()).Length > 0)
            If hasBytes Then Continue For
            
            ' Satır bilgilerini al
            Dim sModel As String = ""
            Dim sRenk As String = ""
            Dim sKodu As String = ""
            Dim nSira As Integer = 1
            Try
                sModel = If(TryCast(r("sModel"), String), "").Trim()
                sRenk = If(TryCast(r("sRenk"), String), "").Trim()
                nSira = If(IsDBNull(r("nSira")), 1, Convert.ToInt32(r("nSira")))
                ' sKodu varsa al (stok kodu - ör: 011116203-0000001)
                If dt.Columns.Contains("sKodu") Then
                    sKodu = If(TryCast(r("sKodu"), String), "").Trim()
                End If
            Catch
            End Try
            
            ' 1) ÖNCE LOKAL DOSYA KONTROLÜ - C:\Eticaret\Stok Resim\
            If Directory.Exists(lokalKlasor) Then
                Try
                    ' Dosya adı formatları - çeşitli kombinasyonları dene
                    Dim possibleFiles As New List(Of String)()
                    
                    ' Format 1: sKodu_nSira.jpg (ör: 011116203-0000001_1.jpg)
                    If Not String.IsNullOrEmpty(sKodu) Then
                        possibleFiles.Add(Path.Combine(lokalKlasor, $"{sKodu}_{nSira}.jpg"))
                        possibleFiles.Add(Path.Combine(lokalKlasor, $"{sKodu}_{nSira}.png"))
                    End If
                    
                    ' Format 2: sModel-sRenk_nSira.jpg
                    If Not String.IsNullOrEmpty(sModel) AndAlso Not String.IsNullOrEmpty(sRenk) Then
                        possibleFiles.Add(Path.Combine(lokalKlasor, $"{sModel}-{sRenk}_{nSira}.jpg"))
                        possibleFiles.Add(Path.Combine(lokalKlasor, $"{sModel}-{sRenk}_{nSira}.png"))
                    End If
                    
                    ' Format 3: sModel_nSira.jpg
                    If Not String.IsNullOrEmpty(sModel) Then
                        possibleFiles.Add(Path.Combine(lokalKlasor, $"{sModel}_{nSira}.jpg"))
                        possibleFiles.Add(Path.Combine(lokalKlasor, $"{sModel}_{nSira}.png"))
                        possibleFiles.Add(Path.Combine(lokalKlasor, $"{sModel}.jpg"))
                        possibleFiles.Add(Path.Combine(lokalKlasor, $"{sModel}.png"))
                    End If
                    
                    For Each fp As String In possibleFiles
                        If File.Exists(fp) Then
                            Dim b As Byte() = File.ReadAllBytes(fp)
                            If b IsNot Nothing AndAlso b.Length > 0 Then
                                SetRowBytesUI(r, b)
                                Exit For ' Dosya bulundu, döngüden çık
                            End If
                        End If
                    Next
                    
                    ' Eğer resim bulunduysa sonraki satıra geç
                    If Not IsDBNull(r("ResimBytes")) AndAlso TryCast(r("ResimBytes"), Byte()) IsNot Nothing Then
                        Continue For
                    End If
                Catch ex As Exception
                    Debug.WriteLine($"[FillGridImagesAsync] Lokal dosya okuma hatası: {ex.Message}")
                End Try
            End If

            ' 2) URL'den indir ve pResim'e cache'le
            Dim yol As String = ""
            Try
                yol = If(TryCast(r("yol"), String), "")
            Catch
                yol = ""
            End Try
            
            If Not String.IsNullOrWhiteSpace(yol) AndAlso (yol.StartsWith("http://") OrElse yol.StartsWith("https://")) Then
                Try
                    Dim b As Byte() = Nothing
                    
                    ' WebClient kullan (daha güvenilir)
                    Using client As New System.Net.WebClient()
                        client.Headers.Add("User-Agent", "BarkodMagaza/1.0")
                        b = client.DownloadData(yol)
                    End Using
                    
                    If b IsNot Nothing AndAlso b.Length > 0 Then
                        SetRowBytesUI(r, b)
                        
                        ' Lokale de kaydet
                        If Directory.Exists(lokalKlasor) OrElse True Then ' Klasör yoksa oluştur
                            Try
                                If Not Directory.Exists(lokalKlasor) Then Directory.CreateDirectory(lokalKlasor)
                                Dim fileName As String
                                If Not String.IsNullOrEmpty(sKodu) Then
                                    fileName = $"{sKodu}_{nSira}.jpg"
                                ElseIf Not String.IsNullOrEmpty(sModel) AndAlso Not String.IsNullOrEmpty(sRenk) Then
                                    fileName = $"{sModel}-{sRenk}_{nSira}.jpg"
                                Else
                                    fileName = $"{sModel}_{nSira}.jpg"
                                End If
                                File.WriteAllBytes(Path.Combine(lokalKlasor, fileName), b)
                            Catch
                            End Try
                        End If
                        
                        ' pResim'e cache olarak kaydet (nStokResimID gerekli)
                        Dim nStokResimID As Integer = 0
                        If Not IsDBNull(r("nStokResimID")) Then
                            nStokResimID = Convert.ToInt32(r("nStokResimID"))
                        End If
                        
                        If nStokResimID > 0 Then
                            ' Async olarak veritabanına kaydet (UI bloklanmasın)
                            Dim base64 As String = Convert.ToBase64String(b)
                            Dim id As Integer = nStokResimID
                            Task.Run(Sub()
                                CacheImageToDatabase(id, base64)
                            End Sub)
                        End If
                        
                        Continue For
                    End If
                Catch ex As Exception
                    Debug.WriteLine($"[FillGridImagesAsync] URL indirme hatası: {yol} - {ex.Message}")
                End Try
            End If

            ' 3) Base64'ten çevir
            Dim b64 As String = ""
            Try
                b64 = If(TryCast(r("pResim"), String), "")
            Catch
                b64 = ""
            End Try
            
            If Not String.IsNullOrWhiteSpace(b64) Then
                Try
                    Dim clean = b64.Replace(vbCr, "").Replace(vbLf, "").Replace(" ", "")
                    If clean.StartsWith("data:image") Then
                        Dim commaIndex As Integer = clean.IndexOf(","c)
                        If commaIndex > 0 Then
                            clean = clean.Substring(commaIndex + 1)
                        End If
                    End If
                    Dim b = Convert.FromBase64String(clean)
                    SetRowBytesUI(r, b)
                Catch ex As Exception
                    Debug.WriteLine($"[FillGridImagesAsync] Base64 decode hatası: {ex.Message}")
                End Try
            End If
        Next
    End Function
    
    ''' <summary>
    ''' URL'den indirilen resmi pResim alanına cache olarak kaydeder
    ''' </summary>
    Private Sub CacheImageToDatabase(nStokResimID As Integer, base64 As String)
        Try
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                Using cmd As New OleDb.OleDbCommand("UPDATE tbStokResim SET pResim = ? WHERE nStokResimID = ?", conn)
                    cmd.Parameters.AddWithValue("?", base64)
                    cmd.Parameters.AddWithValue("?", nStokResimID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Cache kaydetme hatası - sessizce geç
            Debug.WriteLine($"[CacheImageToDatabase] Hata: {ex.Message}")
        End Try
    End Sub
    Private Sub SetRowBytesUI(row As DataRow, bytes As Byte())
        If Me.IsHandleCreated AndAlso Me.InvokeRequired Then
            Me.BeginInvoke(CType(Sub() row("ResimBytes") = bytes, MethodInvoker))
        Else
            row("ResimBytes") = bytes
        End If
    End Sub
    Private Function CleanBase64(s As String) As String
        If String.IsNullOrEmpty(s) Then Return s
        s = s.Trim().Replace(" ", "").Replace(vbCr, "").Replace(vbLf, "")
        If s.StartsWith("data:", StringComparison.OrdinalIgnoreCase) Then
            Dim i = s.IndexOf(","c)
            If i >= 0 Then s = s.Substring(i + 1)
        End If
        Return s
    End Function

    Public Function Dataload_tbStokAlternatif(ByVal sModel As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, (SELECT ISNULL(SUM(lGirisMiktar1 - lCikisMiktar1),0) FROM tbStokFisiDetayi WHERE nStokID = tbStok.nStokID) AS KALAN FROM tbStokAlternatif INNER JOIN tbStok ON tbStokAlternatif.nStokID = tbStok.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk WHERE tbStokAlternatif.sModel ='" & sModel & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Try
            Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
            conn.Close()
        Catch ex As Exception
            sorgula_nStokID("CREATE TABLE [tbStokAlternatif] ([sModel] [char] (20) NOT NULL ,[nStokID] [int] NOT NULL ,CONSTRAINT [PK_tbStokAlternatif] PRIMARY KEY  CLUSTERED ([nStokID])  ON [PRIMARY] ) ON [PRIMARY]")
        End Try
        Return Datastoklar1
    End Function
    Public Function Dataload_tbStokMuhasebeEntegrasyon(ByVal sModel As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi, tbSubeMagazaHesapTipi.sAciklama, tbStokMuhasebeEntegrasyon.sSubeMagaza, tbStokMuhasebeEntegrasyon.sHareketTipi, tbStokMuhasebeEntegrasyon.nHesapID, tbHesapPlani.sKodu, tbHesapPlani.sAciklama AS sHesapAciklama FROM tbHesapPlani INNER JOIN tbStokMuhasebeEntegrasyon ON tbHesapPlani.nHesapID = tbStokMuhasebeEntegrasyon.nHesapID RIGHT OUTER JOIN tbSubeMagazaHesapTipi ON tbStokMuhasebeEntegrasyon.nSubeMagazaHesapTipi = tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi AND tbStokMuhasebeEntegrasyon.nStokID IN (SELECT nStokID FROM tbStok WHERE sModel = N'" & sModel & "') WHERE (tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi BETWEEN 6 AND 31) ORDER BY tbSubeMagazaHesapTipi.nSubeMagazaHesapTipi")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Try
            Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
            conn.Close()
        Catch ex As Exception
            ' sorgula_nStokID("CREATE TABLE [tbStokAlternatif] ([sModel] [char] (20) NOT NULL ,[nStokID] [int] NOT NULL ,CONSTRAINT [PK_tbStokAlternatif] PRIMARY KEY  CLUSTERED ([nStokID])  ON [PRIMARY] ) ON [PRIMARY]")
        End Try
        dataload_tbHesapPlani()
        Return Datastoklar1
    End Function
    Private Sub stok_sec()
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_stok_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nStokID = dr1("nStokID")
            sKodu = Trim(dr1("sKodu"))
            sModel = dr1("sModel")
            txt_musteriNo.EditValue = Trim(dr1("sModel"))
            stok_kontrol()
            dr1 = Nothing
        Else
            Try
                Me.Close()
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub stok_kontrol()
        If Trim(txt_musteriNo.EditValue).ToString <> "" Then
            Dim kontrol = sorgu_stok_kontrol(Trim(txt_musteriNo.EditValue))
            If kontrol = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Kayt Bulunumad...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf kontrol > 0 Then
                dataload_stok(Trim(txt_musteriNo.EditValue))
                Dim dr As DataRow
                For Each dr In ds_stok.Tables(0).Rows
                    'txt_Musteri.EditValue = dr("MUSTERI")
                    sKodu = Trim(dr("sKodu"))
                    nStokID = dr("nStokID")
                    sModel = Trim(dr("sModel"))
                    dataload(sModel)
                Next
                dr = Nothing
            End If
        End If
    End Sub
    Public Function sorgu_stok_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu like '" & kod & "%') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         tbStok " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_stok(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (sKodu like  '" & kod & "%') "
        ds_stok = sorgu(sorgu_query("SELECT     top 1 nStokID,sKodu,sAciklama,sModel FROM         tbStok " & kriter & ""))
    End Sub
    ' SADECE BU METODU GNCELLEYN
    Private Async Sub dataload(ByVal sModel As String)
        Dataload_tbStok(sModel)

        ds_nStokID = sorgu(sorgu_query(
        "SELECT nStokID FROM tbStok WHERE (nStokID NOT IN (SELECT nStokID FROM tbStokSinifi)) AND (sModel = N'" & sModel & "')"))

        Dim dr As DataRow
        For Each dr In ds_nStokID.Tables(0).Rows
            tbStokSinifi_kaydet_yeni(nStokID, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
        Next

        Dataload_tbStokSinifi(sModel)
        Dataload_tbStokBakiyesi(sModel)
        Dataload_tbStokAcilimi(sModel)
        Dataload_tbStokUzunNot(sModel)
        Dataload_tbStokBarkodu(sModel)

        ' --- KRTK: Resimleri burada ykle ve gridi BR KEZ bala ---
        Await Goster_StokResimleri(sModel)

        ' !!! BUNLARI SLN/IKARIN:
        ' ds_tbStokResim = Dataload_tbStokResim(sModel)
        ' GridControl6.DataSource = ds_tbStokResim.Tables(0)
        ' GridControl6.DataMember = Nothing

        Try
            ds_tbStokHareket.Tables(0).Clear()
        Catch
        End Try
        
        ' AI içeriklerini yükle
        If aiTabsInitialized Then
            LoadAIContent()
        End If
    End Sub

    Public Sub Dataload_tbStok(ByVal sModel As String)
        Try
            ds_tbStok.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 * From tbStok WHERE sModel ='" & sModel & "'")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT sAciklama, sKisaAdi, nStokTipi, sBedenTipi,sKavalaTipi, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi, sAlisKdvTipi,nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, sModel, sKullaniciAdi, bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2,nPrim,nEn,nBoy,nYukseklik,nHacim,nAgirlik,sDovizCinsi,ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS lBirimCarpan, ISNULL((SELECT ISNULL(bTersOran, 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 0) AS bTersOran, nWebIskontoYuzdesi, bWebGoruntule, bWebTavsiye, bOIVVar, nOIV, sRenk FROM tbStok WHERE sModel =N'" & sModel & "'")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT  sAciklama, sKisaAdi, nStokTipi, sBedenTipi,sKavalaTipi, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi,nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, sModel, sKullaniciAdi, bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2,nPrim,nEn,nBoy,nYukseklik,nHacim,nAgirlik,sDovizCinsi,ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS lBirimCarpan FROM tbStok WHERE sModel =N'" & sModel & "'")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbStok, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbStokBakiyesi(ByVal sModel As String)
        Try
            ds_tbStokBakiyesi.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST(ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS MONEY) AS  nGiris, CAST(ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS MONEY) AS nGirisIade, CAST(ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS MONEY) AS nCikis, CAST(ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS MONEY) AS nCikisIade, CAST(ISNULL((SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1)), 0) AS MONEY) AS nKalan FROM tbStokFisiDetayi WITH (INDEX (tbStokFisiDetayi_index8)) INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "') AND tbStokFisiDetayi.sFisTipi <>'T' and tbStokFisiDetayi.sDepo = '" & sDepo & "'")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST(ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS MONEY) AS  nGiris, CAST(ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS MONEY) AS nGirisIade, CAST(ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS MONEY) AS nCikis, CAST(ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS MONEY) AS nCikisIade, (SELECT     SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) AS nKalan FROM         tbStokFisiDetayi INNER JOIN                       tbStok Stok ON tbStokFisiDetayi.nStokID = Stok.nStokID Where Stok.sModel = N'" & sModel & "') nKalan FROM tbStokFisiDetayi WITH (INDEX (tbStokFisiDetayi_index8)) INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStok.sKodu = '" & sModel & "') AND tbStokFisiDetayi.sFisTipi NOT IN ('T','DG','DC') ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbStokBakiyesi, "Table1")
        conn.Close()
        lbl_sMiktar.Text = sDepo & ":" & Sorgu_sDil("Miktar", sDil)
    End Sub
    Public Sub Dataload_tbStokTutari(ByVal sModel As String)
        Try
            ds_tbStokTutari.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST(ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisTutar * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS MONEY) AS  nGiris, CAST(ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisTutar * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS MONEY) AS nGirisIade, CAST(ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS MONEY) AS nCikis, CAST(ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisTutar * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS MONEY) AS nCikisIade, CAST(ISNULL((SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1)), 0) AS MONEY)* ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStokFisiDetayi.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS nKalan FROM tbStokFisiDetayi WITH (INDEX (tbStokFisiDetayi_index8)) INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "') AND tbStokFisiDetayi.sFisTipi <>'T' Group by tbStokFisiDetayi.nStokID")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbStokTutari, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbStokAcilimi(ByVal sModel As String)
        Try
            ds_tbStokAcilim.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.nStokID, tbStok.sModel, tbStok.sKodu, tbStok.sRenk, tbStok.sBeden, tbStok.sKavala, tbRenk.sRenkAdi, (SELECT ISNULL(SUM(lGirisMiktar1 - lCikisMiktar1) , 0) AS nMevcut FROM tbStokFisiDetayi WHERE nStokID = tbStok.nStokID) AS nMevcut FROM tbStok INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk WHERE tbStok.sModel = N'" & sModel & "'")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbStokAcilim, "Table1")
        conn.Close()
        GridControl3.BestFit(fieldsRenkAdi)
    End Sub
    Public Sub Dataload_tbStokUzunNot(ByVal sModel As String)
        Try
            ds_tbStokUzunNot.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbStokUzunNot WHERE sModel = N'" & sModel & "'")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbStokUzunNot, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbStokBarkodu(ByVal sModel As String)
        Try
            ds_tbStokBarkodu.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokBarkodu.*, tbStok.nStokID as StokID,tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.sKavala, tbRenk.sRenkAdi FROM tbRenk INNER JOIN tbStok ON tbRenk.sRenk = tbStok.sRenk LEFT OUTER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID WHERE tbStok.sModel = N'" & sModel & "' Order by tbStokBarkodu.nStokID,tbStokBarkodu.nKisim")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbStokBarkodu, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbStokHareketleri(ByVal sModel As String, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        Try
            ds_tbStokHareket.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.nStokID,tbStok.sKodu as sStokKodu,tbStok.sAciklama as sStokAciklama,tbStok.sModel,tbStok.sRenk,tbStok.sBeden,tbFisTipi.sFisTipi, tbFisTipi.sAciklama, tbStokFisiDetayi. nIslemID,tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lCikisFiyat,  tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.lCikisMiktar1, tbStokFisiDetayi.lDovizKuru1, tbStokFisiDetayi.sDovizCinsi1, tbStokFisiDetayi.lBrutFiyat,tbStokFisiDetayi.lBrutFiyat as lBrut, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.nIskontoYuzdesi,tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.nKdvOrani,tbStokFisiDetayi.lMaliyetFiyat, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.sSaticiRumuzu, tbStokFisiDetayi.sFisTipi,tbStokFisiDetayi.nAlisverisID,tbStokFisiDetayi.nStokFisiID, tbStokFisiDetayi.nMusteriID, tbStokFisiDetayi.nFirmaID, tbMusteri.lKodu AS MUSTERIKODU, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS MUSTERIADI, tbFirma.sKodu AS FIRMAKODU, tbFirma.sAciklama AS FIRMAADI, '' AS HESAPKODU, '' AS HESAPADI, CAST(0 AS MONEY) AS KALAN,isnull(baslik.lToplamMiktar,0) AS FATURAMIKTARI, isnull(baslik.lMalBedeli - baslik.lMalIskontoTutari,0) AS FATURATUTARI, isnull(baslik.lEkmaliyet1,0) AS EKMALIYET,(SELECT sAlisVerisYapanAdi + ' ' + sAlisVerisYapanSoyadi FROM tbAlisVeris WHERE nAlisVerisID = tbStokFisiDetayi.nAlisVerisID) AS sAvYapanAdi FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi INNER JOIN tbFirma ON tbStokFisiDetayi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbStokFisiMaster baslik ON tbStokFisiDetayi.nStokFisiID = baslik.nStokFisiID LEFT OUTER JOIN tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStok.sModel = N'" & sModel & "')  AND tbStokFisiDetayi.dteIslemTarihi between '" & tarih1 & "' and '" & tarih2 & "' ORDER BY tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lFisNo")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbStokHareket, "Table1")
        conn.Close()
        Dim dr As DataRow
        Dim kalan = 0
        For Each dr In ds_tbStokHareket.Tables(0).Rows
            If CInt(dr("nFirmaID")) > 0 And CInt(dr("nMusteriID")) = 0 Then
                dr("HESAPKODU") = dr("FIRMAKODU").ToString
                dr("HESAPADI") = dr("FIRMAADI").ToString
            Else
                dr("HESAPKODU") = dr("MUSTERIKODU").ToString
                dr("HESAPADI") = dr("MUSTERIADI").ToString
            End If
            Dim oranekmaliyet As Decimal
            If dr("EKMALIYET") <> 0 Then
                oranekmaliyet = dr("EKMALIYET") / dr("FATURATUTARI")
            End If
            'dr("NETMALIYET") = dr("KDVLITUTAR") * ((100 + (dr("ORANEKMALIYET") * 100)) / 100)
            If dr("nGirisCikis") = 1 Then
                dr("lBrutFiyat") = dr("lGirisFiyat") * ((dr("nKdvOrani") + 100) / 100)
                oranekmaliyet = 0
                If dr("EKMALIYET") <> 0 Then
                    oranekmaliyet = dr("EKMALIYET") / dr("FATURATUTARI")
                    dr("lBrutFiyat") = dr("lBrutFiyat") * ((100 + (oranekmaliyet * 100)) / 100)
                End If
                dr("lBrutTutar") = dr("lBrutFiyat") * dr("lGirisMiktar1")
            ElseIf dr("nGirisCikis") = 2 Then
                dr("lBrutFiyat") = dr("lGirisFiyat") * ((dr("nKdvOrani") + 100) / 100)
                oranekmaliyet = 0
                If dr("EKMALIYET") <> 0 Then
                    oranekmaliyet = dr("EKMALIYET") / dr("FATURATUTARI")
                    dr("lBrutFiyat") = dr("lBrutFiyat") * ((100 + (oranekmaliyet * 100)) / 100)
                End If
                dr("lBrutTutar") = dr("lBrutFiyat") * dr("lGirisMiktar1")
            ElseIf dr("nGirisCikis") = 3 Then
                dr("lBrutFiyat") = dr("lCikisFiyat") * ((dr("nKdvOrani") + 100) / 100)
                oranekmaliyet = 0
                If dr("EKMALIYET") <> 0 Then
                    oranekmaliyet = dr("EKMALIYET") / dr("FATURATUTARI")
                    dr("lBrutFiyat") = dr("lBrutFiyat") * ((100 + (oranekmaliyet * 100)) / 100)
                End If
                dr("lBrutTutar") = dr("lBrutFiyat") * dr("lCikisMiktar1")
            ElseIf dr("nGirisCikis") = 4 Then
                dr("lBrutFiyat") = dr("lCikisFiyat") * ((dr("nKdvOrani") + 100) / 100)
                oranekmaliyet = 0
                If dr("EKMALIYET") <> 0 Then
                    oranekmaliyet = dr("EKMALIYET") / dr("FATURATUTARI")
                    dr("lBrutFiyat") = dr("lBrutFiyat") * ((100 + (oranekmaliyet * 100)) / 100)
                End If
                dr("lBrutTutar") = dr("lBrutFiyat") * dr("lCikisMiktar1")
            End If
            'dr("lBrutFiyat") = dr("lGirisFiyat")
            kalan = kalan + (dr("lGirisMiktar1") - dr("lCikisMiktar1"))
            dr("KALAN") = kalan
        Next
        colKALAN.SummaryItem.DisplayFormat = "" & FormatNumber((kalan), 4).ToString
        Try
            GridView4.UpdateSummary()
            GridView4.UpdateTotalSummary()
        Catch ex As Exception
        End Try
        dr = Nothing
        kalan = Nothing
        GridControl5.DataSource = ds_tbStokHareket.Tables(0)
    End Sub
    Private Sub Dataload_tbStokSinifi(ByVal sModel As String)
        Dim kriter As String = ""
        'kriter += " SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
        'kriter += " SELECT TOP 1 1 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi01 FROM tbParamStok) AS sSinifTipi, tbSSinif1.sSinifKodu, tbSSinif1.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        'kriter += " UNION ALL"
        'kriter += " SELECT TOP 1 2 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi02 FROM tbParamStok) AS sSinifTipi, tbSSinif2.sSinifKodu, tbSSinif2.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        'kriter += " UNION ALL"
        'kriter += " SELECT TOP 1 3 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi03 FROM tbParamStok) AS sSinifTipi, tbSSinif3.sSinifKodu, tbSSinif3.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        'kriter += " UNION ALL"
        'kriter += " SELECT TOP 1 4 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi04 FROM tbParamStok) AS sSinifTipi, tbSSinif4.sSinifKodu, tbSSinif4.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        'kriter += " UNION ALL"
        'kriter += " SELECT TOP 1 5 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi05 FROM tbParamStok) AS sSinifTipi, tbSSinif5.sSinifKodu, tbSSinif5.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        'kriter += " UNION ALL"
        'kriter += " SELECT TOP 1 6 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi06 FROM tbParamStok) AS sSinifTipi, tbSSinif6.sSinifKodu, tbSSinif6.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        'kriter += " UNION ALL"
        'kriter += " SELECT TOP 1 7 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi07 FROM tbParamStok) AS sSinifTipi, tbSSinif7.sSinifKodu, tbSSinif7.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        'kriter += " UNION ALL"
        'kriter += " SELECT TOP 1 8 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi08 FROM tbParamStok) AS sSinifTipi, tbSSinif8.sSinifKodu, tbSSinif8.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        'kriter += " UNION ALL"
        'kriter += " SELECT TOP 1 9 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi09 FROM tbParamStok) AS sSinifTipi, tbSSinif9.sSinifKodu, tbSSinif9.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        'kriter += " UNION ALL"
        'kriter += " SELECT TOP 1 10 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi10 FROM tbParamStok) AS sSinifTipi, tbSSinif10.sSinifKodu, tbSSinif10.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        'kriter += " UNION ALL"
        'kriter += " SELECT TOP 1 11 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi11 FROM tbParamStok) AS sSinifTipi, tbSSinif11.sSinifKodu, tbSSinif11.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        'kriter += " UNION ALL"
        'kriter += " SELECT TOP 1 12 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi12 FROM tbParamStok) AS sSinifTipi, tbSSinif12.sSinifKodu, tbSSinif12.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        'kriter += " UNION ALL"
        'kriter += " SELECT TOP 1 13 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi13 FROM tbParamStok) AS sSinifTipi, tbSSinif13.sSinifKodu, tbSSinif13.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        'kriter += " UNION ALL"
        'kriter += " SELECT TOP 1 14 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi14 FROM tbParamStok) AS sSinifTipi, tbSSinif14.sSinifKodu, tbSSinif14.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        'kriter += " UNION ALL"
        'kriter += " SELECT TOP 1 15 AS sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi15 FROM tbParamStok) AS sSinifTipi, tbSSinif15.sSinifKodu, tbSSinif15.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        kriter += " SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
        kriter += " Select Top 1 1 As sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (Select sSinifTipi01 FROM tbParamStok) As sSinifTipi, tbSSinif1.sSinifKodu ,tbSSinif1.sSinifKodu as sSinifKodu1,tbSSinif1.sSinifKodu2,tbSSinif1.sSinifKodu3,tbSSinif1.sSinifKodu4,tbSSinif1.sSinifKodu5,tbSSinif1.sSinifKodu6,tbSSinif1.sSinifKodu7,tbSSinif1.sSinifKodu8,tbSSinif1.sSinifKodu9,tbSSinif1.sSinifKodu10,tbSSinif1.sSinifKodu11,tbSSinif1.sSinifKodu12,tbSSinif1.sSinifKodu13,tbSSinif1.sSinifKodu14,tbSSinif1.sSinifKodu15, tbSSinif1.sAciklama FROM tbStokSinifi INNER Join tbSSinif1 On tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbStok On tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL"
        kriter += " Select Top 1 2 As sSinifNo, tbStokSinifi.nStokID, tbStok.sModel,(Select sSinifTipi02 FROM tbParamStok) As sSinifTipi, tbSSinif2.sSinifKodu ,tbSSinif2.sSinifKodu as sSinifKodu2 ,tbSSinif2.sSinifKodu1,tbSSinif2.sSinifKodu3,tbSSinif2.sSinifKodu4,tbSSinif2.sSinifKodu5,tbSSinif2.sSinifKodu6,tbSSinif2.sSinifKodu7,tbSSinif2.sSinifKodu8,tbSSinif2.sSinifKodu9,tbSSinif2.sSinifKodu10,tbSSinif2.sSinifKodu11,tbSSinif2.sSinifKodu12,tbSSinif2.sSinifKodu13,tbSSinif2.sSinifKodu14,tbSSinif2.sSinifKodu15, tbSSinif2.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif2 On tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbStok On tbStokSinifi.nStokID = tbStok.nStokID WHERE(tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL"
        kriter += " Select Top 1 3 As sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (Select sSinifTipi03 FROM tbParamStok) As sSinifTipi, tbSSinif3.sSinifKodu, tbSSinif3.sSinifKodu as sSinifKodu3,tbSSinif3.sSinifKodu1,tbSSinif3.sSinifKodu2,tbSSinif3.sSinifKodu4,tbSSinif3.sSinifKodu5,tbSSinif3.sSinifKodu6,tbSSinif3.sSinifKodu7,tbSSinif3.sSinifKodu8,tbSSinif3.sSinifKodu9,tbSSinif3.sSinifKodu10,tbSSinif3.sSinifKodu11,tbSSinif3.sSinifKodu12,tbSSinif3.sSinifKodu13,tbSSinif3.sSinifKodu14,tbSSinif3.sSinifKodu15, tbSSinif3.sAciklama FROM tbStokSinifi INNER Join tbSSinif3 On tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbStok On tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL"
        kriter += " Select Top 1 4 As sSinifNo, tbStokSinifi.nStokID, tbStok.sModel,(Select sSinifTipi04 FROM tbParamStok) As sSinifTipi, tbSSinif4.sSinifKodu, tbSSinif4.sSinifKodu as sSinifKodu4,tbSSinif4.sSinifKodu1,tbSSinif4.sSinifKodu2,tbSSinif4.sSinifKodu3,tbSSinif4.sSinifKodu5,tbSSinif4.sSinifKodu6,tbSSinif4.sSinifKodu7,tbSSinif4.sSinifKodu8,tbSSinif4.sSinifKodu9,tbSSinif4.sSinifKodu10,tbSSinif4.sSinifKodu11,tbSSinif4.sSinifKodu12,tbSSinif4.sSinifKodu13,tbSSinif4.sSinifKodu14,tbSSinif4.sSinifKodu15, tbSSinif4.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif4 On tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbStok On tbStokSinifi.nStokID = tbStok.nStokID WHERE(tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL"
        kriter += " Select Top 1 5 As sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (Select sSinifTipi05 FROM tbParamStok) As sSinifTipi, tbSSinif5.sSinifKodu, tbSSinif5.sSinifKodu as sSinifKodu5,tbSSinif5.sSinifKodu1,tbSSinif5.sSinifKodu2,tbSSinif5.sSinifKodu3,tbSSinif5.sSinifKodu4,tbSSinif5.sSinifKodu6,tbSSinif5.sSinifKodu7,tbSSinif5.sSinifKodu8,tbSSinif5.sSinifKodu9,tbSSinif5.sSinifKodu10,tbSSinif5.sSinifKodu11,tbSSinif5.sSinifKodu12,tbSSinif5.sSinifKodu13,tbSSinif5.sSinifKodu14,tbSSinif5.sSinifKodu15, tbSSinif5.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif5 On tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbStok On tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel =N'" & sModel & "')"
        kriter += " UNION ALL "
        kriter += " Select TOP 1 6 As sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi06 FROM tbParamStok) AS sSinifTipi, tbSSinif6.sSinifKodu, tbSSinif6.sSinifKodu as sSinifKodu6, tbSSinif6.sSinifKodu1, tbSSinif6.sSinifKodu2, tbSSinif6.sSinifKodu3, tbSSinif6.sSinifKodu4, tbSSinif6.sSinifKodu5, tbSSinif6.sSinifKodu7, tbSSinif6.sSinifKodu8, tbSSinif6.sSinifKodu9, tbSSinif6.sSinifKodu10, tbSSinif6.sSinifKodu11, tbSSinif6.sSinifKodu12, tbSSinif6.sSinifKodu13, tbSSinif6.sSinifKodu14, tbSSinif6.sSinifKodu15, tbSSinif6.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL "
        kriter += " Select TOP 1 7 As sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi07 FROM tbParamStok) AS sSinifTipi, tbSSinif7.sSinifKodu, tbSSinif7.sSinifKodu as sSinifKodu7,tbSSinif7.sSinifKodu1,tbSSinif7.sSinifKodu2,tbSSinif7.sSinifKodu3,tbSSinif7.sSinifKodu4,tbSSinif7.sSinifKodu5,tbSSinif7.sSinifKodu6,tbSSinif7.sSinifKodu8,tbSSinif7.sSinifKodu9,tbSSinif7.sSinifKodu10,tbSSinif7.sSinifKodu11,tbSSinif7.sSinifKodu12,tbSSinif7.sSinifKodu13,tbSSinif7.sSinifKodu14,tbSSinif7.sSinifKodu15, tbSSinif7.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE(tbStok.sModel =N'" & sModel & "')"
        kriter += " UNION ALL "
        kriter += " Select TOP 1 8 As sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi08 FROM tbParamStok) AS sSinifTipi, tbSSinif8.sSinifKodu, tbSSinif8.sSinifKodu as sSinifKodu8,tbSSinif8.sSinifKodu1,tbSSinif8.sSinifKodu2,tbSSinif8.sSinifKodu3,tbSSinif8.sSinifKodu4,tbSSinif8.sSinifKodu5,tbSSinif8.sSinifKodu6,tbSSinif8.sSinifKodu7,tbSSinif8.sSinifKodu9,tbSSinif8.sSinifKodu10,tbSSinif8.sSinifKodu11,tbSSinif8.sSinifKodu12,tbSSinif8.sSinifKodu13,tbSSinif8.sSinifKodu14,tbSSinif8.sSinifKodu15, tbSSinif8.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL "
        kriter += " Select TOP 1 9 As sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi09 FROM tbParamStok) AS sSinifTipi, tbSSinif9.sSinifKodu, tbSSinif9.sSinifKodu as sSinifKodu9,tbSSinif9.sSinifKodu1,tbSSinif9.sSinifKodu2,tbSSinif9.sSinifKodu3,tbSSinif9.sSinifKodu4,tbSSinif9.sSinifKodu5,tbSSinif9.sSinifKodu6,tbSSinif9.sSinifKodu7,tbSSinif9.sSinifKodu8,tbSSinif9.sSinifKodu10,tbSSinif9.sSinifKodu11,tbSSinif9.sSinifKodu12,tbSSinif9.sSinifKodu13,tbSSinif9.sSinifKodu14,tbSSinif9.sSinifKodu15, tbSSinif9.sAciklama From tbStokSinifi INNER Join tbSSinif9 On tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER Join tbStok On tbStokSinifi.nStokID = tbStok.nStokID Where (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL "
        kriter += " Select TOP 1 10 As sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi10 FROM tbParamStok) AS sSinifTipi, tbSSinif10.sSinifKodu, tbSSinif10.sSinifKodu as sSinifKodu10,tbSSinif10.sSinifKodu1,tbSSinif10.sSinifKodu2,tbSSinif10.sSinifKodu3,tbSSinif10.sSinifKodu4,tbSSinif10.sSinifKodu5,tbSSinif10.sSinifKodu6,tbSSinif10.sSinifKodu7,tbSSinif10.sSinifKodu8,tbSSinif10.sSinifKodu9,tbSSinif10.sSinifKodu11,tbSSinif10.sSinifKodu12,tbSSinif10.sSinifKodu13,tbSSinif10.sSinifKodu14,tbSSinif10.sSinifKodu15, tbSSinif10.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL "
        kriter += " Select TOP 1 11 As sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi11 FROM tbParamStok) AS sSinifTipi, tbSSinif11.sSinifKodu, tbSSinif11.sSinifKodu as sSinifKodu11,tbSSinif11.sSinifKodu1,tbSSinif11.sSinifKodu2,tbSSinif11.sSinifKodu3,tbSSinif11.sSinifKodu4,tbSSinif11.sSinifKodu5,tbSSinif11.sSinifKodu6,tbSSinif11.sSinifKodu7,tbSSinif11.sSinifKodu8,tbSSinif11.sSinifKodu9,tbSSinif11.sSinifKodu10,tbSSinif11.sSinifKodu12,tbSSinif11.sSinifKodu13,tbSSinif11.sSinifKodu14,tbSSinif11.sSinifKodu15, tbSSinif11.sAciklama FROM tbStokSinifi INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER Join tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL "
        kriter += " Select TOP 1 12 As sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi12 FROM tbParamStok) AS sSinifTipi, tbSSinif12.sSinifKodu, tbSSinif12.sSinifKodu as sSinifKodu12,tbSSinif12.sSinifKodu1,tbSSinif12.sSinifKodu2,tbSSinif12.sSinifKodu3,tbSSinif12.sSinifKodu4,tbSSinif12.sSinifKodu5,tbSSinif12.sSinifKodu6,tbSSinif12.sSinifKodu7,tbSSinif12.sSinifKodu8,tbSSinif12.sSinifKodu9,tbSSinif12.sSinifKodu10,tbSSinif12.sSinifKodu11,tbSSinif12.sSinifKodu13,tbSSinif12.sSinifKodu14,tbSSinif12.sSinifKodu15, tbSSinif12.sAciklama From tbStokSinifi INNER Join tbSSinif12 On tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER Join tbStok On tbStokSinifi.nStokID = tbStok.nStokID Where (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL "
        kriter += " Select TOP 1 13 As sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi13 FROM tbParamStok) AS sSinifTipi, tbSSinif13.sSinifKodu, tbSSinif13.sSinifKodu as sSinifKodu13,tbSSinif13.sSinifKodu1,tbSSinif13.sSinifKodu2,tbSSinif13.sSinifKodu3,tbSSinif13.sSinifKodu4,tbSSinif13.sSinifKodu5,tbSSinif13.sSinifKodu6,tbSSinif13.sSinifKodu7,tbSSinif13.sSinifKodu8,tbSSinif13.sSinifKodu9,tbSSinif13.sSinifKodu10,tbSSinif13.sSinifKodu11,tbSSinif13.sSinifKodu12,tbSSinif13.sSinifKodu14,tbSSinif13.sSinifKodu15, tbSSinif13.sAciklama FROM tbStokSinifi INNER Join tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL "
        kriter += " Select Top 1 14 As sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (Select sSinifTipi14 FROM tbParamStok) As sSinifTipi, tbSSinif14.sSinifKodu, tbSSinif14.sSinifKodu as sSinifKodu14,tbSSinif14.sSinifKodu1,tbSSinif14.sSinifKodu2,tbSSinif14.sSinifKodu3,tbSSinif14.sSinifKodu4,tbSSinif14.sSinifKodu5,tbSSinif14.sSinifKodu6,tbSSinif14.sSinifKodu7,tbSSinif14.sSinifKodu8,tbSSinif14.sSinifKodu9,tbSSinif14.sSinifKodu10,tbSSinif14.sSinifKodu11,tbSSinif14.sSinifKodu12,tbSSinif14.sSinifKodu13,tbSSinif14.sSinifKodu15, tbSSinif14.sAciklama From tbStokSinifi INNER Join tbSSinif14 On tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER Join tbStok On tbStokSinifi.nStokID = tbStok.nStokID Where (tbStok.sModel = N'" & sModel & "')"
        kriter += " UNION ALL "
        kriter += " Select TOP 1 15 As sSinifNo, tbStokSinifi.nStokID, tbStok.sModel, (SELECT sSinifTipi15 FROM tbParamStok) AS sSinifTipi, tbSSinif15.sSinifKodu, tbSSinif15.sSinifKodu as sSinifKodu15,tbSSinif15.sSinifKodu1,tbSSinif15.sSinifKodu2,tbSSinif15.sSinifKodu3,tbSSinif15.sSinifKodu4,tbSSinif15.sSinifKodu5,tbSSinif15.sSinifKodu6,tbSSinif15.sSinifKodu7,tbSSinif15.sSinifKodu8,tbSSinif15.sSinifKodu9,tbSSinif15.sSinifKodu10,tbSSinif15.sSinifKodu11,tbSSinif15.sSinifKodu12,tbSSinif15.sSinifKodu13,tbSSinif15.sSinifKodu14, tbSSinif15.sAciklama FROM tbStokSinifi INNER Join tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu INNER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "')"
        ds_tbStokSinifi = sorgu(sorgu_query("" & kriter & ""))
        GridControl1.DataMember = Nothing
        GridControl1.DataSource = ds_tbStokSinifi.Tables(0)
    End Sub
    Public Function Dataload_tbStokAciklamasi(ByVal sModel As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     top 1 * FROM         tbStokAciklama WHERE     (nStokID IN (SELECT     nStokID FROM          tbStok WHERE      sModel = N'" & sModel & "'))")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function Dataload_tbStokAyYekunleri(ByVal sModel As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("set language Trke set dateformat dmy set datefirst 1 SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DATENAME([month], tbStokFisiDetayi.dteIslemTarihi) AS sAy, YEAR(tbStokFisiDetayi.dteIslemTarihi) AS sYil, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 2))), 0) AS nGiris, ISNULL(ABS(SUM(tbStokFisiDetayi.lGirisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 1))), 0) AS nGirisIade, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 4))), 0) AS nCikis, ISNULL(ABS(SUM(tbStokFisiDetayi.lCikisMiktar1 * (tbStokFisiDetayi.nGirisCikis - 3))), 0) AS nCikisIade, ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS nKalan FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID WHERE (tbStok.sModel = N'" & sModel & "') AND tbStokFisiDetayi.sFisTipi <>'T' GROUP BY DATENAME([month], tbStokFisiDetayi.dteIslemTarihi), MONTH(tbStokFisiDetayi.dteIslemTarihi), YEAR(tbStokFisiDetayi.dteIslemTarihi) ORDER BY YEAR(tbStokFisiDetayi.dteIslemTarihi), MONTH(tbStokFisiDetayi.dteIslemTarihi) ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_tbStokTablo_kontrol(ByVal nStokID As String, ByVal Tablo As String) As Int64
        Dim kriter
        kriter = "WHERE (nStokID = N'" & nStokID & "') "
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
    Private Sub tbStok_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal sKisaAdi As String, ByVal nStokTipi As Int64, ByVal sBedenTipi As String, ByVal sKavalaTipi As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sKavala As String, ByVal sBirimCinsi1 As String, ByVal sBirimCinsi2 As String, ByVal nIskontoYuzdesi As Decimal, ByVal sKdvTipi As String, ByVal nTeminSuresi As Decimal, ByVal lAsgariMiktar As Decimal, ByVal lAzamiMiktar As Decimal, ByVal sOzelNot As String, ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bEksiyeDusulebilirmi As Byte, ByVal sDefaultAsortiTipi As String, ByVal bEksideUyarsinmi As Byte, ByVal bOTVVar As Byte, ByVal sOTVTipi As String, ByVal nIskontoYuzdesiAV As Decimal, ByVal bEk1 As Byte, ByVal nEk2 As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStok (sKodu, sAciklama, sKisaAdi, nStokTipi, sBedenTipi, sKavalaTipi, sRenk, sBeden, sKavala, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi, nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, sModel, sKullaniciAdi, dteKayitTarihi, bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2) VALUES     (sKodu, sAciklama, sKisaAdi, nStokTipi, sBedenTipi, sKavalaTipi, sRenk, sBeden, sKavala, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi, nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, sModel, sKullaniciAdi, dteKayitTarihi, bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2)")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStok_kaydet_duzelt(ByVal sKodu As String, ByVal sAciklama As String, ByVal sKisaAdi As String, ByVal nStokTipi As Int64, ByVal sBedenTipi As String, ByVal sKavalaTipi As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sKavala As String, ByVal sBirimCinsi1 As String, ByVal sBirimCinsi2 As String, ByVal nIskontoYuzdesi As Decimal, ByVal sKdvTipi As String, ByVal nTeminSuresi As Decimal, ByVal lAsgariMiktar As Decimal, ByVal lAzamiMiktar As Decimal, ByVal sOzelNot As String, ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bEksiyeDusulebilirmi As Byte, ByVal sDefaultAsortiTipi As String, ByVal bEksideUyarsinmi As Byte, ByVal bOTVVar As Byte, ByVal sOTVTipi As String, ByVal nIskontoYuzdesiAV As Decimal, ByVal bEk1 As Byte, ByVal nEk2 As String, ByVal nPrim As Decimal, ByVal nEn As Decimal, ByVal nBoy As Decimal, ByVal nYukseklik As Decimal, ByVal nHacim As Decimal, ByVal nAgirlik As Decimal, ByVal sDovizCinsi As String, ByVal sAlisKdvTipi As String, ByVal bWebGoruntule As Byte, ByVal nWebIskontoYuzdesi As Decimal, ByVal bWebTavsiye As Byte, ByVal bOIVVar As Byte, ByVal nOIV As Decimal)
        'Private Sub tbStok_kaydet_duzelt(ByVal sKodu As String, ByVal sAciklama As String, ByVal sKisaAdi As String, ByVal nStokTipi As Int64, ByVal sBedenTipi As String, ByVal sKavalaTipi As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sKavala As String, ByVal sBirimCinsi1 As String, ByVal sBirimCinsi2 As String, ByVal nIskontoYuzdesi As Decimal, ByVal sKdvTipi As String, ByVal nTeminSuresi As Decimal, ByVal lAsgariMiktar As Decimal, ByVal lAzamiMiktar As Decimal, ByVal sOzelNot As String, ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bEksiyeDusulebilirmi As Byte, ByVal sDefaultAsortiTipi As String, ByVal bEksideUyarsinmi As Byte, ByVal bOTVVar As Byte, ByVal sOTVTipi As String, ByVal nIskontoYuzdesiAV As Decimal, ByVal bEk1 As Byte, ByVal nEk2 As String, ByVal nPrim As Decimal, ByVal nEn As Decimal, ByVal nBoy As Decimal, ByVal nYukseklik As Decimal, ByVal nHacim As Decimal, ByVal nAgirlik As Decimal, ByVal sDovizCinsi As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStok SET sAciklama = N'" & sAciklama & "', sKisaAdi = N'" & sKisaAdi & "', nStokTipi = " & nStokTipi & ", sBedenTipi = N'" & sBedenTipi & "', sKavalaTipi = N'" & sKavalaTipi & "', sBirimCinsi1 = N'" & sBirimCinsi1 & "', sBirimCinsi2 = N'" & sBirimCinsi2 & "', nIskontoYuzdesi = '0.00', sKdvTipi = N'" & sKdvTipi & "', nTeminSuresi = N'" & nTeminSuresi & "', lAsgariMiktar = " & lAsgariMiktar & ", lAzamiMiktar = " & lAzamiMiktar & ", sOzelNot = N'" & sOzelNot & "', nFiyatlandirma = " & nFiyatlandirma & ", bEksiyeDusulebilirmi = " & bEksiyeDusulebilirmi & ", sDefaultAsortiTipi = N'" & sDefaultAsortiTipi & "', bEksideUyarsinmi = " & bEksideUyarsinmi & ", bOTVVar = " & bOTVVar & ", sOTVTipi = N'" & sOTVTipi & "', nIskontoYuzdesiAV =" & nIskontoYuzdesiAV & ", bEk1 = " & bEk1 & ", nEk2 = " & nEk2 & ", nPrim=" & nPrim & ", nEn = " & nEn & ", nBoy = " & nBoy & ",nYukseklik = " & nYukseklik & ",nHacim = " & nHacim & ",nAgirlik = " & nAgirlik & ",sDovizCinsi = '" & sDovizCinsi & "',sAlisKdvTipi = '" & sAlisKdvTipi & "', bWebGoruntule = " & bWebGoruntule & ", nWebIskontoYuzdesi = " & nWebIskontoYuzdesi & ", bWebTavsiye = " & bWebTavsiye & ", bOIVVar = " & bOIVVar & ", nOIV = " & nOIV & " Where sModel= N'" & sModel & "' ")
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStok SET              sAciklama = N'" & sAciklama & "', sKisaAdi = N'" & sKisaAdi & "', nStokTipi = " & nStokTipi & ", sBedenTipi = N'" & sBedenTipi & "', sKavalaTipi = N'" & sKavalaTipi & "', sBirimCinsi1 = N'" & sBirimCinsi1 & "', sBirimCinsi2 = N'" & sBirimCinsi2 & "', nIskontoYuzdesi = " & nIskontoYuzdesi & ",sKdvTipi = N'" & sKdvTipi & "', nTeminSuresi = N'" & nTeminSuresi & "', lAsgariMiktar = " & lAsgariMiktar & ", lAzamiMiktar = " & lAzamiMiktar & ", sOzelNot = N'" & sOzelNot & "', nFiyatlandirma = " & nFiyatlandirma & ",bEksiyeDusulebilirmi = " & bEksiyeDusulebilirmi & ", sDefaultAsortiTipi = N'" & sDefaultAsortiTipi & "', bEksideUyarsinmi = " & bEksideUyarsinmi & ", bOTVVar = " & bOTVVar & ", sOTVTipi = N'" & sOTVTipi & "', nIskontoYuzdesiAV =" & nIskontoYuzdesiAV & ", bEk1 = " & bEk1 & ", nEk2 = " & nEk2 & ",nPrim=" & nPrim & ",nEn = " & nEn & ",nBoy = " & nBoy & ",nYukseklik = " & nYukseklik & ",nHacim = " & nHacim & ",nAgirlik = " & nAgirlik & ",sDovizCinsi = '" & sDovizCinsi & "' Where sModel= N'" & sModel & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub tbStokSinifi_kaydet_yeni(ByVal nStokID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String, ByVal sSinifKodu6 As String, ByVal sSinifKodu7 As String, ByVal sSinifKodu8 As String, ByVal sSinifKodu9 As String, ByVal sSinifKodu10 As String, ByVal sSinifKodu11 As String, ByVal sSinifKodu12 As String, ByVal sSinifKodu13 As String, ByVal sSinifKodu14 As String, ByVal sSinifKodu15 As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokSinifi (nStokID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, sSinifKodu11, sSinifKodu12, sSinifKodu13, sSinifKodu14, sSinifKodu15) VALUES     (N'" & nStokID & "', N'" & sSinifKodu1 & "', N'" & sSinifKodu2 & "', N'" & sSinifKodu3 & "', N'" & sSinifKodu4 & "', N'" & sSinifKodu5 & "', N'" & sSinifKodu6 & "', N'" & sSinifKodu7 & "', N'" & sSinifKodu8 & "', N'" & sSinifKodu9 & "', N'" & sSinifKodu10 & "',  N'" & sSinifKodu11 & "', N'" & sSinifKodu12 & "', N'" & sSinifKodu13 & "', N'" & sSinifKodu14 & "', N'" & sSinifKodu15 & "')")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        con.Close()
    End Sub
    Private Sub tbStokSinifi_kaydet_duzelt(ByVal sModel As String, ByVal sSinifKodu As String, ByVal sSinifNo As Integer)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSinifi SET              sSinifKodu" & sSinifNo & " = N'" & sSinifKodu & "' where nStokID IN (Select nStokID from tbStok where sModel = N'" & sModel & "' )")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokSinifi_kaydet_duzelt1(ByVal sModel As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String, ByVal sSinifKodu6 As String, ByVal sSinifKodu7 As String, ByVal sSinifKodu As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSinifi SET    sSinifKodu2 =  N'" & sSinifKodu2 & "', sSinifKodu3 =  N'" & sSinifKodu3 & "',  sSinifKodu4 =  N'" & sSinifKodu4 & "' ,  sSinifKodu5 =  N'" & sSinifKodu5 & "',  sSinifKodu6 =  N'" & sSinifKodu6 & "',  sSinifKodu7 =  N'" & sSinifKodu7 & "' where nStokID IN (Select nStokID from tbStok where sModel = N'" & sModel & "' )")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokMuhasebeEntegrasyonu_kaydet_duzelt(ByVal sModel As String, ByVal sSubeMagaza As String, ByVal nSubeMagazaHesapTipi As Int64, ByVal sHareketTipi As String, ByVal nHesapID As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokMuhasebeEntegrasyon WHERE sSubeMagaza = '" & sSubeMagaza & "' and sHareketTipi = '" & sHareketTipi & "' and nSubeMagazaHesapTipi = " & nSubeMagazaHesapTipi & " and nStokID IN(Select nStokID from tbStok where sModel = N'" & sModel & "' )")
        cmd.ExecuteNonQuery()
        If nHesapID <> 0 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokMuhasebeEntegrasyon   select nStokID, '" & sSubeMagaza & "', " & nSubeMagazaHesapTipi & ", '" & sHareketTipi & "', " & nHesapID & " from tbStok where sModel = N'" & sModel & "' ")
            cmd.ExecuteNonQuery()
        End If
        con.Close()
    End Sub
    Private Sub tbStokKod_kaydet_duzelt(ByVal sModel As String, ByVal sKodu As String)
        Dim ds_tbEskiStoklar As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sModel, sRenk, sBeden, sKavala, sKodu FROM tbStok WHERE (sModel = N'" & sModel & "')"))
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Dim dr2 As DataRow
        Dim sYeniKod As String = ""
        For Each dr2 In ds_tbEskiStoklar.Tables(0).Rows
            dr2("sModel") = sKodu
            sYeniKod = sKodu & dr2("sRenk") & dr2("sBeden") & dr2("sKavala")
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStok SET sModel = N'" & sKodu & "', sKodu = N'" & sYeniKod & "' where sKodu = N'" & dr2("sKodu") & "' and sModel = N'" & sModel & "'")
            cmd.ExecuteNonQuery()
        Next
        con.Close()
    End Sub
    Private Sub tbStokUzunNot_kaydet_yeni(ByVal sModel As String, ByVal sUzunNot As String, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokUzunNot (sModel, sUzunNot, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & sModel & "', '" & sUzunNot & "', '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokUzunNot_kaydet_duzelt(ByVal sModel As String, ByVal sUzunNot As String, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokUzunNot SET              sUzunNot = N'" & sUzunNot & "', dteSonUpdateTarihi = N'" & dteSonUpdateTarihi & "' Where sModel = N'" & sModel & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokUzunNot_kaydet_sil(ByVal sModel As String)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokUzunNot Where sModel = N'" & sModel & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokAlternatif_kaydet_yeni(ByVal sModel As String, ByVal nStokID As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokAlternatif (sModel, nStokID) VALUES     ('" & sModel & "', " & nStokID & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokAlternatif_kaydet_duzelt(ByVal sModel As String, ByVal nStokID As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokAlternatif SET              nStokID = " & nStokID & " Where sModel = N'" & sModel & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokAlternatif_kaydet_sil(ByVal sModel As String, ByVal nStokID As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokAlternatif Where sModel = N'" & sModel & "' and nStokID = " & nStokID & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokBarkodu_kaydet_yeni(ByVal sModel As String, ByVal islem As Integer)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("sp_NebEanOlustur '" & sModel & "' , '" & sModel & "' , 0 , 0 , '' , '' , " & islem & "")
        cmd.ExecuteNonQuery()
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED sp_NebEanOlustur '" & sModel & "' , '" & sModel & "' , 0 , 0 , '' , 'Yeni_OtomatikEan' , 0")
        'cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub kaydet_tumu(Optional ByVal status As Boolean = False)
        Dim sUyari As String = ""
        sUyari = sUyariKontrol()
        If sUyari = "" Then
        Else
            XtraMessageBox.Show(sUyari, Sorgu_sDil("Dikkat", sDil))
            Exit Sub
        End If
        Dim dr As DataRow
        dr = ds_tbStok.Tables(0).Rows(0)
        If dr("lBirimCarpan") = 0 Then
            dr("lBirimCarpan") = 1
        End If
        dr("nHacim") = sorgu_sayi(dr("nEn"), 0) * sorgu_sayi(dr("nBoy"), 0) * sorgu_sayi(dr("nYukseklik"), 0)
        If IsDBNull(dr("bWebGoruntule")) Then
            dr("bWebGoruntule") = False
        End If
        If IsDBNull(dr("nWebIskontoYuzdesi")) Then
            dr("nWebIskontoYuzdesi") = 0
        End If
        If IsDBNull(dr("bWebTavsiye")) Then
            dr("bWebTavsiye") = False
        End If
        If IsDBNull(dr("bOIVVar")) Then
            dr("bOIVVar") = 0
        End If
        If IsDBNull(dr("nOIV")) Then
            dr("nOIV") = 0
        End If
        tbStok_kaydet_duzelt(dr("sKodu").ToString(), dr("sAciklama").ToString(), dr("sKisaAdi").ToString(), dr("nStokTipi"), dr("sBedenTipi").ToString(), dr("sKavalaTipi").ToString(), dr("sRenk").ToString(), dr("sBeden").ToString(), dr("sKavala").ToString(), dr("sBirimCinsi1").ToString(), dr("sBirimCinsi2").ToString(), dr("nIskontoYuzdesi"), dr("sKdvTipi").ToString(), dr("nTeminSuresi"), dr("lAsgariMiktar"), dr("lAzamiMiktar"), dr("sOzelNot").ToString(), dr("nFiyatlandirma"), sModel.ToString(), dr("sKullaniciAdi").ToString(), Now, dr("bEksiyeDusulebilirmi"), dr("sDefaultAsortiTipi").ToString(), dr("bEksideUyarsinmi"), dr("bOTVVar"), dr("sOTVTipi").ToString(), dr("nIskontoYuzdesiAV"), dr("bEk1"), dr("nEk2").ToString(), dr("nPrim"), sorgu_sayi(dr("nEn"), 0), sorgu_sayi(dr("nBoy"), 0), sorgu_sayi(dr("nYukseklik"), 0), sorgu_sayi(dr("nHacim"), 0), sorgu_sayi(dr("nAgirlik"), 0), dr("sDovizCinsi").ToString(), dr("sAlisKdvTipi").ToString(), dr("bWebGoruntule"), sorgu_sayi(dr("nWebIskontoYuzdesi"), 0), dr("bWebTavsiye"), dr("bOIVVar"), dr("nOIV"))
        'tbStok_kaydet_duzelt(dr("sKodu").ToString(), dr("sAciklama").ToString(), dr("sKisaAdi").ToString(), dr("nStokTipi"), dr("sBedenTipi").ToString(), dr("sKavalaTipi").ToString(), dr("sRenk").ToString(), dr("sBeden").ToString(), dr("sKavala").ToString(), dr("sBirimCinsi1").ToString(), dr("sBirimCinsi2").ToString(), dr("nIskontoYuzdesi"), dr("sKdvTipi").ToString(), dr("nTeminSuresi"), dr("lAsgariMiktar"), dr("lAzamiMiktar"), dr("sOzelNot").ToString(), dr("nFiyatlandirma"), sModel.ToString(), dr("sKullaniciAdi").ToString(), Now, dr("bEksiyeDusulebilirmi"), dr("sDefaultAsortiTipi").ToString(), dr("bEksideUyarsinmi"), dr("bOTVVar"), dr("sOTVTipi").ToString(), dr("nIskontoYuzdesiAV"), dr("bEk1"), dr("nEk2").ToString(), dr("nPrim"), sorgu_sayi(dr("nEn"), 0), sorgu_sayi(dr("nBoy"), 0), sorgu_sayi(dr("nYukseklik"), 0), sorgu_sayi(dr("nHacim"), 0), sorgu_sayi(dr("nAgirlik"), 0), dr("sDovizCinsi").ToString())
        tbStokBirimCevirimi_kaydet_sil(sModel, dr("sBirimCinsi2"))
        tbStokBirimCevrimi_kaydet_yeni(dr("sBirimCinsi2"), dr("lBirimCarpan"), sModel)
        If txt_sUzunNot.Text <> "" Then
            If ds_tbStokUzunNot.Tables(0).Rows.Count > 0 Then
                tbStokUzunNot_kaydet_duzelt(sModel, txt_sUzunNot.Text, kullanici, Now)
            Else
                tbStokUzunNot_kaydet_yeni(sModel, txt_sUzunNot.Text, kullanici, Now)
            End If
        Else
            tbStokUzunNot_kaydet_sil(sModel)
        End If
        If status = False Then
            Me.Close()
        End If
    End Sub
    Private Sub stok_notlari()
        Dim frm As New frm_stok_kart_aciklama
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sModel = sModel
        frm.sKodu = sKodu
        frm.nStokID = nStokID
        frm.kullanici = kullanici
        frm.lbl_Aciklama.Text = txt_sAdi.Text
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub tbRenkler()
        Dim frm As New frm_tbRenk
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub tbBedenler()
        Dim frm As New frm_tbBedenTipi
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub tbRenk()
        Dim frm As New frm_tbRenk
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.kriter = " AND (sRenk NOT IN (SELECT DISTINCT sRenk FROM tbStok WHERE sModel = N'" & sModel & "'))"
        If yetki_kontrol(kullanici, frm.Name) = True Then
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                dataload_tbBeden(sModel)
                dataload_tbKavala(sModel)
                Dim s As String
                Dim arr As Integer()
                Dim i As Integer
                Dim dr As DataRow
                dr = ds_tbStok.Tables(0).Rows(0)
                Dim dr1 As DataRow
                Dim dr2 As DataRow
                Dim dr3 As DataRow
                arr = frm.GridView1.GetSelectedRows()
                If arr Is Nothing Then
                Else
                    Array.Sort(arr)
                    For Each i In arr
                        s = i.ToString
                        dr = ds_tbStok.Tables(0).Rows(0)
                        dr1 = frm.GridView1.GetDataRow(s)
                        For Each dr2 In ds_tbBeden.Tables(0).Rows
                            For Each dr3 In ds_tbKavala.Tables(0).Rows
                                tbStok_Renk_ekle(Trim(sModel) & dr1("sRenk") & dr2("sBeden") & dr3("sKavala"), dr("sAciklama"), dr("sKisaAdi"), dr("nStokTipi"), dr("sBedenTipi").ToString, dr("sKavalaTipi").ToString, dr1("sRenk"), dr2("sBeden").ToString, dr3("sKavala").ToString, dr("sBirimCinsi1"), dr("sBirimCinsi2"), dr("nIskontoYuzdesi"), dr("sKdvTipi"), dr("nTeminSuresi"), dr("lAsgariMiktar"), dr("lAzamiMiktar"), dr("sOzelNot"), dr("nFiyatlandirma"), sModel, dr("sKullaniciAdi"), Now, dr("bEksiyeDusulebilirmi"), dr("sDefaultAsortiTipi"), dr("bEksideUyarsinmi"), dr("bOTVVar"), dr("sOTVTipi"), dr("nIskontoYuzdesiAV"), dr("bEk1"), dr("nEk2"))
                            Next
                        Next
                    Next
                End If
                s = Nothing
                arr = Nothing
                i = Nothing
                dr = Nothing
                dr1 = Nothing
                dr2 = Nothing
            End If
        End If
        kaydet_tumu(True)
        dataload(sModel)
    End Sub
    Private Sub tbRenk_kaldir()
        Dim frm As New frm_tbRenk
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.kriter = " Where (sRenk IN (SELECT DISTINCT sRenk FROM tbStok WHERE sModel = N'" & sModel & "'))"
        frm.islemstatus = True
        If yetki_kontrol(kullanici, frm.Name) = True Then
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                dataload_tbBeden(sModel)
                dataload_tbKavala(sModel)
                Dim s As String
                Dim arr As Integer()
                Dim i As Integer
                Dim dr As DataRow
                dr = ds_tbStok.Tables(0).Rows(0)
                Dim dr1 As DataRow
                Dim dr2 As DataRow
                Dim dr3 As DataRow
                arr = frm.GridView1.GetSelectedRows()
                If arr Is Nothing Then
                Else
                    Array.Sort(arr)
                    For Each i In arr
                        s = i.ToString
                        dr = ds_tbStok.Tables(0).Rows(0)
                        dr1 = frm.GridView1.GetDataRow(s)
                        For Each dr2 In ds_tbBeden.Tables(0).Rows
                            For Each dr3 In ds_tbKavala.Tables(0).Rows
                                tbStok_Renk_sil(sModel, Trim(sModel) & Trim(dr1("sRenk")) & Trim(dr2("sBeden")) & Trim(dr3("sKavala")))
                            Next
                        Next
                    Next
                End If
                s = Nothing
                arr = Nothing
                i = Nothing
                dr = Nothing
                dr1 = Nothing
                dr2 = Nothing
            End If
        End If
        kaydet_tumu(True)
        dataload(sModel)
    End Sub
    Private Sub tbBeden()
        Dim frm As New frm_tbBeden
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.kriter = " AND (sBeden NOT IN (SELECT DISTINCT sBeden FROM          tbStok WHERE      sModel = N'" & sModel & "'))"
        If yetki_kontrol(kullanici, frm.Name) = True Then
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                dataload_tbRenk(sModel)
                dataload_tbKavala(sModel)
                Dim s As String
                Dim arr As Integer()
                Dim i As Integer
                Dim dr As DataRow
                dr = ds_tbStok.Tables(0).Rows(0)
                Dim dr1 As DataRow
                Dim dr2 As DataRow
                Dim dr3 As DataRow
                arr = frm.GridView1.GetSelectedRows()
                If arr Is Nothing Then
                Else
                    Array.Sort(arr)
                    For Each i In arr
                        s = i.ToString
                        dr = ds_tbStok.Tables(0).Rows(0)
                        dr1 = frm.GridView1.GetDataRow(s)
                        For Each dr2 In ds_tbRenk.Tables(0).Rows
                            For Each dr3 In ds_tbKavala.Tables(0).Rows
                                If Trim(dr2("sRenk")) <> "" Then
                                    tbStok_Renk_ekle(Trim(sModel) & Trim(dr2("sRenk")) & Trim(dr1("sBeden")) & Trim(dr3("sKavala")), dr("sAciklama"), dr("sKisaAdi"), dr("nStokTipi"), dr("sBedenTipi").ToString, dr("sKavalaTipi").ToString, dr2("sRenk"), dr1("sBeden").ToString, dr3("sKavala").ToString, dr("sBirimCinsi1"), dr("sBirimCinsi2"), dr("nIskontoYuzdesi"), dr("sKdvTipi"), dr("nTeminSuresi"), dr("lAsgariMiktar"), dr("lAzamiMiktar"), dr("sOzelNot"), dr("nFiyatlandirma"), sModel, dr("sKullaniciAdi"), Now, dr("bEksiyeDusulebilirmi"), dr("sDefaultAsortiTipi"), dr("bEksideUyarsinmi"), dr("bOTVVar"), dr("sOTVTipi"), dr("nIskontoYuzdesiAV"), dr("bEk1"), dr("nEk2"))
                                End If
                            Next
                        Next
                    Next
                End If
                s = Nothing
                arr = Nothing
                i = Nothing
                dr = Nothing
                dr1 = Nothing
                dr2 = Nothing
            End If
        End If
        kaydet_tumu(True)
        dataload(sModel)
    End Sub
    Private Sub tbKavala()
        Dim frm As New frm_tbKavalaTipi
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.kriter = " AND (sKavala NOT IN (SELECT DISTINCT sKavala FROM          tbStok WHERE      sModel = N'" & sModel & "'))"
        If yetki_kontrol(kullanici, frm.Name) = True Then
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                dataload_tbRenk(sModel)
                dataload_tbBeden(sModel)
                Dim s As String
                Dim arr As Integer()
                Dim i As Integer
                Dim dr As DataRow
                dr = ds_tbStok.Tables(0).Rows(0)
                Dim dr1 As DataRow
                Dim dr2 As DataRow
                Dim dr3 As DataRow
                arr = frm.GridView1.GetSelectedRows()
                If arr Is Nothing Then
                Else
                    Array.Sort(arr)
                    For Each i In arr
                        s = i.ToString
                        dr = ds_tbStok.Tables(0).Rows(0)
                        dr1 = frm.GridView1.GetDataRow(s)
                        For Each dr2 In ds_tbRenk.Tables(0).Rows
                            For Each dr3 In ds_tbBeden.Tables(0).Rows
                                If Trim(dr3("sBeden")) <> "" Then
                                    tbStok_Renk_ekle(Trim(sModel) & dr2("sRenk") & dr3("sBeden") & dr1("sKavala"), dr("sAciklama"), dr("sKisaAdi"), dr("nStokTipi"), dr("sBedenTipi").ToString, dr("sKavalaTipi").ToString, dr2("sRenk"), dr3("sBeden").ToString, dr1("sKavala").ToString, dr("sBirimCinsi1"), dr("sBirimCinsi2"), dr("nIskontoYuzdesi"), dr("sKdvTipi"), dr("nTeminSuresi"), dr("lAsgariMiktar"), dr("lAzamiMiktar"), dr("sOzelNot"), dr("nFiyatlandirma"), sModel, dr("sKullaniciAdi"), Now, dr("bEksiyeDusulebilirmi"), dr("sDefaultAsortiTipi"), dr("bEksideUyarsinmi"), dr("bOTVVar"), dr("sOTVTipi"), dr("nIskontoYuzdesiAV"), dr("bEk1"), dr("nEk2"))
                                End If
                            Next
                        Next
                    Next
                End If
                s = Nothing
                arr = Nothing
                i = Nothing
                dr = Nothing
                dr1 = Nothing
                dr2 = Nothing
            End If
        End If
        kaydet_tumu(True)
        dataload(sModel)
    End Sub
    Private Sub tbBeden_kaldir()
        Dim frm As New frm_tbBeden
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.kriter = " Where (sBeden IN (SELECT DISTINCT sBeden FROM          tbStok WHERE      sModel = N'" & sModel & "'))"
        frm.islemstatus = True
        If yetki_kontrol(kullanici, frm.Name) = True Then
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                dataload_tbRenk(sModel)
                Dim s As String
                Dim arr As Integer()
                Dim i As Integer
                Dim dr As DataRow
                dr = ds_tbStok.Tables(0).Rows(0)
                Dim dr1 As DataRow
                Dim dr2 As DataRow
                arr = frm.GridView1.GetSelectedRows()
                If arr Is Nothing Then
                Else
                    Array.Sort(arr)
                    For Each i In arr
                        s = i.ToString
                        dr = ds_tbStok.Tables(0).Rows(0)
                        dr1 = frm.GridView1.GetDataRow(s)
                        For Each dr2 In ds_tbRenk.Tables(0).Rows
                            tbStok_Renk_sil(sModel, Trim(sModel) & Trim(dr2("sRenk")) & Trim(dr1("sBeden")))
                        Next
                    Next
                End If
            End If
        End If
        kaydet_tumu(True)
        dataload(sModel)
    End Sub
    Private Sub tbKavala_kaldir()
        Dim frm As New frm_tbKavalaTipi
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.kriter = " Where (sKavala IN (SELECT DISTINCT sKavala FROM          tbStok WHERE      sModel = N'" & sModel & "'))"
        frm.islemstatus = True
        If yetki_kontrol(kullanici, frm.Name) = True Then
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                dataload_tbRenk(sModel)
                dataload_tbBeden(sModel)
                Dim s As String
                Dim arr As Integer()
                Dim i As Integer
                Dim dr As DataRow
                dr = ds_tbStok.Tables(0).Rows(0)
                Dim dr1 As DataRow
                Dim dr2 As DataRow
                Dim dr3 As DataRow
                arr = frm.GridView1.GetSelectedRows()
                If arr Is Nothing Then
                Else
                    Array.Sort(arr)
                    For Each i In arr
                        s = i.ToString
                        dr = ds_tbStok.Tables(0).Rows(0)
                        dr1 = frm.GridView1.GetDataRow(s)
                        For Each dr2 In ds_tbRenk.Tables(0).Rows
                            For Each dr3 In ds_tbBeden.Tables(0).Rows
                                tbStok_Renk_sil(sModel, Trim(sModel) & dr2("sRenk") & dr3("sBeden") & dr1("sKavala"))
                            Next
                        Next
                    Next
                End If
            End If
        End If
        kaydet_tumu(True)
        dataload(sModel)
    End Sub
    Private Sub RBKTamamla()
        If XtraMessageBox.Show(Sorgu_sDil("R/B/K Tanmlarnda Eksik Kodlar Tamamlamak stediinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            dataload_tbRenk(sModel)
            dataload_tbBeden(sModel)
            dataload_tbKavala(sModel)
            Dim dr As DataRow = ds_tbStok.Tables(0).Rows(0)
            Dim dr1 As DataRow
            Dim dr2 As DataRow
            Dim dr3 As DataRow
            For Each dr1 In ds_tbRenk.Tables(0).Rows
                dr = ds_tbStok.Tables(0).Rows(0)
                For Each dr2 In ds_tbBeden.Tables(0).Rows
                    For Each dr3 In ds_tbKavala.Tables(0).Rows
                        tbStok_Renk_ekle(Trim(sModel) & dr1("sRenk") & dr2("sBeden") & dr3("sKavala"), dr("sAciklama"), dr("sKisaAdi"), dr("nStokTipi"), dr("sBedenTipi").ToString, dr("sKavalaTipi").ToString, dr1("sRenk"), dr2("sBeden").ToString, dr3("sKavala").ToString, dr("sBirimCinsi1"), dr("sBirimCinsi2"), dr("nIskontoYuzdesi"), dr("sKdvTipi"), dr("nTeminSuresi"), dr("lAsgariMiktar"), dr("lAzamiMiktar"), dr("sOzelNot"), dr("nFiyatlandirma"), sModel, dr("sKullaniciAdi"), Now, dr("bEksiyeDusulebilirmi"), dr("sDefaultAsortiTipi"), dr("bEksideUyarsinmi"), dr("bOTVVar"), dr("sOTVTipi"), dr("nIskontoYuzdesiAV"), dr("bEk1"), dr("nEk2"), False)
                    Next
                Next
            Next
            dr = Nothing
            dr1 = Nothing
            dr2 = Nothing
            kaydet_tumu(True)
            dataload(sModel)
        End If
    End Sub
    Private Sub tbSinif(ByVal tablo As String)
        Dim fr As New frm_tbSinif
        fr.firmano = firmano
        fr.donemno = donemno
        fr.connection = connection
        fr.kullanici = kullanici
        fr.Table = tablo
        If yetki_kontrol(kullanici, fr.Name) = True Then
            fr.ShowDialog()
            Dataload_tbStokSinifi(sModel)
        End If
    End Sub
    Private Sub tbStokBirimCevrimi(ByVal sModel As String)
        Dim fr As New frm_tbStokBirimCevrimi
        fr.firmano = firmano
        fr.donemno = donemno
        fr.connection = connection
        fr.kullanici = kullanici
        fr.sModel = sModel
        If yetki_kontrol(kullanici, fr.Name) = True Then
            fr.ShowDialog()
            Dataload_tbStokSinifi(sModel)
        End If
    End Sub
    Public Function sorgu_tbStokBirimCevrimi_kontrol(ByVal sBirimCinsi As String, ByVal sModel As String) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(*) AS Sayi FROM         tbStokBirimCevrimi WHERE     (nStokID IN (SELECT     nStokID FROM tbStok WHERE sModel = N'" & sModel & "')) AND (sBirimCinsi = N'" & sBirimCinsi & "')")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Private Sub tbStokBirimCevrimi_kaydet_yeni(ByVal sBirimCinsi As String, ByVal lOran As Decimal, ByVal sModel As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Dim bTersOran As Integer = 0
        If sec_bTersOran.Checked = True Then
            bTersOran = 1
        Else
            bTersOran = 0
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokBirimCevrimi select nStokID , '" & sBirimCinsi & "' , " & lOran & ", " & bTersOran & " from tbStok where sModel = N'" & sModel & "' ")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED update tbStok set bEk1 =  " & bTersOran & "  from tbStok where nStokID = N'" & nStokID & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokBirimCevirimi_kaydet_sil(ByVal sModel As String, ByVal sBirimCinsi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED delete tbStokBirimCevrimi  where sBirimCinsi = N'" & sBirimCinsi & "' and  nStokID in ( select nStokID from tbStok where sModel = N'" & sModel & "' )")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStok_kopyala()
        Dim frm As New frm_stok_kart_kopyala
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.sModel = sModel
        frm.txt_EsKodu.EditValue = sModel
        frm.txt_EsKodu.Enabled = False
        frm.txt_sAdi.EditValue = txt_sAdi.Text
        frm.txt_sAdi.Enabled = False
        Dim dr As DataRow
        Dim sayi = 0
        For Each dr In ds_tbStokSinifi.Tables(0).Rows
            sayi += 1
            If sayi = 1 Then
                frm.sSinifKodu1 = dr("sSinifKodu").ToString
            ElseIf sayi = 2 Then
                frm.sSinifKodu2 = dr("sSinifKodu").ToString
            ElseIf sayi = 3 Then
                frm.sSinifKodu3 = dr("sSinifKodu").ToString
            ElseIf sayi = 4 Then
                frm.sSinifKodu4 = dr("sSinifKodu").ToString
            ElseIf sayi = 5 Then
                frm.sSinifKodu5 = dr("sSinifKodu").ToString
            ElseIf sayi = 6 Then
                frm.sSinifKodu6 = dr("sSinifKodu").ToString
            ElseIf sayi = 7 Then
                frm.sSinifKodu7 = dr("sSinifKodu").ToString
            ElseIf sayi = 8 Then
                frm.sSinifKodu8 = dr("sSinifKodu").ToString
            ElseIf sayi = 9 Then
                frm.sSinifKodu9 = dr("sSinifKodu").ToString
            ElseIf sayi = 10 Then
                frm.sSinifKodu10 = dr("sSinifKodu").ToString
            ElseIf sayi = 11 Then
                frm.sSinifKodu11 = dr("sSinifKodu").ToString
            ElseIf sayi = 12 Then
                frm.sSinifKodu12 = dr("sSinifKodu").ToString
            ElseIf sayi = 13 Then
                frm.sSinifKodu13 = dr("sSinifKodu").ToString
            ElseIf sayi = 14 Then
                frm.sSinifKodu14 = dr("sSinifKodu").ToString
            ElseIf sayi = 15 Then
                frm.sSinifKodu15 = dr("sSinifKodu").ToString
            End If
        Next
        sayi = Nothing
        dr = Nothing
        If yetki_kontrol(kullanici, frm.Name) = True Then
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                sModel = frm.sKodu
                txt_musteriNo.Text = sModel
                stok_kontrol()
            End If
        End If
    End Sub
    Private Sub analiz_stok_KarlilikAkisTablosu()
        Dim frm As New frm_Stok_Satis_Maliyetlendir
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.txt_sStokKodu.Text = sKodu
        frm.bAnaliz = True
        If yetki_kontrol(kullanici, "frm_Stok_KarlilikAkisTablosu") = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub analiz_envanter()
        If GridView1.RowCount > 0 Then
            Dim frm As New frm_stok_envanter
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.stokno = nStokID
            frm.stokkodu = sKodu
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_hareket_transfer()
        If GridView1.RowCount > 0 Then
            Dim frm As New frm_stok_hareketleri_transfer
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            'frm.stokno = dr("nStokId")
            frm.stokkodu = sKodu
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
        Dim frm As New frm_stok_hareketleri
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.musterino = sKodu
        frm.sModel = sModel
        frm.nFirmaID = 0
        frm.sec_firma.Checked = False
        frm.sec_giris.Text = "[Tm]"
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
        frm.Label1.Text = txt_sAdi.Text & vbCrLf & frm.Label1.Text
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub analiz_envanter_model()
        Dim frm As New frm_stok_envanter_model
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.modelno = sModel
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub stok_fiyat()
        Dim frm As New frm_stok_fiyatlandir
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.nStokID = nStokID
        frm.sModel = sModel
        frm.sKodu = sKodu
        frm.txt_musteriNo.Text = sModel
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub stok_yeni()
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
                sModel = frm.sModel
                dataload(sModel)
            End If
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Function sorgu_geri(ByVal query As String) As String
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = connection
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.CommandText = sorgu_query(query)
            Return cmd.ExecuteScalar.ToString()
            con.Close()
        Catch ex As Exception
        End Try
    End Function
    Private Function tbStok_Sil_Kontrol(ByVal sModel As String) As Boolean
        Dim degisen As String = ""
        Dim silinebilir As Boolean = False
        Dim yeniTarih As String = Now.Day & "." & Now.Month & "." & Now.Year
        Dim nStokIDSon As String = sorgu_geri("select nStokID from tbStok where sModel = '" & sModel & "'")
        Try
            degisen = sorgu_geri("set dateformat dmy select COUNT(*) from ASTOKETIKETTALEPBASLIK where (IND IN(select IND from ASTOKETIKETTALEPDETAY where STOKNO = " & nStokIDSon & ")) AND (TARIH <= '" & yeniTarih & "')")
            If degisen = 0 Then
                degisen = sorgu_geri("set dateformat dmy select COUNT(*) from ASTOKFIYATDEGISIMBASLIK where (IND IN (select IND from ASTOKFIYATDEGISIMDETAY where STOKNO = " & nStokIDSon & ")) AND (TARIH <= '" & yeniTarih & "')")
                If degisen = 0 Then
                    degisen = sorgu_geri("set dateformat dmy select COUNT(*) from ASTOKPAKETBASLIK where (FISNO IN (select FISNO from ASTOKPAKETDETAY where STOKNO = " & nStokIDSon & ")) AND (FISTARIHI <= '" & yeniTarih & "')")
                    If degisen = 0 Then
                        degisen = sorgu_geri("set dateformat dmy select COUNT(*) from tbSiparis where (nStokID = " & nStokIDSon & ") AND ((dteTeslimTarihi <= '" & yeniTarih & "') OR (dteSiparisTarihi <= '" & yeniTarih & "'))")
                        If degisen = 0 Then
                            degisen = sorgu_geri("set dateformat dmy select COUNT(*) from tbStokFisiDetayi where (nStokID = " & nStokIDSon & ") AND ((dteIslemTarihi <= '" & yeniTarih & "') OR (dteFisTarihi <= '" & yeniTarih & "'))")
                            If degisen = 0 Then
                                degisen = sorgu_geri("SELECT (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut FROM tbStok where nStokID = " & nStokIDSon & "")
                                If degisen = 0 Then
                                    silinebilir = True
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
        Return silinebilir
    End Function
    Private Sub tbStok_sil(ByVal sModel As String)
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
            If tbStok_Sil_Kontrol(sModel) = True Then
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
                cmd.CommandText = sorgu_query("delete tbStokOdemePlani from tbStok where tbStok.nStokID = tbStokOdemePlani.nStokID and sModel = N'" & sModel & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbStokSayim from tbStok where tbStok.nStokID = tbStokSayim.nStokID and sModel = N'" & sModel & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbStokDil from tbStok where tbStok.nStokID = tbStokDil.nStokID and sModel = N'" & sModel & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbStokAciklama from tbStok where tbStok.nStokID = tbStokAciklama.nStokID and sModel = N'" & sModel & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbStokUzunNot where sModel = N'" & sModel & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete from tbStokResim where sModel = N'" & sModel & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete from tbStokMuhasebeEntegrasyon where nStokID IN (Select nStokID from tbStok where sModel = N'" & sModel & "')")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete from tbKoliDagilimi where nStokID IN (Select nStokID from tbStok where sModel = N'" & sModel & "')")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbStok where sModel = N'" & sModel & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(sModel,'') as sModel FROM tbStok WHERE (sModel < '" & sModel & "') ORDER BY sModel DESC")
                sModel = cmd.ExecuteScalar
                txt_musteriNo.EditValue = sModel
                XtraMessageBox.Show(Sorgu_sDil("Model Kodu: " & sModel & " olan stok kayd baaryla silindi...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                stok_kontrol()
            Else
                XtraMessageBox.Show(Sorgu_sDil("Model Kodu: " & sModel & " olan stoa ait, " & vbCrLf & " Hareketler bulunmaktadr. Silemezsiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 ROLLBACK TRAN")
                cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Model Kodu: " & sModel & " olan stoa ait, " & vbCrLf & " Hareketler bulunmaktadr. Silemezsiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 ROLLBACK TRAN")
            cmd.ExecuteNonQuery()
        End Try
        con.Close()
    End Sub
    Private Sub tbStok_Renk_ekle(ByVal sKodu As String, ByVal sAciklama As String, ByVal sKisaAdi As String, ByVal nStokTipi As Int64, ByVal sBedenTipi As String, ByVal sKavalaTipi As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sKavala As String, ByVal sBirimCinsi1 As String, ByVal sBirimCinsi2 As String, ByVal nIskontoYuzdesi As Decimal, ByVal sKdvTipi As String, ByVal nTeminSuresi As Decimal, ByVal lAsgariMiktar As Decimal, ByVal lAzamiMiktar As Decimal, ByVal sOzelNot As String, ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bEksiyeDusulebilirmi As Byte, ByVal sDefaultAsortiTipi As String, ByVal bEksideUyarsinmi As Byte, ByVal bOTVVar As Byte, ByVal sOTVTipi As String, ByVal nIskontoYuzdesiAV As Decimal, ByVal bEk1 As Byte, ByVal nEk2 As String, Optional ByVal bUyari As Boolean = True)
        Dim sSinifKodu As String = ""
        Dim sSinifKodu1 As String = ""
        Dim sSinifKodu2 As String = ""
        Dim sSinifKodu3 As String = ""
        Dim sSinifKodu4 As String = ""
        Dim sSinifKodu5 As String = ""
        Dim sSinifKodu6 As String = ""
        Dim sSinifKodu7 As String = ""
        Dim sSinifKodu8 As String = ""
        Dim sSinifKodu9 As String = ""
        Dim sSinifKodu10 As String = ""
        Dim sSinifKodu11 As String = ""
        Dim sSinifKodu12 As String = ""
        Dim sSinifKodu13 As String = ""
        Dim sSinifKodu14 As String = ""
        Dim sSinifKodu15 As String = ""
        Dim dr As DataRow
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        sModel = Trim(sModel)
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStok (sKodu, sAciklama, sKisaAdi, nStokTipi, sBedenTipi, sKavalaTipi, sRenk, sBeden, sKavala, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi, nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, sModel, sKullaniciAdi, dteKayitTarihi, bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2) VALUES ('" & sKodu & "', N'" & sAciklama & "', '" & sKisaAdi & "', " & nStokTipi & ", '" & sBedenTipi & "', '" & sKavalaTipi & "', '" & sRenk & "', '" & sBeden & "', '" & sKavala & "', '" & sBirimCinsi1 & "', '" & sBirimCinsi1 & "', " & nIskontoYuzdesi & ", '" & sKdvTipi & "', " & nTeminSuresi & ", " & lAsgariMiktar & ", " & lAzamiMiktar & ", '" & sOzelNot & "', " & nFiyatlandirma & ", '" & sModel & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bEksiyeDusulebilirmi & ", '" & sDefaultAsortiTipi & "', " & bEksideUyarsinmi & ", " & bOTVVar & ", '" & sOTVTipi & "', " & nIskontoYuzdesiAV & ", " & bEk1 & ", " & nEk2 & ")")
            cmd.ExecuteNonQuery()
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
            nStokID = cmd.ExecuteScalar
            cmd.CommandText = sorgu_query("set transaction isolation level read uncommitted")
            cmd.ExecuteNonQuery()
            If nFiyatlandirma = 0 Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFiyati SELECT tbStok.nStokID, Fiyatlar.sFiyatTipi, Fiyatlar.lFiyat, Fiyatlar.dteFiyatTespitTarihi, '" & kullanici & "' AS Expr1, GETDATE() AS Expr2 FROM (SELECT DISTINCT sModel , (sFiyatTipi) AS sFiyatTipi , lFiyat , dteFiyatTespitTarihi FROM tbStokFiyati , tbStok WHERE tbStokFiyati.nStokID = tbStok.nStokID AND tbStok.sModel = N'" & sModel & "') Fiyatlar INNER JOIN tbStok ON Fiyatlar.sModel = tbStok.sModel WHERE (NOT EXISTS (SELECT * FROM tbstokfiyati WHERE nStokID = tbStok.nStokID AND sFiyatTipi = Fiyatlar.sFiyatTipi))")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFiyati set dteKayitTarihi = getdate() where nStokID in ( select nStokID from tbStok where sModel = N'" & sModel & "' )")
                cmd.ExecuteNonQuery()
            ElseIf nFiyatlandirma = 1 Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFiyati SELECT tbStok.nStokID, Fiyatlar.sFiyatTipi, Fiyatlar.lFiyat, Fiyatlar.dteFiyatTespitTarihi, '" & kullanici & "' AS Expr1, GETDATE() AS Expr2 FROM (SELECT DISTINCT sModel , (sFiyatTipi) AS sFiyatTipi , lFiyat , dteFiyatTespitTarihi FROM tbStokFiyati , tbStok WHERE tbStokFiyati.nStokID = tbStok.nStokID AND tbStok.sModel = N'" & sModel & "' and tbStok.sRenk = N'" & sRenk & "' ) Fiyatlar INNER JOIN tbStok ON Fiyatlar.sModel = tbStok.sModel WHERE (NOT EXISTS (SELECT * FROM tbstokfiyati WHERE nStokID = tbStok.nStokID AND sFiyatTipi = Fiyatlar.sFiyatTipi))")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFiyati set dteKayitTarihi = getdate() where nStokID in ( select nStokID from tbStok where sModel = N'" & sModel & "' and sRenk = N'" & sRenk & "' )")
                cmd.ExecuteNonQuery()
            ElseIf nFiyatlandirma = 2 Then
            End If
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokAciklama SELECT tbStok.nStokID AS Expr1, b.* FROM tbStok CROSS JOIN (SELECT TOP 1 sAciklama1 , sAciklama2 , sAciklama3 , sAciklama4 , sAciklama5 , sAciklama6 , sAciklama7 , sAciklama8 , sAciklama9 , sAciklama10 FROM tbStokAciklama , tbStok WHERE tbStokAciklama.nStokID = tbStok.nStokID AND sModel = N'" & sModel & "') b WHERE (tbStok.sModel = N'" & sModel & "') AND (NOT EXISTS (SELECT * FROM tbStokAciklama WHERE nStokID = tbStok.nStokID))")
            cmd.ExecuteNonQuery()
            Dim sayi = 0
            For Each dr In ds_tbStokSinifi.Tables(0).Rows
                sayi += 1
                If sayi = 1 Then
                    sSinifKodu1 = dr("sSinifKodu").ToString
                ElseIf sayi = 2 Then
                    sSinifKodu2 = dr("sSinifKodu").ToString
                ElseIf sayi = 3 Then
                    sSinifKodu3 = dr("sSinifKodu").ToString
                ElseIf sayi = 4 Then
                    sSinifKodu4 = dr("sSinifKodu").ToString
                ElseIf sayi = 5 Then
                    sSinifKodu5 = dr("sSinifKodu").ToString
                ElseIf sayi = 6 Then
                    sSinifKodu6 = dr("sSinifKodu").ToString
                ElseIf sayi = 7 Then
                    sSinifKodu7 = dr("sSinifKodu").ToString
                ElseIf sayi = 8 Then
                    sSinifKodu8 = dr("sSinifKodu").ToString
                ElseIf sayi = 9 Then
                    sSinifKodu9 = dr("sSinifKodu").ToString
                ElseIf sayi = 10 Then
                    sSinifKodu10 = dr("sSinifKodu").ToString
                ElseIf sayi = 11 Then
                    sSinifKodu11 = dr("sSinifKodu").ToString
                ElseIf sayi = 12 Then
                    sSinifKodu12 = dr("sSinifKodu").ToString
                ElseIf sayi = 13 Then
                    sSinifKodu13 = dr("sSinifKodu").ToString
                ElseIf sayi = 14 Then
                    sSinifKodu14 = dr("sSinifKodu").ToString
                ElseIf sayi = 15 Then
                    sSinifKodu15 = dr("sSinifKodu").ToString
                End If
            Next
            sayi = Nothing
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokSinifi select nStokID , '" & sSinifKodu1 & "' , '" & sSinifKodu2 & "' , '" & sSinifKodu3 & "' , '" & sSinifKodu4 & "' , '" & sSinifKodu5 & "' , '" & sSinifKodu6 & "' , '" & sSinifKodu7 & "' , '" & sSinifKodu8 & "' , '" & sSinifKodu9 & "' , '" & sSinifKodu10 & "' , '" & sSinifKodu11 & "' , '" & sSinifKodu12 & "' , '" & sSinifKodu13 & "' , '" & sSinifKodu14 & "' , '" & sSinifKodu15 & "', N'" & sModel & "' from tbStok where sModel = N'" & sModel & "' and not exists ( select nStokID from tbStokSinifi where tbStokSinifi.nStokID = tbStok.nStokID )")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokSinifi set sSinifKodu1 = N'" & sSinifKodu1 & "' , sSinifKodu2 = N'" & sSinifKodu2 & "' , sSinifKodu3 = N'" & sSinifKodu3 & "' , sSinifKodu4 = N'" & sSinifKodu4 & "' , sSinifKodu5 = N'" & sSinifKodu5 & "' , sSinifKodu6 = N'" & sSinifKodu6 & "' , sSinifKodu7 = N'" & sSinifKodu7 & "' , sSinifKodu8 = N'" & sSinifKodu8 & "' , sSinifKodu9 = N'" & sSinifKodu9 & "' , sSinifKodu10 = N'" & sSinifKodu10 & "' , sSinifKodu11 = N'" & sSinifKodu11 & "' , sSinifKodu12 = N'" & sSinifKodu12 & "' , sSinifKodu13 = N'" & sSinifKodu13 & "' , sSinifKodu14 = N'" & sSinifKodu14 & "' , sSinifKodu15 = N'" & sSinifKodu15 & "', sModel = N'" & sModel & "'   where nStokID in ( select nStokID from tbStok where sModel = N'" & sModel & "' )")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokMuhasebeEntegrasyon select nStokID , sSubeMagaza, nSubeMagazaHesapTipi, sHareketTipi, nHesapID       from (select distinct sModel,                sSubeMagaza , nSubeMagazaHesapTipi, sHareketTipi, nHesapID                From tbStokMuhasebeEntegrasyon, tbStok                Where tbStokMuhasebeEntegrasyon.nStokID = tbStok.nStokID                      and tbStok.sModel ='" & sModel & "') as Hesaplar ,             tbStok Where tbStok.sModel = Hesaplar.sModel      and not exists ( select * from tbStokMuhasebeEntegrasyon              Where nStokID = tbStok.nStokID                     and sSubeMagaza = Hesaplar.sSubeMagaza                     and nSubeMagazaHesapTipi = Hesaplar.nSubeMagazaHesapTipi                     and sHareketTipi = Hesaplar.sHareketTipi )")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("set implicit_transactions off ")
            cmd.ExecuteNonQuery()
            'MsgBox(Sorgu_sDil("Kayt Baaryla Eklendi...",sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
        Catch ex As Exception
            If bUyari = True Then
                XtraMessageBox.Show(Sorgu_sDil("zgnm,leminiz Tamamlanamad...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 ROLLBACK TRAN")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("set implicit_transactions off ")
            cmd.ExecuteNonQuery()
        End Try
        con.Close()
        dr = Nothing
        sSinifKodu1 = Nothing
        sSinifKodu2 = Nothing
        sSinifKodu3 = Nothing
        sSinifKodu4 = Nothing
        sSinifKodu5 = Nothing
        sSinifKodu6 = Nothing
        sSinifKodu7 = Nothing
        sSinifKodu8 = Nothing
        sSinifKodu9 = Nothing
        sSinifKodu10 = Nothing
        sSinifKodu11 = Nothing
        sSinifKodu12 = Nothing
        sSinifKodu13 = Nothing
        sSinifKodu14 = Nothing
        sSinifKodu15 = Nothing
    End Sub
    Private Sub tbStok_Renk_sil(ByVal sModel As String, ByVal sKodu As String)
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
            cmd.CommandText = sorgu_query("delete tbStokSinifi from tbStok where tbStok.nStokID = tbStokSinifi.nStokID and sKodu = '" & Trim(sKodu) & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokBarkodu from tbStok where tbStok.nStokID = tbStokBarkodu.nStokID and sKodu = N'" & sKodu & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokFiyati from tbStok  where tbStok.nStokID = tbStokFiyati.nStokID and sKodu = N'" & sKodu & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokBirimCevrimi from tbStok where tbStok.nStokID = tbStokBirimCevrimi.nStokID and sKodu = N'" & sKodu & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokMuhasebeEntegrasyon from tbStok where tbStok.nStokID = tbStokMuhasebeEntegrasyon.nStokID and sKodu = N'" & sKodu & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokOdemePlani from tbStok  where tbStok.nStokID = tbStokOdemePlani.nStokID and sKodu = N'" & sKodu & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokSayim from tbStok where tbStok.nStokID = tbStokSayim.nStokID and sKodu = N'" & sKodu & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokDil from tbStok where tbStok.nStokID = tbStokDil.nStokID and sKodu = N'" & sKodu & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokAciklama from tbStok where tbStok.nStokID = tbStokAciklama.nStokID and sKodu = N'" & sKodu & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStok where sKodu = '" & sKodu & "'")
            cmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("delete tbStokUzunNot where sModel = N'" & sKodu & "'")
            'cmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("delete from tbStokResim where sModel = N'" & sKodu & "'")
            'cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("set implicit_transactions off ")
            cmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(sModel,'') as sModel FROM         tbStok WHERE     (sModel < '" & sModel & "' ) ORDER BY sModel DESC ")
            'sModel = cmd.ExecuteScalar
            'txt_musteriNo.EditValue = sModel
            'MsgBox(Sorgu_sDil("Kayt Baaryla Silindi...",sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("zgnm,Hareket Grm Kayd Silemezsiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 ROLLBACK TRAN")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("set implicit_transactions off ")
            cmd.ExecuteNonQuery()
        End Try
        con.Close()
    End Sub
    Private Sub tbStokBarkodu_kaydet_duzelt(ByVal nStokID As Int64, ByVal sBarkod As String, ByVal nKisim As Int64, ByVal nFirmaID As Int64, ByVal sKarsiStokKodu As String, ByVal sKarsiStokAciklama As String, ByVal sBirimCinsi As String, ByVal lBirimMiktar As Decimal)
        Dim kayitsayisi As Integer = 1
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If lBirimMiktar < 0 Then
            lBirimMiktar = 0
        End If
        If lBirimMiktar = 0 Then
            sBirimCinsi = ""
        Else
            nKisim = 2
        End If
        'If Trim(sBarkod) <> "" Then
        '    If kayitsayisi = 0 Then
        '        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokBarkodu (nStokID, sBarkod, nKisim, nFirmaID, sKarsiStokKodu, sKarsiStokAciklama) VALUES     (" & nStokID & ", '" & sBarkod & "', " & nKisim & ", " & nFirmaID & ", '" & sKarsiStokKodu & "', '" & sKarsiStokAciklama & "')")
        '        cmd.ExecuteNonQuery()
        '    Else
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokBarkodu SET             nKisim = " & nKisim & ",sBirimCinsi = '" & sBirimCinsi & "',lBirimMiktar = " & lBirimMiktar & "   Where nStokID = " & nStokID & " AND sBarkod = N'" & sBarkod & "'")
        cmd.ExecuteNonQuery()
        '    End If
        'Else
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokBarkodu WHERE     (nStokID = " & nStokID & ") and nKisim =" & nKisim & " AND nFirmaID =" & nFirmaID & "")
        'kayitsayisi = cmd.ExecuteScalar
        'End If
        con.Close()
    End Sub
    Private Sub tbStokBarkod_kaydet_yeni(ByVal nStokID As Int64, ByVal sBarkod As String, ByVal nKisim As Int64, ByVal nFirmaID As Int64, ByVal sKarsiStokKodu As String, ByVal sKarsiStokAciklama As String, ByVal sBirimCinsi As String, ByVal lBirimMiktar As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokBarkodu (nStokID, sBarkod, nKisim, nFirmaID, sKarsiStokKodu, sKarsiStokAciklama,sBirimCinsi,lBirimMiktar) VALUES     (" & nStokID & ", '" & sBarkod & "', " & nKisim & ", " & nFirmaID & ", '" & sKarsiStokKodu & "', '" & sKarsiStokAciklama & "','" & sBirimCinsi & "'," & lBirimMiktar & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokBarkod_kaydet_sil(ByVal nStokID As Int64, ByVal sBarkod As String, ByVal nKisim As Int64, ByVal nFirmaID As Int64, ByVal sKarsiStokKodu As String, ByVal sKarsiStokAciklama As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokBarkodu WHERE     (nStokID = " & nStokID & ") and sBarkod ='" & sBarkod & "' AND nKisim =" & nKisim & " AND nFirmaID =" & nFirmaID & " AND sKarsiStokKodu ='" & sKarsiStokKodu & "' and sKarsiStokAciklama ='" & sKarsiStokAciklama & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub analiz_bekleyen()
        Dim frm As New frm_satis_bekleyen_onaysiz
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.stokkodu = sKodu
        frm.tarih1 = "01/01/1900"
        frm.tarih2 = "31/12/2048"
        frm.qstokkodu = "Eittir"
        frm.islemstatus = True
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged

        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("Select nParametre1 From tbParamStok ")
        Dim eticaret = cmd.ExecuteScalar()
        con.Close()
        cmd.CommandText = ""
        If eticaret = 1 Then

            If GridView1.RowCount > 0 Then
                Dim satir = GridView1.FocusedRowHandle
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                GridView1.PostEditor()
                dr.EndEdit()
                Dim SinifNo As String = dr("sSinifNo")
                Dim Sinif As String = dr("sSinifKodu")
                If SinifNo = 7 Then
                    Dim ds_Sinif As DataSet = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbsSinif7 WHERE sSinifKodu = '" & Sinif & "'")
                    If ds_Sinif.Tables(0).Rows.Count > 0 Then
                        For Each dr1 As DataRow In ds_Sinif.Tables(0).Rows
                            Dim sSinifKodu7 As String = dr1("sSinifKodu")
                            tbStokSinifi_kaydet_duzelt1(sModel, dr1("sSinifKodu2"), dr1("sSinifKodu3"), dr1("sSinifKodu4"), dr1("sSinifKodu5"), dr1("sSinifKodu6"), sSinifKodu7, dr1("sSinifKodu"))
                        Next
                        Dataload_tbStokSinifi(sModel)
                        GridView1.FocusedRowHandle = satir
                    End If
                ElseIf SinifNo = 6 Then
                    ds_Sinif = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbsSinif6 WHERE sSinifKodu = '" & Sinif & "'")
                    If ds_Sinif.Tables(0).Rows.Count > 0 Then
                        For Each dr1 As DataRow In ds_Sinif.Tables(0).Rows
                            Dim sSinifKodu6 As String = dr1("sSinifKodu")
                            tbStokSinifi_kaydet_duzelt1(sModel, dr1("sSinifKodu2"), dr1("sSinifKodu3"), dr1("sSinifKodu4"), dr1("sSinifKodu5"), sSinifKodu6, dr1("sSinifKodu7"), dr1("sSinifKodu"))
                        Next
                        Dataload_tbStokSinifi(sModel)
                        GridView1.FocusedRowHandle = satir
                    End If
                ElseIf SinifNo = 5 Then
                    ds_Sinif = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbsSinif5 WHERE sSinifKodu = '" & Sinif & "'")
                    If ds_Sinif.Tables(0).Rows.Count > 0 Then
                        For Each dr1 As DataRow In ds_Sinif.Tables(0).Rows
                            Dim sSinifKodu5 As String = dr1("sSinifKodu")
                            tbStokSinifi_kaydet_duzelt1(sModel, dr1("sSinifKodu2"), dr1("sSinifKodu3"), dr1("sSinifKodu4"), sSinifKodu5, dr1("sSinifKodu6"), dr1("sSinifKodu7"), dr1("sSinifKodu"))
                        Next
                        Dataload_tbStokSinifi(sModel)
                        GridView1.FocusedRowHandle = satir
                    End If
                ElseIf SinifNo = 4 Then
                    ds_Sinif = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbsSinif4 WHERE sSinifKodu = '" & Sinif & "'")
                    If ds_Sinif.Tables(0).Rows.Count > 0 Then
                        For Each dr1 As DataRow In ds_Sinif.Tables(0).Rows
                            Dim sSinifKodu4 As String = dr1("sSinifKodu")
                            tbStokSinifi_kaydet_duzelt1(sModel, dr1("sSinifKodu2"), dr1("sSinifKodu3"), sSinifKodu4, dr1("sSinifKodu5"), dr1("sSinifKodu6"), dr1("sSinifKodu7"), dr1("sSinifKodu"))
                        Next
                        Dataload_tbStokSinifi(sModel)
                        GridView1.FocusedRowHandle = satir
                    End If
                ElseIf SinifNo = 3 Then
                    ds_Sinif = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbsSinif3 WHERE sSinifKodu = '" & Sinif & "'")
                    If ds_Sinif.Tables(0).Rows.Count > 0 Then
                        For Each dr1 As DataRow In ds_Sinif.Tables(0).Rows
                            Dim sSinifKodu3 As String = dr1("sSinifKodu")
                            tbStokSinifi_kaydet_duzelt1(sModel, dr1("sSinifKodu2"), sSinifKodu3, dr1("sSinifKodu4"), dr1("sSinifKodu5"), dr1("sSinifKodu6"), dr1("sSinifKodu7"), dr1("sSinifKodu"))
                        Next
                        Dataload_tbStokSinifi(sModel)
                        GridView1.FocusedRowHandle = satir
                    End If
                ElseIf SinifNo = 2 Then
                    ds_Sinif = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbsSinif2 WHERE sSinifKodu = '" & Sinif & "'")
                    If ds_Sinif.Tables(0).Rows.Count > 0 Then
                        For Each dr1 As DataRow In ds_Sinif.Tables(0).Rows
                            Dim sSinifKodu2 As String = dr1("sSinifKodu")
                            tbStokSinifi_kaydet_duzelt1(sModel, sSinifKodu2, "", "", "", "", "", dr1("sSinifKodu"))
                        Next
                        Dataload_tbStokSinifi(sModel)
                        GridView1.FocusedRowHandle = satir
                    End If
                End If


            End If




        Else
            If GridView1.RowCount > 0 Then
                Dim satir = GridView1.FocusedRowHandle
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                GridView1.PostEditor()
                dr.EndEdit()
                tbStokSinifi_kaydet_duzelt(sModel, dr("sSinifKodu"), dr("sSinifNo"))
                Dataload_tbStokSinifi(sModel)
                GridView1.FocusedRowHandle = satir
                dr = Nothing
                satir = Nothing
            End If
        End If
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Try
                dataload_tbSSinif(dr("sSinifNo"))
            Catch ex As Exception
            End Try
            dr = Nothing
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        ds_tbStokAyYekunleri = Dataload_tbStokAyYekunleri(sModel)
        GridControl2.DataSource = ds_tbStokAyYekunleri.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        gorunum_yazdir_rbk()
    End Sub
    Private Sub gorunum_yazdir_rbk()
        printlink2.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        kaydet_tumu()
    End Sub
    Private Sub XtraTabControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles XtraTabControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Stok Kart Ekrann Kapatmak stediinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            txt_sAdi.Focus()
            txt_sAdi.SelectAll()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            GridControl1.Focus()
            GridControl1.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 2 Then
            ds_tbStokAyYekunleri = Dataload_tbStokAyYekunleri(sModel)
            GridControl2.DataSource = ds_tbStokAyYekunleri.Tables(0)
            GridControl2.DataMember = Nothing
            GridControl2.Focus()
            GridControl2.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 3 Then
            GridControl3.BestFit(fieldnMevcut)
            GridControl3.BestFit(fieldsBeden)
            GridControl3.BestFit(fieldsBeden)
            GridControl3.Focus()
            GridControl3.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 4 Then
            GridControl4.Focus()
            GridControl4.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 5 Then
            txt_sUzunNot.Focus()
            txt_sUzunNot.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 7 Then
            GridControl5.Select()
            GridControl5.Focus()
            GridView5.Focus()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 8 Then
            ds_tbStokAlternatif = Dataload_tbStokAlternatif(sModel)
            GridControl7.DataSource = ds_tbStokAlternatif.Tables(0)
            GridControl7.DataMember = Nothing
            GridControl7.Focus()
            GridControl7.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 9 Then
            ds_tbStokMuhasebeEntegrasyon = Dataload_tbStokMuhasebeEntegrasyon(sModel)
            GridControl8.DataSource = ds_tbStokMuhasebeEntegrasyon.Tables(0)
            GridControl8.DataMember = Nothing
            GridControl8.Focus()
            GridControl8.Select()
        End If
    End Sub
    Private Sub txt_OTVvar_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_OTVvar.CheckStateChanged
        If txt_OTVvar.Checked = True Then
            txt_sOTVtipi.Properties.ReadOnly = False
        Else
            txt_sOTVtipi.Properties.ReadOnly = True
            txt_sOTVtipi.EditValue = ""
        End If
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        Me.Close()
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        kaydet_tumu()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        analiz_envanter()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        analiz_envanter_model()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        stok_fiyat()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        analiz_bekleyen()
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        analiz_hareket_transfer()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stok_notlari()
    End Sub
    Private Sub GrnmYazdrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrnmYazdrToolStripMenuItem.Click
        printlink3.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub BarkodAtaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarkodAtaToolStripMenuItem.Click
        barkod_ata(0)
    End Sub
    Private Sub barkod_ata(ByVal nIslem As Integer)
        Dim dr As DataRow = GridView3.GetDataRow(GridView3.FocusedRowHandle)
        Dim satir = GridView3.FocusedRowHandle
        tbStokBarkodu_kaydet_yeni(dr("sKodu"), nIslem)
        Dataload_tbStokBarkodu(sModel)
        GridView3.FocusedRowHandle = satir
        dr = Nothing
        satir = Nothing
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        stok_yeni()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        If XtraMessageBox.Show(Sorgu_sDil("Kayd Silmek stediinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            tbStok_sil(sModel)
        End If
    End Sub
    Private Sub txt_musteriNo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musteriNo.ButtonClick
        stok_sec()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        stok_sec()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        stok_notlari()
    End Sub
    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        tbRenk()
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        tbRenk()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        tbRenk_kaldir()
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        tbBeden()
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        tbBeden_kaldir()
    End Sub
    Private Sub GridView3_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView3.CellValueChanged
        barkod_duzelt()
    End Sub
    Private Sub barkod_duzelt()
        If GridView3.RowCount > 0 Then
            Dim satir = GridView3.FocusedRowHandle
            Dim dr As DataRow = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            GridView3.PostEditor()
            dr.EndEdit()
            If dr("lBirimMiktar") < 0 Then
                dr("lBirimMiktar") = 0
            End If
            If dr("lBirimMiktar") = 0 Then
                dr("sBirimCinsi") = ""
            Else
                dr("nKisim") = 2
            End If
            Try
                tbStokBarkodu_kaydet_duzelt(dr("StokID"), dr("sBarkod"), dr("nKisim"), dr("nFirmaID"), dr("sKarsiStokKodu"), dr("sKarsiStokAciklama"), dr("sBirimCinsi"), dr("lBirimMiktar"))
                If dr("nKisim") = 2 Then
                    If sorgu_sKoli_kontrol(dr("sBarkod")) = True Then
                        tbKoli_kaydet_yeni(dr("sBarkod"), dr("sAciklama"))
                        tbKoliDagilimi_kaydet_yeni(dr("sBarkod"), dr("nStokID"), 1, dr("sBirimCinsi"), dr("lBirimMiktar"), 0, "")
                    Else
                        tbKoliDagilimi_kaydet_duzelt(dr("sBarkod"), dr("nStokID"), 1, dr("sBirimCinsi"), dr("lBirimMiktar"), 0, "")
                    End If
                Else
                    If sorgu_sKoli_kontrol(dr("sBarkod")) = False Then
                        tbKoliDagilimi_kaydet_sil(dr("sBarkod"), dr("nStokID"))
                        tbKoli_kaydet_sil(dr("sBarkod"))
                    End If
                End If
            Catch ex As Exception
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                XtraMessageBox.Show(Sorgu_sDil("Kayt eride Var", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            Dataload_tbStokBarkodu(sModel)
            GridView3.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
            barkod_info()
        End If
    End Sub
    Public Function sorgu_sKoli_kontrol(ByVal sKoliKodu As String) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        sKoliKodu = Trim(sKoliKodu)
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sKoliKodu), 0) AS nKayit FROM         tbKoli WHERE     (sKoliKodu = '" & sKoliKodu & "') and sKoliKodu <>'' ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Private Sub barkod_ekle(ByVal nKisim As Integer)
        If GridView3.RowCount > 0 Then
            Dim satir = GridView3.FocusedRowHandle
            Dim dr As DataRow = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            GridView3.PostEditor()
            dr.EndEdit()
            Dim deger As String = ""
            deger = InputBox("Stok Barkodu", "Stok Barkodu", "").ToString
            Try
                If deger.ToString <> "" Then
                    tbStokBarkod_kaydet_yeni(dr("StokID"), deger, nKisim, 0, "", "", "", 0)
                End If
            Catch ex As Exception
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                XtraMessageBox.Show(Sorgu_sDil("Kayt eride Var", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            Dataload_tbStokBarkodu(sModel)
            GridView3.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
            barkod_info()
        End If
    End Sub
    Private Sub barkod_ekle_sModel(ByVal nKisim As Integer)
        If GridView3.RowCount > 0 Then
            Dim satir = GridView3.FocusedRowHandle
            Dim dr As DataRow = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            GridView3.PostEditor()
            dr.EndEdit()
            Dim deger As String = ""
            deger = txt_musteriNo.Text
            Try
                If deger.ToString <> "" Then
                    tbStokBarkod_kaydet_yeni(dr("StokID"), deger, nKisim, 0, "", "", "", 0)
                End If
            Catch ex As Exception
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                XtraMessageBox.Show(Sorgu_sDil("Kayt eride Var", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            Dataload_tbStokBarkodu(sModel)
            GridView3.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
            barkod_info()
        End If
    End Sub
    Private Sub barkod_sil()
        If GridView3.RowCount > 0 Then
            Dim satir = GridView3.FocusedRowHandle
            Dim dr As DataRow = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            GridView3.PostEditor()
            dr.EndEdit()
            Try
                tbStokBarkod_kaydet_sil(dr("nStokID"), dr("sBarkod"), dr("nKisim"), dr("nFirmaID"), dr("sKarsiStokKodu"), dr("sKarsiStokAciklama"))
                If dr("nKisim") = 2 Then
                    tbKoliDagilimi_kaydet_sil(dr("sBarkod"), dr("nStokID"))
                    tbKoli_kaydet_sil(dr("sBarkod"))
                End If
            Catch ex As Exception
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                XtraMessageBox.Show(Sorgu_sDil("lem Hatas", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            Dataload_tbStokBarkodu(sModel)
            GridView3.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
            barkod_info()
        End If
    End Sub
    Private Sub barkodu_kod_ata()
        If GridView3.RowCount > 0 Then
            Dim satir = GridView3.FocusedRowHandle
            Dim dr As DataRow = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            kod_degistir_ac(dr("sBarkod"))
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub barkod_info()
        If GridView3.RowCount > 0 Then
            Dim satir = GridView3.FocusedRowHandle
            Dim dr As DataRow = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            If Trim(dr("sBarkod").ToString) <> "" Then
                btn_BarkodAtaEan13.Enabled = False
                btn_BarkodAtaEan8.Enabled = False
                btn_BarkodAtaAna.Enabled = False
                btn_BarkodAtaModel.Enabled = False
            Else
                btn_BarkodAtaEan13.Enabled = True
                btn_BarkodAtaEan8.Enabled = True
                btn_BarkodAtaAna.Enabled = True
                btn_BarkodAtaModel.Enabled = True
            End If
        End If
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        tbSinif("tbSSinif")
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        tbStok_kopyala()
    End Sub
    Private Sub sec_Siniflar_BeforeShowMenu(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BeforeShowMenuEventArgs) Handles sec_Siniflar.BeforeShowMenu
        sec_Siniflar.View.ClearColumnsFilter()
    End Sub
    Private Sub sec_Siniflar_QueryCloseUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_Siniflar.QueryCloseUp
        sec_Siniflar.View.ClearColumnsFilter()
    End Sub
    Private Sub sec_Siniflar_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_Siniflar.QueryPopUp
        sec_Siniflar.View.ClearColumnsFilter()
    End Sub
    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        tbStokBirimCevrimi(sModel)
    End Sub
    Private Sub BarkodAtaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarkodAtaToolStripMenuItem1.Click
        barkod_ata(1)
    End Sub
    Private Sub btn_ekle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stok_yeni()
    End Sub
    Private Sub btn_kopyala_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbStok_kopyala()
    End Sub
    Private Sub btn_sil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If XtraMessageBox.Show(Sorgu_sDil("Kayd Silmek stediinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            tbStok_sil(sModel)
        End If
    End Sub
    Private Sub btn_birim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbStokBirimCevrimi(sModel)
    End Sub
    Private Sub btn_fiyatlandir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stok_fiyat()
    End Sub
    Private Sub btn_aciklama_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        stok_notlari()
    End Sub
    Private Sub btn_renk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbRenk()
    End Sub
    Private Sub btn_envanter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_envanter()
    End Sub
    Private Sub btn_hareket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_stok_hareket()
    End Sub
    Private Sub btn_transfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_hareket_transfer()
    End Sub
    Private Sub btn_siniflandirmalar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbSinif("tbSSinif")
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbStok_KodDegistir()
    End Sub
    Private Sub tbStok_KodDegistir()
        Dim deger As String
        deger = InputBox("Yeni Stok Kodu", "Stok Kodu", "").ToString
        If deger.ToString <> "" Then
            tbStokKod_kaydet_duzelt(sModel, deger)
            sModel = deger
            txt_musteriNo.EditValue = sModel
            dataload(deger)
        End If
    End Sub
    Private Function carino_bul(ByVal sModel As String, ByVal kriter As String, ByVal kriter2 As String) As String
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(sModel,'0') AS sModel  FROM tbStok WHERE nStokTipi <> 5 AND sModel " & kriter & " '" & sModel & "' ORDER BY sModel " & kriter2 & "")
        Dim kayitno As String = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Private Sub sonraki_kart()
        Dim sNo As String = ""
        sNo = carino_bul(sModel, ">", "ASC")
        If sNo <> "" Then
            txt_musteriNo.Text = sNo
            sModel = sNo
            dataload(sModel)
        End If
        sNo = Nothing
    End Sub
    Private Sub onceki_kart()
        Dim sNo As String = ""
        sNo = carino_bul(sModel, "<", "DESC")
        If sNo <> "" Then
            txt_musteriNo.Text = sNo
            sModel = sNo
            dataload(sModel)
        End If
        sNo = Nothing
    End Sub
    Private Sub son_kart()
        Dim sNo As String = ""
        sNo = carino_bul(sModel, ">", "DESC")
        If sNo <> "" Then
            txt_musteriNo.Text = sNo
            sModel = sNo
            dataload(sModel)
        End If
        sNo = Nothing
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        onceki_kart()
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        sonraki_kart()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        stok_yeni()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        tbStok_kopyala()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Kayd Silmek stediinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            tbStok_sil(sModel)
        End If
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        kod_degistir_ac(sModel)
    End Sub
    Private Sub kod_degistir_ac(ByVal sModel As String)
        XtraTabControl1.SelectedTabPageIndex = 0
        GroupControl6.Visible = True
        txt_sYeniKod.Text = sModel
        txt_sYeniKod.Focus()
        txt_sYeniKod.SelectAll()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        tbStokBirimCevrimi(sModel)
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        stok_fiyat()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        stok_notlari()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        analiz_hareket_transfer()
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        tbSinif("tbSSinif")
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        tbRenkler()
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        tbBedenler()
    End Sub
    Private Sub BarButtonItem14_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        Me.Close()
    End Sub
    Private Sub SimpleButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BarkodAtaEan13.Click
        barkod_ata(0)
    End Sub
    Private Sub SimpleButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BarkodAtaEan8.Click
        barkod_ata(1)
    End Sub
    Private Sub SimpleButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BarkoduSil.Click
        barkod_sil()
    End Sub
    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BarkodAtaAna.Click
        barkod_ekle(0)
    End Sub
    Private Sub btn_BarkodAtaMuadil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BarkodAtaMuadil.Click
        barkod_ekle(1)
    End Sub
    Private Sub GridView3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView3.Click
        barkod_info()
    End Sub
    Private Sub GridView3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView3.GotFocus
        barkod_info()
    End Sub
    Private Sub SimpleButton3_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        printlink3.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub GridView4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView4.KeyDown
        If e.KeyCode = Keys.F4 Then
            analiz_fis()
        ElseIf e.KeyCode = Keys.Enter Then
            analiz_fis()
        End If
    End Sub
    Private Sub analiz_fis()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView4.GetDataRow(GridView4.FocusedRowHandle)
            If Trim(dr("nAlisVerisID").ToString) <> "" Then
                stok_satis_detay()
            ElseIf Trim(dr("nStokFisiID").ToString) <> "" Then
                fis_duzelt()
            End If
        End If
    End Sub
    Private Sub stok_satis_detay()
        Dim frm As New frm_Perakende_Satis
        Dim dr As DataRow
        dr = GridView4.GetDataRow(GridView4.FocusedRowHandle)
        frm.status = True
        frm.firmano = 100
        frm.donemno = 1
        frm.connection = connection
        frm.islemstatus = True
        frm.nAlisVerisID = dr("nAlisVerisID").ToString
        frm.sFisTipi = Trim(dr("sFisTipi").ToString)
        frm.kullanici = kullanici
        frm.sMagaza = dr("sDepo")
        Dim satir = GridView1.FocusedRowHandle
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
        dr = Nothing
        'dataload()
        GridView4.FocusedRowHandle = satir
        satir = Nothing
    End Sub
    Private Sub fis_duzelt()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView4.GetDataRow(GridView4.FocusedRowHandle)
            Dim frm As New frm_fatura
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.lFisNo = dr("lFisNo")
            frm.dteFisTarihi = dr("dteFisTarihi")
            frm.sFisTipi = dr("sFisTipi")
            frm.nFirmaID = dr("nFirmaID")
            frm.nGirisCikis = dr("nGirisCikis")
            frm.nStokFisiID = dr("nStokFisiID")
            frm.nIslemID = dr("nIslemID")
            frm.kullanici = kullanici
            Dim satir = GridView4.FocusedRowHandle
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm = Nothing
            dr = Nothing
            dataload(sModel)
            GridView4.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub GridControl5_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl5.DoubleClick
        analiz_fis()
    End Sub
    Private Sub SimpleButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton11.Click
        tbRenk()
    End Sub
    Private Sub SimpleButton7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        tbRenk_kaldir()
    End Sub
    Private Sub SimpleButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton10.Click
        tbBeden()
    End Sub
    Private Sub SimpleButton8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton8.Click
        tbBeden_kaldir()
    End Sub
    Private Sub SimpleButton4_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        gorunum_yazdir_rbk()
    End Sub

    ' ===== HELPER: tbRenk'ten Renk Adını al (sRenk kodu → sRenkAdi) =====
    Private Function GetRenkAdiFromCode(sRenkKodu As String) As String
        If String.IsNullOrEmpty(sRenkKodu) Then Return ""
        Try
            Using con As New OleDb.OleDbConnection(connection)
                Using cmd As New OleDb.OleDbCommand("SELECT sRenkAdi FROM tbRenk WHERE sRenk = ?", con)
                    cmd.Parameters.Add("p0", OleDb.OleDbType.VarChar, 50).Value = sRenkKodu
                    con.Open()
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        Return result.ToString().Trim()
                    End If
                End Using
            End Using
        Catch ex As Exception
            Debug.WriteLine($"[GetRenkAdiFromCode] Hata: {ex.Message}")
        End Try
        Return ""
    End Function
    
    'Resim Yeni Balang - UPDATED FOR tbStokResim TABLE
    Private Async Sub SimpleButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton12.Click
        If OpenFileDialog1.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        Dim sourcePath As String = OpenFileDialog1.FileName
        ' DÜZELTME: TextEdit3 değil, txt_musteriNo kullan (sModel burada)
        Dim sModel As String = Trim(txt_musteriNo.EditValue.ToString())
        
        ' ===== DOĞRU YÖNTEM: ds_tbStok dataset'inden al! =====
        Dim nStokID As Integer = Me.nStokID  ' OLDUĞU GİBİ KULLAN - NEGATİF BİLE OLSA!
        Dim sKodu As String = If(String.IsNullOrEmpty(Me.sKodu), "", Me.sKodu)
        Dim sRenk As String = ""
        Dim sRenkAdi As String = ""
        ' DÜZELTME: sBeden ve sKavala artık KULLANILMIYOR
        ' Resimler Model+Renk bazında, beden bazında değil
        
        ' Direkt tbStok tablosundan SADECE sRenk bilgisini çek (beden yok)
        Try
            Using con As New OleDb.OleDbConnection(connection)
                Using cmd As New OleDb.OleDbCommand(
                    "SELECT sRenk FROM tbStok WHERE nStokID = ?", con)
                    cmd.Parameters.Add("p0", OleDb.OleDbType.Integer).Value = nStokID
                    con.Open()
                    Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            sRenk = If(reader.IsDBNull(0) OrElse reader.GetValue(0) Is Nothing, "", reader.GetValue(0).ToString().Trim())
                            Debug.WriteLine($"[ResimEkle] ✓ tbStok'tan alındı: sRenk='{sRenk}' (beden kullanılmıyor)")
                            
                            ' sRenkAdi'yi tbRenk'ten çek
                            If Not String.IsNullOrEmpty(sRenk) Then
                                sRenkAdi = GetRenkAdiFromCode(sRenk)
                            End If
                        Else
                            Debug.WriteLine($"[ResimEkle] ✗ tbStok'ta nStokID={nStokID} için kayıt BULUNAMADI!")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Debug.WriteLine($"[ResimEkle] ✗ tbStok sorgu hatası: {ex.Message}")
            Debug.WriteLine($"[ResimEkle] ✗ Stack: {ex.StackTrace}")
        End Try
        
        Debug.WriteLine($"[ResimEkle] Form'dan: nStokID={nStokID}, sKodu={sKodu}, sModel={sModel}")
        
        If String.IsNullOrEmpty(sModel) Then
            XtraMessageBox.Show("Lütfen önce ürün seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        
        Debug.WriteLine($"[ResimEkle] ===== FINAL DEĞERLER (Model+Renk bazlı) =====")
        Debug.WriteLine($"[ResimEkle] sModel={sModel}, nStokID={nStokID} (referans), sRenk={sRenk}")
        Debug.WriteLine($"[ResimEkle] sBeden=NULL, sKavala=NULL (tüm bedenler için geçerli)")
        Debug.WriteLine($"[ResimEkle] ==========================")

        ' Resim slot'u al - MODEL+RENK bazlı (beden yok)
        Dim nSira As Integer = GetNextAvailableSlot_ModelRenk(Trim(sModel), sRenk)
        If nSira > 11 Then
            XtraMessageBox.Show("Bu renk için maksimum 11 resim eklenebilir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Resmi yükle ve byte array'e çevir
            Dim imageBytes As Byte()
            Using fs As New FileStream(sourcePath, FileMode.Open, FileAccess.Read)
                imageBytes = New Byte(fs.Length - 1) {}
                fs.Read(imageBytes, 0, imageBytes.Length)
            End Using

            ' R2'ye upload et
            ' Firma klasör adını al (REMOTE SERVER - BAYII database)
            Dim klasor As String = ""
            Try
                ' 1. LOCAL DB'den Server IP'sini al
                Dim sourceIP As String = ""
                Using conLocal As New OleDb.OleDbConnection(connection)
                    conLocal.Open()
                    Using cmdSource As New OleDb.OleDbCommand(
                        "SELECT TOP 1 Lisans FROM tbParamGenel", conLocal)
                        Dim result As Object = cmdSource.ExecuteScalar()
                        If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                            sourceIP = result.ToString().Trim()
                        End If
                    End Using
                End Using
                
                ' Default IP
                If String.IsNullOrEmpty(sourceIP) Then
                    sourceIP = "212.156.206.214"
                End If
                
                ' 2. Registry'den sOnayKodu al
                Dim sOnayKodu As String = ""
                Try
                    sOnayKodu = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("Key").GetValue("sOnayKodu").ToString()
                Catch
                    sOnayKodu = ""
                End Try
                
                ' 3. REMOTE SERVER'a bağlan ve sOzelNot al
                If Not String.IsNullOrEmpty(sOnayKodu) AndAlso sOnayKodu <> "0" Then
                    Dim remoteConnectionString As String = String.Format(
                        "Provider=SQLOLEDB.1;Password=87918991;Persist Security Info=True;User ID=bayii1;Initial Catalog=BAYII;Data Source={0},8991",
                        sourceIP)
                    
                    Try
                        Using conRemote As New OleDb.OleDbConnection(remoteConnectionString)
                            conRemote.Open()
                            Using cmdKlasor As New OleDb.OleDbCommand(
                                "SELECT TOP 1 tbFirma.sOzelNot " &
                                "FROM tbFirmaLisans " &
                                "INNER JOIN tbFirma ON tbFirmaLisans.nFirmaID = tbFirma.nFirmaID " &
                                "WHERE tbFirmaLisans.sOnayKodu = ?", conRemote)
                                cmdKlasor.Parameters.Add("sOnayKodu", OleDb.OleDbType.VarChar, 50).Value = sOnayKodu
                                
                                Dim result As Object = cmdKlasor.ExecuteScalar()
                                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                                    klasor = result.ToString().Trim()
                                End If
                            End Using
                        End Using
                    Catch ex As Exception
                        ' Remote server'a bağlanamazsa boş kalır
                        klasor = ""
                    End Try
                End If
            Catch ex As Exception
                klasor = ""
            End Try
            
            ' R2'ye upload et - DOSYA ADI: sModel_sRenk_nSira.jpg (beden yok)
            Dim fileNameParts As New List(Of String) From {sModel.Trim()}
            If Not String.IsNullOrEmpty(sRenk) Then fileNameParts.Add(sRenk.Trim())
            ' DÜZELTME: sBeden ve sKavala EKLENMEYECEK - tüm bedenler için geçerli
            fileNameParts.Add(nSira.ToString())
            
            Dim fileName As String = String.Join("_", fileNameParts) & ".jpg"
            Dim objectKey As String = If(String.IsNullOrEmpty(klasor),
                "products/" & sModel.Trim() & "/" & fileName,
                "products/" & klasor & "/" & sModel.Trim() & "/" & fileName)
            
            Debug.WriteLine($"[ResimEkle] R2 dosya adı: {fileName}, Object key: {objectKey}")
            Dim uploadedUrl As String = Await R2Helpers.R2UploadFromBytesAsync(imageBytes, objectKey, "image/jpeg")

            ' Base64 encode
            Dim base64String As String = Convert.ToBase64String(imageBytes)
            Debug.WriteLine($"[ResimEkle] Base64 boyutu: {base64String.Length} karakter, Image boyutu: {imageBytes.Length} bytes")
            
            ' UYARI: SQL Server VarChar(MAX) için base64 çok büyükse hata verebilir
            If base64String.Length > 2000000 Then ' 2MB limit
                Debug.WriteLine($"[ResimEkle] UYARI: Base64 çok büyük ({base64String.Length} karakter)")
            End If

            ' Database'e kaydet
            Using con As New OleDb.OleDbConnection(connection)
                con.Open()
                
                ' ÖNEMLİ: Tüm transaction state'ini temizle
                Try
                    Using cmdClean As New OleDb.OleDbCommand("IF @@TRANCOUNT > 0 ROLLBACK TRAN; SET IMPLICIT_TRANSACTIONS OFF", con)
                        cmdClean.ExecuteNonQuery()
                        Debug.WriteLine("[ResimEkle] Transaction state temizlendi")
                    End Using
                Catch ex As Exception
                    Debug.WriteLine($"[ResimEkle] Temizleme hatası (görmezden gel): {ex.Message}")
                End Try
                
                ' EXPLICIT Transaction başlat
                Using cmdBegin As New OleDb.OleDbCommand("BEGIN TRAN", con)
                    cmdBegin.ExecuteNonQuery()
                    Debug.WriteLine("[ResimEkle] BEGIN TRAN ✓")
                End Using
                
                Try
                    ' Bu nSira'da zaten resim var mı kontrol et - MODEL+RENK+nSira (beden yok)
                    Dim existingId As Object = Nothing
                    Using cmdCheck As New OleDb.OleDbCommand(
                        "SELECT nStokResimID FROM tbStokResim WHERE sModel = ? AND ISNULL(sRenk,'') = ISNULL(?,'') AND nSira = ? AND (sBeden IS NULL OR sBeden = '')", con)
                        cmdCheck.Parameters.Add("p0", OleDb.OleDbType.VarChar, 50).Value = sModel
                        cmdCheck.Parameters.Add("p1", OleDb.OleDbType.VarChar, 10).Value = If(String.IsNullOrEmpty(sRenk), "", sRenk)
                        cmdCheck.Parameters.Add("p2", OleDb.OleDbType.Integer).Value = nSira
                        existingId = cmdCheck.ExecuteScalar()
                    End Using
                    
                    Debug.WriteLine($"[ResimEkle] sModel={sModel}, sRenk={sRenk}, nSira={nSira}, ExistingID={If(existingId, "NULL")}")

                    If existingId Is Nothing Then
                        ' Yeni satır ekle (INSERT) - Model+Renk bazlı (sBeden NULL)
                        Using cmd As OleDb.OleDbCommand = con.CreateCommand()
                            cmd.CommandText = "INSERT INTO tbStokResim (sModel, nStokID, sRenk, sBeden, sKavala, nSira, pResim, yol, sAciklama, sKullaniciAdi, dteKayitTarihi) " &
                                             "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
                            cmd.Parameters.Add("sModel", OleDb.OleDbType.VarChar, 50).Value = sModel
                            cmd.Parameters.Add("nStokID", OleDb.OleDbType.Integer).Value = If(nStokID = 0, DBNull.Value, CObj(nStokID)) ' Referans olarak sakla
                            cmd.Parameters.Add("sRenk", OleDb.OleDbType.VarChar, 10).Value = If(String.IsNullOrEmpty(sRenk), DBNull.Value, CObj(sRenk))
                            cmd.Parameters.Add("sBeden", OleDb.OleDbType.VarChar, 10).Value = DBNull.Value ' BEDEN NULL - tüm bedenler için geçerli
                            cmd.Parameters.Add("sKavala", OleDb.OleDbType.VarChar, 10).Value = DBNull.Value
                            cmd.Parameters.Add("nSira", OleDb.OleDbType.Integer).Value = nSira
                            
                            ' DEBUG: Base64 string kontrol
                            Debug.WriteLine($"[ResimEkle] Base64 NULL mu? {If(base64String Is Nothing, "EVET!", "Hayır")}")
                            Debug.WriteLine($"[ResimEkle] Base64 boş mu? {If(String.IsNullOrEmpty(base64String), "EVET!", "Hayır")}")
                            Debug.WriteLine($"[ResimEkle] Base64 uzunluk: {If(base64String IsNot Nothing, base64String.Length, 0)}")
                            Debug.WriteLine($"[ResimEkle] İlk 50 karakter: {If(base64String?.Length > 50, base64String.Substring(0, 50), base64String)}")
                            
                            ' CRITICAL FIX: LongVarChar kullan (VARCHAR(MAX) için)
                            Dim pResimParam As New OleDb.OleDbParameter("pResim", OleDb.OleDbType.LongVarChar)
                            pResimParam.Value = If(String.IsNullOrEmpty(base64String), DBNull.Value, CObj(base64String))
                            cmd.Parameters.Add(pResimParam)
                            
                            Debug.WriteLine($"[ResimEkle] Parameter eklendi - IsNull: {TypeOf pResimParam.Value Is DBNull}")
                            
                            cmd.Parameters.Add("yol", OleDb.OleDbType.VarChar, 500).Value = uploadedUrl
                            cmd.Parameters.Add("sAciklama", OleDb.OleDbType.VarChar, 250).Value = ""
                            cmd.Parameters.Add("sKullaniciAdi", OleDb.OleDbType.VarChar, 50).Value = kullanici
                            cmd.Parameters.Add("dteKayitTarihi", OleDb.OleDbType.DBTimeStamp).Value = Now
                            
                            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                            Debug.WriteLine($"[ResimEkle] INSERT çalıştı → rowsAffected={rowsAffected}")
                            
                            If rowsAffected = 0 Then
                                Throw New Exception("INSERT başarısız - 0 satır etkilendi!")
                            End If
                        End Using
                    Else
                        ' Mevcut satırı güncelle (UPDATE) - Model+Renk bazlı
                        Using cmd As OleDb.OleDbCommand = con.CreateCommand()
                            cmd.CommandText = "UPDATE tbStokResim SET pResim = ?, yol = ?, sKullaniciAdi = ?, dteKayitTarihi = ? " &
                                             "WHERE sModel = ? AND ISNULL(sRenk,'') = ISNULL(?,'') AND nSira = ? AND (sBeden IS NULL OR sBeden = '')"
                            ' CRITICAL FIX: LongVarChar kullan (VARCHAR(MAX) için)
                            cmd.Parameters.Add("pResim", OleDb.OleDbType.LongVarChar).Value = base64String
                            cmd.Parameters.Add("yol", OleDb.OleDbType.VarChar, 500).Value = uploadedUrl
                            cmd.Parameters.Add("sKullaniciAdi", OleDb.OleDbType.VarChar, 50).Value = kullanici
                            cmd.Parameters.Add("dteKayitTarihi", OleDb.OleDbType.DBTimeStamp).Value = Now
                            cmd.Parameters.Add("sModel", OleDb.OleDbType.VarChar, 50).Value = sModel
                            cmd.Parameters.Add("sRenk", OleDb.OleDbType.VarChar, 10).Value = If(String.IsNullOrEmpty(sRenk), "", sRenk)
                            cmd.Parameters.Add("nSira", OleDb.OleDbType.Integer).Value = nSira
                            
                            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                            Debug.WriteLine($"[ResimEkle] UPDATE çalıştı → rowsAffected={rowsAffected}")
                            
                            If rowsAffected = 0 Then
                                Throw New Exception("UPDATE başarısız - 0 satır etkilendi!")
                            End If
                        End Using
                    End If
                    
                    ' CRITICAL: Transaction'ı COMMIT et
                    Using cmdCommit As New OleDb.OleDbCommand("COMMIT TRAN", con)
                        cmdCommit.ExecuteNonQuery()
                        Debug.WriteLine("[ResimEkle] *** COMMIT TRAN YAPILDI *** ✓✓✓")
                    End Using
                    
                    ' DOĞRULAMA: Gerçekten kaydedildi mi kontrol et - Model+Renk+nSira
                    Using cmdVerify As New OleDb.OleDbCommand(
                        "SELECT COUNT(*) FROM tbStokResim WHERE sModel = ? AND ISNULL(sRenk,'') = ISNULL(?,'') AND nSira = ? AND (sBeden IS NULL OR sBeden = '')", con)
                        cmdVerify.Parameters.Add("p0", OleDb.OleDbType.VarChar, 50).Value = sModel
                        cmdVerify.Parameters.Add("p1", OleDb.OleDbType.VarChar, 10).Value = If(String.IsNullOrEmpty(sRenk), "", sRenk)
                        cmdVerify.Parameters.Add("p2", OleDb.OleDbType.Integer).Value = nSira
                        Dim count As Integer = CInt(cmdVerify.ExecuteScalar())
                        Debug.WriteLine($"[ResimEkle] DOĞRULAMA: Database'de kayıt sayısı = {count} (Model={sModel}, Renk={sRenk}, Sira={nSira})")
                        
                        If count = 0 Then
                            Throw New Exception("HATA: COMMIT sonrası kayıt bulunamadı!")
                        End If
                    End Using
                    
                Catch dbEx As Exception
                    ' Hata durumunda ROLLBACK
                    Try
                        Using cmdRollback As New OleDb.OleDbCommand("IF @@TRANCOUNT > 0 ROLLBACK TRAN", con)
                            cmdRollback.ExecuteNonQuery()
                            Debug.WriteLine("[ResimEkle] *** ROLLBACK YAPILDI *** ✗✗✗")
                        End Using
                    Catch rollbackEx As Exception
                        Debug.WriteLine($"[ResimEkle] ROLLBACK hatası: {rollbackEx.Message}")
                    End Try
                    
                    Debug.WriteLine($"[ResimEkle] Database HATA: {dbEx.Message}")
                    Debug.WriteLine($"[ResimEkle] StackTrace: {dbEx.StackTrace}")
                    Throw dbEx
                End Try
            End Using
            
            ' UI'ı yenile - GridControl6 kullan (resimler burada gösteriliyor)
            Try
                ds_tbStokResim = Dataload_tbStokResim(Trim(sModel))
                If ds_tbStokResim IsNot Nothing AndAlso ds_tbStokResim.Tables.Count > 0 Then
                    GridControl6.DataSource = ds_tbStokResim.Tables(0)
                    GridControl6.RefreshDataSource()
                    GridView6.RefreshData()
                End If
                XtraMessageBox.Show("Resim başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                XtraMessageBox.Show("Resim eklendi ancak yenilemede hata: " & ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            
        Catch ex As Exception
            XtraMessageBox.Show("Resim yüklenirken hata: " & ex.Message & vbCrLf & vbCrLf & 
                               "Stack Trace: " & ex.StackTrace, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.WriteLine($"[ResimEkle] HATA: {ex.Message}")
            Debug.WriteLine($"[ResimEkle] StackTrace: {ex.StackTrace}")
        End Try
        
End Sub
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        analiz_stok_KarlilikAkisTablosu()
    End Sub
    Private Sub btn_Alternatif_Ekle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Alternatif_Ekle.Click
        Satir_Ekle_StokAlternatif()
    End Sub
    Private Sub Satir_Ekle_StokAlternatif()
        Dim frm As New frm_stok
        frm.islemstatus = True
        Dim dr As DataRow
        Dim dr1 As DataRow
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.kullanici = kullanici
        Dim yeni As Boolean = False
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = frm.GridView1.GetDataRow(s)
                    tbStokAlternatif_kaydet_yeni(sModel, dr1("nStokID"))
                    dr = ds_tbStokAlternatif.Tables(0).NewRow
                    dr("sKodu") = dr1("sKodu")
                    dr("sAciklama") = dr1("sAciklama")
                    dr("sRenk") = dr1("sRenk")
                    dr("sRenkAdi") = dr1("sRenkAdi")
                    dr("sBeden") = dr1("sBeden")
                    dr("KALAN") = dr1("Mevcut")
                    ds_tbStokAlternatif.Tables(0).Rows.Add(dr)
                    Me.Refresh()
                Next
                yeni = frm.yeni
                frm.DataSet1.Clear()
                frm.DataSet1.Dispose()
                frm.DataSet1 = Nothing
                frm.SimpleButton1 = Nothing
                frm.SimpleButton2 = Nothing
                frm.GridControl1.Dispose()
                frm.GridControl1 = Nothing
                frm.GridView1.Dispose()
                frm.GridView1 = Nothing
                frm.XtraTabControl1.Dispose()
                frm.XtraTabControl1 = Nothing
                frm.XtraTabPage1.Dispose()
                frm.XtraTabPage1 = Nothing
                frm.Label1.Dispose()
                frm.Label1 = Nothing
                frm.Label2.Dispose()
                frm.Label2 = Nothing
                frm.Close()
                frm.Dispose()
                frm = Nothing
                dr = Nothing
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
            End If
        End If
        GridView5.UpdateTotalSummary()
        'GridControl1.Select()
        'GridControl1.Focus()
        'GridView1.Focus()
        If GridView5.RowCount > 0 Then
            GridView5.FocusedRowHandle = GridView5.RowCount - 1
            GridView5.SelectRow(GridView5.FocusedRowHandle)
            GridControl7.Focus()
        End If
    End Sub
    Private Sub analiz_stok_Alternatif()
        Dim frm As New frm_stok
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.aktif = 1
        frm.alternatif = sKodu
        frm.qalternatif = "Eittir"
        frm.status = True
        If yetki_kontrol(kullanici, "frm_Stok_Alternatif") = True Then
            frm.ShowDialog()
        End If
    End Sub
    Private Sub tbStokAlternatif_Satir_sil()
        If GridView5.RowCount > 0 Then
            Dim dr As DataRow
            Dim satir
            dr = GridView5.GetDataRow(GridView5.FocusedRowHandle)
            satir = GridView5.FocusedRowHandle
            If XtraMessageBox.Show(dr("sKodu") & vbTab & Sorgu_sDil(" Kodlu Alternatif Stok Kaydn Silmek istediinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                tbStokAlternatif_kaydet_sil(sModel, dr("nStokID"))
            End If
            ds_tbStokAlternatif = Dataload_tbStokAlternatif(sModel)
            GridControl7.DataSource = ds_tbStokAlternatif.Tables(0)
            GridControl7.DataMember = Nothing
            GridView5.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub btn_Alternatif_Sil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Alternatif_Sil.Click
        tbStokAlternatif_Satir_sil()
    End Sub
    Private Sub btn_Alternatif_Yazdir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Alternatif_Yazdir.Click
        GridControl7.ShowPrintPreview()
    End Sub
    Private Sub SimpleButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton14.Click
        analiz_stok_Alternatif()
    End Sub
    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        analiz_stok_Alternatif()
    End Sub
    Private Sub SimpleButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton16.Click
        tbKavala()
    End Sub
    Private Sub SimpleButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton15.Click
        tbKavala_kaldir()
    End Sub
    Private Sub GridView7_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView7.CellValueChanged
        If GridView7.RowCount > 0 Then
            Dim satir = GridView7.FocusedRowHandle
            Dim dr As DataRow = GridView7.GetDataRow(GridView7.FocusedRowHandle)
            GridView7.PostEditor()
            dr.EndEdit()
            'tbStokSinifi_kaydet_duzelt(sModel, dr("sSinifKodu"), dr("sSinifNo"))
            tbStokMuhasebeEntegrasyonu_kaydet_duzelt(sModel, dr("sSubeMagaza").ToString, dr("nSubeMagazaHesapTipi").ToString, dr("sHareketTipi").ToString, dr("nHesapID").ToString)
            'Dataload_tbStokSinifi(sModel)
            GridView7.FocusedRowHandle = satir
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub SimpleButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton17.Click
        GroupControl6.Visible = False
        txt_sAdi.Focus()
        txt_sAdi.SelectAll()
    End Sub
    Private Sub SimpleButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton18.Click
        Dim deger As String = ""
        deger = txt_sYeniKod.Text
        If deger.ToString <> "" Then
            If XtraMessageBox.Show("Model Kodunu : " & txt_sYeniKod.Text & vbCrLf & "Olarak Deitirmek stediinize Eminmisiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                GroupControl6.Visible = False
                tbStokKod_kaydet_duzelt(sModel, deger)
                sModel = deger
                txt_musteriNo.EditValue = sModel
                dataload(deger)
            End If
        End If
    End Sub
    Private Sub txt_sYeniKod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sYeniKod.Validating
        txt_sYeniKod.Text = Trim(txt_sYeniKod.Text.ToString)
        If sorgu_sKodu_kontrol(txt_sYeniKod.Text) = False And txt_sYeniKod.Text <> "" And GroupControl6.Visible = True Then
            txt_sYeniKod.ErrorText = txt_sYeniKod.Text & vbTab & "Kayd Daha nce Kullanlm"
            If XtraMessageBox.Show(txt_sYeniKod.Text & Sorgu_sDil(" Kodlu Kayt Daha nceden Kullanlm...!", sDil) & vbCrLf & Sorgu_sDil("Kaytlar Listelemek ster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                stok_liste(txt_sYeniKod.Text, "sKodu")
            End If
            e.Cancel = True
            txt_sYeniKod.Focus()
            txt_sYeniKod.SelectAll()
        End If
    End Sub
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
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sKodu), 0) AS nKayit FROM         tbStok WHERE     (sKodu = '" & kod & "') or (sModel ='" & kod & "') ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sKoliKodu), 0) AS nKayit FROM         tbKoli WHERE     (sKoliKodu = '" & kod & "') ")
            kayitsayisi = cmd.ExecuteScalar
        End If
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Private Sub stok_liste(ByVal ara As String, ByVal sKonum As String)
        Dim frm As New frm_stok
        'frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.kullanici = kullanici
        'frm.islemstatus = True
        If ara <> "" Then
            frm.qgelismis = "Balar"
            frm.gelismis = ara
            frm.status = True
            frm.mevcut = 1
        End If
        frm.ShowDialog()
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub SimpleButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton19.Click
        barkodu_kod_ata()
    End Sub
    Private Sub SimpleButton20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton20.Click
        Group_BarkodGir.Visible = True
        txt_sBarkod.Focus()
        txt_sBarkod.SelectAll()
        sec_sBarkodTipi.Text = "Koli"
    End Sub
    Private Sub btn_BarkodVazgec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BarkodVazgec.Click
        Group_BarkodGir.Visible = False
        XtraTabControl1.SelectedTabPageIndex = 4
        GridControl4.Focus()
        GridControl4.Select()
    End Sub
    Private Sub txt_sBarkod_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_sBarkod.EditValueChanged
        If Len(txt_sBarkod.EditValue.ToString) <> 0 Then
            lbl_sBarkod.Text = Len(txt_sBarkod.Text.ToString)
        ElseIf Len(txt_sBarkod.EditValue.ToString) = 5 Then
            sec_sBarkodBirimCinsi.EditValue = "KG "
        Else
            lbl_sBarkod.Text = "*"
        End If
        If Len(txt_sBarkod.EditValue.ToString) >= 12 Then
            If IsNumeric(txt_sBarkod.Text) = True Then
                lbl_checkdigit.Text = Ean13_CheckSum(Microsoft.VisualBasic.Left(txt_sBarkod.Text, 12))
            End If
        ElseIf Len(txt_sBarkod.EditValue.ToString) >= 7 Then
            If IsNumeric(txt_sBarkod.Text) = True Then
                lbl_checkdigit.Text = EAN8_Checksum(Microsoft.VisualBasic.Left(txt_sBarkod.Text, 7))
            End If
        End If
        If Len(txt_sBarkod.EditValue.ToString) = 8 Then
            If Microsoft.VisualBasic.Right(txt_sBarkod.Text, 1) = lbl_checkdigit.Text Then
                lbl_barcodestd.Text = "Ean8"
            Else
                lbl_barcodestd.Text = "-"
            End If
        ElseIf Len(txt_sBarkod.EditValue.ToString) = 13 Then
            If Microsoft.VisualBasic.Right(txt_sBarkod.Text, 1) = lbl_checkdigit.Text Then
                lbl_barcodestd.Text = "Ean13"
            Else
                lbl_barcodestd.Text = "-"
            End If
        Else
            lbl_barcodestd.Text = "-"
        End If
    End Sub
    Private Sub txt_sBarkod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sBarkod.Validating
        txt_sBarkod.Text = Trim(txt_sBarkod.Text.ToString)
        If sorgu_sBarkod_kontrol(txt_sBarkod.Text) = False And Group_BarkodGir.Visible = True Then
            txt_sBarkod.ErrorText = txt_sBarkod.Text & vbTab & "Barkodu Daha nce Kullanlm"
            If XtraMessageBox.Show(txt_sBarkod.Text & Sorgu_sDil(" Barkodlu Kayt Daha nceden Kullanlm...!", sDil) & vbCrLf & Sorgu_sDil("Kaytlar Listelemek ster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                stok_liste(txt_sBarkod.Text, "sBarkod")
            End If
            e.Cancel = True
            txt_sBarkod.Focus()
            txt_sBarkod.SelectAll()
        End If
    End Sub
    Public Function sorgu_sBarkod_kontrol(ByVal kod As String) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sBarkod), 0) AS nKayit FROM         tbStokBarkodu WHERE     (sBarkod = '" & kod & "') ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sKoliKodu), 0) AS nKayit FROM         tbKoli WHERE     (sKoliKodu = '" & kod & "') ")
            kayitsayisi = cmd.ExecuteScalar
        End If
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
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
    Private Sub sec_sBarkodTipi_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sBarkodTipi.SelectedValueChanged
        If sec_sBarkodTipi.Text = "Master" Then
            sec_sBarkodBirimCinsi.Text = ""
            txt_lBarkodMiktar.EditValue = 0
            sec_sBarkodBirimCinsi.Enabled = False
            txt_lBarkodMiktar.Enabled = False
        ElseIf sec_sBarkodTipi.Text = "Muadil" Then
            sec_sBarkodBirimCinsi.Text = ""
            txt_lBarkodMiktar.EditValue = 0
            sec_sBarkodBirimCinsi.Enabled = False
            txt_lBarkodMiktar.Enabled = False
        ElseIf sec_sBarkodTipi.Text = "Koli" Then
            sec_sBarkodBirimCinsi.Text = ""
            txt_lBarkodMiktar.EditValue = 0
            sec_sBarkodBirimCinsi.Enabled = True
            txt_lBarkodMiktar.Enabled = True
        End If
    End Sub
    Private Sub btn_BarkodKaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BarkodKaydet.Click
        Dim deger As String = txt_sBarkod.Text
        Dim nKisim As Integer = 0
        If sec_sBarkodTipi.Text = "Master" Then
            nKisim = 0
            sec_sBarkodBirimCinsi.EditValue = ""
        ElseIf sec_sBarkodTipi.Text = "Muadil" Then
            nKisim = 1
            sec_sBarkodBirimCinsi.EditValue = ""
        ElseIf sec_sBarkodTipi.Text = "Koli" Then
            nKisim = 2
        End If
        Dim satir = GridView3.FocusedRowHandle
        Dim dr As DataRow = GridView3.GetDataRow(GridView3.FocusedRowHandle)
        GridView3.PostEditor()
        dr.EndEdit()
        If deger.ToString <> "" Then
            tbStokBarkod_kaydet_yeni(dr("StokID"), deger, nKisim, 0, "", "", sec_sBarkodBirimCinsi.EditValue, txt_lBarkodMiktar.EditValue)
            If nKisim = 2 Then
                tbKoli_kaydet_yeni(deger, dr("sAciklama"))
                tbKoliDagilimi_kaydet_yeni(deger, dr("nStokID"), 1, sec_sBarkodBirimCinsi.EditValue, txt_lBarkodMiktar.EditValue, 0, "")
            End If
        End If
        Dataload_tbStokBarkodu(sModel)
        GridView3.FocusedRowHandle = satir
        dr = Nothing
        satir = Nothing
        barkod_info()
        Group_BarkodGir.Visible = False
        GridControl4.Focus()
        GridControl4.Select()
    End Sub
    Private Sub tbKoli_kaydet_yeni(ByVal sKoliKodu As String, ByVal sAciklama As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        sKoliKodu = Trim(sKoliKodu)
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbKoli (sKoliKodu, sAciklama) VALUES     ('" & sKoliKodu & "', N'" & sAciklama & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbKoliDagilimi_kaydet_yeni(ByVal sKoliKodu As String, ByVal nStokID As Int64, ByVal lMiktar As Decimal, ByVal sBirimCinsi As String, ByVal lBirimMiktar As Decimal, ByVal lFiyat As Decimal, ByVal sFiyatTipi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        sKoliKodu = Trim(sKoliKodu)
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbKoliDagilimi (sKoliKodu, nStokID,lMiktar,sBirimCinsi,lBirimMiktar,lFiyat,sFiyatTipi) VALUES     ('" & sKoliKodu & "', " & nStokID & "," & lMiktar & ",'" & sBirimCinsi & "'," & lBirimMiktar & "," & lFiyat & ",'" & sFiyatTipi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbKoliDagilimi_kaydet_duzelt(ByVal sKoliKodu As String, ByVal nStokID As Int64, ByVal lMiktar As Decimal, ByVal sBirimCinsi As String, ByVal lBirimMiktar As Decimal, ByVal lFiyat As Decimal, ByVal sFiyatTipi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        sKoliKodu = Trim(sKoliKodu)
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbKoliDagilimi SET              sKoliKodu ='" & sKoliKodu & "',nStokID =" & nStokID & " ,lMiktar =" & lMiktar & ",sBirimCinsi = '" & sBirimCinsi & "',lBirimMiktar = " & lBirimMiktar & ",lFiyat = " & lFiyat & ",sFiyatTipi = '" & sFiyatTipi & "' Where sKoliKodu = '" & sKoliKodu & "' and nStokID =" & nStokID & "")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbKoliDagilimi SET              sKoliKodu ='" & sKoliKodu & "',nStokID =" & nStokID & " ,lMiktar =" & lMiktar & ",sBirimCinsi = '" & sBirimCinsi & "',lBirimMiktar = " & lBirimMiktar & " Where sKoliKodu = '" & sKoliKodu & "' and nStokID =" & nStokID & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbKoli_kaydet_sil(ByVal sKoliKodu As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        sKoliKodu = Trim(sKoliKodu)
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbKoli Where sKoliKodu  ='" & sKoliKodu & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbKoliDagilimi_kaydet_sil(ByVal sKoliKodu As String, ByVal nStokID As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbKoliDagilimi Where sKoliKodu  ='" & sKoliKodu & "' and nStokID =" & nStokID & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub SimpleButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton21.Click
        RBKTamamla()
    End Sub
    Private Sub btn_Listele_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Listele.Click
        Dataload_tbStokHareketleri(sModel, DateEdit1.EditValue, DateEdit2.EditValue)
    End Sub
    Private Sub txt_nEn_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nEn.EditValueChanged
        hacim_hesapla()
    End Sub
    Private Sub hacim_hesapla()
        Dim nHacim As Decimal = 0
        nHacim = sorgu_sayi(txt_nEn.EditValue, 0) * sorgu_sayi(txt_nBoy.EditValue, 0) * sorgu_sayi(txt_nYukseklik.EditValue, 0)
        txt_nHacim.Text = nHacim
    End Sub
    Private Sub txt_nBoy_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nBoy.EditValueChanged
        hacim_hesapla()
    End Sub
    Private Sub txt_nYukseklik_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nYukseklik.EditValueChanged
        hacim_hesapla()
    End Sub
    Private Sub txt_musteriNo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_musteriNo.EditValueChanged
        If Len(txt_musteriNo.EditValue.ToString) <> 0 Then
            lbl_ara.Text = Len(txt_musteriNo.EditValue.ToString)
        Else
            lbl_ara.Text = "*"
        End If
    End Sub
    Private Sub txt_musteriNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_musteriNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            stok_kontrol()
            txt_musteriNo.Focus()
            txt_musteriNo.SelectAll()
        ElseIf e.KeyCode = Keys.F6 Then
            stok_sec()
        End If
    End Sub
    Private Sub SimpleButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BarkodAtaModel.Click
        barkod_ekle_sModel(0)
    End Sub
    Private Sub BarkodAtaStokKoduToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarkodAtaStokKoduToolStripMenuItem.Click
        barkod_ekle_sModel(0)
    End Sub
    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        Dim frm As New frm_Stok_Etiket_Yazdir
        frm.kullanici = kullanici
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        If ds_tbStokAcilim.Tables(0).Rows.Count = 1 Then
            frm.txt_sAra.Text = txt_musteriNo.Text
        Else
            frm.bAra = True
            frm.sAra = txt_musteriNo.Text
            frm.txt_sAra.Text = txt_musteriNo.Text
        End If
        frm.islem_status = True
        If yetki_kontrol(kullanici, frm.Name) = True Then
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            End If
        End If
    End Sub
    Private Sub txt_OIVVar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles txt_OIVVar.CheckedChanged
        txt_nOIV.Enabled = txt_OIVVar.Checked
    End Sub

    Private Sub GridControl3_Click(sender As Object, e As EventArgs) Handles GridControl3.Click

    End Sub

    ' ============================================
    ' RESIM CACHE YNETM (frm_stok_liste ile ortak)
    ' ============================================
    Private cacheFolderPath As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "BARKOD_MAGAZA_ImageCache")

    Private Sub SaveImageToCache(imageUrl As String, imageBytes As Byte())
        Try
            If String.IsNullOrEmpty(imageUrl) OrElse imageBytes Is Nothing OrElse imageBytes.Length = 0 Then
                Return
            End If

            ' Cache klasrn olutur
            If Not Directory.Exists(cacheFolderPath) Then
                Directory.CreateDirectory(cacheFolderPath)
            End If

            ' URL'nin hash'ini al (filename olarak kullan)
            Dim urlHash As String = GetMD5Hash(imageUrl)
            Dim cacheFilePath As String = System.IO.Path.Combine(cacheFolderPath, urlHash & ".jpg")

            ' Cache'e kaydet (eer yoksa)
            If Not System.IO.File.Exists(cacheFilePath) Then
                System.IO.File.WriteAllBytes(cacheFilePath, imageBytes)
            End If
        Catch ex As Exception
            ' Cache kaydetme hatas - sessizce devam et
        End Try
    End Sub

    Private Function GetMD5Hash(input As String) As String
        Try
            Using md5 As System.Security.Cryptography.MD5 = System.Security.Cryptography.MD5.Create()
                Dim inputBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(input)
                Dim hashBytes As Byte() = md5.ComputeHash(inputBytes)

                Dim sb As New System.Text.StringBuilder()
                For Each b As Byte In hashBytes
                    sb.Append(b.ToString("x2"))
                Next
                Return sb.ToString()
            End Using
        Catch
            Return Guid.NewGuid().ToString("N")
        End Try
    End Function


    ' ===== YEN FONKSYONLAR - tbStokResim N =====

    Private Function GetNextAvailableSlot_tbStokResim(sModel As String, sRenk As String, nStokID As Integer) As Integer
        ' YENİ YAPI: nStokID + sRenk bazlı, boş slot bul
        ' Her renk için ayrı slot numaraları (1-11)
        
        Using con As New OleDb.OleDbConnection(connection)
            con.Open()
            
            ' Mevcut tüm sıraları al (READ UNCOMMITTED ile) - nStokID + sRenk filtrelemesi
            Using cmd As New OleDb.OleDbCommand(
                "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " &
                "SELECT nSira FROM tbStokResim WHERE (nStokID = ? OR (nStokID IS NULL AND sModel = ?)) AND ISNULL(sRenk,'') = ISNULL(?,'') ORDER BY nSira", con)
                cmd.Parameters.Add("p0", OleDb.OleDbType.Integer).Value = If(nStokID = 0, DBNull.Value, CObj(nStokID))
                cmd.Parameters.Add("p1", OleDb.OleDbType.VarChar, 50).Value = sModel
                cmd.Parameters.Add("p2", OleDb.OleDbType.VarChar, 10).Value = If(String.IsNullOrEmpty(sRenk), DBNull.Value, CObj(sRenk))
                
                Dim existingSlots As New HashSet(Of Integer)()
                
                Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        existingSlots.Add(reader.GetInt32(0))
                    End While
                End Using
                
                Debug.WriteLine($"[GetNextSlot] sModel={sModel}, nStokID={nStokID}, sRenk={sRenk}, Mevcut slotlar: {String.Join(",", existingSlots)}")
                
                ' 1'den 11'e kadar ilk boş slotu bul
                For i As Integer = 1 To 11
                    If Not existingSlots.Contains(i) Then
                        Debug.WriteLine($"[GetNextSlot] Boş slot bulundu: {i}")
                        Return i
                    End If
                Next
                
                ' Tüm slotlar dolu
                Debug.WriteLine("[GetNextSlot] Tüm slotlar dolu (11 resim max), 12 dönüyor")
                Return 12  ' 12 = slot yok (11 resim max)
            End Using
        End Using
    End Function
    
    ' MODEL+RENK bazlı slot bulma (beden yok)
    ' Tüm bedenler için ortak resim olduğundan, Model+Renk ile arama yapılır
    Private Function GetNextAvailableSlot_ModelRenk(sModel As String, sRenk As String) As Integer
        Using con As New OleDb.OleDbConnection(connection)
            con.Open()
            
            ' Model+Renk bazında, beden olmayan (NULL veya boş) kayıtları ara
            Using cmd As New OleDb.OleDbCommand(
                "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " &
                "SELECT nSira FROM tbStokResim WHERE sModel = ? AND ISNULL(sRenk,'') = ISNULL(?,'') AND (sBeden IS NULL OR sBeden = '') ORDER BY nSira", con)
                cmd.Parameters.Add("p0", OleDb.OleDbType.VarChar, 50).Value = sModel
                cmd.Parameters.Add("p1", OleDb.OleDbType.VarChar, 10).Value = If(String.IsNullOrEmpty(sRenk), "", sRenk)
                
                Dim existingSlots As New HashSet(Of Integer)()
                
                Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        existingSlots.Add(reader.GetInt32(0))
                    End While
                End Using
                
                Debug.WriteLine($"[GetNextSlot_ModelRenk] sModel={sModel}, sRenk={sRenk}, Mevcut slotlar: {String.Join(",", existingSlots)}")
                
                ' 1'den 11'e kadar ilk boş slotu bul
                For i As Integer = 1 To 11
                    If Not existingSlots.Contains(i) Then
                        Debug.WriteLine($"[GetNextSlot_ModelRenk] Boş slot bulundu: {i}")
                        Return i
                    End If
                Next
                
                ' Tüm slotlar dolu
                Debug.WriteLine("[GetNextSlot_ModelRenk] Tüm slotlar dolu (11 resim max), 12 dönüyor")
                Return 12  ' 12 = slot yok (11 resim max)
            End Using
        End Using
    End Function

    Private Async Function DownloadFromR2ToLocal(r2Url As String, localPath As String) As Task
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync(r2Url)
            response.EnsureSuccessStatusCode()
            Dim imageBytes As Byte() = Await response.Content.ReadAsByteArrayAsync()
            Dim folderPath As String = System.IO.Path.GetDirectoryName(localPath)
            If Not System.IO.Directory.Exists(folderPath) Then
                System.IO.Directory.CreateDirectory(folderPath)
            End If
            System.IO.File.WriteAllBytes(localPath, imageBytes)
        End Using
    End Function


    ' Resim Silme - GridView6'dan seçili resmi sil
    Private Async Sub tbStokResim_Satir_sil()
        If GridView6.RowCount <= 0 Then Exit Sub

        Dim dr As DataRow = GridView6.GetDataRow(GridView6.FocusedRowHandle)
        If dr Is Nothing Then Exit Sub

        Dim tarihText As String = If(IsDBNull(dr("dteKayitTarihi")), "",
                                 Convert.ToDateTime(dr("dteKayitTarihi")).ToString())

        If XtraMessageBox.Show(tarihText & vbTab &
                           "Tarihli Resmi Silmek istediğinize Emin misiniz...?",
                           "Dikkat",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) <> DialogResult.Yes Then
            Exit Sub
        End If

        ' Resim bilgilerini al
        Dim id As Integer = Convert.ToInt32(If(IsDBNull(dr("nStokResimID")), 0, dr("nStokResimID")))
        Dim sira As Integer = Convert.ToInt32(If(IsDBNull(dr("nSira")), 0, dr("nSira")))
        Dim yol As String = If(IsDBNull(dr("yol")), "", Convert.ToString(dr("yol")))

        ' Database'den sil ve R2'den sil
        Await tbStokResim_kaydet_Sil(sModel, id, sira, yol)

        ' UI'ı yenile - GridControl6 kullan (resimler burada gösteriliyor)
        Try
            ds_tbStokResim = Dataload_tbStokResim(Trim(sModel))
            If ds_tbStokResim IsNot Nothing AndAlso ds_tbStokResim.Tables.Count > 0 Then
                GridControl6.DataSource = ds_tbStokResim.Tables(0)
                GridControl6.RefreshDataSource()
                GridView6.RefreshData()
            End If
            XtraMessageBox.Show("Resim başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            XtraMessageBox.Show("Resim silindi ancak yenilemede hata: " & ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ' Database ve R2'den silme
    Private Async Function tbStokResim_kaydet_Sil(sModel As String, nStokResimID As Integer, nSira As Integer, yol As String) As Task
        ' 0. Önce resim bilgilerini çek (sRenk, sBeden, sKavala)
        Dim sRenk As String = ""
        Dim sBeden As String = ""
        Dim sKavala As String = ""
        
        Try
            Using con As New OleDb.OleDbConnection(connection)
                con.Open()
                Using cmd As New OleDb.OleDbCommand("SELECT sRenk, sBeden, sKavala FROM tbStokResim WHERE nStokResimID = ?", con)
                    cmd.Parameters.Add("p0", OleDb.OleDbType.Integer).Value = nStokResimID
                    Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            sRenk = If(reader.IsDBNull(0) OrElse reader.GetValue(0) Is Nothing, "", reader.GetValue(0).ToString().Trim())
                            sBeden = If(reader.IsDBNull(1) OrElse reader.GetValue(1) Is Nothing, "", reader.GetValue(1).ToString().Trim())
                            sKavala = If(reader.IsDBNull(2) OrElse reader.GetValue(2) Is Nothing, "", reader.GetValue(2).ToString().Trim())
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Bilgiler alınamazsa boş kalır
        End Try
        
        ' 1. Database'den sil
        Try
            Using con As New OleDb.OleDbConnection(connection)
                con.Open()
                Using cmd As New OleDb.OleDbCommand("DELETE FROM tbStokResim WHERE nStokResimID = ?", con)
                    cmd.Parameters.Add("p0", OleDb.OleDbType.Integer).Value = nStokResimID
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            XtraMessageBox.Show("Database'den silme hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        ' 2. R2'den sil (eğer R2 URL ise)
        If Not String.IsNullOrEmpty(yol) AndAlso yol.Contains("r2.dev") Then
            Try
                ' R2 object key'i oluştur - UPLOAD ile AYNI mantık
                Dim klasor As String = Await GetFirmaKlasoru()
                
                Dim fileNameParts As New List(Of String) From {sModel.Trim()}
                If Not String.IsNullOrEmpty(sRenk) Then fileNameParts.Add(sRenk)
                If Not String.IsNullOrEmpty(sBeden) Then fileNameParts.Add(sBeden)
                If Not String.IsNullOrEmpty(sKavala) Then fileNameParts.Add(sKavala)
                fileNameParts.Add(nSira.ToString())
                
                Dim fileName As String = String.Join("_", fileNameParts) & ".jpg"
                Dim objectKey As String = If(String.IsNullOrEmpty(klasor),
                    "products/" & sModel.Trim() & "/" & fileName,
                    "products/" & klasor & "/" & sModel.Trim() & "/" & fileName)

                Debug.WriteLine($"[ResimSil] R2 siliniyor: {objectKey}")
                ' R2'den sil
                Dim deleted As Boolean = R2Helpers.R2Delete(objectKey)
                If Not deleted Then
                    Debug.WriteLine($"[ResimSil] R2'den silinemedi: {objectKey}")
                End If
            Catch ex As Exception
                Debug.WriteLine($"[ResimSil] R2 silme hatası: {ex.Message}")
            End Try
        End If
    End Function

    ' Firma klasör adını al (REMOTE SERVER)
    Private Async Function GetFirmaKlasoru() As Task(Of String)
        Dim klasor As String = ""
        Try
            ' 1. LOCAL DB'den Server IP'sini al
            Dim sourceIP As String = ""
            Using conLocal As New OleDb.OleDbConnection(connection)
                conLocal.Open()
                Using cmdSource As New OleDb.OleDbCommand("SELECT TOP 1 Lisans FROM tbParamGenel", conLocal)
                    Dim result As Object = cmdSource.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        sourceIP = result.ToString().Trim()
                    End If
                End Using
            End Using

            If String.IsNullOrEmpty(sourceIP) Then sourceIP = "212.156.206.214"

            ' 2. Registry'den sOnayKodu al
            Dim sOnayKodu As String = ""
            Try
                sOnayKodu = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("Key").GetValue("sOnayKodu").ToString()
            Catch
                sOnayKodu = ""
            End Try

            ' 3. REMOTE SERVER'a bağlan
            If Not String.IsNullOrEmpty(sOnayKodu) AndAlso sOnayKodu <> "0" Then
                Dim remoteConnectionString As String = String.Format(
                    "Provider=SQLOLEDB.1;Password=87918991;Persist Security Info=True;User ID=bayii1;Initial Catalog=BAYII;Data Source={0},8991",
                    sourceIP)

                Try
                    Using conRemote As New OleDb.OleDbConnection(remoteConnectionString)
                        conRemote.Open()
                        Using cmdKlasor As New OleDb.OleDbCommand(
                            "SELECT TOP 1 tbFirma.sOzelNot " &
                            "FROM tbFirmaLisans " &
                            "INNER JOIN tbFirma ON tbFirmaLisans.nFirmaID = tbFirma.nFirmaID " &
                            "WHERE tbFirmaLisans.sOnayKodu = ?", conRemote)
                            cmdKlasor.Parameters.Add("sOnayKodu", OleDb.OleDbType.VarChar, 50).Value = sOnayKodu

                            Dim result As Object = cmdKlasor.ExecuteScalar()
                            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                                klasor = result.ToString().Trim()
                            End If
                        End Using
                    End Using
                Catch
                    klasor = ""
                End Try
            End If
        Catch
            klasor = ""
        End Try

        Return klasor
    End Function
    
    ' SimpleButton9 Click event - Resim Sil butonu
    Private Sub SimpleButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton9.Click
        tbStokResim_Satir_sil()
    End Sub
    
    ' GridView6 KeyDown event - Delete tuşu ile resim silme
    Private Sub GridView6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView6.KeyDown
        If e.KeyCode = Keys.Delete Then
            tbStokResim_Satir_sil()
        End If
    End Sub
    
    ' ===== AI SISTEM BUTONLARI =====
    
    Private Async Sub btnAIResimEkle_Click(sender As Object, e As EventArgs) Handles btnAIResimEkle.Click
        Try
            If nStokID = 0 Then
                MessageBox.Show("Önce ürün kartını kaydetmelisiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            
            Dim result As DialogResult = MessageBox.Show(
                "Bu ürün için AI ile görsel aranacak ve eklenecek." & vbCrLf & vbCrLf &
                "Tahmini maliyet: 0.175 TL" & vbCrLf & vbCrLf &
                "Devam etmek istiyor musunuz?",
                "AI Resim Ekle",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
            
            If result = DialogResult.Yes Then
                ' tbStokBarkodu tablosundan gerçek barkodu al
                Dim actualBarcode As String = ""
                Try
                    Using con As New OleDb.OleDbConnection(connection)
                        Using cmd As New OleDb.OleDbCommand(
                            "SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = ?", con)
                            cmd.Parameters.Add("p0", OleDb.OleDbType.Integer).Value = Me.nStokID
                            con.Open()
                            Dim result2 As Object = cmd.ExecuteScalar()
                            If result2 IsNot Nothing AndAlso Not IsDBNull(result2) Then
                                actualBarcode = result2.ToString().Trim()
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    Debug.WriteLine($"[AI Resim] Barkod çekme hatası: {ex.Message}")
                End Try
                
                If String.IsNullOrEmpty(actualBarcode) Then
                    MessageBox.Show("❌ Bu ürün için barkod bulunamadı!" & vbCrLf & vbCrLf & "Lütfen önce barkod ekleyin.", "Barkod Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                
                Debug.WriteLine($"[AI Resim] Barkod bulundu: {actualBarcode}")
                
                ' AI resim bulma işlemi (connection string ile başlat)
                Dim imageFinder As New AIImageFinder(connection)
                
                ' Önce resimleri bul
                Cursor.Current = Cursors.WaitCursor
                Dim foundImages As List(Of String) = imageFinder.FindImagesByBarcode(actualBarcode)
                Cursor.Current = Cursors.Default
                
                If foundImages Is Nothing OrElse foundImages.Count = 0 Then
                    MessageBox.Show("❌ Hiç görsel bulunamadı!" & vbCrLf & vbCrLf & 
                                   "Barkod: " & actualBarcode & vbCrLf & vbCrLf & 
                                   "Lütfen barkod veya ürün adını kontrol edin.", 
                                   "Sonuç Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                
                ' Önizleme formu oluştur
                Dim previewForm As New Form()
                previewForm.Text = "AI Görseller - Seçim Yapın (" & foundImages.Count & " adet)"
                previewForm.Size = New Size(900, 700)
                previewForm.StartPosition = FormStartPosition.CenterParent
                previewForm.FormBorderStyle = FormBorderStyle.FixedDialog
                previewForm.MaximizeBox = False
                
                Dim panel As New Panel()
                panel.Location = New Point(10, 10)
                panel.Size = New Size(860, 580)
                panel.AutoScroll = True
                panel.BorderStyle = BorderStyle.FixedSingle
                previewForm.Controls.Add(panel)
                
                ' Resim seçimi için değişken
                Dim selectedImageUrl As String = Nothing
                Dim yPos As Integer = 10
                
                ' Her resim için önizleme ekle
                For i As Integer = 0 To Math.Min(foundImages.Count - 1, 9) ' Maksimum 10 resim
                    Dim imageUrl As String = foundImages(i)
                    
                    Dim groupBox As New GroupBox()
                    groupBox.Text = "Görsel " & (i + 1).ToString()
                    groupBox.Location = New Point(10, yPos)
                    groupBox.Size = New Size(820, 150)
                    panel.Controls.Add(groupBox)
                    
                    ' PictureBox
                    Dim picBox As New PictureBox()
                    picBox.Location = New Point(10, 20)
                    picBox.Size = New Size(120, 120)
                    picBox.SizeMode = PictureBoxSizeMode.Zoom
                    picBox.BorderStyle = BorderStyle.FixedSingle
                    groupBox.Controls.Add(picBox)
                    
                    ' URL label
                    Dim lblUrl As New Label()
                    lblUrl.Text = imageUrl
                    lblUrl.Location = New Point(140, 20)
                    lblUrl.Size = New Size(500, 40)
                    lblUrl.Font = New Font("Segoe UI", 8)
                    groupBox.Controls.Add(lblUrl)
                    
                    ' Seç butonu
                    Dim btnSelect As New Button()
                    btnSelect.Text = "✅ Bu Resmi Seç"
                    btnSelect.Location = New Point(650, 80)
                    btnSelect.Size = New Size(150, 50)
                    btnSelect.BackColor = Color.Green
                    btnSelect.ForeColor = Color.White
                    btnSelect.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                    btnSelect.Tag = imageUrl
                    AddHandler btnSelect.Click, Sub()
                        selectedImageUrl = btnSelect.Tag.ToString()
                        previewForm.DialogResult = DialogResult.OK
                        previewForm.Close()
                    End Sub
                    groupBox.Controls.Add(btnSelect)
                    
                    ' Resmi arka planda yükle
                    Try
                        Using webClient As New System.Net.WebClient()
                            webClient.Headers.Add("User-Agent", "Mozilla/5.0")
                            Dim imageData As Byte() = webClient.DownloadData(imageUrl)
                            Using ms As New MemoryStream(imageData)
                                picBox.Image = Image.FromStream(ms)
                            End Using
                        End Using
                    Catch
                        picBox.BackColor = Color.LightGray
                        Dim lblError As New Label()
                        lblError.Text = "Yüklenemedi"
                        lblError.Location = New Point(30, 50)
                        lblError.AutoSize = True
                        picBox.Controls.Add(lblError)
                    End Try
                    
                    yPos += 160
                Next
                
                ' İptal butonu
                Dim btnCancel As New Button()
                btnCancel.Text = "❌ İptal"
                btnCancel.Location = New Point(720, 600)
                btnCancel.Size = New Size(150, 50)
                btnCancel.BackColor = Color.Gray
                btnCancel.ForeColor = Color.White
                btnCancel.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                AddHandler btnCancel.Click, Sub()
                    previewForm.DialogResult = DialogResult.Cancel
                    previewForm.Close()
                End Sub
                previewForm.Controls.Add(btnCancel)
                
                ' Formu göster
                If previewForm.ShowDialog() = DialogResult.OK AndAlso Not String.IsNullOrEmpty(selectedImageUrl) Then
                    ' Seçilen resmi SimpleButton12_Click mantığıyla kaydet
                    Cursor.Current = Cursors.WaitCursor
                    
                    Try
                        ' URL'den resmi indir ve geçici dosyaya kaydet
                        Dim tempFilePath As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), $"ai_image_{Guid.NewGuid()}.jpg")
                        
                        Using webClient As New System.Net.WebClient()
                            webClient.Headers.Add("User-Agent", "Mozilla/5.0")
                            webClient.DownloadFile(selectedImageUrl, tempFilePath)
                        End Using
                        
                        Debug.WriteLine($"[AI Resim] Geçici dosya oluşturuldu: {tempFilePath}")
                        
                        ' ===== SimpleButton12_Click'teki AYNI mantığı kullan =====
                        Dim sModel As String = Trim(txt_musteriNo.EditValue.ToString())
                        Dim nStokID As Integer = Me.nStokID
                        Dim sKodu As String = If(String.IsNullOrEmpty(Me.sKodu), "", Me.sKodu)
                        Dim sRenk As String = ""
                        Dim sRenkAdi As String = ""
                        Dim sBeden As String = ""
                        Dim sKavala As String = ""
                        
                        ' Direkt tbStok tablosundan sRenk, sBeden, sKavala bilgilerini çek
                        Try
                            Using con As New OleDb.OleDbConnection(connection)
                                Using cmd As New OleDb.OleDbCommand(
                                    "SELECT sRenk, sBeden, sKavala FROM tbStok WHERE nStokID = ?", con)
                                    cmd.Parameters.Add("p0", OleDb.OleDbType.Integer).Value = nStokID
                                    con.Open()
                                    Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                                        If reader.Read() Then
                                            sRenk = If(reader.IsDBNull(0) OrElse reader.GetValue(0) Is Nothing, "", reader.GetValue(0).ToString().Trim())
                                            sBeden = If(reader.IsDBNull(1) OrElse reader.GetValue(1) Is Nothing, "", reader.GetValue(1).ToString().Trim())
                                            sKavala = If(reader.IsDBNull(2) OrElse reader.GetValue(2) Is Nothing, "", reader.GetValue(2).ToString().Trim())
                                            Debug.WriteLine($"[AI Resim] tbStok'tan alındı: sRenk='{sRenk}', sBeden='{sBeden}', sKavala='{sKavala}'")
                                            
                                            If Not String.IsNullOrEmpty(sRenk) Then
                                                sRenkAdi = GetRenkAdiFromCode(sRenk)
                                            End If
                                        End If
                                    End Using
                                End Using
                            End Using
                        Catch ex As Exception
                            Debug.WriteLine($"[AI Resim] tbStok sorgu hatası: {ex.Message}")
                        End Try
                        
                        If String.IsNullOrEmpty(sModel) Then
                            MessageBox.Show("Lütfen önce ürün seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Try : System.IO.File.Delete(tempFilePath) : Catch : End Try
                            Return
                        End If
                        
                        ' Resim slot'u al (renk bazlı)
                        Dim nSira As Integer = GetNextAvailableSlot_tbStokResim(Trim(sModel), sRenk, nStokID)
                        If nSira > 11 Then
                            MessageBox.Show("Bu renk için maksimum 11 resim eklenebilir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Try : System.IO.File.Delete(tempFilePath) : Catch : End Try
                            Return
                        End If
                        
                        ' Resmi yükle ve byte array'e çevir
                        Dim imageBytes As Byte()
                        Using fs As New FileStream(tempFilePath, FileMode.Open, FileAccess.Read)
                            imageBytes = New Byte(fs.Length - 1) {}
                            fs.Read(imageBytes, 0, imageBytes.Length)
                        End Using
                        
                        ' R2'ye upload et - Firma klasör adını al
                        Dim klasor As String = ""
                        Try
                            Dim sourceIP As String = ""
                            Using conLocal As New OleDb.OleDbConnection(connection)
                                conLocal.Open()
                                Using cmdSource As New OleDb.OleDbCommand(
                                    "SELECT TOP 1 Lisans FROM tbParamGenel", conLocal)
                                    Dim resultLisans As Object = cmdSource.ExecuteScalar()
                                    If resultLisans IsNot Nothing AndAlso Not IsDBNull(resultLisans) Then
                                        sourceIP = resultLisans.ToString().Trim()
                                    End If
                                End Using
                            End Using
                            
                            If String.IsNullOrEmpty(sourceIP) Then
                                sourceIP = "212.156.206.214"
                            End If
                            
                            Dim sOnayKodu As String = ""
                            Try
                                sOnayKodu = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("Key").GetValue("sOnayKodu").ToString()
                            Catch
                                sOnayKodu = ""
                            End Try
                            
                            If Not String.IsNullOrEmpty(sOnayKodu) AndAlso sOnayKodu <> "0" Then
                                Dim remoteConnectionString As String = String.Format(
                                    "Provider=SQLOLEDB.1;Password=87918991;Persist Security Info=True;User ID=bayii1;Initial Catalog=BAYII;Data Source={0},8991",
                                    sourceIP)
                                
                                Try
                                    Using conRemote As New OleDb.OleDbConnection(remoteConnectionString)
                                        conRemote.Open()
                                        Using cmdKlasor As New OleDb.OleDbCommand(
                                            "SELECT TOP 1 tbFirma.sOzelNot " &
                                            "FROM tbFirmaLisans " &
                                            "INNER JOIN tbFirma ON tbFirmaLisans.nFirmaID = tbFirma.nFirmaID " &
                                            "WHERE tbFirmaLisans.sOnayKodu = ?", conRemote)
                                            cmdKlasor.Parameters.Add("sOnayKodu", OleDb.OleDbType.VarChar, 50).Value = sOnayKodu
                                            
                                            Dim resultKlasor As Object = cmdKlasor.ExecuteScalar()
                                            If resultKlasor IsNot Nothing AndAlso Not IsDBNull(resultKlasor) Then
                                                klasor = resultKlasor.ToString().Trim()
                                            End If
                                        End Using
                                    End Using
                                Catch ex As Exception
                                    klasor = ""
                                End Try
                            End If
                        Catch ex As Exception
                            klasor = ""
                        End Try
                        
                        ' R2'ye upload et - DOSYA ADI: sModel_sRenk_sBeden_sKavala_nSira.jpg
                        Dim fileNameParts As New List(Of String) From {sModel.Trim()}
                        If Not String.IsNullOrEmpty(sRenk) Then fileNameParts.Add(sRenk.Trim())
                        If Not String.IsNullOrEmpty(sBeden) Then fileNameParts.Add(sBeden.Trim())
                        If Not String.IsNullOrEmpty(sKavala) Then fileNameParts.Add(sKavala.Trim())
                        fileNameParts.Add(nSira.ToString())
                        
                        Dim fileName As String = String.Join("_", fileNameParts) & ".jpg"
                        Dim objectKey As String = If(String.IsNullOrEmpty(klasor),
                            "products/" & sModel.Trim() & "/" & fileName,
                            "products/" & klasor & "/" & sModel.Trim() & "/" & fileName)
                        
                        Debug.WriteLine($"[AI Resim] R2 dosya adı: {fileName}, Object key: {objectKey}")
                        Dim uploadedUrl As String = Await R2Helpers.R2UploadFromBytesAsync(imageBytes, objectKey, "image/jpeg")
                        
                        If String.IsNullOrEmpty(uploadedUrl) Then
                            MessageBox.Show("R2 upload başarısız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Try : System.IO.File.Delete(tempFilePath) : Catch : End Try
                            Return
                        End If
                        
                        ' Base64 encode
                        Dim base64String As String = Convert.ToBase64String(imageBytes)
                        Debug.WriteLine($"[AI Resim] Base64 boyutu: {base64String.Length} karakter")
                        
                        ' Database'e kaydet
                        Using con As New OleDb.OleDbConnection(connection)
                            con.Open()
                            
                            ' Transaction state'ini temizle
                            Try
                                Using cmdClean As New OleDb.OleDbCommand("IF @@TRANCOUNT > 0 ROLLBACK TRAN; SET IMPLICIT_TRANSACTIONS OFF", con)
                                    cmdClean.ExecuteNonQuery()
                                End Using
                            Catch ex As Exception
                                Debug.WriteLine($"[AI Resim] Temizleme hatası: {ex.Message}")
                            End Try
                            
                            ' Transaction başlat
                            Using cmdBegin As New OleDb.OleDbCommand("BEGIN TRAN", con)
                                cmdBegin.ExecuteNonQuery()
                                Debug.WriteLine("[AI Resim] BEGIN TRAN ✓")
                            End Using
                            
                            Try
                                ' Bu nSira'da zaten resim var mı kontrol et
                                Dim existingId As Object = Nothing
                                Using cmdCheck As New OleDb.OleDbCommand(
                                    "SELECT nStokResimID FROM tbStokResim WHERE (nStokID = ? OR (nStokID IS NULL AND sModel = ?)) AND nSira = ?", con)
                                    cmdCheck.Parameters.Add("p0", OleDb.OleDbType.Integer).Value = If(nStokID = 0, DBNull.Value, CObj(nStokID))
                                    cmdCheck.Parameters.Add("p1", OleDb.OleDbType.VarChar, 50).Value = sModel
                                    cmdCheck.Parameters.Add("p2", OleDb.OleDbType.Integer).Value = nSira
                                    existingId = cmdCheck.ExecuteScalar()
                                End Using
                                
                                If existingId Is Nothing Then
                                    ' Yeni satır ekle (INSERT)
                                    Using cmd As OleDb.OleDbCommand = con.CreateCommand()
                                        cmd.CommandText = "INSERT INTO tbStokResim (sModel, nStokID, sRenk, sBeden, sKavala, nSira, pResim, yol, sAciklama, sKullaniciAdi, dteKayitTarihi) " &
                                                         "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
                                        cmd.Parameters.Add("sModel", OleDb.OleDbType.VarChar, 50).Value = sModel
                                        cmd.Parameters.Add("nStokID", OleDb.OleDbType.Integer).Value = If(nStokID = 0, DBNull.Value, CObj(nStokID))
                                        cmd.Parameters.Add("sRenk", OleDb.OleDbType.VarChar, 10).Value = If(String.IsNullOrEmpty(sRenk), DBNull.Value, CObj(sRenk))
                                        cmd.Parameters.Add("sBeden", OleDb.OleDbType.VarChar, 10).Value = If(String.IsNullOrEmpty(sBeden), DBNull.Value, CObj(sBeden))
                                        cmd.Parameters.Add("sKavala", OleDb.OleDbType.VarChar, 10).Value = If(String.IsNullOrEmpty(sKavala), DBNull.Value, CObj(sKavala))
                                        cmd.Parameters.Add("nSira", OleDb.OleDbType.Integer).Value = nSira
                                        
                                        Dim pResimParam As New OleDb.OleDbParameter("pResim", OleDb.OleDbType.LongVarChar)
                                        pResimParam.Value = If(String.IsNullOrEmpty(base64String), DBNull.Value, CObj(base64String))
                                        cmd.Parameters.Add(pResimParam)
                                        
                                        cmd.Parameters.Add("yol", OleDb.OleDbType.VarChar, 500).Value = uploadedUrl
                                        cmd.Parameters.Add("sAciklama", OleDb.OleDbType.VarChar, 250).Value = "[AI Generated]"
                                        cmd.Parameters.Add("sKullaniciAdi", OleDb.OleDbType.VarChar, 50).Value = kullanici
                                        cmd.Parameters.Add("dteKayitTarihi", OleDb.OleDbType.DBTimeStamp).Value = Now
                                        
                                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                                        Debug.WriteLine($"[AI Resim] INSERT çalıştı → rowsAffected={rowsAffected}")
                                        
                                        If rowsAffected = 0 Then
                                            Throw New Exception("INSERT başarısız!")
                                        End If
                                    End Using
                                Else
                                    ' Mevcut satırı güncelle (UPDATE)
                                    Using cmd As OleDb.OleDbCommand = con.CreateCommand()
                                        cmd.CommandText = "UPDATE tbStokResim SET pResim = ?, yol = ?, nStokID = ?, sRenk = ?, sBeden = ?, sKavala = ?, sAciklama = ?, sKullaniciAdi = ?, dteKayitTarihi = ? " &
                                                         "WHERE (nStokID = ? OR (nStokID IS NULL AND sModel = ?)) AND nSira = ?"
                                        cmd.Parameters.Add("pResim", OleDb.OleDbType.LongVarChar).Value = base64String
                                        cmd.Parameters.Add("yol", OleDb.OleDbType.VarChar, 500).Value = uploadedUrl
                                        cmd.Parameters.Add("nStokID", OleDb.OleDbType.Integer).Value = If(nStokID = 0, DBNull.Value, CObj(nStokID))
                                        cmd.Parameters.Add("sRenk", OleDb.OleDbType.VarChar, 10).Value = If(String.IsNullOrEmpty(sRenk), DBNull.Value, CObj(sRenk))
                                        cmd.Parameters.Add("sBeden", OleDb.OleDbType.VarChar, 10).Value = If(String.IsNullOrEmpty(sBeden), DBNull.Value, CObj(sBeden))
                                        cmd.Parameters.Add("sKavala", OleDb.OleDbType.VarChar, 10).Value = If(String.IsNullOrEmpty(sKavala), DBNull.Value, CObj(sKavala))
                                        cmd.Parameters.Add("sAciklama", OleDb.OleDbType.VarChar, 250).Value = "[AI Generated]"
                                        cmd.Parameters.Add("sKullaniciAdi", OleDb.OleDbType.VarChar, 50).Value = kullanici
                                        cmd.Parameters.Add("dteKayitTarihi", OleDb.OleDbType.DBTimeStamp).Value = Now
                                        cmd.Parameters.Add("nStokID2", OleDb.OleDbType.Integer).Value = If(nStokID = 0, DBNull.Value, CObj(nStokID))
                                        cmd.Parameters.Add("sModel", OleDb.OleDbType.VarChar, 50).Value = sModel
                                        cmd.Parameters.Add("nSira", OleDb.OleDbType.Integer).Value = nSira
                                        
                                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                                        Debug.WriteLine($"[AI Resim] UPDATE çalıştı → rowsAffected={rowsAffected}")
                                        
                                        If rowsAffected = 0 Then
                                            Throw New Exception("UPDATE başarısız!")
                                        End If
                                    End Using
                                End If
                                
                                ' COMMIT
                                Using cmdCommit As New OleDb.OleDbCommand("COMMIT TRAN", con)
                                    cmdCommit.ExecuteNonQuery()
                                    Debug.WriteLine("[AI Resim] *** COMMIT TRAN ✓✓✓")
                                End Using
                                
                                ' Doğrulama
                                Using cmdVerify As New OleDb.OleDbCommand(
                                    "SELECT COUNT(*) FROM tbStokResim WHERE (nStokID = ? OR (nStokID IS NULL AND sModel = ?)) AND nSira = ?", con)
                                    cmdVerify.Parameters.Add("p0", OleDb.OleDbType.Integer).Value = If(nStokID = 0, DBNull.Value, CObj(nStokID))
                                    cmdVerify.Parameters.Add("p1", OleDb.OleDbType.VarChar, 50).Value = sModel
                                    cmdVerify.Parameters.Add("p2", OleDb.OleDbType.Integer).Value = nSira
                                    Dim count As Integer = CInt(cmdVerify.ExecuteScalar())
                                    Debug.WriteLine($"[AI Resim] DOĞRULAMA: Database'de kayıt sayısı = {count}")
                                    
                                    If count = 0 Then
                                        Throw New Exception("COMMIT sonrası kayıt bulunamadı!")
                                    End If
                                End Using
                                
                            Catch dbEx As Exception
                                ' ROLLBACK
                                Try
                                    Using cmdRollback As New OleDb.OleDbCommand("IF @@TRANCOUNT > 0 ROLLBACK TRAN", con)
                                        cmdRollback.ExecuteNonQuery()
                                        Debug.WriteLine("[AI Resim] *** ROLLBACK ✗✗✗")
                                    End Using
                                Catch rollbackEx As Exception
                                    Debug.WriteLine($"[AI Resim] ROLLBACK hatası: {rollbackEx.Message}")
                                End Try
                                
                                Throw dbEx
                            End Try
                        End Using
                        
                        ' Geçici dosyayı sil
                        Try : System.IO.File.Delete(tempFilePath) : Catch : End Try
                        
                        ' UI'ı yenile
                        Try
                            ds_tbStokResim = Dataload_tbStokResim(Trim(sModel))
                            If ds_tbStokResim IsNot Nothing AndAlso ds_tbStokResim.Tables.Count > 0 Then
                                GridControl6.DataSource = ds_tbStokResim.Tables(0)
                                GridControl6.RefreshDataSource()
                                GridView6.RefreshData()
                            End If
                            MessageBox.Show("✅ AI Görsel başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Catch ex As Exception
                            MessageBox.Show("Resim eklendi ancak yenilemede hata: " & ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End Try
                        
                        Cursor.Current = Cursors.Default
                        
                    Catch ex As Exception
                        Cursor.Current = Cursors.Default
                        MessageBox.Show("Hata: " & ex.Message & vbCrLf & vbCrLf & 
                                       "Stack Trace: " & ex.StackTrace, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Debug.WriteLine($"[AI Resim] HATA: {ex.Message}")
                    End Try
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btnAIAciklamaEkle_Click(sender As Object, e As EventArgs) Handles btnAIAciklamaEkle.Click
        Try
            If nStokID = 0 Then
                MessageBox.Show("Önce ürün kartını kaydetmelisiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            
            Dim result As DialogResult = MessageBox.Show(
                "Bu ürün için AI ile KAPSAMLI içerik oluşturulacak:" & vbCrLf & vbCrLf &
                "✅ Detaylı Açıklama (300-400 kelime)" & vbCrLf &
                "✅ Kısa Açıklama" & vbCrLf &
                "✅ Ürün Özellikleri" & vbCrLf &
                "✅ Bakım Talimatları" & vbCrLf &
                "✅ SEO Başlık & Meta" & vbCrLf &
                "✅ Anahtar Kelimeler" & vbCrLf &
                "✅ Beden Tablosu (varsa şablondan)" & vbCrLf & vbCrLf &
                "Tahmini maliyet: ~0.35 TL" & vbCrLf & vbCrLf &
                "Devam etmek istiyor musunuz?",
                "AI Kapsamlı İçerik Oluştur",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
            
            If result = DialogResult.Yes Then
                ' Progress göster
                Me.Cursor = Cursors.WaitCursor
                Application.DoEvents()
                
                ' AI servisini başlat
                Dim aiService As New AIService()
                
                ' Ürün verilerini hazırla
                Dim productData As New Dictionary(Of String, Object)
                
                If Not String.IsNullOrEmpty(txt_sAdi.Text) Then
                    productData("sAciklama") = txt_sAdi.Text
                Else
                    Me.Cursor = Cursors.Default
                    MessageBox.Show("Ürün adı boş! Lütfen önce ürün adını girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                
                ' Ek bilgileri ekle
                productData("sKodu") = Me.sKodu
                productData("sModel") = Me.sModel
                productData("sMarka") = ""
                productData("sKategori") = ""
                productData("sCinsiyet") = ""
                productData("sYasGrubu") = ""
                productData("sKumasBilgisi") = ""
                productData("sRenkler") = ""
                productData("sBedenler") = ""
                
                ' KAPSAMLI İÇERİK OLUŞTUR (TEK API ÇAĞRISI)
                Dim completeContent As Dictionary(Of String, String) = aiService.GenerateCompleteContent(productData)
                
                Me.Cursor = Cursors.Default
                
                If completeContent("success") = "true" Then
                    ' Başarılı - Önizleme formunu göster
                    ShowCompleteContentPreview(completeContent, aiService, productData)
                Else
                    ' Hata durumu
                    Dim errorMsg As String = "❌ AI içerik oluşturulamadı!" & vbCrLf & vbCrLf
                    
                    If completeContent.ContainsKey("error") Then
                        If completeContent("error").Contains("API key") Then
                            errorMsg &= "Sebep: Emergent LLM Key girilmemiş" & vbCrLf
                            errorMsg &= "Çözüm: Sistem > AI Sistemi > AI Ayarları menüsünden API key girin"
                        Else
                            errorMsg &= "Sebep: " & completeContent("error")
                        End If
                    Else
                        errorMsg &= "Bilinmeyen hata oluştu."
                    End If
                    
                    MessageBox.Show(errorMsg, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ''' <summary>
    ''' Kapsamlı içerik önizleme formu
    ''' </summary>
    Private Sub ShowCompleteContentPreview(content As Dictionary(Of String, String), aiService As AIService, productData As Dictionary(Of String, Object))
        Dim previewForm As New Form()
        previewForm.Text = "🤖 AI Kapsamlı İçerik Önizleme"
        previewForm.Size = New Size(900, 700)
        previewForm.StartPosition = FormStartPosition.CenterParent
        previewForm.FormBorderStyle = FormBorderStyle.Sizable
        previewForm.MinimumSize = New Size(800, 600)
        
        ' Tab Control
        Dim tabControl As New TabControl()
        tabControl.Dock = DockStyle.Top
        tabControl.Height = 550
        
        ' 1. Açıklama Sekmesi
        Dim tabAciklama As New TabPage("📝 Açıklama")
        Dim txtAciklama As New TextBox() With {
            .Multiline = True,
            .ScrollBars = ScrollBars.Vertical,
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 10),
            .Text = If(content.ContainsKey("description"), content("description"), "")
        }
        tabAciklama.Controls.Add(txtAciklama)
        tabControl.TabPages.Add(tabAciklama)
        
        ' 2. Kısa Açıklama Sekmesi
        Dim tabKisa As New TabPage("📋 Kısa Açıklama")
        Dim txtKisa As New TextBox() With {
            .Multiline = True,
            .ScrollBars = ScrollBars.Vertical,
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 10),
            .Text = If(content.ContainsKey("shortDescription"), content("shortDescription"), "")
        }
        tabKisa.Controls.Add(txtKisa)
        tabControl.TabPages.Add(tabKisa)
        
        ' 3. Özellikler Sekmesi
        Dim tabOzellik As New TabPage("✨ Özellikler")
        Dim txtOzellik As New TextBox() With {
            .Multiline = True,
            .ScrollBars = ScrollBars.Vertical,
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 10),
            .Text = If(content.ContainsKey("featuresHtml"), content("featuresHtml"), "")
        }
        tabOzellik.Controls.Add(txtOzellik)
        tabControl.TabPages.Add(tabOzellik)
        
        ' 4. Bakım Talimatları Sekmesi
        Dim tabBakim As New TabPage("🧺 Bakım")
        Dim txtBakim As New TextBox() With {
            .Multiline = True,
            .ScrollBars = ScrollBars.Vertical,
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 10),
            .Text = If(content.ContainsKey("careInstructions"), content("careInstructions"), "")
        }
        tabBakim.Controls.Add(txtBakim)
        tabControl.TabPages.Add(tabBakim)
        
        ' 5. SEO Sekmesi
        Dim tabSEO As New TabPage("🔍 SEO")
        Dim pnlSEO As New Panel() With {.Dock = DockStyle.Fill, .Padding = New Padding(10)}
        
        Dim lblSeoTitle As New Label() With {.Text = "SEO Başlık:", .Location = New Point(10, 10), .AutoSize = True}
        Dim txtSeoTitle As New TextBox() With {
            .Location = New Point(10, 30),
            .Size = New Size(820, 25),
            .Font = New Font("Segoe UI", 10),
            .Text = If(content.ContainsKey("seoTitle"), content("seoTitle"), "")
        }
        
        Dim lblMeta As New Label() With {.Text = "Meta Açıklama:", .Location = New Point(10, 70), .AutoSize = True}
        Dim txtMeta As New TextBox() With {
            .Location = New Point(10, 90),
            .Size = New Size(820, 60),
            .Multiline = True,
            .Font = New Font("Segoe UI", 10),
            .Text = If(content.ContainsKey("metaDescription"), content("metaDescription"), "")
        }
        
        Dim lblKeywords As New Label() With {.Text = "Anahtar Kelimeler:", .Location = New Point(10, 170), .AutoSize = True}
        Dim txtKeywords As New TextBox() With {
            .Location = New Point(10, 190),
            .Size = New Size(820, 60),
            .Multiline = True,
            .Font = New Font("Segoe UI", 10),
            .Text = If(content.ContainsKey("keywords"), content("keywords"), "")
        }
        
        pnlSEO.Controls.AddRange({lblSeoTitle, txtSeoTitle, lblMeta, txtMeta, lblKeywords, txtKeywords})
        tabSEO.Controls.Add(pnlSEO)
        tabControl.TabPages.Add(tabSEO)
        
        ' 6. Beden Tablosu Sekmesi
        Dim tabBeden As New TabPage("📏 Beden Tablosu")
        Dim txtBeden As New TextBox() With {
            .Multiline = True,
            .ScrollBars = ScrollBars.Vertical,
            .Dock = DockStyle.Fill,
            .Font = New Font("Segoe UI", 10)
        }
        ' Beden tablosu oluştur
        Try
            Dim kategori As String = If(productData.ContainsKey("sKategori"), productData("sKategori").ToString(), "")
            Dim cinsiyet As String = If(productData.ContainsKey("sCinsiyet"), productData("sCinsiyet").ToString(), "")
            Dim yasGrubu As String = If(productData.ContainsKey("sYasGrubu"), productData("sYasGrubu").ToString(), "")
            Dim bedenler As String = If(productData.ContainsKey("sBedenler"), productData("sBedenler").ToString(), "")
            txtBeden.Text = aiService.GenerateSizeChart(kategori, cinsiyet, yasGrubu, bedenler)
        Catch
            txtBeden.Text = "Beden tablosu oluşturulamadı"
        End Try
        tabBeden.Controls.Add(txtBeden)
        tabControl.TabPages.Add(tabBeden)
        
        previewForm.Controls.Add(tabControl)
        
        ' İçerik Puanı
        Dim contentScore As Integer = aiService.CalculateContentScore(content)
        Dim lblScore As New Label() With {
            .Text = $"📊 İçerik Kalite Puanı: {contentScore}/100",
            .Location = New Point(20, 560),
            .Size = New Size(300, 30),
            .Font = New Font("Segoe UI", 12, FontStyle.Bold),
            .ForeColor = If(contentScore >= 70, Color.Green, If(contentScore >= 50, Color.Orange, Color.Red))
        }
        previewForm.Controls.Add(lblScore)
        
        ' Butonlar
        Dim btnKaydet As New Button() With {
            .Text = "✅ Tümünü Kaydet",
            .Location = New Point(550, 610),
            .Size = New Size(150, 45),
            .BackColor = Color.Green,
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 11, FontStyle.Bold)
        }
        AddHandler btnKaydet.Click, Sub()
            Try
                SaveCompleteContent(txtAciklama.Text, txtKisa.Text, txtOzellik.Text, txtBakim.Text, 
                                   txtSeoTitle.Text, txtMeta.Text, txtKeywords.Text, txtBeden.Text, contentScore)
                MessageBox.Show("✅ Tüm içerikler başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                previewForm.DialogResult = DialogResult.OK
                previewForm.Close()
            Catch ex As Exception
                MessageBox.Show("Kayıt hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
        previewForm.Controls.Add(btnKaydet)
        
        Dim btnIptal As New Button() With {
            .Text = "❌ İptal",
            .Location = New Point(720, 610),
            .Size = New Size(130, 45),
            .BackColor = Color.Gray,
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 11, FontStyle.Bold)
        }
        AddHandler btnIptal.Click, Sub()
            previewForm.DialogResult = DialogResult.Cancel
            previewForm.Close()
        End Sub
        previewForm.Controls.Add(btnIptal)
        
        previewForm.ShowDialog()
    End Sub
    
    ''' <summary>
    ''' Kapsamlı içeriği veritabanına kaydet
    ''' </summary>
    Private Sub SaveCompleteContent(aciklama As String, kisaAciklama As String, ozellikler As String, 
                                    bakimTalimati As String, seoBaslik As String, metaAciklama As String,
                                    anahtarKelimeler As String, bedenTablosu As String, icerikPuani As Integer)
        Using conn As New OleDb.OleDbConnection(connection)
            conn.Open()
            
            ' 1. tbStokUzunNot tablosunu güncelle
            Dim checkCmd As New OleDb.OleDbCommand("SELECT COUNT(*) FROM tbStokUzunNot WHERE sModel = ?", conn)
            checkCmd.Parameters.AddWithValue("?", Me.sModel)
            Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
            
            If exists > 0 Then
                Dim updateCmd As New OleDb.OleDbCommand(
                    "UPDATE tbStokUzunNot SET sUzunNot = ?, sBedenTablosu = ?, sOzellikler = ?, " &
                    "sKullanimTalimati = ?, sSonKullaniciAdi = ?, dteSonUpdateTarihi = ? WHERE sModel = ?", conn)
                updateCmd.Parameters.AddWithValue("?", aciklama)
                updateCmd.Parameters.AddWithValue("?", bedenTablosu)
                updateCmd.Parameters.AddWithValue("?", ozellikler)
                updateCmd.Parameters.AddWithValue("?", bakimTalimati)
                updateCmd.Parameters.AddWithValue("?", kullanici)
                updateCmd.Parameters.AddWithValue("?", DateTime.Now)
                updateCmd.Parameters.AddWithValue("?", Me.sModel)
                updateCmd.ExecuteNonQuery()
            Else
                Dim insertCmd As New OleDb.OleDbCommand(
                    "INSERT INTO tbStokUzunNot (sModel, sUzunNot, sBedenTablosu, sOzellikler, sKullanimTalimati, " &
                    "sSonKullaniciAdi, dteSonUpdateTarihi) VALUES (?, ?, ?, ?, ?, ?, ?)", conn)
                insertCmd.Parameters.AddWithValue("?", Me.sModel)
                insertCmd.Parameters.AddWithValue("?", aciklama)
                insertCmd.Parameters.AddWithValue("?", bedenTablosu)
                insertCmd.Parameters.AddWithValue("?", ozellikler)
                insertCmd.Parameters.AddWithValue("?", bakimTalimati)
                insertCmd.Parameters.AddWithValue("?", kullanici)
                insertCmd.Parameters.AddWithValue("?", DateTime.Now)
                insertCmd.ExecuteNonQuery()
            End If
            
            ' 2. tbStokAIIcerik tablosunu güncelle (varsa)
            Try
                Dim checkAI As New OleDb.OleDbCommand("SELECT COUNT(*) FROM tbStokAIIcerik WHERE sModel = ?", conn)
                checkAI.Parameters.AddWithValue("?", Me.sModel)
                Dim existsAI As Integer = Convert.ToInt32(checkAI.ExecuteScalar())
                
                If existsAI > 0 Then
                    Dim updateAI As New OleDb.OleDbCommand(
                        "UPDATE tbStokAIIcerik SET sUzunNot = ?, sKisaAciklama = ?, sOzelliklerHTML = ?, " &
                        "sKullanimTalimati = ?, sSEOBaslik = ?, sMetaDescription = ?, sAnahtarKelimeler = ?, " &
                        "sBedenTablosu = ?, nIcerikPuani = ?, dteGuncellemeTarihi = ? WHERE sModel = ?", conn)
                    updateAI.Parameters.AddWithValue("?", aciklama)
                    updateAI.Parameters.AddWithValue("?", kisaAciklama)
                    updateAI.Parameters.AddWithValue("?", ozellikler)
                    updateAI.Parameters.AddWithValue("?", bakimTalimati)
                    updateAI.Parameters.AddWithValue("?", seoBaslik)
                    updateAI.Parameters.AddWithValue("?", metaAciklama)
                    updateAI.Parameters.AddWithValue("?", anahtarKelimeler)
                    updateAI.Parameters.AddWithValue("?", bedenTablosu)
                    updateAI.Parameters.AddWithValue("?", icerikPuani)
                    updateAI.Parameters.AddWithValue("?", DateTime.Now)
                    updateAI.Parameters.AddWithValue("?", Me.sModel)
                    updateAI.ExecuteNonQuery()
                Else
                    Dim insertAI As New OleDb.OleDbCommand(
                        "INSERT INTO tbStokAIIcerik (sModel, sUzunNot, sKisaAciklama, sOzelliklerHTML, " &
                        "sKullanimTalimati, sSEOBaslik, sMetaDescription, sAnahtarKelimeler, sBedenTablosu, " &
                        "nIcerikPuani, dteOlusturmaTarihi, dteGuncellemeTarihi) " &
                        "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", conn)
                    insertAI.Parameters.AddWithValue("?", Me.sModel)
                    insertAI.Parameters.AddWithValue("?", aciklama)
                    insertAI.Parameters.AddWithValue("?", kisaAciklama)
                    insertAI.Parameters.AddWithValue("?", ozellikler)
                    insertAI.Parameters.AddWithValue("?", bakimTalimati)
                    insertAI.Parameters.AddWithValue("?", seoBaslik)
                    insertAI.Parameters.AddWithValue("?", metaAciklama)
                    insertAI.Parameters.AddWithValue("?", anahtarKelimeler)
                    insertAI.Parameters.AddWithValue("?", bedenTablosu)
                    insertAI.Parameters.AddWithValue("?", icerikPuani)
                    insertAI.Parameters.AddWithValue("?", DateTime.Now)
                    insertAI.Parameters.AddWithValue("?", DateTime.Now)
                    insertAI.ExecuteNonQuery()
                End If
            Catch
                ' tbStokAIIcerik tablosu yoksa görmezden gel
            End Try
            
            ' 3. tbStok tablosunda AI içerik var işaretle
            Try
                Dim updateStok As New OleDb.OleDbCommand("UPDATE tbStok SET bAIIcerikVar = 1 WHERE sModel = ?", conn)
                updateStok.Parameters.AddWithValue("?", Me.sModel)
                updateStok.ExecuteNonQuery()
            Catch
            End Try
        End Using
        
        ' Ekranı yenile
        Dataload_tbStokUzunNot(Me.sModel)
        txt_sUzunNot.Text = aciklama
    End Sub

    ' ============================================================================
    ' AI SEKMELERİNİ OLUŞTUR
    ' ============================================================================
    Private Sub frm_stok_kart_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Not aiTabsInitialized Then
            Try
                InitializeAITabs()
                aiTabsInitialized = True
            Catch ex As Exception
                ' Hata oluşursa sessizce devam et
            End Try
        End If
    End Sub
    
    Private Sub InitializeAITabs()
        If XtraTabControl1 Is Nothing Then Exit Sub
        
        ' 1. SEO Başlık Sekmesi
        XtraTabPage_SEOBaslik = New DevExpress.XtraTab.XtraTabPage()
        XtraTabPage_SEOBaslik.Name = "XtraTabPage_SEOBaslik"
        XtraTabPage_SEOBaslik.Text = "SEO Başlık"
        XtraTabPage_SEOBaslik.Size = New System.Drawing.Size(1355, 480)
        
        lblSEOBaslikInfo = New DevExpress.XtraEditors.LabelControl()
        lblSEOBaslikInfo.Text = "AI ile SEO uyumlu ürün başlığı oluşturun (Maksimum 100 karakter)"
        lblSEOBaslikInfo.Location = New System.Drawing.Point(20, 20)
        lblSEOBaslikInfo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        lblSEOBaslikInfo.Size = New System.Drawing.Size(800, 20)
        XtraTabPage_SEOBaslik.Controls.Add(lblSEOBaslikInfo)
        
        btnSEOBaslikOlustur = New DevExpress.XtraEditors.SimpleButton()
        btnSEOBaslikOlustur.Text = "SEO Başlık Oluştur"
        btnSEOBaslikOlustur.Location = New System.Drawing.Point(20, 50)
        btnSEOBaslikOlustur.Size = New System.Drawing.Size(200, 35)
        AddHandler btnSEOBaslikOlustur.Click, AddressOf btnSEOBaslikOlustur_Click
        XtraTabPage_SEOBaslik.Controls.Add(btnSEOBaslikOlustur)
        
        txtSEOBaslik = New DevExpress.XtraEditors.MemoEdit()
        txtSEOBaslik.Location = New System.Drawing.Point(20, 100)
        txtSEOBaslik.Size = New System.Drawing.Size(1300, 350)
        XtraTabPage_SEOBaslik.Controls.Add(txtSEOBaslik)
        
        XtraTabControl1.TabPages.Add(XtraTabPage_SEOBaslik)
        
        ' 2. Kullanım Talimatı Sekmesi
        XtraTabPage_KullanimTalimati = New DevExpress.XtraTab.XtraTabPage()
        XtraTabPage_KullanimTalimati.Name = "XtraTabPage_KullanimTalimati"
        XtraTabPage_KullanimTalimati.Text = "Kullanım Talimatı"
        XtraTabPage_KullanimTalimati.Size = New System.Drawing.Size(1355, 480)
        
        lblKullanimTalimatiInfo = New DevExpress.XtraEditors.LabelControl()
        lblKullanimTalimatiInfo.Text = "Ürün için kullanım ve bakım talimatları oluşturun"
        lblKullanimTalimatiInfo.Location = New System.Drawing.Point(20, 20)
        lblKullanimTalimatiInfo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        lblKullanimTalimatiInfo.Size = New System.Drawing.Size(800, 20)
        XtraTabPage_KullanimTalimati.Controls.Add(lblKullanimTalimatiInfo)
        
        btnKullanimTalimatiOlustur = New DevExpress.XtraEditors.SimpleButton()
        btnKullanimTalimatiOlustur.Text = "Kullanım Talimatı Oluştur"
        btnKullanimTalimatiOlustur.Location = New System.Drawing.Point(20, 50)
        btnKullanimTalimatiOlustur.Size = New System.Drawing.Size(220, 35)
        AddHandler btnKullanimTalimatiOlustur.Click, AddressOf btnKullanimTalimatiOlustur_Click
        XtraTabPage_KullanimTalimati.Controls.Add(btnKullanimTalimatiOlustur)
        
        txtKullanimTalimati = New DevExpress.XtraEditors.MemoEdit()
        txtKullanimTalimati.Location = New System.Drawing.Point(20, 100)
        txtKullanimTalimati.Size = New System.Drawing.Size(1300, 350)
        XtraTabPage_KullanimTalimati.Controls.Add(txtKullanimTalimati)
        
        XtraTabControl1.TabPages.Add(XtraTabPage_KullanimTalimati)
        
        ' 3. Meta Açıklama Sekmesi
        XtraTabPage_MetaAciklama = New DevExpress.XtraTab.XtraTabPage()
        XtraTabPage_MetaAciklama.Name = "XtraTabPage_MetaAciklama"
        XtraTabPage_MetaAciklama.Text = "Meta Açıklama"
        XtraTabPage_MetaAciklama.Size = New System.Drawing.Size(1355, 480)
        
        lblMetaAciklamaInfo = New DevExpress.XtraEditors.LabelControl()
        lblMetaAciklamaInfo.Text = "SEO meta açıklaması oluşturun (Maksimum 160 karakter)"
        lblMetaAciklamaInfo.Location = New System.Drawing.Point(20, 20)
        lblMetaAciklamaInfo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        lblMetaAciklamaInfo.Size = New System.Drawing.Size(800, 20)
        XtraTabPage_MetaAciklama.Controls.Add(lblMetaAciklamaInfo)
        
        btnMetaAciklamaOlustur = New DevExpress.XtraEditors.SimpleButton()
        btnMetaAciklamaOlustur.Text = "Meta Açıklama Oluştur"
        btnMetaAciklamaOlustur.Location = New System.Drawing.Point(20, 50)
        btnMetaAciklamaOlustur.Size = New System.Drawing.Size(210, 35)
        AddHandler btnMetaAciklamaOlustur.Click, AddressOf btnMetaAciklamaOlustur_Click
        XtraTabPage_MetaAciklama.Controls.Add(btnMetaAciklamaOlustur)
        
        txtMetaAciklama = New DevExpress.XtraEditors.MemoEdit()
        txtMetaAciklama.Location = New System.Drawing.Point(20, 100)
        txtMetaAciklama.Size = New System.Drawing.Size(1300, 200)
        XtraTabPage_MetaAciklama.Controls.Add(txtMetaAciklama)
        
        XtraTabControl1.TabPages.Add(XtraTabPage_MetaAciklama)
        
        ' Sınıflar sekmesine AI butonu ekle (Grid'in altına)
        If XtraTabPage2 IsNot Nothing Then
            ' GridControl'ün Dock'unu değiştir
            If GridControl1 IsNot Nothing Then
                GridControl1.Dock = DockStyle.None
                GridControl1.Location = New System.Drawing.Point(0, 0)
                GridControl1.Size = New System.Drawing.Size(XtraTabPage2.Width, XtraTabPage2.Height - 55)
                GridControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            End If
            
            ' AI butonu grid'in altında, sağ tarafta
            btnKategoriOner = New DevExpress.XtraEditors.SimpleButton()
            btnKategoriOner.Text = "🤖 AI ile Kategori Öner"
            btnKategoriOner.Size = New System.Drawing.Size(220, 45)
            btnKategoriOner.Location = New System.Drawing.Point(XtraTabPage2.Width - 230, XtraTabPage2.Height - 50)
            btnKategoriOner.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
            AddHandler btnKategoriOner.Click, AddressOf btnKategoriOner_Click
            XtraTabPage2.Controls.Add(btnKategoriOner)
            btnKategoriOner.BringToFront()
        End If
        
        ' 5. Fiyat Optimizasyonu Sekmesi
        XtraTabPage_FiyatOptimize = New DevExpress.XtraTab.XtraTabPage()
        XtraTabPage_FiyatOptimize.Name = "XtraTabPage_FiyatOptimize"
        XtraTabPage_FiyatOptimize.Text = "Fiyat Optimizasyonu"
        XtraTabPage_FiyatOptimize.Size = New System.Drawing.Size(1355, 480)
        
        lblFiyatOptimizeInfo = New DevExpress.XtraEditors.LabelControl()
        lblFiyatOptimizeInfo.Text = "AI ile ürün fiyat analizi ve önerisi alın"
        lblFiyatOptimizeInfo.Location = New System.Drawing.Point(20, 20)
        lblFiyatOptimizeInfo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        lblFiyatOptimizeInfo.Size = New System.Drawing.Size(800, 20)
        XtraTabPage_FiyatOptimize.Controls.Add(lblFiyatOptimizeInfo)
        
        btnFiyatOptimize = New DevExpress.XtraEditors.SimpleButton()
        btnFiyatOptimize.Text = "Fiyat Optimize Et"
        btnFiyatOptimize.Location = New System.Drawing.Point(20, 50)
        btnFiyatOptimize.Size = New System.Drawing.Size(180, 35)
        AddHandler btnFiyatOptimize.Click, AddressOf btnFiyatOptimize_Click
        XtraTabPage_FiyatOptimize.Controls.Add(btnFiyatOptimize)
        
        txtFiyatOptimize = New DevExpress.XtraEditors.MemoEdit()
        txtFiyatOptimize.Location = New System.Drawing.Point(20, 100)
        txtFiyatOptimize.Size = New System.Drawing.Size(1300, 350)
        XtraTabPage_FiyatOptimize.Controls.Add(txtFiyatOptimize)
        
        XtraTabControl1.TabPages.Add(XtraTabPage_FiyatOptimize)
        
        ' Mevcut verileri yükle
        LoadAIContent()
    End Sub
    
    ' ============================================================================
    ' BUTON CLICK HANDLER'LARI
    ' ============================================================================
    
    Private Sub btnSEOBaslikOlustur_Click(sender As Object, e As EventArgs)
        If String.IsNullOrEmpty(Me.sKodu) Then
            MessageBox.Show("Lütfen önce bir ürün seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        Try
            btnSEOBaslikOlustur.Enabled = False
            btnSEOBaslikOlustur.Text = "Oluşturuluyor..."
            Application.DoEvents()
            
            ' ===== PARAMETRİK SINIF BİLGİLERİNİ AL =====
            Dim marka As String = ""
            Dim kategori1 As String = ""
            Dim kategori2 As String = ""
            
            Try
                ' tbSistemAyar'dan hangi sınıfın ne olduğunu oku
                Dim markaField As String = GetSinifAyar("ETICARET_SINIF_MARKA", "sSinifKodu5")
                Dim kat1Field As String = GetSinifAyar("ETICARET_SINIF_KAT1", "sSinifKodu4")
                Dim kat2Field As String = GetSinifAyar("ETICARET_SINIF_KAT2", "sSinifKodu3")
                
                ' Sınıf değerlerini al (açıklama olarak)
                marka = GetSinifAciklama(markaField)
                kategori1 = GetSinifAciklama(kat1Field)
                kategori2 = GetSinifAciklama(kat2Field)
                
                System.Diagnostics.Debug.WriteLine($"SEO Başlık - Marka: {marka}, Kat1: {kategori1}, Kat2: {kategori2}")
            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine($"Sınıf bilgisi alınamadı: {ex.Message}")
            End Try
            
            ' Kategori bilgisini birleştir
            Dim tumKategori As String = kategori1
            If Not String.IsNullOrEmpty(kategori2) Then
                tumKategori = kategori1 & " > " & kategori2
            End If
            
            Dim aiService As New AIService()
            Dim productData As New Dictionary(Of String, Object) From {
                {"sAciklama", Me.txt_sAdi.Text},
                {"sMarka", marka},
                {"sKategori", tumKategori},
                {"sModel", Me.txt_musteriNo.Text},
                {"sRenk", ""}
            }
            
            Dim baslik As String = aiService.GenerateTitle(productData)
            
            If Not String.IsNullOrEmpty(baslik) AndAlso Not baslik.Contains("API key bulunamadı") Then
                txtSEOBaslik.Text = baslik
                SaveAIContent("sSEOBaslik", baslik)
                MessageBox.Show("SEO başlık başarıyla oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Hata: " & baslik, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnSEOBaslikOlustur.Enabled = True
            btnSEOBaslikOlustur.Text = "SEO Başlık Oluştur"
        End Try
    End Sub
    
    ''' <summary>
    ''' tbSistemAyar'dan sınıf eşleştirme ayarını okur
    ''' </summary>
    Private Function GetSinifAyar(ayarKodu As String, varsayilan As String) As String
        Try
            Dim deger As String = sorgu_geri($"SELECT sAyarDeger FROM tbSistemAyar WHERE sAyarKodu = '{ayarKodu}'")
            Return If(String.IsNullOrEmpty(deger), varsayilan, deger)
        Catch
            Return varsayilan
        End Try
    End Function
    
    ''' <summary>
    ''' Sınıf kodundan açıklama değerini döndürür
    ''' </summary>
    Private Function GetSinifAciklama(sinifField As String) As String
        Try
            If String.IsNullOrEmpty(sinifField) Then Return ""
            
            ' sSinifKodu3 -> 3 numaralı sınıf tablosu
            Dim sinifNo As String = sinifField.Replace("sSinifKodu", "")
            Dim sinifKodu As String = ""
            
            ' Form'daki sınıf değerlerinden ilgili olanı al
            Select Case sinifNo
                Case "1" : sinifKodu = Me.sSinifKodu1
                Case "2" : sinifKodu = Me.sSinifKodu2
                Case "3" : sinifKodu = Me.sSinifKodu3
                Case "4" : sinifKodu = Me.sSinifKodu4
                Case "5" : sinifKodu = Me.sSinifKodu5
                Case "6" : sinifKodu = Me.sSinifKodu6
                Case "7" : sinifKodu = Me.sSinifKodu7
                Case "8" : sinifKodu = Me.sSinifKodu8
                Case "9" : sinifKodu = Me.sSinifKodu9
                Case "10" : sinifKodu = Me.sSinifKodu10
                Case Else : Return ""
            End Select
            
            If String.IsNullOrEmpty(sinifKodu) Then Return ""
            
            ' Sınıf tablosundan açıklamayı al
            Dim aciklama As String = sorgu_geri($"SELECT sAciklama FROM tbSSinif{sinifNo} WHERE sSinifKodu = '{sinifKodu}'")
            Return If(String.IsNullOrEmpty(aciklama), "", aciklama.Trim())
        Catch
            Return ""
        End Try
    End Function
    
    Private Sub btnKullanimTalimatiOlustur_Click(sender As Object, e As EventArgs)
        If String.IsNullOrEmpty(Me.sKodu) Then
            MessageBox.Show("Lütfen önce bir ürün seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        Try
            btnKullanimTalimatiOlustur.Enabled = False
            btnKullanimTalimatiOlustur.Text = "Oluşturuluyor..."
            Application.DoEvents()
            
            ' Parametrik sınıf bilgilerini al
            Dim kategori1 As String = ""
            Dim kategori2 As String = ""
            Try
                Dim kat1Field As String = GetSinifAyar("ETICARET_SINIF_KAT1", "sSinifKodu4")
                Dim kat2Field As String = GetSinifAyar("ETICARET_SINIF_KAT2", "sSinifKodu3")
                kategori1 = GetSinifAciklama(kat1Field)
                kategori2 = GetSinifAciklama(kat2Field)
            Catch
            End Try
            
            Dim tumKategori As String = kategori1
            If Not String.IsNullOrEmpty(kategori2) Then
                tumKategori = kategori1 & " > " & kategori2
            End If
            
            Dim aiService As New AIService()
            Dim productData As New Dictionary(Of String, Object) From {
                {"sAciklama", Me.txt_sAdi.Text},
                {"sKategoriAdi", tumKategori},
                {"sKategori", tumKategori}
            }
            
            Dim talimat As String = aiService.GenerateInstructions(productData)
            
            If Not String.IsNullOrEmpty(talimat) AndAlso Not talimat.Contains("API key bulunamadı") Then
                txtKullanimTalimati.Text = talimat
                SaveAIContent("sKullanimTalimati", talimat)
                MessageBox.Show("Kullanım talimatı başarıyla oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Hata: " & talimat, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnKullanimTalimatiOlustur.Enabled = True
            btnKullanimTalimatiOlustur.Text = "Kullanım Talimatı Oluştur"
        End Try
    End Sub
    
    Private Sub btnMetaAciklamaOlustur_Click(sender As Object, e As EventArgs)
        If String.IsNullOrEmpty(Me.sKodu) Then
            MessageBox.Show("Lütfen önce bir ürün seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        Try
            btnMetaAciklamaOlustur.Enabled = False
            btnMetaAciklamaOlustur.Text = "Oluşturuluyor..."
            Application.DoEvents()
            
            ' Parametrik sınıf bilgilerini al
            Dim marka As String = ""
            Dim kategori1 As String = ""
            Try
                Dim markaField As String = GetSinifAyar("ETICARET_SINIF_MARKA", "sSinifKodu5")
                Dim kat1Field As String = GetSinifAyar("ETICARET_SINIF_KAT1", "sSinifKodu4")
                marka = GetSinifAciklama(markaField)
                kategori1 = GetSinifAciklama(kat1Field)
            Catch
            End Try
            
            Dim aiService As New AIService()
            Dim productData As New Dictionary(Of String, Object) From {
                {"sAciklama", Me.txt_sAdi.Text},
                {"sMarka", marka},
                {"sKategori", kategori1}
            }
            
            Dim meta As String = aiService.GenerateMetaDescription(productData)
            
            If Not String.IsNullOrEmpty(meta) AndAlso Not meta.Contains("API key bulunamadı") Then
                txtMetaAciklama.Text = meta
                SaveAIContent("sMetaDescription", meta)
                MessageBox.Show("Meta açıklama başarıyla oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Hata: " & meta, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnMetaAciklamaOlustur.Enabled = True
            btnMetaAciklamaOlustur.Text = "Meta Açıklama Oluştur"
        End Try
    End Sub
    
    Private Sub btnKategoriOner_Click(sender As Object, e As EventArgs)
        If String.IsNullOrEmpty(Me.sKodu) Then
            MessageBox.Show("Lütfen önce bir ürün seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        Try
            btnKategoriOner.Enabled = False
            btnKategoriOner.Text = "⏳ Oluşturuluyor..."
            Application.DoEvents()
            
            Dim aiService As New AIService()
            Dim prompt As String = $"Aşağıdaki ürün için kategorileri öner:

Ürün: {Me.txt_sAdi.Text}

Format (TAM BU FORMATTA DÖNDÜR):
Marka: [marka adı]
Ana Kategori: [kategori adı]
Alt Kategori: [alt kategori adı]
Cinsiyet: [Erkek/Kadın/Unisex/Çocuk]
Etiket 1: [etiket1]
Etiket 2: [etiket2]
Etiket 3: [etiket3]
Etiket 4: [etiket4]
Etiket 5: [etiket5]
Etiket 6: [etiket6]
Etiket 7: [etiket7]

SADECE BU 11 SATIRI DÖNDÜR!"
            
            Dim kategori As String = aiService.CallOpenAI(prompt, 150)
            
            If Not String.IsNullOrEmpty(kategori) AndAlso Not kategori.Contains("API key bulunamadı") Then
                ' AI içeriği kaydet
                SaveAIContent("sKategoriOner", kategori)
                
                ' Kategorileri parse et ve sisteme ekle
                ParseAndAddCategories(kategori)
                
                MessageBox.Show("✅ AI kategorileri oluşturuldu ve otomatik eklendi:" & vbCrLf & vbCrLf & kategori, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Hata: " & kategori, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnKategoriOner.Enabled = True
            btnKategoriOner.Text = "🤖 AI ile Kategori Öner"
        End Try
    End Sub
    
    Private Sub ParseAndAddCategories(aiText As String)
        Try
            Dim lines() As String = aiText.Split(New String() {vbCrLf, vbLf, vbCr}, StringSplitOptions.RemoveEmptyEntries)
            
            Dim marka As String = ""
            Dim anaKategori As String = ""
            Dim altKategori As String = ""
            Dim cinsiyet As String = ""
            Dim etiket1 As String = ""
            Dim etiket2 As String = ""
            Dim etiket3 As String = ""
            Dim etiket4 As String = ""
            Dim etiket5 As String = ""
            Dim etiket6 As String = ""
            Dim etiket7 As String = ""
            
            ' Parse et
            For Each line As String In lines
                If line.Contains("Marka:") Then
                    marka = line.Replace("Marka:", "").Trim()
                ElseIf line.Contains("Ana Kategori:") Then
                    anaKategori = line.Replace("Ana Kategori:", "").Trim()
                ElseIf line.Contains("Alt Kategori:") Then
                    altKategori = line.Replace("Alt Kategori:", "").Trim()
                ElseIf line.Contains("Cinsiyet:") Then
                    cinsiyet = line.Replace("Cinsiyet:", "").Trim()
                ElseIf line.Contains("Etiket 1:") Then
                    etiket1 = line.Replace("Etiket 1:", "").Trim()
                ElseIf line.Contains("Etiket 2:") Then
                    etiket2 = line.Replace("Etiket 2:", "").Trim()
                ElseIf line.Contains("Etiket 3:") Then
                    etiket3 = line.Replace("Etiket 3:", "").Trim()
                ElseIf line.Contains("Etiket 4:") Then
                    etiket4 = line.Replace("Etiket 4:", "").Trim()
                ElseIf line.Contains("Etiket 5:") Then
                    etiket5 = line.Replace("Etiket 5:", "").Trim()
                ElseIf line.Contains("Etiket 6:") Then
                    etiket6 = line.Replace("Etiket 6:", "").Trim()
                ElseIf line.Contains("Etiket 7:") Then
                    etiket7 = line.Replace("Etiket 7:", "").Trim()
                End If
            Next
            
            System.Diagnostics.Debug.WriteLine($"Parse sonucu - Marka: {marka}, Ana: {anaKategori}, Alt: {altKategori}, Cinsiyet: {cinsiyet}, Etiketler: {etiket1}, {etiket2}, {etiket3}, {etiket4}, {etiket5}, {etiket6}, {etiket7}")
            
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                
                ' Marka ekle (sSinifTipi = 3)
                If Not String.IsNullOrEmpty(marka) Then
                    Dim markaKodu As String = AddOrGetSinif(conn, "3", marka)
                    If Not String.IsNullOrEmpty(markaKodu) Then
                        UpdateStokSinifi(conn, "sSinifKodu3", markaKodu)
                        System.Diagnostics.Debug.WriteLine($"Marka eklendi: {markaKodu} - {marka}")
                    End If
                End If
                
                ' Ana Kategori ekle (sSinifTipi = 4)
                If Not String.IsNullOrEmpty(anaKategori) Then
                    Dim anaKodu As String = AddOrGetSinif(conn, "4", anaKategori)
                    If Not String.IsNullOrEmpty(anaKodu) Then
                        UpdateStokSinifi(conn, "sSinifKodu4", anaKodu)
                        System.Diagnostics.Debug.WriteLine($"Ana Kategori eklendi: {anaKodu} - {anaKategori}")
                    End If
                End If
                
                ' Alt Kategori ekle (sSinifTipi = 5)
                If Not String.IsNullOrEmpty(altKategori) Then
                    Dim altKodu As String = AddOrGetSinif(conn, "5", altKategori)
                    If Not String.IsNullOrEmpty(altKodu) Then
                        UpdateStokSinifi(conn, "sSinifKodu5", altKodu)
                        System.Diagnostics.Debug.WriteLine($"Alt Kategori eklendi: {altKodu} - {altKategori}")
                    End If
                End If
                
                ' Cinsiyet ekle (sSinifTipi = 6)
                If Not String.IsNullOrEmpty(cinsiyet) Then
                    Dim cinsiyetKodu As String = AddOrGetSinif(conn, "6", cinsiyet)
                    If Not String.IsNullOrEmpty(cinsiyetKodu) Then
                        UpdateStokSinifi(conn, "sSinifKodu6", cinsiyetKodu)
                        System.Diagnostics.Debug.WriteLine($"Cinsiyet eklendi: {cinsiyetKodu} - {cinsiyet}")
                    End If
                End If
                
                ' Etiket 1 ekle (sSinifTipi = 7)
                If Not String.IsNullOrEmpty(etiket1) Then
                    Dim etiket1Kod As String = AddOrGetSinif(conn, "7", etiket1)
                    If Not String.IsNullOrEmpty(etiket1Kod) Then
                        UpdateStokSinifi(conn, "sSinifKodu7", etiket1Kod)
                        System.Diagnostics.Debug.WriteLine($"Etiket 1 eklendi: {etiket1Kod} - {etiket1}")
                    End If
                End If
                
                ' Etiket 2 ekle (sSinifTipi = 8)
                If Not String.IsNullOrEmpty(etiket2) Then
                    Dim etiket2Kod As String = AddOrGetSinif(conn, "8", etiket2)
                    If Not String.IsNullOrEmpty(etiket2Kod) Then
                        UpdateStokSinifi(conn, "sSinifKodu8", etiket2Kod)
                        System.Diagnostics.Debug.WriteLine($"Etiket 2 eklendi: {etiket2Kod} - {etiket2}")
                    End If
                End If
                
                ' Etiket 3 ekle (sSinifTipi = 9)
                If Not String.IsNullOrEmpty(etiket3) Then
                    Dim etiket3Kod As String = AddOrGetSinif(conn, "9", etiket3)
                    If Not String.IsNullOrEmpty(etiket3Kod) Then
                        UpdateStokSinifi(conn, "sSinifKodu9", etiket3Kod)
                        System.Diagnostics.Debug.WriteLine($"Etiket 3 eklendi: {etiket3Kod} - {etiket3}")
                    End If
                End If
                
                ' Etiket 4 ekle (sSinifTipi = 10)
                If Not String.IsNullOrEmpty(etiket4) Then
                    Dim etiket4Kod As String = AddOrGetSinif(conn, "10", etiket4)
                    If Not String.IsNullOrEmpty(etiket4Kod) Then
                        UpdateStokSinifi(conn, "sSinifKodu10", etiket4Kod)
                        System.Diagnostics.Debug.WriteLine($"Etiket 4 eklendi: {etiket4Kod} - {etiket4}")
                    End If
                End If
                
                ' Etiket 5 ekle (sSinifTipi = 11)
                If Not String.IsNullOrEmpty(etiket5) Then
                    Dim etiket5Kod As String = AddOrGetSinif(conn, "11", etiket5)
                    If Not String.IsNullOrEmpty(etiket5Kod) Then
                        UpdateStokSinifi(conn, "sSinifKodu11", etiket5Kod)
                        System.Diagnostics.Debug.WriteLine($"Etiket 5 eklendi: {etiket5Kod} - {etiket5}")
                    End If
                End If
                
                ' Etiket 6 ekle (sSinifTipi = 12)
                If Not String.IsNullOrEmpty(etiket6) Then
                    Dim etiket6Kod As String = AddOrGetSinif(conn, "12", etiket6)
                    If Not String.IsNullOrEmpty(etiket6Kod) Then
                        UpdateStokSinifi(conn, "sSinifKodu12", etiket6Kod)
                        System.Diagnostics.Debug.WriteLine($"Etiket 6 eklendi: {etiket6Kod} - {etiket6}")
                    End If
                End If
                
                ' Etiket 7 ekle (sSinifTipi = 13)
                If Not String.IsNullOrEmpty(etiket7) Then
                    Dim etiket7Kod As String = AddOrGetSinif(conn, "13", etiket7)
                    If Not String.IsNullOrEmpty(etiket7Kod) Then
                        UpdateStokSinifi(conn, "sSinifKodu13", etiket7Kod)
                        System.Diagnostics.Debug.WriteLine($"Etiket 7 eklendi: {etiket7Kod} - {etiket7}")
                    End If
                End If
            End Using
            
            ' Grid'i yenile
            If Not String.IsNullOrEmpty(Me.sModel) Then
                Dataload_tbStokSinifi(Me.sModel)
            End If
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine($"ParseAndAddCategories Hata: {ex.Message}")
            MessageBox.Show("Kategori eklenirken hata: " & ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    
    Private Function AddOrGetSinif(conn As OleDb.OleDbConnection, sinifTipi As String, aciklama As String) As String
        Try
            ' Her sınıf tipi için ayrı tablo var: tbSSinif3, tbSSinif4, tbSSinif5...
            Dim tabloAdi As String = $"tbSSinif{sinifTipi}"
            
            System.Diagnostics.Debug.WriteLine($"AddOrGetSinif: Tablo={tabloAdi}, Açıklama={aciklama}")
            
            ' Önce var mı kontrol et
            Dim checkCmd As New OleDb.OleDbCommand(
                $"SELECT TOP 1 sSinifKodu FROM {tabloAdi} WHERE sAciklama = ?", conn)
            checkCmd.Parameters.AddWithValue("?", aciklama)
            
            Dim existingKod As Object = checkCmd.ExecuteScalar()
            If existingKod IsNot Nothing AndAlso Not IsDBNull(existingKod) Then
                System.Diagnostics.Debug.WriteLine($"Mevcut sınıf bulundu - Kod: {existingKod}")
                Return existingKod.ToString()
            End If
            
            ' Yeni kod oluştur (son kod + 1)
            Dim maxKodCmd As New OleDb.OleDbCommand(
                $"SELECT ISNULL(MAX(CAST(sSinifKodu AS INT)), 0) FROM {tabloAdi}", conn)
            
            Dim maxKod As Integer = Convert.ToInt32(maxKodCmd.ExecuteScalar())
            Dim yeniKod As String = (maxKod + 1).ToString("000")
            
            System.Diagnostics.Debug.WriteLine($"Yeni kod oluşturuluyor - MaxKod: {maxKod}, YeniKod: {yeniKod}")
            
            ' Ekle
            Dim insertCmd As New OleDb.OleDbCommand(
                $"INSERT INTO {tabloAdi} (sSinifKodu, sAciklama) VALUES (?, ?)", conn)
            insertCmd.Parameters.AddWithValue("?", yeniKod)
            insertCmd.Parameters.AddWithValue("?", aciklama)
            Dim rowsAffected As Integer = insertCmd.ExecuteNonQuery()
            
            System.Diagnostics.Debug.WriteLine($"Yeni sınıf eklendi - Tablo: {tabloAdi}, Kod: {yeniKod}, Açıklama: {aciklama}, Rows: {rowsAffected}")
            Return yeniKod
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine($"AddOrGetSinif HATA: {ex.Message}")
            MessageBox.Show($"Sınıf ekleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
    End Function
    
    Private Sub UpdateStokSinifi(conn As OleDb.OleDbConnection, kolonAdi As String, kod As String)
        Try
            System.Diagnostics.Debug.WriteLine($"UpdateStokSinifi (MODEL BAZLI): sModel={Me.sModel}, Kolon={kolonAdi}, Kod={kod}")
            
            ' MODEL BAZLI: tbStokSinifi'de bu model için kayıt var mı kontrol et
            Dim checkCmd As New OleDb.OleDbCommand(
                "SELECT COUNT(*) FROM tbStokSinifi WHERE sModel = ?", conn)
            checkCmd.Parameters.AddWithValue("?", Me.sModel)
            
            Dim recordExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
            System.Diagnostics.Debug.WriteLine($"UpdateStokSinifi (MODEL BAZLI): Kayıt var mı? {recordExists}")
            
            If recordExists > 0 Then
                ' UPDATE (Model bazlı)
                Dim updateSQL As String = $"UPDATE tbStokSinifi SET {kolonAdi} = ? WHERE sModel = ?"
                System.Diagnostics.Debug.WriteLine($"UPDATE SQL (MODEL): {updateSQL}, Params: {kod}, {Me.sModel}")
                
                Dim updateCmd As New OleDb.OleDbCommand(updateSQL, conn)
                updateCmd.Parameters.AddWithValue("?", kod)
                updateCmd.Parameters.AddWithValue("?", Me.sModel)
                Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()
                
                System.Diagnostics.Debug.WriteLine($"UPDATE başarılı (MODEL) - {kolonAdi}: {kod}, RowsAffected: {rowsAffected}")
            Else
                ' INSERT (Model bazlı - ama nStokID de eklemeliyiz çünkü tablo NOT NULL olabilir)
                System.Diagnostics.Debug.WriteLine($"INSERT (MODEL): Kayıt yok, yeni oluşturuluyor...")
                
                ' Bu modele ait herhangi bir nStokID al
                Dim getStokIDCmd As New OleDb.OleDbCommand(
                    "SELECT TOP 1 nStokID FROM tbStok WHERE sModel = ?", conn)
                getStokIDCmd.Parameters.AddWithValue("?", Me.sModel)
                Dim stokIDObj As Object = getStokIDCmd.ExecuteScalar()
                
                If stokIDObj Is Nothing OrElse IsDBNull(stokIDObj) Then
                    System.Diagnostics.Debug.WriteLine("HATA: Bu model için stok kaydı bulunamadı!")
                    MessageBox.Show("Hata: Bu model için stok kaydı bulunamadı!", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                
                Dim nStokID As Integer = Convert.ToInt32(stokIDObj)
                
                Dim insertSQL As String = $"INSERT INTO tbStokSinifi (nStokID, sModel, {kolonAdi}) VALUES (?, ?, ?)"
                System.Diagnostics.Debug.WriteLine($"INSERT SQL (MODEL): {insertSQL}, Params: nStokID={nStokID}, sModel={Me.sModel}, {kolonAdi}={kod}")
                
                Dim insertCmd As New OleDb.OleDbCommand(insertSQL, conn)
                insertCmd.Parameters.AddWithValue("?", nStokID)
                insertCmd.Parameters.AddWithValue("?", Me.sModel)
                insertCmd.Parameters.AddWithValue("?", kod)
                Dim rowsAffected As Integer = insertCmd.ExecuteNonQuery()
                
                System.Diagnostics.Debug.WriteLine($"INSERT başarılı (MODEL) - {kolonAdi}: {kod}, RowsAffected: {rowsAffected}, nStokID: {nStokID}")
            End If
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine($"UpdateStokSinifi HATA: {ex.Message}")
            System.Diagnostics.Debug.WriteLine($"StackTrace: {ex.StackTrace}")
            MessageBox.Show($"Sınıf güncelleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub btnFiyatOptimize_Click(sender As Object, e As EventArgs)
        If String.IsNullOrEmpty(Me.sKodu) Then
            MessageBox.Show("Lütfen önce bir ürün seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        Try
            btnFiyatOptimize.Enabled = False
            btnFiyatOptimize.Text = "Analiz ediliyor..."
            Application.DoEvents()
            
            Dim aiService As New AIService()
            Dim prompt As String = $"Sen bir fiyatlandırma uzmanısın. Aşağıdaki ürün için fiyat analizi yap:

Ürün: {Me.txt_sAdi.Text}

Analizini şu formatta sun:
📊 Piyasa Analizi:
- Benzer ürünler genelde ne kadara satılıyor?

💡 Önerilen Fiyat:
- Minimum: [fiyat]
- Optimum: [fiyat]
- Maksimum: [fiyat]

🎯 Strateji:
- Hangi fiyatlandırma stratejisi kullanılmalı?

⚠️ Notlar:
- Dikkat edilmesi gerekenler

200-250 kelime. SADECE ANALİZİ DÖNDÜR!"
            
            Dim analiz As String = aiService.CallOpenAI(prompt, 400)
            
            If Not String.IsNullOrEmpty(analiz) AndAlso Not analiz.Contains("API key bulunamadı") Then
                txtFiyatOptimize.Text = analiz
                SaveAIContent("sFiyatOptimize", analiz)
                MessageBox.Show("Fiyat analizi başarıyla oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Hata: " & analiz, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btnFiyatOptimize.Enabled = True
            btnFiyatOptimize.Text = "Fiyat Optimize Et"
        End Try
    End Sub
    
    ' ============================================================================
    ' VERİTABANI İŞLEMLERİ
    ' ============================================================================
    
    Private Sub SaveAIContent(columnName As String, content As String)
        Try
            ' sModel kontrolü
            If String.IsNullOrEmpty(Me.sModel) Then
                MessageBox.Show("Hata: Ürün modeli bulunamadı!", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                
                ' Önce tablonun var olup olmadığını kontrol et
                Dim tableCheckCmd As New OleDb.OleDbCommand(
                    "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'tbStokAIIcerik'", conn)
                Dim tableExists As Integer = Convert.ToInt32(tableCheckCmd.ExecuteScalar())
                
                If tableExists = 0 Then
                    MessageBox.Show("Hata: tbStokAIIcerik tablosu bulunamadı! SQL_AI_SYSTEM/INSTALL_DATABASE.sql scriptini çalıştırın.", "Tablo Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                
                System.Diagnostics.Debug.WriteLine($"SaveAIContent (MODEL BAZLI): sModel={Me.sModel}, Column={columnName}")
                
                ' MODEL BAZLI: Kayıt var mı kontrol et
                Dim checkCmd As New OleDb.OleDbCommand(
                    "SELECT COUNT(*) FROM tbStokAIIcerik WHERE sModel = ?", conn)
                checkCmd.Parameters.AddWithValue("?", Me.sModel)
                
                Dim recordExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                
                If recordExists > 0 Then
                    ' UPDATE (Model bazlı)
                    Dim updateCmd As New OleDb.OleDbCommand(
                        $"UPDATE tbStokAIIcerik SET {columnName} = ?, dteOlusturma = GETDATE() WHERE sModel = ?", conn)
                    updateCmd.Parameters.AddWithValue("?", content)
                    updateCmd.Parameters.AddWithValue("?", Me.sModel)
                    Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()
                    
                    System.Diagnostics.Debug.WriteLine($"AI İçerik güncellendi (MODEL): {columnName}, Rows: {rowsAffected}, Model: {Me.sModel}")
                Else
                    ' INSERT (Model bazlı - nStokID de eklemeliyiz çünkü tablo NOT NULL)
                    ' Bu modele ait herhangi bir nStokID al
                    Dim getStokIDCmd As New OleDb.OleDbCommand(
                        "SELECT TOP 1 nStokID FROM tbStok WHERE sModel = ?", conn)
                    getStokIDCmd.Parameters.AddWithValue("?", Me.sModel)
                    Dim stokIDObj As Object = getStokIDCmd.ExecuteScalar()
                    
                    If stokIDObj Is Nothing OrElse IsDBNull(stokIDObj) Then
                        MessageBox.Show("Hata: Bu model için stok kaydı bulunamadı!", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                    
                    Dim nStokID As Integer = Convert.ToInt32(stokIDObj)
                    
                    Dim insertCmd As New OleDb.OleDbCommand(
                        $"INSERT INTO tbStokAIIcerik (nStokID, sModel, {columnName}, dteOlusturma) VALUES (?, ?, ?, GETDATE())", conn)
                    insertCmd.Parameters.AddWithValue("?", nStokID)
                    insertCmd.Parameters.AddWithValue("?", Me.sModel)
                    insertCmd.Parameters.AddWithValue("?", content)
                    Dim rowsAffected As Integer = insertCmd.ExecuteNonQuery()
                    
                    System.Diagnostics.Debug.WriteLine($"AI İçerik eklendi (MODEL): {columnName}, Rows: {rowsAffected}, Model: {Me.sModel}, nStokID: {nStokID}")
                End If
                
                ' tbStok güncelle (Bu modeldeki TÜM ürünler için)
                Dim updateStokCmd As New OleDb.OleDbCommand(
                    "UPDATE tbStok SET bAIIcerikVar = 1, dteAISonGuncelleme = GETDATE() WHERE sModel = ?", conn)
                updateStokCmd.Parameters.AddWithValue("?", Me.sModel)
                Dim updatedStokCount As Integer = updateStokCmd.ExecuteNonQuery()
                
                System.Diagnostics.Debug.WriteLine($"Kayıt başarılı (MODEL BAZLI): {columnName} -> Model: {Me.sModel}, Güncellenen ürün sayısı: {updatedStokCount}")
            End Using
        Catch ex As Exception
            MessageBox.Show("Kayıt hatası: " & ex.Message & vbCrLf & vbCrLf & "Stack Trace: " & ex.StackTrace, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub LoadAIContent()
        Try
            System.Diagnostics.Debug.WriteLine($"LoadAIContent çağrıldı - sModel: {Me.sModel}")
            
            If String.IsNullOrEmpty(Me.sModel) Then
                System.Diagnostics.Debug.WriteLine("LoadAIContent iptal: sModel boş")
                Return
            End If
            
            If txtSEOBaslik Is Nothing Then
                System.Diagnostics.Debug.WriteLine("LoadAIContent iptal: txtSEOBaslik Nothing")
                Return
            End If
            
            ' Önce tüm textbox'ları temizle
            txtSEOBaslik.Text = ""
            txtKullanimTalimati.Text = ""
            txtMetaAciklama.Text = ""
            txtFiyatOptimize.Text = ""
            
            Using conn As New OleDb.OleDbConnection(connection)
                conn.Open()
                
                System.Diagnostics.Debug.WriteLine($"LoadAIContent (MODEL BAZLI): sModel={Me.sModel}")
                
                ' MODEL BAZLI: Doğrudan sModel ile oku
                Dim cmd As New OleDb.OleDbCommand(
                    "SELECT * FROM tbStokAIIcerik WHERE sModel = ?", conn)
                cmd.Parameters.AddWithValue("?", Me.sModel)
                
                Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                
                If reader.Read() Then
                    System.Diagnostics.Debug.WriteLine("AI İçerik bulundu (MODEL BAZLI), yükleniyor...")
                    
                    If Not IsDBNull(reader("sSEOBaslik")) Then
                        txtSEOBaslik.Text = reader("sSEOBaslik").ToString()
                        System.Diagnostics.Debug.WriteLine($"SEO Başlık yüklendi: {txtSEOBaslik.Text.Substring(0, Math.Min(50, txtSEOBaslik.Text.Length))}")
                    End If
                    
                    If Not IsDBNull(reader("sKullanimTalimati")) Then
                        txtKullanimTalimati.Text = reader("sKullanimTalimati").ToString()
                        System.Diagnostics.Debug.WriteLine("Kullanım Talimatı yüklendi")
                    End If
                    
                    If Not IsDBNull(reader("sMetaDescription")) Then
                        txtMetaAciklama.Text = reader("sMetaDescription").ToString()
                        System.Diagnostics.Debug.WriteLine("Meta Açıklama yüklendi")
                    End If
                    
                    Try
                        If Not IsDBNull(reader("sFiyatOptimize")) Then
                            txtFiyatOptimize.Text = reader("sFiyatOptimize").ToString()
                            System.Diagnostics.Debug.WriteLine("Fiyat Optimizasyon yüklendi")
                        End If
                    Catch
                    End Try
                Else
                    System.Diagnostics.Debug.WriteLine($"AI İçerik bulunamadı (MODEL BAZLI) - Model: {Me.sModel}")
                End If
                
                reader.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("AI İçerik yükleme hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            System.Diagnostics.Debug.WriteLine($"LoadAIContent Hata: {ex.Message}")
        End Try
    End Sub

End Class
