Imports Microsoft.Win32
Imports System.Net.Http
Imports System.Net
Imports System.Data.OleDb
Imports System.IO
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.Data
Imports System.Linq
Imports System

Public Class frm_stok_liste
    Inherits DevExpress.XtraEditors.XtraForm
    
    ' Seçili stok bilgileri (dışarıdan erişim için)
    Public secili_nStokID As Long = 0
    Public secili_Barkod As String = ""
    Public secili_StokKodu As String = ""
    
    ' Image cache for performance optimization
    Private imageCache As New Dictionary(Of String, Image)()
    Private thumbnailSize As New Size(100, 100) ' Thumbnail size for display
    Private Const MAX_CACHE_SIZE As Integer = 50

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
    Private _imgCache As New Dictionary(Of String, Image)()
    Private Const _cacheDir As String = "C:\Eticaret\Stok Resim\"
    Private ReadOnly ResimCache As New Dictionary(Of String, Byte())()

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
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sec_kriter As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ara As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sec_konum As DevExpress.XtraEditors.ComboBoxEdit
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
    Friend WithEvents colbEksiyeDusebilirmi As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents colMevcut2 As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents colFiyat1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFiyat2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFiyat3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collFiyat4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_fiyatli As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents sec_webGoruntule As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colnBirimCarpan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFIYAT6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_bResimGoster As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colpResim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_pResim As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemAIIcerik As System.Windows.Forms.MenuItem
    Friend WithEvents colbFiyatDegisti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbYeni As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDovizCinsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnPrim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnHacim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnAgirlik As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMuadilBarkod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colsDepo6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsDepo8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnWeb As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnTavsiye As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sec_renk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stok_liste))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colMevcut = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbFiyatDegisti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbYeni = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_bResimGoster = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_fiyatli = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_webGoruntule = New DevExpress.XtraEditors.CheckEdit()
        Me.sec_konum = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.sec_kriter = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ara = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItemAIIcerik = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
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
        Me.colbEksiyeDusebilirmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDefaultAsortiTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbEksideUyarsinmi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbOtvVar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsOTVTipi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnIskontoYuzdesiAV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbEK1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colbEK2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsBarkod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSinif15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colISTIHBARAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMevcut2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFiyat1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFiyat2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFiyat3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.collFiyat4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnBirimCarpan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFIYAT6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpResim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sec_pResim = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.colsDovizCinsi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnPrim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnHacim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnAgirlik = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMuadilBarkod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsDepo8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnWeb = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnTavsiye = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ps = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.printlink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
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
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_bResimGoster.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_fiyatli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_webGoruntule.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sec_pResim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.printlink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colMevcut
        '
        Me.colMevcut.Caption = "Mevcut"
        Me.colMevcut.DisplayFormat.FormatString = "#,0.####"
        Me.colMevcut.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMevcut.FieldName = "Mevcut"
        Me.colMevcut.Name = "colMevcut"
        Me.colMevcut.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Mevcut", "{0:#,0.####}")})
        Me.colMevcut.Visible = True
        Me.colMevcut.VisibleIndex = 2
        Me.colMevcut.Width = 76
        '
        'colbFiyatDegisti
        '
        Me.colbFiyatDegisti.Caption = "Fiyatı Değisti?"
        Me.colbFiyatDegisti.FieldName = "bFiyatDegisti"
        Me.colbFiyatDegisti.Name = "colbFiyatDegisti"
        '
        'colbYeni
        '
        Me.colbYeni.Caption = "Yeni?"
        Me.colbYeni.FieldName = "bYeni"
        Me.colbYeni.Name = "colbYeni"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1397, 80)
        Me.PanelControl1.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.CheckEdit1)
        Me.GroupControl1.Controls.Add(Me.sec_bResimGoster)
        Me.GroupControl1.Controls.Add(Me.sec_fiyatli)
        Me.GroupControl1.Controls.Add(Me.sec_webGoruntule)
        Me.GroupControl1.Controls.Add(Me.sec_konum)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.sec_kriter)
        Me.GroupControl1.Controls.Add(Me.txt_ara)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(154, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1241, 76)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Text = "Ara"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(904, 33)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Muadil Barkod"
        Me.CheckEdit1.Size = New System.Drawing.Size(149, 24)
        ToolTipTitleItem1.Text = "Bakiyeli Mteriler"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Sadece Bakiyeli Müşterilerin Ekrana Gelmesi ve Izlenmesi istenidiği zaman Bu Kutu" &
    "cuk işaretlenir"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.CheckEdit1.SuperTip = SuperToolTip1
        Me.CheckEdit1.TabIndex = 10
        '
        'sec_bResimGoster
        '
        Me.sec_bResimGoster.Location = New System.Drawing.Point(603, 31)
        Me.sec_bResimGoster.Name = "sec_bResimGoster"
        Me.sec_bResimGoster.Properties.Caption = "ResimGöster"
        Me.sec_bResimGoster.Size = New System.Drawing.Size(149, 24)
        ToolTipTitleItem2.Text = "Bakiyeli Mteriler"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Sadece Bakiyeli Müşterilerin Ekrana Gelmesi ve Izlenmesi istenidiği zaman Bu Kutu" &
    "cuk işaretlenir"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.sec_bResimGoster.SuperTip = SuperToolTip2
        Me.sec_bResimGoster.TabIndex = 9
        '
        'sec_fiyatli
        '
        Me.sec_fiyatli.Location = New System.Drawing.Point(558, 31)
        Me.sec_fiyatli.Name = "sec_fiyatli"
        Me.sec_fiyatli.Properties.Caption = ""
        Me.sec_fiyatli.Size = New System.Drawing.Size(36, 19)
        ToolTipTitleItem3.Text = "Fiyatl Liste"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Stoklarn Fiyatlarnn listede gözükmesi isteniyorsa buranın işaretli olması gerekme" &
    "ktedir."
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.sec_fiyatli.SuperTip = SuperToolTip3
        Me.sec_fiyatli.TabIndex = 8
        '
        'sec_webGoruntule
        '
        Me.sec_webGoruntule.Location = New System.Drawing.Point(1060, 33)
        Me.sec_webGoruntule.Name = "sec_webGoruntule"
        Me.sec_webGoruntule.Properties.Caption = "Web"
        Me.sec_webGoruntule.Size = New System.Drawing.Size(60, 24)
        Me.sec_webGoruntule.TabIndex = 10
        '
        'sec_konum
        '
        Me.sec_konum.EditValue = "Ad"
        Me.sec_konum.EnterMoveNextControl = True
        Me.sec_konum.Location = New System.Drawing.Point(282, 31)
        Me.sec_konum.Name = "sec_konum"
        Me.sec_konum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_konum.Properties.Items.AddRange(New Object() {"Kod", "Ad", "Barkod", "Seri No", "Not", "KısaKod", "Gelişmiş", "Sınıf1", "Sınıf2", "Sınıf3", "Sınıf4", "Sınıf5", "Sınıf6", "Sınıf7", "Sınıf8", "Sınıf9", "Sınıf10", "Sınıf11", "Sınıf12", "Sınıf13", "Sınıf14", "Sınıf15"})
        Me.sec_konum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_konum.Size = New System.Drawing.Size(156, 26)
        Me.sec_konum.TabIndex = 1
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(762, 31)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(120, 29)
        Me.SimpleButton3.TabIndex = 3
        Me.SimpleButton3.Text = "&Listele"
        '
        'sec_kriter
        '
        Me.sec_kriter.EditValue = "Başlar"
        Me.sec_kriter.EnterMoveNextControl = True
        Me.sec_kriter.Location = New System.Drawing.Point(438, 31)
        Me.sec_kriter.Name = "sec_kriter"
        Me.sec_kriter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sec_kriter.Properties.Items.AddRange(New Object() {"Başlar", "Biter", "Eşittir", "İçerir", "Boş", "Dolu", "Farklı", "Büyük", "Küçük", "Aralık"})
        Me.sec_kriter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.sec_kriter.Size = New System.Drawing.Size(120, 26)
        Me.sec_kriter.TabIndex = 2
        '
        'txt_ara
        '
        Me.txt_ara.EnterMoveNextControl = True
        Me.txt_ara.Location = New System.Drawing.Point(3, 31)
        Me.txt_ara.Name = "txt_ara"
        Me.txt_ara.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txt_ara.Properties.Appearance.Options.UseFont = True
        Me.txt_ara.Properties.MaxLength = 15
        Me.txt_ara.Size = New System.Drawing.Size(279, 28)
        Me.txt_ara.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(154, 2)
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
        Me.PictureBox1.Size = New System.Drawing.Size(152, 76)
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
        Me.PanelControl2.Location = New System.Drawing.Point(0, 641)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1397, 70)
        Me.PanelControl2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*** Kayıt Bulunamadı...! ***"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(1261, 11)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(119, 35)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "&Vazgeç"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1140, 11)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(121, 35)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Tamam"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GridControl1)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 80)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1397, 561)
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
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.sec_renk, Me.sec_pResim})
        Me.GridControl1.Size = New System.Drawing.Size(1393, 557)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem14, Me.MenuItem15, Me.MenuItem16, Me.MenuItem17, Me.MenuItem18, Me.MenuItem21, Me.MenuItem22, Me.MenuItem28, Me.MenuItem19, Me.MenuItem29, Me.MenuItem27, Me.MenuItem30, Me.MenuItemAIIcerik, Me.MenuItem20, Me.MenuItem1, Me.MenuItem2, Me.MenuItem3, Me.MenuItem4, Me.MenuItem10, Me.MenuItem24, Me.MenuItem23, Me.MenuItem5, Me.MenuItem6, Me.MenuItem11, Me.MenuItem7, Me.MenuItem8, Me.MenuItem12, Me.MenuItem9})
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
        Me.MenuItem16.Shortcut = System.Windows.Forms.Shortcut.F6
        Me.MenuItem16.Text = "Envanter"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 4
        Me.MenuItem17.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem17.Text = "Stok Kartı"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 5
        Me.MenuItem18.Shortcut = System.Windows.Forms.Shortcut.F7
        Me.MenuItem18.Text = "Stok Hareketleri"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 6
        Me.MenuItem21.Shortcut = System.Windows.Forms.Shortcut.F8
        Me.MenuItem21.Text = "Transfer Hareketleri"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 7
        Me.MenuItem22.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.MenuItem22.Text = "Stok Fiyatlandır"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 8
        Me.MenuItem28.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
        Me.MenuItem28.Text = "Karlılık Akış Tablosu"
        '
        'MenuItem19
        '
        Me.MenuItem19.Enabled = False
        Me.MenuItem19.Index = 9
        Me.MenuItem19.Shortcut = System.Windows.Forms.Shortcut.F4
        Me.MenuItem19.Text = "Firma Kart"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 10
        Me.MenuItem29.Shortcut = System.Windows.Forms.Shortcut.CtrlL
        Me.MenuItem29.Text = "Alternatifler"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 11
        Me.MenuItem27.Shortcut = System.Windows.Forms.Shortcut.F11
        Me.MenuItem27.Text = "Resim Göster"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 12
        Me.MenuItem30.Shortcut = System.Windows.Forms.Shortcut.CtrlT
        Me.MenuItem30.Text = "Protokol"
        '
        'MenuItemAIIcerik
        '
        Me.MenuItemAIIcerik.Index = 13
        Me.MenuItemAIIcerik.Text = "🤖 AI İçerik Oluştur"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 14
        Me.MenuItem20.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 15
        Me.MenuItem1.Text = "Görünüm Düzenle"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 16
        Me.MenuItem2.Text = "Başlık Değiştir"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 17
        Me.MenuItem3.Text = "Görnüm Kaydet"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 18
        Me.MenuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.MenuItem4.Text = "Görünüm Yazdır"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 19
        Me.MenuItem10.Text = "-"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 20
        Me.MenuItem24.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem25, Me.MenuItem26})
        Me.MenuItem24.Text = "Raporla"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 0
        Me.MenuItem25.Text = "Excel"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 1
        Me.MenuItem26.Text = "Text"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 21
        Me.MenuItem23.Text = "Hızlı Filtre"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 22
        Me.MenuItem5.Text = "Filtrele"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 23
        Me.MenuItem6.Text = "Gruplandır"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 24
        Me.MenuItem11.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 25
        Me.MenuItem7.Text = "Satrlar Aç"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 26
        Me.MenuItem8.Text = "Satrlar Kapat"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 27
        Me.MenuItem12.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 28
        Me.MenuItem9.Shortcut = System.Windows.Forms.Shortcut.F12
        Me.MenuItem9.Text = "Ekran Kapla"
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
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.Options.UseFont = True
        Me.GridView1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnStokID, Me.colsKodu, Me.colsAciklama, Me.colsKisaAdi, Me.colnStokTipi, Me.colsBedenTipi, Me.colsKavalaTipi, Me.colsRenk, Me.colsBeden, Me.colsKavala, Me.colsBirimCinsi1, Me.colsBirimCinsi2, Me.colnIskontoYuzdesi, Me.colsKdvTipi, Me.colnTeminSuresi, Me.collAsgariMiktar, Me.collAzamiMiktar, Me.colsOzelNot, Me.colnFiyatlandirma, Me.colsModel, Me.colsKullaniciAdi, Me.coldteKayitTarihi, Me.colbEksiyeDusebilirmi, Me.colsDefaultAsortiTipi, Me.colbEksideUyarsinmi, Me.colbOtvVar, Me.colsOTVTipi, Me.colnIskontoYuzdesiAV, Me.colbEK1, Me.colbEK2, Me.colsBarkod, Me.colSinif1, Me.colSinif2, Me.colSinif3, Me.colSinif4, Me.colSinif5, Me.colSinif6, Me.colSinif7, Me.colSinif8, Me.colSinif9, Me.colSinif10, Me.colSinif11, Me.colSinif12, Me.colSinif13, Me.colSinif14, Me.colSinif15, Me.colISTIHBARAT, Me.colMevcut, Me.colMevcut2, Me.colFiyat1, Me.colFiyat2, Me.colFiyat3, Me.collFiyat4, Me.colFIYAT5, Me.colnBirimCarpan, Me.colFIYAT6, Me.colpResim, Me.colbFiyatDegisti, Me.colbYeni, Me.colsDovizCinsi, Me.colsDepo1, Me.colsDepo2, Me.colsDepo3, Me.colsDepo4, Me.colsDepo5, Me.colnPrim, Me.colnHacim, Me.colnAgirlik, Me.colMuadilBarkod, Me.colsDepo6, Me.colsDepo7, Me.colsDepo8, Me.colnWeb, Me.colnTavsiye})
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(755, 312, 208, 169)
        Me.GridView1.DetailHeight = 160
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Navy
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.colMevcut
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition1.Value1 = "0"
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.Column = Me.colMevcut
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        StyleFormatCondition2.Value1 = "0"
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Appearance.Options.UseForeColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.colbFiyatDegisti
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Expression = "1"
        StyleFormatCondition3.Value1 = "1"
        StyleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.Purple
        StyleFormatCondition4.Appearance.Options.UseForeColor = True
        StyleFormatCondition4.ApplyToRow = True
        StyleFormatCondition4.Column = Me.colbYeni
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition4.Expression = "1"
        StyleFormatCondition4.Value1 = "1"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}:  {1} {2}"
        Me.GridView1.GroupPanelText = "Gruplamak stediiniz Kolonu Buraya Srkleyiniz..."
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayt"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Musteri", Nothing, "{0} Kayt")})
        Me.GridView1.IndicatorWidth = 35
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsDetail.ShowDetailTabs = False
        Me.GridView1.OptionsPrint.ExpandAllGroups = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colnStokID
        '
        Me.colnStokID.Caption = "Kayıt No"
        Me.colnStokID.FieldName = "nStokID"
        Me.colnStokID.Name = "colnStokID"
        '
        'colsKodu
        '
        Me.colsKodu.Caption = "Stok Kodu"
        Me.colsKodu.FieldName = "sKodu"
        Me.colsKodu.Name = "colsKodu"
        Me.colsKodu.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "sKodu", "{0} Kayt")})
        Me.colsKodu.Visible = True
        Me.colsKodu.VisibleIndex = 0
        Me.colsKodu.Width = 128
        '
        'colsAciklama
        '
        Me.colsAciklama.Caption = "Stok Adı"
        Me.colsAciklama.FieldName = "sAciklama"
        Me.colsAciklama.Name = "colsAciklama"
        Me.colsAciklama.Visible = True
        Me.colsAciklama.VisibleIndex = 1
        Me.colsAciklama.Width = 362
        '
        'colsKisaAdi
        '
        Me.colsKisaAdi.Caption = "Kısa Ad"
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
        Me.colsRenk.Width = 157
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
        Me.colsBirimCinsi1.Caption = "Birim"
        Me.colsBirimCinsi1.FieldName = "sBirimCinsi1"
        Me.colsBirimCinsi1.Name = "colsBirimCinsi1"
        Me.colsBirimCinsi1.Visible = True
        Me.colsBirimCinsi1.VisibleIndex = 3
        Me.colsBirimCinsi1.Width = 77
        '
        'colsBirimCinsi2
        '
        Me.colsBirimCinsi2.Caption = "Birim 2"
        Me.colsBirimCinsi2.FieldName = "sBirimCinsi2"
        Me.colsBirimCinsi2.Name = "colsBirimCinsi2"
        '
        'colnIskontoYuzdesi
        '
        Me.colnIskontoYuzdesi.Caption = "İskonto Yüzdesi"
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
        Me.colsKullaniciAdi.Caption = "Kullancı Adı"
        Me.colsKullaniciAdi.FieldName = "sKullaniciAdi"
        Me.colsKullaniciAdi.Name = "colsKullaniciAdi"
        '
        'coldteKayitTarihi
        '
        Me.coldteKayitTarihi.Caption = "Kayıt Tarihi"
        Me.coldteKayitTarihi.FieldName = "dteKayitTarihi"
        Me.coldteKayitTarihi.Name = "coldteKayitTarihi"
        '
        'colbEksiyeDusebilirmi
        '
        Me.colbEksiyeDusebilirmi.Caption = "Eksiye Düşebilirmi"
        Me.colbEksiyeDusebilirmi.FieldName = "bEksiyeDusebilirmi"
        Me.colbEksiyeDusebilirmi.Name = "colbEksiyeDusebilirmi"
        '
        'colsDefaultAsortiTipi
        '
        Me.colsDefaultAsortiTipi.Caption = "DefaultAsortiTipi"
        Me.colsDefaultAsortiTipi.FieldName = "sDefaultAsortiTipi"
        Me.colsDefaultAsortiTipi.Name = "colsDefaultAsortiTipi"
        '
        'colbEksideUyarsinmi
        '
        Me.colbEksideUyarsinmi.Caption = "Ekside Uyarsınmı"
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
        Me.colnIskontoYuzdesiAV.Caption = "İskonto Yüzdesi AV"
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
        '
        'colSinif1
        '
        Me.colSinif1.Caption = "Sınıf 1"
        Me.colSinif1.FieldName = "Sinif1"
        Me.colSinif1.Name = "colSinif1"
        Me.colSinif1.Visible = True
        Me.colSinif1.VisibleIndex = 4
        Me.colSinif1.Width = 171
        '
        'colSinif2
        '
        Me.colSinif2.Caption = "Sınıf 2"
        Me.colSinif2.FieldName = "Sinif2"
        Me.colSinif2.Name = "colSinif2"
        Me.colSinif2.Visible = True
        Me.colSinif2.VisibleIndex = 5
        '
        'colSinif3
        '
        Me.colSinif3.Caption = "Sınıf 3"
        Me.colSinif3.FieldName = "Sinif3"
        Me.colSinif3.Name = "colSinif3"
        '
        'colSinif4
        '
        Me.colSinif4.Caption = "Sınıf 4"
        Me.colSinif4.FieldName = "Sinif4"
        Me.colSinif4.Name = "colSinif4"
        '
        'colSinif5
        '
        Me.colSinif5.Caption = "Sınıf 5"
        Me.colSinif5.FieldName = "Sinif5"
        Me.colSinif5.Name = "colSinif5"
        '
        'colSinif6
        '
        Me.colSinif6.Caption = "Sınıf 6"
        Me.colSinif6.FieldName = "Sinif6"
        Me.colSinif6.Name = "colSinif6"
        '
        'colSinif7
        '
        Me.colSinif7.Caption = "Sınıf 7"
        Me.colSinif7.FieldName = "Sinif7"
        Me.colSinif7.Name = "colSinif7"
        '
        'colSinif8
        '
        Me.colSinif8.Caption = "Sınıf 8"
        Me.colSinif8.FieldName = "Sinif8"
        Me.colSinif8.Name = "colSinif8"
        '
        'colSinif9
        '
        Me.colSinif9.Caption = "Sınıf 9"
        Me.colSinif9.FieldName = "Sinif9"
        Me.colSinif9.Name = "colSinif9"
        '
        'colSinif10
        '
        Me.colSinif10.Caption = "Sınıf 10"
        Me.colSinif10.FieldName = "Sinif10"
        Me.colSinif10.Name = "colSinif10"
        '
        'colSinif11
        '
        Me.colSinif11.Caption = "Sınıf 11"
        Me.colSinif11.FieldName = "Sinif11"
        Me.colSinif11.Name = "colSinif11"
        '
        'colSinif12
        '
        Me.colSinif12.Caption = "Sınıf 12"
        Me.colSinif12.FieldName = "Sinif12"
        Me.colSinif12.Name = "colSinif12"
        '
        'colSinif13
        '
        Me.colSinif13.Caption = "Sınıf 13"
        Me.colSinif13.FieldName = "Sinif13"
        Me.colSinif13.Name = "colSinif13"
        '
        'colSinif14
        '
        Me.colSinif14.Caption = "Sınıf 14"
        Me.colSinif14.FieldName = "Sinif14"
        Me.colSinif14.Name = "colSinif14"
        '
        'colSinif15
        '
        Me.colSinif15.Caption = "Sınıf 15"
        Me.colSinif15.FieldName = "Sinif15"
        Me.colSinif15.Name = "colSinif15"
        '
        'colISTIHBARAT
        '
        Me.colISTIHBARAT.Caption = "ISTIHBARAT"
        Me.colISTIHBARAT.FieldName = "ISTIHBARAT"
        Me.colISTIHBARAT.Name = "colISTIHBARAT"
        '
        'colMevcut2
        '
        Me.colMevcut2.Caption = "Mevcut2"
        Me.colMevcut2.DisplayFormat.FormatString = "#,0.####"
        Me.colMevcut2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMevcut2.FieldName = "lMevcut2"
        Me.colMevcut2.Name = "colMevcut2"
        Me.colMevcut2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "lMevcut2", "{0#,0.####}")})
        Me.colMevcut2.Width = 93
        '
        'colFiyat1
        '
        Me.colFiyat1.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFiyat1.AppearanceCell.Options.UseFont = True
        Me.colFiyat1.Caption = "1. Satış Fiyatı"
        Me.colFiyat1.DisplayFormat.FormatString = "#,0.00##"
        Me.colFiyat1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFiyat1.FieldName = "lFiyat1"
        Me.colFiyat1.Name = "colFiyat1"
        '
        'colFiyat2
        '
        Me.colFiyat2.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFiyat2.AppearanceCell.Options.UseFont = True
        Me.colFiyat2.Caption = "2. Satış Fiyatı"
        Me.colFiyat2.DisplayFormat.FormatString = "#,0.00##"
        Me.colFiyat2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFiyat2.FieldName = "lFiyat2"
        Me.colFiyat2.Name = "colFiyat2"
        '
        'colFiyat3
        '
        Me.colFiyat3.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFiyat3.AppearanceCell.Options.UseFont = True
        Me.colFiyat3.Caption = "3. Satış Fiyatı"
        Me.colFiyat3.DisplayFormat.FormatString = "#,0.00##"
        Me.colFiyat3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFiyat3.FieldName = "lFiyat3"
        Me.colFiyat3.Name = "colFiyat3"
        '
        'collFiyat4
        '
        Me.collFiyat4.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.collFiyat4.AppearanceCell.Options.UseFont = True
        Me.collFiyat4.Caption = "4. Satış Fiyatı"
        Me.collFiyat4.DisplayFormat.FormatString = "#,0.00##"
        Me.collFiyat4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.collFiyat4.FieldName = "lFiyat4"
        Me.collFiyat4.Name = "collFiyat4"
        '
        'colFIYAT5
        '
        Me.colFIYAT5.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFIYAT5.AppearanceCell.Options.UseFont = True
        Me.colFIYAT5.Caption = "Alış Fiyatı"
        Me.colFIYAT5.DisplayFormat.FormatString = "#,0.00##"
        Me.colFIYAT5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT5.FieldName = "FIYAT5"
        Me.colFIYAT5.Name = "colFIYAT5"
        '
        'colnBirimCarpan
        '
        Me.colnBirimCarpan.Caption = "Koli i"
        Me.colnBirimCarpan.DisplayFormat.FormatString = "#,0.##"
        Me.colnBirimCarpan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnBirimCarpan.FieldName = "nBirimCarpan"
        Me.colnBirimCarpan.Name = "colnBirimCarpan"
        '
        'colFIYAT6
        '
        Me.colFIYAT6.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colFIYAT6.AppearanceCell.Options.UseFont = True
        Me.colFIYAT6.Caption = "Maliyet"
        Me.colFIYAT6.DisplayFormat.FormatString = "#,0.00##"
        Me.colFIYAT6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFIYAT6.FieldName = "FIYAT6"
        Me.colFIYAT6.Name = "colFIYAT6"
        '
        'colpResim
        '
        Me.colpResim.Caption = "Resim"
        Me.colpResim.ColumnEdit = Me.sec_pResim
        Me.colpResim.FieldName = "colpResim"
        Me.colpResim.Name = "colpResim"
        Me.colpResim.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        '
        'sec_pResim
        '
        Me.sec_pResim.Name = "sec_pResim"
        Me.sec_pResim.PictureAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.sec_pResim.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bicubic
        Me.sec_pResim.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        '
        'colsDovizCinsi
        '
        Me.colsDovizCinsi.Caption = "Pb"
        Me.colsDovizCinsi.FieldName = "sDovizCinsi"
        Me.colsDovizCinsi.Name = "colsDovizCinsi"
        '
        'colsDepo1
        '
        Me.colsDepo1.Caption = "Depo1"
        Me.colsDepo1.DisplayFormat.FormatString = "#,0.###"
        Me.colsDepo1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colsDepo1.FieldName = "sDepo1"
        Me.colsDepo1.Name = "colsDepo1"
        '
        'colsDepo2
        '
        Me.colsDepo2.Caption = "Depo2"
        Me.colsDepo2.DisplayFormat.FormatString = "#,0.###"
        Me.colsDepo2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colsDepo2.FieldName = "sDepo2"
        Me.colsDepo2.Name = "colsDepo2"
        '
        'colsDepo3
        '
        Me.colsDepo3.Caption = "Depo3"
        Me.colsDepo3.DisplayFormat.FormatString = "#,0.###"
        Me.colsDepo3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colsDepo3.FieldName = "sDepo3"
        Me.colsDepo3.Name = "colsDepo3"
        '
        'colsDepo4
        '
        Me.colsDepo4.Caption = "Depo4"
        Me.colsDepo4.DisplayFormat.FormatString = "#,0.###"
        Me.colsDepo4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colsDepo4.FieldName = "sDepo4"
        Me.colsDepo4.Name = "colsDepo4"
        '
        'colsDepo5
        '
        Me.colsDepo5.Caption = "Depo5"
        Me.colsDepo5.DisplayFormat.FormatString = "#,0.###"
        Me.colsDepo5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colsDepo5.FieldName = "sDepo5"
        Me.colsDepo5.Name = "colsDepo5"
        '
        'colnPrim
        '
        Me.colnPrim.Caption = "Prim"
        Me.colnPrim.DisplayFormat.FormatString = "#,0.###"
        Me.colnPrim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnPrim.FieldName = "nPrim"
        Me.colnPrim.Name = "colnPrim"
        '
        'colnHacim
        '
        Me.colnHacim.Caption = "Hacim"
        Me.colnHacim.DisplayFormat.FormatString = "#,0.###"
        Me.colnHacim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnHacim.FieldName = "nHacim"
        Me.colnHacim.Name = "colnHacim"
        '
        'colnAgirlik
        '
        Me.colnAgirlik.Caption = "Agirlik"
        Me.colnAgirlik.DisplayFormat.FormatString = "#,0.###"
        Me.colnAgirlik.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colnAgirlik.FieldName = "nAgirlik"
        Me.colnAgirlik.Name = "colnAgirlik"
        '
        'colMuadilBarkod
        '
        Me.colMuadilBarkod.Caption = "Muadil Barkod"
        Me.colMuadilBarkod.FieldName = "nMuadilBarkod"
        Me.colMuadilBarkod.Name = "colMuadilBarkod"
        '
        'colsDepo6
        '
        Me.colsDepo6.Caption = "Depo6"
        Me.colsDepo6.DisplayFormat.FormatString = "#,0.###"
        Me.colsDepo6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colsDepo6.FieldName = "sDepo6"
        Me.colsDepo6.Name = "colsDepo6"
        '
        'colsDepo7
        '
        Me.colsDepo7.Caption = "Depo7"
        Me.colsDepo7.DisplayFormat.FormatString = "#,0.###"
        Me.colsDepo7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colsDepo7.FieldName = "sDepo7"
        Me.colsDepo7.Name = "colsDepo7"
        '
        'colsDepo8
        '
        Me.colsDepo8.Caption = "Depo8"
        Me.colsDepo8.DisplayFormat.FormatString = "#,0.###"
        Me.colsDepo8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colsDepo8.FieldName = "sDepo8"
        Me.colsDepo8.Name = "colsDepo8"
        '
        'colnWeb
        '
        Me.colnWeb.Caption = "Web Görüntüle"
        Me.colnWeb.FieldName = "bWebGoruntule"
        Me.colnWeb.Name = "colnWeb"
        '
        'colnTavsiye
        '
        Me.colnTavsiye.Caption = "Web Tavsiye"
        Me.colnTavsiye.FieldName = "bWebTavsiye"
        Me.colnTavsiye.Name = "colnTavsiye"
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
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", "Stok Kaytlar", "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Stok Ynetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
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
        Me.BarButtonItem1.Caption = "Ara ,F3"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Ekle ,Insert"
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Düzelt ,F4"
        Me.BarButtonItem3.Id = 2
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Sil ,Ctrl+Del"
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Yazdır ,Ctrl+P"
        Me.BarButtonItem5.Id = 4
        Me.BarButtonItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Fiyatlandır ,Ctrl+F"
        Me.BarButtonItem6.Id = 5
        Me.BarButtonItem6.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem6.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Envanter ,F6"
        Me.BarButtonItem7.Id = 6
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Hareketler ,F7"
        Me.BarButtonItem8.Id = 7
        Me.BarButtonItem8.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem8.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Transferler ,F8"
        Me.BarButtonItem9.Id = 8
        Me.BarButtonItem9.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BarButtonItem9.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Excel"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1397, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 711)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1397, 31)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 711)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1397, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 711)
        '
        'frm_stok_liste
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 20)
        Me.ClientSize = New System.Drawing.Size(1397, 742)
        Me.ContextMenu = Me.ContextMenu1
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stok_liste"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stok Kayıtları"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_bResimGoster.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_fiyatli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_webGoruntule.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_konum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_kriter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ara.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.sec_renk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sec_pResim, System.ComponentModel.ISupportInitialize).EndInit()
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
    Public kullanici
    Public islemstatus As Boolean = False
    Public bStokKarti As Boolean = False
    Dim mevcut As Decimal = 1
    Dim count As String = ""
    Dim x As Integer = 0
    Dim okut As Boolean = False
    Private Sub frm_stok_liste_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("Konum", sec_konum.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("Kriter", sec_kriter.EditValue)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("YENIKART").SetValue("bResimGoster", sec_bResimGoster.Checked)
    End Sub
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        colsDepo1.Caption = sDepo1Aciklama
        colsDepo2.Caption = sDepo2Aciklama
        colsDepo3.Caption = sDepo3Aciklama
        colsDepo4.Caption = sDepo4Aciklama
        colsDepo5.Caption = sDepo5Aciklama
        colsDepo6.Caption = sDepo6Aciklama
        colsDepo7.Caption = sDepo7Aciklama
        colsDepo8.Caption = sDepo8Aciklama
        colFiyat1.Caption = sFiyat1Aciklama
        colFiyat2.Caption = sFiyat2Aciklama
        colFiyat3.Caption = sFiyat3Aciklama
        collFiyat4.Caption = sFiyat4Aciklama
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
            sec_konum.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("Konum").ToString
        Catch ex As Exception
            sec_konum.EditValue = "Kod"
        End Try
        Try
            sec_kriter.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("Kriter").ToString
        Catch ex As Exception
            sec_kriter.EditValue = "Balar"
        End Try
        Try
            sec_bResimGoster.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("bResimGoster").ToString
        Catch ex As Exception
            sec_bResimGoster.Checked = False
        End Try
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        'If islemstatus = True Or bStokKarti = True Then
        '    colSinif1.Visible = False
        '    colSinif2.Visible = False
        '    colSinif3.Visible = False
        '    colSinif4.Visible = False
        '    colSinif5.Visible = False
        '    colSinif6.Visible = False
        '    colSinif7.Visible = False
        '    colSinif8.Visible = False
        '    colSinif9.Visible = False
        '    colSinif10.Visible = False
        '    colSinif11.Visible = False
        '    colSinif12.Visible = False
        '    colSinif13.Visible = False
        '    colSinif14.Visible = False
        '    colSinif15.Visible = False
        'End If
        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        dataload_renk()
        txt_ara.EditValue = ""
        txt_ara.Focus()
        txt_ara.Select()
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
        XtraMessageBox.Show(Sorgu_sDil("Grnm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        ' Resim göster seçili mi kontrol et
        If sec_bResimGoster.Checked = True Then
            ' --- Resim cache klasörü: System.IO ile tam ad kullan ---
            Try
                If Not System.IO.Directory.Exists("C:\Eticaret\Stok Resim\") Then
                    System.IO.Directory.CreateDirectory("C:\Eticaret\Stok Resim\")
                End If
            Catch
            End Try

            ' --- SADECE colpResim kolonunu kullan (Designer'da tanımlı) ---
            ' ResimGoruntu dinamik kolonu KULLANILMIYOR artık

            ' colpResim kolonunu görünür yap ve ayarla
            If colpResim IsNot Nothing Then
                colpResim.Visible = sec_bResimGoster.Checked
                colpResim.VisibleIndex = 1  ' İlk sırada göster
                colpResim.Width = 125
                colpResim.UnboundType = DevExpress.Data.UnboundColumnType.Object
                colpResim.OptionsColumn.AllowEdit = False
                colpResim.OptionsColumn.AllowFocus = False
                colpResim.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
                colpResim.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
                colpResim.OptionsFilter.AllowFilter = False
                colpResim.OptionsFilter.AllowAutoFilter = False

                ' PictureEdit repository ayarla
                If TypeOf colpResim.ColumnEdit Is DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit Then
                    Dim picEdit = DirectCast(colpResim.ColumnEdit, DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit)
                    picEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
                    picEdit.ShowMenu = False
                    picEdit.NullText = ""
                End If
            End If

            ' ResimGoruntu kolonunu gizle (kullanılmıyor artık)
            Dim colResimGoruntu = GridView1.Columns.ColumnByFieldName("ResimGoruntu")
            If colResimGoruntu IsNot Nothing Then
                colResimGoruntu.Visible = False
            End If

            ' --- Satır yüksekliði ---
            GridView1.RowHeight = 125

            ' --- Orijinal URL kolonu istenmiyorsa gizle ---
            Dim colUrl = GridView1.Columns.ColumnByFieldName("yol")
            If colUrl IsNot Nothing Then colUrl.Visible = False

            ' --- Unbound veriyi saðlayan event: çift baðlanmayı engelle ---
            RemoveHandler GridView1.CustomUnboundColumnData, AddressOf GridView1_CustomUnboundColumnData
            AddHandler GridView1.CustomUnboundColumnData, AddressOf GridView1_CustomUnboundColumnData
        Else
            ' Resim göster kapalı - normal satır yüksekliği
            GridView1.RowHeight = -1

            ' ResimGoruntu kolonunu gizle
            Dim colImg As DevExpress.XtraGrid.Columns.GridColumn =
            GridView1.Columns.ColumnByFieldName("ResimGoruntu")
            If colImg IsNot Nothing Then
                colImg.Visible = False
            End If

            ' colpResim kolonunu da gizle
            If colpResim IsNot Nothing Then
                colpResim.Visible = False
            End If
        End If

        ' --- Designerdaki Mevcut format koşullarında "0" string olabilir -> sayıya çevir ---
        Try
            For Each fc As DevExpress.XtraGrid.StyleFormatCondition In GridView1.FormatConditions
                If fc IsNot Nothing AndAlso fc.Column IsNot Nothing AndAlso
               String.Equals(fc.Column.FieldName, "Mevcut", StringComparison.OrdinalIgnoreCase) Then
                    fc.Value1 = 0D
                End If
            Next
        Catch
        End Try

        ' --- Dil çevirileri / metinler ---
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        ' >> itm bildirimi yok hatası için türü belirt
        For Each itm As System.Windows.Forms.MenuItem In ContextMenu1.MenuItems
            itm.Text = Sorgu_sDil(itm.Text, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)

        ' --- Layout geri yükleme ---
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub

    Private Sub dataload_renk()
        sec_renk.DataSource = sorgu(sorgu_query("SELECT * FROM tbRenk")).Tables(0) 'DataSet2.Tables(0)
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
        If kriter = "Başlar" Then
            sorgu_kriter = " LIKE N'" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE N'%" & deger & "' "
        ElseIf kriter = "İçerir" Then
            sorgu_kriter = " LIKE N'%" & deger & "%' "
        ElseIf kriter = "Boş" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklı" Then
            sorgu_kriter = " <> N'" & deger & "' "
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = " >  N'" & deger & "' "
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = " < N'" & deger & "' "
        ElseIf kriter = "Eşittir" Then
            sorgu_kriter = " = N'" & deger & "' "
        End If
        Return sorgu_kriter
    End Function
    Public Function stok(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String) As DataSet
        Dim kriter = "WHERE tbStok.sKodu <> '' and tbStok.nStokTipi < 5  "
        Dim sResim As String = ""
        Dim muadilB As String = "(tbStokBarkodu.nKisim IN(0))"
        If CheckEdit1.Checked = True Then
            muadilB = "(tbStokBarkodu.nKisim IN (0, 1))"
        End If
        ' Web Görüntüle filtresi
        If sec_webGoruntule IsNot Nothing AndAlso sec_webGoruntule.Checked = True Then
            kriter += " AND tbStok.bWebGoruntule = 1 "
        End If
        If Trim(ara).ToString <> "" Then
            If konum = "Kod" Then
                kriter += " AND (tbStok.sKodu " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Ad" Then
                kriter += " AND (tbStok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Not" Then
                kriter += " AND (tbStok.sOzelNot " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "KısaKod" Then
                kriter += " AND (tbStok.sKisaAdi " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Gelişmiş" Then
                kriter += " AND (tbStok.skodu " & sorgu_kriter_string(ara, ara_kriter) & ") OR (tbStok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") OR  (tbStok.sOzelNot " & sorgu_kriter_string(ara, ara_kriter) & ")OR  (tbStok.sKisaAdi " & sorgu_kriter_string(ara, ara_kriter) & ") OR tbStok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(ara, ara_kriter) & ")  OR (tbStok.sRenk " & sorgu_kriter_string(ara, ara_kriter) & ") OR (tbStok.sbeden " & sorgu_kriter_string(ara, ara_kriter) & ") "
            ElseIf konum = "Seri No" Then
                kriter += " AND (tbStok.nStokID IN (Select nStokID from tbStokFisiSeriNo where sSeri " & sorgu_kriter_string(ara, ara_kriter) & ")) "
            ElseIf konum = "Barkod" Then
                kriter += " AND (tbStok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(ara, ara_kriter) & ")) "
            ElseIf konum = "Sınıf1" Then
                'kriter += " AND ( tbSSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu WHERE tbSSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Sınıf2" Then
                'kriter += " AND ( tbSSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu WHERE tbSSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Sınıf3" Then
                'kriter += " AND ( tbSSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu WHERE tbSSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Sınıf4" Then
                'kriter += " AND ( tbSSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu WHERE tbSSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Sınıf5" Then
                'kriter += " AND ( tbSSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Sınıf6" Then
                'kriter += " AND ( tbSSinif6.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu WHERE tbSSinif6.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Sınıf7" Then
                'kriter += " AND ( tbSSinif7.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu WHERE tbSSinif7.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Sınıf8" Then
                'kriter += " AND ( tbSSinif8.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu WHERE tbSSinif8.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Sınıf9" Then
                'kriter += " AND ( tbSSinif9.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu WHERE tbSSinif9.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Sınıf10" Then
                'kriter += " AND ( tbSSinif10.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif1.sSinifKodu WHERE tbSSinif10.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Sınıf11" Then
                'kriter += " AND ( tbSSinif11.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu WHERE tbSSinif11.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Sınıf12" Then
                'kriter += " AND ( tbSSinif12.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu WHERE tbSSinif12.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Sınıf13" Then
                'kriter += " AND ( tbSSinif13.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu WHERE tbSSinif13.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Sınıf14" Then
                'kriter += " AND ( tbSSinif14.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu WHERE tbSSinif14.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            ElseIf konum = "Sınıf15" Then
                'kriter += " AND ( tbSSinif15.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
                kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu WHERE tbSSinif15.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
            End If
        End If
        If sStokSinirla <> "" Then
            kriter += " AND (tbStok.sKodu like '" & sStokSinirla & "%') "
        End If
        If islemstatus = True And ara = "" Then
            count = " TOP 1000 "
        End If
        If islemstatus = False And bStokKarti = True And ara = "" Then
            count = " TOP 1000 "
        End If
        If nKayitSinir > 0 Then
            count = " TOP " & nKayitSinir & " "
        End If
        If sec_bResimGoster.Checked = True Then
            ' Resim sorgusu: Önce nStokID, sonra model+renk, sonra sadece model
            ' Renksiz ürünler için de çalışacak şekilde düzenlendi
            sResim = " (SELECT TOP 1 pResim FROM tbStokResim WHERE " &
                     "(nStokID = tbStok.nStokID) OR " &
                     "((sModel = tbStok.sModel) AND " &
                     " ((sRenk = tbStok.sRenk) OR (sRenk IS NULL AND tbStok.sRenk IS NULL) OR (sRenk = '' AND tbStok.sRenk = '')) AND " &
                     " ((sBeden = tbStok.sBeden) OR (sBeden IS NULL) OR (sBeden = '')) AND " &
                     " ((sKavala = tbStok.sKavala) OR (sKavala IS NULL) OR (sKavala = ''))) OR " &
                     "(sModel = tbStok.sModel) " &
                     "ORDER BY " &
                     "CASE WHEN nStokID = tbStok.nStokID THEN 1 " &
                     "     WHEN sRenk = tbStok.sRenk THEN 2 " &
                     "     ELSE 3 END, nSira) AS pResim, "
            colpResim.Visible = sec_bResimGoster.Checked
            GridView1.RowHeight = 125
        Else
            colpResim.Visible = False
            GridView1.RowHeight = -1
            sResim = ""
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        Dim kriter_fiyat As String = ""
        If sec_fiyatli.Checked = True Then
            kriter_fiyat = " ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS lFiyat4, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS FIYAT5 ,"
        End If
        If islemstatus = True Then
            ' DÜZELTME: LEFT OUTER JOIN yerine OUTER APPLY kullanılarak mükerrer kayıt sorunu giderildi
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " tbStok.*, " & sResim & " ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, CAST((SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) / ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS MONEY) AS lMevcut2, ISNULL(BarkodAna.sBarkod, '') as sBarkod, ISNULL(BarkodMuadil.sBarkod, '') as nMuadilBarkod, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'), 0) AS lFiyat4, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS FIYAT5, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS FIYAT6,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, (SELECT COUNT(DISTINCT nStokID) AS nKayit FROM tbStokFiyati WHERE (dteFiyatTespitTarihi between '" & DateAdd(DateInterval.Day, -3, dteSistemTarihi) & "' and '" & dteSistemTarihi & "') AND (sFiyatTipi IN ('" & sFiyat1 & "' , '" & sFiyat2 & "' , '" & sFiyat3 & "')) AND nStokID = tbStok.nStokID) AS bFiyatDegisti,bYeni = Case When (CONVERT(char(10), tbStok.dteKayitTarihi, 103) = '" & dteSistemTarihi & "') Then 1 else 0 END FROM tbStok OUTER APPLY (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID AND nKisim = 0) BarkodAna OUTER APPLY (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID AND nKisim = 1) BarkodMuadil " & kriter & " ORDER BY tbStok.sKodu")
        Else
            ' DÜZELTME: tbStokSinifi JOIN'i de OUTER APPLY ile değiştirildi - mükerrer kayıt sorunu giderildi
            If sec_bResimGoster.Checked = True Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " tbStok.*," & sResim & " ISNULL((SELECT ISNULL(lOran, 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,CAST((SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) / ISNULL((SELECT ISNULL(lOran, 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS MONEY) as lMevcut2, " & kriter_fiyat & " ISNULL(BarkodAna.sBarkod, '') AS sBarkod, ISNULL(SinifData.Sinif1, '') AS Sinif1, ISNULL(SinifData.Sinif2, '') AS Sinif2, ISNULL(SinifData.Sinif3, '') AS Sinif3, ISNULL(SinifData.Sinif4, '') AS Sinif4, ISNULL(SinifData.Sinif5, '') AS Sinif5, ISNULL(SinifData.Sinif6, '') AS Sinif6, ISNULL(SinifData.Sinif7, '') AS Sinif7, ISNULL(SinifData.Sinif8, '') AS Sinif8, ISNULL(SinifData.Sinif9, '') AS Sinif9, ISNULL(SinifData.Sinif10, '') AS Sinif10, ISNULL(SinifData.Sinif11, '') AS Sinif11, ISNULL(SinifData.Sinif12, '') AS Sinif12, ISNULL(SinifData.Sinif13, '') AS Sinif13, ISNULL(SinifData.Sinif14, '') AS Sinif14, ISNULL(SinifData.Sinif15, '') AS Sinif15, ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10, '') AS ISTIHBARAT,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut FROM tbStok OUTER APPLY (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID AND nKisim = 0) BarkodAna OUTER APPLY (SELECT TOP 1 s1.sAciklama AS Sinif1, s2.sAciklama AS Sinif2, s3.sAciklama AS Sinif3, s4.sAciklama AS Sinif4, s5.sAciklama AS Sinif5, s6.sAciklama AS Sinif6, s7.sAciklama AS Sinif7, s8.sAciklama AS Sinif8, s9.sAciklama AS Sinif9, s10.sAciklama AS Sinif10, s11.sAciklama AS Sinif11, s12.sAciklama AS Sinif12, s13.sAciklama AS Sinif13, s14.sAciklama AS Sinif14, s15.sAciklama AS Sinif15 FROM tbStokSinifi ss LEFT JOIN tbSSinif1 s1 ON ss.sSinifKodu1 = s1.sSinifKodu LEFT JOIN tbSSinif2 s2 ON ss.sSinifKodu2 = s2.sSinifKodu LEFT JOIN tbSSinif3 s3 ON ss.sSinifKodu3 = s3.sSinifKodu LEFT JOIN tbSSinif4 s4 ON ss.sSinifKodu4 = s4.sSinifKodu LEFT JOIN tbSSinif5 s5 ON ss.sSinifKodu5 = s5.sSinifKodu LEFT JOIN tbSSinif6 s6 ON ss.sSinifKodu6 = s6.sSinifKodu LEFT JOIN tbSSinif7 s7 ON ss.sSinifKodu7 = s7.sSinifKodu LEFT JOIN tbSSinif8 s8 ON ss.sSinifKodu8 = s8.sSinifKodu LEFT JOIN tbSSinif9 s9 ON ss.sSinifKodu9 = s9.sSinifKodu LEFT JOIN tbSSinif10 s10 ON ss.sSinifKodu10 = s10.sSinifKodu LEFT JOIN tbSSinif11 s11 ON ss.sSinifKodu11 = s11.sSinifKodu LEFT JOIN tbSSinif12 s12 ON ss.sSinifKodu12 = s12.sSinifKodu LEFT JOIN tbSSinif13 s13 ON ss.sSinifKodu13 = s13.sSinifKodu LEFT JOIN tbSSinif14 s14 ON ss.sSinifKodu14 = s14.sSinifKodu LEFT JOIN tbSSinif15 s15 ON ss.sSinifKodu15 = s15.sSinifKodu WHERE ss.sModel = tbStok.sModel) SinifData LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " ORDER BY tbStok.sKodu")
            Else
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " tbStok.*," & sResim & " ISNULL((SELECT ISNULL(lOran, 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,CAST((SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) / ISNULL((SELECT ISNULL(lOran, 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS MONEY) as lMevcut2, " & kriter_fiyat & " ISNULL(BarkodAna.sBarkod, '') AS sBarkod, ISNULL(SinifData.Sinif1, '') AS Sinif1, ISNULL(SinifData.Sinif2, '') AS Sinif2, ISNULL(SinifData.Sinif3, '') AS Sinif3, ISNULL(SinifData.Sinif4, '') AS Sinif4, ISNULL(SinifData.Sinif5, '') AS Sinif5, ISNULL(SinifData.Sinif6, '') AS Sinif6, ISNULL(SinifData.Sinif7, '') AS Sinif7, ISNULL(SinifData.Sinif8, '') AS Sinif8, ISNULL(SinifData.Sinif9, '') AS Sinif9, ISNULL(SinifData.Sinif10, '') AS Sinif10, ISNULL(SinifData.Sinif11, '') AS Sinif11, ISNULL(SinifData.Sinif12, '') AS Sinif12, ISNULL(SinifData.Sinif13, '') AS Sinif13, ISNULL(SinifData.Sinif14, '') AS Sinif14, ISNULL(SinifData.Sinif15, '') AS Sinif15, ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10, '') AS ISTIHBARAT,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut FROM tbStok OUTER APPLY (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID AND nKisim = 0) BarkodAna OUTER APPLY (SELECT TOP 1 s1.sAciklama AS Sinif1, s2.sAciklama AS Sinif2, s3.sAciklama AS Sinif3, s4.sAciklama AS Sinif4, s5.sAciklama AS Sinif5, s6.sAciklama AS Sinif6, s7.sAciklama AS Sinif7, s8.sAciklama AS Sinif8, s9.sAciklama AS Sinif9, s10.sAciklama AS Sinif10, s11.sAciklama AS Sinif11, s12.sAciklama AS Sinif12, s13.sAciklama AS Sinif13, s14.sAciklama AS Sinif14, s15.sAciklama AS Sinif15 FROM tbStokSinifi ss LEFT JOIN tbSSinif1 s1 ON ss.sSinifKodu1 = s1.sSinifKodu LEFT JOIN tbSSinif2 s2 ON ss.sSinifKodu2 = s2.sSinifKodu LEFT JOIN tbSSinif3 s3 ON ss.sSinifKodu3 = s3.sSinifKodu LEFT JOIN tbSSinif4 s4 ON ss.sSinifKodu4 = s4.sSinifKodu LEFT JOIN tbSSinif5 s5 ON ss.sSinifKodu5 = s5.sSinifKodu LEFT JOIN tbSSinif6 s6 ON ss.sSinifKodu6 = s6.sSinifKodu LEFT JOIN tbSSinif7 s7 ON ss.sSinifKodu7 = s7.sSinifKodu LEFT JOIN tbSSinif8 s8 ON ss.sSinifKodu8 = s8.sSinifKodu LEFT JOIN tbSSinif9 s9 ON ss.sSinifKodu9 = s9.sSinifKodu LEFT JOIN tbSSinif10 s10 ON ss.sSinifKodu10 = s10.sSinifKodu LEFT JOIN tbSSinif11 s11 ON ss.sSinifKodu11 = s11.sSinifKodu LEFT JOIN tbSSinif12 s12 ON ss.sSinifKodu12 = s12.sSinifKodu LEFT JOIN tbSSinif13 s13 ON ss.sSinifKodu13 = s13.sSinifKodu LEFT JOIN tbSSinif14 s14 ON ss.sSinifKodu14 = s14.sSinifKodu LEFT JOIN tbSSinif15 s15 ON ss.sSinifKodu15 = s15.sSinifKodu WHERE ss.sModel = tbStok.sModel) SinifData LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " ORDER BY tbStok.sKodu")
            End If
        End If
        ' DÜZELTME: bStokKarti = True durumunda da OUTER APPLY ile mükerrer kayıt sorunu giderildi
        If bStokKarti = True Then
            If sec_bResimGoster.Checked = True Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " tbStok.*, " & sResim & " ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, CAST((SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) / ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS MONEY) AS lMevcut2, ISNULL(BarkodAna.sBarkod, '') as sBarkod, ISNULL(BarkodMuadil.sBarkod, '') as nMuadilBarkod, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'), 0) AS lFiyat4, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS FIYAT5,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS FIYAT6, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, (SELECT COUNT(DISTINCT nStokID) AS nKayit FROM tbStokFiyati WHERE (dteFiyatTespitTarihi between '" & DateAdd(DateInterval.Day, -3, dteSistemTarihi) & "' and '" & dteSistemTarihi & "') AND (sFiyatTipi IN ('" & sFiyat1 & "' , '" & sFiyat2 & "' , '" & sFiyat3 & "')) AND nStokID = tbStok.nStokID) AS bFiyatDegisti,bYeni = Case When (CONVERT(char(10), tbStok.dteKayitTarihi, 103) = '" & dteSistemTarihi & "') Then 1 else 0 END,tbDepoDetayi.sDepo1, tbDepoDetayi.sDepo2, tbDepoDetayi.sDepo3, tbDepoDetayi.sDepo4, tbDepoDetayi.sDepo5, tbDepoDetayi.sDepo6, tbDepoDetayi.sDepo7, tbDepoDetayi.sDepo8, ISNULL(SinifData.Sinif1, '') AS Sinif1 FROM tbStok OUTER APPLY (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID AND nKisim = 0) BarkodAna OUTER APPLY (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID AND nKisim = 1) BarkodMuadil OUTER APPLY (SELECT TOP 1 s1.sAciklama AS Sinif1 FROM tbStokSinifi ss LEFT JOIN tbSSinif1 s1 ON ss.sSinifKodu1 = s1.sSinifKodu WHERE ss.sModel = tbStok.sModel) SinifData LEFT OUTER JOIN (SELECT nStokID , SUM(sDepo1) AS sDepo1 , SUM(sDepo2) AS sDepo2 , SUM(sDepo3) AS sDepo3 , SUM(sDepo4) AS sDepo4 , SUM(sDepo5) AS sDepo5, SUM(sDepo6) AS sDepo6, SUM(sDepo7) AS sDepo7, SUM(sDepo8) AS sDepo8 FROM (SELECT  nStokID , CASE WHEN RTRIM(UPPER(sDepo)) = 'D001' THEN lGirisMiktar1 - lCikisMiktar1 ELSE 0 END AS sDepo1 , CASE WHEN RTRIM(UPPER(sDepo)) = 'D002' THEN lGirisMiktar1 - lCikisMiktar1 ELSE 0 END AS sDepo2 , CASE WHEN RTRIM(UPPER(sDepo)) = 'D003' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo3 , CASE WHEN RTRIM(UPPER(sDepo)) = 'D004' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo4 , CASE WHEN RTRIM(UPPER(sDepo)) = 'D005' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo5, CASE WHEN RTRIM(UPPER(sDepo)) = 'D006' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo6, CASE WHEN RTRIM(UPPER(sDepo)) = 'D007' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo7, CASE WHEN RTRIM(UPPER(sDepo)) = 'D099' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo8 FROM tbStokFisiDetayi) tbStokFisiDetayi GROUP BY nStokID) tbDepoDetayi ON tbStok.nStokID = tbDepoDetayi.nStokID " & kriter & " ORDER BY tbStok.sKodu")
            Else
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " tbStok.*, " & sResim & " ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, CAST((SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) / ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS MONEY) AS lMevcut2, ISNULL(BarkodAna.sBarkod, '') as sBarkod, ISNULL(BarkodMuadil.sBarkod, '') as nMuadilBarkod, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'), 0) AS lFiyat4, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS FIYAT5,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS FIYAT6, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, (SELECT COUNT(DISTINCT nStokID) AS nKayit FROM tbStokFiyati WHERE (dteFiyatTespitTarihi between '" & DateAdd(DateInterval.Day, -3, dteSistemTarihi) & "' and '" & dteSistemTarihi & "') AND (sFiyatTipi IN ('" & sFiyat1 & "' , '" & sFiyat2 & "' , '" & sFiyat3 & "')) AND nStokID = tbStok.nStokID) AS bFiyatDegisti,bYeni = Case When (CONVERT(char(10), tbStok.dteKayitTarihi, 103) = '" & dteSistemTarihi & "') Then 1 else 0 END,tbDepoDetayi.sDepo1, tbDepoDetayi.sDepo2, tbDepoDetayi.sDepo3, tbDepoDetayi.sDepo4, tbDepoDetayi.sDepo5, tbDepoDetayi.sDepo6, tbDepoDetayi.sDepo7, tbDepoDetayi.sDepo8, ISNULL(SinifData.Sinif1, '') AS Sinif1, ISNULL(SinifData.Sinif2, '') AS Sinif2, ISNULL(SinifData.Sinif3, '') AS Sinif3, ISNULL(SinifData.Sinif4, '') AS Sinif4, ISNULL(SinifData.Sinif5, '') AS Sinif5, ISNULL(SinifData.Sinif6, '') AS Sinif6, ISNULL(SinifData.Sinif7, '') AS Sinif7, ISNULL(SinifData.Sinif8, '') AS Sinif8, ISNULL(SinifData.Sinif9, '') AS Sinif9 FROM tbStok OUTER APPLY (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID AND nKisim = 0) BarkodAna OUTER APPLY (SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID AND nKisim = 1) BarkodMuadil OUTER APPLY (SELECT TOP 1 s1.sAciklama AS Sinif1, s2.sAciklama AS Sinif2, s3.sAciklama AS Sinif3, s4.sAciklama AS Sinif4, s5.sAciklama AS Sinif5, s6.sAciklama AS Sinif6, s7.sAciklama AS Sinif7, s8.sAciklama AS Sinif8, s9.sAciklama AS Sinif9 FROM tbStokSinifi ss LEFT JOIN tbSSinif1 s1 ON ss.sSinifKodu1 = s1.sSinifKodu LEFT JOIN tbSSinif2 s2 ON ss.sSinifKodu2 = s2.sSinifKodu LEFT JOIN tbSSinif3 s3 ON ss.sSinifKodu3 = s3.sSinifKodu LEFT JOIN tbSSinif4 s4 ON ss.sSinifKodu4 = s4.sSinifKodu LEFT JOIN tbSSinif5 s5 ON ss.sSinifKodu5 = s5.sSinifKodu LEFT JOIN tbSSinif6 s6 ON ss.sSinifKodu6 = s6.sSinifKodu LEFT JOIN tbSSinif7 s7 ON ss.sSinifKodu7 = s7.sSinifKodu LEFT JOIN tbSSinif8 s8 ON ss.sSinifKodu8 = s8.sSinifKodu LEFT JOIN tbSSinif9 s9 ON ss.sSinifKodu9 = s9.sSinifKodu WHERE ss.sModel = tbStok.sModel) SinifData LEFT OUTER JOIN (SELECT nStokID , SUM(sDepo1) AS sDepo1 , SUM(sDepo2) AS sDepo2 , SUM(sDepo3) AS sDepo3 , SUM(sDepo4) AS sDepo4 , SUM(sDepo5) AS sDepo5, SUM(sDepo6) AS sDepo6, SUM(sDepo7) AS sDepo7, SUM(sDepo8) AS sDepo8 FROM (SELECT  nStokID , CASE WHEN RTRIM(UPPER(sDepo)) = 'D001' THEN lGirisMiktar1 - lCikisMiktar1 ELSE 0 END AS sDepo1 , CASE WHEN RTRIM(UPPER(sDepo)) = 'D002' THEN lGirisMiktar1 - lCikisMiktar1 ELSE 0 END AS sDepo2 , CASE WHEN RTRIM(UPPER(sDepo)) = 'D003' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo3 , CASE WHEN RTRIM(UPPER(sDepo)) = 'D004' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo4, CASE WHEN RTRIM(UPPER(sDepo)) = 'D005' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo5, CASE WHEN RTRIM(UPPER(sDepo)) = 'D006' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo6, CASE WHEN RTRIM(UPPER(sDepo)) = 'D007' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo7, CASE WHEN RTRIM(UPPER(sDepo)) = 'D099' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo8 FROM tbStokFisiDetayi) tbStokFisiDetayi GROUP BY nStokID) tbDepoDetayi ON tbStok.nStokID = tbDepoDetayi.nStokID " & kriter & " ORDER BY tbStok.sKodu")
            End If
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " tbStok.*,  tbStokBarkodu.sBarkod AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS FIYAT4, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS FIYAT5, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, (SELECT COUNT(DISTINCT nStokID) AS nKayit FROM tbStokFiyati WHERE (dteFiyatTespitTarihi = '" & Today & "') AND (sFiyatTipi IN ('" & sFiyat1 & "' , '" & sFiyat2 & "' , '" & sFiyat3 & "')) AND nStokID = tbStok.nStokID) AS bFiyatDegisti FROM tbStok LEFT OUTER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim = 0 " & kriter & " ORDER BY tbStok.sKodu")
        End If
        cmd.Connection = conn
        conn.Open()

        ' DEBUG LOG - SQL sorgusunu dosyaya yaz
        Try
            System.IO.File.WriteAllText("C:\Eticaret\debug_sql.txt", "islemstatus: " & islemstatus.ToString() & vbCrLf & "bStokKarti: " & bStokKarti.ToString() & vbCrLf & "sec_bResimGoster: " & sec_bResimGoster.Checked.ToString() & vbCrLf & vbCrLf & cmd.CommandText)
        Catch
        End Try

        Dim Datastoklar1 As New DataSet

        Try
            ' Memory efficient fill with timeout
            adapter.SelectCommand.CommandTimeout = 120 ' 2 dakika timeout
            Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")

            ' Eğer çok fazla satır varsa uyar
            If N > 10000 Then
                MessageBox.Show("Çok fazla kayıt yüklendi (" & N.ToString() & "). Daha spesifik filtre kullanın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch outOfMemEx As OutOfMemoryException
            ' Out of memory hatası
            MessageBox.Show("Bellek yetersiz! Lütfen daha az kayıt döndürecek şekilde filtre uygulayın.", "Bellek Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Cache'i temizle
            If imageCache IsNot Nothing Then
                ClearImageCache()
            End If

            ' GC zorla
            GC.Collect()
            GC.WaitForPendingFinalizers()
            GC.Collect()

            Return Nothing

        Catch ex As Exception
            MessageBox.Show("Veri yüklenirken hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        Return Datastoklar1
    End Function


    'Public Function stok(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String) As DataSet
    '    Dim kriter As String = "WHERE tbStok.sKodu <> '' and tbStok.nStokTipi < 5  "
    '    Dim sResimSelect As String = ""   ' SELECT listesine eklenecek para (yol kolonu)
    '    Dim sResimJoin As String = ""     ' FROM sonrasna eklenecek JOIN
    '    Dim muadilB As String = "(tbStokBarkodu.nKisim IN(0))"

    '    If CheckEdit1.Checked = True Then
    '        muadilB = "(tbStokBarkodu.nKisim IN (0, 1))"
    '    End If

    '    If Trim(ara).ToString <> "" Then
    '        If konum = "Kod" Then
    '            kriter += " AND (tbStok.sKodu " & sorgu_kriter_string(ara, ara_kriter) & ")"
    '        ElseIf konum = "Ad" Then
    '            kriter += " AND (tbStok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
    '        ElseIf konum = "Not" Then
    '            kriter += " AND (tbStok.sOzelNot " & sorgu_kriter_string(ara, ara_kriter) & ")"
    '        ElseIf konum = "KısaKod" Then
    '            kriter += " AND (tbStok.sKisaAdi " & sorgu_kriter_string(ara, ara_kriter) & ")"
    '        ElseIf konum = "Gelişmiş" Then
    '            kriter += " AND (tbStok.skodu " & sorgu_kriter_string(ara, ara_kriter) & ") OR (tbStok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") OR  (tbStok.sOzelNot " & sorgu_kriter_string(ara, ara_kriter) & ")OR  (tbStok.sKisaAdi " & sorgu_kriter_string(ara, ara_kriter) & ") OR tbStok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(ara, ara_kriter) & ")  OR (tbStok.sRenk " & sorgu_kriter_string(ara, ara_kriter) & ") OR (tbStok.sbeden " & sorgu_kriter_string(ara, ara_kriter) & ") "
    '        ElseIf konum = "Seri No" Then
    '            kriter += " AND (tbStok.nStokID IN (Select nStokID from tbStokFisiSeriNo where sSeri " & sorgu_kriter_string(ara, ara_kriter) & ")) "
    '        ElseIf konum = "Barkod" Then
    '            kriter += " AND (tbStok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(ara, ara_kriter) & ")) "
    '        ElseIf konum = "Sınıf1" Then
    '            'kriter += " AND ( tbSSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
    '            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu WHERE tbSSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
    '        ElseIf konum = "Sınıf2" Then
    '            'kriter += " AND ( tbSSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
    '            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu WHERE tbSSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
    '        ElseIf konum = "Sınıf3" Then
    '            'kriter += " AND ( tbSSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
    '            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu WHERE tbSSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
    '        ElseIf konum = "Sınıf4" Then
    '            'kriter += " AND ( tbSSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
    '            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu WHERE tbSSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
    '        ElseIf konum = "Sınıf5" Then
    '            'kriter += " AND ( tbSSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
    '            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
    '        ElseIf konum = "Sınıf6" Then
    '            'kriter += " AND ( tbSSinif6.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
    '            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu WHERE tbSSinif6.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
    '        ElseIf konum = "Sınıf7" Then
    '            'kriter += " AND ( tbSSinif7.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
    '            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu WHERE tbSSinif7.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
    '        ElseIf konum = "Sınıf8" Then
    '            'kriter += " AND ( tbSSinif8.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
    '            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu WHERE tbSSinif8.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
    '        ElseIf konum = "Sınıf9" Then
    '            'kriter += " AND ( tbSSinif9.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
    '            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu WHERE tbSSinif9.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
    '        ElseIf konum = "Sınıf10" Then
    '            'kriter += " AND ( tbSSinif10.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
    '            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif1.sSinifKodu WHERE tbSSinif10.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
    '        ElseIf konum = "Sınıf11" Then
    '            'kriter += " AND ( tbSSinif11.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
    '            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu WHERE tbSSinif11.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
    '        ElseIf konum = "Sınıf12" Then
    '            'kriter += " AND ( tbSSinif12.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
    '            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu WHERE tbSSinif12.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
    '        ElseIf konum = "Sınıf13" Then
    '            'kriter += " AND ( tbSSinif13.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
    '            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu WHERE tbSSinif13.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
    '        ElseIf konum = "Sınıf14" Then
    '            'kriter += " AND ( tbSSinif14.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
    '            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu WHERE tbSSinif14.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
    '        ElseIf konum = "Sınıf15" Then
    '            'kriter += " AND ( tbSSinif15.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
    '            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu WHERE tbSSinif15.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
    '        End If
    '    End If

    '    If sStokSinirla <> "" Then
    '        kriter &= " AND (tbStok.sKodu like '" & sStokSinirla & "%') "
    '    End If

    '    If islemstatus = True And ara = "" Then
    '        count = " TOP 1000 "
    '    End If
    '    If islemstatus = False And bStokKarti = True And ara = "" Then
    '        count = " TOP 1000 "
    '    End If
    '    If nKayitSinir > 0 Then
    '        count = " TOP " & nKayitSinir & " "
    '    End If

    '    ' --- SADECE RESM KISMI ---
    '    If sec_bResimGoster.Checked = True Then
    '        ' JOIN + SELECT (yol kolonu var)
    '        sResimJoin =
    '" OUTER APPLY (SELECT TOP 1 pResim, yol FROM tbStokResim WHERE sModel = tbStok.sModel ORDER BY nStokResimID) R "
    '        sResimSelect = " R.pResim AS pResim, R.yol AS yol, "
    '        colpResim.Visible = sec_bResimGoster.Checked
    '        GridView1.RowHeight = 125
    '    Else
    '        ' JOIN yok, SELECT'e de resim kolonu eklenmiyor
    '        sResimJoin = ""
    '        sResimSelect = ""
    '        colpResim.Visible = False
    '        GridView1.RowHeight = -1
    '    End If
    '    ' --------------------------

    '    Dim conn As New OleDb.OleDbConnection
    '    Dim cmd As New OleDb.OleDbCommand
    '    Dim adapter As New OleDb.OleDbDataAdapter
    '    conn.ConnectionString = connection
    '    cmd.CommandTimeout = False
    '    adapter.SelectCommand = cmd

    '    Dim kriter_fiyat As String = ""
    '    If sec_fiyatli.Checked = True Then
    '        kriter_fiyat = " ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, " &
    '                   " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, " &
    '                   " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, " &
    '                   " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS lFiyat4, " &
    '                   " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS FIYAT5 ,"
    '    End If

    '    If islemstatus = True Then
    '        ' ---- Sorgu (islemstatus = True) ----
    '        cmd.CommandText = sorgu_query(
    '        "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " &
    '        "SELECT " & count & " tbStok.*, " & sResimSelect &
    '        " ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, " &
    '        " CAST((SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) / ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS MONEY) AS lMevcut2, " &
    '        " (case when tbStokBarkodu.nKisim=0 then tbStokBarkodu.sBarkod else '' end) as sBarkod, " &
    '        " (case when tbStokBarkodu.nKisim=1 then tbStokBarkodu.sBarkod else '' end) as nMuadilBarkod, " &
    '        " (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, " &
    '        " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, " &
    '        " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, " &
    '        " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, " &
    '        " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'), 0) AS lFiyat4, " &
    '        " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS FIYAT5, " &
    '        " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS FIYAT6, " &
    '        " (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, " &
    '        " (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, " &
    '        " (SELECT COUNT(DISTINCT nStokID) AS nKayit FROM tbStokFiyati WHERE (dteFiyatTespitTarihi between '" & DateAdd(DateInterval.Day, -3, dteSistemTarihi) & "' and '" & dteSistemTarihi & "') AND (sFiyatTipi IN ('" & sFiyat1 & "' , '" & sFiyat2 & "' , '" & sFiyat3 & "')) AND nStokID = tbStok.nStokID) AS bFiyatDegisti, " &
    '        " bYeni = Case When (CONVERT(char(10), tbStok.dteKayitTarihi, 103) = '" & dteSistemTarihi & "') Then 1 else 0 END " &
    '        " FROM tbStok " & sResimJoin &
    '        " LEFT JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND " & muadilB & " " &
    '        " " & kriter & " " &
    '        " ORDER BY tbStok.sKodu"
    '    )
    '    Else
    '        If sec_bResimGoster.Checked = True Then
    '            ' ---- Sorgu (islemstatus = False, resim ak) ----
    '            cmd.CommandText = sorgu_query(
    '            "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " &
    '            "SELECT " & count & " tbStok.*, " & sResimSelect &
    '            " ISNULL((SELECT ISNULL(lOran, 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, " &
    '            " CAST((SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) / ISNULL((SELECT ISNULL(lOran, 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS MONEY) as lMevcut2, " &
    '            kriter_fiyat &
    '            " tbStokBarkodu.sBarkod, " &
    '            " tbSSinif1.sAciklama AS Sinif1, tbSSinif2.sAciklama AS Sinif2, tbSSinif3.sAciklama AS Sinif3, tbSSinif4.sAciklama AS Sinif4, tbSSinif5.sAciklama AS Sinif5, tbSSinif6.sAciklama AS Sinif6, tbSSinif7.sAciklama AS Sinif7, tbSSinif8.sAciklama AS Sinif8, tbSSinif9.sAciklama AS Sinif9, tbSSinif10.sAciklama AS Sinif10, tbSSinif11.sAciklama AS Sinif11, tbSSinif12.sAciklama AS Sinif12, tbSSinif13.sAciklama AS Sinif13, tbSSinif14.sAciklama AS Sinif14, tbSSinif15.sAciklama AS Sinif15, " &
    '            " ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10, '') AS ISTIHBARAT, " &
    '            " (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut " &
    '            " FROM tbStok " & sResimJoin &
    '            " LEFT OUTER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID " &
    '            " INNER JOIN tbStokSinifi ON tbStokSinifi.sModel = tbStok.sModel " &
    '            " INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu " &
    '            " INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu " &
    '            " INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu " &
    '            " INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu " &
    '            " INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu " &
    '            " INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu " &
    '            " INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu " &
    '            " INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu " &
    '            " INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu " &
    '            " INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu " &
    '            " INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu " &
    '            " INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu " &
    '            " INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu " &
    '            " INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu " &
    '            " INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu " &
    '            " LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " &
    '            " " & kriter & " ORDER BY tbStok.sKodu"
    '        )
    '        Else
    '            ' ---- Sorgu (islemstatus = False, resim kapal) ----
    '            cmd.CommandText = sorgu_query(
    '            "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " &
    '            "SELECT " & count & " tbStok.*, " &
    '            " ISNULL((SELECT ISNULL(lOran, 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, " &
    '            " CAST((SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) / ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS MONEY) AS lMevcut2, " &
    '            " (case when tbStokBarkodu.nKisim=0 then tbStokBarkodu.sBarkod else '' end) as sBarkod, " &
    '            " (case when tbStokBarkodu.nKisim=1 then tbStokBarkodu.sBarkod else '' end) as nMuadilBarkod, " &
    '            " (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, " &
    '            " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, " &
    '            " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, " &
    '            " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, " &
    '            " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'), 0) AS lFiyat4, " &
    '            " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS FIYAT5, " &
    '            " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS FIYAT6, " &
    '            " (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, " &
    '            " (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, " &
    '            " (SELECT COUNT(DISTINCT nStokID) AS nKayit FROM tbStokFiyati WHERE (dteFiyatTespitTarihi between '" & DateAdd(DateInterval.Day, -3, dteSistemTarihi) & "' and '" & dteSistemTarihi & "') AND (sFiyatTipi IN ('" & sFiyat1 & "' , '" & sFiyat2 & "' , '" & sFiyat3 & "')) AND nStokID = tbStok.nStokID) AS bFiyatDegisti, " &
    '            " bYeni = Case When (CONVERT(char(10), tbStok.dteKayitTarihi, 103) = '" & dteSistemTarihi & "') Then 1 else 0 END, " &
    '            " tbDepoDetayi.sDepo1, tbDepoDetayi.sDepo2, tbDepoDetayi.sDepo3, tbDepoDetayi.sDepo4, tbDepoDetayi.sDepo5, tbDepoDetayi.sDepo6, tbDepoDetayi.sDepo7, tbDepoDetayi.sDepo8, " &
    '            " tbSSinif1.sAciklama AS Sinif1, tbSSinif2.sAciklama AS Sinif2, tbSSinif3.sAciklama AS Sinif3, tbSSinif4.sAciklama AS Sinif4, tbSSinif5.sAciklama AS Sinif5, tbSSinif6.sAciklama AS Sinif6, tbSSinif7.sAciklama AS Sinif7, tbSSinif8.sAciklama AS Sinif8, tbSSinif9.sAciklama AS Sinif9 " &
    '            " FROM tbStok " & sResimJoin &
    '            " LEFT OUTER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND " & muadilB & " " &
    '            " INNER JOIN tbStokSinifi ON tbStokSinifi.sModel = tbStok.sModel " &
    '            " INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu " &
    '            " INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu " &
    '            " INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu " &
    '            " INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu " &
    '            " INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu " &
    '            " INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu " &
    '            " INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu " &
    '            " INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu " &
    '            " INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu " &
    '            " LEFT OUTER JOIN ( " &
    '            "   SELECT nStokID , SUM(sDepo1) AS sDepo1 , SUM(sDepo2) AS sDepo2 , SUM(sDepo3) AS sDepo3 , SUM(sDepo4) AS sDepo4 , SUM(sDepo5) AS sDepo5, SUM(sDepo6) AS sDepo6, SUM(sDepo7) AS sDepo7, SUM(sDepo8) AS sDepo8 " &
    '            "   FROM ( " &
    '            "       SELECT  nStokID , " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D001' THEN lGirisMiktar1 - lCikisMiktar1 ELSE 0 END AS sDepo1 , " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D002' THEN lGirisMiktar1 - lCikisMiktar1 ELSE 0 END AS sDepo2 , " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D003' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo3 , " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D004' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo4 , " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D005' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo5, " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D006' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo6, " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D007' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo7, " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D099' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo8 " &
    '            "       FROM tbStokFisiDetayi " &
    '            "   ) tbStokFisiDetayi GROUP BY nStokID " &
    '            " ) tbDepoDetayi ON tbStok.nStokID = tbDepoDetayi.nStokID " &
    '            " " & kriter & " ORDER BY tbStok.sKodu"
    '        )
    '        End If
    '    End If

    '    If bStokKarti = True Then
    '        If sec_bResimGoster.Checked = True Then
    '            ' ---- Sorgu (bStokKarti = True, resim ak) ----
    '            cmd.CommandText = sorgu_query(
    '            "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " &
    '            "SELECT " & count & " tbStok.*, " & sResimSelect &
    '            " ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, " &
    '            " CAST((SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) / ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS MONEY) AS lMevcut2, " &
    '            " (case when tbStokBarkodu.nKisim=0 then tbStokBarkodu.sBarkod else '' end) as sBarkod, " &
    '            " (case when tbStokBarkodu.nKisim=1 then tbStokBarkodu.sBarkod else '' end) as nMuadilBarkod, " &
    '            " (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, " &
    '            " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, " &
    '            " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, " &
    '            " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, " &
    '            " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS FIYAT5, " &
    '            " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS FIYAT6, " &
    '            " (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, " &
    '            " (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, " &
    '            " (SELECT COUNT(DISTINCT nStokID) AS nKayit FROM tbStokFiyati WHERE (dteFiyatTespitTarihi between '" & DateAdd(DateInterval.Day, -3, dteSistemTarihi) & "' and '" & dteSistemTarihi & "') AND (sFiyatTipi IN ('" & sFiyat1 & "' , '" & sFiyat2 & "' , '" & sFiyat3 & "')) AND nStokID = tbStok.nStokID) AS bFiyatDegisti, " &
    '            " bYeni = Case When (CONVERT(char(10), tbStok.dteKayitTarihi, 103) = '" & dteSistemTarihi & "') Then 1 else 0 END, " &
    '            " tbDepoDetayi.sDepo1, tbDepoDetayi.sDepo2, tbDepoDetayi.sDepo3, tbDepoDetayi.sDepo4, tbDepoDetayi.sDepo5, tbDepoDetayi.sDepo6, tbDepoDetayi.sDepo7, tbDepoDetayi.sDepo8, " &
    '            " tbSSinif1.sAciklama AS Sinif1 " &
    '            " FROM tbStok " & sResimJoin &
    '            " LEFT OUTER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND " & muadilB & " " &
    '            " INNER JOIN tbStokSinifi ON tbStokSinifi.sModel = tbStok.sModel " &
    '            " INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu " &
    '            " LEFT OUTER JOIN ( " &
    '            "   SELECT nStokID , SUM(sDepo1) AS sDepo1 , SUM(sDepo2) AS sDepo2 , SUM(sDepo3) AS sDepo3 , SUM(sDepo4) AS sDepo4 , SUM(sDepo5) AS sDepo5, SUM(sDepo6) AS sDepo6, SUM(sDepo7) AS sDepo7, SUM(sDepo8) AS sDepo8 " &
    '            "   FROM ( " &
    '            "       SELECT  nStokID , " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D001' THEN lGirisMiktar1 - lCikisMiktar1 ELSE 0 END AS sDepo1 , " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D002' THEN lGirisMiktar1 - lCikisMiktar1 ELSE 0 END AS sDepo2 , " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D003' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo3 , " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D004' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo4 , " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D005' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo5, " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D006' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo6, " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D007' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo7, " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D099' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo8 " &
    '            "       FROM tbStokFisiDetayi " &
    '            "   ) tbStokFisiDetayi GROUP BY nStokID " &
    '            " ) tbDepoDetayi ON tbStok.nStokID = tbDepoDetayi.nStokID " &
    '            " " & kriter & " ORDER BY tbStok.sKodu"
    '        )
    '        Else
    '            ' ---- Sorgu (bStokKarti = True, resim kapal) ----
    '            cmd.CommandText = sorgu_query(
    '            "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " &
    '            "SELECT " & count & " tbStok.*, " &
    '            " ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, " &
    '            " CAST((SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) / ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS MONEY) AS lMevcut2, " &
    '            " (case when tbStokBarkodu.nKisim=0 then tbStokBarkodu.sBarkod else '' end) as sBarkod, " &
    '            " (case when tbStokBarkodu.nKisim=1 then tbStokBarkodu.sBarkod else '' end) as nMuadilBarkod, " &
    '            " (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, " &
    '            " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, " &
    '            " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, " &
    '            " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, " &
    '            " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'), 0) AS lFiyat4, " &
    '            " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS FIYAT5, " &
    '            " ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS FIYAT6, " &
    '            " (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, " &
    '            " (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, " &
    '            " (SELECT COUNT(DISTINCT nStokID) AS nKayit FROM tbStokFiyati WHERE (dteFiyatTespitTarihi between '" & DateAdd(DateInterval.Day, -3, dteSistemTarihi) & "' and '" & dteSistemTarihi & "') AND (sFiyatTipi IN ('" & sFiyat1 & "' , '" & sFiyat2 & "' , '" & sFiyat3 & "')) AND nStokID = tbStok.nStokID) AS bFiyatDegisti, " &
    '            " bYeni = Case When (CONVERT(char(10), tbStok.dteKayitTarihi, 103) = '" & dteSistemTarihi & "') Then 1 else 0 END, " &
    '            " tbDepoDetayi.sDepo1, tbDepoDetayi.sDepo2, tbDepoDetayi.sDepo3, tbDepoDetayi.sDepo4, tbDepoDetayi.sDepo5, tbDepoDetayi.sDepo6, tbDepoDetayi.sDepo7, tbDepoDetayi.sDepo8, " &
    '            " tbSSinif1.sAciklama AS Sinif1, tbSSinif2.sAciklama AS Sinif2, tbSSinif3.sAciklama AS Sinif3, tbSSinif4.sAciklama AS Sinif4, tbSSinif5.sAciklama AS Sinif5, tbSSinif6.sAciklama AS Sinif6, tbSSinif7.sAciklama AS Sinif7, tbSSinif8.sAciklama AS Sinif8, tbSSinif9.sAciklama AS Sinif9 " &
    '            " FROM tbStok " & sResimJoin &
    '            " LEFT OUTER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND " & muadilB & " " &
    '            " INNER JOIN  tbStokSinifi ON tbStokSinifi.sModel = tbStok.sModel " &
    '            " INNER JOIN  tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu " &
    '            " INNER JOIN  tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu " &
    '            " INNER JOIN  tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu " &
    '            " INNER JOIN  tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu " &
    '            " INNER JOIN  tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu " &
    '            " INNER JOIN  tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu " &
    '            " INNER JOIN  tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu " &
    '            " INNER JOIN  tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu " &
    '            " INNER JOIN  tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu " &
    '            " LEFT OUTER JOIN ( " &
    '            "   SELECT nStokID , SUM(sDepo1) AS sDepo1 , SUM(sDepo2) AS sDepo2 , SUM(sDepo3) AS sDepo3 , SUM(sDepo4) AS sDepo4 , SUM(sDepo5) AS sDepo5, SUM(sDepo6) AS sDepo6, SUM(sDepo7) AS sDepo7, SUM(sDepo8) AS sDepo8 " &
    '            "   FROM ( " &
    '            "       SELECT  nStokID , " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D001' THEN lGirisMiktar1 - lCikisMiktar1 ELSE 0 END AS sDepo1 , " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D002' THEN lGirisMiktar1 - lCikisMiktar1 ELSE 0 END AS sDepo2 , " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D003' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo3 , " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D004' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo4 , " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D005' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo5, " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D006' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo6, " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D007' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo7, " &
    '            "       CASE WHEN RTRIM(UPPER(sDepo)) = 'D099' THEN (lGirisMiktar1 - lCikisMiktar1) ELSE 0 END AS sDepo8 " &
    '            "       FROM tbStokFisiDetayi " &
    '            "   ) tbStokFisiDetayi GROUP BY nStokID " &
    '            " ) tbDepoDetayi ON tbStok.nStokID = tbDepoDetayi.nStokID " &
    '            " " & kriter & " ORDER BY tbStok.sKodu"
    '        )
    '        End If
    '    End If

    '    cmd.Connection = conn
    '    conn.Open()
    '    Dim Datastoklar1 As New DataSet
    '    Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
    '    conn.Close()
    '    Return Datastoklar1
    'End Function
    Private Sub SetupResimKolonu()
        ' Kaynaktaki URL ve raw pResim kolonlarını gizle
        Dim urlCol = GridView1.Columns.ColumnByFieldName("yol")
        If urlCol IsNot Nothing Then urlCol.Visible = False

        Dim pResimCol = GridView1.Columns.ColumnByFieldName("pResim")
        If pResimCol IsNot Nothing Then pResimCol.Visible = False
        
        ' Eski "ResimGoster" kolonunu kaldır (varsa)
        Dim oldCol = GridView1.Columns.ColumnByFieldName("ResimGoster")
        If oldCol IsNot Nothing Then 
            oldCol.Visible = False
        End If

        ' Resim göster kapalıysa hiçbir şey yapma
        If Not sec_bResimGoster.Checked Then
            If colpResim IsNot Nothing Then colpResim.Visible = False
            Return
        End If

        ' Designer'daki colpResim kolonunu kullan (tek kolon)
        If colpResim IsNot Nothing Then
            colpResim.Visible = True
            colpResim.VisibleIndex = 1
            colpResim.Width = 125
            colpResim.UnboundType = DevExpress.Data.UnboundColumnType.Object
            colpResim.OptionsColumn.AllowEdit = False
            colpResim.OptionsColumn.AllowFocus = False
            
            ' PictureEdit ayarları
            If TypeOf colpResim.ColumnEdit Is RepositoryItemPictureEdit Then
                Dim pic = DirectCast(colpResim.ColumnEdit, RepositoryItemPictureEdit)
                pic.SizeMode = PictureSizeMode.Zoom
                pic.NullText = " "
                pic.PictureStoreMode = PictureStoreMode.Image
            End If
        End If
        
        GridView1.RowHeight = 125

        RemoveHandler GridView1.CustomUnboundColumnData, AddressOf GridView1_CustomUnboundColumnData
        AddHandler GridView1.CustomUnboundColumnData, AddressOf GridView1_CustomUnboundColumnData
    End Sub
    Private Sub GridView1_CustomUnboundColumnData(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs)
        ' Sadece colpResim kolonu için işlem yap (Designer'daki kolon)
        If e.Column.FieldName <> "colpResim" OrElse Not e.IsGetData Then Return

        Try
            ' Önce SQL'den gelen pResim verisini kontrol et (bound data)
            Dim pResimData As Object = Nothing
            Try
                pResimData = GridView1.GetListSourceRowCellValue(e.ListSourceRowIndex, "pResim")
            Catch
                ' pResim kolonu yoksa devam et
            End Try

            ' Eğer SQL'den pResim verisi geldiyse direkt kullan
            If pResimData IsNot Nothing AndAlso Not IsDBNull(pResimData) Then
                Dim pResimStr As String = pResimData.ToString()
                If Not String.IsNullOrEmpty(pResimStr) AndAlso pResimStr.Length > 100 Then
                    ' Base64 veya dosya yolu
                    Dim img As Image = LoadImageOptimized(pResimStr)
                    If img IsNot Nothing Then
                        e.Value = img
                        Return
                    End If
                End If
            End If

            ' SQL'den veri gelmediyse veya yüklenemezse, alternatif arama yap
            ' nStokID, sModel, sRenk, sBeden, sKavala değerlerini al
            Dim nStokID As Object = GridView1.GetListSourceRowCellValue(e.ListSourceRowIndex, "nStokID")
            Dim sModel As Object = GridView1.GetListSourceRowCellValue(e.ListSourceRowIndex, "sModel")
            Dim sRenk As Object = GridView1.GetListSourceRowCellValue(e.ListSourceRowIndex, "sRenk")
            Dim sBeden As Object = GridView1.GetListSourceRowCellValue(e.ListSourceRowIndex, "sBeden")
            Dim sKavala As Object = GridView1.GetListSourceRowCellValue(e.ListSourceRowIndex, "sKavala")

            ' nStokID önceliği (en güvenilir)
            Dim nStokIDValue As Integer = 0
            If nStokID IsNot Nothing AndAlso Not IsDBNull(nStokID) Then
                nStokIDValue = Convert.ToInt32(nStokID)
            End If

            ' sModel kontrolü (fallback)
            If String.IsNullOrEmpty(sModel?.ToString()?.Trim()) Then
                e.Value = Nothing
                Return
            End If

            ' Null değerleri boş string'e çevir
            If sRenk Is Nothing OrElse IsDBNull(sRenk) Then sRenk = ""
            If sBeden Is Nothing OrElse IsDBNull(sBeden) Then sBeden = ""
            If sKavala Is Nothing OrElse IsDBNull(sKavala) Then sKavala = ""

            ' Cache key oluştur (stokID veya model + renk + beden + kavala)
            Dim cacheKey As String = ""
            If nStokIDValue > 0 Then
                cacheKey = "stokid_" & nStokIDValue.ToString()
            Else
                cacheKey = "model_" & sModel.ToString().Trim() &
                          "_renk_" & sRenk.ToString().Trim() &
                          "_beden_" & sBeden.ToString().Trim() &
                          "_kavala_" & sKavala.ToString().Trim()
            End If

            ' Cache'de var mı kontrol et
            If imageCache.ContainsKey(cacheKey) Then
                e.Value = imageCache(cacheKey)
                Return
            End If

            ' Database'den resim yolunu çek (önce nStokID, sonra model bazlı)
            Dim imagePath As String = GetImageFromDatabase(
                nStokIDValue,
                sModel.ToString().Trim(),
                sRenk.ToString().Trim(),
                sBeden.ToString().Trim(),
                sKavala.ToString().Trim()
            )

            If Not String.IsNullOrEmpty(imagePath) Then
                ' Optimize edilmiş yükleme (dosya yolu veya base64)
                Dim thumb As Image = LoadImageOptimized(imagePath)
                If thumb IsNot Nothing Then
                    ' Cache'e ekle
                    If Not imageCache.ContainsKey(cacheKey) Then
                        imageCache(cacheKey) = thumb
                    End If
                    e.Value = thumb
                End If
            End If

        Catch ex As Exception
            ' Hata durumunda null değer ata
            e.Value = Nothing
        End Try
    End Sub

    ' Database'den resim çekme metodu - GÜVENLİ VE ESNEK
    ' 1. Önce lokal klasörde arar (C:\Eticaret\Stok Resim\)
    ' 2. Sonra nStokID ile exact match dener
    ' 3. Sonra model + renk + beden + kavala ile dener
    ' 4. Sonra sadece model ile dener (renksiz/bedensiz ürünler için)
    Private Function GetImageFromDatabase(nStokID As Integer, sModel As String, sRenk As String, sBeden As String, sKavala As String) As String
        Try
            Dim lokalKlasor As String = "C:\Eticaret\Stok Resim\"
            
            ' STRATEJI 0: ÖNCE LOKAL DOSYA KONTROLÜ (en hızlı)
            If Not String.IsNullOrEmpty(sModel) AndAlso Directory.Exists(lokalKlasor) Then
                Dim possibleFiles As New List(Of String)()
                
                If Not String.IsNullOrEmpty(sRenk) Then
                    possibleFiles.Add(Path.Combine(lokalKlasor, $"{sModel.Trim()}-{sRenk.Trim()}_1.jpg"))
                    possibleFiles.Add(Path.Combine(lokalKlasor, $"{sModel.Trim()}-{sRenk.Trim()}_1.png"))
                End If
                possibleFiles.Add(Path.Combine(lokalKlasor, $"{sModel.Trim()}_1.jpg"))
                possibleFiles.Add(Path.Combine(lokalKlasor, $"{sModel.Trim()}_1.png"))
                possibleFiles.Add(Path.Combine(lokalKlasor, $"{sModel.Trim()}.jpg"))
                possibleFiles.Add(Path.Combine(lokalKlasor, $"{sModel.Trim()}.png"))
                
                For Each fp As String In possibleFiles
                    If File.Exists(fp) Then
                        Return fp ' Dosya yolunu döndür - LoadImageOptimized işleyecek
                    End If
                Next
            End If
            
            ' STRATEJI 1: nStokID ile exact match (en güvenilir) - pResim veya yol ile caching
            If nStokID > 0 Then
                Dim query1 As String = "SELECT TOP 1 nStokResimID, pResim, yol FROM tbStokResim WHERE nStokID = ? AND (pResim IS NOT NULL AND pResim <> '' OR yol IS NOT NULL AND yol <> '') ORDER BY nSira ASC"
                Using tempConn As New OleDb.OleDbConnection(connection)
                    Using cmd As New OleDb.OleDbCommand(query1, tempConn)
                        cmd.Parameters.Add(New OleDb.OleDbParameter("nStokID", OleDb.OleDbType.Integer)).Value = nStokID
                        tempConn.Open()
                        Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                Dim result As String = GetOrCacheImageFromReader(reader, sModel, sRenk)
                                If Not String.IsNullOrEmpty(result) Then Return result
                            End If
                        End Using
                    End Using
                End Using
            End If

            ' STRATEJI 2: sModel + sRenk + sBeden + sKavala (tam eşleşme) - pResim veya yol ile caching
            If Not String.IsNullOrEmpty(sModel) Then
                Dim query2 As String = "SELECT TOP 1 nStokResimID, pResim, yol FROM tbStokResim WHERE sModel = ? " &
                                      "AND (sRenk = ? OR (sRenk IS NULL AND ? = '')) " &
                                      "AND (sBeden = ? OR (sBeden IS NULL AND ? = '')) " &
                                      "AND (sKavala = ? OR (sKavala IS NULL AND ? = '')) " &
                                      "AND (pResim IS NOT NULL AND pResim <> '' OR yol IS NOT NULL AND yol <> '') ORDER BY nSira ASC"

                Using tempConn As New OleDb.OleDbConnection(connection)
                    Using cmd As New OleDb.OleDbCommand(query2, tempConn)
                        cmd.Parameters.Add(New OleDb.OleDbParameter("sModel", OleDb.OleDbType.VarChar, 50)).Value = sModel
                        cmd.Parameters.Add(New OleDb.OleDbParameter("sRenk1", OleDb.OleDbType.VarChar, 50)).Value = sRenk
                        cmd.Parameters.Add(New OleDb.OleDbParameter("sRenk2", OleDb.OleDbType.VarChar, 50)).Value = sRenk
                        cmd.Parameters.Add(New OleDb.OleDbParameter("sBeden1", OleDb.OleDbType.VarChar, 50)).Value = sBeden
                        cmd.Parameters.Add(New OleDb.OleDbParameter("sBeden2", OleDb.OleDbType.VarChar, 50)).Value = sBeden
                        cmd.Parameters.Add(New OleDb.OleDbParameter("sKavala1", OleDb.OleDbType.VarChar, 50)).Value = sKavala
                        cmd.Parameters.Add(New OleDb.OleDbParameter("sKavala2", OleDb.OleDbType.VarChar, 50)).Value = sKavala
                        tempConn.Open()
                        Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                Dim result As String = GetOrCacheImageFromReader(reader, sModel, sRenk)
                                If Not String.IsNullOrEmpty(result) Then Return result
                            End If
                        End Using
                    End Using
                End Using
            End If

            ' STRATEJI 3: Sadece sModel (renksiz/bedensiz ürünler için fallback) - pResim veya yol ile caching
            If Not String.IsNullOrEmpty(sModel) Then
                Dim query3 As String = "SELECT TOP 1 nStokResimID, pResim, yol FROM tbStokResim WHERE sModel = ? AND (pResim IS NOT NULL AND pResim <> '' OR yol IS NOT NULL AND yol <> '') ORDER BY nSira ASC"
                Using tempConn As New OleDb.OleDbConnection(connection)
                    Using cmd As New OleDb.OleDbCommand(query3, tempConn)
                        cmd.Parameters.Add(New OleDb.OleDbParameter("sModel", OleDb.OleDbType.VarChar, 50)).Value = sModel
                        tempConn.Open()
                        Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                Dim result As String = GetOrCacheImageFromReader(reader, sModel, sRenk)
                                If Not String.IsNullOrEmpty(result) Then Return result
                            End If
                        End Using
                    End Using
                End Using
            End If

        Catch ex As Exception
            ' Sessizce hata göz ardı et (performance için)
        End Try

        Return Nothing
    End Function
    
    ''' <summary>
    ''' Reader'dan pResim veya yol'u okur. pResim NULL ise ve yol varsa, URL'den indirir ve lokale + DB'ye cache'ler.
    ''' </summary>
    Private Function GetOrCacheImageFromReader(reader As OleDb.OleDbDataReader, sModel As String, sRenk As String) As String
        Try
            Dim nStokResimID As Integer = If(reader.IsDBNull(0), 0, reader.GetInt32(0))
            Dim pResim As String = If(reader.IsDBNull(1), "", reader.GetString(1))
            Dim yol As String = If(reader.IsDBNull(2), "", reader.GetString(2))
            Dim lokalKlasor As String = "C:\Eticaret\Stok Resim\"
            
            ' 1. pResim (lokal cache) varsa direkt döndür
            If Not String.IsNullOrEmpty(pResim) AndAlso pResim.Length > 100 Then
                Return pResim
            End If
            
            ' 2. pResim yok ama yol (R2 URL) varsa - indir ve pResim'e cache'le
            If Not String.IsNullOrEmpty(yol) AndAlso yol.StartsWith("http") Then
                Dim base64 As String = DownloadImageAsBase64(yol)
                
                If Not String.IsNullOrEmpty(base64) Then
                    ' Lokale de kaydet
                    Try
                        If Not Directory.Exists(lokalKlasor) Then Directory.CreateDirectory(lokalKlasor)
                        Dim fileName As String = If(Not String.IsNullOrEmpty(sRenk), $"{sModel.Trim()}-{sRenk.Trim()}_1.jpg", $"{sModel.Trim()}_1.jpg")
                        Dim localPath As String = Path.Combine(lokalKlasor, fileName)
                        Dim imgBytes As Byte() = Convert.FromBase64String(base64)
                        File.WriteAllBytes(localPath, imgBytes)
                    Catch
                    End Try
                    
                    ' DB'ye cache kaydet
                    If nStokResimID > 0 Then
                        Try
                            Using updateConn As New OleDb.OleDbConnection(connection)
                                updateConn.Open()
                                Using updateCmd As New OleDb.OleDbCommand("UPDATE tbStokResim SET pResim = ? WHERE nStokResimID = ?", updateConn)
                                    updateCmd.Parameters.AddWithValue("?", base64)
                                    updateCmd.Parameters.AddWithValue("?", nStokResimID)
                                    updateCmd.ExecuteNonQuery()
                                End Using
                            End Using
                        Catch
                            ' Cache kaydetme hatası - sessizce geç
                        End Try
                    End If
                    
                    Return base64
                End If
                
                ' İndirme başarısız olsa bile yol'u döndür (LoadImageOptimized URL'yi işleyebilir)
                Return yol
            End If
            
        Catch ex As Exception
            ' Hata durumunda Nothing döndür
        End Try
        
        Return Nothing
    End Function

    ' --- Yardımcılar ---
    Private Function LooksLikeBase64(s As String) As Boolean
        If String.IsNullOrEmpty(s) Then Return False
        s = CleanBase64(s)
        ' base64 karakter seti + 4'ün katı uzunluk kontrolü
        If (s.Length Mod 4) <> 0 Then Return False
        For Each ch As Char In s
            If Not ((ch >= "A"c AndAlso ch <= "Z"c) OrElse
                (ch >= "a"c AndAlso ch <= "z"c) OrElse
                (ch >= "0"c AndAlso ch <= "9"c) OrElse
                ch = "+"c OrElse ch = "/"c OrElse ch = "="c) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function CleanBase64(s As String) As String
        If s Is Nothing Then Return ""
        ' NVARCHAR(MAX) tarafında araya kaçan CR/LF, boşluk vs.
        Return s.Replace(vbCr, "").Replace(vbLf, "").Trim()
    End Function


    Private Sub EnsureTls12()
        Try
            ServicePointManager.Expect100Continue = False
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        Catch
        End Try
    End Sub

    ' Grid hücresini güvenli string okur (yalnızca gerçekten String ise)
    Private Function ReadStr(v As DevExpress.XtraGrid.Views.Grid.GridView, rowIndex As Integer, field As String) As String
        Try
            Dim val = v.GetListSourceRowCellValue(rowIndex, field)
            If val Is Nothing OrElse val Is DBNull.Value Then Return Nothing
            If TypeOf val Is String Then Return DirectCast(val, String)
            Return Nothing
        Catch
            Return Nothing
        End Try
    End Function

    ' Grid hücresini güvenli byte[] okur
    Private Function ReadBytes(v As DevExpress.XtraGrid.Views.Grid.GridView, rowIndex As Integer, field As String) As Byte()
        Try
            Dim val = v.GetListSourceRowCellValue(rowIndex, field)
            If val Is Nothing OrElse val Is DBNull.Value Then Return Nothing
            If TypeOf val Is Byte() Then Return DirectCast(val, Byte())
            Return Nothing
        Catch
            Return Nothing
        End Try
    End Function
    Private Function BytesToImage(b As Byte()) As Image
        Try
            Using ms As New Global.System.IO.MemoryStream(b)
                Return Image.FromStream(ms)
            End Using
        Catch
            Return Nothing
        End Try
    End Function
    Private Function SafeLoadImage(path As String) As Image
        Try
            Dim b = Global.System.IO.File.ReadAllBytes(path)
            Return BytesToImage(b)
        Catch
            Return Nothing
        End Try
    End Function
    Private Function BuildSafeFileName(sModel As String, nStokID As String, url As String) As String
        Dim baseName As String = ""
        If Not String.IsNullOrWhiteSpace(sModel) Then
            baseName = sModel
        ElseIf Not String.IsNullOrWhiteSpace(nStokID) Then
            baseName = "STOK_" & nStokID
        Else
            baseName = Guid.NewGuid().ToString("N")
        End If

        ' Geçersiz karakterleri temizle
        Dim invalid() As Char = Global.System.IO.Path.GetInvalidFileNameChars()
        For Each ch As Char In invalid
            baseName = baseName.Replace(ch, "_"c)
        Next
        baseName = Global.System.Text.RegularExpressions.Regex.Replace(baseName, "\s+", "_")

        ' Uzantı
        Dim ext As String = ".jpg"
        Try
            Dim u As New Global.System.Uri(url)
            Dim epath = Global.System.IO.Path.GetExtension(u.AbsolutePath)
            If Not String.IsNullOrEmpty(epath) Then ext = epath
        Catch
        End Try
        If url.IndexOf("format=png", StringComparison.OrdinalIgnoreCase) >= 0 Then ext = ".png"
        If url.IndexOf("format=webp", StringComparison.OrdinalIgnoreCase) >= 0 Then ext = ".webp"

        Return baseName & ext
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        If firmano IsNot Nothing Then
            query = Replace(query, "*!F", "F0" + firmano.ToString)
        Else
            query = Replace(query, "*!F", "F01")
        End If
        If donemno IsNot Nothing Then
            query = Replace(query, "!D", "D000" + donemno.ToString)
        Else
            query = Replace(query, "!D", "D0001")
        End If
        Return query
    End Function
    Private Sub dataload(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String)
        DataSet1 = stok(ara, konum, ara_kriter)

        ' DEBUG LOG - Dönen satır sayısı
        Try
            System.IO.File.AppendAllText("C:\Eticaret\debug_sql.txt", vbCrLf & vbCrLf & "Dönen Satır Sayısı: " & DataSet1.Tables(0).Rows.Count.ToString())
        Catch
        End Try

        GridControl1.DataSource = DataSet1.Tables(0)
        SetupResimKolonu()
        If sec_bResimGoster.Checked Then LoadStokResimleri()
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
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
            frm.bStokKarti = bStokKarti
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
                    If XtraMessageBox.Show(Sorgu_sDil("Yeni Stok Kart Amak ster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        stok_yeni()
                    Else
                        txt_ara.Text = frm.sModel
                        sec_konum.Text = "Kod"
                        sec_kriter.Text = "Balar"
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
    Private Sub analiz_hareket_transfer()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri_transfer
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            'frm.stokno = dr("nStokId")
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
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sKodu")
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
            frm.Label1.Text = dr("sAciklama") & vbCrLf & frm.Label1.Text
            frm.kullanici = kullanici
            If yetki_kontrol1(kullanici, "frm_stok_hareketleri_Sec") = False Then
                frm.sec_giris.Visible = False
                frm.sec_firma.Visible = False
                frm.sec_giris.Text = "klar"
            Else
                frm.sec_giris.Visible = True
                frm.sec_firma.Visible = True
            End If
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_envanter_model()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_envanter_model
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.modelno = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_hareket()
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'stkdll.firmano = firmano
        'stkdll.donemno = donemno
        'stkdll.connection = connection
        'stkdll.stokno = dr("IND")
        'stkdll.rptfiyatanalizi(dr("IND"), 100, dr("MALINCINSI"), 2)
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
    Private Sub analiz_stok_Alternatif()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.alternatif = dr("sKodu")
            frm.qalternatif = "Eittir"
            frm.status = True
            frm.aktif = 1
            If yetki_kontrol(kullanici, "frm_Stok_Alternatif") = True Then
                frm.ShowDialog()
            End If
        End If
    End Sub
    Private Sub analiz_protokol()
        'If sLicenseModule.Items.Contains("Protokol") = True Then
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_tbStokCariProtokol
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokID")
            frm.nFirmaID = 0
            frm.txt_musteriNo.Text = dr("sKodu")
            frm.lbl_Firma.Text = dr("sAciklama")
            frm.bFirma = False
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
        'End If
    End Sub
    Private Sub analiz_resim()
        If GridView1.RowCount > 0 Then
            Dim satir = GridView1.FocusedRowHandle
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If sec_bResimGoster.Checked = False Then
                Dim dsResim As DataSet = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT     * FROM         tbStokResim WHERE     (sModel = '" & dr("sModel") & "') ")
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
            Else
                Try
                    Dim frm As New frm_tbResim
                    frm.PictureEdit1.EditValue = dr("yol")
                    frm.ShowDialog()
                Catch ex As Exception
                End Try
            End If
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
            frm.sKavala = dr("sKavala")
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
    Private Sub analiz_iletisim()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_firma_iletisim
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("nFirmaID")
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
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Ltfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        dataload(txt_ara.EditValue, sec_konum.Text, sec_kriter.Text)
        Label2.Text = Sorgu_sDil("Tamamland...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonular Excel Dosyas Oluturmak stediinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalar(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kayd Amak ster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_text()
        If XtraMessageBox.Show(Sorgu_sDil("Sonular Text Dosyas Oluturmak stediinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Text Dosyalar(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kayd Amak ster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
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
            Label2.Text = Sorgu_sDil("Kayt Says :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayt Says :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        If islemstatus = True Then
            If GridView1.RowCount > 0 Then
                ' Seçili satır bilgilerini kaydet
                SetSeciliSatirBilgileri()
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                XtraMessageBox.Show(Sorgu_sDil("Kayt Bulunamad", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            If bStokKarti = True Then
                stok_duzelt()
            End If
            'Me.Close()
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            'If XtraMessageBox.Show(Sorgu_sDil("Ak Faturalar Kontrol Ekranndan kmak stediinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If islemstatus = True Then
            If GridView1.RowCount > 0 Then
                ' Seçili satır bilgilerini kaydet
                SetSeciliSatirBilgileri()
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                XtraMessageBox.Show(Sorgu_sDil("Kayt Bulunamad", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            Me.Close()
        End If
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dataload(txt_ara.EditValue, sec_konum.Text, sec_kriter.Text)
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        analiz_musteri_karti()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_musteri_satislar()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_acik_faturalar()
    End Sub
    Private Sub MenuItem16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_acik_faturalar_analiz()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_musteri_hareket_ekstre()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If islemstatus = True Then
                If GridView1.RowCount > 0 Then
                    ' Seçili satır bilgilerini kaydet
                    SetSeciliSatirBilgileri()
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                Else
                    XtraMessageBox.Show(Sorgu_sDil("Kayt Bulunamad", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If bStokKarti = True Then
                    stok_duzelt()
                End If
            End If
        End If
    End Sub
    
    ''' <summary>
    ''' Seçili satır bilgilerini public alanlara yazar
    ''' </summary>
    Private Sub SetSeciliSatirBilgileri()
        Try
            Dim focusedHandle As Integer = GridView1.FocusedRowHandle
            If focusedHandle >= 0 Then
                Dim dr As DataRow = GridView1.GetDataRow(focusedHandle)
                If dr IsNot Nothing Then
                    ' nStokID
                    If dr.Table.Columns.Contains("nStokID") Then
                        secili_nStokID = CLng(dr("nStokID"))
                    End If
                    ' sKodu (stok kodu)
                    If dr.Table.Columns.Contains("sKodu") Then
                        secili_StokKodu = dr("sKodu").ToString().Trim()
                    End If
                End If
            End If
        Catch ex As Exception
            Debug.WriteLine("SetSeciliSatirBilgileri hatası: " & ex.Message)
        End Try
    End Sub
    
    Private Sub MenuItem16_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_envanter()
    End Sub
    Private Sub txt_ara_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ara.KeyDown
        If e.KeyCode = Keys.Enter Then
            If IsNumeric(Trim(txt_ara.Text)) = True Then
                If Len(Trim(txt_ara.Text).ToString) < 2 Then
                    txt_ara.Text = Trim(txt_ara.Text) + "  "
                End If
                If Trim((Trim(txt_ara.Text)).Substring(0, 2)) = sBarcodeStd And Len(Trim(txt_ara.Text)) > 5 Then
                    Dim deger = Trim(Trim(txt_ara.Text))
                    If IsNumeric(deger) = True Then
                        mevcut = CType((deger.substring(7, sBarcodeStd_KG) + "." + deger.substring(7 + sBarcodeStd_KG, sBarcodeStd_GR)), Decimal)
                        txt_ara.Text = deger.substring(2, 5)
                    End If
                Else
                    mevcut = 1
                End If
            Else
                If CStr(Trim(txt_ara.Text).ToString) <> "" Then
                    x = (Trim(txt_ara.Text)).IndexOf("*", 1, (Trim(txt_ara.Text)).Length - 1)
                    If x = -1 Then
                        mevcut = 1
                    Else
                        mevcut = (Trim(txt_ara.Text)).Substring(0, x)
                        txt_ara.Text = (Trim(txt_ara.Text)).Substring((x + 1), (Trim(txt_ara.Text)).Length - (x + 1))
                    End If
                End If
            End If
        End If
        If islemstatus = True Then
            If e.KeyCode = Keys.Enter Then
                ara()
                PanelControl3.Focus()
                PanelControl3.Select()
            End If
        Else
            If e.KeyCode = Keys.Enter Then
                ara()
                PanelControl3.Focus()
                PanelControl3.Select()
            End If
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub MenuItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        stok_duzelt()
    End Sub
    Private Sub MenuItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem21_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        analiz_hareket_transfer()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        stok_fiyat()
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        If MenuItem23.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem23.Checked = True
        ElseIf MenuItem23.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem23.Checked = True
        End If
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        If XtraMessageBox.Show(Sorgu_sDil("Sonular Excel Dosyas Oluturmak stediinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            SaveFileDialog1.Filter = "Excel Dosyalar(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
            End If
        End If
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        If XtraMessageBox.Show(Sorgu_sDil("Sonular Text Dosyas Oluturmak stediinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            SaveFileDialog1.Filter = "Text Dosyalar(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
            End If
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        txt_ara.Text = ""
        txt_ara.Focus()
        txt_ara.SelectAll()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        stok_yeni()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        stok_duzelt()
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
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        analiz_hareket_transfer()
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        analiz_resim()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        raporla_excel()
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        analiz_stok_KarlilikAkisTablosu()
    End Sub
    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        analiz_stok_Alternatif()
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        analiz_protokol()
    End Sub
    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            colMuadilBarkod.Visible = True
            colsBarkod.Visible = True
        Else
            colMuadilBarkod.Visible = False
            colsBarkod.Visible = False
        End If
    End Sub
    Private Sub sec_kriter_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles sec_kriter.SelectedIndexChanged
    End Sub

    ' ============================================
    ' RESIM CACHE YNETM
    ' ============================================
    Private cacheFolderPath As String = Path.Combine(Path.GetTempPath(), "BARKOD_MAGAZA_ImageCache")

    Private Function GetCachedImageOrDownload(imageUrl As String) As Byte()
        Try
            If String.IsNullOrEmpty(imageUrl) Then Return Nothing

            ' Cache klasrn olutur
            If Not Directory.Exists(cacheFolderPath) Then
                Directory.CreateDirectory(cacheFolderPath)
            End If

            ' URL'nin hash'ini al (filename olarak kullan)
            Dim urlHash As String = GetMD5Hash(imageUrl)
            Dim cacheFilePath As String = Path.Combine(cacheFolderPath, urlHash & ".jpg")

            ' Cache'de var m kontrol et
            If File.Exists(cacheFilePath) Then
                ' Cache'den ykle (hzl!)
                Return File.ReadAllBytes(cacheFilePath)
            Else
                ' URL'den indir
                Using client As New System.Net.WebClient()
                    Dim imageBytes As Byte() = client.DownloadData(imageUrl)

                    ' Cache'e kaydet
                    File.WriteAllBytes(cacheFilePath, imageBytes)

                    Return imageBytes
                End Using
            End If
        Catch ex As Exception
            ' Hata durumunda null dn
            Return Nothing
        End Try
    End Function

    Private Function GetMD5Hash(input As String) As String
        Using md5 As System.Security.Cryptography.MD5 = System.Security.Cryptography.MD5.Create()
            Dim inputBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(input)
            Dim hashBytes As Byte() = md5.ComputeHash(inputBytes)

            Dim sb As New System.Text.StringBuilder()
            For Each b As Byte In hashBytes
                sb.Append(b.ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function

    ' Cache temizleme metodu - Memory management iyileştirildi
    Private Sub ClearImageCache()
        Try
            ' Tüm resimleri dispose et
            For Each kvp As KeyValuePair(Of String, Image) In imageCache.ToList()
                If kvp.Value IsNot Nothing Then
                    kvp.Value.Dispose()
                End If
            Next
            imageCache.Clear()

            ' Garbage collection zorla
            GC.Collect()
            GC.WaitForPendingFinalizers()
            GC.Collect()
        Catch ex As Exception
            ' Ignore errors
        End Try
    End Sub

    ' Cache boyut kontrolü - Limit aşılırsa eski resimleri sil
    Private Sub ManageCacheSize()
        Try
            If imageCache.Count > MAX_CACHE_SIZE Then
                ' En eski yarısını sil (FIFO)
                Dim itemsToRemove = imageCache.Take(imageCache.Count - MAX_CACHE_SIZE).ToList()
                For Each item As KeyValuePair(Of String, Image) In itemsToRemove
                    If item.Value IsNot Nothing Then
                        item.Value.Dispose()
                    End If
                    imageCache.Remove(item.Key)
                Next

                ' GC'yi çağır
                GC.Collect()
            End If
        Catch ex As Exception
            ' Ignore errors
        End Try
    End Sub

    ' Thumbnail oluşturma metodu
    ' Optimize edilmiş resim yükleme metodu - Memory efficient
    Private Function LoadImageOptimized(imageData As Object) As Image
        If imageData Is Nothing Then Return Nothing

        Dim cacheKey As String = ""

        Try
            ' Cache boyut kontrolü
            ManageCacheSize()

            ' 1) Byte[] kontrolü
            Dim bytes As Byte() = TryCast(imageData, Byte())
            If bytes IsNot Nothing AndAlso bytes.Length > 0 Then
                cacheKey = "b_" & bytes.Length.ToString()

                If imageCache.ContainsKey(cacheKey) Then
                    Return imageCache(cacheKey)
                End If

                ' Resmi yükle, thumbnail oluştur ve orijinali dispose et
                Using ms As New MemoryStream(bytes)
                    Using fullImage As Image = Image.FromStream(ms)
                        Dim thumb As Image = CreateThumbnailCompressed(fullImage)
                        If thumb IsNot Nothing AndAlso Not imageCache.ContainsKey(cacheKey) Then
                            imageCache(cacheKey) = thumb
                        End If
                        Return thumb
                    End Using
                End Using
            End If

            ' 2) String kontrolü (dosya yolu veya base64)
            Dim s As String = TryCast(imageData, String)
            If Not String.IsNullOrEmpty(s) Then
                ' Dosya yolu
                If File.Exists(s) Then
                    cacheKey = "f_" & Path.GetFileName(s)

                    If imageCache.ContainsKey(cacheKey) Then
                        Return imageCache(cacheKey)
                    End If

                    Using fs As New FileStream(s, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                        Using fullImage As Image = Image.FromStream(fs)
                            Dim thumb As Image = CreateThumbnailCompressed(fullImage)
                            If thumb IsNot Nothing AndAlso Not imageCache.ContainsKey(cacheKey) Then
                                imageCache(cacheKey) = thumb
                            End If
                            Return thumb
                        End Using
                    End Using

                    ' URL (http veya https)
                ElseIf s.StartsWith("http://", StringComparison.OrdinalIgnoreCase) OrElse s.StartsWith("https://", StringComparison.OrdinalIgnoreCase) Then
                    cacheKey = "url_" & Math.Abs(s.GetHashCode()).ToString()
                    
                    If imageCache.ContainsKey(cacheKey) Then
                        Return imageCache(cacheKey)
                    End If
                    
                    ' URL'den resmi indir
                    Try
                        Using client As New System.Net.WebClient()
                            client.Headers.Add("User-Agent", "BarkodMagaza/1.0")
                            Dim imgBytes As Byte() = client.DownloadData(s)
                            If imgBytes IsNot Nothing AndAlso imgBytes.Length > 0 Then
                                Using ms As New MemoryStream(imgBytes)
                                    Using fullImage As Image = Image.FromStream(ms)
                                        Dim thumb As Image = CreateThumbnailCompressed(fullImage)
                                        If thumb IsNot Nothing AndAlso Not imageCache.ContainsKey(cacheKey) Then
                                            imageCache(cacheKey) = thumb
                                        End If
                                        Return thumb
                                    End Using
                                End Using
                            End If
                        End Using
                    Catch
                        ' URL indirme hatası - sessizce geç
                    End Try
                    
                    ' Base64
                ElseIf s.Length > 100 Then
                    cacheKey = "64_" & Math.Abs(s.GetHashCode()).ToString()

                    If imageCache.ContainsKey(cacheKey) Then
                        Return imageCache(cacheKey)
                    End If

                    Dim base64Data As String = s
                    If s.Contains(",") Then
                        base64Data = s.Substring(s.IndexOf(",") + 1)
                    End If

                    Dim imgBytes As Byte() = Convert.FromBase64String(base64Data)
                    Using ms As New MemoryStream(imgBytes)
                        Using fullImage As Image = Image.FromStream(ms)
                            Dim thumb As Image = CreateThumbnailCompressed(fullImage)
                            If thumb IsNot Nothing AndAlso Not imageCache.ContainsKey(cacheKey) Then
                                imageCache(cacheKey) = thumb
                            End If
                            Return thumb
                        End Using
                    End Using
                End If
            End If

        Catch ex As Exception
            ' Hata durumunda null dön
            Return Nothing
        End Try

        Return Nothing
    End Function

    ' Compressed thumbnail oluşturma - Daha düşük kalite, daha az bellek
    Private Function CreateThumbnailCompressed(originalImage As Image) As Image
        If originalImage Is Nothing Then Return Nothing
        Try
            ' Aspect ratio'yu koru
            Dim ratioX As Double = CDbl(thumbnailSize.Width) / originalImage.Width
            Dim ratioY As Double = CDbl(thumbnailSize.Height) / originalImage.Height
            Dim ratio As Double = Math.Min(ratioX, ratioY)

            Dim newWidth As Integer = Math.Max(1, CInt(originalImage.Width * ratio))
            Dim newHeight As Integer = Math.Max(1, CInt(originalImage.Height * ratio))

            ' Küçük bitmap oluştur
            Dim thumbnail As New Bitmap(newWidth, newHeight, Imaging.PixelFormat.Format24bppRgb)

            Using g As Graphics = Graphics.FromImage(thumbnail)
                ' Hızlı ve düşük kaliteli rendering (bellek dostu)
                g.InterpolationMode = Drawing2D.InterpolationMode.Low
                g.SmoothingMode = Drawing2D.SmoothingMode.HighSpeed
                g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighSpeed
                g.CompositingQuality = Drawing2D.CompositingQuality.HighSpeed

                g.Clear(Color.White)
                g.DrawImage(originalImage, 0, 0, newWidth, newHeight)
            End Using

            Return thumbnail
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub sec_bResimGoster_CheckedChanged(sender As Object, e As EventArgs) Handles sec_bResimGoster.CheckedChanged
        colpResim.Visible = sec_bResimGoster.Checked
        If sec_bResimGoster.Checked Then
            GridView1.RowHeight = 125
            GridView1.RefreshData()
            LoadStokResimleri()
        Else
            GridView1.RowHeight = -1
        End If

        ' Registry'ye kaydet
        Try
            Registry.CurrentUser.OpenSubKey("Software", True).OpenSubKey("BusinessSmart", True).OpenSubKey("VIEW", True).OpenSubKey("STOK", True).OpenSubKey("YENIKART", True).SetValue("bResimGoster", sec_bResimGoster.Checked)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub LoadStokResimleri()
        Try
            If Not sec_bResimGoster.Checked Then Return

            For i As Integer = 0 To GridView1.RowCount - 1
                Dim sModel As Object = GridView1.GetRowCellValue(i, "sModel")

                ' NULL veya boş kontrolü
                If sModel Is Nothing OrElse IsDBNull(sModel) OrElse String.IsNullOrEmpty(sModel.ToString().Trim()) Then
                    Continue For
                End If

                Dim resimUrl As String = GetFirstStokResimUrl(sModel.ToString())
                If String.IsNullOrEmpty(resimUrl) Then Continue For

                Dim resim As Image = LoadImageFromUrlOrPath(resimUrl)
                If resim IsNot Nothing Then
                    GridView1.SetRowCellValue(i, "ResimGoster", resim)
                End If
            Next
        Catch ex As Exception
            ' Hata sessizce geç
        End Try
    End Sub
    Private Function GetFirstStokResimUrl(sModel As String) As String
        Try
            If String.IsNullOrEmpty(sModel) Then Return Nothing
            sModel = sModel.Trim()

            Dim query As String = "SELECT TOP 1 pResim, yol FROM tbStokResim WHERE sModel = ?"
            Using tempCon As New OleDbConnection(connection)
                Using cmd As New OleDbCommand(query, tempCon)
                    cmd.Parameters.Add(New OleDbParameter("sModel", OleDbType.VarChar, 50)).Value = sModel
                    tempCon.Open()
                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim pResimPath As String = If(reader.IsDBNull(0), "", Convert.ToString(reader.GetValue(0)).Trim())
                            If Not String.IsNullOrEmpty(pResimPath) AndAlso File.Exists(pResimPath) Then Return pResimPath

                            Dim yolUrl As String = If(reader.IsDBNull(1), "", Convert.ToString(reader.GetValue(1)).Trim())
                            If Not String.IsNullOrEmpty(yolUrl) Then Return yolUrl
                        End If
                    End Using
                End Using
            End Using
        Catch
            Return Nothing
        End Try
        Return Nothing
    End Function
    Private Function LoadImageFromUrlOrPath(urlOrPath As String) As Image
        Try
            If String.IsNullOrEmpty(urlOrPath) Then Return Nothing

            Dim localFolder As String = "C:/Eticaret/Stok Resim/"
            If Not Directory.Exists(localFolder) Then Directory.CreateDirectory(localFolder)

            If _imgCache.ContainsKey(urlOrPath) Then Return _imgCache(urlOrPath)

            Dim img As Image = Nothing

            If urlOrPath.StartsWith("http://", StringComparison.OrdinalIgnoreCase) OrElse urlOrPath.StartsWith("https://", StringComparison.OrdinalIgnoreCase) Then
                Dim fileName As String = Path.GetFileName(New Uri(urlOrPath).LocalPath)
                Dim localPath As String = Path.Combine(localFolder, fileName)

                If Not File.Exists(localPath) Then
                    Using client As New WebClient()
                        client.DownloadFile(urlOrPath, localPath)
                    End Using
                End If
                img = Image.FromFile(localPath)
            ElseIf File.Exists(urlOrPath) Then
                img = Image.FromFile(urlOrPath)
            End If

            If img IsNot Nothing Then _imgCache(urlOrPath) = img
            Return img
        Catch
            Return Nothing
        End Try
    End Function

    ' ===== PERFORMANCE OPTIMIZATION: Image Cache & Lazy Loading =====

    ' ===== PERFORMANS OPTİMİZASYONU: Base64 Image Loading =====
    ' pResim: Base64 string (FULL quality)
    ' Cache: Dictionary ile optimize
    ' Lazy Loading: Sadece görünen satırlar


    ' Cache temizleme

    ' Cache boyut yönetimi

    ' Base64'ten resim yükle (FULL quality, cache'li)
    Private Function LoadImageFromBase64(base64String As String) As Image
        If String.IsNullOrEmpty(base64String) Then Return Nothing

        Dim cacheKey As String = "b64_" & base64String.GetHashCode().ToString()

        Try
            ' Cache kontrolü
            If imageCache.ContainsKey(cacheKey) Then
                Return imageCache(cacheKey)
            End If

            ' Cache boyut yönetimi
            ManageCacheSize()

            ' Base64 decode
            Dim cleanBase64 As String = base64String.Trim().Replace(vbCr, "").Replace(vbLf, "")

            ' data:image prefix varsa temizle
            If cleanBase64.StartsWith("data:image") Then
                Dim commaIndex As Integer = cleanBase64.IndexOf(","c)
                If commaIndex > 0 Then
                    cleanBase64 = cleanBase64.Substring(commaIndex + 1)
                End If
            End If

            ' Byte array'e çevir
            Dim imageBytes As Byte() = Convert.FromBase64String(cleanBase64)

            ' Image oluştur
            Using ms As New MemoryStream(imageBytes)
                Dim img As Image = Image.FromStream(ms)

                ' Cache'e ekle
                If Not imageCache.ContainsKey(cacheKey) Then
                    imageCache(cacheKey) = img
                End If

                Return img
            End Using

        Catch ex As Exception
            ' Hata durumunda null dön
            Return Nothing
        End Try
    End Function

    ' Database'den Base64 resim çek veya R2'den indir ve cache'le
    Private Function GetBase64FromDatabase(sModel As String, sRenk As String) As String
        Try
            ' 1. Önce renk bazlı ara - pResim (lokal cache) veya yol (R2 URL)
            Dim query As String = "SELECT TOP 1 nStokResimID, pResim, yol FROM tbStokResim WHERE sModel = ? AND sRenk = ? AND (pResim IS NOT NULL AND pResim <> '' OR yol IS NOT NULL AND yol <> '') ORDER BY nSira ASC"

            Using tempConn As New OleDb.OleDbConnection(connection)
                Using cmd As New OleDb.OleDbCommand(query, tempConn)
                    cmd.Parameters.Add(New OleDb.OleDbParameter("sModel", OleDb.OleDbType.VarChar, 50)).Value = sModel
                    cmd.Parameters.Add(New OleDb.OleDbParameter("sRenk", OleDb.OleDbType.VarChar, 50)).Value = sRenk
                    tempConn.Open()

                    Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Return GetOrDownloadImage(reader, tempConn)
                        End If
                    End Using
                End Using
            End Using
            
            ' 2. Renk bazlı bulunamadıysa, model bazlı ara (varyansız ürünler için)
            Dim queryNoColor As String = "SELECT TOP 1 nStokResimID, pResim, yol FROM tbStokResim WHERE sModel = ? AND (sRenk IS NULL OR sRenk = '') AND (pResim IS NOT NULL AND pResim <> '' OR yol IS NOT NULL AND yol <> '') ORDER BY nSira ASC"

            Using tempConn2 As New OleDb.OleDbConnection(connection)
                Using cmd2 As New OleDb.OleDbCommand(queryNoColor, tempConn2)
                    cmd2.Parameters.Add(New OleDb.OleDbParameter("sModel", OleDb.OleDbType.VarChar, 50)).Value = sModel
                    tempConn2.Open()

                    Using reader2 As OleDb.OleDbDataReader = cmd2.ExecuteReader()
                        If reader2.Read() Then
                            Return GetOrDownloadImage(reader2, tempConn2)
                        End If
                    End Using
                End Using
            End Using
            
            ' 3. Hala bulunamadıysa, sadece model ile herhangi bir resim ara
            Dim queryAll As String = "SELECT TOP 1 nStokResimID, pResim, yol FROM tbStokResim WHERE sModel = ? AND (pResim IS NOT NULL AND pResim <> '' OR yol IS NOT NULL AND yol <> '') ORDER BY nSira ASC"

            Using tempConn3 As New OleDb.OleDbConnection(connection)
                Using cmd3 As New OleDb.OleDbCommand(queryAll, tempConn3)
                    cmd3.Parameters.Add(New OleDb.OleDbParameter("sModel", OleDb.OleDbType.VarChar, 50)).Value = sModel
                    tempConn3.Open()

                    Using reader3 As OleDb.OleDbDataReader = cmd3.ExecuteReader()
                        If reader3.Read() Then
                            Return GetOrDownloadImage(reader3, tempConn3)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Sessizce hata göz ardı et
        End Try

        Return Nothing
    End Function
    
    ''' <summary>
    ''' pResim varsa döndür, yoksa yol'dan indir ve pResim'e cache'le
    ''' </summary>
    Private Function GetOrDownloadImage(reader As OleDb.OleDbDataReader, conn As OleDb.OleDbConnection) As String
        Try
            Dim nStokResimID As Integer = If(reader.IsDBNull(0), 0, reader.GetInt32(0))
            Dim pResim As String = If(reader.IsDBNull(1), "", reader.GetString(1))
            Dim yol As String = If(reader.IsDBNull(2), "", reader.GetString(2))
            
            ' 1. pResim (lokal cache) varsa döndür
            If Not String.IsNullOrEmpty(pResim) Then
                Return pResim
            End If
            
            ' 2. pResim yok ama yol (R2 URL) varsa - indir ve cache'le
            If Not String.IsNullOrEmpty(yol) AndAlso yol.StartsWith("http") Then
                Dim base64 As String = DownloadImageAsBase64(yol)
                
                If Not String.IsNullOrEmpty(base64) AndAlso nStokResimID > 0 Then
                    ' Cache'e kaydet (pResim alanına)
                    Try
                        Using updateConn As New OleDb.OleDbConnection(connection)
                            updateConn.Open()
                            Using updateCmd As New OleDb.OleDbCommand("UPDATE tbStokResim SET pResim = ? WHERE nStokResimID = ?", updateConn)
                                updateCmd.Parameters.AddWithValue("?", base64)
                                updateCmd.Parameters.AddWithValue("?", nStokResimID)
                                updateCmd.ExecuteNonQuery()
                            End Using
                        End Using
                    Catch
                        ' Cache kaydetme hatası - sessizce geç
                    End Try
                    
                    Return base64
                End If
                
                ' İndirme başarısız olsa bile URL'yi döndür (UI URL'yi gösterebilir)
                Return yol
            End If
            
        Catch ex As Exception
            ' Hata durumunda Nothing döndür
        End Try
        
        Return Nothing
    End Function
    
    ''' <summary>
    ''' URL'den resmi indir ve Base64'e çevir
    ''' </summary>
    Private Function DownloadImageAsBase64(url As String) As String
        Try
            Using client As New System.Net.WebClient()
                client.Headers.Add("User-Agent", "BarkodMagaza/1.0")
                Dim imageBytes As Byte() = client.DownloadData(url)
                If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                    Return Convert.ToBase64String(imageBytes)
                End If
            End Using
        Catch ex As Exception
            ' İndirme hatası - sessizce geç
        End Try
        Return Nothing
    End Function

    ' GridView CustomUnboundColumnData - Lazy Loading

    ' Form kapanırken cache'i temizle

    ' ===== AI İÇERİK OLUŞTURMA =====
    Private Sub MenuItemAIIcerik_Click(sender As Object, e As EventArgs) Handles MenuItemAIIcerik.Click
        Try
            ' Seçili satırı al
            Dim rowHandle As Integer = GridView1.FocusedRowHandle
            If rowHandle < 0 Then
                MessageBox.Show("Lütfen bir ürün seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Seçili satırdan bilgileri al
            Dim nStokID As Integer = Convert.ToInt32(GridView1.GetRowCellValue(rowHandle, "nStokID"))
            Dim sModel As String = GridView1.GetRowCellValue(rowHandle, "sModel").ToString()
            Dim sAciklama As String = GridView1.GetRowCellValue(rowHandle, "sAciklama").ToString()

            ' Onay al
            Dim result As DialogResult = MessageBox.Show(
                "Seçili ürün için AI içerik oluşturulacak:" & vbCrLf & vbCrLf &
                "Model: " & sModel & vbCrLf &
                "Ürün: " & sAciklama & vbCrLf & vbCrLf &
                "✅ Detaylı Açıklama" & vbCrLf &
                "✅ Kısa Açıklama" & vbCrLf &
                "✅ Ürün Özellikleri" & vbCrLf &
                "✅ Bakım Talimatları" & vbCrLf &
                "✅ SEO Bilgileri" & vbCrLf &
                "✅ Beden Tablosu" & vbCrLf & vbCrLf &
                "Devam etmek istiyor musunuz?",
                "🤖 AI İçerik Oluştur",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' AI işlemi başlat
                Me.Cursor = Cursors.WaitCursor
                Application.DoEvents()

                Dim aiService As New AIService()

                ' Ürün verilerini hazırla
                Dim productData As New Dictionary(Of String, Object)
                productData("sAciklama") = sAciklama
                productData("sModel") = sModel
                productData("sKodu") = sModel
                productData("sMarka") = ""
                productData("sKategori") = ""
                productData("sCinsiyet") = ""
                productData("sYasGrubu") = ""
                productData("sKumasBilgisi") = ""
                productData("sRenkler") = ""
                productData("sBedenler") = ""

                ' AI içerik oluştur
                Dim completeContent As Dictionary(Of String, String) = aiService.GenerateCompleteContent(productData)

                Me.Cursor = Cursors.Default

                If completeContent("success") = "true" Then
                    ' Veritabanına kaydet
                    SaveAIContent(sModel, completeContent, aiService)

                    ' Başarı mesajı
                    Dim contentScore As Integer = aiService.CalculateContentScore(completeContent)
                    MessageBox.Show(
                        "✅ AI içerik başarıyla oluşturuldu ve kaydedildi!" & vbCrLf & vbCrLf &
                        "📊 İçerik Puanı: " & contentScore & "/100" & vbCrLf & vbCrLf &
                        "Ürün: " & sAciklama,
                        "Başarılı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
                Else
                    Dim errorMsg As String = "AI içerik oluşturulamadı!"
                    If completeContent.ContainsKey("error") Then
                        errorMsg &= vbCrLf & vbCrLf & "Hata: " & completeContent("error")
                    End If
                    MessageBox.Show(errorMsg, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("Hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaveAIContent(sModel As String, content As Dictionary(Of String, String), aiService As AIService)
        Using conn As New OleDb.OleDbConnection(connection)
            conn.Open()

            Dim aciklama As String = If(content.ContainsKey("description"), content("description"), "")
            Dim kisaAciklama As String = If(content.ContainsKey("shortDescription"), content("shortDescription"), "")
            Dim ozellikler As String = If(content.ContainsKey("featuresHtml"), content("featuresHtml"), "")
            Dim bakimTalimati As String = If(content.ContainsKey("careInstructions"), content("careInstructions"), "")
            Dim seoBaslik As String = If(content.ContainsKey("seoTitle"), content("seoTitle"), "")
            Dim metaAciklama As String = If(content.ContainsKey("metaDescription"), content("metaDescription"), "")
            Dim anahtarKelimeler As String = If(content.ContainsKey("keywords"), content("keywords"), "")
            ' Beden tablosu kaldırıldı - frm_AI_TopluIslem'deki checkbox ile kontrol edilir
            Dim bedenTablosu As String = ""
            Dim icerikPuani As Integer = aiService.CalculateContentScore(content)

            ' tbStokUzunNot güncelle
            Dim checkCmd As New OleDb.OleDbCommand("SELECT COUNT(*) FROM tbStokUzunNot WHERE sModel = ?", conn)
            checkCmd.Parameters.AddWithValue("?", sModel)
            Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If exists > 0 Then
                Dim updateCmd As New OleDb.OleDbCommand(
                    "UPDATE tbStokUzunNot SET sUzunNot = ?, dteSonUpdateTarihi = ? WHERE sModel = ?", conn)
                updateCmd.Parameters.AddWithValue("?", aciklama)
                updateCmd.Parameters.AddWithValue("?", DateTime.Now)
                updateCmd.Parameters.AddWithValue("?", sModel)
                updateCmd.ExecuteNonQuery()
            Else
                Dim insertCmd As New OleDb.OleDbCommand(
                    "INSERT INTO tbStokUzunNot (sModel, sUzunNot, dteSonUpdateTarihi) VALUES (?, ?, ?)", conn)
                insertCmd.Parameters.AddWithValue("?", sModel)
                insertCmd.Parameters.AddWithValue("?", aciklama)
                insertCmd.Parameters.AddWithValue("?", DateTime.Now)
                insertCmd.ExecuteNonQuery()
            End If

            ' tbStokAIIcerik güncelle
            Try
                Dim checkAI As New OleDb.OleDbCommand("SELECT COUNT(*) FROM tbStokAIIcerik WHERE sModel = ?", conn)
                checkAI.Parameters.AddWithValue("?", sModel)
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
                    updateAI.Parameters.AddWithValue("?", sModel)
                    updateAI.ExecuteNonQuery()
                Else
                    Dim insertAI As New OleDb.OleDbCommand(
                        "INSERT INTO tbStokAIIcerik (sModel, sUzunNot, sKisaAciklama, sOzelliklerHTML, " &
                        "sKullanimTalimati, sSEOBaslik, sMetaDescription, sAnahtarKelimeler, sBedenTablosu, " &
                        "nIcerikPuani, dteOlusturmaTarihi, dteGuncellemeTarihi) " &
                        "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", conn)
                    insertAI.Parameters.AddWithValue("?", sModel)
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

            ' tbStok.bAIIcerikVar = 1 yap
            Try
                Dim updateStok As New OleDb.OleDbCommand("UPDATE tbStok SET bAIIcerikVar = 1 WHERE sModel = ?", conn)
                updateStok.Parameters.AddWithValue("?", sModel)
                updateStok.ExecuteNonQuery()
            Catch
            End Try
        End Using
    End Sub

    ''' <summary>
    ''' Sil butonu - secili stoklari nStokID ile siler
    ''' </summary>
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        If GridView1.SelectedRowsCount = 0 Then
            XtraMessageBox.Show("Silmek icin en az bir kayit secmelisiniz!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        
        If XtraMessageBox.Show("Secili " & GridView1.SelectedRowsCount & " kaydi silmek istediginize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        
        Dim silinenler As Integer = 0
        Dim silinemeyen As Integer = 0
        Dim arr As Integer() = GridView1.GetSelectedRows()
        
        Using conn As New OleDb.OleDbConnection(connection)
            conn.Open()
            
            For Each i As Integer In arr
                Try
                    Dim dr As DataRow = GridView1.GetDataRow(i)
                    If dr IsNot Nothing Then
                        Dim nStokID As Long = CLng(dr("nStokID"))
                        
                        ' Stok hareketi kontrolu
                        Dim cmdCheck As New OleDb.OleDbCommand("SELECT COUNT(*) FROM tbStokFisiDetayi WHERE nStokID = " & nStokID, conn)
                        Dim hareketSayisi As Integer = CInt(cmdCheck.ExecuteScalar())
                        
                        If hareketSayisi = 0 Then
                            ' sModel'i al
                            Dim cmdModel As New OleDb.OleDbCommand("SELECT sModel FROM tbStok WHERE nStokID = " & nStokID, conn)
                            Dim sModel As String = CStr(cmdModel.ExecuteScalar())
                            
                            ' Silme islemleri
                            Dim cmd As New OleDb.OleDbCommand("", conn)
                            
                            cmd.CommandText = "DELETE FROM tbStokSinifi WHERE nStokID = " & nStokID
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "DELETE FROM tbStokBarkodu WHERE nStokID = " & nStokID
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "DELETE FROM tbStokFiyati WHERE nStokID = " & nStokID
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "DELETE FROM tbStokBirimCevrimi WHERE nStokID = " & nStokID
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "DELETE FROM tbStokMuhasebeEntegrasyon WHERE nStokID = " & nStokID
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "DELETE FROM tbStokOdemePlani WHERE nStokID = " & nStokID
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "DELETE FROM tbStokSayim WHERE nStokID = " & nStokID
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "DELETE FROM tbStokDil WHERE nStokID = " & nStokID
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "DELETE FROM tbStokAciklama WHERE nStokID = " & nStokID
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "DELETE FROM tbStokUzunNot WHERE sModel = '" & sModel & "'"
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "DELETE FROM tbStokResim WHERE sModel = '" & sModel & "'"
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "DELETE FROM tbKoliDagilimi WHERE nStokID = " & nStokID
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "DELETE FROM tbStok WHERE nStokID = " & nStokID
                            cmd.ExecuteNonQuery()
                            
                            silinenler += 1
                        Else
                            silinemeyen += 1
                        End If
                    End If
                Catch ex As Exception
                    silinemeyen += 1
                End Try
            Next
        End Using
        
        Dim mesaj As String = "Silinen: " & silinenler
        If silinemeyen > 0 Then
            mesaj &= vbCrLf & "Silinemeyen (hareket var): " & silinemeyen
        End If
        XtraMessageBox.Show(mesaj, "Sonuc", MessageBoxButtons.OK, MessageBoxIcon.Information)
        
        ' Listeyi yenile
        ara()
    End Sub

End Class